using System;
using AfriCompare.Data.Entities;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel.DataAnnotations;
using AfriCompare.Common;

namespace AfriCompare.Data.APIObjs
{
    public class ParameterObj
    {
        [Range(1, int.MaxValue, ErrorMessage = "Please enter valid integer Number")]
        public int ParameterId { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Parameter Name is required")]
        [StringLength(100, MinimumLength = 2, ErrorMessage = "Parameter Name must be between 2 and 100 characters")]
        public string ParameterName { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Parameter Description is required")]
        [StringLength(300, MinimumLength = 5, ErrorMessage = "Parameter Description must be between 5 and 300 characters")]
        public string ParameterDescription { get; set; }
        public int ParameterNameHash { get; set; }

        public ParameterInputType ParameterInputType { get; set; }
        public Status Status { get; set; }
    }
}