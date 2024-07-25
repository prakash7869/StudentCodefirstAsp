using Microsoft.EntityFrameworkCore;

namespace CodefirstAsp.Models
{
    public class StudentDBContext : DbContext  /*studentcontext is child  class and Db context is parent class*/
    {
        public StudentDBContext(DbContextOptions options) : base(options)  /*short cut key use "cpor" TApTAp """Constructor"""*/ /*DbContext Option instance carries configuration information such asthe connection string ,database provider to use etc*/
        {

        }

        public DbSet<Student> Students { get; set; }  /*represent database  name as "Students"*/
    }
}


//DbContext class is an integral part of entity framework
// this  is the class that we use in our application code to interact with underlying data base 
//it is the class that manage the data base connecrtion  and is used to retrieve and save data in the data base 

//An instance(object) of Dbcontext represent a session(connection) with database which can be used to quey and save instance of your entities(pointing to student model)
//to a database

//After creating model class Db context class can be used 
//example after creating student Db context we inherited property to Dbcontext
//Dbcontext coordinates with entity framework and allows  you to quey and save the data in the data base

//Used the DbSet<T> type to define one or more properties where T represent the type of an object that needs to be stored in database