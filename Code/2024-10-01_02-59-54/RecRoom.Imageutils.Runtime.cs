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
		[Cpp2IlInjected.Address(RVA = "0x8D4B40", Offset = "0x8D3F40", VA = "0x1808D4B40")]
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
		[Cpp2IlInjected.Address(RVA = "0x6E0DFE0", Offset = "0x6E0D3E0", VA = "0x186E0DFE0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x8D5A40", Offset = "0x8D4E40", VA = "0x1808D5A40")]
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
		[Cpp2IlInjected.Address(RVA = "0x8D5A80", Offset = "0x8D4E80", VA = "0x1808D5A80")]
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
		[Cpp2IlInjected.Address(RVA = "0x6E0BCE0", Offset = "0x6E0B0E0", VA = "0x186E0BCE0")]
		public CubeMapGenerator()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public enum NIKFDFNKIIP
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
public interface CACEEKJFPMO
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	NIKFDFNKIIP MCOIHBABMHA
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool DCEFPMOAPDC(VertexAttributeFormat BJFFNJGHPDD, int LGECJFDMKDK);
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class IEDBHADDPFJ
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
			[Cpp2IlInjected.Address(RVA = "0x6E0E700", Offset = "0x6E0DB00", VA = "0x186E0E700")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x6E0E6F0", Offset = "0x6E0DAF0", VA = "0x186E0E6F0")]
		public Resolution(uint CFANGCOBGCF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0xA74660", Offset = "0xA73A60", VA = "0x180A74660")]
		public Resolution(uint CFANGCOBGCF, uint HHLCHNICLGA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x6E0E600", Offset = "0x6E0DA00", VA = "0x186E0E600")]
		public static Resolution JKMAMNAOLPC(Resolution[] AHOANCKGKEN, Resolution IMHAGKGHIMH, int JCHFNDMJHIM)
		{
			return default(Resolution);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public class OBNICENNGLA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private readonly Resolution EMAMEIJFDKA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private Resolution? NJBCJJBFFIF;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public uint CFANGCOBGCF
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x6E0E1E0", Offset = "0x6E0D5E0", VA = "0x186E0E1E0")]
			get
			{
				return default(uint);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public Resolution LGNIDBGNLIK
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x6E0E1F0", Offset = "0x6E0D5F0", VA = "0x186E0E1F0")]
			get
			{
				return default(Resolution);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x97CE00", Offset = "0x97C200", VA = "0x18097CE00")]
		public OBNICENNGLA(Resolution EMAMEIJFDKA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x6E0E060", Offset = "0x6E0D460", VA = "0x186E0E060")]
		private static Resolution DIMKIECENLH(Resolution NJBCJJBFFIF, NIKFDFNKIIP HGJIIAEHJEI)
		{
			return default(Resolution);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public static class JJKFKADFNFJ
	{
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public static readonly Resolution NPPKAIOOIOC;

		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public static readonly Resolution OJBHKHIBMCO;

		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public static readonly Resolution EKBFILAEFDP;

		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public static readonly Resolution JHCLAAAEAEE;

		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public static readonly Resolution FELIDCNMINM;

		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public static readonly Resolution NIFNAPBDKHG;

		[Cpp2IlInjected.Token(Token = "0x4000016")]
		internal static readonly Resolution[] FBFCDIGGMMH;
	}

	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public static class JNDPKJJEHBG
	{
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public static readonly Resolution OMFKGOEJOBM;

		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public static readonly Resolution FKHLOECKDGA;

		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public static readonly Resolution ODFMLKNNJBP;

		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public static readonly Resolution FLHHEIMLFIC;

		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public static readonly Resolution DEAHEPMEDLH;

		[Cpp2IlInjected.Token(Token = "0x400001C")]
		internal static readonly Resolution[] FBFCDIGGMMH;

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x6E0C980", Offset = "0x6E0BD80", VA = "0x186E0C980")]
		public static Resolution MENGMNFFBEF(uint ODBPFGKPHPK)
		{
			return default(Resolution);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400000B")]
	public static readonly Resolution MPNNCDCDGBK;
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
internal static class KFENEHJFJKM
{
	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x6E0CD30", Offset = "0x6E0C130", VA = "0x186E0CD30")]
	public static bool BABNGKMOILF(byte[] MPMEGOKIEPF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x6E0CD70", Offset = "0x6E0C170", VA = "0x186E0CD70")]
	public static bool EJHPACDAAEH(byte[] MPMEGOKIEPF, [Out] int ODBPFGKPHPK, [Out] int HDEGPKKBOJG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x6E0CF80", Offset = "0x6E0C380", VA = "0x186E0CF80")]
	private static int OHHDBCGJFCJ(byte[] MPMEGOKIEPF, int IHLILPEDKCL, [Out] ushort DOOJJKGALGI)
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
		public enum KILBIKDFMBE : byte
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
		private class JPEFPDOLFED : IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			private string ADANIHOIEKJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			public Texture2D EBPDEDEIAHJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400002C")]
			public KILBIKDFMBE BIIFAAOEPEL;

			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x6E0CCE0", Offset = "0x6E0C0E0", VA = "0x186E0CCE0")]
			public JPEFPDOLFED(string ADANIHOIEKJ)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x4207330", Offset = "0x4206730", VA = "0x184207330")]
			public JPEFPDOLFED(string ADANIHOIEKJ, Texture2D KDKJOONKNHD, KILBIKDFMBE CKOKODDOLAE)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x6E0CCA0", Offset = "0x6E0C0A0", VA = "0x186E0CCA0", Slot = "4")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000011")]
		[CompilerGenerated]
		private sealed class GMJOPODHCEN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400002D")]
			public ManagedTexture <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400002E")]
			public KILBIKDFMBE textureMemory;

			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x8B7800", Offset = "0x8B6C00", VA = "0x1808B7800")]
			public GMJOPODHCEN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x6E0C2F0", Offset = "0x6E0B6F0", VA = "0x186E0C2F0")]
			internal void BPMDPECFLAF()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000012")]
		[CompilerGenerated]
		private sealed class PNLINDMJCBB
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400002F")]
			public int quality;

			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x8B7800", Offset = "0x8B6C00", VA = "0x1808B7800")]
			public PNLINDMJCBB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x6E0E540", Offset = "0x6E0D940", VA = "0x186E0E540")]
			internal HAAINPJLAPA EHDLGLLBPJF(Texture2D t2d)
			{
				return default(HAAINPJLAPA);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000014")]
		[CompilerGenerated]
		private sealed class PNOOKGIIEPB
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000032")]
			public RenderTexture tempRenderTexture;

			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x8B7800", Offset = "0x8B6C00", VA = "0x1808B7800")]
			public PNOOKGIIEPB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x6E0E580", Offset = "0x6E0D980", VA = "0x186E0E580")]
			internal void IGGHBECDEGN()
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
		private MIJNEIJMPHL<Texture2D> _cpuSidePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private JPEFPDOLFED _memTexture;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private MIJNEIJMPHL<HAAINPJLAPA> _jpgEncodePromise;

		[Cpp2IlInjected.Token(Token = "0x4000023")]
		public const int DEFAULT_JPG_QUALITY = 80;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private MIJNEIJMPHL<HAAINPJLAPA> _pngEncodePromise;

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public bool UsePalette
		{
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x918830", Offset = "0x917C30", VA = "0x180918830")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public RenderTexture LastRenderTexture
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x8AA330", Offset = "0x8A9730", VA = "0x1808AA330")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x8AA350", Offset = "0x8A9750", VA = "0x1808AA350")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		private JPEFPDOLFED memoryTexture
		{
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x6E0DF30", Offset = "0x6E0D330", VA = "0x186E0DF30")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x6E0DE60", Offset = "0x6E0D260", VA = "0x186E0DE60")]
		public ManagedTexture(string ADANIHOIEKJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x6E0DEC0", Offset = "0x6E0D2C0", VA = "0x186E0DEC0")]
		public ManagedTexture(string ADANIHOIEKJ, bool OICPKLEBAOC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x6E0D100", Offset = "0x6E0C500", VA = "0x186E0D100")]
		public void GOAFAIGFFLO(RenderTexture KFJIEAHMGBG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x6E0DB10", Offset = "0x6E0CF10", VA = "0x186E0DB10")]
		public MIJNEIJMPHL<Texture2D> JGGONDMDMMC(KILBIKDFMBE CKOKODDOLAE, bool BENOBHEMNEG = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x6E0D980", Offset = "0x6E0CD80", VA = "0x186E0D980")]
		public MIJNEIJMPHL<HAAINPJLAPA> IHDLGPAFOBP(bool BENOBHEMNEG = false, int CDOJMKLGBKB = 80)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x6E0D140", Offset = "0x6E0C540", VA = "0x186E0D140")]
		public MIJNEIJMPHL<HAAINPJLAPA> HCNKANOCBGM(bool BENOBHEMNEG = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x6E0D430", Offset = "0x6E0C830", VA = "0x186E0D430")]
		private static MIJNEIJMPHL<Texture2D> HHOHOJMJODF(string ADANIHOIEKJ, RenderTexture KFJIEAHMGBG, Texture2D KOGGMJHEMJN, bool BENOBHEMNEG, KILBIKDFMBE EMNCIELHGPH = KILBIKDFMBE.GPU)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x6E0D050", Offset = "0x6E0C450", VA = "0x186E0D050")]
		public void DJMOOGDMDML()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x6E0D0F0", Offset = "0x6E0C4F0", VA = "0x186E0D0F0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x6E0DE00", Offset = "0x6E0D200", VA = "0x186E0DE00")]
		[CompilerGenerated]
		private MIJNEIJMPHL<byte[]> KCCGPLINNKE(Texture2D HPMHBLEMOFI)
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public static class FAHDEDILDMF
{
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	private struct AOPPEEFIHJP
	{
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x6E0AC90", Offset = "0x6E0A090", VA = "0x186E0AC90")]
		public unsafe static extern void JKEEEBAJFME(void* IJJGGEHNLJH, void* EDLJDADHMAM, bool LGBMGJKPOPJ, bool MALFMMCOAGN, bool FHIBCAIEMNB, [Out] int ODBPFGKPHPK, [Out] int HDEGPKKBOJG, [Out] bool HJDKHKDBOHK);
	}

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[CompilerGenerated]
	private sealed class BFLJKBHKLJO
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
		[Cpp2IlInjected.Address(RVA = "0x8B7800", Offset = "0x8B6C00", VA = "0x1808B7800")]
		public BFLJKBHKLJO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x6E0AD90", Offset = "0x6E0A190", VA = "0x186E0AD90")]
		internal void AINDNOOJCKG(NativeArray<byte> outputTextureBytes)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[CompilerGenerated]
	private struct DJEIFKHAAKL : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x6E0BD00", Offset = "0x6E0B100", VA = "0x186E0BD00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x6E0BF20", Offset = "0x6E0B320", VA = "0x186E0BF20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000019")]
	[CompilerGenerated]
	private sealed class KLIDKMCCDNP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public Action<NativeArray<byte>> compressionAction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public NativeArray<byte> outputTextureBytes;

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x8B7800", Offset = "0x8B6C00", VA = "0x1808B7800")]
		public KLIDKMCCDNP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x6E0D010", Offset = "0x6E0C410", VA = "0x186E0D010")]
		internal void BGENJCLIPNE()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	[CompilerGenerated]
	private struct CFANFLHDDEN : IAsyncStateMachine
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
		private KLIDKMCCDNP <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private Texture2D <outputTexture>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x6E0B5B0", Offset = "0x6E0A9B0", VA = "0x186E0B5B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x6E0BC70", Offset = "0x6E0B070", VA = "0x186E0BC70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private static readonly bool JNPMBHHCKED;

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x8F3EB0", Offset = "0x8F32B0", VA = "0x1808F3EB0")]
	public static bool OHHDPECOBPM(byte[] BOKCPBKMELG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x6E0C170", Offset = "0x6E0B570", VA = "0x186E0C170")]
	[AsyncStateMachine(typeof(DJEIFKHAAKL))]
	public static Task<Texture2D> MKEKDDOEJOB(byte[] BOKCPBKMELG, bool EBINBKIGPNH = false, bool PHHFGBPPBJH = false, [Optional] CancellationToken EEHACKMODLA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x6E0C020", Offset = "0x6E0B420", VA = "0x186E0C020")]
	[AsyncStateMachine(typeof(CFANFLHDDEN))]
	private static Task<Texture2D> IJNCLILKBFN(int ODBPFGKPHPK, int HDEGPKKBOJG, bool CHODMJPHLFH, bool EBINBKIGPNH, bool PHHFGBPPBJH, Action<NativeArray<byte>> NDGCIMGHJPC, CancellationToken EEHACKMODLA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x6E0BF90", Offset = "0x6E0B390", VA = "0x186E0BF90")]
	private static TextureFormat HIEAFBEKFGC(bool CHODMJPHLFH)
	{
		return default(TextureFormat);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
internal enum HNHGPHMPFKD
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
internal static class BHGALAHIKDB
{
	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x6E0B370", Offset = "0x6E0A770", VA = "0x186E0B370")]
	public static bool IOHKPCKECAF(byte[] MPMEGOKIEPF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x6E0B060", Offset = "0x6E0A460", VA = "0x186E0B060")]
	public static void GKGELJNPGPM(byte[] MPMEGOKIEPF, [Out] int ODBPFGKPHPK, [Out] int HDEGPKKBOJG, [Out] HNHGPHMPFKD BJFFNJGHPDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x6E0AF30", Offset = "0x6E0A330", VA = "0x186E0AF30")]
	private static uint AHOKLCKNIEP(byte[] MPMEGOKIEPF, int AKMLIMIBFHO)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x6E0B3B0", Offset = "0x6E0A7B0", VA = "0x186E0B3B0")]
	private static ulong OJFNEHCPGDK(byte[] MPMEGOKIEPF, int AKMLIMIBFHO)
	{
		return default(ulong);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public static class HGHPMENABFF
{
	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x6E0C390", Offset = "0x6E0B790", VA = "0x186E0C390")]
	public static RenderTexture ICMNNHELDLG(int ODBPFGKPHPK, int HDEGPKKBOJG, int POIIDMGHBLO, Camera HOFAFOENMKG, RenderTextureMemoryless LLIIIFIGCCM = RenderTextureMemoryless.None)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x6E0C330", Offset = "0x6E0B730", VA = "0x186E0C330")]
	public static void CGAPBMBCBNK(RenderTexture KFJIEAHMGBG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public sealed class MDHJDHDDDBG<TImageId> : IDisposable where TImageId : notnull, IEquatable<TImageId>
{
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	private readonly struct FBKGJJBBPIL : IEquatable<FBKGJJBBPIL>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public readonly TImageId EENFEPHPBDE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public readonly LPEFFIFDMBH PLKIGBLLMLI;

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x3EE9040", Offset = "0x3EE8440", VA = "0x183EE9040")]
		public FBKGJJBBPIL(TImageId GMJINMLEEAC, LPEFFIFDMBH PAOCHLJLMOG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x3EE8A30", Offset = "0x3EE7E30", VA = "0x183EE8A30", Slot = "4")]
		public bool Equals(MDHJDHDDDBG<TImageId>.FBKGJJBBPIL OCKBFCIKBEN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x3EE88B0", Offset = "0x3EE7CB0", VA = "0x183EE88B0", Slot = "0")]
		public override bool Equals(object PBAACPJGKNP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x3EE8CF0", Offset = "0x3EE80F0", VA = "0x183EE8CF0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x3EE8EB0", Offset = "0x3EE82B0", VA = "0x183EE8EB0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[CompilerGenerated]
	private sealed class IHNCGPAAPHG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public CCELPPEDKLE<Task<Texture2D>> innerDisposableTask;

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x8B7800", Offset = "0x8B6C00", VA = "0x1808B7800")]
		public IHNCGPAAPHG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x41E6E70", Offset = "0x41E6270", VA = "0x1841E6E70")]
		internal void LOBCIOAMNBP()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[CompilerGenerated]
	private struct OKPCFNEDJGL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public AsyncTaskMethodBuilder<Texture2D> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		public FBKGJJBBPIL cacheKey;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public MDHJDHDDDBG<TImageId> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		private TImageId <imageId>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		private LPEFFIFDMBH <textureLoadOptions>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		private TaskAwaiter<byte[]> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		private TaskAwaiter<Texture2D> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x4AA4360", Offset = "0x4AA3760", VA = "0x184AA4360", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x4AA4A50", Offset = "0x4AA3E50", VA = "0x184AA4A50", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[CompilerGenerated]
	private struct PAFAEGFNEGI : IAsyncStateMachine
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
		public LPEFFIFDMBH textureLoadOptions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public byte[] imageBytes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public MDHJDHDDDBG<TImageId> <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x4B47220", Offset = "0x4B46620", VA = "0x184B47220", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x4B47930", Offset = "0x4B46D30", VA = "0x184B47930", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	[CompilerGenerated]
	private struct HEPAKHFAMOK : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x40861F0", Offset = "0x40855F0", VA = "0x1840861F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x4086430", Offset = "0x4085830", VA = "0x184086430", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private const int JEDPJAGLDFB = 1;

	[Cpp2IlInjected.Token(Token = "0x4000052")]
	private static readonly SemaphoreSlim ICFMDOJBAIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	private readonly Func<TImageId, CancellationToken, Task<byte[]>>? BJOKEDHALFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	private readonly Func<TImageId, LPEFFIFDMBH, CancellationToken, Task<Texture2D>>? MMIPFFMOLGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	private readonly Func<TImageId, string>? CDOGJLOEEIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	private readonly CFHDIMIAJNN<FBKGJJBBPIL, Texture2D> GBOMGAEIONN;

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x48148A0", Offset = "0x4813CA0", VA = "0x1848148A0")]
	public MDHJDHDDDBG(Func<TImageId, CancellationToken, Task<byte[]>> BHHFFGMNKIA, [Optional] Func<TImageId, string>? KDPDKNNCBGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x48148F0", Offset = "0x4813CF0", VA = "0x1848148F0")]
	public MDHJDHDDDBG(Func<TImageId, LPEFFIFDMBH, CancellationToken, Task<Texture2D>> MEDHNPPEAFO, [Optional] Func<TImageId, string>? KDPDKNNCBGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x4814B00", Offset = "0x4813F00", VA = "0x184814B00")]
	private MDHJDHDDDBG(Func<TImageId, CancellationToken, Task<byte[]>>? BHHFFGMNKIA, Func<TImageId, LPEFFIFDMBH, CancellationToken, Task<Texture2D>>? MEDHNPPEAFO, Func<TImageId, string>? KDPDKNNCBGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x4814030", Offset = "0x4813430", VA = "0x184814030")]
	public FLIAEPPCPCN<Texture2D> JIPJNCDLAMO(TImageId AMIPOMPPLJL, LPEFFIFDMBH GHOCLMNAEIB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x4813CE0", Offset = "0x48130E0", VA = "0x184813CE0")]
	public void GFHJFDEAGBN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x4813C20", Offset = "0x4813020", VA = "0x184813C20", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x4813970", Offset = "0x4812D70", VA = "0x184813970")]
	[AsyncStateMachine(typeof(MDHJDHDDDBG<>.OKPCFNEDJGL))]
	private Task<Texture2D> DMDLLDFHEHE(FBKGJJBBPIL PBCLNIAADPK, CancellationToken EEHACKMODLA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x4814240", Offset = "0x4813640", VA = "0x184814240")]
	[AsyncStateMachine(typeof(MDHJDHDDDBG<>.PAFAEGFNEGI))]
	private Task<Texture2D> NEKHABNOFFM(byte[] BOKCPBKMELG, LPEFFIFDMBH GHOCLMNAEIB, CancellationToken EEHACKMODLA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x4813DF0", Offset = "0x48131F0", VA = "0x184813DF0")]
	private void JDDCAIGDNCG(Texture2D KDKJOONKNHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x4813CD0", Offset = "0x48130D0", VA = "0x184813CD0")]
	private bool FMPEFADLHLJ()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x4813D40", Offset = "0x4813140", VA = "0x184813D40")]
	private bool GOKEJEIOOKD(byte[] BOKCPBKMELG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x48145F0", Offset = "0x48139F0", VA = "0x1848145F0")]
	[CompilerGenerated]
	[AsyncStateMachine(typeof(MDHJDHDDDBG<>.HEPAKHFAMOK))]
	internal static Task PLDMGGBINDN(IDisposable ADMBCLKILDD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
[Flags]
public enum LPEFFIFDMBH : byte
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
