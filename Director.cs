using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheBuilderPattern
{
    public static class Director
    {
        //DIRECTOR. Deligates the job to the builder
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
