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
		[Cpp2IlInjected.Address(RVA = "0x43C76B0", Offset = "0x43C6AB0", VA = "0x1843C76B0")]
		public CubeMapGenerator()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public enum AMPBOFNOCCG
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
public interface EOCBNNKOJOH
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	AMPBOFNOCCG KCIACHOIGKI
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class ACCGDGCLHOL
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
			[Cpp2IlInjected.Address(RVA = "0x43CA3B0", Offset = "0x43C97B0", VA = "0x1843CA3B0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x43CA3A0", Offset = "0x43C97A0", VA = "0x1843CA3A0")]
		public Resolution(uint JHHMBPGDMDJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x5EE670", Offset = "0x5EDA70", VA = "0x1805EE670")]
		public Resolution(uint JHHMBPGDMDJ, uint FODPAODADFP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x43CA250", Offset = "0x43C9650", VA = "0x1843CA250")]
		public static Resolution AHEAFIFIODP(Resolution[] GBFMEHCBGAL, Resolution EOGEFEOAMIG, int BLJBIPAMJHK)
		{
			return default(Resolution);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public class KKDLFECMBHK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private readonly Resolution CJLFPDJHAJI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private Resolution? PCMGJJGPLIH;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public uint JHHMBPGDMDJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x43C7990", Offset = "0x43C6D90", VA = "0x1843C7990")]
			get
			{
				return default(uint);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public uint FODPAODADFP
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x43C7D70", Offset = "0x43C7170", VA = "0x1843C7D70")]
			get
			{
				return default(uint);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public Resolution JNMGBLJPKFP
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x43C79A0", Offset = "0x43C6DA0", VA = "0x1843C79A0")]
			get
			{
				return default(Resolution);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x2660B70", Offset = "0x265FF70", VA = "0x182660B70")]
		public KKDLFECMBHK(Resolution CJLFPDJHAJI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x43C7BA0", Offset = "0x43C6FA0", VA = "0x1843C7BA0")]
		private static Resolution IFDCDNDFFNB(Resolution PCMGJJGPLIH, AMPBOFNOCCG JFLLAAOLHHE)
		{
			return default(Resolution);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public static class IHAEHKEDEHN
	{
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public static readonly Resolution KOIFIILNLKH;

		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public static readonly Resolution NFGGHGFBHED;

		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public static readonly Resolution OGHKEFPPDDE;

		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public static readonly Resolution LLBIAEFJFFJ;

		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public static readonly Resolution NJDNIEFPMIP;

		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public static readonly Resolution JALDAOBEEEH;

		[Cpp2IlInjected.Token(Token = "0x4000014")]
		internal static readonly Resolution[] GAHIPEMBIAJ;
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public static class MIEMDFGBLOJ
	{
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public static readonly Resolution BBKIICICAGM;

		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public static readonly Resolution ODMENLLADBB;

		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public static readonly Resolution POJJHPPCLMF;

		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public static readonly Resolution JAFHENNIOJC;

		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public static readonly Resolution OLOPJAEMDIF;

		[Cpp2IlInjected.Token(Token = "0x400001A")]
		internal static readonly Resolution[] GAHIPEMBIAJ;

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x43C7FE0", Offset = "0x43C73E0", VA = "0x1843C7FE0")]
		public static Resolution KHDPHAMHBAP(uint IFCECCMAOBC)
		{
			return default(Resolution);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public static readonly Resolution IGKGPFFNKCE;

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x43C73F0", Offset = "0x43C67F0", VA = "0x1843C73F0")]
	public static bool IANCDPDFPGH(uint FOCFOBFMNLJ)
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
		public enum FMCCEPDLEHF : byte
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
		private class MEOMOFPADEH : IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			private string LADOLLMJDDF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			public Texture2D AIHOGBBMNND;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400002C")]
			public FMCCEPDLEHF JGDJFAEAFCD;

			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x43C7DC0", Offset = "0x43C71C0", VA = "0x1843C7DC0")]
			public MEOMOFPADEH(string LADOLLMJDDF)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x854690", Offset = "0x853A90", VA = "0x180854690")]
			public MEOMOFPADEH(string LADOLLMJDDF, Texture2D CNHPJMFJBDK, FMCCEPDLEHF HNAMLJJLLEG)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x43C7D90", Offset = "0x43C7190", VA = "0x1843C7D90", Slot = "4")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000D")]
		[CompilerGenerated]
		private sealed class FEODAAELEFE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400002D")]
			public ManagedTexture <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400002E")]
			public FMCCEPDLEHF textureMemory;

			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x4C29D0", Offset = "0x4C1DD0", VA = "0x1804C29D0")]
			public FEODAAELEFE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x43C76F0", Offset = "0x43C6AF0", VA = "0x1843C76F0")]
			internal void <GetManagedTexture>b__0()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000E")]
		[CompilerGenerated]
		private sealed class DMBGBPMGIAE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400002F")]
			public int quality;

			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x4C29D0", Offset = "0x4C1DD0", VA = "0x1804C29D0")]
			public DMBGBPMGIAE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x43C76D0", Offset = "0x43C6AD0", VA = "0x1843C76D0")]
			internal byte[] <EncodeToJPG>b__0(Texture2D t2d)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000F")]
		[CompilerGenerated]
		private sealed class AIFEIPIDPJA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000030")]
			public RenderTexture tempRenderTexture;

			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x4C29D0", Offset = "0x4C1DD0", VA = "0x1804C29D0")]
			public AIFEIPIDPJA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x43C7630", Offset = "0x43C6A30", VA = "0x1843C7630")]
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
		private global::PMGAAIBIJNM<Texture2D> _cpuSidePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private MEOMOFPADEH _memTexture;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private global::PMGAAIBIJNM<byte[]> _jpgEncodePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private byte[] _jpgBytes;

		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public const int DEFAULT_JPG_QUALITY = 80;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private global::PMGAAIBIJNM<byte[]> _pngEncodePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private byte[] _pngBytes;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public bool UsePalette
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x4EA180", Offset = "0x4E9580", VA = "0x1804EA180")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public RenderTexture LastRenderTexture
		{
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x4C2CF0", Offset = "0x4C20F0", VA = "0x1804C2CF0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x4E97D0", Offset = "0x4E8BD0", VA = "0x1804E97D0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		private MEOMOFPADEH memoryTexture
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x43C9190", Offset = "0x43C8590", VA = "0x1843C9190")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x43C9140", Offset = "0x43C8540", VA = "0x1843C9140")]
		public ManagedTexture(string LADOLLMJDDF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x43C90F0", Offset = "0x43C84F0", VA = "0x1843C90F0")]
		public ManagedTexture(string LADOLLMJDDF, bool KIDOFENPAPD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x43C83E0", Offset = "0x43C77E0", VA = "0x1843C83E0")]
		public void GABEIELFMLD(RenderTexture GBOOKNNDALL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x43C8880", Offset = "0x43C7C80", VA = "0x1843C8880")]
		public global::PMGAAIBIJNM<byte[]> KMFAENPEAOG(bool DOAMLLLPJFO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x43C8460", Offset = "0x43C7860", VA = "0x1843C8460")]
		public global::PMGAAIBIJNM<Texture2D> GNPPOJPIICD(FMCCEPDLEHF HNAMLJJLLEG, bool KMFMFMMFIHC = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x43C86E0", Offset = "0x43C7AE0", VA = "0x1843C86E0")]
		public global::PMGAAIBIJNM<byte[]> JNKNNOKINDO(bool KMFMFMMFIHC = false, int PHOCAGJMMDL = 80)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x43C8A10", Offset = "0x43C7E10", VA = "0x1843C8A10")]
		public global::PMGAAIBIJNM<byte[]> MFHIDEBKABN(bool KMFMFMMFIHC = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x43C8C20", Offset = "0x43C8020", VA = "0x1843C8C20")]
		private static global::PMGAAIBIJNM<Texture2D> OHKFHBOLJIK(string LADOLLMJDDF, RenderTexture GBOOKNNDALL, ref Texture2D MKKHHMCPOHH, bool KMFMFMMFIHC, FMCCEPDLEHF PEFBPHEPGOF = FMCCEPDLEHF.GPU)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x43C8370", Offset = "0x43C7770", VA = "0x1843C8370")]
		public void CLLEMGJMILA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x43C8370", Offset = "0x43C7770", VA = "0x1843C8370", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x43C8B80", Offset = "0x43C7F80", VA = "0x1843C8B80")]
		[CompilerGenerated]
		private global::PMGAAIBIJNM<byte[]> NLKGGCIMEHL(Texture2D OKDDBCMEODH)
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public static class MFJAPHHIKKE
{
	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x43C7E00", Offset = "0x43C7200", VA = "0x1843C7E00")]
	public static RenderTexture IDCBLONKFGN(int IFCECCMAOBC, int GBPNNHBJMFP, int HFJFEJHPHGF, Camera OIHHAFBBPAH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x43C7F70", Offset = "0x43C7370", VA = "0x1843C7F70")]
	public static void PHLCEPNNDIE(RenderTexture GBOOKNNDALL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class NFECLNDLLEL
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public class KCNGBHMMJNJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public int FMLKMLFEFAG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public int CHLDFDHMOHL;

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x578D60", Offset = "0x578160", VA = "0x180578D60")]
		public KCNGBHMMJNJ(int HBGEEEHGIGE, int LKGDCBMCJOL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	private enum NCMOFCJOIAH
	{
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		Point,
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		Bilinear,
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		Average
	}

	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private static Color[] KBHMHGFAKKK;

	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private static Color[] HCDBDKLKHCL;

	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private static int MLPJAIJOOMF;

	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private static float PEDEBBANICE;

	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private static float KCDDPBHABLG;

	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private static int JOEDBPAKAEE;

	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private static int JOMEHLBLKHN;

	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private static Mutex DLNFJKHDONI;

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x43C9210", Offset = "0x43C8610", VA = "0x1843C9210")]
	public static void BEPCFBJMPAC(Texture2D DAEFGHOCCHC, int JOAFBPLJEEK, int EOGFGEHDLAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x43C9DC0", Offset = "0x43C91C0", VA = "0x1843C9DC0")]
	private static void KHEBHAFLCIB(Texture2D DAEFGHOCCHC, int JOAFBPLJEEK, int EOGFGEHDLAO, NCMOFCJOIAH IOEMLBGAGAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x43C95D0", Offset = "0x43C89D0", VA = "0x1843C95D0")]
	public static void GIBDBMOKPHL(object IIGCLEONCAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x43C93F0", Offset = "0x43C87F0", VA = "0x1843C93F0")]
	public static void GBCHCIDOCAJ(object IIGCLEONCAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x43C9230", Offset = "0x43C8630", VA = "0x1843C9230")]
	private static Color DGLPLLDGBGK(int JHHMBPGDMDJ, int FODPAODADFP, float PEDEBBANICE, float KCDDPBHABLG)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x43C9AF0", Offset = "0x43C8EF0", VA = "0x1843C9AF0")]
	public static void GIKNEAJECAJ(object IIGCLEONCAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x43C9CD0", Offset = "0x43C90D0", VA = "0x1843C9CD0")]
	private static Color JHLEHCNDMEJ(Color IJEKJOGIMMN, Color MGIMHHCPGKK, float IFBOOLFAOLF)
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
