import { FluentProvider, webDarkTheme, webLightTheme } from '@fluentui/react-components';
import { useEffect } from 'react';
import { useRoutes } from 'react-router-dom';
import { routes } from './routes';
import { useSystemTheme } from './stores/effects/useSystemTheme';
import { useGlobalState } from './stores/useGlobalState';

function App() {
  const { theme } = useGlobalState();
  const systemTheme = useSystemTheme();
  const actualTheme = theme === 'system' ? systemTheme : theme;

  useEffect(() => {
    document.documentElement.style.colorScheme = actualTheme;
  }, [actualTheme]);

  const appRoutes = useRoutes(routes);
  return (
    <FluentProvider theme={actualTheme === 'dark' ? webDarkTheme : webLightTheme}>
      {appRoutes}
    </FluentProvider>
  );
}

export default App;
