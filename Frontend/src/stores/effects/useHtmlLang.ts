import { useEffect } from 'react';
import { useGlobalState } from '../useGlobalState';

export function HtmlLangSync() {
  const { lang } = useGlobalState();

  useEffect(() => {
    document.documentElement.lang = lang;
  }, [lang]);

  return null;
}
