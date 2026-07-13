import {
  Button,
  DialogActions,
  DialogBody,
  DialogContent,
  DialogTitle,
  DialogTrigger,
  Field,
  Input,
} from '@fluentui/react-components';
import { Search24Regular } from '@fluentui/react-icons';
import { useState } from 'react';
import GeneralDialog from '../../../components/generalDialog';
import { Capitalize } from '../../../helpers/stringHelper';
import MultiselectWithValueString from './MultiselectWithValueString';

export type FilterResult = {
  searchName: string;
  searchRarity: ('legendary' | 'mythical')[];
  searchTypes: string[];
};

type HomeSearchButtonProps = {
  onSubmit: (result: FilterResult) => void;
};

const types = [
  'normal',
  'fire',
  'water',
  'grass',
  'electric',
  'ice',
  'fighting',
  'poison',
  'ground',
  'flying',
  'psychic',
  'bug',
  'rock',
  'ghost',
  'dragon',
  'dark',
  'steel',
  'fairy',
];

const HomeSearchButton = ({ onSubmit }: HomeSearchButtonProps) => {
  const [name, setName] = useState('');
  const [rarity, setRarity] = useState<('legendary' | 'mythical')[]>([]);
  const [selectedTypes, setSelectedTypes] = useState<string[]>([]);

  const handleSubmit = (e: React.SubmitEvent<HTMLFormElement>) => {
    e.preventDefault();
    onSubmit({ searchName: name, searchRarity: rarity, searchTypes: selectedTypes });
  };

  return (
    <GeneralDialog
      trigger={<Button icon={<Search24Regular />}>Search</Button>}
      unmountOnClose={false}
    >
      <form onSubmit={handleSubmit}>
        <DialogBody>
          <DialogTitle>Pokemon Search</DialogTitle>
          <DialogContent className="flex flex-col gap-2">
            <div className="grid grid-cols-1 md:grid-cols-2 gap-2 items-start">
              <Field
                label="Pokemon Name"
                hint="Accepts SQL wildcards. For example, 'pika%' will return all Pokemon names that start with 'pika'."
              >
                <Input
                  type="text"
                  value={name}
                  onChange={(e) => setName(e.target.value)}
                  placeholder="Enter Pokemon name"
                />
              </Field>
              <MultiselectWithValueString
                label="Rarity"
                selectedOptions={rarity}
                onChange={(selectedOptions) =>
                  setRarity(selectedOptions as ('legendary' | 'mythical')[])
                }
                options={['legendary', 'mythical'].map((rarity) => ({
                  label: Capitalize(rarity),
                  value: rarity,
                }))}
                hint="Select one or more rarities to filter by."
                placeholder="Select one or more rarities"
              />
            </div>
            <MultiselectWithValueString
              label="Types"
              hint="Select one or more types to filter by."
              placeholder="Select one or more types"
              selectedOptions={selectedTypes}
              onChange={(selectedOptions) => setSelectedTypes(selectedOptions)}
              options={types.map((type) => ({
                label: Capitalize(type),
                value: type,
              }))}
            />
          </DialogContent>
          <DialogActions>
            <DialogTrigger disableButtonEnhancement>
              <Button type="submit" appearance="primary">
                Search
              </Button>
            </DialogTrigger>
            <DialogTrigger disableButtonEnhancement>
              <Button appearance="secondary">Close</Button>
            </DialogTrigger>
          </DialogActions>
        </DialogBody>
      </form>
    </GeneralDialog>
  );
};

export default HomeSearchButton;
