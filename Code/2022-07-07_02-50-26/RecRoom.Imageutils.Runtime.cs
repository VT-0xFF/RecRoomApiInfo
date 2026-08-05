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
		[Cpp2IlInjected.Address(RVA = "0x51C7CF0", Offset = "0x51C6EF0", VA = "0x1851C7CF0")]
		public CubeMapGenerator()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public enum AKLINJEJGMD
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
public interface JOGKEOEGOLP
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	AKLINJEJGMD FHNBJPNLBEH
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class KOIIOENKCEG
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
			[Cpp2IlInjected.Address(RVA = "0x51C9BF0", Offset = "0x51C8DF0", VA = "0x1851C9BF0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x51C9BE0", Offset = "0x51C8DE0", VA = "0x1851C9BE0")]
		public Resolution(uint CNMHAFPCMJK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x713A30", Offset = "0x712C30", VA = "0x180713A30")]
		public Resolution(uint CNMHAFPCMJK, uint HNFKJOACHLJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x51C9A90", Offset = "0x51C8C90", VA = "0x1851C9A90")]
		public static Resolution GAICJDADLNA(Resolution[] IBNFHBKFNLG, Resolution HFFJMMCMLFA, int KHKJHIKLBGA)
		{
			return default(Resolution);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public class LOOLBKBPFPF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private readonly Resolution COJOIHOFAHP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private Resolution? DAPODBAEMFE;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public uint CNMHAFPCMJK
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x51C8A40", Offset = "0x51C7C40", VA = "0x1851C8A40")]
			get
			{
				return default(uint);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public uint HNFKJOACHLJ
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x51C8850", Offset = "0x51C7A50", VA = "0x1851C8850")]
			get
			{
				return default(uint);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public Resolution FAIIMKIIIHE
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x51C8650", Offset = "0x51C7850", VA = "0x1851C8650")]
			get
			{
				return default(Resolution);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x16B5D80", Offset = "0x16B4F80", VA = "0x1816B5D80")]
		public LOOLBKBPFPF(Resolution COJOIHOFAHP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x51C8870", Offset = "0x51C7A70", VA = "0x1851C8870")]
		private static Resolution KAPNOIKAOFF(Resolution DAPODBAEMFE, AKLINJEJGMD BOHEMNBKEFE)
		{
			return default(Resolution);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public static class NPPHDPFLFHJ
	{
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public static readonly Resolution DONBKKCABPG;

		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public static readonly Resolution FLIHMJADBKB;

		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public static readonly Resolution DHLBAPLCINI;

		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public static readonly Resolution PFKPLJMNCJK;

		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public static readonly Resolution NGHOEEBIJFG;

		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public static readonly Resolution MBMCMHABEDD;

		[Cpp2IlInjected.Token(Token = "0x4000014")]
		internal static readonly Resolution[] NLMBJJABNEM;
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public static class LGOOCDDGOIA
	{
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public static readonly Resolution DKGKBKFBLHI;

		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public static readonly Resolution PEJNJPKPALL;

		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public static readonly Resolution INFEDHAIHEN;

		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public static readonly Resolution BDFEMJLPDPC;

		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public static readonly Resolution CHBLENOFCHO;

		[Cpp2IlInjected.Token(Token = "0x400001A")]
		internal static readonly Resolution[] NLMBJJABNEM;

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x51C82B0", Offset = "0x51C74B0", VA = "0x1851C82B0")]
		public static Resolution OFFJMHOFGHE(uint HDKAONFKHGH)
		{
			return default(Resolution);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public static readonly Resolution ONOPLECECEM;

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x51C7FE0", Offset = "0x51C71E0", VA = "0x1851C7FE0")]
	public static bool JEPOFHOOBJC(uint DLCMKMGGLKO)
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
		public enum OALNEKFINGK : byte
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
		private class LEDONGDEICD : IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			private string KFCJDHCECCC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			public Texture2D DMOGONEDIMG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400002C")]
			public OALNEKFINGK MECPNFAAMAH;

			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x51C8260", Offset = "0x51C7460", VA = "0x1851C8260")]
			public LEDONGDEICD(string KFCJDHCECCC)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x8DCE60", Offset = "0x8DC060", VA = "0x1808DCE60")]
			public LEDONGDEICD(string KFCJDHCECCC, Texture2D IHADKGPJABJ, OALNEKFINGK FFLCICECDHB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x51C8220", Offset = "0x51C7420", VA = "0x1851C8220", Slot = "4")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000D")]
		[CompilerGenerated]
		private sealed class DAICJLEFHDB
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400002D")]
			public ManagedTexture <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400002E")]
			public OALNEKFINGK textureMemory;

			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x58CAB0", Offset = "0x58BCB0", VA = "0x18058CAB0")]
			public DAICJLEFHDB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x51C7D10", Offset = "0x51C6F10", VA = "0x1851C7D10")]
			internal void <GetManagedTexture>b__0()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000E")]
		[CompilerGenerated]
		private sealed class INLAHLIIJCJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400002F")]
			public int quality;

			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x58CAB0", Offset = "0x58BCB0", VA = "0x18058CAB0")]
			public INLAHLIIJCJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x51C7FC0", Offset = "0x51C71C0", VA = "0x1851C7FC0")]
			internal byte[] <EncodeToJPG>b__0(Texture2D t2d)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000F")]
		[CompilerGenerated]
		private sealed class GKONIMMAGJN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000030")]
			public RenderTexture tempRenderTexture;

			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x58CAB0", Offset = "0x58BCB0", VA = "0x18058CAB0")]
			public GKONIMMAGJN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x51C7F30", Offset = "0x51C7130", VA = "0x1851C7F30")]
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
		private global::FJLAHCBCPIJ<Texture2D> _cpuSidePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private LEDONGDEICD _memTexture;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private global::FJLAHCBCPIJ<byte[]> _jpgEncodePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private byte[] _jpgBytes;

		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public const int DEFAULT_JPG_QUALITY = 80;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private global::FJLAHCBCPIJ<byte[]> _pngEncodePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private byte[] _pngBytes;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public bool UsePalette
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x5B57B0", Offset = "0x5B49B0", VA = "0x1805B57B0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public RenderTexture LastRenderTexture
		{
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x58CDF0", Offset = "0x58BFF0", VA = "0x18058CDF0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x5B4D70", Offset = "0x5B3F70", VA = "0x1805B4D70")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		private LEDONGDEICD memoryTexture
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x51C9780", Offset = "0x51C8980", VA = "0x1851C9780")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x51C96D0", Offset = "0x51C88D0", VA = "0x1851C96D0")]
		public ManagedTexture(string KFCJDHCECCC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x51C9720", Offset = "0x51C8920", VA = "0x1851C9720")]
		public ManagedTexture(string KFCJDHCECCC, bool NEOCLNBCBDF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x51C91B0", Offset = "0x51C83B0", VA = "0x1851C91B0")]
		public void MPBLNPOHGEB(RenderTexture PJJNEPFJNLD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x51C9000", Offset = "0x51C8200", VA = "0x1851C9000")]
		public global::FJLAHCBCPIJ<byte[]> MKHBKDDFGBJ(bool AMNAKAODEKC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x51C8B00", Offset = "0x51C7D00", VA = "0x1851C8B00")]
		public global::FJLAHCBCPIJ<Texture2D> EHKFAEJBMKE(OALNEKFINGK FFLCICECDHB, bool ALIKPAOCNCO = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x51C8D90", Offset = "0x51C7F90", VA = "0x1851C8D90")]
		public global::FJLAHCBCPIJ<byte[]> IHBDAHOHPFB(bool ALIKPAOCNCO = false, int BHBPPOIKJLF = 80)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x51C9020", Offset = "0x51C8220", VA = "0x1851C9020")]
		public global::FJLAHCBCPIJ<byte[]> MMKFHNMKDPL(bool ALIKPAOCNCO = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x51C91E0", Offset = "0x51C83E0", VA = "0x1851C91E0")]
		private static global::FJLAHCBCPIJ<Texture2D> NELHBNOFJLJ(string KFCJDHCECCC, RenderTexture PJJNEPFJNLD, ref Texture2D CDAELACOAHO, bool ALIKPAOCNCO, OALNEKFINGK KAAGFCEHGBE = OALNEKFINGK.GPU)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x51C8F40", Offset = "0x51C8140", VA = "0x1851C8F40")]
		public void JKBCMAMNLPO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x51C8AF0", Offset = "0x51C7CF0", VA = "0x1851C8AF0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x51C8A50", Offset = "0x51C7C50", VA = "0x1851C8A50")]
		[CompilerGenerated]
		private global::FJLAHCBCPIJ<byte[]> BGFNDKHMGAF(Texture2D FGDNEMBGNGM)
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public static class EGCLHKBABBB
{
	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x51C7DC0", Offset = "0x51C6FC0", VA = "0x1851C7DC0")]
	public static RenderTexture MMEHDCDPGDA(int HDKAONFKHGH, int IPFKOEAAMDI, int MJDCBDAMEKF, Camera BHFABKKIGAB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x51C7D50", Offset = "0x51C6F50", VA = "0x1851C7D50")]
	public static void EKPFAKJCMOH(RenderTexture PJJNEPFJNLD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class CFPJIAKCECG
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public class EAKAFCEJBJE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public int NDIGKIEANGO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public int EGKHKAOEMCJ;

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x623350", Offset = "0x622550", VA = "0x180623350")]
		public EAKAFCEJBJE(int JJPOEPNDEKK, int NBMFBMPPBLJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	private enum ACDNEBKNJJB
	{
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		Point,
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		Bilinear,
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		Average
	}

	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private static Color[] FDBACKFPGJA;

	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private static Color[] KDKIIHDDLNG;

	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private static int OPOOFMFPPJH;

	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private static float NBDODNGIACP;

	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private static float OABDPDCDCAM;

	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private static int AKMHJICIJDG;

	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private static int KBJJPPEALGK;

	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private static Mutex JINMCLNNLFN;

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x51C7CD0", Offset = "0x51C6ED0", VA = "0x1851C7CD0")]
	public static void PAJNMDLAIDN(Texture2D KBDFNPIKKAI, int PCNJAKCGBPO, int OEDGHBMIEDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x51C6C90", Offset = "0x51C5E90", VA = "0x1851C6C90")]
	private static void AAOHOCHAAAL(Texture2D KBDFNPIKKAI, int PCNJAKCGBPO, int OEDGHBMIEDK, ACDNEBKNJJB JLFMEHNCONN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x51C7320", Offset = "0x51C6520", VA = "0x1851C7320")]
	public static void IFEBKBKECEG(object ANFJLMLDELH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x51C7140", Offset = "0x51C6340", VA = "0x1851C7140")]
	public static void GPIHGFNEJDA(object ANFJLMLDELH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x51C7840", Offset = "0x51C6A40", VA = "0x1851C7840")]
	private static Color MBPEDMLGBMC(int CNMHAFPCMJK, int HNFKJOACHLJ, float NBDODNGIACP, float OABDPDCDCAM)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x51C7AF0", Offset = "0x51C6CF0", VA = "0x1851C7AF0")]
	public static void NBHINAMIFBJ(object ANFJLMLDELH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x51C7A00", Offset = "0x51C6C00", VA = "0x1851C7A00")]
	private static Color MICOKKMODHF(Color ECOKKINBCAF, Color AAKFLAELBPM, float LDPMPDNIHLJ)
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
