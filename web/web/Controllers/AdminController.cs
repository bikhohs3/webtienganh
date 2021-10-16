using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web;
using System.Web.Mvc;
using web.Models.Database;

namespace web.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        DbContext1 db = new DbContext1();
        public ActionResult Dangnhap()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Dangnhap(FormCollection form)
        {
            if (ModelState.IsValid)
            {
                //var pass = GetMD5(matKhau);
                //Dangky _login = new Dangky();

                var sdtt = Int32.Parse(form["sdthoai"]);
                var pass = (form["pass"]);
                var data = db.Dangnhap.Where(s => s.tenDangnhap == sdtt) && s.matKhau == pass).ToList();
                Console.WriteLine("Đăng nhập thành công ^^ ");

                if (data.Count != 0)
                {
                    //Session["idUser"] = data.FirstOrDefault().maUser;
                    //Session["Sdt"] = data.FirstOrDefault().sdt;
                    //Session["FullName"] = data.FirstOrDefault().tenBe;
                    //Session["Total"] = data.FirstOrDefault().tongDiem;
                }
                else
                {
                    ViewBag.error = "Đăng nhập thất bại";
                }
                Console.WriteLine("Sai!!");
            }
            return RedirectToAction("Dangnhap", "Admin");
        }
        //Băm MD5
        public static string GetMD5(string str)
        {
            MD5 md5 = new MD5CryptoServiceProvider();
            byte[] fromData = Encoding.UTF8.GetBytes(str);
            byte[] targetData = md5.ComputeHash(fromData);
            string byte2String = null;

            for (int i = 0; i < targetData.Length; i++)
            {
                byte2String += targetData[i].ToString("x2");

            }
            return byte2String;
        }



        // GET: Admin/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Admin/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Admin/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Admin/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Admin/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Admin/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Admin/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
