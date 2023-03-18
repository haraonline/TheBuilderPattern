using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheBuilderPattern
{
    public abstract class Builder
    {
        //The builder needs the Product (plan) of the house to build one
        protected House house = new House();

        public abstract void BuildRoof();
        public abstract void BuildWalls();
        public abstract void BuildDoors();
        public abstract void BuildWindows();
        public abstract void GetHouseType();

        public House GetHouse()
        {
            return house; //This returned product object is inturn used in by the Concreate Builder to build a specific type of house
        }        
    }
}
