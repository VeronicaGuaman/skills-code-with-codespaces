// Prueba del sistema de reserva de recursos
using System;
using Reservation;
using System.Collections.Generic;

//Añadir algunas reservas de ejemplo
var reservationServices = new ReservationServices();
reservationServices.Reserve("Sala de reuniones", new DateTime(2021, 5, 7, 9, 0, 0), new DateTime(2021, 5, 7, 10, 0, 0));
reservationServices.Reserve("Sala de reuniones", new DateTime(2021, 5, 7, 10, 0, 0), new DateTime(2021, 5, 7, 11, 0, 0));
reservationServices.Reserve("Sala de reuniones", new DateTime(2021, 5, 7, 11, 0, 0), new DateTime(2021, 5, 7, 12, 0, 0));
reservationServices.Reserve("Sala de reuniones", new DateTime(2021, 5, 7, 12, 0, 0), new DateTime(2021, 5, 7, 13, 0, 0));
reservationServices.Reserve("Sala de reuniones", new DateTime(2021, 5, 7, 13, 0, 0), new DateTime(2021, 5, 7, 14, 0, 0));

// Mostrar las reservas
var reservations = reservationServices.GetReservations();
foreach (var reservation in reservations)
{
    Console.WriteLine($"Reserva de {reservation.ResourceId} de {reservation.StartTime} a {reservation.EndTime}");
}   

