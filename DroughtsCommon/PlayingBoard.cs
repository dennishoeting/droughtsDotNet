using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections.ObjectModel;
using System.Security;
using Util;

namespace DroughtsCommon {

    public sealed class PlayingBoard {

        [SecurityCriticalAttribute]
        private readonly PlayerBase _player1;

        [SecurityCriticalAttribute]
        private readonly PlayerBase _player2;

        [SecurityCriticalAttribute]
        private readonly Dictionary<PlayerBase, List<TokenBase>> _tokens = new Dictionary<PlayerBase,List<TokenBase>>(2);

        /// <summary>
        /// Die Spielsteine des Spielers (erster long sind normale Steine, zweiter long sind Damen)
        /// </summary>
        [SecurityCriticalAttribute]
        private readonly Dictionary<PlayerBase, Bitboard> _bitboards = new Dictionary<PlayerBase, Bitboard>(2);

        private long _makeDroughts1 = 1L;
        private long _makeDroughts2 = 1L;

        public PlayingBoard(PlayerBase player1, PlayerBase player2) {

            this._player1 = player1;
            this._player2 = player2;

            //Steine und Bitboards für den ersten Spieler erzeugen
            this._tokens[player1] = new List<TokenBase>() {
                new BlackToken(new Position(0, 1)),
                new BlackToken(new Position(0, 3)),
                new BlackToken(new Position(0, 5)),
                new BlackToken(new Position(0, 7)),
                new BlackToken(new Position(1, 0)),
                new BlackToken(new Position(1, 2)),
                new BlackToken(new Position(1, 4)),
                new BlackToken(new Position(1, 6)),
                new BlackToken(new Position(2, 1)),
                new BlackToken(new Position(2, 3)),
                new BlackToken(new Position(2, 5)),
                new BlackToken(new Position(2, 7)),
            };

            this._bitboards[player1] = new Bitboard(0x55AA550000000000, 0x0);

            //Steine und Bitboards für den zweiten Spieler erzeugen
            this._tokens[player2] = new List<TokenBase>() {
                new WhiteToken(new Position(5, 0)),
                new WhiteToken(new Position(5, 2)),
                new WhiteToken(new Position(5, 4)),
                new WhiteToken(new Position(5, 6)),
                new WhiteToken(new Position(6, 1)),
                new WhiteToken(new Position(6, 3)),
                new WhiteToken(new Position(6, 5)),
                new WhiteToken(new Position(6, 7)),
                new WhiteToken(new Position(7, 0)),
                new WhiteToken(new Position(7, 2)),
                new WhiteToken(new Position(7, 4)),
                new WhiteToken(new Position(7, 6)),
            };
            this._bitboards[player2] = new Bitboard(0x0000000000AA55AA, 0x0);
        }

        internal void Move(PlayerBase player, Move move) {

            //Stein bewegen
            this._tokens[player].Single(p => p == move.Token).Position = move.NewPosition;

            //Bitboard anpassen
            long from = 1L << (8 * (7 - move.Token.Position.I) + 7 - move.Token.Position.J);
            long to = 1L << (8 * (7 - move.NewPosition.I) + 7 - move.NewPosition.J);
            long bitFilter = from ^ to;
            //this._bitboards[player] ^= bitFilter;

            //Damen generieren
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="player"></param>
        /// <returns></returns>
        public ReadOnlyCollection<TokenBase> GetTokensForPlayer(PlayerBase player) {
            return new ReadOnlyCollection<TokenBase>(this._tokens[player]);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="player"></param>
        /// <returns></returns>
        public ReadOnlyCollection<TokenBase> GetTokensForOpponent(PlayerBase player) {
            return new ReadOnlyCollection<TokenBase>(this._tokens.First(p => p.Key != player).Value);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="player"></param>
        /// <returns></returns>
        public Bitboard GetBitboardForPlayer(PlayerBase player) {
            return this._bitboards[player];
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="player"></param>
        /// <returns></returns>
        public Bitboard GetBitboardForOpponent(PlayerBase player) {
            return this._bitboards[this._bitboards.First(p => p.Key != player).Key];
        }


        internal bool CheckIfMoveIsValidFor(PlayerBase player, Move move) {
            return this.GetAvailableMovesFor(player).Contains(move);
        }

        /// <summary>
        /// Prüft, ob ein das Spiel gewonnen ist und liefert den Spieler, der gewonnen hat.
        /// </summary>
        /// <returns>der Spieler der gewonnen hat, ansonsten null</returns>
        public PlayerBase CheckIfGameIsWon() {
            return this._bitboards.FirstOrDefault(p => p.Value == Bitboard.Empty).Key;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="player"></param>
        /// <returns></returns>
        public ReadOnlyCollection<Move> GetAvailableMovesFor(PlayerBase player) {
            List<Move> result = new List<Move>();
            foreach(TokenBase token in this._tokens[player]) {
                //Schauen
            }
            return new ReadOnlyCollection<Move>(result);
        }

        public List<Bitboard> GetAvailableMovesFor(PlayerBase player, Bitboard playerBitboard, Bitboard opponentBitboard) {
            List<Bitboard> result = new List<Bitboard>();
            return result;
        }

        /// <summary>
        /// 
        /// </summary>
        public void Replay() {

        }
        public string PrintPlayingBoard() {

            char[,] arr = new char[8, 8];
            foreach(TokenBase token in this._tokens[this._player1]) {
                arr[(int)(token.Position.I), (int)token.Position.J] = '*';
            }

            foreach(TokenBase token in this._tokens[this._player2]) {
                arr[(int)(token.Position.I), (int)token.Position.J] = '+';
            }

            StringBuilder result = new StringBuilder();
            result.AppendLine(this._player1.Name);
            result.AppendLine(" |A|B|C|D|E|F|G|H|");
            for(int i = 0; i < arr.GetLength(0); i++) {
                result.Append((i + 1) + "|");
                for(int j = 0; j < arr.GetLength(1); j++) {
                    result.Append(arr[i,j] + "|");
                }
                result.AppendLine();
                result.AppendLine(new string('-', 18));
            }
            result.AppendLine(this._player2.Name);

            return result.ToString();
        }
    }
}
