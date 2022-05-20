// File:    RelocateEquipmentRepository.cs
// Author:  User
// Created: Tuesday, May 3, 2022 8:26:09 PM
// Purpose: Definition of Class RelocateEquipmentRepository

using Model;
using System;
using System.Collections.Generic;

namespace Repository
{
   public class RelocateEquipmentRepository
   {
      public List<RelocateEquipment> GetEquipment()
      {
            return relocateEquipmentFileHandler.Load();
      }
      
      public void Relocate(Model.RelocateEquipment relocateEquipment)
      {
            RelocateEquipment = relocateEquipmentFileHandler.Load();
            RelocateEquipment.Add(relocateEquipment);
            relocateEquipmentFileHandler.Save(RelocateEquipment);
        }

        //public Model.RelocateEquipment[] relocateEquipment;
        public List<RelocateEquipment> relocateEquipment;
      public FileHandler.RelocateEquipmentFileHandler relocateEquipmentFileHandler = new FileHandler.RelocateEquipmentFileHandler();

        

        public List<RelocateEquipment> RelocateEquipment
        {
            get
            {
                if (relocateEquipment == null)
                    relocateEquipment = new List<RelocateEquipment>();
                return relocateEquipment;
            }
            set
            {
                RemoveAllRelocateEquipment();
                if (value != null)
                {
                    foreach (RelocateEquipment oRelocateEquipment in value)
                        AddRelocateEquipment(oRelocateEquipment);
                }
            }
        }

        public void AddRelocateEquipment(RelocateEquipment newRelocateEquipment)
        {
            if (newRelocateEquipment == null)
                return;
            if (this.relocateEquipment == null)
                this.relocateEquipment = new List<RelocateEquipment>();
            if (!this.relocateEquipment.Contains(newRelocateEquipment))
                this.relocateEquipment.Add(newRelocateEquipment);
        }

        public void RemoveAllRelocateEquipment()
        {
            if (relocateEquipment != null)
                relocateEquipment.Clear();
        }

    }
}