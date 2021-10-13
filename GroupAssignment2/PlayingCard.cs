using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupAssignment2
{
	public enum PlayingCardColor
	{
		Clubs = 0, Diamonds, Hearts, Spades         // Poker suit order, Spades highest
	}
	public enum PlayingCardValue
	{
		Two = 2, Three, Four, Five, Six, Seven, Eight, Nine, Ten,
		Knight, Queen, King, Ace                // Poker Value order
	}
	public class PlayingCard
	{
		public PlayingCardColor Color { get; init; }
		public PlayingCardValue Value { get; init; }

		public string BlackOrRed
		{
			get
			{
				if (Color == PlayingCardColor.Clubs || Color == PlayingCardColor.Spades)
					return "Black";

				return "Red";
			}
		}
		/// <summary>
		/// Returns "Face" for Ace,Knight, Queen, King. Otherwise it returns "Value".
		/// 
		/// </summary>
		string FaceOrValue
		{
			//Use switch statment or switch expression
			get
			{
				return Value switch
				{
					PlayingCardValue.Ace => "Face",
					PlayingCardValue.Knight => "Face",
					PlayingCardValue.Queen => "Face",
					PlayingCardValue.King => "Face",
					_ => "Value",
				};
			}
		}
		public override string ToString() => $"{Value} of {Color}, a {BlackOrRed} {FaceOrValue} card";

		/// <summary>
		/// Write a constructor that generates a random card. I.e., PlayingCard card1 = new PlayingCard() 
		/// generates a random card.
		/// </summary>
		public PlayingCard() 
		{
			//Use the .Net class Random to generate a random number
			var rnd = new Random();

			Color = (PlayingCardColor) rnd.Next((int)PlayingCardColor.Clubs, (int) PlayingCardColor.Spades + 1);
			Value = (PlayingCardValue)rnd.Next((int)PlayingCardValue.Two, (int)PlayingCardValue.Ace + 1);
		}
	}
}
