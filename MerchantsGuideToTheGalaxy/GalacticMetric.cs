﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;

public class GalacticMetric
{

	Dictionary<string, int> GalaxyMetric =
	new Dictionary<string, int>();

	public GalacticMetric()
    {
		GalaxyMetric.Add("I", 1 );
		GalaxyMetric.Add("V", 5 );
		GalaxyMetric.Add("X", 10 );
		GalaxyMetric.Add("C", 100 );
		GalaxyMetric.Add("L", 250);
		GalaxyMetric.Add("D", 500);
		GalaxyMetric.Add("M", 1000);

		
	}

	//Add secondary galactic key which corresponds to roman key
	public void updateGalacticMetric(string galactic, string roman)
	{
		int value = GalaxyMetric[roman];
		GalaxyMetric.Remove(roman);
		GalaxyMetric.Add(galactic, value);
	}

	private bool checkMetricExists(string numeral)
	{
		if (GalaxyMetric.ContainsKey(numeral) == true)
			return true;
		else
			return false;
	}

	private int fetchMetricValue(string numeral)
    {
		return GalaxyMetric[numeral];
    }
	//Deduce new Galactic Metric number by subtracting known values from a chain input
	public void deduceGalacticMetric(string[] input)
	{

		//step 1: get length of input
		int length = input.Length;

		//step 2: get resulting value from end
		int value;
		int numeralsLength = length - 3;
		Int32.TryParse(input[length - 2], out value);


		//step 3: subtract known values from total
		
	
		int currentNumber = 0;
		int previousNumber = 999999999;
		int runningTotal = 0;
		for(int i =0; i< numeralsLength -1; i++)
        {
			if (checkMetricExists(input[i]) == true)
			{
				currentNumber = fetchMetricValue(input[i]);
				if (currentNumber <= previousNumber)
				{
					previousNumber = currentNumber;
					runningTotal += currentNumber;
				}
				else
				{
					runningTotal = currentNumber - runningTotal;
				}
			}
            else 
			{ 
				Console.WriteLine("I have no idea what you are talking about"); 
				return; 
			}

		}


		
		int newValue = value + runningTotal;
		//step 4: add result to dictionary
		//Console.WriteLine("New value is: "+ newValue);
		GalaxyMetric.Add(input[numeralsLength - 1], newValue);
	}

	//fetch values from the dictionary to decode input and then roman stule calculation
	public void calculateGalacticValue(string[] input)
	{
		//step 1:get the starting position of the input and ending position

		int startingPoint = Array.IndexOf(input, "is") + 1;
		int endingPoint = Array.IndexOf(input, "?") - 1;
		
		//step 2: calculate total of values in index range


		int currentNumber = 0;
		int previousNumber = 999999999;
		int runningTotal = 0;
		string resultString = "";

		for (int i = startingPoint; i <= endingPoint; i++)
		{
			if (checkMetricExists(input[i]) == true)
			{
				resultString += input[i] + " ";
				currentNumber = fetchMetricValue(input[i]);
				if (currentNumber <= previousNumber)
				{
					previousNumber = currentNumber;
					runningTotal += currentNumber;
				}
				else
				{
					runningTotal = currentNumber - runningTotal;
				}
			}
			else 
			{ 
				Console.WriteLine("I have no idea what you are talking about"); 
				return; 
			}

		}

		resultString += "is ";

		Console.WriteLine(resultString + runningTotal);
		return;	
	}


	public void deduceInputType(string input)
    {
		string[] splitStatement = input.Split(' ');

		if (splitStatement[1].Equals("is"))
			updateGalacticMetric(splitStatement[0], splitStatement[2]);
		else if (splitStatement[0].Equals("how") && (splitStatement[1].Equals("much") || splitStatement[1].Equals("many")) && splitStatement.Contains<string>("is"))
			calculateGalacticValue(splitStatement);
		else if (splitStatement.Contains<string>("is"))
			deduceGalacticMetric(splitStatement);
		else
			Console.WriteLine("I have no idea what you are talking about");
	}
}
