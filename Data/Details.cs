using System.Text.Json.Serialization;

namespace CinemaApp.Data
{
    public class BelongsToCollection
    {

        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; } = default!;

        [JsonPropertyName("poster_path")]
        public string PosterPath { get; set; } = default!;

        [JsonPropertyName("backdrop_path")]
        public string BackdropPath { get; set; } = default!;
    }

    public class Genre
    {

        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; } = default!;
    }

    public class ProductionCompany
    {

        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("logo_path")]
        public string LogoPath { get; set; } = default!;

        [JsonPropertyName("name")]
        public string Name { get; set; } = default!;

        [JsonPropertyName("origin_country")]
        public string OriginCountry { get; set; } = default!;
    }

    public class ProductionCountry
    {

        [JsonPropertyName("iso_3166_1")]
        public string Iso31661 { get; set; } = default!;

        [JsonPropertyName("name")]
        public string Name { get; set; } = default!;
    }

    public class SpokenLanguage
    {

        [JsonPropertyName("english_name")]
        public string EnglishName { get; set; } = default!;

        [JsonPropertyName("iso_639_1")]
        public string Iso6391 { get; set; } = default!;

        [JsonPropertyName("name")]
        public string Name { get; set; } = default!;
    }

    public class Details
    {

        [JsonPropertyName("adult")]
        public bool Adult { get; set; }

        [JsonPropertyName("backdrop_path")]
        public string BackdropPath { get; set; } = default!;

        [JsonPropertyName("belongs_to_collection")]
        public BelongsToCollection BelongsToCollection { get; set; } = default!;

        [JsonPropertyName("budget")]
        public int Budget { get; set; }

        [JsonPropertyName("genres")]
        public IList<Genre> Genres { get; set; } = default!;

        [JsonPropertyName("homepage")]
        public string Homepage { get; set; } = default!;

        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("imdb_id")]
        public string ImdbId { get; set; } = default!;

        [JsonPropertyName("original_language")]
        public string OriginalLanguage { get; set; } = default!;

        [JsonPropertyName("original_title")]
        public string OriginalTitle { get; set; } = default!;

        [JsonPropertyName("overview")]
        public string Overview { get; set; } = default!;

        [JsonPropertyName("popularity")]
        public double Popularity { get; set; }

        [JsonPropertyName("poster_path")]
        public string PosterPath { get; set; } = default!;

        [JsonPropertyName("production_companies")]
        public IList<ProductionCompany> ProductionCompanies { get; set; } = default!;

        [JsonPropertyName("production_countries")]
        public IList<ProductionCountry> ProductionCountries { get; set; } = default!;

        [JsonPropertyName("release_date")]
        public string ReleaseDate { get; set; } = default!;

        [JsonPropertyName("revenue")]
        public double Revenue { get; set; }

        [JsonPropertyName("runtime")]
        public int Runtime { get; set; }

        [JsonPropertyName("spoken_languages")]
        public IList<SpokenLanguage> SpokenLanguages { get; set; } = default!;

        [JsonPropertyName("status")]
        public string Status { get; set; } = default!;

        [JsonPropertyName("tagline")]
        public string Tagline { get; set; } = default!;

        [JsonPropertyName("title")]
        public string Title { get; set; } = default!;

        [JsonPropertyName("video")]
        public bool Video { get; set; }

        [JsonPropertyName("vote_average")]
        public double VoteAverage { get; set; }

        [JsonPropertyName("vote_count")]
        public int VoteCount { get; set; }
    }


}
