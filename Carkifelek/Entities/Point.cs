using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Carkifelek.Entities
{
    public class Point
    {
        [Key]
        public int PointID { get; set; }
        public int PointRate { get; set; }
        public int ProbabilityPercentage { get; set; }
    }
}