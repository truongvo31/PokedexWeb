import { Divider, ToggleButton } from '@fluentui/react-components';
import {
  Laptop16Filled,
  Laptop16Regular,
  WeatherMoon16Filled,
  WeatherMoon16Regular,
  WeatherSunny16Filled,
  WeatherSunny16Regular,
  bundleIcon,
} from '@fluentui/react-icons';
import { useGlobalState } from '../../stores/useGlobalState';

const LightIcon = bundleIcon(WeatherSunny16Filled, WeatherSunny16Regular);
const DarkIcon = bundleIcon(WeatherMoon16Filled, WeatherMoon16Regular);
const SystemIcon = bundleIcon(Laptop16Filled, Laptop16Regular);

const SettingsPopover = () => {
  const { theme, setTheme, lang, setLang } = useGlobalState();

  return (
    <div className="flex flex-col gap-2 p-4">
      <p className="text-xs">Themes</p>
      <div className="flex gap-2">
        <ToggleButton
          icon={<LightIcon />}
          size="small"
          checked={theme === 'light'}
          onClick={() => setTheme('light')}
          isAccessible
        >
          Light
        </ToggleButton>
        <ToggleButton
          icon={<DarkIcon />}
          size="small"
          checked={theme === 'dark'}
          onClick={() => setTheme('dark')}
          isAccessible
        >
          Dark
        </ToggleButton>
        <ToggleButton
          icon={<SystemIcon />}
          size="small"
          checked={theme === 'system'}
          onClick={() => setTheme('system')}
          isAccessible
        >
          System
        </ToggleButton>
      </div>
      <Divider />
      <p className="text-xs">Languages</p>
      <div className="flex gap-2">
        <ToggleButton
          size="small"
          checked={lang === 'en'}
          onClick={() => setLang('en')}
          isAccessible
        >
          English
        </ToggleButton>
        <ToggleButton
          size="small"
          checked={lang === 'ja'}
          onClick={() => setLang('ja')}
          isAccessible
        >
          Japanese
        </ToggleButton>
        <ToggleButton
          size="small"
          checked={lang === 'vi'}
          onClick={() => setLang('vi')}
          isAccessible
        >
          Vietnamese
        </ToggleButton>
      </div>
    </div>
  );
};

export default SettingsPopover;
