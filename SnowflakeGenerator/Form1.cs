﻿using System;
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
        public Form1()
        {
            InitializeComponent();
            lbl_01.BackColor = pBx_main.BackColor;

            snowflake = new Snowflake(pBx_main.Width, 1);

            ThreadStart childref = new ThreadStart(Thread_01);
            Console.WriteLine("In Main: Creating the Child thread");

            Thread childThread = new Thread(childref);
            childThread.Start();

            
        }

        public static void Thread_01()
        {
            snowflake.Generate_Snowflake();
        }

        private void pBx_main_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.TranslateTransform(pBx_main.Width / 2, pBx_main.Height / 2);
            e.Graphics.ScaleTransform(2, 2);
            lock (snowflake.particles)
            {
                foreach (var particle in snowflake.particles)
                {
                    e.Graphics.FillEllipse(Brushes.White, particle.Rectangle);
                }
            }

        }

        private void Btn_Generate_Click(object sender, EventArgs e)
        {

        }

        private void tmr_16ms_Tick(object sender, EventArgs e)
        {
            pBx_main.Invalidate();
        }
    }

    public class Snowflake
    {
        private float width;
        private float radius;
        public List<Particle> particles;
        Particle particle;
        int seed;
        Random rnd;

        public Snowflake(float width, float radius)
        {

            this.radius = radius;
            this.width = width;
            particles = new List<Particle>();
            particle = new Particle(width / 2, 0, radius);
            seed = Guid.NewGuid().GetHashCode();
            rnd = new Random(seed);
        }

        public void Generate_Snowflake()
        {
            for (int i = 0; i < 2000; i++)
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
                particle.Y += rnd.Next(-2000, 2001) / 1000;
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
                return new RectangleF(X, Y, R * 2, R * 2);
            }
        }
    }
}
