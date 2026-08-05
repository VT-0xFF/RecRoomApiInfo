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
		[Cpp2IlInjected.Address(RVA = "0x5E96240", Offset = "0x5E95040", VA = "0x185E96240")]
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
			[Cpp2IlInjected.Address(RVA = "0x5E98BE0", Offset = "0x5E979E0", VA = "0x185E98BE0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x5E98BD0", Offset = "0x5E979D0", VA = "0x185E98BD0")]
		public Resolution(uint IODEOJKDCNL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x6BD570", Offset = "0x6BC370", VA = "0x1806BD570")]
		public Resolution(uint IODEOJKDCNL, uint FNMMGECGLAC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x5E98AE0", Offset = "0x5E978E0", VA = "0x185E98AE0")]
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
			[Cpp2IlInjected.Address(RVA = "0x5E95D90", Offset = "0x5E94B90", VA = "0x185E95D90")]
			get
			{
				return default(uint);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public uint FNMMGECGLAC
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x5E95BD0", Offset = "0x5E949D0", VA = "0x185E95BD0")]
			get
			{
				return default(uint);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public Resolution OIHBHLEMEBM
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x5E95DA0", Offset = "0x5E94BA0", VA = "0x185E95DA0")]
			get
			{
				return default(Resolution);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x13645B0", Offset = "0x13633B0", VA = "0x1813645B0")]
		public ABHJKKPICJH(Resolution DKGDBMNGGAD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x5E95BF0", Offset = "0x5E949F0", VA = "0x185E95BF0")]
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
		[Cpp2IlInjected.Address(RVA = "0x5E96260", Offset = "0x5E95060", VA = "0x185E96260")]
		public static Resolution DLJDHJMIAFD(uint BDBMIEBKIGN)
		{
			return default(Resolution);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public static readonly Resolution NGEAINKKKNI;

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x5E96620", Offset = "0x5E95420", VA = "0x185E96620")]
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
			[Cpp2IlInjected.Address(RVA = "0x5E968C0", Offset = "0x5E956C0", VA = "0x185E968C0")]
			public HMJIBMGCEOI(string NLCIGFDKGEE)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x6F4430", Offset = "0x6F3230", VA = "0x1806F4430")]
			public HMJIBMGCEOI(string NLCIGFDKGEE, Texture2D EAGLNINCDHO, KFLFBJNPGFN FHNMKKONDPC)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x5E96880", Offset = "0x5E95680", VA = "0x185E96880", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x66D7A0", Offset = "0x66C5A0", VA = "0x18066D7A0")]
			public AOBEGDMINCN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x5E95F80", Offset = "0x5E94D80", VA = "0x185E95F80")]
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
			[Cpp2IlInjected.Address(RVA = "0x66D7A0", Offset = "0x66C5A0", VA = "0x18066D7A0")]
			public JJHHAIOOKJD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x5E969A0", Offset = "0x5E957A0", VA = "0x185E969A0")]
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
			[Cpp2IlInjected.Address(RVA = "0x66D7A0", Offset = "0x66C5A0", VA = "0x18066D7A0")]
			public JDFNJGJDCIG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x5E96910", Offset = "0x5E95710", VA = "0x185E96910")]
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
			[Cpp2IlInjected.Address(RVA = "0x6CC600", Offset = "0x6CB400", VA = "0x1806CC600")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public RenderTexture LastRenderTexture
		{
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x6529E0", Offset = "0x6517E0", VA = "0x1806529E0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x674BA0", Offset = "0x6739A0", VA = "0x180674BA0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		private HMJIBMGCEOI memoryTexture
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x5E98A40", Offset = "0x5E97840", VA = "0x185E98A40")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x5E989F0", Offset = "0x5E977F0", VA = "0x185E989F0")]
		public ManagedTexture(string NLCIGFDKGEE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x5E98990", Offset = "0x5E97790", VA = "0x185E98990")]
		public ManagedTexture(string NLCIGFDKGEE, bool HLHLOGDNHJP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x5E98400", Offset = "0x5E97200", VA = "0x185E98400")]
		public void NDLHHHFIPMN(RenderTexture FKMIGOOPCII)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x5E97B90", Offset = "0x5E96990", VA = "0x185E97B90")]
		public global::CGDFFALNLAC<byte[]> ACDEDPNHFPJ(bool BJPHGCGMDOF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x5E986A0", Offset = "0x5E974A0", VA = "0x185E986A0")]
		public global::CGDFFALNLAC<Texture2D> PBLIAKCIEEB(KFLFBJNPGFN FHNMKKONDPC, bool BLAIOMMDBIO = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x5E98140", Offset = "0x5E96F40", VA = "0x185E98140")]
		public global::CGDFFALNLAC<byte[]> FJBBMADJMAF(bool BLAIOMMDBIO = false, int FJJLLMJBFCA = 80)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x5E984E0", Offset = "0x5E972E0", VA = "0x185E984E0")]
		public global::CGDFFALNLAC<byte[]> OMMNIMNJEJF(bool BLAIOMMDBIO = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x5E97BB0", Offset = "0x5E969B0", VA = "0x185E97BB0")]
		private static global::CGDFFALNLAC<Texture2D> AIDEPOPOCBN(string NLCIGFDKGEE, RenderTexture FKMIGOOPCII, ref Texture2D BHCGAMLAEJL, bool BLAIOMMDBIO, KFLFBJNPGFN PFKOAOLPKPH = KFLFBJNPGFN.GPU)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x5E98340", Offset = "0x5E97140", VA = "0x185E98340")]
		public void LONCJCMFBOC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x5E98130", Offset = "0x5E96F30", VA = "0x185E98130", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x5E98430", Offset = "0x5E97230", VA = "0x185E98430")]
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
	[Cpp2IlInjected.Address(RVA = "0x5E979E0", Offset = "0x5E967E0", VA = "0x185E979E0")]
	public static RenderTexture FNCMFHAJNDA(int BDBMIEBKIGN, int KDPLJDNGPBM, int EMDDAPNEEHK, Camera NBPOFMEGJJC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x5E97970", Offset = "0x5E96770", VA = "0x185E97970")]
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
		[Cpp2IlInjected.Address(RVA = "0xB7FAE0", Offset = "0xB7E8E0", VA = "0x180B7FAE0")]
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
	[Cpp2IlInjected.Address(RVA = "0x5E97950", Offset = "0x5E96750", VA = "0x185E97950")]
	public static void PDPIIJJNMEK(Texture2D GKNGPLPCHID, int KEMHLBCCAGL, int NHGMEBNMHGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x5E96B90", Offset = "0x5E95990", VA = "0x185E96B90")]
	private static void EJMHLLGBPKF(Texture2D GKNGPLPCHID, int KEMHLBCCAGL, int NHGMEBNMHGE, MEAFIHNDCBO IBPPDEDMEKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x5E97080", Offset = "0x5E95E80", VA = "0x185E97080")]
	public static void ELDDEMDOLPC(object KMFLGGMLFJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x5E97780", Offset = "0x5E96580", VA = "0x185E97780")]
	public static void JJDKLMHGDFH(object KMFLGGMLFJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x5E97500", Offset = "0x5E96300", VA = "0x185E97500")]
	private static Color HAOAEMADDHJ(int IODEOJKDCNL, int FNMMGECGLAC, float EKDFJDEIIFE, float ELBBFHKJNCJ)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x5E969C0", Offset = "0x5E957C0", VA = "0x185E969C0")]
	public static void EHMCFKAELAG(object KMFLGGMLFJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x5E976A0", Offset = "0x5E964A0", VA = "0x185E976A0")]
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
