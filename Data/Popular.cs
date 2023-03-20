using System.Text.Json.Serialization;

namespace CinemaApp.Data
{
    public class Result
    {

        [JsonPropertyName("adult")]
        public bool Adult { get; set; }

        [JsonPropertyName("backdrop_path")]
        public string BackdropPath { get; set; } = default!;

        [JsonPropertyName("genre_ids")]
        public IList<int> GenreIds { get; set; } = default!;

        [JsonPropertyName("id")]
        public int Id { get; set; }

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

        [JsonPropertyName("release_date")]
        public string ReleaseDate { get; set; } = default!;

        [JsonPropertyName("title")]
        public string Title { get; set; } = default!;

        [JsonPropertyName("video")]
        public bool Video { get; set; }

        [JsonPropertyName("vote_average")]
        public double VoteAverage { get; set; }

        [JsonPropertyName("vote_count")]
        public int VoteCount { get; set; }
    }

    public class Popular
    {

        [JsonPropertyName("page")]
        public int Page { get; set; }

        [JsonPropertyName("results")]
        public IList<Result> Results { get; set; } = default!;

        [JsonPropertyName("total_pages")]
        public int TotalPages { get; set; }

        [JsonPropertyName("total_results")]
        public int TotalResults { get; set; }
    }
}
