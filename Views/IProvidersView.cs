using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace supermarkett_mvp.Views
{
    internal interface IProvidersView
    {
        string ProviderId { get; set; }
        string ProviderName { get; set; }
        string ProviderObservation { get; set; }
        string SearchValue { get; set; }
        bool IsEdit { get; set; }
        bool IsSuccesful { get; set; }
        string Menssage { get; set; }

        event EventHandler SearchEvent;
        event EventHandler AddNewEvent;
        event EventHandler EditEvent;
        event EventHandler DeleteEvent;
        event EventHandler SaveEvent;
        event EventHandler CancelEvent;

        void SetProvidersListBildingSource(BindingSource providersList);
        void Show();
    }
}
