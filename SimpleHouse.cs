using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheBuilderPattern
{
    public class SimpleHouse : Builder
    {
        //CONCRETE BUILDER 1
        public override void BuildRoof()
        {
            house.Roof = "Simple roof";
        }

        public override void BuildWalls()
        {
            house.Walls = "Simple walls";
        }

        public override void BuildDoors()
        {
            house.Doors = "Simple doors";
        }

        public override void BuildWindows()
        {
            house.Windows = "Simple windows";
        }

        public override void GetHouseType()
        {
            house.HouseType = "Simple House";
        }
    }    
}