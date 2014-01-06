namespace DroughtsCommon {

    public struct Move {

        public TokenBase Token { get; private set; }
        public Position NewPosition { get; private set; }

        public Move(TokenBase token, Position newPosition) : this() {
            this.Token = token;
            this.NewPosition = newPosition;
        }

        public static bool operator ==(Move move1, Move move2) {
            return move1.Token == move2.Token && move1.NewPosition == move2.NewPosition;
        }

        public static bool operator !=(Move move1, Move move2) {
            return !(move1 == move2);
        }
    }
}