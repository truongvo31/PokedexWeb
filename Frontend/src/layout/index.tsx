import { Button, makeStyles, tokens } from '@fluentui/react-components';
import { Navigation24Regular } from '@fluentui/react-icons';
import { Link, Outlet } from 'react-router-dom';
import Logo from '../assets/images/logo.png';
import SidebarProvider from '../providers/sidebarProvider';
import useSidebar from '../stores/useSidebar';
import AppSidebar from './components/appSidebar';

const useFluentStyles = makeStyles({
  nav: {
    backgroundColor: tokens.colorBrandBackground2,
    borderBottom: `1px solid ${tokens.colorNeutralStroke2}`,
  },
});

const LayoutContent = () => {
  const fluentStyles = useFluentStyles();
  const { toggleMobileSidebar, isMobile, toggleSidebar } = useSidebar();

  return (
    <div className="flex flex-col h-dvh">
      <nav
        className={
          'h-(--header-height) flex gap-2 px-4 items-center justify-between' + fluentStyles.nav
        }
      >
        <div className="flex items-center gap-2">
          <Button
            onClick={isMobile ? toggleMobileSidebar : toggleSidebar}
            icon={<Navigation24Regular />}
            appearance="transparent"
          />
          <Link to="/">
            <img src={Logo} alt="Logo" className="h-6" />
          </Link>
        </div>
      </nav>
      <main className="flex h-[calc(100dvh-var(--header-height))]">
        <AppSidebar />
        <div className="flex-1">
          <Outlet />
        </div>
      </main>
    </div>
  );
};

const DefaultLayout = () => {
  return (
    <SidebarProvider>
      <LayoutContent />
    </SidebarProvider>
  );
};

export default DefaultLayout;
