using gescom.create.Views;
using gescom.data.Models;
using System.Globalization;
using System.Windows.Forms;

namespace gescom.create.Models
{
    public static class ErrorHelpers
    {
        public static void ShowCodeError()
        {
            MessageBox.Show(@"CODE REQUIS.");
        }

        public static void CompleteInfoCustomer(CashModel model)
        {
            var form = new CustomerAdress(model);
            form.ShowDialog();
        }

        public static void ShowDepassError(float quantite, float qstock, string name)
        {
            string msgError = name + "\n" + qstock.ToString(CultureInfo.InvariantCulture) + @" DISPONIBLE" + "\n\n" +
                              quantite +
                              @" SAISIE" + "\n\n";
            MessageBox.Show(null, msgError, @"DONNEE INVALIDE", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static void ShowDepassError(float quantite, float qstock, float qteSaved, string name)
        {
            string msgError = qstock.ToString(CultureInfo.InvariantCulture) + @" DISPONIBLE" + "\n\n" + quantite +
                              @" SAISIE" + "\n\n" + qteSaved.ToString(CultureInfo.InvariantCulture) + @" ACUELLE.";
            MessageBox.Show(null, msgError, name, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static void ShowDepassError(string txtNew, string txtReal, string txtSend, string name)
        {
            string msgError = txtReal + @" DISPONIBLE" + "\n\n" + txtNew + @" SAISIE" + "\n\n";
            if (txtSend != null)
            {
                msgError += txtSend + @" ACTUELLE.";
            }
            MessageBox.Show(null, msgError, name, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static void ShowError(string msgError)
        {
            MessageBox.Show(null, msgError, @"ERREUR", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static void ShowErrorDuplicate()
        {
            MessageBox.Show(@"CODE ET/OU NOM DUPLIQUE(S).");
        }

        public static void ShowNameError()
        {
            MessageBox.Show(@"NOM REQUIS.");
        }

        public static void SignalEmptyList()
        {
            MessageBox.Show(@"AUCUNE INFORMATION A AFFICHER", @"LISTE VIDE", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }
    }
}