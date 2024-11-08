public class Presupuestos{
    private int idPresupuesto;
    private string nombreDestinatario;
    private string fechaCreacion;
    private List<PresupuestoDetalle> detalle;


    public Presupuestos(int idPresupuesto, string nombreDestinatario){
        this.idPresupuesto=idPresupuesto;
        this.nombreDestinatario=nombreDestinatario;
        this.detalle= new List<PresupuestoDetalle>();
    }

    public int IdPresupuesto{ get => idPresupuesto; set => idPresupuesto = value; }
    public string NombreDestinatario { get => nombreDestinatario; set => nombreDestinatario = value; }
    public string FechaCreacion { get => fechaCreacion; set => fechaCreacion = value; }
    public List<PresupuestoDetalle> Detalle { get => detalle; set => detalle = value; }

    public float Monto Presupuesto()
    {
        float total = 0;
        foreach (var item in detalle)
        {
            total += item.Precio * item.Cantidad; // Asumiendo que PresupuestoDetalle tiene Precio y Cantidad
        }
        return total;
    }

    // Método para calcular el monto total del presupuesto incluyendo IVA (suponiendo un IVA del 21%)
    public float MontoPresupuestoConIva()
    {
        return MontoPresupuesto() * 1.21; // Ajusta el porcentaje según sea necesario
    }

    // Método para contar la cantidad total de productos en el presupuesto
    public int CantidadProductos()
    {
        int totalCantidad = 0;
        foreach (var item in detalle)
        {
            totalCantidad += item.Cantidad; // Asumiendo que PresupuestoDetalle tiene Cantidad
        }
        return totalCantidad;
    }
}