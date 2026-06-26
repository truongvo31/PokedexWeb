import { useVirtualizer } from '@tanstack/react-virtual';
import { useElementSize } from '../../effects/useElementSize';
import type { PokemonDtoMin } from '../../types/pokemon';
import PokemonCard from './pokemonCard';

type PokemonGridProps = {
  pokemons: PokemonDtoMin[];
  options: {
    gap: number;
    itemHeight: number;
  };
  className?: string;
};

const PokemonGrid = ({ pokemons, options, className }: PokemonGridProps) => {
  const { ref, width } = useElementSize();
  const lanes = Math.max(1, Math.floor(width / 200));
  const gap = options.gap;
  const itemHeight = options.itemHeight;
  const rows = Math.ceil((pokemons?.length ?? 0) / lanes);
  console.log(pokemons);

  const virtualizer = useVirtualizer({
    count: rows,
    getScrollElement: () => ref.current,
    estimateSize: () => itemHeight, // item height
    overscan: 3,
    directDomUpdates: true,
  });

  return (
    <div ref={ref} className={`overflow-auto p-2 ${className}`}>
      <div ref={virtualizer.containerRef} className="w-full relative">
        {virtualizer.getVirtualItems().map((virtualRow) => {
          const startIndex = virtualRow.index * lanes;
          const rowItems = pokemons?.slice(startIndex, startIndex + lanes) ?? [];
          return (
            <div
              key={virtualRow.key}
              style={{
                position: 'absolute',
                top: 0,
                left: 0,
                transform: `translateY(${virtualRow.start}px)`,
                display: 'grid',
                gridTemplateColumns: `repeat(${lanes}, 1fr)`,
                gap,
                width: '100%',
                height: itemHeight,
              }}
            >
              {rowItems.map((pokemon) => (
                <PokemonCard key={pokemon.id} pokemon={pokemon} height={itemHeight - gap} />
              ))}
            </div>
          );
        })}
      </div>
    </div>
  );
};

export default PokemonGrid;
