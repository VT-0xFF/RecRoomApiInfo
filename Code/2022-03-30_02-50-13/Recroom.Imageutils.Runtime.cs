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
		[Cpp2IlInjected.Address(RVA = "0x4B1AB70", Offset = "0x4B19170", VA = "0x184B1AB70")]
		public CubeMapGenerator()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public enum HFFDDONMOCL
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
public interface GHHFAILFECL
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	HFFDDONMOCL HMLHLEMFIKC
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class DDACGLKGGGD
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
			[Cpp2IlInjected.Address(RVA = "0x4B1D5F0", Offset = "0x4B1BBF0", VA = "0x184B1D5F0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x4B1D5E0", Offset = "0x4B1BBE0", VA = "0x184B1D5E0")]
		public Resolution(uint GHGHAFCMINB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x631BA0", Offset = "0x6301A0", VA = "0x180631BA0")]
		public Resolution(uint GHGHAFCMINB, uint PAFNDAGPPJD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x4B1D490", Offset = "0x4B1BA90", VA = "0x184B1D490")]
		public static Resolution LOLJKBFJDAL(Resolution[] CADDBGKPOOP, Resolution PCDOKEJHIEH, int OPAKFODENEM)
		{
			return default(Resolution);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public class KCHCHFCIADG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private readonly Resolution ECACBIPHCNP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private Resolution? MENCAFGHCAE;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public uint GHGHAFCMINB
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x4B1C020", Offset = "0x4B1A620", VA = "0x184B1C020")]
			get
			{
				return default(uint);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public uint PAFNDAGPPJD
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x4B1C000", Offset = "0x4B1A600", VA = "0x184B1C000")]
			get
			{
				return default(uint);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public Resolution IJDFHNHDDFJ
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x4B1C030", Offset = "0x4B1A630", VA = "0x184B1C030")]
			get
			{
				return default(Resolution);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x15A7FA0", Offset = "0x15A65A0", VA = "0x1815A7FA0")]
		public KCHCHFCIADG(Resolution ECACBIPHCNP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x4B1BE30", Offset = "0x4B1A430", VA = "0x184B1BE30")]
		private static Resolution DHKCPMHCJOD(Resolution MENCAFGHCAE, HFFDDONMOCL PEHAOEPLDHP)
		{
			return default(Resolution);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public static class BKOHACPKMEI
	{
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public static readonly Resolution BNLIGBEGIGB;

		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public static readonly Resolution AACDCAOOANH;

		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public static readonly Resolution GLCEOKODEHM;

		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public static readonly Resolution OIOAFEKKEDF;

		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public static readonly Resolution AKGAIIPNMLJ;

		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public static readonly Resolution DCADMFNMAGO;

		[Cpp2IlInjected.Token(Token = "0x4000014")]
		internal static readonly Resolution[] KHFDPNPOEKC;
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public static class ONNMCCPFADE
	{
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public static readonly Resolution NPNCFDFFGCE;

		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public static readonly Resolution FPLDOPCAPMF;

		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public static readonly Resolution MINHLJIAJNG;

		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public static readonly Resolution PHJDHBCDOPG;

		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public static readonly Resolution NOEMAAIOJOI;

		[Cpp2IlInjected.Token(Token = "0x400001A")]
		internal static readonly Resolution[] KHFDPNPOEKC;

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x4B1D0B0", Offset = "0x4B1B6B0", VA = "0x184B1D0B0")]
		public static Resolution GFEGGMBMHGD(uint NABAGIDNPBH)
		{
			return default(Resolution);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public static readonly Resolution FIICGOANGPG;

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x4B1AB90", Offset = "0x4B19190", VA = "0x184B1AB90")]
	public static bool KEDHMNJGENJ(uint OECAOOAOCCA)
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
		public enum GPEGNBNIGAC : byte
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
		private class BGLDEPFDEIJ : IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			private string LEOGCMFBAME;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			public Texture2D GBPDJHEMGBF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400002C")]
			public GPEGNBNIGAC LKDGPPJAKAN;

			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x4B1A8B0", Offset = "0x4B18EB0", VA = "0x184B1A8B0")]
			public BGLDEPFDEIJ(string LEOGCMFBAME)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x827870", Offset = "0x825E70", VA = "0x180827870")]
			public BGLDEPFDEIJ(string LEOGCMFBAME, Texture2D FDGILGPIKNI, GPEGNBNIGAC OCKPFPOOKPP)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x4B1A870", Offset = "0x4B18E70", VA = "0x184B1A870", Slot = "4")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000D")]
		[CompilerGenerated]
		private sealed class PNGMMIFACND
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400002D")]
			public ManagedTexture <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400002E")]
			public GPEGNBNIGAC textureMemory;

			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x522AB0", Offset = "0x5210B0", VA = "0x180522AB0")]
			public PNGMMIFACND()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x4B1D450", Offset = "0x4B1BA50", VA = "0x184B1D450")]
			internal void <GetManagedTexture>b__0()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000E")]
		[CompilerGenerated]
		private sealed class MBKKKKBAPGP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400002F")]
			public int quality;

			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x522AB0", Offset = "0x5210B0", VA = "0x180522AB0")]
			public MBKKKKBAPGP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x4B1C230", Offset = "0x4B1A830", VA = "0x184B1C230")]
			internal byte[] <EncodeToJPG>b__0(Texture2D t2d)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000F")]
		[CompilerGenerated]
		private sealed class NHAFKJCODNC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000030")]
			public RenderTexture tempRenderTexture;

			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x522AB0", Offset = "0x5210B0", VA = "0x180522AB0")]
			public NHAFKJCODNC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x4B1D020", Offset = "0x4B1B620", VA = "0x184B1D020")]
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
		private global::OGKKIDEDJHF<Texture2D> _cpuSidePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private BGLDEPFDEIJ _memTexture;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private global::OGKKIDEDJHF<byte[]> _jpgEncodePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private byte[] _jpgBytes;

		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public const int DEFAULT_JPG_QUALITY = 80;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private global::OGKKIDEDJHF<byte[]> _pngEncodePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private byte[] _pngBytes;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public bool UsePalette
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x54D250", Offset = "0x54B850", VA = "0x18054D250")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public RenderTexture LastRenderTexture
		{
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x522DF0", Offset = "0x5213F0", VA = "0x180522DF0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x5E0560", Offset = "0x5DEB60", VA = "0x1805E0560")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		private BGLDEPFDEIJ memoryTexture
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x4B1CF80", Offset = "0x4B1B580", VA = "0x184B1CF80")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x4B1CF30", Offset = "0x4B1B530", VA = "0x184B1CF30")]
		public ManagedTexture(string LEOGCMFBAME)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x4B1CED0", Offset = "0x4B1B4D0", VA = "0x184B1CED0")]
		public ManagedTexture(string LEOGCMFBAME, bool CHLABLOGHNB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x4B1CC30", Offset = "0x4B1B230", VA = "0x184B1CC30")]
		public void LDBJLAHAJAK(RenderTexture MCKKAPCNBMB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x4B1C3E0", Offset = "0x4B1A9E0", VA = "0x184B1C3E0")]
		public global::OGKKIDEDJHF<byte[]> DEHCFNKGBBL(bool AEAAJNNHOFA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x4B1C900", Offset = "0x4B1AF00", VA = "0x184B1C900")]
		public global::OGKKIDEDJHF<Texture2D> HOCFBGCJNLC(GPEGNBNIGAC OCKPFPOOKPP, bool IKAFIPHNBBI = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x4B1CC60", Offset = "0x4B1B260", VA = "0x184B1CC60")]
		public global::OGKKIDEDJHF<byte[]> LMGDBGJNFGL(bool IKAFIPHNBBI = false, int EDDOHGIAHFF = 80)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x4B1C250", Offset = "0x4B1A850", VA = "0x184B1C250")]
		public global::OGKKIDEDJHF<byte[]> DALCMFBIOAN(bool IKAFIPHNBBI = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x4B1C410", Offset = "0x4B1AA10", VA = "0x184B1C410")]
		private static global::OGKKIDEDJHF<Texture2D> HDDNHEDBEOO(string LEOGCMFBAME, RenderTexture MCKKAPCNBMB, ref Texture2D GJFLHCEMALJ, bool IKAFIPHNBBI, GPEGNBNIGAC KKNIKFLNNEK = GPEGNBNIGAC.GPU)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x4B1CE10", Offset = "0x4B1B410", VA = "0x184B1CE10")]
		public void PGFCFCEIKHH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x4B1C400", Offset = "0x4B1AA00", VA = "0x184B1C400", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x4B1CB90", Offset = "0x4B1B190", VA = "0x184B1CB90")]
		[CompilerGenerated]
		private global::OGKKIDEDJHF<byte[]> JFCAJHNFIDH(Texture2D OFOCPGNHKAE)
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public static class AOELBDKFKJO
{
	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x4B1A690", Offset = "0x4B18C90", VA = "0x184B1A690")]
	public static RenderTexture BNOAIFNPAKP(int NABAGIDNPBH, int LCHOEMIECIB, int JHMMBJIDMDE, Camera HDEFJNGJHNJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x4B1A800", Offset = "0x4B18E00", VA = "0x184B1A800")]
	public static void HGAPBLHHINC(RenderTexture MCKKAPCNBMB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class HOGPCAMLCLG
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public class NINMDCLFDCB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public int NLKNFILNCBB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public int NNAABNLELHM;

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x563DA0", Offset = "0x5623A0", VA = "0x180563DA0")]
		public NINMDCLFDCB(int JCMILBCKNDN, int JBAJFCDPKHB)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	private enum GHLFLDEPMIN
	{
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		Point,
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		Bilinear,
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		Average
	}

	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private static Color[] AEPMHODKBOG;

	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private static Color[] KOHCABJDBCK;

	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private static int KFADHCBNGMB;

	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private static float HAAEADLJLLL;

	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private static float DDEAMJPHCBO;

	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private static int PHLMFAGCCNM;

	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private static int DIDCDBEGDDP;

	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private static Mutex AMIBKKHEMFF;

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x4B1B350", Offset = "0x4B19950", VA = "0x184B1B350")]
	public static void MNNCOBAJHPA(Texture2D EIJKMIJKFHB, int BNKBGEOBJKK, int DJOFGFFHEBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x4B1B370", Offset = "0x4B19970", VA = "0x184B1B370")]
	private static void MOEFAMFBIGE(Texture2D EIJKMIJKFHB, int BNKBGEOBJKK, int DJOFGFFHEBG, GHLFLDEPMIN PFPGKONDFAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x4B1B910", Offset = "0x4B19F10", VA = "0x184B1B910")]
	public static void NIMMBNMJEFH(object GPAMIINBFCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x4B1B170", Offset = "0x4B19770", VA = "0x184B1B170")]
	public static void JNPCDFDNHAF(object GPAMIINBFCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x4B1AFB0", Offset = "0x4B195B0", VA = "0x184B1AFB0")]
	private static Color DGGGKOCFDDF(int GHGHAFCMINB, int PAFNDAGPPJD, float HAAEADLJLLL, float DDEAMJPHCBO)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x4B1ADD0", Offset = "0x4B193D0", VA = "0x184B1ADD0")]
	public static void CCHHJOKCBNA(object GPAMIINBFCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x4B1B820", Offset = "0x4B19E20", VA = "0x184B1B820")]
	private static Color NEONDEADKON(Color HADBNNALOCG, Color ELGPOBKPGEJ, float BABHCNCDDFB)
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
