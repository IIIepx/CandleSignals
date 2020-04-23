using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace TickerData
{
	[Serializable]
	public class TickerModel
	{
		public Dictionary<string, string> dicTickers = new Dictionary<string, string>(20);
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
			dicTickers.Add("Si", "Доллар - рубль");
			dicTickers.Add("RI", "Индекс РТС");
			dicTickers.Add("BR", "Нефть");
			dicTickers.Add("GD", "Золото");
			dicTickers.Add("ED", "Евро - доллар");
			dicTickers.Add("Eu", "Евро - рубль");
			dicTickers.Add("MX", "Индекс мосбиржи");
			dicTickers.Add("SR", "Сбербанк");
			dicTickers.Add("LK", "Лукойл");
			dicTickers.Add("SV", "Серебро");
			dicTickers.Add("RN", "Роснефть");
			dicTickers.Add("GU", "Фунт - доллар");
			dicTickers.Add("VB", "ВТБ");
			dicTickers.Add("GM", "Норильский Никель");
			dicTickers.Add("SN", "Сургутнефтегаз");
			dicTickers.Add("AF", "Аэрофлот");
			dicTickers.Add("SP", "Сбербанк префы");
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
