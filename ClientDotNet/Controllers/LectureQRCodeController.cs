using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Newtonsoft.Json;
using ZXing;
using System.IO;
using System.Drawing;

namespace ProjetDotNet.Controllers.LectureQRCode
{
    public class LectureQRCodeController : Controller
    {
        private object fileUpload;

        // GET: LectureQRCode
        public ActionResult Index()
        {

            //Trouver qr code dans une image
            var reader = new BarcodeReader();
            //Saving the uploaded image and reading from it
            var fileName = Path.Combine(Request.MapPath("~/Content"), "QR.png");
            var result = reader.Decode(new Bitmap(fileName));

            return Json(result.Text, JsonRequestBehavior.AllowGet);
        }
        public class check
        {
            public string value { get; set; }
        }
    }
}