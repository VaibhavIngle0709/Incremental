﻿// Models/Player.cs
using System.ComponentModel.DataAnnotations;

namespace dotnetapp.Models
{


    public class Player
    {
        public int Id{get;set;}

        [Required]
        [MaxLength(17)]
        public string Name{get;set;}
        public string Category{get;set;}

        [Range(1,int.MaxValue,ErrorMessage="Bidding amount must be greater than 0.")]
        public decimal BiddingAmount{get;set;}
        

    }
}
