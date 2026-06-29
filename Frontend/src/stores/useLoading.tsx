import { createContext, type ReactNode, useCallback, useContext, useMemo, useState } from 'react';

type LoadingContextValue = {
  isLoading: boolean;
  message?: string;
  showLoading: (message?: string) => void;
  hideLoading: () => void;
  setLoading: (value: boolean, message?: string) => void;
  withLoading: <T>(asyncFunction: () => Promise<T>, message?: string) => Promise<T>;
};

const LoadingContext = createContext<LoadingContextValue | null>(null);

type LoadingProviderProps = {
  children: ReactNode;
};

export function LoadingProvider({ children }: LoadingProviderProps) {
  const [loadingCount, setLoadingCount] = useState(0);
  const [message, setMessage] = useState<string | undefined>();

  const isLoading = loadingCount > 0;

  const showLoading = useCallback((nextMessage?: string) => {
    setMessage(nextMessage);
    setLoadingCount((count) => count + 1);
  }, []);

  const hideLoading = useCallback(() => {
    setLoadingCount((count) => Math.max(0, count - 1));
    setMessage(undefined);
  }, []);

  const setLoading = useCallback((value: boolean, nextMessage?: string) => {
    if (value) {
      setLoadingCount((count) => count + 1);
      setMessage(nextMessage);
      return;
    }
    setLoadingCount((count) => Math.max(0, count - 1));
    setMessage(undefined);
  }, []);

  const withLoading = useCallback(
    async <T,>(asyncFunction: () => Promise<T>, nextMessage?: string): Promise<T> => {
      showLoading(nextMessage);
      try {
        return await asyncFunction();
      } finally {
        hideLoading();
      }
    },
    [showLoading, hideLoading],
  );

  const value = useMemo(
    () => ({
      isLoading,
      message,
      showLoading,
      hideLoading,
      setLoading,
      withLoading,
    }),
    [isLoading, message, showLoading, hideLoading, setLoading, withLoading],
  );

  return <LoadingContext.Provider value={value}>{children}</LoadingContext.Provider>;
}

export function useLoading() {
  const context = useContext(LoadingContext);

  if (!context) {
    throw new Error('useLoading must be used inside LoadingProvider.');
  }

  return context;
}
