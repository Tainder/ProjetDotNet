using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetDotNet.Models
{
    public class Amc
    {
        private int id;
        private String nom;

        public int Id { get => id; set => id = value; }
        public string Nom { get => nom; set => nom = value; }

        public Amc(int id, string nom)
        {
            this.Id = id;
            this.Nom = nom;
        }

        public Amc()
        {
            this.Id = -1;
            this.Nom = "Nouvelle AMC";
        }

    }
}