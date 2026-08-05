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
		[Cpp2IlInjected.Address(RVA = "0x69D7E20", Offset = "0x69D6820", VA = "0x1869D7E20")]
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
			[Cpp2IlInjected.Address(RVA = "0x69DAB60", Offset = "0x69D9560", VA = "0x1869DAB60")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x69DAB50", Offset = "0x69D9550", VA = "0x1869DAB50")]
		public Resolution(uint GKBCEINHOJB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x731A30", Offset = "0x730430", VA = "0x180731A30")]
		public Resolution(uint GKBCEINHOJB, uint LAMHEDHCIJG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x69DAA60", Offset = "0x69D9460", VA = "0x1869DAA60")]
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
			[Cpp2IlInjected.Address(RVA = "0x69D8920", Offset = "0x69D7320", VA = "0x1869D8920")]
			get
			{
				return default(uint);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public uint LAMHEDHCIJG
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x69D8900", Offset = "0x69D7300", VA = "0x1869D8900")]
			get
			{
				return default(uint);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public Resolution BHKLJEHNFFH
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x69D8720", Offset = "0x69D7120", VA = "0x1869D8720")]
			get
			{
				return default(Resolution);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x15A2210", Offset = "0x15A0C10", VA = "0x1815A2210")]
		public JICBHFFOOFM(Resolution PFIEPHMLPAK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x69D8930", Offset = "0x69D7330", VA = "0x1869D8930")]
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
		[Cpp2IlInjected.Address(RVA = "0x69D8360", Offset = "0x69D6D60", VA = "0x1869D8360")]
		public static Resolution OCGPLBLELFM(uint CNHIJOPNDKB)
		{
			return default(Resolution);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public static readonly Resolution MGDJFJMGKOJ;

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x69D80C0", Offset = "0x69D6AC0", VA = "0x1869D80C0")]
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
			[Cpp2IlInjected.Address(RVA = "0x69DAA10", Offset = "0x69D9410", VA = "0x1869DAA10")]
			public NCOPKDFDODE(string AMNLGEBHFHK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x7BBBC0", Offset = "0x7BA5C0", VA = "0x1807BBBC0")]
			public NCOPKDFDODE(string AMNLGEBHFHK, Texture2D IABGICEDMHC, IICEBMMBAAD CAECBDMPHDC)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x69DA9D0", Offset = "0x69D93D0", VA = "0x1869DA9D0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x72A810", Offset = "0x729210", VA = "0x18072A810")]
			public IIGBOJICJEF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x69D8320", Offset = "0x69D6D20", VA = "0x1869D8320")]
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
			[Cpp2IlInjected.Address(RVA = "0x72A810", Offset = "0x729210", VA = "0x18072A810")]
			public CAEBDAAPCGP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x69D7E00", Offset = "0x69D6800", VA = "0x1869D7E00")]
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
			[Cpp2IlInjected.Address(RVA = "0x72A810", Offset = "0x729210", VA = "0x18072A810")]
			public BAPANBNNIIA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x69D7B50", Offset = "0x69D6550", VA = "0x1869D7B50")]
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
			[Cpp2IlInjected.Address(RVA = "0x754640", Offset = "0x753040", VA = "0x180754640")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public RenderTexture LastRenderTexture
		{
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x72B250", Offset = "0x729C50", VA = "0x18072B250")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x74C3F0", Offset = "0x74ADF0", VA = "0x18074C3F0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		private NCOPKDFDODE memoryTexture
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x69DA930", Offset = "0x69D9330", VA = "0x1869DA930")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x69DA8E0", Offset = "0x69D92E0", VA = "0x1869DA8E0")]
		public ManagedTexture(string AMNLGEBHFHK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x69DA880", Offset = "0x69D9280", VA = "0x1869DA880")]
		public ManagedTexture(string AMNLGEBHFHK, bool HNOHGPIALPP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x69D9A80", Offset = "0x69D8480", VA = "0x1869D9A80")]
		public void AIKHGGNOAAH(RenderTexture MCBMPNNCIFL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x69D9AB0", Offset = "0x69D84B0", VA = "0x1869D9AB0")]
		public global::ODHJGGEEIEO<byte[]> DJDJILIFBFK(bool EOMKPMFKBFB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x69D9F60", Offset = "0x69D8960", VA = "0x1869D9F60")]
		public global::ODHJGGEEIEO<Texture2D> LPLABHNDGOF(IICEBMMBAAD CAECBDMPHDC, bool OICOLJAFIJL = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x69D9AE0", Offset = "0x69D84E0", VA = "0x1869D9AE0")]
		public global::ODHJGGEEIEO<byte[]> GOCDBENDJFI(bool OICOLJAFIJL = false, int MPKBPIINDPI = 80)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x69D9DA0", Offset = "0x69D87A0", VA = "0x1869D9DA0")]
		public global::ODHJGGEEIEO<byte[]> HFFPNDJODDK(bool OICOLJAFIJL = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x69DA250", Offset = "0x69D8C50", VA = "0x1869DA250")]
		private static global::ODHJGGEEIEO<Texture2D> OPLACCMLPMK(string AMNLGEBHFHK, RenderTexture MCBMPNNCIFL, ref Texture2D FKFOFGCPDCB, bool OICOLJAFIJL, IICEBMMBAAD PENLANIEIGJ = IICEBMMBAAD.GPU)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x69D9CE0", Offset = "0x69D86E0", VA = "0x1869D9CE0")]
		public void HBODLFIIGIE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x69D9AD0", Offset = "0x69D84D0", VA = "0x1869D9AD0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x69DA7D0", Offset = "0x69D91D0", VA = "0x1869DA7D0")]
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
	[Cpp2IlInjected.Address(RVA = "0x69D7BE0", Offset = "0x69D65E0", VA = "0x1869D7BE0")]
	public static RenderTexture INFBHEKEMOA(int CNHIJOPNDKB, int PJDCFLLCMEF, int GDPPOOAONKL, Camera KOLLANHLAOK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x69D7D90", Offset = "0x69D6790", VA = "0x1869D7D90")]
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
		[Cpp2IlInjected.Address(RVA = "0x8CE450", Offset = "0x8CCE50", VA = "0x1808CE450")]
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
	[Cpp2IlInjected.Address(RVA = "0x69D92C0", Offset = "0x69D7CC0", VA = "0x1869D92C0")]
	public static void GFLFPJHIEPA(Texture2D LPAFKHCFKFO, int OADGBFOIKDC, int HNGEENNAGDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x69D94B0", Offset = "0x69D7EB0", VA = "0x1869D94B0")]
	private static void KNKPPHDODAL(Texture2D LPAFKHCFKFO, int OADGBFOIKDC, int HNGEENNAGDF, IGCFAFJDECJ AIDKMFBMMNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x69D8CA0", Offset = "0x69D76A0", VA = "0x1869D8CA0")]
	public static void ELPNNJGKEPP(object NBNOMDAKOCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x69D92E0", Offset = "0x69D7CE0", VA = "0x1869D92E0")]
	public static void IFGBLKLENGP(object NBNOMDAKOCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x69D9120", Offset = "0x69D7B20", VA = "0x1869D9120")]
	private static Color FFFDGDCFMBL(int GKBCEINHOJB, int LAMHEDHCIJG, float EJJLODBJOML, float HEMLJKPMMIP)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x69D8AD0", Offset = "0x69D74D0", VA = "0x1869D8AD0")]
	public static void AMAHDEICJNK(object NBNOMDAKOCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x69D99A0", Offset = "0x69D83A0", VA = "0x1869D99A0")]
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
