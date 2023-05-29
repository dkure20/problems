//შექმენით კლასი Article, რომელიც შეიცავს შემდეგ დახურულ ველებს
//* ნივთის სახელი
//* იმ მაღაზიის სახელი, რომელშიც იყიდება ნივთის
//* ღირებულება ლარებში
//შექმენით კლასი Store, რომელიც შეიცავს დახურულ Article ტიპის ელემენტების მასივს
//და შეასრულეთ შემდეგი
//* Store კლასში უზრუნველყავით შესაძლებლობა ელემენტის ამოღების ინდექსის მიხედვით (გამოიყენეთ ინდექსატორი, ინდექსი იყოს ნივთის სახელი)
//*ეკრანზე იმ ნივთის შესახებ ინფორმაციის გამოტანა, რომლის სახელიც იყო შეყვანილი კლავიატურიდან, თუ მსგავსი ნივთი არ არსებობს, გამოიტანეთ შესაბამისი შეტყობინება
//დაწერეთ პროგრამა, რომელიც გამოიტანს ინფორმაცის ნივთის შესახებ
//P.S მოახდინეთ ინდექსატორის ვალიდაცია
namespace problemOne
{
    public class Article
    {
        private string itemName { get; set; }
        private string storeName { get; set; }
        private double itemPrice { get; set; }
        public string getItemName()
        {
            return itemName;
        }
        public string getStoreName()
        {
            return storeName;
        }
        public double getItemPrice()
        {
            return itemPrice;
        }
        public void setItemName(string itemName)
        {
            this.itemName = itemName;
        }
        public void setStoreName(string storeName)
        {
            this.storeName = storeName;
        }
        public void setItemPrice(double itemPrice)
        {
            this.itemPrice = itemPrice;
        }
    }
    public class Store
    {
        private List<Article> articles { get; set; }

        public string this[string item]
        {
            get
            {
                foreach(Article article in articles)
                {
                    if (article.getItemName() == item)
                    {
                        return "Item" + article.getItemName() + "Store" + article.getStoreName() + "Price" + article.getStoreName;
                    }
                }
                return "Item is not in store";
            }
        }
    }
}

