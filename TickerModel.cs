using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace TickerData
{
	[Serializable]
	public class TickerModel
	{
		private decimal supply, demand;
		private string name;
		private bool pinbar;
		public string Name { get; set; }
		/* сопротивление */
		public decimal Supply { get { return supply; } set { supply = value; } }
		/* поддержка*/
		public decimal Demand { get { return demand; } set { demand = value; } }
		public bool Pinbar { get { return pinbar; } set { pinbar = value; } }
		public TickerModel()
		{
		}
	}
	public class TickerList : INotifyPropertyChanged
	{
		public List<TickerModel> List { get; set; }
		public bool IsDataChanged { get => isDataChanged; set => isDataChanged = value; }

		private bool isDataChanged = false;
		public TickerList()
		{
		}

		public event PropertyChangedEventHandler PropertyChanged;
		public void OnPropertyChanged([CallerMemberName]string prop = "")
		{
			if (PropertyChanged != null)
				isDataChanged = true;
				PropertyChanged(this, new PropertyChangedEventArgs(prop));
		}
	}
}
