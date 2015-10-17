using DataAnnotationsExtensions;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DynamicDataTestProject.BLL.Models
{
    /// <summary>
    /// An instance of result for concrete training session
    /// </summary>
    public class ExerciseResult
    {
        /// <summary>
        /// Result ID
        /// </summary>
        [Key, ScaffoldColumn(false)]
        public int ExerciseResultID { get; set; }

        /// <summary>
        /// Exercise result value
        /// </summary>
        [Min(0)]
        public double Value { get; set; }

        /// <summary>
        /// Date when result has been established
        /// </summary>
        [Required]
        public DateTime DatePerformed { get; set; }

        /// <summary>
        /// Related exercise ID
        /// </summary>
        public int ExerciseID { get; set; }

        /// <summary>
        /// Related exercise object
        /// </summary>
        public virtual Exercise Exercise { get; set; }
    }
}