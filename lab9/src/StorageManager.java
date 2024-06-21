import java.io.*;

public class StorageManager {
    public static void saveObject(Serializable obj, String fileName) {
        try (ObjectOutputStream outputStream = new ObjectOutputStream(new FileOutputStream(fileName))) {
            outputStream.writeObject(obj);
        } catch (IOException e) {
            e.printStackTrace();
        }
    }

    public static Object restoreObject(String fileName) {
        try (ObjectInputStream inputStream = new ObjectInputStream(new FileInputStream(fileName))) {
            return inputStream.readObject();
        } catch (IOException | ClassNotFoundException e) {
            e.printStackTrace();
            return null;
        }
    }
}

class MainStorageManager {
    public static void main(String[] args) {
        // Сохранение объекта
        Warehouse warehouse = new Warehouse();
        StorageManager.saveObject(warehouse, "warehouseData.ser");

        // Восстановление объекта
        Warehouse restoredWarehouse = (Warehouse) StorageManager.restoreObject("warehouseData.ser");
        System.out.println("Restored Warehouse: " + restoredWarehouse);
    }
}
