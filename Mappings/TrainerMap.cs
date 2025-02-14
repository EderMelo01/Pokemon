using FluentNHibernate.Mapping;

public class TrainerMap: ClassMap<Trainer>{
    public TrainerMap(){
        Id(x=> x.Id);
        Map(x=> x.nome);
        HasMany(x => x.pokemons)  
            .Cascade.All()
            .Inverse(); 
    }
}