using System;

namespace TickerData
{
	public class TickerModel
	{
		public string Name { get; set; }
		/* сопротивление */
		public decimal Supply { get; set; }
		/* поддержка*/
		public decimal Demand { get; set; }
		public bool Pinbar { get; set; }
		public TickerModel()
		{
		}
	}
}
