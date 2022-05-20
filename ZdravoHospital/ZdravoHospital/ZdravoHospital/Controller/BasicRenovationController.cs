// File:    BasicRenovationController.cs
// Author:  User
// Created: Wednesday, May 4, 2022 2:00:55 AM
// Purpose: Definition of Class BasicRenovationController

using Model;
using System;
using System.Collections.Generic;

namespace Controller
{
   public class BasicRenovationController
   {
      public void ScheduleRenovation(BasicRenovation basicRenovation)
      {
         basicRenovationService.ScheduleRenovation(basicRenovation);
      }
      
      public List<BasicRenovation> GetScheduledRenovations()
      {
         return basicRenovationService.GetScheduledRenovations();
      }
      
      public Service.BasicRenovationService basicRenovationService = new Service.BasicRenovationService();
   
   }
}