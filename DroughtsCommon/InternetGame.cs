using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DroughtsCommon {
    public sealed class InternetGame : GameBase<HumanPlayerBase> {

        /// <summary>
        /// 
        /// </summary>
        /// <param name="player1"></param>
        /// <param name="player2"></param>
        public InternetGame(HumanPlayerBase player1, HumanPlayerBase player2)  : base(player1, player2) {
        }
    }
}
