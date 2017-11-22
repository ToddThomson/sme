﻿using System;
using System.Collections.Generic;
using System.Linq;
using SME.AST;
using SME.AST.Transform;

namespace SME.VHDL.Transformations
{
    public class UntangleElseStatements : IASTTransform
    {
		/// <summary>
		/// The render state.
		/// </summary>
		private readonly RenderState State;
		/// <summary>
		/// The method being transformed
		/// </summary>
		private readonly Method Method;

        /// <summary>
        /// Cache of handled methods
        /// </summary>
        private HashSet<ASTItem> m_handled = new HashSet<ASTItem>();

		/// <summary>
		/// Initializes a new instance of the <see cref="T:SME.VHDL.Transformations.UntangleElseStatements"/> class.
		/// </summary>
		/// <param name="state">The render state.</param>
		/// <param name="method">The method being rendered.</param>
		public UntangleElseStatements(RenderState state, Method method)
		{
			State = state;
			Method = method;
		}

        /// <summary>
        /// Applies the transformation
        /// </summary>
        /// <returns>The transformed item.</returns>
        /// <param name="item">The item to visit.</param>
        public ASTItem Transform(ASTItem item)
        {
            if (item is ReturnStatement && Method.Parent is AST.Process && ((AST.Process)Method.Parent).MainMethod == Method)
            {
                if (m_handled.Contains(item))
                    return item;

                m_handled.Add(item);

                object pos = ((ReturnStatement)item).SourceStatement;
                if (item.Parent is AST.BlockStatement)
                    pos = ((AST.BlockStatement)item.Parent).SourceStatement;

                var parentif = item.Parent;
                while (parentif != null && !(parentif is AST.IfElseStatement))
                    parentif = parentif.Parent;

                if (parentif == null)
                {                    
                    Console.WriteLine("Unable to transform return statement in main method, try building the source program in Debug mode. Statement location is: {0}", pos);
                    return item;
                }

                pos = ((AST.IfElseStatement)parentif).SourceStatement;
                if (!(((AST.IfElseStatement)parentif).FalseStatement is EmptyStatement))
                {
                    Console.WriteLine("Unable to transform return statement in main method, try building the source program in Debug mode. Statement location is: {0}", pos);
                    return item;
                }

                var blockparent = parentif.Parent as AST.Method;
                if (blockparent == null)
                {
                    Console.WriteLine("Unable to transform return statement in main method, try building the source program in Debug mode. Statement location is: {0}", pos);
                    return item;
                }

                var ix = Array.IndexOf(blockparent.Statements, parentif);
                if (ix < 0)
                {
                    Console.WriteLine("Unable to transform return statement in main method, try building the source program in Debug mode. Statement location is: {0}", pos);
                    return item;
                }

                var remain = blockparent.Statements.Skip(ix + 1).ToArray();

                ((ReturnStatement)item).ReplaceWith(new EmptyStatement());

                // If there are no other statements, we are good, but this should not happen
                if (remain.Length == 0)
                {
                    return null;
                }
                else
                {
                    blockparent.Statements = blockparent.Statements.Take(ix + 1).ToArray();

                    // One left, then skip the block construct
                    if (remain.Length == 1)
                    {
                        ((AST.IfElseStatement)parentif).FalseStatement = remain[0];
                    }
                    else
                    {
                        ((AST.IfElseStatement)parentif).FalseStatement = new BlockStatement()
                        {
                            Parent = parentif,
                            Statements = remain,
                            SourceStatement = ((AST.IfElseStatement)parentif).SourceStatement
                        };
                    }

                    ((AST.IfElseStatement)parentif).FalseStatement.UpdateParents();

                    return null;
                }

            }

            return item;
        }
	}
}
