﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

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
            this.Write(".hpp\"\n\n// Insert additional includes and methods here\n// #### USER-DATA-EXTRA-STA" +
                    "RT\n// #### USER-DATA-EXTRA-END\n\n\n");
            
            #line default
            #line hidden
            
            #line 17 ""

var busses = RSP.Process.InputBusses.Concat(RSP.Process.OutputBusses).Concat(RSP.Process.InternalBusses).Distinct().OrderBy(x => x.Name).ToArray();
var members = RSP.Process.SharedVariables.Cast<DataElement>().Union(RSP.Process.SharedSignals).ToArray();

            
            #line default
            #line hidden
            
            #line 21 ""
            this.Write("\n");
            
            #line default
            #line hidden
            
            #line 22 ""
            this.Write(this.ToStringHelper.ToStringWithCulture( RSP.Process.Name ));
            
            #line default
            #line hidden
            
            #line 22 ""
            this.Write("::");
            
            #line default
            #line hidden
            
            #line 22 ""
            this.Write(this.ToStringHelper.ToStringWithCulture( RSP.Process.Name ));
            
            #line default
            #line hidden
            
            #line 22 ""
            this.Write("(\n");
            
            #line default
            #line hidden
            
            #line 23 ""
 foreach(var bus in busses) { 
            
            #line default
            #line hidden
            
            #line 24 ""
            this.Write("    ");
            
            #line default
            #line hidden
            
            #line 24 ""
            this.Write(this.ToStringHelper.ToStringWithCulture( bus.Name ));
            
            #line default
            #line hidden
            
            #line 24 ""
            this.Write("* p");
            
            #line default
            #line hidden
            
            #line 24 ""
            this.Write(this.ToStringHelper.ToStringWithCulture( Naming.BusNameToValidName(bus, RSP.Process) ));
            
            #line default
            #line hidden
            
            #line 24 ""
            this.Write(this.ToStringHelper.ToStringWithCulture( (bus == busses.Last() && members.Length == 0) ? "" : "," ));
            
            #line default
            #line hidden
            
            #line 24 ""
            this.Write("\n");
            
            #line default
            #line hidden
            
            #line 25 ""
  } 
            
            #line default
            #line hidden
            
            #line 26 ""
 foreach(var v in members) { 
       var rt = RS.TypeScope.GetType(v);
       if (rt.IsArray) { 
            
            #line default
            #line hidden
            
            #line 29 ""
            this.Write("    size_t init_size_");
            
            #line default
            #line hidden
            
            #line 29 ""
            this.Write(this.ToStringHelper.ToStringWithCulture( v.Name ));
            
            #line default
            #line hidden
            
            #line 29 ""
            this.Write(",\n");
            
            #line default
            #line hidden
            
            #line 30 ""
     } 
            
            #line default
            #line hidden
            
            #line 31 ""
            this.Write("    const ");
            
            #line default
            #line hidden
            
            #line 31 ""
            this.Write(this.ToStringHelper.ToStringWithCulture( Type(v) ));
            
            #line default
            #line hidden
            
            #line 31 ""
            this.Write(" init_");
            
            #line default
            #line hidden
            
            #line 31 ""
            this.Write(this.ToStringHelper.ToStringWithCulture( v.Name ));
            
            #line default
            #line hidden
            
            #line 31 ""
            this.Write(this.ToStringHelper.ToStringWithCulture( v == members.Last() ? "" : "," ));
            
            #line default
            #line hidden
            
            #line 31 ""
            this.Write("\n");
            
            #line default
            #line hidden
            
            #line 32 ""
  } 
            
            #line default
            #line hidden
            
            #line 33 ""
            this.Write(") {\n");
            
            #line default
            #line hidden
            
            #line 34 ""
 foreach(var bus in busses) { 
            
            #line default
            #line hidden
            
            #line 35 ""
            this.Write("    bus_");
            
            #line default
            #line hidden
            
            #line 35 ""
            this.Write(this.ToStringHelper.ToStringWithCulture( Naming.BusNameToValidName(bus, RSP.Process) ));
            
            #line default
            #line hidden
            
            #line 35 ""
            this.Write(" = p");
            
            #line default
            #line hidden
            
            #line 35 ""
            this.Write(this.ToStringHelper.ToStringWithCulture( Naming.BusNameToValidName(bus, RSP.Process) ));
            
            #line default
            #line hidden
            
            #line 35 ""
            this.Write(";\n");
            
            #line default
            #line hidden
            
            #line 36 ""
  } 
            
            #line default
            #line hidden
            
            #line 37 ""
            this.Write("\n");
            
            #line default
            #line hidden
            
            #line 38 ""
 foreach(var v in members) {
       var rt = RS.TypeScope.GetType(v);
       if (rt.IsArray) { 
           var eltype = rt.ElementName;

            
            #line default
            #line hidden
            
            #line 43 ""
            this.Write("    size_");
            
            #line default
            #line hidden
            
            #line 43 ""
            this.Write(this.ToStringHelper.ToStringWithCulture( v.Name ));
            
            #line default
            #line hidden
            
            #line 43 ""
            this.Write(" = init_size_");
            
            #line default
            #line hidden
            
            #line 43 ""
            this.Write(this.ToStringHelper.ToStringWithCulture( v.Name ));
            
            #line default
            #line hidden
            
            #line 43 ""
            this.Write(";\n    ");
            
            #line default
            #line hidden
            
            #line 44 ""
            this.Write(this.ToStringHelper.ToStringWithCulture( v.Name ));
            
            #line default
            #line hidden
            
            #line 44 ""
            this.Write(" = new ");
            
            #line default
            #line hidden
            
            #line 44 ""
            this.Write(this.ToStringHelper.ToStringWithCulture( eltype ));
            
            #line default
            #line hidden
            
            #line 44 ""
            this.Write("[size_");
            
            #line default
            #line hidden
            
            #line 44 ""
            this.Write(this.ToStringHelper.ToStringWithCulture( v.Name ));
            
            #line default
            #line hidden
            
            #line 44 ""
            this.Write("];\n    std::memcpy(");
            
            #line default
            #line hidden
            
            #line 45 ""
            this.Write(this.ToStringHelper.ToStringWithCulture( v.Name ));
            
            #line default
            #line hidden
            
            #line 45 ""
            this.Write(", init_");
            
            #line default
            #line hidden
            
            #line 45 ""
            this.Write(this.ToStringHelper.ToStringWithCulture( v.Name ));
            
            #line default
            #line hidden
            
            #line 45 ""
            this.Write(", size_");
            
            #line default
            #line hidden
            
            #line 45 ""
            this.Write(this.ToStringHelper.ToStringWithCulture( v.Name ));
            
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
            this.Write(" = init_");
            
            #line default
            #line hidden
            
            #line 47 ""
            this.Write(this.ToStringHelper.ToStringWithCulture( v.Name ));
            
            #line default
            #line hidden
            
            #line 47 ""
            this.Write(";\n");
            
            #line default
            #line hidden
            
            #line 48 ""
     }
            
            #line default
            #line hidden
            
            #line 49 ""
 } 
            
            #line default
            #line hidden
            
            #line 50 ""
            this.Write("\n    // Insert additional initialization here\n    // #### USER-DATA-INIT-START\n  " +
                    "  // #### USER-DATA-INIT-END\n}\n\nvoid ");
            
            #line default
            #line hidden
            
            #line 56 ""
            this.Write(this.ToStringHelper.ToStringWithCulture( RSP.Process.Name ));
            
            #line default
            #line hidden
            
            #line 56 ""
            this.Write("::onTick() {\n    // Insert additional pre- clock-tick code here\n    // #### USER-" +
                    "DATA-PRE-START\n    // #### USER-DATA-PRE-END\n\n");
            
            #line default
            #line hidden
            
            #line 61 ""
     foreach(var line in RS.Renderer.RenderMethod(RSP.Process.MainMethod)) { 
            
            #line default
            #line hidden
            
            #line 62 ""
            this.Write("    ");
            
            #line default
            #line hidden
            
            #line 62 ""
            this.Write(this.ToStringHelper.ToStringWithCulture( line ));
            
            #line default
            #line hidden
            
            #line 62 ""
            this.Write("\n");
            
            #line default
            #line hidden
            
            #line 63 ""
     } 
            
            #line default
            #line hidden
            
            #line 64 ""
            this.Write("\n    // Insert additional post- clock-tick code here\n    // #### USER-DATA-POST-S" +
                    "TART\n    // #### USER-DATA-POST-END\n}\n");
            
            #line default
            #line hidden
            
            #line 69 ""
 if (RSP.Process.Methods != null && RSP.Process.Methods.Any(x => !x.Ignore)) { 
            
            #line default
            #line hidden
            
            #line 70 ""
            this.Write("\n// Internal methods\n");
            
            #line default
            #line hidden
            
            #line 72 ""
     foreach (var s in RSP.Process.Methods.Where(x => !x.Ignore)) { 
            
            #line default
            #line hidden
            
            #line 73 ""

           var rettype = (s.ReturnVariable == null || s.ReturnVariable.CecilType.IsSameTypeReference(typeof(void))) ? "void" : Type(s.ReturnVariable);

            
            #line default
            #line hidden
            
            #line 76 ""
            this.Write(this.ToStringHelper.ToStringWithCulture( rettype ));
            
            #line default
            #line hidden
            
            #line 76 ""
            this.Write(" ");
            
            #line default
            #line hidden
            
            #line 76 ""
            this.Write(this.ToStringHelper.ToStringWithCulture( RSP.Process.Name ));
            
            #line default
            #line hidden
            
            #line 76 ""
            this.Write("::");
            
            #line default
            #line hidden
            
            #line 76 ""
            this.Write(this.ToStringHelper.ToStringWithCulture( s.Name ));
            
            #line default
            #line hidden
            
            #line 76 ""
            this.Write("(");
            
            #line default
            #line hidden
            
            #line 76 ""
            this.Write(this.ToStringHelper.ToStringWithCulture( string.Join(", ", s.Parameters.Select(x => $"{Type(x)} {x.Name}")) ));
            
            #line default
            #line hidden
            
            #line 76 ""
            this.Write(") {\n");
            
            #line default
            #line hidden
            
            #line 77 ""
         foreach(var line in RS.Renderer.RenderMethod(s)) { 
            
            #line default
            #line hidden
            
            #line 78 ""
            this.Write("    ");
            
            #line default
            #line hidden
            
            #line 78 ""
            this.Write(this.ToStringHelper.ToStringWithCulture( line ));
            
            #line default
            #line hidden
            
            #line 78 ""
            this.Write("\n");
            
            #line default
            #line hidden
            
            #line 79 ""
         } 
            
            #line default
            #line hidden
            
            #line 80 ""
            this.Write("}\n");
            
            #line default
            #line hidden
            
            #line 81 ""
     } 
            
            #line default
            #line hidden
            
            #line 82 ""
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
