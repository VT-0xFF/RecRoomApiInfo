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
		[Cpp2IlInjected.Address(RVA = "0xA4AA2F0", Offset = "0xA4A8CF0", VA = "0x18A4AA2F0", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x2A16AE0", Offset = "0x2A154E0", VA = "0x182A16AE0")]
		public _AssemblyIndex()
		{
		}
	}
}
namespace RecRoom
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public static class FGKYLWVQSTT
	{
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public static readonly int IPNOFSMYJMY;

		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public static readonly int QZCEHKAJEFD;

		[Cpp2IlInjected.Token(Token = "0x4000003")]
		public static readonly int XHWALFCISOZ;

		[Cpp2IlInjected.Token(Token = "0x4000004")]
		public static readonly int MASDNACRZFN;

		[Cpp2IlInjected.Token(Token = "0x4000005")]
		public static readonly int QRRKGNWQZZP;

		[Cpp2IlInjected.Token(Token = "0x4000006")]
		public static readonly int CGVTCXZDUOV;

		[Cpp2IlInjected.Token(Token = "0x4000007")]
		public static readonly int RALXKTJSYGR;

		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public static readonly int IQMLFJVOEZH;

		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public static readonly int LVVMYFQXCTQ;

		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public static readonly int TLQCGVUVGEH;

		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public static readonly int KDJNMQFGFHF;

		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public static readonly int ERAURVLGRID;

		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public static readonly int QLCNRUNYCCT;

		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public static readonly int EWUOVWBCPLR;

		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public static readonly int YIHMBUECBLL;

		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public static readonly int YSEHGLZZRVM;

		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public static readonly int BYIUAOJPRSS;

		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public static readonly int PFXXGKUYHLQ;

		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public static readonly int TOFTPQZKAIU;

		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public static readonly int PVEFLLJOETM;

		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public static readonly int WTZUSNHVNPD;

		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public static readonly int SZWDCRUEKVU;

		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public static readonly int GUFGXVQJREY;

		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public static readonly int FVAHMFTLNYB;

		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public static readonly int XPMVCOCJKUE;

		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public static readonly int KBKRUNCILGH;

		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public static readonly int EJOAVTWYUGH;

		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public static readonly int BFZEVVDBIHY;
	}
}
namespace RecRoom.Core.Creation
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public class EMKOOOWYONT
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public readonly int UDYNKLIOGMS;

		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private static EMKOOOWYONT BXRBUPETPDJ;

		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private static EMKOOOWYONT BKZISCHPZDW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private readonly int ASWKYQOVTYO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private readonly int AVMWPANNMQB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private readonly int AWCRGUVFOYC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private readonly float MTCCOJOAYCH;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public static EMKOOOWYONT ZAZQYNYWSCE
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0xA4A4B60", Offset = "0xA4A3560", VA = "0x18A4A4B60")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public static EMKOOOWYONT BCLEEVLHAWH
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0xA4A4C10", Offset = "0xA4A3610", VA = "0x18A4A4C10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xA4A4D20", Offset = "0xA4A3720", VA = "0x18A4A4D20")]
		public EMKOOOWYONT(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0xA4A4A80", Offset = "0xA4A3480", VA = "0x18A4A4A80")]
		public int IJZZEKFIXPV(Color a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0xA4A4CB0", Offset = "0xA4A36B0", VA = "0x18A4A4CB0")]
		public Color UWNKNVUJSIT(int a)
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
		[Cpp2IlInjected.Address(RVA = "0xA4A0580", Offset = "0xA49EF80", VA = "0x18A4A0580")]
		public float DRPWYUNMYYR(float a, Vector2 b, bool c)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xA4A05D0", Offset = "0xA49EFD0", VA = "0x18A4A05D0")]
		public Color DRPWYUNMYYR(float a, float b, float c)
		{
			return default(Color);
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0xA4A06C0", Offset = "0xA49F0C0", VA = "0x18A4A06C0")]
		public ColorRemap()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public static class KOMISVVILBR
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
		[Cpp2IlInjected.Address(RVA = "0xA4A53C0", Offset = "0xA4A3DC0", VA = "0x18A4A53C0")]
		public static Texture2D NXEPKYJNATO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0xA4A55C0", Offset = "0xA4A3FC0", VA = "0x18A4A55C0")]
		public static Texture2D VVZCWCOPSHE(Func<ShapeColorInfo, ColorChannel, Color, Color> a, string b = "LegacyColorTexture")
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0xA4A5210", Offset = "0xA4A3C10", VA = "0x18A4A5210")]
		[CompilerGenerated]
		internal static void EIRUZGOMIPZ(ShapeColorInfo a, int b, <>c__DisplayClass2_0 c)
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
		private static NQSKMVJZUKB GRYOKUPRGLJ;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		private static NQSKMVJZUKB UOQTHZHNJFG
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0xA4A81F0", Offset = "0xA4A6BF0", VA = "0x18A4A81F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public Color Additive
		{
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0xA4A82B0", Offset = "0xA4A6CB0", VA = "0x18A4A82B0")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0xA4A79D0", Offset = "0xA4A63D0", VA = "0x18A4A79D0")]
		public static ShapeColor JBFVVJLHZZR(Color a, EMKOOOWYONT b)
		{
			return default(ShapeColor);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0xA4A78E0", Offset = "0xA4A62E0", VA = "0x18A4A78E0")]
		public static ShapeColor JBFVVJLHZZR(Color a)
		{
			return default(ShapeColor);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0xA4A7DB0", Offset = "0xA4A67B0", VA = "0x18A4A7DB0")]
		public static ShapeColorInfo MVDOPEIAKYZ(ShapeColor a, EMKOOOWYONT b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0xA4A7FF0", Offset = "0xA4A69F0", VA = "0x18A4A7FF0")]
		public static ShapeColorInfo RAWPLQDNFIJ(ShapeColor a, EMKOOOWYONT b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0xA4A7AA0", Offset = "0xA4A64A0", VA = "0x18A4A7AA0")]
		public static bool MGXKPJLIDYP(Color a, [Out] ShapeColorInfo b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0xD10590", Offset = "0xD0EF90", VA = "0x180D10590")]
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
		[Cpp2IlInjected.Address(RVA = "0xA4A8640", Offset = "0xA4A7040", VA = "0x18A4A8640")]
		public ShapeMaterialInfo()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0xA4A85B0", Offset = "0xA4A6FB0", VA = "0x18A4A85B0")]
		public ShapeMaterialInfo(ShapeMaterialInfo other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0xA4A8550", Offset = "0xA4A6F50", VA = "0x18A4A8550")]
		public void CopyTo(ShapeMaterialInfo shapeMaterialInfo)
		{
		}
	}
}
namespace RecRoom.Core.Creation.Shapes
{
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class CEOMEXFQEGY : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private static readonly int HWMYZOVWIUK;

		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private static readonly int PONTWQUAJHD;

		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private static readonly int TTCSWHXFWQG;

		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private static readonly int DALLEIAQNHC;

		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private static readonly int HYBKCMMKFBA;

		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private static readonly int MJAEIICSQQF;

		[Cpp2IlInjected.Token(Token = "0x400004D")]
		private static readonly int DZBSZRZQWUE;

		[Cpp2IlInjected.Token(Token = "0x400004E")]
		private static readonly int XAWFHIZXUFQ;

		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private static readonly int KPDYVXRWKOC;

		[Cpp2IlInjected.Token(Token = "0x4000050")]
		private static readonly int TNQTHXSIPQI;

		[Cpp2IlInjected.Token(Token = "0x4000051")]
		private static readonly int ZWDLIFMDXUQ;

		[Cpp2IlInjected.Token(Token = "0x4000052")]
		private static readonly int IXPRYJUMAEK;

		[Cpp2IlInjected.Token(Token = "0x4000053")]
		private static readonly int OGHTUQMFLRA;

		[Cpp2IlInjected.Token(Token = "0x4000054")]
		private static readonly int PHKFKXSSFOM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public ShapeMaterialInfo[] BWJXNPSNBPY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public Texture2DArray JGAFAMHGJRI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public Texture2DArray JXBJENZMAZE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public float[] AKHSUWBBAPX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public Texture2DArray JUGYTQWBSUC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		public float[] GDCFNGZDMOD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public float[] DGBOMQOLGRU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		public float[] DQGJBWEWLUA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public Vector4[] OUIGKFQMVTY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public Texture2DArray CAKKWVVWWIK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public float[] BOTGHGYIYLR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public float[] MXQJTMYAILI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public float[] XJEKBQLQCFC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public Vector4[] FWARJVNIPCS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		private int[] QZUUWNMADMP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public Texture2DArray SDYHMWHQXIA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public float[] PDZEGUMPBQP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public Vector4[] HQVINETWJGG;

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0xA49F290", Offset = "0xA49DC90", VA = "0x18A49F290")]
		private Texture2DArray JARYTEJBANR(string a, IReadOnlyList<Texture2D> b, bool c, ShapeMaterialInfo[] d)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0xA49F860", Offset = "0xA49E260", VA = "0x18A49F860")]
		public CEOMEXFQEGY(ShapeMaterialInfo[] a, bool b, bool c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0xA49F500", Offset = "0xA49DF00", VA = "0x18A49F500")]
		private Vector3 RNBZLOVYSVV(ShapeMaterialInfo a)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0xA49F5B0", Offset = "0xA49DFB0", VA = "0x18A49F5B0")]
		public int SUICNCULBZB(ShapeMaterial a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0xA49F240", Offset = "0xA49DC40", VA = "0x18A49F240", Slot = "4")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public interface QMFEXJDJZQQ
	{
		[Cpp2IlInjected.Token(Token = "0x17000005")]
		bool ELNMCQXSHEL
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		bool AZRJMNLMOUI
		{
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		bool BCZCVGCWRQF
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public interface FEXMJJXGKDB : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x17000008")]
		Texture2D SLJIZMNRMQL
		{
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(Slot = "1")]
		Material HZRYXDLPGQV();

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(Slot = "2")]
		int BKSCVAYJETP(ShapeColor a);

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(Slot = "3")]
		int SUICNCULBZB(ShapeMaterial a);

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void UWYHNEILKRD(Material a);

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(Slot = "5")]
		NAUDDOCKLNV[] FIKEXQENXVL();
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public interface NQSKMVJZUKB
	{
		[Cpp2IlInjected.Token(Token = "0x17000009")]
		ColorRemap HCCVMGQJLFY
		{
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		ColorRemap OJHFCBFPLYY
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(Slot = "0")]
		ShapeColorInfo TQQMMKDJMOA(ShapeColor a, bool b = true);

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		bool KWABOMPUJTQ(ShapeColor a, [Out] Color b);
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public static class QLHUVVSQIRO
	{
		[Cpp2IlInjected.Token(Token = "0x2000012")]
		private class YUDSDLLABHR : FEXMJJXGKDB, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400007F")]
			public CEOMEXFQEGY SKUTOKJYILO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000080")]
			private readonly Texture2D HJLHDJSEYYK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000081")]
			private bool AKKYAKUGEYR;

			[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
			[Cpp2IlInjected.Token(Token = "0x4000082")]
			private bool QVXGCPKLJSA;

			[Cpp2IlInjected.Token(Token = "0x4000083")]
			private static NAUDDOCKLNV[] GCDFANWSHUW;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000084")]
			private Texture2D SRHDIIIGWGP;

			[Cpp2IlInjected.Token(Token = "0x1700000B")]
			public Texture2D SLJIZMNRMQL
			{
				[Cpp2IlInjected.Token(Token = "0x6000034")]
				[Cpp2IlInjected.Address(RVA = "0xA4A97E0", Offset = "0xA4A81E0", VA = "0x18A4A97E0", Slot = "4")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0xA4AA120", Offset = "0xA4A8B20", VA = "0x18A4AA120")]
			public YUDSDLLABHR()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0xA4AA000", Offset = "0xA4A8A00", VA = "0x18A4AA000")]
			private Color ZKRLAISNJGJ(ShapeColorInfo a, KOMISVVILBR.ColorChannel b, Color c)
			{
				return default(Color);
			}

			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0xA4A9620", Offset = "0xA4A8020", VA = "0x18A4A9620", Slot = "10")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0xA4A96E0", Offset = "0xA4A80E0", VA = "0x18A4A96E0", Slot = "5")]
			public Material HZRYXDLPGQV()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0xA4A89F0", Offset = "0xA4A73F0", VA = "0x18A4A89F0")]
			private void BMBBZJSKMRH(Texture2D a, bool b, bool c)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0xA4A96A0", Offset = "0xA4A80A0", VA = "0x18A4A96A0", Slot = "9")]
			public NAUDDOCKLNV[] FIKEXQENXVL()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0xA4A9AA0", Offset = "0xA4A84A0", VA = "0x18A4A9AA0", Slot = "8")]
			public void UWYHNEILKRD(Material a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0xA4A88D0", Offset = "0xA4A72D0", VA = "0x18A4A88D0", Slot = "6")]
			public int BKSCVAYJETP(ShapeColor a)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0xA4A9A50", Offset = "0xA4A8450", VA = "0x18A4A9A50", Slot = "7")]
			public int SUICNCULBZB(ShapeMaterial a)
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
			[Cpp2IlInjected.Address(RVA = "0xA4A5B40", Offset = "0xA4A4540", VA = "0x18A4A5B40", Slot = "4")]
			public bool Equals(MaterialHash other)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0xA4A5D30", Offset = "0xA4A4730", VA = "0x18A4A5D30", Slot = "0")]
			public override bool Equals(object obj)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0xA4A5DF0", Offset = "0xA4A47F0", VA = "0x18A4A5DF0", Slot = "2")]
			public override int GetHashCode()
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000067")]
		private static Dictionary<MaterialHash, Material> FRXHYWMDFKM;

		[Cpp2IlInjected.Token(Token = "0x4000068")]
		private static readonly int ZTLIPKQKGRR;

		[Cpp2IlInjected.Token(Token = "0x4000069")]
		private static readonly int XOUXUFVNVLT;

		[Cpp2IlInjected.Token(Token = "0x400006A")]
		private static readonly int DEGCMNRLUNL;

		[Cpp2IlInjected.Token(Token = "0x400006B")]
		private static readonly int OIMXXOPRCEA;

		[Cpp2IlInjected.Token(Token = "0x400006C")]
		private static readonly int JRQASFMWDXA;

		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private static readonly int WPCGNVWCGPF;

		[Cpp2IlInjected.Token(Token = "0x400006E")]
		private static readonly int ILATVSAJEIW;

		[Cpp2IlInjected.Token(Token = "0x400006F")]
		private static readonly int FPSRALOVHVZ;

		[Cpp2IlInjected.Token(Token = "0x4000070")]
		private static readonly int VXETFWVHIFE;

		[Cpp2IlInjected.Token(Token = "0x4000071")]
		private static readonly int AFUEZDSKKKZ;

		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private static readonly int DVJFUPMVNUF;

		[Cpp2IlInjected.Token(Token = "0x4000073")]
		private static readonly int GNSPOSTPAVN;

		[Cpp2IlInjected.Token(Token = "0x4000074")]
		private static readonly int ECNVNAOKQED;

		[Cpp2IlInjected.Token(Token = "0x4000075")]
		private static readonly int EVQXKKRSZIL;

		[Cpp2IlInjected.Token(Token = "0x4000076")]
		private static readonly int SWFSDRGPEWR;

		[Cpp2IlInjected.Token(Token = "0x4000077")]
		private static readonly int XDCJLOPQQZH;

		[Cpp2IlInjected.Token(Token = "0x4000078")]
		private static readonly int KDCPKUZVEKD;

		[Cpp2IlInjected.Token(Token = "0x4000079")]
		private static readonly int TCRIGQVDSGH;

		[Cpp2IlInjected.Token(Token = "0x400007A")]
		private static readonly int VNNQXVBQPPV;

		[Cpp2IlInjected.Token(Token = "0x400007B")]
		private static readonly int JGHQSDAHOAN;

		[Cpp2IlInjected.Token(Token = "0x400007C")]
		private static readonly int BMUQNLDTUDC;

		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public static readonly int HYBKCMMKFBA;

		[Cpp2IlInjected.Token(Token = "0x400007E")]
		public static readonly int MDXQZXJCXHV;

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0xA4A6F90", Offset = "0xA4A5990", VA = "0x18A4A6F90")]
		[RRPostPlayModeMethod(PostPlayModePhase.ExitingPlayMode, 0)]
		private static void PASTELJJGIU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0xA4A68C0", Offset = "0xA4A52C0", VA = "0x18A4A68C0")]
		private static QMFEXJDJZQQ FTNAQJUSNFT()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0xA4A7000", Offset = "0xA4A5A00", VA = "0x18A4A7000")]
		public static FEXMJJXGKDB PLJZNYPWZQH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0xA4A6930", Offset = "0xA4A5330", VA = "0x18A4A6930")]
		public static void GHKPNZPJRJL(this Material a, ShapeColor b, ShapeMaterial c, bool d, bool e, float f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0xA4A6A00", Offset = "0xA4A5400", VA = "0x18A4A6A00")]
		public static void GHKPNZPJRJL(this Material a, ShapeColorInfo b, ShapeMaterialInfo c, bool d, bool e, float f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0xA4A7200", Offset = "0xA4A5C00", VA = "0x18A4A7200")]
		public static Material VNIKYPHXMPD(ShapeColorInfo a, ShapeMaterialInfo b, bool c, bool d)
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
				[Cpp2IlInjected.Address(RVA = "0xA4A5B00", Offset = "0xA4A4500", VA = "0x18A4A5B00")]
				public KeyVal()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0xA4A83B0", Offset = "0xA4A6DB0", VA = "0x18A4A83B0")]
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
		protected override bool AAEFCZWPOIZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0xD54D90", Offset = "0xD53790", VA = "0x180D54D90", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0xA4A83F0", Offset = "0xA4A6DF0", VA = "0x18A4A83F0")]
		public ShapeConfig()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public static class OOMTQAHSEPQ
	{
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		public static readonly ShapeType[] GKCRTTVCICZ;

		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		public static readonly int[] YTKDEPAMTGS;

		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		public static readonly PrimitiveShapeMeshType[] GWQDFQSNCRA;

		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		private static readonly Dictionary<ShapeType, int> MKGSGPXQAZE;

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0xA4A6400", Offset = "0xA4A4E00", VA = "0x18A4A6400")]
		private static Dictionary<ShapeType, int> SVVMHUXTDKJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0xA4A6280", Offset = "0xA4A4C80", VA = "0x18A4A6280")]
		public static PrimitiveShapeMeshType IKSAGXONXHJ(this ShapeType a)
		{
			return default(PrimitiveShapeMeshType);
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0xA4A6390", Offset = "0xA4A4D90", VA = "0x18A4A6390")]
		public static int PAVBXCXRQJE(this ShapeType a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0xA4A62F0", Offset = "0xA4A4CF0", VA = "0x18A4A62F0")]
		public static int MXHTHPOUGAV(this ShapeType a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x16C2620", Offset = "0x16C1020", VA = "0x1816C2620")]
		public static bool GPUZMGJJTSY(this ShapeType a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x9C10AF0", Offset = "0x9C0F4F0", VA = "0x189C10AF0")]
		public static bool RSPHLFAURBE(this ShapeType a)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	public class NKSQDZZIYWS : NQSKMVJZUKB
	{
		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public ColorRemap HCCVMGQJLFY
		{
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0xA4A6170", Offset = "0xA4A4B70", VA = "0x18A4A6170", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public ColorRemap OJHFCBFPLYY
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0xA4A60C0", Offset = "0xA4A4AC0", VA = "0x18A4A60C0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0xD10590", Offset = "0xD0EF90", VA = "0x180D10590")]
		[UnityEngine.Scripting.Preserve]
		internal NKSQDZZIYWS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0xA4A5EF0", Offset = "0xA4A48F0", VA = "0x18A4A5EF0")]
		[ONTQUCAGRJW.Root]
		internal static void BREYGLPBXMV(KLUMUBWDFVY a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0xA4A6220", Offset = "0xA4A4C20", VA = "0x18A4A6220", Slot = "4")]
		public ShapeColorInfo TQQMMKDJMOA(ShapeColor a, bool b = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0xA4A5FE0", Offset = "0xA4A49E0", VA = "0x18A4A5FE0", Slot = "5")]
		public bool KWABOMPUJTQ(ShapeColor a, [Out] Color b)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public static class DMBUYRMSBVO
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
		public static BQUYOYJDJCS PFNNWFNMNQJ;

		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		private static Material PQVXCCGJSXM;

		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		private static Material YZEZEOFAOVO;

		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		private static bool KMXSYIPJRSK;

		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		private static FEXMJJXGKDB NNPIPNODNXH;

		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		private static readonly CollisionMeshData[] ZXUDBBPETHY;

		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		private static CollisionMeshData YDTJEWOWVIC;

		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		private static int[] WCSPUNJFMWX;

		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		private static int[] JPKZIASYQQV;

		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		private static readonly TCLCQNCIIAT<ShapeColor, ShapeColorInfo> DBOCOSZGFZD;

		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		public static readonly Dictionary<string, EnumChoiceData> VNTUAMYUMLF;

		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		public static readonly Dictionary<int, string> VNZAXTSRVWO;

		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		private static readonly Vector3[] WSLIXEBEDAU;

		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		public static readonly Dictionary<string, EnumChoiceData> LSCEKMAUBQO;

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public static ShapeConfig QKJKJVSOHHE
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0xA4A22D0", Offset = "0xA4A0CD0", VA = "0x18A4A22D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		private static FEXMJJXGKDB YDTPYAQCYUW
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0xA4A37D0", Offset = "0xA4A21D0", VA = "0x18A4A37D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public static Texture2D SLJIZMNRMQL
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0xA4A1BF0", Offset = "0xA4A05F0", VA = "0x18A4A1BF0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public static ColorRemap HCCVMGQJLFY
		{
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0xA4A2450", Offset = "0xA4A0E50", VA = "0x18A4A2450")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public static ColorRemap OJHFCBFPLYY
		{
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0xA4A21E0", Offset = "0xA4A0BE0", VA = "0x18A4A21E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public static ShapeColorInfo[] ALLMFCRAGUZ
		{
			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0xA4A23D0", Offset = "0xA4A0DD0", VA = "0x18A4A23D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public static ShapeMaterialInfo[] JDFKYTSUCON
		{
			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0xA4A1780", Offset = "0xA4A0180", VA = "0x18A4A1780")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public static int VOWXXSMNIFB
		{
			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0x1FD7E90", Offset = "0x1FD6890", VA = "0x181FD7E90")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		private static int[] VAXFYHZLPLA
		{
			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0xA4A2F50", Offset = "0xA4A1950", VA = "0x18A4A2F50")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		private static int[] JLFESDISLUG
		{
			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0xA4A0D30", Offset = "0xA49F730", VA = "0x18A4A0D30")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public static Shader MBGMJNPVVXJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0xA4A3E80", Offset = "0xA4A2880", VA = "0x18A4A3E80")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public static Material OJCKPYNJSMF
		{
			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0xA4A18A0", Offset = "0xA4A02A0", VA = "0x18A4A18A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0xA4A06F0", Offset = "0xA49F0F0", VA = "0x18A4A06F0")]
		private static void AJWPUVGIVDP(Scene a, LoadSceneMode b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0xA4A2750", Offset = "0xA4A1150", VA = "0x18A4A2750")]
		public static GameObject SNZFFKGVHWR(ShapeType a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0xA4A4080", Offset = "0xA4A2A80", VA = "0x18A4A4080")]
		public static GameObject YPSRPGXILJN(ShapeType a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0xA4A3630", Offset = "0xA4A2030", VA = "0x18A4A3630")]
		private static Mesh VDTRTLFQSPQ(ShapeType a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0xA4A3FA0", Offset = "0xA4A29A0", VA = "0x18A4A3FA0")]
		public static bool YFWRYXYNRYF(ShapeType a, [Out] Mesh b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0xA4A0AC0", Offset = "0xA49F4C0", VA = "0x18A4A0AC0")]
		private static void CYNOIFLKVSQ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0xA4A1500", Offset = "0xA49FF00", VA = "0x18A4A1500")]
		public static Material FYOWZYQKSUQ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0xA4A2300", Offset = "0xA4A0D00", VA = "0x18A4A2300")]
		public static Material OSAJXJTUQRC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0xA4A15D0", Offset = "0xA49FFD0", VA = "0x18A4A15D0")]
		public static Vector3 GAUWFLJXYGY(Vector3 a, Quaternion b, ShapeMaterial c)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0xA4A3B30", Offset = "0xA4A2530", VA = "0x18A4A3B30")]
		private static Vector3 WYOSRUCJCKI(Vector3 a, Quaternion b, ShapeMaterial c, bool d)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0xA4A32B0", Offset = "0xA4A1CB0", VA = "0x18A4A32B0")]
		public static void VACYIFPXNWD(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0xA4A0770", Offset = "0xA49F170", VA = "0x18A4A0770")]
		public static int BKSCVAYJETP(ShapeColor a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0xA4A2810", Offset = "0xA4A1210", VA = "0x18A4A2810")]
		public static int SUICNCULBZB(ShapeMaterial a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0xA4A2100", Offset = "0xA4A0B00", VA = "0x18A4A2100")]
		[RRPostPlayModeMethod(PostPlayModePhase.ExitingPlayMode, 0)]
		private static void NCVCJHLBYWK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0xA4A2890", Offset = "0xA4A1290", VA = "0x18A4A2890")]
		public static CollisionMeshData TKLYZXSLDRQ(ShapeType a)
		{
			return default(CollisionMeshData);
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0xA4A09F0", Offset = "0xA49F3F0", VA = "0x18A4A09F0")]
		public static CollisionMeshData CJVIAHYGENQ()
		{
			return default(CollisionMeshData);
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0xA4A3F00", Offset = "0xA4A2900", VA = "0x18A4A3F00")]
		public static string XTNDBIVSEIW(ShapeType a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0xA4A4120", Offset = "0xA4A2B20", VA = "0x18A4A4120")]
		public static Bounds ZKGYGZZIFWY(ShapeType a)
		{
			return default(Bounds);
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0xA4A24D0", Offset = "0xA4A0ED0", VA = "0x18A4A24D0")]
		public static int QSQGNKHJGIR(ShapeType a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0xA4A1B40", Offset = "0xA4A0540", VA = "0x18A4A1B40")]
		public static bool KWABOMPUJTQ(ShapeColor a, [Out] Color b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0xA4A27F0", Offset = "0xA4A11F0", VA = "0x18A4A27F0")]
		public static int SSVLDTDHHCH(int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0xA4A2F30", Offset = "0xA4A1930", VA = "0x18A4A2F30")]
		public static int UCRRTUASCES(int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0xA4A2260", Offset = "0xA4A0C60", VA = "0x18A4A2260")]
		public static Color ODUCBNAVQLI(ShapeColor a)
		{
			return default(Color);
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0xA4A14E0", Offset = "0xA49FEE0", VA = "0x18A4A14E0")]
		public static bool FQWBVRMEUHN(ShapeType a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0xA4A2680", Offset = "0xA4A1080", VA = "0x18A4A2680")]
		public static int ROVCAGNAKLP(ShapeType a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0xA4A2C10", Offset = "0xA4A1610", VA = "0x18A4A2C10")]
		[NotNull]
		public static ShapeColorInfo TQQMMKDJMOA(ShapeColor a, bool b = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0xA4A1800", Offset = "0xA4A0200", VA = "0x18A4A1800")]
		public static ShapeMaterialInfo HKXICRLNENS(ShapeMaterial a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0xA4A07F0", Offset = "0xA49F1F0", VA = "0x18A4A07F0")]
		public static float BNCSMVFIPZH(int a)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0xA4A4240", Offset = "0xA4A2C40", VA = "0x18A4A4240")]
		public static int ZVFGLFADYTZ(int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0xA4A3450", Offset = "0xA4A1E50", VA = "0x18A4A3450")]
		public static int VCKPZJAHVMB(int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0xA4A31D0", Offset = "0xA4A1BD0", VA = "0x18A4A31D0")]
		public static Vector3 UOZVPUFZSCR(ShapeType a)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0xA4A1920", Offset = "0xA4A0320", VA = "0x18A4A1920")]
		public static float JCPOQWLDMTE(ShapeType a, Vector3 b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0xA4A3870", Offset = "0xA4A2270", VA = "0x18A4A3870")]
		public static void WSTPPEAEILT(bool a = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0xA4A0FA0", Offset = "0xA49F9A0", VA = "0x18A4A0FA0")]
		private static void DXAWWIEKHLE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0xA4A1CD0", Offset = "0xA4A06D0", VA = "0x18A4A1CD0")]
		public static void MYKFWWYAMNE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0xA4A11B0", Offset = "0xA49FBB0", VA = "0x18A4A11B0")]
		public static void ETRHQBXLGLJ()
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
