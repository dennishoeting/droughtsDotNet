using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DroughtsCommon {
    public abstract class TokenDecoratorBase : TokenBase {

        protected TokenBase TokenToDecorate { get; private set; }

        public TokenDecoratorBase(TokenBase tokenToDecorate) : base(tokenToDecorate.Position) {
            this.TokenToDecorate = tokenToDecorate;
        }
    }
}
