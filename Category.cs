﻿using System;
using Entities.Abstract;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{


	public class Category: IEntitiy

	{
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }

    }
}

