import { FluentProvider, webDarkTheme, webLightTheme } from '@fluentui/react-components';
import { useEffect } from 'react';
import { useRoutes } from 'react-router-dom';
import { GlobalLoadingOverlay } from './components/ui/loading';
import { useSystemTheme } from './effects/useSystemTheme';
import { routes } from './plugins/routes';
import { useGlobalState } from './stores/useGlobalState';
import { LoadingProvider } from './stores/useLoading';

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
      <LoadingProvider>
        {appRoutes}
        <GlobalLoadingOverlay />
      </LoadingProvider>
    </FluentProvider>
  );
}

export default App;
