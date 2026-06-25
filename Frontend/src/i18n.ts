import i18n from 'i18next';
import LanguageDetector from 'i18next-browser-languagedetector';
import { initReactI18next } from 'react-i18next';
import en from './locales/en.ts';
import ja from './locales/ja.ts';
import vi from './locales/vi.ts';

i18n
  .use(LanguageDetector) // detects browser language
  .use(initReactI18next)
  .init({
    fallbackLng: 'en',
    debug: true,
    interpolation: {
      escapeValue: false, // react already escapes
    },
    resources: {
      en: {
        translation: en,
      },
      ja: {
        translation: ja,
      },
      vi: {
        translation: vi,
      },
    },
  });

export default i18n;
