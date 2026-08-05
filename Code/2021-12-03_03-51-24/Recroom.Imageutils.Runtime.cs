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
		[Cpp2IlInjected.Address(RVA = "0x3F7A680", Offset = "0x3F79880", VA = "0x183F7A680")]
		public CubeMapGenerator()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public enum FBPOKFIOMGF
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
public interface IDGNEBPGAPH
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	FBPOKFIOMGF PGIOEELGNKM
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class KLHOGCBCHPF
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
			[Cpp2IlInjected.Address(RVA = "0x3F7D460", Offset = "0x3F7C660", VA = "0x183F7D460")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x3F7D450", Offset = "0x3F7C650", VA = "0x183F7D450")]
		public Resolution(uint HFHNJJJOCHJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x57E340", Offset = "0x57D540", VA = "0x18057E340")]
		public Resolution(uint HFHNJJJOCHJ, uint OCFCJMCJMEC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x3F7D300", Offset = "0x3F7C500", VA = "0x183F7D300")]
		public static Resolution HKNGIPKBLAC(Resolution[] HOANHHBHEOA, Resolution KNJNGMPPBIK, int FMNJHAPNDOL)
		{
			return default(Resolution);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public class HAJBEICJNMK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private readonly Resolution NGCBPNIPBEP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private Resolution? IFBLBPGBFIM;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public uint HFHNJJJOCHJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x3F7AEA0", Offset = "0x3F7A0A0", VA = "0x183F7AEA0")]
			get
			{
				return default(uint);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public uint OCFCJMCJMEC
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x3F7AE80", Offset = "0x3F7A080", VA = "0x183F7AE80")]
			get
			{
				return default(uint);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public Resolution KLEANMEOABC
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x3F7AAB0", Offset = "0x3F79CB0", VA = "0x183F7AAB0")]
			get
			{
				return default(Resolution);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x23DF750", Offset = "0x23DE950", VA = "0x1823DF750")]
		public HAJBEICJNMK(Resolution NGCBPNIPBEP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x3F7ACB0", Offset = "0x3F79EB0", VA = "0x183F7ACB0")]
		private static Resolution DIMBBOHFEGJ(Resolution IFBLBPGBFIM, FBPOKFIOMGF LOAOEELNCOC)
		{
			return default(Resolution);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public static class HKBANCBAPBP
	{
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public static readonly Resolution PDNLHBNJOCJ;

		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public static readonly Resolution GEAHMLKEHNA;

		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public static readonly Resolution CEFACEOHMPI;

		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public static readonly Resolution PEAADEPEPHL;

		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public static readonly Resolution HPFCCLFDCBD;

		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public static readonly Resolution POHBDGHCNLJ;

		[Cpp2IlInjected.Token(Token = "0x4000014")]
		internal static readonly Resolution[] GIKDJNFGKGL;
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public static class FPBCHMOBFMF
	{
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public static readonly Resolution AOKIFBAONOL;

		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public static readonly Resolution EKKIKJCOKNO;

		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public static readonly Resolution ALNPHNOJEEP;

		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public static readonly Resolution JIMMLCNGCHA;

		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public static readonly Resolution KIBAHPHCDMK;

		[Cpp2IlInjected.Token(Token = "0x400001A")]
		internal static readonly Resolution[] GIKDJNFGKGL;

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x3F7A720", Offset = "0x3F79920", VA = "0x183F7A720")]
		public static Resolution HHKODGJBHJK(uint CEONAJBCPHB)
		{
			return default(Resolution);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public static readonly Resolution DGMMHPNPBOG;

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x3F7B170", Offset = "0x3F7A370", VA = "0x183F7B170")]
	public static bool OFAKDGBJHOG(uint NDBEDLCBCAH)
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
		public enum KEOFFNIJHPI : byte
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
		private class LHJMONMBIGB : IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			private string OMNGGFHPHNL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			public Texture2D LFGPFMBFPJC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400002C")]
			public KEOFFNIJHPI PPGHBDDIFFL;

			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x3F7B3E0", Offset = "0x3F7A5E0", VA = "0x183F7B3E0")]
			public LHJMONMBIGB(string OMNGGFHPHNL)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x6EE530", Offset = "0x6ED730", VA = "0x1806EE530")]
			public LHJMONMBIGB(string OMNGGFHPHNL, Texture2D NACHDJNEDIE, KEOFFNIJHPI NFNCCELHHPH)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x3F7B3B0", Offset = "0x3F7A5B0", VA = "0x183F7B3B0", Slot = "4")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000D")]
		[CompilerGenerated]
		private sealed class HJIOEKNEDPB
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400002D")]
			public ManagedTexture <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400002E")]
			public KEOFFNIJHPI textureMemory;

			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x4719D0", Offset = "0x470BD0", VA = "0x1804719D0")]
			public HJIOEKNEDPB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x3F7AEB0", Offset = "0x3F7A0B0", VA = "0x183F7AEB0")]
			internal void <GetManagedTexture>b__0()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000E")]
		[CompilerGenerated]
		private sealed class HLIEMLCPEBI
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400002F")]
			public int quality;

			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x4719D0", Offset = "0x470BD0", VA = "0x1804719D0")]
			public HLIEMLCPEBI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x3F7B150", Offset = "0x3F7A350", VA = "0x183F7B150")]
			internal byte[] <EncodeToJPG>b__0(Texture2D t2d)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000F")]
		[CompilerGenerated]
		private sealed class FCJFJFKFNCJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000030")]
			public RenderTexture tempRenderTexture;

			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x4719D0", Offset = "0x470BD0", VA = "0x1804719D0")]
			public FCJFJFKFNCJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x3F7A6A0", Offset = "0x3F798A0", VA = "0x183F7A6A0")]
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
		private global::GFAADABKIAG<Texture2D> _cpuSidePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private LHJMONMBIGB _memTexture;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private global::GFAADABKIAG<byte[]> _jpgEncodePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private byte[] _jpgBytes;

		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public const int DEFAULT_JPG_QUALITY = 80;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private global::GFAADABKIAG<byte[]> _pngEncodePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private byte[] _pngBytes;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public bool UsePalette
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x499180", Offset = "0x498380", VA = "0x180499180")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public RenderTexture LastRenderTexture
		{
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x471CF0", Offset = "0x470EF0", VA = "0x180471CF0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x4987D0", Offset = "0x4979D0", VA = "0x1804987D0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		private LHJMONMBIGB memoryTexture
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x3F7C240", Offset = "0x3F7B440", VA = "0x183F7C240")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x3F7C1F0", Offset = "0x3F7B3F0", VA = "0x183F7C1F0")]
		public ManagedTexture(string OMNGGFHPHNL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x3F7C1A0", Offset = "0x3F7B3A0", VA = "0x183F7C1A0")]
		public ManagedTexture(string OMNGGFHPHNL, bool EHOFHEFPIEB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x3F7C120", Offset = "0x3F7B320", VA = "0x183F7C120")]
		public void PFEBEIDHNNB(RenderTexture NDOHKEKJHAJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x3F7B490", Offset = "0x3F7A690", VA = "0x183F7B490")]
		public global::GFAADABKIAG<byte[]> EIMLAMGIIKP(bool EFOMGNCMMPD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x3F7B620", Offset = "0x3F7A820", VA = "0x183F7B620")]
		public global::GFAADABKIAG<Texture2D> HICPJALMANG(KEOFFNIJHPI NFNCCELHHPH, bool AOGIDECPGKG = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x3F7BF80", Offset = "0x3F7B180", VA = "0x183F7BF80")]
		public global::GFAADABKIAG<byte[]> OEEOBOPMGPA(bool AOGIDECPGKG = false, int LAKKCKNGHNB = 80)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x3F7BD70", Offset = "0x3F7AF70", VA = "0x183F7BD70")]
		public global::GFAADABKIAG<byte[]> JBKBPLMNOMP(bool AOGIDECPGKG = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x3F7B8A0", Offset = "0x3F7AAA0", VA = "0x183F7B8A0")]
		private static global::GFAADABKIAG<Texture2D> IPKOMCIMKAL(string OMNGGFHPHNL, RenderTexture NDOHKEKJHAJ, ref Texture2D AELBOGMIFPB, bool AOGIDECPGKG, KEOFFNIJHPI HNNFPFMNLLG = KEOFFNIJHPI.GPU)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x3F7B420", Offset = "0x3F7A620", VA = "0x183F7B420")]
		public void APDKFBKJFEO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x3F7B420", Offset = "0x3F7A620", VA = "0x183F7B420", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x3F7BEE0", Offset = "0x3F7B0E0", VA = "0x183F7BEE0")]
		[CompilerGenerated]
		private global::GFAADABKIAG<byte[]> LNPMAIDJBNN(Texture2D CCIACKNKCHA)
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public static class CJDAAGICLLN
{
	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x3F7A4A0", Offset = "0x3F796A0", VA = "0x183F7A4A0")]
	public static RenderTexture BAFLMOCIILD(int CEONAJBCPHB, int CJJNNAADKMO, int MEJGCLJFMFK, Camera FKJGPIENBBB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x3F7A610", Offset = "0x3F79810", VA = "0x183F7A610")]
	public static void FOLOGOPFKLO(RenderTexture NDOHKEKJHAJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class NDHEHOAJJKI
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public class DJPNOHJKJCK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public int GCLJHKFNNFJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public int BFAKJIPFGDA;

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x85B6C0", Offset = "0x85A8C0", VA = "0x18085B6C0")]
		public DJPNOHJKJCK(int JNCKFICFHFI, int HHEDDBLEJEI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	private enum IDHPFGNAICB
	{
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		Point,
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		Bilinear,
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		Average
	}

	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private static Color[] HKOBHIJFJNG;

	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private static Color[] CGAMJNJCLMH;

	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private static int DOHOOGIDJEK;

	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private static float LJKCFFAJAAO;

	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private static float CMPBEGFLNFO;

	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private static int NNOHICKCCHC;

	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private static int PLABFAODNHH;

	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private static Mutex IGFBHHGNFAD;

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x3F7D1F0", Offset = "0x3F7C3F0", VA = "0x183F7D1F0")]
	public static void HPOBMCPEMHK(Texture2D NKIKCOBLADO, int OOCILLOPEGA, int LIPKCPKLHLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x3F7C2C0", Offset = "0x3F7B4C0", VA = "0x183F7C2C0")]
	private static void BJKMDOENKHL(Texture2D NKIKCOBLADO, int OOCILLOPEGA, int LIPKCPKLHLB, IDHPFGNAICB KGKCOFGIHPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x3F7C930", Offset = "0x3F7BB30", VA = "0x183F7C930")]
	public static void DOHFALCAMKP(object NLPBLPBCJHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x3F7D010", Offset = "0x3F7C210", VA = "0x183F7D010")]
	public static void EPENHIOBEEL(object NLPBLPBCJHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x3F7CE50", Offset = "0x3F7C050", VA = "0x183F7CE50")]
	private static Color EJIHGNGPBPK(int HFHNJJJOCHJ, int OCFCJMCJMEC, float LJKCFFAJAAO, float CMPBEGFLNFO)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x3F7C750", Offset = "0x3F7B950", VA = "0x183F7C750")]
	public static void CENEGKPDLLK(object NLPBLPBCJHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x3F7D210", Offset = "0x3F7C410", VA = "0x183F7D210")]
	private static Color MPLJOIEDFFK(Color EOLFJEKBJDD, Color EKGNAFIJLDN, float LNFKIKOILLL)
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
