import { createContext } from 'react';
import type { LoadingContextValue } from '../../types/loading';

const LoadingContext = createContext<LoadingContextValue | null>(null);

export default LoadingContext;
