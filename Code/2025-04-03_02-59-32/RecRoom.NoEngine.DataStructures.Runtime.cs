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
		[Cpp2IlInjected.Address(RVA = "0x9BE830", Offset = "0x9BDC30", VA = "0x1809BE830")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[Microsoft.CodeAnalysis.Embedded]
	[CompilerGenerated]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter, AllowMultiple = false, Inherited = false)]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x79A2F80", Offset = "0x79A2380", VA = "0x1879A2F80")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x9BF4A0", Offset = "0x9BE8A0", VA = "0x1809BF4A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x9BF4E0", Offset = "0x9BE8E0", VA = "0x1809BF4E0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public abstract class IDHBJLFNPFK
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x9A2500", Offset = "0x9A1900", VA = "0x1809A2500")]
	protected IDHBJLFNPFK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public abstract class JOFKANMKADA<T> : IDHBJLFNPFK
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	protected struct IFKAIKKCHGA
	{
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		public enum HMKOLDAGCCF
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
		public HMKOLDAGCCF HAFNBBNOLPO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public T IOPCFKOHPBF;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private int AAALDLMOJBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly bool PMMHICPABLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	protected readonly bool IJDDHHGFLMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	protected List<T>? GJPACEOICPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private List<IFKAIKKCHGA>? MHFLIIJFFHK;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public bool MJIPOFJFHHP
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x4C6FDF0", Offset = "0x4C6F1F0", VA = "0x184C6FDF0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x4C70810", Offset = "0x4C6FC10", VA = "0x184C70810")]
	protected JOFKANMKADA(bool IJDDHHGFLMK, bool PMMHICPABLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x4C70770", Offset = "0x4C6FB70", VA = "0x184C70770")]
	protected bool PBFIJCPFKLF()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x4C70650", Offset = "0x4C6FA50", VA = "0x184C70650")]
	protected void OKKPDLLGNFD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x4C70000", Offset = "0x4C6F400", VA = "0x184C70000")]
	protected void IDCLBHDMBMO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x3BAAC40", Offset = "0x3BAA040", VA = "0x183BAAC40")]
	private static void KPLHIAAPOEI<U>(List<U>? CEFIHBLEFNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x4C70440", Offset = "0x4C6F840", VA = "0x184C70440", Slot = "4")]
	public void JJBKLNLGAIJ(T IOPCFKOHPBF, bool NBOBCBNKKKD = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x4C70270", Offset = "0x4C6F670", VA = "0x184C70270", Slot = "5")]
	public void JEBJOEBLLEI(T IOPCFKOHPBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x4C6FE50", Offset = "0x4C6F250", VA = "0x184C6FE50")]
	public void CJEMNCEDADJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public sealed class OPNNLJDPBAB : JOFKANMKADA<Action>
{
	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x79A3B70", Offset = "0x79A2F70", VA = "0x1879A3B70")]
	public OPNNLJDPBAB(bool IJDDHHGFLMK = false, bool PMMHICPABLF = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x79A38B0", Offset = "0x79A2CB0", VA = "0x1879A38B0")]
	public void HKANHPMMIAO()
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x79A3AB0", Offset = "0x79A2EB0", VA = "0x1879A3AB0")]
	public static OPNNLJDPBAB NEOOCHPFDCF(OPNNLJDPBAB LGGJKGFGJMC, Action IOPCFKOHPBF)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x79A3B10", Offset = "0x79A2F10", VA = "0x1879A3B10")]
	public static OPNNLJDPBAB PMIHMDGCMLK(OPNNLJDPBAB LGGJKGFGJMC, Action IOPCFKOHPBF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface CJNDCIPCLNI<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void JJBKLNLGAIJ(Action<T> IOPCFKOHPBF, bool NBOBCBNKKKD = false);

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void JEBJOEBLLEI(Action<T> IOPCFKOHPBF);
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public sealed class GLDBGNIANKN<T> : JOFKANMKADA<Action<T>>, CJNDCIPCLNI<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x42C3A80", Offset = "0x42C2E80", VA = "0x1842C3A80")]
	public GLDBGNIANKN(bool IJDDHHGFLMK = false, bool PMMHICPABLF = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x484E690", Offset = "0x484DA90", VA = "0x18484E690")]
	public void HKANHPMMIAO(T OOLNPDLPIEB)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x484F330", Offset = "0x484E730", VA = "0x18484F330")]
	public static GLDBGNIANKN<T> NEOOCHPFDCF(GLDBGNIANKN<T> LGGJKGFGJMC, Action<T> IOPCFKOHPBF)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x484F3D0", Offset = "0x484E7D0", VA = "0x18484F3D0")]
	public static GLDBGNIANKN<T> PMIHMDGCMLK(GLDBGNIANKN<T> LGGJKGFGJMC, Action<T> IOPCFKOHPBF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface FOFIHLCPBFF<T, U> where T : notnull where U : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void JJBKLNLGAIJ(Action<T, U> IOPCFKOHPBF, bool NBOBCBNKKKD = false);

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void JEBJOEBLLEI(Action<T, U> IOPCFKOHPBF);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public sealed class APHAPGEAMFF<T, U> : JOFKANMKADA<Action<T, U>>, FOFIHLCPBFF<T, U> where T : notnull where U : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x42C3A80", Offset = "0x42C2E80", VA = "0x1842C3A80")]
	public APHAPGEAMFF(bool IJDDHHGFLMK = false, bool PMMHICPABLF = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x4A24D90", Offset = "0x4A24190", VA = "0x184A24D90")]
	public void HKANHPMMIAO(T OOLNPDLPIEB, U OJOOOBBLFNO)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x484F330", Offset = "0x484E730", VA = "0x18484F330")]
	public static APHAPGEAMFF<T, U> NEOOCHPFDCF(APHAPGEAMFF<T, U> LGGJKGFGJMC, Action<T, U> IOPCFKOHPBF)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x484F3D0", Offset = "0x484E7D0", VA = "0x18484F3D0")]
	public static APHAPGEAMFF<T, U> PMIHMDGCMLK(APHAPGEAMFF<T, U> LGGJKGFGJMC, Action<T, U> IOPCFKOHPBF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public sealed class CJBDHFJKABF<T, U, V> : JOFKANMKADA<Action<T, U, V>> where T : notnull where U : notnull where V : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x42C3A80", Offset = "0x42C2E80", VA = "0x1842C3A80")]
	public CJBDHFJKABF(bool IJDDHHGFLMK = false, bool PMMHICPABLF = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x63FE190", Offset = "0x63FD590", VA = "0x1863FE190")]
	public void HKANHPMMIAO(T OOLNPDLPIEB, U OJOOOBBLFNO, V CHAOGBKCKEH)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x484F330", Offset = "0x484E730", VA = "0x18484F330")]
	public static CJBDHFJKABF<T, U, V> NEOOCHPFDCF(CJBDHFJKABF<T, U, V> LGGJKGFGJMC, Action<T, U, V> IOPCFKOHPBF)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x484F3D0", Offset = "0x484E7D0", VA = "0x18484F3D0")]
	public static CJBDHFJKABF<T, U, V> PMIHMDGCMLK(CJBDHFJKABF<T, U, V> LGGJKGFGJMC, Action<T, U, V> IOPCFKOHPBF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface PAICOPENLKI<T, U, V, W>
{
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public sealed class PBBPHACIOEF<T, U, V, W> : JOFKANMKADA<Action<T, U, V, W>>, PAICOPENLKI<T, U, V, W> where T : notnull where U : notnull where V : notnull where W : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x42C3A80", Offset = "0x42C2E80", VA = "0x1842C3A80")]
	public PBBPHACIOEF(bool IJDDHHGFLMK = false, bool PMMHICPABLF = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x52BBEF0", Offset = "0x52BB2F0", VA = "0x1852BBEF0")]
	public void HKANHPMMIAO(T OOLNPDLPIEB, U OJOOOBBLFNO, V CHAOGBKCKEH, W AMDFBELLJOH)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x484F330", Offset = "0x484E730", VA = "0x18484F330")]
	public static PBBPHACIOEF<T, U, V, W> NEOOCHPFDCF(PBBPHACIOEF<T, U, V, W> LGGJKGFGJMC, Action<T, U, V, W> IOPCFKOHPBF)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x484F3D0", Offset = "0x484E7D0", VA = "0x18484F3D0")]
	public static PBBPHACIOEF<T, U, V, W> PMIHMDGCMLK(PBBPHACIOEF<T, U, V, W> LGGJKGFGJMC, Action<T, U, V, W> IOPCFKOHPBF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public sealed class CPKJELMNNMK<T, U, V, W, X> : JOFKANMKADA<Action<T, U, V, W, X>>
{
	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x42C3A80", Offset = "0x42C2E80", VA = "0x1842C3A80")]
	public CPKJELMNNMK(bool IJDDHHGFLMK = false, bool PMMHICPABLF = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x6471660", Offset = "0x6470A60", VA = "0x186471660")]
	public void HKANHPMMIAO(T OOLNPDLPIEB, U OJOOOBBLFNO, V CHAOGBKCKEH, W AMDFBELLJOH, X MEAMPLHPPKP)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x484F330", Offset = "0x484E730", VA = "0x18484F330")]
	public static CPKJELMNNMK<T, U, V, W, X> NEOOCHPFDCF(CPKJELMNNMK<T, U, V, W, X> LGGJKGFGJMC, Action<T, U, V, W, X> IOPCFKOHPBF)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x484F3D0", Offset = "0x484E7D0", VA = "0x18484F3D0")]
	public static CPKJELMNNMK<T, U, V, W, X> PMIHMDGCMLK(CPKJELMNNMK<T, U, V, W, X> LGGJKGFGJMC, Action<T, U, V, W, X> IOPCFKOHPBF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public sealed class KHBBAOBIBLP<T, U, V, W, X, Y> : JOFKANMKADA<Action<T, U, V, W, X, Y>>
{
	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x42C3A80", Offset = "0x42C2E80", VA = "0x1842C3A80")]
	public KHBBAOBIBLP(bool IJDDHHGFLMK = false, bool PMMHICPABLF = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x4D70D10", Offset = "0x4D70110", VA = "0x184D70D10")]
	public void HKANHPMMIAO(T OOLNPDLPIEB, U OJOOOBBLFNO, V CHAOGBKCKEH, W AMDFBELLJOH, X MEAMPLHPPKP, Y KDELALKKKOF)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x484F330", Offset = "0x484E730", VA = "0x18484F330")]
	public static KHBBAOBIBLP<T, U, V, W, X, Y> NEOOCHPFDCF(KHBBAOBIBLP<T, U, V, W, X, Y> LGGJKGFGJMC, Action<T, U, V, W, X, Y> IOPCFKOHPBF)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x484F3D0", Offset = "0x484E7D0", VA = "0x18484F3D0")]
	public static KHBBAOBIBLP<T, U, V, W, X, Y> PMIHMDGCMLK(KHBBAOBIBLP<T, U, V, W, X, Y> LGGJKGFGJMC, Action<T, U, V, W, X, Y> IOPCFKOHPBF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public class AJFMCKADLPL<TKey, TVal> where TKey : notnull where TVal : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly GDHFCHKNKML<TKey, TVal> FIPKMJLDFIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	internal readonly Dictionary<TKey, (TVal value, int size)> HHDECPDLGCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private readonly GDHFCHKNKML<TKey, TVal>.CPGEBDJOKID? HJOFJNMLEPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private readonly int DBGIEJGJFKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private readonly GDHFCHKNKML<TKey, TVal>.AFHJOOIPMOA? MEOOEKANMLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private int JAABHFFIPBH;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	internal int INEOJCNAKKK
	{
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x48E5CF0", Offset = "0x48E50F0", VA = "0x1848E5CF0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public int DIPAECOCKOI
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x993220", Offset = "0x992620", VA = "0x180993220")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x48E6A10", Offset = "0x48E5E10", VA = "0x1848E6A10")]
	public AJFMCKADLPL(int DBGIEJGJFKO, [Optional] GDHFCHKNKML<TKey, TVal>.AFHJOOIPMOA? MEOOEKANMLH, [Optional] IEqualityComparer<TKey>? EBDAAEFHDKB, [Optional] GDHFCHKNKML<TKey, TVal>.CPGEBDJOKID? HJOFJNMLEPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x48E66B0", Offset = "0x48E5AB0", VA = "0x1848E66B0")]
	public void NOKIHEFAJEB(TKey DJBLFBEBKGO, TVal FFOEEMKIKJO, bool JINCPPLMAIJ = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x48E58D0", Offset = "0x48E4CD0", VA = "0x1848E58D0")]
	public bool DJBLIHGNADP(TKey DJBLFBEBKGO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x48E5720", Offset = "0x48E4B20", VA = "0x1848E5720")]
	public bool BGPIDOLLEKE(TKey IMDENDBDIKN, [Out] TVal FFOEEMKIKJO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x48E5A30", Offset = "0x48E4E30", VA = "0x1848E5A30")]
	private void HEGJIJBKKKF(TKey DJBLFBEBKGO, TVal FFOEEMKIKJO, int MNDMOIHIBEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x48E6500", Offset = "0x48E5900", VA = "0x1848E6500")]
	public bool MALKODFEJPJ(TKey DJBLFBEBKGO, TVal FFOEEMKIKJO, bool JINCPPLMAIJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x48E5820", Offset = "0x48E4C20", VA = "0x1848E5820")]
	public void CJEMNCEDADJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x48E5D40", Offset = "0x48E5140", VA = "0x1848E5D40")]
	private void JGENILCBGHM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x48E62A0", Offset = "0x48E56A0", VA = "0x1848E62A0")]
	private bool LGEIOPGDBHJ(TKey DJBLFBEBKGO, GAOHBELNOKN JKODLOFLBMK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x48E63E0", Offset = "0x48E57E0", VA = "0x1848E63E0")]
	private void LIJFMNCJHOH(TKey DJBLFBEBKGO, TVal FFOEEMKIKJO, GAOHBELNOKN JKODLOFLBMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x48E68E0", Offset = "0x48E5CE0", VA = "0x1848E68E0")]
	private void PCFAGDEGKCB(TKey DJBLFBEBKGO, TVal PCJCDFNKKKE, GAOHBELNOKN JKODLOFLBMK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class DOGHOCFLAFM : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private readonly Action MNLBIHAIHOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private bool BPBLJHNDPBA;

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x99CAA0", Offset = "0x99BEA0", VA = "0x18099CAA0")]
	public DOGHOCFLAFM(Action JECALFIKEFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x79A13F0", Offset = "0x79A07F0", VA = "0x1879A13F0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x3385030", Offset = "0x3384430", VA = "0x183385030")]
	public static OHGHKHJHGOP<T> GNHEPACBJCH<T>(T FFOEEMKIKJO, Action JECALFIKEFL) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public sealed class OHGHKHJHGOP<T> : DOGHOCFLAFM where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public T HDKOPKMNJCH
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x9931D0", Offset = "0x9925D0", VA = "0x1809931D0")]
		[CompilerGenerated]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x51E89A0", Offset = "0x51E7DA0", VA = "0x1851E89A0")]
	public OHGHKHJHGOP(T FFOEEMKIKJO, Action JECALFIKEFL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public sealed class DHFNCGJPBDA<T> : IDisposable where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private readonly MMNJMCCEIJD<T>? DJJNBDDHGCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private readonly ReadOnlySequence<T> LOHLOFBHAAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private bool BPBLJHNDPBA;

	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public static readonly DHFNCGJPBDA<T> GBADJOAJCAL;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public ReadOnlySequence<T> JCEIELCFMHI
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x66705C0", Offset = "0x666F9C0", VA = "0x1866705C0")]
		get
		{
			return default(ReadOnlySequence<T>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public long EMKINJPKJHL
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x6670470", Offset = "0x666F870", VA = "0x186670470")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public bool KCBHPIPJOPL
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x6670230", Offset = "0x666F630", VA = "0x186670230")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x6670C70", Offset = "0x6670070", VA = "0x186670C70")]
	public DHFNCGJPBDA(MMNJMCCEIJD<T> HCKMKBFOCMD, MMNJMCCEIJD<T> OMFHLFAFNPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x66708C0", Offset = "0x666FCC0", VA = "0x1866708C0")]
	public DHFNCGJPBDA(MMNJMCCEIJD<T> HCKMKBFOCMD, int GNPKFMEIDNL, MMNJMCCEIJD<T> OMFHLFAFNPI, int HGILLAMPJKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x6670810", Offset = "0x666FC10", VA = "0x186670810")]
	private DHFNCGJPBDA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x6670530", Offset = "0x666F930", VA = "0x186670530", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x66700D0", Offset = "0x666F4D0", VA = "0x1866700D0")]
	public T[] CNGHJFEEEPF()
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x666FFB0", Offset = "0x666F3B0", VA = "0x18666FFB0")]
	public static ReadOnlySequence<T> CLMIANKGGAM(DHFNCGJPBDA<T>? LGAMEGCBKGI)
	{
		return default(ReadOnlySequence<T>);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000017")]
public readonly struct MLHHDOMPAAM : IDisposable
{
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public readonly struct EKEKPGHKMDM : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x9DE710", Offset = "0x9DDB10", VA = "0x1809DE710")]
		public static EKEKPGHKMDM HBLBJMFGHFK()
		{
			return default(EKEKPGHKMDM);
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x996AE0", Offset = "0x995EE0", VA = "0x180996AE0", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x79A2E40", Offset = "0x79A2240", VA = "0x1879A2E40")]
	public static string BIKEBHNNGCB(Type HAFNBBNOLPO, [Optional] string? EDECGKJDLJG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x37265E0", Offset = "0x37259E0", VA = "0x1837265E0")]
	public static string? BIKEBHNNGCB<T>([Optional] string? EDECGKJDLJG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x3726560", Offset = "0x3725960", VA = "0x183726560")]
	public static string? AOINLCMLAIL<T>([Optional] string? BNCBNCCIEDH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x9DE710", Offset = "0x9DDB10", VA = "0x1809DE710")]
	public static MLHHDOMPAAM NFJOOPGCIPO(string EDECGKJDLJG, string? BNCBNCCIEDH)
	{
		return default(MLHHDOMPAAM);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x996AE0", Offset = "0x995EE0", VA = "0x180996AE0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public struct EACGDNOMLJK
{
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public delegate bool EFENJPBJCOH(string GIOLGNBKNMC, EACGDNOMLJK CCIAFLEMOBM);

	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[CompilerGenerated]
	private sealed class BNKBGJBEGIF<T> where T : notnull, Enum
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public List<int> enumValuesSubset;

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x9A2500", Offset = "0x9A1900", VA = "0x1809A2500")]
		public BNKBGJBEGIF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x5F59C50", Offset = "0x5F59050", VA = "0x185F59C50")]
		internal void PAIOJHEHHIJ(T x)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public int OEAPKNBFGIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public string AOGBFILDDIH;

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x79A19B0", Offset = "0x79A0DB0", VA = "0x1879A19B0")]
	public static Dictionary<string, EACGDNOMLJK> OJIKIDBCAGI(Type JBNOGMDBBDL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x34607A0", Offset = "0x345FBA0", VA = "0x1834607A0")]
	public static Dictionary<string, EACGDNOMLJK> OJIKIDBCAGI<T>(Type JBNOGMDBBDL, IReadOnlyDictionary<T, string> JBPGLHLMGII) where T : notnull, Enum
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x3460020", Offset = "0x345F420", VA = "0x183460020")]
	public static Dictionary<string, EACGDNOMLJK> IBINIPEMFDD<T>(List<T> LDJBCGFILMH) where T : notnull, Enum
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x79A15F0", Offset = "0x79A09F0", VA = "0x1879A15F0")]
	public static Dictionary<string, EACGDNOMLJK> IDKFEPKOMMO(Type JBNOGMDBBDL, EFENJPBJCOH JHHKEPHPIEH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x79A1430", Offset = "0x79A0830", VA = "0x1879A1430")]
	public static Dictionary<int, string> FNLEDGEAHHN(Dictionary<string, EACGDNOMLJK> PEAMMFAMJGD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public abstract class ADGPAJEIFGP : ALOCPDILHNE
{
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public static bool IIKJCOPJDLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	private readonly string? KCNLBGCMEND;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public virtual ALOCPDILHNE? JFBOFPIIHMH
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x996AF0", Offset = "0x995EF0", VA = "0x180996AF0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x79A0830", Offset = "0x799FC30", VA = "0x1879A0830")]
	protected ADGPAJEIFGP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(Slot = "7")]
	public abstract string JIBLDGHIHFP();

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x79A0180", Offset = "0x799F580", VA = "0x1879A0180", Slot = "8")]
	public virtual string ECHJPNBCKLJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x79A03C0", Offset = "0x799F7C0", VA = "0x1879A03C0", Slot = "9")]
	public void LFNEGAPCDIL(StringBuilder OMGOKFDHENG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x79A07D0", Offset = "0x799FBD0", VA = "0x1879A07D0", Slot = "10")]
	public void NHONLPKKPFF(StringBuilder OMGOKFDHENG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x79A02A0", Offset = "0x799F6A0", VA = "0x1879A02A0", Slot = "11")]
	public void JDOJMNNLGDL(StringBuilder OMGOKFDHENG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x79A0670", Offset = "0x799FA70", VA = "0x1879A0670", Slot = "12")]
	public void LLIADOCJEAC(StringBuilder OMGOKFDHENG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x79A0200", Offset = "0x799F600", VA = "0x1879A0200")]
	public static void GDBJJCBACPN(StringBuilder OMGOKFDHENG, string MFHOBOOBKHB, string ABIKLBLEKNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x69AAC40", Offset = "0x69AA040", VA = "0x1869AAC40", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class NIBOMDHJAAI : Exception
{
	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x79A2E80", Offset = "0x79A2280", VA = "0x1879A2E80")]
	public NIBOMDHJAAI(string DAMFJFKKFBI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class JAPPCHCKPAA<TErr> : NIBOMDHJAAI where TErr : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public readonly TErr HEEGIAFBKFO;

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x4BCADB0", Offset = "0x4BCA1B0", VA = "0x184BCADB0")]
	private JAPPCHCKPAA([In] TErr IMFPGAEPEOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x4BCACE0", Offset = "0x4BCA0E0", VA = "0x184BCACE0")]
	public static JAPPCHCKPAA<TErr> HBLBJMFGHFK([In] TErr IMFPGAEPEOJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class ONDHKAHAPMB : Stream
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private readonly HashAlgorithm APIKMAJFDAH;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public override bool FHKDOADDAFH
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x9DE710", Offset = "0x9DDB10", VA = "0x1809DE710", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public override bool PNPJDGDLDIH
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x9DE710", Offset = "0x9DDB10", VA = "0x1809DE710", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public override bool KPGHGMFLLPE
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x9AF690", Offset = "0x9AEA90", VA = "0x1809AF690", Slot = "11")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public override long EMKINJPKJHL
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x79A3750", Offset = "0x79A2B50", VA = "0x1879A3750", Slot = "12")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public override long KLIFIKMFFNL
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x79A37C0", Offset = "0x79A2BC0", VA = "0x1879A37C0", Slot = "13")]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x79A3830", Offset = "0x79A2C30", VA = "0x1879A3830", Slot = "14")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x79A36E0", Offset = "0x79A2AE0", VA = "0x1879A36E0")]
	public ONDHKAHAPMB(HashAlgorithm APIKMAJFDAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x79A3500", Offset = "0x79A2900", VA = "0x1879A3500", Slot = "35")]
	public override int Read(byte[] DAMDACDIHDN, int HGHGCNDALFP, int ECKHNAPCKGD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x79A36B0", Offset = "0x79A2AB0", VA = "0x1879A36B0", Slot = "38")]
	public override void Write(byte[] DAMDACDIHDN, int HGHGCNDALFP, int ECKHNAPCKGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x79A35A0", Offset = "0x79A29A0", VA = "0x1879A35A0", Slot = "33")]
	public override long Seek(long HGHGCNDALFP, SeekOrigin NEGIIJCCHAL)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x79A3630", Offset = "0x79A2A30", VA = "0x1879A3630", Slot = "34")]
	public override void SetLength(long FFOEEMKIKJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x996AE0", Offset = "0x995EE0", VA = "0x180996AE0", Slot = "23")]
	public override void Flush()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x79A3420", Offset = "0x79A2820", VA = "0x1879A3420")]
	public byte[] FIDKGFHBMMK()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public interface ALOCPDILHNE
{
	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(Slot = "0")]
	string ECHJPNBCKLJ();

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(Slot = "1")]
	string JIBLDGHIHFP();
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public interface OAODAKEKPCL<out TOptions> where TOptions : notnull
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	TOptions HDKOPKMNJCH
	{
		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public interface NKOCKMDBDMK
{
	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	string IDGHCCMLDGL
	{
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public sealed class MMNJMCCEIJD<T> : ReadOnlySequenceSegment<T>, IDisposable where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private static MMNJMCCEIJD<T>? LEAGDEJGMAF;

	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private static object OEPEEGNHBEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private IMemoryOwner<T>? GFHIOICIEMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private bool BPBLJHNDPBA;

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public bool MPMNNGFDLEO
	{
		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0xCDB920", Offset = "0xCDAD20", VA = "0x180CDB920")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x5067770", Offset = "0x5066B70", VA = "0x185067770")]
	private static MMNJMCCEIJD<T> ANCJIAKCLEH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x5068940", Offset = "0x5067D40", VA = "0x185068940")]
	private static void IMEMDDBMBAH(MMNJMCCEIJD<T> GKFIHIFDCIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x49DA5A0", Offset = "0x49D99A0", VA = "0x1849DA5A0")]
	private MMNJMCCEIJD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x5068450", Offset = "0x5067850", VA = "0x185068450")]
	public static MMNJMCCEIJD<T> GNHEPACBJCH(ReadOnlyMemory<T> OICOPJMPHPI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x5068240", Offset = "0x5067640", VA = "0x185068240")]
	public static MMNJMCCEIJD<T> GNHEPACBJCH(IMemoryOwner<T> KIPNCKDBHPH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x5068F00", Offset = "0x5068300", VA = "0x185068F00")]
	public static void LHBIEBGOHFD(MMNJMCCEIJD<T> HCKMKBFOCMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x5067FC0", Offset = "0x50673C0", VA = "0x185067FC0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x5067C30", Offset = "0x5067030", VA = "0x185067C30")]
	public MMNJMCCEIJD<T> DEGBEBOMHAA(IMemoryOwner<T> KIPNCKDBHPH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x5069040", Offset = "0x5068440", VA = "0x185069040")]
	private void OPKMIMNNMDE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x50687F0", Offset = "0x5067BF0", VA = "0x1850687F0")]
	private MMNJMCCEIJD<T> HANDLLACLGA(MMNJMCCEIJD<T> GKFIHIFDCIH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public class CDDLHGOPHPH : Exception
{
	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x79A0EE0", Offset = "0x79A02E0", VA = "0x1879A0EE0")]
	public CDDLHGOPHPH(string DAMFJFKKFBI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public class GMNIIJHIMEI<TOk> : CDDLHGOPHPH where TOk : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public readonly TOk NILGAOGKJBL;

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x485C220", Offset = "0x485B620", VA = "0x18485C220")]
	private GMNIIJHIMEI([In] TOk CFKMKCHBJDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x485BFD0", Offset = "0x485B3D0", VA = "0x18485BFD0")]
	public static GMNIIJHIMEI<TOk> HBLBJMFGHFK([In] TOk CFKMKCHBJDM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public readonly struct KGPHFOFOMPJ<TOk, TErr> : IEquatable<KGPHFOFOMPJ<TOk, TErr>> where TOk : notnull where TErr : notnull
{
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private static readonly EqualityComparer<TErr> ELBJNCNIGON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	internal readonly TErr HEEGIAFBKFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	internal readonly TOk NILGAOGKJBL;

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public bool NKGHKIGEFDO
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x4D67210", Offset = "0x4D66610", VA = "0x184D67210")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public bool LMIOLHACLIM
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x4D66A10", Offset = "0x4D65E10", VA = "0x184D66A10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x4D679F0", Offset = "0x4D66DF0", VA = "0x184D679F0")]
	internal KGPHFOFOMPJ([In] TErr IMFPGAEPEOJ, [In] TOk CFKMKCHBJDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x4D66950", Offset = "0x4D65D50", VA = "0x184D66950")]
	public static KGPHFOFOMPJ<TOk, TErr> AAACLIDCHDJ([In] TErr IMFPGAEPEOJ)
	{
		return default(KGPHFOFOMPJ<TOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x4D67120", Offset = "0x4D66520", VA = "0x184D67120")]
	public static KGPHFOFOMPJ<TOk, TErr> ILHOPILDHCK([In] TOk CFKMKCHBJDM)
	{
		return default(KGPHFOFOMPJ<TOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x3BABBB0", Offset = "0x3BAAFB0", VA = "0x183BABBB0")]
	public KGPHFOFOMPJ<TOk?, UErr?> JDBAGOIIDGN<UErr>()
	{
		return default(KGPHFOFOMPJ<TOk, UErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x3BAB730", Offset = "0x3BAAB30", VA = "0x183BAB730")]
	public KGPHFOFOMPJ<UOk?, TErr?> DABOHFDDALG<UOk>()
	{
		return default(KGPHFOFOMPJ<UOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x3BAD0D0", Offset = "0x3BAC4D0", VA = "0x183BAD0D0")]
	public KGPHFOFOMPJ<UOk?, TErr?> LHOLLGDHFLI<UOk>()
	{
		return default(KGPHFOFOMPJ<UOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x3BABA90", Offset = "0x3BAAE90", VA = "0x183BABA90")]
	public KGPHFOFOMPJ<TOk?, UErr?> FDHPOINJLND<UErr>()
	{
		return default(KGPHFOFOMPJ<TOk, UErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x4D66E80", Offset = "0x4D66280", VA = "0x184D66E80")]
	public KGPHFOFOMPJ<LPCAMBCOBBH, TErr> GMFGMNMCOOP()
	{
		return default(KGPHFOFOMPJ<LPCAMBCOBBH, TErr>);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x4D67410", Offset = "0x4D66810", VA = "0x184D67410")]
	public static bool PEOCKCCHEIN([In] KGPHFOFOMPJ<TOk, TErr> KGCKEJLFPJB, [In] KGPHFOFOMPJ<TOk, TErr> HKELKGIPNGP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x4D66C30", Offset = "0x4D66030", VA = "0x184D66C30", Slot = "4")]
	public bool Equals(KGPHFOFOMPJ<TOk, TErr> KNCKFHOKGJM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x4D66AA0", Offset = "0x4D65EA0", VA = "0x184D66AA0", Slot = "0")]
	public override bool Equals(object KNCKFHOKGJM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x4D67030", Offset = "0x4D66430", VA = "0x184D67030", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x4D67680", Offset = "0x4D66A80", VA = "0x184D67680", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public static class BJMLEKADMEB
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	[CompilerGenerated]
	private struct KIILEOLGICM<TOk, TErr> : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		public AsyncTaskMethodBuilder<TOk> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		public Task<KGPHFOFOMPJ<TOk, TErr>> self;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private TaskAwaiter<KGPHFOFOMPJ<TOk, TErr>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x4D75070", Offset = "0x4D74470", VA = "0x184D75070", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x4D756B0", Offset = "0x4D74AB0", VA = "0x184D756B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x337CA50", Offset = "0x337BE50", VA = "0x18337CA50")]
	public static KGPHFOFOMPJ<TOk?, TErr?> NILGAOGKJBL<TOk, TErr>([In] this KGPHFOFOMPJ<TOk, TErr> JOCJBPPJMJJ, [In] TOk CFKMKCHBJDM)
	{
		return default(KGPHFOFOMPJ<TOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x337DD00", Offset = "0x337D100", VA = "0x18337DD00")]
	public static KGPHFOFOMPJ<LPCAMBCOBBH, TErr?> NILGAOGKJBL<TErr>([In] this KGPHFOFOMPJ<LPCAMBCOBBH, TErr> JOCJBPPJMJJ)
	{
		return default(KGPHFOFOMPJ<LPCAMBCOBBH, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x337CA50", Offset = "0x337BE50", VA = "0x18337CA50")]
	public static KGPHFOFOMPJ<TOk?, TErr?> HEEGIAFBKFO<TOk, TErr>([In] this KGPHFOFOMPJ<TOk, TErr> JOCJBPPJMJJ, [In] TErr IMFPGAEPEOJ)
	{
		return default(KGPHFOFOMPJ<TOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x337D630", Offset = "0x337CA30", VA = "0x18337D630")]
	public static TOk? KOIJKADCNPN<TOk, TErr>([In] this KGPHFOFOMPJ<TOk, TErr> JOCJBPPJMJJ)
	{
		return (TOk?)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x337C270", Offset = "0x337B670", VA = "0x18337C270")]
	[AsyncStateMachine(typeof(KIILEOLGICM<, >))]
	public static Task<TOk?>? DPMPGHOHCDF<TOk, TErr>(this Task<KGPHFOFOMPJ<TOk, TErr>> JOCJBPPJMJJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x337A660", Offset = "0x3379A60", VA = "0x18337A660")]
	public static TErr? CALIHNGCPLM<TErr, TOk>([In] this KGPHFOFOMPJ<TOk, TErr> JOCJBPPJMJJ)
	{
		return (TErr?)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x337AF90", Offset = "0x337A390", VA = "0x18337AF90")]
	public static bool DCKDEFGFKNG<TOk, TErr, UErr, UOk>([In] this KGPHFOFOMPJ<TOk, TErr> JOCJBPPJMJJ, [Out] KGPHFOFOMPJ<UOk, UErr> LMBIAMNEEOB) where TErr : UErr?
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x337C040", Offset = "0x337B440", VA = "0x18337C040")]
	public static bool DEIJFJEKBEC<TOk, TErr>([In] this KGPHFOFOMPJ<TOk, TErr> JOCJBPPJMJJ, [Out] TOk CFKMKCHBJDM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x337C5B0", Offset = "0x337B9B0", VA = "0x18337C5B0")]
	public static bool EEEJGKIMOON<TOk, TErr>([In] this KGPHFOFOMPJ<TOk, TErr> JOCJBPPJMJJ, [Out][NotNullWhen(true)] TErr IMFPGAEPEOJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x337DA70", Offset = "0x337CE70", VA = "0x18337DA70")]
	public static bool LPJKPKOGNIL<TOk, TErr>([In] this KGPHFOFOMPJ<TOk, TErr> JOCJBPPJMJJ, [Out][NotNullWhen(true)] TOk CFKMKCHBJDM, [Out][NotNullWhen(false)] TErr IMFPGAEPEOJ) where TOk : notnull where TErr : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x337DDA0", Offset = "0x337D1A0", VA = "0x18337DDA0")]
	public static bool OABOGIGMDIA<TOk, TErr>([In] this KGPHFOFOMPJ<TOk, TErr> JOCJBPPJMJJ, [Out][NotNullWhen(true)] TOk CFKMKCHBJDM, [Out] KGPHFOFOMPJ<TOk, TErr> LMBIAMNEEOB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x337AE60", Offset = "0x337A260", VA = "0x18337AE60")]
	public static bool DCKDEFGFKNG<TOk, TErr, UErr, UOk>([In] this KGPHFOFOMPJ<TOk, TErr> JOCJBPPJMJJ, [Out][NotNullWhen(true)] TOk CFKMKCHBJDM, [Out] KGPHFOFOMPJ<UOk, UErr> LMBIAMNEEOB) where TErr : UErr?
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x337AAB0", Offset = "0x3379EB0", VA = "0x18337AAB0")]
	public static bool CIMAMCACLNG<TOk, TErr>([In] this KGPHFOFOMPJ<TOk, TErr> JOCJBPPJMJJ, [Out][NotNullWhen(true)] TOk CFKMKCHBJDM, [Out] KGPHFOFOMPJ<LPCAMBCOBBH, TErr> LMBIAMNEEOB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x337CCE0", Offset = "0x337C0E0", VA = "0x18337CCE0")]
	public static KGPHFOFOMPJ<UOk, UErr> IIKGBDEKDDN<UOk, UErr, TOk, TErr>([In] this KGPHFOFOMPJ<TOk, TErr> JOCJBPPJMJJ, [In] KGPHFOFOMPJ<UOk, UErr> FKPHPPGPLLD) where TOk : UOk where TErr : UErr
	{
		return default(KGPHFOFOMPJ<UOk, UErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x337C680", Offset = "0x337BA80", VA = "0x18337C680")]
	public static KGPHFOFOMPJ<TOk?[]?, TErr?> FNDANPCHJKK<TOk, TErr>(this IEnumerable<KGPHFOFOMPJ<TOk, TErr>> JOCJBPPJMJJ)
	{
		return default(KGPHFOFOMPJ<TOk[], TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x337A300", Offset = "0x3379700", VA = "0x18337A300")]
	public static KGPHFOFOMPJ<UOk?, TErr?> AHDIBBAIBEF<UOk, TErr, TOk>([In] this KGPHFOFOMPJ<TOk, TErr> JOCJBPPJMJJ, Func<TOk, UOk> JGMEGNLMLMJ)
	{
		return default(KGPHFOFOMPJ<UOk, TErr>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public static class HFNFPGPMECM<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x3B9FCC0", Offset = "0x3B9F0C0", VA = "0x183B9FCC0")]
	public static KGPHFOFOMPJ<TOk, T> NILGAOGKJBL<TOk>([In] TOk CFKMKCHBJDM) where TOk : notnull
	{
		return default(KGPHFOFOMPJ<TOk, T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x48CE9F0", Offset = "0x48CDDF0", VA = "0x1848CE9F0")]
	public static KGPHFOFOMPJ<LPCAMBCOBBH, T> NILGAOGKJBL()
	{
		return default(KGPHFOFOMPJ<LPCAMBCOBBH, T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x3B9FCC0", Offset = "0x3B9F0C0", VA = "0x183B9FCC0")]
	public static KGPHFOFOMPJ<T, TErr> HEEGIAFBKFO<TErr>([In] TErr IMFPGAEPEOJ) where TErr : notnull
	{
		return default(KGPHFOFOMPJ<T, TErr>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public readonly struct INNNADKOMLO<TKey, TValue> where TKey : notnull where TValue : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private readonly DMLDMFABONA ODMONMJNOHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private readonly Dictionary<TKey, TValue> LLLNOEOKELG;

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x49FE020", Offset = "0x49FD420", VA = "0x1849FE020")]
	public static INNNADKOMLO<TKey, TValue> HBLBJMFGHFK(string PCJJKLDOJMD)
	{
		return default(INNNADKOMLO<TKey, TValue>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x49FE1E0", Offset = "0x49FD5E0", VA = "0x1849FE1E0")]
	internal INNNADKOMLO(Dictionary<TKey, TValue> FFOEEMKIKJO, DMLDMFABONA NMJDAHMKHPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x49FE140", Offset = "0x49FD540", VA = "0x1849FE140")]
	public MMNAADIMANP<TKey, TValue> NLDGOOOPFJD([Out] Dictionary<TKey, TValue> FFOEEMKIKJO)
	{
		return default(MMNAADIMANP<TKey, TValue>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public readonly struct MMNAADIMANP<TKey, TValue> : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private readonly Dictionary<TKey, TValue> LLLNOEOKELG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private readonly GIHKLINNGKG IEEDPGNJOED;

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x2864460", Offset = "0x2863860", VA = "0x182864460")]
	internal MMNAADIMANP(Dictionary<TKey, TValue> FFOEEMKIKJO, GIHKLINNGKG FELFNICCHNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x49FE220", Offset = "0x49FD620", VA = "0x1849FE220", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public readonly struct MKPOKEEHKDJ<T> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private readonly DMLDMFABONA ODMONMJNOHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private readonly HashSet<T> LLLNOEOKELG;

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x49FE020", Offset = "0x49FD420", VA = "0x1849FE020")]
	public static MKPOKEEHKDJ<T> HBLBJMFGHFK(string PCJJKLDOJMD)
	{
		return default(MKPOKEEHKDJ<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x49FE1E0", Offset = "0x49FD5E0", VA = "0x1849FE1E0")]
	internal MKPOKEEHKDJ(HashSet<T> FFOEEMKIKJO, DMLDMFABONA NMJDAHMKHPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x49FE140", Offset = "0x49FD540", VA = "0x1849FE140")]
	public PJBPCGKEMON<T> NLDGOOOPFJD([Out] HashSet<T> FFOEEMKIKJO)
	{
		return default(PJBPCGKEMON<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public readonly struct PJBPCGKEMON<T> : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private readonly HashSet<T> LLLNOEOKELG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private readonly GIHKLINNGKG IEEDPGNJOED;

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x2864460", Offset = "0x2863860", VA = "0x182864460")]
	internal PJBPCGKEMON(HashSet<T> FFOEEMKIKJO, GIHKLINNGKG FELFNICCHNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x49FE220", Offset = "0x49FD620", VA = "0x1849FE220", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public readonly struct BNAEEDIDAKC<T> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly DMLDMFABONA ODMONMJNOHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private readonly Stack<T> LLLNOEOKELG;

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x49FE020", Offset = "0x49FD420", VA = "0x1849FE020")]
	public static BNAEEDIDAKC<T> HBLBJMFGHFK(string PCJJKLDOJMD)
	{
		return default(BNAEEDIDAKC<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x49FE1E0", Offset = "0x49FD5E0", VA = "0x1849FE1E0")]
	internal BNAEEDIDAKC(Stack<T> FFOEEMKIKJO, DMLDMFABONA NMJDAHMKHPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x49FE140", Offset = "0x49FD540", VA = "0x1849FE140")]
	public INPJIHEKKJM<T> NLDGOOOPFJD([Out] Stack<T> FFOEEMKIKJO)
	{
		return default(INPJIHEKKJM<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public readonly struct INPJIHEKKJM<T> : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private readonly Stack<T> LLLNOEOKELG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private readonly GIHKLINNGKG IEEDPGNJOED;

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x2864460", Offset = "0x2863860", VA = "0x182864460")]
	internal INPJIHEKKJM(Stack<T> FFOEEMKIKJO, GIHKLINNGKG FELFNICCHNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x49FE220", Offset = "0x49FD620", VA = "0x1849FE220", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
[DefaultMember("Item")]
public sealed class PIDCPBHOLKH<T> : IEnumerable<T>, IEnumerable where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	private readonly struct DGGNKIMEHBN : IEnumerable<T>, IEnumerable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private readonly PIDCPBHOLKH<T> FOBLOMCENPC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private readonly int EGJIIIJJGBI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private readonly bool ENNLKHDPLOC;

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x2564470", Offset = "0x2563870", VA = "0x182564470")]
		public DGGNKIMEHBN(PIDCPBHOLKH<T> BGCEKLPNCIL, int OKDAAFAEHMK, bool ANOHBCPDNKJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x666F310", Offset = "0x666E710", VA = "0x18666F310")]
		public PIDCPBHOLKH<T>.PGCBELDNGEP DBEEDGEHMMA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x666F400", Offset = "0x666E800", VA = "0x18666F400", Slot = "5")]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x666F400", Offset = "0x666E800", VA = "0x18666F400", Slot = "4")]
		IEnumerator<T> IEnumerable<T>.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000032")]
	public sealed class PGCBELDNGEP : IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private readonly PIDCPBHOLKH<T> FOBLOMCENPC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private readonly int CFPOEBANINC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private int HEDIIMFFIJC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private readonly bool ENNLKHDPLOC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private bool DJJGLNONCOC;

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public T JKNLEFEANEI
		{
			[Cpp2IlInjected.Token(Token = "0x60000CF")]
			[Cpp2IlInjected.Address(RVA = "0x52D8E60", Offset = "0x52D8260", VA = "0x1852D8E60")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		T IEnumerator<T>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000D0")]
			[Cpp2IlInjected.Address(RVA = "0x52D9010", Offset = "0x52D8410", VA = "0x1852D9010", Slot = "4")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		object? IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000D1")]
			[Cpp2IlInjected.Address(RVA = "0x52D9180", Offset = "0x52D8580", VA = "0x1852D9180", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x52D9620", Offset = "0x52D8A20", VA = "0x1852D9620")]
		public PGCBELDNGEP(PIDCPBHOLKH<T> BGCEKLPNCIL, int OKDAAFAEHMK, bool ANOHBCPDNKJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x52D8F20", Offset = "0x52D8320", VA = "0x1852D8F20", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x52D8FB0", Offset = "0x52D83B0", VA = "0x1852D8FB0", Slot = "8")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x996AE0", Offset = "0x995EE0", VA = "0x180996AE0", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000033")]
	[CompilerGenerated]
	private sealed class LENNOHBDEEF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public Func<T> makeDefault;

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x9A2500", Offset = "0x9A1900", VA = "0x1809A2500")]
		public LENNOHBDEEF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x4E384B0", Offset = "0x4E378B0", VA = "0x184E384B0")]
		internal T NEKAPODGPIO(int _)
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private readonly T[] EIHPIBBPBJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private int HEDIIMFFIJC;

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public int IEPEHDIOMPO
	{
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x52E0DA0", Offset = "0x52E01A0", VA = "0x1852E0DA0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public T JKNLEFEANEI
	{
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x46E4270", Offset = "0x46E3670", VA = "0x1846E4270")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public T HNICEFLLFFA
	{
		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x52E0E00", Offset = "0x52E0200", VA = "0x1852E0E00")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public T JODHLAKLPCM
	{
		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x52E0C90", Offset = "0x52E0090", VA = "0x1852E0C90")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public int EMKINJPKJHL
	{
		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x24494A0", Offset = "0x24488A0", VA = "0x1824494A0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x192EA40", Offset = "0x192DE40", VA = "0x18192EA40")]
	private static int AMFLNKOGMNI(int CJFNAFNJJLB, int BFBCILDCBHG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x52E1000", Offset = "0x52E0400", VA = "0x1852E1000")]
	public PIDCPBHOLKH(int MNDMOIHIBEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x52E0E40", Offset = "0x52E0240", VA = "0x1852E0E40")]
	public PIDCPBHOLKH(int MNDMOIHIBEI, Func<T> GHHMDONGNPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x52E1300", Offset = "0x52E0700", VA = "0x1852E1300")]
	public PIDCPBHOLKH(T[] KKIPPMFKGPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x52E0B10", Offset = "0x52DFF10", VA = "0x1852E0B10")]
	public void BCBDFCEJKAP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x52E0A50", Offset = "0x52DFE50", VA = "0x1852E0A50")]
	public IEnumerable<T> BALECFBFOGM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x52E0D00", Offset = "0x52E0100", VA = "0x1852E0D00")]
	public PIDCPBHOLKH<T>.PGCBELDNGEP DBEEDGEHMMA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x47C0B40", Offset = "0x47BFF40", VA = "0x1847C0B40", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x47C0B40", Offset = "0x47BFF40", VA = "0x1847C0B40", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public static class NMNCPAMDABG
{
	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x37C6AA0", Offset = "0x37C5EA0", VA = "0x1837C6AA0")]
	public static PIDCPBHOLKH<T> HBLBJMFGHFK<T>(int MNDMOIHIBEI, Func<T> GHHMDONGNPN) where T : notnull
	{
		return null;
	}
}
namespace RecRoom.NoEngine.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	public struct RRColor : IEquatable<RRColor>, IFormattable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public float r;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public float g;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public float b;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public float a;

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public static RRColor White
		{
			[Cpp2IlInjected.Token(Token = "0x60000DD")]
			[Cpp2IlInjected.Address(RVA = "0x79A4570", Offset = "0x79A3970", VA = "0x1879A4570")]
			get
			{
				return default(RRColor);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public static RRColor Green
		{
			[Cpp2IlInjected.Token(Token = "0x60000DE")]
			[Cpp2IlInjected.Address(RVA = "0x79A4530", Offset = "0x79A3930", VA = "0x1879A4530")]
			get
			{
				return default(RRColor);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public static RRColor Red
		{
			[Cpp2IlInjected.Token(Token = "0x60000DF")]
			[Cpp2IlInjected.Address(RVA = "0x79A4550", Offset = "0x79A3950", VA = "0x1879A4550")]
			get
			{
				return default(RRColor);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public static RRColor Yellow
		{
			[Cpp2IlInjected.Token(Token = "0x60000E0")]
			[Cpp2IlInjected.Address(RVA = "0x79A4590", Offset = "0x79A3990", VA = "0x1879A4590")]
			get
			{
				return default(RRColor);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public static RRColor Cyan
		{
			[Cpp2IlInjected.Token(Token = "0x60000E1")]
			[Cpp2IlInjected.Address(RVA = "0x79A4510", Offset = "0x79A3910", VA = "0x1879A4510")]
			get
			{
				return default(RRColor);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x266EF80", Offset = "0x266E380", VA = "0x18266EF80")]
		public RRColor(float IEDBNFIMLNL, float NJJCBIMJHBH, float IAJJOLNCJOI, float PCMHLCLONGN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x786FFF0", Offset = "0x786F3F0", VA = "0x18786FFF0", Slot = "4")]
		public bool Equals(RRColor KNCKFHOKGJM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x79A4160", Offset = "0x79A3560", VA = "0x1879A4160", Slot = "0")]
		public override bool Equals(object KNCKFHOKGJM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x79A4260", Offset = "0x79A3660", VA = "0x1879A4260", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x79A42E0", Offset = "0x79A36E0", VA = "0x1879A42E0", Slot = "5")]
		public string ToString(string HJPPOILPOFH, IFormatProvider KIABGCJLOID)
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	public struct RRColor32 : IEquatable<RRColor32>, IFormattable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private int rgba;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public byte r;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public byte g;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public byte b;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public byte a;

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public static RRColor32 White
		{
			[Cpp2IlInjected.Token(Token = "0x60000E9")]
			[Cpp2IlInjected.Address(RVA = "0x79A4100", Offset = "0x79A3500", VA = "0x1879A4100")]
			get
			{
				return default(RRColor32);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public static RRColor32 Green
		{
			[Cpp2IlInjected.Token(Token = "0x60000EA")]
			[Cpp2IlInjected.Address(RVA = "0x79A40A0", Offset = "0x79A34A0", VA = "0x1879A40A0")]
			get
			{
				return default(RRColor32);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public static RRColor32 Red
		{
			[Cpp2IlInjected.Token(Token = "0x60000EB")]
			[Cpp2IlInjected.Address(RVA = "0x79A40D0", Offset = "0x79A34D0", VA = "0x1879A40D0")]
			get
			{
				return default(RRColor32);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public static RRColor32 Yellow
		{
			[Cpp2IlInjected.Token(Token = "0x60000EC")]
			[Cpp2IlInjected.Address(RVA = "0x79A4130", Offset = "0x79A3530", VA = "0x1879A4130")]
			get
			{
				return default(RRColor32);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public static RRColor32 Cyan
		{
			[Cpp2IlInjected.Token(Token = "0x60000ED")]
			[Cpp2IlInjected.Address(RVA = "0x79A4070", Offset = "0x79A3470", VA = "0x1879A4070")]
			get
			{
				return default(RRColor32);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x592AC50", Offset = "0x592A050", VA = "0x18592AC50")]
		public RRColor32(byte IEDBNFIMLNL, byte NJJCBIMJHBH, byte IAJJOLNCJOI, byte PCMHLCLONGN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x202FBC0", Offset = "0x202EFC0", VA = "0x18202FBC0", Slot = "4")]
		public bool Equals(RRColor32 KNCKFHOKGJM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x79A3D90", Offset = "0x79A3190", VA = "0x1879A3D90", Slot = "0")]
		public override bool Equals(object KNCKFHOKGJM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x11D2130", Offset = "0x11D1530", VA = "0x1811D2130", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x79A3C40", Offset = "0x79A3040", VA = "0x1879A3C40")]
		public static RRColor32 CLMIANKGGAM(RRColor NOBKOCLLFNE)
		{
			return default(RRColor32);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x79A3BD0", Offset = "0x79A2FD0", VA = "0x1879A3BD0")]
		public static RRColor CLMIANKGGAM(RRColor32 NOBKOCLLFNE)
		{
			return default(RRColor);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x79A3E10", Offset = "0x79A3210", VA = "0x1879A3E10", Slot = "5")]
		public string ToString(string HJPPOILPOFH, IFormatProvider KIABGCJLOID)
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public sealed class DECHADNHCAL<T> : IDisposable where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	public readonly struct HJKBBGDIABL : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		private readonly DECHADNHCAL<T> CAOCGEIBDJH;

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public T HDKOPKMNJCH
		{
			[Cpp2IlInjected.Token(Token = "0x60000F4")]
			[Cpp2IlInjected.Address(RVA = "0x49038A0", Offset = "0x4902CA0", VA = "0x1849038A0")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x49038C0", Offset = "0x4902CC0", VA = "0x1849038C0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0xC6E720", Offset = "0xC6DB20", VA = "0x180C6E720")]
		public HJKBBGDIABL(DECHADNHCAL<T> CAOCGEIBDJH)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	[CompilerGenerated]
	private struct DLCICMKMCCD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public AsyncTaskMethodBuilder<HJKBBGDIABL> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public DECHADNHCAL<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x668FF80", Offset = "0x668F380", VA = "0x18668FF80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x48EA040", Offset = "0x48E9440", VA = "0x1848EA040", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	private readonly SemaphoreSlim BPHINCLMBDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	private T MEBMOMPAGGP;

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x6666940", Offset = "0x6665D40", VA = "0x186666940")]
	public DECHADNHCAL([In] T MEBMOMPAGGP, int AEIBEGHLFEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x6666710", Offset = "0x6665B10", VA = "0x186666710")]
	public DECHADNHCAL([In] T MEBMOMPAGGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x6666210", Offset = "0x6665610", VA = "0x186666210", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x6666250", Offset = "0x6665650", VA = "0x186666250")]
	public HJKBBGDIABL EJDIBLGNHID()
	{
		return default(HJKBBGDIABL);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x66665F0", Offset = "0x66659F0", VA = "0x1866665F0")]
	[AsyncStateMachine(typeof(DECHADNHCAL<>.DLCICMKMCCD))]
	public Task<DECHADNHCAL<T>.HJKBBGDIABL> FGOCGFEJCED(CancellationToken LMNHDKIFBOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x66661F0", Offset = "0x66655F0", VA = "0x1866661F0")]
	public void BMKKLKINIKE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public static class GNMLKKENCAK
{
	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x79A2060", Offset = "0x79A1460", VA = "0x1879A2060")]
	public static DECHADNHCAL<LPCAMBCOBBH> HBLBJMFGHFK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x337DEA0", Offset = "0x337D2A0", VA = "0x18337DEA0")]
	public static DECHADNHCAL<T> HBLBJMFGHFK<T>([In] T MEBMOMPAGGP) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public sealed class IGBGKFFBDGD<T> : IDisposable where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	public readonly struct PDBBMANOHFJ : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		private readonly IGBGKFFBDGD<T> CIIMCPBANDO;

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public T HDKOPKMNJCH
		{
			[Cpp2IlInjected.Token(Token = "0x6000100")]
			[Cpp2IlInjected.Address(RVA = "0x4BF6E40", Offset = "0x4BF6240", VA = "0x184BF6E40")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x52C7710", Offset = "0x52C6B10", VA = "0x1852C7710", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0xC6E720", Offset = "0xC6DB20", VA = "0x180C6E720")]
		internal PDBBMANOHFJ(IGBGKFFBDGD<T> CAOCGEIBDJH)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003D")]
	public readonly struct JKFBCIOKDLE : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		private readonly IGBGKFFBDGD<T> CIIMCPBANDO;

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public T HDKOPKMNJCH
		{
			[Cpp2IlInjected.Token(Token = "0x6000103")]
			[Cpp2IlInjected.Address(RVA = "0x4BF6E40", Offset = "0x4BF6240", VA = "0x184BF6E40")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x4BF6E60", Offset = "0x4BF6260", VA = "0x184BF6E60", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0xC6E720", Offset = "0xC6DB20", VA = "0x180C6E720")]
		internal JKFBCIOKDLE(IGBGKFFBDGD<T> CAOCGEIBDJH)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	[CompilerGenerated]
	private struct MFJBMCGMDDJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public AsyncTaskMethodBuilder<JKFBCIOKDLE> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public IGBGKFFBDGD<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		private DECHADNHCAL<LPCAMBCOBBH>.HJKBBGDIABL <writeLock>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		private TaskAwaiter<DECHADNHCAL<LPCAMBCOBBH>.HJKBBGDIABL> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x5028D50", Offset = "0x5028150", VA = "0x185028D50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x48EA040", Offset = "0x48E9440", VA = "0x1848EA040", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	private readonly DECHADNHCAL<int> BIPELOLFMAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private readonly DECHADNHCAL<LPCAMBCOBBH> HEJEJLODMEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private readonly DECHADNHCAL<LPCAMBCOBBH> LDHBOMPEEPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private T NCGFNDEHOML;

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x49E6F80", Offset = "0x49E6380", VA = "0x1849E6F80")]
	internal IGBGKFFBDGD(DECHADNHCAL<int> AOFIHJADKAE, DECHADNHCAL<LPCAMBCOBBH> ILEDCBBLOHG, DECHADNHCAL<LPCAMBCOBBH> GHHEMFPIBHO, [In] T MEBMOMPAGGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x49E66D0", Offset = "0x49E5AD0", VA = "0x1849E66D0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x49E6350", Offset = "0x49E5750", VA = "0x1849E6350")]
	public PDBBMANOHFJ DDCLNCKPBBO()
	{
		return default(PDBBMANOHFJ);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x49E6CA0", Offset = "0x49E60A0", VA = "0x1849E6CA0")]
	public JKFBCIOKDLE FEAAJMEOMKD()
	{
		return default(JKFBCIOKDLE);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x49E6970", Offset = "0x49E5D70", VA = "0x1849E6970")]
	[AsyncStateMachine(typeof(IGBGKFFBDGD<>.MFJBMCGMDDJ))]
	public Task<IGBGKFFBDGD<T>.JKFBCIOKDLE> EMLOFOCCCDE(CancellationToken LMNHDKIFBOH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public static class DLBBBONNLPG
{
	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x79A11F0", Offset = "0x79A05F0", VA = "0x1879A11F0")]
	public static IGBGKFFBDGD<LPCAMBCOBBH> HBLBJMFGHFK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x3447B70", Offset = "0x3446F70", VA = "0x183447B70")]
	public static IGBGKFFBDGD<T> HBLBJMFGHFK<T>([In] T MEBMOMPAGGP) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public sealed class AJOONLBHDFN<TData> : ADGPAJEIFGP where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	public readonly string FOLBMPKOGPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	public readonly TData EEHHJHNNGPO;

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x9931C0", Offset = "0x9925C0", VA = "0x1809931C0", Slot = "7")]
	public override string JIBLDGHIHFP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x48E6EA0", Offset = "0x48E62A0", VA = "0x1848E6EA0")]
	internal AJOONLBHDFN(string DAMFJFKKFBI, [In] TData HPMNBNLACCC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public static class OICBNKIHGAL
{
	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x79A33A0", Offset = "0x79A27A0", VA = "0x1879A33A0")]
	public static AJOONLBHDFN<LPCAMBCOBBH> HBLBJMFGHFK(string DAMFJFKKFBI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x3385030", Offset = "0x3384430", VA = "0x183385030")]
	public static AJOONLBHDFN<TData> HBLBJMFGHFK<TData>(string DAMFJFKKFBI, [In] TData HPMNBNLACCC) where TData : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public sealed class DMLDMFABONA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	internal bool KACIALAEALI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private readonly string HJGHCBKJEMP;

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0xD74A40", Offset = "0xD73E40", VA = "0x180D74A40")]
	private DMLDMFABONA(bool DDKOKAKNDPF, string AAAEJNNKBGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x79A12C0", Offset = "0x79A06C0", VA = "0x1879A12C0")]
	public static DMLDMFABONA HBLBJMFGHFK(string AAAEJNNKBGJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x79A1330", Offset = "0x79A0730", VA = "0x1879A1330")]
	public GIHKLINNGKG NLDGOOOPFJD()
	{
		return default(GIHKLINNGKG);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public readonly struct GIHKLINNGKG : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private readonly DMLDMFABONA BCEAIOAPDKK;

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0xC6E720", Offset = "0xC6DB20", VA = "0x180C6E720")]
	internal GIHKLINNGKG(DMLDMFABONA PCJJKLDOJMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x79A2040", Offset = "0x79A1440", VA = "0x1879A2040", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
[Obsolete("Use SimpleTokenFlag or WeakTokenFlag<T> instead")]
public sealed class DPCJKIAOFOP<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	[CompilerGenerated]
	private sealed class MHIGPFNFDPA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public StringBuilder sb;

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x9A2500", Offset = "0x9A1900", VA = "0x1809A2500")]
		public MHIGPFNFDPA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x503F610", Offset = "0x503EA10", VA = "0x18503F610")]
		internal int KEGLDGMOJDF(int i, T token)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private HashSet<T>? GFDNHOKEBDD;

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public IReadOnlyCollection<T> KIKFIFDHJFK
	{
		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x66984C0", Offset = "0x66978C0", VA = "0x1866984C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public bool AEJJCGKCLAI
	{
		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x6698500", Offset = "0x6697900", VA = "0x186698500")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public int GMILMIAEFMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x9984C0", Offset = "0x9978C0", VA = "0x1809984C0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x99F360", Offset = "0x99E760", VA = "0x18099F360")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x66986C0", Offset = "0x6697AC0", VA = "0x1866986C0")]
	public bool JJBKLNLGAIJ(T HHGPJKKLNIG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x6698550", Offset = "0x6697950", VA = "0x186698550")]
	public bool JEBJOEBLLEI(T HHGPJKKLNIG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x6698880", Offset = "0x6697C80", VA = "0x186698880")]
	public bool JOEMDCADNHJ(T HHGPJKKLNIG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x66983E0", Offset = "0x66977E0", VA = "0x1866983E0")]
	public void ANKKLOKJJMP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x66988D0", Offset = "0x6697CD0", VA = "0x1866988D0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x9A2500", Offset = "0x9A1900", VA = "0x1809A2500")]
	public DPCJKIAOFOP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public sealed class BBOIFKBNJEM
{
	[Cpp2IlInjected.Token(Token = "0x2000047")]
	[CompilerGenerated]
	private sealed class OHOBNLEJMHL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public StringBuilder sb;

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x9A2500", Offset = "0x9A1900", VA = "0x1809A2500")]
		public OHOBNLEJMHL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x79A32F0", Offset = "0x79A26F0", VA = "0x1879A32F0")]
		internal int KEGLDGMOJDF(int i, object token)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private HashSet<object>? GFDNHOKEBDD;

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public IReadOnlyCollection<object> KIKFIFDHJFK
	{
		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x79A0910", Offset = "0x799FD10", VA = "0x1879A0910")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public bool AEJJCGKCLAI
	{
		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x79A09A0", Offset = "0x799FDA0", VA = "0x1879A09A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public int GMILMIAEFMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x9984C0", Offset = "0x9978C0", VA = "0x1809984C0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x99F360", Offset = "0x99E760", VA = "0x18099F360")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x79A0A50", Offset = "0x799FE50", VA = "0x1879A0A50")]
	public bool JJBKLNLGAIJ(object HHGPJKKLNIG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x79A09B0", Offset = "0x799FDB0", VA = "0x1879A09B0")]
	public bool JEBJOEBLLEI(object HHGPJKKLNIG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x79A0B30", Offset = "0x799FF30", VA = "0x1879A0B30")]
	public bool JOEMDCADNHJ(object HHGPJKKLNIG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x79A08A0", Offset = "0x799FCA0", VA = "0x1879A08A0")]
	public void ANKKLOKJJMP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x79A0B90", Offset = "0x799FF90", VA = "0x1879A0B90", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x9A2500", Offset = "0x9A1900", VA = "0x1809A2500")]
	public BBOIFKBNJEM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public class CPPBICOIDFP<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000049")]
	private struct OPBKEIFNCHO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		public float LHAHEJJDJJP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public T HDKOPKMNJCH;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	private readonly Dictionary<object, OPBKEIFNCHO> JLLDPNEPEEK;

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public virtual T FHLINHJNANA
	{
		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x1838860", Offset = "0x1837C60", VA = "0x181838860", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x1836BB0", Offset = "0x1835FB0", VA = "0x181836BB0", Slot = "5")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public object? PKKALGBGHDI
	{
		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x9944C0", Offset = "0x9938C0", VA = "0x1809944C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x99E210", Offset = "0x99D610", VA = "0x18099E210")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public bool PKMGEMMGNAG
	{
		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x4BED180", Offset = "0x4BEC580", VA = "0x184BED180")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x647CD90", Offset = "0x647C190", VA = "0x18647CD90")]
	public bool JHAAOHPGICL(T FFOEEMKIKJO, object HHGPJKKLNIG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x4BED1E0", Offset = "0x4BEC5E0", VA = "0x184BED1E0")]
	public bool GOGJPLAFFMK(object HHGPJKKLNIG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x4812530", Offset = "0x4811930", VA = "0x184812530")]
	public void CJEMNCEDADJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x647B180", Offset = "0x647A580", VA = "0x18647B180")]
	public bool BGPIDOLLEKE(object HHGPJKKLNIG, [Out] T FFOEEMKIKJO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x647B460", Offset = "0x647A860", VA = "0x18647B460")]
	[HDBICCPCIAM("T can be T?, `default!` shouldn't be necessary in C# 9")]
	private bool CMPEKILFMCC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x5F42BD0", Offset = "0x5F41FD0", VA = "0x185F42BD0")]
	public CPPBICOIDFP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public sealed class DEMPDIKPCDF : CGKIFKPHPJP<CEGHMOMNMEC>
{
	[Cpp2IlInjected.Token(Token = "0x200004B")]
	internal class LPOKEFEHANM : IEqualityComparer<CEGHMOMNMEC>
	{
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		internal static readonly LPOKEFEHANM DNEPPKLGBFA;

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x79A2DA0", Offset = "0x79A21A0", VA = "0x1879A2DA0", Slot = "4")]
		public bool Equals(CEGHMOMNMEC MEAMPLHPPKP, CEGHMOMNMEC KDELALKKKOF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x6B9D540", Offset = "0x6B9C940", VA = "0x186B9D540", Slot = "5")]
		public int GetHashCode(CEGHMOMNMEC BLFGIKOAKOL)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x9A2500", Offset = "0x9A1900", VA = "0x1809A2500")]
		public LPOKEFEHANM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x79A1180", Offset = "0x79A0580", VA = "0x1879A1180")]
	public DEMPDIKPCDF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x79A1040", Offset = "0x79A0440", VA = "0x1879A1040", Slot = "4")]
	public override bool JJBKLNLGAIJ(CEGHMOMNMEC HHGPJKKLNIG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x79A0F90", Offset = "0x79A0390", VA = "0x1879A0F90", Slot = "5")]
	public override bool JEBJOEBLLEI(CEGHMOMNMEC HHGPJKKLNIG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x79A10F0", Offset = "0x79A04F0", VA = "0x1879A10F0")]
	private static void LKOIDCDGDIK(CEGHMOMNMEC HHGPJKKLNIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x171B960", Offset = "0x171AD60", VA = "0x18171B960", Slot = "6")]
	protected override string TokenToString(CEGHMOMNMEC HHGPJKKLNIG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public sealed class CEGHMOMNMEC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private readonly string OMKMDHJKBJB;

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x99CAA0", Offset = "0x99BEA0", VA = "0x18099CAA0")]
	public CEGHMOMNMEC(string OMKMDHJKBJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x79A0F40", Offset = "0x79A0340", VA = "0x1879A0F40", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public abstract class CGKIFKPHPJP<T> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private readonly IEqualityComparer<T> BJPBKLBLNPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	private HashSet<T>? GFDNHOKEBDD;

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public bool AEJJCGKCLAI
	{
		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x568ED60", Offset = "0x568E160", VA = "0x18568ED60")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public int GMILMIAEFMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0xB35CF0", Offset = "0xB350F0", VA = "0x180B35CF0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0xBE45A0", Offset = "0xBE39A0", VA = "0x180BE45A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x63FA150", Offset = "0x63F9550", VA = "0x1863FA150")]
	public CGKIFKPHPJP(IEqualityComparer<T> BJPBKLBLNPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x63F97C0", Offset = "0x63F8BC0", VA = "0x1863F97C0", Slot = "4")]
	public virtual bool JJBKLNLGAIJ(T HHGPJKKLNIG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x63F94E0", Offset = "0x63F88E0", VA = "0x1863F94E0", Slot = "5")]
	public virtual bool JEBJOEBLLEI(T HHGPJKKLNIG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x63F9400", Offset = "0x63F8800", VA = "0x1863F9400")]
	public void ANKKLOKJJMP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract string TokenToString(T HHGPJKKLNIG);

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x63F9E50", Offset = "0x63F9250", VA = "0x1863F9E50", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public sealed class JLKGKCGBFEF<T> where T : class
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	private List<WeakReference<T>>? GFDNHOKEBDD;

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public bool AEJJCGKCLAI
	{
		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x4C60370", Offset = "0x4C5F770", VA = "0x184C60370")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public int GMILMIAEFMI
	{
		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x4C601D0", Offset = "0x4C5F5D0", VA = "0x184C601D0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x4C60630", Offset = "0x4C5FA30", VA = "0x184C60630")]
	public void JJBKLNLGAIJ(T HHGPJKKLNIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x4C60490", Offset = "0x4C5F890", VA = "0x184C60490")]
	public void JEBJOEBLLEI(T HHGPJKKLNIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x4C60190", Offset = "0x4C5F590", VA = "0x184C60190")]
	public void ANKKLOKJJMP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x4C608A0", Offset = "0x4C5FCA0", VA = "0x184C608A0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x9A2500", Offset = "0x9A1900", VA = "0x1809A2500")]
	public JLKGKCGBFEF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
internal static class MCBLDKLLCBB
{
	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x36D37C0", Offset = "0x36D2BC0", VA = "0x1836D37C0")]
	public static void ICCNAFAJNNM<T>(this List<T> CEFIHBLEFNG, int CJFNAFNJJLB) where T : notnull
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public class JIKDMLBEKBP<T> where T : notnull, IEquatable<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000051")]
	private struct NGONCPHMLIJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		public float LHAHEJJDJJP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public T HDKOPKMNJCH;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	private readonly Dictionary<CEGHMOMNMEC, NGONCPHMLIJ> JLLDPNEPEEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	private readonly EqualityComparer<T> BDBNFBEJAFL;

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public virtual T FHLINHJNANA
	{
		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x9943A0", Offset = "0x9937A0", VA = "0x1809943A0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x994540", Offset = "0x993940", VA = "0x180994540", Slot = "5")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	private CEGHMOMNMEC? PKKALGBGHDI
	{
		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x99A2A0", Offset = "0x9996A0", VA = "0x18099A2A0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public bool PKMGEMMGNAG
	{
		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x4BED180", Offset = "0x4BEC580", VA = "0x184BED180")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x4BED280", Offset = "0x4BEC680", VA = "0x184BED280")]
	public bool JHAAOHPGICL(T FFOEEMKIKJO, CEGHMOMNMEC HHGPJKKLNIG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x4BED1E0", Offset = "0x4BEC5E0", VA = "0x184BED1E0")]
	public bool GOGJPLAFFMK(CEGHMOMNMEC HHGPJKKLNIG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x4812530", Offset = "0x4811930", VA = "0x184812530")]
	public void CJEMNCEDADJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x4BECB50", Offset = "0x4BEBF50", VA = "0x184BECB50")]
	public bool BGPIDOLLEKE(CEGHMOMNMEC HHGPJKKLNIG, [Out] T FFOEEMKIKJO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x4BECBE0", Offset = "0x4BEBFE0", VA = "0x184BECBE0")]
	[HDBICCPCIAM("T can be T?, `default!` shouldn't be necessary in C# 9")]
	private bool CMPEKILFMCC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x4BED4A0", Offset = "0x4BEC8A0", VA = "0x184BED4A0")]
	public JIKDMLBEKBP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
public class ODCAMKMJKCK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	private readonly Dictionary<object, float> JLLDPNEPEEK;

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public float PJKCLPDDOCJ
	{
		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0xE322F0", Offset = "0xE316F0", VA = "0x180E322F0")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0xE32300", Offset = "0xE31700", VA = "0x180E32300")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x79A31F0", Offset = "0x79A25F0", VA = "0x1879A31F0")]
	public void JHAAOHPGICL(float FFOEEMKIKJO, object HHGPJKKLNIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x79A3050", Offset = "0x79A2450", VA = "0x1879A3050")]
	public void GOGJPLAFFMK(object HHGPJKKLNIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x79A3000", Offset = "0x79A2400", VA = "0x1879A3000")]
	public void CJEMNCEDADJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x79A30C0", Offset = "0x79A24C0", VA = "0x1879A30C0")]
	private void HHGPJDOAOMJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x79A3260", Offset = "0x79A2660", VA = "0x1879A3260")]
	public ODCAMKMJKCK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public interface EEKKCJKNBCB
{
	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event ABEIMCMKCDE AMAEMNCEHKG;
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
public class LIJGGIIFNIO : EEKKCJKNBCB, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000055")]
	public readonly struct IAJGAMIBMKK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public readonly float FMCLIDDFJAP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public readonly float NJIDHPODGEN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		internal readonly bool PNPLPCMDCBA;

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		public float BFPJLGPCCAO
		{
			[Cpp2IlInjected.Token(Token = "0x600016B")]
			[Cpp2IlInjected.Address(RVA = "0x79A21B0", Offset = "0x79A15B0", VA = "0x1879A21B0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x79A2320", Offset = "0x79A1720", VA = "0x1879A2320")]
		public IAJGAMIBMKK(float HCJENEHBBIC, float FNNKAHMFNCJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x79A21C0", Offset = "0x79A15C0", VA = "0x1879A21C0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000056")]
	[CompilerGenerated]
	private sealed class NPIJFNFHNAO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		public LIJGGIIFNIO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		public int newProgressableIndex;

		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x9A2500", Offset = "0x9A1900", VA = "0x1809A2500")]
		public NPIJFNFHNAO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x79A2EE0", Offset = "0x79A22E0", VA = "0x1879A2EE0")]
		internal void MMEAHODGGIC(float innerProgress)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	private readonly int HDAIOJEADNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	private int OKNKGBDFCHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	private readonly EEKKCJKNBCB[] KMNKMCJHPCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	private readonly ABEIMCMKCDE[] IAPHFNOPBJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	private readonly IAJGAMIBMKK[] DAIBHKEIPNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	private IAJGAMIBMKK CMLBLPFCDJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	private readonly FAHCCCHCJAA ILPLBJJOLMJ;

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event ABEIMCMKCDE AMAEMNCEHKG
	{
		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x79A2AC0", Offset = "0x79A1EC0", VA = "0x1879A2AC0", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x79A2480", Offset = "0x79A1880", VA = "0x1879A2480", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x79A2C10", Offset = "0x79A2010", VA = "0x1879A2C10")]
	public LIJGGIIFNIO(int HDAIOJEADNO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x79A2B80", Offset = "0x79A1F80", VA = "0x1879A2B80")]
	public FAHCCCHCJAA KOLJAMFOMMB(IAJGAMIBMKK KEDOGBHAGPB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x79A2650", Offset = "0x79A1A50", VA = "0x1879A2650")]
	public void GJCJLCNCGIP(EEKKCJKNBCB EJCDDFONACB, [Optional] IAJGAMIBMKK AJPALOBJENJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x79A2540", Offset = "0x79A1940", VA = "0x1879A2540", Slot = "6")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
public delegate void ABEIMCMKCDE(float BBLAIIAJPLM);
[Cpp2IlInjected.Token(Token = "0x2000058")]
public static class FBDGPOCLKFJ
{
	[Cpp2IlInjected.Token(Token = "0x2000059")]
	private class HHKFIMNMCPH : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		private readonly EEKKCJKNBCB JFFCFMIEDHJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		private readonly ABEIMCMKCDE ADLKPPBLCIG;

		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x79A2120", Offset = "0x79A1520", VA = "0x1879A2120")]
		public HHKFIMNMCPH(EEKKCJKNBCB JFFCFMIEDHJ, ABEIMCMKCDE ADLKPPBLCIG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x79A20D0", Offset = "0x79A14D0", VA = "0x1879A20D0", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x79A1F10", Offset = "0x79A1310", VA = "0x1879A1F10")]
	internal static bool DCNGKCALKGH(float PCMHLCLONGN, float IAJJOLNCJOI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x798F760", Offset = "0x798EB60", VA = "0x18798F760")]
	internal static float OIDFEGPNECD(float PCMHLCLONGN)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x79A1F80", Offset = "0x79A1380", VA = "0x1879A1F80")]
	public static IDisposable LPFBNPDLKAG(this EEKKCJKNBCB JFFCFMIEDHJ, ABEIMCMKCDE ADLKPPBLCIG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public class FAHCCCHCJAA : EEKKCJKNBCB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private float BBLAIIAJPLM;

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public float DBGFOJJCCMF
	{
		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x79A1D80", Offset = "0x79A1180", VA = "0x1879A1D80")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public event ABEIMCMKCDE? AMAEMNCEHKG
	{
		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x79A1E70", Offset = "0x79A1270", VA = "0x1879A1E70", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x79A1CE0", Offset = "0x79A10E0", VA = "0x1879A1CE0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x9A2500", Offset = "0x9A1900", VA = "0x1809A2500")]
	public FAHCCCHCJAA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public interface KFPBEOGNJED<T> where T : class, new()
{
	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	LAMDJDMNGDN<T> GKNBKKNIPGM([Out] T FFOEEMKIKJO);

	[Cpp2IlInjected.Token(Token = "0x600017C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void CJEMNCEDADJ();
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public class NENLLJAMJJE<T> : KFPBEOGNJED<T> where T : class, new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private readonly ConcurrentStack<T> AKJFBFFJIJI;

	[Cpp2IlInjected.Token(Token = "0x600017D")]
	[Cpp2IlInjected.Address(RVA = "0x50C0850", Offset = "0x50BFC50", VA = "0x1850C0850", Slot = "4")]
	public LAMDJDMNGDN<T> GKNBKKNIPGM([Out] T FFOEEMKIKJO)
	{
		return default(LAMDJDMNGDN<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(RVA = "0x50C07D0", Offset = "0x50BFBD0", VA = "0x1850C07D0")]
	public void FEMKONHLAGL(T NLJFPINPIMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0x4A01700", Offset = "0x4A00B00", VA = "0x184A01700", Slot = "5")]
	public void CJEMNCEDADJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(RVA = "0x996AE0", Offset = "0x995EE0", VA = "0x180996AE0", Slot = "6")]
	protected virtual void LABLGBAFPHD(T LEJFGCBLDNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000181")]
	[Cpp2IlInjected.Address(RVA = "0x50C08F0", Offset = "0x50BFCF0", VA = "0x1850C08F0")]
	private T IOLMGDEDCOJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(RVA = "0x50C0990", Offset = "0x50BFD90", VA = "0x1850C0990")]
	public NENLLJAMJJE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
public readonly struct LAMDJDMNGDN<T> : IDisposable where T : class, new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private readonly T NLJFPINPIMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private readonly NENLLJAMJJE<T> LHNFDMCLNKP;

	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(RVA = "0xA147A0", Offset = "0xA13BA0", VA = "0x180A147A0")]
	internal LAMDJDMNGDN(T FFOEEMKIKJO, NENLLJAMJJE<T> LHNFDMCLNKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000184")]
	[Cpp2IlInjected.Address(RVA = "0x4E22270", Offset = "0x4E21670", VA = "0x184E22270", Slot = "4")]
	void IDisposable.Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
public class BJDPOFCDNPK : NENLLJAMJJE<StringBuilder>
{
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	public static readonly BJDPOFCDNPK DNEPPKLGBFA;

	[Cpp2IlInjected.Token(Token = "0x6000185")]
	[Cpp2IlInjected.Address(RVA = "0x79A0D40", Offset = "0x79A0140", VA = "0x1879A0D40")]
	public static LAMDJDMNGDN<StringBuilder> IOLMGDEDCOJ([Out] StringBuilder FFOEEMKIKJO)
	{
		return default(LAMDJDMNGDN<StringBuilder>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000186")]
	[Cpp2IlInjected.Address(RVA = "0x79A0DE0", Offset = "0x79A01E0", VA = "0x1879A0DE0", Slot = "6")]
	protected override void LABLGBAFPHD(StringBuilder LEJFGCBLDNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(RVA = "0x79A0EA0", Offset = "0x79A02A0", VA = "0x1879A0EA0")]
	public BJDPOFCDNPK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
public class BJKDCPLBLNJ : InvalidOperationException
{
	[Cpp2IlInjected.Token(Token = "0x6000189")]
	[Cpp2IlInjected.Address(RVA = "0x72D6790", Offset = "0x72D5B90", VA = "0x1872D6790")]
	public BJKDCPLBLNJ(string DAMFJFKKFBI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
[DefaultMember("Item")]
public class JDBJDCHGLEP<TKey, TValue> : AACIGADGGNN<TKey, TValue>, IDictionary<TKey, TValue>, ICollection<KeyValuePair<TKey, TValue>>, IEnumerable<KeyValuePair<TKey, TValue>>, IEnumerable, IFJOKEIDJIN where TKey : notnull where TValue : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000061")]
	[CompilerGenerated]
	private sealed class KLJOJIJLBPN : IEnumerator<KeyValuePair<TKey, TValue>>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		private KeyValuePair<TKey, TValue> <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		public JDBJDCHGLEP<TKey, TValue> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		private IEnumerator<KeyValuePair<TKey, TValue>> <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		KeyValuePair<TKey, TValue> IEnumerator<KeyValuePair<TKey, TValue>>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001AA")]
			[Cpp2IlInjected.Address(RVA = "0x1838860", Offset = "0x1837C60", VA = "0x181838860", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return default(KeyValuePair<TKey, TValue>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001AC")]
			[Cpp2IlInjected.Address(RVA = "0x47812B0", Offset = "0x47806B0", VA = "0x1847812B0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0x999C60", Offset = "0x999060", VA = "0x180999C60")]
		[DebuggerHidden]
		public KLJOJIJLBPN(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x4781350", Offset = "0x4780750", VA = "0x184781350", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x4D87960", Offset = "0x4D86D60", VA = "0x184D87960", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x4D88590", Offset = "0x4D87990", VA = "0x184D88590")]
		private void OMCGPHJKBHJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x4D884F0", Offset = "0x4D878F0", VA = "0x184D884F0")]
		private void NIIFAIKAHLE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x4D88720", Offset = "0x4D87B20", VA = "0x184D88720", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private readonly AACIGADGGNN<TKey, TValue> ABFALEEGJAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private readonly IDictionary<TKey, TValue> JHEPDGMAEMP;

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public int GMILMIAEFMI
	{
		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x4BDE630", Offset = "0x4BDDA30", VA = "0x184BDE630", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public bool HMHCPPJANGM
	{
		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x9DE710", Offset = "0x9DDB10", VA = "0x1809DE710", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public TValue JODHLAKLPCM
	{
		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x4BDE8E0", Offset = "0x4BDDCE0", VA = "0x184BDE8E0", Slot = "4")]
		get
		{
			return (TValue)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x4BDEB70", Offset = "0x4BDDF70", VA = "0x184BDEB70", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public ICollection<TKey> JPBJOHHNBHM
	{
		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x4BDE930", Offset = "0x4BDDD30", VA = "0x184BDE930", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public ICollection<TValue> BDMOHMNBJNC
	{
		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x4BDEA50", Offset = "0x4BDDE50", VA = "0x184BDEA50", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600018C")]
	[Cpp2IlInjected.Address(RVA = "0x4BDE570", Offset = "0x4BDD970", VA = "0x184BDE570")]
	public JDBJDCHGLEP(AACIGADGGNN<TKey, TValue> ABFALEEGJAB, [Optional] IDictionary<TKey, TValue>? JHEPDGMAEMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(RVA = "0x4BDC6A0", Offset = "0x4BDBAA0", VA = "0x184BDC6A0", Slot = "15")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000190")]
	[Cpp2IlInjected.Address(RVA = "0x4BDD410", Offset = "0x4BDC810", VA = "0x184BDD410")]
	public void KLKJNIGBEJL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(RVA = "0x4BDBEA0", Offset = "0x4BDB2A0", VA = "0x184BDBEA0", Slot = "9")]
	public void Add(TKey DJBLFBEBKGO, TValue FFOEEMKIKJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0x4BDB970", Offset = "0x4BDAD70", VA = "0x184BDB970")]
	public void AKLFLEEJOBE(TKey DJBLFBEBKGO, TValue FFOEEMKIKJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(RVA = "0x4BDD030", Offset = "0x4BDC430", VA = "0x184BDD030")]
	public void GGDHGDLABKP(TKey DJBLFBEBKGO, TValue FFOEEMKIKJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000194")]
	[Cpp2IlInjected.Address(RVA = "0x4BDC0D0", Offset = "0x4BDB4D0", VA = "0x184BDC0D0")]
	public void BDFADDLMFGH(TKey DJBLFBEBKGO, TValue FFOEEMKIKJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000195")]
	[Cpp2IlInjected.Address(RVA = "0x4BDD740", Offset = "0x4BDCB40", VA = "0x184BDD740")]
	public void OKCFFLMGCHF(TKey DJBLFBEBKGO, TValue FFOEEMKIKJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(RVA = "0x4BDDBB0", Offset = "0x4BDCFB0", VA = "0x184BDDBB0", Slot = "14")]
	void ICollection<KeyValuePair<TKey, TValue>>.Add(KeyValuePair<TKey, TValue> MGCEJOCCONP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x4BDDDA0", Offset = "0x4BDD1A0", VA = "0x184BDDDA0", Slot = "16")]
	bool ICollection<KeyValuePair<TKey, TValue>>.Contains(KeyValuePair<TKey, TValue> MGCEJOCCONP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(RVA = "0x4BDE100", Offset = "0x4BDD500", VA = "0x184BDE100", Slot = "18")]
	bool ICollection<KeyValuePair<TKey, TValue>>.Remove(KeyValuePair<TKey, TValue> MGCEJOCCONP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0x4BDC730", Offset = "0x4BDBB30", VA = "0x184BDC730", Slot = "8")]
	public bool ContainsKey(TKey DJBLFBEBKGO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(RVA = "0x4BDBB00", Offset = "0x4BDAF00", VA = "0x184BDBB00")]
	public bool APMJBPJLDIL(TKey DJBLFBEBKGO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(RVA = "0x4BDC570", Offset = "0x4BDB970", VA = "0x184BDC570")]
	public bool CFKPFLBEDHP(TKey DJBLFBEBKGO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(RVA = "0x4BDD910", Offset = "0x4BDCD10", VA = "0x184BDD910", Slot = "10")]
	public bool Remove(TKey DJBLFBEBKGO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0x4BDE300", Offset = "0x4BDD700", VA = "0x184BDE300", Slot = "11")]
	public bool TryGetValue(TKey DJBLFBEBKGO, [Out] TValue FFOEEMKIKJO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(RVA = "0x4BDC8A0", Offset = "0x4BDBCA0", VA = "0x184BDC8A0", Slot = "17")]
	public void CopyTo(KeyValuePair<TKey, TValue>[] LLPLHOOOAEB, int KIMBCLMGPOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(RVA = "0x4BDE2C0", Offset = "0x4BDD6C0", VA = "0x184BDE2C0", Slot = "20")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A0")]
	[Cpp2IlInjected.Address(RVA = "0x4BDD1C0", Offset = "0x4BDC5C0", VA = "0x184BDD1C0", Slot = "19")]
	[IteratorStateMachine(typeof(JDBJDCHGLEP<, >.KLJOJIJLBPN))]
	public IEnumerator<KeyValuePair<TKey, TValue>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x4BDD320", Offset = "0x4BDC720", VA = "0x184BDD320", Slot = "21")]
	public bool HOJCINCDFLD()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(RVA = "0x4BDD630", Offset = "0x4BDCA30", VA = "0x184BDD630")]
	private TValue NBHEDBEBKKN(TKey DJBLFBEBKGO)
	{
		return (TValue)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
public interface NIKLPCOAPNM : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000042")]
	string CBLOFHHHMKC
	{
		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
public interface IFJOKEIDJIN
{
	[Cpp2IlInjected.Token(Token = "0x60001AE")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool HOJCINCDFLD();
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
public interface AACIGADGGNN<TKey, TVal> : IDictionary<TKey, TVal>, ICollection<KeyValuePair<TKey, TVal>>, IEnumerable<KeyValuePair<TKey, TVal>>, IEnumerable, IFJOKEIDJIN
{
}
[Cpp2IlInjected.Token(Token = "0x2000065")]
[DefaultMember("Item")]
public sealed class GDHFCHKNKML<TKey, TVal> : AACIGADGGNN<TKey, TVal>, IDictionary<TKey, TVal>, ICollection<KeyValuePair<TKey, TVal>>, IEnumerable<KeyValuePair<TKey, TVal>>, IEnumerable, IFJOKEIDJIN where TKey : notnull where TVal : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000066")]
	public delegate int AFHJOOIPMOA(TKey DJBLFBEBKGO, TVal FFOEEMKIKJO);

	[Cpp2IlInjected.Token(Token = "0x2000067")]
	public delegate void CPGEBDJOKID(TKey DJBLFBEBKGO, TVal FFOEEMKIKJO, GAOHBELNOKN JKODLOFLBMK);

	[Cpp2IlInjected.Token(Token = "0x2000068")]
	private class MGAEHKKMNHP
	{
		[Cpp2IlInjected.Token(Token = "0x1700004B")]
		public TKey KKGMNHPHOBN
		{
			[Cpp2IlInjected.Token(Token = "0x60001D9")]
			[Cpp2IlInjected.Address(RVA = "0xB9CB20", Offset = "0xB9BF20", VA = "0x180B9CB20")]
			[CompilerGenerated]
			get
			{
				return (TKey)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004C")]
		public TVal HDKOPKMNJCH
		{
			[Cpp2IlInjected.Token(Token = "0x60001DA")]
			[Cpp2IlInjected.Address(RVA = "0xB35CF0", Offset = "0xB350F0", VA = "0x180B35CF0")]
			[CompilerGenerated]
			get
			{
				return (TVal)null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001DB")]
			[Cpp2IlInjected.Address(RVA = "0xBE45A0", Offset = "0xBE39A0", VA = "0x180BE45A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004D")]
		public int BFPJLGPCCAO
		{
			[Cpp2IlInjected.Token(Token = "0x60001DC")]
			[Cpp2IlInjected.Address(RVA = "0xC69A20", Offset = "0xC68E20", VA = "0x180C69A20")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60001DD")]
			[Cpp2IlInjected.Address(RVA = "0xE46E60", Offset = "0xE46260", VA = "0x180E46E60")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004E")]
		public DateTimeOffset LIKBJKDPFDK
		{
			[Cpp2IlInjected.Token(Token = "0x60001DE")]
			[Cpp2IlInjected.Address(RVA = "0xE66620", Offset = "0xE65A20", VA = "0x180E66620")]
			[CompilerGenerated]
			get
			{
				return default(DateTimeOffset);
			}
			[Cpp2IlInjected.Token(Token = "0x60001DF")]
			[Cpp2IlInjected.Address(RVA = "0xE66630", Offset = "0xE65A30", VA = "0x180E66630")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x5029B40", Offset = "0x5028F40", VA = "0x185029B40")]
		public MGAEHKKMNHP(TKey DJBLFBEBKGO, TVal PCJCDFNKKKE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006A")]
	[CompilerGenerated]
	private sealed class HOPDKDLAEDF : IEnumerator<KeyValuePair<TKey, TVal>>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		private KeyValuePair<TKey, TVal> <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		public GDHFCHKNKML<TKey, TVal> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		private LinkedList<MGAEHKKMNHP>.Enumerator <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x1700004F")]
		KeyValuePair<TKey, TVal> IEnumerator<KeyValuePair<TKey, TVal>>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001E9")]
			[Cpp2IlInjected.Address(RVA = "0x1838860", Offset = "0x1837C60", VA = "0x181838860", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return default(KeyValuePair<TKey, TVal>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000050")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001EB")]
			[Cpp2IlInjected.Address(RVA = "0x4923460", Offset = "0x4922860", VA = "0x184923460", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x999C60", Offset = "0x999060", VA = "0x180999C60")]
		[DebuggerHidden]
		public HOPDKDLAEDF(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(RVA = "0x477BBD0", Offset = "0x477AFD0", VA = "0x18477BBD0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0x49219F0", Offset = "0x4920DF0", VA = "0x1849219F0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(RVA = "0x4922EE0", Offset = "0x49222E0", VA = "0x184922EE0")]
		private void OMCGPHJKBHJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(RVA = "0x49232D0", Offset = "0x49226D0", VA = "0x1849232D0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400009A")]
	public const int ODONCBOMANJ = -1;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private readonly Dictionary<TKey, LinkedListNode<MGAEHKKMNHP>> KKIMKKBNHLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private readonly LinkedList<MGAEHKKMNHP> LDKHFINJMDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private readonly AFHJOOIPMOA? MEOOEKANMLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private readonly TimeSpan LIEGCGDEIEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private readonly CPGEBDJOKID? HJOFJNMLEPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	private readonly EJMLPOJDKGC BIMMPEIIIPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	private bool EMPJMADFNPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	private readonly List<TKey> GJELAJOELML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	private readonly List<TVal> DNNJGAIIMJF;

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public int DIPAECOCKOI
	{
		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x9A40C0", Offset = "0x9A34C0", VA = "0x1809A40C0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	internal int INEOJCNAKKK
	{
		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0xC71970", Offset = "0xC70D70", VA = "0x180C71970")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0xD9ABF0", Offset = "0xD99FF0", VA = "0x180D9ABF0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	public int GMILMIAEFMI
	{
		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x4814FE0", Offset = "0x48143E0", VA = "0x184814FE0", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	internal int NOOLHGJKMCJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x4812530", Offset = "0x4811930", VA = "0x184812530")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	public ICollection<TVal> BDMOHMNBJNC
	{
		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x4815120", Offset = "0x4814520", VA = "0x184815120", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	ICollection<TKey> IDictionary<TKey, TVal>.OBKIJAHPMKH
	{
		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x4813340", Offset = "0x4812740", VA = "0x184813340", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	public bool HMHCPPJANGM
	{
		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x9DE710", Offset = "0x9DDB10", VA = "0x1809DE710", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	public TVal JODHLAKLPCM
	{
		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x4815070", Offset = "0x4814470", VA = "0x184815070", Slot = "4")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x48151D0", Offset = "0x48145D0", VA = "0x1848151D0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001B0")]
	[Cpp2IlInjected.Address(RVA = "0x480D670", Offset = "0x480CA70", VA = "0x18480D670")]
	private bool EIJDAKFOJDE(int HDAIOJEADNO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B7")]
	[Cpp2IlInjected.Address(RVA = "0x480D6C0", Offset = "0x480CAC0", VA = "0x18480D6C0")]
	private void FJHIDKBBPKG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B9")]
	[Cpp2IlInjected.Address(RVA = "0x4814790", Offset = "0x4813B90", VA = "0x184814790")]
	public GDHFCHKNKML(int HDAIOJEADNO, [Optional] AFHJOOIPMOA? MEOOEKANMLH, [Optional] IEqualityComparer<TKey>? EBDAAEFHDKB, [Optional] CPGEBDJOKID? HJOFJNMLEPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BA")]
	[Cpp2IlInjected.Address(RVA = "0x4814A30", Offset = "0x4813E30", VA = "0x184814A30")]
	public GDHFCHKNKML(TimeSpan LIEGCGDEIEA, [Optional] IEqualityComparer<TKey>? EBDAAEFHDKB, [Optional] CPGEBDJOKID? HJOFJNMLEPJ, [Optional] EJMLPOJDKGC? BIMMPEIIIPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BB")]
	[Cpp2IlInjected.Address(RVA = "0x48139F0", Offset = "0x4812DF0", VA = "0x1848139F0")]
	public GDHFCHKNKML(int HDAIOJEADNO, TimeSpan LIEGCGDEIEA, [Optional] IEqualityComparer<TKey>? EBDAAEFHDKB, [Optional] CPGEBDJOKID? HJOFJNMLEPJ, [Optional] EJMLPOJDKGC? BIMMPEIIIPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BC")]
	[Cpp2IlInjected.Address(RVA = "0x4813ED0", Offset = "0x48132D0", VA = "0x184813ED0")]
	public GDHFCHKNKML(int HDAIOJEADNO, AFHJOOIPMOA? MEOOEKANMLH, TimeSpan LIEGCGDEIEA, [Optional] IEqualityComparer<TKey>? EBDAAEFHDKB, [Optional] CPGEBDJOKID? HJOFJNMLEPJ, [Optional] EJMLPOJDKGC? BIMMPEIIIPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BD")]
	[Cpp2IlInjected.Address(RVA = "0x480E570", Offset = "0x480D970", VA = "0x18480E570", Slot = "21")]
	public bool HOJCINCDFLD()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001BE")]
	[Cpp2IlInjected.Address(RVA = "0x4811E40", Offset = "0x4811240", VA = "0x184811E40", Slot = "22")]
	public bool KOABHKGAHBJ(int MNDMOIHIBEI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001BF")]
	[Cpp2IlInjected.Address(RVA = "0x4810230", Offset = "0x480F630", VA = "0x184810230")]
	private bool KEJOMHLKFOB(int MNDMOIHIBEI, GAOHBELNOKN JKODLOFLBMK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C2")]
	[Cpp2IlInjected.Address(RVA = "0x480EA70", Offset = "0x480DE70", VA = "0x18480EA70")]
	public void JFGGMENNDNP(TKey DJBLFBEBKGO, TVal FFOEEMKIKJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C3")]
	[Cpp2IlInjected.Address(RVA = "0x480AC80", Offset = "0x480A080", VA = "0x18480AC80", Slot = "14")]
	public void Add(KeyValuePair<TKey, TVal> MGCEJOCCONP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C4")]
	[Cpp2IlInjected.Address(RVA = "0x480ACD0", Offset = "0x480A0D0", VA = "0x18480ACD0", Slot = "9")]
	public void Add(TKey DJBLFBEBKGO, TVal FFOEEMKIKJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C5")]
	[Cpp2IlInjected.Address(RVA = "0x480C830", Offset = "0x480BC30", VA = "0x18480C830", Slot = "8")]
	public bool ContainsKey(TKey DJBLFBEBKGO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C6")]
	[Cpp2IlInjected.Address(RVA = "0x4812DE0", Offset = "0x48121E0", VA = "0x184812DE0", Slot = "16")]
	bool ICollection<KeyValuePair<TKey, TVal>>.Contains(KeyValuePair<TKey, TVal> MGCEJOCCONP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C7")]
	[Cpp2IlInjected.Address(RVA = "0x4812CD0", Offset = "0x48120D0", VA = "0x184812CD0", Slot = "10")]
	public bool Remove(TKey DJBLFBEBKGO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C8")]
	[Cpp2IlInjected.Address(RVA = "0x4813200", Offset = "0x4812600", VA = "0x184813200", Slot = "18")]
	bool ICollection<KeyValuePair<TKey, TVal>>.Remove(KeyValuePair<TKey, TVal> MGCEJOCCONP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C9")]
	[Cpp2IlInjected.Address(RVA = "0x4811990", Offset = "0x4810D90", VA = "0x184811990")]
	private bool KJOCGPOLNFE(TKey DJBLFBEBKGO, [Out] TVal FFOEEMKIKJO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(RVA = "0x480E960", Offset = "0x480DD60", VA = "0x18480E960")]
	private TVal IOLMGDEDCOJ(TKey IMDENDBDIKN)
	{
		return (TVal)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x48135E0", Offset = "0x48129E0", VA = "0x1848135E0", Slot = "11")]
	public bool TryGetValue(TKey IMDENDBDIKN, [Out] TVal FFOEEMKIKJO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(RVA = "0x480C640", Offset = "0x480BA40", VA = "0x18480C640", Slot = "15")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(RVA = "0x480CC10", Offset = "0x480C010", VA = "0x18480CC10", Slot = "17")]
	public void CopyTo(KeyValuePair<TKey, TVal>[] LLPLHOOOAEB, int KIMBCLMGPOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CE")]
	[Cpp2IlInjected.Address(RVA = "0x4812820", Offset = "0x4811C20", VA = "0x184812820")]
	private void PCFAGDEGKCB(TKey DJBLFBEBKGO, TVal PCJCDFNKKKE, GAOHBELNOKN JKODLOFLBMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CF")]
	[Cpp2IlInjected.Address(RVA = "0x4812210", Offset = "0x4811610", VA = "0x184812210")]
	private bool NHHPKGGLCPB(MGAEHKKMNHP ECBAJKPMIPA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D0")]
	[Cpp2IlInjected.Address(RVA = "0x480B580", Offset = "0x480A980", VA = "0x18480B580")]
	private void BGJPPINHALG(LinkedListNode<MGAEHKKMNHP> OPNABDJAFLJ, TVal NHBPFAFPCOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D1")]
	[Cpp2IlInjected.Address(RVA = "0x480F1A0", Offset = "0x480E5A0", VA = "0x18480F1A0")]
	private void JHAAOHPGICL(TKey DJBLFBEBKGO, TVal FFOEEMKIKJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D2")]
	[Cpp2IlInjected.Address(RVA = "0x480DF10", Offset = "0x480D310", VA = "0x18480DF10")]
	private void HIONDKLIFKC(MGAEHKKMNHP ECBAJKPMIPA, TVal NHBPFAFPCOO, int KDGGAJDGKDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D3")]
	[Cpp2IlInjected.Address(RVA = "0x480DC40", Offset = "0x480D040", VA = "0x18480DC40", Slot = "19")]
	[IteratorStateMachine(typeof(GDHFCHKNKML<, >.HOPDKDLAEDF))]
	public IEnumerator<KeyValuePair<TKey, TVal>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D4")]
	[Cpp2IlInjected.Address(RVA = "0x4813390", Offset = "0x4812790", VA = "0x184813390", Slot = "20")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
public enum GAOHBELNOKN : byte
{
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	Evicted,
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	RemovedViaRemove,
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	RemovedViaClear,
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	Overwritten
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
public class EMAMDJDJCPC<TKey> : Exception where TKey : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	public readonly TKey PGPECFNHINN;

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(RVA = "0x42C9120", Offset = "0x42C8520", VA = "0x1842C9120")]
	public EMAMDJDJCPC(TKey ECKNEFMHDOF, Exception HIFFMIIALED)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006D")]
public class PIGFFPDILJC : ArgumentException
{
	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0x6B26AD0", Offset = "0x6B25ED0", VA = "0x186B26AD0")]
	public PIGFFPDILJC(string DAMFJFKKFBI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006E")]
public class NJGLBGPNBMB<TId, TResource> : IEnumerable<(TId, Task<TResource>, int)>, IEnumerable where TId : notnull where TResource : notnull
{
	[Cpp2IlInjected.Token(Token = "0x200006F")]
	[CompilerGenerated]
	private sealed class FKJLJPAEPPN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		public Func<TId, CancellationToken, Task<TResource>> factory;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		public NJGLBGPNBMB<TId, TResource> <>4__this;

		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0x9A2500", Offset = "0x9A1900", VA = "0x1809A2500")]
		public FKJLJPAEPPN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0x474A880", Offset = "0x4749C80", VA = "0x18474A880")]
		internal Task<TResource> HGBGDNLOCPJ(TId _id)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000070")]
	[CompilerGenerated]
	private struct BEKGHJDBHLD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		public Task<TResource> task;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		public NJGLBGPNBMB<TId, TResource> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		private TaskAwaiter<TResource> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0x5E56900", Offset = "0x5E55D00", VA = "0x185E56900", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0x5E56C40", Offset = "0x5E56040", VA = "0x185E56C40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000071")]
	[CompilerGenerated]
	private struct IBJBOAJFKDP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		public Task<TResource> task;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		public Dictionary<Task<TResource>, CancellationTokenSource> cancellationTokenSources;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		public CancellationTokenSource cts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		private TaskAwaiter<TResource> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0x49D66C0", Offset = "0x49D5AC0", VA = "0x1849D66C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(RVA = "0x49D6A40", Offset = "0x49D5E40", VA = "0x1849D6A40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	private readonly PMGJGICKNDP<TId, Task<TResource>> AGHDHGECBDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	private readonly Dictionary<Task<TResource>, CancellationTokenSource> OGGMCHGAKND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	private readonly Func<TId, CancellationToken, Task<TResource>>? CABJPPKBEEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	private readonly Action<TResource>? LMHAIPPLPPH;

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x50D68A0", Offset = "0x50D5CA0", VA = "0x1850D68A0")]
	public NJGLBGPNBMB(int OPFOLNCOPBG = 0, [Optional] IEqualityComparer<TId>? NLPOHGJBCNK, [Optional] Func<TId, CancellationToken, Task<TResource>>? EBOPNJLKNFL, [Optional] Action<TResource>? CNGPFCCJGHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(RVA = "0x50D64F0", Offset = "0x50D58F0", VA = "0x1850D64F0")]
	public OHGHKHJHGOP<Task<TResource>> NLKEOLDKCDH(TId NCJKGMLAKGH, [Optional] Func<TId, CancellationToken, Task<TResource>>? EBOPNJLKNFL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(RVA = "0x50D5980", Offset = "0x50D4D80", VA = "0x1850D5980")]
	private void DDHGIEAEBOC(Task<TResource> NHNFPALEEPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(RVA = "0x50D53B0", Offset = "0x50D47B0", VA = "0x1850D53B0")]
	[AsyncStateMachine(typeof(NJGLBGPNBMB<, >.BEKGHJDBHLD))]
	private Task AAKOHFKBHCF(Task<TResource> NHNFPALEEPM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(RVA = "0x426E1A0", Offset = "0x426D5A0", VA = "0x18426E1A0")]
	public void EIKMHJEEHOI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(RVA = "0x50D5530", Offset = "0x50D4930", VA = "0x1850D5530")]
	public PMGJGICKNDP<TId, Task<TResource>>.CKFGIEKMDOM DBEEDGEHMMA()
	{
		return default(PMGJGICKNDP<TId, Task<TResource>>.CKFGIEKMDOM);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(RVA = "0x50D66D0", Offset = "0x50D5AD0", VA = "0x1850D66D0", Slot = "4")]
	private IEnumerator<(TId, Task<TResource>, int)> System.Collections.Generic.IEnumerable<(TIdId,System.Threading.Tasks.Task<TResource>LoadResourceTask,System.Int32RefCount)>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(RVA = "0x50D66D0", Offset = "0x50D5AD0", VA = "0x1850D66D0", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(RVA = "0x50D5D00", Offset = "0x50D5100", VA = "0x1850D5D00")]
	[AsyncStateMachine(typeof(NJGLBGPNBMB<, >.IBJBOAJFKDP))]
	[CompilerGenerated]
	internal static Task JJNMMCFBEMD(Task<TResource> NHNFPALEEPM, CancellationTokenSource NKPAICCCLOJ, Dictionary<Task<TResource>, CancellationTokenSource> EHGHPDMDHMO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000072")]
public class PMGJGICKNDP<TKey, TValue> : IEnumerable<(TKey, TValue, int)>, IEnumerable where TKey : notnull where TValue : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000073")]
	private sealed class EDLNAGCENGJ : IEquatable<EDLNAGCENGJ>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		public readonly TValue HDKOPKMNJCH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		public int ODCCEEPCJPK;

		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(RVA = "0x1080720", Offset = "0x107FB20", VA = "0x181080720")]
		public EDLNAGCENGJ(TValue FFOEEMKIKJO, int HCHLCNCEOFK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(RVA = "0x42B50B0", Offset = "0x42B44B0", VA = "0x1842B50B0", Slot = "4")]
		public bool Equals(EDLNAGCENGJ? KNCKFHOKGJM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0x42B5010", Offset = "0x42B4410", VA = "0x1842B5010", Slot = "0")]
		public override bool Equals(object? BLFGIKOAKOL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000207")]
		[Cpp2IlInjected.Address(RVA = "0x42B5260", Offset = "0x42B4660", VA = "0x1842B5260", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000074")]
	public struct CKFGIEKMDOM : IEnumerator<(TKey, TValue, int)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		private Dictionary<TKey, EDLNAGCENGJ>.Enumerator MLBBCBCPJFG;

		[Cpp2IlInjected.Token(Token = "0x17000051")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600020C")]
			[Cpp2IlInjected.Address(RVA = "0x6403050", Offset = "0x6402450", VA = "0x186403050", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000052")]
		public (TKey Key, TValue Value, int RefCount) JKNLEFEANEI
		{
			[Cpp2IlInjected.Token(Token = "0x600020D")]
			[Cpp2IlInjected.Address(RVA = "0x6403410", Offset = "0x6402810", VA = "0x186403410", Slot = "4")]
			get
			{
				return default((TKey, TValue, int));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000208")]
		[Cpp2IlInjected.Address(RVA = "0x6403270", Offset = "0x6402670", VA = "0x186403270")]
		public CKFGIEKMDOM(PMGJGICKNDP<TKey, TValue> JLLDPNEPEEK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000209")]
		[Cpp2IlInjected.Address(RVA = "0x6402C10", Offset = "0x6402010", VA = "0x186402C10", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020A")]
		[Cpp2IlInjected.Address(RVA = "0x6402C50", Offset = "0x6402050", VA = "0x186402C50", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600020B")]
		[Cpp2IlInjected.Address(RVA = "0x6402D10", Offset = "0x6402110", VA = "0x186402D10", Slot = "8")]
		public void Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000075")]
	[CompilerGenerated]
	private sealed class INJAKOKFNDK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		public PMGJGICKNDP<TKey, TValue> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		public TKey key;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		public EDLNAGCENGJ refCountedValue;

		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0x9A2500", Offset = "0x9A1900", VA = "0x1809A2500")]
		public INJAKOKFNDK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0x49FD780", Offset = "0x49FCB80", VA = "0x1849FD780")]
		internal void HGBGDNLOCPJ()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	private readonly Dictionary<TKey, EDLNAGCENGJ> DLDDMLNNPAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	private readonly Func<TKey, TValue>? OEAMCDLLBFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	private readonly Action<TValue>? HNBHNEGFLKA;

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x5322CC0", Offset = "0x53220C0", VA = "0x185322CC0")]
	public PMGJGICKNDP(int OPFOLNCOPBG = 0, [Optional] IEqualityComparer<TKey>? EBDAAEFHDKB, [Optional] Func<TKey, TValue>? PHBAINGMPJM, [Optional] Action<TValue>? IEPDDECJCHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(RVA = "0x53227E0", Offset = "0x5321BE0", VA = "0x1853227E0")]
	public OHGHKHJHGOP<TValue> NLKEOLDKCDH(TKey DJBLFBEBKGO, [Optional] Func<TKey, TValue>? NEOIMCIEMDA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(RVA = "0x5321D70", Offset = "0x5321170", VA = "0x185321D70")]
	private void FEMKONHLAGL(TKey DJBLFBEBKGO, EDLNAGCENGJ ABDCGJOLLLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000200")]
	[Cpp2IlInjected.Address(RVA = "0x5321480", Offset = "0x5320880", VA = "0x185321480")]
	public void EIKMHJEEHOI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000201")]
	[Cpp2IlInjected.Address(RVA = "0x53213C0", Offset = "0x53207C0", VA = "0x1853213C0")]
	public CKFGIEKMDOM DBEEDGEHMMA()
	{
		return default(CKFGIEKMDOM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(RVA = "0x5322AF0", Offset = "0x5321EF0", VA = "0x185322AF0", Slot = "4")]
	private IEnumerator<(TKey, TValue, int)> System.Collections.Generic.IEnumerable<(TKeyKey,TValueValue,System.Int32RefCount)>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(RVA = "0x5322AF0", Offset = "0x5321EF0", VA = "0x185322AF0", Slot = "5")]
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
