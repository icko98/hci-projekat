// File:    RelocateEquipment.cs
// Author:  User
// Created: Tuesday, May 3, 2022 8:15:13 PM
// Purpose: Definition of Class RelocateEquipment

using System;

namespace Model
{
   public class RelocateEquipment
   {
      private string id;
      private int quantity;
      private string nextRoomId;
      private System.DateTime date;

        public RelocateEquipment(string id, int quantity, string nextRoomId, System.DateTime date)
        {
            Id = id;
            Quantity = quantity;
            NextRoomId = nextRoomId;    
            Date = date;
        }

        public string Id { get; set; }
        public int Quantity { get; set; }
        public string NextRoomId { get; set; }
        public System.DateTime Date { get; set; }
   
   }
}