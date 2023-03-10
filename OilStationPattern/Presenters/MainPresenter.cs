using OilStationPattern.Data;
using OilStationPattern.Models;
using OilStationPattern.View;
using System;
using System.Collections.Generic;
using System.Linq;

namespace OilStationPattern.Presenters
{

    public class MainPresenter
    {
        public List<Oil> oils = new List<Oil>()
            {
                new Oil()
                {
                    OilName="AI-92",
                    Price=1
                },
                new Oil()
                {
                    OilName="AI-95",
                    Price=2
                },
                new Oil()
                {
                    OilName="AI-98",
                    Price=2.3M
                },
                new Oil()
                {
                    OilName="Diesel",
                    Price=0.8M
                }
            };
        private readonly IMainView _view;
        private readonly OilContext _db;
        public MainPresenter(IMainView view)
        {
            _view = view;
            _db = new OilContext();
            LoadAllData();
            _view.SelectionChange += ViewSelectionChange;
            _view.LoadMain += ViewLoadMain;
            _view.QuantityChange += ViewQuantityChange;
            _view.QuantumChange += ViewQuantumChange;

        }

        private void ViewQuantumChange(object sender, EventArgs e)
        {
            if (_view.QuantumText != String.Empty)
            {
                _view.TotalAmountText = decimal.Parse(_view.QuantumText).ToString();
            }
            else
            {
                _view.TotalAmountText = "0.00";
            }
        }

        private void ViewQuantityChange(object sender, EventArgs e)
        {
            if (_view.QuantityText != String.Empty)
            {
                _view.TotalAmountText = (decimal.Parse(_view.QuantityText) * decimal.Parse(_view.PriceText)).ToString();
            }
            else
            {
                _view.TotalAmountText = "0.00";
            }

        }

        private void LoadAllData()
        {
            if (!_db.Oils.Any())
            {
                _db.Oils.AddRange(oils);
                _db.SaveChanges();
            }
        }
        private void ViewLoadMain(object sender, EventArgs e)
        {
            var myoils = _db.Oils.ToList();
            _view.Oils = myoils;
        }

        private void ViewSelectionChange(object sender, EventArgs e)
        {
            var oil = _view.SelectedOil;
            _view.PriceText = oil.Price.ToString();
        }
    }
}
