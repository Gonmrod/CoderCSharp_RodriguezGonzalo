using System.Data;
using System.Data.SqlClient;

namespace WinFormsAppADO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string connectionString = @"Server=localhost\SQLEXPRESS; Database=SistemaGestion ; Trusted_Connection=True; User=sa; Password=Admin1234;";
            string query = "SELECT Id, Descripciones, Costo, PrecioVenta FROM Producto";
            List<Producto> listProductos = new List<Producto>();

            using(SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using(SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader dataReader = command.ExecuteReader())
                    {
                        if (dataReader.HasRows) 
                        { 
                            while (dataReader.Read())
                            {
                                Producto producto = new Producto();
                                producto.Id = Convert.ToInt32(dataReader["Id"]);
                                producto.Descripciones = dataReader["Descripciones"].ToString();
                                producto.Costo = Convert.ToDouble(dataReader["Costo"]);
                                producto.PrecioVenta = Convert.ToDouble(dataReader["PrecioVenta"]);

                                listProductos.Add(producto);
                            }
                        }
                    }
                    connection.Close();
                }
            }
            dgvLista.DataSource = listProductos;
            dgvLista.AutoGenerateColumns = true;
        }
    }
}
