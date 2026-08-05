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
		[Cpp2IlInjected.Address(RVA = "0x60631C0", Offset = "0x6061DC0", VA = "0x1860631C0")]
		public CubeMapGenerator()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public enum DPBCBCFDBDM
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
public interface LLFFKCALCGK
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	DPBCBCFDBDM GILEFAAHGAH
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class HEDAMGIAMFE
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
			[Cpp2IlInjected.Address(RVA = "0x6065B60", Offset = "0x6064760", VA = "0x186065B60")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x6065B50", Offset = "0x6064750", VA = "0x186065B50")]
		public Resolution(uint IODEOJKDCNL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x698050", Offset = "0x696C50", VA = "0x180698050")]
		public Resolution(uint IODEOJKDCNL, uint FNMMGECGLAC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x6065A60", Offset = "0x6064660", VA = "0x186065A60")]
		public static Resolution EGGHHJJKNDH(Resolution[] PCNKMHOFIMD, Resolution IKECBPLJIDF, int LDGLIEGMBMI)
		{
			return default(Resolution);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public class ABHJKKPICJH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private readonly Resolution DKGDBMNGGAD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private Resolution? MIMNILBCKHN;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public uint IODEOJKDCNL
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x6062D10", Offset = "0x6061910", VA = "0x186062D10")]
			get
			{
				return default(uint);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public uint FNMMGECGLAC
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x6062B50", Offset = "0x6061750", VA = "0x186062B50")]
			get
			{
				return default(uint);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public Resolution OIHBHLEMEBM
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x6062D20", Offset = "0x6061920", VA = "0x186062D20")]
			get
			{
				return default(Resolution);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x1F8E050", Offset = "0x1F8CC50", VA = "0x181F8E050")]
		public ABHJKKPICJH(Resolution DKGDBMNGGAD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x6062B70", Offset = "0x6061770", VA = "0x186062B70")]
		private static Resolution EDIHAHKLEMD(Resolution MIMNILBCKHN, DPBCBCFDBDM JGNMKPEPGLF)
		{
			return default(Resolution);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public static class BJBGFFEPILD
	{
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public static readonly Resolution HCLFAAMKPCN;

		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public static readonly Resolution JJONJBNEDOO;

		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public static readonly Resolution OCIGAOMCAIE;

		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public static readonly Resolution LFHFEMJBHPJ;

		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public static readonly Resolution EMMAAOCMJED;

		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public static readonly Resolution DNPAGMJLKAJ;

		[Cpp2IlInjected.Token(Token = "0x4000014")]
		internal static readonly Resolution[] OHEKGKOBMNJ;
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public static class GMDJNPFFPME
	{
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public static readonly Resolution HDKJFPOIFMA;

		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public static readonly Resolution AGOLKNBEGGF;

		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public static readonly Resolution HIFLCCAKHGC;

		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public static readonly Resolution FLLDEDLJFEK;

		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public static readonly Resolution DOAFFJDPKEO;

		[Cpp2IlInjected.Token(Token = "0x400001A")]
		internal static readonly Resolution[] OHEKGKOBMNJ;

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x60631E0", Offset = "0x6061DE0", VA = "0x1860631E0")]
		public static Resolution DLJDHJMIAFD(uint BDBMIEBKIGN)
		{
			return default(Resolution);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public static readonly Resolution NGEAINKKKNI;

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x60635A0", Offset = "0x60621A0", VA = "0x1860635A0")]
	public static bool NFDHLGLCOMB(uint ACHKNJOLNKO)
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
		public enum KFLFBJNPGFN : byte
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
		private class HMJIBMGCEOI : IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			private string NLCIGFDKGEE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			public Texture2D IPMEFBALBHL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400002C")]
			public KFLFBJNPGFN OFJKLMIDFOH;

			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x6063840", Offset = "0x6062440", VA = "0x186063840")]
			public HMJIBMGCEOI(string NLCIGFDKGEE)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x67D750", Offset = "0x67C350", VA = "0x18067D750")]
			public HMJIBMGCEOI(string NLCIGFDKGEE, Texture2D EAGLNINCDHO, KFLFBJNPGFN FHNMKKONDPC)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x6063800", Offset = "0x6062400", VA = "0x186063800", Slot = "4")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000D")]
		[CompilerGenerated]
		private sealed class AOBEGDMINCN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400002D")]
			public ManagedTexture <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400002E")]
			public KFLFBJNPGFN textureMemory;

			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677730", VA = "0x180678B30")]
			public AOBEGDMINCN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x6062F00", Offset = "0x6061B00", VA = "0x186062F00")]
			internal void <GetManagedTexture>b__0()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000E")]
		[CompilerGenerated]
		private sealed class JJHHAIOOKJD
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400002F")]
			public int quality;

			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677730", VA = "0x180678B30")]
			public JJHHAIOOKJD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x6063920", Offset = "0x6062520", VA = "0x186063920")]
			internal byte[] <EncodeToJPG>b__0(Texture2D t2d)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000F")]
		[CompilerGenerated]
		private sealed class JDFNJGJDCIG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000030")]
			public RenderTexture tempRenderTexture;

			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677730", VA = "0x180678B30")]
			public JDFNJGJDCIG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x6063890", Offset = "0x6062490", VA = "0x186063890")]
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
		private global::CGDFFALNLAC<Texture2D> _cpuSidePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private HMJIBMGCEOI _memTexture;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private global::CGDFFALNLAC<byte[]> _jpgEncodePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private byte[] _jpgBytes;

		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public const int DEFAULT_JPG_QUALITY = 80;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private global::CGDFFALNLAC<byte[]> _pngEncodePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private byte[] _pngBytes;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public bool UsePalette
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x67B250", Offset = "0x679E50", VA = "0x18067B250")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public RenderTexture LastRenderTexture
		{
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x678120", Offset = "0x676D20", VA = "0x180678120")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x678130", Offset = "0x676D30", VA = "0x180678130")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		private HMJIBMGCEOI memoryTexture
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x60659C0", Offset = "0x60645C0", VA = "0x1860659C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x6065970", Offset = "0x6064570", VA = "0x186065970")]
		public ManagedTexture(string NLCIGFDKGEE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x6065910", Offset = "0x6064510", VA = "0x186065910")]
		public ManagedTexture(string NLCIGFDKGEE, bool HLHLOGDNHJP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x6065380", Offset = "0x6063F80", VA = "0x186065380")]
		public void NDLHHHFIPMN(RenderTexture FKMIGOOPCII)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x6064B10", Offset = "0x6063710", VA = "0x186064B10")]
		public global::CGDFFALNLAC<byte[]> ACDEDPNHFPJ(bool BJPHGCGMDOF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x6065620", Offset = "0x6064220", VA = "0x186065620")]
		public global::CGDFFALNLAC<Texture2D> PBLIAKCIEEB(KFLFBJNPGFN FHNMKKONDPC, bool BLAIOMMDBIO = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x60650C0", Offset = "0x6063CC0", VA = "0x1860650C0")]
		public global::CGDFFALNLAC<byte[]> FJBBMADJMAF(bool BLAIOMMDBIO = false, int FJJLLMJBFCA = 80)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x6065460", Offset = "0x6064060", VA = "0x186065460")]
		public global::CGDFFALNLAC<byte[]> OMMNIMNJEJF(bool BLAIOMMDBIO = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x6064B30", Offset = "0x6063730", VA = "0x186064B30")]
		private static global::CGDFFALNLAC<Texture2D> AIDEPOPOCBN(string NLCIGFDKGEE, RenderTexture FKMIGOOPCII, ref Texture2D BHCGAMLAEJL, bool BLAIOMMDBIO, KFLFBJNPGFN PFKOAOLPKPH = KFLFBJNPGFN.GPU)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x60652C0", Offset = "0x6063EC0", VA = "0x1860652C0")]
		public void LONCJCMFBOC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x60650B0", Offset = "0x6063CB0", VA = "0x1860650B0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x60653B0", Offset = "0x6063FB0", VA = "0x1860653B0")]
		[CompilerGenerated]
		private global::CGDFFALNLAC<byte[]> OFINJEDKFNA(Texture2D CEPMFNOGKKL)
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public static class MGHFOEMDCJP
{
	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x6064960", Offset = "0x6063560", VA = "0x186064960")]
	public static RenderTexture FNCMFHAJNDA(int BDBMIEBKIGN, int KDPLJDNGPBM, int EMDDAPNEEHK, Camera NBPOFMEGJJC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x60648F0", Offset = "0x60634F0", VA = "0x1860648F0")]
	public static void AKPNKPIENOD(RenderTexture FKMIGOOPCII)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class JOGLCPPPAHM
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public class CFFIILJINFF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public int HOKMFDPKLJA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public int OCMAALMMILB;

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x8DD2F0", Offset = "0x8DBEF0", VA = "0x1808DD2F0")]
		public CFFIILJINFF(int PJBFFCCCLKF, int AENGIJLJHJA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	private enum MEAFIHNDCBO
	{
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		Point,
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		Bilinear,
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		Average
	}

	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private static Color[] GPDNOEBMLHM;

	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private static Color[] FFEDKPOCEIM;

	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private static int AEPJHDKHAPL;

	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private static float EKDFJDEIIFE;

	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private static float ELBBFHKJNCJ;

	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private static int COGPCGJFEOG;

	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private static int JKFDMPBCOGA;

	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private static Mutex LHHKDFOGNAA;

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x60648D0", Offset = "0x60634D0", VA = "0x1860648D0")]
	public static void PDPIIJJNMEK(Texture2D GKNGPLPCHID, int KEMHLBCCAGL, int NHGMEBNMHGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x6063B10", Offset = "0x6062710", VA = "0x186063B10")]
	private static void EJMHLLGBPKF(Texture2D GKNGPLPCHID, int KEMHLBCCAGL, int NHGMEBNMHGE, MEAFIHNDCBO IBPPDEDMEKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x6064000", Offset = "0x6062C00", VA = "0x186064000")]
	public static void ELDDEMDOLPC(object KMFLGGMLFJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x6064700", Offset = "0x6063300", VA = "0x186064700")]
	public static void JJDKLMHGDFH(object KMFLGGMLFJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x6064480", Offset = "0x6063080", VA = "0x186064480")]
	private static Color HAOAEMADDHJ(int IODEOJKDCNL, int FNMMGECGLAC, float EKDFJDEIIFE, float ELBBFHKJNCJ)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x6063940", Offset = "0x6062540", VA = "0x186063940")]
	public static void EHMCFKAELAG(object KMFLGGMLFJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x6064620", Offset = "0x6063220", VA = "0x186064620")]
	private static Color IIPJDHECMCM(Color KIIAGFCGACP, Color GHMGLIIPJND, float GKFICKKHACC)
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
