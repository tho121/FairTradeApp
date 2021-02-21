﻿using System;
using System.Collections.Generic;
using System.Text;

namespace FairTradeApp
{
	public class Conversions
	{
		public static float ConvertRate(string rate)
		{
			if(rate == "USD/MT")
			{
				return 1.26f / 1000.0f;
			}
			else if (rate == "EUR/MT")
			{
				return 1.53f / 1000.0f;
			}
			else if (rate == "MMK/MT")
			{
				return 0.00089f / 1000.0f;
			}
			else if (rate == "KHR/MT")
			{
				return 0.00031f / 1000.0f;
			}
			else if (rate == "THB/MT")
			{
				return 0.042f / 1000.0f;
			}
			else if (rate == "LAK/kg")
			{
				return 0.00013f / 1.0f;
			}
			else if (rate == "LKR/kg")
			{
				return 0.0064f / 1.0f;
			}
			else if (rate == "USD/1MT")
			{
				return 1.26f / 1000.0f;
			}
			else if (rate == "USD/pound")
			{
				return 1.26f / 0.453592f;
			}
			else if (rate == "EUR/tCO2e")
			{
				return 1.53f / 1.0f;
			}
			else if (rate == "EUR/kg")
			{
				return 1.53f / 1.0f;
			}
			else if (rate == "USD/14 kg")
			{
				return 1.26f / 14.0f;
			}
			else if (rate == "GBP/kg")
			{
				return 1.77f / 1.0f;
			}
			else if (rate == "USD/kg")
			{
				return 1.26f / 1.0f;
			}
			else if (rate == "ZAR/kg")
			{
				return 0.086f / 1.0f;
			}
			else if (rate == "USD/18.14 kg")
			{
				return 1.26f / 18.14f;
			}
			else if (rate == "EUR/Kg")
			{
				return 1.53f / 1.0f;
			}
			else if (rate == "SPO / HL")
			{
				return 1.0f / 1.0f;
			}
			else if (rate == "EXW")
			{
				return 1.0f / 1.0f;
			}
			else if (rate == "FOB")
			{
				return 1.0f / 1.0f;
			}
			else if (rate == "USD/40.8 Kg")
			{
				return 1.26f / 40.8f;
			}
			else if (rate == "USD/22kg")
			{
				return 1.26f / 22.0f;
			}
			else if (rate == "EUR/1kg")
			{
				return 1.53f / 1.0f;
			}
			else if (rate == "USD/Kg")
			{
				return 1.26f / 1.0f;
			}
			else if (rate == "USD")
			{
				return 1.26f / 1.0f;
			}
			else if (rate == "EUR/litres")
			{
				return 1.53f / 1.0f;
			}
			else if (rate == "USD/nut")
			{
				return 1.26f / 1.0f;
			}
			else if (rate == "USD/1000 nuts")
			{
				return 1.26f / 1000.0f;
			}

			return 1.0f;
		}
	}
}
