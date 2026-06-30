import { Divider, makeStyles, tokens } from '@fluentui/react-components';
import type { PokemonDtoMin } from '../../../types/pokemon';
import PokemonGrid from './pokemonGrid';

const useFluentStyles = makeStyles({
  card: {
    backgroundColor: tokens.colorNeutralBackground3,
    borderRadius: tokens.borderRadiusXLarge,
  },
});

const PokemonEvolutionChain = ({ pokemons, id }: { pokemons: PokemonDtoMin[]; id: number }) => {
  const fluentStyle = useFluentStyles();
  return (
    <div className={`flex flex-col gap-2 p-2 ${fluentStyle.card}`}>
      <Divider>Evolution chain & variants</Divider>
      <PokemonGrid
        pokemons={pokemons}
        options={{ gap: 8, itemHeight: 220 }}
        className="max-h-[70dvh] md:max-h-fit"
        selected={id}
      />
    </div>
  );
};

export default PokemonEvolutionChain;
