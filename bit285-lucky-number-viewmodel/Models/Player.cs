﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace bit285_lucky_number_viewmodel.Models
{
    public class Player
    {
        //TODO: Add the properties neededby the Player entity (including Data Annotations)
        public int PlayerId { get; set; }
       public string Name { get; set; }
        [Range(1,9)]
       public int Number { get; set; }
       
        [RegularExpression(@"^\$?\d+(\.(\d{2}))?$")]
        public decimal Balance { get; set; }
    }
}