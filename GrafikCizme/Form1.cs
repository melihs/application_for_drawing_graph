using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZedGraph;//zend graph using e eklendi
namespace GrafikCizme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        #region//değişkenler
        GraphPane grafik;
        int k1, k2, k3, sayac;
        bool hata, hataSil = true;
        #endregion
        #region //çiz butonu
        private void btnCiz_Click(object sender, EventArgs e)
        {
            if (txtXkatsayi.Text == "" || txtYkatsayi.Text == "" || txtSabitSayi.Text == "")
            {
                MessageBox.Show("BOŞ ALANLARI DOLDURUN!", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                try
                {
                    double[] x = new double[10];
                    double[] y = new double[10];

                    k3 = Convert.ToInt32(txtSabitSayi.Text);
                    k1 = Convert.ToInt32(txtXkatsayi.Text);
                    k2 = Convert.ToInt32(txtYkatsayi.Text);
                    //k1 sıfır olma durumu
                    if (k1 == 0)
                    {
                        x[0] = 0.0d;
                        switch (cmbIslem.Text)
                        {
                            case "+":
                                y[0] = Convert.ToDouble(k3 / (k2 * 1));
                                break;
                            case "-":
                                y[0] = Convert.ToDouble(k3 / (k2 * (-1)));
                                break;
                            default: break;
                        }
                    }
                    else if (k2 == 0)
                    {
                        x[0] = Convert.ToDouble(k3 / k1);
                        y[0] = 0.0d;
                        hataSil = false;
                    }
                    else
                    {
                        x[0] = Convert.ToDouble(k3 / k1);

                        switch (cmbIslem.Text)
                        {
                            case "+":
                                y[0] = Convert.ToDouble(k3 / (k2 * 1));
                                break;
                            case "-":
                                y[0] = Convert.ToDouble(k3 / (k2 * (-1)));
                                break;
                            default: break;
                        }
                    }
                    // eğriler, GraphPane classından oluşturalan grafik nesnesinde tutulacak
                    grafik = zedPanel.GraphPane;

                    //x ve y değerlerini tutan nesnemizin classı PointPairList'tir
                    PointPairList koordinat = new PointPairList(x, y);

                    //grafik eğrimizi grafik adlı nesnemize atıyoruz
                    //mycurve=benim eğrim
                    LineItem mycurve = grafik.AddCurve("2 bilinmeyenli denklem grafiği", koordinat, Color.Red, SymbolType.None);
                    mycurve.Line.Width = 2f;

                    //grafiğimizin etiketlerini düzenleyelim
                    grafik.Title.Text = "2 BİLİNMEYENLİ DENKLEMİN GRAFİĞİ";
                    grafik.XAxis.Title.Text = "x değeri";
                    grafik.YAxis.Title.Text = "Y değeri";
                    //lbSonuc yazısını ekrana yazdırma  
                    lbSonuc.Text = k1 + "X" + cmbIslem.Text + "" + k2 + "Y=" + k3;
                    string[] yazilar = new string[1];
                    sayac++;
                    for (int i = 0; i < yazilar.Length; i++)
                    {
                        yazilar[i] = sayac + ".Denklem: " + lbSonuc.Text;
                    }
                    listFormuller.Items.AddRange(yazilar);

                    zedPanel.AxisChange();
                    zedPanel.Invalidate();
                    zedPanel.Refresh();
                }
                catch
                {
                    MessageBox.Show("SINIR VERİ GERİŞİNİ AŞTINIZ!!", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    hata = true;
                }
            }
            hataSil = false;
        }
        #endregion
        #region //silme butonu
        private void btnSil_Click(object sender, EventArgs e)
        {
            if (hataSil != true)
            {
                //hata kontrolü
                if (hata == true)
                {
                    txtSabitSayi.Clear();
                    txtXkatsayi.Clear();
                    txtYkatsayi.Clear();
                    lbSonuc.ResetText();
                }
                else
                {
                    //eğri listesini temizle ve grafiği yenile
                    grafik.CurveList.Clear();

                    txtSabitSayi.Clear();
                    txtXkatsayi.Clear();
                    txtYkatsayi.Clear();
                    lbSonuc.ResetText();
                    zedPanel.Refresh();
                }
            }
        }
        #endregion
        #region//formload
        private void Form1_Load(object sender, EventArgs e)
        {
            //SelectedIndex property sini 0 yaparak comboboxın program açılışında(formload kısmına kodu yazdığım için)0 .indeksteki seçenek, seçili olarak açılır.
            cmbIslem.SelectedIndex = 0;
        }
#endregion
        #region //textboxtların giriş kontrolleri
        private void txtXkatsayi_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = char.IsLetter(e.KeyChar);
        }
        private void cmbIslem_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = char.IsLetterOrDigit(e.KeyChar);
        }
        private void txtYkatsayi_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = char.IsLetter(e.KeyChar);
        }
        private void txtSabitSayi_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = char.IsLetter(e.KeyChar);
        }
        private void txtXkatsayi_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            e.Handled = char.IsLetter(e.KeyChar);
        }
        #endregion
    }
}