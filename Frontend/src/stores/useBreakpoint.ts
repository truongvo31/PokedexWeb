import { useMediaQuery } from '../effects/useMediaQuery';

export function useBreakpoint() {
  return {
    sm: useMediaQuery('(min-width: 640px)'),
    md: useMediaQuery('(min-width: 768px)'),
    lg: useMediaQuery('(min-width: 1024px)'),
    xl: useMediaQuery('(min-width: 1280px)'),
  };
}
