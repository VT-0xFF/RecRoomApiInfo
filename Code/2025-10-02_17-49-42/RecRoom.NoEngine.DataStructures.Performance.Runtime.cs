using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
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
		[Cpp2IlInjected.Address(RVA = "0xAD77F0", Offset = "0xAD61F0", VA = "0x180AD77F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x86604A0", Offset = "0x865EEA0", VA = "0x1886604A0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xAD85C0", Offset = "0xAD6FC0", VA = "0x180AD85C0")]
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
		[Cpp2IlInjected.Address(RVA = "0xAD8600", Offset = "0xAD7000", VA = "0x180AD8600")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class FMBHIEALJOI
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x32D3210", Offset = "0x32D1C10", VA = "0x1832D3210")]
	public static CEAGJEFPBKJ<T> NJHGEAODMAD<T>(this T[] DKGBCFDLMOI) where T : notnull
	{
		return default(CEAGJEFPBKJ<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x3D6FFB0", Offset = "0x3D6E9B0", VA = "0x183D6FFB0")]
	public static DPBDBKAMFJF<T, JEHMKJHNDIM<T>> CCNNAEANGAH<T>(this T[] DKGBCFDLMOI) where T : notnull
	{
		return default(DPBDBKAMFJF<T, JEHMKJHNDIM<T>>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[DefaultMember("Item")]
public sealed class ECKPDCJKGBK<T> : IDisposable, GAHDIFHIOJO, IEnumerable<T>, IEnumerable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private DBIBICKBIIJ<T> OKDHLAPLDHP;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int BEFNAMGOJCC
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x4AFB030", Offset = "0x4AF9A30", VA = "0x184AFB030", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public T PCCJLFHFGOC
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x4AFAF90", Offset = "0x4AF9990", VA = "0x184AFAF90")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x4AFB060", Offset = "0x4AF9A60", VA = "0x184AFB060")]
	public static ECKPDCJKGBK<T> KDBDJPAJKDJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x4AFB1F0", Offset = "0x4AF9BF0", VA = "0x184AFB1F0")]
	internal ECKPDCJKGBK([In] DBIBICKBIIJ<T> FDMAPEJEBGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x4AFAF70", Offset = "0x4AF9970", VA = "0x184AFAF70", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x4AFB010", Offset = "0x4AF9A10", VA = "0x184AFB010")]
	public void JEMMEJHNIAD(int MHMCOJIKNCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x4AFAFC0", Offset = "0x4AF99C0", VA = "0x184AFAFC0", Slot = "8")]
	public DBIBICKBIIJ<T>.IFIFFEDNNCK GetEnumerator()
	{
		return default(DBIBICKBIIJ<T>.IFIFFEDNNCK);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x4AFB180", Offset = "0x4AF9B80", VA = "0x184AFB180", Slot = "6")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x4AFB180", Offset = "0x4AF9B80", VA = "0x184AFB180", Slot = "7")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public readonly struct PBLIJBPBDIB<T, U> : IEnumerable<T>, IEnumerable where U : JDFFJCHKFGN<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	internal readonly U DMHBCNMMMCA;

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x12D6400", Offset = "0x12D4E00", VA = "0x1812D6400")]
	internal PBLIJBPBDIB([In] U BNAAJHEIBMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x12D6120", Offset = "0x12D4B20", VA = "0x1812D6120", Slot = "6")]
	public U GetEnumerator()
	{
		return (U)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x4688B90", Offset = "0x4687590", VA = "0x184688B90", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x4688B90", Offset = "0x4687590", VA = "0x184688B90", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class MOINNGNCLME<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x3F27560", Offset = "0x3F25F60", VA = "0x183F27560")]
	public static PBLIJBPBDIB<T, U> KDBDJPAJKDJ<U>([In] U DKGBCFDLMOI) where U : JDFFJCHKFGN<T>
	{
		return default(PBLIJBPBDIB<T, U>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public static class LAINPKOHEGC
{
	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x3E6BD60", Offset = "0x3E6A760", VA = "0x183E6BD60")]
	public static int BEFNAMGOJCC<T, U>([In] this PBLIJBPBDIB<T, U> DKGBCFDLMOI) where U : JDFFJCHKFGN<T>, GAHDIFHIOJO
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public static class CEBFEKDCGHL<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x6CD7860", Offset = "0x6CD6260", VA = "0x186CD7860")]
	public static DPBDBKAMFJF<T, JEHMKJHNDIM<T>> KDBDJPAJKDJ([In] T[] DKGBCFDLMOI)
	{
		return default(DPBDBKAMFJF<T, JEHMKJHNDIM<T>>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public readonly struct DPBDBKAMFJF<T, U> : IEnumerable<T>, IEnumerable where U : IEnumerator<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	internal readonly U DMHBCNMMMCA;

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x4688EE0", Offset = "0x46878E0", VA = "0x184688EE0")]
	internal DPBDBKAMFJF([In] U BNAAJHEIBMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0xB51460", Offset = "0xB4FE60", VA = "0x180B51460", Slot = "6")]
	public U GetEnumerator()
	{
		return (U)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x4688C90", Offset = "0x4687690", VA = "0x184688C90", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x4688C90", Offset = "0x4687690", VA = "0x184688C90", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public static class CKEKIFHGGIC<T>
{
	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x3F274D0", Offset = "0x3F25ED0", VA = "0x183F274D0")]
	public static DPBDBKAMFJF<T, U> KDBDJPAJKDJ<U>([In] U DKGBCFDLMOI) where U : IEnumerator<T>
	{
		return default(DPBDBKAMFJF<T, U>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public static class AGIGIDAOMHB
{
	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x32D6640", Offset = "0x32D5040", VA = "0x1832D6640")]
	public static DPBDBKAMFJF<TResult, LIHFMFNNOED<TSourceEnumerator, TSource, TResult>> OKADJEKOEOP<TResult, TSourceEnumerator, TSource>([In] this DPBDBKAMFJF<TSource, TSourceEnumerator> DKGBCFDLMOI, Func<TSource, TResult> ODNIHKHDBNI) where TSourceEnumerator : GAHDIFHIOJO, IEnumerator<TSource>
	{
		return default(DPBDBKAMFJF<TResult, LIHFMFNNOED<TSourceEnumerator, TSource, TResult>>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public struct JEHMKJHNDIM<T> : IEnumerator<T>, IEnumerator, IDisposable, GAHDIFHIOJO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private readonly T[] CHIJICENHIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private int PKCPLKGODML;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public readonly T IGCJDJEKHNM
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x5535240", Offset = "0x5533C40", VA = "0x185535240", Slot = "4")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	readonly object IEnumerator.Current
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x55351F0", Offset = "0x5533BF0", VA = "0x1855351F0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public readonly int BEFNAMGOJCC
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x2B56AC0", Offset = "0x2B554C0", VA = "0x182B56AC0", Slot = "9")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0xDCD740", Offset = "0xDCC140", VA = "0x180DCD740")]
	private JEHMKJHNDIM(T[] DKGBCFDLMOI, int KABGMIEBEFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x5131130", Offset = "0x512FB30", VA = "0x185131130")]
	public static JEHMKJHNDIM<T> KDBDJPAJKDJ(T[] DKGBCFDLMOI)
	{
		return default(JEHMKJHNDIM<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x2B56B10", Offset = "0x2B55510", VA = "0x182B56B10", Slot = "6")]
	public bool MoveNext()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x2B56970", Offset = "0x2B55370", VA = "0x182B56970", Slot = "8")]
	public void Reset()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680", Slot = "5")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public struct LIHFMFNNOED<TSourceEnumerator, TSource, TResult> : GAHDIFHIOJO, IEnumerator<TResult>, IEnumerator, IDisposable where TSourceEnumerator : GAHDIFHIOJO, IEnumerator<TSource>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private TSourceEnumerator CHIJICENHIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private readonly Func<TSource, TResult> FCCLNMCNOCA;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public readonly int BEFNAMGOJCC
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x5737480", Offset = "0x5735E80", VA = "0x185737480", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public readonly TResult IGCJDJEKHNM
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x57377D0", Offset = "0x57361D0", VA = "0x1857377D0", Slot = "5")]
		get
		{
			return (TResult)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	readonly object IEnumerator.Current
	{
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x5737630", Offset = "0x5736030", VA = "0x185737630", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x2B67F90", Offset = "0x2B66990", VA = "0x182B67F90")]
	internal LIHFMFNNOED([In] TSourceEnumerator DKGBCFDLMOI, Func<TSource, TResult> ODNIHKHDBNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x5737510", Offset = "0x5735F10", VA = "0x185737510", Slot = "7")]
	public bool MoveNext()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x57375A0", Offset = "0x5735FA0", VA = "0x1857375A0", Slot = "9")]
	public void Reset()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x5737440", Offset = "0x5735E40", VA = "0x185737440", Slot = "6")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
internal static class PLFNKNCAAHH
{
	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x3F6FFA0", Offset = "0x3F6E9A0", VA = "0x183F6FFA0")]
	public static string AAFLIPPLJLB<T>(this IEnumerable<T> DKGBCFDLMOI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x3F75350", Offset = "0x3F73D50", VA = "0x183F75350")]
	public static string JINGDHGJCKK<T>(this IEnumerable<T> DKGBCFDLMOI, string PLBCHDOJDPN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public static class PAJKLAFOKIJ
{
	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x3F5EE80", Offset = "0x3F5D880", VA = "0x183F5EE80")]
	public static bool OKPBNBCGAGL<TSourceEnumerator, TSource>(this TSourceEnumerator DKGBCFDLMOI, [In] TSource EOJOFJJBHLN) where TSourceEnumerator : JDFFJCHKFGN<TSource> where TSource : IIHDAIFMJNA<TSource>
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x3F5E950", Offset = "0x3F5D350", VA = "0x183F5E950")]
	public static int FBIACNENMBO<TSourceEnumerator, TSource>(this TSourceEnumerator DKGBCFDLMOI, [In] TSource KMAFNKGMDCF) where TSourceEnumerator : JDFFJCHKFGN<TSource> where TSource : IIHDAIFMJNA<TSource>
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x3F5EE20", Offset = "0x3F5D820", VA = "0x183F5EE20")]
	public static LIHFMFNNOED<TSourceEnumerator, TSource, TResult> OKADJEKOEOP<TSourceEnumerator, TSource, TResult>(this TSourceEnumerator DKGBCFDLMOI, Func<TSource, TResult> ODNIHKHDBNI) where TSourceEnumerator : GAHDIFHIOJO, IEnumerator<TSource>
	{
		return default(LIHFMFNNOED<TSourceEnumerator, TSource, TResult>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x3F5EBB0", Offset = "0x3F5D5B0", VA = "0x183F5EBB0")]
	public static int MEACOPOPEOP<TSourceEnumerator, TSource>(this TSourceEnumerator DKGBCFDLMOI, [In] TSource KMAFNKGMDCF) where TSourceEnumerator : IEnumerator<TSource> where TSource : IEquatable<TSource>
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface JDFFJCHKFGN<T> : IEnumerator<T>, IEnumerator, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000009")]
	T IGCJDJEKHNM
	{
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface GAHDIFHIOJO
{
	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	int BEFNAMGOJCC
	{
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface GDLGBNOKPJP<T> : JDFFJCHKFGN<T>, IEnumerator<T>, IEnumerator, IDisposable
{
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public readonly struct HLIJAGLLLIK<T, U> : IEnumerable<T>, IEnumerable where U : GDLGBNOKPJP<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	internal readonly U DMHBCNMMMCA;

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x4688EC0", Offset = "0x46878C0", VA = "0x184688EC0")]
	internal HLIJAGLLLIK([In] U BNAAJHEIBMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x46888D0", Offset = "0x46872D0", VA = "0x1846888D0", Slot = "6")]
	public U GetEnumerator()
	{
		return (U)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x4688D10", Offset = "0x4687710", VA = "0x184688D10", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x4688D10", Offset = "0x4687710", VA = "0x184688D10", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public static class HAHDLJCIEAA<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x3F27530", Offset = "0x3F25F30", VA = "0x183F27530")]
	public static HLIJAGLLLIK<T, U> KDBDJPAJKDJ<U>([In] U DKGBCFDLMOI) where U : GDLGBNOKPJP<T>
	{
		return default(HLIJAGLLLIK<T, U>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
[DefaultMember("Item")]
public readonly struct CEAGJEFPBKJ<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public struct NMLMDDDHGDP : GAHDIFHIOJO, JDFFJCHKFGN<T>, IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private readonly T[] CHIJICENHIH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private int PKCPLKGODML;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public readonly int BEFNAMGOJCC
		{
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x2B56AC0", Offset = "0x2B554C0", VA = "0x182B56AC0", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public readonly T IGCJDJEKHNM
		{
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x5A68330", Offset = "0x5A66D30", VA = "0x185A68330", Slot = "5")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		readonly T IEnumerator<T>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x55351F0", Offset = "0x5533BF0", VA = "0x1855351F0", Slot = "6")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		readonly object? IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x5A67EA0", Offset = "0x5A668A0", VA = "0x185A67EA0", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0xDCD740", Offset = "0xDCC140", VA = "0x180DCD740")]
		private NMLMDDDHGDP(T[] DKGBCFDLMOI, int KABGMIEBEFC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x5131130", Offset = "0x512FB30", VA = "0x185131130")]
		public static NMLMDDDHGDP KDBDJPAJKDJ(T[] DKGBCFDLMOI)
		{
			return default(NMLMDDDHGDP);
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x2B56B10", Offset = "0x2B55510", VA = "0x182B56B10", Slot = "8")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x2B56970", Offset = "0x2B55370", VA = "0x182B56970", Slot = "10")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680", Slot = "7")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	internal readonly T[] KNJHGKFJLEL;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public int EJCBNJPPPEE
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x2B56AC0", Offset = "0x2B554C0", VA = "0x182B56AC0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public T PCCJLFHFGOC
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x3BFFE00", Offset = "0x3BFE800", VA = "0x183BFFE00")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0xECC590", Offset = "0xECAF90", VA = "0x180ECC590")]
	internal CEAGJEFPBKJ(T[] BHEONMJLANC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x6CD7590", Offset = "0x6CD5F90", VA = "0x186CD7590")]
	public static CEAGJEFPBKJ<T> BENGIKOEPPE()
	{
		return default(CEAGJEFPBKJ<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0xB51460", Offset = "0xB4FE60", VA = "0x180B51460")]
	public IEnumerable<T> FMDNLEMEPBD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x6CD7470", Offset = "0x6CD5E70", VA = "0x186CD7470")]
	public ReadOnlySpan<T> AFPBINKHJJL()
	{
		return default(ReadOnlySpan<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x6CD76D0", Offset = "0x6CD60D0", VA = "0x186CD76D0")]
	public PBLIJBPBDIB<T, CEAGJEFPBKJ<T>.NMLMDDDHGDP> LMPAJGGAAAN()
	{
		return default(PBLIJBPBDIB<T, NMLMDDDHGDP>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x6CD7500", Offset = "0x6CD5F00", VA = "0x186CD7500")]
	public NMLMDDDHGDP BBFGOLHFFHP()
	{
		return default(NMLMDDDHGDP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x6CD7650", Offset = "0x6CD6050", VA = "0x186CD7650")]
	public IEnumerator<T> FIIFAFDLDFC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x6CD77F0", Offset = "0x6CD61F0", VA = "0x186CD77F0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public static class ILNOIHNBKEN
{
	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x3BD8C70", Offset = "0x3BD7670", VA = "0x183BD8C70")]
	public static CEAGJEFPBKJ<T> BIHFCHCACNE<T>(params T[] BHEONMJLANC) where T : notnull
	{
		return default(CEAGJEFPBKJ<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x8660440", Offset = "0x865EE40", VA = "0x188660440")]
	public static Stream JJFKPBIFMGN(this CEAGJEFPBKJ<byte> DKGBCFDLMOI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
[DebuggerTypeProxy(typeof(DBIBICKBIIJ<>.JBABGDBALHB))]
public struct DBIBICKBIIJ<T>
{
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public struct IFIFFEDNNCK : GAHDIFHIOJO, GDLGBNOKPJP<T>, JDFFJCHKFGN<T>, IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private readonly T[] KLFCKMIGJNB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private readonly int HHDAEKKGFAH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private int PKCPLKGODML;

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public readonly int BEFNAMGOJCC
		{
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0xF91E00", Offset = "0xF90800", VA = "0x180F91E00", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public readonly T IGCJDJEKHNM
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x52E15E0", Offset = "0x52DFFE0", VA = "0x1852E15E0", Slot = "11")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public readonly T NGFCPMHAEIL
		{
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x52E0BD0", Offset = "0x52DF5D0", VA = "0x1852E0BD0")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		private readonly T HGKOIIFPONI
		{
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x52E0D40", Offset = "0x52DF740", VA = "0x1852E0D40", Slot = "5")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		readonly T IEnumerator<T>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x52E0EE0", Offset = "0x52DF8E0", VA = "0x1852E0EE0", Slot = "6")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		readonly object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x52E1100", Offset = "0x52DFB00", VA = "0x1852E1100", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x52E14F0", Offset = "0x52DFEF0", VA = "0x1852E14F0")]
		internal IFIFFEDNNCK(T[] GLPDKCPPLJM, int MHMCOJIKNCI, int KABGMIEBEFC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x52E0E30", Offset = "0x52DF830", VA = "0x1852E0E30")]
		public static IFIFFEDNNCK KDBDJPAJKDJ(DBIBICKBIIJ<T> DKGBCFDLMOI)
		{
			return default(IFIFFEDNNCK);
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x4BACA00", Offset = "0x4BAB400", VA = "0x184BACA00", Slot = "8")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x4B9CCF0", Offset = "0x4B9B6F0", VA = "0x184B9CCF0", Slot = "10")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680", Slot = "7")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public struct PNODPBCKBCC : GAHDIFHIOJO, JDFFJCHKFGN<T>, IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private IFIFFEDNNCK DMHBCNMMMCA;

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public int BEFNAMGOJCC
		{
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x5CCDE10", Offset = "0x5CCC810", VA = "0x185CCDE10", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public readonly T IGCJDJEKHNM
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x5CCE370", Offset = "0x5CCCD70", VA = "0x185CCE370", Slot = "5")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		readonly T IEnumerator<T>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x5CCE080", Offset = "0x5CCCA80", VA = "0x185CCE080", Slot = "6")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		readonly object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x5CCE210", Offset = "0x5CCCC10", VA = "0x185CCE210", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x12D6400", Offset = "0x12D4E00", VA = "0x1812D6400")]
		private PNODPBCKBCC([In] IFIFFEDNNCK BNAAJHEIBMD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x5CCDE40", Offset = "0x5CCC840", VA = "0x185CCDE40")]
		public static PNODPBCKBCC KDBDJPAJKDJ([In] DBIBICKBIIJ<T> DKGBCFDLMOI)
		{
			return default(PNODPBCKBCC);
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x5CCDEF0", Offset = "0x5CCC8F0", VA = "0x185CCDEF0", Slot = "8")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x5CCDF30", Offset = "0x5CCC930", VA = "0x185CCDF30", Slot = "10")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x5737440", Offset = "0x5735E40", VA = "0x185737440", Slot = "7")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001D")]
	public sealed class JBABGDBALHB
	{
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	internal T[] KLFCKMIGJNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	internal int HHDAEKKGFAH;

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x45D5120", Offset = "0x45D3B20", VA = "0x1845D5120")]
	public static DBIBICKBIIJ<T> KDBDJPAJKDJ()
	{
		return default(DBIBICKBIIJ<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x45D51C0", Offset = "0x45D3BC0", VA = "0x1845D51C0")]
	public static DBIBICKBIIJ<T> OMIAKFKAABA(int JHAGJEMJCCP)
	{
		return default(DBIBICKBIIJ<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0xDCD740", Offset = "0xDCC140", VA = "0x180DCD740")]
	internal DBIBICKBIIJ(T[] GLPDKCPPLJM, int MHMCOJIKNCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x45D5270", Offset = "0x45D3C70", VA = "0x1845D5270", Slot = "3")]
	public override readonly string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public static class HLJKCCIEJAH
{
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public delegate int DMGPKLAOAJJ<TCtx, T>([In] TCtx GFENHEKLPCC, T CFAKKPGMPGD, T KMGOFHJBCKL);

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x3DD8460", Offset = "0x3DD6E60", VA = "0x183DD8460")]
	public static void PIIFCIMJIKL<T>(this DBIBICKBIIJ<T> DKGBCFDLMOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x3DD5F40", Offset = "0x3DD4940", VA = "0x183DD5F40")]
	public static string NIACPPGANAD<T>([In] this DBIBICKBIIJ<T> DKGBCFDLMOI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0xB51460", Offset = "0xB4FE60", VA = "0x180B51460")]
	public static T[] HDLOCCBKLLK<T>([In] this DBIBICKBIIJ<T> DKGBCFDLMOI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x2B55B30", Offset = "0x2B54530", VA = "0x182B55B30")]
	public static T GFFPJLNAMHB<T>([In] this DBIBICKBIIJ<T> DKGBCFDLMOI, int JEDFFCJGKHB)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x2B55B30", Offset = "0x2B54530", VA = "0x182B55B30")]
	public static T JBIDHPNGLGB<T>(this DBIBICKBIIJ<T> DKGBCFDLMOI, int JEDFFCJGKHB)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x3DD53E0", Offset = "0x3DD3DE0", VA = "0x183DD53E0")]
	public static T MMPDNGEAFAO<T>([In] this DBIBICKBIIJ<T> DKGBCFDLMOI, int JEDFFCJGKHB)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x3DD1820", Offset = "0x3DD0220", VA = "0x183DD1820")]
	public static void FNAEMEPGHFK<T>(this DBIBICKBIIJ<T> DKGBCFDLMOI, int JEDFFCJGKHB, [In] T KMAFNKGMDCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x3DD1820", Offset = "0x3DD0220", VA = "0x183DD1820")]
	public static void EDNIPPMHOGI<T>(this DBIBICKBIIJ<T> DKGBCFDLMOI, int JEDFFCJGKHB, T KMAFNKGMDCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0xF91E00", Offset = "0xF90800", VA = "0x180F91E00")]
	public static int GFGCJDNPPIK<T>([In] this DBIBICKBIIJ<T> DKGBCFDLMOI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x3DCFBD0", Offset = "0x3DCE5D0", VA = "0x183DCFBD0")]
	public static ReadOnlySpan<T> AFPBINKHJJL<T>([In] this DBIBICKBIIJ<T> DKGBCFDLMOI)
	{
		return default(ReadOnlySpan<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x3DD1670", Offset = "0x3DD0070", VA = "0x183DD1670")]
	public static T[] DMNKFOEHHOG<T>([In] this DBIBICKBIIJ<T> DKGBCFDLMOI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x3DD2860", Offset = "0x3DD1260", VA = "0x183DD2860")]
	public static T GMLEOGECPFL<T>([In] this DBIBICKBIIJ<T> DKGBCFDLMOI)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x3DD83D0", Offset = "0x3DD6DD0", VA = "0x183DD83D0")]
	public static CEAGJEFPBKJ<T> OOHHDGFFDIJ<T>(this DBIBICKBIIJ<T> DKGBCFDLMOI)
	{
		return default(CEAGJEFPBKJ<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x3DD28F0", Offset = "0x3DD12F0", VA = "0x183DD28F0")]
	public static void HMDNMGBNKIA<T>(this DBIBICKBIIJ<T> DKGBCFDLMOI, [In] T KMAFNKGMDCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x3DD5580", Offset = "0x3DD3F80", VA = "0x183DD5580")]
	public static void NGDIIOBOPDL<T>(this DBIBICKBIIJ<T> DKGBCFDLMOI, T KMAFNKGMDCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x3DD8190", Offset = "0x3DD6B90", VA = "0x183DD8190")]
	public static void OGBKPOJEFBN<T>(this DBIBICKBIIJ<T> DKGBCFDLMOI, int KABGMIEBEFC, [In] T KMAFNKGMDCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x3DD4FD0", Offset = "0x3DD39D0", VA = "0x183DD4FD0")]
	public static void LNAEJBCEBBA<T>(this DBIBICKBIIJ<T> DKGBCFDLMOI, int KABGMIEBEFC, [In] DBIBICKBIIJ<T> FDOLNIMJMJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x3DCF650", Offset = "0x3DCE050", VA = "0x183DCF650")]
	public static void ABPCCKGLLDM<T>(this DBIBICKBIIJ<T> DKGBCFDLMOI, int KABGMIEBEFC, T KMAFNKGMDCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x3DCF780", Offset = "0x3DCE180", VA = "0x183DCF780")]
	public static void AEOLGKCAPHA<T>(this DBIBICKBIIJ<T> DKGBCFDLMOI, int KABGMIEBEFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x3DD8370", Offset = "0x3DD6D70", VA = "0x183DD8370")]
	public static T OJMMHGDOBAM<T>(this DBIBICKBIIJ<T> DKGBCFDLMOI)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x3DD3380", Offset = "0x3DD1D80", VA = "0x183DD3380")]
	public static void JEMMEJHNIAD<T>(this DBIBICKBIIJ<T> DKGBCFDLMOI, int MHMCOJIKNCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x3DD0100", Offset = "0x3DCEB00", VA = "0x183DD0100")]
	private static void DHICIEGNKDO<T>(this DBIBICKBIIJ<T> DKGBCFDLMOI, int JHAGJEMJCCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x3DD1D40", Offset = "0x3DD0740", VA = "0x183DD1D40")]
	public static void EMMOLKMNHIK<T>(this DBIBICKBIIJ<T> DKGBCFDLMOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x3DCF7C0", Offset = "0x3DCE1C0", VA = "0x183DCF7C0")]
	public static DBIBICKBIIJ<T> AFCIIKKNNFA<T>([In] this DBIBICKBIIJ<T> DKGBCFDLMOI, KKKPCGOJLNC<T, T> BIGMIOJICNE)
	{
		return default(DBIBICKBIIJ<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x3DD5170", Offset = "0x3DD3B70", VA = "0x183DD5170")]
	public static int MLAMDHJIIBG<T>([In] this DBIBICKBIIJ<T> DKGBCFDLMOI, T KMAFNKGMDCF) where T : IEquatable<T>
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x3388C90", Offset = "0x3387690", VA = "0x183388C90")]
	public static bool GMMHHEEELIA<T>([In] this DBIBICKBIIJ<T> DKGBCFDLMOI, T KMAFNKGMDCF) where T : IEquatable<T>
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x3DD5070", Offset = "0x3DD3A70", VA = "0x183DD5070")]
	public static bool MCKODPOBNPM<T>(this DBIBICKBIIJ<T> DKGBCFDLMOI, T KMAFNKGMDCF) where T : IEquatable<T>
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x3DD80F0", Offset = "0x3DD6AF0", VA = "0x183DD80F0")]
	public static bool NOMJEKOIMEG<T>(this DBIBICKBIIJ<T> DKGBCFDLMOI, [In] T KMAFNKGMDCF) where T : IIHDAIFMJNA<T>
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x3DD17A0", Offset = "0x3DD01A0", VA = "0x183DD17A0")]
	public static bool DOGEECCMHOL<T>([In] this DBIBICKBIIJ<T> DKGBCFDLMOI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x3DD2830", Offset = "0x3DD1230", VA = "0x183DD2830")]
	public static void GIBIDHHONBD<T, TCtx>(this DBIBICKBIIJ<T> DKGBCFDLMOI, [In] TCtx GFENHEKLPCC, DMGPKLAOAJJ<TCtx, T> PCMLMDHJMLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x3DD2D50", Offset = "0x3DD1750", VA = "0x183DD2D50")]
	private static void JAIHDBPGAAL<T, TCtx>(DBIBICKBIIJ<T> DKGBCFDLMOI, [In] TCtx GFENHEKLPCC, DMGPKLAOAJJ<TCtx, T> PCMLMDHJMLA, int BOOLOMLHBBD, int GCPCGIEODHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x3DD2250", Offset = "0x3DD0C50", VA = "0x183DD2250")]
	private static int FOBMNJPLGID<T, TCtx>(DBIBICKBIIJ<T> DKGBCFDLMOI, [In] TCtx GFENHEKLPCC, DMGPKLAOAJJ<TCtx, T> PCMLMDHJMLA, int BOOLOMLHBBD, int GCPCGIEODHG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x32D31D0", Offset = "0x32D1BD0", VA = "0x1832D31D0")]
	public static DBIBICKBIIJ<T>.PNODPBCKBCC FIIFAFDLDFC<T>([In] this DBIBICKBIIJ<T> DKGBCFDLMOI)
	{
		return default(DBIBICKBIIJ<T>.PNODPBCKBCC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x32D31D0", Offset = "0x32D1BD0", VA = "0x1832D31D0")]
	public static DBIBICKBIIJ<T>.IFIFFEDNNCK OGMGECKFDOH<T>(this DBIBICKBIIJ<T> DKGBCFDLMOI)
	{
		return default(DBIBICKBIIJ<T>.IFIFFEDNNCK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x32D2950", Offset = "0x32D1350", VA = "0x1832D2950")]
	public static PBLIJBPBDIB<T, DBIBICKBIIJ<T>.PNODPBCKBCC> ALMCMAJICHA<T>([In] this DBIBICKBIIJ<T> DKGBCFDLMOI)
	{
		return default(PBLIJBPBDIB<T, DBIBICKBIIJ<T>.PNODPBCKBCC>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
internal static class LPJGFMJKCBA
{
	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x3E78EC0", Offset = "0x3E778C0", VA = "0x183E78EC0")]
	public static T[] KGDMCDPLJJA<T>(int BCAJFCGHDKI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680")]
	public static void OADJCNDOFBA<T>(T[] BHEONMJLANC)
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
