using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DynamicDataTestProject.BLL.Models
{
    /// <summary>
    /// Represents a measurement unit for exercise results
    /// </summary>
    [DisplayName("Measurement units")]
    public class MeasurementUnit
    {
        /// <summary>
        /// ID of mea
        /// </summary>
        [Key, ScaffoldColumn(false)]
        public int MeasurementUnitID { get; set; }

        /// <summary>
        /// Measurement unit name
        /// </summary>
        [DataType(DataType.Text)]
        public string Name { get; set; }
    }
}