// File:    Room.cs
// Author:  smvul
// Created: Tuesday, April 12, 2022 10:46:10 PM
// Purpose: Definition of Class Room

using System;

namespace Model
{
    public class Room
    {
        private string id;
        private string name;
        private string description;
        private int floor;
        private RoomType roomType;

        public Room(string id, string name, string description, int floor, RoomType roomType)
        {
            Id = id;
            Name = name;
            Description = description;
            Floor = floor;
            RoomType = roomType;
        }

        public string Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Floor { get; set; }
        public RoomType RoomType {get; set;}

   
   }
}