using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Snow1
{
    public partial class FormMain : Form
    {
        public struct Snowflake
        {
            public Snowflake(float x, float y, float speed, float size, float time)
            {
                this.X = x;
                this.Y = y;
                this.Speed = speed;
                this.Size = size;
                this.Time = time;
            }

            public float X { get; set; }
            public float Y { get; set; }
            public float Speed { get; set; }
            public float Size { get; set; }
            public float Time { get; set; }
        }

        Graphics Canvas;
        Random rnd;
        Bitmap Back;

        Snowflake[] Snowflacks;

        readonly int SnowflakeCount = 240;

        public FormMain()
        {
            InitializeComponent();

            Start();
        }

        private void MakeSnowflake()
        {
            for (int i = 0; i < SnowflakeCount; i++)
            {
                float addSpeed = 3 + (float)rnd.NextDouble() + (float)rnd.NextDouble() + (float)rnd.NextDouble();
                Snowflacks[i] = new Snowflake(rnd.Next(-100, 550), rnd.Next(0, 580), addSpeed, rnd.Next(4, 12), 1);
            }
        }

        private void Start()
        {
            rnd = new Random();

            Back = new Bitmap("backB.png", true);

            //Canvas = Canvas_Box.CreateGraphics();

            Bitmap myBitmap = new Bitmap(Width, Height);

            Canvas_Box.Image = myBitmap;

            Canvas = Graphics.FromImage(Canvas_Box.Image);
            Snowflacks = new Snowflake[SnowflakeCount];
            MakeSnowflake();
        }

        private void Canvas_Box_Paint(object sender, PaintEventArgs e)
        {
            this.Width = 573;
            this.Height = 561;

            SolidBrush SnowBrush = new SolidBrush(Color.LightGray);

            //Canvas.Clear(Color.Black);
            Canvas.DrawImage(Back, -240, 0);

            for (int i = 0; i < SnowflakeCount; i++)
            {
                Canvas.FillEllipse(SnowBrush, Snowflacks[i].X, Snowflacks[i].Y, Snowflacks[i].Size, Snowflacks[i].Size);

                Snowflacks[i].Time += 0.4f;
                Snowflacks[i].X += (float)Math.Sin(Snowflacks[i].Time) * 5;


                if (Snowflacks[i].Y > 600)
                {
                    Snowflacks[i].Y = 0;
                    Snowflacks[i].Time = 0;
                }
                if (Snowflacks[i].X > 580 & Snowflacks[i].X < -5)
                {
                    Snowflacks[i].X = rnd.Next(0, 580);
                }
                else
                {
                    Snowflacks[i].Y += Snowflacks[i].Speed;
                }
            }

        }

        private void TimerUpdate_Tick(object sender, EventArgs e)
        {
            //this.InvokePaint(Canvas_Box, new PaintEventArgs(Canvas, new Rectangle(0, 0, Form.ActiveForm.Width, Form.ActiveForm.Height)));
            Canvas_Box.Invalidate();
        }
    }
}
