namespace SabariTest.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ExceptionLogger")]
    public partial class ExceptionLogger
    {
        [Key]
        public int Id { get; set; }

        public string ExceptionMessage { get; set; }

        public string ControllName { get; set; }

        public string ExceptionStackTrace { get; set; }

        public DateTime LogTime { get; set; }
    }
}
