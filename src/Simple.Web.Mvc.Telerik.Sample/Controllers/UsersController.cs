using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Ajax;
using Telerik.Web.Mvc;
using Simple.Web.Mvc.Telerik;
using Simple.DataAccess;
using Simple.Entities;
using Simple;
using NHibernate.Linq;
using Simple.Web.Mvc.Telerik.Sample.Model;

namespace Simple.Web.Mvc.Telerik.Sample.Controllers
{
    public class UsersController : Controller
    {
        //
        // GET: /User/

        [GridAction(EnableCustomBinding = true)]
        public ActionResult Index(GridCommand command)
        {
            var user = TUser.List(x => x.Groups.Any(y => y.Name == "grupo0"));
            return View(command.List<TUser>(30));
        }

    }

    public static class W
    {
        public static IPage<T> List<T>(this GridCommand command, int pageSize)
            where T : class, IEntity<T>
        {
            var def = GridParser.Parse<T>(command, pageSize);
            return Entity<T>.Linq(def.Map, def.Reduce);
        }

    }

}
