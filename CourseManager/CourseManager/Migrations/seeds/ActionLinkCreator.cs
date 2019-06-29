using CourseManager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CourseManager.Controllers.Seeds
{
    public class ActionLinkCreator
    {
        private readonly CourseManager.Models.CourseManagerEntities _context;
        public ActionLinkCreator(CourseManager.Models.CourseManagerEntities context)
        {
            _context = context;
        }

        public ActionLinkCreator()
        {
            // TODO: Complete member initialization
        }
        public void Seed()
        {
            var initialActionLinks = new List<ActionLink>
           {
             new ActionLink
             {
               
               Name="主页",
               Controller="Home",
               Action="Index"
             }
           };
            foreach (var action in initialActionLinks)
            {
                if (_context.ActionLink.Any(r => r.Name == action.Name))
                {
                    continue;
                }
                _context.ActionLink.Add(action);
            }
            _context.SaveChanges();
        }
    }
}
