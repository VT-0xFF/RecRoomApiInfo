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
		[Cpp2IlInjected.Address(RVA = "0x5E66F10", Offset = "0x5E65D10", VA = "0x185E66F10")]
		public CubeMapGenerator()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public enum HPDMCDHGCLK
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
public interface ENLLKONBLFF
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	HPDMCDHGCLK IIPKCDPFIHK
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class IGMIKGEACEM
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
			[Cpp2IlInjected.Address(RVA = "0x5E68B50", Offset = "0x5E67950", VA = "0x185E68B50")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x5E68B40", Offset = "0x5E67940", VA = "0x185E68B40")]
		public Resolution(uint KNMKEOOODCL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x678050", Offset = "0x676E50", VA = "0x180678050")]
		public Resolution(uint KNMKEOOODCL, uint EMKKILCIAOK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x5E68A50", Offset = "0x5E67850", VA = "0x185E68A50")]
		public static Resolution AEGDCDHBOAA(Resolution[] FJDLENJCEEA, Resolution KHJBCHKLCPE, int KPJOCLELOAK)
		{
			return default(Resolution);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public class OFIMMFLGLKI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private readonly Resolution MHJDMGHNAOL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private Resolution? PGMHGDGHIDO;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public uint KNMKEOOODCL
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x5E685A0", Offset = "0x5E673A0", VA = "0x185E685A0")]
			get
			{
				return default(uint);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public uint EMKKILCIAOK
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x5E68200", Offset = "0x5E67000", VA = "0x185E68200")]
			get
			{
				return default(uint);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public Resolution FHHMBEOOMIM
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x5E683C0", Offset = "0x5E671C0", VA = "0x185E683C0")]
			get
			{
				return default(Resolution);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0xF1EFD0", Offset = "0xF1DDD0", VA = "0x180F1EFD0")]
		public OFIMMFLGLKI(Resolution MHJDMGHNAOL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x5E68220", Offset = "0x5E67020", VA = "0x185E68220")]
		private static Resolution JAFLNIBNEAO(Resolution PGMHGDGHIDO, HPDMCDHGCLK MMBIFMOEGNJ)
		{
			return default(Resolution);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public static class PAMEJOBFALP
	{
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public static readonly Resolution GOIFNHHFDII;

		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public static readonly Resolution JFFDEEBFGBK;

		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public static readonly Resolution BHFNMMGBMHJ;

		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public static readonly Resolution CFNKEDIGEFE;

		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public static readonly Resolution DFEGGFNBODC;

		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public static readonly Resolution KAJHIOLNICG;

		[Cpp2IlInjected.Token(Token = "0x4000014")]
		internal static readonly Resolution[] ENEODMNCFCJ;
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public static class BGLOEFJMNJM
	{
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public static readonly Resolution AJPAMBNHHMN;

		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public static readonly Resolution HNDLFMPFAFJ;

		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public static readonly Resolution GHKAOKOFGBK;

		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public static readonly Resolution BLFIGOOHIOM;

		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public static readonly Resolution AOPHNADICCA;

		[Cpp2IlInjected.Token(Token = "0x400001A")]
		internal static readonly Resolution[] ENEODMNCFCJ;

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x5E66B30", Offset = "0x5E65930", VA = "0x185E66B30")]
		public static Resolution KILAKFPKKDE(uint KLFKELPFFNF)
		{
			return default(Resolution);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public static readonly Resolution FLOAMMBMBBA;

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x5E66FC0", Offset = "0x5E65DC0", VA = "0x185E66FC0")]
	public static bool JGKODMAJLIC(uint IPMFBEGAKOD)
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
		public enum GNIPIFCCDHI : byte
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
		private class EKFDJIBOINJ : IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			private string BEMAPDNKPAD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			public Texture2D FLIIFAJKAIG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400002C")]
			public GNIPIFCCDHI DPIEFGBDMJO;

			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x5E66F70", Offset = "0x5E65D70", VA = "0x185E66F70")]
			public EKFDJIBOINJ(string BEMAPDNKPAD)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x65D750", Offset = "0x65C550", VA = "0x18065D750")]
			public EKFDJIBOINJ(string BEMAPDNKPAD, Texture2D KMDJHNBKGGO, GNIPIFCCDHI KCDCEJCMDKK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x5E66F30", Offset = "0x5E65D30", VA = "0x185E66F30", Slot = "4")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000D")]
		[CompilerGenerated]
		private sealed class AEPIKLHDDED
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400002D")]
			public ManagedTexture <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400002E")]
			public GNIPIFCCDHI textureMemory;

			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657930", VA = "0x180658B30")]
			public AEPIKLHDDED()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x5E65B40", Offset = "0x5E64940", VA = "0x185E65B40")]
			internal void <GetManagedTexture>b__0()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000E")]
		[CompilerGenerated]
		private sealed class BHCMFNLCDII
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400002F")]
			public int quality;

			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657930", VA = "0x180658B30")]
			public BHCMFNLCDII()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x5E66EF0", Offset = "0x5E65CF0", VA = "0x185E66EF0")]
			internal byte[] <EncodeToJPG>b__0(Texture2D t2d)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000F")]
		[CompilerGenerated]
		private sealed class KCKKLCFEBJE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000030")]
			public RenderTexture tempRenderTexture;

			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657930", VA = "0x180658B30")]
			public KCKKLCFEBJE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x5E67220", Offset = "0x5E66020", VA = "0x185E67220")]
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
		private global::DGCAEBAFOOK<Texture2D> _cpuSidePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private EKFDJIBOINJ _memTexture;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private global::DGCAEBAFOOK<byte[]> _jpgEncodePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private byte[] _jpgBytes;

		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public const int DEFAULT_JPG_QUALITY = 80;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private global::DGCAEBAFOOK<byte[]> _pngEncodePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private byte[] _pngBytes;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public bool UsePalette
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x65B250", Offset = "0x65A050", VA = "0x18065B250")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public RenderTexture LastRenderTexture
		{
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x658120", Offset = "0x656F20", VA = "0x180658120")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x658130", Offset = "0x656F30", VA = "0x180658130")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		private EKFDJIBOINJ memoryTexture
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x5E68160", Offset = "0x5E66F60", VA = "0x185E68160")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x5E68110", Offset = "0x5E66F10", VA = "0x185E68110")]
		public ManagedTexture(string BEMAPDNKPAD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x5E680B0", Offset = "0x5E66EB0", VA = "0x185E680B0")]
		public ManagedTexture(string BEMAPDNKPAD, bool KKIJPGPEKJN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x5E677D0", Offset = "0x5E665D0", VA = "0x185E677D0")]
		public void JAIMKKDJOGN(RenderTexture BOPKABBIJAM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x5E677A0", Offset = "0x5E665A0", VA = "0x185E677A0")]
		public global::DGCAEBAFOOK<byte[]> DMDDFCHNGMI(bool FHBEMHIFEJJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x5E674B0", Offset = "0x5E662B0", VA = "0x185E674B0")]
		public global::DGCAEBAFOOK<Texture2D> BGOFNHJJAEM(GNIPIFCCDHI KCDCEJCMDKK, bool LDGFEKMKAJL = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x5E672B0", Offset = "0x5E660B0", VA = "0x185E672B0")]
		public global::DGCAEBAFOOK<byte[]> BDOACBCNPLA(bool LDGFEKMKAJL = false, int BNALEFONLCG = 80)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x5E678C0", Offset = "0x5E666C0", VA = "0x185E678C0")]
		public global::DGCAEBAFOOK<byte[]> LBOOMHGGKCC(bool LDGFEKMKAJL = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x5E67A80", Offset = "0x5E66880", VA = "0x185E67A80")]
		private static global::DGCAEBAFOOK<Texture2D> PBLDDLOEADD(string BEMAPDNKPAD, RenderTexture BOPKABBIJAM, ref Texture2D LJLGHGGNBJI, bool LDGFEKMKAJL, GNIPIFCCDHI KMKPNLDEGAH = GNIPIFCCDHI.GPU)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x5E67800", Offset = "0x5E66600", VA = "0x185E67800")]
		public void JBJDBKNELJA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x5E677C0", Offset = "0x5E665C0", VA = "0x185E677C0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x5E68000", Offset = "0x5E66E00", VA = "0x185E68000")]
		[CompilerGenerated]
		private global::DGCAEBAFOOK<byte[]> PEDKDMJHMIM(Texture2D MLLJNENPDAI)
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public static class OIPIKPKPMDG
{
	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x5E68620", Offset = "0x5E67420", VA = "0x185E68620")]
	public static RenderTexture KOIBDPJJJMK(int KLFKELPFFNF, int AGONAJNGCCO, int MOLGFCBNAJA, Camera KJOMMEKPFAI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x5E685B0", Offset = "0x5E673B0", VA = "0x185E685B0")]
	public static void CMGDIHMMPJG(RenderTexture BOPKABBIJAM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class APOLDJJMMOD
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public class FJPEEEHFIKD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public int FOACNEHDHLI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public int CBNJCJLIEMJ;

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0xB6E430", Offset = "0xB6D230", VA = "0x180B6E430")]
		public FJPEEEHFIKD(int JELKAOENNOA, int BKGIODDNKLG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	private enum IBPEEAIMBEC
	{
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		Point,
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		Bilinear,
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		Average
	}

	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private static Color[] MCMFCOLFOLG;

	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private static Color[] LINAMPIOLME;

	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private static int KKGHEBDDELA;

	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private static float PLPAMFGFJPE;

	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private static float DFMAICKGLHK;

	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private static int OAGGIAHLDED;

	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private static int AOOMFGBNFHN;

	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private static Mutex AFAFOHAANJF;

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x5E65B80", Offset = "0x5E64980", VA = "0x185E65B80")]
	public static void AGHOGKPDHJJ(Texture2D BCMIJGMPPAL, int BOBGEIAHGKI, int FDCFGLPCNPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x5E65FF0", Offset = "0x5E64DF0", VA = "0x185E65FF0")]
	private static void IMBCHODDGAA(Texture2D BCMIJGMPPAL, int BOBGEIAHGKI, int FDCFGLPCNPN, IBPEEAIMBEC MFMGKGDAPJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x5E664E0", Offset = "0x5E652E0", VA = "0x185E664E0")]
	public static void MOIEEHOKEBE(object CCPIHKCBGHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x5E65E20", Offset = "0x5E64C20", VA = "0x185E65E20")]
	public static void HFNMBBIKAJI(object CCPIHKCBGHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x5E65BA0", Offset = "0x5E649A0", VA = "0x185E65BA0")]
	private static Color CEFCJHBBDOJ(int KNMKEOOODCL, int EMKKILCIAOK, float PLPAMFGFJPE, float DFMAICKGLHK)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x5E66960", Offset = "0x5E65760", VA = "0x185E66960")]
	public static void OPOBMNHGGMD(object CCPIHKCBGHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x5E65D40", Offset = "0x5E64B40", VA = "0x185E65D40")]
	private static Color COHHFBCJDOO(Color IGGNNHOJPJN, Color FEPDNPIOBIG, float IGJPNMBCJPK)
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
