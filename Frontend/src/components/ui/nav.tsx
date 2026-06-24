import {
  Hamburger,
  NavDrawer,
  NavDrawerBody,
  NavDrawerHeader,
  NavItem,
  Tooltip,
} from '@fluentui/react-components';
import {
  Board20Filled,
  Board20Regular,
  Fire20Regular,
  Fire24Filled,
  bundleIcon,
} from '@fluentui/react-icons';
import { Link } from 'react-router-dom';

const Dashboard = bundleIcon(Board20Filled, Board20Regular);
const FireIcon = bundleIcon(Fire24Filled, Fire20Regular);
type Props = {
  open: boolean;
  overlay: boolean;
  headerText: string;
  onToggle: () => {};
};

export const Nav = ({ open, overlay, headerText, onToggle }: Props) => {
  return (
    <NavDrawer
      className="min-w-65 app-sidebar"
      tabbable={false}
      open={open}
      type={overlay ? 'overlay' : 'inline'}
      defaultSelectedValue="pokemons"
    >
      <NavDrawerHeader className="md:hidden! flex-row! items-center">
        <Tooltip content="Close Navigation" relationship="label">
          <Hamburger onClick={onToggle} />
        </Tooltip>
        <span>{headerText}</span>
      </NavDrawerHeader>
      <NavDrawerBody className="flex flex-col">
        <Link to="/">
          <NavItem icon={<Dashboard />} value="pokemons">
            Pokemons
          </NavItem>
        </Link>
        <Link to="/types">
          <NavItem icon={<FireIcon />} value="types">
            Types
          </NavItem>
        </Link>
      </NavDrawerBody>
    </NavDrawer>
  );
};
