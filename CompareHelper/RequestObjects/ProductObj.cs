using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Compare.Data.APIObjects
{
    public  class AddProductObj
    {
    }

    public class EditProductObj
    {
    }
    public class ProductObj
    {
        [Range(1, long.MaxValue, ErrorMessage = "Please enter valid integer Number")]
        public long ProductId { get; set; }

        [Range(1, long.MaxValue, ErrorMessage = "Please enter valid integer Number")]
        public long ServiceProviderId { get; set; }

        [Range(1, long.MaxValue, ErrorMessage = "Please enter valid integer Number")]
        public long ProductCategoryId { get; set; }

        [Range(1, long.MaxValue, ErrorMessage = "Please enter valid integer Number")]
        public long ProductTypeId { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Project Name is required")]
        [StringLength(100, MinimumLength = 2, ErrorMessage = "Project Name must be between 2 and 100 characters")]
        public string Name { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = " Description is required")]
        [StringLength(300, MinimumLength = 5, ErrorMessage = "Description must be between 5 and 300 characters")]
        public string Description { get; set; }

        public int Status { get; set; }

    }

}
