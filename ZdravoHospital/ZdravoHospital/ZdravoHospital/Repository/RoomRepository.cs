// File:    RoomRepository.cs
// Author:  smvul
// Created: Tuesday, April 12, 2022 10:59:59 PM
// Purpose: Definition of Class RoomRepository

using System;
using System.Collections.Generic;
using System.Windows;
using Model;

namespace Repository
{
   public class RoomRepository
   {
      public void CreateRoom(Room room)
      {
            Room = roomFileHandler.Load();
            Room.Add(room);
            roomFileHandler.Save(Room);
        }
      
      public List<Room> GetRooms()
      {
            return roomFileHandler.Load();
      }
      
      public void EditRoom(Room room)
      {
            Room = roomFileHandler.Load();
            int numberOfRooms = Room.Count;
            for (int i = 0; i< numberOfRooms; i++)
            {
                if(Room[i].Id == room.Id)
                {
                     Room[i] = room;

                }

            }

            roomFileHandler.Save(Room);

        }
      
      public void DeleteRoom(Room room)
      {
            Room = roomFileHandler.Load();
            int numberOfRooms = Room.Count;
            for(int i = 0; i < numberOfRooms; i++)
            {
                if(Room[i].Id == room.Id)
                {
                    Room.RemoveAt(i);
                }
            }
            
            roomFileHandler.Save(Room);
      }

      public Model.Room GetById(string id)
      {
            Room = roomFileHandler.Load();
            Room wantedRoom = null;
            int numberOfRooms = Room.Count;
            for(int i = 0; i < numberOfRooms; i++)
            {
                if(Room[i].Id == id)
                {
                    wantedRoom = Room[i];
                }
            }

            return wantedRoom;
        }

      public FileHandler.RoomFileHandler roomFileHandler = new FileHandler.RoomFileHandler();
      public System.Collections.Generic.List<Room> room;
      
      /// <summary>
      /// Property for collection of Model.Room
      /// </summary>
      /// <pdGenerated>Default opposite class collection property</pdGenerated>
      public System.Collections.Generic.List<Room> Room
      {
         get
         {
            if (room == null)
               room = new System.Collections.Generic.List<Room>();
            return room;
         }
         set
         {
            RemoveAllRoom();
            if (value != null)
            {
               foreach (Model.Room oRoom in value)
                  AddRoom(oRoom);
            }
         }
      }
      
      /// <summary>
      /// Add a new Model.Room in the collection
      /// </summary>
      /// <pdGenerated>Default Add</pdGenerated>
      public void AddRoom(Model.Room newRoom)
      {
         if (newRoom == null)
            return;
         if (this.room == null)
            this.room = new System.Collections.Generic.List<Room>();
         if (!this.room.Contains(newRoom))
            this.room.Add(newRoom);
      }
      
      /// <summary>
      /// Remove an existing Model.Room from the collection
      /// </summary>
      /// <pdGenerated>Default Remove</pdGenerated>
      public void RemoveRoom(Model.Room oldRoom)
      {
         if (oldRoom == null)
            return;
         if (this.room != null)
            if (this.room.Contains(oldRoom))
               this.room.Remove(oldRoom);
      }
      
      /// <summary>
      /// Remove all instances of Model.Room from the collection
      /// </summary>
      /// <pdGenerated>Default removeAll</pdGenerated>
      public void RemoveAllRoom()
      {
         if (room != null)
            room.Clear();
      }
   
   }
}