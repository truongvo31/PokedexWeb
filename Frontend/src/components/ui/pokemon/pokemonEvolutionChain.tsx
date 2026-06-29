import { Divider } from '@fluentui/react-components';
import type { PokemonDtoMin } from '../../../types/pokemon';
import PokemonGrid from './pokemonGrid';

const PokemonEvolutionChain = ({ pokemons, id }: { pokemons: PokemonDtoMin[]; id: number }) => {
  return (
    <div className="flex flex-col gap-2">
      <Divider>Evolution chain & variants</Divider>
      <PokemonGrid
        pokemons={pokemons}
        options={{ gap: 8, itemHeight: 220 }}
        className="h-[70dvh] md:h-auto"
        selected={id}
      />
    </div>
  );
};

export default PokemonEvolutionChain;
