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
		[Cpp2IlInjected.Address(RVA = "0x6AF7A80", Offset = "0x6AF6880", VA = "0x186AF7A80")]
		public CubeMapGenerator()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public enum GFAJKGCMJEB
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
public interface HAMOOCPFFPL
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	GFAJKGCMJEB HNDPBHMBDLO
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class DDCNLGEBINB
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
			[Cpp2IlInjected.Address(RVA = "0x6AFA4C0", Offset = "0x6AF92C0", VA = "0x186AFA4C0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x6AFA4B0", Offset = "0x6AF92B0", VA = "0x186AFA4B0")]
		public Resolution(uint NHKCICGBPMI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x7621E0", Offset = "0x760FE0", VA = "0x1807621E0")]
		public Resolution(uint NHKCICGBPMI, uint PEKPPEFFGIG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x6AFA3C0", Offset = "0x6AF91C0", VA = "0x186AFA3C0")]
		public static Resolution KJJDIMPOPGE(Resolution[] IFLCOEMLDOM, Resolution KEOKBEBOAJL, int LKMJAMHHJKK)
		{
			return default(Resolution);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public class BMKGANBKMLL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private readonly Resolution JIKFFNICLCG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private Resolution? IMJHKPCOBLG;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public uint NHKCICGBPMI
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x6AF78B0", Offset = "0x6AF66B0", VA = "0x186AF78B0")]
			get
			{
				return default(uint);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public uint PEKPPEFFGIG
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x6AF78C0", Offset = "0x6AF66C0", VA = "0x186AF78C0")]
			get
			{
				return default(uint);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public Resolution PFPBJOJBLDK
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x6AF76D0", Offset = "0x6AF64D0", VA = "0x186AF76D0")]
			get
			{
				return default(Resolution);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x1A4A7B0", Offset = "0x1A495B0", VA = "0x181A4A7B0")]
		public BMKGANBKMLL(Resolution JIKFFNICLCG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x6AF78E0", Offset = "0x6AF66E0", VA = "0x186AF78E0")]
		private static Resolution PGGHJEJPEBI(Resolution IMJHKPCOBLG, GFAJKGCMJEB EHFDKIEKAGI)
		{
			return default(Resolution);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public static class OAGKNODPCBO
	{
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public static readonly Resolution AHCAIALDPOJ;

		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public static readonly Resolution KIKGONODLOI;

		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public static readonly Resolution ACIHBKCKIEJ;

		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public static readonly Resolution OFJOJDBKAIG;

		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public static readonly Resolution EPINBAAAIIE;

		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public static readonly Resolution BJFAPCFAEIL;

		[Cpp2IlInjected.Token(Token = "0x4000014")]
		internal static readonly Resolution[] DCENDHGJICB;
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public static class KGMMFBIKEEH
	{
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public static readonly Resolution NMCPINJEIDD;

		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public static readonly Resolution PFKJAKCKOFB;

		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public static readonly Resolution OBKEIPNHAGA;

		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public static readonly Resolution OFABBGPPCFH;

		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public static readonly Resolution COHBFMMBPNN;

		[Cpp2IlInjected.Token(Token = "0x400001A")]
		internal static readonly Resolution[] DCENDHGJICB;

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x6AF8E10", Offset = "0x6AF7C10", VA = "0x186AF8E10")]
		public static Resolution NFCEJJOGAPB(uint NMEFFJNNPPL)
		{
			return default(Resolution);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public static readonly Resolution IDAFFMLJALI;

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x6AF7AA0", Offset = "0x6AF68A0", VA = "0x186AF7AA0")]
	public static bool BHJKPHIFGLF(uint LLPKAFIHFAL)
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
		public enum JFDFCFMDBLC : byte
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
		private class EDJMNHNIJHO : IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			private string ICIEGOLHGJN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			public Texture2D AILIAHAEHJP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400002C")]
			public JFDFCFMDBLC HPOGFJLKCIH;

			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x6AF7D40", Offset = "0x6AF6B40", VA = "0x186AF7D40")]
			public EDJMNHNIJHO(string ICIEGOLHGJN)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x747D80", Offset = "0x746B80", VA = "0x180747D80")]
			public EDJMNHNIJHO(string ICIEGOLHGJN, Texture2D HICKPGGKAPE, JFDFCFMDBLC NHGDGLMKGIB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x6AF7D00", Offset = "0x6AF6B00", VA = "0x186AF7D00", Slot = "4")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000D")]
		[CompilerGenerated]
		private sealed class JNADNGPPBKC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400002D")]
			public ManagedTexture <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400002E")]
			public JFDFCFMDBLC textureMemory;

			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30")]
			public JNADNGPPBKC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x6AF8DD0", Offset = "0x6AF7BD0", VA = "0x186AF8DD0")]
			internal void <GetManagedTexture>b__0()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000E")]
		[CompilerGenerated]
		private sealed class LBKJOJEPKGO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400002F")]
			public int quality;

			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30")]
			public LBKJOJEPKGO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x6AF91D0", Offset = "0x6AF7FD0", VA = "0x186AF91D0")]
			internal byte[] <EncodeToJPG>b__0(Texture2D t2d)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000F")]
		[CompilerGenerated]
		private sealed class EOOHFOHMGCJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000030")]
			public RenderTexture tempRenderTexture;

			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30")]
			public EOOHFOHMGCJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x6AF7D90", Offset = "0x6AF6B90", VA = "0x186AF7D90")]
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
		private global::OOLBMJPBBIG<Texture2D> _cpuSidePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private EDJMNHNIJHO _memTexture;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private global::OOLBMJPBBIG<byte[]> _jpgEncodePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private byte[] _jpgBytes;

		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public const int DEFAULT_JPG_QUALITY = 80;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private global::OOLBMJPBBIG<byte[]> _pngEncodePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private byte[] _pngBytes;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public bool UsePalette
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x745880", Offset = "0x744680", VA = "0x180745880")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public RenderTexture LastRenderTexture
		{
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x741120", Offset = "0x73FF20", VA = "0x180741120")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x741130", Offset = "0x73FF30", VA = "0x180741130")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		private EDJMNHNIJHO memoryTexture
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x6AFA0A0", Offset = "0x6AF8EA0", VA = "0x186AFA0A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x6AFA050", Offset = "0x6AF8E50", VA = "0x186AFA050")]
		public ManagedTexture(string ICIEGOLHGJN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x6AF9FF0", Offset = "0x6AF8DF0", VA = "0x186AF9FF0")]
		public ManagedTexture(string ICIEGOLHGJN, bool JANEKDOAJEN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x6AF91F0", Offset = "0x6AF7FF0", VA = "0x186AF91F0")]
		public void ABNHDGIMBIO(RenderTexture MHGCFGLEIOE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x6AF9430", Offset = "0x6AF8230", VA = "0x186AF9430")]
		public global::OOLBMJPBBIG<byte[]> FHBEFJANJDK(bool KFHIEHNLONM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x6AF9A90", Offset = "0x6AF8890", VA = "0x186AF9A90")]
		public global::OOLBMJPBBIG<Texture2D> INIGEPIMHPM(JFDFCFMDBLC NHGDGLMKGIB, bool JIJDIIIGPBO = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x6AF9220", Offset = "0x6AF8020", VA = "0x186AF9220")]
		public global::OOLBMJPBBIG<byte[]> BGBAJBOABPN(bool JIJDIIIGPBO = false, int LICEKJAFBKG = 80)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x6AF9D80", Offset = "0x6AF8B80", VA = "0x186AF9D80")]
		public global::OOLBMJPBBIG<byte[]> LCFHCDFJPLM(bool JIJDIIIGPBO = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x6AF9450", Offset = "0x6AF8250", VA = "0x186AF9450")]
		private static global::OOLBMJPBBIG<Texture2D> GCBLLFFNMNF(string ICIEGOLHGJN, RenderTexture MHGCFGLEIOE, ref Texture2D CBJJOOMNPDP, bool JIJDIIIGPBO, JFDFCFMDBLC IMJIBLLOFLP = JFDFCFMDBLC.GPU)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x6AF99D0", Offset = "0x6AF87D0", VA = "0x186AF99D0")]
		public void HKEPLMHHHHI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x6AF9420", Offset = "0x6AF8220", VA = "0x186AF9420", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x6AF9F40", Offset = "0x6AF8D40", VA = "0x186AF9F40")]
		[CompilerGenerated]
		private global::OOLBMJPBBIG<byte[]> NCNNKPEODLJ(Texture2D DFFKKELIION)
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public static class AIKJIBLPPPJ
{
	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x6AF7520", Offset = "0x6AF6320", VA = "0x186AF7520")]
	public static RenderTexture PMKJKKNPKHP(int NMEFFJNNPPL, int FPELGIFOMNB, int JDFNCOHPHEI, Camera NBHONKEBOCB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x6AF74B0", Offset = "0x6AF62B0", VA = "0x186AF74B0")]
	public static void AOCBMPILHDC(RenderTexture MHGCFGLEIOE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class IFKFNOMLIBE
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public class PHHMFMLGBLB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public int CKCLNMMLENB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public int KHILBFLOBFB;

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x9159B0", Offset = "0x9147B0", VA = "0x1809159B0")]
		public PHHMFMLGBLB(int NNDKGIFLHME, int EBHODPHNEOL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	private enum CKMBHLAGLFA
	{
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		Point,
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		Bilinear,
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		Average
	}

	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private static Color[] DHPHENOEKNO;

	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private static Color[] MMIGKBNJEEE;

	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private static int DAHBJHMBLLC;

	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private static float FHAPIODBKOC;

	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private static float LBPIIGJEBFB;

	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private static int MDDCHMFLOLJ;

	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private static int MHHOHGEJHNL;

	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private static Mutex JHEAALJIJDP;

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x6AF7E20", Offset = "0x6AF6C20", VA = "0x186AF7E20")]
	public static void CLMMBCOLPHC(Texture2D DDOMIBDDKFJ, int FIFMEOMEJNJ, int LDFOLECOBCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x6AF8540", Offset = "0x6AF7340", VA = "0x186AF8540")]
	private static void OJKBJHBELIG(Texture2D DDOMIBDDKFJ, int FIFMEOMEJNJ, int LDFOLECOBCH, CKMBHLAGLFA LECLKHHDNBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x6AF80C0", Offset = "0x6AF6EC0", VA = "0x186AF80C0")]
	public static void ODMALBFBINJ(object OJGAEOFIMPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x6AF8A30", Offset = "0x6AF7830", VA = "0x186AF8A30")]
	public static void ONBHLHCIGGH(object OJGAEOFIMPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x6AF7F20", Offset = "0x6AF6D20", VA = "0x186AF7F20")]
	private static Color MCMEBCBGIEE(int NHKCICGBPMI, int PEKPPEFFGIG, float FHAPIODBKOC, float LBPIIGJEBFB)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x6AF8C00", Offset = "0x6AF7A00", VA = "0x186AF8C00")]
	public static void PDIDILOGLEN(object OJGAEOFIMPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x6AF7E40", Offset = "0x6AF6C40", VA = "0x186AF7E40")]
	private static Color HCKBDDIBIGO(Color PEPGHJFBNLF, Color HEGFGAGDGOC, float MGFMONLLLPD)
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
