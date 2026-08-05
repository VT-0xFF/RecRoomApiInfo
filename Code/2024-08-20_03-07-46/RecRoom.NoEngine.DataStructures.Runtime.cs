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
		[Cpp2IlInjected.Address(RVA = "0x87BDE0", Offset = "0x87ADE0", VA = "0x18087BDE0")]
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
		[Cpp2IlInjected.Address(RVA = "0x6A4D290", Offset = "0x6A4C290", VA = "0x186A4D290")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x87C700", Offset = "0x87B700", VA = "0x18087C700")]
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
		[Cpp2IlInjected.Address(RVA = "0x87C740", Offset = "0x87B740", VA = "0x18087C740")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public abstract class LILEKNEGCAA
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x85EB60", Offset = "0x85DB60", VA = "0x18085EB60")]
	protected LILEKNEGCAA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public abstract class CMFNPKMJAFA<T> : LILEKNEGCAA
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	protected struct LIMIIHFNIFE
	{
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		public enum EGOAAAHAMJF
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
		public EGOAAAHAMJF HNGLFCFOHLI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public T JFOAFIPDIOA;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private int LNKDEKBOILI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly bool FMLEIMDPBEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	protected readonly bool AMMGAEEFBPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	protected List<T>? FHHKMAIKNGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private List<LIMIIHFNIFE>? LBOJJIKJHLB;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public bool NJKMIOHJAHJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x55367B0", Offset = "0x55357B0", VA = "0x1855367B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x5536BB0", Offset = "0x5535BB0", VA = "0x185536BB0")]
	protected CMFNPKMJAFA(bool AMMGAEEFBPK, bool FMLEIMDPBEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x5536440", Offset = "0x5535440", VA = "0x185536440")]
	protected bool DJLHOEHIDHE()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x55364E0", Offset = "0x55354E0", VA = "0x1855364E0")]
	protected void EOFONNEKPML()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x55361D0", Offset = "0x55351D0", VA = "0x1855361D0")]
	protected void CHDHHFDOJKE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x2898840", Offset = "0x2897840", VA = "0x182898840")]
	private static void NMEPELANJGM<U>(List<U>? IEKJOJONGFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x5536810", Offset = "0x5535810", VA = "0x185536810", Slot = "4")]
	public void GKAGDNHKNII(T JFOAFIPDIOA, bool NDLMNNIFCKF = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x55365F0", Offset = "0x55355F0", VA = "0x1855365F0", Slot = "5")]
	public void FFDBNDOHLIO(T JFOAFIPDIOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x5536A10", Offset = "0x5535A10", VA = "0x185536A10")]
	public void PKAGCAPLLKG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public sealed class PEHINEDJEEO : CMFNPKMJAFA<Action>
{
	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x6A4D640", Offset = "0x6A4C640", VA = "0x186A4D640")]
	public PEHINEDJEEO(bool AMMGAEEFBPK = false, bool FMLEIMDPBEI = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x6A4D3E0", Offset = "0x6A4C3E0", VA = "0x186A4D3E0")]
	public void GHKHNOGELCE()
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x6A4D380", Offset = "0x6A4C380", VA = "0x186A4D380")]
	public static PEHINEDJEEO COINKPNJNOH(PEHINEDJEEO EHNOOKNJAOJ, Action JFOAFIPDIOA)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x6A4D5E0", Offset = "0x6A4C5E0", VA = "0x186A4D5E0")]
	public static PEHINEDJEEO MKDFLKCFAJP(PEHINEDJEEO EHNOOKNJAOJ, Action JFOAFIPDIOA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface JNHEFPNEIPJ<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void GKAGDNHKNII(Action<T> JFOAFIPDIOA, bool NDLMNNIFCKF = false);

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void FFDBNDOHLIO(Action<T> JFOAFIPDIOA);
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public sealed class HLGIBODIABL<T> : CMFNPKMJAFA<Action<T>>, JNHEFPNEIPJ<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x38A5560", Offset = "0x38A4560", VA = "0x1838A5560")]
	public HLGIBODIABL(bool AMMGAEEFBPK = false, bool FMLEIMDPBEI = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x3DE7560", Offset = "0x3DE6560", VA = "0x183DE7560")]
	public void GHKHNOGELCE(T IGKMAMABJBH)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x3DC1FA0", Offset = "0x3DC0FA0", VA = "0x183DC1FA0")]
	public static HLGIBODIABL<T> COINKPNJNOH(HLGIBODIABL<T> EHNOOKNJAOJ, Action<T> JFOAFIPDIOA)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x3DC27B0", Offset = "0x3DC17B0", VA = "0x183DC27B0")]
	public static HLGIBODIABL<T> MKDFLKCFAJP(HLGIBODIABL<T> EHNOOKNJAOJ, Action<T> JFOAFIPDIOA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface GFINBICJGPG<T, U> where T : notnull where U : notnull
{
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public sealed class DNDLMNGOFAF<T, U> : CMFNPKMJAFA<Action<T, U>>, GFINBICJGPG<T, U> where T : notnull where U : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x38A5560", Offset = "0x38A4560", VA = "0x1838A5560")]
	public DNDLMNGOFAF(bool AMMGAEEFBPK = false, bool FMLEIMDPBEI = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x5890360", Offset = "0x588F360", VA = "0x185890360")]
	public void GHKHNOGELCE(T IGKMAMABJBH, U FCEMFAMODEL)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x3DC1FA0", Offset = "0x3DC0FA0", VA = "0x183DC1FA0")]
	public static DNDLMNGOFAF<T, U> COINKPNJNOH(DNDLMNGOFAF<T, U> EHNOOKNJAOJ, Action<T, U> JFOAFIPDIOA)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x3DC27B0", Offset = "0x3DC17B0", VA = "0x183DC27B0")]
	public static DNDLMNGOFAF<T, U> MKDFLKCFAJP(DNDLMNGOFAF<T, U> EHNOOKNJAOJ, Action<T, U> JFOAFIPDIOA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public sealed class BGDMCGKFNLN<T, U, V> : CMFNPKMJAFA<Action<T, U, V>> where T : notnull where U : notnull where V : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x38A5560", Offset = "0x38A4560", VA = "0x1838A5560")]
	public BGDMCGKFNLN(bool AMMGAEEFBPK = false, bool FMLEIMDPBEI = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x4E8BEA0", Offset = "0x4E8AEA0", VA = "0x184E8BEA0")]
	public void GHKHNOGELCE(T IGKMAMABJBH, U FCEMFAMODEL, V CKOKPBDJPNC)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x3DC1FA0", Offset = "0x3DC0FA0", VA = "0x183DC1FA0")]
	public static BGDMCGKFNLN<T, U, V> COINKPNJNOH(BGDMCGKFNLN<T, U, V> EHNOOKNJAOJ, Action<T, U, V> JFOAFIPDIOA)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x3DC27B0", Offset = "0x3DC17B0", VA = "0x183DC27B0")]
	public static BGDMCGKFNLN<T, U, V> MKDFLKCFAJP(BGDMCGKFNLN<T, U, V> EHNOOKNJAOJ, Action<T, U, V> JFOAFIPDIOA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface EJIIDDBAIBP<T, U, V, W>
{
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public sealed class HIHNBCKGEDJ<T, U, V, W> : CMFNPKMJAFA<Action<T, U, V, W>>, EJIIDDBAIBP<T, U, V, W> where T : notnull where U : notnull where V : notnull where W : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x38A5560", Offset = "0x38A4560", VA = "0x1838A5560")]
	public HIHNBCKGEDJ(bool AMMGAEEFBPK = false, bool FMLEIMDPBEI = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x3DDCFA0", Offset = "0x3DDBFA0", VA = "0x183DDCFA0")]
	public void GHKHNOGELCE(T IGKMAMABJBH, U FCEMFAMODEL, V CKOKPBDJPNC, W EPJGIIKPLND)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x3DC1FA0", Offset = "0x3DC0FA0", VA = "0x183DC1FA0")]
	public static HIHNBCKGEDJ<T, U, V, W> COINKPNJNOH(HIHNBCKGEDJ<T, U, V, W> EHNOOKNJAOJ, Action<T, U, V, W> JFOAFIPDIOA)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x3DC27B0", Offset = "0x3DC17B0", VA = "0x183DC27B0")]
	public static HIHNBCKGEDJ<T, U, V, W> MKDFLKCFAJP(HIHNBCKGEDJ<T, U, V, W> EHNOOKNJAOJ, Action<T, U, V, W> JFOAFIPDIOA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public sealed class HCDEKONOOJI<T, U, V, W, X> : CMFNPKMJAFA<Action<T, U, V, W, X>>
{
	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x38A5560", Offset = "0x38A4560", VA = "0x1838A5560")]
	public HCDEKONOOJI(bool AMMGAEEFBPK = false, bool FMLEIMDPBEI = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x3DC2040", Offset = "0x3DC1040", VA = "0x183DC2040")]
	public void GHKHNOGELCE(T IGKMAMABJBH, U FCEMFAMODEL, V CKOKPBDJPNC, W EPJGIIKPLND, X PONGAOGJLMF)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x3DC1FA0", Offset = "0x3DC0FA0", VA = "0x183DC1FA0")]
	public static HCDEKONOOJI<T, U, V, W, X> COINKPNJNOH(HCDEKONOOJI<T, U, V, W, X> EHNOOKNJAOJ, Action<T, U, V, W, X> JFOAFIPDIOA)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x3DC27B0", Offset = "0x3DC17B0", VA = "0x183DC27B0")]
	public static HCDEKONOOJI<T, U, V, W, X> MKDFLKCFAJP(HCDEKONOOJI<T, U, V, W, X> EHNOOKNJAOJ, Action<T, U, V, W, X> JFOAFIPDIOA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public sealed class DNFMPMKJMMG<T, U, V, W, X, Y> : CMFNPKMJAFA<Action<T, U, V, W, X, Y>>
{
	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x38A5560", Offset = "0x38A4560", VA = "0x1838A5560")]
	public DNFMPMKJMMG(bool AMMGAEEFBPK = false, bool FMLEIMDPBEI = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x5896B30", Offset = "0x5895B30", VA = "0x185896B30")]
	public void GHKHNOGELCE(T IGKMAMABJBH, U FCEMFAMODEL, V CKOKPBDJPNC, W EPJGIIKPLND, X PONGAOGJLMF, Y FOJLHADHAPD)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x3DC1FA0", Offset = "0x3DC0FA0", VA = "0x183DC1FA0")]
	public static DNFMPMKJMMG<T, U, V, W, X, Y> COINKPNJNOH(DNFMPMKJMMG<T, U, V, W, X, Y> EHNOOKNJAOJ, Action<T, U, V, W, X, Y> JFOAFIPDIOA)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x3DC27B0", Offset = "0x3DC17B0", VA = "0x183DC27B0")]
	public static DNFMPMKJMMG<T, U, V, W, X, Y> MKDFLKCFAJP(DNFMPMKJMMG<T, U, V, W, X, Y> EHNOOKNJAOJ, Action<T, U, V, W, X, Y> JFOAFIPDIOA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public class BKIJEMBLMIC<TKey, TVal> where TKey : notnull where TVal : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly KIDOIMPBPFI<TKey, TVal> CKEPALIGKKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	internal readonly Dictionary<TKey, (TVal value, int size)> CHKOAAKAAAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private readonly KIDOIMPBPFI<TKey, TVal>.NDGJCKPGBFK? GIENKCLOHGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private readonly int LAGBOBLGNMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private readonly KIDOIMPBPFI<TKey, TVal>.GCJEKKLLOED? OBMPBELMCMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private int NKHNDBAFKIB;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	internal int IGFDJNMKOKN
	{
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x4E9ACB0", Offset = "0x4E99CB0", VA = "0x184E9ACB0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public int MANBHPILCPK
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x854630", Offset = "0x853630", VA = "0x180854630")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x4E9B750", Offset = "0x4E9A750", VA = "0x184E9B750")]
	public BKIJEMBLMIC(int LAGBOBLGNMM, [Optional] KIDOIMPBPFI<TKey, TVal>.GCJEKKLLOED? OBMPBELMCMA, [Optional] IEqualityComparer<TKey>? KCABKELDGLM, [Optional] KIDOIMPBPFI<TKey, TVal>.NDGJCKPGBFK? GIENKCLOHGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x4E9AD00", Offset = "0x4E99D00", VA = "0x184E9AD00")]
	public void IMBBALDNPND(TKey GMFCIHEFPPO, TVal JJCEIJMGOAB, bool AOKBFOMGMHJ = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x4E9AA60", Offset = "0x4E99A60", VA = "0x184E9AA60")]
	public bool GPIONHAHCKC(TKey GMFCIHEFPPO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x4E9ABC0", Offset = "0x4E99BC0", VA = "0x184E9ABC0")]
	public bool HNEILIJEPGH(TKey GNKBMNIDCFJ, [Out] TVal JJCEIJMGOAB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x4E9A5E0", Offset = "0x4E995E0", VA = "0x184E9A5E0")]
	private void EBLGOKMMCKE(TKey GMFCIHEFPPO, TVal JJCEIJMGOAB, int GHACOABIHDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x4E9A8A0", Offset = "0x4E998A0", VA = "0x184E9A8A0")]
	public bool GKHFJIDOBCI(TKey GMFCIHEFPPO, TVal JJCEIJMGOAB, bool AOKBFOMGMHJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x4E9B6B0", Offset = "0x4E9A6B0", VA = "0x184E9B6B0")]
	public void PKAGCAPLLKG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x4E9B040", Offset = "0x4E9A040", VA = "0x184E9B040")]
	private void NODAFGBPNII()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x4E9A4A0", Offset = "0x4E994A0", VA = "0x184E9A4A0")]
	private bool AHHMMPHKCAC(TKey GMFCIHEFPPO, BMBBIMDJMPC JMFILHLKOGK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x4E9AF20", Offset = "0x4E99F20", VA = "0x184E9AF20")]
	private void LLLHLOLBNPD(TKey GMFCIHEFPPO, TVal JJCEIJMGOAB, BMBBIMDJMPC JMFILHLKOGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x4E9B590", Offset = "0x4E9A590", VA = "0x184E9B590")]
	private void OCPJNGBFOJD(TKey GMFCIHEFPPO, TVal AAINAOCHJJJ, BMBBIMDJMPC JMFILHLKOGK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class CEMHLMHKKEC : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private readonly Action HKFKJFMKPBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private bool EMBMGADKEBB;

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x858C30", Offset = "0x857C30", VA = "0x180858C30")]
	public CEMHLMHKKEC(Action AELCBPEPGGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x6A4B1A0", Offset = "0x6A4A1A0", VA = "0x186A4B1A0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x2995270", Offset = "0x2994270", VA = "0x182995270")]
	public static OKJGCOPDBJF<T> EAPGIKBOING<T>(T JJCEIJMGOAB, Action AELCBPEPGGI) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public sealed class OKJGCOPDBJF<T> : CEMHLMHKKEC where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public T JMEAFIDIDGF
	{
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x854640", Offset = "0x853640", VA = "0x180854640")]
		[CompilerGenerated]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x46F7B00", Offset = "0x46F6B00", VA = "0x1846F7B00")]
	public OKJGCOPDBJF(T JJCEIJMGOAB, Action AELCBPEPGGI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public sealed class HLMANKJDPMC<T> : IDisposable where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private readonly ODPCNGHMLMH<T>? PGIAOKCMMNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private readonly ReadOnlySequence<T> JINHHEMEJDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private bool EMBMGADKEBB;

	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public static readonly HLMANKJDPMC<T> MEMMBNOMLFC;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public ReadOnlySequence<T> ONOOEPMFCAN
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x3DE9DD0", Offset = "0x3DE8DD0", VA = "0x183DE9DD0")]
		get
		{
			return default(ReadOnlySequence<T>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public long NLCDAFOIEDF
	{
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x3DE9F90", Offset = "0x3DE8F90", VA = "0x183DE9F90")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public bool KFCLKKNDODJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x3DEA420", Offset = "0x3DE9420", VA = "0x183DEA420")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x3DEAA80", Offset = "0x3DE9A80", VA = "0x183DEAA80")]
	public HLMANKJDPMC(ODPCNGHMLMH<T> BJLJAMMIHNN, ODPCNGHMLMH<T> CHIHDPEPJMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x3DEAB70", Offset = "0x3DE9B70", VA = "0x183DEAB70")]
	public HLMANKJDPMC(ODPCNGHMLMH<T> BJLJAMMIHNN, int EFHNBALPFBO, ODPCNGHMLMH<T> CHIHDPEPJMG, int IFCLFELEKNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x3DEA9D0", Offset = "0x3DE99D0", VA = "0x183DEA9D0")]
	private HLMANKJDPMC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x3DEA1B0", Offset = "0x3DE91B0", VA = "0x183DEA1B0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x3DEA050", Offset = "0x3DE9050", VA = "0x183DEA050")]
	public T[] DGKGANFODBM()
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x3DEA240", Offset = "0x3DE9240", VA = "0x183DEA240")]
	public static ReadOnlySequence<T> GCCHPLCKKEJ(HLMANKJDPMC<T>? IPBDMIADCAB)
	{
		return default(ReadOnlySequence<T>);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000017")]
public readonly struct DIIOFOPNEPI : IDisposable
{
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public readonly struct JFMCJBKLFPG : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x89A950", Offset = "0x899950", VA = "0x18089A950")]
		public static JFMCJBKLFPG GAKCNKPJGEK()
		{
			return default(JFMCJBKLFPG);
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x853950", Offset = "0x852950", VA = "0x180853950", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x2A0EFF0", Offset = "0x2A0DFF0", VA = "0x182A0EFF0")]
	public static string? NKDNCMGAEMH<T>([Optional] string? MIFIJMKPEHB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x2A0EF70", Offset = "0x2A0DF70", VA = "0x182A0EF70")]
	public static string? CLCINAPCLIB<T>([Optional] string? IMEHACKFNMD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x89A950", Offset = "0x899950", VA = "0x18089A950")]
	public static DIIOFOPNEPI CJEJKMLBKEL(string MIFIJMKPEHB, string? IMEHACKFNMD)
	{
		return default(DIIOFOPNEPI);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x853950", Offset = "0x852950", VA = "0x180853950", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public struct KDGMAMLGGIL
{
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public delegate bool ALKADBNLDDI(string AOIJHFGIGFM, KDGMAMLGGIL HJOFIELOMNN);

	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[CompilerGenerated]
	private sealed class CGDMCMFFCEF<T> where T : notnull, Enum
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public List<int> enumValuesSubset;

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x85EB60", Offset = "0x85DB60", VA = "0x18085EB60")]
		public CGDMCMFFCEF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x527B7B0", Offset = "0x527A7B0", VA = "0x18527B7B0")]
		internal void HGKKOGLAKPD(T x)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public int EIIABACMOFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public string LCHFKOLLLHM;

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x6A4C910", Offset = "0x6A4B910", VA = "0x186A4C910")]
	public static Dictionary<string, KDGMAMLGGIL> PLAOJAPHECN(Type OOJEFOLNJAF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x2C6F080", Offset = "0x2C6E080", VA = "0x182C6F080")]
	public static Dictionary<string, KDGMAMLGGIL> PLAOJAPHECN<T>(Type OOJEFOLNJAF, IReadOnlyDictionary<T, string> LJAPFMCGBIM) where T : notnull, Enum
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x2C6E920", Offset = "0x2C6D920", VA = "0x182C6E920")]
	public static Dictionary<string, KDGMAMLGGIL> CANKMJDMLDM<T>(List<T> KJPHBOCIHMI) where T : notnull, Enum
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x6A4C550", Offset = "0x6A4B550", VA = "0x186A4C550")]
	public static Dictionary<string, KDGMAMLGGIL> LEDDGKOAJIM(Type OOJEFOLNJAF, ALKADBNLDDI JGEDBDKJKFC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x6A4C390", Offset = "0x6A4B390", VA = "0x186A4C390")]
	public static Dictionary<int, string> KOAFKBHKNNL(Dictionary<string, KDGMAMLGGIL> IEJOAHLDAPK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public abstract class DNBIAPHIKOM : GFEHMFEELCO
{
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public static bool EIEDNFHKNLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	private readonly string? HIDJKDAPOLF;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public virtual GFEHMFEELCO? FNKBBKALOCP
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x853960", Offset = "0x852960", VA = "0x180853960", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x6A4B920", Offset = "0x6A4A920", VA = "0x186A4B920")]
	protected DNBIAPHIKOM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(Slot = "7")]
	public abstract string DODDKOCHLNI();

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x6A4B480", Offset = "0x6A4A480", VA = "0x186A4B480", Slot = "8")]
	public virtual string GPAKGMFFNBH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x6A4B560", Offset = "0x6A4A560", VA = "0x186A4B560", Slot = "9")]
	public void PDAPFMJMPEO(StringBuilder ICOELOCEPJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x6A4B500", Offset = "0x6A4A500", VA = "0x186A4B500", Slot = "10")]
	public void MDJIHMLDLBJ(StringBuilder ICOELOCEPJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x6A4B800", Offset = "0x6A4A800", VA = "0x186A4B800", Slot = "11")]
	public void PNGCECCBIPF(StringBuilder ICOELOCEPJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x6A4B280", Offset = "0x6A4A280", VA = "0x186A4B280", Slot = "12")]
	public void CGMOKLNABOK(StringBuilder ICOELOCEPJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x6A4B3E0", Offset = "0x6A4A3E0", VA = "0x186A4B3E0")]
	public static void ECFFODHMABG(StringBuilder ICOELOCEPJB, string MBFNMDDHLBC, string ODLJHGIHJAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x5C100D0", Offset = "0x5C0F0D0", VA = "0x185C100D0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class LIADNODIGLJ : Exception
{
	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x6A4CD90", Offset = "0x6A4BD90", VA = "0x186A4CD90")]
	public LIADNODIGLJ(string KKHEHGHPOAA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class BBNKEAOGPCM<TErr> : LIADNODIGLJ where TErr : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public readonly TErr LGADNLCCAHC;

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x4E734A0", Offset = "0x4E724A0", VA = "0x184E734A0")]
	private BBNKEAOGPCM([In] TErr KECOGJIJDLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x4E733D0", Offset = "0x4E723D0", VA = "0x184E733D0")]
	public static BBNKEAOGPCM<TErr> GAKCNKPJGEK([In] TErr KECOGJIJDLD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class EGPOJDDCDCB : Stream
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private readonly HashAlgorithm LIKGKKLFOGC;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public override bool CNOOMBEFBKO
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x89A950", Offset = "0x899950", VA = "0x18089A950", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public override bool LLNHELIKNIN
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x89A950", Offset = "0x899950", VA = "0x18089A950", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public override bool JFGJOOFKPAO
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x86C5D0", Offset = "0x86B5D0", VA = "0x18086C5D0", Slot = "11")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public override long NLCDAFOIEDF
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x6A4BCC0", Offset = "0x6A4ACC0", VA = "0x186A4BCC0", Slot = "12")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public override long ANCEDMGEKMM
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x6A4BD30", Offset = "0x6A4AD30", VA = "0x186A4BD30", Slot = "13")]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x6A4BDA0", Offset = "0x6A4ADA0", VA = "0x186A4BDA0", Slot = "14")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x6A4BC50", Offset = "0x6A4AC50", VA = "0x186A4BC50")]
	public EGPOJDDCDCB(HashAlgorithm LIKGKKLFOGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x6A4BA70", Offset = "0x6A4AA70", VA = "0x186A4BA70", Slot = "35")]
	public override int Read(byte[] EPDCHNAKJIF, int BEMLKOBANDO, int DOPPKGNLPAC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x6A4BC20", Offset = "0x6A4AC20", VA = "0x186A4BC20", Slot = "38")]
	public override void Write(byte[] EPDCHNAKJIF, int BEMLKOBANDO, int DOPPKGNLPAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x6A4BB10", Offset = "0x6A4AB10", VA = "0x186A4BB10", Slot = "33")]
	public override long Seek(long BEMLKOBANDO, SeekOrigin MAFKHKANKNB)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x6A4BBA0", Offset = "0x6A4ABA0", VA = "0x186A4BBA0", Slot = "34")]
	public override void SetLength(long JJCEIJMGOAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x853950", Offset = "0x852950", VA = "0x180853950", Slot = "23")]
	public override void Flush()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x6A4B990", Offset = "0x6A4A990", VA = "0x186A4B990")]
	public byte[] LFEMKGOKFBB()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public interface GFEHMFEELCO
{
	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(Slot = "0")]
	string GPAKGMFFNBH();

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(Slot = "1")]
	string DODDKOCHLNI();
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public interface KPEPFPOPGOA<out TOptions> where TOptions : notnull
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	TOptions JMEAFIDIDGF
	{
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public interface JOJDDOJMLCJ
{
	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	string NHCHJGFHHAJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public sealed class ODPCNGHMLMH<T> : ReadOnlySequenceSegment<T>, IDisposable where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private static ODPCNGHMLMH<T>? IEAIKPOHGMC;

	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private static object HIAJDOAHGCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private IMemoryOwner<T>? JJNAOELJHHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private bool EMBMGADKEBB;

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public bool HALEFOFGOBN
	{
		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x95D930", Offset = "0x95C930", VA = "0x18095D930")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x46DD670", Offset = "0x46DC670", VA = "0x1846DD670")]
	private static ODPCNGHMLMH<T> AHFCEJLGOJF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x46DE6D0", Offset = "0x46DD6D0", VA = "0x1846DE6D0")]
	private static void JBCBHKOKFAC(ODPCNGHMLMH<T> GMNLKLNEKFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x3F4FD80", Offset = "0x3F4ED80", VA = "0x183F4FD80")]
	private ODPCNGHMLMH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x46DE500", Offset = "0x46DD500", VA = "0x1846DE500")]
	public static ODPCNGHMLMH<T> EAPGIKBOING(ReadOnlyMemory<T> GDDAJLJCBON)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x46DE120", Offset = "0x46DD120", VA = "0x1846DE120")]
	public static ODPCNGHMLMH<T> EAPGIKBOING(IMemoryOwner<T> EPJDGKDKNPK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x46DDB10", Offset = "0x46DCB10", VA = "0x1846DDB10")]
	public static void BKJOJCOLINC(ODPCNGHMLMH<T> BJLJAMMIHNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x46DDEB0", Offset = "0x46DCEB0", VA = "0x1846DDEB0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x46DEF90", Offset = "0x46DDF90", VA = "0x1846DEF90")]
	public ODPCNGHMLMH<T> NGJBLAFJBEA(IMemoryOwner<T> EPJDGKDKNPK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x46DEDB0", Offset = "0x46DDDB0", VA = "0x1846DEDB0")]
	private void MHNCANFEGDG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x46DEC70", Offset = "0x46DDC70", VA = "0x1846DEC70")]
	private ODPCNGHMLMH<T> KJDBIFOEPHO(ODPCNGHMLMH<T> GMNLKLNEKFL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public class FEMOHDAMMOH : Exception
{
	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x6A4C120", Offset = "0x6A4B120", VA = "0x186A4C120")]
	public FEMOHDAMMOH(string KKHEHGHPOAA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public class LGAJLFPCFCH<TOk> : FEMOHDAMMOH where TOk : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public readonly TOk GNBINOCKJLL;

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x42E8230", Offset = "0x42E7230", VA = "0x1842E8230")]
	private LGAJLFPCFCH([In] TOk NJOGAPDLKNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x38AC320", Offset = "0x38AB320", VA = "0x1838AC320")]
	public static LGAJLFPCFCH<TOk> GAKCNKPJGEK([In] TOk NJOGAPDLKNC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public readonly struct DFAHBLOKBPH<TOk, TErr> : IEquatable<DFAHBLOKBPH<TOk, TErr>> where TOk : notnull where TErr : notnull
{
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private static readonly EqualityComparer<TErr> DMFPNCLAPDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	internal readonly TErr LGADNLCCAHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	internal readonly TOk GNBINOCKJLL;

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public bool HKDAPKAPGAK
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x582CAB0", Offset = "0x582BAB0", VA = "0x18582CAB0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public bool MFHHIEKJDDP
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x582C120", Offset = "0x582B120", VA = "0x18582C120")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x582F540", Offset = "0x582E540", VA = "0x18582F540")]
	internal DFAHBLOKBPH([In] TErr KECOGJIJDLD, [In] TOk NJOGAPDLKNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x582CD40", Offset = "0x582BD40", VA = "0x18582CD40")]
	public static DFAHBLOKBPH<TOk, TErr> IADLCNKOANJ([In] TErr KECOGJIJDLD)
	{
		return default(DFAHBLOKBPH<TOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x582DDF0", Offset = "0x582CDF0", VA = "0x18582DDF0")]
	public static DFAHBLOKBPH<TOk, TErr> OFJMHCLIJEP([In] TOk NJOGAPDLKNC)
	{
		return default(DFAHBLOKBPH<TOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x289BED0", Offset = "0x289AED0", VA = "0x18289BED0")]
	public DFAHBLOKBPH<TOk?, UErr?> NONGIENKLIM<UErr>()
	{
		return default(DFAHBLOKBPH<TOk, UErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x289BC90", Offset = "0x289AC90", VA = "0x18289BC90")]
	public DFAHBLOKBPH<UOk?, TErr?> KHNHHBKANGA<UOk>()
	{
		return default(DFAHBLOKBPH<UOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x289D120", Offset = "0x289C120", VA = "0x18289D120")]
	public DFAHBLOKBPH<UOk?, TErr?> PJBIDPHDIHM<UOk>()
	{
		return default(DFAHBLOKBPH<UOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x289B5D0", Offset = "0x289A5D0", VA = "0x18289B5D0")]
	public DFAHBLOKBPH<TOk?, UErr?> FFBIEKLILLM<UErr>()
	{
		return default(DFAHBLOKBPH<TOk, UErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x582B460", Offset = "0x582A460", VA = "0x18582B460")]
	public DFAHBLOKBPH<OKOMLKNINNF, TErr> AJFAMMHHPIF()
	{
		return default(DFAHBLOKBPH<OKOMLKNINNF, TErr>);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x582D320", Offset = "0x582C320", VA = "0x18582D320")]
	public static bool MKBCGNPIJEJ([In] DFAHBLOKBPH<TOk, TErr> OHFIHFHICKK, [In] DFAHBLOKBPH<TOk, TErr> CENGDJBMKEO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x582B580", Offset = "0x582A580", VA = "0x18582B580", Slot = "4")]
	public bool Equals(DFAHBLOKBPH<TOk, TErr> ACBLPNJDJBF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x582B7E0", Offset = "0x582A7E0", VA = "0x18582B7E0", Slot = "0")]
	public override bool Equals(object ACBLPNJDJBF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x582C3B0", Offset = "0x582B3B0", VA = "0x18582C3B0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x582EDA0", Offset = "0x582DDA0", VA = "0x18582EDA0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public static class NJMOFNGGHBE
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	[CompilerGenerated]
	private struct FKAALPCDBPE<TOk, TErr> : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		public AsyncTaskMethodBuilder<TOk> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		public Task<DFAHBLOKBPH<TOk, TErr>> self;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private TaskAwaiter<DFAHBLOKBPH<TOk, TErr>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x3C42420", Offset = "0x3C41420", VA = "0x183C42420", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x3C42D80", Offset = "0x3C41D80", VA = "0x183C42D80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x2D0C890", Offset = "0x2D0B890", VA = "0x182D0C890")]
	public static DFAHBLOKBPH<TOk?, TErr?> GNBINOCKJLL<TOk, TErr>([In] this DFAHBLOKBPH<TOk, TErr> KALCJEIICGB, [In] TOk NJOGAPDLKNC)
	{
		return default(DFAHBLOKBPH<TOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x2D0C940", Offset = "0x2D0B940", VA = "0x182D0C940")]
	public static DFAHBLOKBPH<OKOMLKNINNF, TErr?> GNBINOCKJLL<TErr>([In] this DFAHBLOKBPH<OKOMLKNINNF, TErr> KALCJEIICGB)
	{
		return default(DFAHBLOKBPH<OKOMLKNINNF, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x2D0C890", Offset = "0x2D0B890", VA = "0x182D0C890")]
	public static DFAHBLOKBPH<TOk?, TErr?> LGADNLCCAHC<TOk, TErr>([In] this DFAHBLOKBPH<TOk, TErr> KALCJEIICGB, [In] TErr KECOGJIJDLD)
	{
		return default(DFAHBLOKBPH<TOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x2D0D280", Offset = "0x2D0C280", VA = "0x182D0D280")]
	public static TOk? IOJCPHBOELE<TOk, TErr>([In] this DFAHBLOKBPH<TOk, TErr> KALCJEIICGB)
	{
		return (TOk?)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x2D0D830", Offset = "0x2D0C830", VA = "0x182D0D830")]
	[AsyncStateMachine(typeof(FKAALPCDBPE<, >))]
	public static Task<TOk?>? JPPPKFIBIKI<TOk, TErr>(this Task<DFAHBLOKBPH<TOk, TErr>> KALCJEIICGB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x2D0C470", Offset = "0x2D0B470", VA = "0x182D0C470")]
	public static TErr? DDJEEACBGMF<TErr, TOk>([In] this DFAHBLOKBPH<TOk, TErr> KALCJEIICGB)
	{
		return (TErr?)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x2D0B300", Offset = "0x2D0A300", VA = "0x182D0B300")]
	public static bool AAOOGGACFMK<TOk, TErr, UErr, UOk>([In] this DFAHBLOKBPH<TOk, TErr> KALCJEIICGB, [Out] DFAHBLOKBPH<UOk, UErr> IFNLJKMCIFO) where TErr : UErr?
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x2D0C380", Offset = "0x2D0B380", VA = "0x182D0C380")]
	public static bool BALMMDANGPM<TOk, TErr>([In] this DFAHBLOKBPH<TOk, TErr> KALCJEIICGB, [Out][NotNullWhen(true)] TOk NJOGAPDLKNC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x2D0DE70", Offset = "0x2D0CE70", VA = "0x182D0DE70")]
	public static bool NGPHBPNEKNO<TOk, TErr>([In] this DFAHBLOKBPH<TOk, TErr> KALCJEIICGB, [Out][NotNullWhen(true)] TErr KECOGJIJDLD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x2D0CC70", Offset = "0x2D0BC70", VA = "0x182D0CC70")]
	public static bool IDGGEIAAMGP<TOk, TErr>([In] this DFAHBLOKBPH<TOk, TErr> KALCJEIICGB, [Out][NotNullWhen(true)] TOk NJOGAPDLKNC, [Out][NotNullWhen(false)] TErr KECOGJIJDLD) where TOk : notnull where TErr : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x2D0D180", Offset = "0x2D0C180", VA = "0x182D0D180")]
	public static bool IIJMLBJHEAB<TOk, TErr>([In] this DFAHBLOKBPH<TOk, TErr> KALCJEIICGB, [Out][NotNullWhen(true)] TOk NJOGAPDLKNC, [Out] DFAHBLOKBPH<TOk, TErr> IFNLJKMCIFO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x2D0B1D0", Offset = "0x2D0A1D0", VA = "0x182D0B1D0")]
	public static bool AAOOGGACFMK<TOk, TErr, UErr, UOk>([In] this DFAHBLOKBPH<TOk, TErr> KALCJEIICGB, [Out][NotNullWhen(true)] TOk NJOGAPDLKNC, [Out] DFAHBLOKBPH<UOk, UErr> IFNLJKMCIFO) where TErr : UErr?
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x2D0CDD0", Offset = "0x2D0BDD0", VA = "0x182D0CDD0")]
	public static bool IHAOABGBGJG<TOk, TErr>([In] this DFAHBLOKBPH<TOk, TErr> KALCJEIICGB, [Out][NotNullWhen(true)] TOk NJOGAPDLKNC, [Out] DFAHBLOKBPH<OKOMLKNINNF, TErr> IFNLJKMCIFO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x2D0DFB0", Offset = "0x2D0CFB0", VA = "0x182D0DFB0")]
	public static DFAHBLOKBPH<UOk, UErr> NHPNCGAIEHE<UOk, UErr, TOk, TErr>([In] this DFAHBLOKBPH<TOk, TErr> KALCJEIICGB, [In] DFAHBLOKBPH<UOk, UErr> PGMBMLICCAI) where TOk : UOk where TErr : UErr
	{
		return default(DFAHBLOKBPH<UOk, UErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x2D0DB00", Offset = "0x2D0CB00", VA = "0x182D0DB00")]
	public static DFAHBLOKBPH<TOk?[]?, TErr?> MGKHCMMNDMI<TOk, TErr>(this IEnumerable<DFAHBLOKBPH<TOk, TErr>> KALCJEIICGB)
	{
		return default(DFAHBLOKBPH<TOk[], TErr>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public static class EEPDAOIBGOB<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x2AE1ED0", Offset = "0x2AE0ED0", VA = "0x182AE1ED0")]
	public static DFAHBLOKBPH<TOk, T> GNBINOCKJLL<TOk>([In] TOk NJOGAPDLKNC) where TOk : notnull
	{
		return default(DFAHBLOKBPH<TOk, T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x3891D60", Offset = "0x3890D60", VA = "0x183891D60")]
	public static DFAHBLOKBPH<OKOMLKNINNF, T> GNBINOCKJLL()
	{
		return default(DFAHBLOKBPH<OKOMLKNINNF, T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x2AE1E40", Offset = "0x2AE0E40", VA = "0x182AE1E40")]
	public static DFAHBLOKBPH<T, TErr> LGADNLCCAHC<TErr>([In] TErr KECOGJIJDLD) where TErr : notnull
	{
		return default(DFAHBLOKBPH<T, TErr>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public readonly struct IMCKJKAMEOB<TKey, TValue> where TKey : notnull where TValue : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private readonly KBBDEOGGMLN EDCCOLJGACB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private readonly Dictionary<TKey, TValue> FCMCBJLHAPF;

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x3DFE2C0", Offset = "0x3DFD2C0", VA = "0x183DFE2C0")]
	public static IMCKJKAMEOB<TKey, TValue> GAKCNKPJGEK(string PDLLDMABKGP)
	{
		return default(IMCKJKAMEOB<TKey, TValue>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x3DFE3E0", Offset = "0x3DFD3E0", VA = "0x183DFE3E0")]
	internal IMCKJKAMEOB(Dictionary<TKey, TValue> JJCEIJMGOAB, KBBDEOGGMLN PAAPMAACDBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x3DFE220", Offset = "0x3DFD220", VA = "0x183DFE220")]
	public IDEMDIHFNFG<TKey, TValue> DJMIDOMHGJC([Out] Dictionary<TKey, TValue> JJCEIJMGOAB)
	{
		return default(IDEMDIHFNFG<TKey, TValue>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public readonly struct IDEMDIHFNFG<TKey, TValue> : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private readonly Dictionary<TKey, TValue> FCMCBJLHAPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private readonly LBDAKAFCOBL OALAOEKJMHN;

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x21C8670", Offset = "0x21C7670", VA = "0x1821C8670")]
	internal IDEMDIHFNFG(Dictionary<TKey, TValue> JJCEIJMGOAB, LBDAKAFCOBL KOGAOEAJNFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x3C23100", Offset = "0x3C22100", VA = "0x183C23100", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public readonly struct HOBIFOAKLBM<T> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private readonly KBBDEOGGMLN EDCCOLJGACB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private readonly HashSet<T> FCMCBJLHAPF;

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x3DFE2C0", Offset = "0x3DFD2C0", VA = "0x183DFE2C0")]
	public static HOBIFOAKLBM<T> GAKCNKPJGEK(string PDLLDMABKGP)
	{
		return default(HOBIFOAKLBM<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x3DFE3E0", Offset = "0x3DFD3E0", VA = "0x183DFE3E0")]
	internal HOBIFOAKLBM(HashSet<T> JJCEIJMGOAB, KBBDEOGGMLN PAAPMAACDBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x3DFE220", Offset = "0x3DFD220", VA = "0x183DFE220")]
	public NDIBPBGDNLI<T> DJMIDOMHGJC([Out] HashSet<T> JJCEIJMGOAB)
	{
		return default(NDIBPBGDNLI<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public readonly struct NDIBPBGDNLI<T> : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private readonly HashSet<T> FCMCBJLHAPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private readonly LBDAKAFCOBL OALAOEKJMHN;

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x21C8670", Offset = "0x21C7670", VA = "0x1821C8670")]
	internal NDIBPBGDNLI(HashSet<T> JJCEIJMGOAB, LBDAKAFCOBL KOGAOEAJNFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x3C23100", Offset = "0x3C22100", VA = "0x183C23100", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public readonly struct BNNHEFKLJEM<T> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly KBBDEOGGMLN EDCCOLJGACB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private readonly Stack<T> FCMCBJLHAPF;

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x3DFE2C0", Offset = "0x3DFD2C0", VA = "0x183DFE2C0")]
	public static BNNHEFKLJEM<T> GAKCNKPJGEK(string PDLLDMABKGP)
	{
		return default(BNNHEFKLJEM<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x3DFE3E0", Offset = "0x3DFD3E0", VA = "0x183DFE3E0")]
	internal BNNHEFKLJEM(Stack<T> JJCEIJMGOAB, KBBDEOGGMLN PAAPMAACDBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x3DFE220", Offset = "0x3DFD220", VA = "0x183DFE220")]
	public FDDGEAMAAEM<T> DJMIDOMHGJC([Out] Stack<T> JJCEIJMGOAB)
	{
		return default(FDDGEAMAAEM<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public readonly struct FDDGEAMAAEM<T> : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private readonly Stack<T> FCMCBJLHAPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private readonly LBDAKAFCOBL OALAOEKJMHN;

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x21C8670", Offset = "0x21C7670", VA = "0x1821C8670")]
	internal FDDGEAMAAEM(Stack<T> JJCEIJMGOAB, LBDAKAFCOBL KOGAOEAJNFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x3C23100", Offset = "0x3C22100", VA = "0x183C23100", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
[DefaultMember("Item")]
public sealed class AJDNIJFDEKM<T> : IEnumerable<T>, IEnumerable where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	private readonly struct IAALGJGDDOI : IEnumerable<T>, IEnumerable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private readonly AJDNIJFDEKM<T> HKOHEKBCCKM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private readonly int LICGMKIBKKN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private readonly bool JMDLIEJNBMA;

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x1EF2250", Offset = "0x1EF1250", VA = "0x181EF2250")]
		public IAALGJGDDOI(AJDNIJFDEKM<T> OEFGKJLECGH, int IOBFEMAPLCM, bool KBLEKBOKOPM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x3EAFAD0", Offset = "0x3EAEAD0", VA = "0x183EAFAD0")]
		public AJDNIJFDEKM<T>.OGICDFOFECE EAJKDCOBAGF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x3EAFBC0", Offset = "0x3EAEBC0", VA = "0x183EAFBC0", Slot = "5")]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x3EAFBC0", Offset = "0x3EAEBC0", VA = "0x183EAFBC0", Slot = "4")]
		IEnumerator<T> IEnumerable<T>.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000032")]
	public sealed class OGICDFOFECE : IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private readonly AJDNIJFDEKM<T> HKOHEKBCCKM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private readonly int GFJCEDJJMEL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private int KIBIMPIGGMO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private readonly bool JMDLIEJNBMA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private bool PEDMJLCCKOM;

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public T NIGOAHBKKGN
		{
			[Cpp2IlInjected.Token(Token = "0x60000CB")]
			[Cpp2IlInjected.Address(RVA = "0x46E9BA0", Offset = "0x46E8BA0", VA = "0x1846E9BA0")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		T IEnumerator<T>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000CC")]
			[Cpp2IlInjected.Address(RVA = "0x46E9CD0", Offset = "0x46E8CD0", VA = "0x1846E9CD0", Slot = "4")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		object? IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000CD")]
			[Cpp2IlInjected.Address(RVA = "0x46E9F40", Offset = "0x46E8F40", VA = "0x1846E9F40", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x46EA0E0", Offset = "0x46E90E0", VA = "0x1846EA0E0")]
		public OGICDFOFECE(AJDNIJFDEKM<T> OEFGKJLECGH, int IOBFEMAPLCM, bool KBLEKBOKOPM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x46E9BE0", Offset = "0x46E8BE0", VA = "0x1846E9BE0", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x46E9C70", Offset = "0x46E8C70", VA = "0x1846E9C70", Slot = "8")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x853950", Offset = "0x852950", VA = "0x180853950", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000033")]
	[CompilerGenerated]
	private sealed class DANOPMEFMJN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public Func<T> makeDefault;

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x85EB60", Offset = "0x85DB60", VA = "0x18085EB60")]
		public DANOPMEFMJN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x581FDB0", Offset = "0x581EDB0", VA = "0x18581FDB0")]
		internal T LGBLPIGLEEK(int _)
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private readonly T[] GFDAIILHLGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private int KIBIMPIGGMO;

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public int BKDGFHMDAFC
	{
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x3D21720", Offset = "0x3D20720", VA = "0x183D21720")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public T NIGOAHBKKGN
	{
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x3C10D30", Offset = "0x3C0FD30", VA = "0x183C10D30")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public T BKINHHIOKAO
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x3D21620", Offset = "0x3D20620", VA = "0x183D21620")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public T OMCGAJCFHLP
	{
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x3D21390", Offset = "0x3D20390", VA = "0x183D21390")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public int NLCDAFOIEDF
	{
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x1A29190", Offset = "0x1A28190", VA = "0x181A29190")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x1244980", Offset = "0x1243980", VA = "0x181244980")]
	private static int AIMBABCDMJH(int HCALFJOJKJO, int IGIHBEMLMOK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x3D21780", Offset = "0x3D20780", VA = "0x183D21780")]
	public AJDNIJFDEKM(int GHACOABIHDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x3D21940", Offset = "0x3D20940", VA = "0x183D21940")]
	public AJDNIJFDEKM(int GHACOABIHDA, Func<T> BPDOPNLNHPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x3D218A0", Offset = "0x3D208A0", VA = "0x183D218A0")]
	public AJDNIJFDEKM(T[] AFNCAAOMPCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x3D215F0", Offset = "0x3D205F0", VA = "0x183D215F0")]
	public void KEBHODGMKEA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x3D21660", Offset = "0x3D20660", VA = "0x183D21660")]
	public IEnumerable<T> OFOLEEMILMP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x3D21550", Offset = "0x3D20550", VA = "0x183D21550")]
	public AJDNIJFDEKM<T>.OGICDFOFECE EAJKDCOBAGF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x3CD4B40", Offset = "0x3CD3B40", VA = "0x183CD4B40", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x3CD4B40", Offset = "0x3CD3B40", VA = "0x183CD4B40", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public static class EFILMACLPFF
{
	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x2A31ED0", Offset = "0x2A30ED0", VA = "0x182A31ED0")]
	public static AJDNIJFDEKM<T> GAKCNKPJGEK<T>(int GHACOABIHDA, Func<T> BPDOPNLNHPE) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public sealed class HDMGOLPHDBL<T> : IDisposable where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	public readonly struct HBFHALBEKCH : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private readonly HDMGOLPHDBL<T> ENEMKAFOMMC;

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public T JMEAFIDIDGF
		{
			[Cpp2IlInjected.Token(Token = "0x60000DA")]
			[Cpp2IlInjected.Address(RVA = "0x3DC1D10", Offset = "0x3DC0D10", VA = "0x183DC1D10")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x3DC1CE0", Offset = "0x3DC0CE0", VA = "0x183DC1CE0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0xA111F0", Offset = "0xA101F0", VA = "0x180A111F0")]
		public HBFHALBEKCH(HDMGOLPHDBL<T> ENEMKAFOMMC)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	[CompilerGenerated]
	private struct ACBLBKLNOHK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public AsyncTaskMethodBuilder<HBFHALBEKCH> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public HDMGOLPHDBL<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x3CEBD80", Offset = "0x3CEAD80", VA = "0x183CEBD80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x387D5A0", Offset = "0x387C5A0", VA = "0x18387D5A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private readonly SemaphoreSlim IIPKCHJCLML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private T APCOPGLENMB;

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x3DC5B20", Offset = "0x3DC4B20", VA = "0x183DC5B20")]
	public HDMGOLPHDBL([In] T APCOPGLENMB, int JOGHJLGPCHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x3DC59A0", Offset = "0x3DC49A0", VA = "0x183DC59A0")]
	public HDMGOLPHDBL([In] T APCOPGLENMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x3DC53D0", Offset = "0x3DC43D0", VA = "0x183DC53D0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x3DC58B0", Offset = "0x3DC48B0", VA = "0x183DC58B0")]
	public HBFHALBEKCH LOBGFLIEACE()
	{
		return default(HBFHALBEKCH);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x3DC5770", Offset = "0x3DC4770", VA = "0x183DC5770")]
	[AsyncStateMachine(typeof(HDMGOLPHDBL<>.ACBLBKLNOHK))]
	public Task<HDMGOLPHDBL<T>.HBFHALBEKCH> LKEPCKHFNMC(CancellationToken LABHBAHABKB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x3DC5890", Offset = "0x3DC4890", VA = "0x183DC5890")]
	public void LMNAOHPMBPK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public static class OCAICEGCJNP
{
	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x6A4D310", Offset = "0x6A4C310", VA = "0x186A4D310")]
	public static HDMGOLPHDBL<OKOMLKNINNF> GAKCNKPJGEK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x2BB96B0", Offset = "0x2BB86B0", VA = "0x182BB96B0")]
	public static HDMGOLPHDBL<T> GAKCNKPJGEK<T>([In] T APCOPGLENMB) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public sealed class PKDFNMPOBDA<T> : IDisposable where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	public readonly struct GCIHDDLMLOF : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		private readonly PKDFNMPOBDA<T> IIDKHNBOOJG;

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public T JMEAFIDIDGF
		{
			[Cpp2IlInjected.Token(Token = "0x60000E6")]
			[Cpp2IlInjected.Address(RVA = "0x3D36FD0", Offset = "0x3D35FD0", VA = "0x183D36FD0")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x3D36C70", Offset = "0x3D35C70", VA = "0x183D36C70", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0xA111F0", Offset = "0xA101F0", VA = "0x180A111F0")]
		internal GCIHDDLMLOF(PKDFNMPOBDA<T> ENEMKAFOMMC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003B")]
	public readonly struct LAPIIELFGCI : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		private readonly PKDFNMPOBDA<T> IIDKHNBOOJG;

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public T JMEAFIDIDGF
		{
			[Cpp2IlInjected.Token(Token = "0x60000E9")]
			[Cpp2IlInjected.Address(RVA = "0x3D36FD0", Offset = "0x3D35FD0", VA = "0x183D36FD0")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x42D6CB0", Offset = "0x42D5CB0", VA = "0x1842D6CB0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0xA111F0", Offset = "0xA101F0", VA = "0x180A111F0")]
		internal LAPIIELFGCI(PKDFNMPOBDA<T> ENEMKAFOMMC)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	[CompilerGenerated]
	private struct CDDPFNBHGEJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public AsyncTaskMethodBuilder<LAPIIELFGCI> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public PKDFNMPOBDA<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		private HDMGOLPHDBL<OKOMLKNINNF>.HBFHALBEKCH <writeLock>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		private TaskAwaiter<HDMGOLPHDBL<OKOMLKNINNF>.HBFHALBEKCH> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x5192190", Offset = "0x5191190", VA = "0x185192190", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x387D5A0", Offset = "0x387C5A0", VA = "0x18387D5A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	private readonly HDMGOLPHDBL<int> HEKFJKAIDOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	private readonly HDMGOLPHDBL<OKOMLKNINNF> CEGPGBMDFHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	private readonly HDMGOLPHDBL<OKOMLKNINNF> LCJLNPNKNAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	private T AIGPAGLDIDC;

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x47ABE60", Offset = "0x47AAE60", VA = "0x1847ABE60")]
	internal PKDFNMPOBDA(HDMGOLPHDBL<int> JPAJEIPGILA, HDMGOLPHDBL<OKOMLKNINNF> ICCFEPGAFBA, HDMGOLPHDBL<OKOMLKNINNF> GODLNNNHIJE, [In] T APCOPGLENMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x47AB170", Offset = "0x47AA170", VA = "0x1847AB170", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x47AB5C0", Offset = "0x47AA5C0", VA = "0x1847AB5C0")]
	public GCIHDDLMLOF MIPAHJGEBFN()
	{
		return default(GCIHDDLMLOF);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x47AB3E0", Offset = "0x47AA3E0", VA = "0x1847AB3E0")]
	public LAPIIELFGCI GJJFJNBFMKE()
	{
		return default(LAPIIELFGCI);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x47ABC20", Offset = "0x47AAC20", VA = "0x1847ABC20")]
	[AsyncStateMachine(typeof(PKDFNMPOBDA<>.CDDPFNBHGEJ))]
	public Task<PKDFNMPOBDA<T>.LAPIIELFGCI> NDDKMHPJIFM(CancellationToken LABHBAHABKB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public static class FEDKMKPIBNK
{
	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x6A4C050", Offset = "0x6A4B050", VA = "0x186A4C050")]
	public static PKDFNMPOBDA<OKOMLKNINNF> GAKCNKPJGEK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x2BA4B60", Offset = "0x2BA3B60", VA = "0x182BA4B60")]
	public static PKDFNMPOBDA<T> GAKCNKPJGEK<T>([In] T APCOPGLENMB) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public sealed class PLMMBNNPNKC<TData> : DNBIAPHIKOM where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	public readonly string LOFJHBNFKMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	public readonly TData KHBLMBBNMIA;

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x8517C0", Offset = "0x8507C0", VA = "0x1808517C0", Slot = "7")]
	public override string DODDKOCHLNI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x47AD660", Offset = "0x47AC660", VA = "0x1847AD660")]
	internal PLMMBNNPNKC(string KKHEHGHPOAA, [In] TData AHGAPHMJDIB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public static class CDFJKHMNPDK
{
	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x6A4B120", Offset = "0x6A4A120", VA = "0x186A4B120")]
	public static PLMMBNNPNKC<OKOMLKNINNF> GAKCNKPJGEK(string KKHEHGHPOAA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x2995270", Offset = "0x2994270", VA = "0x182995270")]
	public static PLMMBNNPNKC<TData> GAKCNKPJGEK<TData>(string KKHEHGHPOAA, [In] TData AHGAPHMJDIB) where TData : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public sealed class KBBDEOGGMLN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	internal bool DJAIFDCGJJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private readonly string DLKOIOAGHDF;

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x1181D00", Offset = "0x1180D00", VA = "0x181181D00")]
	private KBBDEOGGMLN(bool COIFHPNCBML, string EPPJDCMGDEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x6A4C320", Offset = "0x6A4B320", VA = "0x186A4C320")]
	public static KBBDEOGGMLN GAKCNKPJGEK(string EPPJDCMGDEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x6A4C260", Offset = "0x6A4B260", VA = "0x186A4C260")]
	public LBDAKAFCOBL DJMIDOMHGJC()
	{
		return default(LBDAKAFCOBL);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public readonly struct LBDAKAFCOBL : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private readonly KBBDEOGGMLN FLIKFFPFKKH;

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0xA111F0", Offset = "0xA101F0", VA = "0x180A111F0")]
	internal LBDAKAFCOBL(KBBDEOGGMLN PDLLDMABKGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x6A4CD70", Offset = "0x6A4BD70", VA = "0x186A4CD70", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public class AAMILACCMMH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private readonly Dictionary<object, float> PDKIFAKOONJ;

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public float NAKECNOMGDB
	{
		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x99AE70", Offset = "0x999E70", VA = "0x18099AE70")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0xFA73D0", Offset = "0xFA63D0", VA = "0x180FA73D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x6A4A310", Offset = "0x6A49310", VA = "0x186A4A310")]
	public void CPIPAMHCHDK(float JJCEIJMGOAB, object DJIBMMAIGPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x6A4A380", Offset = "0x6A49380", VA = "0x186A4A380")]
	public void FDNJFPDHLCC(object DJIBMMAIGPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x6A4A520", Offset = "0x6A49520", VA = "0x186A4A520")]
	public void PKAGCAPLLKG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x6A4A3F0", Offset = "0x6A493F0", VA = "0x186A4A3F0")]
	private void JFEMNBPJCJM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x6A4A570", Offset = "0x6A49570", VA = "0x186A4A570")]
	public AAMILACCMMH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public sealed class OBAAALPDOHL<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	[CompilerGenerated]
	private sealed class HELGFFBDNIO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public StringBuilder sb;

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x85EB60", Offset = "0x85DB60", VA = "0x18085EB60")]
		public HELGFFBDNIO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x3DC6AE0", Offset = "0x3DC5AE0", VA = "0x183DC6AE0")]
		internal int NJPIBOGKOOM(int i, T token)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private HashSet<T>? GKBCMBINOEA;

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public IReadOnlyCollection<T> KAKPDKDJFKH
	{
		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x46D74E0", Offset = "0x46D64E0", VA = "0x1846D74E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public bool IDBOCGMNJDA
	{
		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x46D7760", Offset = "0x46D6760", VA = "0x1846D7760")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public int DHMBIHOHONP
	{
		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x85BDB0", Offset = "0x85ADB0", VA = "0x18085BDB0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x85BDC0", Offset = "0x85ADC0", VA = "0x18085BDC0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x46D77A0", Offset = "0x46D67A0", VA = "0x1846D77A0")]
	public bool GKAGDNHKNII(T DJIBMMAIGPE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x46D75F0", Offset = "0x46D65F0", VA = "0x1846D75F0")]
	public bool FFDBNDOHLIO(T DJIBMMAIGPE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x46D7960", Offset = "0x46D6960", VA = "0x1846D7960")]
	public bool HODGCICEPOA(T DJIBMMAIGPE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x46D7520", Offset = "0x46D6520", VA = "0x1846D7520")]
	public void EGIJBDHAFPN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x46D79B0", Offset = "0x46D69B0", VA = "0x1846D79B0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x85EB60", Offset = "0x85DB60", VA = "0x18085EB60")]
	public OBAAALPDOHL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public class AIBHHEDLNAL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private readonly string NCMHPFHKKAK;

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x858C30", Offset = "0x857C30", VA = "0x180858C30")]
	public AIBHHEDLNAL(string NCMHPFHKKAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x6A4A600", Offset = "0x6A49600", VA = "0x186A4A600", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public sealed class MBGIGHPFJLL
{
	[Cpp2IlInjected.Token(Token = "0x2000047")]
	[CompilerGenerated]
	private sealed class PLCPOAPAANC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public StringBuilder sb;

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x85EB60", Offset = "0x85DB60", VA = "0x18085EB60")]
		public PLCPOAPAANC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x6A4D980", Offset = "0x6A4C980", VA = "0x186A4D980")]
		internal int NJPIBOGKOOM(int i, object token)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private HashSet<object>? GKBCMBINOEA;

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public IReadOnlyCollection<object> KAKPDKDJFKH
	{
		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x6A4CDF0", Offset = "0x6A4BDF0", VA = "0x186A4CDF0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public bool IDBOCGMNJDA
	{
		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x6A4CF90", Offset = "0x6A4BF90", VA = "0x186A4CF90")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public int DHMBIHOHONP
	{
		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x85BDB0", Offset = "0x85ADB0", VA = "0x18085BDB0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x85BDC0", Offset = "0x85ADC0", VA = "0x18085BDC0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x6A4CFA0", Offset = "0x6A4BFA0", VA = "0x186A4CFA0")]
	public bool GKAGDNHKNII(object DJIBMMAIGPE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x6A4CEF0", Offset = "0x6A4BEF0", VA = "0x186A4CEF0")]
	public bool FFDBNDOHLIO(object DJIBMMAIGPE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x6A4D080", Offset = "0x6A4C080", VA = "0x186A4D080")]
	public bool HODGCICEPOA(object DJIBMMAIGPE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x6A4CE80", Offset = "0x6A4BE80", VA = "0x186A4CE80")]
	public void EGIJBDHAFPN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x6A4D0E0", Offset = "0x6A4C0E0", VA = "0x186A4D0E0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x85EB60", Offset = "0x85DB60", VA = "0x18085EB60")]
	public MBGIGHPFJLL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public class LNHMKNJPHJE<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000049")]
	private struct MAMHAGHBBJC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public float HOGCJKOMKJI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public T JMEAFIDIDGF;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private readonly Dictionary<object, MAMHAGHBBJC> PDKIFAKOONJ;

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public virtual T ENICFDFDOMJ
	{
		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x116D470", Offset = "0x116C470", VA = "0x18116D470", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x116BE80", Offset = "0x116AE80", VA = "0x18116BE80", Slot = "5")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public object? DAHCIMPPGGJ
	{
		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x851920", Offset = "0x850920", VA = "0x180851920")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x855810", Offset = "0x854810", VA = "0x180855810")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public bool PJKLLPHHPED
	{
		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x430AC80", Offset = "0x4309C80", VA = "0x18430AC80")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x43088E0", Offset = "0x43078E0", VA = "0x1843088E0")]
	public bool CPIPAMHCHDK(T JJCEIJMGOAB, object DJIBMMAIGPE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x430A7F0", Offset = "0x43097F0", VA = "0x18430A7F0")]
	public bool FDNJFPDHLCC(object DJIBMMAIGPE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x3D8F170", Offset = "0x3D8E170", VA = "0x183D8F170")]
	public void PKAGCAPLLKG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x430A9B0", Offset = "0x43099B0", VA = "0x18430A9B0")]
	public bool HNEILIJEPGH(object DJIBMMAIGPE, [Out] T JJCEIJMGOAB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x430A100", Offset = "0x4309100", VA = "0x18430A100")]
	[EIHFMHIFCDM("T can be T?, `default!` shouldn't be necessary in C# 9")]
	private bool ECEIHMNAJDA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x430ACE0", Offset = "0x4309CE0", VA = "0x18430ACE0")]
	public LNHMKNJPHJE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public sealed class HFLLPBEPMHN<T> where T : class
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private List<WeakReference<T>>? GKBCMBINOEA;

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public bool IDBOCGMNJDA
	{
		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x3DCB500", Offset = "0x3DCA500", VA = "0x183DCB500")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public int DHMBIHOHONP
	{
		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x3DCB8A0", Offset = "0x3DCA8A0", VA = "0x183DCB8A0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x3DCB630", Offset = "0x3DCA630", VA = "0x183DCB630")]
	public void GKAGDNHKNII(T DJIBMMAIGPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x3DCB370", Offset = "0x3DCA370", VA = "0x183DCB370")]
	public void FFDBNDOHLIO(T DJIBMMAIGPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x3DCB330", Offset = "0x3DCA330", VA = "0x183DCB330")]
	public void EGIJBDHAFPN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x3DCBA40", Offset = "0x3DCAA40", VA = "0x183DCBA40", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x85EB60", Offset = "0x85DB60", VA = "0x18085EB60")]
	public HFLLPBEPMHN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
internal static class HDCHGPGBHNL
{
	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x2BC1BF0", Offset = "0x2BC0BF0", VA = "0x182BC1BF0")]
	public static void GNBFOHFDCGD<T>(this List<T> IEKJOJONGFC, int HCALFJOJKJO) where T : notnull
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public interface OLPDJCMCKLE
{
	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event DFELLKFGNIL AOGBJAPDPAB;
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public class APGNEMKOEFL : OLPDJCMCKLE, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200004E")]
	public readonly struct PHHLMCPBCMJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		public readonly float BHMAKOOBFHF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		public readonly float AOJAOMOLLEG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		internal readonly bool KJINILEJGLO;

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public float ODOBBFBPIEC
		{
			[Cpp2IlInjected.Token(Token = "0x6000135")]
			[Cpp2IlInjected.Address(RVA = "0x6A4D6A0", Offset = "0x6A4C6A0", VA = "0x186A4D6A0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x6A4D820", Offset = "0x6A4C820", VA = "0x186A4D820")]
		public PHHLMCPBCMJ(float KKONFBKDDLI, float NBLBDKMENFD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x6A4D6B0", Offset = "0x6A4C6B0", VA = "0x186A4D6B0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004F")]
	[CompilerGenerated]
	private sealed class DFGEFIHMFBL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		public APGNEMKOEFL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		public int newProgressableIndex;

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x85EB60", Offset = "0x85DB60", VA = "0x18085EB60")]
		public DFGEFIHMFBL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x6A4B1E0", Offset = "0x6A4A1E0", VA = "0x186A4B1E0")]
		internal void ANILHCMKJLK(float innerProgress)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	private readonly int BPIECAEAGAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private int EJEHKJENEDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private readonly OLPDJCMCKLE[] OADEMPOFPFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private readonly DFELLKFGNIL[] LCGMLIBOFMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private readonly PHHLMCPBCMJ[] BEFMHPALOAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private PHHLMCPBCMJ DCBFFEIPJDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private readonly FBMPPIILJHC PLMGPCAGCJD;

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event DFELLKFGNIL AOGBJAPDPAB
	{
		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x6A4A7F0", Offset = "0x6A497F0", VA = "0x186A4A7F0", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x6A4A9C0", Offset = "0x6A499C0", VA = "0x186A4A9C0", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x6A4AF90", Offset = "0x6A49F90", VA = "0x186A4AF90")]
	public APGNEMKOEFL(int BPIECAEAGAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x6A4AF00", Offset = "0x6A49F00", VA = "0x186A4AF00")]
	public FBMPPIILJHC LJCPPEOJAHO(PHHLMCPBCMJ EKCCFIDJBEH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x6A4AA80", Offset = "0x6A49A80", VA = "0x186A4AA80")]
	public void FJJALDLDHPI(OLPDJCMCKLE PALBKPBGLFL, [Optional] PHHLMCPBCMJ MEKNOAFBMMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x6A4A8B0", Offset = "0x6A498B0", VA = "0x186A4A8B0", Slot = "6")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public delegate void DFELLKFGNIL(float FPGNFNMDNAF);
[Cpp2IlInjected.Token(Token = "0x2000051")]
public static class KLGIOHFDPCN
{
	[Cpp2IlInjected.Token(Token = "0x2000052")]
	private class GDIHKCFAFBO : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		private readonly OLPDJCMCKLE ODCDHGEAADM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		private readonly DFELLKFGNIL IPCEAEAAIHH;

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x6A4C1D0", Offset = "0x6A4B1D0", VA = "0x186A4C1D0")]
		public GDIHKCFAFBO(OLPDJCMCKLE ODCDHGEAADM, DFELLKFGNIL IPCEAEAAIHH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x6A4C180", Offset = "0x6A4B180", VA = "0x186A4C180", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x6A4CC40", Offset = "0x6A4BC40", VA = "0x186A4CC40")]
	internal static bool AHFJEFOPLKE(float MHGINKKGGNL, float JCHFDOINNOA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x6A3A220", Offset = "0x6A39220", VA = "0x186A3A220")]
	internal static float BFLBDANNIPF(float MHGINKKGGNL)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x6A4CCB0", Offset = "0x6A4BCB0", VA = "0x186A4CCB0")]
	public static IDisposable IDIKHHHLLEG(this OLPDJCMCKLE ODCDHGEAADM, DFELLKFGNIL IPCEAEAAIHH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public class FBMPPIILJHC : OLPDJCMCKLE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	private float FPGNFNMDNAF;

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public float FIFILJOEKFG
	{
		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x6A4BF60", Offset = "0x6A4AF60", VA = "0x186A4BF60")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public event DFELLKFGNIL? AOGBJAPDPAB
	{
		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x6A4BE20", Offset = "0x6A4AE20", VA = "0x186A4BE20", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x6A4BEC0", Offset = "0x6A4AEC0", VA = "0x186A4BEC0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x85EB60", Offset = "0x85DB60", VA = "0x18085EB60")]
	public FBMPPIILJHC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
public interface ANEDNMIFAAN<T> where T : class, new()
{
	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(Slot = "0")]
	MHHMNNGNHFN<T> AAMNLOAKCMH([Out] T JJCEIJMGOAB);

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void PKAGCAPLLKG();
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public class HCFECKIPACO<T> : ANEDNMIFAAN<T> where T : class, new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	private readonly ConcurrentStack<T> MDILCGJHBHE;

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x3DC2850", Offset = "0x3DC1850", VA = "0x183DC2850", Slot = "4")]
	public MHHMNNGNHFN<T> AAMNLOAKCMH([Out] T JJCEIJMGOAB)
	{
		return default(MHHMNNGNHFN<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x3DC29A0", Offset = "0x3DC19A0", VA = "0x183DC29A0")]
	public void ONMBONLCIME(T BGEJNNNFDMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x3DC2A20", Offset = "0x3DC1A20", VA = "0x183DC2A20", Slot = "5")]
	public void PKAGCAPLLKG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x853950", Offset = "0x852950", VA = "0x180853950", Slot = "6")]
	protected virtual void MJCHFHIOAAH(T ECHKOBCEDMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x3DC28F0", Offset = "0x3DC18F0", VA = "0x183DC28F0")]
	private T MKHPGHPCCLG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x3DC2A70", Offset = "0x3DC1A70", VA = "0x183DC2A70")]
	public HCFECKIPACO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
public readonly struct MHHMNNGNHFN<T> : IDisposable where T : class, new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	private readonly T BGEJNNNFDMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	private readonly HCFECKIPACO<T> ELCGDHICFJE;

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0xB852B0", Offset = "0xB842B0", VA = "0x180B852B0")]
	internal MHHMNNGNHFN(T JJCEIJMGOAB, HCFECKIPACO<T> ELCGDHICFJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x44E89E0", Offset = "0x44E79E0", VA = "0x1844E89E0", Slot = "4")]
	void IDisposable.Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
public class AIPEJHPBKEO : HCFECKIPACO<StringBuilder>
{
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	public static readonly AIPEJHPBKEO PNNELGGLBHA;

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x6A4A670", Offset = "0x6A49670", VA = "0x186A4A670")]
	public static MHHMNNGNHFN<StringBuilder> MKHPGHPCCLG([Out] StringBuilder JJCEIJMGOAB)
	{
		return default(MHHMNNGNHFN<StringBuilder>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x6A4A650", Offset = "0x6A49650", VA = "0x186A4A650", Slot = "6")]
	protected override void MJCHFHIOAAH(StringBuilder ECHKOBCEDMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x6A4A7B0", Offset = "0x6A497B0", VA = "0x186A4A7B0")]
	public AIPEJHPBKEO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
public class OOAHMGOCMDJ : InvalidOperationException
{
	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x64C0020", Offset = "0x64BF020", VA = "0x1864C0020")]
	public OOAHMGOCMDJ(string KKHEHGHPOAA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
[DefaultMember("Item")]
public class IANGDEAPHCM<TKey, TValue> : JNPPICMGEKH<TKey, TValue>, IDictionary<TKey, TValue>, ICollection<KeyValuePair<TKey, TValue>>, IEnumerable<KeyValuePair<TKey, TValue>>, IEnumerable, HNGFKNAMBEG where TKey : notnull where TValue : notnull
{
	[Cpp2IlInjected.Token(Token = "0x200005A")]
	[CompilerGenerated]
	private sealed class FMAPFDLJBHH : IEnumerator<KeyValuePair<TKey, TValue>>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		private KeyValuePair<TKey, TValue> <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public IANGDEAPHCM<TKey, TValue> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		private IEnumerator<KeyValuePair<TKey, TValue>> <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		KeyValuePair<TKey, TValue> IEnumerator<KeyValuePair<TKey, TValue>>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000174")]
			[Cpp2IlInjected.Address(RVA = "0x116D470", Offset = "0x116C470", VA = "0x18116D470", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return default(KeyValuePair<TKey, TValue>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000176")]
			[Cpp2IlInjected.Address(RVA = "0x3C56910", Offset = "0x3C55910", VA = "0x183C56910", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x857C10", Offset = "0x856C10", VA = "0x180857C10")]
		[DebuggerHidden]
		public FMAPFDLJBHH(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x3AA8700", Offset = "0x3AA7700", VA = "0x183AA8700", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x3C55FA0", Offset = "0x3C54FA0", VA = "0x183C55FA0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x3C55BA0", Offset = "0x3C54BA0", VA = "0x183C55BA0")]
		private void IKLMFKCBKPE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x3C567D0", Offset = "0x3C557D0", VA = "0x183C567D0")]
		private void POOBBHLNDCF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x3C56820", Offset = "0x3C55820", VA = "0x183C56820", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	private readonly JNPPICMGEKH<TKey, TValue> OHPNFOMIHAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	private readonly IDictionary<TKey, TValue> EFMGOHKDMGB;

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public int DHMBIHOHONP
	{
		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x3EB4B80", Offset = "0x3EB3B80", VA = "0x183EB4B80", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public bool KEMHBPIIPLB
	{
		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x89A950", Offset = "0x899950", VA = "0x18089A950", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public TValue OMCGAJCFHLP
	{
		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x3EB4C50", Offset = "0x3EB3C50", VA = "0x183EB4C50", Slot = "4")]
		get
		{
			return (TValue)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x3EB4F00", Offset = "0x3EB3F00", VA = "0x183EB4F00", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public ICollection<TKey> BOBINNLNLCJ
	{
		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x3EB4CE0", Offset = "0x3EB3CE0", VA = "0x183EB4CE0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public ICollection<TValue> FBFLONJFPNG
	{
		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x3EB4DF0", Offset = "0x3EB3DF0", VA = "0x183EB4DF0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x3EB4920", Offset = "0x3EB3920", VA = "0x183EB4920")]
	public IANGDEAPHCM(JNPPICMGEKH<TKey, TValue> OHPNFOMIHAM, [Optional] IDictionary<TKey, TValue>? EFMGOHKDMGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x3EB2210", Offset = "0x3EB1210", VA = "0x183EB2210", Slot = "15")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x3EB3740", Offset = "0x3EB2740", VA = "0x183EB3740")]
	public void KPOOOGFDMJE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x3EB1EF0", Offset = "0x3EB0EF0", VA = "0x183EB1EF0", Slot = "9")]
	public void Add(TKey GMFCIHEFPPO, TValue JJCEIJMGOAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x3EB3A50", Offset = "0x3EB2A50", VA = "0x183EB3A50")]
	public void PLIBHNNDJEI(TKey GMFCIHEFPPO, TValue JJCEIJMGOAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x3EB2BF0", Offset = "0x3EB1BF0", VA = "0x183EB2BF0")]
	public void FNICKCOCMAN(TKey GMFCIHEFPPO, TValue JJCEIJMGOAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x3EB2FB0", Offset = "0x3EB1FB0", VA = "0x183EB2FB0")]
	public void IFBAGKPBFLA(TKey GMFCIHEFPPO, TValue JJCEIJMGOAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x3EB3530", Offset = "0x3EB2530", VA = "0x183EB3530")]
	public void KGLPONAEOEK(TKey GMFCIHEFPPO, TValue JJCEIJMGOAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x3EB3F60", Offset = "0x3EB2F60", VA = "0x183EB3F60", Slot = "14")]
	void ICollection<KeyValuePair<TKey, TValue>>.Add(KeyValuePair<TKey, TValue> LLGHCONMHCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x3EB3FB0", Offset = "0x3EB2FB0", VA = "0x183EB3FB0", Slot = "16")]
	bool ICollection<KeyValuePair<TKey, TValue>>.Contains(KeyValuePair<TKey, TValue> LLGHCONMHCJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x3EB44B0", Offset = "0x3EB34B0", VA = "0x183EB44B0", Slot = "18")]
	bool ICollection<KeyValuePair<TKey, TValue>>.Remove(KeyValuePair<TKey, TValue> LLGHCONMHCJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x3EB2350", Offset = "0x3EB1350", VA = "0x183EB2350", Slot = "8")]
	public bool ContainsKey(TKey GMFCIHEFPPO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x3EB3620", Offset = "0x3EB2620", VA = "0x183EB3620")]
	public bool KNNNBPHPCHJ(TKey GMFCIHEFPPO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x3EB2B30", Offset = "0x3EB1B30", VA = "0x183EB2B30")]
	public bool EDDJNNELODH(TKey GMFCIHEFPPO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x3EB3CB0", Offset = "0x3EB2CB0", VA = "0x183EB3CB0", Slot = "10")]
	public bool Remove(TKey GMFCIHEFPPO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x3EB4780", Offset = "0x3EB3780", VA = "0x183EB4780", Slot = "11")]
	public bool TryGetValue(TKey GMFCIHEFPPO, [Out] TValue JJCEIJMGOAB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x3EB2410", Offset = "0x3EB1410", VA = "0x183EB2410", Slot = "17")]
	public void CopyTo(KeyValuePair<TKey, TValue>[] IKONNGGNFPH, int MNPIBEICCLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x3EB4670", Offset = "0x3EB3670", VA = "0x183EB4670", Slot = "20")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x3EB2F00", Offset = "0x3EB1F00", VA = "0x183EB2F00", Slot = "19")]
	[IteratorStateMachine(typeof(IANGDEAPHCM<, >.FMAPFDLJBHH))]
	public IEnumerator<KeyValuePair<TKey, TValue>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x3EB2120", Offset = "0x3EB1120", VA = "0x183EB2120", Slot = "21")]
	public bool CFIJOALJKNI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x3EB3790", Offset = "0x3EB2790", VA = "0x183EB3790")]
	private TValue OBEBHKNGIGI(TKey GMFCIHEFPPO)
	{
		return (TValue)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public interface HNGFKNAMBEG
{
	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool CFIJOALJKNI();
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public interface JNPPICMGEKH<TKey, TVal> : IDictionary<TKey, TVal>, ICollection<KeyValuePair<TKey, TVal>>, IEnumerable<KeyValuePair<TKey, TVal>>, IEnumerable, HNGFKNAMBEG
{
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
[DefaultMember("Item")]
public sealed class KIDOIMPBPFI<TKey, TVal> : JNPPICMGEKH<TKey, TVal>, IDictionary<TKey, TVal>, ICollection<KeyValuePair<TKey, TVal>>, IEnumerable<KeyValuePair<TKey, TVal>>, IEnumerable, HNGFKNAMBEG where TKey : notnull where TVal : notnull
{
	[Cpp2IlInjected.Token(Token = "0x200005E")]
	public delegate int GCJEKKLLOED(TKey GMFCIHEFPPO, TVal JJCEIJMGOAB);

	[Cpp2IlInjected.Token(Token = "0x200005F")]
	public delegate void NDGJCKPGBFK(TKey GMFCIHEFPPO, TVal JJCEIJMGOAB, BMBBIMDJMPC JMFILHLKOGK);

	[Cpp2IlInjected.Token(Token = "0x2000060")]
	private class GLNKOKAFEGO
	{
		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		public TKey NAKCNJCFEHA
		{
			[Cpp2IlInjected.Token(Token = "0x60001A2")]
			[Cpp2IlInjected.Address(RVA = "0x9A27D0", Offset = "0x9A17D0", VA = "0x1809A27D0")]
			[CompilerGenerated]
			get
			{
				return (TKey)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public TVal JMEAFIDIDGF
		{
			[Cpp2IlInjected.Token(Token = "0x60001A3")]
			[Cpp2IlInjected.Address(RVA = "0x9ABFE0", Offset = "0x9AAFE0", VA = "0x1809ABFE0")]
			[CompilerGenerated]
			get
			{
				return (TVal)null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001A4")]
			[Cpp2IlInjected.Address(RVA = "0x9ABFA0", Offset = "0x9AAFA0", VA = "0x1809ABFA0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		public int ODOBBFBPIEC
		{
			[Cpp2IlInjected.Token(Token = "0x60001A5")]
			[Cpp2IlInjected.Address(RVA = "0x891670", Offset = "0x890670", VA = "0x180891670")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60001A6")]
			[Cpp2IlInjected.Address(RVA = "0x890C60", Offset = "0x88FC60", VA = "0x180890C60")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public DateTimeOffset BKDECFLEBBB
		{
			[Cpp2IlInjected.Token(Token = "0x60001A7")]
			[Cpp2IlInjected.Address(RVA = "0xD382C0", Offset = "0xD372C0", VA = "0x180D382C0")]
			[CompilerGenerated]
			get
			{
				return default(DateTimeOffset);
			}
			[Cpp2IlInjected.Token(Token = "0x60001A8")]
			[Cpp2IlInjected.Address(RVA = "0x15F39C0", Offset = "0x15F29C0", VA = "0x1815F39C0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x3D8EFD0", Offset = "0x3D8DFD0", VA = "0x183D8EFD0")]
		public GLNKOKAFEGO(TKey GMFCIHEFPPO, TVal AAINAOCHJJJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000062")]
	[CompilerGenerated]
	private sealed class LHBIGHOMICI : IEnumerator<KeyValuePair<TKey, TVal>>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		private KeyValuePair<TKey, TVal> <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		public KIDOIMPBPFI<TKey, TVal> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		private LinkedList<GLNKOKAFEGO>.Enumerator <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		KeyValuePair<TKey, TVal> IEnumerator<KeyValuePair<TKey, TVal>>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001B2")]
			[Cpp2IlInjected.Address(RVA = "0x116D470", Offset = "0x116C470", VA = "0x18116D470", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return default(KeyValuePair<TKey, TVal>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001B4")]
			[Cpp2IlInjected.Address(RVA = "0x3AAB840", Offset = "0x3AAA840", VA = "0x183AAB840", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x857C10", Offset = "0x856C10", VA = "0x180857C10")]
		[DebuggerHidden]
		public LHBIGHOMICI(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x3AA34E0", Offset = "0x3AA24E0", VA = "0x183AA34E0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x42F0CF0", Offset = "0x42EFCF0", VA = "0x1842F0CF0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x42F06E0", Offset = "0x42EF6E0", VA = "0x1842F06E0")]
		private void IKLMFKCBKPE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x42F2CC0", Offset = "0x42F1CC0", VA = "0x1842F2CC0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000087")]
	public const int HADBHNIBEBA = -1;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private readonly Dictionary<TKey, LinkedListNode<GLNKOKAFEGO>> NJAKPNNGKJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private readonly LinkedList<GLNKOKAFEGO> FPBAAODCFDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private readonly GCJEKKLLOED? OBMPBELMCMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	private readonly TimeSpan OHGHMDPJBMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private readonly NDGJCKPGBFK? GIENKCLOHGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private readonly BOEJJLJIHOD EMHNBGGEJCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private bool ILILAJLGFLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private readonly List<TKey> LBLOAGJHPEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private readonly List<TVal> LGHLCPDJFAI;

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public int MANBHPILCPK
	{
		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x861470", Offset = "0x860470", VA = "0x180861470")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	internal int IGFDJNMKOKN
	{
		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0xBFF640", Offset = "0xBFE640", VA = "0x180BFF640")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0xBFEC30", Offset = "0xBFDC30", VA = "0x180BFEC30")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public int DHMBIHOHONP
	{
		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x4222050", Offset = "0x4221050", VA = "0x184222050", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	internal int BJBAMGFHEMM
	{
		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x3D8F170", Offset = "0x3D8E170", VA = "0x183D8F170")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public ICollection<TVal> FBFLONJFPNG
	{
		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x4222130", Offset = "0x4221130", VA = "0x184222130", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	ICollection<TKey> IDictionary<TKey, TVal>.BCHLPPDHLMC
	{
		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x4221080", Offset = "0x4220080", VA = "0x184221080", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public bool KEMHBPIIPLB
	{
		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x89A950", Offset = "0x899950", VA = "0x18089A950", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public TVal OMCGAJCFHLP
	{
		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x42220E0", Offset = "0x42210E0", VA = "0x1842220E0", Slot = "4")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x4222170", Offset = "0x4221170", VA = "0x184222170", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x421F3C0", Offset = "0x421E3C0", VA = "0x18421F3C0")]
	private bool GPHJNCMMAMK(int BPIECAEAGAJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(RVA = "0x421E030", Offset = "0x421D030", VA = "0x18421E030")]
	private void FFEMEDFFBGN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(RVA = "0x4221A30", Offset = "0x4220A30", VA = "0x184221A30")]
	public KIDOIMPBPFI(int BPIECAEAGAJ, [Optional] GCJEKKLLOED? OBMPBELMCMA, [Optional] IEqualityComparer<TKey>? KCABKELDGLM, [Optional] NDGJCKPGBFK? GIENKCLOHGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(RVA = "0x42219C0", Offset = "0x42209C0", VA = "0x1842219C0")]
	public KIDOIMPBPFI(TimeSpan OHGHMDPJBMO, [Optional] IEqualityComparer<TKey>? KCABKELDGLM, [Optional] NDGJCKPGBFK? GIENKCLOHGK, [Optional] BOEJJLJIHOD? EMHNBGGEJCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000184")]
	[Cpp2IlInjected.Address(RVA = "0x4221950", Offset = "0x4220950", VA = "0x184221950")]
	public KIDOIMPBPFI(int BPIECAEAGAJ, TimeSpan OHGHMDPJBMO, [Optional] IEqualityComparer<TKey>? KCABKELDGLM, [Optional] NDGJCKPGBFK? GIENKCLOHGK, [Optional] BOEJJLJIHOD? EMHNBGGEJCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000185")]
	[Cpp2IlInjected.Address(RVA = "0x42214F0", Offset = "0x42204F0", VA = "0x1842214F0")]
	public KIDOIMPBPFI(int BPIECAEAGAJ, GCJEKKLLOED? OBMPBELMCMA, TimeSpan OHGHMDPJBMO, [Optional] IEqualityComparer<TKey>? KCABKELDGLM, [Optional] NDGJCKPGBFK? GIENKCLOHGK, [Optional] BOEJJLJIHOD? EMHNBGGEJCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000186")]
	[Cpp2IlInjected.Address(RVA = "0x421CAE0", Offset = "0x421BAE0", VA = "0x18421CAE0", Slot = "21")]
	public bool CFIJOALJKNI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(RVA = "0x421DED0", Offset = "0x421CED0", VA = "0x18421DED0", Slot = "22")]
	public bool FBDJECCLADF(int GHACOABIHDA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000188")]
	[Cpp2IlInjected.Address(RVA = "0x421E4F0", Offset = "0x421D4F0", VA = "0x18421E4F0")]
	private bool FOHJNJBLPMC(int GHACOABIHDA, BMBBIMDJMPC JMFILHLKOGK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600018B")]
	[Cpp2IlInjected.Address(RVA = "0x421F4C0", Offset = "0x421E4C0", VA = "0x18421F4C0")]
	public void HACKMLKKHNE(TKey GMFCIHEFPPO, TVal JJCEIJMGOAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018C")]
	[Cpp2IlInjected.Address(RVA = "0x421C8E0", Offset = "0x421B8E0", VA = "0x18421C8E0", Slot = "14")]
	public void Add(KeyValuePair<TKey, TVal> LLGHCONMHCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018D")]
	[Cpp2IlInjected.Address(RVA = "0x421C930", Offset = "0x421B930", VA = "0x18421C930", Slot = "9")]
	public void Add(TKey GMFCIHEFPPO, TVal JJCEIJMGOAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018E")]
	[Cpp2IlInjected.Address(RVA = "0x421D7A0", Offset = "0x421C7A0", VA = "0x18421D7A0", Slot = "8")]
	public bool ContainsKey(TKey GMFCIHEFPPO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(RVA = "0x4220D80", Offset = "0x421FD80", VA = "0x184220D80", Slot = "16")]
	bool ICollection<KeyValuePair<TKey, TVal>>.Contains(KeyValuePair<TKey, TVal> LLGHCONMHCJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000190")]
	[Cpp2IlInjected.Address(RVA = "0x4220B80", Offset = "0x421FB80", VA = "0x184220B80", Slot = "10")]
	public bool Remove(TKey GMFCIHEFPPO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(RVA = "0x4220F40", Offset = "0x421FF40", VA = "0x184220F40", Slot = "18")]
	bool ICollection<KeyValuePair<TKey, TVal>>.Remove(KeyValuePair<TKey, TVal> LLGHCONMHCJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0x42203E0", Offset = "0x421F3E0", VA = "0x1842203E0")]
	private bool NKLFDDHDIPC(TKey GMFCIHEFPPO, [Out] TVal JJCEIJMGOAB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(RVA = "0x42202E0", Offset = "0x421F2E0", VA = "0x1842202E0")]
	private TVal MKHPGHPCCLG(TKey GNKBMNIDCFJ)
	{
		return (TVal)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000194")]
	[Cpp2IlInjected.Address(RVA = "0x4221300", Offset = "0x4220300", VA = "0x184221300", Slot = "11")]
	public bool TryGetValue(TKey GNKBMNIDCFJ, [Out] TVal JJCEIJMGOAB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000195")]
	[Cpp2IlInjected.Address(RVA = "0x421D620", Offset = "0x421C620", VA = "0x18421D620", Slot = "15")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(RVA = "0x421DB70", Offset = "0x421CB70", VA = "0x18421DB70", Slot = "17")]
	public void CopyTo(KeyValuePair<TKey, TVal>[] IKONNGGNFPH, int MNPIBEICCLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x4220900", Offset = "0x421F900", VA = "0x184220900")]
	private void OCPJNGBFOJD(TKey GMFCIHEFPPO, TVal AAINAOCHJJJ, BMBBIMDJMPC JMFILHLKOGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(RVA = "0x421F0C0", Offset = "0x421E0C0", VA = "0x18421F0C0")]
	private bool GBKICLPIOKL(GLNKOKAFEGO KGGDFCFBBAP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0x421FC80", Offset = "0x421EC80", VA = "0x18421FC80")]
	private void KGGIMEPAKDF(LinkedListNode<GLNKOKAFEGO> ADGNMPNPIEM, TVal ECCBDOCBJDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(RVA = "0x421CFA0", Offset = "0x421BFA0", VA = "0x18421CFA0")]
	private void CPIPAMHCHDK(TKey GMFCIHEFPPO, TVal JJCEIJMGOAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(RVA = "0x421CB80", Offset = "0x421BB80", VA = "0x18421CB80")]
	private void CFKMEGJAKII(GLNKOKAFEGO KGGDFCFBBAP, TVal ECCBDOCBJDI, int NPCJGJBLMEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(RVA = "0x421F410", Offset = "0x421E410", VA = "0x18421F410", Slot = "19")]
	[IteratorStateMachine(typeof(KIDOIMPBPFI<, >.LHBIGHOMICI))]
	public IEnumerator<KeyValuePair<TKey, TVal>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0x42210C0", Offset = "0x42200C0", VA = "0x1842210C0", Slot = "20")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
public enum BMBBIMDJMPC : byte
{
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	Evicted,
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	RemovedViaRemove,
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	RemovedViaClear,
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	Overwritten
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
public class PCBHLGNMFFM<TKey> : Exception where TKey : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	public readonly TKey JGDDOKMMALG;

	[Cpp2IlInjected.Token(Token = "0x60001B5")]
	[Cpp2IlInjected.Address(RVA = "0x4793500", Offset = "0x4792500", VA = "0x184793500")]
	public PCBHLGNMFFM(TKey FJLMBHGKPPN, Exception NFGOFCBGHNA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000065")]
public class MDHMDCENIJD : ArgumentException
{
	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(RVA = "0x5D85740", Offset = "0x5D84740", VA = "0x185D85740")]
	public MDHMDCENIJD(string KKHEHGHPOAA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
public class ANCOHNGNEPM<TId, TResource> : IEnumerable<(TId, Task<TResource>, int)>, IEnumerable where TId : notnull where TResource : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000067")]
	[CompilerGenerated]
	private sealed class BLKFKKOOGKC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		public Func<TId, CancellationToken, Task<TResource>> factory;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		public ANCOHNGNEPM<TId, TResource> <>4__this;

		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x85EB60", Offset = "0x85DB60", VA = "0x18085EB60")]
		public BLKFKKOOGKC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x4E9CC00", Offset = "0x4E9BC00", VA = "0x184E9CC00")]
		internal Task<TResource> ACJHCGJAHLE(TId _id)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000068")]
	[CompilerGenerated]
	private struct DMAAODAIIOM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		public Task<TResource> task;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		public ANCOHNGNEPM<TId, TResource> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		private TaskAwaiter<TResource> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x5877E10", Offset = "0x5876E10", VA = "0x185877E10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x58786B0", Offset = "0x58776B0", VA = "0x1858786B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000069")]
	[CompilerGenerated]
	private struct BECFNLOKFFD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		public Task<TResource> task;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		public Dictionary<Task<TResource>, CancellationTokenSource> cancellationTokenSources;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		public CancellationTokenSource cts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		private TaskAwaiter<TResource> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x4E78F80", Offset = "0x4E77F80", VA = "0x184E78F80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x4E795C0", Offset = "0x4E785C0", VA = "0x184E795C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	private readonly FABKIIPBCPH<TId, Task<TResource>> LECDBOBDMMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	private readonly Dictionary<Task<TResource>, CancellationTokenSource> PLOGHLIJMBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	private readonly Func<TId, CancellationToken, Task<TResource>>? GDLKAMJHGLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	private readonly Action<TResource>? KCGNMJDIHHM;

	[Cpp2IlInjected.Token(Token = "0x60001B7")]
	[Cpp2IlInjected.Address(RVA = "0x3E3B690", Offset = "0x3E3A690", VA = "0x183E3B690")]
	public ANCOHNGNEPM(int DJEFMBABFDG = 0, [Optional] IEqualityComparer<TId>? NMMBPDOMMCG, [Optional] Func<TId, CancellationToken, Task<TResource>>? AJDAJFEOMGJ, [Optional] Action<TResource>? EHODHMIFOLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(RVA = "0x3E39FB0", Offset = "0x3E38FB0", VA = "0x183E39FB0")]
	public OKJGCOPDBJF<Task<TResource>> EKDMJCIFMJJ(TId KHLDDJPHOBA, [Optional] Func<TId, CancellationToken, Task<TResource>>? AJDAJFEOMGJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001B9")]
	[Cpp2IlInjected.Address(RVA = "0x3E3AAC0", Offset = "0x3E39AC0", VA = "0x183E3AAC0")]
	private void HKMPBCKENOH(Task<TResource> FGPHJGHMKNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BA")]
	[Cpp2IlInjected.Address(RVA = "0x3E3ADE0", Offset = "0x3E39DE0", VA = "0x183E3ADE0")]
	[AsyncStateMachine(typeof(ANCOHNGNEPM<, >.DMAAODAIIOM))]
	private Task JNMOIJPBGMC(Task<TResource> FGPHJGHMKNM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001BB")]
	[Cpp2IlInjected.Address(RVA = "0x3E3A700", Offset = "0x3E39700", VA = "0x183E3A700")]
	public void HIFFKHAKJHE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BC")]
	[Cpp2IlInjected.Address(RVA = "0x3E39E30", Offset = "0x3E38E30", VA = "0x183E39E30")]
	public FABKIIPBCPH<TId, Task<TResource>>.LNHFJPBKDJL EAJKDCOBAGF()
	{
		return default(FABKIIPBCPH<TId, Task<TResource>>.LNHFJPBKDJL);
	}

	[Cpp2IlInjected.Token(Token = "0x60001BD")]
	[Cpp2IlInjected.Address(RVA = "0x3E3B4A0", Offset = "0x3E3A4A0", VA = "0x183E3B4A0", Slot = "4")]
	private IEnumerator<(TId, Task<TResource>, int)> System.Collections.Generic.IEnumerable<(TIdId,System.Threading.Tasks.Task<TResource>LoadResourceTask,System.Int32RefCount)>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001BE")]
	[Cpp2IlInjected.Address(RVA = "0x3E3B4A0", Offset = "0x3E3A4A0", VA = "0x183E3B4A0", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001BF")]
	[Cpp2IlInjected.Address(RVA = "0x3E3B110", Offset = "0x3E3A110", VA = "0x183E3B110")]
	[AsyncStateMachine(typeof(ANCOHNGNEPM<, >.BECFNLOKFFD))]
	[CompilerGenerated]
	internal static Task PCJCGDNHKOG(Task<TResource> FGPHJGHMKNM, CancellationTokenSource ABKMPDMCEDC, Dictionary<Task<TResource>, CancellationTokenSource> FHPMHDAKPOB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006A")]
public class FABKIIPBCPH<TKey, TValue> : IEnumerable<(TKey, TValue, int)>, IEnumerable where TKey : notnull where TValue : notnull
{
	[Cpp2IlInjected.Token(Token = "0x200006B")]
	private sealed class ECOEDJLALKJ : IEquatable<ECOEDJLALKJ>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		public readonly TValue JMEAFIDIDGF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		public int HOOEHJABCBP;

		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0xA2E5C0", Offset = "0xA2D5C0", VA = "0x180A2E5C0")]
		public ECOEDJLALKJ(TValue JJCEIJMGOAB, int OLGLGOMOALJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x38880C0", Offset = "0x38870C0", VA = "0x1838880C0", Slot = "4")]
		public bool Equals(ECOEDJLALKJ? ACBLPNJDJBF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x3888150", Offset = "0x3887150", VA = "0x183888150", Slot = "0")]
		public override bool Equals(object? NOPFNIKINJA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0x3888280", Offset = "0x3887280", VA = "0x183888280", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006C")]
	public struct LNHFJPBKDJL : IEnumerator<(TKey, TValue, int)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		private Dictionary<TKey, ECOEDJLALKJ>.Enumerator CONNOEDJHFM;

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001D5")]
			[Cpp2IlInjected.Address(RVA = "0x4308020", Offset = "0x4307020", VA = "0x184308020", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		public (TKey Key, TValue Value, int RefCount) NIGOAHBKKGN
		{
			[Cpp2IlInjected.Token(Token = "0x60001D6")]
			[Cpp2IlInjected.Address(RVA = "0x4308480", Offset = "0x4307480", VA = "0x184308480", Slot = "4")]
			get
			{
				return default((TKey, TValue, int));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0x43082E0", Offset = "0x43072E0", VA = "0x1843082E0")]
		public LNHFJPBKDJL(FABKIIPBCPH<TKey, TValue> PDKIFAKOONJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0x4307C80", Offset = "0x4306C80", VA = "0x184307C80", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0x4307D00", Offset = "0x4306D00", VA = "0x184307D00", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0x4307F80", Offset = "0x4306F80", VA = "0x184307F80", Slot = "8")]
		public void Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006D")]
	[CompilerGenerated]
	private sealed class CPAAHIENCNF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		public FABKIIPBCPH<TKey, TValue> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		public TKey key;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		public ECOEDJLALKJ refCountedValue;

		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0x85EB60", Offset = "0x85DB60", VA = "0x18085EB60")]
		public CPAAHIENCNF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0x5543C90", Offset = "0x5542C90", VA = "0x185543C90")]
		internal void ACJHCGJAHLE()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	private readonly Dictionary<TKey, ECOEDJLALKJ> DKBFJLMDACN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	private readonly Func<TKey, TValue>? JFCMKKFEIHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	private readonly Action<TValue>? BLKLBNOJLNE;

	[Cpp2IlInjected.Token(Token = "0x60001C6")]
	[Cpp2IlInjected.Address(RVA = "0x3C15470", Offset = "0x3C14470", VA = "0x183C15470")]
	public FABKIIPBCPH(int DJEFMBABFDG = 0, [Optional] IEqualityComparer<TKey>? KCABKELDGLM, [Optional] Func<TKey, TValue>? NPONHFJNHIN, [Optional] Action<TValue>? NLBMAIAHBJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C7")]
	[Cpp2IlInjected.Address(RVA = "0x3C13F70", Offset = "0x3C12F70", VA = "0x183C13F70")]
	public OKJGCOPDBJF<TValue> EKDMJCIFMJJ(TKey GMFCIHEFPPO, [Optional] Func<TKey, TValue>? OAHIMGDELFN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C8")]
	[Cpp2IlInjected.Address(RVA = "0x3C14F00", Offset = "0x3C13F00", VA = "0x183C14F00")]
	private void ONMBONLCIME(TKey GMFCIHEFPPO, ECOEDJLALKJ MKLAIAHEMOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C9")]
	[Cpp2IlInjected.Address(RVA = "0x3C148C0", Offset = "0x3C138C0", VA = "0x183C148C0")]
	public void HIFFKHAKJHE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(RVA = "0x3C13C00", Offset = "0x3C12C00", VA = "0x183C13C00")]
	public LNHFJPBKDJL EAJKDCOBAGF()
	{
		return default(LNHFJPBKDJL);
	}

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x3C15320", Offset = "0x3C14320", VA = "0x183C15320", Slot = "4")]
	private IEnumerator<(TKey, TValue, int)> System.Collections.Generic.IEnumerable<(TKeyKey,TValueValue,System.Int32RefCount)>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(RVA = "0x3C15320", Offset = "0x3C14320", VA = "0x183C15320", Slot = "5")]
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
