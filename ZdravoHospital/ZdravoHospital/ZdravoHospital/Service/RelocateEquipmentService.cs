// File:    RelocateEquipmentService.cs
// Author:  User
// Created: Tuesday, May 3, 2022 8:42:54 PM
// Purpose: Definition of Class RelocateEquipmentService

using Model;
using System;
using System.Collections.Generic;

namespace Service
{
   public class RelocateEquipmentService
   {
      public List<RelocateEquipment> GetEquipment()
      {
            return relocateEquipmentRepository.GetEquipment();
        }
      
      public void Relocate(RelocateEquipment relocateEquipment)
      {
            relocateEquipmentRepository.Relocate(relocateEquipment);
        }
      
      public Repository.RelocateEquipmentRepository relocateEquipmentRepository = new Repository.RelocateEquipmentRepository();
   
   }
}