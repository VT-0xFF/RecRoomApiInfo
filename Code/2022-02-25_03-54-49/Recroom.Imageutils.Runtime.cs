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
		[Cpp2IlInjected.Address(RVA = "0x3204FC0", Offset = "0x32035C0", VA = "0x183204FC0")]
		public CubeMapGenerator()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public enum DNFOKCMEHDL
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
public interface JFHHODKDCEN
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	DNFOKCMEHDL JFADOFGMDME
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class KDBDNEPBONK
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
			[Cpp2IlInjected.Address(RVA = "0x3206850", Offset = "0x3204E50", VA = "0x183206850")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x3206840", Offset = "0x3204E40", VA = "0x183206840")]
		public Resolution(uint AEIHHPIDBGN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x63CF00", Offset = "0x63B500", VA = "0x18063CF00")]
		public Resolution(uint AEIHHPIDBGN, uint NFJDNKBDHHD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x32066F0", Offset = "0x3204CF0", VA = "0x1832066F0")]
		public static Resolution CDNBHFLBGJI(Resolution[] MEBKGNDEPFC, Resolution AGNPALBLIDN, int KMCPLNACOGP)
		{
			return default(Resolution);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public class APABNDGPAAP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private readonly Resolution BMAPFPPDFAB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private Resolution? DOHIDGBGBHL;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public uint AEIHHPIDBGN
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x3203AE0", Offset = "0x32020E0", VA = "0x183203AE0")]
			get
			{
				return default(uint);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public uint NFJDNKBDHHD
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x32038F0", Offset = "0x3201EF0", VA = "0x1832038F0")]
			get
			{
				return default(uint);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public Resolution KLJJEFKPFMO
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x3203AF0", Offset = "0x32020F0", VA = "0x183203AF0")]
			get
			{
				return default(Resolution);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x8B73D0", Offset = "0x8B59D0", VA = "0x1808B73D0")]
		public APABNDGPAAP(Resolution BMAPFPPDFAB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x3203910", Offset = "0x3201F10", VA = "0x183203910")]
		private static Resolution BHMCAFKJGPA(Resolution DOHIDGBGBHL, DNFOKCMEHDL LHHJPEFINNA)
		{
			return default(Resolution);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public static class CBCMPHNPNOJ
	{
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public static readonly Resolution CNNKHPPGDBE;

		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public static readonly Resolution BBEIEKEEJAD;

		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public static readonly Resolution PCCJLGHGBNG;

		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public static readonly Resolution APFHEALMDBK;

		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public static readonly Resolution HPFHMCCEPCD;

		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public static readonly Resolution FBGEICAPIFD;

		[Cpp2IlInjected.Token(Token = "0x4000014")]
		internal static readonly Resolution[] GMGOPMJIBFO;
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public static class PHKPDOAFCEJ
	{
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public static readonly Resolution AECCFOEJOMD;

		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public static readonly Resolution JCBHPAAHONH;

		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public static readonly Resolution CPEICABONCH;

		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public static readonly Resolution NGJJJPAGFCA;

		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public static readonly Resolution HEEFHNEPJPH;

		[Cpp2IlInjected.Token(Token = "0x400001A")]
		internal static readonly Resolution[] GMGOPMJIBFO;

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x3206350", Offset = "0x3204950", VA = "0x183206350")]
		public static Resolution IAOFPPCHAKC(uint PPFMJFLCFJD)
		{
			return default(Resolution);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public static readonly Resolution PCAPPOEKLIE;

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x3205270", Offset = "0x3203870", VA = "0x183205270")]
	public static bool OIMDILPPGNF(uint DHCBLHGABGF)
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
		public enum CBLJBKHCOAM : byte
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
		private class IBGIFGFDJPP : IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			private string EIBLJOLNOMI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			public Texture2D KGCEBAOOLII;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400002C")]
			public CBLJBKHCOAM KKAFBJHCPGM;

			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x3205220", Offset = "0x3203820", VA = "0x183205220")]
			public IBGIFGFDJPP(string EIBLJOLNOMI)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0xADBE80", Offset = "0xADA480", VA = "0x180ADBE80")]
			public IBGIFGFDJPP(string EIBLJOLNOMI, Texture2D OPLNEEINEGF, CBLJBKHCOAM AALPDELBGJP)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x32051E0", Offset = "0x32037E0", VA = "0x1832051E0", Slot = "4")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000D")]
		[CompilerGenerated]
		private sealed class MHLAHFLBGMP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400002D")]
			public ManagedTexture <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400002E")]
			public CBLJBKHCOAM textureMemory;

			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x5321A0", Offset = "0x5307A0", VA = "0x1805321A0")]
			public MHLAHFLBGMP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x32054B0", Offset = "0x3203AB0", VA = "0x1832054B0")]
			internal void <GetManagedTexture>b__0()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000E")]
		[CompilerGenerated]
		private sealed class GCHKKJCPOIJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400002F")]
			public int quality;

			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x5321A0", Offset = "0x5307A0", VA = "0x1805321A0")]
			public GCHKKJCPOIJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x32051C0", Offset = "0x32037C0", VA = "0x1832051C0")]
			internal byte[] <EncodeToJPG>b__0(Texture2D t2d)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000F")]
		[CompilerGenerated]
		private sealed class NGJDGAABOPO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000030")]
			public RenderTexture tempRenderTexture;

			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x5321A0", Offset = "0x5307A0", VA = "0x1805321A0")]
			public NGJDGAABOPO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x32062C0", Offset = "0x32048C0", VA = "0x1832062C0")]
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
		private global::FPCEKCNKAAO<Texture2D> _cpuSidePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private IBGIFGFDJPP _memTexture;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private global::FPCEKCNKAAO<byte[]> _jpgEncodePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private byte[] _jpgBytes;

		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public const int DEFAULT_JPG_QUALITY = 80;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private global::FPCEKCNKAAO<byte[]> _pngEncodePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private byte[] _pngBytes;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public bool UsePalette
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x773AE0", Offset = "0x7720E0", VA = "0x180773AE0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public RenderTexture LastRenderTexture
		{
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x50DD90", Offset = "0x50C390", VA = "0x18050DD90")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x5395F0", Offset = "0x537BF0", VA = "0x1805395F0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		private IBGIFGFDJPP memoryTexture
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x3206220", Offset = "0x3204820", VA = "0x183206220")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x32061D0", Offset = "0x32047D0", VA = "0x1832061D0")]
		public ManagedTexture(string EIBLJOLNOMI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x3206170", Offset = "0x3204770", VA = "0x183206170")]
		public ManagedTexture(string EIBLJOLNOMI, bool KPPDFJOKKOB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x3205EB0", Offset = "0x32044B0", VA = "0x183205EB0")]
		public void OGLIMOKBALN(RenderTexture HMGBLENEJII)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x3205DF0", Offset = "0x32043F0", VA = "0x183205DF0")]
		public global::FPCEKCNKAAO<byte[]> KMALLDEMIJG(bool FDFNKILHFAN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x3205EE0", Offset = "0x32044E0", VA = "0x183205EE0")]
		public global::FPCEKCNKAAO<Texture2D> PGCILAOODIC(CBLJBKHCOAM AALPDELBGJP, bool GMLCBBAFBLK = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x3205C40", Offset = "0x3204240", VA = "0x183205C40")]
		public global::FPCEKCNKAAO<byte[]> HEHKDBEGJDL(bool GMLCBBAFBLK = false, int FPKJJGOHAEL = 80)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x32054F0", Offset = "0x3203AF0", VA = "0x1832054F0")]
		public global::FPCEKCNKAAO<byte[]> BCGBHMNLOHC(bool GMLCBBAFBLK = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x3205680", Offset = "0x3203C80", VA = "0x183205680")]
		private static global::FPCEKCNKAAO<Texture2D> DPLOOEFDNOJ(string EIBLJOLNOMI, RenderTexture HMGBLENEJII, ref Texture2D DNBKEMMFHPF, bool GMLCBBAFBLK, CBLJBKHCOAM FDPHOBCCBOP = CBLJBKHCOAM.GPU)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x3205B80", Offset = "0x3204180", VA = "0x183205B80")]
		public void EHFKPHIFKAI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x3205B70", Offset = "0x3204170", VA = "0x183205B70", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x3205E10", Offset = "0x3204410", VA = "0x183205E10")]
		[CompilerGenerated]
		private global::FPCEKCNKAAO<byte[]> LOMEKKIKKOC(Texture2D IFCFCFEMFOI)
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public static class FHDBNGKKHHI
{
	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x3205050", Offset = "0x3203650", VA = "0x183205050")]
	public static RenderTexture NEGPCGLNLCH(int PPFMJFLCFJD, int BIOALPENMMK, int AFOOALBCHEO, Camera OONJMIECOOE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x3204FE0", Offset = "0x32035E0", VA = "0x183204FE0")]
	public static void LELIJFDBOPN(RenderTexture HMGBLENEJII)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class BOBMNDLLOJI
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public class GEMEFOOKGJJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public int JBMPAJCMLGB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public int LPDEFDFDBMN;

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x988090", Offset = "0x986690", VA = "0x180988090")]
		public GEMEFOOKGJJ(int NOGJILFDNDN, int KGONAAJAECB)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	private enum BBFINODBDEK
	{
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		Point,
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		Bilinear,
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		Average
	}

	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private static Color[] ELOEKOMPIFK;

	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private static Color[] PLEMFKPENAA;

	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private static int GOEGACBKPPH;

	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private static float JGMDIPGOHMA;

	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private static float INCEJKCLGDP;

	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private static int OLFPCIPACOO;

	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private static int PBKIMMNEMEG;

	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private static Mutex DGGAHPABKNH;

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x3203FC0", Offset = "0x32025C0", VA = "0x183203FC0")]
	public static void CFBINHNGEDP(Texture2D PCANAPDFDBD, int EJNDBEHLNBE, int PCABAONOIKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x32046E0", Offset = "0x3202CE0", VA = "0x1832046E0")]
	private static void NEJJAKCDNBH(Texture2D PCANAPDFDBD, int EJNDBEHLNBE, int PCABAONOIKF, BBFINODBDEK DPABGOFAHHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x3203FE0", Offset = "0x32025E0", VA = "0x183203FE0")]
	public static void FIHJCCAFCEB(object KFIBIDDJFNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x3203CF0", Offset = "0x32022F0", VA = "0x183203CF0")]
	public static void ACEDGPEAPPC(object KFIBIDDJFNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x3204B90", Offset = "0x3203190", VA = "0x183204B90")]
	private static Color PPBNENHAHCL(int AEIHHPIDBGN, int NFJDNKBDHHD, float JGMDIPGOHMA, float INCEJKCLGDP)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x3204500", Offset = "0x3202B00", VA = "0x183204500")]
	public static void IBFGPJDMACP(object KFIBIDDJFNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x3203ED0", Offset = "0x32024D0", VA = "0x183203ED0")]
	private static Color BAIOIGOAGCE(Color HCDELCJNOLD, Color CHOMKLBKDBE, float JKOBKIEBPCF)
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
