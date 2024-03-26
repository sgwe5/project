namespace filmLib
{
    public class Film
    {
        public const int MAX_LENGTH = 100;
        private Film(Guid id, string name, string genre, decimal year)
        {
            Id = id;
            Name = name;
            Genre = genre;
            Year = year;
        }
        public Guid Id { get; }

        public string Name { get; } = string.Empty;

        public string Genre { get; } = string.Empty;

        public decimal Year { get; }

        public static (Film Film, string Error) Create(Guid id, string name, string genre, decimal year)
        {
            var error = string.Empty;

            if (string.IsNullOrEmpty(name) || name.Length > MAX_LENGTH)
            {
                error = "Название слишком длинное, максимум 100 символов";
            }
            if (string.IsNullOrEmpty(genre) || genre.Length > MAX_LENGTH)
            {
                error = "Название слишком длинное, максимум 100 символов";
            }

            var film = new Film(id, name, genre, year);
            return (film, error);
        }
    }
}

