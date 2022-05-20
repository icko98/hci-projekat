// File:    BasicRenovationRepository.cs
// Author:  User
// Created: Wednesday, May 4, 2022 1:27:28 AM
// Purpose: Definition of Class BasicRenovationRepository

using Model;
using System;
using System.Collections.Generic;

namespace Repository
{
   public class BasicRenovationRepository
   {
      public void ScheduleRenovation(Model.BasicRenovation basicRenovation)
      {
            BasicRenovation = basicRenovationFileHandler.Load();
            BasicRenovation.Add(basicRenovation);
            basicRenovationFileHandler.Save(BasicRenovation);
      }
      
      public List<BasicRenovation> GetScheduledRenovations()
      {
            return basicRenovationFileHandler.Load();
      }
      
      public FileHandler.BasicRenovationFileHandler basicRenovationFileHandler = new FileHandler.BasicRenovationFileHandler();
      //public Model.BasicRenovation[] basicRenovation;
      public List<BasicRenovation> basicRenovation;

        public List<BasicRenovation> BasicRenovation
        { get
            {
                if(basicRenovation == null)
                    basicRenovation = new List<BasicRenovation>();
                return basicRenovation;
            }
            set
            {
                RemoveAllBasicRenovation();
                if(value != null)
                {
                    foreach (BasicRenovation oBasicRenovation in value)
                        AddBasicRenovation(oBasicRenovation);
                }
            }
        }

        public void AddBasicRenovation(BasicRenovation newBasicRenovation)
        {
            if (newBasicRenovation == null)
                return;
            if (this.basicRenovation == null)
                this.basicRenovation = new List<BasicRenovation>();
            if (!this.basicRenovation.Contains(newBasicRenovation))
                this.basicRenovation.Add(newBasicRenovation);
        }

        public void RemoveAllBasicRenovation()
        {
            if (basicRenovation != null)
                basicRenovation.Clear();
        }

    }
}