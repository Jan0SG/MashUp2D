using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Pt2pt
{
    public partial class MyForm : Form
    {
        static Figure f;
        Point ptX, ptY, mouse;
        Bitmap bmpX, bmpY;
        Graphics gX, gY;
        bool IsMouseDownX = false;
        bool IsMouseDownY = false;
        Canvas canvas;
        float deltaX = 0;
        float deltaY = 1;
        Scene scene;
        bool isMouseDown = false;
        bool LimitofSlider = false;
        private bool Iniciar = false;

        public MyForm()
        {
            InitializeComponent();
            Init();
            IsMouseDownX = false;            
        }

        private void Init()
        {   
            bmpX = new Bitmap(PCT_SLIDEER_X.Width, PCT_SLIDEER_X.Height);
            bmpY = new Bitmap(PCT_SLIDEER_Y.Width, PCT_SLIDEER_Y.Height);

            gX = Graphics.FromImage(bmpX);
            gY = Graphics.FromImage(bmpY);

            PCT_SLIDEER_X.Image = bmpX;
            PCT_SLIDEER_Y.Image = bmpY;

            gX.DrawLine(Pens.DarkRed, 0, bmpX.Height / 2, bmpX.Width, bmpX.Height / 2);
            gX.FillEllipse(Brushes.PaleVioletRed, bmpX.Width / 2, bmpX.Height / 4, bmpX.Height / 2, bmpX.Height / 2);

            gY.DrawLine(Pens.DarkRed, bmpY.Width / 2, 0,  bmpY.Width / 2, bmpY.Height);
            gY.FillEllipse(Brushes.PaleVioletRed, bmpY.Width / 4, bmpY.Height / 2, bmpX.Height / 2, bmpX.Height / 2);

            scene = new Scene();
            /*Figure fig = new Figure();
            fig.Add(new PointF(100, 120));
            fig.Add(new PointF(1400, 120));*/
            //scene.Figures.Add(fig);
            canvas = new Canvas(PCT_CANVAS);
            
        }
        private void PCT_SLIDEER_Y_MouseUp(object sender, MouseEventArgs e)
        {
            IsMouseDownY = false;
            gY.Clear(Color.Transparent);
            gY.DrawLine(Pens.DarkOliveGreen, bmpY.Width / 2, 0, bmpY.Width / 2, bmpY.Height);
            gY.FillEllipse(Brushes.ForestGreen, bmpY.Width / 4, bmpY.Height / 2, bmpX.Height / 2, bmpX.Height / 2);

            PCT_SLIDEER_Y.Invalidate();
        }

        private void PCT_SLIDEER_Y_MouseMove(object sender, MouseEventArgs e)
        {
            if (IsMouseDownY)
            {
                gY.Clear(Color.Transparent);
                gY.DrawLine(Pens.DarkOliveGreen, bmpY.Width / 2, 0, bmpY.Width / 2, bmpY.Height);
                gY.FillEllipse(Brushes.ForestGreen, bmpY.Width / 4, e.Y, bmpX.Height / 2, bmpX.Height / 2);

                PCT_SLIDEER_Y.Invalidate();
                deltaY += (float)(ptY.Y - e.Location.Y) / 500;//------------------
                ptY.Y = e.Location.Y;
            }
        }

        private void PCT_SLIDEER_Y_MouseDown(object sender, MouseEventArgs e)
        {
            ptY = e.Location;
            IsMouseDownY = true;
        }

        private void PCT_SLIDEER_X_MouseDown(object sender, MouseEventArgs e)
        {
            ptX = e.Location;
            IsMouseDownX = true;
        }

        private void PCT_SLIDEER_X_MouseMove(object sender, MouseEventArgs e)
        {
            if (IsMouseDownX)
            {
                gX.Clear(Color.Transparent);
                gX.DrawLine(Pens.DarkOliveGreen, 0, PCT_SLIDEER_X.Height / 2, PCT_SLIDEER_X.Width, PCT_SLIDEER_X.Height / 2);
                gX.FillEllipse(Brushes.GreenYellow, e.X, PCT_SLIDEER_X.Height / 4, PCT_SLIDEER_X.Height / 2, PCT_SLIDEER_X.Height / 2);

                PCT_SLIDEER_X.Invalidate();
                deltaX += (float)(e.Location.X - ptX.X) / 3; 
                ptX.X = e.Location.X;
            }
        }

        private void PCT_SLIDEER_X_MouseUp(object sender, MouseEventArgs e)
        {
            IsMouseDownX = false;
            gX.Clear(Color.Transparent);
            gX.DrawLine(Pens.DarkOliveGreen, 0, PCT_SLIDEER_X.Height / 2, PCT_SLIDEER_X.Width, PCT_SLIDEER_X.Height / 2);
            gX.FillEllipse(Brushes.GreenYellow, PCT_SLIDEER_X.Width / 2, PCT_SLIDEER_X.Height / 4, PCT_SLIDEER_X.Height / 2, PCT_SLIDEER_X.Height / 2);

            PCT_SLIDEER_X.Invalidate();
        }

        private void MyForm_Resize(object sender, EventArgs e)
        {
            canvas = new Canvas(PCT_CANVAS);
        }

        private void TIMER_Tick(object sender, EventArgs e)
        {
            if (f != null && (IsMouseDownX|| IsMouseDownY))
            {
                f.TranslateToOrigin();
                f.Scale(deltaY);
                f.Rotate(deltaX);                
                f.TranslatePoints(f.Centroid);

                f.arotacion += deltaX;
                f.aescala *= deltaY;
            }
            deltaX = 0;
            deltaY = 1;
            canvas.Render(scene);

            if (Iniciar)
            {
                if (trackBar1.Value < trackBar1.Maximum && LimitofSlider)
                {
                    trackBar1.Value++;
                    RunAnimation();
                }
                else if (trackBar1.Value > 0 && LimitofSlider)
                {
                    trackBar1.Value--;
                    RunAnimation();
                }
                else LimitofSlider = !LimitofSlider;
            }
        }

        private void RunAnimation()
        {
            //framesLabel.Text = "Frame: " + trackBar1.Value + "\nAvailable Frames: " + trackBar1.Maximum;

            if (checkBox1.Checked) foreach (Figure figure in scene.Figures)
                Animacion(figure);
            else
                Animacion(f);
        }

        private void Animacion(Figure figs)
        {
            
                int firstSavedFrame = -1;
                int finalSavedFrame = -1;
                float difference;

                float rotAngle; //Rotation preset on that frame
                float scaleFactor; //How much the size of the figure will increase on that frame

                if (scene.Figures.Count == 0 || figs.FPS[trackBar1.Value]) return; //It detects if we have created figures before starting an animation
                else
                {
                    for (int i = trackBar1.Value; i >= 0; i--)
                    {
                        if (figs.FPS[i])
                        {
                            firstSavedFrame = i;
                            break;
                        }
                    }
                    for (int i = trackBar1.Value; i <= figs.posiciones.Length - 1; i++)
                    {
                        if (figs.FPS[i])
                        {
                            finalSavedFrame = i;
                            break;
                        }
                    }
                }
                if (firstSavedFrame != -1 && finalSavedFrame != -1) //If there exist an initial and final frame the animation can start
                {

                    difference = ((float)trackBar1.Value - firstSavedFrame) / (finalSavedFrame - firstSavedFrame);

                    rotAngle = ((figs.rotaciones[finalSavedFrame] - figs.rotaciones[firstSavedFrame]) * difference) + figs.rotaciones[firstSavedFrame]; //This helps to play a possible stated rotation by taking into account the rotation of a point in comparison to another.
                    scaleFactor = ((figs.tamanios[finalSavedFrame] - figs.tamanios[firstSavedFrame]) * difference) + figs.tamanios[firstSavedFrame];

                    figs.Follow(figs.posiciones[firstSavedFrame], figs.posiciones[finalSavedFrame], difference); //This helps to go to the next point.
                    refresh(figs, rotAngle, scaleFactor); //Values are updated even before the tick
                
            }
        }

        private void refresh(Figure figs, float x, float y) //Method that helps to save and update more data as size, rotation.
        {

            if (figs != null)
            {
                figs.TranslateToOrigin();
                figs.Scale(1 / figs.aescala); //Cada que avancemos o retrocedamos un frame de la animación, elimina la escala que tenga volviendola 1
                figs.aescala *= 1 / figs.aescala;
                figs.Scale(y);
                figs.Rotate(-figs.arotacion + x); //Each frame it will reset the figure rotation and update it with the most recent. 
                figs.arotacion = x;
                figs.aescala = y;
                figs.TranslatePoints(figs.Centroid);
            }
        }

        private void PCT_CANVAS_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
                f.UpdateAttributes();
        }

        private void BTN_EXE_Click(object sender, EventArgs e)
        {
            f = new Figure(trackBar1.Maximum);
            scene.Figures.Add(f);
            TreeNode node = new TreeNode("Fig" + (TREE.Nodes.Count + 1));
            node.Tag = f;
            TREE.Nodes.Add(node);
        }   

        private void TREE_AfterSelect(object sender, TreeViewEventArgs e)
        {
            f = (Figure)TREE.SelectedNode.Tag;
            BTN_EXE.Select();
        }
        
        public static bool IsControlDown()
        {
            return (Control.ModifierKeys & Keys.Control) == Keys.Control;
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (f == null)
                return false;
            
            switch (keyData)
            {
                case Keys.Left:
                    f.Centroid.X -= 3;                  
                    break;
                case Keys.Right:
                    f.Centroid.X += 3;
                    break;
                case Keys.Up:
                    f.Centroid.Y += -3;
                    break;
                case Keys.Down:
                    f.Centroid.Y += 3;
                    break;
                case Keys.Space:
                    break;
            }
            PCT_CANVAS.Select();
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void PCT_CANVAS_MouseDown(object sender, MouseEventArgs e)
        {
            mouse = e.Location;
            isMouseDown = true;
        }

        private void PCT_CANVAS_MouseUp(object sender, MouseEventArgs e)
        {
            isMouseDown = false;
            PCT_CANVAS.Select();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            f.FPS[trackBar1.Value] = true;
            f.posiciones[trackBar1.Value] = f.Centroid;
            f.rotaciones[trackBar1.Value] = f.arotacion;
            f.tamanios[trackBar1.Value] = f.aescala;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Iniciar = !Iniciar;

            if (Iniciar)
                button2.Text = "PAUSA";
            else
                button2.Text = "PLAY";
        }

        private void PCT_CANVAS_MouseMove(object sender, MouseEventArgs e)
        {
            if (isMouseDown)
            {
                mouse.X -= e.X;
                mouse.Y -= e.Y;
                f.TranslatePoints(new Point(-mouse.X,-mouse.Y));
                f.UpdateAttributes();
                mouse = e.Location;
            }            
        }

        private void PCT_CANVAS_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (f != null)
            {
                f.Add(new PointF(e.X, e.Y));
            }
        }

        private void TREE_KeyPress(object sender, KeyPressEventArgs e)
        {
            return;
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            //LBL_STATUS.Text = " ::: " + (float)trackBar1.Value / 100;            
            //f.Follow(scene.Figures[0].Pts[0], scene.Figures[0].Pts[1], (float)trackBar1.Value / 100);
            RunAnimation();
        }


    }
}