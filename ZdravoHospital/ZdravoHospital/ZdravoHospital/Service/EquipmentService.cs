// File:    EquipmentService.cs
// Author:  User
// Created: Wednesday, April 20, 2022 2:27:21 AM
// Purpose: Definition of Class EquipmentService

using Model;
using System;
using System.Collections.Generic;

namespace Service
{
   public class EquipmentService
   {
      public List<Equipment> GetEquipment()
      {
            return equipmentRepository.GetEquipment();
      }
      
      public Equipment GetById(string id)
      {
            return equipmentRepository.GetById(id);
        }
      
      public Equipment GetByName(string name)
      {
            return equipmentRepository.GetByName(name);
        }
      
      public Repository.EquipmentRepository equipmentRepository = new Repository.EquipmentRepository();
      

    }
}