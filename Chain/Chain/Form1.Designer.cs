
namespace Chain
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelT = new System.Windows.Forms.Label();
            this.labeln = new System.Windows.Forms.Label();
            this.labelpsi = new System.Windows.Forms.Label();
            this.labeltipperedachi = new System.Windows.Forms.Label();
            this.labelcharactnagr = new System.Windows.Forms.Label();
            this.labelWayofreg = new System.Windows.Forms.Label();
            this.labelcharofsmaz = new System.Windows.Forms.Label();
            this.labelRezhRab = new System.Windows.Forms.Label();
            this.textBoxT = new System.Windows.Forms.TextBox();
            this.textBoxn = new System.Windows.Forms.TextBox();
            this.textBoxpsi = new System.Windows.Forms.TextBox();
            this.textBoxTipPer = new System.Windows.Forms.TextBox();
            this.textBoxHarNagr = new System.Windows.Forms.TextBox();
            this.textBoxRegNat = new System.Windows.Forms.TextBox();
            this.textBoxHarOfSmaz = new System.Windows.Forms.TextBox();
            this.textBoxRezhRab = new System.Windows.Forms.TextBox();
            this.labelOut = new System.Windows.Forms.Label();
            this.labelOuti = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.labeli = new System.Windows.Forms.Label();
            this.textBoxi = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelT
            // 
            this.labelT.AutoSize = true;
            this.labelT.Location = new System.Drawing.Point(12, 9);
            this.labelT.Name = "labelT";
            this.labelT.Size = new System.Drawing.Size(335, 13);
            this.labelT.TabIndex = 0;
            this.labelT.Text = "Вращающий момент на валу ведущей (малой) звёздочки T1,Нм:";
            this.labelT.Click += new System.EventHandler(this.labelT_Click);
            // 
            // labeln
            // 
            this.labeln.AutoSize = true;
            this.labeln.Location = new System.Drawing.Point(9, 48);
            this.labeln.Name = "labeln";
            this.labeln.Size = new System.Drawing.Size(309, 13);
            this.labeln.TabIndex = 1;
            this.labeln.Text = "Круговая частота вращения ведущей звёздочки n1,мин^-1:";
            // 
            // labelpsi
            // 
            this.labelpsi.AutoSize = true;
            this.labelpsi.Location = new System.Drawing.Point(8, 126);
            this.labelpsi.Name = "labelpsi";
            this.labelpsi.Size = new System.Drawing.Size(369, 13);
            this.labelpsi.TabIndex = 2;
            this.labelpsi.Text = "Угол расположения линии центров передачи к горизонту ψ,град (0-90):";
            // 
            // labeltipperedachi
            // 
            this.labeltipperedachi.AutoSize = true;
            this.labeltipperedachi.Location = new System.Drawing.Point(8, 165);
            this.labeltipperedachi.Name = "labeltipperedachi";
            this.labeltipperedachi.Size = new System.Drawing.Size(254, 13);
            this.labeltipperedachi.TabIndex = 3;
            this.labeltipperedachi.Text = "Тип передачи (открытая или закрытая - 1 или 2):";
            // 
            // labelcharactnagr
            // 
            this.labelcharactnagr.AutoSize = true;
            this.labelcharactnagr.Location = new System.Drawing.Point(8, 204);
            this.labelcharactnagr.Name = "labelcharactnagr";
            this.labelcharactnagr.Size = new System.Drawing.Size(306, 13);
            this.labelcharactnagr.TabIndex = 4;
            this.labelcharactnagr.Text = "Характер нагрузки (постоянная или переменная - 1 или 2):";
            // 
            // labelWayofreg
            // 
            this.labelWayofreg.AutoSize = true;
            this.labelWayofreg.Location = new System.Drawing.Point(8, 243);
            this.labelWayofreg.Name = "labelWayofreg";
            this.labelWayofreg.Size = new System.Drawing.Size(527, 13);
            this.labelWayofreg.TabIndex = 5;
            this.labelWayofreg.Text = "Способ регулировки натяжения (смещение звездочки,оттяжная звездочка, нажимной рол" +
    "ик - 1, 2, 3):";
            // 
            // labelcharofsmaz
            // 
            this.labelcharofsmaz.AutoSize = true;
            this.labelcharofsmaz.Location = new System.Drawing.Point(8, 282);
            this.labelcharofsmaz.Name = "labelcharofsmaz";
            this.labelcharofsmaz.Size = new System.Drawing.Size(387, 13);
            this.labelcharofsmaz.TabIndex = 6;
            this.labelcharofsmaz.Text = "Характер смазывания (непрерывный, регулярный, нерегулярный - 1, 2, 3):";
            // 
            // labelRezhRab
            // 
            this.labelRezhRab.AutoSize = true;
            this.labelRezhRab.Location = new System.Drawing.Point(8, 321);
            this.labelRezhRab.Name = "labelRezhRab";
            this.labelRezhRab.Size = new System.Drawing.Size(351, 13);
            this.labelRezhRab.TabIndex = 7;
            this.labelRezhRab.Text = "Режим работы (односменный, двухсменный, трехсменный - 1, 2, 3):";
            // 
            // textBoxT
            // 
            this.textBoxT.Location = new System.Drawing.Point(12, 25);
            this.textBoxT.Name = "textBoxT";
            this.textBoxT.Size = new System.Drawing.Size(100, 20);
            this.textBoxT.TabIndex = 8;
            this.textBoxT.TextChanged += new System.EventHandler(this.textBoxT_TextChanged);
            // 
            // textBoxn
            // 
            this.textBoxn.Location = new System.Drawing.Point(12, 64);
            this.textBoxn.Name = "textBoxn";
            this.textBoxn.Size = new System.Drawing.Size(100, 20);
            this.textBoxn.TabIndex = 9;
            this.textBoxn.TextChanged += new System.EventHandler(this.textBoxn_TextChanged);
            // 
            // textBoxpsi
            // 
            this.textBoxpsi.Location = new System.Drawing.Point(11, 142);
            this.textBoxpsi.Name = "textBoxpsi";
            this.textBoxpsi.Size = new System.Drawing.Size(100, 20);
            this.textBoxpsi.TabIndex = 10;
            this.textBoxpsi.TextChanged += new System.EventHandler(this.textBoxpsi_TextChanged);
            // 
            // textBoxTipPer
            // 
            this.textBoxTipPer.Location = new System.Drawing.Point(11, 181);
            this.textBoxTipPer.Name = "textBoxTipPer";
            this.textBoxTipPer.Size = new System.Drawing.Size(100, 20);
            this.textBoxTipPer.TabIndex = 11;
            this.textBoxTipPer.TextChanged += new System.EventHandler(this.textBoxTipPer_TextChanged);
            // 
            // textBoxHarNagr
            // 
            this.textBoxHarNagr.Location = new System.Drawing.Point(11, 220);
            this.textBoxHarNagr.Name = "textBoxHarNagr";
            this.textBoxHarNagr.Size = new System.Drawing.Size(100, 20);
            this.textBoxHarNagr.TabIndex = 12;
            this.textBoxHarNagr.TextChanged += new System.EventHandler(this.textBoxCharNagr_TextChanged);
            // 
            // textBoxRegNat
            // 
            this.textBoxRegNat.Location = new System.Drawing.Point(11, 259);
            this.textBoxRegNat.Name = "textBoxRegNat";
            this.textBoxRegNat.Size = new System.Drawing.Size(100, 20);
            this.textBoxRegNat.TabIndex = 13;
            this.textBoxRegNat.TextChanged += new System.EventHandler(this.textBoxWayOfReg_TextChanged);
            // 
            // textBoxHarOfSmaz
            // 
            this.textBoxHarOfSmaz.Location = new System.Drawing.Point(11, 298);
            this.textBoxHarOfSmaz.Name = "textBoxHarOfSmaz";
            this.textBoxHarOfSmaz.Size = new System.Drawing.Size(101, 20);
            this.textBoxHarOfSmaz.TabIndex = 14;
            this.textBoxHarOfSmaz.TextChanged += new System.EventHandler(this.textBoxCharOfSma_TextChanged);
            // 
            // textBoxRezhRab
            // 
            this.textBoxRezhRab.Location = new System.Drawing.Point(11, 337);
            this.textBoxRezhRab.Name = "textBoxRezhRab";
            this.textBoxRezhRab.Size = new System.Drawing.Size(100, 20);
            this.textBoxRezhRab.TabIndex = 15;
            this.textBoxRezhRab.TextChanged += new System.EventHandler(this.textBoxRezhRab_TextChanged);
            // 
            // labelOut
            // 
            this.labelOut.AutoSize = true;
            this.labelOut.Location = new System.Drawing.Point(197, 424);
            this.labelOut.Name = "labelOut";
            this.labelOut.Size = new System.Drawing.Size(206, 13);
            this.labelOut.TabIndex = 17;
            this.labelOut.Text = "Итоговые параметры цепной передачи";
            // 
            // labelOuti
            // 
            this.labelOuti.AutoSize = true;
            this.labelOuti.Location = new System.Drawing.Point(9, 461);
            this.labelOuti.Name = "labelOuti";
            this.labelOuti.Size = new System.Drawing.Size(0, 13);
            this.labelOuti.TabIndex = 18;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(234, 387);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(133, 23);
            this.button1.TabIndex = 19;
            this.button1.Text = "Нажми для рассчета";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // labeli
            // 
            this.labeli.AutoSize = true;
            this.labeli.Location = new System.Drawing.Point(9, 87);
            this.labeli.Name = "labeli";
            this.labeli.Size = new System.Drawing.Size(140, 13);
            this.labeli.TabIndex = 20;
            this.labeli.Text = "Передаточное отношение:";
            // 
            // textBoxi
            // 
            this.textBoxi.Location = new System.Drawing.Point(11, 103);
            this.textBoxi.Name = "textBoxi";
            this.textBoxi.Size = new System.Drawing.Size(100, 20);
            this.textBoxi.TabIndex = 21;
            this.textBoxi.TextChanged += new System.EventHandler(this.textBoxi_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 634);
            this.Controls.Add(this.textBoxi);
            this.Controls.Add(this.labeli);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labelOuti);
            this.Controls.Add(this.labelOut);
            this.Controls.Add(this.textBoxRezhRab);
            this.Controls.Add(this.textBoxHarOfSmaz);
            this.Controls.Add(this.textBoxRegNat);
            this.Controls.Add(this.textBoxHarNagr);
            this.Controls.Add(this.textBoxTipPer);
            this.Controls.Add(this.textBoxpsi);
            this.Controls.Add(this.textBoxn);
            this.Controls.Add(this.textBoxT);
            this.Controls.Add(this.labelRezhRab);
            this.Controls.Add(this.labelcharofsmaz);
            this.Controls.Add(this.labelWayofreg);
            this.Controls.Add(this.labelcharactnagr);
            this.Controls.Add(this.labeltipperedachi);
            this.Controls.Add(this.labelpsi);
            this.Controls.Add(this.labeln);
            this.Controls.Add(this.labelT);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelT;
        private System.Windows.Forms.Label labeln;
        private System.Windows.Forms.Label labelpsi;
        private System.Windows.Forms.Label labeltipperedachi;
        private System.Windows.Forms.Label labelcharactnagr;
        private System.Windows.Forms.Label labelWayofreg;
        private System.Windows.Forms.Label labelcharofsmaz;
        private System.Windows.Forms.Label labelRezhRab;
        private System.Windows.Forms.TextBox textBoxT;
        private System.Windows.Forms.TextBox textBoxn;
        private System.Windows.Forms.TextBox textBoxpsi;
        private System.Windows.Forms.TextBox textBoxTipPer;
        private System.Windows.Forms.TextBox textBoxHarNagr;
        private System.Windows.Forms.TextBox textBoxRegNat;
        private System.Windows.Forms.TextBox textBoxHarOfSmaz;
        private System.Windows.Forms.TextBox textBoxRezhRab;
        private System.Windows.Forms.Label labelOut;
        private System.Windows.Forms.Label labelOuti;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label labeli;
        private System.Windows.Forms.TextBox textBoxi;
    }
}

