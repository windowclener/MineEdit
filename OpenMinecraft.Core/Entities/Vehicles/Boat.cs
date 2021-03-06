/**
 * Copyright (c) 2010, MineEdit Contributors
 *  All rights reserved.
 *
 *  Redistribution and use in source and binary forms, with or without 
 *  modification, are permitted provided that the following conditions are met:
 *
 *    * Redistributions of source code must retain the above copyright notice, 
 *      this list of conditions and the following disclaimer.
 *    * Redistributions in binary form must reproduce the above copyright 
 *      notice, this list of conditions and the following disclaimer in the 
 *      documentation and/or other materials provided with the distribution.
 *    * Neither the name of MineEdit nor the names of its contributors 
 *      may be used to endorse or promote products derived from this software 
 *      without specific prior written permission.
 *
 * THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS "AS IS" AND 
 * ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT LIMITED TO, THE IMPLIED 
 * WARRANTIES OF MERCHANTABILITY AND FITNESS FOR A PARTICULAR PURPOSE ARE DISCLAIMED. 
 * IN NO EVENT SHALL THE COPYRIGHT HOLDER OR CONTRIBUTORS BE LIABLE FOR ANY DIRECT, 
 * INDIRECT, INCIDENTAL, SPECIAL, EXEMPLARY, OR CONSEQUENTIAL DAMAGES (INCLUDING, 
 * BUT NOT LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR SERVICES; LOSS OF USE, DATA, 
 * OR PROFITS; OR BUSINESS INTERRUPTION) HOWEVER CAUSED AND ON ANY THEORY OF 
 * LIABILITY, WHETHER IN CONTRACT, STRICT LIABILITY, OR TORT (INCLUDING NEGLIGENCE 
 * OR OTHERWISE) ARISING IN ANY WAY OUT OF THE USE OF THIS SOFTWARE, EVEN IF ADVISED 
 * OF THE POSSIBILITY OF SUCH DAMAGE.
 */

using System.Drawing;
using LibNbt.Tags;

namespace OpenMinecraft.Entities
{
/*
TAG_Compound: 8 entries
{
	TAG_String("id"): Boat
	TAG_List("Pos"): 3 entries
	{
		TAG_Double: 229.5
		TAG_Double: 63.2028440790172
		TAG_Double: 112.5
	}
	TAG_List("Motion"): 3 entries
	{
		TAG_Double: 0
		TAG_Double: -0.00214219552098296
		TAG_Double: 0
	}
	TAG_Byte("OnGround"): 0
	TAG_Short("Fire"): -1
	TAG_Float("FallDistance"): 41.62358
	TAG_Short("Air"): 300
	TAG_List("Rotation"): 2 entries
	{
		TAG_Float: 0
		TAG_Float: 0
	}
}
*/
    public class Boat:Entity
    {
		
        public Boat()
        {
        }

        public Boat(NbtCompound c)
        {
            SetBaseStuff(c);
			
        }
        public override NbtCompound ToNBT()
        {
            NbtCompound c = new NbtCompound();
            Base2NBT(ref c, GetID());
			
            return c;
        }
        public override string ToString()
        {
            return "Boat";
        }

        public override string GetID()
        {
            return "Boat";
        }

        public override Image Image
        {
            get
            {
                return new Bitmap("items/333.png"); // Boat;
            }
        }
    }
}
