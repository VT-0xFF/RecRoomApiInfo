using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Microsoft.CodeAnalysis;
using RecRoom.NoEngine.Common;

[assembly: AssemblyVersion("0.0.0.0")]
namespace Microsoft.CodeAnalysis
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class EmbeddedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x78C450", Offset = "0x78B250", VA = "0x18078C450")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter, AllowMultiple = false, Inherited = false)]
	[Microsoft.CodeAnalysis.Embedded]
	[CompilerGenerated]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x5D56230", Offset = "0x5D55030", VA = "0x185D56230")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x78C910", Offset = "0x78B710", VA = "0x18078C910")]
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
		[Cpp2IlInjected.Address(RVA = "0x78C950", Offset = "0x78B750", VA = "0x18078C950")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public abstract class GMEDFLPOLNB
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x76E9D0", Offset = "0x76D7D0", VA = "0x18076E9D0")]
	protected GMEDFLPOLNB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public abstract class KCJDMMPGHJL<T> : GMEDFLPOLNB
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	protected struct LKGLGJDKGPI
	{
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		public enum IONAOPGKEEF
		{
			[Cpp2IlInjected.Token(Token = "0x400000B")]
			ADD,
			[Cpp2IlInjected.Token(Token = "0x400000C")]
			REMOVE,
			[Cpp2IlInjected.Token(Token = "0x400000D")]
			CLEAR
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public IONAOPGKEEF PEMNIEMPPLO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public T HMHDIIODGFG;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private int HPFILKPHMGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly bool EMBOPBKHCPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	protected readonly bool KKLOGEMNKIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	protected List<T>? CCFIBOOCIDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private List<LKGLGJDKGPI>? EPFLOIIHONJ;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public bool JNABINLAEJD
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x3879FF0", Offset = "0x3878DF0", VA = "0x183879FF0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x387A6F0", Offset = "0x38794F0", VA = "0x18387A6F0")]
	protected KCJDMMPGHJL(bool KKLOGEMNKIB, bool EMBOPBKHCPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x387A650", Offset = "0x3879450", VA = "0x18387A650")]
	protected bool NKKCKKMMILB()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x387A550", Offset = "0x3879350", VA = "0x18387A550")]
	protected void LIIPCNNABMM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x387A1C0", Offset = "0x3878FC0", VA = "0x18387A1C0")]
	protected void IFLPNBCPCPK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x2286930", Offset = "0x2285730", VA = "0x182286930")]
	private static void FFABNJNGKNE<U>(List<U>? NDKEAGMKBJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x3879E10", Offset = "0x3878C10", VA = "0x183879E10", Slot = "4")]
	public void AAFNAGDLNDC(T HMHDIIODGFG, bool CGNEAPBMMCE = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x387A3A0", Offset = "0x38791A0", VA = "0x18387A3A0", Slot = "5")]
	public void ILBKIBAINPM(T HMHDIIODGFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x387A040", Offset = "0x3878E40", VA = "0x18387A040")]
	public void EOCKAINKMIG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface JOMKKGNHLBF
{
	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void AAFNAGDLNDC(Action HMHDIIODGFG, bool CGNEAPBMMCE = false);

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void ILBKIBAINPM(Action HMHDIIODGFG);
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public sealed class ECJBBEDPNJE : KCJDMMPGHJL<Action>, JOMKKGNHLBF
{
	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x5D553A0", Offset = "0x5D541A0", VA = "0x185D553A0")]
	public ECJBBEDPNJE(bool KKLOGEMNKIB = false, bool EMBOPBKHCPM = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x5D55140", Offset = "0x5D53F40", VA = "0x185D55140")]
	public void LBCPFKCIFOM()
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x5D550E0", Offset = "0x5D53EE0", VA = "0x185D550E0")]
	public static ECJBBEDPNJE ANKLPPKHJLG(ECJBBEDPNJE JCPBGJGPGPA, Action HMHDIIODGFG)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x5D55340", Offset = "0x5D54140", VA = "0x185D55340")]
	public static ECJBBEDPNJE LNLCGFPCCBD(ECJBBEDPNJE JCPBGJGPGPA, Action HMHDIIODGFG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface PPGMOANNHCH<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void AAFNAGDLNDC(Action<T> HMHDIIODGFG, bool CGNEAPBMMCE = false);

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void ILBKIBAINPM(Action<T> HMHDIIODGFG);
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public sealed class HEBNGJMIMPC<T> : KCJDMMPGHJL<Action<T>>, PPGMOANNHCH<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x33D1C20", Offset = "0x33D0A20", VA = "0x1833D1C20")]
	public HEBNGJMIMPC(bool KKLOGEMNKIB = false, bool EMBOPBKHCPM = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x3572070", Offset = "0x3570E70", VA = "0x183572070")]
	public void LBCPFKCIFOM(T MOEPCGBEMKK)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x33D0F00", Offset = "0x33CFD00", VA = "0x1833D0F00")]
	public static HEBNGJMIMPC<T> ANKLPPKHJLG(HEBNGJMIMPC<T> JCPBGJGPGPA, Action<T> HMHDIIODGFG)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x33D1B90", Offset = "0x33D0990", VA = "0x1833D1B90")]
	public static HEBNGJMIMPC<T> LNLCGFPCCBD(HEBNGJMIMPC<T> JCPBGJGPGPA, Action<T> HMHDIIODGFG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface EIDGIKEKFOJ<T, U> where T : notnull where U : notnull
{
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public sealed class GNIKJMLLIOJ<T, U> : KCJDMMPGHJL<Action<T, U>>, EIDGIKEKFOJ<T, U> where T : notnull where U : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x33D1C20", Offset = "0x33D0A20", VA = "0x1833D1C20")]
	public GNIKJMLLIOJ(bool KKLOGEMNKIB = false, bool EMBOPBKHCPM = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x34DD700", Offset = "0x34DC500", VA = "0x1834DD700")]
	public void LBCPFKCIFOM(T MOEPCGBEMKK, U JKDACOMACIH)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x33D0F00", Offset = "0x33CFD00", VA = "0x1833D0F00")]
	public static GNIKJMLLIOJ<T, U> ANKLPPKHJLG(GNIKJMLLIOJ<T, U> JCPBGJGPGPA, Action<T, U> HMHDIIODGFG)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x33D1B90", Offset = "0x33D0990", VA = "0x1833D1B90")]
	public static GNIKJMLLIOJ<T, U> LNLCGFPCCBD(GNIKJMLLIOJ<T, U> JCPBGJGPGPA, Action<T, U> HMHDIIODGFG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public sealed class GGFMHBMHBCG<T, U, V> : KCJDMMPGHJL<Action<T, U, V>> where T : notnull where U : notnull where V : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x33D1C20", Offset = "0x33D0A20", VA = "0x1833D1C20")]
	public GGFMHBMHBCG(bool KKLOGEMNKIB = false, bool EMBOPBKHCPM = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x34B0E80", Offset = "0x34AFC80", VA = "0x1834B0E80")]
	public void LBCPFKCIFOM(T MOEPCGBEMKK, U JKDACOMACIH, V PMHKKHBJKIH)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x33D0F00", Offset = "0x33CFD00", VA = "0x1833D0F00")]
	public static GGFMHBMHBCG<T, U, V> ANKLPPKHJLG(GGFMHBMHBCG<T, U, V> JCPBGJGPGPA, Action<T, U, V> HMHDIIODGFG)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x33D1B90", Offset = "0x33D0990", VA = "0x1833D1B90")]
	public static GGFMHBMHBCG<T, U, V> LNLCGFPCCBD(GGFMHBMHBCG<T, U, V> JCPBGJGPGPA, Action<T, U, V> HMHDIIODGFG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface DMGDEKHJOIG<T, U, V, W>
{
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public sealed class AKBGILKKBKF<T, U, V, W> : KCJDMMPGHJL<Action<T, U, V, W>>, DMGDEKHJOIG<T, U, V, W> where T : notnull where U : notnull where V : notnull where W : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x33D1C20", Offset = "0x33D0A20", VA = "0x1833D1C20")]
	public AKBGILKKBKF(bool KKLOGEMNKIB = false, bool EMBOPBKHCPM = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x3516ED0", Offset = "0x3515CD0", VA = "0x183516ED0")]
	public void LBCPFKCIFOM(T MOEPCGBEMKK, U JKDACOMACIH, V PMHKKHBJKIH, W LOKDBOGNGFK)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x33D0F00", Offset = "0x33CFD00", VA = "0x1833D0F00")]
	public static AKBGILKKBKF<T, U, V, W> ANKLPPKHJLG(AKBGILKKBKF<T, U, V, W> JCPBGJGPGPA, Action<T, U, V, W> HMHDIIODGFG)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x33D1B90", Offset = "0x33D0990", VA = "0x1833D1B90")]
	public static AKBGILKKBKF<T, U, V, W> LNLCGFPCCBD(AKBGILKKBKF<T, U, V, W> JCPBGJGPGPA, Action<T, U, V, W> HMHDIIODGFG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public sealed class CJOAKDHLHGL<T, U, V, W, X> : KCJDMMPGHJL<Action<T, U, V, W, X>>
{
	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x33D1C20", Offset = "0x33D0A20", VA = "0x1833D1C20")]
	public CJOAKDHLHGL(bool KKLOGEMNKIB = false, bool EMBOPBKHCPM = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x490EEA0", Offset = "0x490DCA0", VA = "0x18490EEA0")]
	public void LBCPFKCIFOM(T MOEPCGBEMKK, U JKDACOMACIH, V PMHKKHBJKIH, W LOKDBOGNGFK, X HOELCINBFKH)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x33D0F00", Offset = "0x33CFD00", VA = "0x1833D0F00")]
	public static CJOAKDHLHGL<T, U, V, W, X> ANKLPPKHJLG(CJOAKDHLHGL<T, U, V, W, X> JCPBGJGPGPA, Action<T, U, V, W, X> HMHDIIODGFG)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x33D1B90", Offset = "0x33D0990", VA = "0x1833D1B90")]
	public static CJOAKDHLHGL<T, U, V, W, X> LNLCGFPCCBD(CJOAKDHLHGL<T, U, V, W, X> JCPBGJGPGPA, Action<T, U, V, W, X> HMHDIIODGFG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public sealed class FEPEOKGAFDG<T, U, V, W, X, Y> : KCJDMMPGHJL<Action<T, U, V, W, X, Y>>
{
	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x33D1C20", Offset = "0x33D0A20", VA = "0x1833D1C20")]
	public FEPEOKGAFDG(bool KKLOGEMNKIB = false, bool EMBOPBKHCPM = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x33D1370", Offset = "0x33D0170", VA = "0x1833D1370")]
	public void LBCPFKCIFOM(T MOEPCGBEMKK, U JKDACOMACIH, V PMHKKHBJKIH, W LOKDBOGNGFK, X HOELCINBFKH, Y JOHINIOFBIJ)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x33D0F00", Offset = "0x33CFD00", VA = "0x1833D0F00")]
	public static FEPEOKGAFDG<T, U, V, W, X, Y> ANKLPPKHJLG(FEPEOKGAFDG<T, U, V, W, X, Y> JCPBGJGPGPA, Action<T, U, V, W, X, Y> HMHDIIODGFG)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x33D1B90", Offset = "0x33D0990", VA = "0x1833D1B90")]
	public static FEPEOKGAFDG<T, U, V, W, X, Y> LNLCGFPCCBD(FEPEOKGAFDG<T, U, V, W, X, Y> JCPBGJGPGPA, Action<T, U, V, W, X, Y> HMHDIIODGFG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class PJOJEFHEHIG<TKey, TVal> where TKey : notnull where TVal : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly PFFBOKGKIDF<TKey, TVal> AFDFJNANMCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	internal readonly Dictionary<TKey, (TVal value, int size)> FADDIHKPAHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private readonly int NKBKKABANIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private readonly PFFBOKGKIDF<TKey, TVal>.OLKFLODAMAD? AMOMNEMLALL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private int LGHMGGBDNLG;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	internal int FHHPPKCLCHJ
	{
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x3DEB4C0", Offset = "0x3DEA2C0", VA = "0x183DEB4C0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public int LIILMDHCBPK
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x80C540", Offset = "0x80B340", VA = "0x18080C540")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x3DEB5F0", Offset = "0x3DEA3F0", VA = "0x183DEB5F0")]
	public PJOJEFHEHIG(int NKBKKABANIN, [Optional] PFFBOKGKIDF<TKey, TVal>.OLKFLODAMAD? AMOMNEMLALL, [Optional] IEqualityComparer<TKey>? IPIBHOFAEEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x3DEB2F0", Offset = "0x3DEA0F0", VA = "0x183DEB2F0")]
	public void FFLPIDOOLDD(TKey JLDFGFPAIIN, TVal GNLEHBFFNFG, bool ENEEBBAOOGB = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x3DEAF70", Offset = "0x3DE9D70", VA = "0x183DEAF70")]
	public bool CPOEEPFCBDP(TKey JLDFGFPAIIN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x3DEB510", Offset = "0x3DEA310", VA = "0x183DEB510")]
	public bool PGDPBMGNNCL(TKey IAHPBPDECDH, [Out] TVal GNLEHBFFNFG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x3DEB010", Offset = "0x3DE9E10", VA = "0x183DEB010")]
	private void EGMHBCOKAAG(TKey JLDFGFPAIIN, TVal GNLEHBFFNFG, int MEDHPDICIDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x3DEADE0", Offset = "0x3DE9BE0", VA = "0x183DEADE0")]
	public bool AOJOKHPDLHF(TKey JLDFGFPAIIN, TVal GNLEHBFFNFG, bool ENEEBBAOOGB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x3DEB230", Offset = "0x3DEA030", VA = "0x183DEB230")]
	private bool EMLLEDHHEFK(TKey JLDFGFPAIIN)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
[DefaultMember("Item")]
public sealed class PFFBOKGKIDF<TKey, TVal> : IDictionary<TKey, TVal>, ICollection<KeyValuePair<TKey, TVal>>, IEnumerable<KeyValuePair<TKey, TVal>>, IEnumerable where TKey : notnull where TVal : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public delegate int OLKFLODAMAD(TKey JLDFGFPAIIN, TVal GNLEHBFFNFG);

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	private class CCOAKCBLLBH
	{
		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public TKey FPPHOMLMMKP
		{
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0xA8D850", Offset = "0xA8C650", VA = "0x180A8D850")]
			[CompilerGenerated]
			get
			{
				return (TKey)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public TVal GMPOHOAMMIO
		{
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x761660", Offset = "0x760460", VA = "0x180761660")]
			[CompilerGenerated]
			get
			{
				return (TVal)null;
			}
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x761680", Offset = "0x760480", VA = "0x180761680")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public int ALAHGBICDEI
		{
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x761620", Offset = "0x760420", VA = "0x180761620")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x761690", Offset = "0x760490", VA = "0x180761690")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public DateTime LEIKIAOHPNE
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x765900", Offset = "0x764700", VA = "0x180765900")]
			[CompilerGenerated]
			get
			{
				return default(DateTime);
			}
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x76B120", Offset = "0x769F20", VA = "0x18076B120")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x47366A0", Offset = "0x47354A0", VA = "0x1847366A0")]
		public CCOAKCBLLBH(TKey JLDFGFPAIIN, TVal AACJDNHHIME)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000019")]
	[CompilerGenerated]
	private sealed class KIFMCLFJAPE : IEnumerator<KeyValuePair<TKey, TVal>>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private KeyValuePair<TKey, TVal> <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		public PFFBOKGKIDF<TKey, TVal> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private LinkedList<CCOAKCBLLBH>.Enumerator <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		KeyValuePair<TKey, TVal> IEnumerator<KeyValuePair<TKey, TVal>>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0xD5F440", Offset = "0xD5E240", VA = "0x180D5F440", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return default(KeyValuePair<TKey, TVal>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x38989B0", Offset = "0x38977B0", VA = "0x1838989B0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x765650", Offset = "0x764450", VA = "0x180765650")]
		[DebuggerHidden]
		public KIFMCLFJAPE(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x325F240", Offset = "0x325E040", VA = "0x18325F240", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x3897B40", Offset = "0x3896940", VA = "0x183897B40", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x3897520", Offset = "0x3896320", VA = "0x183897520")]
		private void MPOCHKHBDOM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x3898960", Offset = "0x3897760", VA = "0x183898960", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public const int BBPKOPNAANB = -1;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private readonly Dictionary<TKey, LinkedListNode<CCOAKCBLLBH>> IBKAPCOCGHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private readonly LinkedList<CCOAKCBLLBH> MMDICKAPHDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private readonly OLKFLODAMAD? AMOMNEMLALL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private readonly TimeSpan HNKMIBBIDLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private readonly GMINOKAOFAH HOJGKLDFGEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private bool EPEABHIBJGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private readonly List<TKey> LJNKPPEJMJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private readonly List<TVal> AGMKHGLMIPH;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public int LIILMDHCBPK
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x7804C0", Offset = "0x77F2C0", VA = "0x1807804C0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	internal int FHHPPKCLCHJ
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x7804D0", Offset = "0x77F2D0", VA = "0x1807804D0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0xD50C10", Offset = "0xD4FA10", VA = "0x180D50C10")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public int CBILAPKHPBD
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x33CCDC0", Offset = "0x33CBBC0", VA = "0x1833CCDC0", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public ICollection<TVal> JAFLGLCJABA
	{
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x3DE1220", Offset = "0x3DE0020", VA = "0x183DE1220", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	ICollection<TKey> IDictionary<TKey, TVal>.ADBPPNGEMBE
	{
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x3DDEB10", Offset = "0x3DDD910", VA = "0x183DDEB10", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public bool MGKAFOIHMEH
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x7AC370", Offset = "0x7AB170", VA = "0x1807AC370", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public TVal BCEJDLMHPFK
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x3DE1130", Offset = "0x3DDFF30", VA = "0x183DE1130", Slot = "4")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x3DE12D0", Offset = "0x3DE00D0", VA = "0x183DE12D0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x3DD7450", Offset = "0x3DD6250", VA = "0x183DD7450")]
	private bool BIMCJLMDBJI(int DECKGNHFLHF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x3DDDC80", Offset = "0x3DDCA80", VA = "0x183DDDC80")]
	private void OPJNKAAOAHM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x3DE0170", Offset = "0x3DDEF70", VA = "0x183DE0170")]
	public PFFBOKGKIDF(int DECKGNHFLHF, [Optional] OLKFLODAMAD? AMOMNEMLALL, [Optional] IEqualityComparer<TKey>? IPIBHOFAEEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x3DDF870", Offset = "0x3DDE670", VA = "0x183DDF870")]
	public PFFBOKGKIDF(int DECKGNHFLHF, TimeSpan HNKMIBBIDLG, [Optional] IEqualityComparer<TKey>? IPIBHOFAEEO, [Optional] GMINOKAOFAH? HOJGKLDFGEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x3DE0AF0", Offset = "0x3DDF8F0", VA = "0x183DE0AF0")]
	public PFFBOKGKIDF(int DECKGNHFLHF, OLKFLODAMAD? AMOMNEMLALL, TimeSpan HNKMIBBIDLG, [Optional] IEqualityComparer<TKey>? IPIBHOFAEEO, [Optional] GMINOKAOFAH? HOJGKLDFGEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x3DDE0D0", Offset = "0x3DDCED0", VA = "0x183DDE0D0")]
	public bool PLPJLNKCNFD()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x3DD98E0", Offset = "0x3DD86E0", VA = "0x183DD98E0")]
	public bool FIJCMKHMCDO(int MEDHPDICIDE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x3DDC610", Offset = "0x3DDB410", VA = "0x183DDC610")]
	public void KLJMIKDFPBF(TKey JLDFGFPAIIN, TVal GNLEHBFFNFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x3DD7300", Offset = "0x3DD6100", VA = "0x183DD7300", Slot = "14")]
	public void Add(KeyValuePair<TKey, TVal> PEGAJFMFKFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x3DD6C00", Offset = "0x3DD5A00", VA = "0x183DD6C00", Slot = "9")]
	public void Add(TKey JLDFGFPAIIN, TVal GNLEHBFFNFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x3DD7610", Offset = "0x3DD6410", VA = "0x183DD7610", Slot = "8")]
	public bool ContainsKey(TKey JLDFGFPAIIN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x3DD7610", Offset = "0x3DD6410", VA = "0x183DD7610", Slot = "16")]
	public bool Contains(KeyValuePair<TKey, TVal> PEGAJFMFKFI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x3DDE8F0", Offset = "0x3DDD6F0", VA = "0x183DDE8F0", Slot = "10")]
	public bool Remove(TKey JLDFGFPAIIN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x3DDE8A0", Offset = "0x3DDD6A0", VA = "0x183DDE8A0", Slot = "18")]
	public bool Remove(KeyValuePair<TKey, TVal> PEGAJFMFKFI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x3DDD7C0", Offset = "0x3DDC5C0", VA = "0x183DDD7C0")]
	private TVal OMJIHOMPBMI(TKey IAHPBPDECDH)
	{
		return (TVal)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x3DDEEE0", Offset = "0x3DDDCE0", VA = "0x183DDEEE0", Slot = "11")]
	public bool TryGetValue(TKey IAHPBPDECDH, [Out] TVal GNLEHBFFNFG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x3DD74A0", Offset = "0x3DD62A0", VA = "0x183DD74A0", Slot = "15")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x3DD77D0", Offset = "0x3DD65D0", VA = "0x183DD77D0", Slot = "17")]
	public void CopyTo(KeyValuePair<TKey, TVal>[] FNIMPMJDPGM, int KOPIDODGMCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x3DDD530", Offset = "0x3DDC330", VA = "0x183DDD530")]
	private bool NFEMDHFJHOB(CCOAKCBLLBH FCOPAMEHMPM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x3DDAF60", Offset = "0x3DD9D60", VA = "0x183DDAF60")]
	private void JAKLJCGNBKF(LinkedListNode<CCOAKCBLLBH> FALFPACGDPL, TVal LEDLLMJPAFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x3DDC0D0", Offset = "0x3DDAED0", VA = "0x183DDC0D0")]
	private void JPPNIIILNPH(TKey JLDFGFPAIIN, TVal GNLEHBFFNFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x3DDCD10", Offset = "0x3DDBB10", VA = "0x183DDCD10")]
	private void KLPOMFNMAKN(CCOAKCBLLBH FCOPAMEHMPM, TVal LEDLLMJPAFI, int HJIJELOHDKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x3DD9C30", Offset = "0x3DD8A30", VA = "0x183DD9C30", Slot = "19")]
	[IteratorStateMachine(typeof(PFFBOKGKIDF<, >.KIFMCLFJAPE))]
	public IEnumerator<KeyValuePair<TKey, TVal>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x3DDEB40", Offset = "0x3DDD940", VA = "0x183DDEB40", Slot = "20")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200001A")]
public readonly struct JNONPGBJGNA : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x7AC370", Offset = "0x7AB170", VA = "0x1807AC370")]
	public static JNONPGBJGNA ELGLCHHLLKA(Type PEMNIEMPPLO, [Optional] string? PHCHJDIOHDH, [Optional] string? JOFNJNEIAFD, bool NNJGJGLAPJI = false)
	{
		return default(JNONPGBJGNA);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x7AC370", Offset = "0x7AB170", VA = "0x1807AC370")]
	public static JNONPGBJGNA ELGLCHHLLKA<T>([Optional] string? PHCHJDIOHDH, [Optional] string? JOFNJNEIAFD, bool NNJGJGLAPJI = false)
	{
		return default(JNONPGBJGNA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x762EE0", Offset = "0x761CE0", VA = "0x180762EE0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public struct CCCPMPNPNDP
{
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public delegate bool ICIBAGIALFE(string MLGFNNIACIE, CCCPMPNPNDP EMOHODBDDIO);

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public int JAEAMOHJHNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public string NPFABOJEIOB;

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x5D54250", Offset = "0x5D53050", VA = "0x185D54250")]
	public static Dictionary<string, CCCPMPNPNDP> GHEOHOKCPOE(Type GOCAMACBFDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x5D53D60", Offset = "0x5D52B60", VA = "0x185D53D60")]
	public static Dictionary<string, CCCPMPNPNDP> FLMENDCBPOG(Type GOCAMACBFDC, ICIBAGIALFE NPMHPDAEJIM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x5D54580", Offset = "0x5D53380", VA = "0x185D54580")]
	public static Dictionary<int, string> HNKEPLGOFOE(Dictionary<string, CCCPMPNPNDP> JIHPAFENIMM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
[AttributeUsage(AttributeTargets.Enum)]
public abstract class IIPDAAOMMFK : PreserveAttribute
{
	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(Slot = "7")]
	public abstract string JJBOMBABIFH(string MFNMDNHFIBO);

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x772100", Offset = "0x770F00", VA = "0x180772100")]
	protected IIPDAAOMMFK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public abstract class EAGLHGKDHHG : IABAFDHJPAP
{
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	public static bool CLJPPEBOKPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private readonly string? GDCHLADJFBK;

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public virtual IABAFDHJPAP? DFHCBCFELOM
	{
		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x762EF0", Offset = "0x761CF0", VA = "0x180762EF0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x5D55070", Offset = "0x5D53E70", VA = "0x185D55070")]
	protected EAGLHGKDHHG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(Slot = "7")]
	public abstract string FIDCKDNNLBM();

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x5D54DD0", Offset = "0x5D53BD0", VA = "0x185D54DD0", Slot = "8")]
	public virtual string HIOHIJONBDL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x5D54B20", Offset = "0x5D53920", VA = "0x185D54B20", Slot = "9")]
	public void DKKDCADPOAA(StringBuilder AHDOKECFGPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x5D55010", Offset = "0x5D53E10", VA = "0x185D55010", Slot = "10")]
	public void OPOKDBOICNO(StringBuilder AHDOKECFGPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x5D54E50", Offset = "0x5D53C50", VA = "0x185D54E50", Slot = "11")]
	public void IKKNJCAHOGI(StringBuilder AHDOKECFGPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x5D549C0", Offset = "0x5D537C0", VA = "0x185D549C0", Slot = "12")]
	public void AGDMJNMMPMN(StringBuilder AHDOKECFGPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x5D54F70", Offset = "0x5D53D70", VA = "0x185D54F70")]
	public static void NPKBMFDJHPL(StringBuilder AHDOKECFGPD, string GHLBNBHOOGO, string GBAEFMNHFFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x50CEC20", Offset = "0x50CDA20", VA = "0x1850CEC20", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class FMHBJDBEPGG : Exception
{
	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x5D55460", Offset = "0x5D54260", VA = "0x185D55460")]
	public FMHBJDBEPGG(string JIGBFCEILIK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public class IMDNOFKFNBA<TErr> : FMHBJDBEPGG where TErr : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	public readonly TErr LHLAKMACAIO;

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x3691030", Offset = "0x368FE30", VA = "0x183691030")]
	private IMDNOFKFNBA([In] TErr JCDLFGBIJHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x3690F60", Offset = "0x368FD60", VA = "0x183690F60")]
	public static IMDNOFKFNBA<TErr> NPAOPBPEFCO([In] TErr JCDLFGBIJHO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public interface IABAFDHJPAP
{
	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(Slot = "0")]
	string HIOHIJONBDL();

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(Slot = "1")]
	string FIDCKDNNLBM();
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public interface AICFLDBEEBM<out TOptions> where TOptions : notnull
{
	[Cpp2IlInjected.Token(Token = "0x17000012")]
	TOptions GMPOHOAMMIO
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public interface GPEBDKMLLDB
{
	[Cpp2IlInjected.Token(Token = "0x17000013")]
	string PELBHLMGAJP
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public class EJAFJMGCPFG : Exception
{
	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x5D55400", Offset = "0x5D54200", VA = "0x185D55400")]
	public EJAFJMGCPFG(string JIGBFCEILIK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public class JBIDMEHDIAH<TOk> : EJAFJMGCPFG where TOk : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	public readonly TOk IHJEMCOJOFC;

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x3814A00", Offset = "0x3813800", VA = "0x183814A00")]
	private JBIDMEHDIAH([In] TOk DPBEBLPLACN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x305A3E0", Offset = "0x30591E0", VA = "0x18305A3E0")]
	public static JBIDMEHDIAH<TOk> NPAOPBPEFCO([In] TOk DPBEBLPLACN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public readonly struct IHFDHMKEEAA<TOk, TErr> : IEquatable<IHFDHMKEEAA<TOk, TErr>> where TOk : notnull where TErr : notnull
{
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private static readonly EqualityComparer<TErr> MCJBBIBLBNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	internal readonly TErr LHLAKMACAIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	internal readonly TOk IHJEMCOJOFC;

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public bool MPLHEPOIKIO
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x365E260", Offset = "0x365D060", VA = "0x18365E260")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public bool HBPNIFCGHLM
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x365DDE0", Offset = "0x365CBE0", VA = "0x18365DDE0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x3663E70", Offset = "0x3662C70", VA = "0x183663E70")]
	internal IHFDHMKEEAA([In] TErr JCDLFGBIJHO, [In] TOk DPBEBLPLACN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x3660280", Offset = "0x365F080", VA = "0x183660280")]
	public static IHFDHMKEEAA<TOk, TErr> LBPJEAPFFKH([In] TErr JCDLFGBIJHO)
	{
		return default(IHFDHMKEEAA<TOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x365FAF0", Offset = "0x365E8F0", VA = "0x18365FAF0")]
	public static IHFDHMKEEAA<TOk, TErr> HBHIALLDIMA([In] TOk DPBEBLPLACN)
	{
		return default(IHFDHMKEEAA<TOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x2284A60", Offset = "0x2283860", VA = "0x182284A60")]
	public IHFDHMKEEAA<UOk?, TErr?> GEGCHDOPMFC<UOk>()
	{
		return default(IHFDHMKEEAA<UOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x2285330", Offset = "0x2284130", VA = "0x182285330")]
	public IHFDHMKEEAA<UOk?, TErr?> MIECDPJKLMC<UOk>()
	{
		return default(IHFDHMKEEAA<UOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x2284500", Offset = "0x2283300", VA = "0x182284500")]
	public IHFDHMKEEAA<TOk?, UErr?> DIGLFHECDND<UErr>()
	{
		return default(IHFDHMKEEAA<TOk, UErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x365FDE0", Offset = "0x365EBE0", VA = "0x18365FDE0")]
	public IHFDHMKEEAA<LIGKMPLCELA, TErr> IHLOCJGJAJE()
	{
		return default(IHFDHMKEEAA<LIGKMPLCELA, TErr>);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x36611A0", Offset = "0x365FFA0", VA = "0x1836611A0")]
	public static bool NOLBLOCHCOA([In] IHFDHMKEEAA<TOk, TErr> HADGDMKFEOD, [In] IHFDHMKEEAA<TOk, TErr> CJIAEKJDMKM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x365D210", Offset = "0x365C010", VA = "0x18365D210", Slot = "4")]
	public bool Equals(IHFDHMKEEAA<TOk, TErr> MFMJJEFODHB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x365D090", Offset = "0x365BE90", VA = "0x18365D090", Slot = "0")]
	public override bool Equals(object MFMJJEFODHB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x365EF60", Offset = "0x365DD60", VA = "0x18365EF60", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x36633A0", Offset = "0x36621A0", VA = "0x1836633A0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public static class LADHGDEHHMH
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	[CompilerGenerated]
	private struct NGDHLPIFOCF<TOk, TErr> : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public AsyncTaskMethodBuilder<TOk> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public Task<IHFDHMKEEAA<TOk, TErr>> self;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private TaskAwaiter<IHFDHMKEEAA<TOk, TErr>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x3BCFE50", Offset = "0x3BCEC50", VA = "0x183BCFE50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x3BD0490", Offset = "0x3BCF290", VA = "0x183BD0490", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000029")]
	[CompilerGenerated]
	private sealed class NNCNGEOFCDP<TOk, TErr> : IEnumerable<TOk>, IEnumerable, IEnumerator<TOk>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private TOk <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private IEnumerable<IHFDHMKEEAA<TOk, TErr>> self;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public IEnumerable<IHFDHMKEEAA<TOk, TErr>> <>3__self;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private IEnumerator<IHFDHMKEEAA<TOk, TErr>> <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		TOk? IEnumerator<TOk>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000B1")]
			[Cpp2IlInjected.Address(RVA = "0x761640", Offset = "0x760440", VA = "0x180761640", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return (TOk?)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		object? IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000B3")]
			[Cpp2IlInjected.Address(RVA = "0x761640", Offset = "0x760440", VA = "0x180761640", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x863A90", Offset = "0x862890", VA = "0x180863A90")]
		[DebuggerHidden]
		public NNCNGEOFCDP(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x325F240", Offset = "0x325E040", VA = "0x18325F240", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x3BE6930", Offset = "0x3BE5730", VA = "0x183BE6930", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x3BE68E0", Offset = "0x3BE56E0", VA = "0x183BE68E0")]
		private void MPOCHKHBDOM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x3BE6D20", Offset = "0x3BE5B20", VA = "0x183BE6D20", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x3BE6C60", Offset = "0x3BE5A60", VA = "0x183BE6C60", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<TOk?>? IEnumerable<TOk>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x3263D50", Offset = "0x3262B50", VA = "0x183263D50", Slot = "5")]
		[DebuggerHidden]
		IEnumerator? IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x24040C0", Offset = "0x2402EC0", VA = "0x1824040C0")]
	public static IHFDHMKEEAA<TOk?, TErr?> IHJEMCOJOFC<TOk, TErr>([In] this IHFDHMKEEAA<TOk, TErr> LNKCIHFCLHG, [In] TOk DPBEBLPLACN)
	{
		return default(IHFDHMKEEAA<TOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x2404150", Offset = "0x2402F50", VA = "0x182404150")]
	public static IHFDHMKEEAA<LIGKMPLCELA, TErr?> IHJEMCOJOFC<TErr>([In] this IHFDHMKEEAA<LIGKMPLCELA, TErr> LNKCIHFCLHG)
	{
		return default(IHFDHMKEEAA<LIGKMPLCELA, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x24040C0", Offset = "0x2402EC0", VA = "0x1824040C0")]
	public static IHFDHMKEEAA<TOk?, TErr?> LHLAKMACAIO<TOk, TErr>([In] this IHFDHMKEEAA<TOk, TErr> LNKCIHFCLHG, [In] TErr JCDLFGBIJHO)
	{
		return default(IHFDHMKEEAA<TOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x2403E50", Offset = "0x2402C50", VA = "0x182403E50")]
	public static TOk? CMIHAFGHLML<TOk, TErr>([In] this IHFDHMKEEAA<TOk, TErr> LNKCIHFCLHG)
	{
		return (TOk?)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x24042C0", Offset = "0x24030C0", VA = "0x1824042C0")]
	[AsyncStateMachine(typeof(NGDHLPIFOCF<, >))]
	public static Task<TOk?>? JCJJPEHNOAE<TOk, TErr>(this Task<IHFDHMKEEAA<TOk, TErr>> LNKCIHFCLHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x2405420", Offset = "0x2404220", VA = "0x182405420")]
	public static TErr? PNOBNBCMPEM<TErr, TOk>([In] this IHFDHMKEEAA<TOk, TErr> LNKCIHFCLHG)
	{
		return (TErr?)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x2402E80", Offset = "0x2401C80", VA = "0x182402E80")]
	public static bool BBLNOPGFLFE<TOk, TErr, UErr, UOk>([In] this IHFDHMKEEAA<TOk, TErr> LNKCIHFCLHG, [Out] IHFDHMKEEAA<UOk, UErr> DIJBDHGGADO) where TErr : UErr?
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x2404F10", Offset = "0x2403D10", VA = "0x182404F10")]
	public static bool OINEKDBKCDI<TOk, TErr>([In] this IHFDHMKEEAA<TOk, TErr> LNKCIHFCLHG, [Out][NotNullWhen(true)] TOk DPBEBLPLACN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x2403B50", Offset = "0x2402950", VA = "0x182403B50")]
	public static bool CADLHIPDHCM<TOk, TErr>([In] this IHFDHMKEEAA<TOk, TErr> LNKCIHFCLHG, [Out][NotNullWhen(true)] TErr JCDLFGBIJHO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x24041D0", Offset = "0x2402FD0", VA = "0x1824041D0")]
	public static bool IOFMNEEOPJJ<TOk, TErr>([In] this IHFDHMKEEAA<TOk, TErr> LNKCIHFCLHG, [Out][NotNullWhen(true)] TOk DPBEBLPLACN, [Out][NotNullWhen(false)] TErr JCDLFGBIJHO) where TOk : notnull where TErr : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x2404560", Offset = "0x2403360", VA = "0x182404560")]
	public static bool JOCBEJNNMLH<TOk, TErr>([In] this IHFDHMKEEAA<TOk, TErr> LNKCIHFCLHG, [Out][NotNullWhen(true)] TOk DPBEBLPLACN, [Out] IHFDHMKEEAA<TOk, TErr> DIJBDHGGADO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x2402F90", Offset = "0x2401D90", VA = "0x182402F90")]
	public static bool BBLNOPGFLFE<TOk, TErr, UErr, UOk>([In] this IHFDHMKEEAA<TOk, TErr> LNKCIHFCLHG, [Out][NotNullWhen(true)] TOk DPBEBLPLACN, [Out] IHFDHMKEEAA<UOk, UErr> DIJBDHGGADO) where TErr : UErr?
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x2404730", Offset = "0x2403530", VA = "0x182404730")]
	public static bool LBGFANEHPKE<TOk, TErr>([In] this IHFDHMKEEAA<TOk, TErr> LNKCIHFCLHG, [Out][NotNullWhen(true)] TOk DPBEBLPLACN, [Out] IHFDHMKEEAA<LIGKMPLCELA, TErr> DIJBDHGGADO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x2404BF0", Offset = "0x24039F0", VA = "0x182404BF0")]
	public static IHFDHMKEEAA<UOk, UErr> NGOMFBFAKDG<UOk, UErr, TOk, TErr>([In] this IHFDHMKEEAA<TOk, TErr> LNKCIHFCLHG, [In] IHFDHMKEEAA<UOk, UErr> NGDHFFBLCOO) where TOk : UOk where TErr : UErr
	{
		return default(IHFDHMKEEAA<UOk, UErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x2404F80", Offset = "0x2403D80", VA = "0x182404F80")]
	public static IHFDHMKEEAA<TOk?[]?, TErr?> OJBCGPGMPAI<TOk, TErr>(this IEnumerable<IHFDHMKEEAA<TOk, TErr>> LNKCIHFCLHG)
	{
		return default(IHFDHMKEEAA<TOk[], TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x227A220", Offset = "0x2279020", VA = "0x18227A220")]
	[IteratorStateMachine(typeof(NNCNGEOFCDP<, >))]
	public static IEnumerable<TOk?>? FILHJJNNLPL<TOk, TErr>(this IEnumerable<IHFDHMKEEAA<TOk, TErr>> LNKCIHFCLHG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public static class FMKPBLKLHGG<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x2CEE4E0", Offset = "0x2CED2E0", VA = "0x182CEE4E0")]
	public static IHFDHMKEEAA<TOk, T> IHJEMCOJOFC<TOk>([In] TOk DPBEBLPLACN) where TOk : notnull
	{
		return default(IHFDHMKEEAA<TOk, T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x3407610", Offset = "0x3406410", VA = "0x183407610")]
	public static IHFDHMKEEAA<LIGKMPLCELA, T> IHJEMCOJOFC()
	{
		return default(IHFDHMKEEAA<LIGKMPLCELA, T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x2CEE4E0", Offset = "0x2CED2E0", VA = "0x182CEE4E0")]
	public static IHFDHMKEEAA<T, TErr> LHLAKMACAIO<TErr>([In] TErr JCDLFGBIJHO) where TErr : notnull
	{
		return default(IHFDHMKEEAA<T, TErr>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
[DefaultMember("Item")]
public sealed class ELEIJGMKKAB<T> : IEnumerable<T>, IEnumerable where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	private readonly struct AIDJCPJKOFF : IEnumerable<T>, IEnumerable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private readonly ELEIJGMKKAB<T> CACPHFDOACB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private readonly int IHDKJPJNLAE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private readonly bool HLFCPLPCFMB;

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x1B49D10", Offset = "0x1B48B10", VA = "0x181B49D10")]
		public AIDJCPJKOFF(ELEIJGMKKAB<T> BAHHCFCHDLD, int NNHMNHOJFAH, bool AOPMMCHPBND)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x35145E0", Offset = "0x35133E0", VA = "0x1835145E0")]
		public ELEIJGMKKAB<T>.DMMIPFHKODJ MIBGMGJFDKE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x35146D0", Offset = "0x35134D0", VA = "0x1835146D0", Slot = "5")]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x35146D0", Offset = "0x35134D0", VA = "0x1835146D0", Slot = "4")]
		IEnumerator<T> IEnumerable<T>.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002D")]
	public sealed class DMMIPFHKODJ : IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private readonly ELEIJGMKKAB<T> CACPHFDOACB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private readonly int NIPFDPIAJJJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private int GNMPNJODIBF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		private readonly bool HLFCPLPCFMB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private bool LJIAGLFCFBO;

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public T MNPEEGLNGOK
		{
			[Cpp2IlInjected.Token(Token = "0x60000CC")]
			[Cpp2IlInjected.Address(RVA = "0x4D08D80", Offset = "0x4D07B80", VA = "0x184D08D80")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		T IEnumerator<T>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000CD")]
			[Cpp2IlInjected.Address(RVA = "0x4D08EE0", Offset = "0x4D07CE0", VA = "0x184D08EE0", Slot = "4")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		object? IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000CE")]
			[Cpp2IlInjected.Address(RVA = "0x4D090A0", Offset = "0x4D07EA0", VA = "0x184D090A0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x4D094B0", Offset = "0x4D082B0", VA = "0x184D094B0")]
		public DMMIPFHKODJ(ELEIJGMKKAB<T> BAHHCFCHDLD, int NNHMNHOJFAH, bool AOPMMCHPBND)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x4D08CF0", Offset = "0x4D07AF0", VA = "0x184D08CF0", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x4D08E80", Offset = "0x4D07C80", VA = "0x184D08E80", Slot = "8")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x762EE0", Offset = "0x761CE0", VA = "0x180762EE0", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[CompilerGenerated]
	private sealed class JJHEDBFKELH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public Func<T> makeDefault;

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x76E9D0", Offset = "0x76D7D0", VA = "0x18076E9D0")]
		public JJHEDBFKELH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x38260E0", Offset = "0x3824EE0", VA = "0x1838260E0")]
		internal T ALHPMIMOIKG(int _)
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private readonly T[] IMJDOOJFOPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private int GNMPNJODIBF;

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public int PJKAHLIOIGO
	{
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x30624B0", Offset = "0x30612B0", VA = "0x1830624B0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public T MNPEEGLNGOK
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x3062530", Offset = "0x3061330", VA = "0x183062530")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public T PAJMFNOPIGC
	{
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x30623F0", Offset = "0x30611F0", VA = "0x1830623F0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public T BCEJDLMHPFK
	{
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x30622F0", Offset = "0x30610F0", VA = "0x1830622F0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public int DCLHHJJDFAJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x1506270", Offset = "0x1505070", VA = "0x181506270")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0xE256E0", Offset = "0xE244E0", VA = "0x180E256E0")]
	private static int ILLBNGMBDLH(int DOJILIOCHKM, int JMNJMKJAMOL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x3062620", Offset = "0x3061420", VA = "0x183062620")]
	public ELEIJGMKKAB(int MEDHPDICIDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x30627D0", Offset = "0x30615D0", VA = "0x1830627D0")]
	public ELEIJGMKKAB(int MEDHPDICIDE, Func<T> ENDMHBEFMAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x3062A90", Offset = "0x3061890", VA = "0x183062A90")]
	public ELEIJGMKKAB(T[] LJMPIGIKCCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x3062500", Offset = "0x3061300", VA = "0x183062500")]
	public void NNDCJFADDPM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x3062560", Offset = "0x3061360", VA = "0x183062560")]
	public IEnumerable<T> OMHIJMLJLPL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x3062420", Offset = "0x3061220", VA = "0x183062420")]
	public ELEIJGMKKAB<T>.DMMIPFHKODJ MIBGMGJFDKE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x3021BA0", Offset = "0x30209A0", VA = "0x183021BA0", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x3021BA0", Offset = "0x30209A0", VA = "0x183021BA0", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public static class FDGGFAINLLK
{
	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x23329F0", Offset = "0x23317F0", VA = "0x1823329F0")]
	public static ELEIJGMKKAB<T> NPAOPBPEFCO<T>(int MEDHPDICIDE, Func<T> ENDMHBEFMAL) where T : notnull
	{
		return null;
	}
}
namespace RecRoom.NoEngine.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	public struct RRColor : IEquatable<RRColor>, IFormattable
	{
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private const float kEpsilon = 1E-05f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public float r;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public float g;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public float b;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public float a;

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x1C29DF0", Offset = "0x1C28BF0", VA = "0x181C29DF0")]
		public RRColor(float HFPPDNNHFOK, float KEPNFOAIFAI, float JHKDDIMPPGN, float MACGGKMNKNM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x5D56BD0", Offset = "0x5D559D0", VA = "0x185D56BD0", Slot = "4")]
		public bool Equals(RRColor MFMJJEFODHB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x5D56C50", Offset = "0x5D55A50", VA = "0x185D56C50", Slot = "0")]
		public override bool Equals(object MFMJJEFODHB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x5D56D50", Offset = "0x5D55B50", VA = "0x185D56D50", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x5D56DD0", Offset = "0x5D55BD0", VA = "0x185D56DD0", Slot = "5")]
		public string ToString(string KFLIIANGBGC, IFormatProvider DBOLBCKCCPL)
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public sealed class OBFPNGDLHMM<TData> : EAGLHGKDHHG where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public readonly string PPDMEDDKMEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public readonly TData LJDFDHJOOIG;

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x761640", Offset = "0x760440", VA = "0x180761640", Slot = "7")]
	public override string FIDCKDNNLBM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x3C94E40", Offset = "0x3C93C40", VA = "0x183C94E40")]
	internal OBFPNGDLHMM(string JIGBFCEILIK, [In] TData PFDMLBFKIAP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public static class JENLJJNNANM
{
	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x216E360", Offset = "0x216D160", VA = "0x18216E360")]
	public static OBFPNGDLHMM<TData> NPAOPBPEFCO<TData>(string JIGBFCEILIK, [In] TData PFDMLBFKIAP) where TData : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public class GFFPBIAOJFD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	private readonly Dictionary<object, float> FAHEFJJEKHK;

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public float JNELJAKLFKC
	{
		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x7EE820", Offset = "0x7ED620", VA = "0x1807EE820")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x7EE8C0", Offset = "0x7ED6C0", VA = "0x1807EE8C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x5D55530", Offset = "0x5D54330", VA = "0x185D55530")]
	public void JPPNIIILNPH(float GNLEHBFFNFG, object PFKLELGAJPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x5D554C0", Offset = "0x5D542C0", VA = "0x185D554C0")]
	public void IGLDGAEFJDA(object PFKLELGAJPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x5D555A0", Offset = "0x5D543A0", VA = "0x185D555A0")]
	private void LIHCMPDFILF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x5D556D0", Offset = "0x5D544D0", VA = "0x185D556D0")]
	public GFFPBIAOJFD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public sealed class DMNGDJHPICB<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	[CompilerGenerated]
	private sealed class BNLIDDBMACN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public StringBuilder sb;

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x76E9D0", Offset = "0x76D7D0", VA = "0x18076E9D0")]
		public BNLIDDBMACN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x444B3A0", Offset = "0x444A1A0", VA = "0x18444B3A0")]
		internal int CCMIBOFNOAH(int i, T token)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	private HashSet<T>? GHECIKKJJFO;

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public IReadOnlyCollection<T> MBCDNEJHGOH
	{
		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x4D0B680", Offset = "0x4D0A480", VA = "0x184D0B680")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public bool CBNGLFIJJGK
	{
		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x4D0B810", Offset = "0x4D0A610", VA = "0x184D0B810")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public int CBILAPKHPBD
	{
		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x7658E0", Offset = "0x7646E0", VA = "0x1807658E0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x7658D0", Offset = "0x7646D0", VA = "0x1807658D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x4D0B510", Offset = "0x4D0A310", VA = "0x184D0B510")]
	public bool AAFNAGDLNDC(T PFKLELGAJPH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x4D0B6F0", Offset = "0x4D0A4F0", VA = "0x184D0B6F0")]
	public bool ILBKIBAINPM(T PFKLELGAJPH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x4D0B6B0", Offset = "0x4D0A4B0", VA = "0x184D0B6B0")]
	public bool FEMGIDLEFLP(T PFKLELGAJPH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x4D0B850", Offset = "0x4D0A650", VA = "0x184D0B850", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x76E9D0", Offset = "0x76D7D0", VA = "0x18076E9D0")]
	public DMNGDJHPICB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public class DMEPLNBDMIK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	private readonly string BBKDMDADEPB;

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x763A40", Offset = "0x762840", VA = "0x180763A40")]
	public DMEPLNBDMIK(string BBKDMDADEPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x5D54740", Offset = "0x5D53540", VA = "0x185D54740", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public sealed class IBKPFCNCMON
{
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	[CompilerGenerated]
	private sealed class ICDKONNDJDL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public StringBuilder sb;

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x76E9D0", Offset = "0x76D7D0", VA = "0x18076E9D0")]
		public ICDKONNDJDL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x5D55C00", Offset = "0x5D54A00", VA = "0x185D55C00")]
		internal int CCMIBOFNOAH(int i, object token)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	private HashSet<object>? GHECIKKJJFO;

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public IReadOnlyCollection<object> MBCDNEJHGOH
	{
		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x5D55840", Offset = "0x5D54640", VA = "0x185D55840")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public bool CBNGLFIJJGK
	{
		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x5D559D0", Offset = "0x5D547D0", VA = "0x185D559D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public int CBILAPKHPBD
	{
		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x7658E0", Offset = "0x7646E0", VA = "0x1807658E0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x7658D0", Offset = "0x7646D0", VA = "0x1807658D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x5D55760", Offset = "0x5D54560", VA = "0x185D55760")]
	public bool AAFNAGDLNDC(object PFKLELGAJPH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x5D55930", Offset = "0x5D54730", VA = "0x185D55930")]
	public bool ILBKIBAINPM(object PFKLELGAJPH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x5D558D0", Offset = "0x5D546D0", VA = "0x185D558D0")]
	public bool FEMGIDLEFLP(object PFKLELGAJPH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x5D559E0", Offset = "0x5D547E0", VA = "0x185D559E0")]
	public void OOLLPGOJDNC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x5D55A50", Offset = "0x5D54850", VA = "0x185D55A50", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x76E9D0", Offset = "0x76D7D0", VA = "0x18076E9D0")]
	public IBKPFCNCMON()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public class FGNJEGHKKBN<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	private struct LBDPFDLJLLN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		public float MOIPJLJDBHJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public T GMPOHOAMMIO;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private readonly Dictionary<object, LBDPFDLJLLN> FAHEFJJEKHK;

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public virtual T GCPMMAPKABP
	{
		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0xD5F440", Offset = "0xD5E240", VA = "0x180D5F440", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0xD5EA10", Offset = "0xD5D810", VA = "0x180D5EA10", Slot = "5")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public object? CHPBIOFHFAB
	{
		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x765900", Offset = "0x764700", VA = "0x180765900")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x7658F0", Offset = "0x7646F0", VA = "0x1807658F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public bool MEMHDGIHOIJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x33D9530", Offset = "0x33D8330", VA = "0x1833D9530")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x33D9000", Offset = "0x33D7E00", VA = "0x1833D9000")]
	public bool JPPNIIILNPH(T GNLEHBFFNFG, object PFKLELGAJPH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x33D8CA0", Offset = "0x33D7AA0", VA = "0x1833D8CA0")]
	public bool IGLDGAEFJDA(object PFKLELGAJPH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x33D8C70", Offset = "0x33D7A70", VA = "0x1833D8C70")]
	public void EOCKAINKMIG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x33D95F0", Offset = "0x33D83F0", VA = "0x1833D95F0")]
	public bool PGDPBMGNNCL(object PFKLELGAJPH, [Out] T GNLEHBFFNFG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x33D8670", Offset = "0x33D7470", VA = "0x1833D8670")]
	[FGKPKGHMHKE("T can be T?, `default!` shouldn't be necessary in C# 9")]
	private bool AENLNMPEOGK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x33D9910", Offset = "0x33D8710", VA = "0x1833D9910")]
	public FGNJEGHKKBN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public interface HMFMDANJGDM
{
	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event ALOCECILKMC HOIIKOIHLKA;
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public class PLICAFGMAMP : HMFMDANJGDM, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	public readonly struct KJHNBJOAAFN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public readonly float JPHPMPIIOOM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public readonly float NADIGMMCAIB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		internal readonly bool EHIDAKAHKBK;

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public float ALAHGBICDEI
		{
			[Cpp2IlInjected.Token(Token = "0x600010F")]
			[Cpp2IlInjected.Address(RVA = "0x5D55DE0", Offset = "0x5D54BE0", VA = "0x185D55DE0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x5D55F50", Offset = "0x5D54D50", VA = "0x185D55F50")]
		public KJHNBJOAAFN(float KMFMMHANJHK, float MCKBHHHCKCE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x5D55DF0", Offset = "0x5D54BF0", VA = "0x185D55DF0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003E")]
	[CompilerGenerated]
	private sealed class LJNOGJNLMIN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public PLICAFGMAMP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public int newProgressableIndex;

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x76E9D0", Offset = "0x76D7D0", VA = "0x18076E9D0")]
		public LJNOGJNLMIN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x5D560B0", Offset = "0x5D54EB0", VA = "0x185D560B0")]
		internal void AHGGECIJAMN(float innerProgress)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private readonly int DECKGNHFLHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private int HOBJJNBHIIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private readonly HMFMDANJGDM[] JELLFMOEFHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private readonly ALOCECILKMC[] EILPDJCOMNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private readonly KJHNBJOAAFN[] AMBNNLENGPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private KJHNBJOAAFN FAPEGOEEANA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private readonly EAEGPJJOHKN OGJNGCOANIB;

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event ALOCECILKMC HOIIKOIHLKA
	{
		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x5D56980", Offset = "0x5D55780", VA = "0x185D56980", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x5D56340", Offset = "0x5D55140", VA = "0x185D56340", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x5D56A40", Offset = "0x5D55840", VA = "0x185D56A40")]
	public PLICAFGMAMP(int DECKGNHFLHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x5D562B0", Offset = "0x5D550B0", VA = "0x185D562B0")]
	public EAEGPJJOHKN AODKECLPICM(KJHNBJOAAFN OCEFOKCLIAN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x5D56510", Offset = "0x5D55310", VA = "0x185D56510")]
	public void EDDHBKFOGHB(HMFMDANJGDM EEMMCAINFII, [Optional] KJHNBJOAAFN PIMFHIPGNPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x5D56400", Offset = "0x5D55200", VA = "0x185D56400", Slot = "6")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public delegate void ALOCECILKMC(float AAFIFKJHGBH);
[Cpp2IlInjected.Token(Token = "0x2000040")]
public static class JDODEGJDNOB
{
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	private class MPOJDJNCPHC : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		private readonly HMFMDANJGDM PIKGLINOKIG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		private readonly ALOCECILKMC MEKLMIFMFCO;

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x5D561A0", Offset = "0x5D54FA0", VA = "0x185D561A0")]
		public MPOJDJNCPHC(HMFMDANJGDM PIKGLINOKIG, ALOCECILKMC MEKLMIFMFCO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x5D56150", Offset = "0x5D54F50", VA = "0x185D56150", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x5D55D70", Offset = "0x5D54B70", VA = "0x185D55D70")]
	internal static bool JLHAFAJKLPK(float MACGGKMNKNM, float JHKDDIMPPGN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x5D4EC90", Offset = "0x5D4DA90", VA = "0x185D4EC90")]
	internal static float DLKFKOHMJLL(float MACGGKMNKNM)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x5D55CB0", Offset = "0x5D54AB0", VA = "0x185D55CB0")]
	public static IDisposable BKJNKNHKCNK(this HMFMDANJGDM PIKGLINOKIG, ALOCECILKMC MEKLMIFMFCO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public class EAEGPJJOHKN : HMFMDANJGDM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private float AAFIFKJHGBH;

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public float NJKDLAMFIDB
	{
		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x5D548D0", Offset = "0x5D536D0", VA = "0x185D548D0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public event ALOCECILKMC? HOIIKOIHLKA
	{
		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x5D54830", Offset = "0x5D53630", VA = "0x185D54830", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x5D54790", Offset = "0x5D53590", VA = "0x185D54790", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x76E9D0", Offset = "0x76D7D0", VA = "0x18076E9D0")]
	public EAEGPJJOHKN()
	{
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
