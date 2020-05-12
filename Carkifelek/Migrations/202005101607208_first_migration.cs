namespace Carkifelek.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class first_migration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.EarnedPoints",
                c => new
                    {
                        EarnedPointID = c.Int(nullable: false, identity: true),
                        PointID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.EarnedPointID)
                .ForeignKey("dbo.Points", t => t.PointID, cascadeDelete: true)
                .Index(t => t.PointID);
            
            CreateTable(
                "dbo.Points",
                c => new
                    {
                        PointID = c.Int(nullable: false, identity: true),
                        PointRate = c.Int(nullable: false),
                        ProbabilityPercentage = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.PointID);
            
            CreateTable(
                "dbo.EarnedRewards",
                c => new
                    {
                        EarnedRewardId = c.Int(nullable: false, identity: true),
                        RewardID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.EarnedRewardId)
                .ForeignKey("dbo.Rewards", t => t.RewardID, cascadeDelete: true)
                .Index(t => t.RewardID);
            
            CreateTable(
                "dbo.Rewards",
                c => new
                    {
                        RewardID = c.Int(nullable: false, identity: true),
                        RewardName = c.String(),
                        ProbabilityPercentage = c.Int(nullable: false),
                        IsAllowedForGetPoint = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.RewardID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.EarnedRewards", "RewardID", "dbo.Rewards");
            DropForeignKey("dbo.EarnedPoints", "PointID", "dbo.Points");
            DropIndex("dbo.EarnedRewards", new[] { "RewardID" });
            DropIndex("dbo.EarnedPoints", new[] { "PointID" });
            DropTable("dbo.Rewards");
            DropTable("dbo.EarnedRewards");
            DropTable("dbo.Points");
            DropTable("dbo.EarnedPoints");
        }
    }
}
