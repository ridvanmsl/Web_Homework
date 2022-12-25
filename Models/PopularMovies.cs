namespace WebAssignmentt.Models
{
    public class PopularMovies
    {
        public string? name { get; set; }
        public int? duration { get; set; }
        public string? imgurl { get; set; }
        public string? category { get; set; }
        public string? viewurl { get; set; }
        public int? id { get; set; }
    }
    public static class PopularMoviesRepo
    {
        private static List<PopularMovies> _popmov = new List<PopularMovies>();

        static PopularMoviesRepo()
        {
            _popmov = new List<PopularMovies>()
            {
                new PopularMovies(){name="Doctor Strange",duration=126,imgurl="https://m.media-amazon.com/images/M/MV5BNWM0ZGJlMzMtZmYwMi00NzI3LTgzMzMtNjMzNjliNDRmZmFlXkEyXkFqcGdeQXVyMTM1MTE1NDMx._V1_FMjpg_UX1000_.jpg",category="Action",viewurl="doctor-strange.cshtml", id=1},
                new PopularMovies(){name="The Northman",duration=137,imgurl="https://m.media-amazon.com/images/M/MV5BMzVlMmY2NTctODgwOC00NDMzLWEzMWYtM2RiYmIyNTNhMTI0XkEyXkFqcGdeQXVyNTAzNzgwNTg@._V1_.jpg",category="Adventure"},
                new PopularMovies(){name="Lord Of The Rings",duration=178,imgurl="https://m.media-amazon.com/images/M/MV5BZGMxZTdjZmYtMmE2Ni00ZTdkLWI5NTgtNjlmMjBiNzU2MmI5XkEyXkFqcGdeQXVyNjU0OTQ0OTY@._V1_.jpg",category="Adventure"},
                new PopularMovies(){name="The Godfather",duration=175,imgurl="https://m.media-amazon.com/images/M/MV5BM2MyNjYxNmUtYTAwNi00MTYxLWJmNWYtYzZlODY3ZTk3OTFlXkEyXkFqcGdeQXVyNzkwMjQ5NzM@._V1_.jpg",category="Crime"},
                new PopularMovies(){name="Pulp Fiction",duration=154,imgurl="https://m.media-amazon.com/images/I/71mlgE7nUdL._AC_UF1000,1000_QL80_.jpg",category="Comedy"},
                new PopularMovies(){name="The Batman",duration=176,imgurl="https://m.media-amazon.com/images/M/MV5BMDdmMTBiNTYtMDIzNi00NGVlLWIzMDYtZTk3MTQ3NGQxZGEwXkEyXkFqcGdeQXVyMzMwOTU5MDk@._V1_FMjpg_UX1000_.jpg",category="Action"},
                new PopularMovies(){name="Dune",duration=155,imgurl="https://imageio.forbes.com/specials-images/imageserve/61116cea2313e8bae55a536a/-Dune-/0x0.jpg?format=jpg&width=960",category="Adventure"},
                new PopularMovies(){name="Interstellar",duration=169,imgurl="https://www.arthipo.com/image/cache/catalog/poster/movie/1-758/pfilm716-interstellar_a074ce1f-movie-film-posteri-1000x1000.jpg",category="Science Fiction"},
                new PopularMovies(){name="Fight Club",duration=139,imgurl="https://img.fruugo.com/product/0/08/14290080_max.jpg",category="Thriller"},
                new PopularMovies(){name="The Shawshank Redemption",duration=144,imgurl="https://m.media-amazon.com/images/M/MV5BMDFkYTc0MGEtZmNhMC00ZDIzLWFmNTEtODM1ZmRlYWMwMWFmXkEyXkFqcGdeQXVyMTMxODk2OTU@._V1_FMjpg_UX1000_.jpg",category="Thriller"},
            };
        }
        public static List<PopularMovies> Popmov
        {
            get
            {
                return _popmov;
            }
        }
    }
}
