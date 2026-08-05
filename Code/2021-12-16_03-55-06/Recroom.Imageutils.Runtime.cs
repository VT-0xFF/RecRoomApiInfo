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
		[Cpp2IlInjected.Address(RVA = "0x43CAE70", Offset = "0x43CA270", VA = "0x1843CAE70")]
		public CubeMapGenerator()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public enum INFPLMEGKOA
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
public interface DBNDBLOFGBH
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	INFPLMEGKOA LILHIFMBIMK
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class DGMLJCNGDPF
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
			[Cpp2IlInjected.Address(RVA = "0x43CCB50", Offset = "0x43CBF50", VA = "0x1843CCB50")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x43CCB40", Offset = "0x43CBF40", VA = "0x1843CCB40")]
		public Resolution(uint FDNDJJDHFEF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x5FDA40", Offset = "0x5FCE40", VA = "0x1805FDA40")]
		public Resolution(uint FDNDJJDHFEF, uint KILEPAPFHJE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x43CC9F0", Offset = "0x43CBDF0", VA = "0x1843CC9F0")]
		public static Resolution DHGEEIAINAP(Resolution[] EJNNJOGKADK, Resolution KDMDAGICPFH, int EOIBAOGCDMJ)
		{
			return default(Resolution);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public class MJENHPGKFFG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private readonly Resolution FJPLCMLLFEI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private Resolution? AIGAPMKHAHP;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public uint FDNDJJDHFEF
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x43CB8B0", Offset = "0x43CACB0", VA = "0x1843CB8B0")]
			get
			{
				return default(uint);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public uint KILEPAPFHJE
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x43CBAC0", Offset = "0x43CAEC0", VA = "0x1843CBAC0")]
			get
			{
				return default(uint);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public Resolution FJFJHGKKPOE
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x43CB8C0", Offset = "0x43CACC0", VA = "0x1843CB8C0")]
			get
			{
				return default(Resolution);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x1B88C30", Offset = "0x1B88030", VA = "0x181B88C30")]
		public MJENHPGKFFG(Resolution FJPLCMLLFEI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x43CB6E0", Offset = "0x43CAAE0", VA = "0x1843CB6E0")]
		private static Resolution ABCBEBOMMEN(Resolution AIGAPMKHAHP, INFPLMEGKOA MBAGINHMKKG)
		{
			return default(Resolution);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public static class AMKHAFGNIMI
	{
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public static readonly Resolution HHMFFMJCDEF;

		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public static readonly Resolution BOOMGICIFPB;

		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public static readonly Resolution KMNAILIMOJL;

		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public static readonly Resolution LBNHEFCIMLC;

		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public static readonly Resolution LPMDAPFHFPH;

		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public static readonly Resolution FPFGJMDIABG;

		[Cpp2IlInjected.Token(Token = "0x4000014")]
		internal static readonly Resolution[] ALDEGGHLKDI;
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public static class KALOEEIKDGI
	{
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public static readonly Resolution OCDDFEOKBPH;

		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public static readonly Resolution BJGMJLFGDEC;

		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public static readonly Resolution DPGAOOPOHEH;

		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public static readonly Resolution LKLLIHOODDE;

		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public static readonly Resolution OMHHOINHAJP;

		[Cpp2IlInjected.Token(Token = "0x400001A")]
		internal static readonly Resolution[] ALDEGGHLKDI;

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x43CB2B0", Offset = "0x43CA6B0", VA = "0x1843CB2B0")]
		public static Resolution KEAEGJEBMDI(uint PDGEOAMFAGE)
		{
			return default(Resolution);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public static readonly Resolution BKEIKEGENED;

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x43CAE90", Offset = "0x43CA290", VA = "0x1843CAE90")]
	public static bool JCMLBHEEPIA(uint NBIHKAMGFCA)
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
		public enum NKNNDFNFDIO : byte
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
		private class OFLFJANPENK : IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			private string AAODJFHPDJC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			public Texture2D LJFGGJPNGDA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400002C")]
			public NKNNDFNFDIO AJBJGLFFNIJ;

			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x43CC9B0", Offset = "0x43CBDB0", VA = "0x1843CC9B0")]
			public OFLFJANPENK(string AAODJFHPDJC)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x76DB60", Offset = "0x76CF60", VA = "0x18076DB60")]
			public OFLFJANPENK(string AAODJFHPDJC, Texture2D HHCMAOOHPAC, NKNNDFNFDIO GGNEKJNCOKP)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x43CC980", Offset = "0x43CBD80", VA = "0x1843CC980", Slot = "4")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000D")]
		[CompilerGenerated]
		private sealed class AMIJINJDOIC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400002D")]
			public ManagedTexture <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400002E")]
			public NKNNDFNFDIO textureMemory;

			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x4C19D0", Offset = "0x4C0DD0", VA = "0x1804C19D0")]
			public AMIJINJDOIC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x43C9B90", Offset = "0x43C8F90", VA = "0x1843C9B90")]
			internal void <GetManagedTexture>b__0()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000E")]
		[CompilerGenerated]
		private sealed class MIMDIFCPJON
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400002F")]
			public int quality;

			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x4C19D0", Offset = "0x4C0DD0", VA = "0x1804C19D0")]
			public MIMDIFCPJON()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x43CB6C0", Offset = "0x43CAAC0", VA = "0x1843CB6C0")]
			internal byte[] <EncodeToJPG>b__0(Texture2D t2d)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000F")]
		[CompilerGenerated]
		private sealed class MCIGFBLJAEH
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000030")]
			public RenderTexture tempRenderTexture;

			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x4C19D0", Offset = "0x4C0DD0", VA = "0x1804C19D0")]
			public MCIGFBLJAEH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x43CB640", Offset = "0x43CAA40", VA = "0x1843CB640")]
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
		private global::GMNMGKEAFFO<Texture2D> _cpuSidePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private OFLFJANPENK _memTexture;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private global::GMNMGKEAFFO<byte[]> _jpgEncodePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private byte[] _jpgBytes;

		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public const int DEFAULT_JPG_QUALITY = 80;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private global::GMNMGKEAFFO<byte[]> _pngEncodePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private byte[] _pngBytes;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public bool UsePalette
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x4E9180", Offset = "0x4E8580", VA = "0x1804E9180")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public RenderTexture LastRenderTexture
		{
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x4C1CF0", Offset = "0x4C10F0", VA = "0x1804C1CF0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x4E87D0", Offset = "0x4E7BD0", VA = "0x1804E87D0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		private OFLFJANPENK memoryTexture
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x43CC900", Offset = "0x43CBD00", VA = "0x1843CC900")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x43CC8B0", Offset = "0x43CBCB0", VA = "0x1843CC8B0")]
		public ManagedTexture(string AAODJFHPDJC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x43CC860", Offset = "0x43CBC60", VA = "0x1843CC860")]
		public ManagedTexture(string AAODJFHPDJC, bool DEIMKKOEKPO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x43CBB50", Offset = "0x43CAF50", VA = "0x1843CBB50")]
		public void EIEFCEMFGBH(RenderTexture FPBNLCOJEIC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x43CC6D0", Offset = "0x43CBAD0", VA = "0x1843CC6D0")]
		public global::GMNMGKEAFFO<byte[]> OHHKFHJKKCC(bool HNCOEIFFMEE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x43CBBD0", Offset = "0x43CAFD0", VA = "0x1843CBBD0")]
		public global::GMNMGKEAFFO<Texture2D> EIPONEPGOKO(NKNNDFNFDIO GGNEKJNCOKP, bool DFBJCJKBJHL = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x43CBE50", Offset = "0x43CB250", VA = "0x1843CBE50")]
		public global::GMNMGKEAFFO<byte[]> GDCCKDGLLOG(bool DFBJCJKBJHL = false, int HLEPHPBDHIH = 80)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x43CC4C0", Offset = "0x43CB8C0", VA = "0x1843CC4C0")]
		public global::GMNMGKEAFFO<byte[]> KDFAHJLMKIM(bool DFBJCJKBJHL = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x43CBFF0", Offset = "0x43CB3F0", VA = "0x1843CBFF0")]
		private static global::GMNMGKEAFFO<Texture2D> IPIKLCGAILA(string AAODJFHPDJC, RenderTexture FPBNLCOJEIC, ref Texture2D MNJFNHJFDOD, bool DFBJCJKBJHL, NKNNDFNFDIO AOADIKKAOAE = NKNNDFNFDIO.GPU)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x43CBAE0", Offset = "0x43CAEE0", VA = "0x1843CBAE0")]
		public void BMGOKHPGFMC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x43CBAE0", Offset = "0x43CAEE0", VA = "0x1843CBAE0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x43CC630", Offset = "0x43CBA30", VA = "0x1843CC630")]
		[CompilerGenerated]
		private global::GMNMGKEAFFO<byte[]> OCJFHBCBAIK(Texture2D JGFNOHLEHFN)
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public static class GCHNDFMOFGI
{
	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x43CB140", Offset = "0x43CA540", VA = "0x1843CB140")]
	public static RenderTexture FPKGBOEDIJC(int PDGEOAMFAGE, int IIOKLEBJNCC, int PHKAHLBDNEB, Camera BEKCFBHJHPH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x43CB0D0", Offset = "0x43CA4D0", VA = "0x1843CB0D0")]
	public static void EGLBNKKFIHC(RenderTexture FPBNLCOJEIC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class BNGHFNAHNJJ
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public class PCHHHNDJBDD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public int HBBFBNIBFJH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public int PJBCJCDIJAD;

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x8C1DC0", Offset = "0x8C11C0", VA = "0x1808C1DC0")]
		public PCHHHNDJBDD(int AMJFFDFDFBH, int MGJAPINLAFH)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	private enum NMOGAGMODOC
	{
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		Point,
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		Bilinear,
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		Average
	}

	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private static Color[] EMODEAGDMPG;

	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private static Color[] AFJDGMEOOAG;

	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private static int IBDFNBHFLMJ;

	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private static float ELKJBILGEDL;

	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private static float ABLBLGOFFJI;

	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private static int DOLONJDAFEF;

	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private static int HGIPMFLEMIC;

	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private static Mutex BPACDEKAHFJ;

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x43C9E30", Offset = "0x43C9230", VA = "0x1843C9E30")]
	public static void BGIBHJHAEAJ(Texture2D FFFEJNGECGP, int KGKINJAADHM, int BGHJHGGNHPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x43CA030", Offset = "0x43C9430", VA = "0x1843CA030")]
	private static void GPOHGFKMDOG(Texture2D FFFEJNGECGP, int KGKINJAADHM, int BGHJHGGNHPI, NMOGAGMODOC BENFHEMCBPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x43CA950", Offset = "0x43C9D50", VA = "0x1843CA950")]
	public static void PFPLHDLHCKH(object JLOFPPFANIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x43C9E50", Offset = "0x43C9250", VA = "0x1843C9E50")]
	public static void GNGPMAGDNBG(object JLOFPPFANIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x43CA4C0", Offset = "0x43C98C0", VA = "0x1843CA4C0")]
	private static Color IDHKBNNPFNN(int FDNDJJDHFEF, int KILEPAPFHJE, float ELKJBILGEDL, float ABLBLGOFFJI)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x43CA770", Offset = "0x43C9B70", VA = "0x1843CA770")]
	public static void NICIILHMABD(object JLOFPPFANIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x43CA680", Offset = "0x43C9A80", VA = "0x1843CA680")]
	private static Color MBDFDAPOAGK(Color GBJGDEILMGM, Color FLOINHDFHEA, float DOLIKBJJDJE)
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
