import { useVirtualizer } from '@tanstack/react-virtual';
import { useLayoutEffect } from 'react';
import { useElementSize } from '../../../stores/useElementSize';
import type { PokemonDtoMin } from '../../../types/pokemon';
import PokemonCard from './PokemonCard';

type PokemonGridProps = {
  pokemons: PokemonDtoMin[];
  options: {
    gap: number;
    itemHeight: number;
  };
  className?: string;
  selected?: number;
  jumpToPokemonId?: number;
  jumpBehavior?: 'smooth' | 'auto' | 'instant';
};

const PokemonGrid = ({
  pokemons,
  options,
  className,
  selected,
  jumpToPokemonId,
  jumpBehavior = 'smooth',
}: PokemonGridProps) => {
  const { ref, width } = useElementSize<HTMLDivElement>();
  const lanes = Math.max(1, Math.floor(width / 200));
  const gap = options.gap;
  const itemHeight = options.itemHeight;
  const rows = Math.ceil((pokemons?.length ?? 0) / lanes);

  const jumpToRow =
    jumpToPokemonId !== undefined
      ? Math.floor(pokemons.findIndex((p) => p.id === jumpToPokemonId) / lanes)
      : undefined;

  // eslint-disable-next-line react-hooks/incompatible-library
  const virtualizer = useVirtualizer({
    count: rows,
    getScrollElement: () => ref.current,
    estimateSize: () => itemHeight, // item height
    overscan: 3,
    directDomUpdates: true,
  });

  useLayoutEffect(() => {
    if (jumpToRow === undefined || jumpToRow < 0) return;

    virtualizer.scrollToIndex(jumpToRow, {
      align: 'start',
      behavior: jumpBehavior,
    });
  }, [jumpToRow, virtualizer, jumpBehavior]);

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
                <PokemonCard
                  key={pokemon.id}
                  pokemon={pokemon}
                  height={itemHeight - gap}
                  selected={selected === pokemon.id}
                />
              ))}
            </div>
          );
        })}
      </div>
    </div>
  );
};

export default PokemonGrid;
