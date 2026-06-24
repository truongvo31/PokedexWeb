import { Button, FluentProvider, webDarkTheme, webLightTheme } from '@fluentui/react-components';
import { useSystemTheme } from './stores/effects/useSystemTheme';
import { useGlobalState } from './stores/useGlobalState';

function App() {
  const { theme, setTheme, setLang } = useGlobalState();
  const systemTheme = useSystemTheme();
  const actualTheme = theme === 'system' ? systemTheme : theme;
  return (
    <FluentProvider theme={actualTheme === 'dark' ? webDarkTheme : webLightTheme}>
      <div className="flex flex-col h-dvh w-dvw items-center justify-center gap-2">
        <div className="flex gap-2">
          <Button appearance="primary" onClick={() => setTheme('light')}>
            Light
          </Button>
          <Button appearance="primary" onClick={() => setTheme('dark')}>
            Dark
          </Button>
          <Button appearance="primary" onClick={() => setTheme('system')}>
            System
          </Button>
        </div>
        <div className="flex gap-2">
          <Button appearance="primary" onClick={() => setLang('en')}>
            Lang En
          </Button>
          <Button appearance="primary" onClick={() => setLang('ja')}>
            Lang Ja
          </Button>
          <Button appearance="primary" onClick={() => setLang('vi')}>
            Lang Vi
          </Button>
        </div>
        <span>This is the test</span>
      </div>
    </FluentProvider>
  );
}

export default App;
