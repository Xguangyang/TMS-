using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TMS_Smart_logistics.Model;
using TMS_Smart_logistics.IRepository;

namespace TMS_Smart_logistics.Api.Controllers
{
    /// <summary>
    /// 物资领用管理
    /// </summary>
    [Route("api/[controller]/[action]")]
    public class AidRecipientsController : Controller
    {
        public IViewAidRecipients viewAid;
        public AidRecipientsController (IViewAidRecipients _viewAid)
        {
            viewAid = _viewAid;
        }
        /// <summary>
        /// 显示物资领用
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult GetAidRecipients()
        {
            List<ViewAidRecipients> Lis1 = viewAid.GetAidRecipients();
            if (Lis1 != null)
            {
                return Ok(new { Code = 1, data = Lis1, Mess = "请求成功" });
            }
            else
            {
                return Ok(new { Code = 0, data = "", Mess = "失败请求" });
            }
        }
    }
}
