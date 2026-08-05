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
		[Cpp2IlInjected.Address(RVA = "0x4D5FB10", Offset = "0x4D5EB10", VA = "0x184D5FB10")]
		public CubeMapGenerator()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public enum DKEIPFJAJOP
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
public interface KMCBEGLNFFB
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	DKEIPFJAJOP MPDKOCKNDNB
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class KHHGHMCJMLC
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
			[Cpp2IlInjected.Address(RVA = "0x4D629E0", Offset = "0x4D619E0", VA = "0x184D629E0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x4D629D0", Offset = "0x4D619D0", VA = "0x184D629D0")]
		public Resolution(uint FMMKCBAOFKA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x9F6AF0", Offset = "0x9F5AF0", VA = "0x1809F6AF0")]
		public Resolution(uint FMMKCBAOFKA, uint HPNMBFKMIJK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x4D62880", Offset = "0x4D61880", VA = "0x184D62880")]
		public static Resolution GFBHEMJEPHD(Resolution[] DGPNIJFKAFK, Resolution CALJLIPKAJK, int ECNDMFKNELO)
		{
			return default(Resolution);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public class GFIMFPCJACH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private readonly Resolution OIKJLINBHGG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private Resolution? ENJBHDJNLDC;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public uint FMMKCBAOFKA
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x4D5FF60", Offset = "0x4D5EF60", VA = "0x184D5FF60")]
			get
			{
				return default(uint);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public uint HPNMBFKMIJK
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x4D5FB70", Offset = "0x4D5EB70", VA = "0x184D5FB70")]
			get
			{
				return default(uint);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public Resolution PDCLOMKNDFK
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x4D5FB90", Offset = "0x4D5EB90", VA = "0x184D5FB90")]
			get
			{
				return default(Resolution);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0xC16430", Offset = "0xC15430", VA = "0x180C16430")]
		public GFIMFPCJACH(Resolution OIKJLINBHGG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x4D5FD90", Offset = "0x4D5ED90", VA = "0x184D5FD90")]
		private static Resolution FPOEBAIMCGM(Resolution ENJBHDJNLDC, DKEIPFJAJOP JFHLDHDBAJE)
		{
			return default(Resolution);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public static class MJOALMJDINK
	{
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public static readonly Resolution MKLKPNGGGKB;

		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public static readonly Resolution FLDINPBPECO;

		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public static readonly Resolution NAENPIAJMPN;

		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public static readonly Resolution LLAABMKAMMB;

		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public static readonly Resolution CKCBGEFFDNL;

		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public static readonly Resolution OAGFMFOAKHO;

		[Cpp2IlInjected.Token(Token = "0x4000014")]
		internal static readonly Resolution[] ONICAHFJPIK;
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public static class PDBPMPMPIFB
	{
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public static readonly Resolution MHICJJHIHBM;

		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public static readonly Resolution BGKNMONDMOF;

		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public static readonly Resolution CIBGIIGNOMN;

		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public static readonly Resolution LHNHAIFAIPD;

		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public static readonly Resolution JHCKCKDBPGG;

		[Cpp2IlInjected.Token(Token = "0x400001A")]
		internal static readonly Resolution[] ONICAHFJPIK;

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x4D62300", Offset = "0x4D61300", VA = "0x184D62300")]
		public static Resolution IFDFDICJOGI(uint GPPALIDPAOJ)
		{
			return default(Resolution);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public static readonly Resolution KPBKJCMJMEM;

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x4D60FF0", Offset = "0x4D5FFF0", VA = "0x184D60FF0")]
	public static bool FMGFNPOCGCE(uint PKIJBGFOEBK)
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
		public enum JPBIKFJKJGG : byte
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
		private class ODONKHGHJMI : IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			private string JIEIIEKPPIJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			public Texture2D DDMKGFIAECO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400002C")]
			public JPBIKFJKJGG JGMMNGHCOCH;

			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x4D622B0", Offset = "0x4D612B0", VA = "0x184D622B0")]
			public ODONKHGHJMI(string JIEIIEKPPIJ)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x1BD4C40", Offset = "0x1BD3C40", VA = "0x181BD4C40")]
			public ODONKHGHJMI(string JIEIIEKPPIJ, Texture2D LLCEBHEOINP, JPBIKFJKJGG HAEMLPCPIAF)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x4D62270", Offset = "0x4D61270", VA = "0x184D62270", Slot = "4")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000D")]
		[CompilerGenerated]
		private sealed class FLIEMJCMHEN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400002D")]
			public ManagedTexture <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400002E")]
			public JPBIKFJKJGG textureMemory;

			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x54F0C0", Offset = "0x54E0C0", VA = "0x18054F0C0")]
			public FLIEMJCMHEN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x4D5FB30", Offset = "0x4D5EB30", VA = "0x184D5FB30")]
			internal void <GetManagedTexture>b__0()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000E")]
		[CompilerGenerated]
		private sealed class GGOOEJCHPLO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400002F")]
			public int quality;

			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x54F0C0", Offset = "0x54E0C0", VA = "0x18054F0C0")]
			public GGOOEJCHPLO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x4D5FF70", Offset = "0x4D5EF70", VA = "0x184D5FF70")]
			internal byte[] <EncodeToJPG>b__0(Texture2D t2d)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000F")]
		[CompilerGenerated]
		private sealed class BFDHDNNOHPJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000030")]
			public RenderTexture tempRenderTexture;

			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x54F0C0", Offset = "0x54E0C0", VA = "0x18054F0C0")]
			public BFDHDNNOHPJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x4D5FA80", Offset = "0x4D5EA80", VA = "0x184D5FA80")]
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
		private global::PKODKNLJGEP<Texture2D> _cpuSidePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private ODONKHGHJMI _memTexture;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private global::PKODKNLJGEP<byte[]> _jpgEncodePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private byte[] _jpgBytes;

		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public const int DEFAULT_JPG_QUALITY = 80;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private global::PKODKNLJGEP<byte[]> _pngEncodePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private byte[] _pngBytes;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public bool UsePalette
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x5550C0", Offset = "0x5540C0", VA = "0x1805550C0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public RenderTexture LastRenderTexture
		{
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x584B30", Offset = "0x583B30", VA = "0x180584B30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x584EA0", Offset = "0x583EA0", VA = "0x180584EA0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		private ODONKHGHJMI memoryTexture
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x4D621D0", Offset = "0x4D611D0", VA = "0x184D621D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x4D62120", Offset = "0x4D61120", VA = "0x184D62120")]
		public ManagedTexture(string JIEIIEKPPIJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x4D62170", Offset = "0x4D61170", VA = "0x184D62170")]
		public ManagedTexture(string JIEIIEKPPIJ, bool BDJLKCEPOFI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x4D61F40", Offset = "0x4D60F40", VA = "0x184D61F40")]
		public void NKHIBIOHJBP(RenderTexture AGNICJKNAMO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x4D618A0", Offset = "0x4D608A0", VA = "0x184D618A0")]
		public global::PKODKNLJGEP<byte[]> FCCOANLKFNH(bool IDDDJHNHDCH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x4D61600", Offset = "0x4D60600", VA = "0x184D61600")]
		public global::PKODKNLJGEP<Texture2D> AIMBIGCMMHN(JPBIKFJKJGG HAEMLPCPIAF, bool PDMDGABPLCC = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x4D61F70", Offset = "0x4D60F70", VA = "0x184D61F70")]
		public global::PKODKNLJGEP<byte[]> PEFIHGFONIM(bool PDMDGABPLCC = false, int OOMJEPHHFML = 80)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x4D618C0", Offset = "0x4D608C0", VA = "0x184D618C0")]
		public global::PKODKNLJGEP<byte[]> GFOFNNMADMF(bool PDMDGABPLCC = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x4D61A50", Offset = "0x4D60A50", VA = "0x184D61A50")]
		private static global::PKODKNLJGEP<Texture2D> JFCIBIHEGCP(string JIEIIEKPPIJ, RenderTexture AGNICJKNAMO, ref Texture2D BGHOOPDPPLL, bool PDMDGABPLCC, JPBIKFJKJGG PNGLMCEBOPL = JPBIKFJKJGG.GPU)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x4D614A0", Offset = "0x4D604A0", VA = "0x184D614A0")]
		public void AHMCNMHCMIE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x4D61890", Offset = "0x4D60890", VA = "0x184D61890", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x4D61560", Offset = "0x4D60560", VA = "0x184D61560")]
		[CompilerGenerated]
		private global::PKODKNLJGEP<byte[]> AIIPEPACALN(Texture2D PHIJFDCFGAH)
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public static class PEBMPPLKNBN
{
	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x4D626A0", Offset = "0x4D616A0", VA = "0x184D626A0")]
	public static RenderTexture MDPDLEJMBJI(int GPPALIDPAOJ, int HBKDNCCDNCO, int LOOFANMHKBL, Camera CDJBGAEAJNM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x4D62810", Offset = "0x4D61810", VA = "0x184D62810")]
	public static void PMKHILAKKAD(RenderTexture AGNICJKNAMO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class HOADENFGKGP
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public class GDMCGCIBIGG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public int ICAAAAPMEKA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public int HGCGODPLIAK;

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x1A547C0", Offset = "0x1A537C0", VA = "0x181A547C0")]
		public GDMCGCIBIGG(int MGKAPLGAIOL, int OADAOAPKMCI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	private enum NHOIHEAKJDK
	{
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		Point,
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		Bilinear,
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		Average
	}

	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private static Color[] NKJBHNMNAKG;

	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private static Color[] IIFPPDBIFIF;

	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private static int ENPBHFNIBIC;

	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private static float GHNPFFAOBIN;

	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private static float BDCCAMGDOGA;

	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private static int MPMDADJEMKF;

	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private static int JCHGEFCMHBP;

	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private static Mutex FHGKHKBNAPD;

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x4D60FD0", Offset = "0x4D5FFD0", VA = "0x184D60FD0")]
	public static void OMGDCFMHHIO(Texture2D GOCGDEHFMFP, int NIJCODHFBHK, int LKHOJFIGGAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x4D5FF90", Offset = "0x4D5EF90", VA = "0x184D5FF90")]
	private static void AIONFMBGOKI(Texture2D GOCGDEHFMFP, int NIJCODHFBHK, int LKHOJFIGGAK, NHOIHEAKJDK EMKPCNJLLFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x4D60440", Offset = "0x4D5F440", VA = "0x184D60440")]
	public static void DBGOLHFEFOC(object OMILIKJDDEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x4D60C30", Offset = "0x4D5FC30", VA = "0x184D60C30")]
	public static void JIKACLFFEDM(object OMILIKJDDEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x4D60E10", Offset = "0x4D5FE10", VA = "0x184D60E10")]
	private static Color JLECCIJNDID(int FMMKCBAOFKA, int HPNMBFKMIJK, float GHNPFFAOBIN, float BDCCAMGDOGA)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x4D60A50", Offset = "0x4D5FA50", VA = "0x184D60A50")]
	public static void IFKLCMLKDAL(object OMILIKJDDEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x4D60960", Offset = "0x4D5F960", VA = "0x184D60960")]
	private static Color EKNBMNJLLJM(Color JPFPFPHBAGN, Color LCGPFILPAIH, float MFBIHMKFNKA)
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
