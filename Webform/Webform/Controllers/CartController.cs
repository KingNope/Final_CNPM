using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Webform.Context;
using Webform.Models;

namespace Webform.Controllers
{
    public class CartController : Controller
    {
        db_projectEntities1 dbWeb = new db_projectEntities1();

        // GET: Cart
        public ActionResult Index()
        {
           
            return View((List<CartModel>)Session["cart"]);
        }

        public ActionResult AddToCart(int id, int quantity1)
        {
            if (Session["cart"] == null)
            {
                List<CartModel> cart = new List<CartModel>();
                cart.Add(new CartModel { Product = dbWeb.products.Find(id), quantity = quantity1 });
                Session["cart"] = cart;
                Session["count"] = 1;
            }
            else
            {
                List<CartModel> cart = (List<CartModel>)Session["cart"];
                //kiểm tra sản phẩm có tồn tại trong giỏ hàng chưa???
                int index = isExist(id);
                if (index != -1)
                {
                    //nếu sp tồn tại trong giỏ hàng thì cộng thêm số lượng
                    cart[index].quantity += quantity1;
                }
                else
                {
                    //nếu không tồn tại thì thêm sản phẩm vào giỏ hàng
                    cart.Add(new CartModel { Product = dbWeb.products.Find(id), quantity = quantity1 });
                    //Tính lại số sản phẩm trong giỏ hàng
                    Session["count"] = Convert.ToInt32(Session["count"]) + 1;
                }
                Session["cart"] = cart;
            }
            return Json(new { Message = "Thành công", JsonRequestBehavior.AllowGet });
        }

        private int isExist(int id)
        {
            List<CartModel> cart = (List<CartModel>)Session["cart"];
            for (int i = 0; i < cart.Count; i++)
                if (cart[i].Product.ID.Equals(id))
                    return i;
            return -1;
        }
        public ActionResult Remove(int Id)
        {
            List<CartModel> li = (List<CartModel>)Session["cart"];
            li.RemoveAll(x => x.Product.ID == Id);
            Session["cart"] = li;
            Session["count"] = Convert.ToInt32(Session["count"]) - 1;
            return Json(new { Message = "Thành công", JsonRequestBehavior.AllowGet });
        }

    }
}