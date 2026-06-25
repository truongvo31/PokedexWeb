namespace PokedexWeb.Helpers
{
    public static class PokemonHelper
    {
        public static string ToDisplayName(string input)
        {
            if (string.IsNullOrWhiteSpace(input))
                return input;

            return string.Join(" ",
                input.Split('-', StringSplitOptions.RemoveEmptyEntries)
                     .Select(word => char.ToUpper(word[0]) + word.Substring(1)));
        }

        public static string GetGenerationName(string dbName)
        {
            if (string.IsNullOrWhiteSpace(dbName))
                return dbName;
            return dbName.Substring(dbName.LastIndexOf('-') + 1).ToUpper();
        }
    }
}
