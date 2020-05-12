using System.Data.Entity;

namespace Carkifelek.Context
{
    public class CarkifelekContext:DbContext
    {
        public CarkifelekContext():base("CarkifelekDB")
        {
        }

        public DbSet<Entities.Point> Points { get; set; }   
        public DbSet<Entities.Reward> Rewards { get; set; }
        public DbSet<Entities.EarnedRewards> EarnedRewards { get; set; }
        public DbSet<Entities.EarnedPoints> EarnedPoints { get; set; }
    }
}