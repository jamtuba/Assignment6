using System.ComponentModel.DataAnnotations;

namespace Assignment6.Models
{
    public class OfferClass
    {
        [Required]
        public string OfferNumber { get; set; }

        [Required]
        public string OfferType { get; set; }

        public string Message { get; set; }

        [Required]
        [StringLength(50, ErrorMessage = "Navnet må højst være på 50 bogstaver")]
        public string FullName { get; set; }

        [Required]
        [EmailAddress(ErrorMessage = "Du skal indtaste din email adresse")]
        public string EmailAddress { get; set; }
    }

    public class OfferClassDTO
    {
        [Required(ErrorMessage = "Du skal vælge en tilbudstype på listen")]
        public string OfferType { get; set; }

        [StringLength(250, ErrorMessage = "Beskeden må højst være på 250 bogstaver")]
        public string Message { get; set; }

        [Required(ErrorMessage = "Du skal indtaste dit fulde navn")]
        [StringLength(50, ErrorMessage = "Navnet må højst være på 50 bogstaver")]
        public string FullName { get; set; }

        [Required(ErrorMessage = "Du skal indtaste din email adresse")]
        [EmailAddress(ErrorMessage = "Det skal være en email adresse")]
        public string EmailAddress { get; set; }
    }
}
