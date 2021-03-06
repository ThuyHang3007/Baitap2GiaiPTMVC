using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;

namespace Baitap2MVC.Models
{
    public class AutoGenerateKey
    {

        public string GenerateKey(string id) // tạo hàm truyền vào ID  id= PS001
        {

            string strkey = ""; 
            string numPart = "", strPart = "", strPhanso = "";

            numPart = Regex.Match(id, @"\d+").Value; //001
            strPart = Regex.Match(id, @"\D+").Value; //PS

            int Phanso = Convert.ToInt32(numPart) + 1; // phanso = 2;

            for (int i = 0; i < numPart.Length - Phanso.ToString().Length; i++)
            {
                strPhanso += "0"; 
            }
            strPhanso += Phanso; //= 002 + 2
            strkey = strPart + strPhanso; // PS002

            return strkey; // trả về một ID mới  // PS002


            // tach rieng phan so va phan chu cua tham so id                  
            // giu nguyen phan chu
            // phan so chuyen di sang kieu so nguyen va tang them 1 don vi
            // ghep phan so voi phan chu de duoc ma tu sinh
            // tra ve ma sau khi tu sinh

        }
    }
}