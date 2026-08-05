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
		[Cpp2IlInjected.Address(RVA = "0x17ABAF0", Offset = "0x17AA6F0", VA = "0x1817ABAF0")]
		public CubeMapGenerator()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public enum ABDNOHPLODF
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
public interface KFMNGLOEGFN
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	ABDNOHPLODF NEGPHEGPCGE
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class LJINICACMOF
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
			[Cpp2IlInjected.Address(RVA = "0x17AEA50", Offset = "0x17AD650", VA = "0x1817AEA50")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x17AEA40", Offset = "0x17AD640", VA = "0x1817AEA40")]
		public Resolution(uint PKLHFCEKMJB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x69CBD0", Offset = "0x69B7D0", VA = "0x18069CBD0")]
		public Resolution(uint PKLHFCEKMJB, uint JGEGPABGNNL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x17AE8F0", Offset = "0x17AD4F0", VA = "0x1817AE8F0")]
		public static Resolution DHKNDKJOLPD(Resolution[] GKGHHNOLMOP, Resolution GLKFNPDGEHF, int ENLKMJNDLAF)
		{
			return default(Resolution);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public class KIAGJIFKKPC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private readonly Resolution LHLKINCCPLI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private Resolution? ILKHJPOMDNJ;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public uint PKLHFCEKMJB
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x17AD390", Offset = "0x17ABF90", VA = "0x1817AD390")]
			get
			{
				return default(uint);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public uint JGEGPABGNNL
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x17AD1A0", Offset = "0x17ABDA0", VA = "0x1817AD1A0")]
			get
			{
				return default(uint);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public Resolution DALFCPPEMEA
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x17ACFA0", Offset = "0x17ABBA0", VA = "0x1817ACFA0")]
			get
			{
				return default(Resolution);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x5BA9F0", Offset = "0x5B95F0", VA = "0x1805BA9F0")]
		public KIAGJIFKKPC(Resolution LHLKINCCPLI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x17AD1C0", Offset = "0x17ABDC0", VA = "0x1817AD1C0")]
		private static Resolution JLCMEKMBABM(Resolution ILKHJPOMDNJ, ABDNOHPLODF MDMKFNLNNOB)
		{
			return default(Resolution);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public static class NLDNNDCEPIM
	{
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public static readonly Resolution MFFFBHAJHGP;

		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public static readonly Resolution DEGILKDIIEG;

		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public static readonly Resolution OLAJKIPPDKF;

		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public static readonly Resolution MPJGJDIHKHP;

		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public static readonly Resolution FBNMMPLMIPK;

		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public static readonly Resolution BCGLABEOOND;

		[Cpp2IlInjected.Token(Token = "0x4000014")]
		internal static readonly Resolution[] KJDJBNGEFMK;
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public static class GGNAPABNBBC
	{
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public static readonly Resolution HEKAKPNOFHC;

		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public static readonly Resolution CJEPJMHLEKB;

		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public static readonly Resolution NFCIMGFLEGB;

		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public static readonly Resolution HBKIOKAEBPC;

		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public static readonly Resolution KNFFNDLDMBF;

		[Cpp2IlInjected.Token(Token = "0x400001A")]
		internal static readonly Resolution[] KJDJBNGEFMK;

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x17ABB10", Offset = "0x17AA710", VA = "0x1817ABB10")]
		public static Resolution FEDOPEGHDMB(uint LOAJHEIDPPI)
		{
			return default(Resolution);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public static readonly Resolution IDCKHOGBDGP;

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x17AD3C0", Offset = "0x17ABFC0", VA = "0x1817AD3C0")]
	public static bool MIAGBEAOOGC(uint BEPGNDGLPLC)
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
		public enum MMPIFNFIGOJ : byte
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
		private class PIEJICFJLHP : IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			private string FFOAIHIIDHB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			public Texture2D KAENPCPGKDK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400002C")]
			public MMPIFNFIGOJ CAIGCFGNKLH;

			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x17AE6C0", Offset = "0x17AD2C0", VA = "0x1817AE6C0")]
			public PIEJICFJLHP(string FFOAIHIIDHB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x107CC30", Offset = "0x107B830", VA = "0x18107CC30")]
			public PIEJICFJLHP(string FFOAIHIIDHB, Texture2D OKMFAPACDHF, MMPIFNFIGOJ AGHFCOADLJN)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x17AE680", Offset = "0x17AD280", VA = "0x1817AE680", Slot = "4")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000D")]
		[CompilerGenerated]
		private sealed class MEJOCKADAIP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400002D")]
			public ManagedTexture <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400002E")]
			public MMPIFNFIGOJ textureMemory;

			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x54F000", Offset = "0x54DC00", VA = "0x18054F000")]
			public MEJOCKADAIP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x17AD600", Offset = "0x17AC200", VA = "0x1817AD600")]
			internal void <GetManagedTexture>b__0()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000E")]
		[CompilerGenerated]
		private sealed class LCELAPKCBEH
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400002F")]
			public int quality;

			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x54F000", Offset = "0x54DC00", VA = "0x18054F000")]
			public LCELAPKCBEH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x17AD3A0", Offset = "0x17ABFA0", VA = "0x1817AD3A0")]
			internal byte[] <EncodeToJPG>b__0(Texture2D t2d)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000F")]
		[CompilerGenerated]
		private sealed class IDAAEHGEKCA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000030")]
			public RenderTexture tempRenderTexture;

			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x54F000", Offset = "0x54DC00", VA = "0x18054F000")]
			public IDAAEHGEKCA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x17ABEB0", Offset = "0x17AAAB0", VA = "0x1817ABEB0")]
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
		private global::NHGODCKFGMA<Texture2D> _cpuSidePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private PIEJICFJLHP _memTexture;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private global::NHGODCKFGMA<byte[]> _jpgEncodePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private byte[] _jpgBytes;

		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public const int DEFAULT_JPG_QUALITY = 80;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private global::NHGODCKFGMA<byte[]> _pngEncodePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private byte[] _pngBytes;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public bool UsePalette
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x62AF80", Offset = "0x629B80", VA = "0x18062AF80")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public RenderTexture LastRenderTexture
		{
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x5534B0", Offset = "0x5520B0", VA = "0x1805534B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x556540", Offset = "0x555140", VA = "0x180556540")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		private PIEJICFJLHP memoryTexture
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x17AE370", Offset = "0x17ACF70", VA = "0x1817AE370")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x17AE2C0", Offset = "0x17ACEC0", VA = "0x1817AE2C0")]
		public ManagedTexture(string FFOAIHIIDHB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x17AE310", Offset = "0x17ACF10", VA = "0x1817AE310")]
		public ManagedTexture(string FFOAIHIIDHB, bool HJMBCMLKMJP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x17AE290", Offset = "0x17ACE90", VA = "0x1817AE290")]
		public void PPBCIMLBGCH(RenderTexture OELHFLGPLLF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x17ADFF0", Offset = "0x17ACBF0", VA = "0x1817ADFF0")]
		public global::NHGODCKFGMA<byte[]> DOJCLGFBJJO(bool KDLMNHJLNBC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x17AD870", Offset = "0x17AC470", VA = "0x1817AD870")]
		public global::NHGODCKFGMA<Texture2D> CANPCFPJLAI(MMPIFNFIGOJ AGHFCOADLJN, bool NJCKLAMEHBH = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x17AE0E0", Offset = "0x17ACCE0", VA = "0x1817AE0E0")]
		public global::NHGODCKFGMA<byte[]> GEHCJPPMHPC(bool NJCKLAMEHBH = false, int EDHHENJILMD = 80)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x17AD640", Offset = "0x17AC240", VA = "0x1817AD640")]
		public global::NHGODCKFGMA<byte[]> BBAMNPJOOBN(bool NJCKLAMEHBH = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x17ADB00", Offset = "0x17AC700", VA = "0x1817ADB00")]
		private static global::NHGODCKFGMA<Texture2D> DKDAJEDGIPL(string FFOAIHIIDHB, RenderTexture OELHFLGPLLF, ref Texture2D GGPFFDMCHFK, bool NJCKLAMEHBH, MMPIFNFIGOJ GGIHJJCOPGB = MMPIFNFIGOJ.GPU)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x17AE020", Offset = "0x17ACC20", VA = "0x1817AE020")]
		public void FGLKJJEPHMB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x17AE010", Offset = "0x17ACC10", VA = "0x1817AE010", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x17AD7D0", Offset = "0x17AC3D0", VA = "0x1817AD7D0")]
		[CompilerGenerated]
		private global::NHGODCKFGMA<byte[]> BNPCDLMKELO(Texture2D NKBIMIJPIDO)
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public static class PJONEBFJEBO
{
	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x17AE780", Offset = "0x17AD380", VA = "0x1817AE780")]
	public static RenderTexture NOEEFOLJHBJ(int LOAJHEIDPPI, int KBNEJJFCEEJ, int JPOCGFPMJDP, Camera BBPAACDOCIG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x17AE710", Offset = "0x17AD310", VA = "0x1817AE710")]
	public static void BKJGNHMCFKM(RenderTexture OELHFLGPLLF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class INBCEPNGOGL
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public class NJKFHNCHAAM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public int HKPOEHACKEK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public int DMAGKBIPPNM;

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x641940", Offset = "0x640540", VA = "0x180641940")]
		public NJKFHNCHAAM(int EPDNHJIJDCH, int AADNPGFOACH)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	private enum OAJCINLBFLO
	{
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		Point,
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		Bilinear,
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		Average
	}

	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private static Color[] LCFEABCPENM;

	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private static Color[] CONDLLJNMHC;

	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private static int DGOIKAEPCOF;

	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private static float PNFCJOOBKJM;

	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private static float IAJDOBJPAOI;

	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private static int OOLDIBBMLKN;

	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private static int GBBJAPFGNNE;

	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private static Mutex MBHHDIGHHOM;

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x17ACAF0", Offset = "0x17AB6F0", VA = "0x1817ACAF0")]
	public static void HFBAMDDKIGD(Texture2D DFLGIBDAJEH, int GIBHDNFNGCP, int PHKDBCENJGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x17AC120", Offset = "0x17AAD20", VA = "0x1817AC120")]
	private static void ECMKFGFLEHJ(Texture2D DFLGIBDAJEH, int GIBHDNFNGCP, int PHKDBCENJGO, OAJCINLBFLO JDBEJANMNJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x17AC5D0", Offset = "0x17AB1D0", VA = "0x1817AC5D0")]
	public static void GEFBAGBDOIF(object KLDDDNGBABC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x17ABF40", Offset = "0x17AAB40", VA = "0x1817ABF40")]
	public static void DNBDAHLBMLF(object KLDDDNGBABC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x17ACB10", Offset = "0x17AB710", VA = "0x1817ACB10")]
	private static Color IPNKGMGJGLE(int PKLHFCEKMJB, int JGEGPABGNNL, float PNFCJOOBKJM, float IAJDOBJPAOI)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x17ACCD0", Offset = "0x17AB8D0", VA = "0x1817ACCD0")]
	public static void JINGALJPHBL(object KLDDDNGBABC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x17ACEB0", Offset = "0x17ABAB0", VA = "0x1817ACEB0")]
	private static Color OMHHMLJBFKG(Color BGFGGKMJJPL, Color PANHEFENLDL, float JHEBJPCMJGD)
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
