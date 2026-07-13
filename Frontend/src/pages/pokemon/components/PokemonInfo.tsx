import { Button, Divider, Text } from '@fluentui/react-components';
import { formatHeight, formatWeight } from '../../../helpers/pokemonHelper';
import type { PokemonDto } from '../../../types/pokemon';
import PokemonTypeBadge from './TypeBadge';

const PokemonInfo = ({ pokemon }: { pokemon: PokemonDto }) => {
  return (
    pokemon && (
      <div className="flex flex-col gap-2 h-full">
        <Divider>Pokemon Info</Divider>
        <div className="grid grid-cols-[auto_1fr] gap-4 h-full *:self-center">
          <Text align="end">ID :</Text>
          <Text>{pokemon.id}</Text>

          <Text align="end">Name :</Text>
          <Text>{pokemon.name}</Text>

          <Text align="end">Title :</Text>
          <Text>{pokemon.title}</Text>

          <Text align="end">Height :</Text>
          <Text>{formatHeight(pokemon.height)}</Text>

          <Text align="end">Weight :</Text>
          <Text>{formatWeight(pokemon.weight)}</Text>

          <Text align="end">Abilities :</Text>
          <div className="flex flex-wrap gap-2">
            {pokemon.abilities.map((ability) => (
              <Button key={ability.id} className="h-fit">
                {ability.name}
              </Button>
            ))}
          </div>

          <Text align="end">Types :</Text>
          <div className="flex flex-wrap gap-2">
            {pokemon.types.map((type) => (
              <PokemonTypeBadge key={type.id} type={type} link={`/types/${type.id}`} />
            ))}
          </div>
        </div>
      </div>
    )
  );
};

export default PokemonInfo;
