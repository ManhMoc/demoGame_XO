using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace demoGame_XO
{
    
    public partial class Form1 : Form
    {
        public static char[,] arr;
        public static char last = 'O';
        public Form1()
        {
            InitializeComponent();
            
        }

        public void Form1_Load(object sender, EventArgs e)
        {
            
        }

        public void btnTao_Click(object sender, EventArgs e)
        {
            
            int row = int.Parse(txtHang.Text);
            int colum = int.Parse(txtCot.Text);
            Button[,] btn = new Button[row,colum];
           
            arr = new char[row, colum];
            for (int i=0;i<row;i++)
                for(int j=0;j<colum;j++)
                {
                    btn[i, j] = new Button();
                    btn[i,j].Width  = 50;
                    btn[i, j].Height = 50;
                    btn[i,j].Location = new Point(j* 50, i * 50);
                    btn[i,j].Text = "";
                    btn[i,j].Click += new EventHandler(button_click);
                    btn[i,j].ForeColor = Color.Blue;
                    arr[i, j] = ' ';
                    grb.Controls.Add(btn[i,j]);
                }
        }

        private void button_click(object sender, EventArgs e)
        {
            // MessageBox.Show(((Button)sender).Location.ToString());
            //MessageBox.Show(((Button)sender).Top.ToString());
            //MessageBox.Show(((Button)sender).Left.ToString());
            int x = ((Button)sender).Left / 50;
            int y = ((Button)sender).Top / 50;
           // MessageBox.Show("[" + x + "," + y + "]");
            if (last == 'O')
            {
                ((Button)sender).Text = "X";
                
                last = 'X';
                arr[x, y] = 'X';
                if (IsWinRow(x, y)) MessageBox.Show("X win");
                if (IsWinColumn(x, y)) MessageBox.Show("X win");
                if (IsWinDiagonal1(x, y)) MessageBox.Show("X win");
                if (IsWinDiagonal2(x, y)) MessageBox.Show("X win");
                /* foreach(Button btn in grb.Controls)
                 {
                     if (btn.Location == ((Button)sender).Location)
                     {
                         int x = ((Button)sender).Left/50;
                         int y = ((Button)sender).Top / 50;
                         MessageBox.Show("["+x+","+y+"]");
                     }        
                 }*/
            }
            else
            {
                ((Button)sender).Text = "O";
                arr[x, y] = 'O';
                if (IsWinRow(x, y)) MessageBox.Show("O win");
                if (IsWinColumn(x, y)) MessageBox.Show("O win");
                if (IsWinDiagonal1(x, y)) MessageBox.Show("O win");
                if (IsWinDiagonal2(x, y)) MessageBox.Show("O win");
                last = 'O';
            }
        }
        public bool IsWinRow(int x,int y)//kiem tra hang.
        {
            char c = arr[x, y];
            int count = 0;
            int k = x;
            int kmax = x;
            int kmin = x;
            int max = int.Parse(txtCot.Text)-1;
            while(k>=0 && k <= max)
            {
                if ( k>=x && arr[k, y] == c)
                {
                    count++;
                    kmax = k;
                    if (k == max) k = x - count;
                    else
                    k++;
                    
                }
                else 
                {
                    
                    k = x - count;
                    kmin = k;
                    if (k>=0 && arr[k, y] == c)
                    {
                        if (arr[k + 1, y] != c) break;//Node truoc !=c;
                        count++;
                    }
                    else break;
                }
            }           
            if (kmin < 0) kmin = 0;
            if (kmax < max) kmax++;
           // if (kmin > 0) kmin--;
            bool bl = arr[kmin, y] == ' ' || arr[kmax, y] == ' '
                || arr[kmax,y]==c || arr[kmin,y]==c;
            if (bl && count >= 5) return true;

            

            return false;
        }
        public bool IsWinColumn(int x,int y)//Kiem tra cot
        {
            char c = arr[x, y];
            int count = 0;
            int k = y;
            int kmax = y;
            int kmin = y;
            int max = int.Parse(txtHang.Text) - 1;
            while (k >= 0 && k <= max)
            {
                if (k >= y && arr[x, k] == c)
                {
                    count++;
                    kmax = k;
                    if (k == max) k = y - count;
                    else
                        k++;
                }
                else
                {
                    k = y - count;
                    kmin = k;
                    if (k >= 0 && arr[x, k] == c)
                    {
                        if (arr[x, k+1] != c) break;
                        count++;
                    }
                    else break;
                }
            }
            if (kmin < 0) kmin = 0;
            if (kmax < max) kmax++;
            bool bl = arr[x, kmin] == ' ' || arr[x, kmax] == ' '
                || arr[x, kmax] == c || arr[x, kmin] == c;
            if (bl && count >= 5) return true;
            return false;
        }
        public bool IsWinDiagonal1(int x,int y)//Theo chieu tang;
        {
            char c = arr[x, y];
            int count = 0;
            int kx = x;
            int ky = y;
            int kmax_y = y;
            int kmin_y = y;
            int kmax_x = x;
            int kmin_x = x;
            int maxx = int.Parse(txtCot.Text) - 1;
            int maxy = int.Parse(txtHang.Text) - 1;
            while( kx >= 0 && kx <= maxx
                && ky >= 0 && ky <= maxy )
            {
                if (ky >= y && arr[kx, ky] == c
                    && kx >= x && arr[kx, ky] == c)
                {
                    count++;
                    kmax_x = kx;
                    kmax_y = ky;
                    if (kx == maxx || ky == maxy)
                    {
                        kx = x - count;
                        ky = y - count;
                    }
                    else
                    {
                        kx++;
                        ky++;
                    };
                }
                else
                {
                    ky = y - count;
                    kx = x - count;
                    kmin_x = kx;
                    kmin_y = ky;
                    if (kx >= 0 && ky>=0 && arr[kx, ky] == c)
                    {
                        if (arr[kx+1 , ky+1] != c) break;
                        count++;
                    }
                    else break;
                }
            }
            if (kmin_x < 0 || kmin_y < 0)
            {
                kmin_x++;
                kmin_y++;
            }
            if (kmax_x < maxx && kmax_y < maxy)
            {
                kmax_x++;
                kmax_y++;
            }
            bool bl = arr[kmin_x, kmin_y] == ' ' || arr[kmax_x, kmax_y] == ' '
                || arr[kmax_x, kmax_y] == c || arr[kmin_x, kmin_y] == c;
            if (bl && count >= 5) return true;
           
            return false;
        }
       
        public bool IsWinDiagonal2(int x, int y)//Theo chieu giam;
        {
            char c = arr[x, y];
            int count = 0;
            int kx = x;
            int ky = y;
            int kmax_y = y;
            int kmin_y = y;
            int kmax_x = x;
            int kmin_x = x;
            int maxx = int.Parse(txtCot.Text) - 1;
            int maxy = int.Parse(txtHang.Text) - 1;
            while (kx >= 0 && kx <= maxx
                && ky >= 0 && ky <= maxy)
            {
                if (kx >= x && arr[kx, ky] == c
                    && ky >= 0 && arr[kx, ky] == c)//
                {
                    count++;
                    kmax_x = kx;
                    kmax_y = ky;
                    if (ky == 0)
                    {
                        kx = x - count;
                        ky = y - count;
                    }
                    else
                    {
                        kx++;
                        ky--;
                    };
                }
                else
                {
                    ky = y + count;
                    kx = x - count;
                    kmin_x = kx;
                    kmin_y = ky;
                    if (kx >= 0 && ky <=maxy && arr[kx, ky] == c)
                    {
                        if (arr[kx + 1, ky - 1] != c) break;
                        count++;
                    }
                    else break;
                }
            }
            if (kmin_x < 0)
            {
                kmin_x++;
                kmin_y--;
            }
            if (kmax_y<0)
            {
                kmax_x--;
                kmax_y++;
            }
            bool bl = arr[kmin_x, kmin_y] == ' ' || arr[kmax_x, kmax_y] == ' '
                || arr[kmax_x, kmax_y] == c || arr[kmin_x, kmin_y] == c;
            if (bl && count >= 5) return true;

            return false;
        }
        private void grb_Enter(object sender, EventArgs e)
        {

        }
    }
}
