using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FineTuningBuilder
{
    public partial class frm_Principal : Form
    {
        public frm_Principal()
        {
            InitializeComponent();
        }

        private void btn_Montar_Click(object sender, EventArgs e)
        {
            var entradaPrompt = MontaPrompt(txt_Prompt.Text);
            var entradaCompletion = MontaCompletion(txt_Completion.Text);
            var fineTuning = MontaFineTuning(entradaPrompt, entradaCompletion);
            txt_FineTuning.Text += fineTuning + "\r\n";
        }
        string MontaPrompt(string texto)
        {
            texto = TrataQuebraLinhaEAspas(texto);
            return "\"prompt\": \"" + texto + "\"";
        }
        string MontaCompletion(string texto)
        {
            texto = TrataQuebraLinhaEAspas(texto);
            return "\"completion\": \"" + texto + "stop!\"";
        }
        string MontaFineTuning(string prompt, string completion)
        {
            return "{" + prompt + "," + completion + "}";
        }
        string TrataQuebraLinhaEAspas(string texto)
        {
            texto = texto.Replace("\r\n", "\\r\\n");
            texto = texto.Replace("\"", "\\\"");
            return texto;
        }
    }
}
