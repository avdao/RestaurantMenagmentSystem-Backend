﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;
using Recipes.Models;
using Recipes.Services;
using System.Collections.Generic;

namespace Recipes.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NamirniceController : ControllerBase
    {

        private readonly NamirniceInterface namirnice;


        public NamirniceController(NamirniceInterface namirnice)
        {
           this.namirnice = namirnice;
        }



        [HttpGet]
        public List<Namirnice> get()
        {
            return namirnice.getAllNamirnice();

        }


        [HttpDelete("{id}")]
        public void deleteByid(int id)
        {
            namirnice.deleteById(id);
        }
        [HttpGet("{id}")]
        public Namirnice getByid(int id)
        {
            return namirnice.getById(id);
        }


        [HttpPost]
        public void postData(JObject data)
        {
            namirnice.post(data);
        }

        [HttpPut("{id}")]
        public void edit(Namirnice c)
        {
            namirnice.edit(c);
        }
    }
}
