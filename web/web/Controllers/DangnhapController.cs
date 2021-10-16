using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Security.Cryptography;
using System.Web.Mvc;
using web.Models;
using web.Models.Database;
using System.Text;
using WMPLib;

namespace web.Controllers
{
    public class DangnhapController : Controller
    {
        DbContext1 db = new DbContext1();

        // GET: Dangnhap

        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        //[ValidateAntiForgeryToken]
        public ActionResult Login(FormCollection form)
        {
            //if (ModelState.IsValid)
            //{
            //    //var f_password = GetMD5(password);
            //    //Dangky _login = new Dangky();

            //    //String sdtt = (form["sdthoai"]);

            //    var data = db.Dangkies.Where(s => s.sdt.Equals(sdtt)).ToList();
            //    Console.WriteLine("Đăng nhập thành công ^^ ");

            //    if (data.Count != 0)
            //    {                    
            //        //Session["idUser"] = data.FirstOrDefault().maUser;
            //        Session["Sdt"] = data.FirstOrDefault().sdt;
            //        Session["FullName"] = data.FirstOrDefault().tenBe;
            //        Session["Total"] = data.FirstOrDefault().tongDiem;
            //    }
            //    else
            //    {
            //        ViewBag.error = "Đăng nhập thất bại";
            //    }
            //    Console.WriteLine("Sai!!");
            //}
            //return View();

            //----------------------------------------------------------------------
            var sdtt = Int32.Parse(form["sdthoai"]);
            var acc = db.Dangkies.FirstOrDefault(p => p.sdt==sdtt);
            if (acc == null)

            {

                ViewData["loi1"] = "Đăng nhập thất bại";
                return RedirectToAction("Login");
            }
            Session["Sdt"] = acc.sdt;
            Session["FullName"] = acc.tenBe;
            Session["Total"] = acc.tongDiem; 
            return RedirectToAction("Index", "Home");
           
        }
       


        // GET: Dangnhap/Details/5
        public ActionResult Dangky()
        {
            return View();
        }

        [HttpPost]
        //[ValidateAntiForgeryToken]

        public ActionResult Dangky(FormCollection form)
        {
            if (ModelState.IsValid)
            {
                Dangky _dangky = new Dangky();
                var check = db.Dangkies.FirstOrDefault(s => s.sdt == _dangky.sdt);
                if (check == null)
                {
                    //_dangky.email = (_dangky.email);
                    //_dangky.tenBe = (_dangky.tenBe);

                    _dangky.sdt = Int32.Parse(form["dienthoai"]);
                    _dangky.email = form["mail"];
                    _dangky.tenBe = form["tenbe"];
                    _dangky.tongDiem = 0;
                    

                    db.Configuration.ValidateOnSaveEnabled = false;
                    db.Dangkies.Add(_dangky);
                    db.SaveChanges();
                }               
                TempData["DangKy"] = "Đăng ký thành công ^^";
                //return RedirectToAction("Index");
            }
            else
            {
                ViewBag.error = "Sai thông tin !!!!!";
 
            }
            return View();

        }
            
        

        

        // logout
        public ActionResult Logout()
        {
            Session.Clear();//remove session
            return RedirectToAction("Login");
        }


        //chức năng bâm
        //public static string GetMD5(string str)
        //{
        //    MD5 md5 = new MD5CryptoServiceProvider();
        //    byte[] fromData = Encoding.UTF8.GetBytes(str);
        //    byte[] targetData = md5.ComputeHash(fromData);
        //    string byte2String = null;

        //    for (int i = 0; i < targetData.Length; i++)
        //    {
        //        byte2String += targetData[i].ToString("x2");

        //    }
        //    return byte2String;
        //}




        // GET: Dangnhap/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Dangnhap/Create
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

        // GET: Dangnhap/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Dangnhap/Edit/5
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

        // GET: Dangnhap/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Dangnhap/Delete/5
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
