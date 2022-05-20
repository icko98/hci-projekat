// File:    Equipment.cs
// Author:  User
// Created: Wednesday, April 20, 2022 2:19:32 AM
// Purpose: Definition of Class Equipment

using System;

namespace Model
{
   public class Equipment
   {
      private string id;
      private string name;
      private string roomId;
      private int quantity;
      private EquipmentType equipmentType;

    public Equipment(string id, string name, string roomId, int quantity, EquipmentType equipmentType)
        {
            Id = id;
            Name = name;
            RoomId = roomId;
            Quantity = quantity;
            EquipmentType = equipmentType;
        }

        public string Id { get; set; }
        public string Name { get; set; }
        public string RoomId { get; set; }
        public int Quantity { get; set; }
        public EquipmentType EquipmentType { get; set; }
   
   }
}