using System;
using System.Reflection;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Resources;
using System.Globalization;
using System.IO;
using System.Xml;
using System.Threading;

namespace msi
{
    public partial class Form1 : Form
    {
    #region GLOBALIS VALTOZOK

        //amiben tarolok es amibol a dataset-be olvasok
        String db_FileName = "Application/XMLdatabase.txt";
        //amibe az eredmeny kerul
        string filePath_rec = "Application/recep.txt";
        string filePath_written = "Application/written.txt";
        //a dataset aktualis táblajanak neve, egyszerre egy tabla nem ures!!
        string tablename;

        // informaló illetve hibauzenet szövegek
        string message_NeedExOrCont = "Exista deja date in optiunea ";
        string message_NeedExOrCont2 = "!";
        string message_Delete = "Doriti sa stergeti toate datele?";
        //string message_Confirm = "Do you want to export the data?";
        //string message_Exist = "The recep.txt file exist, do you want to overwrite it?";
        //string message_NotExported = "The data had not been exported!";
        string message_AllDeleted = "Toate datele au fost sterse din MSI!";
        string message_noexport = "Nu exista date, selectati o optiune!";
        string message_SuccesExport = "Datele au fost exportate!";
        
        string app1 = "'Pret concurenta'";
        string app2 = "'Stoc produse'";
        string app3 = "'Verificare pret'";
        string app4 = "'Receptie'";
        string app5 = "'Etichete MSI'";
        
        string errorMsg_empty = "Completati toate campurile!";
        string errorMsg_notnum = "Nu este un numar!";
        string errorMsg = "";
        string errorMsg_longean = "Atentie: max 13 cifre!";
        string errorMsg_longprice = "Atentie: max 7.2 cifre!";
        string errorMsg_longprice2 = "Atentie: max 4.3 cifre!";
        //string errorMsg_notdigit = "it can be between 0-9!";
        string errorMsg_notpositiv = "Numai numere pozitive!";

        string info_choose_app = "Alegeti o optiune!";
        string info_scan = "In acest camp nu se scaneaza!";
        //javitva 2008.08.28 
        //string info_empty = " field should not be empty! If you not fill it, the last row will be deleted!! Would you like to fill it?";
        string info_empty = "Inregistrare incompleta!! Doriti sa o corectati?";
        
        string aktText = "";
        string alpha_pressed = "Este apasat butonul ALPHA";
        string shift_pressed = "Este apasat butonul SHIFT";
        string ctrl_pressed = "Este apasat butonul CTRL";

        //
        string takeovernum_constans = "";
        
        // adott alkalmazast mutatja
        int application_type = 0;
        
        // mezo ervenyessegi flag
        bool valid = false;

        // hibas mező eseten megjelenő kép
        PictureBox picturError = new PictureBox();
    
        #endregion GLOBALIS VALTOZOK
        
    #region KONSTRUKTOR
        public Form1()
        {
            InitializeComponent();

            picturError.Size = new Size(30, 30);
            picturError.Image = imageList_buttons.Images[2];
            picturError.Click += new System.EventHandler(this.picturError_Click);
        }
        #endregion KONSTRUKTOR

    #region ESEMÉNYKEZELŐK
        private void Form1_Load(object sender, EventArgs e)
        {
            if (!File.Exists(db_FileName)) // ha nem letezik a file, keszitunk egyet, es beleirjuk a semat
                dataSet1.WriteXmlSchema(db_FileName);

            dataSet1.ReadXml(db_FileName);  //aztan feltoltjuk a dataszetet

            if (dataSet1.Tables["DataTable_con"].Rows.Count != 0)  // ha a dataset ures-> szabadon valaszthat alkalmazast, egyebkent exportalasig ugyanazt az alkalmazast hasznalhatja!!
            {
                application_type = 1;
                tablename = "DataTable_con";
                label_con_storecode.Text = dataSet1.Tables["DataTable_con"].Rows[bindingSource_con.Count - 1].ItemArray[0].ToString();
                comboBox_con_store.Text = label_con_storecode.Text;
                radioButton_con.Checked = true;
            }
            else if (dataSet1.Tables["DataTable_real"].Rows.Count != 0)  // ha a dataset ures-> szabadon valaszthat alkalmazast, egyebkent exportalasig ugyanazt az alkalmazast hasznalhatja!!
            {
                application_type = 2;
                tablename = "DataTable_real";
                label_real_quntity_binding.Text = "0";
                comboBox_real_dev.Text = label_real_quntity_binding.Text;
                radioButton_real.Checked = true;
            }
            else if (dataSet1.Tables["DataTable_label"].Rows.Count != 0)  // ha a dataset ures-> szabadon valaszthat alkalmazast, egyebkent exportalasig ugyanazt az alkalmazast hasznalhatja!!
            {
                application_type = 3;
                tablename = "DataTable_label";
                radioButton_label.Checked = true;
            }
            else if (dataSet1.Tables["DataTable_takeover"].Rows.Count != 0)  // ha a dataset ures-> szabadon valaszthat alkalmazast, egyebkent exportalasig ugyanazt az alkalmazast hasznalhatja!!
            {
                application_type = 4;
                tablename = "DataTable_takeover";
                radioButton_takeover.Checked = true;
            }
            else if (dataSet1.Tables["DataTable_MSI"].Rows.Count != 0)  // ha a dataset ures-> szabadon valaszthat alkalmazast, egyebkent exportalasig ugyanazt az alkalmazast hasznalhatja!!
            {
                application_type = 5;
                tablename = "DataTable_MSI";
                radioButton_MSI.Checked = true;
            }
            else
            {
                application_type = 0;
                radioButton_con.Checked = true;
            }
            button_ok.Focus();
            timer1.Enabled = true;
            label_time.Text = System.DateTime.Now.Hour + ":" + System.DateTime.Now.Minute;
            label_statusbar.Text = info_choose_app;
        }
        #region főalkalmazás elseménykezelői
        //A panel_application panelen elhelyezett button_ok gomb használatakor meghívódó 
        //eseménykezelő. Amennyiben az application_type globális változó értéke nem
        //nulla ( azaz a dataset valamely táblájában van adat), illetve ezen változó 
        //nem egyezik a változó értékének megfelelő radiobutton-nal, úgy a 
        //NeedExOrCont() függvény segítségével a megfelelő hibaüzenet kerül kiíratásra. 
        //Amennyiben ez a feltétel nem teljesül, és nem a letöltésért felelős 
        //radiobutton aktív, úgy beállításra kerülnek a megfelelő panelek 
        //láthatósági tulajdonságai, illetve az application_type változó értéke, 
        //majd a setButtonsEnable(bindingSource_...) függvény segítségével 
        //beállításra kerülnek a panel_navigator-on elhelyezett navigációs gombok 
        //helyes elérhetőségi tulajdonságai, végül a megfelelő dataset táblához 
        //hozzáadunk egy ures sort az Add() függvény segítségével. 
        //Amennyiben a letöltés radiobutton az aktív, úgy ha van letöltendő 
        //adatunk (azaz az application_type változó értéke nem nulla), úgy az 
        //Export() függvény segítségével az adatok letöltésre kerülnek.
        private void button_ok_Click(object sender, EventArgs e)
        {
            if ((application_type != 0) && (
             (application_type != 1 && radioButton_con.Checked) ||
             (application_type != 2 && radioButton_real.Checked) ||
             (application_type != 3 && radioButton_label.Checked) ||
             (application_type != 4 && radioButton_takeover.Checked) ||
             (application_type != 5 && radioButton_MSI.Checked)))
            {
                NeedExOrCont();
                return;
            }

            panel_applications.Visible = false;
            panel_con.Visible = false;
            panel_label.Visible = false;
            panel_real.Visible = false;
            panel_takeover.Visible = false;
            panel_navigator.Visible = false;
            panel_export.Visible = false;
            panel_MSI.Visible = false;
            label_statusbar.Text = "";

            if (radioButton_con.Checked)
            {
                if (File.Exists(filePath_rec))
                    File.Delete(filePath_rec);
                panel_con.Visible = true;
                panel_navigator.Visible = true;
                application_type = 1;
                tablename = "DataTable_con";
                setButtonsEnable(bindingSource_con);
                this.Text = "msi2008 v2.3.1 / " + app1;
                Add();
            }
            else if (radioButton_real.Checked)
            {
                if (File.Exists(filePath_rec))
                    File.Delete(filePath_rec);

                panel_real.Visible = true;
                panel_navigator.Visible = true;
                application_type = 2;
                tablename = "DataTable_real";
                setButtonsEnable(bindingSource_real);
                this.Text = "msi2008 v2.3.1 / " + app2;
                Add();
            }
            else if (radioButton_label.Checked)
            {
                if (File.Exists(filePath_rec))
                    File.Delete(filePath_rec);

                panel_label.Visible = true;
                panel_navigator.Visible = true;
                application_type = 3;
                tablename = "DataTable_label";
                setButtonsEnable(bindingSource_label);
                this.Text = "msi2008 v2.3.1 / " + app3;
                Add();
            }
            else if (radioButton_takeover.Checked)
            {
                if (File.Exists(filePath_rec))
                    File.Delete(filePath_rec);

                panel_takeover.Visible = true;
                panel_navigator.Visible = true;
                application_type = 4;
                tablename = "DataTable_takeover";
                setButtonsEnable(bindingSource_takeover);
                this.Text = "msi2008 v2.3.1 / " + app4;
                Add();
                if (bindingSource_takeover.Count == 1)
                    textBox_takeover_takeovernum.Text = "";
            }
            else if (radioButton_MSI.Checked)
            {
                if (File.Exists(filePath_rec))
                    File.Delete(filePath_rec);

                panel_MSI.Visible = true;
                panel_navigator.Visible = true;
                application_type = 5;
                tablename = "DataTable_MSI";
                setButtonsEnable(bindingSource_MSI);
                this.Text = "msi2008 v2.3.1 / " + app5;
                Add();
               // if (bindingSource_MSI.Count == 1)
                 //   textBox_takeover_takeovernum.Text = "";
            }
            else if (radioButton_download.Checked)
            {

                if (application_type == 0)
                {
                    panel_applications.Visible = true;
                    MessageBox.Show(message_noexport);
                    panel_applications.Refresh();
                    return;
                }
                else
                {
                    radioButton_export_delete.Checked = false;
                    radioButton_export_export.Checked = false;
                    panel_applications.Visible = false;
                    panel_export.Visible = true;
                    this.Text = "msi2008 v2.3.1";
                    //Export();
                }
            }
        }
        private void radioButton_Click(object sender, EventArgs e)
        {
            button_ok.Focus();
            this.Refresh();
        }
        int radiobutton_id = 1;

        private void radioButton_Checked_Changed(object sender, EventArgs e)
        {
            //if (!((RadioButton)sender).Checked && sender!=radioButton_con)
            //{
            //    if (sender == radioButton_con)
            //        radiobutton_id = 2;
            //    else if (sender == radioButton_real)
            //        radiobutton_id = 3;
            //    else if (sender == radioButton_label)
            //        radiobutton_id = 4;
            //    else if (sender == radioButton_takeover)
            //        radiobutton_id = 5;
            //    else if (sender == radioButton_download)
            //        radiobutton_id = 1;
            //}
            button_ok.Focus();
        }
        #endregion főalkalmazás elseménykezelői
        #region navigációs sáv eseménykezelői
        //navigációs sáv eseménykezelői
        //A navigációs sávon található pictureBox_first, pictureBox_prev, pictureBox_next, 
        //pictureBox_last, illetve pictureBox_delete komponensekhez rendelt 
        //eseménykezelő, amely a felsorolt komponensekre való kattintással hívódik meg. 
        //Az aktuális alkalmazás függvényében meghívja a Move(1par, sender) 
        //függvényt a megfelelő bindingSorce paraméterrel(1par), illetve a saját 
        //object típusú paraméterével.
        private void pictureBox_Click(object sender, EventArgs e)
        {
            if (application_type == 1)
                Move(bindingSource_con, sender);
            else if (application_type == 2)
                Move(bindingSource_real, sender);
            else if (application_type == 3)
                Move(bindingSource_label, sender);
            else if (application_type == 4)
                Move(bindingSource_takeover, sender);
            else if (application_type == 5)
                Move(bindingSource_MSI, sender);
        }

        //A navigációs sávon található pictureBox_add komponenshez rendelt eseménykezelő
        private void pictureBox_add_Click(object sender, EventArgs e)
        {
            if (AllControllsValidator(false))
            {
                Save();
                Add();
            }
        }

        //A navigációs sávon található pictureBox_back komponenshez rendelt eseménykezelő
        private void pictureBox_back_Click(object sender, EventArgs e)
        {
            if (dataSet1.Tables[tablename].Rows.Count == 0)
                Back(true);
            else
                Back(false);
        }
        #endregion navigációs sáv eseménykezelői
        #region validátok
        private void textBox_real_quantity_Validating(object sender, CancelEventArgs e)
        {
            if (button_ok.Focused) //a fokusz akkor van a button_ok-on,ha hasznaltuk az AllControllsValidator() fv-t, es ott ugy dont a felhasznalo, hogy nem tolti v nem korrigalja a hibait! De attol hogy az a sor torlesre kerul a validator cancel -et is false-ra kell allitani!!(v kezdetben, de ez akkor nem hivodik meg)
            {
                errorMsg = "";
                label_statusbar.Text = "";
                valid = true;
                e.Cancel = false;
                return;
            }
            TextBox tbx = ((TextBox)sender);

            picturError.Location = new Point(tbx.Location.X + tbx.Size.Width + 15, tbx.Location.Y);
            picturError.Visible = false;

            tbx.Parent.Controls.Add(picturError); //tbx parentje mindig az adott panel
            if ((tbx.Text).StartsWith("z")) // PDA-n beallitott prefix a "z"! Ekkor ean codot olvas, ami hibas, mivel ide quantity kell!!
            {
                tbx.Text = "";
                errorMsg = info_scan;
                picturError.Visible = true;
                label_statusbar.Text = errorMsg;
                valid = false;
                e.Cancel = true;
            }
            else if (tbx.Text == "")
            {
                errorMsg = errorMsg_empty;
                picturError.Visible = true;
                label_statusbar.Text = errorMsg;
                valid = false;
                e.Cancel = true;
            }
            else
            {
                Int64 isnumber = 0;
                try
                {
                    Double isdouble = Convert.ToDouble(tbx.Text);
                    isnumber = Convert.ToInt64(isdouble * 1000);
                    tbx.Text = (Convert.ToDouble(isnumber) / 1000).ToString();
                    if (isnumber <= 0)
                    {
                        errorMsg = errorMsg_notpositiv;
                        picturError.Visible = true;
                        label_statusbar.Text = errorMsg;
                        valid = false;
                        e.Cancel = true;
                    }
                    else if (isnumber.ToString().Length > 7)
                    {
                        errorMsg = errorMsg_longprice2;
                        picturError.Visible = true;
                        label_statusbar.Text = errorMsg;
                        valid = false;
                        e.Cancel = true;
                    }
                    else
                    {
                        picturError.Visible = false;
                        tbx.Parent.Controls.Remove(picturError);
                        label_statusbar.Text = "";
                        valid = true;
                        e.Cancel = false;
                    }
                }
                catch
                {
                    errorMsg = errorMsg_notnum;
                    picturError.Visible = true;
                    label_statusbar.Text = errorMsg;
                    valid = false;
                    e.Cancel = true;
                }
            }
            tbx.Parent.Refresh();
        }

        private void textBox_Validating(object sender, CancelEventArgs e)
        {
            if (button_ok.Focused) //mint fent
            {
                errorMsg = "";
                label_statusbar.Text = "";
                valid = true;
                e.Cancel = false;
                return;
            }

            TextBox tbx = ((TextBox)sender);

            picturError.Location = new Point(tbx.Location.X + tbx.Size.Width + 15, tbx.Location.Y);
            picturError.Visible = false;

            tbx.Parent.Controls.Add(picturError);
            if ((tbx.Text).StartsWith("z"))
            {
                //PDA-n beallitva: vonalkod leolvasas prefixe:"z", ha a tbx-be ean kodot kell olvasni es "z"-vel kezd jo, egyebkent hiba
                if (tbx == textBox_con_ean || tbx == textBox_label_ean || tbx == textBox_real_ean || tbx == textBox_takeover_ean || tbx == textBox_MSI_cod)
                {
                     tbx.Text = tbx.Text.Remove(0, 1);
                }
                else
                {
                    tbx.Text = "";
                    errorMsg = info_scan;
                    picturError.Visible = true;
                    label_statusbar.Text = errorMsg;
                    valid = false;
                    e.Cancel = true;
                }
            }
            else if (tbx.Text == "") // ures mezo nem megengedett
            {
                errorMsg = errorMsg_empty;
                picturError.Visible = true;
                label_statusbar.Text = errorMsg;
                valid = false;
                e.Cancel = true;
            }
            else
            {
                //ean csak 13 hosszu szam lehet
                if (tbx.Name == "textBox_con_ean" || tbx.Name == "textBox_label_ean" || tbx.Name == "textBox_real_ean" || tbx.Name == "textBox_takeover_ean" || tbx.Name == "textBox_MSI_cod")
                {
                    try
                    {
                        Int64 isnumber = Convert.ToInt64(tbx.Text);
                        picturError.Visible = false;
                        tbx.Parent.Controls.Remove(picturError);
                        label_statusbar.Text = "";
                        valid = true;
                        e.Cancel = false;

                        if (isnumber <= 0)
                        {
                            errorMsg = errorMsg_notpositiv;
                            picturError.Visible = true;
                            label_statusbar.Text = errorMsg;
                            valid = false;
                            e.Cancel = true;
                        }
                    }
                    catch //nem szamot adott meg
                    {
                        //errorMsg = errorMsg_notnum;
                        errorMsg = errorMsg_longean;
                        picturError.Visible = true;
                        label_statusbar.Text = errorMsg;
                        valid = false;
                        e.Cancel = true;
                    }
                    if (tbx.Text.Length > 13) //tul hosszu ean -t akart megadni
                    {
                        errorMsg = errorMsg_longean;
                        picturError.Visible = true;
                        label_statusbar.Text = errorMsg;
                        valid = false;
                        e.Cancel = true;
                    }
                }
                else // ide jonnek a quantity ill price ertekek; ami lehet double 2 tizedes jeggyel
                {
                    Int64 isnumber = 0;
                    try
                    {
                        Double isdouble = Convert.ToDouble(tbx.Text);
                        isnumber = Convert.ToInt64(isdouble * 100);  
                        tbx.Text = (Convert.ToDouble(isnumber) / 100).ToString();
                        if (isnumber <= 0)
                        {
                            if (isnumber == 0 && sender == textBox_label_price) //egyetlen mezo, ahol lehet 0 ertek is!
                            {
                                picturError.Visible = false;
                                tbx.Parent.Controls.Remove(picturError);
                                label_statusbar.Text = "";
                                valid = true;
                                e.Cancel = false;
                            }
                            else // mashol 0 nem megengedett
                            {
                                errorMsg = errorMsg_notpositiv;
                                picturError.Visible = true;
                                label_statusbar.Text = errorMsg;
                                valid = false;
                                e.Cancel = true;
                            }
                        }
                        else if (isnumber.ToString().Length > 9) // max 8 hosszu lehet: 6szamjegy.2szamjegy
                        {
                            errorMsg = errorMsg_longprice;
                            picturError.Visible = true;
                            label_statusbar.Text = errorMsg;
                            valid = false;
                            e.Cancel = true;
                        }
                        else // szam es hossz jo -> nincs hiba
                        {
                            picturError.Visible = false;
                            tbx.Parent.Controls.Remove(picturError);
                            label_statusbar.Text = "";
                            valid = true;
                            e.Cancel = false;
                        }
                    }
                    catch // nem szamot adott meg
                    {
                        errorMsg = errorMsg_notnum;
                        picturError.Visible = true;
                        label_statusbar.Text = errorMsg;
                        valid = false;
                        e.Cancel = true;
                    }
                }
            }
            if (valid) // minden ok
            {
                picturError.Visible = false;
                tbx.Parent.Controls.Remove(picturError);
                label_statusbar.Text = "";
                valid = true;
                e.Cancel = false;
            }
            tbx.Parent.Refresh();
        }
        private void picturError_Click(object sender, EventArgs e)
        {
            MessageBox.Show(errorMsg);
        }
        #endregion validátok
        #region gombok esemenykezelői
        
        //Az eseménykezelő, mely gomblenyomáskor hívódik, a következő komponensekhez 
        //kötött: panel_application panelen található button_ok gomb, valamint 
        //minden itteni radioButton; a panel_con, panel_label, panel_real és 
        //panel_takeover minden textBox és comboBox komponense. 
        //Feladata: figyelni, hogy a felhasználó használta-e a „shift”, a „ctrl”, 
        //illetve a piros(-) és zöld(-) gombokat. 
        //Előbbi két esetben információt küld a státuszbárra a gombok használatáról, 
        //míg az utóbbi két esetben elmenti a textbox szövegét, hogy gombfelengedésnél ugyanazt az
        //értéket visszaadhassa -> törli majd a MyKeyUp-nal a leütött  „-” karaktert.
        private void MyKeyDown(object sender, KeyEventArgs e)
        {
            if (sender is TextBox && e.KeyValue == 189)// || e.KeyChar==9) //45:tab, 189: piros/zold gomb
            {
                aktText = ((TextBox)sender).Text;
            }
            else if (e.KeyValue == 16)//shift
            {
                label_statusbar.Text = shift_pressed;
                pictureBox_shift.Image = imageList_statusbar.Images[4];
            }
            else if (e.KeyValue == 17)//control
            {
                label_statusbar.Text = ctrl_pressed;
                pictureBox_shift.Image = imageList_statusbar.Images[3];
            }
        }
        //Ez az eseménykezelő, mely gomblenyomáskor hívódik.
        //A button_ok gombbal kapcsolatos feladata: a PDA billentyűzetén lévő „1-4”
        //gombok lenyomására a megfelelő alkalmazás panelét jeleníti meg. 
        //Amennyiben a főalkalmazásban (panel_application) a navigációs gombokat 
        //használtuk az alkalmazás választásához, úgy az előbbi feladatot az „enter”
        //gomb lenyomásával lehet elérni. 
        //Ha a küldő valamely alkalmazás panelen (panel_con, panel_label, panel_real, 
        //panel_takeover) lévő komponens, és a lenyomott gomb az „enter”, úgy az 
        //eseménykezelő feladata a helyes fókusz beállítása, illetve az adatok 
        //elmentése a Save() függvény hívásával. 
        //Amennyiben a lenyomott billentyű az „Esc” és valamely alkalmazás panel 
        //látható, úgy az eseménykezelő a Back() függvény hívásával a főalkalmazásra navigál. 
        //A következő komponensekhez kötött: button_ok gomb, valamint 
        //minden itteni radioButton; a panel_con, panel_label, panel_real és 
        //panel_takeover minden textBox és comboBox komponense.
        private void MyKeyPress(object sender, KeyPressEventArgs e)
        {
            if (sender is TextBox || sender is ComboBox)
            {
                if (AlphaPressed(e.KeyChar))
                    return;
            }
            if (sender == button_ok)
            {
                if (AlphaPressed(e.KeyChar))
                    return;
                if (e.KeyChar == 49)
                {
                    this.radioButton_con.Checked = true;
                    button_ok_Click(sender, e);
                }
                else if (e.KeyChar == 50) //2  
                {
                    this.radioButton_real.Checked = true;
                    button_ok_Click(sender, e);
                }
                else if (e.KeyChar == 51) //3
                {
                    this.radioButton_label.Checked = true;
                    button_ok_Click(sender, e);
                }
                else if (e.KeyChar == 52) //4
                {
                    this.radioButton_takeover.Checked = true;
                    button_ok_Click(sender, e);
                }
                else if (e.KeyChar == 53) //5
                {
                    this.radioButton_MSI.Checked = true;
                    button_ok_Click(sender, e);
                }
                //else if (e.KeyChar == 53) //5
                //{
                //    this.radioButton_download.Checked = true;
                //    button_ok_Click(sender, e);
                //}

                else if (e.KeyChar == 13) //enter
                    button_ok_Click(sender, e);
            }
            else if (e.KeyChar == 13) //13: enter
            {
                if (sender == comboBox_con_store)
                    textBox_con_ean.Focus();
                else if (sender == textBox_con_ean)
                    textBox_con_price.Focus();
                else if (sender == textBox_con_price)
                {
                    comboBox_con_store.Focus();
                    if (valid)
                    {
                        Save();
                        Add();
                    }
                }

                else if (sender == textBox_real_ean)
                    textBox_real_quantity.Focus();

                else if (sender == textBox_real_quantity)
                {
                    comboBox_real_dev.Focus();
                }
                else if (sender == comboBox_real_dev)
                {
                    textBox_label_ean.Focus();
                    if (valid)
                    {
                        Save();
                        Add();
                    }
                }

                else if (sender == textBox_label_ean)
                    textBox_label_price.Focus();
                else if (sender == textBox_label_price)
                {
                    textBox_label_ean.Focus();
                    if (valid)
                    {
                        Save();
                        Add();
                    }
                }

                else if (sender == textBox_MSI_cod)
                    textBox_MSI_cantitate.Focus();
                else if (sender == textBox_MSI_cantitate)
                {
                    textBox_MSI_cod.Focus();
                    if (valid)
                    {
                        Save();
                        Add();
                    }
                }

                else if (sender == textBox_takeover_takeovernum)
                {
                    takeovernum_constans = textBox_takeover_takeovernum.Text;
                    textBox_takeover_ean.Focus();
                }
                else if (sender == textBox_takeover_ean)
                {
                    textBox_takeover_quantity.Focus();
                }
                else if (sender == textBox_takeover_quantity)
                {
                    textBox_takeover_ean.Focus();
                    if (valid)
                    {
                        textBox_takeover_takeovernum.Text = takeovernum_constans;
                        Save();
                        Add();
                    }
                }
            }

            else if (e.KeyChar == 27) //27:esc
            {
                if (!panel_applications.Visible)
                {
                    if (dataSet1.Tables[tablename].Rows.Count == 0)
                        Back(true);
                    else
                        Back(false);
                }
            }

            //else if (e.KeyChar == 45) //piros ill zold gombok
            //{
            //    return;
            //}
        }
        //Az eseménykezelő, mely gombfelengedéskor hívódik, a következő komponensekhez 
        //kötött: panel_application panelen található button_ok gomb, valamint 
        //minden itteni radioButton; a panel_con, panel_label, panel_real és 
        //panel_takeover minden textBox és comboBox komponense. 
        //Feladatai: figyelni, hogy a felhasználó használta-e ismét 
        //(deaktiválta, felengedte-e) a „shift”, a „ctrl” gombokat. 
        //Illetve a piros és zöld gombok felengedésére a MyKeyDown(…) 
        //eseménykezelőben, az akt_text változóba mentett értéket visszaadja az 
        //adott textBox szövegtulajdonságának. 
        //Továbbá a különböző navigációs gombok helyes viselkedéséért felel 
        //(azaz ↓: adott radioButton rákövetkezőjére áll, amennyiben ez az utolsó 
        //radioButton, úgy az elsőt jelöli meg, ↑: adott radioButton előzőjére áll,
        //amennyiben ez az első radioButton, úgy az utolsót jelöli meg, 
        //←: legelső, illetve a  → legutolsó radioButonttont jelöli meg).
        private void MyKeyUp(object sender, KeyEventArgs e)
        {
            //radiobuttonok helyes viselkedese
            if (e.KeyValue == 38 && sender == button_ok && panel_applications.Visible) //fel
            {
                if (radiobutton_id == 0)
                    radiobutton_id = 5;

                if (radiobutton_id == 2)
                    radioButton_con.Checked = true;
                else if (radiobutton_id == 3)
                    radioButton_real.Checked = true;
                else if (radiobutton_id == 4)
                    radioButton_label.Checked = true;
                else if (radiobutton_id == 5)
                    radioButton_takeover.Checked = true;
                else if (radiobutton_id == 1)
                    radioButton_download.Checked = true;

                radiobutton_id--;
            }
            else if ((e.KeyValue == 40 || e.KeyValue == 45) && sender == button_ok && panel_applications.Visible)//le
            {
                if (radiobutton_id == 6)
                    radiobutton_id = 1;

                if (radiobutton_id == 1)
                    radioButton_real.Checked = true;
                else if (radiobutton_id == 2)
                    radioButton_label.Checked = true;
                else if (radiobutton_id == 3)
                    radioButton_takeover.Checked = true;
                else if (radiobutton_id == 4)
                    radioButton_download.Checked = true;
                else if (radiobutton_id == 5)
                    radioButton_con.Checked = true;

                radiobutton_id++;
            }
            //else if (e.KeyValue == 40 || e.KeyValue == 45)//le
            //{

            //    if (radioButton_real.Checked)
            //        radioButton_label.Checked = true;
            //    else if (radioButton_label.Checked)
            //        radioButton_takeover.Checked = true;
            //    else if (radioButton_takeover.Checked)
            //        radioButton_download.Checked = true;
            //    else if (radioButton_download.Checked)
            //        radioButton_con.Checked = true;
            //    else if (radioButton_con.Checked)
            //        radioButton_real.Checked = true;
            //}else if...
            else if (e.KeyValue == 37 && sender == button_ok && panel_applications.Visible) //balra
            {
                radioButton_download.Checked = true;
                radiobutton_id = 5;
            }
            else if (e.KeyValue == 39 && sender == button_ok && panel_applications.Visible)//jobbra
            {
                radioButton_con.Checked = true;
                radiobutton_id = 1;
            }
            else if (sender is TextBox && e.KeyValue == 189)
            {
                //if (sender is TextBox)
                //{
                ((TextBox)sender).Text = aktText;
                //}
            }
            else if (e.KeyValue == 16) //shift
            {
                label_statusbar.Text = "";
                pictureBox_shift.Image = null;
            }
            else if (e.KeyValue == 17) //ctrl
            {
                label_statusbar.Text = "";
                pictureBox_shift.Image = null;
            }

            this.Refresh();
        }
        #endregion gombok esemenykezelői
        #region egyeb esemenykezelők
        
        private void bindingSource_CurrentChanged(object sender, EventArgs e)
        {
            if (application_type == 1)
                setButtonsEnable(bindingSource_con);
            else if (application_type == 2)
                setButtonsEnable(bindingSource_real);
            else if (application_type == 3)
                setButtonsEnable(bindingSource_label);
            else if (application_type == 4)
                setButtonsEnable(bindingSource_takeover);
            else if (application_type == 5)
                setButtonsEnable(bindingSource_MSI);
        }
        
        private void dataGrid_GotFocus(object sender, EventArgs e)
        {
            try
            {
                if(application_type==1)
                    bindingSource_con.EndEdit();
                else if (application_type == 2)
                   bindingSource_real.EndEdit();
               else if (application_type == 3)
                   bindingSource_label.EndEdit();
               else if (application_type == 4)
                   bindingSource_takeover.EndEdit();
               else if (application_type == 5)
                   bindingSource_MSI.EndEdit();
               
               
                Save();
                
            }
            catch
            {
                if (application_type == 1)
                    Move(bindingSource_con, this.pictureBox_delete);
                else if (application_type == 2)
                    Move(bindingSource_real, this.pictureBox_delete);
                else if (application_type == 3)
                    Move(bindingSource_label, this.pictureBox_delete);
                else if (application_type == 4)
                    Move(bindingSource_takeover, this.pictureBox_delete);
                else if (application_type == 5)
                    Move(bindingSource_MSI, this.pictureBox_delete);
                    
                
                Save();
                
                if (dataSet1.Tables[tablename].Rows.Count == 0)
                    Add();

                if (application_type == 4 && bindingSource_takeover.Count == 1)
                {
                    textBox_takeover_takeovernum.Text="";
                    textBox_takeover_takeovernum.Visible = true;
                }
            }

        }
        

        private void dataGrid_DoubleClick(object sender, EventArgs e)
        {
         
            int column = ((DataGrid)sender).CurrentCell.ColumnNumber;
            if (application_type == 1)
            {
                if (column == 0)
                    comboBox_con_store.Focus();
                else if (column == 1)
                    textBox_con_ean.Focus();
                else if (column == 2)
                    textBox_con_price.Focus();

            }
            else if (application_type == 2)
            {
                if (column == 0)
                    textBox_real_ean.Focus();
                else if (column == 1)
                    textBox_real_quantity.Focus();
                else if (column == 2)
                {
                    comboBox_real_dev.Text = label_real_quntity_binding.Text;
                    comboBox_real_dev.Focus();
                }
            }
            else if (application_type == 3)
            {
                if (column == 0)
                    textBox_label_ean.Focus();
                else if (column == 1)
                    textBox_label_price.Focus();
            }
            else if (application_type == 4)
            {
                
                if (column == 0 && ((DataGrid)sender).CurrentCell.RowNumber == 0)
                {
                    textBox_takeover_takeovernum.Visible = true;
                    textBox_takeover_takeovernum.Focus();
                }
                else if (column == 1)
                {
                    textBox_takeover_takeovernum.Visible = false;
                    textBox_takeover_ean.Focus();
                }
                else if (column == 2)
                {
                    textBox_takeover_takeovernum.Visible = false;
                    textBox_takeover_quantity.Focus();
                }
                //if (bindingSource_takeover.Count==1)
                  //  textBox_takeover_takeovernum.Focus();
            }
            if (application_type == 5)
            {
                if (column == 0)
                    textBox_MSI_cod.Focus();
                else if (column == 1)
                    textBox_MSI_cantitate.Focus();

            }
        }
        private void dataGrid_real_Click(object sender, EventArgs e)
        {
            if (((DataGrid)sender).CurrentCell.ColumnNumber == 2)
            {
                comboBox_real_dev.Text = label_real_quntity_binding.Text;
            }
        }
        private void dataGrid_takeover_Click(object sender, EventArgs e)
        {
            if (((DataGrid)sender).CurrentCell.RowNumber == 0 && ((DataGrid)sender).CurrentCell.ColumnNumber == 0)
                textBox_takeover_takeovernum.Visible = true;
            
            else
                textBox_takeover_takeovernum.Visible = false;
        }

        private void comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (((ComboBox)sender).SelectedIndex > -1)
            {
                if (application_type == 1)
                {
                    ((ComboBox)sender).SelectedItem = ((ComboBox)sender).Items[((ComboBox)sender).SelectedIndex];
                    label_con_storecode.Text = ((ComboBox)sender).SelectedIndex.ToString();
                    //a label-hez van bindingolva a dataset tablajanak oszlopa! 
                }
                else if (application_type == 2)
                {
                    ((ComboBox)sender).SelectedItem = ((ComboBox)sender).Items[((ComboBox)sender).SelectedIndex];
                    label_real_quntity_binding.Text = ((ComboBox)sender).SelectedIndex.ToString();
                    //a label-hez van bindingolva a dataset tablajanak oszlopa! 
                }
           }
        }

        private void textBox_takeover_takeovernum_TextChanged(object sender, EventArgs e)
        {
            if (textBox_takeover_takeovernum.Text != "")
            {
                label_input_takeovernumber.Text = textBox_takeover_takeovernum.Text;//a label-hez van bindingolva a dataset tablajanak oszlopa! 
                if (bindingSource_takeover.Count > 1)
                {
                    for (int i = 0; i < bindingSource_takeover.Count; i++)
                        dataSet1.Tables[tablename].Rows[i][0] = Convert.ToInt32(label_input_takeovernumber.Text);
                    Save();
                }
            }
        }
        private void button_export_cancel_Click(object sender, EventArgs e)
        {
            panel_export.Visible = false;
            panel_applications.Visible = true;
            button_ok.Focus();
        }

        private void button_export_ok_Click(object sender, EventArgs e)
        {
            if (this.radioButton_export_delete.Checked)
            {
                DeleteData();
            }
            else
            {
                ExportData();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label_time.Text = (System.DateTime.Now.TimeOfDay.ToString()).Remove(5, 3);//.Hour + ":" + System.DateTime.Now.Minute;
        }

        private void pictureBox_time_Click(object sender, EventArgs e)
        {
            if (label_time.Visible)
            {
                timer1.Enabled = false;
                label_time.Visible = false;
                pictureBox_time.Image = imageList_statusbar.Images[2];
            }
            else
            {
                timer1.Enabled = true;
                label_time.Visible = true;
                pictureBox_time.Image = imageList_statusbar.Images[1];
            }
        }

        #endregion egyeb esemenykezelok
    #endregion ESEMÉNYKEZELŐK

    #region FÜGGVÉNYEK
        private void NeedExOrCont()
        {
            string continueWith = "";

            if (application_type == 1)
                continueWith = app1;
            else if (application_type == 2)
                continueWith = app2;
            else if (application_type == 3)
                continueWith = app3;
            else if (application_type == 4)
                continueWith = app4;
            else if (application_type == 5)
                continueWith = app5;
            MessageBox.Show(message_NeedExOrCont + " " + continueWith + " " + message_NeedExOrCont2);
            //radioButton_download.Checked = true;
            button_ok.Focus();
        }

        
        //panel_navigatoron levo navigacios gombok helyes elérhetőségéért felelos fv.
        //  A gombok elérhetősége a dataset-ben lévő adatok függvénye:
            //•	Első elemre ugrás aktív, ha nem az első elem a kijelölt
            //•	Előző elemre ugrás aktív, ha nem az első elem a kijelölt
            //•	Következő elemre ugrás aktív, ha nem az utolsó elem a kijelölt
            //•	Utolsó elemre ugrás aktív, ha nem az utolsó elem a kijelölt
            //•	Törlés aktív, ha nem csak egy elemet tartalmaz a dataset
            //•	Az pozíciót mutató label_count szövege mindig: „az aktuális pozició” of „összes elem”
        //A függvény hívásra kerül a button_ok_Click(…), 
        //bindingSource_CurrentChanged(…)eseménykezelőkből, 
        //illetve az Add() és Move() függvényekből.
        //imageList_buttons.Images[x]: x=0:;     
        private void setButtonsEnable(BindingSource p_bindingSource_akt)
        {
            label_count.Text = (1 + p_bindingSource_akt.Position).ToString() + "of{" + p_bindingSource_akt.Count.ToString() + "}";

            //elso, elozo nem aktiv
            if (p_bindingSource_akt.Position < 1) // position<1, ha egy elemunk van, v nincs elem
            {
                pictureBox_first.Enabled = false;
                pictureBox_prev.Enabled = false;
                pictureBox_first.Image = imageList_buttons.Images[3];
                pictureBox_prev.Image = imageList_buttons.Images[10];
            }
            //elso, elozo aktiv
            if (p_bindingSource_akt.Position > 0) // egy vagy több elem esete
            {
                pictureBox_first.Enabled = true;
                pictureBox_prev.Enabled = true;
                pictureBox_first.Image = imageList_buttons.Images[4];
                pictureBox_prev.Image = imageList_buttons.Images[11];
            }
            //utolso, kovetkezo nem aktiv
            if (p_bindingSource_akt.Position == p_bindingSource_akt.Count - 1) // utolso elemen allas esete
            {
                pictureBox_last.Enabled = false;
                pictureBox_next.Enabled = false;
                pictureBox_last.Image = imageList_buttons.Images[5];
                pictureBox_next.Image = imageList_buttons.Images[7];
            }
            //utolso, kovetkezo aktiv
            if (p_bindingSource_akt.Position != p_bindingSource_akt.Count - 1)//nem utolsó elem esete
            {
                pictureBox_last.Enabled = true;
                pictureBox_next.Enabled = true;
                pictureBox_last.Image = imageList_buttons.Images[6];
                pictureBox_next.Image = imageList_buttons.Images[8];
            }

            //torles gomb nem aktiv
            if (p_bindingSource_akt.Count <= 1)
            {
                pictureBox_delete.Enabled = false;
                pictureBox_delete.Image = imageList_buttons.Images[12];
            }
            //torles gomb aktiv
            if (p_bindingSource_akt.Count > 1)
            {
                pictureBox_delete.Enabled = true;
                pictureBox_delete.Image = imageList_buttons.Images[13];
            }
            //a takeover panelen talalhato textBox_takeover_takeovernum textbox csak akkor lathato,
            //ha a legelso soron allunk, azaz ha a bindingsource pozicioja ==0. 
            if (p_bindingSource_akt == bindingSource_takeover)
            {
                if (p_bindingSource_akt.Position == 0)
                {
                    textBox_takeover_takeovernum.Visible = true;
                    textBox_takeover_takeovernum.Focus();
                }
                else
                {
                    textBox_takeover_takeovernum.Visible = false;
                }
            }

            //this.Refresh();
        }

        //Annak függvényében, hogy melyik alkalmazást használjuk (ezt az application_type értéken mutatja), 
        //az aktuális bindingsuorce-hoz ad egy új üres sort, 
        //újraszámolja az aktuális datagrid szélességét és magasságát a Datagrid_style(datagrid_...) függvény segítségével, 
        //majd a navigációs sáv gombjainak elérhetőségét korrigálja a setButtonsEnabled(bindingSource_...) függvény hívásával.
        //A függvény hívásra kerül a button_ok_Click(…), 
        //pictureBox_add_Click(…),illetve a MyKeyPress(…)eseménykezelőkből.
        private void Add()
        {
            if (application_type == 1)
            {
                bindingSource_con.AddNew();
                Datagrid_style(dataGrid_con);
                setButtonsEnable(bindingSource_con);
                // apro csalas: label_con_storecode használata, mivel a combobox ha bindingolt nem 
                // adja vissza a selecteditem_changed esemeny aktualis erteket!! Igy nem a combobox van bindingolva, hanem ez a label!!!
                if (bindingSource_con.Count == 1) // ezert: count==1-> ez egy ures sor lesz, ekkor beállitjuk 0-ra az erteket, es ezt kapja meg a combobox is!!
                {
                    label_con_storecode.Text = "0";
                    comboBox_con_store.Text = label_con_storecode.Text;
                    comboBox_con_store.Focus();
                }
                else // kulonben a combobox erteke uaz marad, nem kap fokuszt sem, csak a combobox-ra valo kattintassal lehet megváltoztatni az erteket, v. datagrid vmelyik sor elso mezojere valo duplakatt-tal
                {
                    label_con_storecode.Text = comboBox_con_store.Text;
                    textBox_con_ean.Focus();
                }
            }
            else if (application_type == 2)
            {
                
                bindingSource_real.AddNew();
                Datagrid_style(dataGrid_real);
                setButtonsEnable(bindingSource_real);

                label_real_quntity_binding.Text = "0";
                comboBox_real_dev.Text = label_real_quntity_binding.Text;

                textBox_real_ean.Focus();
            }
            else if (application_type == 3)
            {
                bindingSource_label.AddNew();
                Datagrid_style(dataGrid_label);
                setButtonsEnable(bindingSource_label);

                textBox_label_ean.Focus();
            }
            else if (application_type == 4)
            {
                bindingSource_takeover.AddNew();
                Datagrid_style(dataGrid_takeover);
                setButtonsEnable(bindingSource_takeover);
                //hasonlo a con alkalmazashoz, itt is a label_input_takeovernum a bindingolt! de itt a textbox csak a legelso
                // sor kivalasztasanal láthato, label erteke akkor változik, ha az elso sor van kijelolve-> megjelenik a textbox->
                // ->_takeover_takeovernum_TextChanged, focust csak az elsosornal kap a textbox
                if (bindingSource_takeover.Count == 1)
                {
                    textBox_takeover_takeovernum.Visible = true;
                    textBox_takeover_takeovernum.Focus();
                }
                else
                {
                    label_input_takeovernumber.Text = dataSet1.Tables[tablename].Rows[0][0].ToString();
                    textBox_takeover_takeovernum.Visible = false;
                    textBox_takeover_ean.Focus();
                }
            }
            else if (application_type == 5)
            {

                bindingSource_MSI.AddNew();
                Datagrid_style(dataGrid_MSI);
                setButtonsEnable(bindingSource_MSI);
               
                textBox_MSI_cod.Focus();
            }
        }

        //Ez a függvény felelős azért, hogy az adott panelen lévő összes kontroll
        //helyesen legyen kitöltve, a fókusz változtatással meghívja az 
        //adott kontrol …_Validating(…) eseménykezelőjét. 
        //Amennyiben valahol hibás adatot talál, akkor egy üzenetet küld a hibáról,
        //melynek korrigálását, vagy az adott sor törlését ajánlja. 
        //Amennyiben a javítás funkciót választja a felhasználó, a fókusz a javítandó kontrollra áll. 
        //Ellenkező esetben kitörli az utolsó sort, és újrarajzolja az aktuális datagrid-et a Datagrid_style(datagrid_...) függvény hívásával.
        //A függvényt a pictureBox_add_Click(…) eseménykezelő, 
        //illetve a Move() és a Back() függvények hívják.   
        private bool AllControllsValidator(bool p_isempty)
        {
            
            Panel l_aktpanel;// errol a panelrol kell leszedni az esetlegesen ott maradt picture_errort!;
            BindingSource l_aktbindigsource;// innen kell torolni a rossz sort;
            
            if (application_type == 1)
            {
                if (this.textBox_con_ean.Text == "" && this.textBox_con_price.Text == "")
                {
                    bindingSource_con.RemoveCurrent();
                    return true;
                }
                l_aktpanel = panel_con;
                l_aktbindigsource = bindingSource_con;
            }
            else if (application_type == 2)
            {
                
                if (this.textBox_real_ean.Text == "" && this.textBox_real_quantity.Text == "")
                {
                    bindingSource_real.RemoveCurrent();
                    return true;
                }
                l_aktpanel = panel_real;
                l_aktbindigsource = bindingSource_real;
            }
            else if (application_type == 3)
            {
                if (this.textBox_label_ean.Text == "" && this.textBox_label_price.Text == "")
                {
                    bindingSource_label.RemoveCurrent();
                    return true;
                }
                l_aktpanel = panel_label;
                l_aktbindigsource = bindingSource_label;
            }
            else if (application_type == 4)
            {
                if (this.textBox_takeover_ean.Text == "" && this.textBox_takeover_quantity.Text == "")
                {
                    bindingSource_takeover.RemoveCurrent();
                    return true;
                }
                l_aktpanel = panel_takeover;
                l_aktbindigsource = bindingSource_takeover;
            }
            else if (application_type == 5)
            {

                if (this.textBox_MSI_cod.Text == "" && this.textBox_MSI_cantitate.Text == "")
                {
                    bindingSource_MSI.RemoveCurrent();
                    return true;
                }
                l_aktpanel = panel_MSI;
                l_aktbindigsource = bindingSource_MSI;
            }
            else
                return true;

            if (p_isempty) // ez akkor hivodik, ha a back() fv-t ugy hivtak hogy nincs egyetlen valid sora sem!Vagy törlés utolso sorra
            {
                l_aktbindigsource.RemoveCurrent();
                return true;
            }
            for (int i = 0; i < l_aktpanel.Controls.Count; i++)
            {
                if (l_aktpanel.Controls[i] is TextBox)
                {
                    if (l_aktpanel.Controls[i].Enabled == false)
                        l_aktpanel.Controls[i].Enabled = true;
                    l_aktpanel.Controls[i].Focus();
                    l_aktpanel.Controls[i - 1].Focus();
                    if (!valid)
                    {
                        if (l_aktpanel.Controls[i].Name=="textBox_takeover_takeovernum")
                        {
                            l_aktpanel.Controls.Remove(picturError);
                            return true; 
                        }
                        DialogResult l_result = MessageBox.Show("Campul '" + l_aktpanel.Controls[i - 1].Text +"' este incorect. "+ errorMsg + "\n" + info_empty, "", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                        
                        if (l_result == DialogResult.No)
                        {
                            button_ok.Focus();
                            l_aktbindigsource.RemoveCurrent();
                            l_aktpanel.Controls.Remove(picturError);
                            l_aktpanel.Refresh();
                            if (l_aktpanel == panel_con)
                                Datagrid_style(dataGrid_con);
                            else if (l_aktpanel == panel_real)
                                Datagrid_style(dataGrid_real);
                            else if (l_aktpanel == panel_label)
                                Datagrid_style(dataGrid_label);
                            else if (l_aktpanel == panel_takeover)
                                Datagrid_style(dataGrid_takeover);
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                }
            }
            return true;
        }

        //Egy sor mentéséért felelős függvény, mely hívásra kerül a 
        //pictureBox_add_Click(…),textBox_takeover_takeovernum_TextChanged(…), 
        //illetve a MyKeyPress(…) eseménykezelőkből, 
        //valamint a Move(…) és a Back() függvényekből.
        private void Save()//BindingSource aktbindingsource)
        {
            try
            {
                if (application_type == 1)
                {
                    this.bindingSource_con.EndEdit();
                }
                else if (application_type == 2)
                {
                    this.bindingSource_real.EndEdit();
                }
                else if (application_type == 3)
                {
                    this.bindingSource_label.EndEdit();
                }
                else if (application_type == 4)
                {
                    this.bindingSource_takeover.EndEdit();
                }
                else if (application_type == 5)
                {
                    this.bindingSource_MSI.EndEdit();
                }
                //picturError.Visible = false;

            }
            catch (Exception ex) //ide elmeletileg nem juthat :)
            {
                
                MessageBox.Show("meg igy is van hiba a mentesben!! " + ex.Message);
            }
            try
            {
                dataSet1.AcceptChanges();
                dataSet1.WriteXml(db_FileName);
            }
            catch (Exception ex) //ide meg megugysem....
            {
                MessageBox.Show("Error: mentésnél" + ex.Message);
                dataSet1.RejectChanges();
            }
            this.Refresh();
        }

        //A függvény a navigációs sáv gombjainak helyes működését szolgálja. 
        //Amennyiben a hívó a törlést szolgáló gomb, és a törlés megengedett, 
        //úgy törli az aktuális sort, majd korrigálja az aktuális datagrid stílusát
        //a Datagrid_style(datagrid_...) függvény hívásával, 
        //végül a setButtonsEnable() függvény segítségével újra állítja a 
        //navigációs sáv gombjainak elérhetőségét. 
        //Ellenkező esetben (ha a hívó nem a törlést szolgáló gomb) 
        //ellenőrzi a kontrolok helyes kitöltését az AllControllsValidator() függvény segítségével, 
        //amennyiben ez rendben van, akkor a hívó gombnak megfelelően az első, 
        //az előző, a  következő, vagy az utolsó sor lesz az aktuális sor.
        //A függvényt a pictureBox_Click(…) eseménykezelő hívja.
        private void Move(BindingSource p_bindingSource_akt, object p_sender)
        {
            if (p_sender == pictureBox_delete && p_bindingSource_akt.Count > 0)
            {
                try
                {
                    p_bindingSource_akt.RemoveCurrent();

                    if (p_bindingSource_akt == bindingSource_con)
                        Datagrid_style(dataGrid_con);
                    else if (p_bindingSource_akt == bindingSource_real)
                        Datagrid_style(dataGrid_real);
                    else if (p_bindingSource_akt == bindingSource_label)
                        Datagrid_style(dataGrid_label);
                    else if (p_bindingSource_akt == bindingSource_takeover)
                        Datagrid_style(dataGrid_takeover);
                    else if (p_bindingSource_akt == bindingSource_MSI)
                        Datagrid_style(dataGrid_MSI);
                    //if (bindingSource_akt.Count <= 1)
                    //    pictureBox_delete.Enabled = false;

                    setButtonsEnable(p_bindingSource_akt);
                }
                catch
                {
                    MessageBox.Show("hiba delete!!");
                }
            }
            else
            {
                if (AllControllsValidator(false))
                {
                    Save();
                    try
                    {
                        if (p_sender == pictureBox_first)
                            p_bindingSource_akt.MoveFirst();
                        else if (p_sender == pictureBox_next)
                            p_bindingSource_akt.MoveNext();
                        else if (p_sender == pictureBox_prev)
                            p_bindingSource_akt.MovePrevious();
                        else if (p_sender == pictureBox_last)
                            p_bindingSource_akt.MoveLast();

                        setButtonsEnable(p_bindingSource_akt);
                    }
                    catch (Exception ex) // ide nem juthat-> ellenorizni, torolni!!
                    {
                        MessageBox.Show("error a Move fv-ben:  " + ex.ToString());
                    }
                }
            }
            this.Refresh();
        }

        private void Datagrid_style(DataGrid p_akt_datagrid)
        {
            int rows = ((BindingSource)p_akt_datagrid.DataSource).Count;
            //if (rows > 6)
              //  return;
            
            if (rows <5)
            {
                p_akt_datagrid.Height = 21 + (rows * 18);
                p_akt_datagrid.Width = 290;
            }
            else if (rows == 5)
            {
                p_akt_datagrid.Height = 112;
                p_akt_datagrid.Width = 290;
            }
            else
            {
                p_akt_datagrid.Height = 112;
                p_akt_datagrid.Width = 303;
            }
        }

        //A főalkalmazásba való visszatérésért felelős függvény, 
        //mely az AllControllsValidator() függvény segítségével megvizsgalja, 
        //hogy az adott panelen lévő kontrollok helyesen lettek-e kitöltve, 
        //majd menti a bevitt adatokat. Ezt követően beállítja a panelek helyes 
        //láthatósági tulajdonságait, illetve ha ez szükséges 
        //(a dataset adott tablája nem tartalmaz sort) korrigálja az 
        //application_type globális változó értékét. 
        //A függvényt a pictureBox_back_Click(…), illetve a MyKeyPress(…) ű
        //eseménykezelők hívják.
        private void Back(bool p_isempty)
        {
            if (AllControllsValidator(p_isempty))
            {
                Save();
                if (dataSet1.Tables[tablename].Rows.Count == 0)
                    application_type = 0;

                
                panel_con.Visible = false;
                panel_label.Visible = false;
                panel_real.Visible = false;
                panel_takeover.Visible = false;
                panel_navigator.Visible = false;
                panel_MSI.Visible = false;
                label_statusbar.Text = info_choose_app;
                panel_applications.Visible = true;
                //radioButton_download.Checked = true;
                this.Text = "msi2008 v2.3.1";
                button_ok.Focus();
            }
        }

        //A függvény egyetlen feladata az alkalmazás típusának megfelelő helyes 
        //eredményfájl megírása. Egyetlen hívási helye az Export() függvény. 
        private void Write()
        {
            if (application_type == 0)
                MessageBox.Show("apptype==0");

            TextWriter l_tw = new StreamWriter(filePath_rec);
            if (application_type == 3)
                l_tw.WriteLine("P" + dataSet1.Tables[tablename].Rows.Count.ToString());
            else if (application_type == 5)
                l_tw.WriteLine("Q" + dataSet1.Tables[tablename].Rows.Count.ToString());
            else
                l_tw.WriteLine(dataSet1.Tables[tablename].Rows.Count);

            string l_corrected_ean;
            string l_corrected_price;
            Int32 l_storecode = 10;

            bool l = true;
            for (int i = 0; i != dataSet1.Tables[tablename].Rows.Count; i++)
            {
                l_corrected_ean = dataSet1.Tables[tablename].Rows[i]["ean"].ToString();

                while (l_corrected_ean.Length < 13)
                    l_corrected_ean = "0" + l_corrected_ean;
                if (application_type == 1)
                {
                    if (l_storecode != Convert.ToInt32(dataSet1.Tables[tablename].Rows[i]["storecode"]))
                    {

                        l_tw.WriteLine("D" + dataSet1.Tables[tablename].Rows[i]["storecode"]);
                        l_storecode = Convert.ToInt32(dataSet1.Tables[tablename].Rows[i]["storecode"]);
                    }

                    Double l_int_price = Convert.ToDouble(dataSet1.Tables[tablename].Rows[i]["price"]) * 100;
                    l_corrected_price = l_int_price.ToString();
                    //javitva 2008.03.17 Edouard keresere
                    while (l_corrected_price.Length < 9)
                        l_corrected_price = "0" + l_corrected_price;
                    l_corrected_price = " " + l_corrected_price;
                    //while (l_corrected_price.Length < 10)
                    //    l_corrected_price = "0" + l_corrected_price;

                    l_tw.WriteLine("F" + l_corrected_ean + l_corrected_price);
                }
                else if (application_type == 2)
                {
                    Double l_int_price = Convert.ToDouble(dataSet1.Tables[tablename].Rows[i]["quantity"]) * 1000;
                    l_corrected_price = l_int_price.ToString();

                    while (l_corrected_price.Length < 7) //itt eddig 7 volt
                        l_corrected_price = "0" + l_corrected_price;

                    l_tw.WriteLine("I" + l_corrected_ean + l_corrected_price + dataSet1.Tables[tablename].Rows[i]["devaluation"]);
                }
                else if (application_type == 3)
                {
                    Double l_int_price = Convert.ToDouble(dataSet1.Tables[tablename].Rows[i]["price"]) * 100;
                    l_corrected_price = l_int_price.ToString();

                    if (l_corrected_price == "0")
                        l_corrected_price = "       00";
                    if (l_corrected_price.Length == 1)
                        l_corrected_price = "0" + l_corrected_price;    
                    while (l_corrected_price.Length < 9)
                        l_corrected_price = " " + l_corrected_price;

                    l_tw.WriteLine("B" + l_corrected_ean + l_corrected_price);
                }
                else if (application_type == 4)
                {
                    if (l)
                    {
                        l_tw.WriteLine("R" + dataSet1.Tables[tablename].Rows[i]["takeovernum"]);
                        l = false;
                    }
                    Double l_int_price = Convert.ToDouble(dataSet1.Tables[tablename].Rows[i]["quantity"]) * 100;
                    l_corrected_price = l_int_price.ToString();

                    while (l_corrected_price.Length < 9)
                        l_corrected_price = "0" + l_corrected_price;

                    l_tw.WriteLine("S" + l_corrected_ean + l_corrected_price);
                }
                else if (application_type == 5)
                {
                    Double l_int_price = Convert.ToDouble(dataSet1.Tables[tablename].Rows[i]["quantity"]);
                    l_corrected_price = l_int_price.ToString();

                    if (l_corrected_price == "0")
                        l_corrected_price = "       00";
                    if (l_corrected_price.Length == 1)
                        l_corrected_price = "0" + l_corrected_price;
                    while (l_corrected_price.Length < 9)
                        l_corrected_price = " " + l_corrected_price;

                    l_tw.WriteLine("B" + l_corrected_ean + l_corrected_price);
                }
            }
            l_tw.Close();
        }

        //A függvény feladata, hogy ellenőrizze a PDA-n lévő „alpha” gomb lenyomását. 
        //Egyetlen lokális változója a string típusú prev_text változó, melyben 
        //mentésre kerül a státuszbár szövege, melyet az „alpha” gomb ismételt 
        //lenyomása esetén visszakap a státuszbár. A gomb lenyomását direkt nem lehet 
        //kezelni, mert a .NET nem ismeri ezen gomb keyChar értékét. Így a többi 
        //keyChar értékkel rendelkező gomb lenyomásakor történik meg egy intervallumos 
        //ellenőrzés.A függvényt a MyKeyPress(…) eseménykezelő hívja.
        private bool AlphaPressed(int p_key_char)
        {
            string l_prev_text = "";

            if (label_statusbar.Text != alpha_pressed)
                l_prev_text = label_statusbar.Text;

            if (p_key_char == 42 || (p_key_char >= 97 && p_key_char <= 122))
            {
                label_statusbar.Text = alpha_pressed;
                pictureBox_alpha.Image = imageList_statusbar.Images[0];
                return true;
            }
            else
            {
                label_statusbar.Text = l_prev_text;
                pictureBox_alpha.Image = null;
                return false;
            }
        }
        

        private void ExportData()
        {  
            Write();
            if (!File.Exists(filePath_written))
            { 
                TextWriter l_tw = new StreamWriter(filePath_written);
                l_tw.WriteLine("ok");
                l_tw.Close();
            }
            DialogResult l_result = MessageBox.Show(message_SuccesExport, " ", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
            DeleteData();    
        }

        private void DeleteData()
        {
            DialogResult l_result = MessageBox.Show(message_Delete, " ", MessageBoxButtons.YesNo, MessageBoxIcon.Hand, MessageBoxDefaultButton.Button2);
            if (l_result == DialogResult.No)
            {
                panel_export.Visible = false;
                panel_applications.Visible = true;
                button_ok.Focus();
                return;
            }
            else
            {
                dataSet1.Clear();
                dataSet1.AcceptChanges();
                dataSet1.WriteXml(db_FileName);
                application_type = 0;

                l_result = MessageBox.Show(message_AllDeleted, " ", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
                
                panel_export.Visible = false;
                panel_applications.Visible = true;
                button_ok.Focus();
            }
        }

        private void button_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    #endregion FÜGGVÉNYEK
    }
}