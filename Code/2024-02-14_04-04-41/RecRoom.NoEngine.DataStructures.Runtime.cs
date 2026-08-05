using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Microsoft.CodeAnalysis;

[assembly: AssemblyVersion("0.0.0.0")]
namespace Microsoft.CodeAnalysis
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class EmbeddedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x7C7B20", Offset = "0x7C6F20", VA = "0x1807C7B20")]
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
		[Cpp2IlInjected.Address(RVA = "0x5FF40F0", Offset = "0x5FF34F0", VA = "0x185FF40F0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x7C8560", Offset = "0x7C7960", VA = "0x1807C8560")]
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
		[Cpp2IlInjected.Address(RVA = "0x7C85A0", Offset = "0x7C79A0", VA = "0x1807C85A0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public abstract class KADOKHFKKHK
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x7A4800", Offset = "0x7A3C00", VA = "0x1807A4800")]
	protected KADOKHFKKHK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public abstract class EFPIIEDMBDG<T> : KADOKHFKKHK
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	protected struct OPGAIGAJKHP
	{
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		public enum CFOLGCOLGFK
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
		public CFOLGCOLGFK ADAMDPHPFAA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public T MCLCEMNNOFC;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private int GABEJNCELOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly bool MMCELDMNEIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	protected readonly bool KBONKPJBKKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	protected List<T>? MFFFNBMOHDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private List<OPGAIGAJKHP>? HKJLKBMNOOO;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public bool BALEFKMEOKM
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x31E0810", Offset = "0x31DFC10", VA = "0x1831E0810")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x31E0C30", Offset = "0x31E0030", VA = "0x1831E0C30")]
	protected EFPIIEDMBDG(bool KBONKPJBKKI, bool MMCELDMNEIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x31E0B90", Offset = "0x31DFF90", VA = "0x1831E0B90")]
	protected bool PHFHPOMAFMC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x31E0530", Offset = "0x31DF930", VA = "0x1831E0530")]
	protected void DHNLNFPFOPH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x31E0350", Offset = "0x31DF750", VA = "0x1831E0350")]
	protected void BHKKLLJLHNA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x221C260", Offset = "0x221B660", VA = "0x18221C260")]
	private static void CGGPKCFFGFD<U>(List<U>? EPNEAFACLDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x31E0630", Offset = "0x31DFA30", VA = "0x1831E0630", Slot = "4")]
	public void FLOHBAGDPJC(T MCLCEMNNOFC, bool BBNHGDKLLEC = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x31E0860", Offset = "0x31DFC60", VA = "0x1831E0860", Slot = "5")]
	public void NJHEJNEGCKN(T MCLCEMNNOFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x31E0A10", Offset = "0x31DFE10", VA = "0x1831E0A10")]
	public void NJLBNDAIMDB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface OBKMCFLFOCN
{
	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void FLOHBAGDPJC(Action MCLCEMNNOFC, bool BBNHGDKLLEC = false);

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void NJHEJNEGCKN(Action MCLCEMNNOFC);
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public sealed class KKEEGFAPLDK : EFPIIEDMBDG<Action>, OBKMCFLFOCN
{
	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x5FF2390", Offset = "0x5FF1790", VA = "0x185FF2390")]
	public KKEEGFAPLDK(bool KBONKPJBKKI = false, bool MMCELDMNEIG = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x5FF2130", Offset = "0x5FF1530", VA = "0x185FF2130")]
	public void HEMLICAMOIG()
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x5FF2330", Offset = "0x5FF1730", VA = "0x185FF2330")]
	public static KKEEGFAPLDK KILOAEIJEKO(KKEEGFAPLDK EFBBNAJCOID, Action MCLCEMNNOFC)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x5FF20D0", Offset = "0x5FF14D0", VA = "0x185FF20D0")]
	public static KKEEGFAPLDK DEAFAHIGGBI(KKEEGFAPLDK EFBBNAJCOID, Action MCLCEMNNOFC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface DIAOINMDBPG<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void FLOHBAGDPJC(Action<T> MCLCEMNNOFC, bool BBNHGDKLLEC = false);

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void NJHEJNEGCKN(Action<T> MCLCEMNNOFC);
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public sealed class PFEKNBHDJHH<T> : EFPIIEDMBDG<Action<T>>, DIAOINMDBPG<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x3725D40", Offset = "0x3725140", VA = "0x183725D40")]
	public PFEKNBHDJHH(bool KBONKPJBKKI = false, bool MMCELDMNEIG = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x3FA0940", Offset = "0x3F9FD40", VA = "0x183FA0940")]
	public void HEMLICAMOIG(T FENMDPNPDJP)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x3725CB0", Offset = "0x37250B0", VA = "0x183725CB0")]
	public static PFEKNBHDJHH<T> KILOAEIJEKO(PFEKNBHDJHH<T> EFBBNAJCOID, Action<T> MCLCEMNNOFC)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x3721E10", Offset = "0x3721210", VA = "0x183721E10")]
	public static PFEKNBHDJHH<T> DEAFAHIGGBI(PFEKNBHDJHH<T> EFBBNAJCOID, Action<T> MCLCEMNNOFC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface KBNIPMCDCMP<T, U> where T : notnull where U : notnull
{
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public sealed class APBBKGHGNMG<T, U> : EFPIIEDMBDG<Action<T, U>>, KBNIPMCDCMP<T, U> where T : notnull where U : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x3725D40", Offset = "0x3725140", VA = "0x183725D40")]
	public APBBKGHGNMG(bool KBONKPJBKKI = false, bool MMCELDMNEIG = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x3724EB0", Offset = "0x37242B0", VA = "0x183724EB0")]
	public void HEMLICAMOIG(T FENMDPNPDJP, U GCBKFJHNBKG)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x3725CB0", Offset = "0x37250B0", VA = "0x183725CB0")]
	public static APBBKGHGNMG<T, U> KILOAEIJEKO(APBBKGHGNMG<T, U> EFBBNAJCOID, Action<T, U> MCLCEMNNOFC)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x3721E10", Offset = "0x3721210", VA = "0x183721E10")]
	public static APBBKGHGNMG<T, U> DEAFAHIGGBI(APBBKGHGNMG<T, U> EFBBNAJCOID, Action<T, U> MCLCEMNNOFC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public sealed class IKPPCOONOBI<T, U, V> : EFPIIEDMBDG<Action<T, U, V>> where T : notnull where U : notnull where V : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x3725D40", Offset = "0x3725140", VA = "0x183725D40")]
	public IKPPCOONOBI(bool KBONKPJBKKI = false, bool MMCELDMNEIG = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x37C1A30", Offset = "0x37C0E30", VA = "0x1837C1A30")]
	public void HEMLICAMOIG(T FENMDPNPDJP, U GCBKFJHNBKG, V MHNPONMPDCG)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x3725CB0", Offset = "0x37250B0", VA = "0x183725CB0")]
	public static IKPPCOONOBI<T, U, V> KILOAEIJEKO(IKPPCOONOBI<T, U, V> EFBBNAJCOID, Action<T, U, V> MCLCEMNNOFC)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x3721E10", Offset = "0x3721210", VA = "0x183721E10")]
	public static IKPPCOONOBI<T, U, V> DEAFAHIGGBI(IKPPCOONOBI<T, U, V> EFBBNAJCOID, Action<T, U, V> MCLCEMNNOFC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface GLAJJENFHLJ<T, U, V, W>
{
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public sealed class NNLPCOMBHPP<T, U, V, W> : EFPIIEDMBDG<Action<T, U, V, W>>, GLAJJENFHLJ<T, U, V, W> where T : notnull where U : notnull where V : notnull where W : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x3725D40", Offset = "0x3725140", VA = "0x183725D40")]
	public NNLPCOMBHPP(bool KBONKPJBKKI = false, bool MMCELDMNEIG = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x3E117D0", Offset = "0x3E10BD0", VA = "0x183E117D0")]
	public void HEMLICAMOIG(T FENMDPNPDJP, U GCBKFJHNBKG, V MHNPONMPDCG, W LKDONMJJPCN)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x3725CB0", Offset = "0x37250B0", VA = "0x183725CB0")]
	public static NNLPCOMBHPP<T, U, V, W> KILOAEIJEKO(NNLPCOMBHPP<T, U, V, W> EFBBNAJCOID, Action<T, U, V, W> MCLCEMNNOFC)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x3721E10", Offset = "0x3721210", VA = "0x183721E10")]
	public static NNLPCOMBHPP<T, U, V, W> DEAFAHIGGBI(NNLPCOMBHPP<T, U, V, W> EFBBNAJCOID, Action<T, U, V, W> MCLCEMNNOFC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public sealed class NDHGGGMOPFH<T, U, V, W, X> : EFPIIEDMBDG<Action<T, U, V, W, X>>
{
	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x3725D40", Offset = "0x3725140", VA = "0x183725D40")]
	public NDHGGGMOPFH(bool KBONKPJBKKI = false, bool MMCELDMNEIG = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x3DF9500", Offset = "0x3DF8900", VA = "0x183DF9500")]
	public void HEMLICAMOIG(T FENMDPNPDJP, U GCBKFJHNBKG, V MHNPONMPDCG, W LKDONMJJPCN, X LGHEBJJLAGD)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x3725CB0", Offset = "0x37250B0", VA = "0x183725CB0")]
	public static NDHGGGMOPFH<T, U, V, W, X> KILOAEIJEKO(NDHGGGMOPFH<T, U, V, W, X> EFBBNAJCOID, Action<T, U, V, W, X> MCLCEMNNOFC)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x3721E10", Offset = "0x3721210", VA = "0x183721E10")]
	public static NDHGGGMOPFH<T, U, V, W, X> DEAFAHIGGBI(NDHGGGMOPFH<T, U, V, W, X> EFBBNAJCOID, Action<T, U, V, W, X> MCLCEMNNOFC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public sealed class BHJOJMJBMBG<T, U, V, W, X, Y> : EFPIIEDMBDG<Action<T, U, V, W, X, Y>>
{
	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x3725D40", Offset = "0x3725140", VA = "0x183725D40")]
	public BHJOJMJBMBG(bool KBONKPJBKKI = false, bool MMCELDMNEIG = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x45EE860", Offset = "0x45EDC60", VA = "0x1845EE860")]
	public void HEMLICAMOIG(T FENMDPNPDJP, U GCBKFJHNBKG, V MHNPONMPDCG, W LKDONMJJPCN, X LGHEBJJLAGD, Y FGIFEPPMILE)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x3725CB0", Offset = "0x37250B0", VA = "0x183725CB0")]
	public static BHJOJMJBMBG<T, U, V, W, X, Y> KILOAEIJEKO(BHJOJMJBMBG<T, U, V, W, X, Y> EFBBNAJCOID, Action<T, U, V, W, X, Y> MCLCEMNNOFC)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x3721E10", Offset = "0x3721210", VA = "0x183721E10")]
	public static BHJOJMJBMBG<T, U, V, W, X, Y> DEAFAHIGGBI(BHJOJMJBMBG<T, U, V, W, X, Y> EFBBNAJCOID, Action<T, U, V, W, X, Y> MCLCEMNNOFC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class NMNDOPJHNGE<TKey, TVal> where TKey : notnull where TVal : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly MJLLEPHHJHI<TKey, TVal> BEMPGJDEKNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	internal readonly Dictionary<TKey, (TVal value, int size)> CNONAMCJGGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private readonly int OCEJLAPIBJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private readonly MJLLEPHHJHI<TKey, TVal>.PPEICCCLIIN? KGEHLPHHEIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private int GOIIECFDOHN;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	internal int JCNCHEMNGCI
	{
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x3E10060", Offset = "0x3E0F460", VA = "0x183E10060")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public int GNOKEDLFEFM
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x8B8500", Offset = "0x8B7900", VA = "0x1808B8500")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x3E106A0", Offset = "0x3E0FAA0", VA = "0x183E106A0")]
	public NMNDOPJHNGE(int OCEJLAPIBJB, [Optional] MJLLEPHHJHI<TKey, TVal>.PPEICCCLIIN? KGEHLPHHEIL, [Optional] IEqualityComparer<TKey>? FJBNIHOMMJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x3E0FE90", Offset = "0x3E0F290", VA = "0x183E0FE90")]
	public void BBPLDEELCBF(TKey KCGLPAPOILB, TVal FDFHGIHHGHO, bool DJLLKAFPCPP = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x3E100B0", Offset = "0x3E0F4B0", VA = "0x183E100B0")]
	public bool EDHCABCMHIK(TKey KCGLPAPOILB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x3E105C0", Offset = "0x3E0F9C0", VA = "0x183E105C0")]
	public bool MFCFPLHBNLD(TKey JLHAOFBOAMO, [Out] TVal FDFHGIHHGHO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x3E10210", Offset = "0x3E0F610", VA = "0x183E10210")]
	private void GLHFDLMBPNK(TKey KCGLPAPOILB, TVal FDFHGIHHGHO, int BFFGCOIILMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x3E10430", Offset = "0x3E0F830", VA = "0x183E10430")]
	public bool LGMHHCNNEOD(TKey KCGLPAPOILB, TVal FDFHGIHHGHO, bool DJLLKAFPCPP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x3E10150", Offset = "0x3E0F550", VA = "0x183E10150")]
	private bool FAEMGLFNKGH(TKey KCGLPAPOILB)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class IKCHCEMKDEK : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private readonly Action HAMKLIIFHKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private bool DPEKFEGDLJG;

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x7ABBD0", Offset = "0x7AAFD0", VA = "0x1807ABBD0")]
	public IKCHCEMKDEK(Action NJNIBIJAKOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x5FF1E60", Offset = "0x5FF1260", VA = "0x185FF1E60", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x24E45D0", Offset = "0x24E39D0", VA = "0x1824E45D0")]
	public static DKOAJFJKKBO<T> NDFPICIGPEG<T>(T FDFHGIHHGHO, Action NJNIBIJAKOK) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public sealed class DKOAJFJKKBO<T> : IKCHCEMKDEK where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public T NAJOFLHMBPO
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x7A2270", Offset = "0x7A1670", VA = "0x1807A2270")]
		[CompilerGenerated]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x4EB2350", Offset = "0x4EB1750", VA = "0x184EB2350")]
	public DKOAJFJKKBO(T FDFHGIHHGHO, Action NJNIBIJAKOK)
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000017")]
public readonly struct JFHNBCMMCBM : IDisposable
{
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public readonly struct GNPEOHHFLMH : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x7E58B0", Offset = "0x7E4CB0", VA = "0x1807E58B0")]
		public static GNPEOHHFLMH JKJFENIAMEL()
		{
			return default(GNPEOHHFLMH);
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x79E370", Offset = "0x79D770", VA = "0x18079E370", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x7E58B0", Offset = "0x7E4CB0", VA = "0x1807E58B0")]
	public static JFHNBCMMCBM OGHELNAPKFG(Type ADAMDPHPFAA, [Optional] string? DHMELDCIENN, [Optional] string? BPKHIODBLAG, bool OBALHMCJMLE = false)
	{
		return default(JFHNBCMMCBM);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x7E58B0", Offset = "0x7E4CB0", VA = "0x1807E58B0")]
	public static JFHNBCMMCBM OGHELNAPKFG<T>([Optional] string? DHMELDCIENN, [Optional] string? BPKHIODBLAG, bool OBALHMCJMLE = false)
	{
		return default(JFHNBCMMCBM);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x79E370", Offset = "0x79D770", VA = "0x18079E370", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public struct NJECMKJCHLN
{
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public delegate bool ALNDINNGDFF(string MOFHKLOIPKE, NJECMKJCHLN DOEAANFMIPN);

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public int EPPCBJOAABF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public string FMHOOBGDDNM;

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x5FF32E0", Offset = "0x5FF26E0", VA = "0x185FF32E0")]
	public static Dictionary<string, NJECMKJCHLN> GIONMCBMGJF(Type BEDHMHDFJHM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x5FF3610", Offset = "0x5FF2A10", VA = "0x185FF3610")]
	public static Dictionary<string, NJECMKJCHLN> ODIDOILMHAH(Type BEDHMHDFJHM, ALNDINNGDFF IFENPEIBPKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x5FF3120", Offset = "0x5FF2520", VA = "0x185FF3120")]
	public static Dictionary<int, string> GDDEJPFIPIK(Dictionary<string, NJECMKJCHLN> JIBNFGIMNPP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public abstract class NOJMEPFJKIM : PKFDKDKJAIE
{
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	public static bool NBIMBBOGCCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private readonly string? JKDCHODMOKI;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public virtual PKFDKDKJAIE? DMFDDPGAOCC
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x79E380", Offset = "0x79D780", VA = "0x18079E380", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x5FF4080", Offset = "0x5FF3480", VA = "0x185FF4080")]
	protected NOJMEPFJKIM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(Slot = "7")]
	public abstract string GMMJBFEOGBG();

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x5FF4000", Offset = "0x5FF3400", VA = "0x185FF4000", Slot = "8")]
	public virtual string NMNGFLDOGJA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x5FF3D50", Offset = "0x5FF3150", VA = "0x185FF3D50", Slot = "9")]
	public void NMBHEJLHMCA(StringBuilder JCBFBOIDMHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x5FF3A70", Offset = "0x5FF2E70", VA = "0x185FF3A70", Slot = "10")]
	public void GACDJLNCILB(StringBuilder JCBFBOIDMHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x5FF3AD0", Offset = "0x5FF2ED0", VA = "0x185FF3AD0", Slot = "11")]
	public void GJBIODMIKJM(StringBuilder JCBFBOIDMHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x5FF3BF0", Offset = "0x5FF2FF0", VA = "0x185FF3BF0", Slot = "12")]
	public void LHLGPDNIGNH(StringBuilder JCBFBOIDMHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x5FF39D0", Offset = "0x5FF2DD0", VA = "0x185FF39D0")]
	public static void CKDKDALJJOO(StringBuilder JCBFBOIDMHE, string OIOEICOLCFK, string ICNDOBMEEGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x52892E0", Offset = "0x52886E0", VA = "0x1852892E0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class OOEPIKBKNCM : Exception
{
	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x5FF4170", Offset = "0x5FF3570", VA = "0x185FF4170")]
	public OOEPIKBKNCM(string DCKDMGKGDFN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class EHDKIPJCGGG<TErr> : OOEPIKBKNCM where TErr : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public readonly TErr FIFMAKOIIAI;

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x31E18B0", Offset = "0x31E0CB0", VA = "0x1831E18B0")]
	private EHDKIPJCGGG([In] TErr CMFELDDODDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x31E17E0", Offset = "0x31E0BE0", VA = "0x1831E17E0")]
	public static EHDKIPJCGGG<TErr> JKJFENIAMEL([In] TErr CMFELDDODDF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public interface PKFDKDKJAIE
{
	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(Slot = "0")]
	string NMNGFLDOGJA();

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(Slot = "1")]
	string GMMJBFEOGBG();
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public interface GDGKCKFKOJJ<out TOptions> where TOptions : notnull
{
	[Cpp2IlInjected.Token(Token = "0x17000006")]
	TOptions NAJOFLHMBPO
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public interface FCDLODPBFED
{
	[Cpp2IlInjected.Token(Token = "0x17000007")]
	string IKMDIGIALIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public class GNEEMLMGKHI : Exception
{
	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x5FF1DB0", Offset = "0x5FF11B0", VA = "0x185FF1DB0")]
	public GNEEMLMGKHI(string DCKDMGKGDFN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public class LNPJJHNIIGJ<TOk> : GNEEMLMGKHI where TOk : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public readonly TOk KFDAIKAACAG;

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x3B75290", Offset = "0x3B74690", VA = "0x183B75290")]
	private LNPJJHNIIGJ([In] TOk HBOAKAKCPDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x378ADD0", Offset = "0x378A1D0", VA = "0x18378ADD0")]
	public static LNPJJHNIIGJ<TOk> JKJFENIAMEL([In] TOk HBOAKAKCPDP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public readonly struct KKHLNMGODKL<TOk, TErr> : IEquatable<KKHLNMGODKL<TOk, TErr>> where TOk : notnull where TErr : notnull
{
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private static readonly EqualityComparer<TErr> PNPMBDCAIDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	internal readonly TErr FIFMAKOIIAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	internal readonly TOk KFDAIKAACAG;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public bool OHACJECCFBB
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x3A803F0", Offset = "0x3A7F7F0", VA = "0x183A803F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public bool GDAENDGNNIF
	{
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x3A80100", Offset = "0x3A7F500", VA = "0x183A80100")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x3A80DD0", Offset = "0x3A801D0", VA = "0x183A80DD0")]
	internal KKHLNMGODKL([In] TErr CMFELDDODDF, [In] TOk HBOAKAKCPDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x3A7EDD0", Offset = "0x3A7E1D0", VA = "0x183A7EDD0")]
	public static KKHLNMGODKL<TOk, TErr> BFJPNPEHDIL([In] TErr CMFELDDODDF)
	{
		return default(KKHLNMGODKL<TOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x3A80210", Offset = "0x3A7F610", VA = "0x183A80210")]
	public static KKHLNMGODKL<TOk, TErr> KDGOIKIJBMM([In] TOk HBOAKAKCPDP)
	{
		return default(KKHLNMGODKL<TOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x24DAC70", Offset = "0x24DA070", VA = "0x1824DAC70")]
	public KKHLNMGODKL<TOk?, UErr?> GKDILODOHMM<UErr>()
	{
		return default(KKHLNMGODKL<TOk, UErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x24DB480", Offset = "0x24DA880", VA = "0x1824DB480")]
	public KKHLNMGODKL<UOk?, TErr?> JCPCIFNNELI<UOk>()
	{
		return default(KKHLNMGODKL<UOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x24DA030", Offset = "0x24D9430", VA = "0x1824DA030")]
	public KKHLNMGODKL<UOk?, TErr?> FDJKEAILLFG<UOk>()
	{
		return default(KKHLNMGODKL<UOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x24DB9D0", Offset = "0x24DADD0", VA = "0x1824DB9D0")]
	public KKHLNMGODKL<TOk?, UErr?> KODOALIFPNN<UErr>()
	{
		return default(KKHLNMGODKL<TOk, UErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x3A7EFD0", Offset = "0x3A7E3D0", VA = "0x183A7EFD0")]
	public KKHLNMGODKL<PJHBHBBODGG, TErr> ELLEMAPEEPB()
	{
		return default(KKHLNMGODKL<PJHBHBBODGG, TErr>);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x3A7FC60", Offset = "0x3A7F060", VA = "0x183A7FC60")]
	public static bool FFFIMEBHMPG([In] KKHLNMGODKL<TOk, TErr> JIKBDKDLPCA, [In] KKHLNMGODKL<TOk, TErr> DOFNKPFHEKJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x3A7F370", Offset = "0x3A7E770", VA = "0x183A7F370", Slot = "4")]
	public bool Equals(KKHLNMGODKL<TOk, TErr> AAMIMDAKFMC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x3A7F1F0", Offset = "0x3A7E5F0", VA = "0x183A7F1F0", Slot = "0")]
	public override bool Equals(object AAMIMDAKFMC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x3A7FE10", Offset = "0x3A7F210", VA = "0x183A7FE10", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x3A80980", Offset = "0x3A7FD80", VA = "0x183A80980", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public static class GLDHEKPHIFL
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	[CompilerGenerated]
	private struct HKMPGCFICIK<TOk, TErr> : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public AsyncTaskMethodBuilder<TOk> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		public Task<KKHLNMGODKL<TOk, TErr>> self;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private TaskAwaiter<KKHLNMGODKL<TOk, TErr>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x36F1EF0", Offset = "0x36F12F0", VA = "0x1836F1EF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x36F2210", Offset = "0x36F1610", VA = "0x1836F2210", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x263C6C0", Offset = "0x263BAC0", VA = "0x18263C6C0")]
	public static KKHLNMGODKL<TOk?, TErr?> KFDAIKAACAG<TOk, TErr>([In] this KKHLNMGODKL<TOk, TErr> NHHBAHIFHJK, [In] TOk HBOAKAKCPDP)
	{
		return default(KKHLNMGODKL<TOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x263E4E0", Offset = "0x263D8E0", VA = "0x18263E4E0")]
	public static KKHLNMGODKL<PJHBHBBODGG, TErr?> KFDAIKAACAG<TErr>([In] this KKHLNMGODKL<PJHBHBBODGG, TErr> NHHBAHIFHJK)
	{
		return default(KKHLNMGODKL<PJHBHBBODGG, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x263C6C0", Offset = "0x263BAC0", VA = "0x18263C6C0")]
	public static KKHLNMGODKL<TOk?, TErr?> FIFMAKOIIAI<TOk, TErr>([In] this KKHLNMGODKL<TOk, TErr> NHHBAHIFHJK, [In] TErr CMFELDDODDF)
	{
		return default(KKHLNMGODKL<TOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x263DE50", Offset = "0x263D250", VA = "0x18263DE50")]
	public static TOk? HGLHDNKOEGO<TOk, TErr>([In] this KKHLNMGODKL<TOk, TErr> NHHBAHIFHJK)
	{
		return (TOk?)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x263D820", Offset = "0x263CC20", VA = "0x18263D820")]
	[AsyncStateMachine(typeof(HKMPGCFICIK<, >))]
	public static Task<TOk?>? GLBEDFPFBGG<TOk, TErr>(this Task<KKHLNMGODKL<TOk, TErr>> NHHBAHIFHJK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x263E120", Offset = "0x263D520", VA = "0x18263E120")]
	public static TErr? IDADJOLNKBH<TErr, TOk>([In] this KKHLNMGODKL<TOk, TErr> NHHBAHIFHJK)
	{
		return (TErr?)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x263C7D0", Offset = "0x263BBD0", VA = "0x18263C7D0")]
	public static bool GGEALMNHJMO<TOk, TErr, UErr, UOk>([In] this KKHLNMGODKL<TOk, TErr> NHHBAHIFHJK, [Out] KKHLNMGODKL<UOk, UErr> MIDPPLABCKI) where TErr : UErr?
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x263EC80", Offset = "0x263E080", VA = "0x18263EC80")]
	public static bool LIDJCJGKACK<TOk, TErr>([In] this KKHLNMGODKL<TOk, TErr> NHHBAHIFHJK, [Out][NotNullWhen(true)] TOk HBOAKAKCPDP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x263C600", Offset = "0x263BA00", VA = "0x18263C600")]
	public static bool EFCBPCCMCHE<TOk, TErr>([In] this KKHLNMGODKL<TOk, TErr> NHHBAHIFHJK, [Out][NotNullWhen(true)] TErr CMFELDDODDF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x263ECF0", Offset = "0x263E0F0", VA = "0x18263ECF0")]
	public static bool OIAAFCPEJHN<TOk, TErr>([In] this KKHLNMGODKL<TOk, TErr> NHHBAHIFHJK, [Out][NotNullWhen(true)] TOk HBOAKAKCPDP, [Out][NotNullWhen(false)] TErr CMFELDDODDF) where TOk : notnull where TErr : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x263E3E0", Offset = "0x263D7E0", VA = "0x18263E3E0")]
	public static bool JNFNPLPBEBM<TOk, TErr>([In] this KKHLNMGODKL<TOk, TErr> NHHBAHIFHJK, [Out][NotNullWhen(true)] TOk HBOAKAKCPDP, [Out] KKHLNMGODKL<TOk, TErr> MIDPPLABCKI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x263CA00", Offset = "0x263BE00", VA = "0x18263CA00")]
	public static bool GGEALMNHJMO<TOk, TErr, UErr, UOk>([In] this KKHLNMGODKL<TOk, TErr> NHHBAHIFHJK, [Out][NotNullWhen(true)] TOk HBOAKAKCPDP, [Out] KKHLNMGODKL<UOk, UErr> MIDPPLABCKI) where TErr : UErr?
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x263E920", Offset = "0x263DD20", VA = "0x18263E920")]
	public static bool LGLCMCEEHEO<TOk, TErr>([In] this KKHLNMGODKL<TOk, TErr> NHHBAHIFHJK, [Out][NotNullWhen(true)] TOk HBOAKAKCPDP, [Out] KKHLNMGODKL<PJHBHBBODGG, TErr> MIDPPLABCKI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x263C270", Offset = "0x263B670", VA = "0x18263C270")]
	public static KKHLNMGODKL<UOk, UErr> DBDGOCLNIHO<UOk, UErr, TOk, TErr>([In] this KKHLNMGODKL<TOk, TErr> NHHBAHIFHJK, [In] KKHLNMGODKL<UOk, UErr> JHEMNDMHNOB) where TOk : UOk where TErr : UErr
	{
		return default(KKHLNMGODKL<UOk, UErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x263E510", Offset = "0x263D910", VA = "0x18263E510")]
	public static KKHLNMGODKL<TOk?[]?, TErr?> LAFIGOHDHEP<TOk, TErr>(this IEnumerable<KKHLNMGODKL<TOk, TErr>> NHHBAHIFHJK)
	{
		return default(KKHLNMGODKL<TOk[], TErr>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public static class FDLPBEPKMKP<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x221C5D0", Offset = "0x221B9D0", VA = "0x18221C5D0")]
	public static KKHLNMGODKL<TOk, T> KFDAIKAACAG<TOk>([In] TOk HBOAKAKCPDP) where TOk : notnull
	{
		return default(KKHLNMGODKL<TOk, T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x3576DA0", Offset = "0x35761A0", VA = "0x183576DA0")]
	public static KKHLNMGODKL<PJHBHBBODGG, T> KFDAIKAACAG()
	{
		return default(KKHLNMGODKL<PJHBHBBODGG, T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x221C5D0", Offset = "0x221B9D0", VA = "0x18221C5D0")]
	public static KKHLNMGODKL<T, TErr> FIFMAKOIIAI<TErr>([In] TErr CMFELDDODDF) where TErr : notnull
	{
		return default(KKHLNMGODKL<T, TErr>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
[DefaultMember("Item")]
public sealed class IAGMEJPGGLG<T> : IEnumerable<T>, IEnumerable where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	private readonly struct HHHILCEKNCN : IEnumerable<T>, IEnumerable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private readonly IAGMEJPGGLG<T> FADHFJMFNKI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private readonly int DCLCGMJAAIL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private readonly bool OEIIBBIMCDL;

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x1C641E0", Offset = "0x1C635E0", VA = "0x181C641E0")]
		public HHHILCEKNCN(IAGMEJPGGLG<T> CEBGEIIIEAM, int IAIMCNINKBB, bool PGNFLNLCAJC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x36ED130", Offset = "0x36EC530", VA = "0x1836ED130")]
		public IAGMEJPGGLG<T>.DPAFKDKLFDE MFONJKCHJIL()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x36ED220", Offset = "0x36EC620", VA = "0x1836ED220", Slot = "5")]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x36ED220", Offset = "0x36EC620", VA = "0x1836ED220", Slot = "4")]
		IEnumerator<T> IEnumerable<T>.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public sealed class DPAFKDKLFDE : IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private readonly IAGMEJPGGLG<T> FADHFJMFNKI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private readonly int HDCMGFOEGED;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private int GJJACCEHJNF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private readonly bool OEIIBBIMCDL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private bool EHOOOIGPALP;

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public T FPOHGHGPMEE
		{
			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0x4EC2320", Offset = "0x4EC1720", VA = "0x184EC2320")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		T IEnumerator<T>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0x4EC2490", Offset = "0x4EC1890", VA = "0x184EC2490", Slot = "4")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		object? IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(RVA = "0x4EC25B0", Offset = "0x4EC19B0", VA = "0x184EC25B0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x4EC2BA0", Offset = "0x4EC1FA0", VA = "0x184EC2BA0")]
		public DPAFKDKLFDE(IAGMEJPGGLG<T> CEBGEIIIEAM, int IAIMCNINKBB, bool PGNFLNLCAJC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x4EC23E0", Offset = "0x4EC17E0", VA = "0x184EC23E0", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x4EC2470", Offset = "0x4EC1870", VA = "0x184EC2470", Slot = "8")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x79E370", Offset = "0x79D770", VA = "0x18079E370", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002A")]
	[CompilerGenerated]
	private sealed class MPCANHCKJKA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		public Func<T> makeDefault;

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x7A4800", Offset = "0x7A3C00", VA = "0x1807A4800")]
		public MPCANHCKJKA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x3D9D800", Offset = "0x3D9CC00", VA = "0x183D9D800")]
		internal T GOCEDAKMJLI(int _)
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private readonly T[] BILENEANONJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private int GJJACCEHJNF;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public int NJMBCBIIFBD
	{
		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x378B3F0", Offset = "0x378A7F0", VA = "0x18378B3F0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public T FPOHGHGPMEE
	{
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x356C4C0", Offset = "0x356B8C0", VA = "0x18356C4C0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public T OBADPIAFNKI
	{
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x378B3C0", Offset = "0x378A7C0", VA = "0x18378B3C0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public T BFKPGKFLJIC
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x378B360", Offset = "0x378A760", VA = "0x18378B360")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public int NDHLDPJEOPN
	{
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x1625620", Offset = "0x1624A20", VA = "0x181625620")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0xF26610", Offset = "0xF25A10", VA = "0x180F26610")]
	private static int MIIMNLFBFLM(int OJANCMLFDOJ, int CBKFAHCFHJN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x378B6F0", Offset = "0x378AAF0", VA = "0x18378B6F0")]
	public IAGMEJPGGLG(int BFFGCOIILMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x378B4D0", Offset = "0x378A8D0", VA = "0x18378B4D0")]
	public IAGMEJPGGLG(int BFFGCOIILMK, Func<T> AHOMMOMFKHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x378B940", Offset = "0x378AD40", VA = "0x18378B940")]
	public IAGMEJPGGLG(T[] NBBGPGGFMPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x378B240", Offset = "0x378A640", VA = "0x18378B240")]
	public void FEEPLGJILOF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x378B180", Offset = "0x378A580", VA = "0x18378B180")]
	public IEnumerable<T> AKEBJOHCODB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x378B440", Offset = "0x378A840", VA = "0x18378B440")]
	public IAGMEJPGGLG<T>.DPAFKDKLFDE MFONJKCHJIL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x31D6B70", Offset = "0x31D5F70", VA = "0x1831D6B70", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x31D6B70", Offset = "0x31D5F70", VA = "0x1831D6B70", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public static class EPIFGGBFNJG
{
	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x2510B20", Offset = "0x250FF20", VA = "0x182510B20")]
	public static IAGMEJPGGLG<T> JKJFENIAMEL<T>(int BFFGCOIILMK, Func<T> AHOMMOMFKHL) where T : notnull
	{
		return null;
	}
}
namespace RecRoom.NoEngine.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	public struct RRColor : IEquatable<RRColor>, IFormattable
	{
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private const float kEpsilon = 1E-05f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public float r;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public float g;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public float b;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public float a;

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x1D4C550", Offset = "0x1D4B950", VA = "0x181D4C550")]
		public RRColor(float FEDGKNJBNJN, float MFNGJNAICAH, float LFCFPOEDJCH, float MAGGDEMNFDG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x5FF4240", Offset = "0x5FF3640", VA = "0x185FF4240", Slot = "4")]
		public bool Equals(RRColor AAMIMDAKFMC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x5FF42C0", Offset = "0x5FF36C0", VA = "0x185FF42C0", Slot = "0")]
		public override bool Equals(object AAMIMDAKFMC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x5FF43C0", Offset = "0x5FF37C0", VA = "0x185FF43C0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x5FF4440", Offset = "0x5FF3840", VA = "0x185FF4440", Slot = "5")]
		public string ToString(string CLNBNIFIABA, IFormatProvider CFLJBPEPIHC)
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public sealed class PPHKGMCHEIH<T> : IDisposable where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	public readonly struct PFEBKAMHPIK : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private readonly PPHKGMCHEIH<T> LLDFFBKKKMF;

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public T NAJOFLHMBPO
		{
			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0x3F9ED10", Offset = "0x3F9E110", VA = "0x183F9ED10")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x3F9ECE0", Offset = "0x3F9E0E0", VA = "0x183F9ECE0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x8BBF70", Offset = "0x8BB370", VA = "0x1808BBF70")]
		public PFEBKAMHPIK(PPHKGMCHEIH<T> LLDFFBKKKMF)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[CompilerGenerated]
	private struct FENCFIKIDKM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public AsyncTaskMethodBuilder<PFEBKAMHPIK> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public PPHKGMCHEIH<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x357ABE0", Offset = "0x3579FE0", VA = "0x18357ABE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x3004F70", Offset = "0x3004370", VA = "0x183004F70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private readonly SemaphoreSlim FFIKGPDKLEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private T EDAECHJGCPN;

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x3FE2F40", Offset = "0x3FE2340", VA = "0x183FE2F40")]
	public PPHKGMCHEIH([In] T EDAECHJGCPN, int IGJOMFKAPJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x3FE2FE0", Offset = "0x3FE23E0", VA = "0x183FE2FE0")]
	public PPHKGMCHEIH([In] T EDAECHJGCPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x3FE2EC0", Offset = "0x3FE22C0", VA = "0x183FE2EC0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x3FE2F00", Offset = "0x3FE2300", VA = "0x183FE2F00")]
	public PFEBKAMHPIK JGFPJHGGHNM()
	{
		return default(PFEBKAMHPIK);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x3FE2DA0", Offset = "0x3FE21A0", VA = "0x183FE2DA0")]
	[AsyncStateMachine(typeof(PPHKGMCHEIH<>.FENCFIKIDKM))]
	public Task<PPHKGMCHEIH<T>.PFEBKAMHPIK> BHDBCONKGOD(CancellationToken HNLFPBLPOKJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x3FE2EE0", Offset = "0x3FE22E0", VA = "0x183FE2EE0")]
	public void HFBBMBGILNA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public static class PODFKOLNMDE
{
	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x5FF41D0", Offset = "0x5FF35D0", VA = "0x185FF41D0")]
	public static PPHKGMCHEIH<PJHBHBBODGG> JKJFENIAMEL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x26D9450", Offset = "0x26D8850", VA = "0x1826D9450")]
	public static PPHKGMCHEIH<T> JKJFENIAMEL<T>([In] T EDAECHJGCPN) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public sealed class PAPBDLFBJGK<T> : IDisposable where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	public readonly struct MFKMADJMJOO : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private readonly PAPBDLFBJGK<T> NOHCKNOFBEJ;

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public T NAJOFLHMBPO
		{
			[Cpp2IlInjected.Token(Token = "0x60000B2")]
			[Cpp2IlInjected.Address(RVA = "0x3D4E220", Offset = "0x3D4D620", VA = "0x183D4E220")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x3D4E100", Offset = "0x3D4D500", VA = "0x183D4E100", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x8BBF70", Offset = "0x8BB370", VA = "0x1808BBF70")]
		internal MFKMADJMJOO(PAPBDLFBJGK<T> LLDFFBKKKMF)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000033")]
	public readonly struct BLNPIIBOOKM : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private readonly PAPBDLFBJGK<T> NOHCKNOFBEJ;

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public T NAJOFLHMBPO
		{
			[Cpp2IlInjected.Token(Token = "0x60000B5")]
			[Cpp2IlInjected.Address(RVA = "0x3D4E220", Offset = "0x3D4D620", VA = "0x183D4E220")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x461C1B0", Offset = "0x461B5B0", VA = "0x18461C1B0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x8BBF70", Offset = "0x8BB370", VA = "0x1808BBF70")]
		internal BLNPIIBOOKM(PAPBDLFBJGK<T> LLDFFBKKKMF)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	[CompilerGenerated]
	private struct OMDHBBCPDGF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public AsyncTaskMethodBuilder<BLNPIIBOOKM> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public PAPBDLFBJGK<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private PPHKGMCHEIH<PJHBHBBODGG>.PFEBKAMHPIK <writeLock>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private TaskAwaiter<PPHKGMCHEIH<PJHBHBBODGG>.PFEBKAMHPIK> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x3EFC6A0", Offset = "0x3EFBAA0", VA = "0x183EFC6A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x3004F70", Offset = "0x3004370", VA = "0x183004F70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private readonly PPHKGMCHEIH<int> KGALJIBINHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private readonly PPHKGMCHEIH<PJHBHBBODGG> KGCLOBDNKAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private readonly PPHKGMCHEIH<PJHBHBBODGG> EFDLILIDFBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private T ABIAOLKOEAH;

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x3F85540", Offset = "0x3F84940", VA = "0x183F85540")]
	internal PAPBDLFBJGK(PPHKGMCHEIH<int> BPDGJKBHFDM, PPHKGMCHEIH<PJHBHBBODGG> AHGAJAILFKI, PPHKGMCHEIH<PJHBHBBODGG> DBPOKJNNNND, [In] T EDAECHJGCPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x3F84820", Offset = "0x3F83C20", VA = "0x183F84820", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x3F84920", Offset = "0x3F83D20", VA = "0x183F84920")]
	public MFKMADJMJOO MBGBGOCHAHN()
	{
		return default(MFKMADJMJOO);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x3F853D0", Offset = "0x3F847D0", VA = "0x183F853D0")]
	public BLNPIIBOOKM POJMGPDPHDM()
	{
		return default(BLNPIIBOOKM);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x3F850C0", Offset = "0x3F844C0", VA = "0x183F850C0")]
	[AsyncStateMachine(typeof(PAPBDLFBJGK<>.OMDHBBCPDGF))]
	public Task<PAPBDLFBJGK<T>.BLNPIIBOOKM> OIFOAMINDBG(CancellationToken HNLFPBLPOKJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public static class NELAIEJIDPJ
{
	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x5FF3050", Offset = "0x5FF2450", VA = "0x185FF3050")]
	public static PAPBDLFBJGK<PJHBHBBODGG> JKJFENIAMEL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x27680D0", Offset = "0x27674D0", VA = "0x1827680D0")]
	public static PAPBDLFBJGK<T> JKJFENIAMEL<T>([In] T EDAECHJGCPN) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public sealed class KFOFMIDIMKC<TData> : NOJMEPFJKIM where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	public readonly string FEMPLJOMNCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	public readonly TData IHMOEAABGNA;

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x79F170", Offset = "0x79E570", VA = "0x18079F170", Slot = "7")]
	public override string GMMJBFEOGBG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x3A691B0", Offset = "0x3A685B0", VA = "0x183A691B0")]
	internal KFOFMIDIMKC(string DCKDMGKGDFN, [In] TData MFNOAEFOKBK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public static class DEBDHNPNGFN
{
	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x5FF1930", Offset = "0x5FF0D30", VA = "0x185FF1930")]
	public static KFOFMIDIMKC<PJHBHBBODGG> JKJFENIAMEL(string DCKDMGKGDFN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x24E45D0", Offset = "0x24E39D0", VA = "0x1824E45D0")]
	public static KFOFMIDIMKC<TData> JKJFENIAMEL<TData>(string DCKDMGKGDFN, [In] TData MFNOAEFOKBK) where TData : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public class LECIONMHFPN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	private readonly Dictionary<object, float> PBLEFJPDFNN;

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public float HBKCHJFHKOI
	{
		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x8BB7D0", Offset = "0x8BABD0", VA = "0x1808BB7D0")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x8BB870", Offset = "0x8BAC70", VA = "0x1808BB870")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x5FF2520", Offset = "0x5FF1920", VA = "0x185FF2520")]
	public void JCJIKHJCHHK(float FDFHGIHHGHO, object FACMOGNGACN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x5FF2590", Offset = "0x5FF1990", VA = "0x185FF2590")]
	public void KFIFCFIPLDK(object FACMOGNGACN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x5FF23F0", Offset = "0x5FF17F0", VA = "0x185FF23F0")]
	private void GFHAEDEBADM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x5FF2600", Offset = "0x5FF1A00", VA = "0x185FF2600")]
	public LECIONMHFPN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public sealed class FGEOBMDKMFP<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	[CompilerGenerated]
	private sealed class AANJEFDFFHN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public StringBuilder sb;

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x7A4800", Offset = "0x7A3C00", VA = "0x1807A4800")]
		public AANJEFDFFHN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x362DF90", Offset = "0x362D390", VA = "0x18362DF90")]
		internal int PJNBJBDKOAM(int i, T token)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	private HashSet<T>? ALPAAFNCDOB;

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public IReadOnlyCollection<T> LNNDAGHEIDE
	{
		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x357C6D0", Offset = "0x357BAD0", VA = "0x18357C6D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public bool GKEEJKBHGEO
	{
		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x357C520", Offset = "0x357B920", VA = "0x18357C520")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public int OICIIFDIAGM
	{
		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x7A6920", Offset = "0x7A5D20", VA = "0x1807A6920")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x7A7070", Offset = "0x7A6470", VA = "0x1807A7070")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x357C560", Offset = "0x357B960", VA = "0x18357C560")]
	public bool FLOHBAGDPJC(T FACMOGNGACN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x357C740", Offset = "0x357BB40", VA = "0x18357C740")]
	public bool NJHEJNEGCKN(T FACMOGNGACN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x357C700", Offset = "0x357BB00", VA = "0x18357C700")]
	public bool NBEEIKJCOIK(T FACMOGNGACN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x357C860", Offset = "0x357BC60", VA = "0x18357C860", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x7A4800", Offset = "0x7A3C00", VA = "0x1807A4800")]
	public FGEOBMDKMFP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public class ICDJEGFNKHF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	private readonly string PKNHHJOMLDP;

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x7ABBD0", Offset = "0x7AAFD0", VA = "0x1807ABBD0")]
	public ICDJEGFNKHF(string PKNHHJOMLDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x5FF1E10", Offset = "0x5FF1210", VA = "0x185FF1E10", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public sealed class CIADAKDIJIG
{
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	[CompilerGenerated]
	private sealed class CFHEOMDFENA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public StringBuilder sb;

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x7A4800", Offset = "0x7A3C00", VA = "0x1807A4800")]
		public CFHEOMDFENA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x5FF13E0", Offset = "0x5FF07E0", VA = "0x185FF13E0")]
		internal int PJNBJBDKOAM(int i, object token)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	private HashSet<object>? ALPAAFNCDOB;

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public IReadOnlyCollection<object> LNNDAGHEIDE
	{
		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x5FF15F0", Offset = "0x5FF09F0", VA = "0x185FF15F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public bool GKEEJKBHGEO
	{
		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x5FF1500", Offset = "0x5FF0900", VA = "0x185FF1500")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public int OICIIFDIAGM
	{
		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x7A6920", Offset = "0x7A5D20", VA = "0x1807A6920")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x7A7070", Offset = "0x7A6470", VA = "0x1807A7070")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x5FF1510", Offset = "0x5FF0910", VA = "0x185FF1510")]
	public bool FLOHBAGDPJC(object FACMOGNGACN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x5FF16E0", Offset = "0x5FF0AE0", VA = "0x185FF16E0")]
	public bool NJHEJNEGCKN(object FACMOGNGACN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x5FF1680", Offset = "0x5FF0A80", VA = "0x185FF1680")]
	public bool NBEEIKJCOIK(object FACMOGNGACN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x5FF1490", Offset = "0x5FF0890", VA = "0x185FF1490")]
	public void AIINLGMCLCN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x5FF1780", Offset = "0x5FF0B80", VA = "0x185FF1780", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x7A4800", Offset = "0x7A3C00", VA = "0x1807A4800")]
	public CIADAKDIJIG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public class IGLHFMCOLGL<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	private struct CDHAFMINFEA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public float GGACJIFFJPI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public T NAJOFLHMBPO;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	private readonly Dictionary<object, CDHAFMINFEA> PBLEFJPDFNN;

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public virtual T BBNINFLHLFB
	{
		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0xE46B90", Offset = "0xE45F90", VA = "0x180E46B90", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0xE45590", Offset = "0xE44990", VA = "0x180E45590", Slot = "5")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public object? GKOLABDKGEB
	{
		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x79F100", Offset = "0x79E500", VA = "0x18079F100")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x7A2280", Offset = "0x7A1680", VA = "0x1807A2280")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public bool GFBKHLIEAHL
	{
		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x379F5E0", Offset = "0x379E9E0", VA = "0x18379F5E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x379EF20", Offset = "0x379E320", VA = "0x18379EF20")]
	public bool JCJIKHJCHHK(T FDFHGIHHGHO, object FACMOGNGACN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x3667F00", Offset = "0x3667300", VA = "0x183667F00")]
	public bool KFIFCFIPLDK(object FACMOGNGACN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x379F5B0", Offset = "0x379E9B0", VA = "0x18379F5B0")]
	public void NJLBNDAIMDB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x379F2B0", Offset = "0x379E6B0", VA = "0x18379F2B0")]
	public bool MFCFPLHBNLD(object FACMOGNGACN, [Out] T FDFHGIHHGHO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x379D400", Offset = "0x379C800", VA = "0x18379D400")]
	[FANKNDILCGJ("T can be T?, `default!` shouldn't be necessary in C# 9")]
	private bool FHLDKHHAFIF()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x379F630", Offset = "0x379EA30", VA = "0x18379F630")]
	public IGLHFMCOLGL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public interface EGKEAENJJOD
{
	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event DCAEKOCLCGM HLOOKCONAHB;
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public class MAADCOBIKJK : EGKEAENJJOD, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	public readonly struct FIHAGGBJBAC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public readonly float KDHLPBFNFLJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public readonly float GJADLDCIGOI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		internal readonly bool LIEFAHOJBOO;

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public float DPKBEHGMNCM
		{
			[Cpp2IlInjected.Token(Token = "0x60000F2")]
			[Cpp2IlInjected.Address(RVA = "0x5FF1AE0", Offset = "0x5FF0EE0", VA = "0x185FF1AE0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x5FF1C50", Offset = "0x5FF1050", VA = "0x185FF1C50")]
		public FIHAGGBJBAC(float AJOMPGHNEBN, float HPBGGHHMELE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x5FF1AF0", Offset = "0x5FF0EF0", VA = "0x185FF1AF0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000043")]
	[CompilerGenerated]
	private sealed class MBFDFFHPKCD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public MAADCOBIKJK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public int newProgressableIndex;

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x7A4800", Offset = "0x7A3C00", VA = "0x1807A4800")]
		public MBFDFFHPKCD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x5FF2FB0", Offset = "0x5FF23B0", VA = "0x185FF2FB0")]
		internal void CNDEADIMGJG(float innerProgress)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private readonly int NOOJMJOLDPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private int PBBHPMNOFEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private readonly EGKEAENJJOD[] INAMJJBODMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private readonly DCAEKOCLCGM[] CBKELGPMNJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private readonly FIHAGGBJBAC[] CPBDCLIHHCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private FIHAGGBJBAC MHLBLANIIEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private readonly INCDONFPCLI MHIMIIIPHAE;

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event DCAEKOCLCGM HLOOKCONAHB
	{
		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x5FF2860", Offset = "0x5FF1C60", VA = "0x185FF2860", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x5FF2690", Offset = "0x5FF1A90", VA = "0x185FF2690", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x5FF2E20", Offset = "0x5FF2220", VA = "0x185FF2E20")]
	public MAADCOBIKJK(int NOOJMJOLDPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x5FF2920", Offset = "0x5FF1D20", VA = "0x185FF2920")]
	public INCDONFPCLI LLIKOEOMCOJ(FIHAGGBJBAC DNGHAFFBABM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x5FF29B0", Offset = "0x5FF1DB0", VA = "0x185FF29B0")]
	public void NOLFJJEBEJA(EGKEAENJJOD FCEKELPBNBM, [Optional] FIHAGGBJBAC JOPGGPBKNLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x5FF2750", Offset = "0x5FF1B50", VA = "0x185FF2750", Slot = "6")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public delegate void DCAEKOCLCGM(float GFGPAAAJMHA);
[Cpp2IlInjected.Token(Token = "0x2000045")]
public static class EPCKCHJNDOE
{
	[Cpp2IlInjected.Token(Token = "0x2000046")]
	private class BKIBAIBPDKG : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		private readonly EGKEAENJJOD OKNCJBDPMLE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		private readonly DCAEKOCLCGM DBIEPHLOFKD;

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x5FF1350", Offset = "0x5FF0750", VA = "0x185FF1350")]
		public BKIBAIBPDKG(EGKEAENJJOD OKNCJBDPMLE, DCAEKOCLCGM DBIEPHLOFKD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x5FF1300", Offset = "0x5FF0700", VA = "0x185FF1300", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x5FF1A70", Offset = "0x5FF0E70", VA = "0x185FF1A70")]
	internal static bool OGLKKLEEOFI(float MAGGDEMNFDG, float LFCFPOEDJCH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x5FE59E0", Offset = "0x5FE4DE0", VA = "0x185FE59E0")]
	internal static float MACAPJAECCG(float MAGGDEMNFDG)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x5FF19B0", Offset = "0x5FF0DB0", VA = "0x185FF19B0")]
	public static IDisposable KNLLGAEFNFP(this EGKEAENJJOD OKNCJBDPMLE, DCAEKOCLCGM DBIEPHLOFKD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public class INCDONFPCLI : EGKEAENJJOD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private float GFGPAAAJMHA;

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public float AGCLJMPJOJC
	{
		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x5FF1F40", Offset = "0x5FF1340", VA = "0x185FF1F40")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public event DCAEKOCLCGM? HLOOKCONAHB
	{
		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x5FF2030", Offset = "0x5FF1430", VA = "0x185FF2030", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x5FF1EA0", Offset = "0x5FF12A0", VA = "0x185FF1EA0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x7A4800", Offset = "0x7A3C00", VA = "0x1807A4800")]
	public INCDONFPCLI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public class DAIAEPPEIAB : InvalidOperationException
{
	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x5ADEAC0", Offset = "0x5ADDEC0", VA = "0x185ADEAC0")]
	public DAIAEPPEIAB(string DCKDMGKGDFN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
[DefaultMember("Item")]
public class CCFIPONGHOF<TKey, TValue> : DKPBAPHLFEE<TKey, TValue>, IDictionary<TKey, TValue>, ICollection<KeyValuePair<TKey, TValue>>, IEnumerable<KeyValuePair<TKey, TValue>>, IEnumerable, CEFMKOMPDMH where TKey : notnull where TValue : notnull
{
	[Cpp2IlInjected.Token(Token = "0x200004A")]
	[CompilerGenerated]
	private sealed class BLFOGJOFPJJ : IEnumerator<KeyValuePair<TKey, TValue>>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		private KeyValuePair<TKey, TValue> <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public CCFIPONGHOF<TKey, TValue> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		private IEnumerator<KeyValuePair<TKey, TValue>> <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		KeyValuePair<TKey, TValue> IEnumerator<KeyValuePair<TKey, TValue>>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000123")]
			[Cpp2IlInjected.Address(RVA = "0xE46B90", Offset = "0xE45F90", VA = "0x180E46B90", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return default(KeyValuePair<TKey, TValue>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000125")]
			[Cpp2IlInjected.Address(RVA = "0x4616690", Offset = "0x4615A90", VA = "0x184616690", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x7A3830", Offset = "0x7A2C30", VA = "0x1807A3830")]
		[DebuggerHidden]
		public BLFOGJOFPJJ(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x34A6E50", Offset = "0x34A6250", VA = "0x1834A6E50", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x46161C0", Offset = "0x46155C0", VA = "0x1846161C0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x4615880", Offset = "0x4614C80", VA = "0x184615880")]
		private void DHKGKCPFHLK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x46159C0", Offset = "0x4614DC0", VA = "0x1846159C0")]
		private void GPHLLGKPILI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x4616640", Offset = "0x4615A40", VA = "0x184616640", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private readonly DKPBAPHLFEE<TKey, TValue> EFJPJEKBCBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private readonly IDictionary<TKey, TValue> NOMCGCIBJBH;

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public int OICIIFDIAGM
	{
		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x4866DE0", Offset = "0x48661E0", VA = "0x184866DE0", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public bool OAMNHFOMJCD
	{
		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x7E58B0", Offset = "0x7E4CB0", VA = "0x1807E58B0", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public TValue BFKPGKFLJIC
	{
		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x4866FB0", Offset = "0x48663B0", VA = "0x184866FB0", Slot = "4")]
		get
		{
			return (TValue)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x4867210", Offset = "0x4866610", VA = "0x184867210", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public ICollection<TKey> PHNAAMFGMLC
	{
		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x4866FF0", Offset = "0x48663F0", VA = "0x184866FF0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public ICollection<TValue> GIBFJBENMIN
	{
		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x4867100", Offset = "0x4866500", VA = "0x184867100", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x4866C60", Offset = "0x4866060", VA = "0x184866C60")]
	public CCFIPONGHOF(DKPBAPHLFEE<TKey, TValue> EFJPJEKBCBN, [Optional] IDictionary<TKey, TValue>? NOMCGCIBJBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x48648E0", Offset = "0x4863CE0", VA = "0x1848648E0", Slot = "15")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x4865190", Offset = "0x4864590", VA = "0x184865190")]
	public void DIPLPBAFIDG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x4864040", Offset = "0x4863440", VA = "0x184864040", Slot = "9")]
	public void Add(TKey KCGLPAPOILB, TValue FDFHGIHHGHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x4865500", Offset = "0x4864900", VA = "0x184865500")]
	public void KPIABGOFHIK(TKey KCGLPAPOILB, TValue FDFHGIHHGHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x4865780", Offset = "0x4864B80", VA = "0x184865780")]
	public void LGCDOAFMFIJ(TKey KCGLPAPOILB, TValue FDFHGIHHGHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x4865DD0", Offset = "0x48651D0", VA = "0x184865DD0")]
	public void OOJKDGKDIKK(TKey KCGLPAPOILB, TValue FDFHGIHHGHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x48659C0", Offset = "0x4864DC0", VA = "0x1848659C0")]
	public void LKALFPFIHNL(TKey KCGLPAPOILB, TValue FDFHGIHHGHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x48662A0", Offset = "0x48656A0", VA = "0x1848662A0", Slot = "14")]
	void ICollection<KeyValuePair<TKey, TValue>>.Add(KeyValuePair<TKey, TValue> ELCFHMHMPMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x4866480", Offset = "0x4865880", VA = "0x184866480", Slot = "16")]
	bool ICollection<KeyValuePair<TKey, TValue>>.Contains(KeyValuePair<TKey, TValue> ELCFHMHMPMJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x4866640", Offset = "0x4865A40", VA = "0x184866640", Slot = "18")]
	bool ICollection<KeyValuePair<TKey, TValue>>.Remove(KeyValuePair<TKey, TValue> ELCFHMHMPMJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x4864950", Offset = "0x4863D50", VA = "0x184864950", Slot = "8")]
	public bool ContainsKey(TKey KCGLPAPOILB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x4864560", Offset = "0x4863960", VA = "0x184864560")]
	public bool BOHJCNJKLMI(TKey KCGLPAPOILB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x4865300", Offset = "0x4864700", VA = "0x184865300")]
	public bool ICMGCLKFMJN(TKey KCGLPAPOILB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x4866010", Offset = "0x4865410", VA = "0x184866010", Slot = "10")]
	public bool Remove(TKey KCGLPAPOILB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x48669D0", Offset = "0x4865DD0", VA = "0x1848669D0", Slot = "11")]
	public bool TryGetValue(TKey KCGLPAPOILB, [Out] TValue FDFHGIHHGHO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x4864AA0", Offset = "0x4863EA0", VA = "0x184864AA0", Slot = "17")]
	public void CopyTo(KeyValuePair<TKey, TValue>[] NIKMHLBDDHG, int HHFBBAINCMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x48669A0", Offset = "0x4865DA0", VA = "0x1848669A0", Slot = "20")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x48651E0", Offset = "0x48645E0", VA = "0x1848651E0", Slot = "19")]
	[IteratorStateMachine(typeof(CCFIPONGHOF<, >.BLFOGJOFPJJ))]
	public IEnumerator<KeyValuePair<TKey, TValue>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x4865AB0", Offset = "0x4864EB0", VA = "0x184865AB0", Slot = "21")]
	public bool OBNDHDJALHM()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x48647E0", Offset = "0x4863BE0", VA = "0x1848647E0")]
	private TValue CEKONABIKIC(TKey KCGLPAPOILB)
	{
		return (TValue)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
public interface CEFMKOMPDMH
{
	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool OBNDHDJALHM();
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public interface DKPBAPHLFEE<TKey, TVal> : IDictionary<TKey, TVal>, ICollection<KeyValuePair<TKey, TVal>>, IEnumerable<KeyValuePair<TKey, TVal>>, IEnumerable, CEFMKOMPDMH
{
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
[DefaultMember("Item")]
public sealed class MJLLEPHHJHI<TKey, TVal> : DKPBAPHLFEE<TKey, TVal>, IDictionary<TKey, TVal>, ICollection<KeyValuePair<TKey, TVal>>, IEnumerable<KeyValuePair<TKey, TVal>>, IEnumerable, CEFMKOMPDMH where TKey : notnull where TVal : notnull
{
	[Cpp2IlInjected.Token(Token = "0x200004E")]
	public delegate int PPEICCCLIIN(TKey KCGLPAPOILB, TVal FDFHGIHHGHO);

	[Cpp2IlInjected.Token(Token = "0x200004F")]
	private class ANHGFGMDIAF
	{
		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public TKey JFBDDAMOHDF
		{
			[Cpp2IlInjected.Token(Token = "0x600014E")]
			[Cpp2IlInjected.Address(RVA = "0xB58670", Offset = "0xB57A70", VA = "0x180B58670")]
			[CompilerGenerated]
			get
			{
				return (TKey)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public TVal NAJOFLHMBPO
		{
			[Cpp2IlInjected.Token(Token = "0x600014F")]
			[Cpp2IlInjected.Address(RVA = "0x8B8500", Offset = "0x8B7900", VA = "0x1808B8500")]
			[CompilerGenerated]
			get
			{
				return (TVal)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000150")]
			[Cpp2IlInjected.Address(RVA = "0x8B8510", Offset = "0x8B7910", VA = "0x1808B8510")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public int DPKBEHGMNCM
		{
			[Cpp2IlInjected.Token(Token = "0x6000151")]
			[Cpp2IlInjected.Address(RVA = "0x7DC8F0", Offset = "0x7DBCF0", VA = "0x1807DC8F0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000152")]
			[Cpp2IlInjected.Address(RVA = "0x7DC410", Offset = "0x7DB810", VA = "0x1807DC410")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public DateTimeOffset OJGKNKOMDMF
		{
			[Cpp2IlInjected.Token(Token = "0x6000153")]
			[Cpp2IlInjected.Address(RVA = "0xA1E930", Offset = "0xA1DD30", VA = "0x180A1E930")]
			[CompilerGenerated]
			get
			{
				return default(DateTimeOffset);
			}
			[Cpp2IlInjected.Token(Token = "0x6000154")]
			[Cpp2IlInjected.Address(RVA = "0x1243420", Offset = "0x1242820", VA = "0x181243420")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x3672EB0", Offset = "0x36722B0", VA = "0x183672EB0")]
		public ANHGFGMDIAF(TKey KCGLPAPOILB, TVal HHFKHHNHDLP)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000051")]
	[CompilerGenerated]
	private sealed class AHKHAFHGIAM : IEnumerator<KeyValuePair<TKey, TVal>>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		private KeyValuePair<TKey, TVal> <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		public MJLLEPHHJHI<TKey, TVal> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		private LinkedList<ANHGFGMDIAF>.Enumerator <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		KeyValuePair<TKey, TVal> IEnumerator<KeyValuePair<TKey, TVal>>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600015E")]
			[Cpp2IlInjected.Address(RVA = "0xE46B90", Offset = "0xE45F90", VA = "0x180E46B90", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return default(KeyValuePair<TKey, TVal>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000160")]
			[Cpp2IlInjected.Address(RVA = "0x36398C0", Offset = "0x3638CC0", VA = "0x1836398C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x7A3830", Offset = "0x7A2C30", VA = "0x1807A3830")]
		[DebuggerHidden]
		public AHKHAFHGIAM(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x34A1050", Offset = "0x34A0450", VA = "0x1834A1050", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x3639170", Offset = "0x3638570", VA = "0x183639170", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x3638AF0", Offset = "0x3637EF0", VA = "0x183638AF0")]
		private void DHKGKCPFHLK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x36397D0", Offset = "0x3638BD0", VA = "0x1836397D0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400006D")]
	public const int KJCGGBEDEJN = -1;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private readonly Dictionary<TKey, LinkedListNode<ANHGFGMDIAF>> KBIEHEANPIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private readonly LinkedList<ANHGFGMDIAF> HDHLGFFPMBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private readonly PPEICCCLIIN? KGEHLPHHEIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private readonly TimeSpan ADGNMGBOHNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private readonly POIPBNPALLD LICENKOBCFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	private bool ODCLMHMKEAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	private readonly List<TKey> DOFNDAJGDKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	private readonly List<TVal> KEOBMCEINNH;

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public int GNOKEDLFEFM
	{
		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x7BB410", Offset = "0x7BA810", VA = "0x1807BB410")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	internal int JCNCHEMNGCI
	{
		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x7BB420", Offset = "0x7BA820", VA = "0x1807BB420")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0xE3F050", Offset = "0xE3E450", VA = "0x180E3F050")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public int OICIIFDIAGM
	{
		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x3D850D0", Offset = "0x3D844D0", VA = "0x183D850D0", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	internal int GIIBMGHCPFN
	{
		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x3A6E740", Offset = "0x3A6DB40", VA = "0x183A6E740")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public ICollection<TVal> GIBFJBENMIN
	{
		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x3D85200", Offset = "0x3D84600", VA = "0x183D85200", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	ICollection<TKey> IDictionary<TKey, TVal>.FIJEHJGNBGK
	{
		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x3D80DC0", Offset = "0x3D801C0", VA = "0x183D80DC0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public bool OAMNHFOMJCD
	{
		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x7E58B0", Offset = "0x7E4CB0", VA = "0x1807E58B0", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public TVal BFKPGKFLJIC
	{
		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x3D85130", Offset = "0x3D84530", VA = "0x183D85130", Slot = "4")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x3D85290", Offset = "0x3D84690", VA = "0x183D85290", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x3D7FF60", Offset = "0x3D7F360", VA = "0x183D7FF60")]
	private bool PICIMKIPILE(int NOOJMJOLDPD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x3D7C960", Offset = "0x3D7BD60", VA = "0x183D7C960")]
	private void GKKENCLOGAH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x3D81CD0", Offset = "0x3D810D0", VA = "0x183D81CD0")]
	public MJLLEPHHJHI(int NOOJMJOLDPD, [Optional] PPEICCCLIIN? KGEHLPHHEIL, [Optional] IEqualityComparer<TKey>? FJBNIHOMMJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x3D81F50", Offset = "0x3D81350", VA = "0x183D81F50")]
	public MJLLEPHHJHI(TimeSpan ADGNMGBOHNA, [Optional] IEqualityComparer<TKey>? FJBNIHOMMJI, [Optional] POIPBNPALLD? LICENKOBCFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x3D81E50", Offset = "0x3D81250", VA = "0x183D81E50")]
	public MJLLEPHHJHI(int NOOJMJOLDPD, TimeSpan ADGNMGBOHNA, [Optional] IEqualityComparer<TKey>? FJBNIHOMMJI, [Optional] POIPBNPALLD? LICENKOBCFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x3D83A90", Offset = "0x3D82E90", VA = "0x183D83A90")]
	public MJLLEPHHJHI(int NOOJMJOLDPD, PPEICCCLIIN? KGEHLPHHEIL, TimeSpan ADGNMGBOHNA, [Optional] IEqualityComparer<TKey>? FJBNIHOMMJI, [Optional] POIPBNPALLD? LICENKOBCFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x3D7FEF0", Offset = "0x3D7F2F0", VA = "0x183D7FEF0", Slot = "21")]
	public bool OBNDHDJALHM()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x3D7D590", Offset = "0x3D7C990", VA = "0x183D7D590", Slot = "22")]
	public bool HHIKCDPOOFP(int BFFGCOIILMK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x3D736C0", Offset = "0x3D72AC0", VA = "0x183D736C0")]
	private bool AJDLKIKFEFE(int BFFGCOIILMK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x3D75160", Offset = "0x3D74560", VA = "0x183D75160")]
	public void BDBEANEDBLI(TKey KCGLPAPOILB, TVal FDFHGIHHGHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x3D74590", Offset = "0x3D73990", VA = "0x183D74590", Slot = "14")]
	public void Add(KeyValuePair<TKey, TVal> ELCFHMHMPMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x3D749F0", Offset = "0x3D73DF0", VA = "0x183D749F0", Slot = "9")]
	public void Add(TKey KCGLPAPOILB, TVal FDFHGIHHGHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x3D76BA0", Offset = "0x3D75FA0", VA = "0x183D76BA0", Slot = "8")]
	public bool ContainsKey(TKey KCGLPAPOILB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x3D80330", Offset = "0x3D7F730", VA = "0x183D80330", Slot = "16")]
	bool ICollection<KeyValuePair<TKey, TVal>>.Contains(KeyValuePair<TKey, TVal> ELCFHMHMPMJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x3D80090", Offset = "0x3D7F490", VA = "0x183D80090", Slot = "10")]
	public bool Remove(TKey KCGLPAPOILB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x3D80A50", Offset = "0x3D7FE50", VA = "0x183D80A50", Slot = "18")]
	bool ICollection<KeyValuePair<TKey, TVal>>.Remove(KeyValuePair<TKey, TVal> ELCFHMHMPMJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x3D73190", Offset = "0x3D72590", VA = "0x183D73190")]
	private bool AADKCBDLBJK(TKey KCGLPAPOILB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x3D7FC10", Offset = "0x3D7F010", VA = "0x183D7FC10")]
	private TVal JNDPLHMHPON(TKey JLHAOFBOAMO)
	{
		return (TVal)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x3D816E0", Offset = "0x3D80AE0", VA = "0x183D816E0", Slot = "11")]
	public bool TryGetValue(TKey JLHAOFBOAMO, [Out] TVal FDFHGIHHGHO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x3D76A70", Offset = "0x3D75E70", VA = "0x183D76A70", Slot = "15")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x3D78790", Offset = "0x3D77B90", VA = "0x183D78790", Slot = "17")]
	public void CopyTo(KeyValuePair<TKey, TVal>[] NIKMHLBDDHG, int HHFBBAINCMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x3D7BBE0", Offset = "0x3D7AFE0", VA = "0x183D7BBE0")]
	private bool EGDEIKFHJDG(ANHGFGMDIAF LFFHAICKOJM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x3D79170", Offset = "0x3D78570", VA = "0x183D79170")]
	private void EBJFHKGJJBB(LinkedListNode<ANHGFGMDIAF> KOHJGJBKPIF, TVal AIIPFNKEHOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x3D7E180", Offset = "0x3D7D580", VA = "0x183D7E180")]
	private void JCJIKHJCHHK(TKey KCGLPAPOILB, TVal FDFHGIHHGHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x3D762F0", Offset = "0x3D756F0", VA = "0x183D762F0")]
	private void BHJGGAGKGAG(ANHGFGMDIAF LFFHAICKOJM, TVal AIIPFNKEHOL, int FFHOJDHOGBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x3D7CE40", Offset = "0x3D7C240", VA = "0x183D7CE40", Slot = "19")]
	[IteratorStateMachine(typeof(MJLLEPHHJHI<, >.AHKHAFHGIAM))]
	public IEnumerator<KeyValuePair<TKey, TVal>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x3D80DF0", Offset = "0x3D801F0", VA = "0x183D80DF0", Slot = "20")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
public class BLIICMKNCDA<TId, TResource> : IEnumerable<(TId, Task<TResource>, int)>, IEnumerable where TId : notnull where TResource : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000053")]
	[CompilerGenerated]
	private sealed class BJEAKCMLBNK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public Func<TId, CancellationToken, Task<TResource>> factory;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public BLIICMKNCDA<TId, TResource> <>4__this;

		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x7A4800", Offset = "0x7A3C00", VA = "0x1807A4800")]
		public BJEAKCMLBNK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x460C2B0", Offset = "0x460B6B0", VA = "0x18460C2B0")]
		internal Task<TResource> MBGNNGIBCNN(TId _id)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000054")]
	[CompilerGenerated]
	private struct AIHAIAGNOBM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		public Task<TResource> task;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		public Dictionary<Task<TResource>, CancellationTokenSource> cancellationTokenSources;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public CancellationTokenSource cts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		private TaskAwaiter<TResource> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x364FB50", Offset = "0x364EF50", VA = "0x18364FB50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x364FF30", Offset = "0x364F330", VA = "0x18364FF30", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000055")]
	[CompilerGenerated]
	private struct FCAKMHHOOCC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		public Task<TResource> task;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		public Action<TResource> cleanup;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		private TaskAwaiter<TResource> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x3575130", Offset = "0x3574530", VA = "0x183575130", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x35755F0", Offset = "0x35749F0", VA = "0x1835755F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	private readonly KLNFOPBEMME<TId, Task<TResource>> MLMOPCBIHDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	private readonly Dictionary<Task<TResource>, CancellationTokenSource> HFMECHOJFJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	private readonly Func<TId, CancellationToken, Task<TResource>>? OKOGJPMAIAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	private readonly Action<TResource>? FOIEOEEAEFG;

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x46183E0", Offset = "0x46177E0", VA = "0x1846183E0")]
	public BLIICMKNCDA(int GJODBLAILPJ = 0, [Optional] IEqualityComparer<TId>? CLDGIOLDPBJ, [Optional] Func<TId, CancellationToken, Task<TResource>>? ACHLACIFFGN, [Optional] Action<TResource>? BPIHDLJOLGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x4617820", Offset = "0x4616C20", VA = "0x184617820")]
	public DKOAJFJKKBO<Task<TResource>> CHLPPFFEBAE(TId PDDHPPHOJPD, [Optional] Func<TId, CancellationToken, Task<TResource>>? ACHLACIFFGN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x4617FF0", Offset = "0x46173F0", VA = "0x184617FF0")]
	private void OILCGOGDJGI(Task<TResource> CKAKCFLCDJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x4617EB0", Offset = "0x46172B0", VA = "0x184617EB0")]
	public void MMNBAHCLFKO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x4617DD0", Offset = "0x46171D0", VA = "0x184617DD0")]
	public KLNFOPBEMME<TId, Task<TResource>>.MIICNLNGJIG MFONJKCHJIL()
	{
		return default(KLNFOPBEMME<TId, Task<TResource>>.MIICNLNGJIG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x46182B0", Offset = "0x46176B0", VA = "0x1846182B0", Slot = "4")]
	private IEnumerator<(TId, Task<TResource>, int)> System.Collections.Generic.IEnumerable<(TIdId,System.Threading.Tasks.Task<TResource>LoadResourceTask,System.Int32RefCount)>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x46182B0", Offset = "0x46176B0", VA = "0x1846182B0", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x4617B00", Offset = "0x4616F00", VA = "0x184617B00")]
	[CompilerGenerated]
	[AsyncStateMachine(typeof(BLIICMKNCDA<, >.AIHAIAGNOBM))]
	internal static Task FNIKEGKGNFJ(Task<TResource> CKAKCFLCDJK, CancellationTokenSource MDMFFOLEAMP, Dictionary<Task<TResource>, CancellationTokenSource> ALBJJABJKGM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x46172A0", Offset = "0x46166A0", VA = "0x1846172A0")]
	[AsyncStateMachine(typeof(BLIICMKNCDA<, >.FCAKMHHOOCC))]
	[CompilerGenerated]
	internal static Task BNKCMNADABB(Task<TResource> CKAKCFLCDJK, Action<TResource> NKPJBBBDDPM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
public class KLNFOPBEMME<TKey, TValue> : IEnumerable<(TKey, TValue, int)>, IEnumerable where TKey : notnull where TValue : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000057")]
	private sealed class OPNHEAJGAOB : IEquatable<OPNHEAJGAOB>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		public readonly TValue NAJOFLHMBPO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		public int OFLNCFGJKJB;

		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x1BC5ED0", Offset = "0x1BC52D0", VA = "0x181BC5ED0")]
		public OPNHEAJGAOB(TValue FDFHGIHHGHO, int PNJDIDJFDGJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x3F03680", Offset = "0x3F02A80", VA = "0x183F03680", Slot = "4")]
		public bool Equals(OPNHEAJGAOB? AAMIMDAKFMC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x3F03710", Offset = "0x3F02B10", VA = "0x183F03710", Slot = "0")]
		public override bool Equals(object? MBCPMMHPENP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x3F03840", Offset = "0x3F02C40", VA = "0x183F03840", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000058")]
	public struct MIICNLNGJIG : IEnumerator<(TKey, TValue, int)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		private Dictionary<TKey, OPNHEAJGAOB>.Enumerator ECGFDGFLICA;

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600017F")]
			[Cpp2IlInjected.Address(RVA = "0x3D687F0", Offset = "0x3D67BF0", VA = "0x183D687F0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public (TKey Key, TValue Value, int RefCount) FPOHGHGPMEE
		{
			[Cpp2IlInjected.Token(Token = "0x6000180")]
			[Cpp2IlInjected.Address(RVA = "0x3D68B90", Offset = "0x3D67F90", VA = "0x183D68B90", Slot = "4")]
			get
			{
				return default((TKey, TValue, int));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x3D68940", Offset = "0x3D67D40", VA = "0x183D68940")]
		public MIICNLNGJIG(KLNFOPBEMME<TKey, TValue> PBLEFJPDFNN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x3D68440", Offset = "0x3D67840", VA = "0x183D68440", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x3D684C0", Offset = "0x3D678C0", VA = "0x183D684C0", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x3D685F0", Offset = "0x3D679F0", VA = "0x183D685F0", Slot = "8")]
		public void Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000059")]
	[CompilerGenerated]
	private sealed class PGEMNMEMJAE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		public KLNFOPBEMME<TKey, TValue> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		public TKey key;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		public OPNHEAJGAOB refCountedValue;

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x7A4800", Offset = "0x7A3C00", VA = "0x1807A4800")]
		public PGEMNMEMJAE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x3FA59B0", Offset = "0x3FA4DB0", VA = "0x183FA59B0")]
		internal void MBGNNGIBCNN()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private readonly Dictionary<TKey, OPNHEAJGAOB> KOJBKBMPOJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private readonly Func<TKey, TValue>? IOAOOPLKBBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private readonly Action<TValue>? BDCJFFKPDAA;

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x3A98D60", Offset = "0x3A98160", VA = "0x183A98D60")]
	public KLNFOPBEMME(int GJODBLAILPJ = 0, [Optional] IEqualityComparer<TKey>? FJBNIHOMMJI, [Optional] Func<TKey, TValue>? EFLMEFDEHPC, [Optional] Action<TValue>? HOJJAHGBEHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x3A97CB0", Offset = "0x3A970B0", VA = "0x183A97CB0")]
	public DKOAJFJKKBO<TValue> CHLPPFFEBAE(TKey KCGLPAPOILB, [Optional] Func<TKey, TValue>? JIFPACEMJBG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x3A98420", Offset = "0x3A97820", VA = "0x183A98420")]
	private void FLLAKBFBGHI(TKey KCGLPAPOILB, OPNHEAJGAOB FAPEJKPMDCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x3A985E0", Offset = "0x3A979E0", VA = "0x183A985E0")]
	public void MMNBAHCLFKO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x3A985A0", Offset = "0x3A979A0", VA = "0x183A985A0")]
	public MIICNLNGJIG MFONJKCHJIL()
	{
		return default(MIICNLNGJIG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x3A98B90", Offset = "0x3A97F90", VA = "0x183A98B90", Slot = "4")]
	private IEnumerator<(TKey, TValue, int)> System.Collections.Generic.IEnumerable<(TKeyKey,TValueValue,System.Int32RefCount)>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x3A98B90", Offset = "0x3A97F90", VA = "0x183A98B90", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
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
