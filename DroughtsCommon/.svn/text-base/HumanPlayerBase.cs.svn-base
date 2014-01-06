using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections.ObjectModel;

namespace DroughtsCommon {
    public abstract class HumanPlayerBase : PlayerBase {

        protected sealed override Move CreateMove(PlayingBoard playingBoard) {
            return this.CreateMove(playingBoard.GetTokensForPlayer(this));
        }

        protected abstract Move CreateMove(ReadOnlyCollection<TokenBase> myTokens);
    }
}
