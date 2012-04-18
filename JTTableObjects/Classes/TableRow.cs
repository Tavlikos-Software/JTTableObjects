//JTTableObjects - a MonoTouch UITableView companion.
//© 2012, Dimitris Tavlikos - dimitris ( at ) tavlikos.com, http://software.tavlikos.com
//
//Permission is hereby granted, free of charge, to any person obtaining a copy
//of this software and associated documentation files (the "Software"), to deal
//in the Software without restriction, including without limitation the rights
//to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
//copies of the Software, and to permit persons to whom the Software is
//furnished to do so, subject to the following conditions:
//
//The above copyright notice and this permission notice shall be included in
//all copies or substantial portions of the Software.
//
//THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
//IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
//FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
//AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
//LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
//OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
//THE SOFTWARE.
using System;
using MonoTouch.Foundation;
using MonoTouch.UIKit;

namespace JTTableObjects
{
	public class TableRow<TDataObject> : ITableRow
		where TDataObject : class
	{
		#region Constructors
		
		public TableRow (Func<TDataObject, string> rowTitleFunc, 
		                 Func<TDataObject, string> rowValueFunc, 
		                 TDataObject dataObject,
			             string rowIdentifier)
		{
			this.rowTitleFunc = rowTitleFunc;
			this.rowValueFunc = rowValueFunc;
			this.RowIdentifier = rowIdentifier;
			this.DataObject = dataObject;
		}
		
		#endregion Constructors
		
		
			
		#region Fields
			
		private Func<TDataObject, string> rowTitleFunc;
		private Func<TDataObject, string> rowValueFunc;
		
		#endregion Fields
			
			
			
			
		
		#region Properties
		
		public TDataObject DataObject
		{
			get;
			private set;
		}//end TDataObject DataObject
		
		#endregion Properties
		
		
		

		#region ITableRow implementation
		public T GetDataObject<T> ()
			where T : class
		{
			return this.DataObject as T;
		}
		
		
		
		public void SetDataObject<T>(T dataObject)
			where T : class
		{
			this.DataObject = dataObject as TDataObject;
		}
		
				
		

		public string RowTitle 
		{
			get 
			{
				return this.rowTitleFunc(this.DataObject);
			}
		}
		
		

		public string RowValue 
		{
			get 
			{
				return this.rowValueFunc(this.DataObject);
			}
		}
			
			
			
		public string RowIdentifier
		{
			
			get;
			private set;
			
		}//end string RowIdentifier
		
		
		
		public float RowHeight
		{
			get;
			set;
		}//end float RowHeight
		#endregion
	}
}

