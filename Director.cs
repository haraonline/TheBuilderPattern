using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheBuilderPattern
{
    public static class Director
    {
        //The Director deligates the job to the builder, the builder inturn uses the Product plan house to build a certain type of house
        //This can be a static or regular class              

        public static void BuildHouse(Builder builder)
        {   
            builder.BuildRoof();
            builder.BuildWalls();
            builder.BuildDoors();
            builder.BuildWindows();
            builder.GetHouseType();
        }
    }
}
