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
		[Cpp2IlInjected.Address(RVA = "0x51DE1F0", Offset = "0x51DD1F0", VA = "0x1851DE1F0")]
		public CubeMapGenerator()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public enum EIHMAADEKJI
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
public interface MAEFFEFBFNP
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	EIHMAADEKJI FLCGCPCGFHH
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class OHENNPIEOEJ
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
			[Cpp2IlInjected.Address(RVA = "0x51E10C0", Offset = "0x51E00C0", VA = "0x1851E10C0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x51E10B0", Offset = "0x51E00B0", VA = "0x1851E10B0")]
		public Resolution(uint BIBNBCIJJEK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x716A30", Offset = "0x715A30", VA = "0x180716A30")]
		public Resolution(uint BIBNBCIJJEK, uint AIHGENMJNEC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x51E0F60", Offset = "0x51DFF60", VA = "0x1851E0F60")]
		public static Resolution EHMGHKFHBDB(Resolution[] DMCHPKBMHBM, Resolution MMEADPKHNEI, int OMFABMNEOJJ)
		{
			return default(Resolution);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public class GOGFPMCGJPE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private readonly Resolution GGGCFMDHBPM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private Resolution? GJIFOBKMBJM;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public uint BIBNBCIJJEK
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x51DE6A0", Offset = "0x51DD6A0", VA = "0x1851DE6A0")]
			get
			{
				return default(uint);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public uint AIHGENMJNEC
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x51DE480", Offset = "0x51DD480", VA = "0x1851DE480")]
			get
			{
				return default(uint);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public Resolution JALBAFLMIDD
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x51DE4A0", Offset = "0x51DD4A0", VA = "0x1851DE4A0")]
			get
			{
				return default(Resolution);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x1630ED0", Offset = "0x162FED0", VA = "0x181630ED0")]
		public GOGFPMCGJPE(Resolution GGGCFMDHBPM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x51DE6B0", Offset = "0x51DD6B0", VA = "0x1851DE6B0")]
		private static Resolution LFADMBKHEDC(Resolution GJIFOBKMBJM, EIHMAADEKJI BIPFNFPNJHI)
		{
			return default(Resolution);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public static class GKGLLDEJICH
	{
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public static readonly Resolution DAJIOABDNNB;

		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public static readonly Resolution BKHMKJNEAMJ;

		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public static readonly Resolution JJLPEJIAJGP;

		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public static readonly Resolution HCADGEFIHOP;

		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public static readonly Resolution DCMPKKDFECG;

		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public static readonly Resolution EPNCPAKBBMF;

		[Cpp2IlInjected.Token(Token = "0x4000014")]
		internal static readonly Resolution[] HFPIPEFDCKI;
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public static class NKPJGCIBKMB
	{
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public static readonly Resolution HEBGNPCLFPM;

		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public static readonly Resolution PLPCAKEKJFJ;

		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public static readonly Resolution BHFDEOCHNMK;

		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public static readonly Resolution GPDFJIFDBIL;

		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public static readonly Resolution CMEMGAAAHCN;

		[Cpp2IlInjected.Token(Token = "0x400001A")]
		internal static readonly Resolution[] HFPIPEFDCKI;

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x51E08F0", Offset = "0x51DF8F0", VA = "0x1851E08F0")]
		public static Resolution EIGNAJHOHHO(uint PONIFNELPFK)
		{
			return default(Resolution);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public static readonly Resolution IPFLHINCBIH;

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x51E0D20", Offset = "0x51DFD20", VA = "0x1851E0D20")]
	public static bool EGANPPCLAJF(uint KJDHKGFKPCI)
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
		public enum APCBKEJAJDE : byte
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
		private class NMJPCPNAEDN : IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			private string IPJBPCNNBIO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			public Texture2D MKEJCFHFAFE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400002C")]
			public APCBKEJAJDE PFPPGFNGCJC;

			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x51E0CD0", Offset = "0x51DFCD0", VA = "0x1851E0CD0")]
			public NMJPCPNAEDN(string IPJBPCNNBIO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x8DFE60", Offset = "0x8DEE60", VA = "0x1808DFE60")]
			public NMJPCPNAEDN(string IPJBPCNNBIO, Texture2D IBCFGLJLEIM, APCBKEJAJDE CLCHBIPANII)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x51E0C90", Offset = "0x51DFC90", VA = "0x1851E0C90", Slot = "4")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000D")]
		[CompilerGenerated]
		private sealed class LPAIFBGGLIN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400002D")]
			public ManagedTexture <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400002E")]
			public APCBKEJAJDE textureMemory;

			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x58FAB0", Offset = "0x58EAB0", VA = "0x18058FAB0")]
			public LPAIFBGGLIN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x51DFAE0", Offset = "0x51DEAE0", VA = "0x1851DFAE0")]
			internal void <GetManagedTexture>b__0()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000E")]
		[CompilerGenerated]
		private sealed class GOJKJHBGLEA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400002F")]
			public int quality;

			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x58FAB0", Offset = "0x58EAB0", VA = "0x18058FAB0")]
			public GOJKJHBGLEA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x51DE880", Offset = "0x51DD880", VA = "0x1851DE880")]
			internal byte[] <EncodeToJPG>b__0(Texture2D t2d)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000F")]
		[CompilerGenerated]
		private sealed class BCIOKNFLHDI
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000030")]
			public RenderTexture tempRenderTexture;

			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x58FAB0", Offset = "0x58EAB0", VA = "0x18058FAB0")]
			public BCIOKNFLHDI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x51DE160", Offset = "0x51DD160", VA = "0x1851DE160")]
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
		private global::BDGKEGGAANF<Texture2D> _cpuSidePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private NMJPCPNAEDN _memTexture;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private global::BDGKEGGAANF<byte[]> _jpgEncodePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private byte[] _jpgBytes;

		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public const int DEFAULT_JPG_QUALITY = 80;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private global::BDGKEGGAANF<byte[]> _pngEncodePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private byte[] _pngBytes;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public bool UsePalette
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x5B87B0", Offset = "0x5B77B0", VA = "0x1805B87B0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public RenderTexture LastRenderTexture
		{
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x58FDF0", Offset = "0x58EDF0", VA = "0x18058FDF0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x5B7D70", Offset = "0x5B6D70", VA = "0x1805B7D70")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		private NMJPCPNAEDN memoryTexture
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x51E0850", Offset = "0x51DF850", VA = "0x1851E0850")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x51E07A0", Offset = "0x51DF7A0", VA = "0x1851E07A0")]
		public ManagedTexture(string IPJBPCNNBIO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x51E07F0", Offset = "0x51DF7F0", VA = "0x1851E07F0")]
		public ManagedTexture(string IPJBPCNNBIO, bool HMJIFJDDBDL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x51E06D0", Offset = "0x51DF6D0", VA = "0x1851E06D0")]
		public void LPOMDCJAODP(RenderTexture GNIPLECAJFH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x51E06B0", Offset = "0x51DF6B0", VA = "0x1851E06B0")]
		public global::BDGKEGGAANF<byte[]> KIOBOJEHMDK(bool GNDPCFKNFEI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x51E0420", Offset = "0x51DF420", VA = "0x1851E0420")]
		public global::BDGKEGGAANF<Texture2D> IMAHBAJPDEE(APCBKEJAJDE CLCHBIPANII, bool JJEFDOLLCLJ = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x51E01B0", Offset = "0x51DF1B0", VA = "0x1851E01B0")]
		public global::BDGKEGGAANF<byte[]> EMIPKJFPBMG(bool JJEFDOLLCLJ = false, int KKHCJLOHCKO = 80)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x51DFB20", Offset = "0x51DEB20", VA = "0x1851DFB20")]
		public global::BDGKEGGAANF<byte[]> BMHFKELPECD(bool JJEFDOLLCLJ = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x51DFCC0", Offset = "0x51DECC0", VA = "0x1851DFCC0")]
		private static global::BDGKEGGAANF<Texture2D> EENLDLCPEBI(string IPJBPCNNBIO, RenderTexture GNIPLECAJFH, ref Texture2D AFMDFIMEBPM, bool JJEFDOLLCLJ, APCBKEJAJDE NDKOEPDFAAM = APCBKEJAJDE.GPU)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x51E0360", Offset = "0x51DF360", VA = "0x1851E0360")]
		public void GNHEEPEAKHN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x51DFCB0", Offset = "0x51DECB0", VA = "0x1851DFCB0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x51E0700", Offset = "0x51DF700", VA = "0x1851E0700")]
		[CompilerGenerated]
		private global::BDGKEGGAANF<byte[]> ONKLNBCHPGF(Texture2D IDGIFEIBICA)
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public static class JEKGLJGPMBB
{
	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x51DF970", Offset = "0x51DE970", VA = "0x1851DF970")]
	public static RenderTexture OIAMHEICHPE(int PONIFNELPFK, int GIGPIDHIFMI, int HJCLNPMNHLH, Camera LLJBKEDJDOO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x51DF900", Offset = "0x51DE900", VA = "0x1851DF900")]
	public static void JNMCABBLEAE(RenderTexture GNIPLECAJFH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class JAAOOOJCNAC
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public class OIEMMJOLMNH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public int DBHBFIKBLHB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public int OENKNOGFNFA;

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x626350", Offset = "0x625350", VA = "0x180626350")]
		public OIEMMJOLMNH(int BEAIDOMOPNK, int MMICFFPKPAJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	private enum GBDGEDEPIIJ
	{
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		Point,
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		Bilinear,
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		Average
	}

	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private static Color[] GLKJJEPIGJF;

	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private static Color[] GGONLKJDDMB;

	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private static int OBDHDNFKOBC;

	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private static float KDPNEDFAJMM;

	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private static float JIBBGBKKPPH;

	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private static int OHEHOKCFGNE;

	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private static int IKHLMJOHPBO;

	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private static Mutex GBBAIFJBJLJ;

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x51DEDC0", Offset = "0x51DDDC0", VA = "0x1851DEDC0")]
	public static void ILMCHDOBGDG(Texture2D LBODAJKJECA, int NBDAEHGBHPH, int NAIJJCDPBNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x51DEFA0", Offset = "0x51DDFA0", VA = "0x1851DEFA0")]
	private static void KOBKAFJIHDP(Texture2D LBODAJKJECA, int NBDAEHGBHPH, int NAIJJCDPBNA, GBDGEDEPIIJ EBDPCEJLBBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x51DE8A0", Offset = "0x51DD8A0", VA = "0x1851DE8A0")]
	public static void HGNLLMIFLKG(object NHBCHHMAJOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x51DF630", Offset = "0x51DE630", VA = "0x1851DF630")]
	public static void OKNPPMHADEI(object NHBCHHMAJOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x51DEDE0", Offset = "0x51DDDE0", VA = "0x1851DEDE0")]
	private static Color KNPIBEACDPO(int BIBNBCIJJEK, int AIHGENMJNEC, float KDPNEDFAJMM, float JIBBGBKKPPH)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x51DF450", Offset = "0x51DE450", VA = "0x1851DF450")]
	public static void LPAFBHPMDNE(object NHBCHHMAJOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x51DF810", Offset = "0x51DE810", VA = "0x1851DF810")]
	private static Color PFAKAFEDNNJ(Color DIDAJJKNFBL, Color JGBADMFNJFG, float GGAFBKIEDPG)
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
