import { Button, Image, makeStyles, Text, tokens } from '@fluentui/react-components';
import {
  bundleIcon,
  NextFrame20Filled,
  NextFrame20Regular,
  Previous20Regular,
  PreviousFrame20Filled,
} from '@fluentui/react-icons';
import { useQuery } from '@tanstack/react-query';
import { useEffect } from 'react';
import { Link, useParams } from 'react-router-dom';
import api from '../../helpers/apiHelper';
import { resolveAssets } from '../../helpers/pokemonHelper';
import { saveStateToSession } from '../../helpers/storageHelper';
import useLoading from '../../stores/useLoading';
import type {
  EncounterDto,
  EncounterGameNode,
  PokemonDto,
  PokemonDtoMin,
  PokemonNextPrev,
  PokemonTypeEfficacyDto,
} from '../../types/pokemon';
import PokemonEncounters from './components/Encounters';
import PokemonEvolutionChain from './components/EvolutionChain';
import PokemonMiscellaneous from './components/Miscellaneous';
import PokemonInfo from './components/PokemonInfo';
import PokemonStats from './components/PokemonStats';
import PokemonTypeEfficacies from './components/TypeEfficacies';

type QueryData = {
  pokemon: PokemonDto;
  adjacent: PokemonNextPrev;
  evolutionChain: PokemonDtoMin[];
  typeEfficacy: PokemonTypeEfficacyDto[];
  encounters: EncounterGameNode[];
};

const useFluentStyles = makeStyles({
  breadcrumbLink: {
    color: tokens.colorBrandForeground1,
    textDecoration: 'none',
    ':hover': {
      textDecoration: 'underline',
    },
  },
  breakcrumbSeparator: {
    color: tokens.colorNeutralForeground3,
    margin: '0 0.5rem',
  },
  breadcrumbLinkActive: {
    color: tokens.colorNeutralForeground1,
    textDecoration: 'none',
  },
});

const PrevIcon = bundleIcon(PreviousFrame20Filled, Previous20Regular);
const NextIcon = bundleIcon(NextFrame20Filled, NextFrame20Regular);

const PokemonDetailsPage = () => {
  const fluentStyles = useFluentStyles();

  const { id: paramId } = useParams<{ id: string }>();
  const id = paramId ? parseInt(paramId, 10) : null;

  const { setLoading } = useLoading();
  const { data, isLoading } = useQuery<QueryData>({
    queryKey: ['pokemons', id],
    queryFn: async () => {
      const [
        pokemonRequest,
        adjacentRequest,
        evolutionChainRequest,
        typeEfficacyRequest,
        encountersRequest,
      ] = await Promise.all([
        api.$get<PokemonDto>(`pokemon/${id}`),
        api.$get<PokemonNextPrev>(`pokemon/${id}/next_prev`),
        api.$get<PokemonDtoMin[]>(`pokemon/${id}/evolution_chain`),
        api.$get<PokemonTypeEfficacyDto[]>(`pokemon/${id}/type_efficacies`),
        api.$get<EncounterDto>(`encounters/${id}`),
      ]);
      return {
        pokemon: pokemonRequest.data ?? ({} as PokemonDto),
        adjacent: adjacentRequest.data ?? { next: undefined, prev: undefined },
        evolutionChain: evolutionChainRequest.data ?? [],
        typeEfficacy: typeEfficacyRequest.data ?? [],
        encounters: encountersRequest.data?.inGameEncounters ?? [],
      };
    },
  });

  useEffect(() => {
    setLoading(isLoading);
  }, [isLoading, setLoading]);

  if (id !== null) {
    saveStateToSession('lastViewedPokemonId', id);
  }

  return (
    data && (
      <div className="flex flex-col h-full">
        <div className="px-4 md:px-6 lg:px-8 py-2 grid grid-cols-1 md:grid-cols-[1fr_auto] gap-2 items-center">
          <nav>
            <Link to="/">
              <Text className={fluentStyles.breadcrumbLink} weight="semibold">
                Pokemons
              </Text>
            </Link>
            <Text className={fluentStyles.breakcrumbSeparator}>/</Text>
            <Text className={fluentStyles.breadcrumbLinkActive}>{data?.pokemon.name}</Text>
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
          <div className="grid gap-2 grid-cols-1 md:grid-cols-3 xl:grid-cols-[2fr_3fr_2fr]">
            <div className="order-2 md:order-1">
              <PokemonInfo pokemon={data.pokemon} />
            </div>
            <div className="order-1 md:order-2 flex items-center justify-center p-2">
              <Image src={resolveAssets(id ?? 0)} alt="Pokemon" loading="lazy" className="w-100" />
            </div>
            <div className="order-3">
              <PokemonStats pokemon={data.pokemon} />
            </div>
          </div>

          <PokemonEvolutionChain pokemons={data.evolutionChain} id={id ?? 0} />

          <div className="grid gap-2 grid-cols-1 md:grid-cols-[2fr_1fr]">
            <PokemonTypeEfficacies typeEfficacy={data.typeEfficacy} />
            <PokemonMiscellaneous pokemon={data.pokemon} />
          </div>

          <PokemonEncounters encounters={data.encounters} />
        </div>
      </div>
    )
  );
};

export default PokemonDetailsPage;
