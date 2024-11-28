namespace HahaWare
{
    partial class BunnyTech
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            richTextBox1 = new RichTextBox();
            Execute = new Button();
            Clear = new Button();
            KillRoblox = new Button();
            Inject = new Button();
            panel1 = new Panel();
            SuspendLayout();
            // 
            // richTextBox1
            // 
            richTextBox1.BackColor = Color.FromArgb(48, 46, 47);
            richTextBox1.BorderStyle = BorderStyle.None;
            richTextBox1.Cursor = Cursors.IBeam;
            richTextBox1.Location = new Point(35, 53);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(745, 189);
            richTextBox1.TabIndex = 0;
            richTextBox1.Text = "Print(\"Hello World!\")";
            richTextBox1.TextChanged += richTextBox1_TextChanged;
            // 
            // Execute
            // 
            Execute.BackColor = Color.FromArgb(48, 46, 47);
            Execute.Font = new Font("Microsoft Sans Serif", 8.25F);
            Execute.Location = new Point(303, 263);
            Execute.Name = "Execute";
            Execute.Size = new Size(178, 35);
            Execute.TabIndex = 1;
            Execute.Text = "Execute";
            Execute.UseVisualStyleBackColor = false;
            Execute.Click += Execute_Click;
            // 
            // Clear
            // 
            Clear.BackColor = Color.FromArgb(48, 46, 47);
            Clear.Location = new Point(35, 263);
            Clear.Name = "Clear";
            Clear.Size = new Size(145, 35);
            Clear.TabIndex = 2;
            Clear.Text = "Clear";
            Clear.UseVisualStyleBackColor = false;
            Clear.Click += Clear_Click;
            // 
            // KillRoblox
            // 
            KillRoblox.BackColor = Color.FromArgb(48, 46, 47);
            KillRoblox.Location = new Point(704, -2);
            KillRoblox.Name = "KillRoblox";
            KillRoblox.Size = new Size(147, 37);
            KillRoblox.TabIndex = 3;
            KillRoblox.Text = "Kill Roblox";
            KillRoblox.UseVisualStyleBackColor = false;
            KillRoblox.Click += KillRoblox_Click;
            // 
            // Inject
            // 
            Inject.BackColor = Color.FromArgb(48, 46, 47);
            Inject.ForeColor = Color.Black;
            Inject.Location = new Point(608, 263);
            Inject.Name = "Inject";
            Inject.Size = new Size(172, 35);
            Inject.TabIndex = 4;
            Inject.Text = "Inject";
            Inject.UseVisualStyleBackColor = false;
            Inject.Click += Inject_Click;
            // 
            // panel1
            // 
            panel1.BackgroundImage = Properties.Resources.btech;
            panel1.BackgroundImageLayout = ImageLayout.Zoom;
            panel1.Location = new Point(35, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(649, 35);
            panel1.TabIndex = 6;
            // 
            // BunnyTech
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(850, 357);
            Controls.Add(panel1);
            Controls.Add(Inject);
            Controls.Add(KillRoblox);
            Controls.Add(Clear);
            Controls.Add(Execute);
            Controls.Add(richTextBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "BunnyTech";
            Text = "BunnySploit";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private RichTextBox richTextBox1;
        private Button Execute;
        private Button Clear;
        private Button KillRoblox;
        private Button Inject;
        private Panel panel1;
    }
}
