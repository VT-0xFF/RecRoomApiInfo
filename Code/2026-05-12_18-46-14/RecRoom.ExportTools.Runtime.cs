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
		[Cpp2IlInjected.Address(RVA = "0xD341B0", Offset = "0xD32BB0", VA = "0x180D341B0")]
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
		[Cpp2IlInjected.Address(RVA = "0x9979E50", Offset = "0x9978850", VA = "0x189979E50")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xD34A80", Offset = "0xD33480", VA = "0x180D34A80")]
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
		[Cpp2IlInjected.Address(RVA = "0xD34AC0", Offset = "0xD334C0", VA = "0x180D34AC0")]
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
		[Cpp2IlInjected.Address(RVA = "0x9975510", Offset = "0x9973F10", VA = "0x189975510")]
		public static ModelRoot BuildAvatarGlbModel(string sceneName, ZYPKWOMNBIE[] nodes)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x9976C50", Offset = "0x9975650", VA = "0x189976C50")]
		private static MaterialBuilder YDFWLSEDEHS(VSULZHIWWII? matData, Dictionary<VSULZHIWWII, MaterialBuilder> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x99762B0", Offset = "0x9974CB0", VA = "0x1899762B0")]
		private static ImageBuilder? PFJYBTSZAAF(byte[]? a, string name)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x9976310", Offset = "0x9974D10", VA = "0x189976310")]
		private static float PMEBZMGCZLO(float a)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x9975B40", Offset = "0x9974540", VA = "0x189975B40")]
		private static IMeshBuilder<MaterialBuilder> FOERUYGXNMV(string a, JZLQQLGVCEB b, MaterialBuilder c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x99763A0", Offset = "0x9974DA0", VA = "0x1899763A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x9982830", Offset = "0x9981230", VA = "0x189982830")]
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
		[Cpp2IlInjected.Address(RVA = "0x9988770", Offset = "0x9987170", VA = "0x189988770")]
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
			[Cpp2IlInjected.Address(RVA = "0x9977500", Offset = "0x9975F00", VA = "0x189977500")]
			get
			{
				return default(ColorRGB);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public static ColorRGB SOYMJLOTOVF
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x105FB60", Offset = "0x105E560", VA = "0x18105FB60")]
			get
			{
				return default(ColorRGB);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x2B8AE20", Offset = "0x2B89820", VA = "0x182B8AE20")]
		public ColorRGB(float r, float g, float b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public class CLVXXDMVJZA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public string KPIDBUYRLLN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		public ColorRGB CWBFGTAZPQQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public float WUJAAPJKDJS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		public byte[]? GSWDUSYGRLI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public byte[]? MRCNWMMOMFL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public float QWQJPOLXCQX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public ColorRGB QURGLJPCYNQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		public byte[]? VQEQHDALYHD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		public float CBUBXJOFJDM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		public float XPVGWGYFKBX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		public float YYRILWYIYYG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		public byte[]? VJMZNIMZBXZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		public bool ZBAGGWVCBCW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		public float? WZBLKEWNZOF;

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x9977460", Offset = "0x9975E60", VA = "0x189977460")]
		public CLVXXDMVJZA()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public class QDIAPBNTDPE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		public string KPIDBUYRLLN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public float3 OYWTYXOICNS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public quaternion SILHDFYWFMV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public float3 AQJHARNXCDR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public JZLQQLGVCEB SEPNJECHARX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public CLVXXDMVJZA? DMNWOMXIVEB;

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x997A290", Offset = "0x9978C90", VA = "0x18997A290")]
		public QDIAPBNTDPE(string a, float3 b, quaternion c, float3 d, JZLQQLGVCEB e, CLVXXDMVJZA? material)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public class PDYPULBSWLN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public string DOPDVBKWPXV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		public MaterialColorUsage TLNHXYPHGIK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public ColorRGB SMEJZRYYLMB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public ColorRGB QURGLJPCYNQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public ColorRGB PFSLMBNTBPO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public float BAAIFBCYOIS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public MFPZTNNQEMV? WBCXOYIMCKZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public MFPZTNNQEMV? TMFDBCIUKZA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public MFPZTNNQEMV? VJSDQIVKXLM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public MFPZTNNQEMV? NQQQBKZYYOA;

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x9979FB0", Offset = "0x99789B0", VA = "0x189979FB0")]
		public PDYPULBSWLN()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	internal readonly struct MaterialExportKey : IEquatable<MaterialExportKey>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public readonly ShapeColor ShapeColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public readonly ShapeMaterial ShapeMaterial;

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0xEE1960", Offset = "0xEE0360", VA = "0x180EE1960")]
		public MaterialExportKey(ShapeColor shapeColor, ShapeMaterial shapeMaterial)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x1452E10", Offset = "0x1451810", VA = "0x181452E10", Slot = "4")]
		public bool Equals(MaterialExportKey other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x9979900", Offset = "0x9978300", VA = "0x189979900", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x9979990", Offset = "0x9978390", VA = "0x189979990", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	internal readonly struct MeshBuilderCacheKey : IEquatable<MeshBuilderCacheKey>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		public readonly PrimitiveShapeMeshType MeshType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public readonly MaterialExportKey Material;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public readonly float3 BevelScalingRatio;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public readonly float BevelAuthoredRatio;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public readonly float3 WorldScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public readonly bool DynamicProjection;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public readonly float ContainerScaleX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public readonly float UvScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public readonly float3 UvOffset;

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x9979DE0", Offset = "0x99787E0", VA = "0x189979DE0")]
		public MeshBuilderCacheKey(PrimitiveShapeMeshType meshType, MaterialExportKey material, [Optional] float3 bevelScalingRatio, float bevelAuthoredRatio = 0f, [Optional] float3 worldScale, bool dynamicProjection = false, float containerScaleX = 0f, float uvScale = 0f, [Optional] float3 uvOffset)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x9979A00", Offset = "0x9978400", VA = "0x189979A00", Slot = "4")]
		public bool Equals(MeshBuilderCacheKey other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x9979B90", Offset = "0x9978590", VA = "0x189979B90", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x9979C40", Offset = "0x9978640", VA = "0x189979C40", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public class JZLQQLGVCEB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public float3[] ICUTMTEPZVV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public int[] PHLVAANKWVP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public float3[] FRTHDLVTDSU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public float2[]? DDBWYGVQUOO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public float2[]? XBYCSIYTXVV;

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x8B725E0", Offset = "0x8B70FE0", VA = "0x188B725E0")]
		public JZLQQLGVCEB(float3[] a, int[] b, float3[] c, [Optional] float2[]? uv0s, [Optional] float2[]? uv1s)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public class UAOCQJVAFZA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public string KPIDBUYRLLN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public float3 OYWTYXOICNS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public quaternion SILHDFYWFMV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public float3 AQJHARNXCDR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public JZLQQLGVCEB SEPNJECHARX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public VSULZHIWWII? DMNWOMXIVEB;

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x9981E00", Offset = "0x9980800", VA = "0x189981E00")]
		public UAOCQJVAFZA()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public class MFPZTNNQEMV
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public string WHEACKMHEYE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public ImageBuilder? OLXIJAXXIGN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public float2 KJUGRAXUWPR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public float2 ZGYOETDZTFY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public TextureWrapMode PWQGZEAGGVY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public TextureWrapMode PWLABXGIXKP;

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x99798B0", Offset = "0x99782B0", VA = "0x1899798B0")]
		public MFPZTNNQEMV()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[Flags]
	public enum MaterialColorUsage
	{
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		ALBEDO = 1,
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		EMISSIVE = 2,
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		SPECULAR = 4,
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		HOLOGRAPHIC = 8
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public enum PrimitiveShapeMeshType
	{
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		Invalid = -1,
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		RR_Box,
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		RR_Sphere,
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		RR_Cylinder,
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		RR_Wedge,
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		RR_Pyramid,
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		RR_HalfSphere,
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		RR_Cone,
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		RR_Pipe,
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		RR_Donut,
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		RR_HalfPipe,
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		RR_Diamond,
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		ADVANCED_Mound,
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		LEGACY_Box,
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		ADVANCED_Cube,
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		ADVANCED_Sphere,
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		ADVANCED_Cylinder,
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		ADVANCED_Cone,
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		ADVANCED_Pyramid,
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		ADVANCED_Octagon,
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		ADVANCED_Triangle,
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		ADVANCED_Hexagon,
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		ADVANCED_QuarterPipe,
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		ADVANCED_Pentagon,
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		ADVANCED_Dodecahedron,
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		ADVANCED_Trihedron,
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		ADVANCED_Octahedron,
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		RR_QuarterCylinder,
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		RR_Pentagon,
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		RR_QuarterSphere,
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		ADVANCED_Wedge,
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		RR_Hexagon,
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		RR_Octagon,
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		RR_Triangle,
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		Count
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public enum ShapeColor
	{
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		RED = 0,
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		ORANGE = 1,
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		YELLOW = 2,
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		GREEN = 3,
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		DARK_GREEN = 4,
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		CYAN = 5,
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		BLUE = 6,
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		DARK_BLUE = 7,
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		PURPLE = 8,
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		PINK = 9,
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		BROWN = 10,
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		WHITE = 11,
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		GREY = 12,
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		BLACK = 13,
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		DARK_ORANGE = 14,
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		LIME = 15,
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		LIGHT_GREEN = 16,
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		AQUAMARINE = 17,
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		LIGHT_BLUE = 18,
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		LAVENDER = 19,
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		MAGENTA = 20,
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		SALMON = 21,
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		TAN = 22,
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		CREAM = 23,
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		LIGHT_GREY = 24,
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		DARK_GREY = 25,
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		NEW_COLOR_0 = 26,
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		NEW_COLOR_1 = 27,
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		NEW_COLOR_2 = 28,
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		NEW_COLOR_3 = 29,
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		NEW_COLOR_4 = 30,
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		NEW_COLOR_5 = 31,
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		NEW_COLOR_6 = 32,
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		UNUSED_SEE_COMMENT = 33,
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		NEW_COLOR_7 = 34,
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		NEW_COLOR_8 = 35,
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		NEW_COLOR_9 = 36,
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		NEW_COLOR_10 = 37,
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		NEW_COLOR_11 = 38,
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		NEW_COLOR_12 = 39,
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		NEW_COLOR_13 = 40,
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		NEW_COLOR_14 = 41,
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		NEW_COLOR_15 = 42,
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		NEW_COLOR_16 = 43,
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		NEW_COLOR_17 = 44,
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		NEW_COLOR_18 = 45,
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		NEW_COLOR_19 = 46,
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		NEW_COLOR_20 = 47,
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		NEW_COLOR_21 = 48,
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		NEW_COLOR_22 = 49,
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		NEW_COLOR_23 = 50,
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		NEW_COLOR_24 = 51,
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		NEW_COLOR_25 = 52,
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		NEW_COLOR_26 = 53,
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		NEW_COLOR_27 = 54,
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		NEW_COLOR_28 = 55,
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		NEW_COLOR_29 = 56,
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		NEW_COLOR_30 = 57,
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		NEW_COLOR_31 = 58,
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		NEW_COLOR_32 = 59,
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		NEW_COLOR_33 = 60,
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		GENERATED_COLOR_START = 1000
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public enum ShapeMaterial
	{
		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		INVALID = -1,
		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		CARDBOARD = 0,
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		METAL = 1,
		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		RUBBER = 2,
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		PLASTIC = 3,
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		NEON = 4,
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		WOOD = 5,
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		GLASS = 6,
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		ROCK = 7,
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		ICE = 8,
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		GOLD = 9,
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		SAND = 10,
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		LEATHER = 11,
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		GRID = 12,
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		TILE = 13,
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		GRASS = 14,
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		BARK = 15,
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		CONCRETE = 16,
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		SNOW = 17,
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		CARPET = 18,
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		FABRIC = 19,
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		FOIL = 20,
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		FLESH = 21,
		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		GALAXY = 22,
		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		LAVA = 23,
		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		WATER = 24,
		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		CANDY = 25,
		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		FUR = 26,
		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		CHAIN_MAIL = 27,
		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		PLACEHOLDER_14 = 28,
		[Cpp2IlInjected.Token(Token = "0x40000E1")]
		PLACEHOLDER_15 = 29,
		[Cpp2IlInjected.Token(Token = "0x40000E2")]
		PLACEHOLDER_16 = 30,
		[Cpp2IlInjected.Token(Token = "0x40000E3")]
		PLACEHOLDER_18 = 31,
		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		MIN_VALUE = -1,
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		MAX_VALUE = 31,
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		COUNT = 32,
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		DEFAULT = 0
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public enum ShapeType
	{
		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		Invalid = -1,
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		CURVE_Tube = 0,
		[Cpp2IlInjected.Token(Token = "0x40000EB")]
		CURVE_Ribbon = 1,
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		LegacyBox = 2,
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		RR_Sphere = 3,
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		RR_Cylinder = 4,
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		LEGACY_Wedge = 5,
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		LEGACY_Pyramid = 6,
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		LEGACY_TriggerVolumeBox = 7,
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		RR_Box = 8,
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		LEGACY_RoundedBox = 9,
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		RR_Wedge = 10,
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		RR_Pyramid = 11,
		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		RR_HalfSphere = 12,
		[Cpp2IlInjected.Token(Token = "0x40000F7")]
		RR_Cone = 13,
		[Cpp2IlInjected.Token(Token = "0x40000F8")]
		RR_Pipe = 14,
		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		RR_Donut = 15,
		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		RR_HalfPipe = 16,
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		RR_Diamond = 17,
		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		ADVANCED_Mound = 18,
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		ADVANCED_Cube = 19,
		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		ADVANCED_Sphere = 20,
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		ADVANCED_Cylinder = 21,
		[Cpp2IlInjected.Token(Token = "0x4000100")]
		ADVANCED_Cone = 22,
		[Cpp2IlInjected.Token(Token = "0x4000101")]
		ADVANCED_Pyramid = 23,
		[Cpp2IlInjected.Token(Token = "0x4000102")]
		ADVANCED_Octagon = 24,
		[Cpp2IlInjected.Token(Token = "0x4000103")]
		ADVANCED_Triangle = 25,
		[Cpp2IlInjected.Token(Token = "0x4000104")]
		ADVANCED_Hexagon = 26,
		[Cpp2IlInjected.Token(Token = "0x4000105")]
		ADVANCED_QuarterPipe = 27,
		[Cpp2IlInjected.Token(Token = "0x4000106")]
		ADVANCED_Pentagon = 28,
		[Cpp2IlInjected.Token(Token = "0x4000107")]
		ADVANCED_Dodecahedron = 29,
		[Cpp2IlInjected.Token(Token = "0x4000108")]
		ADVANCED_Trihedron = 30,
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		ADVANCED_Octahedron = 31,
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		RR_QuarterCylinder = 32,
		[Cpp2IlInjected.Token(Token = "0x400010B")]
		RR_Pentagon = 33,
		[Cpp2IlInjected.Token(Token = "0x400010C")]
		RR_QuarterSphere = 34,
		[Cpp2IlInjected.Token(Token = "0x400010D")]
		ADVANCED_Wedge = 35,
		[Cpp2IlInjected.Token(Token = "0x400010E")]
		RR_Hexagon = 36,
		[Cpp2IlInjected.Token(Token = "0x400010F")]
		RR_Octagon = 37,
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		RR_Triangle = 38,
		[Cpp2IlInjected.Token(Token = "0x4000111")]
		COUNT = 39,
		[Cpp2IlInjected.Token(Token = "0x4000112")]
		MIN_VALUE = -1,
		[Cpp2IlInjected.Token(Token = "0x4000113")]
		MAX_VALUE = 38
	}
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public enum TextureWrapMode
	{
		[Cpp2IlInjected.Token(Token = "0x4000115")]
		Repeat,
		[Cpp2IlInjected.Token(Token = "0x4000116")]
		Clamp,
		[Cpp2IlInjected.Token(Token = "0x4000117")]
		Other
	}
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public static class GVIBCHKZCVV
	{
		[Cpp2IlInjected.Token(Token = "0x2000019")]
		public struct ProfileSession : IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000118")]
			private readonly string? _outputPath;

			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x997A280", Offset = "0x9978C80", VA = "0x18997A280")]
			internal ProfileSession(string? outputPath)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0xD0A4C0", Offset = "0xD08EC0", VA = "0x180D0A4C0", Slot = "4")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001A")]
		internal struct ProfileSection : IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000119")]
			private readonly string? _name;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400011A")]
			private readonly int _depth;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400011B")]
			private readonly long _startTicks;

			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x997A270", Offset = "0x9978C70", VA = "0x18997A270")]
			internal ProfileSection(string name)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0xD0A4C0", Offset = "0xD08EC0", VA = "0x180D0A4C0", Slot = "4")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0xD0A4D0", Offset = "0xD08ED0", VA = "0x180D0A4D0")]
		public static ProfileSession ONZPJVMVHLX(string? a)
		{
			return default(ProfileSession);
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x1845070", Offset = "0x1843A70", VA = "0x181845070")]
		internal static ProfileSection Section(string name)
		{
			return default(ProfileSection);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public class JKZAGQGUSZL
	{
		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public string? KPIDBUYRLLN
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0xD0CCC0", Offset = "0xD0B6C0", VA = "0x180D0CCC0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0xD0C6D0", Offset = "0xD0B0D0", VA = "0x180D0C6D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public int? JCAXWUWFZBC
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0xD11A70", Offset = "0xD10470", VA = "0x180D11A70")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0xE26CF0", Offset = "0xE256F0", VA = "0x180E26CF0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0xD10590", Offset = "0xD0EF90", VA = "0x180D10590")]
		public JKZAGQGUSZL()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public interface KGAFOUMCVHY
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(Slot = "0")]
		JZLQQLGVCEB? TJOCMZKYOQA(PrimitiveShapeMeshType a, int b = 0);

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		BevelConfig RSSRAMPWADM();

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		PDYPULBSWLN? GetMaterialExportData(ShapeColor shapeColor, ShapeMaterial shapeMaterial);

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(Slot = "3")]
		bool DRMQJFEHOCO(Guid a, [Out] string b);
	}
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	public interface EMGUUJRGOMM
	{
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Task<IReadOnlyList<UAOCQJVAFZA>> WVOQZDSDNCR(SpawnableTemplateData a, CancellationToken b);
	}
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public static class WDURBPJKNSH
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x9983010", Offset = "0x9981A10", VA = "0x189983010")]
		public static ModelRoot FVHGPSLUBFR(string a, QDIAPBNTDPE[] b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x9983590", Offset = "0x9981F90", VA = "0x189983590")]
		private static MaterialBuilder YDFWLSEDEHS(CLVXXDMVJZA? matData, Dictionary<CLVXXDMVJZA, MaterialBuilder> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x99762B0", Offset = "0x9974CB0", VA = "0x1899762B0")]
		private static ImageBuilder? PFJYBTSZAAF(byte[]? a, string name)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x9983500", Offset = "0x9981F00", VA = "0x189983500")]
		private static float PMEBZMGCZLO(float a)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x99828C0", Offset = "0x99812C0", VA = "0x1899828C0")]
		private static IMeshBuilder<MaterialBuilder> FOERUYGXNMV(string a, JZLQQLGVCEB b, MaterialBuilder c)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public static class SZGWZRLGTDX
	{
		[Cpp2IlInjected.Token(Token = "0x2000020")]
		public static class GNMOUREVCFV
		{
			[Cpp2IlInjected.Token(Token = "0x2000021")]
			public static class EFUZXDCYMMP
			{
				[Cpp2IlInjected.Token(Token = "0x400011E")]
				public static readonly Guid JWNNLLGFFFB;

				[Cpp2IlInjected.Token(Token = "0x400011F")]
				public static readonly Guid VMCAKRQCMJT;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000022")]
		private readonly struct ExportContext
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000120")]
			public readonly SceneBuilder SceneBuilder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000121")]
			public readonly KGAFOUMCVHY Dependencies;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000122")]
			public readonly BevelConfig BevelConfig;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000123")]
			public readonly Dictionary<string, int> NodeNameToCountMap;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000124")]
			public readonly Dictionary<MaterialExportKey, MaterialBuilder> MaterialCache;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000125")]
			public readonly Dictionary<PrimitiveShapeMeshType, JZLQQLGVCEB?> PrimitiveMeshCache;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000126")]
			public readonly Dictionary<MeshBuilderCacheKey, MeshBuilder<MaterialBuilder, VertexPositionNormal, VertexTexture1, VertexEmpty>> MeshBuilderCache;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000127")]
			public readonly UUYHHZWTGNG? Progress;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000128")]
			public readonly UFPXWURGTMD TimedYielder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4000129")]
			public readonly CancellationToken CancellationToken;

			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x9977970", Offset = "0x9976370", VA = "0x189977970")]
			private ExportContext(SceneBuilder sceneBuilder, KGAFOUMCVHY dependencies, BevelConfig bevelConfig, Dictionary<string, int> nodeNameToCountMap, Dictionary<MaterialExportKey, MaterialBuilder> materialCache, Dictionary<PrimitiveShapeMeshType, JZLQQLGVCEB?> primitiveMeshCache, Dictionary<MeshBuilderCacheKey, MeshBuilder<MaterialBuilder, VertexPositionNormal, VertexTexture1, VertexEmpty>> meshBuilderCache, UUYHHZWTGNG? progress, UFPXWURGTMD timedYielder, CancellationToken cancellationToken)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x9977610", Offset = "0x9976010", VA = "0x189977610")]
			public static ExportContext New(KGAFOUMCVHY dependencies, UUYHHZWTGNG? progress, CancellationToken cancellationToken)
			{
				return default(ExportContext);
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000023")]
		[CompilerGenerated]
		private struct <BuildR1GlbModel>d__3 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400012A")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400012B")]
			public AsyncTaskMethodBuilder<ModelRoot> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400012C")]
			public FDPQDCZIFNA[] persistenceViewDatas;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400012D")]
			public KGAFOUMCVHY dependencies;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400012E")]
			public UUYHHZWTGNG progress;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400012F")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000130")]
			private GVIBCHKZCVV.ProfileSection <_exportSection>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4000131")]
			private ExportContext <ctx>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
			[Cpp2IlInjected.Token(Token = "0x4000132")]
			private Queue<(NodeBuilder parentNode, FDPQDCZIFNA data)> <queue>5__4;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
			[Cpp2IlInjected.Token(Token = "0x4000133")]
			private FDPQDCZIFNA <pv>5__5;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
			[Cpp2IlInjected.Token(Token = "0x4000134")]
			private NodeBuilder <node>5__6;

			[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
			[Cpp2IlInjected.Token(Token = "0x4000135")]
			private int <childViewCount>5__7;

			[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
			[Cpp2IlInjected.Token(Token = "0x4000136")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
			[Cpp2IlInjected.Token(Token = "0x4000137")]
			private object <>u__2;

			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x997E030", Offset = "0x997CA30", VA = "0x18997E030", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x997EFE0", Offset = "0x997D9E0", VA = "0x18997EFE0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000024")]
		[CompilerGenerated]
		private struct <BuildR2GlbModel>d__5 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000138")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000139")]
			public AsyncTaskMethodBuilder<ModelRoot> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400013A")]
			public FDPQDCZIFNA[] persistenceViewDatas;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400013B")]
			public KGAFOUMCVHY dependencies;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400013C")]
			public UUYHHZWTGNG progress;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400013D")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400013E")]
			public JKZAGQGUSZL[] nodeInfos;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400013F")]
			private GVIBCHKZCVV.ProfileSection <_exportSection>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x4000140")]
			private FDPQDCZIFNA[] <views>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x4000141")]
			private ExportContext <ctx>5__4;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
			[Cpp2IlInjected.Token(Token = "0x4000142")]
			private NodeBuilder[] <allNodes>5__5;

			[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
			[Cpp2IlInjected.Token(Token = "0x4000143")]
			private bool[] <created>5__6;

			[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
			[Cpp2IlInjected.Token(Token = "0x4000144")]
			private GVIBCHKZCVV.ProfileSection <>7__wrap6;

			[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
			[Cpp2IlInjected.Token(Token = "0x4000145")]
			private NodeBuilder <shapeRootNode>5__8;

			[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
			[Cpp2IlInjected.Token(Token = "0x4000146")]
			private bool <madeProgress>5__9;

			[Cpp2IlInjected.FieldOffset(Offset = "0xFC")]
			[Cpp2IlInjected.Token(Token = "0x4000147")]
			private int <i>5__10;

			[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
			[Cpp2IlInjected.Token(Token = "0x4000148")]
			private TaskAwaiter<bool> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
			[Cpp2IlInjected.Token(Token = "0x4000149")]
			private TaskAwaiter <>u__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
			[Cpp2IlInjected.Token(Token = "0x400014A")]
			private object <>u__3;

			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x997F050", Offset = "0x997DA50", VA = "0x18997F050", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x9980B10", Offset = "0x997F510", VA = "0x189980B10", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000025")]
		[CompilerGenerated]
		private struct <ProcessShapesForNode>d__7 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400014B")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400014C")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400014D")]
			public FDPQDCZIFNA pv;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400014E")]
			public ExportContext ctx;

			[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
			[Cpp2IlInjected.Token(Token = "0x400014F")]
			public NodeBuilder containerNode;

			[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
			[Cpp2IlInjected.Token(Token = "0x4000150")]
			private int <shapeCountInContainer>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
			[Cpp2IlInjected.Token(Token = "0x4000151")]
			private float3 <containerScale>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
			[Cpp2IlInjected.Token(Token = "0x4000152")]
			private int <shapeIndex>5__4;

			[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
			[Cpp2IlInjected.Token(Token = "0x4000153")]
			private TaskAwaiter<bool> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x9980B80", Offset = "0x997F580", VA = "0x189980B80", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x9981720", Offset = "0x9980120", VA = "0x189981720", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000026")]
		[CompilerGenerated]
		private struct <WriteGlbModel>d__6 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000154")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000155")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000156")]
			public UUYHHZWTGNG progress;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000157")]
			public ModelRoot model;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000158")]
			public Stream output;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000159")]
			private object <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x9981A40", Offset = "0x9980440", VA = "0x189981A40", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x9981DA0", Offset = "0x99807A0", VA = "0x189981DA0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x997D790", Offset = "0x997C190", VA = "0x18997D790")]
		public static bool VGNXTRUUYIZ(FDPQDCZIFNA? a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x997C380", Offset = "0x997AD80", VA = "0x18997C380")]
		public static bool FMOLAOEXRLD(FDPQDCZIFNA? a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x997CFF0", Offset = "0x997B9F0", VA = "0x18997CFF0")]
		private static bool NZVKVHXUKJP(FDPQDCZIFNA? a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x997C220", Offset = "0x997AC20", VA = "0x18997C220")]
		[AsyncStateMachine(typeof(<BuildR1GlbModel>d__3))]
		public static Task<ModelRoot> DNGYIUUVPIZ(FDPQDCZIFNA[] a, KGAFOUMCVHY b, [Optional] UUYHHZWTGNG? progress, [Optional] CancellationToken c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x997CD20", Offset = "0x997B720", VA = "0x18997CD20")]
		[AsyncStateMachine(typeof(<BuildR2GlbModel>d__5))]
		public static Task<ModelRoot> LLMQKDIRSFW(FDPQDCZIFNA[] a, JKZAGQGUSZL[] b, KGAFOUMCVHY c, [Optional] UUYHHZWTGNG? progress, [Optional] CancellationToken d)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x997D850", Offset = "0x997C250", VA = "0x18997D850")]
		[AsyncStateMachine(typeof(<WriteGlbModel>d__6))]
		public static Task WriteGlbModel(ModelRoot model, Stream output, [Optional] UUYHHZWTGNG? progress)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x997CEA0", Offset = "0x997B8A0", VA = "0x18997CEA0")]
		[AsyncStateMachine(typeof(<ProcessShapesForNode>d__7))]
		private static Task LUMYYZXWDIO(NodeBuilder a, FDPQDCZIFNA b, ExportContext c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x997D100", Offset = "0x997BB00", VA = "0x18997D100")]
		private static MeshBuilder<MaterialBuilder, VertexPositionNormal, VertexTexture1, VertexEmpty> OPOXSREAJLK(PrimitiveShapeMeshType a, string b, ShapeColor c, ShapeMaterial d, float e, float3 f, bool g, float h, float3 i, ExportContext j)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x997D960", Offset = "0x997C360", VA = "0x18997D960")]
		private static MaterialBuilder YDFWLSEDEHS(ShapeColor a, ShapeMaterial b, ExportContext c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x997D700", Offset = "0x997C100", VA = "0x18997D700")]
		private static float PMEBZMGCZLO(float a)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x997C570", Offset = "0x997AF70", VA = "0x18997C570")]
		private static MeshBuilder<MaterialBuilder, VertexPositionNormal, VertexTexture1, VertexEmpty> FOERUYGXNMV(string a, JZLQQLGVCEB b, MaterialBuilder c, [Optional] float2[]? perCornerUvs)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x997BE00", Offset = "0x997A800", VA = "0x18997BE00")]
		[CompilerGenerated]
		internal static NodeBuilder AFJOCJFGEBY(ExportContext a, NodeBuilder b, FDPQDCZIFNA c)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public static class LBYTYNZQQAF
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000028")]
		[CompilerGenerated]
		private struct <WriteGlbModel>d__1 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400015A")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400015B")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400015C")]
			public ModelRoot model;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400015D")]
			public Stream output;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400015E")]
			private object <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x9981780", Offset = "0x9980180", VA = "0x189981780", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x99819E0", Offset = "0x99803E0", VA = "0x1899819E0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x99781F0", Offset = "0x9976BF0", VA = "0x1899781F0")]
		public static ModelRoot BuildGlbModel(string sceneName, IReadOnlyList<UAOCQJVAFZA> meshExports)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x9979100", Offset = "0x9977B00", VA = "0x189979100")]
		[AsyncStateMachine(typeof(<WriteGlbModel>d__1))]
		public static Task WriteGlbModel(ModelRoot model, Stream output)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x99791F0", Offset = "0x9977BF0", VA = "0x1899791F0")]
		private static MaterialBuilder YDFWLSEDEHS(VSULZHIWWII? matData, Dictionary<VSULZHIWWII, MaterialBuilder> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x99762B0", Offset = "0x9974CB0", VA = "0x1899762B0")]
		private static ImageBuilder? PFJYBTSZAAF(byte[]? a, string name)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x9979070", Offset = "0x9977A70", VA = "0x189979070")]
		private static float PMEBZMGCZLO(float a)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x9978810", Offset = "0x9977210", VA = "0x189978810")]
		private static IMeshBuilder<MaterialBuilder> FOERUYGXNMV(string a, JZLQQLGVCEB b, MaterialBuilder c)
		{
			return null;
		}
	}
}
namespace RecRoom.ExportTools.Internal
{
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	internal static class GGWLMAXYYQI
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x9977D40", Offset = "0x9976740", VA = "0x189977D40")]
		public static bool UJROKURZHYN(PrimitiveShapeMeshType a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x9977A40", Offset = "0x9976440", VA = "0x189977A40")]
		public static void LQPPRSTVKFX(PrimitiveShapeMeshType a, float3 b, BevelConfig c, [Out] float3 d, [Out] float e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x9977D60", Offset = "0x9976760", VA = "0x189977D60")]
		public static JZLQQLGVCEB WADZJWIRAWY(JZLQQLGVCEB a, PrimitiveShapeMeshType b, float3 c, float d)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	internal static class PZIQNUAKRBM
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x997A0B0", Offset = "0x9978AB0", VA = "0x18997A0B0")]
		public static Vector3 IMENNOQTDLO(float3 a)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x997A220", Offset = "0x9978C20", VA = "0x18997A220")]
		public static Quaternion QIPVLLCYJMB(quaternion a)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x8D86680", Offset = "0x8D85080", VA = "0x188D86680")]
		public static Vector3 SYWGPTEJCLN(float3 a)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x997A0B0", Offset = "0x9978AB0", VA = "0x18997A0B0")]
		public static Vector3 PXVPPYIFYBK(float3 a)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x997A000", Offset = "0x9978A00", VA = "0x18997A000")]
		public static quaternion CHDYEAYARDV(float3 a)
		{
			return default(quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x997A0F0", Offset = "0x9978AF0", VA = "0x18997A0F0")]
		public static quaternion MVRFKYUEAHY(TransformData a)
		{
			return default(quaternion);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	internal static class INELDWKGJPN
	{
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x9978060", Offset = "0x9976A60", VA = "0x189978060")]
		public static Guid HMTMFOHIADN(ByteString? a)
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x9978190", Offset = "0x9976B90", VA = "0x189978190")]
		public static string LQXZISZXQMB(ByteString? self)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	internal static class YSTSPQKGNOB
	{
		[Cpp2IlInjected.Token(Token = "0x400015F")]
		public static readonly PrimitiveShapeMeshType[] GWQDFQSNCRA;

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x9985300", Offset = "0x9983D00", VA = "0x189985300")]
		public static PrimitiveShapeMeshType IKSAGXONXHJ(ShapeType a)
		{
			return default(PrimitiveShapeMeshType);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	internal static class OPAKESEIYJD
	{
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x9979ED0", Offset = "0x99788D0", VA = "0x189979ED0")]
		public static string JRWRRADAUDG(string a, Dictionary<string, int> b)
		{
			return null;
		}
	}
}
namespace RecRoom.ExportTools.Internal.ShapeExport
{
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	internal static class ZAFEBQPTPNI
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x9985430", Offset = "0x9983E30", VA = "0x189985430")]
		public static JZLQQLGVCEB IGSHMKUBJWY(PrimitiveShapeMeshType a, float3 b, float c, KGAFOUMCVHY d, Dictionary<PrimitiveShapeMeshType, JZLQQLGVCEB?> primitiveMeshCache)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x99855D0", Offset = "0x9983FD0", VA = "0x1899855D0")]
		public static float2[] VJHCYHVCPUE(JZLQQLGVCEB a, float3 b, bool c, float d, float e, float3 f)
		{
			return null;
		}
	}
}
namespace RecRoom.ExportTools.Internal.CurveExport
{
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	internal static class YHZJYCXPBRH
	{
		[Cpp2IlInjected.Token(Token = "0x4000160")]
		public static readonly float3 KKPKGAFNPAA;

		[Cpp2IlInjected.Token(Token = "0x4000161")]
		public static readonly float3 BZWQMJVMCKW;

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x9984A80", Offset = "0x9983480", VA = "0x189984A80")]
		public static float3 GTJUVZHBRTR(quaternion a)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x9984F90", Offset = "0x9983990", VA = "0x189984F90")]
		public static float3 MGGWJFQZRSB(quaternion a)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x9984F10", Offset = "0x9983910", VA = "0x189984F10")]
		public static quaternion IYPZUAEPOID(float3 a, float3 b)
		{
			return default(quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x9984C30", Offset = "0x9983630", VA = "0x189984C30")]
		public static float HNZMMLQUAFP(float3 a, float3 b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x9985140", Offset = "0x9983B40", VA = "0x189985140")]
		public static float UKPWSORJFRR(float3 a, float3 b, float3 c)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x9983C50", Offset = "0x9982650", VA = "0x189983C50")]
		public static float3 AAVKPRLWSRM(float3 a, float3 b, float3 c)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x9984060", Offset = "0x9982A60", VA = "0x189984060")]
		public static quaternion ESRORWRJJHY(quaternion a, float3 b)
		{
			return default(quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x9984DD0", Offset = "0x99837D0", VA = "0x189984DD0")]
		public static bool HPOFHGWNCJO(float3 a, float3 b, [Out] float3 c, bool d)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x99846A0", Offset = "0x99830A0", VA = "0x1899846A0")]
		public static float3 GAETRHGJRAJ(bool a, [Optional] quaternion b)
		{
			return default(float3);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	internal static class RLYITWKNVRX
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x997A330", Offset = "0x9978D30", VA = "0x18997A330")]
		public static JZLQQLGVCEB EUMUFLQYOSG(CurveShapeData a, ShapeType b, int c, float d, float3 e, float f, float g)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x997B260", Offset = "0x9979C60", VA = "0x18997B260")]
		private static void IRHGZQACXJU(float3[] a, float3[] b, float2[] c, int d, float3 e, float3 f, float3 g, float h, bool i, float j)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x997B9C0", Offset = "0x997A3C0", VA = "0x18997B9C0")]
		private static void OHTRRUMOKNN(ExportCurvePointData a, ExportRingSegment b, float3[] c, float3[] d, float2[] e, int f, float g, float h, float i, float3 j, float k)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x997B370", Offset = "0x9979D70", VA = "0x18997B370")]
		private static void OAOOHYHZUIZ(ExportRingSegment a, float3[] b, float3[] c, float2[] d, int[] e, int f, int g, float3 h, float3x3 i, bool j, float k, int l, bool m, float n, float o, float3 p, float q)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	internal struct ExportCurvePointData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000162")]
		public float3 Position;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000163")]
		public float3x3 Rotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000164")]
		public float Radius;
	}
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	internal static class ZAUIMEBNHFO
	{
		[Cpp2IlInjected.Token(Token = "0x2000033")]
		private struct PointSrcData
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000165")]
			public float3 Position;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
			[Cpp2IlInjected.Token(Token = "0x4000166")]
			public quaternion Rotation;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
			[Cpp2IlInjected.Token(Token = "0x4000167")]
			public float Radius;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000168")]
			public quaternion BlendedRotation;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000169")]
			public float BendAngle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
			[Cpp2IlInjected.Token(Token = "0x400016A")]
			public float BendRadius;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400016B")]
			public float DistanceToNext;
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x9985D80", Offset = "0x9984780", VA = "0x189985D80")]
		public static List<ExportCurvePointData> Generate(IReadOnlyList<float3> positions, IReadOnlyList<float3> normals, IReadOnlyList<float> radii, int configFlags, float heightScale)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x9985A90", Offset = "0x9984490", VA = "0x189985A90")]
		private static float3[] BEFXTVFLVYX(IReadOnlyList<float3> a, bool b, bool c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x99869C0", Offset = "0x99853C0", VA = "0x1899869C0")]
		private static List<ExportCurvePointData> NJGRNLDOHGT(List<PointSrcData> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x9987A10", Offset = "0x9986410", VA = "0x189987A10")]
		private static bool QDLKOIURNSC(int a, List<ExportCurvePointData> b, List<PointSrcData> c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x9986430", Offset = "0x9984E30", VA = "0x189986430")]
		private static ExportCurvePointData MZYGUFTPDAS(int a, List<PointSrcData> b)
		{
			return default(ExportCurvePointData);
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x9986D00", Offset = "0x9985700", VA = "0x189986D00")]
		private static List<ExportCurvePointData> NTYUODIBUXH(List<PointSrcData> a, float b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x99886B0", Offset = "0x99870B0", VA = "0x1899886B0")]
		private static ExportCurvePointData VWZQNKMIPHA(PointSrcData a)
		{
			return default(ExportCurvePointData);
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x99863A0", Offset = "0x9984DA0", VA = "0x1899863A0")]
		private static ExportCurvePointData HCHWTBEMRXB(float3 a, quaternion b, float c)
		{
			return default(ExportCurvePointData);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	internal struct ExportRingVertex
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016C")]
		public float2 Offset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400016D")]
		public float2 Normal;
	}
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	internal struct ExportRingSegment
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016E")]
		public ExportRingVertex[] RingVerts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400016F")]
		public int[] RingIndices;
	}
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	internal static class UTNYMNWKPOO
	{
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x9981E80", Offset = "0x9980880", VA = "0x189981E80")]
		public static ExportRingSegment ESNRPCFLHHD(int a)
		{
			return default(ExportRingSegment);
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x99822E0", Offset = "0x9980CE0", VA = "0x1899822E0")]
		public static ExportRingSegment TAFCQZVOQIK(int a)
		{
			return default(ExportRingSegment);
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x9981E50", Offset = "0x9980850", VA = "0x189981E50")]
		public static ExportRingSegment BDMGEDQWWQL()
		{
			return default(ExportRingSegment);
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x9982230", Offset = "0x9980C30", VA = "0x189982230")]
		public static int GDKUMAEBULX(int a, int b, bool c, bool d, bool e)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x9982290", Offset = "0x9980C90", VA = "0x189982290")]
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
