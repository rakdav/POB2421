using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson34
{
    internal class Building
    {
        public string? Type {  get; set; }//автоматическое свойство
        private double floorHeight;
        public double FloorHeight
        {
            get { return floorHeight; }
            set { if(value > 0)  floorHeight = value; }
        }
        private double roofHeight;
        public double RoofHeight
        {
            get { return roofHeight; }
            set { if (value > 0) roofHeight = value; }
        }
        private double length;
        public double Length
        {
            get { return length; }
            set { if (value > 0) length = value; }
        }
        private double width;
        public double Width
        {
            get { return width; }
            set { if (value > 0) width = value; }
        }
        private int floorCount;
        public int FloorCount
        {
            get { return floorCount; }
            set { if (value > 0) floorCount = value; }
        }
        private int windowCount;
        public int WindowCount
        {
            get { return windowCount; }
            set { if (value > 0) windowCount = value; }
        }

        private int roomCount;
        public int RoomCount
        {
            get { return roomCount; }
            set { if (value > 0) roomCount = value; }
        }
        public double CalculateBuildingHeight()
        {
            return floorCount * floorHeight + roofHeight;
        }
        public double CalculateBuildingArea()
        {
            return length * width;
        }
        public double CalculateTotalOpenings()
        {
            Random random=new Random();
            return windowCount * roomCount * random.Next(1, 3);
        }
    }
}
