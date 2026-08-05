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
		[Cpp2IlInjected.Address(RVA = "0x8C1980", Offset = "0x8C0380", VA = "0x1808C1980")]
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
		[Cpp2IlInjected.Address(RVA = "0x737CCE0", Offset = "0x737B6E0", VA = "0x18737CCE0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x8C2AE0", Offset = "0x8C14E0", VA = "0x1808C2AE0")]
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
		[Cpp2IlInjected.Address(RVA = "0x8C2B20", Offset = "0x8C1520", VA = "0x1808C2B20")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public enum FMJKFFDODPG
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
	public class _AssemblyIndex : PBJLLMOALLO
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x737D4C0", Offset = "0x737BEC0", VA = "0x18737D4C0", Slot = "8")]
		public override void BHEMPDPJNII(CGCPPALGHJA registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x632F010", Offset = "0x632DA10", VA = "0x18632F010")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public delegate void MMHFDHHJEIO<TPermission>(TPermission LEFCHIAHDPM);
[Cpp2IlInjected.Token(Token = "0x2000008")]
public delegate void PKJINFCAKOB(PDPPFLAPOCL JDDNDMPDAKN);
[Cpp2IlInjected.Token(Token = "0x2000009")]
public enum BIINPDBFLJA
{
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	Off,
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	Hosts,
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	Everyone
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface AKOLKDEAGPF
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool OIAFFMDLNBD
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	bool PICOLHJNDCN
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	bool AGNEAPNNIGA
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool IEGKBEPMGLB
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	bool CNMBGGGLNFO
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	bool KDNHHNLNHDO
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
internal static class EHFEPFBJIOL
{
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[Flags]
	public enum KBHMALAAALO
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
	public static readonly Guid KPGHBLCBKNF;

	[Cpp2IlInjected.Token(Token = "0x400000C")]
	public static readonly Guid EDGCGKGOPBA;

	[Cpp2IlInjected.Token(Token = "0x400000D")]
	public static readonly Guid HGHEHKBJPGJ;

	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public static readonly Guid MILEIHMLLOP;

	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public static readonly Guid JNCNMADAIJC;

	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public static readonly Guid NBNOJDELBLG;

	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private static readonly HHBOELANGID<HFNNEAJJBFG, Guid> OIDGIPLMDLJ;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	internal static IEnumerable<HFNNEAJJBFG> MIAEFHLIGDO
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x7375D80", Offset = "0x7374780", VA = "0x187375D80")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x7375C60", Offset = "0x7374660", VA = "0x187375C60")]
	public static HFNNEAJJBFG AKEJKHOMDDE(Guid GDCMEHKEAMI)
	{
		return default(HFNNEAJJBFG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x7375FC0", Offset = "0x73749C0", VA = "0x187375FC0")]
	public static Guid POGJHKEANFC(HFNNEAJJBFG IKPBJLKHJKL)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x7375CF0", Offset = "0x73746F0", VA = "0x187375CF0")]
	public static bool FOMMCLPGKHB(HFNNEAJJBFG IKPBJLKHJKL, [Out] Guid GDCMEHKEAMI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x7375EE0", Offset = "0x73748E0", VA = "0x187375EE0")]
	public static bool OMPGCHAOMFN(Guid GDCMEHKEAMI, [Out] HFNNEAJJBFG IKPBJLKHJKL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x7375F80", Offset = "0x7374980", VA = "0x187375F80")]
	public static HFNNEAJJBFG OPBDNFCFDOJ(HFNNEAJJBFG IKPBJLKHJKL)
	{
		return default(HFNNEAJJBFG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x7375DF0", Offset = "0x73747F0", VA = "0x187375DF0")]
	public static KBHMALAAALO JPEOMHOKAAB(HFNNEAJJBFG AKCLOKLEHPL)
	{
		return default(KBHMALAAALO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x7375EA0", Offset = "0x73748A0", VA = "0x187375EA0")]
	internal static HFNNEAJJBFG NDEJLIEJJHK(KBHMALAAALO MPEEDFGJHGK)
	{
		return default(HFNNEAJJBFG);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface CCCNHCCNHAA : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000008")]
	IGNDBCCAMKK BHMPLMDPNNE
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	IEnumerable<IFLHCANCNLC> JAJOFHLKPDM
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event PKJINFCAKOB NAIOOKDGJIH;

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	IReadOnlyList<IFLHCANCNLC> CEALBHDGCJA(bool CIPGPACPIJP = false);

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(Slot = "5")]
	IFLHCANCNLC AEAEPHPJCCJ(PDPPFLAPOCL JDDNDMPDAKN);

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool EAGEBHLOEEE(PDPPFLAPOCL JDDNDMPDAKN);

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(Slot = "7")]
	IReadOnlyList<IFLHCANCNLC> EHLFEHJKABL(PDPPFLAPOCL JDDNDMPDAKN, bool PJKGDAGLDJL = false);

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool MGFJCDMIHKA(PDPPFLAPOCL MIDHKBKKKKN, HFNNEAJJBFG IKPBJLKHJKL);

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "9")]
	IFLHCANCNLC CCCEJCOCDKK(HFNNEAJJBFG IKPBJLKHJKL);

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "10")]
	bool CKDDMGACOLE<T>(HFNNEAJJBFG IKPBJLKHJKL, EOHLKKLFGPK LEFCHIAHDPM, bool AOFHMNBLLIM, T IOBLLEKOCNN, [Optional] Action IEJEEFGEIHJ) where T : notnull;

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(Slot = "11")]
	string CDCEGBGJCMB(EOHLKKLFGPK LEFCHIAHDPM);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface OCJOAOOBLDD
{
	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task BDLNNECAKFK(ANPHFBDJECI LLAPGPIJJLB, CancellationToken IONNNJNKLMJ);

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OCMNECECGGC(ANPHFBDJECI LLAPGPIJJLB);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface NBODDKCENDJ
{
	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	PDPPFLAPOCL BBCDFEPIACG
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	KHOOKALDLHN PCBILONHKIP
	{
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	LGKHNIEIJHC BEMILBPFDBH
	{
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event Action<AFMJJDEJELI> MDGCOGBAMFE;

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event Action HDANNCCLMAN;

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(Slot = "4")]
	HFNNEAJJBFG CDPBAPNDIJL(PDPPFLAPOCL JDDNDMPDAKN);

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "5")]
	Task<AFMJJDEJELI> DAECCFNCGOD(CancellationToken IONNNJNKLMJ);

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(Slot = "6")]
	Task MLDKAIJNGKL(long FNKMOIJJLLC, IReadOnlyList<FPDICOEILEC> EKOGLCEFECK);

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(Slot = "7")]
	Task MBALANIBMAI(long FNKMOIJJLLC, long KAEOEGGGCFM, IReadOnlyList<FPDICOEILEC> EKOGLCEFECK);

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(Slot = "9")]
	IEnumerable<PDPPFLAPOCL> GACLHOJDJIM();
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public static class NMIJPAIHNKO
{
	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x737C110", Offset = "0x737AB10", VA = "0x18737C110")]
	public static HFNNEAJJBFG CCGILANHMLE(this NBODDKCENDJ IPPPCAMKOGF)
	{
		return default(HFNNEAJJBFG);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public interface NKLDLJMJHKK<TPermission> where TPermission : notnull
{
	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	string CMHKCEEJFEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	event MMHFDHHJEIO<TPermission> HAIPFDLDBOD;
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
internal abstract class NLMPGKGPLFP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	internal object? HAJJFKEOIAL;

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public object? BJEDDKIOPJH
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x737BE40", Offset = "0x737A840", VA = "0x18737BE40")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x737BF10", Offset = "0x737A910", VA = "0x18737BF10")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x737C010", Offset = "0x737AA10", VA = "0x18737C010")]
	protected NLMPGKGPLFP(object? HKGNMKAPJOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract bool OMPLFGPAEBL(object? KLABJGGMBGH);
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
internal class JDBOLOLCBDG<T> : NLMPGKGPLFP where T : notnull, new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private readonly IEqualityComparer<T> NBGPDLBENLO;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public T PGPGCBGPPOH
	{
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x42701E0", Offset = "0x426EBE0", VA = "0x1842701E0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x4270C00", Offset = "0x426F600", VA = "0x184270C00", Slot = "4")]
	public override bool OMPLFGPAEBL(object? KLABJGGMBGH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x42705B0", Offset = "0x426EFB0", VA = "0x1842705B0")]
	public bool AKDCIHBJFJC(T PHKNMBJOKNO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x4270F40", Offset = "0x426F940", VA = "0x184270F40")]
	public JDBOLOLCBDG(T MCAGMGIJFIA, IEqualityComparer<T> NBGPDLBENLO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
internal class IBDKBDHOMPM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private readonly Dictionary<EOHLKKLFGPK, bool> CMDENCNGACH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private readonly Dictionary<EOHLKKLFGPK, NLMPGKGPLFP> AGBPACHHOCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private readonly LAPGBHGMBBJ IADKPADJHAA;

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x7376ED0", Offset = "0x73758D0", VA = "0x187376ED0")]
	public IBDKBDHOMPM(LAPGBHGMBBJ IADKPADJHAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x7376920", Offset = "0x7375320", VA = "0x187376920")]
	public bool EGNFNLBOOHL(EOHLKKLFGPK LEFCHIAHDPM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x2DF09F0", Offset = "0x2DEF3F0", VA = "0x182DF09F0")]
	public bool LLGPNHEJJKJ<T>(EOHLKKLFGPK LEFCHIAHDPM, bool AOFHMNBLLIM, T KLABJGGMBGH) where T : notnull, new()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x2DF0550", Offset = "0x2DEEF50", VA = "0x182DF0550")]
	public (bool, T?) IBGDEPCKEAP<T>(EOHLKKLFGPK LEFCHIAHDPM) where T : new()
	{
		return default((bool, T));
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x7376DF0", Offset = "0x73757F0", VA = "0x187376DF0")]
	public bool LLGPNHEJJKJ(EOHLKKLFGPK LEFCHIAHDPM, bool AOFHMNBLLIM, object KLABJGGMBGH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x7376990", Offset = "0x7375390", VA = "0x187376990")]
	public (bool, object) IBGDEPCKEAP(EOHLKKLFGPK LEFCHIAHDPM)
	{
		return default((bool, object));
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x2DF0F70", Offset = "0x2DEF970", VA = "0x182DF0F70")]
	private void LOHPIBIJKHA<T>(EOHLKKLFGPK LEFCHIAHDPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x7376B20", Offset = "0x7375520", VA = "0x187376B20")]
	private NLMPGKGPLFP IMBOOFOJMLN(EOHLKKLFGPK LEFCHIAHDPM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x7376BF0", Offset = "0x73755F0", VA = "0x187376BF0")]
	public void JHKHDODFLLH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
internal class LGKKONHBOAK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public readonly string IGLNGGCKCNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public readonly Type KMLDJDKAICD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public readonly PAFLHJKPKNO KHANFKJAJEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public readonly EOHLKKLFGPK KPJOHGMGCEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public AGADBBNOOEL HJODBIMLOGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public DJPJFKGBMEI FGHEJOMGHED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public ADEBAPEEJCL INPKIJCDAHK;

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x73799E0", Offset = "0x73783E0", VA = "0x1873799E0")]
	public LGKKONHBOAK(Type NBKCHPLEKMN, string LHJGOMAMPPA, EOHLKKLFGPK LEFCHIAHDPM, AGADBBNOOEL NMJJDOEMMBH, DJPJFKGBMEI ABHONLIJBAP, ADEBAPEEJCL BDAFPDGEBBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x73798E0", Offset = "0x73782E0", VA = "0x1873798E0")]
	public object BPBOGJBJDAF(object? PLNBHPCFEOK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x2E4EB80", Offset = "0x2E4D580", VA = "0x182E4EB80")]
	public void LOHPIBIJKHA<T>()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x7379930", Offset = "0x7378330", VA = "0x187379930")]
	public void LOHPIBIJKHA(Type IHBEJNPOKCH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
internal class OMCKHBLOCAC<T> : LGKKONHBOAK where T : new()
{
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	internal delegate string JKDGMKHLEBE(T KLABJGGMBGH);

	[Cpp2IlInjected.Token(Token = "0x2000018")]
	internal delegate T EDGIIEIEHPO(string? OOANKEFNOJL, T MCAGMGIJFIA);

	[Cpp2IlInjected.Token(Token = "0x2000019")]
	[CompilerGenerated]
	private sealed class FHNJEBHNJBE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public JKDGMKHLEBE serializeRecNetString;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public EDGIIEIEHPO parseRecNetString;

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x8A32C0", Offset = "0x8A1CC0", VA = "0x1808A32C0")]
		public FHNJEBHNJBE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x3DF5AD0", Offset = "0x3DF44D0", VA = "0x183DF5AD0")]
		internal string KADFCEPNOJB(object? v)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x3DF5950", Offset = "0x3DF4350", VA = "0x183DF5950")]
		internal object IFEFHMAMNCA(string? s, object d)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x49065B0", Offset = "0x4904FB0", VA = "0x1849065B0")]
	public OMCKHBLOCAC(EOHLKKLFGPK LEFCHIAHDPM, string LHJGOMAMPPA, [Optional] JKDGMKHLEBE? NMJJDOEMMBH, [Optional] EDGIIEIEHPO? ABHONLIJBAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x4905C10", Offset = "0x4904610", VA = "0x184905C10")]
	private static object? CENBFOHJAFB(EDGIIEIEHPO? ABHONLIJBAP, string? OOANKEFNOJL, object? MCAGMGIJFIA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x4905340", Offset = "0x4903D40", VA = "0x184905340")]
	private static string AMCHBAGBIFH(JKDGMKHLEBE? DDALIOAEHEH, object? KLABJGGMBGH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
internal delegate string AGADBBNOOEL(object? KLABJGGMBGH);
[Cpp2IlInjected.Token(Token = "0x200001C")]
internal delegate object DJPJFKGBMEI(string? OOANKEFNOJL, [Optional] object MCAGMGIJFIA);
[Cpp2IlInjected.Token(Token = "0x200001D")]
internal delegate NLMPGKGPLFP ADEBAPEEJCL();
[Cpp2IlInjected.Token(Token = "0x200001E")]
internal class LAPGBHGMBBJ
{
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	private class NAECLPNJGGD : IEqualityComparer<List<string>>
	{
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		internal static NAECLPNJGGD DFEEMNKDOMA;

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x737BB10", Offset = "0x737A510", VA = "0x18737BB10", Slot = "4")]
		public bool Equals(List<string> NCPIGLMANIM, List<string> DJBPOPBDKAJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x737BC60", Offset = "0x737A660", VA = "0x18737BC60", Slot = "5")]
		public int GetHashCode(List<string> GHMNBJIOGAM)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x8A32C0", Offset = "0x8A1CC0", VA = "0x1808A32C0")]
		public NAECLPNJGGD()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000020")]
	private class GBPBDIPLKLF : KOJKMHEJMIH<FMJKFFDODPG>
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x7376350", Offset = "0x7374D50", VA = "0x187376350", Slot = "9")]
		public override string AMCHBAGBIFH(FMJKFFDODPG DIGEGMNKCOG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x7376440", Offset = "0x7374E40", VA = "0x187376440", Slot = "10")]
		protected override bool NCNIDKADMIM(string DIGEGMNKCOG, [Out] FMJKFFDODPG KLABJGGMBGH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x7376620", Offset = "0x7375020", VA = "0x187376620")]
		public GBPBDIPLKLF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private static readonly CLEGOEPPJBC BJBJOKIKBPO;

	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private static readonly GBPBDIPLKLF IFGMAKOOLEF;

	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private static readonly List<LGKKONHBOAK> ONIAKIEJDFN;

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public IEnumerable<EOHLKKLFGPK> ANKEAJNGIIP
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x8961B0", Offset = "0x894BB0", VA = "0x1808961B0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public IReadOnlyDictionary<EOHLKKLFGPK, LGKKONHBOAK> HAEPFIKFDHM
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x899050", Offset = "0x897A50", VA = "0x180899050")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x73795C0", Offset = "0x7377FC0", VA = "0x1873795C0")]
	public LAPGBHGMBBJ([Optional] IList<LGKKONHBOAK>? OKHMOFGDLBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x73780C0", Offset = "0x7376AC0", VA = "0x1873780C0")]
	public LGKKONHBOAK AKDGDEKKLDI(EOHLKKLFGPK LEFCHIAHDPM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public interface IGNDBCCAMKK
{
	[Cpp2IlInjected.Token(Token = "0x17000012")]
	IFLHCANCNLC MLLFLOIKNHG
	{
		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
internal class EAKBOPCLEOP : IGNDBCCAMKK
{
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public static EAKBOPCLEOP JIEONBCBMAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	internal readonly MMAJGKCEHKJ BAKGMNLLKHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	internal readonly IReadOnlyList<MMAJGKCEHKJ> EFLACCMFOPK;

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public IFLHCANCNLC MLLFLOIKNHG
	{
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x8961B0", Offset = "0x894BB0", VA = "0x1808961B0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x7375850", Offset = "0x7374250", VA = "0x187375850")]
	public EAKBOPCLEOP(MMAJGKCEHKJ PIHGMBLNCCN, IReadOnlyList<MMAJGKCEHKJ> OLDHOJOBADB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x7374A10", Offset = "0x7373410", VA = "0x187374A10")]
	private static EAKBOPCLEOP GNAPJJODKLL()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public static class EDKIBCJDKHA
{
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public static readonly IReadOnlyList<HFNNEAJJBFG> GLJJFBMDKNH;

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x73759E0", Offset = "0x73743E0", VA = "0x1873759E0")]
	public static bool ECJFNKNCOFF(this PDPPFLAPOCL MBAGFJGPJPM, HFNNEAJJBFG IKPBJLKHJKL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x7375960", Offset = "0x7374360", VA = "0x187375960")]
	public static bool DHCLCOBFNII(this PDPPFLAPOCL MBAGFJGPJPM, HFNNEAJJBFG IKPBJLKHJKL, LGKHNIEIJHC HLNFJPOGDHL)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public interface FFEEJKDGGND
{
	[Cpp2IlInjected.Token(Token = "0x17000014")]
	bool COFJLPKAFLA
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	bool HOAPMBJADIH
	{
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	bool CCFJBFEEGCL
	{
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	bool EPAHCKODHHK
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	bool AEAFJNDGGJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	bool INBOPNFKDDE
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	bool PJDIDEEGIKO
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	bool HANLHHHODHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	bool JEMKFJGIFED
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	bool DIOHHGHOAPK
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	bool NBOGFGNPPEM
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	bool OHEIJIAJHLC
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	IReadOnlyList<string> EBAMNHGHECM
	{
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	FMJKFFDODPG FFIKDNOAOOF
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public interface IFLHCANCNLC : FFEEJKDGGND, AKOLKDEAGPF, NKLDLJMJHKK<EOHLKKLFGPK>
{
	[Cpp2IlInjected.Token(Token = "0x17000022")]
	string FEIMGKBMACL
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	HFNNEAJJBFG AJIPIOMIEED
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(Slot = "2")]
	(bool, T?) IEGIPHMDKLE<T>(EOHLKKLFGPK LEFCHIAHDPM) where T : new();
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public enum EOHLKKLFGPK
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
internal class MMAJGKCEHKJ : IFLHCANCNLC, FFEEJKDGGND, AKOLKDEAGPF, NKLDLJMJHKK<EOHLKKLFGPK>
{
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	internal static readonly LAPGBHGMBBJ EPIADIAFCML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	internal readonly IBDKBDHOMPM ALBBLGPCALD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private string? BBOODOOGLHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private string? PLGLPFCDGML;

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	private bool GPCFAHIIIFO
	{
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x7379E10", Offset = "0x7378810", VA = "0x187379E10", Slot = "23")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	private bool PMKOBEGEAKD
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x737B280", Offset = "0x7379C80", VA = "0x18737B280", Slot = "22")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	private bool CIKEDBNGIMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x7379F00", Offset = "0x7378900", VA = "0x187379F00", Slot = "21")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	private bool AKNEOLOBAOO
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x7379EB0", Offset = "0x73788B0", VA = "0x187379EB0", Slot = "24")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	private bool NMDBGCHILON
	{
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x737B180", Offset = "0x7379B80", VA = "0x18737B180", Slot = "26")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	private bool BMKKJAEBGNL
	{
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x737A650", Offset = "0x7379050", VA = "0x18737A650", Slot = "25")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public HFNNEAJJBFG AJIPIOMIEED
	{
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0xAC0390", Offset = "0xABED90", VA = "0x180AC0390", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(HFNNEAJJBFG);
		}
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x8A08A0", Offset = "0x89F2A0", VA = "0x1808A08A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public string CMHKCEEJFEB
	{
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x737B020", Offset = "0x7379A20", VA = "0x18737B020", Slot = "29")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x7379A80", Offset = "0x7378480", VA = "0x187379A80")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public string FEIMGKBMACL
	{
		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x737B020", Offset = "0x7379A20", VA = "0x18737B020", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public bool IGGCMOEDLJN
	{
		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x941870", Offset = "0x940270", VA = "0x180941870")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0xC378D0", Offset = "0xC362D0", VA = "0x180C378D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public bool COFJLPKAFLA
	{
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x737B730", Offset = "0x737A130", VA = "0x18737B730", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public FMJKFFDODPG FFIKDNOAOOF
	{
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x737B0C0", Offset = "0x7379AC0", VA = "0x18737B0C0", Slot = "20")]
		get
		{
			return default(FMJKFFDODPG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public bool HOAPMBJADIH
	{
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x7379FB0", Offset = "0x73789B0", VA = "0x187379FB0", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public bool CCFJBFEEGCL
	{
		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x737B830", Offset = "0x737A230", VA = "0x18737B830", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public bool EPAHCKODHHK
	{
		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x7379E60", Offset = "0x7378860", VA = "0x187379E60", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public bool AEAFJNDGGJI
	{
		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x737B070", Offset = "0x7379A70", VA = "0x18737B070", Slot = "11")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public bool INBOPNFKDDE
	{
		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x737B110", Offset = "0x7379B10", VA = "0x18737B110", Slot = "12")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public bool PJDIDEEGIKO
	{
		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x737A600", Offset = "0x7379000", VA = "0x18737A600", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public bool HANLHHHODHO
	{
		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x737B3D0", Offset = "0x7379DD0", VA = "0x18737B3D0", Slot = "14")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public bool JEMKFJGIFED
	{
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x737A4D0", Offset = "0x7378ED0", VA = "0x18737A4D0", Slot = "15")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public IReadOnlyList<string> EBAMNHGHECM
	{
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x7379F50", Offset = "0x7378950", VA = "0x187379F50", Slot = "19")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public bool EOFMOLBKMFI
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x7379E10", Offset = "0x7378810", VA = "0x187379E10", Slot = "30")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public bool IEFDNNEAHEK
	{
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x737B180", Offset = "0x7379B80", VA = "0x18737B180", Slot = "31")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public bool DOLNKNPNIAN
	{
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x737B280", Offset = "0x7379C80", VA = "0x18737B280", Slot = "32")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public bool DIOHHGHOAPK
	{
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x737B420", Offset = "0x7379E20", VA = "0x18737B420", Slot = "16")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public bool NBOGFGNPPEM
	{
		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x7379AD0", Offset = "0x73784D0", VA = "0x187379AD0", Slot = "17")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public bool FHHKNDCONFA
	{
		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x7379F00", Offset = "0x7378900", VA = "0x187379F00", Slot = "33")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public bool OHEIJIAJHLC
	{
		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x737A520", Offset = "0x7378F20", VA = "0x18737A520", Slot = "18")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public bool DDICGMHJNNB
	{
		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x7379EB0", Offset = "0x73788B0", VA = "0x187379EB0", Slot = "34")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public bool NAIKJHKDFBL
	{
		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x737A650", Offset = "0x7379050", VA = "0x18737A650", Slot = "35")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	public event MMHFDHHJEIO<EOHLKKLFGPK> HAIPFDLDBOD
	{
		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x737B780", Offset = "0x737A180", VA = "0x18737B780", Slot = "27")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x737B1D0", Offset = "0x7379BD0", VA = "0x18737B1D0", Slot = "28")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x2E82AD0", Offset = "0x2E814D0", VA = "0x182E82AD0", Slot = "6")]
	public (bool, T?) IEGIPHMDKLE<T>(EOHLKKLFGPK LEFCHIAHDPM) where T : new()
	{
		return default((bool, T));
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x2E82A70", Offset = "0x2E81470", VA = "0x182E82A70")]
	public MMAJGKCEHKJ AGBEIIJBLGC<T>(EOHLKKLFGPK LEFCHIAHDPM, bool AOFHMNBLLIM, T KLABJGGMBGH) where T : notnull, new()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x737B920", Offset = "0x737A320", VA = "0x18737B920")]
	public MMAJGKCEHKJ(HFNNEAJJBFG IKPBJLKHJKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x737B900", Offset = "0x737A300", VA = "0x18737B900")]
	public MMAJGKCEHKJ(HFNNEAJJBFG IKPBJLKHJKL, [Optional] string? BBOODOOGLHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x737B940", Offset = "0x737A340", VA = "0x18737B940")]
	public MMAJGKCEHKJ(MMAJGKCEHKJ FIDABDMJLID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x737B9C0", Offset = "0x737A3C0", VA = "0x18737B9C0")]
	internal MMAJGKCEHKJ(HFNNEAJJBFG KNKNPPCOIIB, [Optional] string? BBOODOOGLHI, [Optional] MMAJGKCEHKJ? FIDABDMJLID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x737B4C0", Offset = "0x7379EC0", VA = "0x18737B4C0")]
	public static PAFLHJKPKNO OGAOOKECBDL(EOHLKKLFGPK LEFCHIAHDPM)
	{
		return default(PAFLHJKPKNO);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x737B160", Offset = "0x7379B60", VA = "0x18737B160")]
	public void JHKHDODFLLH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x7379B20", Offset = "0x7378520", VA = "0x187379B20")]
	internal MMAJGKCEHKJ BGHBPLODFDC(MMAJGKCEHKJ FDFNDBLKCKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x737A0E0", Offset = "0x7378AE0", VA = "0x18737A0E0")]
	internal IReadOnlyCollection<EOHLKKLFGPK> DODCOAEGADP(MMAJGKCEHKJ FIDABDMJLID)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x737A000", Offset = "0x7378A00", VA = "0x18737A000")]
	public bool DMGOIIJNNCC(EOHLKKLFGPK LEFCHIAHDPM, bool AOFHMNBLLIM, string FIDECJMONGH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x737B2D0", Offset = "0x7379CD0", VA = "0x18737B2D0")]
	public (bool, string) KHOBPOGICPL(EOHLKKLFGPK LEFCHIAHDPM)
	{
		return default((bool, string));
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x737B470", Offset = "0x7379E70", VA = "0x18737B470")]
	internal void NEECIEODNLP(EOHLKKLFGPK LEFCHIAHDPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x737B530", Offset = "0x7379F30", VA = "0x18737B530")]
	public MIHLFAECCOH OHNLHFDAOKO(Func<HFNNEAJJBFG, Guid> PCALKMKBDNC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x737A6A0", Offset = "0x73790A0", VA = "0x18737A6A0")]
	public void HDBIEKDLOJA(MIHLFAECCOH LKBGPBNFBLO, Func<Guid, HFNNEAJJBFG> AADNKDJBHGJ, [Optional] HFNNEAJJBFG? FKLCIOLGKME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x737A570", Offset = "0x7378F70", VA = "0x18737A570")]
	[CompilerGenerated]
	private void FLBJMKAJLEC(EOHLKKLFGPK EEAEOFCBMAC, CEJLGIIMCHG COJIMPBDIAM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public class BDFLEGPINGC : OCJOAOOBLDD, CCCNHCCNHAA, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	[CompilerGenerated]
	private sealed class GGMCKKFFAHL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		public MMAJGKCEHKJ newRole;

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x8A32C0", Offset = "0x8A1CC0", VA = "0x1808A32C0")]
		public GGMCKKFFAHL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x7376660", Offset = "0x7375060", VA = "0x187376660")]
		internal bool BNLLAGAJIMP(MMAJGKCEHKJ rc)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002D")]
	[CompilerGenerated]
	private sealed class ICFNCFFPLFI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		public HFNNEAJJBFG roleTypeToUpdate;

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x8A32C0", Offset = "0x8A1CC0", VA = "0x1808A32C0")]
		public ICFNCFFPLFI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x7377180", Offset = "0x7375B80", VA = "0x187377180")]
		internal bool OKDBJFEPEJC(HFNNEAJJBFG r)
		{
			return default(bool);
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[CompilerGenerated]
	private struct KHFBMCBHGFC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public BDFLEGPINGC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		public ANPHFBDJECI roomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		private bool <isOffline>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		private TaskAwaiter<AFMJJDEJELI> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x73779F0", Offset = "0x73763F0", VA = "0x1873779F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x7378060", Offset = "0x7376A60", VA = "0x187378060", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[CompilerGenerated]
	private sealed class HCLDIOPIKBP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		public StringBuilder migrationMessageBuilder;

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x8A32C0", Offset = "0x8A1CC0", VA = "0x1808A32C0")]
		public HCLDIOPIKBP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x7376840", Offset = "0x7375240", VA = "0x187376840")]
		internal void OGMMDEBLBKG(MIHLFAECCOH r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x7376720", Offset = "0x7375120", VA = "0x187376720")]
		internal void JCLBEFPNKJI(MIHLFAECCOH r)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	[CompilerGenerated]
	private struct NKNNBDNFHNG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		public ANPHFBDJECI roomData;
	}

	[Cpp2IlInjected.Token(Token = "0x2000031")]
	[CompilerGenerated]
	private sealed class HBPJHCECGPL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		public Func<MIHLFAECCOH, CEJLGIIMCHG> dataFunc;

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x8A32C0", Offset = "0x8A1CC0", VA = "0x1808A32C0")]
		public HBPJHCECGPL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x7376690", Offset = "0x7375090", VA = "0x187376690")]
		internal void EBHHMOCJKDP(MIHLFAECCOH r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x73766C0", Offset = "0x73750C0", VA = "0x1873766C0")]
		internal void MLHHDNLMEMO(MIHLFAECCOH r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x73766F0", Offset = "0x73750F0", VA = "0x1873766F0")]
		internal void OBAELJBKLEN(MIHLFAECCOH r)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000032")]
	[CompilerGenerated]
	private sealed class AEKAPDMELEH<T> where T : notnull
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
			public AEKAPDMELEH<T> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400009C")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400009D")]
			private TaskAwaiter<AFMJJDEJELI> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x6000114")]
			[Cpp2IlInjected.Address(RVA = "0x3762D50", Offset = "0x3761750", VA = "0x183762D50", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000115")]
			[Cpp2IlInjected.Address(RVA = "0x8E5A10", Offset = "0x8E4410", VA = "0x1808E5A10", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		public EOHLKKLFGPK rolePermission;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		public HFNNEAJJBFG accountRoleType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		public bool overrides;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		public PAFLHJKPKNO recNetPermissionType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		public string serializedNewValue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		public BDFLEGPINGC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		public Action onComplete;

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x8A32C0", Offset = "0x8A1CC0", VA = "0x1808A32C0")]
		public AEKAPDMELEH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x3E7B1E0", Offset = "0x3E79BE0", VA = "0x183E7B1E0")]
		[AsyncStateMachine(typeof(AEKAPDMELEH<>.<<LocalRequestModifyRolePermission>g__ChangeAndRefresh|0>d))]
		internal void GBBCFNJPEPI()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	[CompilerGenerated]
	private struct CAILEFFGLIA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		public IReadOnlyList<FPDICOEILEC> newPermissionOverrides;
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	[CompilerGenerated]
	private struct NOLEKPKFFHH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		public NBODDKCENDJ rolesDataProvider;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		public ANPHFBDJECI roomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public IReadOnlyDictionary<HFNNEAJJBFG, MMAJGKCEHKJ> defaultRoles;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		public CICIOHJMEBM debugLogger;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x737C170", Offset = "0x737AB70", VA = "0x18737C170", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x737CC80", Offset = "0x737B680", VA = "0x18737CC80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private readonly NBODDKCENDJ IPPPCAMKOGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private readonly EAKBOPCLEOP CHNBBEHJILM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private readonly CICIOHJMEBM LONCLMCGANJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private readonly Dictionary<int, MMAJGKCEHKJ> KCDLOKHDLOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	internal readonly Dictionary<HFNNEAJJBFG, MMAJGKCEHKJ> EOLMEPPMBMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	internal readonly Dictionary<HFNNEAJJBFG, MMAJGKCEHKJ> CKJDLCINMPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	internal readonly List<MMAJGKCEHKJ> MOFINOHOLKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private bool DEJNLINBLJK;

	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private static readonly EOHLKKLFGPK[] BFGFCNCNGJJ;

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public IGNDBCCAMKK BHMPLMDPNNE
	{
		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x899050", Offset = "0x897A50", VA = "0x180899050", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public IEnumerable<IFLHCANCNLC> JAJOFHLKPDM
	{
		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x7372A40", Offset = "0x7371440", VA = "0x187372A40", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	public event PKJINFCAKOB NAIOOKDGJIH
	{
		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x7373690", Offset = "0x7372090", VA = "0x187373690", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x7371680", Offset = "0x7370080", VA = "0x187371680", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x7373000", Offset = "0x7371A00", VA = "0x187373000")]
	[DJINMBCHLNM.BKIMOKOFNKD]
	internal static void LJBMCKAFLEE(JEFLJDHAGDI FMBOKBBFBFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x7374750", Offset = "0x7373150", VA = "0x187374750")]
	[UnityEngine.Scripting.Preserve]
	internal BDFLEGPINGC([OLJNBPOCBCJ(null)] NBODDKCENDJ CHKPFDMMLJA, [OLJNBPOCBCJ(null)] EAKBOPCLEOP OHMCDDAIOJJ, [OLJNBPOCBCJ(null)] CICIOHJMEBM LONCLMCGANJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x7370F40", Offset = "0x736F940", VA = "0x187370F40", Slot = "18")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x7370020", Offset = "0x736EA20", VA = "0x187370020")]
	private void CDPJLODHOFD(IEnumerable<MMAJGKCEHKJ> EIIAJBKNEHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x7371050", Offset = "0x736FA50", VA = "0x187371050", Slot = "12")]
	public bool EAGEBHLOEEE(PDPPFLAPOCL JDDNDMPDAKN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x7372A30", Offset = "0x7371430", VA = "0x187372A30")]
	private void HDANNCCLMAN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x7372DA0", Offset = "0x73717A0", VA = "0x187372DA0")]
	private void KHPNIAJMILL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x7370890", Offset = "0x736F290", VA = "0x187370890", Slot = "10")]
	public IReadOnlyList<IFLHCANCNLC> CEALBHDGCJA(bool CIPGPACPIJP = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x736F010", Offset = "0x736DA10", VA = "0x18736F010", Slot = "11")]
	public IFLHCANCNLC AEAEPHPJCCJ(PDPPFLAPOCL JDDNDMPDAKN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x7371130", Offset = "0x736FB30", VA = "0x187371130")]
	private HFNNEAJJBFG FIJFPHLEGOA(PDPPFLAPOCL JDDNDMPDAKN)
	{
		return default(HFNNEAJJBFG);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x73731B0", Offset = "0x7371BB0", VA = "0x1873731B0", Slot = "14")]
	public bool MGFJCDMIHKA(PDPPFLAPOCL MIDHKBKKKKN, HFNNEAJJBFG IKPBJLKHJKL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x736FF10", Offset = "0x736E910", VA = "0x18736FF10", Slot = "15")]
	public IFLHCANCNLC CCCEJCOCDKK(HFNNEAJJBFG IKPBJLKHJKL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x7373B10", Offset = "0x7372510", VA = "0x187373B10")]
	private static bool PGIDJFBHCLG(AKMGCDNEIAI FDAOEBFGFKJ, HFNNEAJJBFG IKPBJLKHJKL, [Out] MIHLFAECCOH? OKOBKJCOPMN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x73719B0", Offset = "0x73703B0", VA = "0x1873719B0")]
	private static void GECLCBBHHAB(AKMGCDNEIAI FDAOEBFGFKJ, Action<MIHLFAECCOH> BPKLBHMJAAI, HFNNEAJJBFG HIPJAKODFJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x7371720", Offset = "0x7370120", VA = "0x187371720")]
	private static void GECLCBBHHAB(AKMGCDNEIAI FDAOEBFGFKJ, Action<MIHLFAECCOH> BPKLBHMJAAI, Predicate<HFNNEAJJBFG> IHLKLGIFOEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x7372F90", Offset = "0x7371990", VA = "0x187372F90")]
	private void KMAAKCABBIJ(PDPPFLAPOCL JDDNDMPDAKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x736FDF0", Offset = "0x736E7F0", VA = "0x18736FDF0", Slot = "4")]
	[AsyncStateMachine(typeof(KHFBMCBHGFC))]
	public Task BDLNNECAKFK([CanBeNull] ANPHFBDJECI LLAPGPIJJLB, CancellationToken IONNNJNKLMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x897350", Offset = "0x895D50", VA = "0x180897350", Slot = "5")]
	public void OCMNECECGGC(ANPHFBDJECI LLAPGPIJJLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x736F120", Offset = "0x736DB20", VA = "0x18736F120")]
	private void AIFIENCNFLH(AKMGCDNEIAI HPNNDMILJMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x7372A90", Offset = "0x7371490", VA = "0x187372A90")]
	internal static string JHEFEIPOLED(NBODDKCENDJ IPPPCAMKOGF, ANPHFBDJECI LLAPGPIJJLB, IReadOnlyDictionary<HFNNEAJJBFG, MMAJGKCEHKJ> EOLMEPPMBMD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x7371AA0", Offset = "0x73704A0", VA = "0x187371AA0")]
	private static void GJDAHOGGPKK(ANPHFBDJECI LLAPGPIJJLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x7373340", Offset = "0x7371D40", VA = "0x187373340")]
	private static void MIEKFOHKMKG(AKMGCDNEIAI DKFOFIDBMLN, IReadOnlyDictionary<HFNNEAJJBFG, MMAJGKCEHKJ> EOLMEPPMBMD, StringBuilder PCIIBPBPJJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x7371200", Offset = "0x736FC00", VA = "0x187371200")]
	private static bool FKEHFPADMKJ(string NEFKMOMGCFG, [Out] Guid KMDFBPHNLJN, [Out] HFNNEAJJBFG IKPBJLKHJKL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x7373E40", Offset = "0x7372840", VA = "0x187373E40")]
	private static void PHHCJALOPHL(ANPHFBDJECI LLAPGPIJJLB, StringBuilder PCIIBPBPJJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x2ACFF80", Offset = "0x2ACE980", VA = "0x182ACFF80", Slot = "16")]
	public bool CKDDMGACOLE<T>(HFNNEAJJBFG IKPBJLKHJKL, EOHLKKLFGPK LEFCHIAHDPM, bool AOFHMNBLLIM, T IOBLLEKOCNN, [Optional] Action IEJEEFGEIHJ) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x736FFB0", Offset = "0x736E9B0", VA = "0x18736FFB0", Slot = "17")]
	public string CDCEGBGJCMB(EOHLKKLFGPK LEFCHIAHDPM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x736F460", Offset = "0x736DE60", VA = "0x18736F460")]
	private void BAEIOKAAJED(HFNNEAJJBFG IKPBJLKHJKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x736EFF0", Offset = "0x736D9F0", VA = "0x18736EFF0")]
	private bool ABIDFPHFACN(PDPPFLAPOCL JDDNDMPDAKN, HFNNEAJJBFG IKPBJLKHJKL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x7370910", Offset = "0x736F310", VA = "0x187370910")]
	internal MMAJGKCEHKJ CMPBJCOJAML(PDPPFLAPOCL JDDNDMPDAKN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x7371120", Offset = "0x736FB20", VA = "0x187371120", Slot = "13")]
	public IReadOnlyList<IFLHCANCNLC> EHLFEHJKABL(PDPPFLAPOCL JDDNDMPDAKN, bool PJKGDAGLDJL = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x7372800", Offset = "0x7371200", VA = "0x187372800")]
	internal IReadOnlyList<MMAJGKCEHKJ> GPLNOHGJKHP(PDPPFLAPOCL JDDNDMPDAKN, bool PJKGDAGLDJL = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x736F670", Offset = "0x736E070", VA = "0x18736F670")]
	private void BCFABGGIOAA(AFMJJDEJELI OCGGFMGECFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x7370C60", Offset = "0x736F660", VA = "0x187370C60")]
	private static bool DMMNHLACLNB(MMAJGKCEHKJ JKLGHAJCCAM, IReadOnlyDictionary<HFNNEAJJBFG, MMAJGKCEHKJ> EOLMEPPMBMD, [Out] IReadOnlyList<EOHLKKLFGPK> CDPCMEFGFEP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x7373730", Offset = "0x7372130", VA = "0x187373730")]
	[AsyncStateMachine(typeof(NOLEKPKFFHH))]
	private static Task OOBBEIEOJFP(NBODDKCENDJ IPPPCAMKOGF, ANPHFBDJECI LLAPGPIJJLB, IReadOnlyDictionary<HFNNEAJJBFG, MMAJGKCEHKJ> EOLMEPPMBMD, CICIOHJMEBM LONCLMCGANJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x7373870", Offset = "0x7372270", VA = "0x187373870")]
	[CompilerGenerated]
	internal static void PBLENKFJNAC(Func<MIHLFAECCOH, CEJLGIIMCHG> DHEFCDMFNON, NKNNBDNFHNG P_1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x7371310", Offset = "0x736FD10", VA = "0x187371310")]
	[CompilerGenerated]
	internal static bool FMBMKPHFIPI(HFNNEAJJBFG IKPBJLKHJKL, EOHLKKLFGPK LEFCHIAHDPM, [Out] FPDICOEILEC ONELEJIJMBN, CAILEFFGLIA P_3)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public interface FAJBGJLDCFD
{
	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool CHFOHNKGMGD(PDPPFLAPOCL DPAOKBCPBMN, PDPPFLAPOCL DGMOLOLGOMJ, IEnumerable<PDPPFLAPOCL> ALAJJIMLDON, [Out] FMJKFFDODPG CAJNNOJFHPH, [Out] NHHNHFBEEFP MMKFDMMHFPK);

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(Slot = "1")]
	string HAJLKPAGHMA(NHHNHFBEEFP FCNOMCILCIA);
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public enum NHHNHFBEEFP : byte
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
internal class INBOINGPPBE : FAJBGJLDCFD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	private readonly CCCNHCCNHAA GNBAHMNBGMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	private readonly LHBMCLICBFC LLIINJNDDIL;

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x89CB80", Offset = "0x89B580", VA = "0x18089CB80")]
	[RecRoom.NoEngine.Common.Preserve]
	public INBOINGPPBE([OLJNBPOCBCJ(null)] CCCNHCCNHAA LAJDOPBBKGG, [OLJNBPOCBCJ(null)] LHBMCLICBFC DALBHJFAJKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x7377190", Offset = "0x7375B90", VA = "0x187377190")]
	private static HBBAEPBLNMC? AGHFLFPHGBG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x73777F0", Offset = "0x73761F0", VA = "0x1873777F0", Slot = "4")]
	public bool CHFOHNKGMGD(PDPPFLAPOCL DPAOKBCPBMN, PDPPFLAPOCL DGMOLOLGOMJ, IEnumerable<PDPPFLAPOCL> ALAJJIMLDON, [Out] FMJKFFDODPG CAJNNOJFHPH, [Out] NHHNHFBEEFP MMKFDMMHFPK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x73778F0", Offset = "0x73762F0", VA = "0x1873778F0", Slot = "5")]
	public string HAJLKPAGHMA(NHHNHFBEEFP FCNOMCILCIA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x73771D0", Offset = "0x7375BD0", VA = "0x1873771D0")]
	internal bool BJBAHPAEGCJ(PDPPFLAPOCL DPAOKBCPBMN, PDPPFLAPOCL DGMOLOLGOMJ, IEnumerable<PDPPFLAPOCL> ALAJJIMLDON, LGKHNIEIJHC HLNFJPOGDHL, HBBAEPBLNMC? HFFPAFBHNGM, [Out] FMJKFFDODPG CAJNNOJFHPH, [Out] NHHNHFBEEFP MMKFDMMHFPK)
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
