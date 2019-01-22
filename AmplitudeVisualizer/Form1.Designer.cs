namespace AmplitudeVisualizer
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this._cbDevices = new System.Windows.Forms.ComboBox();
            this._leftPanel = new System.Windows.Forms.Panel();
            this._rightPanel = new System.Windows.Forms.Panel();
            this._TickTimer = new System.Windows.Forms.Timer(this.components);
            this._trbMultiplicator = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this._trbMultiplicator)).BeginInit();
            this.SuspendLayout();
            // 
            // _cbDevices
            // 
            this._cbDevices.FormattingEnabled = true;
            this._cbDevices.Location = new System.Drawing.Point(12, 12);
            this._cbDevices.Name = "_cbDevices";
            this._cbDevices.Size = new System.Drawing.Size(193, 21);
            this._cbDevices.TabIndex = 0;
            // 
            // _leftPanel
            // 
            this._leftPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this._leftPanel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this._leftPanel.Location = new System.Drawing.Point(0, 90);
            this._leftPanel.Name = "_leftPanel";
            this._leftPanel.Size = new System.Drawing.Size(100, 353);
            this._leftPanel.TabIndex = 1;
            this._leftPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.onLeftPanelPaint);
            // 
            // _rightPanel
            // 
            this._rightPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._rightPanel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this._rightPanel.Location = new System.Drawing.Point(114, 90);
            this._rightPanel.Name = "_rightPanel";
            this._rightPanel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._rightPanel.Size = new System.Drawing.Size(100, 353);
            this._rightPanel.TabIndex = 2;
            this._rightPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.onRightPanelPaint);
            // 
            // _TickTimer
            // 
            this._TickTimer.Tick += new System.EventHandler(this.OnTimerTIck);
            // 
            // _trbMultiplicator
            // 
            this._trbMultiplicator.Location = new System.Drawing.Point(16, 40);
            this._trbMultiplicator.Minimum = 1;
            this._trbMultiplicator.Name = "_trbMultiplicator";
            this._trbMultiplicator.Size = new System.Drawing.Size(186, 45);
            this._trbMultiplicator.TabIndex = 5;
            this._trbMultiplicator.Value = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(214, 451);
            this.Controls.Add(this._trbMultiplicator);
            this.Controls.Add(this._rightPanel);
            this.Controls.Add(this._leftPanel);
            this.Controls.Add(this._cbDevices);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Resize += new System.EventHandler(this.OnFormResize);
            ((System.ComponentModel.ISupportInitialize)(this._trbMultiplicator)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox _cbDevices;
        private System.Windows.Forms.Panel _leftPanel;
        private System.Windows.Forms.Panel _rightPanel;
        private System.Windows.Forms.Timer _TickTimer;
        private System.Windows.Forms.TrackBar _trbMultiplicator;
    }
}

