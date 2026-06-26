import { Card, CardFooter, CardPreview, Image } from '@fluentui/react-components';
import { useEffect, useState } from 'react';
import type { PokemonDtoMin } from '../../types/pokemon';

type PokemonCardProps = {
  pokemon: PokemonDtoMin;
  height?: number;
};

const resolveAssets = (id: number): string => {
  const idStr = id.toString().padStart(5, '0');
  const baseUrl = import.meta.env.VITE_ASSETS_URL;
  return `${baseUrl}pokemons/${idStr}.png`;
};

const PokemonCard = ({ pokemon, height }: PokemonCardProps) => {
  const [showImg, setShowImg] = useState(false);

  useEffect(() => {
    const t = setTimeout(() => setShowImg(true), 100);
    return () => clearTimeout(t);
  }, []);

  return (
    <Card
      className="w-full border border-(--colorNeutralStroke2) transition-all duration-200 hover:shadow-lg hover:-translate-y-1 hover:scale-[1.02] hover:border-(--colorNeutralStroke1) hover:border-solid hover:cursor-pointer"
      style={{ height }}
      key={pokemon.id}
    >
      <CardPreview className="h-[70%] p-2">
        {showImg && (
          <Image src={resolveAssets(pokemon.id)} alt={pokemon.name} loading="lazy" fit="contain" />
        )}
      </CardPreview>
      <CardFooter className="h-[30%] flex flex-col! items-center justify-center">
        {pokemon.name}
        <div className="flex items-center justify-around w-full">
          {pokemon.types.map((type, index) => (
            <div key={index} className="text-sm font-medium">
              {type.toString()}
            </div>
          ))}
        </div>
      </CardFooter>
    </Card>
  );
};

export default PokemonCard;
