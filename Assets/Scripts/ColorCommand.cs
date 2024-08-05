//CONCRETE COMMAND
using UnityEngine;

public class ColorCommand : ICommand
{
    MaterialChanger materialChanger;
    Color previousColor;


    public ColorCommand(MaterialChanger _materialChanger)
    {
        materialChanger = _materialChanger;
        previousColor = _materialChanger.GetComponent<Renderer>().material.color;
    }

    public void Execute()
    {
        materialChanger.SetRandomColor();
    }

    public void Undo()
    {
        materialChanger.GetComponent<Renderer>().material.color = previousColor;
    }
}
