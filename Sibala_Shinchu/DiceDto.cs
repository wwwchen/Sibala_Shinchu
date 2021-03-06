﻿using System;
using System.Collections.Generic;

namespace Sibala_Hsinchu
{
    public class DiceDto
    {
        public DiceDto(int point, StatusEnum status)
        {
            this.DicePoints = point;
            this.Status = status;
        }
        public enum StatusEnum { SameColor, Points, NoPoints }

        public StatusEnum Status { get; set; }
        public int DicePoints { get; set; }
        public List<int> SourceSibala { get; set; }
    }
}