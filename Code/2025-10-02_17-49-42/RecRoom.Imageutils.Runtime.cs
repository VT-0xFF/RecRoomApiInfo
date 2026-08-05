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
		[Cpp2IlInjected.Address(RVA = "0xAD77F0", Offset = "0xAD61F0", VA = "0x180AD77F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x852DBB0", Offset = "0x852C5B0", VA = "0x18852DBB0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xAD85C0", Offset = "0xAD6FC0", VA = "0x180AD85C0")]
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
		[Cpp2IlInjected.Address(RVA = "0xAD8600", Offset = "0xAD7000", VA = "0x180AD8600")]
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
		[Cpp2IlInjected.Address(RVA = "0x852AB80", Offset = "0x8529580", VA = "0x18852AB80")]
		public CubeMapGenerator()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public static class GHLLMMMOGIL
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
			[Cpp2IlInjected.Address(RVA = "0x852E5F0", Offset = "0x852CFF0", VA = "0x18852E5F0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x852E5E0", Offset = "0x852CFE0", VA = "0x18852E5E0")]
		public Resolution(uint FKPKEFAKAOE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0xECA580", Offset = "0xEC8F80", VA = "0x180ECA580")]
		public Resolution(uint FKPKEFAKAOE, uint KEEMKILMOML)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x852E4F0", Offset = "0x852CEF0", VA = "0x18852E4F0")]
		public static Resolution NDJMDCDHPJB(Resolution[] ALFCEIKBPNG, Resolution AOPHNNINHPL, int COEGKKPLPBO)
		{
			return default(Resolution);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public class AOLDKBCDLFC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private readonly Resolution IABAKNMLDIL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private Resolution? PGKIHJANJGK;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public uint FKPKEFAKAOE
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x852A580", Offset = "0x8528F80", VA = "0x18852A580")]
			get
			{
				return default(uint);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public Resolution DACAJDDGJFE
		{
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x852A590", Offset = "0x8528F90", VA = "0x18852A590")]
			get
			{
				return default(Resolution);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0xF9A070", Offset = "0xF98A70", VA = "0x180F9A070")]
		public AOLDKBCDLFC(Resolution IABAKNMLDIL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x852A400", Offset = "0x8528E00", VA = "0x18852A400")]
		private static Resolution BEKONMDOINH(Resolution PGKIHJANJGK, KHFGFGLIMNE OAPEHKGFLOG)
		{
			return default(Resolution);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public static class OOBMAHCHPNI
	{
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public static readonly Resolution CPGMGJCDGKA;

		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public static readonly Resolution AFIDNMNBJMP;

		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public static readonly Resolution GHEPJJOCNCB;

		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public static readonly Resolution NHKMMCKGEHA;

		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public static readonly Resolution IABBLOKPJJK;

		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public static readonly Resolution CKANJJLDFNE;

		[Cpp2IlInjected.Token(Token = "0x4000010")]
		internal static readonly Resolution[] BIFMJBGGHNL;
	}

	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public static class OBCLNDMIIBH
	{
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public static readonly Resolution CPGMGJCDGKA;

		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public static readonly Resolution AFIDNMNBJMP;

		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public static readonly Resolution GHEPJJOCNCB;

		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public static readonly Resolution NHKMMCKGEHA;

		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public static readonly Resolution IABBLOKPJJK;

		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public static readonly Resolution CKANJJLDFNE;

		[Cpp2IlInjected.Token(Token = "0x4000017")]
		internal static readonly Resolution[] BIFMJBGGHNL;
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public static class FKFEHDGDCMO
	{
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public static readonly Resolution CPGMGJCDGKA;

		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public static readonly Resolution AFIDNMNBJMP;

		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public static readonly Resolution GHEPJJOCNCB;

		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public static readonly Resolution NHKMMCKGEHA;

		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public static readonly Resolution IABBLOKPJJK;

		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public static readonly Resolution CKANJJLDFNE;

		[Cpp2IlInjected.Token(Token = "0x400001E")]
		internal static readonly Resolution[] BIFMJBGGHNL;
	}

	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public static class INDMOGLDADL
	{
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public static readonly Resolution CPGMGJCDGKA;

		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public static readonly Resolution AFIDNMNBJMP;

		[Cpp2IlInjected.Token(Token = "0x4000021")]
		public static readonly Resolution GHEPJJOCNCB;

		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public static readonly Resolution NHKMMCKGEHA;

		[Cpp2IlInjected.Token(Token = "0x4000023")]
		public static readonly Resolution IABBLOKPJJK;

		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public static readonly Resolution CKANJJLDFNE;

		[Cpp2IlInjected.Token(Token = "0x4000025")]
		internal static readonly Resolution[] BIFMJBGGHNL;
	}

	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public static class GKLOMCFAJGD
	{
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public static readonly Resolution ILLIMBHLCLN;

		[Cpp2IlInjected.Token(Token = "0x4000027")]
		public static readonly Resolution PNGHAGEOBDH;

		[Cpp2IlInjected.Token(Token = "0x4000028")]
		public static readonly Resolution APBPPFOFAKG;

		[Cpp2IlInjected.Token(Token = "0x4000029")]
		public static readonly Resolution IEGMIGDPLBJ;

		[Cpp2IlInjected.Token(Token = "0x400002A")]
		public static readonly Resolution LONFJKBAEGL;

		[Cpp2IlInjected.Token(Token = "0x400002B")]
		public static readonly Resolution CPGMGJCDGKA;

		[Cpp2IlInjected.Token(Token = "0x400002C")]
		public static readonly Resolution AFIDNMNBJMP;

		[Cpp2IlInjected.Token(Token = "0x400002D")]
		public static readonly Resolution GHEPJJOCNCB;

		[Cpp2IlInjected.Token(Token = "0x400002E")]
		public static readonly Resolution NHKMMCKGEHA;

		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public static readonly Resolution IABBLOKPJJK;

		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public static readonly Resolution CKANJJLDFNE;

		[Cpp2IlInjected.Token(Token = "0x4000031")]
		internal static readonly Resolution[] BIFMJBGGHNL;

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x852BE40", Offset = "0x852A840", VA = "0x18852BE40")]
		public static Resolution OPFDMLBICOK(uint ANOHMOCFGAJ)
		{
			return default(Resolution);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public static readonly Resolution JPMHOGDOIDM;
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
internal static class PIJFGFDINJE
{
	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x852E2A0", Offset = "0x852CCA0", VA = "0x18852E2A0")]
	public static bool FPOHCELAAOL(byte[] BLPDDGCLNPE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x852E2E0", Offset = "0x852CCE0", VA = "0x18852E2E0")]
	public static bool HMLFKDAJPAK(byte[] BLPDDGCLNPE, [Out] int ANOHMOCFGAJ, [Out] int NJLBPEGOCCN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x852E210", Offset = "0x852CC10", VA = "0x18852E210")]
	private static int DJMLDLBNALN(byte[] BLPDDGCLNPE, int MHADOGLMBLF, [Out] ushort IBANGDJKICJ)
	{
		return default(int);
	}
}
namespace RecRoom.Utils.Image
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public class ManagedTexture : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x2000010")]
		[Flags]
		public enum PPMCPELCJMK : byte
		{
			[Cpp2IlInjected.Token(Token = "0x400003B")]
			None = 0,
			[Cpp2IlInjected.Token(Token = "0x400003C")]
			GPU = 1,
			[Cpp2IlInjected.Token(Token = "0x400003D")]
			System = 2,
			[Cpp2IlInjected.Token(Token = "0x400003E")]
			Both = 3
		}

		[Cpp2IlInjected.Token(Token = "0x2000011")]
		private class JPAHCEMNOGF : IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400003F")]
			private string IELIBBNCJAC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000040")]
			public Texture2D DOODMBFAKHA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000041")]
			public PPMCPELCJMK FLMLEJBOOFK;

			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x852C920", Offset = "0x852B320", VA = "0x18852C920")]
			public JPAHCEMNOGF(string IELIBBNCJAC)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x1D00DE0", Offset = "0x1CFF7E0", VA = "0x181D00DE0")]
			public JPAHCEMNOGF(string IELIBBNCJAC, Texture2D JBOOEIGKOID, PPMCPELCJMK NGJBLHIEGKE)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x852C8E0", Offset = "0x852B2E0", VA = "0x18852C8E0", Slot = "4")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000012")]
		[CompilerGenerated]
		private sealed class FOIAPOLFOGK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000042")]
			public ManagedTexture <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000043")]
			public PPMCPELCJMK textureMemory;

			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
			public FOIAPOLFOGK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x852BC30", Offset = "0x852A630", VA = "0x18852BC30")]
			internal void KIPIBMJLPAJ()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000013")]
		[CompilerGenerated]
		private sealed class AHPDANNPKJG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000044")]
			public int quality;

			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
			public AHPDANNPKJG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x852A2C0", Offset = "0x8528CC0", VA = "0x18852A2C0")]
			internal GEKDGFHNEKG IIPDCGHEBNJ(Texture2D t2d)
			{
				return default(GEKDGFHNEKG);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000015")]
		[CompilerGenerated]
		private sealed class EDLAENDECJO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000047")]
			public RenderTexture tempRenderTexture;

			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
			public EDLAENDECJO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x852B310", Offset = "0x8529D10", VA = "0x18852B310")]
			internal void NCCPCFFHCPI()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		[SerializeField]
		private bool usePalette;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		[SerializeField]
		private string name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private FKFADEBPFBK<Texture2D> _cpuSidePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private JPAHCEMNOGF _memTexture;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private FKFADEBPFBK<GEKDGFHNEKG> _jpgEncodePromise;

		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public const int DEFAULT_JPG_QUALITY = 80;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private FKFADEBPFBK<GEKDGFHNEKG> _pngEncodePromise;

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public bool UsePalette
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0xAFB540", Offset = "0xAF9F40", VA = "0x180AFB540")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public RenderTexture LastRenderTexture
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0xAAE1A0", Offset = "0xAACBA0", VA = "0x180AAE1A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0xAAE130", Offset = "0xAACB30", VA = "0x180AAE130")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		private JPAHCEMNOGF memoryTexture
		{
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x852DB00", Offset = "0x852C500", VA = "0x18852DB00")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x852DA30", Offset = "0x852C430", VA = "0x18852DA30")]
		public ManagedTexture(string IELIBBNCJAC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x852DA90", Offset = "0x852C490", VA = "0x18852DA90")]
		public ManagedTexture(string IELIBBNCJAC, bool IOLINJLIFGF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x852D1A0", Offset = "0x852BBA0", VA = "0x18852D1A0")]
		public void MIOAPAHDANH(RenderTexture FCPOHBIAEDM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x852CE50", Offset = "0x852B850", VA = "0x18852CE50")]
		public FKFADEBPFBK<Texture2D> IPIHFCKKFDP(PPMCPELCJMK NGJBLHIEGKE, bool LEHFBDCPJIJ = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x852CCB0", Offset = "0x852B6B0", VA = "0x18852CCB0")]
		public FKFADEBPFBK<GEKDGFHNEKG> HJAEPOKMBAB(bool LEHFBDCPJIJ = false, int NBBNFNDFODF = 80)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x852D730", Offset = "0x852C130", VA = "0x18852D730")]
		public FKFADEBPFBK<GEKDGFHNEKG> OIDHDHDEPEI(bool LEHFBDCPJIJ = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x852D1E0", Offset = "0x852BBE0", VA = "0x18852D1E0")]
		private static FKFADEBPFBK<Texture2D> NJMEDNLBCIM(string IELIBBNCJAC, RenderTexture FCPOHBIAEDM, Texture2D ELFOJPLKDJO, bool LEHFBDCPJIJ, PPMCPELCJMK FLHOBJPLFGO = PPMCPELCJMK.GPU)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x852CC10", Offset = "0x852B610", VA = "0x18852CC10")]
		public void HEHFHDOAHLJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x852CC00", Offset = "0x852B600", VA = "0x18852CC00", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x852D140", Offset = "0x852BB40", VA = "0x18852D140")]
		[CompilerGenerated]
		private FKFADEBPFBK<byte[]> KOPOIEODDJI(Texture2D HMPINFHNLLC)
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public static class JDKAHLMDIDA
{
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	private struct ALLOMGDOCIP
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x852A300", Offset = "0x8528D00", VA = "0x18852A300")]
		public unsafe static extern void CKLBAIMELFP(void* NJGCJFAJJGH, void* MPGFNEFLINC, bool GBBKMDKFHIB, bool LAFHEAIKLGB, bool PIBDFOIFDMB, [Out] int ANOHMOCFGAJ, [Out] int NJLBPEGOCCN, [Out] bool FCIGHILOMFD);
	}

	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[CompilerGenerated]
	private sealed class OCCBHNGENJP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public byte[] imageBytes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public bool generateMipMaps;

		[Cpp2IlInjected.FieldOffset(Offset = "0x19")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public bool bgr;

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
		public OCCBHNGENJP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x852DE50", Offset = "0x852C850", VA = "0x18852DE50")]
		internal void GAGCBNNNIHD(NativeArray<byte> outputTextureBytes)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	[CompilerGenerated]
	private struct BKBLAKBLCDH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public AsyncTaskMethodBuilder<Texture2D> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public byte[] imageBytes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public bool generateMipMaps;

		[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public bool makeTextureReadable;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		private TaskAwaiter<Texture2D> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x852A8F0", Offset = "0x85292F0", VA = "0x18852A8F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x852AB10", Offset = "0x8529510", VA = "0x18852AB10", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001A")]
	[CompilerGenerated]
	private sealed class DFGAFENPGJK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public Action<NativeArray<byte>> compressionAction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public NativeArray<byte> outputTextureBytes;

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
		public DFGAFENPGJK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x852ABA0", Offset = "0x85295A0", VA = "0x18852ABA0")]
		internal void EKEGIPOECBA()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[CompilerGenerated]
	private struct EDBCGAENECP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public AsyncTaskMethodBuilder<Texture2D> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public Action<NativeArray<byte>> compressionAction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public bool hasAlpha;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		public int width;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public int height;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		public bool generateMipMaps;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3D")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public bool makeTextureReadable;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		private DFGAFENPGJK <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		private Texture2D <outputTexture>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x852ABE0", Offset = "0x85295E0", VA = "0x18852ABE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x852B2A0", Offset = "0x8529CA0", VA = "0x18852B2A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000048")]
	private static readonly bool LCCNHGOIAKN;

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0xAF8250", Offset = "0xAF6C50", VA = "0x180AF8250")]
	public static bool OJNMDLKMEDG(byte[] KGFFECLDIIF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x852C600", Offset = "0x852B000", VA = "0x18852C600")]
	[AsyncStateMachine(typeof(BKBLAKBLCDH))]
	public static Task<Texture2D> NKOGDGENHHP(byte[] KGFFECLDIIF, bool ODEKHDHNPCM = false, bool JNHHBALHHFE = false, [Optional] CancellationToken AHOMALKMHKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x852C740", Offset = "0x852B140", VA = "0x18852C740")]
	[AsyncStateMachine(typeof(EDBCGAENECP))]
	private static Task<Texture2D> OMGLFIBKGDM(int ANOHMOCFGAJ, int NJLBPEGOCCN, bool OHOJJGPKNNE, bool ODEKHDHNPCM, bool JNHHBALHHFE, Action<NativeArray<byte>> LHGOPIHMHFH, CancellationToken AHOMALKMHKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x852C560", Offset = "0x852AF60", VA = "0x18852C560")]
	private static TextureFormat JEJLDJOPGOI(bool OHOJJGPKNNE)
	{
		return default(TextureFormat);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
internal enum GECPEBHGIEI
{
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	RGB,
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	BGR,
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	RGBA,
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	ABGR
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
internal static class FFDCCJFHIDM
{
	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x852B590", Offset = "0x8529F90", VA = "0x18852B590")]
	public static bool KDEALBKIHCJ(byte[] BLPDDGCLNPE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x852B700", Offset = "0x852A100", VA = "0x18852B700")]
	public static void NLLPAPLKJAA(byte[] BLPDDGCLNPE, [Out] int ANOHMOCFGAJ, [Out] int NJLBPEGOCCN, [Out] GECPEBHGIEI JBHFIGLCFLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x852B5D0", Offset = "0x8529FD0", VA = "0x18852B5D0")]
	private static uint LEGFFGDEMBF(byte[] BLPDDGCLNPE, int NPCHJIPLCII)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x852B390", Offset = "0x8529D90", VA = "0x18852B390")]
	private static ulong INDBGHIPJAD(byte[] BLPDDGCLNPE, int NPCHJIPLCII)
	{
		return default(ulong);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public static class KAEJBEADLIM
{
	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x852C9D0", Offset = "0x852B3D0", VA = "0x18852C9D0")]
	public static RenderTexture MLPAJKMJIJI(int ANOHMOCFGAJ, int NJLBPEGOCCN, int LLKOCKJOAFD, Camera GDINMNFHIGJ, RenderTextureMemoryless LAAMLNHFDGO = RenderTextureMemoryless.None)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x852C970", Offset = "0x852B370", VA = "0x18852C970")]
	public static void ECKLEGKDPIN(RenderTexture FCPOHBIAEDM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public sealed class IMOLCFIILMD<TImageId> : IDisposable where TImageId : notnull, IEquatable<TImageId>
{
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	private readonly struct BODJKLPPFIO : IEquatable<BODJKLPPFIO>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public readonly TImageId CMJMGBCLCDC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public readonly HDLCNNNMOCG ACKCPFDIOLH;

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x1B11FE0", Offset = "0x1B109E0", VA = "0x181B11FE0")]
		public BODJKLPPFIO(TImageId HPFHOBCPNEF, HDLCNNNMOCG OPEDEFJIKLN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x6784750", Offset = "0x6783150", VA = "0x186784750", Slot = "4")]
		public bool Equals(IMOLCFIILMD<TImageId>.BODJKLPPFIO GOCNHGEHNFD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x6784450", Offset = "0x6782E50", VA = "0x186784450", Slot = "0")]
		public override bool Equals(object PMNHIPACJLN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x67848D0", Offset = "0x67832D0", VA = "0x1867848D0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x6784990", Offset = "0x6783390", VA = "0x186784990", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[CompilerGenerated]
	private sealed class CADHLGIMAOC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public MDANMGHNNOC<Task<Texture2D>> innerDisposableTask;

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
		public CADHLGIMAOC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x6B2F8D0", Offset = "0x6B2E2D0", VA = "0x186B2F8D0")]
		internal void IHCBFAFPLNC()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[CompilerGenerated]
	private struct FFHFHCAJOCG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		public AsyncTaskMethodBuilder<Texture2D> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public BODJKLPPFIO cacheKey;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		public IMOLCFIILMD<TImageId> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		private TImageId <imageId>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		private HDLCNNNMOCG <textureLoadOptions>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		private TaskAwaiter<byte[]> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		private TaskAwaiter<Texture2D> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x4FE01C0", Offset = "0x4FDEBC0", VA = "0x184FE01C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x4FE0F70", Offset = "0x4FDF970", VA = "0x184FE0F70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	[CompilerGenerated]
	private struct MMIIFCNEAJH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		public AsyncTaskMethodBuilder<Texture2D> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public HDLCNNNMOCG textureLoadOptions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		public byte[] imageBytes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public IMOLCFIILMD<TImageId> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		private bool <generateMipMaps>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		private bool <makeTextureReadable>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		private bool <usePointFiltering>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		private bool <useClampWrapMode>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		private TaskAwaiter<Texture2D> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x59F14D0", Offset = "0x59EFED0", VA = "0x1859F14D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x59F1C20", Offset = "0x59F0620", VA = "0x1859F1C20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[CompilerGenerated]
	private struct OCBNFBBLPGD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		public IDisposable disposable;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x5B99E30", Offset = "0x5B98830", VA = "0x185B99E30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x5B9A250", Offset = "0x5B98C50", VA = "0x185B9A250", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private const int BIDBPHCHPNP = 1;

	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private static readonly SemaphoreSlim OIMHBCDINNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private readonly Func<TImageId, CancellationToken, Task<byte[]>>? DFLOMHIBGCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private readonly Func<TImageId, HDLCNNNMOCG, CancellationToken, Task<Texture2D>>? PLGGKNELHOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private readonly Func<TImageId, string>? BNLDJIHMJHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private readonly GGPPGEPMEPL<BODJKLPPFIO, Texture2D> DHCGDGMNMNK;

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x52F5770", Offset = "0x52F4170", VA = "0x1852F5770")]
	public IMOLCFIILMD(Func<TImageId, CancellationToken, Task<byte[]>> HNFLBLCKDDM, [Optional] Func<TImageId, string>? NLFOHIPKDDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x52F55B0", Offset = "0x52F3FB0", VA = "0x1852F55B0")]
	public IMOLCFIILMD(Func<TImageId, HDLCNNNMOCG, CancellationToken, Task<Texture2D>> MDCPGNAIHOB, [Optional] Func<TImageId, string>? NLFOHIPKDDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x52F57A0", Offset = "0x52F41A0", VA = "0x1852F57A0")]
	private IMOLCFIILMD(Func<TImageId, CancellationToken, Task<byte[]>>? HNFLBLCKDDM, Func<TImageId, HDLCNNNMOCG, CancellationToken, Task<Texture2D>>? MDCPGNAIHOB, Func<TImageId, string>? NLFOHIPKDDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x52F4B70", Offset = "0x52F3570", VA = "0x1852F4B70")]
	public AACADPLMCLK<Texture2D> IPJDHKGAIHO(TImageId BNAPLBAGADO, HDLCNNNMOCG CCBJKLCNFNC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x52F47C0", Offset = "0x52F31C0", VA = "0x1852F47C0")]
	public void FABDHPDGCNB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x52F4730", Offset = "0x52F3130", VA = "0x1852F4730", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x52F5290", Offset = "0x52F3C90", VA = "0x1852F5290")]
	[AsyncStateMachine(typeof(IMOLCFIILMD<>.FFHFHCAJOCG))]
	private Task<Texture2D> NNDNMAIKBCH(BODJKLPPFIO JLGLJMOGAHI, CancellationToken AHOMALKMHKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x52F47F0", Offset = "0x52F31F0", VA = "0x1852F47F0")]
	[AsyncStateMachine(typeof(IMOLCFIILMD<>.MMIIFCNEAJH))]
	private Task<Texture2D> FBMPJFMANEM(byte[] KGFFECLDIIF, HDLCNNNMOCG CCBJKLCNFNC, CancellationToken AHOMALKMHKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x52F4720", Offset = "0x52F3120", VA = "0x1852F4720")]
	private void DFKIHNIHLOO(Texture2D JBOOEIGKOID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x52F4B60", Offset = "0x52F3560", VA = "0x1852F4B60")]
	private bool IIMGJMBCPKG()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x52F4AB0", Offset = "0x52F34B0", VA = "0x1852F4AB0")]
	private bool GEEDCFELKHE(byte[] KGFFECLDIIF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x52F5050", Offset = "0x52F3A50", VA = "0x1852F5050")]
	[AsyncStateMachine(typeof(IMOLCFIILMD<>.OCBNFBBLPGD))]
	[CompilerGenerated]
	internal static Task JEBHDGOGKMA(IDisposable BOOMBPLGJAL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
[Flags]
public enum HDLCNNNMOCG : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	Default = 0,
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	NoMipMaps = 1,
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	MakeTextureReadable = 2,
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	CompressTexture = 4,
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	UseNearestTextureFiltering = 8,
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	UseClampWrapMode = 0x10
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
