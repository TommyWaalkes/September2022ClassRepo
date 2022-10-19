using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MockAssessment3
{
    //I think of town as a runner class, it's role is similar to a Controller
    internal class Town
    {
        public List<Villager> VillagerList { get; set; } = new List<Villager>();

        public Town()
        {
            VillagerList.Add(new Farmer());
            VillagerList.Add(new Farmer());
            VillagerList.Add(new Farmer());
            VillagerList.Add(new Slacker());
        }

        public int Harvest()
        {
            int totalFood = 0; 
            foreach(Villager v in VillagerList)
            {
                totalFood += v.Farm();
            }

            return totalFood;
        }

        public int CalcFoodConsumption()
        {
            int totalHunger = 0;

            foreach(Villager v in VillagerList)
            {
                totalHunger += v.Hunger;
            }

            return totalHunger;
        }

        public bool SurviveTheWinter()
        {
            int foodHarvest = Harvest();
            int totalHunger = CalcFoodConsumption();

            if(foodHarvest >= totalHunger)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
