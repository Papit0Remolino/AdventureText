using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; //libreria para poder usar componentes de la UI
using TMPro;//libreria para poder usar los TextMeshpro

public class AdventureGameController : MonoBehaviour
{
    //con esto podemos acceder al texto de la UI
    [SerializeField] TextMeshProUGUI textComponent;
    //Referencia de tipo State (de la clase state) que usamos para poder acceder a las variables y metodos del script State
    State state;//estado que ira cambiando conforme avanza el juego
    [SerializeField] State startingState; //estado en el que inicia el juego
    void Start()
    {
        state = startingState; // el estado actual es el starting state
        textComponent.text = state.GetStateStory(); //accededemos al texto del stroeytext y metemos lo que haya del campo storytext del estado actual
    }

    // Update is called once per frame
    void Update()
    {
        ManageState();
    }

    //cambio de escena
    private void ManageState()
    {
        var nextStates = state.GetNextStates();
        for (int index = 0; index < nextStates.Length; index++)
        {
            if (Input.GetKeyDown(KeyCode.Alpha1 + index))
            {
                state = nextStates[index];
            }
        }



        //if (Input.GetKeyDown(KeyCode.Alpha1))
        //{
        //    state = nextStates[0];
        //}
        //else if (Input.GetKeyDown(KeyCode.Alpha2))
        //{
        //    state = nextStates[1];
        //}
        //else if (Input.GetKeyDown(KeyCode.Alpha3))
        //{
        //    state = nextStates[2];
        //}
        textComponent.text = state.GetStateStory();
    }
}
