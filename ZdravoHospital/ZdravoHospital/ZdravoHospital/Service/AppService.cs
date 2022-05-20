// File:    AppService.cs
// Author:  Ilija
// Created: Wednesday, April 13, 2022 10:04:57 PM
// Purpose: Definition of Class AppService

using Model;
using System;
using System.Collections.Generic;

namespace Service
{
   public class AppService
   {
        public Repository.AppRepository apr = new Repository.AppRepository();
        public App GetOne(Guid id)
      {
         return apr.GetByID(id);
      }
      
      public List<App> GetAll()
      {
         return apr.GetAll();
      }
      
      public App GetByDT(System.DateTime dt)
      {
         throw new NotImplementedException();
      }
      
      public void Create(App app)
      {
            apr.Create(app);
      }
      
      public void DeleteById(Guid id)
      {
         apr.DeleteByAppId(id);
      }
      
      public void Update(App app)
      {
         apr.Update(app);
      }
      
      
   
   }
}