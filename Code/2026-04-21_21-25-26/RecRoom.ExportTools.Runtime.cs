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
		[Cpp2IlInjected.Address(RVA = "0xD39E50", Offset = "0xD38850", VA = "0x180D39E50")]
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
		[Cpp2IlInjected.Address(RVA = "0x999CC30", Offset = "0x999B630", VA = "0x18999CC30")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xD3A120", Offset = "0xD38B20", VA = "0x180D3A120")]
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
		[Cpp2IlInjected.Address(RVA = "0xD3A160", Offset = "0xD38B60", VA = "0x180D3A160")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
namespace RecRoom.ExportTools
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public static class RLWZXWVREJC
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x999D490", Offset = "0x999BE90", VA = "0x18999D490")]
		public static ModelRoot BuildAvatarGlbModel(string sceneName, CDXZADPTJZP[] nodes)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x999DB50", Offset = "0x999C550", VA = "0x18999DB50")]
		private static MaterialBuilder KKXTWVSBUED(DEEFRTOCULD? matData, Dictionary<DEEFRTOCULD, MaterialBuilder> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x999D430", Offset = "0x999BE30", VA = "0x18999D430")]
		private static ImageBuilder? BHTHJILBYXI(byte[]? a, string name)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x999DAC0", Offset = "0x999C4C0", VA = "0x18999DAC0")]
		private static float IOUZSHNDZRD(float a)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x999E360", Offset = "0x999CD60", VA = "0x18999E360")]
		private static IMeshBuilder<MaterialBuilder> KYACMQRLSZA(string a, GHMDNJNUTEU b, MaterialBuilder c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x999EAD0", Offset = "0x999D4D0", VA = "0x18999EAD0")]
		private static MeshBuilder<MaterialBuilder, VertexPositionNormal, VertexTexture2, VertexEmpty> ZKDOOKYUPTZ(string a, GHMDNJNUTEU b, MaterialBuilder c)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public class DEEFRTOCULD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		public string CTZDLOJAEUK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		public ColorRGB UVHRLBAMABR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		public float QSFGNGFMNON;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		public byte[]? WNIHRNHOESV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		public int TFPYLARNZZZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public bool TJRHMAEIZKB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public byte[]? EIFUTUQVQHC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public float ZZXSUAURSDG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public ColorRGB OOGZVRKKDQZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public byte[]? RDMPMKXINVO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public float TGLCHKVKAOI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public float VZROLSFMYKF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public byte[]? APNAYWALDZS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public bool UEVJNGMYQUX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public float? JKCDKBRSTKK;

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x9998010", Offset = "0x9996A10", VA = "0x189998010")]
		public DEEFRTOCULD()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public class CDXZADPTJZP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public string CTZDLOJAEUK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public float3 RIRFUTNLMYH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public quaternion JNDLMIYHMJY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public float3 ZSBTDKWBKJM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public GHMDNJNUTEU WSNDFSGATGI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public DEEFRTOCULD? KOSKITVPIKI;

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x9997F50", Offset = "0x9996950", VA = "0x189997F50")]
		public CDXZADPTJZP()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public struct BevelConfig
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public float SmallBevelSizeMeters;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public float BoxAuthoredBevelPercent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public float WedgeAuthoredBevelPercent;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public float PyramidAuthoredBevelPercent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public bool BevelSizeBasedOnLargestPossibleDimension;
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public readonly struct ColorRGB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public readonly float R;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public readonly float G;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public readonly float B;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public static ColorRGB NZATEIPGBIW
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x9997FF0", Offset = "0x99969F0", VA = "0x189997FF0")]
			get
			{
				return default(ColorRGB);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public static ColorRGB YIDLOVBUORG
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x10741F0", Offset = "0x1072BF0", VA = "0x1810741F0")]
			get
			{
				return default(ColorRGB);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x2BA33B0", Offset = "0x2BA1DB0", VA = "0x182BA33B0")]
		public ColorRGB(float r, float g, float b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public class CKHQFNSXZSC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public string VQRUGTSIEYC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		public MaterialColorUsage NSJYCUQICUD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public ColorRGB FQDOSDSKRYQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		public ColorRGB OOGZVRKKDQZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public ColorRGB QIMWDSQTAWP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public float CNLFQEJQYOB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public NQDQQTWUYEG? UIUHWYMHXVK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		public NQDQQTWUYEG? LNBMGWNGMNT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		public NQDQQTWUYEG? AVEWYGYKEFH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		public NQDQQTWUYEG? CBNCWKVRLYD;

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x9997FA0", Offset = "0x99969A0", VA = "0x189997FA0")]
		public CKHQFNSXZSC()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	internal readonly struct MaterialExportKey : IEquatable<MaterialExportKey>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		public readonly ShapeColor ShapeColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		public readonly ShapeMaterial ShapeMaterial;

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0xEEA000", Offset = "0xEE8A00", VA = "0x180EEA000")]
		public MaterialExportKey(ShapeColor shapeColor, ShapeMaterial shapeMaterial)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x1451F40", Offset = "0x1450940", VA = "0x181451F40", Slot = "4")]
		public bool Equals(MaterialExportKey other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x999C680", Offset = "0x999B080", VA = "0x18999C680", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x999C710", Offset = "0x999B110", VA = "0x18999C710", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	internal readonly struct MeshBuilderCacheKey : IEquatable<MeshBuilderCacheKey>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		public readonly PrimitiveShapeMeshType MeshType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		public readonly MaterialExportKey Material;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		public readonly float3 BevelScalingRatio;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public readonly float BevelAuthoredRatio;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public readonly float3 WorldScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public readonly bool DynamicProjection;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public readonly float ContainerScaleX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public readonly float UvScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public readonly float3 UvOffset;

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x999CB70", Offset = "0x999B570", VA = "0x18999CB70")]
		public MeshBuilderCacheKey(PrimitiveShapeMeshType meshType, MaterialExportKey material, [Optional] float3 bevelScalingRatio, float bevelAuthoredRatio = 0f, [Optional] float3 worldScale, bool dynamicProjection = false, float containerScaleX = 0f, float uvScale = 0f, [Optional] float3 uvOffset)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x999C780", Offset = "0x999B180", VA = "0x18999C780", Slot = "4")]
		public bool Equals(MeshBuilderCacheKey other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x999C910", Offset = "0x999B310", VA = "0x18999C910", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x999C9D0", Offset = "0x999B3D0", VA = "0x18999C9D0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class GHMDNJNUTEU
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		public float3[] MUESSYFOZDA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public int[] MLXYNQEOJWW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public float3[] BMXFSTVLRAD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public float2[]? SHIJGKBYFAP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public float2[]? YIMDMHYVBTI;

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x8B802A0", Offset = "0x8B7ECA0", VA = "0x188B802A0")]
		public GHMDNJNUTEU(float3[] a, int[] b, float3[] c, [Optional] float2[]? uv0s, [Optional] float2[]? uv1s)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public class NQDQQTWUYEG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public string LGPZHFPCQSX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public ImageBuilder? TVEDHTRQYXY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public float2 VFZFKOJRRKG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public float2 XGEMPETLZEZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public TextureWrapMode ATODAPHUOMR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public TextureWrapMode ASYIIVACMEQ;

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x999CBE0", Offset = "0x999B5E0", VA = "0x18999CBE0")]
		public NQDQQTWUYEG()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[Flags]
	public enum MaterialColorUsage
	{
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		ALBEDO = 1,
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		EMISSIVE = 2,
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		SPECULAR = 4,
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		HOLOGRAPHIC = 8
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public enum PrimitiveShapeMeshType
	{
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		Invalid = -1,
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		RR_Box,
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		RR_Sphere,
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		RR_Cylinder,
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		RR_Wedge,
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		RR_Pyramid,
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		RR_HalfSphere,
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		RR_Cone,
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		RR_Pipe,
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		RR_Donut,
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		RR_HalfPipe,
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		RR_Diamond,
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		ADVANCED_Mound,
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		LEGACY_Box,
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		ADVANCED_Cube,
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		ADVANCED_Sphere,
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		ADVANCED_Cylinder,
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		ADVANCED_Cone,
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		ADVANCED_Pyramid,
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		ADVANCED_Octagon,
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		ADVANCED_Triangle,
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		ADVANCED_Hexagon,
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		ADVANCED_QuarterPipe,
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		ADVANCED_Pentagon,
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		ADVANCED_Dodecahedron,
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		ADVANCED_Trihedron,
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		ADVANCED_Octahedron,
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		RR_QuarterCylinder,
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		RR_Pentagon,
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		RR_QuarterSphere,
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		ADVANCED_Wedge,
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		RR_Hexagon,
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		RR_Octagon,
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		RR_Triangle,
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		Count
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public enum ShapeColor
	{
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		RED = 0,
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		ORANGE = 1,
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		YELLOW = 2,
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		GREEN = 3,
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		DARK_GREEN = 4,
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		CYAN = 5,
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		BLUE = 6,
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		DARK_BLUE = 7,
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		PURPLE = 8,
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		PINK = 9,
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		BROWN = 10,
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		WHITE = 11,
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		GREY = 12,
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		BLACK = 13,
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		DARK_ORANGE = 14,
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		LIME = 15,
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		LIGHT_GREEN = 16,
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		AQUAMARINE = 17,
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		LIGHT_BLUE = 18,
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		LAVENDER = 19,
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		MAGENTA = 20,
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		SALMON = 21,
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		TAN = 22,
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		CREAM = 23,
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		LIGHT_GREY = 24,
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		DARK_GREY = 25,
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		NEW_COLOR_0 = 26,
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		NEW_COLOR_1 = 27,
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		NEW_COLOR_2 = 28,
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		NEW_COLOR_3 = 29,
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		NEW_COLOR_4 = 30,
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		NEW_COLOR_5 = 31,
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		NEW_COLOR_6 = 32,
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		UNUSED_SEE_COMMENT = 33,
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		NEW_COLOR_7 = 34,
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		NEW_COLOR_8 = 35,
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		NEW_COLOR_9 = 36,
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		NEW_COLOR_10 = 37,
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		NEW_COLOR_11 = 38,
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		NEW_COLOR_12 = 39,
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		NEW_COLOR_13 = 40,
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		NEW_COLOR_14 = 41,
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		NEW_COLOR_15 = 42,
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		NEW_COLOR_16 = 43,
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		NEW_COLOR_17 = 44,
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		NEW_COLOR_18 = 45,
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		NEW_COLOR_19 = 46,
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		NEW_COLOR_20 = 47,
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		NEW_COLOR_21 = 48,
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		NEW_COLOR_22 = 49,
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		NEW_COLOR_23 = 50,
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		NEW_COLOR_24 = 51,
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		NEW_COLOR_25 = 52,
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		NEW_COLOR_26 = 53,
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		NEW_COLOR_27 = 54,
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		NEW_COLOR_28 = 55,
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		NEW_COLOR_29 = 56,
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		NEW_COLOR_30 = 57,
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		NEW_COLOR_31 = 58,
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		NEW_COLOR_32 = 59,
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		NEW_COLOR_33 = 60,
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		GENERATED_COLOR_START = 1000
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public enum ShapeMaterial
	{
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		INVALID = -1,
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		CARDBOARD = 0,
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		METAL = 1,
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		RUBBER = 2,
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		PLASTIC = 3,
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		NEON = 4,
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		WOOD = 5,
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		GLASS = 6,
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		ROCK = 7,
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		ICE = 8,
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		GOLD = 9,
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		SAND = 10,
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		LEATHER = 11,
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		GRID = 12,
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		TILE = 13,
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		GRASS = 14,
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		BARK = 15,
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		CONCRETE = 16,
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		SNOW = 17,
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		CARPET = 18,
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		FABRIC = 19,
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		FOIL = 20,
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		FLESH = 21,
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		GALAXY = 22,
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		LAVA = 23,
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		WATER = 24,
		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		CANDY = 25,
		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		FUR = 26,
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		CHAIN_MAIL = 27,
		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		PLACEHOLDER_14 = 28,
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		PLACEHOLDER_15 = 29,
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		PLACEHOLDER_16 = 30,
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		PLACEHOLDER_18 = 31,
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		MIN_VALUE = -1,
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		MAX_VALUE = 31,
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		COUNT = 32,
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		DEFAULT = 0
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public enum ShapeType
	{
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		Invalid = -1,
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		CURVE_Tube = 0,
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		CURVE_Ribbon = 1,
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		LegacyBox = 2,
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		RR_Sphere = 3,
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		RR_Cylinder = 4,
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		LEGACY_Wedge = 5,
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		LEGACY_Pyramid = 6,
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		LEGACY_TriggerVolumeBox = 7,
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		RR_Box = 8,
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		LEGACY_RoundedBox = 9,
		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		RR_Wedge = 10,
		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		RR_Pyramid = 11,
		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		RR_HalfSphere = 12,
		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		RR_Cone = 13,
		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		RR_Pipe = 14,
		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		RR_Donut = 15,
		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		RR_HalfPipe = 16,
		[Cpp2IlInjected.Token(Token = "0x40000E1")]
		RR_Diamond = 17,
		[Cpp2IlInjected.Token(Token = "0x40000E2")]
		ADVANCED_Mound = 18,
		[Cpp2IlInjected.Token(Token = "0x40000E3")]
		ADVANCED_Cube = 19,
		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		ADVANCED_Sphere = 20,
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		ADVANCED_Cylinder = 21,
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		ADVANCED_Cone = 22,
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		ADVANCED_Pyramid = 23,
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		ADVANCED_Octagon = 24,
		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		ADVANCED_Triangle = 25,
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		ADVANCED_Hexagon = 26,
		[Cpp2IlInjected.Token(Token = "0x40000EB")]
		ADVANCED_QuarterPipe = 27,
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		ADVANCED_Pentagon = 28,
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		ADVANCED_Dodecahedron = 29,
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		ADVANCED_Trihedron = 30,
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		ADVANCED_Octahedron = 31,
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		RR_QuarterCylinder = 32,
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		RR_Pentagon = 33,
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		RR_QuarterSphere = 34,
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		ADVANCED_Wedge = 35,
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		RR_Hexagon = 36,
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		RR_Octagon = 37,
		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		RR_Triangle = 38,
		[Cpp2IlInjected.Token(Token = "0x40000F7")]
		COUNT = 39,
		[Cpp2IlInjected.Token(Token = "0x40000F8")]
		MIN_VALUE = -1,
		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		MAX_VALUE = 38
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public enum TextureWrapMode
	{
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		Repeat,
		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		Clamp,
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		Other
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public static class HVQLIMMZRNY
	{
		[Cpp2IlInjected.Token(Token = "0x2000016")]
		public struct ProfileSession : IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000FE")]
			private readonly string? _outputPath;

			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x999CDC0", Offset = "0x999B7C0", VA = "0x18999CDC0")]
			internal ProfileSession(string? outputPath)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0xD10150", Offset = "0xD0EB50", VA = "0x180D10150", Slot = "4")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000017")]
		internal struct ProfileSection : IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000FF")]
			private readonly string? _name;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000100")]
			private readonly int _depth;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000101")]
			private readonly long _startTicks;

			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x999CDB0", Offset = "0x999B7B0", VA = "0x18999CDB0")]
			internal ProfileSection(string name)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0xD10150", Offset = "0xD0EB50", VA = "0x180D10150", Slot = "4")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0xD10160", Offset = "0xD0EB60", VA = "0x180D10160")]
		public static ProfileSession AZAFAXRXEYK(string? a)
		{
			return default(ProfileSession);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x1851730", Offset = "0x1850130", VA = "0x181851730")]
		internal static ProfileSection Section(string name)
		{
			return default(ProfileSection);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public class MJATFEMGJMI
	{
		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public string? CTZDLOJAEUK
		{
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0xD117B0", Offset = "0xD101B0", VA = "0x180D117B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0xD117C0", Offset = "0xD101C0", VA = "0x180D117C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public int? HIKMGJZQPLV
		{
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0xD11B30", Offset = "0xD10530", VA = "0x180D11B30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0xE07390", Offset = "0xE05D90", VA = "0x180E07390")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
		public MJATFEMGJMI()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public interface ADMWIPYDBOF
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(Slot = "0")]
		GHMDNJNUTEU? JHXTUPPVISB(PrimitiveShapeMeshType a, int b = 0);

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(Slot = "1")]
		BevelConfig DZEMQYGEMDB();

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(Slot = "2")]
		CKHQFNSXZSC? GetMaterialExportData(ShapeColor shapeColor, ShapeMaterial shapeMaterial);

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(Slot = "3")]
		bool NIESACJLCQX(Guid a, [Out] string b);
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public static class MSWEODUYACW
	{
		[Cpp2IlInjected.Token(Token = "0x200001B")]
		public static class DNCLIQEOPAS
		{
			[Cpp2IlInjected.Token(Token = "0x200001C")]
			public static class POHXRHRABSA
			{
				[Cpp2IlInjected.Token(Token = "0x4000104")]
				public static readonly Guid NEYTWPYFVEO;

				[Cpp2IlInjected.Token(Token = "0x4000105")]
				public static readonly Guid GDJRSKEDMNK;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001D")]
		private readonly struct ExportContext
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000106")]
			public readonly SceneBuilder SceneBuilder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000107")]
			public readonly ADMWIPYDBOF Dependencies;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000108")]
			public readonly BevelConfig BevelConfig;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000109")]
			public readonly Dictionary<string, int> NodeNameToCountMap;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400010A")]
			public readonly Dictionary<MaterialExportKey, MaterialBuilder> MaterialCache;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400010B")]
			public readonly Dictionary<PrimitiveShapeMeshType, GHMDNJNUTEU?> PrimitiveMeshCache;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400010C")]
			public readonly Dictionary<MeshBuilderCacheKey, MeshBuilder<MaterialBuilder, VertexPositionNormal, VertexTexture1, VertexEmpty>> MeshBuilderCache;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400010D")]
			public readonly BNUDEUJRXJV? Progress;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x400010E")]
			public readonly IPVFOJQFFNA TimedYielder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x400010F")]
			public readonly CancellationToken CancellationToken;

			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x9998400", Offset = "0x9996E00", VA = "0x189998400")]
			private ExportContext(SceneBuilder sceneBuilder, ADMWIPYDBOF dependencies, BevelConfig bevelConfig, Dictionary<string, int> nodeNameToCountMap, Dictionary<MaterialExportKey, MaterialBuilder> materialCache, Dictionary<PrimitiveShapeMeshType, GHMDNJNUTEU?> primitiveMeshCache, Dictionary<MeshBuilderCacheKey, MeshBuilder<MaterialBuilder, VertexPositionNormal, VertexTexture1, VertexEmpty>> meshBuilderCache, BNUDEUJRXJV? progress, IPVFOJQFFNA timedYielder, CancellationToken cancellationToken)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x99980A0", Offset = "0x9996AA0", VA = "0x1899980A0")]
			public static ExportContext New(ADMWIPYDBOF dependencies, BNUDEUJRXJV? progress, CancellationToken cancellationToken)
			{
				return default(ExportContext);
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200001E")]
		[CompilerGenerated]
		private struct <BuildR1GlbModel>d__3 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000110")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000111")]
			public AsyncTaskMethodBuilder<ModelRoot> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000112")]
			public PBCTZJZFZQR[] persistenceViewDatas;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000113")]
			public ADMWIPYDBOF dependencies;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000114")]
			public BNUDEUJRXJV progress;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000115")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000116")]
			private HVQLIMMZRNY.ProfileSection <_exportSection>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4000117")]
			private ExportContext <ctx>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
			[Cpp2IlInjected.Token(Token = "0x4000118")]
			private Queue<(NodeBuilder parentNode, PBCTZJZFZQR data)> <queue>5__4;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
			[Cpp2IlInjected.Token(Token = "0x4000119")]
			private PBCTZJZFZQR <pv>5__5;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
			[Cpp2IlInjected.Token(Token = "0x400011A")]
			private NodeBuilder <node>5__6;

			[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
			[Cpp2IlInjected.Token(Token = "0x400011B")]
			private int <childViewCount>5__7;

			[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
			[Cpp2IlInjected.Token(Token = "0x400011C")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
			[Cpp2IlInjected.Token(Token = "0x400011D")]
			private object <>u__2;

			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x999F380", Offset = "0x999DD80", VA = "0x18999F380", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x99A0330", Offset = "0x999ED30", VA = "0x1899A0330", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200001F")]
		[CompilerGenerated]
		private struct <BuildR2GlbModel>d__5 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400011E")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400011F")]
			public AsyncTaskMethodBuilder<ModelRoot> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000120")]
			public PBCTZJZFZQR[] persistenceViewDatas;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000121")]
			public ADMWIPYDBOF dependencies;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000122")]
			public BNUDEUJRXJV progress;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000123")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000124")]
			public MJATFEMGJMI[] nodeInfos;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000125")]
			private HVQLIMMZRNY.ProfileSection <_exportSection>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x4000126")]
			private PBCTZJZFZQR[] <views>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x4000127")]
			private ExportContext <ctx>5__4;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
			[Cpp2IlInjected.Token(Token = "0x4000128")]
			private NodeBuilder[] <allNodes>5__5;

			[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
			[Cpp2IlInjected.Token(Token = "0x4000129")]
			private bool[] <created>5__6;

			[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
			[Cpp2IlInjected.Token(Token = "0x400012A")]
			private HVQLIMMZRNY.ProfileSection <>7__wrap6;

			[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
			[Cpp2IlInjected.Token(Token = "0x400012B")]
			private NodeBuilder <shapeRootNode>5__8;

			[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
			[Cpp2IlInjected.Token(Token = "0x400012C")]
			private bool <madeProgress>5__9;

			[Cpp2IlInjected.FieldOffset(Offset = "0xFC")]
			[Cpp2IlInjected.Token(Token = "0x400012D")]
			private int <i>5__10;

			[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
			[Cpp2IlInjected.Token(Token = "0x400012E")]
			private TaskAwaiter<bool> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
			[Cpp2IlInjected.Token(Token = "0x400012F")]
			private TaskAwaiter <>u__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
			[Cpp2IlInjected.Token(Token = "0x4000130")]
			private object <>u__3;

			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x99A03A0", Offset = "0x999EDA0", VA = "0x1899A03A0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x99A1E60", Offset = "0x99A0860", VA = "0x1899A1E60", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000020")]
		[CompilerGenerated]
		private struct <ProcessShapesForNode>d__7 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000131")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000132")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000133")]
			public PBCTZJZFZQR pv;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000134")]
			public ExportContext ctx;

			[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
			[Cpp2IlInjected.Token(Token = "0x4000135")]
			public NodeBuilder containerNode;

			[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
			[Cpp2IlInjected.Token(Token = "0x4000136")]
			private int <shapeCountInContainer>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
			[Cpp2IlInjected.Token(Token = "0x4000137")]
			private float3 <containerScale>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
			[Cpp2IlInjected.Token(Token = "0x4000138")]
			private int <shapeIndex>5__4;

			[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
			[Cpp2IlInjected.Token(Token = "0x4000139")]
			private TaskAwaiter<bool> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x99A1ED0", Offset = "0x99A08D0", VA = "0x1899A1ED0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x99A2A80", Offset = "0x99A1480", VA = "0x1899A2A80", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000021")]
		[CompilerGenerated]
		private struct <WriteGlbModel>d__6 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400013A")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400013B")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400013C")]
			public BNUDEUJRXJV progress;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400013D")]
			public ModelRoot model;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400013E")]
			public Stream output;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400013F")]
			private object <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x99A2AE0", Offset = "0x99A14E0", VA = "0x1899A2AE0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x99A2E50", Offset = "0x99A1850", VA = "0x1899A2E50", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x999C5C0", Offset = "0x999AFC0", VA = "0x18999C5C0")]
		public static bool YIJPLXKEOCU(PBCTZJZFZQR? a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x999A8D0", Offset = "0x99992D0", VA = "0x18999A8D0")]
		public static bool KGNZSLPVPWQ(PBCTZJZFZQR? a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x999A440", Offset = "0x9998E40", VA = "0x18999A440")]
		private static bool FJJOQSHLRXI(PBCTZJZFZQR? a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x999A6E0", Offset = "0x99990E0", VA = "0x18999A6E0")]
		[AsyncStateMachine(typeof(<BuildR1GlbModel>d__3))]
		public static Task<ModelRoot> IIAXAJFXHKW(PBCTZJZFZQR[] a, ADMWIPYDBOF b, [Optional] BNUDEUJRXJV? progress, [Optional] CancellationToken c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x999A560", Offset = "0x9998F60", VA = "0x18999A560")]
		[AsyncStateMachine(typeof(<BuildR2GlbModel>d__5))]
		public static Task<ModelRoot> ICMALBLCMMH(PBCTZJZFZQR[] a, MJATFEMGJMI[] b, ADMWIPYDBOF c, [Optional] BNUDEUJRXJV? progress, [Optional] CancellationToken d)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x999C4B0", Offset = "0x999AEB0", VA = "0x18999C4B0")]
		[AsyncStateMachine(typeof(<WriteGlbModel>d__6))]
		public static Task WriteGlbModel(ModelRoot model, Stream output, [Optional] BNUDEUJRXJV? progress)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x999BF40", Offset = "0x999A940", VA = "0x18999BF40")]
		[AsyncStateMachine(typeof(<ProcessShapesForNode>d__7))]
		private static Task THIVZUGMNBR(NodeBuilder a, PBCTZJZFZQR b, ExportContext c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x999AAC0", Offset = "0x99994C0", VA = "0x18999AAC0")]
		private static MeshBuilder<MaterialBuilder, VertexPositionNormal, VertexTexture1, VertexEmpty> KINRFDTVUIP(PrimitiveShapeMeshType a, string b, ShapeColor c, ShapeMaterial d, float e, float3 f, bool g, float h, float3 i, ExportContext j)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x999B0C0", Offset = "0x9999AC0", VA = "0x18999B0C0")]
		private static MaterialBuilder KKXTWVSBUED(ShapeColor a, ShapeMaterial b, ExportContext c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x999A840", Offset = "0x9999240", VA = "0x18999A840")]
		private static float IOUZSHNDZRD(float a)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x999B790", Offset = "0x999A190", VA = "0x18999B790")]
		private static MeshBuilder<MaterialBuilder, VertexPositionNormal, VertexTexture1, VertexEmpty> KYACMQRLSZA(string a, GHMDNJNUTEU b, MaterialBuilder c, [Optional] float2[]? perCornerUvs)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x999C090", Offset = "0x999AA90", VA = "0x18999C090")]
		[CompilerGenerated]
		internal static NodeBuilder VILXCIYWATL(ExportContext a, NodeBuilder b, PBCTZJZFZQR c)
		{
			return null;
		}
	}
}
namespace RecRoom.ExportTools.Internal
{
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	internal static class KWXFTHBBZLJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x999A340", Offset = "0x9998D40", VA = "0x18999A340")]
		public static bool PXJJUXERPXM(PrimitiveShapeMeshType a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x999A040", Offset = "0x9998A40", VA = "0x18999A040")]
		public static void LVFNSFKENQI(PrimitiveShapeMeshType a, float3 b, BevelConfig c, [Out] float3 d, [Out] float e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x9999D40", Offset = "0x9998740", VA = "0x189999D40")]
		public static GHMDNJNUTEU JAVCNFEKIEV(GHMDNJNUTEU a, PrimitiveShapeMeshType b, float3 c, float d)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	internal static class ATYRCIEFNZH
	{
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x9997300", Offset = "0x9995D00", VA = "0x189997300")]
		public static Vector3 SLDQTZDODKP(float3 a)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x9997520", Offset = "0x9995F20", VA = "0x189997520")]
		public static Quaternion VBJYZLLOBKS(quaternion a)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x8D93E80", Offset = "0x8D92880", VA = "0x188D93E80")]
		public static Vector3 UYZLVIDUAIW(float3 a)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x9997300", Offset = "0x9995D00", VA = "0x189997300")]
		public static Vector3 EOAJOCMNHSH(float3 a)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x9997340", Offset = "0x9995D40", VA = "0x189997340")]
		public static quaternion HBQDMAVSJAI(float3 a)
		{
			return default(quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x99973F0", Offset = "0x9995DF0", VA = "0x1899973F0")]
		public static quaternion ISIZUSLDTHL(TransformData a)
		{
			return default(quaternion);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	internal static class GSPYCNBVULE
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x9999BB0", Offset = "0x99985B0", VA = "0x189999BB0")]
		public static Guid TMDUMOFHSHY(ByteString? a)
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x9999CE0", Offset = "0x99986E0", VA = "0x189999CE0")]
		public static string ZJAUTLXXOMA(ByteString? self)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	internal static class VTNWHXOQLOU
	{
		[Cpp2IlInjected.Token(Token = "0x4000140")]
		public static readonly PrimitiveShapeMeshType[] TUZCFCMLANT;

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x99A7830", Offset = "0x99A6230", VA = "0x1899A7830")]
		public static PrimitiveShapeMeshType UCBBFCBUQBC(ShapeType a)
		{
			return default(PrimitiveShapeMeshType);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	internal static class LZPYPWCQBOG
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x999A360", Offset = "0x9998D60", VA = "0x18999A360")]
		public static string ONYUYKDIYQL(string a, Dictionary<string, int> b)
		{
			return null;
		}
	}
}
namespace RecRoom.ExportTools.Internal.ShapeExport
{
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	internal static class QLJORNZSJUR
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x999CDD0", Offset = "0x999B7D0", VA = "0x18999CDD0")]
		public static GHMDNJNUTEU CKBJXCKFRZP(PrimitiveShapeMeshType a, float3 b, float c, ADMWIPYDBOF d, Dictionary<PrimitiveShapeMeshType, GHMDNJNUTEU?> primitiveMeshCache)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x999CF70", Offset = "0x999B970", VA = "0x18999CF70")]
		public static float2[] FNAQZAWMJDD(GHMDNJNUTEU a, float3 b, bool c, float d, float e, float3 f)
		{
			return null;
		}
	}
}
namespace RecRoom.ExportTools.Internal.CurveExport
{
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	internal static class GRSMXKNDFHQ
	{
		[Cpp2IlInjected.Token(Token = "0x4000141")]
		public static readonly float3 SSEFFWMUGNJ;

		[Cpp2IlInjected.Token(Token = "0x4000142")]
		public static readonly float3 ZBNSVHLVUAT;

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x9999450", Offset = "0x9997E50", VA = "0x189999450")]
		public static float3 PAWJEXEVIFQ(quaternion a)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x9999980", Offset = "0x9998380", VA = "0x189999980")]
		public static float3 WEFOWFVCHXY(quaternion a)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x9999600", Offset = "0x9998000", VA = "0x189999600")]
		public static quaternion SVMCNBIWFMY(float3 a, float3 b)
		{
			return default(quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x99997E0", Offset = "0x99981E0", VA = "0x1899997E0")]
		public static float TBRTDIRGBOM(float3 a, float3 b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x9999300", Offset = "0x9997D00", VA = "0x189999300")]
		public static float OBLBMCQKIIE(float3 a, float3 b, float3 c)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x99988B0", Offset = "0x99972B0", VA = "0x1899988B0")]
		public static float3 GKJZBPTRPIT(float3 a, float3 b, float3 c)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x9998CC0", Offset = "0x99976C0", VA = "0x189998CC0")]
		public static quaternion LOVCCOHRXOL(quaternion a, float3 b)
		{
			return default(quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x9999680", Offset = "0x9998080", VA = "0x189999680")]
		public static bool SXZAYAHAXYH(float3 a, float3 b, [Out] float3 c, bool d)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x99984D0", Offset = "0x9996ED0", VA = "0x1899984D0")]
		public static float3 CASIBAUPLZA(bool a, [Optional] quaternion b)
		{
			return default(float3);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	internal static class UIZOGLZGSKM
	{
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x99A2EB0", Offset = "0x99A18B0", VA = "0x1899A2EB0")]
		public static GHMDNJNUTEU ITCFODKGFCX(CurveShapeData a, ShapeType b, int c, float d, float3 e, float f, float g)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x99A4430", Offset = "0x99A2E30", VA = "0x1899A4430")]
		private static void NTUKHBNCEJB(float3[] a, float3[] b, float2[] c, int d, float3 e, float3 f, float3 g, float h, bool i, float j)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x99A4540", Offset = "0x99A2F40", VA = "0x1899A4540")]
		private static void WIBNBLSMGAM(ExportCurvePointData a, ExportRingSegment b, float3[] c, float3[] d, float2[] e, int f, float g, float h, float i, float3 j, float k)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x99A3DE0", Offset = "0x99A27E0", VA = "0x1899A3DE0")]
		private static void LLFFLMFZQGG(ExportRingSegment a, float3[] b, float3[] c, float2[] d, int[] e, int f, int g, float3 h, float3x3 i, bool j, float k, int l, bool m, float n, float o, float3 p, float q)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	internal struct ExportCurvePointData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000143")]
		public float3 Position;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000144")]
		public float3x3 Rotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000145")]
		public float Radius;
	}
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	internal static class VQRQWZJGIVR
	{
		[Cpp2IlInjected.Token(Token = "0x200002C")]
		private struct PointSrcData
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000146")]
			public float3 Position;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
			[Cpp2IlInjected.Token(Token = "0x4000147")]
			public quaternion Rotation;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
			[Cpp2IlInjected.Token(Token = "0x4000148")]
			public float Radius;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000149")]
			public quaternion BlendedRotation;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400014A")]
			public float BendAngle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
			[Cpp2IlInjected.Token(Token = "0x400014B")]
			public float BendRadius;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400014C")]
			public float DistanceToNext;
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x99A65C0", Offset = "0x99A4FC0", VA = "0x1899A65C0")]
		public static List<ExportCurvePointData> Generate(IReadOnlyList<float3> positions, IReadOnlyList<float3> normals, IReadOnlyList<float> radii, int configFlags, float heightScale)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x99A7650", Offset = "0x99A6050", VA = "0x1899A7650")]
		private static void XAYAMVPYELC(IReadOnlyList<float3> a, float3[] b, int c, bool d, bool e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x99A6330", Offset = "0x99A4D30", VA = "0x1899A6330")]
		private static float3 EYMBOVELGWA(IReadOnlyList<float3> a, float3[] b, int c, int d, bool e, bool f, quaternion g)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x99A6D80", Offset = "0x99A5780", VA = "0x1899A6D80")]
		private static List<ExportCurvePointData> NKNOQNGHCWK(List<PointSrcData> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x99A5690", Offset = "0x99A4090", VA = "0x1899A5690")]
		private static bool EFXWTWFXNSL(int a, List<ExportCurvePointData> b, List<PointSrcData> c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x99A70C0", Offset = "0x99A5AC0", VA = "0x1899A70C0")]
		private static ExportCurvePointData VGJJWLZFDDN(int a, List<PointSrcData> b)
		{
			return default(ExportCurvePointData);
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x99A4980", Offset = "0x99A3380", VA = "0x1899A4980")]
		private static List<ExportCurvePointData> ANZLZZWJVGK(List<PointSrcData> a, float b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x99A7770", Offset = "0x99A6170", VA = "0x1899A7770")]
		private static ExportCurvePointData ZOXNLZIFTRV(PointSrcData a)
		{
			return default(ExportCurvePointData);
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x99A6CF0", Offset = "0x99A56F0", VA = "0x1899A6CF0")]
		private static ExportCurvePointData LHJQSYGDNJI(float3 a, quaternion b, float c)
		{
			return default(ExportCurvePointData);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	internal struct ExportRingVertex
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400014D")]
		public float2 Offset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400014E")]
		public float2 Normal;
	}
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	internal struct ExportRingSegment
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400014F")]
		public ExportRingVertex[] RingVerts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000150")]
		public int[] RingIndices;
	}
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	internal static class CCMPQGVQHVB
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x9997650", Offset = "0x9996050", VA = "0x189997650")]
		public static ExportRingSegment EROYCQZEVLU(int a)
		{
			return default(ExportRingSegment);
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x9997A00", Offset = "0x9996400", VA = "0x189997A00")]
		public static ExportRingSegment FVAPSNMZDZX(int a)
		{
			return default(ExportRingSegment);
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x9997570", Offset = "0x9995F70", VA = "0x189997570")]
		public static ExportRingSegment AONEWLWHJXK()
		{
			return default(ExportRingSegment);
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x99975F0", Offset = "0x9995FF0", VA = "0x1899975F0")]
		public static int EPZVEPTFZMI(int a, int b, bool c, bool d, bool e)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x99975A0", Offset = "0x9995FA0", VA = "0x1899975A0")]
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
