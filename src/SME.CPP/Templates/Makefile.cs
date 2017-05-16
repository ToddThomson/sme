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
    using System;
    
    
    public partial class Makefile : MakefileBase {
        
        public virtual string TransformText() {
            this.GenerationEnvironment = null;
            
            #line 1 ""
            this.Write("﻿﻿");
            
            #line default
            #line hidden
            
            #line 6 ""
            this.Write("all: build\n\nGPP = g++\nCPPFLAGS = \n\nbuild: ");
            
            #line default
            #line hidden
            
            #line 11 ""
            this.Write(this.ToStringHelper.ToStringWithCulture( Naming.AssemblyNameToFileName(Network) ));
            
            #line default
            #line hidden
            
            #line 11 ""
            this.Write("\n\n");
            
            #line default
            #line hidden
            
            #line 13 ""

var cust_tag = CustomFiles == null || CustomFiles.Count() == 0 ? "" : " custom_files";

            
            #line default
            #line hidden
            
            #line 16 ""
            this.Write("\n");
            
            #line default
            #line hidden
            
            #line 17 ""
 if (!string.IsNullOrEmpty(cust_tag)) { 
            
            #line default
            #line hidden
            
            #line 18 ""
            this.Write("custom_files: ");
            
            #line default
            #line hidden
            
            #line 18 ""
 foreach(var file in CustomFiles) { 
            
            #line default
            #line hidden
            
            #line 19 ""
            this.Write(this.ToStringHelper.ToStringWithCulture( file ));
            
            #line default
            #line hidden
            
            #line 19 ""
            this.Write(".o ");
            
            #line default
            #line hidden
            
            #line 19 ""
 } 
            
            #line default
            #line hidden
            
            #line 20 ""
            this.Write("\n");
            
            #line default
            #line hidden
            
            #line 21 ""
 } 
            
            #line default
            #line hidden
            
            #line 22 ""
            this.Write("\n");
            
            #line default
            #line hidden
            
            #line 23 ""
            this.Write(this.ToStringHelper.ToStringWithCulture( Naming.BusImplementationsFileName(Network) ));
            
            #line default
            #line hidden
            
            #line 23 ""
            this.Write(".o: SystemTypes.hpp ");
            
            #line default
            #line hidden
            
            #line 23 ""
            this.Write(this.ToStringHelper.ToStringWithCulture( Naming.BusDefinitionsFileName(Network) ));
            
            #line default
            #line hidden
            
            #line 23 ""
            this.Write("\n\t${GPP} ${CPPFLAGS} -c ");
            
            #line default
            #line hidden
            
            #line 24 ""
            this.Write(this.ToStringHelper.ToStringWithCulture( Naming.BusImplementationsFileName(Network) ));
            
            #line default
            #line hidden
            
            #line 24 ""
            this.Write(".cpp\n\n");
            
            #line default
            #line hidden
            
            #line 26 ""
 foreach (var file in Filenames) { 
            
            #line default
            #line hidden
            
            #line 27 ""
            this.Write(this.ToStringHelper.ToStringWithCulture( file ));
            
            #line default
            #line hidden
            
            #line 27 ""
            this.Write(".o: ");
            
            #line default
            #line hidden
            
            #line 27 ""
            this.Write(this.ToStringHelper.ToStringWithCulture( file ));
            
            #line default
            #line hidden
            
            #line 27 ""
            this.Write(".cpp SystemTypes.hpp ");
            
            #line default
            #line hidden
            
            #line 27 ""
            this.Write(this.ToStringHelper.ToStringWithCulture( Naming.BusDefinitionsFileName(Network) ));
            
            #line default
            #line hidden
            
            #line 27 ""
            this.Write(" ");
            
            #line default
            #line hidden
            
            #line 27 ""
            this.Write(this.ToStringHelper.ToStringWithCulture( file ));
            
            #line default
            #line hidden
            
            #line 27 ""
            this.Write(".hpp");
            
            #line default
            #line hidden
            
            #line 27 ""
            this.Write(this.ToStringHelper.ToStringWithCulture( cust_tag ));
            
            #line default
            #line hidden
            
            #line 27 ""
            this.Write("\n\t${GPP} ${CPPFLAGS} -c ");
            
            #line default
            #line hidden
            
            #line 28 ""
            this.Write(this.ToStringHelper.ToStringWithCulture( file ));
            
            #line default
            #line hidden
            
            #line 28 ""
            this.Write(".cpp\n");
            
            #line default
            #line hidden
            
            #line 29 ""
 } 
            
            #line default
            #line hidden
            
            #line 30 ""
            this.Write("\n");
            
            #line default
            #line hidden
            
            #line 31 ""
 if (!string.IsNullOrEmpty(cust_tag)) { 
            
            #line default
            #line hidden
            
            #line 32 ""
     foreach (var file in CustomFiles) { 
            
            #line default
            #line hidden
            
            #line 33 ""
            this.Write(this.ToStringHelper.ToStringWithCulture( file ));
            
            #line default
            #line hidden
            
            #line 33 ""
            this.Write(".o: ");
            
            #line default
            #line hidden
            
            #line 33 ""
            this.Write(this.ToStringHelper.ToStringWithCulture( file ));
            
            #line default
            #line hidden
            
            #line 33 ""
            this.Write(".cpp SystemTypes.hpp ");
            
            #line default
            #line hidden
            
            #line 33 ""
            this.Write(this.ToStringHelper.ToStringWithCulture( Naming.BusDefinitionsFileName(Network) ));
            
            #line default
            #line hidden
            
            #line 33 ""
            this.Write("\n\t${GPP} ${CPPFLAGS} -c ");
            
            #line default
            #line hidden
            
            #line 34 ""
            this.Write(this.ToStringHelper.ToStringWithCulture( file ));
            
            #line default
            #line hidden
            
            #line 34 ""
            this.Write(".cpp\n");
            
            #line default
            #line hidden
            
            #line 35 ""
     } 
            
            #line default
            #line hidden
            
            #line 36 ""
 } 
            
            #line default
            #line hidden
            
            #line 37 ""
            this.Write("\n\n");
            
            #line default
            #line hidden
            
            #line 39 ""
            this.Write(this.ToStringHelper.ToStringWithCulture( Naming.AssemblyNameToFileName(Network) ));
            
            #line default
            #line hidden
            
            #line 39 ""
            this.Write(": SystemTypes.hpp ");
            
            #line default
            #line hidden
            
            #line 39 ""
            this.Write(this.ToStringHelper.ToStringWithCulture( Naming.BusDefinitionsFileName(Network) ));
            
            #line default
            #line hidden
            
            #line 39 ""
            this.Write(" ");
            
            #line default
            #line hidden
            
            #line 39 ""
            this.Write(this.ToStringHelper.ToStringWithCulture( Naming.BusImplementationsFileName(Network) ));
            
            #line default
            #line hidden
            
            #line 39 ""
            this.Write(".o ");
            
            #line default
            #line hidden
            
            #line 39 ""
 foreach(var file in Filenames) { 
            
            #line default
            #line hidden
            
            #line 40 ""
            this.Write(this.ToStringHelper.ToStringWithCulture( file ));
            
            #line default
            #line hidden
            
            #line 40 ""
            this.Write(".o ");
            
            #line default
            #line hidden
            
            #line 40 ""
            this.Write(this.ToStringHelper.ToStringWithCulture( file ));
            
            #line default
            #line hidden
            
            #line 40 ""
            this.Write(".hpp ");
            
            #line default
            #line hidden
            
            #line 40 ""
 } 
            
            #line default
            #line hidden
            
            #line 41 ""
            this.Write(this.ToStringHelper.ToStringWithCulture( cust_tag ));
            
            #line default
            #line hidden
            
            #line 41 ""
            this.Write("\n\t${GPP} ");
            
            #line default
            #line hidden
            
            #line 42 ""
            this.Write(this.ToStringHelper.ToStringWithCulture( Naming.AssemblyNameToFileName(Network) ));
            
            #line default
            #line hidden
            
            #line 42 ""
            this.Write(" ");
            
            #line default
            #line hidden
            
            #line 42 ""
            this.Write(this.ToStringHelper.ToStringWithCulture( Naming.BusImplementationsFileName(Network) ));
            
            #line default
            #line hidden
            
            #line 42 ""
            this.Write(".o ");
            
            #line default
            #line hidden
            
            #line 42 ""
 foreach(var file in Filenames) { 
            
            #line default
            #line hidden
            
            #line 43 ""
            this.Write(this.ToStringHelper.ToStringWithCulture( file ));
            
            #line default
            #line hidden
            
            #line 43 ""
            this.Write(".o ");
            
            #line default
            #line hidden
            
            #line 43 ""
 } 
            
            #line default
            #line hidden
            
            #line 44 ""
            this.Write(" -o ");
            
            #line default
            #line hidden
            
            #line 44 ""
            this.Write(this.ToStringHelper.ToStringWithCulture( Network.Name ));
            
            #line default
            #line hidden
            
            #line 44 ""
            this.Write("\n\nclean:\n\trm -rf *.o ");
            
            #line default
            #line hidden
            
            #line 47 ""
            this.Write(this.ToStringHelper.ToStringWithCulture( Network.Name ));
            
            #line default
            #line hidden
            
            #line 47 ""
            this.Write("\n\n\n.PHONY: all clean ");
            
            #line default
            #line hidden
            
            #line 50 ""
            this.Write(this.ToStringHelper.ToStringWithCulture( cust_tag ));
            
            #line default
            #line hidden
            
            #line 50 ""
            this.Write("\n");
            
            #line default
            #line hidden
            return this.GenerationEnvironment.ToString();
        }
        
        public virtual void Initialize() {
        }
    }
    
    public class MakefileBase {
        
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
