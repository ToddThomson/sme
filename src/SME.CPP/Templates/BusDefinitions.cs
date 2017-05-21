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
    using System;
    
    
    public partial class BusDefinitions : BusDefinitionsBase {
        
        public virtual string TransformText() {
            this.GenerationEnvironment = null;
            
            #line 1 ""
            this.Write("﻿");
            
            #line default
            #line hidden
            
            #line 6 ""
            this.Write("#ifndef SME_BUSDEFINITIONS_HPP\n#define SME_BUSDEFINITIONS_HPP\n\n#include \"SystemTypes.hpp\"\n\n// Insert additional includes here\n// #### USER-DATA-INCLUDE-START\n// #### USER-DATA-INCLUDE-END\n\n");
            
            #line default
            #line hidden
            
            #line 15 ""
 foreach(var bus in Network.Busses) { 
            
            #line default
            #line hidden
            
            #line 16 ""
            this.Write("\nclass ");
            
            #line default
            #line hidden
            
            #line 17 ""
            this.Write(this.ToStringHelper.ToStringWithCulture( bus.Name ));
            
            #line default
            #line hidden
            
            #line 17 ""
            this.Write(" {\nprivate:\n");
            
            #line default
            #line hidden
            
            #line 19 ""
     foreach(var signal in bus.Signals) { 
           var cpptype = RS.TypeScope.GetType(signal);
           if (cpptype.IsArray) { 
            
            #line default
            #line hidden
            
            #line 22 ""
            this.Write("    ");
            
            #line default
            #line hidden
            
            #line 22 ""
            this.Write(this.ToStringHelper.ToStringWithCulture( Type(signal) ));
            
            #line default
            #line hidden
            
            #line 22 ""
            this.Write(" write_");
            
            #line default
            #line hidden
            
            #line 22 ""
            this.Write(this.ToStringHelper.ToStringWithCulture( signal.Name ));
            
            #line default
            #line hidden
            
            #line 22 ""
            this.Write(";\n    ");
            
            #line default
            #line hidden
            
            #line 23 ""
            this.Write(this.ToStringHelper.ToStringWithCulture( Type(signal) ));
            
            #line default
            #line hidden
            
            #line 23 ""
            this.Write(" read_");
            
            #line default
            #line hidden
            
            #line 23 ""
            this.Write(this.ToStringHelper.ToStringWithCulture( signal.Name ));
            
            #line default
            #line hidden
            
            #line 23 ""
            this.Write(";\n    bool* valid_");
            
            #line default
            #line hidden
            
            #line 24 ""
            this.Write(this.ToStringHelper.ToStringWithCulture( signal.Name ));
            
            #line default
            #line hidden
            
            #line 24 ""
            this.Write(";\n    bool* written_");
            
            #line default
            #line hidden
            
            #line 25 ""
            this.Write(this.ToStringHelper.ToStringWithCulture( signal.Name ));
            
            #line default
            #line hidden
            
            #line 25 ""
            this.Write(";\n    bool* staged_");
            
            #line default
            #line hidden
            
            #line 26 ""
            this.Write(this.ToStringHelper.ToStringWithCulture( signal.Name ));
            
            #line default
            #line hidden
            
            #line 26 ""
            this.Write(";\n    size_t size_");
            
            #line default
            #line hidden
            
            #line 27 ""
            this.Write(this.ToStringHelper.ToStringWithCulture( signal.Name ));
            
            #line default
            #line hidden
            
            #line 27 ""
            this.Write(";\n");
            
            #line default
            #line hidden
            
            #line 28 ""
         } else { 
            
            #line default
            #line hidden
            
            #line 29 ""
            this.Write("    ");
            
            #line default
            #line hidden
            
            #line 29 ""
            this.Write(this.ToStringHelper.ToStringWithCulture( Type(signal) ));
            
            #line default
            #line hidden
            
            #line 29 ""
            this.Write(" write_");
            
            #line default
            #line hidden
            
            #line 29 ""
            this.Write(this.ToStringHelper.ToStringWithCulture( signal.Name ));
            
            #line default
            #line hidden
            
            #line 29 ""
            this.Write(";\n    ");
            
            #line default
            #line hidden
            
            #line 30 ""
            this.Write(this.ToStringHelper.ToStringWithCulture( Type(signal) ));
            
            #line default
            #line hidden
            
            #line 30 ""
            this.Write(" read_");
            
            #line default
            #line hidden
            
            #line 30 ""
            this.Write(this.ToStringHelper.ToStringWithCulture( signal.Name ));
            
            #line default
            #line hidden
            
            #line 30 ""
            this.Write(";\n    bool valid_");
            
            #line default
            #line hidden
            
            #line 31 ""
            this.Write(this.ToStringHelper.ToStringWithCulture( signal.Name ));
            
            #line default
            #line hidden
            
            #line 31 ""
            this.Write(";\n    bool written_");
            
            #line default
            #line hidden
            
            #line 32 ""
            this.Write(this.ToStringHelper.ToStringWithCulture( signal.Name ));
            
            #line default
            #line hidden
            
            #line 32 ""
            this.Write(";\n    bool staged_");
            
            #line default
            #line hidden
            
            #line 33 ""
            this.Write(this.ToStringHelper.ToStringWithCulture( signal.Name ));
            
            #line default
            #line hidden
            
            #line 33 ""
            this.Write(";\n");
            
            #line default
            #line hidden
            
            #line 34 ""
         } 
            
            #line default
            #line hidden
            
            #line 35 ""
     } 
            
            #line default
            #line hidden
            
            #line 36 ""
            this.Write("\npublic:\n\n    ");
            
            #line default
            #line hidden
            
            #line 39 ""
            this.Write(this.ToStringHelper.ToStringWithCulture( bus.Name ));
            
            #line default
            #line hidden
            
            #line 39 ""
            this.Write(" ();\n\n");
            
            #line default
            #line hidden
            
            #line 41 ""
     foreach(var signal in bus.Signals) { 
           var cpptype = RS.TypeScope.GetType(signal);
           if (cpptype.IsArray) { 
              var eltype = cpptype.ElementName; 
            
            #line default
            #line hidden
            
            #line 45 ""
            this.Write("    ");
            
            #line default
            #line hidden
            
            #line 45 ""
            this.Write(this.ToStringHelper.ToStringWithCulture( eltype ));
            
            #line default
            #line hidden
            
            #line 45 ""
            this.Write(" ");
            
            #line default
            #line hidden
            
            #line 45 ""
            this.Write(this.ToStringHelper.ToStringWithCulture( signal.Name ));
            
            #line default
            #line hidden
            
            #line 45 ""
            this.Write("(size_t index) const;\n    ");
            
            #line default
            #line hidden
            
            #line 46 ""
            this.Write(this.ToStringHelper.ToStringWithCulture( eltype ));
            
            #line default
            #line hidden
            
            #line 46 ""
            this.Write(" ");
            
            #line default
            #line hidden
            
            #line 46 ""
            this.Write(this.ToStringHelper.ToStringWithCulture( signal.Name ));
            
            #line default
            #line hidden
            
            #line 46 ""
            this.Write("(size_t index, ");
            
            #line default
            #line hidden
            
            #line 46 ""
            this.Write(this.ToStringHelper.ToStringWithCulture( eltype ));
            
            #line default
            #line hidden
            
            #line 46 ""
            this.Write(" value);\n");
            
            #line default
            #line hidden
            
            #line 47 ""
         } else { 
            
            #line default
            #line hidden
            
            #line 48 ""
            this.Write("    ");
            
            #line default
            #line hidden
            
            #line 48 ""
            this.Write(this.ToStringHelper.ToStringWithCulture( Type(signal) ));
            
            #line default
            #line hidden
            
            #line 48 ""
            this.Write(" ");
            
            #line default
            #line hidden
            
            #line 48 ""
            this.Write(this.ToStringHelper.ToStringWithCulture( signal.Name ));
            
            #line default
            #line hidden
            
            #line 48 ""
            this.Write("() const;\n    ");
            
            #line default
            #line hidden
            
            #line 49 ""
            this.Write(this.ToStringHelper.ToStringWithCulture( Type(signal) ));
            
            #line default
            #line hidden
            
            #line 49 ""
            this.Write(" ");
            
            #line default
            #line hidden
            
            #line 49 ""
            this.Write(this.ToStringHelper.ToStringWithCulture( signal.Name ));
            
            #line default
            #line hidden
            
            #line 49 ""
            this.Write("(");
            
            #line default
            #line hidden
            
            #line 49 ""
            this.Write(this.ToStringHelper.ToStringWithCulture( Type(signal) ));
            
            #line default
            #line hidden
            
            #line 49 ""
            this.Write(" value);\n");
            
            #line default
            #line hidden
            
            #line 50 ""
         } 
            
            #line default
            #line hidden
            
            #line 51 ""
     } 
            
            #line default
            #line hidden
            
            #line 52 ""
            this.Write("    void forward_signals();\n    void propagate_signals();\n};\n\n");
            
            #line default
            #line hidden
            
            #line 56 ""
 } 
            
            #line default
            #line hidden
            
            #line 57 ""
            this.Write("\n// Insert additional code and classes here\n// #### USER-DATA-EXTRA-START\n// #### USER-DATA-EXTRA-END\n\n#endif /* SME_BUSDEFINITIONS_HPP */\n");
            
            #line default
            #line hidden
            return this.GenerationEnvironment.ToString();
        }
        
        public virtual void Initialize() {
        }
    }
    
    public class BusDefinitionsBase {
        
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
