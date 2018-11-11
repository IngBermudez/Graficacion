﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Imaging;
using System.Drawing.Drawing2D;


namespace PickleRick
{
    public partial class Form1 : Form
    {
        #region Cdigop1
        public Form1()
        {
            InitializeComponent();
           
        }


        Point sp = new Point(0, 0);
        int cX, cY, x, y, dX, dY;
        int k = 0;
        Point ep = new Point(0, 0);

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
        }
       
        private void Form1_Paint(object sender, PaintEventArgs e)
        {


        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
        
                sp = e.Location;
                if (e.Button == MouseButtons.Left)
                {
                    k = 1;
                }
                cX = e.X;
                cY = e.Y;
            
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            labelx1.Text = "X: " + Convert.ToString(x);
            labely.Text = "y: " + Convert.ToString(y);
            if (k == 1)
            {
                ep = e.Location;
                x = e.X;
                y = e.Y;
            }
            sp = ep;
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            if (k == 1)
            {
                x = e.X;
                y = e.Y;
                dX = e.X - cX;
                dY = e.Y - cY;
            }
        }
#endregion
        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {


            #region ColorDest
            System.Drawing.Color Dest1 = System.Drawing.ColorTranslator.FromHtml("#5B3832");
            System.Drawing.Color Dest2 = System.Drawing.ColorTranslator.FromHtml("#765953");
            System.Drawing.Color Dest3 = System.Drawing.ColorTranslator.FromHtml("#493A27");
            System.Drawing.Color Dest4 = System.Drawing.ColorTranslator.FromHtml("#977D58");
            SolidBrush ColoDest1 = new SolidBrush(Dest1);
            SolidBrush ColoDest2 = new SolidBrush(Dest2);
            SolidBrush ColoDest3 = new SolidBrush(Dest3);
            SolidBrush ColoDest4 = new SolidBrush(Dest4);
            #endregion
            #region ColoresParedes
            System.Drawing.Color ColoFondoPared= System.Drawing.ColorTranslator.FromHtml("#54554D");
            SolidBrush ColorPared1 = new SolidBrush(ColoFondoPared);
            System.Drawing.Color ColoBordePared = System.Drawing.ColorTranslator.FromHtml("#49443E");
            SolidBrush ColorPared2 = new SolidBrush(ColoFondoPared);
            System.Drawing.Color ColoFondoG = System.Drawing.ColorTranslator.FromHtml("#656058");
            SolidBrush ColorFG = new SolidBrush(ColoFondoG);

            System.Drawing.Color ColoF1 = System.Drawing.ColorTranslator.FromHtml("#302F2A");
            SolidBrush ColorF1 = new SolidBrush(ColoF1);
            System.Drawing.Color ColoF2 = System.Drawing.ColorTranslator.FromHtml(" #817867");
            SolidBrush ColorF2 = new SolidBrush(ColoF2);
            System.Drawing.Color ColoF3 = System.Drawing.ColorTranslator.FromHtml("#655B51");
            SolidBrush ColorF3 = new SolidBrush(ColoF3);
            System.Drawing.Color ColoF4 = System.Drawing.ColorTranslator.FromHtml("#C4BAB0");
            SolidBrush ColorF4 = new SolidBrush(ColoF4);
            System.Drawing.Color ColoF5 = System.Drawing.ColorTranslator.FromHtml("#7C7362");
            SolidBrush ColorF5 = new SolidBrush(ColoF5);
            System.Drawing.Color ColoF6 = System.Drawing.ColorTranslator.FromHtml("#423731");
            SolidBrush ColorF6 = new SolidBrush(ColoF6);
            System.Drawing.Color ColoF7 = System.Drawing.ColorTranslator.FromHtml("#5F5B58");
            SolidBrush ColorF7 = new SolidBrush(ColoF7);
            System.Drawing.Color ColoF8 = System.Drawing.ColorTranslator.FromHtml("#3D3930");
            SolidBrush ColorF8 = new SolidBrush(ColoF8);
            System.Drawing.Color ColoF9 = System.Drawing.ColorTranslator.FromHtml("#B6A087");
            SolidBrush ColorF9 = new SolidBrush(ColoF9);
            System.Drawing.Color ColoF10 = System.Drawing.ColorTranslator.FromHtml("#A25C50");
            SolidBrush ColorF10 = new SolidBrush(ColoF10);
            System.Drawing.Color ColoF11 = System.Drawing.ColorTranslator.FromHtml("#353535");
            SolidBrush ColorF11 = new SolidBrush(ColoF11);
            System.Drawing.Color ColoF12 = System.Drawing.ColorTranslator.FromHtml("#7C5D5D");
            SolidBrush ColorF12 = new SolidBrush(ColoF12);
            System.Drawing.Color ColoF13 = System.Drawing.ColorTranslator.FromHtml("#2D282C");
            SolidBrush ColorF13 = new SolidBrush(ColoF13);
            System.Drawing.Color ColoF14 = System.Drawing.ColorTranslator.FromHtml("#4F484F");
            SolidBrush ColorF14 = new SolidBrush(ColoF14);
            System.Drawing.Color ColoF15 = System.Drawing.ColorTranslator.FromHtml("#A0A0A0");
            SolidBrush ColorF15 = new SolidBrush(ColoF15);
            System.Drawing.Color ColoF16 = System.Drawing.ColorTranslator.FromHtml("#595959");
            SolidBrush ColorF16 = new SolidBrush(ColoF16);
            System.Drawing.Color ColoF17 = System.Drawing.ColorTranslator.FromHtml("#353535");
            SolidBrush ColorF17 = new SolidBrush(ColoF17);
            System.Drawing.Color ColoF18 = System.Drawing.ColorTranslator.FromHtml("#77615C");
            SolidBrush ColorF18 = new SolidBrush(ColoF18);
            System.Drawing.Color ColoF19 = System.Drawing.ColorTranslator.FromHtml("#4E6F28");
            SolidBrush ColorF19 = new SolidBrush(ColoF19);
            System.Drawing.Color ColoF20 = System.Drawing.ColorTranslator.FromHtml("#6D605A");
            SolidBrush ColorF20 = new SolidBrush(ColoF20);
            System.Drawing.Color ColoF21 = System.Drawing.ColorTranslator.FromHtml("#483934");
            SolidBrush ColorF21 = new SolidBrush(ColoF21);
            System.Drawing.Color ColoF22 = System.Drawing.ColorTranslator.FromHtml("#634F4B");
            SolidBrush ColorF22 = new SolidBrush(ColoF22);
            System.Drawing.Color ColoF23 = System.Drawing.ColorTranslator.FromHtml("#BE6C68");
            SolidBrush ColorF23 = new SolidBrush(ColoF23);

            #endregion
            #region ColorMueble
            System.Drawing.Color ColoM1 = System.Drawing.ColorTranslator.FromHtml("#413936");
            SolidBrush ColorM1 = new SolidBrush(ColoM1);
            System.Drawing.Color ColoM2 = System.Drawing.ColorTranslator.FromHtml("#2D2D25");
            SolidBrush ColorM2 = new SolidBrush(ColoM2);
            System.Drawing.Color ColoM3 = System.Drawing.ColorTranslator.FromHtml("#4E443A");
            SolidBrush ColorM3 = new SolidBrush(ColoM3);

            
            #endregion

            SolidBrush ColorNegro = new SolidBrush(Color.Black);
            SolidBrush ColorHuesos = new SolidBrush(Color.Gray);
           
            SolidBrush ColorMuñecaSuperiorIzquierda = new SolidBrush(Color.Orange);
            SolidBrush ColorMuñecaInferiorIzquierda1 = new SolidBrush(Color.DimGray);
            SolidBrush ColorMuñecaInferiorIzquierda2 = new SolidBrush(Color.Gray);
            Pen pnegro = new Pen(Color.Black, 2);
            Pen PDelg = new Pen(Color.Black, 1);
            Pen PGrue = new Pen(Color.Black, 3);
            Pen PVerde = new Pen(Color.Green, 2);
            //Color PH=ColorTranslator.FromHtml("")
            Pen PHuesoEse = new Pen(ColoF9, 4);
            Pen PiernaSuperiorIzquierdaPalos = new Pen(ColoF20, 4);
            Graphics g = e.Graphics;
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            #region Fondo
            Point[] C00 =
            {
                new Point(589,437),
                new Point(538,0),
                new Point(0,0),
                new Point(0,438)
                 
            }; 
            Point[] F1 =
            {
                new Point(589,437),
                new Point(847,386),
                new Point(847,464),
                new Point(587,465)
            };
            Point[] F2 =
            {
                new Point(589,437),
                new Point(179,437),
                new Point(177,469),
                new Point(587,465)
            };
            Point[] F3 =
            {
                new Point(589,437),
                new Point(847,386),
                new Point(847,135),
                new Point(538,0)
            };
            Point[] F4 = 
            {
                new Point(538,0),
                new Point(847,135),
                new Point(847,0)
                
            };
            Point[] F5 = 
            {
                new Point(0,474),
                new Point(49,473),
                new Point(178,468),
                new Point(587,465),
                new Point(847,465),
                new Point(847,567),
                new Point(0,567)
            };

            g.FillPolygon(ColorFG, C00);
            g.DrawPolygon(PDelg, F1);
            g.FillPolygon(ColorF1,F1);
            g.DrawPolygon(PDelg, F2);
            g.FillPolygon(ColorF1, F2);
            g.DrawPolygon(PDelg, F3);
            g.FillPolygon(ColorF2, F3);
            g.DrawPolygon(PDelg, F4);
            g.FillPolygon(ColorF3, F4);
            g.DrawPolygon(PDelg, F5);
            g.FillPolygon(ColorF4, F5);
            g.DrawLine(PDelg,194,473,0,485);
            g.DrawLine(PDelg,316,470,0,503);
            g.DrawLine(PDelg,363,468,89,567);
            g.DrawLine(PDelg,427,469,430,567);
            g.DrawLine(PDelg,471,469,725,567);
            g.DrawLine(PDelg,501,469,848,512);
            g.DrawLine(PDelg,0,560,848,559);
            g.DrawLine(PDelg,0,522,848,522);
            g.DrawLine(PDelg,0,494,848,489);
            g.DrawLine(PDelg,0,484,848,472);
            g.DrawLine(PDelg,111,472,848,467);
           
            #endregion

            #region CuadrosParedes
            Point[] C21 = 
            {
                new Point(341,4),
                new Point(415,0),
                new Point(518,0),
                new Point(547,220),
                new Point(334,224)
            };
            Point[] C22 = 
            {
                new Point(335,0),
                new Point(524,0),
                new Point(554,227),
                new Point(328,231)
            };
            Point[] C31 = 
            {
                new Point(212,284),
                new Point(552,276),
                new Point(568,425),
                new Point(201,427)
            };
            Point[] C32 = 
            {
                new Point(217,289),
                new Point(548,282),
                new Point(562,421),
                new Point(206,421)
            };
            Point[] C41 = 
            {
                new Point(573,200),
                new Point(548,0),
                new Point(695,0)
                
            };
            Point[] C42 = 
            {
                new Point(576,182),
                new Point(557,0),
                new Point(687,0)
            };
            Point[] C51 = 
            {
                new Point(581,266),
                new Point(758,36),
                new Point(824,360),
                new Point(601,423)
            };
            Point[] C52 = 
            {
                new Point(589,268),
                new Point(753,59),
                new Point(811,351),
                new Point(606,416)
            };
            g.DrawPolygon(pnegro, C22);
            g.FillPolygon(ColorPared1, C22);
            g.DrawPolygon(pnegro,C21);
            g.FillPolygon(ColorPared1, C21);
            g.DrawPolygon(pnegro, C31);
            g.FillPolygon(ColorPared1, C31);
            g.DrawPolygon(pnegro, C32);
            g.FillPolygon(ColorPared1, C32);


            g.DrawPolygon(pnegro, C41);
            //g.FillPolygon(ColorPared1, C41);
            g.DrawPolygon(pnegro, C42);
            //g.FillPolygon(ColorPared1, C42);
            g.DrawPolygon(pnegro, C51);
            //g.FillPolygon(ColorPared, C41);
            g.DrawPolygon(pnegro, C52);
            

            g.DrawLine(pnegro,573,200,576,182);
            g.DrawLine(pnegro, 341, 4, 335, 0);g.DrawLine(pnegro,547,220,554,227);g.DrawLine(pnegro,334,224,328,231);
            g.DrawLine(pnegro,193,245,563,238);g.DrawLine(pnegro,194,250,564,245);g.DrawLine(pnegro,197,261,565,255);g.DrawLine(pnegro,196,266,567,260);
            g.DrawLine(pnegro,563,238,717,0);g.DrawLine(pnegro,564,245,725,0);g.DrawLine(pnegro,565,255,735,0);g.DrawLine(pnegro,567,260,745,0);
            
            g.DrawLine(pnegro,766,0,848,365);g.DrawLine(pnegro,774,0,848,315);g.DrawLine(pnegro,779,0,848,294);
            g.DrawLine(pnegro,795,0,848,213);g.DrawLine(pnegro,805,0,848,174);g.DrawLine(pnegro,817,0,848,123);
            Point[] F6 =
            {
                new Point(817,0),
                new Point(848,123),
                new Point(848,0)
            };
            
            g.FillPolygon(ColorF6, F6);
            Point[] F7 =
            {
                new Point(821,0),
                new Point(831,38),
                new Point(848,20),
                new Point(848,0)
            };
            g.DrawPolygon(pnegro, F7);
            g.FillPolygon(ColorPared1,F7);
            Point[] F8 =
            {
                new Point(836,11),
                new Point(821,8),
                new Point(813,0),
                new Point(831,2),
                new Point(837,7)
                
            };
            g.DrawClosedCurve(pnegro,F8);
            g.FillClosedCurve(ColorF7,F8);
           
            

            #endregion

            #region MuebleNuevo
            Point[] M1 =
            {
                new Point(56,419),
                new Point(178,437),
                new Point(177,469),
                new Point(49,473)
              };
            g.DrawPolygon(pnegro,M1);
            g.FillPolygon(ColorM1, M1);
            Point[] M2 =
            {
                new Point(55,419),
                new Point(49,473),
                new Point(0,475),
                new Point(0,419)
                
              
            };
            g.DrawPolygon(pnegro, M2);
            g.FillPolygon(ColorM2, M2);
            Point[] M3 =
            {
                new Point(0,232),
                new Point(38,232),
                new Point(17,419),
                new Point(0,419)
                
              
            };
            g.DrawPolygon(pnegro, M3);
            g.FillPolygon(ColorM2, M3);
            g.FillPolygon(ColorM2, M2);
            Point[] M4 =
            {
                new Point(0,232),
                new Point(38,232),
                new Point(38,229),
                new Point(0,229)
                
              
            };
            g.DrawPolygon(pnegro, M4);
            g.FillPolygon(ColorM2, M4);
            Point[] M5 =
            {
                new Point(0,229),
                new Point(38,229),
                new Point(44,169),
                new Point(0,170)
              
            };
            g.DrawPolygon(pnegro, M5);
            g.FillPolygon(ColorM2, M5);
            Point[] M6 =
            {
                new Point(0,218),
                new Point(14,218),
                new Point(19,182),
                new Point(0,182)
              
            };
            g.DrawPolygon(pnegro, M6);
            g.FillPolygon(ColorM2, M6);
            Point[] M7 =
            {
                new Point(0,213),
                new Point(10,213),
                new Point(13,188),
                new Point(0,188)
              
            };
            g.DrawPolygon(pnegro, M7);
            g.FillPolygon(ColorM2, M7);
            Point[] M8 =
            {
                new Point(0,170),
                new Point(72,168),
                new Point(191,270),
                new Point(197,270),
                new Point(77,162),
                new Point(0,164)
              
            };
            g.DrawPolygon(pnegro, M8);
            g.FillPolygon(ColorM2, M8);
            Point[] M9 =
            {
                new Point(44,165),
                new Point(72,165),
                new Point(47,418),
                new Point(17,418)
                
                
              
            };
            g.DrawPolygon(pnegro, M9);
            g.FillPolygon(ColorM2, M9);
            Point[] M10 =
            {
                new Point(72,168),
                new Point(191,270),
                new Point(174,438),
                new Point(47,418)
            };
            g.DrawPolygon(pnegro, M10);
            g.FillPolygon(ColorM1, M10);
            Point[] M11 =
            {
                new Point(89,203),
                new Point(178,279),
                new Point(162,423),
                new Point(69,405)
            };
            g.DrawPolygon(pnegro, M11);
            g.FillPolygon(ColorM1, M11);


            #endregion

            #region Espejo
            e.Graphics.DrawLine(pnegro, 2, 34, 185, 26);
            e.Graphics.DrawLine(pnegro, 186, 26, 168, 185);
            e.Graphics.DrawLine(pnegro, 168, 185, 125, 189);
            e.Graphics.DrawLine(pnegro, 147, 210, 191, 208);
            e.Graphics.DrawLine(pnegro, 172, 190, 190, 22);
            e.Graphics.DrawLine(pnegro, 189, 19, 1, 26);
            e.Graphics.DrawLine(pnegro, 130, 192, 172, 190);
            e.Graphics.DrawLine(pnegro, 196, 217, 156, 217);
            e.Graphics.DrawLine(pnegro, 190, 210, 194, 215);
            e.Graphics.DrawLine(pnegro, 190, 208, 210, 4);
            e.Graphics.DrawLine(pnegro, 195, 214, 214, 10);
            e.Graphics.DrawLine(pnegro, 210, 5, 215, 11);
            e.Graphics.DrawLine(pnegro, 0, 12, 209, 4);
            g.DrawLine(pnegro, 190, 19, 190, 32);
            #endregion

            #region cabeza
            //Point[] myPointArray ={p1, new Point(402, 138), new Point(407, 130), new Point(434, 126) };
            //Point[] myPointArray1 ={new Point(0, 0), new Point(60, 20), new Point(40, 50) };
            //g.DrawClosedCurve(pnegro, myPointArray1);

            //g.DrawPolygon(pnegro, myPointArray);
            e.Graphics.DrawBezier(pnegro, 393, 162, 402,138,407,130,434,126);
            e.Graphics.DrawBezier(pnegro, 434,126, 454, 131, 466, 136, 470, 158);
            e.Graphics.DrawBezier(pnegro, 393, 161, 392, 183, 392, 205, 393, 221);
            e.Graphics.DrawBezier(pnegro, 469, 158, 469, 174, 470, 194, 470, 211);
            e.Graphics.DrawBezier(pnegro, 469, 178,477 , 180, 478, 192, 471, 204);
            #endregion

            #region BrazoIzquierdo
            //Hombro
            Point[] HombroIzquierdo =
                {
                new Point(399, 252),
                new Point(404, 238),
                new Point(402, 227),
                new Point(400, 225),
                new Point(389,220),
                new Point(373, 222),
                new Point(365, 231),
                new Point(357, 239),
                new Point(356, 245),
                new Point(358,267),
                new Point(362, 254),
                new Point(362, 265),
                new Point(366, 261),
                new Point(364, 267),
                new Point(369, 262),
                new Point(370, 263),
                new Point(377, 262),
                new Point(392, 253),
                new Point(398, 247)};

            //Brazo
            Point[] BrazoSuperior =
                {
                new Point(365, 246),
                new Point(353, 262),
                new Point(347, 274),
                new Point(340, 299),
                new Point(342, 302),
                new Point(351, 302),
                new Point(362, 292),
                new Point(371, 283),
                new Point(380, 271),
                new Point(395, 245)};

            Point[] BrazoInferior =
                {
                new Point(341, 291),
                new Point(334, 292),
                new Point(332, 298),
                new Point(333, 307),
                new Point(329, 315),
                new Point(328, 328),
                new Point(326, 338),
                new Point(334, 340),
                new Point(338, 333),
                new Point(339, 325),
                new Point(345, 313),
                new Point(354, 307),
                new Point(354, 302),
                new Point(342, 303),
                new Point(339, 300)};
            #endregion

            #region BrazoDerecho
            //Hombro
            e.Graphics.DrawLine(pnegro, 486, 210, 470, 211);
            e.Graphics.DrawLine(pnegro, 189, 24, 189, 30);
            e.Graphics.DrawLine(pnegro, 474, 258, 497, 241);
            e.Graphics.DrawBezier(pnegro, 485, 210, 497, 216, 499, 230, 496,242);

            //Brazo
            e.Graphics.DrawLine(pnegro, 486, 247, 512, 278);
            e.Graphics.DrawLine(pnegro, 474, 258, 506, 293);
            e.Graphics.DrawBezier(pnegro, 506, 287, 498, 298, 523, 299,528, 291);
            e.Graphics.DrawLine(pnegro, 506, 287, 523,257);
            e.Graphics.DrawBezier(pnegro, 519, 296, 521, 288, 526, 277, 532, 264);
            e.Graphics.DrawBezier(pnegro, 528, 292, 527, 285, 528, 276, 533, 262);
            #endregion

            #region ManoDerecha
            //new Point p2 =new Point ()
            e.Graphics.DrawBezier(pnegro, 519, 248, 522,261, 533, 264, 538, 262);
            e.Graphics.DrawLine(pnegro, 519, 248, 532, 217);
            e.Graphics.DrawLine(pnegro, 539, 262, 558, 251);
            e.Graphics.DrawLine(pnegro, 539, 262, 548, 229);
            e.Graphics.DrawBezier(pnegro, 534, 208,528, 218, 534, 226, 546, 229);
            e.Graphics.DrawLine(pnegro, 547, 228, 565, 218);
            e.Graphics.DrawLine(pnegro, 565, 218, 559, 212);
            e.Graphics.DrawLine(pnegro, 556, 252, 559, 242);
            //e.Graphics.DrawBezier(pnegro, 559, 213, 554, 223, 534, 214, 531, 198);
            g.DrawRectangle(pnegro, 555, 228, 10, 15);
            e.Graphics.DrawLine(pnegro, 563, 218, 562, 228);
            e.Graphics.DrawLine(pnegro, 574, 205, 565, 228);
            e.Graphics.DrawLine(pnegro, 565, 242, 572, 242);
            e.Graphics.DrawLine(pnegro, 574, 206, 606, 193);
            e.Graphics.DrawLine(pnegro, 606, 193, 602, 204);
            //e.Graphics.DrawLine(pnegro, 606, 193, 588, 174);
            //e.Graphics.DrawLine(pnegro, 574, 207, 568, 199);
            //e.Graphics.DrawLine(pnegro, 547, 179, 563, 172);
            //e.Graphics.DrawLine(pnegro, 559, 215, 571, 194);
            //g.DrawBezier(pnegro, 531, 199, 534, 192, 535, 189, 534, 184);
            g.DrawBezier(pnegro, 571, 242, 570, 230, 587, 206, 602, 203);
            g.DrawBezier(pnegro, 571, 242, 587, 244, 610, 214, 602, 204);

            Point[] Taladro1 =
    {
                new Point(397, 398),
                new Point(394, 395),
                new Point(391, 398),
                new Point(393, 399),
                new Point(394, 402),
                new Point(392, 403),
                new Point(389, 458),
                new Point(394, 459),
                new Point(397, 402),
                new Point(398, 398)};

            #endregion

            #region ManoIzquierda
            Point[] MuñecaSuperiorIzquierda =
                {
                new Point(338, 334),
                new Point(343, 339),
                new Point(341, 345),
                new Point(339, 356),
                new Point(331, 361),
                new Point(323, 353),
                new Point(324, 347),
                new Point(322, 339),
                new Point(327, 331)};
            Point[] MuñecaInferiorIzquierda1 =
                {
                new Point(346, 347),
                new Point(318, 347),
                new Point(317, 371),
                new Point(330, 387),
                new Point(346, 376)};
            Point[] MuñecaInferiorIzquierda2 =
                {
                new Point(342, 344),
                new Point(348, 357),
                new Point(347, 366),
                new Point(346, 376),
                new Point(342, 383),
                new Point(330, 387),
                new Point(330, 365),
                new Point(339, 362),
                new Point(343, 356)};
            Point[] ManoIzquierda =
                {
                new Point(323, 384),
                new Point(321, 398),
                new Point(324, 400),
                new Point(326, 396),
                new Point(325, 404),
                new Point(329, 406),
                new Point(330, 403),
                new Point(334, 410),
                new Point(342, 407),
                new Point(342, 411),
                new Point(346, 413),
                new Point(349, 403),
                new Point(348, 390),
                new Point(344, 384)};

            #endregion

            #region PiernaIzquierda
            Point[] PiernaSuperiorIzquierdo =
                {
                new Point(410, 399),
                new Point(406, 387),
                new Point(396, 384),
                new Point(382, 394),
                new Point(379, 410),
                new Point(382, 422),
                new Point(385, 438),
                new Point(387, 448),
                new Point(386, 457),
                new Point(395, 463),
                new Point(399, 462),
                new Point(406, 457),
                new Point(406, 433),
                new Point(409, 398)};

            Point[] HuesoPiernaIzquierdo1 =
                {
                new Point(413, 395),
                new Point(390, 402)};

            Point[] HuesoPiernaIzquierdo2 =
                {
                new Point(397, 398),
                new Point(394, 395),
                new Point(391, 398),
                new Point(393, 399),
                new Point(394, 402),
                new Point(392, 403),
                new Point(389, 458),
                new Point(394, 459),
                new Point(397, 402),
                new Point(398, 398)};

            Point[] RodillaIzquierda1 =
                {
                new Point(394, 465),
                new Point(403, 460),
                new Point(409, 465),
                new Point(409, 468),
                new Point(394, 473),
                new Point(393, 467)};

            Point[] RodillaIzquierda2 =
                {
                new Point(393, 472),
                new Point(391, 467),
                new Point(388, 460),
                new Point(383, 465),
                new Point(386, 474),
                new Point(393, 471)};

            Point[] RodillaIzquierda3 =
                {
                new Point(385, 472),
                new Point(373, 467),
                new Point(365, 459),
                new Point(355, 446),
                new Point(370, 441),
                new Point(375, 446),
                new Point(383, 455),
                new Point(390, 460)};
            Point[] RodillaIzquierda4 =
                {
                new Point(356, 451),
                new Point(354, 451),
                new Point(357, 456),
                new Point(366, 466),
                new Point(378, 474),
                new Point(386, 474)};
            Point[] PiernaInferiorIzquierda1 =
                {
                new Point(355, 455),
                new Point(354, 460),
                new Point(352, 474),
                new Point(353, 484),
                new Point(355, 494),
                new Point(358, 502),
                new Point(360, 510),
                new Point(356, 520),
                new Point(359, 520),
                new Point(358, 528),
                new Point(362, 525),
                new Point(364, 527),
                new Point(365, 523),
                new Point(368, 525),
                new Point(366, 515),
                new Point(366, 496),
                new Point(367, 473)};
            Point[] PiernaInferiorIzquierda2 =
                {
                new Point(356, 455),
                new Point(356, 461),
                new Point(359, 467),
                new Point(365, 480),
                new Point(364, 490),
                new Point(363, 506),
                new Point(366, 514),
                new Point(366, 501),
                new Point(367, 492),
                new Point(372, 473),
                new Point(363, 464)};

            #endregion

            #region PiernaDerecha
            Point[] PiernaSuperiorDerecha1 =
               {
                new Point(473, 386),
                new Point(488, 402),
                new Point(487, 404),
                new Point(491, 409),
                new Point(495, 418),
                new Point(486, 406),
                new Point(482, 403),
                new Point(475, 395),
                new Point(475, 398),
                new Point(478, 408),
                new Point(480, 422),
                new Point(480, 442),
                new Point(470, 429),
                new Point(462, 422),
                new Point(454, 412),
                new Point(461, 404),
                new Point(467, 398)};

            Point[] PiernaSuperiorDerecha2 =
                {
                new Point(474, 393),
                new Point(485, 404),
                new Point(490, 410),
                new Point(494, 421),
                new Point(494, 429),
                new Point(500, 441),
                new Point(498, 446),
                new Point(494, 445),
                new Point(490, 450),
                new Point(485, 450),
                new Point(483, 444),
                new Point(458, 409)};

            Point[] PiernaSuperiorDerecha3 =
                {
                new Point(487, 452),
                new Point(480, 447),
                new Point(478, 445),
                new Point(473, 441),
                new Point(466, 437),
                new Point(458, 426),
                new Point(449, 419),
                new Point(445, 419),
                new Point(444, 415),
                new Point(454, 410),
                new Point(464, 402)};

            Point[] PiernaInferiorDerecha1 =
                {
                new Point(442, 420),
                new Point(448, 419),
                new Point(452, 422),
                new Point(456, 426),
                new Point(457, 436),
                new Point(463, 460),
                new Point(451, 429),
                new Point(447, 426),
                new Point(442, 424),
                new Point(442, 420)};

            Point[] PiernaInferiorDerecha2 =
                {
                new Point(444, 425),
                new Point(461, 478),
                new Point(467, 476),
                new Point(453, 427)};


            #endregion

            #region PieIzquierdo
            Point[] PieIzquierdo =
                {
                new Point(360, 524),
                new Point(365, 535),
                new Point(382, 545),
                new Point(397, 553),
                new Point(411, 557),
                new Point(414, 549),
                new Point(408, 541),
                new Point(400, 538),
                new Point(378, 528),
                new Point(366, 523),                
                new Point(366, 523)};

            Point[] PieIzquierdoDetalles1 =
                {
                new Point(410, 555),
                new Point(408, 549),
                new Point(404, 546),
                new Point(400, 546)};

            Point[] PieIzquierdoDetalles2 =
                {
                new Point(413, 549),
                new Point(411, 546),
                new Point(406, 542),
                new Point(401, 543)};

            #endregion

            #region PieDerecho
            Point[] PieDerecho =
                {
                new Point(460, 485),
                new Point(461, 493),
                new Point(473, 500),
                new Point(495, 512),
                new Point(509, 515),
                new Point(513, 511),
                new Point(508, 507),
                new Point(503, 507),
                new Point(494, 501),
                new Point(469, 486)};

            Point[] PieDerecho1 =
                {
                new Point(512, 516),
                new Point(506, 510),
                new Point(505, 509),
                new Point(501, 510)};

            Point[] TobilloDerecho =
                {
                new Point(459, 479),
                new Point(463, 481),
                new Point(464, 478),
                new Point(466, 481),
                new Point(467, 477),
                new Point(472, 487),
                new Point(469, 486),
                new Point(467, 487),
                new Point(467, 487),
                new Point(464, 489),
                new Point(463, 484),
                new Point(461, 490)};

            #endregion

            #region Cuerpo
            g.DrawLine(PDelg, 470, 212, 473, 231);
            g.DrawLine(pnegro, 471, 242, 475, 270);
            g.DrawLine(pnegro, 476, 278, 476, 289);
            g.DrawLine(PDelg, 477, 294, 478, 308);
            g.DrawLine(pnegro, 394, 254, 394, 268);
            g.DrawLine(pnegro, 394, 278, 392, 290);
            g.DrawLine(pnegro, 392, 298, 392, 310);
            Point[] Cuerpo =
                {
                new Point(393, 222),
                new Point(393, 165),
                new Point(406, 138),
                new Point(434, 126),
                new Point(460, 137),
                new Point(470, 155),
                new Point(470, 182),
                new Point(470, 202),
                new Point(473, 230),
                new Point(474, 270),
                new Point(478, 322),
                new Point(478, 334),
                new Point(469, 378),
                new Point(460, 400),
                new Point(450, 409),
                new Point(446, 410),
                new Point(419, 405),
                new Point(401, 390),
                new Point(391, 381),
                new Point(391, 346),
                new Point(394, 221)};

            Point[] MadreEsa1 =
                {
                new Point(479, 350),
                new Point(474, 371),
                new Point(464, 399),
                new Point(440, 414),
                new Point(422, 409),
                new Point(419, 405)};
            Point[] MadreEsa2 =
                {
                new Point(428, 411),
                new Point(425, 403),
                new Point(422, 392),
                new Point(419, 372),
                new Point(412, 358),
                new Point(403, 354),
                new Point(391, 346),               
                new Point(386, 345),
                new Point(389, 353),
                new Point(396, 361),
                new Point(408, 367),
                new Point(414, 377),
                new Point(414, 381),
                new Point(416, 396),
                new Point(410, 399),
                new Point(420, 410)};


            #endregion

            #region Huesos
            //HuesosDerecha//
            g.DrawBezier(PDelg, 464, 245, 474, 239, 478, 233, 474, 228);
            g.DrawBezier(PDelg, 464, 244, 470, 237, 473, 230, 473, 230);
            g.DrawBezier(PDelg, 466, 281, 475, 274, 476, 270, 476, 270);
            g.DrawBezier(PDelg, 466, 281, 477, 278, 480, 273, 477, 266);
            g.DrawBezier(PDelg, 466, 296, 466, 296, 478, 288, 478, 288);
            g.DrawBezier(PDelg, 466, 296, 477, 294, 481, 290, 477, 286);
            g.DrawBezier(PDelg, 466, 314, 474, 310, 478, 307, 478, 307);
            g.DrawBezier(PDelg, 466, 314, 478, 313, 482, 310, 477, 305);

            Point[] HuesoIzquierda0 =
                {
                new Point(402, 234),
                new Point(412, 242),
                new Point(427, 248),
                new Point(413, 248),
                new Point(401, 245),
                new Point(398, 242),
                new Point(401, 236) };
            Point[] HuesoIzquierda1 =
                {
                new Point(393, 267),
                new Point(407,280),
                new Point(437, 286),
                new Point(412, 288),
                new Point(388,272),
                new Point(393, 262) };
            Point[] HuesoIzquierda2 =
                {
                new Point(392, 287),
                new Point(397, 297),
                new Point(409, 303),
                new Point(436, 302),
                new Point(407, 308),
                new Point(387, 290),
                new Point(393, 280) };

            Point[] HuesoIzquierda3 =
                {
                new Point(391, 310),
                new Point(405, 320),
                new Point(434, 319),
                new Point(411, 326),
                new Point(390, 318),
                new Point(388, 311),
                new Point(391, 302)};
            #endregion

            #region mueble
            e.Graphics.DrawLine(pnegro, 0, 146, 77, 144);
            e.Graphics.DrawLine(pnegro, 1, 150, 75, 148);
            e.Graphics.DrawLine(pnegro, 77, 144, 75, 163);
            e.Graphics.DrawLine(pnegro, 74, 163, 2, 165);
            e.Graphics.DrawLine(pnegro, 76, 144, 199, 258);
            e.Graphics.DrawLine(pnegro, 78, 150, 198, 259);
            e.Graphics.DrawLine(pnegro, 77, 164, 197,268);
            e.Graphics.DrawLine(pnegro, 71, 166, 190, 271);
            e.Graphics.DrawLine(pnegro, 197, 269, 190, 270);
            e.Graphics.DrawLine(pnegro, 196, 259, 196, 266);
            e.Graphics.DrawLine(pnegro, 70, 163, 46, 418);
            e.Graphics.DrawLine(pnegro, 45, 163, 17, 418);
            e.Graphics.DrawLine(pnegro, 54, 419, 1, 418);
            e.Graphics.DrawLine(pnegro, 54, 418, 48, 473);


            #endregion

            #region destapacaños
            Point[] Destapacaño1 =
            {
                new Point(189,471),
                new Point(190,468),
                new Point(190,464),
                new Point(191,460),
                new Point(192,456),
                new Point(194,452),
                new Point(197,448),
                new Point(199,444),
                new Point(201,443),
                new Point(204,439),
                new Point(207,438),
                new Point(211,437),
                new Point(215,436),
                new Point(229,436), 
                new Point(232,437),
                new Point(234,438),
                new Point(237,439),
                new Point(242,442),
                new Point(246,446),
                new Point(248,449), 
                new Point(251,451),
                new Point(252,455),
                new Point(253,459),
                new Point(254,462),
                new Point(254,467),
                new Point(254,471),
            };
            Point[] Destapacaño2 =
            {
                new Point(191,463),
                new Point(253,463),
            };
            Point[] Destapacaño3 =
            {
                new Point(213,437),
                new Point(215,430),
                new Point(232,430),
                new Point(234,437),
             
            };
            Point[] Destapacaño4 =
            {
                new Point(220,429),
                new Point(227,429),
                new Point(240,279),
                new Point(239,276),
                new Point(239,273),
                new Point(238,272),
                new Point(235,272),
                new Point(230,278),
                new Point(226,335),
                new Point(221,398),
                new Point(220,419)
               
              
            };

            
           
            #endregion

            #region ParedCentral
            Point[] C11 =
            {
                new Point(237,7),
                new Point(316,2),
                new Point(302,226),
                new Point(220,228),
               
            };
            Point[] C12 =
            {
                new Point(233,2),
                new Point(275,0),
                new Point(320,0),
                new Point(307,231),
                new Point(215,232)
               
            };
            Point Esq11 = new Point(237,7); Point Esq12 = new Point(233,2);
            Point Esq21 = new Point(316,2); Point Esq22 = new Point(320,0);
            Point Esq31 = new Point(302,226); Point Esq32 = new Point(307,231);
            Point Esq41 = new Point(220,228); Point Esq42 = new Point(215,232);
            #endregion

            #region Metodos
            //ParedCentral
           
            Pen CBordeP=new Pen(Color.Black,2);
            
           


            g.DrawPolygon(CBordeP, C12);
            g.FillPolygon(ColorPared2, C12);
            g.DrawPolygon(CBordeP, C11);
            g.FillPolygon(ColorPared2,C11);
            g.DrawLine(CBordeP,Esq11,Esq12);
            g.DrawLine(CBordeP, Esq21, Esq22);
            g.DrawLine(CBordeP, Esq31, Esq32);
            g.DrawLine(CBordeP, Esq41, Esq42);

            //CuerpoContorno//
            g.DrawClosedCurve(PVerde, Cuerpo);
            g.FillClosedCurve(ColorF19, Cuerpo);

            //HombroIzquierdo//
            g.DrawClosedCurve(pnegro, HombroIzquierdo);

            //Brazos//
            g.DrawClosedCurve(pnegro, ManoIzquierda);
            g.FillClosedCurve(ColorF15, ManoIzquierda);
            g.DrawClosedCurve(pnegro, MuñecaInferiorIzquierda1);
            g.FillClosedCurve(ColorF14, MuñecaInferiorIzquierda1);

            g.DrawClosedCurve(pnegro, MuñecaInferiorIzquierda2);
            g.FillClosedCurve(ColorF13, MuñecaInferiorIzquierda2);

            g.DrawClosedCurve(pnegro, MuñecaSuperiorIzquierda);
            g.FillClosedCurve(ColorF12, MuñecaSuperiorIzquierda);
            g.DrawPolygon(pnegro, BrazoSuperior);
            g.FillClosedCurve(ColorF10, BrazoSuperior);
            g.DrawPolygon(pnegro, BrazoInferior);
            g.FillPolygon(ColorF9, BrazoInferior);
            g.FillClosedCurve(ColorF11, HombroIzquierdo);
            //Manos//
            


            //Huesos//
            g.DrawClosedCurve(PDelg, HuesoIzquierda0);
            g.FillClosedCurve(ColorF9, HuesoIzquierda0);
            g.DrawClosedCurve(PDelg, HuesoIzquierda1);
            g.FillClosedCurve(ColorF9, HuesoIzquierda1);
            g.DrawClosedCurve(PDelg, HuesoIzquierda2);
            g.FillClosedCurve(ColorF9, HuesoIzquierda2);
            g.DrawClosedCurve(PDelg, HuesoIzquierda3);
            g.FillClosedCurve(ColorF9, HuesoIzquierda3);

            //MadreEsa//
            g.DrawClosedCurve(pnegro, MadreEsa2);
            g.FillClosedCurve(ColorF9, MadreEsa2);
            

            //Piernas//
            g.DrawClosedCurve(pnegro, PieIzquierdo);
            g.FillClosedCurve(ColorF15, PieIzquierdo);
            g.DrawClosedCurve(pnegro, PiernaSuperiorIzquierdo);
            g.FillClosedCurve(ColorF10, PiernaSuperiorIzquierdo);
            g.DrawLines(PiernaSuperiorIzquierdaPalos, HuesoPiernaIzquierdo1);
            g.DrawClosedCurve(pnegro, HuesoPiernaIzquierdo2);
            g.FillClosedCurve(ColorF20, HuesoPiernaIzquierdo2);
            g.DrawClosedCurve(PDelg, RodillaIzquierda1);
            g.FillClosedCurve(ColorF20, RodillaIzquierda1);
            g.DrawClosedCurve(pnegro, RodillaIzquierda4);
            g.FillClosedCurve(ColorF21, RodillaIzquierda4);
            g.DrawClosedCurve(pnegro, RodillaIzquierda3);
            g.FillClosedCurve(ColorF22, RodillaIzquierda3);
            g.DrawClosedCurve(pnegro, RodillaIzquierda2);
            g.FillClosedCurve(ColorF21, RodillaIzquierda2);
            g.DrawClosedCurve(pnegro, PiernaInferiorIzquierda1);
            g.FillClosedCurve(ColorF16, PiernaInferiorIzquierda1);
            g.DrawClosedCurve(pnegro, PiernaInferiorIzquierda2);
            g.FillClosedCurve(ColorF17, PiernaInferiorIzquierda2);

            g.DrawClosedCurve(pnegro, PiernaSuperiorDerecha2);
            g.FillClosedCurve(ColorF10, PiernaSuperiorDerecha2);
            g.DrawClosedCurve(pnegro, PiernaSuperiorDerecha3);
            g.FillClosedCurve(ColorF10, PiernaSuperiorDerecha3);
            g.DrawClosedCurve(pnegro, PiernaSuperiorDerecha1);
            g.FillClosedCurve(ColorF17, PiernaSuperiorDerecha1);
            g.DrawClosedCurve(pnegro, PiernaInferiorDerecha2);
            g.FillClosedCurve(ColorF23, PiernaInferiorDerecha2);
            g.DrawClosedCurve(pnegro, PiernaInferiorDerecha1);
            g.FillClosedCurve(ColorF9, PiernaInferiorDerecha1);
            g.DrawBeziers(PDelg, PieIzquierdoDetalles1);
            g.DrawBeziers(PDelg, PieIzquierdoDetalles2);
            g.DrawCurve(PHuesoEse, MadreEsa1);
            //Pies//
            g.DrawClosedCurve(pnegro, PieDerecho);
            g.FillClosedCurve(ColorF15, PieDerecho);
            g.DrawBeziers(PDelg, PieDerecho1);
            g.DrawPolygon(PDelg, TobilloDerecho);
            g.FillPolygon(ColorF8, TobilloDerecho);
            //Destapacaños
            Pen DestBlack = new Pen(Color.Black, 1);
            Pen DestPalo = new Pen(ColoDest3, 1);

            g.DrawClosedCurve(DestBlack, Destapacaño1);
            g.FillClosedCurve(ColoDest1, Destapacaño1);
            g.DrawPolygon(DestBlack, Destapacaño2);
            g.DrawClosedCurve(DestPalo, Destapacaño4);
            g.FillClosedCurve(ColoDest4, Destapacaño4);
            g.DrawClosedCurve(DestBlack, Destapacaño3);
            g.FillClosedCurve(ColoDest1, Destapacaño3);
            #endregion
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            k = 0;
        }

        private void PictureboxBack_MouseUp(object sender, MouseEventArgs e)
        {
 
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripButton1_Click_1(object sender, EventArgs e)
        {
            
        }

        private void toolStripButton1_Click_2(object sender, EventArgs e)
        {
            Bitmap bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            Graphics g = Graphics.FromImage(bmp);
            Rectangle rect = pictureBox1.RectangleToScreen(pictureBox1.ClientRectangle);
            g.CopyFromScreen(rect.Location, Point.Empty, pictureBox1.Size);
            g.Dispose();
            SaveFileDialog s = new SaveFileDialog();
            s.Filter = "Png files|*.png|jpeg files|*jpg|bitmaps|*.bmp";
            if (s.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                if (File.Exists(s.FileName))
                {
                    File.Delete(s.FileName);
                }
                if (s.FileName.Contains(".jpg"))
                {
                    bmp.Save(s.FileName, ImageFormat.Jpeg);
                }
                else if (s.FileName.Contains(".png"))
                {
                    bmp.Save(s.FileName, ImageFormat.Png);
                }
                else if (s.FileName.Contains(".bmp"))
                {
                    bmp.Save(s.FileName, ImageFormat.Bmp);
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void labelx_Click(object sender, EventArgs e)
        {

        }
    }
}
