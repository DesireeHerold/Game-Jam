using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSelection : MonoBehaviour
{
    public void selectScene()
    {
        switch (this.gameObject.name)
        {
            case "StationszimmerKnopf":
                SceneManager.LoadScene("Stationszimmer");
                break;
            case "ArztzimmerKnopf":
                SceneManager.LoadScene("Arztzimmer");
                break;
            case "WarteraumKnopf":
                SceneManager.LoadScene("Warteraum");
                break;
            case "BeratungsraumKnopf":
                SceneManager.LoadScene("Beratungsraum");
                break;
            case "PatientenzimmerKnopf":
                SceneManager.LoadScene("Patientenzimmer");
                break;
            case "TrainingsraumKnopf":
                SceneManager.LoadScene("Trainingsraum");
                break;
        }
    }
}

