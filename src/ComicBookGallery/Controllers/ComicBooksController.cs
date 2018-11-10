using System.Web.Mvc;
using WebApplication1.Data;

namespace WebApplication1.Controllers
{
    public class ComicBooksController : Controller
    {
        private readonly ComicBookRepository _comicBookRepository = null;

        public ComicBooksController()
        {
            _comicBookRepository = new ComicBookRepository();

        }

        public ActionResult Index()
        {
            var comicBooks = _comicBookRepository.GetComicBooks();
            return View(comicBooks);
        }

        public ActionResult Detail(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }
            var comicBook = _comicBookRepository.GetComicBook((int)id);

            if (comicBook == null)
            {
                return HttpNotFound();
            }

            return View(comicBook);

        }
    }
}