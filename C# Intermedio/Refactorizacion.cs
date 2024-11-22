namespace Refactoring_C_;
public class Asiento
{
    public int AsientoID { get; set; }
    public int BusId { get; set; }
    public int NumeroPiso { get; set; }
    public int NumeroAsiento { get; set; }
    public DateTime FechaCreacion { get; set; }
}
public interface IRepository<T>
{
    void Agregar(T entity);
    void Actualizar(T entity);
    void Remover(T entity);
    List<T> TraerTodos();
    T ObtenerPorId(int id);
}

public class Repository<T> : IRepository<T>
{
    private List<T> _entities = new List<T>();

    public void Agregar(T entity)
    {
        _entities.Add(entity);
    }

    public void Actualizar(T entity)
    {
     
        int index = _entities.FindIndex(e => e.Equals(entity));
        if (index >= 0)
        {
            _entities[index] = entity;
        }
    }

    public void Remover(T entity)
    {
        _entities.Remove(entity);
    }

    public List<T> TraerTodos()
    {
        return _entities;
    }

    public T ObtenerPorId(int id)
    {
 
        return _entities.FirstOrDefault(e => (e as dynamic).AsientoID == id);
    }
}

public class AsientoRepository : Repository<Asiento>
{
    
}

class Program
{
    static void Main(string[] args)
    {
       var asientoRepo = new AsientoRepository();

       
        var asiento1 = new Asiento
        {
            AsientoID = 1,
            BusId = 101,
            NumeroPiso = 1,
            NumeroAsiento = 10,
            FechaCreacion = DateTime.Now
        };

        
        asientoRepo.Agregar(asiento1);

       
        var todosAsientos = asientoRepo.TraerTodos();
        Console.WriteLine("Asientos:");
        foreach (var asiento in todosAsientos)
        {
            Console.WriteLine($"ID: {asiento.AsientoID}, Bus ID: {asiento.BusId}");
        }

        
        var asientoObtenido = asientoRepo.ObtenerPorId(1);
        Console.WriteLine($"Asiento obtenido por ID: {asientoObtenido.AsientoID}, Piso: {asientoObtenido.NumeroPiso}");

      
        asiento1.NumeroAsiento = 12;
        asientoRepo.Actualizar(asiento1);

     
        asientoRepo.Remover(asiento1);

      
        var asientosRestantes = asientoRepo.TraerTodos();
        Console.WriteLine("Asientos restantes después de eliminar:");
        foreach (var asiento in asientosRestantes)
        {
            Console.WriteLine($"ID: {asiento.AsientoID}, Bus ID: {asiento.BusId}");
        }
    }
}
