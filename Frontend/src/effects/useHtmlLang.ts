import { useEffect } from 'react';
import { useTranslation } from 'react-i18next';
import { useGlobalState } from '../stores/useGlobalState';

export function HtmlLangSync() {
  const { lang } = useGlobalState();
  const { i18n } = useTranslation();

  useEffect(() => {
    document.documentElement.lang = lang;
    if (i18n.language !== lang) {
      i18n.changeLanguage(lang);
    }
  }, [lang, i18n]);

  return null;
}
