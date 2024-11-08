public interface IProductoRepository {
    void CrearNuevo(Productos producto);
    void ModificarProducto(Productos productos,int id);
    List<Productos> ListarProductos();
    Productos ObtenerDetalles(int id);
    void EliminarProducto(int id);
    }

public class ProductoRepository : IProductoRepository
{
    public void CrearNuevo(Productos producto)
    {
        throw new NotImplementedException();
    }

    public void EliminarProducto(int id)
    {
        throw new NotImplementedException();
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

