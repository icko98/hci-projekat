// File:    RoomService.cs
// Author:  smvul
// Created: Tuesday, April 12, 2022 10:59:59 PM
// Purpose: Definition of Class RoomService

using System;
using System.Collections.Generic;
using Model;

namespace Service
{
   public class RoomService
   {
      public void CreateRoom(Room room)
      {
         roomRepository.CreateRoom(room);
      }
      
      public List<Room> GetRooms()
      {
            return roomRepository.GetRooms();
      }
      
      public void EditRoom(Room room)
      {
            roomRepository.EditRoom(room);
      }
      
      public void DeleteRoom(Room room)
      {
            roomRepository.DeleteRoom(room);
      }
      
      public Room GetById(string id)
      {
            return roomRepository.GetById(id);
      }
      
      public Repository.RoomRepository roomRepository = new Repository.RoomRepository();
   
   }
}