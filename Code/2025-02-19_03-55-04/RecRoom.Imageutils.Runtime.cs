using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Microsoft.CodeAnalysis;
using Unity.Collections;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
namespace Microsoft.CodeAnalysis
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class EmbeddedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x9827A0", Offset = "0x9813A0", VA = "0x1809827A0")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter, AllowMultiple = false, Inherited = false)]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x74D9EE0", Offset = "0x74D8AE0", VA = "0x1874D9EE0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x9836D0", Offset = "0x9822D0", VA = "0x1809836D0")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[Microsoft.CodeAnalysis.Embedded]
	[CompilerGenerated]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x983710", Offset = "0x982310", VA = "0x180983710")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
namespace RecRoom.Utils.Image
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[RequireComponent(typeof(Camera))]
	public class CubeMapGenerator : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		public int Resolution;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		public int AntiAliasLevel;

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x74D7540", Offset = "0x74D6140", VA = "0x1874D7540")]
		public CubeMapGenerator()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public static class KDGFECNFIOC
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public struct Resolution
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		public uint x;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		public uint y;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public bool IsSquare
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x74DAE10", Offset = "0x74D9A10", VA = "0x1874DAE10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x74DAE00", Offset = "0x74D9A00", VA = "0x1874DAE00")]
		public Resolution(uint MDFKHKOGFDI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0xBB76A0", Offset = "0xBB62A0", VA = "0x180BB76A0")]
		public Resolution(uint MDFKHKOGFDI, uint ELJEANFLEPB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x74DAD10", Offset = "0x74D9910", VA = "0x1874DAD10")]
		public static Resolution KPDHBIJEMPN(Resolution[] DAMABILEGII, Resolution OLMPOEHJFBJ, int OOBJLMJBEGM)
		{
			return default(Resolution);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public class HGHLPPGLDME
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private readonly Resolution LJELFDPDPCK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private Resolution? LLBBKOFKFGM;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public uint MDFKHKOGFDI
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x74D81B0", Offset = "0x74D6DB0", VA = "0x1874D81B0")]
			get
			{
				return default(uint);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public Resolution DGLILJPKCIH
		{
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x74D81C0", Offset = "0x74D6DC0", VA = "0x1874D81C0")]
			get
			{
				return default(Resolution);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0xC75730", Offset = "0xC74330", VA = "0x180C75730")]
		public HGHLPPGLDME(Resolution LJELFDPDPCK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x74D8030", Offset = "0x74D6C30", VA = "0x1874D8030")]
		private static Resolution BBCAJKCJKFG(Resolution LLBBKOFKFGM, IHDLOECPOPK IOKMKHKCDIC)
		{
			return default(Resolution);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public static class MLIHOIAIIHA
	{
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public static readonly Resolution GPKPPDLACME;

		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public static readonly Resolution JNDKAIHHMED;

		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public static readonly Resolution FDMMHNDLKNA;

		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public static readonly Resolution DBDHOCMLKKE;

		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public static readonly Resolution INEICJNLLFO;

		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public static readonly Resolution ACONPKLPHHG;

		[Cpp2IlInjected.Token(Token = "0x4000010")]
		internal static readonly Resolution[] OMBJGKDHJON;
	}

	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public static class OIAPBJEBFKA
	{
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public static readonly Resolution CHHMGPENBBC;

		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public static readonly Resolution GMOHNPDOGOP;

		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public static readonly Resolution EJLEEPHJPPN;

		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public static readonly Resolution HAFBKCANCNO;

		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public static readonly Resolution HCLAEEMNHHI;

		[Cpp2IlInjected.Token(Token = "0x4000016")]
		internal static readonly Resolution[] OMBJGKDHJON;

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x74D9F60", Offset = "0x74D8B60", VA = "0x1874D9F60")]
		public static Resolution GDOFDAALEHC(uint EENCJGAJJNC)
		{
			return default(Resolution);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public static readonly Resolution FILAMKOLNFP;
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
internal static class KHNKJHNOLNO
{
	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x74D8BC0", Offset = "0x74D77C0", VA = "0x1874D8BC0")]
	public static bool KECEFBFFADL(byte[] LLDJIJICLJF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x74D89B0", Offset = "0x74D75B0", VA = "0x1874D89B0")]
	public static bool HMIMCKHCNGL(byte[] LLDJIJICLJF, [Out] int EENCJGAJJNC, [Out] int IAPDLEOJLDI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x74D8C00", Offset = "0x74D7800", VA = "0x1874D8C00")]
	private static int PFAFNILALJJ(byte[] LLDJIJICLJF, int PKAJCFBDMNB, [Out] ushort DOBDECIGKLF)
	{
		return default(int);
	}
}
namespace RecRoom.Utils.Image
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public class ManagedTexture : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x200000D")]
		[Flags]
		public enum GACPCELEGCN : byte
		{
			[Cpp2IlInjected.Token(Token = "0x4000020")]
			None = 0,
			[Cpp2IlInjected.Token(Token = "0x4000021")]
			GPU = 1,
			[Cpp2IlInjected.Token(Token = "0x4000022")]
			System = 2,
			[Cpp2IlInjected.Token(Token = "0x4000023")]
			Both = 3
		}

		[Cpp2IlInjected.Token(Token = "0x200000E")]
		private class NMAKJOPIMDK : IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000024")]
			private string BGKKCEGMOKH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000025")]
			public Texture2D NGKNCBOEHEC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000026")]
			public GACPCELEGCN IIMADIAJNMM;

			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x74D9E90", Offset = "0x74D8A90", VA = "0x1874D9E90")]
			public NMAKJOPIMDK(string BGKKCEGMOKH)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x44E2DC0", Offset = "0x44E19C0", VA = "0x1844E2DC0")]
			public NMAKJOPIMDK(string BGKKCEGMOKH, Texture2D AIKPMCHDKOH, GACPCELEGCN GPKBNAJDKMM)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x74D9E50", Offset = "0x74D8A50", VA = "0x1874D9E50", Slot = "4")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000F")]
		[CompilerGenerated]
		private sealed class LFPHHHOCOLA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000027")]
			public ManagedTexture <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000028")]
			public GACPCELEGCN textureMemory;

			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x960580", Offset = "0x95F180", VA = "0x180960580")]
			public LFPHHHOCOLA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x74D8C90", Offset = "0x74D7890", VA = "0x1874D8C90")]
			internal void ILHBLHIGELN()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000010")]
		[CompilerGenerated]
		private sealed class JDLCMCAAFOD
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000029")]
			public int quality;

			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x960580", Offset = "0x95F180", VA = "0x180960580")]
			public JDLCMCAAFOD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x74D8510", Offset = "0x74D7110", VA = "0x1874D8510")]
			internal DKPINLIKPED EJOEECCLLCB(Texture2D t2d)
			{
				return default(DKPINLIKPED);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000012")]
		[CompilerGenerated]
		private sealed class HEKKINLKODK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400002C")]
			public RenderTexture tempRenderTexture;

			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x960580", Offset = "0x95F180", VA = "0x180960580")]
			public HEKKINLKODK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x74D7F70", Offset = "0x74D6B70", VA = "0x1874D7F70")]
			internal void DNPIFJIDBBP()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		[SerializeField]
		private bool usePalette;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		[SerializeField]
		private string name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private JOIICJDLMNO<Texture2D> _cpuSidePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private NMAKJOPIMDK _memTexture;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private JOIICJDLMNO<DKPINLIKPED> _jpgEncodePromise;

		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public const int DEFAULT_JPG_QUALITY = 80;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private JOIICJDLMNO<DKPINLIKPED> _pngEncodePromise;

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public bool UsePalette
		{
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0xB435D0", Offset = "0xB421D0", VA = "0x180B435D0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public RenderTexture LastRenderTexture
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x957550", Offset = "0x956150", VA = "0x180957550")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x957500", Offset = "0x956100", VA = "0x180957500")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		private NMAKJOPIMDK memoryTexture
		{
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x74D9DA0", Offset = "0x74D89A0", VA = "0x1874D9DA0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x74D9CD0", Offset = "0x74D88D0", VA = "0x1874D9CD0")]
		public ManagedTexture(string BGKKCEGMOKH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x74D9D30", Offset = "0x74D8930", VA = "0x1874D9D30")]
		public ManagedTexture(string BGKKCEGMOKH, bool MCBDDKBAMFK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x74D9C90", Offset = "0x74D8890", VA = "0x1874D9C90")]
		public void MNJOAKIKDCN(RenderTexture LAFJENBGFOE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x74D9810", Offset = "0x74D8410", VA = "0x1874D9810")]
		public JOIICJDLMNO<Texture2D> FKAGGCMNMGP(GACPCELEGCN GPKBNAJDKMM, bool NEJDPDPHNGF = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x74D9B00", Offset = "0x74D8700", VA = "0x1874D9B00")]
		public JOIICJDLMNO<DKPINLIKPED> GDOPKHDGJAE(bool NEJDPDPHNGF = false, int NNDEKBGALPO = 80)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x74D8EC0", Offset = "0x74D7AC0", VA = "0x1874D8EC0")]
		public JOIICJDLMNO<DKPINLIKPED> ADAIPMPMHLN(bool NEJDPDPHNGF = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x74D9250", Offset = "0x74D7E50", VA = "0x1874D9250")]
		private static JOIICJDLMNO<Texture2D> CLAMPDGDFOL(string BGKKCEGMOKH, RenderTexture LAFJENBGFOE, Texture2D MCCMECEPAMM, bool NEJDPDPHNGF, GACPCELEGCN HHGIEJIAPGF = GACPCELEGCN.GPU)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x74D91B0", Offset = "0x74D7DB0", VA = "0x1874D91B0")]
		public void BCDCDDBJEOK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x74D9800", Offset = "0x74D8400", VA = "0x1874D9800", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x74D97A0", Offset = "0x74D83A0", VA = "0x1874D97A0")]
		[CompilerGenerated]
		private JOIICJDLMNO<byte[]> CMFIPGGDPBC(Texture2D GCBBFNBNLPP)
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public static class OIIJBNGFPOA
{
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	private struct FCKEADHCNEO
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x74D7BE0", Offset = "0x74D67E0", VA = "0x1874D7BE0")]
		public unsafe static extern void EHGIAFNMBLC(void* NCFKEHEDKBC, void* DNBDCKCECAB, bool IDPEJONFBHA, bool DIAANEDKCDI, bool LEDIGDPDFGO, [Out] int EENCJGAJJNC, [Out] int IAPDLEOJLDI, [Out] bool FPCKKMEFFCE);
	}

	[Cpp2IlInjected.Token(Token = "0x2000015")]
	[CompilerGenerated]
	private sealed class BCAPFPCKKPM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		public byte[] imageBytes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public bool generateMipMaps;

		[Cpp2IlInjected.FieldOffset(Offset = "0x19")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public bool bgr;

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x960580", Offset = "0x95F180", VA = "0x180960580")]
		public BCAPFPCKKPM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x74D73A0", Offset = "0x74D5FA0", VA = "0x1874D73A0")]
		internal void PHNHFJOHJFE(NativeArray<byte> outputTextureBytes)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[CompilerGenerated]
	private struct FKGBBHDLBAK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public AsyncTaskMethodBuilder<Texture2D> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public byte[] imageBytes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public bool generateMipMaps;

		[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		public bool makeTextureReadable;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private TaskAwaiter<Texture2D> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x74D7CE0", Offset = "0x74D68E0", VA = "0x1874D7CE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x74D7F00", Offset = "0x74D6B00", VA = "0x1874D7F00", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[CompilerGenerated]
	private sealed class HFGFBPFMLGJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public Action<NativeArray<byte>> compressionAction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public NativeArray<byte> outputTextureBytes;

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x960580", Offset = "0x95F180", VA = "0x180960580")]
		public HFGFBPFMLGJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x74D7FF0", Offset = "0x74D6BF0", VA = "0x1874D7FF0")]
		internal void JBJACMFAEGG()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[CompilerGenerated]
	private struct OJLNHFDHLPO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public AsyncTaskMethodBuilder<Texture2D> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public Action<NativeArray<byte>> compressionAction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public bool hasAlpha;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public int width;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		public int height;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public bool generateMipMaps;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3D")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public bool makeTextureReadable;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private HFGFBPFMLGJ <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		private Texture2D <outputTexture>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x74DA5E0", Offset = "0x74D91E0", VA = "0x1874DA5E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x74DACA0", Offset = "0x74D98A0", VA = "0x1874DACA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private static readonly bool ICNOFICPIDD;

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x9A1F50", Offset = "0x9A0B50", VA = "0x1809A1F50")]
	public static bool GNNDEANJHJI(byte[] KOIENEFMELP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x74DA280", Offset = "0x74D8E80", VA = "0x1874DA280")]
	[AsyncStateMachine(typeof(FKGBBHDLBAK))]
	public static Task<Texture2D> JBAGCGMNPAK(byte[] KOIENEFMELP, bool NBDGENDNOEB = false, bool IMFGNAGGABH = false, [Optional] CancellationToken NAOIMKEDKEJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x74DA450", Offset = "0x74D9050", VA = "0x1874DA450")]
	[AsyncStateMachine(typeof(OJLNHFDHLPO))]
	private static Task<Texture2D> POMPPCOAMKJ(int EENCJGAJJNC, int IAPDLEOJLDI, bool KFNIDBMJDIO, bool NBDGENDNOEB, bool IMFGNAGGABH, Action<NativeArray<byte>> JEDCFFDKHII, CancellationToken NAOIMKEDKEJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x74DA3C0", Offset = "0x74D8FC0", VA = "0x1874DA3C0")]
	private static TextureFormat MNEIBHDHFBJ(bool KFNIDBMJDIO)
	{
		return default(TextureFormat);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
internal enum AEEJKFCGCEM
{
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	RGB,
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	BGR,
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	RGBA,
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	ABGR
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
internal static class DJOJMMCBJAJ
{
	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x74D7BA0", Offset = "0x74D67A0", VA = "0x1874D7BA0")]
	public static bool OJOEOKHGMMK(byte[] LLDJIJICLJF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x74D7890", Offset = "0x74D6490", VA = "0x1874D7890")]
	public static void JJJNAJMLCHF(byte[] LLDJIJICLJF, [Out] int EENCJGAJJNC, [Out] int IAPDLEOJLDI, [Out] AEEJKFCGCEM MPDMBPEKKLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x74D7760", Offset = "0x74D6360", VA = "0x1874D7760")]
	private static uint IGJEHACFAJC(byte[] LLDJIJICLJF, int BICIFKAHIKL)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x74D7560", Offset = "0x74D6160", VA = "0x1874D7560")]
	private static ulong FFDPEIBGHGL(byte[] LLDJIJICLJF, int BICIFKAHIKL)
	{
		return default(ulong);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public static class JODHOBBENJJ
{
	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x74D85B0", Offset = "0x74D71B0", VA = "0x1874D85B0")]
	public static RenderTexture HFNGJLFJJDJ(int EENCJGAJJNC, int IAPDLEOJLDI, int NAEHIKACNDB, Camera CBLDONJIECH, RenderTextureMemoryless GOFECGOMBLL = RenderTextureMemoryless.None)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x74D8550", Offset = "0x74D7150", VA = "0x1874D8550")]
	public static void BNKIDOMOBHI(RenderTexture LAFJENBGFOE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public sealed class GLLAOJKBFAH<TImageId> : IDisposable where TImageId : notnull, IEquatable<TImageId>
{
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	private readonly struct BDNPIGHHDIO : IEquatable<BDNPIGHHDIO>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public readonly TImageId MPMDBEHHGDI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public readonly ELEIDFHMMCC DILPOCPNHLN;

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x1554050", Offset = "0x1552C50", VA = "0x181554050")]
		public BDNPIGHHDIO(TImageId NKANGPLHEGE, ELEIDFHMMCC OLHMFJKENGJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x58000E0", Offset = "0x57FECE0", VA = "0x1858000E0", Slot = "4")]
		public bool Equals(GLLAOJKBFAH<TImageId>.BDNPIGHHDIO PELBNOCGOOJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x58001E0", Offset = "0x57FEDE0", VA = "0x1858001E0", Slot = "0")]
		public override bool Equals(object CFMCKCBBBKK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x58002F0", Offset = "0x57FEEF0", VA = "0x1858002F0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x5800580", Offset = "0x57FF180", VA = "0x185800580", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[CompilerGenerated]
	private sealed class DJIGNDKAOMH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public PAGNEAPPJJN<Task<Texture2D>> innerDisposableTask;

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x960580", Offset = "0x95F180", VA = "0x180960580")]
		public DJIGNDKAOMH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x631DBF0", Offset = "0x631C7F0", VA = "0x18631DBF0")]
		internal void NIEGGPDAIGG()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[CompilerGenerated]
	private struct JGGJJJDMINM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public AsyncTaskMethodBuilder<Texture2D> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public BDNPIGHHDIO cacheKey;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public GLLAOJKBFAH<TImageId> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		private TImageId <imageId>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		private ELEIDFHMMCC <textureLoadOptions>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		private TaskAwaiter<byte[]> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		private TaskAwaiter<Texture2D> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x4934390", Offset = "0x4932F90", VA = "0x184934390", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x4935200", Offset = "0x4933E00", VA = "0x184935200", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[CompilerGenerated]
	private struct JMIMAGFNBCL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public AsyncTaskMethodBuilder<Texture2D> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public ELEIDFHMMCC textureLoadOptions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public byte[] imageBytes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public GLLAOJKBFAH<TImageId> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		private bool <generateMipMaps>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		private bool <makeTextureReadable>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		private TaskAwaiter<Texture2D> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x4945300", Offset = "0x4943F00", VA = "0x184945300", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x4945A10", Offset = "0x4944610", VA = "0x184945A10", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[CompilerGenerated]
	private struct CGFOFMFOHIH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public IDisposable disposable;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x5AAE320", Offset = "0x5AACF20", VA = "0x185AAE320", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x5AAE560", Offset = "0x5AAD160", VA = "0x185AAE560", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400004B")]
	private const int IKPEGLLKOHJ = 1;

	[Cpp2IlInjected.Token(Token = "0x400004C")]
	private static readonly SemaphoreSlim PHILHGHLHAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	private readonly Func<TImageId, CancellationToken, Task<byte[]>>? EEBAGMGCPJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	private readonly Func<TImageId, ELEIDFHMMCC, CancellationToken, Task<Texture2D>>? MFMLDGILMHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	private readonly Func<TImageId, string>? NPBBODCAKMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	private readonly NIDMLILKNFO<BDNPIGHHDIO, Texture2D> AOCHDLCPKFI;

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x44E1050", Offset = "0x44DFC50", VA = "0x1844E1050")]
	public GLLAOJKBFAH(Func<TImageId, CancellationToken, Task<byte[]>> BFDPIKHBJML, [Optional] Func<TImageId, string>? ADIEPAKNALJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x44E1000", Offset = "0x44DFC00", VA = "0x1844E1000")]
	public GLLAOJKBFAH(Func<TImageId, ELEIDFHMMCC, CancellationToken, Task<Texture2D>> HNEAOBNGPGJ, [Optional] Func<TImageId, string>? ADIEPAKNALJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x44E10A0", Offset = "0x44DFCA0", VA = "0x1844E10A0")]
	private GLLAOJKBFAH(Func<TImageId, CancellationToken, Task<byte[]>>? BFDPIKHBJML, Func<TImageId, ELEIDFHMMCC, CancellationToken, Task<Texture2D>>? HNEAOBNGPGJ, Func<TImageId, string>? ADIEPAKNALJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x44E0360", Offset = "0x44DEF60", VA = "0x1844E0360")]
	public OBLFPJIHAJD<Texture2D> DFDDPHPBNNL(TImageId JFKKGAPJJII, ELEIDFHMMCC OOLPBOPBJIK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x44E00D0", Offset = "0x44DECD0", VA = "0x1844E00D0")]
	public void COPJFCALJGH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x44E0570", Offset = "0x44DF170", VA = "0x1844E0570", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x44E0770", Offset = "0x44DF370", VA = "0x1844E0770")]
	[AsyncStateMachine(typeof(GLLAOJKBFAH<>.JGGJJJDMINM))]
	private Task<Texture2D> FALDODNCFMB(BDNPIGHHDIO OJEMGKJCJDB, CancellationToken NAOIMKEDKEJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x44E0C30", Offset = "0x44DF830", VA = "0x1844E0C30")]
	[AsyncStateMachine(typeof(GLLAOJKBFAH<>.JMIMAGFNBCL))]
	private Task<Texture2D> LAKKPMFDIEH(byte[] KOIENEFMELP, ELEIDFHMMCC OOLPBOPBJIK, CancellationToken NAOIMKEDKEJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x44E0AB0", Offset = "0x44DF6B0", VA = "0x1844E0AB0")]
	private void JOBOJAHBBFG(Texture2D AIKPMCHDKOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x44E0AC0", Offset = "0x44DF6C0", VA = "0x1844E0AC0")]
	private bool KIFIEFJHKNK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x44E0D90", Offset = "0x44DF990", VA = "0x1844E0D90")]
	private bool PNBNNFPLBBP(byte[] KOIENEFMELP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x44E08D0", Offset = "0x44DF4D0", VA = "0x1844E08D0")]
	[CompilerGenerated]
	[AsyncStateMachine(typeof(GLLAOJKBFAH<>.CGFOFMFOHIH))]
	internal static Task FGLNEEKNCFL(IDisposable CDKGOEPCOCL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
[Flags]
public enum ELEIDFHMMCC : byte
{
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	Default = 0,
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	NoMipMaps = 1,
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	MakeTextureReadable = 2,
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	CompressTexture = 4
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
