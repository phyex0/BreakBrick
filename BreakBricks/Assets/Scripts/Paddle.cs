using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{
    [SerializeField] float ekranGenisligiUnitCinsinden =16f;  // Start is called before the first frame update
   
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float farePozUnitCinsinden = Input.mousePosition.x / Screen.width * ekranGenisligiUnitCinsinden;
        Vector2 pedalPozisyonu = new Vector2(farePozUnitCinsinden, transform.position.y);
        pedalPozisyonu.x  = Mathf.Clamp(pedalPozisyonu.x, (float)-7.91, (float)7.86);
        transform.position = pedalPozisyonu;
    }
}
