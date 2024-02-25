using System.ComponentModel;
using System.Diagnostics;

namespace FakeInstaller
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            P1panelGame.Hide();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_MouseMove(object sender, MouseEventArgs e)
        {
            P1buttonNext.ForeColor = Color.Black;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            if (P1buttonNext.Enabled)
            {
                P1buttonNext.ForeColor = Color.DarkOrange;
            }

        }

        private void button1_EnabledChanged(object sender, EventArgs e)
        {
            if (P1buttonNext.Enabled)
            {
                P1buttonNext.BackColor = Color.Black;
                P1buttonNext.ForeColor = Color.DarkOrange;
                P1buttonNext.FlatAppearance.BorderColor = Color.DarkOrange;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            P1buttonNext.Cursor = Cursors.Hand;
            if (P1comboBoxV.SelectedIndex == 0)
            {
                P1labelV.Text = "����: v0.1-winX64";
                P1labelF.Text = "�ɮפj�p: 10.2GB";
                P1Waringlabel.Show();
                P1panelGame.Show();

                //�q�M�׸귽�ɤ��ޤJ�Ϥ�:
                gameCover.Image = Properties.Resources.jHYHBBnkJ5Vnqe5HpSEHwp_NNClPfUJHaVKlPGlSpTw;
            }
            else
            {
                P1labelV.Text = "����: v0.2-winX64";
                P1labelF.Text = "�ɮפj�p: 12.4GB";
                P1Waringlabel.Show();
                P1panelGame.Show();
                gameCover.Image = Properties.Resources._3_6;
            }
        }

        private void P1buttonNext_Click(object sender, EventArgs e)
        {
            if (P1buttonNext.Cursor == Cursors.Hand)
            {

                DialogResult result = MessageBox.Show($"�T�w�n�U���o�Ӫ�����?\n{P1comboBoxV.SelectedText}", "Rockstar Installer", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result == DialogResult.OK)
                {
                    //panel1.Hide();
                    P2labelS.Text = P1labelF.Text;
                    P2labelV.Text = P1labelV.Text;
                    P2pictureBox1.Image = gameCover.Image;
                    progressBar1.Value = 0;
                    panel2.Show();

                    if (!backgroundWorkerDownLoad.IsBusy)
                    {
                        backgroundWorkerDownLoad.RunWorkerAsync();
                    }
                }
            }
            else
            {
                MessageBox.Show("�Х���ܦw�˪���", "Rockstar Installer", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void P2buttonC_Click(object sender, EventArgs e)
        {

            DialogResult result = MessageBox.Show($"�T�w�n�����U����?\n{P1comboBoxV.SelectedText}", "Rockstar Installer", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                //panel1.Hide();
                panel2.Hide();
                backgroundWorkerDownLoad.CancelAsync();
            }
        }

        private void backgroundWorkerDownLoad_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker worker = sender as BackgroundWorker;

            Random RD = new Random();
            int runProgress = 0;
            Debug.WriteLine("Runed");
            while (runProgress != 100)
            {
                if (worker.CancellationPending == true)
                {
                    e.Cancel = true;
                    break;
                }
                {
                    Thread.Sleep(RD.Next(500, 1000));
                    runProgress += RD.Next(0, 5);

                    if (runProgress >= 100)
                    {
                        worker.ReportProgress(100);
                        break;
                    }

                    worker.ReportProgress(runProgress);
                }

            }
        }

        private void backgroundWorkerDownLoad_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            F2button1.Show();
            MessageBox.Show("�U������!!", "Rockstar Installer", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void backgroundWorkerDownLoad_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage;
        }

        private void F2button1_Click(object sender, EventArgs e)
        {
            Microsoft.VisualBasic.Interaction.InputBox("��J�ʳ����դH���N�X�H�i��w��\n(�z�i�H�b�z�[�J���ԦW��ɶ�J��Email�����)", "Rockstar Beta");
            MessageBox.Show("�����w�˥]����!!\n�нT�{�z��J�F���T�N�X!!", "Rockstar Installer", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
