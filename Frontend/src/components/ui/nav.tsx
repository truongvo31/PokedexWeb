import {
  Hamburger,
  Image,
  NavDrawer,
  NavDrawerBody,
  NavDrawerHeader,
  NavItem,
  Tooltip,
  makeStyles,
  tokens,
} from '@fluentui/react-components';
import { Link } from 'react-router-dom';
import Logo from '../../assets/logo.png';
import { routes, type AppRoute } from '../../plugins/routes';

type Props = {
  open: boolean;
  overlay: boolean;
  onToggle: () => {};
};

const useFluentStyles = makeStyles({
  sidebar: {
    // backgroundColor: tokens.colorNeutralBackgroundAlpha2,
    borderRight: `1px solid ${tokens.colorNeutralStroke2}`,
  },
});

export const Nav = ({ open, overlay, onToggle }: Props) => {
  const navItems = routes[0].children?.filter((r: AppRoute) => r.nav) ?? [];

  const fluentStyles = useFluentStyles();

  return (
    <NavDrawer
      className={`min-w-65 app-sidebar shadow ${fluentStyles.sidebar}`}
      tabbable={false}
      open={open}
      type={overlay ? 'overlay' : 'inline'}
      defaultSelectedValue="pokemons"
    >
      <NavDrawerHeader className="md:hidden! flex-row! items-center">
        <Tooltip content="Close Navigation" relationship="label">
          <Hamburger onClick={onToggle} />
        </Tooltip>
        <Image src={Logo} className="h-8" loading="lazy" />
      </NavDrawerHeader>
      <NavDrawerBody className="flex flex-col">
        {navItems.map((route) => {
          const path = route.index ? '/' : `/${route.path}`;

          return (
            <Link key={path} to={path}>
              <NavItem icon={route.nav!.icon} value={route.nav!.value}>
                {route.nav!.label}
              </NavItem>
            </Link>
          );
        })}
      </NavDrawerBody>
    </NavDrawer>
  );
};
