// File:    RelocateEquipmentController.cs
// Author:  User
// Created: Tuesday, May 3, 2022 8:45:12 PM
// Purpose: Definition of Class RelocateEquipmentController

using Model;
using System;
using System.Collections.Generic;

namespace Controller
{
   public class RelocateEquipmentController
   {
      public List<RelocateEquipment> GetEquipment()
      {
            return relocateEquipmentService.GetEquipment();
        }
      
      public void Relocate(RelocateEquipment relocateEquipment)
      {
            relocateEquipmentService.Relocate(relocateEquipment);
        }
      
      public Service.RelocateEquipmentService relocateEquipmentService = new Service.RelocateEquipmentService();
   
   }
}