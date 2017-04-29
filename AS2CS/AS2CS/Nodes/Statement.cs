﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AS2CS.Nodes
{
    public class Statement : Node
    {
        public Statement(TokenStream tokenStream) : base(tokenStream)
        {
        }

        public override Node Select()
        {
            if (!Accept(TokenNode.Semicolon(ts)))
            {
                if (!Accept<CommaExpr>())
                {
                    if (!)
                }
                else
                {
                    Expect(TokenNode.Semicolon(ts));
                }
            }
        }
    }
}
