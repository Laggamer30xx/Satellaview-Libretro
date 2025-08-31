using System.Collections.Generic;
using System.Drawing;

namespace Satellaview_server
{
    public class EventPlazaAnimationController
    {
        public List<BuildingAnimation> BuildingAnimations { get; set; }
        public List<Tag> Tags { get; set; }
        
        public EventPlazaAnimationController()
        {
            BuildingAnimations = new List<BuildingAnimation>();
            Tags = new List<Tag>();
        }

        public class BuildingAnimation
        {
            public int BuildingId { get; set; }
            public List<AnimationFrame> Frames { get; set; }
            public bool Loop { get; set; }
            
            public BuildingAnimation()
            {
                Frames = new List<AnimationFrame>();
            }
        }

        public class AnimationFrame
        {
            public int Duration { get; set; }
            public Point Position { get; set; }
            public Size Size { get; set; }
        }

        public class Tag
        {
            public string Name { get; set; }
            public Rectangle Area { get; set; }
            public Color DisplayColor { get; set; }
        }
    }
}
