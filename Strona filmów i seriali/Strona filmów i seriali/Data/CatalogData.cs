using Strona_filmów_i_seriali.Models;

namespace Strona_filmów_i_seriali.Data
{
    public class CatalogData
    {
        public static List<CatalogItem> Items = new()
        {
            new(
                1,
                "Interstellar",
                2014,
                "Sci-Fi",
                "Film",
                8.7,
                "Grupa astronautów wyrusza w niebezpieczną podróż przez tunel czasoprzestrzenny, aby znaleźć nowy dom dla ludzkości.",
                "169 min",
                null,
                null,
                new[] { "Matthew McConaughey", "Anne Hathaway", "Jessica Chastain" }
            ),

            new(
                2,
                "Incepcja",
                2010,
                "Sci-Fi",
                "Film",
                8.8,
                "Złodziej potrafiący wnikać do ludzkich snów otrzymuje zadanie zaszczepienia pomysłu w umyśle swojej ofiary.",
                "148 min",
                null,
                null,
                new[] { "Leonardo DiCaprio", "Joseph Gordon-Levitt", "Tom Hardy" }
            ),

            new(
                3,
                "Breaking Bad",
                2008,
                "Dramat",
                "Serial",
                9.5,
                "Nauczyciel chemii, Walter White, po diagnozie ciężkiej choroby zaczyna produkować narkotyki, aby zabezpieczyć finansowo swoją rodzinę.",
                "Około 47 min / odcinek",
                5,
                62,
                new[] { "Bryan Cranston", "Aaron Paul", "Anna Gunn" }
            ),

            new(
                4,
                "Dark",
                2017,
                "Sci-Fi",
                "Serial",
                8.7,
                "Zaginięcie dziecka w niemieckim miasteczku ujawnia tajemnice czterech rodzin i niezwykłe powiązania między różnymi okresami czasu.",
                "Około 55 min / odcinek",
                3,
                26,
                new[] { "Louis Hofmann", "Lisa Vicari", "Oliver Masucci" }
            )
        };
    }
}
