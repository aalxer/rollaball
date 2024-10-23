using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject player;
    // Diese Variable speichert den Abstand (Offset) zwischen der Kamera und dem Spieler
    private Vector3 offset;
    
    // Diese Methode wird einmal aufgerufen, wenn das Skript zum ersten Mal ausgeführt wird,
    // bevor die erste Update()-Methode aufgerufen wird
    void Start()
    {
        // transform bezieht sich auf das aktulle Obj, an das das Skript angehängt ist. Sie ist eine Eigenschaft,
        // die jede GameObject-Instanz in Unity hat. Sie gibt dir Zugriff auf die Transform-Komponente des GameObjects,
        // die Informationen über die Position, Rotation und Skalierung des Objekts enthält
        offset = transform.position - player.transform.position;
    }

    // wird einmal pro Frame aufgerufen, nachdem alle Update()-Methoden für andere Objekte ausgeführt wurden.
    // Das bedeutet, dass es nach der Aktualisierung aller Spielobjekte passiert
    void LateUpdate()
    {
        transform.position = player.transform.position + offset;
    }
}
