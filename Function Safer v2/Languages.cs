using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Function_Safer_v2 {
    class Languages {
        public enum Language { English, Polish }
        
        public class CurrentLanguage {
            private Language Mode = Language.English;
            public CurrentLanguage(Language Mode) { this.Mode = Mode; }

            public string FunctionName {
                get {
                    if (Mode == Language.Polish)
                        return "nazwa funkcji";

                    return "function name";
                }
            }

            public string FunctionTop {
                get {
                    if (Mode == Language.Polish)
                        return "top funkcji";

                    return "function top";
                }
            }

            public string CodeAddress {
                get {
                    if (Mode == Language.Polish)
                        return "adres kod";

                    return "code address";
                }
            }

            public string SubmitFunction {
                get {
                    if (Mode == Language.Polish)
                        return "przedstawić funkcję";

                    return "submit function";
                }
            }

            public string SubmitCodeTo {
                get {
                    if (Mode == Language.Polish)
                        return "złożyć kod";

                    return "submit code to";
                }
            }

            public string CopyAndView {
                get {
                    if (Mode == Language.Polish)
                        return "skopiować i zobaczyć";

                    return "copy and view";
                }
            }

            public string NumberOfFunctionsToBeCopied {
                get {
                    if (Mode == Language.Polish)
                        return "liczba funkcji do skopiowania";

                    return "number of functions to be copied";
                }
            }

            public string CodesInSelectedFunction {
                get {
                    if (Mode == Language.Polish)
                        return "kody w wybranej funkcji";

                    return "codes in selected function";
                }
            }

            public string Size {
                get {
                    if (Mode == Language.Polish)
                        return "rozmiar";

                    return "size";
                }
            }

            public string Bytes {
                get {
                    if (Mode == Language.Polish)
                        return "bajtów";

                    return "bytes";
                }
            }

            public string CodeDistance {
                get {
                    if (Mode == Language.Polish)
                        return "odległość kod";

                    return "code distance";
                }
            }

            public string FunctionView {
                get {
                    if (Mode == Language.Polish)
                        return "widok funkcja";

                    return "function view";
                }
            }

            public string Codes {
                get {
                    if (Mode == Language.Polish)
                        return "kody";

                    return "codes";
                }
            }

            public string Results {
                get {
                    if (Mode == Language.Polish)
                        return "wyniki";

                    return "results";
                }
            }
        }
    }
}