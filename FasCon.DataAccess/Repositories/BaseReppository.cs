using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace FasCon.DataAccess.Repositories
{
   public  class BaseRepository
    {
         public void SetModifiedField<TEntity>(FasConDBEntities db, TEntity item, Expression<Func<TEntity, object>> setModifyProperty) where TEntity : class
        {
            var entry = db.Entry(item);
            entry.Property(setModifyProperty).IsModified = true;
        }

        protected void SetValueAuditFields<T>(ref T obj)
        {
            using (var db = new FasConDBEntities())
            {
                //var systemUser = db.Users.FirstOrDefault(i => i.AspNetUser.UserName == "SYSTEM_USER");
                //if (systemUser != null)
                //{
                //    SetPropertyValue(ref obj, systemUser.UserID, "UpdateUserId");
                //    SetPropertyValue(ref obj, systemUser.UserID, "UpdateUserID");
                //}
                //SetPropertyValue(ref obj, DateTime.Now, "UpdateDate");
            }
        }

        private static bool SetPropertyValue<T, T1>(ref T obj, T1 val, string propertyName)
        {
            PropertyInfo prop = obj.GetType().GetProperty(propertyName, BindingFlags.Public | BindingFlags.Instance);
            if (null != prop && prop.CanWrite)
            {
                prop.SetValue(obj, val, null);
                return true;
            }
            return false;
        }
        public static string Messsage { get; set; }
       
         ~BaseRepository()
        {
            //if (_db != null)
            //{
            //    _db.Dispose();
            //}
        }
    }
}
