using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using JetBrains.Annotations;
using Microsoft.CodeAnalysis;
using RecRoom.DataLayer.Attributes;
using RecRoom.NoEngine.Common;
using UnityEngine.Scripting;

[assembly: AssemblyVersion("0.0.0.0")]
namespace Microsoft.CodeAnalysis
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class EmbeddedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x8DF890", Offset = "0x8DE890", VA = "0x1808DF890")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[CompilerGenerated]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter, AllowMultiple = false, Inherited = false)]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x75EC580", Offset = "0x75EB580", VA = "0x1875EC580")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x8E0550", Offset = "0x8DF550", VA = "0x1808E0550")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[Microsoft.CodeAnalysis.Embedded]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	[CompilerGenerated]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x8E0590", Offset = "0x8DF590", VA = "0x1808E0590")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public enum MHGEKCLKOFO
{
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	Vote,
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	Instant,
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	Off
}
namespace _AssemblyRegistry.RecRoom_RoomPermissions_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[CompilerGenerated]
	[RecRoom.DataLayer.Attributes.Preserve]
	public class _AssemblyIndex : PFMKOBANMPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x75ED730", Offset = "0x75EC730", VA = "0x1875ED730", Slot = "8")]
		public override void NCHGKCJDJHF(GLGFPKOIELC registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x6565350", Offset = "0x6564350", VA = "0x186565350")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public delegate void HHIHAPKJFMP<TPermission>(TPermission DHAFNIGMBFM);
[Cpp2IlInjected.Token(Token = "0x2000008")]
public delegate void KJDJEIIMPPO(NKLIIMCFHAI LCIKCDFLABF);
[Cpp2IlInjected.Token(Token = "0x2000009")]
public enum NGKGGDJIOJG
{
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	Off,
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	Hosts,
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	Everyone
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface JGPDOODBKMF
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool MKGJLKAAMAK
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	bool JNCALHKLLLH
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	bool NLDKNMFCFPL
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool NEGHPMEBKNB
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	bool LDNFEFNCEMA
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	bool AIONIODMJJO
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
internal static class GLGJHEKJLCI
{
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[Flags]
	public enum GAPNMPEOLEO
	{
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		AG_EVERYONE = 0,
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		AG_CREATOR = 0x200000,
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		AG_COOWNER = 0x400000,
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		AG_HOST = 0x800000,
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		AG_MODERATOR = 0x1000000
	}

	[Cpp2IlInjected.Token(Token = "0x400000B")]
	public static readonly Guid MHELEEFLOAK;

	[Cpp2IlInjected.Token(Token = "0x400000C")]
	public static readonly Guid FEKCBCBPNDE;

	[Cpp2IlInjected.Token(Token = "0x400000D")]
	public static readonly Guid DIELOPDIEOC;

	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public static readonly Guid CFOFDNMHBLK;

	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public static readonly Guid IECPHOIKOBK;

	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public static readonly Guid KMNDEIHNIOG;

	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private static readonly LIODPKEEOBA<FCBKKHIFGAP, Guid> MDGBGCLGOBF;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	internal static IEnumerable<FCBKKHIFGAP> IMFNICDGCCG
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x75E9AD0", Offset = "0x75E8AD0", VA = "0x1875E9AD0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x75E9B40", Offset = "0x75E8B40", VA = "0x1875E9B40")]
	public static FCBKKHIFGAP FEENCFGPFLJ(Guid EEKOILIMLBO)
	{
		return default(FCBKKHIFGAP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x75E9C60", Offset = "0x75E8C60", VA = "0x1875E9C60")]
	public static Guid ICMBMAJLLLH(FCBKKHIFGAP LDEBJCNGHAE)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x75E9BD0", Offset = "0x75E8BD0", VA = "0x1875E9BD0")]
	public static bool GLLGCNMIBIE(FCBKKHIFGAP LDEBJCNGHAE, [Out] Guid EEKOILIMLBO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x75E9A30", Offset = "0x75E8A30", VA = "0x1875E9A30")]
	public static bool BHJMJAOJOJM(Guid EEKOILIMLBO, [Out] FCBKKHIFGAP LDEBJCNGHAE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x75E99B0", Offset = "0x75E89B0", VA = "0x1875E99B0")]
	public static FCBKKHIFGAP AIABABPCNPB(FCBKKHIFGAP LDEBJCNGHAE)
	{
		return default(FCBKKHIFGAP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x75E9D00", Offset = "0x75E8D00", VA = "0x1875E9D00")]
	public static GAPNMPEOLEO IIDJENDDBDG(FCBKKHIFGAP GENKPPCKKFI)
	{
		return default(GAPNMPEOLEO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x75E99F0", Offset = "0x75E89F0", VA = "0x1875E99F0")]
	internal static FCBKKHIFGAP BAGOLCMCNBH(GAPNMPEOLEO HBDBJNDDNAC)
	{
		return default(FCBKKHIFGAP);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface OEEIHCNKFII : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000008")]
	AMEDAMHKJIC DODKMANFIID
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	IEnumerable<DIADGMKLDNI> IFPNDLAEACE
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event KJDJEIIMPPO BDFAMBBFIAO;

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	IReadOnlyList<DIADGMKLDNI> IMBJELIJHHN(bool DGLCLMHHBOF = false);

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(Slot = "5")]
	DIADGMKLDNI KDJOBHPKOEO(NKLIIMCFHAI LCIKCDFLABF);

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool JJJHHANNCAF(NKLIIMCFHAI LCIKCDFLABF);

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(Slot = "7")]
	IReadOnlyList<DIADGMKLDNI> JOICPLOCNKH(NKLIIMCFHAI LCIKCDFLABF, bool LNJDKONKNPL = false);

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool JMFIMHJPHGN(NKLIIMCFHAI LPFCDPGIHHG, FCBKKHIFGAP LDEBJCNGHAE);

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "9")]
	DIADGMKLDNI AEFONFNECHD(FCBKKHIFGAP LDEBJCNGHAE);

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "10")]
	bool DHGEIKHDDJO<T>(FCBKKHIFGAP LDEBJCNGHAE, IKDOJNFJDNC DHAFNIGMBFM, bool DEFOPLCHCHK, T FPMIIFOGKII, [Optional] Action MMIFGEKFLGG) where T : notnull;

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(Slot = "11")]
	string NOAOGCNDHAJ(IKDOJNFJDNC DHAFNIGMBFM);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface GAEMIBCDDHG
{
	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task HMHPPIMEPPI(MEGLOJMOHAP EBLANDLJNLN, CancellationToken CLIKNEKJHEI);

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void IMNCMBBMCOA(MEGLOJMOHAP EBLANDLJNLN);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface HAIFHPEHFFK
{
	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	NKLIIMCFHAI JNLEFHOCOBD
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	DACBMNFKIFK GCCNOMJGODC
	{
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	CDBHFDKLKGA HEMLAFJPHME
	{
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event Action<OJLKOODJGJG> GFPFOCADKGG;

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event Action DDCCLGIHOCL;

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(Slot = "4")]
	FCBKKHIFGAP DPABPOAHNIF(NKLIIMCFHAI LCIKCDFLABF);

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "5")]
	Task<OJLKOODJGJG> DIDPJPLMMPE(CancellationToken CLIKNEKJHEI);

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(Slot = "6")]
	Task ECKGABIFOHM(long AHNLEKFKAGC, IReadOnlyList<ODFEIFFKACA> KLLJINOHCFN);

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(Slot = "7")]
	Task PFGBNOEGBAF(long AHNLEKFKAGC, long ABKHIAFPEJM, IReadOnlyList<ODFEIFFKACA> KLLJINOHCFN);

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(Slot = "9")]
	IEnumerable<NKLIIMCFHAI> FGHPJOLHCFE();
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public static class KKKPBHLFFIP
{
	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x75EAC80", Offset = "0x75E9C80", VA = "0x1875EAC80")]
	public static FCBKKHIFGAP JDBKLFCLEGG(this HAIFHPEHFFK HECBBENLGBG)
	{
		return default(FCBKKHIFGAP);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public interface CBHGHBKJOFJ<TPermission> where TPermission : notnull
{
	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	string IFKOOJMOBBB
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	event HHIHAPKJFMP<TPermission> KDANFDAOAHC;
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
internal abstract class PHNJGCJFNNK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	internal object? DJOIOGDBGGN;

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public object? GMKMPAKIOPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x75ECE00", Offset = "0x75EBE00", VA = "0x1875ECE00")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x75ECD00", Offset = "0x75EBD00", VA = "0x1875ECD00")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x75ECED0", Offset = "0x75EBED0", VA = "0x1875ECED0")]
	protected PHNJGCJFNNK(object? BGLLEKPGLCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract bool GLDBPDCBPPC(object? BJDKOHEGDOK);
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
internal class ADHJCKACMMF<T> : PHNJGCJFNNK where T : notnull, new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private readonly IEqualityComparer<T> MPGIFOAHCCG;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public T DMNEEJMINJG
	{
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x40903C0", Offset = "0x408F3C0", VA = "0x1840903C0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x408FCC0", Offset = "0x408ECC0", VA = "0x18408FCC0", Slot = "4")]
	public override bool GLDBPDCBPPC(object? BJDKOHEGDOK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x408F8D0", Offset = "0x408E8D0", VA = "0x18408F8D0")]
	public bool BLKBOMFGDBH(T OJFJLNPNKOG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x4090590", Offset = "0x408F590", VA = "0x184090590")]
	public ADHJCKACMMF(T MJBMFFMBOMO, IEqualityComparer<T> MPGIFOAHCCG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
internal class JABMLOEDLEK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private readonly Dictionary<IKDOJNFJDNC, bool> KFHBCEANNIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private readonly Dictionary<IKDOJNFJDNC, PHNJGCJFNNK> HJOHNMMONKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private readonly BHDMLGFMKHN HKKDKNLICHD;

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x75EA940", Offset = "0x75E9940", VA = "0x1875EA940")]
	public JABMLOEDLEK(BHDMLGFMKHN HKKDKNLICHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x75EA8D0", Offset = "0x75E98D0", VA = "0x1875EA8D0")]
	public bool NBNFMEFICKI(IKDOJNFJDNC DHAFNIGMBFM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x2FFB330", Offset = "0x2FFA330", VA = "0x182FFB330")]
	public bool BFJFPEEJCCJ<T>(IKDOJNFJDNC DHAFNIGMBFM, bool DEFOPLCHCHK, T BJDKOHEGDOK) where T : notnull, new()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x2FFB8B0", Offset = "0x2FFA8B0", VA = "0x182FFB8B0")]
	public (bool, T?) IIDBOIEBJMD<T>(IKDOJNFJDNC DHAFNIGMBFM) where T : new()
	{
		return default((bool, T));
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x75EA3A0", Offset = "0x75E93A0", VA = "0x1875EA3A0")]
	public bool BFJFPEEJCCJ(IKDOJNFJDNC DHAFNIGMBFM, bool DEFOPLCHCHK, object BJDKOHEGDOK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x75EA480", Offset = "0x75E9480", VA = "0x1875EA480")]
	public (bool, object) IIDBOIEBJMD(IKDOJNFJDNC DHAFNIGMBFM)
	{
		return default((bool, object));
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x2FFB2D0", Offset = "0x2FFA2D0", VA = "0x182FFB2D0")]
	private void ABANADJLIBP<T>(IKDOJNFJDNC DHAFNIGMBFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x75EA610", Offset = "0x75E9610", VA = "0x1875EA610")]
	private PHNJGCJFNNK LHLDEICMMFG(IKDOJNFJDNC DHAFNIGMBFM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x75EA6E0", Offset = "0x75E96E0", VA = "0x1875EA6E0")]
	public void MGHLHAGPGPD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
internal class NOMMAFJLNON
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public readonly string NJGIKIMFGFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public readonly Type CNHHJBLEEON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public readonly DJFOFKBBHNH EMEOIHEFEGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public readonly IKDOJNFJDNC DCPGDIMGOKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public EIBDAGCPMBL LNOIPEFGOBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public MFANNPNAEAN ILHOBEAGIGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public HOGHBDKNFHG LELJALJIIEN;

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x75EC4E0", Offset = "0x75EB4E0", VA = "0x1875EC4E0")]
	public NOMMAFJLNON(Type ADFKACDKJAK, string BHEDEEKHNIF, IKDOJNFJDNC DHAFNIGMBFM, EIBDAGCPMBL OPPDDBEMDJD, MFANNPNAEAN NEMDMHJOBOA, HOGHBDKNFHG HIIBGDCHKOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x75EC490", Offset = "0x75EB490", VA = "0x1875EC490")]
	public object NJJGJPCNGNM(object? DFABCHNPEEM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x312C800", Offset = "0x312B800", VA = "0x18312C800")]
	public void ABANADJLIBP<T>()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x75EC3E0", Offset = "0x75EB3E0", VA = "0x1875EC3E0")]
	public void ABANADJLIBP(Type ECAKPKNLKCK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
internal class FKNLCDBHODC<T> : NOMMAFJLNON where T : new()
{
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	internal delegate string FGIPGNGAHHM(T BJDKOHEGDOK);

	[Cpp2IlInjected.Token(Token = "0x2000018")]
	internal delegate T CDGAHHBDBAC(string? JJFHFEBKLFD, T MJBMFFMBOMO);

	[Cpp2IlInjected.Token(Token = "0x2000019")]
	[CompilerGenerated]
	private sealed class MJBBGHEHBKM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public FGIPGNGAHHM serializeRecNetString;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public CDGAHHBDBAC parseRecNetString;

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x8C2F40", Offset = "0x8C1F40", VA = "0x1808C2F40")]
		public MJBBGHEHBKM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x49533E0", Offset = "0x49523E0", VA = "0x1849533E0")]
		internal string LHMCPEBOPFA(object? v)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x49534B0", Offset = "0x49524B0", VA = "0x1849534B0")]
		internal object NOEMCLGBEJF(string? s, object d)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x400FEC0", Offset = "0x400EEC0", VA = "0x18400FEC0")]
	public FKNLCDBHODC(IKDOJNFJDNC DHAFNIGMBFM, string BHEDEEKHNIF, [Optional] FGIPGNGAHHM? OPPDDBEMDJD, [Optional] CDGAHHBDBAC? NEMDMHJOBOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x400FB80", Offset = "0x400EB80", VA = "0x18400FB80")]
	private static object? OGCNNFLPKKP(CDGAHHBDBAC? NEMDMHJOBOA, string? JJFHFEBKLFD, object? MJBMFFMBOMO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x400EF60", Offset = "0x400DF60", VA = "0x18400EF60")]
	private static string EKFEJLFJOKC(FGIPGNGAHHM? MEAIDBDFAEJ, object? BJDKOHEGDOK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
internal delegate string EIBDAGCPMBL(object? BJDKOHEGDOK);
[Cpp2IlInjected.Token(Token = "0x200001C")]
internal delegate object MFANNPNAEAN(string? JJFHFEBKLFD, [Optional] object MJBMFFMBOMO);
[Cpp2IlInjected.Token(Token = "0x200001D")]
internal delegate PHNJGCJFNNK HOGHBDKNFHG();
[Cpp2IlInjected.Token(Token = "0x200001E")]
internal class BHDMLGFMKHN
{
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	private class NMPHLCDIMEF : IEqualityComparer<List<string>>
	{
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		internal static NMPHLCDIMEF LONLOOPDCMJ;

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x75EC0B0", Offset = "0x75EB0B0", VA = "0x1875EC0B0", Slot = "4")]
		public bool Equals(List<string> GOCMFEAMGHO, List<string> AEFHGLLPABH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x75EC200", Offset = "0x75EB200", VA = "0x1875EC200", Slot = "5")]
		public int GetHashCode(List<string> IFPBFCLBBDP)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x8C2F40", Offset = "0x8C1F40", VA = "0x1808C2F40")]
		public NMPHLCDIMEF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000020")]
	private class BKICINNNFHO : LMCPEFPJCIF<MHGEKCLKOFO>
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x75E0C20", Offset = "0x75DFC20", VA = "0x1875E0C20", Slot = "9")]
		public override string EKFEJLFJOKC(MHGEKCLKOFO EDAMLOGMMEK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x75E0A40", Offset = "0x75DFA40", VA = "0x1875E0A40", Slot = "10")]
		protected override bool CGANEOLEPNJ(string EDAMLOGMMEK, [Out] MHGEKCLKOFO BJDKOHEGDOK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x75E0D10", Offset = "0x75DFD10", VA = "0x1875E0D10")]
		public BKICINNNFHO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private static readonly HFALKJFPGCM NAEPPEEJCEA;

	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private static readonly BKICINNNFHO LJBEGKJCAMO;

	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private static readonly List<NOMMAFJLNON> KBPGPEEOLIB;

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public IEnumerable<IKDOJNFJDNC> AOKBHOMNGEI
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x8B9BC0", Offset = "0x8B8BC0", VA = "0x1808B9BC0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public IReadOnlyDictionary<IKDOJNFJDNC, NOMMAFJLNON> HHOEKEGDEHN
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x8B65F0", Offset = "0x8B55F0", VA = "0x1808B65F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x75E0720", Offset = "0x75DF720", VA = "0x1875E0720")]
	public BHDMLGFMKHN([Optional] IList<NOMMAFJLNON>? LPMOJNFJAAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x75DF210", Offset = "0x75DE210", VA = "0x1875DF210")]
	public NOMMAFJLNON KDKJBDAOEOF(IKDOJNFJDNC DHAFNIGMBFM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public interface AMEDAMHKJIC
{
	[Cpp2IlInjected.Token(Token = "0x17000012")]
	DIADGMKLDNI JNJPEELABBO
	{
		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
internal class CPPPHAOOJFM : AMEDAMHKJIC
{
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public static CPPPHAOOJFM DJEOMJLBDBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	internal readonly CJMDJEIMFHD HJOJMOCNNMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	internal readonly IReadOnlyList<CJMDJEIMFHD> JMMJJPGCGDG;

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public DIADGMKLDNI JNJPEELABBO
	{
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x8B9BC0", Offset = "0x8B8BC0", VA = "0x1808B9BC0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x75E96A0", Offset = "0x75E86A0", VA = "0x1875E96A0")]
	public CPPPHAOOJFM(CJMDJEIMFHD JPPLMDPFIIL, IReadOnlyList<CJMDJEIMFHD> MPEHHKPKJPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x75E8810", Offset = "0x75E7810", VA = "0x1875E8810")]
	private static CPPPHAOOJFM AIFPNBHCNON()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public static class HLAAHBJCLIB
{
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public static readonly IReadOnlyList<FCBKKHIFGAP> MOCKJBDLKCH;

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x75EA120", Offset = "0x75E9120", VA = "0x1875EA120")]
	public static bool PFGPLPGIMHH(this NKLIIMCFHAI FOMGKNFCKEA, FCBKKHIFGAP LDEBJCNGHAE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x75EA0A0", Offset = "0x75E90A0", VA = "0x1875EA0A0")]
	public static bool PDBLMGGPDBG(this NKLIIMCFHAI FOMGKNFCKEA, FCBKKHIFGAP LDEBJCNGHAE, CDBHFDKLKGA DOIEOJODELN)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public interface OGGLJODHNNC
{
	[Cpp2IlInjected.Token(Token = "0x17000014")]
	bool IEHACAAADGM
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	bool IDNDEMONPHP
	{
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	bool KCIHJOPKHIN
	{
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	bool PDBNPANBEOE
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	bool ECMMMOPBEMA
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	bool ECPEFFLPADH
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	bool KONCHEMLKEE
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	bool BPFKDCDKAGM
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	bool ENKECGFAPKF
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	bool GAAMOBMOEEN
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	bool BPIDLGKGOPE
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	bool CNDNMEDKLEI
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	IReadOnlyList<string> EHPNBBLNCKB
	{
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	MHGEKCLKOFO BKFEFEEEIOH
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public interface DIADGMKLDNI : OGGLJODHNNC, JGPDOODBKMF, CBHGHBKJOFJ<IKDOJNFJDNC>
{
	[Cpp2IlInjected.Token(Token = "0x17000022")]
	string NMFCEHACCGF
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	FCBKKHIFGAP FOMKPJGIOMM
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(Slot = "2")]
	(bool, T?) AJDAPGIACMM<T>(IKDOJNFJDNC DHAFNIGMBFM) where T : new();
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public enum IKDOJNFJDNC
{
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	INVALID = -1,
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	CAN_EDIT_ROOM_ROLES = 1,
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	VOTE_KICK_PERMISSION = 3,
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	CAN_INVITE = 4,
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	CAN_TALK = 6,
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	CAN_PRINT_PHOTOS = 7,
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	CAN_START_GAMES = 8,
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	CAN_SELF_REVIVE = 9,
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	AUTO_ASSIGNED_GAME_ROLES = 11,
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	CAN_CHANGE_GAME_MODE = 12,
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	CAN_USE_MAKER_PEN = 13,
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	CAN_USE_DELETE_ALL_BUTTON = 14,
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	CAN_SAVE_INVENTIONS = 15,
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	DISABLE_MIC_AUTO_MUTE = 16,
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	CAN_END_GAMES_EARLY = 17,
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	CAN_USE_SHARE_CAM = 18,
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	DEPRECATED_CAN_EDIT_CIRCUITS = 19,
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	CAN_SPAWN_INVENTIONS = 20,
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	CAN_SPAWN_CONSUMABLES = 21,
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	CAN_USE_ROOM_RESET_BUTTON = 22,
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	CAN_USE_PLAY_GIZMOS_TOGGLE = 23,
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	AUTO_ASSIGNED_PLAYER_TAGS = 24,
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	CAN_USE_RRS = 25,
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	ROOM_LEVEL_THRESHOLD = 1000,
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	CAN_SAVE_ROOM = 1001,
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	CAN_PUBLISH_ROOM = 1002,
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	CAN_CLONE_ROOM = 1003,
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	CAN_RESTORE_ROOM = 1004,
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	CAN_EDIT_MAIN_ROOM_SETTINGS = 1006,
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	CAN_EDIT_ROOM_ECON_SETTINGS = 1007,
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	CAN_CREATE_SUBROOMS = 1008,
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	CAN_NAME_SUBROOMS = 1009,
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	CAN_CLONE_SUBROOMS = 1010,
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	CAN_MOVE_SUBROOMS = 1011,
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	CAN_DELETE_SUBROOMS = 1012,
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	CAN_EDIT_SUBROOM_SETTINGS = 1013,
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	CAN_RESET_CLOUD_VARIABLES = 1014,
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	CAN_DELETE_CLOUD_VARIABLES = 1015,
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	CAN_EDIT_ROOM_PROGRESSION = 1016,
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	CAN_REMOVE_ROOM_BANS = 1017,
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	CAN_ADD_ROOM_BANS = 1018
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
internal class CJMDJEIMFHD : DIADGMKLDNI, OGGLJODHNNC, JGPDOODBKMF, CBHGHBKJOFJ<IKDOJNFJDNC>
{
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	internal static readonly BHDMLGFMKHN FEOJLMMILGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	internal readonly JABMLOEDLEK HIEAKHMDOMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private string? LJOHONDJCMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private string? AGLFJBKOOLC;

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	private bool CMKMANNCOOB
	{
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x75E8490", Offset = "0x75E7490", VA = "0x1875E8490", Slot = "23")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	private bool CMIGIHOOJJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x75E6880", Offset = "0x75E5880", VA = "0x1875E6880", Slot = "22")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	private bool NAIIPAACBPE
	{
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x75E7FC0", Offset = "0x75E6FC0", VA = "0x1875E7FC0", Slot = "21")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	private bool IHADJBHFKBN
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x75E6830", Offset = "0x75E5830", VA = "0x1875E6830", Slot = "24")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	private bool JAKMFEJIGDA
	{
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x75E67E0", Offset = "0x75E57E0", VA = "0x1875E67E0", Slot = "26")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	private bool IMMKPMOCJAN
	{
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x75E7ED0", Offset = "0x75E6ED0", VA = "0x1875E7ED0", Slot = "25")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public FCBKKHIFGAP FOMKPJGIOMM
	{
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x9A7620", Offset = "0x9A6620", VA = "0x1809A7620", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(FCBKKHIFGAP);
		}
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x8BC650", Offset = "0x8BB650", VA = "0x1808BC650")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public string IFKOOJMOBBB
	{
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x75E68D0", Offset = "0x75E58D0", VA = "0x1875E68D0", Slot = "29")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x75E7320", Offset = "0x75E6320", VA = "0x1875E7320")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public string NMFCEHACCGF
	{
		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x75E68D0", Offset = "0x75E58D0", VA = "0x1875E68D0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public bool GOPCAMMCELJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0xA24150", Offset = "0xA23150", VA = "0x180A24150")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0xA23D90", Offset = "0xA22D90", VA = "0x180A23D90")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public bool IEHACAAADGM
	{
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x75E7E80", Offset = "0x75E6E80", VA = "0x1875E7E80", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public MHGEKCLKOFO BKFEFEEEIOH
	{
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x75E69B0", Offset = "0x75E59B0", VA = "0x1875E69B0", Slot = "20")]
		get
		{
			return default(MHGEKCLKOFO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public bool IDNDEMONPHP
	{
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x75E8530", Offset = "0x75E7530", VA = "0x1875E8530", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public bool KCIHJOPKHIN
	{
		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x75E6790", Offset = "0x75E5790", VA = "0x1875E6790", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public bool PDBNPANBEOE
	{
		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x75E7E30", Offset = "0x75E6E30", VA = "0x1875E7E30", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public bool ECMMMOPBEMA
	{
		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x75E7F70", Offset = "0x75E6F70", VA = "0x1875E7F70", Slot = "11")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public bool ECPEFFLPADH
	{
		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x75E73C0", Offset = "0x75E63C0", VA = "0x1875E73C0", Slot = "12")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public bool KONCHEMLKEE
	{
		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x75E6EF0", Offset = "0x75E5EF0", VA = "0x1875E6EF0", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public bool BPFKDCDKAGM
	{
		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x75E6EA0", Offset = "0x75E5EA0", VA = "0x1875E6EA0", Slot = "14")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public bool ENKECGFAPKF
	{
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x75E84E0", Offset = "0x75E74E0", VA = "0x1875E84E0", Slot = "15")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public IReadOnlyList<string> EHPNBBLNCKB
	{
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x75E6E40", Offset = "0x75E5E40", VA = "0x1875E6E40", Slot = "19")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public bool CMEGMALDHMN
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x75E8490", Offset = "0x75E7490", VA = "0x1875E8490", Slot = "30")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public bool MDMEKDJDAPJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x75E67E0", Offset = "0x75E57E0", VA = "0x1875E67E0", Slot = "31")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public bool IMGJOBKPIDM
	{
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x75E6880", Offset = "0x75E5880", VA = "0x1875E6880", Slot = "32")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public bool GAAMOBMOEEN
	{
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x75E7F20", Offset = "0x75E6F20", VA = "0x1875E7F20", Slot = "16")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public bool BPIDLGKGOPE
	{
		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x75E7460", Offset = "0x75E6460", VA = "0x1875E7460", Slot = "17")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public bool BIOLCPGCPFN
	{
		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x75E7FC0", Offset = "0x75E6FC0", VA = "0x1875E7FC0", Slot = "33")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public bool CNDNMEDKLEI
	{
		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x75E7370", Offset = "0x75E6370", VA = "0x1875E7370", Slot = "18")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public bool KKIINIKKJMH
	{
		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x75E6830", Offset = "0x75E5830", VA = "0x1875E6830", Slot = "34")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public bool OCHJPBFFHHC
	{
		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x75E7ED0", Offset = "0x75E6ED0", VA = "0x1875E7ED0", Slot = "35")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	public event HHIHAPKJFMP<IKDOJNFJDNC> KDANFDAOAHC
	{
		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x75E83E0", Offset = "0x75E73E0", VA = "0x1875E83E0", Slot = "27")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x75E8330", Offset = "0x75E7330", VA = "0x1875E8330", Slot = "28")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x2D6A8C0", Offset = "0x2D698C0", VA = "0x182D6A8C0", Slot = "6")]
	public (bool, T?) AJDAPGIACMM<T>(IKDOJNFJDNC DHAFNIGMBFM) where T : new()
	{
		return default((bool, T));
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x2D6AAB0", Offset = "0x2D69AB0", VA = "0x182D6AAB0")]
	public CJMDJEIMFHD LPOKFEDDHED<T>(IKDOJNFJDNC DHAFNIGMBFM, bool DEFOPLCHCHK, T BJDKOHEGDOK) where T : notnull, new()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x75E8600", Offset = "0x75E7600", VA = "0x1875E8600")]
	public CJMDJEIMFHD(FCBKKHIFGAP LDEBJCNGHAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x75E8770", Offset = "0x75E7770", VA = "0x1875E8770")]
	public CJMDJEIMFHD(FCBKKHIFGAP LDEBJCNGHAE, [Optional] string? LJOHONDJCMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x75E8790", Offset = "0x75E7790", VA = "0x1875E8790")]
	public CJMDJEIMFHD(CJMDJEIMFHD CFKJFOKANDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x75E8620", Offset = "0x75E7620", VA = "0x1875E8620")]
	internal CJMDJEIMFHD(FCBKKHIFGAP OIANJPEFJFO, [Optional] string? LJOHONDJCMD, [Optional] CJMDJEIMFHD? CFKJFOKANDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x75E6A00", Offset = "0x75E5A00", VA = "0x1875E6A00")]
	public static DJFOFKBBHNH DOGELJPGIIC(IKDOJNFJDNC DHAFNIGMBFM)
	{
		return default(DJFOFKBBHNH);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x75E8210", Offset = "0x75E7210", VA = "0x1875E8210")]
	public void MGHLHAGPGPD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x75E6A70", Offset = "0x75E5A70", VA = "0x1875E6A70")]
	internal CJMDJEIMFHD EAJKPPGGHKD(CJMDJEIMFHD JKGBCOKAJNJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x75E6F40", Offset = "0x75E5F40", VA = "0x1875E6F40")]
	internal IReadOnlyCollection<IKDOJNFJDNC> GHOCANAKDHH(CJMDJEIMFHD CFKJFOKANDL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x75E6D60", Offset = "0x75E5D60", VA = "0x1875E6D60")]
	public bool EKLKLMALOEB(IKDOJNFJDNC DHAFNIGMBFM, bool DEFOPLCHCHK, string BFAJLEAKMLN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x75E8230", Offset = "0x75E7230", VA = "0x1875E8230")]
	public (bool, string) NIFMJCIJCIA(IKDOJNFJDNC DHAFNIGMBFM)
	{
		return default((bool, string));
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x75E7410", Offset = "0x75E6410", VA = "0x1875E7410")]
	internal void IHIHNODDDDM(IKDOJNFJDNC DHAFNIGMBFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x75E8010", Offset = "0x75E7010", VA = "0x1875E8010")]
	public CDFKPKDKKIH MBIEDPJEHBA(Func<FCBKKHIFGAP, Guid> PBGFHMAKDJH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x75E74B0", Offset = "0x75E64B0", VA = "0x1875E74B0")]
	public void KGEFLKCPNMO(CDFKPKDKKIH EBNIDFBNCGH, Func<Guid, FCBKKHIFGAP> PLBKMKBBEGM, [Optional] FCBKKHIFGAP? EMKDENKGKCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x75E6920", Offset = "0x75E5920", VA = "0x1875E6920")]
	[CompilerGenerated]
	private void BPEMCNIJCEE(IKDOJNFJDNC KGMMMIEFJPH, DCPIKKAALLG IMNPPIELGKP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public class BPAFGFJJEIC : GAEMIBCDDHG, OEEIHCNKFII, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	[CompilerGenerated]
	private sealed class OMOPDEDNLJH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		public CJMDJEIMFHD newRole;

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x8C2F40", Offset = "0x8C1F40", VA = "0x1808C2F40")]
		public OMOPDEDNLJH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x75ECCD0", Offset = "0x75EBCD0", VA = "0x1875ECCD0")]
		internal bool ONJJFAOEOBO(CJMDJEIMFHD rc)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002D")]
	[CompilerGenerated]
	private sealed class CCMDJFFICOK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		public FCBKKHIFGAP roleTypeToUpdate;

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x8C2F40", Offset = "0x8C1F40", VA = "0x1808C2F40")]
		public CCMDJFFICOK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x75E6780", Offset = "0x75E5780", VA = "0x1875E6780")]
		internal bool HNPDPAPPIDC(FCBKKHIFGAP r)
		{
			return default(bool);
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[CompilerGenerated]
	private struct OEIHFKIDJJB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public BPAFGFJJEIC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		public MEGLOJMOHAP roomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		private bool <isOffline>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		private TaskAwaiter<OJLKOODJGJG> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x75EC600", Offset = "0x75EB600", VA = "0x1875EC600", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x75ECC70", Offset = "0x75EBC70", VA = "0x1875ECC70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[CompilerGenerated]
	private sealed class FIJBGIJNPPD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		public StringBuilder migrationMessageBuilder;

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x8C2F40", Offset = "0x8C1F40", VA = "0x1808C2F40")]
		public FIJBGIJNPPD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x75E98D0", Offset = "0x75E88D0", VA = "0x1875E98D0")]
		internal void MOOELMDPKKM(CDFKPKDKKIH r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x75E97B0", Offset = "0x75E87B0", VA = "0x1875E97B0")]
		internal void FCNMMMLLAHJ(CDFKPKDKKIH r)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	[CompilerGenerated]
	private struct ICKBLEKALJF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		public MEGLOJMOHAP roomData;
	}

	[Cpp2IlInjected.Token(Token = "0x2000031")]
	[CompilerGenerated]
	private sealed class KFGKFBMMKNJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		public Func<CDFKPKDKKIH, DCPIKKAALLG> dataFunc;

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x8C2F40", Offset = "0x8C1F40", VA = "0x1808C2F40")]
		public KFGKFBMMKNJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x75EABF0", Offset = "0x75E9BF0", VA = "0x1875EABF0")]
		internal void FCKCAFNELNM(CDFKPKDKKIH r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x75EAC50", Offset = "0x75E9C50", VA = "0x1875EAC50")]
		internal void NCMJAMENDLO(CDFKPKDKKIH r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x75EAC20", Offset = "0x75E9C20", VA = "0x1875EAC20")]
		internal void MPHNOFACGBC(CDFKPKDKKIH r)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000032")]
	[CompilerGenerated]
	private sealed class PLAGPFMOKGJ<T> where T : notnull
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000033")]
		private struct <<LocalRequestModifyRolePermission>g__ChangeAndRefresh|0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000099")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400009A")]
			public AsyncVoidMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400009B")]
			public PLAGPFMOKGJ<T> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400009C")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400009D")]
			private TaskAwaiter<OJLKOODJGJG> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x6000114")]
			[Cpp2IlInjected.Address(RVA = "0x3941F60", Offset = "0x3940F60", VA = "0x183941F60", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000115")]
			[Cpp2IlInjected.Address(RVA = "0x9031A0", Offset = "0x9021A0", VA = "0x1809031A0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		public IKDOJNFJDNC rolePermission;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		public FCBKKHIFGAP accountRoleType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		public bool overrides;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		public DJFOFKBBHNH recNetPermissionType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		public string serializedNewValue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		public BPAFGFJJEIC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		public Action onComplete;

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x8C2F40", Offset = "0x8C1F40", VA = "0x1808C2F40")]
		public PLAGPFMOKGJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x4BE7DB0", Offset = "0x4BE6DB0", VA = "0x184BE7DB0")]
		[AsyncStateMachine(typeof(PLAGPFMOKGJ<>.<<LocalRequestModifyRolePermission>g__ChangeAndRefresh|0>d))]
		internal void JKGFNMAFEOA()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	[CompilerGenerated]
	private struct PKMOPDFPODJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		public IReadOnlyList<ODFEIFFKACA> newPermissionOverrides;
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	[CompilerGenerated]
	private struct NLJCDMILKPK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		public HAIFHPEHFFK rolesDataProvider;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		public MEGLOJMOHAP roomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public IReadOnlyDictionary<FCBKKHIFGAP, CJMDJEIMFHD> defaultRoles;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		public NAAEIEAKGMH debugLogger;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x75EB530", Offset = "0x75EA530", VA = "0x1875EB530", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x75EC050", Offset = "0x75EB050", VA = "0x1875EC050", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private readonly HAIFHPEHFFK HECBBENLGBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private readonly CPPPHAOOJFM MNIEMLLJOFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private readonly NAAEIEAKGMH AGNAOKAOOII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private readonly Dictionary<int, CJMDJEIMFHD> NHAMMMDMNCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	internal readonly Dictionary<FCBKKHIFGAP, CJMDJEIMFHD> GDJDNHHEBFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	internal readonly Dictionary<FCBKKHIFGAP, CJMDJEIMFHD> IOMJEFNIIPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	internal readonly List<CJMDJEIMFHD> ODDJLGLGBEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private bool DDCHEACAAAF;

	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private static readonly IKDOJNFJDNC[] KHKCFCGBHDN;

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public AMEDAMHKJIC DODKMANFIID
	{
		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x8B65F0", Offset = "0x8B55F0", VA = "0x1808B65F0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public IEnumerable<DIADGMKLDNI> IFPNDLAEACE
	{
		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x75E0DF0", Offset = "0x75DFDF0", VA = "0x1875E0DF0", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	public event KJDJEIIMPPO BDFAMBBFIAO
	{
		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x75E2E10", Offset = "0x75E1E10", VA = "0x1875E2E10", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x75E11C0", Offset = "0x75E01C0", VA = "0x1875E11C0", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x75E40D0", Offset = "0x75E30D0", VA = "0x1875E40D0")]
	[AEDCCIMPEFD.OFLDIEMPABC]
	internal static void MKFFGPHAFOG(MAONAIOKEHK OLAHEEDNGNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x75E64C0", Offset = "0x75E54C0", VA = "0x1875E64C0")]
	[UnityEngine.Scripting.Preserve]
	internal BPAFGFJJEIC([GAHPILLNNBL(null)] HAIFHPEHFFK KHNLNOPAFKO, [GAHPILLNNBL(null)] CPPPHAOOJFM KIFJHMGLDIM, [GAHPILLNNBL(null)] NAAEIEAKGMH AGNAOKAOOII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x75E2250", Offset = "0x75E1250", VA = "0x1875E2250", Slot = "18")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x75E5730", Offset = "0x75E4730", VA = "0x1875E5730")]
	private void OIGPAIBLLHL(IEnumerable<CJMDJEIMFHD> JEFKIKAFAGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x75E39E0", Offset = "0x75E29E0", VA = "0x1875E39E0", Slot = "12")]
	public bool JJJHHANNCAF(NKLIIMCFHAI LCIKCDFLABF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x75E14E0", Offset = "0x75E04E0", VA = "0x1875E14E0")]
	private void DDCCLGIHOCL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x75E1280", Offset = "0x75E0280", VA = "0x1875E1280")]
	private void CHCLNCMNAFK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x75E35B0", Offset = "0x75E25B0", VA = "0x1875E35B0", Slot = "10")]
	public IReadOnlyList<DIADGMKLDNI> IMBJELIJHHN(bool DGLCLMHHBOF = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x75E3C50", Offset = "0x75E2C50", VA = "0x1875E3C50", Slot = "11")]
	public DIADGMKLDNI KDJOBHPKOEO(NKLIIMCFHAI LCIKCDFLABF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x75E3630", Offset = "0x75E2630", VA = "0x1875E3630")]
	private FCBKKHIFGAP JEOHCINGJGD(NKLIIMCFHAI LCIKCDFLABF)
	{
		return default(FCBKKHIFGAP);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x75E3AB0", Offset = "0x75E2AB0", VA = "0x1875E3AB0", Slot = "14")]
	public bool JMFIMHJPHGN(NKLIIMCFHAI LPFCDPGIHHG, FCBKKHIFGAP LDEBJCNGHAE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x75E0D50", Offset = "0x75DFD50", VA = "0x1875E0D50", Slot = "15")]
	public DIADGMKLDNI AEFONFNECHD(FCBKKHIFGAP LDEBJCNGHAE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x75E5010", Offset = "0x75E4010", VA = "0x1875E5010")]
	private static bool NBENLLALOOG(FJMNGKLFDEJ EEAJJFECKHG, FCBKKHIFGAP LDEBJCNGHAE, [Out] CDFKPKDKKIH? IKIOADLBBNF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x75E55D0", Offset = "0x75E45D0", VA = "0x1875E55D0")]
	private static void NBICIKEAIML(FJMNGKLFDEJ EEAJJFECKHG, Action<CDFKPKDKKIH> EGJGIKCEPGP, FCBKKHIFGAP NKPGOALNMHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x75E5340", Offset = "0x75E4340", VA = "0x1875E5340")]
	private static void NBICIKEAIML(FJMNGKLFDEJ EEAJJFECKHG, Action<CDFKPKDKKIH> EGJGIKCEPGP, Predicate<FCBKKHIFGAP> FLOPEBONNHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x75E1470", Offset = "0x75E0470", VA = "0x1875E1470")]
	private void COAGMFAMAMI(NKLIIMCFHAI LCIKCDFLABF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x75E2EB0", Offset = "0x75E1EB0", VA = "0x1875E2EB0", Slot = "4")]
	[AsyncStateMachine(typeof(OEIHFKIDJJB))]
	public Task HMHPPIMEPPI([CanBeNull] MEGLOJMOHAP EBLANDLJNLN, CancellationToken CLIKNEKJHEI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x8B5BA0", Offset = "0x8B4BA0", VA = "0x1808B5BA0", Slot = "5")]
	public void IMNCMBBMCOA(MEGLOJMOHAP EBLANDLJNLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x75E3270", Offset = "0x75E2270", VA = "0x1875E3270")]
	private void IGHAFBKNAFA(FJMNGKLFDEJ BEPGCKEDNBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x75E49C0", Offset = "0x75E39C0", VA = "0x1875E49C0")]
	internal static string MOLIFPGOCBL(HAIFHPEHFFK HECBBENLGBG, MEGLOJMOHAP EBLANDLJNLN, IReadOnlyDictionary<FCBKKHIFGAP, CJMDJEIMFHD> GDJDNHHEBFJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x75E14F0", Offset = "0x75E04F0", VA = "0x1875E14F0")]
	private static void DGIJMNDEDMA(MEGLOJMOHAP EBLANDLJNLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x75E5FA0", Offset = "0x75E4FA0", VA = "0x1875E5FA0")]
	private static void PGAMJEMAALP(FJMNGKLFDEJ NLINDILCIIK, IReadOnlyDictionary<FCBKKHIFGAP, CJMDJEIMFHD> GDJDNHHEBFJ, StringBuilder FMNCLDDEHOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x75E2570", Offset = "0x75E1570", VA = "0x1875E2570")]
	private static bool EGAFDGAONJF(string EOIBBLKNMKH, [Out] Guid MDIIHAAEKKI, [Out] FCBKKHIFGAP LDEBJCNGHAE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x75E4290", Offset = "0x75E3290", VA = "0x1875E4290")]
	private static void MNBMLBEPDLE(MEGLOJMOHAP EBLANDLJNLN, StringBuilder FMNCLDDEHOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x2D03DF0", Offset = "0x2D02DF0", VA = "0x182D03DF0", Slot = "16")]
	public bool DHGEIKHDDJO<T>(FCBKKHIFGAP LDEBJCNGHAE, IKDOJNFJDNC DHAFNIGMBFM, bool DEFOPLCHCHK, T FPMIIFOGKII, [Optional] Action MMIFGEKFLGG) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x75E56C0", Offset = "0x75E46C0", VA = "0x1875E56C0", Slot = "17")]
	public string NOAOGCNDHAJ(IKDOJNFJDNC DHAFNIGMBFM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x75E2360", Offset = "0x75E1360", VA = "0x1875E2360")]
	private void EDAEJHACKHC(FCBKKHIFGAP LDEBJCNGHAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x75E1260", Offset = "0x75E0260", VA = "0x1875E1260")]
	private bool CCCEJMGILNH(NKLIIMCFHAI LCIKCDFLABF, FCBKKHIFGAP LDEBJCNGHAE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x75E4CD0", Offset = "0x75E3CD0", VA = "0x1875E4CD0")]
	internal CJMDJEIMFHD MPMEOEKGBMM(NKLIIMCFHAI LCIKCDFLABF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x75E3C40", Offset = "0x75E2C40", VA = "0x1875E3C40", Slot = "13")]
	public IReadOnlyList<DIADGMKLDNI> JOICPLOCNKH(NKLIIMCFHAI LCIKCDFLABF, bool LNJDKONKNPL = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x75E3EA0", Offset = "0x75E2EA0", VA = "0x1875E3EA0")]
	internal IReadOnlyList<CJMDJEIMFHD> MIPPBCILFDE(NKLIIMCFHAI LCIKCDFLABF, bool LNJDKONKNPL = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x75E2680", Offset = "0x75E1680", VA = "0x1875E2680")]
	private void EMBPGPKDLBA(OJLKOODJGJG FHDJNOGLDDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x75E3700", Offset = "0x75E2700", VA = "0x1875E3700")]
	private static bool JJEOIEAKACE(CJMDJEIMFHD MGGDAKKNFJE, IReadOnlyDictionary<FCBKKHIFGAP, CJMDJEIMFHD> GDJDNHHEBFJ, [Out] IReadOnlyList<IKDOJNFJDNC> ANOPKEOFJKH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x75E3D60", Offset = "0x75E2D60", VA = "0x1875E3D60")]
	[AsyncStateMachine(typeof(NLJCDMILKPK))]
	private static Task KNDECJEMBKJ(HAIFHPEHFFK HECBBENLGBG, MEGLOJMOHAP EBLANDLJNLN, IReadOnlyDictionary<FCBKKHIFGAP, CJMDJEIMFHD> GDJDNHHEBFJ, NAAEIEAKGMH AGNAOKAOOII)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x75E2FD0", Offset = "0x75E1FD0", VA = "0x1875E2FD0")]
	[CompilerGenerated]
	internal static void IDGAGKJLNHE(Func<CDFKPKDKKIH, DCPIKKAALLG> JPNHLGPJNHO, ICKBLEKALJF P_1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x75E0E40", Offset = "0x75DFE40", VA = "0x1875E0E40")]
	[CompilerGenerated]
	internal static bool BGFOLDCGMLB(FCBKKHIFGAP LDEBJCNGHAE, IKDOJNFJDNC DHAFNIGMBFM, [Out] ODFEIFFKACA OIGHCACKHBF, PKMOPDFPODJ P_3)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public interface CNLGJLNLIAL
{
	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool HNNHJOKHPMH(NKLIIMCFHAI JOHHFLBBCGL, NKLIIMCFHAI FJMBNABCBLN, IEnumerable<NKLIIMCFHAI> LKGFNJMMNFB, [Out] MHGEKCLKOFO IBAGIIOFHIK, [Out] KMCLKGMHJJP GDDLMEBNLCH);

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(Slot = "1")]
	string NHLBDEHIPKM(KMCLKGMHJJP CAGLHPLGLCI);
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public enum KMCLKGMHJJP : byte
{
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	InsufficientPermission,
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	DisabledByRoom,
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	CantKickEventOrganizer,
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	Broadcaster,
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	GameInProgress,
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	OpponentGameInProgress
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
internal class MKNEEGDGKAO : CNLGJLNLIAL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	private readonly OEEIHCNKFII KJFGEFGBAJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	private readonly GNGMGCOCMMC ICLIAJGEEGI;

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x8C0B80", Offset = "0x8BFB80", VA = "0x1808C0B80")]
	[RecRoom.NoEngine.Common.Preserve]
	public MKNEEGDGKAO([GAHPILLNNBL(null)] OEEIHCNKFII ALEFFBOCKIE, [GAHPILLNNBL(null)] GNGMGCOCMMC COLEEALMCGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x75EB4F0", Offset = "0x75EA4F0", VA = "0x1875EB4F0")]
	private static BDPFDGINDPN? PGBPAJAGLOM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x75EACE0", Offset = "0x75E9CE0", VA = "0x1875EACE0", Slot = "4")]
	public bool HNNHJOKHPMH(NKLIIMCFHAI JOHHFLBBCGL, NKLIIMCFHAI FJMBNABCBLN, IEnumerable<NKLIIMCFHAI> LKGFNJMMNFB, [Out] MHGEKCLKOFO IBAGIIOFHIK, [Out] KMCLKGMHJJP GDDLMEBNLCH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x75EB3F0", Offset = "0x75EA3F0", VA = "0x1875EB3F0", Slot = "5")]
	public string NHLBDEHIPKM(KMCLKGMHJJP CAGLHPLGLCI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x75EADE0", Offset = "0x75E9DE0", VA = "0x1875EADE0")]
	internal bool KCFBCIFCIOJ(NKLIIMCFHAI JOHHFLBBCGL, NKLIIMCFHAI FJMBNABCBLN, IEnumerable<NKLIIMCFHAI> LKGFNJMMNFB, CDBHFDKLKGA DOIEOJODELN, BDPFDGINDPN? GOIBGAPOHMA, [Out] MHGEKCLKOFO IBAGIIOFHIK, [Out] KMCLKGMHJJP GDDLMEBNLCH)
	{
		return default(bool);
	}
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
