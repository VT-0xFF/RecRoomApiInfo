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
		[Cpp2IlInjected.Address(RVA = "0x2197390", Offset = "0x2196190", VA = "0x182197390")]
		public CubeMapGenerator()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public enum GMEFCEADAKM
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
public interface KAFHIBAIPBP
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	GMEFCEADAKM BGCCONDCKHP
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class PBOIBLIHFLK
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
			[Cpp2IlInjected.Address(RVA = "0x219A280", Offset = "0x2199080", VA = "0x18219A280")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x219A270", Offset = "0x2199070", VA = "0x18219A270")]
		public Resolution(uint IDDALCIIJOJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x8A9760", Offset = "0x8A8560", VA = "0x1808A9760")]
		public Resolution(uint IDDALCIIJOJ, uint GIJPFDNHKHN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x219A180", Offset = "0x2198F80", VA = "0x18219A180")]
		public static Resolution CMMHCIHHJIE(Resolution[] LACOAEKOGLC, Resolution CALKHMPGMJF, int NLAJCADFDJL)
		{
			return default(Resolution);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public class JHGEHHHODMP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private readonly Resolution NHKACNEKILA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private Resolution? HCOAMANDEMD;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public uint IDDALCIIJOJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x2197830", Offset = "0x2196630", VA = "0x182197830")]
			get
			{
				return default(uint);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public uint GIJPFDNHKHN
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x2197840", Offset = "0x2196640", VA = "0x182197840")]
			get
			{
				return default(uint);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public Resolution PEBIPHJGIDE
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x2197860", Offset = "0x2196660", VA = "0x182197860")]
			get
			{
				return default(Resolution);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x1EAADC0", Offset = "0x1EA9BC0", VA = "0x181EAADC0")]
		public JHGEHHHODMP(Resolution NHKACNEKILA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x2197690", Offset = "0x2196490", VA = "0x182197690")]
		private static Resolution GOAEIHOFKIM(Resolution HCOAMANDEMD, GMEFCEADAKM DFIHKJJODLF)
		{
			return default(Resolution);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public static class DNLEDGPGGCH
	{
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public static readonly Resolution FCCFCAHKKCN;

		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public static readonly Resolution OJABKCBGGKJ;

		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public static readonly Resolution FPCGAAALEEM;

		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public static readonly Resolution NIEMLACBCCP;

		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public static readonly Resolution HANIAIPPAKA;

		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public static readonly Resolution JFFMABKHFFD;

		[Cpp2IlInjected.Token(Token = "0x4000014")]
		internal static readonly Resolution[] IMJNLCBFLHH;
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public static class OALEMEBAKDB
	{
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public static readonly Resolution GHOKMDAPIHN;

		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public static readonly Resolution NBHCPBOPGFJ;

		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public static readonly Resolution LIELJDNIIGP;

		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public static readonly Resolution CGFIDJEIMPN;

		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public static readonly Resolution NFJKFPICOIJ;

		[Cpp2IlInjected.Token(Token = "0x400001A")]
		internal static readonly Resolution[] IMJNLCBFLHH;

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x2198990", Offset = "0x2197790", VA = "0x182198990")]
		public static Resolution EJFPMLNFPDD(uint IHIELFHBHBE)
		{
			return default(Resolution);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public static readonly Resolution BFFHLPJHCGE;

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x2199D00", Offset = "0x2198B00", VA = "0x182199D00")]
	public static bool NPODPEADCON(uint HOLFHCLAMDI)
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
		public enum GMNADIIKMGJ : byte
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
		private class BCCDGDHBBNO : IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			private string CCEKFDNIAPD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			public Texture2D LFPDAJJFNKI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400002C")]
			public GMNADIIKMGJ IFCDBLHBOLB;

			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x2197340", Offset = "0x2196140", VA = "0x182197340")]
			public BCCDGDHBBNO(string CCEKFDNIAPD)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0xA720E0", Offset = "0xA70EE0", VA = "0x180A720E0")]
			public BCCDGDHBBNO(string CCEKFDNIAPD, Texture2D MACEMPHCNCG, GMNADIIKMGJ HNEKFLDDGIL)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x2197300", Offset = "0x2196100", VA = "0x182197300", Slot = "4")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000D")]
		[CompilerGenerated]
		private sealed class GIFNPCDGKDM
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400002D")]
			public ManagedTexture <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400002E")]
			public GMNADIIKMGJ textureMemory;

			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x6D2360", Offset = "0x6D1160", VA = "0x1806D2360")]
			public GIFNPCDGKDM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x2197650", Offset = "0x2196450", VA = "0x182197650")]
			internal void <GetManagedTexture>b__0()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000E")]
		[CompilerGenerated]
		private sealed class DJBIHNKFEAO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400002F")]
			public int quality;

			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x6D2360", Offset = "0x6D1160", VA = "0x1806D2360")]
			public DJBIHNKFEAO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x21973B0", Offset = "0x21961B0", VA = "0x1821973B0")]
			internal byte[] <EncodeToJPG>b__0(Texture2D t2d)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000F")]
		[CompilerGenerated]
		private sealed class AJMLNOHBIMF
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000030")]
			public RenderTexture tempRenderTexture;

			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x6D2360", Offset = "0x6D1160", VA = "0x1806D2360")]
			public AJMLNOHBIMF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x2197270", Offset = "0x2196070", VA = "0x182197270")]
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
		private global::KOILDJEEFJD<Texture2D> _cpuSidePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private BCCDGDHBBNO _memTexture;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private global::KOILDJEEFJD<byte[]> _jpgEncodePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private byte[] _jpgBytes;

		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public const int DEFAULT_JPG_QUALITY = 80;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private global::KOILDJEEFJD<byte[]> _pngEncodePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private byte[] _pngBytes;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public bool UsePalette
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x8E8110", Offset = "0x8E6F10", VA = "0x1808E8110")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public RenderTexture LastRenderTexture
		{
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x6C5D30", Offset = "0x6C4B30", VA = "0x1806C5D30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x6FAD80", Offset = "0x6F9B80", VA = "0x1806FAD80")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		private BCCDGDHBBNO memoryTexture
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x21988F0", Offset = "0x21976F0", VA = "0x1821988F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x21988A0", Offset = "0x21976A0", VA = "0x1821988A0")]
		public ManagedTexture(string CCEKFDNIAPD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x2198840", Offset = "0x2197640", VA = "0x182198840")]
		public ManagedTexture(string CCEKFDNIAPD, bool BCEAHKCBFEP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x2198650", Offset = "0x2197450", VA = "0x182198650")]
		public void PCFBLKNCOPH(RenderTexture MHFALDDJPCP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x2198340", Offset = "0x2197140", VA = "0x182198340")]
		public global::KOILDJEEFJD<byte[]> LHMEFCLGLCF(bool EHBGGJGBMJF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x2198360", Offset = "0x2197160", VA = "0x182198360")]
		public global::KOILDJEEFJD<Texture2D> MKCIINOLGIG(GMNADIIKMGJ HNEKFLDDGIL, bool PHBIHKGBJHL = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x2198140", Offset = "0x2196F40", VA = "0x182198140")]
		public global::KOILDJEEFJD<byte[]> LAOKAMPOKKC(bool PHBIHKGBJHL = false, int BAGOOKJPBCM = 80)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x2198680", Offset = "0x2197480", VA = "0x182198680")]
		public global::KOILDJEEFJD<byte[]> PJJOCEPCEKB(bool PHBIHKGBJHL = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x2197B10", Offset = "0x2196910", VA = "0x182197B10")]
		private static global::KOILDJEEFJD<Texture2D> FBPBBMAKOLG(string CCEKFDNIAPD, RenderTexture MHFALDDJPCP, ref Texture2D DOBOCAMAHJF, bool PHBIHKGBJHL, GMNADIIKMGJ LCCBKFLDPGG = GMNADIIKMGJ.GPU)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x2197A40", Offset = "0x2196840", VA = "0x182197A40")]
		public void CKEFJFIBFCO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x2197B00", Offset = "0x2196900", VA = "0x182197B00", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x2198090", Offset = "0x2196E90", VA = "0x182198090")]
		[CompilerGenerated]
		private global::KOILDJEEFJD<byte[]> JHDMEFDJABI(Texture2D JOHJEKEMCLN)
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public static class PPCJCNFEBFH
{
	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x2199F60", Offset = "0x2198D60", VA = "0x182199F60")]
	public static RenderTexture IACNKKLNFOD(int IHIELFHBHBE, int KDPPAHMOANJ, int BEGFELCMNHC, Camera JGGPGHMADLC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x219A110", Offset = "0x2198F10", VA = "0x18219A110")]
	public static void LKONPEAJGEJ(RenderTexture MHFALDDJPCP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class OPIGIPJGOLO
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public class EKOBACPONAN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public int CPMHNPIOINN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public int DAFMFEFJEFF;

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x12550C0", Offset = "0x1253EC0", VA = "0x1812550C0")]
		public EKOBACPONAN(int CJELHHBKKOG, int HOJKPDKANGJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	private enum PKBPDCPFEJD
	{
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		Point,
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		Bilinear,
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		Average
	}

	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private static Color[] KJFAGHBAKCB;

	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private static Color[] ABOMLCIIMMD;

	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private static int FALKGHPMDGO;

	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private static float AHJBAHIHKFK;

	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private static float EPMGKIAJJLB;

	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private static int CHFBHPJODLE;

	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private static int KPKGIJBPHFD;

	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private static Mutex ACLAMIMOMOJ;

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x2199CE0", Offset = "0x2198AE0", VA = "0x182199CE0")]
	public static void MHANNKNLHPE(Texture2D HJIKDFIFJPI, int KBABKOKCGNP, int DKJCEKOGNDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x2198FD0", Offset = "0x2197DD0", VA = "0x182198FD0")]
	private static void IDMKNCLKLJG(Texture2D HJIKDFIFJPI, int KBABKOKCGNP, int DKJCEKOGNDF, PKBPDCPFEJD GFKEBOENNOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x2199860", Offset = "0x2198660", VA = "0x182199860")]
	public static void MFFKBEENFPO(object LOPIEGGIDMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x21994C0", Offset = "0x21982C0", VA = "0x1821994C0")]
	public static void KMMJLBLOMHM(object LOPIEGGIDMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x2198E30", Offset = "0x2197C30", VA = "0x182198E30")]
	private static Color HLBKAJHDIJC(int IDDALCIIJOJ, int GIJPFDNHKHN, float AHJBAHIHKFK, float EPMGKIAJJLB)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x2199690", Offset = "0x2198490", VA = "0x182199690")]
	public static void LCAHGDEGPCG(object LOPIEGGIDMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x2198D50", Offset = "0x2197B50", VA = "0x182198D50")]
	private static Color DMCFMGOPPJG(Color ADLLHAKFDLL, Color CEOKNKIJANN, float DPJGMDFEIDL)
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
