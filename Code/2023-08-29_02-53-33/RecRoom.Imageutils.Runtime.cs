using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class DMMACIPMJDK
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x6F790C0", Offset = "0x6F784C0", VA = "0x186F790C0")]
	public static RenderTexture EKHHGCNAMDI(int OCOCPBLDNBD, int IPGOHDEENMI, int NIACHINLKFI, Camera GNCNILLDJGG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x6F79050", Offset = "0x6F78450", VA = "0x186F79050")]
	public static void BGPODAGADOO(RenderTexture OBMNDNDMHNP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public enum FPFCGEOAFMD
{
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	NOT_SET,
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	UNSUPPORTED,
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	TWO_GB,
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	FOUR_GB,
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	EIGHT_GB
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface GMKLHDNAGOD
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	FPFCGEOAFMD PPICJDDHLCP
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class LGKEAEEAAAJ
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public struct Resolution
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public uint x;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public uint y;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public bool IsSquare
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x6F7B180", Offset = "0x6F7A580", VA = "0x186F7B180")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x6F7B170", Offset = "0x6F7A570", VA = "0x186F7B170")]
		public Resolution(uint GEAEMIOLNKK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0xA28DB0", Offset = "0xA281B0", VA = "0x180A28DB0")]
		public Resolution(uint GEAEMIOLNKK, uint KFMHCNGHPHP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x6F7B080", Offset = "0x6F7A480", VA = "0x186F7B080")]
		public static Resolution MLDMFNLPNOK(Resolution[] CPIBKOBEODB, Resolution FLGKLMNLNML, int GLNINDAMNMO)
		{
			return default(Resolution);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public class KLAMMEBODOG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private readonly Resolution PLOIJMLGJFK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private Resolution? GNCCBMHKJKJ;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public uint GEAEMIOLNKK
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x6F79500", Offset = "0x6F78900", VA = "0x186F79500")]
			get
			{
				return default(uint);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public uint KFMHCNGHPHP
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x6F796F0", Offset = "0x6F78AF0", VA = "0x186F796F0")]
			get
			{
				return default(uint);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public Resolution CEJCGPCKHLK
		{
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x6F79510", Offset = "0x6F78910", VA = "0x186F79510")]
			get
			{
				return default(Resolution);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0xC1C960", Offset = "0xC1BD60", VA = "0x180C1C960")]
		public KLAMMEBODOG(Resolution PLOIJMLGJFK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x6F79360", Offset = "0x6F78760", VA = "0x186F79360")]
		private static Resolution EOPKKAPOPDG(Resolution GNCCBMHKJKJ, FPFCGEOAFMD KJEPGBADHED)
		{
			return default(Resolution);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public static class LJFNJLIEDPM
	{
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public static readonly Resolution FFHLKBKIAMO;

		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public static readonly Resolution FAPFPIOIDIN;

		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public static readonly Resolution IMNJEDJGIGG;

		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public static readonly Resolution NJCFGELNHBL;

		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public static readonly Resolution ICCGJIDDCHG;

		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public static readonly Resolution CIJCEPDDMEJ;

		[Cpp2IlInjected.Token(Token = "0x4000012")]
		internal static readonly Resolution[] KKJBCBOMACK;
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public static class LLHANPOBFHG
	{
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public static readonly Resolution INCFNMAFGAB;

		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public static readonly Resolution IBBGMNIJBND;

		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public static readonly Resolution FHOMBOBAEKP;

		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public static readonly Resolution HIIAEDPIBNJ;

		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public static readonly Resolution OOENNPAHPAM;

		[Cpp2IlInjected.Token(Token = "0x4000018")]
		internal static readonly Resolution[] KKJBCBOMACK;

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x6F79BF0", Offset = "0x6F78FF0", VA = "0x186F79BF0")]
		public static Resolution PMJNOOOFGKE(uint OCOCPBLDNBD)
		{
			return default(Resolution);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public static readonly Resolution GCCGIMIJGBN;

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x6F79710", Offset = "0x6F78B10", VA = "0x186F79710")]
	public static bool EGIGBBJHMBB(uint ALHLNAFKKKA)
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
		public enum EGCICLDPDNH : byte
		{
			[Cpp2IlInjected.Token(Token = "0x4000024")]
			None = 0,
			[Cpp2IlInjected.Token(Token = "0x4000025")]
			GPU = 1,
			[Cpp2IlInjected.Token(Token = "0x4000026")]
			System = 2,
			[Cpp2IlInjected.Token(Token = "0x4000027")]
			Both = 3
		}

		[Cpp2IlInjected.Token(Token = "0x200000C")]
		private class PFBJEMJPBNE : IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000028")]
			private string DKPHPKDPBCM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000029")]
			public Texture2D GDGNOPBENBJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			public EGCICLDPDNH CDDEGCCOEDJ;

			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x6F7B030", Offset = "0x6F7A430", VA = "0x186F7B030")]
			public PFBJEMJPBNE(string DKPHPKDPBCM)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x2F16520", Offset = "0x2F15920", VA = "0x182F16520")]
			public PFBJEMJPBNE(string DKPHPKDPBCM, Texture2D ONDELHFOLNG, EGCICLDPDNH PAPLIPJHBNL)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x6F7AFF0", Offset = "0x6F7A3F0", VA = "0x186F7AFF0", Slot = "4")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000D")]
		[CompilerGenerated]
		private sealed class JOHMLHCMCKM
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			public ManagedTexture <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400002C")]
			public EGCICLDPDNH textureMemory;

			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x7EA760", Offset = "0x7E9B60", VA = "0x1807EA760")]
			public JOHMLHCMCKM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x6F79320", Offset = "0x6F78720", VA = "0x186F79320")]
			internal void NANMOFFDBFG()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000E")]
		[CompilerGenerated]
		private sealed class GHKNFAEGLNI
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400002D")]
			public int quality;

			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x7EA760", Offset = "0x7E9B60", VA = "0x1807EA760")]
			public GHKNFAEGLNI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x6F79300", Offset = "0x6F78700", VA = "0x186F79300")]
			internal byte[] CHFBPLOCICC(Texture2D t2d)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000F")]
		[CompilerGenerated]
		private sealed class FOAPLNGOLGC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400002E")]
			public RenderTexture tempRenderTexture;

			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x7EA760", Offset = "0x7E9B60", VA = "0x1807EA760")]
			public FOAPLNGOLGC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x6F79270", Offset = "0x6F78670", VA = "0x186F79270")]
			internal void FAAJPNKIBPI()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		[SerializeField]
		private bool usePalette;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		[SerializeField]
		private string name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private MCFFIFIPNKE<Texture2D> _cpuSidePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private PFBJEMJPBNE _memTexture;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private MCFFIFIPNKE<byte[]> _jpgEncodePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private byte[] _jpgBytes;

		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public const int DEFAULT_JPG_QUALITY = 80;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private MCFFIFIPNKE<byte[]> _pngEncodePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private byte[] _pngBytes;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public bool UsePalette
		{
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0xA2ED20", Offset = "0xA2E120", VA = "0x180A2ED20")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public RenderTexture LastRenderTexture
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x7E8120", Offset = "0x7E7520", VA = "0x1807E8120")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x7F2C10", Offset = "0x7F2010", VA = "0x1807F2C10")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		private PFBJEMJPBNE memoryTexture
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x6F7AF50", Offset = "0x6F7A350", VA = "0x186F7AF50")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x6F7AEA0", Offset = "0x6F7A2A0", VA = "0x186F7AEA0")]
		public ManagedTexture(string DKPHPKDPBCM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x6F7ADE0", Offset = "0x6F7A1E0", VA = "0x186F7ADE0")]
		public ManagedTexture(string DKPHPKDPBCM, bool MBKDPJODKOD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x6F7A380", Offset = "0x6F79780", VA = "0x186F7A380")]
		public void JECHLOMJIHF(RenderTexture OBMNDNDMHNP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x6F7A690", Offset = "0x6F79A90", VA = "0x186F7A690")]
		public MCFFIFIPNKE<byte[]> LBEFDNEMBNL(bool JLCHNGCIHCM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x6F7A3B0", Offset = "0x6F797B0", VA = "0x186F7A3B0")]
		public MCFFIFIPNKE<Texture2D> KIAFLJCNDKA(EGCICLDPDNH PAPLIPJHBNL, bool CCBGDNFDEHH = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x6F79FC0", Offset = "0x6F793C0", VA = "0x186F79FC0")]
		public MCFFIFIPNKE<byte[]> HPIKDJAHGFC(bool CCBGDNFDEHH = false, int PPDPKNHMMHM = 80)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x6F7A1C0", Offset = "0x6F795C0", VA = "0x186F7A1C0")]
		public MCFFIFIPNKE<byte[]> IHONOFLEHFF(bool CCBGDNFDEHH = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x6F7A830", Offset = "0x6F79C30", VA = "0x186F7A830")]
		private static MCFFIFIPNKE<Texture2D> PICFFEGMCIL(string DKPHPKDPBCM, RenderTexture OBMNDNDMHNP, ref Texture2D FMMLEAFEHKJ, bool CCBGDNFDEHH, EGCICLDPDNH EKMACCAGGFD = EGCICLDPDNH.GPU)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x6F7A6C0", Offset = "0x6F79AC0", VA = "0x186F7A6C0")]
		public void NNJECNIOAOI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x6F79FB0", Offset = "0x6F793B0", VA = "0x186F79FB0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x6F7A780", Offset = "0x6F79B80", VA = "0x186F7A780")]
		[CompilerGenerated]
		private MCFFIFIPNKE<byte[]> OEFGGIOLGEH(Texture2D NNPBGCPFOPK)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[RequireComponent(typeof(Camera))]
	public class CubeMapGenerator : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public int Resolution;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public int AntiAliasLevel;

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x6F79030", Offset = "0x6F78430", VA = "0x186F79030")]
		public CubeMapGenerator()
		{
		}
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
