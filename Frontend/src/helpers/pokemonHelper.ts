export const resolveAssets = (id: number): string => {
  const idStr = id.toString().padStart(5, '0');
  const baseUrl = import.meta.env.VITE_ASSETS_URL as string;
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

export const getCaptureTextColor = (
  rate: number,
): [
  string,
  'brand' | 'danger' | 'important' | 'informative' | 'severe' | 'subtle' | 'success' | 'warning',
] => {
  if (rate >= 200) return [`Very Easy (${rate})`, 'success'];
  if (rate >= 150) return [`Easy (${rate})`, 'informative'];
  if (rate >= 100) return [`Medium (${rate})`, 'warning'];
  if (rate >= 50) return [`Hard (${rate})`, 'important'];
  if (rate >= 10) return [`Very Hard (${rate})`, 'danger'];
  return [`Extreme (${rate})`, 'severe'];
};

export const getGenderRatioTextColor = (
  genderRate: number,
): {
  gender: 'male' | 'female' | 'genderless';
  color: 'brand' | 'danger' | 'informative';
  rate?: number;
}[] => {
  if (genderRate === -1) return [{ gender: 'genderless', color: 'informative' }];
  const maleRate = (1 - genderRate / 8.0) * 100.0;
  const femaleRate = (genderRate / 8.0) * 100.0;
  return [
    { gender: 'male', color: 'brand', rate: maleRate },
    { gender: 'female', color: 'danger', rate: femaleRate },
  ];
};
