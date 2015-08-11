using FasCon.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FasCon.DataAccess.Repositories
{
    public class CommonRepository:BaseRepository
    {
        public static List<StateProvinceModel> GetAllStates()
        {
            using (var db = new FasConDBEntities())
            {
                var products = db.StateProvinces.ToList().OrderBy(p => p.Name);
                return products.Select(p => new StateProvinceModel { StateProvinceId=p.StateProvinceId,Name=p.Name}).ToList();
            }
        }
        public static List<DistrictModel> FindCitiesById(int stateId)
        {
            List<DistrictModel> rs=new List<DistrictModel>();
            using (var db = new FasConDBEntities())
            {
                var p = db.Districts.Where(pr => pr.StateProvinceId == stateId);
                rs = p.Select(o => new DistrictModel {DistrictId=o.DistrictId,Name=o.Name }).ToList();
                return rs;
            }
        }
    }
}
