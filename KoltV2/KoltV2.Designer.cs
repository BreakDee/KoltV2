namespace KoltV2
{
    partial class KoltV2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KoltV2));
            this.panel = new System.Windows.Forms.Panel();
            this.minimize = new System.Windows.Forms.Button();
            this.close_btn = new System.Windows.Forms.Button();
            this.window_name = new System.Windows.Forms.Label();
            this.icon = new System.Windows.Forms.Label();
            this.Execute = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.open_file = new System.Windows.Forms.Button();
            this.save_file = new System.Windows.Forms.Button();
            this.attach = new System.Windows.Forms.Button();
            this.inputscript = new FastColoredTextBoxNS.FastColoredTextBox();
            this.scripts = new System.Windows.Forms.ListBox();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inputscript)).BeginInit();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(60)))), ((int)(((byte)(55)))));
            this.panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel.Controls.Add(this.minimize);
            this.panel.Controls.Add(this.close_btn);
            this.panel.Controls.Add(this.window_name);
            this.panel.Controls.Add(this.icon);
            this.panel.Location = new System.Drawing.Point(1, 1);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(799, 44);
            this.panel.TabIndex = 0;
            this.panel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_MouseDown);
            this.panel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel_MouseMove);
            // 
            // minimize
            // 
            this.minimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.minimize.ForeColor = System.Drawing.Color.Black;
            this.minimize.Location = new System.Drawing.Point(734, 4);
            this.minimize.Name = "minimize";
            this.minimize.Size = new System.Drawing.Size(23, 23);
            this.minimize.TabIndex = 3;
            this.minimize.Text = "-";
            this.minimize.UseVisualStyleBackColor = true;
            this.minimize.Click += new System.EventHandler(this.minimize_Click);
            // 
            // close_btn
            // 
            this.close_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.close_btn.ForeColor = System.Drawing.Color.Black;
            this.close_btn.Location = new System.Drawing.Point(763, 4);
            this.close_btn.Name = "close_btn";
            this.close_btn.Size = new System.Drawing.Size(23, 23);
            this.close_btn.TabIndex = 2;
            this.close_btn.Text = "X";
            this.close_btn.UseVisualStyleBackColor = true;
            this.close_btn.Click += new System.EventHandler(this.close_btn_Click);
            // 
            // window_name
            // 
            this.window_name.AutoSize = true;
            this.window_name.Font = new System.Drawing.Font("Cambria", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.window_name.Location = new System.Drawing.Point(310, 4);
            this.window_name.Name = "window_name";
            this.window_name.Size = new System.Drawing.Size(192, 32);
            this.window_name.TabIndex = 1;
            this.window_name.Text = "Enter text here";
            // 
            // icon
            // 
            this.icon.AutoSize = true;
            this.icon.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.icon.ForeColor = System.Drawing.Color.Honeydew;
            this.icon.Location = new System.Drawing.Point(3, 4);
            this.icon.Name = "icon";
            this.icon.Size = new System.Drawing.Size(29, 32);
            this.icon.TabIndex = 0;
            this.icon.Text = "e";
            // 
            // Execute
            // 
            this.Execute.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Execute.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Execute.ForeColor = System.Drawing.Color.Black;
            this.Execute.Location = new System.Drawing.Point(10, 400);
            this.Execute.Name = "Execute";
            this.Execute.Size = new System.Drawing.Size(112, 38);
            this.Execute.TabIndex = 1;
            this.Execute.Text = "Execute";
            this.Execute.UseVisualStyleBackColor = true;
            this.Execute.Click += new System.EventHandler(this.Execute_Click);
            // 
            // clear
            // 
            this.clear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clear.ForeColor = System.Drawing.Color.Black;
            this.clear.Location = new System.Drawing.Point(128, 400);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(112, 38);
            this.clear.TabIndex = 2;
            this.clear.Text = "Clear";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // open_file
            // 
            this.open_file.Cursor = System.Windows.Forms.Cursors.Hand;
            this.open_file.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.open_file.ForeColor = System.Drawing.Color.Black;
            this.open_file.Location = new System.Drawing.Point(246, 400);
            this.open_file.Name = "open_file";
            this.open_file.Size = new System.Drawing.Size(112, 38);
            this.open_file.TabIndex = 3;
            this.open_file.Text = "Open File";
            this.open_file.UseVisualStyleBackColor = true;
            this.open_file.Click += new System.EventHandler(this.open_file_Click);
            // 
            // save_file
            // 
            this.save_file.Cursor = System.Windows.Forms.Cursors.Hand;
            this.save_file.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.save_file.ForeColor = System.Drawing.Color.Black;
            this.save_file.Location = new System.Drawing.Point(364, 400);
            this.save_file.Name = "save_file";
            this.save_file.Size = new System.Drawing.Size(112, 38);
            this.save_file.TabIndex = 4;
            this.save_file.Text = "Save File";
            this.save_file.UseVisualStyleBackColor = true;
            this.save_file.Click += new System.EventHandler(this.save_file_Click);
            // 
            // attach
            // 
            this.attach.Cursor = System.Windows.Forms.Cursors.Hand;
            this.attach.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.attach.ForeColor = System.Drawing.Color.Black;
            this.attach.Location = new System.Drawing.Point(676, 400);
            this.attach.Name = "attach";
            this.attach.Size = new System.Drawing.Size(112, 38);
            this.attach.TabIndex = 6;
            this.attach.Text = "Attach";
            this.attach.UseVisualStyleBackColor = true;
            this.attach.Click += new System.EventHandler(this.attach_Click);
            // 
            // inputscript
            // 
            this.inputscript.AutoCompleteBrackets = true;
            this.inputscript.AutoCompleteBracketsList = new char[] {
        '(',
        ')',
        '{',
        '}',
        '[',
        ']',
        '\"',
        '\"',
        '\'',
        '\''};
            this.inputscript.AutoIndentCharsPatterns = "\r\n^\\s*[\\w\\.]+(\\s\\w+)?\\s*(?<range>=)\\s*(?<range>.+)\r\n";
            this.inputscript.AutoScrollMinSize = new System.Drawing.Size(31, 18);
            this.inputscript.BackBrush = null;
            this.inputscript.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.inputscript.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.inputscript.BracketsHighlightStrategy = FastColoredTextBoxNS.BracketsHighlightStrategy.Strategy2;
            this.inputscript.CharHeight = 18;
            this.inputscript.CharWidth = 10;
            this.inputscript.CommentPrefix = "--";
            this.inputscript.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.inputscript.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.inputscript.Font = new System.Drawing.Font("Courier New", 12F);
            this.inputscript.IndentBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(65)))), ((int)(((byte)(60)))));
            this.inputscript.IsReplaceMode = false;
            this.inputscript.Language = FastColoredTextBoxNS.Language.Lua;
            this.inputscript.LeftBracket = '(';
            this.inputscript.LeftBracket2 = '{';
            this.inputscript.Location = new System.Drawing.Point(10, 51);
            this.inputscript.Name = "inputscript";
            this.inputscript.Paddings = new System.Windows.Forms.Padding(0);
            this.inputscript.RightBracket = ')';
            this.inputscript.RightBracket2 = '}';
            this.inputscript.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.inputscript.ServiceColors = ((FastColoredTextBoxNS.ServiceColors)(resources.GetObject("inputscript.ServiceColors")));
            this.inputscript.ServiceLinesColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.inputscript.Size = new System.Drawing.Size(660, 343);
            this.inputscript.TabIndex = 7;
            this.inputscript.Zoom = 100;
            this.inputscript.Load += new System.EventHandler(this.inputscript_Load);
            // 
            // scripts
            // 
            this.scripts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.scripts.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.scripts.Cursor = System.Windows.Forms.Cursors.Default;
            this.scripts.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scripts.FormattingEnabled = true;
            this.scripts.ItemHeight = 16;
            this.scripts.Location = new System.Drawing.Point(676, 51);
            this.scripts.Name = "scripts";
            this.scripts.Size = new System.Drawing.Size(120, 338);
            this.scripts.TabIndex = 8;
            // 
            // KoltV2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.scripts);
            this.Controls.Add(this.inputscript);
            this.Controls.Add(this.attach);
            this.Controls.Add(this.save_file);
            this.Controls.Add(this.open_file);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.Execute);
            this.Controls.Add(this.panel);
            this.ForeColor = System.Drawing.Color.DimGray;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "KoltV2";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Kolt_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.KoltV2_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.KoltV2_MouseMove);
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inputscript)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Label window_name;
        private System.Windows.Forms.Label icon;
        private System.Windows.Forms.Button Execute;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Button open_file;
        private System.Windows.Forms.Button save_file;
        private System.Windows.Forms.Button attach;
        private FastColoredTextBoxNS.FastColoredTextBox inputscript;
        private System.Windows.Forms.ListBox scripts;
        private System.Windows.Forms.Button minimize;
        private System.Windows.Forms.Button close_btn;
    }
}

