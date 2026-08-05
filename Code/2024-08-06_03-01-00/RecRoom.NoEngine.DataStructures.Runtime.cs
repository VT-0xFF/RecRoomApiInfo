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
		[Cpp2IlInjected.Address(RVA = "0x8878E0", Offset = "0x885EE0", VA = "0x1808878E0")]
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
		[Cpp2IlInjected.Address(RVA = "0x6A86850", Offset = "0x6A84E50", VA = "0x186A86850")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x888570", Offset = "0x886B70", VA = "0x180888570")]
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
		[Cpp2IlInjected.Address(RVA = "0x8885B0", Offset = "0x886BB0", VA = "0x1808885B0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public abstract class HIJKIEJHIIG
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x8692F0", Offset = "0x8678F0", VA = "0x1808692F0")]
	protected HIJKIEJHIIG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public abstract class IGFOELDHGHG<T> : HIJKIEJHIIG
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	protected struct AJOGJPEHDFO
	{
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		public enum MFOFHPABHLH
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
		public MFOFHPABHLH BDKLEMDNAFL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public T IJDJHMGAIOM;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private int GLDHJPDKHKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly bool DEPLLDGPNEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	protected readonly bool JCBMFJIMKPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	protected List<T>? PMPHLNPIOLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private List<AJOGJPEHDFO>? FJLDDIELPLO;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public bool KHBJCGGOBHL
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x3E19160", Offset = "0x3E17760", VA = "0x183E19160")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x3E19560", Offset = "0x3E17B60", VA = "0x183E19560")]
	protected IGFOELDHGHG(bool JCBMFJIMKPL, bool DEPLLDGPNEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x3E191D0", Offset = "0x3E177D0", VA = "0x183E191D0")]
	protected bool OAONGCHLHCH()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x3E19270", Offset = "0x3E17870", VA = "0x183E19270")]
	protected void PEPPLDOLNCB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x3E18D10", Offset = "0x3E17310", VA = "0x183E18D10")]
	protected void KENOFPHLEPO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x2A948C0", Offset = "0x2A92EC0", VA = "0x182A948C0")]
	private static void NDGPMBHDPDG<U>(List<U>? MNNCEMFBNNK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x3E18B00", Offset = "0x3E17100", VA = "0x183E18B00", Slot = "4")]
	public void AGMNBECNIJC(T IJDJHMGAIOM, bool DDHBGPMMJPL = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x3E19390", Offset = "0x3E17990", VA = "0x183E19390", Slot = "5")]
	public void PJEMHMBEIPM(T IJDJHMGAIOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x3E18FB0", Offset = "0x3E175B0", VA = "0x183E18FB0")]
	public void KFLPEIEEDCE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public sealed class CLOBMDANPDK : IGFOELDHGHG<Action>
{
	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x6A84260", Offset = "0x6A82860", VA = "0x186A84260")]
	public CLOBMDANPDK(bool JCBMFJIMKPL = false, bool DEPLLDGPNEA = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x6A84000", Offset = "0x6A82600", VA = "0x186A84000")]
	public void DFDLGJKGLOI()
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x6A84200", Offset = "0x6A82800", VA = "0x186A84200")]
	public static CLOBMDANPDK EEIKJJKDCIF(CLOBMDANPDK CBPJEEIIIBG, Action IJDJHMGAIOM)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x6A83FA0", Offset = "0x6A825A0", VA = "0x186A83FA0")]
	public static CLOBMDANPDK CFPMNIDPBAM(CLOBMDANPDK CBPJEEIIIBG, Action IJDJHMGAIOM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface NFIDKAEBDAM<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void AGMNBECNIJC(Action<T> IJDJHMGAIOM, bool DDHBGPMMJPL = false);

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void PJEMHMBEIPM(Action<T> IJDJHMGAIOM);
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public sealed class BEJAMOEFGKL<T> : IGFOELDHGHG<Action<T>>, NFIDKAEBDAM<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x3C6A900", Offset = "0x3C68F00", VA = "0x183C6A900")]
	public BEJAMOEFGKL(bool JCBMFJIMKPL = false, bool DEPLLDGPNEA = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x4EE8DC0", Offset = "0x4EE73C0", VA = "0x184EE8DC0")]
	public void DFDLGJKGLOI(T GJMDIBEDCBL)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x3D53C20", Offset = "0x3D52220", VA = "0x183D53C20")]
	public static BEJAMOEFGKL<T> EEIKJJKDCIF(BEJAMOEFGKL<T> CBPJEEIIIBG, Action<T> IJDJHMGAIOM)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x3D518D0", Offset = "0x3D4FED0", VA = "0x183D518D0")]
	public static BEJAMOEFGKL<T> CFPMNIDPBAM(BEJAMOEFGKL<T> CBPJEEIIIBG, Action<T> IJDJHMGAIOM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface FJHADGIFDND<T, U> where T : notnull where U : notnull
{
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public sealed class HONHOEKIKED<T, U> : IGFOELDHGHG<Action<T, U>>, FJHADGIFDND<T, U> where T : notnull where U : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x3C6A900", Offset = "0x3C68F00", VA = "0x183C6A900")]
	public HONHOEKIKED(bool JCBMFJIMKPL = false, bool DEPLLDGPNEA = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x3D522D0", Offset = "0x3D508D0", VA = "0x183D522D0")]
	public void DFDLGJKGLOI(T GJMDIBEDCBL, U MPPEEPOGFEA)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x3D53C20", Offset = "0x3D52220", VA = "0x183D53C20")]
	public static HONHOEKIKED<T, U> EEIKJJKDCIF(HONHOEKIKED<T, U> CBPJEEIIIBG, Action<T, U> IJDJHMGAIOM)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x3D518D0", Offset = "0x3D4FED0", VA = "0x183D518D0")]
	public static HONHOEKIKED<T, U> CFPMNIDPBAM(HONHOEKIKED<T, U> CBPJEEIIIBG, Action<T, U> IJDJHMGAIOM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public sealed class NFPAMNODNCJ<T, U, V> : IGFOELDHGHG<Action<T, U, V>> where T : notnull where U : notnull where V : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x3C6A900", Offset = "0x3C68F00", VA = "0x183C6A900")]
	public NFPAMNODNCJ(bool JCBMFJIMKPL = false, bool DEPLLDGPNEA = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x4578890", Offset = "0x4576E90", VA = "0x184578890")]
	public void DFDLGJKGLOI(T GJMDIBEDCBL, U MPPEEPOGFEA, V ONOKCMNNMGN)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x3D53C20", Offset = "0x3D52220", VA = "0x183D53C20")]
	public static NFPAMNODNCJ<T, U, V> EEIKJJKDCIF(NFPAMNODNCJ<T, U, V> CBPJEEIIIBG, Action<T, U, V> IJDJHMGAIOM)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x3D518D0", Offset = "0x3D4FED0", VA = "0x183D518D0")]
	public static NFPAMNODNCJ<T, U, V> CFPMNIDPBAM(NFPAMNODNCJ<T, U, V> CBPJEEIIIBG, Action<T, U, V> IJDJHMGAIOM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface BBIDKNAGBCG<T, U, V, W>
{
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public sealed class NGEDGMKFCOB<T, U, V, W> : IGFOELDHGHG<Action<T, U, V, W>>, BBIDKNAGBCG<T, U, V, W> where T : notnull where U : notnull where V : notnull where W : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x3C6A900", Offset = "0x3C68F00", VA = "0x183C6A900")]
	public NGEDGMKFCOB(bool JCBMFJIMKPL = false, bool DEPLLDGPNEA = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x4579330", Offset = "0x4577930", VA = "0x184579330")]
	public void DFDLGJKGLOI(T GJMDIBEDCBL, U MPPEEPOGFEA, V ONOKCMNNMGN, W BABLFAIMKPL)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x3D53C20", Offset = "0x3D52220", VA = "0x183D53C20")]
	public static NGEDGMKFCOB<T, U, V, W> EEIKJJKDCIF(NGEDGMKFCOB<T, U, V, W> CBPJEEIIIBG, Action<T, U, V, W> IJDJHMGAIOM)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x3D518D0", Offset = "0x3D4FED0", VA = "0x183D518D0")]
	public static NGEDGMKFCOB<T, U, V, W> CFPMNIDPBAM(NGEDGMKFCOB<T, U, V, W> CBPJEEIIIBG, Action<T, U, V, W> IJDJHMGAIOM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public sealed class CNIGOBCPJBH<T, U, V, W, X> : IGFOELDHGHG<Action<T, U, V, W, X>>
{
	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x3C6A900", Offset = "0x3C68F00", VA = "0x183C6A900")]
	public CNIGOBCPJBH(bool JCBMFJIMKPL = false, bool DEPLLDGPNEA = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x51BB2F0", Offset = "0x51B98F0", VA = "0x1851BB2F0")]
	public void DFDLGJKGLOI(T GJMDIBEDCBL, U MPPEEPOGFEA, V ONOKCMNNMGN, W BABLFAIMKPL, X OEMFOJFNECE)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x3D53C20", Offset = "0x3D52220", VA = "0x183D53C20")]
	public static CNIGOBCPJBH<T, U, V, W, X> EEIKJJKDCIF(CNIGOBCPJBH<T, U, V, W, X> CBPJEEIIIBG, Action<T, U, V, W, X> IJDJHMGAIOM)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x3D518D0", Offset = "0x3D4FED0", VA = "0x183D518D0")]
	public static CNIGOBCPJBH<T, U, V, W, X> CFPMNIDPBAM(CNIGOBCPJBH<T, U, V, W, X> CBPJEEIIIBG, Action<T, U, V, W, X> IJDJHMGAIOM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public sealed class BDENCGACDPJ<T, U, V, W, X, Y> : IGFOELDHGHG<Action<T, U, V, W, X, Y>>
{
	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x3C6A900", Offset = "0x3C68F00", VA = "0x183C6A900")]
	public BDENCGACDPJ(bool JCBMFJIMKPL = false, bool DEPLLDGPNEA = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x4EE0370", Offset = "0x4EDE970", VA = "0x184EE0370")]
	public void DFDLGJKGLOI(T GJMDIBEDCBL, U MPPEEPOGFEA, V ONOKCMNNMGN, W BABLFAIMKPL, X OEMFOJFNECE, Y DPKOFHFGJKJ)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x3D53C20", Offset = "0x3D52220", VA = "0x183D53C20")]
	public static BDENCGACDPJ<T, U, V, W, X, Y> EEIKJJKDCIF(BDENCGACDPJ<T, U, V, W, X, Y> CBPJEEIIIBG, Action<T, U, V, W, X, Y> IJDJHMGAIOM)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x3D518D0", Offset = "0x3D4FED0", VA = "0x183D518D0")]
	public static BDENCGACDPJ<T, U, V, W, X, Y> CFPMNIDPBAM(BDENCGACDPJ<T, U, V, W, X, Y> CBPJEEIIIBG, Action<T, U, V, W, X, Y> IJDJHMGAIOM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public class BJEMMAPIFLD<TKey, TVal> where TKey : notnull where TVal : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly LKGLDJOEKJK<TKey, TVal> GBGCJPOJANL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	internal readonly Dictionary<TKey, (TVal value, int size)> BLIJEFAFLME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private readonly LKGLDJOEKJK<TKey, TVal>.FDCJCDHMCDD? OCAMNNOHPOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private readonly int JHOBNOOJLMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private readonly LKGLDJOEKJK<TKey, TVal>.AAPCCAPMMPH? MJOMCCCNEEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private int OMDEIPPBACO;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	internal int EJNKNAFFBCO
	{
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x4F21180", Offset = "0x4F1F780", VA = "0x184F21180")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public int HLDGGDLOPHI
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x85F440", Offset = "0x85DA40", VA = "0x18085F440")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x4F21FF0", Offset = "0x4F205F0", VA = "0x184F21FF0")]
	public BJEMMAPIFLD(int JHOBNOOJLMI, [Optional] LKGLDJOEKJK<TKey, TVal>.AAPCCAPMMPH? MJOMCCCNEEE, [Optional] IEqualityComparer<TKey>? OPFBHDJCGDH, [Optional] LKGLDJOEKJK<TKey, TVal>.FDCJCDHMCDD? OCAMNNOHPOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x4F20C30", Offset = "0x4F1F230", VA = "0x184F20C30")]
	public void BFCMHILAOHJ(TKey MNBFPOFIDHA, TVal FEBGGALLBNN, bool MFLPGBGGIKI = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x4F215F0", Offset = "0x4F1FBF0", VA = "0x184F215F0")]
	public bool IKDKJCEKPEM(TKey MNBFPOFIDHA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x4F21EF0", Offset = "0x4F204F0", VA = "0x184F21EF0")]
	public bool NCAHNJJKPNF(TKey FHLBFJLDNAL, [Out] TVal FEBGGALLBNN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x4F211E0", Offset = "0x4F1F7E0", VA = "0x184F211E0")]
	private void FDOCBJHJJIH(TKey MNBFPOFIDHA, TVal FEBGGALLBNN, int PPOFLGDKIBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x4F20FB0", Offset = "0x4F1F5B0", VA = "0x184F20FB0")]
	public bool DHBEBBMMMME(TKey MNBFPOFIDHA, TVal FEBGGALLBNN, bool MFLPGBGGIKI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x4F21760", Offset = "0x4F1FD60", VA = "0x184F21760")]
	public void KFLPEIEEDCE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x4F21960", Offset = "0x4F1FF60", VA = "0x184F21960")]
	private void NBIODJGPBMO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x4F21810", Offset = "0x4F1FE10", VA = "0x184F21810")]
	private bool LOFFCCPJOFK(TKey MNBFPOFIDHA, ADFIMBGMKOL HBKEEHODHEK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x4F214C0", Offset = "0x4F1FAC0", VA = "0x184F214C0")]
	private void HGMHHAOFHGH(TKey MNBFPOFIDHA, TVal FEBGGALLBNN, ADFIMBGMKOL HBKEEHODHEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x4F20E80", Offset = "0x4F1F480", VA = "0x184F20E80")]
	private void CFFHCOJIFGA(TKey MNBFPOFIDHA, TVal GAELHANIPAM, ADFIMBGMKOL HBKEEHODHEK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class LLOPEJPAAKJ : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private readonly Action HIGGGMLLMGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private bool PDCOMJHMCFG;

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x8682B0", Offset = "0x8668B0", VA = "0x1808682B0")]
	public LLOPEJPAAKJ(Action BBIGAGCAOBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x6A86340", Offset = "0x6A84940", VA = "0x186A86340", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x2972330", Offset = "0x2970930", VA = "0x182972330")]
	public static OCANDJCDBAG<T> KKJEMJBKDLP<T>(T FEBGGALLBNN, Action BBIGAGCAOBD) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public sealed class OCANDJCDBAG<T> : LLOPEJPAAKJ where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public T MDPJKNKDANF
	{
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x85F450", Offset = "0x85DA50", VA = "0x18085F450")]
		[CompilerGenerated]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x46D3690", Offset = "0x46D1C90", VA = "0x1846D3690")]
	public OCANDJCDBAG(T FEBGGALLBNN, Action BBIGAGCAOBD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public sealed class ANNFLNHKMNA<T> : IDisposable where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private readonly ECNEELLHPIH<T>? EOEHFFOAMEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private readonly ReadOnlySequence<T> CJAIHBAMGLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private bool PDCOMJHMCFG;

	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public static readonly ANNFLNHKMNA<T> IJMGMBPJJCI;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public ReadOnlySequence<T> MPGKFDBFFND
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x3D8B5A0", Offset = "0x3D89BA0", VA = "0x183D8B5A0")]
		get
		{
			return default(ReadOnlySequence<T>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public long BANKGEHECOP
	{
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x3D8B620", Offset = "0x3D89C20", VA = "0x183D8B620")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public bool BNJOFFCHEKO
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x3D8B860", Offset = "0x3D89E60", VA = "0x183D8B860")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x3D8BB20", Offset = "0x3D8A120", VA = "0x183D8BB20")]
	public ANNFLNHKMNA(ECNEELLHPIH<T> BNEBKBGCLPN, ECNEELLHPIH<T> JCIAEGENGJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x3D8BFF0", Offset = "0x3D8A5F0", VA = "0x183D8BFF0")]
	public ANNFLNHKMNA(ECNEELLHPIH<T> BNEBKBGCLPN, int CHEJIFFIDLB, ECNEELLHPIH<T> JCIAEGENGJC, int DKGEKHELJDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x3D8BA70", Offset = "0x3D8A070", VA = "0x183D8BA70")]
	private ANNFLNHKMNA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x3D8B360", Offset = "0x3D89960", VA = "0x183D8B360", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x3D8B2A0", Offset = "0x3D898A0", VA = "0x183D8B2A0")]
	public T[] AAHIFJHBHEG()
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x3D8B3F0", Offset = "0x3D899F0", VA = "0x183D8B3F0")]
	public static ReadOnlySequence<T> IHCIOHJGPAF(ANNFLNHKMNA<T>? EKOPIDBFEPE)
	{
		return default(ReadOnlySequence<T>);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000017")]
public readonly struct DHCKKIGFMDM : IDisposable
{
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public readonly struct DBBHILNOCCF : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x8A6190", Offset = "0x8A4790", VA = "0x1808A6190")]
		public static DBBHILNOCCF NKOJKFHACJH()
		{
			return default(DBBHILNOCCF);
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x85E9E0", Offset = "0x85CFE0", VA = "0x18085E9E0", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x29AAB50", Offset = "0x29A9150", VA = "0x1829AAB50")]
	public static string? LGKPKOKNCPB<T>([Optional] string? ABKKONPEJJA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x29AAAD0", Offset = "0x29A90D0", VA = "0x1829AAAD0")]
	public static string? JPPOMNGIGHK<T>([Optional] string? GEMEFHKAFNJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x8A6190", Offset = "0x8A4790", VA = "0x1808A6190")]
	public static DHCKKIGFMDM AINDKFFJENA(string ABKKONPEJJA, string? GEMEFHKAFNJ)
	{
		return default(DHCKKIGFMDM);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x85E9E0", Offset = "0x85CFE0", VA = "0x18085E9E0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public struct ODEJHONECGK
{
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public delegate bool JEGGHNFCKIC(string IDJOIDLBHBP, ODEJHONECGK ILIAEHJCJFL);

	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[CompilerGenerated]
	private sealed class LICNKCIJIDI<T> where T : notnull, Enum
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public List<int> enumValuesSubset;

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x8692F0", Offset = "0x8678F0", VA = "0x1808692F0")]
		public LICNKCIJIDI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x42AE140", Offset = "0x42AC740", VA = "0x1842AE140")]
		internal void BGODKFHCNDE(T x)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public int FKJJEAOFBOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public string HJLBLJFCLPM;

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x6A86C90", Offset = "0x6A85290", VA = "0x186A86C90")]
	public static Dictionary<string, ODEJHONECGK> GCFEMNNICNM(Type HFAFLGFODND)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x2CE5950", Offset = "0x2CE3F50", VA = "0x182CE5950")]
	public static Dictionary<string, ODEJHONECGK> GCFEMNNICNM<T>(Type HFAFLGFODND, IReadOnlyDictionary<T, string> ADKLJIAAIFO) where T : notnull, Enum
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x2CE6180", Offset = "0x2CE4780", VA = "0x182CE6180")]
	public static Dictionary<string, ODEJHONECGK> GMAFEAALIHM<T>(List<T> GDAFDLMKDOP) where T : notnull, Enum
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x6A868D0", Offset = "0x6A84ED0", VA = "0x186A868D0")]
	public static Dictionary<string, ODEJHONECGK> AHEOOCNCFBI(Type HFAFLGFODND, JEGGHNFCKIC DMCOEIJANII)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x6A86FC0", Offset = "0x6A855C0", VA = "0x186A86FC0")]
	public static Dictionary<int, string> MLOCJFEOGDM(Dictionary<string, ODEJHONECGK> JOCJMGGBHIC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public abstract class EKHHLAEJNGE : PFOLFPHIKGH
{
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public static bool PIBLOKBLGIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	private readonly string? JKJABDFADBD;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public virtual PFOLFPHIKGH? OBHHJMBFPLD
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x85E9F0", Offset = "0x85CFF0", VA = "0x18085E9F0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x6A85AD0", Offset = "0x6A840D0", VA = "0x186A85AD0")]
	protected EKHHLAEJNGE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(Slot = "7")]
	public abstract string DLMCGACMBKO();

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x6A85540", Offset = "0x6A83B40", VA = "0x186A85540", Slot = "8")]
	public virtual string BLOGIPBAOJB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x6A855C0", Offset = "0x6A83BC0", VA = "0x186A855C0", Slot = "9")]
	public void EPMNGALLBNJ(StringBuilder IIKAGDADFIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x6A859D0", Offset = "0x6A83FD0", VA = "0x186A859D0", Slot = "10")]
	public void NLIJBJHCEGB(StringBuilder IIKAGDADFIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x6A85420", Offset = "0x6A83A20", VA = "0x186A85420", Slot = "11")]
	public void ADJLOLEOLNG(StringBuilder IIKAGDADFIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x6A85870", Offset = "0x6A83E70", VA = "0x186A85870", Slot = "12")]
	public void LHIDLPMHCON(StringBuilder IIKAGDADFIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x6A85A30", Offset = "0x6A84030", VA = "0x186A85A30")]
	public static void PIEKDANIPFA(StringBuilder IIKAGDADFIJ, string IGDCFOJDNGG, string MFPFNFCNEKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x5C64170", Offset = "0x5C62770", VA = "0x185C64170", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class NHFABODCLNF : Exception
{
	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x6A86520", Offset = "0x6A84B20", VA = "0x186A86520")]
	public NHFABODCLNF(string DICMABMCPKO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class GJBBDNEJCNA<TErr> : NHFABODCLNF where TErr : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public readonly TErr FFEAAHJJNFC;

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x3CD9B80", Offset = "0x3CD8180", VA = "0x183CD9B80")]
	private GJBBDNEJCNA([In] TErr JHFPKIAMKPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x3CD9AA0", Offset = "0x3CD80A0", VA = "0x183CD9AA0")]
	public static GJBBDNEJCNA<TErr> NKOJKFHACJH([In] TErr JHFPKIAMKPI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class EJMOOGDJHJH : Stream
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private readonly HashAlgorithm HNNGGOFPCHF;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public override bool NNPHIKHAEMC
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x8A6190", Offset = "0x8A4790", VA = "0x1808A6190", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public override bool BMLOJHHBHCK
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x8A6190", Offset = "0x8A4790", VA = "0x1808A6190", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public override bool GCCOJAFIIFO
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x878510", Offset = "0x876B10", VA = "0x180878510", Slot = "11")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public override long BANKGEHECOP
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x6A852D0", Offset = "0x6A838D0", VA = "0x186A852D0", Slot = "12")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public override long MCOMLLJHBBI
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x6A85340", Offset = "0x6A83940", VA = "0x186A85340", Slot = "13")]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x6A853B0", Offset = "0x6A839B0", VA = "0x186A853B0", Slot = "14")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x6A85260", Offset = "0x6A83860", VA = "0x186A85260")]
	public EJMOOGDJHJH(HashAlgorithm HNNGGOFPCHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x6A85090", Offset = "0x6A83690", VA = "0x186A85090", Slot = "35")]
	public override int Read(byte[] KGHDKIBNGIE, int LHOLHMCKPEO, int FDDANCOAHOL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x6A85230", Offset = "0x6A83830", VA = "0x186A85230", Slot = "38")]
	public override void Write(byte[] KGHDKIBNGIE, int LHOLHMCKPEO, int FDDANCOAHOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x6A85130", Offset = "0x6A83730", VA = "0x186A85130", Slot = "33")]
	public override long Seek(long LHOLHMCKPEO, SeekOrigin PGBFIMCGBLE)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x6A851C0", Offset = "0x6A837C0", VA = "0x186A851C0", Slot = "34")]
	public override void SetLength(long FEBGGALLBNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x85E9E0", Offset = "0x85CFE0", VA = "0x18085E9E0", Slot = "23")]
	public override void Flush()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x6A84FC0", Offset = "0x6A835C0", VA = "0x186A84FC0")]
	public byte[] KCBJMPEGKLK()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public interface PFOLFPHIKGH
{
	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(Slot = "0")]
	string BLOGIPBAOJB();

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(Slot = "1")]
	string DLMCGACMBKO();
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public interface APGKCJLMPOM<out TOptions> where TOptions : notnull
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	TOptions MDPJKNKDANF
	{
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public interface KOCIELDGJFC
{
	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	string JMHGJMEMEEG
	{
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public sealed class ECNEELLHPIH<T> : ReadOnlySequenceSegment<T>, IDisposable where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private static ECNEELLHPIH<T>? EPKJHNMEKMO;

	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private static object CCEKFAFDMLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private IMemoryOwner<T>? FMDBNHLGOLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private bool PDCOMJHMCFG;

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public bool JEDAHGMJAJE
	{
		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x96BE50", Offset = "0x96A450", VA = "0x18096BE50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x37DB550", Offset = "0x37D9B50", VA = "0x1837DB550")]
	private static ECNEELLHPIH<T> MAGOLDBNOLA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x37DA4F0", Offset = "0x37D8AF0", VA = "0x1837DA4F0")]
	private static void IMMLBGAMDJO(ECNEELLHPIH<T> HEGICFCGPID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x37DBDE0", Offset = "0x37DA3E0", VA = "0x1837DBDE0")]
	private ECNEELLHPIH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x37DB230", Offset = "0x37D9830", VA = "0x1837DB230")]
	public static ECNEELLHPIH<T> KKJEMJBKDLP(ReadOnlyMemory<T> CJGDPKPECIH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x37DAE30", Offset = "0x37D9430", VA = "0x1837DAE30")]
	public static ECNEELLHPIH<T> KKJEMJBKDLP(IMemoryOwner<T> HEMGEJKJAAI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x37DB410", Offset = "0x37D9A10", VA = "0x1837DB410")]
	public static void LFFMLHAOMKE(ECNEELLHPIH<T> BNEBKBGCLPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x37D9FD0", Offset = "0x37D85D0", VA = "0x1837D9FD0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x37DBA20", Offset = "0x37DA020", VA = "0x1837DBA20")]
	public ECNEELLHPIH<T> MHNGNGPDOJG(IMemoryOwner<T> HEMGEJKJAAI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x37DAC30", Offset = "0x37D9230", VA = "0x1837DAC30")]
	private void KKICOGGKCIG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x37DAAD0", Offset = "0x37D90D0", VA = "0x1837DAAD0")]
	private ECNEELLHPIH<T> JGFJOKEHIGF(ECNEELLHPIH<T> HEGICFCGPID)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public class LAOCEHJNAHL : Exception
{
	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x6A862E0", Offset = "0x6A848E0", VA = "0x186A862E0")]
	public LAOCEHJNAHL(string DICMABMCPKO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public class KHNIHAHJCLM<TOk> : LAOCEHJNAHL where TOk : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public readonly TOk CPPFBKBPLGG;

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x41EC230", Offset = "0x41EA830", VA = "0x1841EC230")]
	private KHNIHAHJCLM([In] TOk KOKMBFFIMLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x3B82980", Offset = "0x3B80F80", VA = "0x183B82980")]
	public static KHNIHAHJCLM<TOk> NKOJKFHACJH([In] TOk KOKMBFFIMLP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public class EIJOMNGNJGO : Stream
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private readonly ReadOnlySequence<byte> CJAIHBAMGLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private SequencePosition DHHBENCPDLN;

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public override bool NNPHIKHAEMC
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x878510", Offset = "0x876B10", VA = "0x180878510", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public override bool BMLOJHHBHCK
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x878510", Offset = "0x876B10", VA = "0x180878510", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public override bool GCCOJAFIIFO
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x8A6190", Offset = "0x8A4790", VA = "0x1808A6190", Slot = "11")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public override long BANKGEHECOP
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x6A84C80", Offset = "0x6A83280", VA = "0x186A84C80", Slot = "12")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public override long MCOMLLJHBBI
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x6A84CE0", Offset = "0x6A832E0", VA = "0x186A84CE0", Slot = "13")]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x6A84DB0", Offset = "0x6A833B0", VA = "0x186A84DB0", Slot = "14")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x6A84BB0", Offset = "0x6A831B0", VA = "0x186A84BB0")]
	public EIJOMNGNJGO(ReadOnlySequence<byte> EKOPIDBFEPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x6A84760", Offset = "0x6A82D60", VA = "0x186A84760", Slot = "33")]
	public override long Seek(long LHOLHMCKPEO, SeekOrigin PGBFIMCGBLE)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x6A842C0", Offset = "0x6A828C0", VA = "0x186A842C0", Slot = "35")]
	public override int Read(byte[] KGHDKIBNGIE, int LHOLHMCKPEO, int FDDANCOAHOL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x85E9E0", Offset = "0x85CFE0", VA = "0x18085E9E0", Slot = "23")]
	public override void Flush()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x6A84AF0", Offset = "0x6A830F0", VA = "0x186A84AF0", Slot = "34")]
	public override void SetLength(long FEBGGALLBNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x6A84B50", Offset = "0x6A83150", VA = "0x186A84B50", Slot = "38")]
	public override void Write(byte[] KGHDKIBNGIE, int LHOLHMCKPEO, int FDDANCOAHOL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public readonly struct HHANDHIMCMH<TOk, TErr> : IEquatable<HHANDHIMCMH<TOk, TErr>> where TOk : notnull where TErr : notnull
{
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private static readonly EqualityComparer<TErr> HCLEKFBGFOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	internal readonly TErr FFEAAHJJNFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	internal readonly TOk CPPFBKBPLGG;

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public bool CAKMNBEMHKK
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x3D41000", Offset = "0x3D3F600", VA = "0x183D41000")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public bool AIFMMLCCFLJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x3D416E0", Offset = "0x3D3FCE0", VA = "0x183D416E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x3D46F50", Offset = "0x3D45550", VA = "0x183D46F50")]
	internal HHANDHIMCMH([In] TErr JHFPKIAMKPI, [In] TOk KOKMBFFIMLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x3D40B60", Offset = "0x3D3F160", VA = "0x183D40B60")]
	public static HHANDHIMCMH<TOk, TErr> IIBEPAPJKKE([In] TErr JHFPKIAMKPI)
	{
		return default(HHANDHIMCMH<TOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x3D43AA0", Offset = "0x3D420A0", VA = "0x183D43AA0")]
	public static HHANDHIMCMH<TOk, TErr> OCPINIADNPB([In] TOk KOKMBFFIMLP)
	{
		return default(HHANDHIMCMH<TOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x2A94050", Offset = "0x2A92650", VA = "0x182A94050")]
	public HHANDHIMCMH<TOk?, UErr?> JEJHBNEJBNG<UErr>()
	{
		return default(HHANDHIMCMH<TOk, UErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x2A93E10", Offset = "0x2A92410", VA = "0x182A93E10")]
	public HHANDHIMCMH<UOk?, TErr?> GNAKLNEKLNA<UOk>()
	{
		return default(HHANDHIMCMH<UOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x2A933A0", Offset = "0x2A919A0", VA = "0x182A933A0")]
	public HHANDHIMCMH<UOk?, TErr?> DIOECNHNDCF<UOk>()
	{
		return default(HHANDHIMCMH<UOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x2A92640", Offset = "0x2A90C40", VA = "0x182A92640")]
	public HHANDHIMCMH<TOk?, UErr?> AGFNNOBIOFD<UErr>()
	{
		return default(HHANDHIMCMH<TOk, UErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x3D43350", Offset = "0x3D41950", VA = "0x183D43350")]
	public HHANDHIMCMH<DHABIOOJNOJ, TErr> NCPEMEILJFJ()
	{
		return default(HHANDHIMCMH<DHABIOOJNOJ, TErr>);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x3D42090", Offset = "0x3D40690", VA = "0x183D42090")]
	public static bool MLHBCNDBLOI([In] HHANDHIMCMH<TOk, TErr> GKFLJIIICHM, [In] HHANDHIMCMH<TOk, TErr> GCLENKIGLBM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x3D3E670", Offset = "0x3D3CC70", VA = "0x183D3E670", Slot = "4")]
	public bool Equals(HHANDHIMCMH<TOk, TErr> OGEIJLCLBIC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x3D3ED10", Offset = "0x3D3D310", VA = "0x183D3ED10", Slot = "0")]
	public override bool Equals(object OGEIJLCLBIC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x3D401E0", Offset = "0x3D3E7E0", VA = "0x183D401E0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x3D45880", Offset = "0x3D43E80", VA = "0x183D45880", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public static class JHDAGGIILLN
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	[CompilerGenerated]
	private struct BGEKEPNKLCN<TOk, TErr> : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		public AsyncTaskMethodBuilder<TOk> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		public Task<HHANDHIMCMH<TOk, TErr>> self;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private TaskAwaiter<HHANDHIMCMH<TOk, TErr>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x4F0F530", Offset = "0x4F0DB30", VA = "0x184F0F530", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x4F0FBB0", Offset = "0x4F0E1B0", VA = "0x184F0FBB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x2BBAB70", Offset = "0x2BB9170", VA = "0x182BBAB70")]
	public static HHANDHIMCMH<TOk?, TErr?> CPPFBKBPLGG<TOk, TErr>([In] this HHANDHIMCMH<TOk, TErr> ELMHNMGFNPC, [In] TOk KOKMBFFIMLP)
	{
		return default(HHANDHIMCMH<TOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x2BBAC30", Offset = "0x2BB9230", VA = "0x182BBAC30")]
	public static HHANDHIMCMH<DHABIOOJNOJ, TErr?> CPPFBKBPLGG<TErr>([In] this HHANDHIMCMH<DHABIOOJNOJ, TErr> ELMHNMGFNPC)
	{
		return default(HHANDHIMCMH<DHABIOOJNOJ, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x2BBAB70", Offset = "0x2BB9170", VA = "0x182BBAB70")]
	public static HHANDHIMCMH<TOk?, TErr?> FFEAAHJJNFC<TOk, TErr>([In] this HHANDHIMCMH<TOk, TErr> ELMHNMGFNPC, [In] TErr JHFPKIAMKPI)
	{
		return default(HHANDHIMCMH<TOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x2BBB7D0", Offset = "0x2BB9DD0", VA = "0x182BBB7D0")]
	public static TOk? LGJOEOAIJGG<TOk, TErr>([In] this HHANDHIMCMH<TOk, TErr> ELMHNMGFNPC)
	{
		return (TOk?)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x2BBBC20", Offset = "0x2BBA220", VA = "0x182BBBC20")]
	[AsyncStateMachine(typeof(BGEKEPNKLCN<, >))]
	public static Task<TOk?>? NMLNODIEKGG<TOk, TErr>(this Task<HHANDHIMCMH<TOk, TErr>> ELMHNMGFNPC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x2BBD990", Offset = "0x2BBBF90", VA = "0x182BBD990")]
	public static TErr? OGBEOIPPMAM<TErr, TOk>([In] this HHANDHIMCMH<TOk, TErr> ELMHNMGFNPC)
	{
		return (TErr?)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x2BBC030", Offset = "0x2BBA630", VA = "0x182BBC030")]
	public static bool NOMDAHNIKNM<TOk, TErr, UErr, UOk>([In] this HHANDHIMCMH<TOk, TErr> ELMHNMGFNPC, [Out] HHANDHIMCMH<UOk, UErr> PKNJBPICNDE) where TErr : UErr?
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x2BBAA30", Offset = "0x2BB9030", VA = "0x182BBAA30")]
	public static bool BFMPMEBEDEL<TOk, TErr>([In] this HHANDHIMCMH<TOk, TErr> ELMHNMGFNPC, [Out][NotNullWhen(true)] TOk KOKMBFFIMLP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x2BBAD90", Offset = "0x2BB9390", VA = "0x182BBAD90")]
	public static bool GBCDAGAKJOD<TOk, TErr>([In] this HHANDHIMCMH<TOk, TErr> ELMHNMGFNPC, [Out][NotNullWhen(true)] TErr JHFPKIAMKPI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x2BBB4F0", Offset = "0x2BB9AF0", VA = "0x182BBB4F0")]
	public static bool JKBFKNCKIPC<TOk, TErr>([In] this HHANDHIMCMH<TOk, TErr> ELMHNMGFNPC, [Out][NotNullWhen(true)] TOk KOKMBFFIMLP, [Out][NotNullWhen(false)] TErr JHFPKIAMKPI) where TOk : notnull where TErr : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x2BBB360", Offset = "0x2BB9960", VA = "0x182BBB360")]
	public static bool HAFCKMIGHOE<TOk, TErr>([In] this HHANDHIMCMH<TOk, TErr> ELMHNMGFNPC, [Out][NotNullWhen(true)] TOk KOKMBFFIMLP, [Out] HHANDHIMCMH<TOk, TErr> PKNJBPICNDE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x2BBC290", Offset = "0x2BBA890", VA = "0x182BBC290")]
	public static bool NOMDAHNIKNM<TOk, TErr, UErr, UOk>([In] this HHANDHIMCMH<TOk, TErr> ELMHNMGFNPC, [Out][NotNullWhen(true)] TOk KOKMBFFIMLP, [Out] HHANDHIMCMH<UOk, UErr> PKNJBPICNDE) where TErr : UErr?
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x2BBAFB0", Offset = "0x2BB95B0", VA = "0x182BBAFB0")]
	public static bool GMMKLMJBIPE<TOk, TErr>([In] this HHANDHIMCMH<TOk, TErr> ELMHNMGFNPC, [Out][NotNullWhen(true)] TOk KOKMBFFIMLP, [Out] HHANDHIMCMH<DHABIOOJNOJ, TErr> PKNJBPICNDE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x2BBD420", Offset = "0x2BBBA20", VA = "0x182BBD420")]
	public static HHANDHIMCMH<UOk, UErr> OCDPGFKBEHJ<UOk, UErr, TOk, TErr>([In] this HHANDHIMCMH<TOk, TErr> ELMHNMGFNPC, [In] HHANDHIMCMH<UOk, UErr> CEBMDGFHLLP) where TOk : UOk where TErr : UErr
	{
		return default(HHANDHIMCMH<UOk, UErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x2BBDBA0", Offset = "0x2BBC1A0", VA = "0x182BBDBA0")]
	public static HHANDHIMCMH<TOk?[]?, TErr?> POIHGMAHABA<TOk, TErr>(this IEnumerable<HHANDHIMCMH<TOk, TErr>> ELMHNMGFNPC)
	{
		return default(HHANDHIMCMH<TOk[], TErr>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public static class NADBJPDMDJC<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x2BE9500", Offset = "0x2BE7B00", VA = "0x182BE9500")]
	public static HHANDHIMCMH<TOk, T> CPPFBKBPLGG<TOk>([In] TOk KOKMBFFIMLP) where TOk : notnull
	{
		return default(HHANDHIMCMH<TOk, T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x4568220", Offset = "0x4566820", VA = "0x184568220")]
	public static HHANDHIMCMH<DHABIOOJNOJ, T> CPPFBKBPLGG()
	{
		return default(HHANDHIMCMH<DHABIOOJNOJ, T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x2BE9500", Offset = "0x2BE7B00", VA = "0x182BE9500")]
	public static HHANDHIMCMH<T, TErr> FFEAAHJJNFC<TErr>([In] TErr JHFPKIAMKPI) where TErr : notnull
	{
		return default(HHANDHIMCMH<T, TErr>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public readonly struct NIGENNDBOFP<TKey, TValue> where TKey : notnull where TValue : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private readonly FAJOGJPGMCJ IOPKLMNEFEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private readonly Dictionary<TKey, TValue> AJMJPNNFKLO;

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x450C7A0", Offset = "0x450ADA0", VA = "0x18450C7A0")]
	public static NIGENNDBOFP<TKey, TValue> NKOJKFHACJH(string MGIHCPMKPNG)
	{
		return default(NIGENNDBOFP<TKey, TValue>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x450C8D0", Offset = "0x450AED0", VA = "0x18450C8D0")]
	internal NIGENNDBOFP(Dictionary<TKey, TValue> FEBGGALLBNN, FAJOGJPGMCJ ECKLLHFMEGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x450C6F0", Offset = "0x450ACF0", VA = "0x18450C6F0")]
	public IJOGKGDODML<TKey, TValue> DLFKMEEGPPB([Out] Dictionary<TKey, TValue> FEBGGALLBNN)
	{
		return default(IJOGKGDODML<TKey, TValue>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public readonly struct IJOGKGDODML<TKey, TValue> : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private readonly Dictionary<TKey, TValue> AJMJPNNFKLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private readonly JODOCINPKJG OKJAMBCDMMO;

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x2192FE0", Offset = "0x21915E0", VA = "0x182192FE0")]
	internal IJOGKGDODML(Dictionary<TKey, TValue> FEBGGALLBNN, JODOCINPKJG EBLEOKHEIFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x3E007E0", Offset = "0x3DFEDE0", VA = "0x183E007E0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public readonly struct DFMALICFLEG<T> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private readonly FAJOGJPGMCJ IOPKLMNEFEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private readonly HashSet<T> AJMJPNNFKLO;

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x450C7A0", Offset = "0x450ADA0", VA = "0x18450C7A0")]
	public static DFMALICFLEG<T> NKOJKFHACJH(string MGIHCPMKPNG)
	{
		return default(DFMALICFLEG<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x450C8D0", Offset = "0x450AED0", VA = "0x18450C8D0")]
	internal DFMALICFLEG(HashSet<T> FEBGGALLBNN, FAJOGJPGMCJ ECKLLHFMEGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x450C6F0", Offset = "0x450ACF0", VA = "0x18450C6F0")]
	public OMPBPBDJLNL<T> DLFKMEEGPPB([Out] HashSet<T> FEBGGALLBNN)
	{
		return default(OMPBPBDJLNL<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public readonly struct OMPBPBDJLNL<T> : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly HashSet<T> AJMJPNNFKLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private readonly JODOCINPKJG OKJAMBCDMMO;

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x2192FE0", Offset = "0x21915E0", VA = "0x182192FE0")]
	internal OMPBPBDJLNL(HashSet<T> FEBGGALLBNN, JODOCINPKJG EBLEOKHEIFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x3E007E0", Offset = "0x3DFEDE0", VA = "0x183E007E0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public readonly struct MNDBANIBLOK<T> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private readonly FAJOGJPGMCJ IOPKLMNEFEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private readonly Stack<T> AJMJPNNFKLO;

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x450C7A0", Offset = "0x450ADA0", VA = "0x18450C7A0")]
	public static MNDBANIBLOK<T> NKOJKFHACJH(string MGIHCPMKPNG)
	{
		return default(MNDBANIBLOK<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x450C8D0", Offset = "0x450AED0", VA = "0x18450C8D0")]
	internal MNDBANIBLOK(Stack<T> FEBGGALLBNN, FAJOGJPGMCJ ECKLLHFMEGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x450C6F0", Offset = "0x450ACF0", VA = "0x18450C6F0")]
	public ICNNCFNFAIG<T> DLFKMEEGPPB([Out] Stack<T> FEBGGALLBNN)
	{
		return default(ICNNCFNFAIG<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public readonly struct ICNNCFNFAIG<T> : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private readonly Stack<T> AJMJPNNFKLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private readonly JODOCINPKJG OKJAMBCDMMO;

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x2192FE0", Offset = "0x21915E0", VA = "0x182192FE0")]
	internal ICNNCFNFAIG(Stack<T> FEBGGALLBNN, JODOCINPKJG EBLEOKHEIFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x3E007E0", Offset = "0x3DFEDE0", VA = "0x183E007E0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
[DefaultMember("Item")]
public sealed class CEGNEIKFOOD<T> : IEnumerable<T>, IEnumerable where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	private readonly struct PEEPPFLPEKI : IEnumerable<T>, IEnumerable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private readonly CEGNEIKFOOD<T> FBBOLOGCAEG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private readonly int NPOFLMEFHDG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private readonly bool MEJPCMFFBAN;

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x1ECE9E0", Offset = "0x1ECCFE0", VA = "0x181ECE9E0")]
		public PEEPPFLPEKI(CEGNEIKFOOD<T> ADLOKNICHMI, int AMAGIJPKNEA, bool OOMPJDOAFCB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x480CBB0", Offset = "0x480B1B0", VA = "0x18480CBB0")]
		public CEGNEIKFOOD<T>.HFNIDMHNPLB CPHKKMADKBM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x480CCB0", Offset = "0x480B2B0", VA = "0x18480CCB0", Slot = "5")]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x480CCB0", Offset = "0x480B2B0", VA = "0x18480CCB0", Slot = "4")]
		IEnumerator<T> IEnumerable<T>.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000033")]
	public sealed class HFNIDMHNPLB : IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private readonly CEGNEIKFOOD<T> FBBOLOGCAEG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private readonly int FOPPNAPHGGN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private int BIJNAGBOKBO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		private readonly bool MEJPCMFFBAN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private bool HJPCOAKIEBO;

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public T LAAEJDPDOMN
		{
			[Cpp2IlInjected.Token(Token = "0x60000D7")]
			[Cpp2IlInjected.Address(RVA = "0x3D3C690", Offset = "0x3D3AC90", VA = "0x183D3C690")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		T IEnumerator<T>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000D8")]
			[Cpp2IlInjected.Address(RVA = "0x3D3C8D0", Offset = "0x3D3AED0", VA = "0x183D3C8D0", Slot = "4")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		object? IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000D9")]
			[Cpp2IlInjected.Address(RVA = "0x3D3CBB0", Offset = "0x3D3B1B0", VA = "0x183D3CBB0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x3D3CC60", Offset = "0x3D3B260", VA = "0x183D3CC60")]
		public HFNIDMHNPLB(CEGNEIKFOOD<T> ADLOKNICHMI, int AMAGIJPKNEA, bool OOMPJDOAFCB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x3D3C710", Offset = "0x3D3AD10", VA = "0x183D3C710", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x3D3C7B0", Offset = "0x3D3ADB0", VA = "0x183D3C7B0", Slot = "8")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x85E9E0", Offset = "0x85CFE0", VA = "0x18085E9E0", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000034")]
	[CompilerGenerated]
	private sealed class NALFMNMGIHI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public Func<T> makeDefault;

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x8692F0", Offset = "0x8678F0", VA = "0x1808692F0")]
		public NALFMNMGIHI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x4569050", Offset = "0x4567650", VA = "0x184569050")]
		internal T JIKBKHJFEJJ(int _)
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private readonly T[] LNHCGNKOFIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private int BIJNAGBOKBO;

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public int AKBHLNKDFOJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x4FC22D0", Offset = "0x4FC08D0", VA = "0x184FC22D0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public T LAAEJDPDOMN
	{
		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x3B6F7C0", Offset = "0x3B6DDC0", VA = "0x183B6F7C0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public T PKGJKBJFPHI
	{
		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x4FC25C0", Offset = "0x4FC0BC0", VA = "0x184FC25C0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public T ECHCHHAAKAL
	{
		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x4FC23A0", Offset = "0x4FC09A0", VA = "0x184FC23A0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public int BANKGEHECOP
	{
		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x1A17360", Offset = "0x1A15960", VA = "0x181A17360")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x1238180", Offset = "0x1236780", VA = "0x181238180")]
	private static int JGBKBKKICGD(int EBDMAJMOJLN, int KDDFOIMAIHK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x4FC27D0", Offset = "0x4FC0DD0", VA = "0x184FC27D0")]
	public CEGNEIKFOOD(int PPOFLGDKIBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x4FC2600", Offset = "0x4FC0C00", VA = "0x184FC2600")]
	public CEGNEIKFOOD(int PPOFLGDKIBE, Func<T> EIOJNCEMLFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x4FC2B80", Offset = "0x4FC1180", VA = "0x184FC2B80")]
	public CEGNEIKFOOD(T[] HBAHAFEIFCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x4FC22A0", Offset = "0x4FC08A0", VA = "0x184FC22A0")]
	public void EIAEIDEKEDO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x4FC24F0", Offset = "0x4FC0AF0", VA = "0x184FC24F0")]
	public IEnumerable<T> NOMDHCDFJCP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x4FC2200", Offset = "0x4FC0800", VA = "0x184FC2200")]
	public CEGNEIKFOOD<T>.HFNIDMHNPLB CPHKKMADKBM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x3C4D780", Offset = "0x3C4BD80", VA = "0x183C4D780", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x3C4D780", Offset = "0x3C4BD80", VA = "0x183C4D780", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public static class PBNNEEHEJBC
{
	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x2D0A120", Offset = "0x2D08720", VA = "0x182D0A120")]
	public static CEGNEIKFOOD<T> NKOJKFHACJH<T>(int PPOFLGDKIBE, Func<T> EIOJNCEMLFL) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public sealed class CBHPPGADJML<T> : IDisposable where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	public readonly struct NPOEPOLLKBO : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private readonly CBHPPGADJML<T> JJMIFPAKOCI;

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public T MDPJKNKDANF
		{
			[Cpp2IlInjected.Token(Token = "0x60000E6")]
			[Cpp2IlInjected.Address(RVA = "0x46029A0", Offset = "0x4600FA0", VA = "0x1846029A0")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x4602970", Offset = "0x4600F70", VA = "0x184602970", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0xA150A0", Offset = "0xA136A0", VA = "0x180A150A0")]
		public NPOEPOLLKBO(CBHPPGADJML<T> JJMIFPAKOCI)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	[CompilerGenerated]
	private struct GOIGHHDKMJH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public AsyncTaskMethodBuilder<NPOEPOLLKBO> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public CBHPPGADJML<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x3CF1BB0", Offset = "0x3CF01B0", VA = "0x183CF1BB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x3CF2570", Offset = "0x3CF0B70", VA = "0x183CF2570", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	private readonly SemaphoreSlim JMFGICCCEGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	private T PNLPKKJIAIJ;

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x4FC0060", Offset = "0x4FBE660", VA = "0x184FC0060")]
	public CBHPPGADJML([In] T PNLPKKJIAIJ, int ILBKCKEABAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x4FBFE30", Offset = "0x4FBE430", VA = "0x184FBFE30")]
	public CBHPPGADJML([In] T PNLPKKJIAIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x4FBFDD0", Offset = "0x4FBE3D0", VA = "0x184FBFDD0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x4FBFD90", Offset = "0x4FBE390", VA = "0x184FBFD90")]
	public NPOEPOLLKBO DNPNFMKGJCO()
	{
		return default(NPOEPOLLKBO);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x4FBFC60", Offset = "0x4FBE260", VA = "0x184FBFC60")]
	[AsyncStateMachine(typeof(CBHPPGADJML<>.GOIGHHDKMJH))]
	public Task<CBHPPGADJML<T>.NPOEPOLLKBO> APGDBIMGDHH(CancellationToken NNGMAHIDECE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x4FBFE10", Offset = "0x4FBE410", VA = "0x184FBFE10")]
	public void PMKGPHJLGJP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public static class MHEMBAJLGLO
{
	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x6A864B0", Offset = "0x6A84AB0", VA = "0x186A864B0")]
	public static CBHPPGADJML<DHABIOOJNOJ> NKOJKFHACJH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x2973880", Offset = "0x2971E80", VA = "0x182973880")]
	public static CBHPPGADJML<T> NKOJKFHACJH<T>([In] T PNLPKKJIAIJ) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public sealed class HOFDADDBLJF<T> : IDisposable where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	public readonly struct HJEMANHHKLC : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		private readonly HOFDADDBLJF<T> PAEPEKNDPIM;

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public T MDPJKNKDANF
		{
			[Cpp2IlInjected.Token(Token = "0x60000F2")]
			[Cpp2IlInjected.Address(RVA = "0x3D49EB0", Offset = "0x3D484B0", VA = "0x183D49EB0")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x3D49B50", Offset = "0x3D48150", VA = "0x183D49B50", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0xA150A0", Offset = "0xA136A0", VA = "0x180A150A0")]
		internal HJEMANHHKLC(HOFDADDBLJF<T> JJMIFPAKOCI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003C")]
	public readonly struct MHDAHPHFHFG : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		private readonly HOFDADDBLJF<T> PAEPEKNDPIM;

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public T MDPJKNKDANF
		{
			[Cpp2IlInjected.Token(Token = "0x60000F5")]
			[Cpp2IlInjected.Address(RVA = "0x3D49EB0", Offset = "0x3D484B0", VA = "0x183D49EB0")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x44F7870", Offset = "0x44F5E70", VA = "0x1844F7870", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0xA150A0", Offset = "0xA136A0", VA = "0x180A150A0")]
		internal MHDAHPHFHFG(HOFDADDBLJF<T> JJMIFPAKOCI)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	[CompilerGenerated]
	private struct LDIPBDECMEE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public AsyncTaskMethodBuilder<MHDAHPHFHFG> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public HOFDADDBLJF<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		private CBHPPGADJML<DHABIOOJNOJ>.NPOEPOLLKBO <writeLock>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		private TaskAwaiter<CBHPPGADJML<DHABIOOJNOJ>.NPOEPOLLKBO> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x429AD70", Offset = "0x4299370", VA = "0x18429AD70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x3CF2570", Offset = "0x3CF0B70", VA = "0x183CF2570", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	private readonly CBHPPGADJML<int> ABFNLPIPFDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	private readonly CBHPPGADJML<DHABIOOJNOJ> FMNGCEFHOEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private readonly CBHPPGADJML<DHABIOOJNOJ> LACKECMHMFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	private T JFGILOINJHC;

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x3D50D10", Offset = "0x3D4F310", VA = "0x183D50D10")]
	internal HOFDADDBLJF(CBHPPGADJML<int> MOPEDOOMJDP, CBHPPGADJML<DHABIOOJNOJ> LFHELLDCEOG, CBHPPGADJML<DHABIOOJNOJ> CAPNAHCEIMG, [In] T PNLPKKJIAIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x3D50060", Offset = "0x3D4E660", VA = "0x183D50060", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x3D50900", Offset = "0x3D4EF00", VA = "0x183D50900")]
	public HJEMANHHKLC OBHAHCLECJI()
	{
		return default(HJEMANHHKLC);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x3D501D0", Offset = "0x3D4E7D0", VA = "0x183D501D0")]
	public MHDAHPHFHFG HLFLKFIELLH()
	{
		return default(MHDAHPHFHFG);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x3D503B0", Offset = "0x3D4E9B0", VA = "0x183D503B0")]
	[AsyncStateMachine(typeof(HOFDADDBLJF<>.LDIPBDECMEE))]
	public Task<HOFDADDBLJF<T>.MHDAHPHFHFG> NHDNPNAPOIN(CancellationToken NNGMAHIDECE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public static class EJBBCCLEMGE
{
	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x6A84EF0", Offset = "0x6A834F0", VA = "0x186A84EF0")]
	public static HOFDADDBLJF<DHABIOOJNOJ> NKOJKFHACJH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x29F6540", Offset = "0x29F4B40", VA = "0x1829F6540")]
	public static HOFDADDBLJF<T> NKOJKFHACJH<T>([In] T PNLPKKJIAIJ) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public sealed class HPDPDFMMHHG<TData> : EKHHLAEJNGE where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public readonly string BILHBHGOAAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public readonly TData LFHGEGNPGJE;

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x85F4F0", Offset = "0x85DAF0", VA = "0x18085F4F0", Slot = "7")]
	public override string DLMCGACMBKO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x3D576A0", Offset = "0x3D55CA0", VA = "0x183D576A0")]
	internal HPDPDFMMHHG(string DICMABMCPKO, [In] TData JHLEMCFOEMF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public static class KGEJMKMDMCJ
{
	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x6A86260", Offset = "0x6A84860", VA = "0x186A86260")]
	public static HPDPDFMMHHG<DHABIOOJNOJ> NKOJKFHACJH(string DICMABMCPKO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x2972330", Offset = "0x2970930", VA = "0x182972330")]
	public static HPDPDFMMHHG<TData> NKOJKFHACJH<TData>(string DICMABMCPKO, [In] TData JHLEMCFOEMF) where TData : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public sealed class FAJOGJPGMCJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	internal bool CDGFGBDIEEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private readonly string EJBEEEFPPCB;

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x117E8D0", Offset = "0x117CED0", VA = "0x18117E8D0")]
	private FAJOGJPGMCJ(bool BKOPPHPKOBE, string IKGMIGLNMHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x6A85CB0", Offset = "0x6A842B0", VA = "0x186A85CB0")]
	public static FAJOGJPGMCJ NKOJKFHACJH(string IKGMIGLNMHI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x6A85BF0", Offset = "0x6A841F0", VA = "0x186A85BF0")]
	public JODOCINPKJG DLFKMEEGPPB()
	{
		return default(JODOCINPKJG);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public readonly struct JODOCINPKJG : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private readonly FAJOGJPGMCJ PAEEKJNMDGM;

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0xA150A0", Offset = "0xA136A0", VA = "0x180A150A0")]
	internal JODOCINPKJG(FAJOGJPGMCJ MGIHCPMKPNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x6A86240", Offset = "0x6A84840", VA = "0x186A86240", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public class INLBENEIBKJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private readonly Dictionary<object, float> LPGLBEOCAPG;

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public float HOOODHBILAG
	{
		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x9A4C70", Offset = "0x9A3270", VA = "0x1809A4C70")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0xFA4540", Offset = "0xFA2B40", VA = "0x180FA4540")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x6A86140", Offset = "0x6A84740", VA = "0x186A86140")]
	public void OGECAKANLGB(float FEBGGALLBNN, object PNPIGCGKNPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x6A85F50", Offset = "0x6A84550", VA = "0x186A85F50")]
	public void GDEOFMCKIAN(object PNPIGCGKNPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x6A85FC0", Offset = "0x6A845C0", VA = "0x186A85FC0")]
	public void KFLPEIEEDCE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x6A86010", Offset = "0x6A84610", VA = "0x186A86010")]
	private void MEELIHLFNHN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x6A861B0", Offset = "0x6A847B0", VA = "0x186A861B0")]
	public INLBENEIBKJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public sealed class FMGPOMIMEIJ<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	[CompilerGenerated]
	private sealed class MHLHPMJDPDN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public StringBuilder sb;

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x8692F0", Offset = "0x8678F0", VA = "0x1808692F0")]
		public MHLHPMJDPDN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x44FE530", Offset = "0x44FCB30", VA = "0x1844FE530")]
		internal int JPEKAOLPJPC(int i, T token)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private HashSet<T>? BPJHOHJPCPA;

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public IReadOnlyCollection<T> NBJPIBEDHFC
	{
		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x3C01560", Offset = "0x3BFFB60", VA = "0x183C01560")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public bool LLDNMPNLNAJ
	{
		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x3C01510", Offset = "0x3BFFB10", VA = "0x183C01510")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public int NCPJPJDHEHD
	{
		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x861EB0", Offset = "0x8604B0", VA = "0x180861EB0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x869B50", Offset = "0x868150", VA = "0x180869B50")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x3C01330", Offset = "0x3BFF930", VA = "0x183C01330")]
	public bool AGMNBECNIJC(T PNPIGCGKNPI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x3C016E0", Offset = "0x3BFFCE0", VA = "0x183C016E0")]
	public bool PJEMHMBEIPM(T PNPIGCGKNPI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x3C015A0", Offset = "0x3BFFBA0", VA = "0x183C015A0")]
	public bool GJJPBLIIILJ(T PNPIGCGKNPI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x3C015F0", Offset = "0x3BFFBF0", VA = "0x183C015F0")]
	public void JBPBOLKPOMG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x3C01860", Offset = "0x3BFFE60", VA = "0x183C01860", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x8692F0", Offset = "0x8678F0", VA = "0x1808692F0")]
	public FMGPOMIMEIJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public class MAOIFBOIJHO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private readonly string IPHEMJCMPMN;

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x8682B0", Offset = "0x8668B0", VA = "0x1808682B0")]
	public MAOIFBOIJHO(string IPHEMJCMPMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x6A86380", Offset = "0x6A84980", VA = "0x186A86380", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public sealed class PFNCBEJNFIN
{
	[Cpp2IlInjected.Token(Token = "0x2000048")]
	[CompilerGenerated]
	private sealed class ENKNPFIOGIP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public StringBuilder sb;

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x8692F0", Offset = "0x8678F0", VA = "0x1808692F0")]
		public ENKNPFIOGIP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x6A85B40", Offset = "0x6A84140", VA = "0x186A85B40")]
		internal int JPEKAOLPJPC(int i, object token)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private HashSet<object>? BPJHOHJPCPA;

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public IReadOnlyCollection<object> NBJPIBEDHFC
	{
		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x6A87310", Offset = "0x6A85910", VA = "0x186A87310")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public bool LLDNMPNLNAJ
	{
		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x6A87300", Offset = "0x6A85900", VA = "0x186A87300")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public int NCPJPJDHEHD
	{
		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x861EB0", Offset = "0x8604B0", VA = "0x180861EB0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x869B50", Offset = "0x868150", VA = "0x180869B50")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x6A87220", Offset = "0x6A85820", VA = "0x186A87220")]
	public bool AGMNBECNIJC(object PNPIGCGKNPI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x6A87470", Offset = "0x6A85A70", VA = "0x186A87470")]
	public bool PJEMHMBEIPM(object PNPIGCGKNPI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x6A873A0", Offset = "0x6A859A0", VA = "0x186A873A0")]
	public bool GJJPBLIIILJ(object PNPIGCGKNPI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x6A87400", Offset = "0x6A85A00", VA = "0x186A87400")]
	public void JBPBOLKPOMG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x6A87510", Offset = "0x6A85B10", VA = "0x186A87510", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x8692F0", Offset = "0x8678F0", VA = "0x1808692F0")]
	public PFNCBEJNFIN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public class OLEKGJHHEJD<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x200004A")]
	private struct HMNFBMFKBCG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public float CPBLIPMHMEN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public T MDPJKNKDANF;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private readonly Dictionary<object, HMNFBMFKBCG> LPGLBEOCAPG;

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public virtual T GDGEALNCJFP
	{
		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x1164580", Offset = "0x1162B80", VA = "0x181164580", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x1163B60", Offset = "0x1162160", VA = "0x181163B60", Slot = "5")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public object? AKPPLOLFBAH
	{
		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x860D00", Offset = "0x85F300", VA = "0x180860D00")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x860D10", Offset = "0x85F310", VA = "0x180860D10")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public bool IFHHIAJABFM
	{
		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x472D050", Offset = "0x472B650", VA = "0x18472D050")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x472EEF0", Offset = "0x472D4F0", VA = "0x18472EEF0")]
	public bool OGECAKANLGB(T FEBGGALLBNN, object PNPIGCGKNPI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x4568AD0", Offset = "0x45670D0", VA = "0x184568AD0")]
	public bool GDEOFMCKIAN(object PNPIGCGKNPI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x42BB5A0", Offset = "0x42B9BA0", VA = "0x1842BB5A0")]
	public void KFLPEIEEDCE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x472D140", Offset = "0x472B740", VA = "0x18472D140")]
	public bool NCAHNJJKPNF(object PNPIGCGKNPI, [Out] T FEBGGALLBNN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x472E560", Offset = "0x472CB60", VA = "0x18472E560")]
	[JOGPDABBCMG("T can be T?, `default!` shouldn't be necessary in C# 9")]
	private bool OFMJOCAKMAO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x4568F40", Offset = "0x4567540", VA = "0x184568F40")]
	public OLEKGJHHEJD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
public sealed class NAMFEGOLNAG<T> where T : class
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private List<WeakReference<T>>? BPJHOHJPCPA;

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public bool LLDNMPNLNAJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x45693D0", Offset = "0x45679D0", VA = "0x1845693D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public int NCPJPJDHEHD
	{
		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x4569500", Offset = "0x4567B00", VA = "0x184569500")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x4569140", Offset = "0x4567740", VA = "0x184569140")]
	public void AGMNBECNIJC(T PNPIGCGKNPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x4569700", Offset = "0x4567D00", VA = "0x184569700")]
	public void PJEMHMBEIPM(T PNPIGCGKNPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x45696B0", Offset = "0x4567CB0", VA = "0x1845696B0")]
	public void JBPBOLKPOMG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x45698B0", Offset = "0x4567EB0", VA = "0x1845698B0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x8692F0", Offset = "0x8678F0", VA = "0x1808692F0")]
	public NAMFEGOLNAG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
internal static class LAAHCDAALNC
{
	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x2B67B10", Offset = "0x2B66110", VA = "0x182B67B10")]
	public static void FBCKHABHFCF<T>(this List<T> MNNCEMFBNNK, int EBDMAJMOJLN) where T : notnull
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public interface GONGLEACLPC
{
	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event LPKLEONEBEN DAHNPFPABDP;
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public class ACFLDMOCEIL : GONGLEACLPC, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200004F")]
	public readonly struct NJGOPODJBJI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		public readonly float MNIJFILABEH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		public readonly float FPPJAIDLFLK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		internal readonly bool NEEAOKHHHDA;

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public float BONHNBEOKPE
		{
			[Cpp2IlInjected.Token(Token = "0x6000141")]
			[Cpp2IlInjected.Address(RVA = "0x6A86580", Offset = "0x6A84B80", VA = "0x186A86580")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x6A866F0", Offset = "0x6A84CF0", VA = "0x186A866F0")]
		public NJGOPODJBJI(float KKKICJLJANF, float MDHDJKJDJJA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x6A86590", Offset = "0x6A84B90", VA = "0x186A86590", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000050")]
	[CompilerGenerated]
	private sealed class PAEAEKAMGLM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		public ACFLDMOCEIL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		public int newProgressableIndex;

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x8692F0", Offset = "0x8678F0", VA = "0x1808692F0")]
		public PAEAEKAMGLM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x6A87180", Offset = "0x6A85780", VA = "0x186A87180")]
		internal void ENNGHKHFEBE(float innerProgress)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private readonly int HDGFIGFBKEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private int AADHGKCBKFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private readonly GONGLEACLPC[] MGIHAHMOJNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private readonly LPKLEONEBEN[] FGMBCEGOCBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private readonly NJGOPODJBJI[] DDGEIGHMCFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private NJGOPODJBJI NIOPLBFPMEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	private readonly ILHJBMNMDOK AKFMAOPLNIE;

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event LPKLEONEBEN DAHNPFPABDP
	{
		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x6A836C0", Offset = "0x6A81CC0", VA = "0x186A836C0", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x6A83600", Offset = "0x6A81C00", VA = "0x186A83600", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x6A83C80", Offset = "0x6A82280", VA = "0x186A83C80")]
	public ACFLDMOCEIL(int HDGFIGFBKEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x6A83780", Offset = "0x6A81D80", VA = "0x186A83780")]
	public ILHJBMNMDOK OIGMEOOJDKD(NJGOPODJBJI LBJFABAANBI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x6A83810", Offset = "0x6A81E10", VA = "0x186A83810")]
	public void PCHOMJGBKMP(GONGLEACLPC MBJKHDICKAG, [Optional] NJGOPODJBJI NBHMJKDMMCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x6A834F0", Offset = "0x6A81AF0", VA = "0x186A834F0", Slot = "6")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public delegate void LPKLEONEBEN(float BHBOBILKEHI);
[Cpp2IlInjected.Token(Token = "0x2000052")]
public static class PIHPGENFGLN
{
	[Cpp2IlInjected.Token(Token = "0x2000053")]
	private class MFJEHGNBJJH : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		private readonly GONGLEACLPC HOKJIEOGIEH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		private readonly LPKLEONEBEN MAPPKFKPMBJ;

		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x6A86420", Offset = "0x6A84A20", VA = "0x186A86420")]
		public MFJEHGNBJJH(GONGLEACLPC HOKJIEOGIEH, LPKLEONEBEN MAPPKFKPMBJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x6A863D0", Offset = "0x6A849D0", VA = "0x186A863D0", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x6A876C0", Offset = "0x6A85CC0", VA = "0x186A876C0")]
	internal static bool GHDHLALAOPK(float EJHDJMODPJO, float PNLANOPNMAC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x6A77370", Offset = "0x6A75970", VA = "0x186A77370")]
	internal static float HGCOOIGCPMJ(float EJHDJMODPJO)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x6A87730", Offset = "0x6A85D30", VA = "0x186A87730")]
	public static IDisposable NFMJEJBLPOP(this GONGLEACLPC HOKJIEOGIEH, LPKLEONEBEN MAPPKFKPMBJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
public class ILHJBMNMDOK : GONGLEACLPC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	private float BHBOBILKEHI;

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public float DNNOEEKFBMD
	{
		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x6A85E60", Offset = "0x6A84460", VA = "0x186A85E60")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public event LPKLEONEBEN? DAHNPFPABDP
	{
		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x6A85DC0", Offset = "0x6A843C0", VA = "0x186A85DC0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x6A85D20", Offset = "0x6A84320", VA = "0x186A85D20", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x8692F0", Offset = "0x8678F0", VA = "0x1808692F0")]
	public ILHJBMNMDOK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public interface GPBMHFCOOIF<T> where T : class, new()
{
	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(Slot = "0")]
	BGLCABCFECN<T> BCNBEMFJJAE([Out] T FEBGGALLBNN);

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void KFLPEIEEDCE();
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
public class IOHAEPIGGHP<T> : GPBMHFCOOIF<T> where T : class, new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	private readonly ConcurrentStack<T> BIGMIHNMPBO;

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x3E6FFE0", Offset = "0x3E6E5E0", VA = "0x183E6FFE0", Slot = "4")]
	public BGLCABCFECN<T> BCNBEMFJJAE([Out] T FEBGGALLBNN)
	{
		return default(BGLCABCFECN<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x3E70190", Offset = "0x3E6E790", VA = "0x183E70190")]
	public void OCKLLMDPOLJ(T PMIFLAGOBLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x3E70130", Offset = "0x3E6E730", VA = "0x183E70130", Slot = "5")]
	public void KFLPEIEEDCE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x85E9E0", Offset = "0x85CFE0", VA = "0x18085E9E0", Slot = "6")]
	protected virtual void OALOIFDLDGJ(T BGGHHJBGNMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x3E70080", Offset = "0x3E6E680", VA = "0x183E70080")]
	private T BJJBEHDKBAF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x3E70210", Offset = "0x3E6E810", VA = "0x183E70210")]
	public IOHAEPIGGHP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
public readonly struct BGLCABCFECN<T> : IDisposable where T : class, new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	private readonly T PMIFLAGOBLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	private readonly IOHAEPIGGHP<T> HFEKFICPOBG;

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0xB912D0", Offset = "0xB8F8D0", VA = "0x180B912D0")]
	internal BGLCABCFECN(T FEBGGALLBNN, IOHAEPIGGHP<T> HFEKFICPOBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x4F0FF40", Offset = "0x4F0E540", VA = "0x184F0FF40", Slot = "4")]
	void IDisposable.Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
public class BHIFAIOEBAO : IOHAEPIGGHP<StringBuilder>
{
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	public static readonly BHIFAIOEBAO HHHOBHGDEHO;

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x6A83E10", Offset = "0x6A82410", VA = "0x186A83E10")]
	public static BGLCABCFECN<StringBuilder> BJJBEHDKBAF([Out] StringBuilder FEBGGALLBNN)
	{
		return default(BGLCABCFECN<StringBuilder>);
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x6A83EB0", Offset = "0x6A824B0", VA = "0x186A83EB0", Slot = "6")]
	protected override void OALOIFDLDGJ(StringBuilder BGGHHJBGNMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x6A83F60", Offset = "0x6A82560", VA = "0x186A83F60")]
	public BHIFAIOEBAO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public class FEIHFOOMCAF : InvalidOperationException
{
	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x64F8010", Offset = "0x64F6610", VA = "0x1864F8010")]
	public FEIHFOOMCAF(string DICMABMCPKO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
[DefaultMember("Item")]
public class FBAEPIOEHON<TKey, TValue> : DDBLKDJNAFA<TKey, TValue>, IDictionary<TKey, TValue>, ICollection<KeyValuePair<TKey, TValue>>, IEnumerable<KeyValuePair<TKey, TValue>>, IEnumerable, INDPNCGOIHO where TKey : notnull where TValue : notnull
{
	[Cpp2IlInjected.Token(Token = "0x200005B")]
	[CompilerGenerated]
	private sealed class OFBPBGCCGPO : IEnumerator<KeyValuePair<TKey, TValue>>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		private KeyValuePair<TKey, TValue> <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public FBAEPIOEHON<TKey, TValue> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		private IEnumerator<KeyValuePair<TKey, TValue>> <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		KeyValuePair<TKey, TValue> IEnumerator<KeyValuePair<TKey, TValue>>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000180")]
			[Cpp2IlInjected.Address(RVA = "0x1164580", Offset = "0x1162B80", VA = "0x181164580", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return default(KeyValuePair<TKey, TValue>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000182")]
			[Cpp2IlInjected.Address(RVA = "0x46D81D0", Offset = "0x46D67D0", VA = "0x1846D81D0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x864580", Offset = "0x862B80", VA = "0x180864580")]
		[DebuggerHidden]
		public OFBPBGCCGPO(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x3B2A9E0", Offset = "0x3B28FE0", VA = "0x183B2A9E0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x46D7C00", Offset = "0x46D6200", VA = "0x1846D7C00", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x46D8090", Offset = "0x46D6690", VA = "0x1846D8090")]
		private void OGHBNIPNCAM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x46D7260", Offset = "0x46D5860", VA = "0x1846D7260")]
		private void MKLBAOAGFDM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x46D8180", Offset = "0x46D6780", VA = "0x1846D8180", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	private readonly DDBLKDJNAFA<TKey, TValue> PODDGOHBLKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	private readonly IDictionary<TKey, TValue> OKGOFHADGHG;

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public int NCPJPJDHEHD
	{
		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x3B778E0", Offset = "0x3B75EE0", VA = "0x183B778E0", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public bool AJPOMKOKGAO
	{
		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x8A6190", Offset = "0x8A4790", VA = "0x1808A6190", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public TValue ECHCHHAAKAL
	{
		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x3B77AC0", Offset = "0x3B760C0", VA = "0x183B77AC0", Slot = "4")]
		get
		{
			return (TValue)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x3B77DB0", Offset = "0x3B763B0", VA = "0x183B77DB0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public ICollection<TKey> JLCPGPNHAMF
	{
		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x3B77B10", Offset = "0x3B76110", VA = "0x183B77B10", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public ICollection<TValue> AHHFPMECDNA
	{
		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x3B77C40", Offset = "0x3B76240", VA = "0x183B77C40", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x3B77740", Offset = "0x3B75D40", VA = "0x183B77740")]
	public FBAEPIOEHON(DDBLKDJNAFA<TKey, TValue> PODDGOHBLKE, [Optional] IDictionary<TKey, TValue>? OKGOFHADGHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x3B75590", Offset = "0x3B73B90", VA = "0x183B75590", Slot = "15")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x3B765B0", Offset = "0x3B74BB0", VA = "0x183B765B0")]
	public void IAONBBGIKAL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x3B74FD0", Offset = "0x3B735D0", VA = "0x183B74FD0", Slot = "9")]
	public void Add(TKey MNBFPOFIDHA, TValue FEBGGALLBNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x3B76800", Offset = "0x3B74E00", VA = "0x183B76800")]
	public void IDMBEBKMBMB(TKey MNBFPOFIDHA, TValue FEBGGALLBNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x3B75400", Offset = "0x3B73A00", VA = "0x183B75400")]
	public void BKAAHHOHIOE(TKey MNBFPOFIDHA, TValue FEBGGALLBNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x3B74B00", Offset = "0x3B73100", VA = "0x183B74B00")]
	public void AMKFNMDBIIJ(TKey MNBFPOFIDHA, TValue FEBGGALLBNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x3B76070", Offset = "0x3B74670", VA = "0x183B76070")]
	public void DOJDFAGOBIN(TKey MNBFPOFIDHA, TValue FEBGGALLBNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x3B76D70", Offset = "0x3B75370", VA = "0x183B76D70", Slot = "14")]
	void ICollection<KeyValuePair<TKey, TValue>>.Add(KeyValuePair<TKey, TValue> OKNDMMHNIOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x3B76DC0", Offset = "0x3B753C0", VA = "0x183B76DC0", Slot = "16")]
	bool ICollection<KeyValuePair<TKey, TValue>>.Contains(KeyValuePair<TKey, TValue> OKNDMMHNIOK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x3B77120", Offset = "0x3B75720", VA = "0x183B77120", Slot = "18")]
	bool ICollection<KeyValuePair<TKey, TValue>>.Remove(KeyValuePair<TKey, TValue> OKNDMMHNIOK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x3B756D0", Offset = "0x3B73CD0", VA = "0x183B756D0", Slot = "8")]
	public bool ContainsKey(TKey MNBFPOFIDHA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x3B76600", Offset = "0x3B74C00", VA = "0x183B76600")]
	public bool ICEAFNHNPPE(TKey MNBFPOFIDHA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x3B76990", Offset = "0x3B74F90", VA = "0x183B76990")]
	public bool KEDLBPHMCMG(TKey MNBFPOFIDHA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x3B76B80", Offset = "0x3B75180", VA = "0x183B76B80", Slot = "10")]
	public bool Remove(TKey MNBFPOFIDHA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x3B775A0", Offset = "0x3B75BA0", VA = "0x183B775A0", Slot = "11")]
	public bool TryGetValue(TKey MNBFPOFIDHA, [Out] TValue FEBGGALLBNN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x3B757A0", Offset = "0x3B73DA0", VA = "0x183B757A0", Slot = "17")]
	public void CopyTo(KeyValuePair<TKey, TValue>[] NMHOKLPDKBK, int IBKDGIHHMKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x3B77480", Offset = "0x3B75A80", VA = "0x183B77480", Slot = "20")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x3B76220", Offset = "0x3B74820", VA = "0x183B76220", Slot = "19")]
	[IteratorStateMachine(typeof(FBAEPIOEHON<, >.OFBPBGCCGPO))]
	public IEnumerator<KeyValuePair<TKey, TValue>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x3B75EE0", Offset = "0x3B744E0", VA = "0x183B75EE0", Slot = "21")]
	public bool DKINHKGFPPC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x3B764A0", Offset = "0x3B74AA0", VA = "0x183B764A0")]
	private TValue HPOINNIGEEL(TKey MNBFPOFIDHA)
	{
		return (TValue)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public interface INDPNCGOIHO
{
	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool DKINHKGFPPC();
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
public interface DDBLKDJNAFA<TKey, TVal> : IDictionary<TKey, TVal>, ICollection<KeyValuePair<TKey, TVal>>, IEnumerable<KeyValuePair<TKey, TVal>>, IEnumerable, INDPNCGOIHO
{
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
[DefaultMember("Item")]
public sealed class LKGLDJOEKJK<TKey, TVal> : DDBLKDJNAFA<TKey, TVal>, IDictionary<TKey, TVal>, ICollection<KeyValuePair<TKey, TVal>>, IEnumerable<KeyValuePair<TKey, TVal>>, IEnumerable, INDPNCGOIHO where TKey : notnull where TVal : notnull
{
	[Cpp2IlInjected.Token(Token = "0x200005F")]
	public delegate int AAPCCAPMMPH(TKey MNBFPOFIDHA, TVal FEBGGALLBNN);

	[Cpp2IlInjected.Token(Token = "0x2000060")]
	public delegate void FDCJCDHMCDD(TKey MNBFPOFIDHA, TVal FEBGGALLBNN, ADFIMBGMKOL HBKEEHODHEK);

	[Cpp2IlInjected.Token(Token = "0x2000061")]
	private class GFEGMDLDGLN
	{
		[Cpp2IlInjected.Token(Token = "0x17000040")]
		public TKey MFNGEPMCPEG
		{
			[Cpp2IlInjected.Token(Token = "0x60001AE")]
			[Cpp2IlInjected.Address(RVA = "0x9B1620", Offset = "0x9AFC20", VA = "0x1809B1620")]
			[CompilerGenerated]
			get
			{
				return (TKey)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		public TVal MDPJKNKDANF
		{
			[Cpp2IlInjected.Token(Token = "0x60001AF")]
			[Cpp2IlInjected.Address(RVA = "0x998B00", Offset = "0x997100", VA = "0x180998B00")]
			[CompilerGenerated]
			get
			{
				return (TVal)null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001B0")]
			[Cpp2IlInjected.Address(RVA = "0x998B10", Offset = "0x997110", VA = "0x180998B10")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		public int BONHNBEOKPE
		{
			[Cpp2IlInjected.Token(Token = "0x60001B1")]
			[Cpp2IlInjected.Address(RVA = "0x89D480", Offset = "0x89BA80", VA = "0x18089D480")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60001B2")]
			[Cpp2IlInjected.Address(RVA = "0x89CB70", Offset = "0x89B170", VA = "0x18089CB70")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000043")]
		public DateTimeOffset LCJOAOMEGKF
		{
			[Cpp2IlInjected.Token(Token = "0x60001B3")]
			[Cpp2IlInjected.Address(RVA = "0xD355B0", Offset = "0xD33BB0", VA = "0x180D355B0")]
			[CompilerGenerated]
			get
			{
				return default(DateTimeOffset);
			}
			[Cpp2IlInjected.Token(Token = "0x60001B4")]
			[Cpp2IlInjected.Address(RVA = "0x15E17A0", Offset = "0x15DFDA0", VA = "0x1815E17A0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x3CD4BD0", Offset = "0x3CD31D0", VA = "0x183CD4BD0")]
		public GFEGMDLDGLN(TKey MNBFPOFIDHA, TVal GAELHANIPAM)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000063")]
	[CompilerGenerated]
	private sealed class ODBMBJLDKAC : IEnumerator<KeyValuePair<TKey, TVal>>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		private KeyValuePair<TKey, TVal> <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		public LKGLDJOEKJK<TKey, TVal> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		private LinkedList<GFEGMDLDGLN>.Enumerator <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		KeyValuePair<TKey, TVal> IEnumerator<KeyValuePair<TKey, TVal>>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001BE")]
			[Cpp2IlInjected.Address(RVA = "0x1164580", Offset = "0x1162B80", VA = "0x181164580", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return default(KeyValuePair<TKey, TVal>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000045")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001C0")]
			[Cpp2IlInjected.Address(RVA = "0x3B2DCE0", Offset = "0x3B2C2E0", VA = "0x183B2DCE0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x864580", Offset = "0x862B80", VA = "0x180864580")]
		[DebuggerHidden]
		public ODBMBJLDKAC(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x39CF030", Offset = "0x39CD630", VA = "0x1839CF030", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x46D52D0", Offset = "0x46D38D0", VA = "0x1846D52D0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x46D5CC0", Offset = "0x46D42C0", VA = "0x1846D5CC0")]
		private void OGHBNIPNCAM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x46D60A0", Offset = "0x46D46A0", VA = "0x1846D60A0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000089")]
	public const int HOOFBEMMDMG = -1;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private readonly Dictionary<TKey, LinkedListNode<GFEGMDLDGLN>> OOGPOBCOLDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	private readonly LinkedList<GFEGMDLDGLN> NCAJDMOMBKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private readonly AAPCCAPMMPH? MJOMCCCNEEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private readonly TimeSpan HOGGDFNEONN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private readonly FDCJCDHMCDD? OCAMNNOHPOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private readonly ACOOALCGGNA EMBNKJFJLOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private bool AAPMBDGCLPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private readonly List<TKey> IDGNOJCAOGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private readonly List<TVal> CDANJCAMILG;

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public int HLDGGDLOPHI
	{
		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x86D300", Offset = "0x86B900", VA = "0x18086D300")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	internal int EJNKNAFFBCO
	{
		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0xBFEF50", Offset = "0xBFD550", VA = "0x180BFEF50")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0xBFEA40", Offset = "0xBFD040", VA = "0x180BFEA40")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public int NCPJPJDHEHD
	{
		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x42C1990", Offset = "0x42BFF90", VA = "0x1842C1990", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	internal int LLEIGHBCDNJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x42BB5A0", Offset = "0x42B9BA0", VA = "0x1842BB5A0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public ICollection<TVal> AHHFPMECDNA
	{
		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x42C1B00", Offset = "0x42C0100", VA = "0x1842C1B00", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	ICollection<TKey> IDictionary<TKey, TVal>.GJMLHFCPMIK
	{
		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x42C0180", Offset = "0x42BE780", VA = "0x1842C0180", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public bool AJPOMKOKGAO
	{
		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x8A6190", Offset = "0x8A4790", VA = "0x1808A6190", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public TVal ECHCHHAAKAL
	{
		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x42C1A30", Offset = "0x42C0030", VA = "0x1842C1A30", Slot = "4")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x42C1BB0", Offset = "0x42C01B0", VA = "0x1842C1BB0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000185")]
	[Cpp2IlInjected.Address(RVA = "0x42BC840", Offset = "0x42BAE40", VA = "0x1842BC840")]
	private bool DNEGGCLBHAL(int HDGFIGFBKEK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600018C")]
	[Cpp2IlInjected.Address(RVA = "0x42BF3A0", Offset = "0x42BD9A0", VA = "0x1842BF3A0")]
	private void PIJDHDAJGOI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018E")]
	[Cpp2IlInjected.Address(RVA = "0x42C0970", Offset = "0x42BEF70", VA = "0x1842C0970")]
	public LKGLDJOEKJK(int HDGFIGFBKEK, [Optional] AAPCCAPMMPH? MJOMCCCNEEE, [Optional] IEqualityComparer<TKey>? OPFBHDJCGDH, [Optional] FDCJCDHMCDD? OCAMNNOHPOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(RVA = "0x42C0870", Offset = "0x42BEE70", VA = "0x1842C0870")]
	public LKGLDJOEKJK(TimeSpan HOGGDFNEONN, [Optional] IEqualityComparer<TKey>? OPFBHDJCGDH, [Optional] FDCJCDHMCDD? OCAMNNOHPOA, [Optional] ACOOALCGGNA? EMBNKJFJLOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000190")]
	[Cpp2IlInjected.Address(RVA = "0x42C08F0", Offset = "0x42BEEF0", VA = "0x1842C08F0")]
	public LKGLDJOEKJK(int HDGFIGFBKEK, TimeSpan HOGGDFNEONN, [Optional] IEqualityComparer<TKey>? OPFBHDJCGDH, [Optional] FDCJCDHMCDD? OCAMNNOHPOA, [Optional] ACOOALCGGNA? EMBNKJFJLOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(RVA = "0x42C1090", Offset = "0x42BF690", VA = "0x1842C1090")]
	public LKGLDJOEKJK(int HDGFIGFBKEK, AAPCCAPMMPH? MJOMCCCNEEE, TimeSpan HOGGDFNEONN, [Optional] IEqualityComparer<TKey>? OPFBHDJCGDH, [Optional] FDCJCDHMCDD? OCAMNNOHPOA, [Optional] ACOOALCGGNA? EMBNKJFJLOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0x42BC790", Offset = "0x42BAD90", VA = "0x1842BC790", Slot = "21")]
	public bool DKINHKGFPPC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(RVA = "0x42BCDD0", Offset = "0x42BB3D0", VA = "0x1842BCDD0", Slot = "22")]
	public bool GKLPDMFEOOB(int PPOFLGDKIBE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000194")]
	[Cpp2IlInjected.Address(RVA = "0x42BE750", Offset = "0x42BCD50", VA = "0x1842BE750")]
	private bool OGJNLLCLDCH(int PPOFLGDKIBE, ADFIMBGMKOL HBKEEHODHEK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x42BCB30", Offset = "0x42BB130", VA = "0x1842BCB30")]
	public void FNIGGHLNDBN(TKey MNBFPOFIDHA, TVal FEBGGALLBNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(RVA = "0x42BAA40", Offset = "0x42B9040", VA = "0x1842BAA40", Slot = "14")]
	public void Add(KeyValuePair<TKey, TVal> OKNDMMHNIOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0x42BAAE0", Offset = "0x42B90E0", VA = "0x1842BAAE0", Slot = "9")]
	public void Add(TKey MNBFPOFIDHA, TVal FEBGGALLBNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(RVA = "0x42BBCC0", Offset = "0x42BA2C0", VA = "0x1842BBCC0", Slot = "8")]
	public bool ContainsKey(TKey MNBFPOFIDHA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(RVA = "0x42BFCF0", Offset = "0x42BE2F0", VA = "0x1842BFCF0", Slot = "16")]
	bool ICollection<KeyValuePair<TKey, TVal>>.Contains(KeyValuePair<TKey, TVal> OKNDMMHNIOK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(RVA = "0x42BF8A0", Offset = "0x42BDEA0", VA = "0x1842BF8A0", Slot = "10")]
	public bool Remove(TKey MNBFPOFIDHA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0x42C0030", Offset = "0x42BE630", VA = "0x1842C0030", Slot = "18")]
	bool ICollection<KeyValuePair<TKey, TVal>>.Remove(KeyValuePair<TKey, TVal> OKNDMMHNIOK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(RVA = "0x42BA060", Offset = "0x42B8660", VA = "0x1842BA060")]
	private bool ALFBGNPHAAN(TKey MNBFPOFIDHA, [Out] TVal FEBGGALLBNN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(RVA = "0x42BAF80", Offset = "0x42B9580", VA = "0x1842BAF80")]
	private TVal BJJBEHDKBAF(TKey FHLBFJLDNAL)
	{
		return (TVal)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A0")]
	[Cpp2IlInjected.Address(RVA = "0x42C0210", Offset = "0x42BE810", VA = "0x1842C0210", Slot = "11")]
	public bool TryGetValue(TKey FHLBFJLDNAL, [Out] TVal FEBGGALLBNN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A1")]
	[Cpp2IlInjected.Address(RVA = "0x42BBAB0", Offset = "0x42BA0B0", VA = "0x1842BBAB0", Slot = "15")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(RVA = "0x42BC0B0", Offset = "0x42BA6B0", VA = "0x1842BC0B0", Slot = "17")]
	public void CopyTo(KeyValuePair<TKey, TVal>[] NMHOKLPDKBK, int IBKDGIHHMKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x42BB1A0", Offset = "0x42B97A0", VA = "0x1842BB1A0")]
	private void CFFHCOJIFGA(TKey MNBFPOFIDHA, TVal GAELHANIPAM, ADFIMBGMKOL HBKEEHODHEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(RVA = "0x42BB600", Offset = "0x42B9C00", VA = "0x1842BB600")]
	private bool CLHEPDHGENO(GFEGMDLDGLN HNCNHGMLPCN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A5")]
	[Cpp2IlInjected.Address(RVA = "0x42B9AA0", Offset = "0x42B80A0", VA = "0x1842B9AA0")]
	private void AFBHEHJMGFB(LinkedListNode<GFEGMDLDGLN> BJGJAGABCJI, TVal GNGOIGDLMDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(RVA = "0x42BD9E0", Offset = "0x42BBFE0", VA = "0x1842BD9E0")]
	private void OGECAKANLGB(TKey MNBFPOFIDHA, TVal FEBGGALLBNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A7")]
	[Cpp2IlInjected.Address(RVA = "0x42BD200", Offset = "0x42BB800", VA = "0x1842BD200")]
	private void OFMNGFABGHI(GFEGMDLDGLN HNCNHGMLPCN, TVal GNGOIGDLMDJ, int OLPDBLKOEOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A8")]
	[Cpp2IlInjected.Address(RVA = "0x42BCE80", Offset = "0x42BB480", VA = "0x1842BCE80", Slot = "19")]
	[IteratorStateMachine(typeof(LKGLDJOEKJK<, >.ODBMBJLDKAC))]
	public IEnumerator<KeyValuePair<TKey, TVal>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A9")]
	[Cpp2IlInjected.Address(RVA = "0x42C01D0", Offset = "0x42BE7D0", VA = "0x1842C01D0", Slot = "20")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
public enum ADFIMBGMKOL : byte
{
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	Evicted,
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	RemovedViaRemove,
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	RemovedViaClear,
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	Overwritten
}
[Cpp2IlInjected.Token(Token = "0x2000065")]
public class HEPLDGNBIFN<TKey> : Exception where TKey : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	public readonly TKey MJOIHKGLHFF;

	[Cpp2IlInjected.Token(Token = "0x60001C1")]
	[Cpp2IlInjected.Address(RVA = "0x3D38DF0", Offset = "0x3D373F0", VA = "0x183D38DF0")]
	public HEPLDGNBIFN(TKey OABNCKHDHLI, Exception GKKDKGGMLEH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
public class HOACOEFKGCN : ArgumentException
{
	[Cpp2IlInjected.Token(Token = "0x60001C2")]
	[Cpp2IlInjected.Address(RVA = "0x5DD5A00", Offset = "0x5DD4000", VA = "0x185DD5A00")]
	public HOACOEFKGCN(string DICMABMCPKO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
public class LJONMJGPMEC<TId, TResource> : IEnumerable<(TId, Task<TResource>, int)>, IEnumerable where TId : notnull where TResource : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000068")]
	[CompilerGenerated]
	private sealed class NOPFAGBMNBJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		public Func<TId, CancellationToken, Task<TResource>> factory;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		public LJONMJGPMEC<TId, TResource> <>4__this;

		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x8692F0", Offset = "0x8678F0", VA = "0x1808692F0")]
		public NOPFAGBMNBJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0x45FF780", Offset = "0x45FDD80", VA = "0x1845FF780")]
		internal Task<TResource> LDEOCPMBBAC(TId _id)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000069")]
	[CompilerGenerated]
	private struct OHDFMHANNLL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		public Task<TResource> task;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		public LJONMJGPMEC<TId, TResource> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		private TaskAwaiter<TResource> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x46DA3D0", Offset = "0x46D89D0", VA = "0x1846DA3D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x46DAD30", Offset = "0x46D9330", VA = "0x1846DAD30", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200006A")]
	[CompilerGenerated]
	private struct FJODFIGKEIB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		public Task<TResource> task;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		public Dictionary<Task<TResource>, CancellationTokenSource> cancellationTokenSources;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		public CancellationTokenSource cts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		private TaskAwaiter<TResource> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0x3BB9420", Offset = "0x3BB7A20", VA = "0x183BB9420", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0x3BB9880", Offset = "0x3BB7E80", VA = "0x183BB9880", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	private readonly PLEMAOJFBHI<TId, Task<TResource>> JFFLIMJLFFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	private readonly Dictionary<Task<TResource>, CancellationTokenSource> GGNCMBBNACO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	private readonly Func<TId, CancellationToken, Task<TResource>>? DKOCKACEFIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	private readonly Action<TResource>? LPFKHNFLELN;

	[Cpp2IlInjected.Token(Token = "0x60001C3")]
	[Cpp2IlInjected.Address(RVA = "0x42B7230", Offset = "0x42B5830", VA = "0x1842B7230")]
	public LJONMJGPMEC(int HMGCDCANKDC = 0, [Optional] IEqualityComparer<TId>? OMPGBNEJEDF, [Optional] Func<TId, CancellationToken, Task<TResource>>? LBCIKNOEINF, [Optional] Action<TResource>? OHJFEKHIPEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C4")]
	[Cpp2IlInjected.Address(RVA = "0x42B6890", Offset = "0x42B4E90", VA = "0x1842B6890")]
	public OCANDJCDBAG<Task<TResource>> PAAJJJJMJPE(TId KAGKMEDPMHO, [Optional] Func<TId, CancellationToken, Task<TResource>>? LBCIKNOEINF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C5")]
	[Cpp2IlInjected.Address(RVA = "0x42B5B90", Offset = "0x42B4190", VA = "0x1842B5B90")]
	private void AHBMJEGDPFO(Task<TResource> OOOMFPPINLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C6")]
	[Cpp2IlInjected.Address(RVA = "0x42B6070", Offset = "0x42B4670", VA = "0x1842B6070")]
	[AsyncStateMachine(typeof(LJONMJGPMEC<, >.OHDFMHANNLL))]
	private Task DFLIGKCDINB(Task<TResource> OOOMFPPINLE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C7")]
	[Cpp2IlInjected.Address(RVA = "0x42B6370", Offset = "0x42B4970", VA = "0x1842B6370")]
	public void NDCMEIADGMG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C8")]
	[Cpp2IlInjected.Address(RVA = "0x42B5E70", Offset = "0x42B4470", VA = "0x1842B5E70")]
	public PLEMAOJFBHI<TId, Task<TResource>>.GIAAELBFJAE CPHKKMADKBM()
	{
		return default(PLEMAOJFBHI<TId, Task<TResource>>.GIAAELBFJAE);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C9")]
	[Cpp2IlInjected.Address(RVA = "0x42B7040", Offset = "0x42B5640", VA = "0x1842B7040", Slot = "4")]
	private IEnumerator<(TId, Task<TResource>, int)> System.Collections.Generic.IEnumerable<(TIdId,System.Threading.Tasks.Task<TResource>LoadResourceTask,System.Int32RefCount)>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(RVA = "0x42B7040", Offset = "0x42B5640", VA = "0x1842B7040", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x42B63D0", Offset = "0x42B49D0", VA = "0x1842B63D0")]
	[CompilerGenerated]
	[AsyncStateMachine(typeof(LJONMJGPMEC<, >.FJODFIGKEIB))]
	internal static Task OJHMODEPNAJ(Task<TResource> OOOMFPPINLE, CancellationTokenSource OKPKPFNKCEG, Dictionary<Task<TResource>, CancellationTokenSource> LLFFHJKEDGA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
public class PLEMAOJFBHI<TKey, TValue> : IEnumerable<(TKey, TValue, int)>, IEnumerable where TKey : notnull where TValue : notnull
{
	[Cpp2IlInjected.Token(Token = "0x200006C")]
	private sealed class MLJDNKPJFLO : IEquatable<MLJDNKPJFLO>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		public readonly TValue MDPJKNKDANF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		public int IFLFFDPCOKD;

		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(RVA = "0xA4F260", Offset = "0xA4D860", VA = "0x180A4F260")]
		public MLJDNKPJFLO(TValue FEBGGALLBNN, int DAJGEHCNILB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(RVA = "0x4507DC0", Offset = "0x45063C0", VA = "0x184507DC0", Slot = "4")]
		public bool Equals(MLJDNKPJFLO? OGEIJLCLBIC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0x4507E50", Offset = "0x4506450", VA = "0x184507E50", Slot = "0")]
		public override bool Equals(object? CDBNFNMIHPK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x4508020", Offset = "0x4506620", VA = "0x184508020", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006D")]
	public struct GIAAELBFJAE : IEnumerator<(TKey, TValue, int)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		private Dictionary<TKey, MLJDNKPJFLO>.Enumerator OLJEMKBMIKC;

		[Cpp2IlInjected.Token(Token = "0x17000046")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001E1")]
			[Cpp2IlInjected.Address(RVA = "0x3CD8DF0", Offset = "0x3CD73F0", VA = "0x183CD8DF0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000047")]
		public (TKey Key, TValue Value, int RefCount) LAAEJDPDOMN
		{
			[Cpp2IlInjected.Token(Token = "0x60001E2")]
			[Cpp2IlInjected.Address(RVA = "0x3CD91C0", Offset = "0x3CD77C0", VA = "0x183CD91C0", Slot = "4")]
			get
			{
				return default((TKey, TValue, int));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0x3CD8F40", Offset = "0x3CD7540", VA = "0x183CD8F40")]
		public GIAAELBFJAE(PLEMAOJFBHI<TKey, TValue> LPGLBEOCAPG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x3CD8990", Offset = "0x3CD6F90", VA = "0x183CD8990", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x3CD89D0", Offset = "0x3CD6FD0", VA = "0x183CD89D0", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x3CD8A90", Offset = "0x3CD7090", VA = "0x183CD8A90", Slot = "8")]
		public void Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006E")]
	[CompilerGenerated]
	private sealed class GGGMJGIHBDI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		public PLEMAOJFBHI<TKey, TValue> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		public TKey key;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		public MLJDNKPJFLO refCountedValue;

		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x8692F0", Offset = "0x8678F0", VA = "0x1808692F0")]
		public GGGMJGIHBDI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x3CD5C60", Offset = "0x3CD4260", VA = "0x183CD5C60")]
		internal void LDEOCPMBBAC()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	private readonly Dictionary<TKey, MLJDNKPJFLO> GAJCMDBIKLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	private readonly Func<TKey, TValue>? GOFIMNOFBHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	private readonly Action<TValue>? FJIOHHMADMN;

	[Cpp2IlInjected.Token(Token = "0x60001D2")]
	[Cpp2IlInjected.Address(RVA = "0x4821990", Offset = "0x481FF90", VA = "0x184821990")]
	public PLEMAOJFBHI(int HMGCDCANKDC = 0, [Optional] IEqualityComparer<TKey>? OPFBHDJCGDH, [Optional] Func<TKey, TValue>? LPFGOPJEBKO, [Optional] Action<TValue>? DGOCGKJIJDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D3")]
	[Cpp2IlInjected.Address(RVA = "0x4820E00", Offset = "0x481F400", VA = "0x184820E00")]
	public OCANDJCDBAG<TValue> PAAJJJJMJPE(TKey MNBFPOFIDHA, [Optional] Func<TKey, TValue>? FJEABHKCODN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D4")]
	[Cpp2IlInjected.Address(RVA = "0x4820700", Offset = "0x481ED00", VA = "0x184820700")]
	private void OCKLLMDPOLJ(TKey MNBFPOFIDHA, MLJDNKPJFLO COJNICJHMKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D5")]
	[Cpp2IlInjected.Address(RVA = "0x48204E0", Offset = "0x481EAE0", VA = "0x1848204E0")]
	public void NDCMEIADGMG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D6")]
	[Cpp2IlInjected.Address(RVA = "0x481FFD0", Offset = "0x481E5D0", VA = "0x18481FFD0")]
	public GIAAELBFJAE CPHKKMADKBM()
	{
		return default(GIAAELBFJAE);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(RVA = "0x48217A0", Offset = "0x481FDA0", VA = "0x1848217A0", Slot = "4")]
	private IEnumerator<(TKey, TValue, int)> System.Collections.Generic.IEnumerable<(TKeyKey,TValueValue,System.Int32RefCount)>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(RVA = "0x48217A0", Offset = "0x481FDA0", VA = "0x1848217A0", Slot = "5")]
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
