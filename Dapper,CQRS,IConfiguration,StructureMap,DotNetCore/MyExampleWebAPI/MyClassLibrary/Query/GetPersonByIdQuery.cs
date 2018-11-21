using System;
using System.Collections.Generic;
using System.Text;

namespace MyClassLibrary.Query
{
    public class GetPersonByIdQuery
    {
        public int PersonId { get; set; }
        public GetPersonByIdQuery(int personId)
        {
            if(personId == 0)
            {
                throw new ArgumentException("Person Id must not be null.");
            }

            PersonId = personId;
        }
    }
}
