using RssApp.Models;
using RssApp.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RssApp.Services
{
    public class NewsCreateService
    {

        private readonly RssRepository _repo;

        public NewsCreateService(RssRepository rRepo)
        {
            _repo = rRepo;
        }

        public void CreateNews(New news)
        {

            if (string.IsNullOrEmpty(news.NewsName))
            {
                throw new Exception("isim kısmı bos gecilemez");
            }
            if (string.IsNullOrEmpty(news.RssLink))
            {
                throw new Exception("Link kısmı bos gecilemez");

            }
            if (string.IsNullOrEmpty(news.Priority))
            {
                throw new Exception("bos gecilemez");

            }

            _repo.Add(news);

        }

    }
}
