// See https://aka.ms/new-console-template for more information


using Parking.Entities.Service;

try {




    string path = @"C:\temp\placas\placacarros.txt";
    using (StreamReader sr = new StreamReader(path)) {
            string[] placas = File.ReadAllLines(path);

        Estacionamento estacionamento = new Estacionamento();

    }
}catch (FormatException e) {
    Console.WriteLine($"An format error ocurrer: {e.Message}");
}