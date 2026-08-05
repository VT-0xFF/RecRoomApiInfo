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
		[Cpp2IlInjected.Address(RVA = "0x51E68A0", Offset = "0x51E58A0", VA = "0x1851E68A0")]
		public CubeMapGenerator()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public enum ACHDIHNJHCL
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
public interface BHNJNIAJGIF
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	ACHDIHNJHCL NFNGJOAIFGF
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class DJCMBHNNNIK
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
			[Cpp2IlInjected.Address(RVA = "0x51E9040", Offset = "0x51E8040", VA = "0x1851E9040")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x51E9030", Offset = "0x51E8030", VA = "0x1851E9030")]
		public Resolution(uint JBEHFGFFAPE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x715A30", Offset = "0x714A30", VA = "0x180715A30")]
		public Resolution(uint JBEHFGFFAPE, uint GLCMAAPCBBC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x51E8EE0", Offset = "0x51E7EE0", VA = "0x1851E8EE0")]
		public static Resolution ADKPGGCCCGE(Resolution[] HDAKPKJDKIP, Resolution ABMMCEAMIOO, int ICODEOELMFL)
		{
			return default(Resolution);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public class CAPHPDPBMGJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private readonly Resolution MAHEBOPOHPO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private Resolution? IKPGCBDOBAF;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public uint JBEHFGFFAPE
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x51E60E0", Offset = "0x51E50E0", VA = "0x1851E60E0")]
			get
			{
				return default(uint);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public uint GLCMAAPCBBC
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x51E64C0", Offset = "0x51E54C0", VA = "0x1851E64C0")]
			get
			{
				return default(uint);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public Resolution KLGGKFODBOE
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x51E62C0", Offset = "0x51E52C0", VA = "0x1851E62C0")]
			get
			{
				return default(Resolution);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0xE6F2E0", Offset = "0xE6E2E0", VA = "0x180E6F2E0")]
		public CAPHPDPBMGJ(Resolution MAHEBOPOHPO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x51E60F0", Offset = "0x51E50F0", VA = "0x1851E60F0")]
		private static Resolution IKAJBHHBIGH(Resolution IKPGCBDOBAF, ACHDIHNJHCL OGBHLAKNHDJ)
		{
			return default(Resolution);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public static class DPBEDEFGEDL
	{
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public static readonly Resolution JDAHKKDPAHP;

		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public static readonly Resolution JJBCLCKNOJD;

		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public static readonly Resolution CIDDFGOKPEB;

		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public static readonly Resolution APAGABMPGMB;

		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public static readonly Resolution HBADBKIOGGB;

		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public static readonly Resolution NOKGMCNDFAA;

		[Cpp2IlInjected.Token(Token = "0x4000014")]
		internal static readonly Resolution[] HDJMOBJKELE;
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public static class CCNKANJOBDJ
	{
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public static readonly Resolution KGOJNEJPFGE;

		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public static readonly Resolution NNNEFIHAHBN;

		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public static readonly Resolution AFFKHHLONHH;

		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public static readonly Resolution APGGEDHHKEF;

		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public static readonly Resolution MHGFPGKDMGJ;

		[Cpp2IlInjected.Token(Token = "0x400001A")]
		internal static readonly Resolution[] HDJMOBJKELE;

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x51E64E0", Offset = "0x51E54E0", VA = "0x1851E64E0")]
		public static Resolution OMCHMCFCGLG(uint DFGJDFLDIBI)
		{
			return default(Resolution);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public static readonly Resolution NLHIDHKDLDI;

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x51E68C0", Offset = "0x51E58C0", VA = "0x1851E68C0")]
	public static bool LFKBGDGFNDP(uint ANCLKCFBFNC)
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
		public enum OGAPPOHIGNH : byte
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
		private class EFCDDALJNFM : IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			private string LDKPDNBIJND;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			public Texture2D DGEMPJBPAFP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400002C")]
			public OGAPPOHIGNH NDPDPIBHPGP;

			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x51E6DB0", Offset = "0x51E5DB0", VA = "0x1851E6DB0")]
			public EFCDDALJNFM(string LDKPDNBIJND)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x8DEE60", Offset = "0x8DDE60", VA = "0x1808DEE60")]
			public EFCDDALJNFM(string LDKPDNBIJND, Texture2D ONBABIBGPJL, OGAPPOHIGNH PMIDJCCOGMO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x51E6D70", Offset = "0x51E5D70", VA = "0x1851E6D70", Slot = "4")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000D")]
		[CompilerGenerated]
		private sealed class IMEALPLLJMD
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400002D")]
			public ManagedTexture <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400002E")]
			public OGAPPOHIGNH textureMemory;

			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x58EAB0", Offset = "0x58DAB0", VA = "0x18058EAB0")]
			public IMEALPLLJMD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x51E6E00", Offset = "0x51E5E00", VA = "0x1851E6E00")]
			internal void <GetManagedTexture>b__0()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000E")]
		[CompilerGenerated]
		private sealed class CDNHFGLNNDP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400002F")]
			public int quality;

			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x58EAB0", Offset = "0x58DAB0", VA = "0x18058EAB0")]
			public CDNHFGLNNDP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x51E6880", Offset = "0x51E5880", VA = "0x1851E6880")]
			internal byte[] <EncodeToJPG>b__0(Texture2D t2d)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000F")]
		[CompilerGenerated]
		private sealed class JPEIKIFELHL
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000030")]
			public RenderTexture tempRenderTexture;

			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x58EAB0", Offset = "0x58DAB0", VA = "0x18058EAB0")]
			public JPEIKIFELHL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x51E6E40", Offset = "0x51E5E40", VA = "0x1851E6E40")]
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
		private global::IHDAFNHGAJF<Texture2D> _cpuSidePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private EFCDDALJNFM _memTexture;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private global::IHDAFNHGAJF<byte[]> _jpgEncodePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private byte[] _jpgBytes;

		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public const int DEFAULT_JPG_QUALITY = 80;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private global::IHDAFNHGAJF<byte[]> _pngEncodePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private byte[] _pngBytes;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public bool UsePalette
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x5B77B0", Offset = "0x5B67B0", VA = "0x1805B77B0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public RenderTexture LastRenderTexture
		{
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x58EDF0", Offset = "0x58DDF0", VA = "0x18058EDF0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x5B6D70", Offset = "0x5B5D70", VA = "0x1805B6D70")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		private EFCDDALJNFM memoryTexture
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x51E7C00", Offset = "0x51E6C00", VA = "0x1851E7C00")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x51E7B50", Offset = "0x51E6B50", VA = "0x1851E7B50")]
		public ManagedTexture(string LDKPDNBIJND)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x51E7BA0", Offset = "0x51E6BA0", VA = "0x1851E7BA0")]
		public ManagedTexture(string LDKPDNBIJND, bool DFLBBNCIPFA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x51E7550", Offset = "0x51E6550", VA = "0x1851E7550")]
		public void HHGAGCEDLLD(RenderTexture FBKAAFGDBNB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x51E7A70", Offset = "0x51E6A70", VA = "0x1851E7A70")]
		public global::IHDAFNHGAJF<byte[]> LHKBFIFANGL(bool LIKBGLCBPEP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x51E6F80", Offset = "0x51E5F80", VA = "0x1851E6F80")]
		public global::IHDAFNHGAJF<Texture2D> FEBAFGDJKLE(OGAPPOHIGNH PMIDJCCOGMO, bool IEHHFONNMJH = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x51E73A0", Offset = "0x51E63A0", VA = "0x1851E73A0")]
		public global::IHDAFNHGAJF<byte[]> FMLCPONBPJJ(bool IEHHFONNMJH = false, int BPEACKDDNJJ = 80)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x51E7210", Offset = "0x51E6210", VA = "0x1851E7210")]
		public global::IHDAFNHGAJF<byte[]> FFOHDKICHHO(bool IEHHFONNMJH = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x51E7580", Offset = "0x51E6580", VA = "0x1851E7580")]
		private static global::IHDAFNHGAJF<Texture2D> JNBHNJCIJEH(string LDKPDNBIJND, RenderTexture FBKAAFGDBNB, ref Texture2D JANOMHGCOPG, bool IEHHFONNMJH, OGAPPOHIGNH JBMAENCNHAA = OGAPPOHIGNH.GPU)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x51E7A90", Offset = "0x51E6A90", VA = "0x1851E7A90")]
		public void OAHMJFLEMEM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x51E6F70", Offset = "0x51E5F70", VA = "0x1851E6F70", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x51E6ED0", Offset = "0x51E5ED0", VA = "0x1851E6ED0")]
		[CompilerGenerated]
		private global::IHDAFNHGAJF<byte[]> BMAIJEJHPOL(Texture2D KJNFHJGNKGH)
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public static class PLKCNPMCJDC
{
	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x51E8D70", Offset = "0x51E7D70", VA = "0x1851E8D70")]
	public static RenderTexture EIHMGNOFHKM(int DFGJDFLDIBI, int LDIDAFFCGNN, int EBFLECLDFLM, Camera BCGEPBJHKEG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x51E8D00", Offset = "0x51E7D00", VA = "0x1851E8D00")]
	public static void CHJIINJKEBL(RenderTexture FBKAAFGDBNB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class OPBKFDEMMIA
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public class OLJCHMEIHEL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public int DOAOIAFHHOJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public int KANEENJPAME;

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x625350", Offset = "0x624350", VA = "0x180625350")]
		public OLJCHMEIHEL(int AEKJNMNAGFE, int OPNLBLDAFKL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	private enum MOJFIFFIICF
	{
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		Point,
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		Bilinear,
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		Average
	}

	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private static Color[] LKIEHGOOCCC;

	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private static Color[] DNAGFILHJIJ;

	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private static int HNDCAHMOFNF;

	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private static float IKJPGECCPMK;

	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private static float HCJBHIKNPDC;

	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private static int EOMIIKGMCCP;

	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private static int DJKJDKOPCFE;

	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private static Mutex OAIMGHACNPE;

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x51E85E0", Offset = "0x51E75E0", VA = "0x1851E85E0")]
	public static void GJHHJCPMKAD(Texture2D CKGLNBOGADK, int HGEAOIPNOJP, int ICDPNDIMHBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x51E8130", Offset = "0x51E7130", VA = "0x1851E8130")]
	private static void GHPHDIKIIGA(Texture2D CKGLNBOGADK, int HGEAOIPNOJP, int ICDPNDIMHBG, MOJFIFFIICF ILIBCLKFIMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x51E8600", Offset = "0x51E7600", VA = "0x1851E8600")]
	public static void IIONBHBJOCO(object OOJKHPLJJMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x51E8B20", Offset = "0x51E7B20", VA = "0x1851E8B20")]
	public static void LHLJPBLKAON(object OOJKHPLJJMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x51E7CA0", Offset = "0x51E6CA0", VA = "0x1851E7CA0")]
	private static Color CKABBJEPFNF(int JBEHFGFFAPE, int GLCMAAPCBBC, float IKJPGECCPMK, float HCJBHIKNPDC)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x51E7E60", Offset = "0x51E6E60", VA = "0x1851E7E60")]
	public static void CMEINAILJAI(object OOJKHPLJJMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x51E8040", Offset = "0x51E7040", VA = "0x1851E8040")]
	private static Color DGNCNICGOIF(Color NFKOJPCMBCG, Color MAFEAPBKGHH, float BMNJAHFFOPC)
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
