import { createContext } from 'react';
import type { SidebarContextType } from '../../types/sidebar';

const SidebarContext = createContext<SidebarContextType | undefined>(undefined);

export default SidebarContext;
