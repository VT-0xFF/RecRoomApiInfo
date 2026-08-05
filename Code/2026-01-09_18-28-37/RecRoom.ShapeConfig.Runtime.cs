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
		[Cpp2IlInjected.Address(RVA = "0x8D05160", Offset = "0x8D04560", VA = "0x188D05160", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x273B290", Offset = "0x273A690", VA = "0x18273B290")]
		public _AssemblyIndex()
		{
		}
	}
}
namespace RecRoom
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public static class DEERZYUXIIX
	{
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public static readonly int MELPYHIFPQC;

		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public static readonly int QAUCXVCNLYD;

		[Cpp2IlInjected.Token(Token = "0x4000003")]
		public static readonly int ENJDMMZJHLR;

		[Cpp2IlInjected.Token(Token = "0x4000004")]
		public static readonly int OTPIOMBBISJ;

		[Cpp2IlInjected.Token(Token = "0x4000005")]
		public static readonly int HRVEVFFIEOT;

		[Cpp2IlInjected.Token(Token = "0x4000006")]
		public static readonly int CBTIMOTMKAX;

		[Cpp2IlInjected.Token(Token = "0x4000007")]
		public static readonly int REIMLBVYDIH;

		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public static readonly int UJGOXHJXDED;

		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public static readonly int ECXWEDVPEEE;

		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public static readonly int HJQGSWFYLCB;

		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public static readonly int SRHBOPQKOKJ;

		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public static readonly int YYWWZJSFFGB;

		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public static readonly int CKHWDZJWRTL;

		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public static readonly int UWKDAZGWGBD;

		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public static readonly int VJAOSNUQQHB;

		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public static readonly int HDDCDTBQPCU;

		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public static readonly int LFAAORCFHWU;

		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public static readonly int IVNKYVHMNXW;

		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public static readonly int AGSZZXPVOJY;

		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public static readonly int MHGULSMNCIM;

		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public static readonly int NRGNGIEGRFZ;

		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public static readonly int YUSMGJMXWAQ;

		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public static readonly int KJNBZNKGJQK;

		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public static readonly int YEWYTZVOLRN;

		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public static readonly int UBMQHFIGOJM;

		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public static readonly int EBMCNMGENQJ;

		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public static readonly int KYCIAFQQLBL;

		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public static readonly int VZRSSDOERTC;
	}
}
namespace RecRoom.Core.Creation
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public class KVDCYHWGUXB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public readonly int WWIURUMFUCE;

		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private static KVDCYHWGUXB WBSYHLCIPJD;

		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private static KVDCYHWGUXB PFFGJEXKSRA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private readonly int CVTCLYUKZBK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private readonly int CZZRGKWHPFR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private readonly int CYZIUDAUUAY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private readonly float XXKWDCIRGBT;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public static KVDCYHWGUXB PQDFIHTOTYG
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x8CFDEF0", Offset = "0x8CFD2F0", VA = "0x188CFDEF0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public static KVDCYHWGUXB COEQEZEIPJD
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x8CFDD70", Offset = "0x8CFD170", VA = "0x188CFDD70")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x8CFDFA0", Offset = "0x8CFD3A0", VA = "0x188CFDFA0")]
		public KVDCYHWGUXB(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x8CFDE10", Offset = "0x8CFD210", VA = "0x188CFDE10")]
		public int IBTTETEIRUR(Color a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x8CFDD00", Offset = "0x8CFD100", VA = "0x188CFDD00")]
		public Color ACBFARJCTPX(int a)
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
		[Cpp2IlInjected.Address(RVA = "0x8CFBAE0", Offset = "0x8CFAEE0", VA = "0x188CFBAE0")]
		public float URXFDQVCDFR(float a, Vector2 b, bool c)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x8CFBB30", Offset = "0x8CFAF30", VA = "0x188CFBB30")]
		public Color URXFDQVCDFR(float a, float b, float c)
		{
			return default(Color);
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x8CFBC20", Offset = "0x8CFB020", VA = "0x188CFBC20")]
		public ColorRemap()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public static class GALLELJLOKV
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
		[Cpp2IlInjected.Address(RVA = "0x8CFC0E0", Offset = "0x8CFB4E0", VA = "0x188CFC0E0")]
		public static Texture2D KSUZWUDJFWG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x8CFC2E0", Offset = "0x8CFB6E0", VA = "0x188CFC2E0")]
		public static Texture2D PCHRONVOCQY(Func<ShapeColorInfo, ColorChannel, Color, Color> a, string b = "LegacyColorTexture")
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x8CFC820", Offset = "0x8CFBC20", VA = "0x188CFC820")]
		[CompilerGenerated]
		internal static void ZNUQWNWYETH(ShapeColorInfo a, int b, <>c__DisplayClass2_0 c)
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
		private static JFBJTJHPLCP TPFNSMGWJHD;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		private static JFBJTJHPLCP TYQEGAJKYDU
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x8CFFD20", Offset = "0x8CFF120", VA = "0x188CFFD20")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public Color Additive
		{
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x8CFFDE0", Offset = "0x8CFF1E0", VA = "0x188CFFDE0")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x8CFFC50", Offset = "0x8CFF050", VA = "0x188CFFC50")]
		public static ShapeColor KHCEBJMRUUJ(Color a, KVDCYHWGUXB b)
		{
			return default(ShapeColor);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x8CFFB60", Offset = "0x8CFEF60", VA = "0x188CFFB60")]
		public static ShapeColor KHCEBJMRUUJ(Color a)
		{
			return default(ShapeColor);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x8CFF410", Offset = "0x8CFE810", VA = "0x188CFF410")]
		public static ShapeColorInfo AFYBTIHQJYT(ShapeColor a, KVDCYHWGUXB b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x8CFF960", Offset = "0x8CFED60", VA = "0x188CFF960")]
		public static ShapeColorInfo GSQZGXKSFQT(ShapeColor a, KVDCYHWGUXB b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x8CFF650", Offset = "0x8CFEA50", VA = "0x188CFF650")]
		public static bool FKXWFSFLERD(Color a, [Out] ShapeColorInfo b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0xAAB600", Offset = "0xAAAA00", VA = "0x180AAB600")]
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
		[Cpp2IlInjected.Address(RVA = "0x8D00170", Offset = "0x8CFF570", VA = "0x188D00170")]
		public ShapeMaterialInfo()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x8D000E0", Offset = "0x8CFF4E0", VA = "0x188D000E0")]
		public ShapeMaterialInfo(ShapeMaterialInfo other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x8D00080", Offset = "0x8CFF480", VA = "0x188D00080")]
		public void CopyTo(ShapeMaterialInfo shapeMaterialInfo)
		{
		}
	}
}
namespace RecRoom.Core.Creation.Shapes
{
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class GASGDFZJSQO : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private static readonly int PYWXOTFMKKI;

		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private static readonly int NYGYCBPXDQH;

		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private static readonly int DWAOOWHHCDG;

		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private static readonly int MTLGFGDGEPU;

		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private static readonly int TBLCGNOXTJW;

		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private static readonly int XQQVQVIFWOX;

		[Cpp2IlInjected.Token(Token = "0x400004D")]
		private static readonly int JMAVLLRNJWG;

		[Cpp2IlInjected.Token(Token = "0x400004E")]
		private static readonly int SLSREWESRHS;

		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private static readonly int FANILMLARZO;

		[Cpp2IlInjected.Token(Token = "0x4000050")]
		private static readonly int AFFWMHYZWGS;

		[Cpp2IlInjected.Token(Token = "0x4000051")]
		private static readonly int LNGMEBFSKLA;

		[Cpp2IlInjected.Token(Token = "0x4000052")]
		private static readonly int EQQKNKTVDFO;

		[Cpp2IlInjected.Token(Token = "0x4000053")]
		private static readonly int HXHUHQSTQME;

		[Cpp2IlInjected.Token(Token = "0x4000054")]
		private static readonly int HKWDCRHIOOC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public ShapeMaterialInfo[] FNOUCWHSPPO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public Texture2DArray OXTBYRWVGII;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public Texture2DArray ZNWGAQQNKRC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public float[] BXAXZFVZUAH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public Texture2DArray EZHSKLYVLGM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		public float[] JNTPYPNPUND;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public float[] HTJFNUODTQI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		public float[] EUZQITRAEQG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public Vector4[] ZCLDSEDMYMI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public Texture2DArray HSXSPBULBVW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public float[] XUZCBTKTZUR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public float[] DORTKBNEAAE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public float[] PDEUZDGKIWS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public Vector4[] EDPFOPTCFOI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		private int[] VPOLROUNODX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public Texture2DArray MUGQVDQZZZU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public float[] QDYRVGMNKWV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public Vector4[] FQZWCQCCJZO;

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x8CFCAD0", Offset = "0x8CFBED0", VA = "0x188CFCAD0")]
		private Texture2DArray MZGPGAIZTRD(string a, IReadOnlyList<Texture2D> b, bool c, ShapeMaterialInfo[] d)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x8CFCFF0", Offset = "0x8CFC3F0", VA = "0x188CFCFF0")]
		public GASGDFZJSQO(ShapeMaterialInfo[] a, bool b, bool c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x8CFC9D0", Offset = "0x8CFBDD0", VA = "0x188CFC9D0")]
		private Vector3 BFUGCEIUTGZ(ShapeMaterialInfo a)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x8CFCD40", Offset = "0x8CFC140", VA = "0x188CFCD40")]
		public int OJEBEPWAVDH(ShapeMaterial a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x8CFCA80", Offset = "0x8CFBE80", VA = "0x188CFCA80", Slot = "4")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public interface KWAWFTFLWBQ
	{
		[Cpp2IlInjected.Token(Token = "0x17000005")]
		bool IBTFYPHAINL
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		bool XZRXWCHYKDM
		{
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		bool BCJVILQCBNV
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public interface RGULPNZWCNP : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x17000008")]
		Texture2D MCEQOBYTJSZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(Slot = "1")]
		Material YMGRULWFOKH();

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(Slot = "2")]
		int RUVESQGSZFJ(ShapeColor a);

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(Slot = "3")]
		int OJEBEPWAVDH(ShapeMaterial a);

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void AOSGMDAIGLF(Material a);

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(Slot = "5")]
		OCIRYUTVXIZ[] EXGMRXESKYP();
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public interface JFBJTJHPLCP
	{
		[Cpp2IlInjected.Token(Token = "0x17000009")]
		ColorRemap VTROAVDHXNS
		{
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		ColorRemap ROYSKIRYBOG
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(Slot = "0")]
		ShapeColorInfo JYVBYDITPHY(ShapeColor a, bool b = true);

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		bool PGYVCBNVZAM(ShapeColor a, [Out] Color b);
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public static class SJGAKACUNOS
	{
		[Cpp2IlInjected.Token(Token = "0x2000012")]
		private class BTXKNOSSJEB : RGULPNZWCNP, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400007F")]
			public GASGDFZJSQO RKCNXMTJHDY;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000080")]
			private readonly Texture2D CVBZRUBKTXG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000081")]
			private bool KKTUQISRFBV;

			[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
			[Cpp2IlInjected.Token(Token = "0x4000082")]
			private bool TBGNDXRISDE;

			[Cpp2IlInjected.Token(Token = "0x4000083")]
			private static OCIRYUTVXIZ[] VBDQDSAJSJG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000084")]
			private Texture2D KCAHQWPVZEF;

			[Cpp2IlInjected.Token(Token = "0x1700000B")]
			public Texture2D MCEQOBYTJSZ
			{
				[Cpp2IlInjected.Token(Token = "0x6000034")]
				[Cpp2IlInjected.Address(RVA = "0x8CFB360", Offset = "0x8CFA760", VA = "0x188CFB360", Slot = "4")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x8CFB910", Offset = "0x8CFAD10", VA = "0x188CFB910")]
			public BTXKNOSSJEB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x8CFB6F0", Offset = "0x8CFAAF0", VA = "0x188CFB6F0")]
			private Color UVUVBJKNRAD(ShapeColorInfo a, GALLELJLOKV.ColorChannel b, Color c)
			{
				return default(Color);
			}

			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x8CFA310", Offset = "0x8CF9710", VA = "0x188CFA310", Slot = "10")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x8CFB810", Offset = "0x8CFAC10", VA = "0x188CFB810", Slot = "5")]
			public Material YMGRULWFOKH()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x8CFA420", Offset = "0x8CF9820", VA = "0x188CFA420")]
			private void PWXYGAKMBUD(Texture2D a, bool b, bool c)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x8CFA390", Offset = "0x8CF9790", VA = "0x188CFA390", Slot = "9")]
			public OCIRYUTVXIZ[] EXGMRXESKYP()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x8CF9DB0", Offset = "0x8CF91B0", VA = "0x188CF9DB0", Slot = "8")]
			public void AOSGMDAIGLF(Material a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x8CFB5D0", Offset = "0x8CFA9D0", VA = "0x188CFB5D0", Slot = "6")]
			public int RUVESQGSZFJ(ShapeColor a)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x8CFA3D0", Offset = "0x8CF97D0", VA = "0x188CFA3D0", Slot = "7")]
			public int OJEBEPWAVDH(ShapeMaterial a)
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
			[Cpp2IlInjected.Address(RVA = "0x8CFE040", Offset = "0x8CFD440", VA = "0x188CFE040", Slot = "4")]
			public bool Equals(MaterialHash other)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x8CFE230", Offset = "0x8CFD630", VA = "0x188CFE230", Slot = "0")]
			public override bool Equals(object obj)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x8CFE2F0", Offset = "0x8CFD6F0", VA = "0x188CFE2F0", Slot = "2")]
			public override int GetHashCode()
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000067")]
		private static Dictionary<MaterialHash, Material> PJLKCCPCTPU;

		[Cpp2IlInjected.Token(Token = "0x4000068")]
		private static readonly int NIKDNCKJIFD;

		[Cpp2IlInjected.Token(Token = "0x4000069")]
		private static readonly int UJPFYWVLDHV;

		[Cpp2IlInjected.Token(Token = "0x400006A")]
		private static readonly int GYZZFDXBWMP;

		[Cpp2IlInjected.Token(Token = "0x400006B")]
		private static readonly int ZZMVVUNKIJA;

		[Cpp2IlInjected.Token(Token = "0x400006C")]
		private static readonly int MNHBQSJYVHW;

		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private static readonly int AINQPHBIAFH;

		[Cpp2IlInjected.Token(Token = "0x400006E")]
		private static readonly int JTXTPHCDTEE;

		[Cpp2IlInjected.Token(Token = "0x400006F")]
		private static readonly int AQCYICJYOAR;

		[Cpp2IlInjected.Token(Token = "0x4000070")]
		private static readonly int QYKAKFQLADG;

		[Cpp2IlInjected.Token(Token = "0x4000071")]
		private static readonly int ZPAIHCUYFNV;

		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private static readonly int JOAAETVDVUD;

		[Cpp2IlInjected.Token(Token = "0x4000073")]
		private static readonly int DIKCXGEFWWZ;

		[Cpp2IlInjected.Token(Token = "0x4000074")]
		private static readonly int AUGPKUHRYYV;

		[Cpp2IlInjected.Token(Token = "0x4000075")]
		private static readonly int VFZKZYBDGZD;

		[Cpp2IlInjected.Token(Token = "0x4000076")]
		private static readonly int HRXDPUTSNDF;

		[Cpp2IlInjected.Token(Token = "0x4000077")]
		private static readonly int FBZBOHMADQD;

		[Cpp2IlInjected.Token(Token = "0x4000078")]
		private static readonly int XERYDCDXESR;

		[Cpp2IlInjected.Token(Token = "0x4000079")]
		private static readonly int BPJUGTRMSFL;

		[Cpp2IlInjected.Token(Token = "0x400007A")]
		private static readonly int VCVGHUPJUSJ;

		[Cpp2IlInjected.Token(Token = "0x400007B")]
		private static readonly int YLUZMHHLUDZ;

		[Cpp2IlInjected.Token(Token = "0x400007C")]
		private static readonly int AFZTSQAIPUS;

		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public static readonly int TBLCGNOXTJW;

		[Cpp2IlInjected.Token(Token = "0x400007E")]
		public static readonly int PNLWYZBAAAN;

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x8CFEF10", Offset = "0x8CFE310", VA = "0x188CFEF10")]
		[RRPostPlayModeMethod(PostPlayModePhase.ExitingPlayMode, 0)]
		private static void SHPPOFIJMJA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x8CFEF80", Offset = "0x8CFE380", VA = "0x188CFEF80")]
		private static KWAWFTFLWBQ XMSMXGLPNWD()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x8CFED10", Offset = "0x8CFE110", VA = "0x188CFED10")]
		public static RGULPNZWCNP OMEXTDAHJTL()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x8CFE6B0", Offset = "0x8CFDAB0", VA = "0x188CFE6B0")]
		public static void HOOYIETJMFZ(this Material a, ShapeColor b, ShapeMaterial c, bool d, bool e, float f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x8CFE780", Offset = "0x8CFDB80", VA = "0x188CFE780")]
		public static void HOOYIETJMFZ(this Material a, ShapeColorInfo b, ShapeMaterialInfo c, bool d, bool e, float f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x8CFE3F0", Offset = "0x8CFD7F0", VA = "0x188CFE3F0")]
		public static Material DACILWJKIIT(ShapeColorInfo a, ShapeMaterialInfo b, bool c, bool d)
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
				[Cpp2IlInjected.Address(RVA = "0x8CFE000", Offset = "0x8CFD400", VA = "0x188CFE000")]
				public KeyVal()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x8CFFEE0", Offset = "0x8CFF2E0", VA = "0x188CFFEE0")]
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
		protected override bool VLJASFKDUKP
		{
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0xAECF50", Offset = "0xAEC350", VA = "0x180AECF50", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x8CFFF20", Offset = "0x8CFF320", VA = "0x188CFFF20")]
		public ShapeConfig()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public static class TREHFXAHSNG
	{
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		public static readonly ShapeType[] PJTOTKBYTEH;

		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		public static readonly int[] ICYXLHGVMOE;

		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		public static readonly PrimitiveShapeMeshType[] CMWDFWIBEUY;

		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		private static readonly Dictionary<ShapeType, int> UZNHAMHCXMU;

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x8D001A0", Offset = "0x8CFF5A0", VA = "0x188D001A0")]
		private static Dictionary<ShapeType, int> DIPLYFRVMTJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x8D003F0", Offset = "0x8CFF7F0", VA = "0x188D003F0")]
		public static PrimitiveShapeMeshType ZEYKEWVNNHX(this ShapeType a)
		{
			return default(PrimitiveShapeMeshType);
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x8D00460", Offset = "0x8CFF860", VA = "0x188D00460")]
		public static int ZPUSCHRXMLS(this ShapeType a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x8D00350", Offset = "0x8CFF750", VA = "0x188D00350")]
		public static int TVLINZUPXJN(this ShapeType a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x13CEBC0", Offset = "0x13CDFC0", VA = "0x1813CEBC0")]
		public static bool OETHVXQFXAG(this ShapeType a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x8476510", Offset = "0x8475910", VA = "0x188476510")]
		public static bool MYDUYVFDZBW(this ShapeType a)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	public class WZGGQIQXTWE : JFBJTJHPLCP
	{
		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public ColorRemap VTROAVDHXNS
		{
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x8D04FD0", Offset = "0x8D043D0", VA = "0x188D04FD0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public ColorRemap ROYSKIRYBOG
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x8D04F20", Offset = "0x8D04320", VA = "0x188D04F20", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0xAAB600", Offset = "0xAAAA00", VA = "0x180AAB600")]
		[UnityEngine.Scripting.Preserve]
		internal WZGGQIQXTWE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x8D04DD0", Offset = "0x8D041D0", VA = "0x188D04DD0")]
		[JKCTBFVRGVY.Root]
		internal static void ICBJJQORUJZ(NAWAUUZVKFS a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x8D04EC0", Offset = "0x8D042C0", VA = "0x188D04EC0", Slot = "4")]
		public ShapeColorInfo JYVBYDITPHY(ShapeColor a, bool b = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x8D05080", Offset = "0x8D04480", VA = "0x188D05080", Slot = "5")]
		public bool PGYVCBNVZAM(ShapeColor a, [Out] Color b)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public static class UKNXSBGGYTE
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
		public static OAGBKHNZSHS FKRFHGPGJZN;

		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		private static Material YLTNUVYRSZK;

		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		private static Material GOMVYKCLSTY;

		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		private static bool QZMGGJHFTYE;

		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		private static RGULPNZWCNP YNQPAVQYKDZ;

		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		private static readonly CollisionMeshData[] WZZYZNTRYQI;

		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		private static CollisionMeshData RZOUBDWYJTC;

		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		private static int[] VPQWKJFDFHT;

		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		private static int[] YSDBXJGKVVR;

		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		private static readonly KQKEIHVWGTT<ShapeColor, ShapeColorInfo> HLYTANELOAL;

		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		public static readonly Dictionary<string, EnumChoiceData> EDSUOMNGPRD;

		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		public static readonly Dictionary<int, string> EDCZWSFONJC;

		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		private static readonly Vector3[] AHZPZYNYVQW;

		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		public static readonly Dictionary<string, EnumChoiceData> XMUDZPKQECU;

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public static ShapeConfig LIGDBZOJBCU
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x8D013D0", Offset = "0x8D007D0", VA = "0x188D013D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		private static RGULPNZWCNP OVHFYSLJMKQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x8D01C40", Offset = "0x8D01040", VA = "0x188D01C40")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public static Texture2D MCEQOBYTJSZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x8D02AD0", Offset = "0x8D01ED0", VA = "0x188D02AD0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public static ColorRemap VTROAVDHXNS
		{
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x8D02580", Offset = "0x8D01980", VA = "0x188D02580")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public static ColorRemap ROYSKIRYBOG
		{
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0x8D02480", Offset = "0x8D01880", VA = "0x188D02480")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public static ShapeColorInfo[] IUEWUEDLOYH
		{
			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x8D03E70", Offset = "0x8D03270", VA = "0x188D03E70")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public static ShapeMaterialInfo[] VZGIKIJWNET
		{
			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x8D04400", Offset = "0x8D03800", VA = "0x188D04400")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public static int RGODKAHSEJL
		{
			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0x1C3DAB0", Offset = "0x1C3CEB0", VA = "0x181C3DAB0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		private static int[] KHEBSIQSCVS
		{
			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0x8D01480", Offset = "0x8D00880", VA = "0x188D01480")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		private static int[] LPFWXWQGZBG
		{
			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0x8D03600", Offset = "0x8D02A00", VA = "0x188D03600")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public static Shader IXLNBHQTZOB
		{
			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x8D02500", Offset = "0x8D01900", VA = "0x188D02500")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public static Material HGUFHYWCIGD
		{
			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x8D01400", Offset = "0x8D00800", VA = "0x188D01400")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x8D02860", Offset = "0x8D01C60", VA = "0x188D02860")]
		private static void PITFTOJPVGT(Scene a, LoadSceneMode b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x8D03B50", Offset = "0x8D02F50", VA = "0x188D03B50")]
		public static GameObject TQCBNEQUFYH(ShapeType a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x8D03EF0", Offset = "0x8D032F0", VA = "0x188D03EF0")]
		public static GameObject WEUGFILZLDD(ShapeType a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x8D01CE0", Offset = "0x8D010E0", VA = "0x188D01CE0")]
		private static Mesh LGYNGHFEEYM(ShapeType a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x8D03A70", Offset = "0x8D02E70", VA = "0x188D03A70")]
		public static bool TKMZPWVRZTF(ShapeType a, [Out] Mesh b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x8D03390", Offset = "0x8D02790", VA = "0x188D03390")]
		private static void SPIVSGIGQDU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x8D03CC0", Offset = "0x8D030C0", VA = "0x188D03CC0")]
		public static Material UGYKJONBVPQ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x8D03BF0", Offset = "0x8D02FF0", VA = "0x188D03BF0")]
		public static Material UBODAKNVVSC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x8D01220", Offset = "0x8D00620", VA = "0x188D01220")]
		public static Vector3 FLFHYPVYEFY(Vector3 a, Quaternion b, ShapeMaterial c)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x8D03F90", Offset = "0x8D03390", VA = "0x188D03F90")]
		private static Vector3 XOIKBHMNVHQ(Vector3 a, Quaternion b, ShapeMaterial c, bool d)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x8D04540", Offset = "0x8D03940", VA = "0x188D04540")]
		public static void ZJROZYCRTUV(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x8D02EE0", Offset = "0x8D022E0", VA = "0x188D02EE0")]
		public static int RUVESQGSZFJ(ShapeColor a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x8D02400", Offset = "0x8D01800", VA = "0x188D02400")]
		public static int OJEBEPWAVDH(ShapeMaterial a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x8D017D0", Offset = "0x8D00BD0", VA = "0x188D017D0")]
		[RRPostPlayModeMethod(PostPlayModePhase.ExitingPlayMode, 0)]
		private static void JOUKZZNSRNO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x8D01E80", Offset = "0x8D01280", VA = "0x188D01E80")]
		public static CollisionMeshData MBYEFNANWNS(ShapeType a)
		{
			return default(CollisionMeshData);
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x8D00A40", Offset = "0x8CFFE40", VA = "0x188D00A40")]
		public static CollisionMeshData ANRDKKIVAFG()
		{
			return default(CollisionMeshData);
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x8D046E0", Offset = "0x8D03AE0", VA = "0x188D046E0")]
		public static string ZNQUMRMWSQI(ShapeType a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x8D042E0", Offset = "0x8D036E0", VA = "0x188D042E0")]
		public static Bounds XRAEEDEFESK(ShapeType a)
		{
			return default(Bounds);
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x8D02600", Offset = "0x8D01A00", VA = "0x188D02600")]
		public static int PALDLTGKSFV(ShapeType a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x8D027B0", Offset = "0x8D01BB0", VA = "0x188D027B0")]
		public static bool PGYVCBNVZAM(ShapeColor a, [Out] Color b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x8D04520", Offset = "0x8D03920", VA = "0x188D04520")]
		public static int YQCUZICJDDP(int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x8D023E0", Offset = "0x8D017E0", VA = "0x188D023E0")]
		public static int NAOHYMYSFFO(int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x8D01BD0", Offset = "0x8D00FD0", VA = "0x188D01BD0")]
		public static Color KBQFBRRZUPO(ShapeColor a)
		{
			return default(Color);
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x8D00B10", Offset = "0x8CFFF10", VA = "0x188D00B10")]
		public static bool BBAAGQYPKMN(ShapeType a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x8D01700", Offset = "0x8D00B00", VA = "0x188D01700")]
		public static int JBSPKTSUJTR(ShapeType a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x8D018B0", Offset = "0x8D00CB0", VA = "0x188D018B0")]
		[NotNull]
		public static ShapeColorInfo JYVBYDITPHY(ShapeColor a, bool b = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x8D04480", Offset = "0x8D03880", VA = "0x188D04480")]
		public static ShapeMaterialInfo XZJEHPRVJWC(ShapeMaterial a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x8D03870", Offset = "0x8D02C70", VA = "0x188D03870")]
		public static float TDJRMROZDWH(int a)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x8D028E0", Offset = "0x8D01CE0", VA = "0x188D028E0")]
		public static int QHQPBNSBZMV(int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x8D02200", Offset = "0x8D01600", VA = "0x188D02200")]
		public static int MKGZBOJQUVN(int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x8D03D90", Offset = "0x8D03190", VA = "0x188D03D90")]
		public static Vector3 UHEZJPJOPUX(ShapeType a)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x8D00D40", Offset = "0x8D00140", VA = "0x188D00D40")]
		public static float EBUUSELFHQI(ShapeType a, Vector3 b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x8D00F60", Offset = "0x8D00360", VA = "0x188D00F60")]
		public static void EJCIZCAMGMT(bool a = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x8D00B30", Offset = "0x8CFFF30", VA = "0x188D00B30")]
		private static void BGKXAJUSVYA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x8D02F60", Offset = "0x8D02360", VA = "0x188D02F60")]
		public static void SBKEMAVNVPG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x8D02BB0", Offset = "0x8D01FB0", VA = "0x188D02BB0")]
		public static void RFYRQUTXIJL()
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
