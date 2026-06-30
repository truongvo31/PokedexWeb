import {
  Divider,
  Table,
  TableBody,
  TableCell,
  TableHeader,
  TableHeaderCell,
  TableRow,
  makeStyles,
  tokens,
} from '@fluentui/react-components';
import type { PokemonBasicDto, PokemonTypeEfficacyDto } from '../../../types/pokemon';
import PokemonTypeBadge from './pokemonTypeBadge';

const columns: { key: keyof PokemonTypeEfficacyDto; label: string; className?: string }[] = [
  {
    key: 'multiplier',
    label: 'Dmg',
    className: 'w-1/8',
  },
  {
    key: 'types',
    label: 'Types',
    className: 'w-7/8',
  },
];

const useFluentStyles = makeStyles({
  card: {
    backgroundColor: tokens.colorNeutralBackground3,
    borderRadius: tokens.borderRadiusXLarge,
  },
});

const PokemonTypeEfficacy = ({ typeEfficacy }: { typeEfficacy: PokemonTypeEfficacyDto[] }) => {
  const fluentStyle = useFluentStyles();
  return (
    <div className={`flex flex-col gap-2 p-2 ${fluentStyle.card}`}>
      <Divider>Type Efficacy</Divider>
      <Table aria-label="Type Efficacy Table">
        <TableHeader>
          <TableRow>
            {columns.map((column) => (
              <TableHeaderCell key={column.key} className={column.className + ' *:justify-center'}>
                {column.label}
              </TableHeaderCell>
            ))}
          </TableRow>
        </TableHeader>
        <TableBody>
          {typeEfficacy.map((efficacy, index) => (
            <TableRow key={index}>
              {columns.map((column) => (
                <TableCell key={column.key} className={column.className + ' text-center'}>
                  {typeof efficacy[column.key] === 'string' ? (
                    efficacy[column.key]
                  ) : (
                    <div className="flex flex-wrap gap-2 p-2">
                      {(efficacy[column.key] as PokemonBasicDto[]).map((type) => (
                        <PokemonTypeBadge key={type.id} type={type} link={`/type/${type.id}`} />
                      ))}
                    </div>
                  )}
                </TableCell>
              ))}
            </TableRow>
          ))}
        </TableBody>
      </Table>
    </div>
  );
};

export default PokemonTypeEfficacy;
