﻿// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      Mono Runtime Version: 4.0.30319.42000
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------

namespace SME.CPP.Templates {
    using System.Linq;
    using System.Text;
    using System.Collections.Generic;
    using SME.AST;
    using System;
    
    
    public partial class ProcessItem : ProcessItemBase {
        
        public virtual string TransformText() {
            this.GenerationEnvironment = null;
            
            #line 1 ""
            this.Write("﻿");
            
            #line default
            #line hidden
            
            #line 7 ""
            this.Write("\n#include <iostream>\n#include <cstring>\n#include \"");
            
            #line default
            #line hidden
            
            #line 10 ""
            this.Write(this.ToStringHelper.ToStringWithCulture( RSP.Process.Name ));
            
            #line default
            #line hidden
            
            #line 10 ""
            this.Write(".hpp\"\n\n// Insert additional includes and methods here\n// #### USER-DATA-EXTRA-START\n// #### USER-DATA-EXTRA-END\n\n\n");
            
            #line default
            #line hidden
            
            #line 17 ""

var busses = RSP.Process.InputBusses.Union(RSP.Process.OutputBusses).Union(RSP.Process.InternalBusses).Distinct().OrderBy(x => x.Name).ToArray();

            
            #line default
            #line hidden
            
            #line 20 ""
            this.Write("\n");
            
            #line default
            #line hidden
            
            #line 21 ""
            this.Write(this.ToStringHelper.ToStringWithCulture( RSP.Process.Name ));
            
            #line default
            #line hidden
            
            #line 21 ""
            this.Write("::");
            
            #line default
            #line hidden
            
            #line 21 ""
            this.Write(this.ToStringHelper.ToStringWithCulture( RSP.Process.Name ));
            
            #line default
            #line hidden
            
            #line 21 ""
            this.Write("(\n");
            
            #line default
            #line hidden
            
            #line 22 ""
 foreach(var bus in busses) { 
            
            #line default
            #line hidden
            
            #line 23 ""
            this.Write("    ");
            
            #line default
            #line hidden
            
            #line 23 ""
            this.Write(this.ToStringHelper.ToStringWithCulture( bus.Name ));
            
            #line default
            #line hidden
            
            #line 23 ""
            this.Write("* p");
            
            #line default
            #line hidden
            
            #line 23 ""
            this.Write(this.ToStringHelper.ToStringWithCulture( bus.Name ));
            
            #line default
            #line hidden
            
            #line 23 ""
            this.Write(this.ToStringHelper.ToStringWithCulture( bus == busses.Last() ? "" : "," ));
            
            #line default
            #line hidden
            
            #line 23 ""
            this.Write("\n");
            
            #line default
            #line hidden
            
            #line 24 ""
  } 
            
            #line default
            #line hidden
            
            #line 25 ""
            this.Write(") {\n");
            
            #line default
            #line hidden
            
            #line 26 ""
 foreach(var bus in busses) { 
            
            #line default
            #line hidden
            
            #line 27 ""
            this.Write("    bus_");
            
            #line default
            #line hidden
            
            #line 27 ""
            this.Write(this.ToStringHelper.ToStringWithCulture( bus.Name ));
            
            #line default
            #line hidden
            
            #line 27 ""
            this.Write(" = p");
            
            #line default
            #line hidden
            
            #line 27 ""
            this.Write(this.ToStringHelper.ToStringWithCulture( bus.Name ));
            
            #line default
            #line hidden
            
            #line 27 ""
            this.Write(";\n");
            
            #line default
            #line hidden
            
            #line 28 ""
  } 
            
            #line default
            #line hidden
            
            #line 29 ""
            this.Write("\n");
            
            #line default
            #line hidden
            
            #line 30 ""
 foreach(var v in RSP.Process.SharedVariables.Cast<DataElement>().Union(RSP.Process.SharedSignals)) { 
       var initializer = RS.Renderer.GetInitializer(v);
       if (!string.IsNullOrWhiteSpace(initializer)) { 
           var rt = RS.TypeScope.GetType(v);
           if (rt.IsArray) {
               var eltype = rt.ElementName;

               var arraylen =
                   (v.DefaultValue is SME.AST.ArrayCreateExpression)
                   ? (v.DefaultValue as SME.AST.ArrayCreateExpression).ElementExpressions.Length.ToString()
                   : RS.Renderer.RenderExpression((v.DefaultValue as SME.AST.EmptyArrayCreateExpression).SizeExpression);

               if ((v.DefaultValue is SME.AST.ArrayCreateExpression)) { 
            
            #line default
            #line hidden
            
            #line 43 ""
            this.Write("    ");
            
            #line default
            #line hidden
            
            #line 43 ""
            this.Write(this.ToStringHelper.ToStringWithCulture( v.Name ));
            
            #line default
            #line hidden
            
            #line 43 ""
            this.Write(" = new ");
            
            #line default
            #line hidden
            
            #line 43 ""
            this.Write(this.ToStringHelper.ToStringWithCulture( eltype ));
            
            #line default
            #line hidden
            
            #line 43 ""
            this.Write("[");
            
            #line default
            #line hidden
            
            #line 43 ""
            this.Write(this.ToStringHelper.ToStringWithCulture( arraylen ));
            
            #line default
            #line hidden
            
            #line 43 ""
            this.Write("];\n    ");
            
            #line default
            #line hidden
            
            #line 44 ""
            this.Write(this.ToStringHelper.ToStringWithCulture( eltype ));
            
            #line default
            #line hidden
            
            #line 44 ""
            this.Write(" orig_");
            
            #line default
            #line hidden
            
            #line 44 ""
            this.Write(this.ToStringHelper.ToStringWithCulture( v.Name ));
            
            #line default
            #line hidden
            
            #line 44 ""
            this.Write("[]");
            
            #line default
            #line hidden
            
            #line 44 ""
            this.Write(this.ToStringHelper.ToStringWithCulture( initializer ));
            
            #line default
            #line hidden
            
            #line 44 ""
            this.Write(";\n    std::memcpy(");
            
            #line default
            #line hidden
            
            #line 45 ""
            this.Write(this.ToStringHelper.ToStringWithCulture( v.Name ));
            
            #line default
            #line hidden
            
            #line 45 ""
            this.Write(", orig_");
            
            #line default
            #line hidden
            
            #line 45 ""
            this.Write(this.ToStringHelper.ToStringWithCulture( v.Name ));
            
            #line default
            #line hidden
            
            #line 45 ""
            this.Write(", ");
            
            #line default
            #line hidden
            
            #line 45 ""
            this.Write(this.ToStringHelper.ToStringWithCulture( arraylen ));
            
            #line default
            #line hidden
            
            #line 45 ""
            this.Write(" * sizeof(");
            
            #line default
            #line hidden
            
            #line 45 ""
            this.Write(this.ToStringHelper.ToStringWithCulture( eltype ));
            
            #line default
            #line hidden
            
            #line 45 ""
            this.Write("));\n");
            
            #line default
            #line hidden
            
            #line 46 ""
             } else { 
            
            #line default
            #line hidden
            
            #line 47 ""
            this.Write("    ");
            
            #line default
            #line hidden
            
            #line 47 ""
            this.Write(this.ToStringHelper.ToStringWithCulture( v.Name ));
            
            #line default
            #line hidden
            
            #line 47 ""
            this.Write(" = new ");
            
            #line default
            #line hidden
            
            #line 47 ""
            this.Write(this.ToStringHelper.ToStringWithCulture( eltype ));
            
            #line default
            #line hidden
            
            #line 47 ""
            this.Write("[");
            
            #line default
            #line hidden
            
            #line 47 ""
            this.Write(this.ToStringHelper.ToStringWithCulture( arraylen ));
            
            #line default
            #line hidden
            
            #line 47 ""
            this.Write("]();\n");
            
            #line default
            #line hidden
            
            #line 48 ""
             } 
            
            #line default
            #line hidden
            
            #line 49 ""
            this.Write("    size_");
            
            #line default
            #line hidden
            
            #line 49 ""
            this.Write(this.ToStringHelper.ToStringWithCulture( v.Name ));
            
            #line default
            #line hidden
            
            #line 49 ""
            this.Write(" = ");
            
            #line default
            #line hidden
            
            #line 49 ""
            this.Write(this.ToStringHelper.ToStringWithCulture( arraylen ));
            
            #line default
            #line hidden
            
            #line 49 ""
            this.Write(";\n");
            
            #line default
            #line hidden
            
            #line 50 ""
         } else { 
            
            #line default
            #line hidden
            
            #line 51 ""
            this.Write("    ");
            
            #line default
            #line hidden
            
            #line 51 ""
            this.Write(this.ToStringHelper.ToStringWithCulture( v.Name ));
            
            #line default
            #line hidden
            
            #line 51 ""
            this.Write(this.ToStringHelper.ToStringWithCulture( initializer ));
            
            #line default
            #line hidden
            
            #line 51 ""
            this.Write(";\n");
            
            #line default
            #line hidden
            
            #line 52 ""
         } 
            
            #line default
            #line hidden
            
            #line 53 ""
     } 
            
            #line default
            #line hidden
            
            #line 54 ""
 } 
            
            #line default
            #line hidden
            
            #line 55 ""
            this.Write("\n    // Insert additional initialization here\n    // #### USER-DATA-INIT-START\n    // #### USER-DATA-INIT-END\n}\n\nvoid ");
            
            #line default
            #line hidden
            
            #line 61 ""
            this.Write(this.ToStringHelper.ToStringWithCulture( RSP.Process.Name ));
            
            #line default
            #line hidden
            
            #line 61 ""
            this.Write("::onTick() {\n    // Insert additional pre- clock-tick code here\n    // #### USER-DATA-PRE-START\n    // #### USER-DATA-PRE-END\n\n");
            
            #line default
            #line hidden
            
            #line 66 ""
     foreach(var line in RS.Renderer.RenderMethod(RSP.Process.MainMethod)) { 
            
            #line default
            #line hidden
            
            #line 67 ""
            this.Write("    ");
            
            #line default
            #line hidden
            
            #line 67 ""
            this.Write(this.ToStringHelper.ToStringWithCulture( line ));
            
            #line default
            #line hidden
            
            #line 67 ""
            this.Write("\n");
            
            #line default
            #line hidden
            
            #line 68 ""
     } 
            
            #line default
            #line hidden
            
            #line 69 ""
            this.Write("\n    // Insert additional post- clock-tick code here\n    // #### USER-DATA-POST-START\n    // #### USER-DATA-POST-END\n}\n");
            
            #line default
            #line hidden
            
            #line 74 ""
 if (RSP.Process.Methods != null && RSP.Process.Methods.Any(x => !x.Ignore)) { 
            
            #line default
            #line hidden
            
            #line 75 ""
            this.Write("\n// Internal methods\n");
            
            #line default
            #line hidden
            
            #line 77 ""
     foreach (var s in RSP.Process.Methods.Where(x => !x.Ignore)) { 
            
            #line default
            #line hidden
            
            #line 78 ""

           var rettype = (s.ReturnVariable == null || s.ReturnVariable.CecilType.IsSameTypeReference(typeof(void))) ? "void" : Type(s.ReturnVariable);

            
            #line default
            #line hidden
            
            #line 81 ""
            this.Write(this.ToStringHelper.ToStringWithCulture( rettype ));
            
            #line default
            #line hidden
            
            #line 81 ""
            this.Write(" ");
            
            #line default
            #line hidden
            
            #line 81 ""
            this.Write(this.ToStringHelper.ToStringWithCulture( RSP.Process.Name ));
            
            #line default
            #line hidden
            
            #line 81 ""
            this.Write("::");
            
            #line default
            #line hidden
            
            #line 81 ""
            this.Write(this.ToStringHelper.ToStringWithCulture( s.Name ));
            
            #line default
            #line hidden
            
            #line 81 ""
            this.Write("(");
            
            #line default
            #line hidden
            
            #line 81 ""
            this.Write(this.ToStringHelper.ToStringWithCulture( string.Join(", ", s.Parameters.Select(x => $"{Type(x)} {x.Name}")) ));
            
            #line default
            #line hidden
            
            #line 81 ""
            this.Write(") {\n");
            
            #line default
            #line hidden
            
            #line 82 ""
         foreach(var line in RS.Renderer.RenderMethod(s)) { 
            
            #line default
            #line hidden
            
            #line 83 ""
            this.Write("    ");
            
            #line default
            #line hidden
            
            #line 83 ""
            this.Write(this.ToStringHelper.ToStringWithCulture( line ));
            
            #line default
            #line hidden
            
            #line 83 ""
            this.Write("\n");
            
            #line default
            #line hidden
            
            #line 84 ""
         } 
            
            #line default
            #line hidden
            
            #line 85 ""
            this.Write("}\n");
            
            #line default
            #line hidden
            
            #line 86 ""
     } 
            
            #line default
            #line hidden
            
            #line 87 ""
 } 
            
            #line default
            #line hidden
            return this.GenerationEnvironment.ToString();
        }
        
        public virtual void Initialize() {
        }
    }
    
    public class ProcessItemBase {
        
        private global::System.Text.StringBuilder builder;
        
        private global::System.Collections.Generic.IDictionary<string, object> session;
        
        private global::System.CodeDom.Compiler.CompilerErrorCollection errors;
        
        private string currentIndent = string.Empty;
        
        private global::System.Collections.Generic.Stack<int> indents;
        
        private ToStringInstanceHelper _toStringHelper = new ToStringInstanceHelper();
        
        public virtual global::System.Collections.Generic.IDictionary<string, object> Session {
            get {
                return this.session;
            }
            set {
                this.session = value;
            }
        }
        
        public global::System.Text.StringBuilder GenerationEnvironment {
            get {
                if ((this.builder == null)) {
                    this.builder = new global::System.Text.StringBuilder();
                }
                return this.builder;
            }
            set {
                this.builder = value;
            }
        }
        
        protected global::System.CodeDom.Compiler.CompilerErrorCollection Errors {
            get {
                if ((this.errors == null)) {
                    this.errors = new global::System.CodeDom.Compiler.CompilerErrorCollection();
                }
                return this.errors;
            }
        }
        
        public string CurrentIndent {
            get {
                return this.currentIndent;
            }
        }
        
        private global::System.Collections.Generic.Stack<int> Indents {
            get {
                if ((this.indents == null)) {
                    this.indents = new global::System.Collections.Generic.Stack<int>();
                }
                return this.indents;
            }
        }
        
        public ToStringInstanceHelper ToStringHelper {
            get {
                return this._toStringHelper;
            }
        }
        
        public void Error(string message) {
            this.Errors.Add(new global::System.CodeDom.Compiler.CompilerError(null, -1, -1, null, message));
        }
        
        public void Warning(string message) {
            global::System.CodeDom.Compiler.CompilerError val = new global::System.CodeDom.Compiler.CompilerError(null, -1, -1, null, message);
            val.IsWarning = true;
            this.Errors.Add(val);
        }
        
        public string PopIndent() {
            if ((this.Indents.Count == 0)) {
                return string.Empty;
            }
            int lastPos = (this.currentIndent.Length - this.Indents.Pop());
            string last = this.currentIndent.Substring(lastPos);
            this.currentIndent = this.currentIndent.Substring(0, lastPos);
            return last;
        }
        
        public void PushIndent(string indent) {
            this.Indents.Push(indent.Length);
            this.currentIndent = (this.currentIndent + indent);
        }
        
        public void ClearIndent() {
            this.currentIndent = string.Empty;
            this.Indents.Clear();
        }
        
        public void Write(string textToAppend) {
            this.GenerationEnvironment.Append(textToAppend);
        }
        
        public void Write(string format, params object[] args) {
            this.GenerationEnvironment.AppendFormat(format, args);
        }
        
        public void WriteLine(string textToAppend) {
            this.GenerationEnvironment.Append(this.currentIndent);
            this.GenerationEnvironment.AppendLine(textToAppend);
        }
        
        public void WriteLine(string format, params object[] args) {
            this.GenerationEnvironment.Append(this.currentIndent);
            this.GenerationEnvironment.AppendFormat(format, args);
            this.GenerationEnvironment.AppendLine();
        }
        
        public class ToStringInstanceHelper {
            
            private global::System.IFormatProvider formatProvider = global::System.Globalization.CultureInfo.InvariantCulture;
            
            public global::System.IFormatProvider FormatProvider {
                get {
                    return this.formatProvider;
                }
                set {
                    if ((value != null)) {
                        this.formatProvider = value;
                    }
                }
            }
            
            public string ToStringWithCulture(object objectToConvert) {
                if ((objectToConvert == null)) {
                    throw new global::System.ArgumentNullException("objectToConvert");
                }
                global::System.Type type = objectToConvert.GetType();
                global::System.Type iConvertibleType = typeof(global::System.IConvertible);
                if (iConvertibleType.IsAssignableFrom(type)) {
                    return ((global::System.IConvertible)(objectToConvert)).ToString(this.formatProvider);
                }
                global::System.Reflection.MethodInfo methInfo = type.GetMethod("ToString", new global::System.Type[] {
                            iConvertibleType});
                if ((methInfo != null)) {
                    return ((string)(methInfo.Invoke(objectToConvert, new object[] {
                                this.formatProvider})));
                }
                return objectToConvert.ToString();
            }
        }
    }
}