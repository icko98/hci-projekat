// File:    EquipmentController.cs
// Author:  User
// Created: Wednesday, April 20, 2022 2:30:21 AM
// Purpose: Definition of Class EquipmentController

using Model;
using System;
using System.Collections.Generic;

namespace Controller
{
   public class EquipmentController
   {
      public List<Equipment> GetEquipment()
      {
            return equipmentService.GetEquipment();
        }
      
      public Equipment GetById(string id)
      {
            return equipmentService.GetById(id);
        }
      
      public Equipment GetByName(string name)
      {
            return equipmentService.GetByName(name);
        }
      
      public Service.EquipmentService equipmentService = new Service.EquipmentService();
   
   }
}