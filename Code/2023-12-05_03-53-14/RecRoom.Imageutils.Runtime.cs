using System;
using System.Reflection;
using System.Runtime.CompilerServices;
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
		[Cpp2IlInjected.Address(RVA = "0x5E18840", Offset = "0x5E17C40", VA = "0x185E18840")]
		public CubeMapGenerator()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public enum GMHIMPDIHGJ
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
public interface EMPOAMAMFPH
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	GMHIMPDIHGJ EAKHLHNBLDA
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class GPJBPNMHHEB
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
			[Cpp2IlInjected.Address(RVA = "0x5E1A680", Offset = "0x5E19A80", VA = "0x185E1A680")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x5E1A670", Offset = "0x5E19A70", VA = "0x185E1A670")]
		public Resolution(uint OPHKAEHAFCM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0xA0EFA0", Offset = "0xA0E3A0", VA = "0x180A0EFA0")]
		public Resolution(uint OPHKAEHAFCM, uint CLGLFIMLHLG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x5E1A580", Offset = "0x5E19980", VA = "0x185E1A580")]
		public static Resolution IOJNKOBNCPI(Resolution[] AHMINIDFCHC, Resolution FFNMHDPIEOG, int PPAIIHOAJEF)
		{
			return default(Resolution);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public class KJOEEKCPADB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private readonly Resolution JHCBHAHJAHM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private Resolution? GGGANBABEOE;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public uint OPHKAEHAFCM
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x5E195F0", Offset = "0x5E189F0", VA = "0x185E195F0")]
			get
			{
				return default(uint);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public uint CLGLFIMLHLG
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x5E19600", Offset = "0x5E18A00", VA = "0x185E19600")]
			get
			{
				return default(uint);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public Resolution POEFMMCGLJM
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x5E19130", Offset = "0x5E18530", VA = "0x185E19130")]
			get
			{
				return default(Resolution);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x190EA10", Offset = "0x190DE10", VA = "0x18190EA10")]
		public KJOEEKCPADB(Resolution JHCBHAHJAHM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x5E19470", Offset = "0x5E18870", VA = "0x185E19470")]
		private static Resolution ELCENCKDHPI(Resolution GGGANBABEOE, GMHIMPDIHGJ BCFEKMPFJNA)
		{
			return default(Resolution);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public static class CDMBLPIBEMJ
	{
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public static readonly Resolution IGFADGEEINM;

		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public static readonly Resolution IFHLPBAFJLB;

		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public static readonly Resolution JCLAAGANHCP;

		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public static readonly Resolution LCNEPNEBLFM;

		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public static readonly Resolution HBFPDFPDPNE;

		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public static readonly Resolution NOHIONKEOKF;

		[Cpp2IlInjected.Token(Token = "0x4000014")]
		internal static readonly Resolution[] MCOKBGNPHNK;
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public static class FENDDBHKDCC
	{
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public static readonly Resolution GCHKFEHNICI;

		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public static readonly Resolution LPBILOAHKBG;

		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public static readonly Resolution FPLEPOGICNK;

		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public static readonly Resolution DFILCGEFOGM;

		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public static readonly Resolution FPEBFLAHHLL;

		[Cpp2IlInjected.Token(Token = "0x400001A")]
		internal static readonly Resolution[] MCOKBGNPHNK;

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x5E188F0", Offset = "0x5E17CF0", VA = "0x185E188F0")]
		public static Resolution BJHIHJLCHNB(uint DFNBDEKAJAM)
		{
			return default(Resolution);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public static readonly Resolution OFCLCPDEOMI;

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x5E18C40", Offset = "0x5E18040", VA = "0x185E18C40")]
	public static bool MJNBEOHAJNF(uint KPCLOCGMBOC)
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
		public enum GGLAAAOEPEM : byte
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
		private class ECEBJLGIANO : IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			private string MDFAJJKMBAI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			public Texture2D MCKDHFIAJPK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400002C")]
			public GGLAAAOEPEM KKGLFELGABH;

			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x5E188A0", Offset = "0x5E17CA0", VA = "0x185E188A0")]
			public ECEBJLGIANO(string MDFAJJKMBAI)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x3461700", Offset = "0x3460B00", VA = "0x183461700")]
			public ECEBJLGIANO(string MDFAJJKMBAI, Texture2D FHDJNDAFDEI, GGLAAAOEPEM MPFMMLDBIMC)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x5E18860", Offset = "0x5E17C60", VA = "0x185E18860", Slot = "4")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000D")]
		[CompilerGenerated]
		private sealed class IEODCLDHAHG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400002D")]
			public ManagedTexture <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400002E")]
			public GGLAAAOEPEM textureMemory;

			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x778200", Offset = "0x777600", VA = "0x180778200")]
			public IEODCLDHAHG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x5E18E70", Offset = "0x5E18270", VA = "0x185E18E70")]
			internal void LGMOJALDNAC()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000E")]
		[CompilerGenerated]
		private sealed class LAPPDIDMPEO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400002F")]
			public int quality;

			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x778200", Offset = "0x777600", VA = "0x180778200")]
			public LAPPDIDMPEO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x5E19620", Offset = "0x5E18A20", VA = "0x185E19620")]
			internal byte[] DLIFEFLCDLK(Texture2D t2d)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000F")]
		[CompilerGenerated]
		private sealed class JIOMLLDCGON
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000030")]
			public RenderTexture tempRenderTexture;

			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x778200", Offset = "0x777600", VA = "0x180778200")]
			public JIOMLLDCGON()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x5E190B0", Offset = "0x5E184B0", VA = "0x185E190B0")]
			internal void PCBEKBCODKL()
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
		private CJNEKNCGBDK<Texture2D> _cpuSidePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private ECEBJLGIANO _memTexture;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private CJNEKNCGBDK<byte[]> _jpgEncodePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private byte[] _jpgBytes;

		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public const int DEFAULT_JPG_QUALITY = 80;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private CJNEKNCGBDK<byte[]> _pngEncodePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private byte[] _pngBytes;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public bool UsePalette
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x7C5050", Offset = "0x7C4450", VA = "0x1807C5050")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public RenderTexture LastRenderTexture
		{
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x775A80", Offset = "0x774E80", VA = "0x180775A80")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x775420", Offset = "0x774820", VA = "0x180775420")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		private ECEBJLGIANO memoryTexture
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x5E1A4D0", Offset = "0x5E198D0", VA = "0x185E1A4D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x5E1A400", Offset = "0x5E19800", VA = "0x185E1A400")]
		public ManagedTexture(string MDFAJJKMBAI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x5E1A460", Offset = "0x5E19860", VA = "0x185E1A460")]
		public ManagedTexture(string MDFAJJKMBAI, bool LBKKIIAJBOK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x5E19800", Offset = "0x5E18C00", VA = "0x185E19800")]
		public void DOIMHJIKDAI(RenderTexture CJAFPNGJCPP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x5E19B40", Offset = "0x5E18F40", VA = "0x185E19B40")]
		public CJNEKNCGBDK<byte[]> MHLNHEJBPEL(bool DEBHNAKAIMJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x5E19850", Offset = "0x5E18C50", VA = "0x185E19850")]
		public CJNEKNCGBDK<Texture2D> GCIFCODGGGA(GGLAAAOEPEM MPFMMLDBIMC, bool DKOKFHNKIEL = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x5E1A170", Offset = "0x5E19570", VA = "0x185E1A170")]
		public CJNEKNCGBDK<byte[]> OPFOLIKCBLJ(bool DKOKFHNKIEL = false, int ELLIMFKHEAJ = 80)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x5E19640", Offset = "0x5E18A40", VA = "0x185E19640")]
		public CJNEKNCGBDK<byte[]> ABOAJIANLLH(bool DKOKFHNKIEL = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x5E19B60", Offset = "0x5E18F60", VA = "0x185E19B60")]
		private static CJNEKNCGBDK<Texture2D> MOBOPJFPDJG(string MDFAJJKMBAI, RenderTexture CJAFPNGJCPP, Texture2D CPHJALBFKJN, bool DKOKFHNKIEL, GGLAAAOEPEM JGFHOBIGFIB = GGLAAAOEPEM.GPU)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x5E1A0B0", Offset = "0x5E194B0", VA = "0x185E1A0B0")]
		public void OHBJMNOPJBL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x5E19840", Offset = "0x5E18C40", VA = "0x185E19840", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x5E1A360", Offset = "0x5E19760", VA = "0x185E1A360")]
		[CompilerGenerated]
		private CJNEKNCGBDK<byte[]> PCMDEAFLODB(Texture2D FMCADPPCCFC)
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public static class IPGBBBACFLB
{
	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x5E18F10", Offset = "0x5E18310", VA = "0x185E18F10")]
	public static RenderTexture BPBBAJMNHLB(int DFNBDEKAJAM, int DLFGMNCCFOK, int KPHHMKNGICG, Camera CABLNKDOKMA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x5E18EB0", Offset = "0x5E182B0", VA = "0x185E18EB0")]
	public static void AAJDEGFEOCG(RenderTexture CJAFPNGJCPP)
	{
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
