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
		[Cpp2IlInjected.Address(RVA = "0x8F2EB00", Offset = "0x8F2DD00", VA = "0x188F2EB00", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x27815F0", Offset = "0x27807F0", VA = "0x1827815F0")]
		public _AssemblyIndex()
		{
		}
	}
}
namespace RecRoom
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public static class ERTJBNBKWQZ
	{
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public static readonly int NJEBNQGDXNW;

		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public static readonly int VSCALMBPUXX;

		[Cpp2IlInjected.Token(Token = "0x4000003")]
		public static readonly int THLSNSMQGKZ;

		[Cpp2IlInjected.Token(Token = "0x4000004")]
		public static readonly int RXWJGSGDGNR;

		[Cpp2IlInjected.Token(Token = "0x4000005")]
		public static readonly int AXIHNFQDVRP;

		[Cpp2IlInjected.Token(Token = "0x4000006")]
		public static readonly int VGUSHKQOXNT;

		[Cpp2IlInjected.Token(Token = "0x4000007")]
		public static readonly int LKEPGTKRDZH;

		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public static readonly int JIQHWHRXGRP;

		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public static readonly int BXODHBSVONE;

		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public static readonly int LKJQXBPIEPR;

		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public static readonly int GGQIVLCSHSX;

		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public static readonly int WFTWNOGUKBN;

		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public static readonly int DGFQKUURSSD;

		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public static readonly int SQKMPYRUCYL;

		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public static readonly int DQJUCRCCXON;

		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public static readonly int DLDIZPSGONI;

		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public static readonly int QUPXHDZFKRA;

		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public static readonly int PAISZMUTGIS;

		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public static readonly int URNZYUEGRLK;

		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public static readonly int VRDEQOYVYRA;

		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public static readonly int BYSENRFRCOR;

		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public static readonly int DDGMBKQPFVY;

		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public static readonly int PJOYXLBJWFC;

		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public static readonly int WUTDGQKPZRP;

		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public static readonly int SVQQSADQLTK;

		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public static readonly int YSBCGRSJXJJ;

		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public static readonly int PRYQXQHIRUP;

		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public static readonly int VRPGLZHCLRY;
	}
}
namespace RecRoom.Core.Creation
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public class GXBNVWNXWQV
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public readonly int SKQEJPFKPEG;

		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private static GXBNVWNXWQV VAGTXEWWSIL;

		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private static GXBNVWNXWQV VZFFOFFJVSI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private readonly int NMFYOOOIYHU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private readonly int NOWKEYNAQZH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private readonly int NPMEWSUSTHI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private readonly float DZDUTHDWSRR;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public static GXBNVWNXWQV GMJFPZLUQSE
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x8F24CD0", Offset = "0x8F23ED0", VA = "0x188F24CD0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public static GXBNVWNXWQV YSNEPFROTYX
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x8F24D80", Offset = "0x8F23F80", VA = "0x188F24D80")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x8F24F70", Offset = "0x8F24170", VA = "0x188F24F70")]
		public GXBNVWNXWQV(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x8F24E20", Offset = "0x8F24020", VA = "0x188F24E20")]
		public int RFXJGEALDVJ(Color a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x8F24F00", Offset = "0x8F24100", VA = "0x188F24F00")]
		public Color UQPJOPVZUVR(int a)
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
		[Cpp2IlInjected.Address(RVA = "0x8F23A50", Offset = "0x8F22C50", VA = "0x188F23A50")]
		public float BEOXNJYSLBD(float a, Vector2 b, bool c)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x8F23AA0", Offset = "0x8F22CA0", VA = "0x188F23AA0")]
		public Color BEOXNJYSLBD(float a, float b, float c)
		{
			return default(Color);
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x8F23B90", Offset = "0x8F22D90", VA = "0x188F23B90")]
		public ColorRemap()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public static class EPMLESOSLJZ
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
		[Cpp2IlInjected.Address(RVA = "0x8F242B0", Offset = "0x8F234B0", VA = "0x188F242B0")]
		public static Texture2D WQWPCSSUTWU()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x8F23BC0", Offset = "0x8F22DC0", VA = "0x188F23BC0")]
		public static Texture2D IAGTZZTJVQG(Func<ShapeColorInfo, ColorChannel, Color, Color> a, string b = "LegacyColorTexture")
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x8F24100", Offset = "0x8F23300", VA = "0x188F24100")]
		[CompilerGenerated]
		internal static void KZZHLCVVFBR(ShapeColorInfo a, int b, <>c__DisplayClass2_0 c)
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
		private static EUHFJULRGTX SHYNLONWGNV;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		private static EUHFJULRGTX SQLCHMTLGAM
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x8F2CAA0", Offset = "0x8F2BCA0", VA = "0x188F2CAA0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public Color Additive
		{
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x8F2CB60", Offset = "0x8F2BD60", VA = "0x188F2CB60")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x8F2C5D0", Offset = "0x8F2B7D0", VA = "0x188F2C5D0")]
		public static ShapeColor NZEDRZZXDXV(Color a, GXBNVWNXWQV b)
		{
			return default(ShapeColor);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x8F2C6A0", Offset = "0x8F2B8A0", VA = "0x188F2C6A0")]
		public static ShapeColor NZEDRZZXDXV(Color a)
		{
			return default(ShapeColor);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x8F2C390", Offset = "0x8F2B590", VA = "0x188F2C390")]
		public static ShapeColorInfo JTQKOXEFPKR(ShapeColor a, GXBNVWNXWQV b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x8F2C190", Offset = "0x8F2B390", VA = "0x188F2C190")]
		public static ShapeColorInfo DUEEQFKSWQF(ShapeColor a, GXBNVWNXWQV b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x8F2C790", Offset = "0x8F2B990", VA = "0x188F2C790")]
		public static bool SNHQRVCOEQT(Color a, [Out] ShapeColorInfo b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0xABDFB0", Offset = "0xABD1B0", VA = "0x180ABDFB0")]
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
		[Cpp2IlInjected.Address(RVA = "0x8F2CEF0", Offset = "0x8F2C0F0", VA = "0x188F2CEF0")]
		public ShapeMaterialInfo()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x8F2CE60", Offset = "0x8F2C060", VA = "0x188F2CE60")]
		public ShapeMaterialInfo(ShapeMaterialInfo other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x8F2CE00", Offset = "0x8F2C000", VA = "0x188F2CE00")]
		public void CopyTo(ShapeMaterialInfo shapeMaterialInfo)
		{
		}
	}
}
namespace RecRoom.Core.Creation.Shapes
{
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class UPHJDWBVDKE : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private static readonly int IFZLZLXQMHE;

		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private static readonly int NKWVMYJZBXD;

		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private static readonly int ASOYNCKTVXM;

		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private static readonly int TDFGEMCSIPO;

		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private static readonly int BLSOFRQIRCO;

		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private static readonly int LVELJFEESKB;

		[Cpp2IlInjected.Token(Token = "0x400004D")]
		private static readonly int VXJQCKLFHKU;

		[Cpp2IlInjected.Token(Token = "0x400004E")]
		private static readonly int FBGFWZVKHPQ;

		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private static readonly int NATTGHIYHFQ;

		[Cpp2IlInjected.Token(Token = "0x4000050")]
		private static readonly int FTTWEJHMESI;

		[Cpp2IlInjected.Token(Token = "0x4000051")]
		private static readonly int DPVVHBPQQLG;

		[Cpp2IlInjected.Token(Token = "0x4000052")]
		private static readonly int WSSXIJBNSJA;

		[Cpp2IlInjected.Token(Token = "0x4000053")]
		private static readonly int VEEDXJKSRVA;

		[Cpp2IlInjected.Token(Token = "0x4000054")]
		private static readonly int EQDPRZNZEOQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public ShapeMaterialInfo[] OJEIGDPAMJY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public Texture2DArray ZOBBRSFVYDY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public Texture2DArray HIUIPMVAZFQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public float[] OXAFUGUMRNX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public Texture2DArray HZDPPPMEYNQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		public float[] MVODARONVCP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public float[] CDGSTCLREWS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		public float[] THMYBHTVPJO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public Vector4[] JXQTZJFHCUK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public Texture2DArray DPQKJYQMDCK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public float[] KKWFWYMXWQH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public float[] PWXZKFBOKQG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public float[] RFXRDFETYOQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public Vector4[] HFQWPABONJM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		private int[] ZVIPTHYMSEL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public Texture2DArray MDRKIDDCKZC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public float[] OGBQPTHKLIX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public Vector4[] AYKMNOLDXBQ;

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x8F2D8C0", Offset = "0x8F2CAC0", VA = "0x188F2D8C0")]
		private Texture2DArray RIZPSIWLJOL(string a, IReadOnlyList<Texture2D> b, bool c, ShapeMaterialInfo[] d)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x8F2DDE0", Offset = "0x8F2CFE0", VA = "0x188F2DDE0")]
		public UPHJDWBVDKE(ShapeMaterialInfo[] a, bool b, bool c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x8F2D810", Offset = "0x8F2CA10", VA = "0x188F2D810")]
		private Vector3 LVEAVLJENTV(ShapeMaterialInfo a)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x8F2DB30", Offset = "0x8F2CD30", VA = "0x188F2DB30")]
		public int VZTZJQGDDCH(ShapeMaterial a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x8F2D7C0", Offset = "0x8F2C9C0", VA = "0x188F2D7C0", Slot = "4")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public interface SKLNPGLDXMI
	{
		[Cpp2IlInjected.Token(Token = "0x17000005")]
		bool THQRVRWZDAT
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		bool VAAJEYKBANG
		{
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		bool FPXIIMXEPGZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public interface DAZTDYLYFJB : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x17000008")]
		Texture2D OIIEYRDYGML
		{
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(Slot = "1")]
		Material JIXMKBDUHJH();

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(Slot = "2")]
		int PEWBGIBUAPH(ShapeColor a);

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(Slot = "3")]
		int VZTZJQGDDCH(ShapeMaterial a);

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void MSBZGPHTXNP(Material a);

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(Slot = "5")]
		AIIDXRKICBZ[] WTNQFCBHYBX();
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public interface EUHFJULRGTX
	{
		[Cpp2IlInjected.Token(Token = "0x17000009")]
		ColorRemap WDBPEROCBIC
		{
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		ColorRemap CVQPJSXZUKI
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(Slot = "0")]
		ShapeColorInfo AIPKYCPUISY(ShapeColor a, bool b = true);

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		bool ZVSMGGWQLTQ(ShapeColor a, [Out] Color b);
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public static class MMMIICMIXTW
	{
		[Cpp2IlInjected.Token(Token = "0x2000012")]
		private class SCBQJATVPFN : DAZTDYLYFJB, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400007F")]
			public UPHJDWBVDKE DJPMBWBRRZO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000080")]
			private readonly Texture2D YBAVMPTWQYC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000081")]
			private bool PLLGSBNELKJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
			[Cpp2IlInjected.Token(Token = "0x4000082")]
			private bool DGMBDHCAFQU;

			[Cpp2IlInjected.Token(Token = "0x4000083")]
			private static AIIDXRKICBZ[] MVTOSOAROQS;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000084")]
			private Texture2D FFRNEIKLSVJ;

			[Cpp2IlInjected.Token(Token = "0x1700000B")]
			public Texture2D OIIEYRDYGML
			{
				[Cpp2IlInjected.Token(Token = "0x6000034")]
				[Cpp2IlInjected.Address(RVA = "0x8F2BCC0", Offset = "0x8F2AEC0", VA = "0x188F2BCC0", Slot = "4")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x8F2BFC0", Offset = "0x8F2B1C0", VA = "0x188F2BFC0")]
			public SCBQJATVPFN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x8F2BBA0", Offset = "0x8F2ADA0", VA = "0x188F2BBA0")]
			private Color QKDUDXYACMJ(ShapeColorInfo a, EPMLESOSLJZ.ColorChannel b, Color c)
			{
				return default(Color);
			}

			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x8F2A770", Offset = "0x8F29970", VA = "0x188F2A770", Slot = "10")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x8F2B420", Offset = "0x8F2A620", VA = "0x188F2B420", Slot = "5")]
			public Material JIXMKBDUHJH()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x8F2A7F0", Offset = "0x8F299F0", VA = "0x188F2A7F0")]
			private void IMEKXTRPKYZ(Texture2D a, bool b, bool c)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x8F2BF80", Offset = "0x8F2B180", VA = "0x188F2BF80", Slot = "9")]
			public AIIDXRKICBZ[] WTNQFCBHYBX()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x8F2B520", Offset = "0x8F2A720", VA = "0x188F2B520", Slot = "8")]
			public void MSBZGPHTXNP(Material a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x8F2BA80", Offset = "0x8F2AC80", VA = "0x188F2BA80", Slot = "6")]
			public int PEWBGIBUAPH(ShapeColor a)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x8F2BF30", Offset = "0x8F2B130", VA = "0x188F2BF30", Slot = "7")]
			public int VZTZJQGDDCH(ShapeMaterial a)
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
			[Cpp2IlInjected.Address(RVA = "0x8F26030", Offset = "0x8F25230", VA = "0x188F26030", Slot = "4")]
			public bool Equals(MaterialHash other)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x8F26220", Offset = "0x8F25420", VA = "0x188F26220", Slot = "0")]
			public override bool Equals(object obj)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x8F262E0", Offset = "0x8F254E0", VA = "0x188F262E0", Slot = "2")]
			public override int GetHashCode()
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000067")]
		private static Dictionary<MaterialHash, Material> QLGJHGKEDCE;

		[Cpp2IlInjected.Token(Token = "0x4000068")]
		private static readonly int XDDCMITBIFB;

		[Cpp2IlInjected.Token(Token = "0x4000069")]
		private static readonly int JODAQWTGDWN;

		[Cpp2IlInjected.Token(Token = "0x400006A")]
		private static readonly int TGRRQARJBSN;

		[Cpp2IlInjected.Token(Token = "0x400006B")]
		private static readonly int ZFPECKBOXWI;

		[Cpp2IlInjected.Token(Token = "0x400006C")]
		private static readonly int EPZRHCKLZTQ;

		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private static readonly int DVAOCRPFINR;

		[Cpp2IlInjected.Token(Token = "0x400006E")]
		private static readonly int HDQTZSOWAHQ;

		[Cpp2IlInjected.Token(Token = "0x400006F")]
		private static readonly int CXZJTTKIZUL;

		[Cpp2IlInjected.Token(Token = "0x4000070")]
		private static readonly int AYCPYNCTGFE;

		[Cpp2IlInjected.Token(Token = "0x4000071")]
		private static readonly int WZOWASDMLNP;

		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private static readonly int OWBUZDWHXMV;

		[Cpp2IlInjected.Token(Token = "0x4000073")]
		private static readonly int KYLXGLFAKYH;

		[Cpp2IlInjected.Token(Token = "0x4000074")]
		private static readonly int ZUXWGPKICWP;

		[Cpp2IlInjected.Token(Token = "0x4000075")]
		private static readonly int LPZXWVVHCLZ;

		[Cpp2IlInjected.Token(Token = "0x4000076")]
		private static readonly int AZHCFSGYUOB;

		[Cpp2IlInjected.Token(Token = "0x4000077")]
		private static readonly int VELOMREGNYV;

		[Cpp2IlInjected.Token(Token = "0x4000078")]
		private static readonly int KEIBIDMKKYP;

		[Cpp2IlInjected.Token(Token = "0x4000079")]
		private static readonly int PUIAHSYDXTZ;

		[Cpp2IlInjected.Token(Token = "0x400007A")]
		private static readonly int LKOHDLFMLOX;

		[Cpp2IlInjected.Token(Token = "0x400007B")]
		private static readonly int CXQLILCNQUF;

		[Cpp2IlInjected.Token(Token = "0x400007C")]
		private static readonly int WYGNGNTDCVO;

		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public static readonly int BLSOFRQIRCO;

		[Cpp2IlInjected.Token(Token = "0x400007E")]
		public static readonly int DOPGEJOPFID;

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x8F259A0", Offset = "0x8F24BA0", VA = "0x188F259A0")]
		[RRPostPlayModeMethod(PostPlayModePhase.ExitingPlayMode, 0)]
		private static void JXUWADLHVLC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x8F25010", Offset = "0x8F24210", VA = "0x188F25010")]
		private static SKLNPGLDXMI BHQVLBHGPHP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x8F25A10", Offset = "0x8F24C10", VA = "0x188F25A10")]
		public static DAZTDYLYFJB QGGMIUNYLIX()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x8F25340", Offset = "0x8F24540", VA = "0x188F25340")]
		public static void JSUFEJCKCZH(this Material a, ShapeColor b, ShapeMaterial c, bool d, bool e, float f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x8F25410", Offset = "0x8F24610", VA = "0x188F25410")]
		public static void JSUFEJCKCZH(this Material a, ShapeColorInfo b, ShapeMaterialInfo c, bool d, bool e, float f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x8F25080", Offset = "0x8F24280", VA = "0x188F25080")]
		public static Material CGTPCQQDCNH(ShapeColorInfo a, ShapeMaterialInfo b, bool c, bool d)
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
				[Cpp2IlInjected.Address(RVA = "0x8F24FD0", Offset = "0x8F241D0", VA = "0x188F24FD0")]
				public KeyVal()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x8F2CC60", Offset = "0x8F2BE60", VA = "0x188F2CC60")]
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
		protected override bool CMDPQKPEDTH
		{
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0xB017C0", Offset = "0xB009C0", VA = "0x180B017C0", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x8F2CCA0", Offset = "0x8F2BEA0", VA = "0x188F2CCA0")]
		public ShapeConfig()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public static class TYYLRMLUXNQ
	{
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		public static readonly ShapeType[] YHJNDXRGGPH;

		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		public static readonly int[] VFXOJNHSSKW;

		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		public static readonly PrimitiveShapeMeshType[] BDWDSEWAUMK;

		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		private static readonly Dictionary<ShapeType, int> LFYERYTYIAG;

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x8F2D030", Offset = "0x8F2C230", VA = "0x188F2D030")]
		private static Dictionary<ShapeType, int> OECLYRKAUQZ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x8F2D1E0", Offset = "0x8F2C3E0", VA = "0x188F2D1E0")]
		public static PrimitiveShapeMeshType TLTPDAYOWZJ(this ShapeType a)
		{
			return default(PrimitiveShapeMeshType);
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x8F2CF20", Offset = "0x8F2C120", VA = "0x188F2CF20")]
		public static int DNQDDNDATYC(this ShapeType a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x8F2CF90", Offset = "0x8F2C190", VA = "0x188F2CF90")]
		public static int KJQVTUZVVCV(this ShapeType a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x1435B10", Offset = "0x1434D10", VA = "0x181435B10")]
		public static bool CZCOUKXTEEY(this ShapeType a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x869ACD0", Offset = "0x8699ED0", VA = "0x18869ACD0")]
		public static bool PQQLXBTBRBU(this ShapeType a)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	public class FSNDHFJDNAK : EUHFJULRGTX
	{
		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public ColorRemap WDBPEROCBIC
		{
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x8F24940", Offset = "0x8F23B40", VA = "0x188F24940", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public ColorRemap CVQPJSXZUKI
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x8F24A50", Offset = "0x8F23C50", VA = "0x188F24A50", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0xABDFB0", Offset = "0xABD1B0", VA = "0x180ABDFB0")]
		[UnityEngine.Scripting.Preserve]
		internal FSNDHFJDNAK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x8F24B00", Offset = "0x8F23D00", VA = "0x188F24B00")]
		[OCFGNIRMEEE.Root]
		internal static void XXZSNELNZLP(CYZVJPHMMVM a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x8F249F0", Offset = "0x8F23BF0", VA = "0x188F249F0", Slot = "4")]
		public ShapeColorInfo AIPKYCPUISY(ShapeColor a, bool b = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x8F24BF0", Offset = "0x8F23DF0", VA = "0x188F24BF0", Slot = "5")]
		public bool ZVSMGGWQLTQ(ShapeColor a, [Out] Color b)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public static class NTPTJOIVUPO
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
		public static CVEDYLCEYBQ LHZFCXXJFRP;

		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		private static Material ZVPVAXPDRDQ;

		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		private static Material FFYFEFCXCXK;

		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		private static bool YFCIMIARCYS;

		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		private static DAZTDYLYFJB QJHGNVIFFDX;

		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		private static readonly CollisionMeshData[] JPBGIUZGVKK;

		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		private static CollisionMeshData UNFLZFLBTTM;

		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		private static int[] ZCPUZDDDDBF;

		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		private static int[] KIBEKSIFCVL;

		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		private static readonly KRGSIBWZYGX<ShapeColor, ShapeColorInfo> SAQHLOXMXMV;

		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		public static readonly Dictionary<string, EnumChoiceData> XOUJKDBMEJB;

		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		public static readonly Dictionary<int, string> XOZQHJVJNUK;

		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		private static readonly Vector3[] KEIPYMTRYLS;

		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		public static readonly Dictionary<string, EnumChoiceData> XNJHYYFZIIC;

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public static ShapeConfig UKIVWIIHBUK
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x8F29190", Offset = "0x8F28390", VA = "0x188F29190")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		private static DAZTDYLYFJB ZFTMVPENXMK
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x8F290F0", Offset = "0x8F282F0", VA = "0x188F290F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public static Texture2D OIIEYRDYGML
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x8F289F0", Offset = "0x8F27BF0", VA = "0x188F289F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public static ColorRemap WDBPEROCBIC
		{
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x8F263E0", Offset = "0x8F255E0", VA = "0x188F263E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public static ColorRemap CVQPJSXZUKI
		{
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0x8F276B0", Offset = "0x8F268B0", VA = "0x188F276B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public static ShapeColorInfo[] QHOOLEQVSHL
		{
			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x8F27BC0", Offset = "0x8F26DC0", VA = "0x188F27BC0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public static ShapeMaterialInfo[] OEDTEDKMQAZ
		{
			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x8F29070", Offset = "0x8F28270", VA = "0x188F29070")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public static int SBHGANPPAUD
		{
			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0x1D59990", Offset = "0x1D58B90", VA = "0x181D59990")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		private static int[] RPXZPMIZMXM
		{
			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0x8F28AD0", Offset = "0x8F27CD0", VA = "0x188F28AD0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		private static int[] VKIKLMZQWJA
		{
			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0x8F27730", Offset = "0x8F26930", VA = "0x188F27730")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public static Shader FYMQGTNPIGP
		{
			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x8F27630", Offset = "0x8F26830", VA = "0x188F27630")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public static Material ETGQOXBVXYR
		{
			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x8F26920", Offset = "0x8F25B20", VA = "0x188F26920")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x8F292E0", Offset = "0x8F284E0", VA = "0x188F292E0")]
		private static void WCHGHKQEBKB(Scene a, LoadSceneMode b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x8F29C80", Offset = "0x8F28E80", VA = "0x188F29C80")]
		public static GameObject YCUYBRRAUQJ(ShapeType a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x8F291C0", Offset = "0x8F283C0", VA = "0x188F291C0")]
		public static GameObject VKJNKYMKLUH(ShapeType a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x8F26780", Offset = "0x8F25980", VA = "0x188F26780")]
		private static Mesh AOUOPAKFVSG(ShapeType a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x8F29DF0", Offset = "0x8F28FF0", VA = "0x188F29DF0")]
		public static bool YQPTAWIDKRP(ShapeType a, [Out] Mesh b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x8F26EC0", Offset = "0x8F260C0", VA = "0x188F26EC0")]
		private static void CFRTYFBXUAY()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x8F29D20", Offset = "0x8F28F20", VA = "0x188F29D20")]
		public static Material YIGZDOVGKFO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x8F29360", Offset = "0x8F28560", VA = "0x188F29360")]
		public static Material WGPHOBRHXJW()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x8F26C30", Offset = "0x8F25E30", VA = "0x188F26C30")]
		public static Vector3 BZMNVQGMFOU(Vector3 a, Quaternion b, ShapeMaterial c)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x8F272E0", Offset = "0x8F264E0", VA = "0x188F272E0")]
		private static Vector3 CIDTBKFSUHO(Vector3 a, Quaternion b, ShapeMaterial c, bool d)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x8F29F80", Offset = "0x8F29180", VA = "0x188F29F80")]
		public static void ZWXKMPGYKUT(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x8F28870", Offset = "0x8F27A70", VA = "0x188F28870")]
		public static int PEWBGIBUAPH(ShapeColor a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x8F29260", Offset = "0x8F28460", VA = "0x188F29260")]
		public static int VZTZJQGDDCH(ShapeMaterial a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x8F26DE0", Offset = "0x8F25FE0", VA = "0x188F26DE0")]
		[RRPostPlayModeMethod(PostPlayModePhase.ExitingPlayMode, 0)]
		private static void CFPUPOLONOW()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x8F29640", Offset = "0x8F28840", VA = "0x188F29640")]
		public static CollisionMeshData XICWVHSDWQG(ShapeType a)
		{
			return default(CollisionMeshData);
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x8F27CB0", Offset = "0x8F26EB0", VA = "0x188F27CB0")]
		public static CollisionMeshData KAGRBQXFBPY()
		{
			return default(CollisionMeshData);
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x8F269A0", Offset = "0x8F25BA0", VA = "0x188F269A0")]
		public static string BVDVSZCLBNA(ShapeType a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x8F28F50", Offset = "0x8F28150", VA = "0x188F28F50")]
		public static Bounds UJIYRJVUXHO(ShapeType a)
		{
			return default(Bounds);
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x8F27130", Offset = "0x8F26330", VA = "0x188F27130")]
		public static int CFWCWTLMNFD(ShapeType a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x8F29ED0", Offset = "0x8F290D0", VA = "0x188F29ED0")]
		public static bool ZVSMGGWQLTQ(ShapeColor a, [Out] Color b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x8F289D0", Offset = "0x8F27BD0", VA = "0x188F289D0")]
		public static int QOZEBKJDADR(int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x8F27D80", Offset = "0x8F26F80", VA = "0x188F27D80")]
		public static int LBNKPPZQTTA(int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x8F27C40", Offset = "0x8F26E40", VA = "0x188F27C40")]
		public static Color JTCGEBDXGDY(ShapeColor a)
		{
			return default(Color);
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x8F28D50", Offset = "0x8F27F50", VA = "0x188F28D50")]
		public static bool SGEYMITAWNR(ShapeType a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x8F27FA0", Offset = "0x8F271A0", VA = "0x188F27FA0")]
		public static int LMBFKCWAWSR(ShapeType a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x8F26460", Offset = "0x8F25660", VA = "0x188F26460")]
		[NotNull]
		public static ShapeColorInfo AIPKYCPUISY(ShapeColor a, bool b = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x8F284A0", Offset = "0x8F276A0", VA = "0x188F284A0")]
		public static ShapeMaterialInfo NZDTBBYQFUI(ShapeMaterial a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x8F27DA0", Offset = "0x8F26FA0", VA = "0x188F27DA0")]
		public static float LHCRECTWQRL(int a)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x8F26A40", Offset = "0x8F25C40", VA = "0x188F26A40")]
		public static int BWEIYAKHSIX(int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x8F28D70", Offset = "0x8F27F70", VA = "0x188F28D70")]
		public static int SGTSSEASRDL(int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x8F288F0", Offset = "0x8F27AF0", VA = "0x188F288F0")]
		public static Vector3 PHMAQTOJONL(ShapeType a)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x8F279A0", Offset = "0x8F26BA0", VA = "0x188F279A0")]
		public static float FRRLMZRCYAS(ShapeType a, Vector3 b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x8F299C0", Offset = "0x8F28BC0", VA = "0x188F299C0")]
		public static void XMYNDAGMDVL(bool a = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x8F29430", Offset = "0x8F28630", VA = "0x188F29430")]
		private static void XEJJBBIOMTY()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x8F28070", Offset = "0x8F27270", VA = "0x188F28070")]
		public static void NESTVZMXJHM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x8F28540", Offset = "0x8F27740", VA = "0x188F28540")]
		public static void ONYMDEZKQSL()
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
