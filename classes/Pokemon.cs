public class Pokemon{
    public virtual int Id { get; set; }
    public virtual string Nome { get; set; }
    public virtual string Tipo { get; set; }
    public virtual Trainer trainers{get; set;}
}