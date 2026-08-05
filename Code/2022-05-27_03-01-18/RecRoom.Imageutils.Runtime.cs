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
		[Cpp2IlInjected.Address(RVA = "0x1DF69A0", Offset = "0x1DF59A0", VA = "0x181DF69A0")]
		public CubeMapGenerator()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public enum ILFCBFDHBDG
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
public interface PMGEFFACBEO
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	ILFCBFDHBDG DMEOCEJIHDN
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class DLCFCIEAPJJ
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
			[Cpp2IlInjected.Address(RVA = "0x1DF88A0", Offset = "0x1DF78A0", VA = "0x181DF88A0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x1DF8890", Offset = "0x1DF7890", VA = "0x181DF8890")]
		public Resolution(uint KDNDPAEEMPL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x7AF220", Offset = "0x7AE220", VA = "0x1807AF220")]
		public Resolution(uint KDNDPAEEMPL, uint HJCNEOFEOPD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x1DF8740", Offset = "0x1DF7740", VA = "0x181DF8740")]
		public static Resolution HHMGMKOFEDI(Resolution[] JJLLJNBGLHH, Resolution JLEDAGFMBFJ, int OFMLLJLHHBA)
		{
			return default(Resolution);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public class GNKGNOGIPBL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private readonly Resolution LEKKFOGIKDN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private Resolution? HEDLEIOCNIC;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public uint KDNDPAEEMPL
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x1DF73D0", Offset = "0x1DF63D0", VA = "0x181DF73D0")]
			get
			{
				return default(uint);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public uint HJCNEOFEOPD
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x1DF73B0", Offset = "0x1DF63B0", VA = "0x181DF73B0")]
			get
			{
				return default(uint);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public Resolution ICLELFLNMDL
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x1DF71B0", Offset = "0x1DF61B0", VA = "0x181DF71B0")]
			get
			{
				return default(Resolution);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0xD0F690", Offset = "0xD0E690", VA = "0x180D0F690")]
		public GNKGNOGIPBL(Resolution LEKKFOGIKDN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x1DF6FE0", Offset = "0x1DF5FE0", VA = "0x181DF6FE0")]
		private static Resolution AHHCNHMBDML(Resolution HEDLEIOCNIC, ILFCBFDHBDG PGPNIJFMKNG)
		{
			return default(Resolution);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public static class KAEKDHJJBLC
	{
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public static readonly Resolution DILMCFFNDNB;

		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public static readonly Resolution NALMCDAGHFH;

		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public static readonly Resolution IKKCNIJCEAG;

		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public static readonly Resolution ELEKJAALIGA;

		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public static readonly Resolution FKGDJOAEKEM;

		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public static readonly Resolution LBMAIOHIMIA;

		[Cpp2IlInjected.Token(Token = "0x4000014")]
		internal static readonly Resolution[] BIELHHDHLBM;
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public static class EJOEHDKJKJN
	{
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public static readonly Resolution PHMJKFIICJE;

		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public static readonly Resolution CIFDBMDPILF;

		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public static readonly Resolution IFPPPBDPKCE;

		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public static readonly Resolution HNOJDLMPMMH;

		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public static readonly Resolution GFPEHJPIGDD;

		[Cpp2IlInjected.Token(Token = "0x400001A")]
		internal static readonly Resolution[] BIELHHDHLBM;

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x1DF6C00", Offset = "0x1DF5C00", VA = "0x181DF6C00")]
		public static Resolution JMENOMDNIJC(uint KIDBPFAHLEE)
		{
			return default(Resolution);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public static readonly Resolution JCGGKHNCAKD;

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x1DF69C0", Offset = "0x1DF59C0", VA = "0x181DF69C0")]
	public static bool ONOFNFCFMGO(uint HOLMJEAPGIG)
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
		public enum KHLPPAEGGDP : byte
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
		private class GNMNJGPLDKN : IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			private string MONHCMBIJIP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			public Texture2D CHONDJEKMBF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400002C")]
			public KHLPPAEGGDP IGGNBHEMAJA;

			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x1DF7420", Offset = "0x1DF6420", VA = "0x181DF7420")]
			public GNMNJGPLDKN(string MONHCMBIJIP)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x1045350", Offset = "0x1044350", VA = "0x181045350")]
			public GNMNJGPLDKN(string MONHCMBIJIP, Texture2D PBMMIHFCNAJ, KHLPPAEGGDP PPOELIIMNHG)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x1DF73E0", Offset = "0x1DF63E0", VA = "0x181DF73E0", Slot = "4")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000D")]
		[CompilerGenerated]
		private sealed class EKNMCJHGDOJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400002D")]
			public ManagedTexture <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400002E")]
			public KHLPPAEGGDP textureMemory;

			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x54F440", Offset = "0x54E440", VA = "0x18054F440")]
			public EKNMCJHGDOJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x1DF6FA0", Offset = "0x1DF5FA0", VA = "0x181DF6FA0")]
			internal void <GetManagedTexture>b__0()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000E")]
		[CompilerGenerated]
		private sealed class PAONOIEGOAG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400002F")]
			public int quality;

			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x54F440", Offset = "0x54E440", VA = "0x18054F440")]
			public PAONOIEGOAG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x1DF8540", Offset = "0x1DF7540", VA = "0x181DF8540")]
			internal byte[] <EncodeToJPG>b__0(Texture2D t2d)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000F")]
		[CompilerGenerated]
		private sealed class LMJHHNIFDAL
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000030")]
			public RenderTexture tempRenderTexture;

			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x54F440", Offset = "0x54E440", VA = "0x18054F440")]
			public LMJHHNIFDAL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x1DF76E0", Offset = "0x1DF66E0", VA = "0x181DF76E0")]
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
		private global::DBIKMJJJBLJ<Texture2D> _cpuSidePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private GNMNJGPLDKN _memTexture;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private global::DBIKMJJJBLJ<byte[]> _jpgEncodePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private byte[] _jpgBytes;

		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public const int DEFAULT_JPG_QUALITY = 80;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private global::DBIKMJJJBLJ<byte[]> _pngEncodePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private byte[] _pngBytes;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public bool UsePalette
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x5AA270", Offset = "0x5A9270", VA = "0x1805AA270")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public RenderTexture LastRenderTexture
		{
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x5B1950", Offset = "0x5B0950", VA = "0x1805B1950")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x5B19A0", Offset = "0x5B09A0", VA = "0x1805B19A0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		private GNMNJGPLDKN memoryTexture
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x1DF84A0", Offset = "0x1DF74A0", VA = "0x181DF84A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x1DF83F0", Offset = "0x1DF73F0", VA = "0x181DF83F0")]
		public ManagedTexture(string MONHCMBIJIP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x1DF8440", Offset = "0x1DF7440", VA = "0x181DF8440")]
		public ManagedTexture(string MONHCMBIJIP, bool ENJNAOIFMJB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x1DF8300", Offset = "0x1DF7300", VA = "0x181DF8300")]
		public void OJIGDNFMOIG(RenderTexture GKKMFGHFBIE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x1DF7770", Offset = "0x1DF6770", VA = "0x181DF7770")]
		public global::DBIKMJJJBLJ<byte[]> AFGOHIDDFKJ(bool GJPAOGAEMPF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x1DF79D0", Offset = "0x1DF69D0", VA = "0x181DF79D0")]
		public global::DBIKMJJJBLJ<Texture2D> IAIFEGKABCI(KHLPPAEGGDP PPOELIIMNHG, bool OIMMIIAEHCM = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x1DF7C60", Offset = "0x1DF6C60", VA = "0x181DF7C60")]
		public global::DBIKMJJJBLJ<byte[]> LHHNIFNFEKA(bool OIMMIIAEHCM = false, int OJJAJHMCFNP = 80)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x1DF77A0", Offset = "0x1DF67A0", VA = "0x181DF77A0")]
		public global::DBIKMJJJBLJ<byte[]> EHLBFDMOOIE(bool OIMMIIAEHCM = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x1DF7E10", Offset = "0x1DF6E10", VA = "0x181DF7E10")]
		private static global::DBIKMJJJBLJ<Texture2D> OCFMBKLFBOL(string MONHCMBIJIP, RenderTexture GKKMFGHFBIE, ref Texture2D DLHIIDNDAEP, bool OIMMIIAEHCM, KHLPPAEGGDP OGJEJNICDOL = KHLPPAEGGDP.GPU)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x1DF8330", Offset = "0x1DF7330", VA = "0x181DF8330")]
		public void PPKEDBMEGJJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x1DF7790", Offset = "0x1DF6790", VA = "0x181DF7790", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x1DF7930", Offset = "0x1DF6930", VA = "0x181DF7930")]
		[CompilerGenerated]
		private global::DBIKMJJJBLJ<byte[]> HDEDJLOOAGH(Texture2D NLIFBDGPJKH)
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public static class PNNFJKJCHCG
{
	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x1DF85D0", Offset = "0x1DF75D0", VA = "0x181DF85D0")]
	public static RenderTexture OOKOMMDKEGC(int KIDBPFAHLEE, int CNJPPLLLBHD, int DIAIBOCHHHM, Camera LCODELBDPMD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x1DF8560", Offset = "0x1DF7560", VA = "0x181DF8560")]
	public static void GBPNIAKENGA(RenderTexture GKKMFGHFBIE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class BLMBPJPOFEH
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public class DKNLKBEBIBB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public int BDOCBPFFDPK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public int OHLDOAGOHKP;

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x713F40", Offset = "0x712F40", VA = "0x180713F40")]
		public DKNLKBEBIBB(int AGEMEGILCNK, int BACBMFCMEGB)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	private enum APMMLHJCLMB
	{
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		Point,
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		Bilinear,
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		Average
	}

	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private static Color[] ANGMCLOIHHN;

	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private static Color[] KDJAIICEFBA;

	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private static int PCMOEMJBGBJ;

	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private static float PNFKICENCLL;

	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private static float HBBBMCMPEPC;

	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private static int BKAFDOCABAD;

	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private static int OKKMIPNALGJ;

	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private static Mutex JGOIBPLIDCF;

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x1DF5B20", Offset = "0x1DF4B20", VA = "0x181DF5B20")]
	public static void BLMAJNAGPDM(Texture2D DOIOJKKBEBG, int DLOADEHLGDM, int FBKPAPINPGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x1DF5B40", Offset = "0x1DF4B40", VA = "0x181DF5B40")]
	private static void FKBHDDKCKLG(Texture2D DOIOJKKBEBG, int DLOADEHLGDM, int FBKPAPINPGM, APMMLHJCLMB FKIPEOKEBBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x1DF6480", Offset = "0x1DF5480", VA = "0x181DF6480")]
	public static void PLCBLAGCOEL(object FIEDOLNFNLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x1DF61B0", Offset = "0x1DF51B0", VA = "0x181DF61B0")]
	public static void KCIONFJCJJN(object FIEDOLNFNLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x1DF5FF0", Offset = "0x1DF4FF0", VA = "0x181DF5FF0")]
	private static Color HMNLIHGBLAO(int KDNDPAEEMPL, int HJCNEOFEOPD, float PNFKICENCLL, float HBBBMCMPEPC)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x1DF5940", Offset = "0x1DF4940", VA = "0x181DF5940")]
	public static void BICDJMCHDHM(object FIEDOLNFNLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x1DF6390", Offset = "0x1DF5390", VA = "0x181DF6390")]
	private static Color OEHGIGPEMHM(Color OMPICBAEDLM, Color KAEOEOFCDOG, float MPHFKGJNMOK)
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
