using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
	public class Car
	{
		private string manufacturer = string.Empty;
		private string model = string.Empty;
		private string type = string.Empty;
		private string color = string.Empty;
		private bool isFWD;
		private int numAirBags;
		private float maxPower;
		private float wheelBase;
		private float tyreSize;
		private int numValves;

		public string Manufacturer
		{
			get { return manufacturer; }
			set { manufacturer = value; }
		}

		public string Model
		{
			get { return model; }
			set { model = value; }
		}

		public string Type
		{
			get { return type; }
			set { type = value; }
		}

		public string Color
		{
			get { return color; }
			set { color = value; }
		}

		public bool IsFWD
		{
			get { return isFWD; }
			set { isFWD = value; }
		}

		public int NumAirBags
		{
			get { return numAirBags; }
			set { numAirBags = value; }
		}
		public float MaxPower
		{
			get { return maxPower; }
			set { maxPower = value; }
		}
		public float WheelBase
		{
			get { return wheelBase; }
			set { wheelBase = value; }
		}
		public float TyreSize
		{
			get { return tyreSize; }
			set { tyreSize = value; }
		}
		public int NumValves
		{
			get { return numValves; }
			set { numValves = value; }
		}
	}

}
