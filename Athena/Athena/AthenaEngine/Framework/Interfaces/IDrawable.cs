﻿using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.GamerServices;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;

namespace AthenaEngine.Framework.Interfaces
{
	/// <summary>
	/// I drawable.
	/// </summary>
    interface IDrawable
    {
		/// <summary>
		/// Draw this instance.
		/// </summary>
        void Draw();
    }
}
