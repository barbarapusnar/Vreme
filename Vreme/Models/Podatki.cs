﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Vreme.Models
{
    public class Podatki
    {
        [Display(Name = "Št. podatka")]
        public int Id { get; set; }
        [Display(Name = "Postaja")]
        public int IdPostaje { get; set; }
        [Display(Name = "Čas")]
        public DateTime Cas { get; set; }
        [Display(Name = "Temperatura")]
        public decimal Temp { get; set;}
        [Display(Name = "Vlaga")]
        public decimal Vlaga { get; set; }
        [Display(Name = "Podatek1")]
        public string Nekaj { get; set; }
        [Display(Name = "Podatek2")]
        public string Nevem { get; set; }

     
    }



}