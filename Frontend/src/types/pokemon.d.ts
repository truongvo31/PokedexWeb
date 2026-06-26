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

export type PokemonBasicDto = {
  id: number;
  name: string;
};

export type PokemonDtoMin = Pick<PokemonDto, 'id' | 'name' | 'types'>;
