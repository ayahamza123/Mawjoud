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
    public class AdminController : Controller
    {
        // GET: Admin
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

        public ActionResult Dashboard()
        {
            return View();
        }


        public ActionResult Categories()
        {
            List<Category> allcategories = _unitOfWork.GetRepositoryInstance<Category>().GetAllRecordsIQueryable().ToList();
            return View(allcategories);
        }


        public ActionResult CategoryEdit(int catId)
        {
            return View(_unitOfWork.GetRepositoryInstance<Category>().GetFirstorDefault(catId));
        }
        [HttpPost]
        public ActionResult CategoryEdit(Category tbl)
        {
            _unitOfWork.GetRepositoryInstance<Category>().Update(tbl);
            return RedirectToAction("Categories");
        }
        public ActionResult CategoryCreate()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CategoryCreate(Category tbl)
        {
            _unitOfWork.GetRepositoryInstance<Category>().Add(tbl);
            return RedirectToAction("Categories");
        }
        public ActionResult Product()
        {
            return View(_unitOfWork.GetRepositoryInstance<Product>().GetProduct());
        }
        public ActionResult ProductDelete(int productId)
        {
            return View(_unitOfWork.GetRepositoryInstance<Product>().GetFirstorDefault(productId));
        }

        [HttpPost]
        public ActionResult ProductDelete(Product tbl)
        {
            _unitOfWork.GetRepositoryInstance<Product>().Delete(tbl);
            return RedirectToAction("Product");
        }
        public ActionResult ProductEdit(int productId)
        {
            ViewBag.CategoryList = GetCategory();

            return View(_unitOfWork.GetRepositoryInstance<Product>().GetFirstorDefault(productId));
        }

        [HttpPost]
        public ActionResult ProductEdit(Product tbl, HttpPostedFileBase file)
        {
            string pic = null;
            if (file != null)
            {
                pic = System.IO.Path.GetFileName(file.FileName);
                string path = System.IO.Path.Combine(Server.MapPath("~/ProductImg/"), pic);
                // file is uploaded
                file.SaveAs(path);
            }
            tbl.ProductImage = file != null ? pic : tbl.ProductImage;
            tbl.ModifiedDate = DateTime.Now;

            _unitOfWork.GetRepositoryInstance<Product>().Update(tbl);
            return RedirectToAction("Product");
        }
        public ActionResult ProductAdd()
        {
            ViewBag.CategoryList = GetCategory();

            return View();
        }
        [HttpPost]
        public ActionResult ProductAdd(Product tbl, HttpPostedFileBase file)
        {

            string pic = null;
            if (file != null)
            {
                pic = System.IO.Path.GetFileName(file.FileName);
                string path = System.IO.Path.Combine(Server.MapPath("~/ProductImg/"), pic);
                // file is uploaded
                file.SaveAs(path);
            }
            tbl.ProductImage = pic;
            tbl.CreatedDate = DateTime.Now;

            _unitOfWork.GetRepositoryInstance<Product>().Add(tbl);
            return RedirectToAction("Product");
        }
        public ActionResult Member()
        {
            return View(_unitOfWork.GetRepositoryInstance<Members>().GetMember());
        }
        public ActionResult MemberDelete(int memberId)
        {
            return View(_unitOfWork.GetRepositoryInstance<Members>().GetFirstorDefault(memberId));
        }

        [HttpPost]
        public ActionResult MemberDelete(Members tbl)
        {
            _unitOfWork.GetRepositoryInstance<Members>().Delete(tbl);
            return RedirectToAction("Member");

        }
        public ActionResult MemberEdit(int MemberId)
        {
            ViewBag.CategoryList = GetCategory();

            return View(_unitOfWork.GetRepositoryInstance<Members>().GetFirstorDefault(MemberId));
        }

        [HttpPost]
        public ActionResult MemberEdit(Members tbl, HttpPostedFileBase file)
        {
            string pic = null;
            if (file != null)
            {
                pic = System.IO.Path.GetFileName(file.FileName);
                string path = System.IO.Path.Combine(Server.MapPath("~/MemberImg/"), pic);
                // file is uploaded
                file.SaveAs(path);
            }
            tbl.Memberphoto= file != null ? pic : tbl.Memberphoto;
            tbl.ModifiedOn = DateTime.Now;

            _unitOfWork.GetRepositoryInstance<Members>().Update(tbl);
            return RedirectToAction("Members");
        }
        public ActionResult MemberAdd()
        {
            ViewBag.CategoryList = GetCategory();

            return View();
        }
        [HttpPost]
        public ActionResult MemberAdd(Members tbl, HttpPostedFileBase file)
        {

            string pic = null;
            if (file != null)
            {
                pic = System.IO.Path.GetFileName(file.FileName);
                string path = System.IO.Path.Combine(Server.MapPath("~/MemberImg/"), pic);
                // file is uploaded
                file.SaveAs(path);
            }
            tbl.Memberphoto = pic;
            tbl.CreatedOn = DateTime.Now;

            _unitOfWork.GetRepositoryInstance<Members>().Add(tbl);
            return RedirectToAction("Member");
        }
    }
}