// File:    EquipmentRepository.cs
// Author:  User
// Created: Wednesday, April 20, 2022 2:22:32 AM
// Purpose: Definition of Class EquipmentRepository

using Model;
using System;
using System.Collections.Generic;

namespace Repository
{
   public class EquipmentRepository
   {
      public List<Equipment> GetEquipment()
      {
            return equipmentFileHandler.Load();
      }
      
      public Model.Equipment GetById(string id)
      {
            Equipment = equipmentFileHandler.Load();
            Equipment wantedEquipment = null;
            int numberOfEquipment = Equipment.Count;
            for(int i = 0; i < numberOfEquipment; i++)
            {
                if(Equipment[i].Id == id)
                {
                    wantedEquipment = Equipment[i];
                }
            }
            return wantedEquipment;
      }
      
      public Model.Equipment GetByName(string name)
      {
            Equipment = equipmentFileHandler.Load();
            Equipment wantedEquipment = null;
            int numberOfEquipment = Equipment.Count;
            for(int i = 0; i < numberOfEquipment; i++)
            {
                if(Equipment[i].Name == name )
                {
                    wantedEquipment = Equipment[i];
                }
            }

            return wantedEquipment;
      }
      
      public FileHandler.EquipmentFileHandler equipmentFileHandler = new FileHandler.EquipmentFileHandler();
      public System.Collections.Generic.List<Equipment> equipment;

        

        /// <summary>
        /// Property for collection of Model.Equipment
        /// </summary>
        /// <pdGenerated>Default opposite class collection property</pdGenerated>
        public System.Collections.Generic.List<Equipment> Equipment
      {
         get
         {
            if (equipment == null)
               equipment = new System.Collections.Generic.List<Equipment>();
            return equipment;
         }
         set
         {
            RemoveAllEquipment();
            if (value != null)
            {
               foreach (Model.Equipment oEquipment in value)
                  AddEquipment(oEquipment);
            }
         }
      }
      
      /// <summary>
      /// Add a new Model.Equipment in the collection
      /// </summary>
      /// <pdGenerated>Default Add</pdGenerated>
      public void AddEquipment(Model.Equipment newEquipment)
      {
         if (newEquipment == null)
            return;
         if (this.equipment == null)
            this.equipment = new System.Collections.Generic.List<Equipment>();
         if (!this.equipment.Contains(newEquipment))
            this.equipment.Add(newEquipment);
      }
      
      /// <summary>
      /// Remove an existing Model.Equipment from the collection
      /// </summary>
      /// <pdGenerated>Default Remove</pdGenerated>
      public void RemoveEquipment(Model.Equipment oldEquipment)
      {
         if (oldEquipment == null)
            return;
         if (this.equipment != null)
            if (this.equipment.Contains(oldEquipment))
               this.equipment.Remove(oldEquipment);
      }
      
      /// <summary>
      /// Remove all instances of Model.Equipment from the collection
      /// </summary>
      /// <pdGenerated>Default removeAll</pdGenerated>
      public void RemoveAllEquipment()
      {
         if (equipment != null)
            equipment.Clear();
      }
   
   }
}