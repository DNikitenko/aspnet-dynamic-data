using DataAnnotationsExtensions;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DynamicDataTestProject.BLL.Models
{
    /// <summary>
    /// Represents a kind of sport exercise
    /// </summary>
    public class Exercise
    {
        /// <summary>
        /// ID of exercise
        /// </summary>
        [Key, ScaffoldColumn(false)]
        public int ExerciseID { get; set; }

        /// <summary>
        /// Exercise's name
        /// </summary>
        [Required]
        public string Name { get; set; }

        /// <summary>
        /// Contains detailed explanation of exercise
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Absolute record had been set up to the moment
        /// </summary>
        [Min(0)]
        public double WorldRecord { get; set; }
    }
}