using Core.Entities.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constants
{
   public static class Messages
    {
        public static string ProductAdded = "Ürün Eklendi";
        public static string ProductNameInvalid = "ürün geçersiz";
        public static string MaintenanceTime = "Sistem bakımda";
        public static string ProductsListed = "listelendi";
        public static string ProductCountOfCategoryError = "Hatalı";
        public static string ErrorName = "İsim zaten var";
        public static string CategoryLimitExceded = "kategori limit aşıldı";

        public static string  AuthorizationDenied = "yetkiniz yok";

        public static string UserRegistered = "";
        public static string UserNotFound = "";
        public static string PasswordError = "";
        public static string SuccessfulLogin ="";
        public static string UserAlreadyExists = "";
        public static string AccessTokenCreated = "";
    }
}
