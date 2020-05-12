using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Carkifelek.Entities
{
    public class EarnedRewards
    {
        [Key]
        public int EarnedRewardId { get; set; }

        public int RewardID { get; set; }
        [ForeignKey("RewardID")]
        public Reward Reward { get; set; }

    }
}