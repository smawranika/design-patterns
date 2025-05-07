//Thread-safe Singleton

public class Singleton{
    private Singleton() { }
    private static Singleton _instance;
    private static readonly Object _lock = new Object();
    public static Singleton Instance{
        get{
            if (_instance == null){
                lock (_lock) {
                    if (_instance == null) {
                        _instance = new Singleton();
                    }
                }
            }
            return _instance;
        }
    }

}