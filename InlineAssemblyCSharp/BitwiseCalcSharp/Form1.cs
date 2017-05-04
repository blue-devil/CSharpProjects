using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;   //[DllImport] yapabilmek için bu ad alanını tanımlamamız gerekiyor

namespace BitwiseCalcSharp
{
     public partial class frmMain : Form
     {
          //[DLLImport] ile kangi DLL'den hangi fonksiyonu çağıracağımızı burada belirtiyoruz:
          //kernel32 ya da user32 dll'lerinden de fonksiyon çağırabilirsiniz
          //sanırım bu konuyla da ilgili bir örnek yapmak gerekiyor:)
          [DllImport("CalculationDLL.dll")]
          static extern int calcHexAnd(int pOne, int opTwo);
          [DllImport("CalculationDLL.dll")]
          static extern int calcHexOr(int opOne, int opTwo);
          [DllImport("CalculationDLL.dll")]
          static extern int calcHexXor(int opOne, int opTwo);
          [DllImport("CalculationDLL.dll")]
          static extern int calcHexNot(int opOne);
          public frmMain()
          {
               InitializeComponent();
               Text = "[SCT]Inline Asm in C# - 32bit";
               //Kullanıcı capslock açıkda olsa kapalıda olsa txtboxa girdiği değer büyük harf olsun istiyorum
               //textbox için "CharacterCasing" adında bir yordam var bunun "Upper" özelliğini kullanıyorum
               txtHexAnd01.CharacterCasing        = CharacterCasing.Upper;
               txtHexAnd02.CharacterCasing        = CharacterCasing.Upper;
               txtHexAndResult.CharacterCasing    = CharacterCasing.Upper;
               txtHexOr01.CharacterCasing         = CharacterCasing.Upper;
               txtHexOr2.CharacterCasing          = CharacterCasing.Upper;
               txtHexOrResult.CharacterCasing     = CharacterCasing.Upper;
               txtHexXor01.CharacterCasing        = CharacterCasing.Upper;
               txtHexXor02.CharacterCasing        = CharacterCasing.Upper;
               txtHexXorResult.CharacterCasing    = CharacterCasing.Upper;
               txtHexNot.CharacterCasing          = CharacterCasing.Upper;
               txtHexNotResult.CharacterCasing    = CharacterCasing.Upper;
          }

          private void btnHexNot_Click(object sender, EventArgs e)
          {    
               //try-catch blokları hata yakalamama yarıyor, kullanmayı öğrenmenizi şiddetle öneriyorum
               try
               {
                    //içerden dışarı doğru okuyalım:
                    //txtHexNot.text içindeki string değeri Hex(onaltılık) değere dönüştür, bunu sonra ondalığa dönüştür ve
                    //bu onluk sayıyı DLL içindeki fonksiyona sok. fonksiyondan dönen değeri notValueHex değişkenine ata
                    int notValueHex = calcHexNot(Int32.Parse(txtHexNot.Text, System.Globalization.NumberStyles.HexNumber));
                    //"X" in ToString returns UpperCase Hex, "x" -> lowercase
                    //ToString içine "X" yazarak notValueHex içindeki değeri Hexe çevirip string olrak textboxa yazdırıyorum
                    txtHexNotResult.Text = notValueHex.ToString("X");
               }
               catch(DllNotFoundException ex)          //DLL bulunamazsa runtime hatasını mesaj kutusunda göster
               {
                    MessageBox.Show(ex.ToString());
               }
               catch (FormatException ex)               //txtbox'a girilen birşey yoksa hata mesajı göster
               {
                    MessageBox.Show(ex.ToString());
               }
          }
          private void btnHexAnd_Click(object sender, EventArgs e)
          {
               try
               {
                    //int andValue = calcHexAnd(Convert.ToInt32(txtHexAnd01.Text),Convert.ToInt32(txtHexAnd02.Text));
                    int andValueHex = calcHexAnd(Int32.Parse(txtHexAnd01.Text, System.Globalization.NumberStyles.HexNumber), Int32.Parse(txtHexAnd02.Text, System.Globalization.NumberStyles.HexNumber));
                    txtHexAndResult.Text = andValueHex.ToString("X");
               }
               catch(DllNotFoundException ex)          //If our dll is missing pop a messagebox
               {
                    MessageBox.Show(ex.ToString());
               }
               catch(FormatException ex)               //if user forgets to write smth to the textbox pop an error box
               {
                    MessageBox.Show(ex.ToString());
               }
          }

          private void btnHexOr_Click(object sender, EventArgs e)
          {
               try
               {
                    //int orValue = calcHexOr(Convert.ToInt32(txtHexOr01.Text), Convert.ToInt32(txtHexOr2.Text));
                    int orValueHex = calcHexOr(Int32.Parse(txtHexOr01.Text,System.Globalization.NumberStyles.HexNumber), Int32.Parse(txtHexOr2.Text, System.Globalization.NumberStyles.HexNumber));
                    txtHexOrResult.Text = orValueHex.ToString("X");
               }
               catch(DllNotFoundException ex)
               {
                    MessageBox.Show(ex.ToString());
               }
               catch (FormatException ex)
               {
                    MessageBox.Show(ex.ToString());
               }
          }
          private void btnHexXor_Click(object sender, EventArgs e)
          {
               try
               {
                    //int xorValue = calcHexXor(Convert.ToInt32(txtHexXor01.Text), Convert.ToInt32(txtHexXor02.Text));
                    int xorValHex = calcHexXor(Int32.Parse(txtHexXor01.Text, System.Globalization.NumberStyles.HexNumber), Int32.Parse(txtHexXor02.Text, System.Globalization.NumberStyles.HexNumber));
                    txtHexXorResult.Text = xorValHex.ToString("X");
               }
               catch(DllNotFoundException ex)
               {
                    MessageBox.Show(ex.ToString());
               }
               catch (FormatException ex)
               {
                    MessageBox.Show(ex.ToString());
               }
          }

          private void mnuAbout_Click(object sender, EventArgs e)
          {
               MessageBox.Show("Coded by Blue DeviL\nSCTZine 2017\nwww.sctzine.com\nwww.decompile.us", "Asm in C#");
          }

          private void mnuQuit_Click(object sender, EventArgs e)
          {
               Application.Exit();
          }

          //The Event Below are just for checking if the user presses hexadecimal values or not?
          //Aşağıdaki "KeyPress" olayı(event) bize kullanıcı tuşa basınca
          //bastığı tuş onaltılık değerle karşılık gelen 0-9 A-F a-f gibi değerler değilse
          //bu yanlış karakterleri textboxa döndürmüyor, sadece hex değerleri döndürmemizi sağlıyor
          //bu sayede ikinci kez textboxa girilen değer 16'lık mı kontrolü yapılamasına gerek kalmıyor
          //'\b' -> backspace 'in kaçışl karakteri
          //0x60 - 0x66 a - f
          //0x40 - 0x46 A - F
          //0x30 - 0x39 0 - 9
          private void txtHexAnd01_KeyPress(object sender, KeyPressEventArgs e)
          {
               char cAndValHex = e.KeyChar;       //define a char typed variable and set to the key pressed by user
               if (cAndValHex!='\b' && !((cAndValHex <= 0x66 && cAndValHex >= 0x60) || (cAndValHex <= 0x46 && cAndValHex >= 0x40) || (cAndValHex <= 0x39 && cAndValHex >= 0x30)))
               {
                    e.Handled = true;
               }
          }

          private void txtHexAnd02_KeyPress(object sender, KeyPressEventArgs e)
          {
               char cAndValHex = e.KeyChar;
               if (cAndValHex!='\b' && !((cAndValHex <= 0x66 && cAndValHex >= 0x60) || (cAndValHex <= 0x46 && cAndValHex >= 0x40) || (cAndValHex <= 0x39 && cAndValHex >= 0x30)))
               {
                    e.Handled = true;
               }
          }

          private void txtHexOr01_KeyPress(object sender, KeyPressEventArgs e)
          {
               char cOrValHex = e.KeyChar;
               if (cOrValHex !='\b' && !((cOrValHex<=0x66 && cOrValHex>=0x60) || (cOrValHex<=0x46 && cOrValHex>=0x40) || (cOrValHex<=0x39 && cOrValHex>=0x30)))
               {
                    e.Handled = true;
               }
          }

          private void txtHexOr2_KeyPress(object sender, KeyPressEventArgs e)
          {
               char cOrValHex = e.KeyChar;
               if (cOrValHex != '\b' && !((cOrValHex <= 0x66 && cOrValHex >= 0x60) || (cOrValHex <= 0x46 && cOrValHex >= 0x40) || (cOrValHex <= 0x39 && cOrValHex >= 0x30)))
               {
                    e.Handled = true;
               }
          }

          private void txtHexXor01_KeyPress(object sender, KeyPressEventArgs e)
          {
               char cXorValHex = e.KeyChar;
               if (cXorValHex != '\b' && !((cXorValHex <= 0x66 && cXorValHex >= 0x60) || (cXorValHex <= 0x46 && cXorValHex >= 0x40) || (cXorValHex <= 0x39 && cXorValHex >= 0x30)))
               {
                    e.Handled = true;
               }
          }

          private void txtHexXor02_KeyPress(object sender, KeyPressEventArgs e)
          {
               char cXorValHex = e.KeyChar;
               if (cXorValHex != '\b' && !((cXorValHex <= 0x66 && cXorValHex >= 0x60) || (cXorValHex <= 0x46 && cXorValHex >= 0x40) || (cXorValHex <= 0x39 && cXorValHex >= 0x30)))
               {
                    e.Handled = true;
               }
          }

          private void txtHexNot_KeyPress(object sender, KeyPressEventArgs e)
          {
               char cNotValHex = e.KeyChar;
               if (cNotValHex != '\b' && !((cNotValHex <= 0x66 && cNotValHex >= 0x60) || (cNotValHex <= 0x46 && cNotValHex >= 0x40) || (cNotValHex <= 0x39 && cNotValHex >= 0x30)))
               {
                    e.Handled = true;
               }
          }

          /*
            Doğrudan textboxlara ctrl + c-v-x-a yapamıyordum
            Bunu yapabilmek için birer if-elseif döngüsüyle kontrol sağlayıp
            kopyala-yapıştır-kes-tümünü seç işlemlerini yaptırdım
            Ayrıca textbox özelliklerinden "ShortCutEnabled" "true" olarak işaretlenmeli
            Ayrıca "static void main()" fonksiyonu altında "Application.EnableVisualStyles();" uygulanmalı
          */
          private void txtHexAnd01_KeyUp(object sender, KeyEventArgs e)
          {
               if(e.KeyData == (Keys.Control | Keys.V))
               {
                    (sender as TextBox).Paste();
               }
               else if(e.KeyData == (Keys.Control | Keys.A))
               {
                    (sender as TextBox).SelectAll();
               }
               else if(e.KeyData == (Keys.Control | Keys.X))
               {
                    (sender as TextBox).Cut();
               }
               else if(e.KeyData == (Keys.Control | Keys.C))
               {
                    (sender as TextBox).Copy();
               }
          }

          private void txtHexAnd02_KeyUp(object sender, KeyEventArgs e)
          {
               if(e.KeyData == (Keys.Control | Keys.A))
               {
                    (sender as TextBox).SelectAll();
               }
               else if(e.KeyData == (Keys.Control | Keys.C))
               {
                    (sender as TextBox).Copy();
               }
               else if(e.KeyData == (Keys.Control | Keys.X))
               {
                    (sender as TextBox).Cut();
               }
               else if(e.KeyData == (Keys.Control | Keys.V))
               {
                    (sender as TextBox).Paste();
               }
          }

          private void txtHexOr01_KeyUp(object sender, KeyEventArgs e)
          {
               if (e.KeyData == (Keys.Control | Keys.A))
               {
                    (sender as TextBox).SelectAll();
               }
               else if (e.KeyData == (Keys.Control | Keys.C))
               {
                    (sender as TextBox).Copy();
               }
               else if (e.KeyData == (Keys.Control | Keys.X))
               {
                    (sender as TextBox).Cut();
               }
               else if (e.KeyData == (Keys.Control | Keys.V))
               {
                    (sender as TextBox).Paste();
               }
          }

          private void txtHexOr2_KeyUp(object sender, KeyEventArgs e)
          {
               if (e.KeyData == (Keys.Control | Keys.A))
               {
                    (sender as TextBox).SelectAll();
               }
               else if (e.KeyData == (Keys.Control | Keys.C))
               {
                    (sender as TextBox).Copy();
               }
               else if (e.KeyData == (Keys.Control | Keys.X))
               {
                    (sender as TextBox).Cut();
               }
               else if (e.KeyData == (Keys.Control | Keys.V))
               {
                    (sender as TextBox).Paste();
               }
          }

          private void txtHexXor01_KeyUp(object sender, KeyEventArgs e)
          {
               if (e.KeyData == (Keys.Control | Keys.A))
               {
                    (sender as TextBox).SelectAll();
               }
               else if (e.KeyData == (Keys.Control | Keys.C))
               {
                    (sender as TextBox).Copy();
               }
               else if (e.KeyData == (Keys.Control | Keys.X))
               {
                    (sender as TextBox).Cut();
               }
               else if (e.KeyData == (Keys.Control | Keys.V))
               {
                    (sender as TextBox).Paste();
               }
          }

          private void txtHexXor02_KeyUp(object sender, KeyEventArgs e)
          {
               if (e.KeyData == (Keys.Control | Keys.A))
               {
                    (sender as TextBox).SelectAll();
               }
               else if (e.KeyData == (Keys.Control | Keys.C))
               {
                    (sender as TextBox).Copy();
               }
               else if (e.KeyData == (Keys.Control | Keys.X))
               {
                    (sender as TextBox).Cut();
               }
               else if (e.KeyData == (Keys.Control | Keys.V))
               {
                    (sender as TextBox).Paste();
               }
          }

          private void txtHexNot_KeyUp(object sender, KeyEventArgs e)
          {
               if (e.KeyData == (Keys.Control | Keys.A))
               {
                    (sender as TextBox).SelectAll();
               }
               else if (e.KeyData == (Keys.Control | Keys.C))
               {
                    (sender as TextBox).Copy();
               }
               else if (e.KeyData == (Keys.Control | Keys.X))
               {
                    (sender as TextBox).Cut();
               }
               else if (e.KeyData == (Keys.Control | Keys.V))
               {
                    (sender as TextBox).Paste();
               }
          }
     }
}
