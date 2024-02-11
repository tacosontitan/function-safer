using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Diagnostics;

namespace Function_Safer_v2 {
    partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
            menuStrip1.Renderer = new MenuRenderer();
        }

        private List<Function> Functions = new List<Function>();
        private Languages.CurrentLanguage CurrentLanguage = new Languages.CurrentLanguage(Languages.Language.English);

        private void ApplicationStart(object sender, EventArgs e) { languageModifier.Start(); }
        private void SubmitFunction(object sender, EventArgs e) {
            Functions.Add(new Function(functionNameBox.Text, new HexAddress(functionTopBox.Text), new HexAddress(jrRa8Box.Text),
                          functionList));
            numberOfFunctionsLabel.Text = String.Format(CurrentLanguage.NumberOfFunctionsToBeCopied + ": {0}", Functions.Count);
        }

        private void SubmitCode(object sender, EventArgs e) {
            try {
                Functions[functionList.SelectedIndex].AddCode(new HexAddress(codeAddressBox.Text));

                codeList.Items.Clear();

                for (int i = 0; i < Functions[functionList.SelectedIndex].Codes.Count; i++)
                    codeList.Items.Add(Functions[functionList.SelectedIndex].Codes[i].Address);

                codesInFunctionLabel.Text = String.Format(CurrentLanguage.CodesInSelectedFunction + ": {0}",
                                          Functions[functionList.SelectedIndex].Codes.Count);
            }
            catch (Exception ex) { MessageBox.Show("Could not add code because there is no function selected to add it to."); }
        }

        private void CopyAndView(object sender, EventArgs e) {
            CopyManager Manager = new CopyManager(Functions);
            Manager.Copy();

            resultBox.Text = Manager.Result;

            for (int i = 0; i < Functions.Count; i++)
                Functions[i].Codes.Clear();

            Functions.Clear();
            functionList.Items.Clear();
            codeList.Items.Clear();

            functionTopLabel.Text = CurrentLanguage.FunctionTop + ": 00000000";
            jrRa8Label.Text = "Jr Ra + 8: 00000000";
            sizeLabel.Text = CurrentLanguage.Bytes + ": 0";

            functionNameBox.Text = "";
            functionTopBox.Text = "";
            jrRa8Box.Text = "";
            codeAddressBox.Text = "";

            numberOfFunctionsLabel.Text = CurrentLanguage.NumberOfFunctionsToBeCopied + ": 0";
            codesInFunctionLabel.Text = CurrentLanguage.CodesInSelectedFunction + ": 0";
            codeDistanceLabel.Text = CurrentLanguage.CodeDistance + ": 0 Bytes";
        }

        private void ViewFunction(object sender, EventArgs e) {
            try {
                submitCodeButton.Text = String.Format(CurrentLanguage.SubmitCodeTo + " F({0})", functionList.SelectedIndex + 1);
                functionTopLabel.Text = CurrentLanguage.FunctionTop + ": " + Functions[functionList.SelectedIndex].TopAddress.ToString();
                jrRa8Label.Text = "Jr Ra + 8: " + Functions[functionList.SelectedIndex].JrRaPlus8.ToString();
                sizeLabel.Text = CurrentLanguage.Bytes + ": " + Functions[functionList.SelectedIndex].Bytes;
                codesInFunctionLabel.Text = String.Format(CurrentLanguage.CodesInSelectedFunction + ": {0}",
                                                          Functions[functionList.SelectedIndex].Codes.Count);

                codeList.Items.Clear();

                for (int i = 0; i < Functions[functionList.SelectedIndex].Codes.Count; i++)
                    codeList.Items.Add(Functions[functionList.SelectedIndex].Codes[i].Address);
            }

            catch {
                MessageBox.Show("We're terribly sorry, but something went wrong. Please check to make sure you have a function selected.");
            }
        }

        private void VisitUs(object sender, EventArgs e) {
            Process.Start("http://www.studio41games.tk");
        }

        private void ShowThanks(object sender, FormClosingEventArgs e) {
            MessageBox.Show("Thank you for using Studio 41 Games products. We hope to see you again soon!", "Thank You!");
        }

        private void UpdateCodeInfo(object sender, EventArgs e) {
            try {
                codeDistanceLabel.Text = String.Format(CurrentLanguage.CodeDistance + ": {0} Bytes",
                    Functions[functionList.SelectedIndex].Codes[codeList.SelectedIndex].BytesFromTop(
                                Functions[functionList.SelectedIndex].TopAddress));
            }

            catch (Exception ex) {
                MessageBox.Show("We're terribly sorry, but something went wrong. Please check to make sure you have a code selected.");
            }
        }

        private void SwitchToEnglish(object sender, EventArgs e) {
            CurrentLanguage = new Languages.CurrentLanguage(Languages.Language.English);
        }

        private void SwitchToPolish(object sender, EventArgs e) {
            CurrentLanguage = new Languages.CurrentLanguage(Languages.Language.Polish);
        }

        private void UpdateLanguages(object sender, EventArgs e) {
            functionNameLabel.Text = CurrentLanguage.FunctionName + ":";
            functionTopLabel2.Text = CurrentLanguage.FunctionTop + ":";
            codeAddressLabel.Text = CurrentLanguage.CodeAddress + ":";
            resultLabel.Text = CurrentLanguage.Results;
            codesLabel.Text = CurrentLanguage.Codes;
            submitFunctionButton.Text = CurrentLanguage.SubmitFunction;
            copyViewButton.Text = CurrentLanguage.CopyAndView;
            functionInfoContainer.Text = CurrentLanguage.FunctionView;
        }
    }
}