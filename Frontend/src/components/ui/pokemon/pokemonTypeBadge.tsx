import { Image } from '@fluentui/react-components';
import { useState, type JSX } from 'react';
import { Link } from 'react-router-dom';
import type { PokemonBasicDto } from '../../../types/pokemon';

export const typeColors: Record<string, string> = {
  normal: 'bg-stone-600',
  fighting: 'bg-red-700',
  flying: 'bg-sky-600',
  poison: 'bg-purple-700',
  ground: 'bg-amber-700',
  rock: 'bg-yellow-700',
  bug: 'bg-lime-700',
  ghost: 'bg-indigo-800',
  steel: 'bg-slate-600',
  fire: 'bg-orange-600',
  water: 'bg-blue-700',
  grass: 'bg-green-700',
  electric: 'bg-yellow-600',
  psychic: 'bg-pink-700',
  ice: 'bg-cyan-600',
  dragon: 'bg-indigo-700',
  dark: 'bg-neutral-900',
  fairy: 'bg-pink-600',
};

type PokemonTypeBadgeProps = {
  type: PokemonBasicDto;
  clickable?: boolean;
};

const PokemonTypeBadge = ({ type, clickable }: PokemonTypeBadgeProps) => {
  const colorClass = typeColors[type.name.toLowerCase()] || 'bg-gray-500';
  const [svgPath, setSvgPath] = useState(undefined);

  import(`../../../assets/${type.name.toLowerCase()}.svg`)
    .then((image) => setSvgPath(image.default))
    .catch((err) => console.error('SVG not found', err));
  const link = clickable ? `/type/${type.id}` : '';

  let returnItem: JSX.Element | null = null;
  if (clickable) {
    returnItem = (
      <Link
        to={link}
        className={`px-2 py-1.5 flex items-center rounded text-white text-xs font-semibold ${colorClass}`}
      >
        <Image src={svgPath} alt={type.name} width={14} height={14} className="inline-block mr-1" />
        {type.name}
      </Link>
    );
  }

  return (
    returnItem || (
      <div
        className={`px-2 py-1.5 flex items-center rounded text-white text-xs font-semibold ${colorClass}`}
      >
        <Image src={svgPath} alt={type.name} width={14} height={14} className="inline-block mr-1" />
        {type.name}
      </div>
    )
  );
};

export default PokemonTypeBadge;
