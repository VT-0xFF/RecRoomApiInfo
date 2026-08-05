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
using UnityEngine.Rendering;

[assembly: AssemblyVersion("0.0.0.0")]
namespace Microsoft.CodeAnalysis
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class EmbeddedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x7DAB80", Offset = "0x7D9780", VA = "0x1807DAB80")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter, AllowMultiple = false, Inherited = false)]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x61417E0", Offset = "0x61403E0", VA = "0x1861417E0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x7DB530", Offset = "0x7DA130", VA = "0x1807DB530")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x7DB570", Offset = "0x7DA170", VA = "0x1807DB570")]
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
		[Cpp2IlInjected.Address(RVA = "0x613EDC0", Offset = "0x613D9C0", VA = "0x18613EDC0")]
		public CubeMapGenerator()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public enum OMOPNJFCNMB
{
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	NOT_SET,
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	UNSUPPORTED,
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	TWO_GB,
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	FOUR_GB,
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	EIGHT_GB
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface MCAMBMBILIM
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	OMOPNJFCNMB PNCLBFMMAFK
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool FLHAJNOCNJA(VertexAttributeFormat AHKBHJGDBJA, int ENKEDABEIJA);
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class PIMGDNKHIEC
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public struct Resolution
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public uint x;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public uint y;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public bool IsSquare
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x6142160", Offset = "0x6140D60", VA = "0x186142160")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x6142150", Offset = "0x6140D50", VA = "0x186142150")]
		public Resolution(uint KLNIMOGOBLK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0xADE590", Offset = "0xADD190", VA = "0x180ADE590")]
		public Resolution(uint KLNIMOGOBLK, uint EGCIDIGPDPB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x6142060", Offset = "0x6140C60", VA = "0x186142060")]
		public static Resolution ECDNJKDACHL(Resolution[] JAIAHAGCBLM, Resolution FKGEIPBBPCF, int CFGFKCJPNML)
		{
			return default(Resolution);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public class ELBMFIJEJDB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private readonly Resolution JEFACDEBIIA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private Resolution? NJAKLMFEDMB;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public uint KLNIMOGOBLK
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x613EE70", Offset = "0x613DA70", VA = "0x18613EE70")]
			get
			{
				return default(uint);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public uint EGCIDIGPDPB
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x613F1C0", Offset = "0x613DDC0", VA = "0x18613F1C0")]
			get
			{
				return default(uint);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public Resolution OMHHHKJHDFG
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x613EE80", Offset = "0x613DA80", VA = "0x18613EE80")]
			get
			{
				return default(Resolution);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0xEFDDB0", Offset = "0xEFC9B0", VA = "0x180EFDDB0")]
		public ELBMFIJEJDB(Resolution JEFACDEBIIA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x613F1E0", Offset = "0x613DDE0", VA = "0x18613F1E0")]
		private static Resolution MDNLKELGBAN(Resolution NJAKLMFEDMB, OMOPNJFCNMB CICECFKNKLD)
		{
			return default(Resolution);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public static class PFKEELHNHJP
	{
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public static readonly Resolution DDCDAGEOAFP;

		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public static readonly Resolution DDLKFNELJAL;

		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public static readonly Resolution KLDJCCJGKPA;

		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public static readonly Resolution DHOPFDPGCKF;

		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public static readonly Resolution EPPPPCBADCI;

		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public static readonly Resolution OEBGACLNCAL;

		[Cpp2IlInjected.Token(Token = "0x4000016")]
		internal static readonly Resolution[] ANHJIFKFGIO;
	}

	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public static class FLCOODANNIP
	{
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public static readonly Resolution FLPPAJOBNGA;

		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public static readonly Resolution NIEMIFMEHJD;

		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public static readonly Resolution FIGNMOFCOCE;

		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public static readonly Resolution LPCJNNJKOCC;

		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public static readonly Resolution FOGGCCGCJOJ;

		[Cpp2IlInjected.Token(Token = "0x400001C")]
		internal static readonly Resolution[] ANHJIFKFGIO;

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x613F360", Offset = "0x613DF60", VA = "0x18613F360")]
		public static Resolution BIOJHCGEPNJ(uint JIBGHGEBPGM)
		{
			return default(Resolution);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400000B")]
	public static readonly Resolution NFLCBMBPDPK;
}
namespace RecRoom.Utils.Image
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class ManagedTexture : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x200000E")]
		[Flags]
		public enum DIJGBMPONOH : byte
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

		[Cpp2IlInjected.Token(Token = "0x200000F")]
		private class DFACHHGADAH : IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			private string MPGNMPAPHDB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			public Texture2D LJFMFDGFMPO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400002C")]
			public DIJGBMPONOH APFNNHEFMAD;

			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x613EE20", Offset = "0x613DA20", VA = "0x18613EE20")]
			public DFACHHGADAH(string MPGNMPAPHDB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x3B2FB20", Offset = "0x3B2E720", VA = "0x183B2FB20")]
			public DFACHHGADAH(string MPGNMPAPHDB, Texture2D BLAFIMMPJJO, DIJGBMPONOH KGMHPGAGLIA)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x613EDE0", Offset = "0x613D9E0", VA = "0x18613EDE0", Slot = "4")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000010")]
		[CompilerGenerated]
		private sealed class OHBMHPHDGJC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400002D")]
			public ManagedTexture <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400002E")]
			public DIJGBMPONOH textureMemory;

			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x7BD130", Offset = "0x7BBD30", VA = "0x1807BD130")]
			public OHBMHPHDGJC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x6141960", Offset = "0x6140560", VA = "0x186141960")]
			internal void MKKMCFPGDNK()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000011")]
		[CompilerGenerated]
		private sealed class AGDJAEKPEHD
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400002F")]
			public int quality;

			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x7BD130", Offset = "0x7BBD30", VA = "0x1807BD130")]
			public AGDJAEKPEHD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x613EA10", Offset = "0x613D610", VA = "0x18613EA10")]
			internal GIHBCJDMJLB NPCNMLKHHII(Texture2D t2d)
			{
				return default(GIHBCJDMJLB);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000013")]
		[CompilerGenerated]
		private sealed class FNICIFFNCAE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000032")]
			public RenderTexture tempRenderTexture;

			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x7BD130", Offset = "0x7BBD30", VA = "0x1807BD130")]
			public FNICIFFNCAE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x613F6B0", Offset = "0x613E2B0", VA = "0x18613F6B0")]
			internal void DMEPGCNGGGG()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		[SerializeField]
		private bool usePalette;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		[SerializeField]
		private string name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private LHJBMADJJFP<Texture2D> _cpuSidePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private DFACHHGADAH _memTexture;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private LHJBMADJJFP<GIHBCJDMJLB> _jpgEncodePromise;

		[Cpp2IlInjected.Token(Token = "0x4000023")]
		public const int DEFAULT_JPG_QUALITY = 80;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private LHJBMADJJFP<GIHBCJDMJLB> _pngEncodePromise;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public bool UsePalette
		{
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x8029C0", Offset = "0x8015C0", VA = "0x1808029C0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public RenderTexture LastRenderTexture
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x7B2920", Offset = "0x7B1520", VA = "0x1807B2920")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x7B2B40", Offset = "0x7B1740", VA = "0x1807B2B40")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		private DFACHHGADAH memoryTexture
		{
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x61409D0", Offset = "0x613F5D0", VA = "0x1861409D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x6140900", Offset = "0x613F500", VA = "0x186140900")]
		public ManagedTexture(string MPGNMPAPHDB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x6140960", Offset = "0x613F560", VA = "0x186140960")]
		public ManagedTexture(string MPGNMPAPHDB, bool IEBCILKDLPK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x613FCE0", Offset = "0x613E8E0", VA = "0x18613FCE0")]
		public void HNHIJHDOABA(RenderTexture CBOPAFAOIAL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x6140610", Offset = "0x613F210", VA = "0x186140610")]
		public LHJBMADJJFP<Texture2D> NMEIHGGJOMB(DIJGBMPONOH KGMHPGAGLIA, bool CLNALFLDKMK = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x613FB40", Offset = "0x613E740", VA = "0x18613FB40")]
		public LHJBMADJJFP<GIHBCJDMJLB> FFNLIAJDCNK(bool CLNALFLDKMK = false, int NOLDDKJKMHE = 80)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x613FD20", Offset = "0x613E920", VA = "0x18613FD20")]
		public LHJBMADJJFP<GIHBCJDMJLB> JODCBGMEOCG(bool CLNALFLDKMK = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x61400C0", Offset = "0x613ECC0", VA = "0x1861400C0")]
		private static LHJBMADJJFP<Texture2D> NIGFOJIIDJL(string MPGNMPAPHDB, RenderTexture CBOPAFAOIAL, Texture2D BBCKDAGIKHA, bool CLNALFLDKMK, DIJGBMPONOH BHHIHPAOHKJ = DIJGBMPONOH.GPU)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x6140020", Offset = "0x613EC20", VA = "0x186140020")]
		public void MPCJNFOIOCJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x613FB30", Offset = "0x613E730", VA = "0x18613FB30", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x613FAD0", Offset = "0x613E6D0", VA = "0x18613FAD0")]
		[CompilerGenerated]
		private LHJBMADJJFP<byte[]> AJKODCNDAMA(Texture2D GJGKIMOHGOF)
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public static class BCILEJPOKFC
{
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	private struct OEKIPNHMOKL
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x6141860", Offset = "0x6140460", VA = "0x186141860")]
		public unsafe static extern void EAJKNDJKBIO(void* FOHKFKMBADK, void* NOMGJFAPODI, bool HMNJPIPIMGC, bool BJFMBECBNBN, bool KAOEPCPEBJL, [Out] int JIBGHGEBPGM, [Out] int JMAKFJEBNGB, [Out] bool HDONHDHBKLE);
	}

	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[CompilerGenerated]
	private sealed class HLFKEJDMNOM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public byte[] imageBytes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		public bool generateMipMaps;

		[Cpp2IlInjected.FieldOffset(Offset = "0x19")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public bool bgr;

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x7BD130", Offset = "0x7BBD30", VA = "0x1807BD130")]
		public HLFKEJDMNOM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x613F730", Offset = "0x613E330", VA = "0x18613F730")]
		internal void BJKAHINNPDF(NativeArray<byte> outputTextureBytes)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[CompilerGenerated]
	private struct OJDBFOODJAB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public AsyncTaskMethodBuilder<Texture2D> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public byte[] imageBytes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public bool generateMipMaps;

		[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public bool makeTextureReadable;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private TaskAwaiter<Texture2D> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x61419A0", Offset = "0x61405A0", VA = "0x1861419A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x6141BC0", Offset = "0x61407C0", VA = "0x186141BC0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[CompilerGenerated]
	private sealed class PKGDLDGJDCI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public Action<NativeArray<byte>> compressionAction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public NativeArray<byte> outputTextureBytes;

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x7BD130", Offset = "0x7BBD30", VA = "0x1807BD130")]
		public PKGDLDGJDCI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x6142020", Offset = "0x6140C20", VA = "0x186142020")]
		internal void GBKAIHOOEHD()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	[CompilerGenerated]
	private struct NMMHCGHPGGJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public AsyncTaskMethodBuilder<Texture2D> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public Action<NativeArray<byte>> compressionAction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public bool hasAlpha;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public int width;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public int height;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public bool generateMipMaps;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3D")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public bool makeTextureReadable;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private PKGDLDGJDCI <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private Texture2D <outputTexture>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x61410B0", Offset = "0x613FCB0", VA = "0x1861410B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x6141770", Offset = "0x6140370", VA = "0x186141770", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private static readonly bool EAADGBFBCHG;

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x7F8B30", Offset = "0x7F7730", VA = "0x1807F8B30")]
	public static bool PDIPFOADJIL(byte[] NLCPCFKLAII)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x613EAF0", Offset = "0x613D6F0", VA = "0x18613EAF0")]
	[AsyncStateMachine(typeof(OJDBFOODJAB))]
	public static Task<Texture2D> LDCPMIAELMI(byte[] NLCPCFKLAII, bool LKDHKDNECIH = false, bool KFKEIGJLAON = false, [Optional] CancellationToken EJGJLLMBDIN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x613EC30", Offset = "0x613D830", VA = "0x18613EC30")]
	[AsyncStateMachine(typeof(NMMHCGHPGGJ))]
	private static Task<Texture2D> NHJMADIBLHM(int JIBGHGEBPGM, int JMAKFJEBNGB, bool HAEOFAKMKDE, bool LKDHKDNECIH, bool KFKEIGJLAON, Action<NativeArray<byte>> BMDBEDBNGKF, CancellationToken EJGJLLMBDIN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x613EA50", Offset = "0x613D650", VA = "0x18613EA50")]
	private static TextureFormat GACBKGDIEJG(bool HAEOFAKMKDE)
	{
		return default(TextureFormat);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
internal enum NFLAAOIFPBG
{
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	RGB,
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	BGR,
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	RGBA,
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	ABGR
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
internal static class NILGPFLGOLH
{
	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x6140C80", Offset = "0x613F880", VA = "0x186140C80")]
	public static void CKOMIDHKJII(byte[] KOMCCCIEHEA, [Out] int JIBGHGEBPGM, [Out] int JMAKFJEBNGB, [Out] NFLAAOIFPBG AHKBHJGDBJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x6140F80", Offset = "0x613FB80", VA = "0x186140F80")]
	private static uint JABOMLKLEJE(byte[] KOMCCCIEHEA, int ILKNGPHCOGM)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x6140A80", Offset = "0x613F680", VA = "0x186140A80")]
	private static ulong ABKPEFHAEIH(byte[] KOMCCCIEHEA, int ILKNGPHCOGM)
	{
		return default(ulong);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public static class KGDMCMBAGML
{
	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x613F930", Offset = "0x613E530", VA = "0x18613F930")]
	public static RenderTexture FJIGILLHGHG(int JIBGHGEBPGM, int JMAKFJEBNGB, int EIGGDODJGMH, Camera JGPDJKGMCDE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x613F8D0", Offset = "0x613E4D0", VA = "0x18613F8D0")]
	public static void DGCCHDPCMHP(RenderTexture CBOPAFAOIAL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public sealed class JPLJPOIPCAK<TImageId> : IDisposable where TImageId : notnull, IEquatable<TImageId>
{
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	private readonly struct OGLGBNNFAMC : IEquatable<OGLGBNNFAMC>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public readonly TImageId PDEKCHJPLKJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public readonly LEMOMOGBMCO HPBGKPJAHHJ;

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x3BF5770", Offset = "0x3BF4370", VA = "0x183BF5770")]
		public OGLGBNNFAMC(TImageId CGGNJKGENIH, LEMOMOGBMCO BLBNODLKBOG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x4009CE0", Offset = "0x40088E0", VA = "0x184009CE0", Slot = "4")]
		public bool Equals(JPLJPOIPCAK<TImageId>.OGLGBNNFAMC NAFFCAIMPLI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x4009DE0", Offset = "0x40089E0", VA = "0x184009DE0", Slot = "0")]
		public override bool Equals(object OGGNGHKHHGI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x4009F80", Offset = "0x4008B80", VA = "0x184009F80", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x400A120", Offset = "0x4008D20", VA = "0x18400A120", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[CompilerGenerated]
	private sealed class ALOMCGMCKDL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public LENMHFABFBO<Task<Texture2D>> innerDisposableTask;

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x7BD130", Offset = "0x7BBD30", VA = "0x1807BD130")]
		public ALOMCGMCKDL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x38DAEC0", Offset = "0x38D9AC0", VA = "0x1838DAEC0")]
		internal void HGEKKECEAGC()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[CompilerGenerated]
	private struct GJGLAFBEHOK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public AsyncTaskMethodBuilder<Texture2D> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		public OGLGBNNFAMC cacheKey;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public JPLJPOIPCAK<TImageId> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		private TImageId <imageId>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		private LEMOMOGBMCO <textureLoadOptions>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		private TaskAwaiter<byte[]> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		private TaskAwaiter<Texture2D> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x379FF50", Offset = "0x379EB50", VA = "0x18379FF50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x37A05E0", Offset = "0x379F1E0", VA = "0x1837A05E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[CompilerGenerated]
	private struct DNFEOEEEKAA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public AsyncTaskMethodBuilder<Texture2D> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public LEMOMOGBMCO textureLoadOptions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public byte[] imageBytes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		private bool <generateMipMaps>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		private bool <makeTextureReadable>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		private TaskAwaiter<Texture2D> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x5062AD0", Offset = "0x50616D0", VA = "0x185062AD0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x50630F0", Offset = "0x5061CF0", VA = "0x1850630F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[CompilerGenerated]
	private struct LFACIDPAMEA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public IDisposable disposable;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x3C06DD0", Offset = "0x3C059D0", VA = "0x183C06DD0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x3C071F0", Offset = "0x3C05DF0", VA = "0x183C071F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private const int CDKBCPLKFHD = 1;

	[Cpp2IlInjected.Token(Token = "0x4000052")]
	private static readonly SemaphoreSlim DJFMCEJGDFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	private readonly Func<TImageId, CancellationToken, Task<byte[]>>? POHKPMCLGLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	private readonly Func<TImageId, LEMOMOGBMCO, CancellationToken, Task<Texture2D>>? KGAMPGFGPDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	private readonly Func<TImageId, string>? MAKODMMKEBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	private readonly MKEFBMKCECP<OGLGBNNFAMC, Texture2D> NHNMHEFJKFP;

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x3B31820", Offset = "0x3B30420", VA = "0x183B31820")]
	public JPLJPOIPCAK(Func<TImageId, CancellationToken, Task<byte[]>> NEGKLNABLAL, [Optional] Func<TImageId, string>? EOCKHBAOEHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x3B317F0", Offset = "0x3B303F0", VA = "0x183B317F0")]
	public JPLJPOIPCAK(Func<TImageId, LEMOMOGBMCO, CancellationToken, Task<Texture2D>> IKICDFPFNDD, [Optional] Func<TImageId, string>? EOCKHBAOEHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x3B31660", Offset = "0x3B30260", VA = "0x183B31660")]
	private JPLJPOIPCAK(Func<TImageId, CancellationToken, Task<byte[]>>? NEGKLNABLAL, Func<TImageId, LEMOMOGBMCO, CancellationToken, Task<Texture2D>>? IKICDFPFNDD, Func<TImageId, string>? EOCKHBAOEHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x3B309D0", Offset = "0x3B2F5D0", VA = "0x183B309D0")]
	public EICCGEEHPKI<Texture2D> EJMKGPJAODM(TImageId HKFHMFHHJKH, LEMOMOGBMCO JLABLMDPMLH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x3B312D0", Offset = "0x3B2FED0", VA = "0x183B312D0")]
	public void LHPGNJKPMMJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x3B30720", Offset = "0x3B2F320", VA = "0x183B30720", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x3B30D10", Offset = "0x3B2F910", VA = "0x183B30D10")]
	[AsyncStateMachine(typeof(JPLJPOIPCAK<>.GJGLAFBEHOK))]
	private Task<Texture2D> GCCJHBBLEAB(OGLGBNNFAMC OGHBIBDHMBM, CancellationToken EJGJLLMBDIN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x3B30FB0", Offset = "0x3B2FBB0", VA = "0x183B30FB0")]
	[AsyncStateMachine(typeof(JPLJPOIPCAK<>.DNFEOEEEKAA))]
	private Task<Texture2D> HKNNMNCNNMG(byte[] NLCPCFKLAII, LEMOMOGBMCO JLABLMDPMLH, CancellationToken EJGJLLMBDIN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x3B31300", Offset = "0x3B2FF00", VA = "0x183B31300")]
	private void MOOFHGJBFHM(Texture2D BLAFIMMPJJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x3B310F0", Offset = "0x3B2FCF0", VA = "0x183B310F0")]
	[AsyncStateMachine(typeof(JPLJPOIPCAK<>.LFACIDPAMEA))]
	[CompilerGenerated]
	internal static Task KFJMFBCLEHC(IDisposable BBIPKMHOKHD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
[Flags]
public enum LEMOMOGBMCO : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	Default = 0,
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	NoMipMaps = 1,
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	MakeTextureReadable = 2,
	[Cpp2IlInjected.Token(Token = "0x4000074")]
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
