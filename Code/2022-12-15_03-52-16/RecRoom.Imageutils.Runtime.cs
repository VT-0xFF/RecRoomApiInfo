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
		[Cpp2IlInjected.Address(RVA = "0x606BEF0", Offset = "0x606A8F0", VA = "0x18606BEF0")]
		public CubeMapGenerator()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public enum PMEJOLOKHEA
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
public interface IFDKEJKIBBP
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	PMEJOLOKHEA LMEDAFKACIN
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class HCOJPENEIFJ
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
			[Cpp2IlInjected.Address(RVA = "0x606EEE0", Offset = "0x606D8E0", VA = "0x18606EEE0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x606EED0", Offset = "0x606D8D0", VA = "0x18606EED0")]
		public Resolution(uint FBHIPILAOBE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x698050", Offset = "0x696A50", VA = "0x180698050")]
		public Resolution(uint FBHIPILAOBE, uint DPKHPCDGHJF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x606EDE0", Offset = "0x606D7E0", VA = "0x18606EDE0")]
		public static Resolution HLLEMHFBAOD(Resolution[] IDLLFOOCBNN, Resolution KMDCEHOGNBJ, int GOPIBLEGFGF)
		{
			return default(Resolution);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public class NOJBAKDCAFG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private readonly Resolution INPFIMHPIHF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private Resolution? HCOLEHDACND;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public uint FBHIPILAOBE
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x606E810", Offset = "0x606D210", VA = "0x18606E810")]
			get
			{
				return default(uint);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public uint DPKHPCDGHJF
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x606E9C0", Offset = "0x606D3C0", VA = "0x18606E9C0")]
			get
			{
				return default(uint);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public Resolution APBKGLDIBON
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x606E9E0", Offset = "0x606D3E0", VA = "0x18606E9E0")]
			get
			{
				return default(Resolution);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x15B0430", Offset = "0x15AEE30", VA = "0x1815B0430")]
		public NOJBAKDCAFG(Resolution INPFIMHPIHF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x606E820", Offset = "0x606D220", VA = "0x18606E820")]
		private static Resolution ECJCFBOMMEE(Resolution HCOLEHDACND, PMEJOLOKHEA HDLNKMMDJBD)
		{
			return default(Resolution);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public static class LLEDANNGFGJ
	{
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public static readonly Resolution FMPCHJGAFGA;

		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public static readonly Resolution BMDINCNBEGD;

		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public static readonly Resolution CCIBPGEFEOO;

		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public static readonly Resolution OEFCHKAKDFO;

		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public static readonly Resolution LMLKLGHAMPK;

		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public static readonly Resolution NCADEJJHOFM;

		[Cpp2IlInjected.Token(Token = "0x4000014")]
		internal static readonly Resolution[] INMNIACEOHE;
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public static class LPNFAAGEADA
	{
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public static readonly Resolution OFMLLKONECL;

		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public static readonly Resolution CPOEDFJHKOK;

		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public static readonly Resolution JFNJPLIGDDB;

		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public static readonly Resolution KOJNGHGHFCP;

		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public static readonly Resolution OKINOHOMILG;

		[Cpp2IlInjected.Token(Token = "0x400001A")]
		internal static readonly Resolution[] INMNIACEOHE;

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x606D500", Offset = "0x606BF00", VA = "0x18606D500")]
		public static Resolution HHEHGEFGIHC(uint LEFBNKJDKNL)
		{
			return default(Resolution);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public static readonly Resolution BACFGGEDIKG;

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x606CEC0", Offset = "0x606B8C0", VA = "0x18606CEC0")]
	public static bool AFFOBMDGMCA(uint FBKLDAMJDNN)
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
		public enum HHIEBHMLFFC : byte
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
		private class KJCCELCBPKM : IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			private string NBODBMLPNJA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			public Texture2D CDJJDHONPMD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400002C")]
			public HHIEBHMLFFC JDJHOBIAJOD;

			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x606D1A0", Offset = "0x606BBA0", VA = "0x18606D1A0")]
			public KJCCELCBPKM(string NBODBMLPNJA)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x67D750", Offset = "0x67C150", VA = "0x18067D750")]
			public KJCCELCBPKM(string NBODBMLPNJA, Texture2D DOHOBDDOJBE, HHIEBHMLFFC OIJCJLIFMAL)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x606D160", Offset = "0x606BB60", VA = "0x18606D160", Slot = "4")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000D")]
		[CompilerGenerated]
		private sealed class HDNPJJABEHJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400002D")]
			public ManagedTexture <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400002E")]
			public HHIEBHMLFFC textureMemory;

			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677530", VA = "0x180678B30")]
			public HDNPJJABEHJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x606D120", Offset = "0x606BB20", VA = "0x18606D120")]
			internal void <GetManagedTexture>b__0()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000E")]
		[CompilerGenerated]
		private sealed class CMFDFNHKOGF
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400002F")]
			public int quality;

			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677530", VA = "0x180678B30")]
			public CMFDFNHKOGF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x606BED0", Offset = "0x606A8D0", VA = "0x18606BED0")]
			internal byte[] <EncodeToJPG>b__0(Texture2D t2d)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000F")]
		[CompilerGenerated]
		private sealed class LLFMGBLAFPP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000030")]
			public RenderTexture tempRenderTexture;

			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677530", VA = "0x180678B30")]
			public LLFMGBLAFPP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x606D470", Offset = "0x606BE70", VA = "0x18606D470")]
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
		private global::DIHJKCFGFNO<Texture2D> _cpuSidePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private KJCCELCBPKM _memTexture;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private global::DIHJKCFGFNO<byte[]> _jpgEncodePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private byte[] _jpgBytes;

		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public const int DEFAULT_JPG_QUALITY = 80;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private global::DIHJKCFGFNO<byte[]> _pngEncodePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private byte[] _pngBytes;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public bool UsePalette
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x67B250", Offset = "0x679C50", VA = "0x18067B250")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public RenderTexture LastRenderTexture
		{
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x678120", Offset = "0x676B20", VA = "0x180678120")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x678130", Offset = "0x676B30", VA = "0x180678130")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		private KJCCELCBPKM memoryTexture
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x606E770", Offset = "0x606D170", VA = "0x18606E770")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x606E720", Offset = "0x606D120", VA = "0x18606E720")]
		public ManagedTexture(string NBODBMLPNJA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x606E6C0", Offset = "0x606D0C0", VA = "0x18606E6C0")]
		public ManagedTexture(string NBODBMLPNJA, bool DAMMPOALBIF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x606DA80", Offset = "0x606C480", VA = "0x18606DA80")]
		public void CGDCBHELNPH(RenderTexture GNBKNDLBAAB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x606E4A0", Offset = "0x606CEA0", VA = "0x18606E4A0")]
		public global::DIHJKCFGFNO<byte[]> HOMIENNHGEF(bool GDPDOKHIPLJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x606E0F0", Offset = "0x606CAF0", VA = "0x18606E0F0")]
		public global::DIHJKCFGFNO<Texture2D> HFEFGLHOHIH(HHIEBHMLFFC OIJCJLIFMAL, bool JHKDNIHNEGE = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x606E4C0", Offset = "0x606CEC0", VA = "0x18606E4C0")]
		public global::DIHJKCFGFNO<byte[]> OHLOBODEPCG(bool JHKDNIHNEGE = false, int IOLALACJDDA = 80)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x606D8C0", Offset = "0x606C2C0", VA = "0x18606D8C0")]
		public global::DIHJKCFGFNO<byte[]> AOAICLPGPOJ(bool JHKDNIHNEGE = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x606DB70", Offset = "0x606C570", VA = "0x18606DB70")]
		private static global::DIHJKCFGFNO<Texture2D> GEHIHCGENPH(string NBODBMLPNJA, RenderTexture GNBKNDLBAAB, ref Texture2D HBDKBFEAFPM, bool JHKDNIHNEGE, HHIEBHMLFFC JFCAFMNFNCK = HHIEBHMLFFC.GPU)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x606E3E0", Offset = "0x606CDE0", VA = "0x18606E3E0")]
		public void HJDOHCLDLLI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x606DB60", Offset = "0x606C560", VA = "0x18606DB60", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x606DAB0", Offset = "0x606C4B0", VA = "0x18606DAB0")]
		[CompilerGenerated]
		private global::DIHJKCFGFNO<byte[]> CIALPBEPHHI(Texture2D OMNHBJMDGNJ)
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public static class ODMFBILPBNI
{
	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x606EBC0", Offset = "0x606D5C0", VA = "0x18606EBC0")]
	public static RenderTexture HAGDIOKOHPB(int LEFBNKJDKNL, int ELIEMKLAFPL, int IFJOKNDLBML, Camera DKDADEMGLPD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x606ED70", Offset = "0x606D770", VA = "0x18606ED70")]
	public static void JBPCJJMIDKK(RenderTexture GNBKNDLBAAB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class FNGEFOPAOPJ
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public class FJMJEKGEMOM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public int LJECKBCMELA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public int EAJAFIHJLHG;

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x8DD2F0", Offset = "0x8DBCF0", VA = "0x1808DD2F0")]
		public FJMJEKGEMOM(int BBFEACHCBCI, int CNABBHHIHOO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	private enum ELIJPNLBOCJ
	{
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		Point,
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		Bilinear,
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		Average
	}

	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private static Color[] HLAPHLBCDMF;

	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private static Color[] BHDHEDIKBDG;

	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private static int JNLBJEDABNH;

	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private static float IPOEBANNPEG;

	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private static float DCJIGLKNILM;

	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private static int DMAGPGPICOK;

	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private static int NKAPPACMELK;

	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private static Mutex JJPNACGAGJG;

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x606BF10", Offset = "0x606A910", VA = "0x18606BF10")]
	public static void ACNKHHAHMNE(Texture2D NFMBOCDANHB, int BENPGIPOJFG, int DOBEJFLIMAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x606C1B0", Offset = "0x606ABB0", VA = "0x18606C1B0")]
	private static void GJBBOFENCDJ(Texture2D NFMBOCDANHB, int BENPGIPOJFG, int DOBEJFLIMAG, ELIJPNLBOCJ BOIFLMIGBFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x606C870", Offset = "0x606B270", VA = "0x18606C870")]
	public static void IDLNABPGHKB(object LGKNNMGLNIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x606C6A0", Offset = "0x606B0A0", VA = "0x18606C6A0")]
	public static void HDAILKABPGF(object LGKNNMGLNIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x606C010", Offset = "0x606AA10", VA = "0x18606C010")]
	private static Color EAAMLIDBFLM(int FBHIPILAOBE, int DPKHPCDGHJF, float IPOEBANNPEG, float DCJIGLKNILM)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x606CCF0", Offset = "0x606B6F0", VA = "0x18606CCF0")]
	public static void OPMKCBENAPI(object LGKNNMGLNIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x606BF30", Offset = "0x606A930", VA = "0x18606BF30")]
	private static Color DHBOECMDFBE(Color ELOMOAANDAG, Color LNCCLGDBCCL, float MAKFNMHIJIF)
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
