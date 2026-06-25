import type { Slot } from '@fluentui/react-components';
import { type RouteObject } from 'react-router-dom';
import Error from '../Error';
import DefaultLayout from '../layouts/default';
import Pokemons from '../pages/pokemon/index';
import Types from '../pages/type';

import {
  Board20Filled,
  Board20Regular,
  Fire20Regular,
  Fire24Filled,
  bundleIcon,
} from '@fluentui/react-icons';

const Dashboard = bundleIcon(Board20Filled, Board20Regular);
const FireIcon = bundleIcon(Fire24Filled, Fire20Regular);

export type AppRoute = RouteObject & {
  nav?: {
    label: string;
    icon: Slot<'span'>;
    value: string;
  };
  children?: AppRoute[];
};

export const routes: AppRoute[] = [
  {
    path: '/',
    element: <DefaultLayout />,
    children: [
      {
        index: true,
        element: <Pokemons />,
        nav: { label: 'Pokemons', icon: <Dashboard />, value: 'pokemons' },
      },
      {
        path: 'types',
        element: <Types />,
        nav: {
          label: 'Types',
          icon: <FireIcon />,
          value: 'types',
        },
      },
    ],
  },
  {
    path: '*',
    element: <Error code={404} message="Page not found" />,
  },
];
