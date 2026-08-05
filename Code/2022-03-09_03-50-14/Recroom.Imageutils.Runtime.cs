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
		[Cpp2IlInjected.Address(RVA = "0x2044990", Offset = "0x2042F90", VA = "0x182044990")]
		public CubeMapGenerator()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public enum LGFEPNIJFGJ
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
public interface LDKICONBFCO
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	LGFEPNIJFGJ MMOCNFNIJDM
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class MBIGAJNLINE
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
			[Cpp2IlInjected.Address(RVA = "0x20466B0", Offset = "0x2044CB0", VA = "0x1820466B0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x20466A0", Offset = "0x2044CA0", VA = "0x1820466A0")]
		public Resolution(uint NJIPMFDFONJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x855950", Offset = "0x853F50", VA = "0x180855950")]
		public Resolution(uint NJIPMFDFONJ, uint ENLDDEBGJMC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x2046550", Offset = "0x2044B50", VA = "0x182046550")]
		public static Resolution CIEMABBOAEA(Resolution[] FOOKBGBEEHA, Resolution JPJJLCMCADO, int LCIJGAIMIKA)
		{
			return default(Resolution);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public class PBNJFHIHDCH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private readonly Resolution DJPHMHFEJPD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private Resolution? NPHPCJCJHAE;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public uint NJIPMFDFONJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x2046170", Offset = "0x2044770", VA = "0x182046170")]
			get
			{
				return default(uint);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public uint ENLDDEBGJMC
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x2046150", Offset = "0x2044750", VA = "0x182046150")]
			get
			{
				return default(uint);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public Resolution MCDNKHJPPKI
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x2046180", Offset = "0x2044780", VA = "0x182046180")]
			get
			{
				return default(Resolution);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0xD63220", Offset = "0xD61820", VA = "0x180D63220")]
		public PBNJFHIHDCH(Resolution DJPHMHFEJPD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x2046380", Offset = "0x2044980", VA = "0x182046380")]
		private static Resolution NGNMIHFBBCF(Resolution NPHPCJCJHAE, LGFEPNIJFGJ HPLKBDOMPPI)
		{
			return default(Resolution);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public static class HGAKJENOONM
	{
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public static readonly Resolution EMKHPDOEOJK;

		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public static readonly Resolution GMNOCCCICHM;

		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public static readonly Resolution OALNDFNGKLO;

		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public static readonly Resolution IENOHJHCFBG;

		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public static readonly Resolution PKLDKLOFIFD;

		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public static readonly Resolution JKJNMDKEPIH;

		[Cpp2IlInjected.Token(Token = "0x4000014")]
		internal static readonly Resolution[] JLILHEPIPDA;
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public static class OHGKAKGOLPF
	{
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public static readonly Resolution LFOOGGEJJNA;

		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public static readonly Resolution NHMJJFMHOJN;

		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public static readonly Resolution OLCIDOALEHC;

		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public static readonly Resolution MHEFBGJGGAM;

		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public static readonly Resolution PIFIOONHHMC;

		[Cpp2IlInjected.Token(Token = "0x400001A")]
		internal static readonly Resolution[] JLILHEPIPDA;

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x2045DB0", Offset = "0x20443B0", VA = "0x182045DB0")]
		public static Resolution MFEDCLPIBLI(uint OMKIDNPFIFC)
		{
			return default(Resolution);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public static readonly Resolution JBGGPJCEOPH;

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x2044D10", Offset = "0x2043310", VA = "0x182044D10")]
	public static bool LNHMNFAEPIE(uint MOFIPCHLOJN)
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
		public enum HIDPHIENNBO : byte
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
		private class GEFKDAGEMKG : IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			private string BCICIJMKKJI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			public Texture2D ICILGHIJNLE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400002C")]
			public HIDPHIENNBO NFMFIHMPBCA;

			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x2044A10", Offset = "0x2043010", VA = "0x182044A10")]
			public GEFKDAGEMKG(string BCICIJMKKJI)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x10AE2F0", Offset = "0x10AC8F0", VA = "0x1810AE2F0")]
			public GEFKDAGEMKG(string BCICIJMKKJI, Texture2D EBIKBALPNNA, HIDPHIENNBO KPDFIJLGLOL)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x20449D0", Offset = "0x2042FD0", VA = "0x1820449D0", Slot = "4")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000D")]
		[CompilerGenerated]
		private sealed class HLDBEMGLJGI
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400002D")]
			public ManagedTexture <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400002E")]
			public HIDPHIENNBO textureMemory;

			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x513010", Offset = "0x511610", VA = "0x180513010")]
			public HLDBEMGLJGI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x2044CD0", Offset = "0x20432D0", VA = "0x182044CD0")]
			internal void <GetManagedTexture>b__0()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000E")]
		[CompilerGenerated]
		private sealed class FGNBPCBCAMM
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400002F")]
			public int quality;

			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x513010", Offset = "0x511610", VA = "0x180513010")]
			public FGNBPCBCAMM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x20449B0", Offset = "0x2042FB0", VA = "0x1820449B0")]
			internal byte[] <EncodeToJPG>b__0(Texture2D t2d)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000F")]
		[CompilerGenerated]
		private sealed class MEFHAKIMLGN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000030")]
			public RenderTexture tempRenderTexture;

			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x513010", Offset = "0x511610", VA = "0x180513010")]
			public MEFHAKIMLGN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x2044F50", Offset = "0x2043550", VA = "0x182044F50")]
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
		private global::ANHHADAADKH<Texture2D> _cpuSidePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private GEFKDAGEMKG _memTexture;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private global::ANHHADAADKH<byte[]> _jpgEncodePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private byte[] _jpgBytes;

		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public const int DEFAULT_JPG_QUALITY = 80;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private global::ANHHADAADKH<byte[]> _pngEncodePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private byte[] _pngBytes;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public bool UsePalette
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x599D90", Offset = "0x598390", VA = "0x180599D90")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public RenderTexture LastRenderTexture
		{
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x523CC0", Offset = "0x5222C0", VA = "0x180523CC0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x523A10", Offset = "0x522010", VA = "0x180523A10")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		private GEFKDAGEMKG memoryTexture
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x2045D10", Offset = "0x2044310", VA = "0x182045D10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x2045CC0", Offset = "0x20442C0", VA = "0x182045CC0")]
		public ManagedTexture(string BCICIJMKKJI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x2045C60", Offset = "0x2044260", VA = "0x182045C60")]
		public ManagedTexture(string BCICIJMKKJI, bool EGNNBDGAPNG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x2044FE0", Offset = "0x20435E0", VA = "0x182044FE0")]
		public void ACGDMEGCDCL(RenderTexture LBNPNDDHGAP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x20455A0", Offset = "0x2043BA0", VA = "0x1820455A0")]
		public global::ANHHADAADKH<byte[]> CCCCFECLMPB(bool DMFKOBLCEAI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x2045750", Offset = "0x2043D50", VA = "0x182045750")]
		public global::ANHHADAADKH<Texture2D> CPEEMAIMDFP(HIDPHIENNBO KPDFIJLGLOL, bool MCIPHBDAIGE = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x2045AB0", Offset = "0x20440B0", VA = "0x182045AB0")]
		public global::ANHHADAADKH<byte[]> KFEAKBJJBIN(bool MCIPHBDAIGE = false, int NOHNDIDIFGK = 80)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x20455C0", Offset = "0x2043BC0", VA = "0x1820455C0")]
		public global::ANHHADAADKH<byte[]> CKBFHJDIFLM(bool MCIPHBDAIGE = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x2045010", Offset = "0x2043610", VA = "0x182045010")]
		private static global::ANHHADAADKH<Texture2D> BCKFCJGDNKN(string BCICIJMKKJI, RenderTexture LBNPNDDHGAP, ref Texture2D GPPCPAKHNPF, bool MCIPHBDAIGE, HIDPHIENNBO EMHEHFDCJJE = HIDPHIENNBO.GPU)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x20459E0", Offset = "0x2043FE0", VA = "0x1820459E0")]
		public void DELJMNEOELN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x2045AA0", Offset = "0x20440A0", VA = "0x182045AA0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x2045500", Offset = "0x2043B00", VA = "0x182045500")]
		[CompilerGenerated]
		private global::ANHHADAADKH<byte[]> BIJJAKNFKHI(Texture2D CCBOELBFEKG)
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public static class BIAHDOAPNIO
{
	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x20437C0", Offset = "0x2041DC0", VA = "0x1820437C0")]
	public static RenderTexture GPKPMJIFOGO(int OMKIDNPFIFC, int JEGDAENABFA, int GFDLNLPJGDB, Camera NCNFGBFCBAA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x2043750", Offset = "0x2041D50", VA = "0x182043750")]
	public static void CIOMPJALDCC(RenderTexture LBNPNDDHGAP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class CCAHHFALJBG
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public class FNFELBILKOK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public int DCLJJOJCGNC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public int DOENPMFKHAF;

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x7F2EC0", Offset = "0x7F14C0", VA = "0x1807F2EC0")]
		public FNFELBILKOK(int DNMBNBDOOGP, int OBBHILLKPGP)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	private enum NMLHFFJEMPA
	{
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		Point,
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		Bilinear,
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		Average
	}

	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private static Color[] FFJGGOJOCMD;

	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private static Color[] FAEFMNEFHDA;

	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private static int JIABHIKNJHH;

	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private static float DMOPMJHIGFD;

	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private static float OIKIHLKEHEE;

	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private static int OJCCFLKHFLG;

	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private static int BBPHIAFHCLA;

	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private static Mutex ALNBPGGJNEL;

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x2044970", Offset = "0x2042F70", VA = "0x182044970")]
	public static void OEFMMDKLLNG(Texture2D EOOHGKILIEO, int HCKONBADILE, int PAFMLPMMDBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x2043B10", Offset = "0x2042110", VA = "0x182043B10")]
	private static void EFOKHCCJJGP(Texture2D EOOHGKILIEO, int HCKONBADILE, int PAFMLPMMDBB, NMLHFFJEMPA AECDOCIFGIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x2044360", Offset = "0x2042960", VA = "0x182044360")]
	public static void JBCIFKJKDDI(object AIHPMIAHIBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x2043930", Offset = "0x2041F30", VA = "0x182043930")]
	public static void APBGALJJNNM(object AIHPMIAHIBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x2043FC0", Offset = "0x20425C0", VA = "0x182043FC0")]
	private static Color FEFHGIDEKDE(int NJIPMFDFONJ, int ENLDDEBGJMC, float DMOPMJHIGFD, float OIKIHLKEHEE)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x2044180", Offset = "0x2042780", VA = "0x182044180")]
	public static void IONGELEGPAE(object AIHPMIAHIBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x2044880", Offset = "0x2042E80", VA = "0x182044880")]
	private static Color NENHCICJCFK(Color OIMCMNMLOMO, Color FPDLGHPBNAF, float BEOHMGPJCII)
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
