using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TMS_Smart_logistics.IRepository;
using TMS_Smart_logistics.Model;
namespace TMS_Smart_logistics.IRepository
{
   public interface IGoodsAndMaterials:IBase<Supplies>
    {
        List<Supplies> GetAndMaterials(string GoodsAndMaterialsName,string TextureName,string PlaceOfOrigin,string Proposer,string ExamineName);
    }
}
