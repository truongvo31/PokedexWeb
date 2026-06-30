import { useParams } from 'react-router-dom';

const PokemonEncounters = () => {
  const { id } = useParams<{ id: string }>();
  return <>This is pokemon encounters page for {id}</>;
};
export default PokemonEncounters;
