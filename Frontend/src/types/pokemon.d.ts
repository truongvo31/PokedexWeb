export type PokemonDto = PokemonBasicDto & {
  height: number;
  weight: number;
  title: string;
  isLegendary: boolean;
  isMythical: boolean;
  captureRate: number;
  genderRate: number;
  stats: PokemonDtoStat[];
  types: PokemonBasicDto[];
  abilities: PokemonBasicDto[];
  generations: PokemonBasicDto[];
};

export type PokemonDtoStat = PokemonBasicDto & {
  value: number;
  betterThan: number;
  allPokemonsCount: number;
};

export type PokemonBasicDto = {
  id: number;
  name: string;
};

export type PokemonNextPrev = {
  prev?: PokemonBasicDto;
  next?: PokemonBasicDto;
};

export type PokemonDtoMin = Pick<PokemonDto, 'id' | 'name' | 'types'>;
