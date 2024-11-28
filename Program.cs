using System;

class Reservation
{
    public string RoomType { get; set; }
    public int NumberOfNights { get; set; }

    public Reservation(string roomType, int numberOfNights)
    {
        RoomType = roomType;
        NumberOfNights = numberOfNights;
    }
}

class SystemTest
{
    static void Main(string[] args)
    {
        string roomType;
        int numberOfNights;

        do
        {
            Console.Write("Room Type (S/L): ");
            roomType = Console.ReadLine().ToUpper();
        }
        while (roomType != "S" && roomType != "L");

        do
        {
            Console.Write("Number of nights (>=1): ");
            string input = Console.ReadLine();
            if (int.TryParse(input, out numberOfNights) && numberOfNights >= 1)
            {
                break;
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a number greater than or equal to 1.");
            }
        }
        while (true);

        Reservation reservation = new Reservation(roomType, numberOfNights);

        if (reservation.RoomType == "S")
        {
            Console.WriteLine($"Standard Room, {reservation.NumberOfNights} night{(reservation.NumberOfNights > 1 ? "s" : "")}");
        }
        else if (reservation.RoomType == "L")
        {
            Console.WriteLine($"Luxury Suite, {reservation.NumberOfNights} night{(reservation.NumberOfNights > 1 ? "s" : "")}");
        }
    }
}
