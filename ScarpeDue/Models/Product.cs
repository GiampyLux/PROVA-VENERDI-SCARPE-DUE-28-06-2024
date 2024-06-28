using System.ComponentModel.DataAnnotations;

namespace ScarpeDue.Models
    {
        public class Product
        {
            public int Id { get; set; }

            [Required]
            public string? Name { get; set; }

            [Required]
            public decimal Price { get; set; }

            public string? Description { get; set; }

            public string? CoverImageUrl { get; set; }

            public string? AdditionalImage1Url { get; set; }

            public string? AdditionalImage2Url { get; set; }
        }
    }



