// File:    BasicRenovationFileHandler.cs
// Author:  User
// Created: Wednesday, May 4, 2022 1:24:58 AM
// Purpose: Definition of Class BasicRenovationFileHandler

using Model;
using System;
using System.Collections.Generic;

namespace FileHandler
{
   public class BasicRenovationFileHandler
   {
      
      
      public void Save(List<BasicRenovation> basicRenovation)
      {
            System.IO.File.WriteAllText(path, Newtonsoft.Json.JsonConvert.SerializeObject(basicRenovation));
        }
      
      public List<BasicRenovation> Load()
      {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<List<BasicRenovation>>(System.IO.File.ReadAllText(path));
        }

        private string path = @"..\..\Data\BasicRenovation.txt";

    }
}