using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheBuilderPattern
{
    public class WoodenHouse: Builder
    {
        //CONCRETE BUILDER 2
        
        public override void BuildRoof()
        {
            house.Roof = "Wooden Roof";
        }

        public override void BuildWalls()
        {
            house.Walls = "Wooden Walls";
        }

        public override void BuildDoors()
        {
            house.Doors = "Wooden Doors";
        }

        public override void BuildWindows()
        {
            house.Windows = "Wooden Windows";
        }

        public override void GetHouseType()
        {
            house.HouseType = "Wooden House";
        }
    }
}
