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
		[Cpp2IlInjected.Address(RVA = "0x8AE600", Offset = "0x8AD000", VA = "0x1808AE600")]
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
		[Cpp2IlInjected.Address(RVA = "0x6BC89F0", Offset = "0x6BC73F0", VA = "0x186BC89F0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x8AEC90", Offset = "0x8AD690", VA = "0x1808AEC90")]
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
		[Cpp2IlInjected.Address(RVA = "0x8AECD0", Offset = "0x8AD6D0", VA = "0x1808AECD0")]
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
		[Cpp2IlInjected.Address(RVA = "0x6BC6DB0", Offset = "0x6BC57B0", VA = "0x186BC6DB0")]
		public CubeMapGenerator()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public enum PGOCMPMFHNA
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
public interface OFPGGHGKMMH
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	PGOCMPMFHNA GODNGLHLBLO
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool LJIMAGFONNI(VertexAttributeFormat CJLNMCEFAGN, int DAIFAFDACHD);
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class FKAJEOHNBFD
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
			[Cpp2IlInjected.Address(RVA = "0x6BC94B0", Offset = "0x6BC7EB0", VA = "0x186BC94B0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x6BC94A0", Offset = "0x6BC7EA0", VA = "0x186BC94A0")]
		public Resolution(uint ICJCFEHCALD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x921970", Offset = "0x920370", VA = "0x180921970")]
		public Resolution(uint ICJCFEHCALD, uint MPEFCGEJLMG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x6BC93B0", Offset = "0x6BC7DB0", VA = "0x186BC93B0")]
		public static Resolution NCBFHFABHGH(Resolution[] IIPNOBBMFOE, Resolution DJKANKELDLP, int ONGAIGHJLHH)
		{
			return default(Resolution);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public class CIGIDFGEEOL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private readonly Resolution NMLHJBCMHPA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private Resolution? KCMAKPKENAM;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public uint ICJCFEHCALD
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x6BC6A50", Offset = "0x6BC5450", VA = "0x186BC6A50")]
			get
			{
				return default(uint);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public Resolution KNNFKELGICC
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x6BC6A60", Offset = "0x6BC5460", VA = "0x186BC6A60")]
			get
			{
				return default(Resolution);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x1EB2BB0", Offset = "0x1EB15B0", VA = "0x181EB2BB0")]
		public CIGIDFGEEOL(Resolution NMLHJBCMHPA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x6BC68D0", Offset = "0x6BC52D0", VA = "0x186BC68D0")]
		private static Resolution HIPDDKKLOEH(Resolution KCMAKPKENAM, PGOCMPMFHNA HILGNLGIHPN)
		{
			return default(Resolution);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public static class NLDFHPIEGFA
	{
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public static readonly Resolution OPKNMGFJLLD;

		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public static readonly Resolution NPBBEHKOPHC;

		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public static readonly Resolution JFODBNDNDOM;

		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public static readonly Resolution DCEHMDCPOID;

		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public static readonly Resolution NNDAKAJKKIM;

		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public static readonly Resolution DKMJENMECOC;

		[Cpp2IlInjected.Token(Token = "0x4000016")]
		internal static readonly Resolution[] NAEDKILIABH;
	}

	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public static class MHJHFLEOCFA
	{
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public static readonly Resolution CDPCKMPFOOJ;

		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public static readonly Resolution NOKAFBFNGCI;

		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public static readonly Resolution ODPLMNOOAFL;

		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public static readonly Resolution BIONANOJKHH;

		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public static readonly Resolution ACNPGFBOCEH;

		[Cpp2IlInjected.Token(Token = "0x400001C")]
		internal static readonly Resolution[] NAEDKILIABH;

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x6BC7550", Offset = "0x6BC5F50", VA = "0x186BC7550")]
		public static Resolution HIFKCOBGHAB(uint PBCKEPEIHHM)
		{
			return default(Resolution);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400000B")]
	public static readonly Resolution CEMPKGLGDFI;
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
internal static class CENFAEOBLCF
{
	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x6BC6680", Offset = "0x6BC5080", VA = "0x186BC6680")]
	public static bool JBGLGOAGPOK(byte[] OIGMDCDEKEG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x6BC66C0", Offset = "0x6BC50C0", VA = "0x186BC66C0")]
	public static bool LPPEIDPJGBE(byte[] OIGMDCDEKEG, [Out] int PBCKEPEIHHM, [Out] int NAEEKHAHIML)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x6BC65F0", Offset = "0x6BC4FF0", VA = "0x186BC65F0")]
	private static int EHHCAOKFIMD(byte[] OIGMDCDEKEG, int GLCOHEPGOCK, [Out] ushort FMLILKPMMBJ)
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
		public enum DABMHFCLCCA : byte
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
		private class JMMPFHANFMB : IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			private string HBOONHFLONJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			public Texture2D IGLHHDIKCOD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400002C")]
			public DABMHFCLCCA FBIHIDFKMJK;

			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x6BC7380", Offset = "0x6BC5D80", VA = "0x186BC7380")]
			public JMMPFHANFMB(string HBOONHFLONJ)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x399AAD0", Offset = "0x39994D0", VA = "0x18399AAD0")]
			public JMMPFHANFMB(string HBOONHFLONJ, Texture2D GOIIACIDIEH, DABMHFCLCCA DDCJEMHBEBJ)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x6BC7340", Offset = "0x6BC5D40", VA = "0x186BC7340", Slot = "4")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000011")]
		[CompilerGenerated]
		private sealed class HKLGKFGIAGL
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400002D")]
			public ManagedTexture <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400002E")]
			public DABMHFCLCCA textureMemory;

			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x883870", Offset = "0x882270", VA = "0x180883870")]
			public HKLGKFGIAGL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x6BC7300", Offset = "0x6BC5D00", VA = "0x186BC7300")]
			internal void KJGJACMGHCE()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000012")]
		[CompilerGenerated]
		private sealed class OOMMKHBMLBA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400002F")]
			public int quality;

			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x883870", Offset = "0x882270", VA = "0x180883870")]
			public OOMMKHBMLBA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x6BC9370", Offset = "0x6BC7D70", VA = "0x186BC9370")]
			internal KOMLEKOBAHG EKECLAMDBCI(Texture2D t2d)
			{
				return default(KOMLEKOBAHG);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000014")]
		[CompilerGenerated]
		private sealed class LJLBHMLEEFL
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000032")]
			public RenderTexture tempRenderTexture;

			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x883870", Offset = "0x882270", VA = "0x180883870")]
			public LJLBHMLEEFL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x6BC73D0", Offset = "0x6BC5DD0", VA = "0x186BC73D0")]
			internal void PBAKKMHGMJO()
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
		private CAPIMDIPLHM<Texture2D> _cpuSidePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private JMMPFHANFMB _memTexture;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private CAPIMDIPLHM<KOMLEKOBAHG> _jpgEncodePromise;

		[Cpp2IlInjected.Token(Token = "0x4000023")]
		public const int DEFAULT_JPG_QUALITY = 80;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private CAPIMDIPLHM<KOMLEKOBAHG> _pngEncodePromise;

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public bool UsePalette
		{
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x9F86D0", Offset = "0x9F70D0", VA = "0x1809F86D0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public RenderTexture LastRenderTexture
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x8869A0", Offset = "0x8853A0", VA = "0x1808869A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x885AF0", Offset = "0x8844F0", VA = "0x180885AF0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		private JMMPFHANFMB memoryTexture
		{
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x6BC8750", Offset = "0x6BC7150", VA = "0x186BC8750")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x6BC8680", Offset = "0x6BC7080", VA = "0x186BC8680")]
		public ManagedTexture(string HBOONHFLONJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x6BC86E0", Offset = "0x6BC70E0", VA = "0x186BC86E0")]
		public ManagedTexture(string HBOONHFLONJ, bool HAMKCJLDCHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x6BC7A00", Offset = "0x6BC6400", VA = "0x186BC7A00")]
		public void DLMOHACGDAO(RenderTexture NKCIJEBEOAF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x6BC8390", Offset = "0x6BC6D90", VA = "0x186BC8390")]
		public CAPIMDIPLHM<Texture2D> MCMMJLNODIO(DABMHFCLCCA DDCJEMHBEBJ, bool DKOFDCDFGDP = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x6BC7870", Offset = "0x6BC6270", VA = "0x186BC7870")]
		public CAPIMDIPLHM<KOMLEKOBAHG> CKNJNOBCCLJ(bool DKOFDCDFGDP = false, int FCPJNKHFFBN = 80)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x6BC7A50", Offset = "0x6BC6450", VA = "0x186BC7A50")]
		public CAPIMDIPLHM<KOMLEKOBAHG> ECNFIFEEBNG(bool DKOFDCDFGDP = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x6BC7E40", Offset = "0x6BC6840", VA = "0x186BC7E40")]
		private static CAPIMDIPLHM<Texture2D> FPIPDALHKBC(string HBOONHFLONJ, RenderTexture NKCIJEBEOAF, Texture2D AMMIAKIIFMK, bool DKOFDCDFGDP, DABMHFCLCCA PHIIILPGMPE = DABMHFCLCCA.GPU)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x6BC7DA0", Offset = "0x6BC67A0", VA = "0x186BC7DA0")]
		public void FKIIDCHJJGE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x6BC7A40", Offset = "0x6BC6440", VA = "0x186BC7A40", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x6BC7D40", Offset = "0x6BC6740", VA = "0x186BC7D40")]
		[CompilerGenerated]
		private CAPIMDIPLHM<byte[]> EKHJODEMHAG(Texture2D NBIMDFOICOI)
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public static class FCCIHGIPKGG
{
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	private struct LMDDJCNHINJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x6BC7450", Offset = "0x6BC5E50", VA = "0x186BC7450")]
		public unsafe static extern void FNPFLOBIJDO(void* KODCGLBMACG, void* FHIOPODCIDM, bool BEJGFABLDDO, bool KLLOCELGIMH, bool HGACKMILONM, [Out] int PBCKEPEIHHM, [Out] int NAEEKHAHIML, [Out] bool FHJPFJPFMEM);
	}

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[CompilerGenerated]
	private sealed class ALBNOPDACKL
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
		[Cpp2IlInjected.Address(RVA = "0x883870", Offset = "0x882270", VA = "0x180883870")]
		public ALBNOPDACKL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x6BC5A50", Offset = "0x6BC4450", VA = "0x186BC5A50")]
		internal void BPKIMANOHCJ(NativeArray<byte> outputTextureBytes)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[CompilerGenerated]
	private struct BIHFBGFLPBP : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x6BC5BF0", Offset = "0x6BC45F0", VA = "0x186BC5BF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x6BC5E10", Offset = "0x6BC4810", VA = "0x186BC5E10", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000019")]
	[CompilerGenerated]
	private sealed class BNHBFHKBMNP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public Action<NativeArray<byte>> compressionAction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public NativeArray<byte> outputTextureBytes;

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x883870", Offset = "0x882270", VA = "0x180883870")]
		public BNHBFHKBMNP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x6BC65B0", Offset = "0x6BC4FB0", VA = "0x186BC65B0")]
		internal void JOFIPJNOGJH()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	[CompilerGenerated]
	private struct BKEPDMMLEEA : IAsyncStateMachine
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
		private BNHBFHKBMNP <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private Texture2D <outputTexture>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x6BC5E80", Offset = "0x6BC4880", VA = "0x186BC5E80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x6BC6540", Offset = "0x6BC4F40", VA = "0x186BC6540", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private static readonly bool PELEIDMECFI;

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x8CD1A0", Offset = "0x8CBBA0", VA = "0x1808CD1A0")]
	public static bool ANNGOEILNDE(byte[] LEHELAENBHM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x6BC6FB0", Offset = "0x6BC59B0", VA = "0x186BC6FB0")]
	[AsyncStateMachine(typeof(BIHFBGFLPBP))]
	public static Task<Texture2D> MEAPFMMAGEJ(byte[] LEHELAENBHM, bool HACLCPNNMNO = false, bool FPADOJNNJHB = false, [Optional] CancellationToken OGJIGALEPCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x6BC6DD0", Offset = "0x6BC57D0", VA = "0x186BC6DD0")]
	[AsyncStateMachine(typeof(BKEPDMMLEEA))]
	private static Task<Texture2D> BFGABAJGNBF(int PBCKEPEIHHM, int NAEEKHAHIML, bool IPJOKEBEGJJ, bool HACLCPNNMNO, bool FPADOJNNJHB, Action<NativeArray<byte>> MBDMJHOADLO, CancellationToken OGJIGALEPCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x6BC6F20", Offset = "0x6BC5920", VA = "0x186BC6F20")]
	private static TextureFormat FLDCFJGIGPG(bool IPJOKEBEGJJ)
	{
		return default(TextureFormat);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
internal enum IKMPPFBDEMD
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
internal static class OMKJNHCKOHG
{
	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x6BC8D00", Offset = "0x6BC7700", VA = "0x186BC8D00")]
	public static bool EGBICCFFGEE(byte[] OIGMDCDEKEG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x6BC8D40", Offset = "0x6BC7740", VA = "0x186BC8D40")]
	public static void FCNHHPLCAPO(byte[] OIGMDCDEKEG, [Out] int PBCKEPEIHHM, [Out] int NAEEKHAHIML, [Out] IKMPPFBDEMD CJLNMCEFAGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x6BC9240", Offset = "0x6BC7C40", VA = "0x186BC9240")]
	private static uint JEFOINCNHIL(byte[] OIGMDCDEKEG, int PJOMFOPGCGL)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x6BC9040", Offset = "0x6BC7A40", VA = "0x186BC9040")]
	private static ulong IOKKLHONGKA(byte[] OIGMDCDEKEG, int PJOMFOPGCGL)
	{
		return default(ulong);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public static class OKLIBIKPKDE
{
	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x6BC8AD0", Offset = "0x6BC74D0", VA = "0x186BC8AD0")]
	public static RenderTexture PGFEPBOOKPN(int PBCKEPEIHHM, int NAEEKHAHIML, int CGONJHCKFHH, Camera DDOBMGBAJJA, RenderTextureMemoryless LKKMBAFOGCP = RenderTextureMemoryless.None)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x6BC8A70", Offset = "0x6BC7470", VA = "0x186BC8A70")]
	public static void BPAIGJJCEII(RenderTexture NKCIJEBEOAF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public sealed class HMKKAOBJBOM<TImageId> : IDisposable where TImageId : notnull, IEquatable<TImageId>
{
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	private readonly struct IOCBIMLBMAH : IEquatable<IOCBIMLBMAH>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public readonly TImageId IGMGCDLNNFK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public readonly OEMGMFEPHIK JCDDNNOGBEG;

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x3972910", Offset = "0x3971310", VA = "0x183972910")]
		public IOCBIMLBMAH(TImageId JODEIIFHAPK, OEMGMFEPHIK GFMBINOFLKM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x402C590", Offset = "0x402AF90", VA = "0x18402C590", Slot = "4")]
		public bool Equals(HMKKAOBJBOM<TImageId>.IOCBIMLBMAH AIPFCMFLDKG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x402C410", Offset = "0x402AE10", VA = "0x18402C410", Slot = "0")]
		public override bool Equals(object GIGIFGONEAO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x402C7C0", Offset = "0x402B1C0", VA = "0x18402C7C0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x402CA50", Offset = "0x402B450", VA = "0x18402CA50", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[CompilerGenerated]
	private sealed class IIFFKHDIDLB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public LMGHFFLKBKA<Task<Texture2D>> innerDisposableTask;

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x883870", Offset = "0x882270", VA = "0x180883870")]
		public IIFFKHDIDLB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x4014960", Offset = "0x4013360", VA = "0x184014960")]
		internal void EIMPLFNCBFF()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[CompilerGenerated]
	private struct FOIGKLILPIE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public AsyncTaskMethodBuilder<Texture2D> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		public IOCBIMLBMAH cacheKey;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public HMKKAOBJBOM<TImageId> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		private TImageId <imageId>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		private OEMGMFEPHIK <textureLoadOptions>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		private TaskAwaiter<byte[]> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		private TaskAwaiter<Texture2D> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x3D6CDB0", Offset = "0x3D6B7B0", VA = "0x183D6CDB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x3D6D4A0", Offset = "0x3D6BEA0", VA = "0x183D6D4A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[CompilerGenerated]
	private struct NFJPNIGPHOH : IAsyncStateMachine
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
		public OEMGMFEPHIK textureLoadOptions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public byte[] imageBytes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public HMKKAOBJBOM<TImageId> <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x46AA9A0", Offset = "0x46A93A0", VA = "0x1846AA9A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x46AB830", Offset = "0x46AA230", VA = "0x1846AB830", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	[CompilerGenerated]
	private struct PLHDPDDFEDP : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x4936980", Offset = "0x4935380", VA = "0x184936980", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x4936B60", Offset = "0x4935560", VA = "0x184936B60", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private const int BOAMLNJLLJK = 1;

	[Cpp2IlInjected.Token(Token = "0x4000052")]
	private static readonly SemaphoreSlim BBINDMIKHNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	private readonly Func<TImageId, CancellationToken, Task<byte[]>>? GEGHELJJCMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	private readonly Func<TImageId, OEMGMFEPHIK, CancellationToken, Task<Texture2D>>? FHIHFKNLAJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	private readonly Func<TImageId, string>? IOMPINHLHFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	private readonly IMDBOMPAFBK<IOCBIMLBMAH, Texture2D> MDHFMKIIIPG;

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x3EF2520", Offset = "0x3EF0F20", VA = "0x183EF2520")]
	public HMKKAOBJBOM(Func<TImageId, CancellationToken, Task<byte[]>> DDILOGLKKMF, [Optional] Func<TImageId, string>? CJGLEBOGFLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x3EF2310", Offset = "0x3EF0D10", VA = "0x183EF2310")]
	public HMKKAOBJBOM(Func<TImageId, OEMGMFEPHIK, CancellationToken, Task<Texture2D>> GKCIIDDHKLL, [Optional] Func<TImageId, string>? CJGLEBOGFLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x3EF2360", Offset = "0x3EF0D60", VA = "0x183EF2360")]
	private HMKKAOBJBOM(Func<TImageId, CancellationToken, Task<byte[]>>? DDILOGLKKMF, Func<TImageId, OEMGMFEPHIK, CancellationToken, Task<Texture2D>>? GKCIIDDHKLL, Func<TImageId, string>? CJGLEBOGFLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x3EF1800", Offset = "0x3EF0200", VA = "0x183EF1800")]
	public FGDPIAEELFA<Texture2D> EFIOCLOBLMI(TImageId NGLDABPGGLH, OEMGMFEPHIK ABCCCJJCPCJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x3EF1C40", Offset = "0x3EF0640", VA = "0x183EF1C40")]
	public void FEPBBOLJLLA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x3EF14A0", Offset = "0x3EEFEA0", VA = "0x183EF14A0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x3EF16A0", Offset = "0x3EF00A0", VA = "0x183EF16A0")]
	[AsyncStateMachine(typeof(HMKKAOBJBOM<>.FOIGKLILPIE))]
	private Task<Texture2D> ECLDIPCMIGN(IOCBIMLBMAH HEKNCDFGAEO, CancellationToken OGJIGALEPCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x3EF1E10", Offset = "0x3EF0810", VA = "0x183EF1E10")]
	[AsyncStateMachine(typeof(HMKKAOBJBOM<>.NFJPNIGPHOH))]
	private Task<Texture2D> PFNLFCOAHDH(byte[] LEHELAENBHM, OEMGMFEPHIK ABCCCJJCPCJ, CancellationToken OGJIGALEPCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x3EF1490", Offset = "0x3EEFE90", VA = "0x183EF1490")]
	private void DCDNIKDJKHP(Texture2D GOIIACIDIEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x3EF1CA0", Offset = "0x3EF06A0", VA = "0x183EF1CA0")]
	private bool KIMAAICOFOL()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x3EF13E0", Offset = "0x3EEFDE0", VA = "0x183EF13E0")]
	private bool BEMCEIIADAI(byte[] LEHELAENBHM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x3EF2060", Offset = "0x3EF0A60", VA = "0x183EF2060")]
	[CompilerGenerated]
	[AsyncStateMachine(typeof(HMKKAOBJBOM<>.PLHDPDDFEDP))]
	internal static Task PLJBLNCGELG(IDisposable PPGIAIPODGI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
[Flags]
public enum OEMGMFEPHIK : byte
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
