public interface IPresupuestoRepository
{
    void CrearNuevoPresupuesto(Presupuestos presupuestos);
    List<PresupuestoDetalle> ListarPresupuesto();
    Presupuestos ObtenerDetallePresupuesto(int id);
    void AgregarProducto(int id);
    void EliminarPresupuesto(int id);
}

public class PresupuestoRepository : PresupuestoRepository{

    public void CrearNuevoPresupuesto(Presupuestos presupuestos)
    {
        throw new NotImplementedException();
    }

    public List<PresupuestoDetalle> ListarPresupuesto()
    {
        throw new NotImplementedException();
    }

    public Presupuestos ObtenerDetallePresupuesto(int id)
    {
        throw new NotImplementedException();
    }

    public void AgregarProducto(int id)
    {
        throw new NotImplementedException();
    }

    public void EliminarPresupuesto(int id)
    {
        throw new NotImplementedException();
    }
    
}
