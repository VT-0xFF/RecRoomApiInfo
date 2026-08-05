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
		[Cpp2IlInjected.Address(RVA = "0x5FDD8A0", Offset = "0x5FDCCA0", VA = "0x185FDD8A0")]
		public CubeMapGenerator()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public enum KCFGCECHGCL
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
public interface DBHHGNCOGNP
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	KCFGCECHGCL DJIGFBOGDHP
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class ELAJGEJMFBI
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
			[Cpp2IlInjected.Address(RVA = "0x5FE0450", Offset = "0x5FDF850", VA = "0x185FE0450")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x5FE0440", Offset = "0x5FDF840", VA = "0x185FE0440")]
		public Resolution(uint HHAEMEGNPGJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x68E050", Offset = "0x68D450", VA = "0x18068E050")]
		public Resolution(uint HHAEMEGNPGJ, uint ACCHMFPFGHP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x5FE0350", Offset = "0x5FDF750", VA = "0x185FE0350")]
		public static Resolution IANPEBGBBLA(Resolution[] EGGIDBBMBNM, Resolution AKIFLGNCNBN, int JPCMFIHBNIE)
		{
			return default(Resolution);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public class BOGFNKBGGLI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private readonly Resolution EBGHGKONJLP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private Resolution? PKGCEHIILIL;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public uint HHAEMEGNPGJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x5FDD510", Offset = "0x5FDC910", VA = "0x185FDD510")]
			get
			{
				return default(uint);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public uint ACCHMFPFGHP
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x5FDD4F0", Offset = "0x5FDC8F0", VA = "0x185FDD4F0")]
			get
			{
				return default(uint);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public Resolution FAOALHDDKHF
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x5FDD520", Offset = "0x5FDC920", VA = "0x185FDD520")]
			get
			{
				return default(Resolution);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x17A76C0", Offset = "0x17A6AC0", VA = "0x1817A76C0")]
		public BOGFNKBGGLI(Resolution EBGHGKONJLP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x5FDD700", Offset = "0x5FDCB00", VA = "0x185FDD700")]
		private static Resolution KFAACBLLPLN(Resolution PKGCEHIILIL, KCFGCECHGCL BPBDHIINCAF)
		{
			return default(Resolution);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public static class MCLINKOLMJH
	{
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public static readonly Resolution NIKBGOMKOJF;

		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public static readonly Resolution DBFIEPEOLBJ;

		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public static readonly Resolution ENGKBKIDCNF;

		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public static readonly Resolution DKMBHNGIPLN;

		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public static readonly Resolution IPGCLJCONJK;

		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public static readonly Resolution HGMGOMHCALF;

		[Cpp2IlInjected.Token(Token = "0x4000014")]
		internal static readonly Resolution[] KMJIBMBLLCL;
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public static class KKMCILNDPFM
	{
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public static readonly Resolution KOEBBBAFPIK;

		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public static readonly Resolution DCOMHPCAPFI;

		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public static readonly Resolution EBMECMDDDJK;

		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public static readonly Resolution NFCNGCCJOOF;

		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public static readonly Resolution KFEGAFGCBNE;

		[Cpp2IlInjected.Token(Token = "0x400001A")]
		internal static readonly Resolution[] KMJIBMBLLCL;

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x5FDEBA0", Offset = "0x5FDDFA0", VA = "0x185FDEBA0")]
		public static Resolution GFDKLEEDHEP(uint ILNHJCKAKCL)
		{
			return default(Resolution);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public static readonly Resolution DDPKBGGANJP;

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x5FDE870", Offset = "0x5FDDC70", VA = "0x185FDE870")]
	public static bool KIABEDHHFFD(uint JCCDEHAIAGF)
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
		public enum PLJNCFFCJGI : byte
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
		private class BIOLKBLENGK : IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			private string JODEBEIHAPC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			public Texture2D GHONKGEEMJC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400002C")]
			public PLJNCFFCJGI APLJJOKHIGA;

			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x5FDD4A0", Offset = "0x5FDC8A0", VA = "0x185FDD4A0")]
			public BIOLKBLENGK(string JODEBEIHAPC)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x673750", Offset = "0x672B50", VA = "0x180673750")]
			public BIOLKBLENGK(string JODEBEIHAPC, Texture2D JKBJLGEJIHH, PLJNCFFCJGI ONLCDDLCCPA)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x5FDD460", Offset = "0x5FDC860", VA = "0x185FDD460", Slot = "4")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000D")]
		[CompilerGenerated]
		private sealed class HFDGAPEGGJD
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400002D")]
			public ManagedTexture <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400002E")]
			public PLJNCFFCJGI textureMemory;

			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x66EB30", Offset = "0x66DF30", VA = "0x18066EB30")]
			public HFDGAPEGGJD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x5FDEB60", Offset = "0x5FDDF60", VA = "0x185FDEB60")]
			internal void <GetManagedTexture>b__0()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000E")]
		[CompilerGenerated]
		private sealed class AFOJFBOIICJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400002F")]
			public int quality;

			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x66EB30", Offset = "0x66DF30", VA = "0x18066EB30")]
			public AFOJFBOIICJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x5FDD440", Offset = "0x5FDC840", VA = "0x185FDD440")]
			internal byte[] <EncodeToJPG>b__0(Texture2D t2d)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000F")]
		[CompilerGenerated]
		private sealed class GOLHJOCCKOL
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000030")]
			public RenderTexture tempRenderTexture;

			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x66EB30", Offset = "0x66DF30", VA = "0x18066EB30")]
			public GOLHJOCCKOL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x5FDEAD0", Offset = "0x5FDDED0", VA = "0x185FDEAD0")]
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
		private global::BHPNOFOGFAO<Texture2D> _cpuSidePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private BIOLKBLENGK _memTexture;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private global::BHPNOFOGFAO<byte[]> _jpgEncodePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private byte[] _jpgBytes;

		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public const int DEFAULT_JPG_QUALITY = 80;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private global::BHPNOFOGFAO<byte[]> _pngEncodePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private byte[] _pngBytes;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public bool UsePalette
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x671250", Offset = "0x670650", VA = "0x180671250")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public RenderTexture LastRenderTexture
		{
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x66E120", Offset = "0x66D520", VA = "0x18066E120")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x66E130", Offset = "0x66D530", VA = "0x18066E130")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		private BIOLKBLENGK memoryTexture
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x5FE0090", Offset = "0x5FDF490", VA = "0x185FE0090")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x5FE0040", Offset = "0x5FDF440", VA = "0x185FE0040")]
		public ManagedTexture(string JODEBEIHAPC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x5FDFFE0", Offset = "0x5FDF3E0", VA = "0x185FDFFE0")]
		public ManagedTexture(string JODEBEIHAPC, bool PGFMOGLHGBB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x5FDFFB0", Offset = "0x5FDF3B0", VA = "0x185FDFFB0")]
		public void ONNGOHDFPHB(RenderTexture BIHPNNBGLKP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x5FDF2A0", Offset = "0x5FDE6A0", VA = "0x185FDF2A0")]
		public global::BHPNOFOGFAO<byte[]> GAAIKCCOHLO(bool KKGNLAKPOOK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x5FDF840", Offset = "0x5FDEC40", VA = "0x185FDF840")]
		public global::BHPNOFOGFAO<Texture2D> IIEMDLMGPDA(PLJNCFFCJGI ONLCDDLCCPA, bool OABLBEDFEOA = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x5FDFB30", Offset = "0x5FDEF30", VA = "0x185FDFB30")]
		public global::BHPNOFOGFAO<byte[]> IKKMAEPELCF(bool OABLBEDFEOA = false, int LFKIEBAGFNF = 80)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x5FDFD30", Offset = "0x5FDF130", VA = "0x185FDFD30")]
		public global::BHPNOFOGFAO<byte[]> NGKPAAGBNIL(bool OABLBEDFEOA = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x5FDF2C0", Offset = "0x5FDE6C0", VA = "0x185FDF2C0")]
		private static global::BHPNOFOGFAO<Texture2D> GKADHIADEML(string JODEBEIHAPC, RenderTexture BIHPNNBGLKP, ref Texture2D FECIFDBHEDG, bool OABLBEDFEOA, PLJNCFFCJGI HNJOBBBCILH = PLJNCFFCJGI.GPU)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x5FDFEF0", Offset = "0x5FDF2F0", VA = "0x185FDFEF0")]
		public void ONBHKJLFNIL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x5FDF290", Offset = "0x5FDE690", VA = "0x185FDF290", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x5FDF1E0", Offset = "0x5FDE5E0", VA = "0x185FDF1E0")]
		[CompilerGenerated]
		private global::BHPNOFOGFAO<byte[]> BMKNGBPPPII(Texture2D LNJKILBOHDD)
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public static class PABLOMLDIOD
{
	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x5FE01A0", Offset = "0x5FDF5A0", VA = "0x185FE01A0")]
	public static RenderTexture JJEBPDAKFLK(int ILNHJCKAKCL, int LGPCJCBIAHN, int KJKHPEKCAGF, Camera GPLNPMCNMLF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x5FE0130", Offset = "0x5FDF530", VA = "0x185FE0130")]
	public static void GGOIBHPMCEM(RenderTexture BIHPNNBGLKP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class DENPNDHGCJB
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public class HMMJEHLGGAL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public int BOIMPMGFDJM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public int NBODAMBMIAE;

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x8D32F0", Offset = "0x8D26F0", VA = "0x1808D32F0")]
		public HMMJEHLGGAL(int OINEAABDMLI, int CLHMIOKIOGP)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	private enum JPLAMDNOLBP
	{
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		Point,
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		Bilinear,
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		Average
	}

	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private static Color[] NFCHBOJMMJB;

	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private static Color[] PGHFJDGNJOL;

	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private static int CIBKDAIJBIH;

	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private static float CFNIOANNONI;

	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private static float NNIEEHPMMAH;

	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private static int AOFPNLEBFKL;

	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private static int FOHOMDDACGI;

	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private static Mutex BPELDAECLOK;

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x5FDE200", Offset = "0x5FDD600", VA = "0x185FDE200")]
	public static void LJHOGPIHFPG(Texture2D IMJEMFLKGED, int FNHODBMDFNF, int FAEDPPGNGOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x5FDD8C0", Offset = "0x5FDCCC0", VA = "0x185FDD8C0")]
	private static void AANGAGMMFKA(Texture2D IMJEMFLKGED, int FNHODBMDFNF, int FAEDPPGNGOG, JPLAMDNOLBP IKIEHNNFDEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x5FDE3F0", Offset = "0x5FDD7F0", VA = "0x185FDE3F0")]
	public static void PHHLJDGFADO(object HKFNIHLBEHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x5FDDDB0", Offset = "0x5FDD1B0", VA = "0x185FDDDB0")]
	public static void ELHJIDJIIMH(object HKFNIHLBEHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x5FDE060", Offset = "0x5FDD460", VA = "0x185FDE060")]
	private static Color KLJODDCLLJI(int HHAEMEGNPGJ, int ACCHMFPFGHP, float CFNIOANNONI, float NNIEEHPMMAH)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x5FDE220", Offset = "0x5FDD620", VA = "0x185FDE220")]
	public static void MMDGACJPCFG(object HKFNIHLBEHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x5FDDF80", Offset = "0x5FDD380", VA = "0x185FDDF80")]
	private static Color HKEMJIEFHKK(Color ILDCPEHHKPE, Color OLBCLMAKDOJ, float PKODKJLGOIN)
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
