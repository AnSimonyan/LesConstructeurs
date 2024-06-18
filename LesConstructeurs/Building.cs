using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LesConstructeurs
{
    internal class Building
    {
        private int _numberOfFloors { get; set; }
        private int _buildingSize { get; set; }
        public int _height { get; set; } = 3;

        public Building(int numberOfFloors, int buildingSize = 0)
        {
            _numberOfFloors = numberOfFloors;
            if (buildingSize != 0)
            {
                _buildingSize = buildingSize;
            }
            else
            {
                _buildingSize = numberOfFloors * _height;
            }
        }

        public int GetFloorMaxSize()
        {
            if (_numberOfFloors != 0)
            {
                return _buildingSize / _numberOfFloors;
            }
            else 
            {
                return 0;
            }
                
        }

        public int GetSize()
        {
            return _buildingSize;
        }

        public int SetHight(int hight)
        {
            return _height = hight;
        }
    }
}
