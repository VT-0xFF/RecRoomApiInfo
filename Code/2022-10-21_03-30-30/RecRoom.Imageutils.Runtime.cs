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
		[Cpp2IlInjected.Address(RVA = "0x5E65A70", Offset = "0x5E64870", VA = "0x185E65A70")]
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
			[Cpp2IlInjected.Address(RVA = "0x5E676B0", Offset = "0x5E664B0", VA = "0x185E676B0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x5E676A0", Offset = "0x5E664A0", VA = "0x185E676A0")]
		public Resolution(uint KNMKEOOODCL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x661A30", Offset = "0x660830", VA = "0x180661A30")]
		public Resolution(uint KNMKEOOODCL, uint EMKKILCIAOK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x5E675B0", Offset = "0x5E663B0", VA = "0x185E675B0")]
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
			[Cpp2IlInjected.Address(RVA = "0x5E67100", Offset = "0x5E65F00", VA = "0x185E67100")]
			get
			{
				return default(uint);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public uint EMKKILCIAOK
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x5E66D60", Offset = "0x5E65B60", VA = "0x185E66D60")]
			get
			{
				return default(uint);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public Resolution FHHMBEOOMIM
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x5E66F20", Offset = "0x5E65D20", VA = "0x185E66F20")]
			get
			{
				return default(Resolution);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0xDDD300", Offset = "0xDDC100", VA = "0x180DDD300")]
		public OFIMMFLGLKI(Resolution MHJDMGHNAOL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x5E66D80", Offset = "0x5E65B80", VA = "0x185E66D80")]
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
		[Cpp2IlInjected.Address(RVA = "0x5E65690", Offset = "0x5E64490", VA = "0x185E65690")]
		public static Resolution KILAKFPKKDE(uint KLFKELPFFNF)
		{
			return default(Resolution);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public static readonly Resolution FLOAMMBMBBA;

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x5E65B20", Offset = "0x5E64920", VA = "0x185E65B20")]
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
			[Cpp2IlInjected.Address(RVA = "0x5E65AD0", Offset = "0x5E648D0", VA = "0x185E65AD0")]
			public EKFDJIBOINJ(string BEMAPDNKPAD)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x9B4A80", Offset = "0x9B3880", VA = "0x1809B4A80")]
			public EKFDJIBOINJ(string BEMAPDNKPAD, Texture2D KMDJHNBKGGO, GNIPIFCCDHI KCDCEJCMDKK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x5E65A90", Offset = "0x5E64890", VA = "0x185E65A90", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x65A810", Offset = "0x659610", VA = "0x18065A810")]
			public AEPIKLHDDED()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x5E646A0", Offset = "0x5E634A0", VA = "0x185E646A0")]
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
			[Cpp2IlInjected.Address(RVA = "0x65A810", Offset = "0x659610", VA = "0x18065A810")]
			public BHCMFNLCDII()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x5E65A50", Offset = "0x5E64850", VA = "0x185E65A50")]
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
			[Cpp2IlInjected.Address(RVA = "0x65A810", Offset = "0x659610", VA = "0x18065A810")]
			public KCKKLCFEBJE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x5E65D80", Offset = "0x5E64B80", VA = "0x185E65D80")]
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
			[Cpp2IlInjected.Address(RVA = "0x6B19D0", Offset = "0x6B07D0", VA = "0x1806B19D0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public RenderTexture LastRenderTexture
		{
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x65B250", Offset = "0x65A050", VA = "0x18065B250")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x6A0580", Offset = "0x69F380", VA = "0x1806A0580")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		private EKFDJIBOINJ memoryTexture
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x5E66CC0", Offset = "0x5E65AC0", VA = "0x185E66CC0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x5E66C70", Offset = "0x5E65A70", VA = "0x185E66C70")]
		public ManagedTexture(string BEMAPDNKPAD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x5E66C10", Offset = "0x5E65A10", VA = "0x185E66C10")]
		public ManagedTexture(string BEMAPDNKPAD, bool KKIJPGPEKJN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x5E66330", Offset = "0x5E65130", VA = "0x185E66330")]
		public void JAIMKKDJOGN(RenderTexture BOPKABBIJAM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x5E66300", Offset = "0x5E65100", VA = "0x185E66300")]
		public global::DGCAEBAFOOK<byte[]> DMDDFCHNGMI(bool FHBEMHIFEJJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x5E66010", Offset = "0x5E64E10", VA = "0x185E66010")]
		public global::DGCAEBAFOOK<Texture2D> BGOFNHJJAEM(GNIPIFCCDHI KCDCEJCMDKK, bool LDGFEKMKAJL = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x5E65E10", Offset = "0x5E64C10", VA = "0x185E65E10")]
		public global::DGCAEBAFOOK<byte[]> BDOACBCNPLA(bool LDGFEKMKAJL = false, int BNALEFONLCG = 80)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x5E66420", Offset = "0x5E65220", VA = "0x185E66420")]
		public global::DGCAEBAFOOK<byte[]> LBOOMHGGKCC(bool LDGFEKMKAJL = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x5E665E0", Offset = "0x5E653E0", VA = "0x185E665E0")]
		private static global::DGCAEBAFOOK<Texture2D> PBLDDLOEADD(string BEMAPDNKPAD, RenderTexture BOPKABBIJAM, ref Texture2D LJLGHGGNBJI, bool LDGFEKMKAJL, GNIPIFCCDHI KMKPNLDEGAH = GNIPIFCCDHI.GPU)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x5E66360", Offset = "0x5E65160", VA = "0x185E66360")]
		public void JBJDBKNELJA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x5E66320", Offset = "0x5E65120", VA = "0x185E66320", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x5E66B60", Offset = "0x5E65960", VA = "0x185E66B60")]
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
	[Cpp2IlInjected.Address(RVA = "0x5E67180", Offset = "0x5E65F80", VA = "0x185E67180")]
	public static RenderTexture KOIBDPJJJMK(int KLFKELPFFNF, int AGONAJNGCCO, int MOLGFCBNAJA, Camera KJOMMEKPFAI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x5E67110", Offset = "0x5E65F10", VA = "0x185E67110")]
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
		[Cpp2IlInjected.Address(RVA = "0x748990", Offset = "0x747790", VA = "0x180748990")]
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
	[Cpp2IlInjected.Address(RVA = "0x5E646E0", Offset = "0x5E634E0", VA = "0x185E646E0")]
	public static void AGHOGKPDHJJ(Texture2D BCMIJGMPPAL, int BOBGEIAHGKI, int FDCFGLPCNPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x5E64B50", Offset = "0x5E63950", VA = "0x185E64B50")]
	private static void IMBCHODDGAA(Texture2D BCMIJGMPPAL, int BOBGEIAHGKI, int FDCFGLPCNPN, IBPEEAIMBEC MFMGKGDAPJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x5E65040", Offset = "0x5E63E40", VA = "0x185E65040")]
	public static void MOIEEHOKEBE(object CCPIHKCBGHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x5E64980", Offset = "0x5E63780", VA = "0x185E64980")]
	public static void HFNMBBIKAJI(object CCPIHKCBGHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x5E64700", Offset = "0x5E63500", VA = "0x185E64700")]
	private static Color CEFCJHBBDOJ(int KNMKEOOODCL, int EMKKILCIAOK, float PLPAMFGFJPE, float DFMAICKGLHK)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x5E654C0", Offset = "0x5E642C0", VA = "0x185E654C0")]
	public static void OPOBMNHGGMD(object CCPIHKCBGHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x5E648A0", Offset = "0x5E636A0", VA = "0x185E648A0")]
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
