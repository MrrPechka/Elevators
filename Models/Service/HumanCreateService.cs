﻿using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.Service;

namespace Models.Services
{
    public class HumanCreateService : IHumanCreateService
    {
        private SystemData systemData;
        Type type;

        public HumanCreateService(SystemData systemData)
        {
            this.systemData = systemData;
            type = new FactoryOfHumans(0, 1, null).GetType();
        }

        public void CreateHuman(int number, int locationFloor, int destinationFloor)
        {
            if (locationFloor == destinationFloor)
                throw new Exception("This is stupid");
            systemData.CreateHuman(number, locationFloor, destinationFloor);
        }
    }
}
