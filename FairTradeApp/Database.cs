﻿using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Reflection;

namespace FairTradeApp
{
	public class Database
	{
		private static Database instance;

		private List<string> productCategoryList = new List<string>();
		private List<string> productTypeList = new List<string>();
		private List<string> productFormList = new List<string>();
		private List<string> productCountryList = new List<string>();
		private int rowCount = 0;

		public struct RowData
		{
			public int index;
			public string catagory;
			public string type;
			public string form;
			public string country;
		};

		public static Database Instance()
		{
			if(instance == null)
			{
				instance = new Database();
				instance.Init();
			}

			return instance;
		}

		private void Init()
		{
			var assembly = typeof(App).GetTypeInfo().Assembly;
			var stream = assembly.GetManifestResourceStream("FairTradeApp.data.csv");
			
			using (var reader = new StreamReader(stream))
			{
				//remove headers
				if(!reader.EndOfStream)
				{
					var line = reader.ReadLine();
				}

				while (!reader.EndOfStream)
				{
					var line = reader.ReadLine();
					var values = line.Split(',');

					productCategoryList.Add(values[0]);		//Specific Product Standard column A
					productTypeList.Add(values[1]);			//Product					column B
					productFormList.Add(values[3]);			//Form						column D
					productCountryList.Add(values[4]);		//Country/Region			column E
				}

				rowCount = productCategoryList.Count;
			}
		}

		public RowData GetRowData(int index)
		{
			RowData data = new RowData();
			data.index = index;
			data.catagory = productCategoryList[index];
			data.type = productTypeList[index];
			data.form = productFormList[index];
			data.country = productCountryList[index];

			return data;
		}

		public List<RowData> GetRowDatas(string catagory, string type, string form, string country)
		{
			//get all indexes that match
			var categoryRows = GetProductCategoryRows(catagory);
			var typeRows = GetProductTypeRows(type);
			var formRows = GetProductFormRows(form);
			var countryRows = GetProductCountryRows(country);

			//get only the columns that returned non empty
			List<int[]> nonEmptyRows = new List<int[]>();

			if(categoryRows.Count > 0 )
			{
				nonEmptyRows.Add(categoryRows.ToArray());
			}

			if (typeRows.Count > 0)
			{
				nonEmptyRows.Add(typeRows.ToArray());
			}

			if (formRows.Count > 0)
			{
				nonEmptyRows.Add(formRows.ToArray());
			}

			if (countryRows.Count > 0)
			{
				nonEmptyRows.Add(countryRows.ToArray());
			}

			//match indexes between columns
			List<int> rows = new List<int>();

			if(nonEmptyRows.Count > 0)
			{
				//init rows with first non empty row indexes
				rows = new List<int>(nonEmptyRows[0]);

				for(int i = 1; i < nonEmptyRows.Count; ++i)
				{
					//for each match, push to match array, then replace rows with this
					List<int> matches = new List<int>();

					foreach(var index in nonEmptyRows[i])
					{
						if(rows.Contains(index))
						{
							matches.Add(index);
						}
					}

					rows = matches;
				}
			}

			//get row data with these indexes and return
			List<RowData> rowDatas = new List<RowData>();

			foreach(var index in rows)
			{
				rowDatas.Add(GetRowData(index));
			}

			return rowDatas;
		}

		public List<int> GetProductCategoryRows(string category)
		{
			List<int> rows = new List<int>();

			if (!String.IsNullOrEmpty(category))
			{
				for (int i = 0; i < rowCount; ++i)
				{
					if (productCategoryList[i] == category)
					{
						rows.Add(i);
					}
				}
			}

			return rows;
		}

		public List<int> GetProductTypeRows(string type)
		{
			List<int> rows = new List<int>();

			if (!String.IsNullOrEmpty(type))
			{
				for (int i = 0; i < rowCount; ++i)
				{
					if (productTypeList[i] == type)
					{
						rows.Add(i);
					}
				}
			}

			return rows;
		}

		public List<int> GetProductFormRows(string form)
		{
			List<int> rows = new List<int>();

			if (!String.IsNullOrEmpty(form))
			{
				for (int i = 0; i < rowCount; ++i)
				{
					if (productFormList[i] == form)
					{
						rows.Add(i);
					}
				}
			}

			return rows;
		}

		public List<int> GetProductCountryRows(string country)
		{
			List<int> rows = new List<int>();

			if (!String.IsNullOrEmpty(country))
			{
				for (int i = 0; i < rowCount; ++i)
				{
					if (productCountryList[i] == country)
					{
						rows.Add(i);
					}
				}
			}

			return rows;
		}

	}

}
