// File:    BasicRenovation.cs
// Author:  User
// Created: Wednesday, May 4, 2022 1:24:42 AM
// Purpose: Definition of Class BasicRenovation

using System;

namespace Model
{
   public class BasicRenovation
   {
      private string roomId;
      private System.DateTime startDate;
      private System.DateTime endDate;
      private string description;

        public BasicRenovation(string roomId, System.DateTime startDate, System.DateTime endDate, string description)
        {
            RoomId = roomId;
            StartDate = startDate;
            EndDate = endDate;  
            Description = description;
        }

        public string RoomId { get; set; }
        public System.DateTime StartDate { get; set; }
        public System.DateTime EndDate { get; set; }
        public string Description { get; set; }
   
   }
}