import { useEffect, useReducer } from 'react';
import { loadState, saveState } from '../../helpers/storageHelper';
import type { GlobalAction, GlobalState } from '../../types/globalProvider';
import { GlobalContext } from './context';

const STORAGE_KEY = 'app:global';

const persisted = loadState<GlobalState>(STORAGE_KEY);

const initialState: GlobalState = {
  theme: 'system',
  lang: 'en',
  ...persisted,
};

const reducer = (state: GlobalState, action: GlobalAction): GlobalState => {
  switch (action.type) {
    case 'SET_THEME':
      return { ...state, theme: action.payload };

    case 'SET_LANG':
      return { ...state, lang: action.payload };

    default:
      return state;
  }
};

const GlobalProvider = ({ children }: { children: React.ReactNode }) => {
  const [state, dispatch] = useReducer(reducer, initialState);

  useEffect(() => {
    saveState(STORAGE_KEY, state);
  }, [state]);

  return <GlobalContext.Provider value={{ state, dispatch }}>{children}</GlobalContext.Provider>;
};

export default GlobalProvider;
