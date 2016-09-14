/*UserInterface.cs
 * Author:  Ying Chen
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Ksu.Cis300.MatrixMultiplier
{
    /// <summary>
    /// A GUI for a program that retrieves information about last names in
    /// a sample of US data.
    /// </summary>
    public partial class UserInterface : Form
    {
        /// <summary>
        /// Constructs a new GUI.
        /// </summary>
        public UserInterface()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Build row vectors for a given matrix.
        /// </summary>
        /// <param name="name">The name of the file containing the matrix.</param>
        /// <param name="s">The row number of the matrix.</param>
        /// <param name="p">The column number of the matrix.</param>
        /// <returns></returns>
        private KeyValuePair<int, Vector>[] BuildRowVector(string name, out int s, out int p)
        {
            using (StreamReader matrixA = new StreamReader(name))
            {
                string s1 = matrixA.ReadLine().Trim();
                string[] sa = s1.Split(',');
               
                 p = Convert.ToInt32(sa[1]);
                 s = Convert.ToInt32(sa[0]);
               
                KeyValuePair<int, Vector>[] ma = new KeyValuePair<int, Vector>[p];
                for (int n = 0; n < p; n++ )
                {
                    Vector r = new Vector();
                    while (!matrixA.EndOfStream)
                    {
                        string str1 = matrixA.ReadLine().Trim();
                        string[] t1 = str1.Split(',');
                        int e0 = Convert.ToInt32(t1[0]);
                        int e1 = Convert.ToInt32(t1[1]);
                        double e2 = Convert.ToDouble(t1[2]);
                        
                            if (e0 >= s || e1 >= p)
                            {
                                throw new Exception();
                               
                            }
                         if (n == Convert.ToInt32(t1[0]))
                            {
                                ma[n] = BuildElement(r, n, e1, e2);
                            }
                    }
                         matrixA.DiscardBufferedData();
                         matrixA.BaseStream.Seek(0, SeekOrigin.Begin); 
                         matrixA.ReadLine();
                  }
                 return ma;  
                    
               }
            }     
 
        /// <summary>
        /// Build element for a vector. 
        /// </summary>
        /// <param name="r"></param>
        /// <param name="n"></param>
        /// <param name="e1"></param>
        /// <param name="e2"></param>
        /// <returns></returns>
        private KeyValuePair<int, Vector> BuildElement(Vector r, int n, int e1, double e2)
        {
            r.SetValue(e1, e2);
            KeyValuePair<int, Vector> k = new KeyValuePair<int, Vector>(n, r);
            return k;
        }

       private KeyValuePair<int, Vector>[] BuildColumnVector(string name, out int p)
        {
            using (StreamReader matrixB = new StreamReader(name))
            {
                string s2 = matrixB.ReadLine().Trim();
                string[] sb = s2.Split(',');
                p = Convert.ToInt32(sb[0]);
                int d = Convert.ToInt32(sb[1]);

                KeyValuePair<int, Vector>[] mb = new KeyValuePair<int, Vector>[d];
                for (int i = 0; i < d; i++)
                {
                    Vector r = new Vector();
                    while (!matrixB.EndOfStream)
                    {
                        string str1 = matrixB.ReadLine().Trim();
                        string[] t1 = str1.Split(',');
                        int e1 = Convert.ToInt32(t1[0]);
                        double e2 = Convert.ToDouble(t1[2]);
                        
                        if (i == Convert.ToInt32(t1[1]))
                        {
                            mb[i] = BuildElement(r, i, e1, e2);
                        }

                    }
                    matrixB.DiscardBufferedData();
                    matrixB.BaseStream.Seek(0, SeekOrigin.Begin);
                    matrixB.ReadLine();
                }
                return mb;
            }
      }
   

        /// <summary>
        /// Do product of matrix a and b.
        /// </summary>
        /// <param name="ma"></param>
        /// <param name="s"></param>
        /// <param name="mb"></param>
        /// <param name="p"></param>
       private void Product(KeyValuePair<int, Vector>[] ma, int s, KeyValuePair<int, Vector>[] mb, int p)
        {
            try
            {
                using (StreamWriter output = new StreamWriter(uxSaveDialog.FileName))
                {
                    int a = ma.Length;
                    int b = mb.Length;
                    output.WriteLine(a.ToString() + "," + b.ToString());

                        for (int i = 0; i < ma.Length; i++)
                        {
                            for (int j = 0; j < mb.Length; j++)
                            {
                                double t = Vector.DotProduct(ma[i].Value, mb[j].Value);
                                if (t != 0)
                                {
                                    output.WriteLine(i.ToString() + "," + j.ToString() + "," + t.ToString());
                                }

                            }

                        }
               
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
    }



        /// <summary>
        /// Handles the event when MatrixA button is clicked.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

       private void uxMatrixA_Click(object sender, EventArgs e)
        {
          
            if (uxOpenDialogA.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    uxTextBoxA.Text = uxOpenDialogA.FileName.ToString();
                  
                    if (uxTextBoxA.Text != "" && uxTextBoxB.Text != "" && uxTextBoxOutput.Text != "")
                    {
                        uxSaveMatrix.Enabled = true;
                    }
                    else
                    {
                        uxSaveMatrix.Enabled = false;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        /// <summary>
        /// Handles the event when MatrixB button is clicked.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
       private void uxMatrixB_Click(object sender, EventArgs e)
        {
            if (uxOpenDialogB.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    uxTextBoxB.Text = uxOpenDialogB.FileName.ToString();
                    if (uxTextBoxA.Text != "" && uxTextBoxB.Text != "" && uxTextBoxOutput.Text != "")
                    {
                        uxSaveMatrix.Enabled = true;
                    }
                    else
                    {
                        uxSaveMatrix.Enabled = false;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        /// <summary>
        /// Handles the event when Output button is clicked.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
       private void uxOutputMatrix_Click(object sender, EventArgs e)
        {
            if (uxSaveDialog.ShowDialog() == DialogResult.OK)
            {
                uxTextBoxOutput.Text = uxSaveDialog.FileName;
                if (uxTextBoxA.Text != "" && uxTextBoxB.Text != "" && uxTextBoxOutput.Text != "")
                {
                    uxSaveMatrix.Enabled = true;
                }
                else
                {
                    uxSaveMatrix.Enabled = false;
                }

            }
        }

        /// <summary>
       /// Handles the event when Compute Matrix Product button is clicked.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
       private void uxSaveMatrix_Click(object sender, EventArgs e)
        {
                string sa = uxTextBoxA.Text;
                string sb = uxTextBoxB.Text;
                int s;
                int p;

                KeyValuePair<int, Vector>[] ma = BuildRowVector(sa, out s, out p);
                KeyValuePair<int, Vector>[] mb = BuildColumnVector(sb, out p);
                try
                {
                    Product(ma, s, mb, p);
                    MessageBox.Show("Matrix written.");
                }
               catch(Exception er)
                {
                    MessageBox.Show(er.ToString());
                }
        }

       

    }

}
