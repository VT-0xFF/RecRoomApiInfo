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
		[Cpp2IlInjected.Address(RVA = "0xCFAE40", Offset = "0xCF9840", VA = "0x180CFAE40")]
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
		[Cpp2IlInjected.Address(RVA = "0x9815A80", Offset = "0x9814480", VA = "0x189815A80")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xCFB710", Offset = "0xCFA110", VA = "0x180CFB710")]
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
		[Cpp2IlInjected.Address(RVA = "0xCFB750", Offset = "0xCFA150", VA = "0x180CFB750")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
namespace RecRoom.ExportTools
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public static class CGGSDWKPNIV
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x98111D0", Offset = "0x980FBD0", VA = "0x1898111D0")]
		public static ModelRoot BuildAvatarGlbModel(string sceneName, ZYPKWOMNBIE[] nodes)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x9812910", Offset = "0x9811310", VA = "0x189812910")]
		private static MaterialBuilder YDFWLSEDEHS(VSULZHIWWII? matData, Dictionary<VSULZHIWWII, MaterialBuilder> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x9811F70", Offset = "0x9810970", VA = "0x189811F70")]
		private static ImageBuilder? PFJYBTSZAAF(byte[]? a, string name)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x9811FD0", Offset = "0x98109D0", VA = "0x189811FD0")]
		private static float PMEBZMGCZLO(float a)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x9811800", Offset = "0x9810200", VA = "0x189811800")]
		private static IMeshBuilder<MaterialBuilder> FOERUYGXNMV(string a, JZLQQLGVCEB b, MaterialBuilder c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x9812060", Offset = "0x9810A60", VA = "0x189812060")]
		private static MeshBuilder<MaterialBuilder, VertexPositionNormal, VertexTexture2, VertexEmpty> TAIAXTVBESY(string a, JZLQQLGVCEB b, MaterialBuilder c)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public class VSULZHIWWII
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		public string KPIDBUYRLLN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		public ColorRGB CWBFGTAZPQQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		public float WUJAAPJKDJS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		public byte[]? GSWDUSYGRLI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		public int UBXPOWRWLQI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public bool MWDGTXBHVTM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public byte[]? MRCNWMMOMFL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public float QWQJPOLXCQX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public ColorRGB QURGLJPCYNQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public byte[]? VQEQHDALYHD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public float XPVGWGYFKBX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public float YYRILWYIYYG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public byte[]? VJMZNIMZBXZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public bool ZBAGGWVCBCW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public float? WZBLKEWNZOF;

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x981E3F0", Offset = "0x981CDF0", VA = "0x18981E3F0")]
		public VSULZHIWWII()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public class ZYPKWOMNBIE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public string KPIDBUYRLLN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public float3 OYWTYXOICNS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public quaternion SILHDFYWFMV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public float3 AQJHARNXCDR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public JZLQQLGVCEB SEPNJECHARX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public VSULZHIWWII? DMNWOMXIVEB;

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x9823000", Offset = "0x9821A00", VA = "0x189823000")]
		public ZYPKWOMNBIE()
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
		public static ColorRGB SBSOVVPTTBD
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x9813120", Offset = "0x9811B20", VA = "0x189813120")]
			get
			{
				return default(ColorRGB);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public static ColorRGB SOYMJLOTOVF
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x10399D0", Offset = "0x10383D0", VA = "0x1810399D0")]
			get
			{
				return default(ColorRGB);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x2B6BDE0", Offset = "0x2B6A7E0", VA = "0x182B6BDE0")]
		public ColorRGB(float r, float g, float b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public class PDYPULBSWLN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public string DOPDVBKWPXV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		public MaterialColorUsage TLNHXYPHGIK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public ColorRGB SMEJZRYYLMB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		public ColorRGB QURGLJPCYNQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public ColorRGB PFSLMBNTBPO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public float BAAIFBCYOIS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public MFPZTNNQEMV? WBCXOYIMCKZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		public MFPZTNNQEMV? TMFDBCIUKZA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		public MFPZTNNQEMV? VJSDQIVKXLM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		public MFPZTNNQEMV? NQQQBKZYYOA;

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x9815BE0", Offset = "0x98145E0", VA = "0x189815BE0")]
		public PDYPULBSWLN()
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
		[Cpp2IlInjected.Address(RVA = "0xEA99B0", Offset = "0xEA83B0", VA = "0x180EA99B0")]
		public MaterialExportKey(ShapeColor shapeColor, ShapeMaterial shapeMaterial)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x14163A0", Offset = "0x1414DA0", VA = "0x1814163A0", Slot = "4")]
		public bool Equals(MaterialExportKey other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x9815530", Offset = "0x9813F30", VA = "0x189815530", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x98155C0", Offset = "0x9813FC0", VA = "0x1898155C0", Slot = "2")]
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
		[Cpp2IlInjected.Address(RVA = "0x9815A10", Offset = "0x9814410", VA = "0x189815A10")]
		public MeshBuilderCacheKey(PrimitiveShapeMeshType meshType, MaterialExportKey material, [Optional] float3 bevelScalingRatio, float bevelAuthoredRatio = 0f, [Optional] float3 worldScale, bool dynamicProjection = false, float containerScaleX = 0f, float uvScale = 0f, [Optional] float3 uvOffset)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x9815630", Offset = "0x9814030", VA = "0x189815630", Slot = "4")]
		public bool Equals(MeshBuilderCacheKey other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x98157C0", Offset = "0x98141C0", VA = "0x1898157C0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x9815870", Offset = "0x9814270", VA = "0x189815870", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class JZLQQLGVCEB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		public float3[] ICUTMTEPZVV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public int[] PHLVAANKWVP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public float3[] FRTHDLVTDSU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public float2[]? DDBWYGVQUOO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public float2[]? XBYCSIYTXVV;

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x89FA300", Offset = "0x89F8D00", VA = "0x1889FA300")]
		public JZLQQLGVCEB(float3[] a, int[] b, float3[] c, [Optional] float2[]? uv0s, [Optional] float2[]? uv1s)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public class UAOCQJVAFZA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public string KPIDBUYRLLN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public float3 OYWTYXOICNS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public quaternion SILHDFYWFMV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public float3 AQJHARNXCDR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public JZLQQLGVCEB SEPNJECHARX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public VSULZHIWWII? DMNWOMXIVEB;

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x981D9C0", Offset = "0x981C3C0", VA = "0x18981D9C0")]
		public UAOCQJVAFZA()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public class MFPZTNNQEMV
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		public string WHEACKMHEYE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public ImageBuilder? OLXIJAXXIGN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public float2 KJUGRAXUWPR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public float2 ZGYOETDZTFY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public TextureWrapMode PWQGZEAGGVY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public TextureWrapMode PWLABXGIXKP;

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x98154E0", Offset = "0x9813EE0", VA = "0x1898154E0")]
		public MFPZTNNQEMV()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[Flags]
	public enum MaterialColorUsage
	{
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		ALBEDO = 1,
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		EMISSIVE = 2,
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		SPECULAR = 4,
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		HOLOGRAPHIC = 8
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public enum PrimitiveShapeMeshType
	{
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		Invalid = -1,
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		RR_Box,
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		RR_Sphere,
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		RR_Cylinder,
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		RR_Wedge,
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		RR_Pyramid,
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		RR_HalfSphere,
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		RR_Cone,
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		RR_Pipe,
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		RR_Donut,
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		RR_HalfPipe,
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		RR_Diamond,
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		ADVANCED_Mound,
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		LEGACY_Box,
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		ADVANCED_Cube,
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		ADVANCED_Sphere,
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		ADVANCED_Cylinder,
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		ADVANCED_Cone,
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		ADVANCED_Pyramid,
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		ADVANCED_Octagon,
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		ADVANCED_Triangle,
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		ADVANCED_Hexagon,
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		ADVANCED_QuarterPipe,
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		ADVANCED_Pentagon,
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		ADVANCED_Dodecahedron,
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		ADVANCED_Trihedron,
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		ADVANCED_Octahedron,
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		RR_QuarterCylinder,
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		RR_Pentagon,
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		RR_QuarterSphere,
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		ADVANCED_Wedge,
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		RR_Hexagon,
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		RR_Octagon,
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		RR_Triangle,
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		Count
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public enum ShapeColor
	{
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		RED = 0,
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		ORANGE = 1,
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		YELLOW = 2,
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		GREEN = 3,
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		DARK_GREEN = 4,
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		CYAN = 5,
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		BLUE = 6,
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		DARK_BLUE = 7,
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		PURPLE = 8,
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		PINK = 9,
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		BROWN = 10,
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		WHITE = 11,
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		GREY = 12,
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		BLACK = 13,
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		DARK_ORANGE = 14,
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		LIME = 15,
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		LIGHT_GREEN = 16,
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		AQUAMARINE = 17,
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		LIGHT_BLUE = 18,
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		LAVENDER = 19,
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		MAGENTA = 20,
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		SALMON = 21,
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		TAN = 22,
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		CREAM = 23,
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		LIGHT_GREY = 24,
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		DARK_GREY = 25,
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		NEW_COLOR_0 = 26,
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		NEW_COLOR_1 = 27,
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		NEW_COLOR_2 = 28,
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		NEW_COLOR_3 = 29,
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		NEW_COLOR_4 = 30,
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		NEW_COLOR_5 = 31,
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		NEW_COLOR_6 = 32,
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		UNUSED_SEE_COMMENT = 33,
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		NEW_COLOR_7 = 34,
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		NEW_COLOR_8 = 35,
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		NEW_COLOR_9 = 36,
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		NEW_COLOR_10 = 37,
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		NEW_COLOR_11 = 38,
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		NEW_COLOR_12 = 39,
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		NEW_COLOR_13 = 40,
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		NEW_COLOR_14 = 41,
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		NEW_COLOR_15 = 42,
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		NEW_COLOR_16 = 43,
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		NEW_COLOR_17 = 44,
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		NEW_COLOR_18 = 45,
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		NEW_COLOR_19 = 46,
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		NEW_COLOR_20 = 47,
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		NEW_COLOR_21 = 48,
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		NEW_COLOR_22 = 49,
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		NEW_COLOR_23 = 50,
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		NEW_COLOR_24 = 51,
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		NEW_COLOR_25 = 52,
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		NEW_COLOR_26 = 53,
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		NEW_COLOR_27 = 54,
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		NEW_COLOR_28 = 55,
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		NEW_COLOR_29 = 56,
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		NEW_COLOR_30 = 57,
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		NEW_COLOR_31 = 58,
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		NEW_COLOR_32 = 59,
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		NEW_COLOR_33 = 60,
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		GENERATED_COLOR_START = 1000
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public enum ShapeMaterial
	{
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		INVALID = -1,
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		CARDBOARD = 0,
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		METAL = 1,
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		RUBBER = 2,
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		PLASTIC = 3,
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		NEON = 4,
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		WOOD = 5,
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		GLASS = 6,
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		ROCK = 7,
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		ICE = 8,
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		GOLD = 9,
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		SAND = 10,
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		LEATHER = 11,
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		GRID = 12,
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		TILE = 13,
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		GRASS = 14,
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		BARK = 15,
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		CONCRETE = 16,
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		SNOW = 17,
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		CARPET = 18,
		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		FABRIC = 19,
		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		FOIL = 20,
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		FLESH = 21,
		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		GALAXY = 22,
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		LAVA = 23,
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		WATER = 24,
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		CANDY = 25,
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		FUR = 26,
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		CHAIN_MAIL = 27,
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		PLACEHOLDER_14 = 28,
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		PLACEHOLDER_15 = 29,
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		PLACEHOLDER_16 = 30,
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		PLACEHOLDER_18 = 31,
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		MIN_VALUE = -1,
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		MAX_VALUE = 31,
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		COUNT = 32,
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		DEFAULT = 0
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public enum ShapeType
	{
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		Invalid = -1,
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		CURVE_Tube = 0,
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		CURVE_Ribbon = 1,
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		LegacyBox = 2,
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		RR_Sphere = 3,
		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		RR_Cylinder = 4,
		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		LEGACY_Wedge = 5,
		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		LEGACY_Pyramid = 6,
		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		LEGACY_TriggerVolumeBox = 7,
		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		RR_Box = 8,
		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		LEGACY_RoundedBox = 9,
		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		RR_Wedge = 10,
		[Cpp2IlInjected.Token(Token = "0x40000E1")]
		RR_Pyramid = 11,
		[Cpp2IlInjected.Token(Token = "0x40000E2")]
		RR_HalfSphere = 12,
		[Cpp2IlInjected.Token(Token = "0x40000E3")]
		RR_Cone = 13,
		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		RR_Pipe = 14,
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		RR_Donut = 15,
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		RR_HalfPipe = 16,
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		RR_Diamond = 17,
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		ADVANCED_Mound = 18,
		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		ADVANCED_Cube = 19,
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		ADVANCED_Sphere = 20,
		[Cpp2IlInjected.Token(Token = "0x40000EB")]
		ADVANCED_Cylinder = 21,
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		ADVANCED_Cone = 22,
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		ADVANCED_Pyramid = 23,
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		ADVANCED_Octagon = 24,
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		ADVANCED_Triangle = 25,
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		ADVANCED_Hexagon = 26,
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		ADVANCED_QuarterPipe = 27,
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		ADVANCED_Pentagon = 28,
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		ADVANCED_Dodecahedron = 29,
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		ADVANCED_Trihedron = 30,
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		ADVANCED_Octahedron = 31,
		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		RR_QuarterCylinder = 32,
		[Cpp2IlInjected.Token(Token = "0x40000F7")]
		RR_Pentagon = 33,
		[Cpp2IlInjected.Token(Token = "0x40000F8")]
		RR_QuarterSphere = 34,
		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		ADVANCED_Wedge = 35,
		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		RR_Hexagon = 36,
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		RR_Octagon = 37,
		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		RR_Triangle = 38,
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		COUNT = 39,
		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		MIN_VALUE = -1,
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		MAX_VALUE = 38
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public enum TextureWrapMode
	{
		[Cpp2IlInjected.Token(Token = "0x4000101")]
		Repeat,
		[Cpp2IlInjected.Token(Token = "0x4000102")]
		Clamp,
		[Cpp2IlInjected.Token(Token = "0x4000103")]
		Other
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public static class GVIBCHKZCVV
	{
		[Cpp2IlInjected.Token(Token = "0x2000017")]
		public struct ProfileSession : IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000104")]
			private readonly string? _outputPath;

			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x9815EB0", Offset = "0x98148B0", VA = "0x189815EB0")]
			internal ProfileSession(string? outputPath)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0xCD14C0", Offset = "0xCCFEC0", VA = "0x180CD14C0", Slot = "4")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000018")]
		internal struct ProfileSection : IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000105")]
			private readonly string? _name;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000106")]
			private readonly int _depth;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000107")]
			private readonly long _startTicks;

			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x9815EA0", Offset = "0x98148A0", VA = "0x189815EA0")]
			internal ProfileSection(string name)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0xCD14C0", Offset = "0xCCFEC0", VA = "0x180CD14C0", Slot = "4")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0xCD14D0", Offset = "0xCCFED0", VA = "0x180CD14D0")]
		public static ProfileSession ONZPJVMVHLX(string? a)
		{
			return default(ProfileSession);
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x1816030", Offset = "0x1814A30", VA = "0x181816030")]
		internal static ProfileSection Section(string name)
		{
			return default(ProfileSection);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public class JKZAGQGUSZL
	{
		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public string? KPIDBUYRLLN
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0xCD3CC0", Offset = "0xCD26C0", VA = "0x180CD3CC0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0xCD36D0", Offset = "0xCD20D0", VA = "0x180CD36D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public int? JCAXWUWFZBC
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0xCD8A70", Offset = "0xCD7470", VA = "0x180CD8A70")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0xDF0A10", Offset = "0xDEF410", VA = "0x180DF0A10")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0xCD7590", Offset = "0xCD5F90", VA = "0x180CD7590")]
		public JKZAGQGUSZL()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public interface KGAFOUMCVHY
	{
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(Slot = "0")]
		JZLQQLGVCEB? TJOCMZKYOQA(PrimitiveShapeMeshType a, int b = 0);

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(Slot = "1")]
		BevelConfig RSSRAMPWADM();

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(Slot = "2")]
		PDYPULBSWLN? GetMaterialExportData(ShapeColor shapeColor, ShapeMaterial shapeMaterial);

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(Slot = "3")]
		bool DRMQJFEHOCO(Guid a, [Out] string b);
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public interface EMGUUJRGOMM
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Task<IReadOnlyList<UAOCQJVAFZA>> WVOQZDSDNCR(SpawnableTemplateData a, CancellationToken b);
	}
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public static class SZGWZRLGTDX
	{
		[Cpp2IlInjected.Token(Token = "0x200001D")]
		public static class GNMOUREVCFV
		{
			[Cpp2IlInjected.Token(Token = "0x200001E")]
			public static class EFUZXDCYMMP
			{
				[Cpp2IlInjected.Token(Token = "0x400010A")]
				public static readonly Guid JWNNLLGFFFB;

				[Cpp2IlInjected.Token(Token = "0x400010B")]
				public static readonly Guid VMCAKRQCMJT;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001F")]
		private readonly struct ExportContext
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400010C")]
			public readonly SceneBuilder SceneBuilder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400010D")]
			public readonly KGAFOUMCVHY Dependencies;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400010E")]
			public readonly BevelConfig BevelConfig;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400010F")]
			public readonly Dictionary<string, int> NodeNameToCountMap;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000110")]
			public readonly Dictionary<MaterialExportKey, MaterialBuilder> MaterialCache;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000111")]
			public readonly Dictionary<PrimitiveShapeMeshType, JZLQQLGVCEB?> PrimitiveMeshCache;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000112")]
			public readonly Dictionary<MeshBuilderCacheKey, MeshBuilder<MaterialBuilder, VertexPositionNormal, VertexTexture1, VertexEmpty>> MeshBuilderCache;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000113")]
			public readonly UUYHHZWTGNG? Progress;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000114")]
			public readonly UFPXWURGTMD TimedYielder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4000115")]
			public readonly CancellationToken CancellationToken;

			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x98135A0", Offset = "0x9811FA0", VA = "0x1898135A0")]
			private ExportContext(SceneBuilder sceneBuilder, KGAFOUMCVHY dependencies, BevelConfig bevelConfig, Dictionary<string, int> nodeNameToCountMap, Dictionary<MaterialExportKey, MaterialBuilder> materialCache, Dictionary<PrimitiveShapeMeshType, JZLQQLGVCEB?> primitiveMeshCache, Dictionary<MeshBuilderCacheKey, MeshBuilder<MaterialBuilder, VertexPositionNormal, VertexTexture1, VertexEmpty>> meshBuilderCache, UUYHHZWTGNG? progress, UFPXWURGTMD timedYielder, CancellationToken cancellationToken)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x9813240", Offset = "0x9811C40", VA = "0x189813240")]
			public static ExportContext New(KGAFOUMCVHY dependencies, UUYHHZWTGNG? progress, CancellationToken cancellationToken)
			{
				return default(ExportContext);
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000020")]
		[CompilerGenerated]
		private struct <BuildR1GlbModel>d__3 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000116")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000117")]
			public AsyncTaskMethodBuilder<ModelRoot> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000118")]
			public FDPQDCZIFNA[] persistenceViewDatas;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000119")]
			public KGAFOUMCVHY dependencies;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400011A")]
			public UUYHHZWTGNG progress;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400011B")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400011C")]
			private GVIBCHKZCVV.ProfileSection <_exportSection>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x400011D")]
			private ExportContext <ctx>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
			[Cpp2IlInjected.Token(Token = "0x400011E")]
			private Queue<(NodeBuilder parentNode, FDPQDCZIFNA data)> <queue>5__4;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
			[Cpp2IlInjected.Token(Token = "0x400011F")]
			private FDPQDCZIFNA <pv>5__5;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
			[Cpp2IlInjected.Token(Token = "0x4000120")]
			private NodeBuilder <node>5__6;

			[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
			[Cpp2IlInjected.Token(Token = "0x4000121")]
			private int <childViewCount>5__7;

			[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
			[Cpp2IlInjected.Token(Token = "0x4000122")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
			[Cpp2IlInjected.Token(Token = "0x4000123")]
			private object <>u__2;

			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x9819BD0", Offset = "0x98185D0", VA = "0x189819BD0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x981AB80", Offset = "0x9819580", VA = "0x18981AB80", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000021")]
		[CompilerGenerated]
		private struct <BuildR2GlbModel>d__5 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000124")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000125")]
			public AsyncTaskMethodBuilder<ModelRoot> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000126")]
			public FDPQDCZIFNA[] persistenceViewDatas;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000127")]
			public KGAFOUMCVHY dependencies;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000128")]
			public UUYHHZWTGNG progress;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000129")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400012A")]
			public JKZAGQGUSZL[] nodeInfos;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400012B")]
			private GVIBCHKZCVV.ProfileSection <_exportSection>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x400012C")]
			private FDPQDCZIFNA[] <views>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x400012D")]
			private ExportContext <ctx>5__4;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
			[Cpp2IlInjected.Token(Token = "0x400012E")]
			private NodeBuilder[] <allNodes>5__5;

			[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
			[Cpp2IlInjected.Token(Token = "0x400012F")]
			private bool[] <created>5__6;

			[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
			[Cpp2IlInjected.Token(Token = "0x4000130")]
			private GVIBCHKZCVV.ProfileSection <>7__wrap6;

			[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
			[Cpp2IlInjected.Token(Token = "0x4000131")]
			private NodeBuilder <shapeRootNode>5__8;

			[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
			[Cpp2IlInjected.Token(Token = "0x4000132")]
			private bool <madeProgress>5__9;

			[Cpp2IlInjected.FieldOffset(Offset = "0xFC")]
			[Cpp2IlInjected.Token(Token = "0x4000133")]
			private int <i>5__10;

			[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
			[Cpp2IlInjected.Token(Token = "0x4000134")]
			private TaskAwaiter<bool> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
			[Cpp2IlInjected.Token(Token = "0x4000135")]
			private TaskAwaiter <>u__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
			[Cpp2IlInjected.Token(Token = "0x4000136")]
			private object <>u__3;

			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x981ABF0", Offset = "0x98195F0", VA = "0x18981ABF0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x981C6B0", Offset = "0x981B0B0", VA = "0x18981C6B0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000022")]
		[CompilerGenerated]
		private struct <ProcessShapesForNode>d__7 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000137")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000138")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000139")]
			public FDPQDCZIFNA pv;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400013A")]
			public ExportContext ctx;

			[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
			[Cpp2IlInjected.Token(Token = "0x400013B")]
			public NodeBuilder containerNode;

			[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
			[Cpp2IlInjected.Token(Token = "0x400013C")]
			private int <shapeCountInContainer>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
			[Cpp2IlInjected.Token(Token = "0x400013D")]
			private float3 <containerScale>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
			[Cpp2IlInjected.Token(Token = "0x400013E")]
			private int <shapeIndex>5__4;

			[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
			[Cpp2IlInjected.Token(Token = "0x400013F")]
			private TaskAwaiter<bool> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x981C720", Offset = "0x981B120", VA = "0x18981C720", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x981D2D0", Offset = "0x981BCD0", VA = "0x18981D2D0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000023")]
		[CompilerGenerated]
		private struct <WriteGlbModel>d__6 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000140")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000141")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000142")]
			public UUYHHZWTGNG progress;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000143")]
			public ModelRoot model;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000144")]
			public Stream output;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000145")]
			private object <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x981D5F0", Offset = "0x981BFF0", VA = "0x18981D5F0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x981D960", Offset = "0x981C360", VA = "0x18981D960", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x9819330", Offset = "0x9817D30", VA = "0x189819330")]
		public static bool VGNXTRUUYIZ(FDPQDCZIFNA? a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x9817F10", Offset = "0x9816910", VA = "0x189817F10")]
		public static bool FMOLAOEXRLD(FDPQDCZIFNA? a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x9818B80", Offset = "0x9817580", VA = "0x189818B80")]
		private static bool NZVKVHXUKJP(FDPQDCZIFNA? a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x9817DB0", Offset = "0x98167B0", VA = "0x189817DB0")]
		[AsyncStateMachine(typeof(<BuildR1GlbModel>d__3))]
		public static Task<ModelRoot> DNGYIUUVPIZ(FDPQDCZIFNA[] a, KGAFOUMCVHY b, [Optional] UUYHHZWTGNG? progress, [Optional] CancellationToken c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x98188B0", Offset = "0x98172B0", VA = "0x1898188B0")]
		[AsyncStateMachine(typeof(<BuildR2GlbModel>d__5))]
		public static Task<ModelRoot> LLMQKDIRSFW(FDPQDCZIFNA[] a, JKZAGQGUSZL[] b, KGAFOUMCVHY c, [Optional] UUYHHZWTGNG? progress, [Optional] CancellationToken d)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x98193F0", Offset = "0x9817DF0", VA = "0x1898193F0")]
		[AsyncStateMachine(typeof(<WriteGlbModel>d__6))]
		public static Task WriteGlbModel(ModelRoot model, Stream output, [Optional] UUYHHZWTGNG? progress)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x9818A30", Offset = "0x9817430", VA = "0x189818A30")]
		[AsyncStateMachine(typeof(<ProcessShapesForNode>d__7))]
		private static Task LUMYYZXWDIO(NodeBuilder a, FDPQDCZIFNA b, ExportContext c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x9818CA0", Offset = "0x98176A0", VA = "0x189818CA0")]
		private static MeshBuilder<MaterialBuilder, VertexPositionNormal, VertexTexture1, VertexEmpty> OPOXSREAJLK(PrimitiveShapeMeshType a, string b, ShapeColor c, ShapeMaterial d, float e, float3 f, bool g, float h, float3 i, ExportContext j)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x9819500", Offset = "0x9817F00", VA = "0x189819500")]
		private static MaterialBuilder YDFWLSEDEHS(ShapeColor a, ShapeMaterial b, ExportContext c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x98192A0", Offset = "0x9817CA0", VA = "0x1898192A0")]
		private static float PMEBZMGCZLO(float a)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x9818100", Offset = "0x9816B00", VA = "0x189818100")]
		private static MeshBuilder<MaterialBuilder, VertexPositionNormal, VertexTexture1, VertexEmpty> FOERUYGXNMV(string a, JZLQQLGVCEB b, MaterialBuilder c, [Optional] float2[]? perCornerUvs)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x9817990", Offset = "0x9816390", VA = "0x189817990")]
		[CompilerGenerated]
		internal static NodeBuilder AFJOCJFGEBY(ExportContext a, NodeBuilder b, FDPQDCZIFNA c)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public static class LBYTYNZQQAF
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000025")]
		[CompilerGenerated]
		private struct <WriteGlbModel>d__1 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000146")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000147")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000148")]
			public ModelRoot model;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000149")]
			public Stream output;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400014A")]
			private object <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x981D330", Offset = "0x981BD30", VA = "0x18981D330", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x981D590", Offset = "0x981BF90", VA = "0x18981D590", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x9813E20", Offset = "0x9812820", VA = "0x189813E20")]
		public static ModelRoot BuildGlbModel(string sceneName, IReadOnlyList<UAOCQJVAFZA> meshExports)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x9814D30", Offset = "0x9813730", VA = "0x189814D30")]
		[AsyncStateMachine(typeof(<WriteGlbModel>d__1))]
		public static Task WriteGlbModel(ModelRoot model, Stream output)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x9814E20", Offset = "0x9813820", VA = "0x189814E20")]
		private static MaterialBuilder YDFWLSEDEHS(VSULZHIWWII? matData, Dictionary<VSULZHIWWII, MaterialBuilder> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x9811F70", Offset = "0x9810970", VA = "0x189811F70")]
		private static ImageBuilder? PFJYBTSZAAF(byte[]? a, string name)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x9814CA0", Offset = "0x98136A0", VA = "0x189814CA0")]
		private static float PMEBZMGCZLO(float a)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x9814440", Offset = "0x9812E40", VA = "0x189814440")]
		private static IMeshBuilder<MaterialBuilder> FOERUYGXNMV(string a, JZLQQLGVCEB b, MaterialBuilder c)
		{
			return null;
		}
	}
}
namespace RecRoom.ExportTools.Internal
{
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	internal static class GGWLMAXYYQI
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x9813970", Offset = "0x9812370", VA = "0x189813970")]
		public static bool UJROKURZHYN(PrimitiveShapeMeshType a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x9813670", Offset = "0x9812070", VA = "0x189813670")]
		public static void LQPPRSTVKFX(PrimitiveShapeMeshType a, float3 b, BevelConfig c, [Out] float3 d, [Out] float e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x9813990", Offset = "0x9812390", VA = "0x189813990")]
		public static JZLQQLGVCEB WADZJWIRAWY(JZLQQLGVCEB a, PrimitiveShapeMeshType b, float3 c, float d)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	internal static class PZIQNUAKRBM
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x9815CE0", Offset = "0x98146E0", VA = "0x189815CE0")]
		public static Vector3 IMENNOQTDLO(float3 a)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x9815E50", Offset = "0x9814850", VA = "0x189815E50")]
		public static Quaternion QIPVLLCYJMB(quaternion a)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x8C107F0", Offset = "0x8C0F1F0", VA = "0x188C107F0")]
		public static Vector3 SYWGPTEJCLN(float3 a)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x9815CE0", Offset = "0x98146E0", VA = "0x189815CE0")]
		public static Vector3 PXVPPYIFYBK(float3 a)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x9815C30", Offset = "0x9814630", VA = "0x189815C30")]
		public static quaternion CHDYEAYARDV(float3 a)
		{
			return default(quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x9815D20", Offset = "0x9814720", VA = "0x189815D20")]
		public static quaternion MVRFKYUEAHY(TransformData a)
		{
			return default(quaternion);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	internal static class INELDWKGJPN
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x9813C90", Offset = "0x9812690", VA = "0x189813C90")]
		public static Guid HMTMFOHIADN(ByteString? a)
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x9813DC0", Offset = "0x98127C0", VA = "0x189813DC0")]
		public static string LQXZISZXQMB(ByteString? self)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	internal static class YSTSPQKGNOB
	{
		[Cpp2IlInjected.Token(Token = "0x400014B")]
		public static readonly PrimitiveShapeMeshType[] GWQDFQSNCRA;

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x981FB40", Offset = "0x981E540", VA = "0x18981FB40")]
		public static PrimitiveShapeMeshType IKSAGXONXHJ(ShapeType a)
		{
			return default(PrimitiveShapeMeshType);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	internal static class OPAKESEIYJD
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x9815B00", Offset = "0x9814500", VA = "0x189815B00")]
		public static string JRWRRADAUDG(string a, Dictionary<string, int> b)
		{
			return null;
		}
	}
}
namespace RecRoom.ExportTools.Internal.ShapeExport
{
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	internal static class ZAFEBQPTPNI
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x981FC80", Offset = "0x981E680", VA = "0x18981FC80")]
		public static JZLQQLGVCEB IGSHMKUBJWY(PrimitiveShapeMeshType a, float3 b, float c, KGAFOUMCVHY d, Dictionary<PrimitiveShapeMeshType, JZLQQLGVCEB?> primitiveMeshCache)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x981FE20", Offset = "0x981E820", VA = "0x18981FE20")]
		public static float2[] VJHCYHVCPUE(JZLQQLGVCEB a, float3 b, bool c, float d, float e, float3 f)
		{
			return null;
		}
	}
}
namespace RecRoom.ExportTools.Internal.CurveExport
{
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	internal static class YHZJYCXPBRH
	{
		[Cpp2IlInjected.Token(Token = "0x400014C")]
		public static readonly float3 KKPKGAFNPAA;

		[Cpp2IlInjected.Token(Token = "0x400014D")]
		public static readonly float3 BZWQMJVMCKW;

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x981F2B0", Offset = "0x981DCB0", VA = "0x18981F2B0")]
		public static float3 GTJUVZHBRTR(quaternion a)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x981F7C0", Offset = "0x981E1C0", VA = "0x18981F7C0")]
		public static float3 MGGWJFQZRSB(quaternion a)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x981F740", Offset = "0x981E140", VA = "0x18981F740")]
		public static quaternion IYPZUAEPOID(float3 a, float3 b)
		{
			return default(quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x981F460", Offset = "0x981DE60", VA = "0x18981F460")]
		public static float HNZMMLQUAFP(float3 a, float3 b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x981F970", Offset = "0x981E370", VA = "0x18981F970")]
		public static float UKPWSORJFRR(float3 a, float3 b, float3 c)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x981E480", Offset = "0x981CE80", VA = "0x18981E480")]
		public static float3 AAVKPRLWSRM(float3 a, float3 b, float3 c)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x981E890", Offset = "0x981D290", VA = "0x18981E890")]
		public static quaternion ESRORWRJJHY(quaternion a, float3 b)
		{
			return default(quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x981F600", Offset = "0x981E000", VA = "0x18981F600")]
		public static bool HPOFHGWNCJO(float3 a, float3 b, [Out] float3 c, bool d)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x981EED0", Offset = "0x981D8D0", VA = "0x18981EED0")]
		public static float3 GAETRHGJRAJ(bool a, [Optional] quaternion b)
		{
			return default(float3);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	internal static class RLYITWKNVRX
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x9815EC0", Offset = "0x98148C0", VA = "0x189815EC0")]
		public static JZLQQLGVCEB EUMUFLQYOSG(CurveShapeData a, ShapeType b, int c, float d, float3 e, float f, float g)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x9816DF0", Offset = "0x98157F0", VA = "0x189816DF0")]
		private static void IRHGZQACXJU(float3[] a, float3[] b, float2[] c, int d, float3 e, float3 f, float3 g, float h, bool i, float j)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x9817550", Offset = "0x9815F50", VA = "0x189817550")]
		private static void OHTRRUMOKNN(ExportCurvePointData a, ExportRingSegment b, float3[] c, float3[] d, float2[] e, int f, float g, float h, float i, float3 j, float k)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x9816F00", Offset = "0x9815900", VA = "0x189816F00")]
		private static void OAOOHYHZUIZ(ExportRingSegment a, float3[] b, float3[] c, float2[] d, int[] e, int f, int g, float3 h, float3x3 i, bool j, float k, int l, bool m, float n, float o, float3 p, float q)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	internal struct ExportCurvePointData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400014E")]
		public float3 Position;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x400014F")]
		public float3x3 Rotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000150")]
		public float Radius;
	}
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	internal static class ZAUIMEBNHFO
	{
		[Cpp2IlInjected.Token(Token = "0x2000030")]
		private struct PointSrcData
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000151")]
			public float3 Position;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
			[Cpp2IlInjected.Token(Token = "0x4000152")]
			public quaternion Rotation;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
			[Cpp2IlInjected.Token(Token = "0x4000153")]
			public float Radius;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000154")]
			public quaternion BlendedRotation;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000155")]
			public float BendAngle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
			[Cpp2IlInjected.Token(Token = "0x4000156")]
			public float BendRadius;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000157")]
			public float DistanceToNext;
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x98205D0", Offset = "0x981EFD0", VA = "0x1898205D0")]
		public static List<ExportCurvePointData> Generate(IReadOnlyList<float3> positions, IReadOnlyList<float3> normals, IReadOnlyList<float> radii, int configFlags, float heightScale)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x98202E0", Offset = "0x981ECE0", VA = "0x1898202E0")]
		private static float3[] BEFXTVFLVYX(IReadOnlyList<float3> a, bool b, bool c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x9821200", Offset = "0x981FC00", VA = "0x189821200")]
		private static List<ExportCurvePointData> NJGRNLDOHGT(List<PointSrcData> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x98222A0", Offset = "0x9820CA0", VA = "0x1898222A0")]
		private static bool QDLKOIURNSC(int a, List<ExportCurvePointData> b, List<PointSrcData> c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x9820C70", Offset = "0x981F670", VA = "0x189820C70")]
		private static ExportCurvePointData MZYGUFTPDAS(int a, List<PointSrcData> b)
		{
			return default(ExportCurvePointData);
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x9821590", Offset = "0x981FF90", VA = "0x189821590")]
		private static List<ExportCurvePointData> NTYUODIBUXH(List<PointSrcData> a, float b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x9822F40", Offset = "0x9821940", VA = "0x189822F40")]
		private static ExportCurvePointData VWZQNKMIPHA(PointSrcData a)
		{
			return default(ExportCurvePointData);
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x9820BE0", Offset = "0x981F5E0", VA = "0x189820BE0")]
		private static ExportCurvePointData HCHWTBEMRXB(float3 a, quaternion b, float c)
		{
			return default(ExportCurvePointData);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	internal struct ExportRingVertex
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000158")]
		public float2 Offset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000159")]
		public float2 Normal;
	}
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	internal struct ExportRingSegment
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400015A")]
		public ExportRingVertex[] RingVerts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400015B")]
		public int[] RingIndices;
	}
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	internal static class UTNYMNWKPOO
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x981DA40", Offset = "0x981C440", VA = "0x18981DA40")]
		public static ExportRingSegment ESNRPCFLHHD(int a)
		{
			return default(ExportRingSegment);
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x981DEA0", Offset = "0x981C8A0", VA = "0x18981DEA0")]
		public static ExportRingSegment TAFCQZVOQIK(int a)
		{
			return default(ExportRingSegment);
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x981DA10", Offset = "0x981C410", VA = "0x18981DA10")]
		public static ExportRingSegment BDMGEDQWWQL()
		{
			return default(ExportRingSegment);
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x981DDF0", Offset = "0x981C7F0", VA = "0x18981DDF0")]
		public static int GDKUMAEBULX(int a, int b, bool c, bool d, bool e)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x981DE50", Offset = "0x981C850", VA = "0x18981DE50")]
		public static int KSBJZWZPOFB(int a, int b, bool c, bool d, bool e)
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
