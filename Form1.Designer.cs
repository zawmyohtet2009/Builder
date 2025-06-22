
namespace Builder
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
            this.panel_input = new System.Windows.Forms.Panel();
            this.textBox_x = new System.Windows.Forms.TextBox();
            this.label_x = new System.Windows.Forms.Label();
            this.label_y = new System.Windows.Forms.Label();
            this.textBox_y = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label_sc = new System.Windows.Forms.Label();
            this.label_input = new System.Windows.Forms.Label();
            this.button_add = new System.Windows.Forms.Button();
            this.label_add = new System.Windows.Forms.Label();
            this.label_subtract = new System.Windows.Forms.Label();
            this.button_subtract = new System.Windows.Forms.Button();
            this.label_multiply = new System.Windows.Forms.Label();
            this.button_multiply = new System.Windows.Forms.Button();
            this.label_divide = new System.Windows.Forms.Label();
            this.button_divide = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label_squareRoot = new System.Windows.Forms.Label();
            this.button_squareRoot = new System.Windows.Forms.Button();
            this.label_power = new System.Windows.Forms.Label();
            this.button_power = new System.Windows.Forms.Button();
            this.label_ac = new System.Windows.Forms.Label();
            this.panel_input.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_input
            // 
            this.panel_input.Controls.Add(this.label_input);
            this.panel_input.Controls.Add(this.textBox_y);
            this.panel_input.Controls.Add(this.label_y);
            this.panel_input.Controls.Add(this.label_x);
            this.panel_input.Controls.Add(this.textBox_x);
            this.panel_input.Location = new System.Drawing.Point(12, 22);
            this.panel_input.Name = "panel_input";
            this.panel_input.Size = new System.Drawing.Size(426, 111);
            this.panel_input.TabIndex = 0;
            // 
            // textBox_x
            // 
            this.textBox_x.Location = new System.Drawing.Point(66, 50);
            this.textBox_x.Name = "textBox_x";
            this.textBox_x.Size = new System.Drawing.Size(100, 22);
            this.textBox_x.TabIndex = 0;
            // 
            // label_x
            // 
            this.label_x.AutoSize = true;
            this.label_x.Location = new System.Drawing.Point(20, 53);
            this.label_x.Name = "label_x";
            this.label_x.Size = new System.Drawing.Size(29, 17);
            this.label_x.TabIndex = 1;
            this.label_x.Text = "X : ";
            // 
            // label_y
            // 
            this.label_y.AutoSize = true;
            this.label_y.Location = new System.Drawing.Point(213, 53);
            this.label_y.Name = "label_y";
            this.label_y.Size = new System.Drawing.Size(29, 17);
            this.label_y.TabIndex = 2;
            this.label_y.Text = "Y : ";
            // 
            // textBox_y
            // 
            this.textBox_y.Location = new System.Drawing.Point(270, 49);
            this.textBox_y.Name = "textBox_y";
            this.textBox_y.Size = new System.Drawing.Size(100, 22);
            this.textBox_y.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label_divide);
            this.panel1.Controls.Add(this.button_divide);
            this.panel1.Controls.Add(this.label_multiply);
            this.panel1.Controls.Add(this.button_multiply);
            this.panel1.Controls.Add(this.label_subtract);
            this.panel1.Controls.Add(this.button_subtract);
            this.panel1.Controls.Add(this.label_add);
            this.panel1.Controls.Add(this.button_add);
            this.panel1.Controls.Add(this.label_sc);
            this.panel1.Location = new System.Drawing.Point(12, 174);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(386, 264);
            this.panel1.TabIndex = 1;
            // 
            // label_sc
            // 
            this.label_sc.AutoSize = true;
            this.label_sc.Location = new System.Drawing.Point(127, 4);
            this.label_sc.Name = "label_sc";
            this.label_sc.Size = new System.Drawing.Size(182, 17);
            this.label_sc.TabIndex = 0;
            this.label_sc.Text = "Simple Calculator Functions";
            // 
            // label_input
            // 
            this.label_input.AutoSize = true;
            this.label_input.Location = new System.Drawing.Point(119, 4);
            this.label_input.Name = "label_input";
            this.label_input.Size = new System.Drawing.Size(140, 17);
            this.label_input.TabIndex = 4;
            this.label_input.Text = "Input X and Y Values";
            // 
            // button_add
            // 
            this.button_add.Location = new System.Drawing.Point(23, 50);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(75, 23);
            this.button_add.TabIndex = 1;
            this.button_add.Text = "+";
            this.button_add.UseVisualStyleBackColor = true;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // label_add
            // 
            this.label_add.AutoSize = true;
            this.label_add.Location = new System.Drawing.Point(159, 56);
            this.label_add.Name = "label_add";
            this.label_add.Size = new System.Drawing.Size(93, 17);
            this.label_add.TabIndex = 2;
            this.label_add.Text = "Add Result ...";
            // 
            // label_subtract
            // 
            this.label_subtract.AutoSize = true;
            this.label_subtract.Location = new System.Drawing.Point(159, 103);
            this.label_subtract.Name = "label_subtract";
            this.label_subtract.Size = new System.Drawing.Size(121, 17);
            this.label_subtract.TabIndex = 4;
            this.label_subtract.Text = "Subtract Result ...";
            // 
            // button_subtract
            // 
            this.button_subtract.Location = new System.Drawing.Point(23, 97);
            this.button_subtract.Name = "button_subtract";
            this.button_subtract.Size = new System.Drawing.Size(75, 23);
            this.button_subtract.TabIndex = 3;
            this.button_subtract.Text = "-";
            this.button_subtract.UseVisualStyleBackColor = true;
            this.button_subtract.Click += new System.EventHandler(this.button_subtract_Click);
            // 
            // label_multiply
            // 
            this.label_multiply.AutoSize = true;
            this.label_multiply.Location = new System.Drawing.Point(159, 151);
            this.label_multiply.Name = "label_multiply";
            this.label_multiply.Size = new System.Drawing.Size(115, 17);
            this.label_multiply.TabIndex = 6;
            this.label_multiply.Text = "Multiply Result ...";
            // 
            // button_multiply
            // 
            this.button_multiply.Location = new System.Drawing.Point(23, 145);
            this.button_multiply.Name = "button_multiply";
            this.button_multiply.Size = new System.Drawing.Size(75, 23);
            this.button_multiply.TabIndex = 5;
            this.button_multiply.Text = "x";
            this.button_multiply.UseVisualStyleBackColor = true;
            this.button_multiply.Click += new System.EventHandler(this.button_multiply_Click);
            // 
            // label_divide
            // 
            this.label_divide.AutoSize = true;
            this.label_divide.Location = new System.Drawing.Point(159, 205);
            this.label_divide.Name = "label_divide";
            this.label_divide.Size = new System.Drawing.Size(107, 17);
            this.label_divide.TabIndex = 8;
            this.label_divide.Text = "Divide Result ...";
            // 
            // button_divide
            // 
            this.button_divide.Location = new System.Drawing.Point(23, 199);
            this.button_divide.Name = "button_divide";
            this.button_divide.Size = new System.Drawing.Size(75, 23);
            this.button_divide.TabIndex = 7;
            this.button_divide.Text = "÷";
            this.button_divide.UseVisualStyleBackColor = true;
            this.button_divide.Click += new System.EventHandler(this.button_divide_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label_squareRoot);
            this.panel2.Controls.Add(this.button_squareRoot);
            this.panel2.Controls.Add(this.label_power);
            this.panel2.Controls.Add(this.button_power);
            this.panel2.Controls.Add(this.label_ac);
            this.panel2.Location = new System.Drawing.Point(404, 174);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(386, 264);
            this.panel2.TabIndex = 2;
            // 
            // label_squareRoot
            // 
            this.label_squareRoot.AutoSize = true;
            this.label_squareRoot.Location = new System.Drawing.Point(159, 103);
            this.label_squareRoot.Name = "label_squareRoot";
            this.label_squareRoot.Size = new System.Drawing.Size(177, 17);
            this.label_squareRoot.TabIndex = 4;
            this.label_squareRoot.Text = "Square Root of X Result ...";
            // 
            // button_squareRoot
            // 
            this.button_squareRoot.Location = new System.Drawing.Point(23, 97);
            this.button_squareRoot.Name = "button_squareRoot";
            this.button_squareRoot.Size = new System.Drawing.Size(75, 23);
            this.button_squareRoot.TabIndex = 3;
            this.button_squareRoot.Text = "√x";
            this.button_squareRoot.UseVisualStyleBackColor = true;
            this.button_squareRoot.Click += new System.EventHandler(this.button_squareRoot_Click);
            // 
            // label_power
            // 
            this.label_power.AutoSize = true;
            this.label_power.Location = new System.Drawing.Point(159, 56);
            this.label_power.Name = "label_power";
            this.label_power.Size = new System.Drawing.Size(132, 17);
            this.label_power.TabIndex = 2;
            this.label_power.Text = "X power Y Result ...";
            // 
            // button_power
            // 
            this.button_power.Location = new System.Drawing.Point(23, 50);
            this.button_power.Name = "button_power";
            this.button_power.Size = new System.Drawing.Size(75, 23);
            this.button_power.TabIndex = 1;
            this.button_power.Text = "x^y";
            this.button_power.UseVisualStyleBackColor = true;
            this.button_power.Click += new System.EventHandler(this.button_power_Click);
            // 
            // label_ac
            // 
            this.label_ac.AutoSize = true;
            this.label_ac.Location = new System.Drawing.Point(127, 4);
            this.label_ac.Name = "label_ac";
            this.label_ac.Size = new System.Drawing.Size(195, 17);
            this.label_ac.TabIndex = 0;
            this.label_ac.Text = "Advance Calculator Functions";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel_input);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel_input.ResumeLayout(false);
            this.panel_input.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_input;
        private System.Windows.Forms.Label label_x;
        private System.Windows.Forms.TextBox textBox_x;
        private System.Windows.Forms.Label label_input;
        private System.Windows.Forms.TextBox textBox_y;
        private System.Windows.Forms.Label label_y;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label_divide;
        private System.Windows.Forms.Button button_divide;
        private System.Windows.Forms.Label label_multiply;
        private System.Windows.Forms.Button button_multiply;
        private System.Windows.Forms.Label label_subtract;
        private System.Windows.Forms.Button button_subtract;
        private System.Windows.Forms.Label label_add;
        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.Label label_sc;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label_squareRoot;
        private System.Windows.Forms.Button button_squareRoot;
        private System.Windows.Forms.Label label_power;
        private System.Windows.Forms.Button button_power;
        private System.Windows.Forms.Label label_ac;
    }
}

