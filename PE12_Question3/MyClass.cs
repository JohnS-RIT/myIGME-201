using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE12_Question3
{
	//Class: MyClass
	//Purpose: To be base class with method to be overriden
	class MyClass
	{
		private string myString;

		//Write-only property
		public string MyString
		{
			set { myString = value; }
		}

		//Method: GetString
		//Purpose: returns myString
		public virtual string GetString()
		{
			return myString;
		}

	}
}
