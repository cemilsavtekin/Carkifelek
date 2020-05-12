using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Carkifelek.Entities
{
    public class EarnedPoints
    {
        [Key]
        public int EarnedPointID { get; set; }

        public int PointID { get; set; }
        [ForeignKey("PointID")]
        public Point Point { get; set; }

    }
}