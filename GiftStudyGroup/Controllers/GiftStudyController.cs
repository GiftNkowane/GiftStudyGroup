using GiftStudyGroup;
using GiftStudyGroup.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GiftsStudyGroup.Controllers
{
    public class GiftStudyController : Controller
    {

        // GET: GiftStudy
        public ActionResult Index()
        {
            var StudyGroupPeople = new List<GiftStudyGroup.Models.GiftStudyGroup>
            {
                new GiftStudyGroup.Models.GiftStudyGroup { StudentNum = "21446947", Name = "Gift", Surname = "Nkowane", EmailAddress = "giftnkowane@gmail.com" },
                new GiftStudyGroup.Models.GiftStudyGroup { StudentNum = "22456944", Name = "James", Surname = "Matty", EmailAddress = "james@gmail.com" },
                new GiftStudyGroup.Models.GiftStudyGroup { StudentNum = "234460424",Name = "Dan", Surname = "Green", EmailAddress = "DanGreen@gmail.com" },
                new GiftStudyGroup.Models.GiftStudyGroup { StudentNum = "2468753", Name = "Will", Surname = "Vennly", EmailAddress = "willvennly@gmail.com" },
                new GiftStudyGroup.Models.GiftStudyGroup { StudentNum = "22063576", Name = "Ania", Surname = "Snyman", EmailAddress = "TniaSnyman@gmail.com" }



            };





            return View(StudyGroupPeople);
        }
    }
}

  