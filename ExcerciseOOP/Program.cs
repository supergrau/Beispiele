namespace ExcerciseOOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Test der Konstruktoren:
            DataStorage ds_i = new DataStorage(5);
            ds_i.SetValue(98.76); ds_i.SetValue("Beispieltext");
            DataStorage ds_d = new DataStorage(12.34d);
            DataStorage ds_s = new DataStorage("Hallo Daten");

            Console.WriteLine(ds_i.ToString());
            Console.WriteLine(ds_d.ToString());
            Console.WriteLine(ds_s.ToString());
            ds_s.AddString(" und Werte");
            Console.WriteLine(ds_s.ToString());
        }
    }


    // Übung 1:
    public class DataStorage
    {
        private int _i = 0;
        private double _d = 0.0;
        private string _s = "leer";

        // Übung 2:
        public DataStorage(int i)    => this._i = i;
        public DataStorage(double d) => this._d = d;
        public DataStorage(string s) => this._s = s;
        
        // Übung 3:
        public static int mult(int a, int b) => a * b;

        // Übung 4:
        public void SetValue(int i)    => this._i = i;
        public void SetValue(double d) => this._d = d;
        public void SetValue(string s) => this._s = s;

        // Übung 5:
        public void AddString(string s) => this._s += s;

        // Zusatz von mir für's Auslesen der Werte ;):
        public override string ToString() => $"_i = {this._i}\n_d = {this._d}\n_s = {this._s}";
        
    }

}