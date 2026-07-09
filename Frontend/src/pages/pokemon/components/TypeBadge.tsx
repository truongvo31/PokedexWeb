import { Link } from 'react-router-dom';
import BugTypeIcon from '../../../components/icons/types/bug';
import DarkTypeIcon from '../../../components/icons/types/dark';
import DragonTypeIcon from '../../../components/icons/types/dragon';
import ElectricTypeIcon from '../../../components/icons/types/electric';
import FairyTypeIcon from '../../../components/icons/types/fairy';
import FightingTypeIcon from '../../../components/icons/types/fighting';
import FireTypeIcon from '../../../components/icons/types/fire';
import FlyingTypeIcon from '../../../components/icons/types/flying';
import GhostTypeIcon from '../../../components/icons/types/ghost';
import GrassTypeIcon from '../../../components/icons/types/grass';
import GroundTypeIcon from '../../../components/icons/types/ground';
import IceTypeIcon from '../../../components/icons/types/ice';
import NormalTypeIcon from '../../../components/icons/types/normal';
import PoisonTypeIcon from '../../../components/icons/types/poison';
import PsychicTypeIcon from '../../../components/icons/types/psychic';
import RockTypeIcon from '../../../components/icons/types/rock';
import SteelTypeIcon from '../../../components/icons/types/steel';
import WaterTypeIcon from '../../../components/icons/types/water';
import { Capitalize } from '../../../helpers/stringHelper';
import type { PokemonBasicDto } from '../../../types/pokemon';

type PokemonTypeBadgeProps = {
  type: PokemonBasicDto;
  link?: string;
  iconSize?: number;
};

const PokemonTypeBadge = ({ type, link, iconSize = 14 }: PokemonTypeBadgeProps) => {
  const typeMap: Record<string, { bgColor: string; icon: React.ReactElement }> = {
    normal: { bgColor: 'bg-stone-600', icon: <NormalTypeIcon size={iconSize} /> },
    fighting: { bgColor: 'bg-red-700', icon: <FightingTypeIcon size={iconSize} /> },
    flying: { bgColor: 'bg-sky-600', icon: <FlyingTypeIcon size={iconSize} /> },
    poison: { bgColor: 'bg-purple-700', icon: <PoisonTypeIcon size={iconSize} /> },
    ground: { bgColor: 'bg-amber-700', icon: <GroundTypeIcon size={iconSize} /> },
    rock: { bgColor: 'bg-yellow-700', icon: <RockTypeIcon size={iconSize} /> },
    bug: { bgColor: 'bg-lime-700', icon: <BugTypeIcon size={iconSize} /> },
    ghost: { bgColor: 'bg-indigo-800', icon: <GhostTypeIcon size={iconSize} /> },
    steel: { bgColor: 'bg-slate-600', icon: <SteelTypeIcon size={iconSize} /> },
    fire: { bgColor: 'bg-orange-600', icon: <FireTypeIcon size={iconSize} /> },
    water: { bgColor: 'bg-blue-700', icon: <WaterTypeIcon size={iconSize} /> },
    grass: { bgColor: 'bg-green-700', icon: <GrassTypeIcon size={iconSize} /> },
    electric: { bgColor: 'bg-yellow-600', icon: <ElectricTypeIcon size={iconSize} /> },
    psychic: { bgColor: 'bg-pink-700', icon: <PsychicTypeIcon size={iconSize} /> },
    ice: { bgColor: 'bg-cyan-600', icon: <IceTypeIcon size={iconSize} /> },
    dragon: { bgColor: 'bg-indigo-700', icon: <DragonTypeIcon size={iconSize} /> },
    dark: { bgColor: 'bg-neutral-900', icon: <DarkTypeIcon size={iconSize} /> },
    fairy: { bgColor: 'bg-pink-600', icon: <FairyTypeIcon size={iconSize} /> },
  };

  const colorClass = typeMap[type.name.toLowerCase()]?.bgColor || 'bg-gray-500';
  const Icon = typeMap[type.name.toLowerCase()]?.icon || <NormalTypeIcon size={iconSize} />;
  let returnItem: React.ReactElement | null = null;

  if (link) {
    returnItem = (
      <Link
        to={link}
        className={`px-2 py-1.5 w-fit flex items-center rounded text-white text-xs font-semibold gap-1 ${colorClass}`}
      >
        {Icon}
        {Capitalize(type.name)}
      </Link>
    );
  }

  return (
    returnItem || (
      <div
        className={`px-2 py-1.5 w-fit flex items-center rounded text-white text-xs font-semibold gap-1 ${colorClass}`}
      >
        {Icon}
        {Capitalize(type.name)}
      </div>
    )
  );
};

export default PokemonTypeBadge;
