using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using RecRoom.DataLayer;
using RecRoom.Foundation.Collections;
using RecRoom.Foundation.Mathematics;
using RecRoom.Foundation.Transforms;
using RecRoom.RendererV1.DataProviders;
using Unity.Collections;
using Unity.Mathematics;
using Unity.Properties;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
namespace RecRoom.RendererV1
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	public enum IgnoreEffectType
	{
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		Ghost = 0,
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		GhostSkinned = 50,
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		ShadowsOnly = 100,
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		ShadowsOnlySkinned = 150,
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		Hide = 200
	}
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public enum OutlineEffectType
	{
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		Hover,
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		Tutorial,
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		Teleport,
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		Menu,
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		CircuitNode,
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		Warning,
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		ExtrusionHover,
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		CornerMove,
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		CornerMoveWarning,
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		Configure,
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		NearbyContextual,
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		HoverXRay,
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		ContainerHover,
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		PivotHover,
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		DebugLocate,
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		FrozenHover,
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		ManipulateCollision
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public enum PrimitiveShapeMeshType
	{
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		Invalid = -1,
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		RR_Box,
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		RR_Sphere,
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		RR_Cylinder,
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		RR_Wedge,
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		RR_Pyramid,
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		RR_HalfSphere,
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		RR_Cone,
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		RR_Pipe,
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		RR_Donut,
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		RR_HalfPipe,
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		RR_Diamond,
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		ADVANCED_Mound,
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		LEGACY_Box,
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		ADVANCED_Cube,
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		ADVANCED_Sphere,
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		ADVANCED_Cylinder,
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		ADVANCED_Cone,
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		ADVANCED_Pyramid,
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		ADVANCED_Octagon,
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		ADVANCED_Triangle,
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		ADVANCED_Hexagon,
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		ADVANCED_QuarterPipe,
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		ADVANCED_Pentagon,
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		ADVANCED_Dodecahedron,
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		ADVANCED_Trihedron,
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		ADVANCED_Octahedron,
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		RR_QuarterCylinder,
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		RR_Pentagon,
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		RR_QuarterSphere,
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		ADVANCED_Wedge,
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		RR_Hexagon,
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		RR_Octagon,
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		RR_Triangle,
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		Count
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public enum RootFlags
	{
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		Static,
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		Dynamic,
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		Selected,
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		SkinnedBone
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public enum SelectionEffectType
	{
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		Default,
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		Circuit,
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		Shape,
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		CornerMove,
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		Container,
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		Pivot
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public enum ShapeColor
	{
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		INVALID = -1,
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		RRO_MIN_VALUE = 0,
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		RED = 0,
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		ORANGE = 1,
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		YELLOW = 2,
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		LIGHT_GREEN = 3,
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		BLUE = 4,
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		LIGHT_BLUE = 5,
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		TEAL = 6,
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		GREEN = 7,
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		PURPLE = 8,
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		LIGHT_PINK = 9,
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		PINK = 10,
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		BROWN = 11,
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		TAN = 12,
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		WHITE = 13,
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		GREY = 14,
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		DARK_GREY = 15,
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		DARK_BROWN = 16,
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		LIGHT_BROWN = 17,
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		LIGHT_GREY = 18,
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		BLACK = 19,
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		DARK_RED = 20,
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		DARK_ORANGE = 21,
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		DARK_YELLOW = 22,
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		DARK_GREEN = 23,
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		DARK_TEAL = 24,
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		DARK_BLUE = 25,
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		DARK_PURPLE = 26,
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		DARK_PINK = 27,
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		LIGHT_RED = 28,
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		LIGHT_ORANGE = 29,
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		LIGHT_YELLOW = 30,
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		CYAN = 31,
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		LIGHT_PURPLE = 32,
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		UNUSED_SEE_COMMENT = 33,
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		NEW_COLOR_1 = 34,
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		NEW_COLOR_2 = 35,
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		NEW_COLOR_3 = 36,
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		NEW_COLOR_4 = 37,
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		NEW_COLOR_5 = 38,
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		NEW_COLOR_6 = 39,
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		NEW_COLOR_7 = 40,
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		NEW_COLOR_8 = 41,
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		NEW_COLOR_9 = 42,
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		NEW_COLOR_10 = 43,
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		NEW_COLOR_11 = 44,
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		NEW_COLOR_12 = 45,
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		NEW_COLOR_13 = 46,
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		NEW_COLOR_14 = 47,
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		NEW_COLOR_15 = 48,
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		NEW_COLOR_16 = 49,
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		NEW_COLOR_17 = 50,
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		NEW_COLOR_18 = 51,
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		NEW_COLOR_19 = 52,
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		NEW_COLOR_20 = 53,
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		NEW_COLOR_21 = 54,
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		NEW_COLOR_22 = 55,
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		NEW_COLOR_23 = 56,
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		NEW_COLOR_24 = 57,
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		NEW_COLOR_25 = 58,
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		NEW_COLOR_26 = 59,
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		NEW_COLOR_27 = 60,
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		RRO_COLORS_COUNT = 61,
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		RRO_MAX_VALUE = 60,
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		GENERATED_MIN_VALUE = 1000,
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		GENERATED_COLORS_BITS_PER_CHANNEL = 8,
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		GENERATED_COLORS_COUNT = 16777216,
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		GENERATED_MAX_VALUE = 16778215,
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		LEGACY_GENERATED_COLORS_BITS_PER_CHANNEL = 4,
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		LEGACY_GENERATED_COLORS_COUNT = 4096,
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		GENERATED_TO_GPU_OFFSET = -939,
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		MIN_VALUE = 0,
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		MAX_VALUE = 16778215,
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		DEFAULT = 0
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public static class KLMOOVZNXRF
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x86C8520", Offset = "0x86C6B20", VA = "0x1886C8520")]
		public static bool CZOPLCMDPAQ(this ShapeColor a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x86C8510", Offset = "0x86C6B10", VA = "0x1886C8510")]
		public static bool CCIEXMECXBW(this ShapeColor a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x86C8540", Offset = "0x86C6B40", VA = "0x1886C8540")]
		public static bool ZWHTNLTTGTH(this ShapeColor a)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public enum ShapeMaterial
	{
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		INVALID = -1,
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		CARDBOARD = 0,
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		NEON = 1,
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		BRICK = 2,
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		CARPET = 3,
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		DIRT = 4,
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		GRASS = 5,
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		METAL_REFLECTIVE = 6,
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		CONCRETE = 7,
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		LINOLEUM = 8,
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		PLASTER = 9,
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		WOOD_LOGS = 10,
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		WOOD_BOARDS = 11,
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		WOOD_GRAIN = 12,
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		WOOD_FLOOR = 13,
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		SAND = 14,
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		GLOSSY_PLASTIC = 15,
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		CLOTH = 16,
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		RUBBER_FLOOR = 17,
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		METAL_FLOOR_TREAD = 18,
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		PAINTED_BRICK = 19,
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		CRASHPAD = 20,
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		PAINTED_WOOD = 21,
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		GRIP_TAPE = 22,
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		GALVANIZED_METAL = 23,
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		PARTICLE_BOARD = 24,
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		CHECKERED_FLOOR = 25,
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		SPARKLY_VINYL = 26,
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		GRAVEL = 27,
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		ROCK = 28,
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		WORN_WOOD = 29,
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		PLACEHOLDER_17 = 30,
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		PLACEHOLDER_18 = 31,
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		MIN_VALUE = 0,
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		MAX_VALUE = 31,
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		COUNT = 32,
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		DEFAULT = 0
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public struct RootHandle : FKATZDKRTHL, IEquatable<RootHandle>
	{
		[Cpp2IlInjected.Token(Token = "0x17000001")]
		[CreateProperty]
		public int Index
		{
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0xD991D0", Offset = "0xD977D0", VA = "0x180D991D0", Slot = "4")]
			[CompilerGenerated]
			readonly get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x15F4A80", Offset = "0x15F3080", VA = "0x1815F4A80", Slot = "5")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		[CreateProperty]
		public int Version
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x303B5B0", Offset = "0x3039BB0", VA = "0x18303B5B0", Slot = "6")]
			[CompilerGenerated]
			readonly get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x303B5C0", Offset = "0x3039BC0", VA = "0x18303B5C0", Slot = "7")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public bool HFYUEIOIRYO
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x86C9990", Offset = "0x86C7F90", VA = "0x1886C9990")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x146D670", Offset = "0x146BC70", VA = "0x18146D670", Slot = "8")]
		public bool Equals(RootHandle other)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x84ADC60", Offset = "0x84AC260", VA = "0x1884ADC60")]
		public static bool HCJGUXGANNO(RootHandle a, RootHandle b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x86C9870", Offset = "0x86C7E70", VA = "0x1886C9870", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0xD991D0", Offset = "0xD977D0", VA = "0x180D991D0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x86C9910", Offset = "0x86C7F10", VA = "0x1886C9910", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public struct ShapeHandle : FKATZDKRTHL, IEquatable<ShapeHandle>
	{
		[Cpp2IlInjected.Token(Token = "0x17000004")]
		[CreateProperty]
		public int Index
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0xD991D0", Offset = "0xD977D0", VA = "0x180D991D0", Slot = "4")]
			[CompilerGenerated]
			readonly get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x15F4A80", Offset = "0x15F3080", VA = "0x1815F4A80", Slot = "5")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		[CreateProperty]
		public int Version
		{
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x303B5B0", Offset = "0x3039BB0", VA = "0x18303B5B0", Slot = "6")]
			[CompilerGenerated]
			readonly get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x303B5C0", Offset = "0x3039BC0", VA = "0x18303B5C0", Slot = "7")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public bool HFYUEIOIRYO
		{
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x86C9AF0", Offset = "0x86C80F0", VA = "0x1886C9AF0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x146D670", Offset = "0x146BC70", VA = "0x18146D670", Slot = "8")]
		public bool Equals(ShapeHandle other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x86C99D0", Offset = "0x86C7FD0", VA = "0x1886C99D0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0xD991D0", Offset = "0xD977D0", VA = "0x180D991D0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x86C9A70", Offset = "0x86C8070", VA = "0x1886C9A70", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public struct SkinnedCostumeHandle : FKATZDKRTHL, IEquatable<SkinnedCostumeHandle>
	{
		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public int Index
		{
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0xD991D0", Offset = "0xD977D0", VA = "0x180D991D0", Slot = "4")]
			[CompilerGenerated]
			readonly get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x15F4A80", Offset = "0x15F3080", VA = "0x1815F4A80", Slot = "5")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public int Version
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x303B5B0", Offset = "0x3039BB0", VA = "0x18303B5B0", Slot = "6")]
			[CompilerGenerated]
			readonly get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x303B5C0", Offset = "0x3039BC0", VA = "0x18303B5C0", Slot = "7")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public bool HFYUEIOIRYO
		{
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x86C9BD0", Offset = "0x86C81D0", VA = "0x1886C9BD0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x146D670", Offset = "0x146BC70", VA = "0x18146D670", Slot = "8")]
		public bool Equals(SkinnedCostumeHandle other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x86C9B30", Offset = "0x86C8130", VA = "0x1886C9B30", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0xD991D0", Offset = "0xD977D0", VA = "0x180D991D0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public interface YAAJDYCRQCQ : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void BOOVXKXAWZI(RootHandle a, OutlineEffectType b);

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void BOOVXKXAWZI(ShapeHandle a, OutlineEffectType b);

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void GHBXLWLYDYW(ShapeHandle a);

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void DFAQGDTXPGQ(ShapeHandle a);

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void VJLJMSDVNBC();

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void VBSHZMEMZXO(OutlineEffectType a);

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(Slot = "6")]
		void YNOHPCGKAGH(RootHandle a);

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(Slot = "7")]
		void YNOHPCGKAGH(ShapeHandle a);

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(Slot = "8")]
		void AKXTZAQUDQO(ShapeHandle a);

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(Slot = "9")]
		void RYMHNPXDKFG(ShapeHandle a);

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(Slot = "10")]
		void BGYSQSCFACI();

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(Slot = "11")]
		void LSUDTSWJGJG();

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(Slot = "12")]
		void FGIEGDTHUKO(RootHandle a, SelectionEffectType b);

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(Slot = "13")]
		void DXWHHURYVOC(ShapeHandle a);

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(Slot = "14")]
		void LIFMSKVCFMM(ShapeHandle a);

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(Slot = "15")]
		void HTHSQZDBBBK();

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(Slot = "16")]
		void ZRLPFEADPCI(SelectionEffectType a);

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(Slot = "17")]
		void VFTHMEYCQAY(RootHandle a, Vector3 b, Vector3 c, Vector3 d, float e, float f, IReadOnlyList<Camera> g, IgnoreEffectType h);

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(Slot = "18")]
		void VFTHMEYCQAY(SkinnedCostumeHandle a, Vector3 b, Vector3 c, Vector3 d, float e, float f);
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public interface VFTFGZTBLYG : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		bool VONGNOHUZMJ
		{
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(Slot = "11")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(Slot = "0")]
		RootHandle CVVIZCXBNKH(CFCZCPIYOEX a);

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(Slot = "1")]
		RootHandle CVVIZCXBNKH(CFCZCPIYOEX a, bool b);

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void XAUPBUBSXFK(RootHandle a);

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void RJNJZGGXMHT(RootHandle a);

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(Slot = "4")]
		ShapeHandle FRFIMNFJFFK(RootHandle a, DLUTEBMOTCY b);

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(Slot = "5")]
		ShapeHandle BDHFAEROMKG(RootHandle a, ETHRCGFVFMO b);

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(Slot = "6")]
		void DBLYHFJKDON(ShapeHandle a);

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(Slot = "7")]
		void JQDFVWFEVSC(ShapeHandle a);

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(Slot = "8")]
		SkinnedCostumeHandle NYATRSELJUG(GXFAWPGRESV a);

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(Slot = "9")]
		void MWUKAWRTRAG(SkinnedCostumeHandle a);

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(Slot = "10")]
		void IAEWQTRTXST(SkinnedCostumeHandle a);

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(Slot = "12")]
		Task RKJPJCRVUDP();

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(Slot = "13")]
		Task WBRAZDFWQKD();

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(Slot = "14")]
		Task IGYCAIIHBBU();

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(Slot = "15")]
		void WWGTTSZJKKJ();

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(Slot = "16")]
		IEnumerable<Renderer> HRDXTUMWPSO(RootHandle a);
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public static class FHXZBCZJWZY
	{
		[Cpp2IlInjected.Token(Token = "0x2000010")]
		public enum ScalabilityCollapseMetricEnum
		{
			[Cpp2IlInjected.Token(Token = "0x4000160")]
			Distance,
			[Cpp2IlInjected.Token(Token = "0x4000161")]
			DistanceAttributes,
			[Cpp2IlInjected.Token(Token = "0x4000162")]
			DistanceAttributesArea
		}

		[Cpp2IlInjected.Token(Token = "0x2000011")]
		public enum ScalabilityShapeClassificationEnum
		{
			[Cpp2IlInjected.Token(Token = "0x4000164")]
			AllNaughty,
			[Cpp2IlInjected.Token(Token = "0x4000165")]
			NaughtyAndNice,
			[Cpp2IlInjected.Token(Token = "0x4000166")]
			AllNice
		}

		[Cpp2IlInjected.Token(Token = "0x2000012")]
		public enum ScalabilityDebugColourEnum
		{
			[Cpp2IlInjected.Token(Token = "0x4000168")]
			None,
			[Cpp2IlInjected.Token(Token = "0x4000169")]
			ShowNoLods,
			[Cpp2IlInjected.Token(Token = "0x400016A")]
			ActualError,
			[Cpp2IlInjected.Token(Token = "0x400016B")]
			LodColour,
			[Cpp2IlInjected.Token(Token = "0x400016C")]
			VertexFormatColour,
			[Cpp2IlInjected.Token(Token = "0x400016D")]
			ContainerColour,
			[Cpp2IlInjected.Token(Token = "0x400016E")]
			MaterialColour,
			[Cpp2IlInjected.Token(Token = "0x400016F")]
			MeshColour,
			[Cpp2IlInjected.Token(Token = "0x4000170")]
			BatchColour,
			[Cpp2IlInjected.Token(Token = "0x4000171")]
			TriangleColour,
			[Cpp2IlInjected.Token(Token = "0x4000172")]
			RefreshShapesBatchColour,
			[Cpp2IlInjected.Token(Token = "0x4000173")]
			RefreshBatchedMeshColour
		}

		[Cpp2IlInjected.Token(Token = "0x2000013")]
		public enum ScalabilityVertexOverrideEnum
		{
			[Cpp2IlInjected.Token(Token = "0x4000175")]
			None,
			[Cpp2IlInjected.Token(Token = "0x4000176")]
			Disable_NormTanMatF16,
			[Cpp2IlInjected.Token(Token = "0x4000177")]
			Disable_NormTanSn8MatF16,
			[Cpp2IlInjected.Token(Token = "0x4000178")]
			Disable_NormTanSn8UvMatF16,
			[Cpp2IlInjected.Token(Token = "0x4000179")]
			Disable_NormTanOct8MatUi,
			[Cpp2IlInjected.Token(Token = "0x400017A")]
			Disable_PosFixedPoint16NormTanOct8MatUi,
			[Cpp2IlInjected.Token(Token = "0x400017B")]
			Force_FullFloat32,
			[Cpp2IlInjected.Token(Token = "0x400017C")]
			Force_NormTanMatF16,
			[Cpp2IlInjected.Token(Token = "0x400017D")]
			Force_NormTanSn8MatF16,
			[Cpp2IlInjected.Token(Token = "0x400017E")]
			Force_NormTanSn8UvMatF16,
			[Cpp2IlInjected.Token(Token = "0x400017F")]
			Force_NormTanOct8MatUi,
			[Cpp2IlInjected.Token(Token = "0x4000180")]
			Force_PosFixedPoint16NormTanOct8MatUi
		}

		[Cpp2IlInjected.Token(Token = "0x2000014")]
		public enum ScalabilityRoomLoadingPhase
		{
			[Cpp2IlInjected.Token(Token = "0x4000182")]
			StartOfLevelPlay,
			[Cpp2IlInjected.Token(Token = "0x4000183")]
			LoadingStarted,
			[Cpp2IlInjected.Token(Token = "0x4000184")]
			LoadingShapesFinished,
			[Cpp2IlInjected.Token(Token = "0x4000185")]
			ShapeMeshesGenerated,
			[Cpp2IlInjected.Token(Token = "0x4000186")]
			RunningGame
		}

		[Cpp2IlInjected.Token(Token = "0x2000015")]
		public enum ScalabilityDynamicModeEnum
		{
			[Cpp2IlInjected.Token(Token = "0x4000188")]
			TriCount,
			[Cpp2IlInjected.Token(Token = "0x4000189")]
			FixedError,
			[Cpp2IlInjected.Token(Token = "0x400018A")]
			FixedBudget,
			[Cpp2IlInjected.Token(Token = "0x400018B")]
			CheckAtRoomLoad,
			[Cpp2IlInjected.Token(Token = "0x400018C")]
			CheckPassive,
			[Cpp2IlInjected.Token(Token = "0x400018D")]
			CheckOften,
			[Cpp2IlInjected.Token(Token = "0x400018E")]
			SimulatedLimit
		}

		[Cpp2IlInjected.Token(Token = "0x2000016")]
		public enum ScalabilityTessellationModeEnum
		{
			[Cpp2IlInjected.Token(Token = "0x4000190")]
			None,
			[Cpp2IlInjected.Token(Token = "0x4000191")]
			Linear,
			[Cpp2IlInjected.Token(Token = "0x4000192")]
			Sqrt
		}

		[Cpp2IlInjected.Token(Token = "0x2000017")]
		public enum ScalabilityPresetsEnum
		{
			[Cpp2IlInjected.Token(Token = "0x4000194")]
			GameConfigSetting = 0,
			[Cpp2IlInjected.Token(Token = "0x4000195")]
			Off = 1,
			[Cpp2IlInjected.Token(Token = "0x4000196")]
			FullDetail = 2,
			[Cpp2IlInjected.Token(Token = "0x4000197")]
			Imperceptible = 3,
			[Cpp2IlInjected.Token(Token = "0x4000198")]
			PC_High = 4,
			[Cpp2IlInjected.Token(Token = "0x4000199")]
			PC_Mid = 5,
			[Cpp2IlInjected.Token(Token = "0x400019A")]
			PC_Low = 6,
			[Cpp2IlInjected.Token(Token = "0x400019B")]
			MajorStress = 7,
			[Cpp2IlInjected.Token(Token = "0x400019C")]
			OutOfMemory = 8,
			[Cpp2IlInjected.Token(Token = "0x400019D")]
			Mobile_High = 9,
			[Cpp2IlInjected.Token(Token = "0x400019E")]
			Mobile_Mid = 10,
			[Cpp2IlInjected.Token(Token = "0x400019F")]
			Mobile_Low = 11,
			[Cpp2IlInjected.Token(Token = "0x40001A0")]
			PS4 = 12,
			[Cpp2IlInjected.Token(Token = "0x40001A1")]
			PS5 = 13,
			[Cpp2IlInjected.Token(Token = "0x40001A2")]
			XboxOne = 14,
			[Cpp2IlInjected.Token(Token = "0x40001A3")]
			XboxSeries = 15,
			[Cpp2IlInjected.Token(Token = "0x40001A4")]
			Switch1 = 16,
			[Cpp2IlInjected.Token(Token = "0x40001A5")]
			Quest2 = 17,
			[Cpp2IlInjected.Token(Token = "0x40001A6")]
			Quest3 = 18,
			[Cpp2IlInjected.Token(Token = "0x40001A7")]
			MemoryBuild = 19,
			[Cpp2IlInjected.Token(Token = "0x40001A8")]
			PS4VR = 20,
			[Cpp2IlInjected.Token(Token = "0x40001A9")]
			FourRoomsDemo = 100,
			[Cpp2IlInjected.Token(Token = "0x40001AA")]
			JustAvatarMeshLod = 101,
			[Cpp2IlInjected.Token(Token = "0x40001AB")]
			LowQualityHighSpeed = 102,
			[Cpp2IlInjected.Token(Token = "0x40001AC")]
			SpreadsheetSettings = 103
		}

		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		public static bool OAAKRERCOHS;

		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		public static long UHZVCZTZEQR;

		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		public static bool JLPQLXCWCNE;

		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		public static bool VCAPELSWFAI;

		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		public static bool OZHPXZRYGAP;

		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		public static float ARHWWXQQIVG;

		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		public static float WFWLOMMGYXL;

		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		public static int LTMFIQKSWOG;

		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		public static ScalabilityDynamicModeEnum EIFCQCKDIDX;

		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		public static long SHVRTCXBTZG;

		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		public static float IKHJOLSHRQA;

		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		public static int VOJIQCUNYQU;

		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		public static int CRZKRDQAFXB;

		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		public static int TYLGOZUPFID;

		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		public static int XAUJDMFLRYB;

		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		public static int RSIGBUPBTBM;

		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		public static int BORBJIGCNYJ;

		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		public static int QJMLJGDNIER;

		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		public static int DSXSTVZQGNT;

		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		public static bool TSDSGQKQFPX;

		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		public static int NDWBDJXEQMB;

		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		public static int AFOAWTSKTBG;

		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		public static int HXHVBVZJLKY;

		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		public static bool TXEIVXQCATN;

		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		public static float QSOYOASJACG;

		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		public static bool JRGOHOEKCFN;

		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		public static float BVDJPQMZAAI;

		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		public static long CUORIRBPFUR;

		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		public static bool PSYVQSXMDXI;

		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		public static long YRCUMPHZEEX;

		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		public static int BQEXURQTJDQ;

		[Cpp2IlInjected.Token(Token = "0x40000E1")]
		public static bool OVYDENAGFJX;

		[Cpp2IlInjected.Token(Token = "0x40000E2")]
		public static ScalabilityCollapseMetricEnum ROFXRXPWOYR;

		[Cpp2IlInjected.Token(Token = "0x40000E3")]
		public static bool USUXJGEXAUK;

		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		public static bool DPQAKOGGGPG;

		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		public static int WGLZGSLVNAA;

		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		public static int RGZDEOFVFGG;

		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		public static int WLOKNXVYVKK;

		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		public static int QGLDGHHNORX;

		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		public static int OETZGQRRNNL;

		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		public static int PXETGVOMCJP;

		[Cpp2IlInjected.Token(Token = "0x40000EB")]
		public static int YLEXYIFSTTR;

		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		public static int XVJHEUEVMNK;

		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		public static float FLYKIKZSGPH;

		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		public static float KLCNDYNKJCV;

		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		public static float XCHFBRTSBDK;

		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		public static float QLURIPYSVUY;

		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		public static int ZJDRNZTESZV;

		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		public static int LWBZXODHJAI;

		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		public static int UNTYBYZFAVZ;

		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		public static int YUSTPPICLHF;

		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		public static bool RTOTRMNLZLO;

		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		public static ScalabilityDebugColourEnum IWVBDNHPSSB;

		[Cpp2IlInjected.Token(Token = "0x40000F7")]
		public static ScalabilityVertexOverrideEnum SUBLQBXHXKA;

		[Cpp2IlInjected.Token(Token = "0x40000F8")]
		public static bool GVJMFHBBJIB;

		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		public static ScalabilityShapeClassificationEnum BLUSVZRFMEJ;

		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		public static float OGTPRRHIQXQ;

		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		public static float JQUKQXXIVWG;

		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		public static float TZTFWWFQDIY;

		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		public static float SUFLGTUVUEF;

		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		public static float TNTGYOFQSNH;

		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		public static float VEQFRSMXDNQ;

		[Cpp2IlInjected.Token(Token = "0x4000100")]
		public static float XTAFXSGYMEP;

		[Cpp2IlInjected.Token(Token = "0x4000101")]
		public static float GCDOFJXWDUY;

		[Cpp2IlInjected.Token(Token = "0x4000102")]
		public static bool FHGUSEFQMWB;

		[Cpp2IlInjected.Token(Token = "0x4000103")]
		public static ScalabilityTessellationModeEnum YRIGUWULIHX;

		[Cpp2IlInjected.Token(Token = "0x4000104")]
		public static bool MEJDOPOMSUF;

		[Cpp2IlInjected.Token(Token = "0x4000105")]
		public static float NVSSYUNKOQL;

		[Cpp2IlInjected.Token(Token = "0x4000106")]
		public static float EILDSXKPRMO;

		[Cpp2IlInjected.Token(Token = "0x4000107")]
		public static float NCXUFNUVRZA;

		[Cpp2IlInjected.Token(Token = "0x4000108")]
		public static float WGHDTUERVBF;

		[Cpp2IlInjected.Token(Token = "0x4000109")]
		public static float AVRYUYJQWKX;

		[Cpp2IlInjected.Token(Token = "0x400010A")]
		public static bool RPFAYOOQFSE;

		[Cpp2IlInjected.Token(Token = "0x400010B")]
		public static long NTCWEIPGZAL;

		[Cpp2IlInjected.Token(Token = "0x400010C")]
		public static float VVXNOZYTJKN;

		[Cpp2IlInjected.Token(Token = "0x400010D")]
		public static float HROMYMXNUCD;

		[Cpp2IlInjected.Token(Token = "0x400010E")]
		public static float NLEFWDDZIFJ;

		[Cpp2IlInjected.Token(Token = "0x400010F")]
		public static int VKVYOAPXPVF;

		[Cpp2IlInjected.Token(Token = "0x4000110")]
		public static float PPXWAKDAWSN;

		[Cpp2IlInjected.Token(Token = "0x4000111")]
		public static bool NXYLVJVIUKG;

		[Cpp2IlInjected.Token(Token = "0x4000112")]
		public static long CLXYNVARUEF;

		[Cpp2IlInjected.Token(Token = "0x4000113")]
		public static int WMHHVCEIGBC;

		[Cpp2IlInjected.Token(Token = "0x4000114")]
		public static int NXXVBWXPCIP;

		[Cpp2IlInjected.Token(Token = "0x4000115")]
		public static float SKGKEEPVOBH;

		[Cpp2IlInjected.Token(Token = "0x4000116")]
		public static float JVFHHSQIUKU;

		[Cpp2IlInjected.Token(Token = "0x4000117")]
		public static bool TGHKTUBOOAP;

		[Cpp2IlInjected.Token(Token = "0x4000118")]
		public static bool AUKTRAVZSNI;

		[Cpp2IlInjected.Token(Token = "0x4000119")]
		public static float VSMKMVXEAHV;

		[Cpp2IlInjected.Token(Token = "0x400011A")]
		public static long ABIRIHFMWEO;

		[Cpp2IlInjected.Token(Token = "0x400011B")]
		public static long YMHTXWSXXRF;

		[Cpp2IlInjected.Token(Token = "0x400011C")]
		public static int BKUBZLIQVGU;

		[Cpp2IlInjected.Token(Token = "0x400011D")]
		public static bool LIOTNUTEKNI;

		[Cpp2IlInjected.Token(Token = "0x400011E")]
		public static float RZNZPGRDNFQ;

		[Cpp2IlInjected.Token(Token = "0x400011F")]
		public static float FAGSCGRMZXP;

		[Cpp2IlInjected.Token(Token = "0x4000120")]
		public static bool BECVFWCYHNA;

		[Cpp2IlInjected.Token(Token = "0x4000121")]
		public static long HWDLWETUYCJ;

		[Cpp2IlInjected.Token(Token = "0x4000122")]
		public static int YTIINDQWXPK;

		[Cpp2IlInjected.Token(Token = "0x4000123")]
		public static float4x4 IOKCHPQAEAC;

		[Cpp2IlInjected.Token(Token = "0x4000124")]
		public static float3 PDLEJJDODNW;

		[Cpp2IlInjected.Token(Token = "0x4000125")]
		public static bool WJQDXLRVXBP;

		[Cpp2IlInjected.Token(Token = "0x4000126")]
		public static ScalabilityRoomLoadingPhase ZHDMSHAKAJW;

		[Cpp2IlInjected.Token(Token = "0x4000127")]
		public static long NGGLXLRFHTC;

		[Cpp2IlInjected.Token(Token = "0x4000128")]
		public static int VAFYJZTYLKN;

		[Cpp2IlInjected.Token(Token = "0x4000129")]
		public static int KCVEMJBOTES;

		[Cpp2IlInjected.Token(Token = "0x400012A")]
		public static int UUAOFZOBRQU;

		[Cpp2IlInjected.Token(Token = "0x400012B")]
		public static int QDNLIUZXPYO;

		[Cpp2IlInjected.Token(Token = "0x400012C")]
		public static int ERNEHFQYEDW;

		[Cpp2IlInjected.Token(Token = "0x400012D")]
		public static int RYHZLEQDHMP;

		[Cpp2IlInjected.Token(Token = "0x400012E")]
		public static int FIWHDOFQNEX;

		[Cpp2IlInjected.Token(Token = "0x400012F")]
		public static long VYFYZSWOEMQ;

		[Cpp2IlInjected.Token(Token = "0x4000130")]
		public static int JKYGJVIXBAZ;

		[Cpp2IlInjected.Token(Token = "0x4000131")]
		public static int YKATSUZBCVZ;

		[Cpp2IlInjected.Token(Token = "0x4000132")]
		public static int JNNZWKOQQAQ;

		[Cpp2IlInjected.Token(Token = "0x4000133")]
		public static long SBKJZEHCFIW;

		[Cpp2IlInjected.Token(Token = "0x4000134")]
		public static long HFEWSSMCAIE;

		[Cpp2IlInjected.Token(Token = "0x4000135")]
		public static long XCCQYMEVLSH;

		[Cpp2IlInjected.Token(Token = "0x4000136")]
		public static long KECJMWAAHMV;

		[Cpp2IlInjected.Token(Token = "0x4000137")]
		public static int ABIOPMBBKEN;

		[Cpp2IlInjected.Token(Token = "0x4000138")]
		public static int SEBOPDIHJDD;

		[Cpp2IlInjected.Token(Token = "0x4000139")]
		public static int QTWCVRPTOHG;

		[Cpp2IlInjected.Token(Token = "0x400013A")]
		public static int JLTXTJPKTNR;

		[Cpp2IlInjected.Token(Token = "0x400013B")]
		public static int NMPPLRLPYSX;

		[Cpp2IlInjected.Token(Token = "0x400013C")]
		public static int[] MIPXCAIDECM;

		[Cpp2IlInjected.Token(Token = "0x400013D")]
		public static int[] ZQAFIIJQZWH;

		[Cpp2IlInjected.Token(Token = "0x400013E")]
		public static int KGOVYMCMESC;

		[Cpp2IlInjected.Token(Token = "0x400013F")]
		public static long CDZPUIILMCO;

		[Cpp2IlInjected.Token(Token = "0x4000140")]
		public static long EBTEJLVBPLO;

		[Cpp2IlInjected.Token(Token = "0x4000141")]
		public static int KHAZKSJBARW;

		[Cpp2IlInjected.Token(Token = "0x4000142")]
		public static int LZAPWWHBTUX;

		[Cpp2IlInjected.Token(Token = "0x4000143")]
		public static long FPGHOXMWILB;

		[Cpp2IlInjected.Token(Token = "0x4000144")]
		public static long JYGUSIXALDX;

		[Cpp2IlInjected.Token(Token = "0x4000145")]
		public static long VXBEKAOMQWE;

		[Cpp2IlInjected.Token(Token = "0x4000146")]
		public static long ZINUTEDJIID;

		[Cpp2IlInjected.Token(Token = "0x4000147")]
		public static long PFCGCAWJFUX;

		[Cpp2IlInjected.Token(Token = "0x4000148")]
		public static long VAKIPBVNNLR;

		[Cpp2IlInjected.Token(Token = "0x4000149")]
		public static long FFTYVGRPAXX;

		[Cpp2IlInjected.Token(Token = "0x400014A")]
		public static long PIIPEGKAWRJ;

		[Cpp2IlInjected.Token(Token = "0x400014B")]
		public static long FTHQHBEAESG;

		[Cpp2IlInjected.Token(Token = "0x400014C")]
		public static float BWFMFJRXWKT;

		[Cpp2IlInjected.Token(Token = "0x400014D")]
		public static float HZGGPJBAIKJ;

		[Cpp2IlInjected.Token(Token = "0x400014E")]
		public static long PDTASMFUWNW;

		[Cpp2IlInjected.Token(Token = "0x400014F")]
		public static int SKCFLQVHTEH;

		[Cpp2IlInjected.Token(Token = "0x4000150")]
		public static long MKQJRZCAIBS;

		[Cpp2IlInjected.Token(Token = "0x4000151")]
		public static long PNABBCXIFTH;

		[Cpp2IlInjected.Token(Token = "0x4000152")]
		public static float FGUTNQAVIHL;

		[Cpp2IlInjected.Token(Token = "0x4000153")]
		public static long QNBWEAXCHIF;

		[Cpp2IlInjected.Token(Token = "0x4000154")]
		public static long RDXUQWEZZSW;

		[Cpp2IlInjected.Token(Token = "0x4000155")]
		public static long YEFAHGFUOPI;

		[Cpp2IlInjected.Token(Token = "0x4000156")]
		public static long QHQSZRQSYUG;

		[Cpp2IlInjected.Token(Token = "0x4000157")]
		public static long FOBPQLAEONR;

		[Cpp2IlInjected.Token(Token = "0x4000158")]
		public static long CUSKJTUBIST;

		[Cpp2IlInjected.Token(Token = "0x4000159")]
		public static long FFWRLJCKWTL;

		[Cpp2IlInjected.Token(Token = "0x400015A")]
		public static long HPJXIDKUSRJ;

		[Cpp2IlInjected.Token(Token = "0x400015B")]
		public static long EOJDLIQWIVM;

		[Cpp2IlInjected.Token(Token = "0x400015C")]
		public static long JHUXLOBANPH;

		[Cpp2IlInjected.Token(Token = "0x400015D")]
		public static long AVBEKXTNWQW;

		[Cpp2IlInjected.Token(Token = "0x400015E")]
		public static long ZAGAGWHYMWO;

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		private static ScalabilityPresetsEnum QKDLDLONNQO
		{
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x86C78F0", Offset = "0x86C5EF0", VA = "0x1886C78F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public static long RGKLNNJHPWV
		{
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x86C7940", Offset = "0x86C5F40", VA = "0x1886C7940")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x86C7320", Offset = "0x86C5920", VA = "0x1886C7320")]
		public static void KDANQWPITNE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x86C6320", Offset = "0x86C4920", VA = "0x1886C6320")]
		public static void BYEFXAUGEJZ(ScalabilityPresetsEnum a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public static class TOSIZOZYZYY
	{
		[Cpp2IlInjected.Token(Token = "0x2000019")]
		private struct PointSrcData
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001AE")]
			public Vector3 Position;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
			[Cpp2IlInjected.Token(Token = "0x40001AF")]
			public Quaternion Rotation;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
			[Cpp2IlInjected.Token(Token = "0x40001B0")]
			public float Radius;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40001B1")]
			public Quaternion BlendedRotation;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40001B2")]
			public float BendAngle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
			[Cpp2IlInjected.Token(Token = "0x40001B3")]
			public float BendRadius;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40001B4")]
			public float DistanceToNext;
		}

		[Cpp2IlInjected.Token(Token = "0x40001AD")]
		private static List<PointSrcData> FRRSCGNUYQZ;

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x86C9C10", Offset = "0x86C8210", VA = "0x1886C9C10")]
		public static NativeList<CurvePointData> EBYFOHGXWGD(TGTFRFYHYCD a)
		{
			return default(NativeList<CurvePointData>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x86CA240", Offset = "0x86C8840", VA = "0x1886CA240")]
		private static bool IYGZUDLECSC(int a, NativeList<CurvePointData> b, List<PointSrcData> c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x86CC560", Offset = "0x86CAB60", VA = "0x1886CC560")]
		private static CurvePointData VKJIVOGXKNN(int a, List<PointSrcData> b)
		{
			return default(CurvePointData);
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x86CC6E0", Offset = "0x86CACE0", VA = "0x1886CC6E0")]
		private static CurvePointData XMSACXLCMZQ(int a, List<PointSrcData> b)
		{
			return default(CurvePointData);
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x86CA160", Offset = "0x86C8760", VA = "0x1886CA160")]
		private static CurvePointData HOMYAWVYFZZ(Vector3 a, Quaternion b, float c)
		{
			return default(CurvePointData);
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x86CB0D0", Offset = "0x86C96D0", VA = "0x1886CB0D0")]
		public static NativeList<CurvePointData> JNJVETNLQYJ(TGTFRFYHYCD a, float b)
		{
			return default(NativeList<CurvePointData>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public static class QFKAQWBGWCL
	{
		[Cpp2IlInjected.Token(Token = "0x40001B5")]
		public static Vector3 AWOCIVVQRFC;

		[Cpp2IlInjected.Token(Token = "0x40001B6")]
		public static Vector3 VYWLECKBQLQ;

		[Cpp2IlInjected.Token(Token = "0x40001B7")]
		public static readonly float BZEWXGPDRPC;

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x86C8C50", Offset = "0x86C7250", VA = "0x1886C8C50")]
		public static Vector3 JQNNMACGIMS(Vector3 a, Quaternion b)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x86C9700", Offset = "0x86C7D00", VA = "0x1886C9700")]
		public static Vector3 YVWEBTGBJNH(Quaternion a)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x86C9660", Offset = "0x86C7C60", VA = "0x1886C9660")]
		public static Vector3 WFXCKNUOZBR(Quaternion a)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x86C8BD0", Offset = "0x86C71D0", VA = "0x1886C8BD0")]
		public static Quaternion JKXTCORHRID(Vector3 a, Vector3 b)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x86C8860", Offset = "0x86C6E60", VA = "0x1886C8860")]
		public static Vector3 FRUWUVMIZOS(Vector3 a, Vector3 b, Vector3 c)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x86C9230", Offset = "0x86C7830", VA = "0x1886C9230")]
		public static Vector3 SJRNKSHOQFW(Vector3 a, Vector3 b, Quaternion c)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x86C8ED0", Offset = "0x86C74D0", VA = "0x1886C8ED0")]
		public static Quaternion QNPKFFULGHQ(Quaternion a, Vector3 b)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x86C8A50", Offset = "0x86C7050", VA = "0x1886C8A50")]
		public static bool HEOYVAGTIAU(Vector3 a, Vector3 b, [Out] Vector3 c, bool d)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x86C8570", Offset = "0x86C6B70", VA = "0x1886C8570")]
		public static Vector3 FMXDERNQXJT(bool a, [Optional] Quaternion b)
		{
			return default(Vector3);
		}
	}
}
namespace RecRoom.RendererV1.Terrain
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public struct TerrainMaterialLayer
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001B8")]
		public float heightCutoff;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40001B9")]
		public float effectiveHeightCutoff;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001BA")]
		public float slopeCutoff;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x40001BB")]
		public Color topColorInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40001BC")]
		public ShapeMaterial topMaterialInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001BD")]
		public Color slopeColorInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001BE")]
		public ShapeMaterial slopeMaterialInfo;
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public struct TerrainWaterProperties
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001BF")]
		public bool waterEnabled;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40001C0")]
		public float waterHeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001C1")]
		public float waterChop;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x40001C2")]
		public Color waterColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40001C3")]
		public Color deepColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40001C4")]
		public float emissiveStrength;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001C5")]
		public float alpha;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x40001C6")]
		public TerrainWaterMaterial waterMaterial;

		[Cpp2IlInjected.FieldOffset(Offset = "0x35")]
		[Cpp2IlInjected.Token(Token = "0x40001C7")]
		public WaterOverrides overrides;
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	public class TerrainGenerationInfo
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001C8")]
		public TerrainLayerRoughness baseTerrainRoughness;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40001C9")]
		public float baseTerrainHeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001CA")]
		public float baseTerrainScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001CB")]
		public TerrainGenerationLayer[] additionalLayers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001CC")]
		public TerrainMaterialLayer[] materialLayers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001CD")]
		public bool normalizeLayerHeights;

		[Cpp2IlInjected.FieldOffset(Offset = "0x31")]
		[Cpp2IlInjected.Token(Token = "0x40001CE")]
		public TerrainPlayAreaShape playArea;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x40001CF")]
		public float playAreaOpacity;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001D0")]
		public TerrainWaterProperties globalWaterProperties;

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x86CCC50", Offset = "0x86CB250", VA = "0x1886CCC50")]
		public TerrainGenerationInfo()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public struct TerrainInfo
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001D1")]
		public float WaterHeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40001D2")]
		public float GroundHeight;
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public enum TerrainPropertyMapPropertyType
	{
		[Cpp2IlInjected.Token(Token = "0x40001D4")]
		Height,
		[Cpp2IlInjected.Token(Token = "0x40001D5")]
		Strata,
		[Cpp2IlInjected.Token(Token = "0x40001D6")]
		Count
	}
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public class XFJKHSOWROK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001D7")]
		public Vector2Int KHMIYEAQFNT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001D8")]
		public float[] EJHSPXJBXKG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001D9")]
		public TerrainPropertyMapPropertyType FOEYAZCVXNK;

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x86CCD90", Offset = "0x86CB390", VA = "0x1886CCD90")]
		public XFJKHSOWROK(Vector2Int a, TerrainPropertyMapPropertyType b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public class YVETIPOWKYW
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001DA")]
		public float WPMRZVQPRVN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40001DB")]
		public float CKLSCVMNHPR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001DC")]
		public TerrainMaterialLayer[] QECFKBIOYUD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001DD")]
		public int UVAJBNUCFTO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001DE")]
		public XFJKHSOWROK[] OOGOVJOOYUC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001DF")]
		public float HAHZWDTUWDP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x40001E0")]
		public int HORALCKWLOX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001E1")]
		public int PTKJKCNWCAP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x40001E2")]
		public float INUPMLAKJIN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001E3")]
		public int PZQGKQBYKQF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x40001E4")]
		public float QOWSDYQTIPZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001E5")]
		public int LMIVPCBGFUM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x40001E6")]
		public int NIFIEXLTLTY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001E7")]
		public float XPZVOCPZTCA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x40001E8")]
		public int RZLUEUUUDLV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001E9")]
		public int IERBHMHJJAO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x40001EA")]
		public int CPLHEKIORFR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40001EB")]
		public XFJKHSOWROK[] VWVQCOXKMOR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40001EC")]
		public float TGMSMVKXZIA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x40001ED")]
		public int TALLLGBHXOU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40001EE")]
		public int YQZRCPMERKJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
		[Cpp2IlInjected.Token(Token = "0x40001EF")]
		public int FKNJTERJASZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40001F0")]
		public float XCDOWIUZJAX;

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x86CCE10", Offset = "0x86CB410", VA = "0x1886CCE10")]
		public YVETIPOWKYW(Vector2Int a, Vector2Int b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public interface VXOSMSYQLMZ
	{
		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		TerrainData YIOSTUXNGYZ
		{
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		GameObject WCLCOMYYRHM
		{
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		Vector3 TBDKTKQQYPS
		{
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		float3 MQITXBMBIRY
		{
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		float3 RSXYAAVCJIB
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		TerrainGenerationInfo IZGHMIODFXF
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		TerrainInfo ZKHEPJDCIPL
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(Slot = "6")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(Slot = "7")]
		Task<bool> Generate(uint seed, bool randomize = true, bool spawnProps = true, bool animate = true, [Optional] TerrainGenerationInfo info, TerrainColorMode colorMode = TerrainColorMode.Default, [Optional] float3? spawnPosition, [Optional] CancellationToken cancellationToken);

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(Slot = "8")]
		void Destroy(bool cleanupProps);

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(Slot = "9")]
		void UpdateMaterial(Action<Material> updateFunction);
	}
}
namespace RecRoom.RendererV1.DataProviders
{
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public struct CurvePointData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001F1")]
		public float3 Position;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x40001F2")]
		public float3x3 Rotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001F3")]
		public float Radius;
	}
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public interface TGTFRFYHYCD
	{
		[Cpp2IlInjected.Token(Token = "0x17000014")]
		int GJESTOHYQDA
		{
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Vector3 JKZRWOXSAVT(int a);

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(Slot = "1")]
		Quaternion SNWEFGIPWCU(int a);

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(Slot = "2")]
		float NTAREGFYHJS(int a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public interface ETHRCGFVFMO : SOLFBWZQQDG, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x17000015")]
		bool LVBHKBNKMKE
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		bool FXRBVFKMFOQ
		{
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		float CWOZQLHMEND
		{
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		int FTJRLOHGVNR
		{
			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		bool RWVOODLDRJZ
		{
			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		int EDVTPYZYLZE
		{
			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(Slot = "6")]
		NativeArray<CurvePointData> GetNativeCurvePoints();
	}
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public interface DLUTEBMOTCY : SOLFBWZQQDG, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		PrimitiveShapeMeshType JTFCKIJTXOB
		{
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		bool ILFDNTRMCWP
		{
			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		float3 YWHMPZHUOWV
		{
			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public interface CFCZCPIYOEX
	{
		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		RRTransform HBZICNJLAVK
		{
			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		RootFlags NNBHECDSPIX
		{
			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0xAA6850", Offset = "0xAA4E50", VA = "0x180AA6850", Slot = "2")]
		void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public interface SOLFBWZQQDG : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x17000020")]
		bool YILFLEUBXBS
		{
			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		bool BYQGWLPWIYL
		{
			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		RRTransform HBZICNJLAVK
		{
			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		UniformTRS SJGAMIEVZUQ
		{
			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		float AZLZTQGKHOD
		{
			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		Vector3 JKCYYQVJBGY
		{
			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		ShapeColor YGAAABOCJPW
		{
			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(Slot = "6")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		ShapeMaterial PFFCZGTOYIY
		{
			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(Slot = "7")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(Slot = "8")]
		Hash128 ComputeHash();
	}
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public interface GXFAWPGRESV
	{
		[Cpp2IlInjected.Token(Token = "0x17000028")]
		int LESMSQKGZJR
		{
			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		Transform AQMOUBPQNZV
		{
			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		bool QKAAASRNCAT
		{
			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(Slot = "1")]
		RootHandle GetBone(int idx);

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(Slot = "2")]
		bool IsPartOfFirstPersonSkin(int idx);
	}
}
namespace Cpp2IlInjected
{
	internal class AddressAttribute : Attribute
	{
		public string RVA;

		public string Offset;

		public string VA;

		public string Slot;
	}
	internal class FieldOffsetAttribute : Attribute
	{
		public string Offset;
	}
	internal class AttributeAttribute : Attribute
	{
		public string Name;

		public string RVA;

		public string Offset;
	}
	internal class MetadataOffsetAttribute : Attribute
	{
		public string Offset;
	}
	internal class TokenAttribute : Attribute
	{
		public string Token;
	}
	internal class AnalysisFailedException : Exception
	{
		public AnalysisFailedException(string message)
			: base(message)
		{
		}
	}
}
