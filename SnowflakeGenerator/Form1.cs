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

namespace SnowflakeGenerator
{
    public partial class Form1 : Form
    {
        static Snowflake snowflake;
        Thread childThread;

        List<Particle> particles = new List<Particle>();

        public Form1()
        {
            InitializeComponent();
            lbl_01.BackColor = pBx_main.BackColor;

            Gen_new_Snowflake();
        }

        public static void Thread_01()
        {
            snowflake.Generate_Snowflake();
        }

        private void pBx_main_Paint(object sender, PaintEventArgs e)
        {
            //e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            e.Graphics.TranslateTransform(pBx_main.Width / 2, pBx_main.Height / 2);
            e.Graphics.ScaleTransform(2, 2);
            lock (snowflake.particles)
            {
                particles = snowflake.particles.ToList();
            }

            foreach (var particle in particles)
            {
                e.Graphics.FillEllipse(Brushes.White, particle.Rectangle);
                e.Graphics.RotateTransform(60);
                e.Graphics.FillEllipse(Brushes.White, particle.Rectangle);
                e.Graphics.RotateTransform(60);
                e.Graphics.FillEllipse(Brushes.White, particle.Rectangle);
                e.Graphics.RotateTransform(60);
                e.Graphics.FillEllipse(Brushes.White, particle.Rectangle);
                e.Graphics.RotateTransform(60);
                e.Graphics.FillEllipse(Brushes.White, particle.Rectangle);
                e.Graphics.RotateTransform(60);
                e.Graphics.FillEllipse(Brushes.White, particle.Rectangle);
                e.Graphics.RotateTransform(60);
            }


            e.Graphics.ScaleTransform(1, -1);

            foreach (var particle in particles)
            {
                e.Graphics.FillEllipse(Brushes.White, particle.Rectangle);
                e.Graphics.RotateTransform(60);
                e.Graphics.FillEllipse(Brushes.White, particle.Rectangle);
                e.Graphics.RotateTransform(60);
                e.Graphics.FillEllipse(Brushes.White, particle.Rectangle);
                e.Graphics.RotateTransform(60);
                e.Graphics.FillEllipse(Brushes.White, particle.Rectangle);
                e.Graphics.RotateTransform(60);
                e.Graphics.FillEllipse(Brushes.White, particle.Rectangle);
                e.Graphics.RotateTransform(60);
                e.Graphics.FillEllipse(Brushes.White, particle.Rectangle);
                e.Graphics.RotateTransform(60);
            }


            e.Graphics.ResetTransform();

        }

        private void Btn_Generate_Click(object sender, EventArgs e)
        {
            Gen_new_Snowflake();
        }

        private void Gen_new_Snowflake()
        {
            if (childThread != null) childThread.Abort();
            snowflake = new Snowflake(pBx_main.Width, 1.1f);
            Snowflake.seed = tBx_seed.Text.GetHashCode();
            ThreadStart childref = new ThreadStart(Thread_01);
            childThread = new Thread(childref);
            childThread.Start();
        }

        private void tmr_16ms_Tick(object sender, EventArgs e)
        {
            pBx_main.Invalidate();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            childThread.Abort();
        }

        private void btn_new_Seed_Click(object sender, EventArgs e)
        {
            tBx_seed.Text = Guid.NewGuid().ToString();
        }

        private void btn_stop_Click(object sender, EventArgs e)
        {
            childThread.Abort();
        }
    }

    public class Snowflake
    {
        private float width;
        private float radius;
        public List<Particle> particles;
        Particle particle;
        public static int seed = 0;
        Random rnd;
        int spread = 4;

        public Snowflake(float width, float radius)
        {

            this.radius = radius;
            this.width = width;
            particles = new List<Particle>();
            particle = new Particle(width / 2, 0, radius);
            //seed = Guid.NewGuid().GetHashCode();
            rnd = new Random(seed);
        }

        public void Generate_Snowflake()
        {
            for (int i = 0; i < 200000; i++)
            {
                lock (particles)
                {
                    MoveParticle();
                    particles.Add(particle);
                }
                particle = new Particle(width / 2, 0, radius);
            }
        }

        private void MoveParticle()
        {
            while (!Particle_Finished())
            {
                particle.X--;
                particle.Y += rnd.Next(spread * -10000, (spread * 10000) + 1) / 10000;
            }
        }

        private void Stay_here_Particle()   //!!                    ^^
        {
            //Should stay in an triangle from (0|0), (width/2|0), (width/2|?) angle = 60°
            float a = Distance(0, 0, width / 2, 0);
            float h = Distance(0, 0, width / 2, (float)(a / (Math.Tan(2 * Math.PI / 12))));

            if (particle.Y < 0) particle.Y = 0;

            float k1 = h / a;
            float k2 = particle.Y / particle.X;
            if (particle.X * k1 < particle.X * k2)
            {
                particle.Y = k1 * particle.X;
            }
        }

        private bool Particle_Finished()
        {
            bool finished = false;
            bool intersects = false;

            finished = particle.X < 1;

            foreach (Particle p in particles)
            {
                float distance = Distance(p.X, p.Y, particle.X, particle.Y);
                if (distance < radius * 2)
                {
                    intersects = true;
                    break;
                }
            }

            Stay_here_Particle();

            return finished || intersects;
        }

        private float Distance(float x1, float y1, float x2, float y2)
        {
            x1 -= x2;
            y1 -= y2;
            x1 = To_Positive(x1);
            y1 = To_Positive(y1);
            return (float)Math.Sqrt(Math.Pow(x1, 2) + Math.Pow(y1, 2));
        }

        private float To_Positive(float num)
        {
            if (num < 0) num *= -1;
            return num;
        }
    }

    public class Particle
    {
        public Particle(float x, float y, float r)
        {
            X = x;
            Y = y;
            R = r;
        }

        public float X { get; set; }
        public float Y { get; set; }
        public float R { get; set; }
        public RectangleF Rectangle
        {
            get
            {
                return new RectangleF(X, Y, R * (float)1.05, R * (float)1.05);
            }
        }
    }
}
