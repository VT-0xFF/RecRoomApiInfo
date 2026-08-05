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
		[Cpp2IlInjected.Address(RVA = "0x788D90", Offset = "0x787B90", VA = "0x180788D90")]
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
		[Cpp2IlInjected.Address(RVA = "0x5CFF110", Offset = "0x5CFDF10", VA = "0x185CFF110")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x789560", Offset = "0x788360", VA = "0x180789560")]
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
		[Cpp2IlInjected.Address(RVA = "0x7895A0", Offset = "0x7883A0", VA = "0x1807895A0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public abstract class HDFFHGIALNL
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x75E150", Offset = "0x75CF50", VA = "0x18075E150")]
	protected HDFFHGIALNL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public abstract class HJJJAEENHBG<T> : HDFFHGIALNL
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	protected struct MGPHJBNKHAP
	{
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		public enum KBDMFDMCCPC
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
		public KBDMFDMCCPC FLHOFPAHPKL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public T IPGJPNDBCJD;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private int GHMFKALBMIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly bool MFMFOICEADP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	protected readonly bool MHFMAJJOIDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	protected List<T>? HIAIEFMBODB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private List<MGPHJBNKHAP>? CKGAGBCLKMM;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public bool JFJDLBGJIJC
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x35E32B0", Offset = "0x35E20B0", VA = "0x1835E32B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x35E38B0", Offset = "0x35E26B0", VA = "0x1835E38B0")]
	protected HJJJAEENHBG(bool MHFMAJJOIDE, bool MFMFOICEADP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x35E3810", Offset = "0x35E2610", VA = "0x1835E3810")]
	protected bool OJIJDHDABJG()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x35E2FD0", Offset = "0x35E1DD0", VA = "0x1835E2FD0")]
	protected void DPGIPBHBLOH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x35E3300", Offset = "0x35E2100", VA = "0x1835E3300")]
	protected void KANOFBFBELC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x22A8580", Offset = "0x22A7380", VA = "0x1822A8580")]
	private static void NMKICKOFHCB<U>(List<U>? MJLHCFFNENL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x35E30D0", Offset = "0x35E1ED0", VA = "0x1835E30D0", Slot = "4")]
	public void EJEJBLJEAIN(T IPGJPNDBCJD, bool JEEDCHKJMPI = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x35E34E0", Offset = "0x35E22E0", VA = "0x1835E34E0", Slot = "5")]
	public void KCJHGNBNEJA(T IPGJPNDBCJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x35E3690", Offset = "0x35E2490", VA = "0x1835E3690")]
	public void LHLJEDFLAKN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface BJAOHGBKOIO
{
	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void EJEJBLJEAIN(Action IPGJPNDBCJD, bool JEEDCHKJMPI = false);

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void KCJHGNBNEJA(Action IPGJPNDBCJD);
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public sealed class HJOHDOIHOEL : HJJJAEENHBG<Action>, BJAOHGBKOIO
{
	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x5CFDFA0", Offset = "0x5CFCDA0", VA = "0x185CFDFA0")]
	public HJOHDOIHOEL(bool MHFMAJJOIDE = false, bool MFMFOICEADP = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x5CFDCE0", Offset = "0x5CFCAE0", VA = "0x185CFDCE0")]
	public void FKGDFLCAOJM()
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x5CFDF40", Offset = "0x5CFCD40", VA = "0x185CFDF40")]
	public static HJOHDOIHOEL JBOMEKIAFFI(HJOHDOIHOEL KOAEBLFOOIP, Action IPGJPNDBCJD)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x5CFDEE0", Offset = "0x5CFCCE0", VA = "0x185CFDEE0")]
	public static HJOHDOIHOEL GNMMJMJKAMO(HJOHDOIHOEL KOAEBLFOOIP, Action IPGJPNDBCJD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface MLGLLEJHKEC<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void EJEJBLJEAIN(Action<T> IPGJPNDBCJD, bool JEEDCHKJMPI = false);

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void KCJHGNBNEJA(Action<T> IPGJPNDBCJD);
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public sealed class KAPCIBMFMEE<T> : HJJJAEENHBG<Action<T>>, MLGLLEJHKEC<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x304E4F0", Offset = "0x304D2F0", VA = "0x18304E4F0")]
	public KAPCIBMFMEE(bool MHFMAJJOIDE = false, bool MFMFOICEADP = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x3890990", Offset = "0x388F790", VA = "0x183890990")]
	public void FKGDFLCAOJM(T EGGPNONKPNJ)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x304E460", Offset = "0x304D260", VA = "0x18304E460")]
	public static KAPCIBMFMEE<T> JBOMEKIAFFI(KAPCIBMFMEE<T> KOAEBLFOOIP, Action<T> IPGJPNDBCJD)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x304E3D0", Offset = "0x304D1D0", VA = "0x18304E3D0")]
	public static KAPCIBMFMEE<T> GNMMJMJKAMO(KAPCIBMFMEE<T> KOAEBLFOOIP, Action<T> IPGJPNDBCJD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface DOBMMDHNBNE<T, U> where T : notnull where U : notnull
{
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public sealed class LOHPOAFOAMK<T, U> : HJJJAEENHBG<Action<T, U>>, DOBMMDHNBNE<T, U> where T : notnull where U : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x304E4F0", Offset = "0x304D2F0", VA = "0x18304E4F0")]
	public LOHPOAFOAMK(bool MHFMAJJOIDE = false, bool MFMFOICEADP = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x3995F50", Offset = "0x3994D50", VA = "0x183995F50")]
	public void FKGDFLCAOJM(T EGGPNONKPNJ, U NBENGMJKPEI)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x304E460", Offset = "0x304D260", VA = "0x18304E460")]
	public static LOHPOAFOAMK<T, U> JBOMEKIAFFI(LOHPOAFOAMK<T, U> KOAEBLFOOIP, Action<T, U> IPGJPNDBCJD)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x304E3D0", Offset = "0x304D1D0", VA = "0x18304E3D0")]
	public static LOHPOAFOAMK<T, U> GNMMJMJKAMO(LOHPOAFOAMK<T, U> KOAEBLFOOIP, Action<T, U> IPGJPNDBCJD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public sealed class ALHAAKPBCNN<T, U, V> : HJJJAEENHBG<Action<T, U, V>> where T : notnull where U : notnull where V : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x304E4F0", Offset = "0x304D2F0", VA = "0x18304E4F0")]
	public ALHAAKPBCNN(bool MHFMAJJOIDE = false, bool MFMFOICEADP = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x34B7D50", Offset = "0x34B6B50", VA = "0x1834B7D50")]
	public void FKGDFLCAOJM(T EGGPNONKPNJ, U NBENGMJKPEI, V ABBNPGBNHJD)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x304E460", Offset = "0x304D260", VA = "0x18304E460")]
	public static ALHAAKPBCNN<T, U, V> JBOMEKIAFFI(ALHAAKPBCNN<T, U, V> KOAEBLFOOIP, Action<T, U, V> IPGJPNDBCJD)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x304E3D0", Offset = "0x304D1D0", VA = "0x18304E3D0")]
	public static ALHAAKPBCNN<T, U, V> GNMMJMJKAMO(ALHAAKPBCNN<T, U, V> KOAEBLFOOIP, Action<T, U, V> IPGJPNDBCJD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface CILJHLJOKLK<T, U, V, W>
{
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public sealed class ENFICHHJAOO<T, U, V, W> : HJJJAEENHBG<Action<T, U, V, W>>, CILJHLJOKLK<T, U, V, W> where T : notnull where U : notnull where V : notnull where W : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x304E4F0", Offset = "0x304D2F0", VA = "0x18304E4F0")]
	public ENFICHHJAOO(bool MHFMAJJOIDE = false, bool MFMFOICEADP = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x304DBD0", Offset = "0x304C9D0", VA = "0x18304DBD0")]
	public void FKGDFLCAOJM(T EGGPNONKPNJ, U NBENGMJKPEI, V ABBNPGBNHJD, W NHNDDOIAEPK)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x304E460", Offset = "0x304D260", VA = "0x18304E460")]
	public static ENFICHHJAOO<T, U, V, W> JBOMEKIAFFI(ENFICHHJAOO<T, U, V, W> KOAEBLFOOIP, Action<T, U, V, W> IPGJPNDBCJD)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x304E3D0", Offset = "0x304D1D0", VA = "0x18304E3D0")]
	public static ENFICHHJAOO<T, U, V, W> GNMMJMJKAMO(ENFICHHJAOO<T, U, V, W> KOAEBLFOOIP, Action<T, U, V, W> IPGJPNDBCJD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public sealed class BAKFNCNMGLI<T, U, V, W, X> : HJJJAEENHBG<Action<T, U, V, W, X>>
{
	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x304E4F0", Offset = "0x304D2F0", VA = "0x18304E4F0")]
	public BAKFNCNMGLI(bool MHFMAJJOIDE = false, bool MFMFOICEADP = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x4419C60", Offset = "0x4418A60", VA = "0x184419C60")]
	public void FKGDFLCAOJM(T EGGPNONKPNJ, U NBENGMJKPEI, V ABBNPGBNHJD, W NHNDDOIAEPK, X NPDPLEIHBMM)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x304E460", Offset = "0x304D260", VA = "0x18304E460")]
	public static BAKFNCNMGLI<T, U, V, W, X> JBOMEKIAFFI(BAKFNCNMGLI<T, U, V, W, X> KOAEBLFOOIP, Action<T, U, V, W, X> IPGJPNDBCJD)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x304E3D0", Offset = "0x304D1D0", VA = "0x18304E3D0")]
	public static BAKFNCNMGLI<T, U, V, W, X> GNMMJMJKAMO(BAKFNCNMGLI<T, U, V, W, X> KOAEBLFOOIP, Action<T, U, V, W, X> IPGJPNDBCJD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public sealed class PCKADFGBLLN<T, U, V, W, X, Y> : HJJJAEENHBG<Action<T, U, V, W, X, Y>>
{
	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x304E4F0", Offset = "0x304D2F0", VA = "0x18304E4F0")]
	public PCKADFGBLLN(bool MHFMAJJOIDE = false, bool MFMFOICEADP = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x3D8F420", Offset = "0x3D8E220", VA = "0x183D8F420")]
	public void FKGDFLCAOJM(T EGGPNONKPNJ, U NBENGMJKPEI, V ABBNPGBNHJD, W NHNDDOIAEPK, X NPDPLEIHBMM, Y CINKHPOEGPD)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x304E460", Offset = "0x304D260", VA = "0x18304E460")]
	public static PCKADFGBLLN<T, U, V, W, X, Y> JBOMEKIAFFI(PCKADFGBLLN<T, U, V, W, X, Y> KOAEBLFOOIP, Action<T, U, V, W, X, Y> IPGJPNDBCJD)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x304E3D0", Offset = "0x304D1D0", VA = "0x18304E3D0")]
	public static PCKADFGBLLN<T, U, V, W, X, Y> GNMMJMJKAMO(PCKADFGBLLN<T, U, V, W, X, Y> KOAEBLFOOIP, Action<T, U, V, W, X, Y> IPGJPNDBCJD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class JPJEOGHEMMN<TKey, TVal> where TKey : notnull where TVal : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly PHDJOGCKOJN<TKey, TVal> BIPEBBDDNJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	internal readonly Dictionary<TKey, (TVal value, int size)> AEAGNLOGKPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private readonly int GHGLBOLLGFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private readonly PHDJOGCKOJN<TKey, TVal>.IFDOMOFBJEM? BNDMEFEDKBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private int GIIFFPPFBHD;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	internal int GFHKKACHALK
	{
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x3865890", Offset = "0x3864690", VA = "0x183865890")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public int NPIMCONFHFK
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x806B40", Offset = "0x805940", VA = "0x180806B40")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x38658E0", Offset = "0x38646E0", VA = "0x1838658E0")]
	public JPJEOGHEMMN(int GHGLBOLLGFA, [Optional] PHDJOGCKOJN<TKey, TVal>.IFDOMOFBJEM? BNDMEFEDKBN, [Optional] IEqualityComparer<TKey>? PIKDPJAMHBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x3865530", Offset = "0x3864330", VA = "0x183865530")]
	public void OEABKPDKIDM(TKey GMOPMNAPKBE, TVal POACLGOFKAJ, bool BKHABMKMEMJ = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x38650D0", Offset = "0x3863ED0", VA = "0x1838650D0")]
	public bool FBMKJODBPCN(TKey GMOPMNAPKBE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x3865390", Offset = "0x3864190", VA = "0x183865390")]
	public bool HOKMFLFGDOM(TKey HDKPFIPOEJB, [Out] TVal POACLGOFKAJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x3865170", Offset = "0x3863F70", VA = "0x183865170")]
	private void FKHAMINOCNK(TKey GMOPMNAPKBE, TVal POACLGOFKAJ, int GINFBCJKIJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x3865700", Offset = "0x3864500", VA = "0x183865700")]
	public bool PCJCJLHGCFN(TKey GMOPMNAPKBE, TVal POACLGOFKAJ, bool BKHABMKMEMJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x3865470", Offset = "0x3864270", VA = "0x183865470")]
	private bool KFONPDEBMMD(TKey GMOPMNAPKBE)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
[DefaultMember("Item")]
public sealed class PHDJOGCKOJN<TKey, TVal> : IDictionary<TKey, TVal>, ICollection<KeyValuePair<TKey, TVal>>, IEnumerable<KeyValuePair<TKey, TVal>>, IEnumerable where TKey : notnull where TVal : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public delegate int IFDOMOFBJEM(TKey GMOPMNAPKBE, TVal POACLGOFKAJ);

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	private class MMFFBBKBEIF
	{
		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public TKey OBPJFFDCAMB
		{
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0xA9AB90", Offset = "0xA99990", VA = "0x180A9AB90")]
			[CompilerGenerated]
			get
			{
				return (TKey)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public TVal CAGIMKNDHKH
		{
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x763880", Offset = "0x762680", VA = "0x180763880")]
			[CompilerGenerated]
			get
			{
				return (TVal)null;
			}
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x760C70", Offset = "0x75FA70", VA = "0x180760C70")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public int MGLJLKOIJDH
		{
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x763850", Offset = "0x762650", VA = "0x180763850")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x7638B0", Offset = "0x7626B0", VA = "0x1807638B0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public DateTime EGGNOMMONEH
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x763870", Offset = "0x762670", VA = "0x180763870")]
			[CompilerGenerated]
			get
			{
				return default(DateTime);
			}
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x765460", Offset = "0x764260", VA = "0x180765460")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x3B8FC30", Offset = "0x3B8EA30", VA = "0x183B8FC30")]
		public MMFFBBKBEIF(TKey GMOPMNAPKBE, TVal OBPGGDPOOJH)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000019")]
	[CompilerGenerated]
	private sealed class OOIFCBBJDEH : IEnumerator<KeyValuePair<TKey, TVal>>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private KeyValuePair<TKey, TVal> <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		public PHDJOGCKOJN<TKey, TVal> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private LinkedList<MMFFBBKBEIF>.Enumerator <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		KeyValuePair<TKey, TVal> IEnumerator<KeyValuePair<TKey, TVal>>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0xD77A50", Offset = "0xD76850", VA = "0x180D77A50", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x3CEC3A0", Offset = "0x3CEB1A0", VA = "0x183CEC3A0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x761980", Offset = "0x760780", VA = "0x180761980")]
		[DebuggerHidden]
		public OOIFCBBJDEH(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x3053A50", Offset = "0x3052850", VA = "0x183053A50", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x3CEB4B0", Offset = "0x3CEA2B0", VA = "0x183CEB4B0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x3CEAED0", Offset = "0x3CE9CD0", VA = "0x183CEAED0")]
		private void LAJOCHINEFP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x3CEC190", Offset = "0x3CEAF90", VA = "0x183CEC190", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public const int KMLHFBBFHLK = -1;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private readonly Dictionary<TKey, LinkedListNode<MMFFBBKBEIF>> ONOGEDCCDDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private readonly LinkedList<MMFFBBKBEIF> MPIFFEBLIIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private readonly IFDOMOFBJEM? BNDMEFEDKBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private readonly TimeSpan MCADMODHBDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private readonly LHBCOENPGKH IJBOMMDAEMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private bool MBKKDNDEEFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private readonly List<TKey> EIEBLCDCGIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private readonly List<TVal> JFBBDMCCKOD;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public int NPIMCONFHFK
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x77CC90", Offset = "0x77BA90", VA = "0x18077CC90")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	internal int GFHKKACHALK
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x77CCA0", Offset = "0x77BAA0", VA = "0x18077CCA0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0xD70540", Offset = "0xD6F340", VA = "0x180D70540")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public int GJPDNICHPHI
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x3666CD0", Offset = "0x3665AD0", VA = "0x183666CD0", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public ICollection<TVal> OCBGEIAFOJG
	{
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x3DC0FD0", Offset = "0x3DBFDD0", VA = "0x183DC0FD0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	ICollection<TKey> IDictionary<TKey, TVal>.NPAAJOHCGII
	{
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x3DBEFF0", Offset = "0x3DBDDF0", VA = "0x183DBEFF0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public bool LOLLACKIPEN
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x7A8300", Offset = "0x7A7100", VA = "0x1807A8300", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public TVal CNLGKPLLPHE
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x3DC0F80", Offset = "0x3DBFD80", VA = "0x183DC0F80", Slot = "4")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x3DC1020", Offset = "0x3DBFE20", VA = "0x183DC1020", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x3DBCE30", Offset = "0x3DBBC30", VA = "0x183DBCE30")]
	private bool EOJEJBKPKHD(int LCFOKPAENOI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x3DBA4E0", Offset = "0x3DB92E0", VA = "0x183DBA4E0")]
	private void CLCALCBKIDB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x3DC0290", Offset = "0x3DBF090", VA = "0x183DC0290")]
	public PHDJOGCKOJN(int LCFOKPAENOI, [Optional] IFDOMOFBJEM? BNDMEFEDKBN, [Optional] IEqualityComparer<TKey>? PIKDPJAMHBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x3DC00D0", Offset = "0x3DBEED0", VA = "0x183DC00D0")]
	public PHDJOGCKOJN(int LCFOKPAENOI, TimeSpan MCADMODHBDH, [Optional] IEqualityComparer<TKey>? PIKDPJAMHBK, [Optional] LHBCOENPGKH? IJBOMMDAEMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x3DC0350", Offset = "0x3DBF150", VA = "0x183DC0350")]
	public PHDJOGCKOJN(int LCFOKPAENOI, IFDOMOFBJEM? BNDMEFEDKBN, TimeSpan MCADMODHBDH, [Optional] IEqualityComparer<TKey>? PIKDPJAMHBK, [Optional] LHBCOENPGKH? IJBOMMDAEMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x3DBA930", Offset = "0x3DB9730", VA = "0x183DBA930")]
	public bool CMINLHHEIKK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x3DBE0E0", Offset = "0x3DBCEE0", VA = "0x183DBE0E0")]
	public bool PAANGOPPMIH(int GINFBCJKIJI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x3DBD8E0", Offset = "0x3DBC6E0", VA = "0x183DBD8E0")]
	public void MFACMGCFCOL(TKey GMOPMNAPKBE, TVal POACLGOFKAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x3DB8910", Offset = "0x3DB7710", VA = "0x183DB8910", Slot = "14")]
	public void Add(KeyValuePair<TKey, TVal> LCDPCJGMPFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x3DB8A70", Offset = "0x3DB7870", VA = "0x183DB8A70", Slot = "9")]
	public void Add(TKey GMOPMNAPKBE, TVal POACLGOFKAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x3DBBCF0", Offset = "0x3DBAAF0", VA = "0x183DBBCF0", Slot = "8")]
	public bool ContainsKey(TKey GMOPMNAPKBE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x3DBBCF0", Offset = "0x3DBAAF0", VA = "0x183DBBCF0", Slot = "16")]
	public bool Contains(KeyValuePair<TKey, TVal> LCDPCJGMPFF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x3DBEB90", Offset = "0x3DBD990", VA = "0x183DBEB90", Slot = "10")]
	public bool Remove(TKey GMOPMNAPKBE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x3DBE930", Offset = "0x3DBD730", VA = "0x183DBE930", Slot = "18")]
	public bool Remove(KeyValuePair<TKey, TVal> LCDPCJGMPFF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x3DBD150", Offset = "0x3DBBF50", VA = "0x183DBD150")]
	private TVal HAMDPAFEPLN(TKey HDKPFIPOEJB)
	{
		return (TVal)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x3DBF3C0", Offset = "0x3DBE1C0", VA = "0x183DBF3C0", Slot = "11")]
	public bool TryGetValue(TKey HDKPFIPOEJB, [Out] TVal POACLGOFKAJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x3DBBB80", Offset = "0x3DBA980", VA = "0x183DBBB80", Slot = "15")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x3DBC160", Offset = "0x3DBAF60", VA = "0x183DBC160", Slot = "17")]
	public void CopyTo(KeyValuePair<TKey, TVal>[] OBEMKDLNKLE, int EMKJLDKBBHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x3DBD5A0", Offset = "0x3DBC3A0", VA = "0x183DBD5A0")]
	private bool IFLBKFHBDKE(MMFFBBKBEIF JDPHKGNAPGC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x3DBB0C0", Offset = "0x3DB9EC0", VA = "0x183DBB0C0")]
	private void CPKMIPDOHJE(LinkedListNode<MMFFBBKBEIF> DEOLFJCMPKN, TVal OEMJACOGEGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x3DB9F80", Offset = "0x3DB8D80", VA = "0x183DB9F80")]
	private void CENAICLMDCB(TKey GMOPMNAPKBE, TVal POACLGOFKAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x3DB9450", Offset = "0x3DB8250", VA = "0x183DB9450")]
	private void CEEACMLAABK(MMFFBBKBEIF JDPHKGNAPGC, TVal OEMJACOGEGN, int FFKAIEDDKPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x3DBCE80", Offset = "0x3DBBC80", VA = "0x183DBCE80", Slot = "19")]
	[IteratorStateMachine(typeof(PHDJOGCKOJN<, >.OOIFCBBJDEH))]
	public IEnumerator<KeyValuePair<TKey, TVal>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x3DBF020", Offset = "0x3DBDE20", VA = "0x183DBF020", Slot = "20")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200001A")]
public readonly struct LPGEKCDAPHC : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x7A8300", Offset = "0x7A7100", VA = "0x1807A8300")]
	public static LPGEKCDAPHC HOBCKCOLEEF(Type FLHOFPAHPKL, [Optional] string? DGAJLDGDPHC, [Optional] string? IIPFMOILDOJ, bool DGOHDJKLOHL = false)
	{
		return default(LPGEKCDAPHC);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x7A8300", Offset = "0x7A7100", VA = "0x1807A8300")]
	public static LPGEKCDAPHC HOBCKCOLEEF<T>([Optional] string? DGAJLDGDPHC, [Optional] string? IIPFMOILDOJ, bool DGOHDJKLOHL = false)
	{
		return default(LPGEKCDAPHC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x75D2D0", Offset = "0x75C0D0", VA = "0x18075D2D0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public struct NMLCLDAMLCH
{
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public delegate bool BNLGPNOJMMH(string NLMMICEMMAO, NMLCLDAMLCH FBCOGDDOKCB);

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public int JLNEIALFDLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public string CEJLGFJKNLE;

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x5CFE730", Offset = "0x5CFD530", VA = "0x185CFE730")]
	public static Dictionary<string, NMLCLDAMLCH> ENJPODDODDK(Type LKELPJCJOJE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x5CFEC20", Offset = "0x5CFDA20", VA = "0x185CFEC20")]
	public static Dictionary<string, NMLCLDAMLCH> JKOGAMHBKDA(Type LKELPJCJOJE, BNLGPNOJMMH BDPJDDNDBHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x5CFEA60", Offset = "0x5CFD860", VA = "0x185CFEA60")]
	public static Dictionary<int, string> IDHDALJPDMI(Dictionary<string, NMLCLDAMLCH> PGGBKFCMLMO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
[AttributeUsage(AttributeTargets.Enum)]
public abstract class GONMAILKGKG : PreserveAttribute
{
	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(Slot = "7")]
	public abstract string DENFBJJPHJF(string OEHHENOKKFM);

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x76E100", Offset = "0x76CF00", VA = "0x18076E100")]
	protected GONMAILKGKG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public abstract class DBMNCLOBEEI : NEBNMHPBDBO
{
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	public static bool CGEJPGNDIMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private readonly string? JGKACOLIAJM;

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public virtual NEBNMHPBDBO? EAGHEKIFCAJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x75DC40", Offset = "0x75CA40", VA = "0x18075DC40", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x5CFD080", Offset = "0x5CFBE80", VA = "0x185CFD080")]
	protected DBMNCLOBEEI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(Slot = "7")]
	public abstract string KJDIEKJIOOI();

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x5CFC9D0", Offset = "0x5CFB7D0", VA = "0x185CFC9D0", Slot = "8")]
	public virtual string BAJDIMDBCKJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x5CFCC50", Offset = "0x5CFBA50", VA = "0x185CFCC50", Slot = "9")]
	public void JAPDCFJOCDO(StringBuilder GPMCJPHJCFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x5CFD020", Offset = "0x5CFBE20", VA = "0x185CFD020", Slot = "10")]
	public void PLCCLKGHBLK(StringBuilder GPMCJPHJCFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x5CFCF00", Offset = "0x5CFBD00", VA = "0x185CFCF00", Slot = "11")]
	public void MEEJDEHKIMB(StringBuilder GPMCJPHJCFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x5CFCA50", Offset = "0x5CFB850", VA = "0x185CFCA50", Slot = "12")]
	public void CDFOANKPEMD(StringBuilder GPMCJPHJCFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x5CFCBB0", Offset = "0x5CFB9B0", VA = "0x185CFCBB0")]
	public static void EGOKJHJHCNE(StringBuilder GPMCJPHJCFI, string ODENANPFPNO, string MEMLJAEHJPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x50545C0", Offset = "0x50533C0", VA = "0x1850545C0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class BBMFMADJNHN : Exception
{
	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x5CFC370", Offset = "0x5CFB170", VA = "0x185CFC370")]
	public BBMFMADJNHN(string BLAOEBOMGGP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public class KIIJPKCKFBO<TErr> : BBMFMADJNHN where TErr : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	public readonly TErr BKDHJHDCDEB;

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x38C2170", Offset = "0x38C0F70", VA = "0x1838C2170")]
	private KIIJPKCKFBO([In] TErr MBGHMMBHAJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x38C20A0", Offset = "0x38C0EA0", VA = "0x1838C20A0")]
	public static KIIJPKCKFBO<TErr> IGHHFGMBDIH([In] TErr MBGHMMBHAJP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public interface NEBNMHPBDBO
{
	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(Slot = "0")]
	string BAJDIMDBCKJ();

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(Slot = "1")]
	string KJDIEKJIOOI();
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public interface FCDHKLHAJDA<out TOptions> where TOptions : notnull
{
	[Cpp2IlInjected.Token(Token = "0x17000012")]
	TOptions CAGIMKNDHKH
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public interface OIBDDPONOJA
{
	[Cpp2IlInjected.Token(Token = "0x17000013")]
	string EGMGPGFMLGN
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public class IDDDKKNAOCC : Exception
{
	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x5CFE000", Offset = "0x5CFCE00", VA = "0x185CFE000")]
	public IDDDKKNAOCC(string BLAOEBOMGGP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public class NACLMJBKEOD<TOk> : IDDDKKNAOCC where TOk : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	public readonly TOk ILFNBAFAKLL;

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x3BCF240", Offset = "0x3BCE040", VA = "0x183BCF240")]
	private NACLMJBKEOD([In] TOk HGBOBKOOEBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x34B5C00", Offset = "0x34B4A00", VA = "0x1834B5C00")]
	public static NACLMJBKEOD<TOk> IGHHFGMBDIH([In] TOk HGBOBKOOEBF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public readonly struct FEBPNEDDNDE<TOk, TErr> : IEquatable<FEBPNEDDNDE<TOk, TErr>> where TOk : notnull where TErr : notnull
{
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private static readonly EqualityComparer<TErr> FLNPEEHKALL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	internal readonly TErr BKDHJHDCDEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	internal readonly TOk ILFNBAFAKLL;

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public bool NLOJILCIDAN
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x33994B0", Offset = "0x33982B0", VA = "0x1833994B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public bool IKPIMLMGALA
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x3398C60", Offset = "0x3397A60", VA = "0x183398C60")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x339B610", Offset = "0x339A410", VA = "0x18339B610")]
	internal FEBPNEDDNDE([In] TErr MBGHMMBHAJP, [In] TOk HGBOBKOOEBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x3398020", Offset = "0x3396E20", VA = "0x183398020")]
	public static FEBPNEDDNDE<TOk, TErr> DJOAGIAAIEP([In] TErr MBGHMMBHAJP)
	{
		return default(FEBPNEDDNDE<TOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x3399690", Offset = "0x3398490", VA = "0x183399690")]
	public static FEBPNEDDNDE<TOk, TErr> ILOOBGDIHHA([In] TOk HGBOBKOOEBF)
	{
		return default(FEBPNEDDNDE<TOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x2183280", Offset = "0x2182080", VA = "0x182183280")]
	public FEBPNEDDNDE<UOk?, TErr?> LEJHHDDDMCM<UOk>()
	{
		return default(FEBPNEDDNDE<UOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x2183C70", Offset = "0x2182A70", VA = "0x182183C70")]
	public FEBPNEDDNDE<UOk?, TErr?> MMLAIAMMIHP<UOk>()
	{
		return default(FEBPNEDDNDE<UOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x2182E40", Offset = "0x2181C40", VA = "0x182182E40")]
	public FEBPNEDDNDE<TOk?, UErr?> KLODMFGHGPN<UErr>()
	{
		return default(FEBPNEDDNDE<TOk, UErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x3397E50", Offset = "0x3396C50", VA = "0x183397E50")]
	public FEBPNEDDNDE<NENNLMOAGAP, TErr> BLFEHPKALMG()
	{
		return default(FEBPNEDDNDE<NENNLMOAGAP, TErr>);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x339A0B0", Offset = "0x3398EB0", VA = "0x18339A0B0")]
	public static bool PNFEPLLEJJK([In] FEBPNEDDNDE<TOk, TErr> NLBDNIEIKMB, [In] FEBPNEDDNDE<TOk, TErr> NFFCMKPCJPP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x33982F0", Offset = "0x33970F0", VA = "0x1833982F0", Slot = "4")]
	public bool Equals(FEBPNEDDNDE<TOk, TErr> LKMMHIOOCMN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x3398570", Offset = "0x3397370", VA = "0x183398570", Slot = "0")]
	public override bool Equals(object LKMMHIOOCMN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x3399230", Offset = "0x3398030", VA = "0x183399230", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x339B170", Offset = "0x3399F70", VA = "0x18339B170", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public static class BECOEKADGCJ
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	[CompilerGenerated]
	private struct KNCLBIGKADN<TOk, TErr> : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public AsyncTaskMethodBuilder<TOk> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public Task<FEBPNEDDNDE<TOk, TErr>> self;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private TaskAwaiter<FEBPNEDDNDE<TOk, TErr>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x38D05F0", Offset = "0x38CF3F0", VA = "0x1838D05F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x38D0910", Offset = "0x38CF710", VA = "0x1838D0910", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000029")]
	[CompilerGenerated]
	private sealed class HNBKPPNLPLL<TOk, TErr> : IEnumerable<TOk>, IEnumerable, IEnumerator<TOk>, IEnumerator, IDisposable
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
		private IEnumerable<FEBPNEDDNDE<TOk, TErr>> self;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public IEnumerable<FEBPNEDDNDE<TOk, TErr>> <>3__self;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private IEnumerator<FEBPNEDDNDE<TOk, TErr>> <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		TOk? IEnumerator<TOk>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000B1")]
			[Cpp2IlInjected.Address(RVA = "0x761890", Offset = "0x760690", VA = "0x180761890", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x761890", Offset = "0x760690", VA = "0x180761890", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x86F050", Offset = "0x86DE50", VA = "0x18086F050")]
		[DebuggerHidden]
		public HNBKPPNLPLL(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x3053A50", Offset = "0x3052850", VA = "0x183053A50", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x35EB7A0", Offset = "0x35EA5A0", VA = "0x1835EB7A0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x35EB6E0", Offset = "0x35EA4E0", VA = "0x1835EB6E0")]
		private void LAJOCHINEFP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x35EBB90", Offset = "0x35EA990", VA = "0x1835EBB90", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x35EBAD0", Offset = "0x35EA8D0", VA = "0x1835EBAD0", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<TOk?>? IEnumerable<TOk>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x33019A0", Offset = "0x33007A0", VA = "0x1833019A0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator? IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x215EE00", Offset = "0x215DC00", VA = "0x18215EE00")]
	public static FEBPNEDDNDE<TOk?, TErr?> ILFNBAFAKLL<TOk, TErr>([In] this FEBPNEDDNDE<TOk, TErr> PECKHAMCEFO, [In] TOk HGBOBKOOEBF)
	{
		return default(FEBPNEDDNDE<TOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x215F620", Offset = "0x215E420", VA = "0x18215F620")]
	public static FEBPNEDDNDE<NENNLMOAGAP, TErr?> ILFNBAFAKLL<TErr>([In] this FEBPNEDDNDE<NENNLMOAGAP, TErr> PECKHAMCEFO)
	{
		return default(FEBPNEDDNDE<NENNLMOAGAP, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x215EE00", Offset = "0x215DC00", VA = "0x18215EE00")]
	public static FEBPNEDDNDE<TOk?, TErr?> BKDHJHDCDEB<TOk, TErr>([In] this FEBPNEDDNDE<TOk, TErr> PECKHAMCEFO, [In] TErr MBGHMMBHAJP)
	{
		return default(FEBPNEDDNDE<TOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x2160850", Offset = "0x215F650", VA = "0x182160850")]
	public static TOk? OLLOMLOIMIK<TOk, TErr>([In] this FEBPNEDDNDE<TOk, TErr> PECKHAMCEFO)
	{
		return (TOk?)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x215EFD0", Offset = "0x215DDD0", VA = "0x18215EFD0")]
	[AsyncStateMachine(typeof(KNCLBIGKADN<, >))]
	public static Task<TOk?>? CGOGJPHHNLK<TOk, TErr>(this Task<FEBPNEDDNDE<TOk, TErr>> PECKHAMCEFO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x2160150", Offset = "0x215EF50", VA = "0x182160150")]
	public static TErr? MBHDGAOEJJE<TErr, TOk>([In] this FEBPNEDDNDE<TOk, TErr> PECKHAMCEFO)
	{
		return (TErr?)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x215E0E0", Offset = "0x215CEE0", VA = "0x18215E0E0")]
	public static bool ADPLLBOPDAG<TOk, TErr, UErr, UOk>([In] this FEBPNEDDNDE<TOk, TErr> PECKHAMCEFO, [Out] FEBPNEDDNDE<UOk, UErr> KEPFMJGOPNJ) where TErr : UErr?
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x215F5B0", Offset = "0x215E3B0", VA = "0x18215F5B0")]
	public static bool HNMDOCOPNCH<TOk, TErr>([In] this FEBPNEDDNDE<TOk, TErr> PECKHAMCEFO, [Out][NotNullWhen(true)] TOk HGBOBKOOEBF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x2160480", Offset = "0x215F280", VA = "0x182160480")]
	public static bool OCMHPMEJPBK<TOk, TErr>([In] this FEBPNEDDNDE<TOk, TErr> PECKHAMCEFO, [Out][NotNullWhen(true)] TErr MBGHMMBHAJP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x215FF00", Offset = "0x215ED00", VA = "0x18215FF00")]
	public static bool LABIIHHNEIA<TOk, TErr>([In] this FEBPNEDDNDE<TOk, TErr> PECKHAMCEFO, [Out][NotNullWhen(true)] TOk HGBOBKOOEBF, [Out][NotNullWhen(false)] TErr MBGHMMBHAJP) where TOk : notnull where TErr : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x215EED0", Offset = "0x215DCD0", VA = "0x18215EED0")]
	public static bool BKPBEOAACMH<TOk, TErr>([In] this FEBPNEDDNDE<TOk, TErr> PECKHAMCEFO, [Out][NotNullWhen(true)] TOk HGBOBKOOEBF, [Out] FEBPNEDDNDE<TOk, TErr> KEPFMJGOPNJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x215E1F0", Offset = "0x215CFF0", VA = "0x18215E1F0")]
	public static bool ADPLLBOPDAG<TOk, TErr, UErr, UOk>([In] this FEBPNEDDNDE<TOk, TErr> PECKHAMCEFO, [Out][NotNullWhen(true)] TOk HGBOBKOOEBF, [Out] FEBPNEDDNDE<UOk, UErr> KEPFMJGOPNJ) where TErr : UErr?
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x215F720", Offset = "0x215E520", VA = "0x18215F720")]
	public static bool JEKPIHLIENO<TOk, TErr>([In] this FEBPNEDDNDE<TOk, TErr> PECKHAMCEFO, [Out][NotNullWhen(true)] TOk HGBOBKOOEBF, [Out] FEBPNEDDNDE<NENNLMOAGAP, TErr> KEPFMJGOPNJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x215FBE0", Offset = "0x215E9E0", VA = "0x18215FBE0")]
	public static FEBPNEDDNDE<UOk, UErr> KFBLGMDOJOA<UOk, UErr, TOk, TErr>([In] this FEBPNEDDNDE<TOk, TErr> PECKHAMCEFO, [In] FEBPNEDDNDE<UOk, UErr> KNIBDNLMNEE) where TOk : UOk where TErr : UErr
	{
		return default(FEBPNEDDNDE<UOk, UErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x215F270", Offset = "0x215E070", VA = "0x18215F270")]
	public static FEBPNEDDNDE<TOk?[]?, TErr?> FJFNMMILHBL<TOk, TErr>(this IEnumerable<FEBPNEDDNDE<TOk, TErr>> PECKHAMCEFO)
	{
		return default(FEBPNEDDNDE<TOk[], TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x21604F0", Offset = "0x215F2F0", VA = "0x1821604F0")]
	[IteratorStateMachine(typeof(HNBKPPNLPLL<, >))]
	public static IEnumerable<TOk?>? OIKMLIPKLPA<TOk, TErr>(this IEnumerable<FEBPNEDDNDE<TOk, TErr>> PECKHAMCEFO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public static class MFPPEBKNEFN<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x22CF000", Offset = "0x22CDE00", VA = "0x1822CF000")]
	public static FEBPNEDDNDE<TOk, T> ILFNBAFAKLL<TOk>([In] TOk HGBOBKOOEBF) where TOk : notnull
	{
		return default(FEBPNEDDNDE<TOk, T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x3B642B0", Offset = "0x3B630B0", VA = "0x183B642B0")]
	public static FEBPNEDDNDE<NENNLMOAGAP, T> ILFNBAFAKLL()
	{
		return default(FEBPNEDDNDE<NENNLMOAGAP, T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x22CF000", Offset = "0x22CDE00", VA = "0x1822CF000")]
	public static FEBPNEDDNDE<T, TErr> BKDHJHDCDEB<TErr>([In] TErr MBGHMMBHAJP) where TErr : notnull
	{
		return default(FEBPNEDDNDE<T, TErr>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
[DefaultMember("Item")]
public sealed class LPNFINBBFNM<T> : IEnumerable<T>, IEnumerable where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	private readonly struct PFCEMMPIEHK : IEnumerable<T>, IEnumerable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private readonly LPNFINBBFNM<T> MAOOJAIJJDE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private readonly int GKOIKIBBEPM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private readonly bool AMCAMOBFKMF;

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x1B7E660", Offset = "0x1B7D460", VA = "0x181B7E660")]
		public PFCEMMPIEHK(LPNFINBBFNM<T> IIJDENGNPJH, int BBMKBFCLNGP, bool IPIEGCEOKKJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x3D97340", Offset = "0x3D96140", VA = "0x183D97340")]
		public LPNFINBBFNM<T>.FLPADLBELPE LMOHIMMBLMJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x3D97430", Offset = "0x3D96230", VA = "0x183D97430", Slot = "5")]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x3D97430", Offset = "0x3D96230", VA = "0x183D97430", Slot = "4")]
		IEnumerator<T> IEnumerable<T>.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002D")]
	public sealed class FLPADLBELPE : IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private readonly LPNFINBBFNM<T> MAOOJAIJJDE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private readonly int AGNDKDKGMEO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private int DCHFIHHGKPA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		private readonly bool AMCAMOBFKMF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private bool PCIHIOPCLIB;

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public T CPKIHOLEKMC
		{
			[Cpp2IlInjected.Token(Token = "0x60000CC")]
			[Cpp2IlInjected.Address(RVA = "0x33C3D60", Offset = "0x33C2B60", VA = "0x1833C3D60")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		T IEnumerator<T>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000CD")]
			[Cpp2IlInjected.Address(RVA = "0x33C3E50", Offset = "0x33C2C50", VA = "0x1833C3E50", Slot = "4")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		object? IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000CE")]
			[Cpp2IlInjected.Address(RVA = "0x33C4120", Offset = "0x33C2F20", VA = "0x1833C4120", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x33C4520", Offset = "0x33C3320", VA = "0x1833C4520")]
		public FLPADLBELPE(LPNFINBBFNM<T> IIJDENGNPJH, int BBMKBFCLNGP, bool IPIEGCEOKKJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x33C3DA0", Offset = "0x33C2BA0", VA = "0x1833C3DA0", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x33C3E30", Offset = "0x33C2C30", VA = "0x1833C3E30", Slot = "8")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x75D2D0", Offset = "0x75C0D0", VA = "0x18075D2D0", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[CompilerGenerated]
	private sealed class IAKFOACHGPN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public Func<T> makeDefault;

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x75E150", Offset = "0x75CF50", VA = "0x18075E150")]
		public IAKFOACHGPN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x3667CB0", Offset = "0x3666AB0", VA = "0x183667CB0")]
		internal T JFNJDBFGGNA(int _)
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private readonly T[] CIILHNOIABE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private int DCHFIHHGKPA;

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public int EEKDIENBIMA
	{
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x399A950", Offset = "0x3999750", VA = "0x18399A950")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public T CPKIHOLEKMC
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x337C670", Offset = "0x337B470", VA = "0x18337C670")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public T FKIKGLFLOCI
	{
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x399A710", Offset = "0x3999510", VA = "0x18399A710")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public T CNLGKPLLPHE
	{
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x399A7E0", Offset = "0x39995E0", VA = "0x18399A7E0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public int GFHGMKIJCDL
	{
		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x151C810", Offset = "0x151B610", VA = "0x18151C810")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0xE3CBC0", Offset = "0xE3B9C0", VA = "0x180E3CBC0")]
	private static int GJAOGCHDKPD(int OCMJNDDMDAL, int JGMNJBPPKGP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x399AD20", Offset = "0x3999B20", VA = "0x18399AD20")]
	public LPNFINBBFNM(int GINFBCJKIJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x399AA60", Offset = "0x3999860", VA = "0x18399AA60")]
	public LPNFINBBFNM(int GINFBCJKIJI, Func<T> ACPGFCDONCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x399AED0", Offset = "0x3999CD0", VA = "0x18399AED0")]
	public LPNFINBBFNM(T[] DNHCBADCFIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x399AA30", Offset = "0x3999830", VA = "0x18399AA30")]
	public void PCLFOECPHAN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x399A890", Offset = "0x3999690", VA = "0x18399A890")]
	public IEnumerable<T> JNLMHIDHGKM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x399A9A0", Offset = "0x39997A0", VA = "0x18399A9A0")]
	public LPNFINBBFNM<T>.FLPADLBELPE LMOHIMMBLMJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x304B990", Offset = "0x304A790", VA = "0x18304B990", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x304B990", Offset = "0x304A790", VA = "0x18304B990", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public static class NMKKDHMKEMI
{
	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x24E8C00", Offset = "0x24E7A00", VA = "0x1824E8C00")]
	public static LPNFINBBFNM<T> IGHHFGMBDIH<T>(int GINFBCJKIJI, Func<T> ACPGFCDONCI) where T : notnull
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
		[Cpp2IlInjected.Address(RVA = "0x1C5FE70", Offset = "0x1C5EC70", VA = "0x181C5FE70")]
		public RRColor(float CAAEKLGIBGJ, float LBBFHBDANKG, float DFBIFCHBAHF, float APOJANFJHJO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x5CFF1E0", Offset = "0x5CFDFE0", VA = "0x185CFF1E0", Slot = "4")]
		public bool Equals(RRColor LKMMHIOOCMN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x5CFF260", Offset = "0x5CFE060", VA = "0x185CFF260", Slot = "0")]
		public override bool Equals(object LKMMHIOOCMN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x5CFF360", Offset = "0x5CFE160", VA = "0x185CFF360", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x5CFF3E0", Offset = "0x5CFE1E0", VA = "0x185CFF3E0", Slot = "5")]
		public string ToString(string GEACENBCPHD, IFormatProvider MKAILHOOHAP)
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public sealed class CGPJFLOALKB<TData> : DBMNCLOBEEI where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public readonly string LPKINLJAGGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public readonly TData NCHGGNHAEAG;

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x761890", Offset = "0x760690", VA = "0x180761890", Slot = "7")]
	public override string KJDIEKJIOOI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x47892C0", Offset = "0x47880C0", VA = "0x1847892C0")]
	internal CGPJFLOALKB(string BLAOEBOMGGP, [In] TData LMCJHCIOIIP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public static class KHCBEBJFFNI
{
	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x21EDE40", Offset = "0x21ECC40", VA = "0x1821EDE40")]
	public static CGPJFLOALKB<TData> IGHHFGMBDIH<TData>(string BLAOEBOMGGP, [In] TData LMCJHCIOIIP) where TData : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public class BMDIILMCEPA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	private readonly Dictionary<object, float> EKLELFILNFP;

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public float HMOJGMNIINE
	{
		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x7EA2A0", Offset = "0x7E90A0", VA = "0x1807EA2A0")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x7EA340", Offset = "0x7E9140", VA = "0x1807EA340")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x5CFC600", Offset = "0x5CFB400", VA = "0x185CFC600")]
	public void CENAICLMDCB(float POACLGOFKAJ, object EKDHBKMFLGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x5CFC7A0", Offset = "0x5CFB5A0", VA = "0x185CFC7A0")]
	public void NEOFPANHMHF(object EKDHBKMFLGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x5CFC670", Offset = "0x5CFB470", VA = "0x185CFC670")]
	private void JNPLIHNGJDK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x5CFC810", Offset = "0x5CFB610", VA = "0x185CFC810")]
	public BMDIILMCEPA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public sealed class NBCIJBGEDIF<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	[CompilerGenerated]
	private sealed class ICHLJJELDJG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public StringBuilder sb;

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x75E150", Offset = "0x75CF50", VA = "0x18075E150")]
		public ICHLJJELDJG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x366E800", Offset = "0x366D600", VA = "0x18366E800")]
		internal int HNGPANDAFLG(int i, T token)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	private HashSet<T>? HAAKHKPMLLI;

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public IReadOnlyCollection<T> NKNNEPMAPAO
	{
		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x3BCF7F0", Offset = "0x3BCE5F0", VA = "0x183BCF7F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public bool IGIJGGJFLFM
	{
		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x3BCF690", Offset = "0x3BCE490", VA = "0x183BCF690")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public int GJPDNICHPHI
	{
		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x7638A0", Offset = "0x7626A0", VA = "0x1807638A0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x763860", Offset = "0x762660", VA = "0x180763860")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x3BCF520", Offset = "0x3BCE320", VA = "0x183BCF520")]
	public bool EJEJBLJEAIN(T EKDHBKMFLGI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x3BCF6D0", Offset = "0x3BCE4D0", VA = "0x183BCF6D0")]
	public bool KCJHGNBNEJA(T EKDHBKMFLGI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x3BCF820", Offset = "0x3BCE620", VA = "0x183BCF820")]
	public bool PEOEIPDBFBN(T EKDHBKMFLGI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x3BCF860", Offset = "0x3BCE660", VA = "0x183BCF860", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x75E150", Offset = "0x75CF50", VA = "0x18075E150")]
	public NBCIJBGEDIF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public class OHJELKPNANC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	private readonly string FLJPOLPGFIE;

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x761AA0", Offset = "0x7608A0", VA = "0x180761AA0")]
	public OHJELKPNANC(string FLJPOLPGFIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x5CFF190", Offset = "0x5CFDF90", VA = "0x185CFF190", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public sealed class LNJAJLDNNOD
{
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	[CompilerGenerated]
	private sealed class JLJPINFHMKF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public StringBuilder sb;

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x75E150", Offset = "0x75CF50", VA = "0x18075E150")]
		public JLJPINFHMKF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x5CFE100", Offset = "0x5CFCF00", VA = "0x185CFE100")]
		internal int HNGPANDAFLG(int i, object token)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	private HashSet<object>? HAAKHKPMLLI;

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public IReadOnlyCollection<object> NKNNEPMAPAO
	{
		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x5CFE420", Offset = "0x5CFD220", VA = "0x185CFE420")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public bool IGIJGGJFLFM
	{
		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x5CFE370", Offset = "0x5CFD170", VA = "0x185CFE370")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public int GJPDNICHPHI
	{
		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x7638A0", Offset = "0x7626A0", VA = "0x1807638A0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x763860", Offset = "0x762660", VA = "0x180763860")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x5CFE290", Offset = "0x5CFD090", VA = "0x185CFE290")]
	public bool EJEJBLJEAIN(object EKDHBKMFLGI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x5CFE380", Offset = "0x5CFD180", VA = "0x185CFE380")]
	public bool KCJHGNBNEJA(object EKDHBKMFLGI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x5CFE4B0", Offset = "0x5CFD2B0", VA = "0x185CFE4B0")]
	public bool PEOEIPDBFBN(object EKDHBKMFLGI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x5CFE510", Offset = "0x5CFD310", VA = "0x185CFE510")]
	public void POMEKMFJGMM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x5CFE580", Offset = "0x5CFD380", VA = "0x185CFE580", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x75E150", Offset = "0x75CF50", VA = "0x18075E150")]
	public LNJAJLDNNOD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public class PNOGIDMGPHE<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	private struct PDGPDNIHCNJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		public float HJIOHHDAIMK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public T CAGIMKNDHKH;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private readonly Dictionary<object, PDGPDNIHCNJ> EKLELFILNFP;

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public virtual T IDOPIKJICIO
	{
		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0xD77A50", Offset = "0xD76850", VA = "0x180D77A50", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0xD77030", Offset = "0xD75E30", VA = "0x180D77030", Slot = "5")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public object? CACMDMPEOBN
	{
		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x763870", Offset = "0x762670", VA = "0x180763870")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x763890", Offset = "0x762690", VA = "0x180763890")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public bool HDJEELEGJFL
	{
		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x3DE1AB0", Offset = "0x3DE08B0", VA = "0x183DE1AB0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x3DE1E10", Offset = "0x3DE0C10", VA = "0x183DE1E10")]
	public bool CENAICLMDCB(T POACLGOFKAJ, object EKDHBKMFLGI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x36A5CB0", Offset = "0x36A4AB0", VA = "0x1836A5CB0")]
	public bool NEOFPANHMHF(object EKDHBKMFLGI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x3DE3CB0", Offset = "0x3DE2AB0", VA = "0x183DE3CB0")]
	public void LHLJEDFLAKN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x3DE3A20", Offset = "0x3DE2820", VA = "0x183DE3A20")]
	public bool HOKMFLFGDOM(object EKDHBKMFLGI, [Out] T POACLGOFKAJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x3DE2670", Offset = "0x3DE1470", VA = "0x183DE2670")]
	[KBDIGOEEBHG("T can be T?, `default!` shouldn't be necessary in C# 9")]
	private bool HDFPDDDLDDO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x3DE3CE0", Offset = "0x3DE2AE0", VA = "0x183DE3CE0")]
	public PNOGIDMGPHE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public interface DABBEHEKBOG
{
	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event HBHFGMAABIK IODBMHDGGGP;
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public class GKIGKOCEHFL : DABBEHEKBOG, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	public readonly struct DELNNMNHJAM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public readonly float BAOEPALFJFL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public readonly float OACGCGFLLOK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		internal readonly bool ELICBKNLKLB;

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public float MGLJLKOIJDH
		{
			[Cpp2IlInjected.Token(Token = "0x600010F")]
			[Cpp2IlInjected.Address(RVA = "0x5CFD0F0", Offset = "0x5CFBEF0", VA = "0x185CFD0F0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x5CFD260", Offset = "0x5CFC060", VA = "0x185CFD260")]
		public DELNNMNHJAM(float IHNKLCGMFDI, float MBGJPMIDMIA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x5CFD100", Offset = "0x5CFBF00", VA = "0x185CFD100", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003E")]
	[CompilerGenerated]
	private sealed class IKNKCKDKMFF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public GKIGKOCEHFL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public int newProgressableIndex;

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x75E150", Offset = "0x75CF50", VA = "0x18075E150")]
		public IKNKCKDKMFF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x5CFE060", Offset = "0x5CFCE60", VA = "0x185CFE060")]
		internal void NEJONPIOJAF(float innerProgress)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private readonly int LCFOKPAENOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private int GNMKLHGAJBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private readonly DABBEHEKBOG[] MDFFHHKDEPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private readonly HBHFGMAABIK[] JOJOJMCMCEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private readonly DELNNMNHJAM[] FMHOLGIBPHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private DELNNMNHJAM MBAMKOJAHCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private readonly BLJPMIJPLBG KPFGJGMGOKI;

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event HBHFGMAABIK IODBMHDGGGP
	{
		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x5CFD450", Offset = "0x5CFC250", VA = "0x185CFD450", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x5CFDA90", Offset = "0x5CFC890", VA = "0x185CFDA90", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x5CFDB50", Offset = "0x5CFC950", VA = "0x185CFDB50")]
	public GKIGKOCEHFL(int LCFOKPAENOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x5CFD3C0", Offset = "0x5CFC1C0", VA = "0x185CFD3C0")]
	public BLJPMIJPLBG CIKKFGFGDDA(DELNNMNHJAM NFGCMBPOMHF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x5CFD620", Offset = "0x5CFC420", VA = "0x185CFD620")]
	public void EBPAJJIBMBE(DABBEHEKBOG NDMFDHHLMEF, [Optional] DELNNMNHJAM CNCKHPILCEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x5CFD510", Offset = "0x5CFC310", VA = "0x185CFD510", Slot = "6")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public delegate void HBHFGMAABIK(float NEOFCPOBGDK);
[Cpp2IlInjected.Token(Token = "0x2000040")]
public static class COPPDHAGAOL
{
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	private class KAJLDMBOOLO : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		private readonly DABBEHEKBOG OCJGDPPEKNH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		private readonly HBHFGMAABIK PMOMGAGBHKB;

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x5CFE200", Offset = "0x5CFD000", VA = "0x185CFE200")]
		public KAJLDMBOOLO(DABBEHEKBOG OCJGDPPEKNH, HBHFGMAABIK PMOMGAGBHKB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x5CFE1B0", Offset = "0x5CFCFB0", VA = "0x185CFE1B0", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x5CFC960", Offset = "0x5CFB760", VA = "0x185CFC960")]
	internal static bool CCPCLHCJICC(float APOJANFJHJO, float DFBIFCHBAHF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x5CF4B50", Offset = "0x5CF3950", VA = "0x185CF4B50")]
	internal static float IAHALMPHGDE(float APOJANFJHJO)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x5CFC8A0", Offset = "0x5CFB6A0", VA = "0x185CFC8A0")]
	public static IDisposable BKMCAENFFKB(this DABBEHEKBOG OCJGDPPEKNH, HBHFGMAABIK PMOMGAGBHKB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public class BLJPMIJPLBG : DABBEHEKBOG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private float NEOFCPOBGDK;

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public float CAJFKDIMEBB
	{
		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x5CFC510", Offset = "0x5CFB310", VA = "0x185CFC510")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public event HBHFGMAABIK? IODBMHDGGGP
	{
		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x5CFC3D0", Offset = "0x5CFB1D0", VA = "0x185CFC3D0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x5CFC470", Offset = "0x5CFB270", VA = "0x185CFC470", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x75E150", Offset = "0x75CF50", VA = "0x18075E150")]
	public BLJPMIJPLBG()
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
