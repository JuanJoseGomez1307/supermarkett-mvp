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
            //throw new NotImplementedException();
            CleanViewFields();
        }


        private void SaveProduct(object? sender, EventArgs e)
        {
            //throw new NotImplementedException();
            var products = new ProductsModel();
            products.Id = Convert.ToInt32(view.ProductId);
            products.Name = view.ProductName;
            products.Observation = view.ProductObservation;

            try
            {
                new Common.ModelDataValidation().Validate(products);

                if (view.IsEdit)
                {
                    repository.Edit(products);
                    view.Message = "Product edited successfuly";
                }
                else
                {
                    repository.Add(products);
                    view.Message = "Product added successfuly";
                }
                view.IsSuccessful = true;
                LoadAllProductList();
                CleanViewFields();
            }
            catch (Exception ex)
            {
                view.IsSuccessful = false;
                view.Message = ex.Message;
            }
        }

        private void CleanViewFields()
        {
            view.ProductId = "0";
            view.ProductName = "";
            view.ProductObservation = "";
        }

        private void DeleteSelectedProduct(object? sender, EventArgs e)
        {
            //throw new NotImplementedException();
            try
            {
                var product = (ProductsModel)productBindingSource.Current;

                repository.Delete(product.Id);
                view.IsSuccessful = true;
                view.Message = "Product deleted successfully";
                LoadAllProductList();
            }
            catch (Exception ex)
            {
                view.IsSuccessful = false;
                view.Message = "An error ocurred, could not delete product";
            }
        }

        private void LoadSelectProductToEdit(object? sender, EventArgs e)
        {
            //throw new NotImplementedException();
            var product = (ProductsModel)productBindingSource.Current;

            view.ProductId = product.Id.ToString();
            view.ProductName = product.Name;
            view.ProductObservation = product.Observation;

            view.IsEdit = true;
        }

        private void AddNewProduct(object? sender, EventArgs e)
        {
            //throw new NotImplementedException();
            view.IsEdit = false;
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