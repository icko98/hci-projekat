// File:    RoomFileHandler.cs
// Author:  smvul
// Created: Tuesday, April 12, 2022 10:51:12 PM
// Purpose: Definition of Class RoomFileHandler

using System;
using System.Collections.Generic;
using Model;

namespace FileHandler
{
   public class RoomFileHandler
   {
      public void Save(List<Room> rooms)
      {
            System.IO.File.WriteAllText(path, Newtonsoft.Json.JsonConvert.SerializeObject(rooms));
      }
      
      public List<Room> Load()
      {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<List<Room>>(System.IO.File.ReadAllText(path));
      }

        private string path = @"..\..\Data\Rooms.txt";
   }
}