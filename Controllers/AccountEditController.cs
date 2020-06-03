using Mawjoud2.DAL;
using Mawjoud2.Models;
using Mawjoud2.Repository;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Mawjoud2.Controllers
{
    public class AccountEditController : Controller
    {
       public GenericUnitOfWork _unitOfWork = new GenericUnitOfWork();
        public List<SelectListItem> GetCategory()
        {
            List<SelectListItem> list = new List<SelectListItem>();
            var cat = _unitOfWork.GetRepositoryInstance<Category>().GetAllRecords();
            foreach (var item in cat)
            {
                list.Add(new SelectListItem { Value = item.CategoryId.ToString(), Text = item.CategoryName });
            }
            return list;
        }


        //GET: AccountEdit

        public ActionResult AccountProduct()
        {
            return View();
        }
        public ActionResult AccountEdit(int MemberId)
        {
            ViewBag.CategoryList = GetCategory();

            return View(_unitOfWork.GetRepositoryInstance<Members>().GetFirstorDefault(MemberId));
        }

        [HttpPost]
        public ActionResult AccountEdit(Members tbl, HttpPostedFileBase file)
        {
             string pic = null;
            if (file != null)
            {
                pic = System.IO.Path.GetFileName(file.FileName);
                string path = System.IO.Path.Combine(Server.MapPath("~/MemberImg/"), pic);
                // file is uploaded
                file.SaveAs(path);
            }
            tbl.Memberphoto = file != null ? pic : tbl.Memberphoto;
            tbl.ModifiedOn = DateTime.Now;

            _unitOfWork.GetRepositoryInstance<Members>().Update(tbl);
            return RedirectToAction("Members");
        }
        public ActionResult AccountDelete()
        {
            return View();
        }
        public ActionResult ProductDetails()
        {
            return View();
        }
        public ActionResult ProductAdd()
        {
            return View();
        }
        public ActionResult ProductDelete()
        {
            return View();
        }

    }
}