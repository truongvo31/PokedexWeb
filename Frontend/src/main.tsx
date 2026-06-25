import { StrictMode } from 'react';
import { createRoot } from 'react-dom/client';
import { BrowserRouter } from 'react-router-dom';
import App from './App.tsx';
import { HtmlLangSync } from './effects/useHtmlLang.ts';
import './i18n.ts';
import './index.css';
import { GlobalProvider } from './stores/useGlobalState.tsx';

createRoot(document.getElementById('root')!).render(
  <StrictMode>
    <GlobalProvider>
      <HtmlLangSync />
      <BrowserRouter>
        <App />
      </BrowserRouter>
    </GlobalProvider>
  </StrictMode>,
);
