import java.io.Serializable;

public class Product1 implements Serializable {
    private String name;
    private String category;
    private double price;

    public Product1(String name, String category, double price) {
        this.name = name;
        this.category = category;
        this.price = price;
    }

    public Product1() {
        // Конструктор без параметров
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
    public static void main(String[] args) {
        // Создание объекта Product1
        Product1 product = new Product1("Телефон", "Электроника", 49999.99);

        // Сохранение объекта в файл
        StorageManager.saveObject(product, "productData.ser");

        // Восстановление объекта из файла
        Product1 restoredProduct = (Product1) StorageManager.restoreObject("productData.ser");

        // Вывод данных о восстановленном объекте
        System.out.println("Восстановленные сведения о продукте:");
        System.out.println("Name: " + restoredProduct.getName());
        System.out.println("Category: " + restoredProduct.getCategory());
        System.out.println("Price: " + restoredProduct.getPrice());
    }
}
