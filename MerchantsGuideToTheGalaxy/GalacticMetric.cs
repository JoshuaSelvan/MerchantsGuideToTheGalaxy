using System;
using System.Collections.Generic;

public class GalacticMetric
{

	Dictionary<string, int, string> GalaxyMetric =
	new Dictionary<string, int,string>();

	public GalacticMetric()
    {
		GalaxyMetric.Add("I", 1, "?");
		GalaxyMetric.Add("V", 5, "?");
		GalaxyMetric.Add("X", 10, "?");
		GalaxyMetric.Add("C", 100, "?");
		GalaxyMetric.Add("L", 250, "?");
		GalaxyMetric.Add("D", 500, "?");
		GalaxyMetric.Add("M", 1000, "?");

		
	}

	//Add secondary galactic key which corresponds to roman key
	public void updateGalacticMetric(string galactic, string roman)
	{
		int value = GalacticMetric[roman]
		dict.Remove(roman);
		dict.Add(galactic, value);
	};


	//Deduce new Galactic Metric number by subtracting known values from a chain input
	public void deduceGalacticMetric(string[] input, int resultingValue)
	{ }

	//fetch values from the dictionary to decode input and then roman stule calculation
	public int calculateGalacticValue(string[])
	{ };


	public string[] deduceInputType(string input)
    {


    }

}
