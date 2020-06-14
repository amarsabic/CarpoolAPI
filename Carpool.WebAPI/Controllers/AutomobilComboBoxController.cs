using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Carpool.Model;
using Carpool.WebAPI.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Carpool.WebAPI.Controllers
{
    public class AutomobilComboBoxController : BaseController<Model.AutomobilComboBox, object>
    {
        public AutomobilComboBoxController(IService<AutomobilComboBox, object> service) : base(service)
        {
        }
    }
}