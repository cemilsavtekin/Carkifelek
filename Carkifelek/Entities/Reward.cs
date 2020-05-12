using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Carkifelek.Entities
{
    public class Reward
    {
        [Key]
        public int RewardID { get; set; }
        public string RewardName { get; set; }
        public int ProbabilityPercentage { get; set; }
        public bool IsAllowedForGetPoint { get; set; }
    }
}