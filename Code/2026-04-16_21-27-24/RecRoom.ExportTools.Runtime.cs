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
		[Cpp2IlInjected.Address(RVA = "0xD0FDB0", Offset = "0xD0EBB0", VA = "0x180D0FDB0")]
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
		[Cpp2IlInjected.Address(RVA = "0x981B510", Offset = "0x981A310", VA = "0x18981B510")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xD10080", Offset = "0xD0EE80", VA = "0x180D10080")]
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
		[Cpp2IlInjected.Address(RVA = "0xD100C0", Offset = "0xD0EEC0", VA = "0x180D100C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x2B654C0", Offset = "0x2B642C0", VA = "0x182B654C0")]
		public ColorRGB(float r, float g, float b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public class CKHQFNSXZSC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public string VQRUGTSIEYC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public MaterialColorUsage NSJYCUQICUD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public ColorRGB FQDOSDSKRYQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public ColorRGB OOGZVRKKDQZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public ColorRGB QIMWDSQTAWP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public float CNLFQEJQYOB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public NQDQQTWUYEG? UIUHWYMHXVK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public NQDQQTWUYEG? LNBMGWNGMNT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public NQDQQTWUYEG? AVEWYGYKEFH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public NQDQQTWUYEG? CBNCWKVRLYD;

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x9816950", Offset = "0x9815750", VA = "0x189816950")]
		public CKHQFNSXZSC()
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
		[Cpp2IlInjected.Address(RVA = "0xEAF980", Offset = "0xEAE780", VA = "0x180EAF980")]
		public MaterialExportKey(ShapeColor shapeColor, ShapeMaterial shapeMaterial)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x1424AD0", Offset = "0x14238D0", VA = "0x181424AD0", Slot = "4")]
		public bool Equals(MaterialExportKey other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x981AF60", Offset = "0x9819D60", VA = "0x18981AF60", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x981AFF0", Offset = "0x9819DF0", VA = "0x18981AFF0", Slot = "2")]
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
		[Cpp2IlInjected.Address(RVA = "0x981B450", Offset = "0x981A250", VA = "0x18981B450")]
		public MeshBuilderCacheKey(PrimitiveShapeMeshType meshType, MaterialExportKey material, [Optional] float3 bevelScalingRatio, float bevelAuthoredRatio = 0f, [Optional] float3 worldScale, bool dynamicProjection = false, float containerScaleX = 0f, float uvScale = 0f, [Optional] float3 uvOffset)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x981B060", Offset = "0x9819E60", VA = "0x18981B060", Slot = "4")]
		public bool Equals(MeshBuilderCacheKey other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x981B1F0", Offset = "0x9819FF0", VA = "0x18981B1F0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x981B2B0", Offset = "0x981A0B0", VA = "0x18981B2B0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public class GHMDNJNUTEU
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public float3[] MUESSYFOZDA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		public int[] MLXYNQEOJWW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public float3[] BMXFSTVLRAD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		public float2[]? JWXVQGHFPUD;

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x1117370", Offset = "0x1116170", VA = "0x181117370")]
		public GHMDNJNUTEU(float3[] a, int[] b, float3[] c, [Optional] float2[]? uvs)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public class NQDQQTWUYEG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public string LGPZHFPCQSX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public ImageBuilder? TVEDHTRQYXY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public float2 VFZFKOJRRKG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		public float2 XGEMPETLZEZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		public TextureWrapMode ATODAPHUOMR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		public TextureWrapMode ASYIIVACMEQ;

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x981B4C0", Offset = "0x981A2C0", VA = "0x18981B4C0")]
		public NQDQQTWUYEG()
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
	public static class HVQLIMMZRNY
	{
		[Cpp2IlInjected.Token(Token = "0x2000013")]
		public struct ProfileSession : IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000E8")]
			private readonly string? _outputPath;

			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x981B6A0", Offset = "0x981A4A0", VA = "0x18981B6A0")]
			internal ProfileSession(string? outputPath)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0xCE6150", Offset = "0xCE4F50", VA = "0x180CE6150", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x981B690", Offset = "0x981A490", VA = "0x18981B690")]
			internal ProfileSection(string name)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0xCE6150", Offset = "0xCE4F50", VA = "0x180CE6150", Slot = "4")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0xCE6160", Offset = "0xCE4F60", VA = "0x180CE6160")]
		public static ProfileSession AZAFAXRXEYK(string? a)
		{
			return default(ProfileSession);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x18191D0", Offset = "0x1817FD0", VA = "0x1818191D0")]
		internal static ProfileSection Section(string name)
		{
			return default(ProfileSection);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public class MJATFEMGJMI
	{
		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public string? CTZDLOJAEUK
		{
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0xCE77B0", Offset = "0xCE65B0", VA = "0x180CE77B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0xCE77C0", Offset = "0xCE65C0", VA = "0x180CE77C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public int? HIKMGJZQPLV
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0xCE7B30", Offset = "0xCE6930", VA = "0x180CE7B30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0xDDD2F0", Offset = "0xDDC0F0", VA = "0x180DDD2F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
		public MJATFEMGJMI()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public interface ADMWIPYDBOF
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		GHMDNJNUTEU? JHXTUPPVISB(PrimitiveShapeMeshType a, int b = 0);

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		BevelConfig DZEMQYGEMDB();

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(Slot = "2")]
		CKHQFNSXZSC? GetMaterialExportData(ShapeColor shapeColor, ShapeMaterial shapeMaterial);

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(Slot = "3")]
		bool NIESACJLCQX(Guid a, [Out] string b);
	}
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public static class MSWEODUYACW
	{
		[Cpp2IlInjected.Token(Token = "0x2000018")]
		public static class DNCLIQEOPAS
		{
			[Cpp2IlInjected.Token(Token = "0x2000019")]
			public static class POHXRHRABSA
			{
				[Cpp2IlInjected.Token(Token = "0x40000EE")]
				public static readonly Guid NEYTWPYFVEO;

				[Cpp2IlInjected.Token(Token = "0x40000EF")]
				public static readonly Guid GDJRSKEDMNK;
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
			public readonly ADMWIPYDBOF Dependencies;

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
			public readonly Dictionary<PrimitiveShapeMeshType, GHMDNJNUTEU?> PrimitiveMeshCache;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40000F6")]
			public readonly Dictionary<MeshBuilderCacheKey, MeshBuilder<MaterialBuilder, VertexPositionNormal, VertexTexture1, VertexEmpty>> MeshBuilderCache;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40000F7")]
			public readonly BNUDEUJRXJV? Progress;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x40000F8")]
			public readonly IPVFOJQFFNA TimedYielder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x40000F9")]
			public readonly CancellationToken CancellationToken;

			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x9816D00", Offset = "0x9815B00", VA = "0x189816D00")]
			private ExportContext(SceneBuilder sceneBuilder, ADMWIPYDBOF dependencies, BevelConfig bevelConfig, Dictionary<string, int> nodeNameToCountMap, Dictionary<MaterialExportKey, MaterialBuilder> materialCache, Dictionary<PrimitiveShapeMeshType, GHMDNJNUTEU?> primitiveMeshCache, Dictionary<MeshBuilderCacheKey, MeshBuilder<MaterialBuilder, VertexPositionNormal, VertexTexture1, VertexEmpty>> meshBuilderCache, BNUDEUJRXJV? progress, IPVFOJQFFNA timedYielder, CancellationToken cancellationToken)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x98169A0", Offset = "0x98157A0", VA = "0x1898169A0")]
			public static ExportContext New(ADMWIPYDBOF dependencies, BNUDEUJRXJV? progress, CancellationToken cancellationToken)
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
			public PBCTZJZFZQR[] persistenceViewDatas;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000FD")]
			public ADMWIPYDBOF dependencies;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000FE")]
			public BNUDEUJRXJV progress;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40000FF")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000100")]
			private HVQLIMMZRNY.ProfileSection <_exportSection>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4000101")]
			private ExportContext <ctx>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
			[Cpp2IlInjected.Token(Token = "0x4000102")]
			private Queue<(NodeBuilder parentNode, PBCTZJZFZQR data)> <queue>5__4;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
			[Cpp2IlInjected.Token(Token = "0x4000103")]
			private PBCTZJZFZQR <pv>5__5;

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
			[Cpp2IlInjected.Address(RVA = "0x981BD10", Offset = "0x981AB10", VA = "0x18981BD10", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x981CCC0", Offset = "0x981BAC0", VA = "0x18981CCC0", Slot = "5")]
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
			public PBCTZJZFZQR[] persistenceViewDatas;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400010B")]
			public ADMWIPYDBOF dependencies;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400010C")]
			public BNUDEUJRXJV progress;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400010D")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400010E")]
			public MJATFEMGJMI[] nodeInfos;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400010F")]
			private HVQLIMMZRNY.ProfileSection <_exportSection>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x4000110")]
			private PBCTZJZFZQR[] <views>5__3;

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
			private HVQLIMMZRNY.ProfileSection <>7__wrap6;

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
			[Cpp2IlInjected.Address(RVA = "0x981CD30", Offset = "0x981BB30", VA = "0x18981CD30", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x981E7F0", Offset = "0x981D5F0", VA = "0x18981E7F0", Slot = "5")]
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
			public PBCTZJZFZQR pv;

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
			[Cpp2IlInjected.Address(RVA = "0x981E860", Offset = "0x981D660", VA = "0x18981E860", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x981F410", Offset = "0x981E210", VA = "0x18981F410", Slot = "5")]
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
			public BNUDEUJRXJV progress;

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
			[Cpp2IlInjected.Address(RVA = "0x981F470", Offset = "0x981E270", VA = "0x18981F470", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x981F7E0", Offset = "0x981E5E0", VA = "0x18981F7E0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x981AEA0", Offset = "0x9819CA0", VA = "0x18981AEA0")]
		public static bool YIJPLXKEOCU(PBCTZJZFZQR? a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x98191B0", Offset = "0x9817FB0", VA = "0x1898191B0")]
		public static bool KGNZSLPVPWQ(PBCTZJZFZQR? a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x9818D20", Offset = "0x9817B20", VA = "0x189818D20")]
		private static bool FJJOQSHLRXI(PBCTZJZFZQR? a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x9818FC0", Offset = "0x9817DC0", VA = "0x189818FC0")]
		[AsyncStateMachine(typeof(<BuildR1GlbModel>d__3))]
		public static Task<ModelRoot> IIAXAJFXHKW(PBCTZJZFZQR[] a, ADMWIPYDBOF b, [Optional] BNUDEUJRXJV? progress, [Optional] CancellationToken c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x9818E40", Offset = "0x9817C40", VA = "0x189818E40")]
		[AsyncStateMachine(typeof(<BuildR2GlbModel>d__5))]
		public static Task<ModelRoot> ICMALBLCMMH(PBCTZJZFZQR[] a, MJATFEMGJMI[] b, ADMWIPYDBOF c, [Optional] BNUDEUJRXJV? progress, [Optional] CancellationToken d)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x981AD90", Offset = "0x9819B90", VA = "0x18981AD90")]
		[AsyncStateMachine(typeof(<WriteGlbModel>d__6))]
		public static Task WriteGlbModel(ModelRoot model, Stream output, [Optional] BNUDEUJRXJV? progress)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x981A820", Offset = "0x9819620", VA = "0x18981A820")]
		[AsyncStateMachine(typeof(<ProcessShapesForNode>d__7))]
		private static Task THIVZUGMNBR(NodeBuilder a, PBCTZJZFZQR b, ExportContext c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x98193A0", Offset = "0x98181A0", VA = "0x1898193A0")]
		private static MeshBuilder<MaterialBuilder, VertexPositionNormal, VertexTexture1, VertexEmpty> KINRFDTVUIP(PrimitiveShapeMeshType a, string b, ShapeColor c, ShapeMaterial d, float e, float3 f, bool g, float h, float3 i, ExportContext j)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x98199A0", Offset = "0x98187A0", VA = "0x1898199A0")]
		private static MaterialBuilder KKXTWVSBUED(ShapeColor a, ShapeMaterial b, ExportContext c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x9819120", Offset = "0x9817F20", VA = "0x189819120")]
		private static float IOUZSHNDZRD(float a)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x981A070", Offset = "0x9818E70", VA = "0x18981A070")]
		private static MeshBuilder<MaterialBuilder, VertexPositionNormal, VertexTexture1, VertexEmpty> KYACMQRLSZA(string a, GHMDNJNUTEU b, MaterialBuilder c, [Optional] float2[]? perCornerUvs)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x981A970", Offset = "0x9819770", VA = "0x18981A970")]
		[CompilerGenerated]
		internal static NodeBuilder VILXCIYWATL(ExportContext a, NodeBuilder b, PBCTZJZFZQR c)
		{
			return null;
		}
	}
}
namespace RecRoom.ExportTools.Internal
{
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	internal static class KWXFTHBBZLJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x9818C20", Offset = "0x9817A20", VA = "0x189818C20")]
		public static bool PXJJUXERPXM(PrimitiveShapeMeshType a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x9818920", Offset = "0x9817720", VA = "0x189818920")]
		public static void LVFNSFKENQI(PrimitiveShapeMeshType a, float3 b, BevelConfig c, [Out] float3 d, [Out] float e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x9818640", Offset = "0x9817440", VA = "0x189818640")]
		public static GHMDNJNUTEU JAVCNFEKIEV(GHMDNJNUTEU a, PrimitiveShapeMeshType b, float3 c, float d)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	internal static class ATYRCIEFNZH
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x9815D00", Offset = "0x9814B00", VA = "0x189815D00")]
		public static Vector3 SLDQTZDODKP(float3 a)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x9815F20", Offset = "0x9814D20", VA = "0x189815F20")]
		public static Quaternion VBJYZLLOBKS(quaternion a)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x8C14190", Offset = "0x8C12F90", VA = "0x188C14190")]
		public static Vector3 UYZLVIDUAIW(float3 a)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x9815D00", Offset = "0x9814B00", VA = "0x189815D00")]
		public static Vector3 EOAJOCMNHSH(float3 a)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x9815D40", Offset = "0x9814B40", VA = "0x189815D40")]
		public static quaternion HBQDMAVSJAI(float3 a)
		{
			return default(quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x9815DF0", Offset = "0x9814BF0", VA = "0x189815DF0")]
		public static quaternion ISIZUSLDTHL(TransformData a)
		{
			return default(quaternion);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	internal static class GSPYCNBVULE
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x98184B0", Offset = "0x98172B0", VA = "0x1898184B0")]
		public static Guid TMDUMOFHSHY(ByteString? a)
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x98185E0", Offset = "0x98173E0", VA = "0x1898185E0")]
		public static string ZJAUTLXXOMA(ByteString? self)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	internal static class VTNWHXOQLOU
	{
		[Cpp2IlInjected.Token(Token = "0x400012A")]
		public static readonly PrimitiveShapeMeshType[] TUZCFCMLANT;

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x9824210", Offset = "0x9823010", VA = "0x189824210")]
		public static PrimitiveShapeMeshType UCBBFCBUQBC(ShapeType a)
		{
			return default(PrimitiveShapeMeshType);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	internal static class LZPYPWCQBOG
	{
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x9818C40", Offset = "0x9817A40", VA = "0x189818C40")]
		public static string ONYUYKDIYQL(string a, Dictionary<string, int> b)
		{
			return null;
		}
	}
}
namespace RecRoom.ExportTools.Internal.ShapeExport
{
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	internal static class QLJORNZSJUR
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x981B6B0", Offset = "0x981A4B0", VA = "0x18981B6B0")]
		public static GHMDNJNUTEU CKBJXCKFRZP(PrimitiveShapeMeshType a, float3 b, float c, ADMWIPYDBOF d, Dictionary<PrimitiveShapeMeshType, GHMDNJNUTEU?> primitiveMeshCache)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x981B850", Offset = "0x981A650", VA = "0x18981B850")]
		public static float2[] FNAQZAWMJDD(GHMDNJNUTEU a, float3 b, bool c, float d, float e, float3 f)
		{
			return null;
		}
	}
}
namespace RecRoom.ExportTools.Internal.CurveExport
{
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	internal static class GRSMXKNDFHQ
	{
		[Cpp2IlInjected.Token(Token = "0x400012B")]
		public static readonly float3 SSEFFWMUGNJ;

		[Cpp2IlInjected.Token(Token = "0x400012C")]
		public static readonly float3 ZBNSVHLVUAT;

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x9817D50", Offset = "0x9816B50", VA = "0x189817D50")]
		public static float3 PAWJEXEVIFQ(quaternion a)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x9818280", Offset = "0x9817080", VA = "0x189818280")]
		public static float3 WEFOWFVCHXY(quaternion a)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x9817F00", Offset = "0x9816D00", VA = "0x189817F00")]
		public static quaternion SVMCNBIWFMY(float3 a, float3 b)
		{
			return default(quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x98180E0", Offset = "0x9816EE0", VA = "0x1898180E0")]
		public static float TBRTDIRGBOM(float3 a, float3 b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x9817C00", Offset = "0x9816A00", VA = "0x189817C00")]
		public static float OBLBMCQKIIE(float3 a, float3 b, float3 c)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x98171B0", Offset = "0x9815FB0", VA = "0x1898171B0")]
		public static float3 GKJZBPTRPIT(float3 a, float3 b, float3 c)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x98175C0", Offset = "0x98163C0", VA = "0x1898175C0")]
		public static quaternion LOVCCOHRXOL(quaternion a, float3 b)
		{
			return default(quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x9817F80", Offset = "0x9816D80", VA = "0x189817F80")]
		public static bool SXZAYAHAXYH(float3 a, float3 b, [Out] float3 c, bool d)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x9816DD0", Offset = "0x9815BD0", VA = "0x189816DD0")]
		public static float3 CASIBAUPLZA(bool a, [Optional] quaternion b)
		{
			return default(float3);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	internal static class UIZOGLZGSKM
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x981F840", Offset = "0x981E640", VA = "0x18981F840")]
		public static GHMDNJNUTEU ITCFODKGFCX(CurveShapeData a, ShapeType b, int c, float d, float3 e, float f, float g)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x9820DC0", Offset = "0x981FBC0", VA = "0x189820DC0")]
		private static void NTUKHBNCEJB(float3[] a, float3[] b, float2[] c, int d, float3 e, float3 f, float3 g, float h, bool i, float j)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x9820ED0", Offset = "0x981FCD0", VA = "0x189820ED0")]
		private static void WIBNBLSMGAM(ExportCurvePointData a, ExportRingSegment b, float3[] c, float3[] d, float2[] e, int f, float g, float h, float i, float3 j, float k)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x9820770", Offset = "0x981F570", VA = "0x189820770")]
		private static void LLFFLMFZQGG(ExportRingSegment a, float3[] b, float3[] c, float2[] d, int[] e, int f, int g, float3 h, float3x3 i, bool j, float k, int l, bool m, float n, float o, float3 p, float q)
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
	internal static class VQRQWZJGIVR
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
		[Cpp2IlInjected.Address(RVA = "0x9822F50", Offset = "0x9821D50", VA = "0x189822F50")]
		public static List<ExportCurvePointData> Generate(IReadOnlyList<float3> positions, IReadOnlyList<float3> normals, IReadOnlyList<float> radii, int configFlags, float heightScale)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x9824030", Offset = "0x9822E30", VA = "0x189824030")]
		private static void XAYAMVPYELC(IReadOnlyList<float3> a, float3[] b, int c, bool d, bool e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x9822CC0", Offset = "0x9821AC0", VA = "0x189822CC0")]
		private static float3 EYMBOVELGWA(IReadOnlyList<float3> a, float3[] b, int c, int d, bool e, bool f, quaternion g)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x9823710", Offset = "0x9822510", VA = "0x189823710")]
		private static List<ExportCurvePointData> NKNOQNGHCWK(List<PointSrcData> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x9822020", Offset = "0x9820E20", VA = "0x189822020")]
		private static bool EFXWTWFXNSL(int a, List<ExportCurvePointData> b, List<PointSrcData> c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x9823AA0", Offset = "0x98228A0", VA = "0x189823AA0")]
		private static ExportCurvePointData VGJJWLZFDDN(int a, List<PointSrcData> b)
		{
			return default(ExportCurvePointData);
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x9821310", Offset = "0x9820110", VA = "0x189821310")]
		private static List<ExportCurvePointData> ANZLZZWJVGK(List<PointSrcData> a, float b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x9824150", Offset = "0x9822F50", VA = "0x189824150")]
		private static ExportCurvePointData ZOXNLZIFTRV(PointSrcData a)
		{
			return default(ExportCurvePointData);
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x9823680", Offset = "0x9822480", VA = "0x189823680")]
		private static ExportCurvePointData LHJQSYGDNJI(float3 a, quaternion b, float c)
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
	internal static class CCMPQGVQHVB
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x9816050", Offset = "0x9814E50", VA = "0x189816050")]
		public static ExportRingSegment EROYCQZEVLU(int a)
		{
			return default(ExportRingSegment);
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x9816400", Offset = "0x9815200", VA = "0x189816400")]
		public static ExportRingSegment FVAPSNMZDZX(int a)
		{
			return default(ExportRingSegment);
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x9815F70", Offset = "0x9814D70", VA = "0x189815F70")]
		public static ExportRingSegment AONEWLWHJXK()
		{
			return default(ExportRingSegment);
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x9815FF0", Offset = "0x9814DF0", VA = "0x189815FF0")]
		public static int EPZVEPTFZMI(int a, int b, bool c, bool d, bool e)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x9815FA0", Offset = "0x9814DA0", VA = "0x189815FA0")]
		public static int DLBQBPSNMMY(int a, int b, bool c, bool d, bool e)
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
