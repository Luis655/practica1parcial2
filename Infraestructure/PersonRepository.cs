using System.Collections;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.IO;
using QueryApi.Domain;
using System.Threading.Tasks;

namespace QueryApi.Repositories
{
    public class PersonRepository
    {
        List<Person> _persons;

        public PersonRepository()
        {
            var fileName = "dummy.data.queries.json";
            if(File.Exists(fileName))
            {
                var json = File.ReadAllText(fileName);
                _persons = JsonSerializer.Deserialize<IEnumerable<Person>>(json).ToList();
            }
        }

        // retornar todos los valores
        public IEnumerable<Person> GetAll()
        {
            var query = _persons.Select(person => person);
            return query;
        }

        // retornar campos especificos

        public IEnumerable<object>GetFields()
        {
            var query =_persons.Select(Person=>new{
              NombreCompleto=$"{Person.FirstName} {Person.LastName}",
              AnioNacimiento= DateTime.Now.AddYears((Person.Age*-1)).Year,
              Correo = Person.Email  
            });
            return query;
        }

   

        
        // Retornar elementos que sean diferentes
           public IEnumerable<string> GetJobs()
        {
            var query =_persons.Select(Person=>Person.Job).Distinct();
            return query;

        }


        public IEnumerable<string> GetDistincJobs(string job)
        {
            
            var query =_persons.Where(P => P.Job != job ).Select(P => P.Job).Distinct();
            return query; 
            
        }
        
        // retornar valores que contengan
        public IEnumerable<Person> GetStartWith(string word)
        {
           
            var query =_persons.Where(p=>p.Job.StartsWith(word));
            return query;
        }
     
        // retornar valores entre un rango
        public IEnumerable<Person> GetRange(int minAge, int maxAge)
        {
            
            var query =_persons.Where(P=>P.Age>=minAge&&P.Age<=maxAge);
            return query;
        }



        
   
        
        // retorno cantidad de elementos
              public int GetCount(string job)
        {
          
            var query =_persons.Count(p=>p.Job==job);
            return query;

        }
        
        // Evalua si un elemento existe
             public bool GetExist(string firstName)
        {
            
            var query =_persons.Exists(Person=>Person.FirstName==firstName);
            return query;

        }

              public bool GetAny(string lastName)
        {
            
            var query =_persons.Any(Person=>Person.LastName==lastName);
            return query;

        }


        
        // retornar solo un elemento
        public Person GetByid(string job)
        {
            
            var query =_persons.FirstOrDefault(p=> p.Job ==job);
            return query;
        }
        
        // retornar solamente unos elementos
        public IEnumerable<Person> GetTake(string job)
        {
            
            var take =3;
            var query=_persons.Where(p => p.Job ==job).Take(take);
            return query;
        }
        
        // retornar elementos saltando posición

        public IEnumerable<Person> GetSkip(string job)
        {
            var skip =3;
           
            var query =_persons.Where(p => p.Job==job).Skip(skip);
            return query;
        }
        
    }
}