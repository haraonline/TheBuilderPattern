using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheBuilderPattern
{
    public class House
    {
        //PRODUCT (PLAN)
        public string? Roof { get; set; }
        public string? Walls { get; set; }
        public string? Doors { get; set; }
        public string? Windows { get; set; }
        public string? HouseType { get; set; }


        //override to string.
        public override string ToString()
        {            
            return string.Format($"your {HouseType} is ready for occupation\nRoof: {Roof}\nWalls: {Walls}\nDoors: {Doors}\nWindows: {Windows}");
        }
    }
}
