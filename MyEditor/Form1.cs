namespace MyEditor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog Open = new OpenFileDialog();
            System.IO.StreamReader myStreamReader = null;
            //confgurar el filtro para archivos de textp
            Open.Filter = "Archivos de texto (*.txt*)|*.txt|Todos los archivos (*.*)|*.*";
            Open.CheckFileExists = true;
            Open.Title = "Abrir archivo";
            Open.ShowDialog(this);
            try
            {
                //Este codigo para mostar la info en el rich text box
                Open.OpenFile();
                myStreamReader = System.IO.File.OpenText(Open.FileName);
                richTextBox1.Text = myStreamReader.ReadToEnd();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al abrir el archivo: " + ex.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }

        private void azulToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void rojoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void timesNewRomanToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void comicSansToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void formatoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void fuenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Undo();
        }

        private void guardarComoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //guardar
            SaveFileDialog save = new SaveFileDialog();
            System.IO.StreamWriter myStreamWriter = null;
            //al igual que para abrir ponemos filtros para guardar
            save.Filter = "Archivos de texto (*.txt*)|*.txt|HTML (*.html)|*.html|Todos los Archivos(*.*)|*.*";
            save.Title = "Guardar Archivo";
            save.ShowDialog(this);
            try
            {
                //este codigo paragauradar la info del rich text box en el archivo
                myStreamWriter = System.IO.File.AppendText(save.FileName);
                myStreamWriter.Write(richTextBox1.Text);
                myStreamWriter.Flush();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar el archivo: " + ex.Message);
            }

        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Redo();
        }

        private void copiarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }

        private void pegarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }

        private void cortarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }

        private void seleccionarTodoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectAll();
        }

        private void borrarTodoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }

        private void colorFuenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //cremos el objwto fotn dialog para cambiar la fuente de texto
            FontDialog font = new FontDialog();
            //aplicamos  el tipo de fuente al rich text box
            font.Font = richTextBox1.Font;
            //se hace la validacion para que ek usuario  peuda cambiar de la fuente
            if (font.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.Font = font.Font;
            }

        }

        private void colorDeFondoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog fondo= new ColorDialog();
            if(fondo.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.BackColor= fondo.Color;
            }
        }
    }
}
