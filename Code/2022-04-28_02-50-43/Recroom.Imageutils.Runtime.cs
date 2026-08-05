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
		[Cpp2IlInjected.Address(RVA = "0x4C02DB0", Offset = "0x4C01FB0", VA = "0x184C02DB0")]
		public CubeMapGenerator()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public enum GGIIPAAIDIK
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
public interface MPHNCMNGAOP
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	GGIIPAAIDIK NIOOBMPDIFE
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class POECMEMLMLO
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
			[Cpp2IlInjected.Address(RVA = "0x4C05880", Offset = "0x4C04A80", VA = "0x184C05880")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x4C05870", Offset = "0x4C04A70", VA = "0x184C05870")]
		public Resolution(uint GGMEAHKJCJC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x6DD110", Offset = "0x6DC310", VA = "0x1806DD110")]
		public Resolution(uint GGMEAHKJCJC, uint DHBFNIJNBON)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x4C05720", Offset = "0x4C04920", VA = "0x184C05720")]
		public static Resolution HEHALFNIHCP(Resolution[] DLAIHBPBICF, Resolution EHPEPHKNCAB, int MPGLHCAGDJG)
		{
			return default(Resolution);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public class NIFJOLKAKBD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private readonly Resolution PDGIBDHFEOG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private Resolution? CJBDPDDOMHP;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public uint GGMEAHKJCJC
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x4C03FB0", Offset = "0x4C031B0", VA = "0x184C03FB0")]
			get
			{
				return default(uint);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public uint DHBFNIJNBON
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x4C03BC0", Offset = "0x4C02DC0", VA = "0x184C03BC0")]
			get
			{
				return default(uint);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public Resolution EFNLLBAJPIO
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x4C03BE0", Offset = "0x4C02DE0", VA = "0x184C03BE0")]
			get
			{
				return default(Resolution);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0xF3D640", Offset = "0xF3C840", VA = "0x180F3D640")]
		public NIFJOLKAKBD(Resolution PDGIBDHFEOG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x4C03DE0", Offset = "0x4C02FE0", VA = "0x184C03DE0")]
		private static Resolution MACIMEHEOCE(Resolution CJBDPDDOMHP, GGIIPAAIDIK PJDAKNDDJKP)
		{
			return default(Resolution);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public static class BIDANKBHDBN
	{
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public static readonly Resolution DPCDDHCNLHK;

		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public static readonly Resolution EILPJAPPBEG;

		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public static readonly Resolution BHPKNIHCGBE;

		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public static readonly Resolution ANAEIEKKIMJ;

		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public static readonly Resolution LPFNMOJLKPA;

		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public static readonly Resolution LEHDMIKBEHO;

		[Cpp2IlInjected.Token(Token = "0x4000014")]
		internal static readonly Resolution[] NCNCDEGIFIP;
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public static class OJAHKFNKIGD
	{
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public static readonly Resolution KAOCFPILMHD;

		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public static readonly Resolution GBKJOKDLKJO;

		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public static readonly Resolution KFCGGFPKOEI;

		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public static readonly Resolution PAMFKPPHBAP;

		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public static readonly Resolution AEIOIPMOKKC;

		[Cpp2IlInjected.Token(Token = "0x400001A")]
		internal static readonly Resolution[] NCNCDEGIFIP;

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x4C05020", Offset = "0x4C04220", VA = "0x184C05020")]
		public static Resolution BJCNKOFLOIE(uint PJIIABFMCEC)
		{
			return default(Resolution);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public static readonly Resolution PKKAMJOEMJB;

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x4C05450", Offset = "0x4C04650", VA = "0x184C05450")]
	public static bool HAHJCGOMCJC(uint MHOHLFCELHE)
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
		public enum HBGHAFCLKAP : byte
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
		private class PJLIJGLOEIK : IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			private string OJIMLEPHDJI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			public Texture2D EMFBLDMPMBO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400002C")]
			public HBGHAFCLKAP DJMJEMAADIM;

			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x4C05400", Offset = "0x4C04600", VA = "0x184C05400")]
			public PJLIJGLOEIK(string OJIMLEPHDJI)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x898290", Offset = "0x897490", VA = "0x180898290")]
			public PJLIJGLOEIK(string OJIMLEPHDJI, Texture2D JGFHLGPFALF, HBGHAFCLKAP GKKJBLBBKLP)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x4C053C0", Offset = "0x4C045C0", VA = "0x184C053C0", Slot = "4")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000D")]
		[CompilerGenerated]
		private sealed class APBLMCCGGJE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400002D")]
			public ManagedTexture <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400002E")]
			public HBGHAFCLKAP textureMemory;

			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x529AB0", Offset = "0x528CB0", VA = "0x180529AB0")]
			public APBLMCCGGJE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x4C02920", Offset = "0x4C01B20", VA = "0x184C02920")]
			internal void <GetManagedTexture>b__0()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000E")]
		[CompilerGenerated]
		private sealed class MFMIIJMFKFO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400002F")]
			public int quality;

			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x529AB0", Offset = "0x528CB0", VA = "0x180529AB0")]
			public MFMIIJMFKFO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x4C02DD0", Offset = "0x4C01FD0", VA = "0x184C02DD0")]
			internal byte[] <EncodeToJPG>b__0(Texture2D t2d)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000F")]
		[CompilerGenerated]
		private sealed class POKPJPLGOKK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000030")]
			public RenderTexture tempRenderTexture;

			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x529AB0", Offset = "0x528CB0", VA = "0x180529AB0")]
			public POKPJPLGOKK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x4C05690", Offset = "0x4C04890", VA = "0x184C05690")]
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
		private global::HEDCDMAPDEO<Texture2D> _cpuSidePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private PJLIJGLOEIK _memTexture;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private global::HEDCDMAPDEO<byte[]> _jpgEncodePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private byte[] _jpgBytes;

		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public const int DEFAULT_JPG_QUALITY = 80;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private global::HEDCDMAPDEO<byte[]> _pngEncodePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private byte[] _pngBytes;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public bool UsePalette
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x5527B0", Offset = "0x5519B0", VA = "0x1805527B0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public RenderTexture LastRenderTexture
		{
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x529DF0", Offset = "0x528FF0", VA = "0x180529DF0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x551D70", Offset = "0x550F70", VA = "0x180551D70")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		private PJLIJGLOEIK memoryTexture
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x4C03B20", Offset = "0x4C02D20", VA = "0x184C03B20")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x4C03AD0", Offset = "0x4C02CD0", VA = "0x184C03AD0")]
		public ManagedTexture(string OJIMLEPHDJI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x4C03A70", Offset = "0x4C02C70", VA = "0x184C03A70")]
		public ManagedTexture(string OJIMLEPHDJI, bool PMDEMCLNBDL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x4C02DF0", Offset = "0x4C01FF0", VA = "0x184C02DF0")]
		public void BADFPGPLENE(RenderTexture COFEIENCIHG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x4C02E20", Offset = "0x4C02020", VA = "0x184C02E20")]
		public global::HEDCDMAPDEO<byte[]> BECFEEJICLL(bool JNKOIMHMFMH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x4C037E0", Offset = "0x4C029E0", VA = "0x184C037E0")]
		public global::HEDCDMAPDEO<Texture2D> PJMPOIPBIBK(HBGHAFCLKAP GKKJBLBBKLP, bool EOAPIDPHAOM = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x4C03400", Offset = "0x4C02600", VA = "0x184C03400")]
		public global::HEDCDMAPDEO<byte[]> KNNFKLJIOAA(bool EOAPIDPHAOM = false, int KMOMJOGEIJJ = 80)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x4C035B0", Offset = "0x4C027B0", VA = "0x184C035B0")]
		public global::HEDCDMAPDEO<byte[]> NKHHMLFEJEJ(bool EOAPIDPHAOM = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x4C02E40", Offset = "0x4C02040", VA = "0x184C02E40")]
		private static global::HEDCDMAPDEO<Texture2D> DDBMEKKAJBC(string OJIMLEPHDJI, RenderTexture COFEIENCIHG, ref Texture2D DELLJEGGJFH, bool EOAPIDPHAOM, HBGHAFCLKAP AOLILEJACDH = HBGHAFCLKAP.GPU)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x4C03340", Offset = "0x4C02540", VA = "0x184C03340")]
		public void JPOFEDFGJIN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x4C03330", Offset = "0x4C02530", VA = "0x184C03330", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x4C03740", Offset = "0x4C02940", VA = "0x184C03740")]
		[CompilerGenerated]
		private global::HEDCDMAPDEO<byte[]> OFHHKAKGJDJ(Texture2D JIBHAAFGAID)
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public static class APIGJHHKNAG
{
	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x4C02960", Offset = "0x4C01B60", VA = "0x184C02960")]
	public static RenderTexture JDNHMNEPLHE(int PJIIABFMCEC, int JDCAGDMDMDO, int LGBNPMIFAPG, Camera PIFHMLPDKOB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x4C02AD0", Offset = "0x4C01CD0", VA = "0x184C02AD0")]
	public static void OGJBPAIBLFI(RenderTexture COFEIENCIHG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class NKJJNOBAJMB
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public class CPEBBGANCDC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public int PGDHNMNFPNO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public int NPDPHCNLMFM;

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x5C0350", Offset = "0x5BF550", VA = "0x1805C0350")]
		public CPEBBGANCDC(int GDHCMJKCBDF, int FFEJELOBLMN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	private enum GBECDNGDHHB
	{
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		Point,
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		Bilinear,
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		Average
	}

	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private static Color[] KEGPJEEJPCL;

	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private static Color[] LONNMLBACCG;

	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private static int AGHNKENFEOL;

	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private static float HAIMIFOJMEM;

	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private static float AKDMMHMMCHF;

	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private static int OMLHOIBNHNB;

	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private static int PHBMBJCFKNB;

	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private static Mutex OMFKJAGOGOL;

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x4C03FC0", Offset = "0x4C031C0", VA = "0x184C03FC0")]
	public static void CBNKLHEJLLI(Texture2D LPHEEHLMDPC, int AEBCALKOGBJ, int CCMEIGBPBMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x4C04470", Offset = "0x4C03670", VA = "0x184C04470")]
	private static void LALGNPAOEMM(Texture2D LPHEEHLMDPC, int AEBCALKOGBJ, int CCMEIGBPBMG, GBECDNGDHHB JIJOLLBGIHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x4C04B00", Offset = "0x4C03D00", VA = "0x184C04B00")]
	public static void POFJKILAHPO(object KFCOOCIKJFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x4C04920", Offset = "0x4C03B20", VA = "0x184C04920")]
	public static void OJFBELMCBMO(object KFCOOCIKJFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x4C042B0", Offset = "0x4C034B0", VA = "0x184C042B0")]
	private static Color KLEIMDHCDMH(int GGMEAHKJCJC, int DHBFNIJNBON, float HAIMIFOJMEM, float AKDMMHMMCHF)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x4C03FE0", Offset = "0x4C031E0", VA = "0x184C03FE0")]
	public static void EPGCCMNLLMG(object KFCOOCIKJFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x4C041C0", Offset = "0x4C033C0", VA = "0x184C041C0")]
	private static Color IFLGMDMJDMJ(Color GJEFODHDPEH, Color KELHFOJANGL, float EOEMKDLOAGI)
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
