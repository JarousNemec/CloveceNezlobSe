namespace BroNezlobSe;

partial class Form1
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
            this._btnThrow = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // _btnThrow
            // 
            this._btnThrow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this._btnThrow.Location = new System.Drawing.Point(453, 971);
            this._btnThrow.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this._btnThrow.Name = "_btnThrow";
            this._btnThrow.Size = new System.Drawing.Size(86, 71);
            this._btnThrow.TabIndex = 0;
            this._btnThrow.Text = "Hodit";
            this._btnThrow.UseVisualStyleBackColor = true;
            this._btnThrow.Click += new System.EventHandler(this._btnThrow_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 1055);
            this.Controls.Add(this._btnThrow);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.ResumeLayout(false);

    }

    #endregion

    private Button _btnThrow;
}