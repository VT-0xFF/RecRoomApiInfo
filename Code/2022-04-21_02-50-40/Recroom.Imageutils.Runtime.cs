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
		[Cpp2IlInjected.Address(RVA = "0x4BD3B30", Offset = "0x4BD2B30", VA = "0x184BD3B30")]
		public CubeMapGenerator()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public enum EGIMNDAJDEC
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
public interface PBCBHNMLAEB
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	EGIMNDAJDEC GIHOHPJBLGC
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class MGKLDFNNHJK
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
			[Cpp2IlInjected.Address(RVA = "0x4BD5A30", Offset = "0x4BD4A30", VA = "0x184BD5A30")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x4BD5A20", Offset = "0x4BD4A20", VA = "0x184BD5A20")]
		public Resolution(uint PACPIJAANIO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x6D9110", Offset = "0x6D8110", VA = "0x1806D9110")]
		public Resolution(uint PACPIJAANIO, uint OKDBMFJJANH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x4BD58D0", Offset = "0x4BD48D0", VA = "0x184BD58D0")]
		public static Resolution ENHHAIEJGON(Resolution[] OHJPMCLGHLF, Resolution HMNCLNNJHHI, int GONMEFHNMGL)
		{
			return default(Resolution);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public class NCOAANELIEO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private readonly Resolution JFMPOGPGGBH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private Resolution? JHCHEKCKPPK;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public uint PACPIJAANIO
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x4BD56F0", Offset = "0x4BD46F0", VA = "0x184BD56F0")]
			get
			{
				return default(uint);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public uint OKDBMFJJANH
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x4BD54D0", Offset = "0x4BD44D0", VA = "0x184BD54D0")]
			get
			{
				return default(uint);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public Resolution OMDNGMPPEDN
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x4BD54F0", Offset = "0x4BD44F0", VA = "0x184BD54F0")]
			get
			{
				return default(Resolution);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x10D0E00", Offset = "0x10CFE00", VA = "0x1810D0E00")]
		public NCOAANELIEO(Resolution JFMPOGPGGBH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x4BD5700", Offset = "0x4BD4700", VA = "0x184BD5700")]
		private static Resolution PJJFIMPMNFP(Resolution JHCHEKCKPPK, EGIMNDAJDEC ODPAILNOOMM)
		{
			return default(Resolution);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public static class DFNEFOMLCBA
	{
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public static readonly Resolution OGIENOGDCPD;

		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public static readonly Resolution HKGCBNBDPIO;

		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public static readonly Resolution LDCPBKAMLIC;

		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public static readonly Resolution LGEIDOCOHEP;

		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public static readonly Resolution DPHOAFJGCDI;

		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public static readonly Resolution ENHDMDNMBNI;

		[Cpp2IlInjected.Token(Token = "0x4000014")]
		internal static readonly Resolution[] MHHPPBBPJMD;
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public static class FHNLPBBMKJB
	{
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public static readonly Resolution HHFHHLIBKDG;

		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public static readonly Resolution GMKPNIFCGME;

		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public static readonly Resolution GKIKIGKPAIN;

		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public static readonly Resolution PLPCFBJPEAI;

		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public static readonly Resolution PJDILFGNBAK;

		[Cpp2IlInjected.Token(Token = "0x400001A")]
		internal static readonly Resolution[] MHHPPBBPJMD;

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x4BD3FE0", Offset = "0x4BD2FE0", VA = "0x184BD3FE0")]
		public static Resolution BPANLPINPIL(uint DNPKPAMDPOM)
		{
			return default(Resolution);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public static readonly Resolution JHILFAJNHKC;

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x4BD44C0", Offset = "0x4BD34C0", VA = "0x184BD44C0")]
	public static bool DIPINHHPAAB(uint PNKEHKDEJJG)
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
		public enum MFDPOIJABPJ : byte
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
		private class ICGBNOCNEDD : IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			private string PABPMLLKDBG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			public Texture2D FNJLNIGGEFB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400002C")]
			public MFDPOIJABPJ NHLHEMODMCI;

			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x4BD43E0", Offset = "0x4BD33E0", VA = "0x184BD43E0")]
			public ICGBNOCNEDD(string PABPMLLKDBG)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x894290", Offset = "0x893290", VA = "0x180894290")]
			public ICGBNOCNEDD(string PABPMLLKDBG, Texture2D GFKJBBMHOHC, MFDPOIJABPJ EFHEAMCOAMM)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x4BD43A0", Offset = "0x4BD33A0", VA = "0x184BD43A0", Slot = "4")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000D")]
		[CompilerGenerated]
		private sealed class EOJKFHDPHLB
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400002D")]
			public ManagedTexture <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400002E")]
			public MFDPOIJABPJ textureMemory;

			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x525AB0", Offset = "0x524AB0", VA = "0x180525AB0")]
			public EOJKFHDPHLB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x4BD3FA0", Offset = "0x4BD2FA0", VA = "0x184BD3FA0")]
			internal void <GetManagedTexture>b__0()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000E")]
		[CompilerGenerated]
		private sealed class GGPPEFPDMMP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400002F")]
			public int quality;

			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x525AB0", Offset = "0x524AB0", VA = "0x180525AB0")]
			public GGPPEFPDMMP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x4BD4380", Offset = "0x4BD3380", VA = "0x184BD4380")]
			internal byte[] <EncodeToJPG>b__0(Texture2D t2d)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000F")]
		[CompilerGenerated]
		private sealed class JAOCBEOJDBD
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000030")]
			public RenderTexture tempRenderTexture;

			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x525AB0", Offset = "0x524AB0", VA = "0x180525AB0")]
			public JAOCBEOJDBD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x4BD4430", Offset = "0x4BD3430", VA = "0x184BD4430")]
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
		private global::GIFPPDKJJDK<Texture2D> _cpuSidePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private ICGBNOCNEDD _memTexture;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private global::GIFPPDKJJDK<byte[]> _jpgEncodePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private byte[] _jpgBytes;

		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public const int DEFAULT_JPG_QUALITY = 80;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private global::GIFPPDKJJDK<byte[]> _pngEncodePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private byte[] _pngBytes;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public bool UsePalette
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x54E7B0", Offset = "0x54D7B0", VA = "0x18054E7B0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public RenderTexture LastRenderTexture
		{
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x525DF0", Offset = "0x524DF0", VA = "0x180525DF0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x54DD70", Offset = "0x54CD70", VA = "0x18054DD70")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		private ICGBNOCNEDD memoryTexture
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x4BD5430", Offset = "0x4BD4430", VA = "0x184BD5430")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x4BD53E0", Offset = "0x4BD43E0", VA = "0x184BD53E0")]
		public ManagedTexture(string PABPMLLKDBG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x4BD5380", Offset = "0x4BD4380", VA = "0x184BD5380")]
		public ManagedTexture(string PABPMLLKDBG, bool HGPJDHFIDAP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x4BD5350", Offset = "0x4BD4350", VA = "0x184BD5350")]
		public void PMCGCMEEKKP(RenderTexture CBLPGLENDIH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x4BD50A0", Offset = "0x4BD40A0", VA = "0x184BD50A0")]
		public global::GIFPPDKJJDK<byte[]> NEBCFFEGNDO(bool ACNGAHEGLPF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x4BD50C0", Offset = "0x4BD40C0", VA = "0x184BD50C0")]
		public global::GIFPPDKJJDK<Texture2D> NFGJNCEOLKN(MFDPOIJABPJ EFHEAMCOAMM, bool GABHLMFNPBO = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x4BD4E50", Offset = "0x4BD3E50", VA = "0x184BD4E50")]
		public global::GIFPPDKJJDK<byte[]> LJEFDNPHBNF(bool GABHLMFNPBO = false, int DJHEHCCMNAL = 80)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x4BD4CC0", Offset = "0x4BD3CC0", VA = "0x184BD4CC0")]
		public global::GIFPPDKJJDK<byte[]> LHKOGPLDIBA(bool GABHLMFNPBO = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x4BD4700", Offset = "0x4BD3700", VA = "0x184BD4700")]
		private static global::GIFPPDKJJDK<Texture2D> DHMIHDBOLMP(string PABPMLLKDBG, RenderTexture CBLPGLENDIH, ref Texture2D MCIKJOJNNEH, bool GABHLMFNPBO, MFDPOIJABPJ BCAIFIFHKFI = MFDPOIJABPJ.GPU)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x4BD4C00", Offset = "0x4BD3C00", VA = "0x184BD4C00")]
		public void EOBHFPCJIBM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x4BD4BF0", Offset = "0x4BD3BF0", VA = "0x184BD4BF0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x4BD5000", Offset = "0x4BD4000", VA = "0x184BD5000")]
		[CompilerGenerated]
		private global::GIFPPDKJJDK<byte[]> NDMPBPKGLDN(Texture2D BAKILJDPDEH)
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public static class DNJEBOJPMKO
{
	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x4BD3DC0", Offset = "0x4BD2DC0", VA = "0x184BD3DC0")]
	public static RenderTexture AFGMOGCBHIB(int DNPKPAMDPOM, int OFPEKKPMEGK, int CLOKNLNKIIJ, Camera DGEGEJENMLC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x4BD3F30", Offset = "0x4BD2F30", VA = "0x184BD3F30")]
	public static void ODAFAADLMEJ(RenderTexture CBLPGLENDIH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class CENABAFLFLB
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public class JHGEBAGAFFA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public int CLGDKNKBLCJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public int NJGCNBGINJK;

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x5BC350", Offset = "0x5BB350", VA = "0x1805BC350")]
		public JHGEBAGAFFA(int KEJBKAOADAJ, int KECOEODIMDM)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	private enum HMOADLGONPG
	{
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		Point,
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		Bilinear,
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		Average
	}

	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private static Color[] PODKKELGBNF;

	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private static Color[] ECKHMKAEKCF;

	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private static int IBICEGJOGOF;

	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private static float LCKPIJPOBDK;

	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private static float JOKACIMDBEF;

	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private static int KGFJAKNKFBB;

	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private static int KBFIEKPNLKL;

	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private static Mutex OFLIHBACPOF;

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x4BD3B10", Offset = "0x4BD2B10", VA = "0x184BD3B10")]
	public static void NKDHNHBMJKA(Texture2D BGHNEHLOOFD, int KHBGPCGMHME, int GEMPIJDDCAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x4BD2DA0", Offset = "0x4BD1DA0", VA = "0x184BD2DA0")]
	private static void FLAFDKPEAOK(Texture2D BGHNEHLOOFD, int KHBGPCGMHME, int GEMPIJDDCAH, HMOADLGONPG PMNBFCIBCNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x4BD35F0", Offset = "0x4BD25F0", VA = "0x184BD35F0")]
	public static void KMOCJOILKDP(object HAFCDCMNBJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x4BD2BC0", Offset = "0x4BD1BC0", VA = "0x184BD2BC0")]
	public static void FHHNBDGOKAC(object HAFCDCMNBJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x4BD3430", Offset = "0x4BD2430", VA = "0x184BD3430")]
	private static Color KAJALEPMMDN(int PACPIJAANIO, int OKDBMFJJANH, float LCKPIJPOBDK, float JOKACIMDBEF)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x4BD3250", Offset = "0x4BD2250", VA = "0x184BD3250")]
	public static void HECOGEMFHEG(object HAFCDCMNBJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x4BD2AD0", Offset = "0x4BD1AD0", VA = "0x184BD2AD0")]
	private static Color ENIDMCKOGMD(Color IEKKNIEGIBI, Color KJDFEAGMLOO, float PLIDGBGAHIA)
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
