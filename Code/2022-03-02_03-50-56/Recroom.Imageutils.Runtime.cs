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
		[Cpp2IlInjected.Address(RVA = "0x49DE420", Offset = "0x49DD420", VA = "0x1849DE420")]
		public CubeMapGenerator()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public enum ABPKNGFIBGL
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
public interface MFNCBAKJBIF
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	ABPKNGFIBGL JOAAIBEPEPL
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class HCCAIJCFMEA
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
			[Cpp2IlInjected.Address(RVA = "0x49E01C0", Offset = "0x49DF1C0", VA = "0x1849E01C0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x49E01B0", Offset = "0x49DF1B0", VA = "0x1849E01B0")]
		public Resolution(uint LLFMGCPPNJC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x69F3B0", Offset = "0x69E3B0", VA = "0x18069F3B0")]
		public Resolution(uint LLFMGCPPNJC, uint JPNAADDLLDM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x49E0060", Offset = "0x49DF060", VA = "0x1849E0060")]
		public static Resolution IONNLCABJBF(Resolution[] OFJFCNIJHCG, Resolution DNCGKKHFPIF, int PCHCGODLOKJ)
		{
			return default(Resolution);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public class FOHENMHOOGJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private readonly Resolution MHKPCGDNFJB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private Resolution? JIADEBBDJMN;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public uint LLFMGCPPNJC
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x49DE7E0", Offset = "0x49DD7E0", VA = "0x1849DE7E0")]
			get
			{
				return default(uint);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public uint JPNAADDLLDM
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x49DE7F0", Offset = "0x49DD7F0", VA = "0x1849DE7F0")]
			get
			{
				return default(uint);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public Resolution BGKBIDNGFHM
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x49DE9E0", Offset = "0x49DD9E0", VA = "0x1849DE9E0")]
			get
			{
				return default(Resolution);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x1119290", Offset = "0x1118290", VA = "0x181119290")]
		public FOHENMHOOGJ(Resolution MHKPCGDNFJB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x49DE810", Offset = "0x49DD810", VA = "0x1849DE810")]
		private static Resolution FJBGJHICGMG(Resolution JIADEBBDJMN, ABPKNGFIBGL IIIBPOKJNEB)
		{
			return default(Resolution);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public static class MNIMFJILOIN
	{
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public static readonly Resolution PCCLOFEPFFN;

		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public static readonly Resolution OOCMCLADALD;

		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public static readonly Resolution BGJDIHGLEGM;

		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public static readonly Resolution GMGHLHEJOME;

		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public static readonly Resolution DFIDIOECLMJ;

		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public static readonly Resolution CMHOOPALIEA;

		[Cpp2IlInjected.Token(Token = "0x4000014")]
		internal static readonly Resolution[] GBHOCNFEDOI;
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public static class EJACDHOBAAB
	{
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public static readonly Resolution OIBBPPEEHNO;

		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public static readonly Resolution DBEKIEMOPKD;

		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public static readonly Resolution NIOEDGCNFIG;

		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public static readonly Resolution PBAHJGDKJBH;

		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public static readonly Resolution APONCLLOFGF;

		[Cpp2IlInjected.Token(Token = "0x400001A")]
		internal static readonly Resolution[] GBHOCNFEDOI;

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x49DE440", Offset = "0x49DD440", VA = "0x1849DE440")]
		public static Resolution DLPNEANHAOA(uint AGCGFKAOCBO)
		{
			return default(Resolution);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public static readonly Resolution DLAKFHNKNFP;

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x49DEBE0", Offset = "0x49DDBE0", VA = "0x1849DEBE0")]
	public static bool FEGIDBPHDDO(uint DOKCKPPPKOC)
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
		public enum PMLMBLDDPIG : byte
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
		private class AAPDBLDJEEI : IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			private string GDCCAEJAPNJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			public Texture2D OFCIKPMLJKA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400002C")]
			public PMLMBLDDPIG ILJLMLHAHMA;

			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x49DD330", Offset = "0x49DC330", VA = "0x1849DD330")]
			public AAPDBLDJEEI(string GDCCAEJAPNJ)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0xA7DE70", Offset = "0xA7CE70", VA = "0x180A7DE70")]
			public AAPDBLDJEEI(string GDCCAEJAPNJ, Texture2D NFJNFINDLPF, PMLMBLDDPIG EDAHFEPGELA)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x49DD2F0", Offset = "0x49DC2F0", VA = "0x1849DD2F0", Slot = "4")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000D")]
		[CompilerGenerated]
		private sealed class BGDGOCCOGGP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400002D")]
			public ManagedTexture <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400002E")]
			public PMLMBLDDPIG textureMemory;

			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x50D000", Offset = "0x50C000", VA = "0x18050D000")]
			public BGDGOCCOGGP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x49DD380", Offset = "0x49DC380", VA = "0x1849DD380")]
			internal void <GetManagedTexture>b__0()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000E")]
		[CompilerGenerated]
		private sealed class MHNNDMEIMJD
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400002F")]
			public int quality;

			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x50D000", Offset = "0x50C000", VA = "0x18050D000")]
			public MHNNDMEIMJD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x49DEE20", Offset = "0x49DDE20", VA = "0x1849DEE20")]
			internal byte[] <EncodeToJPG>b__0(Texture2D t2d)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000F")]
		[CompilerGenerated]
		private sealed class AAHGLFDAJGM
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000030")]
			public RenderTexture tempRenderTexture;

			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x50D000", Offset = "0x50C000", VA = "0x18050D000")]
			public AAHGLFDAJGM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x49DD260", Offset = "0x49DC260", VA = "0x1849DD260")]
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
		private global::HMPJDJAALAE<Texture2D> _cpuSidePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private AAPDBLDJEEI _memTexture;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private global::HMPJDJAALAE<byte[]> _jpgEncodePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private byte[] _jpgBytes;

		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public const int DEFAULT_JPG_QUALITY = 80;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private global::HMPJDJAALAE<byte[]> _pngEncodePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private byte[] _pngBytes;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public bool UsePalette
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x5600F0", Offset = "0x55F0F0", VA = "0x1805600F0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public RenderTexture LastRenderTexture
		{
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x511480", Offset = "0x510480", VA = "0x180511480")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x514510", Offset = "0x513510", VA = "0x180514510")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		private AAPDBLDJEEI memoryTexture
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x49DFDE0", Offset = "0x49DEDE0", VA = "0x1849DFDE0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x49DFD90", Offset = "0x49DED90", VA = "0x1849DFD90")]
		public ManagedTexture(string GDCCAEJAPNJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x49DFD30", Offset = "0x49DED30", VA = "0x1849DFD30")]
		public ManagedTexture(string GDCCAEJAPNJ, bool KODFMOCIPBN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x49DF330", Offset = "0x49DE330", VA = "0x1849DF330")]
		public void FKMLMAJCOIP(RenderTexture FBDGJPAMFGN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x49DF310", Offset = "0x49DE310", VA = "0x1849DF310")]
		public global::HMPJDJAALAE<byte[]> FCPIPECJENB(bool OBPLMCLAJBB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x49DFA00", Offset = "0x49DEA00", VA = "0x1849DFA00")]
		public global::HMPJDJAALAE<Texture2D> MDPAAGOCKOH(PMLMBLDDPIG EDAHFEPGELA, bool ABGLAGCDKMF = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x49DF850", Offset = "0x49DE850", VA = "0x1849DF850")]
		public global::HMPJDJAALAE<byte[]> LAPNKALIOMK(bool ABGLAGCDKMF = false, int GLCOFFJCMDP = 80)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x49DF0B0", Offset = "0x49DE0B0", VA = "0x1849DF0B0")]
		public global::HMPJDJAALAE<byte[]> AFAJIOJIJCL(bool ABGLAGCDKMF = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x49DF360", Offset = "0x49DE360", VA = "0x1849DF360")]
		private static global::HMPJDJAALAE<Texture2D> IKBONHOFLJO(string GDCCAEJAPNJ, RenderTexture FBDGJPAMFGN, ref Texture2D GLEGAGBCCOK, bool ABGLAGCDKMF, PMLMBLDDPIG AINFEKLADFH = PMLMBLDDPIG.GPU)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x49DF240", Offset = "0x49DE240", VA = "0x1849DF240")]
		public void BNJCEBDNHCB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x49DF300", Offset = "0x49DE300", VA = "0x1849DF300", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x49DFC90", Offset = "0x49DEC90", VA = "0x1849DFC90")]
		[CompilerGenerated]
		private global::HMPJDJAALAE<byte[]> OFLFMOFMFJH(Texture2D FPFNJMKNLCP)
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public static class NHONFCENANK
{
	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x49DFE80", Offset = "0x49DEE80", VA = "0x1849DFE80")]
	public static RenderTexture DBOBBFGGJOF(int AGCGFKAOCBO, int DGPMNFKJNDI, int EIIGHGIDAOK, Camera BGPNLIAFPNF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x49DFFF0", Offset = "0x49DEFF0", VA = "0x1849DFFF0")]
	public static void GDHEMNKKAAE(RenderTexture FBDGJPAMFGN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class CDBAPACBJBM
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public class KACKOPPKFDA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public int ICBNMBILIBM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public int MBPMMGMNCKG;

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x61E6F0", Offset = "0x61D6F0", VA = "0x18061E6F0")]
		public KACKOPPKFDA(int JEOKDIGJIBK, int KFHJIBPHHGJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	private enum BEDMNNOFCBE
	{
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		Point,
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		Bilinear,
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		Average
	}

	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private static Color[] DMPDBDKDNNC;

	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private static Color[] OFCIHOPKMMA;

	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private static int IBKHPENJJPF;

	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private static float BHJMGOAJGMI;

	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private static float BIAIIMIAHKJ;

	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private static int DLCNGFOJIEK;

	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private static int BPIANFFHKIE;

	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private static Mutex CJJAOPLJCCL;

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x49DD5A0", Offset = "0x49DC5A0", VA = "0x1849DD5A0")]
	public static void BDBKFOBFGEN(Texture2D FLGKCFDBBLH, int AGJBPNKGJNJ, int KFIGPICMEAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x49DD780", Offset = "0x49DC780", VA = "0x1849DD780")]
	private static void KGMCAMINPLJ(Texture2D FLGKCFDBBLH, int AGJBPNKGJNJ, int KFIGPICMEAP, BEDMNNOFCBE PCBNHJBHPCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x49DDD20", Offset = "0x49DCD20", VA = "0x1849DDD20")]
	public static void LAFAGHIAOAM(object CKMKLMKNMPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x49DD3C0", Offset = "0x49DC3C0", VA = "0x1849DD3C0")]
	public static void BCBPLCHDBAD(object CKMKLMKNMPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x49DD5C0", Offset = "0x49DC5C0", VA = "0x1849DD5C0")]
	private static Color KGFIFODPLPA(int LLFMGCPPNJC, int JPNAADDLLDM, float BHJMGOAJGMI, float BIAIIMIAHKJ)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x49DE240", Offset = "0x49DD240", VA = "0x1849DE240")]
	public static void PHDCFMGBOFJ(object CKMKLMKNMPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x49DDC30", Offset = "0x49DCC30", VA = "0x1849DDC30")]
	private static Color KNPMAEKMHAA(Color DCIACIPFFPK, Color OIMGNDJLGFG, float DDDOLDGEMNC)
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
