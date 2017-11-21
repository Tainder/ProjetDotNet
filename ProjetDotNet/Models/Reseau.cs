using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetDotNet.Models
{
    public class Reseau
    {
        private int id;
        private String nom;

        public int Id { get => id; set => id = value; }
        public string Nom { get => nom; set => nom = value; }

        public Reseau(int id, string nom)
        {
            this.Id = id;
            this.Nom = nom;
        }

        public Reseau()
        {
            this.Id = -1;
            this.Nom = "Nouveau réseau";
        }
    }
}