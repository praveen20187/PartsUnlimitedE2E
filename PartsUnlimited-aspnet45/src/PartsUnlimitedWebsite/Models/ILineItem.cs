﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartsUnlimited.Models
{
	public interface ILineItem
	{
		//2nd change
		int Count { get; }

		Product Product { get; }
		//3rd change
	}
}
