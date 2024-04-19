using Microsoft.Data.SqlClient;
using supermarkett_mvp._Repositories;
using supermarkett_mvp.Models;
using supermarkett_mvp.Views;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace supermarkett_mvp.Presenters
{
    internal class ProductPresenter
    {
        private IProductView view;
        private IProductRepository repository;
        private BindingSource productBindingSource;
        private IEnumerable<ProductsModel> productList;

        public ProductPresenter(IProductView view, IProductRepository repository)
        {
            this.productBindingSource = new BindingSource();

            this.view = view;
            this.repository = repository;

            this.view.SearchEvent += SearchProduct;
            this.view.AddNewEvent += AddNewProduct;
            this.view.EditEvent += LoadSelectProductToEdit;
            this.view.DeleteEvent += DeleteSelectedProduct;
            this.view.SaveEvent += SaveProduct;
            this.view.CancelEvent += CancelAction;

            this.view.SetProductListBildingSource(productBindingSource);

            LoadAllProductList();

            this.view.Show();

        }
        private void LoadAllProductList()
        {
            productList = repository.GetAll();
            productBindingSource.DataSource = productList;
        }

        private void CancelAction(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }


        private void SaveProduct(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void DeleteSelectedProduct(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void LoadSelectProductToEdit(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void AddNewProduct(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void SearchProduct(object? sender, EventArgs e)
        {
            bool EmptyValue = string.IsNullOrWhiteSpace(this.view.SearchValue);
            if (EmptyValue == false)
            {
                productList = repository.GetByValue(this.view.SearchValue);
            }
            else
            {
                productList = repository.GetAll();
            }
            productBindingSource.DataSource = productList;
        }
    }
}  