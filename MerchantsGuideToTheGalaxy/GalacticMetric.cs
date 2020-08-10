using System;
using System.Collections.Generic;
using System.Linq;

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
		Console.WriteLine("updating");
		int value = GalaxyMetric[roman];
		GalaxyMetric.Remove(roman);
		GalaxyMetric.Add(galactic, value);
	}


	//Deduce new Galactic Metric number by subtracting known values from a chain input
	public void deduceGalacticMetric(string[] input)
	{
		Console.WriteLine("deducing");
	}

	//fetch values from the dictionary to decode input and then roman stule calculation
	public int calculateGalacticValue(string[] input)
	{
		Console.WriteLine("Calculate");
		return 0;
	}


	public string deduceInputType(string input)
    {
		string[] splitStatement = input.Split(' ');
		Console.WriteLine(input);
		if (splitStatement[1].Equals("is"))
			updateGalacticMetric(splitStatement[0], splitStatement[2]);
		else if (splitStatement[0].Equals("how") && (splitStatement[1].Equals("much") || splitStatement[1].Equals("many")) && splitStatement.Contains<string>("is"))
			calculateGalacticValue(splitStatement);
		else if (splitStatement.Contains<string>("is"))
			deduceGalacticMetric(splitStatement);
		else
			Console.WriteLine("I dont know what yuo talking about");
		return "fish";
	

	}


}
