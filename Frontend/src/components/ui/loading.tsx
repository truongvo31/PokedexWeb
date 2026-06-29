import { Spinner } from '@fluentui/react-components';
import { getSystemTheme } from '../../helpers/themeHelper';
import { useGlobalState } from '../../stores/useGlobalState';
import { useLoading } from '../../stores/useLoading';

export function GlobalLoadingOverlay() {
  const { isLoading, message } = useLoading();
  const { theme } = useGlobalState();
  const actualTheme = theme === 'system' ? getSystemTheme() : theme;

  if (!isLoading) {
    return null;
  }

  return (
    <div
      className="fixed inset-0 z-999 flex items-center justify-center backdrop-blur-md"
      role="alert"
      aria-live="assertive"
      aria-busy="true"
    >
      <Spinner
        appearance={actualTheme === 'dark' ? 'inverted' : 'primary'}
        size="huge"
        label={message ?? 'Loading'}
        labelPosition="below"
      />
    </div>
  );
}
