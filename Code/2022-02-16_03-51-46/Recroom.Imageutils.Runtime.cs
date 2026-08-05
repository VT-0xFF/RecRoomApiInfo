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
		[Cpp2IlInjected.Address(RVA = "0x1B8A9B0", Offset = "0x1B891B0", VA = "0x181B8A9B0")]
		public CubeMapGenerator()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public enum AFKPIHLBLDC
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
public interface KFCOPHLHCFI
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	AFKPIHLBLDC IJKDELNFNOB
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class BLJNFBMKDDD
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
			[Cpp2IlInjected.Address(RVA = "0x1B8C5E0", Offset = "0x1B8ADE0", VA = "0x181B8C5E0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x1B8C5D0", Offset = "0x1B8ADD0", VA = "0x181B8C5D0")]
		public Resolution(uint ODDCIAGBNFM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x6EB420", Offset = "0x6E9C20", VA = "0x1806EB420")]
		public Resolution(uint ODDCIAGBNFM, uint AAHOONHJJFO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x1B8C480", Offset = "0x1B8AC80", VA = "0x181B8C480")]
		public static Resolution AONBFAKNDIH(Resolution[] AALMLIAIBFL, Resolution IMLJOADLHOA, int FNNDABKNFHO)
		{
			return default(Resolution);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public class DOHLCDJCOAP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private readonly Resolution DBHNGIKDGKG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private Resolution? KCCPEODFAAM;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public uint ODDCIAGBNFM
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x1B8ADE0", Offset = "0x1B895E0", VA = "0x181B8ADE0")]
			get
			{
				return default(uint);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public uint AAHOONHJJFO
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x1B8ADC0", Offset = "0x1B895C0", VA = "0x181B8ADC0")]
			get
			{
				return default(uint);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public Resolution HNPKEAGFKCM
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x1B8A9F0", Offset = "0x1B891F0", VA = "0x181B8A9F0")]
			get
			{
				return default(Resolution);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0xB5BDD0", Offset = "0xB5A5D0", VA = "0x180B5BDD0")]
		public DOHLCDJCOAP(Resolution DBHNGIKDGKG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x1B8ABF0", Offset = "0x1B893F0", VA = "0x181B8ABF0")]
		private static Resolution HBLLBMENFAD(Resolution KCCPEODFAAM, AFKPIHLBLDC PKPECBAKHEO)
		{
			return default(Resolution);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public static class JNIPMFEDACC
	{
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public static readonly Resolution MJJLFBHFBMO;

		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public static readonly Resolution KCCHOHJBOIH;

		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public static readonly Resolution IKFGMIFCHKK;

		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public static readonly Resolution LKPCAAACDMK;

		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public static readonly Resolution AGGNFOGBENI;

		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public static readonly Resolution CNFOFAIKLIN;

		[Cpp2IlInjected.Token(Token = "0x4000014")]
		internal static readonly Resolution[] DODBNJLPDLA;
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public static class EGPNGEDGAMH
	{
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public static readonly Resolution JDFGAGPODNA;

		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public static readonly Resolution KJHFFEHACFJ;

		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public static readonly Resolution NFBPOOAMEEB;

		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public static readonly Resolution HGLEOHKHFHO;

		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public static readonly Resolution GMCKAKGKDMM;

		[Cpp2IlInjected.Token(Token = "0x400001A")]
		internal static readonly Resolution[] DODBNJLPDLA;

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x1B8AE30", Offset = "0x1B89630", VA = "0x181B8AE30")]
		public static Resolution HJIJFPKPNEA(uint NDFHPJNHGMJ)
		{
			return default(Resolution);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public static readonly Resolution KFMCCMKMMFB;

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x1B89710", Offset = "0x1B87F10", VA = "0x181B89710")]
	public static bool DDGNDBJNLPO(uint HGGACEHKHOH)
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
		public enum ABPEFPPILNO : byte
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
		private class OCOGABBEMDM : IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			private string CEAFHMOKOGD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			public Texture2D KAEBLKBJCFF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400002C")]
			public ABPEFPPILNO GFHFPCKMKGH;

			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x1B8C430", Offset = "0x1B8AC30", VA = "0x181B8C430")]
			public OCOGABBEMDM(string CEAFHMOKOGD)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0xE69070", Offset = "0xE67870", VA = "0x180E69070")]
			public OCOGABBEMDM(string CEAFHMOKOGD, Texture2D HGIAFGGFLKH, ABPEFPPILNO BBJEMLFIMFN)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x1B8C3F0", Offset = "0x1B8ABF0", VA = "0x181B8C3F0", Slot = "4")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000D")]
		[CompilerGenerated]
		private sealed class EAMLHJHGHHN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400002D")]
			public ManagedTexture <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400002E")]
			public ABPEFPPILNO textureMemory;

			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x507000", Offset = "0x505800", VA = "0x180507000")]
			public EAMLHJHGHHN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x1B8ADF0", Offset = "0x1B895F0", VA = "0x181B8ADF0")]
			internal void <GetManagedTexture>b__0()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000E")]
		[CompilerGenerated]
		private sealed class DHFAAEOAEDF
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400002F")]
			public int quality;

			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x507000", Offset = "0x505800", VA = "0x180507000")]
			public DHFAAEOAEDF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x1B8A9D0", Offset = "0x1B891D0", VA = "0x181B8A9D0")]
			internal byte[] <EncodeToJPG>b__0(Texture2D t2d)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000F")]
		[CompilerGenerated]
		private sealed class AOLLEGKHHHJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000030")]
			public RenderTexture tempRenderTexture;

			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x507000", Offset = "0x505800", VA = "0x180507000")]
			public AOLLEGKHHHJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x1B89680", Offset = "0x1B87E80", VA = "0x181B89680")]
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
		private global::KGPLAJBADNH<Texture2D> _cpuSidePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private OCOGABBEMDM _memTexture;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private global::KGPLAJBADNH<byte[]> _jpgEncodePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private byte[] _jpgBytes;

		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public const int DEFAULT_JPG_QUALITY = 80;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private global::KGPLAJBADNH<byte[]> _pngEncodePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private byte[] _pngBytes;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public bool UsePalette
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x55A0F0", Offset = "0x5588F0", VA = "0x18055A0F0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public RenderTexture LastRenderTexture
		{
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x50B480", Offset = "0x509C80", VA = "0x18050B480")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x50E510", Offset = "0x50CD10", VA = "0x18050E510")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		private OCOGABBEMDM memoryTexture
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x1B8C350", Offset = "0x1B8AB50", VA = "0x181B8C350")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x1B8C300", Offset = "0x1B8AB00", VA = "0x181B8C300")]
		public ManagedTexture(string CEAFHMOKOGD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x1B8C2A0", Offset = "0x1B8AAA0", VA = "0x181B8C2A0")]
		public ManagedTexture(string CEAFHMOKOGD, bool GOBKBAIGMDI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x1B8B7E0", Offset = "0x1B89FE0", VA = "0x181B8B7E0")]
		public void IOONKDEFFEJ(RenderTexture LHPNJODAKHL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x1B8B630", Offset = "0x1B89E30", VA = "0x181B8B630")]
		public global::KGPLAJBADNH<byte[]> FIFPEANNCHH(bool JENFBHNJLAB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x1B8BD00", Offset = "0x1B8A500", VA = "0x181B8BD00")]
		public global::KGPLAJBADNH<Texture2D> LCMIHBNNMEM(ABPEFPPILNO BBJEMLFIMFN, bool ANFHHMIJPLD = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x1B8C0F0", Offset = "0x1B8A8F0", VA = "0x181B8C0F0")]
		public global::KGPLAJBADNH<byte[]> PEAPLJJAAKJ(bool ANFHHMIJPLD = false, int DLGKNGIHEPN = 80)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x1B8B650", Offset = "0x1B89E50", VA = "0x181B8B650")]
		public global::KGPLAJBADNH<byte[]> GNAOFMOKPDO(bool ANFHHMIJPLD = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x1B8B810", Offset = "0x1B8A010", VA = "0x181B8B810")]
		private static global::KGPLAJBADNH<Texture2D> JFIAHOBKGMA(string CEAFHMOKOGD, RenderTexture LHPNJODAKHL, ref Texture2D HDHKPDPFMOF, bool ANFHHMIJPLD, ABPEFPPILNO FDLGABCFMJL = ABPEFPPILNO.GPU)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x1B8BF90", Offset = "0x1B8A790", VA = "0x181B8BF90")]
		public void LJNHPAAGPAB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x1B8B620", Offset = "0x1B89E20", VA = "0x181B8B620", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x1B8C050", Offset = "0x1B8A850", VA = "0x181B8C050")]
		[CompilerGenerated]
		private global::KGPLAJBADNH<byte[]> NMGHPOBAMLH(Texture2D IGCHNGLBENM)
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public static class JENADFELJGD
{
	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x1B8B240", Offset = "0x1B89A40", VA = "0x181B8B240")]
	public static RenderTexture DJHNICKGADB(int NDFHPJNHGMJ, int GGKKIKOPNIA, int PKLAHCEIMIH, Camera MHBKJKHFPHB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x1B8B1D0", Offset = "0x1B899D0", VA = "0x181B8B1D0")]
	public static void BACPAMLGPPP(RenderTexture LHPNJODAKHL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class CODNEAGFALF
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public class CDFMKGAICJM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public int OJOGGFGEONO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public int KDNIOOOEPJF;

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x636D90", Offset = "0x635590", VA = "0x180636D90")]
		public CDFMKGAICJM(int MNNJGJLHIFH, int BCENOHLAIEF)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	private enum NMLNKEKAEKH
	{
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		Point,
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		Bilinear,
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		Average
	}

	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private static Color[] LGDOIHNPDEI;

	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private static Color[] GHDKDOLJNNC;

	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private static int AEFBFMJCCOH;

	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private static float GDGILCIAMJL;

	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private static float PIGFJFHOKDD;

	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private static int PFGONMOGCAG;

	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private static int AKBLACEBJKJ;

	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private static Mutex LACFGGLEJDD;

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x1B89B30", Offset = "0x1B88330", VA = "0x181B89B30")]
	public static void EILAHBFFAHC(Texture2D EMALPPIPNBL, int EJFKOCNFKGG, int AJJJJCFMPBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x1B89E20", Offset = "0x1B88620", VA = "0x181B89E20")]
	private static void KAFKNHADJNF(Texture2D EMALPPIPNBL, int EJFKOCNFKGG, int AJJJJCFMPBB, NMLNKEKAEKH KGMFNKHHAAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x1B8A2D0", Offset = "0x1B88AD0", VA = "0x181B8A2D0")]
	public static void OGBNIHHDEIC(object JGHAOGLDGDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x1B89950", Offset = "0x1B88150", VA = "0x181B89950")]
	public static void ECJFKIEHCOG(object JGHAOGLDGDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x1B8A7F0", Offset = "0x1B88FF0", VA = "0x181B8A7F0")]
	private static Color OJOIHDCBJDA(int ODDCIAGBNFM, int AAHOONHJJFO, float GDGILCIAMJL, float PIGFJFHOKDD)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x1B89B50", Offset = "0x1B88350", VA = "0x181B89B50")]
	public static void EMMNPKIEGGC(object JGHAOGLDGDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x1B89D30", Offset = "0x1B88530", VA = "0x181B89D30")]
	private static Color JGOBFNIMEOJ(Color EGIMFBPDJFC, Color AJLKKINIJIC, float HNCFAALBJCG)
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
