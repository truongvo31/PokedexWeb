import { FluentProvider, webDarkTheme, webLightTheme } from '@fluentui/react-components';
import { useEffect } from 'react';
import { RouterProvider } from 'react-router-dom';
import AsyncDialogProvider from './providers/dialogProvider';
import LoadingProvider from './providers/loadingProvider';
import routes from './routes';
import useGlobalState from './stores/useGlobalState';
import { HtmlLangSync } from './stores/useHtmlLangSync';
import { useSystemTheme } from './stores/useSystemTheme';

const App = () => {
  const { theme } = useGlobalState();
  const systemTheme = useSystemTheme();

  const actualTheme = theme === 'system' ? systemTheme : theme;
  useEffect(() => {
    document.documentElement.style.colorScheme = actualTheme;
  }, [actualTheme]);

  return (
    <FluentProvider
      theme={actualTheme === 'dark' ? webDarkTheme : webLightTheme}
      id="root-fluent-provider"
    >
      <LoadingProvider>
        <AsyncDialogProvider>
          <HtmlLangSync />
          <RouterProvider router={routes} />
        </AsyncDialogProvider>
      </LoadingProvider>
    </FluentProvider>
  );
};

export default App;
