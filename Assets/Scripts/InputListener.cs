using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputListener : MonoBehaviour
{
    public MaterialChanger materialChanger;
    ColorSwitch colorSwitch;
    AdvancedColorSwitch advanced;
    
private void Start() {
        //ICommand storedCommand = new ColorCommand(materialChanger);
        //colorSwitch= new ColorSwitch(storedCommand);
        advanced = new AdvancedColorSwitch();

}
    // Update is called once per frame
    void Update()
    {

        //Toggle Color red and green command
        if(Input.GetKeyDown(KeyCode.V))
        {
            //ICommand storedCommand = new ColorCommand(materialChanger);
            //colorSwitch.Switch();
        }

        //toggle random color command
        else if (Input.GetKeyDown(KeyCode.B))
        {
            ICommand colorChange = new ColorCommand(materialChanger);
            advanced.AddCommand(colorChange);

        }

        //toggle command undo
        else if (Input.GetKeyDown(KeyCode.Z))
        {
            ICommand undoColor = new ColorCommand(materialChanger);
            advanced.UndoCommand();
        }
    }
}
