﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BadmintonPlayerRankingLibrary.Models
{
    public class PlayersRankingModel
    {
        public int Id { get; set; }
        public int PlayerID { get; set; }
        public string? SinglesPoints { get; set; }
        public string? SinglesRanking { get; set; }
        public string? DoublesPoints { get; set; }
        public string? MixedPoints { get; set; }
        public string? MixedRanking { get; set; }
        public string? OverallPoints { get; set; }
        public string? OverallRanking { get; set; }

    }
}