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
using System.Collections.Generic;

namespace JTTableObjects
{

	public class TableSection
	{
		
		#region Constructors
		
		public TableSection (int sectionIndex, string sectionTitle, List<ITableRow> sectionRows)
		{
			
			this.SectionIndex = sectionIndex;
			this.SectionTitle = sectionTitle;
			this.SectionRows = sectionRows;
			
		}
		
		#endregion Constructors
		
		
				
		#region Properties
		
		public int SectionIndex
		{
			get;
			private set;
		}//end int SectionIndex
		
		
		
		public string SectionTitle
		{
			get;
			private set;
			
		}//end string SectionTitle
		
		
		
		public List<ITableRow> SectionRows
		{
			get;
			private set;
		}//end List<ITableRow> SectionRows
		
		
		
		public int RowCount
		{
			get
			{
				if (null != this.SectionRows)
				{
					return this.SectionRows.Count;
				} else
				{
					return 0;
				}//end if else
				
			}//end get
			
		}//end int RowCount
		
		#endregion Properties
	}
}

