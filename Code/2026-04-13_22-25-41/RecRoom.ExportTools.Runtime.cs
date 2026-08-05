using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Numerics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Google.Protobuf;
using Microsoft.CodeAnalysis;
using RecRoom.NoEngine.DataStructures;
using RecRoom.NoEngine.DataStructures.ProgressV2;
using RecRoom.Protobuf;
using SharpGLTF.Geometry;
using SharpGLTF.Geometry.VertexTypes;
using SharpGLTF.Materials;
using SharpGLTF.Scenes;
using SharpGLTF.Schema2;
using Unity.Mathematics;

[assembly: AssemblyVersion("0.0.0.0")]
namespace Microsoft.CodeAnalysis
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class EmbeddedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0xD18E40", Offset = "0xD17840", VA = "0x180D18E40")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter, AllowMultiple = false, Inherited = false)]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x98342D0", Offset = "0x9832CD0", VA = "0x1898342D0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xD19810", Offset = "0xD18210", VA = "0x180D19810")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xD19850", Offset = "0xD18250", VA = "0x180D19850")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
namespace RecRoom.ExportTools
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public struct BevelConfig
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		public float SmallBevelSizeMeters;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		public float BoxAuthoredBevelPercent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		public float WedgeAuthoredBevelPercent;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		public float PyramidAuthoredBevelPercent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		public bool BevelSizeBasedOnLargestPossibleDimension;
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public readonly struct ColorRGB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public readonly float R;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public readonly float G;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public readonly float B;

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x2B6CF70", Offset = "0x2B6B970", VA = "0x182B6CF70")]
		public ColorRGB(float r, float g, float b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public class DYQUHGVLWJN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public string SGABVFHOYOH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public MaterialColorUsage DCUYQOEPUHY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public ColorRGB TYYAMNNNNTX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public ColorRGB YZXWCMRSHNQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public ColorRGB UMAGGRVLINK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public float JCTDYQNNZWW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public NWLNRFVRZLH? NYJSSJUFKAB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public NWLNRFVRZLH? QRHEPUODWBE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public NWLNRFVRZLH? HLATYILRRYG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public NWLNRFVRZLH? NXFQZXQQYTC;

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x9830F20", Offset = "0x982F920", VA = "0x189830F20")]
		public DYQUHGVLWJN()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	internal readonly struct MaterialExportKey : IEquatable<MaterialExportKey>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public readonly ShapeColor ShapeColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public readonly ShapeMaterial ShapeMaterial;

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0xEB70C0", Offset = "0xEB5AC0", VA = "0x180EB70C0")]
		public MaterialExportKey(ShapeColor shapeColor, ShapeMaterial shapeMaterial)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x142DAD0", Offset = "0x142C4D0", VA = "0x18142DAD0", Slot = "4")]
		public bool Equals(MaterialExportKey other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x9833D20", Offset = "0x9832720", VA = "0x189833D20", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x9833DB0", Offset = "0x98327B0", VA = "0x189833DB0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	internal readonly struct MeshBuilderCacheKey : IEquatable<MeshBuilderCacheKey>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public readonly PrimitiveShapeMeshType MeshType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public readonly MaterialExportKey Material;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public readonly float3 BevelScalingRatio;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public readonly float BevelAuthoredRatio;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public readonly float3 WorldScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public readonly bool DynamicProjection;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public readonly float ContainerScaleX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public readonly float UvScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public readonly float3 UvOffset;

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x9834210", Offset = "0x9832C10", VA = "0x189834210")]
		public MeshBuilderCacheKey(PrimitiveShapeMeshType meshType, MaterialExportKey material, [Optional] float3 bevelScalingRatio, float bevelAuthoredRatio = 0f, [Optional] float3 worldScale, bool dynamicProjection = false, float containerScaleX = 0f, float uvScale = 0f, [Optional] float3 uvOffset)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x9833E20", Offset = "0x9832820", VA = "0x189833E20", Slot = "4")]
		public bool Equals(MeshBuilderCacheKey other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x9833FB0", Offset = "0x98329B0", VA = "0x189833FB0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x9834070", Offset = "0x9832A70", VA = "0x189834070", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public class TIREOSLVZXD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public float3[] PNBEGWYOAAP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		public int[] ESJRHMVTMSZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public float3[] DOGEWGHCIYA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		public float2[]? PNJKVUQTAIQ;

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x1120590", Offset = "0x111EF90", VA = "0x181120590")]
		public TIREOSLVZXD(float3[] a, int[] b, float3[] c, [Optional] float2[]? uvs)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public class NWLNRFVRZLH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public string SMRRXKTPZZK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public ImageBuilder? AVCMJKNHAKR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public float2 RFBIZEQGAWX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		public float2 JBTKORXHGDU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		public TextureWrapMode FZIQPFSEMNE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		public TextureWrapMode FZDJRYYHDBV;

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x9834280", Offset = "0x9832C80", VA = "0x189834280")]
		public NWLNRFVRZLH()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[Flags]
	public enum MaterialColorUsage
	{
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		ALBEDO = 1,
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		EMISSIVE = 2,
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		SPECULAR = 4,
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		HOLOGRAPHIC = 8
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public enum PrimitiveShapeMeshType
	{
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		Invalid = -1,
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		RR_Box,
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		RR_Sphere,
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		RR_Cylinder,
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		RR_Wedge,
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		RR_Pyramid,
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		RR_HalfSphere,
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		RR_Cone,
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		RR_Pipe,
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		RR_Donut,
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		RR_HalfPipe,
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		RR_Diamond,
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		ADVANCED_Mound,
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		LEGACY_Box,
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		ADVANCED_Cube,
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		ADVANCED_Sphere,
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		ADVANCED_Cylinder,
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		ADVANCED_Cone,
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		ADVANCED_Pyramid,
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		ADVANCED_Octagon,
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		ADVANCED_Triangle,
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		ADVANCED_Hexagon,
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		ADVANCED_QuarterPipe,
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		ADVANCED_Pentagon,
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		ADVANCED_Dodecahedron,
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		ADVANCED_Trihedron,
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		ADVANCED_Octahedron,
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		RR_QuarterCylinder,
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		RR_Pentagon,
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		RR_QuarterSphere,
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		ADVANCED_Wedge,
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		RR_Hexagon,
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		RR_Octagon,
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		RR_Triangle,
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		Count
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public enum ShapeColor
	{
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		RED = 0,
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		ORANGE = 1,
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		YELLOW = 2,
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		GREEN = 3,
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		DARK_GREEN = 4,
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		CYAN = 5,
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		BLUE = 6,
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		DARK_BLUE = 7,
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		PURPLE = 8,
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		PINK = 9,
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		BROWN = 10,
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		WHITE = 11,
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		GREY = 12,
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		BLACK = 13,
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		DARK_ORANGE = 14,
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		LIME = 15,
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		LIGHT_GREEN = 16,
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		AQUAMARINE = 17,
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		LIGHT_BLUE = 18,
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		LAVENDER = 19,
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		MAGENTA = 20,
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		SALMON = 21,
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		TAN = 22,
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		CREAM = 23,
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		LIGHT_GREY = 24,
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		DARK_GREY = 25,
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		NEW_COLOR_0 = 26,
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		NEW_COLOR_1 = 27,
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		NEW_COLOR_2 = 28,
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		NEW_COLOR_3 = 29,
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		NEW_COLOR_4 = 30,
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		NEW_COLOR_5 = 31,
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		NEW_COLOR_6 = 32,
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		UNUSED_SEE_COMMENT = 33,
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		NEW_COLOR_7 = 34,
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		NEW_COLOR_8 = 35,
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		NEW_COLOR_9 = 36,
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		NEW_COLOR_10 = 37,
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		NEW_COLOR_11 = 38,
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		NEW_COLOR_12 = 39,
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		NEW_COLOR_13 = 40,
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		NEW_COLOR_14 = 41,
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		NEW_COLOR_15 = 42,
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		NEW_COLOR_16 = 43,
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		NEW_COLOR_17 = 44,
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		NEW_COLOR_18 = 45,
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		NEW_COLOR_19 = 46,
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		NEW_COLOR_20 = 47,
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		NEW_COLOR_21 = 48,
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		NEW_COLOR_22 = 49,
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		NEW_COLOR_23 = 50,
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		NEW_COLOR_24 = 51,
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		NEW_COLOR_25 = 52,
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		NEW_COLOR_26 = 53,
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		NEW_COLOR_27 = 54,
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		NEW_COLOR_28 = 55,
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		NEW_COLOR_29 = 56,
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		NEW_COLOR_30 = 57,
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		NEW_COLOR_31 = 58,
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		NEW_COLOR_32 = 59,
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		NEW_COLOR_33 = 60,
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		GENERATED_COLOR_START = 1000
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public enum ShapeMaterial
	{
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		INVALID = -1,
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		CARDBOARD = 0,
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		METAL = 1,
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		RUBBER = 2,
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		PLASTIC = 3,
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		NEON = 4,
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		WOOD = 5,
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		GLASS = 6,
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		ROCK = 7,
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		ICE = 8,
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		GOLD = 9,
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		SAND = 10,
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		LEATHER = 11,
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		GRID = 12,
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		TILE = 13,
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		GRASS = 14,
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		BARK = 15,
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		CONCRETE = 16,
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		SNOW = 17,
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		CARPET = 18,
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		FABRIC = 19,
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		FOIL = 20,
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		FLESH = 21,
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		GALAXY = 22,
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		LAVA = 23,
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		WATER = 24,
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		CANDY = 25,
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		FUR = 26,
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		CHAIN_MAIL = 27,
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		PLACEHOLDER_14 = 28,
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		PLACEHOLDER_15 = 29,
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		PLACEHOLDER_16 = 30,
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		PLACEHOLDER_18 = 31,
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		MIN_VALUE = -1,
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		MAX_VALUE = 31,
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		COUNT = 32,
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		DEFAULT = 0
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public enum ShapeType
	{
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		Invalid = -1,
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		CURVE_Tube = 0,
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		CURVE_Ribbon = 1,
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		LegacyBox = 2,
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		RR_Sphere = 3,
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		RR_Cylinder = 4,
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		LEGACY_Wedge = 5,
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		LEGACY_Pyramid = 6,
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		LEGACY_TriggerVolumeBox = 7,
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		RR_Box = 8,
		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		LEGACY_RoundedBox = 9,
		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		RR_Wedge = 10,
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		RR_Pyramid = 11,
		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		RR_HalfSphere = 12,
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		RR_Cone = 13,
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		RR_Pipe = 14,
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		RR_Donut = 15,
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		RR_HalfPipe = 16,
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		RR_Diamond = 17,
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		ADVANCED_Mound = 18,
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		ADVANCED_Cube = 19,
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		ADVANCED_Sphere = 20,
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		ADVANCED_Cylinder = 21,
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		ADVANCED_Cone = 22,
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		ADVANCED_Pyramid = 23,
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		ADVANCED_Octagon = 24,
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		ADVANCED_Triangle = 25,
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		ADVANCED_Hexagon = 26,
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		ADVANCED_QuarterPipe = 27,
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		ADVANCED_Pentagon = 28,
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		ADVANCED_Dodecahedron = 29,
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		ADVANCED_Trihedron = 30,
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		ADVANCED_Octahedron = 31,
		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		RR_QuarterCylinder = 32,
		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		RR_Pentagon = 33,
		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		RR_QuarterSphere = 34,
		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		ADVANCED_Wedge = 35,
		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		RR_Hexagon = 36,
		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		RR_Octagon = 37,
		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		RR_Triangle = 38,
		[Cpp2IlInjected.Token(Token = "0x40000E1")]
		COUNT = 39,
		[Cpp2IlInjected.Token(Token = "0x40000E2")]
		MIN_VALUE = -1,
		[Cpp2IlInjected.Token(Token = "0x40000E3")]
		MAX_VALUE = 38
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public enum TextureWrapMode
	{
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		Repeat,
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		Clamp,
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		Other
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public static class IBHOQKYRCJB
	{
		[Cpp2IlInjected.Token(Token = "0x2000013")]
		public struct ProfileSession : IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000E8")]
			private readonly string? _outputPath;

			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x98345D0", Offset = "0x9832FD0", VA = "0x1898345D0")]
			internal ProfileSession(string? outputPath)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0xCEFF30", Offset = "0xCEE930", VA = "0x180CEFF30", Slot = "4")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000014")]
		internal struct ProfileSection : IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000E9")]
			private readonly string? _name;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40000EA")]
			private readonly int _depth;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000EB")]
			private readonly long _startTicks;

			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x98345C0", Offset = "0x9832FC0", VA = "0x1898345C0")]
			internal ProfileSection(string name)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0xCEFF30", Offset = "0xCEE930", VA = "0x180CEFF30", Slot = "4")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0xCEFF40", Offset = "0xCEE940", VA = "0x180CEFF40")]
		public static ProfileSession SIUHUEYRRON(string? a)
		{
			return default(ProfileSession);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x1820930", Offset = "0x181F330", VA = "0x181820930")]
		internal static ProfileSection Section(string name)
		{
			return default(ProfileSection);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public class KDUQLYDWETD
	{
		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public string? AZGBUIWNJKT
		{
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0xCF4310", Offset = "0xCF2D10", VA = "0x180CF4310")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0xCF43C0", Offset = "0xCF2DC0", VA = "0x180CF43C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public int? YOUKCUZQPKM
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0xCF1D40", Offset = "0xCF0740", VA = "0x180CF1D40")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0xDDD760", Offset = "0xDDC160", VA = "0x180DDD760")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF4E50", VA = "0x180CF6450")]
		public KDUQLYDWETD()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public interface HAHYOVHKCDQ
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		TIREOSLVZXD? JEEFDDJPOEU(PrimitiveShapeMeshType a, int b = 0);

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		BevelConfig HRXZAOUNJJY();

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(Slot = "2")]
		DYQUHGVLWJN? GetMaterialExportData(ShapeColor shapeColor, ShapeMaterial shapeMaterial);

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(Slot = "3")]
		bool KIRKQSEUHFI(Guid a, [Out] string b);
	}
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public static class ICXMNVJDBVX
	{
		[Cpp2IlInjected.Token(Token = "0x2000018")]
		public static class FARHETYOEGP
		{
			[Cpp2IlInjected.Token(Token = "0x2000019")]
			public static class VCLRGATQZHR
			{
				[Cpp2IlInjected.Token(Token = "0x40000EE")]
				public static readonly Guid FQQXWJRJYNJ;

				[Cpp2IlInjected.Token(Token = "0x40000EF")]
				public static readonly Guid LIQRHMTDHGB;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001A")]
		private readonly struct ExportContext
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000F0")]
			public readonly SceneBuilder SceneBuilder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40000F1")]
			public readonly HAHYOVHKCDQ Dependencies;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000F2")]
			public readonly BevelConfig BevelConfig;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000F3")]
			public readonly Dictionary<string, int> NodeNameToCountMap;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000F4")]
			public readonly Dictionary<MaterialExportKey, MaterialBuilder> MaterialCache;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40000F5")]
			public readonly Dictionary<PrimitiveShapeMeshType, TIREOSLVZXD?> PrimitiveMeshCache;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40000F6")]
			public readonly Dictionary<MeshBuilderCacheKey, MeshBuilder<MaterialBuilder, VertexPositionNormal, VertexTexture1, VertexEmpty>> MeshBuilderCache;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40000F7")]
			public readonly XDSPFZNLMNK? Progress;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x40000F8")]
			public readonly BQPRVKKJFCT TimedYielder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x40000F9")]
			public readonly CancellationToken CancellationToken;

			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x98318D0", Offset = "0x98302D0", VA = "0x1898318D0")]
			private ExportContext(SceneBuilder sceneBuilder, HAHYOVHKCDQ dependencies, BevelConfig bevelConfig, Dictionary<string, int> nodeNameToCountMap, Dictionary<MaterialExportKey, MaterialBuilder> materialCache, Dictionary<PrimitiveShapeMeshType, TIREOSLVZXD?> primitiveMeshCache, Dictionary<MeshBuilderCacheKey, MeshBuilder<MaterialBuilder, VertexPositionNormal, VertexTexture1, VertexEmpty>> meshBuilderCache, XDSPFZNLMNK? progress, BQPRVKKJFCT timedYielder, CancellationToken cancellationToken)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x9831570", Offset = "0x982FF70", VA = "0x189831570")]
			public static ExportContext New(HAHYOVHKCDQ dependencies, XDSPFZNLMNK? progress, CancellationToken cancellationToken)
			{
				return default(ExportContext);
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200001B")]
		[CompilerGenerated]
		private struct <BuildR1GlbModel>d__3 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000FA")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40000FB")]
			public AsyncTaskMethodBuilder<ModelRoot> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000FC")]
			public YMQXVRQNJLQ[] persistenceViewDatas;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000FD")]
			public HAHYOVHKCDQ dependencies;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000FE")]
			public XDSPFZNLMNK progress;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40000FF")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000100")]
			private IBHOQKYRCJB.ProfileSection <_exportSection>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4000101")]
			private ExportContext <ctx>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
			[Cpp2IlInjected.Token(Token = "0x4000102")]
			private Queue<(NodeBuilder parentNode, YMQXVRQNJLQ data)> <queue>5__4;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
			[Cpp2IlInjected.Token(Token = "0x4000103")]
			private YMQXVRQNJLQ <pv>5__5;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
			[Cpp2IlInjected.Token(Token = "0x4000104")]
			private NodeBuilder <node>5__6;

			[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
			[Cpp2IlInjected.Token(Token = "0x4000105")]
			private int <childViewCount>5__7;

			[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
			[Cpp2IlInjected.Token(Token = "0x4000106")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
			[Cpp2IlInjected.Token(Token = "0x4000107")]
			private object <>u__2;

			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x9834C40", Offset = "0x9833640", VA = "0x189834C40", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x9835BF0", Offset = "0x98345F0", VA = "0x189835BF0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200001C")]
		[CompilerGenerated]
		private struct <BuildR2GlbModel>d__5 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000108")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000109")]
			public AsyncTaskMethodBuilder<ModelRoot> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400010A")]
			public YMQXVRQNJLQ[] persistenceViewDatas;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400010B")]
			public HAHYOVHKCDQ dependencies;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400010C")]
			public XDSPFZNLMNK progress;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400010D")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400010E")]
			public KDUQLYDWETD[] nodeInfos;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400010F")]
			private IBHOQKYRCJB.ProfileSection <_exportSection>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x4000110")]
			private YMQXVRQNJLQ[] <views>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x4000111")]
			private ExportContext <ctx>5__4;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
			[Cpp2IlInjected.Token(Token = "0x4000112")]
			private NodeBuilder[] <allNodes>5__5;

			[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
			[Cpp2IlInjected.Token(Token = "0x4000113")]
			private bool[] <created>5__6;

			[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
			[Cpp2IlInjected.Token(Token = "0x4000114")]
			private IBHOQKYRCJB.ProfileSection <>7__wrap6;

			[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
			[Cpp2IlInjected.Token(Token = "0x4000115")]
			private NodeBuilder <shapeRootNode>5__8;

			[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
			[Cpp2IlInjected.Token(Token = "0x4000116")]
			private bool <madeProgress>5__9;

			[Cpp2IlInjected.FieldOffset(Offset = "0xFC")]
			[Cpp2IlInjected.Token(Token = "0x4000117")]
			private int <i>5__10;

			[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
			[Cpp2IlInjected.Token(Token = "0x4000118")]
			private TaskAwaiter<bool> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
			[Cpp2IlInjected.Token(Token = "0x4000119")]
			private TaskAwaiter <>u__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
			[Cpp2IlInjected.Token(Token = "0x400011A")]
			private object <>u__3;

			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x9835C60", Offset = "0x9834660", VA = "0x189835C60", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x9837720", Offset = "0x9836120", VA = "0x189837720", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200001D")]
		[CompilerGenerated]
		private struct <ProcessShapesForNode>d__7 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400011B")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400011C")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400011D")]
			public YMQXVRQNJLQ pv;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400011E")]
			public ExportContext ctx;

			[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
			[Cpp2IlInjected.Token(Token = "0x400011F")]
			public NodeBuilder containerNode;

			[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
			[Cpp2IlInjected.Token(Token = "0x4000120")]
			private int <shapeCountInContainer>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
			[Cpp2IlInjected.Token(Token = "0x4000121")]
			private float3 <containerScale>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
			[Cpp2IlInjected.Token(Token = "0x4000122")]
			private int <shapeIndex>5__4;

			[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
			[Cpp2IlInjected.Token(Token = "0x4000123")]
			private TaskAwaiter<bool> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x9837790", Offset = "0x9836190", VA = "0x189837790", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x9838340", Offset = "0x9836D40", VA = "0x189838340", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200001E")]
		[CompilerGenerated]
		private struct <WriteGlbModel>d__6 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000124")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000125")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000126")]
			public XDSPFZNLMNK progress;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000127")]
			public ModelRoot model;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000128")]
			public Stream output;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000129")]
			private object <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x98383A0", Offset = "0x9836DA0", VA = "0x1898383A0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x9838710", Offset = "0x9837110", VA = "0x189838710", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x9831C60", Offset = "0x9830660", VA = "0x189831C60")]
		public static bool EJMYKALCOGZ(YMQXVRQNJLQ? a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x9831E40", Offset = "0x9830840", VA = "0x189831E40")]
		public static bool GPYPUEZINCJ(YMQXVRQNJLQ? a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x9831D20", Offset = "0x9830720", VA = "0x189831D20")]
		private static bool FOFHLZTBBYJ(YMQXVRQNJLQ? a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x9833BC0", Offset = "0x98325C0", VA = "0x189833BC0")]
		[AsyncStateMachine(typeof(<BuildR1GlbModel>d__3))]
		public static Task<ModelRoot> YZQFLRQAJZT(YMQXVRQNJLQ[] a, HAHYOVHKCDQ b, [Optional] XDSPFZNLMNK? progress, [Optional] CancellationToken c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x9831AE0", Offset = "0x98304E0", VA = "0x189831AE0")]
		[AsyncStateMachine(typeof(<BuildR2GlbModel>d__5))]
		public static Task<ModelRoot> AWXHBXGTUTG(YMQXVRQNJLQ[] a, KDUQLYDWETD[] b, HAHYOVHKCDQ c, [Optional] XDSPFZNLMNK? progress, [Optional] CancellationToken d)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x9833AB0", Offset = "0x98324B0", VA = "0x189833AB0")]
		[AsyncStateMachine(typeof(<WriteGlbModel>d__6))]
		public static Task WriteGlbModel(ModelRoot model, Stream output, [Optional] XDSPFZNLMNK? progress)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x9833120", Offset = "0x9831B20", VA = "0x189833120")]
		[AsyncStateMachine(typeof(<ProcessShapesForNode>d__7))]
		private static Task PLFSLLPHOWC(NodeBuilder a, YMQXVRQNJLQ b, ExportContext c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x9832450", Offset = "0x9830E50", VA = "0x189832450")]
		private static MeshBuilder<MaterialBuilder, VertexPositionNormal, VertexTexture1, VertexEmpty> KLVZLWBKVSA(PrimitiveShapeMeshType a, string b, ShapeColor c, ShapeMaterial d, float e, float3 f, bool g, float h, float3 i, ExportContext j)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x9832A50", Offset = "0x9831450", VA = "0x189832A50")]
		private static MaterialBuilder NFIHYPWZAWY(ShapeColor a, ShapeMaterial b, ExportContext c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x9833A20", Offset = "0x9832420", VA = "0x189833A20")]
		private static float UUWNEZBGXZW(float a)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x9833270", Offset = "0x9831C70", VA = "0x189833270")]
		private static MeshBuilder<MaterialBuilder, VertexPositionNormal, VertexTexture1, VertexEmpty> QSDWYEORUZT(string a, TIREOSLVZXD b, MaterialBuilder c, [Optional] float2[]? perCornerUvs)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x9832030", Offset = "0x9830A30", VA = "0x189832030")]
		[CompilerGenerated]
		internal static NodeBuilder JONDZJKVZXE(ExportContext a, NodeBuilder b, YMQXVRQNJLQ c)
		{
			return null;
		}
	}
}
namespace RecRoom.ExportTools.Internal
{
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	internal static class EJIDFQZSNMY
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x9831550", Offset = "0x982FF50", VA = "0x189831550")]
		public static bool ZDPCYGMAPWN(PrimitiveShapeMeshType a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x9830F70", Offset = "0x982F970", VA = "0x189830F70")]
		public static void CTOZDXQLUCZ(PrimitiveShapeMeshType a, float3 b, BevelConfig c, [Out] float3 d, [Out] float e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x9831270", Offset = "0x982FC70", VA = "0x189831270")]
		public static TIREOSLVZXD DZPZOHHFYEQ(TIREOSLVZXD a, PrimitiveShapeMeshType b, float3 c, float d)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	internal static class PVANUOORZNY
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x9834530", Offset = "0x9832F30", VA = "0x189834530")]
		public static Vector3 GZFHCIWWAWA(float3 a)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x9834570", Offset = "0x9832F70", VA = "0x189834570")]
		public static Quaternion PQPMTJEVUJP(quaternion a)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x8C2F580", Offset = "0x8C2DF80", VA = "0x188C2F580")]
		public static Vector3 JDAWDQOSYRF(float3 a)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x9834530", Offset = "0x9832F30", VA = "0x189834530")]
		public static Vector3 RDFVZFTNUYA(float3 a)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x9834350", Offset = "0x9832D50", VA = "0x189834350")]
		public static quaternion CNBJJIGNWLF(float3 a)
		{
			return default(quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x9834400", Offset = "0x9832E00", VA = "0x189834400")]
		public static quaternion GAMTMLZXDFU(TransformData a)
		{
			return default(quaternion);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	internal static class VSSGYXXHBOL
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x9838870", Offset = "0x9837270", VA = "0x189838870")]
		public static Guid TPCZVPEOOMH(ByteString? a)
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x98389A0", Offset = "0x98373A0", VA = "0x1898389A0")]
		public static string WXXKFIMVBJX(ByteString? self)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	internal static class HZQNMNJMZBP
	{
		[Cpp2IlInjected.Token(Token = "0x400012A")]
		public static readonly PrimitiveShapeMeshType[] XGMLYSDEOBM;

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x98319A0", Offset = "0x98303A0", VA = "0x1898319A0")]
		public static PrimitiveShapeMeshType XQAGRHRTNOP(ShapeType a)
		{
			return default(PrimitiveShapeMeshType);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	internal static class ALVQNMKAQCF
	{
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x982D560", Offset = "0x982BF60", VA = "0x18982D560")]
		public static string LPFKITGOKEI(string a, Dictionary<string, int> b)
		{
			return null;
		}
	}
}
namespace RecRoom.ExportTools.Internal.ShapeExport
{
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	internal static class RQGGTOSAZBM
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x9834AA0", Offset = "0x98334A0", VA = "0x189834AA0")]
		public static TIREOSLVZXD YYEIVGXYEKI(PrimitiveShapeMeshType a, float3 b, float c, HAHYOVHKCDQ d, Dictionary<PrimitiveShapeMeshType, TIREOSLVZXD?> primitiveMeshCache)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x98345E0", Offset = "0x9832FE0", VA = "0x1898345E0")]
		public static float2[] VLOYBRPMGVS(TIREOSLVZXD a, float3 b, bool c, float d, float e, float3 f)
		{
			return null;
		}
	}
}
namespace RecRoom.ExportTools.Internal.CurveExport
{
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	internal static class ZQKRHFYREHD
	{
		[Cpp2IlInjected.Token(Token = "0x400012B")]
		public static readonly float3 ESSEHLULBVC;

		[Cpp2IlInjected.Token(Token = "0x400012C")]
		public static readonly float3 DAQNWSZRZKO;

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x983A8E0", Offset = "0x98392E0", VA = "0x18983A8E0")]
		public static float3 EBATBZZFJZR(quaternion a)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x983B450", Offset = "0x9839E50", VA = "0x18983B450")]
		public static float3 VWBQSCWJRYR(quaternion a)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x983B230", Offset = "0x9839C30", VA = "0x18983B230")]
		public static quaternion SSZKZXZMHVJ(float3 a, float3 b)
		{
			return default(quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x983B2B0", Offset = "0x9839CB0", VA = "0x18983B2B0")]
		public static float USDSIUDFQLX(float3 a, float3 b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x983B9E0", Offset = "0x983A3E0", VA = "0x18983B9E0")]
		public static float YHXZHDLRAAT(float3 a, float3 b, float3 c)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x983A4D0", Offset = "0x9838ED0", VA = "0x18983A4D0")]
		public static float3 BLDVZUBNIWW(float3 a, float3 b, float3 c)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x983ABF0", Offset = "0x98395F0", VA = "0x18983ABF0")]
		public static quaternion JIBTHYVGJLM(quaternion a, float3 b)
		{
			return default(quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x983AA90", Offset = "0x9839490", VA = "0x18983AA90")]
		public static bool JGEVFYCWHPS(float3 a, float3 b, [Out] float3 c, bool d)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x983B600", Offset = "0x983A000", VA = "0x18983B600")]
		public static float3 XQIKHMDPCQR(bool a, [Optional] quaternion b)
		{
			return default(float3);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	internal static class XUTDVADEOGN
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x9838A00", Offset = "0x9837400", VA = "0x189838A00")]
		public static TIREOSLVZXD DUEAWZZMLJY(CurveShapeData a, ShapeType b, int c, float d, float3 e, float f, float g)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x983A3C0", Offset = "0x9838DC0", VA = "0x18983A3C0")]
		private static void VXTYIQLNYQW(float3[] a, float3[] b, float2[] c, int d, float3 e, float3 f, float3 g, float h, bool i, float j)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x9839F80", Offset = "0x9838980", VA = "0x189839F80")]
		private static void TLNZSWIQJAX(ExportCurvePointData a, ExportRingSegment b, float3[] c, float3[] d, float2[] e, int f, float g, float h, float i, float3 j, float k)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x9839930", Offset = "0x9838330", VA = "0x189839930")]
		private static void JUBVOBIWGGZ(ExportRingSegment a, float3[] b, float3[] c, float2[] d, int[] e, int f, int g, float3 h, float3x3 i, bool j, float k, int l, bool m, float n, float o, float3 p, float q)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	internal struct ExportCurvePointData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400012D")]
		public float3 Position;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x400012E")]
		public float3x3 Rotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400012F")]
		public float Radius;
	}
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	internal static class BQVIFYNNSYY
	{
		[Cpp2IlInjected.Token(Token = "0x2000029")]
		private struct PointSrcData
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000130")]
			public float3 Position;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
			[Cpp2IlInjected.Token(Token = "0x4000131")]
			public quaternion Rotation;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
			[Cpp2IlInjected.Token(Token = "0x4000132")]
			public float Radius;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000133")]
			public quaternion BlendedRotation;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000134")]
			public float BendAngle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
			[Cpp2IlInjected.Token(Token = "0x4000135")]
			public float BendRadius;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000136")]
			public float DistanceToNext;
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x982F110", Offset = "0x982DB10", VA = "0x18982F110")]
		public static List<ExportCurvePointData> Generate(IReadOnlyList<float3> positions, IReadOnlyList<float3> normals, IReadOnlyList<float> radii, int configFlags, float heightScale)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x982D640", Offset = "0x982C040", VA = "0x18982D640")]
		private static void BYCUEHDGLRB(IReadOnlyList<float3> a, float3[] b, int c, bool d, bool e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x982FF20", Offset = "0x982E920", VA = "0x18982FF20")]
		private static float3 RMRKJOLXRKX(IReadOnlyList<float3> a, float3[] b, int c, int d, bool e, bool f, quaternion g)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x98301B0", Offset = "0x982EBB0", VA = "0x1898301B0")]
		private static List<ExportCurvePointData> TBRDPPNTEWT(List<PointSrcData> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x982D760", Offset = "0x982C160", VA = "0x18982D760")]
		private static bool DMNLFUGWFNA(int a, List<ExportCurvePointData> b, List<PointSrcData> c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x982F990", Offset = "0x982E390", VA = "0x18982F990")]
		private static ExportCurvePointData QGTNFAFUVWC(int a, List<PointSrcData> b)
		{
			return default(ExportCurvePointData);
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x982E400", Offset = "0x982CE00", VA = "0x18982E400")]
		private static List<ExportCurvePointData> FNVXLRAROPD(List<PointSrcData> a, float b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x982F8D0", Offset = "0x982E2D0", VA = "0x18982F8D0")]
		private static ExportCurvePointData NQIRVNAYIPY(PointSrcData a)
		{
			return default(ExportCurvePointData);
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x982F840", Offset = "0x982E240", VA = "0x18982F840")]
		private static ExportCurvePointData MKYDPLSBSCL(float3 a, quaternion b, float c)
		{
			return default(ExportCurvePointData);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	internal struct ExportRingVertex
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000137")]
		public float2 Offset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000138")]
		public float2 Normal;
	}
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	internal struct ExportRingSegment
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000139")]
		public ExportRingVertex[] RingVerts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400013A")]
		public int[] RingIndices;
	}
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	internal static class BZONMELLFRE
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x9830B70", Offset = "0x982F570", VA = "0x189830B70")]
		public static ExportRingSegment ZMCUVDREANH(int a)
		{
			return default(ExportRingSegment);
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x9830590", Offset = "0x982EF90", VA = "0x189830590")]
		public static ExportRingSegment MDNOVOHVSEW(int a)
		{
			return default(ExportRingSegment);
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x9830B40", Offset = "0x982F540", VA = "0x189830B40")]
		public static ExportRingSegment VNCWCFSIQVN()
		{
			return default(ExportRingSegment);
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x9830AE0", Offset = "0x982F4E0", VA = "0x189830AE0")]
		public static int ULPBHGNXMON(int a, int b, bool c, bool d, bool e)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x9830540", Offset = "0x982EF40", VA = "0x189830540")]
		public static int JCYDRNCJMTR(int a, int b, bool c, bool d, bool e)
		{
			return default(int);
		}
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
