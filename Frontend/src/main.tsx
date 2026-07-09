import { StrictMode } from 'react';
import { createRoot } from 'react-dom/client';
import App from './App.tsx';
import './assets/styles/index.css';
import './locales/config.ts';
import GlobalProvider from './providers/globalProvider/index.tsx';

createRoot(document.getElementById('root')!).render(
  <StrictMode>
    <GlobalProvider>
      <App />
    </GlobalProvider>
  </StrictMode>,
);
