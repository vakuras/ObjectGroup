using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace ObjectGroup
{
    public partial class MainWindow : Form
    {
        private int arraysize;
        private int groups; 
        private int[] objects;
        private int[] lastposition;
        private Color [] objscolor;
        private int index=-1;
        bool visual = false;
        private int selected = -1;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void _btnRandom_Click(object sender, EventArgs e)
        {
            arraysize = (int)_nudSize.Value;
            groups = (int)_nudGroups.Value;

            objects = new int[arraysize];

            Random rnd = new Random();

            for (int i = 0; i < objects.Length; i++)
                objects[i] = rnd.Next(groups);

            lastposition = new int[groups];
            objscolor = new Color[groups];
            index = 0;

            for(int i=0; i<lastposition.Length; i++)
            {
                lastposition[i] = -1;
                objscolor[i] = Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256));
            }

            Draw();
        }

        private void Draw()
        {
            Bitmap bmp = new Bitmap(480, 480);

            using (Graphics g = Graphics.FromImage(bmp))
            {
                g.Clear(Color.Black);

                int x = 0;
                int y = 0;

                for (int i = 0; i < objects.Length; i++)
                {
                    g.FillRectangle(new SolidBrush(objscolor[objects[i]]), x + 1, y + 1, 28, 28);

                    if (selected == i)
                        g.DrawRectangle(Pens.White, x, y, 30, 30);

                    x += 30;

                    if (x > bmp.Width-1)
                    {
                        x = 0;
                        y += 30;
                    }
                }
            }

            _picView.Image = bmp;
        }

        private void _nudSpeed_ValueChanged(object sender, EventArgs e)
        {
            _tmrSolve.Interval = ((10 - (int)_nudSpeed.Value) * 20) + 1;
        }

        private void _btnVisualSolve_Click(object sender, EventArgs e)
        {
            if (index != 0)
                return;

            _tmrSolve.Enabled = true;
            _btnRandom.Enabled = false;
            _btnSolve.Enabled = false;
            _btnVisualSolve.Enabled = false;
            _btnStop.Enabled = true;
            visual = true;
        }

        private void _btnStop_Click(object sender, EventArgs e)
        {
            _tmrSolve.Enabled = false;
            _btnRandom.Enabled = true;
            _btnSolve.Enabled = true;
            _btnVisualSolve.Enabled = true;
            _btnStop.Enabled = false;
        }

        private void _btnSolve_Click(object sender, EventArgs e)
        {
            visual = false;

            if (index != 0)
                return;

            while (!Solve()) { };

            Draw();
        }

        private bool Solve()
        {
            if (index >= objects.Length)
                return true;

            if (lastposition[objects[index]] != -1)
            {
                for (int i = 1; i < groups && objects[index - 1] != objects[index]; i++)
                {
                    int afterlast = lastposition[objects[index]] + 1;

                    if (afterlast >= index)
                        continue;

                    int tmp = objects[afterlast];

                    if (visual)
                        Select(afterlast);

                    objects[afterlast] = objects[index];

                    if (visual)
                        Select(afterlast);

                    objects[index] = tmp;

                    if (visual)
                        Select(index);

                    lastposition[objects[afterlast]] = afterlast;
                }
            }
            
            lastposition[objects[index]] = index;

            index++;

            return false;
        }

        private void Select(int i)
        {
            selected = i;
            Draw();
            _picView.Refresh();
            Thread.Sleep(_tmrSolve.Interval);
        }

        private void _tmrSolve_Tick(object sender, EventArgs e)
        {            
            bool res = Solve();
            selected = -1;
            Draw();

            if (res)
                _btnStop_Click(null, null);
        }


    }
}
