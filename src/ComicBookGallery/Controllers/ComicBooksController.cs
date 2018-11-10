using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace ComicBookGallery.Controllers
{
    public class ComicBooksController : Controller
    {
        public ActionResult Detail()
        {
            var comicBook = new ComicBook()
            {
                SeriesTitle = "The Amazing Spider-Man",
                IssueNumber = 700,
                Favorite = true,
                DescriptionHtml = 
                    "<p>Final issue! Witness the final hours of Doctor Octopus' life and his one, last, great act of revenge! Even if Spider-Man survives... <strong>will Peter Parker?</strong></p>",
                Artists = new Artists[]
                {
                    new Artists() {Name = "Dan Slott", Role = "Script"},
                    new Artists() {Name = "Humberto Ramos", Role = "Pencils"},
                    new Artists() {Name = "Victor Olazaba", Role = "Inks"},
                    new Artists() {Name = "Edgar Delgado", Role = "Colors"},
                    new Artists() {Name = "Chris Eliopoulos", Role = "Letters"},

                }

            };

            return View(comicBook);

        }
    }
}