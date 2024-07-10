// Clase para manejar la lógica principal de la reserva de recursos
// Date: 2021-05-07
using System.Collections.Generic;
using System;
using Reservation;

public class ReservationServices
{
    private List<Reservation> reservations = new List<Reservation>();

    public void ConfirmReservation(Reservation reservation)
    {
        // Add logic to confirm the reservation
    }

    public void CancelReservation(Reservation reservation)
    {
        // Add logic to cancel the reservation
    }
// Método para reservar un recurso, verificando conflictos
    public bool Reserve(string resourceId, DateTime startTime, DateTime endTime)
    {
        // Verificar si hay conflictos con las reservas existentes
        foreach (var reservation in reservations)
        {
            if (reservation.ResourceId == resourceId &&
                (startTime < reservation.EndTime && endTime > reservation.StartTime))
            {
                // Conflicto encontrado
                return false;
            }
        }
        // Añadir nueva reserva
        reservations.Add(new Reservation(resourceId, startTime, endTime));
        return true;
    }
    // método para listar las reservas
    public List<Reservation> GetReservations()
    {
        return reservations;

    }
}
