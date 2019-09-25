using System;
using System.Collections.Generic;

public class Author{
    public int Id { get; set; }
    public string NameSurname { get; set; }
    public DateTime BirthDate { get; set; }
    public List<Book> Books { get; set; }
}