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
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter, AllowMultiple = false, Inherited = false)]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x72917B0", Offset = "0x728FDB0", VA = "0x1872917B0")]
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
	[Microsoft.CodeAnalysis.Embedded]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	[CompilerGenerated]
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
		[Cpp2IlInjected.Address(RVA = "0x7291F90", Offset = "0x7290590", VA = "0x187291F90", Slot = "8")]
		public override void BHEMPDPJNII(CGCPPALGHJA registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x624B890", Offset = "0x6249E90", VA = "0x18624B890")]
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
		[Cpp2IlInjected.Address(RVA = "0x728A850", Offset = "0x7288E50", VA = "0x18728A850")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x728A730", Offset = "0x7288D30", VA = "0x18728A730")]
	public static HFNNEAJJBFG AKEJKHOMDDE(Guid GDCMEHKEAMI)
	{
		return default(HFNNEAJJBFG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x728AA90", Offset = "0x7289090", VA = "0x18728AA90")]
	public static Guid POGJHKEANFC(HFNNEAJJBFG IKPBJLKHJKL)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x728A7C0", Offset = "0x7288DC0", VA = "0x18728A7C0")]
	public static bool FOMMCLPGKHB(HFNNEAJJBFG IKPBJLKHJKL, [Out] Guid GDCMEHKEAMI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x728A9B0", Offset = "0x7288FB0", VA = "0x18728A9B0")]
	public static bool OMPGCHAOMFN(Guid GDCMEHKEAMI, [Out] HFNNEAJJBFG IKPBJLKHJKL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x728AA50", Offset = "0x7289050", VA = "0x18728AA50")]
	public static HFNNEAJJBFG OPBDNFCFDOJ(HFNNEAJJBFG IKPBJLKHJKL)
	{
		return default(HFNNEAJJBFG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x728A8C0", Offset = "0x7288EC0", VA = "0x18728A8C0")]
	public static KBHMALAAALO JPEOMHOKAAB(HFNNEAJJBFG AKCLOKLEHPL)
	{
		return default(KBHMALAAALO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x728A970", Offset = "0x7288F70", VA = "0x18728A970")]
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
	[Cpp2IlInjected.Address(RVA = "0x7290BE0", Offset = "0x728F1E0", VA = "0x187290BE0")]
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
		[Cpp2IlInjected.Address(RVA = "0x7290910", Offset = "0x728EF10", VA = "0x187290910")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x72909E0", Offset = "0x728EFE0", VA = "0x1872909E0")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x7290AE0", Offset = "0x728F0E0", VA = "0x187290AE0")]
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
		[Cpp2IlInjected.Address(RVA = "0x4198080", Offset = "0x4196680", VA = "0x184198080")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x4198AA0", Offset = "0x41970A0", VA = "0x184198AA0", Slot = "4")]
	public override bool OMPLFGPAEBL(object? KLABJGGMBGH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x4198450", Offset = "0x4196A50", VA = "0x184198450")]
	public bool AKDCIHBJFJC(T PHKNMBJOKNO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x4198DE0", Offset = "0x41973E0", VA = "0x184198DE0")]
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
	[Cpp2IlInjected.Address(RVA = "0x728B9A0", Offset = "0x7289FA0", VA = "0x18728B9A0")]
	public IBDKBDHOMPM(LAPGBHGMBBJ IADKPADJHAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x728B3F0", Offset = "0x72899F0", VA = "0x18728B3F0")]
	public bool EGNFNLBOOHL(EOHLKKLFGPK LEFCHIAHDPM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x2D11240", Offset = "0x2D0F840", VA = "0x182D11240")]
	public bool LLGPNHEJJKJ<T>(EOHLKKLFGPK LEFCHIAHDPM, bool AOFHMNBLLIM, T KLABJGGMBGH) where T : notnull, new()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x2D10DA0", Offset = "0x2D0F3A0", VA = "0x182D10DA0")]
	public (bool, T?) IBGDEPCKEAP<T>(EOHLKKLFGPK LEFCHIAHDPM) where T : new()
	{
		return default((bool, T));
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x728B8C0", Offset = "0x7289EC0", VA = "0x18728B8C0")]
	public bool LLGPNHEJJKJ(EOHLKKLFGPK LEFCHIAHDPM, bool AOFHMNBLLIM, object KLABJGGMBGH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x728B460", Offset = "0x7289A60", VA = "0x18728B460")]
	public (bool, object) IBGDEPCKEAP(EOHLKKLFGPK LEFCHIAHDPM)
	{
		return default((bool, object));
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x2D117C0", Offset = "0x2D0FDC0", VA = "0x182D117C0")]
	private void LOHPIBIJKHA<T>(EOHLKKLFGPK LEFCHIAHDPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x728B5F0", Offset = "0x7289BF0", VA = "0x18728B5F0")]
	private NLMPGKGPLFP IMBOOFOJMLN(EOHLKKLFGPK LEFCHIAHDPM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x728B6C0", Offset = "0x7289CC0", VA = "0x18728B6C0")]
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
	[Cpp2IlInjected.Address(RVA = "0x728E4B0", Offset = "0x728CAB0", VA = "0x18728E4B0")]
	public LGKKONHBOAK(Type NBKCHPLEKMN, string LHJGOMAMPPA, EOHLKKLFGPK LEFCHIAHDPM, AGADBBNOOEL NMJJDOEMMBH, DJPJFKGBMEI ABHONLIJBAP, ADEBAPEEJCL BDAFPDGEBBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x728E3B0", Offset = "0x728C9B0", VA = "0x18728E3B0")]
	public object BPBOGJBJDAF(object? PLNBHPCFEOK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x2D6F3D0", Offset = "0x2D6D9D0", VA = "0x182D6F3D0")]
	public void LOHPIBIJKHA<T>()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x728E400", Offset = "0x728CA00", VA = "0x18728E400")]
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
		[Cpp2IlInjected.Address(RVA = "0x8912C0", Offset = "0x88F8C0", VA = "0x1808912C0")]
		public FHNJEBHNJBE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x3D235D0", Offset = "0x3D21BD0", VA = "0x183D235D0")]
		internal string KADFCEPNOJB(object? v)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x3D23450", Offset = "0x3D21A50", VA = "0x183D23450")]
		internal object IFEFHMAMNCA(string? s, object d)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x48329D0", Offset = "0x4830FD0", VA = "0x1848329D0")]
	public OMCKHBLOCAC(EOHLKKLFGPK LEFCHIAHDPM, string LHJGOMAMPPA, [Optional] JKDGMKHLEBE? NMJJDOEMMBH, [Optional] EDGIIEIEHPO? ABHONLIJBAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x4832030", Offset = "0x4830630", VA = "0x184832030")]
	private static object? CENBFOHJAFB(EDGIIEIEHPO? ABHONLIJBAP, string? OOANKEFNOJL, object? MCAGMGIJFIA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x4831760", Offset = "0x482FD60", VA = "0x184831760")]
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
		[Cpp2IlInjected.Address(RVA = "0x72905E0", Offset = "0x728EBE0", VA = "0x1872905E0", Slot = "4")]
		public bool Equals(List<string> NCPIGLMANIM, List<string> DJBPOPBDKAJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x7290730", Offset = "0x728ED30", VA = "0x187290730", Slot = "5")]
		public int GetHashCode(List<string> GHMNBJIOGAM)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x8912C0", Offset = "0x88F8C0", VA = "0x1808912C0")]
		public NAECLPNJGGD()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000020")]
	private class GBPBDIPLKLF : KOJKMHEJMIH<FMJKFFDODPG>
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x728AE20", Offset = "0x7289420", VA = "0x18728AE20", Slot = "9")]
		public override string AMCHBAGBIFH(FMJKFFDODPG DIGEGMNKCOG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x728AF10", Offset = "0x7289510", VA = "0x18728AF10", Slot = "10")]
		protected override bool NCNIDKADMIM(string DIGEGMNKCOG, [Out] FMJKFFDODPG KLABJGGMBGH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x728B0F0", Offset = "0x72896F0", VA = "0x18728B0F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x8841B0", Offset = "0x8827B0", VA = "0x1808841B0")]
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
		[Cpp2IlInjected.Address(RVA = "0x887050", Offset = "0x885650", VA = "0x180887050")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x728E090", Offset = "0x728C690", VA = "0x18728E090")]
	public LAPGBHGMBBJ([Optional] IList<LGKKONHBOAK>? OKHMOFGDLBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x728CB90", Offset = "0x728B190", VA = "0x18728CB90")]
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
		[Cpp2IlInjected.Address(RVA = "0x8841B0", Offset = "0x8827B0", VA = "0x1808841B0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x728A320", Offset = "0x7288920", VA = "0x18728A320")]
	public EAKBOPCLEOP(MMAJGKCEHKJ PIHGMBLNCCN, IReadOnlyList<MMAJGKCEHKJ> OLDHOJOBADB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x72894E0", Offset = "0x7287AE0", VA = "0x1872894E0")]
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
	[Cpp2IlInjected.Address(RVA = "0x728A4B0", Offset = "0x7288AB0", VA = "0x18728A4B0")]
	public static bool ECJFNKNCOFF(this PDPPFLAPOCL MBAGFJGPJPM, HFNNEAJJBFG IKPBJLKHJKL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x728A430", Offset = "0x7288A30", VA = "0x18728A430")]
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
		[Cpp2IlInjected.Address(RVA = "0x728E8E0", Offset = "0x728CEE0", VA = "0x18728E8E0", Slot = "23")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	private bool PMKOBEGEAKD
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x728FD50", Offset = "0x728E350", VA = "0x18728FD50", Slot = "22")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	private bool CIKEDBNGIMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x728E9D0", Offset = "0x728CFD0", VA = "0x18728E9D0", Slot = "21")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	private bool AKNEOLOBAOO
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x728E980", Offset = "0x728CF80", VA = "0x18728E980", Slot = "24")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	private bool NMDBGCHILON
	{
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x728FC50", Offset = "0x728E250", VA = "0x18728FC50", Slot = "26")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	private bool BMKKJAEBGNL
	{
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x728F120", Offset = "0x728D720", VA = "0x18728F120", Slot = "25")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public HFNNEAJJBFG AJIPIOMIEED
	{
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x9F2D20", Offset = "0x9F1320", VA = "0x1809F2D20", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(HFNNEAJJBFG);
		}
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x88E8A0", Offset = "0x88CEA0", VA = "0x18088E8A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public string CMHKCEEJFEB
	{
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x728FAF0", Offset = "0x728E0F0", VA = "0x18728FAF0", Slot = "29")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x728E550", Offset = "0x728CB50", VA = "0x18728E550")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public string FEIMGKBMACL
	{
		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x728FAF0", Offset = "0x728E0F0", VA = "0x18728FAF0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public bool IGGCMOEDLJN
	{
		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x9F2CE0", Offset = "0x9F12E0", VA = "0x1809F2CE0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0xB68B00", Offset = "0xB67100", VA = "0x180B68B00")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public bool COFJLPKAFLA
	{
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x7290200", Offset = "0x728E800", VA = "0x187290200", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public FMJKFFDODPG FFIKDNOAOOF
	{
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x728FB90", Offset = "0x728E190", VA = "0x18728FB90", Slot = "20")]
		get
		{
			return default(FMJKFFDODPG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public bool HOAPMBJADIH
	{
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x728EA80", Offset = "0x728D080", VA = "0x18728EA80", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public bool CCFJBFEEGCL
	{
		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x7290300", Offset = "0x728E900", VA = "0x187290300", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public bool EPAHCKODHHK
	{
		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x728E930", Offset = "0x728CF30", VA = "0x18728E930", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public bool AEAFJNDGGJI
	{
		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x728FB40", Offset = "0x728E140", VA = "0x18728FB40", Slot = "11")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public bool INBOPNFKDDE
	{
		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x728FBE0", Offset = "0x728E1E0", VA = "0x18728FBE0", Slot = "12")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public bool PJDIDEEGIKO
	{
		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x728F0D0", Offset = "0x728D6D0", VA = "0x18728F0D0", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public bool HANLHHHODHO
	{
		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x728FEA0", Offset = "0x728E4A0", VA = "0x18728FEA0", Slot = "14")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public bool JEMKFJGIFED
	{
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x728EFA0", Offset = "0x728D5A0", VA = "0x18728EFA0", Slot = "15")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public IReadOnlyList<string> EBAMNHGHECM
	{
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x728EA20", Offset = "0x728D020", VA = "0x18728EA20", Slot = "19")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public bool EOFMOLBKMFI
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x728E8E0", Offset = "0x728CEE0", VA = "0x18728E8E0", Slot = "30")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public bool IEFDNNEAHEK
	{
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x728FC50", Offset = "0x728E250", VA = "0x18728FC50", Slot = "31")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public bool DOLNKNPNIAN
	{
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x728FD50", Offset = "0x728E350", VA = "0x18728FD50", Slot = "32")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public bool DIOHHGHOAPK
	{
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x728FEF0", Offset = "0x728E4F0", VA = "0x18728FEF0", Slot = "16")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public bool NBOGFGNPPEM
	{
		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x728E5A0", Offset = "0x728CBA0", VA = "0x18728E5A0", Slot = "17")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public bool FHHKNDCONFA
	{
		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x728E9D0", Offset = "0x728CFD0", VA = "0x18728E9D0", Slot = "33")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public bool OHEIJIAJHLC
	{
		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x728EFF0", Offset = "0x728D5F0", VA = "0x18728EFF0", Slot = "18")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public bool DDICGMHJNNB
	{
		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x728E980", Offset = "0x728CF80", VA = "0x18728E980", Slot = "34")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public bool NAIKJHKDFBL
	{
		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x728F120", Offset = "0x728D720", VA = "0x18728F120", Slot = "35")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	public event MMHFDHHJEIO<EOHLKKLFGPK> HAIPFDLDBOD
	{
		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x7290250", Offset = "0x728E850", VA = "0x187290250", Slot = "27")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x728FCA0", Offset = "0x728E2A0", VA = "0x18728FCA0", Slot = "28")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x2D9CCE0", Offset = "0x2D9B2E0", VA = "0x182D9CCE0", Slot = "6")]
	public (bool, T?) IEGIPHMDKLE<T>(EOHLKKLFGPK LEFCHIAHDPM) where T : new()
	{
		return default((bool, T));
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x2D9CC80", Offset = "0x2D9B280", VA = "0x182D9CC80")]
	public MMAJGKCEHKJ AGBEIIJBLGC<T>(EOHLKKLFGPK LEFCHIAHDPM, bool AOFHMNBLLIM, T KLABJGGMBGH) where T : notnull, new()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x72903F0", Offset = "0x728E9F0", VA = "0x1872903F0")]
	public MMAJGKCEHKJ(HFNNEAJJBFG IKPBJLKHJKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x72903D0", Offset = "0x728E9D0", VA = "0x1872903D0")]
	public MMAJGKCEHKJ(HFNNEAJJBFG IKPBJLKHJKL, [Optional] string? BBOODOOGLHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x7290410", Offset = "0x728EA10", VA = "0x187290410")]
	public MMAJGKCEHKJ(MMAJGKCEHKJ FIDABDMJLID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x7290490", Offset = "0x728EA90", VA = "0x187290490")]
	internal MMAJGKCEHKJ(HFNNEAJJBFG KNKNPPCOIIB, [Optional] string? BBOODOOGLHI, [Optional] MMAJGKCEHKJ? FIDABDMJLID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x728FF90", Offset = "0x728E590", VA = "0x18728FF90")]
	public static PAFLHJKPKNO OGAOOKECBDL(EOHLKKLFGPK LEFCHIAHDPM)
	{
		return default(PAFLHJKPKNO);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x728FC30", Offset = "0x728E230", VA = "0x18728FC30")]
	public void JHKHDODFLLH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x728E5F0", Offset = "0x728CBF0", VA = "0x18728E5F0")]
	internal MMAJGKCEHKJ BGHBPLODFDC(MMAJGKCEHKJ FDFNDBLKCKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x728EBB0", Offset = "0x728D1B0", VA = "0x18728EBB0")]
	internal IReadOnlyCollection<EOHLKKLFGPK> DODCOAEGADP(MMAJGKCEHKJ FIDABDMJLID)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x728EAD0", Offset = "0x728D0D0", VA = "0x18728EAD0")]
	public bool DMGOIIJNNCC(EOHLKKLFGPK LEFCHIAHDPM, bool AOFHMNBLLIM, string FIDECJMONGH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x728FDA0", Offset = "0x728E3A0", VA = "0x18728FDA0")]
	public (bool, string) KHOBPOGICPL(EOHLKKLFGPK LEFCHIAHDPM)
	{
		return default((bool, string));
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x728FF40", Offset = "0x728E540", VA = "0x18728FF40")]
	internal void NEECIEODNLP(EOHLKKLFGPK LEFCHIAHDPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x7290000", Offset = "0x728E600", VA = "0x187290000")]
	public MIHLFAECCOH OHNLHFDAOKO(Func<HFNNEAJJBFG, Guid> PCALKMKBDNC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x728F170", Offset = "0x728D770", VA = "0x18728F170")]
	public void HDBIEKDLOJA(MIHLFAECCOH LKBGPBNFBLO, Func<Guid, HFNNEAJJBFG> AADNKDJBHGJ, [Optional] HFNNEAJJBFG? FKLCIOLGKME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x728F040", Offset = "0x728D640", VA = "0x18728F040")]
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
		[Cpp2IlInjected.Address(RVA = "0x8912C0", Offset = "0x88F8C0", VA = "0x1808912C0")]
		public GGMCKKFFAHL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x728B130", Offset = "0x7289730", VA = "0x18728B130")]
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
		[Cpp2IlInjected.Address(RVA = "0x8912C0", Offset = "0x88F8C0", VA = "0x1808912C0")]
		public ICFNCFFPLFI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x728BC50", Offset = "0x728A250", VA = "0x18728BC50")]
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
		[Cpp2IlInjected.Address(RVA = "0x728C4C0", Offset = "0x728AAC0", VA = "0x18728C4C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x728CB30", Offset = "0x728B130", VA = "0x18728CB30", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x8912C0", Offset = "0x88F8C0", VA = "0x1808912C0")]
		public HCLDIOPIKBP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x728B310", Offset = "0x7289910", VA = "0x18728B310")]
		internal void OGMMDEBLBKG(MIHLFAECCOH r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x728B1F0", Offset = "0x72897F0", VA = "0x18728B1F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x8912C0", Offset = "0x88F8C0", VA = "0x1808912C0")]
		public HBPJHCECGPL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x728B160", Offset = "0x7289760", VA = "0x18728B160")]
		internal void EBHHMOCJKDP(MIHLFAECCOH r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x728B190", Offset = "0x7289790", VA = "0x18728B190")]
		internal void MLHHDNLMEMO(MIHLFAECCOH r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x728B1C0", Offset = "0x72897C0", VA = "0x18728B1C0")]
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
			[Cpp2IlInjected.Address(RVA = "0x369DAF0", Offset = "0x369C0F0", VA = "0x18369DAF0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000115")]
			[Cpp2IlInjected.Address(RVA = "0xB9D680", Offset = "0xB9BC80", VA = "0x180B9D680", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x8912C0", Offset = "0x88F8C0", VA = "0x1808912C0")]
		public AEKAPDMELEH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x3DA5820", Offset = "0x3DA3E20", VA = "0x183DA5820")]
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
		[Cpp2IlInjected.Address(RVA = "0x7290C40", Offset = "0x728F240", VA = "0x187290C40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x7291750", Offset = "0x728FD50", VA = "0x187291750", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x887050", Offset = "0x885650", VA = "0x180887050", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public IEnumerable<IFLHCANCNLC> JAJOFHLKPDM
	{
		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x7287510", Offset = "0x7285B10", VA = "0x187287510", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	public event PKJINFCAKOB NAIOOKDGJIH
	{
		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x7288160", Offset = "0x7286760", VA = "0x187288160", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x7286150", Offset = "0x7284750", VA = "0x187286150", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x7287AD0", Offset = "0x72860D0", VA = "0x187287AD0")]
	[DJINMBCHLNM.BKIMOKOFNKD]
	internal static void LJBMCKAFLEE(JEFLJDHAGDI FMBOKBBFBFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x7289220", Offset = "0x7287820", VA = "0x187289220")]
	[UnityEngine.Scripting.Preserve]
	internal BDFLEGPINGC([OLJNBPOCBCJ(null)] NBODDKCENDJ CHKPFDMMLJA, [OLJNBPOCBCJ(null)] EAKBOPCLEOP OHMCDDAIOJJ, [OLJNBPOCBCJ(null)] CICIOHJMEBM LONCLMCGANJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x7285A10", Offset = "0x7284010", VA = "0x187285A10", Slot = "18")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x7284AF0", Offset = "0x72830F0", VA = "0x187284AF0")]
	private void CDPJLODHOFD(IEnumerable<MMAJGKCEHKJ> EIIAJBKNEHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x7285B20", Offset = "0x7284120", VA = "0x187285B20", Slot = "12")]
	public bool EAGEBHLOEEE(PDPPFLAPOCL JDDNDMPDAKN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x7287500", Offset = "0x7285B00", VA = "0x187287500")]
	private void HDANNCCLMAN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x7287870", Offset = "0x7285E70", VA = "0x187287870")]
	private void KHPNIAJMILL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x7285360", Offset = "0x7283960", VA = "0x187285360", Slot = "10")]
	public IReadOnlyList<IFLHCANCNLC> CEALBHDGCJA(bool CIPGPACPIJP = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x7283AE0", Offset = "0x72820E0", VA = "0x187283AE0", Slot = "11")]
	public IFLHCANCNLC AEAEPHPJCCJ(PDPPFLAPOCL JDDNDMPDAKN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x7285C00", Offset = "0x7284200", VA = "0x187285C00")]
	private HFNNEAJJBFG FIJFPHLEGOA(PDPPFLAPOCL JDDNDMPDAKN)
	{
		return default(HFNNEAJJBFG);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x7287C80", Offset = "0x7286280", VA = "0x187287C80", Slot = "14")]
	public bool MGFJCDMIHKA(PDPPFLAPOCL MIDHKBKKKKN, HFNNEAJJBFG IKPBJLKHJKL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x72849E0", Offset = "0x7282FE0", VA = "0x1872849E0", Slot = "15")]
	public IFLHCANCNLC CCCEJCOCDKK(HFNNEAJJBFG IKPBJLKHJKL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x72885E0", Offset = "0x7286BE0", VA = "0x1872885E0")]
	private static bool PGIDJFBHCLG(AKMGCDNEIAI FDAOEBFGFKJ, HFNNEAJJBFG IKPBJLKHJKL, [Out] MIHLFAECCOH? OKOBKJCOPMN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x7286480", Offset = "0x7284A80", VA = "0x187286480")]
	private static void GECLCBBHHAB(AKMGCDNEIAI FDAOEBFGFKJ, Action<MIHLFAECCOH> BPKLBHMJAAI, HFNNEAJJBFG HIPJAKODFJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x72861F0", Offset = "0x72847F0", VA = "0x1872861F0")]
	private static void GECLCBBHHAB(AKMGCDNEIAI FDAOEBFGFKJ, Action<MIHLFAECCOH> BPKLBHMJAAI, Predicate<HFNNEAJJBFG> IHLKLGIFOEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x7287A60", Offset = "0x7286060", VA = "0x187287A60")]
	private void KMAAKCABBIJ(PDPPFLAPOCL JDDNDMPDAKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x72848C0", Offset = "0x7282EC0", VA = "0x1872848C0", Slot = "4")]
	[AsyncStateMachine(typeof(KHFBMCBHGFC))]
	public Task BDLNNECAKFK([CanBeNull] ANPHFBDJECI LLAPGPIJJLB, CancellationToken IONNNJNKLMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x885350", Offset = "0x883950", VA = "0x180885350", Slot = "5")]
	public void OCMNECECGGC(ANPHFBDJECI LLAPGPIJJLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x7283BF0", Offset = "0x72821F0", VA = "0x187283BF0")]
	private void AIFIENCNFLH(AKMGCDNEIAI HPNNDMILJMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x7287560", Offset = "0x7285B60", VA = "0x187287560")]
	internal static string JHEFEIPOLED(NBODDKCENDJ IPPPCAMKOGF, ANPHFBDJECI LLAPGPIJJLB, IReadOnlyDictionary<HFNNEAJJBFG, MMAJGKCEHKJ> EOLMEPPMBMD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x7286570", Offset = "0x7284B70", VA = "0x187286570")]
	private static void GJDAHOGGPKK(ANPHFBDJECI LLAPGPIJJLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x7287E10", Offset = "0x7286410", VA = "0x187287E10")]
	private static void MIEKFOHKMKG(AKMGCDNEIAI DKFOFIDBMLN, IReadOnlyDictionary<HFNNEAJJBFG, MMAJGKCEHKJ> EOLMEPPMBMD, StringBuilder PCIIBPBPJJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x7285CD0", Offset = "0x72842D0", VA = "0x187285CD0")]
	private static bool FKEHFPADMKJ(string NEFKMOMGCFG, [Out] Guid KMDFBPHNLJN, [Out] HFNNEAJJBFG IKPBJLKHJKL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x7288910", Offset = "0x7286F10", VA = "0x187288910")]
	private static void PHHCJALOPHL(ANPHFBDJECI LLAPGPIJJLB, StringBuilder PCIIBPBPJJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x2A0E3A0", Offset = "0x2A0C9A0", VA = "0x182A0E3A0", Slot = "16")]
	public bool CKDDMGACOLE<T>(HFNNEAJJBFG IKPBJLKHJKL, EOHLKKLFGPK LEFCHIAHDPM, bool AOFHMNBLLIM, T IOBLLEKOCNN, [Optional] Action IEJEEFGEIHJ) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x7284A80", Offset = "0x7283080", VA = "0x187284A80", Slot = "17")]
	public string CDCEGBGJCMB(EOHLKKLFGPK LEFCHIAHDPM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x7283F30", Offset = "0x7282530", VA = "0x187283F30")]
	private void BAEIOKAAJED(HFNNEAJJBFG IKPBJLKHJKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x7283AC0", Offset = "0x72820C0", VA = "0x187283AC0")]
	private bool ABIDFPHFACN(PDPPFLAPOCL JDDNDMPDAKN, HFNNEAJJBFG IKPBJLKHJKL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x72853E0", Offset = "0x72839E0", VA = "0x1872853E0")]
	internal MMAJGKCEHKJ CMPBJCOJAML(PDPPFLAPOCL JDDNDMPDAKN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x7285BF0", Offset = "0x72841F0", VA = "0x187285BF0", Slot = "13")]
	public IReadOnlyList<IFLHCANCNLC> EHLFEHJKABL(PDPPFLAPOCL JDDNDMPDAKN, bool PJKGDAGLDJL = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x72872D0", Offset = "0x72858D0", VA = "0x1872872D0")]
	internal IReadOnlyList<MMAJGKCEHKJ> GPLNOHGJKHP(PDPPFLAPOCL JDDNDMPDAKN, bool PJKGDAGLDJL = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x7284140", Offset = "0x7282740", VA = "0x187284140")]
	private void BCFABGGIOAA(AFMJJDEJELI OCGGFMGECFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x7285730", Offset = "0x7283D30", VA = "0x187285730")]
	private static bool DMMNHLACLNB(MMAJGKCEHKJ JKLGHAJCCAM, IReadOnlyDictionary<HFNNEAJJBFG, MMAJGKCEHKJ> EOLMEPPMBMD, [Out] IReadOnlyList<EOHLKKLFGPK> CDPCMEFGFEP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x7288200", Offset = "0x7286800", VA = "0x187288200")]
	[AsyncStateMachine(typeof(NOLEKPKFFHH))]
	private static Task OOBBEIEOJFP(NBODDKCENDJ IPPPCAMKOGF, ANPHFBDJECI LLAPGPIJJLB, IReadOnlyDictionary<HFNNEAJJBFG, MMAJGKCEHKJ> EOLMEPPMBMD, CICIOHJMEBM LONCLMCGANJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x7288340", Offset = "0x7286940", VA = "0x187288340")]
	[CompilerGenerated]
	internal static void PBLENKFJNAC(Func<MIHLFAECCOH, CEJLGIIMCHG> DHEFCDMFNON, NKNNBDNFHNG P_1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x7285DE0", Offset = "0x72843E0", VA = "0x187285DE0")]
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
	[Cpp2IlInjected.Address(RVA = "0x88AB80", Offset = "0x889180", VA = "0x18088AB80")]
	[RecRoom.NoEngine.Common.Preserve]
	public INBOINGPPBE([OLJNBPOCBCJ(null)] CCCNHCCNHAA LAJDOPBBKGG, [OLJNBPOCBCJ(null)] LHBMCLICBFC DALBHJFAJKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x728BC60", Offset = "0x728A260", VA = "0x18728BC60")]
	private static HBBAEPBLNMC? AGHFLFPHGBG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x728C2C0", Offset = "0x728A8C0", VA = "0x18728C2C0", Slot = "4")]
	public bool CHFOHNKGMGD(PDPPFLAPOCL DPAOKBCPBMN, PDPPFLAPOCL DGMOLOLGOMJ, IEnumerable<PDPPFLAPOCL> ALAJJIMLDON, [Out] FMJKFFDODPG CAJNNOJFHPH, [Out] NHHNHFBEEFP MMKFDMMHFPK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x728C3C0", Offset = "0x728A9C0", VA = "0x18728C3C0", Slot = "5")]
	public string HAJLKPAGHMA(NHHNHFBEEFP FCNOMCILCIA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x728BCA0", Offset = "0x728A2A0", VA = "0x18728BCA0")]
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
