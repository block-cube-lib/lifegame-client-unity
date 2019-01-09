using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cell : MonoBehaviour
{
    [SerializeField]
    UnityEngine.UI.Image image = null;

    public Lifegame.Cell State { get; private set; } = Lifegame.Cell.Dead;

    public void SetState(Lifegame.Cell cellState)
    {
        this.State = cellState;
        var color = this.State == Lifegame.Cell.Alive ? Color.white : Color.black;
        this.image.color = color;
    }
}
