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
		[Cpp2IlInjected.Address(RVA = "0x5827750", Offset = "0x5826750", VA = "0x185827750")]
		public CubeMapGenerator()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public enum KECELCGEOFD
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
public interface IKJGKNDIELD
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	KECELCGEOFD KKKALJDMAAB
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class PPDFAJPPGAE
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
			[Cpp2IlInjected.Address(RVA = "0x582A620", Offset = "0x5829620", VA = "0x18582A620")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x582A610", Offset = "0x5829610", VA = "0x18582A610")]
		public Resolution(uint JIOINDMBNBK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x76ED30", Offset = "0x76DD30", VA = "0x18076ED30")]
		public Resolution(uint JIOINDMBNBK, uint AOEDNBDEECB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x582A4C0", Offset = "0x58294C0", VA = "0x18582A4C0")]
		public static Resolution FOIFLJGIOBE(Resolution[] PEOPHIMPDAL, Resolution NEAGOBGENHA, int ALJDAJGJPJA)
		{
			return default(Resolution);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public class HDFEALMINOM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private readonly Resolution HPMKKMICIDA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private Resolution? LPKGBNJEHPC;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public uint JIOINDMBNBK
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x5827F90", Offset = "0x5826F90", VA = "0x185827F90")]
			get
			{
				return default(uint);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public uint AOEDNBDEECB
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x5827FA0", Offset = "0x5826FA0", VA = "0x185827FA0")]
			get
			{
				return default(uint);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public Resolution BIOKFNJMPPO
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x5827FC0", Offset = "0x5826FC0", VA = "0x185827FC0")]
			get
			{
				return default(Resolution);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x13A1130", Offset = "0x13A0130", VA = "0x1813A1130")]
		public HDFEALMINOM(Resolution HPMKKMICIDA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x5827DC0", Offset = "0x5826DC0", VA = "0x185827DC0")]
		private static Resolution IMBLAKAOINK(Resolution LPKGBNJEHPC, KECELCGEOFD OPMKCDPNGEE)
		{
			return default(Resolution);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public static class FEEIJHOGCDC
	{
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public static readonly Resolution HAKDKDGMMBO;

		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public static readonly Resolution MLBHMPBMJFE;

		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public static readonly Resolution OHGFPBAKFII;

		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public static readonly Resolution PBKJFJMKFMB;

		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public static readonly Resolution NHIOJEOCMBN;

		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public static readonly Resolution BPDKOBJAJKF;

		[Cpp2IlInjected.Token(Token = "0x4000014")]
		internal static readonly Resolution[] OJJMIKGPBFM;
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public static class EIILLBEIMHG
	{
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public static readonly Resolution OGPHGGNKKMN;

		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public static readonly Resolution FLJEGNIICDP;

		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public static readonly Resolution BMDHBFKLJFD;

		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public static readonly Resolution OLGDNKCJDDH;

		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public static readonly Resolution MCAEIFGJBLM;

		[Cpp2IlInjected.Token(Token = "0x400001A")]
		internal static readonly Resolution[] OJJMIKGPBFM;

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x5827770", Offset = "0x5826770", VA = "0x185827770")]
		public static Resolution BCEGMJJAOAP(uint GHGJDDLLLBP)
		{
			return default(Resolution);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public static readonly Resolution CLECMJEMOAO;

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x582A280", Offset = "0x5829280", VA = "0x18582A280")]
	public static bool NNIEPECCOOI(uint OGPJEBFEDED)
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
		public enum NLNGMEFIIFC : byte
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
		private class MEIGHEINBNK : IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			private string MBHNCPMPIFB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			public Texture2D CGDEODHBCDI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400002C")]
			public NLNGMEFIIFC JOGNLCLOLBO;

			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x5828220", Offset = "0x5827220", VA = "0x185828220")]
			public MEIGHEINBNK(string MBHNCPMPIFB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x938160", Offset = "0x937160", VA = "0x180938160")]
			public MEIGHEINBNK(string MBHNCPMPIFB, Texture2D CAFFMJCBFPE, NLNGMEFIIFC NDCDNJLCJJL)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x58281E0", Offset = "0x58271E0", VA = "0x1858281E0", Slot = "4")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000D")]
		[CompilerGenerated]
		private sealed class GJLMFIPBMAI
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400002D")]
			public ManagedTexture <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400002E")]
			public NLNGMEFIIFC textureMemory;

			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x5E7AB0", Offset = "0x5E6AB0", VA = "0x1805E7AB0")]
			public GJLMFIPBMAI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x5827D80", Offset = "0x5826D80", VA = "0x185827D80")]
			internal void <GetManagedTexture>b__0()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000E")]
		[CompilerGenerated]
		private sealed class KCHOMMKOPFC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400002F")]
			public int quality;

			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x5E7AB0", Offset = "0x5E6AB0", VA = "0x1805E7AB0")]
			public KCHOMMKOPFC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x58281C0", Offset = "0x58271C0", VA = "0x1858281C0")]
			internal byte[] <EncodeToJPG>b__0(Texture2D t2d)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000F")]
		[CompilerGenerated]
		private sealed class AIDPOMJNMBI
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000030")]
			public RenderTexture tempRenderTexture;

			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x5E7AB0", Offset = "0x5E6AB0", VA = "0x1805E7AB0")]
			public AIDPOMJNMBI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x58276C0", Offset = "0x58266C0", VA = "0x1858276C0")]
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
		private global::LBHHDEJJNHM<Texture2D> _cpuSidePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private MEIGHEINBNK _memTexture;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private global::LBHHDEJJNHM<byte[]> _jpgEncodePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private byte[] _jpgBytes;

		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public const int DEFAULT_JPG_QUALITY = 80;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private global::LBHHDEJJNHM<byte[]> _pngEncodePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private byte[] _pngBytes;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public bool UsePalette
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x6107B0", Offset = "0x60F7B0", VA = "0x1806107B0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public RenderTexture LastRenderTexture
		{
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x5E7DF0", Offset = "0x5E6DF0", VA = "0x1805E7DF0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x60FD70", Offset = "0x60ED70", VA = "0x18060FD70")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		private MEIGHEINBNK memoryTexture
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x5829180", Offset = "0x5828180", VA = "0x185829180")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x58290D0", Offset = "0x58280D0", VA = "0x1858290D0")]
		public ManagedTexture(string MBHNCPMPIFB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x5829120", Offset = "0x5828120", VA = "0x185829120")]
		public ManagedTexture(string MBHNCPMPIFB, bool CNADLKFBFFL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x5828BB0", Offset = "0x5827BB0", VA = "0x185828BB0")]
		public void LMEFHEPPKGL(RenderTexture HGMOOJHNDLL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x5828860", Offset = "0x5827860", VA = "0x185828860")]
		public global::LBHHDEJJNHM<byte[]> JCAODEIDPAL(bool NJAHJDNAGHG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x5828920", Offset = "0x5827920", VA = "0x185828920")]
		public global::LBHHDEJJNHM<Texture2D> KFKHDGLANKH(NLNGMEFIIFC NDCDNJLCJJL, bool MPHEGMALMBB = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x5828520", Offset = "0x5827520", VA = "0x185828520")]
		public global::LBHHDEJJNHM<byte[]> ECDDDCBEEMD(bool MPHEGMALMBB = false, int NKOFGGDGFBK = 80)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x58286D0", Offset = "0x58276D0", VA = "0x1858286D0")]
		public global::LBHHDEJJNHM<byte[]> GEHLIKPDBEB(bool MPHEGMALMBB = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x5828BE0", Offset = "0x5827BE0", VA = "0x185828BE0")]
		private static global::LBHHDEJJNHM<Texture2D> PKBLFBNNPFP(string MBHNCPMPIFB, RenderTexture HGMOOJHNDLL, ref Texture2D BBILMFCGNMP, bool MPHEGMALMBB, NLNGMEFIIFC HJGAAKALDLB = NLNGMEFIIFC.GPU)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x5828450", Offset = "0x5827450", VA = "0x185828450")]
		public void CIJIOMOBIEO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x5828510", Offset = "0x5827510", VA = "0x185828510", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x5828880", Offset = "0x5827880", VA = "0x185828880")]
		[CompilerGenerated]
		private global::LBHHDEJJNHM<byte[]> JJHBEHJPIJE(Texture2D NJEFAJIMHNF)
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public static class MILHEEBKMMB
{
	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x58282E0", Offset = "0x58272E0", VA = "0x1858282E0")]
	public static RenderTexture NPFGLPJPOGN(int GHGJDDLLLBP, int EKAJBPONJJD, int OAHGKINJMDG, Camera JPJGLKLNOBM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x5828270", Offset = "0x5827270", VA = "0x185828270")]
	public static void LICGLELEDCP(RenderTexture HGMOOJHNDLL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class NNNGCOMNHLO
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public class JGHDBBEJBDD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public int HNIIDPMJKFI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public int MOCOMOOJDJI;

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x67E350", Offset = "0x67D350", VA = "0x18067E350")]
		public JGHDBBEJBDD(int MHLMNJMBPPH, int MKAEFGDNMHM)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	private enum MFLHFEEIFCN
	{
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		Point,
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		Bilinear,
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		Average
	}

	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private static Color[] EIJPIKGKLKN;

	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private static Color[] IEDEJJELKGI;

	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private static int AMGKGKNGBFO;

	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private static float DLJAGOHEHHI;

	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private static float AGBENHOIFEE;

	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private static int KIPEOEAHOGH;

	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private static int NBAGPAINLPG;

	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private static Mutex OEBGOKNJDKN;

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x58294D0", Offset = "0x58284D0", VA = "0x1858294D0")]
	public static void EPOMEHLKICE(Texture2D CDKFBFMHKKP, int BKFEFNHNGPJ, int BNIDANEHDLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x58294F0", Offset = "0x58284F0", VA = "0x1858294F0")]
	private static void GFLOCBNHKLK(Texture2D CDKFBFMHKKP, int BKFEFNHNGPJ, int BNIDANEHDLP, MFLHFEEIFCN KKLMGGNHHPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x58299A0", Offset = "0x58289A0", VA = "0x1858299A0")]
	public static void JBALJFODIPO(object MDAEAKFNGDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x5829EC0", Offset = "0x5828EC0", VA = "0x185829EC0")]
	public static void KLDBBMMBJBG(object MDAEAKFNGDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x5829220", Offset = "0x5828220", VA = "0x185829220")]
	private static Color DMDDGNGAOOB(int JIOINDMBNBK, int AOEDNBDEECB, float DLJAGOHEHHI, float AGBENHOIFEE)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x582A0A0", Offset = "0x58290A0", VA = "0x18582A0A0")]
	public static void MFMLCDILLPA(object MDAEAKFNGDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x58293E0", Offset = "0x58283E0", VA = "0x1858293E0")]
	private static Color EIOOMDJMKKB(Color JNJHAIDBMPL, Color NGMKGMLIPAC, float JNLOLNFALGF)
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
