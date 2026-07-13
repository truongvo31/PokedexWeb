import { Badge, Divider, Text, tokens } from '@fluentui/react-components';
import { WindowNew20Regular } from '@fluentui/react-icons';
import { Link } from 'react-router-dom';
import { getCaptureTextColor, getGenderRatioTextColor } from '../../../helpers/pokemonHelper';
import type { PokemonDto } from '../../../types/pokemon';

const PokemonMiscellaneous = ({ pokemon }: { pokemon: PokemonDto }) => {
  const legendaryTextColor = tokens.colorPaletteMarigoldBackground3;
  const mythicalTextColor = tokens.colorPaletteGrapeBorderActive;
  const genderArray = getGenderRatioTextColor(pokemon.genderRate);
  return (
    pokemon && (
      <div className="flex flex-col gap-2">
        <Divider>Miscellaneous</Divider>
        <div className="h-full">
          <div className="grid grid-cols-[auto_1fr] gap-4 *:self-center">
            <Text align="end">Rarity :</Text>
            <Text
              weight="semibold"
              style={{
                color: pokemon.isLegendary
                  ? legendaryTextColor
                  : pokemon.isMythical
                    ? mythicalTextColor
                    : 'inherit',
              }}
            >
              {pokemon.isLegendary ? 'Legendary' : pokemon.isMythical ? 'Mythical' : 'Normal'}
            </Text>

            <Text align="end">Catch Rate :</Text>
            <Badge className="w-max" color={getCaptureTextColor(pokemon.captureRate)[1]}>
              {getCaptureTextColor(pokemon.captureRate)[0]}
            </Badge>

            <Text align="end">Gender Ratio :</Text>
            <div className="flex flex-wrap gap-2 items-center">
              {genderArray.map((gender) => (
                <Badge key={gender.gender} className="w-max" color={gender.color}>
                  {gender.gender === 'genderless'
                    ? 'Genderless'
                    : `${gender.gender.charAt(0).toUpperCase() + gender.gender.slice(1)} (${gender.rate?.toFixed(1)}%)`}
                </Badge>
              ))}
            </div>

            <Text align="end">Appears In :</Text>
            <div className="flex flex-wrap gap-2 items-center">
              {pokemon.generations.map((generation) => (
                <Badge key={generation.id} className="w-max" color="brand">
                  {generation.name}
                </Badge>
              ))}
            </div>

            <Text align="end">Encounters :</Text>
            <Link to={`/pokemon/${pokemon.id}/encounters`}>
              <div className="flex gap-2 w-max" style={{ color: tokens.colorBrandForegroundLink }}>
                <Text weight="semibold" underline>
                  View Encounters
                </Text>
                <WindowNew20Regular />
              </div>
            </Link>
          </div>
        </div>
      </div>
    )
  );
};

export default PokemonMiscellaneous;
