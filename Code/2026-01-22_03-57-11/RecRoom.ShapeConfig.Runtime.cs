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
		[Cpp2IlInjected.Address(RVA = "0x8DF71D0", Offset = "0x8DF59D0", VA = "0x188DF71D0", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x275D1F0", Offset = "0x275B9F0", VA = "0x18275D1F0")]
		public _AssemblyIndex()
		{
		}
	}
}
namespace RecRoom
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public static class ICLYNNVUOAQ
	{
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public static readonly int OMWNXWFEIRR;

		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public static readonly int RMAABWKVSIK;

		[Cpp2IlInjected.Token(Token = "0x4000003")]
		public static readonly int LHZBLAMIEFY;

		[Cpp2IlInjected.Token(Token = "0x4000004")]
		public static readonly int CHZGLXPZKBS;

		[Cpp2IlInjected.Token(Token = "0x4000005")]
		public static readonly int ZRUEWAGJWXI;

		[Cpp2IlInjected.Token(Token = "0x4000006")]
		public static readonly int KFBLRXYKCJM;

		[Cpp2IlInjected.Token(Token = "0x4000007")]
		public static readonly int QZCUHGJNFZI;

		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public static readonly int JWWGLHWXSJG;

		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public static readonly int SKAUTWTGVYZ;

		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public static readonly int XLTMIKVWPUU;

		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public static readonly int TNXROMMPYJG;

		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public static readonly int BBEVPKRYWDC;

		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public static readonly int FUIZSRWKNHU;

		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public static readonly int FKOZWSCOYYK;

		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public static readonly int LQYQNZTJAQY;

		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public static readonly int EHLHCQDYRLN;

		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public static readonly int WMWKGHJKPCB;

		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public static readonly int YYBXMAZRQVB;

		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public static readonly int JWZPARDDDLB;

		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public static readonly int BLRMHVWENAB;

		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public static readonly int DNUDKUTDAWS;

		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public static readonly int UFGJMLONKFJ;

		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public static readonly int QVVLXYQJDNF;

		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public static readonly int MBNDCCXTGHC;

		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public static readonly int PDMTOYEJMQV;

		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public static readonly int SKOXLGBTFES;

		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public static readonly int NYHNADULZIS;

		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public static readonly int IJZSFIXNHJF;
	}
}
namespace RecRoom.Core.Creation
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public class XCPAEOSMKWK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public readonly int WRAPLMGKAWN;

		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private static XCPAEOSMKWK FZEUPPXOIQM;

		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private static XCPAEOSMKWK CFNSGVPMVXP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private readonly int XZCOGZFOLQL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private readonly int YBIMCVQLLLG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private readonly int YCIUPDLYGPZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private readonly float ZWAUNKDGQAA;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public static XCPAEOSMKWK VIMBDQSHPDH
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x8DF49E0", Offset = "0x8DF31E0", VA = "0x188DF49E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public static XCPAEOSMKWK CJTPUIWTVZW
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x8DF47F0", Offset = "0x8DF2FF0", VA = "0x188DF47F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x8DF4A90", Offset = "0x8DF3290", VA = "0x188DF4A90")]
		public XCPAEOSMKWK(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x8DF4900", Offset = "0x8DF3100", VA = "0x188DF4900")]
		public int WCLMKLQLMKU(Color a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x8DF4890", Offset = "0x8DF3090", VA = "0x188DF4890")]
		public Color INSUNUGKNRC(int a)
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
		[Cpp2IlInjected.Address(RVA = "0x8DEBE00", Offset = "0x8DEA600", VA = "0x188DEBE00")]
		public float KOEFOMHNJIY(float a, Vector2 b, bool c)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x8DEBE50", Offset = "0x8DEA650", VA = "0x188DEBE50")]
		public Color KOEFOMHNJIY(float a, float b, float c)
		{
			return default(Color);
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x8DEBF40", Offset = "0x8DEA740", VA = "0x188DEBF40")]
		public ColorRemap()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public static class IVSIMLKPNLA
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
		[Cpp2IlInjected.Address(RVA = "0x8DECA40", Offset = "0x8DEB240", VA = "0x188DECA40")]
		public static Texture2D FSQVNIDQMRZ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x8DECC40", Offset = "0x8DEB440", VA = "0x188DECC40")]
		public static Texture2D HEWPJOYNNMJ(Func<ShapeColorInfo, ColorChannel, Color, Color> a, string b = "LegacyColorTexture")
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x8DED180", Offset = "0x8DEB980", VA = "0x188DED180")]
		[CompilerGenerated]
		internal static void HHSQSNOJYYY(ShapeColorInfo a, int b, <>c__DisplayClass2_0 c)
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
		private static ROICWQCFUIG HTKKAMWTHRO;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		private static ROICWQCFUIG MNFSRVNRPXP
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x8DF21E0", Offset = "0x8DF09E0", VA = "0x188DF21E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public Color Additive
		{
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x8DF24A0", Offset = "0x8DF0CA0", VA = "0x188DF24A0")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x8DF1AD0", Offset = "0x8DF02D0", VA = "0x188DF1AD0")]
		public static ShapeColor BBRWJOCAOVS(Color a, XCPAEOSMKWK b)
		{
			return default(ShapeColor);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x8DF1BA0", Offset = "0x8DF03A0", VA = "0x188DF1BA0")]
		public static ShapeColor BBRWJOCAOVS(Color a)
		{
			return default(ShapeColor);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x8DF1FA0", Offset = "0x8DF07A0", VA = "0x188DF1FA0")]
		public static ShapeColorInfo TGNWSGGIAXO(ShapeColor a, XCPAEOSMKWK b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x8DF22A0", Offset = "0x8DF0AA0", VA = "0x188DF22A0")]
		public static ShapeColorInfo YQEKVOVPTOI(ShapeColor a, XCPAEOSMKWK b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x8DF1C90", Offset = "0x8DF0490", VA = "0x188DF1C90")]
		public static bool PQTSGMCBMJU(Color a, [Out] ShapeColorInfo b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0xAB5950", Offset = "0xAB4150", VA = "0x180AB5950")]
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
		[Cpp2IlInjected.Address(RVA = "0x8DF2830", Offset = "0x8DF1030", VA = "0x188DF2830")]
		public ShapeMaterialInfo()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x8DF27A0", Offset = "0x8DF0FA0", VA = "0x188DF27A0")]
		public ShapeMaterialInfo(ShapeMaterialInfo other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x8DF2740", Offset = "0x8DF0F40", VA = "0x188DF2740")]
		public void CopyTo(ShapeMaterialInfo shapeMaterialInfo)
		{
		}
	}
}
namespace RecRoom.Core.Creation.Shapes
{
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class YDKYRIZIQST : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private static readonly int SMYHHAATUYN;

		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private static readonly int ZCGDMSXUTYK;

		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private static readonly int DQFYUBFNLZZ;

		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private static readonly int RCOGEPCXDBT;

		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private static readonly int HZUCSRQXRHX;

		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private static readonly int PTPXVGBKGAK;

		[Cpp2IlInjected.Token(Token = "0x400004D")]
		private static readonly int VHLTYDGIXOR;

		[Cpp2IlInjected.Token(Token = "0x400004E")]
		private static readonly int GOBGRYTYZIN;

		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private static readonly int LABDQAXPEDB;

		[Cpp2IlInjected.Token(Token = "0x4000050")]
		private static readonly int YLEWHPTYXRP;

		[Cpp2IlInjected.Token(Token = "0x4000051")]
		private static readonly int VPQKQTLDCOV;

		[Cpp2IlInjected.Token(Token = "0x4000052")]
		private static readonly int PEKGYVUXZEV;

		[Cpp2IlInjected.Token(Token = "0x4000053")]
		private static readonly int OKCWSXTASAH;

		[Cpp2IlInjected.Token(Token = "0x4000054")]
		private static readonly int MLDZMARDWPH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public ShapeMaterialInfo[] TKXPTXCJBEH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public Texture2DArray XVGHEMXYBYF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public Texture2DArray HXGXJCEAZAR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public float[] XHWGWDIEIQG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public Texture2DArray BTGMXTRGSLF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		public float[] HMHTIUDSCRO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public float[] FVDSGLNTIUL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		public float[] XZDRHWQCWPR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public Vector4[] UZGRVJDJJVX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public Texture2DArray NHNQRIAGTZN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public float[] DLWBQNYNIRG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public float[] NQNPTFPGCJB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public float[] LCUCYRSOACD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public Vector4[] YFJPPWJLTFH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		private int[] HDPAXOIBGKA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public Texture2DArray ENOISCCQBIX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public float[] SEQCQPYXMEU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public Vector4[] GBTVGWTMEEP;

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x8DF4BF0", Offset = "0x8DF33F0", VA = "0x188DF4BF0")]
		private Texture2DArray SDADBCLNLPM(string a, IReadOnlyList<Texture2D> b, bool c, ShapeMaterialInfo[] d)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x8DF5110", Offset = "0x8DF3910", VA = "0x188DF5110")]
		public YDKYRIZIQST(ShapeMaterialInfo[] a, bool b, bool c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x8DF4B40", Offset = "0x8DF3340", VA = "0x188DF4B40")]
		private Vector3 GCVWCLSPXAA(ShapeMaterialInfo a)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x8DF4E60", Offset = "0x8DF3660", VA = "0x188DF4E60")]
		public int ZXXJLIBRJCC(ShapeMaterial a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x8DF4AF0", Offset = "0x8DF32F0", VA = "0x188DF4AF0", Slot = "4")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public interface QZFSSTKAYPN
	{
		[Cpp2IlInjected.Token(Token = "0x17000005")]
		bool JQPPKDVQOPI
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		bool KDGVWGCENAH
		{
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		bool DLBHEGPZKMM
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public interface WGJMOXIQYYS : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x17000008")]
		Texture2D FGAWDJGNCME
		{
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(Slot = "1")]
		Material YALOPYWNOYO();

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(Slot = "2")]
		int EMCPTOVIEDM(ShapeColor a);

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(Slot = "3")]
		int ZXXJLIBRJCC(ShapeMaterial a);

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void IEBTSKQTKCS(Material a);

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(Slot = "5")]
		PBEGJBLTWBY[] XGJQFBFFOJY();
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public interface ROICWQCFUIG
	{
		[Cpp2IlInjected.Token(Token = "0x17000009")]
		ColorRemap BYWDCHLOVJJ
		{
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		ColorRemap ABWLTKILMWR
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(Slot = "0")]
		ShapeColorInfo XGNIEESUSWN(ShapeColor a, bool b = true);

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		bool GGRRDZHJWKP(ShapeColor a, [Out] Color b);
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public static class ZWSEIQSJXZX
	{
		[Cpp2IlInjected.Token(Token = "0x2000012")]
		private class UAGOQUJGFTA : WGJMOXIQYYS, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400007F")]
			public YDKYRIZIQST XYBATLMLPJP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000080")]
			private readonly Texture2D CKGWFDAUCNH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000081")]
			private bool SMCSMRCLCIK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
			[Cpp2IlInjected.Token(Token = "0x4000082")]
			private bool NWYVOTLQQKL;

			[Cpp2IlInjected.Token(Token = "0x4000083")]
			private static PBEGJBLTWBY[] NDJNOETPBFP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000084")]
			private Texture2D UXQBRXUIBXS;

			[Cpp2IlInjected.Token(Token = "0x1700000B")]
			public Texture2D FGAWDJGNCME
			{
				[Cpp2IlInjected.Token(Token = "0x6000034")]
				[Cpp2IlInjected.Address(RVA = "0x8DF2AC0", Offset = "0x8DF12C0", VA = "0x188DF2AC0", Slot = "4")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x8DF4620", Offset = "0x8DF2E20", VA = "0x188DF4620")]
			public UAGOQUJGFTA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x8DF4370", Offset = "0x8DF2B70", VA = "0x188DF4370")]
			private Color SVHTMRJLAOS(ShapeColorInfo a, IVSIMLKPNLA.ColorChannel b, Color c)
			{
				return default(Color);
			}

			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x8DF2D30", Offset = "0x8DF1530", VA = "0x188DF2D30", Slot = "10")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x8DF44D0", Offset = "0x8DF2CD0", VA = "0x188DF44D0", Slot = "5")]
			public Material YALOPYWNOYO()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x8DF3430", Offset = "0x8DF1C30", VA = "0x188DF3430")]
			private void RFKLNCWYHQE(Texture2D a, bool b, bool c)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x8DF4490", Offset = "0x8DF2C90", VA = "0x188DF4490", Slot = "9")]
			public PBEGJBLTWBY[] XGJQFBFFOJY()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x8DF2ED0", Offset = "0x8DF16D0", VA = "0x188DF2ED0", Slot = "8")]
			public void IEBTSKQTKCS(Material a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x8DF2DB0", Offset = "0x8DF15B0", VA = "0x188DF2DB0", Slot = "6")]
			public int EMCPTOVIEDM(ShapeColor a)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x8DF45D0", Offset = "0x8DF2DD0", VA = "0x188DF45D0", Slot = "7")]
			public int ZXXJLIBRJCC(ShapeMaterial a)
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
			[Cpp2IlInjected.Address(RVA = "0x8DED430", Offset = "0x8DEBC30", VA = "0x188DED430", Slot = "4")]
			public bool Equals(MaterialHash other)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x8DED370", Offset = "0x8DEBB70", VA = "0x188DED370", Slot = "0")]
			public override bool Equals(object obj)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x8DED620", Offset = "0x8DEBE20", VA = "0x188DED620", Slot = "2")]
			public override int GetHashCode()
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000067")]
		private static Dictionary<MaterialHash, Material> HXLNQCJZVRV;

		[Cpp2IlInjected.Token(Token = "0x4000068")]
		private static readonly int DGRBHQHGKAE;

		[Cpp2IlInjected.Token(Token = "0x4000069")]
		private static readonly int PTXIVYZYNCS;

		[Cpp2IlInjected.Token(Token = "0x400006A")]
		private static readonly int PPMXGUFUWDI;

		[Cpp2IlInjected.Token(Token = "0x400006B")]
		private static readonly int AZXYSNFQWGZ;

		[Cpp2IlInjected.Token(Token = "0x400006C")]
		private static readonly int CWPIEQXCOCX;

		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private static readonly int FZLRSQMXYJE;

		[Cpp2IlInjected.Token(Token = "0x400006E")]
		private static readonly int LTFLQNOYWMP;

		[Cpp2IlInjected.Token(Token = "0x400006F")]
		private static readonly int LLZMODHHAWA;

		[Cpp2IlInjected.Token(Token = "0x4000070")]
		private static readonly int RWBGNYZZXJR;

		[Cpp2IlInjected.Token(Token = "0x4000071")]
		private static readonly int LRXPUMFDTAK;

		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private static readonly int MDBTIJQNJFU;

		[Cpp2IlInjected.Token(Token = "0x4000073")]
		private static readonly int LEIZBPBDMUW;

		[Cpp2IlInjected.Token(Token = "0x4000074")]
		private static readonly int PDRILALOVYC;

		[Cpp2IlInjected.Token(Token = "0x4000075")]
		private static readonly int CLTVGSJMRGM;

		[Cpp2IlInjected.Token(Token = "0x4000076")]
		private static readonly int SLEXPROUHEO;

		[Cpp2IlInjected.Token(Token = "0x4000077")]
		private static readonly int EYVJXEHQXLQ;

		[Cpp2IlInjected.Token(Token = "0x4000078")]
		private static readonly int EZMEWCNDDYK;

		[Cpp2IlInjected.Token(Token = "0x4000079")]
		private static readonly int JBGHBQVOACK;

		[Cpp2IlInjected.Token(Token = "0x400007A")]
		private static readonly int SMKLDLZIHZO;

		[Cpp2IlInjected.Token(Token = "0x400007B")]
		private static readonly int CBSHSYJKTXY;

		[Cpp2IlInjected.Token(Token = "0x400007C")]
		private static readonly int RDVESXHOLOB;

		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public static readonly int HZUCSRQXRHX;

		[Cpp2IlInjected.Token(Token = "0x400007E")]
		public static readonly int LWEJFFFVOTE;

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x8DF6A80", Offset = "0x8DF5280", VA = "0x188DF6A80")]
		[RRPostPlayModeMethod(PostPlayModePhase.ExitingPlayMode, 0)]
		private static void VVRCEJCRSAX()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x8DF61B0", Offset = "0x8DF49B0", VA = "0x188DF61B0")]
		private static QZFSSTKAYPN FVZWGMIHNSW()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x8DF6880", Offset = "0x8DF5080", VA = "0x188DF6880")]
		public static WGJMOXIQYYS NWVCQJELRBO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x8DF6220", Offset = "0x8DF4A20", VA = "0x188DF6220")]
		public static void GYXEHRERVAM(this Material a, ShapeColor b, ShapeMaterial c, bool d, bool e, float f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x8DF62F0", Offset = "0x8DF4AF0", VA = "0x188DF62F0")]
		public static void GYXEHRERVAM(this Material a, ShapeColorInfo b, ShapeMaterialInfo c, bool d, bool e, float f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x8DF6AF0", Offset = "0x8DF52F0", VA = "0x188DF6AF0")]
		public static Material YNSYCHYLEBI(ShapeColorInfo a, ShapeMaterialInfo b, bool c, bool d)
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
				[Cpp2IlInjected.Address(RVA = "0x8DED330", Offset = "0x8DEBB30", VA = "0x188DED330")]
				public KeyVal()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x8DF25A0", Offset = "0x8DF0DA0", VA = "0x188DF25A0")]
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
		protected override bool XFIEYTXTJSU
		{
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0xAF7B10", Offset = "0xAF6310", VA = "0x180AF7B10", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x8DF25E0", Offset = "0x8DF0DE0", VA = "0x188DF25E0")]
		public ShapeConfig()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public static class HYDGTEORYDD
	{
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		public static readonly ShapeType[] ZEBIRZOIBCS;

		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		public static readonly int[] UHLXBCGWOZJ;

		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		public static readonly PrimitiveShapeMeshType[] TGAGQSSQFFJ;

		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		private static readonly Dictionary<ShapeType, int> TDQOKTQNTQN;

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x8DEBFE0", Offset = "0x8DEA7E0", VA = "0x188DEBFE0")]
		private static Dictionary<ShapeType, int> NGYIEZHUBWQ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x8DEC230", Offset = "0x8DEAA30", VA = "0x188DEC230")]
		public static PrimitiveShapeMeshType WVKZDKGENAS(this ShapeType a)
		{
			return default(PrimitiveShapeMeshType);
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x8DEBF70", Offset = "0x8DEA770", VA = "0x188DEBF70")]
		public static int FNRMVUGGBWZ(this ShapeType a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x8DEC190", Offset = "0x8DEA990", VA = "0x188DEC190")]
		public static int NYSNLPQKENG(this ShapeType a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x1405520", Offset = "0x1403D20", VA = "0x181405520")]
		public static bool UJEAMVDFXGL(this ShapeType a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x8563EC0", Offset = "0x85626C0", VA = "0x188563EC0")]
		public static bool QPUADDAYKLR(this ShapeType a)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	public class YOTTSRJBJXV : ROICWQCFUIG
	{
		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public ColorRemap BYWDCHLOVJJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x8DF5E20", Offset = "0x8DF4620", VA = "0x188DF5E20", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public ColorRemap ABWLTKILMWR
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x8DF5FB0", Offset = "0x8DF47B0", VA = "0x188DF5FB0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0xAB5950", Offset = "0xAB4150", VA = "0x180AB5950")]
		[UnityEngine.Scripting.Preserve]
		internal YOTTSRJBJXV()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x8DF60C0", Offset = "0x8DF48C0", VA = "0x188DF60C0")]
		[SLGIUIECCXF.Root]
		internal static void XTVZYIQGOEG(MUPQGBSCKZR a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x8DF6060", Offset = "0x8DF4860", VA = "0x188DF6060", Slot = "4")]
		public ShapeColorInfo XGNIEESUSWN(ShapeColor a, bool b = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x8DF5ED0", Offset = "0x8DF46D0", VA = "0x188DF5ED0", Slot = "5")]
		public bool GGRRDZHJWKP(ShapeColor a, [Out] Color b)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public static class QRLMVAOWFCB
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
		public static XOOCNKBZGKP PBQSMZFUQKK;

		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		private static Material IWSLCMIBPFB;

		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		private static Material NTVDNWTHYHR;

		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		private static bool CCSOZIUKQTN;

		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		private static WGJMOXIQYYS PFISFMCDVZA;

		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		private static readonly CollisionMeshData[] YEIXNCHJRTL;

		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		private static CollisionMeshData HWBGOFDQAZR;

		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		private static int[] GAIUOTVHIWG;

		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		private static int[] SJLZJMGLBKC;

		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		private static readonly LODXHAYWTQY<ShapeColor, ShapeColorInfo> GVVFLLFKXRY;

		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		public static readonly Dictionary<string, EnumChoiceData> FZTLRPVKOPY;

		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		public static readonly Dictionary<int, string> FZOEUJBNFEP;

		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		private static readonly Vector3[] WJYEYTPSFWD;

		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		public static readonly Dictionary<string, EnumChoiceData> ALGQZNWKSCJ;

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public static ShapeConfig WBPHTKLJNBB
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x8DEDFC0", Offset = "0x8DEC7C0", VA = "0x188DEDFC0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		private static WGJMOXIQYYS BHVULAGBGCH
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x8DF0C90", Offset = "0x8DEF490", VA = "0x188DF0C90")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public static Texture2D FGAWDJGNCME
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x8DEDBE0", Offset = "0x8DEC3E0", VA = "0x188DEDBE0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public static ColorRemap BYWDCHLOVJJ
		{
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x8DEDF20", Offset = "0x8DEC720", VA = "0x188DEDF20")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public static ColorRemap ABWLTKILMWR
		{
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0x8DF05D0", Offset = "0x8DEEDD0", VA = "0x188DF05D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public static ShapeColorInfo[] NTUCTIPESWQ
		{
			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x8DEF5D0", Offset = "0x8DEDDD0", VA = "0x188DEF5D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public static ShapeMaterialInfo[] DGZGDHYIVMO
		{
			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x8DEDCC0", Offset = "0x8DEC4C0", VA = "0x188DEDCC0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public static int IOGVIUJVKNK
		{
			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0x1D01990", Offset = "0x1D00190", VA = "0x181D01990")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		private static int[] DAAIYBMVQKF
		{
			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0x8DEF950", Offset = "0x8DEE150", VA = "0x188DEF950")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		private static int[] YGIVBLWIDAX
		{
			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0x8DF0290", Offset = "0x8DEEA90", VA = "0x188DF0290")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public static Shader GXAYUWKAXOC
		{
			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x8DF1290", Offset = "0x8DEFA90", VA = "0x188DF1290")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public static Material SCRYKLHJLAQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x8DF0E10", Offset = "0x8DEF610", VA = "0x188DF0E10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x8DED720", Offset = "0x8DEBF20", VA = "0x188DED720")]
		private static void AHNFQMPXHBE(Scene a, LoadSceneMode b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x8DEE290", Offset = "0x8DECA90", VA = "0x188DEE290")]
		public static GameObject FHPZEUAZGNG(ShapeType a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x8DEF650", Offset = "0x8DEDE50", VA = "0x188DEF650")]
		public static GameObject LCDZXYZXZMQ(ShapeType a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x8DF0650", Offset = "0x8DEEE50", VA = "0x188DF0650")]
		private static Mesh TPUKBRHLDRR(ShapeType a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x8DEFE50", Offset = "0x8DEE650", VA = "0x188DEFE50")]
		public static bool NDGRRTYDLAC(ShapeType a, [Out] Mesh b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x8DEF050", Offset = "0x8DED850", VA = "0x188DEF050")]
		private static void HPDQLPKSTOB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x8DF0500", Offset = "0x8DEED00", VA = "0x188DF0500")]
		public static Material QHFLBGZXAFR()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x8DEF360", Offset = "0x8DEDB60", VA = "0x188DEF360")]
		public static Material HRMYJYRVECZ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x8DEFBD0", Offset = "0x8DEE3D0", VA = "0x188DEFBD0")]
		public static Vector3 MOMRRVHKLPZ(Vector3 a, Quaternion b, ShapeMaterial c)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x8DEE600", Offset = "0x8DECE00", VA = "0x188DEE600")]
		private static Vector3 GOQFUKGQTWL(Vector3 a, Quaternion b, ShapeMaterial c, bool d)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x8DEF430", Offset = "0x8DEDC30", VA = "0x188DEF430")]
		public static void HXFZIPDVXRO(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x8DEDFF0", Offset = "0x8DEC7F0", VA = "0x188DEDFF0")]
		public static int EMCPTOVIEDM(ShapeColor a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x8DF1400", Offset = "0x8DEFC00", VA = "0x188DF1400")]
		public static int ZXXJLIBRJCC(ShapeMaterial a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x8DF11B0", Offset = "0x8DEF9B0", VA = "0x188DF11B0")]
		[RRPostPlayModeMethod(PostPlayModePhase.ExitingPlayMode, 0)]
		private static void XLYGDKJVKDH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x8DF0910", Offset = "0x8DEF110", VA = "0x188DF0910")]
		public static CollisionMeshData WREDZAPOEKT(ShapeType a)
		{
			return default(CollisionMeshData);
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x8DEFD80", Offset = "0x8DEE580", VA = "0x188DEFD80")]
		public static CollisionMeshData MUFWCOFRHSN()
		{
			return default(CollisionMeshData);
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x8DEF2C0", Offset = "0x8DEDAC0", VA = "0x188DEF2C0")]
		public static string HQLCACCBKND(ShapeType a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x8DF07F0", Offset = "0x8DEEFF0", VA = "0x188DF07F0")]
		public static Bounds VEPWXDYZYXJ(ShapeType a)
		{
			return default(Bounds);
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x8DEEEA0", Offset = "0x8DED6A0", VA = "0x188DEEEA0")]
		public static int HMYDNLJRWUU(ShapeType a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x8DEE530", Offset = "0x8DECD30", VA = "0x188DEE530")]
		public static bool GGRRDZHJWKP(ShapeColor a, [Out] Color b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x8DEE5E0", Offset = "0x8DECDE0", VA = "0x188DEE5E0")]
		public static int GOMQUJZBWFQ(int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x8DEDFA0", Offset = "0x8DEC7A0", VA = "0x188DEDFA0")]
		public static int DWUHPNLAIXR(int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x8DEF8E0", Offset = "0x8DEE0E0", VA = "0x188DEF8E0")]
		public static Color MAYIUGAGKEX(ShapeColor a)
		{
			return default(Color);
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x8DF13E0", Offset = "0x8DEFBE0", VA = "0x188DF13E0")]
		public static bool ZMOWTPWTQGY(ShapeType a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x8DF1310", Offset = "0x8DEFB10", VA = "0x188DF1310")]
		public static int ZBCOFUAOOWE(ShapeType a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x8DF0E90", Offset = "0x8DEF690", VA = "0x188DF0E90")]
		[NotNull]
		public static ShapeColorInfo XGNIEESUSWN(ShapeColor a, bool b = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x8DF01F0", Offset = "0x8DEE9F0", VA = "0x188DF01F0")]
		public static ShapeMaterialInfo NLYCYDLUVXF(ShapeMaterial a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x8DEE330", Offset = "0x8DECB30", VA = "0x188DEE330")]
		public static float FZDYVNCDOVQ(int a)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x8DEF6F0", Offset = "0x8DEDEF0", VA = "0x188DEF6F0")]
		public static int LWUAYJBGIBQ(int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x8DEDD40", Offset = "0x8DEC540", VA = "0x188DEDD40")]
		public static int CDKQTBLQKIW(int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x8DF0D30", Offset = "0x8DEF530", VA = "0x188DF0D30")]
		public static Vector3 XBVCKCMWPSW(ShapeType a)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x8DEE070", Offset = "0x8DEC870", VA = "0x188DEE070")]
		public static float EVECTCCNSUD(ShapeType a, Vector3 b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x8DEFF30", Offset = "0x8DEE730", VA = "0x188DEFF30")]
		public static void NGLQDLVJZZK(bool a = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x8DEE950", Offset = "0x8DED150", VA = "0x188DEE950")]
		private static void GWJAWPNPHZZ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x8DED7A0", Offset = "0x8DEBFA0", VA = "0x188DED7A0")]
		public static void AIJRVCDTQDX()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x8DEEB70", Offset = "0x8DED370", VA = "0x188DEEB70")]
		public static void HJCRPGEPMDK()
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
