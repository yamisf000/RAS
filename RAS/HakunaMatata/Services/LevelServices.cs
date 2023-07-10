using HakunaMatata.Data;
using HakunaMatata.Models.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HakunaMatata.Services
{
    public interface ILevelServices
    {
        IEnumerable<Level> GetListLevels();
        IEnumerable<News> GetListNews();
        Level GetDetails(int id);
        News GetNewsDetails(int id);
        Newspicture GetNewsPictureDetails(int id);
        void Create(Level level);
        void CreateNews(News news);
        void CreateNewsPicture(Newspicture newspic);
        void UpdateLevel(Level level);
        void UpdateNews(News news);
        void UpdateNewsPicture(Newspicture newspic);
        void DeleteLevel(int id);
        void DeleteNews(int id);
        bool IsExist(int id);
        bool IsExistNews(int id);
    }
    public class LevelServices : ILevelServices
    {
        private readonly HakunaMatataContext _context;
        public LevelServices(HakunaMatataContext context)
        {
            _context = context;
        }


        public IEnumerable<Level> GetListLevels()
        {
            return _context.Level.ToList();
        }

        public IEnumerable<News> GetListNews()
        {
            return _context.News.ToList();
        }

        public Level GetDetails(int id)
        {
            return _context.Level.Find(id);
        }
        public News GetNewsDetails(int id)
        {
            return _context.News.Find(id);
        }

        public Newspicture GetNewsPictureDetails(int id)
        {
            return _context.Newspicture.Find(id);
        }
        public void Create(Level level)
        {
            try
            {
                _context.Level.Add(level);
                _context.SaveChanges();
            }
            catch
            {
                throw;
            }

        }

        public void CreateNews(News news)
        {
            try
            {
                news.AgentId = 5; // Set AgentId to 5
                _context.News.Add(news);
                _context.SaveChanges();
            }
            catch
            {
                throw;
            }
        }

        public void CreateNewsPicture(Newspicture newspic)
        {
            try
            {
                newspic.IsActive = true;
                newspic.NativeWidth = 0;
                newspic.NativeHeight = 0;
                newspic.URL = newspic.PictureName;
                _context.Newspicture.Add(newspic);
                _context.SaveChanges();
            }
            catch
            {
                throw;
            }
        }

        public void UpdateLevel(Level level)
        {
            try
            {
                var lv = _context.Level.Find(level.Id);
                if (lv != null)
                {
                    lv.LevelName = level.LevelName;
                    _context.SaveChanges();
                }
            }
            catch
            {
                throw;
            }
        }

        public void UpdateNews(News news)
        {
            try
            {
                var n = _context.News.Find(news.Id);
                if (n != null)
                {
                    n.Title = news.Title;
                    n.NewsBody = news.NewsBody;
                    _context.SaveChanges();
                }
            }
            catch
            {
                throw;
            }
        }

        public void UpdateNewsPicture(Newspicture newspic)
        {
            try
            {
                var n = _context.Newspicture.Find(newspic.Id);
                if (n != null)
                {
                    n.PictureName = newspic.PictureName;
                    n.NewsID = newspic.NewsID;
                    n.URL = newspic.URL;
                    _context.SaveChanges();
                }
            }
            catch
            {
                throw;
            }
        }

        public void DeleteLevel(int id)
        {
            try
            {
                var a = _context.Level.Find(id);
                if (a != null)
                {
                    _context.Level.Remove(a);
                    _context.SaveChanges();
                }
            }
            catch
            {
                throw;
            }
        }

        public void DeleteNews(int id)
        {
            try
            {
                var a = _context.News.Find(id);
                if (a != null)
                {
                    _context.News.Remove(a);
                    _context.SaveChanges();
                }
            }
            catch
            {
                throw;
            }
        }



        public bool IsExist(int id)
        {
            return _context.Level.Any(f => f.Id == id);
        }

        public bool IsExistNews(int id)
        {
            return _context.News.Any(f => f.Id == id);
        }
    }
}
