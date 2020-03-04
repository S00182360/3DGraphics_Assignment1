using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefaultMonogame
{
    public abstract class Material
    {
        public virtual void Update() { }
        //Call from Draw Method
        //Pass effect that is applied to the model
        //Override and set the effect parameters
        public virtual void SetEffectParameters(Effect effect) { }
    }
}
