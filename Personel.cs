public static class Personel{

    // Static Ctor!!!!


    // Static olan bir ctor asla overloading yapılamaz, yani kesinlikle parametre alamaz!!!
    static Personel(){

        // This keyword'u, static sınıflar için kullanılmaz!!!

        //Static ctorlar sadece bir kez çalışırlar!!!! 
        // bir kez çalışıp, daha sonraki sınıfın kullanımlarında asla çalışmazlar!!!!



        // Static ctor içeirisinde maas değişkeni belleye çıksın diye değer verildi!!!

        Random rnd = new Random();
        Random rnd1 = new Random();

        Maas=100;

    }
    public static decimal Maas{ get; set; }
}