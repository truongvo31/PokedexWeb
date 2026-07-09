import {
  Button,
  Dialog,
  DialogActions,
  DialogBody,
  DialogContent,
  DialogSurface,
  DialogTitle,
  Input,
} from '@fluentui/react-components';
import { useState } from 'react';
import useAsyncDialog from '../stores/useAsyncDialog';
import useLoading from '../stores/useLoading';

type NameDialogProps = {
  title: string;
  placeholder?: string;
};

/**
 * Example of a fully custom async dialog.
 *
 * This component owns the entire Fluent dialog tree and resolves the async
 * prompt through `useAsyncDialog`.
 *
 * Must indicate mountNode to avoid z-index issues with the loading overlay.
 * The loading overlay is rendered in a portal at the root of the app, so the dialog must be rendered in a portal as well.
 */
const MyCustomizedDialogComponent = ({ title, placeholder }: NameDialogProps) => {
  const { resolve, cancel, isOpen } = useAsyncDialog();
  const [value, setValue] = useState('');
  const { withLoading } = useLoading();

  const testLoading = async () => {
    await withLoading(async () => {
      await new Promise((resolve) => setTimeout(resolve, 10000));
    });
  };

  return (
    <Dialog
      open={isOpen}
      onOpenChange={(_event, data) => {
        if (!data.open) {
          void cancel();
        }
      }}
    >
      <DialogSurface
        className={'w-fit '}
        mountNode={document.getElementById('root-fluent-provider') ?? undefined}
      >
        <DialogBody>
          <DialogTitle>{title}</DialogTitle>
          <DialogContent>
            <Input
              className="block w-full"
              autoFocus
              value={value}
              placeholder={placeholder}
              onChange={(_event, data) => {
                setValue(data.value);
              }}
              onKeyDown={(event) => {
                if (event.key === 'Enter') {
                  event.preventDefault();
                  void resolve(value);
                }
              }}
            />
          </DialogContent>
          <DialogActions fluid>
            <Button appearance="secondary" onClick={() => void testLoading()}>
              Test Loading
            </Button>
            <Button appearance="secondary" onClick={() => void cancel()}>
              Cancel
            </Button>
            <Button appearance="primary" onClick={() => void resolve(value)}>
              Continue
            </Button>
          </DialogActions>
        </DialogBody>
      </DialogSurface>
    </Dialog>
  );
};

export default MyCustomizedDialogComponent;
