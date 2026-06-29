import { Button, Image } from '@fluentui/react-components';
import {
  NextFrame20Filled,
  NextFrame20Regular,
  Previous20Regular,
  PreviousFrame20Filled,
  bundleIcon,
} from '@fluentui/react-icons';
import { useQuery } from '@tanstack/react-query';
import { Link, useParams } from 'react-router-dom';
import PokemonInfo from '../../components/ui/pokemon/pokemonInfo';
import PokemonStats from '../../components/ui/pokemon/pokemonStats';
import api from '../../helpers/apiHelper';
import { resolveAssets } from '../../helpers/pokemonHelper';
import type { PokemonDto, PokemonNextPrev } from '../../types/pokemon';

const PrevIcon = bundleIcon(PreviousFrame20Filled, Previous20Regular);
const NextIcon = bundleIcon(NextFrame20Filled, NextFrame20Regular);

type QueryData = {
  pokemon: PokemonDto;
  adjacent: PokemonNextPrev;
};

const PokemonDetails = () => {
  const { id } = useParams<{ id: string }>();
  const { data } = useQuery<QueryData>({
    queryKey: ['pokemons', id],
    queryFn: async () => {
      const [pokemonRequest, adjacentRequest] = await Promise.all([
        api.$get<PokemonDto>(`pokemon/${id}`),
        api.$get<PokemonNextPrev>(`pokemon/${id}/next_prev`),
      ]);
      return {
        pokemon: pokemonRequest.data!,
        adjacent: adjacentRequest.data!,
      };
    },
  });

  const pokemonId = parseInt(id || '0', 10);

  return (
    <div className="flex flex-col h-full">
      <div className="px-8 py-2 grid grid-cols-1 md:grid-cols-[1fr_auto] gap-2 items-center">
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
                  className="w-5 h-5"
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
                  className="w-5 h-5"
                />
              </Button>
            </Link>
          )}
        </div>
      </div>
      <div className="px-8 flex-1 overflow-auto">
        <div className="grid gap-2 grid-cols-1 md:grid-cols-3 xl:grid-cols-[2fr_3fr_2fr]">
          <div className="order-2 md:order-1">
            {data?.pokemon && <PokemonInfo pokemon={data.pokemon} />}
          </div>
          <div className="order-1 md:order-2 flex items-center justify-center">
            <Image src={resolveAssets(pokemonId)} alt="Pokemon" loading="lazy" className="w-100" />
          </div>
          <div className="order-3">{data?.pokemon && <PokemonStats pokemon={data.pokemon} />}</div>
        </div>
      </div>
    </div>
  );
};

export default PokemonDetails;
