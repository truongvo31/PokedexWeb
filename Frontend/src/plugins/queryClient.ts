import { QueryClient } from '@tanstack/react-query';

export const queryClient = new QueryClient({
  defaultOptions: {
    queries: {
      staleTime: Infinity, // Pokedex only fetches, no DB editing, so no need to refetch
      gcTime: 1000 * 60 * 60, // 1 hour
      retry: 1,
    },
  },
});
