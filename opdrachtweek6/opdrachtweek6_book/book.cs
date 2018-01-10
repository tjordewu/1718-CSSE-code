public class Book
{

  private string name;
  private double price;
  private int qtyInStock;

  private Author author;

  public Book()
  {
    qtyInStock = 0;
  }

  public Book(string name, int qtyInStock, int price)
  {
    this.name = name;
    this.qtyInStock = qtyInStock;
    this.price = price;
   // this.author = author;
  }

  public string Name { get => name; set=>name = value; }
  public int Price { get => Price; set => Price = value; }
  public int QtyInStock { get => qtyInStock; set => qtyInStock = value; }

}

