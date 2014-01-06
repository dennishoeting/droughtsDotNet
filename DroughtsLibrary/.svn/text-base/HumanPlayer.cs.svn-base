using System;
using DroughtsCommon;
using System.Collections.ObjectModel;

namespace DroughtsImplementation {

    public class HumanPlayer : HumanPlayerBase {

        public HumanPlayer(string name) {
            this.Name = name;
        }


        protected override Move CreateMove(ReadOnlyCollection<TokenBase> myTokens) {
            Random r = new Random();
            return new Move(myTokens[r.Next(myTokens.Count)], new Position(r.Next(8), r.Next(8)));
        }
    }
}