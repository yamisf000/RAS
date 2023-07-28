using HakunaMatata.Data;
using HakunaMatata.Models.DataModels;
using HakunaMatata.Models.ViewModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HakunaMatata.Services
{
    public interface ILevelServices
    {
        Task<List<ChartReportSummaryModel>> GenerateOrderReport(int year, int month);
        IEnumerable<Level> GetListLevels();
        IEnumerable<HistoryPayment> GetHistoryPayments();
        IEnumerable<PaymentHistoryDetailModel> GetHistoryPaymentsByDate(DateTime? startDate, DateTime? endDate,
            int userId = 0);
        IEnumerable<News> GetListNews();
        News GetNewsDetails(int id);
        void CreateNews(News news);
        void UpdateNews(News news);
        bool IsExistNews(int id);
        void CreateNewsPicture(Newspicture newspic);
        void UpdateNewsPicture(Newspicture newspic);
        Level GetDetails(int id);
        void Create(Level level);
        void UpdateLevel(Level level);
        void DeleteLevel(int id);
        bool IsExist(int id);
    }
    public class LevelServices : ILevelServices
    {
        private readonly HakunaMatataContext _context;
        public LevelServices(HakunaMatataContext context)
        {
            _context = context;
        }

        public async Task<List<ChartReportSummaryModel>> GenerateOrderReport(int year, int month)
        {
            var startDate = new DateTime(year, month, 1);
            var endDate = startDate.AddMonths(1);

            var orders = await _context.HistoryPayment
                .Where(s => s.PaymentDate >= startDate && s.PaymentDate < endDate)
                .ToListAsync();

            var reportData = new List<ChartReportSummaryModel>();

            for (var day = 1; day <= DateTime.DaysInMonth(year, month); day++)
            {
                var ordersInDay = orders.Where(s => s.PaymentDate.Day == day).ToList();
                var totalAmount = (double)ordersInDay.Sum(s => s.Coin);

                var chartModel = new ChartReportSummaryModel
                {
                    ValueX = day,
                    ValueY = totalAmount
                };

                reportData.Add(chartModel);
            }

            return reportData;
        }


        public IEnumerable<Level> GetListLevels()
        {
            return _context.Level.ToList();
        }

        public IEnumerable<HistoryPayment> GetHistoryPayments()
        {
            return _context.HistoryPayment.ToList();
        }

        public IEnumerable<News> GetListNews()
        {
            return _context.News.ToList();
        }

        public News GetNewsDetails(int id)
        {
            return _context.News.Find(id);
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

        public Level GetDetails(int id)
        {
            return _context.Level.Find(id);
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
