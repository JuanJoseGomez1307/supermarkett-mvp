using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using supermarkett_mvp.Models;
using supermarkett_mvp.Views;
using supermarkett_mvp._Repositories;


namespace supermarkett_mvp.Presenters
{
    internal class MainPresenter
    {
        private readonly IMainView mainView;
        private readonly string sqlConnectionString;

        public MainPresenter(IMainView mainView, string sqlConnectionString)
        {
            this.mainView = mainView;
            this.sqlConnectionString = sqlConnectionString;

            this.mainView.ShowPayModeView += ShowPayModeView;
        }

        private void ShowPayModeView(object? sender, EventArgs e)
        {
            //throw new NotImplementedException();
            IPayModeView view = PayModeView.GetInstance();
            IPayModeRepository repository = new PayModeRepository(sqlConnectionString);
            new PayModePresenter(view, repository);
        }
    }
}
