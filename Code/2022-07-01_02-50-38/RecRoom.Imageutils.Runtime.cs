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
		[Cpp2IlInjected.Address(RVA = "0x1214140", Offset = "0x1212940", VA = "0x181214140")]
		public CubeMapGenerator()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public enum NDDMBODCGCJ
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
public interface LHMNCADNLHK
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	NDDMBODCGCJ BGFJMJJAPFN
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class BGLPFKKPAHN
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
			[Cpp2IlInjected.Address(RVA = "0x1216DD0", Offset = "0x12155D0", VA = "0x181216DD0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x1216DC0", Offset = "0x12155C0", VA = "0x181216DC0")]
		public Resolution(uint FNGOAMCGAPH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x6E3FB0", Offset = "0x6E27B0", VA = "0x1806E3FB0")]
		public Resolution(uint FNGOAMCGAPH, uint HDKMFDOPGKJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x1216C70", Offset = "0x1215470", VA = "0x181216C70")]
		public static Resolution GBPEKEBEDAD(Resolution[] FHCGCHMFBNG, Resolution CCPIKGILBMI, int NCFICEHNPBC)
		{
			return default(Resolution);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public class HKAIABLMFEK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private readonly Resolution GHNEPPJIAPK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private Resolution? KKEGKFMLHGK;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public uint FNGOAMCGAPH
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x1214A50", Offset = "0x1213250", VA = "0x181214A50")]
			get
			{
				return default(uint);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public uint HDKMFDOPGKJ
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x1214A60", Offset = "0x1213260", VA = "0x181214A60")]
			get
			{
				return default(uint);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public Resolution AKNPMKPDEOG
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x1214680", Offset = "0x1212E80", VA = "0x181214680")]
			get
			{
				return default(Resolution);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0xFCD700", Offset = "0xFCBF00", VA = "0x180FCD700")]
		public HKAIABLMFEK(Resolution GHNEPPJIAPK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x1214880", Offset = "0x1213080", VA = "0x181214880")]
		private static Resolution FMMJPNMACEJ(Resolution KKEGKFMLHGK, NDDMBODCGCJ GGLDFIHLMBD)
		{
			return default(Resolution);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public static class DJNCMKEIJEP
	{
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public static readonly Resolution IKAEJDPBIPA;

		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public static readonly Resolution AGGFENBMGFA;

		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public static readonly Resolution FICFBNBOGPF;

		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public static readonly Resolution IAPFLBOAPJD;

		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public static readonly Resolution NFMDDAPHNFI;

		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public static readonly Resolution KFBGIIFOKKM;

		[Cpp2IlInjected.Token(Token = "0x4000014")]
		internal static readonly Resolution[] GEGACIOLMFN;
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public static class PPFHEKFMPAM
	{
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public static readonly Resolution KNCLNCNBACO;

		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public static readonly Resolution GNKJICMEFNP;

		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public static readonly Resolution ALKMPODFDMK;

		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public static readonly Resolution IMPLJFOIDCG;

		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public static readonly Resolution KKHHIBDGIFB;

		[Cpp2IlInjected.Token(Token = "0x400001A")]
		internal static readonly Resolution[] GEGACIOLMFN;

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x12168D0", Offset = "0x12150D0", VA = "0x1812168D0")]
		public static Resolution IKNHOIDANOK(uint CNIBEDGIPIB)
		{
			return default(Resolution);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public static readonly Resolution NJJMLLAHHHD;

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x1213F00", Offset = "0x1212700", VA = "0x181213F00")]
	public static bool JDGPDAAGBFK(uint JBEBDLBFDLD)
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
		public enum HPNDDAGPADF : byte
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
		private class AKGJBKOKCPP : IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			private string CGCECGHBEEN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			public Texture2D IHJDINGJPBJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400002C")]
			public HPNDDAGPADF JPPBAHBGHIO;

			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x1213EB0", Offset = "0x12126B0", VA = "0x181213EB0")]
			public AKGJBKOKCPP(string CGCECGHBEEN)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x1213E50", Offset = "0x1212650", VA = "0x181213E50")]
			public AKGJBKOKCPP(string CGCECGHBEEN, Texture2D JMIDDGKFKDG, HPNDDAGPADF IHOOJDMCGOJ)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x1213E10", Offset = "0x1212610", VA = "0x181213E10", Slot = "4")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000D")]
		[CompilerGenerated]
		private sealed class DLLADMFIBHP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400002D")]
			public ManagedTexture <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400002E")]
			public HPNDDAGPADF textureMemory;

			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578040", VA = "0x180579840")]
			public DLLADMFIBHP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x1214460", Offset = "0x1212C60", VA = "0x181214460")]
			internal void <GetManagedTexture>b__0()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000E")]
		[CompilerGenerated]
		private sealed class IPJIBOPKNBH
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400002F")]
			public int quality;

			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578040", VA = "0x180579840")]
			public IPJIBOPKNBH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x1214A80", Offset = "0x1213280", VA = "0x181214A80")]
			internal byte[] <EncodeToJPG>b__0(Texture2D t2d)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000F")]
		[CompilerGenerated]
		private sealed class DJHPCEBMMEP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000030")]
			public RenderTexture tempRenderTexture;

			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578040", VA = "0x180579840")]
			public DJHPCEBMMEP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x1214160", Offset = "0x1212960", VA = "0x181214160")]
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
		private global::MJKMFAPMHBB<Texture2D> _cpuSidePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private AKGJBKOKCPP _memTexture;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private global::MJKMFAPMHBB<byte[]> _jpgEncodePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private byte[] _jpgBytes;

		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public const int DEFAULT_JPG_QUALITY = 80;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private global::MJKMFAPMHBB<byte[]> _pngEncodePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private byte[] _pngBytes;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public bool UsePalette
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x577160", Offset = "0x575960", VA = "0x180577160")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public RenderTexture LastRenderTexture
		{
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x574E70", Offset = "0x573670", VA = "0x180574E70")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x576710", Offset = "0x574F10", VA = "0x180576710")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		private AKGJBKOKCPP memoryTexture
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x1216830", Offset = "0x1215030", VA = "0x181216830")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x1216780", Offset = "0x1214F80", VA = "0x181216780")]
		public ManagedTexture(string CGCECGHBEEN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x12167D0", Offset = "0x1214FD0", VA = "0x1812167D0")]
		public ManagedTexture(string CGCECGHBEEN, bool BGMLNLIHPME)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x1215BA0", Offset = "0x12143A0", VA = "0x181215BA0")]
		public void DIBHEGFDAIE(RenderTexture KBGEANELAPL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x12166A0", Offset = "0x1214EA0", VA = "0x1812166A0")]
		public global::MJKMFAPMHBB<byte[]> OCINMKKBOOC(bool ABMGLJLEAMD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x1215F20", Offset = "0x1214720", VA = "0x181215F20")]
		public global::MJKMFAPMHBB<Texture2D> HHFAOAFAEEE(HPNDDAGPADF IHOOJDMCGOJ, bool JDBHHDMJLII = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x1215D70", Offset = "0x1214570", VA = "0x181215D70")]
		public global::MJKMFAPMHBB<byte[]> GCCEHCCDFBG(bool JDBHHDMJLII = false, int NEMKIGHDJOH = 80)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x1215BE0", Offset = "0x12143E0", VA = "0x181215BE0")]
		public global::MJKMFAPMHBB<byte[]> GAJKOBHBEJE(bool JDBHHDMJLII = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x12161B0", Offset = "0x12149B0", VA = "0x1812161B0")]
		private static global::MJKMFAPMHBB<Texture2D> HNAPFGJKLLF(string CGCECGHBEEN, RenderTexture KBGEANELAPL, ref Texture2D MMGGMFHDFNL, bool JDBHHDMJLII, HPNDDAGPADF CBENAABKPCF = HPNDDAGPADF.GPU)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x12166C0", Offset = "0x1214EC0", VA = "0x1812166C0")]
		public void OJPEEONFPAE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x1215BD0", Offset = "0x12143D0", VA = "0x181215BD0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x1215B00", Offset = "0x1214300", VA = "0x181215B00")]
		[CompilerGenerated]
		private global::MJKMFAPMHBB<byte[]> CLCKCJJMLDK(Texture2D NGCGMGPDJMC)
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public static class ELPDMJKAOLJ
{
	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x1214510", Offset = "0x1212D10", VA = "0x181214510")]
	public static RenderTexture NBIMMPKIIBO(int CNIBEDGIPIB, int JMJIBONNFGD, int GFBINNEGMEM, Camera EKDHLFBGPNM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x12144A0", Offset = "0x1212CA0", VA = "0x1812144A0")]
	public static void FLJELAIFCMO(RenderTexture KBGEANELAPL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class JJJDAMLOJKG
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public class DBIILCCFAHM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public int EDGNDOFMPJJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public int KLPHHCIKKJA;

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x5DE780", Offset = "0x5DCF80", VA = "0x1805DE780")]
		public DBIILCCFAHM(int MOFEGIBBJBK, int AEAEPNFFAPK)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	private enum OPLDEEDPDHL
	{
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		Point,
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		Bilinear,
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		Average
	}

	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private static Color[] EGEDEOOKNPL;

	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private static Color[] CGNPEGCOBED;

	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private static int JOBBLOMPKMF;

	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private static float OOBEFKALOAK;

	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private static float AGOBAKOCCDL;

	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private static int MMPPJOBFECM;

	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private static int HFCDKBAMJOL;

	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private static Mutex NJHMMILCKPK;

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x1215AE0", Offset = "0x12142E0", VA = "0x181215AE0")]
	public static void OGNPLOAKMHD(Texture2D GGAIBDMJEGP, int CBKGOPEFOHM, int NGFCNIJCGLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x1214E60", Offset = "0x1213660", VA = "0x181214E60")]
	private static void HCGIHIPJKNO(Texture2D GGAIBDMJEGP, int CBKGOPEFOHM, int NGFCNIJCGLN, OPLDEEDPDHL IBHLPLDNCBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x1215310", Offset = "0x1213B10", VA = "0x181215310")]
	public static void HDMBFMOCKDE(object ALCFLDIFDGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x1214C80", Offset = "0x1213480", VA = "0x181214C80")]
	public static void EJAEGLJMAHK(object ALCFLDIFDGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x1215830", Offset = "0x1214030", VA = "0x181215830")]
	private static Color JLJBCHFAMHO(int FNGOAMCGAPH, int HDKMFDOPGKJ, float OOBEFKALOAK, float AGOBAKOCCDL)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x1214AA0", Offset = "0x12132A0", VA = "0x181214AA0")]
	public static void EDDAOLANDPF(object ALCFLDIFDGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x12159F0", Offset = "0x12141F0", VA = "0x1812159F0")]
	private static Color KLGEOEEIFAF(Color IPEEGDIBNOO, Color OBPECMJLECD, float HKJMLEKHILN)
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
