import { Button, Image, makeStyles, tokens } from '@fluentui/react-components';
import {
  NextFrame20Filled,
  NextFrame20Regular,
  Previous20Regular,
  PreviousFrame20Filled,
  bundleIcon,
} from '@fluentui/react-icons';
import { useQuery } from '@tanstack/react-query';
import { useEffect } from 'react';
import { Link, useParams } from 'react-router-dom';
import PokemonEvolutionChain from '../../components/ui/pokemon/pokemonEvolutionChain';
import PokemonInfo from '../../components/ui/pokemon/pokemonInfo';
import PokemonMiscellaneous from '../../components/ui/pokemon/pokemonMiscellaneous';
import PokemonStats from '../../components/ui/pokemon/pokemonStats';
import PokemonTypeEfficacy from '../../components/ui/pokemon/pokemonTypeEfficacy';
import api from '../../helpers/apiHelper';
import { resolveAssets } from '../../helpers/pokemonHelper';
import { useLoading } from '../../stores/useLoading';
import type {
  PokemonDto,
  PokemonDtoMin,
  PokemonNextPrev,
  PokemonTypeEfficacyDto,
} from '../../types/pokemon';

const PrevIcon = bundleIcon(PreviousFrame20Filled, Previous20Regular);
const NextIcon = bundleIcon(NextFrame20Filled, NextFrame20Regular);

type QueryData = {
  pokemon: PokemonDto;
  adjacent: PokemonNextPrev;
  evolutionChain: PokemonDtoMin[];
  typeEfficacy: PokemonTypeEfficacyDto[];
};

const useFluentStyles = makeStyles({
  card: {
    backgroundColor: tokens.colorNeutralBackground3,
    borderRadius: tokens.borderRadiusXLarge,
  },
});

const PokemonDetails = () => {
  const { id } = useParams<{ id: string }>();
  const { setLoading } = useLoading();
  const { data, isLoading } = useQuery<QueryData>({
    queryKey: ['pokemons', id],
    queryFn: async () => {
      const [pokemonRequest, adjacentRequest, evolutionChainRequest, typeEfficacyRequest] =
        await Promise.all([
          api.$get<PokemonDto>(`pokemon/${id}`),
          api.$get<PokemonNextPrev>(`pokemon/${id}/next_prev`),
          api.$get<PokemonDtoMin[]>(`pokemon/${id}/evolution_chain`),
          api.$get<PokemonTypeEfficacyDto[]>(`pokemon/${id}/type_efficacies`),
        ]);
      return {
        pokemon: pokemonRequest.data ?? ({} as PokemonDto),
        adjacent: adjacentRequest.data ?? ({} as PokemonNextPrev),
        evolutionChain: evolutionChainRequest.data ?? [],
        typeEfficacy: typeEfficacyRequest.data ?? [],
      };
    },
  });
  const fluentStyle = useFluentStyles();

  useEffect(() => {
    setLoading(isLoading);
  }, [isLoading, setLoading]);

  const pokemonId = parseInt(id || '0', 10);

  return (
    <div className="flex flex-col h-full">
      <div className="px-4 md:px-6 lg:px-8 py-2 grid grid-cols-1 md:grid-cols-[1fr_auto] gap-2 items-center">
        <nav>
          <Link to="/">Pokemons</Link>
          <span className="mx-2">/</span>
          <span className="text-gray-400">{data?.pokemon.name}</span>
        </nav>
        <div className="flex gap-2 justify-center">
          {data?.adjacent.prev && (
            <Link to={`/pokemon/${data.adjacent.prev.id}`}>
              <Button className="gap-2" icon={<PrevIcon />}>
                <Image
                  src={resolveAssets(data.adjacent.prev.id)}
                  alt="Pokemon"
                  loading="lazy"
                  className="size-5"
                />
                {data.adjacent.prev.name}
              </Button>
            </Link>
          )}
          {data?.adjacent.next && (
            <Link to={`/pokemon/${data.adjacent.next.id}`}>
              <Button className="gap-2" icon={<NextIcon />} iconPosition="after">
                {data.adjacent.next.name}
                <Image
                  src={resolveAssets(data.adjacent.next.id)}
                  alt="Pokemon"
                  loading="lazy"
                  className="size-5"
                />
              </Button>
            </Link>
          )}
        </div>
      </div>
      <div className="px-4 md:px-6 lg:px-8 flex-1 overflow-auto flex flex-col gap-2">
        <div
          className={`grid gap-2 grid-cols-1 md:grid-cols-3 xl:grid-cols-[2fr_3fr_2fr] ${fluentStyle.card} p-2`}
        >
          <div className="order-2 md:order-1">
            {data?.pokemon && <PokemonInfo pokemon={data.pokemon} />}
          </div>
          <div className="order-1 md:order-2 flex items-center justify-center">
            <Image src={resolveAssets(pokemonId)} alt="Pokemon" loading="lazy" className="w-100" />
          </div>
          <div className="order-3">{data?.pokemon && <PokemonStats pokemon={data.pokemon} />}</div>
        </div>

        <PokemonEvolutionChain pokemons={data?.evolutionChain || []} id={pokemonId} />

        <div className="grid gap-2 grid-cols-1 md:grid-cols-[2fr_1fr]">
          <PokemonTypeEfficacy typeEfficacy={data?.typeEfficacy || []} />
          {data?.pokemon && <PokemonMiscellaneous pokemon={data.pokemon} />}
        </div>
      </div>
    </div>
  );
};

export default PokemonDetails;
