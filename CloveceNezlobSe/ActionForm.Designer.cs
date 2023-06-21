using System.ComponentModel;

namespace BroNezlobSe;

partial class ActionForm
{
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private IContainer components = null;

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
            this.label1 = new System.Windows.Forms.Label();
            this._btnMoveN1 = new System.Windows.Forms.Button();
            this._lblThrowNumber = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this._lblPlayerColor = new System.Windows.Forms.Label();
            this._btnMoveN2 = new System.Windows.Forms.Button();
            this._btnMoveN3 = new System.Windows.Forms.Button();
            this._btnMoveN4 = new System.Windows.Forms.Button();
            this._btnDeployFigurine = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(25, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Padlo číslo:";
            // 
            // _btnMoveN1
            // 
            this._btnMoveN1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this._btnMoveN1.Location = new System.Drawing.Point(12, 96);
            this._btnMoveN1.Name = "_btnMoveN1";
            this._btnMoveN1.Size = new System.Drawing.Size(129, 66);
            this._btnMoveN1.TabIndex = 2;
            this._btnMoveN1.Text = "Posun číslem 1";
            this._btnMoveN1.UseVisualStyleBackColor = true;
            this._btnMoveN1.Click += new System.EventHandler(this._btnMoveN1_Click);
            // 
            // _lblThrowNumber
            // 
            this._lblThrowNumber.AutoSize = true;
            this._lblThrowNumber.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this._lblThrowNumber.Location = new System.Drawing.Point(180, 46);
            this._lblThrowNumber.Name = "_lblThrowNumber";
            this._lblThrowNumber.Size = new System.Drawing.Size(50, 37);
            this._lblThrowNumber.TabIndex = 7;
            this._lblThrowNumber.Text = "---";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(175, 37);
            this.label2.TabIndex = 8;
            this.label2.Text = "Hraje barva:";
            // 
            // _lblPlayerColor
            // 
            this._lblPlayerColor.AutoSize = true;
            this._lblPlayerColor.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this._lblPlayerColor.Location = new System.Drawing.Point(180, 9);
            this._lblPlayerColor.Name = "_lblPlayerColor";
            this._lblPlayerColor.Size = new System.Drawing.Size(50, 37);
            this._lblPlayerColor.TabIndex = 9;
            this._lblPlayerColor.Text = "---";
            // 
            // _btnMoveN2
            // 
            this._btnMoveN2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this._btnMoveN2.Location = new System.Drawing.Point(160, 96);
            this._btnMoveN2.Name = "_btnMoveN2";
            this._btnMoveN2.Size = new System.Drawing.Size(129, 66);
            this._btnMoveN2.TabIndex = 10;
            this._btnMoveN2.Text = "Posun číslem 2";
            this._btnMoveN2.UseVisualStyleBackColor = true;
            this._btnMoveN2.Click += new System.EventHandler(this._btnMoveN2_Click);
            // 
            // _btnMoveN3
            // 
            this._btnMoveN3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this._btnMoveN3.Location = new System.Drawing.Point(308, 96);
            this._btnMoveN3.Name = "_btnMoveN3";
            this._btnMoveN3.Size = new System.Drawing.Size(129, 66);
            this._btnMoveN3.TabIndex = 11;
            this._btnMoveN3.Text = "Posun číslem 3";
            this._btnMoveN3.UseVisualStyleBackColor = true;
            this._btnMoveN3.Click += new System.EventHandler(this._btnMoveN3_Click);
            // 
            // _btnMoveN4
            // 
            this._btnMoveN4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this._btnMoveN4.Location = new System.Drawing.Point(457, 96);
            this._btnMoveN4.Name = "_btnMoveN4";
            this._btnMoveN4.Size = new System.Drawing.Size(129, 66);
            this._btnMoveN4.TabIndex = 12;
            this._btnMoveN4.Text = "Posun číslem 4";
            this._btnMoveN4.UseVisualStyleBackColor = true;
            this._btnMoveN4.Click += new System.EventHandler(this._btnMoveN4_Click);
            // 
            // _btnDeployFigurine
            // 
            this._btnDeployFigurine.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this._btnDeployFigurine.Location = new System.Drawing.Point(609, 96);
            this._btnDeployFigurine.Name = "_btnDeployFigurine";
            this._btnDeployFigurine.Size = new System.Drawing.Size(129, 66);
            this._btnDeployFigurine.TabIndex = 13;
            this._btnDeployFigurine.Text = "Nasadit figurku";
            this._btnDeployFigurine.UseVisualStyleBackColor = true;
            this._btnDeployFigurine.Click += new System.EventHandler(this._btnDeployFigurine_Click);
            // 
            // ActionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(753, 176);
            this.Controls.Add(this._btnDeployFigurine);
            this.Controls.Add(this._btnMoveN4);
            this.Controls.Add(this._btnMoveN3);
            this.Controls.Add(this._btnMoveN2);
            this.Controls.Add(this._lblPlayerColor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this._lblThrowNumber);
            this.Controls.Add(this._btnMoveN1);
            this.Controls.Add(this.label1);
            this.Name = "ActionForm";
            this.Text = "ActionForm";
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion

    private Label label1;
    private Button _btnMoveN1;
    private Label _lblThrowNumber;
    private Label label2;
    private Label _lblPlayerColor;
    private Button _btnMoveN2;
    private Button _btnMoveN3;
    private Button _btnMoveN4;
    private Button _btnDeployFigurine;
}