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
		[Cpp2IlInjected.Address(RVA = "0x4AF42F0", Offset = "0x4AF2AF0", VA = "0x184AF42F0")]
		public CubeMapGenerator()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public enum OOACPHJDPAE
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
public interface IJAIGNKEEHD
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	OOACPHJDPAE JHOJLEEGEPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class NGGDKFPNBEI
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
			[Cpp2IlInjected.Address(RVA = "0x4AF6EB0", Offset = "0x4AF56B0", VA = "0x184AF6EB0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x4AF6EA0", Offset = "0x4AF56A0", VA = "0x184AF6EA0")]
		public Resolution(uint DNCFOPMJGLJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x6AA9F0", Offset = "0x6A91F0", VA = "0x1806AA9F0")]
		public Resolution(uint DNCFOPMJGLJ, uint DEMCFCBJOPI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x4AF6D50", Offset = "0x4AF5550", VA = "0x184AF6D50")]
		public static Resolution EOEIDDCKINB(Resolution[] CCILPIACBAG, Resolution MDAMDHIKDGD, int DCCLACMIDAI)
		{
			return default(Resolution);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public class DBNPLNEPEAM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private readonly Resolution MFNDBOGMDMH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private Resolution? ACEJJNKDMFP;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public uint DNCFOPMJGLJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x4AF4700", Offset = "0x4AF2F00", VA = "0x184AF4700")]
			get
			{
				return default(uint);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public uint DEMCFCBJOPI
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x4AF46E0", Offset = "0x4AF2EE0", VA = "0x184AF46E0")]
			get
			{
				return default(uint);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public Resolution KLKDBOLMONJ
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x4AF44E0", Offset = "0x4AF2CE0", VA = "0x184AF44E0")]
			get
			{
				return default(Resolution);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x15EC5B0", Offset = "0x15EADB0", VA = "0x1815EC5B0")]
		public DBNPLNEPEAM(Resolution MFNDBOGMDMH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x4AF4310", Offset = "0x4AF2B10", VA = "0x184AF4310")]
		private static Resolution GKEKDFAHPAF(Resolution ACEJJNKDMFP, OOACPHJDPAE MFGBFKJJHAA)
		{
			return default(Resolution);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public static class FEGLPBLHCFB
	{
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public static readonly Resolution AGHGNDLEEKK;

		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public static readonly Resolution GOBLGEOOCFE;

		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public static readonly Resolution KGFKHKGOGFJ;

		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public static readonly Resolution DMDMBODOJNL;

		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public static readonly Resolution IKONAPKMCPO;

		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public static readonly Resolution PMCDHPIEENO;

		[Cpp2IlInjected.Token(Token = "0x4000014")]
		internal static readonly Resolution[] GCHDMCIGOIG;
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public static class CLGECBLGPKA
	{
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public static readonly Resolution NMONINFCCMP;

		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public static readonly Resolution PALFHNAKOAI;

		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public static readonly Resolution LBOKALHMGMN;

		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public static readonly Resolution AANLPDJPDCN;

		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public static readonly Resolution FKIFNNDMDJP;

		[Cpp2IlInjected.Token(Token = "0x400001A")]
		internal static readonly Resolution[] GCHDMCIGOIG;

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x4AF3F50", Offset = "0x4AF2750", VA = "0x184AF3F50")]
		public static Resolution NKOOAHIAIBI(uint JBENCIOJCIN)
		{
			return default(Resolution);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public static readonly Resolution HNMGHPFNAMK;

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x4AF6B10", Offset = "0x4AF5310", VA = "0x184AF6B10")]
	public static bool MDAFBFFAAPJ(uint NBLKHGPOCJG)
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
		public enum OHNIJAPEPNP : byte
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
		private class IIFOAPLINAA : IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			private string CBFODBDAPIM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			public Texture2D NBIGEFHDKLH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400002C")]
			public OHNIJAPEPNP OIOBMMOGFJJ;

			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x4AF5C90", Offset = "0x4AF4490", VA = "0x184AF5C90")]
			public IIFOAPLINAA(string CBFODBDAPIM)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x873A80", Offset = "0x872280", VA = "0x180873A80")]
			public IIFOAPLINAA(string CBFODBDAPIM, Texture2D PJIBFHCAPKE, OHNIJAPEPNP KBJAJBAFHFG)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x4AF5C50", Offset = "0x4AF4450", VA = "0x184AF5C50", Slot = "4")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000D")]
		[CompilerGenerated]
		private sealed class JGJDBBKOBNK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400002D")]
			public ManagedTexture <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400002E")]
			public OHNIJAPEPNP textureMemory;

			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x523AB0", Offset = "0x5222B0", VA = "0x180523AB0")]
			public JGJDBBKOBNK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x4AF5CE0", Offset = "0x4AF44E0", VA = "0x184AF5CE0")]
			internal void <GetManagedTexture>b__0()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000E")]
		[CompilerGenerated]
		private sealed class MFANOPNELDD
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400002F")]
			public int quality;

			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x523AB0", Offset = "0x5222B0", VA = "0x180523AB0")]
			public MFANOPNELDD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x4AF5D20", Offset = "0x4AF4520", VA = "0x184AF5D20")]
			internal byte[] <EncodeToJPG>b__0(Texture2D t2d)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000F")]
		[CompilerGenerated]
		private sealed class EEJCGPHOKLD
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000030")]
			public RenderTexture tempRenderTexture;

			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x523AB0", Offset = "0x5222B0", VA = "0x180523AB0")]
			public EEJCGPHOKLD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x4AF48F0", Offset = "0x4AF30F0", VA = "0x184AF48F0")]
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
		private global::HBEENCCJBCB<Texture2D> _cpuSidePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private IIFOAPLINAA _memTexture;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private global::HBEENCCJBCB<byte[]> _jpgEncodePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private byte[] _jpgBytes;

		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public const int DEFAULT_JPG_QUALITY = 80;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private global::HBEENCCJBCB<byte[]> _pngEncodePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private byte[] _pngBytes;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public bool UsePalette
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x54C7B0", Offset = "0x54AFB0", VA = "0x18054C7B0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public RenderTexture LastRenderTexture
		{
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x523DF0", Offset = "0x5225F0", VA = "0x180523DF0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x54BD70", Offset = "0x54A570", VA = "0x18054BD70")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		private IIFOAPLINAA memoryTexture
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x4AF6A70", Offset = "0x4AF5270", VA = "0x184AF6A70")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x4AF6A20", Offset = "0x4AF5220", VA = "0x184AF6A20")]
		public ManagedTexture(string CBFODBDAPIM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x4AF69C0", Offset = "0x4AF51C0", VA = "0x184AF69C0")]
		public ManagedTexture(string CBFODBDAPIM, bool LJJCAJDLCBG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x4AF6250", Offset = "0x4AF4A50", VA = "0x184AF6250")]
		public void CFFBLBGPAOL(RenderTexture FJDPMAINILB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x4AF5D40", Offset = "0x4AF4540", VA = "0x184AF5D40")]
		public global::HBEENCCJBCB<byte[]> BCHNEJEEGLP(bool KFGAINGGPFO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x4AF6280", Offset = "0x4AF4A80", VA = "0x184AF6280")]
		public global::HBEENCCJBCB<Texture2D> CHIGBOECEGO(OHNIJAPEPNP KBJAJBAFHFG, bool IJKLNDNICAJ = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x4AF6810", Offset = "0x4AF5010", VA = "0x184AF6810")]
		public global::HBEENCCJBCB<byte[]> LOMMCNPECBF(bool IJKLNDNICAJ = false, int FODGLDJODJB = 80)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x4AF6520", Offset = "0x4AF4D20", VA = "0x184AF6520")]
		public global::HBEENCCJBCB<byte[]> EHLCJFFFFDC(bool IJKLNDNICAJ = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x4AF5D60", Offset = "0x4AF4560", VA = "0x184AF5D60")]
		private static global::HBEENCCJBCB<Texture2D> CBCCFACEFNI(string CBFODBDAPIM, RenderTexture FJDPMAINILB, ref Texture2D GDKKCECCIHI, bool IJKLNDNICAJ, OHNIJAPEPNP CINNLCCGLIM = OHNIJAPEPNP.GPU)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x4AF66B0", Offset = "0x4AF4EB0", VA = "0x184AF66B0")]
		public void GFGPHBLOMLL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x4AF6510", Offset = "0x4AF4D10", VA = "0x184AF6510", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x4AF6770", Offset = "0x4AF4F70", VA = "0x184AF6770")]
		[CompilerGenerated]
		private global::HBEENCCJBCB<byte[]> GKHJFOHLBFO(Texture2D KMLOPJKEOMP)
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public static class DDKBLIAKIOM
{
	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x4AF4780", Offset = "0x4AF2F80", VA = "0x184AF4780")]
	public static RenderTexture EGPFFJNKEFN(int JBENCIOJCIN, int DHDPHMHHLFN, int LOBHBEGMMDM, Camera MONKHOPDOAF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x4AF4710", Offset = "0x4AF2F10", VA = "0x184AF4710")]
	public static void DPNKPCFHFDM(RenderTexture FJDPMAINILB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class HOAFCJHILHO
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public class OFHHFHJCIKK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public int HIIIFMJFPMD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public int IIOPPGEOJON;

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x5BA350", Offset = "0x5B8B50", VA = "0x1805BA350")]
		public OFHHFHJCIKK(int JFFDHNPMLKN, int NAAPPGENNFE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	private enum IIOEJAMMPOB
	{
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		Point,
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		Bilinear,
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		Average
	}

	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private static Color[] FIDIPINNLDO;

	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private static Color[] NKMKHHJGMPE;

	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private static int IHDEFGBHAOB;

	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private static float OICOHEEKALK;

	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private static float FIAFBOAGJBA;

	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private static int MCGKBIHHGPD;

	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private static int KGKEBLEKPKH;

	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private static Mutex LBENOKCNDOP;

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x4AF5A50", Offset = "0x4AF4250", VA = "0x184AF5A50")]
	public static void OFNKEJLJKOO(Texture2D KJEDKLNLOAH, int MGKLGEEIJIK, int CBKJBBCHDEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x4AF55A0", Offset = "0x4AF3DA0", VA = "0x184AF55A0")]
	private static void MNFAJAMKBFE(Texture2D KJEDKLNLOAH, int MGKLGEEIJIK, int CBKJBBCHDEJ, IIOEJAMMPOB EJLBOFLHLHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x4AF4EA0", Offset = "0x4AF36A0", VA = "0x184AF4EA0")]
	public static void LFOPLKCFLLD(object HDKLJDMDCGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x4AF5A70", Offset = "0x4AF4270", VA = "0x184AF5A70")]
	public static void PEGBDICCLKN(object HDKLJDMDCGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x4AF4BF0", Offset = "0x4AF33F0", VA = "0x184AF4BF0")]
	private static Color CACELGENOIF(int DNCFOPMJGLJ, int DEMCFCBJOPI, float OICOHEEKALK, float FIAFBOAGJBA)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x4AF53C0", Offset = "0x4AF3BC0", VA = "0x184AF53C0")]
	public static void LODGEMCNBHE(object HDKLJDMDCGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x4AF4DB0", Offset = "0x4AF35B0", VA = "0x184AF4DB0")]
	private static Color FKOOCFIJJOH(Color JEFKKOPAFMN, Color NKPBIJKMLME, float DOBKOKNNFGA)
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
