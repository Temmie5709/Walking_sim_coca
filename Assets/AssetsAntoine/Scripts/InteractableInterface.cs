using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IInteractable
{
    // M�thode que toutes les classes li�s a l'inteface devront impl�menter
    void Interact(); 
    void Looking();
}