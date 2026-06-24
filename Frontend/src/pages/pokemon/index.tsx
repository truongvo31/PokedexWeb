import { Button } from '@fluentui/react-components';
import { useGlobalState } from '../../stores/useGlobalState';

export default function Pokemons() {
  const { setTheme, setLang } = useGlobalState();
  return (
    <div className="flex flex-col items-center justify-center gap-2">
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

      {Array.from({ length: 200 }, (_, i) => (
        <div key={i}>This is the test</div>
      ))}
    </div>
  );
}
