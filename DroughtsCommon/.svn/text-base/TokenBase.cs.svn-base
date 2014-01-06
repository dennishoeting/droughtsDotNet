using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security;
using System.Collections.ObjectModel;

namespace DroughtsCommon {

    public abstract class TokenBase {

        public Position Position { get; internal set; }

        internal TokenBase(Position position) {
            this.Position = position;
        }


        internal abstract ReadOnlyCollection<Position> GetPossibleJumpDirections();

        internal abstract ReadOnlyCollection<Position> GetPossibleJumpDirectionsFrom(Position position);
    }
}
