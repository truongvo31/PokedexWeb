import { createBrowserRouter, Navigate } from 'react-router-dom';
import DefaultLayout from './layout';
import ErrorPage from './pages/error';
import PokemonPage from './pages/pokemon';
import PokemonDetailsPage from './pages/pokemon/details';
import SettingsPage from './pages/settings';
import PokemonTypesPage from './pages/types';
import PokemonTypeDetailsPage from './pages/types/details';

const routes = createBrowserRouter(
  [
    {
      path: '/',
      element: <DefaultLayout />,
      children: [
        {
          path: '/',
          element: <Navigate to="/pokemon" replace />,
        },
        {
          path: '/pokemon',
          children: [
            {
              index: true,
              element: <PokemonPage />,
            },
            {
              path: ':id',
              element: <PokemonDetailsPage />,
            },
          ],
        },
        {
          path: '/types',
          children: [
            {
              index: true,
              element: <PokemonTypesPage />,
            },
            {
              path: ':id',
              element: <PokemonTypeDetailsPage />,
            },
          ],
        },
        {
          path: '/settings',
          element: <SettingsPage />,
        },
      ],
    },
    {
      path: '*',
      element: <ErrorPage code={404} message="Page Not Found" />,
    },
  ],
  {
    basename: import.meta.env.BASE_URL,
  },
);

export default routes;
