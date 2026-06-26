import {
  Button,
  Hamburger,
  Image,
  Popover,
  PopoverSurface,
  PopoverTrigger,
} from '@fluentui/react-components';
import { Settings24Filled, Settings24Regular, bundleIcon } from '@fluentui/react-icons';
import { useEffect, useState } from 'react';
import { Outlet, useLocation } from 'react-router-dom';
import { Nav } from '../components/ui/nav';
import SettingsPopover from '../components/ui/settings';
import { useBreakpoint } from '../stores/useBreakpoint';

const SettingIcon = bundleIcon(Settings24Filled, Settings24Regular);

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
            <Image alt="Logo" src="./logo.png" className="h-8" loading="lazy" />
          </div>
          <div id="layout_header_right" className="flex gap-2 items-center">
            <Popover>
              <PopoverTrigger disableButtonEnhancement>
                <Button icon={<SettingIcon />} appearance="transparent" />
              </PopoverTrigger>
              <PopoverSurface tabIndex={-1} className="settings-popover">
                <SettingsPopover />
              </PopoverSurface>
            </Popover>
          </div>
        </div>
      </header>
      <main className="flex h-[calc(100dvh-var(--header-height))]">
        <Nav open={open} overlay={!md} onToggle={async () => setOpen((prev) => !prev)} />
        <div className="h-full flex-1 overflow-auto">
          <Outlet />
        </div>
      </main>
    </div>
  );
}
