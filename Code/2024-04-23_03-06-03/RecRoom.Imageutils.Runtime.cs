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
		[Cpp2IlInjected.Address(RVA = "0x7EACF0", Offset = "0x7E9CF0", VA = "0x1807EACF0")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[Microsoft.CodeAnalysis.Embedded]
	[CompilerGenerated]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter, AllowMultiple = false, Inherited = false)]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x62CD880", Offset = "0x62CC880", VA = "0x1862CD880")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x7EB340", Offset = "0x7EA340", VA = "0x1807EB340")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x7EB380", Offset = "0x7EA380", VA = "0x1807EB380")]
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
		[Cpp2IlInjected.Address(RVA = "0x62CAB20", Offset = "0x62C9B20", VA = "0x1862CAB20")]
		public CubeMapGenerator()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public enum DAAIGNKLAOA
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
public interface JKJKJGGBMAN
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	DAAIGNKLAOA KDHOCPOBCEF
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool GKFFEFMMFLP(VertexAttributeFormat GCJDIJFGBBE, int NIFBADPEBPF);
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class HFGJKKGPMKC
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
			[Cpp2IlInjected.Address(RVA = "0x62CDB00", Offset = "0x62CCB00", VA = "0x1862CDB00")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x62CDAF0", Offset = "0x62CCAF0", VA = "0x1862CDAF0")]
		public Resolution(uint DLGLHFDHDLB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0xAE6AB0", Offset = "0xAE5AB0", VA = "0x180AE6AB0")]
		public Resolution(uint DLGLHFDHDLB, uint ANLBKHHFCFE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x62CDA00", Offset = "0x62CCA00", VA = "0x1862CDA00")]
		public static Resolution DOJCBMJCAGI(Resolution[] CACELMJJEFC, Resolution KGACHKDCPDH, int JLEGBFMPLFD)
		{
			return default(Resolution);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public class APOEKFGKLCG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private readonly Resolution MOEBNJCGPFG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private Resolution? IBMMBCCCNKA;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public uint DLGLHFDHDLB
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x62CA890", Offset = "0x62C9890", VA = "0x1862CA890")]
			get
			{
				return default(uint);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public uint ANLBKHHFCFE
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x62CA3B0", Offset = "0x62C93B0", VA = "0x1862CA3B0")]
			get
			{
				return default(uint);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public Resolution GJOIDGGEGBL
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x62CA3D0", Offset = "0x62C93D0", VA = "0x1862CA3D0")]
			get
			{
				return default(Resolution);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0xF2ED50", Offset = "0xF2DD50", VA = "0x180F2ED50")]
		public APOEKFGKLCG(Resolution MOEBNJCGPFG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x62CA710", Offset = "0x62C9710", VA = "0x1862CA710")]
		private static Resolution NJFOJAEDOPD(Resolution IBMMBCCCNKA, DAAIGNKLAOA GPGEAFAGBMM)
		{
			return default(Resolution);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public static class EMJCHFMOKDC
	{
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public static readonly Resolution JLDKJLJGCJA;

		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public static readonly Resolution PDIMMMFPOII;

		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public static readonly Resolution OEAFHGFLLOK;

		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public static readonly Resolution ACKPFLDIJHA;

		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public static readonly Resolution NEKFMIGCFKJ;

		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public static readonly Resolution IFADKCBHBAF;

		[Cpp2IlInjected.Token(Token = "0x4000016")]
		internal static readonly Resolution[] JGGBMMODEHL;
	}

	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public static class MDBNJBIEALG
	{
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public static readonly Resolution CLCBNPJKOLE;

		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public static readonly Resolution PIGPHIKOJBI;

		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public static readonly Resolution IOBCPMGFNAF;

		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public static readonly Resolution BIIIOHBAMOJ;

		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public static readonly Resolution GPCNGJNMCJJ;

		[Cpp2IlInjected.Token(Token = "0x400001C")]
		internal static readonly Resolution[] JGGBMMODEHL;

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x62CC4F0", Offset = "0x62CB4F0", VA = "0x1862CC4F0")]
		public static Resolution EGEFINGBLGE(uint IAFAONPONEH)
		{
			return default(Resolution);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400000B")]
	public static readonly Resolution MIABEPDBOED;
}
namespace RecRoom.Utils.Image
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class ManagedTexture : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x200000E")]
		[Flags]
		public enum CBLCOFAIJGC : byte
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
		private class NOMMAMFMMLB : IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			private string ONGJKHHOIAM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			public Texture2D JEILJOKGGDJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400002C")]
			public CBLCOFAIJGC OICMIGJGAPE;

			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x62CD830", Offset = "0x62CC830", VA = "0x1862CD830")]
			public NOMMAMFMMLB(string ONGJKHHOIAM)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x34EE6D0", Offset = "0x34ED6D0", VA = "0x1834EE6D0")]
			public NOMMAMFMMLB(string ONGJKHHOIAM, Texture2D JLEFELGPFPC, CBLCOFAIJGC AGIHKDCNALE)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x62CD7F0", Offset = "0x62CC7F0", VA = "0x1862CD7F0", Slot = "4")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000010")]
		[CompilerGenerated]
		private sealed class DFJPIAALENC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400002D")]
			public ManagedTexture <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400002E")]
			public CBLCOFAIJGC textureMemory;

			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x7CE160", Offset = "0x7CD160", VA = "0x1807CE160")]
			public DFJPIAALENC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x62CAB40", Offset = "0x62C9B40", VA = "0x1862CAB40")]
			internal void IBKNGKJNBAF()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000011")]
		[CompilerGenerated]
		private sealed class CGGIJKBGLMD
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400002F")]
			public int quality;

			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x7CE160", Offset = "0x7CD160", VA = "0x1807CE160")]
			public CGGIJKBGLMD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x62CAAE0", Offset = "0x62C9AE0", VA = "0x1862CAAE0")]
			internal OCOBAOONBMK EGGGGIFGOEC(Texture2D t2d)
			{
				return default(OCOBAOONBMK);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000013")]
		[CompilerGenerated]
		private sealed class IGJKJLHBBCO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000032")]
			public RenderTexture tempRenderTexture;

			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x7CE160", Offset = "0x7CD160", VA = "0x1807CE160")]
			public IGJKJLHBBCO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x62CBE70", Offset = "0x62CAE70", VA = "0x1862CBE70")]
			internal void GIHPDKPEMHN()
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
		private MLBHOBCFFDI<Texture2D> _cpuSidePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private NOMMAMFMMLB _memTexture;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private MLBHOBCFFDI<OCOBAOONBMK> _jpgEncodePromise;

		[Cpp2IlInjected.Token(Token = "0x4000023")]
		public const int DEFAULT_JPG_QUALITY = 80;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private MLBHOBCFFDI<OCOBAOONBMK> _pngEncodePromise;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public bool UsePalette
		{
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x813060", Offset = "0x812060", VA = "0x180813060")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public RenderTexture LastRenderTexture
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x7C2D60", Offset = "0x7C1D60", VA = "0x1807C2D60")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x7C1DE0", Offset = "0x7C0DE0", VA = "0x1807C1DE0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		private NOMMAMFMMLB memoryTexture
		{
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x62CD740", Offset = "0x62CC740", VA = "0x1862CD740")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x62CD670", Offset = "0x62CC670", VA = "0x1862CD670")]
		public ManagedTexture(string ONGJKHHOIAM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x62CD6D0", Offset = "0x62CC6D0", VA = "0x1862CD6D0")]
		public ManagedTexture(string ONGJKHHOIAM, bool EFIOIGPDFAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x62CD630", Offset = "0x62CC630", VA = "0x1862CD630")]
		public void OJEBPMMOGKH(RenderTexture EFKHKEJGEIG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x62CCEA0", Offset = "0x62CBEA0", VA = "0x1862CCEA0")]
		public MLBHOBCFFDI<Texture2D> GAPJPGNKGBJ(CBLCOFAIJGC AGIHKDCNALE, bool KCDLJIDNODJ = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x62CD490", Offset = "0x62CC490", VA = "0x1862CD490")]
		public MLBHOBCFFDI<OCOBAOONBMK> LCFNKFLCKFP(bool KCDLJIDNODJ = false, int INIEMBFBAOI = 80)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x62CD190", Offset = "0x62CC190", VA = "0x1862CD190")]
		public MLBHOBCFFDI<OCOBAOONBMK> JBEOGLFHLMK(bool KCDLJIDNODJ = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x62CC8E0", Offset = "0x62CB8E0", VA = "0x1862CC8E0")]
		private static MLBHOBCFFDI<Texture2D> AJOAHJJJKEJ(string ONGJKHHOIAM, RenderTexture EFKHKEJGEIG, Texture2D IFJJGGCGHOD, bool KCDLJIDNODJ, CBLCOFAIJGC BOGEBNHBMHK = CBLCOFAIJGC.GPU)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x62CC840", Offset = "0x62CB840", VA = "0x1862CC840")]
		public void AJJMBAMKDBI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x62CCE90", Offset = "0x62CBE90", VA = "0x1862CCE90", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x62CCE30", Offset = "0x62CBE30", VA = "0x1862CCE30")]
		[CompilerGenerated]
		private MLBHOBCFFDI<byte[]> BAKNGEKGLDH(Texture2D BPBPMJBJLJD)
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public static class LKKKOCFNMBP
{
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	private struct OHFAHKDBCNO
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x62CD900", Offset = "0x62CC900", VA = "0x1862CD900")]
		public unsafe static extern void IKIOKKLFKFM(void* ODFMOBLHJDD, void* LJGNMEDPHKA, bool ELBKJJLOJJF, bool FDEJMEHMAEF, bool NLBBGLJIAKC, [Out] int IAFAONPONEH, [Out] int BMGPDLLDEPH, [Out] bool PKPFFJKCIIA);
	}

	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[CompilerGenerated]
	private sealed class HGBEIJIIDMO
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
		[Cpp2IlInjected.Address(RVA = "0x7CE160", Offset = "0x7CD160", VA = "0x1807CE160")]
		public HGBEIJIIDMO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x62CAF70", Offset = "0x62C9F70", VA = "0x1862CAF70")]
		internal void JGDGJHKOJHL(NativeArray<byte> outputTextureBytes)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[CompilerGenerated]
	private struct LKAFGBFHNEO : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x62CBEF0", Offset = "0x62CAEF0", VA = "0x1862CBEF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x62CC110", Offset = "0x62CB110", VA = "0x1862CC110", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[CompilerGenerated]
	private sealed class BOCIHJBLCLA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public Action<NativeArray<byte>> compressionAction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public NativeArray<byte> outputTextureBytes;

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x7CE160", Offset = "0x7CD160", VA = "0x1807CE160")]
		public BOCIHJBLCLA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x62CAAA0", Offset = "0x62C9AA0", VA = "0x1862CAAA0")]
		internal void FAABNAKNNIL()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	[CompilerGenerated]
	private struct IGIOFKBHHII : IAsyncStateMachine
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
		private BOCIHJBLCLA <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private Texture2D <outputTexture>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x62CB740", Offset = "0x62CA740", VA = "0x1862CB740", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x62CBE00", Offset = "0x62CAE00", VA = "0x1862CBE00", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private static readonly bool MGECNBEDNEB;

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x808C00", Offset = "0x807C00", VA = "0x180808C00")]
	public static bool BALBLIINIGF(byte[] AABLJOEKOBE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x62CC2D0", Offset = "0x62CB2D0", VA = "0x1862CC2D0")]
	[AsyncStateMachine(typeof(LKAFGBFHNEO))]
	public static Task<Texture2D> HIBKDNPOPDI(byte[] AABLJOEKOBE, bool KLNJMGOPKBH = false, bool HBNOAPEDJDG = false, [Optional] CancellationToken GHLJDIEPICD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x62CC180", Offset = "0x62CB180", VA = "0x1862CC180")]
	[AsyncStateMachine(typeof(IGIOFKBHHII))]
	private static Task<Texture2D> FBIDLHHNGHB(int IAFAONPONEH, int BMGPDLLDEPH, bool MGACHGLFINF, bool KLNJMGOPKBH, bool HBNOAPEDJDG, Action<NativeArray<byte>> IFPJEJHNHIJ, CancellationToken GHLJDIEPICD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x62CC410", Offset = "0x62CB410", VA = "0x1862CC410")]
	private static TextureFormat LAMBGKKEDHO(bool MGACHGLFINF)
	{
		return default(TextureFormat);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
internal enum FFLHEHKHOOB
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
internal static class IAIEPBNFGHJ
{
	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x62CB240", Offset = "0x62CA240", VA = "0x1862CB240")]
	public static void HNMIENNKOHH(byte[] GPKMLHOONCL, [Out] int IAFAONPONEH, [Out] int BMGPDLLDEPH, [Out] FFLHEHKHOOB GCJDIJFGBBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x62CB110", Offset = "0x62CA110", VA = "0x1862CB110")]
	private static uint AFDJMPCFGLM(byte[] GPKMLHOONCL, int GGOAAGPAMNC)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x62CB540", Offset = "0x62CA540", VA = "0x1862CB540")]
	private static ulong LJEAJAFILHD(byte[] GPKMLHOONCL, int GGOAAGPAMNC)
	{
		return default(ulong);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public static class BCABEBIEAKE
{
	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x62CA8A0", Offset = "0x62C98A0", VA = "0x1862CA8A0")]
	public static RenderTexture AGELBBGNPHO(int IAFAONPONEH, int BMGPDLLDEPH, int AAAOJHPKGKF, Camera IGCKGGJPBHM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x62CAA40", Offset = "0x62C9A40", VA = "0x1862CAA40")]
	public static void DBEEMLMKCHH(RenderTexture EFKHKEJGEIG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public sealed class KKGNHHCCIFN<TImageId> : IDisposable where TImageId : notnull, IEquatable<TImageId>
{
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	private readonly struct LFMBDJBENKA : IEquatable<LFMBDJBENKA>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public readonly TImageId CDCBJCJHLLG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public readonly BLIOPMAIGDO OKIEEKGFLKH;

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x387F510", Offset = "0x387E510", VA = "0x18387F510")]
		public LFMBDJBENKA(TImageId OHNEPKBBADL, BLIOPMAIGDO DFCDIGJEEKD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x3E29720", Offset = "0x3E28720", VA = "0x183E29720", Slot = "4")]
		public bool Equals(KKGNHHCCIFN<TImageId>.LFMBDJBENKA JNHFAFOIKEO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x3E29610", Offset = "0x3E28610", VA = "0x183E29610", Slot = "0")]
		public override bool Equals(object KDEEPMDJGFD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x3E29990", Offset = "0x3E28990", VA = "0x183E29990", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x3E29B20", Offset = "0x3E28B20", VA = "0x183E29B20", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[CompilerGenerated]
	private sealed class OCHKECCGIAP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public IDLDPOIKMNH<Task<Texture2D>> innerDisposableTask;

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x7CE160", Offset = "0x7CD160", VA = "0x1807CE160")]
		public OCHKECCGIAP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x419C8A0", Offset = "0x419B8A0", VA = "0x18419C8A0")]
		internal void JMBJIFLKOCA()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[CompilerGenerated]
	private struct BANGPONJOGP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public AsyncTaskMethodBuilder<Texture2D> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		public LFMBDJBENKA cacheKey;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public KKGNHHCCIFN<TImageId> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		private TImageId <imageId>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		private BLIOPMAIGDO <textureLoadOptions>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		private TaskAwaiter<byte[]> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		private TaskAwaiter<Texture2D> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x48DBD00", Offset = "0x48DAD00", VA = "0x1848DBD00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x48DC390", Offset = "0x48DB390", VA = "0x1848DC390", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[CompilerGenerated]
	private struct IHCBKMFHNDN : IAsyncStateMachine
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
		public BLIOPMAIGDO textureLoadOptions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public byte[] imageBytes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public KKGNHHCCIFN<TImageId> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		private bool <generateMipMaps>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		private bool <makeTextureReadable>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		private TaskAwaiter<Texture2D> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x3AFBE90", Offset = "0x3AFAE90", VA = "0x183AFBE90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x3AFCC00", Offset = "0x3AFBC00", VA = "0x183AFCC00", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[CompilerGenerated]
	private struct IHPGMIEDBDG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		public IDisposable disposable;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x3AFD900", Offset = "0x3AFC900", VA = "0x183AFD900", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x3AFDD20", Offset = "0x3AFCD20", VA = "0x183AFDD20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private const int CCAPFCCANFN = 1;

	[Cpp2IlInjected.Token(Token = "0x4000052")]
	private static readonly SemaphoreSlim AEKPCECKCNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	private readonly Func<TImageId, CancellationToken, Task<byte[]>>? JLAJIFCICBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	private readonly Func<TImageId, BLIOPMAIGDO, CancellationToken, Task<Texture2D>>? MBLPLPFLFDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	private readonly Func<TImageId, string>? OMFNEPBHKKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	private readonly JDGBBLNCKLH<LFMBDJBENKA, Texture2D> MICADBJILCC;

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x3D96F00", Offset = "0x3D95F00", VA = "0x183D96F00")]
	public KKGNHHCCIFN(Func<TImageId, CancellationToken, Task<byte[]>> OBDMGDLJLMB, [Optional] Func<TImageId, string>? KJMLPEJMIDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x3D970C0", Offset = "0x3D960C0", VA = "0x183D970C0")]
	public KKGNHHCCIFN(Func<TImageId, BLIOPMAIGDO, CancellationToken, Task<Texture2D>> EFGNENDOOFI, [Optional] Func<TImageId, string>? KJMLPEJMIDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x3D96F30", Offset = "0x3D95F30", VA = "0x183D96F30")]
	private KKGNHHCCIFN(Func<TImageId, CancellationToken, Task<byte[]>>? OBDMGDLJLMB, Func<TImageId, BLIOPMAIGDO, CancellationToken, Task<Texture2D>>? EFGNENDOOFI, Func<TImageId, string>? KJMLPEJMIDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x3D96370", Offset = "0x3D95370", VA = "0x183D96370")]
	public DBHPMDCPDMB<Texture2D> COHCDBGGCNH(TImageId MMNNMJKOPKN, BLIOPMAIGDO GEHFHEALBPG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x3D968C0", Offset = "0x3D958C0", VA = "0x183D968C0")]
	public void KCMKJICGNGC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x3D96560", Offset = "0x3D95560", VA = "0x183D96560", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x3D96600", Offset = "0x3D95600", VA = "0x183D96600")]
	[AsyncStateMachine(typeof(KKGNHHCCIFN<>.BANGPONJOGP))]
	private Task<Texture2D> HCOAGNNLOGC(LFMBDJBENKA IMFAKCHHMPL, CancellationToken GHLJDIEPICD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x3D96A50", Offset = "0x3D95A50", VA = "0x183D96A50")]
	[AsyncStateMachine(typeof(KKGNHHCCIFN<>.IHCBKMFHNDN))]
	private Task<Texture2D> NNKNJIDJPEB(byte[] AABLJOEKOBE, BLIOPMAIGDO GEHFHEALBPG, CancellationToken GHLJDIEPICD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x3D968B0", Offset = "0x3D958B0", VA = "0x183D968B0")]
	private void KBGMNBPJCMD(Texture2D JLEFELGPFPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x3D95F70", Offset = "0x3D94F70", VA = "0x183D95F70")]
	private bool BBKHKBMKFKI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x3D95F80", Offset = "0x3D94F80", VA = "0x183D95F80")]
	[AsyncStateMachine(typeof(KKGNHHCCIFN<>.IHPGMIEDBDG))]
	[CompilerGenerated]
	internal static Task CKOIKAJDMCN(IDisposable IJPJHOCHPMB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
[Flags]
public enum BLIOPMAIGDO : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	Default = 0,
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	NoMipMaps = 1,
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	MakeTextureReadable = 2,
	[Cpp2IlInjected.Token(Token = "0x4000075")]
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
