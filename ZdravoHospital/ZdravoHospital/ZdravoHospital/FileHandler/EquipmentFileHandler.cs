// File:    EquipmentFileHandler.cs
// Author:  User
// Created: Wednesday, April 20, 2022 2:15:41 AM
// Purpose: Definition of Class EquipmentFileHandler

using Model;
using System;
using System.Collections.Generic;

namespace FileHandler
{
   public class EquipmentFileHandler
   {
      
      
      public void Save(List<Equipment> equipment)
      {
            System.IO.File.WriteAllText(path, Newtonsoft.Json.JsonConvert.SerializeObject(equipment));
        }
      
      public List<Equipment> Load()
      {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<List<Equipment>>(System.IO.File.ReadAllText(path));
        }

        private string path = @"..\..\Data\Equipment.txt";

    }
}