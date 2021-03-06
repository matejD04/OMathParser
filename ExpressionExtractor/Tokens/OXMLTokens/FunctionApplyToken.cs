﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using OMathParser.Tokens.OXMLTokens.Abstract;

namespace OMathParser.Tokens.OXMLTokens
{
    public class FunctionApplyToken : AbstractToken
    {
        private TokenList funcBase;
        private TokenList funcName;

        public FunctionApplyToken(TokenList funcBase, TokenList funcName)
            : base()
        {
            this.funcBase = funcBase;
            this.funcName = funcName;
        }

        public override string simpleRepresentation()
        {
            return String.Format("Func: name=({0}), base=({1})", funcName.simpleRepresentation(), funcBase.simpleRepresentation());
        }

        public TokenList FunctionName { get => funcName; }
        public TokenList Arguments { get => funcBase; }
    }
}
