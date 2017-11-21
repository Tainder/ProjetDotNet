using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetDotNet.Models
{
    public class Face
    {
        private Amc amc;
        private Otp otp;
        private Reseau reseau;
        private String dataMatrix;

        public Amc Amc { get => amc; set => amc = value; }
        public Otp Otp { get => otp; set => otp = value; }
        public Reseau Reseau { get => reseau; set => reseau = value; }
        public String DataMatrix { get => dataMatrix; set => dataMatrix = value; }

        public Face(Amc amc, Otp otp, Reseau reseau, String dataMatrix)
        {
            this.Amc = amc;
            this.Otp = otp;
            this.Reseau = reseau;
            this.DataMatrix = dataMatrix;
        }

        public Face()
        {
            this.Amc = new Amc();
            this.Otp = new Otp();
            this.Reseau = new Reseau();
            this.DataMatrix = "";
        }
    }
}