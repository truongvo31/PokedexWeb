import { makeStyles, Text, tokens } from '@fluentui/react-components';

const useFluentStyles = makeStyles({
  description: {
    color: tokens.colorNeutralForeground3,
    fontSize: tokens.fontSizeBase300,
  },
});

const PageHeader = ({
  pageTitle,
  description,
  breadcrumbs,
  className = '',
  children,
}: {
  pageTitle: string;
  description?: string;
  breadcrumbs?: React.ReactNode;
  className?: string;
  children?: React.ReactNode;
}) => {
  const styles = useFluentStyles();

  return (
    <div className={'p-6 flex items-center justify-between' + className}>
      <div className="flex flex-col">
        <Text size={600} weight="semibold">
          {pageTitle}
        </Text>
        {description && <Text className={styles.description}>{description}</Text>}
        {breadcrumbs && <div className="mt-2">{breadcrumbs}</div>}
      </div>
      {children}
    </div>
  );
};

export default PageHeader;
