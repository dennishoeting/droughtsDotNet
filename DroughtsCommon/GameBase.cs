using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace DroughtsCommon {
    public abstract class GameBase<T> where T : PlayerBase {

        int TurnTimeout { get; set; }

        public T Player1 { get; set; }
        public T Player2 { get; set; }
        public T ActivePlayer { get; private set; }
        public T InactivePlayer { get; private set; }

        public PlayingBoard PlayingBoard { get; private set; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="player1"></param>
        /// <param name="player2"></param>
        public GameBase(T player1, T player2) {
            if(player1 == null) {
                throw new ArgumentNullException("player1");
            }
            if(player2 == null) {
                throw new ArgumentNullException("player2");
            }

            if(player1 == player2) {
                throw new InvalidOperationException("Es müssen zwei Playerinstanzen übergeben werden.");
            }

            this.Player1 = player1;
            this.Player2 = player2;
            
            this.PlayingBoard = new PlayingBoard(player1, player2);

            this.ActivePlayer = this.Player1;
            this.InactivePlayer = this.Player2;

            this.TurnTimeout = 1000;
        }


        public void Start() {
            T winner;
            while(true) {
                Console.WriteLine(this.PlayingBoard.PrintPlayingBoard());

                Thread thread = new Thread(new ParameterizedThreadStart(this.ActivePlayer.DoMove));
                thread.Start(this.PlayingBoard);

                // Warten auf Zuggenerierung    
                Thread.Sleep(this.TurnTimeout);
                if(thread.ThreadState != ThreadState.Stopped) {
                    thread.Abort();

                    //TODO: Einen Stein feuern
                }

                if((winner = (T)this.PlayingBoard.CheckIfGameIsWon()) != null) {
                    break;
                }
                this.SwapPlayers();
            }
        }

        #region Helper-Methods

        private void SwapPlayers() {
            T t = this.ActivePlayer;
            this.ActivePlayer = this.InactivePlayer;
            this.InactivePlayer = t;
        }

        #endregion Helper-Methods
    }
}
