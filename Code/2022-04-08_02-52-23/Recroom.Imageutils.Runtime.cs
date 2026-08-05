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
		[Cpp2IlInjected.Address(RVA = "0x16BC190", Offset = "0x16BAF90", VA = "0x1816BC190")]
		public CubeMapGenerator()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public enum KPHEICKGNNE
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
public interface HHABABBLGCI
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	KPHEICKGNNE INLEDFEDNGL
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class DOODEKKNABM
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
			[Cpp2IlInjected.Address(RVA = "0x16BEC10", Offset = "0x16BDA10", VA = "0x1816BEC10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x16BEC00", Offset = "0x16BDA00", VA = "0x1816BEC00")]
		public Resolution(uint DCMLOLBECIB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x705350", Offset = "0x704150", VA = "0x180705350")]
		public Resolution(uint DCMLOLBECIB, uint FNPBMEBCJAB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x16BEAB0", Offset = "0x16BD8B0", VA = "0x1816BEAB0")]
		public static Resolution OIMDMIODFEP(Resolution[] KINNFMPDJLH, Resolution GDBDPPOAAHA, int PAMBLHMHBFB)
		{
			return default(Resolution);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public class KAEMEBHCGFA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private readonly Resolution HFDMANGCGGL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private Resolution? AMLNFKANGMM;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public uint DCMLOLBECIB
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x16BD880", Offset = "0x16BC680", VA = "0x1816BD880")]
			get
			{
				return default(uint);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public uint FNPBMEBCJAB
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x16BD890", Offset = "0x16BC690", VA = "0x1816BD890")]
			get
			{
				return default(uint);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public Resolution BECBLEKFJIO
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x16BD4B0", Offset = "0x16BC2B0", VA = "0x1816BD4B0")]
			get
			{
				return default(Resolution);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x5947A0", Offset = "0x5935A0", VA = "0x1805947A0")]
		public KAEMEBHCGFA(Resolution HFDMANGCGGL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x16BD6B0", Offset = "0x16BC4B0", VA = "0x1816BD6B0")]
		private static Resolution DEBGHDFCDHA(Resolution AMLNFKANGMM, KPHEICKGNNE NDCEHJLLMLA)
		{
			return default(Resolution);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public static class CPLNNAGNFBB
	{
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public static readonly Resolution DGJMKLBHLIH;

		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public static readonly Resolution HFNBLDICJHC;

		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public static readonly Resolution IGEGPLJGEOD;

		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public static readonly Resolution CDFJPAPMIMH;

		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public static readonly Resolution DHLMLEPLFFI;

		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public static readonly Resolution CBGBAOOHBBN;

		[Cpp2IlInjected.Token(Token = "0x4000014")]
		internal static readonly Resolution[] LIBKHJPLBMH;
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public static class KLEFMPNKBIA
	{
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public static readonly Resolution ACBIFHFNEBG;

		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public static readonly Resolution DNFIMOIALIA;

		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public static readonly Resolution BFFOEAHGIOK;

		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public static readonly Resolution KEBJGJOILCI;

		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public static readonly Resolution LGEJHMNCGLG;

		[Cpp2IlInjected.Token(Token = "0x400001A")]
		internal static readonly Resolution[] LIBKHJPLBMH;

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x16BD8B0", Offset = "0x16BC6B0", VA = "0x1816BD8B0")]
		public static Resolution CPNEHEGBLDG(uint AGFGCPCKPEN)
		{
			return default(Resolution);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public static readonly Resolution HEELKAIDCLK;

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x16BC1B0", Offset = "0x16BAFB0", VA = "0x1816BC1B0")]
	public static bool KIIDIIIMKCL(uint IGFJJCHHLGA)
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
		public enum KENAJCIKAOD : byte
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
		private class MDOGAPHFIAF : IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			private string CLDEJGBBMEF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			public Texture2D LNJNGLCBMEI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400002C")]
			public KENAJCIKAOD JNDIFNEDJAE;

			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x16BDC90", Offset = "0x16BCA90", VA = "0x1816BDC90")]
			public MDOGAPHFIAF(string CLDEJGBBMEF)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x6D5FF0", Offset = "0x6D4DF0", VA = "0x1806D5FF0")]
			public MDOGAPHFIAF(string CLDEJGBBMEF, Texture2D MIDPFOHPCCK, KENAJCIKAOD ILOOCBGKGIN)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x16BDC50", Offset = "0x16BCA50", VA = "0x1816BDC50", Slot = "4")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000D")]
		[CompilerGenerated]
		private sealed class FNHDBMEHPMN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400002D")]
			public ManagedTexture <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400002E")]
			public KENAJCIKAOD textureMemory;

			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x524AB0", Offset = "0x5238B0", VA = "0x180524AB0")]
			public FNHDBMEHPMN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x16BC410", Offset = "0x16BB210", VA = "0x1816BC410")]
			internal void <GetManagedTexture>b__0()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000E")]
		[CompilerGenerated]
		private sealed class ENNHKCLJHIN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400002F")]
			public int quality;

			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x524AB0", Offset = "0x5238B0", VA = "0x180524AB0")]
			public ENNHKCLJHIN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x16BC3F0", Offset = "0x16BB1F0", VA = "0x1816BC3F0")]
			internal byte[] <EncodeToJPG>b__0(Texture2D t2d)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000F")]
		[CompilerGenerated]
		private sealed class CNJACHJPHCL
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000030")]
			public RenderTexture tempRenderTexture;

			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x524AB0", Offset = "0x5238B0", VA = "0x180524AB0")]
			public CNJACHJPHCL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x16BBE90", Offset = "0x16BAC90", VA = "0x1816BBE90")]
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
		private global::CBNPJNGNOBA<Texture2D> _cpuSidePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private MDOGAPHFIAF _memTexture;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private global::CBNPJNGNOBA<byte[]> _jpgEncodePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private byte[] _jpgBytes;

		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public const int DEFAULT_JPG_QUALITY = 80;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private global::CBNPJNGNOBA<byte[]> _pngEncodePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private byte[] _pngBytes;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public bool UsePalette
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x54D7B0", Offset = "0x54C5B0", VA = "0x18054D7B0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public RenderTexture LastRenderTexture
		{
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x524DF0", Offset = "0x523BF0", VA = "0x180524DF0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x54CD70", Offset = "0x54BB70", VA = "0x18054CD70")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		private MDOGAPHFIAF memoryTexture
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x16BEA10", Offset = "0x16BD810", VA = "0x1816BEA10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x16BE9C0", Offset = "0x16BD7C0", VA = "0x1816BE9C0")]
		public ManagedTexture(string CLDEJGBBMEF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x16BE960", Offset = "0x16BD760", VA = "0x1816BE960")]
		public ManagedTexture(string CLDEJGBBMEF, bool MMDFFIEPNBL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x16BDEA0", Offset = "0x16BCCA0", VA = "0x1816BDEA0")]
		public void FDBPFCCOHLP(RenderTexture BPACPMEOMHK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x16BDED0", Offset = "0x16BCCD0", VA = "0x1816BDED0")]
		public global::CBNPJNGNOBA<byte[]> FOHPNPGLHMC(bool FBBLBILACDI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x16BE6D0", Offset = "0x16BD4D0", VA = "0x1816BE6D0")]
		public global::CBNPJNGNOBA<Texture2D> MCGJEJAIAAB(KENAJCIKAOD ILOOCBGKGIN, bool NKFIHGGBBFG = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x16BDCE0", Offset = "0x16BCAE0", VA = "0x1816BDCE0")]
		public global::CBNPJNGNOBA<byte[]> CIOFPCBOHCD(bool NKFIHGGBBFG = false, int OHGLILPLMAF = 80)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x16BE540", Offset = "0x16BD340", VA = "0x1816BE540")]
		public global::CBNPJNGNOBA<byte[]> LDJHNJFJMMN(bool NKFIHGGBBFG = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x16BE050", Offset = "0x16BCE50", VA = "0x1816BE050")]
		private static global::CBNPJNGNOBA<Texture2D> JAGNDDDHFKH(string CLDEJGBBMEF, RenderTexture BPACPMEOMHK, ref Texture2D DFFBLIEGNGL, bool NKFIHGGBBFG, KENAJCIKAOD EOFLLDGFJBF = KENAJCIKAOD.GPU)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x16BDEF0", Offset = "0x16BCCF0", VA = "0x1816BDEF0")]
		public void HADMNJKOJMG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x16BDE90", Offset = "0x16BCC90", VA = "0x1816BDE90", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x16BDFB0", Offset = "0x16BCDB0", VA = "0x1816BDFB0")]
		[CompilerGenerated]
		private global::CBNPJNGNOBA<byte[]> HNOBCGPCHDK(Texture2D BKPLLOBOFJL)
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public static class AIHOFKLGJLG
{
	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x16BBCB0", Offset = "0x16BAAB0", VA = "0x1816BBCB0")]
	public static RenderTexture DHJNHFFOPDL(int AGFGCPCKPEN, int LNBHIGPMBFM, int GPFBOLLGNHI, Camera IJPGHPCDAKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x16BBE20", Offset = "0x16BAC20", VA = "0x1816BBE20")]
	public static void OCEDLMMNLPE(RenderTexture BPACPMEOMHK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class GGOKOICNEEO
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public class BLNEGLCGLJI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public int HAPPPLCCINM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public int NIFLCMKMBDD;

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x643FA0", Offset = "0x642DA0", VA = "0x180643FA0")]
		public BLNEGLCGLJI(int EIGPEBMCCHD, int FLNLIILPCOE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	private enum OKDALPOCPIO
	{
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		Point,
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		Bilinear,
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		Average
	}

	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private static Color[] EMKLFHHJKHP;

	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private static Color[] BLHPDMJJINM;

	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private static int LMHLEELBKOB;

	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private static float CKOGHFAAJGF;

	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private static float BHGIIJOHDAH;

	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private static int CPHHJDNAEJN;

	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private static int IECKKNDGDPF;

	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private static Mutex JHHCFBPNDBG;

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x16BC450", Offset = "0x16BB250", VA = "0x1816BC450")]
	public static void CDFJMHEBBBF(Texture2D PLCJHBOAGPK, int EIGOFJMCOON, int KMHBOEEKDBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x16BD000", Offset = "0x16BBE00", VA = "0x1816BD000")]
	private static void ODJDBFNADHA(Texture2D PLCJHBOAGPK, int EIGOFJMCOON, int KMHBOEEKDBM, OKDALPOCPIO PKGDELDOIFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x16BC470", Offset = "0x16BB270", VA = "0x1816BC470")]
	public static void CLEMFIPAPHD(object AHLFMJPCIDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x16BC990", Offset = "0x16BB790", VA = "0x1816BC990")]
	public static void CMBLHLCLGLO(object AHLFMJPCIDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x16BCE40", Offset = "0x16BBC40", VA = "0x1816BCE40")]
	private static Color KLDBEGBDEIL(int DCMLOLBECIB, int FNPBMEBCJAB, float CKOGHFAAJGF, float BHGIIJOHDAH)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x16BCB70", Offset = "0x16BB970", VA = "0x1816BCB70")]
	public static void CPDHLHKFFCH(object AHLFMJPCIDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x16BCD50", Offset = "0x16BBB50", VA = "0x1816BCD50")]
	private static Color DFLMPCPHNEI(Color LKBFPAKPGMP, Color MCMOKIJGLGP, float PEPOHKCFAOG)
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
