﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace supermarkett_mvp.Views
{
    internal interface ICategoriesView
    {
        string CategorieId { get; set; }
        string CategorieName { get; set; }
        string CategorieObservation { get; set; }
        string SearchValue { get; set; }
        bool IsEdit { get; set; }
        bool IsSuccesful { get; set; }
        string Message { get; set; }

        event EventHandler SearchEvent;
        event EventHandler AddNewEvent;
        event EventHandler EditEvent;
        event EventHandler DeleteEvent;
        event EventHandler SaveEvent;
        event EventHandler CancelEvent;

        void SetCategoriesListBildingSource(BindingSource categoriesList);
        void Show();
    }
}
