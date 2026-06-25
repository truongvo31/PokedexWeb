import { type RouteObject } from 'react-router-dom';

import Error from './Error';
import DefaultLayout from './layouts/default';
import Pokemons from './pages/pokemon/index';
import Types from './pages/type';

export const routes: RouteObject[] = [
  {
    path: '/',
    element: <DefaultLayout />,
    children: [
      { index: true, element: <Pokemons /> },
      { path: '/types', element: <Types /> },
    ],
  },
  {
    path: '*',
    element: <Error code={404} message="Page not found" />,
  },
];
