using System;
using Godot;

namespace Settings
{
    public partial class Settings : Node
    {
        public ControlSettings controlSettings = GD.Load<ControlSettings>("res://Assets/Resources/Settings/new_resource.tres");

        public override void _Ready() {
            Save();
            GD.Print(controlSettings.KeyRemaps);
        }

        public void Save() {
            ResourceSaver.Save(controlSettings, "res://Assets/Resources/Settings/new_resource.tres");
        }

        public void RemapKey(string action, Key newInput) {
            //Check to see if the key already has a remap value
            // if it does change the keys value
            // else add key to list
            // Update the input map
        }

        public void SetActionInputMap(string action, Key newInput) {
            //Remove old aciton bind
            //Add new action bind
        }

        public void LoadControls() {
            //Loop through remaps
            //foreach remap setactioninputmap(action, input);
        }
    }
}