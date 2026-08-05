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
		[Cpp2IlInjected.Address(RVA = "0x6A06A60", Offset = "0x6A05E60", VA = "0x186A06A60")]
		public CubeMapGenerator()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public enum HCEOKACMONI
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
public interface DEJOIGIFHEF
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	HCEOKACMONI HNICIDELBKN
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class GDHLJDCIEIL
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
			[Cpp2IlInjected.Address(RVA = "0x6A097A0", Offset = "0x6A08BA0", VA = "0x186A097A0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x6A09790", Offset = "0x6A08B90", VA = "0x186A09790")]
		public Resolution(uint GKBCEINHOJB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x735A30", Offset = "0x734E30", VA = "0x180735A30")]
		public Resolution(uint GKBCEINHOJB, uint LAMHEDHCIJG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x6A096A0", Offset = "0x6A08AA0", VA = "0x186A096A0")]
		public static Resolution OLPFHOPMCNM(Resolution[] MIBGOGGBLGL, Resolution NFNMPJLBEJM, int IILAAKNAPLE)
		{
			return default(Resolution);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public class JICBHFFOOFM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private readonly Resolution PFIEPHMLPAK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private Resolution? ADFLNMBNDNH;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public uint GKBCEINHOJB
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x6A07560", Offset = "0x6A06960", VA = "0x186A07560")]
			get
			{
				return default(uint);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public uint LAMHEDHCIJG
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x6A07540", Offset = "0x6A06940", VA = "0x186A07540")]
			get
			{
				return default(uint);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public Resolution BHKLJEHNFFH
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x6A07360", Offset = "0x6A06760", VA = "0x186A07360")]
			get
			{
				return default(Resolution);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x14326E0", Offset = "0x1431AE0", VA = "0x1814326E0")]
		public JICBHFFOOFM(Resolution PFIEPHMLPAK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x6A07570", Offset = "0x6A06970", VA = "0x186A07570")]
		private static Resolution LNMICIIAIMC(Resolution ADFLNMBNDNH, HCEOKACMONI HJONGJJEMAM)
		{
			return default(Resolution);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public static class ENGIJKPPKCI
	{
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public static readonly Resolution KLBIMIBKAKL;

		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public static readonly Resolution FIHCJEHNEMP;

		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public static readonly Resolution FNIIBIMFHNP;

		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public static readonly Resolution FPLPDBMLGMB;

		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public static readonly Resolution PMPMFLDCEFJ;

		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public static readonly Resolution KHBPNBIKLIP;

		[Cpp2IlInjected.Token(Token = "0x4000014")]
		internal static readonly Resolution[] HNPDLEIOONC;
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public static class JDFCOPGCMMB
	{
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public static readonly Resolution DOCCHCOBLOB;

		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public static readonly Resolution MDNEMEMAOMG;

		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public static readonly Resolution LIJBKIOCGCM;

		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public static readonly Resolution DGDLIBFEFJM;

		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public static readonly Resolution JGMFHLJHOEM;

		[Cpp2IlInjected.Token(Token = "0x400001A")]
		internal static readonly Resolution[] HNPDLEIOONC;

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x6A06FA0", Offset = "0x6A063A0", VA = "0x186A06FA0")]
		public static Resolution OCGPLBLELFM(uint CNHIJOPNDKB)
		{
			return default(Resolution);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public static readonly Resolution MGDJFJMGKOJ;

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x6A06D00", Offset = "0x6A06100", VA = "0x186A06D00")]
	public static bool KBLHHMEOHOO(uint IICJNCLJKMH)
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
		public enum IICEBMMBAAD : byte
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
		private class NCOPKDFDODE : IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			private string AMNLGEBHFHK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			public Texture2D DCLJGPCLLIK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400002C")]
			public IICEBMMBAAD JCJIAPNKHGN;

			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x6A09650", Offset = "0x6A08A50", VA = "0x186A09650")]
			public NCOPKDFDODE(string AMNLGEBHFHK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x86E710", Offset = "0x86DB10", VA = "0x18086E710")]
			public NCOPKDFDODE(string AMNLGEBHFHK, Texture2D IABGICEDMHC, IICEBMMBAAD CAECBDMPHDC)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x6A09610", Offset = "0x6A08A10", VA = "0x186A09610", Slot = "4")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000D")]
		[CompilerGenerated]
		private sealed class IIGBOJICJEF
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400002D")]
			public ManagedTexture <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400002E")]
			public IICEBMMBAAD textureMemory;

			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x72E810", Offset = "0x72DC10", VA = "0x18072E810")]
			public IIGBOJICJEF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x6A06F60", Offset = "0x6A06360", VA = "0x186A06F60")]
			internal void <GetManagedTexture>b__0()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000E")]
		[CompilerGenerated]
		private sealed class CAEBDAAPCGP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400002F")]
			public int quality;

			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x72E810", Offset = "0x72DC10", VA = "0x18072E810")]
			public CAEBDAAPCGP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x6A06A40", Offset = "0x6A05E40", VA = "0x186A06A40")]
			internal byte[] <EncodeToJPG>b__0(Texture2D t2d)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000F")]
		[CompilerGenerated]
		private sealed class BAPANBNNIIA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000030")]
			public RenderTexture tempRenderTexture;

			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x72E810", Offset = "0x72DC10", VA = "0x18072E810")]
			public BAPANBNNIIA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x6A06790", Offset = "0x6A05B90", VA = "0x186A06790")]
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
		private global::ODHJGGEEIEO<Texture2D> _cpuSidePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private NCOPKDFDODE _memTexture;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private global::ODHJGGEEIEO<byte[]> _jpgEncodePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private byte[] _jpgBytes;

		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public const int DEFAULT_JPG_QUALITY = 80;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private global::ODHJGGEEIEO<byte[]> _pngEncodePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private byte[] _pngBytes;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public bool UsePalette
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x7B1910", Offset = "0x7B0D10", VA = "0x1807B1910")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public RenderTexture LastRenderTexture
		{
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x72F250", Offset = "0x72E650", VA = "0x18072F250")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x7A04D0", Offset = "0x79F8D0", VA = "0x1807A04D0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		private NCOPKDFDODE memoryTexture
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x6A09570", Offset = "0x6A08970", VA = "0x186A09570")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x6A09520", Offset = "0x6A08920", VA = "0x186A09520")]
		public ManagedTexture(string AMNLGEBHFHK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x6A094C0", Offset = "0x6A088C0", VA = "0x186A094C0")]
		public ManagedTexture(string AMNLGEBHFHK, bool HNOHGPIALPP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x6A086C0", Offset = "0x6A07AC0", VA = "0x186A086C0")]
		public void AIKHGGNOAAH(RenderTexture MCBMPNNCIFL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x6A086F0", Offset = "0x6A07AF0", VA = "0x186A086F0")]
		public global::ODHJGGEEIEO<byte[]> DJDJILIFBFK(bool EOMKPMFKBFB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x6A08BA0", Offset = "0x6A07FA0", VA = "0x186A08BA0")]
		public global::ODHJGGEEIEO<Texture2D> LPLABHNDGOF(IICEBMMBAAD CAECBDMPHDC, bool OICOLJAFIJL = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x6A08720", Offset = "0x6A07B20", VA = "0x186A08720")]
		public global::ODHJGGEEIEO<byte[]> GOCDBENDJFI(bool OICOLJAFIJL = false, int MPKBPIINDPI = 80)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x6A089E0", Offset = "0x6A07DE0", VA = "0x186A089E0")]
		public global::ODHJGGEEIEO<byte[]> HFFPNDJODDK(bool OICOLJAFIJL = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x6A08E90", Offset = "0x6A08290", VA = "0x186A08E90")]
		private static global::ODHJGGEEIEO<Texture2D> OPLACCMLPMK(string AMNLGEBHFHK, RenderTexture MCBMPNNCIFL, ref Texture2D FKFOFGCPDCB, bool OICOLJAFIJL, IICEBMMBAAD PENLANIEIGJ = IICEBMMBAAD.GPU)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x6A08920", Offset = "0x6A07D20", VA = "0x186A08920")]
		public void HBODLFIIGIE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x6A08710", Offset = "0x6A07B10", VA = "0x186A08710", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x6A09410", Offset = "0x6A08810", VA = "0x186A09410")]
		[CompilerGenerated]
		private global::ODHJGGEEIEO<byte[]> OPLEBBINBED(Texture2D BIEAOPKIFDC)
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public static class BFLPHBPLAHK
{
	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x6A06820", Offset = "0x6A05C20", VA = "0x186A06820")]
	public static RenderTexture INFBHEKEMOA(int CNHIJOPNDKB, int PJDCFLLCMEF, int GDPPOOAONKL, Camera KOLLANHLAOK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x6A069D0", Offset = "0x6A05DD0", VA = "0x186A069D0")]
	public static void PODCPMLNJKA(RenderTexture MCBMPNNCIFL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class KEJMOKPKKCK
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public class KPKFIAMBEKI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public int LOEMONDJCMM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public int FHNIHLGHOIB;

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0xB1CB70", Offset = "0xB1BF70", VA = "0x180B1CB70")]
		public KPKFIAMBEKI(int NKKEIKGKIDA, int CCICIDAGDNF)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	private enum IGCFAFJDECJ
	{
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		Point,
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		Bilinear,
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		Average
	}

	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private static Color[] GBEGKKIPEHF;

	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private static Color[] GIBNMIKAHAB;

	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private static int APNGGCJAEIO;

	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private static float EJJLODBJOML;

	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private static float HEMLJKPMMIP;

	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private static int EJEGFDFGGPC;

	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private static int FMHMEFMODDC;

	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private static Mutex OHJBPDOPAEC;

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x6A07F00", Offset = "0x6A07300", VA = "0x186A07F00")]
	public static void GFLFPJHIEPA(Texture2D LPAFKHCFKFO, int OADGBFOIKDC, int HNGEENNAGDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x6A080F0", Offset = "0x6A074F0", VA = "0x186A080F0")]
	private static void KNKPPHDODAL(Texture2D LPAFKHCFKFO, int OADGBFOIKDC, int HNGEENNAGDF, IGCFAFJDECJ AIDKMFBMMNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x6A078E0", Offset = "0x6A06CE0", VA = "0x186A078E0")]
	public static void ELPNNJGKEPP(object NBNOMDAKOCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x6A07F20", Offset = "0x6A07320", VA = "0x186A07F20")]
	public static void IFGBLKLENGP(object NBNOMDAKOCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x6A07D60", Offset = "0x6A07160", VA = "0x186A07D60")]
	private static Color FFFDGDCFMBL(int GKBCEINHOJB, int LAMHEDHCIJG, float EJJLODBJOML, float HEMLJKPMMIP)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x6A07710", Offset = "0x6A06B10", VA = "0x186A07710")]
	public static void AMAHDEICJNK(object NBNOMDAKOCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x6A085E0", Offset = "0x6A079E0", VA = "0x186A085E0")]
	private static Color PICNKABHCMO(Color JBDBGLAFGCH, Color KEFDOHGCCKJ, float LPJDDLMPNCG)
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
