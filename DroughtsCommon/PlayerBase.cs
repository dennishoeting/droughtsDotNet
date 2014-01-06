using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DroughtsCommon {

    public abstract class PlayerBase {

        public string Name { get; set; }
   
        internal void DoMove(object playingBoard) {
            PlayingBoard realPlayingBoard = (PlayingBoard)playingBoard;
            try {
                Move move;
                do {
                    move = this.CreateMove(realPlayingBoard);
                } while(realPlayingBoard.CheckIfMoveIsValidFor(this, move));
                realPlayingBoard.Move(this, move);
            } catch(System.Exception ex) {
                Console.WriteLine(ex.Message);
            }
        }

        protected abstract Move CreateMove(PlayingBoard playingBoard);

        public sealed override bool Equals(object obj) {
            return base.Equals(obj);
        }
    }
}
