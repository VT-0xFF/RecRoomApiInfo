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
		[Cpp2IlInjected.Address(RVA = "0x4ED45E0", Offset = "0x4ED2DE0", VA = "0x184ED45E0")]
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
			[Cpp2IlInjected.Address(RVA = "0x4ED74B0", Offset = "0x4ED5CB0", VA = "0x184ED74B0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x4ED74A0", Offset = "0x4ED5CA0", VA = "0x184ED74A0")]
		public Resolution(uint FMMKCBAOFKA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x6F4650", Offset = "0x6F2E50", VA = "0x1806F4650")]
		public Resolution(uint FMMKCBAOFKA, uint HPNMBFKMIJK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x4ED7350", Offset = "0x4ED5B50", VA = "0x184ED7350")]
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
			[Cpp2IlInjected.Address(RVA = "0x4ED4A30", Offset = "0x4ED3230", VA = "0x184ED4A30")]
			get
			{
				return default(uint);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public uint HPNMBFKMIJK
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x4ED4640", Offset = "0x4ED2E40", VA = "0x184ED4640")]
			get
			{
				return default(uint);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public Resolution PDCLOMKNDFK
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x4ED4660", Offset = "0x4ED2E60", VA = "0x184ED4660")]
			get
			{
				return default(Resolution);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x13F8D10", Offset = "0x13F7510", VA = "0x1813F8D10")]
		public GFIMFPCJACH(Resolution OIKJLINBHGG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x4ED4860", Offset = "0x4ED3060", VA = "0x184ED4860")]
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
		[Cpp2IlInjected.Address(RVA = "0x4ED6DD0", Offset = "0x4ED55D0", VA = "0x184ED6DD0")]
		public static Resolution IFDFDICJOGI(uint GPPALIDPAOJ)
		{
			return default(Resolution);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public static readonly Resolution KPBKJCMJMEM;

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x4ED5AC0", Offset = "0x4ED42C0", VA = "0x184ED5AC0")]
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
			[Cpp2IlInjected.Address(RVA = "0x4ED6D80", Offset = "0x4ED5580", VA = "0x184ED6D80")]
			public ODONKHGHJMI(string JIEIIEKPPIJ)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x9D40C0", Offset = "0x9D28C0", VA = "0x1809D40C0")]
			public ODONKHGHJMI(string JIEIIEKPPIJ, Texture2D LLCEBHEOINP, JPBIKFJKJGG HAEMLPCPIAF)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x4ED6D40", Offset = "0x4ED5540", VA = "0x184ED6D40", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x563AB0", Offset = "0x5622B0", VA = "0x180563AB0")]
			public FLIEMJCMHEN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x4ED4600", Offset = "0x4ED2E00", VA = "0x184ED4600")]
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
			[Cpp2IlInjected.Address(RVA = "0x563AB0", Offset = "0x5622B0", VA = "0x180563AB0")]
			public GGOOEJCHPLO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x4ED4A40", Offset = "0x4ED3240", VA = "0x184ED4A40")]
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
			[Cpp2IlInjected.Address(RVA = "0x563AB0", Offset = "0x5622B0", VA = "0x180563AB0")]
			public BFDHDNNOHPJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x4ED4550", Offset = "0x4ED2D50", VA = "0x184ED4550")]
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
			[Cpp2IlInjected.Address(RVA = "0x58C7B0", Offset = "0x58AFB0", VA = "0x18058C7B0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public RenderTexture LastRenderTexture
		{
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x563DF0", Offset = "0x5625F0", VA = "0x180563DF0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x58BD70", Offset = "0x58A570", VA = "0x18058BD70")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		private ODONKHGHJMI memoryTexture
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x4ED6CA0", Offset = "0x4ED54A0", VA = "0x184ED6CA0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x4ED6BF0", Offset = "0x4ED53F0", VA = "0x184ED6BF0")]
		public ManagedTexture(string JIEIIEKPPIJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x4ED6C40", Offset = "0x4ED5440", VA = "0x184ED6C40")]
		public ManagedTexture(string JIEIIEKPPIJ, bool BDJLKCEPOFI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x4ED6A10", Offset = "0x4ED5210", VA = "0x184ED6A10")]
		public void NKHIBIOHJBP(RenderTexture AGNICJKNAMO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x4ED6370", Offset = "0x4ED4B70", VA = "0x184ED6370")]
		public global::PKODKNLJGEP<byte[]> FCCOANLKFNH(bool IDDDJHNHDCH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x4ED60D0", Offset = "0x4ED48D0", VA = "0x184ED60D0")]
		public global::PKODKNLJGEP<Texture2D> AIMBIGCMMHN(JPBIKFJKJGG HAEMLPCPIAF, bool PDMDGABPLCC = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x4ED6A40", Offset = "0x4ED5240", VA = "0x184ED6A40")]
		public global::PKODKNLJGEP<byte[]> PEFIHGFONIM(bool PDMDGABPLCC = false, int OOMJEPHHFML = 80)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x4ED6390", Offset = "0x4ED4B90", VA = "0x184ED6390")]
		public global::PKODKNLJGEP<byte[]> GFOFNNMADMF(bool PDMDGABPLCC = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x4ED6520", Offset = "0x4ED4D20", VA = "0x184ED6520")]
		private static global::PKODKNLJGEP<Texture2D> JFCIBIHEGCP(string JIEIIEKPPIJ, RenderTexture AGNICJKNAMO, ref Texture2D BGHOOPDPPLL, bool PDMDGABPLCC, JPBIKFJKJGG PNGLMCEBOPL = JPBIKFJKJGG.GPU)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x4ED5F70", Offset = "0x4ED4770", VA = "0x184ED5F70")]
		public void AHMCNMHCMIE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x4ED6360", Offset = "0x4ED4B60", VA = "0x184ED6360", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x4ED6030", Offset = "0x4ED4830", VA = "0x184ED6030")]
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
	[Cpp2IlInjected.Address(RVA = "0x4ED7170", Offset = "0x4ED5970", VA = "0x184ED7170")]
	public static RenderTexture MDPDLEJMBJI(int GPPALIDPAOJ, int HBKDNCCDNCO, int LOOFANMHKBL, Camera CDJBGAEAJNM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x4ED72E0", Offset = "0x4ED5AE0", VA = "0x184ED72E0")]
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
		[Cpp2IlInjected.Address(RVA = "0x5FA350", Offset = "0x5F8B50", VA = "0x1805FA350")]
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
	[Cpp2IlInjected.Address(RVA = "0x4ED5AA0", Offset = "0x4ED42A0", VA = "0x184ED5AA0")]
	public static void OMGDCFMHHIO(Texture2D GOCGDEHFMFP, int NIJCODHFBHK, int LKHOJFIGGAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x4ED4A60", Offset = "0x4ED3260", VA = "0x184ED4A60")]
	private static void AIONFMBGOKI(Texture2D GOCGDEHFMFP, int NIJCODHFBHK, int LKHOJFIGGAK, NHOIHEAKJDK EMKPCNJLLFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x4ED4F10", Offset = "0x4ED3710", VA = "0x184ED4F10")]
	public static void DBGOLHFEFOC(object OMILIKJDDEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x4ED5700", Offset = "0x4ED3F00", VA = "0x184ED5700")]
	public static void JIKACLFFEDM(object OMILIKJDDEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x4ED58E0", Offset = "0x4ED40E0", VA = "0x184ED58E0")]
	private static Color JLECCIJNDID(int FMMKCBAOFKA, int HPNMBFKMIJK, float GHNPFFAOBIN, float BDCCAMGDOGA)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x4ED5520", Offset = "0x4ED3D20", VA = "0x184ED5520")]
	public static void IFKLCMLKDAL(object OMILIKJDDEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x4ED5430", Offset = "0x4ED3C30", VA = "0x184ED5430")]
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
