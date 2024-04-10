using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CYK
{
    public partial class Form1 : Form
    {
        /// <summary>
        /// Grammar Rules
        /// </summary>
        Dictionary<string, HashSet<string>> Rules = new Dictionary<string, HashSet<string>>();
        
        /// <summary>
        /// The final CYK table
        /// </summary>
        Dictionary<string, HashSet<string>> CYKTable = new Dictionary<string, HashSet<String>>();
        
        /// <summary>
        /// The intial grammar rule.
        /// </summary>
        string Axiome = "";

        /// <summary>
        /// To contain all MTC possibilities.
        /// </summary>
        List<List<List<string>>> MTCPossibilities = new List<List<List<string>>>();

        public Form1()
        {
            InitializeComponent();
            lblResult.Text = "";

            pnlMain.Dock = pnlDetails.Dock = DockStyle.Fill;

            lblTokenizationResult.Text = "\u274C";


            //grdCYKTable.Columns.Add("clm1", "");
            //grdCYKTable.Rows.Add(new DataGridViewRow());
            //grdCYKTable.Rows[0].Cells[0].Value = "AF";
        }

        /// <summary>
        /// Displays the grammar rules for the user.
        /// </summary>
        void displayGrammar()
        {
            int y = 10;
            foreach(var rule in Rules)
            {
                Label lbl = new Label();
                lbl.AutoSize = true;
                lbl.Location = new Point(10, y);
                lbl.Name = "lbl" + rule.Key;
                lbl.TabIndex = 0;
                lbl.Text = rule.Key + " \u2192 " + getValuesToDisplay(rule.Value);
                splitContainer1.Panel2.Controls.Add(lbl);
                y += (5 + lbl.Height);
            }
        }

        /// <summary>
        /// Takes a HashSet and returns a string of its values seperated by ' | '.
        /// </summary>
        /// <param name="values">The set of values</param>
        /// <returns></returns>
        string getValuesToDisplay(HashSet<string> values)
        {
            string result = "";
            foreach(string value in values)
                result += value + " | ";
            return result.TrimEnd(' ', '|');
        }

        bool isValid(string sentense)
        {
            if (String.IsNullOrEmpty(sentense))
                return false;

            List<string> tokens = getTokents(sentense);

            lblTokenizationResult.Visible = true;

            if (tokens == null)
            {
                lblTokenizationResult.Text = "FAILED \u274C";
                lblTokenizationResult.ForeColor = Color.Red;
                return false;
            }

            cboTokens.Items.AddRange(tokens.ToArray());
            lblTokenizationResult.Text = "SUCCESS \u2713";
            lblTokenizationResult.ForeColor = Color.Green;

            bool CYKSuccessfull = ApplyCYK(tokens);

            if (CYKSuccessfull)
            {
                lblCYKAlgorithmResult.Text = "SUCCESS \u2713";
                lblCYKAlgorithmResult.ForeColor = Color.Green;
            }
            else
            {
                lblCYKAlgorithmResult.Text = "FAILED \u274C";
                lblCYKAlgorithmResult.ForeColor = Color.Red;
            }

            lblCYKAlgorithmResult.Visible = true;

            return CYKSuccessfull;
        }

        /// <summary>
        /// Applies the CYK algorithm.
        /// </summary>
        /// <param name="tokens">Tokents to apply the algorithm on</param>
        /// <returns></returns>
        bool ApplyCYK(List<string> tokens)
        {
            for (int i = 1; i <= tokens.Count; ++i)
                grdCYKTable.Columns.Add($"clm{i}", "");
            grdCYKTable.Rows.Add(tokens.Count + 1);
            for (int i = 0; i < tokens.Count; ++i)
                grdCYKTable.Rows[tokens.Count].Cells[i].Value = tokens[i].ToString();

            CYKTable = new Dictionary<string, HashSet<String>>();
            for (int level = 1; level <= tokens.Count; ++level)
            {
                if(level == 1)
                {
                    int grdIndex = 0;
                    foreach (string token in tokens)
                    {
                        string _CYKValue = "";
                        HashSet<string> nonTerminals = new HashSet<string>();
                        if (CYKTable.ContainsKey(token))
                        {
                            foreach (string value in CYKTable[token])
                                _CYKValue += value + ", ";

                            if (!String.IsNullOrEmpty(_CYKValue.TrimEnd(',', ' ')))
                                _CYKValue = "{" + _CYKValue.TrimEnd(',', ' ') + "}";
                            else _CYKValue = "-";

                            grdCYKTable.Rows[tokens.Count - 1].Cells[grdIndex++].Value = _CYKValue;
                            continue;
                        }
                        foreach (var rule in Rules)
                            foreach (string value in rule.Value)
                                if (value == token)
                                {
                                    nonTerminals.Add(rule.Key);
                                    _CYKValue += rule.Key + ", ";
                                }

                        if (!String.IsNullOrEmpty(_CYKValue.TrimEnd(',', ' ')))
                            _CYKValue = "{" + _CYKValue.TrimEnd(',', ' ') + "}";
                        else _CYKValue = "-";

                        CYKTable.Add(token, nonTerminals);
                        grdCYKTable.Rows[tokens.Count - 1].Cells[grdIndex++].Value = _CYKValue;
                    }
                }
                else
                {
                    for(int iteration = 1; iteration <= (tokens.Count + 1) - level; ++iteration)
                    { // Iterates through every CYK-Cell in the current CYK-row of the CYK-table.
                        List<string> subTokens = new List<string>();
                        string subTokensKey = "";
                        for (int count = iteration - 1; count < level + (iteration - 1); ++count) {
                            subTokens.Add(tokens[count]);
                            subTokensKey += tokens[count];
                        }

                        // Apply MTC algorithm
                        MTCPossibilities.Clear();
                        MTC = false;
                        seperateFirstToken(new List<List<string>>(), subTokens);
                        HashSet<string> CYKValue = GetCYKValues();
                        if(!CYKTable.ContainsKey(subTokensKey))
                            CYKTable.Add(subTokensKey, CYKValue);

                        string _CYKValue = "";
                        foreach (string value in CYKValue)
                            _CYKValue += value + ", ";

                        if (!String.IsNullOrEmpty(_CYKValue.TrimEnd(',', ' ')))
                            _CYKValue = "{" + _CYKValue.TrimEnd(',', ' ') + "}";
                        else _CYKValue = "-";

                        grdCYKTable.Rows[tokens.Count - level].Cells[iteration - 1].Value = _CYKValue;

                        if (level == tokens.Count)
                        {
                            foreach(string item in CYKValue)
                            {
                                if(item == Axiome)
                                    return true;
                            }
                            return false;
                        }
                    }
                }
            }
            return false;
        }

        bool MTC = false;

        /// <summary>
        /// Takes 2 lists of tokents and seperates the first token in the list of last tokens
        /// </summary>
        /// <param name="first">A list of tokens before seperation</param>
        /// <param name="last">A list of tokens after seperation</param>
        void seperateFirstToken(List<List<string>> first, List<string> last)
        {
            List<List<string>> newFirst = first.GetRange(0, first.Count);
            List<string> newLast = last.GetRange(0, last.Count);
            for (int i = 1; i < last.Count; ++i)
            {
                if (MTC) // Then move the comma
                {
                    newFirst[newFirst.Count - 1].Add(newLast[0]);
                    newLast.RemoveAt(0);
                }
                else // Then add a comma
                {
                    newFirst.Add(new List<string>() { newLast[0] });
                    newLast.RemoveAt(0);
                }

                List<List<string>> possibility = new List<List<string>>();

                foreach (List<string> tokensFirst in newFirst)
                    possibility.Add(tokensFirst.GetRange(0, tokensFirst.Count));
                possibility.Add(newLast.GetRange(0, newLast.Count));

                MTCPossibilities.Add(possibility);

                if (newLast.Count > 1)
                {
                    MTC = false;
                    seperateFirstToken(newFirst, newLast);
                }
                else MTC = true;
            }
        }

        HashSet<string> GetCYKValues()
        {
            HashSet<string> CYKValue = new HashSet<string>();
            foreach(List<List<string>> possibility in MTCPossibilities)
            {
                List<HashSet<string>> toProtuct = new List<HashSet<string>>();
                foreach(List<string> tokens in possibility)
                {
                    string strTokens = "";
                    foreach(string token in tokens)
                        strTokens += token;
                    HashSet<string> oldCYKValue = CYKTable[strTokens];
                    toProtuct.Add(oldCYKValue);
                }

                // Product:
                HashSet<string> results = new HashSet<string>();

                HashSet<string> firstSet = toProtuct[0];
                
                if(toProtuct.Count == 1)
                {
                    string result = "";
                    foreach (string item in firstSet)
                        result += item;
                    results.Add(result);
                }
                else
                    for (int i = 1; i < toProtuct.Count; ++i)
                    {
                        results.Clear();
                        string result = "";
                        foreach (string item1 in firstSet) // Sub
                        {
                            foreach(string item2 in toProtuct[i]) // Del
                            {
                                result += (item1 + " " + item2).Trim(); // Sub Del
                                results.Add(result);
                            }
                        }

                        firstSet = results.ToHashSet();
                    }

                // Find the results in the grammar rules.
                HashSet<string> grammarValue = FindInGrammar(results);
                CYKValue.UnionWith(grammarValue);
            }

            // Remove unnecessary empty string:
            if(CYKValue.Count > 1)
                CYKValue.Remove("");

            return CYKValue;
        }

        HashSet<string> FindInGrammar(HashSet<string> results)
        {
            HashSet<string> keys = new HashSet<string>();
            foreach(string result in results)
                foreach(KeyValuePair<string, HashSet<string>> rule in Rules)
                    foreach(string grammarValue in rule.Value)
                        if(result == grammarValue)
                            keys.Add(rule.Key);
            if (keys.Count == 0)
                keys.Add(""); // Equivelant to dash.

            return keys;
        }

        /// <summary>
        /// Takes a string as input and return its tokens according to the given grammars.
        /// </summary>
        /// <param name="sentence">String of input to be tokenized</param>
        /// <returns></returns>
        List<string> getTokents(string sentence)
        {
            List<string> tokens = new List<string>();
            string subString = sentence;
            bool finished = false;
            int i = 1;
            while (!finished) {
                for (; i <= subString.Length; i++)
                {
                    bool tokenFound = false;
                    string potenToken = subString.Substring(0, i);
                    foreach(var rule in Rules)
                        foreach(string value in rule.Value)
                            if(potenToken == value)
                            {
                                tokenFound = true;
                                tokens.Add(potenToken);
                            }

                    if (tokenFound)
                    {
                        subString = subString.Substring(i);
                        if(subString.Length == 0)
                            finished = true;
                        i = 1;
                        break;
                    }
                    else if (i == subString.Length)
                    {
                        if (tokens.Count == 0)
                            return null;
                        string last = tokens[tokens.Count - 1];
                        tokens.RemoveAt(tokens.Count - 1);
                        subString = last + subString;
                        i = last.Length + 1;
                        break;
                    }
                }
            }
           return tokens.Count == 0 ? null : tokens;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string nonTerminal = txtNonTerminal.Text;
            string value = txtValue.Text;
            bool isAxiome = chkIsAxiome.Checked;

            /* Input Validation: */
            if (String.IsNullOrEmpty(nonTerminal) || String.IsNullOrEmpty(value))
            {
                MessageBox.Show("All inputs are required.", "Tip");
                return;
            }

            /* Save Grammar */
            if (isAxiome)
            {
                chkIsAxiome.Checked = false;
                if (!String.IsNullOrWhiteSpace(Axiome))
                {
                    if (Axiome != nonTerminal)
                    {
                        if (MessageBox.Show("You already defined as axiome. Are you sure you want to override it?", "Warning.", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        {
                            Axiome = nonTerminal;
                        }
                    }
                }
            }
            if (String.IsNullOrEmpty(Axiome))
                Axiome = nonTerminal;
            if (Rules.ContainsKey(nonTerminal))
            {
                Rules[nonTerminal].Add(value);
            }
            else
            {
                Rules.Add(nonTerminal, new HashSet<string>() { value });
            }

            /* Display Grammar */
            displayGrammar();

            /* Clear Input */
            txtValue.Clear();

            grpInput.Visible = true;
        }

        private void btnValidate_Click(object sender, EventArgs e)
        {
            cboTokens.Items.Clear();
            lblCYKAlgorithmResult.Visible = lblTokenizationResult.Visible = false;
            grdCYKTable.Rows.Clear();
            grdCYKTable.Columns.Clear();

            if (isValid(txtSentense.Text))
            {
                lblResult.Text = "Acepted";
                lblResult.ForeColor = Color.Green;
            }
            else
            {
                lblResult.Text = "Rejected";
                lblResult.ForeColor = Color.Red;
            }
            detailsToolStripMenuItem.Enabled = true;
        }

        private void txtSentense_TextChanged(object sender, EventArgs e)
        {
            lblResult.Text = "";
        }

        private void mainToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnlMain.Visible = true;
            pnlDetails.Visible = false;
        }

        private void detailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnlDetails.Visible = true;
            pnlMain.Visible = false;
        }
    }
}