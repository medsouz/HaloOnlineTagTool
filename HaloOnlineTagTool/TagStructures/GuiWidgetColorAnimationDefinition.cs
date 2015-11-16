using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HaloOnlineTagTool.Common;
using HaloOnlineTagTool.Resources;
using HaloOnlineTagTool.Serialization;

namespace HaloOnlineTagTool.TagStructures
{
	[TagStructure(Class = "wclr", Size = 0x24)]
	public class GuiWidgetColorAnimationDefinition
	{
		public uint AnimationFlags;
		public List<AnimationDefinitionBlock> AnimationDefinition;
		public byte[] Data;

		[TagStructure(Size = 0x20)]
		public class AnimationDefinitionBlock
		{
			public uint Frame;
			public float ColorA;
			public float ColorR;
			public float ColorG;
			public float ColorB;
			public uint Unknown;
			public uint Unknown2;
			public uint Unknown3;
		}
	}
}
