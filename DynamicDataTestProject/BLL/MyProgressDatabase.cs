using DynamicDataTestProject.BLL.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace DynamicDataTestProject.BLL
{
    /// <summary>
    /// Represents an entire database
    /// </summary>
    public class MyProgressDatabase : DbContext
    {
        /// <summary>
        /// A set of exercises stored in MyProgressDatabase
        /// </summary>
        public DbSet<Exercise> Exercises { get; set; }

        /// <summary>
        /// A set of exercise results stored in MyProgressDatabase
        /// </summary>
        public DbSet<ExerciseResult> ExerciseResults { get; set; }
    }
}