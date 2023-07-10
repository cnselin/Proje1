using System;
using System.Collections.Generic;
using System.Text;
using Business.Abstract;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;

namespace Business.Concrete
{
    public class ProductManager : IProductService
	{
		//InMemoryProductDal inMemoryProdutcDal;

		InMemoryProductDal _productDal;
		public ProductManager(InMemoryProductDal productDal)
		{
			_productDal = productDal;
		}

		public List<Product> GetAll()
		{
			return _productDal.GetAll();
			
		}
    }
}

