import { Divider } from '@fluentui/react-components';
import { Link, Outlet } from 'react-router-dom';
import { Nav } from '../components/ui/nav';

export default function DefaultLayout() {
  return (
    <div>
      <header className="h-(--header-height)">
        <div className="flex h-full items-center justify-between px-4">
          <div id="layout_header_left" className="flex gap-4">
            <Link to="/">Pokemons</Link>
            <Link to="/types">Types</Link>
          </div>
        </div>
        <Divider />
      </header>
      <Nav />
      <main className="flex flex-col h-[calc(100dvh-var(--header-height))] overflow-auto">
        <Outlet />
      </main>
    </div>
  );
}
