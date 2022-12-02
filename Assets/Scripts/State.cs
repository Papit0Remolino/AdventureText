using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// es un atributo de la clase que nos permite crear scriptable object de tipo state desde la ventana project
[CreateAssetMenu(menuName = "State")]
//esta clase deriva ahora de los scriptableobjects no de monobehaviour
public class State : ScriptableObject
{
    //TextArea atributo que permite crear un cuadro de texto de numero de lineas escalable y scrolleable
    //serializefield permite que una variable o referencia siga siendo privada pero accesible desde el editor
    [TextArea(14, 10)] [SerializeField] string storyText;
    //Array de estados a los que podemos ir desde el estado actual
    [SerializeField] State[] nextStates;

    //método que nos devuelve el  contenido de la caja del scriptableobject
    public string GetStateStory()
    {
        return storyText;
    }
    public State[] GetNextStates()
    {
        return nextStates;
    }


}
