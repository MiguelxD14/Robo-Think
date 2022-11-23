using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HUD : MonoBehaviour
{
        public Text fase;
        public Text jogador;
    // Start is called before the first frame update
    void Start()
    {
        jogador.text = PlayerPrefs.GetString("Nome").ToString();
    }

    // Update is called once per frame
    void Update()
    {
        fase.text = PlayerPrefs.GetString("Fase").ToString();
    }
}
