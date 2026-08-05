using System;
using System.Buffers;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
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
		[Cpp2IlInjected.Address(RVA = "0x890220", Offset = "0x88EE20", VA = "0x180890220")]
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
		[Cpp2IlInjected.Address(RVA = "0x6AA6C80", Offset = "0x6AA5880", VA = "0x186AA6C80")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x890890", Offset = "0x88F490", VA = "0x180890890")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[CompilerGenerated]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x8908D0", Offset = "0x88F4D0", VA = "0x1808908D0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public abstract class IIOAAHEDNLO
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x86FB10", Offset = "0x86E710", VA = "0x18086FB10")]
	protected IIOAAHEDNLO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public abstract class FEBKAEDPEJE<T> : IIOAAHEDNLO
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	protected struct MDKJAFEADLF
	{
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		public enum EKNMLKEDBGA
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
		public EKNMLKEDBGA HGPIKDLKBHO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public T OBNFAOABLKL;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private int DKLCKHLHNNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly bool FOAENHNJHFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	protected readonly bool FJFCGHHOLNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	protected List<T>? PFBDHDBFEDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private List<MDKJAFEADLF>? HKKIBFALIGK;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public bool LKBIFNNGKDO
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x3C100E0", Offset = "0x3C0ECE0", VA = "0x183C100E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x3C107C0", Offset = "0x3C0F3C0", VA = "0x183C107C0")]
	protected FEBKAEDPEJE(bool FJFCGHHOLNH, bool FOAENHNJHFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x3C10480", Offset = "0x3C0F080", VA = "0x183C10480")]
	protected bool NPGAOGANJPD()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x3C10150", Offset = "0x3C0ED50", VA = "0x183C10150")]
	protected void LJHLJFFJALO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x3C10520", Offset = "0x3C0F120", VA = "0x183C10520")]
	protected void OBBJGKPJAGA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x2A79C20", Offset = "0x2A78820", VA = "0x182A79C20")]
	private static void GMOJMNGGADN<U>(List<U>? ELBBNOKMNCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x3C10270", Offset = "0x3C0EE70", VA = "0x183C10270", Slot = "4")]
	public void LKPJOLMECIF(T OBNFAOABLKL, bool IANHJCOFCIA = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x3C0FF10", Offset = "0x3C0EB10", VA = "0x183C0FF10", Slot = "5")]
	public void ECLBFOFCOFL(T OBNFAOABLKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x3C0FD60", Offset = "0x3C0E960", VA = "0x183C0FD60")]
	public void AFPCPCPKMJJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public sealed class MMAIJBDFGNK : FEBKAEDPEJE<Action>
{
	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x6AA6BE0", Offset = "0x6AA57E0", VA = "0x186AA6BE0")]
	public MMAIJBDFGNK(bool FJFCGHHOLNH = false, bool FOAENHNJHFE = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x6AA69E0", Offset = "0x6AA55E0", VA = "0x186AA69E0")]
	public void HEONFGBJNMF()
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x6AA6980", Offset = "0x6AA5580", VA = "0x186AA6980")]
	public static MMAIJBDFGNK CIMOFGPGBIC(MMAIJBDFGNK LJFHDOMDGON, Action OBNFAOABLKL)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x6AA6920", Offset = "0x6AA5520", VA = "0x186AA6920")]
	public static MMAIJBDFGNK AIDPNBGJIKC(MMAIJBDFGNK LJFHDOMDGON, Action OBNFAOABLKL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface KDPHEOBCBHP<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void LKPJOLMECIF(Action<T> OBNFAOABLKL, bool IANHJCOFCIA = false);

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void ECLBFOFCOFL(Action<T> OBNFAOABLKL);
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public sealed class BCFOECKJENL<T> : FEBKAEDPEJE<Action<T>>, KDPHEOBCBHP<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x3D2BFB0", Offset = "0x3D2ABB0", VA = "0x183D2BFB0")]
	public BCFOECKJENL(bool FJFCGHHOLNH = false, bool FOAENHNJHFE = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x4E64410", Offset = "0x4E63010", VA = "0x184E64410")]
	public void HEONFGBJNMF(T GLMCDBEDNLG)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x3D28230", Offset = "0x3D26E30", VA = "0x183D28230")]
	public static BCFOECKJENL<T> CIMOFGPGBIC(BCFOECKJENL<T> LJFHDOMDGON, Action<T> OBNFAOABLKL)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x3D28190", Offset = "0x3D26D90", VA = "0x183D28190")]
	public static BCFOECKJENL<T> AIDPNBGJIKC(BCFOECKJENL<T> LJFHDOMDGON, Action<T> OBNFAOABLKL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface NHOGIBBJMNG<T, U> where T : notnull where U : notnull
{
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public sealed class GAGHBOIDANB<T, U> : FEBKAEDPEJE<Action<T, U>>, NHOGIBBJMNG<T, U> where T : notnull where U : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x3D2BFB0", Offset = "0x3D2ABB0", VA = "0x183D2BFB0")]
	public GAGHBOIDANB(bool FJFCGHHOLNH = false, bool FOAENHNJHFE = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x3D2B2F0", Offset = "0x3D29EF0", VA = "0x183D2B2F0")]
	public void HEONFGBJNMF(T GLMCDBEDNLG, U MKKFBPKDMEF)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x3D28230", Offset = "0x3D26E30", VA = "0x183D28230")]
	public static GAGHBOIDANB<T, U> CIMOFGPGBIC(GAGHBOIDANB<T, U> LJFHDOMDGON, Action<T, U> OBNFAOABLKL)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x3D28190", Offset = "0x3D26D90", VA = "0x183D28190")]
	public static GAGHBOIDANB<T, U> AIDPNBGJIKC(GAGHBOIDANB<T, U> LJFHDOMDGON, Action<T, U> OBNFAOABLKL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public sealed class LJADHFIHFIP<T, U, V> : FEBKAEDPEJE<Action<T, U, V>> where T : notnull where U : notnull where V : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x3D2BFB0", Offset = "0x3D2ABB0", VA = "0x183D2BFB0")]
	public LJADHFIHFIP(bool FJFCGHHOLNH = false, bool FOAENHNJHFE = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x427C410", Offset = "0x427B010", VA = "0x18427C410")]
	public void HEONFGBJNMF(T GLMCDBEDNLG, U MKKFBPKDMEF, V CCBJGKKCAKF)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x3D28230", Offset = "0x3D26E30", VA = "0x183D28230")]
	public static LJADHFIHFIP<T, U, V> CIMOFGPGBIC(LJADHFIHFIP<T, U, V> LJFHDOMDGON, Action<T, U, V> OBNFAOABLKL)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x3D28190", Offset = "0x3D26D90", VA = "0x183D28190")]
	public static LJADHFIHFIP<T, U, V> AIDPNBGJIKC(LJADHFIHFIP<T, U, V> LJFHDOMDGON, Action<T, U, V> OBNFAOABLKL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface AKONFONBPAI<T, U, V, W>
{
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public sealed class CGMMNFFAPAD<T, U, V, W> : FEBKAEDPEJE<Action<T, U, V, W>>, AKONFONBPAI<T, U, V, W> where T : notnull where U : notnull where V : notnull where W : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x3D2BFB0", Offset = "0x3D2ABB0", VA = "0x183D2BFB0")]
	public CGMMNFFAPAD(bool FJFCGHHOLNH = false, bool FOAENHNJHFE = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x55857C0", Offset = "0x55843C0", VA = "0x1855857C0")]
	public void HEONFGBJNMF(T GLMCDBEDNLG, U MKKFBPKDMEF, V CCBJGKKCAKF, W PHAJGFLHIGP)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x3D28230", Offset = "0x3D26E30", VA = "0x183D28230")]
	public static CGMMNFFAPAD<T, U, V, W> CIMOFGPGBIC(CGMMNFFAPAD<T, U, V, W> LJFHDOMDGON, Action<T, U, V, W> OBNFAOABLKL)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x3D28190", Offset = "0x3D26D90", VA = "0x183D28190")]
	public static CGMMNFFAPAD<T, U, V, W> AIDPNBGJIKC(CGMMNFFAPAD<T, U, V, W> LJFHDOMDGON, Action<T, U, V, W> OBNFAOABLKL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public sealed class CNLJLALAHML<T, U, V, W, X> : FEBKAEDPEJE<Action<T, U, V, W, X>>
{
	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x3D2BFB0", Offset = "0x3D2ABB0", VA = "0x183D2BFB0")]
	public CNLJLALAHML(bool FJFCGHHOLNH = false, bool FOAENHNJHFE = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x56B0610", Offset = "0x56AF210", VA = "0x1856B0610")]
	public void HEONFGBJNMF(T GLMCDBEDNLG, U MKKFBPKDMEF, V CCBJGKKCAKF, W PHAJGFLHIGP, X KIGIELEFAKI)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x3D28230", Offset = "0x3D26E30", VA = "0x183D28230")]
	public static CNLJLALAHML<T, U, V, W, X> CIMOFGPGBIC(CNLJLALAHML<T, U, V, W, X> LJFHDOMDGON, Action<T, U, V, W, X> OBNFAOABLKL)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x3D28190", Offset = "0x3D26D90", VA = "0x183D28190")]
	public static CNLJLALAHML<T, U, V, W, X> AIDPNBGJIKC(CNLJLALAHML<T, U, V, W, X> LJFHDOMDGON, Action<T, U, V, W, X> OBNFAOABLKL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public sealed class LCPOAACEJEN<T, U, V, W, X, Y> : FEBKAEDPEJE<Action<T, U, V, W, X, Y>>
{
	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x3D2BFB0", Offset = "0x3D2ABB0", VA = "0x183D2BFB0")]
	public LCPOAACEJEN(bool FJFCGHHOLNH = false, bool FOAENHNJHFE = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x424FB10", Offset = "0x424E710", VA = "0x18424FB10")]
	public void HEONFGBJNMF(T GLMCDBEDNLG, U MKKFBPKDMEF, V CCBJGKKCAKF, W PHAJGFLHIGP, X KIGIELEFAKI, Y DKINGMIONNI)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x3D28230", Offset = "0x3D26E30", VA = "0x183D28230")]
	public static LCPOAACEJEN<T, U, V, W, X, Y> CIMOFGPGBIC(LCPOAACEJEN<T, U, V, W, X, Y> LJFHDOMDGON, Action<T, U, V, W, X, Y> OBNFAOABLKL)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x3D28190", Offset = "0x3D26D90", VA = "0x183D28190")]
	public static LCPOAACEJEN<T, U, V, W, X, Y> AIDPNBGJIKC(LCPOAACEJEN<T, U, V, W, X, Y> LJFHDOMDGON, Action<T, U, V, W, X, Y> OBNFAOABLKL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public class BLJLJAHEDBK<TKey, TVal> where TKey : notnull where TVal : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly FBOJOKLNJJM<TKey, TVal> EEFBKEJENJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	internal readonly Dictionary<TKey, (TVal value, int size)> FKJMLGEFEFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private readonly FBOJOKLNJJM<TKey, TVal>.HJHFEMFABDM? FEENNKFHIGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private readonly int HHEEBJALHAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private readonly FBOJOKLNJJM<TKey, TVal>.MPKCBDFEDLC? NKOGHEGIMAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private int DELOHNKOFJD;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	internal int BCIJEMDKGBC
	{
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x4E90090", Offset = "0x4E8EC90", VA = "0x184E90090")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public int BEDOIHFIHBM
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x867CE0", Offset = "0x8668E0", VA = "0x180867CE0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x4E90340", Offset = "0x4E8EF40", VA = "0x184E90340")]
	public BLJLJAHEDBK(int HHEEBJALHAB, [Optional] FBOJOKLNJJM<TKey, TVal>.MPKCBDFEDLC? NKOGHEGIMAA, [Optional] IEqualityComparer<TKey>? FCPNKFDOJHF, [Optional] FBOJOKLNJJM<TKey, TVal>.HJHFEMFABDM? FEENNKFHIGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x4E8FE40", Offset = "0x4E8EA40", VA = "0x184E8FE40")]
	public void NECOFOKPADP(TKey NCMHANGAILD, TVal IIPLJLPCLBC, bool MCDEAAOBLDA = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x4E8F5C0", Offset = "0x4E8E1C0", VA = "0x184E8F5C0")]
	public bool CBHLLNFLJAN(TKey NCMHANGAILD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x4E90240", Offset = "0x4E8EE40", VA = "0x184E90240")]
	public bool PNDEAMPCPGC(TKey GJHKHOAMOEF, [Out] TVal IIPLJLPCLBC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x4E8F990", Offset = "0x4E8E590", VA = "0x184E8F990")]
	private void GBECGJKLHEE(TKey NCMHANGAILD, TVal IIPLJLPCLBC, int INGCLKPLIOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x4E8FC70", Offset = "0x4E8E870", VA = "0x184E8FC70")]
	public bool GCINIAHPGOM(TKey NCMHANGAILD, TVal IIPLJLPCLBC, bool MCDEAAOBLDA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x4E8EF80", Offset = "0x4E8DB80", VA = "0x184E8EF80")]
	public void AFPCPCPKMJJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x4E8F030", Offset = "0x4E8DC30", VA = "0x184E8F030")]
	private void AGLMIIHCPAN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x4E900F0", Offset = "0x4E8ECF0", VA = "0x184E900F0")]
	private bool PALLPLCIAHB(TKey NCMHANGAILD, APNGJBKBHFJ GLMDIHNLEBJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x4E8F730", Offset = "0x4E8E330", VA = "0x184E8F730")]
	private void DKMAPMMFBNC(TKey NCMHANGAILD, TVal IIPLJLPCLBC, APNGJBKBHFJ GLMDIHNLEBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x4E8F860", Offset = "0x4E8E460", VA = "0x184E8F860")]
	private void ELPONMBMINN(TKey NCMHANGAILD, TVal BMEHNBDMOJG, APNGJBKBHFJ GLMDIHNLEBJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class NKDLGBLAJJA : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private readonly Action DOHAHAPPGIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private bool CJACEAJHJAH;

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x86E850", Offset = "0x86D450", VA = "0x18086E850")]
	public NKDLGBLAJJA(Action LCEGNFFKCKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x6AA6C40", Offset = "0x6AA5840", VA = "0x186AA6C40", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x2B38FF0", Offset = "0x2B37BF0", VA = "0x182B38FF0")]
	public static ELKLJFKIONH<T> NCPDNLLGMJA<T>(T IIPLJLPCLBC, Action LCEGNFFKCKH) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public sealed class ELKLJFKIONH<T> : NKDLGBLAJJA where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public T JCMGPEFMEMP
	{
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x867590", Offset = "0x866190", VA = "0x180867590")]
		[CompilerGenerated]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x384F5B0", Offset = "0x384E1B0", VA = "0x18384F5B0")]
	public ELKLJFKIONH(T IIPLJLPCLBC, Action LCEGNFFKCKH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public sealed class MHAIBLKHCLA<T> : IDisposable where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private readonly BJHHIAPBGCA<T>? KLGKNPHOOMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private readonly ReadOnlySequence<T> IKAMEKDAKMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private bool CJACEAJHJAH;

	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public static readonly MHAIBLKHCLA<T> ECELLENMKJP;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public ReadOnlySequence<T> KHDHODNOKEI
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x448AE80", Offset = "0x4489A80", VA = "0x18448AE80")]
		get
		{
			return default(ReadOnlySequence<T>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public long IEIDDKENJGC
	{
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x448AF80", Offset = "0x4489B80", VA = "0x18448AF80")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public bool IEKHLJNNNBD
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x448AC40", Offset = "0x4489840", VA = "0x18448AC40")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x448B260", Offset = "0x4489E60", VA = "0x18448B260")]
	public MHAIBLKHCLA(BJHHIAPBGCA<T> GIFPCLFPANC, BJHHIAPBGCA<T> FALBIMALKLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x448B730", Offset = "0x448A330", VA = "0x18448B730")]
	public MHAIBLKHCLA(BJHHIAPBGCA<T> GIFPCLFPANC, int IPBPNCHALEF, BJHHIAPBGCA<T> FALBIMALKLO, int HCLLLBPFFBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x448BB00", Offset = "0x448A700", VA = "0x18448BB00")]
	private MHAIBLKHCLA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x448AAF0", Offset = "0x44896F0", VA = "0x18448AAF0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x448AD00", Offset = "0x4489900", VA = "0x18448AD00")]
	public T[] MAOENEIBJNJ()
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x448A9C0", Offset = "0x44895C0", VA = "0x18448A9C0")]
	public static ReadOnlySequence<T> ANHILFPCAJJ(MHAIBLKHCLA<T>? BEMAKBEIOIC)
	{
		return default(ReadOnlySequence<T>);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000017")]
public readonly struct BLCDLKBIDPC : IDisposable
{
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public readonly struct BFEMGDGHFLJ : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x8AE100", Offset = "0x8ACD00", VA = "0x1808AE100")]
		public static BFEMGDGHFLJ FCDPFGJNKNI()
		{
			return default(BFEMGDGHFLJ);
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x866B20", Offset = "0x865720", VA = "0x180866B20", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x28F62A0", Offset = "0x28F4EA0", VA = "0x1828F62A0")]
	public static string? CFJKIIKFBDM<T>([Optional] string? NGPLLANCHMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x28F6320", Offset = "0x28F4F20", VA = "0x1828F6320")]
	public static string? HLAMFNDLLKK<T>([Optional] string? KFLLHBGDMHB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x8AE100", Offset = "0x8ACD00", VA = "0x1808AE100")]
	public static BLCDLKBIDPC ABOMBKDKOLM(string NGPLLANCHMJ, string? KFLLHBGDMHB)
	{
		return default(BLCDLKBIDPC);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x866B20", Offset = "0x865720", VA = "0x180866B20", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public struct JBBDCCJMFFN
{
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public delegate bool APPEBHBJNMP(string DMOCKEMKDIE, JBBDCCJMFFN NNAPDJBACPG);

	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[CompilerGenerated]
	private sealed class LMFIAKAIAAG<T> where T : notnull, Enum
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public List<int> enumValuesSubset;

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x86FB10", Offset = "0x86E710", VA = "0x18086FB10")]
		public LMFIAKAIAAG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x4288D40", Offset = "0x4287940", VA = "0x184288D40")]
		internal void AGOCHEIHNEF(T x)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public int CLDDKGECHDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public string KKNALJNMIBP;

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x6AA4710", Offset = "0x6AA3310", VA = "0x186AA4710")]
	public static Dictionary<string, JBBDCCJMFFN> CJAHADOEBOC(Type GFECMDDJOLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x2B98190", Offset = "0x2B96D90", VA = "0x182B98190")]
	public static Dictionary<string, JBBDCCJMFFN> CJAHADOEBOC<T>(Type GFECMDDJOLL, IReadOnlyDictionary<T, string> MIJABBJCFIM) where T : notnull, Enum
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x2B97A30", Offset = "0x2B96630", VA = "0x182B97A30")]
	public static Dictionary<string, JBBDCCJMFFN> CCLKHNFCGEO<T>(List<T> FBLCJPBGNJH) where T : notnull, Enum
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x6AA4C00", Offset = "0x6AA3800", VA = "0x186AA4C00")]
	public static Dictionary<string, JBBDCCJMFFN> KHCJFCNECAM(Type GFECMDDJOLL, APPEBHBJNMP IBAMOGAIHGD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x6AA4A40", Offset = "0x6AA3640", VA = "0x186AA4A40")]
	public static Dictionary<int, string> IBNOAJCAAHF(Dictionary<string, JBBDCCJMFFN> LNMFGKOJMJG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public abstract class LGLBGBDJHMM : MLPOHKBMKMA
{
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public static bool MNLPAEBPJDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	private readonly string? IDBJPCNEEKM;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public virtual MLPOHKBMKMA? FCPIDFMFIGO
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x866B30", Offset = "0x865730", VA = "0x180866B30", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x6AA6830", Offset = "0x6AA5430", VA = "0x186AA6830")]
	protected LGLBGBDJHMM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(Slot = "7")]
	public abstract string FGIPLPDCCEJ();

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x6AA62F0", Offset = "0x6AA4EF0", VA = "0x186AA62F0", Slot = "8")]
	public virtual string DCPKHMDHIKG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x6AA63D0", Offset = "0x6AA4FD0", VA = "0x186AA63D0", Slot = "9")]
	public void JBJEEJAEJAM(StringBuilder DCNBAOMJHKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x6AA6370", Offset = "0x6AA4F70", VA = "0x186AA6370", Slot = "10")]
	public void GLEMJJDBCND(StringBuilder DCNBAOMJHKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x6AA6670", Offset = "0x6AA5270", VA = "0x186AA6670", Slot = "11")]
	public void KKEJBLANDIO(StringBuilder DCNBAOMJHKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x6AA6190", Offset = "0x6AA4D90", VA = "0x186AA6190", Slot = "12")]
	public void CMLLEIGDHHM(StringBuilder DCNBAOMJHKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x6AA6790", Offset = "0x6AA5390", VA = "0x186AA6790")]
	public static void KPLNLIGJHKD(StringBuilder DCNBAOMJHKO, string OICNHLDCDBF, string NHAMPLDOOIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x5C74840", Offset = "0x5C73440", VA = "0x185C74840", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class EEIHKIKOLIL : Exception
{
	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x6AA3B20", Offset = "0x6AA2720", VA = "0x186AA3B20")]
	public EEIHKIKOLIL(string NKAJDDICLFH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class OOEPPBOEMNL<TErr> : EEIHKIKOLIL where TErr : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public readonly TErr EPMOHPGLOJC;

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x46C3940", Offset = "0x46C2540", VA = "0x1846C3940")]
	private OOEPPBOEMNL([In] TErr OEFOGDNBLPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x46C3860", Offset = "0x46C2460", VA = "0x1846C3860")]
	public static OOEPPBOEMNL<TErr> FCDPFGJNKNI([In] TErr OEFOGDNBLPB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class DPJIBLGGEHP : Stream
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private readonly HashAlgorithm LBJAPNOAOBK;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public override bool LKHIJHMINPG
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x8AE100", Offset = "0x8ACD00", VA = "0x1808AE100", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public override bool OCEDKLIOLKH
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x8AE100", Offset = "0x8ACD00", VA = "0x1808AE100", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public override bool CKGGGHLCHDP
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x880D80", Offset = "0x87F980", VA = "0x180880D80", Slot = "11")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public override long IEIDDKENJGC
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x6AA39C0", Offset = "0x6AA25C0", VA = "0x186AA39C0", Slot = "12")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public override long MMKDAECKHPD
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x6AA3A30", Offset = "0x6AA2630", VA = "0x186AA3A30", Slot = "13")]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x6AA3AA0", Offset = "0x6AA26A0", VA = "0x186AA3AA0", Slot = "14")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x6AA3950", Offset = "0x6AA2550", VA = "0x186AA3950")]
	public DPJIBLGGEHP(HashAlgorithm LBJAPNOAOBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x6AA3770", Offset = "0x6AA2370", VA = "0x186AA3770", Slot = "35")]
	public override int Read(byte[] EBPAODHLEDO, int JEHLDDEOFLK, int LLHINFJPPOH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x6AA3920", Offset = "0x6AA2520", VA = "0x186AA3920", Slot = "38")]
	public override void Write(byte[] EBPAODHLEDO, int JEHLDDEOFLK, int LLHINFJPPOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x6AA3810", Offset = "0x6AA2410", VA = "0x186AA3810", Slot = "33")]
	public override long Seek(long JEHLDDEOFLK, SeekOrigin PPDGJCIMLMA)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x6AA38A0", Offset = "0x6AA24A0", VA = "0x186AA38A0", Slot = "34")]
	public override void SetLength(long IIPLJLPCLBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x866B20", Offset = "0x865720", VA = "0x180866B20", Slot = "23")]
	public override void Flush()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x6AA36A0", Offset = "0x6AA22A0", VA = "0x186AA36A0")]
	public byte[] KGOBMAMCKGM()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public interface MLPOHKBMKMA
{
	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(Slot = "0")]
	string DCPKHMDHIKG();

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(Slot = "1")]
	string FGIPLPDCCEJ();
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public interface LLMGJLMJELE<out TOptions> where TOptions : notnull
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	TOptions JCMGPEFMEMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public interface FMGLBCFGECL
{
	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	string LLIGJMNMKEG
	{
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public sealed class BJHHIAPBGCA<T> : ReadOnlySequenceSegment<T>, IDisposable where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private static BJHHIAPBGCA<T>? LJHHNLEIKHG;

	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private static object NCPAEBGACBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private IMemoryOwner<T>? IDKKDJMCCDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private bool CJACEAJHJAH;

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public bool DLCDMGIPGPC
	{
		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x9F38E0", Offset = "0x9F24E0", VA = "0x1809F38E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x4E7EFA0", Offset = "0x4E7DBA0", VA = "0x184E7EFA0")]
	private static BJHHIAPBGCA<T> HKEPCJIHKAM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x4E7E7B0", Offset = "0x4E7D3B0", VA = "0x184E7E7B0")]
	private static void GDGGODOCAJI(BJHHIAPBGCA<T> BIKGFDKHEFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x3ED2080", Offset = "0x3ED0C80", VA = "0x183ED2080")]
	private BJHHIAPBGCA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x4E7F710", Offset = "0x4E7E310", VA = "0x184E7F710")]
	public static BJHHIAPBGCA<T> NCPDNLLGMJA(ReadOnlyMemory<T> EOHCNHAIPNF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x4E7FAD0", Offset = "0x4E7E6D0", VA = "0x184E7FAD0")]
	public static BJHHIAPBGCA<T> NCPDNLLGMJA(IMemoryOwner<T> AICDINDBEPA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x4E7F470", Offset = "0x4E7E070", VA = "0x184E7F470")]
	public static void JMFALKPCFKP(BJHHIAPBGCA<T> GIFPCLFPANC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x4E7E290", Offset = "0x4E7CE90", VA = "0x184E7E290", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x4E7FCF0", Offset = "0x4E7E8F0", VA = "0x184E7FCF0")]
	public BJHHIAPBGCA<T> OGNDIGPFEIJ(IMemoryOwner<T> AICDINDBEPA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x4E7EEA0", Offset = "0x4E7DAA0", VA = "0x184E7EEA0")]
	private void GFFDDOGNBLA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x4E7F5B0", Offset = "0x4E7E1B0", VA = "0x184E7F5B0")]
	private BJHHIAPBGCA<T> LMOPPKLMPGC(BJHHIAPBGCA<T> BIKGFDKHEFN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public class DKCHNNHAEAA : Exception
{
	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x6AA35D0", Offset = "0x6AA21D0", VA = "0x186AA35D0")]
	public DKCHNNHAEAA(string NKAJDDICLFH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public class KBMJOMBLJHO<TOk> : DKCHNNHAEAA where TOk : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public readonly TOk DAOKBFPGHPD;

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x41A1A00", Offset = "0x41A0600", VA = "0x1841A1A00")]
	private KBMJOMBLJHO([In] TOk IMMADAONHDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x4092510", Offset = "0x4091110", VA = "0x184092510")]
	public static KBMJOMBLJHO<TOk> FCDPFGJNKNI([In] TOk IMMADAONHDO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public class JGLPCPODANK : Stream
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private readonly ReadOnlySequence<byte> IKAMEKDAKMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private SequencePosition OALLMFOOPAM;

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public override bool LKHIJHMINPG
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x880D80", Offset = "0x87F980", VA = "0x180880D80", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public override bool OCEDKLIOLKH
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x880D80", Offset = "0x87F980", VA = "0x180880D80", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public override bool CKGGGHLCHDP
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x8AE100", Offset = "0x8ACD00", VA = "0x1808AE100", Slot = "11")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public override long IEIDDKENJGC
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x6AA5970", Offset = "0x6AA4570", VA = "0x186AA5970", Slot = "12")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public override long MMKDAECKHPD
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x6AA59D0", Offset = "0x6AA45D0", VA = "0x186AA59D0", Slot = "13")]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x6AA5AA0", Offset = "0x6AA46A0", VA = "0x186AA5AA0", Slot = "14")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x6AA58A0", Offset = "0x6AA44A0", VA = "0x186AA58A0")]
	public JGLPCPODANK(ReadOnlySequence<byte> BEMAKBEIOIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x6AA5450", Offset = "0x6AA4050", VA = "0x186AA5450", Slot = "33")]
	public override long Seek(long JEHLDDEOFLK, SeekOrigin PPDGJCIMLMA)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x6AA4FC0", Offset = "0x6AA3BC0", VA = "0x186AA4FC0", Slot = "35")]
	public override int Read(byte[] EBPAODHLEDO, int JEHLDDEOFLK, int LLHINFJPPOH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x866B20", Offset = "0x865720", VA = "0x180866B20", Slot = "23")]
	public override void Flush()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x6AA57E0", Offset = "0x6AA43E0", VA = "0x186AA57E0", Slot = "34")]
	public override void SetLength(long IIPLJLPCLBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x6AA5840", Offset = "0x6AA4440", VA = "0x186AA5840", Slot = "38")]
	public override void Write(byte[] EBPAODHLEDO, int JEHLDDEOFLK, int LLHINFJPPOH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public readonly struct NLDGPBPIIJN<TOk, TErr> : IEquatable<NLDGPBPIIJN<TOk, TErr>> where TOk : notnull where TErr : notnull
{
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private static readonly EqualityComparer<TErr> FAFDAJKKCJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	internal readonly TErr EPMOHPGLOJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	internal readonly TOk DAOKBFPGHPD;

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public bool NEIONMHPLPL
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x4525DB0", Offset = "0x45249B0", VA = "0x184525DB0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public bool DCGKHHOHMEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x4522A20", Offset = "0x4521620", VA = "0x184522A20")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x4527C50", Offset = "0x4526850", VA = "0x184527C50")]
	internal NLDGPBPIIJN([In] TErr OEFOGDNBLPB, [In] TOk IMMADAONHDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x4525B00", Offset = "0x4524700", VA = "0x184525B00")]
	public static NLDGPBPIIJN<TOk, TErr> JILBBLIAKDP([In] TErr OEFOGDNBLPB)
	{
		return default(NLDGPBPIIJN<TOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x4523130", Offset = "0x4521D30", VA = "0x184523130")]
	public static NLDGPBPIIJN<TOk, TErr> DPBKCBHEKBH([In] TOk IMMADAONHDO)
	{
		return default(NLDGPBPIIJN<TOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x2BD5AA0", Offset = "0x2BD46A0", VA = "0x182BD5AA0")]
	public NLDGPBPIIJN<TOk?, UErr?> NGAGIEGOIOH<UErr>()
	{
		return default(NLDGPBPIIJN<TOk, UErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x2BD5E70", Offset = "0x2BD4A70", VA = "0x182BD5E70")]
	public NLDGPBPIIJN<UOk?, TErr?> OCGHLFMMECL<UOk>()
	{
		return default(NLDGPBPIIJN<UOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x2BD4910", Offset = "0x2BD3510", VA = "0x182BD4910")]
	public NLDGPBPIIJN<UOk?, TErr?> LGOGFMCLICH<UOk>()
	{
		return default(NLDGPBPIIJN<UOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x2BD44B0", Offset = "0x2BD30B0", VA = "0x182BD44B0")]
	public NLDGPBPIIJN<TOk?, UErr?> BMOFBNCHDOG<UErr>()
	{
		return default(NLDGPBPIIJN<TOk, UErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x45260F0", Offset = "0x4524CF0", VA = "0x1845260F0")]
	public NLDGPBPIIJN<HGAAMJINHPI, TErr> OFICOLLKODB()
	{
		return default(NLDGPBPIIJN<HGAAMJINHPI, TErr>);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x4525000", Offset = "0x4523C00", VA = "0x184525000")]
	public static bool IGDKJEPDLHP([In] NLDGPBPIIJN<TOk, TErr> HDIFBMODGOB, [In] NLDGPBPIIJN<TOk, TErr> ADFEKOHGOPP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x45234C0", Offset = "0x45220C0", VA = "0x1845234C0", Slot = "4")]
	public bool Equals(NLDGPBPIIJN<TOk, TErr> HEIGABGMPLJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x4523B90", Offset = "0x4522790", VA = "0x184523B90", Slot = "0")]
	public override bool Equals(object HEIGABGMPLJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x4524890", Offset = "0x4523490", VA = "0x184524890", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x4526700", Offset = "0x4525300", VA = "0x184526700", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public static class PCCHOMEONFL
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	[CompilerGenerated]
	private struct OKNMMOIOLMB<TOk, TErr> : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		public AsyncTaskMethodBuilder<TOk> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		public Task<NLDGPBPIIJN<TOk, TErr>> self;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private TaskAwaiter<NLDGPBPIIJN<TOk, TErr>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x46BC840", Offset = "0x46BB440", VA = "0x1846BC840", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x46BD200", Offset = "0x46BBE00", VA = "0x1846BD200", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x2CDF4F0", Offset = "0x2CDE0F0", VA = "0x182CDF4F0")]
	public static NLDGPBPIIJN<TOk?, TErr?> DAOKBFPGHPD<TOk, TErr>([In] this NLDGPBPIIJN<TOk, TErr> ENEDBNLKLJL, [In] TOk IMMADAONHDO)
	{
		return default(NLDGPBPIIJN<TOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x2CDF540", Offset = "0x2CDE140", VA = "0x182CDF540")]
	public static NLDGPBPIIJN<HGAAMJINHPI, TErr?> DAOKBFPGHPD<TErr>([In] this NLDGPBPIIJN<HGAAMJINHPI, TErr> ENEDBNLKLJL)
	{
		return default(NLDGPBPIIJN<HGAAMJINHPI, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x2CDF4F0", Offset = "0x2CDE0F0", VA = "0x182CDF4F0")]
	public static NLDGPBPIIJN<TOk?, TErr?> EPMOHPGLOJC<TOk, TErr>([In] this NLDGPBPIIJN<TOk, TErr> ENEDBNLKLJL, [In] TErr OEFOGDNBLPB)
	{
		return default(NLDGPBPIIJN<TOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x2CE0990", Offset = "0x2CDF590", VA = "0x182CE0990")]
	public static TOk? MMEACMDMIGC<TOk, TErr>([In] this NLDGPBPIIJN<TOk, TErr> ENEDBNLKLJL)
	{
		return (TOk?)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x2CE1EA0", Offset = "0x2CE0AA0", VA = "0x182CE1EA0")]
	[AsyncStateMachine(typeof(OKNMMOIOLMB<, >))]
	public static Task<TOk?>? NNELOAOBDCA<TOk, TErr>(this Task<NLDGPBPIIJN<TOk, TErr>> ENEDBNLKLJL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x2CDF9F0", Offset = "0x2CDE5F0", VA = "0x182CDF9F0")]
	public static TErr? IKEPDCEPFCC<TErr, TOk>([In] this NLDGPBPIIJN<TOk, TErr> ENEDBNLKLJL)
	{
		return (TErr?)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x2CE0E70", Offset = "0x2CDFA70", VA = "0x182CE0E70")]
	public static bool MPCBHMHJBLP<TOk, TErr, UErr, UOk>([In] this NLDGPBPIIJN<TOk, TErr> ENEDBNLKLJL, [Out] NLDGPBPIIJN<UOk, UErr> CLJABNDODPE) where TErr : UErr?
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x2CE2170", Offset = "0x2CE0D70", VA = "0x182CE2170")]
	public static bool OMKMPDCGDOA<TOk, TErr>([In] this NLDGPBPIIJN<TOk, TErr> ENEDBNLKLJL, [Out][NotNullWhen(true)] TOk IMMADAONHDO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x2CE0640", Offset = "0x2CDF240", VA = "0x182CE0640")]
	public static bool MHJPEGLNOLF<TOk, TErr>([In] this NLDGPBPIIJN<TOk, TErr> ENEDBNLKLJL, [Out][NotNullWhen(true)] TErr OEFOGDNBLPB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x2CDF200", Offset = "0x2CDDE00", VA = "0x182CDF200")]
	public static bool APOLIMOCDLI<TOk, TErr>([In] this NLDGPBPIIJN<TOk, TErr> ENEDBNLKLJL, [Out][NotNullWhen(true)] TOk IMMADAONHDO, [Out][NotNullWhen(false)] TErr OEFOGDNBLPB) where TOk : notnull where TErr : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x2CDF400", Offset = "0x2CDE000", VA = "0x182CDF400")]
	public static bool CEBPKADHABH<TOk, TErr>([In] this NLDGPBPIIJN<TOk, TErr> ENEDBNLKLJL, [Out][NotNullWhen(true)] TOk IMMADAONHDO, [Out] NLDGPBPIIJN<TOk, TErr> CLJABNDODPE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x2CE10C0", Offset = "0x2CDFCC0", VA = "0x182CE10C0")]
	public static bool MPCBHMHJBLP<TOk, TErr, UErr, UOk>([In] this NLDGPBPIIJN<TOk, TErr> ENEDBNLKLJL, [Out][NotNullWhen(true)] TOk IMMADAONHDO, [Out] NLDGPBPIIJN<UOk, UErr> CLJABNDODPE) where TErr : UErr?
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x2CDFC30", Offset = "0x2CDE830", VA = "0x182CDFC30")]
	public static bool ILDFAKMKCGI<TOk, TErr>([In] this NLDGPBPIIJN<TOk, TErr> ENEDBNLKLJL, [Out][NotNullWhen(true)] TOk IMMADAONHDO, [Out] NLDGPBPIIJN<HGAAMJINHPI, TErr> CLJABNDODPE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x2CE0300", Offset = "0x2CDEF00", VA = "0x182CE0300")]
	public static NLDGPBPIIJN<UOk, UErr> JDNNKCCHPBE<UOk, UErr, TOk, TErr>([In] this NLDGPBPIIJN<TOk, TErr> ENEDBNLKLJL, [In] NLDGPBPIIJN<UOk, UErr> LDAADCAOFLJ) where TOk : UOk where TErr : UErr
	{
		return default(NLDGPBPIIJN<UOk, UErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x2CDEE30", Offset = "0x2CDDA30", VA = "0x182CDEE30")]
	public static NLDGPBPIIJN<TOk?[]?, TErr?> AOMJCICAJOP<TOk, TErr>(this IEnumerable<NLDGPBPIIJN<TOk, TErr>> ENEDBNLKLJL)
	{
		return default(NLDGPBPIIJN<TOk[], TErr>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public static class DKCPMKMGCJO<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x2A76100", Offset = "0x2A74D00", VA = "0x182A76100")]
	public static NLDGPBPIIJN<TOk, T> DAOKBFPGHPD<TOk>([In] TOk IMMADAONHDO) where TOk : notnull
	{
		return default(NLDGPBPIIJN<TOk, T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x58BC100", Offset = "0x58BAD00", VA = "0x1858BC100")]
	public static NLDGPBPIIJN<HGAAMJINHPI, T> DAOKBFPGHPD()
	{
		return default(NLDGPBPIIJN<HGAAMJINHPI, T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x2A75FD0", Offset = "0x2A74BD0", VA = "0x182A75FD0")]
	public static NLDGPBPIIJN<T, TErr> EPMOHPGLOJC<TErr>([In] TErr OEFOGDNBLPB) where TErr : notnull
	{
		return default(NLDGPBPIIJN<T, TErr>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
[DefaultMember("Item")]
public sealed class KBDJBBPMEON<T> : IEnumerable<T>, IEnumerable where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	private readonly struct ICMEAHIIMPK : IEnumerable<T>, IEnumerable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private readonly KBDJBBPMEON<T> AEDCKMEIINL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private readonly int NAGHNEOHIKL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private readonly bool LFAMKKFDBID;

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x1EC05C0", Offset = "0x1EBF1C0", VA = "0x181EC05C0")]
		public ICMEAHIIMPK(KBDJBBPMEON<T> JPJGGLNFIBC, int BNFHBIMDLNA, bool ELJEEENPCCA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x3E93100", Offset = "0x3E91D00", VA = "0x183E93100")]
		public KBDJBBPMEON<T>.JFGJGKOBKCO DHNABIACCII()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x3E93200", Offset = "0x3E91E00", VA = "0x183E93200", Slot = "5")]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x3E93200", Offset = "0x3E91E00", VA = "0x183E93200", Slot = "4")]
		IEnumerator<T> IEnumerable<T>.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002D")]
	public sealed class JFGJGKOBKCO : IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private readonly KBDJBBPMEON<T> AEDCKMEIINL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private readonly int ODFAIIPMGPE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private int GNGNLBDFBPG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private readonly bool LFAMKKFDBID;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private bool CCJABJMCKOJ;

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public T KENACMDPOBM
		{
			[Cpp2IlInjected.Token(Token = "0x60000C8")]
			[Cpp2IlInjected.Address(RVA = "0x408D6C0", Offset = "0x408C2C0", VA = "0x18408D6C0")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		T IEnumerator<T>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000C9")]
			[Cpp2IlInjected.Address(RVA = "0x408D810", Offset = "0x408C410", VA = "0x18408D810", Slot = "4")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		object? IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000CA")]
			[Cpp2IlInjected.Address(RVA = "0x408D890", Offset = "0x408C490", VA = "0x18408D890", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x408DF90", Offset = "0x408CB90", VA = "0x18408DF90")]
		public JFGJGKOBKCO(KBDJBBPMEON<T> JPJGGLNFIBC, int BNFHBIMDLNA, bool ELJEEENPCCA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x408D700", Offset = "0x408C300", VA = "0x18408D700", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x408D7A0", Offset = "0x408C3A0", VA = "0x18408D7A0", Slot = "8")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x866B20", Offset = "0x865720", VA = "0x180866B20", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[CompilerGenerated]
	private sealed class MIIPDCGPGKH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public Func<T> makeDefault;

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x86FB10", Offset = "0x86E710", VA = "0x18086FB10")]
		public MIIPDCGPGKH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x448E0B0", Offset = "0x448CCB0", VA = "0x18448E0B0")]
		internal T DOBNEHIALON(int _)
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private readonly T[] LJOIGBCHBEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private int GNGNLBDFBPG;

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public int DLHKGNJLJOH
	{
		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x41A1160", Offset = "0x419FD60", VA = "0x1841A1160")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public T KENACMDPOBM
	{
		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x3BBC4C0", Offset = "0x3BBB0C0", VA = "0x183BBC4C0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public T LMJDMBCGCBD
	{
		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x41A1050", Offset = "0x419FC50", VA = "0x1841A1050")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public T PJODKJCBOKO
	{
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x41A1310", Offset = "0x419FF10", VA = "0x1841A1310")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public int IEIDDKENJGC
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x192A4D0", Offset = "0x19290D0", VA = "0x18192A4D0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x1178930", Offset = "0x1177530", VA = "0x181178930")]
	private static int PAIBFEHFPFK(int BAEBMIBABAE, int AEGGIAICNFC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x41A1690", Offset = "0x41A0290", VA = "0x1841A1690")]
	public KBDJBBPMEON(int INGCLKPLIOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x41A1380", Offset = "0x419FF80", VA = "0x1841A1380")]
	public KBDJBBPMEON(int INGCLKPLIOP, Func<T> DDDGKFKNIML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x41A1550", Offset = "0x41A0150", VA = "0x1841A1550")]
	public KBDJBBPMEON(T[] JMDINDKMKCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x41A0F80", Offset = "0x419FB80", VA = "0x1841A0F80")]
	public void BMKGBFGIEFJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x41A1090", Offset = "0x419FC90", VA = "0x1841A1090")]
	public IEnumerable<T> DKHJIFKCNGP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x41A0FB0", Offset = "0x419FBB0", VA = "0x1841A0FB0")]
	public KBDJBBPMEON<T>.JFGJGKOBKCO DHNABIACCII()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x3BED760", Offset = "0x3BEC360", VA = "0x183BED760", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x3BED760", Offset = "0x3BEC360", VA = "0x183BED760", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public static class ICJLMLPDLFK
{
	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x2B6EC70", Offset = "0x2B6D870", VA = "0x182B6EC70")]
	public static KBDJBBPMEON<T> FCDPFGJNKNI<T>(int INGCLKPLIOP, Func<T> DDDGKFKNIML) where T : notnull
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
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private const float kEpsilon = 1E-05f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public float r;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public float g;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public float b;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public float a;

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x1FC52B0", Offset = "0x1FC3EB0", VA = "0x181FC52B0")]
		public RRColor(float GKPLDDEPNGI, float GPEEPFKJJKI, float GCHHKKAJBGE, float PFJBMEMCGDE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x6AA76E0", Offset = "0x6AA62E0", VA = "0x186AA76E0", Slot = "4")]
		public bool Equals(RRColor HEIGABGMPLJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x6AA7760", Offset = "0x6AA6360", VA = "0x186AA7760", Slot = "0")]
		public override bool Equals(object HEIGABGMPLJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x6AA7860", Offset = "0x6AA6460", VA = "0x186AA7860", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x6AA78E0", Offset = "0x6AA64E0", VA = "0x186AA78E0", Slot = "5")]
		public string ToString(string HCFPFEPBAJC, IFormatProvider PBGIPGOHHON)
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public sealed class CBIHMAIBKHG<T> : IDisposable where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	public readonly struct CGHEIAMMJLJ : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private readonly CBIHMAIBKHG<T> LKJDGPKHHHN;

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public T JCMGPEFMEMP
		{
			[Cpp2IlInjected.Token(Token = "0x60000DC")]
			[Cpp2IlInjected.Address(RVA = "0x4A0DF20", Offset = "0x4A0CB20", VA = "0x184A0DF20")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x5584B50", Offset = "0x5583750", VA = "0x185584B50", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x9403F0", Offset = "0x93EFF0", VA = "0x1809403F0")]
		public CGHEIAMMJLJ(CBIHMAIBKHG<T> LKJDGPKHHHN)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	[CompilerGenerated]
	private struct BNKEHOIKCOJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public AsyncTaskMethodBuilder<CGHEIAMMJLJ> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public CBIHMAIBKHG<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x4EB90F0", Offset = "0x4EB7CF0", VA = "0x184EB90F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x384A580", Offset = "0x3849180", VA = "0x18384A580", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private readonly SemaphoreSlim EJHODDJOBHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private T JPDEDFPDFNF;

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x4F852B0", Offset = "0x4F83EB0", VA = "0x184F852B0")]
	public CBIHMAIBKHG([In] T JPDEDFPDFNF, int FNMKIDCIBHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x4F85130", Offset = "0x4F83D30", VA = "0x184F85130")]
	public CBIHMAIBKHG([In] T JPDEDFPDFNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x4F85090", Offset = "0x4F83C90", VA = "0x184F85090", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x4F850F0", Offset = "0x4F83CF0", VA = "0x184F850F0")]
	public CGHEIAMMJLJ NPKGIFPEIBG()
	{
		return default(CGHEIAMMJLJ);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x4F84D00", Offset = "0x4F83900", VA = "0x184F84D00")]
	[AsyncStateMachine(typeof(CBIHMAIBKHG<>.BNKEHOIKCOJ))]
	public Task<CBIHMAIBKHG<T>.CGHEIAMMJLJ> DLNDHPEPBFM(CancellationToken PPKBAEMFIMG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x4F850D0", Offset = "0x4F83CD0", VA = "0x184F850D0")]
	public void HEMHIGDEJPP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public static class DKFFFFMPAAO
{
	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x6AA3630", Offset = "0x6AA2230", VA = "0x186AA3630")]
	public static CBIHMAIBKHG<HGAAMJINHPI> FCDPFGJNKNI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x2996690", Offset = "0x2995290", VA = "0x182996690")]
	public static CBIHMAIBKHG<T> FCDPFGJNKNI<T>([In] T JPDEDFPDFNF) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public sealed class CDDEGEAOFFN<T> : IDisposable where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	public readonly struct DAGKIAKFEIN : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private readonly CDDEGEAOFFN<T> FGOHKGNGHMJ;

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public T JCMGPEFMEMP
		{
			[Cpp2IlInjected.Token(Token = "0x60000E8")]
			[Cpp2IlInjected.Address(RVA = "0x4089FE0", Offset = "0x4088BE0", VA = "0x184089FE0")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x58796D0", Offset = "0x58782D0", VA = "0x1858796D0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x9403F0", Offset = "0x93EFF0", VA = "0x1809403F0")]
		internal DAGKIAKFEIN(CDDEGEAOFFN<T> LKJDGPKHHHN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000037")]
	public readonly struct JFDJMEDNPDI : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		private readonly CDDEGEAOFFN<T> FGOHKGNGHMJ;

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public T JCMGPEFMEMP
		{
			[Cpp2IlInjected.Token(Token = "0x60000EB")]
			[Cpp2IlInjected.Address(RVA = "0x4089FE0", Offset = "0x4088BE0", VA = "0x184089FE0")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x4089F40", Offset = "0x4088B40", VA = "0x184089F40", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x9403F0", Offset = "0x93EFF0", VA = "0x1809403F0")]
		internal JFDJMEDNPDI(CDDEGEAOFFN<T> LKJDGPKHHHN)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	[CompilerGenerated]
	private struct ACHMJLFLMCM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public AsyncTaskMethodBuilder<JFDJMEDNPDI> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public CDDEGEAOFFN<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		private CBIHMAIBKHG<HGAAMJINHPI>.CGHEIAMMJLJ <writeLock>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		private TaskAwaiter<CBIHMAIBKHG<HGAAMJINHPI>.CGHEIAMMJLJ> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x3CE6640", Offset = "0x3CE5240", VA = "0x183CE6640", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x384A580", Offset = "0x3849180", VA = "0x18384A580", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	private readonly CBIHMAIBKHG<int> CLADDOOBNHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	private readonly CBIHMAIBKHG<HGAAMJINHPI> BNKBCIALGEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private readonly CBIHMAIBKHG<HGAAMJINHPI> FOKNNNMAFIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	private T LKLIFGHNDNN;

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x55752F0", Offset = "0x5573EF0", VA = "0x1855752F0")]
	internal CDDEGEAOFFN(CBIHMAIBKHG<int> NGDLGOGFLHI, CBIHMAIBKHG<HGAAMJINHPI> LHDGFMMANCF, CBIHMAIBKHG<HGAAMJINHPI> KHOADBNKPCP, [In] T JPDEDFPDFNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x55744D0", Offset = "0x55730D0", VA = "0x1855744D0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x5574D40", Offset = "0x5573940", VA = "0x185574D40")]
	public DAGKIAKFEIN MHDEAGHKGFJ()
	{
		return default(DAGKIAKFEIN);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x55745D0", Offset = "0x55731D0", VA = "0x1855745D0")]
	public JFDJMEDNPDI FMNMLKOLAAI()
	{
		return default(JFDJMEDNPDI);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x5574F60", Offset = "0x5573B60", VA = "0x185574F60")]
	[AsyncStateMachine(typeof(CDDEGEAOFFN<>.ACHMJLFLMCM))]
	public Task<CDDEGEAOFFN<T>.JFDJMEDNPDI> NLHOFEGEGPJ(CancellationToken PPKBAEMFIMG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public static class AJIPCDIIIKM
{
	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x6AA3500", Offset = "0x6AA2100", VA = "0x186AA3500")]
	public static CDDEGEAOFFN<HGAAMJINHPI> FCDPFGJNKNI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x31FCCD0", Offset = "0x31FB8D0", VA = "0x1831FCCD0")]
	public static CDDEGEAOFFN<T> FCDPFGJNKNI<T>([In] T JPDEDFPDFNF) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public sealed class ENKCDBGGHHO<TData> : LGLBGBDJHMM where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	public readonly string MPIOCLAPHII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	public readonly TData COKNLHIJAIB;

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x865990", Offset = "0x864590", VA = "0x180865990", Slot = "7")]
	public override string FGIPLPDCCEJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x3856580", Offset = "0x3855180", VA = "0x183856580")]
	internal ENKCDBGGHHO(string NKAJDDICLFH, [In] TData JGFKFMMOAJO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public static class MCIECGBPBNF
{
	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x6AA68A0", Offset = "0x6AA54A0", VA = "0x186AA68A0")]
	public static ENKCDBGGHHO<HGAAMJINHPI> FCDPFGJNKNI(string NKAJDDICLFH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x2B38FF0", Offset = "0x2B37BF0", VA = "0x182B38FF0")]
	public static ENKCDBGGHHO<TData> FCDPFGJNKNI<TData>(string NKAJDDICLFH, [In] TData JGFKFMMOAJO) where TData : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public class IPEBMPJJOHC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	private readonly Dictionary<object, float> CNAIHKDCKLB;

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public float NLELOGBDJIP
	{
		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x8D15D0", Offset = "0x8D01D0", VA = "0x1808D15D0")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0xEDF570", Offset = "0xEDE170", VA = "0x180EDF570")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x6AA45A0", Offset = "0x6AA31A0", VA = "0x186AA45A0")]
	public void LCIJIMMMDPD(float IIPLJLPCLBC, object GBENACPKFNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x6AA4610", Offset = "0x6AA3210", VA = "0x186AA4610")]
	public void MHFEADBCBPA(object GBENACPKFNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x6AA4420", Offset = "0x6AA3020", VA = "0x186AA4420")]
	public void AFPCPCPKMJJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x6AA4470", Offset = "0x6AA3070", VA = "0x186AA4470")]
	private void KKOGONPJKGG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x6AA4680", Offset = "0x6AA3280", VA = "0x186AA4680")]
	public IPEBMPJJOHC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public sealed class NFLFIKGDHAA<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	[CompilerGenerated]
	private sealed class CCGPKFEPOHN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		public StringBuilder sb;

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x86FB10", Offset = "0x86E710", VA = "0x18086FB10")]
		public CCGPKFEPOHN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x5491FD0", Offset = "0x5490BD0", VA = "0x185491FD0")]
		internal int LPAAHLBEDLA(int i, T token)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private HashSet<T>? CFMGNFGOFDP;

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public IReadOnlyCollection<T> BIKOBCCBKJL
	{
		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x44F5270", Offset = "0x44F3E70", VA = "0x1844F5270")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public bool PFNPOIDCBPL
	{
		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x44F5220", Offset = "0x44F3E20", VA = "0x1844F5220")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public int NAAONAFFINP
	{
		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x867580", Offset = "0x866180", VA = "0x180867580")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x867D00", Offset = "0x866900", VA = "0x180867D00")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x44F5040", Offset = "0x44F3C40", VA = "0x1844F5040")]
	public bool LKPJOLMECIF(T GBENACPKFNA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x44F4EC0", Offset = "0x44F3AC0", VA = "0x1844F4EC0")]
	public bool ECLBFOFCOFL(T GBENACPKFNA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x44F4D80", Offset = "0x44F3980", VA = "0x1844F4D80")]
	public bool CPEFJACKAGC(T GBENACPKFNA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x44F4DD0", Offset = "0x44F39D0", VA = "0x1844F4DD0")]
	public void DKINLCGABCJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x44F52B0", Offset = "0x44F3EB0", VA = "0x1844F52B0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x86FB10", Offset = "0x86E710", VA = "0x18086FB10")]
	public NFLFIKGDHAA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public class EPIDMNHCALL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private readonly string LLOIHPNDJLA;

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x86E850", Offset = "0x86D450", VA = "0x18086E850")]
	public EPIDMNHCALL(string LLOIHPNDJLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x6AA3B80", Offset = "0x6AA2780", VA = "0x186AA3B80", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public sealed class IHJBDENMBEB
{
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	[CompilerGenerated]
	private sealed class OOAAADKFLDG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public StringBuilder sb;

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x86FB10", Offset = "0x86E710", VA = "0x18086FB10")]
		public OOAAADKFLDG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x6AA6D00", Offset = "0x6AA5900", VA = "0x186AA6D00")]
		internal int LPAAHLBEDLA(int i, object token)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private HashSet<object>? CFMGNFGOFDP;

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public IReadOnlyCollection<object> BIKOBCCBKJL
	{
		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x6AA41E0", Offset = "0x6AA2DE0", VA = "0x186AA41E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public bool PFNPOIDCBPL
	{
		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x6AA41D0", Offset = "0x6AA2DD0", VA = "0x186AA41D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public int NAAONAFFINP
	{
		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x867580", Offset = "0x866180", VA = "0x180867580")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x867D00", Offset = "0x866900", VA = "0x180867D00")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x6AA40F0", Offset = "0x6AA2CF0", VA = "0x186AA40F0")]
	public bool LKPJOLMECIF(object GBENACPKFNA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x6AA4050", Offset = "0x6AA2C50", VA = "0x186AA4050")]
	public bool ECLBFOFCOFL(object GBENACPKFNA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x6AA3F80", Offset = "0x6AA2B80", VA = "0x186AA3F80")]
	public bool CPEFJACKAGC(object GBENACPKFNA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x6AA3FE0", Offset = "0x6AA2BE0", VA = "0x186AA3FE0")]
	public void DKINLCGABCJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x6AA4270", Offset = "0x6AA2E70", VA = "0x186AA4270", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x86FB10", Offset = "0x86E710", VA = "0x18086FB10")]
	public IHJBDENMBEB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public class DEHOPLDGAFI<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	private struct ILECIOEEGLE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public float JNHHIFMHCCA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public T JCMGPEFMEMP;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private readonly Dictionary<object, ILECIOEEGLE> CNAIHKDCKLB;

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public virtual T KHPIGBHNJIC
	{
		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x10842B0", Offset = "0x1082EB0", VA = "0x1810842B0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x1083890", Offset = "0x1082490", VA = "0x181083890", Slot = "5")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public object? PBEODMPDPAP
	{
		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x867CF0", Offset = "0x8668F0", VA = "0x180867CF0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x867CC0", Offset = "0x8668C0", VA = "0x180867CC0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public bool CHELEKHBFFD
	{
		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x5891830", Offset = "0x5890430", VA = "0x185891830")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x5891EA0", Offset = "0x5890AA0", VA = "0x185891EA0")]
	public bool LCIJIMMMDPD(T IIPLJLPCLBC, object GBENACPKFNA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x3ECA770", Offset = "0x3EC9370", VA = "0x183ECA770")]
	public bool MHFEADBCBPA(object GBENACPKFNA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x385C2A0", Offset = "0x385AEA0", VA = "0x18385C2A0")]
	public void AFPCPCPKMJJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x5893C10", Offset = "0x5892810", VA = "0x185893C10")]
	public bool PNDEAMPCPGC(object GBENACPKFNA, [Out] T IIPLJLPCLBC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x5892F80", Offset = "0x5891B80", VA = "0x185892F80")]
	[DDGBKNGOPIL("T can be T?, `default!` shouldn't be necessary in C# 9")]
	private bool PKFOHKLIEHI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x3ECAA20", Offset = "0x3EC9620", VA = "0x183ECAA20")]
	public DEHOPLDGAFI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public sealed class FCNNHDBKMPK<T> where T : class
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private List<WeakReference<T>>? CFMGNFGOFDP;

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public bool PFNPOIDCBPL
	{
		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x3C01BB0", Offset = "0x3C007B0", VA = "0x183C01BB0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public int NAAONAFFINP
	{
		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x3C01570", Offset = "0x3C00170", VA = "0x183C01570")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x3C01920", Offset = "0x3C00520", VA = "0x183C01920")]
	public void LKPJOLMECIF(T GBENACPKFNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x3C01770", Offset = "0x3C00370", VA = "0x183C01770")]
	public void ECLBFOFCOFL(T GBENACPKFNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x3C01720", Offset = "0x3C00320", VA = "0x183C01720")]
	public void DKINLCGABCJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x3C01CE0", Offset = "0x3C008E0", VA = "0x183C01CE0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x86FB10", Offset = "0x86E710", VA = "0x18086FB10")]
	public FCNNHDBKMPK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
internal static class ILMKFFMIMCI
{
	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x29E70E0", Offset = "0x29E5CE0", VA = "0x1829E70E0")]
	public static void ACJCBDDHPJG<T>(this List<T> ELBBNOKMNCJ, int BAEBMIBABAE) where T : notnull
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public interface CCMLBAANCBG
{
	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event PBMPNMINHOB LGDNHOHICAC;
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public class OPCJIBBMPKM : CCMLBAANCBG, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000048")]
	public readonly struct KECDKNOFGOF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public readonly float CBAJJELMFPM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public readonly float BNKOHBOJIFP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		internal readonly bool PHIOAAOKLPJ;

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public float FODIPBCKAJM
		{
			[Cpp2IlInjected.Token(Token = "0x6000132")]
			[Cpp2IlInjected.Address(RVA = "0x6AA5BE0", Offset = "0x6AA47E0", VA = "0x186AA5BE0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x6AA5D60", Offset = "0x6AA4960", VA = "0x186AA5D60")]
		public KECDKNOFGOF(float CNNPCLMHBKN, float CLJNFDDEOFA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x6AA5BF0", Offset = "0x6AA47F0", VA = "0x186AA5BF0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000049")]
	[CompilerGenerated]
	private sealed class GDNLAKLFNCN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		public OPCJIBBMPKM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		public int newProgressableIndex;

		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x86FB10", Offset = "0x86E710", VA = "0x18086FB10")]
		public GDNLAKLFNCN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x6AA3BD0", Offset = "0x6AA27D0", VA = "0x186AA3BD0")]
		internal void BIICAMPIOPP(float innerProgress)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private readonly int DFJDDCJIBIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private int NKOOOGIHMGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private readonly CCMLBAANCBG[] BDHLPDAPMNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private readonly PBMPNMINHOB[] JMKPKEHPNLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private readonly KECDKNOFGOF[] AAOCCPNEDJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private KECDKNOFGOF OGNMKHNBIJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private readonly GIHGFNFLHKF PGGENDCFJFB;

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event PBMPNMINHOB LGDNHOHICAC
	{
		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x6AA7010", Offset = "0x6AA5C10", VA = "0x186AA7010", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x6AA6DB0", Offset = "0x6AA59B0", VA = "0x186AA6DB0", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x6AA7550", Offset = "0x6AA6150", VA = "0x186AA7550")]
	public OPCJIBBMPKM(int DFJDDCJIBIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x6AA6F80", Offset = "0x6AA5B80", VA = "0x186AA6F80")]
	public GIHGFNFLHKF EJOLEGCGFJK(KECDKNOFGOF FHHLMBJFCEC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x6AA70D0", Offset = "0x6AA5CD0", VA = "0x186AA70D0")]
	public void OGNOHFPDAMP(CCMLBAANCBG NBOGHLAMIAD, [Optional] KECDKNOFGOF CHBIJAKFKDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x6AA6E70", Offset = "0x6AA5A70", VA = "0x186AA6E70", Slot = "6")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public delegate void PBMPNMINHOB(float NGAMHGHMCHP);
[Cpp2IlInjected.Token(Token = "0x200004B")]
public static class KOOPAFMLOMO
{
	[Cpp2IlInjected.Token(Token = "0x200004C")]
	private class ICPAIOIHACH : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		private readonly CCMLBAANCBG GAGFHEEFEGC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private readonly PBMPNMINHOB LABOKGHKKOB;

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x6AA3EF0", Offset = "0x6AA2AF0", VA = "0x186AA3EF0")]
		public ICPAIOIHACH(CCMLBAANCBG GAGFHEEFEGC, PBMPNMINHOB LABOKGHKKOB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x6AA3EA0", Offset = "0x6AA2AA0", VA = "0x186AA3EA0", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x6AA5F80", Offset = "0x6AA4B80", VA = "0x186AA5F80")]
	internal static bool NDIMFDNGAKC(float PFJBMEMCGDE, float GCHHKKAJBGE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x6A96780", Offset = "0x6A95380", VA = "0x186A96780")]
	internal static float FNDBEBDKGML(float PFJBMEMCGDE)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x6AA5EC0", Offset = "0x6AA4AC0", VA = "0x186AA5EC0")]
	public static IDisposable FJPCCPGEJCN(this CCMLBAANCBG GAGFHEEFEGC, PBMPNMINHOB LABOKGHKKOB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public class GIHGFNFLHKF : CCMLBAANCBG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private float NGAMHGHMCHP;

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public float PNLEMFFGAIG
	{
		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x6AA3DB0", Offset = "0x6AA29B0", VA = "0x186AA3DB0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public event PBMPNMINHOB? LGDNHOHICAC
	{
		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x6AA3D10", Offset = "0x6AA2910", VA = "0x186AA3D10", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x6AA3C70", Offset = "0x6AA2870", VA = "0x186AA3C70", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x86FB10", Offset = "0x86E710", VA = "0x18086FB10")]
	public GIHGFNFLHKF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public interface ABLOOIONLPK<T> where T : class, new()
{
	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(Slot = "0")]
	GLIBIBOBMIG<T> JJDEFHBJCMN([Out] T IIPLJLPCLBC);

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void AFPCPCPKMJJ();
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public class DHFGBJLLMAD<T> : ABLOOIONLPK<T> where T : class, new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	private readonly ConcurrentStack<T> CBIPKLLHCMD;

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x58A0B70", Offset = "0x589F770", VA = "0x1858A0B70", Slot = "4")]
	public GLIBIBOBMIG<T> JJDEFHBJCMN([Out] T IIPLJLPCLBC)
	{
		return default(GLIBIBOBMIG<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x58A0C10", Offset = "0x589F810", VA = "0x1858A0C10")]
	public void NNDEKLEFPFP(T ACGIOINLKJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x4244390", Offset = "0x4242F90", VA = "0x184244390", Slot = "5")]
	public void AFPCPCPKMJJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x866B20", Offset = "0x865720", VA = "0x180866B20", Slot = "6")]
	protected virtual void FFPFFBCIKEM(T EIOMIEGEOIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x58A0C90", Offset = "0x589F890", VA = "0x1858A0C90")]
	private T OIPGNBHOLEB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x58A0D40", Offset = "0x589F940", VA = "0x1858A0D40")]
	public DHFGBJLLMAD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public readonly struct GLIBIBOBMIG<T> : IDisposable where T : class, new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	private readonly T ACGIOINLKJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	private readonly DHFGBJLLMAD<T> LDDBKNFFEFI;

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0xAC5C80", Offset = "0xAC4880", VA = "0x180AC5C80")]
	internal GLIBIBOBMIG(T IIPLJLPCLBC, DHFGBJLLMAD<T> LDDBKNFFEFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x3D62540", Offset = "0x3D61140", VA = "0x183D62540", Slot = "4")]
	void IDisposable.Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public class LDOEACJPLDI : DHFGBJLLMAD<StringBuilder>
{
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	public static readonly LDOEACJPLDI NKKNEDDGFMP;

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x6AA6010", Offset = "0x6AA4C10", VA = "0x186AA6010")]
	public static GLIBIBOBMIG<StringBuilder> OIPGNBHOLEB([Out] StringBuilder IIPLJLPCLBC)
	{
		return default(GLIBIBOBMIG<StringBuilder>);
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x6AA5FF0", Offset = "0x6AA4BF0", VA = "0x186AA5FF0", Slot = "6")]
	protected override void FFPFFBCIKEM(StringBuilder EIOMIEGEOIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x6AA6150", Offset = "0x6AA4D50", VA = "0x186AA6150")]
	public LDOEACJPLDI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
public class NKKDGCAPNIP : InvalidOperationException
{
	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x650DC70", Offset = "0x650C870", VA = "0x18650DC70")]
	public NKKDGCAPNIP(string NKAJDDICLFH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
[DefaultMember("Item")]
public class PGCBENNBLHO<TKey, TValue> : PBGCOFCGGGM<TKey, TValue>, IDictionary<TKey, TValue>, ICollection<KeyValuePair<TKey, TValue>>, IEnumerable<KeyValuePair<TKey, TValue>>, IEnumerable, LILJEOGEJEM where TKey : notnull where TValue : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000054")]
	[CompilerGenerated]
	private sealed class PAFPBBNJBBB : IEnumerator<KeyValuePair<TKey, TValue>>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		private KeyValuePair<TKey, TValue> <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public PGCBENNBLHO<TKey, TValue> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		private IEnumerator<KeyValuePair<TKey, TValue>> <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		KeyValuePair<TKey, TValue> IEnumerator<KeyValuePair<TKey, TValue>>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000171")]
			[Cpp2IlInjected.Address(RVA = "0x10842B0", Offset = "0x1082EB0", VA = "0x1810842B0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return default(KeyValuePair<TKey, TValue>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000173")]
			[Cpp2IlInjected.Address(RVA = "0x4756B90", Offset = "0x4755790", VA = "0x184756B90", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x865A80", Offset = "0x864680", VA = "0x180865A80")]
		[DebuggerHidden]
		public PAFPBBNJBBB(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x394AF70", Offset = "0x3949B70", VA = "0x18394AF70", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x4755C10", Offset = "0x4754810", VA = "0x184755C10", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x4756A00", Offset = "0x4755600", VA = "0x184756A00")]
		private void OPGOEIKMBCE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x4755BC0", Offset = "0x47547C0", VA = "0x184755BC0")]
		private void JMPEPBOJIAB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x4756AF0", Offset = "0x47556F0", VA = "0x184756AF0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	private readonly PBGCOFCGGGM<TKey, TValue> FINFHFIGLAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	private readonly IDictionary<TKey, TValue> NIIPBBKEFAP;

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public int NAAONAFFINP
	{
		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x4787CC0", Offset = "0x47868C0", VA = "0x184787CC0", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public bool JGMKIDPCBFO
	{
		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x8AE100", Offset = "0x8ACD00", VA = "0x1808AE100", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public TValue PJODKJCBOKO
	{
		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x4787F70", Offset = "0x4786B70", VA = "0x184787F70", Slot = "4")]
		get
		{
			return (TValue)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x4788220", Offset = "0x4786E20", VA = "0x184788220", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public ICollection<TKey> MKLNDMFLBIH
	{
		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x4787FC0", Offset = "0x4786BC0", VA = "0x184787FC0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public ICollection<TValue> EGGKJPHIHKK
	{
		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x47880F0", Offset = "0x4786CF0", VA = "0x1847880F0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x4787BF0", Offset = "0x47867F0", VA = "0x184787BF0")]
	public PGCBENNBLHO(PBGCOFCGGGM<TKey, TValue> FINFHFIGLAB, [Optional] IDictionary<TKey, TValue>? NIIPBBKEFAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x47855F0", Offset = "0x47841F0", VA = "0x1847855F0", Slot = "15")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x4786010", Offset = "0x4784C10", VA = "0x184786010")]
	public void EIOKKJNEEEH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x4785010", Offset = "0x4783C10", VA = "0x184785010", Slot = "9")]
	public void Add(TKey NCMHANGAILD, TValue IIPLJLPCLBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x4785390", Offset = "0x4783F90", VA = "0x184785390")]
	public void BAEMACEIHDE(TKey NCMHANGAILD, TValue IIPLJLPCLBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x4786C30", Offset = "0x4785830", VA = "0x184786C30")]
	public void KGHGLIBFNHG(TKey NCMHANGAILD, TValue IIPLJLPCLBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x4786190", Offset = "0x4784D90", VA = "0x184786190")]
	public void GEJHPLNEOFL(TKey NCMHANGAILD, TValue IIPLJLPCLBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x4786DC0", Offset = "0x47859C0", VA = "0x184786DC0")]
	public void NPNBGNAMLHK(TKey NCMHANGAILD, TValue IIPLJLPCLBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x4787260", Offset = "0x4785E60", VA = "0x184787260", Slot = "14")]
	void ICollection<KeyValuePair<TKey, TValue>>.Add(KeyValuePair<TKey, TValue> NLEFMACAEAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x47872B0", Offset = "0x4785EB0", VA = "0x1847872B0", Slot = "16")]
	bool ICollection<KeyValuePair<TKey, TValue>>.Contains(KeyValuePair<TKey, TValue> NLEFMACAEAP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x47877B0", Offset = "0x47863B0", VA = "0x1847877B0", Slot = "18")]
	bool ICollection<KeyValuePair<TKey, TValue>>.Remove(KeyValuePair<TKey, TValue> NLEFMACAEAP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x4785730", Offset = "0x4784330", VA = "0x184785730", Slot = "8")]
	public bool ContainsKey(TKey NCMHANGAILD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x4785F50", Offset = "0x4784B50", VA = "0x184785F50")]
	public bool DBCOCACDCNB(TKey NCMHANGAILD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x4786950", Offset = "0x4785550", VA = "0x184786950")]
	public bool HCGHEJAGNLN(TKey NCMHANGAILD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x4787070", Offset = "0x4785C70", VA = "0x184787070", Slot = "10")]
	public bool Remove(TKey NCMHANGAILD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x4787A50", Offset = "0x4786650", VA = "0x184787A50", Slot = "11")]
	public bool TryGetValue(TKey NCMHANGAILD, [Out] TValue IIPLJLPCLBC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x4785800", Offset = "0x4784400", VA = "0x184785800", Slot = "17")]
	public void CopyTo(KeyValuePair<TKey, TValue>[] DKCMKELIAPN, int ELEIFPFNELG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x4178E40", Offset = "0x4177A40", VA = "0x184178E40", Slot = "20")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x47868A0", Offset = "0x47854A0", VA = "0x1847868A0", Slot = "19")]
	[IteratorStateMachine(typeof(PGCBENNBLHO<, >.PAFPBBNJBBB))]
	public IEnumerator<KeyValuePair<TKey, TValue>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x4786AC0", Offset = "0x47856C0", VA = "0x184786AC0", Slot = "21")]
	public bool INGHKKPICIK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x47865E0", Offset = "0x47851E0", VA = "0x1847865E0")]
	private TValue GFEKIPEHKPN(TKey NCMHANGAILD)
	{
		return (TValue)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public interface LILJEOGEJEM
{
	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool INGHKKPICIK();
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
public interface PBGCOFCGGGM<TKey, TVal> : IDictionary<TKey, TVal>, ICollection<KeyValuePair<TKey, TVal>>, IEnumerable<KeyValuePair<TKey, TVal>>, IEnumerable, LILJEOGEJEM
{
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
[DefaultMember("Item")]
public sealed class FBOJOKLNJJM<TKey, TVal> : PBGCOFCGGGM<TKey, TVal>, IDictionary<TKey, TVal>, ICollection<KeyValuePair<TKey, TVal>>, IEnumerable<KeyValuePair<TKey, TVal>>, IEnumerable, LILJEOGEJEM where TKey : notnull where TVal : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000058")]
	public delegate int MPKCBDFEDLC(TKey NCMHANGAILD, TVal IIPLJLPCLBC);

	[Cpp2IlInjected.Token(Token = "0x2000059")]
	public delegate void HJHFEMFABDM(TKey NCMHANGAILD, TVal IIPLJLPCLBC, APNGJBKBHFJ GLMDIHNLEBJ);

	[Cpp2IlInjected.Token(Token = "0x200005A")]
	private class MLAJOHGLMJH
	{
		[Cpp2IlInjected.Token(Token = "0x17000040")]
		public TKey KNLKLIOEEBP
		{
			[Cpp2IlInjected.Token(Token = "0x600019F")]
			[Cpp2IlInjected.Address(RVA = "0x8DA100", Offset = "0x8D8D00", VA = "0x1808DA100")]
			[CompilerGenerated]
			get
			{
				return (TKey)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		public TVal JCMGPEFMEMP
		{
			[Cpp2IlInjected.Token(Token = "0x60001A0")]
			[Cpp2IlInjected.Address(RVA = "0x8E1AD0", Offset = "0x8E06D0", VA = "0x1808E1AD0")]
			[CompilerGenerated]
			get
			{
				return (TVal)null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001A1")]
			[Cpp2IlInjected.Address(RVA = "0x8E1990", Offset = "0x8E0590", VA = "0x1808E1990")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		public int FODIPBCKAJM
		{
			[Cpp2IlInjected.Token(Token = "0x60001A2")]
			[Cpp2IlInjected.Address(RVA = "0x8A5290", Offset = "0x8A3E90", VA = "0x1808A5290")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60001A3")]
			[Cpp2IlInjected.Address(RVA = "0x8A4E40", Offset = "0x8A3A40", VA = "0x1808A4E40")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000043")]
		public DateTimeOffset APBHMKHPJLJ
		{
			[Cpp2IlInjected.Token(Token = "0x60001A4")]
			[Cpp2IlInjected.Address(RVA = "0xC48800", Offset = "0xC47400", VA = "0x180C48800")]
			[CompilerGenerated]
			get
			{
				return default(DateTimeOffset);
			}
			[Cpp2IlInjected.Token(Token = "0x60001A5")]
			[Cpp2IlInjected.Address(RVA = "0x14ECE50", Offset = "0x14EBA50", VA = "0x1814ECE50")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x4491810", Offset = "0x4490410", VA = "0x184491810")]
		public MLAJOHGLMJH(TKey NCMHANGAILD, TVal BMEHNBDMOJG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005C")]
	[CompilerGenerated]
	private sealed class KMDBFIKPBOC : IEnumerator<KeyValuePair<TKey, TVal>>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		private KeyValuePair<TKey, TVal> <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		public FBOJOKLNJJM<TKey, TVal> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		private LinkedList<MLAJOHGLMJH>.Enumerator <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		KeyValuePair<TKey, TVal> IEnumerator<KeyValuePair<TKey, TVal>>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001AF")]
			[Cpp2IlInjected.Address(RVA = "0x10842B0", Offset = "0x1082EB0", VA = "0x1810842B0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return default(KeyValuePair<TKey, TVal>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000045")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001B1")]
			[Cpp2IlInjected.Address(RVA = "0x3AA08C0", Offset = "0x3A9F4C0", VA = "0x183AA08C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x865A80", Offset = "0x864680", VA = "0x180865A80")]
		[DebuggerHidden]
		public KMDBFIKPBOC(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x3945890", Offset = "0x3944490", VA = "0x183945890", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x41C4970", Offset = "0x41C3570", VA = "0x1841C4970", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x41C4CC0", Offset = "0x41C38C0", VA = "0x1841C4CC0")]
		private void OPGOEIKMBCE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x41C4DA0", Offset = "0x41C39A0", VA = "0x1841C4DA0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400007F")]
	public const int HDMMEEEGGPC = -1;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	private readonly Dictionary<TKey, LinkedListNode<MLAJOHGLMJH>> MBGPCNCDGOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	private readonly LinkedList<MLAJOHGLMJH> OFEPFMHJIBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	private readonly MPKCBDFEDLC? NKOGHEGIMAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	private readonly TimeSpan MGHJNBFOBMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	private readonly HJHFEMFABDM? FEENNKFHIGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	private readonly KLEGFBIPAPD OJIBDFGMPKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private bool GCICDIJAPMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private readonly List<TKey> JACPJJGFAEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private readonly List<TVal> ADNIPIPHHDB;

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public int BEDOIHFIHBM
	{
		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x875460", Offset = "0x874060", VA = "0x180875460")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	internal int BCIJEMDKGBC
	{
		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0xB162A0", Offset = "0xB14EA0", VA = "0x180B162A0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0xB15D70", Offset = "0xB14970", VA = "0x180B15D70")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public int NAAONAFFINP
	{
		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x3BD8F50", Offset = "0x3BD7B50", VA = "0x183BD8F50", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	internal int BMHOKAIKJCP
	{
		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x385C2A0", Offset = "0x385AEA0", VA = "0x18385C2A0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public ICollection<TVal> EGGKJPHIHKK
	{
		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x3BD91A0", Offset = "0x3BD7DA0", VA = "0x183BD91A0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	ICollection<TKey> IDictionary<TKey, TVal>.EPPGCFCGLON
	{
		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x3BD4E50", Offset = "0x3BD3A50", VA = "0x183BD4E50", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public bool JGMKIDPCBFO
	{
		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x8AE100", Offset = "0x8ACD00", VA = "0x1808AE100", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public TVal PJODKJCBOKO
	{
		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x3BD9140", Offset = "0x3BD7D40", VA = "0x183BD9140", Slot = "4")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x3BD91F0", Offset = "0x3BD7DF0", VA = "0x183BD91F0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x3BCB0F0", Offset = "0x3BC9CF0", VA = "0x183BCB0F0")]
	private bool HFGPBKLMNIE(int DFJDDCJIBIA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600017D")]
	[Cpp2IlInjected.Address(RVA = "0x3BC8E40", Offset = "0x3BC7A40", VA = "0x183BC8E40")]
	private void DPGMLFKGLIF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0x3BD5DF0", Offset = "0x3BD49F0", VA = "0x183BD5DF0")]
	public FBOJOKLNJJM(int DFJDDCJIBIA, [Optional] MPKCBDFEDLC? NKOGHEGIMAA, [Optional] IEqualityComparer<TKey>? FCPNKFDOJHF, [Optional] HJHFEMFABDM? FEENNKFHIGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(RVA = "0x3BD5FB0", Offset = "0x3BD4BB0", VA = "0x183BD5FB0")]
	public FBOJOKLNJJM(TimeSpan MGHJNBFOBMJ, [Optional] IEqualityComparer<TKey>? FCPNKFDOJHF, [Optional] HJHFEMFABDM? FEENNKFHIGO, [Optional] KLEGFBIPAPD? OJIBDFGMPKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000181")]
	[Cpp2IlInjected.Address(RVA = "0x3BD6BD0", Offset = "0x3BD57D0", VA = "0x183BD6BD0")]
	public FBOJOKLNJJM(int DFJDDCJIBIA, TimeSpan MGHJNBFOBMJ, [Optional] IEqualityComparer<TKey>? FCPNKFDOJHF, [Optional] HJHFEMFABDM? FEENNKFHIGO, [Optional] KLEGFBIPAPD? OJIBDFGMPKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(RVA = "0x3BD8AD0", Offset = "0x3BD76D0", VA = "0x183BD8AD0")]
	public FBOJOKLNJJM(int DFJDDCJIBIA, MPKCBDFEDLC? NKOGHEGIMAA, TimeSpan MGHJNBFOBMJ, [Optional] IEqualityComparer<TKey>? FCPNKFDOJHF, [Optional] HJHFEMFABDM? FEENNKFHIGO, [Optional] KLEGFBIPAPD? OJIBDFGMPKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(RVA = "0x3BCD420", Offset = "0x3BCC020", VA = "0x183BCD420", Slot = "21")]
	public bool INGHKKPICIK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000184")]
	[Cpp2IlInjected.Address(RVA = "0x3BCB350", Offset = "0x3BC9F50", VA = "0x183BCB350", Slot = "22")]
	public bool IFPKLCOGEOP(int INGCLKPLIOP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000185")]
	[Cpp2IlInjected.Address(RVA = "0x3BD0100", Offset = "0x3BCED00", VA = "0x183BD0100")]
	private bool LMLCDNGIALL(int INGCLKPLIOP, APNGJBKBHFJ GLMDIHNLEBJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000188")]
	[Cpp2IlInjected.Address(RVA = "0x3BCBFB0", Offset = "0x3BCABB0", VA = "0x183BCBFB0")]
	public void IJGOPKKNHAN(TKey NCMHANGAILD, TVal IIPLJLPCLBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000189")]
	[Cpp2IlInjected.Address(RVA = "0x3BC1CC0", Offset = "0x3BC08C0", VA = "0x183BC1CC0", Slot = "14")]
	public void Add(KeyValuePair<TKey, TVal> NLEFMACAEAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018A")]
	[Cpp2IlInjected.Address(RVA = "0x3BC1B40", Offset = "0x3BC0740", VA = "0x183BC1B40", Slot = "9")]
	public void Add(TKey NCMHANGAILD, TVal IIPLJLPCLBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018B")]
	[Cpp2IlInjected.Address(RVA = "0x3BC6EE0", Offset = "0x3BC5AE0", VA = "0x183BC6EE0", Slot = "8")]
	public bool ContainsKey(TKey NCMHANGAILD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600018C")]
	[Cpp2IlInjected.Address(RVA = "0x3BD4260", Offset = "0x3BD2E60", VA = "0x183BD4260", Slot = "16")]
	bool ICollection<KeyValuePair<TKey, TVal>>.Contains(KeyValuePair<TKey, TVal> NLEFMACAEAP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600018D")]
	[Cpp2IlInjected.Address(RVA = "0x3BD3D80", Offset = "0x3BD2980", VA = "0x183BD3D80", Slot = "10")]
	public bool Remove(TKey NCMHANGAILD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600018E")]
	[Cpp2IlInjected.Address(RVA = "0x3BD4670", Offset = "0x3BD3270", VA = "0x183BD4670", Slot = "18")]
	bool ICollection<KeyValuePair<TKey, TVal>>.Remove(KeyValuePair<TKey, TVal> NLEFMACAEAP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(RVA = "0x3BC2870", Offset = "0x3BC1470", VA = "0x183BC2870")]
	private bool CCJMGMLBIJD(TKey NCMHANGAILD, [Out] TVal IIPLJLPCLBC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000190")]
	[Cpp2IlInjected.Address(RVA = "0x3BD3240", Offset = "0x3BD1E40", VA = "0x183BD3240")]
	private TVal OIPGNBHOLEB(TKey GJHKHOAMOEF)
	{
		return (TVal)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(RVA = "0x3BD5520", Offset = "0x3BD4120", VA = "0x183BD5520", Slot = "11")]
	public bool TryGetValue(TKey GJHKHOAMOEF, [Out] TVal IIPLJLPCLBC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0x3BC6B00", Offset = "0x3BC5700", VA = "0x183BC6B00", Slot = "15")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(RVA = "0x3BC7D40", Offset = "0x3BC6940", VA = "0x183BC7D40", Slot = "17")]
	public void CopyTo(KeyValuePair<TKey, TVal>[] DKCMKELIAPN, int ELEIFPFNELG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000194")]
	[Cpp2IlInjected.Address(RVA = "0x3BC9360", Offset = "0x3BC7F60", VA = "0x183BC9360")]
	private void ELPONMBMINN(TKey NCMHANGAILD, TVal BMEHNBDMOJG, APNGJBKBHFJ GLMDIHNLEBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000195")]
	[Cpp2IlInjected.Address(RVA = "0x3BC9F70", Offset = "0x3BC8B70", VA = "0x183BC9F70")]
	private bool GIPIANKEOLG(MLAJOHGLMJH NIPPJCCOGNK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(RVA = "0x3BC59C0", Offset = "0x3BC45C0", VA = "0x183BC59C0")]
	private void CFAPAIHEBHC(LinkedListNode<MLAJOHGLMJH> MDDGPDCDEJL, TVal NHPLJONGPGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x3BCDF10", Offset = "0x3BCCB10", VA = "0x183BCDF10")]
	private void LCIJIMMMDPD(TKey NCMHANGAILD, TVal IIPLJLPCLBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(RVA = "0x3BCCDC0", Offset = "0x3BCB9C0", VA = "0x183BCCDC0")]
	private void IKFPEJDACNK(MLAJOHGLMJH NIPPJCCOGNK, TVal NHPLJONGPGD, int FJFOOKJDMKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0x3BCAE30", Offset = "0x3BC9A30", VA = "0x183BCAE30", Slot = "19")]
	[IteratorStateMachine(typeof(FBOJOKLNJJM<, >.KMDBFIKPBOC))]
	public IEnumerator<KeyValuePair<TKey, TVal>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(RVA = "0x3BD4EA0", Offset = "0x3BD3AA0", VA = "0x183BD4EA0", Slot = "20")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
public enum APNGJBKBHFJ : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	Evicted,
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	RemovedViaRemove,
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	RemovedViaClear,
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	Overwritten
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
public class IHKJHGOHOKI<TKey> : Exception where TKey : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	public readonly TKey KOCDGLDJLIG;

	[Cpp2IlInjected.Token(Token = "0x60001B2")]
	[Cpp2IlInjected.Address(RVA = "0x3EAB510", Offset = "0x3EAA110", VA = "0x183EAB510")]
	public IHKJHGOHOKI(TKey IPDBJFIJPBB, Exception PJELPOAIABL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
public class MPFPEFMMIMC : ArgumentException
{
	[Cpp2IlInjected.Token(Token = "0x60001B3")]
	[Cpp2IlInjected.Address(RVA = "0x5DE75A0", Offset = "0x5DE61A0", VA = "0x185DE75A0")]
	public MPFPEFMMIMC(string NKAJDDICLFH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
public class GGPGNIIIDFD<TId, TResource> : IEnumerable<(TId, Task<TResource>, int)>, IEnumerable where TId : notnull where TResource : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000061")]
	[CompilerGenerated]
	private sealed class BIMALACNCOF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		public Func<TId, CancellationToken, Task<TResource>> factory;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		public GGPGNIIIDFD<TId, TResource> <>4__this;

		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x86FB10", Offset = "0x86E710", VA = "0x18086FB10")]
		public BIMALACNCOF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x4E7AD80", Offset = "0x4E79980", VA = "0x184E7AD80")]
		internal Task<TResource> OBOHAEPFFEC(TId _id)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000062")]
	[CompilerGenerated]
	private struct DEPMOHLOBFI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		public Task<TResource> task;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		public GGPGNIIIDFD<TId, TResource> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		private TaskAwaiter<TResource> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x5894170", Offset = "0x5892D70", VA = "0x185894170", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x5894AD0", Offset = "0x58936D0", VA = "0x185894AD0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000063")]
	[CompilerGenerated]
	private struct BBIMCACFECA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		public Task<TResource> task;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		public Dictionary<Task<TResource>, CancellationTokenSource> cancellationTokenSources;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		public CancellationTokenSource cts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		private TaskAwaiter<TResource> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x4E60150", Offset = "0x4E5ED50", VA = "0x184E60150", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x4E60E50", Offset = "0x4E5FA50", VA = "0x184E60E50", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private readonly FDILDAGIHMC<TId, Task<TResource>> NMCMOLFFEGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private readonly Dictionary<Task<TResource>, CancellationTokenSource> PHHNHLHGIGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private readonly Func<TId, CancellationToken, Task<TResource>>? ALADHFKDNLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private readonly Action<TResource>? CLMDMMBPLAO;

	[Cpp2IlInjected.Token(Token = "0x60001B4")]
	[Cpp2IlInjected.Address(RVA = "0x3D4D4D0", Offset = "0x3D4C0D0", VA = "0x183D4D4D0")]
	public GGPGNIIIDFD(int FJFIKCNOKCK = 0, [Optional] IEqualityComparer<TId>? FMBDCKCEJKL, [Optional] Func<TId, CancellationToken, Task<TResource>>? INKNDJFGBMD, [Optional] Action<TResource>? IIPGFMIBHJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B5")]
	[Cpp2IlInjected.Address(RVA = "0x3D4CAD0", Offset = "0x3D4B6D0", VA = "0x183D4CAD0")]
	public ELKLJFKIONH<Task<TResource>> GGAOPBDBMHA(TId CABAGOHBNFK, [Optional] Func<TId, CancellationToken, Task<TResource>>? INKNDJFGBMD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(RVA = "0x3D4BD00", Offset = "0x3D4A900", VA = "0x183D4BD00")]
	private void COKLMBDGFJL(Task<TResource> LJPOAIPEHGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B7")]
	[Cpp2IlInjected.Address(RVA = "0x3D4C7D0", Offset = "0x3D4B3D0", VA = "0x183D4C7D0")]
	[AsyncStateMachine(typeof(GGPGNIIIDFD<, >.DEPMOHLOBFI))]
	private Task GFCFOCGHFEH(Task<TResource> LJPOAIPEHGB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(RVA = "0x3D4D280", Offset = "0x3D4BE80", VA = "0x183D4D280")]
	public void MOPLAKGEBEJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B9")]
	[Cpp2IlInjected.Address(RVA = "0x3D4C110", Offset = "0x3D4AD10", VA = "0x183D4C110")]
	public FDILDAGIHMC<TId, Task<TResource>>.NGADDBEKLCF DHNABIACCII()
	{
		return default(FDILDAGIHMC<TId, Task<TResource>>.NGADDBEKLCF);
	}

	[Cpp2IlInjected.Token(Token = "0x60001BA")]
	[Cpp2IlInjected.Address(RVA = "0x3D4D430", Offset = "0x3D4C030", VA = "0x183D4D430", Slot = "4")]
	private IEnumerator<(TId, Task<TResource>, int)> System.Collections.Generic.IEnumerable<(TIdId,System.Threading.Tasks.Task<TResource>LoadResourceTask,System.Int32RefCount)>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001BB")]
	[Cpp2IlInjected.Address(RVA = "0x3D4D430", Offset = "0x3D4C030", VA = "0x183D4D430", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001BC")]
	[Cpp2IlInjected.Address(RVA = "0x3D4C5A0", Offset = "0x3D4B1A0", VA = "0x183D4C5A0")]
	[AsyncStateMachine(typeof(GGPGNIIIDFD<, >.BBIMCACFECA))]
	[CompilerGenerated]
	internal static Task EAHKNKHLBAG(Task<TResource> LJPOAIPEHGB, CancellationTokenSource EEJMMACLKAM, Dictionary<Task<TResource>, CancellationTokenSource> PNCMIABCDDA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
public class FDILDAGIHMC<TKey, TValue> : IEnumerable<(TKey, TValue, int)>, IEnumerable where TKey : notnull where TValue : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000065")]
	private sealed class IJLOKIFNNPG : IEquatable<IJLOKIFNNPG>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		public readonly TValue JCMGPEFMEMP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		public int IJCLIPEDPPK;

		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x961020", Offset = "0x95FC20", VA = "0x180961020")]
		public IJLOKIFNNPG(TValue IIPLJLPCLBC, int KAAKMNAKLCA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0x3EAEBD0", Offset = "0x3EAD7D0", VA = "0x183EAEBD0", Slot = "4")]
		public bool Equals(IJLOKIFNNPG? HEIGABGMPLJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x3EAEC60", Offset = "0x3EAD860", VA = "0x183EAEC60", Slot = "0")]
		public override bool Equals(object? APKAFMDACKK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0x3EAED10", Offset = "0x3EAD910", VA = "0x183EAED10", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000066")]
	public struct NGADDBEKLCF : IEnumerator<(TKey, TValue, int)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		private Dictionary<TKey, IJLOKIFNNPG>.Enumerator EHCMCILKODG;

		[Cpp2IlInjected.Token(Token = "0x17000046")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001D2")]
			[Cpp2IlInjected.Address(RVA = "0x44F59B0", Offset = "0x44F45B0", VA = "0x1844F59B0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000047")]
		public (TKey Key, TValue Value, int RefCount) KENACMDPOBM
		{
			[Cpp2IlInjected.Token(Token = "0x60001D3")]
			[Cpp2IlInjected.Address(RVA = "0x44F5FA0", Offset = "0x44F4BA0", VA = "0x1844F5FA0", Slot = "4")]
			get
			{
				return default((TKey, TValue, int));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x44F5CB0", Offset = "0x44F48B0", VA = "0x1844F5CB0")]
		public NGADDBEKLCF(FDILDAGIHMC<TKey, TValue> CNAIHKDCKLB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x44F5550", Offset = "0x44F4150", VA = "0x1844F5550", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0x44F55D0", Offset = "0x44F41D0", VA = "0x1844F55D0", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0x44F5650", Offset = "0x44F4250", VA = "0x1844F5650", Slot = "8")]
		public void Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000067")]
	[CompilerGenerated]
	private sealed class APKJMBOLLGB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		public FDILDAGIHMC<TKey, TValue> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		public TKey key;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		public IJLOKIFNNPG refCountedValue;

		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0x86FB10", Offset = "0x86E710", VA = "0x18086FB10")]
		public APKJMBOLLGB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x3D46BF0", Offset = "0x3D457F0", VA = "0x183D46BF0")]
		internal void OBOHAEPFFEC()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	private readonly Dictionary<TKey, IJLOKIFNNPG> DGLNPBCCNEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	private readonly Func<TKey, TValue>? MDDBKPCFJGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	private readonly Action<TValue>? LCENGBAOALG;

	[Cpp2IlInjected.Token(Token = "0x60001C3")]
	[Cpp2IlInjected.Address(RVA = "0x3C05D10", Offset = "0x3C04910", VA = "0x183C05D10")]
	public FDILDAGIHMC(int FJFIKCNOKCK = 0, [Optional] IEqualityComparer<TKey>? FCPNKFDOJHF, [Optional] Func<TKey, TValue>? GOFJAIELMJM, [Optional] Action<TValue>? KDLJINNIAKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C4")]
	[Cpp2IlInjected.Address(RVA = "0x3C04410", Offset = "0x3C03010", VA = "0x183C04410")]
	public ELKLJFKIONH<TValue> GGAOPBDBMHA(TKey NCMHANGAILD, [Optional] Func<TKey, TValue>? EPDOHHIOLIB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C5")]
	[Cpp2IlInjected.Address(RVA = "0x3C05750", Offset = "0x3C04350", VA = "0x183C05750")]
	private void NNDEKLEFPFP(TKey NCMHANGAILD, IJLOKIFNNPG FBKOKFKKGLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C6")]
	[Cpp2IlInjected.Address(RVA = "0x3C05530", Offset = "0x3C04130", VA = "0x183C05530")]
	public void MOPLAKGEBEJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C7")]
	[Cpp2IlInjected.Address(RVA = "0x3C04390", Offset = "0x3C02F90", VA = "0x183C04390")]
	public NGADDBEKLCF DHNABIACCII()
	{
		return default(NGADDBEKLCF);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C8")]
	[Cpp2IlInjected.Address(RVA = "0x3C05B20", Offset = "0x3C04720", VA = "0x183C05B20", Slot = "4")]
	private IEnumerator<(TKey, TValue, int)> System.Collections.Generic.IEnumerable<(TKeyKey,TValueValue,System.Int32RefCount)>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C9")]
	[Cpp2IlInjected.Address(RVA = "0x3C05B20", Offset = "0x3C04720", VA = "0x183C05B20", Slot = "5")]
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
