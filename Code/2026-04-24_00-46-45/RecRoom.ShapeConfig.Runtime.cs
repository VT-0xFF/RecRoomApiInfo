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
		[Cpp2IlInjected.Address(RVA = "0xA4E0410", Offset = "0xA4DEE10", VA = "0x18A4E0410", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x2A2E140", Offset = "0x2A2CB40", VA = "0x182A2E140")]
		public _AssemblyIndex()
		{
		}
	}
}
namespace RecRoom
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public static class KSSDQNNAHWT
	{
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public static readonly int FFEJWWFVBEG;

		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public static readonly int RRDKIIPBFIP;

		[Cpp2IlInjected.Token(Token = "0x4000003")]
		public static readonly int LEAPYGXXPKP;

		[Cpp2IlInjected.Token(Token = "0x4000004")]
		public static readonly int TYXFKNCOGMR;

		[Cpp2IlInjected.Token(Token = "0x4000005")]
		public static readonly int DKIQDUEODQP;

		[Cpp2IlInjected.Token(Token = "0x4000006")]
		public static readonly int CKPIVBPKUCP;

		[Cpp2IlInjected.Token(Token = "0x4000007")]
		public static readonly int QGZNPPYUNAL;

		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public static readonly int BJOELCKIJIP;

		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public static readonly int UOMUSMBJCUQ;

		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public static readonly int PBBZWUGUAKZ;

		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public static readonly int UCQVIDTIODL;

		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public static readonly int BRONLDBBJSV;

		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public static readonly int WYCLSGBBEDT;

		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public static readonly int IOVZMRZETPP;

		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public static readonly int FIPZAIGSXMH;

		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public static readonly int WMTMXABLPQE;

		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public static readonly int VMEFSACNIFO;

		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public static readonly int PGNJNEFRLSU;

		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public static readonly int BBCKJMVXUIO;

		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public static readonly int MJMTEOGVVOA;

		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public static readonly int UCNSTNQIPZV;

		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public static readonly int ACZUPNXLIIE;

		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public static readonly int EGZUOZPKKEC;

		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public static readonly int FFOFXZGXUST;

		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public static readonly int SEJVEDKUWTE;

		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public static readonly int BMYVBONULDP;

		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public static readonly int RVRFTEOCTHL;

		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public static readonly int ZCQDEUBJHRK;
	}
}
namespace RecRoom.Core.Creation
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public class MNZCRXQDBVF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public readonly int PLHOPXIWLAQ;

		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private static MNZCRXQDBVF INNQHEASDIB;

		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private static MNZCRXQDBVF PZSRPEFHKKK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private readonly int GLHBVBTOFIA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private readonly int GNXNLLSFXZN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private readonly int GONIDFZYAHO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private readonly float RVCUQCZJMCF;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public static MNZCRXQDBVF DSJJPRUDGRU
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0xA4D9160", Offset = "0xA4D7B60", VA = "0x18A4D9160")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public static MNZCRXQDBVF PBIKQKCOVQJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0xA4D9360", Offset = "0xA4D7D60", VA = "0x18A4D9360")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xA4D9410", Offset = "0xA4D7E10", VA = "0x18A4D9410")]
		public MNZCRXQDBVF(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0xA4D9280", Offset = "0xA4D7C80", VA = "0x18A4D9280")]
		public int MFVEZYJKQSN(Color a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0xA4D9210", Offset = "0xA4D7C10", VA = "0x18A4D9210")]
		public Color ETQPNNDLWGR(int a)
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
		[Cpp2IlInjected.Address(RVA = "0xA4D54C0", Offset = "0xA4D3EC0", VA = "0x18A4D54C0")]
		public float MQHKQNQUMSP(float a, Vector2 b, bool c)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xA4D53D0", Offset = "0xA4D3DD0", VA = "0x18A4D53D0")]
		public Color MQHKQNQUMSP(float a, float b, float c)
		{
			return default(Color);
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0xA4D5510", Offset = "0xA4D3F10", VA = "0x18A4D5510")]
		public ColorRemap()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public static class EFJNZCLEPJH
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
		[Cpp2IlInjected.Address(RVA = "0xA4D5C30", Offset = "0xA4D4630", VA = "0x18A4D5C30")]
		public static Texture2D SBZQHKXJKTE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0xA4D56F0", Offset = "0xA4D40F0", VA = "0x18A4D56F0")]
		public static Texture2D AHYJKJVHBQY(Func<ShapeColorInfo, ColorChannel, Color, Color> a, string b = "LegacyColorTexture")
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0xA4D5540", Offset = "0xA4D3F40", VA = "0x18A4D5540")]
		[CompilerGenerated]
		internal static void AFNUNYTYCUR(ShapeColorInfo a, int b, <>c__DisplayClass2_0 c)
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
		private static XUNVVSLJRUP BONNUNOTFGJ;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		private static XUNVVSLJRUP BWAOGJSVNKW
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0xA4DB840", Offset = "0xA4DA240", VA = "0x18A4DB840")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public Color Additive
		{
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0xA4DB910", Offset = "0xA4DA310", VA = "0x18A4DB910")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0xA4DAF30", Offset = "0xA4D9930", VA = "0x18A4DAF30")]
		public static ShapeColor EBLLMJWKYFD(Color a, MNZCRXQDBVF b)
		{
			return default(ShapeColor);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0xA4DB000", Offset = "0xA4D9A00", VA = "0x18A4DB000")]
		public static ShapeColor EBLLMJWKYFD(Color a)
		{
			return default(ShapeColor);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0xA4DB600", Offset = "0xA4DA000", VA = "0x18A4DB600")]
		public static ShapeColorInfo QZJRQPTBBXZ(ShapeColor a, MNZCRXQDBVF b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0xA4DB0F0", Offset = "0xA4D9AF0", VA = "0x18A4DB0F0")]
		public static ShapeColorInfo ESHEQUXVFST(ShapeColor a, MNZCRXQDBVF b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0xA4DB2F0", Offset = "0xA4D9CF0", VA = "0x18A4DB2F0")]
		public static bool QOBGZHVFRDH(Color a, [Out] ShapeColorInfo b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
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
		[Cpp2IlInjected.Address(RVA = "0xA4DBCA0", Offset = "0xA4DA6A0", VA = "0x18A4DBCA0")]
		public ShapeMaterialInfo()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0xA4DBC10", Offset = "0xA4DA610", VA = "0x18A4DBC10")]
		public ShapeMaterialInfo(ShapeMaterialInfo other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0xA4DBBB0", Offset = "0xA4DA5B0", VA = "0x18A4DBBB0")]
		public void CopyTo(ShapeMaterialInfo shapeMaterialInfo)
		{
		}
	}
}
namespace RecRoom.Core.Creation.Shapes
{
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class GCTNZUZKFMG : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private static readonly int FQHKNUXNERG;

		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private static readonly int LOAHHQKLFOP;

		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private static readonly int OLQGABXNRDO;

		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private static readonly int MTNGTMUCVWW;

		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private static readonly int SOIYBVAHDRC;

		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private static readonly int LYLHGOASKOD;

		[Cpp2IlInjected.Token(Token = "0x400004D")]
		private static readonly int UWCWCYLYYBA;

		[Cpp2IlInjected.Token(Token = "0x400004E")]
		private static readonly int YWJQLZSOLFK;

		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private static readonly int ZCMQELEEIKE;

		[Cpp2IlInjected.Token(Token = "0x4000050")]
		private static readonly int GWOAJDZSYDE;

		[Cpp2IlInjected.Token(Token = "0x4000051")]
		private static readonly int RPTCTZHARIO;

		[Cpp2IlInjected.Token(Token = "0x4000052")]
		private static readonly int WDQHUOILQVG;

		[Cpp2IlInjected.Token(Token = "0x4000053")]
		private static readonly int GLJYAQWIMQA;

		[Cpp2IlInjected.Token(Token = "0x4000054")]
		private static readonly int ZKZQBLEQHWC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public ShapeMaterialInfo[] YBLTUMQKMPW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public Texture2DArray DKUISGYOARS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public Texture2DArray JSOJQFHNHCA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public float[] JWPMKYEHLRF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public Texture2DArray RRGXVAPXBNK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		public float[] UOFQUPZQAYR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public float[] QBSOOSJFOMQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		public float[] ZHJHPJRSJAO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public Vector4[] GAPQJMRVMVK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public Texture2DArray LADRNGFFTHG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public float[] WAFZGRKMXKZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public float[] ZXIBANYBVRK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public float[] MAQZRZETJKK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public Vector4[] XZQRFNGWZJO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		private int[] FHRRWGDEKAB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public Texture2DArray HJMWGNBUQDQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public float[] OLWEYEOZHAJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public Vector4[] LKQRFDBAIBW;

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0xA4D5F30", Offset = "0xA4D4930", VA = "0x18A4D5F30")]
		private Texture2DArray WSFRWEVNCAF(string a, IReadOnlyList<Texture2D> b, bool c, ShapeMaterialInfo[] d)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0xA4D6480", Offset = "0xA4D4E80", VA = "0x18A4D6480")]
		public GCTNZUZKFMG(ShapeMaterialInfo[] a, bool b, bool c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0xA4D5E80", Offset = "0xA4D4880", VA = "0x18A4D5E80")]
		private Vector3 MRFYEYIWNZH(ShapeMaterialInfo a)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0xA4D61A0", Offset = "0xA4D4BA0", VA = "0x18A4D61A0")]
		public int ZGTUURXQRFX(ShapeMaterial a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0xA4D5E30", Offset = "0xA4D4830", VA = "0x18A4D5E30", Slot = "4")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public interface MTOTYGMECJE
	{
		[Cpp2IlInjected.Token(Token = "0x17000005")]
		bool AZTEFZPHNSJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		bool SLCERHQWALA
		{
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		bool IZZDZAZAMGT
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public interface VCAFVTUIZZH : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x17000008")]
		Texture2D SWTZMOGVAGZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(Slot = "1")]
		Material IQUXDVNGJOH();

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(Slot = "2")]
		int RKGWSZDCMCP(ShapeColor a);

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(Slot = "3")]
		int ZGTUURXQRFX(ShapeMaterial a);

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void TLJPRUAZNML(Material a);

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(Slot = "5")]
		EXYLACFZZRD[] FKUBJCHOUFR();
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public interface XUNVVSLJRUP
	{
		[Cpp2IlInjected.Token(Token = "0x17000009")]
		ColorRemap PXMPRSUEFUY
		{
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		ColorRemap BCHWKGASPPY
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(Slot = "0")]
		ShapeColorInfo EMWMMZLITRA(ShapeColor a, bool b = true);

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		bool HVNLUJYHOUE(ShapeColor a, [Out] Color b);
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public static class QPDCDQZYFPU
	{
		[Cpp2IlInjected.Token(Token = "0x2000012")]
		private class HFZBKJNONPX : VCAFVTUIZZH, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400007F")]
			public GCTNZUZKFMG BESDQVURKGS;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000080")]
			private readonly Texture2D ITQZJPYXOKA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000081")]
			private bool AFSCIYKCERV;

			[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
			[Cpp2IlInjected.Token(Token = "0x4000082")]
			private bool ICWDLLKNPFA;

			[Cpp2IlInjected.Token(Token = "0x4000083")]
			private static EXYLACFZZRD[] YAVDNXTFIBS;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000084")]
			private Texture2D CEOUIFISZFH;

			[Cpp2IlInjected.Token(Token = "0x1700000B")]
			public Texture2D SWTZMOGVAGZ
			{
				[Cpp2IlInjected.Token(Token = "0x6000034")]
				[Cpp2IlInjected.Address(RVA = "0xA4D7240", Offset = "0xA4D5C40", VA = "0x18A4D7240", Slot = "4")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0xA4D8A70", Offset = "0xA4D7470", VA = "0x18A4D8A70")]
			public HFZBKJNONPX()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0xA4D7710", Offset = "0xA4D6110", VA = "0x18A4D7710")]
			private Color SKNBWIXPLTR(ShapeColorInfo a, EFJNZCLEPJH.ColorChannel b, Color c)
			{
				return default(Color);
			}

			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0xA4D71C0", Offset = "0xA4D5BC0", VA = "0x18A4D71C0", Slot = "10")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0xA4D74F0", Offset = "0xA4D5EF0", VA = "0x18A4D74F0", Slot = "5")]
			public Material IQUXDVNGJOH()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0xA4D7DC0", Offset = "0xA4D67C0", VA = "0x18A4D7DC0")]
			private void WVNFWWZQPMP(Texture2D a, bool b, bool c)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0xA4D74B0", Offset = "0xA4D5EB0", VA = "0x18A4D74B0", Slot = "9")]
			public EXYLACFZZRD[] FKUBJCHOUFR()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0xA4D7830", Offset = "0xA4D6230", VA = "0x18A4D7830", Slot = "8")]
			public void TLJPRUAZNML(Material a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0xA4D75F0", Offset = "0xA4D5FF0", VA = "0x18A4D75F0", Slot = "6")]
			public int RKGWSZDCMCP(ShapeColor a)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0xA4D8A20", Offset = "0xA4D7420", VA = "0x18A4D8A20", Slot = "7")]
			public int ZGTUURXQRFX(ShapeMaterial a)
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
			[Cpp2IlInjected.Address(RVA = "0xA4D9470", Offset = "0xA4D7E70", VA = "0x18A4D9470", Slot = "4")]
			public bool Equals(MaterialHash other)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0xA4D9660", Offset = "0xA4D8060", VA = "0x18A4D9660", Slot = "0")]
			public override bool Equals(object obj)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0xA4D9720", Offset = "0xA4D8120", VA = "0x18A4D9720", Slot = "2")]
			public override int GetHashCode()
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000067")]
		private static Dictionary<MaterialHash, Material> WNGQUNQHSWO;

		[Cpp2IlInjected.Token(Token = "0x4000068")]
		private static readonly int FETEYNIHCJH;

		[Cpp2IlInjected.Token(Token = "0x4000069")]
		private static readonly int OVMBEMRTVWD;

		[Cpp2IlInjected.Token(Token = "0x400006A")]
		private static readonly int SPRZPBPVQRJ;

		[Cpp2IlInjected.Token(Token = "0x400006B")]
		private static readonly int UMYRCFGQZQK;

		[Cpp2IlInjected.Token(Token = "0x400006C")]
		private static readonly int WYXEUYUCCLG;

		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private static readonly int KGRVHIRWSZT;

		[Cpp2IlInjected.Token(Token = "0x400006E")]
		private static readonly int AXWZEVJQLWM;

		[Cpp2IlInjected.Token(Token = "0x400006F")]
		private static readonly int CDJDYQCQYVT;

		[Cpp2IlInjected.Token(Token = "0x4000070")]
		private static readonly int UPVZCUMLQRO;

		[Cpp2IlInjected.Token(Token = "0x4000071")]
		private static readonly int CDHNHZPQDQT;

		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private static readonly int MXIQNLUWZLZ;

		[Cpp2IlInjected.Token(Token = "0x4000073")]
		private static readonly int KDQBFQVYYQJ;

		[Cpp2IlInjected.Token(Token = "0x4000074")]
		private static readonly int JZRVZCFZUHD;

		[Cpp2IlInjected.Token(Token = "0x4000075")]
		private static readonly int NVOHHKRGCPT;

		[Cpp2IlInjected.Token(Token = "0x4000076")]
		private static readonly int DEIPRLDFJPR;

		[Cpp2IlInjected.Token(Token = "0x4000077")]
		private static readonly int IGBURNSDPHJ;

		[Cpp2IlInjected.Token(Token = "0x4000078")]
		private static readonly int IQRHQGFHYDL;

		[Cpp2IlInjected.Token(Token = "0x4000079")]
		private static readonly int FVSISFVMJGZ;

		[Cpp2IlInjected.Token(Token = "0x400007A")]
		private static readonly int FRBKUHSKKUZ;

		[Cpp2IlInjected.Token(Token = "0x400007B")]
		private static readonly int ZYUOBWUQDMH;

		[Cpp2IlInjected.Token(Token = "0x400007C")]
		private static readonly int LAKZLAIYZBM;

		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public static readonly int SOIYBVAHDRC;

		[Cpp2IlInjected.Token(Token = "0x400007E")]
		public static readonly int DGWAPXPCZUN;

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0xA4DA9E0", Offset = "0xA4D93E0", VA = "0x18A4DA9E0")]
		[RRPostPlayModeMethod(PostPlayModePhase.ExitingPlayMode, 0)]
		private static void MISXSDFTVGW()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0xA4DAA50", Offset = "0xA4D9450", VA = "0x18A4DAA50")]
		private static MTOTYGMECJE WDBFSHXYGVF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0xA4DA510", Offset = "0xA4D8F10", VA = "0x18A4DA510")]
		public static VCAFVTUIZZH GRORIFQILJD()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0xA4DA440", Offset = "0xA4D8E40", VA = "0x18A4DA440")]
		public static void CLBAKSLBLLN(this Material a, ShapeColor b, ShapeMaterial c, bool d, bool e, float f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0xA4D9E80", Offset = "0xA4D8880", VA = "0x18A4D9E80")]
		public static void CLBAKSLBLLN(this Material a, ShapeColorInfo b, ShapeMaterialInfo c, bool d, bool e, float f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0xA4DA710", Offset = "0xA4D9110", VA = "0x18A4DA710")]
		public static Material HFOHBWBUTNJ(ShapeColorInfo a, ShapeMaterialInfo b, bool c, bool d)
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
				[Cpp2IlInjected.Address(RVA = "0xA4D9120", Offset = "0xA4D7B20", VA = "0x18A4D9120")]
				public KeyVal()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0xA4DBA10", Offset = "0xA4DA410", VA = "0x18A4DBA10")]
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
		protected override bool BSKBGSLAWYH
		{
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0xD5C320", Offset = "0xD5AD20", VA = "0x180D5C320", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0xA4DBA50", Offset = "0xA4DA450", VA = "0x18A4DBA50")]
		public ShapeConfig()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public static class QAWQIPBOHWU
	{
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		public static readonly ShapeType[] SONUVOMWMZF;

		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		public static readonly int[] CTJMIKLICWA;

		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		public static readonly PrimitiveShapeMeshType[] UUHMOXXXHUA;

		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		private static readonly Dictionary<ShapeType, int> IYWPYZYUISY;

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0xA4D99A0", Offset = "0xA4D83A0", VA = "0x18A4D99A0")]
		private static Dictionary<ShapeType, int> YUNHTNHYDZN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0xA4D9820", Offset = "0xA4D8220", VA = "0x18A4D9820")]
		public static PrimitiveShapeMeshType AOTIRDKNGVL(this ShapeType a)
		{
			return default(PrimitiveShapeMeshType);
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0xA4D9890", Offset = "0xA4D8290", VA = "0x18A4D9890")]
		public static int FOCARUMLFMI(this ShapeType a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0xA4D9900", Offset = "0xA4D8300", VA = "0x18A4D9900")]
		public static int LNIUCZSIQVN(this ShapeType a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x16CF2B0", Offset = "0x16CDCB0", VA = "0x1816CF2B0")]
		public static bool RVDHRGHZIDA(this ShapeType a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x9C3DDE0", Offset = "0x9C3C7E0", VA = "0x189C3DDE0")]
		public static bool ZTWEXTUVCGM(this ShapeType a)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	public class CALMDBUEPJK : XUNVVSLJRUP
	{
		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public ColorRemap PXMPRSUEFUY
		{
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0xA4D5270", Offset = "0xA4D3C70", VA = "0x18A4D5270", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public ColorRemap BCHWKGASPPY
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0xA4D5320", Offset = "0xA4D3D20", VA = "0x18A4D5320", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
		[UnityEngine.Scripting.Preserve]
		internal CALMDBUEPJK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0xA4D5040", Offset = "0xA4D3A40", VA = "0x18A4D5040")]
		[BRMSZAJTATI.Root]
		internal static void BZJNQHTNBAL(ZUKUOYIIEVW a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0xA4D5130", Offset = "0xA4D3B30", VA = "0x18A4D5130", Slot = "4")]
		public ShapeColorInfo EMWMMZLITRA(ShapeColor a, bool b = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0xA4D5190", Offset = "0xA4D3B90", VA = "0x18A4D5190", Slot = "5")]
		public bool HVNLUJYHOUE(ShapeColor a, [Out] Color b)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public static class WZFFILIGBZY
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
		public static JOLHGBMRDLK YDUFTEHMADJ;

		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		private static Material UFWHSOHWPKQ;

		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		private static Material PTWPVGTHKCW;

		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		private static bool DFCEQNWIAFC;

		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		private static VCAFVTUIZZH GLESTZXENJV;

		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		private static readonly CollisionMeshData[] JKGWTIJPZSU;

		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		private static CollisionMeshData CAKDWSTOWPC;

		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		private static int[] RDYHOBEKJQF;

		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		private static int[] PMQCMOUKZCT;

		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		private static readonly FWVAIRCWSGZ<ShapeColor, ShapeColorInfo> IMQEROOCHFB;

		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		public static readonly Dictionary<string, EnumChoiceData> FBEXHQZWRJX;

		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		public static readonly Dictionary<int, string> FAPCPWSEPBW;

		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		private static readonly Vector3[] LUZASNFSNGO;

		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		public static readonly Dictionary<string, EnumChoiceData> PABKHPRQFCM;

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public static ShapeConfig TDKUBDRZQTS
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0xA4DC070", Offset = "0xA4DAA70", VA = "0x18A4DC070")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		private static VCAFVTUIZZH IXEJVVSAQRG
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0xA4DF0B0", Offset = "0xA4DDAB0", VA = "0x18A4DF0B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public static Texture2D SWTZMOGVAGZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0xA4DC8E0", Offset = "0xA4DB2E0", VA = "0x18A4DC8E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public static ColorRemap PXMPRSUEFUY
		{
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0xA4DE3B0", Offset = "0xA4DCDB0", VA = "0x18A4DE3B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public static ColorRemap BCHWKGASPPY
		{
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0xA4DE430", Offset = "0xA4DCE30", VA = "0x18A4DE430")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public static ShapeColorInfo[] VQSENVWPGZZ
		{
			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0xA4DC2A0", Offset = "0xA4DACA0", VA = "0x18A4DC2A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public static ShapeMaterialInfo[] NBFEKETBKNJ
		{
			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0xA4DCF90", Offset = "0xA4DB990", VA = "0x18A4DCF90")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public static int IGWWFUNSEFH
		{
			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0x1FFA9C0", Offset = "0x1FF93C0", VA = "0x181FFA9C0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		private static int[] OBPMEQQYZZS
		{
			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0xA4DD010", Offset = "0xA4DBA10", VA = "0x18A4DD010")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		private static int[] FTKENRUTLKQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0xA4DD2A0", Offset = "0xA4DBCA0", VA = "0x18A4DD2A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public static Shader QDVCXQKQQJL
		{
			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0xA4DE4B0", Offset = "0xA4DCEB0", VA = "0x18A4DE4B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public static Material EQWRUNMAQLN
		{
			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0xA4DC320", Offset = "0xA4DAD20", VA = "0x18A4DC320")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0xA4DCAA0", Offset = "0xA4DB4A0", VA = "0x18A4DCAA0")]
		private static void GKHKPNBAOWD(Scene a, LoadSceneMode b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0xA4DBFD0", Offset = "0xA4DA9D0", VA = "0x18A4DBFD0")]
		public static GameObject AZNDQUSBHTN(ShapeType a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0xA4DDFC0", Offset = "0xA4DC9C0", VA = "0x18A4DDFC0")]
		public static GameObject KPXCZYEPEMB(ShapeType a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0xA4DE610", Offset = "0xA4DD010", VA = "0x18A4DE610")]
		private static Mesh QRXLNDQPZPO(ShapeType a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0xA4DE2D0", Offset = "0xA4DCCD0", VA = "0x18A4DE2D0")]
		public static bool ORLNDBWZPZF(ShapeType a, [Out] Mesh b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0xA4DD9F0", Offset = "0xA4DC3F0", VA = "0x18A4DD9F0")]
		private static void JTIRILNHZOG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0xA4DD920", Offset = "0xA4DC320", VA = "0x18A4DD920")]
		public static Material JRPHDNCWYXI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0xA4DCE10", Offset = "0xA4DB810", VA = "0x18A4DCE10")]
		public static Material HJVZDIDORLE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0xA4DC730", Offset = "0xA4DB130", VA = "0x18A4DC730")]
		public static Vector3 FBVAFBDZEYO(Vector3 a, Quaternion b, ShapeMaterial c)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0xA4DED60", Offset = "0xA4DD760", VA = "0x18A4DED60")]
		private static Vector3 UEJCAEYIBUK(Vector3 a, Quaternion b, ShapeMaterial c, bool d)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0xA4DD530", Offset = "0xA4DBF30", VA = "0x18A4DD530")]
		public static void JEZWAFILJBP(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0xA4DE7B0", Offset = "0xA4DD1B0", VA = "0x18A4DE7B0")]
		public static int RKGWSZDCMCP(ShapeColor a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0xA4DFD00", Offset = "0xA4DE700", VA = "0x18A4DFD00")]
		public static int ZGTUURXQRFX(ShapeMaterial a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0xA4DFC10", Offset = "0xA4DE610", VA = "0x18A4DFC10")]
		[RRPostPlayModeMethod(PostPlayModePhase.ExitingPlayMode, 0)]
		private static void YIQLULYRJJS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0xA4DF150", Offset = "0xA4DDB50", VA = "0x18A4DF150")]
		public static CollisionMeshData UIGUPEYMAOM(ShapeType a)
		{
			return default(CollisionMeshData);
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0xA4DE530", Offset = "0xA4DCF30", VA = "0x18A4DE530")]
		public static CollisionMeshData QPAWXILSXEY()
		{
			return default(CollisionMeshData);
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0xA4DE230", Offset = "0xA4DCC30", VA = "0x18A4DE230")]
		public static string NXMLUQNBEBS(ShapeType a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0xA4DDEA0", Offset = "0xA4DC8A0", VA = "0x18A4DDEA0")]
		public static Bounds KNCFRMKQSAK(ShapeType a)
		{
			return default(Bounds);
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0xA4DE060", Offset = "0xA4DCA60", VA = "0x18A4DE060")]
		public static int KRJFNMUXVMP(ShapeType a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0xA4DCEE0", Offset = "0xA4DB8E0", VA = "0x18A4DCEE0")]
		public static bool HVNLUJYHOUE(ShapeColor a, [Out] Color b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0xA4DCB20", Offset = "0xA4DB520", VA = "0x18A4DCB20")]
		public static int GOYZDXOOVIJ(int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0xA4DFBF0", Offset = "0xA4DE5F0", VA = "0x18A4DFBF0")]
		public static int WKHXPKUNRDG(int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0xA4DC3A0", Offset = "0xA4DADA0", VA = "0x18A4DC3A0")]
		public static Color DXJETEIPYZW(ShapeColor a)
		{
			return default(Color);
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0xA4DE210", Offset = "0xA4DCC10", VA = "0x18A4DE210")]
		public static bool NUVKENXGJWR(ShapeType a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0xA4DF4E0", Offset = "0xA4DDEE0", VA = "0x18A4DF4E0")]
		public static int UXFOUDJTPRZ(ShapeType a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0xA4DC410", Offset = "0xA4DAE10", VA = "0x18A4DC410")]
		[NotNull]
		public static ShapeColorInfo EMWMMZLITRA(ShapeColor a, bool b = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0xA4DBF30", Offset = "0xA4DA930", VA = "0x18A4DBF30")]
		public static ShapeMaterialInfo ALHUAYSMZLM(ShapeMaterial a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0xA4DC0A0", Offset = "0xA4DAAA0", VA = "0x18A4DC0A0")]
		public static float BSQOYNRQUUD(int a)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0xA4DEB70", Offset = "0xA4DD570", VA = "0x18A4DEB70")]
		public static int SSVNHODUOKZ(int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0xA4DF5B0", Offset = "0xA4DDFB0", VA = "0x18A4DF5B0")]
		public static int VGVVDZMWKQT(int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0xA4DC9C0", Offset = "0xA4DB3C0", VA = "0x18A4DC9C0")]
		public static Vector3 FJZILKSNBKH(ShapeType a)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0xA4DDC80", Offset = "0xA4DC680", VA = "0x18A4DDC80")]
		public static float KJZSUQTXGOU(ShapeType a, Vector3 b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0xA4DCB40", Offset = "0xA4DB540", VA = "0x18A4DCB40")]
		public static void HJRBLCFYJSH(bool a = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0xA4DD6E0", Offset = "0xA4DC0E0", VA = "0x18A4DD6E0")]
		private static void JNGTYRZDOIQ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0xA4DF790", Offset = "0xA4DE190", VA = "0x18A4DF790")]
		public static void VSHVLNZSJYQ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0xA4DE830", Offset = "0xA4DD230", VA = "0x18A4DE830")]
		public static void SSMRAPFLHNL()
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
