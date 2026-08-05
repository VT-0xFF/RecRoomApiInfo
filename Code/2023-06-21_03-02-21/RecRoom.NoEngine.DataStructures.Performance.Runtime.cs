using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
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
		[Cpp2IlInjected.Address(RVA = "0x841A80", Offset = "0x840C80", VA = "0x180841A80")]
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
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter)]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x15AE980", Offset = "0x15ADB80", VA = "0x1815AE980")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x8F3350", Offset = "0x8F2550", VA = "0x1808F3350")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[Microsoft.CodeAnalysis.Embedded]
	[CompilerGenerated]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate)]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xE73C20", Offset = "0xE72E20", VA = "0x180E73C20")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface HJOHFONIEBL<T> : IEnumerator<T>, IEnumerator, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	T HMPLADJAFAK
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
internal static class FFGMBOCJOFE
{
	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x381F4B0", Offset = "0x381E6B0", VA = "0x18381F4B0")]
	public static string LKPIFHBJENF<T>(this IEnumerable<T> DCMHODHEGEC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x3822790", Offset = "0x3821990", VA = "0x183822790")]
	public static string LLNEMDCMPHM<T>(this IEnumerable<T> DCMHODHEGEC, string BDJHFMNPKBG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public readonly struct LIKKPFMHIEB<T, U> : IEnumerable<T>, IEnumerable where U : BOGNJCFBCKK<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	internal readonly U OIDADDAAEJF;

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x3617460", Offset = "0x3616660", VA = "0x183617460")]
	internal LIKKPFMHIEB(in U DGEHLDDPFAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x25D0880", Offset = "0x25CFA80", VA = "0x1825D0880", Slot = "6")]
	public U GetEnumerator()
	{
		return (U)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x3617130", Offset = "0x3616330", VA = "0x183617130", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x3617130", Offset = "0x3616330", VA = "0x183617130", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class EDNOBKECPDJ<T>
{
	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x2628480", Offset = "0x2627680", VA = "0x182628480")]
	public static LIKKPFMHIEB<T, U> NMBJFIHLDEO<U>(in U DCMHODHEGEC) where U : BOGNJCFBCKK<T>
	{
		return default(LIKKPFMHIEB<T, U>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public static class PIHODICNNFJ
{
	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x42F6980", Offset = "0x42F5B80", VA = "0x1842F6980")]
	public static bool IFGJMJOPPPJ<TSourceEnumerator, TSource, TArgs>(this TSourceEnumerator DCMHODHEGEC, in TArgs AHLCEBMCJMF, in KKIJJMKAJCA<TArgs, TSource, bool> EPCCIGFNMOG) where TSourceEnumerator : HJOHFONIEBL<TSource>
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x42F5E40", Offset = "0x42F5040", VA = "0x1842F5E40")]
	public static int FANMKNGFFFE<TSourceEnumerator, TSource, TArgs>(this TSourceEnumerator DCMHODHEGEC, in TArgs AHLCEBMCJMF, KKIJJMKAJCA<TArgs, TSource, bool> EPCCIGFNMOG) where TSourceEnumerator : HJOHFONIEBL<TSource>
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x42F6630", Offset = "0x42F5830", VA = "0x1842F6630")]
	public static bool GPPADLGKKIH<TSourceEnumerator, TSource>(this TSourceEnumerator DCMHODHEGEC, in TSource FNPJDMFCFGH) where TSourceEnumerator : HJOHFONIEBL<TSource> where TSource : MFKMHCNJACH<TSource>
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x42F62E0", Offset = "0x42F54E0", VA = "0x1842F62E0")]
	public static int FFAACOPAHNC<TSourceEnumerator, TSource>(this TSourceEnumerator DCMHODHEGEC, in TSource ACKOJNNBEBO) where TSourceEnumerator : HJOHFONIEBL<TSource> where TSource : MFKMHCNJACH<TSource>
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x42F5DB0", Offset = "0x42F4FB0", VA = "0x1842F5DB0")]
	public static GDCCBAJCNEE<TSourceEnumerator, TSource, TResult> CLFIDKNNOCH<TSourceEnumerator, TSource, TResult>(this TSourceEnumerator DCMHODHEGEC, HCJBICPEBFB<TSource, TResult> MMFBKCHICCN) where TSourceEnumerator : JAJMGNKDOCC, HJOHFONIEBL<TSource>
	{
		return default(GDCCBAJCNEE<TSourceEnumerator, TSource, TResult>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x42F5DB0", Offset = "0x42F4FB0", VA = "0x1842F5DB0")]
	public static FGDOLLOFPNL<TSourceEnumerator, TSource, TResult> MINMKFNPDHF<TSourceEnumerator, TSource, TResult>(this TSourceEnumerator DCMHODHEGEC, Func<TSource, TResult> MMFBKCHICCN) where TSourceEnumerator : JAJMGNKDOCC, IEnumerator<TSource>
	{
		return default(FGDOLLOFPNL<TSourceEnumerator, TSource, TResult>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public static class NANABHENHMO<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x45F5530", Offset = "0x45F4730", VA = "0x1845F5530")]
	public static bool DDMEFLNNJLE<TSourceEnumerator>(TSourceEnumerator DCMHODHEGEC) where TSourceEnumerator : IEnumerator<T>
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x45F5880", Offset = "0x45F4A80", VA = "0x1845F5880")]
	public static T LBKDJOKCBJI<TSourceEnumerator>(TSourceEnumerator DCMHODHEGEC) where TSourceEnumerator : HJOHFONIEBL<T>
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x45F9770", Offset = "0x45F8970", VA = "0x1845F9770")]
	public static T[] OFMAKBBCDCC<TSourceEnumerator>(TSourceEnumerator DCMHODHEGEC) where TSourceEnumerator : JAJMGNKDOCC, IEnumerator<T>
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x45F5640", Offset = "0x45F4840", VA = "0x1845F5640")]
	public static T IBAMJJMOJCB<TSourceEnumerator>(TSourceEnumerator DCMHODHEGEC) where TSourceEnumerator : IEnumerator<T>
	{
		return (T)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public readonly struct PBKBHDBMPHN<T, U> : IEnumerable<T>, IEnumerable where U : HJOHFONIEBL<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	internal readonly U OIDADDAAEJF;

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x275BBE0", Offset = "0x275ADE0", VA = "0x18275BBE0")]
	internal PBKBHDBMPHN(in U DGEHLDDPFAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x1127750", Offset = "0x1126950", VA = "0x181127750", Slot = "6")]
	public U GetEnumerator()
	{
		return (U)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x35D2BE0", Offset = "0x35D1DE0", VA = "0x1835D2BE0", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x35D2BE0", Offset = "0x35D1DE0", VA = "0x1835D2BE0", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public static class NFGJLBHAEJD<T>
{
	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x26284B0", Offset = "0x26276B0", VA = "0x1826284B0")]
	public static PBKBHDBMPHN<T, U> NMBJFIHLDEO<U>(in U DCMHODHEGEC) where U : HJOHFONIEBL<T>
	{
		return default(PBKBHDBMPHN<T, U>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
[DefaultMember("Item")]
public readonly struct GDHHFAMGGMI<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public struct DONOGHDDGLL : JAJMGNKDOCC, HJOHFONIEBL<T>, IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private readonly T[] HMOJKBKGBGP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private int CENJDAPKDFJ;

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public readonly int CNOEMCDBJKE
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x13C4780", Offset = "0x13C3980", VA = "0x1813C4780", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public readonly T HMPLADJAFAK
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x2EDC020", Offset = "0x2EDB220", VA = "0x182EDC020", Slot = "5")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		readonly T IEnumerator<T>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x2EDBC80", Offset = "0x2EDAE80", VA = "0x182EDBC80", Slot = "6")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		readonly object? IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x2EDBF80", Offset = "0x2EDB180", VA = "0x182EDBF80", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x9A3730", Offset = "0x9A2930", VA = "0x1809A3730")]
		private DONOGHDDGLL(T[] DCMHODHEGEC, int MMFFFGBLCAP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x2EDBA80", Offset = "0x2EDAC80", VA = "0x182EDBA80")]
		public static DONOGHDDGLL NMBJFIHLDEO(T[] DCMHODHEGEC)
		{
			return default(DONOGHDDGLL);
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x159F340", Offset = "0x159E540", VA = "0x18159F340", Slot = "8")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x159F3A0", Offset = "0x159E5A0", VA = "0x18159F3A0", Slot = "10")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x841A70", Offset = "0x840C70", VA = "0x180841A70", Slot = "7")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly T[] OOOADBLOEJD;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public int CGOAKPGGPDP
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x13C4780", Offset = "0x13C3980", VA = "0x1813C4780")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public T LOKIFJEIJCG
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x2EA37E0", Offset = "0x2EA29E0", VA = "0x182EA37E0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0xD48AD0", Offset = "0xD47CD0", VA = "0x180D48AD0")]
	internal GDHHFAMGGMI(T[] BGBPILICHHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x3EDC140", Offset = "0x3EDB340", VA = "0x183EDC140")]
	public static GDHHFAMGGMI<T> GKMFIPLKNAE()
	{
		return default(GDHHFAMGGMI<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x8D6B50", Offset = "0x8D5D50", VA = "0x1808D6B50")]
	public IEnumerable<T> IIGMGCJMIEJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x3EDBF00", Offset = "0x3EDB100", VA = "0x183EDBF00")]
	public ReadOnlySpan<T> AOGGEHOGNEM()
	{
		return default(ReadOnlySpan<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x3EDBF90", Offset = "0x3EDB190", VA = "0x183EDBF90")]
	public PBKBHDBMPHN<T, GDHHFAMGGMI<T>.DONOGHDDGLL> DGKKIOBFMDO()
	{
		return default(PBKBHDBMPHN<T, DONOGHDDGLL>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x3EDC0B0", Offset = "0x3EDB2B0", VA = "0x183EDC0B0")]
	public DONOGHDDGLL GFFHIGABMOK()
	{
		return default(DONOGHDDGLL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x3EDC1F0", Offset = "0x3EDB3F0", VA = "0x183EDC1F0")]
	public IEnumerator<T> KECFEFHENMC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x3EDC270", Offset = "0x3EDB470", VA = "0x183EDC270", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class LIHPCNBPOMG
{
	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x2FEDCD0", Offset = "0x2FECED0", VA = "0x182FEDCD0")]
	public static GDHHFAMGGMI<T> EGFIMLPAOML<T>(params T[] BGBPILICHHA) where T : notnull
	{
		return default(GDHHFAMGGMI<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface JAJMGNKDOCC
{
	[Cpp2IlInjected.Token(Token = "0x17000008")]
	int CNOEMCDBJKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public readonly struct JNOMCIGDOCK<T, U> : IEnumerable<T>, IEnumerable where U : IEnumerator<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	internal readonly U OIDADDAAEJF;

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x3617580", Offset = "0x3616780", VA = "0x183617580")]
	internal JNOMCIGDOCK(in U DGEHLDDPFAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x25D08A0", Offset = "0x25CFAA0", VA = "0x1825D08A0", Slot = "6")]
	public U GetEnumerator()
	{
		return (U)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x3617230", Offset = "0x3616430", VA = "0x183617230", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x3617230", Offset = "0x3616430", VA = "0x183617230", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public static class GPNONGPGLBJ<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x262F7F0", Offset = "0x262E9F0", VA = "0x18262F7F0")]
	public static JNOMCIGDOCK<T, U> NMBJFIHLDEO<U>(in U DCMHODHEGEC) where U : IEnumerator<T>
	{
		return default(JNOMCIGDOCK<T, U>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
[DefaultMember("Item")]
public sealed class OODPKNMAAED<T> : IDisposable, JAJMGNKDOCC, IEnumerable<T>, IEnumerable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private MGHODKJBJID<T> KEKNFEADEAO;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public int CNOEMCDBJKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x324A810", Offset = "0x3249A10", VA = "0x18324A810", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public T LOKIFJEIJCG
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x324A6E0", Offset = "0x32498E0", VA = "0x18324A6E0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x324A700", Offset = "0x3249900", VA = "0x18324A700")]
	public static OODPKNMAAED<T> NMBJFIHLDEO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x324A560", Offset = "0x3249760", VA = "0x18324A560")]
	public static OODPKNMAAED<T> FDMMCOLCNFJ(int HBHBCIIAIII)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x324A8C0", Offset = "0x3249AC0", VA = "0x18324A8C0")]
	internal OODPKNMAAED(in MGHODKJBJID<T> NKLFKPOOEFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x324A540", Offset = "0x3249740", VA = "0x18324A540", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x324A830", Offset = "0x3249A30", VA = "0x18324A830")]
	public void PPMBLONPHPF(in T ACKOJNNBEBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x324A6C0", Offset = "0x32498C0", VA = "0x18324A6C0")]
	public void HGEHCLHLIHP(int IGDJHHPIJBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x324A680", Offset = "0x3249880", VA = "0x18324A680", Slot = "8")]
	public MGHODKJBJID<T>.MNPAGGMHGLH GetEnumerator()
	{
		return default(MGHODKJBJID<T>.MNPAGGMHGLH);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x324A850", Offset = "0x3249A50", VA = "0x18324A850", Slot = "6")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x324A850", Offset = "0x3249A50", VA = "0x18324A850", Slot = "7")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
[DebuggerTypeProxy(typeof(MGHODKJBJID<>.HOOCMMONHHD))]
public struct MGHODKJBJID<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public struct MNPAGGMHGLH : JAJMGNKDOCC, BOGNJCFBCKK<T>, HJOHFONIEBL<T>, IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private readonly T[] ELAHPLDBKNK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private readonly int JCBHPHBKBPG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private int CENJDAPKDFJ;

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public readonly int CNOEMCDBJKE
		{
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x9A3760", Offset = "0x9A2960", VA = "0x1809A3760", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public readonly T HMPLADJAFAK
		{
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x2C82AA0", Offset = "0x2C81CA0", VA = "0x182C82AA0", Slot = "11")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		private readonly T PDPFKJKLGOI
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x2C81A30", Offset = "0x2C80C30", VA = "0x182C81A30", Slot = "5")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		readonly T IEnumerator<T>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x2C81E90", Offset = "0x2C81090", VA = "0x182C81E90", Slot = "6")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		readonly object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x2C82600", Offset = "0x2C81800", VA = "0x182C82600", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x10E4580", Offset = "0x10E3780", VA = "0x1810E4580")]
		internal MNPAGGMHGLH(T[] CAGPAHEIADO, int IGDJHHPIJBK, int MMFFFGBLCAP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x2C81D20", Offset = "0x2C80F20", VA = "0x182C81D20")]
		public static MNPAGGMHGLH NMBJFIHLDEO(ref MGHODKJBJID<T> DCMHODHEGEC)
		{
			return default(MNPAGGMHGLH);
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x2C81D10", Offset = "0x2C80F10", VA = "0x182C81D10", Slot = "8")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x2C81D80", Offset = "0x2C80F80", VA = "0x182C81D80", Slot = "10")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x841A70", Offset = "0x840C70", VA = "0x180841A70", Slot = "7")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public struct CPEDAEDPJGF : JAJMGNKDOCC, HJOHFONIEBL<T>, IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private MNPAGGMHGLH OIDADDAAEJF;

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public int CNOEMCDBJKE
		{
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x383E200", Offset = "0x383D400", VA = "0x18383E200", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public readonly T HMPLADJAFAK
		{
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x383EAB0", Offset = "0x383DCB0", VA = "0x18383EAB0", Slot = "5")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		readonly T IEnumerator<T>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x383E460", Offset = "0x383D660", VA = "0x18383E460", Slot = "6")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		readonly object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x383E850", Offset = "0x383DA50", VA = "0x18383E850", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x275BBE0", Offset = "0x275ADE0", VA = "0x18275BBE0")]
		private CPEDAEDPJGF(in MNPAGGMHGLH DGEHLDDPFAK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x383E140", Offset = "0x383D340", VA = "0x18383E140")]
		public static CPEDAEDPJGF NMBJFIHLDEO(in MGHODKJBJID<T> DCMHODHEGEC)
		{
			return default(CPEDAEDPJGF);
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x383E100", Offset = "0x383D300", VA = "0x18383E100", Slot = "8")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x383E230", Offset = "0x383D430", VA = "0x18383E230", Slot = "10")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x383E0C0", Offset = "0x383D2C0", VA = "0x18383E0C0", Slot = "7")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public sealed class HOOCMMONHHD
	{
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	internal T[] ELAHPLDBKNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	internal int JCBHPHBKBPG;

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x30BF910", Offset = "0x30BEB10", VA = "0x1830BF910")]
	public static MGHODKJBJID<T> NMBJFIHLDEO()
	{
		return default(MGHODKJBJID<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x30BF830", Offset = "0x30BEA30", VA = "0x1830BF830")]
	public static MGHODKJBJID<T> FDMMCOLCNFJ(int HBHBCIIAIII)
	{
		return default(MGHODKJBJID<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x9A3730", Offset = "0x9A2930", VA = "0x1809A3730")]
	internal MGHODKJBJID(T[] CAGPAHEIADO, int IGDJHHPIJBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x275BB70", Offset = "0x275AD70", VA = "0x18275BB70", Slot = "3")]
	public override readonly string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public static class FDDMIKABPFH
{
	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x311DA50", Offset = "0x311CC50", VA = "0x18311DA50")]
	public static void DEAHKEFKGBN<T>(this ref MGHODKJBJID<T> DCMHODHEGEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x311C2F0", Offset = "0x311B4F0", VA = "0x18311C2F0")]
	public static string DAHDANMLBHI<T>(this in MGHODKJBJID<T> DCMHODHEGEC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x8D6B50", Offset = "0x8D5D50", VA = "0x1808D6B50")]
	public static T[] NEIGEGKCNFN<T>(this in MGHODKJBJID<T> DCMHODHEGEC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x311DB80", Offset = "0x311CD80", VA = "0x18311DB80")]
	public static T MEINKDCJHDP<T>(this in MGHODKJBJID<T> DCMHODHEGEC, int PPKKHBJMHLB)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x311DAC0", Offset = "0x311CCC0", VA = "0x18311DAC0")]
	public static T EEDIHMHDPGO<T>(this ref MGHODKJBJID<T> DCMHODHEGEC, int PPKKHBJMHLB)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x9A3760", Offset = "0x9A2960", VA = "0x1809A3760")]
	public static int ALADNLMPBFN<T>(this in MGHODKJBJID<T> DCMHODHEGEC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x3118A20", Offset = "0x3117C20", VA = "0x183118A20")]
	public static ReadOnlySpan<T> AOGGEHOGNEM<T>(this in MGHODKJBJID<T> DCMHODHEGEC)
	{
		return default(ReadOnlySpan<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x3120AC0", Offset = "0x311FCC0", VA = "0x183120AC0")]
	public static ReadOnlyMemory<T> LAGPPBAHKCJ<T>(this in MGHODKJBJID<T> DCMHODHEGEC)
	{
		return default(ReadOnlyMemory<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x3121000", Offset = "0x3120200", VA = "0x183121000")]
	public static void PPMBLONPHPF<T>(this ref MGHODKJBJID<T> DCMHODHEGEC, in T ACKOJNNBEBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x3120E10", Offset = "0x3120010", VA = "0x183120E10")]
	public static void MCHLPOMICIK<T>(this ref MGHODKJBJID<T> DCMHODHEGEC, int MMFFFGBLCAP, in T ACKOJNNBEBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x3120D20", Offset = "0x311FF20", VA = "0x183120D20")]
	public static void LIDGMIKDKFG<T>(this ref MGHODKJBJID<T> DCMHODHEGEC, int MMFFFGBLCAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x311FB70", Offset = "0x311ED70", VA = "0x18311FB70")]
	public static void HGEHCLHLIHP<T>(this ref MGHODKJBJID<T> DCMHODHEGEC, int IGDJHHPIJBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x311DEC0", Offset = "0x311D0C0", VA = "0x18311DEC0")]
	private static void FMKACFFLDAH<T>(this ref MGHODKJBJID<T> DCMHODHEGEC, int HBHBCIIAIII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x311BF40", Offset = "0x311B140", VA = "0x18311BF40")]
	public static void DAFFCKIEONE<T>(this ref MGHODKJBJID<T> DCMHODHEGEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x311F830", Offset = "0x311EA30", VA = "0x18311F830")]
	public static bool FOMINFEJGNH<T>(this ref MGHODKJBJID<T> DCMHODHEGEC, in T ACKOJNNBEBO) where T : MFKMHCNJACH<T>
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0xF13570", Offset = "0xF12770", VA = "0x180F13570")]
	public static bool FKBOPHAPEKO<T>(this in MGHODKJBJID<T> DCMHODHEGEC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x311F8C0", Offset = "0x311EAC0", VA = "0x18311F8C0")]
	public static bool GBNNECEBKHM<T>(this in MGHODKJBJID<T> DCMHODHEGEC, int PPKKHBJMHLB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x2859040", Offset = "0x2858240", VA = "0x182859040")]
	public static MGHODKJBJID<T>.CPEDAEDPJGF KECFEFHENMC<T>(this in MGHODKJBJID<T> DCMHODHEGEC)
	{
		return default(MGHODKJBJID<T>.CPEDAEDPJGF);
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x2859040", Offset = "0x2858240", VA = "0x182859040")]
	public static MGHODKJBJID<T>.MNPAGGMHGLH ONHEDNBFHJD<T>(this ref MGHODKJBJID<T> DCMHODHEGEC)
	{
		return default(MGHODKJBJID<T>.MNPAGGMHGLH);
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x2AE6920", Offset = "0x2AE5B20", VA = "0x182AE6920")]
	public static PBKBHDBMPHN<T, MGHODKJBJID<T>.CPEDAEDPJGF> BOECGLAGLLJ<T>(this in MGHODKJBJID<T> DCMHODHEGEC)
	{
		return default(PBKBHDBMPHN<T, MGHODKJBJID<T>.CPEDAEDPJGF>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public struct GDCCBAJCNEE<TSourceEnumerator, TSource, TResult> : JAJMGNKDOCC, IEnumerator<TResult>, IEnumerator, IDisposable where TSourceEnumerator : JAJMGNKDOCC, HJOHFONIEBL<TSource>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private TSourceEnumerator HMOJKBKGBGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private readonly HCJBICPEBFB<TSource, TResult> DGGEEFAMPDO;

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public readonly int CNOEMCDBJKE
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x3EDB3B0", Offset = "0x3EDA5B0", VA = "0x183EDB3B0", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public readonly TResult HMPLADJAFAK
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x3EDBCC0", Offset = "0x3EDAEC0", VA = "0x183EDBCC0", Slot = "5")]
		get
		{
			return (TResult)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	readonly object IEnumerator.Current
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x3EDB950", Offset = "0x3EDAB50", VA = "0x183EDB950", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x25CFDB0", Offset = "0x25CEFB0", VA = "0x1825CFDB0")]
	internal GDCCBAJCNEE(in TSourceEnumerator DCMHODHEGEC, HCJBICPEBFB<TSource, TResult> MMFBKCHICCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x3EDB290", Offset = "0x3EDA490", VA = "0x183EDB290", Slot = "7")]
	public bool MoveNext()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x3EDB770", Offset = "0x3EDA970", VA = "0x183EDB770", Slot = "9")]
	public void Reset()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x3EDB0F0", Offset = "0x3EDA2F0", VA = "0x183EDB0F0", Slot = "6")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public struct FGDOLLOFPNL<TSourceEnumerator, TSource, TResult> : JAJMGNKDOCC, IEnumerator<TResult>, IEnumerator, IDisposable where TSourceEnumerator : JAJMGNKDOCC, IEnumerator<TSource>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private TSourceEnumerator HMOJKBKGBGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private readonly Func<TSource, TResult> DGGEEFAMPDO;

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public readonly int CNOEMCDBJKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x4C495A0", Offset = "0x4C487A0", VA = "0x184C495A0", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public readonly TResult HMPLADJAFAK
	{
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x3EDBB10", Offset = "0x3EDAD10", VA = "0x183EDBB10", Slot = "5")]
		get
		{
			return (TResult)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	readonly object IEnumerator.Current
	{
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x3EDB850", Offset = "0x3EDAA50", VA = "0x183EDB850", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x25CFDB0", Offset = "0x25CEFB0", VA = "0x1825CFDB0")]
	internal FGDOLLOFPNL(in TSourceEnumerator DCMHODHEGEC, Func<TSource, TResult> MMFBKCHICCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x4C49480", Offset = "0x4C48680", VA = "0x184C49480", Slot = "7")]
	public bool MoveNext()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x4C49730", Offset = "0x4C48930", VA = "0x184C49730", Slot = "9")]
	public void Reset()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x4C49360", Offset = "0x4C48560", VA = "0x184C49360", Slot = "6")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public interface BOGNJCFBCKK<T> : HJOHFONIEBL<T>, IEnumerator<T>, IEnumerator, IDisposable
{
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public static class BEDAFLOIONM
{
	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x1C212D0", Offset = "0x1C204D0", VA = "0x181C212D0")]
	public static GDHHFAMGGMI<T> OLEMKLGMOJP<T>(this T[] DCMHODHEGEC)
	{
		return default(GDHHFAMGGMI<T>);
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
