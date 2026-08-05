using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
namespace RecRoom.Utils.Image
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[RequireComponent(typeof(Camera))]
	public class CubeMapGenerator : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public int Resolution;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public int AntiAliasLevel;

		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x1A899A0", Offset = "0x1A887A0", VA = "0x181A899A0")]
		public CubeMapGenerator()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public enum AKANKMDHICH
{
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	NOT_SET,
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	UNSUPPORTED,
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	TWO_GB,
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	FOUR_GB,
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	EIGHT_GB
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface HIGADHBBJEF
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	AKANKMDHICH NAAAGKHDEKN
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class HCEBCNOIEKG
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public struct Resolution
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public uint x;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public uint y;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public bool IsSquare
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x1A8B6C0", Offset = "0x1A8A4C0", VA = "0x181A8B6C0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x1A8B6B0", Offset = "0x1A8A4B0", VA = "0x181A8B6B0")]
		public Resolution(uint EIPKBLJANKN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x6D1060", Offset = "0x6CFE60", VA = "0x1806D1060")]
		public Resolution(uint EIPKBLJANKN, uint POPNGEAPMKI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x1A8B560", Offset = "0x1A8A360", VA = "0x181A8B560")]
		public static Resolution ENPKHBFIOGJ(Resolution[] CBNHGCKNDKF, Resolution CFCAKDAHBGO, int LLCEEEBHOPH)
		{
			return default(Resolution);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public class ICCGFGPLJBN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private readonly Resolution CKLAHCBBDDF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private Resolution? JAHNMLCJKHL;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public uint EIPKBLJANKN
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x1A8A0E0", Offset = "0x1A88EE0", VA = "0x181A8A0E0")]
			get
			{
				return default(uint);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public uint POPNGEAPMKI
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x1A8A0C0", Offset = "0x1A88EC0", VA = "0x181A8A0C0")]
			get
			{
				return default(uint);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public Resolution DCONHGMCEBA
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x1A89EC0", Offset = "0x1A88CC0", VA = "0x181A89EC0")]
			get
			{
				return default(Resolution);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0xB17B80", Offset = "0xB16980", VA = "0x180B17B80")]
		public ICCGFGPLJBN(Resolution CKLAHCBBDDF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x1A89CF0", Offset = "0x1A88AF0", VA = "0x181A89CF0")]
		private static Resolution DEHKCDENEBK(Resolution JAHNMLCJKHL, AKANKMDHICH OGDILKEIBJP)
		{
			return default(Resolution);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public static class PAKEOICNEPN
	{
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public static readonly Resolution KHFCBKGPALE;

		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public static readonly Resolution DJHGLLDJBIB;

		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public static readonly Resolution ALIFKBFMLJC;

		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public static readonly Resolution JCCJANPAHMH;

		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public static readonly Resolution NFDHPOAAPIN;

		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public static readonly Resolution CGLGIOFLCEJ;

		[Cpp2IlInjected.Token(Token = "0x4000014")]
		internal static readonly Resolution[] FFHINLLCKEM;
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public static class NPJCJACJKOK
	{
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public static readonly Resolution PEEHJEAMINO;

		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public static readonly Resolution GAHBAEELDPN;

		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public static readonly Resolution ONIPANFPGFA;

		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public static readonly Resolution DHKIIGIGEMN;

		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public static readonly Resolution ILNMBMIMOJD;

		[Cpp2IlInjected.Token(Token = "0x400001A")]
		internal static readonly Resolution[] FFHINLLCKEM;

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x1A8AF50", Offset = "0x1A89D50", VA = "0x181A8AF50")]
		public static Resolution MFCNCDAMHNM(uint CEKEOJFHGKE)
		{
			return default(Resolution);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public static readonly Resolution ANGGOLOOACI;

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x1A89A20", Offset = "0x1A88820", VA = "0x181A89A20")]
	public static bool OPPACHDLAHB(uint HFNEBOLOFGG)
	{
		return default(bool);
	}
}
namespace RecRoom.Utils.Image
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public class ManagedTexture : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x200000B")]
		[Flags]
		public enum LGALKBGHHCH : byte
		{
			[Cpp2IlInjected.Token(Token = "0x4000026")]
			None = 0,
			[Cpp2IlInjected.Token(Token = "0x4000027")]
			GPU = 1,
			[Cpp2IlInjected.Token(Token = "0x4000028")]
			System = 2,
			[Cpp2IlInjected.Token(Token = "0x4000029")]
			Both = 3
		}

		[Cpp2IlInjected.Token(Token = "0x200000C")]
		private class NNCMKCIPHJO : IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			private string OPBNEOMPEGH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			public Texture2D LHLMPALGANA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400002C")]
			public LGALKBGHHCH FEGAGCEJOMJ;

			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x1A8AF00", Offset = "0x1A89D00", VA = "0x181A8AF00")]
			public NNCMKCIPHJO(string OPBNEOMPEGH)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0xDA89F0", Offset = "0xDA77F0", VA = "0x180DA89F0")]
			public NNCMKCIPHJO(string OPBNEOMPEGH, Texture2D HKBDHHFCEDC, LGALKBGHHCH JILDOEHCHFG)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x1A8AEC0", Offset = "0x1A89CC0", VA = "0x181A8AEC0", Slot = "4")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000D")]
		[CompilerGenerated]
		private sealed class EGPJLDLEONH
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400002D")]
			public ManagedTexture <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400002E")]
			public LGALKBGHHCH textureMemory;

			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x523000", Offset = "0x521E00", VA = "0x180523000")]
			public EGPJLDLEONH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x1A899C0", Offset = "0x1A887C0", VA = "0x181A899C0")]
			internal void <GetManagedTexture>b__0()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000E")]
		[CompilerGenerated]
		private sealed class GKGIMJCAMEG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400002F")]
			public int quality;

			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x523000", Offset = "0x521E00", VA = "0x180523000")]
			public GKGIMJCAMEG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x1A89A00", Offset = "0x1A88800", VA = "0x181A89A00")]
			internal byte[] <EncodeToJPG>b__0(Texture2D t2d)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000F")]
		[CompilerGenerated]
		private sealed class HNMPMEPHKKN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000030")]
			public RenderTexture tempRenderTexture;

			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x523000", Offset = "0x521E00", VA = "0x180523000")]
			public HNMPMEPHKKN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x1A89C60", Offset = "0x1A88A60", VA = "0x181A89C60")]
			internal void <RenderTextureToTexture2D>b__0()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		[SerializeField]
		private bool usePalette;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		[SerializeField]
		private string name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private global::JDJCJHOOLJN<Texture2D> _cpuSidePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private NNCMKCIPHJO _memTexture;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private global::JDJCJHOOLJN<byte[]> _jpgEncodePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private byte[] _jpgBytes;

		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public const int DEFAULT_JPG_QUALITY = 80;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private global::JDJCJHOOLJN<byte[]> _pngEncodePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private byte[] _pngBytes;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public bool UsePalette
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x55DC30", Offset = "0x55CA30", VA = "0x18055DC30")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public RenderTexture LastRenderTexture
		{
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x5274B0", Offset = "0x5262B0", VA = "0x1805274B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x52A540", Offset = "0x529340", VA = "0x18052A540")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		private NNCMKCIPHJO memoryTexture
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x1A8AE20", Offset = "0x1A89C20", VA = "0x181A8AE20")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x1A8ADD0", Offset = "0x1A89BD0", VA = "0x181A8ADD0")]
		public ManagedTexture(string OPBNEOMPEGH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x1A8AD70", Offset = "0x1A89B70", VA = "0x181A8AD70")]
		public ManagedTexture(string OPBNEOMPEGH, bool HIDCHHBEOLH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x1A8A2A0", Offset = "0x1A890A0", VA = "0x181A8A2A0")]
		public void DPEGILDNDKB(RenderTexture FBFAFHHJDNG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x1A8A2E0", Offset = "0x1A890E0", VA = "0x181A8A2E0")]
		public global::JDJCJHOOLJN<byte[]> EMHFHCLBPIO(bool FKOKPAELLIN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x1A8A890", Offset = "0x1A89690", VA = "0x181A8A890")]
		public global::JDJCJHOOLJN<Texture2D> INEMPFPBKOB(LGALKBGHHCH JILDOEHCHFG, bool BCLIMLDLAHG = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x1A8A0F0", Offset = "0x1A88EF0", VA = "0x181A8A0F0")]
		public global::JDJCJHOOLJN<byte[]> BOJAOGNPNMF(bool BCLIMLDLAHG = false, int IAOGMNMINPG = 80)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x1A8ABE0", Offset = "0x1A899E0", VA = "0x181A8ABE0")]
		public global::JDJCJHOOLJN<byte[]> MMCDPOGAEDF(bool BCLIMLDLAHG = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x1A8A3A0", Offset = "0x1A891A0", VA = "0x181A8A3A0")]
		private static global::JDJCJHOOLJN<Texture2D> IKDJBIKDCJG(string OPBNEOMPEGH, RenderTexture FBFAFHHJDNG, ref Texture2D DBLNBAMGNOI, bool BCLIMLDLAHG, LGALKBGHHCH DPGGOPIIIJD = LGALKBGHHCH.GPU)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x1A8AB20", Offset = "0x1A89920", VA = "0x181A8AB20")]
		public void JLABBELMDEJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x1A8A2D0", Offset = "0x1A890D0", VA = "0x181A8A2D0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x1A8A300", Offset = "0x1A89100", VA = "0x181A8A300")]
		[CompilerGenerated]
		private global::JDJCJHOOLJN<byte[]> FHHCPMHHOFO(Texture2D GDGGIMLAONL)
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public static class AKJKDCMAMCH
{
	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x1A89830", Offset = "0x1A88630", VA = "0x181A89830")]
	public static RenderTexture MKFJFAMBOPI(int CEKEOJFHGKE, int GNPEIMEDGFJ, int JNMLENKGGDM, Camera CBODFCAJOMK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x1A897C0", Offset = "0x1A885C0", VA = "0x181A897C0")]
	public static void CACHOIBGJOJ(RenderTexture FBFAFHHJDNG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class AGECCNGGIBD
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public class COLFEOPJGKE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public int CKKNDHPMNJM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public int BPFJIKLPIND;

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x6551E0", Offset = "0x653FE0", VA = "0x1806551E0")]
		public COLFEOPJGKE(int FANBJFHCKPB, int BNOCGDMHEJO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	private enum NDHHOLCBKFF
	{
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		Point,
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		Bilinear,
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		Average
	}

	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private static Color[] ADCKBBPJDND;

	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private static Color[] JHCHMOBKONE;

	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private static int BGFKLDGFFJD;

	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private static float JKANAIMFNJL;

	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private static float ADKEEIGPACN;

	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private static int CCDDEOBHKLH;

	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private static int DLCONNMKIJA;

	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private static Mutex ICFDCDDKEGB;

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x1A88A30", Offset = "0x1A87830", VA = "0x181A88A30")]
	public static void FIKFJANIIDE(Texture2D JBJNCMONDPO, int GHEFBBOOGHF, int JMGDGOCFPOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x1A88F70", Offset = "0x1A87D70", VA = "0x181A88F70")]
	private static void MDDDEOKOCJF(Texture2D JBJNCMONDPO, int GHEFBBOOGHF, int JMGDGOCFPOK, NDHHOLCBKFF AAJHPJONOLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x1A88A50", Offset = "0x1A87850", VA = "0x181A88A50")]
	public static void KNIJDHKAMCM(object HOBENCJANIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x1A895E0", Offset = "0x1A883E0", VA = "0x181A895E0")]
	public static void PMFPKIEDGIG(object HOBENCJANIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x1A89420", Offset = "0x1A88220", VA = "0x181A89420")]
	private static Color PGGFBGELJCG(int EIPKBLJANKN, int POPNGEAPMKI, float JKANAIMFNJL, float ADKEEIGPACN)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x1A88760", Offset = "0x1A87560", VA = "0x181A88760")]
	public static void BHOECDBDAFK(object HOBENCJANIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x1A88940", Offset = "0x1A87740", VA = "0x181A88940")]
	private static Color DBKDEFCLBHD(Color LHGLMKNFFGM, Color PLCFGKGGMEC, float FCGCDNFBIMM)
	{
		return default(Color);
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
