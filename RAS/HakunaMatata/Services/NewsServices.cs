using HakunaMatata.Data;
using HakunaMatata.Models.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HakunaMatata.Services
{
    public interface INewsServices
    {
        IEnumerable<News> GetListNews();
        News GetDetails(int id);
        void Create(News level);
        void UpdateLevel(News level);
        void DeleteLevel(int id);
        bool IsExist(int id);
    }
    public class NewsServices
    {
        private readonly HakunaMatataContext _context;
        public NewsServices(HakunaMatataContext context)
        {
            _context = context;
        }


        public IEnumerable<News> GetListNews()
        {
            return _context.News.ToList();
        }

        public News GetDetails(int id)
        {
            return _context.News.Find(id);
        }

        public void Create(News news)
        {
            try
            {
                _context.News.Add(news);
                _context.SaveChanges();
            }
            catch
            {
                throw;
            }

        }
    }
}
