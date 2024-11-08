public class PresupuestoDetalle{
    public float Precio {get;set;}
    public int Cantidad {get;set;}
    public PresupuestoDetalle(float precio, int cantidad){
        Precio=precio;
        Cantidad=cantidad;
    }
}