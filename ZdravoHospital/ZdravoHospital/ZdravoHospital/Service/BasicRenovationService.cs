// File:    BasicRenovationService.cs
// Author:  User
// Created: Wednesday, May 4, 2022 1:58:10 AM
// Purpose: Definition of Class BasicRenovationService

using Model;
using System;
using System.Collections.Generic;

namespace Service
{
   public class BasicRenovationService
   {
      public void ScheduleRenovation(BasicRenovation basicRenovation)
      {
         basicRenovationRepository.ScheduleRenovation(basicRenovation);
      }
      
      public List<BasicRenovation> GetScheduledRenovations()
      {
         return basicRenovationRepository.GetScheduledRenovations();
      }
      
      public Repository.BasicRenovationRepository basicRenovationRepository = new Repository.BasicRenovationRepository();
   
   }
}