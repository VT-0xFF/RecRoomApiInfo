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
		[Cpp2IlInjected.Address(RVA = "0x3D5F880", Offset = "0x3D5EA80", VA = "0x183D5F880")]
		public CubeMapGenerator()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public enum NLHCMMHIKFB
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
public interface LJMCHCPLPIM
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	NLHCMMHIKFB GKCKGPFMKFN
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class CAJINFKKDOC
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
			[Cpp2IlInjected.Address(RVA = "0x3D622C0", Offset = "0x3D614C0", VA = "0x183D622C0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x3D622B0", Offset = "0x3D614B0", VA = "0x183D622B0")]
		public Resolution(uint JOBKHMNDDOJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x563A50", Offset = "0x562C50", VA = "0x180563A50")]
		public Resolution(uint JOBKHMNDDOJ, uint IFCPAEEHEPP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x3D62160", Offset = "0x3D61360", VA = "0x183D62160")]
		public static Resolution LPPCLEJLMEO(Resolution[] ADFPKAEIFEA, Resolution CIMDKOBDHGH, int EKOCCBPJLMK)
		{
			return default(Resolution);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public class LLCDBDJLKGE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private readonly Resolution AGNOPLCIEJB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private Resolution? OFCMFNLHJGC;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public uint JOBKHMNDDOJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x3D60F30", Offset = "0x3D60130", VA = "0x183D60F30")]
			get
			{
				return default(uint);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public uint IFCPAEEHEPP
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x3D60B40", Offset = "0x3D5FD40", VA = "0x183D60B40")]
			get
			{
				return default(uint);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public Resolution HOKPDDMCONE
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x3D60B60", Offset = "0x3D5FD60", VA = "0x183D60B60")]
			get
			{
				return default(Resolution);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x226E6D0", Offset = "0x226D8D0", VA = "0x18226E6D0")]
		public LLCDBDJLKGE(Resolution AGNOPLCIEJB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x3D60D60", Offset = "0x3D5FF60", VA = "0x183D60D60")]
		private static Resolution KHKCJGIHCFC(Resolution OFCMFNLHJGC, NLHCMMHIKFB GONFBJGAGAN)
		{
			return default(Resolution);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public static class KNNCMFCFLIN
	{
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public static readonly Resolution DAIOKHPNKEN;

		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public static readonly Resolution DGOFBAKDOPC;

		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public static readonly Resolution GBIIJINHOCH;

		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public static readonly Resolution DGMFMKNJFPF;

		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public static readonly Resolution KAAMEIGDJMF;

		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public static readonly Resolution AGFEHGDCEDD;

		[Cpp2IlInjected.Token(Token = "0x4000014")]
		internal static readonly Resolution[] LPIFBJMPABN;
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public static class AOAJOKPEKDO
	{
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public static readonly Resolution MMJICJMLMGM;

		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public static readonly Resolution JJLMFHPKMCM;

		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public static readonly Resolution HNMIOMDPKOC;

		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public static readonly Resolution JCLNHMNHJHG;

		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public static readonly Resolution PNLJKLKFAIJ;

		[Cpp2IlInjected.Token(Token = "0x400001A")]
		internal static readonly Resolution[] LPIFBJMPABN;

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x3D5F270", Offset = "0x3D5E470", VA = "0x183D5F270")]
		public static Resolution BPCDACDIEAL(uint OKKOCNPNGFM)
		{
			return default(Resolution);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public static readonly Resolution HOMNGELADJH;

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x3D5F600", Offset = "0x3D5E800", VA = "0x183D5F600")]
	public static bool JFELCACKCPL(uint HDKHOPBKBBE)
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
		public enum LNFJAHBCHCA : byte
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
		private class PBGNNMNFNBP : IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			private string DILLFCNMNDO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			public Texture2D JGCFPNFLJJG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400002C")]
			public LNFJAHBCHCA AILCMMOPIMJ;

			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x3D62120", Offset = "0x3D61320", VA = "0x183D62120")]
			public PBGNNMNFNBP(string DILLFCNMNDO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x7272F0", Offset = "0x7264F0", VA = "0x1807272F0")]
			public PBGNNMNFNBP(string DILLFCNMNDO, Texture2D LJIMCPACEIH, LNFJAHBCHCA IBPFJCAFGBD)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x3D620F0", Offset = "0x3D612F0", VA = "0x183D620F0", Slot = "4")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000D")]
		[CompilerGenerated]
		private sealed class CMEEIFBEFGC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400002D")]
			public ManagedTexture <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400002E")]
			public LNFJAHBCHCA textureMemory;

			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x4279D0", Offset = "0x426BD0", VA = "0x1804279D0")]
			public CMEEIFBEFGC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x3D5F840", Offset = "0x3D5EA40", VA = "0x183D5F840")]
			internal void <GetManagedTexture>b__0()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000E")]
		[CompilerGenerated]
		private sealed class AJJPAEGKAJF
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400002F")]
			public int quality;

			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x4279D0", Offset = "0x426BD0", VA = "0x1804279D0")]
			public AJJPAEGKAJF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x3D5F250", Offset = "0x3D5E450", VA = "0x183D5F250")]
			internal byte[] <EncodeToJPG>b__0(Texture2D t2d)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000F")]
		[CompilerGenerated]
		private sealed class ONBFEEKCEOF
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000030")]
			public RenderTexture tempRenderTexture;

			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x4279D0", Offset = "0x426BD0", VA = "0x1804279D0")]
			public ONBFEEKCEOF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x3D62070", Offset = "0x3D61270", VA = "0x183D62070")]
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
		private global::MGLHMIMFOOP<Texture2D> _cpuSidePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private PBGNNMNFNBP _memTexture;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private global::MGLHMIMFOOP<byte[]> _jpgEncodePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private byte[] _jpgBytes;

		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public const int DEFAULT_JPG_QUALITY = 80;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private global::MGLHMIMFOOP<byte[]> _pngEncodePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private byte[] _pngBytes;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public bool UsePalette
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x44F180", Offset = "0x44E380", VA = "0x18044F180")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public RenderTexture LastRenderTexture
		{
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x427CF0", Offset = "0x426EF0", VA = "0x180427CF0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x44E7D0", Offset = "0x44D9D0", VA = "0x18044E7D0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		private PBGNNMNFNBP memoryTexture
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x3D61FF0", Offset = "0x3D611F0", VA = "0x183D61FF0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x3D61FA0", Offset = "0x3D611A0", VA = "0x183D61FA0")]
		public ManagedTexture(string DILLFCNMNDO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x3D61F50", Offset = "0x3D61150", VA = "0x183D61F50")]
		public ManagedTexture(string DILLFCNMNDO, bool NBNIEBFAKHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x3D615F0", Offset = "0x3D607F0", VA = "0x183D615F0")]
		public void CGALPLBCFLL(RenderTexture PIOLDHBAKOC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x3D61C50", Offset = "0x3D60E50", VA = "0x183D61C50")]
		public global::MGLHMIMFOOP<byte[]> MEFIECGMCMM(bool KPOPCIAPEBE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x3D616E0", Offset = "0x3D608E0", VA = "0x183D616E0")]
		public Texture2D EFOGLHABJPI(LNFJAHBCHCA IBPFJCAFGBD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x3D61790", Offset = "0x3D60990", VA = "0x183D61790")]
		public global::MGLHMIMFOOP<Texture2D> HGEBGCJALPM(LNFJAHBCHCA IBPFJCAFGBD, bool GOKBGEBNLHC = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x3D61A10", Offset = "0x3D60C10", VA = "0x183D61A10")]
		public global::MGLHMIMFOOP<byte[]> JIAJMGJNFPL(bool GOKBGEBNLHC = false, int CKPAIIJNFLC = 80)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x3D61DE0", Offset = "0x3D60FE0", VA = "0x183D61DE0")]
		public global::MGLHMIMFOOP<byte[]> PFJIIIKGAAF(bool GOKBGEBNLHC = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x3D61120", Offset = "0x3D60320", VA = "0x183D61120")]
		private static global::MGLHMIMFOOP<Texture2D> CDFNGEBJPGE(string DILLFCNMNDO, RenderTexture PIOLDHBAKOC, ref Texture2D NIIBHICHGOA, bool GOKBGEBNLHC, LNFJAHBCHCA KNBFFBPPFLJ = LNFJAHBCHCA.GPU)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x3D61670", Offset = "0x3D60870", VA = "0x183D61670")]
		public void MOKKMIHPNMO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x3D61670", Offset = "0x3D60870", VA = "0x183D61670", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x3D61BB0", Offset = "0x3D60DB0", VA = "0x183D61BB0")]
		[CompilerGenerated]
		private global::MGLHMIMFOOP<byte[]> JPAHPFADMEO(Texture2D CLOJOOJJLCA)
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public static class MPFBGGJAGDL
{
	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x3D60FB0", Offset = "0x3D601B0", VA = "0x183D60FB0")]
	public static RenderTexture LKDPFDLJHNA(int OKKOCNPNGFM, int CDKBNLCFLFF, int NKFNADHOJPM, Camera MPONKNMGOCG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x3D60F40", Offset = "0x3D60140", VA = "0x183D60F40")]
	public static void BLCBGBMLAIJ(RenderTexture PIOLDHBAKOC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class DNMFFHJFEBO
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public class LKHNCDNGPFO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public int LAOFPHNEBCL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public int KEEJMOEMDPO;

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x8ACA80", Offset = "0x8ABC80", VA = "0x1808ACA80")]
		public LKHNCDNGPFO(int PPDPLGCMAEJ, int MELPNJNHLLD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	private enum LIPPGMDHIDB
	{
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		Point,
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		Bilinear,
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		Average
	}

	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private static Color[] BFNIBICFPCE;

	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private static Color[] PLDLCIIPOMN;

	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private static int KLJHICMKBFI;

	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private static float HEIMEHCHNGG;

	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private static float OHCMIJHBHCP;

	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private static int CFNOOCJEBBF;

	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private static int AFJDEACNJEP;

	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private static Mutex JCMBKBHFNHC;

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x3D5FB50", Offset = "0x3D5ED50", VA = "0x183D5FB50")]
	public static void HIMHLFMBHAF(Texture2D KHEDMOBIKJL, int DKLPCALHAFK, int FPDMLMFJFGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x3D60450", Offset = "0x3D5F650", VA = "0x183D60450")]
	private static void PLNMHLDFOPK(Texture2D KHEDMOBIKJL, int DKLPCALHAFK, int FPDMLMFJFGE, LIPPGMDHIDB IHMEGMFIIHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x3D5FD50", Offset = "0x3D5EF50", VA = "0x183D5FD50")]
	public static void IDGGBFEOONJ(object NKNAILFIDNK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x3D60270", Offset = "0x3D5F470", VA = "0x183D60270")]
	public static void JOGHOAICNPE(object NKNAILFIDNK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x3D5F990", Offset = "0x3D5EB90", VA = "0x183D5F990")]
	private static Color EPBACMODJFB(int JOBKHMNDDOJ, int IFCPAEEHEPP, float HEIMEHCHNGG, float OHCMIJHBHCP)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x3D5FB70", Offset = "0x3D5ED70", VA = "0x183D5FB70")]
	public static void HLCLOHAFCMK(object NKNAILFIDNK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x3D5F8A0", Offset = "0x3D5EAA0", VA = "0x183D5F8A0")]
	private static Color BHEDFCGCMIH(Color OPFEMMOKENJ, Color KELKGAHPLNK, float NAOGMHDFAEF)
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
