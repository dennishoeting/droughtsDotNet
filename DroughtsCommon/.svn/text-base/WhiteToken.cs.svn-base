using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections.ObjectModel;

namespace DroughtsCommon {
    public class WhiteToken : TokenBase {

        internal WhiteToken(Position position)
            : base(position) {
        }

        internal override ReadOnlyCollection<Position> GetPossibleJumpDirections() {
            List<Position> result = new List<Position>();

            return new ReadOnlyCollection<Position>(result);
        }

        internal override ReadOnlyCollection<Position> GetPossibleJumpDirectionsFrom(Position position) {
            throw new NotImplementedException();
        }
    }
}
