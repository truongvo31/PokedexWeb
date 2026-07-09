import { Button } from '@fluentui/react-components';
import useLoading from '../stores/useLoading';
import useMessages from '../stores/useMessages';

const HomePage = () => {
  const { withLoading, withProgressLoading } = useLoading();
  const { $info, $warning, $error, $success, $confirm } = useMessages();

  const testLoading = async () => {
    await withLoading(async () => {
      await new Promise((resolve) => setTimeout(resolve, 3000));
    });
  };

  const testProgressLoading = async () => {
    await withProgressLoading(async (setProgress) => {
      const maxIterations = 300;
      for (let i = 0; i <= maxIterations; i++) {
        const progress = Math.min(100, (i / maxIterations) * 100);
        setProgress(progress, `Loading... ${progress.toFixed(1)}%`);
        await new Promise((resolve) => setTimeout(resolve, 100));
      }
    }, 'Loading');
  };

  return (
    <div className="flex flex-col items-center justify-center h-full gap-2">
      <Button appearance="primary" onClick={() => void testLoading()}>
        Trigger Loading overlay
      </Button>
      <Button appearance="primary" onClick={() => void testProgressLoading()}>
        Test Progress Loading
      </Button>
      <Button appearance="primary" onClick={() => void $info('Info', 'This is an info message')}>
        Trigger Info Dialog
      </Button>
      <Button
        appearance="primary"
        onClick={() => void $warning('Warning', 'This is a warning message')}
      >
        Trigger Warning Dialog
      </Button>
      <Button appearance="primary" onClick={() => void $error('Error', 'This is an error message')}>
        Trigger Error Dialog
      </Button>
      <Button
        appearance="primary"
        onClick={() => void $success('Success', 'This is a success message')}
      >
        Trigger Success Dialog
      </Button>
      <Button appearance="primary" onClick={() => void $confirm('Confirm', 'Are you sure?')}>
        Trigger Confirm Dialog
      </Button>
    </div>
  );
};

export default HomePage;
