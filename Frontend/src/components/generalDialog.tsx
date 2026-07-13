import { Dialog, DialogSurface, DialogTrigger } from '@fluentui/react-components';

type GeneralDialogProps = {
  children: React.ReactNode;
  trigger: React.ReactElement;
  unmountOnClose?: boolean;
};

/**
 * To comply with LoadingOverlay and MessageDialog, avoiding z-index issues, this component was created to wrap the Dialog component from Fluent UI.
 *
 * Must implement full `DialogBody` structure with `DialogTitle`, `DialogContent`, and `DialogActions` as children
 */
const GeneralDialog = ({ children, trigger, unmountOnClose = true }: GeneralDialogProps) => {
  const ready =
    typeof window !== 'undefined' && document.getElementById('root-fluent-provider') != null;

  return (
    ready && (
      <Dialog unmountOnClose={unmountOnClose}>
        <DialogTrigger disableButtonEnhancement>{trigger}</DialogTrigger>
        <DialogSurface mountNode={document.getElementById('root-fluent-provider')}>
          {children}
        </DialogSurface>
      </Dialog>
    )
  );
};

export default GeneralDialog;
