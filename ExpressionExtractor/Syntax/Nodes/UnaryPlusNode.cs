﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using OMathParser.Syntax.Nodes.Abstract;

namespace OMathParser.Syntax.Nodes
{
    public class UnaryPlusNode : UnaryNode
    {
        public UnaryPlusNode(SyntaxNode child) : base(child)
        {
        }

        public override double getValue()
        {
            return child.getValue();
        }

        public override string simpleRepresentation()
        {
            return String.Format("UnaryPlus: {0} ", child.simpleRepresentation());
        }

        public override string toInfixNotation()
        {
            return base.toInfixNotation("+");
        }

        public override string toPostfixNotation()
        {
            return base.toPostfixNotation("+");
        }
    }
}
