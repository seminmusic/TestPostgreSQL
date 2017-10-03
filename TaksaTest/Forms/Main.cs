using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Windows.Forms;
using TaksaTest.Database;
using TaksaTest.Helpers;

namespace TaksaTest.Forms
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void btnInsertTestData_Click(object sender, System.EventArgs e)
        {
            int broj;
            if (Int32.TryParse(txtBrojRecorda.Text, out broj))
            {
                Stopwatch satGetData = new Stopwatch();
                Stopwatch satInsertData = new Stopwatch();

                try
                {
                    satGetData.Start();
                    IEnumerable<Korisnik> randomData = _Data.GenerateRandomData(broj);
                    satGetData.Stop();

                    satInsertData.Start();
                    _Data.InsertTestData(randomData);
                    satInsertData.Stop();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    lblGetData.Text = "Generisanje podataka: " + satGetData.Elapsed;
                    lblInsertData.Text = "Insert podataka: " + satInsertData.Elapsed;
                    lblZavrseno.Text = "Završeno!";
                }
            }
            else
            {
                MessageBox.Show("Unesite validan broj.", "Pogrešan unos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtBrojRecorda.Focus();
            }
        }
    }
}
