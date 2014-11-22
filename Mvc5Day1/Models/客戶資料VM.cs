using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Mvc5Day1.Models
{
    public class 客戶資料VM
    {
        public int Id { get; set; }
        public string 客戶名稱 { get; set; }
        public string 統一編號 { get; set; }
        public string 電話 { get; set; }
        public string 傳真 { get; set; }
        public string 地址 { get; set; }
        //public string Email { get; set; }
    }


    public interface I客戶資料Edit
    {
        int Id { get; set; }
        string 客戶名稱 { get; set; }
        string 統一編號 { get; set; }
        string 電話 { get; set; }
        string 傳真 { get; set; }
        string 地址 { get; set; }
        // string Email { get; set; }
    }
}