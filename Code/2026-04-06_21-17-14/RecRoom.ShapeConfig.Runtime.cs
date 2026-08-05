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
		[Cpp2IlInjected.Address(RVA = "0xA4CCA70", Offset = "0xA4CBA70", VA = "0x18A4CCA70", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x29F86A0", Offset = "0x29F76A0", VA = "0x1829F86A0")]
		public _AssemblyIndex()
		{
		}
	}
}
namespace RecRoom
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public static class LBDFVEZBEUL
	{
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public static readonly int RYZQDNEEFPQ;

		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public static readonly int EIJINEMTCAL;

		[Cpp2IlInjected.Token(Token = "0x4000003")]
		public static readonly int YSTARLWXKPR;

		[Cpp2IlInjected.Token(Token = "0x4000004")]
		public static readonly int SECTKZUGUZH;

		[Cpp2IlInjected.Token(Token = "0x4000005")]
		public static readonly int MFZALANCLYP;

		[Cpp2IlInjected.Token(Token = "0x4000006")]
		public static readonly int RHHNXEYVVAX;

		[Cpp2IlInjected.Token(Token = "0x4000007")]
		public static readonly int HEAIFOCZCJF;

		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public static readonly int EFJLFUKNRKT;

		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public static readonly int LHSNVNROERO;

		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public static readonly int ROKXGOZGMWR;

		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public static readonly int ADOTKKFBIEB;

		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public static readonly int VCKPZRFNJVH;

		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public static readonly int DVXEMUDYBGZ;

		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public static readonly int EXHYFAOKYNP;

		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public static readonly int PQIOOKINVDB;

		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public static readonly int KGNMOSZRSVG;

		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public static readonly int BBKSHIOZAYA;

		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public static readonly int UHSFAWNLTPS;

		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public static readonly int UUSNTWFMXPE;

		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public static readonly int BEQBOWWJNAM;

		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public static readonly int TMIQDVLQPMX;

		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public static readonly int QGWWNSCXSUU;

		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public static readonly int BJRJSUKCCDM;

		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public static readonly int AGNJYZKSGKD;

		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public static readonly int VYDOWQNCFCC;

		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public static readonly int VMJRVRHSWAB;

		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public static readonly int YYUDSOLCXHL;

		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public static readonly int KAHCYQGRQWU;
	}
}
namespace RecRoom.Core.Creation
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public class MCRDSKEXCVB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public readonly int ICHACFJQFGM;

		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private static MCRDSKEXCVB FYHFTLAWMVL;

		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private static MCRDSKEXCVB PXXZAMUYNBQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private readonly int UOOKJGGPHEI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private readonly int UREVZQFGZVV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private readonly int URUQRKMZCDW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private readonly float IXJFRISOFMF;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public static MCRDSKEXCVB RQYRHIRZYHQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0xA4C2D30", Offset = "0xA4C1D30", VA = "0x18A4C2D30")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public static MCRDSKEXCVB JNSKOSBQZMB
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0xA4C2C80", Offset = "0xA4C1C80", VA = "0x18A4C2C80")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xA4C2F30", Offset = "0xA4C1F30", VA = "0x18A4C2F30")]
		public MCRDSKEXCVB(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0xA4C2DE0", Offset = "0xA4C1DE0", VA = "0x18A4C2DE0")]
		public int QIXWRVGBISF(Color a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0xA4C2EC0", Offset = "0xA4C1EC0", VA = "0x18A4C2EC0")]
		public Color XTYDGRZOETP(int a)
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
		[Cpp2IlInjected.Address(RVA = "0xA4C16A0", Offset = "0xA4C06A0", VA = "0x18A4C16A0")]
		public float GRLNHIHQISP(float a, Vector2 b, bool c)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xA4C16F0", Offset = "0xA4C06F0", VA = "0x18A4C16F0")]
		public Color GRLNHIHQISP(float a, float b, float c)
		{
			return default(Color);
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0xA4C17E0", Offset = "0xA4C07E0", VA = "0x18A4C17E0")]
		public ColorRemap()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public static class EJMYARKNSJD
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
		[Cpp2IlInjected.Address(RVA = "0xA4C2560", Offset = "0xA4C1560", VA = "0x18A4C2560")]
		public static Texture2D ZINQPDPZWTU()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0xA4C2020", Offset = "0xA4C1020", VA = "0x18A4C2020")]
		public static Texture2D YQGYTKWYTQY(Func<ShapeColorInfo, ColorChannel, Color, Color> a, string b = "LegacyColorTexture")
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0xA4C1E70", Offset = "0xA4C0E70", VA = "0x18A4C1E70")]
		[CompilerGenerated]
		internal static void JWDPUWUCZBD(ShapeColorInfo a, int b, <>c__DisplayClass2_0 c)
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
		private static ODATKAGSJTR QHAMXJZTGGV;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		private static ODATKAGSJTR ZRVGBDNFWYW
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0xA4CA9C0", Offset = "0xA4C99C0", VA = "0x18A4CA9C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public Color Additive
		{
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0xA4CB3A0", Offset = "0xA4CA3A0", VA = "0x18A4CB3A0")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0xA4CAE90", Offset = "0xA4C9E90", VA = "0x18A4CAE90")]
		public static ShapeColor MGVLVLGKSMF(Color a, MCRDSKEXCVB b)
		{
			return default(ShapeColor);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0xA4CADA0", Offset = "0xA4C9DA0", VA = "0x18A4CADA0")]
		public static ShapeColor MGVLVLGKSMF(Color a)
		{
			return default(ShapeColor);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0xA4CAF60", Offset = "0xA4C9F60", VA = "0x18A4CAF60")]
		public static ShapeColorInfo SYMMCSRGPPJ(ShapeColor a, MCRDSKEXCVB b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0xA4CB1A0", Offset = "0xA4CA1A0", VA = "0x18A4CB1A0")]
		public static ShapeColorInfo WINYZNBEGUD(ShapeColor a, MCRDSKEXCVB b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0xA4CAA90", Offset = "0xA4C9A90", VA = "0x18A4CAA90")]
		public static bool FXWLDGYBCLD(Color a, [Out] ShapeColorInfo b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
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
		[Cpp2IlInjected.Address(RVA = "0xA4CB730", Offset = "0xA4CA730", VA = "0x18A4CB730")]
		public ShapeMaterialInfo()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0xA4CB6A0", Offset = "0xA4CA6A0", VA = "0x18A4CB6A0")]
		public ShapeMaterialInfo(ShapeMaterialInfo other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0xA4CB640", Offset = "0xA4CA640", VA = "0x18A4CB640")]
		public void CopyTo(ShapeMaterialInfo shapeMaterialInfo)
		{
		}
	}
}
namespace RecRoom.Core.Creation.Shapes
{
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class MZAKIHAKCRA : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private static readonly int HVANKNDWLGA;

		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private static readonly int CLKGWWTTRNJ;

		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private static readonly int TCQFSDYXLYE;

		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private static readonly int HOQHIVKJLOW;

		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private static readonly int ALQDDMWCWQY;

		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private static readonly int HUXLSTVSTZR;

		[Cpp2IlInjected.Token(Token = "0x400004D")]
		private static readonly int VWKIWSFCLUW;

		[Cpp2IlInjected.Token(Token = "0x400004E")]
		private static readonly int QRUXPNIUDCI;

		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private static readonly int YIOQHMHENQE;

		[Cpp2IlInjected.Token(Token = "0x4000050")]
		private static readonly int EBWWDNBUZOS;

		[Cpp2IlInjected.Token(Token = "0x4000051")]
		private static readonly int DGMGEULZJSC;

		[Cpp2IlInjected.Token(Token = "0x4000052")]
		private static readonly int IILTWPQHOMY;

		[Cpp2IlInjected.Token(Token = "0x4000053")]
		private static readonly int PRNBJHFRWZW;

		[Cpp2IlInjected.Token(Token = "0x4000054")]
		private static readonly int CKVQDOCYDGS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public ShapeMaterialInfo[] ULFDMGODANS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public Texture2DArray OOXXDYEMOFC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public Texture2DArray VQOGSFAAVSA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public float[] ZZPROCUULDJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public Texture2DArray EOZECRCCTOA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		public float[] YZJTIWQLXGB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public float[] SQQKFEIBERG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		public float[] NTNQOSGUSGO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public Vector4[] RHXRKJYANIQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public Texture2DArray RATGBZFNYHS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public float[] EUNHTDIHIJX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public float[] JNMMLOSUHGI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public float[] SDJIZXYUHZE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public Vector4[] RDMAVSYZYCQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		private int[] VPSPWJMLOAJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public Texture2DArray SAYRMQQJRCO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public float[] AVQQHTQKHHL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public Vector4[] CRTFQHXWANO;

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0xA4C4AB0", Offset = "0xA4C3AB0", VA = "0x18A4C4AB0")]
		private Texture2DArray LHRUALQYIOZ(string a, IReadOnlyList<Texture2D> b, bool c, ShapeMaterialInfo[] d)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0xA4C5060", Offset = "0xA4C4060", VA = "0x18A4C5060")]
		public MZAKIHAKCRA(ShapeMaterialInfo[] a, bool b, bool c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0xA4C4D20", Offset = "0xA4C3D20", VA = "0x18A4C4D20")]
		private Vector3 SKJPDQBTUKZ(ShapeMaterialInfo a)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0xA4C4A60", Offset = "0xA4C3A60", VA = "0x18A4C4A60")]
		public int IRGKTKZXNQR(ShapeMaterial a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0xA4C4A10", Offset = "0xA4C3A10", VA = "0x18A4C4A10", Slot = "4")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public interface TVYPNWLZCFU
	{
		[Cpp2IlInjected.Token(Token = "0x17000005")]
		bool ZYNKVNWBXAV
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		bool OHKESJQBRLE
		{
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		bool OSQVDFQQOHB
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public interface HDXDQGNRQIN : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x17000008")]
		Texture2D UUTXZBOFHQZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(Slot = "1")]
		Material OXYJPGNRXFB();

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(Slot = "2")]
		int MACQJBBAVWT(ShapeColor a);

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(Slot = "3")]
		int IRGKTKZXNQR(ShapeMaterial a);

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void NFBXOUHLHVZ(Material a);

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(Slot = "5")]
		ZQEBWATJSQZ[] DDFAXQIEHCT();
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public interface ODATKAGSJTR
	{
		[Cpp2IlInjected.Token(Token = "0x17000009")]
		ColorRemap DOGZDLMCZLC
		{
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		ColorRemap UCPDTDFFMTU
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(Slot = "0")]
		ShapeColorInfo LKGHHKGZJUC(ShapeColor a, bool b = true);

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		bool VSXCBZQLWLO(ShapeColor a, [Out] Color b);
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public static class ZFGWHMTCILA
	{
		[Cpp2IlInjected.Token(Token = "0x2000012")]
		private class MVWCHPEPSBX : HDXDQGNRQIN, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400007F")]
			public MZAKIHAKCRA FFMUJGCHCTQ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000080")]
			private readonly Texture2D JITPWMHMYIU;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000081")]
			private bool AFGYHOTJGMH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
			[Cpp2IlInjected.Token(Token = "0x4000082")]
			private bool OXIIGCJKAXQ;

			[Cpp2IlInjected.Token(Token = "0x4000083")]
			private static ZQEBWATJSQZ[] FJHGEPWKYAU;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000084")]
			private Texture2D FYZJYVIHAVD;

			[Cpp2IlInjected.Token(Token = "0x1700000B")]
			public Texture2D UUTXZBOFHQZ
			{
				[Cpp2IlInjected.Token(Token = "0x6000034")]
				[Cpp2IlInjected.Address(RVA = "0xA4C2FD0", Offset = "0xA4C1FD0", VA = "0x18A4C2FD0", Slot = "4")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0xA4C4840", Offset = "0xA4C3840", VA = "0x18A4C4840")]
			public MVWCHPEPSBX()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0xA4C4720", Offset = "0xA4C3720", VA = "0x18A4C4720")]
			private Color TKLHNAJAXLJ(ShapeColorInfo a, EJMYARKNSJD.ColorChannel b, Color c)
			{
				return default(Color);
			}

			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0xA4C3240", Offset = "0xA4C2240", VA = "0x18A4C3240", Slot = "10")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0xA4C4620", Offset = "0xA4C3620", VA = "0x18A4C4620", Slot = "5")]
			public Material OXYJPGNRXFB()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0xA4C32C0", Offset = "0xA4C22C0", VA = "0x18A4C32C0")]
			private void HDRNPVVPKIT(Texture2D a, bool b, bool c)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0xA4C2F90", Offset = "0xA4C1F90", VA = "0x18A4C2F90", Slot = "9")]
			public ZQEBWATJSQZ[] DDFAXQIEHCT()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0xA4C4090", Offset = "0xA4C3090", VA = "0x18A4C4090", Slot = "8")]
			public void NFBXOUHLHVZ(Material a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0xA4C3F70", Offset = "0xA4C2F70", VA = "0x18A4C3F70", Slot = "6")]
			public int MACQJBBAVWT(ShapeColor a)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0xA4C3F20", Offset = "0xA4C2F20", VA = "0x18A4C3F20", Slot = "7")]
			public int IRGKTKZXNQR(ShapeMaterial a)
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
			[Cpp2IlInjected.Address(RVA = "0xA4C5DA0", Offset = "0xA4C4DA0", VA = "0x18A4C5DA0", Slot = "4")]
			public bool Equals(MaterialHash other)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0xA4C5F90", Offset = "0xA4C4F90", VA = "0x18A4C5F90", Slot = "0")]
			public override bool Equals(object obj)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0xA4C6050", Offset = "0xA4C5050", VA = "0x18A4C6050", Slot = "2")]
			public override int GetHashCode()
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000067")]
		private static Dictionary<MaterialHash, Material> SKOCGDBOKBI;

		[Cpp2IlInjected.Token(Token = "0x4000068")]
		private static readonly int BUDUQFILZTH;

		[Cpp2IlInjected.Token(Token = "0x4000069")]
		private static readonly int LLGHLWBAIED;

		[Cpp2IlInjected.Token(Token = "0x400006A")]
		private static readonly int YVKHNZKJYBZ;

		[Cpp2IlInjected.Token(Token = "0x400006B")]
		private static readonly int ZMWXJSAIHAS;

		[Cpp2IlInjected.Token(Token = "0x400006C")]
		private static readonly int GNBICLGJBPK;

		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private static readonly int DGFOLPIQKTP;

		[Cpp2IlInjected.Token(Token = "0x400006E")]
		private static readonly int DJGVENOOYPO;

		[Cpp2IlInjected.Token(Token = "0x400006F")]
		private static readonly int VPJWNRXVBNH;

		[Cpp2IlInjected.Token(Token = "0x4000070")]
		private static readonly int AUFWVFRKNRS;

		[Cpp2IlInjected.Token(Token = "0x4000071")]
		private static readonly int UFDJSCTZDFJ;

		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private static readonly int ESTXQZLCRIX;

		[Cpp2IlInjected.Token(Token = "0x4000073")]
		private static readonly int UKYSKVORUAB;

		[Cpp2IlInjected.Token(Token = "0x4000074")]
		private static readonly int UMTJTUVYPVT;

		[Cpp2IlInjected.Token(Token = "0x4000075")]
		private static readonly int HSCJUYWNUAJ;

		[Cpp2IlInjected.Token(Token = "0x4000076")]
		private static readonly int FJHXYSNTPGT;

		[Cpp2IlInjected.Token(Token = "0x4000077")]
		private static readonly int XGLQKUHEDQX;

		[Cpp2IlInjected.Token(Token = "0x4000078")]
		private static readonly int TKNKIHFQNEV;

		[Cpp2IlInjected.Token(Token = "0x4000079")]
		private static readonly int DDETFIGJNCZ;

		[Cpp2IlInjected.Token(Token = "0x400007A")]
		private static readonly int QLFWPCJTKAJ;

		[Cpp2IlInjected.Token(Token = "0x400007B")]
		private static readonly int RLLSQPZXRSL;

		[Cpp2IlInjected.Token(Token = "0x400007C")]
		private static readonly int DCVGOWFMMNY;

		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public static readonly int ALQDDMWCWQY;

		[Cpp2IlInjected.Token(Token = "0x400007E")]
		public static readonly int BFJVJLHUHJD;

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0xA4CB9C0", Offset = "0xA4CA9C0", VA = "0x18A4CB9C0")]
		[RRPostPlayModeMethod(PostPlayModePhase.ExitingPlayMode, 0)]
		private static void CQWSBSHHZVA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0xA4CBF00", Offset = "0xA4CAF00", VA = "0x18A4CBF00")]
		private static TVYPNWLZCFU ENVYSMRBZTF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0xA4CBD00", Offset = "0xA4CAD00", VA = "0x18A4CBD00")]
		public static HDXDQGNRQIN DBOKWAVMOPL()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0xA4CC530", Offset = "0xA4CB530", VA = "0x18A4CC530")]
		public static void OBJQYVMXEDZ(this Material a, ShapeColor b, ShapeMaterial c, bool d, bool e, float f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0xA4CBF70", Offset = "0xA4CAF70", VA = "0x18A4CBF70")]
		public static void OBJQYVMXEDZ(this Material a, ShapeColorInfo b, ShapeMaterialInfo c, bool d, bool e, float f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0xA4CBA30", Offset = "0xA4CAA30", VA = "0x18A4CBA30")]
		public static Material CYCIAGSMAZN(ShapeColorInfo a, ShapeMaterialInfo b, bool c, bool d)
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
				[Cpp2IlInjected.Address(RVA = "0xA4C2760", Offset = "0xA4C1760", VA = "0x18A4C2760")]
				public KeyVal()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0xA4CB4A0", Offset = "0xA4CA4A0", VA = "0x18A4CB4A0")]
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
		protected override bool JKKLWWRKEGT
		{
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0xD405E0", Offset = "0xD3F5E0", VA = "0x180D405E0", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0xA4CB4E0", Offset = "0xA4CA4E0", VA = "0x18A4CB4E0")]
		public ShapeConfig()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public static class EIWWVZZGQOA
	{
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		public static readonly ShapeType[] OSMHVLMQRMT;

		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		public static readonly int[] ELHYIRPXEDO;

		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		public static readonly PrimitiveShapeMeshType[] QHYODSLGLZW;

		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		private static readonly Dictionary<ShapeType, int> OJHLDDMEAEE;

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0xA4C18F0", Offset = "0xA4C08F0", VA = "0x18A4C18F0")]
		private static Dictionary<ShapeType, int> JSLVRTJRVQH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0xA4C1810", Offset = "0xA4C0810", VA = "0x18A4C1810")]
		public static PrimitiveShapeMeshType AGPRETOEVDL(this ShapeType a)
		{
			return default(PrimitiveShapeMeshType);
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0xA4C1880", Offset = "0xA4C0880", VA = "0x18A4C1880")]
		public static int FQRQPUVYKKQ(this ShapeType a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0xA4C1AA0", Offset = "0xA4C0AA0", VA = "0x18A4C1AA0")]
		public static int PHNWAHRXHRR(this ShapeType a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x16A4020", Offset = "0x16A3020", VA = "0x1816A4020")]
		public static bool BCCANKSWKQO(this ShapeType a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x9C29270", Offset = "0x9C28270", VA = "0x189C29270")]
		public static bool HOTRTCIMDQM(this ShapeType a)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	public class PKWWFGWDLMU : ODATKAGSJTR
	{
		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public ColorRemap DOGZDLMCZLC
		{
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0xA4C6350", Offset = "0xA4C5350", VA = "0x18A4C6350", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public ColorRemap UCPDTDFFMTU
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0xA4C6150", Offset = "0xA4C5150", VA = "0x18A4C6150", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
		[UnityEngine.Scripting.Preserve]
		internal PKWWFGWDLMU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0xA4C6200", Offset = "0xA4C5200", VA = "0x18A4C6200")]
		[GQJUYEPYYUG.Root]
		internal static void GCLGJHIKTKH(RZEIGZPHMMY a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0xA4C62F0", Offset = "0xA4C52F0", VA = "0x18A4C62F0", Slot = "4")]
		public ShapeColorInfo LKGHHKGZJUC(ShapeColor a, bool b = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0xA4C6400", Offset = "0xA4C5400", VA = "0x18A4C6400", Slot = "5")]
		public bool VSXCBZQLWLO(ShapeColor a, [Out] Color b)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public static class SJNPTNWKRJY
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
		public static FYRDCSIKYKI LEKVTKBKMQX;

		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		private static Material KREWESQLJGY;

		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		private static Material YYLJKOSTTSC;

		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		private static bool YTQVDCZGPYY;

		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		private static HDXDQGNRQIN TLGZPDVITYX;

		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		private static readonly CollisionMeshData[] RWFTLMBHCWI;

		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		private static CollisionMeshData RHIULHBWNSY;

		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		private static int[] EVIKYEJCTLP;

		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		private static int[] ZWDYSXMSUJR;

		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		private static readonly QBWQCJVZKRT<ShapeColor, ShapeColorInfo> GHKMDONLMKT;

		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		public static readonly Dictionary<string, EnumChoiceData> JLHMNRLGPLL;

		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		public static readonly Dictionary<int, string> JKRRVXDONDK;

		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		private static readonly Vector3[] LUZPQOLOINM;

		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		public static readonly Dictionary<string, EnumChoiceData> UZMKXIUUDQY;

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public static ShapeConfig TYPAAZBPMMI
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0xA4C68F0", Offset = "0xA4C58F0", VA = "0x18A4C68F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		private static HDXDQGNRQIN EKTZWISTYLK
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0xA4C7C60", Offset = "0xA4C6C60", VA = "0x18A4C7C60")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public static Texture2D UUTXZBOFHQZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0xA4C6770", Offset = "0xA4C5770", VA = "0x18A4C6770")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public static ColorRemap DOGZDLMCZLC
		{
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0xA4C8190", Offset = "0xA4C7190", VA = "0x18A4C8190")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public static ColorRemap UCPDTDFFMTU
		{
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0xA4C6870", Offset = "0xA4C5870", VA = "0x18A4C6870")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public static ShapeColorInfo[] QYKLEUUVZST
		{
			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0xA4C7BE0", Offset = "0xA4C6BE0", VA = "0x18A4C7BE0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public static ShapeMaterialInfo[] VINHDVIIVDZ
		{
			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0xA4C7D00", Offset = "0xA4C6D00", VA = "0x18A4C7D00")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public static int SOAWABBAMON
		{
			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0x1FC5750", Offset = "0x1FC4750", VA = "0x181FC5750")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		private static int[] CMVBDINTIUQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0xA4C64E0", Offset = "0xA4C54E0", VA = "0x18A4C64E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		private static int[] GWHALGBUVEM
		{
			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0xA4C70C0", Offset = "0xA4C60C0", VA = "0x18A4C70C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public static Shader HQGRQZSQJQR
		{
			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0xA4C9A80", Offset = "0xA4C8A80", VA = "0x18A4C9A80")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public static Material TQXZALRDVUH
		{
			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0xA4C9F80", Offset = "0xA4C8F80", VA = "0x18A4C9F80")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0xA4C6920", Offset = "0xA4C5920", VA = "0x18A4C6920")]
		private static void EMOEEETUVYT(Scene a, LoadSceneMode b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0xA4C8210", Offset = "0xA4C7210", VA = "0x18A4C8210")]
		public static GameObject PLIOUSAEXRJ(ShapeType a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0xA4C8AE0", Offset = "0xA4C7AE0", VA = "0x18A4C8AE0")]
		public static GameObject TUCQDVHGBGB(ShapeType a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0xA4C96F0", Offset = "0xA4C86F0", VA = "0x18A4C96F0")]
		private static Mesh WGOKGCXLYIY(ShapeType a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0xA4C8540", Offset = "0xA4C7540", VA = "0x18A4C8540")]
		public static bool SEZNZWABEJR(ShapeType a, [Out] Mesh b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0xA4C6D50", Offset = "0xA4C5D50", VA = "0x18A4C6D50")]
		private static void GOGKZCDOGDY()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0xA4C8CA0", Offset = "0xA4C7CA0", VA = "0x18A4C8CA0")]
		public static Material UFDLZZADQYG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0xA4CA1C0", Offset = "0xA4C91C0", VA = "0x18A4CA1C0")]
		public static Material ZCRNTOSJWVE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0xA4C6B80", Offset = "0xA4C5B80", VA = "0x18A4C6B80")]
		public static Vector3 FFFLIFMTNVY(Vector3 a, Quaternion b, ShapeMaterial c)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0xA4C92F0", Offset = "0xA4C82F0", VA = "0x18A4C92F0")]
		private static Vector3 VSNUOZXFUJE(Vector3 a, Quaternion b, ShapeMaterial c, bool d)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0xA4C7350", Offset = "0xA4C6350", VA = "0x18A4C7350")]
		public static void HWBHDAUSQFT(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0xA4C80A0", Offset = "0xA4C70A0", VA = "0x18A4C80A0")]
		public static int MACQJBBAVWT(ShapeColor a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0xA4C7890", Offset = "0xA4C6890", VA = "0x18A4C7890")]
		public static int IRGKTKZXNQR(ShapeMaterial a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0xA4CA000", Offset = "0xA4C9000", VA = "0x18A4CA000")]
		[RRPostPlayModeMethod(PostPlayModePhase.ExitingPlayMode, 0)]
		private static void YMHESMKOXNK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0xA4C7500", Offset = "0xA4C6500", VA = "0x18A4C7500")]
		public static CollisionMeshData IMBKDXRQRIU(ShapeType a)
		{
			return default(CollisionMeshData);
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0xA4C82B0", Offset = "0xA4C72B0", VA = "0x18A4C82B0")]
		public static CollisionMeshData QQFFIUMBDWM()
		{
			return default(CollisionMeshData);
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0xA4C8820", Offset = "0xA4C7820", VA = "0x18A4C8820")]
		public static string SMDGFVEOCJS(ShapeType a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0xA4C8B80", Offset = "0xA4C7B80", VA = "0x18A4C8B80")]
		public static Bounds UCVJWATKYVQ(ShapeType a)
		{
			return default(Bounds);
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0xA4C8390", Offset = "0xA4C7390", VA = "0x18A4C8390")]
		public static int RGPHIJZSKWP(ShapeType a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0xA4C9640", Offset = "0xA4C8640", VA = "0x18A4C9640")]
		public static bool VSXCBZQLWLO(ShapeColor a, [Out] Color b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0xA4C9B00", Offset = "0xA4C8B00", VA = "0x18A4C9B00")]
		public static int XESVZSKWVKV(int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0xA4C6D30", Offset = "0xA4C5D30", VA = "0x18A4C6D30")]
		public static int FQYXDQDVLIM(int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0xA4C8120", Offset = "0xA4C7120", VA = "0x18A4C8120")]
		public static Color NWBFJXJDGEQ(ShapeColor a)
		{
			return default(Color);
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0xA4C6850", Offset = "0xA4C5850", VA = "0x18A4C6850")]
		public static bool DYEBRNISOPD(ShapeType a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0xA4CA0F0", Offset = "0xA4C90F0", VA = "0x18A4CA0F0")]
		public static int YZUUNZIUCGT(ShapeType a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0xA4C7D80", Offset = "0xA4C6D80", VA = "0x18A4C7D80")]
		[NotNull]
		public static ShapeColorInfo LKGHHKGZJUC(ShapeColor a, bool b = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0xA4CA290", Offset = "0xA4C9290", VA = "0x18A4CA290")]
		public static ShapeMaterialInfo ZHJYPONVQOK(ShapeMaterial a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0xA4C8620", Offset = "0xA4C7620", VA = "0x18A4C8620")]
		public static float SLOCPCLFKRR(int a)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0xA4C9890", Offset = "0xA4C8890", VA = "0x18A4C9890")]
		public static int XDGMXXLHHGF(int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0xA4C69A0", Offset = "0xA4C59A0", VA = "0x18A4C69A0")]
		public static int ETDWVTGYDIP(int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0xA4C6FE0", Offset = "0xA4C5FE0", VA = "0x18A4C6FE0")]
		public static Vector3 GXAWMPSACJF(ShapeType a)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0xA4C88C0", Offset = "0xA4C78C0", VA = "0x18A4C88C0")]
		public static float SRRNLJUQPFC(ShapeType a, Vector3 b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0xA4C7910", Offset = "0xA4C6910", VA = "0x18A4C7910")]
		public static void IUONVSJNWLB(bool a = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0xA4C8D70", Offset = "0xA4C7D70", VA = "0x18A4C8D70")]
		private static void VDMNEJXCFUE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0xA4C9B20", Offset = "0xA4C8B20", VA = "0x18A4C9B20")]
		public static void XEZRBWDGZCM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0xA4C8FB0", Offset = "0xA4C7FB0", VA = "0x18A4C8FB0")]
		public static void VPOLEHVQOER()
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
