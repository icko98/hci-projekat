// File:    AppRepository.cs
// Author:  Ilija
// Created: Wednesday, April 13, 2022 10:04:39 PM
// Purpose: Definition of Class AppRepository

using Model;
using System;
using System.Collections.Generic;

namespace Repository
{
    public class AppRepository
    {
        public FileHandler.AppFileHandler afh = new FileHandler.AppFileHandler();
        public void Create(App app)
        {
            App = afh.Load();
            App.Add(app);
            afh.Save(App);
        }

        public void DeleteByAppId(Guid id)
        {
            App = afh.Load();
            int numapps = App.Count;
            for(int i = 0; i < numapps; i++)
            {
                if(App[i].Id == id)
                {
                    App.RemoveAt(i);
                    break;
                }
            }
            afh.Save(App);
        }

        public App GetByID(Guid id)
        {
            App = afh.Load();
            App newapp = null;
            int numapp = App.Count;
            for(int i = 0; i < numapp; i++)
            {
                if(App[i].Id == id)
                { newapp = App[i];  }
            }
        return newapp;
        }

        public List<App> GetAll()
        {
            return afh.Load();
        }

        public void DeleteByDT(System.DateTime dt)
        {
            throw new NotImplementedException();
        }

        public void Update(App app)
        {
            App = afh.Load();
            int numapp = App.Count;
            for(int i=0; i < numapp; i++)
            {
                if(App[i].Id==app.Id)
                {
                    App[i] = app;
                }
            }
            afh.Save(App); 
        }

        public System.Collections.Generic.List<App> app;

        /// <summary>
        /// Property for collection of App
        /// </summary>
        /// <pdGenerated>Default opposite class collection property</pdGenerated>
        public System.Collections.Generic.List<App> App
        {
            get
            {
                if (app == null)
                    app = new System.Collections.Generic.List<App>();
                return app;
            }
            set
            {
                RemoveAllApp();
                if (value != null)
                {
                    foreach (App oApp in value)
                        AddApp(oApp);
                }
            }
        }

        /// <summary>
        /// Add a new App in the collection
        /// </summary>
        /// <pdGenerated>Default Add</pdGenerated>
        public void AddApp(App newApp)
      {
         if (newApp == null)
            return;
         if (this.app == null)
            this.app = new System.Collections.Generic.List<App>();
         if (!this.app.Contains(newApp))
            this.app.Add(newApp);
      }
      
      /// <summary>
      /// Remove an existing App from the collection
      /// </summary>
      /// <pdGenerated>Default Remove</pdGenerated>
      public void RemoveApp(App oldApp)
      {
         if (oldApp == null)
            return;
         if (this.app != null)
            if (this.app.Contains(oldApp))
               this.app.Remove(oldApp);
      }
      
      /// <summary>
      /// Remove all instances of App from the collection
      /// </summary>
      /// <pdGenerated>Default removeAll</pdGenerated>
      public void RemoveAllApp()
      {
         if (app != null)
            app.Clear();
      }
        
   
   }
}