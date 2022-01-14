using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Webforrm.Data;
using Webforrm.Models;

namespace Webforrm.Controllers
{
    public class PaymetController : Controller
    {
        Project db = new Project();

        // GET: Paymet
        public ActionResult Index()
        {
            if (Session["idUser"] == null)
            {
                return RedirectToAction("DangNhap", "Home");
            }
            else
            {
                var list_Cart = (List<CartModel>)Session["cart"];
                customer objOrder = new customer();
                product reduce = new product();
              
                objOrder.ID_custom = Session["idUser"].ToString();
                objOrder.name_custom = Session["FullName"].ToString();
                objOrder.address_custom = Session["DiaChi"].ToString();
                objOrder.phone_number = Session["Sodienthoai"].ToString();
                string s = "";
                float sum = 0;
                int count = 0;
                foreach (var item in list_Cart)
                {
                    s = s + item.Product.name_product + " ";
                    sum = sum + (float)item.Product.price * (float)item.Quantity;
                    count = count + item.Quantity;
                    item.Product.quality = item.Product.quality- item.Quantity;
                    db.Entry(item.Product).State = System.Data.EntityState.Modified;
                }
                s = s.Trim();
                objOrder.product_name = s;
                objOrder.amount = count;
                objOrder.sum_price = sum;
                objOrder.date_order = DateTime.Now;
                if (System.Convert.ToInt32(Session["selected"])== 1)
                {
                    objOrder.method = "Tiền mặt";
                    objOrder.status = "Chưa thanh toán";
                    objOrder.status_order = "Chưa giao";
                }
                else
                {
                    objOrder.method = "MoMo";
                    objOrder.status = "Đã thanh toán";
                    objOrder.status_order = "Chưa giao";
                }
                
                objOrder.ID_order = System.Convert.ToInt32(RandomNumber(3)).ToString();
               
               

                db.customers.Add(objOrder);
                db.SaveChanges();

                Session["cart"] = null;
                Session["count"] = null;

            }
            return View();
        }
        public static string RandomNumber(int numberRD)
        {
            string randomStr = "";
          
                int[] myIntArray = new int[numberRD];
                int x;
            
                Random autoRand = new Random();
                for (x = 0; x < numberRD; x++)
                {
                    myIntArray[x] = System.Convert.ToInt32(autoRand.Next(0, 9));
                    randomStr += (myIntArray[x].ToString());
                }
  
          
            return randomStr;
        }
    }
}