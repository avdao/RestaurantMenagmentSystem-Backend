﻿using Newtonsoft.Json.Linq;
using Recipes.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Recipes.Services
{
    public class NamirniceService : NamirniceInterface
    {

        private RecipesContext rc1;


        public NamirniceService(RecipesContext rc1)
        {

            this.rc1 = rc1;
        }
        public void deleteById(int id)
        {
            rc1.Namirnices.Remove(rc1.Namirnices.Find(id));
            rc1.SaveChanges();
        }

        public void edit(Namirnice c)
        {
            rc1.Namirnices.Update(c);
            rc1.SaveChanges();
        }

        public List<Namirnice> getAllNamirnice()
        {
            return rc1.Namirnices.ToList();
        }

        public Namirnice getById(int id)
        {
            return rc1.Namirnices.Find(id);
        }

        public void post(JObject data)
        {
            Namirnice n = data["data"].ToObject<Namirnice>();
            decimal minValue = data["minValue"].ToObject<decimal>();

            Skladiste storage = new Skladiste();
            storage.FkNamirniceNavigation= n;
            storage.MinKolicina = minValue;
            rc1.Skladistes.Add(storage);




            rc1.Skladistes.Add(storage);
            rc1.Namirnices.Add(n);


            rc1.SaveChanges();
        }
    }
}
