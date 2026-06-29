const AtkIcon = ({ size = 24, color = 'currentColor' }) => (
  <svg xmlns="http://www.w3.org/2000/svg" width={size} height={size} viewBox="0 0 24 24">
    <g fill="none" stroke={color} strokeWidth={1.5}>
      <path d="M5.06 21.06a1.5 1.5 0 1 1-2.12-2.121a1.5 1.5 0 0 1 2.12 2.122Z"></path>
      <path strokeLinecap="round" strokeLinejoin="round" d="m8 16l-2.5 2.5"></path>
      <path
        strokeLinejoin="round"
        d="m9.5 16.5l10.573-9.297a1.73 1.73 0 0 0 .554-.92L21.5 2.5l-3.783.873a1.73 1.73 0 0 0-.92.554L7.5 14.5"
      ></path>
      <path
        strokeLinecap="round"
        strokeLinejoin="round"
        d="M4 13h.572a2 2 0 0 1 1.414.586l4.428 4.428A2 2 0 0 1 11 19.428V20"
      ></path>
    </g>
  </svg>
);

export default AtkIcon;
