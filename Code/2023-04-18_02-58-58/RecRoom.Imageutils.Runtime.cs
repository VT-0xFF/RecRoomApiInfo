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
		[Cpp2IlInjected.Address(RVA = "0x67C2A40", Offset = "0x67C1C40", VA = "0x1867C2A40")]
		public CubeMapGenerator()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public enum CCONJEHGIDD
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
public interface OBMOJNBACPJ
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	CCONJEHGIDD DCDDMPGNMAN
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class LALFNFGHKHL
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
			[Cpp2IlInjected.Address(RVA = "0x67C53E0", Offset = "0x67C45E0", VA = "0x1867C53E0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x67C53D0", Offset = "0x67C45D0", VA = "0x1867C53D0")]
		public Resolution(uint FCCGDNMAHPA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x856470", Offset = "0x855670", VA = "0x180856470")]
		public Resolution(uint FCCGDNMAHPA, uint BADLFKONABM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x67C52E0", Offset = "0x67C44E0", VA = "0x1867C52E0")]
		public static Resolution LNCALKLBEJG(Resolution[] DMMDPMFCBHN, Resolution MEEIILDPPCN, int CMCMKMIJDGD)
		{
			return default(Resolution);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public class HIPPLPKINHO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private readonly Resolution KJMEMOBNABO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private Resolution? NDECALNLBGD;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public uint FCCGDNMAHPA
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x67C2E00", Offset = "0x67C2000", VA = "0x1867C2E00")]
			get
			{
				return default(uint);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public uint BADLFKONABM
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x67C2DE0", Offset = "0x67C1FE0", VA = "0x1867C2DE0")]
			get
			{
				return default(uint);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public Resolution AHOIPJAHANF
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x67C2C00", Offset = "0x67C1E00", VA = "0x1867C2C00")]
			get
			{
				return default(Resolution);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x85C400", Offset = "0x85B600", VA = "0x18085C400")]
		public HIPPLPKINHO(Resolution KJMEMOBNABO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x67C2A60", Offset = "0x67C1C60", VA = "0x1867C2A60")]
		private static Resolution CNLCOEGDAGD(Resolution NDECALNLBGD, CCONJEHGIDD NHNPOPHNLIM)
		{
			return default(Resolution);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public static class OJENEDONBPA
	{
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public static readonly Resolution GAOOHFNJGDI;

		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public static readonly Resolution GMIBNMMGICG;

		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public static readonly Resolution JLJFFJGPHDL;

		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public static readonly Resolution PLAOICCCNGA;

		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public static readonly Resolution KGDANDGONGA;

		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public static readonly Resolution DFMPOOEHPLF;

		[Cpp2IlInjected.Token(Token = "0x4000014")]
		internal static readonly Resolution[] HJADOBGHPFL;
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public static class ALOOOFHLMPN
	{
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public static readonly Resolution KKFEKHEBOJI;

		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public static readonly Resolution GKIKLOGKKMC;

		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public static readonly Resolution LKFLGGIAMDO;

		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public static readonly Resolution HLFAJMGGHHE;

		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public static readonly Resolution LCEHIKLFEBM;

		[Cpp2IlInjected.Token(Token = "0x400001A")]
		internal static readonly Resolution[] HJADOBGHPFL;

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x67C2460", Offset = "0x67C1660", VA = "0x1867C2460")]
		public static Resolution NGPNOHPENLB(uint LBPFDOBECLE)
		{
			return default(Resolution);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public static readonly Resolution LBIHEEEDAPL;

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x67C2E10", Offset = "0x67C2010", VA = "0x1867C2E10")]
	public static bool FOMCBECJLNG(uint BJIDABFGMCI)
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
		public enum FOBJCFHHBPL : byte
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
		private class PMJPIINKOFK : IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			private string KNOPFGAGMCN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			public Texture2D DAHHPOPPCCB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400002C")]
			public FOBJCFHHBPL FOGJFLKMKJH;

			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x67C5290", Offset = "0x67C4490", VA = "0x1867C5290")]
			public PMJPIINKOFK(string KNOPFGAGMCN)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x2DDC9C0", Offset = "0x2DDBBC0", VA = "0x182DDC9C0")]
			public PMJPIINKOFK(string KNOPFGAGMCN, Texture2D CIONKGJFLOB, FOBJCFHHBPL OOFOHOOOGGJ)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x67C5250", Offset = "0x67C4450", VA = "0x1867C5250", Slot = "4")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000D")]
		[CompilerGenerated]
		private sealed class MBAJOEHPMFN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400002D")]
			public ManagedTexture <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400002E")]
			public FOBJCFHHBPL textureMemory;

			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x703570", Offset = "0x702770", VA = "0x180703570")]
			public MBAJOEHPMFN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x67C3090", Offset = "0x67C2290", VA = "0x1867C3090")]
			internal void <GetManagedTexture>b__0()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000E")]
		[CompilerGenerated]
		private sealed class LFCCFHNJIJO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400002F")]
			public int quality;

			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x703570", Offset = "0x702770", VA = "0x180703570")]
			public LFCCFHNJIJO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x67C3070", Offset = "0x67C2270", VA = "0x1867C3070")]
			internal byte[] <EncodeToJPG>b__0(Texture2D t2d)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000F")]
		[CompilerGenerated]
		private sealed class AGENPGMDCCE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000030")]
			public RenderTexture tempRenderTexture;

			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x703570", Offset = "0x702770", VA = "0x180703570")]
			public AGENPGMDCCE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x67C23D0", Offset = "0x67C15D0", VA = "0x1867C23D0")]
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
		private global::NCOKFFGPIJM<Texture2D> _cpuSidePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private PMJPIINKOFK _memTexture;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private global::NCOKFFGPIJM<byte[]> _jpgEncodePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private byte[] _jpgBytes;

		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public const int DEFAULT_JPG_QUALITY = 80;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private global::NCOKFFGPIJM<byte[]> _pngEncodePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private byte[] _pngBytes;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public bool UsePalette
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x707B80", Offset = "0x706D80", VA = "0x180707B80")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public RenderTexture LastRenderTexture
		{
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x6F6390", Offset = "0x6F5590", VA = "0x1806F6390")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x7BB020", Offset = "0x7BA220", VA = "0x1807BB020")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		private PMJPIINKOFK memoryTexture
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x67C3F80", Offset = "0x67C3180", VA = "0x1867C3F80")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x67C3F30", Offset = "0x67C3130", VA = "0x1867C3F30")]
		public ManagedTexture(string KNOPFGAGMCN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x67C3ED0", Offset = "0x67C30D0", VA = "0x1867C3ED0")]
		public ManagedTexture(string KNOPFGAGMCN, bool JCHODOLIGAN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x67C34C0", Offset = "0x67C26C0", VA = "0x1867C34C0")]
		public void KGEOBHGGOLL(RenderTexture KAACGMLIKHK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x67C3290", Offset = "0x67C2490", VA = "0x1867C3290")]
		public global::NCOKFFGPIJM<byte[]> BDPNNJNLKMK(bool BBKNAJILJBF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x67C3BE0", Offset = "0x67C2DE0", VA = "0x1867C3BE0")]
		public global::NCOKFFGPIJM<Texture2D> PEBLHGLINNK(FOBJCFHHBPL OOFOHOOOGGJ, bool DNAAHBKMPOP = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x67C32C0", Offset = "0x67C24C0", VA = "0x1867C32C0")]
		public global::NCOKFFGPIJM<byte[]> HODDEEDEMHN(bool DNAAHBKMPOP = false, int MBPMMFLFHLI = 80)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x67C30D0", Offset = "0x67C22D0", VA = "0x1867C30D0")]
		public global::NCOKFFGPIJM<byte[]> AHKGJHDHBOM(bool DNAAHBKMPOP = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x67C3660", Offset = "0x67C2860", VA = "0x1867C3660")]
		private static global::NCOKFFGPIJM<Texture2D> OOLLDNPNKAP(string KNOPFGAGMCN, RenderTexture KAACGMLIKHK, ref Texture2D DONLPKICEBO, bool DNAAHBKMPOP, FOBJCFHHBPL HCJMJPCIENO = FOBJCFHHBPL.GPU)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x67C35A0", Offset = "0x67C27A0", VA = "0x1867C35A0")]
		public void NLPEFMCGLDE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x67C32B0", Offset = "0x67C24B0", VA = "0x1867C32B0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x67C34F0", Offset = "0x67C26F0", VA = "0x1867C34F0")]
		[CompilerGenerated]
		private global::NCOKFFGPIJM<byte[]> NLFMKMNAKHI(Texture2D LHAHFECEOCL)
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public static class CDNLNJDLMPN
{
	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x67C2820", Offset = "0x67C1A20", VA = "0x1867C2820")]
	public static RenderTexture FLJJFGHAGBC(int LBPFDOBECLE, int BICGJAOHKIJ, int GADEOBMPDPB, Camera GAPPCJHIBEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x67C29D0", Offset = "0x67C1BD0", VA = "0x1867C29D0")]
	public static void IJMCKPELKMM(RenderTexture KAACGMLIKHK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class NCBDPJOFNCC
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public class BECNNHEGNLN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public int EBEICGFALNG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public int OGINPOLMPBC;

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x14B2430", Offset = "0x14B1630", VA = "0x1814B2430")]
		public BECNNHEGNLN(int IBALDFBGBGL, int GCBHEJANCJK)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	private enum KENHLFBLEIO
	{
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		Point,
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		Bilinear,
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		Average
	}

	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private static Color[] IILHNIBEGEH;

	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private static Color[] HEHJGCHFPOG;

	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private static int NHEDGPECFAM;

	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private static float FBOKKIPLFFM;

	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private static float NJPOAENGDHJ;

	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private static int FBLHNPJOMBM;

	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private static int HMGMMBICBFF;

	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private static Mutex KEBKCBOKLMC;

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x67C46E0", Offset = "0x67C38E0", VA = "0x1867C46E0")]
	public static void GJPMJBBMELJ(Texture2D EDPNGGBBEPG, int PCDGPFKJKIF, int BNJGFFHNOGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x67C41F0", Offset = "0x67C33F0", VA = "0x1867C41F0")]
	private static void DKOGGBFHJEH(Texture2D EDPNGGBBEPG, int PCDGPFKJKIF, int BNJGFFHNOGA, KENHLFBLEIO PNMOPCJFNHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x67C4B50", Offset = "0x67C3D50", VA = "0x1867C4B50")]
	public static void ONGCFNJFOJP(object ICHBECDKHOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x67C4700", Offset = "0x67C3900", VA = "0x1867C4700")]
	public static void KFFDABHHAMA(object ICHBECDKHOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x67C49B0", Offset = "0x67C3BB0", VA = "0x1867C49B0")]
	private static Color OACFJIDGDIB(int FCCGDNMAHPA, int BADLFKONABM, float FBOKKIPLFFM, float NJPOAENGDHJ)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x67C4020", Offset = "0x67C3220", VA = "0x1867C4020")]
	public static void BAFENEJCPNP(object ICHBECDKHOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x67C48D0", Offset = "0x67C3AD0", VA = "0x1867C48D0")]
	private static Color LGADFCPNLBD(Color KFJHHKJJBDJ, Color OGOMKILDLPC, float IPMIIEAGJKC)
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
