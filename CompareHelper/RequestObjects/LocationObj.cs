using System.ComponentModel.DataAnnotations;

namespace AfriCompare.Business.Services
{
    public class AddLocationObj
    {
            [StringLength(200)]
            [Required(AllowEmptyStrings = false, ErrorMessage = " LocationName is required")]
            public string LocationName { get; set; }

            [Range(0, float.MaxValue, ErrorMessage = "Please enter valid  Lattitude")]
            public decimal Lattitude { get; set; }

            [Range(0, float.MaxValue, ErrorMessage = "Please enter valid  Longitude")]
            public decimal Longitude { get; set; }
        }


    public class EditLocationObj
    {
            [Range(0, long.MaxValue, ErrorMessage = "Please enter valid Location Id")]
            public long LocationId { get; set; }

            [StringLength(200)]
            [Required(AllowEmptyStrings = false, ErrorMessage = " LocationName is required")]
            public string LocationName { get; set; }

            [Range(0, float.MaxValue, ErrorMessage = "Please enter valid  Lattitude")]
            public decimal Lattitude { get; set; }

            [Range(0, float.MaxValue, ErrorMessage = "Please enter valid  Longitude")]
            public decimal Longitude { get; set; }
    }

    public class DeleteLocationObj
    {
            [Range(0, long.MaxValue, ErrorMessage = "Please enter valid Location Id")]
            public long LocationId { get; set; }
    }
}