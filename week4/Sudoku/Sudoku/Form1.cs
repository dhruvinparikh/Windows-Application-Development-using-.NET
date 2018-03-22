using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sudoku
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void s33_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            s1111.Value = 1;
            s1112.Value = 3;
            s1113.Value = 9;
            s1121.Value = 5;
            //s1122.Value = 4;
            //s1123.Value = 6;
            s1131.Value = 8;
            s1132.Value = 2;
            s1133.Value = 7;

            s1111.Enabled = false;
            s1112.Enabled = false;
            s1113.Enabled = false;
            s1121.Enabled = false;
            s1122.Enabled = true;
            s1123.Enabled = true;
            s1131.Enabled = false;
            s1132.Enabled = false;
            s1133.Enabled = false;

            //s1211.Value = 7;
            s1212.Value = 5;
            //s1213.Value = 4;
            s1221.Value = 8;
            //s1222.Value = 3;
            s1223.Value = 2;
            s1231.Value = 9;
            s1232.Value = 6;
            s1233.Value = 1;

            s1211.Enabled = true;
            s1212.Enabled = false;
            s1213.Enabled = true;
            s1221.Enabled = false;
            s1222.Enabled = true;
            s1223.Enabled = false;
            s1231.Enabled = false;
            s1232.Enabled = false;
            s1233.Enabled = false;

            s1311.Value = 6;
            //s1312.Value = 2;
            //s1313.Value = 8;
            s1321.Value = 7;
            s1322.Value = 1;
            s1323.Value = 9;
            s1331.Value = 4;
            s1332.Value = 3;
            //s1333.Value = 5;

            s1311.Enabled = false;
            s1312.Enabled = true;
            s1313.Enabled = true;
            s1321.Enabled = false;
            s1322.Enabled = false;
            s1323.Enabled = false;
            s1331.Enabled = false;
            s1332.Enabled = false;
            s1333.Enabled = true;

            s2111.Value = 7;
            //s2112.Value = 5;
            //s2113.Value = 8;
            s2121.Value = 9;
            s2122.Value = 1;
            s2123.Value = 4;
            s2131.Value = 3;
            s2132.Value = 6;
            s2133.Value = 2;

            s2111.Enabled = false;
            s2112.Enabled = true;
            s2113.Enabled = true;
            s2121.Enabled = false;
            s2122.Enabled = false;
            s2123.Enabled = false;
            s2131.Enabled = false;
            s2132.Enabled = false;
            s2133.Enabled = false;

            s2211.Value = 1;
            //s2212.Value = 2;
            //s2213.Value = 6;
            s2221.Value = 5;
            s2222.Value = 7;
            s2223.Value = 3;
            //s2231.Value = 4;
            //s2232.Value = 9;
            s2233.Value = 8;

            s2211.Enabled = false;
            s2212.Enabled = true;
            s2213.Enabled = true;
            s2221.Enabled = false;
            s2222.Enabled = false;
            s2223.Enabled = false;
            s2231.Enabled = true;
            s2232.Enabled = true;
            s2233.Enabled = false;

            s2311.Value = 9;
            s2312.Value = 4;
            s2313.Value = 3;
            s2321.Value = 8;
            s2322.Value = 6;
            s2323.Value = 2;
            //s2331.Value = 5;
            //s2332.Value = 7;
            s2333.Value = 1;

            s2311.Enabled = false;
            s2312.Enabled = false;
            s2313.Enabled = false;
            s2321.Enabled = false;
            s2322.Enabled = false;
            s2323.Enabled = false;
            s2331.Enabled = true;
            s2332.Enabled = true;
            s2333.Enabled = false;

            //s3111.Value = 2;
            s3112.Value = 9;
            //s3113.Value = 3;
            s3121.Value = 6;
            s3122.Value = 8;
            s3123.Value = 5;
            //s3131.Value = 4;
            //s3132.Value = 7;
            s3133.Value = 1;

            s3111.Enabled = true;
            s3112.Enabled = false;
            s3113.Enabled = true;
            s3121.Enabled = false;
            s3122.Enabled = false;
            s3123.Enabled = false;
            s3131.Enabled = true;
            s3132.Enabled = true;
            s3133.Enabled = false;

            s3211.Value = 6;
            s3212.Value = 4;
            s3213.Value = 5;
            s3221.Value = 2;
            //s3222.Value = 1;
            s3223.Value = 7;
            //s3231.Value = 3;
            s3232.Value = 8;
            //s3233.Value = 9;

            s3211.Enabled = false;
            s3212.Enabled = false;
            s3213.Enabled = false;
            s3221.Enabled = false;
            s3222.Enabled = true;
            s3223.Enabled = false;
            s3231.Enabled = true;
            s3232.Enabled = false;
            s3233.Enabled = true;


            s3311.Value = 1;
            s3312.Value = 8;
            s3313.Value = 7;
            //s3321.Value = 3;
            //s3322.Value = 9;
            s3323.Value = 4;
            s3331.Value = 2;
            s3332.Value = 5;
            s3333.Value = 6;

            s3311.Enabled = false;
            s3312.Enabled = false;
            s3313.Enabled = false;
            s3321.Enabled = true;
            s3322.Enabled = true;
            s3323.Enabled = false;
            s3331.Enabled = false;
            s3332.Enabled = false;
            s3333.Enabled = false;
        }
        private bool b11_r1(NumericUpDown n)
        {
            if (n.Value != s1111.Value && n.Value != s1112.Value &&
                n.Value != s1113.Value)
            {
                return true;
            }
            return false;
        }
        private bool b11_r2(NumericUpDown n)
        {
            if (n.Value != s1121.Value && n.Value != s1122.Value &&
                    n.Value != s1123.Value)
            {
                return true;
            }
            return false;
        }
        private bool b11_r3(NumericUpDown n)
        {
            if (n.Value != s1131.Value && n.Value != s1132.Value &&
                n.Value != s1133.Value)
            {
                return true;
            }
            return false;
        }
        private bool b11_c1(NumericUpDown n)
        {
            if (n.Value != s1111.Value && n.Value != s1121.Value &&
                n.Value != s1131.Value)
            {
                return true;
            }
            return false;
        }
        private bool b11_c2(NumericUpDown n)
        {
            if (n.Value != s1112.Value && n.Value != s1122.Value &&
                n.Value != s1123.Value)
            {
                return true;
            }
            return false;
        }
        private bool b11_c3(NumericUpDown n)
        {
            if (n.Value != s1113.Value && n.Value != s1123.Value &&
                n.Value != s1133.Value)
            {
                return true;
            }
            return false;
        }
        private bool b12_r1(NumericUpDown n)
        {
            if (n.Value != s1211.Value && n.Value != s1212.Value &&
                    n.Value != s1213.Value)
            {
                return true;
            }
            return false;
        }
        private bool b12_r2(NumericUpDown n)
        {
            if (n.Value != s1221.Value && n.Value != s1222.Value &&
                n.Value != s1223.Value)
            {
                return true;
            }
            return false;
        }
        private bool b12_r3(NumericUpDown n)
        {
            if (n.Value != s1231.Value && n.Value != s1232.Value &&
                n.Value != s1233.Value)
            {
                return true;
            }
            return false;
        }
        private bool b12_c1(NumericUpDown n)
        {
            if (n.Value != s1211.Value && n.Value != s1221.Value &&
                n.Value != s1231.Value)
            {
                return true;
            }
            return false;
        }
        private bool b12_c2(NumericUpDown n)
        {
            if (n.Value != s1212.Value && n.Value != s1222.Value &&
                n.Value != s1232.Value)
            {
                return true;
            }
            return false;
        }
        private bool b12_c3(NumericUpDown n)
        {
            if (n.Value != s1213.Value && n.Value != s1223.Value &&
                n.Value != s1233.Value)
            {
                return true;
            }
            return false;
        }
        private bool b13_r1(NumericUpDown n)
        {
            if (n.Value != s1311.Value &&
                    n.Value != s1312.Value && n.Value != s1313.Value)
            {
                return true;
            }
            return false;
        }
        private bool b13_r2(NumericUpDown n)
        {
            if (n.Value != s1321.Value &&
                n.Value != s1322.Value && n.Value != s1323.Value)
            {
                return true;
            }
            return false;
        }
        private bool b13_r3(NumericUpDown n)
        {
            if (n.Value != s1331.Value && n.Value != s1332.Value &&
                n.Value != s1333.Value)
            {
                return true;
            }
            return false;
        }
        private bool b13_c1(NumericUpDown n)
        {
            if (n.Value != s1311.Value && n.Value != s1321.Value &&
                n.Value != s1331.Value)
            {
                return true;
            }
            return false;
        }
        private bool b13_c2(NumericUpDown n)
        {
            if (n.Value != s1312.Value && n.Value != s1322.Value &&
                n.Value != s1332.Value)
            {
                return true;
            }
            return false;
        }
        private bool b13_c3(NumericUpDown n)
        {
            if (n.Value != s1313.Value && n.Value != s1323.Value &&
                n.Value != s1333.Value)
            {
                return true;
            }
            return false;
        }
        private bool b21_r1(NumericUpDown n)
        {
            if (n.Value != s2111.Value && n.Value != s2112.Value &&
                n.Value != s2113.Value)
            {
                return true;
            }
            return false;
        }
        private bool b21_r2(NumericUpDown n)
        {
            if (n.Value != s2121.Value && n.Value != s2122.Value &&
                n.Value != s2123.Value)
            {
                return true;
            }
            return false;
        }
        private bool b21_r3(NumericUpDown n)
        {
            if (n.Value != s2131.Value && n.Value != s2132.Value &&
                n.Value != s2133.Value)
            {
                return true;
            }
            return false;
        }
        private bool b21_c1(NumericUpDown n)
        {
            if (n.Value != s2111.Value && n.Value != s2121.Value &&
                    n.Value != s2131.Value)
            {
                return true;
            }
            return false;
        }
        private bool b21_c2(NumericUpDown n)
        {
            if (n.Value != s2112.Value && n.Value != s2122.Value &&
                    n.Value != s2132.Value)
            {
                return true;
            }
            return false;
        }
        private bool b21_c3(NumericUpDown n)
        {
            if (n.Value != s2113.Value && n.Value != s2123.Value &&
                n.Value != s2133.Value)
            {
                return true;
            }
            return false;
        }
        private bool b22_r1(NumericUpDown n)
        {
            if (n.Value != s2211.Value && n.Value != s2212.Value &&
                n.Value != s2213.Value)
            {
                return true;
            }
            return false;
        }
        private bool b22_r2(NumericUpDown n)
        {
            if (n.Value != s2221.Value && n.Value != s2222.Value &&
                n.Value != s2223.Value)
            {
                return true;
            }
            return false;
        }
        private bool b22_r3(NumericUpDown n)
        {
            if (n.Value != s2231.Value && n.Value != s2232.Value &&
                n.Value != s2233.Value)
            {
                return true;
            }
            return false;
        }
        private bool b22_c1(NumericUpDown n)
        {
            if (n.Value != s2211.Value && n.Value != s2221.Value &&
                n.Value != s2231.Value)
            {
                return true;
            }
            return false;
        }
        private bool b22_c2(NumericUpDown n)
        {
            if (n.Value != s2212.Value && n.Value != s2222.Value &&
                n.Value != s2232.Value)
            {
                return true;
            }
            return false;
        }
        private bool b22_c3(NumericUpDown n)
        {
            if (n.Value != s2213.Value && n.Value != s2223.Value &&
                n.Value != s2233.Value)
            {
                return true;
            }
            return false;
        }
        private bool b23_r1(NumericUpDown n)
        {
            if (n.Value != s2311.Value && n.Value != s2312.Value &&
                n.Value != s2313.Value)
            {
                return true;
            }
            return false;
        }
        private bool b23_r2(NumericUpDown n)
        {
            if (n.Value != s2321.Value && n.Value != s2322.Value &&
                n.Value != s2323.Value)
            {
                return true;
            }
            return false;
        }
        private bool b23_r3(NumericUpDown n)
        {
            if (n.Value != s2331.Value && n.Value != s2332.Value &&
                n.Value != s2333.Value)
            {
                return true;
            }
            return false;
        }
        private bool b23_c1(NumericUpDown n)
        {
            if (n.Value != s2311.Value && n.Value != s2321.Value &&
                n.Value != s2331.Value)
            {
                return true;
            }
            return false;
        }
        private bool b23_c2(NumericUpDown n)
        {
            if (n.Value != s2312.Value && n.Value != s2322.Value &&
                n.Value != s2332.Value)
            {
                return true;
            }
            return false;
        }
        private bool b23_c3(NumericUpDown n)
        {
            if (n.Value != s2313.Value && n.Value != s2323.Value &&
                n.Value != s2333.Value)
            {
                return true;
            }
            return false;
        }
        private bool b31_r1(NumericUpDown n)
        {
            if (n.Value != s3111.Value && n.Value != s3112.Value &&
                n.Value != s3113.Value)
            {
                return true;
            }
            return false;
        }
        private bool b31_r2(NumericUpDown n)
        {
            if (n.Value != s3121.Value && n.Value != s3122.Value &&
                n.Value != s3123.Value)
            {
                return true;
            }
            return false;
        }
        private bool b31_r3(NumericUpDown n)
        {
            if (n.Value != s3131.Value && n.Value != s3132.Value &&
                n.Value != s3133.Value)
            {
                return true;
            }
            return false;
        }
        private bool b31_c1(NumericUpDown n)
        {
            if (n.Value != s3111.Value &&
                    n.Value != s3121.Value && n.Value != s3131.Value)
            {
                return true;
            }
            return false;
        }

        private bool b31_c2(NumericUpDown n)
        {
            if (n.Value != s3112.Value &&
                    n.Value != s3122.Value && n.Value != s3132.Value)
            {
                return true;
            }
            return false;
        }
        private bool b31_c3(NumericUpDown n)
        {
            if (n.Value != s3113.Value && n.Value != s3123.Value &&
                n.Value != s3133.Value)
            {
                return true;
            }
            return false;
        }

        private bool b32_r1(NumericUpDown n)
        {
            if (n.Value != s3211.Value && n.Value != s3212.Value &&
                n.Value != s3213.Value)
            {
                return true;
            }
            return false;
        }
        private bool b32_r2(NumericUpDown n)
        {
            if (n.Value != s3221.Value && n.Value != s3222.Value &&
                n.Value != s3223.Value)
            {
                return true;
            }
            return false;
        }
        private bool b32_r3(NumericUpDown n)
        {
            if (n.Value != s3231.Value && n.Value != s3232.Value &&
                n.Value != s3233.Value)
            {
                return true;
            }
            return false;
        }
        private bool b32_c1(NumericUpDown n)
        {
            if (n.Value != s3211.Value && n.Value != s3221.Value &&
                n.Value != s3231.Value)
            {
                return true;
            }
            return false;
        }
        private bool b32_c2(NumericUpDown n)
        {
            if (n.Value != s3212.Value && n.Value != s3222.Value &&
                n.Value != s3232.Value)
            {
                return true;
            }
            return false;
        }
        private bool b32_c3(NumericUpDown n)
        {
            if (n.Value != s3213.Value && n.Value != s3223.Value &&
                n.Value != s3233.Value)
            {
                return true;
            }
            return false;
        }
        private bool b33_r1(NumericUpDown n)
        {
            if (n.Value != s3311.Value && n.Value != s3312.Value &&
                n.Value != s3313.Value)
            {
                return true;
            }
            return false;
        }
        private bool b33_r2(NumericUpDown n)
        {
            if (n.Value != s3321.Value && n.Value != s3322.Value &&
                n.Value != s3323.Value)
            {
                return true;
            }
            return false;
        }
        private bool b33_r3(NumericUpDown n)
        {
            if (n.Value != s3331.Value && n.Value != s3332.Value &&
                n.Value != s3333.Value)
            {
                return true;
            }
            return false;
        }
        private bool b33_c1(NumericUpDown n)
        {
            if (n.Value != s3311.Value && n.Value != s3321.Value &&
                n.Value != s3331.Value)
            {
                return true;
            }
            return false;
        }
        private bool b33_c2(NumericUpDown n)
        {
            if (n.Value != s3312.Value && n.Value != s3322.Value &&
                n.Value != s3332.Value)
            {
                return true;
            }
            return false;
        }
        private bool b33_c3(NumericUpDown n)
        {
            if (n.Value != s3313.Value && n.Value != s3323.Value &&
                n.Value != s3333.Value)
            {
                return true;
            }
            return false;
        }
        private void btnCheck_Click(object sender, EventArgs e)
        {
            bool[] valid = new bool[81];
            MessageBox.Show(valid[0].ToString());
            //--s11---
            if (s1111.Enabled)
            {
                if (s1111.Value != s1112.Value && s1111.Value != s1113.Value &&
                    b11_r2(s1111) && b11_r3(s1111) && b21_c1(s1111) &&
                    b31_c1(s1111) && b12_r1(s1111) && b13_r1(s1111))
                {
                    valid[0] = true;
                }
            }

            if (s1112.Enabled && valid[0])
            {
                if (s1112.Value != s1111.Value && s1112.Value != s1113.Value &&
                    b11_r2(s1112) && b11_r3(s1112) && b21_c2(s1112) &&
                    b31_c2(s1112) && b12_r1(s1112) && b13_r1(s1112))
                {
                    valid[1] = true;
                }
            }
            if (s1113.Enabled && valid[1])
            {
                if (s1113.Value != s1111.Value && s1113.Value != s1112.Value &&
                    b11_r2(s1113) && b11_r3(s1113) && b12_r1(s1113) &&
                    b13_r1(s1113) && b21_c3(s1113) && b31_c3(s1113))
                {
                    valid[2] = true;
                }
            }
            if (s1121.Enabled && valid[2])
            {
                if (b11_r1(s1121) && s1121.Value != s1122.Value &&
                    s1121.Value != s1123.Value && b11_r3(s1121) &&
                    b12_r2(s1121) && b13_r2(s1121) &&
                    b21_c1(s1121) && b31_c1(s1121))
                {
                    valid[3] = true;
                }
            }
            if (s1122.Enabled && valid[3])
            {
                if (b11_r1(s1122) && s1122.Value != s1121.Value &&
                    s1122.Value != s1123.Value && b11_r3(s1122) &&
                    b12_r2(s1122) && b13_r2(s1122) &&
                    b21_c2(s1122) && b31_c2(s1122))
                {
                    valid[4] = true;
                }
            }
            if (s1123.Enabled && valid[4])
            {
                if (b11_r1(s1123) && s1123.Value != s1121.Value &&
                    s1123.Value != s1122.Value && b11_r3(s1123) &&
                    b12_r2(s1123) && b13_r2(s1123) &&
                    b21_c3(s1123) && b31_c3(s1123))
                {
                    valid[5] = true;
                }
            }
            if (s1131.Enabled && valid[5])
            {
                if (b11_r1(s1131) && b11_r2(s1131) &&
                    s1131.Value != s1132.Value && s1131.Value != s1133.Value &&
                    b12_r3(s1131) && b13_r3(s1131) &&
                    b21_c1(s1131) && b31_c1(s1131))
                {
                    valid[6] = true;
                }
            }
            if (s1132.Enabled && valid[6])
            {
                if (b11_r1(s1132) && b11_r2(s1132) &&
                    s1132.Value != s1131.Value && s1132.Value != s1133.Value &&
                    b12_r3(s1132) && b13_r3(s1132) &&
                    b21_c2(s1132) && b31_c2(s1132))
                {
                    valid[7] = true;
                }
            }
            if (s1133.Enabled && valid[7])
            {
                if (b11_r1(s1133) && b11_r2(s1133) &&
                    s1133.Value != s1131.Value && s1133.Value != s1132.Value &&
                    b12_r3(s1133) && b13_r3(s1133) &&
                    b21_c3(s1133) && b31_c3(s1133))
                {
                    valid[8] = true;
                }
            }
            //--s12--
            if (s1211.Enabled && valid[8])
            {
                if (s1211.Value != s1212.Value && s1211.Value != s1213.Value &&
                    b12_r2(s1211) && b12_r3(s1211) && b22_c1(s1211) &&
                    b32_c1(s1211) && b11_r1(s1211) && b13_r1(s1211))
                {
                    valid[9] = true;
                }
            }
            if (s1212.Enabled && valid[9])
            {
                if (s1212.Value != s1211.Value && s1212.Value != s1213.Value &&
                    b12_r2(s1212) && b12_r3(s1212) && b13_r1(s1212) &&
                    b11_r1(s1212) && b22_c2(s1212) && b32_c2(s1212))
                {
                    valid[10] = true;
                }
            }
            if (s1213.Enabled && valid[10])
            {
                if (s1213.Value != s1211.Value && s1213.Value != s1212.Value &&
                    b12_r2(s1213) && b12_r3(s1213) && b13_r1(s1213) &&
                    b11_r1(s1212) && b22_c3(s1213) && b32_c3(s1213))
                {
                    valid[11] = true;
                }
            }
            if (s1221.Enabled && valid[11])
            {
                if (s1221.Value != s1222.Value && s1221.Value != s1223.Value &&
                    b12_r1(s1221) && b12_r3(s1221) && b11_r2(s1221) &&
                    b13_r2(s1221) && b22_c1(s1221) && b32_c1(s1221))
                {
                    valid[12] = true;
                }
            }
            if (s1222.Enabled && valid[12])
            {
                if (s1222.Value != s1211.Value && s1222.Value != s1223.Value &&
                    b12_r1(s1222) && b12_r3(s1222) && b11_r2(s1222) &&
                    b13_r2(s1222) && b22_c2(s1222) && b32_c2(s1222))
                {
                    valid[13] = true;
                }
            }
            if (s1223.Enabled && valid[13])
            {
                if (s1223.Value != s1221.Value && s1223.Value != s1222.Value &&
                    b12_r1(s1223) && b12_r3(s1223) && b11_r2(s1223) &&
                    b13_r2(s1223) && b22_c3(s1223) && b32_c3(s1223))
                {
                    valid[14] = true;
                }
            }
            if (s1231.Enabled && valid[14])
            {
                if (s1231.Value != s1232.Value && s1231.Value != s1233.Value &&
                    b12_r1(s1231) && b12_r2(s1231) && b11_r3(s1231) &&
                    b13_r3(s1232) && b22_c1(s1231) && b32_c1(s1231))
                {
                    valid[15] = true;
                }
            }
            if (s1232.Enabled && valid[15])
            {
                if (s1232.Value != s1231.Value && s1232.Value != s1233.Value &&
                    b12_r1(s1232) && b12_r2(s1232) && b11_r3(s1232) &&
                    b13_r3(s1232) && b22_c2(s1232) && b32_c2(s1232))
                {
                    valid[16] = true;
                }
            }
            if (s1233.Enabled && valid[16])
            {
                if (s1233.Value != s1232.Value && s1233.Value != s1231.Value &&
                    b12_r1(s1233) && b12_r2(s1233) && b11_r3(s1233) &&
                    b13_r3(s1233) && b22_c3(s1233) && b32_c3(s1233))
                {
                    valid[17] = true;
                }
            }
            //--s13--
            if (s1311.Enabled && valid[17])
            {
                if (s1311.Value != s1312.Value && s1311.Value != s1313.Value &&
                    b13_r2(s1311) && b13_r3(s1311) && b11_r1(s1311) &&
                    b12_r1(s1311) && b23_c1(s1311) && b33_c1(s1311))
                {
                    valid[18] = true;
                }
            }
            if (s1312.Enabled && valid[18])
            {
                if (s1312.Value != s1311.Value && s1312.Value != s1313.Value &&
                    b13_r2(s1312) && b13_r3(s1312) && b12_r1(s1312) &&
                    b11_r1(s1312) && b23_c2(s1312) && b33_c2(s1312))
                {
                    valid[19] = true;
                }
            }
            if (s1313.Enabled && valid[19])
            {
                if (s1313.Value != s1311.Value && s1313.Value != s1312.Value &&
                    b13_r2(s1313) && b13_r3(s1313) && b12_r1(s1313) &&
                    b11_r1(s1313) && b23_c3(s1313) && b33_c3(s1313))
                {
                    valid[20] = true;
                }
            }
            if (s1321.Enabled && valid[20])
            {
                if (s1321.Value != s1322.Value && s1321.Value != s1323.Value &&
                    b13_r1(s1321) && b13_r3(s1321) && b12_r2(s1321) &&
                    b11_r2(s1321) && b23_c1(s1321) && b33_c1(s1321))
                {
                    valid[21] = true;
                }
            }
            if (s1322.Enabled && valid[21])
            {
                if (s1322.Value != s1321.Value && s1322.Value != s1323.Value &&
                    b13_r1(s1322) && b13_r3(s1322) && b12_r2(s1322) &&
                    b11_r2(s1322) && b23_c2(s1322) && b33_c2(s1322))
                {
                    valid[22] = true;
                }
            }
            if (s1323.Enabled && valid[22])
            {
                if (s1323.Value != s1322.Value && s1323.Value != s1321.Value &&
                    b13_r1(s1323) && b13_r3(s1323) && b12_r2(s1323) &&
                    b11_r2(s1323) && b23_c3(s1323) && b33_c3(s1323))
                {
                    valid[23] = true;
                }
            }
            if (s1331.Enabled && valid[23])
            {
                if (s1331.Value != s1332.Value && s1331.Value != s1333.Value &&
                    b13_r1(s1331) && b13_r2(s1331) && b12_r3(s1331) &&
                    b11_r3(s1331) && b23_c1(s1331) && b33_c1(s1331))
                {
                    valid[24] = true;
                }
            }
            if (s1332.Enabled && valid[24])
            {
                if (s1332.Value != s1331.Value && s1332.Value != s1333.Value &&
                    b13_r1(s1332) && b13_r2(s1332) && b12_r3(s1332) &&
                    b11_r3(s1332) && b23_c2(s1332) && b33_c2(s1332))
                {
                    valid[25] = true;
                }
            }
            if (s1333.Enabled && valid[25])
            {
                if (s1333.Value != s1331.Value && s1333.Value != s1332.Value &&
                    b13_r1(s1333) && b13_r2(s1333) && b12_r3(s1333) &&
                    b11_r3(s1333) && b23_c3(s1333) && b33_c3(s1333))
                {
                    valid[26] = true;
                }
            }
            //--s21--
            if (s2111.Enabled && valid[26])
            {
                if (s2111.Value != s2112.Value && s2111.Value != s2113.Value &&
                    b21_r2(s2111) && b21_r3(s2111) && b22_r1(s2111) &&
                    b23_r1(s2111) && b11_c1(s2111) && b31_c1(s2111))
                {
                    valid[27] = true;
                }
            }
            if (s2112.Enabled && valid[27])
            {
                if (s2112.Value != s2111.Value && s2112.Value != s2113.Value &&
                    b21_r2(s2112) && b21_r3(s2112) && b22_r1(s2112) &&
                    b23_r1(s2112) && b11_c2(s2112) && b31_c2(s2112))
                {
                    valid[28] = true;
                }
            }
            if (s2113.Enabled && valid[28])
            {
                if (s2113.Value != s2111.Value && s2113.Value != s2112.Value &&
                    b21_r2(s2113) && b21_r3(s2113) && b22_r1(s2113) &&
                    b23_r1(s2113) && b11_c3(s2113) && b31_c3(s2113))
                {
                    valid[29] = true;
                }
            }
            if (s2121.Enabled && valid[29])
            {
                if(s2121.Value != s2122.Value && s2121.Value!=s2123.Value &&
                    b21_r1(s2121) && b21_r3(s2121) && b11_c1(s2121) &&
                    b13_c1(s2121) && b22_r2(s2121) && b23_r2(s2121))
                {
                    valid[30] = true;
                }
            }
            if (s2122.Enabled && valid[30])
            {
                if(s211)
            }
            if (s2123.Enabled)
            {

            }
            if (s2131.Enabled)
            {

            }
            if (s2132.Enabled)
            {

            }
            if (s2133.Enabled)
            {

            }
            //--s22--
            if (s2211.Enabled)
            {

            }
            if (s2212.Enabled)
            {

            }
            if (s2213.Enabled)
            {

            }
            if (s2221.Enabled)
            {

            }
            if (s2222.Enabled)
            {

            }
            if (s2223.Enabled)
            {

            }
            if (s2231.Enabled)
            {

            }
            if (s2232.Enabled)
            {

            }
            if (s2233.Enabled)
            {

            }
            //--s23--
            if (s2311.Enabled)
            {

            }
            if (s2312.Enabled)
            {

            }
            if (s2313.Enabled)
            {

            }
            if (s2321.Enabled)
            {

            }
            if (s2322.Enabled)
            {

            }
            if (s2323.Enabled)
            {

            }
            if (s2331.Enabled)
            {

            }
            if (s2332.Enabled)
            {

            }
            if (s2333.Enabled)
            {

            }
            //--s31--
            if (s3111.Enabled)
            {

            }
            if (s3112.Enabled)
            {

            }
            if (s3113.Enabled)
            {

            }
            if (s3121.Enabled)
            {

            }
            if (s3122.Enabled)
            {

            }
            if (s3123.Enabled)
            {

            }
            if (s3131.Enabled)
            {

            }
            if (s3132.Enabled)
            {

            }
            if (s3133.Enabled)
            {

            }
            //--s32--
            if (s3211.Enabled)
            {

            }
            if (s3212.Enabled)
            {

            }
            if (s3213.Enabled)
            {

            }
            if (s3221.Enabled)
            {

            }
            if (s3222.Enabled)
            {

            }
            if (s3223.Enabled)
            {

            }
            if (s3231.Enabled)
            {

            }
            if (s3232.Enabled)
            {

            }
            if (s3233.Enabled)
            {

            }
            //-s33--
            if (s3311.Enabled)
            {

            }
            if (s3312.Enabled)
            {

            }
            if (s3313.Enabled)
            {

            }
            if (s3321.Enabled)
            {

            }
            if (s3322.Enabled)
            {

            }
            if (s3323.Enabled)
            {

            }
            if (s3331.Enabled)
            {

            }
            if (s3332.Enabled)
            {

            }
            if (s3333.Enabled)
            {

            }
        }
    }
}
