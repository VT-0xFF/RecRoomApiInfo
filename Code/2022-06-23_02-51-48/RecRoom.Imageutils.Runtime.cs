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
		[Cpp2IlInjected.Address(RVA = "0x4FC58E0", Offset = "0x4FC4AE0", VA = "0x184FC58E0")]
		public CubeMapGenerator()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public enum HFIOPLAKMCF
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
public interface EEAGIBDKDPK
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	HFIOPLAKMCF JJOEAPJNEEC
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class CPLKFDFIAHC
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
			[Cpp2IlInjected.Address(RVA = "0x4FC80E0", Offset = "0x4FC72E0", VA = "0x184FC80E0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x4FC80D0", Offset = "0x4FC72D0", VA = "0x184FC80D0")]
		public Resolution(uint NJBKHCBPNDB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x5FB570", Offset = "0x5FA770", VA = "0x1805FB570")]
		public Resolution(uint NJBKHCBPNDB, uint CBNFMHDNCPP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x4FC7F80", Offset = "0x4FC7180", VA = "0x184FC7F80")]
		public static Resolution NKONBKMNDOC(Resolution[] LACNFGGIDCN, Resolution MHMHEIGIAPO, int CHFLJNBADCJ)
		{
			return default(Resolution);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public class CFHMLDMPGAN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private readonly Resolution CMJLDGODODH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private Resolution? JLJNOMBKDIG;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public uint NJBKHCBPNDB
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x4FC5670", Offset = "0x4FC4870", VA = "0x184FC5670")]
			get
			{
				return default(uint);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public uint CBNFMHDNCPP
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x4FC5680", Offset = "0x4FC4880", VA = "0x184FC5680")]
			get
			{
				return default(uint);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public Resolution HCJJIJDPIJE
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x4FC5470", Offset = "0x4FC4670", VA = "0x184FC5470")]
			get
			{
				return default(Resolution);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x9D3B60", Offset = "0x9D2D60", VA = "0x1809D3B60")]
		public CFHMLDMPGAN(Resolution CMJLDGODODH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x4FC52A0", Offset = "0x4FC44A0", VA = "0x184FC52A0")]
		private static Resolution BKCDIGKDDLH(Resolution JLJNOMBKDIG, HFIOPLAKMCF LKCILCMAMHD)
		{
			return default(Resolution);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public static class IIPMBKHKKNC
	{
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public static readonly Resolution HCDMCKGDLIH;

		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public static readonly Resolution NKFGNMPCLEL;

		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public static readonly Resolution OLLMOKEDEFA;

		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public static readonly Resolution GGOBPHBPPJG;

		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public static readonly Resolution KAEMOAHKLLA;

		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public static readonly Resolution DIJLACIGBKK;

		[Cpp2IlInjected.Token(Token = "0x4000014")]
		internal static readonly Resolution[] KEFLKPPOLCC;
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public static class FPMCPHGBILC
	{
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public static readonly Resolution LPIHJFBKFIJ;

		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public static readonly Resolution HGMGKANMAPH;

		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public static readonly Resolution KAGHPKEDPNP;

		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public static readonly Resolution IPOIFMFFBLN;

		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public static readonly Resolution MAACMECOHOK;

		[Cpp2IlInjected.Token(Token = "0x400001A")]
		internal static readonly Resolution[] KEFLKPPOLCC;

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x4FC5940", Offset = "0x4FC4B40", VA = "0x184FC5940")]
		public static Resolution KAOINMNJIDM(uint MLMOINPPPFB)
		{
			return default(Resolution);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public static readonly Resolution LLEDOLDECDA;

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x4FC56A0", Offset = "0x4FC48A0", VA = "0x184FC56A0")]
	public static bool IAHCEFGFFCO(uint GAIDHJDJIMC)
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
		public enum JKDLHIKOPNK : byte
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
		private class BHDNJEJNKJN : IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			private string HKLPIGDOLHA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			public Texture2D HBBILLOPAMJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400002C")]
			public JKDLHIKOPNK JEEDFDFFJKL;

			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x4FC51C0", Offset = "0x4FC43C0", VA = "0x184FC51C0")]
			public BHDNJEJNKJN(string HKLPIGDOLHA)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x20097D0", Offset = "0x20089D0", VA = "0x1820097D0")]
			public BHDNJEJNKJN(string HKLPIGDOLHA, Texture2D FALMNMCKLFE, JKDLHIKOPNK JDBDEJAGNAD)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x4FC5180", Offset = "0x4FC4380", VA = "0x184FC5180", Slot = "4")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000D")]
		[CompilerGenerated]
		private sealed class FGEDGOOKKDI
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400002D")]
			public ManagedTexture <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400002E")]
			public JKDLHIKOPNK textureMemory;

			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578A40", VA = "0x180579840")]
			public FGEDGOOKKDI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x4FC5900", Offset = "0x4FC4B00", VA = "0x184FC5900")]
			internal void <GetManagedTexture>b__0()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000E")]
		[CompilerGenerated]
		private sealed class KIGKEPEPFNO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400002F")]
			public int quality;

			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578A40", VA = "0x180579840")]
			public KIGKEPEPFNO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x4FC6FB0", Offset = "0x4FC61B0", VA = "0x184FC6FB0")]
			internal byte[] <EncodeToJPG>b__0(Texture2D t2d)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000F")]
		[CompilerGenerated]
		private sealed class BMMMDEDOMFJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000030")]
			public RenderTexture tempRenderTexture;

			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578A40", VA = "0x180579840")]
			public BMMMDEDOMFJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x4FC5210", Offset = "0x4FC4410", VA = "0x184FC5210")]
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
		private global::IAGOKENNLHI<Texture2D> _cpuSidePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private BHDNJEJNKJN _memTexture;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private global::IAGOKENNLHI<byte[]> _jpgEncodePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private byte[] _jpgBytes;

		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public const int DEFAULT_JPG_QUALITY = 80;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private global::IAGOKENNLHI<byte[]> _pngEncodePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private byte[] _pngBytes;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public bool UsePalette
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x577160", Offset = "0x576360", VA = "0x180577160")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public RenderTexture LastRenderTexture
		{
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x574E70", Offset = "0x574070", VA = "0x180574E70")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x576710", Offset = "0x575910", VA = "0x180576710")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		private BHDNJEJNKJN memoryTexture
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x4FC7D00", Offset = "0x4FC6F00", VA = "0x184FC7D00")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x4FC7C50", Offset = "0x4FC6E50", VA = "0x184FC7C50")]
		public ManagedTexture(string HKLPIGDOLHA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x4FC7CA0", Offset = "0x4FC6EA0", VA = "0x184FC7CA0")]
		public ManagedTexture(string HKLPIGDOLHA, bool NKADGGMMEPL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x4FC7990", Offset = "0x4FC6B90", VA = "0x184FC7990")]
		public void PCACFLKJPIC(RenderTexture EPDBKCHKEGL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x4FC6FE0", Offset = "0x4FC61E0", VA = "0x184FC6FE0")]
		public global::IAGOKENNLHI<byte[]> GEBBKLDBMNP(bool CMJKJPDNFBO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x4FC79C0", Offset = "0x4FC6BC0", VA = "0x184FC79C0")]
		public global::IAGOKENNLHI<Texture2D> PMDBOEPAEND(JKDLHIKOPNK JDBDEJAGNAD, bool MJEJNAABKJM = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x4FC77E0", Offset = "0x4FC69E0", VA = "0x184FC77E0")]
		public global::IAGOKENNLHI<byte[]> PBJEKAAGDKL(bool MJEJNAABKJM = false, int DAENJNDDCOC = 80)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x4FC74F0", Offset = "0x4FC66F0", VA = "0x184FC74F0")]
		public global::IAGOKENNLHI<byte[]> GLLAFNHDPON(bool MJEJNAABKJM = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x4FC7000", Offset = "0x4FC6200", VA = "0x184FC7000")]
		private static global::IAGOKENNLHI<Texture2D> GFAPGPMIJEG(string HKLPIGDOLHA, RenderTexture EPDBKCHKEGL, ref Texture2D PEDGIAIFNOK, bool MJEJNAABKJM, JKDLHIKOPNK NCILNLCJOIO = JKDLHIKOPNK.GPU)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x4FC7720", Offset = "0x4FC6920", VA = "0x184FC7720")]
		public void NJNHNBBBMPP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x4FC6FD0", Offset = "0x4FC61D0", VA = "0x184FC6FD0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x4FC7680", Offset = "0x4FC6880", VA = "0x184FC7680")]
		[CompilerGenerated]
		private global::IAGOKENNLHI<byte[]> IKNGAHBAGMA(Texture2D MILEJIBDPAK)
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public static class NKKPAGLHPOB
{
	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x4FC7DA0", Offset = "0x4FC6FA0", VA = "0x184FC7DA0")]
	public static RenderTexture EIHGBDNGCJC(int MLMOINPPPFB, int LDAGEPJGJAH, int LNPLMCEIBJD, Camera OEFMGGGKAIL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x4FC7F10", Offset = "0x4FC7110", VA = "0x184FC7F10")]
	public static void IHMNHPFJKNB(RenderTexture EPDBKCHKEGL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class HOGIAELLJGO
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public class APJGGHJCPPG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public int PIDBKIOIGJG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public int BHNHKBKLDOH;

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x1E805E0", Offset = "0x1E7F7E0", VA = "0x181E805E0")]
		public APJGGHJCPPG(int MAABPLEGKJM, int BEHJIIABFNP)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	private enum EPBCCDJLAPE
	{
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		Point,
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		Bilinear,
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		Average
	}

	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private static Color[] DPAOOLAPAGE;

	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private static Color[] LECHHNOKKJD;

	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private static int BBPCEFEBLNB;

	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private static float FPDJKIMJBNL;

	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private static float CKPIKEBOAII;

	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private static int JEALHHBPKLO;

	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private static int ONDNMFAJPGH;

	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private static Mutex BFJNPMIJBAD;

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x4FC67A0", Offset = "0x4FC59A0", VA = "0x184FC67A0")]
	public static void GCNMKKAMNNP(Texture2D JMACOFIONHL, int GGMPHPACBGF, int MAOIDNNDANL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x4FC62F0", Offset = "0x4FC54F0", VA = "0x184FC62F0")]
	private static void EIFJKEDKILO(Texture2D JMACOFIONHL, int GGMPHPACBGF, int MAOIDNNDANL, EPBCCDJLAPE PMPBCPKJNBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x4FC5CE0", Offset = "0x4FC4EE0", VA = "0x184FC5CE0")]
	public static void BJMHPIPFMAA(object CEEAMODAEEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x4FC6980", Offset = "0x4FC5B80", VA = "0x184FC6980")]
	public static void KJOLGGFEPPF(object CEEAMODAEEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x4FC67C0", Offset = "0x4FC59C0", VA = "0x184FC67C0")]
	private static Color IHOJHCDCNKM(int NJBKHCBPNDB, int CBNFMHDNCPP, float FPDJKIMJBNL, float CKPIKEBOAII)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x4FC6B60", Offset = "0x4FC5D60", VA = "0x184FC6B60")]
	public static void PAGPHDEKICM(object CEEAMODAEEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x4FC6200", Offset = "0x4FC5400", VA = "0x184FC6200")]
	private static Color ECJCAHKJHIF(Color MAOLMNHFELO, Color EIIFKIPGAHA, float PNLMJAPAHBD)
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
