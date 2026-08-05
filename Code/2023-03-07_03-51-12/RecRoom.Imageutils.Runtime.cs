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
		[Cpp2IlInjected.Address(RVA = "0x1A26680", Offset = "0x1A25A80", VA = "0x181A26680")]
		public CubeMapGenerator()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public enum NEPKDFLAPJD
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
public interface DMHIEAOIBEE
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	NEPKDFLAPJD CAJMJLFFNIO
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class GMKOOMDPHBK
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
			[Cpp2IlInjected.Address(RVA = "0x1A29690", Offset = "0x1A28A90", VA = "0x181A29690")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x1A29680", Offset = "0x1A28A80", VA = "0x181A29680")]
		public Resolution(uint IMDGNLLHHDC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x817230", Offset = "0x816630", VA = "0x180817230")]
		public Resolution(uint IMDGNLLHHDC, uint NJNDPGIDOBC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x1A29590", Offset = "0x1A28990", VA = "0x181A29590")]
		public static Resolution JAINDJGMHDO(Resolution[] OILJOHNDOJO, Resolution PHDPCKMMMJP, int KGNNKHGBIHJ)
		{
			return default(Resolution);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public class PCCGLIMNFOD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private readonly Resolution DNNJJPGPNDF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private Resolution? INMFKGJCGFJ;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public uint IMDGNLLHHDC
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x1A29120", Offset = "0x1A28520", VA = "0x181A29120")]
			get
			{
				return default(uint);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public uint NJNDPGIDOBC
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x1A29100", Offset = "0x1A28500", VA = "0x181A29100")]
			get
			{
				return default(uint);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public Resolution MIDNEJJMDHG
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x1A29130", Offset = "0x1A28530", VA = "0x181A29130")]
			get
			{
				return default(Resolution);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x17DF310", Offset = "0x17DE710", VA = "0x1817DF310")]
		public PCCGLIMNFOD(Resolution DNNJJPGPNDF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x1A28F60", Offset = "0x1A28360", VA = "0x181A28F60")]
		private static Resolution CABNEOKPFOK(Resolution INMFKGJCGFJ, NEPKDFLAPJD NLOFBNKDAHP)
		{
			return default(Resolution);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public static class PEPIEJKEOPO
	{
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public static readonly Resolution LOCMFLGMFGN;

		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public static readonly Resolution OJMFNOPKOKP;

		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public static readonly Resolution LNNGNDLNDNH;

		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public static readonly Resolution CANLMMECELL;

		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public static readonly Resolution EOFIHBINDHC;

		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public static readonly Resolution DOMBGDCHKHB;

		[Cpp2IlInjected.Token(Token = "0x4000014")]
		internal static readonly Resolution[] KDLNGEIGLEI;
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public static class FBNAMOJPPFP
	{
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public static readonly Resolution CGLONOMNFOK;

		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public static readonly Resolution LJFPEJLDIJD;

		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public static readonly Resolution LHJNBOHDFAF;

		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public static readonly Resolution AALDDKKPGJE;

		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public static readonly Resolution INGJEOOINHE;

		[Cpp2IlInjected.Token(Token = "0x400001A")]
		internal static readonly Resolution[] KDLNGEIGLEI;

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x1A266C0", Offset = "0x1A25AC0", VA = "0x181A266C0")]
		public static Resolution OHHMHJMAGDK(uint HIPFHAFHMOD)
		{
			return default(Resolution);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public static readonly Resolution PAEKCGMFPMA;

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x1A26A80", Offset = "0x1A25E80", VA = "0x181A26A80")]
	public static bool MJDLPGCEJEM(uint BBAKKDOBLFB)
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
		public enum FNJDHNECLHF : byte
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
		private class LAJKGMOKBCO : IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			private string LBEPPIIBMPA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			public Texture2D PHNICCCMGMF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400002C")]
			public FNJDHNECLHF OHHNPPHAIMJ;

			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x1A27CD0", Offset = "0x1A270D0", VA = "0x181A27CD0")]
			public LAJKGMOKBCO(string LBEPPIIBMPA)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x883AC0", Offset = "0x882EC0", VA = "0x180883AC0")]
			public LAJKGMOKBCO(string LBEPPIIBMPA, Texture2D GDDBNPDKFAM, FNJDHNECLHF BLLDFLBEIMC)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x1A27C90", Offset = "0x1A27090", VA = "0x181A27C90", Slot = "4")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000D")]
		[CompilerGenerated]
		private sealed class LCONOCGIABI
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400002D")]
			public ManagedTexture <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400002E")]
			public FNJDHNECLHF textureMemory;

			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0")]
			public LCONOCGIABI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x1A27D20", Offset = "0x1A27120", VA = "0x181A27D20")]
			internal void <GetManagedTexture>b__0()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000E")]
		[CompilerGenerated]
		private sealed class ENCDLNIJKNO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400002F")]
			public int quality;

			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0")]
			public ENCDLNIJKNO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x1A266A0", Offset = "0x1A25AA0", VA = "0x181A266A0")]
			internal byte[] <EncodeToJPG>b__0(Texture2D t2d)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000F")]
		[CompilerGenerated]
		private sealed class NPCEPGMKDEN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000030")]
			public RenderTexture tempRenderTexture;

			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0")]
			public NPCEPGMKDEN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x1A28ED0", Offset = "0x1A282D0", VA = "0x181A28ED0")]
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
		private global::HPHDJAFFHCN<Texture2D> _cpuSidePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private LAJKGMOKBCO _memTexture;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private global::HPHDJAFFHCN<byte[]> _jpgEncodePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private byte[] _jpgBytes;

		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public const int DEFAULT_JPG_QUALITY = 80;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private global::HPHDJAFFHCN<byte[]> _pngEncodePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private byte[] _pngBytes;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public bool UsePalette
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x826290", Offset = "0x825690", VA = "0x180826290")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public RenderTexture LastRenderTexture
		{
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x75A350", Offset = "0x759750", VA = "0x18075A350")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x762C90", Offset = "0x762090", VA = "0x180762C90")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		private LAJKGMOKBCO memoryTexture
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x1A28E30", Offset = "0x1A28230", VA = "0x181A28E30")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x1A28DE0", Offset = "0x1A281E0", VA = "0x181A28DE0")]
		public ManagedTexture(string LBEPPIIBMPA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x1A28D80", Offset = "0x1A28180", VA = "0x181A28D80")]
		public ManagedTexture(string LBEPPIIBMPA, bool OGFFJFKFKAO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x1A28AE0", Offset = "0x1A27EE0", VA = "0x181A28AE0")]
		public void NFGKCICEPKL(RenderTexture CIBOIPOKABF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x1A28190", Offset = "0x1A27590", VA = "0x181A28190")]
		public global::HPHDJAFFHCN<byte[]> ENGDPOCEBPC(bool APNFDONOJHF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x1A28730", Offset = "0x1A27B30", VA = "0x181A28730")]
		public global::HPHDJAFFHCN<Texture2D> HJILDLFIKBK(FNJDHNECLHF BLLDFLBEIMC, bool NJFPOEKGIFC = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x1A27F80", Offset = "0x1A27380", VA = "0x181A27F80")]
		public global::HPHDJAFFHCN<byte[]> DLALPOHDJLK(bool NJFPOEKGIFC = false, int HACOGIFBACB = 80)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x1A28BC0", Offset = "0x1A27FC0", VA = "0x181A28BC0")]
		public global::HPHDJAFFHCN<byte[]> OOKOMJIDNHO(bool NJFPOEKGIFC = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x1A281B0", Offset = "0x1A275B0", VA = "0x181A281B0")]
		private static global::HPHDJAFFHCN<Texture2D> GFHGENKMEOP(string LBEPPIIBMPA, RenderTexture CIBOIPOKABF, ref Texture2D PFOKNCIAIKH, bool NJFPOEKGIFC, FNJDHNECLHF JMNEMAJPAML = FNJDHNECLHF.GPU)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x1A28A20", Offset = "0x1A27E20", VA = "0x181A28A20")]
		public void LGADJFBPGLC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x1A28180", Offset = "0x1A27580", VA = "0x181A28180", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x1A28B10", Offset = "0x1A27F10", VA = "0x181A28B10")]
		[CompilerGenerated]
		private global::HPHDJAFFHCN<byte[]> NLDDFPLOAAD(Texture2D JKGLOOFKGCL)
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public static class MBICNDEMOHO
{
	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x1A27DD0", Offset = "0x1A271D0", VA = "0x181A27DD0")]
	public static RenderTexture INPCFILDBOJ(int HIPFHAFHMOD, int BNPPIEMPHIN, int CLPHJECJKHN, Camera PCMMHJDIBAK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x1A27D60", Offset = "0x1A27160", VA = "0x181A27D60")]
	public static void GKIKKGJJIFP(RenderTexture CIBOIPOKABF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class HDACPPOHAOB
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public class DMEJGCCFPCJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public int GJOFJPHNEOA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public int AFEDLJDCGDB;

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x98E880", Offset = "0x98DC80", VA = "0x18098E880")]
		public DMEJGCCFPCJ(int BIKOMANFOPC, int EPPMCIFCHBF)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	private enum AEKCODKEJIE
	{
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		Point,
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		Bilinear,
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		Average
	}

	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private static Color[] FKHHJKBCBDM;

	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private static Color[] BNJAHHPILJH;

	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private static int MIIKBFLPBBF;

	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private static float PAPKMLIMEEJ;

	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private static float JLIKKOOBFKB;

	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private static int ODDCADJAOLD;

	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private static int DNOILABBPCM;

	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private static Mutex BMAKPGDPJHP;

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x1A273A0", Offset = "0x1A267A0", VA = "0x181A273A0")]
	public static void JGCLNKNFDDM(Texture2D NLNBICHCFNA, int GNGJNPEAJDJ, int MHKAINDPLAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x1A26CE0", Offset = "0x1A260E0", VA = "0x181A26CE0")]
	private static void CJFLKBCLLBH(Texture2D NLNBICHCFNA, int GNGJNPEAJDJ, int MHKAINDPLAC, AEKCODKEJIE JPFHNIBFEJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x1A274A0", Offset = "0x1A268A0", VA = "0x181A274A0")]
	public static void NAHMIAFEDOF(object JGHFLANLLNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x1A27AC0", Offset = "0x1A26EC0", VA = "0x181A27AC0")]
	public static void PPOEFGBPHJG(object JGHFLANLLNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x1A27920", Offset = "0x1A26D20", VA = "0x181A27920")]
	private static Color ONEMDIDOMFO(int IMDGNLLHHDC, int NJNDPGIDOBC, float PAPKMLIMEEJ, float JLIKKOOBFKB)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x1A271D0", Offset = "0x1A265D0", VA = "0x181A271D0")]
	public static void HPHIJKEFLEH(object JGHFLANLLNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x1A273C0", Offset = "0x1A267C0", VA = "0x181A273C0")]
	private static Color KOHBKDJJHNH(Color IDPKLCNBKPM, Color FCMMLDJCDJA, float FPLJCBGEJAP)
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
