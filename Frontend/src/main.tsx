import { StrictMode } from 'react';
import { createRoot } from 'react-dom/client';
import App from './App.tsx';
import './index.css';
import { HtmlLangSync } from './stores/effects/useHtmlLang.ts';
import { GlobalProvider } from './stores/useGlobalState.tsx';

createRoot(document.getElementById('root')!).render(
  <StrictMode>
    <GlobalProvider>
      <HtmlLangSync />
      <App />
    </GlobalProvider>
  </StrictMode>,
);
