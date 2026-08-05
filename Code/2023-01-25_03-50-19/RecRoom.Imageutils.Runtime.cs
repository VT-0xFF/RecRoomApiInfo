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
		[Cpp2IlInjected.Address(RVA = "0x60E9390", Offset = "0x60E8390", VA = "0x1860E9390")]
		public CubeMapGenerator()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public enum NLCNLKFEOOG
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
public interface EGDMKJPJKCB
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	NLCNLKFEOOG FOFHAOEOFAA
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class LLKBCGEPIAD
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
			[Cpp2IlInjected.Address(RVA = "0x60EBF60", Offset = "0x60EAF60", VA = "0x1860EBF60")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x60EBF50", Offset = "0x60EAF50", VA = "0x1860EBF50")]
		public Resolution(uint JMDPDGBMGAA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x69F050", Offset = "0x69E050", VA = "0x18069F050")]
		public Resolution(uint JMDPDGBMGAA, uint GKDCJKNJEID)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x60EBE60", Offset = "0x60EAE60", VA = "0x1860EBE60")]
		public static Resolution OPNNDEJFDHG(Resolution[] MNDBAHHKLIP, Resolution LFMDBCHLJJO, int KGOADEIOIHD)
		{
			return default(Resolution);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public class CHIHFMEFPPI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private readonly Resolution OBAAGODHNMD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private Resolution? AGNOGFNMOGA;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public uint JMDPDGBMGAA
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x60E9380", Offset = "0x60E8380", VA = "0x1860E9380")]
			get
			{
				return default(uint);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public uint GKDCJKNJEID
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x60E8FE0", Offset = "0x60E7FE0", VA = "0x1860E8FE0")]
			get
			{
				return default(uint);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public Resolution GINCCKFNGNB
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x60E9000", Offset = "0x60E8000", VA = "0x1860E9000")]
			get
			{
				return default(Resolution);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0xF4A0D0", Offset = "0xF490D0", VA = "0x180F4A0D0")]
		public CHIHFMEFPPI(Resolution OBAAGODHNMD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x60E91E0", Offset = "0x60E81E0", VA = "0x1860E91E0")]
		private static Resolution NFNPFPLGDOB(Resolution AGNOGFNMOGA, NLCNLKFEOOG CENANCLGCNH)
		{
			return default(Resolution);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public static class ILAOHIJOJDC
	{
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public static readonly Resolution OJPENDNEMPK;

		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public static readonly Resolution MEBCOJAMIAD;

		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public static readonly Resolution NCJCKDJPGHK;

		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public static readonly Resolution LPNAHGJBNPK;

		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public static readonly Resolution MLEIEMFBNGG;

		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public static readonly Resolution BHDJELPLHJF;

		[Cpp2IlInjected.Token(Token = "0x4000014")]
		internal static readonly Resolution[] GKCDMDDFKED;
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public static class JMJOCIHGJFM
	{
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public static readonly Resolution MAGEFJMGHNA;

		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public static readonly Resolution JKPLOOEMKGD;

		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public static readonly Resolution ALCEIMJNOGF;

		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public static readonly Resolution BHGCNAAOGHL;

		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public static readonly Resolution OHADBEGGLJB;

		[Cpp2IlInjected.Token(Token = "0x400001A")]
		internal static readonly Resolution[] GKCDMDDFKED;

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x60EA620", Offset = "0x60E9620", VA = "0x1860EA620")]
		public static Resolution DEGCNGHNBCF(uint LBHCEBCJMEF)
		{
			return default(Resolution);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public static readonly Resolution AOEGMLFFKID;

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x60EAA00", Offset = "0x60E9A00", VA = "0x1860EAA00")]
	public static bool IONPDABAICI(uint PBPCGBJAOBA)
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
		public enum LMJDDDCLJEK : byte
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
		private class BFGFHMPCKKE : IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			private string IADPDEAGFAB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			public Texture2D EDIIDDNIPHM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400002C")]
			public LMJDDDCLJEK GNJKOPNLOJB;

			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x60E8F90", Offset = "0x60E7F90", VA = "0x1860E8F90")]
			public BFGFHMPCKKE(string IADPDEAGFAB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x684750", Offset = "0x683750", VA = "0x180684750")]
			public BFGFHMPCKKE(string IADPDEAGFAB, Texture2D OLCMNMBHAKL, LMJDDDCLJEK CIAEPFDAACA)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x60E8F50", Offset = "0x60E7F50", VA = "0x1860E8F50", Slot = "4")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000D")]
		[CompilerGenerated]
		private sealed class DAFMPEKEOOE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400002D")]
			public ManagedTexture <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400002E")]
			public LMJDDDCLJEK textureMemory;

			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x67FB30", Offset = "0x67EB30", VA = "0x18067FB30")]
			public DAFMPEKEOOE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x60E93B0", Offset = "0x60E83B0", VA = "0x1860E93B0")]
			internal void <GetManagedTexture>b__0()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000E")]
		[CompilerGenerated]
		private sealed class KNMNJJFHIGK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400002F")]
			public int quality;

			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x67FB30", Offset = "0x67EB30", VA = "0x18067FB30")]
			public KNMNJJFHIGK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x60EA9E0", Offset = "0x60E99E0", VA = "0x1860EA9E0")]
			internal byte[] <EncodeToJPG>b__0(Texture2D t2d)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000F")]
		[CompilerGenerated]
		private sealed class OAKEPADCINE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000030")]
			public RenderTexture tempRenderTexture;

			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x67FB30", Offset = "0x67EB30", VA = "0x18067FB30")]
			public OAKEPADCINE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x60EBDD0", Offset = "0x60EADD0", VA = "0x1860EBDD0")]
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
		private global::MMBCCHGMCHN<Texture2D> _cpuSidePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private BFGFHMPCKKE _memTexture;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private global::MMBCCHGMCHN<byte[]> _jpgEncodePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private byte[] _jpgBytes;

		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public const int DEFAULT_JPG_QUALITY = 80;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private global::MMBCCHGMCHN<byte[]> _pngEncodePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private byte[] _pngBytes;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public bool UsePalette
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x682250", Offset = "0x681250", VA = "0x180682250")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public RenderTexture LastRenderTexture
		{
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x67F120", Offset = "0x67E120", VA = "0x18067F120")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x67F130", Offset = "0x67E130", VA = "0x18067F130")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		private BFGFHMPCKKE memoryTexture
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x60EBD30", Offset = "0x60EAD30", VA = "0x1860EBD30")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x60EBCE0", Offset = "0x60EACE0", VA = "0x1860EBCE0")]
		public ManagedTexture(string IADPDEAGFAB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x60EBC80", Offset = "0x60EAC80", VA = "0x1860EBC80")]
		public ManagedTexture(string IADPDEAGFAB, bool AAFEENHOFFC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x60EBC50", Offset = "0x60EAC50", VA = "0x1860EBC50")]
		public void PKFLEJFKNEG(RenderTexture PDDLJOCHIHI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x60EB600", Offset = "0x60EA600", VA = "0x1860EB600")]
		public global::MMBCCHGMCHN<byte[]> HCCNKNBFAHE(bool KOFNMHDHMNL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x60EB310", Offset = "0x60EA310", VA = "0x1860EB310")]
		public global::MMBCCHGMCHN<Texture2D> GMAJGBJAKIA(LMJDDDCLJEK CIAEPFDAACA, bool BAOAFNGGCEI = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x60EB040", Offset = "0x60EA040", VA = "0x1860EB040")]
		public global::MMBCCHGMCHN<byte[]> BGPPPEDJNIO(bool BAOAFNGGCEI = false, int CFJLCDHCMKP = 80)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x60EAE80", Offset = "0x60E9E80", VA = "0x1860EAE80")]
		public global::MMBCCHGMCHN<byte[]> BGGOODJECIC(bool BAOAFNGGCEI = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x60EB620", Offset = "0x60EA620", VA = "0x1860EB620")]
		private static global::MMBCCHGMCHN<Texture2D> MKBEGGFKADK(string IADPDEAGFAB, RenderTexture PDDLJOCHIHI, ref Texture2D IPPGECHFHCC, bool BAOAFNGGCEI, LMJDDDCLJEK OKDFMDEEOLF = LMJDDDCLJEK.GPU)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x60EB240", Offset = "0x60EA240", VA = "0x1860EB240")]
		public void CCEOAPHEEGK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x60EB300", Offset = "0x60EA300", VA = "0x1860EB300", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x60EBBA0", Offset = "0x60EABA0", VA = "0x1860EBBA0")]
		[CompilerGenerated]
		private global::MMBCCHGMCHN<byte[]> PBHMAGGJOJJ(Texture2D KICPNKIBMKM)
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public static class LNHLEBNDCKI
{
	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x60EACD0", Offset = "0x60E9CD0", VA = "0x1860EACD0")]
	public static RenderTexture LPDGBFANIMB(int LBHCEBCJMEF, int MMPBKAKMEAK, int HFAPDGCFEDI, Camera ABJENFFCFAK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x60EAC60", Offset = "0x60E9C60", VA = "0x1860EAC60")]
	public static void CNMOKJNLHHN(RenderTexture PDDLJOCHIHI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class FOPADHKGAEJ
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public class JIDMOBJCBPL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public int FHGIIAKFJFF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public int APIEJLBIMAO;

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x84E570", Offset = "0x84D570", VA = "0x18084E570")]
		public JIDMOBJCBPL(int EEDIAOMNBHI, int PBDFKDHMIEL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	private enum MHHNGLNJGDF
	{
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		Point,
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		Bilinear,
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		Average
	}

	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private static Color[] BPKHEKNKPIO;

	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private static Color[] IPGLHCGAJCO;

	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private static int AOJLCLDDLKO;

	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private static float JLKIHLCIHAM;

	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private static float IPNJBEDFLDC;

	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private static int HENPBFDJJKM;

	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private static int KJNFKDBIHEJ;

	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private static Mutex AHOIFIABEOB;

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x60E9AB0", Offset = "0x60E8AB0", VA = "0x1860E9AB0")]
	public static void HLCBPJIIDOM(Texture2D ICPJDAKDCGL, int MFILOFILNJM, int JKNKDJOHNPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x60E93F0", Offset = "0x60E83F0", VA = "0x1860E93F0")]
	private static void DFIFKBLIKLA(Texture2D ICPJDAKDCGL, int MFILOFILNJM, int JKNKDJOHNPD, MHHNGLNJGDF JONBJLGFOKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x60E9F20", Offset = "0x60E8F20", VA = "0x1860E9F20")]
	public static void NMMGGJIHNEM(object GKCPJCKCENH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x60E98E0", Offset = "0x60E88E0", VA = "0x1860E98E0")]
	public static void FNAFPCFMBKD(object GKCPJCKCENH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x60E9BB0", Offset = "0x60E8BB0", VA = "0x1860E9BB0")]
	private static Color JFFKEAMDCNC(int JMDPDGBMGAA, int GKDCJKNJEID, float JLKIHLCIHAM, float IPNJBEDFLDC)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x60E9D50", Offset = "0x60E8D50", VA = "0x1860E9D50")]
	public static void JGGHEJEEOLI(object GKCPJCKCENH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x60E9AD0", Offset = "0x60E8AD0", VA = "0x1860E9AD0")]
	private static Color IPHNBBGKBJN(Color MANOHMIKACK, Color PMAFACBMBNM, float DFEOJBAFBHE)
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
