using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class MySharedData : MonoBehaviour
{
    string filename = "";

    [System.Serializable]
    public class dados
    {
        public string fase, resultado;
        public string Data_hora;

    }

    [System.Serializable]
    public class ListaFases
    {
        public dados[] Cenas;
    }

    public ListaFases myListaFases = new ListaFases();
    // Start is called before the first frame update
    void Start()
    {
        filename = Application.dataPath + "/coletateste.csv";
    }

    // Update is called once per frame
    void Update()
    {
        if (PlayerPrefs.GetString("acabou") == "true")
        {
            WriteCSV();
        }
    }


    public void WriteCSV()
    {
        if (myListaFases.Cenas.Length > 0)
        {
            TextWriter tw = new StreamWriter(filename, false);
            tw.WriteLine("Data/Hora, Fase, Resultado ");
            tw.Close();

            tw = new StreamWriter(filename, true);

            for (int i = 0; i < myListaFases.Cenas.Length; i++)
            {
                myListaFases.Cenas[i].Data_hora = PlayerPrefs.GetString("Data");
                myListaFases.Cenas[i].fase = PlayerPrefs.GetString("Fase");
                myListaFases.Cenas[i].resultado = PlayerPrefs.GetString("Concluiu");

                tw.WriteLine(myListaFases.Cenas[i].Data_hora + "," + myListaFases.Cenas[i].fase + "," + myListaFases.Cenas[i].resultado);
            }

            tw.Close();
        }
        PlayerPrefs.SetString("acabou", "false");

    }
}
