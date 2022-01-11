
namespace LightningBlackjackStrategy
{
    partial class MainForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBJMulti = new System.Windows.Forms.ComboBox();
            this.comboCurrentMulti = new System.Windows.Forms.ComboBox();
            this.comboDealer = new System.Windows.Forms.ComboBox();
            this.comboPlayer = new System.Windows.Forms.ComboBox();
            this.txtStrategy = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.chkTopMost = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Dealer:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Player:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Current Multi:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "BJ Multi:";
            // 
            // comboBJMulti
            // 
            this.comboBJMulti.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBJMulti.FormattingEnabled = true;
            this.comboBJMulti.Items.AddRange(new object[] {
            "6x",
            "8x",
            "12x",
            "15x",
            "20x",
            "25x"});
            this.comboBJMulti.Location = new System.Drawing.Point(87, 12);
            this.comboBJMulti.Name = "comboBJMulti";
            this.comboBJMulti.Size = new System.Drawing.Size(121, 21);
            this.comboBJMulti.TabIndex = 0;
            this.comboBJMulti.SelectedIndexChanged += new System.EventHandler(this.Calculate);
            this.comboBJMulti.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CheckInput);
            // 
            // comboCurrentMulti
            // 
            this.comboCurrentMulti.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboCurrentMulti.FormattingEnabled = true;
            this.comboCurrentMulti.Items.AddRange(new object[] {
            "None",
            "2x",
            "3x",
            "4x",
            "5x",
            "6x",
            "8x",
            "10x",
            "12x",
            "15x",
            "20x",
            "25x"});
            this.comboCurrentMulti.Location = new System.Drawing.Point(87, 39);
            this.comboCurrentMulti.Name = "comboCurrentMulti";
            this.comboCurrentMulti.Size = new System.Drawing.Size(121, 21);
            this.comboCurrentMulti.TabIndex = 1;
            this.comboCurrentMulti.SelectedIndexChanged += new System.EventHandler(this.Calculate);
            this.comboCurrentMulti.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CheckInput);
            // 
            // comboDealer
            // 
            this.comboDealer.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboDealer.FormattingEnabled = true;
            this.comboDealer.Items.AddRange(new object[] {
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11"});
            this.comboDealer.Location = new System.Drawing.Point(87, 66);
            this.comboDealer.Name = "comboDealer";
            this.comboDealer.Size = new System.Drawing.Size(121, 21);
            this.comboDealer.TabIndex = 2;
            this.comboDealer.SelectedIndexChanged += new System.EventHandler(this.Calculate);
            this.comboDealer.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CheckInput);
            // 
            // comboPlayer
            // 
            this.comboPlayer.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboPlayer.FormattingEnabled = true;
            this.comboPlayer.Items.AddRange(new object[] {
            "Hard5",
            "Hard6",
            "Hard7",
            "Hard8",
            "Hard9",
            "Hard10",
            "Hard11",
            "Hard12",
            "Hard13",
            "Hard14",
            "Hard15",
            "Hard16",
            "Hard17",
            "Hard18",
            "Hard19",
            "Hard20",
            "Pair2",
            "Pair3",
            "Pair4",
            "Pair5",
            "Pair6",
            "Pair7",
            "Pair8",
            "Pair9",
            "Pair10",
            "Pair11",
            "Soft13",
            "Soft14",
            "Soft15",
            "Soft16",
            "Soft17",
            "Soft18",
            "Soft19",
            "Soft20",
            "Soft21",
            "Hard12/?",
            "Hard13/?",
            "Hard14/?",
            "Hard15/?",
            "Hard16/?",
            "Hard17/?",
            "Hard18/?",
            "Hard19/?",
            "Hard20/?",
            "12/Hard12",
            "12/Hard13",
            "12/Hard14",
            "12/Hard15",
            "12/Hard16",
            "12/Hard17",
            "12/Hard18",
            "12/Hard19",
            "12/Hard20",
            "13/Hard12",
            "13/Hard13",
            "13/Hard14",
            "13/Hard15",
            "13/Hard16",
            "13/Hard17",
            "13/Hard18",
            "13/Hard19",
            "13/Hard20",
            "14/Hard12",
            "14/Hard13",
            "14/Hard14",
            "14/Hard15",
            "14/Hard16",
            "14/Hard17",
            "14/Hard18",
            "14/Hard19",
            "14/Hard20",
            "15/Hard12",
            "15/Hard13",
            "15/Hard14",
            "15/Hard15",
            "15/Hard16",
            "15/Hard17",
            "15/Hard18",
            "15/Hard19",
            "15/Hard20",
            "16/Hard12",
            "16/Hard13",
            "16/Hard14",
            "16/Hard15",
            "16/Hard16",
            "16/Hard17",
            "16/Hard18",
            "16/Hard19",
            "16/Hard20",
            "17/Hard12",
            "17/Hard13",
            "17/Hard14",
            "17/Hard15",
            "17/Hard16",
            "17/Hard17",
            "17/Hard18",
            "17/Hard19",
            "17/Hard20",
            "18/Hard12",
            "18/Hard13",
            "18/Hard14",
            "18/Hard15",
            "18/Hard16",
            "18/Hard17",
            "18/Hard18",
            "18/Hard19",
            "18/Hard20",
            "19/Hard12",
            "19/Hard13",
            "19/Hard14",
            "19/Hard15",
            "19/Hard16",
            "19/Hard17",
            "19/Hard18",
            "19/Hard19",
            "19/Hard20",
            "20/Hard12",
            "20/Hard13",
            "20/Hard14",
            "20/Hard15",
            "20/Hard16",
            "20/Hard17",
            "20/Hard18",
            "20/Hard19",
            "20/Hard20",
            "21/Hard12",
            "21/Hard13",
            "21/Hard14",
            "21/Hard15",
            "21/Hard16",
            "21/Hard17",
            "21/Hard18",
            "21/Hard19",
            "21/Hard20",
            "22/Hard12",
            "22/Hard13",
            "22/Hard14",
            "22/Hard15",
            "22/Hard16",
            "22/Hard17",
            "22/Hard18",
            "22/Hard19",
            "22/Hard20",
            "Soft12/?",
            "Soft13/?",
            "Soft14/?",
            "Soft15/?",
            "Soft16/?",
            "Soft17/?",
            "Soft18/?",
            "Soft19/?",
            "Soft20/?",
            "12/Soft12",
            "12/Soft13",
            "12/Soft14",
            "12/Soft15",
            "12/Soft16",
            "12/Soft17",
            "12/Soft18",
            "12/Soft19",
            "12/Soft20",
            "13/Soft12",
            "13/Soft13",
            "13/Soft14",
            "13/Soft15",
            "13/Soft16",
            "13/Soft17",
            "13/Soft18",
            "13/Soft19",
            "13/Soft20",
            "14/Soft12",
            "14/Soft13",
            "14/Soft14",
            "14/Soft15",
            "14/Soft16",
            "14/Soft17",
            "14/Soft18",
            "14/Soft19",
            "14/Soft20",
            "15/Soft12",
            "15/Soft13",
            "15/Soft14",
            "15/Soft15",
            "15/Soft16",
            "15/Soft17",
            "15/Soft18",
            "15/Soft19",
            "15/Soft20",
            "16/Soft12",
            "16/Soft13",
            "16/Soft14",
            "16/Soft15",
            "16/Soft16",
            "16/Soft17",
            "16/Soft18",
            "16/Soft19",
            "16/Soft20",
            "17/Soft12",
            "17/Soft13",
            "17/Soft14",
            "17/Soft15",
            "17/Soft16",
            "17/Soft17",
            "17/Soft18",
            "17/Soft19",
            "17/Soft20",
            "18/Soft12",
            "18/Soft13",
            "18/Soft14",
            "18/Soft15",
            "18/Soft16",
            "18/Soft17",
            "18/Soft18",
            "18/Soft19",
            "18/Soft20",
            "19/Soft12",
            "19/Soft13",
            "19/Soft14",
            "19/Soft15",
            "19/Soft16",
            "19/Soft17",
            "19/Soft18",
            "19/Soft19",
            "19/Soft20",
            "20/Soft12",
            "20/Soft13",
            "20/Soft14",
            "20/Soft15",
            "20/Soft16",
            "20/Soft17",
            "20/Soft18",
            "20/Soft19",
            "20/Soft20",
            "21/Soft12",
            "21/Soft13",
            "21/Soft14",
            "21/Soft15",
            "21/Soft16",
            "21/Soft17",
            "21/Soft18",
            "21/Soft19",
            "21/Soft20",
            "22/Soft12",
            "22/Soft13",
            "22/Soft14",
            "22/Soft15",
            "22/Soft16",
            "22/Soft17",
            "22/Soft18",
            "22/Soft19",
            "22/Soft20"});
            this.comboPlayer.Location = new System.Drawing.Point(87, 93);
            this.comboPlayer.Name = "comboPlayer";
            this.comboPlayer.Size = new System.Drawing.Size(121, 21);
            this.comboPlayer.TabIndex = 3;
            this.comboPlayer.SelectedIndexChanged += new System.EventHandler(this.Calculate);
            this.comboPlayer.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CheckInput);
            // 
            // txtStrategy
            // 
            this.txtStrategy.Location = new System.Drawing.Point(87, 120);
            this.txtStrategy.Name = "txtStrategy";
            this.txtStrategy.ReadOnly = true;
            this.txtStrategy.Size = new System.Drawing.Size(121, 20);
            this.txtStrategy.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "Strategy:";
            // 
            // chkTopMost
            // 
            this.chkTopMost.AutoSize = true;
            this.chkTopMost.Location = new System.Drawing.Point(87, 146);
            this.chkTopMost.Name = "chkTopMost";
            this.chkTopMost.Size = new System.Drawing.Size(68, 17);
            this.chkTopMost.TabIndex = 5;
            this.chkTopMost.Text = "TopMost";
            this.chkTopMost.UseVisualStyleBackColor = true;
            this.chkTopMost.CheckedChanged += new System.EventHandler(this.chkTopMost_CheckedChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(223, 171);
            this.Controls.Add(this.chkTopMost);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtStrategy);
            this.Controls.Add(this.comboPlayer);
            this.Controls.Add(this.comboDealer);
            this.Controls.Add(this.comboCurrentMulti);
            this.Controls.Add(this.comboBJMulti);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Lightning Blackjack Strategy";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBJMulti;
        private System.Windows.Forms.ComboBox comboCurrentMulti;
        private System.Windows.Forms.ComboBox comboDealer;
        private System.Windows.Forms.ComboBox comboPlayer;
        private System.Windows.Forms.TextBox txtStrategy;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox chkTopMost;
    }
}

