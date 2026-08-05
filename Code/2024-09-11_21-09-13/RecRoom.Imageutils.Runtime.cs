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
		[Cpp2IlInjected.Address(RVA = "0x8AF980", Offset = "0x8ADF80", VA = "0x1808AF980")]
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
		[Cpp2IlInjected.Address(RVA = "0x6B8AB00", Offset = "0x6B89100", VA = "0x186B8AB00")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x8B0AE0", Offset = "0x8AF0E0", VA = "0x1808B0AE0")]
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
		[Cpp2IlInjected.Address(RVA = "0x8B0B20", Offset = "0x8AF120", VA = "0x1808B0B20")]
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
		[Cpp2IlInjected.Address(RVA = "0x6B87EB0", Offset = "0x6B864B0", VA = "0x186B87EB0")]
		public CubeMapGenerator()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public enum OOCFJNGBHOB
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
public interface PJGPDLJDDJG
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	OOCFJNGBHOB HHEPLALGNEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool FCIGGNLOFGB(VertexAttributeFormat OJCKNPDLJJF, int HBIDHJKMGHO);
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class CFPCGCBKMOE
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
			[Cpp2IlInjected.Address(RVA = "0x6B8AF20", Offset = "0x6B89520", VA = "0x186B8AF20")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x6B8AF10", Offset = "0x6B89510", VA = "0x186B8AF10")]
		public Resolution(uint NCPIGLMANIM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x91C930", Offset = "0x91AF30", VA = "0x18091C930")]
		public Resolution(uint NCPIGLMANIM, uint DJBPOPBDKAJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x6B8AE20", Offset = "0x6B89420", VA = "0x186B8AE20")]
		public static Resolution PCINKCMIJED(Resolution[] CLJCAFMAPFP, Resolution MIMMOFCLECG, int JACBMCDJDIE)
		{
			return default(Resolution);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public class MKKONIPMFGG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private readonly Resolution JAEODMBJJAF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private Resolution? GPHILJJMBDD;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public uint NCPIGLMANIM
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x6B89650", Offset = "0x6B87C50", VA = "0x186B89650")]
			get
			{
				return default(uint);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public Resolution JJCOLEDPPBE
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x6B897E0", Offset = "0x6B87DE0", VA = "0x186B897E0")]
			get
			{
				return default(Resolution);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x1EB7CB0", Offset = "0x1EB62B0", VA = "0x181EB7CB0")]
		public MKKONIPMFGG(Resolution JAEODMBJJAF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x6B89660", Offset = "0x6B87C60", VA = "0x186B89660")]
		private static Resolution DECIAJBKMFD(Resolution GPHILJJMBDD, OOCFJNGBHOB BKMPEMEAFLM)
		{
			return default(Resolution);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public static class CPFGFOLDIIG
	{
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public static readonly Resolution LMFEGGAMCEO;

		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public static readonly Resolution NNMOEFGCNOL;

		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public static readonly Resolution GFDNIEEKKAJ;

		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public static readonly Resolution EKHLNKDDAKJ;

		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public static readonly Resolution NCFLPLCNCPF;

		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public static readonly Resolution KFPFNCIBEJN;

		[Cpp2IlInjected.Token(Token = "0x4000016")]
		internal static readonly Resolution[] POIFOGCLFDL;
	}

	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public static class HEHLIFNJPDO
	{
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public static readonly Resolution DKIFPEBLLPK;

		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public static readonly Resolution BPJPAAELCFM;

		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public static readonly Resolution OCCKOJBNJAC;

		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public static readonly Resolution GJJHGHGAFFO;

		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public static readonly Resolution GDGOMOKJCCH;

		[Cpp2IlInjected.Token(Token = "0x400001C")]
		internal static readonly Resolution[] POIFOGCLFDL;

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x6B88550", Offset = "0x6B86B50", VA = "0x186B88550")]
		public static Resolution MEGPONODPLA(uint LGAIJEFLCNP)
		{
			return default(Resolution);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400000B")]
	public static readonly Resolution MPCCECEIAHK;
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
internal static class ANKGMPNGDJG
{
	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x6B87590", Offset = "0x6B85B90", VA = "0x186B87590")]
	public static bool INOBMJDMKLO(byte[] JGCMECODHDI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x6B875D0", Offset = "0x6B85BD0", VA = "0x186B875D0")]
	public static bool NBBEEMJEIAN(byte[] JGCMECODHDI, [Out] int LGAIJEFLCNP, [Out] int BNIDPDGADNN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x6B87500", Offset = "0x6B85B00", VA = "0x186B87500")]
	private static int IAEMLIODLDP(byte[] JGCMECODHDI, int NBPJLJIBBHP, [Out] ushort DEPDHBLICGA)
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
		public enum GGFPGOHIJGP : byte
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
		private class DLJJFMEFDMG : IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			private string KJPHMNNIMDP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			public Texture2D DBJPCJDMJJE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400002C")]
			public GGFPGOHIJGP KIEBDBGFNBO;

			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x6B87F10", Offset = "0x6B86510", VA = "0x186B87F10")]
			public DLJJFMEFDMG(string KJPHMNNIMDP)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x3D007C0", Offset = "0x3CFEDC0", VA = "0x183D007C0")]
			public DLJJFMEFDMG(string KJPHMNNIMDP, Texture2D AKFEKCILDGA, GGFPGOHIJGP NNEPMONCNJF)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x6B87ED0", Offset = "0x6B864D0", VA = "0x186B87ED0", Slot = "4")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000011")]
		[CompilerGenerated]
		private sealed class NDKIMEJMKKN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400002D")]
			public ManagedTexture <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400002E")]
			public GGFPGOHIJGP textureMemory;

			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x8912C0", Offset = "0x88F8C0", VA = "0x1808912C0")]
			public NDKIMEJMKKN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x6B8AAC0", Offset = "0x6B890C0", VA = "0x186B8AAC0")]
			internal void INIBMLFBAJM()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000012")]
		[CompilerGenerated]
		private sealed class ANCIBKGPHCD
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400002F")]
			public int quality;

			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x8912C0", Offset = "0x88F8C0", VA = "0x1808912C0")]
			public ANCIBKGPHCD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x6B874C0", Offset = "0x6B85AC0", VA = "0x186B874C0")]
			internal KJOHDOJKOGN GGCNEINKIOD(Texture2D t2d)
			{
				return default(KJOHDOJKOGN);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000014")]
		[CompilerGenerated]
		private sealed class BAOIGILLNLG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000032")]
			public RenderTexture tempRenderTexture;

			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x8912C0", Offset = "0x88F8C0", VA = "0x1808912C0")]
			public BAOIGILLNLG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x6B877E0", Offset = "0x6B85DE0", VA = "0x186B877E0")]
			internal void MBNCEGIGAJF()
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
		private JAGIEECCCMP<Texture2D> _cpuSidePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private DLJJFMEFDMG _memTexture;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private JAGIEECCCMP<KJOHDOJKOGN> _jpgEncodePromise;

		[Cpp2IlInjected.Token(Token = "0x4000023")]
		public const int DEFAULT_JPG_QUALITY = 80;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private JAGIEECCCMP<KJOHDOJKOGN> _pngEncodePromise;

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public bool UsePalette
		{
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0xA00000", Offset = "0x9FE600", VA = "0x180A00000")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public RenderTexture LastRenderTexture
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x886FC0", Offset = "0x8855C0", VA = "0x180886FC0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x887040", Offset = "0x885640", VA = "0x180887040")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		private DLJJFMEFDMG memoryTexture
		{
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x6B8AA10", Offset = "0x6B89010", VA = "0x186B8AA10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x6B8A940", Offset = "0x6B88F40", VA = "0x186B8A940")]
		public ManagedTexture(string KJPHMNNIMDP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x6B8A9A0", Offset = "0x6B88FA0", VA = "0x186B8A9A0")]
		public ManagedTexture(string KJPHMNNIMDP, bool IFEGMGMPOGI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x6B8A3D0", Offset = "0x6B889D0", VA = "0x186B8A3D0")]
		public void GLIALNBKGGA(RenderTexture NLJNFEPLKML)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x6B8A650", Offset = "0x6B88C50", VA = "0x186B8A650")]
		public JAGIEECCCMP<Texture2D> PECODIKBMMH(GGFPGOHIJGP NNEPMONCNJF, bool NLCBCJNAMOO = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x6B8A410", Offset = "0x6B88A10", VA = "0x186B8A410")]
		public JAGIEECCCMP<KJOHDOJKOGN> HAGLFAMHNEK(bool NLCBCJNAMOO = false, int HCHCLJMHPCI = 80)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x6B89BA0", Offset = "0x6B881A0", VA = "0x186B89BA0")]
		public JAGIEECCCMP<KJOHDOJKOGN> EMPDKGDMACB(bool NLCBCJNAMOO = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x6B89E80", Offset = "0x6B88480", VA = "0x186B89E80")]
		private static JAGIEECCCMP<Texture2D> FJDOGNJFNNO(string KJPHMNNIMDP, RenderTexture NLJNFEPLKML, Texture2D GCEIFLNJBGE, bool NLCBCJNAMOO, GGFPGOHIJGP MBLLGDBCFGP = GGFPGOHIJGP.GPU)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x6B8A5B0", Offset = "0x6B88BB0", VA = "0x186B8A5B0")]
		public void HPIMFDFHGDN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x6B89B90", Offset = "0x6B88190", VA = "0x186B89B90", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x6B89B30", Offset = "0x6B88130", VA = "0x186B89B30")]
		[CompilerGenerated]
		private JAGIEECCCMP<byte[]> DLNFIKGKJLN(Texture2D OPEKOAHNPMJ)
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public static class GMGMLDNGDAC
{
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	private struct PBJNADMIJGI
	{
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x6B8AD20", Offset = "0x6B89320", VA = "0x186B8AD20")]
		public unsafe static extern void DKIFGMIFPEP(void* MFLGLJDDKCO, void* JPCKHGMDGNF, bool DDNJICHGBLG, bool DPLAALFOMJJ, bool OFELIJCKDAO, [Out] int LGAIJEFLCNP, [Out] int BNIDPDGADNN, [Out] bool PAGJGHNGKEO);
	}

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[CompilerGenerated]
	private sealed class OEIKPDGIGPP
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
		[Cpp2IlInjected.Address(RVA = "0x8912C0", Offset = "0x88F8C0", VA = "0x1808912C0")]
		public OEIKPDGIGPP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x6B8AB80", Offset = "0x6B89180", VA = "0x186B8AB80")]
		internal void LNOBKBHDLOB(NativeArray<byte> outputTextureBytes)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[CompilerGenerated]
	private struct CEKEIBGKAOC : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x6B87860", Offset = "0x6B85E60", VA = "0x186B87860", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x6B87A80", Offset = "0x6B86080", VA = "0x186B87A80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000019")]
	[CompilerGenerated]
	private sealed class MAJKHKMOHGD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public Action<NativeArray<byte>> compressionAction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public NativeArray<byte> outputTextureBytes;

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x8912C0", Offset = "0x88F8C0", VA = "0x1808912C0")]
		public MAJKHKMOHGD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x6B89610", Offset = "0x6B87C10", VA = "0x186B89610")]
		internal void ANEIPAIOEBE()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	[CompilerGenerated]
	private struct IAJAGCGEADG : IAsyncStateMachine
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
		private MAJKHKMOHGD <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private Texture2D <outputTexture>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x6B88870", Offset = "0x6B86E70", VA = "0x186B88870", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x6B88F30", Offset = "0x6B87530", VA = "0x186B88F30", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private static readonly bool IBGNKNEKGIO;

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x8CEE40", Offset = "0x8CD440", VA = "0x1808CEE40")]
	public static bool OMOBLKPJLNG(byte[] PNEGBCBJHCC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x6B881F0", Offset = "0x6B867F0", VA = "0x186B881F0")]
	[AsyncStateMachine(typeof(CEKEIBGKAOC))]
	public static Task<Texture2D> AOGGABFCACL(byte[] PNEGBCBJHCC, bool INHDLEPDPJD = false, bool LECINJMHFOM = false, [Optional] CancellationToken IONNNJNKLMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x6B88330", Offset = "0x6B86930", VA = "0x186B88330")]
	[AsyncStateMachine(typeof(IAJAGCGEADG))]
	private static Task<Texture2D> CNFALBEACID(int LGAIJEFLCNP, int BNIDPDGADNN, bool KFKOMJJDALM, bool INHDLEPDPJD, bool LECINJMHFOM, Action<NativeArray<byte>> OJDCDMNCDCB, CancellationToken IONNNJNKLMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x6B88480", Offset = "0x6B86A80", VA = "0x186B88480")]
	private static TextureFormat DPKCOBGMMHA(bool KFKOMJJDALM)
	{
		return default(TextureFormat);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
internal enum GMEEGNMBOHC
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
internal static class JLKHJEOEDJA
{
	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x6B895D0", Offset = "0x6B87BD0", VA = "0x186B895D0")]
	public static bool ONCMEMMKFKO(byte[] JGCMECODHDI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x6B891A0", Offset = "0x6B877A0", VA = "0x186B891A0")]
	public static void JNPDIGIBDHL(byte[] JGCMECODHDI, [Out] int LGAIJEFLCNP, [Out] int BNIDPDGADNN, [Out] GMEEGNMBOHC OJCKNPDLJJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x6B894A0", Offset = "0x6B87AA0", VA = "0x186B894A0")]
	private static uint MLNLMFAIMGO(byte[] JGCMECODHDI, int OENMMCMOJOM)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x6B88FA0", Offset = "0x6B875A0", VA = "0x186B88FA0")]
	private static ulong CANPCFCIEDL(byte[] JGCMECODHDI, int OENMMCMOJOM)
	{
		return default(ulong);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public static class FBAOFIFKLPJ
{
	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x6B87F60", Offset = "0x6B86560", VA = "0x186B87F60")]
	public static RenderTexture BLLCFNDPHFH(int LGAIJEFLCNP, int BNIDPDGADNN, int EIIIOBOAFAN, Camera FIJJFNJDPAF, RenderTextureMemoryless KMOJJPNFCIO = RenderTextureMemoryless.None)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x6B88190", Offset = "0x6B86790", VA = "0x186B88190")]
	public static void PIJAJJOHIBP(RenderTexture NLJNFEPLKML)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public sealed class GLNEFOKNDFJ<TImageId> : IDisposable where TImageId : notnull, IEquatable<TImageId>
{
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	private readonly struct MMDCHLCBGFB : IEquatable<MMDCHLCBGFB>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public readonly TImageId JPMPGIJEHEH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public readonly OEJLPNHFFMA IEJLGHFBPOK;

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x43DF710", Offset = "0x43DDD10", VA = "0x1843DF710")]
		public MMDCHLCBGFB(TImageId LFOBGDLOPID, OEJLPNHFFMA KOBIBKHOMIO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x46B0DB0", Offset = "0x46AF3B0", VA = "0x1846B0DB0", Slot = "4")]
		public bool Equals(GLNEFOKNDFJ<TImageId>.MMDCHLCBGFB PLNBHPCFEOK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x46B1060", Offset = "0x46AF660", VA = "0x1846B1060", Slot = "0")]
		public override bool Equals(object GHMNBJIOGAM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x46B12D0", Offset = "0x46AF8D0", VA = "0x1846B12D0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x46B13A0", Offset = "0x46AF9A0", VA = "0x1846B13A0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[CompilerGenerated]
	private sealed class GMCPPDDINLK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public EMDFPNDLNED<Task<Texture2D>> innerDisposableTask;

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x8912C0", Offset = "0x88F8C0", VA = "0x1808912C0")]
		public GMCPPDDINLK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x3DFB4F0", Offset = "0x3DF9AF0", VA = "0x183DFB4F0")]
		internal void FPHNCMGHAOG()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[CompilerGenerated]
	private struct LMHALELIEAP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public AsyncTaskMethodBuilder<Texture2D> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		public MMDCHLCBGFB cacheKey;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public GLNEFOKNDFJ<TImageId> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		private TImageId <imageId>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		private OEJLPNHFFMA <textureLoadOptions>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		private TaskAwaiter<byte[]> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		private TaskAwaiter<Texture2D> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x440F270", Offset = "0x440D870", VA = "0x18440F270", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x440F9D0", Offset = "0x440DFD0", VA = "0x18440F9D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[CompilerGenerated]
	private struct DJCCKBPJBEG : IAsyncStateMachine
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
		public OEJLPNHFFMA textureLoadOptions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public byte[] imageBytes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public GLNEFOKNDFJ<TImageId> <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x5A65E20", Offset = "0x5A64420", VA = "0x185A65E20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x5A665A0", Offset = "0x5A64BA0", VA = "0x185A665A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	[CompilerGenerated]
	private struct JOMBAOKNHOM : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x42582B0", Offset = "0x42568B0", VA = "0x1842582B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x4258670", Offset = "0x4256C70", VA = "0x184258670", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private const int IGPLOHFCKOP = 1;

	[Cpp2IlInjected.Token(Token = "0x4000052")]
	private static readonly SemaphoreSlim PEMADDIDEIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	private readonly Func<TImageId, CancellationToken, Task<byte[]>>? NJABAHCMPKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	private readonly Func<TImageId, OEJLPNHFFMA, CancellationToken, Task<Texture2D>>? CANDEBGAOEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	private readonly Func<TImageId, string>? JJIINGBEGAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	private readonly BDGMGOKIHEA<MMDCHLCBGFB, Texture2D> CGBGFBFMDGA;

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x3DF7BB0", Offset = "0x3DF61B0", VA = "0x183DF7BB0")]
	public GLNEFOKNDFJ(Func<TImageId, CancellationToken, Task<byte[]>> JEFAPJMNHJN, [Optional] Func<TImageId, string>? MFIHDFLPACA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x3DF7B60", Offset = "0x3DF6160", VA = "0x183DF7B60")]
	public GLNEFOKNDFJ(Func<TImageId, OEJLPNHFFMA, CancellationToken, Task<Texture2D>> BHBKJCFNMEN, [Optional] Func<TImageId, string>? MFIHDFLPACA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x3DF7C00", Offset = "0x3DF6200", VA = "0x183DF7C00")]
	private GLNEFOKNDFJ(Func<TImageId, CancellationToken, Task<byte[]>>? JEFAPJMNHJN, Func<TImageId, OEJLPNHFFMA, CancellationToken, Task<Texture2D>>? BHBKJCFNMEN, Func<TImageId, string>? MFIHDFLPACA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x3DF6F10", Offset = "0x3DF5510", VA = "0x183DF6F10")]
	public POLPOFEBNLM<Texture2D> EADCAPENOHN(TImageId HEGCFJCEPAN, OEJLPNHFFMA EINMBABHBKN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x3DF75C0", Offset = "0x3DF5BC0", VA = "0x183DF75C0")]
	public void HFHFGMPNGIN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x3DF6C30", Offset = "0x3DF5230", VA = "0x183DF6C30", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x3DF7770", Offset = "0x3DF5D70", VA = "0x183DF7770")]
	[AsyncStateMachine(typeof(GLNEFOKNDFJ<>.LMHALELIEAP))]
	private Task<Texture2D> HJLGCPCHIOK(MMDCHLCBGFB BANNIIGGBKD, CancellationToken IONNNJNKLMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x3DF7460", Offset = "0x3DF5A60", VA = "0x183DF7460")]
	[AsyncStateMachine(typeof(GLNEFOKNDFJ<>.DJCCKBPJBEG))]
	private Task<Texture2D> HBDKPGJFIJP(byte[] PNEGBCBJHCC, OEJLPNHFFMA EINMBABHBKN, CancellationToken IONNNJNKLMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x3DF78E0", Offset = "0x3DF5EE0", VA = "0x183DF78E0")]
	private void MMGMOCIOKAO(Texture2D AKFEKCILDGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x3DF78D0", Offset = "0x3DF5ED0", VA = "0x183DF78D0")]
	private bool LJIJFFONDNE()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x3DF78F0", Offset = "0x3DF5EF0", VA = "0x183DF78F0")]
	private bool PHPCMJPNGFM(byte[] PNEGBCBJHCC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x3DF7120", Offset = "0x3DF5720", VA = "0x183DF7120")]
	[CompilerGenerated]
	[AsyncStateMachine(typeof(GLNEFOKNDFJ<>.JOMBAOKNHOM))]
	internal static Task FHADCNJIOCE(IDisposable PNAJFLCKDNA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
[Flags]
public enum OEJLPNHFFMA : byte
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
