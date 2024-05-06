using Godot;
using System;

namespace Settings
{
    [GlobalClass]
    public partial class ControlSettings : Resource 
    {
        [ExportGroup("Camera Settings")]
        [Export(PropertyHint.Range, "0,10,0.01")] public float CameraSensitivity;
        
        [ExportGroup("Control Remaps")]
        [Export] public Godot.Collections.Dictionary<string, Key> KeyRemaps;

        public ControlSettings() : this(3, new Godot.Collections.Dictionary<string, Key>()) {}
        public ControlSettings(
            int cameraSense, 
            Godot.Collections.Dictionary<string, Key> remaps) 
        {
            KeyRemaps = remaps;
            CameraSensitivity = cameraSense;
        }

    }
}

