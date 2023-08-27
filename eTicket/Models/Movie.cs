using eTicket.Data;
using System.ComponentModel.DataAnnotations;

namespace eTicket.Models
{
    public class Movie
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public double  Price { get; set; }

        public string  ImageURL { get; set; }

        public string StartDate { get; set; }

        public string EndDate { get; set; }

        public MovieCategory MovieCategory { get; set; }
    }
}
