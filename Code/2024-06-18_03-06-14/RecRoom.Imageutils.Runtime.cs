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
		[Cpp2IlInjected.Address(RVA = "0x876AF0", Offset = "0x8754F0", VA = "0x180876AF0")]
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
		[Cpp2IlInjected.Address(RVA = "0x68E92F0", Offset = "0x68E7CF0", VA = "0x1868E92F0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x8775C0", Offset = "0x875FC0", VA = "0x1808775C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x877600", Offset = "0x876000", VA = "0x180877600")]
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
		[Cpp2IlInjected.Address(RVA = "0x68E63B0", Offset = "0x68E4DB0", VA = "0x1868E63B0")]
		public CubeMapGenerator()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public enum PFEIKIHAHIL
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
public interface KCPECHAIDDP
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	PFEIKIHAHIL BNAMGPBDCOC
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool HEEFICIOIDM(VertexAttributeFormat PHCNDPLEFBH, int AKNHDNPACDC);
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class ENDGILICLGP
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
			[Cpp2IlInjected.Address(RVA = "0x68E94B0", Offset = "0x68E7EB0", VA = "0x1868E94B0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x68E94A0", Offset = "0x68E7EA0", VA = "0x1868E94A0")]
		public Resolution(uint PHDMOAMCFBE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0xC2A010", Offset = "0xC28A10", VA = "0x180C2A010")]
		public Resolution(uint PHDMOAMCFBE, uint CPHIHAJIIFD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x68E93B0", Offset = "0x68E7DB0", VA = "0x1868E93B0")]
		public static Resolution JIBJAANJGPB(Resolution[] FKJNBGBCACC, Resolution JPKGFIHPPLI, int BIALCCCALFC)
		{
			return default(Resolution);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public class FAPLKFGFGNH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private readonly Resolution POJCBKGHCDO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private Resolution? POJHFJPOBDJ;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public uint PHDMOAMCFBE
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x68E6E40", Offset = "0x68E5840", VA = "0x1868E6E40")]
			get
			{
				return default(uint);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public Resolution CFEKEECBAJC
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x68E6990", Offset = "0x68E5390", VA = "0x1868E6990")]
			get
			{
				return default(Resolution);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x1C39490", Offset = "0x1C37E90", VA = "0x181C39490")]
		public FAPLKFGFGNH(Resolution POJCBKGHCDO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x68E6CC0", Offset = "0x68E56C0", VA = "0x1868E6CC0")]
		private static Resolution IBFAJEKDDFB(Resolution POJHFJPOBDJ, PFEIKIHAHIL GJGJHLMDNEC)
		{
			return default(Resolution);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public static class IIFMGLGDHJO
	{
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public static readonly Resolution PPLLJMIGCOL;

		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public static readonly Resolution DCOBEIMEKDP;

		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public static readonly Resolution GDGKPDDDLEI;

		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public static readonly Resolution ENCGKIEGJCE;

		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public static readonly Resolution BKMCIAKODIF;

		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public static readonly Resolution IGBODKLCFOB;

		[Cpp2IlInjected.Token(Token = "0x4000016")]
		internal static readonly Resolution[] KLBOMPLNMJO;
	}

	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public static class GMAAIEAHMMB
	{
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public static readonly Resolution PJPFMOIKDLA;

		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public static readonly Resolution CLMLMJAIGHJ;

		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public static readonly Resolution FBBDMBGIJJP;

		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public static readonly Resolution OHEIDAMPBLM;

		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public static readonly Resolution IKCPJIGOJND;

		[Cpp2IlInjected.Token(Token = "0x400001C")]
		internal static readonly Resolution[] KLBOMPLNMJO;

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x68E7030", Offset = "0x68E5A30", VA = "0x1868E7030")]
		public static Resolution IMHIBIJJFBC(uint HJMKGIJAPGN)
		{
			return default(Resolution);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400000B")]
	public static readonly Resolution FDHAEKPKKMH;
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
internal static class KKCBEDNNLOH
{
	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x68E7EB0", Offset = "0x68E68B0", VA = "0x1868E7EB0")]
	public static bool LHBGPOFGCNH(byte[] EEOBDBMOHPL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x68E7CA0", Offset = "0x68E66A0", VA = "0x1868E7CA0")]
	public static bool IOEKJECAIEK(byte[] EEOBDBMOHPL, [Out] int HJMKGIJAPGN, [Out] int FGABMENJOIE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x68E7C10", Offset = "0x68E6610", VA = "0x1868E7C10")]
	private static int IKHHDEHMPDI(byte[] EEOBDBMOHPL, int PFNBAEBFNFJ, [Out] ushort GIOPDMAGBFB)
	{
		return default(int);
	}
}
namespace RecRoom.Utils.Image
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public class ManagedTexture : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x200000F")]
		[Flags]
		public enum BJIKGOABPOA : byte
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

		[Cpp2IlInjected.Token(Token = "0x2000010")]
		private class NNOLELJMPMC : IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			private string CCMEKJGADHN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			public Texture2D GGHCKMICHFP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400002C")]
			public BJIKGOABPOA LKBOLDIGFJN;

			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x68E92A0", Offset = "0x68E7CA0", VA = "0x1868E92A0")]
			public NNOLELJMPMC(string CCMEKJGADHN)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x45DE720", Offset = "0x45DD120", VA = "0x1845DE720")]
			public NNOLELJMPMC(string CCMEKJGADHN, Texture2D POMOCFBBJEF, BJIKGOABPOA IGBDBBCPAEN)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x68E9260", Offset = "0x68E7C60", VA = "0x1868E9260", Slot = "4")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000011")]
		[CompilerGenerated]
		private sealed class FLAAABNFDKG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400002D")]
			public ManagedTexture <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400002E")]
			public BJIKGOABPOA textureMemory;

			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x84D150", Offset = "0x84BB50", VA = "0x18084D150")]
			public FLAAABNFDKG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x68E6FF0", Offset = "0x68E59F0", VA = "0x1868E6FF0")]
			internal void EOHEBMIJOAN()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000012")]
		[CompilerGenerated]
		private sealed class PADHKNJHAIP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400002F")]
			public int quality;

			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x84D150", Offset = "0x84BB50", VA = "0x18084D150")]
			public PADHKNJHAIP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x68E9370", Offset = "0x68E7D70", VA = "0x1868E9370")]
			internal ECNILANNLPN OPFMGDCOIHE(Texture2D t2d)
			{
				return default(ECNILANNLPN);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000014")]
		[CompilerGenerated]
		private sealed class DANDGCCFIOO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000032")]
			public RenderTexture tempRenderTexture;

			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x84D150", Offset = "0x84BB50", VA = "0x18084D150")]
			public DANDGCCFIOO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x68E63D0", Offset = "0x68E4DD0", VA = "0x1868E63D0")]
			internal void EAGBFIJJFDG()
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
		private CPAHEHFKIFF<Texture2D> _cpuSidePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private NNOLELJMPMC _memTexture;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private CPAHEHFKIFF<ECNILANNLPN> _jpgEncodePromise;

		[Cpp2IlInjected.Token(Token = "0x4000023")]
		public const int DEFAULT_JPG_QUALITY = 80;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private CPAHEHFKIFF<ECNILANNLPN> _pngEncodePromise;

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public bool UsePalette
		{
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x8A0E90", Offset = "0x89F890", VA = "0x1808A0E90")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public RenderTexture LastRenderTexture
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x850E50", Offset = "0x84F850", VA = "0x180850E50")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x850E40", Offset = "0x84F840", VA = "0x180850E40")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		private NNOLELJMPMC memoryTexture
		{
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x68E91B0", Offset = "0x68E7BB0", VA = "0x1868E91B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x68E90E0", Offset = "0x68E7AE0", VA = "0x1868E90E0")]
		public ManagedTexture(string CCMEKJGADHN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x68E9140", Offset = "0x68E7B40", VA = "0x1868E9140")]
		public ManagedTexture(string CCMEKJGADHN, bool OKGPJEKDLCI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x68E8DB0", Offset = "0x68E77B0", VA = "0x1868E8DB0")]
		public void LOIGADBHGIN(RenderTexture BHMKADLMPID)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x68E8DF0", Offset = "0x68E77F0", VA = "0x1868E8DF0")]
		public CPAHEHFKIFF<Texture2D> LPCEBMELCDO(BJIKGOABPOA IGBDBBCPAEN, bool ANBEAKCNGFM = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x68E8880", Offset = "0x68E7280", VA = "0x1868E8880")]
		public CPAHEHFKIFF<ECNILANNLPN> FJENDBIAFKL(bool ANBEAKCNGFM = false, int DLGDDFECFOC = 80)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x68E8A10", Offset = "0x68E7410", VA = "0x1868E8A10")]
		public CPAHEHFKIFF<ECNILANNLPN> FLKPNLGMLKC(bool ANBEAKCNGFM = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x68E8330", Offset = "0x68E6D30", VA = "0x1868E8330")]
		private static CPAHEHFKIFF<Texture2D> EOMHAGOKJBG(string CCMEKJGADHN, RenderTexture BHMKADLMPID, Texture2D EAEOFJLCIDB, bool ANBEAKCNGFM, BJIKGOABPOA DACLFJFAECP = BJIKGOABPOA.GPU)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x68E8D10", Offset = "0x68E7710", VA = "0x1868E8D10")]
		public void KAFOBLIJAAI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x68E8320", Offset = "0x68E6D20", VA = "0x1868E8320", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x68E82C0", Offset = "0x68E6CC0", VA = "0x1868E82C0")]
		[CompilerGenerated]
		private CPAHEHFKIFF<byte[]> BJHPCNMLLOH(Texture2D MAAIGNDFEON)
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public static class DJMDEFNCEJC
{
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	private struct MKAFEDIFLPI
	{
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x68E7F30", Offset = "0x68E6930", VA = "0x1868E7F30")]
		public unsafe static extern void NCHGKFMJNBA(void* BJCJOBDKJDA, void* JEDBDINPIII, bool NNOBKPLJGKA, bool AIEPPBLNEIJ, bool JDDEAAKNFNG, [Out] int HJMKGIJAPGN, [Out] int FGABMENJOIE, [Out] bool EDHJDALIALJ);
	}

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[CompilerGenerated]
	private sealed class FHEFADAEHFA
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

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x84D150", Offset = "0x84BB50", VA = "0x18084D150")]
		public FHEFADAEHFA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x68E6E50", Offset = "0x68E5850", VA = "0x1868E6E50")]
		internal void LBDMFOPJCKE(NativeArray<byte> outputTextureBytes)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[CompilerGenerated]
	private struct MMFEFJMJCLG : IAsyncStateMachine
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

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x68E8030", Offset = "0x68E6A30", VA = "0x1868E8030", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x68E8250", Offset = "0x68E6C50", VA = "0x1868E8250", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000019")]
	[CompilerGenerated]
	private sealed class LHOHMJAHMKN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public Action<NativeArray<byte>> compressionAction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public NativeArray<byte> outputTextureBytes;

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x84D150", Offset = "0x84BB50", VA = "0x18084D150")]
		public LHOHMJAHMKN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x68E7EF0", Offset = "0x68E68F0", VA = "0x1868E7EF0")]
		internal void KCKJJOLEDDI()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	[CompilerGenerated]
	private struct CLIEGAJMEIC : IAsyncStateMachine
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
		private LHOHMJAHMKN <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private Texture2D <outputTexture>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x68E5C80", Offset = "0x68E4680", VA = "0x1868E5C80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x68E6340", Offset = "0x68E4D40", VA = "0x1868E6340", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private static readonly bool BFDPGAIADJP;

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x894D60", Offset = "0x893760", VA = "0x180894D60")]
	public static bool ADBGDEBNNFM(byte[] JGDCNGBDIGH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x68E6640", Offset = "0x68E5040", VA = "0x1868E6640")]
	[AsyncStateMachine(typeof(MMFEFJMJCLG))]
	public static Task<Texture2D> KNGIIOAOFNJ(byte[] JGDCNGBDIGH, bool PJHKNNIKDCN = false, bool ELMBOFGMFNL = false, [Optional] CancellationToken AOLOJHLCMLE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x68E6450", Offset = "0x68E4E50", VA = "0x1868E6450")]
	[AsyncStateMachine(typeof(CLIEGAJMEIC))]
	private static Task<Texture2D> BICDNICJHFN(int HJMKGIJAPGN, int FGABMENJOIE, bool HNLFJKLMNNL, bool PJHKNNIKDCN, bool ELMBOFGMFNL, Action<NativeArray<byte>> DMBHPOBHIJB, CancellationToken AOLOJHLCMLE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x68E65A0", Offset = "0x68E4FA0", VA = "0x1868E65A0")]
	private static TextureFormat GEILPBHANGG(bool HNLFJKLMNNL)
	{
		return default(TextureFormat);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
internal enum AFAKADMNNMK
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
[Cpp2IlInjected.Token(Token = "0x200001C")]
internal static class HGBPAGHIGCO
{
	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x68E7580", Offset = "0x68E5F80", VA = "0x1868E7580")]
	public static bool HCAGFICLDJC(byte[] EEOBDBMOHPL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x68E75C0", Offset = "0x68E5FC0", VA = "0x1868E75C0")]
	public static void PGCJKPMJGAJ(byte[] EEOBDBMOHPL, [Out] int HJMKGIJAPGN, [Out] int FGABMENJOIE, [Out] AFAKADMNNMK PHCNDPLEFBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x68E78C0", Offset = "0x68E62C0", VA = "0x1868E78C0")]
	private static uint PLMBBCFAKKF(byte[] EEOBDBMOHPL, int BPFHAJJBCKE)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x68E7380", Offset = "0x68E5D80", VA = "0x1868E7380")]
	private static ulong FMDCJPKAGIC(byte[] EEOBDBMOHPL, int BPFHAJJBCKE)
	{
		return default(ulong);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public static class CDDNHJDPACJ
{
	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x68E59F0", Offset = "0x68E43F0", VA = "0x1868E59F0")]
	public static RenderTexture BKEPFKFOIID(int HJMKGIJAPGN, int FGABMENJOIE, int DNFKHDAPLLB, Camera HGOCAPKHKNC, RenderTextureMemoryless CLLJLENAMHI = RenderTextureMemoryless.None)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x68E5C20", Offset = "0x68E4620", VA = "0x1868E5C20")]
	public static void LIEKGADJFJG(RenderTexture BHMKADLMPID)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public sealed class PJLJFBFJHBC<TImageId> : IDisposable where TImageId : notnull, IEquatable<TImageId>
{
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	private readonly struct JCMFNGBELHB : IEquatable<JCMFNGBELHB>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public readonly TImageId IKINGGCNNLG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public readonly LLEBGPPKHKG FPLHODKEOHM;

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x3CF9B90", Offset = "0x3CF8590", VA = "0x183CF9B90")]
		public JCMFNGBELHB(TImageId LDDEKIBHION, LLEBGPPKHKG GJLMBIPKDKL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x404D570", Offset = "0x404BF70", VA = "0x18404D570", Slot = "4")]
		public bool Equals(PJLJFBFJHBC<TImageId>.JCMFNGBELHB HENLEJBGFIE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x404D2E0", Offset = "0x404BCE0", VA = "0x18404D2E0", Slot = "0")]
		public override bool Equals(object GKHPLGCJCPF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x404D7D0", Offset = "0x404C1D0", VA = "0x18404D7D0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x404D970", Offset = "0x404C370", VA = "0x18404D970", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[CompilerGenerated]
	private sealed class AEMNKGIKGFC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public MAGIJMJBHDB<Task<Texture2D>> innerDisposableTask;

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x84D150", Offset = "0x84BB50", VA = "0x18084D150")]
		public AEMNKGIKGFC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x3CD42F0", Offset = "0x3CD2CF0", VA = "0x183CD42F0")]
		internal void KGGIJBFAINJ()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[CompilerGenerated]
	private struct MKCGKIFKPMH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public AsyncTaskMethodBuilder<Texture2D> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		public JCMFNGBELHB cacheKey;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public PJLJFBFJHBC<TImageId> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		private TImageId <imageId>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		private LLEBGPPKHKG <textureLoadOptions>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		private TaskAwaiter<byte[]> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		private TaskAwaiter<Texture2D> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x4478910", Offset = "0x4477310", VA = "0x184478910", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x4479730", Offset = "0x4478130", VA = "0x184479730", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[CompilerGenerated]
	private struct PCOBGCCFENG : IAsyncStateMachine
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
		public LLEBGPPKHKG textureLoadOptions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public byte[] imageBytes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public PJLJFBFJHBC<TImageId> <>4__this;

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

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x46B9F60", Offset = "0x46B8960", VA = "0x1846B9F60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x46BA6D0", Offset = "0x46B90D0", VA = "0x1846BA6D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	[CompilerGenerated]
	private struct BELGPGKBADJ : IAsyncStateMachine
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

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x4DD8D40", Offset = "0x4DD7740", VA = "0x184DD8D40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x4DD9100", Offset = "0x4DD7B00", VA = "0x184DD9100", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private const int CIIJMINPONH = 1;

	[Cpp2IlInjected.Token(Token = "0x4000052")]
	private static readonly SemaphoreSlim DLDLDFELANP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	private readonly Func<TImageId, CancellationToken, Task<byte[]>>? IKLCLJIMFPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	private readonly Func<TImageId, LLEBGPPKHKG, CancellationToken, Task<Texture2D>>? KEMPKOKDCAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	private readonly Func<TImageId, string>? CJCAPJIPALI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	private readonly JHFAOJJKCFJ<JCMFNGBELHB, Texture2D> FOJNBGHCOFH;

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x46DB260", Offset = "0x46D9C60", VA = "0x1846DB260")]
	public PJLJFBFJHBC(Func<TImageId, CancellationToken, Task<byte[]>> GMGGGDMCGLG, [Optional] Func<TImageId, string>? NIMKLIEEIBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x46DB610", Offset = "0x46DA010", VA = "0x1846DB610")]
	public PJLJFBFJHBC(Func<TImageId, LLEBGPPKHKG, CancellationToken, Task<Texture2D>> ICDMAOEOPLL, [Optional] Func<TImageId, string>? NIMKLIEEIBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x46DB2B0", Offset = "0x46D9CB0", VA = "0x1846DB2B0")]
	private PJLJFBFJHBC(Func<TImageId, CancellationToken, Task<byte[]>>? GMGGGDMCGLG, Func<TImageId, LLEBGPPKHKG, CancellationToken, Task<Texture2D>>? ICDMAOEOPLL, Func<TImageId, string>? NIMKLIEEIBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x46DAEB0", Offset = "0x46D98B0", VA = "0x1846DAEB0")]
	public AMHDMMJJKND<Texture2D> PLLMHPCNJKD(TImageId PBAKLOCFNKP, LLEBGPPKHKG EKHMOJCCAAN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x46DAB90", Offset = "0x46D9590", VA = "0x1846DAB90")]
	public void KEMJONDPFKM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x46DA570", Offset = "0x46D8F70", VA = "0x1846DA570", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x46DA8E0", Offset = "0x46D92E0", VA = "0x1846DA8E0")]
	[AsyncStateMachine(typeof(PJLJFBFJHBC<>.MKCGKIFKPMH))]
	private Task<Texture2D> FCIEOGHLKHG(JCMFNGBELHB KEFBHDJBMMG, CancellationToken AOLOJHLCMLE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x46DA780", Offset = "0x46D9180", VA = "0x1846DA780")]
	[AsyncStateMachine(typeof(PJLJFBFJHBC<>.PCOBGCCFENG))]
	private Task<Texture2D> EGAPJMCMJPM(byte[] JGDCNGBDIGH, LLEBGPPKHKG EKHMOJCCAAN, CancellationToken AOLOJHLCMLE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x46DAB80", Offset = "0x46D9580", VA = "0x1846DAB80")]
	private void GGMLNNCFELJ(Texture2D POMOCFBBJEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x46DA560", Offset = "0x46D8F60", VA = "0x1846DA560")]
	private bool CPEDBAPNHFK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x46DABE0", Offset = "0x46D95E0", VA = "0x1846DABE0")]
	private bool MMPKENMJGNC(byte[] JGDCNGBDIGH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x46DA380", Offset = "0x46D8D80", VA = "0x1846DA380")]
	[CompilerGenerated]
	[AsyncStateMachine(typeof(PJLJFBFJHBC<>.BELGPGKBADJ))]
	internal static Task ANJNLJJMOKL(IDisposable IFHCMCNJFFB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
[Flags]
public enum LLEBGPPKHKG : byte
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
