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
		[Cpp2IlInjected.Address(RVA = "0x5E174C0", Offset = "0x5E15CC0", VA = "0x185E174C0")]
		public CubeMapGenerator()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public enum CFJNFKNJGOC
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
public interface GDFPNOBFOLL
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	CFJNFKNJGOC NAMJDHOKODP
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class CMPHJBKDECB
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
			[Cpp2IlInjected.Address(RVA = "0x5E192D0", Offset = "0x5E17AD0", VA = "0x185E192D0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x5E192C0", Offset = "0x5E17AC0", VA = "0x185E192C0")]
		public Resolution(uint GJPJIELLCID)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0xA106A0", Offset = "0xA0EEA0", VA = "0x180A106A0")]
		public Resolution(uint GJPJIELLCID, uint HBNKALMNLPK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x5E191D0", Offset = "0x5E179D0", VA = "0x185E191D0")]
		public static Resolution NACPJKEFMEB(Resolution[] JDIKAIHEILK, Resolution NHNCIGNLLKF, int GBMHCBPEIKP)
		{
			return default(Resolution);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public class PKNPKEJOAPF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private readonly Resolution MNFDJOCCNEN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private Resolution? FPKHINIMLIA;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public uint GJPJIELLCID
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x5E191C0", Offset = "0x5E179C0", VA = "0x185E191C0")]
			get
			{
				return default(uint);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public uint HBNKALMNLPK
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x5E18CE0", Offset = "0x5E174E0", VA = "0x185E18CE0")]
			get
			{
				return default(uint);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public Resolution NDILNHEKLNM
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x5E18D00", Offset = "0x5E17500", VA = "0x185E18D00")]
			get
			{
				return default(Resolution);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x1905200", Offset = "0x1903A00", VA = "0x181905200")]
		public PKNPKEJOAPF(Resolution MNFDJOCCNEN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x5E19040", Offset = "0x5E17840", VA = "0x185E19040")]
		private static Resolution IGKANHECJMH(Resolution FPKHINIMLIA, CFJNFKNJGOC LPAIEHGAODG)
		{
			return default(Resolution);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public static class EFCJKDGEHKJ
	{
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public static readonly Resolution GANANHEPFND;

		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public static readonly Resolution NGBBHEBLECM;

		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public static readonly Resolution CFKGJEJPFEN;

		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public static readonly Resolution EJPDPNFKMHB;

		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public static readonly Resolution JLGBKIHJJMG;

		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public static readonly Resolution APOMFDMFAOA;

		[Cpp2IlInjected.Token(Token = "0x4000014")]
		internal static readonly Resolution[] HMDIJCNCOLL;
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public static class NJJJBIJDGPG
	{
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public static readonly Resolution IKENDEHHGJM;

		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public static readonly Resolution FHOALILDBPL;

		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public static readonly Resolution OAALFCCPDBJ;

		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public static readonly Resolution ADJBJNELGHH;

		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public static readonly Resolution GNLGIEBFAMP;

		[Cpp2IlInjected.Token(Token = "0x400001A")]
		internal static readonly Resolution[] HMDIJCNCOLL;

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x5E18910", Offset = "0x5E17110", VA = "0x185E18910")]
		public static Resolution CGGOEEIKKHH(uint PHBBHKLLCMB)
		{
			return default(Resolution);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public static readonly Resolution EAKDEIIDPFD;

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x5E17290", Offset = "0x5E15A90", VA = "0x185E17290")]
	public static bool PCNKIDMCBIH(uint OJHCKJJKEEK)
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
		public enum OCPGBPKGGDB : byte
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
		private class HDIPBJIEAMA : IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			private string PMDCAPIFBIP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			public Texture2D FHMJFDFHAEH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400002C")]
			public OCPGBPKGGDB ACGIAHDNDFO;

			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x5E17940", Offset = "0x5E16140", VA = "0x185E17940")]
			public HDIPBJIEAMA(string PMDCAPIFBIP)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x3516BB0", Offset = "0x35153B0", VA = "0x183516BB0")]
			public HDIPBJIEAMA(string PMDCAPIFBIP, Texture2D BCKBLDBDMHJ, OCPGBPKGGDB FCCFGKHDHNC)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x5E17900", Offset = "0x5E16100", VA = "0x185E17900", Slot = "4")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000D")]
		[CompilerGenerated]
		private sealed class MHKBLAIAGGF
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400002D")]
			public ManagedTexture <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400002E")]
			public OCPGBPKGGDB textureMemory;

			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x77B730", Offset = "0x779F30", VA = "0x18077B730")]
			public MHKBLAIAGGF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x5E17990", Offset = "0x5E16190", VA = "0x185E17990")]
			internal void BPAIFNCIOAP()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000E")]
		[CompilerGenerated]
		private sealed class APEBOOJPGEE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400002F")]
			public int quality;

			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x77B730", Offset = "0x779F30", VA = "0x18077B730")]
			public APEBOOJPGEE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x5E17270", Offset = "0x5E15A70", VA = "0x185E17270")]
			internal byte[] PDNFJAADCKA(Texture2D t2d)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000F")]
		[CompilerGenerated]
		private sealed class PHGBAKDKOFJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000030")]
			public RenderTexture tempRenderTexture;

			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x77B730", Offset = "0x779F30", VA = "0x18077B730")]
			public PHGBAKDKOFJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x5E18C60", Offset = "0x5E17460", VA = "0x185E18C60")]
			internal void LBAEDIDNLHM()
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
		private CNJPNJMNEEH<Texture2D> _cpuSidePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private HDIPBJIEAMA _memTexture;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private CNJPNJMNEEH<byte[]> _jpgEncodePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private byte[] _jpgBytes;

		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public const int DEFAULT_JPG_QUALITY = 80;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private CNJPNJMNEEH<byte[]> _pngEncodePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private byte[] _pngBytes;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public bool UsePalette
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x7C5270", Offset = "0x7C3A70", VA = "0x1807C5270")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public RenderTexture LastRenderTexture
		{
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x773B00", Offset = "0x772300", VA = "0x180773B00")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x773B60", Offset = "0x772360", VA = "0x180773B60")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		private HDIPBJIEAMA memoryTexture
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x5E18860", Offset = "0x5E17060", VA = "0x185E18860")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x5E18790", Offset = "0x5E16F90", VA = "0x185E18790")]
		public ManagedTexture(string PMDCAPIFBIP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x5E187F0", Offset = "0x5E16FF0", VA = "0x185E187F0")]
		public ManagedTexture(string PMDCAPIFBIP, bool PLGOIJLFIHL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x5E184A0", Offset = "0x5E16CA0", VA = "0x185E184A0")]
		public void GOBMAOCJNHD(RenderTexture LMKGMMDKLIM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x5E17B90", Offset = "0x5E16390", VA = "0x185E17B90")]
		public CNJPNJMNEEH<byte[]> BOLMEGGGANE(bool INCECIDLOGG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x5E17C60", Offset = "0x5E16460", VA = "0x185E17C60")]
		public CNJPNJMNEEH<Texture2D> EAFOLPJFBDH(OCPGBPKGGDB FCCFGKHDHNC, bool BMCIIAOPJDJ = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x5E185A0", Offset = "0x5E16DA0", VA = "0x185E185A0")]
		public CNJPNJMNEEH<byte[]> PMFDHPBBKGC(bool BMCIIAOPJDJ = false, int EIGMBFKLEGE = 80)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x5E179D0", Offset = "0x5E161D0", VA = "0x185E179D0")]
		public CNJPNJMNEEH<byte[]> ALGBHICAIGE(bool BMCIIAOPJDJ = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x5E17F50", Offset = "0x5E16750", VA = "0x185E17F50")]
		private static CNJPNJMNEEH<Texture2D> FOEEHPCGBGB(string PMDCAPIFBIP, RenderTexture LMKGMMDKLIM, Texture2D FFIOJHIIALA, bool BMCIIAOPJDJ, OCPGBPKGGDB HJDGCKKPGLI = OCPGBPKGGDB.GPU)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x5E184E0", Offset = "0x5E16CE0", VA = "0x185E184E0")]
		public void LBCGEMLKAKI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x5E17C50", Offset = "0x5E16450", VA = "0x185E17C50", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x5E17BB0", Offset = "0x5E163B0", VA = "0x185E17BB0")]
		[CompilerGenerated]
		private CNJPNJMNEEH<byte[]> DDFEBLPHIFH(Texture2D GHBFGEONGIE)
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public static class GJJEGMACCCE
{
	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x5E17700", Offset = "0x5E15F00", VA = "0x185E17700")]
	public static RenderTexture IEGMJDPNHMO(int PHBBHKLLCMB, int OAAHJLMDBPE, int LCPEGFJBFOD, Camera FNKJKKEMKMC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x5E178A0", Offset = "0x5E160A0", VA = "0x185E178A0")]
	public static void NPMLJNBKCHJ(RenderTexture LMKGMMDKLIM)
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
