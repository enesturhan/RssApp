using RssApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RssApp.Repository
{

    public class RssRepository
    {
        private readonly ApplicationDbContext _db;

        public RssRepository()
        {
            _db = new ApplicationDbContext();

        }
        public void Add(New news)
        {
            _db.News.Add(news);
            _db.SaveChanges();
        }

        public New Find(string id)
        {

            return _db.News.Find(id);
        }

        public List<New> List()
        {
            return _db.News.ToList();
        }






    }
}
