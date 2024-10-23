
using UnityEngine;
using UnityEngine.InputSystem;

// MonoBehaviour: Eine Basisklasse in Unity, von der alle Skripte abgeleitet werden, die in der Unity-Umgebung
// funktionieren. Durch die Vererbung von MonoBehaviour hat die Klasse Zugriff auf Unity-spezifische Funktionen
public class PlayerController : MonoBehaviour
{
    public float speed = 0;
    private Rigidbody rb;
    private float movementX;
    private float movementY;
    
    // Diese Methode wird einmal aufgerufen, wenn das Skript zum ersten Mal aktiv wird (also wenn das Spiel beginnt)
    void Start()
    {
        // Hier wird das Rigidbody-Komponentenobjekt des aktuellen GameObjects (z.B. des Spielers)
        // abgerufen und in der Variable rb gespeichert.
        rb = GetComponent<Rigidbody>();
    }

    // Diese Methode wird aufgerufen, wenn eine Eingabe (wie Tastendruck oder Joystickbewegung) registriert wird
    // movmenetValue: enthält Informationen über die aktuelle Bewegung
    void OnMove(InputValue movementValue)
    {
        // Hier wird der aktuelle Eingabewert als 2D-Vektor (X und Y) abgerufen
        Vector2 movementVector = movementValue.Get<Vector2>();
        movementX = movementVector.x;
        movementY = movementVector.y;
    }

    // Diese Methode wird in regelmäßigen Abständen aufgerufen und eignet sich besonders für Physikberechnungen.
    // Sie wird vor der Physikberechnung aufgerufen, was bedeutet, dass alle Bewegungen, die hier vorgenommen werden,
    // direkt die Physik des Spiels beeinflussen
    private void FixedUpdate()
    {
        Vector3 movement = new Vector3(movementX, 0.0f, movementY);
        // Hier wird eine Kraft auf das Rigidbody des Spielers angewendet, um die Bewegung zu steuern.
        // movement * speed multipliziert die Bewegung mit der Geschwindigkeit, um die tatsächliche Kraft zu bestimmen
        rb.AddForce(movement * speed);
    }
}