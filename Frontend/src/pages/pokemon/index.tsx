import { Button } from '@fluentui/react-components';
import { useTranslation } from 'react-i18next';
import { useGlobalState } from '../../stores/useGlobalState';

export default function Pokemons() {
  const { setTheme, setLang } = useGlobalState();
  const { t } = useTranslation();

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
      <p>{t('welcome')}</p>
      <p>{t('greeting', { name: 'Phong' })}</p>
    </div>
  );
}
