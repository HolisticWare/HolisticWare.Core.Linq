# HolisticWare.Core.Linq

HolisticWare.Core.Linq

LINQ APIs for some uiltities (like `Even()` and `Odd()`) and for LINQ to `Memory<T>` and LINQ to `Span<T>`

NOTE: sideproject for learning LINQ.

## Thanks and 

*   John Skeet for inspiration and great tutorial:

    *   https://codeblog.jonskeet.uk/2011/02/23/reimplementing-linq-to-objects-part-45-conclusion-and-list-of-posts/

    *   https://codeblog.jonskeet.uk/2010/09/03/reimplementing-linq-to-objects-part-2-quot-where-quot/

    *   https://codeblog.jonskeet.uk/2011/01/05/reimplementing-linq-to-objects-part-26b-orderby-descending-thenby-descending/

    *   https://codeblog.jonskeet.uk/category/edulinq/
    
    *   One Hour Linq 
    
-   [Walkthrough: Creating an IQueryable Linq Provider (MSDN)](http://msdn.microsoft.com/en-us/library/bb546158.aspx)
-   [Using IQueryable with Linq](https://stackoverflow.com/questions/1578778/using-iqueryable-with-linq)
-   [Building an IQueryable provider series (The Wayward Weblog)](http://blogs.msdn.com/b/mattwar/archive/2008/11/18/linq-links.aspx)


## Utility Extension Methods

LINQ like utilites:

*   `Even()`

*   `Odd()`

##

Extension (LINQ mimic) methods for:

*   `Span<T>`
    
*   `Memory<T>`


methods:

*   `Sum()`

*   `Average()`

*   `Min()`

*   `Max()`

Used in Descriptive Statistics Package.

## Links/References

*   https://msdn.microsoft.com/en-us/library/system.linq.immutablearrayextensions(v=vs.111).aspx    

*   https://github.com/dotnet/corefx/tree/master/src/System.Linq/

*   https://github.com/dotnet/corefx/issues/15329

*   https://msdn.microsoft.com/en-us/magazine/mt814808.aspx

*   https://adamsitnik.com/Span/