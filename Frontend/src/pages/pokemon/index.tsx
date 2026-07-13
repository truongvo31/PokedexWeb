import { useQuery } from '@tanstack/react-query';
import { useEffect, useMemo, useState } from 'react';
import PageHeader from '../../components/pageHeader';
import api from '../../helpers/apiHelper';
import { loadStateFromSession } from '../../helpers/storageHelper';
import useLoading from '../../stores/useLoading';
import useMessages from '../../stores/useMessages';
import type { PokemonDto } from '../../types/pokemon';
import HomeSearchButton, { type FilterResult } from './components/HomeSearchButton';
import PokemonGrid from './components/PokemonGrid';

const PokemonPage = () => {
  const { setLoading } = useLoading();
  const { $error } = useMessages();
  const [filter, setFilter] = useState<FilterResult | null>(null);

  const { data: pokemons, isLoading } = useQuery<PokemonDto[]>({
    queryKey: ['pokemons'],
    queryFn: async () => {
      const { error, message, data } = await api.$get<PokemonDto[]>('pokemon');
      if (error) {
        void $error('Fetch error', message);
        throw new Error(message);
      }
      return data;
    },
  });

  const lastViewedPokemonId = loadStateFromSession<number>('lastViewedPokemonId');

  useEffect(() => {
    setLoading(isLoading, isLoading ? 'Loading Pokemons...' : undefined);
  }, [isLoading, setLoading]);

  const filteredPokemons = useMemo(() => {
    if (!pokemons) return [];
    if (!filter) return pokemons;
    const filtered = pokemons.filter((pokemon) => {
      const matchesName = filter.searchName
        ? (() => {
            const searchLower = filter.searchName.toLowerCase();
            const nameLower = pokemon.name.toLowerCase();

            if (searchLower.includes('%')) {
              // SQL wildcard pattern: convert to regex
              const pattern = searchLower.replace(/%/g, '.*');
              return new RegExp(`^${pattern}$`).test(nameLower);
            } else {
              // Exact match (case-insensitive)
              return nameLower === searchLower;
            }
          })()
        : true;
      // const matchesRarity = filter.searchRarity.length > 0 ? filter.searchRarity.includes(pokemon.rarity) : true;
      const matchesType =
        filter.searchTypes.length > 0
          ? pokemon.types.some((t) =>
              filter.searchTypes.includes((t as unknown as string).toLowerCase()),
            )
          : true;
      return matchesName && matchesType;
    });
    return filtered;
  }, [pokemons, filter]);

  return (
    <div className="h-full flex flex-col">
      <PageHeader pageTitle="Pokemons">
        <HomeSearchButton onSubmit={setFilter} />
      </PageHeader>
      <PokemonGrid
        className="flex-1 px-6"
        pokemons={filteredPokemons}
        options={{ gap: 8, itemHeight: 220 }}
        jumpToPokemonId={lastViewedPokemonId}
        jumpBehavior="smooth"
      />
    </div>
  );
};

export default PokemonPage;
