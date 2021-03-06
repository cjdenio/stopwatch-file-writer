﻿namespace Stopwatch
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.clockText = new System.Windows.Forms.Label();
            this.startButton = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.resetButton = new System.Windows.Forms.Button();
            this.contestantTextBox = new System.Windows.Forms.TextBox();
            this.ageGroupTextBox = new System.Windows.Forms.TextBox();
            this.contestantLabel = new System.Windows.Forms.Label();
            this.ageGroupLabel = new System.Windows.Forms.Label();
            this.updateButton = new System.Windows.Forms.Button();
            this.saveTimeButton = new System.Windows.Forms.Button();
            this.clearDataButton = new System.Windows.Forms.Button();
            this.outputButton = new System.Windows.Forms.Button();
            this.clearScreenButton = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // clockText
            // 
            this.clockText.Font = new System.Drawing.Font("Microsoft Sans Serif", 70F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clockText.Location = new System.Drawing.Point(0, 70);
            this.clockText.Name = "clockText";
            this.clockText.Size = new System.Drawing.Size(606, 100);
            this.clockText.TabIndex = 0;
            this.clockText.Text = "00:00";
            this.clockText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // startButton
            // 
            this.startButton.AutoSize = true;
            this.startButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startButton.Location = new System.Drawing.Point(237, 251);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(117, 62);
            this.startButton.TabIndex = 1;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // resetButton
            // 
            this.resetButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetButton.Location = new System.Drawing.Point(360, 266);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(103, 47);
            this.resetButton.TabIndex = 2;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // contestantTextBox
            // 
            this.contestantTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contestantTextBox.Location = new System.Drawing.Point(12, 208);
            this.contestantTextBox.Name = "contestantTextBox";
            this.contestantTextBox.Size = new System.Drawing.Size(181, 30);
            this.contestantTextBox.TabIndex = 3;
            // 
            // ageGroupTextBox
            // 
            this.ageGroupTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ageGroupTextBox.Location = new System.Drawing.Point(12, 303);
            this.ageGroupTextBox.Name = "ageGroupTextBox";
            this.ageGroupTextBox.Size = new System.Drawing.Size(181, 30);
            this.ageGroupTextBox.TabIndex = 4;
            // 
            // contestantLabel
            // 
            this.contestantLabel.AutoSize = true;
            this.contestantLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contestantLabel.Location = new System.Drawing.Point(7, 180);
            this.contestantLabel.Name = "contestantLabel";
            this.contestantLabel.Size = new System.Drawing.Size(177, 25);
            this.contestantLabel.TabIndex = 5;
            this.contestantLabel.Text = "Current Contestant";
            // 
            // ageGroupLabel
            // 
            this.ageGroupLabel.AutoSize = true;
            this.ageGroupLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ageGroupLabel.Location = new System.Drawing.Point(7, 275);
            this.ageGroupLabel.Name = "ageGroupLabel";
            this.ageGroupLabel.Size = new System.Drawing.Size(107, 25);
            this.ageGroupLabel.TabIndex = 6;
            this.ageGroupLabel.Text = "Age Group";
            // 
            // updateButton
            // 
            this.updateButton.AutoSize = true;
            this.updateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateButton.Location = new System.Drawing.Point(12, 109);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(154, 35);
            this.updateButton.TabIndex = 7;
            this.updateButton.Text = "Update Display";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // saveTimeButton
            // 
            this.saveTimeButton.AutoSize = true;
            this.saveTimeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveTimeButton.Location = new System.Drawing.Point(425, 111);
            this.saveTimeButton.Name = "saveTimeButton";
            this.saveTimeButton.Size = new System.Drawing.Size(153, 35);
            this.saveTimeButton.TabIndex = 8;
            this.saveTimeButton.Text = "Save Data";
            this.saveTimeButton.UseVisualStyleBackColor = true;
            this.saveTimeButton.Click += new System.EventHandler(this.saveTimeButton_Click);
            // 
            // clearDataButton
            // 
            this.clearDataButton.AutoSize = true;
            this.clearDataButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearDataButton.Location = new System.Drawing.Point(425, 70);
            this.clearDataButton.Name = "clearDataButton";
            this.clearDataButton.Size = new System.Drawing.Size(153, 35);
            this.clearDataButton.TabIndex = 9;
            this.clearDataButton.Text = "Clear Saves";
            this.clearDataButton.UseVisualStyleBackColor = true;
            this.clearDataButton.Click += new System.EventHandler(this.clearDataButton_Click);
            // 
            // outputButton
            // 
            this.outputButton.Location = new System.Drawing.Point(503, 341);
            this.outputButton.Name = "outputButton";
            this.outputButton.Size = new System.Drawing.Size(75, 23);
            this.outputButton.TabIndex = 12;
            this.outputButton.Text = "Output on";
            this.outputButton.UseVisualStyleBackColor = true;
            this.outputButton.Click += new System.EventHandler(this.outputButton_Click);
            // 
            // clearScreenButton
            // 
            this.clearScreenButton.AutoSize = true;
            this.clearScreenButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearScreenButton.Location = new System.Drawing.Point(12, 68);
            this.clearScreenButton.Name = "clearScreenButton";
            this.clearScreenButton.Size = new System.Drawing.Size(153, 35);
            this.clearScreenButton.TabIndex = 10;
            this.clearScreenButton.Text = "Clear Display";
            this.clearScreenButton.UseVisualStyleBackColor = true;
            this.clearScreenButton.Click += new System.EventHandler(this.clearScreenButton_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Display 0",
            "Display 1",
            "Display 2",
            "Display 3"});
            this.comboBox1.Location = new System.Drawing.Point(360, 343);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 13;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(590, 376);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.outputButton);
            this.Controls.Add(this.clearScreenButton);
            this.Controls.Add(this.clearDataButton);
            this.Controls.Add(this.saveTimeButton);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.ageGroupLabel);
            this.Controls.Add(this.contestantLabel);
            this.Controls.Add(this.ageGroupTextBox);
            this.Controls.Add(this.contestantTextBox);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.clockText);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "RaceDisplay";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label clockText;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.TextBox contestantTextBox;
        private System.Windows.Forms.TextBox ageGroupTextBox;
        private System.Windows.Forms.Label contestantLabel;
        private System.Windows.Forms.Label ageGroupLabel;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Button saveTimeButton;
        private System.Windows.Forms.Button clearDataButton;
        private System.Windows.Forms.Button outputButton;
        private System.Windows.Forms.Button clearScreenButton;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}

