namespace WinFormsApp32
{
    public partial class Form1 : Form
    {   public Form1()
            {
                InitializeComponent();
                this.Paint += Forma1_Paint;
            }

            private void Forma1_Paint(object? sender, PaintEventArgs e)
            {
                Graphics g = e.Graphics;
            SolidBrush brush = new SolidBrush(Color.Blue);
            Rectangle squareRect = new Rectangle(50, 50, 100, 100);
            g.FillRectangle(brush, squareRect);
           
                Point[] trianglePoints = new Point[]
            {
            new Point(250, 50),
            new Point(200, 150),
            new Point(300, 150)
            };
            g.FillPolygon(brush, trianglePoints);
            
                Rectangle circleRect = new Rectangle(450, 50, 100, 100);
                g.FillRectangle(brush, circleRect);
                g.Dispose();
            }
        }
    }