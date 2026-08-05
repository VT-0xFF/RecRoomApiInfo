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
		[Cpp2IlInjected.Address(RVA = "0x660FF50", Offset = "0x660ED50", VA = "0x18660FF50")]
		public CubeMapGenerator()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public enum FKAAEFPMKLL
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
public interface PBAOOKMBJGO
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	FKAAEFPMKLL PBPADGDMKJA
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class MCMJCPMNDHL
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
			[Cpp2IlInjected.Address(RVA = "0x6612D40", Offset = "0x6611B40", VA = "0x186612D40")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x6612D30", Offset = "0x6611B30", VA = "0x186612D30")]
		public Resolution(uint PAMKNJCGOGK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x783340", Offset = "0x782140", VA = "0x180783340")]
		public Resolution(uint PAMKNJCGOGK, uint IOAMOMOPNDK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x6612C40", Offset = "0x6611A40", VA = "0x186612C40")]
		public static Resolution JHEIGDJIMLP(Resolution[] IPBHLLDFLHP, Resolution ICCGBNEIAHF, int DOCKKHBMMMJ)
		{
			return default(Resolution);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public class KGDLACPEJNE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private readonly Resolution MKPDIKHHNMC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private Resolution? CGOKAFPCMGM;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public uint PAMKNJCGOGK
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x6610400", Offset = "0x660F200", VA = "0x186610400")]
			get
			{
				return default(uint);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public uint IOAMOMOPNDK
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x66103E0", Offset = "0x660F1E0", VA = "0x1866103E0")]
			get
			{
				return default(uint);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public Resolution OJAKLPCHMAJ
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x6610200", Offset = "0x660F000", VA = "0x186610200")]
			get
			{
				return default(Resolution);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x1167BE0", Offset = "0x11669E0", VA = "0x181167BE0")]
		public KGDLACPEJNE(Resolution MKPDIKHHNMC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x6610060", Offset = "0x660EE60", VA = "0x186610060")]
		private static Resolution AGKIODMLMFL(Resolution CGOKAFPCMGM, FKAAEFPMKLL BNAJOMECLJN)
		{
			return default(Resolution);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public static class PKGEBEJDFCH
	{
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public static readonly Resolution AAPBFMBCIJG;

		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public static readonly Resolution PHCJNKKMBII;

		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public static readonly Resolution OJEDPCJAAOG;

		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public static readonly Resolution CLKLLKBDJIL;

		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public static readonly Resolution FJKGENIJFMM;

		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public static readonly Resolution OMGEGEAJHPH;

		[Cpp2IlInjected.Token(Token = "0x4000014")]
		internal static readonly Resolution[] BHNBMCONFJB;
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public static class PLPDCPCNGNH
	{
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public static readonly Resolution ODPFIIHIMPD;

		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public static readonly Resolution NDHADENOADP;

		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public static readonly Resolution IFJGMOEIEKF;

		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public static readonly Resolution OKIPFHLIODE;

		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public static readonly Resolution EMECHALJGKP;

		[Cpp2IlInjected.Token(Token = "0x400001A")]
		internal static readonly Resolution[] BHNBMCONFJB;

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x6612880", Offset = "0x6611680", VA = "0x186612880")]
		public static Resolution NEAFNCOBGEO(uint FLPAOFBCNFM)
		{
			return default(Resolution);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public static readonly Resolution DBJKIOPHKIM;

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x6611450", Offset = "0x6610250", VA = "0x186611450")]
	public static bool BAJHOGKOOCF(uint ELCBJJBPMIM)
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
		public enum JCHGBHBPMNG : byte
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
		private class KPICLBKCDGA : IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			private string EOPECGOILOC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			public Texture2D INLMOPFOEFJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400002C")]
			public JCHGBHBPMNG LHPECOHDOFA;

			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x6610450", Offset = "0x660F250", VA = "0x186610450")]
			public KPICLBKCDGA(string EOPECGOILOC)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x9346F0", Offset = "0x9334F0", VA = "0x1809346F0")]
			public KPICLBKCDGA(string EOPECGOILOC, Texture2D BHABCHLJFHG, JCHGBHBPMNG LFLBAOFKHHB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x6610410", Offset = "0x660F210", VA = "0x186610410", Slot = "4")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000D")]
		[CompilerGenerated]
		private sealed class HHCHDGCKBML
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400002D")]
			public ManagedTexture <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400002E")]
			public JCHGBHBPMNG textureMemory;

			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x6ECCD0", Offset = "0x6EBAD0", VA = "0x1806ECCD0")]
			public HHCHDGCKBML()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x6610000", Offset = "0x660EE00", VA = "0x186610000")]
			internal void <GetManagedTexture>b__0()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000E")]
		[CompilerGenerated]
		private sealed class IIIHMEEGGFD
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400002F")]
			public int quality;

			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x6ECCD0", Offset = "0x6EBAD0", VA = "0x1806ECCD0")]
			public IIIHMEEGGFD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x6610040", Offset = "0x660EE40", VA = "0x186610040")]
			internal byte[] <EncodeToJPG>b__0(Texture2D t2d)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000F")]
		[CompilerGenerated]
		private sealed class GCNENHFAIMB
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000030")]
			public RenderTexture tempRenderTexture;

			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x6ECCD0", Offset = "0x6EBAD0", VA = "0x1806ECCD0")]
			public GCNENHFAIMB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x660FF70", Offset = "0x660ED70", VA = "0x18660FF70")]
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
		private global::ONJEHKCKOLK<Texture2D> _cpuSidePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private KPICLBKCDGA _memTexture;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private global::ONJEHKCKOLK<byte[]> _jpgEncodePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private byte[] _jpgBytes;

		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public const int DEFAULT_JPG_QUALITY = 80;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private global::ONJEHKCKOLK<byte[]> _pngEncodePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private byte[] _pngBytes;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public bool UsePalette
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x792380", Offset = "0x791180", VA = "0x180792380")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public RenderTexture LastRenderTexture
		{
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x6FA130", Offset = "0x6F8F30", VA = "0x1806FA130")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x71C2B0", Offset = "0x71B0B0", VA = "0x18071C2B0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		private KPICLBKCDGA memoryTexture
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x6612560", Offset = "0x6611360", VA = "0x186612560")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x6612510", Offset = "0x6611310", VA = "0x186612510")]
		public ManagedTexture(string EOPECGOILOC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x66124B0", Offset = "0x66112B0", VA = "0x1866124B0")]
		public ManagedTexture(string EOPECGOILOC, bool CMEHAMGAKOO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x6611D10", Offset = "0x6610B10", VA = "0x186611D10")]
		public void FHHCKCAGPEF(RenderTexture EHJGGAEBFFD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x6611C40", Offset = "0x6610A40", VA = "0x186611C40")]
		public global::ONJEHKCKOLK<byte[]> EKBAKBPICOC(bool MFMLMCNPBBI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x6611F40", Offset = "0x6610D40", VA = "0x186611F40")]
		public global::ONJEHKCKOLK<Texture2D> GPOFNMNCLNN(JCHGBHBPMNG LFLBAOFKHHB, bool MLHKAMHABMM = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x6611D40", Offset = "0x6610B40", VA = "0x186611D40")]
		public global::ONJEHKCKOLK<byte[]> GPMCOPKHPKN(bool MLHKAMHABMM = false, int JDLCDLFAHFC = 80)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x6612230", Offset = "0x6611030", VA = "0x186612230")]
		public global::ONJEHKCKOLK<byte[]> IALGONOIDDH(bool MLHKAMHABMM = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x66116B0", Offset = "0x66104B0", VA = "0x1866116B0")]
		private static global::ONJEHKCKOLK<Texture2D> CFBNAKBICJB(string EOPECGOILOC, RenderTexture EHJGGAEBFFD, ref Texture2D FGKPCBGEONN, bool MLHKAMHABMM, JCHGBHBPMNG DKKFFALEKIN = JCHGBHBPMNG.GPU)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x66123F0", Offset = "0x66111F0", VA = "0x1866123F0")]
		public void OFJGFPLMNHP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x6611C30", Offset = "0x6610A30", VA = "0x186611C30", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x6611C60", Offset = "0x6610A60", VA = "0x186611C60")]
		[CompilerGenerated]
		private global::ONJEHKCKOLK<byte[]> FDLCGBMNDEJ(Texture2D MINOKGJHIDP)
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public static class APDEIDKLPFH
{
	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x660FDA0", Offset = "0x660EBA0", VA = "0x18660FDA0")]
	public static RenderTexture JBHDCCNMHOM(int FLPAOFBCNFM, int BDNEGOJDOMD, int ACNLMINHECG, Camera LNALJOCEHJD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x660FD30", Offset = "0x660EB30", VA = "0x18660FD30")]
	public static void JADJBGOAMKD(RenderTexture EHJGGAEBFFD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class LNHLPPFLDDN
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public class LKDCFMAPJJP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public int HJHFBPCCKIM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public int HDNNAAICFFH;

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x10112B0", Offset = "0x10100B0", VA = "0x1810112B0")]
		public LKDCFMAPJJP(int EOOBLLJHFPN, int ABJFFBJEJDK)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	private enum FALNKDHDCNF
	{
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		Point,
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		Bilinear,
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		Average
	}

	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private static Color[] GOGECAPFLGO;

	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private static Color[] DAGFKMIALEH;

	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private static int NBNGFNKGOEK;

	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private static float ENLLKEAOBNK;

	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private static float CFIDKEBCAIC;

	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private static int ONJKJEHNHOF;

	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private static int AKIKPMPKGAO;

	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private static Mutex GHAJLDBLBIG;

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x6611260", Offset = "0x6610060", VA = "0x186611260")]
	public static void NDKMBEKHBBI(Texture2D CHEOMANCBKL, int PFFKGCMFIGL, int PEJNAJEELCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x6610BA0", Offset = "0x660F9A0", VA = "0x186610BA0")]
	private static void HILAAJKLLMO(Texture2D CHEOMANCBKL, int PFFKGCMFIGL, int PEJNAJEELCJ, FALNKDHDCNF LDHPLLNPIDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x6610580", Offset = "0x660F380", VA = "0x186610580")]
	public static void FMGADCBIFJH(object BLIKPCIFNNO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x6611090", Offset = "0x660FE90", VA = "0x186611090")]
	public static void MNCBJDLHBNC(object BLIKPCIFNNO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x6610A00", Offset = "0x660F800", VA = "0x186610A00")]
	private static Color GJLLCDPMAIM(int PAMKNJCGOGK, int IOAMOMOPNDK, float ENLLKEAOBNK, float CFIDKEBCAIC)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x6611280", Offset = "0x6610080", VA = "0x186611280")]
	public static void PFBJBNLOJLJ(object BLIKPCIFNNO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x66104A0", Offset = "0x660F2A0", VA = "0x1866104A0")]
	private static Color BFJNBLBBHGK(Color LDKAJLPHENP, Color IIKHNLNCKBC, float NLHFEJHKLAH)
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
