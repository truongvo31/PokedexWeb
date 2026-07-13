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

export type PokemonTypeEfficacyDto = {
  multiplier: string;
  types: PokemonBasicDto[];
};

export type EncounterDto = {
  inGameEncounters: EncounterGameNode[];
  specialEncounters: EncounterGameNode[];
};

export type EncounterBasicDto = {
  id: number;
  name: string;
};

export type EncounterVersionDto = EncounterBasicDto & {
  versionGroupId: number;
};

export type EncounterGameNode = {
  game: EncounterVersionDto;
  locations: EncounterLocationNode[];
};

export type EncounterLocationNode = {
  location: EncounterBasicDto;
  methods: EncounterMethodNode[];
};

export type EncounterMethodNode = {
  method: EncounterBasicDto;
  methodDesc?: string;
  conditions: EncounterConditionNode[];
};

export type EncounterConditionNode = {
  condition?: string;
  rarity: number;
};
