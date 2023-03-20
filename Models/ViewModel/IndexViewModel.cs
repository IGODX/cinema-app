using CinemaApp.Data;

namespace CinemaApp.Models.ViewModel
{
    public class IndexViewModel
    {
        public Popular Popular { get; set; } = default!;


        public string? Search { get; set; }
    }
}
