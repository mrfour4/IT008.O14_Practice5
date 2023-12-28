using System;
using System.Drawing;
using System.IO;
using System.Numerics;
using System.Threading;
using System.Windows.Forms;


namespace practice_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private readonly int NUM_OF_ELEMENTS = 1000000;

        private void btnCreateFile_Click(object sender, System.EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "Text Files|*.txt|All Files|*.*";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = saveFileDialog.FileName;

                    btnCalcSum.Enabled = false;

                    try
                    {
                        using (FileStream fs = new FileStream(filePath, FileMode.Create))
                        {
                            using (StreamWriter sw = new StreamWriter(fs))
                            {
                                Random random = new Random();
                                for (int i = 0; i < NUM_OF_ELEMENTS; i++)
                                {
                                    int ranNum = random.Next();
                                    sw.Write(ranNum);
                                    if (i < NUM_OF_ELEMENTS - 1)
                                    {
                                        sw.Write(' ');
                                    }
                                }
                            }
                        }

                        MessageBox.Show("Tạo file với 1 triệu số nguyên ngẫu nhiên thành công", "Tạo file", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        btnCalcSum.Enabled = true;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

        }



        private BigInteger CalculateSumFromFile(string filePath)
        {
            BigInteger sum = BigInteger.Zero;

            using (FileStream fileStream = new FileStream(filePath, FileMode.Open, FileAccess.Read))
            {
                using (StreamReader streamReader = new StreamReader(fileStream))
                {
                    while (!streamReader.EndOfStream)
                    {
                        string line = streamReader.ReadLine();

                        string[] items = line.Split(' ');

                        foreach (string item in items)
                        {
                            if (BigInteger.TryParse(item, out BigInteger value))
                            {
                                sum += value;
                            }
                        }
                    }
                }
            }
            return sum;
        }

        private void EnableControls(bool enable)
        {
            if (btnCreateFile.InvokeRequired)
            {
                btnCreateFile.Invoke((MethodInvoker)delegate
                {
                    btnCreateFile.Enabled = enable;
                });
            }
            else
            {
                btnCreateFile.Enabled = enable;
            }

            if (btnCalcSum.InvokeRequired)
            {
                btnCalcSum.Invoke((MethodInvoker)delegate
                {
                    btnCalcSum.Enabled = enable;
                });
            }
            else
            {
                btnCalcSum.Enabled = enable;
            }
        }

        private void btnCalcSum_Click(object sender, EventArgs e)
        {

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = openFileDialog.FileName;

                    EnableControls(false);
                    txtResult.Text = "Đang tính...";

                    Thread thread = new Thread((param) =>
                    {
                        string threadFilePath = (string)param;

                        try
                        {
                            BigInteger sum = CalculateSumFromFile(threadFilePath);

                            txtResult.Invoke((MethodInvoker)delegate
                            {
                                txtResult.Text = sum.ToString();
                            });
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error reading file: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        finally
                        {
                            EnableControls(true);
                        }
                    });

                    thread.IsBackground = true;

                    thread.Start(filePath);
                }
            }

        }


        private void btnDoSomthing_Click(object sender, EventArgs e)
        {
            Random random = new Random();

            int red = random.Next(256);
            int green = random.Next(256);
            int blue = random.Next(256);

            Color randomColor = Color.FromArgb(red, green, blue);

            this.BackColor = randomColor;
            this.BackColor = randomColor;
        }
    }
}
