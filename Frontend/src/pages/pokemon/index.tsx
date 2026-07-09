import PageHeader from '../../components/pageHeader';
import HomeSearchButton from './components/HomeSearchButton';
import PokemonTypeBadge from './components/TypeBadge';

const PokemonPage = () => {
  return (
    <div className="h-full flex flex-col">
      <PageHeader pageTitle="Pokemons">
        <HomeSearchButton onSubmit={(result) => console.log(result)} />
      </PageHeader>
      <div className="p-6">
        <PokemonTypeBadge type={{ id: 1, name: 'dark' }} />
      </div>
    </div>
  );
};

export default PokemonPage;
