﻿using System;
using System.Collections.Generic;
using System.Text;

namespace TrackerLibrary
{
    public class MatchupEntryModel
    {

        /// <summary>
        ///   Reprents one team in the matchup.
        /// </summary>
        public TeamModel TeamCompeting { get; set; }

        /// <summary>
        ///  Represents the score for this particular team.
        /// </summary>
        public double Score { get; set; }

        /// <summary>
        /// represents the matchup that this team came from as the winner.
        /// </summary>
        public MatchupModel ParentMatchup { get; set; }



    }
}
