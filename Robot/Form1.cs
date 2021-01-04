using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Robot
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        #region ALEATORIO
        //SECCIÓN DEL ALGORITMO CON MOVIMIENTOS ALEATORIOS
        //SE DECLARAN LOS 10 OBJETIVOS
        int contObjetivos = 10;
        //COMIENZA CON 200 DE VIDA
        int vida = 200;
        Graphics g;

        //SE DECLARAN LAS COORDENADAS DEL ROBOT
        PointF[] pts =
        {
            new Point(-25, -25),
            new Point(25, -25),
            new Point(25, 25),
            new Point(-25, 25),
            new Point(-25, -25)
        };

        //SE DECLARAN LOS 10 OBJETIVOS, CON VALORES 
        //INICIALES QUE CAMBIARÁN AL CORRER EL PROGRAMA
        PointF[] objetivo1 =
        {
            new Point(-15, -15),
            new Point(15, -15),
            new Point(15, 15),
            new Point(-15, 15),
            new Point(-15, -15)
        };
        PointF[] objetivo2 =
        {
            new Point(-15, -15),
            new Point(15, -15),
            new Point(15, 15),
            new Point(-15, 15),
            new Point(-15, -15)
        };
        PointF[] objetivo3 =
        {
            new Point(-15, -15),
            new Point(15, -15),
            new Point(15, 15),
            new Point(-15, 15),
            new Point(-15, -15)
        };
        PointF[] objetivo4 =
        {
            new Point(-15, -15),
            new Point(15, -15),
            new Point(15, 15),
            new Point(-15, 15),
            new Point(-15, -15)
        };
        PointF[] objetivo5 =
        {
            new Point(-15, -15),
            new Point(15, -15),
            new Point(15, 15),
            new Point(-15, 15),
            new Point(-15, -15)
        };
        PointF[] objetivo6 =
        {
            new Point(-15, -15),
            new Point(15, -15),
            new Point(15, 15),
            new Point(-15, 15),
            new Point(-15, -15)
        };
        PointF[] objetivo7 =
        {
            new Point(-15, -15),
            new Point(15, -15),
            new Point(15, 15),
            new Point(-15, 15),
            new Point(-15, -15)
        };
        PointF[] objetivo8 =
        {
            new Point(-15, -15),
            new Point(15, -15),
            new Point(15, 15),
            new Point(-15, 15),
            new Point(-15, -15)
        };
        PointF[] objetivo9 =
        {
            new Point(-15, -15),
            new Point(15, -15),
            new Point(15, 15),
            new Point(-15, 15),
            new Point(-15, -15)
        };
        PointF[] objetivo10 =
        {
            new Point(-15, -15),
            new Point(15, -15),
            new Point(15, 15),
            new Point(-15, 15),
            new Point(-15, -15)
        };
        #endregion

        #region A*
        //SECCIÓN DEL ALGORITMO A*
        //SE DECLARA UN CONTADOR DE 10 OBJETIVOS
        int contObjetivosA = 10;
        //SE COMIENZA CON UN 100 DE VIDA
        int vidaA = 100;

        //SE DECLARAN LAS COORDENADAS DEL ROBOT
        PointF[] robotA =
        {
            new Point(-25, -25),
            new Point(25, -25),
            new Point(25, 25),
            new Point(-25, 25),
            new Point(-25, -25)
        };

        //SE DECLARAN LOS 10 OBJETIVOS, CON VALORES 
        //INICIALES QUE CAMBIARÁN AL CORRER EL PROGRAMA
        PointF[] obj1 =
        {
            new Point(-20, -20),
            new Point(20, -20),
            new Point(20, 20),
            new Point(-20, 20),
            new Point(-20, -20)
        };
        PointF[] obj2 =
        {
            new Point(-20, -20),
            new Point(20, -20),
            new Point(20, 20),
            new Point(-20, 20),
            new Point(-20, -20)
        };
        PointF[] obj3 =
        {
            new Point(-20, -20),
            new Point(20, -20),
            new Point(20, 20),
            new Point(-20, 20),
            new Point(-20, -20)
        };
        PointF[] obj4 =
        {
            new Point(-20, -20),
            new Point(20, -20),
            new Point(20, 20),
            new Point(-20, 20),
            new Point(-20, -20)
        };
        PointF[] obj5 =
        {
            new Point(-20, -20),
            new Point(20, -20),
            new Point(20, 20),
            new Point(-20, 20),
            new Point(-20, -20)
        };
        PointF[] obj6 =
        {
            new Point(-20, -20),
            new Point(20, -20),
            new Point(20, 20),
            new Point(-20, 20),
            new Point(-20, -20)
        };
        PointF[] obj7 =
        {
            new Point(-20, -20),
            new Point(20, -20),
            new Point(20, 20),
            new Point(-20, 20),
            new Point(-20, -20)
        };
        PointF[] obj8 =
        {
            new Point(-20, -20),
            new Point(20, -20),
            new Point(20, 20),
            new Point(-20, 20),
            new Point(-20, -20)
        };
        PointF[] obj9 =
        {
            new Point(-20, -20),
            new Point(20, -20),
            new Point(20, 20),
            new Point(-20, 20),
            new Point(-20, -20)
        };
        PointF[] obj10 =
        {
            new Point(-20, -20),
            new Point(20, -20),
            new Point(20, 20),
            new Point(-20, 20),
            new Point(-20, -20)
        };
        #endregion

        #region HEURISTICA
        //SECCIÓN DEL ALGORITMO CON HEURISTICA
        //BANDERA PARA SABER SI EL ROBOR LLEGÓ AL OBJETIVO
        bool llegoObjetivo = false;
        //X min -390 max 390
        //Y min -175 max 175
        //COORDENADAS DEL ROBOT
        PointF[] robot =
        {
            new Point(-390, 0),
            new Point(-340, 0),
            new Point(-340, 50),
            new Point(-390, 50),
            new Point(-390, 0)
        };
        //COORDENADAS DE LOS 11 MUROS EXISTENTES
        PointF[] muro1 =
        {
            new Point(-340, -50),
            new Point(-290, -50),
            new Point(-290, 0),
            new Point(-340, 0),
            new Point(-340, -50)
        };

        PointF[] muro2 =
        {
            new Point(-290, 50),
            new Point(-240, 50),
            new Point(-240, 100),
            new Point(-290, 100),
            new Point(-290, 50)
        };

        PointF[] muro3 =
        {
            new Point(-240, 0),
            new Point(-190, 0),
            new Point(-190, 50),
            new Point(-240, 50),
            new Point(-240, 0)
        };

        PointF[] muro4 =
        {
            new Point(-190, -100),
            new Point(-140, -100),
            new Point(-140, -50),
            new Point(-190, -50),
            new Point(-190, -100)
        };

        PointF[] muro5 =
        {
            new Point(-140, -50),
            new Point(-90, -50),
            new Point(-90, 0),
            new Point(-140, 0),
            new Point(-140, -50)
        };

        PointF[] muro6 =
        {
            new Point(-90, 0),
            new Point(-40, 0),
            new Point(-40, 50),
            new Point(-90, 50),
            new Point(-90, 0)
        };

        PointF[] muro7 =
        {
            new Point(-40, 0),
            new Point(10, 0),
            new Point(10, 50),
            new Point(-40, 50),
            new Point(-40, 0)
        };

        PointF[] muro8 =
        {
            new Point(10, 100),
            new Point(60, 100),
            new Point(60, 150),
            new Point(10, 150),
            new Point(10, 100)
        };

        PointF[] muro9 =
        {
            new Point(60, 50),
            new Point(110, 50),
            new Point(110, 100),
            new Point(60, 100),
            new Point(60, 50)
        };

        PointF[] muro10 =
        {
            new Point(110, -50),
            new Point(160, -50),
            new Point(160, 0),
            new Point(110, 0),
            new Point(110, -50)
        };

        PointF[] muro11 =
        {
            new Point(160, 0),
            new Point(210, 0),
            new Point(210, 50),
            new Point(160, 50),
            new Point(160, 0)
        };

        //COORDENADAS DEL OBJETIVO DEL ROBOT
        PointF[] objetivoRobot =
        {
            new Point(310, 0),
            new Point(360, 0),
            new Point(360, 50),
            new Point(310, 50),
            new Point(310, 0)
        };
        #endregion

        private void Form1_Load(object sender, EventArgs e)
        {
            //LABEL DEL MENÚ PRINCIPAL
            lblRobot.Text = "Seleccione una opción";
        }

        #region ALEATORIO
        private void btnAleatorio_Click(object sender, EventArgs e)
        {
            //NOS LLEVA A LA SECCIÓN DEL ALGORITMO CON MOVIMIENTOS ALEATORIOS
            tabRobot.SelectedIndex = tabRobot.TabPages.IndexOf(tabRobot.TabPages["pageAleatorio"]);
            lblRobot.Text = "Robot con movimientos al azar";
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            //NOS REGRESA AL MENÚ PRINCIPAL
            tabRobot.SelectedIndex = tabRobot.TabPages.IndexOf(tabRobot.TabPages["pagePrincipal"]);
            lblRobot.Text = "Seleccione una opción";
            Limpiar();
            pbAleatorio.Refresh();
        }

        private void Limpiar()
        {
            //REGRESA AL ROBOT A PUNTO MEDIO
            pts[0] = new PointF(-25, -25);
            pts[1] = new PointF(25, -25);
            pts[2] = new PointF(25, 25);
            pts[3] = new PointF(-25, 25);
            pts[4] = new PointF(-25, -25);
        }

        private void pbAleatorio_Paint(object sender, PaintEventArgs e)
        {
            if (tabRobot.SelectedTab == tabRobot.TabPages["pageAleatorio"])
            {
                g = e.Graphics;
                //DIBUJA EL ROBOT
                Pen pen = new Pen(Color.Blue, 3);
                e.Graphics.TranslateTransform(pbAleatorio.Width / 2, pbAleatorio.Height / 2);
                g.DrawLines(pen, pts);

                //DIBUJA LOS OBJETIVOS QUE NO SEAN NULOS
                Pen penBlack = new Pen(Color.Black, 2);
                if (objetivo1 != null)
                {
                    g.DrawLines(penBlack, objetivo1);
                }
                if (objetivo2 != null)
                {
                    g.DrawLines(penBlack, objetivo2);
                }
                if (objetivo3 != null)
                {
                    g.DrawLines(penBlack, objetivo3);
                }
                if (objetivo4 != null)
                {
                    g.DrawLines(penBlack, objetivo4);
                }
                if (objetivo5 != null)
                {
                    g.DrawLines(penBlack, objetivo5);
                }
                if (objetivo6 != null)
                {
                    g.DrawLines(penBlack, objetivo6);
                }
                if (objetivo7 != null)
                {
                    g.DrawLines(penBlack, objetivo7);
                }
                if (objetivo8 != null)
                {
                    g.DrawLines(penBlack, objetivo8);
                }
                if (objetivo9 != null)
                {
                    g.DrawLines(penBlack, objetivo9);
                }
                if (objetivo10 != null)
                {
                    g.DrawLines(penBlack, objetivo10);
                }
            }
        }

        PointF[] Traslacion(PointF[] pts, int dx, int dy)
        {
            //SE MUEVE EL ROBOT QUE LLEGA COMO PARAMETRO HACIA X COORDENADA
            for (int i = 0; i < pts.Length; i++)
            {
                pts[i] = new PointF(pts[i].X + dx, pts[i].Y + dy);
            }
            return pts;
        }

        private bool MismoPunto(PointF[] pts, out int index)
        {
            //CHECA CON CADA UNO DE LOS OBJETIVOS SI EL ROBOT ESTÁ EN EL MISMO PUNTO
            //EN CASO DE QUE SI LO ESTÉ, REGRESA UNA VARIABLE BOOLEANA EN VERDADERO
            //ADEMÁS DE QUE REGRESA UN INDICE, QUE SERÁ EL NÚMERO DEL OBJETIVO QUE CHOCÓ
            bool mismo = false;
            index = 0;
            if (objetivo1 != null)
            {
                if (Math.Abs(pts[0].X - objetivo1[0].X) <= 20 && Math.Abs(pts[0].Y - objetivo1[0].Y) <= 20)
                {
                    index = 1;
                    mismo = true;
                }
            }
            if (objetivo2 != null)
            {
                if (Math.Abs(pts[0].X - objetivo2[0].X) <= 20 && Math.Abs(pts[0].Y - objetivo2[0].Y) <= 20)
                {
                    index = 2;
                    mismo = true;
                }
            }
            if (objetivo3 != null)
            {
                if (Math.Abs(pts[0].X - objetivo3[0].X) <= 20 && Math.Abs(pts[0].Y - objetivo3[0].Y) <= 20)
                {
                    index = 3;
                    mismo = true;
                }
            }
            if (objetivo4 != null)
            {
                if (Math.Abs(pts[0].X - objetivo4[0].X) <= 20 && Math.Abs(pts[0].Y - objetivo4[0].Y) <= 20)
                {
                    index = 4;
                    mismo = true;
                }
            }
            if (objetivo5 != null)
            {
                if (Math.Abs(pts[0].X - objetivo5[0].X) <= 20 && Math.Abs(pts[0].Y - objetivo5[0].Y) <= 20)
                {
                    index = 5;
                    mismo = true;
                }
            }
            if (objetivo6 != null)
            {
                if (Math.Abs(pts[0].X - objetivo6[0].X) <= 20 && Math.Abs(pts[0].Y - objetivo6[0].Y) <= 20)
                {
                    index = 6;
                    mismo = true;
                }
            }
            if (objetivo7 != null)
            {
                if (Math.Abs(pts[0].X - objetivo7[0].X) <= 20 && Math.Abs(pts[0].Y - objetivo7[0].Y) <= 20)
                {
                    index = 7;
                    mismo = true;
                }
            }
            if (objetivo8 != null)
            {
                if (Math.Abs(pts[0].X - objetivo8[0].X) <= 20 && Math.Abs(pts[0].Y - objetivo8[0].Y) <= 20)
                {
                    index = 8;
                    mismo = true;
                }
            }
            if (objetivo9 != null)
            {
                if (Math.Abs(pts[0].X - objetivo9[0].X) <= 20 && Math.Abs(pts[0].Y - objetivo9[0].Y) <= 20)
                {
                    index = 9;
                    mismo = true;
                }
            }
            if (objetivo10 != null)
            {
                if (Math.Abs(pts[0].X - objetivo10[0].X) <= 20 && Math.Abs(pts[0].Y - objetivo10[0].Y) <= 20)
                {
                    index = 10;
                    mismo = true;
                }
            }
            return mismo;
        }

        private void RecargarBateria(bool aleatorio)
        {
            //MUEVE AL ROBOT A DONDE ESTÁ LA BATERÍA
            //EL ROBOT QUE SE MOVERÁ DEPENDERÁ DE LA BANDERA DE PARÁMETRO
            //PUEDE SER DEL DE MOVIMIENTOS ALEATORIOS O EL DE A*
            if (aleatorio)
            {
                pts[0] = new PointF(335, 80);
                pts[1] = new PointF(385, 80);
                pts[2] = new PointF(385, 130);
                pts[3] = new PointF(335, 130);
                pts[4] = new PointF(335, 80);
            }
            else
            {
                robotA[0] = new PointF(375, 125);
                robotA[1] = new PointF(425, 125);
                robotA[2] = new PointF(425, 175);
                robotA[3] = new PointF(375, 175);
                robotA[4] = new PointF(375, 125);
            }
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            //MIENTRAS EL CONTADOR DE OBJETIVOS SEA MAYOR QUE 0
            //ENTONCES EL ROBOT SE MOVERÁ CON MOVIMIENTOS ALEATORIOS
            //EN CASO DE QUE CHOQUE CON ALGÚN OBJETIVO, DICHO OBJETIVO
            //CAMBIARÁ A NULO Y YA NO SE DIBUJARÁ, ADEMÁS DE QUE EL
            //CONTADOR DE OBJETIVOS DISMINUIRÁ
            //HARÁ ESTO HASTA QUE EL ROBOT HAYA CHOCADO CON TODOS LOS OBJETIVOS
            while (contObjetivos > 0)
            {
                if (vida > 10)
                {
                    pbBateria.Image = Properties.Resources.bateria_completa;
                    pbBateria.Refresh();
                    Random random = new Random();
                    int x = 0;
                    int y = 0;
                    if (pts[0].X > 360)
                    {
                        x = random.Next(-30, 0);
                    }
                    else if (pts[0].X < -360)
                    {
                        x = random.Next(0, 30);
                    }
                    else
                    {
                        x = random.Next(-30, 30);
                    }
                    if (pts[0].Y > 140)
                    {
                        y = random.Next(-30, 0);
                    }
                    else if (pts[0].Y < -140)
                    {
                        y = random.Next(0, 30);
                    }
                    else
                    {
                        y = random.Next(-30, 30);
                    }
                    System.Threading.Thread.Sleep(50);
                    pts = Traslacion(pts, x, y);
                    vida -= 1;
                    pbAleatorio.Refresh();
                    int index = 0;
                    if (MismoPunto(pts, out index))
                    {
                        switch (index)
                        {
                            case 1:
                                objetivo1 = null;
                                break;
                            case 2:
                                objetivo2 = null;
                                break;
                            case 3:
                                objetivo3 = null;
                                break;
                            case 4:
                                objetivo4 = null;
                                break;
                            case 5:
                                objetivo5 = null;
                                break;
                            case 6:
                                objetivo6 = null;
                                break;
                            case 7:
                                objetivo7 = null;
                                break;
                            case 8:
                                objetivo8 = null;
                                break;
                            case 9:
                                objetivo9 = null;
                                break;
                            case 10:
                                objetivo10 = null;
                                break;
                        }
                        contObjetivos--;
                        lblObjetivosAleatorio.Text = "Objetivos: " + contObjetivos;
                        pbAleatorio.Refresh();
                        Application.DoEvents();
                    }
                }
                else
                {
                    pbBateria.Image = Properties.Resources.bateria_baja;
                    pbBateria.Refresh();
                    RecargarBateria(true);
                    pbAleatorio.Refresh();
                    System.Threading.Thread.Sleep(5000);
                    vida = 200;
                    Application.DoEvents();
                    Limpiar();
                    pbAlgoritmoA.Refresh();
                }
            }
            MessageBox.Show("Terminé de chocar con todos");
        }
        #endregion

        #region A*
        private void btnAlgoritmoA_Click(object sender, EventArgs e)
        {
            //NOS MANDA HACIA LA SECCIÓN DE ALGORITMO A*
            tabRobot.SelectedIndex = tabRobot.TabPages.IndexOf(tabRobot.TabPages["pageAlgoritmoA"]);
            lblRobot.Text = "Robot con algoritmo A*";
        }

        private void btnRegresarAlgoritmoA_Click(object sender, EventArgs e)
        {
            //NOS REGRESA AL MENÚ PRINCIPAL Y REGRESA TODO A COMO EMPEZÓ
            tabRobot.SelectedIndex = tabRobot.TabPages.IndexOf(tabRobot.TabPages["pagePrincipal"]);
            lblRobot.Text = "Seleccione una opción";
            LimpiarA();
            InicializarObjetivos();
            pbAlgoritmoA.Refresh();
        }

        private void InicializarObjetivos()
        {
            //REGRESA LAS COORDENADAS DE LOS OBJETIVOS
            //A COMO EMPEZARON Y EL CONTADOR DE OBJETIVOS
            //REGRESA A 10
            contObjetivosA = 10;

            obj1 = new PointF[5];
            obj1[0] = new Point(-25, -25);
            obj1[1] = new Point(25, -25);
            obj1[2] = new Point(25, 25);
            obj1[3] = new Point(-25, 25);
            obj1[4] = new Point(-25, -25);

            obj2 = new PointF[5];
            obj2[0] = new Point(-25, -25);
            obj2[1] = new Point(25, -25);
            obj2[2] = new Point(25, 25);
            obj2[3] = new Point(-25, 25);
            obj2[4] = new Point(-25, -25);

            obj3 = new PointF[5];
            obj3[0] = new Point(-25, -25);
            obj3[1] = new Point(25, -25);
            obj3[2] = new Point(25, 25);
            obj3[3] = new Point(-25, 25);
            obj3[4] = new Point(-25, -25);

            obj4 = new PointF[5];
            obj4[0] = new Point(-25, -25);
            obj4[1] = new Point(25, -25);
            obj4[2] = new Point(25, 25);
            obj4[3] = new Point(-25, 25);
            obj4[4] = new Point(-25, -25);

            obj5 = new PointF[5];
            obj5[0] = new Point(-25, -25);
            obj5[1] = new Point(25, -25);
            obj5[2] = new Point(25, 25);
            obj5[3] = new Point(-25, 25);
            obj5[4] = new Point(-25, -25);

            obj6 = new PointF[5];
            obj6[0] = new Point(-25, -25);
            obj6[1] = new Point(25, -25);
            obj6[2] = new Point(25, 25);
            obj6[3] = new Point(-25, 25);
            obj6[4] = new Point(-25, -25);

            obj7 = new PointF[5];
            obj7[0] = new Point(-25, -25);
            obj7[1] = new Point(25, -25);
            obj7[2] = new Point(25, 25);
            obj7[3] = new Point(-25, 25);
            obj7[4] = new Point(-25, -25);

            obj8 = new PointF[5];
            obj8[0] = new Point(-25, -25);
            obj8[1] = new Point(25, -25);
            obj8[2] = new Point(25, 25);
            obj8[3] = new Point(-25, 25);
            obj8[4] = new Point(-25, -25);

            obj9 = new PointF[5];
            obj9[0] = new Point(-25, -25);
            obj9[1] = new Point(25, -25);
            obj9[2] = new Point(25, 25);
            obj9[3] = new Point(-25, 25);
            obj9[4] = new Point(-25, -25);

            obj10 = new PointF[5];
            obj10[0] = new Point(-25, -25);
            obj10[1] = new Point(25, -25);
            obj10[2] = new Point(25, 25);
            obj10[3] = new Point(-25, 25);
            obj10[4] = new Point(-25, -25);
        }

        private void LimpiarA()
        {
            //REGRESA AL ROBOT AL PUNTO MEDIO
            robotA[0] = new PointF(-25, -25);
            robotA[1] = new PointF(25, -25);
            robotA[2] = new PointF(25, 25);
            robotA[3] = new PointF(-25, 25);
            robotA[4] = new PointF(-25, -25);
        }

        private void pbAlgoritmoA_Paint(object sender, PaintEventArgs e)
        {
            if (tabRobot.SelectedTab == tabRobot.TabPages["pageAlgoritmoA"])
            {
                g = e.Graphics;
                e.Graphics.TranslateTransform(pbAleatorio.Width / 2, pbAleatorio.Height / 2);

                //DIBUJA LOS OBJETIVOS QUE NO SEAN NULOS
                Pen penBlack = new Pen(Color.Black, 2);
                Brush brushBlack = new SolidBrush(Color.Black);
                if (obj1 != null)
                {
                    g.DrawLines(penBlack, obj1);
                    g.FillPolygon(brushBlack, obj1);
                }
                if (obj2 != null)
                {
                    g.DrawLines(penBlack, obj2);
                    g.FillPolygon(brushBlack, obj2);
                }
                if (obj3 != null)
                {
                    g.DrawLines(penBlack, obj3);
                    g.FillPolygon(brushBlack, obj3);
                }
                if (obj4 != null)
                {
                    g.DrawLines(penBlack, obj4);
                    g.FillPolygon(brushBlack, obj4);
                }
                if (obj5 != null)
                {
                    g.DrawLines(penBlack, obj5);
                    g.FillPolygon(brushBlack, obj5);
                }
                if (obj6 != null)
                {
                    g.DrawLines(penBlack, obj6);
                    g.FillPolygon(brushBlack, obj6);
                }
                if (obj7 != null)
                {
                    g.DrawLines(penBlack, obj7);
                    g.FillPolygon(brushBlack, obj7);
                }
                if (obj8 != null)
                {
                    g.DrawLines(penBlack, obj8);
                    g.FillPolygon(brushBlack, obj8);
                }
                if (obj9 != null)
                {
                    g.DrawLines(penBlack, obj9);
                    g.FillPolygon(brushBlack, obj9);
                }
                if (obj10 != null)
                {
                    g.DrawLines(penBlack, obj10);
                    g.FillPolygon(brushBlack, obj10);
                }

                //DIBUJA EL ROBOT
                Pen pen = new Pen(Color.Blue, 3);
                Brush brushBlue = new SolidBrush(Color.Blue);
                g.DrawLines(pen, robotA);
                g.FillPolygon(brushBlue, robotA);
            }
        }

        private int ObjetivoMasCercano()
        {
            //VERIFICA CUAL ES EL OBJETIVO MÁS CERCANO DESDE EL ROBOT HASTA CADA UNO DE LOS OBJETIVOS
            //POR MEDIO DE LA FÓRMULA DE LA DISTANCIA ENTRE DOS PUNTOS
            int masCercano = 0;
            double distancia = 0;
            double distanciaAux = 0;
            if (obj1 != null)
            {
                distancia = Math.Sqrt(Math.Pow((obj1[0].X - robotA[0].X), 2) + Math.Pow((obj1[0].Y - robotA[0].Y), 2));
                masCercano = 1;
            }
            if (obj2 != null)
            {
                distanciaAux = Math.Sqrt(Math.Pow((obj2[0].X - robotA[0].X), 2) + Math.Pow((obj2[0].Y - robotA[0].Y), 2));
                if (distanciaAux <= distancia || distancia == 0)
                {
                    distancia = distanciaAux;
                    masCercano = 2;
                }
            }
            if (obj3 != null)
            {
                distanciaAux = Math.Sqrt(Math.Pow((obj3[0].X - robotA[0].X), 2) + Math.Pow((obj3[0].Y - robotA[0].Y), 2));
                if (distanciaAux <= distancia || distancia == 0)
                {
                    distancia = distanciaAux;
                    masCercano = 3;
                }
            }
            if (obj4 != null)
            {
                distanciaAux = Math.Sqrt(Math.Pow((obj4[0].X - robotA[0].X), 2) + Math.Pow((obj4[0].Y - robotA[0].Y), 2));
                if (distanciaAux <= distancia || distancia == 0)
                {
                    distancia = distanciaAux;
                    masCercano = 4;
                }
            }
            if (obj5 != null)
            {
                distanciaAux = Math.Sqrt(Math.Pow((obj5[0].X - robotA[0].X), 2) + Math.Pow((obj5[0].Y - robotA[0].Y), 2));
                if (distanciaAux <= distancia || distancia == 0)
                {
                    distancia = distanciaAux;
                    masCercano = 5;
                }
            }
            if (obj6 != null)
            {
                distanciaAux = Math.Sqrt(Math.Pow((obj6[0].X - robotA[0].X), 2) + Math.Pow((obj6[0].Y - robotA[0].Y), 2));
                if (distanciaAux <= distancia || distancia == 0)
                {
                    distancia = distanciaAux;
                    masCercano = 6;
                }
            }
            if (obj7 != null)
            {
                distanciaAux = Math.Sqrt(Math.Pow((obj7[0].X - robotA[0].X), 2) + Math.Pow((obj7[0].Y - robotA[0].Y), 2));
                if (distanciaAux <= distancia || distancia == 0)
                {
                    distancia = distanciaAux;
                    masCercano = 7;
                }
            }
            if (obj8 != null)
            {
                distanciaAux = Math.Sqrt(Math.Pow((obj8[0].X - robotA[0].X), 2) + Math.Pow((obj8[0].Y - robotA[0].Y), 2));
                if (distanciaAux <= distancia || distancia == 0)
                {
                    distancia = distanciaAux;
                    masCercano = 8;
                }
            }
            if (obj9 != null)
            {
                distanciaAux = Math.Sqrt(Math.Pow((obj9[0].X - robotA[0].X), 2) + Math.Pow((obj9[0].Y - robotA[0].Y), 2));
                if (distanciaAux <= distancia || distancia == 0)
                {
                    distancia = distanciaAux;
                    masCercano = 9;
                }
            }
            if (obj10 != null)
            {
                distanciaAux = Math.Sqrt(Math.Pow((obj10[0].X - robotA[0].X), 2) + Math.Pow((obj10[0].Y - robotA[0].Y), 2));
                if (distanciaAux <= distancia || distancia == 0)
                {
                    distancia = distanciaAux;
                    masCercano = 10;
                }
            }
            return masCercano;
        }

        private double DistanciaPuntos(double x, double y, int objetivo)
        {
            //SE REGRESA LA DISTANCIA ENTRE PUNTOS DESDE LOS PUNTOS X Y Y QUE LLEGAN COMO 
            //PARAMETRO, HACIA EL OBJETIVO N DEPENDIENDO DEL PARAMETRO QUE TAMBIEN LLEGA
            double distancia = 0;
            switch (objetivo)
            {
                case 1:
                    distancia = Math.Sqrt(Math.Pow((obj1[0].X - x), 2) + Math.Pow((obj1[0].Y - y), 2));
                    break;
                case 2:
                    distancia = Math.Sqrt(Math.Pow((obj2[0].X - x), 2) + Math.Pow((obj2[0].Y - y), 2));
                    break;
                case 3:
                    distancia = Math.Sqrt(Math.Pow((obj3[0].X - x), 2) + Math.Pow((obj3[0].Y - y), 2));
                    break;
                case 4:
                    distancia = Math.Sqrt(Math.Pow((obj4[0].X - x), 2) + Math.Pow((obj4[0].Y - y), 2));
                    break;
                case 5:
                    distancia = Math.Sqrt(Math.Pow((obj5[0].X - x), 2) + Math.Pow((obj5[0].Y - y), 2));
                    break;
                case 6:
                    distancia = Math.Sqrt(Math.Pow((obj6[0].X - x), 2) + Math.Pow((obj6[0].Y - y), 2));
                    break;
                case 7:
                    distancia = Math.Sqrt(Math.Pow((obj7[0].X - x), 2) + Math.Pow((obj7[0].Y - y), 2));
                    break;
                case 8:
                    distancia = Math.Sqrt(Math.Pow((obj8[0].X - x), 2) + Math.Pow((obj8[0].Y - y), 2));
                    break;
                case 9:
                    distancia = Math.Sqrt(Math.Pow((obj9[0].X - x), 2) + Math.Pow((obj9[0].Y - y), 2));
                    break;
                case 10:
                    distancia = Math.Sqrt(Math.Pow((obj10[0].X - x), 2) + Math.Pow((obj10[0].Y - y), 2));
                    break;
            }
            return distancia;
        }

        private bool MismoPuntoA(PointF[] pts, out int index)
        {
            //CHECA SI EL ROBOT CHOCA CON ALGUNO DE LOS OBJETIVOS, Y EN CASO DE QUE SEA
            //AFIRMATIVO, ENTONCES REGRESA LA BANDERA EN TRUE Y EL INDICE CON EL OBJETIVO QUE CHOCÓ
            bool mismo = false;
            index = 0;
            if (obj1 != null)
            {
                if (Math.Abs(pts[0].X - obj1[0].X) <= 20 && Math.Abs(pts[0].Y - obj1[0].Y) <= 20)
                {
                    index = 1;
                    mismo = true;
                }
            }
            if (obj2 != null)
            {
                if (Math.Abs(pts[0].X - obj2[0].X) <= 20 && Math.Abs(pts[0].Y - obj2[0].Y) <= 20)
                {
                    index = 2;
                    mismo = true;
                }
            }
            if (obj3 != null)
            {
                if (Math.Abs(pts[0].X - obj3[0].X) <= 20 && Math.Abs(pts[0].Y - obj3[0].Y) <= 20)
                {
                    index = 3;
                    mismo = true;
                }
            }
            if (obj4 != null)
            {
                if (Math.Abs(pts[0].X - obj4[0].X) <= 20 && Math.Abs(pts[0].Y - obj4[0].Y) <= 20)
                {
                    index = 4;
                    mismo = true;
                }
            }
            if (obj5 != null)
            {
                if (Math.Abs(pts[0].X - obj5[0].X) <= 20 && Math.Abs(pts[0].Y - obj5[0].Y) <= 20)
                {
                    index = 5;
                    mismo = true;
                }
            }
            if (obj6 != null)
            {
                if (Math.Abs(pts[0].X - obj6[0].X) <= 20 && Math.Abs(pts[0].Y - obj6[0].Y) <= 20)
                {
                    index = 6;
                    mismo = true;
                }
            }
            if (obj7 != null)
            {
                if (Math.Abs(pts[0].X - obj7[0].X) <= 20 && Math.Abs(pts[0].Y - obj7[0].Y) <= 20)
                {
                    index = 7;
                    mismo = true;
                }
            }
            if (obj8 != null)
            {
                if (Math.Abs(pts[0].X - obj8[0].X) <= 20 && Math.Abs(pts[0].Y - obj8[0].Y) <= 20)
                {
                    index = 8;
                    mismo = true;
                }
            }
            if (obj9 != null)
            {
                if (Math.Abs(pts[0].X - obj9[0].X) <= 20 && Math.Abs(pts[0].Y - obj9[0].Y) <= 20)
                {
                    index = 9;
                    mismo = true;
                }
            }
            if (obj10 != null)
            {
                if (Math.Abs(pts[0].X - obj10[0].X) <= 20 && Math.Abs(pts[0].Y - obj10[0].Y) <= 20)
                {
                    index = 10;
                    mismo = true;
                }
            }
            return mismo;
        }

        private void btnIniciarA_Click(object sender, EventArgs e)
        {
            //MIENTRAS EL CONTADOR DE OBJETIVOS SEA MAYOR A 0
            //CHECA PRIMERAMENTE CUAL ES EL OBJETIVO MÁS CERCANO, UNA VEZ QUE 
            //LO TIENE, ENTONCES VERIFICA CUAL ES EL MOVIMIENTO QUE DEBE HACER, 
            //TIENE 4 POSIBILIDADES, DERECHA, IZQUIERDA, ARRIBA, ABAJO
            //ESCOGE UNA DE LAS 4 OPCIONES Y HACE LOS MOVIMIENTOS
            //CUANDO CHOCA CON ALGÚN OBJETIVO LO PONE EN NULO Y YA NO SE DIBUJA
            //ADEMÁS DE QUE EL CONTADOR DISMINUYE
            while (contObjetivosA > 0)
            {
                if (vidaA > 10)
                {
                    pbBateriaA.Image = Properties.Resources.bateria_completa;
                    pbBateriaA.Refresh();

                    int objetivo = ObjetivoMasCercano();
                    //POSIBILIDAD 1
                    double x1 = robotA[0].X;
                    double y1 = robotA[0].Y - 50;
                    double distancia1 = DistanciaPuntos(x1, y1, objetivo);
                    //POSIBILIDAD 2
                    double x2 = robotA[0].X + 50;
                    double y2 = robotA[0].Y;
                    double distancia2 = DistanciaPuntos(x2, y2, objetivo);
                    //POSIBILIDAD 3
                    double x3 = robotA[0].X;
                    double y3 = robotA[0].Y + 50;
                    double distancia3 = DistanciaPuntos(x3, y3, objetivo);
                    //POSIBILIDAD 4
                    double x4 = robotA[0].X - 50;
                    double y4 = robotA[0].Y;
                    double distancia4 = DistanciaPuntos(x4, y4, objetivo);

                    List<double> posiblesMovimientos = new List<double>();
                    posiblesMovimientos.Add(distancia1);
                    posiblesMovimientos.Add(distancia2);
                    posiblesMovimientos.Add(distancia3);
                    posiblesMovimientos.Add(distancia4);

                    int mejorDistancia = 0;
                    double distancia = 0;
                    double distanciaAux = 0;

                    for (int i = 0; i < posiblesMovimientos.Count; i++)
                    {
                        if (i == 0)
                        {
                            distancia = posiblesMovimientos[i];
                            mejorDistancia = i + 1;
                        }
                        else
                        {
                            distanciaAux = posiblesMovimientos[i];
                            if (distanciaAux <= distancia)
                            {
                                distancia = distanciaAux;
                                mejorDistancia = i + 1;
                            }
                        }

                    }

                    switch (mejorDistancia)
                    {
                        case 1:
                            Traslacion(robotA, 0, -50);
                            break;
                        case 2:
                            Traslacion(robotA, 50, 0);
                            break;
                        case 3:
                            Traslacion(robotA, 0, 50);
                            break;
                        case 4:
                            Traslacion(robotA, -50, 0);
                            break;
                    }
                    pbAlgoritmoA.Refresh();

                    int index = 0;
                    System.Threading.Thread.Sleep(500);
                    if (MismoPuntoA(robotA, out index))
                    {
                        switch (index)
                        {
                            case 1:
                                obj1 = null;
                                break;
                            case 2:
                                obj2 = null;
                                break;
                            case 3:
                                obj3 = null;
                                break;
                            case 4:
                                obj4 = null;
                                break;
                            case 5:
                                obj5 = null;
                                break;
                            case 6:
                                obj6 = null;
                                break;
                            case 7:
                                obj7 = null;
                                break;
                            case 8:
                                obj8 = null;
                                break;
                            case 9:
                                obj9 = null;
                                break;
                            case 10:
                                obj10 = null;
                                break;
                        }
                        pbAlgoritmoA.Refresh();
                        contObjetivosA--;
                        lblObjetivosA.Text = "Objetivos: " + contObjetivosA;
                    }
                    Application.DoEvents();
                    vidaA -= 5;
                }
                else
                {
                    pbBateriaA.Image = Properties.Resources.bateria_baja;
                    pbBateriaA.Refresh();
                    RecargarBateria(false);
                    pbAlgoritmoA.Refresh();
                    System.Threading.Thread.Sleep(5000);
                    vidaA = 100;
                    Application.DoEvents();
                }
                //cont--;
            }
            MessageBox.Show("Terminé de chocar con todos");
        }
        #endregion

        #region HERUISTICA
        private void btnHeuristica_Click(object sender, EventArgs e)
        {
            //NOS MANDA HACIA LA SECCIÓN DE ALGORITMOS CON HEURISTICA
            tabRobot.SelectedIndex = tabRobot.TabPages.IndexOf(tabRobot.TabPages["pageHeuristica"]);
            lblRobot.Text = "Robot con algoritmo de búsqueda con heruística";
        }

        private void pbHeuristica_Paint(object sender, PaintEventArgs e)
        {
            g = e.Graphics;
            e.Graphics.TranslateTransform(pbHeuristica.Width / 2, pbHeuristica.Height / 2);

            Pen pen = new Pen(Color.Blue, 3);
            g.DrawLines(pen, robot);
            Brush brushBlue = new SolidBrush(Color.Blue);
            g.FillPolygon(brushBlue, robot);

            Pen penBlack = new Pen(Color.Black, 3);
            g.DrawLines(penBlack, muro1);
            Brush brushBlack = new SolidBrush(Color.Black);
            g.FillPolygon(brushBlack, muro1);

            g.DrawLines(penBlack, muro2);
            g.FillPolygon(brushBlack, muro2);

            g.DrawLines(penBlack, muro3);
            g.FillPolygon(brushBlack, muro3);

            g.DrawLines(penBlack, muro4);
            g.FillPolygon(brushBlack, muro4);

            g.DrawLines(penBlack, muro5);
            g.FillPolygon(brushBlack, muro5);

            g.DrawLines(penBlack, muro6);
            g.FillPolygon(brushBlack, muro6);

            g.DrawLines(penBlack, muro7);
            g.FillPolygon(brushBlack, muro7);

            g.DrawLines(penBlack, muro8);
            g.FillPolygon(brushBlack, muro8);

            g.DrawLines(penBlack, muro9);
            g.FillPolygon(brushBlack, muro9);

            g.DrawLines(penBlack, muro10);
            g.FillPolygon(brushBlack, muro10);

            g.DrawLines(penBlack, muro11);
            g.FillPolygon(brushBlack, muro11);

            Pen penRed = new Pen(Color.Red, 3);
            g.DrawLines(penRed, objetivoRobot);
            Brush brushRed = new SolidBrush(Color.Red);
            g.FillPolygon(brushRed, objetivoRobot);
        }

        private double DistanciaPuntos(double x, double y)
        {
            return Math.Sqrt(Math.Pow((objetivoRobot[0].X - x), 2) + Math.Pow((objetivoRobot[0].Y - y), 2));
        }

        private bool ChoqueMuro(double x, double y)
        {
            bool choque = false;
            if ((x == muro1[0].X && y == muro1[0].Y) || (x == muro2[0].X && y == muro2[0].Y) || (x == muro3[0].X && y == muro3[0].Y) || (x == muro4[0].X && y == muro4[0].Y)
                || (x == muro5[0].X && y == muro5[0].Y) || (x == muro6[0].X && y == muro6[0].Y) || (x == muro7[0].X && y == muro7[0].Y) || (x == muro8[0].X && y == muro8[0].Y)
                || (x == muro9[0].X && y == muro9[0].Y) || (x == muro10[0].X && y == muro10[0].Y) || (x == muro11[0].X && y == muro11[0].Y))
            {
                choque = true;
            }
            return choque;
        }

        private void btnIniciarHeuristica_Click(object sender, EventArgs e)
        {
            while (!llegoObjetivo)
            {
                //POSIBILIDAD 1
                double x1 = robot[0].X;
                double y1 = robot[0].Y - 50;
                double distancia1 = DistanciaPuntos(x1, y1);
                //POSIBILIDAD 2
                double x2 = robot[0].X;
                double y2 = robot[0].Y + 50;
                double distancia2 = DistanciaPuntos(x2, y2);
                //POSIBILIDAD 3
                double x3 = robot[0].X + 50;
                double y3 = robot[0].Y;
                double distancia3 = DistanciaPuntos(x3, y3);

                bool posible1 = false;
                bool posible2 = false;
                bool posible3 = false;

                List<double> posiblesMovimientos = new List<double>();
                if (!ChoqueMuro(x1, y1))
                {
                    posiblesMovimientos.Add(distancia1);
                    posible1 = true;
                }
                if (!ChoqueMuro(x2, y2))
                {
                    posiblesMovimientos.Add(distancia2);
                    posible2 = true;
                }
                if (!ChoqueMuro(x3, y3))
                {
                    posiblesMovimientos.Add(distancia3);
                    posible3 = true;
                }

                int mejorDistancia = 0;

                if (posible1)
                {
                    for (int i = 0; i < posiblesMovimientos.Count; i++)
                    {
                        if (distancia1 <= posiblesMovimientos[i])
                        {
                            mejorDistancia = 1;
                        }
                        else
                        {
                            mejorDistancia = 0;
                            break;
                        }
                    }
                }
                if (posible2)
                {
                    if (mejorDistancia == 0)
                    {
                        for (int i = 0; i < posiblesMovimientos.Count; i++)
                        {
                            if (distancia2 <= posiblesMovimientos[i])
                            {
                                mejorDistancia = 2;
                            }
                            else
                            {
                                mejorDistancia = 0;
                                break;
                            }
                        }
                    }
                }
                if (posible3)
                {
                    if (mejorDistancia == 0)
                    {
                        for (int i = 0; i < posiblesMovimientos.Count; i++)
                        {
                            if (distancia3 <= posiblesMovimientos[i])
                            {
                                mejorDistancia = 3;
                            }
                            else
                            {
                                mejorDistancia = 0;
                                break;
                            }
                        }
                    }
                }

                switch (mejorDistancia)
                {
                    case 1:
                        Traslacion(robot, 0, -50);
                        break;
                    case 2:
                        Traslacion(robot, 0, 50);
                        break;
                    case 3:
                        Traslacion(robot, 50, 0);
                        break;
                }
                pbHeuristica.Refresh();
                System.Threading.Thread.Sleep(500);
                Application.DoEvents();

                if (robot[0].X == objetivoRobot[0].X)
                {
                    llegoObjetivo = true;
                }
            }
            MessageBox.Show("Llegué al objetivo");
        }

        private void btnRegresarHeuristica_Click(object sender, EventArgs e)
        {
            tabRobot.SelectedIndex = tabRobot.TabPages.IndexOf(tabRobot.TabPages["pagePrincipal"]);
            lblRobot.Text = "Seleccione una opción";
            llegoObjetivo = false;
            LimpiarHeuristica();
            pbAleatorio.Refresh();
        }

        private void LimpiarHeuristica()
        {
            robot[0] = new PointF(-390, 0);
            robot[1] = new PointF(-340, 0);
            robot[2] = new PointF(-340, 50);
            robot[3] = new PointF(-390, 50);
            robot[4] = new PointF(-390, 0);
        }
        #endregion

        private void tabRobot_SelectedIndexChanged(object sender, EventArgs e)
        {
            #region ALEATORIO
            if (tabRobot.SelectedTab == tabRobot.TabPages["pageAleatorio"])
            {
                Random r = new Random();
                Traslacion(objetivo1, r.Next(-340, 340), r.Next(-140, 140));
                Traslacion(objetivo2, r.Next(-340, 340), r.Next(-140, 140));
                Traslacion(objetivo3, r.Next(-340, 340), r.Next(-140, 140));
                Traslacion(objetivo4, r.Next(-340, 340), r.Next(-140, 140));
                Traslacion(objetivo5, r.Next(-340, 340), r.Next(-140, 140));
                Traslacion(objetivo6, r.Next(-340, 340), r.Next(-140, 140));
                Traslacion(objetivo7, r.Next(-340, 340), r.Next(-140, 140));
                Traslacion(objetivo8, r.Next(-340, 340), r.Next(-140, 140));
                Traslacion(objetivo9, r.Next(-340, 340), r.Next(-140, 140));
                Traslacion(objetivo10, r.Next(-340, 340), r.Next(-140, 140));
            }
            #endregion

            #region A*
            if (tabRobot.SelectedTab == tabRobot.TabPages["pageAlgoritmoA"])
            {
                Random r = new Random();
                int x1 = r.Next(-5, 5) * 50;
                int y1 = r.Next(-3, 3) * 50;
                Traslacion(obj1, x1, y1);
                int x2 = r.Next(-5, 5) * 50;
                int y2 = r.Next(-3, 3) * 50;
                Traslacion(obj2, x2, y2);
                int x3 = r.Next(-5, 5) * 50;
                int y3 = r.Next(-3, 3) * 50;
                Traslacion(obj3, x3, y3);
                int x4 = r.Next(-5, 5) * 50;
                int y4 = r.Next(-3, 3) * 50;
                Traslacion(obj4, x4, y4);
                int x5 = r.Next(-5, 5) * 50;
                int y5 = r.Next(-3, 3) * 50;
                Traslacion(obj5, x5, y5);
                int x6 = r.Next(-5, 5) * 50;
                int y6 = r.Next(-3, 3) * 50;
                Traslacion(obj6, x6, y6);
                int x7 = r.Next(-5, 5) * 50;
                int y7 = r.Next(-3, 3) * 50;
                Traslacion(obj7, x7, y7);
                int x8 = r.Next(-5, 5) * 50;
                int y8 = r.Next(-3, 3) * 50;
                Traslacion(obj8, x8, y8);
                int x9 = r.Next(-5, 5) * 50;
                int y9 = r.Next(-3, 3) * 50;
                Traslacion(obj9, x9, y9);
                int x10 = r.Next(-5, 5) * 50;
                int y10 = r.Next(-3, 3) * 50;
                Traslacion(obj10, x10, y10);
            }
            #endregion

            #region HEURISTICA
            if (tabRobot.SelectedTab == tabRobot.TabPages["pageHeuristica"])
            {
                Random r = new Random();
                int x = r.Next(-4, 4) * 50;
                int y = r.Next(-2, 2) * 50;
                Traslacion(objetivoRobot, x, y);
            }
            #endregion
        }
    }
}
