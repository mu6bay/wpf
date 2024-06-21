import java.io.Serializable;
import java.util.HashMap;
import java.util.List;
import java.util.Map;

public class Warehouse implements Serializable {
    private Map<String, List<Product1>> products;
    private List<Customer> customers;
    private List<Supplier> suppliers;

    public Warehouse() {
        this.products = new HashMap<>();
    }

    public static void main(String[] args) {
        Warehouse warehouse = new Warehouse();

        Product product1 = new Product("Ноутбук", "Электроника", 100000.0);
        Product product2 = new Product("Стул", "Фурнитура", 5000.0);

        warehouse.addProduct(product1.getCategory(), product1);
        warehouse.addProduct(product2.getCategory(), product2);

        System.out.println("Доступные электронные продукты:" + warehouse.getAvailableProducts("Электроника"));
        System.out.println("Общее количество мебельных изделий: " + warehouse.getProductCount("Фупнитура"));

        Customer customer = new Customer("Алиса");
        warehouse.sellProduct("Электроника", "Ноутбук", customer);
        System.out.println("Клиент купил продукты:" + customer.getBoughtProducts());
    }

    public void addProduct(String category, Product1 product) {
        if (!products.containsKey(category)) {
            products.put(category, List.of(product));
        } else {
            products.get(category).add(product);
        }
    }

    public void sellProduct(String category, String productName, Customer customer) {
        if (products.containsKey(category)) {
            List<Product1> productList = products.get(category);
            productList.stream()
                    .filter(product -> product.getName().equals(productName))
                    .findFirst()
                    .ifPresent(product -> {
                        productList.remove(product);
                        customer.buyProduct(product);
                    });
        }
    }

    public List<Product1> getAvailableProducts(String category) {
        return products.getOrDefault(category, List.of());
    }

    public int getProductCount(String category) {
        return products.getOrDefault(category, List.of()).size();
    }

    public Map<String, List<Product1>> groupProductsByCategory() {
        return products;
    }

    public List<Supplier> getSuppliers() {
        return suppliers;
    }

    public List<Customer> getCustomers() {
        return customers;
    }

    public void addProduct(String category, Product product1) {

    }
}

class Product implements Serializable {
    private String name;
    private String category;
    private double price;

    public Product(String name, String category, double price) {
        this.name = name;
        this.category = category;
        this.price = price;
    }

    public String getName() {
        return name;
    }

    public String getCategory() {
        return category;
    }

    public double getPrice() {
        return price;
    }
}

class Customer implements Serializable {
    private String name;
    private List<Product1> boughtProducts;

    public Customer(String name) {
        this.name = name;
    }

    public void buyProduct(Product1 product) {
        boughtProducts.add(product);
    }

    public String getBoughtProducts() {
        return null;
    }

}

class Supplier implements Serializable {
    private String name;
    // Другие поля и методы
}
