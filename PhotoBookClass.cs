// Create a C# program to manage a photo book using object-oriented programming.

// To start, create a class called PhotoBook with a private attribute numPages of type int.
//  It must also have a public method GetNumberPages that will return the number of photo book pages.

// The default constructor will create an album with 16 pages. 
// There will be an additional constructor, 
// with which we can specify the number of pages we want in the album.

// There is also a SuperPhotoBook class whose constructor will create an album with 64 pages.

// Finally create a PhotoBookTest class to perform the following actions:

// Create a default photo book and show the number of pages
// Create a photo book with 24 pages and show the number of pages
// Create a large photo book and show the number of pages
// Input
 
// Output
// 16
// 24
// 64

using System;

public class PhotoBook
{
    // To start, create a class called PhotoBook with a private attribute numPages of type int.
    protected int numPages ;
    // The default constructor will create an album with 16 pages. 
    public PhotoBook()
    {
        numPages =16;
    }

    // There will be an additional constructor, 
// with which we can specify the number of pages we want in the album.
    public PhotoBook(int numPages){
        
        this.numPages = numPages;
    }
//  It must also have a public method GetNumberPages that will return the number of photo book pages.
    public int GettNumberPages()
    {
        return numPages;

    }
}
// There is also a SuperPhotoBook class whose constructor will create an album with 64 pages.
public class SuperPhotoBook : PhotoBook{
    public SuperPhotoBook ()
    {
         numPages =64;
    }
}
// Finally create a PhotoBookTest class to perform the following actions:
public class PhotoBookTest
{
        public static void Main (string [] args)
        {  // Create a void photo book and show the number of pages
                PhotoBook myAlbum1 = new PhotoBook();
                Console.WriteLine(myAlbum1.GetNumberPages());

            // Create a photo book with 24 pages and show the number of pages
                PhotoBook myAlbum2 = new PhotoBook(24);
                Console.WriteLine(myAlbum1.GetNumberPages());

            // Create a large photo book and show the number of pages
                SuperPhotoBook myAlbum3 = new SuperPhotoBook(24);
                Console.WriteLine(myAlbum3.GetNumberPages());
        }
    
}


