using System;

namespace Laba_6
{
    class Program
    {
        static void Main(string[] args)
        {

            Novel novel1 = new Novel(title:"wewe",pageCount:2,countChapters:43,isReleased:false);
            Novel novel2 = new Novel(title: "Kolland", pageCount: 340, countChapters: 12, isReleased: true,comment:"Good");
            Poem poem1 = new Poem(title: "Jhon Saw", pageCount: 1002, genre: TypeGenreEnum.ODE, isRhyme: true, addresses: "Family");
            Storytelling storytelling1 = new Storytelling(title: "Volondemord", pageCount: 10, new DateTime(1200, 3, 2), isRealStory: false, mainCharacter: "harry");
            Storytelling storytelling2 = new Storytelling(title: "  Alone house ", pageCount: 123, new DateTime(2000, 5, 1), isRealStory: true);
            Library library = new Library(novel1, storytelling1,novel2);
            Console.WriteLine("_________________Library___________________");
            Console.WriteLine(library);
            library.AddElement(poem1);
            Console.WriteLine("_____________Add poem1 to Library___________________");
            Console.WriteLine(library);
            library.RemoveElementByIndex(2);
            Console.WriteLine("_______________Delete element by index 2 in Library___________________");
            Console.WriteLine(library);
            library.UpdateElementByIndex( storytelling2, 2);
            Console.WriteLine("_______________Update element by index 2 on storytelling2 in Library___________________");
            Console.WriteLine(library);
            novel1.OpenBook();
            Console.WriteLine("_________________novel1(Title='wewe') use method OpenBook()_________________");
            Console.WriteLine(library);
        }
    }
}
