﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SME.VHDL.Templates {
    using System.Linq;
    using SME;
    using System.Text;
    using System.Collections.Generic;
    using SME.VHDL;
    using SME.AST;
    using System;
    
    
    public partial class Entity : EntityBase {
        
        public virtual string TransformText() {
            this.GenerationEnvironment = null;
            
            #line 9 ""
            this.Write(@"library IEEE;
use IEEE.STD_LOGIC_1164.ALL;
use IEEE.NUMERIC_STD.ALL;

-- library SYSTEM_TYPES;
use work.SYSTEM_TYPES.ALL;

-- library CUSTOM_TYPES;
use work.CUSTOM_TYPES.ALL;

-- User defined packages here
-- #### USER-DATA-IMPORTS-START
-- #### USER-DATA-IMPORTS-END


entity ");
            
            #line default
            #line hidden
            
            #line 24 ""
            this.Write(this.ToStringHelper.ToStringWithCulture( Process.Name ));
            
            #line default
            #line hidden
            
            #line 24 ""
            this.Write(" is\n  port(\n");
            
            #line default
            #line hidden
            
            #line 26 ""
 foreach (var bus in Process.InputBusses.Where(x => !Process.OutputBusses.Contains(x))) { 
       var busname = RS.GetLocalBusName(bus, Process);

            
            #line default
            #line hidden
            
            #line 29 ""
            this.Write("    -- Input bus ");
            
            #line default
            #line hidden
            
            #line 29 ""
            this.Write(this.ToStringHelper.ToStringWithCulture( busname ));
            
            #line default
            #line hidden
            
            #line 29 ""
            this.Write(" signals\n");
            
            #line default
            #line hidden
            
            #line 30 ""
     foreach (var signal in bus.Signals) { 
            
            #line default
            #line hidden
            
            #line 31 ""
            this.Write("    ");
            
            #line default
            #line hidden
            
            #line 31 ""
            this.Write(this.ToStringHelper.ToStringWithCulture( Naming.ToValidName(busname + "_" + signal.Name) ));
            
            #line default
            #line hidden
            
            #line 31 ""
            this.Write(": in ");
            
            #line default
            #line hidden
            
            #line 31 ""
            this.Write(this.ToStringHelper.ToStringWithCulture( RS.VHDLWrappedTypeName(signal) ));
            
            #line default
            #line hidden
            
            #line 31 ""
            this.Write(";\n");
            
            #line default
            #line hidden
            
            #line 32 ""
     } 
            
            #line default
            #line hidden
            
            #line 33 ""
 } 
            
            #line default
            #line hidden
            
            #line 34 ""
            this.Write("\n");
            
            #line default
            #line hidden
            
            #line 35 ""
 foreach (var bus in Process.OutputBusses.Where(x => !Process.InputBusses.Contains(x))) {
       var busname = RS.GetLocalBusName(bus, Process);

            
            #line default
            #line hidden
            
            #line 38 ""
            this.Write("    -- Output bus ");
            
            #line default
            #line hidden
            
            #line 38 ""
            this.Write(this.ToStringHelper.ToStringWithCulture( busname ));
            
            #line default
            #line hidden
            
            #line 38 ""
            this.Write(" signals\n");
            
            #line default
            #line hidden
            
            #line 39 ""
     foreach (var signal in RSP.WrittenSignals(bus)) { 
            
            #line default
            #line hidden
            
            #line 40 ""
            this.Write("    ");
            
            #line default
            #line hidden
            
            #line 40 ""
            this.Write(this.ToStringHelper.ToStringWithCulture( Naming.ToValidName(busname + "_" + signal.Name) ));
            
            #line default
            #line hidden
            
            #line 40 ""
            this.Write(": out ");
            
            #line default
            #line hidden
            
            #line 40 ""
            this.Write(this.ToStringHelper.ToStringWithCulture( RS.VHDLWrappedTypeName(signal) ));
            
            #line default
            #line hidden
            
            #line 40 ""
            this.Write(";\n");
            
            #line default
            #line hidden
            
            #line 41 ""
     } 
            
            #line default
            #line hidden
            
            #line 42 ""
 } 
            
            #line default
            #line hidden
            
            #line 43 ""
            this.Write("\n");
            
            #line default
            #line hidden
            
            #line 44 ""
 foreach (var bus in Process.InputBusses.Where(x => Process.OutputBusses.Contains(x))) {
       var busname = RS.GetLocalBusName(bus, Process);

            
            #line default
            #line hidden
            
            #line 47 ""
            this.Write("    -- Input/output bus ");
            
            #line default
            #line hidden
            
            #line 47 ""
            this.Write(this.ToStringHelper.ToStringWithCulture( busname ));
            
            #line default
            #line hidden
            
            #line 47 ""
            this.Write(" signals\n");
            
            #line default
            #line hidden
            
            #line 48 ""
     foreach (var signal in bus.Signals) { 
            
            #line default
            #line hidden
            
            #line 49 ""
            this.Write("    ");
            
            #line default
            #line hidden
            
            #line 49 ""
            this.Write(this.ToStringHelper.ToStringWithCulture( Naming.ToValidName(busname + "_" + signal.Name) ));
            
            #line default
            #line hidden
            
            #line 49 ""
            this.Write(": in ");
            
            #line default
            #line hidden
            
            #line 49 ""
            this.Write(this.ToStringHelper.ToStringWithCulture( RS.VHDLWrappedTypeName(signal) ));
            
            #line default
            #line hidden
            
            #line 49 ""
            this.Write(";\n");
            
            #line default
            #line hidden
            
            #line 50 ""
     } 
            
            #line default
            #line hidden
            
            #line 51 ""
            this.Write("\n");
            
            #line default
            #line hidden
            
            #line 52 ""
     foreach (var signal in bus.Signals) { 
            
            #line default
            #line hidden
            
            #line 53 ""
            this.Write("    out_");
            
            #line default
            #line hidden
            
            #line 53 ""
            this.Write(this.ToStringHelper.ToStringWithCulture( Naming.ToValidName(busname + "_" + signal.Name) ));
            
            #line default
            #line hidden
            
            #line 53 ""
            this.Write(": out ");
            
            #line default
            #line hidden
            
            #line 53 ""
            this.Write(this.ToStringHelper.ToStringWithCulture( RS.VHDLWrappedTypeName(signal) ));
            
            #line default
            #line hidden
            
            #line 53 ""
            this.Write(";\n");
            
            #line default
            #line hidden
            
            #line 54 ""
     } 
            
            #line default
            #line hidden
            
            #line 55 ""
 } 
            
            #line default
            #line hidden
            
            #line 56 ""
            this.Write("\n");
            
            #line default
            #line hidden
            
            #line 57 ""
 if (Process.SharedVariables.Any() || Process.SharedSignals.Any()) { 
            
            #line default
            #line hidden
            
            #line 58 ""
            this.Write("    -- Initialization values\n");
            
            #line default
            #line hidden
            
            #line 59 ""
     foreach (var variable in Process.SharedVariables) { 
            
            #line default
            #line hidden
            
            #line 60 ""
            this.Write("    ");
            
            #line default
            #line hidden
            
            #line 60 ""
            this.Write(this.ToStringHelper.ToStringWithCulture( variable.Name ));
            
            #line default
            #line hidden
            
            #line 60 ""
            this.Write("_reset_value: in ");
            
            #line default
            #line hidden
            
            #line 60 ""
            this.Write(this.ToStringHelper.ToStringWithCulture( RS.VHDLWrappedTypeName(variable) ));
            
            #line default
            #line hidden
            
            #line 60 ""
            this.Write(";\n");
            
            #line default
            #line hidden
            
            #line 61 ""
     } 
            
            #line default
            #line hidden
            
            #line 62 ""
     foreach (var variable in Process.SharedSignals) { 
            
            #line default
            #line hidden
            
            #line 63 ""
            this.Write("    ");
            
            #line default
            #line hidden
            
            #line 63 ""
            this.Write(this.ToStringHelper.ToStringWithCulture( variable.Name ));
            
            #line default
            #line hidden
            
            #line 63 ""
            this.Write("_reset_value: in ");
            
            #line default
            #line hidden
            
            #line 63 ""
            this.Write(this.ToStringHelper.ToStringWithCulture( RS.VHDLWrappedTypeName(variable) ));
            
            #line default
            #line hidden
            
            #line 63 ""
            this.Write(";\n");
            
            #line default
            #line hidden
            
            #line 64 ""
     } 
            
            #line default
            #line hidden
            
            #line 65 ""
 } 
            
            #line default
            #line hidden
            
            #line 66 ""
            this.Write("\n    -- Clock signal\n    CLK : in Std_logic;\n\n    -- Ready signal\n    RDY : in St" +
                    "d_logic;\n\n    -- Finished signal\n    FIN : out Std_logic;\n\n    -- Reset signal\n " +
                    "   RST : in Std_logic\n );\nend ");
            
            #line default
            #line hidden
            
            #line 79 ""
            this.Write(this.ToStringHelper.ToStringWithCulture( Process.Name ));
            
            #line default
            #line hidden
            
            #line 79 ""
            this.Write(";\n\narchitecture RTL of ");
            
            #line default
            #line hidden
            
            #line 81 ""
            this.Write(this.ToStringHelper.ToStringWithCulture( Process.Name ));
            
            #line default
            #line hidden
            
            #line 81 ""
            this.Write(" is\n");
            
            #line default
            #line hidden
            
            #line 82 ""
 foreach (var bus in Process.InternalBusses) {
       var busname = RS.GetLocalBusName(bus, Process);

            
            #line default
            #line hidden
            
            #line 85 ""
            this.Write("  -- Internal bus ");
            
            #line default
            #line hidden
            
            #line 85 ""
            this.Write(this.ToStringHelper.ToStringWithCulture( busname ));
            
            #line default
            #line hidden
            
            #line 85 ""
            this.Write(" signals\n");
            
            #line default
            #line hidden
            
            #line 86 ""
     foreach (var signal in bus.Signals) { 
            
            #line default
            #line hidden
            
            #line 87 ""
            this.Write("  signal ");
            
            #line default
            #line hidden
            
            #line 87 ""
            this.Write(this.ToStringHelper.ToStringWithCulture( Naming.ToValidName(busname + "_" + signal.Name) ));
            
            #line default
            #line hidden
            
            #line 87 ""
            this.Write(": ");
            
            #line default
            #line hidden
            
            #line 87 ""
            this.Write(this.ToStringHelper.ToStringWithCulture( RS.VHDLWrappedTypeName(signal) ));
            
            #line default
            #line hidden
            
            #line 87 ""
            this.Write(";\n");
            
            #line default
            #line hidden
            
            #line 88 ""
     } 
            
            #line default
            #line hidden
            
            #line 89 ""
            this.Write("\n");
            
            #line default
            #line hidden
            
            #line 90 ""
 } 
            
            #line default
            #line hidden
            
            #line 91 ""
            this.Write("\n");
            
            #line default
            #line hidden
            
            #line 92 ""
 if (Process.SharedSignals.Any()) { 
            
            #line default
            #line hidden
            
            #line 93 ""
            this.Write("  -- Internal signals\n");
            
            #line default
            #line hidden
            
            #line 94 ""
     foreach (var s in Process.SharedSignals) { 
            
            #line default
            #line hidden
            
            #line 95 ""
            this.Write("  signal ");
            
            #line default
            #line hidden
            
            #line 95 ""
            this.Write(this.ToStringHelper.ToStringWithCulture( s.Name ));
            
            #line default
            #line hidden
            
            #line 95 ""
            this.Write(" : ");
            
            #line default
            #line hidden
            
            #line 95 ""
            this.Write(this.ToStringHelper.ToStringWithCulture( RS.VHDLWrappedTypeName(s) ));
            
            #line default
            #line hidden
            
            #line 95 ""
            this.Write(";\n");
            
            #line default
            #line hidden
            
            #line 96 ""
     } 
            
            #line default
            #line hidden
            
            #line 97 ""
 } 
            
            #line default
            #line hidden
            
            #line 98 ""
            this.Write("\n");
            
            #line default
            #line hidden
            
            #line 99 ""
 if (RSP.IsComponent) { 
            
            #line default
            #line hidden
            
            #line 100 ""
            this.Write("  -- Component declaration and signals\n");
            
            #line default
            #line hidden
            
            #line 101 ""
            this.Write(this.ToStringHelper.ToStringWithCulture( RSP.ComponentSignals ));
            
            #line default
            #line hidden
            
            #line 101 ""
            this.Write("\n");
            
            #line default
            #line hidden
            
            #line 102 ""
 } 
            
            #line default
            #line hidden
            
            #line 103 ""
            this.Write("\n");
            
            #line default
            #line hidden
            
            #line 104 ""
 if (Process.Methods != null && Process.Methods.Any(x => !x.Ignore)) { 
            
            #line default
            #line hidden
            
            #line 105 ""
            this.Write("  -- Internal methods\n");
            
            #line default
            #line hidden
            
            #line 106 ""
     foreach (var s in Process.Methods.Where(x => !x.Ignore)) { 
            
            #line default
            #line hidden
            
            #line 107 ""
         foreach(var line in RSP.Helper.RenderMethod(s)) { 
            
            #line default
            #line hidden
            
            #line 108 ""
            this.Write("  ");
            
            #line default
            #line hidden
            
            #line 108 ""
            this.Write(this.ToStringHelper.ToStringWithCulture( line ));
            
            #line default
            #line hidden
            
            #line 108 ""
            this.Write("\n");
            
            #line default
            #line hidden
            
            #line 109 ""
         } 
            
            #line default
            #line hidden
            
            #line 110 ""
            this.Write("\n");
            
            #line default
            #line hidden
            
            #line 111 ""
     } 
            
            #line default
            #line hidden
            
            #line 112 ""
 } 
            
            #line default
            #line hidden
            
            #line 113 ""
            this.Write("\n\n  -- User defined signals, procedures and components here\n  -- #### USER-DATA-S" +
                    "IGNALS-START\n  -- #### USER-DATA-SIGNALS-END\n\nbegin\n\n    -- Custom processes go " +
                    "here\n    -- #### USER-DATA-PROCESSES-START\n    -- #### USER-DATA-PROCESSES-END\n\n" +
                    "");
            
            #line default
            #line hidden
            
            #line 125 ""
 if (RSP.IsComponent) { 
            
            #line default
            #line hidden
            
            #line 126 ""
            this.Write("    -- Component instantiation\n");
            
            #line default
            #line hidden
            
            #line 127 ""
            this.Write(this.ToStringHelper.ToStringWithCulture( RSP.ComponentProcesses ));
            
            #line default
            #line hidden
            
            #line 127 ""
            this.Write("\n");
            
            #line default
            #line hidden
            
            #line 128 ""
 } else { 
            
            #line default
            #line hidden
            
            #line 129 ""
            this.Write("\n    process(\n        -- Custom sensitivity signals here\n        -- #### USER-DAT" +
                    "A-SENSITIVITY-START\n        -- #### USER-DATA-SENSITIVITY-END\n        RDY,\n     " +
                    "   ");
            
            #line default
            #line hidden
            
            #line 135 ""
            this.Write(this.ToStringHelper.ToStringWithCulture( Process.IsClocked ? "CLK," : "" ));
            
            #line default
            #line hidden
            
            #line 135 ""
            this.Write("\n        RST\n    )\n");
            
            #line default
            #line hidden
            
            #line 138 ""
         if (RSP.Variables.Count() > 0) { 
            
            #line default
            #line hidden
            
            #line 139 ""
            this.Write("    -- Internal variables\n");
            
            #line default
            #line hidden
            
            #line 140 ""
         } 
            
            #line default
            #line hidden
            
            #line 141 ""
         foreach(var s in RSP.Variables) { 
            
            #line default
            #line hidden
            
            #line 142 ""
            this.Write("    variable ");
            
            #line default
            #line hidden
            
            #line 142 ""
            this.Write(this.ToStringHelper.ToStringWithCulture( s.Name ));
            
            #line default
            #line hidden
            
            #line 142 ""
            this.Write(" : ");
            
            #line default
            #line hidden
            
            #line 142 ""
            this.Write(this.ToStringHelper.ToStringWithCulture( RS.VHDLWrappedTypeName(s) ));
            
            #line default
            #line hidden
            
            #line 142 ""
            this.Write(";\n");
            
            #line default
            #line hidden
            
            #line 143 ""
         } 
            
            #line default
            #line hidden
            
            #line 144 ""
            this.Write(@"
    variable reentry_guard : Std_logic;

    -- #### USER-DATA-NONCLOCKEDVARIABLES-START
    -- #### USER-DATA-NONCLOCKEDVARIABLES-END
	begin
        -- Initialize code here
        -- #### USER-DATA-NONCLOCKEDSHAREDINITIALIZECODE-START
        -- #### USER-DATA-NONCLOCKEDSHAREDINITIALIZECODE-END

        if RST = '1' then
");
            
            #line default
            #line hidden
            
            #line 155 ""
     foreach(var s in RSP.ProcessResetStaments) { 
            
            #line default
            #line hidden
            
            #line 156 ""
            this.Write("            ");
            
            #line default
            #line hidden
            
            #line 156 ""
            this.Write(this.ToStringHelper.ToStringWithCulture( s ));
            
            #line default
            #line hidden
            
            #line 156 ""
            this.Write("\n");
            
            #line default
            #line hidden
            
            #line 157 ""
     } 
            
            #line default
            #line hidden
            
            #line 158 ""
     foreach(var variable in Process.SharedVariables) { 
            
            #line default
            #line hidden
            
            #line 159 ""
            this.Write("            ");
            
            #line default
            #line hidden
            
            #line 159 ""
            this.Write(this.ToStringHelper.ToStringWithCulture( variable.Name ));
            
            #line default
            #line hidden
            
            #line 159 ""
            this.Write(" := ");
            
            #line default
            #line hidden
            
            #line 159 ""
            this.Write(this.ToStringHelper.ToStringWithCulture( variable.Name ));
            
            #line default
            #line hidden
            
            #line 159 ""
            this.Write("_reset_value;\n");
            
            #line default
            #line hidden
            
            #line 160 ""
     } 
            
            #line default
            #line hidden
            
            #line 161 ""
     foreach(var variable in Process.SharedSignals) { 
            
            #line default
            #line hidden
            
            #line 162 ""
            this.Write("            ");
            
            #line default
            #line hidden
            
            #line 162 ""
            this.Write(this.ToStringHelper.ToStringWithCulture( variable.Name ));
            
            #line default
            #line hidden
            
            #line 162 ""
            this.Write(" <= ");
            
            #line default
            #line hidden
            
            #line 162 ""
            this.Write(this.ToStringHelper.ToStringWithCulture( variable.Name ));
            
            #line default
            #line hidden
            
            #line 162 ""
            this.Write("_reset_value;\n");
            
            #line default
            #line hidden
            
            #line 163 ""
     } 
            
            #line default
            #line hidden
            
            #line 164 ""
            this.Write("\n            reentry_guard := \'0\';\n            FIN <= \'0\';\n\n            -- Initia" +
                    "lize code here\n            -- #### USER-DATA-NONCLOCKEDRESETCODE-START\n         " +
                    "   -- #### USER-DATA-NONCLOCKEDRESETCODE-END\n\n        ");
            
            #line default
            #line hidden
            
            #line 172 ""
 if (Process.IsClocked) { 
            
            #line default
            #line hidden
            
            #line 173 ""
            this.Write("\n        --elsif rising_edge(CLK) then\n        elsif RDY /= reentry_guard then\n  " +
                    "      ");
            
            #line default
            #line hidden
            
            #line 176 ""
 } else  { 
            
            #line default
            #line hidden
            
            #line 177 ""
            this.Write("\n        elsif RDY /= reentry_guard then\n        ");
            
            #line default
            #line hidden
            
            #line 179 ""
 } 
            
            #line default
            #line hidden
            
            #line 180 ""
            this.Write("\n\n                reentry_guard := RDY;\n\n                -- Initialize code here\n" +
                    "                -- #### USER-DATA-NONCLOCKEDINITIALIZECODE-START\n               " +
                    " -- #### USER-DATA-NONCLOCKEDINITIALIZECODE-END\n\n\n");
            
            #line default
            #line hidden
            
            #line 189 ""
     foreach(var line in RSP.Helper.RenderMethod(Process.MainMethod)) { 
            
            #line default
            #line hidden
            
            #line 190 ""
            this.Write("                ");
            
            #line default
            #line hidden
            
            #line 190 ""
            this.Write(this.ToStringHelper.ToStringWithCulture( line ));
            
            #line default
            #line hidden
            
            #line 190 ""
            this.Write("\n");
            
            #line default
            #line hidden
            
            #line 191 ""
     } 
            
            #line default
            #line hidden
            
            #line 192 ""
            this.Write("\n                FIN <= RDY;\n\n        end if;\n\n        -- Non-clocked process act" +
                    "ions here\n\n        -- #### USER-DATA-CODE-START\n        -- #### USER-DATA-CODE-E" +
                    "ND\n\n    end process;\n");
            
            #line default
            #line hidden
            
            #line 203 ""
 } 
            
            #line default
            #line hidden
            
            #line 204 ""
            this.Write("\nend RTL;\n\n-- User defined architectures here\n-- #### USER-DATA-ARCH-START\n-- ###" +
                    "# USER-DATA-ARCH-END\n");
            
            #line default
            #line hidden
            return this.GenerationEnvironment.ToString();
        }
        
        public virtual void Initialize() {
        }
    }
    
    public class EntityBase {
        
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
