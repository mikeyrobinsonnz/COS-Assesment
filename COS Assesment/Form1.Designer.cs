
namespace COS_Assesment
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnRoll = new System.Windows.Forms.Button();
            this.PicHeader = new System.Windows.Forms.PictureBox();
            this.PicDice = new System.Windows.Forms.PictureBox();
            this.mainPnl = new System.Windows.Forms.Panel();
            this.piece1 = new System.Windows.Forms.PictureBox();
            this.TimerGame = new System.Windows.Forms.Timer(this.components);
            this.BtnName = new System.Windows.Forms.Button();
            this.TxtName = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.PicHeader)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicDice)).BeginInit();
            this.mainPnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.piece1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRoll
            // 
            this.btnRoll.BackColor = System.Drawing.Color.Chartreuse;
            this.btnRoll.Font = new System.Drawing.Font("Algerian", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRoll.Location = new System.Drawing.Point(695, 353);
            this.btnRoll.Name = "btnRoll";
            this.btnRoll.Size = new System.Drawing.Size(183, 42);
            this.btnRoll.TabIndex = 3;
            this.btnRoll.Text = "ROLL!";
            this.btnRoll.UseVisualStyleBackColor = false;
            this.btnRoll.Click += new System.EventHandler(this.btnRoll_Click);
            // 
            // PicHeader
            // 
            this.PicHeader.BackgroundImage = global::COS_Assesment.Properties.Resources.header;
            this.PicHeader.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PicHeader.Location = new System.Drawing.Point(660, 12);
            this.PicHeader.Name = "PicHeader";
            this.PicHeader.Size = new System.Drawing.Size(250, 153);
            this.PicHeader.TabIndex = 2;
            this.PicHeader.TabStop = false;
            // 
            // PicDice
            // 
            this.PicDice.BackgroundImage = global::COS_Assesment.Properties.Resources.dice1;
            this.PicDice.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PicDice.Location = new System.Drawing.Point(729, 194);
            this.PicDice.Name = "PicDice";
            this.PicDice.Size = new System.Drawing.Size(107, 104);
            this.PicDice.TabIndex = 1;
            this.PicDice.TabStop = false;
            // 
            // mainPnl
            // 
            this.mainPnl.BackgroundImage = global::COS_Assesment.Properties.Resources.board_image1;
            this.mainPnl.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.mainPnl.Controls.Add(this.piece1);
            this.mainPnl.Location = new System.Drawing.Point(12, 12);
            this.mainPnl.Name = "mainPnl";
            this.mainPnl.Size = new System.Drawing.Size(600, 600);
            this.mainPnl.TabIndex = 0;
            this.mainPnl.Paint += new System.Windows.Forms.PaintEventHandler(this.mainPnl_Paint);
            // 
            // piece1
            // 
            this.piece1.BackColor = System.Drawing.Color.Transparent;
            this.piece1.BackgroundImage = global::COS_Assesment.Properties.Resources.piece1;
            this.piece1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.piece1.Location = new System.Drawing.Point(3, 550);
            this.piece1.Name = "piece1";
            this.piece1.Size = new System.Drawing.Size(30, 30);
            this.piece1.TabIndex = 3;
            this.piece1.TabStop = false;
            // 
            // TimerGame
            // 
            this.TimerGame.Interval = 1000;
            this.TimerGame.Tick += new System.EventHandler(this.TimerGame_Tick);
            // 
            // BtnName
            // 
            this.BtnName.BackColor = System.Drawing.Color.Chartreuse;
            this.BtnName.Font = new System.Drawing.Font("Algerian", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnName.Location = new System.Drawing.Point(695, 544);
            this.BtnName.Name = "BtnName";
            this.BtnName.Size = new System.Drawing.Size(183, 48);
            this.BtnName.TabIndex = 4;
            this.BtnName.Text = "Submit";
            this.BtnName.UseVisualStyleBackColor = false;
            this.BtnName.Click += new System.EventHandler(this.BtnName_Click);
            // 
            // TxtName
            // 
            this.TxtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtName.Location = new System.Drawing.Point(695, 476);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(183, 31);
            this.TxtName.TabIndex = 5;
            this.TxtName.TextChanged += new System.EventHandler(this.TxtName_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(952, 648);
            this.Controls.Add(this.TxtName);
            this.Controls.Add(this.BtnName);
            this.Controls.Add(this.btnRoll);
            this.Controls.Add(this.PicHeader);
            this.Controls.Add(this.PicDice);
            this.Controls.Add(this.mainPnl);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.PicHeader)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicDice)).EndInit();
            this.mainPnl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.piece1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel mainPnl;
        private System.Windows.Forms.PictureBox piece1;
        private System.Windows.Forms.PictureBox PicDice;
        private System.Windows.Forms.PictureBox PicHeader;
        private System.Windows.Forms.Button btnRoll;
        private System.Windows.Forms.Timer TimerGame;
        private System.Windows.Forms.Button BtnName;
        private System.Windows.Forms.TextBox TxtName;
    }
}

