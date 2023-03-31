namespace Minesweeper
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new Point(261, 155);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(125, 62);
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // Form1
            // 
            ClientSize = new Size(667, 423);
            Controls.Add(pictureBox2);
            Name = "Form1";
            Load += Form1_Load_1;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }


        private void Form1_Load_1(object sender, EventArgs e)
        {
            PictureBox[,] pictureBox = new PictureBox[10, 10];

            MessageBox.Show("Weee");
            MessageBox.Show("This code is still under construction");


            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    pictureBox[i, j] = new PictureBox();
                    pictureBox[i, j].Location = new Point(i, j);
                    pictureBox[i, j].ImageLocation = "C:\\Users\\aidan\\OneDrive\\Documents\\Source Image\\mike.png";
                }
            }
           
        }
    }
}