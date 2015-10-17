using DataAnnotationsExtensions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DynamicDataTestProject.BLL.Models
{
    /// <summary>
    /// An instance of result for concrete training session
    /// </summary>
    [DisplayName("Exercise results")]
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
        [Required, Display(Name = "Date performed"), DataType(DataType.Date)]
        public DateTime DatePerformed { get; set; }

        /// <summary>
        /// Related exercise object
        /// </summary>
        public virtual Exercise Exercise { get; set; }

        /// <summary>
        /// Measurement unit for value
        /// </summary>
        /// 
        public virtual MeasurementUnit MeasurementUnit { get; set; }
    }
}