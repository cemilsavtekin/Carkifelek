using Carkifelek.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Carkifelek.Controllers
{
    public class HomeController : Controller
    {
        Random rnd = new Random();
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public JsonResult GetReward()
        {
            try
            {
                List<Entities.Reward> rewards;
                var result = new Entities.Reward();
                var percentage = rnd.Next(1, 101);
                using (CarkifelekContext context = new CarkifelekContext())
                {
                    rewards = context.Rewards.OrderBy(x => x.RewardID).ToList();
                    var counter = 0;
                    rewards.ForEach(x =>
                    {
                        if (percentage > counter && percentage <= (counter + x.ProbabilityPercentage))
                        {
                            result = x;
                            context.EarnedRewards.Add(new Entities.EarnedRewards() { RewardID = x.RewardID });
                            context.SaveChanges();
                        }
                        counter += x.ProbabilityPercentage;
                    });
                }
                return Json(new { success = true, data = result });
            }
            catch (Exception ex)
            {
                return Json(new { success = false, data = ex.Message });
            }
        }

        public JsonResult GetPoint()
        {
            try
            {
                List<Entities.Point> points;
                var result = new Entities.Point();
                var percentage = rnd.Next(1, 101);
                using (CarkifelekContext context = new CarkifelekContext())
                {
                    points = context.Points.OrderBy(x => x.PointID).ToList();
                    var counter = 0;
                    points.ForEach(x =>
                    {
                        if (percentage > counter && percentage <= (counter + x.ProbabilityPercentage))
                        {
                            result = x;
                            context.EarnedPoints.Add(new Entities.EarnedPoints() { PointID = x.PointID });
                            context.SaveChanges();
                        }
                        counter += x.ProbabilityPercentage;
                    });
                }
                return Json(new { success = true, data = result });
            }
            catch (Exception ex)
            {
                return Json(new { success = false, data = ex.Message });
            }
        }

       

    }
}