public interface IProductoRepository {
    void CrearNuevo(Productos producto);
    void ModificarProducto(Productos productos,int id);
    List<Productos> ListarProductos();
    Productos ObtenerDetalles(int id);
    void EliminarProducto(int id);
    }

public class ProductoRepository : IProductoRepository
{
    private string CadenaDeConexion = "Data Source=db/Tienda.db;Cache=Shared";

    public void CrearNuevo(Productos producto)
    {
        using (SqlConnection connection = new SqlConnection(CadenaDeConexion)) 
        {
            connection.Open();

            // haces la consulta
            string queryString= "INSERT INTO Productos(Descripcion,Precio) VALUES ($descripcion, $precio)";
            var command= new SqlCommand(queryString, connection);
            command.Parameters.AddWithValue("$descripcion", producto.Descripcion);
            command.Parameters.AddWithValue("$precio",producto.Precio);
            command.ExecuteNonQuery();
            connection.Close();
        }
    }

    public void EliminarProducto(int id)
    {
                using (SqlConnection connection = new SqlConnection(CadenaDeConexion)) 
        {
            connection.Open();
            string queryString= ""
            connection.Close();
        }
        
    }

    public List<Productos> ListarProductos()
    {
        throw new NotImplementedException();
    }

    public void ModificarProducto(Productos productos, int id)
    {
        throw new NotImplementedException();
    }

    public Productos ObtenerDetalles(int id)
    {
        throw new NotImplementedException();
    }
}

