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
		[Cpp2IlInjected.Address(RVA = "0x5DF4730", Offset = "0x5DF3530", VA = "0x185DF4730")]
		public CubeMapGenerator()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public enum AIGPLAEBCJN
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
public interface EAFDALFPNEK
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	AIGPLAEBCJN CEIPEKOCJCL
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class BCNAKOLODBD
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
			[Cpp2IlInjected.Address(RVA = "0x5DF5DE0", Offset = "0x5DF4BE0", VA = "0x185DF5DE0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x5DF5DD0", Offset = "0x5DF4BD0", VA = "0x185DF5DD0")]
		public Resolution(uint GPMOHKANAAB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x9D7BB0", Offset = "0x9D69B0", VA = "0x1809D7BB0")]
		public Resolution(uint GPMOHKANAAB, uint GGKPCMCCKDN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x5DF5CE0", Offset = "0x5DF4AE0", VA = "0x185DF5CE0")]
		public static Resolution ALGJBIHJFKO(Resolution[] INHBNHHKMGG, Resolution EJJPFMJPDFJ, int MJAMGIOMBAE)
		{
			return default(Resolution);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public class ABCGJGNPHEJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private readonly Resolution JAHKDGJDBIH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private Resolution? GEBHKCKFKEM;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public uint GPMOHKANAAB
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x5DF4240", Offset = "0x5DF3040", VA = "0x185DF4240")]
			get
			{
				return default(uint);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public uint GGKPCMCCKDN
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x5DF4250", Offset = "0x5DF3050", VA = "0x185DF4250")]
			get
			{
				return default(uint);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public Resolution ANAKAMCDALH
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x5DF3F00", Offset = "0x5DF2D00", VA = "0x185DF3F00")]
			get
			{
				return default(Resolution);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x18D13F0", Offset = "0x18D01F0", VA = "0x1818D13F0")]
		public ABCGJGNPHEJ(Resolution JAHKDGJDBIH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x5DF3D80", Offset = "0x5DF2B80", VA = "0x185DF3D80")]
		private static Resolution LCLNKNKAHDP(Resolution GEBHKCKFKEM, AIGPLAEBCJN CMKPDHGHFEP)
		{
			return default(Resolution);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public static class IHIFLAJPAPJ
	{
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public static readonly Resolution HAGEJNCCEIN;

		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public static readonly Resolution GKIPEFOGNKO;

		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public static readonly Resolution PGJKFCEGBKB;

		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public static readonly Resolution ICOLGNCGOHF;

		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public static readonly Resolution HCBANMKJNLH;

		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public static readonly Resolution NCOIFLOFLPO;

		[Cpp2IlInjected.Token(Token = "0x4000014")]
		internal static readonly Resolution[] LMMDOPOHCIM;
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public static class PBMAFAOEACD
	{
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public static readonly Resolution PFFKBOPAJDC;

		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public static readonly Resolution ICJBGGMKKOE;

		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public static readonly Resolution DKKBNMLEDPI;

		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public static readonly Resolution FGDDMBIGOPP;

		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public static readonly Resolution FACDCHIPOMO;

		[Cpp2IlInjected.Token(Token = "0x400001A")]
		internal static readonly Resolution[] LMMDOPOHCIM;

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x5DF5990", Offset = "0x5DF4790", VA = "0x185DF5990")]
		public static Resolution FADAGEAOIEJ(uint DBGLJKBGOEL)
		{
			return default(Resolution);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public static readonly Resolution JJFANNJBHBO;

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x5DF4300", Offset = "0x5DF3100", VA = "0x185DF4300")]
	public static bool CMCEOMKJBHL(uint DIALPCPADJO)
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
		public enum HMFNIKMBPCI : byte
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
		private class ACHODCKJIIH : IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			private string NDLLBBKGIJD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			public Texture2D HMMNIADHICM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400002C")]
			public HMFNIKMBPCI BLMDJGKMKDB;

			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x5DF42B0", Offset = "0x5DF30B0", VA = "0x185DF42B0")]
			public ACHODCKJIIH(string NDLLBBKGIJD)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x3ED46D0", Offset = "0x3ED34D0", VA = "0x183ED46D0")]
			public ACHODCKJIIH(string NDLLBBKGIJD, Texture2D PMHKBPCFOHI, HMFNIKMBPCI PINFDPAIMGI)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x5DF4270", Offset = "0x5DF3070", VA = "0x185DF4270", Slot = "4")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000D")]
		[CompilerGenerated]
		private sealed class DLEKGILHHOD
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400002D")]
			public ManagedTexture <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400002E")]
			public HMFNIKMBPCI textureMemory;

			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x7793D0", Offset = "0x7781D0", VA = "0x1807793D0")]
			public DLEKGILHHOD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x5DF47D0", Offset = "0x5DF35D0", VA = "0x185DF47D0")]
			internal void AJKKBBGHGDB()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000E")]
		[CompilerGenerated]
		private sealed class JJNJMPOFHGA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400002F")]
			public int quality;

			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x7793D0", Offset = "0x7781D0", VA = "0x1807793D0")]
			public JJNJMPOFHGA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x5DF4A30", Offset = "0x5DF3830", VA = "0x185DF4A30")]
			internal byte[] OMJCFOPACBA(Texture2D t2d)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000F")]
		[CompilerGenerated]
		private sealed class DGJDODNPKEM
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000030")]
			public RenderTexture tempRenderTexture;

			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x7793D0", Offset = "0x7781D0", VA = "0x1807793D0")]
			public DGJDODNPKEM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x5DF4750", Offset = "0x5DF3550", VA = "0x185DF4750")]
			internal void DAKIPIBFPDB()
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
		private HIIDJBNNIDE<Texture2D> _cpuSidePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private ACHODCKJIIH _memTexture;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private HIIDJBNNIDE<byte[]> _jpgEncodePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private byte[] _jpgBytes;

		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public const int DEFAULT_JPG_QUALITY = 80;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private HIIDJBNNIDE<byte[]> _pngEncodePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private byte[] _pngBytes;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public bool UsePalette
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x7C3260", Offset = "0x7C2060", VA = "0x1807C3260")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public RenderTexture LastRenderTexture
		{
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x775E10", Offset = "0x774C10", VA = "0x180775E10")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x770C80", Offset = "0x76FA80", VA = "0x180770C80")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		private ACHODCKJIIH memoryTexture
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x5DF58E0", Offset = "0x5DF46E0", VA = "0x185DF58E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x5DF5810", Offset = "0x5DF4610", VA = "0x185DF5810")]
		public ManagedTexture(string NDLLBBKGIJD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x5DF5870", Offset = "0x5DF4670", VA = "0x185DF5870")]
		public ManagedTexture(string NDLLBBKGIJD, bool IELODPDGIGM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x5DF4C50", Offset = "0x5DF3A50", VA = "0x185DF4C50")]
		public void EFDELCHPGNL(RenderTexture BHMOOKDHJDP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x5DF57F0", Offset = "0x5DF45F0", VA = "0x185DF57F0")]
		public HIIDJBNNIDE<byte[]> LFGHIHGILJB(bool LKBCCKONBJF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x5DF4DF0", Offset = "0x5DF3BF0", VA = "0x185DF4DF0")]
		public HIIDJBNNIDE<Texture2D> JBDPIFPKOKF(HMFNIKMBPCI PINFDPAIMGI, bool PLCLDHNANIJ = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x5DF4A50", Offset = "0x5DF3850", VA = "0x185DF4A50")]
		public HIIDJBNNIDE<byte[]> DMMBNCBDKOP(bool PLCLDHNANIJ = false, int NBJOMEDKMGM = 80)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x5DF5630", Offset = "0x5DF4430", VA = "0x185DF5630")]
		public HIIDJBNNIDE<byte[]> KLFELPDEIFK(bool PLCLDHNANIJ = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x5DF50E0", Offset = "0x5DF3EE0", VA = "0x185DF50E0")]
		private static HIIDJBNNIDE<Texture2D> KDBFPKIGOFC(string NDLLBBKGIJD, RenderTexture BHMOOKDHJDP, Texture2D GBMGFMINHIN, bool PLCLDHNANIJ, HMFNIKMBPCI LNOMAFMNOJH = HMFNIKMBPCI.GPU)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x5DF4C90", Offset = "0x5DF3A90", VA = "0x185DF4C90")]
		public void GAHMFPHHBLJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x5DF4C40", Offset = "0x5DF3A40", VA = "0x185DF4C40", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x5DF4D50", Offset = "0x5DF3B50", VA = "0x185DF4D50")]
		[CompilerGenerated]
		private HIIDJBNNIDE<byte[]> HAKJNDIFFIL(Texture2D DHNGPOGEGOA)
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public static class BDAJDLPABJA
{
	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x5DF4530", Offset = "0x5DF3330", VA = "0x185DF4530")]
	public static RenderTexture BKEKMJALEMG(int DBGLJKBGOEL, int MIKKOCNOFKH, int ECMKHLIFNID, Camera OBBAGOCNFPI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x5DF46D0", Offset = "0x5DF34D0", VA = "0x185DF46D0")]
	public static void JACCAOJBMEI(RenderTexture BHMOOKDHJDP)
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
