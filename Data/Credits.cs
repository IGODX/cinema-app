using System.Text.Json.Serialization;

namespace CinemaApp.Data
{
    public class Cast
    {

        [JsonPropertyName("adult")]
        public bool Adult { get; set; }

        [JsonPropertyName("gender")]
        public int Gender { get; set; }

        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("known_for_department")]
        public string KnownForDepartment { get; set; } = default!;

        [JsonPropertyName("name")]
        public string Name { get; set; } = default!;

        [JsonPropertyName("original_name")]
        public string OriginalName { get; set; } = default!;

        [JsonPropertyName("popularity")]
        public double Popularity { get; set; }

        [JsonPropertyName("profile_path")]
        public string ProfilePath { get; set; } = default!;

        [JsonPropertyName("cast_id")]
        public int CastId { get; set; }

        [JsonPropertyName("character")]
        public string Character { get; set; } = default!;

        [JsonPropertyName("credit_id")]
        public string CreditId { get; set; } = default!;

        [JsonPropertyName("order")]
        public int Order { get; set; }
    }

    public class Crew
    {

        [JsonPropertyName("adult")]
        public bool Adult { get; set; }

        [JsonPropertyName("gender")]
        public int Gender { get; set; }

        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("known_for_department")]
        public string KnownForDepartment { get; set; } = default!;

        [JsonPropertyName("name")]
        public string Name { get; set; } = default!;

        [JsonPropertyName("original_name")]
        public string OriginalName { get; set; } = default!;

        [JsonPropertyName("popularity")]
        public double Popularity { get; set; }

        [JsonPropertyName("profile_path")]
        public string ProfilePath { get; set; } = default!;

        [JsonPropertyName("credit_id")]
        public string CreditId { get; set; } = default!;

        [JsonPropertyName("department")]
        public string Department { get; set; } = default!;

        [JsonPropertyName("job")]
        public string Job { get; set; } = default!;
    }

    public class Credits
    {

        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("cast")]
        public IList<Cast> Cast { get; set; } = default!;

        [JsonPropertyName("crew")]
        public IList<Crew> Crew { get; set; } = default!;
    }

}
