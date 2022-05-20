// File:    AppController.cs
// Author:  Ilija
// Created: Wednesday, April 13, 2022 10:03:47 PM
// Purpose: Definition of Class AppController

using Model;
using System;
using System.Collections.Generic;

namespace Controller
{
   public class AppController
   {
      public void Create(App app)
      {
         appService.Create(app);
      }
      
      public void Update(App app)
      {
         appService.Update(app);
      }
      
      public void DeleteById(Guid id)
      {
         appService.DeleteById(id);
      }
      
      public App GetById(Guid id)
      {
         return appService.GetOne(id);
      }
      
      public List<App> GetAll()
      {
         return appService.GetAll();
      }
      
      public Service.AppService appService = new Service.AppService();
   
   }
}