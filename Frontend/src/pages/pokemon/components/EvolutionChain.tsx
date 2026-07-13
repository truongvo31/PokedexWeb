import { Divider } from '@fluentui/react-components';
import type { PokemonDtoMin } from '../../../types/pokemon';
import PokemonGrid from './PokemonGrid';

const PokemonEvolutionChain = ({ pokemons, id }: { pokemons: PokemonDtoMin[]; id: number }) => {
  return (
    pokemons &&
    id && (
      <div className="flex flex-col gap-2">
        <Divider>Evolution chain & variants</Divider>
        <PokemonGrid
          pokemons={pokemons}
          options={{ gap: 8, itemHeight: 220 }}
          className="max-h-[70dvh] md:max-h-fit"
          selected={id}
        />
      </div>
    )
  );
};

export default PokemonEvolutionChain;
