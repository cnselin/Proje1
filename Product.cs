using System;
using Entities.Abstract;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
	public class Product:IEntitiy   //bu clasa diğer katmanalr da ulaşabilir(public)
	{

		public int ProductId { get; set; }
        public int CategoryId { get; set; }
        public string ProductName { get; set; }
        public short UnitsInStock { get; set; }   //short=intin bir küçüğü
        public decimal UnitPrice { get; set; }



    }
}

