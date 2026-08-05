using System;
using System.Collections.Generic;
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
		[Cpp2IlInjected.Address(RVA = "0xA510280", Offset = "0xA50F280", VA = "0x18A510280", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x2A0E020", Offset = "0x2A0D020", VA = "0x182A0E020")]
		public _AssemblyIndex()
		{
		}
	}
}
namespace RecRoom
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public static class LTNLTUOORKN
	{
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public static readonly int GTRSKLGVTNC;

		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public static readonly int PSUSJAQCVLP;

		[Cpp2IlInjected.Token(Token = "0x4000003")]
		public static readonly int GOLJDAVTWFP;

		[Cpp2IlInjected.Token(Token = "0x4000004")]
		public static readonly int XKSLLHHFZJR;

		[Cpp2IlInjected.Token(Token = "0x4000005")]
		public static readonly int BUTWMGAZWBP;

		[Cpp2IlInjected.Token(Token = "0x4000006")]
		public static readonly int GFDKZCUMKTX;

		[Cpp2IlInjected.Token(Token = "0x4000007")]
		public static readonly int TFLBUKYIJQV;

		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public static readonly int DREYJHCVVPT;

		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public static readonly int PFJSMBHCZKK;

		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public static readonly int MTTLIDXVTVV;

		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public static readonly int PIXFBKVXNMX;

		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public static readonly int XNOXHDGOHRN;

		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public static readonly int IHMRNJUMXPZ;

		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public static readonly int YICJLYLFFRR;

		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public static readonly int UXBYKALSMAR;

		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public static readonly int BWXVHWEOGPA;

		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public static readonly int DZBUGTYPKAG;

		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public static readonly int LNQJVHLJADA;

		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public static readonly int TBVBSBWHMMY;

		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public static readonly int YQHFVFWKZSO;

		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public static readonly int BHNHFDIUXCB;

		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public static readonly int MVQXBGRFELU;

		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public static readonly int DVEKCENDTKY;

		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public static readonly int RVZFDIBVBEV;

		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public static readonly int INOLBQEMBLW;

		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public static readonly int NUZRJXWMTBF;

		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public static readonly int BNBSVMNIDWH;

		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public static readonly int IVAHSGTCTYO;
	}
}
namespace RecRoom.Core.Creation
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public class OIXKGLKIMIJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public readonly int LGIRRMIXDHE;

		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private static OIXKGLKIMIJ HKDACAFVBGX;

		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private static OIXKGLKIMIJ ACNSAGEFQYE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private readonly int RMXVQFKFXPU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private readonly int RREKKRMCNUB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private readonly int RQEBYJQPSPI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private readonly float UJDQTRLRWGD;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public static OIXKGLKIMIJ TNQVRMIXIGI
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0xA5087A0", Offset = "0xA5077A0", VA = "0x18A5087A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public static OIXKGLKIMIJ DURVGTFAOQH
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0xA508850", Offset = "0xA507850", VA = "0x18A508850")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xA508900", Offset = "0xA507900", VA = "0x18A508900")]
		public OIXKGLKIMIJ(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0xA5086C0", Offset = "0xA5076C0", VA = "0x18A5086C0")]
		public int RVOVDFGWYZB(Color a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0xA508650", Offset = "0xA507650", VA = "0x18A508650")]
		public Color NIKZAKAMJML(int a)
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
		[Cpp2IlInjected.Address(RVA = "0xA5057A0", Offset = "0xA5047A0", VA = "0x18A5057A0")]
		public float WAWREKIWZDD(float a, Vector2 b, bool c)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xA5057F0", Offset = "0xA5047F0", VA = "0x18A5057F0")]
		public Color WAWREKIWZDD(float a, float b, float c)
		{
			return default(Color);
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0xA5058E0", Offset = "0xA5048E0", VA = "0x18A5058E0")]
		public ColorRemap()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public static class CRRDKCGNIAD
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
		[Cpp2IlInjected.Address(RVA = "0xA504EB0", Offset = "0xA503EB0", VA = "0x18A504EB0")]
		public static Texture2D DIRDIHYEKYA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0xA5050B0", Offset = "0xA5040B0", VA = "0x18A5050B0")]
		public static Texture2D KQUHWSLVQSC(Func<ShapeColorInfo, ColorChannel, Color, Color> a, string b = "LegacyColorTexture")
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0xA5055F0", Offset = "0xA5045F0", VA = "0x18A5055F0")]
		[CompilerGenerated]
		internal static void KZRQLUKWYVJ(ShapeColorInfo a, int b, <>c__DisplayClass2_0 c)
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
		private static YGQBSPHWAJP ODLUAQDRCUT;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		private static YGQBSPHWAJP GHYUGMLLHWY
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0xA50B6B0", Offset = "0xA50A6B0", VA = "0x18A50B6B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public Color Additive
		{
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0xA50B780", Offset = "0xA50A780", VA = "0x18A50B780")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0xA50B5E0", Offset = "0xA50A5E0", VA = "0x18A50B5E0")]
		public static ShapeColor ICGOXZRWEKP(Color a, OIXKGLKIMIJ b)
		{
			return default(ShapeColor);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0xA50B4F0", Offset = "0xA50A4F0", VA = "0x18A50B4F0")]
		public static ShapeColor ICGOXZRWEKP(Color a)
		{
			return default(ShapeColor);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0xA50B2B0", Offset = "0xA50A2B0", VA = "0x18A50B2B0")]
		public static ShapeColorInfo HTURENTMVZH(ShapeColor a, OIXKGLKIMIJ b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0xA50B0B0", Offset = "0xA50A0B0", VA = "0x18A50B0B0")]
		public static ShapeColorInfo DTPYWNIVKEZ(ShapeColor a, OIXKGLKIMIJ b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0xA50ADA0", Offset = "0xA509DA0", VA = "0x18A50ADA0")]
		public static bool DFEOFRKNGZN(Color a, [Out] ShapeColorInfo b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0xD11530", Offset = "0xD10530", VA = "0x180D11530")]
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
		[Cpp2IlInjected.Address(RVA = "0xA50BB10", Offset = "0xA50AB10", VA = "0x18A50BB10")]
		public ShapeMaterialInfo()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0xA50BA80", Offset = "0xA50AA80", VA = "0x18A50BA80")]
		public ShapeMaterialInfo(ShapeMaterialInfo other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0xA50BA20", Offset = "0xA50AA20", VA = "0x18A50BA20")]
		public void CopyTo(ShapeMaterialInfo shapeMaterialInfo)
		{
		}
	}
}
namespace RecRoom.Core.Creation.Shapes
{
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class RHBLXHOPLWI : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private static readonly int WKJHWCEFYVM;

		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private static readonly int EWYKVWATNOB;

		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private static readonly int NIBHHNVUTNM;

		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private static readonly int ANHHXHRWMPS;

		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private static readonly int IHKOJMHSDVM;

		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private static readonly int OATLMJXUIRP;

		[Cpp2IlInjected.Token(Token = "0x400004D")]
		private static readonly int YDPKJFGIBPG;

		[Cpp2IlInjected.Token(Token = "0x400004E")]
		private static readonly int LRHVUQLCFDU;

		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private static readonly int DZEWYZPZXOS;

		[Cpp2IlInjected.Token(Token = "0x4000050")]
		private static readonly int VRXCXLJZSQI;

		[Cpp2IlInjected.Token(Token = "0x4000051")]
		private static readonly int NRFAETZWUPS;

		[Cpp2IlInjected.Token(Token = "0x4000052")]
		private static readonly int MMPHNAXARPE;

		[Cpp2IlInjected.Token(Token = "0x4000053")]
		private static readonly int IEWDFFFBVLA;

		[Cpp2IlInjected.Token(Token = "0x4000054")]
		private static readonly int IAQZDDZBXRS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public ShapeMaterialInfo[] KKVWWYJXQPI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public Texture2DArray LKQTVAVYGAS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public Texture2DArray EPMXKLTJBUG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public float[] DIHQODMHHDH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public Texture2DArray CWVKOSVEBIS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		public float[] CSWIAGADHTZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public float[] MQPZLJGRWIK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		public float[] JFEQXLCIAIA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public Vector4[] NNADGWEIUKK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public Texture2DArray KRIBHBGPTSG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public float[] JUYALKHMZJV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public float[] RJZTYPNQOFI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public float[] YKQIQYPDTWI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public Vector4[] DYOMQOAJZZQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		private int[] CRXCPFWUHWP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public Texture2DArray JRHVOOOQZWA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public float[] YYMDTKNUFXN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public Vector4[] IZPEFNAXCES;

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0xA509B60", Offset = "0xA508B60", VA = "0x18A509B60")]
		private Texture2DArray XTLWZITSRBR(string a, IReadOnlyList<Texture2D> b, bool c, ShapeMaterialInfo[] d)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0xA50A060", Offset = "0xA509060", VA = "0x18A50A060")]
		public RHBLXHOPLWI(ShapeMaterialInfo[] a, bool b, bool c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0xA509AB0", Offset = "0xA508AB0", VA = "0x18A509AB0")]
		private Vector3 PTIIRTZOLAH(ShapeMaterialInfo a)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0xA509A60", Offset = "0xA508A60", VA = "0x18A509A60")]
		public int NZFVEGNQDDB(ShapeMaterial a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0xA509A10", Offset = "0xA508A10", VA = "0x18A509A10", Slot = "4")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public interface UINALHGAUTK
	{
		[Cpp2IlInjected.Token(Token = "0x17000005")]
		bool NFGEDUXTJDR
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		bool VCXMSJUECFK
		{
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		bool LPBBDSDNROV
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public interface QMMHAFRHRLJ : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x17000008")]
		Texture2D KZSHOCYWCFN
		{
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(Slot = "1")]
		Material TMEARZRCNJD();

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(Slot = "2")]
		int UOTZPZCEGZH(ShapeColor a);

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(Slot = "3")]
		int NZFVEGNQDDB(ShapeMaterial a);

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void BUWMUQUPVQV(Material a);

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(Slot = "5")]
		KQLFSXLAWTZ[] OIQMXRIXZFP();
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public interface YGQBSPHWAJP
	{
		[Cpp2IlInjected.Token(Token = "0x17000009")]
		ColorRemap KJLMIEWBKES
		{
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		ColorRemap ALEOFNXQYVO
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(Slot = "0")]
		ShapeColorInfo SLHPAUVXYEY(ShapeColor a, bool b = true);

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		bool FNZGERFCEUO(ShapeColor a, [Out] Color b);
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public static class OKHXPUNOFUY
	{
		[Cpp2IlInjected.Token(Token = "0x2000012")]
		private class EYBGBWOXCPZ : QMMHAFRHRLJ, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400007F")]
			public RHBLXHOPLWI GLNPFABWEPK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000080")]
			private readonly Texture2D LWVCQGJHALQ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000081")]
			private bool NGIHUOVFPAB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
			[Cpp2IlInjected.Token(Token = "0x4000082")]
			private bool KKFFQNCLVRW;

			[Cpp2IlInjected.Token(Token = "0x4000083")]
			private static KQLFSXLAWTZ[] TIROBPQWVPE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000084")]
			private Texture2D TZGQOBEJNMT;

			[Cpp2IlInjected.Token(Token = "0x1700000B")]
			public Texture2D KZSHOCYWCFN
			{
				[Cpp2IlInjected.Token(Token = "0x6000034")]
				[Cpp2IlInjected.Address(RVA = "0xA505F20", Offset = "0xA504F20", VA = "0x18A505F20", Slot = "4")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0xA5071C0", Offset = "0xA5061C0", VA = "0x18A5071C0")]
			public EYBGBWOXCPZ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0xA5070A0", Offset = "0xA5060A0", VA = "0x18A5070A0")]
			private Color XPJWMVBFQZT(ShapeColorInfo a, CRRDKCGNIAD.ColorChannel b, Color c)
			{
				return default(Color);
			}

			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0xA505EA0", Offset = "0xA504EA0", VA = "0x18A505EA0", Slot = "10")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0xA506E80", Offset = "0xA505E80", VA = "0x18A506E80", Slot = "5")]
			public Material TMEARZRCNJD()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0xA506220", Offset = "0xA505220", VA = "0x18A506220")]
			private void QMBCALGRAHH(Texture2D a, bool b, bool c)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0xA5061E0", Offset = "0xA5051E0", VA = "0x18A5061E0", Slot = "9")]
			public KQLFSXLAWTZ[] OIQMXRIXZFP()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0xA505910", Offset = "0xA504910", VA = "0x18A505910", Slot = "8")]
			public void BUWMUQUPVQV(Material a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0xA506F80", Offset = "0xA505F80", VA = "0x18A506F80", Slot = "6")]
			public int UOTZPZCEGZH(ShapeColor a)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0xA506190", Offset = "0xA505190", VA = "0x18A506190", Slot = "7")]
			public int NZFVEGNQDDB(ShapeMaterial a)
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

			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0xA508360", Offset = "0xA507360", VA = "0x18A508360", Slot = "4")]
			public bool Equals(MaterialHash other)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0xA5082A0", Offset = "0xA5072A0", VA = "0x18A5082A0", Slot = "0")]
			public override bool Equals(object obj)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0xA508550", Offset = "0xA507550", VA = "0x18A508550", Slot = "2")]
			public override int GetHashCode()
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000067")]
		private static Dictionary<MaterialHash, Material> ESVGROAHIVG;

		[Cpp2IlInjected.Token(Token = "0x4000068")]
		private static readonly int MKASFZUKFDF;

		[Cpp2IlInjected.Token(Token = "0x4000069")]
		private static readonly int VZBSJLPDNJD;

		[Cpp2IlInjected.Token(Token = "0x400006A")]
		private static readonly int ITRAWGYGOXL;

		[Cpp2IlInjected.Token(Token = "0x400006B")]
		private static readonly int QNQDYRRVDAI;

		[Cpp2IlInjected.Token(Token = "0x400006C")]
		private static readonly int KQJJSXTIWHA;

		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private static readonly int DTGTCFGYINN;

		[Cpp2IlInjected.Token(Token = "0x400006E")]
		private static readonly int SWYPRJLHREO;

		[Cpp2IlInjected.Token(Token = "0x400006F")]
		private static readonly int NBLXWAJWJVV;

		[Cpp2IlInjected.Token(Token = "0x4000070")]
		private static readonly int ATSAXNPMTPA;

		[Cpp2IlInjected.Token(Token = "0x4000071")]
		private static readonly int VEJNGEEYMWN;

		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private static readonly int HGRMBJLGXKN;

		[Cpp2IlInjected.Token(Token = "0x4000073")]
		private static readonly int GDBMMYYHVDR;

		[Cpp2IlInjected.Token(Token = "0x4000074")]
		private static readonly int VQJNKUZNVPN;

		[Cpp2IlInjected.Token(Token = "0x4000075")]
		private static readonly int ROZTCKRLBMP;

		[Cpp2IlInjected.Token(Token = "0x4000076")]
		private static readonly int YXGTDWYLZKB;

		[Cpp2IlInjected.Token(Token = "0x4000077")]
		private static readonly int CHJXVFHPWSR;

		[Cpp2IlInjected.Token(Token = "0x4000078")]
		private static readonly int ISEFIEWPIED;

		[Cpp2IlInjected.Token(Token = "0x4000079")]
		private static readonly int NRLFYECHXML;

		[Cpp2IlInjected.Token(Token = "0x400007A")]
		private static readonly int MEHEKOKGWZJ;

		[Cpp2IlInjected.Token(Token = "0x400007B")]
		private static readonly int OYTZWMMECQB;

		[Cpp2IlInjected.Token(Token = "0x400007C")]
		private static readonly int AIWIWVSIJYY;

		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public static readonly int IHKOJMHSDVM;

		[Cpp2IlInjected.Token(Token = "0x400007E")]
		public static readonly int FAZPBXRSRGD;

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0xA509060", Offset = "0xA508060", VA = "0x18A509060")]
		[RRPostPlayModeMethod(PostPlayModePhase.ExitingPlayMode, 0)]
		private static void MOJEFGRWPQE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0xA508960", Offset = "0xA507960", VA = "0x18A508960")]
		private static UINALHGAUTK AHXVBJPWSIF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0xA5093A0", Offset = "0xA5083A0", VA = "0x18A5093A0")]
		public static QMMHAFRHRLJ XPTBIZUTKTB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0xA508F90", Offset = "0xA507F90", VA = "0x18A508F90")]
		public static void IXNZDNFOHHL(this Material a, ShapeColor b, ShapeMaterial c, bool d, bool e, float f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0xA5089D0", Offset = "0xA5079D0", VA = "0x18A5089D0")]
		public static void IXNZDNFOHHL(this Material a, ShapeColorInfo b, ShapeMaterialInfo c, bool d, bool e, float f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0xA5090D0", Offset = "0xA5080D0", VA = "0x18A5090D0")]
		public static Material PWIRVFRTOTX(ShapeColorInfo a, ShapeMaterialInfo b, bool c, bool d)
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
			[Cpp2IlInjected.Token(Token = "0x40000AC")]
			UniformCenter,
			[Cpp2IlInjected.Token(Token = "0x40000AD")]
			PyramidCenter,
			[Cpp2IlInjected.Token(Token = "0x40000AE")]
			WedgeCenter,
			[Cpp2IlInjected.Token(Token = "0x40000AF")]
			NumTypes
		}

		[Cpp2IlInjected.Token(Token = "0x2000016")]
		public enum VolumeCalculation
		{
			[Cpp2IlInjected.Token(Token = "0x40000B1")]
			All,
			[Cpp2IlInjected.Token(Token = "0x40000B2")]
			Half,
			[Cpp2IlInjected.Token(Token = "0x40000B3")]
			Cylinder,
			[Cpp2IlInjected.Token(Token = "0x40000B4")]
			Pyramid,
			[Cpp2IlInjected.Token(Token = "0x40000B5")]
			Sphere,
			[Cpp2IlInjected.Token(Token = "0x40000B6")]
			HalfSphere
		}

		[Cpp2IlInjected.Token(Token = "0x2000017")]
		public enum ColliderCost
		{
			[Cpp2IlInjected.Token(Token = "0x40000B8")]
			Sphere,
			[Cpp2IlInjected.Token(Token = "0x40000B9")]
			Box,
			[Cpp2IlInjected.Token(Token = "0x40000BA")]
			Mesh
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000018")]
		public struct ShapeConfigData
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000BB")]
			public string name;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40000BC")]
			[Tooltip("If false, will be hidden in Palette")]
			public bool displayInPalette;

			[Cpp2IlInjected.FieldOffset(Offset = "0x9")]
			[Cpp2IlInjected.Token(Token = "0x40000BD")]
			[Tooltip("If true, will be separated from default in-style shapes in Palette")]
			public bool displayAsAdvanced;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000BE")]
			public GameObject prefab;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000BF")]
			public GameObject prefabUIPreview;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000C0")]
			[Tooltip("Only for primitive shapes")]
			public Mesh collider;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000C1")]
			public CenterOfMass centerOfMass;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x40000C2")]
			public VolumeCalculation volumeCalculation;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000C3")]
			public ColliderCost colliderCost;

			[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
			[Cpp2IlInjected.Token(Token = "0x40000C4")]
			[Tooltip("Standard is (1,1,1)")]
			public Vector3 boundsSize;
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000019")]
		public class ShapeColorToColorDictionary : SerializedDictionary<ShapeColor, Color, ShapeColorToColorDictionary.KeyVal>
		{
			[Serializable]
			[Cpp2IlInjected.Token(Token = "0x200001A")]
			public class KeyVal : SerializedKeyVal<ShapeColor, Color>
			{
				[Cpp2IlInjected.Token(Token = "0x6000044")]
				[Cpp2IlInjected.Address(RVA = "0xA507D80", Offset = "0xA506D80", VA = "0x18A507D80")]
				public KeyVal()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0xA50B880", Offset = "0xA50A880", VA = "0x18A50B880")]
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
		[HideInInspector]
		public ShapeColorToColorDictionary RROShapeColorAdditive;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		[Header("Generated Color Tuners")]
		public ColorRemap SpecularRemap;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		public ColorRemap EmissiveRemap;

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		protected override bool GTDXFOESXIB
		{
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0xD55280", Offset = "0xD54280", VA = "0x180D55280", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0xA50B8C0", Offset = "0xA50A8C0", VA = "0x18A50B8C0")]
		public ShapeConfig()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public static class FXBNZGTOVTI
	{
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		public static readonly ShapeType[] MLHERICQUYB;

		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		public static readonly int[] UYHXUOTUWDQ;

		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		public static readonly PrimitiveShapeMeshType[] XGMLYSDEOBM;

		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		private static readonly Dictionary<ShapeType, int> PMVCUAIBFSC;

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0xA507400", Offset = "0xA506400", VA = "0x18A507400")]
		private static Dictionary<ShapeType, int> ESEMIAPPJRP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0xA507650", Offset = "0xA506650", VA = "0x18A507650")]
		public static PrimitiveShapeMeshType XQAGRHRTNOP(this ShapeType a)
		{
			return default(PrimitiveShapeMeshType);
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0xA507390", Offset = "0xA506390", VA = "0x18A507390")]
		public static int AOZDBHXAZKS(this ShapeType a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0xA5075B0", Offset = "0xA5065B0", VA = "0x18A5075B0")]
		public static int UHLAUYZWNRD(this ShapeType a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x16BB540", Offset = "0x16BA540", VA = "0x1816BB540")]
		public static bool URCTEOOSSYU(this ShapeType a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x9C6CE80", Offset = "0x9C6BE80", VA = "0x189C6CE80")]
		public static bool JYNFNWCWODI(this ShapeType a)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	public class GIUBUOUXHDI : YGQBSPHWAJP
	{
		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public ColorRemap KJLMIEWBKES
		{
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0xA507CD0", Offset = "0xA506CD0", VA = "0x18A507CD0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public ColorRemap ALEOFNXQYVO
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0xA5079F0", Offset = "0xA5069F0", VA = "0x18A5079F0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0xD11530", Offset = "0xD10530", VA = "0x180D11530")]
		[UnityEngine.Scripting.Preserve]
		internal GIUBUOUXHDI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0xA507B80", Offset = "0xA506B80", VA = "0x18A507B80")]
		[GEPWJNEAFDW.Root]
		internal static void RDUKEQTCCWZ(VIGMLMXVCUS a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0xA507C70", Offset = "0xA506C70", VA = "0x18A507C70", Slot = "4")]
		public ShapeColorInfo SLHPAUVXYEY(ShapeColor a, bool b = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0xA507AA0", Offset = "0xA506AA0", VA = "0x18A507AA0", Slot = "5")]
		public bool FNZGERFCEUO(ShapeColor a, [Out] Color b)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public static class YMHSPCEZUDS
	{
		[Cpp2IlInjected.Token(Token = "0x200001F")]
		public enum DensityOption
		{
			[Cpp2IlInjected.Token(Token = "0x40000DA")]
			Air,
			[Cpp2IlInjected.Token(Token = "0x40000DB")]
			Aerogel,
			[Cpp2IlInjected.Token(Token = "0x40000DC")]
			Lithium,
			[Cpp2IlInjected.Token(Token = "0x40000DD")]
			Water,
			[Cpp2IlInjected.Token(Token = "0x40000DE")]
			Lead
		}

		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		public static YZDETVQVLVA QGTNHSRKVWJ;

		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		private static Material JCGBAGVONOO;

		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		private static Material LVZCXPLRYYU;

		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		private static bool RCUDUKKDMXY;

		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		private static QMMHAFRHRLJ ZZIMUWENOUV;

		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		private static readonly CollisionMeshData[] APADJTFEJDM;

		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		private static CollisionMeshData IGNVARYEDZM;

		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		private static int[] WKXNAQPJNID;

		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		private static int[] ARFPCJMQCUJ;

		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		private static readonly LZPNKDWQFGX<ShapeColor, ShapeColorInfo> DQFOHQHWCZT;

		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		public static readonly Dictionary<string, EnumChoiceData> UFVLJFMXOUX;

		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		public static readonly Dictionary<int, string> UGASGMGUYGG;

		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		private static readonly Vector3[] QRBDYKFFNYI;

		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		public static readonly Dictionary<string, EnumChoiceData> TLFQLSJRJJY;

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public static ShapeConfig JVYKGGTMWQC
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0xA50E1B0", Offset = "0xA50D1B0", VA = "0x18A50E1B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		private static QMMHAFRHRLJ FMAIQRDNQZQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0xA50BDA0", Offset = "0xA50ADA0", VA = "0x18A50BDA0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public static Texture2D KZSHOCYWCFN
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0xA50C990", Offset = "0xA50B990", VA = "0x18A50C990")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public static ColorRemap KJLMIEWBKES
		{
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0xA50FB70", Offset = "0xA50EB70", VA = "0x18A50FB70")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public static ColorRemap ALEOFNXQYVO
		{
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0xA50C490", Offset = "0xA50B490", VA = "0x18A50C490")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public static ShapeColorInfo[] NVWWRAZMZKN
		{
			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0xA50D3A0", Offset = "0xA50C3A0", VA = "0x18A50D3A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public static ShapeMaterialInfo[] PSYQITWLDFH
		{
			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0xA50E860", Offset = "0xA50D860", VA = "0x18A50E860")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public static int YGIEHCJKLTF
		{
			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0x1FCEC10", Offset = "0x1FCDC10", VA = "0x181FCEC10")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		private static int[] MXELJVHNXTE
		{
			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0xA50BEC0", Offset = "0xA50AEC0", VA = "0x18A50BEC0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		private static int[] AZYLSFGVSTA
		{
			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0xA50CA70", Offset = "0xA50BA70", VA = "0x18A50CA70")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public static Shader NFYTEZBRARV
		{
			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0xA50BE40", Offset = "0xA50AE40", VA = "0x18A50BE40")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public static Material TTJIFPKZUGF
		{
			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0xA50E060", Offset = "0xA50D060", VA = "0x18A50E060")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0xA50E2C0", Offset = "0xA50D2C0", VA = "0x18A50E2C0")]
		private static void SHORFCMAUCJ(Scene a, LoadSceneMode b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0xA50DC70", Offset = "0xA50CC70", VA = "0x18A50DC70")]
		public static GameObject OIPRMQHDYPX(ShapeType a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0xA50F730", Offset = "0xA50E730", VA = "0x18A50F730")]
		public static GameObject XRTSIQYGCUP(ShapeType a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0xA50F590", Offset = "0xA50E590", VA = "0x18A50F590")]
		private static Mesh XJZOAHLNCJY(ShapeType a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0xA50E660", Offset = "0xA50D660", VA = "0x18A50E660")]
		public static bool TNFVCJJHLNP(ShapeType a, [Out] Mesh b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0xA50C510", Offset = "0xA50B510", VA = "0x18A50C510")]
		private static void EBXUNWCAJLC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0xA50F4C0", Offset = "0xA50E4C0", VA = "0x18A50F4C0")]
		public static Material XAIOSCBXEXO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0xA50C810", Offset = "0xA50B810", VA = "0x18A50C810")]
		public static Material EYGSYZYMUDC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0xA50D420", Offset = "0xA50C420", VA = "0x18A50D420")]
		public static Vector3 JZBLSEPNUXK(Vector3 a, Quaternion b, ShapeMaterial c)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0xA50DD10", Offset = "0xA50CD10", VA = "0x18A50DD10")]
		private static Vector3 OYCAMUVNLJS(Vector3 a, Quaternion b, ShapeMaterial c, bool d)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0xA50D5D0", Offset = "0xA50C5D0", VA = "0x18A50D5D0")]
		public static void KOHPALSXRZJ(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0xA50E8E0", Offset = "0xA50D8E0", VA = "0x18A50E8E0")]
		public static int UOTZPZCEGZH(ShapeColor a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0xA50DBF0", Offset = "0xA50CBF0", VA = "0x18A50DBF0")]
		public static int NZFVEGNQDDB(ShapeMaterial a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0xA50EC30", Offset = "0xA50DC30", VA = "0x18A50EC30")]
		[RRPostPlayModeMethod(PostPlayModePhase.ExitingPlayMode, 0)]
		private static void UYPOTTQGLSS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0xA50F130", Offset = "0xA50E130", VA = "0x18A50F130")]
		public static CollisionMeshData VYPSGALCHFU(ShapeType a)
		{
			return default(CollisionMeshData);
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0xA50F870", Offset = "0xA50E870", VA = "0x18A50F870")]
		public static CollisionMeshData YGXXUJQEGXA()
		{
			return default(CollisionMeshData);
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0xA50F7D0", Offset = "0xA50E7D0", VA = "0x18A50F7D0")]
		public static string XYZURVAEVAW(ShapeType a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0xA50E740", Offset = "0xA50D740", VA = "0x18A50E740")]
		public static Bounds UBOIWCGHMEE(ShapeType a)
		{
			return default(Bounds);
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0xA50D820", Offset = "0xA50C820", VA = "0x18A50D820")]
		public static int MXGEDNZMJDT(ShapeType a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0xA50C8E0", Offset = "0xA50B8E0", VA = "0x18A50C8E0")]
		public static bool FNZGERFCEUO(ShapeColor a, [Out] Color b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0xA50D9D0", Offset = "0xA50C9D0", VA = "0x18A50D9D0")]
		public static int NHTIJTJRYLV(int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0xA50F110", Offset = "0xA50E110", VA = "0x18A50F110")]
		public static int VXSYPCWAIUG(int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0xA50C7A0", Offset = "0xA50B7A0", VA = "0x18A50C7A0")]
		public static Color ENHXRHYCFRM(ShapeColor a)
		{
			return default(Color);
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0xA50F0F0", Offset = "0xA50E0F0", VA = "0x18A50F0F0")]
		public static bool VMZHUOESJNJ(ShapeType a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0xA50E0E0", Offset = "0xA50D0E0", VA = "0x18A50E0E0")]
		public static int QEATZDBMFNT(ShapeType a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0xA50E340", Offset = "0xA50D340", VA = "0x18A50E340")]
		[NotNull]
		public static ShapeColorInfo SLHPAUVXYEY(ShapeColor a, bool b = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0xA50D780", Offset = "0xA50C780", VA = "0x18A50D780")]
		public static ShapeMaterialInfo MLTSKMJLRPO(ShapeMaterial a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0xA50D9F0", Offset = "0xA50C9F0", VA = "0x18A50D9F0")]
		public static float NVOLGDHINPX(int a)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0xA50EF00", Offset = "0xA50DF00", VA = "0x18A50EF00")]
		public static int VKHKDUEGNCD(int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0xA50ED20", Offset = "0xA50DD20", VA = "0x18A50ED20")]
		public static int VBHBIWMUQOF(int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0xA50E1E0", Offset = "0xA50D1E0", VA = "0x18A50E1E0")]
		public static Vector3 RKCYJVUMWQJ(ShapeType a)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0xA50F950", Offset = "0xA50E950", VA = "0x18A50F950")]
		public static float ZAGOIVADAVU(ShapeType a, Vector3 b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0xA50E960", Offset = "0xA50D960", VA = "0x18A50E960")]
		public static void UUFCRKPHWOB(bool a = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0xA50D160", Offset = "0xA50C160", VA = "0x18A50D160")]
		private static void JKXZWAOHEDE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0xA50CD00", Offset = "0xA50BD00", VA = "0x18A50CD00")]
		public static void ILGNEUWLXHY()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0xA50C150", Offset = "0xA50B150", VA = "0x18A50C150")]
		public static void DVHIUUGAUCH()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public enum ShapeType
	{
		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		Invalid = -1,
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		CURVE_Tube = 0,
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		CURVE_Ribbon = 1,
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		LegacyBox = 2,
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		RR_Sphere = 3,
		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		RR_Cylinder = 4,
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		LEGACY_Wedge = 5,
		[Cpp2IlInjected.Token(Token = "0x40000EB")]
		LEGACY_Pyramid = 6,
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		LEGACY_TriggerVolumeBox = 7,
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		RR_Box = 8,
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		LEGACY_RoundedBox = 9,
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		RR_Wedge = 10,
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		RR_Pyramid = 11,
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		RR_HalfSphere = 12,
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		RR_Cone = 13,
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		RR_Pipe = 14,
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		RR_Donut = 15,
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		RR_HalfPipe = 16,
		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		RR_Diamond = 17,
		[Cpp2IlInjected.Token(Token = "0x40000F7")]
		ADVANCED_Mound = 18,
		[Cpp2IlInjected.Token(Token = "0x40000F8")]
		ADVANCED_Cube = 19,
		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		ADVANCED_Sphere = 20,
		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		ADVANCED_Cylinder = 21,
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		ADVANCED_Cone = 22,
		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		ADVANCED_Pyramid = 23,
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		ADVANCED_Octagon = 24,
		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		ADVANCED_Triangle = 25,
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		ADVANCED_Hexagon = 26,
		[Cpp2IlInjected.Token(Token = "0x4000100")]
		ADVANCED_QuarterPipe = 27,
		[Cpp2IlInjected.Token(Token = "0x4000101")]
		ADVANCED_Pentagon = 28,
		[Cpp2IlInjected.Token(Token = "0x4000102")]
		ADVANCED_Dodecahedron = 29,
		[Cpp2IlInjected.Token(Token = "0x4000103")]
		ADVANCED_Trihedron = 30,
		[Cpp2IlInjected.Token(Token = "0x4000104")]
		ADVANCED_Octahedron = 31,
		[Cpp2IlInjected.Token(Token = "0x4000105")]
		RR_QuarterCylinder = 32,
		[Cpp2IlInjected.Token(Token = "0x4000106")]
		RR_Pentagon = 33,
		[Cpp2IlInjected.Token(Token = "0x4000107")]
		RR_QuarterSphere = 34,
		[Cpp2IlInjected.Token(Token = "0x4000108")]
		ADVANCED_Wedge = 35,
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		RR_Hexagon = 36,
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		RR_Octagon = 37,
		[Cpp2IlInjected.Token(Token = "0x400010B")]
		RR_Triangle = 38,
		[Cpp2IlInjected.Token(Token = "0x400010C")]
		COUNT = 39,
		[Cpp2IlInjected.Token(Token = "0x400010D")]
		MIN_VALUE = -1,
		[Cpp2IlInjected.Token(Token = "0x400010E")]
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
