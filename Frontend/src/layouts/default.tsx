import { Hamburger } from '@fluentui/react-components';
import { useEffect, useState } from 'react';
import { Outlet, useLocation } from 'react-router-dom';
import { Nav } from '../components/ui/nav';
import { useBreakpoint } from '../stores/useBreakpoint';

const AppTitle = 'Pokedex';

export default function DefaultLayout() {
  const { md } = useBreakpoint();
  const [open, setOpen] = useState(md);
  const location = useLocation();

  useEffect(() => {
    setOpen(md);
  }, [md]);

  useEffect(() => {
    if (!md) {
      setOpen(false);
    }
  }, [location.pathname]);

  return (
    <div>
      <header className="h-(--header-height) bg-(--colorNeutralBackground4) border-b border-(--colorNeutralStroke2)">
        <div className="flex h-full items-center justify-between px-4">
          <div id="layout_header_left" className="flex gap-2 items-center">
            <Hamburger onClick={() => setOpen((prev) => !prev)} />
            {AppTitle}
          </div>
        </div>
      </header>
      <main className="flex h-[calc(100dvh-var(--header-height))]">
        <Nav
          open={open}
          overlay={!md}
          headerText={AppTitle}
          onToggle={async () => setOpen((prev) => !prev)}
        />
        <div className="h-full flex-1 overflow-auto rounded p-2">
          <Outlet />
        </div>
      </main>
    </div>
  );
}
