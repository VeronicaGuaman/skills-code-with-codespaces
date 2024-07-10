public class Reservation
{
    // Properties
    public int ReservationId { get; set; }
    public string CustomerName { get; set; }
    public DateTime ReservationDate { get; set; }
    public int NumberOfGuests { get; set; }
    public int Age { get; set; }

    // Constructor
    public Reservation(int reservationId, string customerName, DateTime reservationDate, int numberOfGuests, int age)
    {
        ReservationId = reservationId;
        CustomerName = customerName;
        ReservationDate = reservationDate;
        NumberOfGuests = numberOfGuests;
        Age = age;
    }

    // Methods
    public void ConfirmReservation()
    {
        // Add logic to confirm the reservation
    }

    public void CancelReservation()
    {
        // Add logic to cancel the reservation
    }
}