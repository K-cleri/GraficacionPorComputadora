using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Graficacion_Noé_Sicairos
{
    public partial class ErickSicairos : Form
    {
        //Variables Globales
        Color colorPintar, cCol, colorFondo;
        Bitmap Lienzo;
        int herramienta;
        int Grados2,Grados;
        List<Point> Auxiliar = new List<Point>();
        List<Point> Auxiliar2 = new List<Point>();
        List<Point> Coordenadas = new List<Point>();
        List<Point> PixelesTG = new List<Point>();
        List<Point> TPixeles = new List<Point>();
        List<Point> AuxPuntos = new List<Point>();
        int tamañoPixel;
        int Radio, ladosPoligono;
        int Estilos, Contador, Segmentos;
        int RadioX, RadioY;
        int aux;
        float Sx, Sy;
        int Xc, Yc, Tx, Ty, ID;
        public ErickSicairos()
        {
            //Inicializar Componentes
            InitializeComponent();
            Lienzo = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);
            colorPintar = Color.Black;
            colorFondo = Color.FromArgb(0, 0, 0, 0);
            btnTamañoPequeño.BackColor = Color.CornflowerBlue;
            btnEstiloNormal.BackColor = Color.CornflowerBlue;
            mnsPunto.Checked = true;
            Grados2 = 90;
            Grados = 6;
            this.herramienta = 1;
            this.tamañoPixel = 1;
            Radio = 100;
            RadioX = 100;
            aux = 90;
            RadioY = 65;
            Estilos = 1;
            Sx = 1f;
            Sy = 1f;
            Contador = 2;
        }
        //Boton Color por defecto
        private void btnColor_Click_1(object sender, EventArgs e)
        {
            this.colorPintar = paletColor.Color;
        }
        //Boton Color Negro
        private void btnColorBlack_Click(object sender, EventArgs e)
        {
            this.colorPintar = Color.Black;
            btnColor.BackColor = Color.Black;
        }
        //Boton Color Rojo
        private void btnColorRed_Click(object sender, EventArgs e)
        {
            this.colorPintar = Color.Red;
            btnColor.BackColor = Color.Red;
        }
        //Boton Color Verde
        private void btnColorGreen_Click(object sender, EventArgs e)
        {
            this.colorPintar = Color.Green;
            btnColor.BackColor = Color.Green;
        }
        //Boton Color Azul
        private void btnColorBlue_Click(object sender, EventArgs e)
        {
            this.colorPintar = Color.Blue;
            btnColor.BackColor = Color.Blue;
        }
        //Boton Color Amarillo
        private void btnColorYellow_Click(object sender, EventArgs e)
        {
            this.colorPintar = Color.Yellow;
            btnColor.BackColor = Color.Yellow;
        }
        //Boton Color Rosa
        private void btnColorPink_Click(object sender, EventArgs e)
        {
            this.colorPintar = Color.Pink;
            btnColor.BackColor = Color.Pink;
        }
        //Boton Color Gris
        private void ptbColorGray_Click(object sender, EventArgs e)
        {
            this.colorPintar = Color.Gray;
            btnColor.BackColor = Color.Gray;
        }
        //Boton Color Blanco
        private void btnColorWhite_Click(object sender, EventArgs e)
        {
            this.colorPintar = Color.White;
            btnColor.BackColor = Color.White;
        }
        //Boton Paleta de colores, sirve para elegir entre cualquier color que decidas
        private void btnPaletColor_Click(object sender, EventArgs e)
        {
            //Abrir paleta de colores completa.
            paletColor.FullOpen = true;
            //Codigo para configurar un color con una paleta de colores.
            if (paletColor.ShowDialog() == DialogResult.OK)
            {
                //Asignar el color seleccionado a la variable color.
                this.colorPintar = paletColor.Color;
                this.btnColor.BackColor = paletColor.Color;
            }
        }
        //Boton para optener el color de un pixel
        private void selectorDeColoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DesactivarBoton();
            mnsSelectorDeColoresToolStripMenuItem.Checked = true;
            this.herramienta = 3;
        }
        //Boton para crear una Linea poligonal
        private void lineaPoligonalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DesactivarBoton();
            lineaPoligonalToolStripMenuItem.Checked = true;
            this.herramienta = 5;
            Coordenadas.Clear();
        }
        //Boton para crear un elipse por bresenham
        private void mnsElipse_Click(object sender, EventArgs e)
        {
            DesactivarBoton();
            mnsElipse.Checked = true;
            this.herramienta = 8;
            Coordenadas.Clear();
        }
        //Boton para Triangulo
        private void mnsTriangulo_Click(object sender, EventArgs e)
        {
            ladosPoligono = 3;
        }
        //Boton para Cuadrado
        private void mnsCuadrado_Click(object sender, EventArgs e)
        {
            ladosPoligono = 4;
        }
        //Boton para Pentagono
        private void mnsPentagono_Click(object sender, EventArgs e)
        {
            ladosPoligono = 5;
        }
        //Boton para Hexagono
        private void mnsHexagono_Click(object sender, EventArgs e)
        {
            ladosPoligono = 6;
        }
        //Boton para octagono
        private void mnsOctagono_Click(object sender, EventArgs e)
        {
            ladosPoligono = 8;
        }
        //Boton para Nonagono
        private void mnsNonagono_Click(object sender, EventArgs e)
        {
            ladosPoligono = 9;
        }
        //Boton para Decagono
        private void mnsDecagono_Click(object sender, EventArgs e)
        {
            ladosPoligono = 10;
        }
        //Boton para limpiar el mapa de bit y el picturebox
        private void button1_Click(object sender, EventArgs e)
        {
            Lienzo = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);
            ptbLienzo.BackColor = Color.White;
            ptbLienzo.Image = Lienzo;
            PixelesTG.Clear();
            Coordenadas.Clear();
        }
        //Boton para llenar el mapa de bit
        private void btnRellenar_Click(object sender, EventArgs e)
        {
            herramienta = 9;
            tamañoPixel = 1;
            btnRellenar.BackColor = Color.CornflowerBlue;
            btnMonoNieve.BackColor = Color.White;
        }
        //Boton Para activar Mono de Nieve
        private void button1_Click_1(object sender, EventArgs e)
        {
            herramienta = 10;
            btnMonoNieve.BackColor = Color.CornflowerBlue;
            btnRellenar.BackColor = Color.White;
        }
        //Boton para dibujar un punto
        private void btnPunto_Click(object sender, EventArgs e)
        {
            //Herramienta 1 Pintar un pixel. 
            DesactivarBoton();
            mnsPunto.Checked = true;
            this.herramienta = 1;
            Coordenadas.Clear();
        }
        //Boton para poligono irregular
        private void mnsPoligonoIrregular_Click(object sender, EventArgs e)
        {
            DesactivarBoton();
            this.herramienta = 6;
            mnsPoligonoIrregular.Checked = true;
            Coordenadas.Clear();
        }
        //Boton para poligono regular
        private void mnsPoligonoRegular_Click(object sender, EventArgs e)
        {
            DesactivarBoton();
            this.herramienta = 7;
            mnsPoligonoRegular.Checked = true;
            Coordenadas.Clear();
        }
        //Boton para crear una circunferencia
        private void btnCirculo_Click(object sender, EventArgs e)
        {
            DesactivarBoton();
            btnCirculo.Checked = true;
            this.herramienta = 4;
            Coordenadas.Clear();
        }
        //Boton para crear una linea
        private void btnLinea_Click(object sender, EventArgs e)
        {
            DesactivarBoton();
            this.herramienta = 2;
            mnsLinea.Checked = true;
            Coordenadas.Clear();
        }
        //Boton para aumentar los grados
        private void btnGRadosMas_Click(object sender, EventArgs e)
        {
            if(Grados < 360)
            {
                Grados = Grados + Convert.ToInt32(1);
                txtGrados.Text = Convert.ToString(Grados);
            }            
        }
        //Boton para disminuir los grados
        private void btnGradosMenos_Click(object sender, EventArgs e)
        {
            if(Grados > 0)
            {
                //txtGrados.Text = Convert.ToString(1);
                Grados = Grados - Convert.ToInt32(1);
                txtGrados.Text = Convert.ToString(Grados);
            }            
        }
        //Text box que ayuda al usuario a elegir un grado de inclinacion
        private void txtGrados_TextChanged(object sender, EventArgs e)
        {
            if(Grados > 0 && Grados <= 360)
            {
                Grados = Convert.ToInt32(txtGrados.Text);
            }            
        }
        //Boton para Disminuir el tamaño de una figura
        private void btnEscalamientoNegativo_Click(object sender, EventArgs e)
        {
            herramienta = 13;
            DesactivarBoton();
        }
        //Boton para aumentar el tamaño de una figura
        private void btnEscalamientoPositivo_Click(object sender, EventArgs e)
        {
            DesactivarBoton();
            herramienta = 14;
        }
        //Boton para Rotar una figura
        private void btnRotación_Click(object sender, EventArgs e)
        {
            DesactivarBoton();
            herramienta = 12;
        }
        //Boton para trasladar una figura
        private void btnTraslacion_Click_1(object sender, EventArgs e)
        {
            DesactivarBoton();
            herramienta = 11;
        }
        //Boton para asignar el tamaño del Pixel pequeño 
        private void btnTamañoPixel_Click(object sender, EventArgs e)
        {
            this.tamañoPixel = 1;
            btnTamañoPequeño.BackColor = Color.CornflowerBlue;
            btnTamañoMediano.BackColor = Color.White;
            btnTamañoGrande.BackColor = Color.White;
        }
        //Boton para asignar el tamaño del pixel mediano
        private void btnTamañoPixel1_Click(object sender, EventArgs e)
        {
            this.tamañoPixel = 4;
            btnTamañoPequeño.BackColor = Color.White;
            btnTamañoMediano.BackColor = Color.CornflowerBlue;
            btnTamañoGrande.BackColor = Color.White;
        }
        //Boton para asignar el temaño del pixel grande
        private void btnTamañoGrande_Click(object sender, EventArgs e)
        {
            this.tamañoPixel = 8;
            btnTamañoPequeño.BackColor = Color.White;
            btnTamañoMediano.BackColor = Color.White;
            btnTamañoGrande.BackColor = Color.CornflowerBlue;
        }
        //Boton de ayuda
        private void btnAyuda_Click(object sender, EventArgs e)
        {
            Ayuda Abrir = new Ayuda();
            Abrir.Show();
        }
        //Boton para salir del programa
        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea Salir del Programa?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
            {
                Close();
            }
        }
        //Boton Estilo Normal.
        private void btnEstiloNormal_Click(object sender, EventArgs e)
        {
            Estilos = 1;
            if (btnCirculo.Checked == true && herramienta == 4)
            {
                DesactivarBoton();
                btnCirculo.Checked = true;
            }
            if (lineaPoligonalToolStripMenuItem.Checked == true && herramienta == 5)
            {
                DesactivarBoton();
                lineaPoligonalToolStripMenuItem.Checked = true;
            }
            if (mnsLinea.Checked == true && herramienta == 2)
            {
                DesactivarBoton();
                mnsLinea.Checked = true;
            }
            btnEstiloPunteado.BackColor = Color.White;
            btnEstiloNormal.BackColor = Color.CornflowerBlue;
            btnEstiloPorSegmentos.BackColor = Color.White;
        }
        //Boton Estilo Punteado.
        private void btnEstiloPunteado_Click(object sender, EventArgs e)
        {
            if (btnCirculo.Checked == true && herramienta == 4)
            {
                DesactivarBoton();
                btnCirculo.Checked = true;
            }
            if (lineaPoligonalToolStripMenuItem.Checked == true && herramienta == 5)
            {
                DesactivarBoton();
                lineaPoligonalToolStripMenuItem.Checked = true;
            }
            if (mnsLinea.Checked == true && herramienta == 2)
            {
                DesactivarBoton();
                mnsLinea.Checked = true;
            }
            Contador = 2;
            Estilos = 2;
            btnEstiloNormal.BackColor = Color.White;
            btnEstiloPunteado.BackColor = Color.CornflowerBlue;
            btnEstiloPorSegmentos.BackColor = Color.White;
        }
        //Boton Estilo Por Segmentos.
        private void btnEstiloPorSegmentos_Click(object sender, EventArgs e)
        {
            if (btnCirculo.Checked == true && herramienta == 4)
            {
                DesactivarBoton();
                btnCirculo.Checked = true;
            }
            if (lineaPoligonalToolStripMenuItem.Checked == true && herramienta == 5)
            {
                DesactivarBoton();
                lineaPoligonalToolStripMenuItem.Checked = true;
            }
            if (mnsLinea.Checked == true && herramienta == 2)
            {
                DesactivarBoton();
                mnsLinea.Checked = true;
            }
            Contador = 4;
            Estilos = 4;
            Segmentos = 0;
            btnEstiloPunteado.BackColor = Color.White;
            btnEstiloPorSegmentos.BackColor = Color.CornflowerBlue;
            btnEstiloNormal.BackColor = Color.White;
        }
        //Evento Mouse Click, Trozo del codigo mas importante 
        private void ptbLienzo_MouseClick(object sender, MouseEventArgs e)
        {
            ptbLienzo.Image = Lienzo;
            //Sistema de coordenadas
            this.CoorX.Text = e.X.ToString();
            this.CoorY.Text = e.Y.ToString();
            //Punto o pixel
            if (this.herramienta == 1 && mnsPunto.Checked == true)
            {
                PixelesTG.Clear();
                //Linea que nos sirve para pintar un pixel.
                TamañoPixel(e.X, e.Y, colorPintar);
            }
            //Linea
            if (this.herramienta == 2 && mnsLinea.Checked == true)
            {
                ID = 2;
                PixelesTG.Clear();
                TamañoPixel(e.X, e.Y, colorPintar);
                Coordenadas.Add(e.Location);
                if (Coordenadas.Count == 2)
                {
                    LineaBresenham(Coordenadas, colorPintar);
                    Xc = (Coordenadas[0].X + Coordenadas[1].X) / 2;
                    Yc = (Coordenadas[0].Y + Coordenadas[1].Y) / 2;
                    PixelesTG = new List<Point>(Coordenadas);
                    Coordenadas.Clear();
                    ErrorEstilos();
                }
            }
            //Selector de colores
            if (mnsSelectorDeColoresToolStripMenuItem.Checked == true && herramienta == 3)
            {
                ID = 0;
                PixelesTG.Clear();
                SelectorColores(e.X, e.Y);
            }
            //Circunferencia
            if (btnCirculo.Checked == true && herramienta == 4)
            {
                ID = 5;
                PixelesTG.Clear();
                Coordenadas.Add(e.Location);
                if (Coordenadas.Count == 1)
                {
                    CircunferenciaBresenham(Coordenadas, colorPintar);
                    Xc = e.X;
                    Yc = e.Y;
                    PixelesTG = new List<Point>(Coordenadas);
                    Coordenadas.Clear();
                    ErrorEstilos();
                }
            }
            //Linea Poligonal
            if (this.herramienta == 5 && lineaPoligonalToolStripMenuItem.Checked == true)
            {
                ID = 0;
                //PixelesTG.Clear();
                TamañoPixel(e.X, e.Y, colorPintar);
                Coordenadas.Add(e.Location);
                if (Coordenadas.Count >= 2)
                {
                    LineaPoligonal(Coordenadas, colorPintar);
                    Coordenadas.RemoveAt(0);
                    ErrorEstilos();
                }
               
            }
            //Poligono Irregular
            if (this.herramienta == 6 && mnsPoligonoIrregular.Checked == true)
            {
                PixelesTG.Clear();
                ID = 3;
                TamañoPixel(e.X, e.Y, colorPintar);
                Coordenadas.Add(e.Location);
                if (Coordenadas.Count == Convert.ToInt32(txtLadosPoligono.Text))
                {
                    PoligonoIrregular(Coordenadas, colorPintar);
                    Xc = (Coordenadas.Min(Point => Point.X) + Coordenadas.Max(Point => Point.X)) / 2;
                    Yc = (Coordenadas.Min(Point => Point.Y) + Coordenadas.Max(Point => Point.Y)) / 2;
                    //PixelesTG = new List<Point>(Coordenadas);
                    AuxPuntos = new List<Point>(PixelesTG);
                    Coordenadas.Clear();
                    ErrorEstilos();
                }
            }
            //Poligono Regular
            if (this.herramienta == 7 && mnsPoligonoRegular.Checked == true)
            {
                PixelesTG.Clear();
                ID = 4;
                Coordenadas.Add(e.Location);
                PoligonoRegular(Coordenadas, colorPintar);
                Xc = e.X;
                Yc = e.Y;
                //PixelesTG = new List<Point>(Coordenadas);
                Coordenadas.Clear();
                ErrorEstilos();
            }
            //Elipse
            if (this.herramienta == 8 && mnsElipse.Checked == true)
            {
                ID = 6;
                PixelesTG.Clear();
                Coordenadas.Add(e.Location);
                ElipseBresenham(Coordenadas, RadioX, RadioY, colorPintar);
                Xc = e.X;
                Yc = e.Y;
                PixelesTG = new List<Point>(Coordenadas);
                Coordenadas.Clear();
                ErrorEstilos();
            }
            //Herramienta Rellenar
            if (this.herramienta == 9)
            {
                ID = 0;
                PixelesTG.Clear();
                Color colorDeRelleno = colorPintar;
                Relleno(e.X, e.Y, colorDeRelleno);
            }
            //Muñeco de Nieve
            if (herramienta == 10)
            {
                ID = 0;
                PixelesTG.Clear();
                Coordenadas.Add(e.Location);
                MuñecoNieve(Coordenadas, colorPintar);
                Coordenadas.Clear();
            }
            //Herramienta Traslacion
            if (herramienta == 11)
            {
                Tx = e.X - Xc;
                Ty = e.Y - Yc;
                Traslacion(PixelesTG, Tx, Ty, ID, colorPintar);
                Xc = e.X;
                Yc = e.Y;
            } 
            //Herramienta Rotación
            if(herramienta == 12)
            {
                if (ID == 6)
                {
                    Rotacion(PixelesTG, Grados2, ID, colorPintar);
                    if (Grados2 > 0 && Grados2 < 360)
                    {
                        Grados2 = Grados2 + 90;
                    }
                    else
                    {
                        Grados2 = 90;
                    }
                    if (Grados2 == 180)
                    {
                        aux = 90;
                    }
                    if(Grados2 == 360)
                    {
                        aux = 180;
                    }
                }
                else
                {
                    Rotacion(PixelesTG, Grados, ID, colorPintar);
                }                
            }
            //Herramienta Escalamiento
            if (herramienta == 13 || herramienta == 14)
            {
                if (herramienta == 13)
                {
                    Sx = 1 - 0.1f;
                    Sy = 1 - 0.1f;
                    Escalamiento(PixelesTG, Sx, Sy, colorPintar);                 
                }
                if (herramienta == 14)
                {
                    Sx = 1 + 0.1f;
                    Sy = 1 + 0.1f;
                    Escalamiento(PixelesTG, Sx, Sy, colorPintar);                  
                }
            }
        }
        //Evento para mostrar las cordenadas
        private void ptbLienzo_MouseMove(object sender, MouseEventArgs e)
        {
            //Sistema de Coordenadas
            this.CoorX.Text = e.X.ToString();
            this.CoorY.Text = e.Y.ToString();
        }
        //metodo para cambiar el tamaño del pixel
        public void TamañoPixel(int tamañoX, int tamañoY, Color opcionColor)
        {
            for (int X = 0; X < this.tamañoPixel; X++)
            {
                for (int Y = 0; Y < this.tamañoPixel; Y++)
                {
                    if (tamañoX + X > 0 && tamañoX + X < ptbLienzo.Width && tamañoY + Y > 0 && tamañoY + Y < ptbLienzo.Height)
                    {
                        Lienzo.SetPixel((X) + tamañoX, (Y) + tamañoY, opcionColor);
                    }
                }
            }
        }
        //Metodo de Bresenham para dibujar una Linea Recta.
        public void LineaBresenham(List<Point> pLista, Color miColor)
        {
            int x, y, DeltaX, DeltaY, p;
            int incX;
            int incY;
            DeltaX = pLista[1].X - pLista[0].X;
            DeltaY = pLista[1].Y - pLista[0].Y;
            x = pLista[0].X;
            y = pLista[0].Y;
            //Determinar que punto se utilizara           
            if (DeltaX < 0)
            {
                incX = -1;
                DeltaX = -DeltaX;
            }
            else
            {
                incX = 1;
            }
            if (DeltaY < 0)
            {
                incY = -1;
                DeltaY = -DeltaY;
            }
            else
            {
                incY = 1;
            }
            //Reaalizar un ciclo asta llegar al extremo de la linea
            if (DeltaX > DeltaY)
            {
                p = (2 * DeltaY) - DeltaX;
                while (x != pLista[1].X)
                {
                    x = x + incX;
                    if (p < 0)
                    {
                        p = 2 * DeltaY + p;
                    }
                    else
                    {
                        y = y + incY;
                        p = 2 * (DeltaY - DeltaX) + p;
                    }
                    //Codigo para estilo de linea solida. 
                    if (Estilos == 1)
                    {
                        TamañoPixel(x, y, miColor);
                    }
                    //Codigo para estilo de linea punteada.
                    if (Estilos == 2)
                    {
                        if (Contador == 2 * tamañoPixel)
                        {
                            TamañoPixel(x, y, miColor);
                            Contador = 0;
                        }
                        else
                        {
                            Contador++;
                        }
                    }
                    //Codigo para estilo de linea por segmentos.
                    if (Estilos == 4)
                    {
                        if (Contador == 4 * tamañoPixel)
                        {
                            Segmentos++;
                            if (Segmentos == 2 * tamañoPixel)
                            {
                                Contador = 0;
                                Segmentos = 0;
                            }
                        }
                        else
                        {
                            TamañoPixel(x, y, miColor);
                            Contador++;
                        }
                    }
                }
            }
            else
            {
                p = (2 * DeltaX) - DeltaY;
                while (y != pLista[1].Y)
                {
                    y = y + incY;
                    if (p < 0)
                    {
                        p = (2 * DeltaX) + p;
                    }
                    else
                    {
                        x = x + incX;
                        p = 2 * (DeltaX - DeltaY) + p;
                    }
                    //Codigo para estilo de linea solida.
                    if (Estilos == 1)
                    {
                        TamañoPixel(x, y, miColor);
                    }
                    //Codigo para estilo de linea punteada.
                    if (Estilos == 2)
                    {
                        if (Contador == 2 * tamañoPixel)
                        {
                            TamañoPixel(x, y, miColor);
                            Contador = 0;
                        }
                        else
                        {
                            Contador++;
                        }
                    }
                    //Codigo para estilo de linea por segmentos.
                    if (Estilos == 4)
                    {
                        if (Contador == 4 * tamañoPixel)
                        {
                            Segmentos++;
                            if (Segmentos == 2 * tamañoPixel)
                            {
                                Contador = 0;
                                Segmentos = 0;
                            }
                        }
                        else
                        {
                            TamañoPixel(x, y, miColor);
                            Contador++;
                        }
                    }
                }
            }
        }
        //Metodo de Bresenham para dibujar una Circunferencia.
        public void CircunferenciaBresenham(List<Point> pLista, Color miColor)
        {
            int x, y, e;
            x = Radio;
            y = 0;
            e = 0;
            while (x >= y)
            {
                //EstilosRecta de circunferencia normal
                if (Estilos == 1)
                {
                    TamañoPixel(pLista[0].X + x, pLista[0].Y + y, miColor);
                    TamañoPixel(pLista[0].X - x, pLista[0].Y + y, miColor);
                    TamañoPixel(pLista[0].X + y, pLista[0].Y + x, miColor);
                    TamañoPixel(pLista[0].X - y, pLista[0].Y + x, miColor);
                    TamañoPixel(pLista[0].X + x, pLista[0].Y - y, miColor);
                    TamañoPixel(pLista[0].X + y, pLista[0].Y - x, miColor);
                    TamañoPixel(pLista[0].X - x, pLista[0].Y - y, miColor);
                    TamañoPixel(pLista[0].X - y, pLista[0].Y - x, miColor);
                }
                //Codigo para estilo de circunferencia punteada.
                if (Estilos == 2)
                {
                    if (Contador == 2 * tamañoPixel)
                    {
                        TamañoPixel(pLista[0].X + x, pLista[0].Y + y, miColor);
                        TamañoPixel(pLista[0].X - x, pLista[0].Y + y, miColor);
                        TamañoPixel(pLista[0].X + y, pLista[0].Y + x, miColor);
                        TamañoPixel(pLista[0].X - y, pLista[0].Y + x, miColor);
                        TamañoPixel(pLista[0].X + x, pLista[0].Y - y, miColor);
                        TamañoPixel(pLista[0].X + y, pLista[0].Y - x, miColor);
                        TamañoPixel(pLista[0].X - x, pLista[0].Y - y, miColor);
                        TamañoPixel(pLista[0].X - y, pLista[0].Y - x, miColor);
                        Contador = 0;
                    }
                    else
                    {
                        Contador++;
                    }
                }
                //Codigo para estilo de circunferencia por segmentos.
                if (Estilos == 4)
                {
                    if (Contador == 4 * tamañoPixel)
                    {
                        Segmentos++;
                        if (Segmentos == 2 * tamañoPixel)
                        {
                            Contador = 0;
                            Segmentos = 0;
                        }
                    }
                    else
                    {
                        TamañoPixel(pLista[0].X + x, pLista[0].Y + y, miColor);
                        TamañoPixel(pLista[0].X - x, pLista[0].Y + y, miColor);
                        TamañoPixel(pLista[0].X + y, pLista[0].Y + x, miColor);
                        TamañoPixel(pLista[0].X - y, pLista[0].Y + x, miColor);
                        TamañoPixel(pLista[0].X + x, pLista[0].Y - y, miColor);
                        TamañoPixel(pLista[0].X + y, pLista[0].Y - x, miColor);
                        TamañoPixel(pLista[0].X - x, pLista[0].Y - y, miColor);
                        TamañoPixel(pLista[0].X - y, pLista[0].Y - x, miColor);
                        Contador++;
                    }
                }
                e = e + 2 * y + 1;
                y = y + 1;
                if (2 * e > 2 * x - 1)
                {
                    x = x - 1;
                    e = e - 2 * x + 1;
                }
            }
        }
        //Metodo para crear Un Poligono Irregular
        public void PoligonoIrregular(List<Point> pLista, Color miColor)
        {
            for (int i = 0; i < pLista.Count - 1; i++)
            {
                Auxiliar.Add(new Point(pLista[i].X, pLista[i].Y));
                Auxiliar.Add(new Point(pLista[i + 1].X, pLista[i + 1].Y));
                LineaBresenham(Auxiliar, miColor);
                Auxiliar.Clear();
            }
            Auxiliar.Add(new Point(pLista[pLista.Count - 1].X, pLista[pLista.Count - 1].Y));
            Auxiliar.Add(new Point(pLista[0].X, pLista[0].Y));
            LineaBresenham(Auxiliar, miColor);
            Auxiliar.Clear();
            PixelesTG = new List<Point>(pLista);
        }
        //Metodo  para crear poligono regular inscrito en una Circunferencia
        public void PoligonoRegular(List<Point> pLista, Color miColor)
        {
            double X, Y;
            double gradosAngulo, i;
            gradosAngulo = 360 / ladosPoligono;

            for (i = 0; i < 360; i += gradosAngulo)
            {
                X = pLista[0].X + Radio * Math.Cos((i + (90 * (ladosPoligono - 2) / ladosPoligono)) * Math.PI / 180);
                Y = pLista[0].Y + Radio * Math.Sin((i + (90 * (ladosPoligono - 2) / ladosPoligono)) * Math.PI / 180);
                Auxiliar2.Add(new Point(Convert.ToInt32(X), Convert.ToInt32(Y)));
            }
            PoligonoIrregular(Auxiliar2, miColor);
            Auxiliar2.Clear();
        }
        //Metodo para crear un elipse por bresenham
        public void ElipseBresenham(List<Point> pLista, int Rx, int Ry, Color miColor)
        {
            int x, y, error;
            x = 0;
            y = Ry;
            error = 2 * Ry * Ry + (1 - 2 * Ry) * (Rx * Rx);
            while (Ry * Ry * x <= Rx * Rx * y)
            {
                //Crear elipce estilo Normal
                if (Estilos == 1)
                {
                    TamañoPixel(pLista[0].X + x, pLista[0].Y + y, miColor);
                    TamañoPixel(pLista[0].X + x, pLista[0].Y - y, miColor);
                    TamañoPixel(pLista[0].X - x, pLista[0].Y + y, miColor);
                    TamañoPixel(pLista[0].X - x, pLista[0].Y - y, miColor);
                }
                //Crear elipce estilo Punteado
                if (Estilos == 2)
                {
                    if (Contador == 2 * tamañoPixel)
                    {
                        TamañoPixel(pLista[0].X + x, pLista[0].Y + y, miColor);
                        TamañoPixel(pLista[0].X + x, pLista[0].Y - y, miColor);
                        TamañoPixel(pLista[0].X - x, pLista[0].Y + y, miColor);
                        TamañoPixel(pLista[0].X - x, pLista[0].Y - y, miColor);
                        Contador = 0;
                    }
                    else
                    {
                        Contador++;
                    }
                }
                //Crear elipce estilo segmentos
                if (Estilos == 4)
                {
                    if (Contador == 4 * tamañoPixel)
                    {
                        Segmentos++;
                        if (Segmentos == 2 * tamañoPixel)
                        {
                            Contador = 0;
                            Segmentos = 0;
                        }
                    }
                    else
                    {
                        TamañoPixel(pLista[0].X + x, pLista[0].Y + y, miColor);
                        TamañoPixel(pLista[0].X + x, pLista[0].Y - y, miColor);
                        TamañoPixel(pLista[0].X - x, pLista[0].Y + y, miColor);
                        TamañoPixel(pLista[0].X - x, pLista[0].Y - y, miColor);
                        Contador++;
                    }
                }
                x = x + 1;
                if (error >= 0)
                {
                    error = error + 4 * Rx * Rx * (1 - y);
                    y = y - 1;
                }
                error = error + Ry * Ry * (4 * x + 6);
            }
            y = 0;
            x = Rx;
            error = 2 * Rx * Rx + (1 - 2 * Rx) * (Ry * Ry);
            while (Rx * Rx * y <= Ry * Ry * x)
            {
                //Crear elipce estilo Normal
                if (Estilos == 1)
                {
                    TamañoPixel(pLista[0].X + x, pLista[0].Y + y, miColor);
                    TamañoPixel(pLista[0].X + x, pLista[0].Y - y, miColor);
                    TamañoPixel(pLista[0].X - x, pLista[0].Y + y, miColor);
                    TamañoPixel(pLista[0].X - x, pLista[0].Y - y, miColor);
                }
                //Crear elipce estilo Punteado
                if (Estilos == 2)
                {
                    if (Contador == 2 * tamañoPixel)
                    {
                        TamañoPixel(pLista[0].X + x, pLista[0].Y + y, miColor);
                        TamañoPixel(pLista[0].X + x, pLista[0].Y - y, miColor);
                        TamañoPixel(pLista[0].X - x, pLista[0].Y + y, miColor);
                        TamañoPixel(pLista[0].X - x, pLista[0].Y - y, miColor);
                        Contador = 0;
                    }
                    else
                    {
                        Contador++;
                    }
                }
                //Crear elipce estilo segmentos
                if (Estilos == 4)
                {
                    if (Contador == 4 * tamañoPixel)
                    {
                        Segmentos++;
                        if (Segmentos == 2 * tamañoPixel)
                        {
                            Contador = 0;
                            Segmentos = 0;
                        }
                    }
                    else
                    {
                        TamañoPixel(pLista[0].X + x, pLista[0].Y + y, miColor);
                        TamañoPixel(pLista[0].X + x, pLista[0].Y - y, miColor);
                        TamañoPixel(pLista[0].X - x, pLista[0].Y + y, miColor);
                        TamañoPixel(pLista[0].X - x, pLista[0].Y - y, miColor);
                        Contador++;
                    }
                }
                y = y + 1;
                if (error >= 0)
                {
                    error = error + 4 * Ry * Ry * (1 - x);
                    x = x - 1;
                }
                error = error + Rx * Rx * (4 * y + 6);
            }
        }
        //Metodo para crear elipse por Bresenham invertido
        public void ElipseBresenhamRotado(List<Point> pLista, int Rx, int Ry, Color miColor)
        {
            int x, y, error, Xr, Yr;
            x = 0;
            y = Ry;
            error = 2 * Ry * Ry + (1 - 2 * Ry) * (Rx * Rx);
            while (Ry * Ry * x <= Rx * Rx * y)
            {
                Xr = Convert.ToInt32((Xc + (pLista[0].X + x - Xc) * Math.Cos(Grados2 * Math.PI / 180) - (pLista[0].Y + y - Yc) * Math.Sin(Grados2 * Math.PI / 180)));
                Yr = Convert.ToInt32((Yc + (pLista[0].X + x - Xc) * Math.Sin(Grados2 * Math.PI / 180) + (pLista[0].Y + y - Yc) * Math.Cos(Grados2 * Math.PI / 180)));
                TamañoPixel(Xr, Yr, miColor);
                Xr = Convert.ToInt32((Xc + (pLista[0].X + x - Xc) * Math.Cos(Grados2 * Math.PI / 180) - (pLista[0].Y - y - Yc) * Math.Sin(Grados2 * Math.PI / 180)));
                Yr = Convert.ToInt32((Yc + (pLista[0].X + x - Xc) * Math.Sin(Grados2 * Math.PI / 180) + (pLista[0].Y - y - Yc) * Math.Cos(Grados2 * Math.PI / 180)));
                TamañoPixel(Xr, Yr, miColor);
                Xr = Convert.ToInt32((Xc + (pLista[0].X - x - Xc) * Math.Cos(Grados2 * Math.PI / 180) - (pLista[0].Y + y - Yc) * Math.Sin(Grados2 * Math.PI / 180)));
                Yr = Convert.ToInt32((Yc + (pLista[0].X - x - Xc) * Math.Sin(Grados2 * Math.PI / 180) + (pLista[0].Y + y - Yc) * Math.Cos(Grados2 * Math.PI / 180)));
                TamañoPixel(Xr, Yr, miColor);
                Xr = Convert.ToInt32((Xc + (pLista[0].X - x - Xc) * Math.Cos(Grados2 * Math.PI / 180) - (pLista[0].Y - y - Yc) * Math.Sin(Grados2 * Math.PI / 180)));
                Yr = Convert.ToInt32((Yc + (pLista[0].X - x - Xc) * Math.Sin(Grados2 * Math.PI / 180) + (pLista[0].Y - y - Yc) * Math.Cos(Grados2 * Math.PI / 180)));
                TamañoPixel(Xr, Yr, miColor);
                x = x + 1;
                if(error >= 0)
                {
                    error = error + 4 * Rx * Rx * (1 - y);
                    y = y - 1;
                }
                error = error + Ry * Ry * (4 * x + 6);
            }
            y = 0;
            x = Rx;
            error = 2 * Rx * Rx + (1 - 2 * Rx) * (Ry * Ry);
            while (Rx * Rx * y <= Ry * Ry * x)
            {
                Xr = Convert.ToInt32((Xc + (pLista[0].X + x - Xc) * Math.Cos(Grados2 * Math.PI / 180) - (pLista[0].Y + y - Yc) * Math.Sin(Grados2 * Math.PI / 180)));
                Yr = Convert.ToInt32((Yc + (pLista[0].X + x - Xc) * Math.Sin(Grados2 * Math.PI / 180) + (pLista[0].Y + y - Yc) * Math.Cos(Grados2 * Math.PI / 180)));
                TamañoPixel(Xr, Yr, miColor);
                Xr = Convert.ToInt32((Xc + (pLista[0].X + x - Xc) * Math.Cos(Grados2 * Math.PI / 180) - (pLista[0].Y - y - Yc) * Math.Sin(Grados2 * Math.PI / 180)));
                Yr = Convert.ToInt32((Yc + (pLista[0].X + x - Xc) * Math.Sin(Grados2 * Math.PI / 180) + (pLista[0].Y - y - Yc) * Math.Cos(Grados2 * Math.PI / 180)));
                TamañoPixel(Xr, Yr, miColor);
                Xr = Convert.ToInt32((Xc + (pLista[0].X - x - Xc) * Math.Cos(Grados2 * Math.PI / 180) - (pLista[0].Y + y - Yc) * Math.Sin(Grados2 * Math.PI / 180)));
                Yr = Convert.ToInt32((Yc + (pLista[0].X - x - Xc) * Math.Sin(Grados2 * Math.PI / 180) + (pLista[0].Y + y - Yc) * Math.Cos(Grados2 * Math.PI / 180)));
                TamañoPixel(Xr, Yr, miColor);
                Xr = Convert.ToInt32((Xc + (pLista[0].X - x - Xc) * Math.Cos(Grados2 * Math.PI / 180) - (pLista[0].Y - y - Yc) * Math.Sin(Grados2 * Math.PI / 180)));
                Yr = Convert.ToInt32((Yc + (pLista[0].X - x - Xc) * Math.Sin(Grados2 * Math.PI / 180) + (pLista[0].Y - y - Yc) * Math.Cos(Grados2 * Math.PI / 180)));
                TamañoPixel(Xr, Yr, miColor);
                y = y + 1;
                if (error >= 0)
                {
                    error = error + 4 * Ry * Ry * (1 - x);
                    x = x - 1;
                }
                error = error + Rx * Rx * (4 * y + 6);
            }
        }
        //Metodo de relleno por inundacion
        public void Relleno(int x, int y, Color colorRelleno)
        {
            if (x > 0 && x < ptbLienzo.Width && y > 0 && y < ptbLienzo.Height)
            {
                colorFondo = Lienzo.GetPixel(x, y);
            }
            Stack<Point> vecinos = new Stack<Point>();
            vecinos.Push(new Point(x, y));
            if (colorFondo.ToArgb() != colorRelleno.ToArgb())
            {
                while (vecinos.Count > 0)
                {
                    Point pixel = vecinos.Pop();
                    if (pixel.X > 0 && pixel.X < ptbLienzo.Width && pixel.Y > 0 && pixel.Y < ptbLienzo.Height)
                    {
                        cCol = Lienzo.GetPixel(pixel.X, pixel.Y);
                        if (cCol != colorRelleno && cCol == colorFondo)
                        {
                            Lienzo.SetPixel(pixel.X, pixel.Y, colorRelleno);
                            vecinos.Push(new Point(pixel.X + 1, pixel.Y));
                            vecinos.Push(new Point(pixel.X - 1, pixel.Y));
                            vecinos.Push(new Point(pixel.X, pixel.Y + 1));
                            vecinos.Push(new Point(pixel.X, pixel.Y - 1));
                        }
                    }
                }
            }
            vecinos.Clear();
        }
        //Metodo para desactivar las opciones a elegir
        public void DesactivarBoton()
        {
            mnsSelectorDeColoresToolStripMenuItem.Checked = false;
            mnsLinea.Checked = false;
            mnsPoligonoIrregular.Checked = false;
            mnsPoligonoRegular.Checked = false;
            mnsPunto.Checked = false;
            lineaPoligonalToolStripMenuItem.Checked = false;
            btnCirculo.Checked = false;
            mnsElipse.Checked = false;
            btnRellenar.BackColor = Color.White;
        }
        //Meodo para solucionar errores con los metodos y estilos
        public void ErrorEstilos()
        {
            if (Estilos == 2)
            {
                Contador = 2;
            }
            else if (Estilos == 4)
            {
                Contador = 4;
                Segmentos = 0;
            }
        }
        //Metodo selector de colores
        public void SelectorColores(int x, int y)
        {
            this.btnColor.BackColor = Lienzo.GetPixel(x, y);
            colorPintar = Lienzo.GetPixel(x, y);
        }
        //Metodo para crear Muñeco de Nieve
        public void MuñecoNieve(List<Point> pLista, Color miColor)
        {
            int corX = pLista[0].X;
            int corY = pLista[0].Y;
            List<Point> Punto = new List<Point>();
            int x, y, e;
            x = Radio;
            y = 0;
            e = 0;
            //Codigo Para la cabeza
            while (x >= y)
            {
                TamañoPixel(pLista[0].X + x, pLista[0].Y + y, miColor);
                TamañoPixel(pLista[0].X - x, pLista[0].Y + y, miColor);
                TamañoPixel(pLista[0].X + x, pLista[0].Y - y, miColor);
                TamañoPixel(pLista[0].X + y, pLista[0].Y - x, miColor);
                TamañoPixel(pLista[0].X - x, pLista[0].Y - y, miColor);
                TamañoPixel(pLista[0].X - y, pLista[0].Y - x, miColor);
                e = e + 2 * y + 1;
                y = y + 1;
                if (2 * e > 2 * x - 1)
                {
                    x = x - 1;
                    e = e - 2 * x + 1;
                }
            }

            x = Radio + (Radio - 70) / 2;
            y = 0;
            e = 0;
            //Codigo para Cuerpo de Mono de Nieve 
            while (x >= y)
            {
                TamañoPixel(pLista[0].X + x + 5, pLista[0].Y + y + Radio + 35, miColor);
                TamañoPixel(pLista[0].X - x - 5, pLista[0].Y + y + Radio + 35, miColor);
                TamañoPixel(pLista[0].X + x + 5, pLista[0].Y - y + Radio + 35, miColor);
                TamañoPixel(pLista[0].X - x - 5, pLista[0].Y - y + Radio + 35, miColor);
                e = e + 2 * y + 1;
                y = y + 1;
                if (2 * e > 2 * x - 1)
                {
                    x = x - 1;
                    e = e - 2 * x + 1;
                }
            }

            x = Radio + (Radio - 15) / 2;
            y = 0;
            e = 0;
            //Codigo para cuerpo de mono de nieve parte baja
            while (x >= y)
            {
                TamañoPixel(pLista[0].X + x, pLista[0].Y + y + (Radio + 50) * 2, miColor);
                TamañoPixel(pLista[0].X - x, pLista[0].Y + y + (Radio + 50) * 2, miColor);
                TamañoPixel(pLista[0].X + y, pLista[0].Y + x + (Radio + 50) * 2, miColor);
                TamañoPixel(pLista[0].X - y, pLista[0].Y + x + (Radio + 50) * 2, miColor);
                TamañoPixel(pLista[0].X + x, pLista[0].Y - y + (Radio + 50) * 2, miColor);
                TamañoPixel(pLista[0].X - x, pLista[0].Y - y + (Radio + 50) * 2, miColor);
                e = e + 2 * y + 1;
                y = y + 1;
                if (2 * e > 2 * x - 1)
                {
                    x = x - 1;
                    e = e - 2 * x + 1;
                }
            }
            Relleno(pLista[0].X, pLista[0].Y + x, Color.AliceBlue);

            x = Radio - 90;
            y = 0;
            e = 0;
            //Codigo para ojo de mono de nieve
            while (x >= y)
            {
                TamañoPixel(pLista[0].X + x - Radio + 70, pLista[0].Y + y - Radio + 45, miColor);
                TamañoPixel(pLista[0].X - x - Radio + 70, pLista[0].Y + y - Radio + 45, miColor);
                TamañoPixel(pLista[0].X + y - Radio + 70, pLista[0].Y + x - Radio + 45, miColor);
                TamañoPixel(pLista[0].X - y - Radio + 70, pLista[0].Y + x - Radio + 45, miColor);
                TamañoPixel(pLista[0].X + x - Radio + 70, pLista[0].Y - y - Radio + 45, miColor);
                TamañoPixel(pLista[0].X + y - Radio + 70, pLista[0].Y - x - Radio + 45, miColor);
                TamañoPixel(pLista[0].X - x - Radio + 70, pLista[0].Y - y - Radio + 45, miColor);
                TamañoPixel(pLista[0].X - y - Radio + 70, pLista[0].Y - x - Radio + 45, miColor);
                e = e + 2 * y + 1;
                y = y + 1;
                if (2 * e > 2 * x - 1)
                {
                    x = x - 1;
                    e = e - 2 * x + 1;
                }
            }
            Relleno(pLista[0].X + x - Radio + 69, pLista[0].Y + y - Radio + 43, Color.Black);
            x = Radio - 90;
            y = 0;
            e = 0;
            //Codigo para ojo de mono de nieve
            while (x >= y)
            {
                TamañoPixel(pLista[0].X + x - Radio + 130, pLista[0].Y + y - Radio + 45, miColor);
                TamañoPixel(pLista[0].X - x - Radio + 130, pLista[0].Y + y - Radio + 45, miColor);
                TamañoPixel(pLista[0].X + y - Radio + 130, pLista[0].Y + x - Radio + 45, miColor);
                TamañoPixel(pLista[0].X - y - Radio + 130, pLista[0].Y + x - Radio + 45, miColor);
                TamañoPixel(pLista[0].X + x - Radio + 130, pLista[0].Y - y - Radio + 45, miColor);
                TamañoPixel(pLista[0].X + y - Radio + 130, pLista[0].Y - x - Radio + 45, miColor);
                TamañoPixel(pLista[0].X - x - Radio + 130, pLista[0].Y - y - Radio + 45, miColor);
                TamañoPixel(pLista[0].X - y - Radio + 130, pLista[0].Y - x - Radio + 45, miColor);
                e = e + 2 * y + 1;
                y = y + 1;
                if (2 * e > 2 * x - 1)
                {
                    x = x - 1;
                    e = e - 2 * x + 1;
                }
            }
            Relleno(pLista[0].X + x - Radio + 129, pLista[0].Y + y - Radio + 43, Color.Black);
            x = Radio - 90;
            y = 0;
            e = 0;
            //Codigo para boton de mono de nieve
            while (x >= y)
            {
                TamañoPixel(pLista[0].X + x, pLista[0].Y + y + Radio + 45, miColor);
                TamañoPixel(pLista[0].X - x, pLista[0].Y + y + Radio + 45, miColor);
                TamañoPixel(pLista[0].X + y, pLista[0].Y + x + Radio + 45, miColor);
                TamañoPixel(pLista[0].X - y, pLista[0].Y + x + Radio + 45, miColor);
                TamañoPixel(pLista[0].X + x, pLista[0].Y - y + Radio + 45, miColor);
                TamañoPixel(pLista[0].X + y, pLista[0].Y - x + Radio + 45, miColor);
                TamañoPixel(pLista[0].X - x, pLista[0].Y - y + Radio + 45, miColor);
                TamañoPixel(pLista[0].X - y, pLista[0].Y - x + Radio + 45, miColor);
                e = e + 2 * y + 1;
                y = y + 1;
                if (2 * e > 2 * x - 1)
                {
                    x = x - 1;
                    e = e - 2 * x + 1;
                }
            }
            Relleno(pLista[0].X + x, pLista[0].Y + y + Radio + 43, Color.Black);
            x = Radio - 95;
            y = 0;
            e = 0;
            //Codigo para boton de mono de nieve
            while (x >= y)
            {
                TamañoPixel(pLista[0].X + x, pLista[0].Y + y + Radio, miColor);
                TamañoPixel(pLista[0].X - x, pLista[0].Y + y + Radio, miColor);
                TamañoPixel(pLista[0].X + y, pLista[0].Y + x + Radio, miColor);
                TamañoPixel(pLista[0].X - y, pLista[0].Y + x + Radio, miColor);
                TamañoPixel(pLista[0].X + x, pLista[0].Y - y + Radio, miColor);
                TamañoPixel(pLista[0].X + y, pLista[0].Y - x + Radio, miColor);
                TamañoPixel(pLista[0].X - x, pLista[0].Y - y + Radio, miColor);
                TamañoPixel(pLista[0].X - y, pLista[0].Y - x + Radio, miColor);
                e = e + 2 * y + 1;
                y = y + 1;
                if (2 * e > 2 * x - 1)
                {
                    x = x - 1;
                    e = e - 2 * x + 1;
                }
            }
            Relleno(pLista[0].X + x, pLista[0].Y + y + Radio - 2, Color.Black);
            x = Radio - 85;
            y = 0;
            e = 0;
            //Codigo para boton de mono de nieve
            while (x >= y)
            {
                TamañoPixel(pLista[0].X + x, pLista[0].Y + y + Radio + 100, miColor);
                TamañoPixel(pLista[0].X - x, pLista[0].Y + y + Radio + 100, miColor);
                TamañoPixel(pLista[0].X + y, pLista[0].Y + x + Radio + 100, miColor);
                TamañoPixel(pLista[0].X - y, pLista[0].Y + x + Radio + 100, miColor);
                TamañoPixel(pLista[0].X + x, pLista[0].Y - y + Radio + 100, miColor);
                TamañoPixel(pLista[0].X + y, pLista[0].Y - x + Radio + 100, miColor);
                TamañoPixel(pLista[0].X - x, pLista[0].Y - y + Radio + 100, miColor);
                TamañoPixel(pLista[0].X - y, pLista[0].Y - x + Radio + 100, miColor);
                e = e + 2 * y + 1;
                y = y + 1;
                if (2 * e > 2 * x - 1)
                {
                    x = x - 1;
                    e = e - 2 * x + 1;
                }
            }
            Relleno(pLista[0].X + x, pLista[0].Y + y + Radio + 93, Color.Black);
            x = Radio - 50;
            y = 0;
            e = 0;
            //Codigo para Sonrisa de Mono de nieve
            while (x >= y)
            {
                TamañoPixel(pLista[0].X + y, pLista[0].Y + x - Radio + 80, miColor);
                TamañoPixel(pLista[0].X - y, pLista[0].Y + x - Radio + 80, miColor);
                e = e + 2 * y + 1;
                y = y + 1;
                if (2 * e > 2 * x - 1)
                {
                    x = x - 1;
                    e = e - 2 * x + 1;
                }
            }
            x = Radio - 90;
            double X, Y;
            int lados = 3;
            double gradosAngulo, i;
            //Codigo para nariz de mono de nieve
            gradosAngulo = 360 / lados;
            for (i = 0; i < 360; i += gradosAngulo)
            {
                X = pLista[0].X + x + 25 * Math.Cos((i + (335 * (lados - 2) / lados)) * Math.PI / 180);
                Y = (pLista[0].Y - 10) + x * Math.Sin((i + (335 * (lados - 2) / lados)) * Math.PI / 180);
                Auxiliar2.Add(new Point(Convert.ToInt32(X), Convert.ToInt32(Y)));
            }
            PoligonoIrregular(Auxiliar2, miColor);
            Relleno(pLista[0].X + 10, pLista[0].Y - 5, Color.Red);
            Auxiliar2.Clear();
            lados = 4;
            x = Radio;
            //Codigo para Sombrero de mono de nieve
            gradosAngulo = 360 / lados;
            for (i = 0; i < 360; i += gradosAngulo)
            {
                X = (pLista[0].X - 115) + x + 130 * Math.Cos((i + (267 * (lados - 2) / lados)) * Math.PI / 180);
                Y = (pLista[0].Y - 100) + 20 * Math.Sin((i + (170 * (lados - 2) / lados)) * Math.PI / 180);
                Auxiliar2.Add(new Point(Convert.ToInt32(X), Convert.ToInt32(Y)));
            }
            PoligonoIrregularSinCerrar(Auxiliar2, miColor);
            Auxiliar2.Clear();
            Punto.Add(new Point(corX - 105, corY - 81));
            Punto.Add(new Point(corX - 42, corY - 90));
            LineaBresenham(Punto, miColor);
            Punto.Clear();
            Punto.Add(new Point(corX + 80, corY - 102));
            Punto.Add(new Point(corX + 27, corY - 96));
            LineaBresenham(Punto, miColor);
            Punto.Clear();
            Relleno(pLista[0].X + 20, pLista[0].Y - 105, Color.Brown);
            lados = 4;
            x = Radio;
            gradosAngulo = 360 / lados;
            for (i = 0; i < 360; i += gradosAngulo)
            {
                X = (pLista[0].X - 121) + x + 91 * Math.Cos((i + (285 * (lados - 2) / lados)) * Math.PI / 180);
                Y = (pLista[0].Y - 152) - 60 * Math.Sin((i + (290 * (lados - 2) / lados)) * Math.PI / 180);
                Auxiliar2.Add(new Point(Convert.ToInt32(X), Convert.ToInt32(Y)));
            }
            PoligonoIrregular(Auxiliar2, miColor);
            Relleno(pLista[0].X, pLista[0].Y - 130, Color.Brown);
            Auxiliar2.Clear();
            lados = 4;
            x = Radio;
            gradosAngulo = 360 / lados;
            for (i = 0; i < 360; i += gradosAngulo)
            {
                X = (pLista[0].X - 122) + x + 90 * Math.Cos((i + (268 * (lados - 2) / lados)) * Math.PI / 180);
                Y = (pLista[0].Y - 160) + 15 * Math.Sin((i + (170 * (lados - 2) / lados)) * Math.PI / 180);
                Auxiliar2.Add(new Point(Convert.ToInt32(X), Convert.ToInt32(Y)));
            }
            PoligonoIrregular(Auxiliar2, miColor);
            Relleno(pLista[0].X, pLista[0].Y - 160, Color.Red);
            Auxiliar2.Clear();
            lados = 4;
            x = Radio;
            //Brazo mono de Nieve derecho
            Punto.Add(new Point(corX + 117, corY + 120));
            Punto.Add(new Point(corX + 220, corY));
            LineaBresenham(Punto, Color.SaddleBrown);
            Punto.Clear();
            Punto.Add(new Point(corX + 220, corY));
            Punto.Add(new Point(corX + 220, corY - 20));
            LineaBresenham(Punto, Color.SaddleBrown);
            Punto.Clear();
            Punto.Add(new Point(corX + 220, corY));
            Punto.Add(new Point(corX + 250, corY - 20));
            LineaBresenham(Punto, Color.SaddleBrown);
            Punto.Clear();
            Punto.Add(new Point(corX + 166, corY + 61));
            Punto.Add(new Point(corX + 200, corY + 55));
            LineaBresenham(Punto, Color.SaddleBrown);
            Punto.Clear();
            //Brazo Mono de nieve Izquierdo
            Punto.Add(new Point(corX - 120, corY + 120));
            Punto.Add(new Point(corX - 220, corY));
            LineaBresenham(Punto, Color.SaddleBrown);
            Punto.Clear();
            Punto.Add(new Point(corX - 220, corY));
            Punto.Add(new Point(corX - 220, corY - 20));
            LineaBresenham(Punto, Color.SaddleBrown);
            Punto.Clear();
            Punto.Add(new Point(corX - 220, corY));
            Punto.Add(new Point(corX - 250, corY - 20));
            LineaBresenham(Punto, Color.SaddleBrown);
            Punto.Clear();
            Punto.Add(new Point(corX - 167, corY + 61));
            Punto.Add(new Point(corX - 200, corY + 55));
            LineaBresenham(Punto, Color.SaddleBrown);
            Punto.Clear();
            //Moño de mono de nieve
            x = Radio - 90;
            y = 0;
            e = 0;
            while (x >= y)
            {
                TamañoPixel(pLista[0].X + x, pLista[0].Y + y + 60, miColor);
                TamañoPixel(pLista[0].X - x, pLista[0].Y + y + 60, miColor);
                TamañoPixel(pLista[0].X + y, pLista[0].Y + x + 60, miColor);
                TamañoPixel(pLista[0].X - y, pLista[0].Y + x + 60, miColor);
                TamañoPixel(pLista[0].X + x, pLista[0].Y - y + 60, miColor);
                TamañoPixel(pLista[0].X + y, pLista[0].Y - x + 60, miColor);
                TamañoPixel(pLista[0].X - x, pLista[0].Y - y + 60, miColor);
                TamañoPixel(pLista[0].X - y, pLista[0].Y - x + 60, miColor);
                y = y + 1;
                if (2 * e > 2 * x - 1)
                {
                    x = x - 1;
                    e = e - 2 * x + 1;
                }
            }
            Relleno(pLista[0].X, pLista[0].Y + 60, Color.Red);
            x = Radio - 85;
            lados = 3;
            gradosAngulo = 360 / lados;
            for (i = 0; i < 360; i += gradosAngulo)
            {
                X = (pLista[0].X - 45) + x + 30 * Math.Cos((i + (360 * (lados - 2) / lados)) * Math.PI / 180);
                Y = (pLista[0].Y + 60) + x * Math.Sin((i + (360 * (lados - 2) / lados)) * Math.PI / 180);
                Auxiliar2.Add(new Point(Convert.ToInt32(X), Convert.ToInt32(Y)));
            }
            PoligonoIrregular(Auxiliar2, miColor);
            Relleno(pLista[0].X - 35, pLista[0].Y + 60, Color.Red);
            Auxiliar2.Clear();
            gradosAngulo = 360 / lados;
            for (i = 0; i < 360; i += gradosAngulo)
            {
                X = (pLista[0].X + 15) + x + 30 * Math.Cos((i + (180 * (lados - 2) / lados)) * Math.PI / 180);
                Y = (pLista[0].Y + 60) + x * Math.Sin((i + (180 * (lados - 2) / lados)) * Math.PI / 180);
                Auxiliar2.Add(new Point(Convert.ToInt32(X), Convert.ToInt32(Y)));
            }
            PoligonoIrregular(Auxiliar2, miColor);
            Relleno(pLista[0].X + 35, pLista[0].Y + 60, Color.Red);
            Auxiliar2.Clear();
        }
        //Metodo Poligono irregular especial para dejar la figura abierta
        public void PoligonoIrregularSinCerrar(List<Point> pLista, Color miColor)
        {
            for (int i = 0; i < pLista.Count - 1; i++)
            {
                Auxiliar.Add(new Point(pLista[i].X, pLista[i].Y));
                Auxiliar.Add(new Point(pLista[i + 1].X, pLista[i + 1].Y));
                LineaBresenham(Auxiliar, miColor);
                Auxiliar.Clear();
            }
        }
        //Metodo de traslacion
        public void Traslacion(List<Point> PixelesTG, int Tx, int Ty, int ID, Color Micolor)
        {
            for (int i = 0; i < PixelesTG.Count; i++)
            {
                TPixeles.Add(new Point(PixelesTG[i].X + Tx, PixelesTG[i].Y + Ty));
            }
            if (ID == 2)
            {
                LineaBresenham(PixelesTG, colorFondo);
                LineaBresenham(TPixeles, Micolor);
            }
            if (ID == 3)
            {
                PoligonoIrregular(PixelesTG, colorFondo);
                PoligonoIrregular(TPixeles, Micolor);
            }
            if (ID == 4)
            {
                PoligonoIrregular(PixelesTG, colorFondo);
                PoligonoIrregular(TPixeles, Micolor);
            }
            if (ID == 5)
            {
                CircunferenciaBresenham(PixelesTG, colorFondo);
                CircunferenciaBresenham(TPixeles, Micolor);
            }
            if (ID == 6)
            {
                if (Grados2 == aux*2)
                {
                    ElipseBresenham(PixelesTG, RadioY, RadioX, colorFondo);
                    ElipseBresenham(TPixeles, RadioY, RadioX, Micolor);
                }
                else
                {
                    ElipseBresenham(PixelesTG, RadioX, RadioY, colorFondo);
                    ElipseBresenham(PixelesTG, RadioY, RadioX, colorFondo);
                    ElipseBresenham(TPixeles, RadioX, RadioY, Micolor);
                }
            }

            for (int j = 0; j < PixelesTG.Count; j++)
            {
                PixelesTG[j] = TPixeles[j];
            }
            TPixeles.Clear();
        }
        //Metodo Linea Poligonal
        public void LineaPoligonal(List<Point> pLista, Color miColor)
        {
            LineaBresenham(pLista, miColor);
        }
        //Metodo de Rotación
        public void Rotacion(List<Point> PixelesTG, int Grados, int ID, Color miColor)
        {
            int Xr, Yr;
            for(int i = 0; i < PixelesTG.Count; i++)
            {
                Xr = Convert.ToInt32(Xc + (PixelesTG[i].X - Xc) * Math.Cos(Grados * Math.PI / 180) - (PixelesTG[i].Y - Yc) * Math.Sin(Grados * Math.PI / 180));
                Yr = Convert.ToInt32(Yc + (PixelesTG[i].X - Xc) * Math.Sin(Grados * Math.PI / 180) + (PixelesTG[i].Y - Yc) * Math.Cos(Grados * Math.PI / 180));
                TPixeles.Add(new Point(Xr, Yr));
            }
            if (ID == 2)
            {
                LineaBresenham(PixelesTG, colorFondo);
                LineaBresenham(TPixeles, miColor);
            }
            if (ID == 3)
            {
                PoligonoIrregular(PixelesTG, colorFondo);
                PoligonoIrregular(TPixeles, miColor);
            }
            if (ID == 4)
            {
                PoligonoIrregular(PixelesTG, colorFondo);
                PoligonoIrregular(TPixeles, miColor);
            }
            if (ID == 6)
            {
                ElipseBresenham(PixelesTG, RadioY, RadioX, colorFondo);
                ElipseBresenham(PixelesTG, RadioX, RadioY, colorFondo);
                ElipseBresenhamRotado(TPixeles, RadioX, RadioY, miColor);
            }
            for(int j=0;j < PixelesTG.Count; j++)
            {
                PixelesTG[j] = TPixeles[j];
            }
            TPixeles.Clear();
        }
        //Metodo de escalamiento de figuras
        public void Escalamiento(List<Point>PixelesTG,float Sx, float Sy,Color miColor)
        {
            int Xs, Ys;
            for(int i = 0; i < PixelesTG.Count; i++)
            {
                Xs = Convert.ToInt32(Xc + Sx * (PixelesTG[i].X - Xc));
                Ys = Convert.ToInt32(Yc + Sy * (PixelesTG[i].Y - Yc));
                TPixeles.Add(new Point(Xs, Ys));
            }
            if (ID == 2)
            {
                LineaBresenham(PixelesTG, colorFondo);
                LineaBresenham(TPixeles, miColor);
            }
            if (ID == 3)
            {
                PoligonoIrregular(PixelesTG, colorFondo);
                PoligonoIrregular(TPixeles, miColor);
            }
            if (ID == 4)
            {
                PoligonoIrregular(PixelesTG, colorFondo);
                PoligonoIrregular(TPixeles, miColor);
            }
            if (ID == 5)
            {
                CircunferenciaBresenham(PixelesTG, colorFondo);
                Radio = Convert.ToInt32(Radio * Sx);
                CircunferenciaBresenham(TPixeles, miColor);
            }
            if (ID == 6)
            {
                if (Grados2 == aux * 2)
                {
                    ElipseBresenham(PixelesTG, RadioY, RadioX, colorFondo);
                    RadioX = Convert.ToInt32(RadioX * Sx);
                    RadioY = Convert.ToInt32(RadioY * Sy);
                    ElipseBresenham(TPixeles, RadioY, RadioX, miColor);
                }
                else
                {
                    ElipseBresenham(PixelesTG, RadioX, RadioY, colorFondo);
                    ElipseBresenham(PixelesTG, RadioY, RadioX, colorFondo);
                    RadioX = Convert.ToInt32(RadioX * Sx);
                    RadioY = Convert.ToInt32(RadioY * Sy);
                    ElipseBresenham(TPixeles, RadioX, RadioY, miColor);
                }
            }
            for(int j = 0; j < PixelesTG.Count; j++)
            {
                PixelesTG[j] = TPixeles[j];
            }
            TPixeles.Clear();
        }
    }
}