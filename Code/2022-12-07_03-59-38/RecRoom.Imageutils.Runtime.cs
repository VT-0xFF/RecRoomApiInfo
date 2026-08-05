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
		[Cpp2IlInjected.Address(RVA = "0x6075C60", Offset = "0x6074860", VA = "0x186075C60")]
		public CubeMapGenerator()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public enum PLCNJFEDCIK
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
public interface MIEDFLEOKJG
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	PLCNJFEDCIK GPKBPIFDNHH
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class GIAAPMNBKON
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
			[Cpp2IlInjected.Address(RVA = "0x60788B0", Offset = "0x60774B0", VA = "0x1860788B0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x60788A0", Offset = "0x60774A0", VA = "0x1860788A0")]
		public Resolution(uint CCOKEBDEHII)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x702C80", Offset = "0x701880", VA = "0x180702C80")]
		public Resolution(uint CCOKEBDEHII, uint DEGPJNBMBCB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x60787B0", Offset = "0x60773B0", VA = "0x1860787B0")]
		public static Resolution ANJCOCCMGMF(Resolution[] IEKDCEOMNKH, Resolution OCEFHKHNJGC, int NPAKDANEKMP)
		{
			return default(Resolution);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public class MCMOEPILDKD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private readonly Resolution KIKODMGJMEE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private Resolution? KNKLDAJFJPJ;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public uint CCOKEBDEHII
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x60777F0", Offset = "0x60763F0", VA = "0x1860777F0")]
			get
			{
				return default(uint);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public uint DEGPJNBMBCB
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x6077800", Offset = "0x6076400", VA = "0x186077800")]
			get
			{
				return default(uint);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public Resolution IHJGIHBPCMI
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x6077470", Offset = "0x6076070", VA = "0x186077470")]
			get
			{
				return default(Resolution);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x1499FB0", Offset = "0x1498BB0", VA = "0x181499FB0")]
		public MCMOEPILDKD(Resolution KIKODMGJMEE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x6077650", Offset = "0x6076250", VA = "0x186077650")]
		private static Resolution DLDBIGDDBEH(Resolution KNKLDAJFJPJ, PLCNJFEDCIK BKGGKNEKFON)
		{
			return default(Resolution);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public static class LGBOLDOADJA
	{
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public static readonly Resolution OEFLDILGGJE;

		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public static readonly Resolution KJMIMODMFKC;

		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public static readonly Resolution IDJCGAHOABL;

		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public static readonly Resolution BGNDIANGDPH;

		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public static readonly Resolution HIMPDCHPFNF;

		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public static readonly Resolution HGOJNGOFFEF;

		[Cpp2IlInjected.Token(Token = "0x4000014")]
		internal static readonly Resolution[] JPHGCIJCNCK;
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public static class BCDIKKIGGNN
	{
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public static readonly Resolution LDHNFDLJDIP;

		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public static readonly Resolution EHOMPKKPNMI;

		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public static readonly Resolution KAHKMMEELKA;

		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public static readonly Resolution FLKFBICOHAF;

		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public static readonly Resolution OJMBJLNCONB;

		[Cpp2IlInjected.Token(Token = "0x400001A")]
		internal static readonly Resolution[] JPHGCIJCNCK;

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x60758A0", Offset = "0x60744A0", VA = "0x1860758A0")]
		public static Resolution OADDHDFFLMH(uint EFDIFNHGBMG)
		{
			return default(Resolution);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public static readonly Resolution PFKJBOGAEDA;

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x6076D50", Offset = "0x6075950", VA = "0x186076D50")]
	public static bool HNMLNACDDIO(uint LLDLHKJPMDI)
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
		public enum MPHIKMBEHLL : byte
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
		private class FEHEEBGBDLF : IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			private string MKPDFAEIFFO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			public Texture2D AEGBHNONCIJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400002C")]
			public MPHIKMBEHLL DPKHHAAGGGH;

			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x6075D50", Offset = "0x6074950", VA = "0x186075D50")]
			public FEHEEBGBDLF(string MKPDFAEIFFO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x739B70", Offset = "0x738770", VA = "0x180739B70")]
			public FEHEEBGBDLF(string MKPDFAEIFFO, Texture2D BMIKEAOOLDE, MPHIKMBEHLL KOIHBLOGOLE)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x6075D10", Offset = "0x6074910", VA = "0x186075D10", Slot = "4")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000D")]
		[CompilerGenerated]
		private sealed class NDBNIOFALPC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400002D")]
			public ManagedTexture <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400002E")]
			public MPHIKMBEHLL textureMemory;

			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x68ACD0", Offset = "0x6898D0", VA = "0x18068ACD0")]
			public NDBNIOFALPC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x6078770", Offset = "0x6077370", VA = "0x186078770")]
			internal void <GetManagedTexture>b__0()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000E")]
		[CompilerGenerated]
		private sealed class LFOCCJAGLJN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400002F")]
			public int quality;

			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x68ACD0", Offset = "0x6898D0", VA = "0x18068ACD0")]
			public LFOCCJAGLJN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x60771D0", Offset = "0x6075DD0", VA = "0x1860771D0")]
			internal byte[] <EncodeToJPG>b__0(Texture2D t2d)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000F")]
		[CompilerGenerated]
		private sealed class FBOHHKCOIDG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000030")]
			public RenderTexture tempRenderTexture;

			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x68ACD0", Offset = "0x6898D0", VA = "0x18068ACD0")]
			public FBOHHKCOIDG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x6075C80", Offset = "0x6074880", VA = "0x186075C80")]
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
		private global::GANDAICPPHN<Texture2D> _cpuSidePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private FEHEEBGBDLF _memTexture;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private global::GANDAICPPHN<byte[]> _jpgEncodePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private byte[] _jpgBytes;

		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public const int DEFAULT_JPG_QUALITY = 80;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private global::GANDAICPPHN<byte[]> _pngEncodePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private byte[] _pngBytes;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public bool UsePalette
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x711D10", Offset = "0x710910", VA = "0x180711D10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public RenderTexture LastRenderTexture
		{
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x698130", Offset = "0x696D30", VA = "0x180698130")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x6BA2B0", Offset = "0x6B8EB0", VA = "0x1806BA2B0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		private FEHEEBGBDLF memoryTexture
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x60786D0", Offset = "0x60772D0", VA = "0x1860786D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x6078680", Offset = "0x6077280", VA = "0x186078680")]
		public ManagedTexture(string MKPDFAEIFFO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x6078620", Offset = "0x6077220", VA = "0x186078620")]
		public ManagedTexture(string MKPDFAEIFFO, bool DBPGFGJAEKP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x6078430", Offset = "0x6077030", VA = "0x186078430")]
		public void NOJCIFHLGHD(RenderTexture HCMEPCIHKGF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x6078160", Offset = "0x6076D60", VA = "0x186078160")]
		public global::GANDAICPPHN<byte[]> JHDIBGCKJBM(bool JEFBMGIEAFM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x6077DB0", Offset = "0x60769B0", VA = "0x186077DB0")]
		public global::GANDAICPPHN<Texture2D> HFBLAKNBGCC(MPHIKMBEHLL KOIHBLOGOLE, bool KJOIIIMJCFM = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x6078180", Offset = "0x6076D80", VA = "0x186078180")]
		public global::GANDAICPPHN<byte[]> KLIGCEGBALG(bool KJOIIIMJCFM = false, int GPJKIEHFKJI = 80)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x6078460", Offset = "0x6077060", VA = "0x186078460")]
		public global::GANDAICPPHN<byte[]> PPLOAICGOMH(bool KJOIIIMJCFM = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x6077820", Offset = "0x6076420", VA = "0x186077820")]
		private static global::GANDAICPPHN<Texture2D> BOBDMFLOGBL(string MKPDFAEIFFO, RenderTexture HCMEPCIHKGF, ref Texture2D JCANLIGIELL, bool KJOIIIMJCFM, MPHIKMBEHLL JGIJLJMDOOM = MPHIKMBEHLL.GPU)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x60780A0", Offset = "0x6076CA0", VA = "0x1860780A0")]
		public void HGJCLACEDDG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x6077DA0", Offset = "0x60769A0", VA = "0x186077DA0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x6078380", Offset = "0x6076F80", VA = "0x186078380")]
		[CompilerGenerated]
		private global::GANDAICPPHN<byte[]> NFACCDCAMGA(Texture2D ELLGOPPDMOO)
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public static class JIIKMJMGPOA
{
	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x6076FB0", Offset = "0x6075BB0", VA = "0x186076FB0")]
	public static RenderTexture COJHDDGDLON(int EFDIFNHGBMG, int KEJDIAAOACK, int NDIGJOEOGLI, Camera OJDPCJPPDJC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x6077160", Offset = "0x6075D60", VA = "0x186077160")]
	public static void NGKJBPNGNIL(RenderTexture HCMEPCIHKGF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class FKIIJFHLGEF
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public class AHDHDOFBIBJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public int IOMMLLJBIGB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public int IEPBHGAJDBG;

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0xCB04F0", Offset = "0xCAF0F0", VA = "0x180CB04F0")]
		public AHDHDOFBIBJ(int LNLNOFIIOPK, int MPIBPKBJNBB)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	private enum LKNAGOBCEGD
	{
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		Point,
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		Bilinear,
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		Average
	}

	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private static Color[] EPEAACICJDI;

	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private static Color[] ONBBJJDLJLJ;

	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private static int OCOLKLFLIPF;

	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private static float JECJFKBPMIA;

	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private static float BPAEEDJFEHK;

	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private static int EAPOMJAJDIE;

	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private static int CPPAHCINGLI;

	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private static Mutex AEBBDNPFEIH;

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x60768E0", Offset = "0x60754E0", VA = "0x1860768E0")]
	public static void LNPBMBBIKBN(Texture2D ABMLFGGBELB, int GGGMAIBOMJM, int IFEJNLKAMGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x60763F0", Offset = "0x6074FF0", VA = "0x1860763F0")]
	private static void CPCMONNJGFC(Texture2D ABMLFGGBELB, int GGGMAIBOMJM, int IFEJNLKAMGM, LKNAGOBCEGD PLHHHMBMEGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x6075DA0", Offset = "0x60749A0", VA = "0x186075DA0")]
	public static void AKCFFAKNLMN(object AOEMDAGAALP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x6076AA0", Offset = "0x60756A0", VA = "0x186076AA0")]
	public static void PANKAONLCLO(object AOEMDAGAALP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x6076900", Offset = "0x6075500", VA = "0x186076900")]
	private static Color MINCGJFHHBJ(int CCOKEBDEHII, int DEGPJNBMBCB, float JECJFKBPMIA, float BPAEEDJFEHK)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x6076220", Offset = "0x6074E20", VA = "0x186076220")]
	public static void APKHHCDCBLO(object AOEMDAGAALP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x6076C70", Offset = "0x6075870", VA = "0x186076C70")]
	private static Color PGINCJJOPHC(Color IFIFDGHDJOB, Color BLHCJLODMHH, float NENFOEKGNGK)
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
