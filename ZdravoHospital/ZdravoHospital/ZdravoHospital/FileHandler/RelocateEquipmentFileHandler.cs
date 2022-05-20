// File:    RelocateEquipmentFileHandler.cs
// Author:  User
// Created: Tuesday, May 3, 2022 8:32:07 PM
// Purpose: Definition of Class RelocateEquipmentFileHandler

using Model;
using System;
using System.Collections.Generic;

namespace FileHandler
{
   public class RelocateEquipmentFileHandler
   {
      
      
      public void Save(List<RelocateEquipment> relocateEquipment)
      {
            System.IO.File.WriteAllText(path, Newtonsoft.Json.JsonConvert.SerializeObject(relocateEquipment));
        }
      
      public List<RelocateEquipment> Load()
      {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<List<RelocateEquipment>>(System.IO.File.ReadAllText(path));
        }

        private string path = @"..\..\Data\RelocateEquipment.txt";

    }
}