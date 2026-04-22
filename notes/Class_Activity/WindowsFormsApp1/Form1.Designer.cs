namespace SimpleFormApp
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.txtRoll = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.lblAge = new System.Windows.Forms.Label();
            this.lblRoll = new System.Windows.Forms.Label();

            this.SuspendLayout();

            // txtName
            this.txtName.Location = new System.Drawing.Point(120, 30);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(180, 22);

            // txtAge
            this.txtAge.Location = new System.Drawing.Point(120, 70);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(180, 22);

            // txtRoll
            this.txtRoll.Location = new System.Drawing.Point(120, 110);
            this.txtRoll.Name = "txtRoll";
            this.txtRoll.Size = new System.Drawing.Size(180, 22);

            // btnSubmit
            this.btnSubmit.Location = new System.Drawing.Point(120, 160);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(180, 30);
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);

            // lblName
            this.lblName.Location = new System.Drawing.Point(40, 33);
            this.lblName.Text = "Name";

            // lblAge
            this.lblAge.Location = new System.Drawing.Point(40, 73);
            this.lblAge.Text = "Age";

            // lblRoll
            this.lblRoll.Location = new System.Drawing.Point(40, 113);
            this.lblRoll.Text = "Roll Number";

            // Form1 setup
            this.ClientSize = new System.Drawing.Size(350, 230);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtAge);
            this.Controls.Add(this.txtRoll);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblAge);
            this.Controls.Add(this.lblRoll);
            this.Name = "Form1";
            this.Text = "Student Details Form";

            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.TextBox txtRoll;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.Label lblRoll;
    }
}