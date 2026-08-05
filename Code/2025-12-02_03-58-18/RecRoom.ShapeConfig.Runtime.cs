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
		[Cpp2IlInjected.Address(RVA = "0x8CCC440", Offset = "0x8CCB040", VA = "0x188CCC440", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x2721D10", Offset = "0x2720910", VA = "0x182721D10")]
		public _AssemblyIndex()
		{
		}
	}
}
namespace RecRoom
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public static class NYRRHAXSXLK
	{
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public static readonly int EJQPAOHJEAH;

		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public static readonly int EGYDKCJEQRU;

		[Cpp2IlInjected.Token(Token = "0x4000003")]
		public static readonly int KFZPEMUXILY;

		[Cpp2IlInjected.Token(Token = "0x4000004")]
		public static readonly int JQZWCZQKUFW;

		[Cpp2IlInjected.Token(Token = "0x4000005")]
		public static readonly int WYCYXWAFBIO;

		[Cpp2IlInjected.Token(Token = "0x4000006")]
		public static readonly int JCKNGEZGOBA;

		[Cpp2IlInjected.Token(Token = "0x4000007")]
		public static readonly int CWHOGBGZKVI;

		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public static readonly int XKLKNTJMNLS;

		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public static readonly int XFTNJOASTWJ;

		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public static readonly int BSVZLMJUBIQ;

		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public static readonly int XHAHQSKHXIQ;

		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public static readonly int TPGRHTZVVHS;

		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public static readonly int MWKIMPUCKIS;

		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public static readonly int PMGFYSULROO;

		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public static readonly int RRXKJODHACY;

		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public static readonly int DXEGMBCBDPJ;

		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public static readonly int APOIVUGWVBH;

		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public static readonly int YHDISKELZRR;

		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public static readonly int QTBZXCMVLFB;

		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public static readonly int QVAQUXEYIMJ;

		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public static readonly int XXXEWMKSKGO;

		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public static readonly int BFQKOAXHTUL;

		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public static readonly int DODIRWCCKVF;

		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public static readonly int ISYYJXDOGSI;

		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public static readonly int LYGLSCVTFTP;

		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public static readonly int IATTSBSQNGS;

		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public static readonly int NYULAUIXKGO;

		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public static readonly int ABVRWDRNUTB;
	}
}
namespace RecRoom.Core.Creation
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public class YYDYBGNWLJU
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public readonly int HFXTOFVPEMV;

		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private static YYDYBGNWLJU HCQBMJDKWRO;

		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private static YYDYBGNWLJU SNSRWQGGJCN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private readonly int TWZNFWWJGVB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private readonly int TUJBPMXRODO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private readonly int TTTGXSPZLVN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private readonly float CQVCHLKORWU;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public static YYDYBGNWLJU SZZIZENGXMB
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x8CCC250", Offset = "0x8CCAE50", VA = "0x188CCC250")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public static YYDYBGNWLJU KUWMEJYCYIA
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x8CCC130", Offset = "0x8CCAD30", VA = "0x188CCC130")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x8CCC3E0", Offset = "0x8CCAFE0", VA = "0x188CCC3E0")]
		public YYDYBGNWLJU(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x8CCC300", Offset = "0x8CCAF00", VA = "0x188CCC300")]
		public int QFOJAYCJDRW(Color a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x8CCC1E0", Offset = "0x8CCADE0", VA = "0x188CCC1E0")]
		public Color EROXUISCUVC(int a)
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
		[Cpp2IlInjected.Address(RVA = "0x8CC0E50", Offset = "0x8CBFA50", VA = "0x188CC0E50")]
		public float UETBTOZSCMY(float a, Vector2 b, bool c)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x8CC0D60", Offset = "0x8CBF960", VA = "0x188CC0D60")]
		public Color UETBTOZSCMY(float a, float b, float c)
		{
			return default(Color);
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x8CC0EA0", Offset = "0x8CBFAA0", VA = "0x188CC0EA0")]
		public ColorRemap()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public static class EQYADFGLPXU
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
		[Cpp2IlInjected.Address(RVA = "0x8CC1080", Offset = "0x8CBFC80", VA = "0x188CC1080")]
		public static Texture2D QIOJNBAYLZR()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x8CC1280", Offset = "0x8CBFE80", VA = "0x188CC1280")]
		public static Texture2D UCUFWWEKFZT(Func<ShapeColorInfo, ColorChannel, Color, Color> a, string b = "LegacyColorTexture")
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x8CC0ED0", Offset = "0x8CBFAD0", VA = "0x188CC0ED0")]
		[CompilerGenerated]
		internal static void PKTEZQMUMXW(ShapeColorInfo a, int b, <>c__DisplayClass2_0 c)
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
		private static ZWPUZTHGFAG AYWFELIDUZO;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		private static ZWPUZTHGFAG CFYYGEXYXRX
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x8CCB130", Offset = "0x8CC9D30", VA = "0x188CCB130")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public Color Additive
		{
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x8CCBB10", Offset = "0x8CCA710", VA = "0x188CCBB10")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x8CCB600", Offset = "0x8CCA200", VA = "0x188CCB600")]
		public static ShapeColor LZOHVAMPXNC(Color a, YYDYBGNWLJU b)
		{
			return default(ShapeColor);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x8CCB510", Offset = "0x8CCA110", VA = "0x188CCB510")]
		public static ShapeColor LZOHVAMPXNC(Color a)
		{
			return default(ShapeColor);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x8CCB6D0", Offset = "0x8CCA2D0", VA = "0x188CCB6D0")]
		public static ShapeColorInfo RNHTPCWMIOM(ShapeColor a, YYDYBGNWLJU b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x8CCB910", Offset = "0x8CCA510", VA = "0x188CCB910")]
		public static ShapeColorInfo TFYCFXQNNQY(ShapeColor a, YYDYBGNWLJU b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x8CCB200", Offset = "0x8CC9E00", VA = "0x188CCB200")]
		public static bool KWVEAZEYMJY(Color a, [Out] ShapeColorInfo b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0xA9C6D0", Offset = "0xA9B2D0", VA = "0x180A9C6D0")]
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
		[Cpp2IlInjected.Address(RVA = "0x8CCBEA0", Offset = "0x8CCAAA0", VA = "0x188CCBEA0")]
		public ShapeMaterialInfo()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x8CCBE10", Offset = "0x8CCAA10", VA = "0x188CCBE10")]
		public ShapeMaterialInfo(ShapeMaterialInfo other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x8CCBDB0", Offset = "0x8CCA9B0", VA = "0x188CCBDB0")]
		public void CopyTo(ShapeMaterialInfo shapeMaterialInfo)
		{
		}
	}
}
namespace RecRoom.Core.Creation.Shapes
{
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class OIVRDZNIGVB : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private static readonly int LIKVCURTATD;

		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private static readonly int DWKGUCNDHHY;

		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private static readonly int SAOVCXFRDST;

		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private static readonly int DDZMEFWDTDL;

		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private static readonly int CMQHDNEGVGV;

		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private static readonly int LKHDCCJERUK;

		[Cpp2IlInjected.Token(Token = "0x400004D")]
		private static readonly int DLYQFUHQCXH;

		[Cpp2IlInjected.Token(Token = "0x400004E")]
		private static readonly int UGGTMLYEMCJ;

		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private static readonly int IEYQRVKWAGX;

		[Cpp2IlInjected.Token(Token = "0x4000050")]
		private static readonly int FPQEVZKXKHD;

		[Cpp2IlInjected.Token(Token = "0x4000051")]
		private static readonly int OEZMMIIQUAN;

		[Cpp2IlInjected.Token(Token = "0x4000052")]
		private static readonly int NPHFHGEOTHT;

		[Cpp2IlInjected.Token(Token = "0x4000053")]
		private static readonly int ACJYSIPHMVR;

		[Cpp2IlInjected.Token(Token = "0x4000054")]
		private static readonly int VZCGNBXNMIJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public ShapeMaterialInfo[] ECHWDPVQJDV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public Texture2DArray GWFFPWKEGOZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public Texture2DArray CAAHRKBUVEF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public float[] CLHAGSUAADM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public Texture2DArray JRGUNHAEHNZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		public float[] SQKFAKETVGM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public float[] RZZHIGHGZZZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		public float[] QXEZHRYUVUP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public Vector4[] SYLTLTBTDIV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public Texture2DArray ZJPTRMMXEXB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public float[] IIMLMPWVYZK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public float[] UCGUEFKTALZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public float[] RUWTGYAELIH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public Vector4[] MZVXKRBALEN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		private int[] CTZAYPIHIIA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public Texture2DArray LXJUFJOUIEH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public float[] INOZGPTYRQM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public Vector4[] RIOXQRWMBIX;

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x8CC7670", Offset = "0x8CC6270", VA = "0x188CC7670")]
		private Texture2DArray ESDZQMDXAXM(string a, IReadOnlyList<Texture2D> b, bool c, ShapeMaterialInfo[] d)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x8CC7C70", Offset = "0x8CC6870", VA = "0x188CC7C70")]
		public OIVRDZNIGVB(ShapeMaterialInfo[] a, bool b, bool c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x8CC7930", Offset = "0x8CC6530", VA = "0x188CC7930")]
		private Vector3 OKHXVUKEPEU(ShapeMaterialInfo a)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x8CC78E0", Offset = "0x8CC64E0", VA = "0x188CC78E0")]
		public int LNJYYOJNPAC(ShapeMaterial a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x8CC7620", Offset = "0x8CC6220", VA = "0x188CC7620", Slot = "4")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public interface KBQQSTKPLYL
	{
		[Cpp2IlInjected.Token(Token = "0x17000005")]
		bool GRVWJELIIJI
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		bool WNZORAJSMIH
		{
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		bool QBAPNNZXIHK
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public interface VDOVAFZQOIW : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x17000008")]
		Texture2D OPSRYLLNYJO
		{
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(Slot = "1")]
		Material XKQEUTBYVPQ();

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(Slot = "2")]
		int CWUWPOWIVBQ(ShapeColor a);

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(Slot = "3")]
		int LNJYYOJNPAC(ShapeMaterial a);

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void KWGBXCDMIPE(Material a);

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(Slot = "5")]
		OEZUSSOJXPU[] KSYOSSFRDRQ();
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public interface ZWPUZTHGFAG
	{
		[Cpp2IlInjected.Token(Token = "0x17000009")]
		ColorRemap XAMTJTLZWZJ
		{
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		ColorRemap NWMPXDQPABH
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(Slot = "0")]
		ShapeColorInfo NEDXVOYIFTT(ShapeColor a, bool b = true);

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		bool SSXBYUZQLXV(ShapeColor a, [Out] Color b);
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public static class JXHTCPJGUGF
	{
		[Cpp2IlInjected.Token(Token = "0x2000012")]
		private class SMYIJWQEMHQ : VDOVAFZQOIW, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400007F")]
			public OIVRDZNIGVB BDEUEQDQTCB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000080")]
			private readonly Texture2D CCERGBBNWNL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000081")]
			private bool KHZKIXVTREK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
			[Cpp2IlInjected.Token(Token = "0x4000082")]
			private bool TDXWJANOBTJ;

			[Cpp2IlInjected.Token(Token = "0x4000083")]
			private static OEZUSSOJXPU[] CEFJLUNIWKF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000084")]
			private Texture2D JGFOBCMPWUY;

			[Cpp2IlInjected.Token(Token = "0x1700000B")]
			public Texture2D OPSRYLLNYJO
			{
				[Cpp2IlInjected.Token(Token = "0x6000034")]
				[Cpp2IlInjected.Address(RVA = "0x8CC9540", Offset = "0x8CC8140", VA = "0x188CC9540", Slot = "4")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x8CCAF60", Offset = "0x8CC9B60", VA = "0x188CCAF60")]
			public SMYIJWQEMHQ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x8CC97B0", Offset = "0x8CC83B0", VA = "0x188CC97B0")]
			private Color HOVSVHVIISW(ShapeColorInfo a, EQYADFGLPXU.ColorChannel b, Color c)
			{
				return default(Color);
			}

			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x8CC94C0", Offset = "0x8CC80C0", VA = "0x188CC94C0", Slot = "10")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x8CC9EF0", Offset = "0x8CC8AF0", VA = "0x188CC9EF0", Slot = "5")]
			public Material XKQEUTBYVPQ()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x8CC9FF0", Offset = "0x8CC8BF0", VA = "0x188CC9FF0")]
			private void YFWDWIPLHKM(Texture2D a, bool b, bool c)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x8CC98D0", Offset = "0x8CC84D0", VA = "0x188CC98D0", Slot = "9")]
			public OEZUSSOJXPU[] KSYOSSFRDRQ()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x8CC9910", Offset = "0x8CC8510", VA = "0x188CC9910", Slot = "8")]
			public void KWGBXCDMIPE(Material a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x8CC93A0", Offset = "0x8CC7FA0", VA = "0x188CC93A0", Slot = "6")]
			public int CWUWPOWIVBQ(ShapeColor a)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x8CC9EA0", Offset = "0x8CC8AA0", VA = "0x188CC9EA0", Slot = "7")]
			public int LNJYYOJNPAC(ShapeMaterial a)
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
			[Cpp2IlInjected.Address(RVA = "0x8CC6E50", Offset = "0x8CC5A50", VA = "0x188CC6E50", Slot = "4")]
			public bool Equals(MaterialHash other)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x8CC6D90", Offset = "0x8CC5990", VA = "0x188CC6D90", Slot = "0")]
			public override bool Equals(object obj)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x8CC7040", Offset = "0x8CC5C40", VA = "0x188CC7040", Slot = "2")]
			public override int GetHashCode()
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000067")]
		private static Dictionary<MaterialHash, Material> CEPAGRPVIQX;

		[Cpp2IlInjected.Token(Token = "0x4000068")]
		private static readonly int FZUUWYUMONW;

		[Cpp2IlInjected.Token(Token = "0x4000069")]
		private static readonly int SJJMMJFJOVU;

		[Cpp2IlInjected.Token(Token = "0x400006A")]
		private static readonly int LIHULRYTNPQ;

		[Cpp2IlInjected.Token(Token = "0x400006B")]
		private static readonly int UTKDFFRTGTT;

		[Cpp2IlInjected.Token(Token = "0x400006C")]
		private static readonly int VXTQEDYIHFR;

		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private static readonly int CXWDXNZEPZM;

		[Cpp2IlInjected.Token(Token = "0x400006E")]
		private static readonly int LVEBOJXJYVZ;

		[Cpp2IlInjected.Token(Token = "0x400006F")]
		private static readonly int YSOQARHEFXG;

		[Cpp2IlInjected.Token(Token = "0x4000070")]
		private static readonly int EQYQXIIIFBF;

		[Cpp2IlInjected.Token(Token = "0x4000071")]
		private static readonly int GKDKXMSNORI;

		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private static readonly int JMLISFGCKTQ;

		[Cpp2IlInjected.Token(Token = "0x4000073")]
		private static readonly int ZMUREWSYTKK;

		[Cpp2IlInjected.Token(Token = "0x4000074")]
		private static readonly int DNAUQZBVDPQ;

		[Cpp2IlInjected.Token(Token = "0x4000075")]
		private static readonly int KICYOTNZQKU;

		[Cpp2IlInjected.Token(Token = "0x4000076")]
		private static readonly int TYIWSKIRLHU;

		[Cpp2IlInjected.Token(Token = "0x4000077")]
		private static readonly int VPQBSFBJGDA;

		[Cpp2IlInjected.Token(Token = "0x4000078")]
		private static readonly int ZDQBIWNHWVA;

		[Cpp2IlInjected.Token(Token = "0x4000079")]
		private static readonly int KYYFYXAQYZY;

		[Cpp2IlInjected.Token(Token = "0x400007A")]
		private static readonly int MAZQDRHMJSA;

		[Cpp2IlInjected.Token(Token = "0x400007B")]
		private static readonly int VDWDQAQXSYG;

		[Cpp2IlInjected.Token(Token = "0x400007C")]
		private static readonly int MKSKGCKRAWZ;

		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public static readonly int CMQHDNEGVGV;

		[Cpp2IlInjected.Token(Token = "0x400007E")]
		public static readonly int RQWAZPVKSCC;

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x8CC6870", Offset = "0x8CC5470", VA = "0x188CC6870")]
		[RRPostPlayModeMethod(PostPlayModePhase.ExitingPlayMode, 0)]
		private static void ZSDLYAMPTNN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x8CC6330", Offset = "0x8CC4F30", VA = "0x188CC6330")]
		private static KBQQSTKPLYL LQMCRGANDYW()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x8CC6670", Offset = "0x8CC5270", VA = "0x188CC6670")]
		public static VDOVAFZQOIW WNTYQIPAWDC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x8CC6260", Offset = "0x8CC4E60", VA = "0x188CC6260")]
		public static void AXTZXSPEEIE(this Material a, ShapeColor b, ShapeMaterial c, bool d, bool e, float f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x8CC5CA0", Offset = "0x8CC48A0", VA = "0x188CC5CA0")]
		public static void AXTZXSPEEIE(this Material a, ShapeColorInfo b, ShapeMaterialInfo c, bool d, bool e, float f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x8CC63A0", Offset = "0x8CC4FA0", VA = "0x188CC63A0")]
		public static Material WKXRGFFOWBM(ShapeColorInfo a, ShapeMaterialInfo b, bool c, bool d)
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
				[Cpp2IlInjected.Address(RVA = "0x8CC6D50", Offset = "0x8CC5950", VA = "0x188CC6D50")]
				public KeyVal()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x8CCBC10", Offset = "0x8CCA810", VA = "0x188CCBC10")]
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
		protected override bool GFTQHYKYTME
		{
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0xAE0370", Offset = "0xADEF70", VA = "0x180AE0370", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x8CCBC50", Offset = "0x8CCA850", VA = "0x188CCBC50")]
		public ShapeConfig()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public static class SDNWADJIPZH
	{
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		public static readonly ShapeType[] YUMZLBVNLUS;

		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		public static readonly int[] LEBBPGAKLSH;

		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		public static readonly PrimitiveShapeMeshType[] MIMWPMTRTIP;

		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		private static readonly Dictionary<ShapeType, int> LUINKLOJZNH;

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x8CC8EC0", Offset = "0x8CC7AC0", VA = "0x188CC8EC0")]
		private static Dictionary<ShapeType, int> YOAGIJHFEPG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x8CC8E50", Offset = "0x8CC7A50", VA = "0x188CC8E50")]
		public static PrimitiveShapeMeshType TRCITEPKDBU(this ShapeType a)
		{
			return default(PrimitiveShapeMeshType);
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x8CC8D40", Offset = "0x8CC7940", VA = "0x188CC8D40")]
		public static int DAZWTHTFSSZ(this ShapeType a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x8CC8DB0", Offset = "0x8CC79B0", VA = "0x188CC8DB0")]
		public static int JJZVDVQZJTS(this ShapeType a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x13A27A0", Offset = "0x13A13A0", VA = "0x1813A27A0")]
		public static bool MXAXBEZKKAP(this ShapeType a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x84331F0", Offset = "0x8431DF0", VA = "0x1884331F0")]
		public static bool TFFPFWFPLHZ(this ShapeType a)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	public class RASDZFXTRJN : ZWPUZTHGFAG
	{
		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public ColorRemap XAMTJTLZWZJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x8CC89B0", Offset = "0x8CC75B0", VA = "0x188CC89B0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public ColorRemap NWMPXDQPABH
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x8CC8A60", Offset = "0x8CC7660", VA = "0x188CC8A60", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0xA9C6D0", Offset = "0xA9B2D0", VA = "0x180A9C6D0")]
		[UnityEngine.Scripting.Preserve]
		internal RASDZFXTRJN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x8CC8B10", Offset = "0x8CC7710", VA = "0x188CC8B10")]
		[YLZSHGPPZTN.Root]
		internal static void IGQDZAZABEW(URVRSSRGCJF a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x8CC8C00", Offset = "0x8CC7800", VA = "0x188CC8C00", Slot = "4")]
		public ShapeColorInfo NEDXVOYIFTT(ShapeColor a, bool b = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x8CC8C60", Offset = "0x8CC7860", VA = "0x188CC8C60", Slot = "5")]
		public bool SSXBYUZQLXV(ShapeColor a, [Out] Color b)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public static class IODRGXDJJLD
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
		public static ANFWHCNXABV DZEORAHFFLQ;

		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		private static Material XIBSEKELAHV;

		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		private static Material SBHGFKKWANB;

		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		private static bool NPMRXVXMJZZ;

		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		private static VDOVAFZQOIW NVEZAIMWRHA;

		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		private static readonly CollisionMeshData[] NDPAGEJRQIR;

		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		private static CollisionMeshData PGFPOQPYJNR;

		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		private static int[] JYURYKVPYXA;

		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		private static int[] ZHNHCJYVWWK;

		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		private static readonly OROBRNYNQJG<ShapeColor, ShapeColorInfo> QUAXCBCZVXA;

		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		public static readonly Dictionary<string, EnumChoiceData> NSJRHRLSPAG;

		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		public static readonly Dictionary<int, string> NSEKKKRVFOX;

		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		private static readonly Vector3[] KFXVULBBNCX;

		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		public static readonly Dictionary<string, EnumChoiceData> LYUQNPEAJWB;

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public static ShapeConfig MIMEWTHLZJF
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x8CC45A0", Offset = "0x8CC31A0", VA = "0x188CC45A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		private static VDOVAFZQOIW WMTXKBNAGEP
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x8CC32D0", Offset = "0x8CC1ED0", VA = "0x188CC32D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public static Texture2D OPSRYLLNYJO
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x8CC2120", Offset = "0x8CC0D20", VA = "0x188CC2120")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public static ColorRemap XAMTJTLZWZJ
		{
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x8CC19B0", Offset = "0x8CC05B0", VA = "0x188CC19B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public static ColorRemap NWMPXDQPABH
		{
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0x8CC2200", Offset = "0x8CC0E00", VA = "0x188CC2200")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public static ShapeColorInfo[] RCGSEQVXFOI
		{
			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x8CC3250", Offset = "0x8CC1E50", VA = "0x188CC3250")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public static ShapeMaterialInfo[] PJEGMWVTBJQ
		{
			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x8CC1930", Offset = "0x8CC0530", VA = "0x188CC1930")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public static int DMYEJOLGBSY
		{
			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0x1C24B50", Offset = "0x1C23750", VA = "0x181C24B50")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		private static int[] NIEQUZQNXKN
		{
			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0x8CC47C0", Offset = "0x8CC33C0", VA = "0x188CC47C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		private static int[] LCAMGQGDOTJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0x8CC3C50", Offset = "0x8CC2850", VA = "0x188CC3C50")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public static Shader GDWQYFGQRAC
		{
			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x8CC31D0", Offset = "0x8CC1DD0", VA = "0x188CC31D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public static Material GUVRVRWWNRS
		{
			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x8CC2FC0", Offset = "0x8CC1BC0", VA = "0x188CC2FC0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x8CC27C0", Offset = "0x8CC13C0", VA = "0x188CC27C0")]
		private static void HMPBXZLOHLU(Scene a, LoadSceneMode b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x8CC3840", Offset = "0x8CC2440", VA = "0x188CC3840")]
		public static GameObject ONVRZKTTHQI(ShapeType a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x8CC3B70", Offset = "0x8CC2770", VA = "0x188CC3B70")]
		public static GameObject PXHKCJWCGJO(ShapeType a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x8CC2C40", Offset = "0x8CC1840", VA = "0x188CC2C40")]
		private static Mesh JJPWAIQPLOT(ShapeType a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x8CC4ED0", Offset = "0x8CC3AD0", VA = "0x188CC4ED0")]
		public static bool XVYRAGYKCVQ(ShapeType a, [Out] Mesh b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x8CC38E0", Offset = "0x8CC24E0", VA = "0x188CC38E0")]
		private static void PULTMGKJJQJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x8CC1860", Offset = "0x8CC0460", VA = "0x188CC1860")]
		public static Material BMBASGOGCRF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x8CC4A50", Offset = "0x8CC3650", VA = "0x188CC4A50")]
		public static Material WWBNEXSBIUJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x8CC3690", Offset = "0x8CC2290", VA = "0x188CC3690")]
		public static Vector3 NKRQIGREBDF(Vector3 a, Quaternion b, ShapeMaterial c)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x8CC2280", Offset = "0x8CC0E80", VA = "0x188CC2280")]
		private static Vector3 GEFRTFTZPJJ(Vector3 a, Quaternion b, ShapeMaterial c, bool d)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x8CC1A30", Offset = "0x8CC0630", VA = "0x188CC1A30")]
		public static void CHMEJOMDOFO(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x8CC1C80", Offset = "0x8CC0880", VA = "0x188CC1C80")]
		public static int CWUWPOWIVBQ(ShapeColor a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x8CC3150", Offset = "0x8CC1D50", VA = "0x188CC3150")]
		public static int LNJYYOJNPAC(ShapeMaterial a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x8CC3040", Offset = "0x8CC1C40", VA = "0x188CC3040")]
		[RRPostPlayModeMethod(PostPlayModePhase.ExitingPlayMode, 0)]
		private static void LCKOPUHKYPT()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x8CC5280", Offset = "0x8CC3E80", VA = "0x188CC5280")]
		public static CollisionMeshData ZPOANTHSNCD(ShapeType a)
		{
			return default(CollisionMeshData);
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x8CC2840", Offset = "0x8CC1440", VA = "0x188CC2840")]
		public static CollisionMeshData HOQINTJPXSJ()
		{
			return default(CollisionMeshData);
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x8CC1BE0", Offset = "0x8CC07E0", VA = "0x188CC1BE0")]
		public static string COQJAVURGGN(ShapeType a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x8CC46A0", Offset = "0x8CC32A0", VA = "0x188CC46A0")]
		public static Bounds VLQRKLANBHR(ShapeType a)
		{
			return default(Bounds);
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x8CC43F0", Offset = "0x8CC2FF0", VA = "0x188CC43F0")]
		public static int UQCYYRFQLDG(ShapeType a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x8CC3EE0", Offset = "0x8CC2AE0", VA = "0x188CC3EE0")]
		public static bool SSXBYUZQLXV(ShapeColor a, [Out] Color b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x8CC3C10", Offset = "0x8CC2810", VA = "0x188CC3C10")]
		public static int QXKGGWXNHFY(int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x8CC3C30", Offset = "0x8CC2830", VA = "0x188CC3C30")]
		public static int QZWLGHOSXVV(int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x8CC4E60", Offset = "0x8CC3A60", VA = "0x188CC4E60")]
		public static Color XDEHTSVYYZJ(ShapeColor a)
		{
			return default(Color);
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x8CC3130", Offset = "0x8CC1D30", VA = "0x188CC3130")]
		public static bool LDKXXVEEPHG(ShapeType a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x8CC45D0", Offset = "0x8CC31D0", VA = "0x188CC45D0")]
		public static int VBAFZHPEMDO(ShapeType a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x8CC3370", Offset = "0x8CC1F70", VA = "0x188CC3370")]
		[NotNull]
		public static ShapeColorInfo NEDXVOYIFTT(ShapeColor a, bool b = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x8CC17C0", Offset = "0x8CC03C0", VA = "0x188CC17C0")]
		public static ShapeMaterialInfo ANNDCTJSJBV(ShapeMaterial a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x8CC1F20", Offset = "0x8CC0B20", VA = "0x188CC1F20")]
		public static float DYKSIGQUNGW(int a)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x8CC25D0", Offset = "0x8CC11D0", VA = "0x188CC25D0")]
		public static int GGKDHNKTVHU(int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x8CC2DE0", Offset = "0x8CC19E0", VA = "0x188CC2DE0")]
		public static int KBQWGZFTTHQ(int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x8CC2B60", Offset = "0x8CC1760", VA = "0x188CC2B60")]
		public static Vector3 IQOKQNFBQHU(ShapeType a)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x8CC1D00", Offset = "0x8CC0900", VA = "0x188CC1D00")]
		public static float DXSRJRJNZTV(ShapeType a, Vector3 b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x8CC4FB0", Offset = "0x8CC3BB0", VA = "0x188CC4FB0")]
		public static void XYNEGADJMVC(bool a = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x8CC2920", Offset = "0x8CC1520", VA = "0x188CC2920")]
		private static void HTTIQRWECNZ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x8CC3F90", Offset = "0x8CC2B90", VA = "0x188CC3F90")]
		public static void ULWAOKWEAYZ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x8CC4B20", Offset = "0x8CC3720", VA = "0x188CC4B20")]
		public static void WXKIGIZDTUY()
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
