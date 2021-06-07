using System;
namespace BookStoreVS
{
    public class CategoryModel
    {
        public int id { get; set; }
        public string name { get; set; }
    }
    public class ClientModel
    {
        public int id { get; set; }
        public string name { get; set; }
        public string phone { get; set; }
        public DateTime date_joined { get; set; }
    }
    public class SupplierModel
    {
        public int id { get; set; }
        public string name { get; set; }
        public string mail { get; set; }
        public string phone { get; set; }

    }
    public class PublisherModel
    {
        public int id { get; set; }
        public string name { get; set; }
        public string email { get; set; }
        public string address { get; set; }
    }
    public class EmploteeModel
    {
        public int id { get; set; }
        public string name { get; set; }
        public string mail { get; set; }
        public string phone { get; set; }
        public string national_Id { get; set; }
        public string password { get; set; }
        public string isAdmin { get; set; }

    }
    public class BookModel
    {
        public int id { get; set; }
        public string name { get; set; }
        public string author { get; set; }
        public int amount_instock { get; set; }
        public int price { get; set; }
        public string description { get; set; }
        public string publisher { get; set; }
        public int category_id { get; set; }

    }
    public class SaleModel
    {
        public int id { get; set; }
        public DateTime op_time { get; set; }
        public int quantity { get; set; }
        public string client { get; set; }
        public string book_name { get; set; }
        public int price { get; set; }
        public int book_id { get; set; }

    }
    class RequestModel
    {
        public int id { get; set; }
        public DateTime op_time { get; set; }
        public int quantity { get; set; }
        public string client { get; set; }
        public string book { get; set; }
    }
}
