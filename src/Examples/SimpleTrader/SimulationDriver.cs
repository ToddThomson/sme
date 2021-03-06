﻿using System;
using System.Linq;
using System.Threading.Tasks;
using SME;

namespace SimpleTrader
{
	class SimulationDriver : SimulationProcess
	{
		[OutputBus]
        private SimpleTrader.ITraderInput Output = Scope.CreateOrLoadBus<SimpleTrader.ITraderInput>();

		public override async Task Run()
		{
			var rn = new Random();
			Output.Valid = false;

			foreach (var v in GenerateRandomValueSequence.GetUIntSequence().Take(500))
			{
				await ClockAsync();

				// Simulate bubbles in the input
				if (rn.NextDouble() > 0.85)
				{
					Output.Valid = false;
					await ClockAsync();
				}

				Output.Valid = true;
				Output.Value = v;
			}

			await ClockAsync();
			Output.Valid = false;
			await ClockAsync();
		}
	}
}
