import { Input } from '@fluentui/react-components';
import { bundleIcon, Search20Filled, Search20Regular } from '@fluentui/react-icons';
import { useQuery } from '@tanstack/react-query';
import { useEffect, useState } from 'react';
import PokemonGrid from '../../components/ui/pokemon/pokemonGrid';
import api from '../../helpers/apiHelper';
import { debounce } from '../../helpers/utilsHelper';
import { useLoading } from '../../stores/useLoading';
import type { PokemonDto } from '../../types/pokemon';

const SearchIcon = bundleIcon(Search20Filled, Search20Regular);

export default function Pokemons() {
  const { setLoading } = useLoading();
  const [filteredPokemons, setFilteredPokemons] = useState<PokemonDto[]>([]);
  const { data: pokemons, isLoading } = useQuery<PokemonDto[]>({
    queryKey: ['pokemons'],
    queryFn: async () => {
      const { error, message, data } = await api.$get<PokemonDto[]>('pokemon');
      if (error) throw new Error(message);
      return data!;
    },
  });

  useEffect(() => {
    setLoading(isLoading, isLoading ? 'Loading Pokemons...' : undefined);
  }, [isLoading]);

  const searchDebounce = debounce((keyword) => {
    if (pokemons) {
      const filtered = pokemons.filter((pokemon) => pokemon.name.toLowerCase().includes(keyword));
      setFilteredPokemons(filtered);
    }
  }, 500);

  const onInputChange = (event: React.ChangeEvent<HTMLInputElement>) => {
    const searchTerm = event.target.value.toLowerCase();
    searchDebounce(searchTerm);
  };

  return (
    <div className="h-full flex flex-col gap-2">
      <div className="flex justify-between px-8 py-2 items-center gap-4">
        <h1 className="text-2xl font-bold">Pokemon List</h1>
        <Input placeholder="Search..." contentBefore={<SearchIcon />} onChange={onInputChange} />
      </div>
      <PokemonGrid
        className="flex-1 px-8"
        pokemons={filteredPokemons.length > 0 ? filteredPokemons : (pokemons ?? [])}
        options={{ gap: 8, itemHeight: 220 }}
      />
    </div>
  );
}
