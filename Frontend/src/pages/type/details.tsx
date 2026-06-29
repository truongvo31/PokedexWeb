// This is a placeholder for the details page of a specific type. You can customize this component to display detailed information about the selected type.\
import { useParams } from 'react-router-dom';

export default function TypeDetails() {
  const { typeId } = useParams<{ typeId: string }>();
  return <div className="">This is the details page for type {typeId}</div>;
}
