using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Abstract_Factory1
{
    public partial class Form1 : Form
    {
        private IShapeFactory _shapeFactory;
        private List<IShape> _shapes;
        private ComboBox cmbColorFactory;
        public Form1()
        {
            InitializeComponent();

            cmbColorFactory.Items.Add("Red");
            cmbColorFactory.Items.Add("Blue");
            cmbColorFactory.SelectedIndex = 0;

            _shapes = new List<IShape>();
            UpdateShapes();
        }

        private void InitializeComponent()
        {
            this.cmbColorFactory = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
         
            
            this.cmbColorFactory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbColorFactory.FormattingEnabled = true;
            this.cmbColorFactory.Location = new System.Drawing.Point(12, 12);
            this.cmbColorFactory.Name = "cmbColorFactory";
            this.cmbColorFactory.Size = new System.Drawing.Size(121, 21);
            this.cmbColorFactory.TabIndex = 0;
            this.cmbColorFactory.SelectedIndexChanged += new System.EventHandler(this.cmbColorFactory_SelectedIndexChanged);
         
            this.ClientSize = new System.Drawing.Size(500, 250);
            this.Controls.Add(this.cmbColorFactory);
            this.Name = "MainForm";
            this.Text = "Абстрактная фабрика - Пример";
            this.ResumeLayout(false);
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void cmbColorFactory_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateShapes();
            Invalidate();  
        }

        private void UpdateShapes()
        {
           
            _shapes.Clear();

           
            switch (cmbColorFactory.SelectedItem.ToString())
            {
                case "Red":
                    _shapeFactory = new RedFactory();
                    break;
                case "Blue":
                    _shapeFactory = new BlueFactory();
                    break;
            }

            _shapes.Add(_shapeFactory.CreateCircle());
            _shapes.Add(_shapeFactory.CreateSquare());
            _shapes.Add(_shapeFactory.CreateTriangle());
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            foreach (var shape in _shapes)
            {
                shape.Draw(e.Graphics);
            }
        }

      
    }
}
