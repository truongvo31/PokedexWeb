import { useParams } from 'react-router-dom';

const PokemonTypeDetailsPage = () => {
  const { id: paramId } = useParams<{ id: string }>();
  const id = paramId ? parseInt(paramId, 10) : null;
  return <div className="flex flex-col gap-2">Details page for type {id}</div>;
};
export default PokemonTypeDetailsPage;
