using System.ComponentModel.DataAnnotations.Schema;


namespace WebApp.Models
{
    public class Search
    {
        public string Name { get; set; }
    }

        public class User
    {
        //[DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }//Id int NOT NULL(IDENTITY)

        public string Name { get; set; }//Name VARCHAR(50) NOT NULL

        public int Age { get; set; }//Age INT NOT NULL

        public string Address { get; set; }//VARCHAR(50) NULL
    }
}
