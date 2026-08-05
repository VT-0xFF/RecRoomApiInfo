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
		[Cpp2IlInjected.Address(RVA = "0xA29EBF0", Offset = "0xA29DFF0", VA = "0x18A29EBF0", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x29FCDD0", Offset = "0x29FC1D0", VA = "0x1829FCDD0")]
		public _AssemblyIndex()
		{
		}
	}
}
namespace RecRoom
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public static class XRPLEOBQBGD
	{
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public static readonly int PTRSBATLWJI;

		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public static readonly int CGLXNEYHGML;

		[Cpp2IlInjected.Token(Token = "0x4000003")]
		public static readonly int HZPEWWUZMPB;

		[Cpp2IlInjected.Token(Token = "0x4000004")]
		public static readonly int TBEGUNQXRSZ;

		[Cpp2IlInjected.Token(Token = "0x4000005")]
		public static readonly int PFYEHHHSZOT;

		[Cpp2IlInjected.Token(Token = "0x4000006")]
		public static readonly int JEPFQVIDKED;

		[Cpp2IlInjected.Token(Token = "0x4000007")]
		public static readonly int ZTUVPDUCESD;

		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public static readonly int SYBKQUUHAZJ;

		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public static readonly int TXBAVYMRPAM;

		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public static readonly int SYWIVIIYLDL;

		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public static readonly int DDHDJRSGVLH;

		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public static readonly int IZVWWMSUSFT;

		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public static readonly int ZPSOQWZOTLH;

		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public static readonly int HNZNRCHKGZX;

		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public static readonly int WBYFEQDZGZZ;

		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public static readonly int RXJOKCPVGDC;

		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public static readonly int ANUAYKLCGRO;

		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public static readonly int WPHOSGKBBSU;

		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public static readonly int YXUNBMZCRPE;

		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public static readonly int FXFPSWNQAYA;

		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public static readonly int NVFEZDVKSHF;

		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public static readonly int MKCQZFJHRCE;

		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public static readonly int EFLLDRJZWHU;

		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public static readonly int LWHLBNJSIIX;

		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public static readonly int ILXMMFENRAW;

		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public static readonly int FBVAVYDSVMV;

		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public static readonly int XCHMCLODRIJ;

		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public static readonly int FFETYGUMAYA;
	}
}
namespace RecRoom.Core.Creation
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public class FPQHOGRPIJJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public readonly int PBQXGOYCTLK;

		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private static FPQHOGRPIJJ PKHUCFYJCKB;

		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private static FPQHOGRPIJJ KABHJDSALUC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private readonly int QDOLOMSVXNG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private readonly int PZSKOOEUAFR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private readonly int QAIFGIMMCNS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private readonly float GALWTRYOLKZ;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public static FPQHOGRPIJJ JWLILDFYEOK
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0xA2956C0", Offset = "0xA294AC0", VA = "0x18A2956C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public static FPQHOGRPIJJ LSBJKFDRATP
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0xA295770", Offset = "0xA294B70", VA = "0x18A295770")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xA295960", Offset = "0xA294D60", VA = "0x18A295960")]
		public FPQHOGRPIJJ(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0xA295810", Offset = "0xA294C10", VA = "0x18A295810")]
		public int KROPIDFONEN(Color a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0xA2958F0", Offset = "0xA294CF0", VA = "0x18A2958F0")]
		public Color WVCKJPVDKSR(int a)
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
		[Cpp2IlInjected.Address(RVA = "0xA293910", Offset = "0xA292D10", VA = "0x18A293910")]
		public float IJWICLFUBST(float a, Vector2 b, bool c)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xA293820", Offset = "0xA292C20", VA = "0x18A293820")]
		public Color IJWICLFUBST(float a, float b, float c)
		{
			return default(Color);
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0xA293960", Offset = "0xA292D60", VA = "0x18A293960")]
		public ColorRemap()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public static class OLFJATAFYCZ
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
		[Cpp2IlInjected.Address(RVA = "0xA2991C0", Offset = "0xA2985C0", VA = "0x18A2991C0")]
		public static Texture2D YXHRIGPEQQK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0xA298C80", Offset = "0xA298080", VA = "0x18A298C80")]
		public static Texture2D KGSFCVPRDAY(Func<ShapeColorInfo, ColorChannel, Color, Color> a, string b = "LegacyColorTexture")
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0xA298AD0", Offset = "0xA297ED0", VA = "0x18A298AD0")]
		[CompilerGenerated]
		internal static void BTDECJRLAXL(ShapeColorInfo a, int b, <>c__DisplayClass2_0 c)
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
		private static CKNVHDQNEWH IHSQTEKJKUB;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		private static CKNVHDQNEWH QPOLTUQUUJE
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0xA29D770", Offset = "0xA29CB70", VA = "0x18A29D770")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public Color Additive
		{
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0xA29E140", Offset = "0xA29D540", VA = "0x18A29E140")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0xA29DC70", Offset = "0xA29D070", VA = "0x18A29DC70")]
		public static ShapeColor SCRURQHCGVT(Color a, FPQHOGRPIJJ b)
		{
			return default(ShapeColor);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0xA29DD40", Offset = "0xA29D140", VA = "0x18A29DD40")]
		public static ShapeColor SCRURQHCGVT(Color a)
		{
			return default(ShapeColor);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0xA29DA30", Offset = "0xA29CE30", VA = "0x18A29DA30")]
		public static ShapeColorInfo PJCBHFZAXPB(ShapeColor a, FPQHOGRPIJJ b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0xA29D830", Offset = "0xA29CC30", VA = "0x18A29D830")]
		public static ShapeColorInfo MTVAFJMOXMX(ShapeColor a, FPQHOGRPIJJ b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0xA29DE30", Offset = "0xA29D230", VA = "0x18A29DE30")]
		public static bool YSFAYTVSKCN(Color a, [Out] ShapeColorInfo b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0xCFCAD0", Offset = "0xCFBED0", VA = "0x180CFCAD0")]
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
		[Cpp2IlInjected.Address(RVA = "0xA29E4D0", Offset = "0xA29D8D0", VA = "0x18A29E4D0")]
		public ShapeMaterialInfo()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0xA29E440", Offset = "0xA29D840", VA = "0x18A29E440")]
		public ShapeMaterialInfo(ShapeMaterialInfo other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0xA29E3E0", Offset = "0xA29D7E0", VA = "0x18A29E3E0")]
		public void CopyTo(ShapeMaterialInfo shapeMaterialInfo)
		{
		}
	}
}
namespace RecRoom.Core.Creation.Shapes
{
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class KDEQHUNILJE : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private static readonly int RDFHCRFOHOI;

		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private static readonly int YMPKEFKWHOH;

		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private static readonly int MSBIERPXVOI;

		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private static readonly int NJTURLUDXNI;

		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private static readonly int GQZNCRALFCI;

		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private static readonly int GJWQUCCMQDR;

		[Cpp2IlInjected.Token(Token = "0x400004D")]
		private static readonly int QOHYBNKZABA;

		[Cpp2IlInjected.Token(Token = "0x400004E")]
		private static readonly int DTUKNKLZFRK;

		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private static readonly int EHHNIXXXLVK;

		[Cpp2IlInjected.Token(Token = "0x4000050")]
		private static readonly int XDIJNXLXSVY;

		[Cpp2IlInjected.Token(Token = "0x4000051")]
		private static readonly int HKQNEWHCDBU;

		[Cpp2IlInjected.Token(Token = "0x4000052")]
		private static readonly int HYHNPZGPMTC;

		[Cpp2IlInjected.Token(Token = "0x4000053")]
		private static readonly int OSMBZZOTZZS;

		[Cpp2IlInjected.Token(Token = "0x4000054")]
		private static readonly int ISPSAAZFGKO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public ShapeMaterialInfo[] WJTVTYTXQQM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public Texture2DArray AJHGMTPGNRG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public Texture2DArray WIJDADZQYUY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public float[] MRXVTTKSVOL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public Texture2DArray BFZEUSRAPNS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		public float[] YMAZPRXASVP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public float[] WYPFEEYYFUU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		public float[] LZUYEOQJFGC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public Vector4[] YZQLTTMOYVK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public Texture2DArray WXJZXWFUHOA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public float[] UBJHIKGEAJX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public float[] MCLTPIEMHKI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public float[] ICWGGZJSSXE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public Vector4[] TSORAGTKENC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		private int[] BQKVUBOTSOV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public Texture2DArray QWTLPBQCVWG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public float[] IXUZVSUIYFT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public Vector4[] VFVWFBYOCKM;

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0xA297170", Offset = "0xA296570", VA = "0x18A297170")]
		private Texture2DArray ZVRWBZQETFP(string a, IReadOnlyList<Texture2D> b, bool c, ShapeMaterialInfo[] d)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0xA297640", Offset = "0xA296A40", VA = "0x18A297640")]
		public KDEQHUNILJE(ShapeMaterialInfo[] a, bool b, bool c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0xA297070", Offset = "0xA296470", VA = "0x18A297070")]
		private Vector3 JJMMXXWPIKR(ShapeMaterialInfo a)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0xA297120", Offset = "0xA296520", VA = "0x18A297120")]
		public int QXIZMIMDLXL(ShapeMaterial a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0xA297020", Offset = "0xA296420", VA = "0x18A297020", Slot = "4")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public interface TIBOEHALUDY
	{
		[Cpp2IlInjected.Token(Token = "0x17000005")]
		bool TOVXZOUGEZH
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		bool HKSSUGKROJM
		{
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		bool KCUFHBVQIIX
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public interface XBAYPABFHMB : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x17000008")]
		Texture2D HJRSWOYBNMB
		{
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(Slot = "1")]
		Material IOIXBFKXGDB();

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(Slot = "2")]
		int YYIDEAYGZIX(ShapeColor a);

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(Slot = "3")]
		int QXIZMIMDLXL(ShapeMaterial a);

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void UFCJNOEGISD(Material a);

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(Slot = "5")]
		COLEVIOBCGF[] SCIASJXCAVJ();
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public interface CKNVHDQNEWH
	{
		[Cpp2IlInjected.Token(Token = "0x17000009")]
		ColorRemap NWCJUFKCVIY
		{
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		ColorRemap ICILYCQGXTI
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(Slot = "0")]
		ShapeColorInfo UTOJYISLUJM(ShapeColor a, bool b = true);

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		bool MMTKLXEIJBW(ShapeColor a, [Out] Color b);
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public static class JQTVSFMHQCK
	{
		[Cpp2IlInjected.Token(Token = "0x2000012")]
		private class DCADCFYZGNH : XBAYPABFHMB, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400007F")]
			public KDEQHUNILJE FVFBWXHFZVY;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000080")]
			private readonly Texture2D XNFSJYZRTAI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000081")]
			private bool CHKEGTAFEBF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
			[Cpp2IlInjected.Token(Token = "0x4000082")]
			private bool VZVZULSPWGS;

			[Cpp2IlInjected.Token(Token = "0x4000083")]
			private static COLEVIOBCGF[] WBAWLNOKIUU;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000084")]
			private Texture2D KZKZVNKHHJX;

			[Cpp2IlInjected.Token(Token = "0x1700000B")]
			public Texture2D HJRSWOYBNMB
			{
				[Cpp2IlInjected.Token(Token = "0x6000034")]
				[Cpp2IlInjected.Address(RVA = "0xA295160", Offset = "0xA294560", VA = "0x18A295160", Slot = "4")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0xA2954F0", Offset = "0xA2948F0", VA = "0x18A2954F0")]
			public DCADCFYZGNH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0xA293990", Offset = "0xA292D90", VA = "0x18A293990")]
			private Color BDOLJIUUDIP(ShapeColorInfo a, OLFJATAFYCZ.ColorChannel b, Color c)
			{
				return default(Color);
			}

			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0xA293AB0", Offset = "0xA292EB0", VA = "0x18A293AB0", Slot = "10")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0xA293B30", Offset = "0xA292F30", VA = "0x18A293B30", Slot = "5")]
			public Material IOIXBFKXGDB()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0xA293C30", Offset = "0xA293030", VA = "0x18A293C30")]
			private void KQSLIUROXQP(Texture2D a, bool b, bool c)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0xA294BC0", Offset = "0xA293FC0", VA = "0x18A294BC0", Slot = "9")]
			public COLEVIOBCGF[] SCIASJXCAVJ()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0xA294C00", Offset = "0xA294000", VA = "0x18A294C00", Slot = "8")]
			public void UFCJNOEGISD(Material a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0xA2953D0", Offset = "0xA2947D0", VA = "0x18A2953D0", Slot = "6")]
			public int YYIDEAYGZIX(ShapeColor a)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0xA294B70", Offset = "0xA293F70", VA = "0x18A294B70", Slot = "7")]
			public int QXIZMIMDLXL(ShapeMaterial a)
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
			[Cpp2IlInjected.Address(RVA = "0xA2987E0", Offset = "0xA297BE0", VA = "0x18A2987E0", Slot = "4")]
			public bool Equals(MaterialHash other)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0xA298720", Offset = "0xA297B20", VA = "0x18A298720", Slot = "0")]
			public override bool Equals(object obj)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0xA2989D0", Offset = "0xA297DD0", VA = "0x18A2989D0", Slot = "2")]
			public override int GetHashCode()
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000067")]
		private static Dictionary<MaterialHash, Material> JPRAJABMGKG;

		[Cpp2IlInjected.Token(Token = "0x4000068")]
		private static readonly int HXNILLRVYBH;

		[Cpp2IlInjected.Token(Token = "0x4000069")]
		private static readonly int ITUVLYNHUHF;

		[Cpp2IlInjected.Token(Token = "0x400006A")]
		private static readonly int PJFAIIQSMQD;

		[Cpp2IlInjected.Token(Token = "0x400006B")]
		private static readonly int TKGAGCGWFIS;

		[Cpp2IlInjected.Token(Token = "0x400006C")]
		private static readonly int BVYBNOBHCIE;

		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private static readonly int RZDOPAZQDLT;

		[Cpp2IlInjected.Token(Token = "0x400006E")]
		private static readonly int VLXHDFREIOA;

		[Cpp2IlInjected.Token(Token = "0x400006F")]
		private static readonly int ORFXTYDCVMB;

		[Cpp2IlInjected.Token(Token = "0x4000070")]
		private static readonly int XBXRKPENRJS;

		[Cpp2IlInjected.Token(Token = "0x4000071")]
		private static readonly int MYQKMVATUZF;

		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private static readonly int JAKOISVOWQL;

		[Cpp2IlInjected.Token(Token = "0x4000073")]
		private static readonly int VNTKYDRTJWJ;

		[Cpp2IlInjected.Token(Token = "0x4000074")]
		private static readonly int BLLSHIIWSOV;

		[Cpp2IlInjected.Token(Token = "0x4000075")]
		private static readonly int NMFHKXLMLFL;

		[Cpp2IlInjected.Token(Token = "0x4000076")]
		private static readonly int LLCHBGGYYHF;

		[Cpp2IlInjected.Token(Token = "0x4000077")]
		private static readonly int IVEAEAFCNHR;

		[Cpp2IlInjected.Token(Token = "0x4000078")]
		private static readonly int GGGGOIYHCYZ;

		[Cpp2IlInjected.Token(Token = "0x4000079")]
		private static readonly int XFAQVMOZENH;

		[Cpp2IlInjected.Token(Token = "0x400007A")]
		private static readonly int DZJIBOKYYWV;

		[Cpp2IlInjected.Token(Token = "0x400007B")]
		private static readonly int AVRXQPFAFNN;

		[Cpp2IlInjected.Token(Token = "0x400007C")]
		private static readonly int YIRSAPNTQFY;

		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public static readonly int GQZNCRALFCI;

		[Cpp2IlInjected.Token(Token = "0x400007E")]
		public static readonly int AHSNYHRKCUB;

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0xA296350", Offset = "0xA295750", VA = "0x18A296350")]
		[RRPostPlayModeMethod(PostPlayModePhase.ExitingPlayMode, 0)]
		private static void XOHJUZUXNFI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0xA2959C0", Offset = "0xA294DC0", VA = "0x18A2959C0")]
		private static TIBOEHALUDY FGOMDNXJNNZ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0xA2963C0", Offset = "0xA2957C0", VA = "0x18A2963C0")]
		public static XBAYPABFHMB YEMPSLYVAGN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0xA295A30", Offset = "0xA294E30", VA = "0x18A295A30")]
		public static void SGMFBQYLCYX(this Material a, ShapeColor b, ShapeMaterial c, bool d, bool e, float f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0xA295B00", Offset = "0xA294F00", VA = "0x18A295B00")]
		public static void SGMFBQYLCYX(this Material a, ShapeColorInfo b, ShapeMaterialInfo c, bool d, bool e, float f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0xA296090", Offset = "0xA295490", VA = "0x18A296090")]
		public static Material SLKONRPQSHB(ShapeColorInfo a, ShapeMaterialInfo b, bool c, bool d)
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
				[Cpp2IlInjected.Address(RVA = "0xA298350", Offset = "0xA297750", VA = "0x18A298350")]
				public KeyVal()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0xA29E240", Offset = "0xA29D640", VA = "0x18A29E240")]
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
		protected override bool BRLRHWAORSP
		{
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0xD3ECB0", Offset = "0xD3E0B0", VA = "0x180D3ECB0", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0xA29E280", Offset = "0xA29D680", VA = "0x18A29E280")]
		public ShapeConfig()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public static class JWDDMQLLAMU
	{
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		public static readonly ShapeType[] NQRAAYODMIP;

		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		public static readonly int[] KVTCAEZGIZS;

		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		public static readonly PrimitiveShapeMeshType[] HYOKTVZVBEQ;

		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		private static readonly Dictionary<ShapeType, int> XSBISAHIKXW;

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0xA296A80", Offset = "0xA295E80", VA = "0x18A296A80")]
		private static Dictionary<ShapeType, int> LGZKTBMTMEL()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0xA296CA0", Offset = "0xA2960A0", VA = "0x18A296CA0")]
		public static PrimitiveShapeMeshType TNSHCHBJXTD(this ShapeType a)
		{
			return default(PrimitiveShapeMeshType);
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0xA296C30", Offset = "0xA296030", VA = "0x18A296C30")]
		public static int OZYYGVOIHYI(this ShapeType a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0xA2969E0", Offset = "0xA295DE0", VA = "0x18A2969E0")]
		public static int GSQHWLZBMDB(this ShapeType a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x16A7C90", Offset = "0x16A7090", VA = "0x1816A7C90")]
		public static bool QQEBJMBYDLU(this ShapeType a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x9A060D0", Offset = "0x9A054D0", VA = "0x189A060D0")]
		public static bool JXZFOSSHNLW(this ShapeType a)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	public class MGRGWOXIEDK : CKNVHDQNEWH
	{
		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public ColorRemap NWCJUFKCVIY
		{
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0xA298440", Offset = "0xA297840", VA = "0x18A298440", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public ColorRemap ICILYCQGXTI
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0xA298390", Offset = "0xA297790", VA = "0x18A298390", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0xCFCAD0", Offset = "0xCFBED0", VA = "0x180CFCAD0")]
		[UnityEngine.Scripting.Preserve]
		internal MGRGWOXIEDK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0xA2985D0", Offset = "0xA2979D0", VA = "0x18A2985D0")]
		[BQDQKYYGTTM.Root]
		internal static void TDUDTGPDFOH(TFZCSWYZDKY a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0xA2986C0", Offset = "0xA297AC0", VA = "0x18A2986C0", Slot = "4")]
		public ShapeColorInfo UTOJYISLUJM(ShapeColor a, bool b = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0xA2984F0", Offset = "0xA2978F0", VA = "0x18A2984F0", Slot = "5")]
		public bool MMTKLXEIJBW(ShapeColor a, [Out] Color b)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public static class PAMCNYCABOO
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
		public static PZVGSBFXRHS AYEVVNSVUSD;

		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		private static Material GYJGLBLVBHW;

		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		private static Material ZBQERBGYUPM;

		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		private static bool DJWMGVLWMQM;

		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		private static XBAYPABFHMB IHHYEDPIFSD;

		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		private static readonly CollisionMeshData[] CHKYLABTVPK;

		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		private static CollisionMeshData AXQGOZZPEIA;

		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		private static int[] UZGYBXAHYAZ;

		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		private static int[] WUAGOCAJVXR;

		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		private static readonly HJQKIXZDART<ShapeColor, ShapeColorInfo> TIOHPUUWTLN;

		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		public static readonly Dictionary<string, EnumChoiceData> NMYESCORLIZ;

		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		public static readonly Dictionary<int, string> NMIKAIGZJAY;

		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		private static readonly Vector3[] MDTVOJBWMWK;

		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		public static readonly Dictionary<string, EnumChoiceData> VRAQDJPHYGY;

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public static ShapeConfig TYTOHYUTEVW
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0xA29C900", Offset = "0xA29BD00", VA = "0x18A29C900")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		private static XBAYPABFHMB MMDELXRONAE
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0xA29B0E0", Offset = "0xA29A4E0", VA = "0x18A29B0E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public static Texture2D HJRSWOYBNMB
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0xA29C1A0", Offset = "0xA29B5A0", VA = "0x18A29C1A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public static ColorRemap NWCJUFKCVIY
		{
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0xA29A390", Offset = "0xA299790", VA = "0x18A29A390")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public static ColorRemap ICILYCQGXTI
		{
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0xA299CA0", Offset = "0xA2990A0", VA = "0x18A299CA0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public static ShapeColorInfo[] WSBJFQZVHFF
		{
			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0xA29BE00", Offset = "0xA29B200", VA = "0x18A29BE00")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public static ShapeMaterialInfo[] FOKPWTZNSGX
		{
			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0xA29B390", Offset = "0xA29A790", VA = "0x18A29B390")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public static int WZTARLRSRUV
		{
			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0x1FC2930", Offset = "0x1FC1D30", VA = "0x181FC2930")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		private static int[] HLLRQDWRYJG
		{
			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0xA29C680", Offset = "0xA29BA80", VA = "0x18A29C680")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		private static int[] ELTINWZDLXW
		{
			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0xA29ADD0", Offset = "0xA29A1D0", VA = "0x18A29ADD0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public static Shader VJMZKHVERYZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0xA29AAE0", Offset = "0xA299EE0", VA = "0x18A29AAE0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public static Material KKSOJVWYPWL
		{
			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0xA29B310", Offset = "0xA29A710", VA = "0x18A29B310")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0xA29A6F0", Offset = "0xA299AF0", VA = "0x18A29A6F0")]
		private static void HYXXWOEAVJB(Scene a, LoadSceneMode b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0xA29D080", Offset = "0xA29C480", VA = "0x18A29D080")]
		public static GameObject ZFVZXQEXZBB(ShapeType a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0xA2993C0", Offset = "0xA2987C0", VA = "0x18A2993C0")]
		public static GameObject AEEDEGSFJOB(ShapeType a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0xA299F10", Offset = "0xA299310", VA = "0x18A299F10")]
		private static Mesh DDHUHHUPEBW(ShapeType a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0xA29B230", Offset = "0xA29A630", VA = "0x18A29B230")]
		public static bool MMTMREUGKML(ShapeType a, [Out] Mesh b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0xA29AB60", Offset = "0xA299F60", VA = "0x18A29AB60")]
		private static void JKKOICPPBRQ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0xA299900", Offset = "0xA298D00", VA = "0x18A299900")]
		public static Material BOBVRCFYTVY()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0xA29C5B0", Offset = "0xA29B9B0", VA = "0x18A29C5B0")]
		public static Material XSUERVDZYRM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0xA29C930", Offset = "0xA29BD30", VA = "0x18A29C930")]
		public static Vector3 YTSGSNHRQSS(Vector3 a, Quaternion b, ShapeMaterial c)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0xA29A770", Offset = "0xA299B70", VA = "0x18A29A770")]
		private static Vector3 ICOIRUEWSFU(Vector3 a, Quaternion b, ShapeMaterial c, bool d)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0xA29CEE0", Offset = "0xA29C2E0", VA = "0x18A29CEE0")]
		public static void YZBOQPIMCWJ(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0xA29CE60", Offset = "0xA29C260", VA = "0x18A29CE60")]
		public static int YYIDEAYGZIX(ShapeColor a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0xA29BA40", Offset = "0xA29AE40", VA = "0x18A29BA40")]
		public static int QXIZMIMDLXL(ShapeMaterial a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0xA29A2B0", Offset = "0xA2996B0", VA = "0x18A29A2B0")]
		[RRPostPlayModeMethod(PostPlayModePhase.ExitingPlayMode, 0)]
		private static void ENHKEZGPBNS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0xA29CAE0", Offset = "0xA29BEE0", VA = "0x18A29CAE0")]
		public static CollisionMeshData YXRENRUADGY(ShapeType a)
		{
			return default(CollisionMeshData);
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0xA2999F0", Offset = "0xA298DF0", VA = "0x18A2999F0")]
		public static CollisionMeshData CJAMYFTTDCM()
		{
			return default(CollisionMeshData);
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0xA29B410", Offset = "0xA29A810", VA = "0x18A29B410")]
		public static string OURMLKNBGJS(ShapeType a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0xA29BCE0", Offset = "0xA29B0E0", VA = "0x18A29BCE0")]
		public static Bounds SGXRJUUXBJE(ShapeType a)
		{
			return default(Bounds);
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0xA299750", Offset = "0xA298B50", VA = "0x18A299750")]
		public static int BKTTPZORGPF(ShapeType a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0xA29B180", Offset = "0xA29A580", VA = "0x18A29B180")]
		public static bool MMTKLXEIJBW(ShapeColor a, [Out] Color b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0xA29AAC0", Offset = "0xA299EC0", VA = "0x18A29AAC0")]
		public static int IGQMEKLNMNL(int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0xA29A6D0", Offset = "0xA299AD0", VA = "0x18A29A6D0")]
		public static int HKYPFSWFCCU(int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0xA29B4B0", Offset = "0xA29A8B0", VA = "0x18A29B4B0")]
		public static Color PGGMSXYYEWE(ShapeColor a)
		{
			return default(Color);
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0xA2999D0", Offset = "0xA298DD0", VA = "0x18A2999D0")]
		public static bool BVNWEIZACAR(ShapeType a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0xA299460", Offset = "0xA298860", VA = "0x18A299460")]
		public static int AHUTUCKBSYP(ShapeType a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0xA29BE80", Offset = "0xA29B280", VA = "0x18A29BE80")]
		[NotNull]
		public static ShapeColorInfo UTOJYISLUJM(ShapeColor a, bool b = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0xA29B040", Offset = "0xA29A440", VA = "0x18A29B040")]
		public static ShapeMaterialInfo JNNRCMNVWCC(ShapeMaterial a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0xA29A0B0", Offset = "0xA2994B0", VA = "0x18A29A0B0")]
		public static float EECGBYTCBUH(int a)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0xA299D20", Offset = "0xA299120", VA = "0x18A299D20")]
		public static int CVGDEOYKXOV(int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0xA299AC0", Offset = "0xA298EC0", VA = "0x18A299AC0")]
		public static int CNRFOZBKXYH(int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0xA29B520", Offset = "0xA29A920", VA = "0x18A29B520")]
		public static Vector3 POUDIYFYHOX(ShapeType a)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0xA29BAC0", Offset = "0xA29AEC0", VA = "0x18A29BAC0")]
		public static float RUGDYFIYHZC(ShapeType a, Vector3 b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0xA29A410", Offset = "0xA299810", VA = "0x18A29A410")]
		public static void GXINXMZVLNB(bool a = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0xA299530", Offset = "0xA298930", VA = "0x18A299530")]
		private static void AOIMZSBHNDO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0xA29B600", Offset = "0xA29AA00", VA = "0x18A29B600")]
		public static void QOPFFAKUOXO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0xA29C280", Offset = "0xA29B680", VA = "0x18A29C280")]
		public static void XFQRSFRJAIR()
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
