﻿using System;
using System.Linq;
using SME;

namespace ColorBin
{
	class MainClass
	{
		public static void Main(string[] args)
		{
            new Simulation()
                .BuildCSVFile()
                .BuildGraph()
                .BuildVHDL()
                .BuildCPP()
			    .Run(
                    new ImageInputSimulator("image1.png"),
                    new ColorBinCollector()
                );
		}
	}
}
