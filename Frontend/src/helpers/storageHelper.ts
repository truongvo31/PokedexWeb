export function loadState<T>(key: string): Partial<T> | null {
  try {
    const raw = localStorage.getItem(key);
    return raw ? JSON.parse(raw) : null;
  } catch {
    return null;
  }
}

export function saveState<T>(key: string, state: T) {
  try {
    localStorage.setItem(key, JSON.stringify(state));
  } catch {
    // ignore quota / private mode errors
  }
}
