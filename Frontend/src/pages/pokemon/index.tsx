import { useQuery } from '@tanstack/react-query';
import { useTranslation } from 'react-i18next';
import api from '../../helpers/apiHelper';

export default function Pokemons() {
  const { t } = useTranslation();

  const { data: pokemons } = useQuery<any>({
    queryKey: ['pokemons'],
    queryFn: async () => {
      const { error, message, data } = await api.$get<any>('pokemon');
      if (error) throw new Error(message);
      return data!;
    },
  });

  console.log('pokemons', pokemons);

  return (
    <div className="flex flex-col items-center justify-center gap-2">
      <p>{t('welcome')}</p>
      <p>{t('greeting', { name: 'Phong' })}</p>
    </div>
  );
}
