import { Divider, ProgressBar, Text } from '@fluentui/react-components';
import { createElement, Fragment } from 'react';
import Atk from '../../../assets/stats/atk';
import Def from '../../../assets/stats/def';
import Hp from '../../../assets/stats/hp';
import SpAtk from '../../../assets/stats/spatk';
import Speed from '../../../assets/stats/spd';
import SpDef from '../../../assets/stats/spdef';
import type { PokemonDto } from '../../../types/pokemon';

const mappingStatIcon: Record<number, React.ElementType<{ size?: number; color?: string }>> = {
  1: Hp,
  2: Atk,
  3: Def,
  4: SpAtk,
  5: SpDef,
  6: Speed,
};

const PokemonStats = ({ pokemon }: { pokemon: PokemonDto }) => {
  return (
    <div className="flex flex-col gap-2 h-full">
      <Divider>Pokemon Stats</Divider>
      <div className="grid grid-cols-[auto_1fr] gap-4 h-full *:self-center">
        {pokemon.stats.map((stat) => (
          <Fragment key={stat.id}>
            <div className="flex gap-2 items-center">
              {createElement(mappingStatIcon[stat.id], { size: 16, color: 'currentColor' })}
              <Text>{stat.value}</Text>
              <Text>{stat.name}</Text>
            </div>
            <ProgressBar value={stat.betterThan} max={stat.allPokemonsCount} thickness="large" />
          </Fragment>
        ))}
      </div>
    </div>
  );
};

export default PokemonStats;
