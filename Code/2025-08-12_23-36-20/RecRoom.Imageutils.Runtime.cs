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
		[Cpp2IlInjected.Address(RVA = "0xABED60", Offset = "0xABDB60", VA = "0x180ABED60")]
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
		[Cpp2IlInjected.Address(RVA = "0x83C20F0", Offset = "0x83C0EF0", VA = "0x1883C20F0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xABFA20", Offset = "0xABE820", VA = "0x180ABFA20")]
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
		[Cpp2IlInjected.Address(RVA = "0xABFA60", Offset = "0xABE860", VA = "0x180ABFA60")]
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
		[Cpp2IlInjected.Address(RVA = "0x83BFA00", Offset = "0x83BE800", VA = "0x1883BFA00")]
		public CubeMapGenerator()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public static class LODAIJAFMMK
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
			[Cpp2IlInjected.Address(RVA = "0x83C2890", Offset = "0x83C1690", VA = "0x1883C2890")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x83C2880", Offset = "0x83C1680", VA = "0x1883C2880")]
		public Resolution(uint DBBMOEGPNPP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0xEABD50", Offset = "0xEAAB50", VA = "0x180EABD50")]
		public Resolution(uint DBBMOEGPNPP, uint COFKGIHGCOO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x83C2790", Offset = "0x83C1590", VA = "0x1883C2790")]
		public static Resolution BFNEMLPPEPI(Resolution[] PMEODJMCJOL, Resolution GJOJFGFNJEE, int NKKEFKIPPNM)
		{
			return default(Resolution);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public class OGNDAPFGPMI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private readonly Resolution ACNMBIIDJBP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private Resolution? KJHDMKNJKFG;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public uint DBBMOEGPNPP
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x83C24C0", Offset = "0x83C12C0", VA = "0x1883C24C0")]
			get
			{
				return default(uint);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public Resolution BHDNPFBIAIC
		{
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x83C2170", Offset = "0x83C0F70", VA = "0x1883C2170")]
			get
			{
				return default(Resolution);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0xF6D660", Offset = "0xF6C460", VA = "0x180F6D660")]
		public OGNDAPFGPMI(Resolution ACNMBIIDJBP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x83C24D0", Offset = "0x83C12D0", VA = "0x1883C24D0")]
		private static Resolution IPELOGOPONI(Resolution KJHDMKNJKFG, KFEJAIJJFIK IDBCLOIKBIL)
		{
			return default(Resolution);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public static class MNIBFNBONBH
	{
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public static readonly Resolution KDMFGOEDGNE;

		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public static readonly Resolution EPFFAOCCDOI;

		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public static readonly Resolution JFJPDJAMIMC;

		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public static readonly Resolution POJEGIGHOBD;

		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public static readonly Resolution OCCNLLDKLMJ;

		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public static readonly Resolution OPNFNPKHHOB;

		[Cpp2IlInjected.Token(Token = "0x4000010")]
		internal static readonly Resolution[] MFFKHMJDNIM;
	}

	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public static class MACBJBLDFCP
	{
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public static readonly Resolution OJIEMEDHNMD;

		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public static readonly Resolution MIIHOBAOINC;

		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public static readonly Resolution POACGLOMJNB;

		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public static readonly Resolution DMLNJIALFGF;

		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public static readonly Resolution AAMMAHDEBID;

		[Cpp2IlInjected.Token(Token = "0x4000016")]
		internal static readonly Resolution[] MFFKHMJDNIM;

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x83C0650", Offset = "0x83BF450", VA = "0x1883C0650")]
		public static Resolution PAJOPCDKPBG(uint FIJCBEGFDBD)
		{
			return default(Resolution);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public static readonly Resolution PLHKBIDHLNP;
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
internal static class BKJEEMAAINN
{
	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x83BF730", Offset = "0x83BE530", VA = "0x1883BF730")]
	public static bool OHOFMGECFOG(byte[] KANAIIDGHCH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x83BF490", Offset = "0x83BE290", VA = "0x1883BF490")]
	public static bool DNODDKHLAEC(byte[] KANAIIDGHCH, [Out] int FIJCBEGFDBD, [Out] int HBJICDOMHDE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x83BF6A0", Offset = "0x83BE4A0", VA = "0x1883BF6A0")]
	private static int NCFOGNDOAMC(byte[] KANAIIDGHCH, int DOCKBMMINED, [Out] ushort JPMELPBNPJP)
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
		public enum ECFBNEHCKDK : byte
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
		private class DOCPFCGLDCE : IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000024")]
			private string PFLDDMDPCBI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000025")]
			public Texture2D IKJGNDCECOC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000026")]
			public ECFBNEHCKDK JDDNJHFMFNA;

			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x83BFC80", Offset = "0x83BEA80", VA = "0x1883BFC80")]
			public DOCPFCGLDCE(string PFLDDMDPCBI)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x1C88AF0", Offset = "0x1C878F0", VA = "0x181C88AF0")]
			public DOCPFCGLDCE(string PFLDDMDPCBI, Texture2D JDNNGPGPIOL, ECFBNEHCKDK LCPGEHHHFBP)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x83BFC40", Offset = "0x83BEA40", VA = "0x1883BFC40", Slot = "4")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000F")]
		[CompilerGenerated]
		private sealed class LAFDMOILIKF
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000027")]
			public ManagedTexture <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000028")]
			public ECFBNEHCKDK textureMemory;

			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
			public LAFDMOILIKF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x83C0440", Offset = "0x83BF240", VA = "0x1883C0440")]
			internal void EKEDAOPELDG()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000010")]
		[CompilerGenerated]
		private sealed class GKBGHGFLLOP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000029")]
			public int quality;

			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
			public GKBGHGFLLOP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x83C0400", Offset = "0x83BF200", VA = "0x1883C0400")]
			internal IFMNLAHAINE NJKAAAHACDB(Texture2D t2d)
			{
				return default(IFMNLAHAINE);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000012")]
		[CompilerGenerated]
		private sealed class DDLCJJCIDIA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400002C")]
			public RenderTexture tempRenderTexture;

			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
			public DDLCJJCIDIA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x83BFA20", Offset = "0x83BE820", VA = "0x1883BFA20")]
			internal void GEGEAKDKHCG()
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
		private AIKJELDGMEB<Texture2D> _cpuSidePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private DOCPFCGLDCE _memTexture;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private AIKJELDGMEB<IFMNLAHAINE> _jpgEncodePromise;

		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public const int DEFAULT_JPG_QUALITY = 80;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private AIKJELDGMEB<IFMNLAHAINE> _pngEncodePromise;

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public bool UsePalette
		{
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0xB7BC50", Offset = "0xB7AA50", VA = "0x180B7BC50")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public RenderTexture LastRenderTexture
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0xA94B40", Offset = "0xA93940", VA = "0x180A94B40")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0xA94B50", Offset = "0xA93950", VA = "0x180A94B50")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		private DOCPFCGLDCE memoryTexture
		{
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x83C1CE0", Offset = "0x83C0AE0", VA = "0x1883C1CE0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x83C1C10", Offset = "0x83C0A10", VA = "0x1883C1C10")]
		public ManagedTexture(string PFLDDMDPCBI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x83C1C70", Offset = "0x83C0A70", VA = "0x1883C1C70")]
		public ManagedTexture(string PFLDDMDPCBI, bool JFPIEGKAJHP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x83C1640", Offset = "0x83C0440", VA = "0x1883C1640")]
		public void FGHFNHKKCEA(RenderTexture LLOJDDLPEIM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x83C1780", Offset = "0x83C0580", VA = "0x1883C1780")]
		public AIKJELDGMEB<Texture2D> PHBIGNHGAEK(ECFBNEHCKDK LCPGEHHHFBP, bool HOAACHMPJHA = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x83C1A70", Offset = "0x83C0870", VA = "0x1883C1A70")]
		public AIKJELDGMEB<IFMNLAHAINE> PJFJJJBGNDD(bool HOAACHMPJHA = false, int PHKONMFADLA = 80)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x83C1350", Offset = "0x83C0150", VA = "0x1883C1350")]
		public AIKJELDGMEB<IFMNLAHAINE> EDOANAAILLK(bool HOAACHMPJHA = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x83C0DF0", Offset = "0x83BFBF0", VA = "0x1883C0DF0")]
		private static AIKJELDGMEB<Texture2D> BHHEEEDEKJH(string PFLDDMDPCBI, RenderTexture LLOJDDLPEIM, Texture2D GDJDBCLBDEB, bool HOAACHMPJHA, ECFBNEHCKDK CNLAJIDIBGD = ECFBNEHCKDK.GPU)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x83C16E0", Offset = "0x83C04E0", VA = "0x1883C16E0")]
		public void NCDKAOAIMHF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x83C1340", Offset = "0x83C0140", VA = "0x1883C1340", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x83C1680", Offset = "0x83C0480", VA = "0x1883C1680")]
		[CompilerGenerated]
		private AIKJELDGMEB<byte[]> JGMJKECAJFI(Texture2D OGJNNIGBJMI)
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public static class NGDCCNBBFFG
{
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	private struct PDPNEIHIIBP
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x83C2650", Offset = "0x83C1450", VA = "0x1883C2650")]
		public unsafe static extern void EJIJHBANDFC(void* ALEJFNEJFFJ, void* AGEFPDLPNLM, bool BLLGPLEIPJJ, bool NPPMJNALHLD, bool LPJILGAAJDJ, [Out] int FIJCBEGFDBD, [Out] int HBJICDOMHDE, [Out] bool OAKLDNGJBFE);
	}

	[Cpp2IlInjected.Token(Token = "0x2000015")]
	[CompilerGenerated]
	private sealed class DMFPEMIHCCE
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
		[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
		public DMFPEMIHCCE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x83BFAA0", Offset = "0x83BE8A0", VA = "0x1883BFAA0")]
		internal void LCBGJFKBHNP(NativeArray<byte> outputTextureBytes)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[CompilerGenerated]
	private struct MPNCAJILCFL : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x83C0B60", Offset = "0x83BF960", VA = "0x1883C0B60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x83C0D80", Offset = "0x83BFB80", VA = "0x1883C0D80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[CompilerGenerated]
	private sealed class PPKILCNKPHM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public Action<NativeArray<byte>> compressionAction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public NativeArray<byte> outputTextureBytes;

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
		public PPKILCNKPHM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x83C2750", Offset = "0x83C1550", VA = "0x1883C2750")]
		internal void BPNDGHGKBCP()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[CompilerGenerated]
	private struct EJFBKFMMFPH : IAsyncStateMachine
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
		private PPKILCNKPHM <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		private Texture2D <outputTexture>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x83BFCD0", Offset = "0x83BEAD0", VA = "0x1883BFCD0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x83C0390", Offset = "0x83BF190", VA = "0x1883C0390", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private static readonly bool AFMFFHNGELD;

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0xADF8C0", Offset = "0xADE6C0", VA = "0x180ADF8C0")]
	public static bool JOHEDFINFIN(byte[] IEPAGDFFIPB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x83C1F70", Offset = "0x83C0D70", VA = "0x1883C1F70")]
	[AsyncStateMachine(typeof(MPNCAJILCFL))]
	public static Task<Texture2D> IAJJFOJLGOG(byte[] IEPAGDFFIPB, bool NLADJIKAIGM = false, bool JOGKKDELNII = false, [Optional] CancellationToken BKHGNHANFKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x83C1D90", Offset = "0x83C0B90", VA = "0x1883C1D90")]
	[AsyncStateMachine(typeof(EJFBKFMMFPH))]
	private static Task<Texture2D> AGCLIJIABJC(int FIJCBEGFDBD, int HBJICDOMHDE, bool JBAOPGBLGAA, bool NLADJIKAIGM, bool JOGKKDELNII, Action<NativeArray<byte>> IKLCOHBFFAI, CancellationToken BKHGNHANFKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x83C1EE0", Offset = "0x83C0CE0", VA = "0x1883C1EE0")]
	private static TextureFormat BEAGBGOIEFC(bool JBAOPGBLGAA)
	{
		return default(TextureFormat);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
internal enum JGGACMFKBEI
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
internal static class ABFLGKIDOBD
{
	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x83BF450", Offset = "0x83BE250", VA = "0x1883BF450")]
	public static bool PKHOMGIEFFK(byte[] KANAIIDGHCH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x83BEF40", Offset = "0x83BDD40", VA = "0x1883BEF40")]
	public static void JHEDLNLOLOG(byte[] KANAIIDGHCH, [Out] int FIJCBEGFDBD, [Out] int HBJICDOMHDE, [Out] JGGACMFKBEI DILPKDIDKCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x83BEE10", Offset = "0x83BDC10", VA = "0x1883BEE10")]
	private static uint ADLPMIDFGGD(byte[] KANAIIDGHCH, int NBLNCONJINM)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x83BF250", Offset = "0x83BE050", VA = "0x1883BF250")]
	private static ulong KCLCHMHINDM(byte[] KANAIIDGHCH, int NBLNCONJINM)
	{
		return default(ulong);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public static class CHOGEIHNCCM
{
	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x83BF770", Offset = "0x83BE570", VA = "0x1883BF770")]
	public static RenderTexture JLKCGPBNBJI(int FIJCBEGFDBD, int HBJICDOMHDE, int GCKOKDBGBEO, Camera HOHEOKHPGEK, RenderTextureMemoryless AIILMGJPBEL = RenderTextureMemoryless.None)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x83BF9A0", Offset = "0x83BE7A0", VA = "0x1883BF9A0")]
	public static void LLOPLGBNMCL(RenderTexture LLOJDDLPEIM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public sealed class EJFEKODECNO<TImageId> : IDisposable where TImageId : notnull, IEquatable<TImageId>
{
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	private readonly struct DJBIJMKHOEO : IEquatable<DJBIJMKHOEO>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public readonly TImageId HCGGGJIHHCO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public readonly AHOGMEIDPDA FOJPEFPODEB;

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x1AA7590", Offset = "0x1AA6390", VA = "0x181AA7590")]
		public DJBIJMKHOEO(TImageId OPGJHIOADCK, AHOGMEIDPDA LPHCBDACDLC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x454D940", Offset = "0x454C740", VA = "0x18454D940", Slot = "4")]
		public bool Equals(EJFEKODECNO<TImageId>.DJBIJMKHOEO FGAEAFBDBPK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x454DA40", Offset = "0x454C840", VA = "0x18454DA40", Slot = "0")]
		public override bool Equals(object ALGAKMGCCLO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x454DE40", Offset = "0x454CC40", VA = "0x18454DE40", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x454DFD0", Offset = "0x454CDD0", VA = "0x18454DFD0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[CompilerGenerated]
	private sealed class FIGECLJADOI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public JAFFBBCIDNI<Task<Texture2D>> innerDisposableTask;

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
		public FIGECLJADOI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x4F0C450", Offset = "0x4F0B250", VA = "0x184F0C450")]
		internal void HHOOKLBFGAH()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[CompilerGenerated]
	private struct GIHBJBBJEOL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public AsyncTaskMethodBuilder<Texture2D> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public DJBIJMKHOEO cacheKey;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public EJFEKODECNO<TImageId> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		private TImageId <imageId>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		private AHOGMEIDPDA <textureLoadOptions>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		private TaskAwaiter<byte[]> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		private TaskAwaiter<Texture2D> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x4FF3D00", Offset = "0x4FF2B00", VA = "0x184FF3D00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x4FF4B20", Offset = "0x4FF3920", VA = "0x184FF4B20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[CompilerGenerated]
	private struct MBGHIOBJNIF : IAsyncStateMachine
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
		public AHOGMEIDPDA textureLoadOptions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public byte[] imageBytes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public EJFEKODECNO<TImageId> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		private bool <generateMipMaps>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		private bool <makeTextureReadable>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		private bool <usePointFiltering>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		private bool <useClampWrapMode>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		private TaskAwaiter<Texture2D> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x5883780", Offset = "0x5882580", VA = "0x185883780", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x5883F40", Offset = "0x5882D40", VA = "0x185883F40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[CompilerGenerated]
	private struct LJLENCOIFDL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public IDisposable disposable;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x5698A70", Offset = "0x5697870", VA = "0x185698A70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x5698E90", Offset = "0x5697C90", VA = "0x185698E90", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400004B")]
	private const int FNEEKFIBLPH = 1;

	[Cpp2IlInjected.Token(Token = "0x400004C")]
	private static readonly SemaphoreSlim JAKJAHBAJJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	private readonly Func<TImageId, CancellationToken, Task<byte[]>>? BCLENAKHBAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	private readonly Func<TImageId, AHOGMEIDPDA, CancellationToken, Task<Texture2D>>? LBPKEEIPJJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	private readonly Func<TImageId, string>? DPNKCKDBIFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	private readonly IJBKKOGNFGH<DJBIJMKHOEO, Texture2D> ILGAPHGFBJI;

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x4A64C00", Offset = "0x4A63A00", VA = "0x184A64C00")]
	public EJFEKODECNO(Func<TImageId, CancellationToken, Task<byte[]>> IBJJHKFNIHB, [Optional] Func<TImageId, string>? GDNPKBNHOHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x4A64BD0", Offset = "0x4A639D0", VA = "0x184A64BD0")]
	public EJFEKODECNO(Func<TImageId, AHOGMEIDPDA, CancellationToken, Task<Texture2D>> GJOOENJNGMN, [Optional] Func<TImageId, string>? GDNPKBNHOHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x4A64A40", Offset = "0x4A63840", VA = "0x184A64A40")]
	private EJFEKODECNO(Func<TImageId, CancellationToken, Task<byte[]>>? IBJJHKFNIHB, Func<TImageId, AHOGMEIDPDA, CancellationToken, Task<Texture2D>>? GJOOENJNGMN, Func<TImageId, string>? GDNPKBNHOHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x4A63F60", Offset = "0x4A62D60", VA = "0x184A63F60")]
	public HNDICJJKNNH<Texture2D> HNALGEGIBAF(TImageId LBCIAFJGJHM, AHOGMEIDPDA FOPMALPKDHE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x4A646C0", Offset = "0x4A634C0", VA = "0x184A646C0")]
	public void OFEJMMBCIJL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x4A63A10", Offset = "0x4A62810", VA = "0x184A63A10", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x4A63AA0", Offset = "0x4A628A0", VA = "0x184A63AA0")]
	[AsyncStateMachine(typeof(EJFEKODECNO<>.GIHBJBBJEOL))]
	private Task<Texture2D> GHFFMFHBIPC(DJBIJMKHOEO LKKMNPAKFAL, CancellationToken BKHGNHANFKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x4A64560", Offset = "0x4A63360", VA = "0x184A64560")]
	[AsyncStateMachine(typeof(EJFEKODECNO<>.MBGHIOBJNIF))]
	private Task<Texture2D> MDBCLNELHLB(byte[] IEPAGDFFIPB, AHOGMEIDPDA FOPMALPKDHE, CancellationToken BKHGNHANFKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x4A643F0", Offset = "0x4A631F0", VA = "0x184A643F0")]
	private void LHBJPDPCJEC(Texture2D JDNNGPGPIOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x4A64200", Offset = "0x4A63000", VA = "0x184A64200")]
	private bool INLHGKKFNAJ()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x4A64150", Offset = "0x4A62F50", VA = "0x184A64150")]
	private bool IGCHDJALHJJ(byte[] IEPAGDFFIPB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x4A64210", Offset = "0x4A63010", VA = "0x184A64210")]
	[CompilerGenerated]
	[AsyncStateMachine(typeof(EJFEKODECNO<>.LJLENCOIFDL))]
	internal static Task KCNMJNPGAFN(IDisposable GDELPGLMADG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
[Flags]
public enum AHOGMEIDPDA : byte
{
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	Default = 0,
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	NoMipMaps = 1,
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	MakeTextureReadable = 2,
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	CompressTexture = 4,
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	UseNearestTextureFiltering = 8,
	[Cpp2IlInjected.Token(Token = "0x4000073")]
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
