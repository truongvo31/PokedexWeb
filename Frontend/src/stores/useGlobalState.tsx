import React, { createContext, useContext, useReducer } from 'react';
import { loadState, saveState } from '../helpers/storageHelper';

export type GlobalState = {
  theme: 'light' | 'dark' | 'system';
  lang: 'en' | 'ja' | 'vi';
};

const STORAGE_KEY = 'app:global';

const persisted = loadState<GlobalState>(STORAGE_KEY);

const initialState: GlobalState = {
  theme: 'light',
  lang: 'en',
  ...persisted, // override defaults if stored
};

type Action =
  | { type: 'SET_THEME'; payload: GlobalState['theme'] }
  | { type: 'SET_LANG'; payload: GlobalState['lang'] };

function reducer(state: GlobalState, action: Action): GlobalState {
  switch (action.type) {
    case 'SET_THEME':
      return { ...state, theme: action.payload };

    case 'SET_LANG':
      return { ...state, lang: action.payload };

    default:
      return state;
  }
}

const GlobalContext = createContext<{
  state: GlobalState;
  dispatch: React.Dispatch<Action>;
} | null>(null);

export function GlobalProvider({ children }: { children: React.ReactNode }) {
  const [state, dispatch] = useReducer(reducer, initialState);

  React.useEffect(() => {
    saveState(STORAGE_KEY, state);
  }, [state]);

  return <GlobalContext.Provider value={{ state, dispatch }}>{children}</GlobalContext.Provider>;
}

export function useGlobalState() {
  const ctx = useContext(GlobalContext);
  if (!ctx) throw new Error('useGlobalState must be used inside GlobalProvider');

  const { state, dispatch } = ctx;

  return {
    // state
    theme: state.theme,
    lang: state.lang,

    // actions (clean API)
    setTheme: (theme: GlobalState['theme']) => dispatch({ type: 'SET_THEME', payload: theme }),

    setLang: (lang: GlobalState['lang']) => dispatch({ type: 'SET_LANG', payload: lang }),
  };
}
