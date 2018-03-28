using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DVDStore.Data.Models;
using System.Data;
using System.Data.Entity;
using System.Net;
using System.Web.Mvc;



namespace DVDStore.Access.Methods
{
    public class FindAllDVDs
    {
        
        private DVDStoreContext db = new DVDStoreContext();

        public dynamic ViewBag { get; }

        public IEnumerable<DVD> FindAllDVD(bool v1, bool v2)
        {
            throw new NotImplementedException();
        }


    public List<string> GetAllTitles(string DVDTitles, string searchString)
        {
            var DVDQuery = from d in db.DVDs
                           orderby d.Title
                           select d.Title;

            var count = DVDQuery.Count();

            return DVDQuery.ToList();
        }


        public IEnumerable<DVDStore.Data.Models.DVD> FindAllDVD(string DVDTitles, string searchString)
        {

            var dvds = from dvd in db.DVDs
                       select dvd;

            var count = dvds.Count();

            if (!String.IsNullOrEmpty(searchString))
            {
                dvds = dvds.Where(s => s.Title.Contains(searchString));
            }

            if (!String.IsNullOrEmpty(DVDTitles))
            {
                dvds = dvds.Where(x => x.Title == DVDTitles);

            }

            return dvds;

        }


        public DVDStore.Data.Models.DVD GetDVDById(int? id)
        {

            DVD DVDQuery = db.DVDs.Find(id);
            return DVDQuery;

        }

    }
 
}
