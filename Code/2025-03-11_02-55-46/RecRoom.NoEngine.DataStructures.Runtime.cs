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
		[Cpp2IlInjected.Address(RVA = "0x98FE40", Offset = "0x98F240", VA = "0x18098FE40")]
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
		[Cpp2IlInjected.Address(RVA = "0x7703280", Offset = "0x7702680", VA = "0x187703280")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x990590", Offset = "0x98F990", VA = "0x180990590")]
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
		[Cpp2IlInjected.Address(RVA = "0x9905D0", Offset = "0x98F9D0", VA = "0x1809905D0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public abstract class PBFKPNBILLE
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x96D700", Offset = "0x96CB00", VA = "0x18096D700")]
	protected PBFKPNBILLE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public abstract class HJFNGBLPFHC<T> : PBFKPNBILLE
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	protected struct BGALPEDHMNM
	{
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		public enum FMPLAMENANO
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
		public FMPLAMENANO ANONBNLNHHL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public T NJNJGNMEACN;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private int DOFNOMGOOJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly bool LHBFALONLHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	protected readonly bool ELMIOLFGOMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	protected List<T>? IDHMIIMKPLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private List<BGALPEDHMNM>? KOLECLLKFCC;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public bool OMEDABCPAAI
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x474FCE0", Offset = "0x474F0E0", VA = "0x18474FCE0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x4750700", Offset = "0x474FB00", VA = "0x184750700")]
	protected HJFNGBLPFHC(bool ELMIOLFGOMI, bool LHBFALONLHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x474FD40", Offset = "0x474F140", VA = "0x18474FD40")]
	protected bool IIIKDDAGCLO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x4750410", Offset = "0x474F810", VA = "0x184750410")]
	protected void NBJINBKECFC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x47501A0", Offset = "0x474F5A0", VA = "0x1847501A0")]
	protected void LIFNMAKBAAJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x385E5C0", Offset = "0x385D9C0", VA = "0x18385E5C0")]
	private static void EPFKLELKDIM<U>(List<U>? DBJKHFJBKPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x474FF90", Offset = "0x474F390", VA = "0x18474FF90", Slot = "4")]
	public void KAAHFJDOOLK(T NJNJGNMEACN, bool FGJCIIOOAFB = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x4750530", Offset = "0x474F930", VA = "0x184750530", Slot = "5")]
	public void PBIACPFCCPC(T NJNJGNMEACN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x474FDE0", Offset = "0x474F1E0", VA = "0x18474FDE0")]
	public void JIMFDDOIBMF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public sealed class EBGLFEEDNOA : HJFNGBLPFHC<Action>
{
	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x77012E0", Offset = "0x77006E0", VA = "0x1877012E0")]
	public EBGLFEEDNOA(bool ELMIOLFGOMI = false, bool LHBFALONLHP = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x77010E0", Offset = "0x77004E0", VA = "0x1877010E0")]
	public void PLLPMLOMEJL()
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x7701080", Offset = "0x7700480", VA = "0x187701080")]
	public static EBGLFEEDNOA IDGNMDEILLD(EBGLFEEDNOA AHEKIMPMEPJ, Action NJNJGNMEACN)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x7701020", Offset = "0x7700420", VA = "0x187701020")]
	public static EBGLFEEDNOA DHDBACFJGMA(EBGLFEEDNOA AHEKIMPMEPJ, Action NJNJGNMEACN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface MAHINAKKFAO<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void KAAHFJDOOLK(Action<T> NJNJGNMEACN, bool FGJCIIOOAFB = false);

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void PBIACPFCCPC(Action<T> NJNJGNMEACN);
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public sealed class CLNABAPAGFB<T> : HJFNGBLPFHC<Action<T>>, MAHINAKKFAO<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x4123EC0", Offset = "0x41232C0", VA = "0x184123EC0")]
	public CLNABAPAGFB(bool ELMIOLFGOMI = false, bool LHBFALONLHP = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x6160E10", Offset = "0x6160210", VA = "0x186160E10")]
	public void PLLPMLOMEJL(T MPAMMAGABHA)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x411FF50", Offset = "0x411F350", VA = "0x18411FF50")]
	public static CLNABAPAGFB<T> IDGNMDEILLD(CLNABAPAGFB<T> AHEKIMPMEPJ, Action<T> NJNJGNMEACN)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x411FEB0", Offset = "0x411F2B0", VA = "0x18411FEB0")]
	public static CLNABAPAGFB<T> DHDBACFJGMA(CLNABAPAGFB<T> AHEKIMPMEPJ, Action<T> NJNJGNMEACN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface NAHBIEFBNLK<T, U> where T : notnull where U : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void KAAHFJDOOLK(Action<T, U> NJNJGNMEACN, bool FGJCIIOOAFB = false);

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void PBIACPFCCPC(Action<T, U> NJNJGNMEACN);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public sealed class EIILHECILIH<T, U> : HJFNGBLPFHC<Action<T, U>>, NAHBIEFBNLK<T, U> where T : notnull where U : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x4123EC0", Offset = "0x41232C0", VA = "0x184123EC0")]
	public EIILHECILIH(bool ELMIOLFGOMI = false, bool LHBFALONLHP = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x4121BA0", Offset = "0x4120FA0", VA = "0x184121BA0")]
	public void PLLPMLOMEJL(T MPAMMAGABHA, U GPFPEOEGLIN)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x411FF50", Offset = "0x411F350", VA = "0x18411FF50")]
	public static EIILHECILIH<T, U> IDGNMDEILLD(EIILHECILIH<T, U> AHEKIMPMEPJ, Action<T, U> NJNJGNMEACN)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x411FEB0", Offset = "0x411F2B0", VA = "0x18411FEB0")]
	public static EIILHECILIH<T, U> DHDBACFJGMA(EIILHECILIH<T, U> AHEKIMPMEPJ, Action<T, U> NJNJGNMEACN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public sealed class KDOINBBPKIH<T, U, V> : HJFNGBLPFHC<Action<T, U, V>> where T : notnull where U : notnull where V : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x4123EC0", Offset = "0x41232C0", VA = "0x184123EC0")]
	public KDOINBBPKIH(bool ELMIOLFGOMI = false, bool LHBFALONLHP = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x4AF2880", Offset = "0x4AF1C80", VA = "0x184AF2880")]
	public void PLLPMLOMEJL(T MPAMMAGABHA, U GPFPEOEGLIN, V CKLNAHKPEEA)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x411FF50", Offset = "0x411F350", VA = "0x18411FF50")]
	public static KDOINBBPKIH<T, U, V> IDGNMDEILLD(KDOINBBPKIH<T, U, V> AHEKIMPMEPJ, Action<T, U, V> NJNJGNMEACN)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x411FEB0", Offset = "0x411F2B0", VA = "0x18411FEB0")]
	public static KDOINBBPKIH<T, U, V> DHDBACFJGMA(KDOINBBPKIH<T, U, V> AHEKIMPMEPJ, Action<T, U, V> NJNJGNMEACN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface FEAIMAMCDOK<T, U, V, W>
{
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public sealed class FEGAKAEODBK<T, U, V, W> : HJFNGBLPFHC<Action<T, U, V, W>>, FEAIMAMCDOK<T, U, V, W> where T : notnull where U : notnull where V : notnull where W : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x4123EC0", Offset = "0x41232C0", VA = "0x184123EC0")]
	public FEGAKAEODBK(bool ELMIOLFGOMI = false, bool LHBFALONLHP = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x44F4E70", Offset = "0x44F4270", VA = "0x1844F4E70")]
	public void PLLPMLOMEJL(T MPAMMAGABHA, U GPFPEOEGLIN, V CKLNAHKPEEA, W ICNIEKFBNNN)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x411FF50", Offset = "0x411F350", VA = "0x18411FF50")]
	public static FEGAKAEODBK<T, U, V, W> IDGNMDEILLD(FEGAKAEODBK<T, U, V, W> AHEKIMPMEPJ, Action<T, U, V, W> NJNJGNMEACN)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x411FEB0", Offset = "0x411F2B0", VA = "0x18411FEB0")]
	public static FEGAKAEODBK<T, U, V, W> DHDBACFJGMA(FEGAKAEODBK<T, U, V, W> AHEKIMPMEPJ, Action<T, U, V, W> NJNJGNMEACN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public sealed class KJGAOJJNCMN<T, U, V, W, X> : HJFNGBLPFHC<Action<T, U, V, W, X>>
{
	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x4123EC0", Offset = "0x41232C0", VA = "0x184123EC0")]
	public KJGAOJJNCMN(bool ELMIOLFGOMI = false, bool LHBFALONLHP = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x4B2D490", Offset = "0x4B2C890", VA = "0x184B2D490")]
	public void PLLPMLOMEJL(T MPAMMAGABHA, U GPFPEOEGLIN, V CKLNAHKPEEA, W ICNIEKFBNNN, X COMHOHNLIIN)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x411FF50", Offset = "0x411F350", VA = "0x18411FF50")]
	public static KJGAOJJNCMN<T, U, V, W, X> IDGNMDEILLD(KJGAOJJNCMN<T, U, V, W, X> AHEKIMPMEPJ, Action<T, U, V, W, X> NJNJGNMEACN)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x411FEB0", Offset = "0x411F2B0", VA = "0x18411FEB0")]
	public static KJGAOJJNCMN<T, U, V, W, X> DHDBACFJGMA(KJGAOJJNCMN<T, U, V, W, X> AHEKIMPMEPJ, Action<T, U, V, W, X> NJNJGNMEACN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public sealed class NFEHPBAPKAK<T, U, V, W, X, Y> : HJFNGBLPFHC<Action<T, U, V, W, X, Y>>
{
	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x4123EC0", Offset = "0x41232C0", VA = "0x184123EC0")]
	public NFEHPBAPKAK(bool ELMIOLFGOMI = false, bool LHBFALONLHP = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x4E814F0", Offset = "0x4E808F0", VA = "0x184E814F0")]
	public void PLLPMLOMEJL(T MPAMMAGABHA, U GPFPEOEGLIN, V CKLNAHKPEEA, W ICNIEKFBNNN, X COMHOHNLIIN, Y PJGBAACMKFF)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x411FF50", Offset = "0x411F350", VA = "0x18411FF50")]
	public static NFEHPBAPKAK<T, U, V, W, X, Y> IDGNMDEILLD(NFEHPBAPKAK<T, U, V, W, X, Y> AHEKIMPMEPJ, Action<T, U, V, W, X, Y> NJNJGNMEACN)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x411FEB0", Offset = "0x411F2B0", VA = "0x18411FEB0")]
	public static NFEHPBAPKAK<T, U, V, W, X, Y> DHDBACFJGMA(NFEHPBAPKAK<T, U, V, W, X, Y> AHEKIMPMEPJ, Action<T, U, V, W, X, Y> NJNJGNMEACN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public class GEKOPHGFCLK<TKey, TVal> where TKey : notnull where TVal : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly EFINIOEALEL<TKey, TVal> DLBPMONKPJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	internal readonly Dictionary<TKey, (TVal value, int size)> KJOHKGMDLNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private readonly EFINIOEALEL<TKey, TVal>.PCKENNIGLLD? NDCFLLEGBJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private readonly int OFJFJJGDNJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private readonly EFINIOEALEL<TKey, TVal>.MNPKGOKPJDC? FPELGNEKDMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private int HCAJOMKGDJL;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	internal int NANAJOHCDCB
	{
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x4659100", Offset = "0x4658500", VA = "0x184659100")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public int PCGHJECDELA
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x968340", Offset = "0x967740", VA = "0x180968340")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x4659250", Offset = "0x4658650", VA = "0x184659250")]
	public GEKOPHGFCLK(int OFJFJJGDNJK, [Optional] EFINIOEALEL<TKey, TVal>.MNPKGOKPJDC? FPELGNEKDMA, [Optional] IEqualityComparer<TKey>? BPKKCOFEOKH, [Optional] EFINIOEALEL<TKey, TVal>.PCKENNIGLLD? NDCFLLEGBJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x4658ED0", Offset = "0x46582D0", VA = "0x184658ED0")]
	public void OHGNLMOLNNJ(TKey MCNLCGLNHHO, TVal PEBNJNGMMHE, bool OMELLOGONEN = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x4657F60", Offset = "0x4657360", VA = "0x184657F60")]
	public bool BPICNAEGMLA(TKey MCNLCGLNHHO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x4659150", Offset = "0x4658550", VA = "0x184659150")]
	public bool POFMAEKIJGP(TKey PIFENPOOLGB, [Out] TVal PEBNJNGMMHE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x4658200", Offset = "0x4657600", VA = "0x184658200")]
	private void EMBFCMHOFDO(TKey MCNLCGLNHHO, TVal PEBNJNGMMHE, int NBPEDBIONNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x4658D20", Offset = "0x4658120", VA = "0x184658D20")]
	public bool OCJHGMAOBDH(TKey MCNLCGLNHHO, TVal PEBNJNGMMHE, bool OMELLOGONEN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x46585E0", Offset = "0x46579E0", VA = "0x1846585E0")]
	public void JIMFDDOIBMF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x46587C0", Offset = "0x4657BC0", VA = "0x1846587C0")]
	private void KJINEBCLKLA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x46580C0", Offset = "0x46574C0", VA = "0x1846580C0")]
	private bool DALPNBAODNA(TKey MCNLCGLNHHO, NAHGGCMFDAF BBAJBLJIPLG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x46584C0", Offset = "0x46578C0", VA = "0x1846584C0")]
	private void IJJABOEGMAM(TKey MCNLCGLNHHO, TVal PEBNJNGMMHE, NAHGGCMFDAF BBAJBLJIPLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x4658690", Offset = "0x4657A90", VA = "0x184658690")]
	private void KHFEKBJCLEO(TKey MCNLCGLNHHO, TVal GHFLHNCPIIL, NAHGGCMFDAF BBAJBLJIPLG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class IDJONKJGJJC : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private readonly Action DGONPJOIIEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private bool LNCJLLPLCHP;

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x96D760", Offset = "0x96CB60", VA = "0x18096D760")]
	public IDJONKJGJJC(Action FKBCDFMCNEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x7701850", Offset = "0x7700C50", VA = "0x187701850", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x31FD100", Offset = "0x31FC500", VA = "0x1831FD100")]
	public static NIABGHNBMPF<T> GEEFBNOOFMP<T>(T PEBNJNGMMHE, Action FKBCDFMCNEJ) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public sealed class NIABGHNBMPF<T> : IDJONKJGJJC where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public T KAMPPLLIEDO
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x9682E0", Offset = "0x9676E0", VA = "0x1809682E0")]
		[CompilerGenerated]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x4E8D390", Offset = "0x4E8C790", VA = "0x184E8D390")]
	public NIABGHNBMPF(T PEBNJNGMMHE, Action FKBCDFMCNEJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public sealed class NHOJJFNLHFG<T> : IDisposable where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private readonly AAJGMCHLPOD<T>? JGICPJGNFCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private readonly ReadOnlySequence<T> GFCAACLFOMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private bool LNCJLLPLCHP;

	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public static readonly NHOJJFNLHFG<T> MAEOIBKNBOE;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public ReadOnlySequence<T> NGKMIIFIDFA
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x4E8C5B0", Offset = "0x4E8B9B0", VA = "0x184E8C5B0")]
		get
		{
			return default(ReadOnlySequence<T>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public long AKPIBKEABKN
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x4E8C190", Offset = "0x4E8B590", VA = "0x184E8C190")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public bool EAANCJCJLOJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x4E8C4F0", Offset = "0x4E8B8F0", VA = "0x184E8C4F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x4E8C9F0", Offset = "0x4E8BDF0", VA = "0x184E8C9F0")]
	public NHOJJFNLHFG(AAJGMCHLPOD<T> PHFEDDJHBBA, AAJGMCHLPOD<T> ECENFEPDDJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x4E8CAE0", Offset = "0x4E8BEE0", VA = "0x184E8CAE0")]
	public NHOJJFNLHFG(AAJGMCHLPOD<T> PHFEDDJHBBA, int PFCFNJKDJBK, AAJGMCHLPOD<T> ECENFEPDDJF, int OLOBLBBCLPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x4E8C950", Offset = "0x4E8BD50", VA = "0x184E8C950")]
	private NHOJJFNLHFG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x4E8C100", Offset = "0x4E8B500", VA = "0x184E8C100", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x4E8C760", Offset = "0x4E8BB60", VA = "0x184E8C760")]
	public T[] PGFHNJLOBFL()
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x4E8C310", Offset = "0x4E8B710", VA = "0x184E8C310")]
	public static ReadOnlySequence<T> JKGHIELMIOO(NHOJJFNLHFG<T>? KDODPLEFNAL)
	{
		return default(ReadOnlySequence<T>);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000017")]
public readonly struct JKGLJHBPGHO : IDisposable
{
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public readonly struct CCKAEJOKCCD : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x9AFB60", Offset = "0x9AEF60", VA = "0x1809AFB60")]
		public static CCKAEJOKCCD KMDIICJFNJF()
		{
			return default(CCKAEJOKCCD);
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x966900", Offset = "0x965D00", VA = "0x180966900", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x7702A40", Offset = "0x7701E40", VA = "0x187702A40")]
	public static string BJFDGLIFODK(Type ANONBNLNHHL, [Optional] string? EEAKLNEDMBP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x351D4E0", Offset = "0x351C8E0", VA = "0x18351D4E0")]
	public static string? BJFDGLIFODK<T>([Optional] string? EEAKLNEDMBP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x351D560", Offset = "0x351C960", VA = "0x18351D560")]
	public static string? LNKGKGOKJNB<T>([Optional] string? ENPBJKHNCCB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x9AFB60", Offset = "0x9AEF60", VA = "0x1809AFB60")]
	public static JKGLJHBPGHO BONEJHCIKAG(string EEAKLNEDMBP, string? ENPBJKHNCCB)
	{
		return default(JKGLJHBPGHO);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x966900", Offset = "0x965D00", VA = "0x180966900", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public struct BFNODLBAELJ
{
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public delegate bool LEHFFPIKHAN(string LJDOJPFMGDN, BFNODLBAELJ FBCDBGBMMGI);

	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[CompilerGenerated]
	private sealed class AKJDGAJGGGD<T> where T : notnull, Enum
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public List<int> enumValuesSubset;

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x96D700", Offset = "0x96CB00", VA = "0x18096D700")]
		public AKJDGAJGGGD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x4736790", Offset = "0x4735B90", VA = "0x184736790")]
		internal void GOBLGOPNHKG(T x)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public int BJDHLMBEIKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public string LFFNNOABEND;

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x7700490", Offset = "0x76FF890", VA = "0x187700490")]
	public static Dictionary<string, BFNODLBAELJ> AOCBPIMMLDB(Type LMBFCHFPOJL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x31FE250", Offset = "0x31FD650", VA = "0x1831FE250")]
	public static Dictionary<string, BFNODLBAELJ> AOCBPIMMLDB<T>(Type LMBFCHFPOJL, IReadOnlyDictionary<T, string> NFPFNAFAFPG) where T : notnull, Enum
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x31FEA80", Offset = "0x31FDE80", VA = "0x1831FEA80")]
	public static Dictionary<string, BFNODLBAELJ> FNKFLJPIMOG<T>(List<T> MDLLKNNGJAN) where T : notnull, Enum
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x7700980", Offset = "0x76FFD80", VA = "0x187700980")]
	public static Dictionary<string, BFNODLBAELJ> KANIHHKKEBI(Type LMBFCHFPOJL, LEHFFPIKHAN DIJLCELFKBN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x77007C0", Offset = "0x76FFBC0", VA = "0x1877007C0")]
	public static Dictionary<int, string> ICAAOCOEMOO(Dictionary<string, BFNODLBAELJ> IPKJFPCBFNH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public abstract class OGPHAGHJAIC : MOCCGNOLGDK
{
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public static bool BIHOCJMNKHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	private readonly string? MDCAHKBFBJK;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public virtual MOCCGNOLGDK? LCCLGMNLAEF
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x966910", Offset = "0x965D10", VA = "0x180966910", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x77039B0", Offset = "0x7702DB0", VA = "0x1877039B0")]
	protected OGPHAGHJAIC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(Slot = "7")]
	public abstract string CMLLJBLPAFB();

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x7703770", Offset = "0x7702B70", VA = "0x187703770", Slot = "8")]
	public virtual string KDLOFDPGKHF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x7703300", Offset = "0x7702700", VA = "0x187703300", Slot = "9")]
	public void ALIGCHFJCPB(StringBuilder FKDKHBCMLEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x77037F0", Offset = "0x7702BF0", VA = "0x1877037F0", Slot = "10")]
	public void MICJGJELNNM(StringBuilder FKDKHBCMLEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x77035B0", Offset = "0x77029B0", VA = "0x1877035B0", Slot = "11")]
	public void HECKEPBFLIC(StringBuilder FKDKHBCMLEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x7703850", Offset = "0x7702C50", VA = "0x187703850", Slot = "12")]
	public void OAGGHKCFEFC(StringBuilder FKDKHBCMLEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x77036D0", Offset = "0x7702AD0", VA = "0x1877036D0")]
	public static void HGPGOAAFPFI(StringBuilder FKDKHBCMLEB, string KLICPAGEKOI, string DBGCKINNMGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x6779490", Offset = "0x6778890", VA = "0x186779490", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class JJCJHBEJMOE : Exception
{
	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x77029E0", Offset = "0x7701DE0", VA = "0x1877029E0")]
	public JJCJHBEJMOE(string LPIFIOEEOGF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class FCIPLGNMEPJ<TErr> : JJCJHBEJMOE where TErr : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public readonly TErr FGJOGBODJCB;

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x44ED8A0", Offset = "0x44ECCA0", VA = "0x1844ED8A0")]
	private FCIPLGNMEPJ([In] TErr PAIPEEOOJHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x44ED7D0", Offset = "0x44ECBD0", VA = "0x1844ED7D0")]
	public static FCIPLGNMEPJ<TErr> KMDIICJFNJF([In] TErr PAIPEEOOJHA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class JHJJFKGKHCD : Stream
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private readonly HashAlgorithm DLEPOMKKFIP;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public override bool NCHOJGIPJAI
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x9AFB60", Offset = "0x9AEF60", VA = "0x1809AFB60", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public override bool AJIPMELJOMG
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x9AFB60", Offset = "0x9AEF60", VA = "0x1809AFB60", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public override bool IKMOIILDEHN
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x980BB0", Offset = "0x97FFB0", VA = "0x180980BB0", Slot = "11")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public override long AKPIBKEABKN
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x7702890", Offset = "0x7701C90", VA = "0x187702890", Slot = "12")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public override long LLLAMAJMODF
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x7702900", Offset = "0x7701D00", VA = "0x187702900", Slot = "13")]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x7702970", Offset = "0x7701D70", VA = "0x187702970", Slot = "14")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x7702820", Offset = "0x7701C20", VA = "0x187702820")]
	public JHJJFKGKHCD(HashAlgorithm DLEPOMKKFIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x7702650", Offset = "0x7701A50", VA = "0x187702650", Slot = "35")]
	public override int Read(byte[] LMNIHILKKEL, int FGCNBOMLCIC, int LOHPPDCIAAL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x77027F0", Offset = "0x7701BF0", VA = "0x1877027F0", Slot = "38")]
	public override void Write(byte[] LMNIHILKKEL, int FGCNBOMLCIC, int LOHPPDCIAAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x77026F0", Offset = "0x7701AF0", VA = "0x1877026F0", Slot = "33")]
	public override long Seek(long FGCNBOMLCIC, SeekOrigin IJEEJEICDMC)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x7702780", Offset = "0x7701B80", VA = "0x187702780", Slot = "34")]
	public override void SetLength(long PEBNJNGMMHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x966900", Offset = "0x965D00", VA = "0x180966900", Slot = "23")]
	public override void Flush()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x7702580", Offset = "0x7701980", VA = "0x187702580")]
	public byte[] LLNOGEDFBGH()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public interface MOCCGNOLGDK
{
	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(Slot = "0")]
	string KDLOFDPGKHF();

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(Slot = "1")]
	string CMLLJBLPAFB();
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public interface FDJAODJIBPM<out TOptions> where TOptions : notnull
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	TOptions KAMPPLLIEDO
	{
		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public interface PHGDIFDHKBE
{
	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	string DLCEKGNBBMH
	{
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public sealed class AAJGMCHLPOD<T> : ReadOnlySequenceSegment<T>, IDisposable where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private static AAJGMCHLPOD<T>? GJNCFHOGNPL;

	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private static object FKLADLGIAJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private IMemoryOwner<T>? JOCAPACKOHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private bool LNCJLLPLCHP;

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public bool DAOBNBLDNKM
	{
		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0xC6AD40", Offset = "0xC6A140", VA = "0x180C6AD40")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x4627EF0", Offset = "0x46272F0", VA = "0x184627EF0")]
	private static AAJGMCHLPOD<T> OBPOLAALLFJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x46275A0", Offset = "0x46269A0", VA = "0x1846275A0")]
	private static void LHEBKLPFFNI(AAJGMCHLPOD<T> BNJENKKIPML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x4628820", Offset = "0x4627C20", VA = "0x184628820")]
	private AAJGMCHLPOD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x4627200", Offset = "0x4626600", VA = "0x184627200")]
	public static AAJGMCHLPOD<T> GEEFBNOOFMP(ReadOnlyMemory<T> EIKAHOKNLFN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x4626FF0", Offset = "0x46263F0", VA = "0x184626FF0")]
	public static AAJGMCHLPOD<T> GEEFBNOOFMP(IMemoryOwner<T> PFABKEOCGIB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x4627C60", Offset = "0x4627060", VA = "0x184627C60")]
	public static void NDABBEELBDD(AAJGMCHLPOD<T> PHFEDDJHBBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x4626D70", Offset = "0x4626170", VA = "0x184626D70", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x4627B50", Offset = "0x4626F50", VA = "0x184627B50")]
	public AAJGMCHLPOD<T> MCGKHHLAEEH(IMemoryOwner<T> PFABKEOCGIB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x46284A0", Offset = "0x46278A0", VA = "0x1846284A0")]
	private void ONOMGINPBGE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x4627DA0", Offset = "0x46271A0", VA = "0x184627DA0")]
	private AAJGMCHLPOD<T> OBFEDHEGBPK(AAJGMCHLPOD<T> BNJENKKIPML)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public class JKJPHMJCAFO : Exception
{
	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x7702A80", Offset = "0x7701E80", VA = "0x187702A80")]
	public JKJPHMJCAFO(string LPIFIOEEOGF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public class NHFKLCFBCKB<TOk> : JKJPHMJCAFO where TOk : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public readonly TOk PKDIBKPBODK;

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x4E881B0", Offset = "0x4E875B0", VA = "0x184E881B0")]
	private NHFKLCFBCKB([In] TOk BGCBKEFIMMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x4656ED0", Offset = "0x46562D0", VA = "0x184656ED0")]
	public static NHFKLCFBCKB<TOk> KMDIICJFNJF([In] TOk BGCBKEFIMMH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public readonly struct PHLGGJNOBDN<TOk, TErr> : IEquatable<PHLGGJNOBDN<TOk, TErr>> where TOk : notnull where TErr : notnull
{
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private static readonly EqualityComparer<TErr> EDFIIKANHCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	internal readonly TErr FGJOGBODJCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	internal readonly TOk PKDIBKPBODK;

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public bool JJDOLNGHKLJ
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x5097970", Offset = "0x5096D70", VA = "0x185097970")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public bool CPLHDBGAANK
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x5098E70", Offset = "0x5098270", VA = "0x185098E70")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x5099ED0", Offset = "0x50992D0", VA = "0x185099ED0")]
	internal PHLGGJNOBDN([In] TErr PAIPEEOOJHA, [In] TOk BGCBKEFIMMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x5097770", Offset = "0x5096B70", VA = "0x185097770")]
	public static PHLGGJNOBDN<TOk, TErr> DALCOIIGJNE([In] TErr PAIPEEOOJHA)
	{
		return default(PHLGGJNOBDN<TOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x5098F00", Offset = "0x5098300", VA = "0x185098F00")]
	public static PHLGGJNOBDN<TOk, TErr> OKAJHFLMNEL([In] TOk BGCBKEFIMMH)
	{
		return default(PHLGGJNOBDN<TOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x3AE92B0", Offset = "0x3AE86B0", VA = "0x183AE92B0")]
	public PHLGGJNOBDN<TOk?, UErr?> MLAMIBJIBBJ<UErr>()
	{
		return default(PHLGGJNOBDN<TOk, UErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x3AE8B90", Offset = "0x3AE7F90", VA = "0x183AE8B90")]
	public PHLGGJNOBDN<UOk?, TErr?> EKDMMDDMMOD<UOk>()
	{
		return default(PHLGGJNOBDN<UOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x3AE6FA0", Offset = "0x3AE63A0", VA = "0x183AE6FA0")]
	public PHLGGJNOBDN<UOk?, TErr?> AIJNPDEKEOF<UOk>()
	{
		return default(PHLGGJNOBDN<UOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x3AE8CB0", Offset = "0x3AE80B0", VA = "0x183AE8CB0")]
	public PHLGGJNOBDN<TOk?, UErr?> GIDMHPJODCJ<UErr>()
	{
		return default(PHLGGJNOBDN<TOk, UErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x5098140", Offset = "0x5097540", VA = "0x185098140")]
	public PHLGGJNOBDN<AOFFOIKPJDJ, TErr> GIJMMCKFGFL()
	{
		return default(PHLGGJNOBDN<AOFFOIKPJDJ, TErr>);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x50987C0", Offset = "0x5097BC0", VA = "0x1850987C0")]
	public static bool JECEAGOPPKI([In] PHLGGJNOBDN<TOk, TErr> BBGKOKBOEGA, [In] PHLGGJNOBDN<TOk, TErr> NBNHMPFPBPM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x5097A30", Offset = "0x5096E30", VA = "0x185097A30", Slot = "4")]
	public bool Equals(PHLGGJNOBDN<TOk, TErr> MNALNBMKJLK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x5097E20", Offset = "0x5097220", VA = "0x185097E20", Slot = "0")]
	public override bool Equals(object MNALNBMKJLK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x5098300", Offset = "0x5097700", VA = "0x185098300", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x5099370", Offset = "0x5098770", VA = "0x185099370", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public static class APDCJKOGPPK
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	[CompilerGenerated]
	private struct HNPIAEFNMKO<TOk, TErr> : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		public AsyncTaskMethodBuilder<TOk> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		public Task<PHLGGJNOBDN<TOk, TErr>> self;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private TaskAwaiter<PHLGGJNOBDN<TOk, TErr>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x47587A0", Offset = "0x4757BA0", VA = "0x1847587A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x4759100", Offset = "0x4758500", VA = "0x184759100", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x3BCCD90", Offset = "0x3BCC190", VA = "0x183BCCD90")]
	public static PHLGGJNOBDN<TOk?, TErr?> PKDIBKPBODK<TOk, TErr>([In] this PHLGGJNOBDN<TOk, TErr> IIICNLIAPBJ, [In] TOk BGCBKEFIMMH)
	{
		return default(PHLGGJNOBDN<TOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x3BD0050", Offset = "0x3BCF450", VA = "0x183BD0050")]
	public static PHLGGJNOBDN<AOFFOIKPJDJ, TErr?> PKDIBKPBODK<TErr>([In] this PHLGGJNOBDN<AOFFOIKPJDJ, TErr> IIICNLIAPBJ)
	{
		return default(PHLGGJNOBDN<AOFFOIKPJDJ, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x3BCCD90", Offset = "0x3BCC190", VA = "0x183BCCD90")]
	public static PHLGGJNOBDN<TOk?, TErr?> FGJOGBODJCB<TOk, TErr>([In] this PHLGGJNOBDN<TOk, TErr> IIICNLIAPBJ, [In] TErr PAIPEEOOJHA)
	{
		return default(PHLGGJNOBDN<TOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x3BCC890", Offset = "0x3BCBC90", VA = "0x183BCC890")]
	public static TOk? DMGAEIMEAOE<TOk, TErr>([In] this PHLGGJNOBDN<TOk, TErr> IIICNLIAPBJ)
	{
		return (TOk?)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x3BCEEA0", Offset = "0x3BCE2A0", VA = "0x183BCEEA0")]
	[AsyncStateMachine(typeof(HNPIAEFNMKO<, >))]
	public static Task<TOk?>? NAGHGNLKAKE<TOk, TErr>(this Task<PHLGGJNOBDN<TOk, TErr>> IIICNLIAPBJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x3BCEBE0", Offset = "0x3BCDFE0", VA = "0x183BCEBE0")]
	public static TErr? KPJINMKOAEH<TErr, TOk>([In] this PHLGGJNOBDN<TOk, TErr> IIICNLIAPBJ)
	{
		return (TErr?)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x3BCCF60", Offset = "0x3BCC360", VA = "0x183BCCF60")]
	public static bool GIBKABPJKPP<TOk, TErr, UErr, UOk>([In] this PHLGGJNOBDN<TOk, TErr> IIICNLIAPBJ, [Out] PHLGGJNOBDN<UOk, UErr> BDJKLIBOHIO) where TErr : UErr?
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x3BCF520", Offset = "0x3BCE920", VA = "0x183BCF520")]
	public static bool ONCKKBLEDAK<TOk, TErr>([In] this PHLGGJNOBDN<TOk, TErr> IIICNLIAPBJ, [Out] TOk BGCBKEFIMMH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x3BCE510", Offset = "0x3BCD910", VA = "0x183BCE510")]
	public static bool IPIMJNHECNF<TOk, TErr>([In] this PHLGGJNOBDN<TOk, TErr> IIICNLIAPBJ, [Out][NotNullWhen(true)] TErr PAIPEEOOJHA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x3BCC550", Offset = "0x3BCB950", VA = "0x183BCC550")]
	public static bool AIBPAFMGOIK<TOk, TErr>([In] this PHLGGJNOBDN<TOk, TErr> IIICNLIAPBJ, [Out][NotNullWhen(true)] TOk BGCBKEFIMMH, [Out][NotNullWhen(false)] TErr PAIPEEOOJHA) where TOk : notnull where TErr : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x3BCF420", Offset = "0x3BCE820", VA = "0x183BCF420")]
	public static bool OEIOGPJFOJP<TOk, TErr>([In] this PHLGGJNOBDN<TOk, TErr> IIICNLIAPBJ, [Out][NotNullWhen(true)] TOk BGCBKEFIMMH, [Out] PHLGGJNOBDN<TOk, TErr> BDJKLIBOHIO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x3BCD1C0", Offset = "0x3BCC5C0", VA = "0x183BCD1C0")]
	public static bool GIBKABPJKPP<TOk, TErr, UErr, UOk>([In] this PHLGGJNOBDN<TOk, TErr> IIICNLIAPBJ, [Out][NotNullWhen(true)] TOk BGCBKEFIMMH, [Out] PHLGGJNOBDN<UOk, UErr> BDJKLIBOHIO) where TErr : UErr?
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x3BCE6D0", Offset = "0x3BCDAD0", VA = "0x183BCE6D0")]
	public static bool JALJKFGKGMP<TOk, TErr>([In] this PHLGGJNOBDN<TOk, TErr> IIICNLIAPBJ, [Out][NotNullWhen(true)] TOk BGCBKEFIMMH, [Out] PHLGGJNOBDN<AOFFOIKPJDJ, TErr> BDJKLIBOHIO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x3BCF980", Offset = "0x3BCED80", VA = "0x183BCF980")]
	public static PHLGGJNOBDN<UOk, UErr> PJGHHPGMNMI<UOk, UErr, TOk, TErr>([In] this PHLGGJNOBDN<TOk, TErr> IIICNLIAPBJ, [In] PHLGGJNOBDN<UOk, UErr> NCCMNNBGHEA) where TOk : UOk where TErr : UErr
	{
		return default(PHLGGJNOBDN<UOk, UErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x3BCE140", Offset = "0x3BCD540", VA = "0x183BCE140")]
	public static PHLGGJNOBDN<TOk?[]?, TErr?> ICEOBHLFLFJ<TOk, TErr>(this IEnumerable<PHLGGJNOBDN<TOk, TErr>> IIICNLIAPBJ)
	{
		return default(PHLGGJNOBDN<TOk[], TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x3BCF170", Offset = "0x3BCE570", VA = "0x183BCF170")]
	public static PHLGGJNOBDN<UOk?, TErr?> NNJICJEBNHF<UOk, TErr, TOk>([In] this PHLGGJNOBDN<TOk, TErr> IIICNLIAPBJ, Func<TOk, UOk> AALOGPLBPBL)
	{
		return default(PHLGGJNOBDN<UOk, TErr>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public static class KBDKFOFLJBD<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x385E9A0", Offset = "0x385DDA0", VA = "0x18385E9A0")]
	public static PHLGGJNOBDN<TOk, T> PKDIBKPBODK<TOk>([In] TOk BGCBKEFIMMH) where TOk : notnull
	{
		return default(PHLGGJNOBDN<TOk, T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x4AEB260", Offset = "0x4AEA660", VA = "0x184AEB260")]
	public static PHLGGJNOBDN<AOFFOIKPJDJ, T> PKDIBKPBODK()
	{
		return default(PHLGGJNOBDN<AOFFOIKPJDJ, T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x385E9A0", Offset = "0x385DDA0", VA = "0x18385E9A0")]
	public static PHLGGJNOBDN<T, TErr> FGJOGBODJCB<TErr>([In] TErr PAIPEEOOJHA) where TErr : notnull
	{
		return default(PHLGGJNOBDN<T, TErr>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public readonly struct NEHICBENJDD<TKey, TValue> where TKey : notnull where TValue : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private readonly ACMAMDKOGGI IOLJHLIMHHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private readonly Dictionary<TKey, TValue> NGHMONBEEEN;

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x4BFB300", Offset = "0x4BFA700", VA = "0x184BFB300")]
	public static NEHICBENJDD<TKey, TValue> KMDIICJFNJF(string MEBLJIBNLCL)
	{
		return default(NEHICBENJDD<TKey, TValue>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x4BFB4C0", Offset = "0x4BFA8C0", VA = "0x184BFB4C0")]
	internal NEHICBENJDD(Dictionary<TKey, TValue> PEBNJNGMMHE, ACMAMDKOGGI JGFEGNHPBNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x4BFB420", Offset = "0x4BFA820", VA = "0x184BFB420")]
	public FEFOAAHEMFH<TKey, TValue> NLEKBDCJCFG([Out] Dictionary<TKey, TValue> PEBNJNGMMHE)
	{
		return default(FEFOAAHEMFH<TKey, TValue>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public readonly struct FEFOAAHEMFH<TKey, TValue> : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private readonly Dictionary<TKey, TValue> NGHMONBEEEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private readonly FFKKEBAKDMK BGFGKKFLAHO;

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x27A35E0", Offset = "0x27A29E0", VA = "0x1827A35E0")]
	internal FEFOAAHEMFH(Dictionary<TKey, TValue> PEBNJNGMMHE, FFKKEBAKDMK COLONFNHNGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x44F3FC0", Offset = "0x44F33C0", VA = "0x1844F3FC0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public readonly struct OJOJCNBHOIE<T> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private readonly ACMAMDKOGGI IOLJHLIMHHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private readonly HashSet<T> NGHMONBEEEN;

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x4BFB300", Offset = "0x4BFA700", VA = "0x184BFB300")]
	public static OJOJCNBHOIE<T> KMDIICJFNJF(string MEBLJIBNLCL)
	{
		return default(OJOJCNBHOIE<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x4BFB4C0", Offset = "0x4BFA8C0", VA = "0x184BFB4C0")]
	internal OJOJCNBHOIE(HashSet<T> PEBNJNGMMHE, ACMAMDKOGGI JGFEGNHPBNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x4BFB420", Offset = "0x4BFA820", VA = "0x184BFB420")]
	public NHMAHLDJBFA<T> NLEKBDCJCFG([Out] HashSet<T> PEBNJNGMMHE)
	{
		return default(NHMAHLDJBFA<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public readonly struct NHMAHLDJBFA<T> : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private readonly HashSet<T> NGHMONBEEEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private readonly FFKKEBAKDMK BGFGKKFLAHO;

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x27A35E0", Offset = "0x27A29E0", VA = "0x1827A35E0")]
	internal NHMAHLDJBFA(HashSet<T> PEBNJNGMMHE, FFKKEBAKDMK COLONFNHNGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x44F3FC0", Offset = "0x44F33C0", VA = "0x1844F3FC0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public readonly struct LHDCFFCBPLF<T> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly ACMAMDKOGGI IOLJHLIMHHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private readonly Stack<T> NGHMONBEEEN;

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x4BFB300", Offset = "0x4BFA700", VA = "0x184BFB300")]
	public static LHDCFFCBPLF<T> KMDIICJFNJF(string MEBLJIBNLCL)
	{
		return default(LHDCFFCBPLF<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x4BFB4C0", Offset = "0x4BFA8C0", VA = "0x184BFB4C0")]
	internal LHDCFFCBPLF(Stack<T> PEBNJNGMMHE, ACMAMDKOGGI JGFEGNHPBNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x4BFB420", Offset = "0x4BFA820", VA = "0x184BFB420")]
	public CNAJFNABEJG<T> NLEKBDCJCFG([Out] Stack<T> PEBNJNGMMHE)
	{
		return default(CNAJFNABEJG<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public readonly struct CNAJFNABEJG<T> : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private readonly Stack<T> NGHMONBEEEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private readonly FFKKEBAKDMK BGFGKKFLAHO;

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x27A35E0", Offset = "0x27A29E0", VA = "0x1827A35E0")]
	internal CNAJFNABEJG(Stack<T> PEBNJNGMMHE, FFKKEBAKDMK COLONFNHNGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x44F3FC0", Offset = "0x44F33C0", VA = "0x1844F3FC0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
[DefaultMember("Item")]
public sealed class EMJBJDEPDNG<T> : IEnumerable<T>, IEnumerable where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	private readonly struct FLFCJPIJLGL : IEnumerable<T>, IEnumerable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private readonly EMJBJDEPDNG<T> DLJAHPJAFDH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private readonly int EOFNKODNDPF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private readonly bool DMOMOCDLPPB;

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x24A7840", Offset = "0x24A6C40", VA = "0x1824A7840")]
		public FLFCJPIJLGL(EMJBJDEPDNG<T> FBFIKJCNBGP, int BLNNPGKCFEG, bool HAGDFGJNIIA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x450ED00", Offset = "0x450E100", VA = "0x18450ED00")]
		public EMJBJDEPDNG<T>.FDPLLJJMGIM NFFMPMPKJEP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x450EDF0", Offset = "0x450E1F0", VA = "0x18450EDF0", Slot = "5")]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x450EDF0", Offset = "0x450E1F0", VA = "0x18450EDF0", Slot = "4")]
		IEnumerator<T> IEnumerable<T>.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000032")]
	public sealed class FDPLLJJMGIM : IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private readonly EMJBJDEPDNG<T> DLJAHPJAFDH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private readonly int AIOBHBGKPLM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private int EAGPMMHFMCE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private readonly bool DMOMOCDLPPB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private bool FDPMMOELDJG;

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public T ODFFHKFHEBJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000CF")]
			[Cpp2IlInjected.Address(RVA = "0x44F3490", Offset = "0x44F2890", VA = "0x1844F3490")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		T IEnumerator<T>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000D0")]
			[Cpp2IlInjected.Address(RVA = "0x44F3580", Offset = "0x44F2980", VA = "0x1844F3580", Slot = "4")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		object? IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000D1")]
			[Cpp2IlInjected.Address(RVA = "0x44F3820", Offset = "0x44F2C20", VA = "0x1844F3820", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x44F3EC0", Offset = "0x44F32C0", VA = "0x1844F3EC0")]
		public FDPLLJJMGIM(EMJBJDEPDNG<T> FBFIKJCNBGP, int BLNNPGKCFEG, bool HAGDFGJNIIA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x44F34D0", Offset = "0x44F28D0", VA = "0x1844F34D0", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x44F3560", Offset = "0x44F2960", VA = "0x1844F3560", Slot = "8")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x966900", Offset = "0x965D00", VA = "0x180966900", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000033")]
	[CompilerGenerated]
	private sealed class CGMNMEHPCCE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public Func<T> makeDefault;

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x96D700", Offset = "0x96CB00", VA = "0x18096D700")]
		public CGMNMEHPCCE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x6075F60", Offset = "0x6075360", VA = "0x186075F60")]
		internal T NEJCHNJLNGK(int _)
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private readonly T[] OLIJCBKJMEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private int EAGPMMHFMCE;

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public int EBBMDCMDLLK
	{
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x4132220", Offset = "0x4131620", VA = "0x184132220")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public T ODFFHKFHEBJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x41322C0", Offset = "0x41316C0", VA = "0x1841322C0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public T FCHLGGLFBHJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x4132280", Offset = "0x4131680", VA = "0x184132280")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public T BNGIPFMNGPK
	{
		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x4132060", Offset = "0x4131460", VA = "0x184132060")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public int AKPIBKEABKN
	{
		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x101E660", Offset = "0x101DA60", VA = "0x18101E660")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x189F0C0", Offset = "0x189E4C0", VA = "0x18189F0C0")]
	private static int IBBEDIHFHAH(int FFCBHHABFJN, int EHCAJIFPCLL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x41326B0", Offset = "0x4131AB0", VA = "0x1841326B0")]
	public EMJBJDEPDNG(int NBPEDBIONNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x4132730", Offset = "0x4131B30", VA = "0x184132730")]
	public EMJBJDEPDNG(int NBPEDBIONNC, Func<T> CBIJBOBJLCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x4132A30", Offset = "0x4131E30", VA = "0x184132A30")]
	public EMJBJDEPDNG(T[] GONANEIKMGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x4132300", Offset = "0x4131700", VA = "0x184132300")]
	public void LADICKFGPEE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x41323D0", Offset = "0x41317D0", VA = "0x1841323D0")]
	public IEnumerable<T> NHPJPJLHMEG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x4132330", Offset = "0x4131730", VA = "0x184132330")]
	public EMJBJDEPDNG<T>.FDPLLJJMGIM NFFMPMPKJEP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x4132490", Offset = "0x4131890", VA = "0x184132490", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x4132490", Offset = "0x4131890", VA = "0x184132490", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public static class HGOKHNEFEDO
{
	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x34DF920", Offset = "0x34DED20", VA = "0x1834DF920")]
	public static EMJBJDEPDNG<T> KMDIICJFNJF<T>(int NBPEDBIONNC, Func<T> CBIJBOBJLCL) where T : notnull
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
			[Cpp2IlInjected.Address(RVA = "0x7704620", Offset = "0x7703A20", VA = "0x187704620")]
			get
			{
				return default(RRColor);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public static RRColor Green
		{
			[Cpp2IlInjected.Token(Token = "0x60000DE")]
			[Cpp2IlInjected.Address(RVA = "0x77045E0", Offset = "0x77039E0", VA = "0x1877045E0")]
			get
			{
				return default(RRColor);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public static RRColor Red
		{
			[Cpp2IlInjected.Token(Token = "0x60000DF")]
			[Cpp2IlInjected.Address(RVA = "0x7704600", Offset = "0x7703A00", VA = "0x187704600")]
			get
			{
				return default(RRColor);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public static RRColor Yellow
		{
			[Cpp2IlInjected.Token(Token = "0x60000E0")]
			[Cpp2IlInjected.Address(RVA = "0x7704640", Offset = "0x7703A40", VA = "0x187704640")]
			get
			{
				return default(RRColor);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public static RRColor Cyan
		{
			[Cpp2IlInjected.Token(Token = "0x60000E1")]
			[Cpp2IlInjected.Address(RVA = "0x77045C0", Offset = "0x77039C0", VA = "0x1877045C0")]
			get
			{
				return default(RRColor);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x25AF960", Offset = "0x25AED60", VA = "0x1825AF960")]
		public RRColor(float NPJNBFDHKLI, float KJEKHPMLGHP, float DOGHGFGEHNK, float FJLJDCJDABK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x75D3CC0", Offset = "0x75D30C0", VA = "0x1875D3CC0", Slot = "4")]
		public bool Equals(RRColor MNALNBMKJLK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x7704210", Offset = "0x7703610", VA = "0x187704210", Slot = "0")]
		public override bool Equals(object MNALNBMKJLK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x7704310", Offset = "0x7703710", VA = "0x187704310", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x7704390", Offset = "0x7703790", VA = "0x187704390", Slot = "5")]
		public string ToString(string MCIFFFCOFIA, IFormatProvider OBBHKJCKPJP)
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
			[Cpp2IlInjected.Address(RVA = "0x77041B0", Offset = "0x77035B0", VA = "0x1877041B0")]
			get
			{
				return default(RRColor32);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public static RRColor32 Green
		{
			[Cpp2IlInjected.Token(Token = "0x60000EA")]
			[Cpp2IlInjected.Address(RVA = "0x7704150", Offset = "0x7703550", VA = "0x187704150")]
			get
			{
				return default(RRColor32);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public static RRColor32 Red
		{
			[Cpp2IlInjected.Token(Token = "0x60000EB")]
			[Cpp2IlInjected.Address(RVA = "0x7704180", Offset = "0x7703580", VA = "0x187704180")]
			get
			{
				return default(RRColor32);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public static RRColor32 Yellow
		{
			[Cpp2IlInjected.Token(Token = "0x60000EC")]
			[Cpp2IlInjected.Address(RVA = "0x77041E0", Offset = "0x77035E0", VA = "0x1877041E0")]
			get
			{
				return default(RRColor32);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public static RRColor32 Cyan
		{
			[Cpp2IlInjected.Token(Token = "0x60000ED")]
			[Cpp2IlInjected.Address(RVA = "0x7704120", Offset = "0x7703520", VA = "0x187704120")]
			get
			{
				return default(RRColor32);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x56AA600", Offset = "0x56A9A00", VA = "0x1856AA600")]
		public RRColor32(byte NPJNBFDHKLI, byte KJEKHPMLGHP, byte DOGHGFGEHNK, byte FJLJDCJDABK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x1F60680", Offset = "0x1F5FA80", VA = "0x181F60680", Slot = "4")]
		public bool Equals(RRColor32 MNALNBMKJLK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x7703C80", Offset = "0x7703080", VA = "0x187703C80", Slot = "0")]
		public override bool Equals(object MNALNBMKJLK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x115EB10", Offset = "0x115DF10", VA = "0x18115EB10", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x7703D70", Offset = "0x7703170", VA = "0x187703D70")]
		public static RRColor32 JKGHIELMIOO(RRColor FBGCPEAGLNC)
		{
			return default(RRColor32);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x7703D00", Offset = "0x7703100", VA = "0x187703D00")]
		public static RRColor JKGHIELMIOO(RRColor32 FBGCPEAGLNC)
		{
			return default(RRColor);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x7703EC0", Offset = "0x77032C0", VA = "0x187703EC0", Slot = "5")]
		public string ToString(string MCIFFFCOFIA, IFormatProvider OBBHKJCKPJP)
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public sealed class FKFIINFDCMB<T> : IDisposable where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	public readonly struct HKAGMMJKPKF : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		private readonly FKFIINFDCMB<T> BPENEPLFGFJ;

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public T KAMPPLLIEDO
		{
			[Cpp2IlInjected.Token(Token = "0x60000F4")]
			[Cpp2IlInjected.Address(RVA = "0x4750870", Offset = "0x474FC70", VA = "0x184750870")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x4750890", Offset = "0x474FC90", VA = "0x184750890", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0xC1B040", Offset = "0xC1A440", VA = "0x180C1B040")]
		public HKAGMMJKPKF(FKFIINFDCMB<T> BPENEPLFGFJ)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	[CompilerGenerated]
	private struct EAOOEJOGPMB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public AsyncTaskMethodBuilder<HKAGMMJKPKF> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public FKFIINFDCMB<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x40E2FD0", Offset = "0x40E23D0", VA = "0x1840E2FD0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x40E36F0", Offset = "0x40E2AF0", VA = "0x1840E36F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	private readonly SemaphoreSlim FKDDEFIAHCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	private T MCKNMNFEIAK;

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x450E610", Offset = "0x450DA10", VA = "0x18450E610")]
	public FKFIINFDCMB([In] T MCKNMNFEIAK, int PHEKDDEBKMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x450E3E0", Offset = "0x450D7E0", VA = "0x18450E3E0")]
	public FKFIINFDCMB([In] T MCKNMNFEIAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x450E340", Offset = "0x450D740", VA = "0x18450E340", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x450E380", Offset = "0x450D780", VA = "0x18450E380")]
	public HKAGMMJKPKF FAEKFCMFBJO()
	{
		return default(HKAGMMJKPKF);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x450DEC0", Offset = "0x450D2C0", VA = "0x18450DEC0")]
	[AsyncStateMachine(typeof(FKFIINFDCMB<>.EAOOEJOGPMB))]
	public Task<FKFIINFDCMB<T>.HKAGMMJKPKF> DPLCMOBJEIL(CancellationToken MLAPMBKLAOF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x450E3C0", Offset = "0x450D7C0", VA = "0x18450E3C0")]
	public void PKJBPJIBGJI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public static class FJOGOCCDIMP
{
	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x7701360", Offset = "0x7700760", VA = "0x187701360")]
	public static FKFIINFDCMB<AOFFOIKPJDJ> KMDIICJFNJF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x34828A0", Offset = "0x3481CA0", VA = "0x1834828A0")]
	public static FKFIINFDCMB<T> KMDIICJFNJF<T>([In] T MCKNMNFEIAK) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public sealed class GAHKOFJEIPC<T> : IDisposable where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	public readonly struct BOMMEMGKHMA : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		private readonly GAHKOFJEIPC<T> DBLMOBCLNAM;

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public T KAMPPLLIEDO
		{
			[Cpp2IlInjected.Token(Token = "0x6000100")]
			[Cpp2IlInjected.Address(RVA = "0x4B42550", Offset = "0x4B41950", VA = "0x184B42550")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x5D86FA0", Offset = "0x5D863A0", VA = "0x185D86FA0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0xC1B040", Offset = "0xC1A440", VA = "0x180C1B040")]
		internal BOMMEMGKHMA(GAHKOFJEIPC<T> BPENEPLFGFJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003D")]
	public readonly struct KNMEFKJAICP : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		private readonly GAHKOFJEIPC<T> DBLMOBCLNAM;

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public T KAMPPLLIEDO
		{
			[Cpp2IlInjected.Token(Token = "0x6000103")]
			[Cpp2IlInjected.Address(RVA = "0x4B42550", Offset = "0x4B41950", VA = "0x184B42550")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x4B42570", Offset = "0x4B41970", VA = "0x184B42570", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0xC1B040", Offset = "0xC1A440", VA = "0x180C1B040")]
		internal KNMEFKJAICP(GAHKOFJEIPC<T> BPENEPLFGFJ)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	[CompilerGenerated]
	private struct AFEJNGCCCPP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public AsyncTaskMethodBuilder<KNMEFKJAICP> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public GAHKOFJEIPC<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		private FKFIINFDCMB<AOFFOIKPJDJ>.HKAGMMJKPKF <writeLock>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		private TaskAwaiter<FKFIINFDCMB<AOFFOIKPJDJ>.HKAGMMJKPKF> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x462EFA0", Offset = "0x462E3A0", VA = "0x18462EFA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x40E36F0", Offset = "0x40E2AF0", VA = "0x1840E36F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	private readonly FKFIINFDCMB<int> CBBHJJJKKNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private readonly FKFIINFDCMB<AOFFOIKPJDJ> HDHEGIGKHNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private readonly FKFIINFDCMB<AOFFOIKPJDJ> NJFKMLPCEEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private T IAIEICIOMDF;

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x4625EC0", Offset = "0x46252C0", VA = "0x184625EC0")]
	internal GAHKOFJEIPC(FKFIINFDCMB<int> NCPAGIPBMLE, FKFIINFDCMB<AOFFOIKPJDJ> PNKLMBKPPMI, FKFIINFDCMB<AOFFOIKPJDJ> IOHCEFNPPJM, [In] T MCKNMNFEIAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x4625680", Offset = "0x4624A80", VA = "0x184625680", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x4625280", Offset = "0x4624680", VA = "0x184625280")]
	public BOMMEMGKHMA DKFKDLDOCOB()
	{
		return default(BOMMEMGKHMA);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x4625870", Offset = "0x4624C70", VA = "0x184625870")]
	public KNMEFKJAICP IJMBEPNCDBE()
	{
		return default(KNMEFKJAICP);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x4625C90", Offset = "0x4625090", VA = "0x184625C90")]
	[AsyncStateMachine(typeof(GAHKOFJEIPC<>.AFEJNGCCCPP))]
	public Task<GAHKOFJEIPC<T>.KNMEFKJAICP> LPEFLDNKKIJ(CancellationToken MLAPMBKLAOF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public static class MKMPNPHAIPE
{
	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x7703110", Offset = "0x7702510", VA = "0x187703110")]
	public static GAHKOFJEIPC<AOFFOIKPJDJ> KMDIICJFNJF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x35C2DC0", Offset = "0x35C21C0", VA = "0x1835C2DC0")]
	public static GAHKOFJEIPC<T> KMDIICJFNJF<T>([In] T MCKNMNFEIAK) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public sealed class NJENMEKJKID<TData> : OGPHAGHJAIC where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	public readonly string KONAMMIBLOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	public readonly TData IDIBBHDGOOI;

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x968330", Offset = "0x967730", VA = "0x180968330", Slot = "7")]
	public override string CMLLJBLPAFB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x4E8F1A0", Offset = "0x4E8E5A0", VA = "0x184E8F1A0")]
	internal NJENMEKJKID(string LPIFIOEEOGF, [In] TData MJFOKKFMONL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public static class ICMFMNABHAB
{
	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x77017D0", Offset = "0x7700BD0", VA = "0x1877017D0")]
	public static NJENMEKJKID<AOFFOIKPJDJ> KMDIICJFNJF(string LPIFIOEEOGF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x31FD100", Offset = "0x31FC500", VA = "0x1831FD100")]
	public static NJENMEKJKID<TData> KMDIICJFNJF<TData>(string LPIFIOEEOGF, [In] TData MJFOKKFMONL) where TData : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public sealed class ACMAMDKOGGI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	internal bool GHACAHNMECA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private readonly string APCHDJEJDKE;

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0xD185C0", Offset = "0xD179C0", VA = "0x180D185C0")]
	private ACMAMDKOGGI(bool AKPHHFLLNNL, string OPECHCMDHPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x7700280", Offset = "0x76FF680", VA = "0x187700280")]
	public static ACMAMDKOGGI KMDIICJFNJF(string OPECHCMDHPA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x77002F0", Offset = "0x76FF6F0", VA = "0x1877002F0")]
	public FFKKEBAKDMK NLEKBDCJCFG()
	{
		return default(FFKKEBAKDMK);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public readonly struct FFKKEBAKDMK : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private readonly ACMAMDKOGGI DPJDOOGKAAG;

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0xC1B040", Offset = "0xC1A440", VA = "0x180C1B040")]
	internal FFKKEBAKDMK(ACMAMDKOGGI MEBLJIBNLCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x7701340", Offset = "0x7700740", VA = "0x187701340", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
[Obsolete("Use SimpleTokenFlag or WeakTokenFlag<T> instead")]
public sealed class NJCGFGFFEKA<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	[CompilerGenerated]
	private sealed class JKMDBJMPDAB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public StringBuilder sb;

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x96D700", Offset = "0x96CB00", VA = "0x18096D700")]
		public JKMDBJMPDAB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x4A288E0", Offset = "0x4A27CE0", VA = "0x184A288E0")]
		internal int MIAIDDBFPNM(int i, T token)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private HashSet<T>? DPJCNANGMHL;

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public IReadOnlyCollection<T> DNLGFKBFJAG
	{
		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x4E8ED20", Offset = "0x4E8E120", VA = "0x184E8ED20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public bool HPBCHNALIBD
	{
		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x4E8E9E0", Offset = "0x4E8DDE0", VA = "0x184E8E9E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public int ECPNGLCMABA
	{
		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x9712B0", Offset = "0x9706B0", VA = "0x1809712B0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x973060", Offset = "0x972460", VA = "0x180973060")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x4E8EB10", Offset = "0x4E8DF10", VA = "0x184E8EB10")]
	public bool KAAHFJDOOLK(T OCDOGNMJENC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x4E8ED60", Offset = "0x4E8E160", VA = "0x184E8ED60")]
	public bool PBIACPFCCPC(T OCDOGNMJENC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x4E8ECD0", Offset = "0x4E8E0D0", VA = "0x184E8ECD0")]
	public bool KLNGAEBDGOB(T OCDOGNMJENC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x4E8EA30", Offset = "0x4E8DE30", VA = "0x184E8EA30")]
	public void JEKHHOLIIJM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x4E8EED0", Offset = "0x4E8E2D0", VA = "0x184E8EED0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x96D700", Offset = "0x96CB00", VA = "0x18096D700")]
	public NJCGFGFFEKA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public sealed class MBJBJPKHIHP
{
	[Cpp2IlInjected.Token(Token = "0x2000047")]
	[CompilerGenerated]
	private sealed class BMPPOMCCMFJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public StringBuilder sb;

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x96D700", Offset = "0x96CB00", VA = "0x18096D700")]
		public BMPPOMCCMFJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x7700D40", Offset = "0x7700140", VA = "0x187700D40")]
		internal int MIAIDDBFPNM(int i, object token)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private HashSet<object>? DPJCNANGMHL;

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public IReadOnlyCollection<object> DNLGFKBFJAG
	{
		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x7702E30", Offset = "0x7702230", VA = "0x187702E30")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public bool HPBCHNALIBD
	{
		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x7702C70", Offset = "0x7702070", VA = "0x187702C70")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public int ECPNGLCMABA
	{
		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x9712B0", Offset = "0x9706B0", VA = "0x1809712B0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x973060", Offset = "0x972460", VA = "0x180973060")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x7702CF0", Offset = "0x77020F0", VA = "0x187702CF0")]
	public bool KAAHFJDOOLK(object OCDOGNMJENC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x7702EC0", Offset = "0x77022C0", VA = "0x187702EC0")]
	public bool PBIACPFCCPC(object OCDOGNMJENC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x7702DD0", Offset = "0x77021D0", VA = "0x187702DD0")]
	public bool KLNGAEBDGOB(object OCDOGNMJENC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x7702C80", Offset = "0x7702080", VA = "0x187702C80")]
	public void JEKHHOLIIJM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x7702F60", Offset = "0x7702360", VA = "0x187702F60", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x96D700", Offset = "0x96CB00", VA = "0x18096D700")]
	public MBJBJPKHIHP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public class OJLDDPCEFKM<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000049")]
	private struct HOJCIFJONCC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		public float KCGBFPCDPEB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public T KAMPPLLIEDO;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	private readonly Dictionary<object, HOJCIFJONCC> EHAMKEJBOAG;

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public virtual T GGHFKECIEFK
	{
		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x1767FE0", Offset = "0x17673E0", VA = "0x181767FE0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x1766DD0", Offset = "0x17661D0", VA = "0x181766DD0", Slot = "5")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public object? BOGLOANGOBI
	{
		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x969440", Offset = "0x968840", VA = "0x180969440")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x969460", Offset = "0x968860", VA = "0x180969460")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public bool LBBODLMPHJK
	{
		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x4FAC2D0", Offset = "0x4FAB6D0", VA = "0x184FAC2D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x4FAE0E0", Offset = "0x4FAD4E0", VA = "0x184FAE0E0")]
	public bool KNPDKJDFFPK(T PEBNJNGMMHE, object OCDOGNMJENC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x4A3D740", Offset = "0x4A3CB40", VA = "0x184A3D740")]
	public bool MGBKHCNIAFB(object OCDOGNMJENC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x40F49C0", Offset = "0x40F3DC0", VA = "0x1840F49C0")]
	public void JIMFDDOIBMF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x4FAE5A0", Offset = "0x4FAD9A0", VA = "0x184FAE5A0")]
	public bool POFMAEKIJGP(object OCDOGNMJENC, [Out] T PEBNJNGMMHE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x4FAC330", Offset = "0x4FAB730", VA = "0x184FAC330")]
	[IEAAMAIOELF("T can be T?, `default!` shouldn't be necessary in C# 9")]
	private bool GDCKHAIDNGF()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x4A3DC80", Offset = "0x4A3D080", VA = "0x184A3DC80")]
	public OJLDDPCEFKM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public sealed class OLJLBPMKKKI : JCGFKFOOHMP<JBBPIGEHCDP>
{
	[Cpp2IlInjected.Token(Token = "0x200004B")]
	internal class JANGDKOPFID : IEqualityComparer<JBBPIGEHCDP>
	{
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		internal static readonly JANGDKOPFID AJPLFLPAHGP;

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x77024A0", Offset = "0x77018A0", VA = "0x1877024A0", Slot = "4")]
		public bool Equals(JBBPIGEHCDP COMHOHNLIIN, JBBPIGEHCDP PJGBAACMKFF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x6967720", Offset = "0x6966B20", VA = "0x186967720", Slot = "5")]
		public int GetHashCode(JBBPIGEHCDP NBAMGPFDMIB)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x96D700", Offset = "0x96CB00", VA = "0x18096D700")]
		public JANGDKOPFID()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x7703C10", Offset = "0x7703010", VA = "0x187703C10")]
	public OLJLBPMKKKI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x7703AB0", Offset = "0x7702EB0", VA = "0x187703AB0", Slot = "4")]
	public override bool KAAHFJDOOLK(JBBPIGEHCDP OCDOGNMJENC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x7703B60", Offset = "0x7702F60", VA = "0x187703B60", Slot = "5")]
	public override bool PBIACPFCCPC(JBBPIGEHCDP OCDOGNMJENC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x7703A20", Offset = "0x7702E20", VA = "0x187703A20")]
	private static void ENNCFBOAMJL(JBBPIGEHCDP OCDOGNMJENC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x16882C0", Offset = "0x16876C0", VA = "0x1816882C0", Slot = "6")]
	protected override string TokenToString(JBBPIGEHCDP OCDOGNMJENC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public sealed class JBBPIGEHCDP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private readonly string IJJMEPFFMCL;

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x96D760", Offset = "0x96CB60", VA = "0x18096D760")]
	public JBBPIGEHCDP(string IJJMEPFFMCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x7702530", Offset = "0x7701930", VA = "0x187702530", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public abstract class JCGFKFOOHMP<T> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private readonly IEqualityComparer<T> HMLMHCLAIJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	private HashSet<T>? DPJCNANGMHL;

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public bool HPBCHNALIBD
	{
		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x49F7360", Offset = "0x49F6760", VA = "0x1849F7360")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public int ECPNGLCMABA
	{
		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0xAE5990", Offset = "0xAE4D90", VA = "0x180AE5990")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0xB8DA00", Offset = "0xB8CE00", VA = "0x180B8DA00")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x49F80F0", Offset = "0x49F74F0", VA = "0x1849F80F0")]
	public JCGFKFOOHMP(IEqualityComparer<T> HMLMHCLAIJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x49F7480", Offset = "0x49F6880", VA = "0x1849F7480", Slot = "4")]
	public virtual bool KAAHFJDOOLK(T OCDOGNMJENC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x49F7990", Offset = "0x49F6D90", VA = "0x1849F7990", Slot = "5")]
	public virtual bool PBIACPFCCPC(T OCDOGNMJENC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x49F73A0", Offset = "0x49F67A0", VA = "0x1849F73A0")]
	public void JEKHHOLIIJM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract string TokenToString(T OCDOGNMJENC);

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x49F7DF0", Offset = "0x49F71F0", VA = "0x1849F7DF0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public sealed class NHILLDJBJNG<T> where T : class
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	private List<WeakReference<T>>? DPJCNANGMHL;

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public bool HPBCHNALIBD
	{
		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x4E88D40", Offset = "0x4E88140", VA = "0x184E88D40")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public int ECPNGLCMABA
	{
		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x4E88E60", Offset = "0x4E88260", VA = "0x184E88E60")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x4E89040", Offset = "0x4E88440", VA = "0x184E89040")]
	public void KAAHFJDOOLK(T OCDOGNMJENC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x4E892B0", Offset = "0x4E886B0", VA = "0x184E892B0")]
	public void PBIACPFCCPC(T OCDOGNMJENC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x4E89000", Offset = "0x4E88400", VA = "0x184E89000")]
	public void JEKHHOLIIJM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x4E89450", Offset = "0x4E88850", VA = "0x184E89450", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x96D700", Offset = "0x96CB00", VA = "0x18096D700")]
	public NHILLDJBJNG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
internal static class OOBHAHPGNCE
{
	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x35AD7A0", Offset = "0x35ACBA0", VA = "0x1835AD7A0")]
	public static void BAMMEBECKNL<T>(this List<T> DBJKHFJBKPC, int FFCBHHABFJN) where T : notnull
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public class BIDNODKHLHF<T> where T : notnull, IEquatable<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000051")]
	private struct GMPJJACIGCM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		public float KCGBFPCDPEB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public T KAMPPLLIEDO;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	private readonly Dictionary<JBBPIGEHCDP, GMPJJACIGCM> EHAMKEJBOAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	private readonly EqualityComparer<T> IAEECMPFLBN;

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public virtual T GGHFKECIEFK
	{
		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x96A750", Offset = "0x969B50", VA = "0x18096A750", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x96A740", Offset = "0x969B40", VA = "0x18096A740", Slot = "5")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	private JBBPIGEHCDP? BOGLOANGOBI
	{
		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x969430", Offset = "0x968830", VA = "0x180969430")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public bool LBBODLMPHJK
	{
		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x4FAC2D0", Offset = "0x4FAB6D0", VA = "0x184FAC2D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x5CA2BD0", Offset = "0x5CA1FD0", VA = "0x185CA2BD0")]
	public bool KNPDKJDFFPK(T PEBNJNGMMHE, JBBPIGEHCDP OCDOGNMJENC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x4A3D740", Offset = "0x4A3CB40", VA = "0x184A3D740")]
	public bool MGBKHCNIAFB(JBBPIGEHCDP OCDOGNMJENC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x40F49C0", Offset = "0x40F3DC0", VA = "0x1840F49C0")]
	public void JIMFDDOIBMF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x4FAE7F0", Offset = "0x4FADBF0", VA = "0x184FAE7F0")]
	public bool POFMAEKIJGP(JBBPIGEHCDP OCDOGNMJENC, [Out] T PEBNJNGMMHE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x5CA2800", Offset = "0x5CA1C00", VA = "0x185CA2800")]
	[IEAAMAIOELF("T can be T?, `default!` shouldn't be necessary in C# 9")]
	private bool GDCKHAIDNGF()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x5CA2CD0", Offset = "0x5CA20D0", VA = "0x185CA2CD0")]
	public BIDNODKHLHF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
public class ILMKGLKCGJP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	private readonly Dictionary<object, float> EHAMKEJBOAG;

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public float JHIOKIENJMN
	{
		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0xDED8E0", Offset = "0xDECCE0", VA = "0x180DED8E0")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0xDED8F0", Offset = "0xDECCF0", VA = "0x180DED8F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x7702200", Offset = "0x7701600", VA = "0x187702200")]
	public void KNPDKJDFFPK(float PEBNJNGMMHE, object OCDOGNMJENC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x7702270", Offset = "0x7701670", VA = "0x187702270")]
	public void MGBKHCNIAFB(object OCDOGNMJENC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x77021B0", Offset = "0x77015B0", VA = "0x1877021B0")]
	public void JIMFDDOIBMF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x77022E0", Offset = "0x77016E0", VA = "0x1877022E0")]
	private void OHNFBNELOBH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x7702410", Offset = "0x7701810", VA = "0x187702410")]
	public ILMKGLKCGJP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public interface FPEDHPDMHAE
{
	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event OJABBGPCOCO MOMJALIGJLM;
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
public class IIPINPOLBCP : FPEDHPDMHAE, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000055")]
	public readonly struct IBNJHIAIABH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public readonly float EDANEBCOOOB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public readonly float KIFNJPGIHBF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		internal readonly bool DAHIKGIHLLP;

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		public float KHIDBOMGENB
		{
			[Cpp2IlInjected.Token(Token = "0x600016B")]
			[Cpp2IlInjected.Address(RVA = "0x7701500", Offset = "0x7700900", VA = "0x187701500")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x7701670", Offset = "0x7700A70", VA = "0x187701670")]
		public IBNJHIAIABH(float BGLOMHIAAIH, float ONAEOJELNDF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x7701510", Offset = "0x7700910", VA = "0x187701510", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000056")]
	[CompilerGenerated]
	private sealed class MMEDFODKBAJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		public IIPINPOLBCP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		public int newProgressableIndex;

		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x96D700", Offset = "0x96CB00", VA = "0x18096D700")]
		public MMEDFODKBAJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x77031E0", Offset = "0x77025E0", VA = "0x1877031E0")]
		internal void PDLLANIGPOP(float innerProgress)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	private readonly int JJLMBBEIKLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	private int IPHMOHDMKHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	private readonly FPEDHPDMHAE[] JOENKKJDMMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	private readonly OJABBGPCOCO[] DCHKFKLALGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	private readonly IBNJHIAIABH[] PIMLMOOEOCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	private IBNJHIAIABH CNGDBBLHBIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	private readonly CJKDPIKNJOA HCEGHOCIBOI;

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event OJABBGPCOCO MOMJALIGJLM
	{
		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x7701F60", Offset = "0x7701360", VA = "0x187701F60", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x7701890", Offset = "0x7700C90", VA = "0x187701890", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x7702020", Offset = "0x7701420", VA = "0x187702020")]
	public IIPINPOLBCP(int JJLMBBEIKLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x7701ED0", Offset = "0x77012D0", VA = "0x187701ED0")]
	public CJKDPIKNJOA IMBOIDELGBD(IBNJHIAIABH NBKCBIBCKOC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x7701A60", Offset = "0x7700E60", VA = "0x187701A60")]
	public void EBFEAIDGGDN(FPEDHPDMHAE GMJINJCAJGP, [Optional] IBNJHIAIABH FDNNFNHOBGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x7701950", Offset = "0x7700D50", VA = "0x187701950", Slot = "6")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
public delegate void OJABBGPCOCO(float INBDCPKDEKP);
[Cpp2IlInjected.Token(Token = "0x2000058")]
public static class FKPAOOLKHHL
{
	[Cpp2IlInjected.Token(Token = "0x2000059")]
	private class AJFODDJJMFJ : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		private readonly FPEDHPDMHAE AOBCKBCICMA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		private readonly OJABBGPCOCO LOGLEICCEGM;

		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x7700400", Offset = "0x76FF800", VA = "0x187700400")]
		public AJFODDJJMFJ(FPEDHPDMHAE AOBCKBCICMA, OJABBGPCOCO LOGLEICCEGM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x77003B0", Offset = "0x76FF7B0", VA = "0x1877003B0", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x77013D0", Offset = "0x77007D0", VA = "0x1877013D0")]
	internal static bool BDAGHBEELJH(float FJLJDCJDABK, float DOGHGFGEHNK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x76F0820", Offset = "0x76EFC20", VA = "0x1876F0820")]
	internal static float GGBIKCMFDNP(float FJLJDCJDABK)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x7701440", Offset = "0x7700840", VA = "0x187701440")]
	public static IDisposable CPPEMHGOAAA(this FPEDHPDMHAE AOBCKBCICMA, OJABBGPCOCO LOGLEICCEGM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public class CJKDPIKNJOA : FPEDHPDMHAE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private float INBDCPKDEKP;

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public float NBFHNFLEOEO
	{
		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x7700E90", Offset = "0x7700290", VA = "0x187700E90")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public event OJABBGPCOCO? MOMJALIGJLM
	{
		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x7700F80", Offset = "0x7700380", VA = "0x187700F80", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x7700DF0", Offset = "0x77001F0", VA = "0x187700DF0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x96D700", Offset = "0x96CB00", VA = "0x18096D700")]
	public CJKDPIKNJOA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public interface ELOHJPBAPJH<T> where T : class, new()
{
	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	ADAMNMGJGJE<T> GCBDLOKHDCK([Out] T PEBNJNGMMHE);

	[Cpp2IlInjected.Token(Token = "0x600017C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void JIMFDDOIBMF();
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public class BCPJLHKFMGD<T> : ELOHJPBAPJH<T> where T : class, new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private readonly ConcurrentStack<T> EMNJODEMFLO;

	[Cpp2IlInjected.Token(Token = "0x600017D")]
	[Cpp2IlInjected.Address(RVA = "0x58BC710", Offset = "0x58BBB10", VA = "0x1858BC710", Slot = "4")]
	public ADAMNMGJGJE<T> GCBDLOKHDCK([Out] T PEBNJNGMMHE)
	{
		return default(ADAMNMGJGJE<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(RVA = "0x58BC5F0", Offset = "0x58BB9F0", VA = "0x1858BC5F0")]
	public void BOJBCJAFPNH(T LAPCHBMPHAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0x46704E0", Offset = "0x466F8E0", VA = "0x1846704E0", Slot = "5")]
	public void JIMFDDOIBMF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(RVA = "0x966900", Offset = "0x965D00", VA = "0x180966900", Slot = "6")]
	protected virtual void FCOKLFGGGNN(T JCLDCHBJGNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000181")]
	[Cpp2IlInjected.Address(RVA = "0x58BC670", Offset = "0x58BBA70", VA = "0x1858BC670")]
	private T FCPELJIOJPN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(RVA = "0x58BC7B0", Offset = "0x58BBBB0", VA = "0x1858BC7B0")]
	public BCPJLHKFMGD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
public readonly struct ADAMNMGJGJE<T> : IDisposable where T : class, new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private readonly T LAPCHBMPHAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private readonly BCPJLHKFMGD<T> MJFKDNJHIAN;

	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(RVA = "0x9CC970", Offset = "0x9CBD70", VA = "0x1809CC970")]
	internal ADAMNMGJGJE(T PEBNJNGMMHE, BCPJLHKFMGD<T> MJFKDNJHIAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000184")]
	[Cpp2IlInjected.Address(RVA = "0x462B230", Offset = "0x462A630", VA = "0x18462B230", Slot = "4")]
	void IDisposable.Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
public class LCBCOBFJJJM : BCPJLHKFMGD<StringBuilder>
{
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	public static readonly LCBCOBFJJJM AJPLFLPAHGP;

	[Cpp2IlInjected.Token(Token = "0x6000185")]
	[Cpp2IlInjected.Address(RVA = "0x7702B00", Offset = "0x7701F00", VA = "0x187702B00")]
	public static ADAMNMGJGJE<StringBuilder> FCPELJIOJPN([Out] StringBuilder PEBNJNGMMHE)
	{
		return default(ADAMNMGJGJE<StringBuilder>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000186")]
	[Cpp2IlInjected.Address(RVA = "0x7702AE0", Offset = "0x7701EE0", VA = "0x187702AE0", Slot = "6")]
	protected override void FCOKLFGGGNN(StringBuilder JCLDCHBJGNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(RVA = "0x7702C30", Offset = "0x7702030", VA = "0x187702C30")]
	public LCBCOBFJJJM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
public class BJHJGKNMOLA : InvalidOperationException
{
	[Cpp2IlInjected.Token(Token = "0x6000189")]
	[Cpp2IlInjected.Address(RVA = "0x7073FF0", Offset = "0x70733F0", VA = "0x187073FF0")]
	public BJHJGKNMOLA(string LPIFIOEEOGF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
[DefaultMember("Item")]
public class IJDBFPJBEDG<TKey, TValue> : IGPMMBNEKAH<TKey, TValue>, IDictionary<TKey, TValue>, ICollection<KeyValuePair<TKey, TValue>>, IEnumerable<KeyValuePair<TKey, TValue>>, IEnumerable, AHGLPFCFKAO where TKey : notnull where TValue : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000061")]
	[CompilerGenerated]
	private sealed class LNLPDNPEJAM : IEnumerator<KeyValuePair<TKey, TValue>>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		private KeyValuePair<TKey, TValue> <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		public IJDBFPJBEDG<TKey, TValue> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		private IEnumerator<KeyValuePair<TKey, TValue>> <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		KeyValuePair<TKey, TValue> IEnumerator<KeyValuePair<TKey, TValue>>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001AA")]
			[Cpp2IlInjected.Address(RVA = "0x1767FE0", Offset = "0x17673E0", VA = "0x181767FE0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x45A4990", Offset = "0x45A3D90", VA = "0x1845A4990", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0x968E30", Offset = "0x968230", VA = "0x180968E30")]
		[DebuggerHidden]
		public LNLPDNPEJAM(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x45A4B80", Offset = "0x45A3F80", VA = "0x1845A4B80", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x4C1C570", Offset = "0x4C1B970", VA = "0x184C1C570", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x4C1C520", Offset = "0x4C1B920", VA = "0x184C1C520")]
		private void MHCHPBFCGPJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x4C1C3E0", Offset = "0x4C1B7E0", VA = "0x184C1C3E0")]
		private void GADEEDGNJBE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x4C1D2D0", Offset = "0x4C1C6D0", VA = "0x184C1D2D0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private readonly IGPMMBNEKAH<TKey, TValue> MFJGIODBMHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private readonly IDictionary<TKey, TValue> DOGJLACLFJE;

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public int ECPNGLCMABA
	{
		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x48204D0", Offset = "0x481F8D0", VA = "0x1848204D0", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public bool FBPFCDPCCGG
	{
		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x9AFB60", Offset = "0x9AEF60", VA = "0x1809AFB60", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public TValue BNGIPFMNGPK
	{
		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x4820670", Offset = "0x481FA70", VA = "0x184820670", Slot = "4")]
		get
		{
			return (TValue)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x4820980", Offset = "0x481FD80", VA = "0x184820980", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public ICollection<TKey> GOPICAIOKFC
	{
		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x4820700", Offset = "0x481FB00", VA = "0x184820700", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public ICollection<TValue> DELDPIMGFKH
	{
		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x4820820", Offset = "0x481FC20", VA = "0x184820820", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600018C")]
	[Cpp2IlInjected.Address(RVA = "0x4820340", Offset = "0x481F740", VA = "0x184820340")]
	public IJDBFPJBEDG(IGPMMBNEKAH<TKey, TValue> MFJGIODBMHI, [Optional] IDictionary<TKey, TValue>? DOGJLACLFJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(RVA = "0x481DC20", Offset = "0x481D020", VA = "0x18481DC20", Slot = "15")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000190")]
	[Cpp2IlInjected.Address(RVA = "0x481EC20", Offset = "0x481E020", VA = "0x18481EC20")]
	public void KDIDOPJLADB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(RVA = "0x481D900", Offset = "0x481CD00", VA = "0x18481D900", Slot = "9")]
	public void Add(TKey MCNLCGLNHHO, TValue PEBNJNGMMHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0x481E740", Offset = "0x481DB40", VA = "0x18481E740")]
	public void FHNOHNNDEND(TKey MCNLCGLNHHO, TValue PEBNJNGMMHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(RVA = "0x481E5B0", Offset = "0x481D9B0", VA = "0x18481E5B0")]
	public void FEIJHIGOPLA(TKey MCNLCGLNHHO, TValue PEBNJNGMMHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000194")]
	[Cpp2IlInjected.Address(RVA = "0x481EC70", Offset = "0x481E070", VA = "0x18481EC70")]
	public void KHJFIHCJJHE(TKey MCNLCGLNHHO, TValue PEBNJNGMMHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000195")]
	[Cpp2IlInjected.Address(RVA = "0x481F5F0", Offset = "0x481E9F0", VA = "0x18481F5F0")]
	public void PICHLBBMPIL(TKey MCNLCGLNHHO, TValue PEBNJNGMMHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(RVA = "0x481F940", Offset = "0x481ED40", VA = "0x18481F940", Slot = "14")]
	void ICollection<KeyValuePair<TKey, TValue>>.Add(KeyValuePair<TKey, TValue> BBKCHLGPMMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x481F9D0", Offset = "0x481EDD0", VA = "0x18481F9D0", Slot = "16")]
	bool ICollection<KeyValuePair<TKey, TValue>>.Contains(KeyValuePair<TKey, TValue> BBKCHLGPMMO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(RVA = "0x481FD30", Offset = "0x481F130", VA = "0x18481FD30", Slot = "18")]
	bool ICollection<KeyValuePair<TKey, TValue>>.Remove(KeyValuePair<TKey, TValue> BBKCHLGPMMO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0x481DD60", Offset = "0x481D160", VA = "0x18481DD60", Slot = "8")]
	public bool ContainsKey(TKey MCNLCGLNHHO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(RVA = "0x481F110", Offset = "0x481E510", VA = "0x18481F110")]
	public bool NEGMKPHDOCM(TKey MCNLCGLNHHO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(RVA = "0x481EA00", Offset = "0x481DE00", VA = "0x18481EA00")]
	public bool GGDKOBCPBDO(TKey MCNLCGLNHHO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(RVA = "0x481F7A0", Offset = "0x481EBA0", VA = "0x18481F7A0", Slot = "10")]
	public bool Remove(TKey MCNLCGLNHHO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0x48201A0", Offset = "0x481F5A0", VA = "0x1848201A0", Slot = "11")]
	public bool TryGetValue(TKey MCNLCGLNHHO, [Out] TValue PEBNJNGMMHE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(RVA = "0x481DE20", Offset = "0x481D220", VA = "0x18481DE20", Slot = "17")]
	public void CopyTo(KeyValuePair<TKey, TValue>[] PHAPILEGACC, int BCEHLPADKCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(RVA = "0x4820090", Offset = "0x481F490", VA = "0x184820090", Slot = "20")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A0")]
	[Cpp2IlInjected.Address(RVA = "0x481EB70", Offset = "0x481DF70", VA = "0x18481EB70", Slot = "19")]
	[IteratorStateMachine(typeof(IJDBFPJBEDG<, >.LNLPDNPEJAM))]
	public IEnumerator<KeyValuePair<TKey, TValue>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x481DB30", Offset = "0x481CF30", VA = "0x18481DB30", Slot = "21")]
	public bool BFKDGDANBGL()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(RVA = "0x481F330", Offset = "0x481E730", VA = "0x18481F330")]
	private TValue PFKJFLMBIKE(TKey MCNLCGLNHHO)
	{
		return (TValue)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
public interface KINCIKGLIGN : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000042")]
	string HLOCDENDMJJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
public interface AHGLPFCFKAO
{
	[Cpp2IlInjected.Token(Token = "0x60001AE")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool BFKDGDANBGL();
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
public interface IGPMMBNEKAH<TKey, TVal> : IDictionary<TKey, TVal>, ICollection<KeyValuePair<TKey, TVal>>, IEnumerable<KeyValuePair<TKey, TVal>>, IEnumerable, AHGLPFCFKAO
{
}
[Cpp2IlInjected.Token(Token = "0x2000065")]
[DefaultMember("Item")]
public sealed class EFINIOEALEL<TKey, TVal> : IGPMMBNEKAH<TKey, TVal>, IDictionary<TKey, TVal>, ICollection<KeyValuePair<TKey, TVal>>, IEnumerable<KeyValuePair<TKey, TVal>>, IEnumerable, AHGLPFCFKAO where TKey : notnull where TVal : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000066")]
	public delegate int MNPKGOKPJDC(TKey MCNLCGLNHHO, TVal PEBNJNGMMHE);

	[Cpp2IlInjected.Token(Token = "0x2000067")]
	public delegate void PCKENNIGLLD(TKey MCNLCGLNHHO, TVal PEBNJNGMMHE, NAHGGCMFDAF BBAJBLJIPLG);

	[Cpp2IlInjected.Token(Token = "0x2000068")]
	private class LPJFKFEBBLF
	{
		[Cpp2IlInjected.Token(Token = "0x1700004B")]
		public TKey AMKBEFCENEL
		{
			[Cpp2IlInjected.Token(Token = "0x60001D9")]
			[Cpp2IlInjected.Address(RVA = "0xB40EA0", Offset = "0xB402A0", VA = "0x180B40EA0")]
			[CompilerGenerated]
			get
			{
				return (TKey)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004C")]
		public TVal KAMPPLLIEDO
		{
			[Cpp2IlInjected.Token(Token = "0x60001DA")]
			[Cpp2IlInjected.Address(RVA = "0xAE5990", Offset = "0xAE4D90", VA = "0x180AE5990")]
			[CompilerGenerated]
			get
			{
				return (TVal)null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001DB")]
			[Cpp2IlInjected.Address(RVA = "0xB8DA00", Offset = "0xB8CE00", VA = "0x180B8DA00")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004D")]
		public int KHIDBOMGENB
		{
			[Cpp2IlInjected.Token(Token = "0x60001DC")]
			[Cpp2IlInjected.Address(RVA = "0xC15360", Offset = "0xC14760", VA = "0x180C15360")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60001DD")]
			[Cpp2IlInjected.Address(RVA = "0xDBE660", Offset = "0xDBDA60", VA = "0x180DBE660")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004E")]
		public DateTimeOffset MAIPKDEDKJG
		{
			[Cpp2IlInjected.Token(Token = "0x60001DE")]
			[Cpp2IlInjected.Address(RVA = "0xE11DF0", Offset = "0xE111F0", VA = "0x180E11DF0")]
			[CompilerGenerated]
			get
			{
				return default(DateTimeOffset);
			}
			[Cpp2IlInjected.Token(Token = "0x60001DF")]
			[Cpp2IlInjected.Address(RVA = "0xE11E00", Offset = "0xE11200", VA = "0x180E11E00")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x4C20030", Offset = "0x4C1F430", VA = "0x184C20030")]
		public LPJFKFEBBLF(TKey MCNLCGLNHHO, TVal GHFLHNCPIIL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006A")]
	[CompilerGenerated]
	private sealed class KEBGCOLMDBF : IEnumerator<KeyValuePair<TKey, TVal>>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		private KeyValuePair<TKey, TVal> <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		public EFINIOEALEL<TKey, TVal> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		private LinkedList<LPJFKFEBBLF>.Enumerator <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x1700004F")]
		KeyValuePair<TKey, TVal> IEnumerator<KeyValuePair<TKey, TVal>>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001E9")]
			[Cpp2IlInjected.Address(RVA = "0x1767FE0", Offset = "0x17673E0", VA = "0x181767FE0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x4AF7270", Offset = "0x4AF6670", VA = "0x184AF7270", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x968E30", Offset = "0x968230", VA = "0x180968E30")]
		[DebuggerHidden]
		public KEBGCOLMDBF(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(RVA = "0x459F180", Offset = "0x459E580", VA = "0x18459F180", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0x4AF4970", Offset = "0x4AF3D70", VA = "0x184AF4970", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(RVA = "0x4AF4640", Offset = "0x4AF3A40", VA = "0x184AF4640")]
		private void MHCHPBFCGPJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(RVA = "0x4AF6D70", Offset = "0x4AF6170", VA = "0x184AF6D70", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400009A")]
	public const int BNENKNFPEPK = -1;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private readonly Dictionary<TKey, LinkedListNode<LPJFKFEBBLF>> DAAPINCLLHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private readonly LinkedList<LPJFKFEBBLF> DNONFCEDJBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private readonly MNPKGOKPJDC? FPELGNEKDMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private readonly TimeSpan ODEMNCNAEJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private readonly PCKENNIGLLD? NDCFLLEGBJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	private readonly GHGLMKCGIMF HAGMBLPPNIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	private bool GBCHKOGCMHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	private readonly List<TKey> FKFFPJIKOID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	private readonly List<TVal> GAPBAJHBNLD;

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public int PCGHJECDELA
	{
		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x975090", Offset = "0x974490", VA = "0x180975090")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	internal int NANAJOHCDCB
	{
		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0xC15820", Offset = "0xC14C20", VA = "0x180C15820")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0xD31470", Offset = "0xD30870", VA = "0x180D31470")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	public int ECPNGLCMABA
	{
		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x4110700", Offset = "0x410FB00", VA = "0x184110700", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	internal int CCHFFOGEFOL
	{
		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x40F49C0", Offset = "0x40F3DC0", VA = "0x1840F49C0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	public ICollection<TVal> DELDPIMGFKH
	{
		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x4110880", Offset = "0x410FC80", VA = "0x184110880", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	ICollection<TKey> IDictionary<TKey, TVal>.JFKIDFKDOJM
	{
		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x410A4E0", Offset = "0x41098E0", VA = "0x18410A4E0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	public bool FBPFCDPCCGG
	{
		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x9AFB60", Offset = "0x9AEF60", VA = "0x1809AFB60", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	public TVal BNGIPFMNGPK
	{
		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x4110830", Offset = "0x410FC30", VA = "0x184110830", Slot = "4")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x4110970", Offset = "0x410FD70", VA = "0x184110970", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001B0")]
	[Cpp2IlInjected.Address(RVA = "0x40ED9C0", Offset = "0x40ECDC0", VA = "0x1840ED9C0")]
	private bool AAEHFCDIIPO(int JJLMBBEIKLJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B7")]
	[Cpp2IlInjected.Address(RVA = "0x41089A0", Offset = "0x4107DA0", VA = "0x1841089A0")]
	private void OLMJFGIJHHC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B9")]
	[Cpp2IlInjected.Address(RVA = "0x410F580", Offset = "0x410E980", VA = "0x18410F580")]
	public EFINIOEALEL(int JJLMBBEIKLJ, [Optional] MNPKGOKPJDC? FPELGNEKDMA, [Optional] IEqualityComparer<TKey>? BPKKCOFEOKH, [Optional] PCKENNIGLLD? NDCFLLEGBJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BA")]
	[Cpp2IlInjected.Address(RVA = "0x410BC90", Offset = "0x410B090", VA = "0x18410BC90")]
	public EFINIOEALEL(TimeSpan ODEMNCNAEJA, [Optional] IEqualityComparer<TKey>? BPKKCOFEOKH, [Optional] PCKENNIGLLD? NDCFLLEGBJN, [Optional] GHGLMKCGIMF? HAGMBLPPNIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BB")]
	[Cpp2IlInjected.Address(RVA = "0x410BD00", Offset = "0x410B100", VA = "0x18410BD00")]
	public EFINIOEALEL(int JJLMBBEIKLJ, TimeSpan ODEMNCNAEJA, [Optional] IEqualityComparer<TKey>? BPKKCOFEOKH, [Optional] PCKENNIGLLD? NDCFLLEGBJN, [Optional] GHGLMKCGIMF? HAGMBLPPNIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BC")]
	[Cpp2IlInjected.Address(RVA = "0x410F740", Offset = "0x410EB40", VA = "0x18410F740")]
	public EFINIOEALEL(int JJLMBBEIKLJ, MNPKGOKPJDC? FPELGNEKDMA, TimeSpan ODEMNCNAEJA, [Optional] IEqualityComparer<TKey>? BPKKCOFEOKH, [Optional] PCKENNIGLLD? NDCFLLEGBJN, [Optional] GHGLMKCGIMF? HAGMBLPPNIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BD")]
	[Cpp2IlInjected.Address(RVA = "0x40EFB20", Offset = "0x40EEF20", VA = "0x1840EFB20", Slot = "21")]
	public bool BFKDGDANBGL()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001BE")]
	[Cpp2IlInjected.Address(RVA = "0x40EE1A0", Offset = "0x40ED5A0", VA = "0x1840EE1A0", Slot = "22")]
	public bool ACOCJHFCBEB(int NBPEDBIONNC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001BF")]
	[Cpp2IlInjected.Address(RVA = "0x40FAE20", Offset = "0x40FA220", VA = "0x1840FAE20")]
	private bool JECBDDILMBO(int NBPEDBIONNC, NAHGGCMFDAF BBAJBLJIPLG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C2")]
	[Cpp2IlInjected.Address(RVA = "0x40F6150", Offset = "0x40F5550", VA = "0x1840F6150")]
	public void FHPKMMCODGE(TKey MCNLCGLNHHO, TVal PEBNJNGMMHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C3")]
	[Cpp2IlInjected.Address(RVA = "0x40EEEF0", Offset = "0x40EE2F0", VA = "0x1840EEEF0", Slot = "14")]
	public void Add(KeyValuePair<TKey, TVal> BBKCHLGPMMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C4")]
	[Cpp2IlInjected.Address(RVA = "0x40EF710", Offset = "0x40EEB10", VA = "0x1840EF710", Slot = "9")]
	public void Add(TKey MCNLCGLNHHO, TVal PEBNJNGMMHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C5")]
	[Cpp2IlInjected.Address(RVA = "0x40F1460", Offset = "0x40F0860", VA = "0x1840F1460", Slot = "8")]
	public bool ContainsKey(TKey MCNLCGLNHHO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C6")]
	[Cpp2IlInjected.Address(RVA = "0x4109730", Offset = "0x4108B30", VA = "0x184109730", Slot = "16")]
	bool ICollection<KeyValuePair<TKey, TVal>>.Contains(KeyValuePair<TKey, TVal> BBKCHLGPMMO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C7")]
	[Cpp2IlInjected.Address(RVA = "0x4109620", Offset = "0x4108A20", VA = "0x184109620", Slot = "10")]
	public bool Remove(TKey MCNLCGLNHHO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C8")]
	[Cpp2IlInjected.Address(RVA = "0x410A040", Offset = "0x4109440", VA = "0x18410A040", Slot = "18")]
	bool ICollection<KeyValuePair<TKey, TVal>>.Remove(KeyValuePair<TKey, TVal> BBKCHLGPMMO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C9")]
	[Cpp2IlInjected.Address(RVA = "0x40F0B00", Offset = "0x40EFF00", VA = "0x1840F0B00")]
	private bool CPOOIKDIFDM(TKey MCNLCGLNHHO, [Out] TVal PEBNJNGMMHE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(RVA = "0x40F4A10", Offset = "0x40F3E10", VA = "0x1840F4A10")]
	private TVal FCPELJIOJPN(TKey PIFENPOOLGB)
	{
		return (TVal)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x410AD60", Offset = "0x410A160", VA = "0x18410AD60", Slot = "11")]
	public bool TryGetValue(TKey PIFENPOOLGB, [Out] TVal PEBNJNGMMHE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(RVA = "0x40F12E0", Offset = "0x40F06E0", VA = "0x1840F12E0", Slot = "15")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(RVA = "0x40F2AE0", Offset = "0x40F1EE0", VA = "0x1840F2AE0", Slot = "17")]
	public void CopyTo(KeyValuePair<TKey, TVal>[] PHAPILEGACC, int BCEHLPADKCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CE")]
	[Cpp2IlInjected.Address(RVA = "0x40FFF90", Offset = "0x40FF390", VA = "0x1840FFF90")]
	private void KHFEKBJCLEO(TKey MCNLCGLNHHO, TVal GHFLHNCPIIL, NAHGGCMFDAF BBAJBLJIPLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CF")]
	[Cpp2IlInjected.Address(RVA = "0x40F6CC0", Offset = "0x40F60C0", VA = "0x1840F6CC0")]
	private bool HDBMJLEKDIH(LPJFKFEBBLF GGLEKIEOAGD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D0")]
	[Cpp2IlInjected.Address(RVA = "0x4107940", Offset = "0x4106D40", VA = "0x184107940")]
	private void LJAFCDEDGDE(LinkedListNode<LPJFKFEBBLF> KANGMDDDPPB, TVal HAGHDKMDICJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D1")]
	[Cpp2IlInjected.Address(RVA = "0x4103190", Offset = "0x4102590", VA = "0x184103190")]
	private void KNPDKJDFFPK(TKey MCNLCGLNHHO, TVal PEBNJNGMMHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D2")]
	[Cpp2IlInjected.Address(RVA = "0x40F8C60", Offset = "0x40F8060", VA = "0x1840F8C60")]
	private void IAIBDIGCFIN(LPJFKFEBBLF GGLEKIEOAGD, TVal HAGHDKMDICJ, int JOAOMHFJHAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D3")]
	[Cpp2IlInjected.Address(RVA = "0x40F6470", Offset = "0x40F5870", VA = "0x1840F6470", Slot = "19")]
	[IteratorStateMachine(typeof(EFINIOEALEL<, >.KEBGCOLMDBF))]
	public IEnumerator<KeyValuePair<TKey, TVal>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D4")]
	[Cpp2IlInjected.Address(RVA = "0x410A530", Offset = "0x4109930", VA = "0x18410A530", Slot = "20")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
public enum NAHGGCMFDAF : byte
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
public class IKOJLMLFKCG<TKey> : Exception where TKey : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	public readonly TKey GJDNPFPKJOJ;

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(RVA = "0x4822FE0", Offset = "0x48223E0", VA = "0x184822FE0")]
	public IKOJLMLFKCG(TKey LAEPMNHLBAG, Exception JALIEJNBJJA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006D")]
public class AEHEOPOKHBH : ArgumentException
{
	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0x68F5560", Offset = "0x68F4960", VA = "0x1868F5560")]
	public AEHEOPOKHBH(string LPIFIOEEOGF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006E")]
public class NNPLAJINIJO<TId, TResource> : IEnumerable<(TId, Task<TResource>, int)>, IEnumerable where TId : notnull where TResource : notnull
{
	[Cpp2IlInjected.Token(Token = "0x200006F")]
	[CompilerGenerated]
	private sealed class MKAHLFHIGEE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		public Func<TId, CancellationToken, Task<TResource>> factory;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		public NNPLAJINIJO<TId, TResource> <>4__this;

		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0x96D700", Offset = "0x96CB00", VA = "0x18096D700")]
		public MKAHLFHIGEE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0x4E099F0", Offset = "0x4E08DF0", VA = "0x184E099F0")]
		internal Task<TResource> COKGFAGPDEA(TId _id)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000070")]
	[CompilerGenerated]
	private struct FFOODFOHDIL : IAsyncStateMachine
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
		public NNPLAJINIJO<TId, TResource> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		private TaskAwaiter<TResource> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0x44F8850", Offset = "0x44F7C50", VA = "0x1844F8850", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0x44F90F0", Offset = "0x44F84F0", VA = "0x1844F90F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000071")]
	[CompilerGenerated]
	private struct EKJAKDDEKIB : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x4126180", Offset = "0x4125580", VA = "0x184126180", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(RVA = "0x41268E0", Offset = "0x4125CE0", VA = "0x1841268E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	private readonly KEFGHPGOPCG<TId, Task<TResource>> CDJFGJEBIJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	private readonly Dictionary<Task<TResource>, CancellationTokenSource> MCGEPPAAPCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	private readonly Func<TId, CancellationToken, Task<TResource>>? JJFBJGCMJNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	private readonly Action<TResource>? OGBAGEGNAMP;

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x4E97850", Offset = "0x4E96C50", VA = "0x184E97850")]
	public NNPLAJINIJO(int HFNDDLFCAFE = 0, [Optional] IEqualityComparer<TId>? ODBNDOIIIKA, [Optional] Func<TId, CancellationToken, Task<TResource>>? NKJPDHNEGEL, [Optional] Action<TResource>? OPHBOEDIPNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(RVA = "0x4E974A0", Offset = "0x4E968A0", VA = "0x184E974A0")]
	public NIABGHNBMPF<Task<TResource>> ONLACFFIOOB(TId NNKBGKICBEC, [Optional] Func<TId, CancellationToken, Task<TResource>>? NKJPDHNEGEL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(RVA = "0x4E962A0", Offset = "0x4E956A0", VA = "0x184E962A0")]
	private void GOMHKNFIAAI(Task<TResource> GELALODAJCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(RVA = "0x4E966E0", Offset = "0x4E95AE0", VA = "0x184E966E0")]
	[AsyncStateMachine(typeof(NNPLAJINIJO<, >.FFOODFOHDIL))]
	private Task HAODPPJCFBJ(Task<TResource> GELALODAJCE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(RVA = "0x4E706F0", Offset = "0x4E6FAF0", VA = "0x184E706F0")]
	public void JCNHKONKINB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(RVA = "0x4E96DA0", Offset = "0x4E961A0", VA = "0x184E96DA0")]
	public KEFGHPGOPCG<TId, Task<TResource>>.PLMNFGNBBHI NFFMPMPKJEP()
	{
		return default(KEFGHPGOPCG<TId, Task<TResource>>.PLMNFGNBBHI);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(RVA = "0x4E97710", Offset = "0x4E96B10", VA = "0x184E97710", Slot = "4")]
	private IEnumerator<(TId, Task<TResource>, int)> System.Collections.Generic.IEnumerable<(TIdId,System.Threading.Tasks.Task<TResource>LoadResourceTask,System.Int32RefCount)>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(RVA = "0x4E97710", Offset = "0x4E96B10", VA = "0x184E97710", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(RVA = "0x4E96A10", Offset = "0x4E95E10", VA = "0x184E96A10")]
	[AsyncStateMachine(typeof(NNPLAJINIJO<, >.EKJAKDDEKIB))]
	[CompilerGenerated]
	internal static Task KAPMEKLIHGA(Task<TResource> GELALODAJCE, CancellationTokenSource DJFFBOPMNMO, Dictionary<Task<TResource>, CancellationTokenSource> HCBMAECCJJA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000072")]
public class KEFGHPGOPCG<TKey, TValue> : IEnumerable<(TKey, TValue, int)>, IEnumerable where TKey : notnull where TValue : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000073")]
	private sealed class OPOLKKGNKEK : IEquatable<OPOLKKGNKEK>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		public readonly TValue KAMPPLLIEDO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		public int IGMFBGCLFAP;

		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(RVA = "0x100FF80", Offset = "0x100F380", VA = "0x18100FF80")]
		public OPOLKKGNKEK(TValue PEBNJNGMMHE, int BHKPIBELAIJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(RVA = "0x4FDF9F0", Offset = "0x4FDEDF0", VA = "0x184FDF9F0", Slot = "4")]
		public bool Equals(OPOLKKGNKEK? MNALNBMKJLK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0x4FDF950", Offset = "0x4FDED50", VA = "0x184FDF950", Slot = "0")]
		public override bool Equals(object? NBAMGPFDMIB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000207")]
		[Cpp2IlInjected.Address(RVA = "0x4FDFB10", Offset = "0x4FDEF10", VA = "0x184FDFB10", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000074")]
	public struct PLMNFGNBBHI : IEnumerator<(TKey, TValue, int)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		private Dictionary<TKey, OPOLKKGNKEK>.Enumerator MJICIHCBCIM;

		[Cpp2IlInjected.Token(Token = "0x17000051")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600020C")]
			[Cpp2IlInjected.Address(RVA = "0x50D1400", Offset = "0x50D0800", VA = "0x1850D1400", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000052")]
		public (TKey Key, TValue Value, int RefCount) ODFFHKFHEBJ
		{
			[Cpp2IlInjected.Token(Token = "0x600020D")]
			[Cpp2IlInjected.Address(RVA = "0x50D1A70", Offset = "0x50D0E70", VA = "0x1850D1A70", Slot = "4")]
			get
			{
				return default((TKey, TValue, int));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000208")]
		[Cpp2IlInjected.Address(RVA = "0x50D15F0", Offset = "0x50D09F0", VA = "0x1850D15F0")]
		public PLMNFGNBBHI(KEFGHPGOPCG<TKey, TValue> EHAMKEJBOAG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000209")]
		[Cpp2IlInjected.Address(RVA = "0x50D1060", Offset = "0x50D0460", VA = "0x1850D1060", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020A")]
		[Cpp2IlInjected.Address(RVA = "0x50D10A0", Offset = "0x50D04A0", VA = "0x1850D10A0", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600020B")]
		[Cpp2IlInjected.Address(RVA = "0x50D1210", Offset = "0x50D0610", VA = "0x1850D1210", Slot = "8")]
		public void Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000075")]
	[CompilerGenerated]
	private sealed class FOFDLGNDDPA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		public KEFGHPGOPCG<TKey, TValue> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		public TKey key;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		public OPOLKKGNKEK refCountedValue;

		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0x96D700", Offset = "0x96CB00", VA = "0x18096D700")]
		public FOFDLGNDDPA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0x458DDA0", Offset = "0x458D1A0", VA = "0x18458DDA0")]
		internal void COKGFAGPDEA()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	private readonly Dictionary<TKey, OPOLKKGNKEK> BIHMBKOPNOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	private readonly Func<TKey, TValue>? DGCAGHJKOCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	private readonly Action<TValue>? DJEGBOALAHN;

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x4AF8BC0", Offset = "0x4AF7FC0", VA = "0x184AF8BC0")]
	public KEFGHPGOPCG(int HFNDDLFCAFE = 0, [Optional] IEqualityComparer<TKey>? BPKKCOFEOKH, [Optional] Func<TKey, TValue>? OJHDPOLNKNK, [Optional] Action<TValue>? AMDNIFBDJID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(RVA = "0x4AF7DA0", Offset = "0x4AF71A0", VA = "0x184AF7DA0")]
	public NIABGHNBMPF<TValue> ONLACFFIOOB(TKey MCNLCGLNHHO, [Optional] Func<TKey, TValue>? MNPDGADMAAO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(RVA = "0x4AF72C0", Offset = "0x4AF66C0", VA = "0x184AF72C0")]
	private void BOJBCJAFPNH(TKey MCNLCGLNHHO, OPOLKKGNKEK ICCPKELFPNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000200")]
	[Cpp2IlInjected.Address(RVA = "0x4AF7AC0", Offset = "0x4AF6EC0", VA = "0x184AF7AC0")]
	public void JCNHKONKINB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000201")]
	[Cpp2IlInjected.Address(RVA = "0x4AF7CE0", Offset = "0x4AF70E0", VA = "0x184AF7CE0")]
	public PLMNFGNBBHI NFFMPMPKJEP()
	{
		return default(PLMNFGNBBHI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(RVA = "0x4AF89F0", Offset = "0x4AF7DF0", VA = "0x184AF89F0", Slot = "4")]
	private IEnumerator<(TKey, TValue, int)> System.Collections.Generic.IEnumerable<(TKeyKey,TValueValue,System.Int32RefCount)>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(RVA = "0x4AF89F0", Offset = "0x4AF7DF0", VA = "0x184AF89F0", Slot = "5")]
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
