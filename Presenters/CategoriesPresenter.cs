using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using supermarkett_mvp.Views;
using supermarkett_mvp.Models;

namespace supermarkett_mvp.Presenters
{
    internal class CategoriesPresenter
    {
        private ICategoriesView view;
        private ICategoriesRepository repository;
        private BindingSource categoriesBindingSource;
        private IEnumerable<CategoriesModel> categoriesList;

        public CategoriesPresenter(ICategoriesView view, ICategoriesRepository repository)
        {
            this.categoriesBindingSource = new BindingSource();

            this.view = view;
            this.repository = repository;

            this.view.SearchEvent += SearchCategories;
            this.view.AddNewEvent += AddNewCategories;
            this.view.EditEvent += LoadSelectCategoriesToEdit;
            this.view.DeleteEvent += DeleteSeletedCategories;
            this.view.SaveEvent += SaveCategories;
            this.view.CancelEvent += CancelAction;

            this.view.SetCategoriesListBildingSource(categoriesBindingSource);

            loadAllCategoriesList();

            this.view.Show();

        }

        private void loadAllCategoriesList()
        {
            //throw new NotImplementedException();
            categoriesList = repository.GetAll();
            categoriesBindingSource.DataSource = categoriesList;
        }

        private void CancelAction(object? sender, EventArgs e)
        {
            //throw new NotImplementedException();
            CleanViewFields();
        }

        private void SaveCategories(object? sender, EventArgs e)
        {
            //throw new NotImplementedException();
            var categorie = new CategoriesModel();
            categorie.Id = Convert.ToInt32(view.CategorieId);
            categorie.Name = view.CategorieName;
            categorie.Observation = view.CategorieObservation;

            try
            {
                new Common.ModelDataValidation().Validate(categorie);

                if (view.IsEdit)
                {
                    repository.Edit(categorie);
                    view.Message = "Categorie edited successfuly";
                }
                else
                {
                    repository.Add(categorie);
                    view.Message = "Categorie added successfuly";
                }
                view.IsSuccesful = true;
                loadAllCategoriesList();
                CleanViewFields();
            }
            catch (Exception ex)
            {
                view.IsSuccesful = false;
                view.Message = ex.Message;
            }
        }

        private void CleanViewFields()
        {
            view.CategorieId = "0";
            view.CategorieName = "";
            view.CategorieObservation = "";
        }

        private void DeleteSeletedCategories(object? sender, EventArgs e)
        {
            //throw new NotImplementedException();
            try
            {
                var categorie = (CategoriesModel)categoriesBindingSource.Current;

                repository.Delete(categorie.Id);
                view.IsSuccesful = true;
                view.Message = "Categorie deleted successfully";
                loadAllCategoriesList();
            }
            catch (Exception ex)
            {
                view.IsSuccesful = false;
                view.Message = "An error ocurred, could not delete categorie";
            }
        }

        private void LoadSelectCategoriesToEdit(object? sender, EventArgs e)
        {
            //throw new NotImplementedException();
            var categorie = (CategoriesModel)categoriesBindingSource.Current;

            view.CategorieId = categorie.Id.ToString();
            view.CategorieName = categorie.Name;
            view.CategorieObservation = categorie.Observation;

            view.IsEdit = true;
        }

        private void AddNewCategories(object? sender, EventArgs e)
        {
            //throw new NotImplementedException();
            view.IsEdit = false;
        }

        private void SearchCategories(object? sender, EventArgs e)
        {
            //throw new NotImplementedException();
            bool emptyValue = string.IsNullOrEmpty(this.view.SearchValue);

            if (emptyValue == false)
            {
                categoriesList = repository.GetByValue(this.view.SearchValue);
            }
            else
            {
                categoriesList = repository.GetAll();
            }
            categoriesBindingSource.DataSource = categoriesList;
        }
    }
}
