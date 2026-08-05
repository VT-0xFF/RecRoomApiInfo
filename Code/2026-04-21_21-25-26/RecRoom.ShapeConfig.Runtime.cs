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
		[Cpp2IlInjected.Address(RVA = "0xA4D8F90", Offset = "0xA4D7990", VA = "0x18A4D8F90", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x2A2D0B0", Offset = "0x2A2BAB0", VA = "0x182A2D0B0")]
		public _AssemblyIndex()
		{
		}
	}
}
namespace RecRoom
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public static class AIOJFTOWGJU
	{
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public static readonly int LTZEXUYVSGR;

		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public static readonly int GSBJBAQNZTK;

		[Cpp2IlInjected.Token(Token = "0x4000003")]
		public static readonly int QRULOIFQBHO;

		[Cpp2IlInjected.Token(Token = "0x4000004")]
		public static readonly int GRNSGIIQOJE;

		[Cpp2IlInjected.Token(Token = "0x4000005")]
		public static readonly int TLHXSNGKRRK;

		[Cpp2IlInjected.Token(Token = "0x4000006")]
		public static readonly int ZTTOQZIUPZW;

		[Cpp2IlInjected.Token(Token = "0x4000007")]
		public static readonly int GLJDRTSVGHW;

		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public static readonly int HTJJBITLSZU;

		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public static readonly int RZMYWEVWFTZ;

		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public static readonly int FBGUBHIJAPM;

		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public static readonly int ZHTFESVCSPI;

		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public static readonly int KLZOEWPRIQC;

		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public static readonly int WHJJSBEYHRG;

		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public static readonly int MWFESVMJXPS;

		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public static readonly int MAORMBGWZNU;

		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public static readonly int CUSTRSBJCSN;

		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public static readonly int KWMHZUXTNUX;

		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public static readonly int NDUCJSIMTIV;

		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public static readonly int PZEHMECKNZT;

		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public static readonly int WCXAUTRVCUP;

		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public static readonly int BTHLRDTEGMI;

		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public static readonly int ADTBYFJGVON;

		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public static readonly int LJJUARQJBQJ;

		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public static readonly int OBWJWVKCGSS;

		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public static readonly int MQWJGDBNTRB;

		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public static readonly int IAXXWJAJYME;

		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public static readonly int UXFOZNWYPHS;

		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public static readonly int MARPLRBIVDP;
	}
}
namespace RecRoom.Core.Creation
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public class PCXAVMVQGAQ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public readonly int FZFZOKSAJRJ;

		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private static PCXAVMVQGAQ EUBDSRTSPBU;

		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private static PCXAVMVQGAQ HFTPWUUPFWL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private readonly int XNBDZBCBVLL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private readonly int XPHBUXMYVGG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private readonly int XQHKHFILQKZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private readonly float EFYECTSENLA;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public static PCXAVMVQGAQ DAGTGAYAVMH
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0xA4D5E70", Offset = "0xA4D4870", VA = "0x18A4D5E70")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public static PCXAVMVQGAQ ZEUBWUUXESO
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0xA4D5F20", Offset = "0xA4D4920", VA = "0x18A4D5F20")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xA4D6120", Offset = "0xA4D4B20", VA = "0x18A4D6120")]
		public PCXAVMVQGAQ(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0xA4D6040", Offset = "0xA4D4A40", VA = "0x18A4D6040")]
		public int XWNEJNRNPNI(Color a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0xA4D5FD0", Offset = "0xA4D49D0", VA = "0x18A4D5FD0")]
		public Color WQPMNHZGVSW(int a)
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
		[Cpp2IlInjected.Address(RVA = "0xA4CE190", Offset = "0xA4CCB90", VA = "0x18A4CE190")]
		public float WWFSFTPJMDM(float a, Vector2 b, bool c)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xA4CE0A0", Offset = "0xA4CCAA0", VA = "0x18A4CE0A0")]
		public Color WWFSFTPJMDM(float a, float b, float c)
		{
			return default(Color);
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0xA4CE1E0", Offset = "0xA4CCBE0", VA = "0x18A4CE1E0")]
		public ColorRemap()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public static class GXNLLALPQOA
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
		[Cpp2IlInjected.Address(RVA = "0xA4D0010", Offset = "0xA4CEA10", VA = "0x18A4D0010")]
		public static Texture2D YXUNJRMKEAF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0xA4CFAD0", Offset = "0xA4CE4D0", VA = "0x18A4CFAD0")]
		public static Texture2D PVOJAPAIEVB(Func<ShapeColorInfo, ColorChannel, Color, Color> a, string b = "LegacyColorTexture")
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0xA4CF920", Offset = "0xA4CE320", VA = "0x18A4CF920")]
		[CompilerGenerated]
		internal static void EAYAAORAHJY(ShapeColorInfo a, int b, <>c__DisplayClass2_0 c)
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
		private static RGYCUBFCNPO ILLFMXILSYS;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		private static RGYCUBFCNPO CVZLBDVJWEX
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0xA4D6A90", Offset = "0xA4D5490", VA = "0x18A4D6A90")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public Color Additive
		{
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0xA4D6B60", Offset = "0xA4D5560", VA = "0x18A4D6B60")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0xA4D66B0", Offset = "0xA4D50B0", VA = "0x18A4D66B0")]
		public static ShapeColor CBWAVAMVLMS(Color a, PCXAVMVQGAQ b)
		{
			return default(ShapeColor);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0xA4D65C0", Offset = "0xA4D4FC0", VA = "0x18A4D65C0")]
		public static ShapeColor CBWAVAMVLMS(Color a)
		{
			return default(ShapeColor);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0xA4D6180", Offset = "0xA4D4B80", VA = "0x18A4D6180")]
		public static ShapeColorInfo AIAWQAXPBVM(ShapeColor a, PCXAVMVQGAQ b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0xA4D63C0", Offset = "0xA4D4DC0", VA = "0x18A4D63C0")]
		public static ShapeColorInfo AUGOXZBDQBA(ShapeColor a, PCXAVMVQGAQ b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0xA4D6780", Offset = "0xA4D5180", VA = "0x18A4D6780")]
		public static bool LLXFYBFUXDG(Color a, [Out] ShapeColorInfo b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
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
		[Cpp2IlInjected.Address(RVA = "0xA4D6EF0", Offset = "0xA4D58F0", VA = "0x18A4D6EF0")]
		public ShapeMaterialInfo()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0xA4D6E60", Offset = "0xA4D5860", VA = "0x18A4D6E60")]
		public ShapeMaterialInfo(ShapeMaterialInfo other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0xA4D6E00", Offset = "0xA4D5800", VA = "0x18A4D6E00")]
		public void CopyTo(ShapeMaterialInfo shapeMaterialInfo)
		{
		}
	}
}
namespace RecRoom.Core.Creation.Shapes
{
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class JHBYEQVUTTP : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private static readonly int NNZGNIUOKTJ;

		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private static readonly int GIAFTIHXIIE;

		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private static readonly int AJJTJYYATHD;

		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private static readonly int PAITAQRUDHV;

		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private static readonly int VNLYJJLZRJJ;

		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private static readonly int IXTVGFHJBQM;

		[Cpp2IlInjected.Token(Token = "0x400004D")]
		private static readonly int ZCGMJUMAULV;

		[Cpp2IlInjected.Token(Token = "0x400004E")]
		private static readonly int JAJQNMATZNF;

		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private static readonly int TCQAGUGWHOF;

		[Cpp2IlInjected.Token(Token = "0x4000050")]
		private static readonly int FVGNSQVTXJJ;

		[Cpp2IlInjected.Token(Token = "0x4000051")]
		private static readonly int AKSOVSPMHCL;

		[Cpp2IlInjected.Token(Token = "0x4000052")]
		private static readonly int TCUBZESZTVV;

		[Cpp2IlInjected.Token(Token = "0x4000053")]
		private static readonly int BHSTFLEMUOJ;

		[Cpp2IlInjected.Token(Token = "0x4000054")]
		private static readonly int PUAIWGTFSDR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public ShapeMaterialInfo[] YRRUGOAARGB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public Texture2DArray HEVCKKRCBTR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public Texture2DArray INRWHSXKPIX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public float[] HDLWFICLGOU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public Texture2DArray NWEPEGBKOIN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		public float[] DLHTCTCIFNI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public float[] BTIDNHAHKUJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		public float[] SGVKFETFTJD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public Vector4[] DSAWDWGHYLN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public Texture2DArray ITAQPUIVMCB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public float[] VPGYAUOTIPY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public float[] OECMSCGJKHT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public float[] FOPWKOJXCSF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public Vector4[] TOTXLCQOWEL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		private int[] JXBOFMTAJJA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public Texture2DArray LRKODFHLNHX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public float[] KVRJQTBAQTM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public Vector4[] SXNWDSHJZTD;

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0xA4D4740", Offset = "0xA4D3140", VA = "0x18A4D4740")]
		private Texture2DArray HQRADURGVOE(string a, IReadOnlyList<Texture2D> b, bool c, ShapeMaterialInfo[] d)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0xA4D4D40", Offset = "0xA4D3740", VA = "0x18A4D4D40")]
		public JHBYEQVUTTP(ShapeMaterialInfo[] a, bool b, bool c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0xA4D4A00", Offset = "0xA4D3400", VA = "0x18A4D4A00")]
		private Vector3 VSXYSDPVHTE(ShapeMaterialInfo a)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0xA4D49B0", Offset = "0xA4D33B0", VA = "0x18A4D49B0")]
		public int PBQFUXOJPLS(ShapeMaterial a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0xA4D46F0", Offset = "0xA4D30F0", VA = "0x18A4D46F0", Slot = "4")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public interface JKAPDTUUVYF
	{
		[Cpp2IlInjected.Token(Token = "0x17000005")]
		bool GPISZXGFOFC
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		bool DZNUZRNKOJD
		{
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		bool YERCAKUIRJQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public interface KJOFBICKWWI : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x17000008")]
		Texture2D RHMZGZEGYNI
		{
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(Slot = "1")]
		Material CACJCZFNQNK();

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(Slot = "2")]
		int CYAIDUJLFCM(ShapeColor a);

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(Slot = "3")]
		int PBQFUXOJPLS(ShapeMaterial a);

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void GZIQSGSDNVG(Material a);

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(Slot = "5")]
		KKSNSCRXYAE[] RORXICRVQBO();
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public interface RGYCUBFCNPO
	{
		[Cpp2IlInjected.Token(Token = "0x17000009")]
		ColorRemap OYXQGUTSETL
		{
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		ColorRemap MPRMAPKNEOL
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(Slot = "0")]
		ShapeColorInfo VGVTLABSKMP(ShapeColor a, bool b = true);

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		bool LFKXBQQDOTD(ShapeColor a, [Out] Color b);
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public static class EVQGKTCDFUL
	{
		[Cpp2IlInjected.Token(Token = "0x2000012")]
		private class TNXRRFDWSZK : KJOFBICKWWI, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400007F")]
			public JHBYEQVUTTP FWZIXTVIDMX;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000080")]
			private readonly Texture2D UBBGJFJQVOP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000081")]
			private bool ECZDCVNOMTW;

			[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
			[Cpp2IlInjected.Token(Token = "0x4000082")]
			private bool HCVXXWQBWRP;

			[Cpp2IlInjected.Token(Token = "0x4000083")]
			private static KKSNSCRXYAE[] XICFPJEQMRZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000084")]
			private Texture2D YPZFXDARAZY;

			[Cpp2IlInjected.Token(Token = "0x1700000B")]
			public Texture2D RHMZGZEGYNI
			{
				[Cpp2IlInjected.Token(Token = "0x6000034")]
				[Cpp2IlInjected.Address(RVA = "0xA4D8560", Offset = "0xA4D6F60", VA = "0x18A4D8560", Slot = "4")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0xA4D87D0", Offset = "0xA4D71D0", VA = "0x18A4D87D0")]
			public TNXRRFDWSZK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0xA4D6F20", Offset = "0xA4D5920", VA = "0x18A4D6F20")]
			private Color AKACMRVQEEE(ShapeColorInfo a, GXNLLALPQOA.ColorChannel b, Color c)
			{
				return default(Color);
			}

			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0xA4D7260", Offset = "0xA4D5C60", VA = "0x18A4D7260", Slot = "10")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0xA4D7040", Offset = "0xA4D5A40", VA = "0x18A4D7040", Slot = "5")]
			public Material CACJCZFNQNK()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0xA4D78C0", Offset = "0xA4D62C0", VA = "0x18A4D78C0")]
			private void POTKIRKODPU(Texture2D a, bool b, bool c)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0xA4D8520", Offset = "0xA4D6F20", VA = "0x18A4D8520", Slot = "9")]
			public KKSNSCRXYAE[] RORXICRVQBO()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0xA4D72E0", Offset = "0xA4D5CE0", VA = "0x18A4D72E0", Slot = "8")]
			public void GZIQSGSDNVG(Material a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0xA4D7140", Offset = "0xA4D5B40", VA = "0x18A4D7140", Slot = "6")]
			public int CYAIDUJLFCM(ShapeColor a)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0xA4D7870", Offset = "0xA4D6270", VA = "0x18A4D7870", Slot = "7")]
			public int PBQFUXOJPLS(ShapeMaterial a)
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
			[Cpp2IlInjected.Address(RVA = "0xA4D5B80", Offset = "0xA4D4580", VA = "0x18A4D5B80", Slot = "4")]
			public bool Equals(MaterialHash other)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0xA4D5AC0", Offset = "0xA4D44C0", VA = "0x18A4D5AC0", Slot = "0")]
			public override bool Equals(object obj)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0xA4D5D70", Offset = "0xA4D4770", VA = "0x18A4D5D70", Slot = "2")]
			public override int GetHashCode()
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000067")]
		private static Dictionary<MaterialHash, Material> EISXDXPDAJL;

		[Cpp2IlInjected.Token(Token = "0x4000068")]
		private static readonly int LJHMVKYWJNY;

		[Cpp2IlInjected.Token(Token = "0x4000069")]
		private static readonly int OUKICCQAJRO;

		[Cpp2IlInjected.Token(Token = "0x400006A")]
		private static readonly int WAJZBPUYOQQ;

		[Cpp2IlInjected.Token(Token = "0x400006B")]
		private static readonly int CEYOCGRGRPF;

		[Cpp2IlInjected.Token(Token = "0x400006C")]
		private static readonly int LGDZKNCFEGN;

		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private static readonly int LHXJTUUDFXK;

		[Cpp2IlInjected.Token(Token = "0x400006E")]
		private static readonly int AOYMWKDKYLT;

		[Cpp2IlInjected.Token(Token = "0x400006F")]
		private static readonly int XWUCTQXHHWG;

		[Cpp2IlInjected.Token(Token = "0x4000070")]
		private static readonly int FDGYNJVJWHX;

		[Cpp2IlInjected.Token(Token = "0x4000071")]
		private static readonly int JDBFZRNXQAE;

		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private static readonly int CYHAALWYOAA;

		[Cpp2IlInjected.Token(Token = "0x4000073")]
		private static readonly int PFPDCHDKJOU;

		[Cpp2IlInjected.Token(Token = "0x4000074")]
		private static readonly int FIFXVUPQTHO;

		[Cpp2IlInjected.Token(Token = "0x4000075")]
		private static readonly int KXKESUSQUZQ;

		[Cpp2IlInjected.Token(Token = "0x4000076")]
		private static readonly int LVCEEBMXGOQ;

		[Cpp2IlInjected.Token(Token = "0x4000077")]
		private static readonly int BCCVLWXHGOU;

		[Cpp2IlInjected.Token(Token = "0x4000078")]
		private static readonly int NJRFFYFGVUQ;

		[Cpp2IlInjected.Token(Token = "0x4000079")]
		private static readonly int CBQQJTOGWEY;

		[Cpp2IlInjected.Token(Token = "0x400007A")]
		private static readonly int VRMXQCPCVAO;

		[Cpp2IlInjected.Token(Token = "0x400007B")]
		private static readonly int OWSDBHDGKDO;

		[Cpp2IlInjected.Token(Token = "0x400007C")]
		private static readonly int CHRSVQSWHNJ;

		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public static readonly int VNLYJJLZRJJ;

		[Cpp2IlInjected.Token(Token = "0x400007E")]
		public static readonly int UTXJUILCOXS;

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0xA4CEB70", Offset = "0xA4CD570", VA = "0x18A4CEB70")]
		[RRPostPlayModeMethod(PostPlayModePhase.ExitingPlayMode, 0)]
		private static void IGKASPCGHIZ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0xA4CEDE0", Offset = "0xA4CD7E0", VA = "0x18A4CEDE0")]
		private static JKAPDTUUVYF XKUVDFPVPAE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0xA4CEBE0", Offset = "0xA4CD5E0", VA = "0x18A4CEBE0")]
		public static KJOFBICKWWI VEPRWNNAOEW()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0xA4CE210", Offset = "0xA4CCC10", VA = "0x18A4CE210")]
		public static void CVAXCZPTSVA(this Material a, ShapeColor b, ShapeMaterial c, bool d, bool e, float f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0xA4CE2E0", Offset = "0xA4CCCE0", VA = "0x18A4CE2E0")]
		public static void CVAXCZPTSVA(this Material a, ShapeColorInfo b, ShapeMaterialInfo c, bool d, bool e, float f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0xA4CE8A0", Offset = "0xA4CD2A0", VA = "0x18A4CE8A0")]
		public static Material CVYSTIFRPEA(ShapeColorInfo a, ShapeMaterialInfo b, bool c, bool d)
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
				[Cpp2IlInjected.Address(RVA = "0xA4D5A80", Offset = "0xA4D4480", VA = "0x18A4D5A80")]
				public KeyVal()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0xA4D6C60", Offset = "0xA4D5660", VA = "0x18A4D6C60")]
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
		protected override bool VNYAZYWCJPM
		{
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0xD5AE10", Offset = "0xD59810", VA = "0x180D5AE10", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0xA4D6CA0", Offset = "0xA4D56A0", VA = "0x18A4D6CA0")]
		public ShapeConfig()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public static class GGWHDJFSJDJ
	{
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		public static readonly ShapeType[] FHJQGPVPNXG;

		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		public static readonly int[] NUPZHLEFGZX;

		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		public static readonly PrimitiveShapeMeshType[] TUZCFCMLANT;

		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		private static readonly Dictionary<ShapeType, int> BYDWTTSBXEP;

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0xA4CF3D0", Offset = "0xA4CDDD0", VA = "0x18A4CF3D0")]
		private static Dictionary<ShapeType, int> PGNJIJVEZVQ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0xA4CF580", Offset = "0xA4CDF80", VA = "0x18A4CF580")]
		public static PrimitiveShapeMeshType UCBBFCBUQBC(this ShapeType a)
		{
			return default(PrimitiveShapeMeshType);
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0xA4CF360", Offset = "0xA4CDD60", VA = "0x18A4CF360")]
		public static int GAKOSQWTKPN(this ShapeType a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0xA4CF2C0", Offset = "0xA4CDCC0", VA = "0x18A4CF2C0")]
		public static int ASADFTZZRPU(this ShapeType a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x16CDA50", Offset = "0x16CC450", VA = "0x1816CDA50")]
		public static bool QUILXDSJSHH(this ShapeType a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x9C363A0", Offset = "0x9C34DA0", VA = "0x189C363A0")]
		public static bool IOUUXANWYLT(this ShapeType a)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	public class VJOYUWVLTUB : RGYCUBFCNPO
	{
		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public ColorRemap OYXQGUTSETL
		{
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0xA4D8EE0", Offset = "0xA4D78E0", VA = "0x18A4D8EE0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public ColorRemap MPRMAPKNEOL
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0xA4D8C00", Offset = "0xA4D7600", VA = "0x18A4D8C00", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
		[UnityEngine.Scripting.Preserve]
		internal VJOYUWVLTUB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0xA4D8DF0", Offset = "0xA4D77F0", VA = "0x18A4D8DF0")]
		[CXDXQIFYXBD.Root]
		internal static void WESKAKIVYCE(MZEBANDYSXL a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0xA4D8D90", Offset = "0xA4D7790", VA = "0x18A4D8D90", Slot = "4")]
		public ShapeColorInfo VGVTLABSKMP(ShapeColor a, bool b = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0xA4D8CB0", Offset = "0xA4D76B0", VA = "0x18A4D8CB0", Slot = "5")]
		public bool LFKXBQQDOTD(ShapeColor a, [Out] Color b)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public static class GZATNUWYOLZ
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
		public static DYNHRMPGIXT BLXZBNYBZUA;

		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		private static Material SLSZNKQUNGR;

		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		private static Material PGKYNMFIMKZ;

		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		private static bool VCFBTDAZTKZ;

		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		private static KJOFBICKWWI HJBUGRTISSQ;

		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		private static readonly CollisionMeshData[] HWSCINHBMZR;

		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		private static CollisionMeshData OSGROJNIINH;

		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		private static int[] NSWCDZAWYRC;

		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		private static int[] JIFKZCFQADW;

		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		private static readonly ERQEZVDMCAS<ShapeColor, ShapeColorInfo> DQZMFGSKSZW;

		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		public static readonly Dictionary<string, EnumChoiceData> KKGOMTXKSBS;

		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		public static readonly Dictionary<int, string> KKWJEOFCUJT;

		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		private static readonly Vector3[] NAYNTVFIKYF;

		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		public static readonly Dictionary<string, EnumChoiceData> OSBRYAOXJBN;

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public static ShapeConfig EBJVLIWAOQV
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0xA4D12D0", Offset = "0xA4CFCD0", VA = "0x18A4D12D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		private static KJOFBICKWWI RPJGOJSPPBD
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0xA4D2710", Offset = "0xA4D1110", VA = "0x18A4D2710")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public static Texture2D RHMZGZEGYNI
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0xA4D34C0", Offset = "0xA4D1EC0", VA = "0x18A4D34C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public static ColorRemap OYXQGUTSETL
		{
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0xA4D3FE0", Offset = "0xA4D29E0", VA = "0x18A4D3FE0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public static ColorRemap MPRMAPKNEOL
		{
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0xA4D2250", Offset = "0xA4D0C50", VA = "0x18A4D2250")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public static ShapeColorInfo[] QLCXVYPINLY
		{
			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0xA4D3F60", Offset = "0xA4D2960", VA = "0x18A4D3F60")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public static ShapeMaterialInfo[] XXKWUVQWSJW
		{
			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0xA4D2C10", Offset = "0xA4D1610", VA = "0x18A4D2C10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public static int STEOFEOSYNU
		{
			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0x1FF2F00", Offset = "0x1FF1900", VA = "0x181FF2F00")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		private static int[] BVZOPPIRMBR
		{
			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0xA4D0850", Offset = "0xA4CF250", VA = "0x18A4D0850")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		private static int[] TPWNHNOWWHP
		{
			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0xA4D0410", Offset = "0xA4CEE10", VA = "0x18A4D0410")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public static Shader WOMIYRJCLJS
		{
			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0xA4D2D60", Offset = "0xA4D1760", VA = "0x18A4D2D60")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public static Material BHBVYANOAFE
		{
			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0xA4D3C90", Offset = "0xA4D2690", VA = "0x18A4D3C90")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0xA4D2F60", Offset = "0xA4D1960", VA = "0x18A4D2F60")]
		private static void OZATMTJTXXK(Scene a, LoadSceneMode b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0xA4D3EC0", Offset = "0xA4D28C0", VA = "0x18A4D3EC0")]
		public static GameObject YZLFOAVJCKO(ShapeType a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0xA4D25C0", Offset = "0xA4D0FC0", VA = "0x18A4D25C0")]
		public static GameObject JBNERXVTWCS(ShapeType a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0xA4D1980", Offset = "0xA4D0380", VA = "0x18A4D1980")]
		private static Mesh FQNRKWWFLJH(ShapeType a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0xA4D0330", Offset = "0xA4CED30", VA = "0x18A4D0330")]
		public static bool AWXMTYSYCIE(ShapeType a, [Out] Mesh b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0xA4D0AE0", Offset = "0xA4CF4E0", VA = "0x18A4D0AE0")]
		private static void CFNXGZJGIGX()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0xA4D2C90", Offset = "0xA4D1690", VA = "0x18A4D2C90")]
		public static Material NSFBGGCCMRT()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0xA4D27B0", Offset = "0xA4D11B0", VA = "0x18A4D27B0")]
		public static Material MKYCSRJPJVV()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0xA4D06A0", Offset = "0xA4CF0A0", VA = "0x18A4D06A0")]
		public static Vector3 BGFLVQIFBSR(Vector3 a, Quaternion b, ShapeMaterial c)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0xA4D1CC0", Offset = "0xA4D06C0", VA = "0x18A4D1CC0")]
		private static Vector3 HAKKSTKQILL(Vector3 a, Quaternion b, ShapeMaterial c, bool d)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0xA4D1300", Offset = "0xA4CFD00", VA = "0x18A4D1300")]
		public static void EJZNSVGLWBY(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0xA4D0D70", Offset = "0xA4CF770", VA = "0x18A4D0D70")]
		public static int CYAIDUJLFCM(ShapeColor a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0xA4D2FE0", Offset = "0xA4D19E0", VA = "0x18A4D2FE0")]
		public static int PBQFUXOJPLS(ShapeMaterial a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0xA4D14B0", Offset = "0xA4CFEB0", VA = "0x18A4D14B0")]
		[RRPostPlayModeMethod(PostPlayModePhase.ExitingPlayMode, 0)]
		private static void EWKLUTXPTCD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0xA4D2880", Offset = "0xA4D1280", VA = "0x18A4D2880")]
		public static CollisionMeshData MPIUYSCWQUN(ShapeType a)
		{
			return default(CollisionMeshData);
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0xA4D2DE0", Offset = "0xA4D17E0", VA = "0x18A4D2DE0")]
		public static CollisionMeshData OLZUMFFWKID()
		{
			return default(CollisionMeshData);
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0xA4D1B40", Offset = "0xA4D0540", VA = "0x18A4D1B40")]
		public static string FUVYIULECLJ(ShapeType a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0xA4D0210", Offset = "0xA4CEC10", VA = "0x18A4D0210")]
		public static Bounds AUOKQEVDFZP(ShapeType a)
		{
			return default(Bounds);
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0xA4D3D10", Offset = "0xA4D2710", VA = "0x18A4D3D10")]
		public static int YWLYMSZXIIS(ShapeType a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0xA4D2660", Offset = "0xA4D1060", VA = "0x18A4D2660")]
		public static bool LFKXBQQDOTD(ShapeColor a, [Out] Color b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0xA4D12B0", Offset = "0xA4CFCB0", VA = "0x18A4D12B0")]
		public static int DZUIJSVUTPS(int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0xA4D3C00", Offset = "0xA4D2600", VA = "0x18A4D3C00")]
		public static int VHGAHLZLQYJ(int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0xA4D3C20", Offset = "0xA4D2620", VA = "0x18A4D3C20")]
		public static Color XLOOOFQJAXX(ShapeColor a)
		{
			return default(Color);
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0xA4D1B20", Offset = "0xA4D0520", VA = "0x18A4D1B20")]
		public static bool FRYJOUAEXSW(ShapeType a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0xA4D24F0", Offset = "0xA4D0EF0", VA = "0x18A4D24F0")]
		public static int IRDFCZZFDXU(ShapeType a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0xA4D38E0", Offset = "0xA4D22E0", VA = "0x18A4D38E0")]
		[NotNull]
		public static ShapeColorInfo VGVTLABSKMP(ShapeColor a, bool b = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0xA4D2EC0", Offset = "0xA4D18C0", VA = "0x18A4D2EC0")]
		public static ShapeMaterialInfo ORMFWKETBAB(ShapeMaterial a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0xA4D15A0", Offset = "0xA4CFFA0", VA = "0x18A4D15A0")]
		public static float FFZOEYUMPII(int a)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0xA4D0DF0", Offset = "0xA4CF7F0", VA = "0x18A4D0DF0")]
		public static int DMHLOWWPSLG(int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0xA4D17A0", Offset = "0xA4D01A0", VA = "0x18A4D17A0")]
		public static int FLLAVOAGLLG(int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0xA4D1BE0", Offset = "0xA4D05E0", VA = "0x18A4D1BE0")]
		public static Vector3 GOOHGVDPPAI(ShapeType a)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0xA4D22D0", Offset = "0xA4D0CD0", VA = "0x18A4D22D0")]
		public static float IPFNNZJWWOZ(ShapeType a, Vector3 b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0xA4D0FE0", Offset = "0xA4CF9E0", VA = "0x18A4D0FE0")]
		public static void DSPWXDTZDSS(bool a = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0xA4D2010", Offset = "0xA4D0A10", VA = "0x18A4D2010")]
		private static void ICETNIWAGJL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0xA4D3060", Offset = "0xA4D1A60", VA = "0x18A4D3060")]
		public static void RUATNLAHOAX()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0xA4D35A0", Offset = "0xA4D1FA0", VA = "0x18A4D35A0")]
		public static void UDZZEWDYAKS()
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
