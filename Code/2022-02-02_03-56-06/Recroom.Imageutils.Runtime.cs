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
		[Cpp2IlInjected.Address(RVA = "0x46A25A0", Offset = "0x46A15A0", VA = "0x1846A25A0")]
		public CubeMapGenerator()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public enum OGHBHHOAIFL
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
public interface GFNOPJBCPOM
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	OGHBHHOAIFL HLKIMKHJBHC
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class CLHGANKPCJC
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
			[Cpp2IlInjected.Address(RVA = "0x46A4F20", Offset = "0x46A3F20", VA = "0x1846A4F20")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x46A4F10", Offset = "0x46A3F10", VA = "0x1846A4F10")]
		public Resolution(uint APLMPEFFNCL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x619B00", Offset = "0x618B00", VA = "0x180619B00")]
		public Resolution(uint APLMPEFFNCL, uint IKBPIALPOCI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x46A4DC0", Offset = "0x46A3DC0", VA = "0x1846A4DC0")]
		public static Resolution BJGOMCNPPIN(Resolution[] HFFNLENLBJF, Resolution CKBKMGBADNJ, int PJHCCHKNHEC)
		{
			return default(Resolution);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public class GIHLPIGNMKC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private readonly Resolution LACJMHIPAID;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private Resolution? NMGNOOHOMOI;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public uint APLMPEFFNCL
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x46A29B0", Offset = "0x46A19B0", VA = "0x1846A29B0")]
			get
			{
				return default(uint);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public uint IKBPIALPOCI
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x46A25C0", Offset = "0x46A15C0", VA = "0x1846A25C0")]
			get
			{
				return default(uint);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public Resolution NCACOOOHAEP
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x46A25E0", Offset = "0x46A15E0", VA = "0x1846A25E0")]
			get
			{
				return default(Resolution);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x2901FB0", Offset = "0x2900FB0", VA = "0x182901FB0")]
		public GIHLPIGNMKC(Resolution LACJMHIPAID)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x46A27E0", Offset = "0x46A17E0", VA = "0x1846A27E0")]
		private static Resolution IPNOLEFMGHJ(Resolution NMGNOOHOMOI, OGHBHHOAIFL ABGMOIGPDHD)
		{
			return default(Resolution);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public static class MNBANAIMMOP
	{
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public static readonly Resolution CEOFCMFDEGH;

		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public static readonly Resolution CPIHGKMNKHL;

		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public static readonly Resolution LPOCHBEBKLO;

		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public static readonly Resolution CCHIBBAEGPF;

		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public static readonly Resolution OEPNLILLGAA;

		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public static readonly Resolution LEHFOLMDCMP;

		[Cpp2IlInjected.Token(Token = "0x4000014")]
		internal static readonly Resolution[] IEJDDMDELAP;
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public static class AGEFHFNGHKJ
	{
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public static readonly Resolution ONHGFEIOGFF;

		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public static readonly Resolution FAPEKMPECFJ;

		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public static readonly Resolution PKFDNLCOCJI;

		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public static readonly Resolution HGGBIIMEHGD;

		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public static readonly Resolution IBHIBMDKEAF;

		[Cpp2IlInjected.Token(Token = "0x400001A")]
		internal static readonly Resolution[] IEJDDMDELAP;

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x46A1FC0", Offset = "0x46A0FC0", VA = "0x1846A1FC0")]
		public static Resolution HGKMPNALILB(uint OAMJGHNKFHG)
		{
			return default(Resolution);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public static readonly Resolution HMOGEAECOEI;

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x46A2360", Offset = "0x46A1360", VA = "0x1846A2360")]
	public static bool MBBGPJAFJED(uint FMNDOHHHOJL)
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
		public enum JLNBLACPAHP : byte
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
		private class IHNEFKMPHMA : IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			private string GKOIMGFECPK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			public Texture2D GONJMJLDKLJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400002C")]
			public JLNBLACPAHP CMDCALPMKGP;

			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x46A2A00", Offset = "0x46A1A00", VA = "0x1846A2A00")]
			public IHNEFKMPHMA(string GKOIMGFECPK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x88F310", Offset = "0x88E310", VA = "0x18088F310")]
			public IHNEFKMPHMA(string GKOIMGFECPK, Texture2D JHCNPHCCFJC, JLNBLACPAHP KBIOPGHHEAG)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x46A29C0", Offset = "0x46A19C0", VA = "0x1846A29C0", Slot = "4")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000D")]
		[CompilerGenerated]
		private sealed class MMLIKCEONOG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400002D")]
			public ManagedTexture <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400002E")]
			public JLNBLACPAHP textureMemory;

			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x4E5AB0", Offset = "0x4E4AB0", VA = "0x1804E5AB0")]
			public MMLIKCEONOG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x46A3AB0", Offset = "0x46A2AB0", VA = "0x1846A3AB0")]
			internal void <GetManagedTexture>b__0()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000E")]
		[CompilerGenerated]
		private sealed class PILDJBNOKJG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400002F")]
			public int quality;

			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x4E5AB0", Offset = "0x4E4AB0", VA = "0x1804E5AB0")]
			public PILDJBNOKJG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x46A4DA0", Offset = "0x46A3DA0", VA = "0x1846A4DA0")]
			internal byte[] <EncodeToJPG>b__0(Texture2D t2d)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000F")]
		[CompilerGenerated]
		private sealed class NAJFGLIKIII
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000030")]
			public RenderTexture tempRenderTexture;

			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x4E5AB0", Offset = "0x4E4AB0", VA = "0x1804E5AB0")]
			public NAJFGLIKIII()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x46A4B30", Offset = "0x46A3B30", VA = "0x1846A4B30")]
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
		private global::IDCJFNACHEM<Texture2D> _cpuSidePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private IHNEFKMPHMA _memTexture;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private global::IDCJFNACHEM<byte[]> _jpgEncodePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private byte[] _jpgBytes;

		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public const int DEFAULT_JPG_QUALITY = 80;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private global::IDCJFNACHEM<byte[]> _pngEncodePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private byte[] _pngBytes;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public bool UsePalette
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x50E7B0", Offset = "0x50D7B0", VA = "0x18050E7B0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public RenderTexture LastRenderTexture
		{
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x4E5DF0", Offset = "0x4E4DF0", VA = "0x1804E5DF0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x50DD70", Offset = "0x50CD70", VA = "0x18050DD70")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		private IHNEFKMPHMA memoryTexture
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x46A4A90", Offset = "0x46A3A90", VA = "0x1846A4A90")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x46A4A40", Offset = "0x46A3A40", VA = "0x1846A4A40")]
		public ManagedTexture(string GKOIMGFECPK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x46A49E0", Offset = "0x46A39E0", VA = "0x1846A49E0")]
		public ManagedTexture(string GKOIMGFECPK, bool JGKDKOEALHD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x46A3D60", Offset = "0x46A2D60", VA = "0x1846A3D60")]
		public void AGKIOBOMPOG(RenderTexture EIMGJCDJHBM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x46A3D90", Offset = "0x46A2D90", VA = "0x1846A3D90")]
		public global::IDCJFNACHEM<byte[]> APKINGAPCOC(bool BHOEPIBMKIB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x46A4500", Offset = "0x46A3500", VA = "0x1846A4500")]
		public global::IDCJFNACHEM<Texture2D> LACGLLGHJAJ(JLNBLACPAHP KBIOPGHHEAG, bool AGEAOKEHOIA = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x46A4830", Offset = "0x46A3830", VA = "0x1846A4830")]
		public global::IDCJFNACHEM<byte[]> OOFBFMCGDLH(bool AGEAOKEHOIA = false, int AGMALHKLLCN = 80)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x46A4370", Offset = "0x46A3370", VA = "0x1846A4370")]
		public global::IDCJFNACHEM<byte[]> KDFOJLAGDDE(bool AGEAOKEHOIA = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x46A3DB0", Offset = "0x46A2DB0", VA = "0x1846A3DB0")]
		private static global::IDCJFNACHEM<Texture2D> CEPNJLIFFNH(string GKOIMGFECPK, RenderTexture EIMGJCDJHBM, ref Texture2D AAKEKPEIOLP, bool AGEAOKEHOIA, JLNBLACPAHP IFPKGKNIACH = JLNBLACPAHP.GPU)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x46A42B0", Offset = "0x46A32B0", VA = "0x1846A42B0")]
		public void GJIGJHDOGHE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x46A42A0", Offset = "0x46A32A0", VA = "0x1846A42A0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x46A4790", Offset = "0x46A3790", VA = "0x1846A4790")]
		[CompilerGenerated]
		private global::IDCJFNACHEM<byte[]> MCLOICFPFBB(Texture2D JGPLFAHEPPO)
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public static class NBKKCPELLPM
{
	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x46A4BC0", Offset = "0x46A3BC0", VA = "0x1846A4BC0")]
	public static RenderTexture FIOAGENOEML(int OAMJGHNKFHG, int AEFGCKKJMLM, int JFPEIDMPMBL, Camera POHJOPHOGFA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x46A4D30", Offset = "0x46A3D30", VA = "0x1846A4D30")]
	public static void LNLAAGMNCBE(RenderTexture EIMGJCDJHBM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class KJMEBNJILHG
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public class DBNMLLLLAGD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public int DNOEOILNAPK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public int PMAKOBOAGJJ;

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x5A1410", Offset = "0x5A0410", VA = "0x1805A1410")]
		public DBNMLLLLAGD(int FCHDIKBEKHN, int FLCLFKPPOLF)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	private enum HHHNMJGFCMK
	{
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		Point,
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		Bilinear,
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		Average
	}

	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private static Color[] ICHOLKIPNMJ;

	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private static Color[] HNPAPAJIACL;

	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private static int DLEMLHMNLPH;

	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private static float LBCIDNNODHN;

	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private static float FCHOAAOGPLL;

	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private static int DJCABKBDOFM;

	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private static int PLJIHCCCMJI;

	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private static Mutex DMPGDJJNDID;

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x46A2A50", Offset = "0x46A1A50", VA = "0x1846A2A50")]
	public static void ALJBCLDIHCB(Texture2D CJKENOEFONF, int BNGBGEOJOGH, int DNEMNLFPLID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x46A2A70", Offset = "0x46A1A70", VA = "0x1846A2A70")]
	private static void CDCLFFPCFEF(Texture2D CJKENOEFONF, int BNGBGEOJOGH, int DNEMNLFPLID, HHHNMJGFCMK FAMDEDMKNLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x46A34A0", Offset = "0x46A24A0", VA = "0x1846A34A0")]
	public static void MAAAMOHGLGG(object HPPOIDNICFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x46A2F20", Offset = "0x46A1F20", VA = "0x1846A2F20")]
	public static void GBBENHFNOHO(object HPPOIDNICFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x46A3100", Offset = "0x46A2100", VA = "0x1846A3100")]
	private static Color GMJONGDECND(int APLMPEFFNCL, int IKBPIALPOCI, float LBCIDNNODHN, float FCHOAAOGPLL)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x46A32C0", Offset = "0x46A22C0", VA = "0x1846A32C0")]
	public static void JEPEKKHIDNA(object HPPOIDNICFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x46A39C0", Offset = "0x46A29C0", VA = "0x1846A39C0")]
	private static Color PEGGEACDEAC(Color EDNHGIDPIEJ, Color PAMHCOPCMNN, float NBFFDDDBNPN)
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
