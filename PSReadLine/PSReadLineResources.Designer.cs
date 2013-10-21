﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34003
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PSConsoleUtilities {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class PSReadLineResources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal PSReadLineResources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("PSReadLine.PSReadLineResources", typeof(PSReadLineResources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Accept the input or move to the next line if input is missing a closing token..
        /// </summary>
        internal static string AcceptLineDescription {
            get {
                return ResourceManager.GetString("AcceptLineDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Move the cursor to the next line without attempting to execute the input.
        /// </summary>
        internal static string AddLineDescription {
            get {
                return ResourceManager.GetString("AddLineDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Move the cursor back one character.
        /// </summary>
        internal static string BackwardCharDescription {
            get {
                return ResourceManager.GetString("BackwardCharDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Delete the charcter before the cursor.
        /// </summary>
        internal static string BackwardDeleteCharDescription {
            get {
                return ResourceManager.GetString("BackwardDeleteCharDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Delete text from the cursor to the start of the line.
        /// </summary>
        internal static string BackwardDeleteLineDescription {
            get {
                return ResourceManager.GetString("BackwardDeleteLineDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Move the text from the cursor to the beginning of the line to the kill ring.
        /// </summary>
        internal static string BackwardKillLineDescription {
            get {
                return ResourceManager.GetString("BackwardKillLineDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Move the cursor to the beginning of the current or previous token or start of the line.
        /// </summary>
        internal static string BackwordWordDescription {
            get {
                return ResourceManager.GetString("BackwordWordDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Move to the first item in the history.
        /// </summary>
        internal static string BeginningOfHistoryDescription {
            get {
                return ResourceManager.GetString("BeginningOfHistoryDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Move the cursor to the beginning of the line.
        /// </summary>
        internal static string BeginningOfLineDescription {
            get {
                return ResourceManager.GetString("BeginningOfLineDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Abort editing the current line and re-evaluate the prompt.
        /// </summary>
        internal static string CancelLineDescription {
            get {
                return ResourceManager.GetString("CancelLineDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Remove all items from the kill ring.
        /// </summary>
        internal static string ClearKillRingDescription {
            get {
                return ResourceManager.GetString("ClearKillRingDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Remove all items from the command line history (not PowerShell history).
        /// </summary>
        internal static string ClearyHistoryDescription {
            get {
                return ResourceManager.GetString("ClearyHistoryDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Complete the input if there is a single completion, otherwise complete the input with common prefix for all completions.  Show possible completions if pressed a second time..
        /// </summary>
        internal static string CompleteDescription {
            get {
                return ResourceManager.GetString("CompleteDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Delete the character under the cusor.
        /// </summary>
        internal static string DeleteCharDescription {
            get {
                return ResourceManager.GetString("DeleteCharDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Display all {0} possibilities? (y or n).
        /// </summary>
        internal static string DisplayAllPossibilities {
            get {
                return ResourceManager.GetString("DisplayAllPossibilities", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Move the cursor to the beginning of the current or previous token or start of the line.
        /// </summary>
        internal static string EmacsBackwardWordDescription {
            get {
                return ResourceManager.GetString("EmacsBackwardWordDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to String is not used in the UI.
        /// </summary>
        internal static string EmacsCtrlXDescription {
            get {
                return ResourceManager.GetString("EmacsCtrlXDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Move the cursor to the end of the current or next token.
        /// </summary>
        internal static string EmacsForwardWordDescription {
            get {
                return ResourceManager.GetString("EmacsForwardWordDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to String is not used in the UI.
        /// </summary>
        internal static string EmacsMetaDescription {
            get {
                return ResourceManager.GetString("EmacsMetaDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Move to the last item (the current input) in the history.
        /// </summary>
        internal static string EndOfHistoryDescription {
            get {
                return ResourceManager.GetString("EndOfHistoryDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Move the cursor to the end of the line.
        /// </summary>
        internal static string EndOfLineDescription {
            get {
                return ResourceManager.GetString("EndOfLineDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Mark the location of the cursor and move the cursor to the position of the previous mark.
        /// </summary>
        internal static string ExchangePointAndMarkDescription {
            get {
                return ResourceManager.GetString("ExchangePointAndMarkDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Move the cursor forward one character.
        /// </summary>
        internal static string ForwardCharDescription {
            get {
                return ResourceManager.GetString("ForwardCharDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Delete text from the cursor to the end of the line.
        /// </summary>
        internal static string ForwardDeleteLineDescription {
            get {
                return ResourceManager.GetString("ForwardDeleteLineDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Move the cursor to the beginning of the next token or end of line.
        /// </summary>
        internal static string ForwardWordDescription {
            get {
                return ResourceManager.GetString("ForwardWordDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Go to matching brace.
        /// </summary>
        internal static string GotoBraceDescription {
            get {
                return ResourceManager.GetString("GotoBraceDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Search for the previous item in the history that starts with the current input - like PreviousHistory if the input is empty.
        /// </summary>
        internal static string HistorySearchBackwardsDescription {
            get {
                return ResourceManager.GetString("HistorySearchBackwardsDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Search for the next item in the history that starts with the current input - like NextHistory if the input is empty.
        /// </summary>
        internal static string HistorySearchForwardsDescription {
            get {
                return ResourceManager.GetString("HistorySearchForwardsDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to String is not used in the UI.
        /// </summary>
        internal static string IgnoreDescription {
            get {
                return ResourceManager.GetString("IgnoreDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Move the text from the cursor to the start of the current or previous token to the kill ring.
        /// </summary>
        internal static string KillBackwardWordDescription {
            get {
                return ResourceManager.GetString("KillBackwardWordDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Move the text from the cursor to the end of the input to the kill ring.
        /// </summary>
        internal static string KillLineDescription {
            get {
                return ResourceManager.GetString("KillLineDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Move the text from the cursor to the end of the current or next token to the kill ring.
        /// </summary>
        internal static string KillWordDescription {
            get {
                return ResourceManager.GetString("KillWordDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Replace the input with the next item in the history.
        /// </summary>
        internal static string NextHistoryDescription {
            get {
                return ResourceManager.GetString("NextHistoryDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Paste text from the system clipboard.
        /// </summary>
        internal static string PasteDescription {
            get {
                return ResourceManager.GetString("PasteDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Display the possible completions without changing the input.
        /// </summary>
        internal static string PossibleCompletionsDescription {
            get {
                return ResourceManager.GetString("PossibleCompletionsDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Replace the input with the previous item in the history.
        /// </summary>
        internal static string PreviousHistoryDescription {
            get {
                return ResourceManager.GetString("PreviousHistoryDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Redo an undo.
        /// </summary>
        internal static string RedoDescription {
            get {
                return ResourceManager.GetString("RedoDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to length is too big.
        /// </summary>
        internal static string ReplacementLengthTooBig {
            get {
                return ResourceManager.GetString("ReplacementLengthTooBig", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Equivalent to undo all edits (clears the line except lines imported from history).
        /// </summary>
        internal static string RevertLineDescription {
            get {
                return ResourceManager.GetString("RevertLineDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Mark the location of the cursor.
        /// </summary>
        internal static string SetMarkDescription {
            get {
                return ResourceManager.GetString("SetMarkDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &apos;start&apos; cannot be less than zero or greater than the length of the buffer.
        /// </summary>
        internal static string StartOutOfRange {
            get {
                return ResourceManager.GetString("StartOutOfRange", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Complete the input using the next completion.
        /// </summary>
        internal static string TabCompleteNextDescription {
            get {
                return ResourceManager.GetString("TabCompleteNextDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Complete the input using the previous completion.
        /// </summary>
        internal static string TabCompletePreviousDescription {
            get {
                return ResourceManager.GetString("TabCompletePreviousDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Undo a previous edit.
        /// </summary>
        internal static string UndoDescription {
            get {
                return ResourceManager.GetString("UndoDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Copy the text from the current kill ring position to the input.
        /// </summary>
        internal static string YankDescription {
            get {
                return ResourceManager.GetString("YankDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Replace the previously yanked text with the text from the next kill ring position.
        /// </summary>
        internal static string YankPopDescription {
            get {
                return ResourceManager.GetString("YankPopDescription", resourceCulture);
            }
        }
    }
}
