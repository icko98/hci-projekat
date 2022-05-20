// File:    AppFileHandler.cs
// Author:  Ilija
// Created: Wednesday, April 13, 2022 10:04:05 PM
// Purpose: Definition of Class AppFileHandler

using Model;
using System;
using System.Collections.Generic;

namespace FileHandler
{
   public class AppFileHandler
   {
      private string path = @"..\..\Data\Apps.txt";

        public void Save(List<App> apps)
      {
         System.IO.File.WriteAllText(path,Newtonsoft.Json.JsonConvert.SerializeObject(apps));
      }
      
      public List<App> Load()
      {
         return Newtonsoft.Json.JsonConvert.DeserializeObject<List<App>>(System.IO.File.ReadAllText(path));
        }
       
    }
}