namespace MyApiii.Services;

public class RpgService
{
    public static IList<Rpg> database;
    
    static RpgService()
    {
        database = new List<Rpg>();
        database.Add(new Rpg() { id = 0, name = "mipoof", meow = 100});
        database.Add(new Rpg() { id = 1, name = "多多", meow = 1});
        database.Add(new Rpg() { id = 2, name = "Quaso", meow = 2});
        database.Add(new Rpg() { id = 3, name = "布喵", meow = 3});
    }
    
    public Rpg Get(int id)
    {
        Rpg result = null;

        //result = new Rpg() { id = 0, name = "mipoof", meow = 100 };

        var db = from d in database
            where d.id == id
            select d;

        if (db.Any())
        {
            result = db.First();
        }

        return result;
    }
}