import { Card, CardFooter, CardPreview, Image } from '@fluentui/react-components';
import { useEffect, useState } from 'react';
import { Link } from 'react-router-dom';
import type { PokemonDtoMin } from '../../../types/pokemon';
import PokemonTypeBadge from './pokemonTypeBadge';

type PokemonCardProps = {
  pokemon: PokemonDtoMin;
  height?: number;
};

export const resolveAssets = (id: number): string => {
  const idStr = id.toString().padStart(5, '0');
  const baseUrl = import.meta.env.VITE_ASSETS_URL;
  return `${baseUrl}pokemons/${idStr}.png`;
};

const fallbackAsset = `${import.meta.env.VITE_ASSETS_URL}pokemons/placeholder.png`;

const PokemonCard = ({ pokemon, height }: PokemonCardProps) => {
  const [showImg, setShowImg] = useState(false);

  useEffect(() => {
    const t = setTimeout(() => setShowImg(true), 100);
    return () => clearTimeout(t);
  }, []);

  const normalizedTypes = pokemon.types.map((type) => ({
    id: 0,
    name: type.toString(),
  }));

  return (
    <Link to={`/pokemon/${pokemon.id}`}>
      <Card
        className="w-full border border-(--colorNeutralStroke2) transition-all duration-200 hover:shadow-lg hover:-translate-y-1 hover:scale-[1.02] hover:border-(--colorCompoundBrandForeground1) hover:border-2 hover:cursor-pointer"
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
              onError={(e) => (e.currentTarget.src = fallbackAsset)}
            />
          )}
        </CardPreview>
        <CardFooter className="h-[30%] flex flex-col! items-center justify-center">
          {pokemon.name}
          <div className="flex gap-2 items-center justify-center w-full">
            {normalizedTypes.map((type, index) => (
              // <div key={index} className="text-sm font-medium">
              //   {type.toString()}
              // </div>
              <PokemonTypeBadge key={index} type={type} />
            ))}
          </div>
        </CardFooter>
      </Card>
    </Link>
  );
};

export default PokemonCard;
