using Godot;

namespace Fish 
{
    public static class List
    {
        public static class Salt
        {
            public static Fish GROUPER { get; } = GD.Load<Fish>("res://Assets/Resources/Fish/Saltwater/Grouper.tres");
            public static Fish BLOBFISH { get; } = GD.Load<Fish>("res://Assets/Resources/Fish/Saltwater/Blobfish.tres");
            public static Fish MARLIN { get; } = GD.Load<Fish>("res://Assets/Resources/Fish/Saltwater/Marlin.tres");
        }

        public class Brackish
        {
            public static Fish RAINBOWTROUT { get; } = GD.Load<Fish>("res://Assets/Resources/Fish/Brackish/RainbowTrout.tres");
        }

        public class Fresh
        {
            public static Fish PIKE { get; } = GD.Load<Fish>("res://Assets/Resources/Fish/Freshwater/Pike.tres");
        }
    }
}