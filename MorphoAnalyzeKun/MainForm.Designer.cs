namespace MorphoAnalyzeKun
{
    partial class AnalyzeForm
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.fileSelectTextBox = new System.Windows.Forms.TextBox();
            this.fileSelectLabel = new System.Windows.Forms.Label();
            this.fileSelectBtn = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.execAnalyzeBtn = new System.Windows.Forms.Button();
            this.analyzeResultDGV = new System.Windows.Forms.DataGridView();
            this.clearBtn = new System.Windows.Forms.Button();
            this.MeishiCheckBox = new System.Windows.Forms.CheckBox();
            this.DoushiCheckBox = new System.Windows.Forms.CheckBox();
            this.KeiyoushiCheckBox = new System.Windows.Forms.CheckBox();
            this.FukushiCheckBox = new System.Windows.Forms.CheckBox();
            this.JoshiCheckBox = new System.Windows.Forms.CheckBox();
            this.HinshiGroupBox = new System.Windows.Forms.GroupBox();
            this.JodoushiCheckBox = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.analyzeResultDGV)).BeginInit();
            this.HinshiGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // fileSelectTextBox
            // 
            this.fileSelectTextBox.Location = new System.Drawing.Point(12, 26);
            this.fileSelectTextBox.Name = "fileSelectTextBox";
            this.fileSelectTextBox.Size = new System.Drawing.Size(437, 19);
            this.fileSelectTextBox.TabIndex = 0;
            this.fileSelectTextBox.UseWaitCursor = true;
            // 
            // fileSelectLabel
            // 
            this.fileSelectLabel.AutoSize = true;
            this.fileSelectLabel.Location = new System.Drawing.Point(12, 10);
            this.fileSelectLabel.Name = "fileSelectLabel";
            this.fileSelectLabel.Size = new System.Drawing.Size(72, 12);
            this.fileSelectLabel.TabIndex = 1;
            this.fileSelectLabel.Text = "ファイルを選択";
            this.fileSelectLabel.UseWaitCursor = true;
            // 
            // fileSelectBtn
            // 
            this.fileSelectBtn.Location = new System.Drawing.Point(455, 26);
            this.fileSelectBtn.Name = "fileSelectBtn";
            this.fileSelectBtn.Size = new System.Drawing.Size(58, 19);
            this.fileSelectBtn.TabIndex = 2;
            this.fileSelectBtn.Text = "選択";
            this.fileSelectBtn.UseVisualStyleBackColor = true;
            this.fileSelectBtn.UseWaitCursor = true;
            this.fileSelectBtn.Click += new System.EventHandler(this.FileSelectBtn_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // execAnalyzeBtn
            // 
            this.execAnalyzeBtn.Location = new System.Drawing.Point(11, 57);
            this.execAnalyzeBtn.Name = "execAnalyzeBtn";
            this.execAnalyzeBtn.Size = new System.Drawing.Size(173, 39);
            this.execAnalyzeBtn.TabIndex = 3;
            this.execAnalyzeBtn.Text = "解析実行";
            this.execAnalyzeBtn.UseVisualStyleBackColor = true;
            this.execAnalyzeBtn.UseWaitCursor = true;
            this.execAnalyzeBtn.Click += new System.EventHandler(this.ExecAnalyzeBtn_Click);
            // 
            // analyzeResultDGV
            // 
            this.analyzeResultDGV.AllowUserToAddRows = false;
            this.analyzeResultDGV.AllowUserToDeleteRows = false;
            this.analyzeResultDGV.AllowUserToOrderColumns = true;
            this.analyzeResultDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.analyzeResultDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.analyzeResultDGV.Location = new System.Drawing.Point(12, 102);
            this.analyzeResultDGV.Name = "analyzeResultDGV";
            this.analyzeResultDGV.ReadOnly = true;
            this.analyzeResultDGV.RowTemplate.Height = 21;
            this.analyzeResultDGV.Size = new System.Drawing.Size(776, 357);
            this.analyzeResultDGV.TabIndex = 4;
            this.analyzeResultDGV.UseWaitCursor = true;
            // 
            // clearBtn
            // 
            this.clearBtn.Location = new System.Drawing.Point(190, 57);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(173, 39);
            this.clearBtn.TabIndex = 5;
            this.clearBtn.Text = "結果クリア";
            this.clearBtn.UseVisualStyleBackColor = true;
            this.clearBtn.UseWaitCursor = true;
            this.clearBtn.Click += new System.EventHandler(this.ClearBtn_Click);
            // 
            // MeishiCheckBox
            // 
            this.MeishiCheckBox.AutoSize = true;
            this.MeishiCheckBox.Checked = true;
            this.MeishiCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.MeishiCheckBox.Location = new System.Drawing.Point(11, 18);
            this.MeishiCheckBox.Name = "MeishiCheckBox";
            this.MeishiCheckBox.Size = new System.Drawing.Size(48, 16);
            this.MeishiCheckBox.TabIndex = 6;
            this.MeishiCheckBox.Text = "名詞";
            this.MeishiCheckBox.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.MeishiCheckBox.UseVisualStyleBackColor = true;
            this.MeishiCheckBox.UseWaitCursor = true;
            // 
            // DoushiCheckBox
            // 
            this.DoushiCheckBox.AutoSize = true;
            this.DoushiCheckBox.Checked = true;
            this.DoushiCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.DoushiCheckBox.Location = new System.Drawing.Point(11, 40);
            this.DoushiCheckBox.Name = "DoushiCheckBox";
            this.DoushiCheckBox.Size = new System.Drawing.Size(48, 16);
            this.DoushiCheckBox.TabIndex = 7;
            this.DoushiCheckBox.Text = "動詞";
            this.DoushiCheckBox.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.DoushiCheckBox.UseVisualStyleBackColor = true;
            this.DoushiCheckBox.UseWaitCursor = true;
            // 
            // KeiyoushiCheckBox
            // 
            this.KeiyoushiCheckBox.AutoSize = true;
            this.KeiyoushiCheckBox.Checked = true;
            this.KeiyoushiCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.KeiyoushiCheckBox.Location = new System.Drawing.Point(11, 62);
            this.KeiyoushiCheckBox.Name = "KeiyoushiCheckBox";
            this.KeiyoushiCheckBox.Size = new System.Drawing.Size(60, 16);
            this.KeiyoushiCheckBox.TabIndex = 8;
            this.KeiyoushiCheckBox.Text = "形容詞";
            this.KeiyoushiCheckBox.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.KeiyoushiCheckBox.UseVisualStyleBackColor = true;
            this.KeiyoushiCheckBox.UseWaitCursor = true;
            // 
            // FukushiCheckBox
            // 
            this.FukushiCheckBox.AutoSize = true;
            this.FukushiCheckBox.Location = new System.Drawing.Point(113, 18);
            this.FukushiCheckBox.Name = "FukushiCheckBox";
            this.FukushiCheckBox.Size = new System.Drawing.Size(48, 16);
            this.FukushiCheckBox.TabIndex = 9;
            this.FukushiCheckBox.Text = "副詞";
            this.FukushiCheckBox.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.FukushiCheckBox.UseVisualStyleBackColor = true;
            this.FukushiCheckBox.UseWaitCursor = true;
            // 
            // JoshiCheckBox
            // 
            this.JoshiCheckBox.AutoSize = true;
            this.JoshiCheckBox.Location = new System.Drawing.Point(113, 40);
            this.JoshiCheckBox.Name = "JoshiCheckBox";
            this.JoshiCheckBox.Size = new System.Drawing.Size(48, 16);
            this.JoshiCheckBox.TabIndex = 10;
            this.JoshiCheckBox.Text = "助詞";
            this.JoshiCheckBox.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.JoshiCheckBox.UseVisualStyleBackColor = true;
            this.JoshiCheckBox.UseWaitCursor = true;
            // 
            // HinshiGroupBox
            // 
            this.HinshiGroupBox.Controls.Add(this.JodoushiCheckBox);
            this.HinshiGroupBox.Controls.Add(this.MeishiCheckBox);
            this.HinshiGroupBox.Controls.Add(this.DoushiCheckBox);
            this.HinshiGroupBox.Controls.Add(this.JoshiCheckBox);
            this.HinshiGroupBox.Controls.Add(this.KeiyoushiCheckBox);
            this.HinshiGroupBox.Controls.Add(this.FukushiCheckBox);
            this.HinshiGroupBox.Location = new System.Drawing.Point(561, 11);
            this.HinshiGroupBox.Name = "HinshiGroupBox";
            this.HinshiGroupBox.Size = new System.Drawing.Size(227, 85);
            this.HinshiGroupBox.TabIndex = 12;
            this.HinshiGroupBox.TabStop = false;
            this.HinshiGroupBox.Text = "対象とする品詞";
            this.HinshiGroupBox.UseWaitCursor = true;
            // 
            // JodoushiCheckBox
            // 
            this.JodoushiCheckBox.AutoSize = true;
            this.JodoushiCheckBox.Location = new System.Drawing.Point(113, 62);
            this.JodoushiCheckBox.Name = "JodoushiCheckBox";
            this.JodoushiCheckBox.Size = new System.Drawing.Size(60, 16);
            this.JodoushiCheckBox.TabIndex = 11;
            this.JodoushiCheckBox.Text = "助動詞";
            this.JodoushiCheckBox.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.JodoushiCheckBox.UseVisualStyleBackColor = true;
            this.JodoushiCheckBox.UseWaitCursor = true;
            // 
            // AnalyzeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 471);
            this.Controls.Add(this.HinshiGroupBox);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.analyzeResultDGV);
            this.Controls.Add(this.execAnalyzeBtn);
            this.Controls.Add(this.fileSelectBtn);
            this.Controls.Add(this.fileSelectLabel);
            this.Controls.Add(this.fileSelectTextBox);
            this.Name = "AnalyzeForm";
            this.Text = "形態素解析くん";
            this.UseWaitCursor = true;
            ((System.ComponentModel.ISupportInitialize)(this.analyzeResultDGV)).EndInit();
            this.HinshiGroupBox.ResumeLayout(false);
            this.HinshiGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox fileSelectTextBox;
        private System.Windows.Forms.Label fileSelectLabel;
        private System.Windows.Forms.Button fileSelectBtn;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Button execAnalyzeBtn;
        private System.Windows.Forms.DataGridView analyzeResultDGV;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.CheckBox MeishiCheckBox;
        private System.Windows.Forms.CheckBox DoushiCheckBox;
        private System.Windows.Forms.CheckBox KeiyoushiCheckBox;
        private System.Windows.Forms.CheckBox FukushiCheckBox;
        private System.Windows.Forms.CheckBox JoshiCheckBox;
        private System.Windows.Forms.GroupBox HinshiGroupBox;
        private System.Windows.Forms.CheckBox JodoushiCheckBox;
    }
}

