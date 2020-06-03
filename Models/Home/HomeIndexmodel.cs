using Mawjoud2.DAL;
using Mawjoud2.Repository;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PagedList;
using PagedList.Mvc;
namespace Mawjoud2.Models.Home
{
    public class HomeIndexmodel
    {

        public GenericUnitOfWork _unitOfWork = new GenericUnitOfWork();
      Db_MawjoudEntities1 context = new Db_MawjoudEntities1();
        public IPagedList<Product> ListOfProducts { get; set; }
        public HomeIndexmodel CreateModel(string search, int pageSize, int? page)
        {
            SqlParameter[] param = new SqlParameter[]{
                new SqlParameter("@search",search??(object)DBNull.Value)
            };
            IPagedList<Product> data = context.Database.SqlQuery<Product>("GetBySearch @search", param).ToList().ToPagedList(page ?? 1, pageSize);
            return new HomeIndexmodel
            {
                ListOfProducts = data
            };
        }
    }
}