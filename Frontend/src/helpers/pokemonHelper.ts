export const resolveAssets = (id: number): string => {
  const idStr = id.toString().padStart(5, '0');
  const baseUrl = import.meta.env.VITE_ASSETS_URL;
  return `${baseUrl}pokemons/${idStr}.webp`;
};

export const formatHeight = (dm: number) => {
  // Pokémon API height is in decimeters
  const meters = dm / 10;

  // Convert meters → total inches
  const totalInches = meters * 39.3701;

  const feet = Math.floor(totalInches / 12);
  const inches = Math.round(totalInches % 12);

  return `${meters.toFixed(1)} m ( ${feet}'${inches}" )`;
};

export const formatWeight = (hg: number) => {
  // Pokémon API weight is in hectograms
  const kg = hg / 10;

  // Convert kg → pounds
  const lbs = kg * 2.20462;

  return `${kg.toFixed(1)} kg ( ${lbs.toFixed(1)} lbs )`;
};
