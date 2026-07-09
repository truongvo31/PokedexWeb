import { Combobox, Field, Option, type ComboboxProps } from '@fluentui/react-components';
import { useState } from 'react';

export type Option = {
  label: string;
  value: string;
  icon?: React.ReactNode;
};

type MultiselectWithValueStringProps = {
  label: string;
  options: Option[];
  selectedOptions: string[];
  hint?: string;
  placeholder?: string;
  onChange: (selectedOptions: string[]) => void;
};

const MultiselectWithValueString = ({
  label,
  options,
  selectedOptions,
  onChange,
  hint,
  placeholder,
}: MultiselectWithValueStringProps) => {
  const [value, setValue] = useState('');

  const onSelect: ComboboxProps['onOptionSelect'] = (_, data) => {
    // update selectedTypes
    onChange(data.selectedOptions);

    // reset value to an empty string after selection
    setValue('');
  };

  // clear value on focus
  const onFocus = () => {
    setValue('');
  };

  // update value to selected options on blur
  const onBlur = () => {
    setValue(selectedOptions.join(', '));
  };

  // update value on input change
  const onInputChange = (event: React.ChangeEvent<HTMLInputElement>) => {
    setValue(event.target.value);
  };

  return (
    <Field label={label} hint={hint}>
      <Combobox
        placeholder={placeholder}
        multiselect
        value={value}
        onBlur={onBlur}
        onChange={onInputChange}
        onFocus={onFocus}
        onOptionSelect={onSelect}
        positioning={{
          pinned: true,
        }}
      >
        {options.map((option) => (
          <Option key={option.value} value={option.value} text={option.label}>
            {option.label}
          </Option>
        ))}
      </Combobox>
    </Field>
  );
};

export default MultiselectWithValueString;
