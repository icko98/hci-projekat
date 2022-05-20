// File:    RoomController.cs
// Author:  smvul
// Created: Tuesday, April 12, 2022 10:59:59 PM
// Purpose: Definition of Class RoomController

using System;
using System.Collections.Generic;
using Model;

namespace Controller
{
   public class RoomController
   {
      public void CreateRoom(Room room)
      {
         roomService.CreateRoom(room);
      }
      
      public List<Room> GetRooms()
      {
         return roomService.GetRooms();
      }
      
      public void EditRoom(Room room)
      {
         roomService.EditRoom(room);
      }
      
      public void DeleteRoom(Room room)
      {
            roomService.DeleteRoom(room);
      }
      
      public Room GetById(string id)
      {
            return roomService.GetById(id);
      }
      
      public Service.RoomService roomService = new Service.RoomService();
   
   }
}