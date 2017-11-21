using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetDotNet.Models
{
    public class Otp
    {
        private int id;
        private String nom;

        public int Id { get => id; set => id = value; }
        public string Nom { get => nom; set => nom = value; }

        public Otp(int id, string nom)
        {
            this.Id = id;
            this.nom = nom;
        }

        public Otp()
        {
            this.Id = -1;
            this.Nom = "nouvelle Otp";
        }

    }
}