using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetDotNet.Models
{
    public class CarteTiersPayant
    {
        private int id;
        private int idPatient;
        private Face faceRecto;
        private Face faceVerso;
        private String imgSource;

        public int Id { get => id; set => id = value; }
        public int IdPatient { get => idPatient; set => idPatient = value; }
        public Face FaceRecto { get => faceRecto; set => faceRecto = value; }
        public Face FaceVerso { get => faceVerso; set => faceVerso = value; }
        public string ImgSource { get => imgSource; set => imgSource = value; }

        public CarteTiersPayant(int id, int idPatient, Face faceRecto, Face faceVerso, string imgSource)
        {
            this.Id = id;
            this.IdPatient = idPatient;
            this.FaceRecto = faceRecto;
            this.FaceVerso = faceVerso;
            this.ImgSource = imgSource;
        }

        public CarteTiersPayant()
        {
            this.Id = -1;
            this.IdPatient = -1;
            this.FaceRecto = new Face();
            this.FaceVerso = new Face();
            this.ImgSource = "";
        }
    }
}