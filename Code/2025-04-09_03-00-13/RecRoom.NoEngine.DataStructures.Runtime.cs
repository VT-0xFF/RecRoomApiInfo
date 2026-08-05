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
		[Cpp2IlInjected.Address(RVA = "0x9D4820", Offset = "0x9D3C20", VA = "0x1809D4820")]
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
		[Cpp2IlInjected.Address(RVA = "0x79F1830", Offset = "0x79F0C30", VA = "0x1879F1830")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x9D5490", Offset = "0x9D4890", VA = "0x1809D5490")]
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
		[Cpp2IlInjected.Address(RVA = "0x9D54D0", Offset = "0x9D48D0", VA = "0x1809D54D0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public abstract class IDHBJLFNPFK
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x9B8350", Offset = "0x9B7750", VA = "0x1809B8350")]
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
		[Cpp2IlInjected.Address(RVA = "0x4C8FCF0", Offset = "0x4C8F0F0", VA = "0x184C8FCF0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x4C90710", Offset = "0x4C8FB10", VA = "0x184C90710")]
	protected JOFKANMKADA(bool IJDDHHGFLMK, bool PMMHICPABLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x4C90670", Offset = "0x4C8FA70", VA = "0x184C90670")]
	protected bool PBFIJCPFKLF()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x4C90550", Offset = "0x4C8F950", VA = "0x184C90550")]
	protected void OKKPDLLGNFD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x4C8FF00", Offset = "0x4C8F300", VA = "0x184C8FF00")]
	protected void IDCLBHDMBMO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x3BA6F00", Offset = "0x3BA6300", VA = "0x183BA6F00")]
	private static void KPLHIAAPOEI<U>(List<U>? CEFIHBLEFNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x4C90340", Offset = "0x4C8F740", VA = "0x184C90340", Slot = "4")]
	public void JJBKLNLGAIJ(T IOPCFKOHPBF, bool NBOBCBNKKKD = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x4C90170", Offset = "0x4C8F570", VA = "0x184C90170", Slot = "5")]
	public void JEBJOEBLLEI(T IOPCFKOHPBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x4C8FD50", Offset = "0x4C8F150", VA = "0x184C8FD50")]
	public void CJEMNCEDADJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public sealed class OPNNLJDPBAB : JOFKANMKADA<Action>
{
	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x79F23F0", Offset = "0x79F17F0", VA = "0x1879F23F0")]
	public OPNNLJDPBAB(bool IJDDHHGFLMK = false, bool PMMHICPABLF = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x79F2130", Offset = "0x79F1530", VA = "0x1879F2130")]
	public void HKANHPMMIAO()
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x79F2330", Offset = "0x79F1730", VA = "0x1879F2330")]
	public static OPNNLJDPBAB NEOOCHPFDCF(OPNNLJDPBAB LGGJKGFGJMC, Action IOPCFKOHPBF)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x79F2390", Offset = "0x79F1790", VA = "0x1879F2390")]
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
	[Cpp2IlInjected.Address(RVA = "0x42E27A0", Offset = "0x42E1BA0", VA = "0x1842E27A0")]
	public GLDBGNIANKN(bool IJDDHHGFLMK = false, bool PMMHICPABLF = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x4866900", Offset = "0x4865D00", VA = "0x184866900")]
	public void HKANHPMMIAO(T OOLNPDLPIEB)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x48678F0", Offset = "0x4866CF0", VA = "0x1848678F0")]
	public static GLDBGNIANKN<T> NEOOCHPFDCF(GLDBGNIANKN<T> LGGJKGFGJMC, Action<T> IOPCFKOHPBF)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x4867990", Offset = "0x4866D90", VA = "0x184867990")]
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
	[Cpp2IlInjected.Address(RVA = "0x42E27A0", Offset = "0x42E1BA0", VA = "0x1842E27A0")]
	public APHAPGEAMFF(bool IJDDHHGFLMK = false, bool PMMHICPABLF = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x4A007E0", Offset = "0x49FFBE0", VA = "0x184A007E0")]
	public void HKANHPMMIAO(T OOLNPDLPIEB, U OJOOOBBLFNO)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x48678F0", Offset = "0x4866CF0", VA = "0x1848678F0")]
	public static APHAPGEAMFF<T, U> NEOOCHPFDCF(APHAPGEAMFF<T, U> LGGJKGFGJMC, Action<T, U> IOPCFKOHPBF)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x4867990", Offset = "0x4866D90", VA = "0x184867990")]
	public static APHAPGEAMFF<T, U> PMIHMDGCMLK(APHAPGEAMFF<T, U> LGGJKGFGJMC, Action<T, U> IOPCFKOHPBF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public sealed class CJBDHFJKABF<T, U, V> : JOFKANMKADA<Action<T, U, V>> where T : notnull where U : notnull where V : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x42E27A0", Offset = "0x42E1BA0", VA = "0x1842E27A0")]
	public CJBDHFJKABF(bool IJDDHHGFLMK = false, bool PMMHICPABLF = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x63F4310", Offset = "0x63F3710", VA = "0x1863F4310")]
	public void HKANHPMMIAO(T OOLNPDLPIEB, U OJOOOBBLFNO, V CHAOGBKCKEH)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x48678F0", Offset = "0x4866CF0", VA = "0x1848678F0")]
	public static CJBDHFJKABF<T, U, V> NEOOCHPFDCF(CJBDHFJKABF<T, U, V> LGGJKGFGJMC, Action<T, U, V> IOPCFKOHPBF)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x4867990", Offset = "0x4866D90", VA = "0x184867990")]
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
	[Cpp2IlInjected.Address(RVA = "0x42E27A0", Offset = "0x42E1BA0", VA = "0x1842E27A0")]
	public PBBPHACIOEF(bool IJDDHHGFLMK = false, bool PMMHICPABLF = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x52EF840", Offset = "0x52EEC40", VA = "0x1852EF840")]
	public void HKANHPMMIAO(T OOLNPDLPIEB, U OJOOOBBLFNO, V CHAOGBKCKEH, W AMDFBELLJOH)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x48678F0", Offset = "0x4866CF0", VA = "0x1848678F0")]
	public static PBBPHACIOEF<T, U, V, W> NEOOCHPFDCF(PBBPHACIOEF<T, U, V, W> LGGJKGFGJMC, Action<T, U, V, W> IOPCFKOHPBF)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x4867990", Offset = "0x4866D90", VA = "0x184867990")]
	public static PBBPHACIOEF<T, U, V, W> PMIHMDGCMLK(PBBPHACIOEF<T, U, V, W> LGGJKGFGJMC, Action<T, U, V, W> IOPCFKOHPBF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public sealed class CPKJELMNNMK<T, U, V, W, X> : JOFKANMKADA<Action<T, U, V, W, X>>
{
	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x42E27A0", Offset = "0x42E1BA0", VA = "0x1842E27A0")]
	public CPKJELMNNMK(bool IJDDHHGFLMK = false, bool PMMHICPABLF = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x64DC730", Offset = "0x64DBB30", VA = "0x1864DC730")]
	public void HKANHPMMIAO(T OOLNPDLPIEB, U OJOOOBBLFNO, V CHAOGBKCKEH, W AMDFBELLJOH, X MEAMPLHPPKP)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x48678F0", Offset = "0x4866CF0", VA = "0x1848678F0")]
	public static CPKJELMNNMK<T, U, V, W, X> NEOOCHPFDCF(CPKJELMNNMK<T, U, V, W, X> LGGJKGFGJMC, Action<T, U, V, W, X> IOPCFKOHPBF)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x4867990", Offset = "0x4866D90", VA = "0x184867990")]
	public static CPKJELMNNMK<T, U, V, W, X> PMIHMDGCMLK(CPKJELMNNMK<T, U, V, W, X> LGGJKGFGJMC, Action<T, U, V, W, X> IOPCFKOHPBF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public sealed class KHBBAOBIBLP<T, U, V, W, X, Y> : JOFKANMKADA<Action<T, U, V, W, X, Y>>
{
	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x42E27A0", Offset = "0x42E1BA0", VA = "0x1842E27A0")]
	public KHBBAOBIBLP(bool IJDDHHGFLMK = false, bool PMMHICPABLF = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x4D8F4F0", Offset = "0x4D8E8F0", VA = "0x184D8F4F0")]
	public void HKANHPMMIAO(T OOLNPDLPIEB, U OJOOOBBLFNO, V CHAOGBKCKEH, W AMDFBELLJOH, X MEAMPLHPPKP, Y KDELALKKKOF)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x48678F0", Offset = "0x4866CF0", VA = "0x1848678F0")]
	public static KHBBAOBIBLP<T, U, V, W, X, Y> NEOOCHPFDCF(KHBBAOBIBLP<T, U, V, W, X, Y> LGGJKGFGJMC, Action<T, U, V, W, X, Y> IOPCFKOHPBF)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x4867990", Offset = "0x4866D90", VA = "0x184867990")]
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
		[Cpp2IlInjected.Address(RVA = "0x48E0460", Offset = "0x48DF860", VA = "0x1848E0460")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public int DIPAECOCKOI
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x9A9220", Offset = "0x9A8620", VA = "0x1809A9220")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x48E1180", Offset = "0x48E0580", VA = "0x1848E1180")]
	public AJFMCKADLPL(int DBGIEJGJFKO, [Optional] GDHFCHKNKML<TKey, TVal>.AFHJOOIPMOA? MEOOEKANMLH, [Optional] IEqualityComparer<TKey>? EBDAAEFHDKB, [Optional] GDHFCHKNKML<TKey, TVal>.CPGEBDJOKID? HJOFJNMLEPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x48E0E20", Offset = "0x48E0220", VA = "0x1848E0E20")]
	public void NOKIHEFAJEB(TKey DJBLFBEBKGO, TVal FFOEEMKIKJO, bool JINCPPLMAIJ = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x48E0040", Offset = "0x48DF440", VA = "0x1848E0040")]
	public bool DJBLIHGNADP(TKey DJBLFBEBKGO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x48DFE90", Offset = "0x48DF290", VA = "0x1848DFE90")]
	public bool BGPIDOLLEKE(TKey IMDENDBDIKN, [Out] TVal FFOEEMKIKJO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x48E01A0", Offset = "0x48DF5A0", VA = "0x1848E01A0")]
	private void HEGJIJBKKKF(TKey DJBLFBEBKGO, TVal FFOEEMKIKJO, int MNDMOIHIBEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x48E0C70", Offset = "0x48E0070", VA = "0x1848E0C70")]
	public bool MALKODFEJPJ(TKey DJBLFBEBKGO, TVal FFOEEMKIKJO, bool JINCPPLMAIJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x48DFF90", Offset = "0x48DF390", VA = "0x1848DFF90")]
	public void CJEMNCEDADJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x48E04B0", Offset = "0x48DF8B0", VA = "0x1848E04B0")]
	private void JGENILCBGHM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x48E0A10", Offset = "0x48DFE10", VA = "0x1848E0A10")]
	private bool LGEIOPGDBHJ(TKey DJBLFBEBKGO, GAOHBELNOKN JKODLOFLBMK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x48E0B50", Offset = "0x48DFF50", VA = "0x1848E0B50")]
	private void LIJFMNCJHOH(TKey DJBLFBEBKGO, TVal FFOEEMKIKJO, GAOHBELNOKN JKODLOFLBMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x48E1050", Offset = "0x48E0450", VA = "0x1848E1050")]
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
	[Cpp2IlInjected.Address(RVA = "0x9B2970", Offset = "0x9B1D70", VA = "0x1809B2970")]
	public DOGHOCFLAFM(Action JECALFIKEFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x79EFCB0", Offset = "0x79EF0B0", VA = "0x1879EFCB0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x339B040", Offset = "0x339A440", VA = "0x18339B040")]
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
		[Cpp2IlInjected.Address(RVA = "0x9A91D0", Offset = "0x9A85D0", VA = "0x1809A91D0")]
		[CompilerGenerated]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x521A550", Offset = "0x5219950", VA = "0x18521A550")]
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
		[Cpp2IlInjected.Address(RVA = "0x66D8720", Offset = "0x66D7B20", VA = "0x1866D8720")]
		get
		{
			return default(ReadOnlySequence<T>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public long EMKINJPKJHL
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x66D85D0", Offset = "0x66D79D0", VA = "0x1866D85D0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public bool KCBHPIPJOPL
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x66D8390", Offset = "0x66D7790", VA = "0x1866D8390")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x66D8DB0", Offset = "0x66D81B0", VA = "0x1866D8DB0")]
	public DHFNCGJPBDA(MMNJMCCEIJD<T> HCKMKBFOCMD, MMNJMCCEIJD<T> OMFHLFAFNPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x66D8A00", Offset = "0x66D7E00", VA = "0x1866D8A00")]
	public DHFNCGJPBDA(MMNJMCCEIJD<T> HCKMKBFOCMD, int GNPKFMEIDNL, MMNJMCCEIJD<T> OMFHLFAFNPI, int HGILLAMPJKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x66D8960", Offset = "0x66D7D60", VA = "0x1866D8960")]
	private DHFNCGJPBDA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x66D8690", Offset = "0x66D7A90", VA = "0x1866D8690", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x66D8230", Offset = "0x66D7630", VA = "0x1866D8230")]
	public T[] CNGHJFEEEPF()
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x66D8110", Offset = "0x66D7510", VA = "0x1866D8110")]
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
		[Cpp2IlInjected.Address(RVA = "0x9F4930", Offset = "0x9F3D30", VA = "0x1809F4930")]
		public static EKEKPGHKMDM HBLBJMFGHFK()
		{
			return default(EKEKPGHKMDM);
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x9ACA90", Offset = "0x9ABE90", VA = "0x1809ACA90", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x79F16F0", Offset = "0x79F0AF0", VA = "0x1879F16F0")]
	public static string BIKEBHNNGCB(Type HAFNBBNOLPO, [Optional] string? EDECGKJDLJG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x3739CD0", Offset = "0x37390D0", VA = "0x183739CD0")]
	public static string? BIKEBHNNGCB<T>([Optional] string? EDECGKJDLJG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x3739C50", Offset = "0x3739050", VA = "0x183739C50")]
	public static string? AOINLCMLAIL<T>([Optional] string? BNCBNCCIEDH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x9F4930", Offset = "0x9F3D30", VA = "0x1809F4930")]
	public static MLHHDOMPAAM NFJOOPGCIPO(string EDECGKJDLJG, string? BNCBNCCIEDH)
	{
		return default(MLHHDOMPAAM);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x9ACA90", Offset = "0x9ABE90", VA = "0x1809ACA90", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x9B8350", Offset = "0x9B7750", VA = "0x1809B8350")]
		public BNKBGJBEGIF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x6016520", Offset = "0x6015920", VA = "0x186016520")]
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
	[Cpp2IlInjected.Address(RVA = "0x79F0270", Offset = "0x79EF670", VA = "0x1879F0270")]
	public static Dictionary<string, EACGDNOMLJK> OJIKIDBCAGI(Type JBNOGMDBBDL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x34753A0", Offset = "0x34747A0", VA = "0x1834753A0")]
	public static Dictionary<string, EACGDNOMLJK> OJIKIDBCAGI<T>(Type JBNOGMDBBDL, IReadOnlyDictionary<T, string> JBPGLHLMGII) where T : notnull, Enum
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x3474C20", Offset = "0x3474020", VA = "0x183474C20")]
	public static Dictionary<string, EACGDNOMLJK> IBINIPEMFDD<T>(List<T> LDJBCGFILMH) where T : notnull, Enum
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x79EFEB0", Offset = "0x79EF2B0", VA = "0x1879EFEB0")]
	public static Dictionary<string, EACGDNOMLJK> IDKFEPKOMMO(Type JBNOGMDBBDL, EFENJPBJCOH JHHKEPHPIEH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x79EFCF0", Offset = "0x79EF0F0", VA = "0x1879EFCF0")]
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
		[Cpp2IlInjected.Address(RVA = "0x9ACAA0", Offset = "0x9ABEA0", VA = "0x1809ACAA0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x79EF100", Offset = "0x79EE500", VA = "0x1879EF100")]
	protected ADGPAJEIFGP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(Slot = "7")]
	public abstract string JIBLDGHIHFP();

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x79EEA50", Offset = "0x79EDE50", VA = "0x1879EEA50", Slot = "8")]
	public virtual string ECHJPNBCKLJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x79EEC90", Offset = "0x79EE090", VA = "0x1879EEC90", Slot = "9")]
	public void LFNEGAPCDIL(StringBuilder OMGOKFDHENG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x79EF0A0", Offset = "0x79EE4A0", VA = "0x1879EF0A0", Slot = "10")]
	public void NHONLPKKPFF(StringBuilder OMGOKFDHENG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x79EEB70", Offset = "0x79EDF70", VA = "0x1879EEB70", Slot = "11")]
	public void JDOJMNNLGDL(StringBuilder OMGOKFDHENG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x79EEF40", Offset = "0x79EE340", VA = "0x1879EEF40", Slot = "12")]
	public void LLIADOCJEAC(StringBuilder OMGOKFDHENG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x79EEAD0", Offset = "0x79EDED0", VA = "0x1879EEAD0")]
	public static void GDBJJCBACPN(StringBuilder OMGOKFDHENG, string MFHOBOOBKHB, string ABIKLBLEKNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x6A06B40", Offset = "0x6A05F40", VA = "0x186A06B40", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class NIBOMDHJAAI : Exception
{
	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x79F1730", Offset = "0x79F0B30", VA = "0x1879F1730")]
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
	[Cpp2IlInjected.Address(RVA = "0x4BEB350", Offset = "0x4BEA750", VA = "0x184BEB350")]
	private JAPPCHCKPAA([In] TErr IMFPGAEPEOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x4BEB280", Offset = "0x4BEA680", VA = "0x184BEB280")]
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
		[Cpp2IlInjected.Address(RVA = "0x9F4930", Offset = "0x9F3D30", VA = "0x1809F4930", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public override bool PNPJDGDLDIH
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x9F4930", Offset = "0x9F3D30", VA = "0x1809F4930", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public override bool KPGHGMFLLPE
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x9C55F0", Offset = "0x9C49F0", VA = "0x1809C55F0", Slot = "11")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public override long EMKINJPKJHL
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x79F1FE0", Offset = "0x79F13E0", VA = "0x1879F1FE0", Slot = "12")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public override long KLIFIKMFFNL
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x79F2050", Offset = "0x79F1450", VA = "0x1879F2050", Slot = "13")]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x79F20C0", Offset = "0x79F14C0", VA = "0x1879F20C0", Slot = "14")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x79F1F70", Offset = "0x79F1370", VA = "0x1879F1F70")]
	public ONDHKAHAPMB(HashAlgorithm APIKMAJFDAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x79F1DA0", Offset = "0x79F11A0", VA = "0x1879F1DA0", Slot = "35")]
	public override int Read(byte[] DAMDACDIHDN, int HGHGCNDALFP, int ECKHNAPCKGD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x79F1F40", Offset = "0x79F1340", VA = "0x1879F1F40", Slot = "38")]
	public override void Write(byte[] DAMDACDIHDN, int HGHGCNDALFP, int ECKHNAPCKGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x79F1E40", Offset = "0x79F1240", VA = "0x1879F1E40", Slot = "33")]
	public override long Seek(long HGHGCNDALFP, SeekOrigin NEGIIJCCHAL)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x79F1ED0", Offset = "0x79F12D0", VA = "0x1879F1ED0", Slot = "34")]
	public override void SetLength(long FFOEEMKIKJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x9ACA90", Offset = "0x9ABE90", VA = "0x1809ACA90", Slot = "23")]
	public override void Flush()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x79F1CD0", Offset = "0x79F10D0", VA = "0x1879F1CD0")]
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
		[Cpp2IlInjected.Address(RVA = "0xCC5610", Offset = "0xCC4A10", VA = "0x180CC5610")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x5087570", Offset = "0x5086970", VA = "0x185087570")]
	private static MMNJMCCEIJD<T> ANCJIAKCLEH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x5088730", Offset = "0x5087B30", VA = "0x185088730")]
	private static void IMEMDDBMBAH(MMNJMCCEIJD<T> GKFIHIFDCIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x4A05010", Offset = "0x4A04410", VA = "0x184A05010")]
	private MMNJMCCEIJD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x5088240", Offset = "0x5087640", VA = "0x185088240")]
	public static MMNJMCCEIJD<T> GNHEPACBJCH(ReadOnlyMemory<T> OICOPJMPHPI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x5088030", Offset = "0x5087430", VA = "0x185088030")]
	public static MMNJMCCEIJD<T> GNHEPACBJCH(IMemoryOwner<T> KIPNCKDBHPH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x5088CE0", Offset = "0x50880E0", VA = "0x185088CE0")]
	public static void LHBIEBGOHFD(MMNJMCCEIJD<T> HCKMKBFOCMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x5087DB0", Offset = "0x50871B0", VA = "0x185087DB0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x5087A20", Offset = "0x5086E20", VA = "0x185087A20")]
	public MMNJMCCEIJD<T> DEGBEBOMHAA(IMemoryOwner<T> KIPNCKDBHPH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x5088E20", Offset = "0x5088220", VA = "0x185088E20")]
	private void OPKMIMNNMDE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x50885E0", Offset = "0x50879E0", VA = "0x1850885E0")]
	private MMNJMCCEIJD<T> HANDLLACLGA(MMNJMCCEIJD<T> GKFIHIFDCIH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public class CDDLHGOPHPH : Exception
{
	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x79EF7A0", Offset = "0x79EEBA0", VA = "0x1879EF7A0")]
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
	[Cpp2IlInjected.Address(RVA = "0x4874770", Offset = "0x4873B70", VA = "0x184874770")]
	private GMNIIJHIMEI([In] TOk CFKMKCHBJDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x4874520", Offset = "0x4873920", VA = "0x184874520")]
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
		[Cpp2IlInjected.Address(RVA = "0x4D883D0", Offset = "0x4D877D0", VA = "0x184D883D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public bool LMIOLHACLIM
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x4D857C0", Offset = "0x4D84BC0", VA = "0x184D857C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x4D8B5E0", Offset = "0x4D8A9E0", VA = "0x184D8B5E0")]
	internal KGPHFOFOMPJ([In] TErr IMFPGAEPEOJ, [In] TOk CFKMKCHBJDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x4D853C0", Offset = "0x4D847C0", VA = "0x184D853C0")]
	public static KGPHFOFOMPJ<TOk, TErr> AAACLIDCHDJ([In] TErr IMFPGAEPEOJ)
	{
		return default(KGPHFOFOMPJ<TOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x4D87DD0", Offset = "0x4D871D0", VA = "0x184D87DD0")]
	public static KGPHFOFOMPJ<TOk, TErr> ILHOPILDHCK([In] TOk CFKMKCHBJDM)
	{
		return default(KGPHFOFOMPJ<TOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x3BA7E70", Offset = "0x3BA7270", VA = "0x183BA7E70")]
	public KGPHFOFOMPJ<TOk?, UErr?> JDBAGOIIDGN<UErr>()
	{
		return default(KGPHFOFOMPJ<TOk, UErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x3BA79F0", Offset = "0x3BA6DF0", VA = "0x183BA79F0")]
	public KGPHFOFOMPJ<UOk?, TErr?> DABOHFDDALG<UOk>()
	{
		return default(KGPHFOFOMPJ<UOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x3BA9390", Offset = "0x3BA8790", VA = "0x183BA9390")]
	public KGPHFOFOMPJ<UOk?, TErr?> LHOLLGDHFLI<UOk>()
	{
		return default(KGPHFOFOMPJ<UOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x3BA7D50", Offset = "0x3BA7150", VA = "0x183BA7D50")]
	public KGPHFOFOMPJ<TOk?, UErr?> FDHPOINJLND<UErr>()
	{
		return default(KGPHFOFOMPJ<TOk, UErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x4D868C0", Offset = "0x4D85CC0", VA = "0x184D868C0")]
	public KGPHFOFOMPJ<LPCAMBCOBBH, TErr> GMFGMNMCOOP()
	{
		return default(KGPHFOFOMPJ<LPCAMBCOBBH, TErr>);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x4D88F00", Offset = "0x4D88300", VA = "0x184D88F00")]
	public static bool PEOCKCCHEIN([In] KGPHFOFOMPJ<TOk, TErr> KGCKEJLFPJB, [In] KGPHFOFOMPJ<TOk, TErr> HKELKGIPNGP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x4D85A00", Offset = "0x4D84E00", VA = "0x184D85A00", Slot = "4")]
	public bool Equals(KGPHFOFOMPJ<TOk, TErr> KNCKFHOKGJM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x4D85AD0", Offset = "0x4D84ED0", VA = "0x184D85AD0", Slot = "0")]
	public override bool Equals(object KNCKFHOKGJM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x4D87320", Offset = "0x4D86720", VA = "0x184D87320", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x4D89B80", Offset = "0x4D88F80", VA = "0x184D89B80", Slot = "3")]
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
		[Cpp2IlInjected.Address(RVA = "0x4D93820", Offset = "0x4D92C20", VA = "0x184D93820", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x4D93E60", Offset = "0x4D93260", VA = "0x184D93E60", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x3392BA0", Offset = "0x3391FA0", VA = "0x183392BA0")]
	public static KGPHFOFOMPJ<TOk?, TErr?> NILGAOGKJBL<TOk, TErr>([In] this KGPHFOFOMPJ<TOk, TErr> JOCJBPPJMJJ, [In] TOk CFKMKCHBJDM)
	{
		return default(KGPHFOFOMPJ<TOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x3393E50", Offset = "0x3393250", VA = "0x183393E50")]
	public static KGPHFOFOMPJ<LPCAMBCOBBH, TErr?> NILGAOGKJBL<TErr>([In] this KGPHFOFOMPJ<LPCAMBCOBBH, TErr> JOCJBPPJMJJ)
	{
		return default(KGPHFOFOMPJ<LPCAMBCOBBH, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x3392BA0", Offset = "0x3391FA0", VA = "0x183392BA0")]
	public static KGPHFOFOMPJ<TOk?, TErr?> HEEGIAFBKFO<TOk, TErr>([In] this KGPHFOFOMPJ<TOk, TErr> JOCJBPPJMJJ, [In] TErr IMFPGAEPEOJ)
	{
		return default(KGPHFOFOMPJ<TOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x3393780", Offset = "0x3392B80", VA = "0x183393780")]
	public static TOk? KOIJKADCNPN<TOk, TErr>([In] this KGPHFOFOMPJ<TOk, TErr> JOCJBPPJMJJ)
	{
		return (TOk?)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x33923C0", Offset = "0x33917C0", VA = "0x1833923C0")]
	[AsyncStateMachine(typeof(KIILEOLGICM<, >))]
	public static Task<TOk?>? DPMPGHOHCDF<TOk, TErr>(this Task<KGPHFOFOMPJ<TOk, TErr>> JOCJBPPJMJJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x33907B0", Offset = "0x338FBB0", VA = "0x1833907B0")]
	public static TErr? CALIHNGCPLM<TErr, TOk>([In] this KGPHFOFOMPJ<TOk, TErr> JOCJBPPJMJJ)
	{
		return (TErr?)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x33910E0", Offset = "0x33904E0", VA = "0x1833910E0")]
	public static bool DCKDEFGFKNG<TOk, TErr, UErr, UOk>([In] this KGPHFOFOMPJ<TOk, TErr> JOCJBPPJMJJ, [Out] KGPHFOFOMPJ<UOk, UErr> LMBIAMNEEOB) where TErr : UErr?
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x3392190", Offset = "0x3391590", VA = "0x183392190")]
	public static bool DEIJFJEKBEC<TOk, TErr>([In] this KGPHFOFOMPJ<TOk, TErr> JOCJBPPJMJJ, [Out] TOk CFKMKCHBJDM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x3392700", Offset = "0x3391B00", VA = "0x183392700")]
	public static bool EEEJGKIMOON<TOk, TErr>([In] this KGPHFOFOMPJ<TOk, TErr> JOCJBPPJMJJ, [Out][NotNullWhen(true)] TErr IMFPGAEPEOJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x3393BC0", Offset = "0x3392FC0", VA = "0x183393BC0")]
	public static bool LPJKPKOGNIL<TOk, TErr>([In] this KGPHFOFOMPJ<TOk, TErr> JOCJBPPJMJJ, [Out][NotNullWhen(true)] TOk CFKMKCHBJDM, [Out][NotNullWhen(false)] TErr IMFPGAEPEOJ) where TOk : notnull where TErr : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x3393EF0", Offset = "0x33932F0", VA = "0x183393EF0")]
	public static bool OABOGIGMDIA<TOk, TErr>([In] this KGPHFOFOMPJ<TOk, TErr> JOCJBPPJMJJ, [Out][NotNullWhen(true)] TOk CFKMKCHBJDM, [Out] KGPHFOFOMPJ<TOk, TErr> LMBIAMNEEOB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x3390FB0", Offset = "0x33903B0", VA = "0x183390FB0")]
	public static bool DCKDEFGFKNG<TOk, TErr, UErr, UOk>([In] this KGPHFOFOMPJ<TOk, TErr> JOCJBPPJMJJ, [Out][NotNullWhen(true)] TOk CFKMKCHBJDM, [Out] KGPHFOFOMPJ<UOk, UErr> LMBIAMNEEOB) where TErr : UErr?
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x3390C00", Offset = "0x3390000", VA = "0x183390C00")]
	public static bool CIMAMCACLNG<TOk, TErr>([In] this KGPHFOFOMPJ<TOk, TErr> JOCJBPPJMJJ, [Out][NotNullWhen(true)] TOk CFKMKCHBJDM, [Out] KGPHFOFOMPJ<LPCAMBCOBBH, TErr> LMBIAMNEEOB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x3392E30", Offset = "0x3392230", VA = "0x183392E30")]
	public static KGPHFOFOMPJ<UOk, UErr> IIKGBDEKDDN<UOk, UErr, TOk, TErr>([In] this KGPHFOFOMPJ<TOk, TErr> JOCJBPPJMJJ, [In] KGPHFOFOMPJ<UOk, UErr> FKPHPPGPLLD) where TOk : UOk where TErr : UErr
	{
		return default(KGPHFOFOMPJ<UOk, UErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x33927D0", Offset = "0x3391BD0", VA = "0x1833927D0")]
	public static KGPHFOFOMPJ<TOk?[]?, TErr?> FNDANPCHJKK<TOk, TErr>(this IEnumerable<KGPHFOFOMPJ<TOk, TErr>> JOCJBPPJMJJ)
	{
		return default(KGPHFOFOMPJ<TOk[], TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x3390450", Offset = "0x338F850", VA = "0x183390450")]
	public static KGPHFOFOMPJ<UOk?, TErr?> AHDIBBAIBEF<UOk, TErr, TOk>([In] this KGPHFOFOMPJ<TOk, TErr> JOCJBPPJMJJ, Func<TOk, UOk> JGMEGNLMLMJ)
	{
		return default(KGPHFOFOMPJ<UOk, TErr>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public static class HFNFPGPMECM<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x3B9BFB0", Offset = "0x3B9B3B0", VA = "0x183B9BFB0")]
	public static KGPHFOFOMPJ<TOk, T> NILGAOGKJBL<TOk>([In] TOk CFKMKCHBJDM) where TOk : notnull
	{
		return default(KGPHFOFOMPJ<TOk, T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x48FFBD0", Offset = "0x48FEFD0", VA = "0x1848FFBD0")]
	public static KGPHFOFOMPJ<LPCAMBCOBBH, T> NILGAOGKJBL()
	{
		return default(KGPHFOFOMPJ<LPCAMBCOBBH, T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x3B9BFB0", Offset = "0x3B9B3B0", VA = "0x183B9BFB0")]
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
	[Cpp2IlInjected.Address(RVA = "0x4A28B80", Offset = "0x4A27F80", VA = "0x184A28B80")]
	public static INNNADKOMLO<TKey, TValue> HBLBJMFGHFK(string PCJJKLDOJMD)
	{
		return default(INNNADKOMLO<TKey, TValue>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x4A28D40", Offset = "0x4A28140", VA = "0x184A28D40")]
	internal INNNADKOMLO(Dictionary<TKey, TValue> FFOEEMKIKJO, DMLDMFABONA NMJDAHMKHPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x4A28CA0", Offset = "0x4A280A0", VA = "0x184A28CA0")]
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
	[Cpp2IlInjected.Address(RVA = "0x2865590", Offset = "0x2864990", VA = "0x182865590")]
	internal MMNAADIMANP(Dictionary<TKey, TValue> FFOEEMKIKJO, GIHKLINNGKG FELFNICCHNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x4A28D80", Offset = "0x4A28180", VA = "0x184A28D80", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x4A28B80", Offset = "0x4A27F80", VA = "0x184A28B80")]
	public static MKPOKEEHKDJ<T> HBLBJMFGHFK(string PCJJKLDOJMD)
	{
		return default(MKPOKEEHKDJ<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x4A28D40", Offset = "0x4A28140", VA = "0x184A28D40")]
	internal MKPOKEEHKDJ(HashSet<T> FFOEEMKIKJO, DMLDMFABONA NMJDAHMKHPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x4A28CA0", Offset = "0x4A280A0", VA = "0x184A28CA0")]
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
	[Cpp2IlInjected.Address(RVA = "0x2865590", Offset = "0x2864990", VA = "0x182865590")]
	internal PJBPCGKEMON(HashSet<T> FFOEEMKIKJO, GIHKLINNGKG FELFNICCHNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x4A28D80", Offset = "0x4A28180", VA = "0x184A28D80", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x4A28B80", Offset = "0x4A27F80", VA = "0x184A28B80")]
	public static BNAEEDIDAKC<T> HBLBJMFGHFK(string PCJJKLDOJMD)
	{
		return default(BNAEEDIDAKC<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x4A28D40", Offset = "0x4A28140", VA = "0x184A28D40")]
	internal BNAEEDIDAKC(Stack<T> FFOEEMKIKJO, DMLDMFABONA NMJDAHMKHPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x4A28CA0", Offset = "0x4A280A0", VA = "0x184A28CA0")]
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
	[Cpp2IlInjected.Address(RVA = "0x2865590", Offset = "0x2864990", VA = "0x182865590")]
	internal INPJIHEKKJM(Stack<T> FFOEEMKIKJO, GIHKLINNGKG FELFNICCHNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x4A28D80", Offset = "0x4A28180", VA = "0x184A28D80", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x25691C0", Offset = "0x25685C0", VA = "0x1825691C0")]
		public DGGNKIMEHBN(PIDCPBHOLKH<T> BGCEKLPNCIL, int OKDAAFAEHMK, bool ANOHBCPDNKJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x66D7470", Offset = "0x66D6870", VA = "0x1866D7470")]
		public PIDCPBHOLKH<T>.PGCBELDNGEP DBEEDGEHMMA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x66D7560", Offset = "0x66D6960", VA = "0x1866D7560", Slot = "5")]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x66D7560", Offset = "0x66D6960", VA = "0x1866D7560", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x530C7D0", Offset = "0x530BBD0", VA = "0x18530C7D0")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		T IEnumerator<T>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000D0")]
			[Cpp2IlInjected.Address(RVA = "0x530C980", Offset = "0x530BD80", VA = "0x18530C980", Slot = "4")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		object? IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000D1")]
			[Cpp2IlInjected.Address(RVA = "0x530CAF0", Offset = "0x530BEF0", VA = "0x18530CAF0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x530CF90", Offset = "0x530C390", VA = "0x18530CF90")]
		public PGCBELDNGEP(PIDCPBHOLKH<T> BGCEKLPNCIL, int OKDAAFAEHMK, bool ANOHBCPDNKJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x530C890", Offset = "0x530BC90", VA = "0x18530C890", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x530C920", Offset = "0x530BD20", VA = "0x18530C920", Slot = "8")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x9ACA90", Offset = "0x9ABE90", VA = "0x1809ACA90", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x9B8350", Offset = "0x9B7750", VA = "0x1809B8350")]
		public LENNOHBDEEF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x4E5DFD0", Offset = "0x4E5D3D0", VA = "0x184E5DFD0")]
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
		[Cpp2IlInjected.Address(RVA = "0x53146E0", Offset = "0x5313AE0", VA = "0x1853146E0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public T JKNLEFEANEI
	{
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x46FD6A0", Offset = "0x46FCAA0", VA = "0x1846FD6A0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public T HNICEFLLFFA
	{
		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x5314740", Offset = "0x5313B40", VA = "0x185314740")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public T JODHLAKLPCM
	{
		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x53145D0", Offset = "0x53139D0", VA = "0x1853145D0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public int EMKINJPKJHL
	{
		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x2446D70", Offset = "0x2446170", VA = "0x182446D70")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x19425A0", Offset = "0x19419A0", VA = "0x1819425A0")]
	private static int AMFLNKOGMNI(int CJFNAFNJJLB, int BFBCILDCBHG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x5314940", Offset = "0x5313D40", VA = "0x185314940")]
	public PIDCPBHOLKH(int MNDMOIHIBEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x5314780", Offset = "0x5313B80", VA = "0x185314780")]
	public PIDCPBHOLKH(int MNDMOIHIBEI, Func<T> GHHMDONGNPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x5314C40", Offset = "0x5314040", VA = "0x185314C40")]
	public PIDCPBHOLKH(T[] KKIPPMFKGPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x5314450", Offset = "0x5313850", VA = "0x185314450")]
	public void BCBDFCEJKAP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x5314390", Offset = "0x5313790", VA = "0x185314390")]
	public IEnumerable<T> BALECFBFOGM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x5314640", Offset = "0x5313A40", VA = "0x185314640")]
	public PIDCPBHOLKH<T>.PGCBELDNGEP DBEEDGEHMMA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x47D7A60", Offset = "0x47D6E60", VA = "0x1847D7A60", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x47D7A60", Offset = "0x47D6E60", VA = "0x1847D7A60", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public static class NMNCPAMDABG
{
	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x37D8DE0", Offset = "0x37D81E0", VA = "0x1837D8DE0")]
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
			[Cpp2IlInjected.Address(RVA = "0x79F2DF0", Offset = "0x79F21F0", VA = "0x1879F2DF0")]
			get
			{
				return default(RRColor);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public static RRColor Green
		{
			[Cpp2IlInjected.Token(Token = "0x60000DE")]
			[Cpp2IlInjected.Address(RVA = "0x79F2DB0", Offset = "0x79F21B0", VA = "0x1879F2DB0")]
			get
			{
				return default(RRColor);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public static RRColor Red
		{
			[Cpp2IlInjected.Token(Token = "0x60000DF")]
			[Cpp2IlInjected.Address(RVA = "0x79F2DD0", Offset = "0x79F21D0", VA = "0x1879F2DD0")]
			get
			{
				return default(RRColor);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public static RRColor Yellow
		{
			[Cpp2IlInjected.Token(Token = "0x60000E0")]
			[Cpp2IlInjected.Address(RVA = "0x79F2E10", Offset = "0x79F2210", VA = "0x1879F2E10")]
			get
			{
				return default(RRColor);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public static RRColor Cyan
		{
			[Cpp2IlInjected.Token(Token = "0x60000E1")]
			[Cpp2IlInjected.Address(RVA = "0x79F2D90", Offset = "0x79F2190", VA = "0x1879F2D90")]
			get
			{
				return default(RRColor);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x2672850", Offset = "0x2671C50", VA = "0x182672850")]
		public RRColor(float IEDBNFIMLNL, float NJJCBIMJHBH, float IAJJOLNCJOI, float PCMHLCLONGN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x78BCF90", Offset = "0x78BC390", VA = "0x1878BCF90", Slot = "4")]
		public bool Equals(RRColor KNCKFHOKGJM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x79F29E0", Offset = "0x79F1DE0", VA = "0x1879F29E0", Slot = "0")]
		public override bool Equals(object KNCKFHOKGJM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x79F2AE0", Offset = "0x79F1EE0", VA = "0x1879F2AE0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x79F2B60", Offset = "0x79F1F60", VA = "0x1879F2B60", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x79F2980", Offset = "0x79F1D80", VA = "0x1879F2980")]
			get
			{
				return default(RRColor32);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public static RRColor32 Green
		{
			[Cpp2IlInjected.Token(Token = "0x60000EA")]
			[Cpp2IlInjected.Address(RVA = "0x79F2920", Offset = "0x79F1D20", VA = "0x1879F2920")]
			get
			{
				return default(RRColor32);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public static RRColor32 Red
		{
			[Cpp2IlInjected.Token(Token = "0x60000EB")]
			[Cpp2IlInjected.Address(RVA = "0x79F2950", Offset = "0x79F1D50", VA = "0x1879F2950")]
			get
			{
				return default(RRColor32);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public static RRColor32 Yellow
		{
			[Cpp2IlInjected.Token(Token = "0x60000EC")]
			[Cpp2IlInjected.Address(RVA = "0x79F29B0", Offset = "0x79F1DB0", VA = "0x1879F29B0")]
			get
			{
				return default(RRColor32);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public static RRColor32 Cyan
		{
			[Cpp2IlInjected.Token(Token = "0x60000ED")]
			[Cpp2IlInjected.Address(RVA = "0x79F28F0", Offset = "0x79F1CF0", VA = "0x1879F28F0")]
			get
			{
				return default(RRColor32);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x59638E0", Offset = "0x5962CE0", VA = "0x1859638E0")]
		public RRColor32(byte IEDBNFIMLNL, byte NJJCBIMJHBH, byte IAJJOLNCJOI, byte PCMHLCLONGN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x2036D50", Offset = "0x2036150", VA = "0x182036D50", Slot = "4")]
		public bool Equals(RRColor32 KNCKFHOKGJM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x79F2610", Offset = "0x79F1A10", VA = "0x1879F2610", Slot = "0")]
		public override bool Equals(object KNCKFHOKGJM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x11D76A0", Offset = "0x11D6AA0", VA = "0x1811D76A0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x79F24C0", Offset = "0x79F18C0", VA = "0x1879F24C0")]
		public static RRColor32 CLMIANKGGAM(RRColor NOBKOCLLFNE)
		{
			return default(RRColor32);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x79F2450", Offset = "0x79F1850", VA = "0x1879F2450")]
		public static RRColor CLMIANKGGAM(RRColor32 NOBKOCLLFNE)
		{
			return default(RRColor);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x79F2690", Offset = "0x79F1A90", VA = "0x1879F2690", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x491C020", Offset = "0x491B420", VA = "0x18491C020")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x491C040", Offset = "0x491B440", VA = "0x18491C040", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0xC747D0", Offset = "0xC73BD0", VA = "0x180C747D0")]
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
		[Cpp2IlInjected.Address(RVA = "0x66F7F20", Offset = "0x66F7320", VA = "0x1866F7F20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x49F73C0", Offset = "0x49F67C0", VA = "0x1849F73C0", Slot = "5")]
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
	[Cpp2IlInjected.Address(RVA = "0x66CE780", Offset = "0x66CDB80", VA = "0x1866CE780")]
	public DECHADNHCAL([In] T MEBMOMPAGGP, int AEIBEGHLFEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x66CE550", Offset = "0x66CD950", VA = "0x1866CE550")]
	public DECHADNHCAL([In] T MEBMOMPAGGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x66CE050", Offset = "0x66CD450", VA = "0x1866CE050", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x66CE090", Offset = "0x66CD490", VA = "0x1866CE090")]
	public HJKBBGDIABL EJDIBLGNHID()
	{
		return default(HJKBBGDIABL);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x66CE430", Offset = "0x66CD830", VA = "0x1866CE430")]
	[AsyncStateMachine(typeof(DECHADNHCAL<>.DLCICMKMCCD))]
	public Task<DECHADNHCAL<T>.HJKBBGDIABL> FGOCGFEJCED(CancellationToken LMNHDKIFBOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x66CE030", Offset = "0x66CD430", VA = "0x1866CE030")]
	public void BMKKLKINIKE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public static class GNMLKKENCAK
{
	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x79F0920", Offset = "0x79EFD20", VA = "0x1879F0920")]
	public static DECHADNHCAL<LPCAMBCOBBH> HBLBJMFGHFK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x3393FF0", Offset = "0x33933F0", VA = "0x183393FF0")]
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
			[Cpp2IlInjected.Address(RVA = "0x4C16FC0", Offset = "0x4C163C0", VA = "0x184C16FC0")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x52FAFF0", Offset = "0x52FA3F0", VA = "0x1852FAFF0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0xC747D0", Offset = "0xC73BD0", VA = "0x180C747D0")]
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
			[Cpp2IlInjected.Address(RVA = "0x4C16FC0", Offset = "0x4C163C0", VA = "0x184C16FC0")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x4C16FE0", Offset = "0x4C163E0", VA = "0x184C16FE0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0xC747D0", Offset = "0xC73BD0", VA = "0x180C747D0")]
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
		[Cpp2IlInjected.Address(RVA = "0x5058380", Offset = "0x5057780", VA = "0x185058380", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x49F73C0", Offset = "0x49F67C0", VA = "0x1849F73C0", Slot = "5")]
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
	[Cpp2IlInjected.Address(RVA = "0x4A11A50", Offset = "0x4A10E50", VA = "0x184A11A50")]
	internal IGBGKFFBDGD(DECHADNHCAL<int> AOFIHJADKAE, DECHADNHCAL<LPCAMBCOBBH> ILEDCBBLOHG, DECHADNHCAL<LPCAMBCOBBH> GHHEMFPIBHO, [In] T MEBMOMPAGGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x4A111A0", Offset = "0x4A105A0", VA = "0x184A111A0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x4A10E20", Offset = "0x4A10220", VA = "0x184A10E20")]
	public PDBBMANOHFJ DDCLNCKPBBO()
	{
		return default(PDBBMANOHFJ);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x4A11770", Offset = "0x4A10B70", VA = "0x184A11770")]
	public JKFBCIOKDLE FEAAJMEOMKD()
	{
		return default(JKFBCIOKDLE);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x4A11440", Offset = "0x4A10840", VA = "0x184A11440")]
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
	[Cpp2IlInjected.Address(RVA = "0x79EFAB0", Offset = "0x79EEEB0", VA = "0x1879EFAB0")]
	public static IGBGKFFBDGD<LPCAMBCOBBH> HBLBJMFGHFK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x345C8D0", Offset = "0x345BCD0", VA = "0x18345C8D0")]
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
	[Cpp2IlInjected.Address(RVA = "0x9A91C0", Offset = "0x9A85C0", VA = "0x1809A91C0", Slot = "7")]
	public override string JIBLDGHIHFP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x48E17D0", Offset = "0x48E0BD0", VA = "0x1848E17D0")]
	internal AJOONLBHDFN(string DAMFJFKKFBI, [In] TData HPMNBNLACCC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public static class OICBNKIHGAL
{
	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x79F1C50", Offset = "0x79F1050", VA = "0x1879F1C50")]
	public static AJOONLBHDFN<LPCAMBCOBBH> HBLBJMFGHFK(string DAMFJFKKFBI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x339B040", Offset = "0x339A440", VA = "0x18339B040")]
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
	[Cpp2IlInjected.Address(RVA = "0xD79390", Offset = "0xD78790", VA = "0x180D79390")]
	private DMLDMFABONA(bool DDKOKAKNDPF, string AAAEJNNKBGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x79EFB80", Offset = "0x79EEF80", VA = "0x1879EFB80")]
	public static DMLDMFABONA HBLBJMFGHFK(string AAAEJNNKBGJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x79EFBF0", Offset = "0x79EEFF0", VA = "0x1879EFBF0")]
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
	[Cpp2IlInjected.Address(RVA = "0xC747D0", Offset = "0xC73BD0", VA = "0x180C747D0")]
	internal GIHKLINNGKG(DMLDMFABONA PCJJKLDOJMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x79F0900", Offset = "0x79EFD00", VA = "0x1879F0900", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x9B8350", Offset = "0x9B7750", VA = "0x1809B8350")]
		public MHIGPFNFDPA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x505EF30", Offset = "0x505E330", VA = "0x18505EF30")]
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
		[Cpp2IlInjected.Address(RVA = "0x66FECB0", Offset = "0x66FE0B0", VA = "0x1866FECB0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public bool AEJJCGKCLAI
	{
		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x66FECF0", Offset = "0x66FE0F0", VA = "0x1866FECF0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public int GMILMIAEFMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x9AE430", Offset = "0x9AD830", VA = "0x1809AE430")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x9B51D0", Offset = "0x9B45D0", VA = "0x1809B51D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x66FEEB0", Offset = "0x66FE2B0", VA = "0x1866FEEB0")]
	public bool JJBKLNLGAIJ(T HHGPJKKLNIG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x66FED40", Offset = "0x66FE140", VA = "0x1866FED40")]
	public bool JEBJOEBLLEI(T HHGPJKKLNIG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x66FF070", Offset = "0x66FE470", VA = "0x1866FF070")]
	public bool JOEMDCADNHJ(T HHGPJKKLNIG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x66FEBD0", Offset = "0x66FDFD0", VA = "0x1866FEBD0")]
	public void ANKKLOKJJMP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x66FF0C0", Offset = "0x66FE4C0", VA = "0x1866FF0C0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x9B8350", Offset = "0x9B7750", VA = "0x1809B8350")]
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
		[Cpp2IlInjected.Address(RVA = "0x9B8350", Offset = "0x9B7750", VA = "0x1809B8350")]
		public OHOBNLEJMHL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x79F1BA0", Offset = "0x79F0FA0", VA = "0x1879F1BA0")]
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
		[Cpp2IlInjected.Address(RVA = "0x79EF1E0", Offset = "0x79EE5E0", VA = "0x1879EF1E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public bool AEJJCGKCLAI
	{
		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x79EF270", Offset = "0x79EE670", VA = "0x1879EF270")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public int GMILMIAEFMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x9AE430", Offset = "0x9AD830", VA = "0x1809AE430")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x9B51D0", Offset = "0x9B45D0", VA = "0x1809B51D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x79EF320", Offset = "0x79EE720", VA = "0x1879EF320")]
	public bool JJBKLNLGAIJ(object HHGPJKKLNIG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x79EF280", Offset = "0x79EE680", VA = "0x1879EF280")]
	public bool JEBJOEBLLEI(object HHGPJKKLNIG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x79EF400", Offset = "0x79EE800", VA = "0x1879EF400")]
	public bool JOEMDCADNHJ(object HHGPJKKLNIG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x79EF170", Offset = "0x79EE570", VA = "0x1879EF170")]
	public void ANKKLOKJJMP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x79EF460", Offset = "0x79EE860", VA = "0x1879EF460", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x9B8350", Offset = "0x9B7750", VA = "0x1809B8350")]
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
		[Cpp2IlInjected.Address(RVA = "0x184D080", Offset = "0x184C480", VA = "0x18184D080", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x184B3F0", Offset = "0x184A7F0", VA = "0x18184B3F0", Slot = "5")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public object? PKKALGBGHDI
	{
		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x9AA490", Offset = "0x9A9890", VA = "0x1809AA490")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x9B40A0", Offset = "0x9B34A0", VA = "0x1809B40A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public bool PKMGEMMGNAG
	{
		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x4C0D520", Offset = "0x4C0C920", VA = "0x184C0D520")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x64E4C20", Offset = "0x64E4020", VA = "0x1864E4C20")]
	public bool JHAAOHPGICL(T FFOEEMKIKJO, object HHGPJKKLNIG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x4C0D580", Offset = "0x4C0C980", VA = "0x184C0D580")]
	public bool GOGJPLAFFMK(object HHGPJKKLNIG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x4831A20", Offset = "0x4830E20", VA = "0x184831A20")]
	public void CJEMNCEDADJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x64E3010", Offset = "0x64E2410", VA = "0x1864E3010")]
	public bool BGPIDOLLEKE(object HHGPJKKLNIG, [Out] T FFOEEMKIKJO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x64E32F0", Offset = "0x64E26F0", VA = "0x1864E32F0")]
	[HDBICCPCIAM("T can be T?, `default!` shouldn't be necessary in C# 9")]
	private bool CMPEKILFMCC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x5F28510", Offset = "0x5F27910", VA = "0x185F28510")]
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
		[Cpp2IlInjected.Address(RVA = "0x79F1660", Offset = "0x79F0A60", VA = "0x1879F1660", Slot = "4")]
		public bool Equals(CEGHMOMNMEC MEAMPLHPPKP, CEGHMOMNMEC KDELALKKKOF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x6BECFA0", Offset = "0x6BEC3A0", VA = "0x186BECFA0", Slot = "5")]
		public int GetHashCode(CEGHMOMNMEC BLFGIKOAKOL)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x9B8350", Offset = "0x9B7750", VA = "0x1809B8350")]
		public LPOKEFEHANM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x79EFA40", Offset = "0x79EEE40", VA = "0x1879EFA40")]
	public DEMPDIKPCDF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x79EF900", Offset = "0x79EED00", VA = "0x1879EF900", Slot = "4")]
	public override bool JJBKLNLGAIJ(CEGHMOMNMEC HHGPJKKLNIG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x79EF850", Offset = "0x79EEC50", VA = "0x1879EF850", Slot = "5")]
	public override bool JEBJOEBLLEI(CEGHMOMNMEC HHGPJKKLNIG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x79EF9B0", Offset = "0x79EEDB0", VA = "0x1879EF9B0")]
	private static void LKOIDCDGDIK(CEGHMOMNMEC HHGPJKKLNIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x17311D0", Offset = "0x17305D0", VA = "0x1817311D0", Slot = "6")]
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
	[Cpp2IlInjected.Address(RVA = "0x9B2970", Offset = "0x9B1D70", VA = "0x1809B2970")]
	public CEGHMOMNMEC(string OMKMDHJKBJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x79EF800", Offset = "0x79EEC00", VA = "0x1879EF800", Slot = "3")]
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
		[Cpp2IlInjected.Address(RVA = "0x56BE050", Offset = "0x56BD450", VA = "0x1856BE050")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public int GMILMIAEFMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0xB3D410", Offset = "0xB3C810", VA = "0x180B3D410")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0xBEB2C0", Offset = "0xBEA6C0", VA = "0x180BEB2C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x63F05B0", Offset = "0x63EF9B0", VA = "0x1863F05B0")]
	public CGKIFKPHPJP(IEqualityComparer<T> BJPBKLBLNPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x63EFC20", Offset = "0x63EF020", VA = "0x1863EFC20", Slot = "4")]
	public virtual bool JJBKLNLGAIJ(T HHGPJKKLNIG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x63EF940", Offset = "0x63EED40", VA = "0x1863EF940", Slot = "5")]
	public virtual bool JEBJOEBLLEI(T HHGPJKKLNIG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x63EF860", Offset = "0x63EEC60", VA = "0x1863EF860")]
	public void ANKKLOKJJMP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract string TokenToString(T HHGPJKKLNIG);

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x63F02B0", Offset = "0x63EF6B0", VA = "0x1863F02B0", Slot = "3")]
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
		[Cpp2IlInjected.Address(RVA = "0x4C804F0", Offset = "0x4C7F8F0", VA = "0x184C804F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public int GMILMIAEFMI
	{
		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x4C80350", Offset = "0x4C7F750", VA = "0x184C80350")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x4C807B0", Offset = "0x4C7FBB0", VA = "0x184C807B0")]
	public void JJBKLNLGAIJ(T HHGPJKKLNIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x4C80610", Offset = "0x4C7FA10", VA = "0x184C80610")]
	public void JEBJOEBLLEI(T HHGPJKKLNIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x4C80310", Offset = "0x4C7F710", VA = "0x184C80310")]
	public void ANKKLOKJJMP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x4C80A20", Offset = "0x4C7FE20", VA = "0x184C80A20", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x9B8350", Offset = "0x9B7750", VA = "0x1809B8350")]
	public JLKGKCGBFEF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
internal static class MCBLDKLLCBB
{
	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x36E68F0", Offset = "0x36E5CF0", VA = "0x1836E68F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x9AA370", Offset = "0x9A9770", VA = "0x1809AA370", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x9AA510", Offset = "0x9A9910", VA = "0x1809AA510", Slot = "5")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	private CEGHMOMNMEC? PKKALGBGHDI
	{
		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x9B01E0", Offset = "0x9AF5E0", VA = "0x1809B01E0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public bool PKMGEMMGNAG
	{
		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x4C0D520", Offset = "0x4C0C920", VA = "0x184C0D520")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x4C0D620", Offset = "0x4C0CA20", VA = "0x184C0D620")]
	public bool JHAAOHPGICL(T FFOEEMKIKJO, CEGHMOMNMEC HHGPJKKLNIG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x4C0D580", Offset = "0x4C0C980", VA = "0x184C0D580")]
	public bool GOGJPLAFFMK(CEGHMOMNMEC HHGPJKKLNIG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x4831A20", Offset = "0x4830E20", VA = "0x184831A20")]
	public void CJEMNCEDADJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x4C0CEF0", Offset = "0x4C0C2F0", VA = "0x184C0CEF0")]
	public bool BGPIDOLLEKE(CEGHMOMNMEC HHGPJKKLNIG, [Out] T FFOEEMKIKJO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x4C0CF80", Offset = "0x4C0C380", VA = "0x184C0CF80")]
	[HDBICCPCIAM("T can be T?, `default!` shouldn't be necessary in C# 9")]
	private bool CMPEKILFMCC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x4C0D840", Offset = "0x4C0CC40", VA = "0x184C0D840")]
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
		[Cpp2IlInjected.Address(RVA = "0xE36A60", Offset = "0xE35E60", VA = "0x180E36A60")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0xE36A70", Offset = "0xE35E70", VA = "0x180E36A70")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x79F1AA0", Offset = "0x79F0EA0", VA = "0x1879F1AA0")]
	public void JHAAOHPGICL(float FFOEEMKIKJO, object HHGPJKKLNIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x79F1900", Offset = "0x79F0D00", VA = "0x1879F1900")]
	public void GOGJPLAFFMK(object HHGPJKKLNIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x79F18B0", Offset = "0x79F0CB0", VA = "0x1879F18B0")]
	public void CJEMNCEDADJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x79F1970", Offset = "0x79F0D70", VA = "0x1879F1970")]
	private void HHGPJDOAOMJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x79F1B10", Offset = "0x79F0F10", VA = "0x1879F1B10")]
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
			[Cpp2IlInjected.Address(RVA = "0x79F0A70", Offset = "0x79EFE70", VA = "0x1879F0A70")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x79F0BE0", Offset = "0x79EFFE0", VA = "0x1879F0BE0")]
		public IAJGAMIBMKK(float HCJENEHBBIC, float FNNKAHMFNCJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x79F0A80", Offset = "0x79EFE80", VA = "0x1879F0A80", Slot = "3")]
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
		[Cpp2IlInjected.Address(RVA = "0x9B8350", Offset = "0x9B7750", VA = "0x1809B8350")]
		public NPIJFNFHNAO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x79F1790", Offset = "0x79F0B90", VA = "0x1879F1790")]
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
		[Cpp2IlInjected.Address(RVA = "0x79F1380", Offset = "0x79F0780", VA = "0x1879F1380", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x79F0D40", Offset = "0x79F0140", VA = "0x1879F0D40", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x79F14D0", Offset = "0x79F08D0", VA = "0x1879F14D0")]
	public LIJGGIIFNIO(int HDAIOJEADNO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x79F1440", Offset = "0x79F0840", VA = "0x1879F1440")]
	public FAHCCCHCJAA KOLJAMFOMMB(IAJGAMIBMKK KEDOGBHAGPB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x79F0F10", Offset = "0x79F0310", VA = "0x1879F0F10")]
	public void GJCJLCNCGIP(EEKKCJKNBCB EJCDDFONACB, [Optional] IAJGAMIBMKK AJPALOBJENJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x79F0E00", Offset = "0x79F0200", VA = "0x1879F0E00", Slot = "6")]
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
		[Cpp2IlInjected.Address(RVA = "0x79F09E0", Offset = "0x79EFDE0", VA = "0x1879F09E0")]
		public HHKFIMNMCPH(EEKKCJKNBCB JFFCFMIEDHJ, ABEIMCMKCDE ADLKPPBLCIG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x79F0990", Offset = "0x79EFD90", VA = "0x1879F0990", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x79F07D0", Offset = "0x79EFBD0", VA = "0x1879F07D0")]
	internal static bool DCNGKCALKGH(float PCMHLCLONGN, float IAJJOLNCJOI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x79DE350", Offset = "0x79DD750", VA = "0x1879DE350")]
	internal static float OIDFEGPNECD(float PCMHLCLONGN)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x79F0840", Offset = "0x79EFC40", VA = "0x1879F0840")]
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
		[Cpp2IlInjected.Address(RVA = "0x79F0640", Offset = "0x79EFA40", VA = "0x1879F0640")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public event ABEIMCMKCDE? AMAEMNCEHKG
	{
		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x79F0730", Offset = "0x79EFB30", VA = "0x1879F0730", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x79F05A0", Offset = "0x79EF9A0", VA = "0x1879F05A0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x9B8350", Offset = "0x9B7750", VA = "0x1809B8350")]
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
	[Cpp2IlInjected.Address(RVA = "0x50E18D0", Offset = "0x50E0CD0", VA = "0x1850E18D0", Slot = "4")]
	public LAMDJDMNGDN<T> GKNBKKNIPGM([Out] T FFOEEMKIKJO)
	{
		return default(LAMDJDMNGDN<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(RVA = "0x50E1850", Offset = "0x50E0C50", VA = "0x1850E1850")]
	public void FEMKONHLAGL(T NLJFPINPIMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0x4A2C260", Offset = "0x4A2B660", VA = "0x184A2C260", Slot = "5")]
	public void CJEMNCEDADJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(RVA = "0x9ACA90", Offset = "0x9ABE90", VA = "0x1809ACA90", Slot = "6")]
	protected virtual void LABLGBAFPHD(T LEJFGCBLDNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000181")]
	[Cpp2IlInjected.Address(RVA = "0x50E1970", Offset = "0x50E0D70", VA = "0x1850E1970")]
	private T IOLMGDEDCOJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(RVA = "0x50E1A10", Offset = "0x50E0E10", VA = "0x1850E1A10")]
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
	[Cpp2IlInjected.Address(RVA = "0xA3D2B0", Offset = "0xA3C6B0", VA = "0x180A3D2B0")]
	internal LAMDJDMNGDN(T FFOEEMKIKJO, NENLLJAMJJE<T> LHNFDMCLNKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000184")]
	[Cpp2IlInjected.Address(RVA = "0x4E47EA0", Offset = "0x4E472A0", VA = "0x184E47EA0", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x79EF610", Offset = "0x79EEA10", VA = "0x1879EF610")]
	public static LAMDJDMNGDN<StringBuilder> IOLMGDEDCOJ([Out] StringBuilder FFOEEMKIKJO)
	{
		return default(LAMDJDMNGDN<StringBuilder>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000186")]
	[Cpp2IlInjected.Address(RVA = "0x79EF6B0", Offset = "0x79EEAB0", VA = "0x1879EF6B0", Slot = "6")]
	protected override void LABLGBAFPHD(StringBuilder LEJFGCBLDNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(RVA = "0x79EF760", Offset = "0x79EEB60", VA = "0x1879EF760")]
	public BJDPOFCDNPK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
public class BJKDCPLBLNJ : InvalidOperationException
{
	[Cpp2IlInjected.Token(Token = "0x6000189")]
	[Cpp2IlInjected.Address(RVA = "0x7326260", Offset = "0x7325660", VA = "0x187326260")]
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
			[Cpp2IlInjected.Address(RVA = "0x184D080", Offset = "0x184C480", VA = "0x18184D080", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x476C1C0", Offset = "0x476B5C0", VA = "0x18476C1C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0x9AFBB0", Offset = "0x9AEFB0", VA = "0x1809AFBB0")]
		[DebuggerHidden]
		public KLJOJIJLBPN(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x476C260", Offset = "0x476B660", VA = "0x18476C260", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x4DA5DD0", Offset = "0x4DA51D0", VA = "0x184DA5DD0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x4DA6B80", Offset = "0x4DA5F80", VA = "0x184DA6B80")]
		private void OMCGPHJKBHJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x4DA6AE0", Offset = "0x4DA5EE0", VA = "0x184DA6AE0")]
		private void NIIFAIKAHLE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x4DA6D10", Offset = "0x4DA6110", VA = "0x184DA6D10", Slot = "8")]
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
		[Cpp2IlInjected.Address(RVA = "0x4BFEB50", Offset = "0x4BFDF50", VA = "0x184BFEB50", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public bool HMHCPPJANGM
	{
		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x9F4930", Offset = "0x9F3D30", VA = "0x1809F4930", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public TValue JODHLAKLPCM
	{
		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x4BFEE00", Offset = "0x4BFE200", VA = "0x184BFEE00", Slot = "4")]
		get
		{
			return (TValue)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x4BFF090", Offset = "0x4BFE490", VA = "0x184BFF090", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public ICollection<TKey> JPBJOHHNBHM
	{
		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x4BFEE50", Offset = "0x4BFE250", VA = "0x184BFEE50", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public ICollection<TValue> BDMOHMNBJNC
	{
		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x4BFEF70", Offset = "0x4BFE370", VA = "0x184BFEF70", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600018C")]
	[Cpp2IlInjected.Address(RVA = "0x4BFEA90", Offset = "0x4BFDE90", VA = "0x184BFEA90")]
	public JDBJDCHGLEP(AACIGADGGNN<TKey, TValue> ABFALEEGJAB, [Optional] IDictionary<TKey, TValue>? JHEPDGMAEMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(RVA = "0x4BFCBC0", Offset = "0x4BFBFC0", VA = "0x184BFCBC0", Slot = "15")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000190")]
	[Cpp2IlInjected.Address(RVA = "0x4BFD930", Offset = "0x4BFCD30", VA = "0x184BFD930")]
	public void KLKJNIGBEJL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(RVA = "0x4BFC3D0", Offset = "0x4BFB7D0", VA = "0x184BFC3D0", Slot = "9")]
	public void Add(TKey DJBLFBEBKGO, TValue FFOEEMKIKJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0x4BFBEB0", Offset = "0x4BFB2B0", VA = "0x184BFBEB0")]
	public void AKLFLEEJOBE(TKey DJBLFBEBKGO, TValue FFOEEMKIKJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(RVA = "0x4BFD550", Offset = "0x4BFC950", VA = "0x184BFD550")]
	public void GGDHGDLABKP(TKey DJBLFBEBKGO, TValue FFOEEMKIKJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000194")]
	[Cpp2IlInjected.Address(RVA = "0x4BFC600", Offset = "0x4BFBA00", VA = "0x184BFC600")]
	public void BDFADDLMFGH(TKey DJBLFBEBKGO, TValue FFOEEMKIKJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000195")]
	[Cpp2IlInjected.Address(RVA = "0x4BFDC60", Offset = "0x4BFD060", VA = "0x184BFDC60")]
	public void OKCFFLMGCHF(TKey DJBLFBEBKGO, TValue FFOEEMKIKJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(RVA = "0x4BFE0D0", Offset = "0x4BFD4D0", VA = "0x184BFE0D0", Slot = "14")]
	void ICollection<KeyValuePair<TKey, TValue>>.Add(KeyValuePair<TKey, TValue> MGCEJOCCONP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x4BFE2C0", Offset = "0x4BFD6C0", VA = "0x184BFE2C0", Slot = "16")]
	bool ICollection<KeyValuePair<TKey, TValue>>.Contains(KeyValuePair<TKey, TValue> MGCEJOCCONP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(RVA = "0x4BFE620", Offset = "0x4BFDA20", VA = "0x184BFE620", Slot = "18")]
	bool ICollection<KeyValuePair<TKey, TValue>>.Remove(KeyValuePair<TKey, TValue> MGCEJOCCONP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0x4BFCC50", Offset = "0x4BFC050", VA = "0x184BFCC50", Slot = "8")]
	public bool ContainsKey(TKey DJBLFBEBKGO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(RVA = "0x4BFC040", Offset = "0x4BFB440", VA = "0x184BFC040")]
	public bool APMJBPJLDIL(TKey DJBLFBEBKGO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(RVA = "0x4BFCAA0", Offset = "0x4BFBEA0", VA = "0x184BFCAA0")]
	public bool CFKPFLBEDHP(TKey DJBLFBEBKGO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(RVA = "0x4BFDE30", Offset = "0x4BFD230", VA = "0x184BFDE30", Slot = "10")]
	public bool Remove(TKey DJBLFBEBKGO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0x4BFE820", Offset = "0x4BFDC20", VA = "0x184BFE820", Slot = "11")]
	public bool TryGetValue(TKey DJBLFBEBKGO, [Out] TValue FFOEEMKIKJO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(RVA = "0x4BFCDC0", Offset = "0x4BFC1C0", VA = "0x184BFCDC0", Slot = "17")]
	public void CopyTo(KeyValuePair<TKey, TValue>[] LLPLHOOOAEB, int KIMBCLMGPOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(RVA = "0x4BFE7E0", Offset = "0x4BFDBE0", VA = "0x184BFE7E0", Slot = "20")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A0")]
	[Cpp2IlInjected.Address(RVA = "0x4BFD6E0", Offset = "0x4BFCAE0", VA = "0x184BFD6E0", Slot = "19")]
	[IteratorStateMachine(typeof(JDBJDCHGLEP<, >.KLJOJIJLBPN))]
	public IEnumerator<KeyValuePair<TKey, TValue>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x4BFD840", Offset = "0x4BFCC40", VA = "0x184BFD840", Slot = "21")]
	public bool HOJCINCDFLD()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(RVA = "0x4BFDB50", Offset = "0x4BFCF50", VA = "0x184BFDB50")]
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
			[Cpp2IlInjected.Address(RVA = "0xBA3F00", Offset = "0xBA3300", VA = "0x180BA3F00")]
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
			[Cpp2IlInjected.Address(RVA = "0xB3D410", Offset = "0xB3C810", VA = "0x180B3D410")]
			[CompilerGenerated]
			get
			{
				return (TVal)null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001DB")]
			[Cpp2IlInjected.Address(RVA = "0xBEB2C0", Offset = "0xBEA6C0", VA = "0x180BEB2C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004D")]
		public int BFPJLGPCCAO
		{
			[Cpp2IlInjected.Token(Token = "0x60001DC")]
			[Cpp2IlInjected.Address(RVA = "0xC6FB60", Offset = "0xC6EF60", VA = "0x180C6FB60")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60001DD")]
			[Cpp2IlInjected.Address(RVA = "0xE4ACB0", Offset = "0xE4A0B0", VA = "0x180E4ACB0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004E")]
		public DateTimeOffset LIKBJKDPFDK
		{
			[Cpp2IlInjected.Token(Token = "0x60001DE")]
			[Cpp2IlInjected.Address(RVA = "0x11A9300", Offset = "0x11A8700", VA = "0x1811A9300")]
			[CompilerGenerated]
			get
			{
				return default(DateTimeOffset);
			}
			[Cpp2IlInjected.Token(Token = "0x60001DF")]
			[Cpp2IlInjected.Address(RVA = "0x11A92F0", Offset = "0x11A86F0", VA = "0x1811A92F0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x5059160", Offset = "0x5058560", VA = "0x185059160")]
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
			[Cpp2IlInjected.Address(RVA = "0x184D080", Offset = "0x184C480", VA = "0x18184D080", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x493BF80", Offset = "0x493B380", VA = "0x18493BF80", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x9AFBB0", Offset = "0x9AEFB0", VA = "0x1809AFBB0")]
		[DebuggerHidden]
		public HOPDKDLAEDF(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(RVA = "0x4766820", Offset = "0x4765C20", VA = "0x184766820", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0x493A510", Offset = "0x4939910", VA = "0x18493A510", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(RVA = "0x493BA00", Offset = "0x493AE00", VA = "0x18493BA00")]
		private void OMCGPHJKBHJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(RVA = "0x493BDF0", Offset = "0x493B1F0", VA = "0x18493BDF0", Slot = "8")]
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
		[Cpp2IlInjected.Address(RVA = "0x9B9EE0", Offset = "0x9B92E0", VA = "0x1809B9EE0")]
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
		[Cpp2IlInjected.Address(RVA = "0xC76DB0", Offset = "0xC761B0", VA = "0x180C76DB0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0xD9F590", Offset = "0xD9E990", VA = "0x180D9F590")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	public int GMILMIAEFMI
	{
		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x4836BB0", Offset = "0x4835FB0", VA = "0x184836BB0", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	internal int NOOLHGJKMCJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x4831A20", Offset = "0x4830E20", VA = "0x184831A20")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	public ICollection<TVal> BDMOHMNBJNC
	{
		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x4836D30", Offset = "0x4836130", VA = "0x184836D30", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	ICollection<TKey> IDictionary<TKey, TVal>.OBKIJAHPMKH
	{
		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x4833430", Offset = "0x4832830", VA = "0x184833430", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	public bool HMHCPPJANGM
	{
		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x9F4930", Offset = "0x9F3D30", VA = "0x1809F4930", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	public TVal JODHLAKLPCM
	{
		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x4836C40", Offset = "0x4836040", VA = "0x184836C40", Slot = "4")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x4836E20", Offset = "0x4836220", VA = "0x184836E20", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001B0")]
	[Cpp2IlInjected.Address(RVA = "0x48285F0", Offset = "0x48279F0", VA = "0x1848285F0")]
	private bool EIJDAKFOJDE(int HDAIOJEADNO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B7")]
	[Cpp2IlInjected.Address(RVA = "0x4828640", Offset = "0x4827A40", VA = "0x184828640")]
	private void FJHIDKBBPKG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B9")]
	[Cpp2IlInjected.Address(RVA = "0x4836210", Offset = "0x4835610", VA = "0x184836210")]
	public GDHFCHKNKML(int HDAIOJEADNO, [Optional] AFHJOOIPMOA? MEOOEKANMLH, [Optional] IEqualityComparer<TKey>? EBDAAEFHDKB, [Optional] CPGEBDJOKID? HJOFJNMLEPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BA")]
	[Cpp2IlInjected.Address(RVA = "0x4834140", Offset = "0x4833540", VA = "0x184834140")]
	public GDHFCHKNKML(TimeSpan LIEGCGDEIEA, [Optional] IEqualityComparer<TKey>? EBDAAEFHDKB, [Optional] CPGEBDJOKID? HJOFJNMLEPJ, [Optional] EJMLPOJDKGC? BIMMPEIIIPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BB")]
	[Cpp2IlInjected.Address(RVA = "0x48340C0", Offset = "0x48334C0", VA = "0x1848340C0")]
	public GDHFCHKNKML(int HDAIOJEADNO, TimeSpan LIEGCGDEIEA, [Optional] IEqualityComparer<TKey>? EBDAAEFHDKB, [Optional] CPGEBDJOKID? HJOFJNMLEPJ, [Optional] EJMLPOJDKGC? BIMMPEIIIPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BC")]
	[Cpp2IlInjected.Address(RVA = "0x4834FB0", Offset = "0x48343B0", VA = "0x184834FB0")]
	public GDHFCHKNKML(int HDAIOJEADNO, AFHJOOIPMOA? MEOOEKANMLH, TimeSpan LIEGCGDEIEA, [Optional] IEqualityComparer<TKey>? EBDAAEFHDKB, [Optional] CPGEBDJOKID? HJOFJNMLEPJ, [Optional] EJMLPOJDKGC? BIMMPEIIIPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BD")]
	[Cpp2IlInjected.Address(RVA = "0x4829E30", Offset = "0x4829230", VA = "0x184829E30", Slot = "21")]
	public bool HOJCINCDFLD()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001BE")]
	[Cpp2IlInjected.Address(RVA = "0x4830C40", Offset = "0x4830040", VA = "0x184830C40", Slot = "22")]
	public bool KOABHKGAHBJ(int MNDMOIHIBEI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001BF")]
	[Cpp2IlInjected.Address(RVA = "0x482DAE0", Offset = "0x482CEE0", VA = "0x18482DAE0")]
	private bool KEJOMHLKFOB(int MNDMOIHIBEI, GAOHBELNOKN JKODLOFLBMK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C2")]
	[Cpp2IlInjected.Address(RVA = "0x482AAB0", Offset = "0x4829EB0", VA = "0x18482AAB0")]
	public void JFGGMENNDNP(TKey DJBLFBEBKGO, TVal FFOEEMKIKJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C3")]
	[Cpp2IlInjected.Address(RVA = "0x4823220", Offset = "0x4822620", VA = "0x184823220", Slot = "14")]
	public void Add(KeyValuePair<TKey, TVal> MGCEJOCCONP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C4")]
	[Cpp2IlInjected.Address(RVA = "0x4823270", Offset = "0x4822670", VA = "0x184823270", Slot = "9")]
	public void Add(TKey DJBLFBEBKGO, TVal FFOEEMKIKJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C5")]
	[Cpp2IlInjected.Address(RVA = "0x48269F0", Offset = "0x4825DF0", VA = "0x1848269F0", Slot = "8")]
	public bool ContainsKey(TKey DJBLFBEBKGO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C6")]
	[Cpp2IlInjected.Address(RVA = "0x4832CD0", Offset = "0x48320D0", VA = "0x184832CD0", Slot = "16")]
	bool ICollection<KeyValuePair<TKey, TVal>>.Contains(KeyValuePair<TKey, TVal> MGCEJOCCONP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C7")]
	[Cpp2IlInjected.Address(RVA = "0x4832750", Offset = "0x4831B50", VA = "0x184832750", Slot = "10")]
	public bool Remove(TKey DJBLFBEBKGO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C8")]
	[Cpp2IlInjected.Address(RVA = "0x48330A0", Offset = "0x48324A0", VA = "0x1848330A0", Slot = "18")]
	bool ICollection<KeyValuePair<TKey, TVal>>.Remove(KeyValuePair<TKey, TVal> MGCEJOCCONP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C9")]
	[Cpp2IlInjected.Address(RVA = "0x4830580", Offset = "0x482F980", VA = "0x184830580")]
	private bool KJOCGPOLNFE(TKey DJBLFBEBKGO, [Out] TVal FFOEEMKIKJO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(RVA = "0x482A510", Offset = "0x4829910", VA = "0x18482A510")]
	private TVal IOLMGDEDCOJ(TKey IMDENDBDIKN)
	{
		return (TVal)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x48338C0", Offset = "0x4832CC0", VA = "0x1848338C0", Slot = "11")]
	public bool TryGetValue(TKey IMDENDBDIKN, [Out] TVal FFOEEMKIKJO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(RVA = "0x4826750", Offset = "0x4825B50", VA = "0x184826750", Slot = "15")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(RVA = "0x4826E20", Offset = "0x4826220", VA = "0x184826E20", Slot = "17")]
	public void CopyTo(KeyValuePair<TKey, TVal>[] LLPLHOOOAEB, int KIMBCLMGPOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CE")]
	[Cpp2IlInjected.Address(RVA = "0x48321B0", Offset = "0x48315B0", VA = "0x1848321B0")]
	private void PCFAGDEGKCB(TKey DJBLFBEBKGO, TVal PCJCDFNKKKE, GAOHBELNOKN JKODLOFLBMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CF")]
	[Cpp2IlInjected.Address(RVA = "0x48313E0", Offset = "0x48307E0", VA = "0x1848313E0")]
	private bool NHHPKGGLCPB(MGAEHKKMNHP ECBAJKPMIPA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D0")]
	[Cpp2IlInjected.Address(RVA = "0x4824100", Offset = "0x4823500", VA = "0x184824100")]
	private void BGJPPINHALG(LinkedListNode<MGAEHKKMNHP> OPNABDJAFLJ, TVal NHBPFAFPCOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D1")]
	[Cpp2IlInjected.Address(RVA = "0x482B500", Offset = "0x482A900", VA = "0x18482B500")]
	private void JHAAOHPGICL(TKey DJBLFBEBKGO, TVal FFOEEMKIKJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D2")]
	[Cpp2IlInjected.Address(RVA = "0x48291D0", Offset = "0x48285D0", VA = "0x1848291D0")]
	private void HIONDKLIFKC(MGAEHKKMNHP ECBAJKPMIPA, TVal NHBPFAFPCOO, int KDGGAJDGKDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D3")]
	[Cpp2IlInjected.Address(RVA = "0x4828BA0", Offset = "0x4827FA0", VA = "0x184828BA0", Slot = "19")]
	[IteratorStateMachine(typeof(GDHFCHKNKML<, >.HOPDKDLAEDF))]
	public IEnumerator<KeyValuePair<TKey, TVal>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D4")]
	[Cpp2IlInjected.Address(RVA = "0x4833480", Offset = "0x4832880", VA = "0x184833480", Slot = "20")]
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
	[Cpp2IlInjected.Address(RVA = "0x42E7D50", Offset = "0x42E7150", VA = "0x1842E7D50")]
	public EMAMDJDJCPC(TKey ECKNEFMHDOF, Exception HIFFMIIALED)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006D")]
public class PIGFFPDILJC : ArgumentException
{
	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0x6B81310", Offset = "0x6B80710", VA = "0x186B81310")]
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
		[Cpp2IlInjected.Address(RVA = "0x9B8350", Offset = "0x9B7750", VA = "0x1809B8350")]
		public FKJLJPAEPPN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0x4763040", Offset = "0x4762440", VA = "0x184763040")]
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
		[Cpp2IlInjected.Address(RVA = "0x5E3C3A0", Offset = "0x5E3B7A0", VA = "0x185E3C3A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0x5E3C6F0", Offset = "0x5E3BAF0", VA = "0x185E3C6F0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x49F24D0", Offset = "0x49F18D0", VA = "0x1849F24D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(RVA = "0x49F2850", Offset = "0x49F1C50", VA = "0x1849F2850", Slot = "5")]
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
	[Cpp2IlInjected.Address(RVA = "0x50F7940", Offset = "0x50F6D40", VA = "0x1850F7940")]
	public NJGLBGPNBMB(int OPFOLNCOPBG = 0, [Optional] IEqualityComparer<TId>? NLPOHGJBCNK, [Optional] Func<TId, CancellationToken, Task<TResource>>? EBOPNJLKNFL, [Optional] Action<TResource>? CNGPFCCJGHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(RVA = "0x50F7590", Offset = "0x50F6990", VA = "0x1850F7590")]
	public OHGHKHJHGOP<Task<TResource>> NLKEOLDKCDH(TId NCJKGMLAKGH, [Optional] Func<TId, CancellationToken, Task<TResource>>? EBOPNJLKNFL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(RVA = "0x50F6A20", Offset = "0x50F5E20", VA = "0x1850F6A20")]
	private void DDHGIEAEBOC(Task<TResource> NHNFPALEEPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(RVA = "0x50F6450", Offset = "0x50F5850", VA = "0x1850F6450")]
	[AsyncStateMachine(typeof(NJGLBGPNBMB<, >.BEKGHJDBHLD))]
	private Task AAKOHFKBHCF(Task<TResource> NHNFPALEEPM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(RVA = "0x428CD80", Offset = "0x428C180", VA = "0x18428CD80")]
	public void EIKMHJEEHOI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(RVA = "0x50F65D0", Offset = "0x50F59D0", VA = "0x1850F65D0")]
	public PMGJGICKNDP<TId, Task<TResource>>.CKFGIEKMDOM DBEEDGEHMMA()
	{
		return default(PMGJGICKNDP<TId, Task<TResource>>.CKFGIEKMDOM);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(RVA = "0x50F7770", Offset = "0x50F6B70", VA = "0x1850F7770", Slot = "4")]
	private IEnumerator<(TId, Task<TResource>, int)> System.Collections.Generic.IEnumerable<(TIdId,System.Threading.Tasks.Task<TResource>LoadResourceTask,System.Int32RefCount)>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(RVA = "0x50F7770", Offset = "0x50F6B70", VA = "0x1850F7770", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(RVA = "0x50F6DA0", Offset = "0x50F61A0", VA = "0x1850F6DA0")]
	[CompilerGenerated]
	[AsyncStateMachine(typeof(NJGLBGPNBMB<, >.IBJBOAJFKDP))]
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
		[Cpp2IlInjected.Address(RVA = "0x1092500", Offset = "0x1091900", VA = "0x181092500")]
		public EDLNAGCENGJ(TValue FFOEEMKIKJO, int HCHLCNCEOFK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(RVA = "0x42D3C20", Offset = "0x42D3020", VA = "0x1842D3C20", Slot = "4")]
		public bool Equals(EDLNAGCENGJ? KNCKFHOKGJM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0x42D3B80", Offset = "0x42D2F80", VA = "0x1842D3B80", Slot = "0")]
		public override bool Equals(object? BLFGIKOAKOL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000207")]
		[Cpp2IlInjected.Address(RVA = "0x42D3DD0", Offset = "0x42D31D0", VA = "0x1842D3DD0", Slot = "2")]
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
			[Cpp2IlInjected.Address(RVA = "0x63F9200", Offset = "0x63F8600", VA = "0x1863F9200", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000052")]
		public (TKey Key, TValue Value, int RefCount) JKNLEFEANEI
		{
			[Cpp2IlInjected.Token(Token = "0x600020D")]
			[Cpp2IlInjected.Address(RVA = "0x63F95C0", Offset = "0x63F89C0", VA = "0x1863F95C0", Slot = "4")]
			get
			{
				return default((TKey, TValue, int));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000208")]
		[Cpp2IlInjected.Address(RVA = "0x63F9420", Offset = "0x63F8820", VA = "0x1863F9420")]
		public CKFGIEKMDOM(PMGJGICKNDP<TKey, TValue> JLLDPNEPEEK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000209")]
		[Cpp2IlInjected.Address(RVA = "0x63F8DC0", Offset = "0x63F81C0", VA = "0x1863F8DC0", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020A")]
		[Cpp2IlInjected.Address(RVA = "0x63F8E00", Offset = "0x63F8200", VA = "0x1863F8E00", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600020B")]
		[Cpp2IlInjected.Address(RVA = "0x63F8EC0", Offset = "0x63F82C0", VA = "0x1863F8EC0", Slot = "8")]
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
		[Cpp2IlInjected.Address(RVA = "0x9B8350", Offset = "0x9B7750", VA = "0x1809B8350")]
		public INJAKOKFNDK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0x4A282E0", Offset = "0x4A276E0", VA = "0x184A282E0")]
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
	[Cpp2IlInjected.Address(RVA = "0x5356020", Offset = "0x5355420", VA = "0x185356020")]
	public PMGJGICKNDP(int OPFOLNCOPBG = 0, [Optional] IEqualityComparer<TKey>? EBDAAEFHDKB, [Optional] Func<TKey, TValue>? PHBAINGMPJM, [Optional] Action<TValue>? IEPDDECJCHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(RVA = "0x5355B40", Offset = "0x5354F40", VA = "0x185355B40")]
	public OHGHKHJHGOP<TValue> NLKEOLDKCDH(TKey DJBLFBEBKGO, [Optional] Func<TKey, TValue>? NEOIMCIEMDA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(RVA = "0x53550D0", Offset = "0x53544D0", VA = "0x1853550D0")]
	private void FEMKONHLAGL(TKey DJBLFBEBKGO, EDLNAGCENGJ ABDCGJOLLLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000200")]
	[Cpp2IlInjected.Address(RVA = "0x53547E0", Offset = "0x5353BE0", VA = "0x1853547E0")]
	public void EIKMHJEEHOI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000201")]
	[Cpp2IlInjected.Address(RVA = "0x5354720", Offset = "0x5353B20", VA = "0x185354720")]
	public CKFGIEKMDOM DBEEDGEHMMA()
	{
		return default(CKFGIEKMDOM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(RVA = "0x5355E50", Offset = "0x5355250", VA = "0x185355E50", Slot = "4")]
	private IEnumerator<(TKey, TValue, int)> System.Collections.Generic.IEnumerable<(TKeyKey,TValueValue,System.Int32RefCount)>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(RVA = "0x5355E50", Offset = "0x5355250", VA = "0x185355E50", Slot = "5")]
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
