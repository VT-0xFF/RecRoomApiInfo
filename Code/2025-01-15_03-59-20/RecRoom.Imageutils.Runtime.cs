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
		[Cpp2IlInjected.Address(RVA = "0x8F0CF0", Offset = "0x8F00F0", VA = "0x1808F0CF0")]
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
		[Cpp2IlInjected.Address(RVA = "0x701F9C0", Offset = "0x701EDC0", VA = "0x18701F9C0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x8F1670", Offset = "0x8F0A70", VA = "0x1808F1670")]
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
		[Cpp2IlInjected.Address(RVA = "0x8F16B0", Offset = "0x8F0AB0", VA = "0x1808F16B0")]
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
		[Cpp2IlInjected.Address(RVA = "0x701D050", Offset = "0x701C450", VA = "0x18701D050")]
		public CubeMapGenerator()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public static class KFNMODJLLOF
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
			[Cpp2IlInjected.Address(RVA = "0x7020020", Offset = "0x701F420", VA = "0x187020020")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x7020010", Offset = "0x701F410", VA = "0x187020010")]
		public Resolution(uint KENGFOGLPKI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x961F80", Offset = "0x961380", VA = "0x180961F80")]
		public Resolution(uint KENGFOGLPKI, uint IFGPABAHODO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x701FF20", Offset = "0x701F320", VA = "0x18701FF20")]
		public static Resolution OFALIHCNEIG(Resolution[] MFKLHLPHDGD, Resolution NMNJDLKAMOP, int HMNCFFAOFPN)
		{
			return default(Resolution);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public class PKICCPEIJJE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private readonly Resolution CADOAOMOOGL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private Resolution? JELIBLNLKHM;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public uint KENGFOGLPKI
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x701FF10", Offset = "0x701F310", VA = "0x18701FF10")]
			get
			{
				return default(uint);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public Resolution DMOOBDDMFDD
		{
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x701FBC0", Offset = "0x701EFC0", VA = "0x18701FBC0")]
			get
			{
				return default(Resolution);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0xA0BC30", Offset = "0xA0B030", VA = "0x180A0BC30")]
		public PKICCPEIJJE(Resolution CADOAOMOOGL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x701FA40", Offset = "0x701EE40", VA = "0x18701FA40")]
		private static Resolution IENFGADFKEK(Resolution JELIBLNLKHM, GNDHIHCDBKG MKJDDCKIJJC)
		{
			return default(Resolution);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public static class EKGPLGBGLAA
	{
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public static readonly Resolution BIFPHPJIEFC;

		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public static readonly Resolution KNMKAIIDFBH;

		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public static readonly Resolution CNMLBFLGIKP;

		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public static readonly Resolution BBNCNNLDACP;

		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public static readonly Resolution CHEHMBJLAKH;

		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public static readonly Resolution BOEOFPKBDHI;

		[Cpp2IlInjected.Token(Token = "0x4000010")]
		internal static readonly Resolution[] OOLONIKKDFD;
	}

	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public static class NPJDDCGNMKO
	{
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public static readonly Resolution DHAOCFBGLGF;

		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public static readonly Resolution LOILANAEPCN;

		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public static readonly Resolution IMEKEJCJBJP;

		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public static readonly Resolution IKLEBNKLEHD;

		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public static readonly Resolution NDADKDIHONE;

		[Cpp2IlInjected.Token(Token = "0x4000016")]
		internal static readonly Resolution[] OOLONIKKDFD;

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x701F6A0", Offset = "0x701EAA0", VA = "0x18701F6A0")]
		public static Resolution MMILLCKLEHH(uint KHEFLNOGEHI)
		{
			return default(Resolution);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public static readonly Resolution BEGJIBKFCKH;
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
internal static class HOCIPJMEFPB
{
	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x701DD70", Offset = "0x701D170", VA = "0x18701DD70")]
	public static bool JBICJIOJLDH(byte[] JGCOLLOOLHL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x701DDB0", Offset = "0x701D1B0", VA = "0x18701DDB0")]
	public static bool KFJDDMIPEFG(byte[] JGCOLLOOLHL, [Out] int KHEFLNOGEHI, [Out] int ADAKCMMMMFF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x701DFC0", Offset = "0x701D3C0", VA = "0x18701DFC0")]
	private static int PGBPNCLNJME(byte[] JGCOLLOOLHL, int GDCLLKFPEAF, [Out] ushort OKAHBJELMOK)
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
		public enum GFOIHNGAFAD : byte
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
		private class AIJFOBBIHML : IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000024")]
			private string LJAGHAHCFHJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000025")]
			public Texture2D GJLCMMMNILC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000026")]
			public GFOIHNGAFAD HOGCIGGECDL;

			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x701C980", Offset = "0x701BD80", VA = "0x18701C980")]
			public AIJFOBBIHML(string LJAGHAHCFHJ)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x419F1F0", Offset = "0x419E5F0", VA = "0x18419F1F0")]
			public AIJFOBBIHML(string LJAGHAHCFHJ, Texture2D EPCABFKFFHG, GFOIHNGAFAD MGAOKJMOMDM)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x701C940", Offset = "0x701BD40", VA = "0x18701C940", Slot = "4")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000F")]
		[CompilerGenerated]
		private sealed class FLLINFKIKGL
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000027")]
			public ManagedTexture <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000028")]
			public GFOIHNGAFAD textureMemory;

			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
			public FLLINFKIKGL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x701DD30", Offset = "0x701D130", VA = "0x18701DD30")]
			internal void JEIGGCLELOE()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000010")]
		[CompilerGenerated]
		private sealed class JHIPPMIOELM
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000029")]
			public int quality;

			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
			public JHIPPMIOELM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x701E480", Offset = "0x701D880", VA = "0x18701E480")]
			internal NLAIGGBKNNA NFFMBHIBMGL(Texture2D t2d)
			{
				return default(NLAIGGBKNNA);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000012")]
		[CompilerGenerated]
		private sealed class LBMFLMBPFBC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400002C")]
			public RenderTexture tempRenderTexture;

			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
			public LBMFLMBPFBC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x701E690", Offset = "0x701DA90", VA = "0x18701E690")]
			internal void NBCFJLNPHHB()
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
		private AMMGOODCICE<Texture2D> _cpuSidePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private AIJFOBBIHML _memTexture;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private AMMGOODCICE<NLAIGGBKNNA> _jpgEncodePromise;

		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public const int DEFAULT_JPG_QUALITY = 80;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private AMMGOODCICE<NLAIGGBKNNA> _pngEncodePromise;

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public bool UsePalette
		{
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x9617B0", Offset = "0x960BB0", VA = "0x1809617B0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public RenderTexture LastRenderTexture
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x8C7980", Offset = "0x8C6D80", VA = "0x1808C7980")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x8C7990", Offset = "0x8C6D90", VA = "0x1808C7990")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		private AIJFOBBIHML memoryTexture
		{
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x701F5F0", Offset = "0x701E9F0", VA = "0x18701F5F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x701F520", Offset = "0x701E920", VA = "0x18701F520")]
		public ManagedTexture(string LJAGHAHCFHJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x701F580", Offset = "0x701E980", VA = "0x18701F580")]
		public ManagedTexture(string LJAGHAHCFHJ, bool PCNODPFCIHI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x701EF90", Offset = "0x701E390", VA = "0x18701EF90")]
		public void OKBEJHBMBNH(RenderTexture BJOPCDPNEJH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x701E780", Offset = "0x701DB80", VA = "0x18701E780")]
		public AMMGOODCICE<Texture2D> FAFJIMAFOJG(GFOIHNGAFAD MGAOKJMOMDM, bool PMHNHNIJLEG = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x701EA70", Offset = "0x701DE70", VA = "0x18701EA70")]
		public AMMGOODCICE<NLAIGGBKNNA> FBGDFDJOCOA(bool PMHNHNIJLEG = false, int ACMDLFDEGKG = 80)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x701ECA0", Offset = "0x701E0A0", VA = "0x18701ECA0")]
		public AMMGOODCICE<NLAIGGBKNNA> OCGDNFHMLPB(bool PMHNHNIJLEG = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x701EFD0", Offset = "0x701E3D0", VA = "0x18701EFD0")]
		private static AMMGOODCICE<Texture2D> PMGPHOLDBKP(string LJAGHAHCFHJ, RenderTexture BJOPCDPNEJH, Texture2D GJHDGADHMNG, bool PMHNHNIJLEG, GFOIHNGAFAD KAGKKDFEHAB = GFOIHNGAFAD.GPU)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x701EC00", Offset = "0x701E000", VA = "0x18701EC00")]
		public void NAINDFIJHDD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x701E770", Offset = "0x701DB70", VA = "0x18701E770", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x701E710", Offset = "0x701DB10", VA = "0x18701E710")]
		[CompilerGenerated]
		private AMMGOODCICE<byte[]> CNPEJNBPGON(Texture2D CDCIANOKIHO)
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public static class FICALCHKDBN
{
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	private struct ABDLKIGLBMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x701C5B0", Offset = "0x701B9B0", VA = "0x18701C5B0")]
		public unsafe static extern void LPCCKKAMLMP(void* OBOKPGGDIHC, void* LJFKJHDEOPC, bool ELOIINKIPCM, bool HEMCKPMNKOP, bool OMBFDLBPCPL, [Out] int KHEFLNOGEHI, [Out] int ADAKCMMMMFF, [Out] bool AGMHKLEDIEM);
	}

	[Cpp2IlInjected.Token(Token = "0x2000015")]
	[CompilerGenerated]
	private sealed class JGDCHKGKPLC
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
		[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
		public JGDCHKGKPLC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x701E2E0", Offset = "0x701D6E0", VA = "0x18701E2E0")]
		internal void AAGBNICMBNJ(NativeArray<byte> outputTextureBytes)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[CompilerGenerated]
	private struct JABCBLLIDBB : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x701E050", Offset = "0x701D450", VA = "0x18701E050", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x701E270", Offset = "0x701D670", VA = "0x18701E270", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[CompilerGenerated]
	private sealed class FFNIEMPPBPK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public Action<NativeArray<byte>> compressionAction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public NativeArray<byte> outputTextureBytes;

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
		public FFNIEMPPBPK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x701D260", Offset = "0x701C660", VA = "0x18701D260")]
		internal void EFKHOLLFBIE()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[CompilerGenerated]
	private struct FJGPJMIPCGH : IAsyncStateMachine
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
		private FFNIEMPPBPK <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		private Texture2D <outputTexture>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x701D600", Offset = "0x701CA00", VA = "0x18701D600", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x701DCC0", Offset = "0x701D0C0", VA = "0x18701DCC0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private static readonly bool NJABIFLLNLJ;

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x90FCA0", Offset = "0x90F0A0", VA = "0x18090FCA0")]
	public static bool LEBEGHMNFJB(byte[] NALCLIMCBDI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x701D2A0", Offset = "0x701C6A0", VA = "0x18701D2A0")]
	[AsyncStateMachine(typeof(JABCBLLIDBB))]
	public static Task<Texture2D> BIEPHDGJJHP(byte[] NALCLIMCBDI, bool PFENALCCIHL = false, bool PNJNDNEDJFA = false, [Optional] CancellationToken FHGIOBPPFHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x701D3E0", Offset = "0x701C7E0", VA = "0x18701D3E0")]
	[AsyncStateMachine(typeof(FJGPJMIPCGH))]
	private static Task<Texture2D> DKLINBGAMMG(int KHEFLNOGEHI, int ADAKCMMMMFF, bool NLGNPKNAFHI, bool PFENALCCIHL, bool PNJNDNEDJFA, Action<NativeArray<byte>> MIPCBIIBALH, CancellationToken FHGIOBPPFHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x701D530", Offset = "0x701C930", VA = "0x18701D530")]
	private static TextureFormat LNCJJACEHAE(bool NLGNPKNAFHI)
	{
		return default(TextureFormat);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
internal enum IGIKNEAAIMG
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
internal static class BAPOPDJOIIL
{
	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x701D010", Offset = "0x701C410", VA = "0x18701D010")]
	public static bool OCLKEIDAKNO(byte[] JGCOLLOOLHL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x701CD00", Offset = "0x701C100", VA = "0x18701CD00")]
	public static void NBHMBDFFIHM(byte[] JGCOLLOOLHL, [Out] int KHEFLNOGEHI, [Out] int ADAKCMMMMFF, [Out] IGIKNEAAIMG LAKAMCGCHJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x701C9D0", Offset = "0x701BDD0", VA = "0x18701C9D0")]
	private static uint FHCFCICAMAG(byte[] JGCOLLOOLHL, int JJJPINFOLNN)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x701CB00", Offset = "0x701BF00", VA = "0x18701CB00")]
	private static ulong MCFOEPNDJHH(byte[] JGCOLLOOLHL, int JJJPINFOLNN)
	{
		return default(ulong);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public static class ADBJNOCOLHJ
{
	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x701C710", Offset = "0x701BB10", VA = "0x18701C710")]
	public static RenderTexture LKFBDKBCPAJ(int KHEFLNOGEHI, int ADAKCMMMMFF, int GPFECEMMHKP, Camera HNKNJAPAGLP, RenderTextureMemoryless HLMDFBJBIIM = RenderTextureMemoryless.None)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x701C6B0", Offset = "0x701BAB0", VA = "0x18701C6B0")]
	public static void DPJDFCNAKIB(RenderTexture BJOPCDPNEJH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public sealed class LFNPIJFONPG<TImageId> : IDisposable where TImageId : notnull, IEquatable<TImageId>
{
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	private readonly struct FBPLCANNNBD : IEquatable<FBPLCANNNBD>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public readonly TImageId KLICOLJAKND;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public readonly AKCMNNFGBOH IJONEBLBLFM;

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x12D9330", Offset = "0x12D8730", VA = "0x1812D9330")]
		public FBPLCANNNBD(TImageId LDCKBFKFIKC, AKCMNNFGBOH PKMMIPHBCGE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x4052D90", Offset = "0x4052190", VA = "0x184052D90", Slot = "4")]
		public bool Equals(LFNPIJFONPG<TImageId>.FBPLCANNNBD BMKPAKCEMFK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x4052C10", Offset = "0x4052010", VA = "0x184052C10", Slot = "0")]
		public override bool Equals(object NCHBKHMIMGJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x4052EC0", Offset = "0x40522C0", VA = "0x184052EC0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x4053080", Offset = "0x4052480", VA = "0x184053080", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[CompilerGenerated]
	private sealed class PJDLFBPLCBO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public PMAODDEEHAH<Task<Texture2D>> innerDisposableTask;

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
		public PJDLFBPLCBO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x4C6F760", Offset = "0x4C6EB60", VA = "0x184C6F760")]
		internal void AFGIJNAFMLB()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[CompilerGenerated]
	private struct LBDHDCLHECM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public AsyncTaskMethodBuilder<Texture2D> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public FBPLCANNNBD cacheKey;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public LFNPIJFONPG<TImageId> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		private TImageId <imageId>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		private AKCMNNFGBOH <textureLoadOptions>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		private TaskAwaiter<byte[]> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		private TaskAwaiter<Texture2D> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x47BAF60", Offset = "0x47BA360", VA = "0x1847BAF60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x47BB6C0", Offset = "0x47BAAC0", VA = "0x1847BB6C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[CompilerGenerated]
	private struct BLBJOPGACDH : IAsyncStateMachine
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
		public AKCMNNFGBOH textureLoadOptions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public byte[] imageBytes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public LFNPIJFONPG<TImageId> <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x53DA6B0", Offset = "0x53D9AB0", VA = "0x1853DA6B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x53DB4D0", Offset = "0x53DA8D0", VA = "0x1853DB4D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[CompilerGenerated]
	private struct NIGAOMBBIPF : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x4A859E0", Offset = "0x4A84DE0", VA = "0x184A859E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x4A85DA0", Offset = "0x4A851A0", VA = "0x184A85DA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400004B")]
	private const int HGIIIIGIIHE = 1;

	[Cpp2IlInjected.Token(Token = "0x400004C")]
	private static readonly SemaphoreSlim DNDJHNGCLCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	private readonly Func<TImageId, CancellationToken, Task<byte[]>>? HEPNNDHJKKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	private readonly Func<TImageId, AKCMNNFGBOH, CancellationToken, Task<Texture2D>>? OOMKPEINHMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	private readonly Func<TImageId, string>? DEDGJAOGOEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	private readonly ICLEEDLMCMC<FBPLCANNNBD, Texture2D> ANMIKLJIDDP;

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x47C6310", Offset = "0x47C5710", VA = "0x1847C6310")]
	public LFNPIJFONPG(Func<TImageId, CancellationToken, Task<byte[]>> MHCFKJJMJAL, [Optional] Func<TImageId, string>? MNKNFCHFNEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x47C62C0", Offset = "0x47C56C0", VA = "0x1847C62C0")]
	public LFNPIJFONPG(Func<TImageId, AKCMNNFGBOH, CancellationToken, Task<Texture2D>> NHIMMAOOMLB, [Optional] Func<TImageId, string>? MNKNFCHFNEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x47C6360", Offset = "0x47C5760", VA = "0x1847C6360")]
	private LFNPIJFONPG(Func<TImageId, CancellationToken, Task<byte[]>>? MHCFKJJMJAL, Func<TImageId, AKCMNNFGBOH, CancellationToken, Task<Texture2D>>? NHIMMAOOMLB, Func<TImageId, string>? MNKNFCHFNEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x47C59B0", Offset = "0x47C4DB0", VA = "0x1847C59B0")]
	public PLBFKJMGACI<Texture2D> IKNLOMCGOEA(TImageId CKIHPHLFJJI, AKCMNNFGBOH OAEOHBILPGG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x47C5E00", Offset = "0x47C5200", VA = "0x1847C5E00")]
	public void JOJFADPOLHG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x47C5900", Offset = "0x47C4D00", VA = "0x1847C5900", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x47C5650", Offset = "0x47C4A50", VA = "0x1847C5650")]
	[AsyncStateMachine(typeof(LFNPIJFONPG<>.LBDHDCLHECM))]
	private Task<Texture2D> DBLMJKIBBGC(FBPLCANNNBD LKMCKCKNIPH, CancellationToken FHGIOBPPFHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x47C54F0", Offset = "0x47C48F0", VA = "0x1847C54F0")]
	[AsyncStateMachine(typeof(LFNPIJFONPG<>.BLBJOPGACDH))]
	private Task<Texture2D> BILAMAKAOEN(byte[] NALCLIMCBDI, AKCMNNFGBOH OAEOHBILPGG, CancellationToken FHGIOBPPFHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x47C5DF0", Offset = "0x47C51F0", VA = "0x1847C5DF0")]
	private void IOODJJHMDBB(Texture2D EPCABFKFFHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x47C60F0", Offset = "0x47C54F0", VA = "0x1847C60F0")]
	private bool LLDHMKMGMEG()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x47C5E60", Offset = "0x47C5260", VA = "0x1847C5E60")]
	private bool KJOOJJGOBJI(byte[] NALCLIMCBDI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x47C6000", Offset = "0x47C5400", VA = "0x1847C6000")]
	[CompilerGenerated]
	[AsyncStateMachine(typeof(LFNPIJFONPG<>.NIGAOMBBIPF))]
	internal static Task LKMJBPLMPJK(IDisposable PLBHEBOBICJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
[Flags]
public enum AKCMNNFGBOH : byte
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
