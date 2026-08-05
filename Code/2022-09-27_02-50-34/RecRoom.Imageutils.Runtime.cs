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
		[Cpp2IlInjected.Address(RVA = "0x2857870", Offset = "0x2856A70", VA = "0x182857870")]
		public CubeMapGenerator()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public enum BJNGBAPCFNA
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
public interface JKCBGLKDDMP
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	BJNGBAPCFNA IHAMJHJAKEF
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class KFEIHHFIICF
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
			[Cpp2IlInjected.Address(RVA = "0x2859FF0", Offset = "0x28591F0", VA = "0x182859FF0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x2859FE0", Offset = "0x28591E0", VA = "0x182859FE0")]
		public Resolution(uint FMHEJMEECNK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x884C10", Offset = "0x883E10", VA = "0x180884C10")]
		public Resolution(uint FMHEJMEECNK, uint EDNBLCPIBHC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x2859E90", Offset = "0x2859090", VA = "0x182859E90")]
		public static Resolution JOIDEGKEDJL(Resolution[] CKKKILJPPHH, Resolution MBGACFHFFLN, int PMNFKCDEGKE)
		{
			return default(Resolution);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public class CJCHBONPJLM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private readonly Resolution ICFMIMHELEN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private Resolution? JELNBPJDKOB;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public uint FMHEJMEECNK
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x2857330", Offset = "0x2856530", VA = "0x182857330")]
			get
			{
				return default(uint);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public uint EDNBLCPIBHC
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x2857140", Offset = "0x2856340", VA = "0x182857140")]
			get
			{
				return default(uint);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public Resolution KJAOGDJDMLN
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x2857340", Offset = "0x2856540", VA = "0x182857340")]
			get
			{
				return default(Resolution);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0xF8AD60", Offset = "0xF89F60", VA = "0x180F8AD60")]
		public CJCHBONPJLM(Resolution ICFMIMHELEN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x2857160", Offset = "0x2856360", VA = "0x182857160")]
		private static Resolution EKKOMJIMPNJ(Resolution JELNBPJDKOB, BJNGBAPCFNA MFJJLDGNBCA)
		{
			return default(Resolution);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public static class MALPDPAOBHA
	{
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public static readonly Resolution HMCMLJBEGEK;

		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public static readonly Resolution AIOLHGGAHEM;

		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public static readonly Resolution GHMHIGMLFPM;

		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public static readonly Resolution FKFHMNHDGHJ;

		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public static readonly Resolution FFEBDDDAJEF;

		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public static readonly Resolution NFCLKIENJGP;

		[Cpp2IlInjected.Token(Token = "0x4000014")]
		internal static readonly Resolution[] AKBGLMCCDMI;
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public static class CONLENKJNMM
	{
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public static readonly Resolution CJIKBICGOLL;

		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public static readonly Resolution EKPPPBBMNJK;

		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public static readonly Resolution HMMEPJELGBJ;

		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public static readonly Resolution NNKFPBNHEPN;

		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public static readonly Resolution BKOKLPLHJEB;

		[Cpp2IlInjected.Token(Token = "0x400001A")]
		internal static readonly Resolution[] AKBGLMCCDMI;

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x28574D0", Offset = "0x28566D0", VA = "0x1828574D0")]
		public static Resolution GJIPPABMEHP(uint FNNLNDILPIG)
		{
			return default(Resolution);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public static readonly Resolution BPDMMIKHGOA;

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x28579D0", Offset = "0x2856BD0", VA = "0x1828579D0")]
	public static bool DPCDOIADCHO(uint LKCMBEGLIBC)
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
		public enum JGGANEEIHFN : byte
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
		private class EPKCCCPBGAG : IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			private string JFLKGPEABBP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			public Texture2D CHJGHAHFEIA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400002C")]
			public JGGANEEIHFN HODCLCJKOFH;

			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x28578F0", Offset = "0x2856AF0", VA = "0x1828578F0")]
			public EPKCCCPBGAG(string JFLKGPEABBP)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x10A8B70", Offset = "0x10A7D70", VA = "0x1810A8B70")]
			public EPKCCCPBGAG(string JFLKGPEABBP, Texture2D HAPCLODCOFO, JGGANEEIHFN NJAPIHEGCBP)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x28578B0", Offset = "0x2856AB0", VA = "0x1828578B0", Slot = "4")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000D")]
		[CompilerGenerated]
		private sealed class CHOIPONBIHE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400002D")]
			public ManagedTexture <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400002E")]
			public JGGANEEIHFN textureMemory;

			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x5FADF0", Offset = "0x5F9FF0", VA = "0x1805FADF0")]
			public CHOIPONBIHE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x2857100", Offset = "0x2856300", VA = "0x182857100")]
			internal void <GetManagedTexture>b__0()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000E")]
		[CompilerGenerated]
		private sealed class DFHGGFECJNP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400002F")]
			public int quality;

			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x5FADF0", Offset = "0x5F9FF0", VA = "0x1805FADF0")]
			public DFHGGFECJNP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x2857890", Offset = "0x2856A90", VA = "0x182857890")]
			internal byte[] <EncodeToJPG>b__0(Texture2D t2d)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000F")]
		[CompilerGenerated]
		private sealed class ILPINDBIJJF
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000030")]
			public RenderTexture tempRenderTexture;

			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x5FADF0", Offset = "0x5F9FF0", VA = "0x1805FADF0")]
			public ILPINDBIJJF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x2857940", Offset = "0x2856B40", VA = "0x182857940")]
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
		private global::GDKGOJJDLGI<Texture2D> _cpuSidePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private EPKCCCPBGAG _memTexture;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private global::GDKGOJJDLGI<byte[]> _jpgEncodePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private byte[] _jpgBytes;

		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public const int DEFAULT_JPG_QUALITY = 80;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private global::GDKGOJJDLGI<byte[]> _pngEncodePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private byte[] _pngBytes;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public bool UsePalette
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x7CC130", Offset = "0x7CB330", VA = "0x1807CC130")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public RenderTexture LastRenderTexture
		{
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x5FDD10", Offset = "0x5FCF10", VA = "0x1805FDD10")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x5FDD20", Offset = "0x5FCF20", VA = "0x1805FDD20")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		private EPKCCCPBGAG memoryTexture
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x2858D90", Offset = "0x2857F90", VA = "0x182858D90")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x2858CE0", Offset = "0x2857EE0", VA = "0x182858CE0")]
		public ManagedTexture(string JFLKGPEABBP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x2858D30", Offset = "0x2857F30", VA = "0x182858D30")]
		public ManagedTexture(string JFLKGPEABBP, bool LDKOFAAFLMA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x2858960", Offset = "0x2857B60", VA = "0x182858960")]
		public void HMBBODMPHMP(RenderTexture MLHNOPCEHHD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x2858210", Offset = "0x2857410", VA = "0x182858210")]
		public global::GDKGOJJDLGI<byte[]> BIJPBMKMBDP(bool BJDMODDCIGI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x2858A50", Offset = "0x2857C50", VA = "0x182858A50")]
		public global::GDKGOJJDLGI<Texture2D> NIFIFAGKFKD(JGGANEEIHFN NJAPIHEGCBP, bool ADHBEOMCMPH = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x2858060", Offset = "0x2857260", VA = "0x182858060")]
		public global::GDKGOJJDLGI<byte[]> AGPAALMPKIJ(bool ADHBEOMCMPH = false, int OEFPPLLNPFD = 80)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x28582D0", Offset = "0x28574D0", VA = "0x1828582D0")]
		public global::GDKGOJJDLGI<byte[]> DKDPHCAMOKE(bool ADHBEOMCMPH = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x2858470", Offset = "0x2857670", VA = "0x182858470")]
		private static global::GDKGOJJDLGI<Texture2D> GJPALAAFFAG(string JFLKGPEABBP, RenderTexture MLHNOPCEHHD, ref Texture2D NBANFEDGAPL, bool ADHBEOMCMPH, JGGANEEIHFN BLEGFJPEFIF = JGGANEEIHFN.GPU)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x2858990", Offset = "0x2857B90", VA = "0x182858990")]
		public void JPCNKKFCEBC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x2858460", Offset = "0x2857660", VA = "0x182858460", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x2858230", Offset = "0x2857430", VA = "0x182858230")]
		[CompilerGenerated]
		private global::GDKGOJJDLGI<byte[]> DFFDAOIHFEN(Texture2D PBCLGPMBAPA)
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public static class MLPBBKGOMEL
{
	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x2857EF0", Offset = "0x28570F0", VA = "0x182857EF0")]
	public static RenderTexture JJHJOOCDPJO(int FNNLNDILPIG, int AKPHHICECEJ, int IDPOICMGJOK, Camera DEOIHKOIFOG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x2857E80", Offset = "0x2857080", VA = "0x182857E80")]
	public static void CHMECKGONMA(RenderTexture MLHNOPCEHHD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class NJKLHFMMPHL
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public class EEAEAGFEMAH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public int FLFAMDBICFJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public int FOKHGDFDAEJ;

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0xA03070", Offset = "0xA02270", VA = "0x180A03070")]
		public EEAEAGFEMAH(int NLJODIPCHDM, int MAMHFFLAIIN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	private enum DGCBAJGMBJN
	{
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		Point,
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		Bilinear,
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		Average
	}

	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private static Color[] GHIIJEJLNPA;

	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private static Color[] BGHPBAHGBEJ;

	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private static int OBCBDNBHHOM;

	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private static float NLNJDDJDLMK;

	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private static float PFPADNHLAFO;

	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private static int EKKOIIHPIPB;

	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private static int FGJBLGFMCBJ;

	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private static Mutex MJMCANEGOMJ;

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x28591F0", Offset = "0x28583F0", VA = "0x1828591F0")]
	public static void JKFMDDEMIHI(Texture2D GMILAFPHFHI, int AFFOHOFOKKG, int FCADPJIAAHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x28599E0", Offset = "0x2858BE0", VA = "0x1828599E0")]
	private static void PMMBMCIIPJE(Texture2D GMILAFPHFHI, int AFFOHOFOKKG, int FCADPJIAAHN, DGCBAJGMBJN OJCKDJPHKIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x28593D0", Offset = "0x28585D0", VA = "0x1828593D0")]
	public static void MLAAFKDJIBF(object PBKPNJLDBOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x2858E30", Offset = "0x2858030", VA = "0x182858E30")]
	public static void BDJIAPGLDIK(object PBKPNJLDBOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x2859210", Offset = "0x2858410", VA = "0x182859210")]
	private static Color KFHMBGIAMOB(int FMHEJMEECNK, int EDNBLCPIBHC, float NLNJDDJDLMK, float PFPADNHLAFO)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x2859010", Offset = "0x2858210", VA = "0x182859010")]
	public static void CFNPKGIHFHK(object PBKPNJLDBOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x28598F0", Offset = "0x2858AF0", VA = "0x1828598F0")]
	private static Color OGABBIGPALC(Color EEKKNFEKIDH, Color IKFNBMEGJDC, float ADBNEBBHMOP)
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
