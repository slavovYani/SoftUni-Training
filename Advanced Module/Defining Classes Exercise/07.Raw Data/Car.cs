﻿using System;
using System.Collections.Generic;
using System.Text;

namespace RawData
{
    public class Car
    {
		public Car(string model, Engine engine, Cargo cargo, Tires[] tires)
		{
			this.Model = model;
			this.Engine = engine;
			this.Cargo = cargo;
			this.Tires = tires;
		}

		private string model;

		public string Model
		{
			get { return model; }
			set { model = value; }
		}


		private Engine engine;

		public Engine Engine
		{
			get { return engine; }
			set { engine = value; }
		}
		private Cargo cargo;

		public Cargo Cargo
		{
			get { return cargo; }
			set { cargo = value; }
		}

		private Tires[] tires;

		public Tires[] Tires
		{
			get { return tires; }
			set { tires = value; }
		}



	}
}
