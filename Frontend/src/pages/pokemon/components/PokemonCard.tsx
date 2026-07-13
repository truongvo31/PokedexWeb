import {
  Card,
  CardFooter,
  CardPreview,
  Image,
  makeStyles,
  tokens,
} from '@fluentui/react-components';
import { useEffect, useState } from 'react';
import { Link } from 'react-router-dom';
import FallbackAsset from '../../../assets/images/placeholder.webp';
import { resolveAssets } from '../../../helpers/pokemonHelper';
import type { PokemonDtoMin } from '../../../types/pokemon';
import PokemonTypeBadge from './TypeBadge';

type PokemonCardProps = {
  pokemon: PokemonDtoMin;
  height?: number;
  selected?: boolean;
};

const useFluentStyles = makeStyles({
  card: {
    backgroundColor: tokens.colorNeutralCardBackground,
    borderRadius: tokens.borderRadiusMedium,
    ':hover': {
      backgroundColor: tokens.colorNeutralCardBackgroundHover,
      border: `2px solid ${tokens.colorCompoundBrandForeground1}`,
    },
  },
});

const PokemonCard = ({ pokemon, height, selected }: PokemonCardProps) => {
  const [showImg, setShowImg] = useState(false);
  const fluentStyles = useFluentStyles();

  useEffect(() => {
    const t = setTimeout(() => setShowImg(true), 100);
    return () => clearTimeout(t);
  }, []);

  const normalizedTypes = pokemon.types.map((type) => ({
    id: 0,
    name: (type as unknown as string).toString(),
  }));

  const hoverClass = selected
    ? ''
    : 'w-full ' +
      'transition-all duration-200 ' +
      'hover:shadow-lg hover:scale-[1.05] ' +
      'hover:cursor-pointer';

  const selectedClass = selected ? 'border-2 border-(--colorCompoundBrandForeground1)' : '';

  return (
    <Link to={`/pokemon/${pokemon.id}`}>
      <Card
        className={`${hoverClass} ${selectedClass} ${fluentStyles.card}`}
        style={{ height }}
        key={pokemon.id}
      >
        <CardPreview className="h-[70%] p-2">
          {showImg && (
            <Image
              src={resolveAssets(pokemon.id)}
              alt={pokemon.name}
              loading="lazy"
              fit="contain"
              onError={(e) => (e.currentTarget.src = FallbackAsset)}
            />
          )}
        </CardPreview>
        <CardFooter className="h-[30%] flex flex-col! items-center justify-center">
          {pokemon.name}
          <div className="flex gap-2 items-center justify-center w-full">
            {normalizedTypes.map((type, index) => (
              <PokemonTypeBadge key={index} type={type} />
            ))}
          </div>
        </CardFooter>
      </Card>
    </Link>
  );
};

export default PokemonCard;
