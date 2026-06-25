import { QueryClientProvider } from '@tanstack/react-query';
import { StrictMode } from 'react';
import { createRoot } from 'react-dom/client';
import { BrowserRouter } from 'react-router-dom';
import App from './App.tsx';
import { HtmlLangSync } from './effects/useHtmlLang.ts';
import './index.css';
import './plugins/i18n.ts';
import { queryClient } from './plugins/queryClient';
import { GlobalProvider } from './stores/useGlobalState.tsx';

createRoot(document.getElementById('root')!).render(
  <StrictMode>
    <GlobalProvider>
      <HtmlLangSync />
      <BrowserRouter basename="/PokedexWeb">
        <QueryClientProvider client={queryClient}>
          <App />
        </QueryClientProvider>
      </BrowserRouter>
    </GlobalProvider>
  </StrictMode>,
);
