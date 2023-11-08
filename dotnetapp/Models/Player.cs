// Models/Player.cs
using System.ComponentModel.DataAnnotations;

namespace dotnetapp.Models
{

    //Id = 1, Name = "Player 1", Category = "bowler", BiddingAmount = 100m
    public class Player
    {
        public int Id{get;set;}
        public string Name{get;set;}
        public string Category{get;set;}
        public decimal BiddingAmount{get;set;}
        

    }
}
