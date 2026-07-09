import { createBrowserRouter, Navigate } from 'react-router-dom';
import DefaultLayout from './layout';
import ErrorPage from './pages/error';
import PokemonPage from './pages/pokemon';
import SettingsPage from './pages/settings';

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
          element: <PokemonPage />,
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
