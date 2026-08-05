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
		[Cpp2IlInjected.Address(RVA = "0x4E55F20", Offset = "0x4E54520", VA = "0x184E55F20")]
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
			[Cpp2IlInjected.Address(RVA = "0x4E57E20", Offset = "0x4E56420", VA = "0x184E57E20")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x4E57E10", Offset = "0x4E56410", VA = "0x184E57E10")]
		public Resolution(uint KDNDPAEEMPL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x6F3650", Offset = "0x6F1C50", VA = "0x1806F3650")]
		public Resolution(uint KDNDPAEEMPL, uint HJCNEOFEOPD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x4E57CC0", Offset = "0x4E562C0", VA = "0x184E57CC0")]
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
			[Cpp2IlInjected.Address(RVA = "0x4E56950", Offset = "0x4E54F50", VA = "0x184E56950")]
			get
			{
				return default(uint);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public uint HJCNEOFEOPD
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x4E56930", Offset = "0x4E54F30", VA = "0x184E56930")]
			get
			{
				return default(uint);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public Resolution ICLELFLNMDL
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x4E56730", Offset = "0x4E54D30", VA = "0x184E56730")]
			get
			{
				return default(Resolution);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0xDB56B0", Offset = "0xDB3CB0", VA = "0x180DB56B0")]
		public GNKGNOGIPBL(Resolution LEKKFOGIKDN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x4E56560", Offset = "0x4E54B60", VA = "0x184E56560")]
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
		[Cpp2IlInjected.Address(RVA = "0x4E56180", Offset = "0x4E54780", VA = "0x184E56180")]
		public static Resolution JMENOMDNIJC(uint KIDBPFAHLEE)
		{
			return default(Resolution);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public static readonly Resolution JCGGKHNCAKD;

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x4E55F40", Offset = "0x4E54540", VA = "0x184E55F40")]
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
			[Cpp2IlInjected.Address(RVA = "0x4E569A0", Offset = "0x4E54FA0", VA = "0x184E569A0")]
			public GNMNJGPLDKN(string MONHCMBIJIP)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x876E40", Offset = "0x875440", VA = "0x180876E40")]
			public GNMNJGPLDKN(string MONHCMBIJIP, Texture2D PBMMIHFCNAJ, KHLPPAEGGDP PPOELIIMNHG)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x4E56960", Offset = "0x4E54F60", VA = "0x184E56960", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x562AB0", Offset = "0x5610B0", VA = "0x180562AB0")]
			public EKNMCJHGDOJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x4E56520", Offset = "0x4E54B20", VA = "0x184E56520")]
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
			[Cpp2IlInjected.Address(RVA = "0x562AB0", Offset = "0x5610B0", VA = "0x180562AB0")]
			public PAONOIEGOAG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x4E57AC0", Offset = "0x4E560C0", VA = "0x184E57AC0")]
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
			[Cpp2IlInjected.Address(RVA = "0x562AB0", Offset = "0x5610B0", VA = "0x180562AB0")]
			public LMJHHNIFDAL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x4E56C60", Offset = "0x4E55260", VA = "0x184E56C60")]
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
			[Cpp2IlInjected.Address(RVA = "0x58B7B0", Offset = "0x589DB0", VA = "0x18058B7B0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public RenderTexture LastRenderTexture
		{
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x562DF0", Offset = "0x5613F0", VA = "0x180562DF0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x58AD70", Offset = "0x589370", VA = "0x18058AD70")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		private GNMNJGPLDKN memoryTexture
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x4E57A20", Offset = "0x4E56020", VA = "0x184E57A20")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x4E57970", Offset = "0x4E55F70", VA = "0x184E57970")]
		public ManagedTexture(string MONHCMBIJIP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x4E579C0", Offset = "0x4E55FC0", VA = "0x184E579C0")]
		public ManagedTexture(string MONHCMBIJIP, bool ENJNAOIFMJB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x4E57880", Offset = "0x4E55E80", VA = "0x184E57880")]
		public void OJIGDNFMOIG(RenderTexture GKKMFGHFBIE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x4E56CF0", Offset = "0x4E552F0", VA = "0x184E56CF0")]
		public global::DBIKMJJJBLJ<byte[]> AFGOHIDDFKJ(bool GJPAOGAEMPF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x4E56F50", Offset = "0x4E55550", VA = "0x184E56F50")]
		public global::DBIKMJJJBLJ<Texture2D> IAIFEGKABCI(KHLPPAEGGDP PPOELIIMNHG, bool OIMMIIAEHCM = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x4E571E0", Offset = "0x4E557E0", VA = "0x184E571E0")]
		public global::DBIKMJJJBLJ<byte[]> LHHNIFNFEKA(bool OIMMIIAEHCM = false, int OJJAJHMCFNP = 80)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x4E56D20", Offset = "0x4E55320", VA = "0x184E56D20")]
		public global::DBIKMJJJBLJ<byte[]> EHLBFDMOOIE(bool OIMMIIAEHCM = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x4E57390", Offset = "0x4E55990", VA = "0x184E57390")]
		private static global::DBIKMJJJBLJ<Texture2D> OCFMBKLFBOL(string MONHCMBIJIP, RenderTexture GKKMFGHFBIE, ref Texture2D DLHIIDNDAEP, bool OIMMIIAEHCM, KHLPPAEGGDP OGJEJNICDOL = KHLPPAEGGDP.GPU)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x4E578B0", Offset = "0x4E55EB0", VA = "0x184E578B0")]
		public void PPKEDBMEGJJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x4E56D10", Offset = "0x4E55310", VA = "0x184E56D10", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x4E56EB0", Offset = "0x4E554B0", VA = "0x184E56EB0")]
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
	[Cpp2IlInjected.Address(RVA = "0x4E57B50", Offset = "0x4E56150", VA = "0x184E57B50")]
	public static RenderTexture OOKOMMDKEGC(int KIDBPFAHLEE, int CNJPPLLLBHD, int DIAIBOCHHHM, Camera LCODELBDPMD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x4E57AE0", Offset = "0x4E560E0", VA = "0x184E57AE0")]
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
		[Cpp2IlInjected.Address(RVA = "0x5F9350", Offset = "0x5F7950", VA = "0x1805F9350")]
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
	[Cpp2IlInjected.Address(RVA = "0x4E550A0", Offset = "0x4E536A0", VA = "0x184E550A0")]
	public static void BLMAJNAGPDM(Texture2D DOIOJKKBEBG, int DLOADEHLGDM, int FBKPAPINPGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x4E550C0", Offset = "0x4E536C0", VA = "0x184E550C0")]
	private static void FKBHDDKCKLG(Texture2D DOIOJKKBEBG, int DLOADEHLGDM, int FBKPAPINPGM, APMMLHJCLMB FKIPEOKEBBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x4E55A00", Offset = "0x4E54000", VA = "0x184E55A00")]
	public static void PLCBLAGCOEL(object FIEDOLNFNLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x4E55730", Offset = "0x4E53D30", VA = "0x184E55730")]
	public static void KCIONFJCJJN(object FIEDOLNFNLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x4E55570", Offset = "0x4E53B70", VA = "0x184E55570")]
	private static Color HMNLIHGBLAO(int KDNDPAEEMPL, int HJCNEOFEOPD, float PNFKICENCLL, float HBBBMCMPEPC)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x4E54EC0", Offset = "0x4E534C0", VA = "0x184E54EC0")]
	public static void BICDJMCHDHM(object FIEDOLNFNLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x4E55910", Offset = "0x4E53F10", VA = "0x184E55910")]
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
