using collegemanagment.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Script.Serialization;

namespace collegemanagment.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        ORMclass CM = new ORMclass();
        public ActionResult Index()
        {
            return View();
        }

        // GET: Student/Details/5
        public ActionResult StudentDetailsView()
        {


               var std = CM.Studentmanagement.ToList();
                return View(std.ToList());
         
           
        }

        // GET: Student/Create
        public ActionResult StudentdetailsAdd()
        {
            return View();
        }

        // POST: Student/Create
        [HttpPost]
        public ActionResult StudentdetailsAdd(Addstudent AS, string[] DynamicTextBox, HttpPostedFileBase[] Dynamicfile)
        {
            try
            {

                JavaScriptSerializer serializer = new JavaScriptSerializer();
                ViewBag.Values = serializer.Serialize(DynamicTextBox);

                //string message = "";
                //foreach (string textboxValue in DynamicTextBox)
                //{
                //    message += textboxValue + "\\n";
                //}
                //ViewBag.Message = message;

                string path = Path.Combine(Server.MapPath("~/SSLCcertificate/"), Path.GetFileName(AS.tenth.FileName.ToString().Replace("JPG", "jpg")));
                AS.tenth.SaveAs(path);
                string path1 = Path.Combine(Server.MapPath("~/HSSCertificate/"), Path.GetFileName(AS.plustwo.FileName.ToString().Replace("JPG", "jpg")));
                AS.plustwo.SaveAs(path1);
                string path2 = Path.Combine(Server.MapPath("~/UGCertificate/"), Path.GetFileName(AS.UG.FileName.ToString().Replace("JPG", "jpg")));
                AS.UG.SaveAs(path2);
                string path3 = Path.Combine(Server.MapPath("~/PGCertificate/"), Path.GetFileName(AS.PG.FileName.ToString().Replace("JPG", "jpg")));
                AS.PG.SaveAs(path3);
                string path4 = Path.Combine(Server.MapPath("~/CommunityCertificate/"), Path.GetFileName(AS.CC.FileName.ToString().Replace("JPG", "jpg")));
                AS.CC.SaveAs(path4);
                //foreach (HttpPostedFileBase h in Dynamicfile)
                //{
                //    string path2 = Path.Combine(Server.MapPath("~/visascancopy/"), Path.GetFileName(h.FileName.ToString().Replace("JPG", "jpg")));
                //    h.SaveAs(path2);
                //}


                //byte[] bytes;
                //byte[] bytes1;
                //byte[] bytes2;
                //using (BinaryReader br = new BinaryReader(em.fileupload1.InputStream))
                //{
                //    bytes = br.ReadBytes(em.fileupload1.ContentLength);
                //}
                //using (BinaryReader br = new BinaryReader(em.fileupload2.InputStream))
                //{
                //    bytes1 = br.ReadBytes(em.fileupload2.ContentLength);
                //}
                //using (BinaryReader br = new BinaryReader(em.fileupload3.InputStream))
                //{
                //    bytes2 = br.ReadBytes(em.fileupload3.ContentLength);
                //}
                studentmodel stutenttbl = new studentmodel();
                stutenttbl.StudentName = AS.StudentName;
                stutenttbl.Dob = Convert.ToDateTime( AS.Dob);
                stutenttbl.contact = AS.contact;
                stutenttbl.Gender = AS.Gender;
                stutenttbl.GuardianName = AS.GuardianName;
                stutenttbl.UG = AS.UG.FileName.ToString();
                stutenttbl.PG = AS.PG.FileName.ToString();
                stutenttbl.tenth = AS.tenth.FileName.ToString();
                stutenttbl.plustwo= AS.plustwo.FileName.ToString();
                stutenttbl.CC = AS.CC.FileName.ToString();
                stutenttbl.Address = AS.Address;
                stutenttbl.Coursetype = AS.Coursetype;
                stutenttbl.collegename = AS.collegename;
                stutenttbl.Degree = AS.Degree;
                //emptbl.visacopyname = em.fileupload3.FileName.ToString();
                //var x = (from y in cv.employeescandetails where y.windowuserid == emptbl.windowuserid select y).FirstOrDefault();
                //if (x != null)
                //{
                //    cv.employeescandetails.Remove(x);
                //}
                // var studentList = cv.employeescandetails.SqlQuery("if exists(Select * from employeescandetails").ToList<empmodel>();

                CM.Studentmanagement.Add(stutenttbl);
                //List<employeevisa> empl = new List<employeevisa>();
                //var data = new employeevisa();

                //for (int i = 0; i <= Dynamicfile.Length; i++)
                //{
                //    data.visaimage = Dynamicfile[i].FileName.ToString().Replace("JPG", "jpg");
                //    for (int j = 0; j <= DynamicTextBox.Length; j++)
                //    {
                //        data.visatype = DynamicTextBox[j];
                //        for (int k = 0; k <= visacountry.Length; k++)
                //        {
                //            data.visacountry = visacountry[k];
                //        }

                //    }
                //    empl.Add(data);
                //}

                // foreach (HttpPostedFileBase h in Dynamicfile)
                // {
                //     var data = new employeevisa();
                //     data.visaimage = h.FileName.ToString().Replace("JPG", "jpg");

                //     foreach (var t in DynamicTextBox)
                //     {
                //         data.visatype = t;
                //     }
                //     foreach (var k in visacountry)
                //     {
                //         data.visacountry = k;
                //     }

                //     empl.Add(data);
                //}




                //cv.employeevisadetails.Add(ev);
                CM.SaveChanges();
                
      
                return RedirectToAction("StudentDetailsView");
            }
            catch
            {
                return View();
            }
        }

        // GET: Student/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Student/Edit/5
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

        // GET: Student/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Student/Delete/5
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
