import {
  Accordion,
  AccordionHeader,
  AccordionItem,
  AccordionPanel,
  Divider,
  Menu,
  MenuItem,
  MenuList,
  MenuPopover,
  MenuTrigger,
  Table,
  TableBody,
  TableCell,
  TableCellLayout,
  TableHeader,
  TableHeaderCell,
  TableRow,
  createTableColumn,
  makeStyles,
  tokens,
  useTableColumnSizing_unstable,
  useTableFeatures,
  type TableColumnDefinition,
} from '@fluentui/react-components';
import { useEffect, useState } from 'react';
import OverflowTabs from '../../../components/overflowTabs';
import type { EncounterGameNode, EncounterMethodNode } from '../../../types/pokemon';

const useFluentStyles = makeStyles({
  accordionCard: {
    backgroundColor: tokens.colorNeutralCardBackground,
    border: `1px solid ${tokens.colorNeutralStroke1}`,
    borderRadius: tokens.borderRadiusMedium,
  },
  accordionPanel: {
    padding: '.25rem .5rem',
    borderTop: `1px solid ${tokens.colorNeutralStroke1}`,
    display: 'block',
  },
});

const columnsDef: TableColumnDefinition<EncounterMethodNode>[] = [
  createTableColumn<EncounterMethodNode>({
    columnId: 'method',
    renderHeaderCell: () => <>Method</>,
  }),
  createTableColumn<EncounterMethodNode>({
    columnId: 'methoddesc',
    renderHeaderCell: () => <>Method Description</>,
  }),
  createTableColumn<EncounterMethodNode>({
    columnId: 'conditions',
    renderHeaderCell: () => <>Conditions</>,
  }),
];

const columnSizingOptions = {
  method: {
    idealWidth: 300,
    minWidth: 250,
  },
  methoddesc: {
    idealWidth: 300,
    minWidth: 300,
  },
  conditions: {
    idealWidth: 200,
    minWidth: 200,
  },
};

const PokemonEncounters = ({ encounters }: { encounters: EncounterGameNode[] }) => {
  const fluentStyles = useFluentStyles();

  const tabs = encounters.map((encounter) => ({
    id: encounter.game.id.toString(),
    name: encounter.game.name,
  }));
  const [selectedTabId, setSelectedTabId] = useState<string | undefined>(tabs[0]?.id);
  const [selectedLocationId, setSelectedLocationId] = useState<string | undefined>(undefined);

  const selectedEncounter = encounters.find(
    (encounter) => encounter.game.id.toString() === selectedTabId,
  );

  const [columns] = useState<TableColumnDefinition<EncounterMethodNode>[]>(columnsDef);
  const { getRows, columnSizing_unstable, tableRef } = useTableFeatures(
    {
      columns,
      items: selectedEncounter
        ? selectedEncounter.locations.find(
            (location) => location.location.id.toString() === selectedLocationId,
          )?.methods || []
        : [],
    },
    [
      useTableColumnSizing_unstable({
        columnSizingOptions,
        autoFitColumns: true,
      }),
    ],
  );
  const rows = getRows();

  useEffect(() => {
    console.log('Selected location ID:', selectedLocationId);
  }, [selectedLocationId]);

  return (
    encounters && (
      <div className="flex flex-col gap-2">
        <Divider>Encounters (Ingame locations only)</Divider>
        <OverflowTabs tabs={tabs} className="justify-between" onTabSelected={setSelectedTabId} />
        {selectedEncounter && (
          <Accordion
            collapsible
            className="flex flex-col gap-2"
            onToggle={(_, data) => setSelectedLocationId(data.value as string)}
          >
            {selectedEncounter.locations.map((location) => (
              <AccordionItem
                key={location.location.id}
                value={location.location.id.toString()}
                className={fluentStyles.accordionCard}
              >
                <AccordionHeader expandIconPosition="end">{location.location.name}</AccordionHeader>
                <AccordionPanel className={fluentStyles.accordionPanel}>
                  <div className="overflow-x-auto">
                    <Table
                      ref={tableRef}
                      {...columnSizing_unstable.getTableProps()}
                      noNativeElements
                    >
                      <TableHeader>
                        <TableRow>
                          {columns.map((column) => (
                            <Menu openOnContext key={column.columnId}>
                              <MenuTrigger>
                                <TableHeaderCell
                                  key={column.columnId}
                                  {...columnSizing_unstable.getTableHeaderCellProps(
                                    column.columnId,
                                  )}
                                >
                                  {column.renderHeaderCell()}
                                </TableHeaderCell>
                              </MenuTrigger>
                              <MenuPopover>
                                <MenuList>
                                  <MenuItem
                                    onClick={columnSizing_unstable.enableKeyboardMode(
                                      column.columnId,
                                    )}
                                  >
                                    Keyboard Column Resizing
                                  </MenuItem>
                                </MenuList>
                              </MenuPopover>
                            </Menu>
                          ))}
                        </TableRow>
                      </TableHeader>
                      <TableBody>
                        {rows.map(({ item }) => (
                          <TableRow key={item.method.id}>
                            <TableCell {...columnSizing_unstable.getTableCellProps('method')}>
                              <TableCellLayout truncate>{item.method.name}</TableCellLayout>
                            </TableCell>
                            <TableCell {...columnSizing_unstable.getTableCellProps('methoddesc')}>
                              <TableCellLayout truncate>{item.methodDesc || 'N/A'}</TableCellLayout>
                            </TableCell>
                            <TableCell
                              {...columnSizing_unstable.getTableCellProps('conditions')}
                              className="flex flex-col gap-1 items-start! justify-center"
                            >
                              {item.conditions.length > 0
                                ? item.conditions.map((condition) => (
                                    <div key={condition.condition}>
                                      {`${condition.condition || 'N/A'} (Rarity: ${condition.rarity})`}
                                    </div>
                                  ))
                                : 'N/A'}
                            </TableCell>
                          </TableRow>
                        ))}
                      </TableBody>
                    </Table>
                  </div>
                </AccordionPanel>
              </AccordionItem>
            ))}
          </Accordion>
        )}
      </div>
    )
  );
};

export default PokemonEncounters;
