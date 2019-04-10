using System;

namespace MyGame
{
	/// <summary>
	/// Ship name.
	/// </summary>
	public enum ShipName
	{
		/// <summary>
		/// No ship with 0 tile.
		/// </summary>
		None = 0,

		/// <summary>
		/// Tug ship with 1 tiles.
		/// </summary>
		Tug = 1,

		/// <summary>
		/// The submarine with 2 tiles.
		/// </summary>
		Submarine = 2,

		/// <summary>
		/// The Destroyer Ship with 3 tiles.
		/// </summary>
		Destroyer = 3,

		/// <summary>
		/// The battleship with 5 tiles.
		/// </summary>
		Battleship = 4,

		/// <summary>
		/// The aircraft carrier with 5 tiles.
		/// </summary>
		AircraftCarrier = 5
	}

}