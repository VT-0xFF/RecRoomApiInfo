using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using JetBrains.Annotations;
using RecRoom.Configs;
using RecRoom.Core.Creation.Shapes;
using RecRoom.Core.DataStructures;
using RecRoom.DataLayer.Attributes;
using RecRoom.DataLayer.Registration;
using RecRoom.Initialization;
using RecRoom.MCluster;
using RecRoom.NoEngine.DataStructures;
using RecRoom.NoEngine.DataStructures.Caching;
using RecRoom.RendererV1;
using RecRoom.RendererV1.Terrain;
using UJect;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.SceneManagement;
using UnityEngine.Scripting;

[assembly: AssemblyVersion("0.0.0.0")]
namespace _AssemblyRegistry.RecRoom_ShapeConfig_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[RecRoom.DataLayer.Attributes.Preserve]
	[Obfuscation(ApplyToMembers = false)]
	public class _AssemblyIndex : AssemblyIndex
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x95446D0", Offset = "0x95432D0", VA = "0x1895446D0", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x2C401F0", Offset = "0x2C3EDF0", VA = "0x182C401F0")]
		public _AssemblyIndex()
		{
		}
	}
}
namespace RecRoom
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public static class IIWBFEQZUCW
	{
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public static readonly int TZFHRJWYABH;

		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public static readonly int JHEKDBFMSOE;

		[Cpp2IlInjected.Token(Token = "0x4000003")]
		public static readonly int TYDEICUQYWA;

		[Cpp2IlInjected.Token(Token = "0x4000004")]
		public static readonly int SYGIRQDYZGC;

		[Cpp2IlInjected.Token(Token = "0x4000005")]
		public static readonly int VYUGOZCZDOE;

		[Cpp2IlInjected.Token(Token = "0x4000006")]
		public static readonly int GUCUIFRIIDS;

		[Cpp2IlInjected.Token(Token = "0x4000007")]
		public static readonly int TGRXLQLSOHK;

		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public static readonly int YTQLCCVRIHE;

		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public static readonly int AMEUAHVGIYP;

		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public static readonly int KCZKZKRZLFQ;

		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public static readonly int YZJJNPAKMDU;

		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public static readonly int PUNTJOLKUNU;

		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public static readonly int SDXFGPZYYNW;

		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public static readonly int BKAPDJRPHMM;

		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public static readonly int CILFZYFZQGK;

		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public static readonly int XPMXNMIUMZL;

		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public static readonly int EDRLPNWYLSP;

		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public static readonly int ZVNZPNICBTL;

		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public static readonly int MOVKCVHPCAF;

		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public static readonly int DKZFYEFAVMH;

		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public static readonly int PTHLHVXAFNO;

		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public static readonly int KJUUMJASCQB;

		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public static readonly int GZONZOCZIJH;

		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public static readonly int VQPNFQQGQXE;

		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public static readonly int XAZERZGGTTR;

		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public static readonly int SQONHCYZEMA;

		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public static readonly int WRHTSDOBEXS;

		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public static readonly int ZDLXQHZHREB;
	}
}
namespace RecRoom.Core.Creation
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public class TRLDHJPZBXC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public readonly int SHGPIZQORCL;

		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private static TRLDHJPZBXC NSKMMBUTGCK;

		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private static TRLDHJPZBXC BQLILXPODEL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private readonly int ZGHHIIMGPXP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private readonly int ZKDIIHAINFE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private readonly int ZJNNQMSQKXD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private readonly float YZNFUWKNFKW;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public static TRLDHJPZBXC AMQAYNZCUGT
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x9543DD0", Offset = "0x95429D0", VA = "0x189543DD0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public static TRLDHJPZBXC ZFWWJMUUDFA
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x9543F60", Offset = "0x9542B60", VA = "0x189543F60")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x9544080", Offset = "0x9542C80", VA = "0x189544080")]
		public TRLDHJPZBXC(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x9543E80", Offset = "0x9542A80", VA = "0x189543E80")]
		public int HFROMXKDMDM(Color a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x9544010", Offset = "0x9542C10", VA = "0x189544010")]
		public Color RHNRLVZYPVE(int a)
		{
			return default(Color);
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public class ColorRemap
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public bool hdr;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public Vector2 hue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public Vector2 saturation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		public Vector2 value;

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x9538A90", Offset = "0x9537690", VA = "0x189538A90")]
		public float XXSKQLWQTVI(float a, Vector2 b, bool c)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x9538AE0", Offset = "0x95376E0", VA = "0x189538AE0")]
		public Color XXSKQLWQTVI(float a, float b, float c)
		{
			return default(Color);
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x9538BD0", Offset = "0x95377D0", VA = "0x189538BD0")]
		public ColorRemap()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public static class GFLFDCEGTKI
	{
		[Cpp2IlInjected.Token(Token = "0x2000007")]
		public enum ColorChannel
		{
			[Cpp2IlInjected.Token(Token = "0x4000029")]
			Albedo,
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			Specular,
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			Emissive
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		[CompilerGenerated]
		private struct <>c__DisplayClass2_0
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400002C")]
			public Texture2D texture;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400002D")]
			public Func<ShapeColorInfo, ColorChannel, Color, Color> colorAdjust;
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x95392F0", Offset = "0x9537EF0", VA = "0x1895392F0")]
		public static Texture2D GXASLWZHDMN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x9538C00", Offset = "0x9537800", VA = "0x189538C00")]
		public static Texture2D BCYASHKFZHV(Func<ShapeColorInfo, ColorChannel, Color, Color> a, string b = "LegacyColorTexture")
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x9539140", Offset = "0x9537D40", VA = "0x189539140")]
		[CompilerGenerated]
		internal static void BRNSYLHGZGK(ShapeColorInfo a, int b, <>c__DisplayClass2_0 c)
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public class ShapeColorInfo
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		public string name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		[Tooltip("Be careful when changing this: for existing colors, it could cause backwards compatibility issues.")]
		public ShapeColor ColorID;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		[ColorUsage(false, false)]
		public Color baseColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		[Tooltip("Color used when this object is using an emissive material")]
		[ColorUsage(false, true)]
		public Color emissiveColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		[Tooltip("Color used when this object is using a specular-only material (typically metals \\m/)")]
		[ColorUsage(false, false)]
		public Color specularColor;

		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private static FQOVWNKPYEU RDXGSMCSVOW;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		private static FQOVWNKPYEU WWWCMOJBPRV
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x9543340", Offset = "0x9541F40", VA = "0x189543340")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public Color Additive
		{
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x9543A10", Offset = "0x9542610", VA = "0x189543A10")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x9543650", Offset = "0x9542250", VA = "0x189543650")]
		public static ShapeColor IXHOTKHNXXA(Color a, TRLDHJPZBXC b)
		{
			return default(ShapeColor);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x9543720", Offset = "0x9542320", VA = "0x189543720")]
		public static ShapeColor IXHOTKHNXXA(Color a)
		{
			return default(ShapeColor);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x9543410", Offset = "0x9542010", VA = "0x189543410")]
		public static ShapeColorInfo HCNVSYKHDBQ(ShapeColor a, TRLDHJPZBXC b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x9543810", Offset = "0x9542410", VA = "0x189543810")]
		public static ShapeColorInfo TUNGSCYGPBY(ShapeColor a, TRLDHJPZBXC b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x9543030", Offset = "0x9541C30", VA = "0x189543030")]
		public static bool AHQMWAJEBMQ(Color a, [Out] ShapeColorInfo b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
		public ShapeColorInfo()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[Flags]
	public enum MaterialColorUsage
	{
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		ALBEDO = 1,
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		EMISSIVE = 2,
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		SPECULAR = 4,
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		HOLOGRAPHIC = 8
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public enum UVOffsetStart
	{
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		WorldProjected,
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		WorldProjected_Tiled,
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		Random,
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		Zero
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public class ShapeMaterialInfo
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public string DisplayName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public MaterialColorUsage ColorUsage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		public ShapeColor DefaultColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public float UI_TextureSize;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public UVOffsetStart uvOffsetStart;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public float DefaultTextureSize;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public float OldTextureSize;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		[Tooltip("Be careful when changing this: for existing materials, it could cause backwards compatibility issues.")]
		public ShapeMaterial MaterialId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public Material ShapeMaterial;

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x9543DA0", Offset = "0x95429A0", VA = "0x189543DA0")]
		public ShapeMaterialInfo()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x9543D10", Offset = "0x9542910", VA = "0x189543D10")]
		public ShapeMaterialInfo(ShapeMaterialInfo other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x9543CB0", Offset = "0x95428B0", VA = "0x189543CB0")]
		public void CopyTo(ShapeMaterialInfo shapeMaterialInfo)
		{
		}
	}
}
namespace RecRoom.Core.Creation.Shapes
{
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class QCSKCGJLTZP : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private static readonly int NXJMABKPHYP;

		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private static readonly int SVQZDRPLZSY;

		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private static readonly int PYBQPOEYCJH;

		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private static readonly int SBWVYOZYIRZ;

		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private static readonly int XXKXPEASKIT;

		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private static readonly int UUQQGLIPJQA;

		[Cpp2IlInjected.Token(Token = "0x400004D")]
		private static readonly int QMJERPZMWFF;

		[Cpp2IlInjected.Token(Token = "0x400004E")]
		private static readonly int NCLFYPZNHVZ;

		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private static readonly int GWYNXGIAFAF;

		[Cpp2IlInjected.Token(Token = "0x4000050")]
		private static readonly int HJIZRZCWMMT;

		[Cpp2IlInjected.Token(Token = "0x4000051")]
		private static readonly int POTVMZCQVNR;

		[Cpp2IlInjected.Token(Token = "0x4000052")]
		private static readonly int DLISAXVJTVB;

		[Cpp2IlInjected.Token(Token = "0x4000053")]
		private static readonly int FKEYJEUQMAR;

		[Cpp2IlInjected.Token(Token = "0x4000054")]
		private static readonly int OWBPQYJXLDR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public ShapeMaterialInfo[] OUJJBEWPYTH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public Texture2DArray HSMUCLLRGXR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public Texture2DArray OXMZQKFGCBN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public float[] LJZJNLASWDO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public Texture2DArray KBIYUHVIGAJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		public float[] LJEZWQYHJXQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public float[] HJRKCBSYPMJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		public float[] SGKFJQUGGMN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public Vector4[] ESKCTJMHXNB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public Texture2DArray HQKYUJYJAAB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public float[] XJWNBKFZQZI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public float[] RLWTZKOBNLL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public float[] HFNXVVIYYXP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public Vector4[] ZZPXGGTOYDR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		private int[] DQTWMRJYKJA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public Texture2DArray UEEXRMCIDOV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public float[] HKJSVOHKRLE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public Vector4[] XELPODUFQNH;

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x95406A0", Offset = "0x953F2A0", VA = "0x1895406A0")]
		[Conditional("UNITY_EDITOR")]
		[Conditional("DEBUG_BUILD")]
		private void DBKOKVIPJCS(string a, Texture2D b, Texture2D c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x9540BA0", Offset = "0x953F7A0", VA = "0x189540BA0")]
		private Texture2DArray HIHJUCHGPMU(string a, IReadOnlyList<Texture2D> b, bool c, ShapeMaterialInfo[] d)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x9541210", Offset = "0x953FE10", VA = "0x189541210")]
		public QCSKCGJLTZP(ShapeMaterialInfo[] a, bool b, bool c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x9540ED0", Offset = "0x953FAD0", VA = "0x189540ED0")]
		private Vector3 WWEQOQESPQO(ShapeMaterialInfo a)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x9540E80", Offset = "0x953FA80", VA = "0x189540E80")]
		public int RFFVYNZGRXO(ShapeMaterial a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x9540B50", Offset = "0x953F750", VA = "0x189540B50", Slot = "4")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public interface JVQJNTWUAMN
	{
		[Cpp2IlInjected.Token(Token = "0x17000005")]
		bool IZZJKLYSWJO
		{
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		bool KMUUNFGBKUZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		bool DWMFJUSNVNE
		{
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public interface JMOCXQHECRW : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x17000008")]
		Texture2D CRACSGJIAXI
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(Slot = "1")]
		Material DOKFKHJIRCY();

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(Slot = "2")]
		int KDVWDSRLLWA(ShapeColor a);

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(Slot = "3")]
		int RFFVYNZGRXO(ShapeMaterial a);

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void NOWIFQIXTAE(Material a);

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(Slot = "5")]
		KMDPSWFHMIA[] BUVECKWNWDO();
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public interface FQOVWNKPYEU
	{
		[Cpp2IlInjected.Token(Token = "0x17000009")]
		ColorRemap BJOVPARCLPD
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		ColorRemap MWCTCHXQKBR
		{
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		ShapeColorInfo IXZZAFPJJQH(ShapeColor a, bool b = true);

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		bool TEGCUDEQCDP(ShapeColor a, [Out] Color b);
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public static class SBKNILLJEDF
	{
		[Cpp2IlInjected.Token(Token = "0x2000012")]
		private class LENNGJLMWUA : JMOCXQHECRW, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400007F")]
			public QCSKCGJLTZP MIKLFCRNJHN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000080")]
			private readonly Texture2D DSAYQSXNYIT;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000081")]
			private bool NVONJURXFTO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
			[Cpp2IlInjected.Token(Token = "0x4000082")]
			private bool AVCEVOAMRAB;

			[Cpp2IlInjected.Token(Token = "0x4000083")]
			private static KMDPSWFHMIA[] MFXSCHXIDCH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000084")]
			private Texture2D SHBPGNCPLSW;

			[Cpp2IlInjected.Token(Token = "0x1700000B")]
			public Texture2D CRACSGJIAXI
			{
				[Cpp2IlInjected.Token(Token = "0x6000035")]
				[Cpp2IlInjected.Address(RVA = "0x953E890", Offset = "0x953D490", VA = "0x18953E890", Slot = "4")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x953FAC0", Offset = "0x953E6C0", VA = "0x18953FAC0")]
			public LENNGJLMWUA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x953DF40", Offset = "0x953CB40", VA = "0x18953DF40")]
			private Color CGYHFEVQTVS(ShapeColorInfo a, GFLFDCEGTKI.ColorChannel b, Color c)
			{
				return default(Color);
			}

			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x953E160", Offset = "0x953CD60", VA = "0x18953E160", Slot = "10")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x953E060", Offset = "0x953CC60", VA = "0x18953E060", Slot = "5")]
			public Material DOKFKHJIRCY()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x953EB50", Offset = "0x953D750", VA = "0x18953EB50")]
			private void THWZNJNDRMG(Texture2D a, bool b, bool c)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x953DF00", Offset = "0x953CB00", VA = "0x18953DF00", Slot = "9")]
			public KMDPSWFHMIA[] BUVECKWNWDO()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x953E300", Offset = "0x953CF00", VA = "0x18953E300", Slot = "8")]
			public void NOWIFQIXTAE(Material a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x953E1E0", Offset = "0x953CDE0", VA = "0x18953E1E0", Slot = "6")]
			public int KDVWDSRLLWA(ShapeColor a)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x953EB00", Offset = "0x953D700", VA = "0x18953EB00", Slot = "7")]
			public int RFFVYNZGRXO(ShapeMaterial a)
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000013")]
		private struct MaterialHash : IEquatable<MaterialHash>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000085")]
			public bool TransparentQueue;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
			[Cpp2IlInjected.Token(Token = "0x4000086")]
			public bool CameraLit;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x4000087")]
			public Color Color;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x4000088")]
			public Color EmissionColor;

			[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
			[Cpp2IlInjected.Token(Token = "0x4000089")]
			public Color SpecularColor;

			[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
			[Cpp2IlInjected.Token(Token = "0x400008A")]
			public ShapeMaterial MaterialId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400008B")]
			public float TextureSize;

			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x95402F0", Offset = "0x953EEF0", VA = "0x1895402F0", Slot = "4")]
			public bool Equals(MaterialHash other)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x95404E0", Offset = "0x953F0E0", VA = "0x1895404E0", Slot = "0")]
			public override bool Equals(object obj)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x95405A0", Offset = "0x953F1A0", VA = "0x1895405A0", Slot = "2")]
			public override int GetHashCode()
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000067")]
		private static Dictionary<MaterialHash, Material> NXPDEANFAGN;

		[Cpp2IlInjected.Token(Token = "0x4000068")]
		private static readonly int LWTEWEOURDQ;

		[Cpp2IlInjected.Token(Token = "0x4000069")]
		private static readonly int BRRWCWPOVIE;

		[Cpp2IlInjected.Token(Token = "0x400006A")]
		private static readonly int HUKAGNUEVGM;

		[Cpp2IlInjected.Token(Token = "0x400006B")]
		private static readonly int WMMQRKZKLIX;

		[Cpp2IlInjected.Token(Token = "0x400006C")]
		private static readonly int AXCNINDQNTL;

		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private static readonly int WULXRHUJPQE;

		[Cpp2IlInjected.Token(Token = "0x400006E")]
		private static readonly int MDQNCXNAIRL;

		[Cpp2IlInjected.Token(Token = "0x400006F")]
		private static readonly int GWDMZONWDDI;

		[Cpp2IlInjected.Token(Token = "0x4000070")]
		private static readonly int EEJUXVMQWER;

		[Cpp2IlInjected.Token(Token = "0x4000071")]
		private static readonly int RYIMSTYVOYA;

		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private static readonly int UIJDNJPJHHC;

		[Cpp2IlInjected.Token(Token = "0x4000073")]
		private static readonly int TLKXYGEWFQE;

		[Cpp2IlInjected.Token(Token = "0x4000074")]
		private static readonly int GYKDELNODPC;

		[Cpp2IlInjected.Token(Token = "0x4000075")]
		private static readonly int OEABWOVSKJM;

		[Cpp2IlInjected.Token(Token = "0x4000076")]
		private static readonly int KMOXTBFZTYU;

		[Cpp2IlInjected.Token(Token = "0x4000077")]
		private static readonly int OBSTSBWRHEI;

		[Cpp2IlInjected.Token(Token = "0x4000078")]
		private static readonly int URWVQPMTIOM;

		[Cpp2IlInjected.Token(Token = "0x4000079")]
		private static readonly int DBWJHDCSIMU;

		[Cpp2IlInjected.Token(Token = "0x400007A")]
		private static readonly int MXKPJEXOMNU;

		[Cpp2IlInjected.Token(Token = "0x400007B")]
		private static readonly int ZNMIZXVIGFW;

		[Cpp2IlInjected.Token(Token = "0x400007C")]
		private static readonly int SMQOYWWTCVZ;

		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public static readonly int XXKXPEASKIT;

		[Cpp2IlInjected.Token(Token = "0x400007E")]
		public static readonly int IYWLEPPEBUA;

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x9542250", Offset = "0x9540E50", VA = "0x189542250")]
		[RRPostPlayModeMethod(PostPlayModePhase.ExitingPlayMode, 0)]
		private static void MQSDZVFKBNL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x9542950", Offset = "0x9541550", VA = "0x189542950")]
		private static JVQJNTWUAMN ZHGODFKRPII()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x95429C0", Offset = "0x95415C0", VA = "0x1895429C0")]
		public static JMOCXQHECRW ZQHENWKCGDU()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x95422C0", Offset = "0x9540EC0", VA = "0x1895422C0")]
		public static void XNZHWCMUDAC(this Material a, ShapeColor b, ShapeMaterial c, bool d, bool e, float f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x9542390", Offset = "0x9540F90", VA = "0x189542390")]
		public static void XNZHWCMUDAC(this Material a, ShapeColorInfo b, ShapeMaterialInfo c, bool d, bool e, float f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x9541F80", Offset = "0x9540B80", VA = "0x189541F80")]
		public static Material DANLOWGFVYE(ShapeColorInfo a, ShapeMaterialInfo b, bool c, bool d)
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public class ShapeConfig : SingletonScriptableObject<ShapeConfig>
	{
		[Cpp2IlInjected.Token(Token = "0x2000015")]
		public enum CenterOfMass
		{
			[Cpp2IlInjected.Token(Token = "0x40000AD")]
			UniformCenter,
			[Cpp2IlInjected.Token(Token = "0x40000AE")]
			PyramidCenter,
			[Cpp2IlInjected.Token(Token = "0x40000AF")]
			WedgeCenter,
			[Cpp2IlInjected.Token(Token = "0x40000B0")]
			NumTypes
		}

		[Cpp2IlInjected.Token(Token = "0x2000016")]
		public enum VolumeCalculation
		{
			[Cpp2IlInjected.Token(Token = "0x40000B2")]
			All,
			[Cpp2IlInjected.Token(Token = "0x40000B3")]
			Half,
			[Cpp2IlInjected.Token(Token = "0x40000B4")]
			Cylinder,
			[Cpp2IlInjected.Token(Token = "0x40000B5")]
			Pyramid,
			[Cpp2IlInjected.Token(Token = "0x40000B6")]
			Sphere,
			[Cpp2IlInjected.Token(Token = "0x40000B7")]
			HalfSphere
		}

		[Cpp2IlInjected.Token(Token = "0x2000017")]
		public enum ColliderCost
		{
			[Cpp2IlInjected.Token(Token = "0x40000B9")]
			Sphere,
			[Cpp2IlInjected.Token(Token = "0x40000BA")]
			Box,
			[Cpp2IlInjected.Token(Token = "0x40000BB")]
			Mesh
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000018")]
		public struct ShapeConfigData
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000BC")]
			public string name;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40000BD")]
			[Tooltip("If false, will be hidden in Palette")]
			public bool displayInPalette;

			[Cpp2IlInjected.FieldOffset(Offset = "0x9")]
			[Cpp2IlInjected.Token(Token = "0x40000BE")]
			[Tooltip("If true, will be separated from default in-style shapes in Palette")]
			public bool displayAsAdvanced;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000BF")]
			public GameObject prefab;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000C0")]
			public GameObject prefabUIPreview;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000C1")]
			[Tooltip("Only for primitive shapes")]
			public Mesh collider;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000C2")]
			public CenterOfMass centerOfMass;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x40000C3")]
			public VolumeCalculation volumeCalculation;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000C4")]
			public ColliderCost colliderCost;

			[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
			[Cpp2IlInjected.Token(Token = "0x40000C5")]
			[Tooltip("Standard is (1,1,1)")]
			public Vector3 boundsSize;
		}

		[Cpp2IlInjected.Token(Token = "0x2000019")]
		public class RVJPYGGJFIJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000C6")]
			public Vector2Int OBEKLVUANDC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000C7")]
			public float[] HADHXILUUYM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000C8")]
			public float CARLMGYJSCE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
			[Cpp2IlInjected.Token(Token = "0x40000C9")]
			public float MFLPYQRQSFE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000CA")]
			public TerrainMaterialLayer[] EVFBMVFVTFM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000CB")]
			public Vector2 VLSSRPINPTP;

			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x9541F50", Offset = "0x9540B50", VA = "0x189541F50")]
			public RVJPYGGJFIJ()
			{
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200001A")]
		public class ShapeColorToColorDictionary : SerializedDictionary<ShapeColor, Color, ShapeColorToColorDictionary.KeyVal>
		{
			[Serializable]
			[Cpp2IlInjected.Token(Token = "0x200001B")]
			public class KeyVal : SerializedKeyVal<ShapeColor, Color>
			{
				[Cpp2IlInjected.Token(Token = "0x6000046")]
				[Cpp2IlInjected.Address(RVA = "0x953DEC0", Offset = "0x953CAC0", VA = "0x18953DEC0")]
				public KeyVal()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x9543B10", Offset = "0x9542710", VA = "0x189543B10")]
			public ShapeColorToColorDictionary()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		[Header("Curve Shape Prefabs")]
		public GameObject TubeShapePrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public ShapeConfigData[] ShapeDatas;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		[Header("Editing")]
		public float[] CurveThicknessModifiers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		public float[] TubeHeightScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		public int[] TubeRingPoints;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		[Header("Bevels")]
		public float SmallBevelSizeMeters;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		public float RoundedBevelSizeMeters;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		public float BoxAuthoredBevelPercent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		public float WedgeAuthoredBevelPercent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		public float PyramidAuthoredBevelPercent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		[Tooltip("Smaller dimensions will not exceed sqrt(bevel percent) percent")]
		public bool BevelSizeBasedOnLargestPossibleDimension;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		[Header("Resource costs")]
		public int ShapeContainerCostEnvironment;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		public int ShapeContainerCostDecoration;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		public int ShapeContainerCostPhysical;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		public int SphereColliderCost;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		public int BoxColliderCost;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		public int MeshColliderCost;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		public float PhysicalPhysicsModeMultiplier;

		[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		public float EnvironmentPhysicsModeMultiplier;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		public float DecorationPhysicsModeMultiplier;

		[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		public float OptimizedCollidersMultiplier;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		[Header("Colors & Materials")]
		public Material UIPreviewMaterial;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		public Material ConvexHullVisualizationMaterial;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public Shader BatchedMakerPenShader;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		[Tooltip("Supports up to 16 currently")]
		public ShapeColor[] CharadesColors;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		public ShapeColorInfo[] ShapeColorInfos;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		public ShapeMaterialInfo[] ShapeMaterialInfos;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		public AssetReference TerrainHeightmapGenerationPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		public AssetReference TerrainSpawnAnimationPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		[HideInInspector]
		public ShapeColorToColorDictionary RROShapeColorAdditive;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		[Header("Generated Color Tuners")]
		public ColorRemap SpecularRemap;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		public ColorRemap EmissiveRemap;

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		protected override bool EXUVZSMYTYO
		{
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0xB5DE90", Offset = "0xB5CA90", VA = "0x180B5DE90", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x9543B50", Offset = "0x9542750", VA = "0x189543B50")]
		public ShapeConfig()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public static class MVGMGFJXBJJ
	{
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		public static readonly ShapeType[] HQRUJDTPRGU;

		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		public static readonly int[] YSCWZAPFAGZ;

		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		public static readonly PrimitiveShapeMeshType[] RLCZCQMGOXT;

		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		private static readonly Dictionary<ShapeType, int> CXICUNSHSZF;

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x953FC90", Offset = "0x953E890", VA = "0x18953FC90")]
		private static Dictionary<ShapeType, int> BMIWKEKPKXU()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x953FF50", Offset = "0x953EB50", VA = "0x18953FF50")]
		public static PrimitiveShapeMeshType ULBXDTINVVS(this ShapeType a)
		{
			return default(PrimitiveShapeMeshType);
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x953FEE0", Offset = "0x953EAE0", VA = "0x18953FEE0")]
		public static int KDVDOSIVHDF(this ShapeType a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x953FE40", Offset = "0x953EA40", VA = "0x18953FE40")]
		public static int FWWDIPVEPTA(this ShapeType a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x1755D10", Offset = "0x1754910", VA = "0x181755D10")]
		public static bool NTXPJKPKHCZ(this ShapeType a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x8CB45B0", Offset = "0x8CB31B0", VA = "0x188CB45B0")]
		public static bool SUFTCQRQLQR(this ShapeType a)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public class VVMKRUXYPJD : FQOVWNKPYEU
	{
		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public ColorRemap BJOVPARCLPD
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x9544620", Offset = "0x9543220", VA = "0x189544620", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public ColorRemap MWCTCHXQKBR
		{
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x95443A0", Offset = "0x9542FA0", VA = "0x1895443A0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
		[UnityEngine.Scripting.Preserve]
		internal VVMKRUXYPJD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x9544450", Offset = "0x9543050", VA = "0x189544450")]
		[IFIZWETSKCB.Root]
		internal static void KQEBINAABYI(DiContainer a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x9544340", Offset = "0x9542F40", VA = "0x189544340", Slot = "4")]
		public ShapeColorInfo IXZZAFPJJQH(ShapeColor a, bool b = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x9544540", Offset = "0x9543140", VA = "0x189544540", Slot = "5")]
		public bool TEGCUDEQCDP(ShapeColor a, [Out] Color b)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public static class KIGMSYHZZDZ
	{
		[Cpp2IlInjected.Token(Token = "0x2000020")]
		public enum DensityOption
		{
			[Cpp2IlInjected.Token(Token = "0x40000E1")]
			Air,
			[Cpp2IlInjected.Token(Token = "0x40000E2")]
			Aerogel,
			[Cpp2IlInjected.Token(Token = "0x40000E3")]
			Lithium,
			[Cpp2IlInjected.Token(Token = "0x40000E4")]
			Water,
			[Cpp2IlInjected.Token(Token = "0x40000E5")]
			Lead
		}

		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		public static AQWXMNIFQIV OHCVXHZIHKQ;

		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		private static Material WILJOXINLYZ;

		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		private static Material QYOWUTASBKJ;

		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		private static bool BUNPULLGBMB;

		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		private static JMOCXQHECRW UHNKVYQRWZG;

		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		private static readonly CollisionMeshData[] SYBDHXKWLBB;

		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		private static CollisionMeshData DCDKEKOHQBT;

		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		private static int[] VXNVRFPFTLO;

		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		private static int[] PXHZIBZDIHK;

		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		private static readonly UBZYVBBYOSS<ShapeColor, ShapeColorInfo> RSSCCXBAEBC;

		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		public static readonly Dictionary<string, EnumChoiceData> DAUXOBWXFWI;

		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		public static readonly Dictionary<int, string> DBKSFWEPIEJ;

		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		private static readonly Vector3[] UARIMZPJWWF;

		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		public static readonly Dictionary<string, EnumChoiceData> HEUCUREYMSL;

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public static ShapeConfig TSDZZPCEZUV
		{
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x953B110", Offset = "0x9539D10", VA = "0x18953B110")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		private static JMOCXQHECRW PWGVHFAXGCR
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x953C720", Offset = "0x953B320", VA = "0x18953C720")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public static Texture2D CRACSGJIAXI
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x953BCE0", Offset = "0x953A8E0", VA = "0x18953BCE0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public static ColorRemap BJOVPARCLPD
		{
			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x953CAA0", Offset = "0x953B6A0", VA = "0x18953CAA0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public static ColorRemap MWCTCHXQKBR
		{
			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x953B6C0", Offset = "0x953A2C0", VA = "0x18953B6C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public static ShapeColorInfo[] CUAFZXJOXPU
		{
			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x95399D0", Offset = "0x95385D0", VA = "0x1895399D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public static ShapeMaterialInfo[] PXKNPTZCOZS
		{
			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x953B090", Offset = "0x9539C90", VA = "0x18953B090")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public static int JYMGXFTMKJY
		{
			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0x21D4AD0", Offset = "0x21D36D0", VA = "0x1821D4AD0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		private static int[] HUWRFFSZIMX
		{
			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0x953A160", Offset = "0x9538D60", VA = "0x18953A160")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		private static int[] QQBCRGQALKR
		{
			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0x953AE00", Offset = "0x9539A00", VA = "0x18953AE00")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public static Shader XWYLTSXFORK
		{
			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x953D4C0", Offset = "0x953C0C0", VA = "0x18953D4C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public static Material PGNZVIGLDRU
		{
			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0x953B5C0", Offset = "0x953A1C0", VA = "0x18953B5C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x953B7E0", Offset = "0x953A3E0", VA = "0x18953B7E0")]
		private static void LUMFMMCJTHG(Scene a, LoadSceneMode b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x953B740", Offset = "0x953A340", VA = "0x18953B740")]
		public static GameObject KOAMZWRQZSO(ShapeType a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x953C680", Offset = "0x953B280", VA = "0x18953C680")]
		public static GameObject TKPQXTJHIBA(ShapeType a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x953D300", Offset = "0x953BF00", VA = "0x18953D300")]
		private static Mesh XYOAYBBLKSF(ShapeType a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x953BF70", Offset = "0x953AB70", VA = "0x18953BF70")]
		public static bool QCQESHGAKTK(ShapeType a, [Out] Mesh b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x953CC40", Offset = "0x953B840", VA = "0x18953CC40")]
		private static void WQVKSDBNFNR()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x953C050", Offset = "0x953AC50", VA = "0x18953C050")]
		public static Material QLEKRKXJUTT()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x953B4F0", Offset = "0x953A0F0", VA = "0x18953B4F0")]
		public static Material JGDLXBGQLHF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x953BDC0", Offset = "0x953A9C0", VA = "0x18953BDC0")]
		public static Vector3 PYESJZRJBYB(Vector3 a, Quaternion b, ShapeMaterial c)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x953C280", Offset = "0x953AE80", VA = "0x18953C280")]
		private static Vector3 RWNANNWPPQJ(Vector3 a, Quaternion b, ShapeMaterial c, bool d)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x953BB30", Offset = "0x953A730", VA = "0x18953BB30")]
		public static void OCDEYFEGYVU(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x953B640", Offset = "0x953A240", VA = "0x18953B640")]
		public static int KDVWDSRLLWA(ShapeColor a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x953C120", Offset = "0x953AD20", VA = "0x18953C120")]
		public static int RFFVYNZGRXO(ShapeMaterial a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x953D540", Offset = "0x953C140", VA = "0x18953D540")]
		[RRPostPlayModeMethod(PostPlayModePhase.ExitingPlayMode, 0)]
		private static void ZCQTKWVSYAP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x953CF70", Offset = "0x953BB70", VA = "0x18953CF70")]
		public static CollisionMeshData XTHCMVWSYLL(ShapeType a)
		{
			return default(CollisionMeshData);
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x953C1A0", Offset = "0x953ADA0", VA = "0x18953C1A0")]
		public static CollisionMeshData RLQICNWURRZ()
		{
			return default(CollisionMeshData);
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x953C7C0", Offset = "0x953B3C0", VA = "0x18953C7C0")]
		public static string UVKJWSWORNN(ShapeType a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x953CB20", Offset = "0x953B720", VA = "0x18953CB20")]
		public static Bounds WMHYOCMPKIB(ShapeType a)
		{
			return default(Bounds);
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x9539A70", Offset = "0x9538670", VA = "0x189539A70")]
		public static int DECSKIIAMLA(ShapeType a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x953C5D0", Offset = "0x953B1D0", VA = "0x18953C5D0")]
		public static bool TEGCUDEQCDP(ShapeColor a, [Out] Color b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x953D4A0", Offset = "0x953C0A0", VA = "0x18953D4A0")]
		public static int YGFCNZTRRAE(int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x9539A50", Offset = "0x9538650", VA = "0x189539A50")]
		public static int AIITDFGCHAB(int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x953B140", Offset = "0x9539D40", VA = "0x18953B140")]
		public static Color IBPXWKSSUOV(ShapeColor a)
		{
			return default(Color);
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x953B1B0", Offset = "0x9539DB0", VA = "0x18953B1B0")]
		public static bool ICKCHZZTXGS(ShapeType a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x9539C20", Offset = "0x9538820", VA = "0x189539C20")]
		public static int DZCEOUWSWXU(ShapeType a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x953B1D0", Offset = "0x9539DD0", VA = "0x18953B1D0")]
		[NotNull]
		public static ShapeColorInfo IXZZAFPJJQH(ShapeColor a, bool b = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x953CED0", Offset = "0x953BAD0", VA = "0x18953CED0")]
		public static ShapeMaterialInfo XDZNLFUFVTH(ShapeMaterial a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x953D630", Offset = "0x953C230", VA = "0x18953D630")]
		public static float ZNAZYKTCGDS(int a)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x953B940", Offset = "0x953A540", VA = "0x18953B940")]
		public static int NTEWXKMNLJC(int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x953A730", Offset = "0x9539330", VA = "0x18953A730")]
		public static int EZRCKSZCQXG(int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x953B860", Offset = "0x953A460", VA = "0x18953B860")]
		public static Vector3 NJYUHGATFTO(ShapeType a)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x953A910", Offset = "0x9539510", VA = "0x18953A910")]
		public static float FFPRMKYRCIR(ShapeType a, Vector3 b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x953AB30", Offset = "0x9539730", VA = "0x18953AB30")]
		public static void GEIXNVUJILQ(bool a = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x953C860", Offset = "0x953B460", VA = "0x18953C860")]
		private static void VNYKTAWCUAZ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x9539CF0", Offset = "0x95388F0", VA = "0x189539CF0")]
		public static void EQHGDGETFJN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x953A3F0", Offset = "0x9538FF0", VA = "0x18953A3F0")]
		public static void EZQILUZYQUS()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public enum ShapeType
	{
		[Cpp2IlInjected.Token(Token = "0x40000EB")]
		Invalid = -1,
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		CURVE_Tube = 0,
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		CURVE_Ribbon = 1,
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		LegacyBox = 2,
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		RR_Sphere = 3,
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		RR_Cylinder = 4,
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		LEGACY_Wedge = 5,
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		LEGACY_Pyramid = 6,
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		LEGACY_TriggerVolumeBox = 7,
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		RR_Box = 8,
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		LEGACY_RoundedBox = 9,
		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		RR_Wedge = 10,
		[Cpp2IlInjected.Token(Token = "0x40000F7")]
		RR_Pyramid = 11,
		[Cpp2IlInjected.Token(Token = "0x40000F8")]
		RR_HalfSphere = 12,
		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		RR_Cone = 13,
		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		RR_Pipe = 14,
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		RR_Donut = 15,
		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		RR_HalfPipe = 16,
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		RR_Diamond = 17,
		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		ADVANCED_Mound = 18,
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		ADVANCED_Cube = 19,
		[Cpp2IlInjected.Token(Token = "0x4000100")]
		ADVANCED_Sphere = 20,
		[Cpp2IlInjected.Token(Token = "0x4000101")]
		ADVANCED_Cylinder = 21,
		[Cpp2IlInjected.Token(Token = "0x4000102")]
		ADVANCED_Cone = 22,
		[Cpp2IlInjected.Token(Token = "0x4000103")]
		ADVANCED_Pyramid = 23,
		[Cpp2IlInjected.Token(Token = "0x4000104")]
		ADVANCED_Octagon = 24,
		[Cpp2IlInjected.Token(Token = "0x4000105")]
		ADVANCED_Triangle = 25,
		[Cpp2IlInjected.Token(Token = "0x4000106")]
		ADVANCED_Hexagon = 26,
		[Cpp2IlInjected.Token(Token = "0x4000107")]
		ADVANCED_QuarterPipe = 27,
		[Cpp2IlInjected.Token(Token = "0x4000108")]
		ADVANCED_Pentagon = 28,
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		ADVANCED_Dodecahedron = 29,
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		ADVANCED_Trihedron = 30,
		[Cpp2IlInjected.Token(Token = "0x400010B")]
		ADVANCED_Octahedron = 31,
		[Cpp2IlInjected.Token(Token = "0x400010C")]
		RR_QuarterCylinder = 32,
		[Cpp2IlInjected.Token(Token = "0x400010D")]
		RR_Pentagon = 33,
		[Cpp2IlInjected.Token(Token = "0x400010E")]
		RR_QuarterSphere = 34,
		[Cpp2IlInjected.Token(Token = "0x400010F")]
		ADVANCED_Wedge = 35,
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		RR_Hexagon = 36,
		[Cpp2IlInjected.Token(Token = "0x4000111")]
		RR_Octagon = 37,
		[Cpp2IlInjected.Token(Token = "0x4000112")]
		RR_Triangle = 38,
		[Cpp2IlInjected.Token(Token = "0x4000113")]
		COUNT = 39,
		[Cpp2IlInjected.Token(Token = "0x4000114")]
		MIN_VALUE = -1,
		[Cpp2IlInjected.Token(Token = "0x4000115")]
		MAX_VALUE = 38
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
