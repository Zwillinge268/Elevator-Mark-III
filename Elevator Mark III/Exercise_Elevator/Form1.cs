using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise_Elevator
{
    public partial class Form1 : Form
    {
        public byte TotalFloor = 6;
        public bool[] Inside = new bool[7];      //TotalFloor + 1
        public char[] Outside = new char[7];     //TotalFloor + 1

        public bool state = true;
        public byte floor = 1;

        public Form1()
        {
            InitializeComponent();           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int x = (Screen.PrimaryScreen.WorkingArea.Width - this.Width) / 2;
            int y = (Screen.PrimaryScreen.WorkingArea.Height - this.Height) / 2;
            this.Location = new Point(x, y);
        }

        private void Start_Click(object sender, EventArgs e)
        {
            for (int i = 1; i <= TotalFloor; i++)
            {
                Inside[i] = false;
                Outside[i] = '4';
            }

            groupBox1.Enabled = true;
            groupBox10.Enabled = true;
            timer1.Enabled = true;
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void End_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }    

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (state == true)
            {
                for (byte i = 1; i < TotalFloor; i++)
                {
                    byte temp = (byte)(floor + i);
                    if (temp > TotalFloor) temp = (byte)(temp - TotalFloor);

                    if (Inside[temp] == true || Outside[temp] == '1' || Outside[temp] == '2' || Outside[temp] == '3')
                    {
                        if (temp > floor)
                        {
                            floor++;
                            break;
                        }
                        else
                        {
                            if(Outside[floor] == '2')
                            {
                                Outside[floor] = '4';
                                Up.BackColor = Color.LightGray;
                            }
                            floor--;
                            state = false;
                            break;
                        }
                    }
                    else if (Outside[floor] == '2' && i == (TotalFloor - 1)) state = false;
                }
            }
            else
            {
                for (short i = 1; i < TotalFloor; i++)
                {
                    short temp = (short)(floor - i);
                    if (temp < 1) temp = (byte)(temp + TotalFloor);

                    if (Inside[temp] == true || Outside[temp] == '1' || Outside[temp] == '2' || Outside[temp] == '3')
                    {
                        if (temp < floor)
                        {
                            floor--;
                            break;
                        }
                        else
                        {
                            if(Outside[floor] == '1')
                            {
                                Outside[floor] = '4';
                                Up.BackColor = Color.LightGray;
                            }
                            floor++;
                            state = true;                            
                            break;
                        }                       
                    }
                    else if (Outside[floor] == '1' && i == (TotalFloor - 1)) state = true;
                }
            }

            display.Text = floor.ToString();
            if (floor == 1 || floor == TotalFloor) state = !state;
            
            CheckBoxUncheck();
        }

        private void CheckBoxUncheck()
        {
            bool open = false;

            if (Inside[floor] == true)
            {
                foreach (Control ctrl in groupBox10.Controls)
                {
                    if (ctrl.Name == "G" + floor.ToString())
                    {
                        ((CheckBox)ctrl).Checked = false;
                        ((CheckBox)ctrl).Enabled = true;
                        open = true;
                    }
                }
            }     
            
            if(state == true)
            {
                if(Outside[floor] == '1')
                {
                    Outside[floor] = '4';
                    if (select.SelectedIndex + 1 == floor) Up.BackColor = Color.LightGray;
                    open = true;                    
                }
                else if(Outside[floor] == '3')
                {
                    Outside[floor] = '2';
                    if (select.SelectedIndex + 1 == floor) Up.BackColor = Color.LightGray;
                    open = true;
                }
                if (select.SelectedIndex + 1 == floor) Up.BackColor = Color.LightGray;
            }
            else
            {
                if (Outside[floor] == '2')
                {
                    Outside[floor] = '4';
                    if (select.SelectedIndex + 1 == floor) Down.BackColor = Color.LightGray;
                    open = true;
                }
                else if (Outside[floor] == '3')
                {
                    Outside[floor] = '1';
                    if (select.SelectedIndex + 1 == floor) Down.BackColor = Color.LightGray;
                    open = true;
                }                
            }           
            if (open == true) DoorOpen();
        }

        private void DoorOpen()
        {
            timer1.Enabled = false;
            Close.Enabled = true;
            Open.Checked = true;
            timer1.Enabled = false;
            door.Enabled = true;
        }

        private void Close_CheckedChanged(object sender, EventArgs e)
        {
            if (Close.Checked == true)
            {
                timer1.Enabled = true; 
                Close.Enabled = false;
            }
        }

        private void InsideCC(object sender, EventArgs e)
        {
            CheckBox CB = (CheckBox)sender;
            if (CB.Checked == true)
            {
                short temp = short.Parse(CB.Name.ToString().Substring(1, 1));
                Inside[temp] = true;
            }
            else
            {
                short temp = short.Parse(CB.Name.ToString().Substring(1, 1));
                Inside[temp] = false;
            }
            ((CheckBox)sender).Enabled = false;
        }

        private void OutsideCC(object sender, EventArgs e)
        {
            ((Button)sender).BackColor = Color.Wheat;
            if(((Button)sender).Name == "Up")
            {
                if(Outside[select.SelectedIndex + 1] == '4')
                Outside[select.SelectedIndex + 1] = '1';
                else if(Outside[select.SelectedIndex + 1] == '2')
                Outside[select.SelectedIndex + 1] = '3';
            }
            else
            {
                if (Outside[select.SelectedIndex + 1] == '4')
                    Outside[select.SelectedIndex + 1] = '2';
                else if (Outside[select.SelectedIndex + 1] == '1')
                    Outside[select.SelectedIndex + 1] = '3';
            }                        
        }

        private void info_Click(object sender, EventArgs e)
        {
            MessageBox.Show("點擊“開始模擬”按鈕即可啓動電梯程式\r\n" + 
                "電梯到達指定樓層後電梯門將開啓，點擊“關”以關上電梯門，電梯將繼續移動\r\n" +
                "點擊“停止模擬”按鈕將初始化程式", "説明", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void select_SelectedIndexChanged(object sender, EventArgs e)
        {
            Up.Enabled = true; Down.Enabled = true;
            Up.Visible = true; Down.Visible = true;

            if (select.SelectedIndex == 0)
            {
                Down.Enabled = false; Down.Visible = false;
            }              
            else if (select.SelectedIndex == TotalFloor - 1)
            {
                Up.Enabled = false; Up.Visible = false;
            }
            
            if(Outside[select.SelectedIndex + 1] == '4')
            {
                Up.BackColor = Color.LightGray;
                Down.BackColor = Color.LightGray;
            }
            else if (Outside[select.SelectedIndex + 1] == '3')
            {
                Up.BackColor = Color.Wheat;
                Down.BackColor = Color.Wheat;
            }
            else if (Outside[select.SelectedIndex + 1] == '2')
            {
                Up.BackColor = Color.LightGray;
                Down.BackColor = Color.Wheat;
            }
            else if (Outside[select.SelectedIndex + 1] == '1')
            {
                Up.BackColor = Color.Wheat;
                Down.BackColor = Color.LightGray;
            }

        }

        private void door_Tick(object sender, EventArgs e)
        {
            Close.Checked = true;
            timer1.Enabled = true;
            door.Enabled = false;
        }
    }
}
