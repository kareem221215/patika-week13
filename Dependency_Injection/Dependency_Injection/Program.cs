
namespace Dependency_Injection
{
    public class Program
    {
        static void Main(string[] args)
        {
            IOgretmen teacher = new Ogretmen("Kareem", "Y?lmaz"); 
            ClassRoom classroom = new ClassRoom(teacher);

            Console.WriteLine("Ö?retmen Bilgisi: " + classroom.GetTeacherInfo());
        }
    }
}
