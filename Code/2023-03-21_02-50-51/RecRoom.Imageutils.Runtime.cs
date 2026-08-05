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
		[Cpp2IlInjected.Address(RVA = "0x65B5A70", Offset = "0x65B4270", VA = "0x1865B5A70")]
		public CubeMapGenerator()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public enum BOJGDEHJPGM
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
public interface ICKAAGNPCJL
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	BOJGDEHJPGM BINFMDBFPGP
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class IHBPPHIDGCA
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
			[Cpp2IlInjected.Address(RVA = "0x65B77C0", Offset = "0x65B5FC0", VA = "0x1865B77C0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x65B77B0", Offset = "0x65B5FB0", VA = "0x1865B77B0")]
		public Resolution(uint NGMFABJMIHP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x6F6050", Offset = "0x6F4850", VA = "0x1806F6050")]
		public Resolution(uint NGMFABJMIHP, uint OMDBFFDAOFA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x65B76C0", Offset = "0x65B5EC0", VA = "0x1865B76C0")]
		public static Resolution HCBMBJCIDHI(Resolution[] LBOENCNHHLB, Resolution EPOGHFGIKMG, int MCNHECJCMCH)
		{
			return default(Resolution);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public class DODHMKELAPM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private readonly Resolution MFNFJCNGEPG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private Resolution? GONHOIMEDCD;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public uint NGMFABJMIHP
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x65B5A90", Offset = "0x65B4290", VA = "0x1865B5A90")]
			get
			{
				return default(uint);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public uint OMDBFFDAOFA
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x65B5E20", Offset = "0x65B4620", VA = "0x1865B5E20")]
			get
			{
				return default(uint);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public Resolution GLHJOJMJHAM
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x65B5C40", Offset = "0x65B4440", VA = "0x1865B5C40")]
			get
			{
				return default(Resolution);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x1174610", Offset = "0x1172E10", VA = "0x181174610")]
		public DODHMKELAPM(Resolution MFNFJCNGEPG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x65B5AA0", Offset = "0x65B42A0", VA = "0x1865B5AA0")]
		private static Resolution ACHMJJBINBF(Resolution GONHOIMEDCD, BOJGDEHJPGM GNDIPKFACDF)
		{
			return default(Resolution);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public static class BDCNFCBGCCM
	{
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public static readonly Resolution IPLDMBLPDKC;

		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public static readonly Resolution PKCBAPPKDMA;

		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public static readonly Resolution KDHKBKCGJDE;

		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public static readonly Resolution NLFDHPHNJLF;

		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public static readonly Resolution PJKIKCCEJCN;

		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public static readonly Resolution MBMCHOOAGAI;

		[Cpp2IlInjected.Token(Token = "0x4000014")]
		internal static readonly Resolution[] OCJKFLIIFEC;
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public static class FKEMCHDLCHB
	{
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public static readonly Resolution GBGFIIGPFAF;

		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public static readonly Resolution MDJMMGPGIMG;

		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public static readonly Resolution FBJCCNJNGLF;

		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public static readonly Resolution JCKJBMAFHHB;

		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public static readonly Resolution JOKHCDJOGCL;

		[Cpp2IlInjected.Token(Token = "0x400001A")]
		internal static readonly Resolution[] OCJKFLIIFEC;

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x65B6060", Offset = "0x65B4860", VA = "0x1865B6060")]
		public static Resolution CABLNHADOLA(uint HOAILLMFABM)
		{
			return default(Resolution);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public static readonly Resolution CGJIPGDILFE;

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x65B6420", Offset = "0x65B4C20", VA = "0x1865B6420")]
	public static bool PHDIAFMDCLH(uint EPMPDFCFIAB)
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
		public enum OFDBOLDACJC : byte
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
		private class KLHGGKFAJAO : IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			private string LOIAMCEJAFO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			public Texture2D FDHNJOLMCBC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400002C")]
			public OFDBOLDACJC KOKDJPDJNLB;

			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x65B66C0", Offset = "0x65B4EC0", VA = "0x1865B66C0")]
			public KLHGGKFAJAO(string LOIAMCEJAFO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x6DB750", Offset = "0x6D9F50", VA = "0x1806DB750")]
			public KLHGGKFAJAO(string LOIAMCEJAFO, Texture2D KDIGAMMGOAF, OFDBOLDACJC BHNAJKICOGF)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x65B6680", Offset = "0x65B4E80", VA = "0x1865B6680", Slot = "4")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000D")]
		[CompilerGenerated]
		private sealed class KLPINDFJHIO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400002D")]
			public ManagedTexture <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400002E")]
			public OFDBOLDACJC textureMemory;

			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x6D6B30", Offset = "0x6D5330", VA = "0x1806D6B30")]
			public KLPINDFJHIO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x65B6710", Offset = "0x65B4F10", VA = "0x1865B6710")]
			internal void <GetManagedTexture>b__0()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000E")]
		[CompilerGenerated]
		private sealed class MHEAIIPPGPM
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400002F")]
			public int quality;

			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x6D6B30", Offset = "0x6D5330", VA = "0x1806D6B30")]
			public MHEAIIPPGPM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x65B6750", Offset = "0x65B4F50", VA = "0x1865B6750")]
			internal byte[] <EncodeToJPG>b__0(Texture2D t2d)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000F")]
		[CompilerGenerated]
		private sealed class AABLKIJHKKH
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000030")]
			public RenderTexture tempRenderTexture;

			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x6D6B30", Offset = "0x6D5330", VA = "0x1806D6B30")]
			public AABLKIJHKKH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x65B47B0", Offset = "0x65B2FB0", VA = "0x1865B47B0")]
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
		private global::FGLDKEJLAKB<Texture2D> _cpuSidePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private KLHGGKFAJAO _memTexture;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private global::FGLDKEJLAKB<byte[]> _jpgEncodePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private byte[] _jpgBytes;

		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public const int DEFAULT_JPG_QUALITY = 80;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private global::FGLDKEJLAKB<byte[]> _pngEncodePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private byte[] _pngBytes;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public bool UsePalette
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x6D9250", Offset = "0x6D7A50", VA = "0x1806D9250")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public RenderTexture LastRenderTexture
		{
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x6D6120", Offset = "0x6D4920", VA = "0x1806D6120")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x6D6130", Offset = "0x6D4930", VA = "0x1806D6130")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		private KLHGGKFAJAO memoryTexture
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x65B7620", Offset = "0x65B5E20", VA = "0x1865B7620")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x65B75D0", Offset = "0x65B5DD0", VA = "0x1865B75D0")]
		public ManagedTexture(string LOIAMCEJAFO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x65B7570", Offset = "0x65B5D70", VA = "0x1865B7570")]
		public ManagedTexture(string LOIAMCEJAFO, bool OJEEMFJEJCI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x65B6990", Offset = "0x65B5190", VA = "0x1865B6990")]
		public void BJEHMFPGFJB(RenderTexture KFPIPKEMGLA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x65B6970", Offset = "0x65B5170", VA = "0x1865B6970")]
		public global::FGLDKEJLAKB<byte[]> ALIMEHCKAGF(bool CJJBHAMPAMP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x65B6C50", Offset = "0x65B5450", VA = "0x1865B6C50")]
		public global::FGLDKEJLAKB<Texture2D> GANBOCGCHKJ(OFDBOLDACJC BHNAJKICOGF, bool EMGBPJJJMLL = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x65B6770", Offset = "0x65B4F70", VA = "0x1865B6770")]
		public global::FGLDKEJLAKB<byte[]> AIHFODEGIMB(bool EMGBPJJJMLL = false, int KKBNIDLOJBJ = 80)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x65B69C0", Offset = "0x65B51C0", VA = "0x1865B69C0")]
		public global::FGLDKEJLAKB<byte[]> DCIMLNBLGOI(bool EMGBPJJJMLL = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x65B6FF0", Offset = "0x65B57F0", VA = "0x1865B6FF0")]
		private static global::FGLDKEJLAKB<Texture2D> NDAMHEMENLB(string LOIAMCEJAFO, RenderTexture KFPIPKEMGLA, ref Texture2D ODAAADFNDIP, bool EMGBPJJJMLL, OFDBOLDACJC BFIALCNBMFC = OFDBOLDACJC.GPU)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x65B6B80", Offset = "0x65B5380", VA = "0x1865B6B80")]
		public void DNFFCAFBKEE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x65B6C40", Offset = "0x65B5440", VA = "0x1865B6C40", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x65B6F40", Offset = "0x65B5740", VA = "0x1865B6F40")]
		[CompilerGenerated]
		private global::FGLDKEJLAKB<byte[]> MDOGJEMNDDJ(Texture2D MODLABGNADB)
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public static class FJLBACOPACB
{
	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x65B5E40", Offset = "0x65B4640", VA = "0x1865B5E40")]
	public static RenderTexture GDIIAIIJFII(int HOAILLMFABM, int APOJLADNFJD, int LJGHFLLENHO, Camera MOOPBONJIIA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x65B5FF0", Offset = "0x65B47F0", VA = "0x1865B5FF0")]
	public static void GHECAFLAGMO(RenderTexture KFPIPKEMGLA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class BDNNONFIAEJ
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public class HEACKOIGINE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public int DAOIPFCHFFJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public int FBIOFODCNKG;

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x8A88E0", Offset = "0x8A70E0", VA = "0x1808A88E0")]
		public HEACKOIGINE(int GLKCNJGCDME, int ODBOKKABIBK)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	private enum CNLHBJPLDMN
	{
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		Point,
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		Bilinear,
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		Average
	}

	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private static Color[] IPKPJAALCLL;

	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private static Color[] JELBJHIDNDL;

	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private static int CBDPMHLACML;

	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private static float IHLOKKFHFJF;

	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private static float PCIPAGHOFFL;

	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private static int LHEHJCAJPFM;

	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private static int HMLFAECEICC;

	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private static Mutex ACEIGKJAOHD;

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x65B5880", Offset = "0x65B4080", VA = "0x1865B5880")]
	public static void KDIOPNEAMHO(Texture2D DENKOFNHCLK, int EGDGPILNMKA, int DGFBCOFMLMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x65B5110", Offset = "0x65B3910", VA = "0x1865B5110")]
	private static void GMIAFDCCLHB(Texture2D DENKOFNHCLK, int EGDGPILNMKA, int DGFBCOFMLMM, CNLHBJPLDMN BDEPELOIHDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x65B4AC0", Offset = "0x65B32C0", VA = "0x1865B4AC0")]
	public static void AEHHPHGNLFM(object BFHAMCLNCKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x65B4F40", Offset = "0x65B3740", VA = "0x1865B4F40")]
	public static void FHJPCDLOLHH(object BFHAMCLNCKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x65B56E0", Offset = "0x65B3EE0", VA = "0x1865B56E0")]
	private static Color IELBLAJIOOC(int NGMFABJMIHP, int OMDBFFDAOFA, float IHLOKKFHFJF, float PCIPAGHOFFL)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x65B58A0", Offset = "0x65B40A0", VA = "0x1865B58A0")]
	public static void KDJDNPCGKLM(object BFHAMCLNCKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x65B5600", Offset = "0x65B3E00", VA = "0x1865B5600")]
	private static Color GOHCDAEGLKM(Color MAPINKODENG, Color KGDMJMFENPE, float NPHADDCNBHE)
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
