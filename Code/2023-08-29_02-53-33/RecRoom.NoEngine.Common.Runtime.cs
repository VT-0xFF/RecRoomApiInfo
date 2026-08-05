using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using Cpp2IlInjected;
using Microsoft.CodeAnalysis;
using RecRoom.NoEngine.Common;

[assembly: AssemblyVersion("0.0.0.0")]
namespace Microsoft.CodeAnalysis
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[Embedded]
	internal sealed class EmbeddedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x7F1AF0", Offset = "0x7F0EF0", VA = "0x1807F1AF0")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[Embedded]
	[CompilerGenerated]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter)]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x6EBB770", Offset = "0x6EBAB70", VA = "0x186EBB770")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x8D1B70", Offset = "0x8D0F70", VA = "0x1808D1B70")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[Embedded]
	[CompilerGenerated]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate)]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x9D7910", Offset = "0x9D6D10", VA = "0x1809D7910")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Parameter | AttributeTargets.ReturnValue)]
public sealed class AOBEEAMIDJN : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x7F1AF0", Offset = "0x7F0EF0", VA = "0x1807F1AF0")]
	public AOBEEAMIDJN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[AttributeUsage(AttributeTargets.Parameter)]
public sealed class PIJLCHPMKPF : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x9D7910", Offset = "0x9D6D10", VA = "0x1809D7910")]
	public PIJLCHPMKPF(bool BBKNLJJOEGD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
[AttributeUsage(AttributeTargets.Parameter)]
public sealed class OMENNNHHMEF : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x9D7910", Offset = "0x9D6D10", VA = "0x1809D7910")]
	public OMENNNHHMEF(bool BBKNLJJOEGD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Parameter | AttributeTargets.ReturnValue)]
public sealed class BLIKAHGKCEJ : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x7F1AF0", Offset = "0x7F0EF0", VA = "0x1807F1AF0")]
	public BLIKAHGKCEJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
[AttributeUsage(AttributeTargets.Method | AttributeTargets.Property)]
public sealed class MNNPODBKFKI : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x6EBB490", Offset = "0x6EBA890", VA = "0x186EBB490")]
	public MNNPODBKFKI(bool BBKNLJJOEGD, string FACIPGCABCE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
[AttributeUsage(AttributeTargets.All)]
public class EMKCLHFPCCP : Attribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public readonly string CLOBPFLKHFL;

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x8D1B70", Offset = "0x8D0F70", VA = "0x1808D1B70")]
	public EMKCLHFPCCP(string MBHJNEALOOE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public static class MDJFPBOKPIG
{
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private sealed class KIAACFBEPEB<TResult> where TResult : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public TaskCompletionSource<TResult> tcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public CancellationToken token;

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x928540", Offset = "0x927940", VA = "0x180928540")]
		public KIAACFBEPEB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x22133F0", Offset = "0x22127F0", VA = "0x1822133F0")]
		internal void FMEECHGEBCD()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[CompilerGenerated]
	private sealed class DEILDKLEAAA<TResult> where TResult : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public CancellationTokenRegistration registration;

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x928540", Offset = "0x927940", VA = "0x180928540")]
		public DEILDKLEAAA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x2B0F370", Offset = "0x2B0E770", VA = "0x182B0F370")]
		internal void DABLNFHCMKL(Task<TResult> _)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	private sealed class HJDIOMDEPDP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public AsyncTaskMethodBuilder<TaskStatus> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public Task selfInternal;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private Exception <ex>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x7EA760", Offset = "0x7E9B60", VA = "0x1807EA760")]
		public HJDIOMDEPDP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x6EB9050", Offset = "0x6EB8450", VA = "0x186EB9050", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x7EB120", Offset = "0x7EA520", VA = "0x1807EB120", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x6EBB110", Offset = "0x6EBA510", VA = "0x186EBB110")]
	public static Task<TaskStatus> FJALDPAECHP(this Task JCOLBAAGCGE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x293E3B0", Offset = "0x293D7B0", VA = "0x18293E3B0")]
	public static Task<T> KFBOPHIOBEO<T>() where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x6EBB260", Offset = "0x6EBA660", VA = "0x186EBB260")]
	public static Task PBPGODMEEMP(this Task LPNIBKGOBIK, CancellationToken GAOLOMEJCOK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x293FC30", Offset = "0x293F030", VA = "0x18293FC30")]
	public static Task<TResult> PBPGODMEEMP<TResult>(this Task<TResult> LPNIBKGOBIK, CancellationToken GAOLOMEJCOK) where TResult : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x29403F0", Offset = "0x293F7F0", VA = "0x1829403F0")]
	public static TaskCompletionSource<TResult> PBPGODMEEMP<TResult>(this TaskCompletionSource<TResult> NAPIEOOPGJH, CancellationToken GAOLOMEJCOK) where TResult : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x6EBAFC0", Offset = "0x6EBA3C0", VA = "0x186EBAFC0")]
	[DebuggerStepThrough]
	[CompilerGenerated]
	[AsyncStateMachine(typeof(HJDIOMDEPDP))]
	internal static Task<TaskStatus> APNIGMJEEJH(Task BCHPONHEIBB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public interface CAIMKLEKLDA : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	TimeSpan CNMKOHGCOKG
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	Action? DACNEIACIPG
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(Slot = "2")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void ENLGDLEAANC();

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void FICOAOPNFHG();

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void IOLEHDCJDGA();
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public readonly struct NBLNDJODNFJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public readonly string EEMAOFBHODN;

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x9EA8F0", Offset = "0x9E9CF0", VA = "0x1809EA8F0")]
	public NBLNDJODNFJ(string KKIAKNLLHIO)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x7E80A0", Offset = "0x7E74A0", VA = "0x1807E80A0")]
	public static string PGDDHPNABOB(in NBLNDJODNFJ JCOLBAAGCGE)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0xBDEA00", Offset = "0xBDDE00", VA = "0x180BDEA00")]
	public static NBLNDJODNFJ PGDDHPNABOB(string LNOOAJJNCAE)
	{
		return default(NBLNDJODNFJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x6EBB670", Offset = "0x6EBAA70", VA = "0x186EBB670")]
	public string PLCKEMCONAJ(string ABFHPKCOHFI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x6EBB570", Offset = "0x6EBA970", VA = "0x186EBB570")]
	public string ENJEAOIJPGE(object NGGDDMBBPDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x7E80A0", Offset = "0x7E74A0", VA = "0x1807E80A0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public readonly struct ODPPKBIAGLP<T> : IEquatable<ODPPKBIAGLP<T>>, EIMBCPMDPDA<ODPPKBIAGLP<T>> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public readonly T EEMAOFBHODN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public readonly int BJNMAHEDMNC;

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x16CF790", Offset = "0x16CEB90", VA = "0x1816CF790")]
	public ODPPKBIAGLP(in T KKIAKNLLHIO, int NANJAGEOPJI)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x3E893E0", Offset = "0x3E887E0", VA = "0x183E893E0")]
	public static bool MCJHDEKAHDI([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6EC360", Offset = "0x6EB760")] in ODPPKBIAGLP<T> OEMIPMEJOAJ, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6EC3D0", Offset = "0x6EB7D0")] in ODPPKBIAGLP<T> NJNCIEAMKKF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x2AA0F50", Offset = "0x2AA0350", VA = "0x182AA0F50", Slot = "4")]
	public bool Equals([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6EC440", Offset = "0x6EB840")] ODPPKBIAGLP<T> LNOOAJJNCAE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x3E881D0", Offset = "0x3E875D0", VA = "0x183E881D0", Slot = "0")]
	public override bool Equals(object LNOOAJJNCAE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x3E89840", Offset = "0x3E88C40", VA = "0x183E89840")]
	public bool PCEGJADMELK([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6EC4A0", Offset = "0x6EB8A0")] in ODPPKBIAGLP<T> LNOOAJJNCAE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x3E88790", Offset = "0x3E87B90", VA = "0x183E88790", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x3E89930", Offset = "0x3E88D30", VA = "0x183E89930", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x3E88EF0", Offset = "0x3E882F0", VA = "0x183E88EF0")]
	public void IAFKAHLPOAN(out T KKIAKNLLHIO, out int NANJAGEOPJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x3E882D0", Offset = "0x3E876D0", VA = "0x183E882D0")]
	public (T, int) GICNEAOCPBD()
	{
		return default((T, int));
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x3E897F0", Offset = "0x3E88BF0", VA = "0x183E897F0", Slot = "5")]
	private bool NJMBHPPLFAK([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6EC510", Offset = "0x6EB910")] in ODPPKBIAGLP<T> LNOOAJJNCAE)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public static class FGGLDGOIJAO
{
	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x1DAE810", Offset = "0x1DADC10", VA = "0x181DAE810")]
	public static ODPPKBIAGLP<T> OHIOHLNJBHE<T>(in T KKIAKNLLHIO, int NANJAGEOPJI) where T : notnull
	{
		return default(ODPPKBIAGLP<T>);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000015")]
public readonly struct GPBBNBCMMCG : IEquatable<GPBBNBCMMCG>
{
	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x7FFD60", Offset = "0x7FF160", VA = "0x1807FFD60", Slot = "4")]
	public bool Equals(GPBBNBCMMCG LNOOAJJNCAE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x6EB8FC0", Offset = "0x6EB83C0", VA = "0x186EB8FC0", Slot = "0")]
	public override bool Equals(object LNOOAJJNCAE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x6EB9010", Offset = "0x6EB8410", VA = "0x186EB9010", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x6EB9020", Offset = "0x6EB8420", VA = "0x186EB9020", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public readonly struct KNGHDDKPMIM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public readonly CJHEBKAPNKM KBJDOGHPCND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	public readonly EDKKGKNBFEM EAFMBCEIGLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public readonly KGNEJPNDPMN JKEKBIHMHIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public readonly HHOIMPBGKEB OAGIFNIBGFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public readonly JMNIJDKCOPG BCJEELIOFDB;

	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public static readonly KGNEJPNDPMN MAOJMGNMINA;

	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public static readonly HHOIMPBGKEB LNJALMNOJOL;

	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public static readonly JMNIJDKCOPG GGFMGJCFMOJ;

	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public static readonly KNGHDDKPMIM OJIJINABCLB;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool NGKCNIJNPNN
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x6EB9320", Offset = "0x6EB8720", VA = "0x186EB9320")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x6EB98B0", Offset = "0x6EB8CB0", VA = "0x186EB98B0")]
	public KNGHDDKPMIM(in CJHEBKAPNKM DJAFMKJMKIL, in EDKKGKNBFEM IEKOKANHLLB, KGNEJPNDPMN JPCNGFPADCG, HHOIMPBGKEB MLELLKOGHBE, JMNIJDKCOPG OHJDHPCJFPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x6EB92E0", Offset = "0x6EB86E0", VA = "0x186EB92E0")]
	private static string BLIBOMIMNMC(object ICNDEPGFBMI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x7F35A0", Offset = "0x7F29A0", VA = "0x1807F35A0")]
	private static long KFFDMGBEJNI()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x9BB570", Offset = "0x9BA970", VA = "0x1809BB570")]
	private static string AFFAPKNDKNA(string LIOFBOCKKOC, string? OPCAJEKMCHC, bool NCLDFBHCAND)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x6EB9460", Offset = "0x6EB8860", VA = "0x186EB9460")]
	private static KNGHDDKPMIM LKAGDJJLKJI()
	{
		return default(KNGHDDKPMIM);
	}
}
[StructLayout((LayoutKind)2)]
[Cpp2IlInjected.Token(Token = "0x2000017")]
public struct GCCFPAIJDJM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public ulong FKFHKOKPGIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public long HNFINGDPGIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public double HLHAAPJDJCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public uint JDNLJFHGJMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public uint OHEAMDHLEFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public int FBACKMLDFAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public int JJLJPBDNOIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public float AFLEMPJHFNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public float IOGEFDCPEMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public ushort HKGGIGMLGGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public ushort MBLPMLIKBAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	public ushort NEBLPNDBMMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	public ushort FADPAEBBKDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	public short OMMNDELBIGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	public short FMFMKCFPAGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	public short CJBPEAOEEAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	public short JEKIEAIMLMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public char FFEIABEGGAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public char KAMGEOLBKEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public char PIMLFPHPPKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public char LHMMBABDADH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public byte NECOMFBPNIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public byte FGMFBCKABPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public byte BJCAJCCHNMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public byte PGJGOHOOPJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public byte LDKANMMLBDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public byte EDGDAHAIIEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public byte HFOKJAHBJMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public byte ONPJEJCICKO;

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x6EB85D0", Offset = "0x6EB79D0", VA = "0x186EB85D0")]
	public static GCCFPAIJDJM OHIOHLNJBHE(byte ALEDEGPGNJM, byte EOJOJJFDLIK, byte CGBKIEMLJCL, byte CNMCFCJCNPO, byte JMECHEGHPMM, byte MBNOJBDGHPN, byte KONFDHLGPJN, byte HHLLMEKBHAF)
	{
		return default(GCCFPAIJDJM);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public readonly struct CJHEBKAPNKM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public readonly EILIAHNFJHP KNPDKLJBDFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public readonly GNHOOJBJGAM IEPBGKHNOFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public readonly EILIAHNFJHP HADEJDEGFEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	public readonly GNHOOJBJGAM CPIDLLLAPEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	public readonly EILIAHNFJHP EPMNJJPGAIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public readonly GNHOOJBJGAM PCGIOEADPMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public readonly KPOHMLIKLLA NLENGDPABDN;

	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public static readonly EILIAHNFJHP ACEDBLJFNFH;

	[Cpp2IlInjected.Token(Token = "0x4000045")]
	public static readonly GNHOOJBJGAM CLEFHNILGEK;

	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public static readonly EILIAHNFJHP IJEDDECLJBB;

	[Cpp2IlInjected.Token(Token = "0x4000047")]
	public static readonly GNHOOJBJGAM EGKLPIMGDKP;

	[Cpp2IlInjected.Token(Token = "0x4000048")]
	public static readonly EILIAHNFJHP PMFLOGOCKDP;

	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public static readonly GNHOOJBJGAM GOIHOIKPFNJ;

	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public static readonly KPOHMLIKLLA NFCHGMMJGHB;

	[Cpp2IlInjected.Token(Token = "0x400004B")]
	public static readonly CJHEBKAPNKM OJIJINABCLB;

	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public static readonly EILIAHNFJHP PKNBIDMBBAK;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public bool NGKCNIJNPNN
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x6EB7A40", Offset = "0x6EB6E40", VA = "0x186EB7A40")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x7F2650", Offset = "0x7F1A50", VA = "0x1807F2650")]
	public CJHEBKAPNKM(EILIAHNFJHP LMJEICABIHM, GNHOOJBJGAM OBNNFKEHLAC, EILIAHNFJHP DNCFEAGCAOE, GNHOOJBJGAM JKGNFMFGFOG, EILIAHNFJHP BCDKCPEBKJD, GNHOOJBJGAM IPCEHKDEFLI, KPOHMLIKLLA MPCHPNONCKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x7F2D20", Offset = "0x7F2120", VA = "0x1807F2D20")]
	private static bool OAGOLFMDHPA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x7EB120", Offset = "0x7EA520", VA = "0x1807EB120")]
	private static void FEPHGFJPLFP(string HGJHDPGFLKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x7F2D20", Offset = "0x7F2120", VA = "0x1807F2D20")]
	private static bool JCHBHKLKDNN()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x7EB120", Offset = "0x7EA520", VA = "0x1807EB120")]
	private static void KFHHDBGLCDG(string HGJHDPGFLKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x7F2D20", Offset = "0x7F2120", VA = "0x1807F2D20")]
	private static bool NPNIBKGKANI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x7EB120", Offset = "0x7EA520", VA = "0x1807EB120")]
	private static void JKOFHOMLMEG(string HGJHDPGFLKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x7EB120", Offset = "0x7EA520", VA = "0x1807EB120")]
	private static void MPBBJAJJKDM(Exception PJBDDELIPHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x6EB7C80", Offset = "0x6EB7080", VA = "0x186EB7C80")]
	private static CJHEBKAPNKM LKAGDJJLKJI()
	{
		return default(CJHEBKAPNKM);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x7FFD60", Offset = "0x7FF160", VA = "0x1807FFD60")]
	private static bool KMDKJAOHDFP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x6EB79D0", Offset = "0x6EB6DD0", VA = "0x186EB79D0")]
	public void GEPKNBOCDIP(object HGJHDPGFLKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x6EB78D0", Offset = "0x6EB6CD0", VA = "0x186EB78D0")]
	public void CLEFMIEDHDP(object HGJHDPGFLKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x6EB7DC0", Offset = "0x6EB71C0", VA = "0x186EB7DC0")]
	public void LNGEJEFAEBO(Exception PJBDDELIPHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x6EB7940", Offset = "0x6EB6D40", VA = "0x186EB7940")]
	public void CLEFMIEDHDP(HCIKPAIKCFN HGJHDPGFLKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x1CEA040", Offset = "0x1CE9440", VA = "0x181CEA040")]
	public void CLEFMIEDHDP<T>(T FADMIIJIPLK, CPMAMLPMNCK<T> HGJHDPGFLKO) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x1CEA0C0", Offset = "0x1CE94C0", VA = "0x181CEA0C0")]
	public void GEPKNBOCDIP<T>(in T FADMIIJIPLK, AJNDBPKFAJA<T> HGJHDPGFLKO) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x6EB7DE0", Offset = "0x6EB71E0", VA = "0x186EB7DE0")]
	public bool NNPAAGJDMPD(bool CNFJPPDHNAC, string HGJHDPGFLKO)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public static class HBFOOAKBCLA
{
	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x180F570", Offset = "0x180E970", VA = "0x18180F570")]
	public static IEnumerable<T> IOFIHFFKCIE<T>() where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x9BB570", Offset = "0x9BA970", VA = "0x1809BB570")]
	public static T[] GMHBJFEBHIE<T>(params T[] JEALLLNODKL) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x9BB570", Offset = "0x9BA970", VA = "0x1809BB570")]
	public static IEnumerable<T> EIGFCNENOJP<T>(params T[] JEALLLNODKL) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0xBC7E80", Offset = "0xBC7280", VA = "0x180BC7E80")]
	public static HashSet<T> MCJBIFACCKD<T>(params T[] JEALLLNODKL) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x180F580", Offset = "0x180E980", VA = "0x18180F580")]
	public static KeyValuePair<TKey, TValue> KGPBJPICGFH<TKey, TValue>(in TKey KOFPKIJDAMC, in TValue KKIAKNLLHIO) where TKey : notnull where TValue : notnull
	{
		return default(KeyValuePair<TKey, TValue>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0xBC7E80", Offset = "0xBC7280", VA = "0x180BC7E80")]
	public static List<T> FKMDMMBCGDA<T>(IEnumerable<T> CJPIHDACEJM) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
[AttributeUsage(AttributeTargets.All)]
public sealed class IPLNLDPLIJK : Attribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public readonly string OGNAABGAHLK;

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x8D1B70", Offset = "0x8D0F70", VA = "0x1808D1B70")]
	public IPLNLDPLIJK(string DKMLMFNFONI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public static class BKACJAFDDJH
{
	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x3304D40", Offset = "0x3304140", VA = "0x183304D40")]
	public static NBLNDJODNFJ IILKOAEBIOM<T>()
	{
		return default(NBLNDJODNFJ);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x3304AB0", Offset = "0x3303EB0", VA = "0x183304AB0")]
	public static NBLNDJODNFJ APHLAGNJEGG<T>([CallerMemberName] string DKPHPKDPBCM = "") where T : notnull
	{
		return default(NBLNDJODNFJ);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x3304CB0", Offset = "0x33040B0", VA = "0x183304CB0")]
	public static NBLNDJODNFJ IILKOAEBIOM<T>(this T AHNODGPGJKH) where T : notnull
	{
		return default(NBLNDJODNFJ);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x3304B40", Offset = "0x3303F40", VA = "0x183304B40")]
	public static NBLNDJODNFJ FIKKPDLOENF<T>(this T AHNODGPGJKH, [CallerMemberName] string DKPHPKDPBCM = "") where T : notnull
	{
		return default(NBLNDJODNFJ);
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x3304A10", Offset = "0x3303E10", VA = "0x183304A10")]
	public static NBLNDJODNFJ APHLAGNJEGG<T>(this T JCOLBAAGCGE, [CallerMemberName] string DKPHPKDPBCM = "") where T : notnull
	{
		return default(NBLNDJODNFJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x6EB7790", Offset = "0x6EB6B90", VA = "0x186EB7790")]
	public static NBLNDJODNFJ APHLAGNJEGG(string DBJAMBOMFHN, [CallerMemberName] string DKPHPKDPBCM = "")
	{
		return default(NBLNDJODNFJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x6EB7810", Offset = "0x6EB6C10", VA = "0x186EB7810")]
	public static string MMCPHHFKAIN(this object JCOLBAAGCGE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
[IHCDKBCAINB]
public delegate long HHOIMPBGKEB();
[Cpp2IlInjected.Token(Token = "0x200001D")]
public delegate void HKLMLMKLIMJ<T>(in T FADMIIJIPLK);
[Cpp2IlInjected.Token(Token = "0x200001E")]
public static class BFCNPDHGMIK
{
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	private static KNGHDDKPMIM GJAMFANOHJC;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public static KNGHDDKPMIM NCBDOMMAJEH
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x6EB72E0", Offset = "0x6EB66E0", VA = "0x186EB72E0")]
		get
		{
			return default(KNGHDDKPMIM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public static CJHEBKAPNKM KBJDOGHPCND
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x6EB6FC0", Offset = "0x6EB63C0", VA = "0x186EB6FC0")]
		get
		{
			return default(CJHEBKAPNKM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public static EDKKGKNBFEM EAFMBCEIGLN
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x6EB74A0", Offset = "0x6EB68A0", VA = "0x186EB74A0")]
		get
		{
			return default(EDKKGKNBFEM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x6EB7180", Offset = "0x6EB6580", VA = "0x186EB7180")]
	public static void HLFGEDGGAGH(in KNGHDDKPMIM LEIMKPAELGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x6EB70D0", Offset = "0x6EB64D0", VA = "0x186EB70D0")]
	public static void GEPKNBOCDIP(string HGJHDPGFLKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x6EB7020", Offset = "0x6EB6420", VA = "0x186EB7020")]
	public static void CLEFMIEDHDP(string HGJHDPGFLKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x3302F20", Offset = "0x3302320", VA = "0x183302F20")]
	public static void CLEFMIEDHDP<T>(T FADMIIJIPLK, CPMAMLPMNCK<T> HGJHDPGFLKO) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x6EB7500", Offset = "0x6EB6900", VA = "0x186EB7500")]
	public static void LNGEJEFAEBO(Exception PJBDDELIPHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x6EB7580", Offset = "0x6EB6980", VA = "0x186EB7580")]
	public static string MMCPHHFKAIN(object ICNDEPGFBMI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x6EB7430", Offset = "0x6EB6830", VA = "0x186EB7430")]
	public static long JENEJAECKMJ()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x6EB7600", Offset = "0x6EB6A00", VA = "0x186EB7600")]
	public static bool NNPAAGJDMPD(bool CNFJPPDHNAC, string HGJHDPGFLKO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x6EB7340", Offset = "0x6EB6740", VA = "0x186EB7340")]
	public static double JCKAPECOJOA()
	{
		return default(double);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class NNPCDBKGBGI : OCNCPDJOIDH
{
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	public static readonly OCNCPDJOIDH HLFGGJBLCBK;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public DateTime IOFDEDJPKFO
	{
		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x6EBB6C0", Offset = "0x6EBAAC0", VA = "0x186EBB6C0", Slot = "4")]
		get
		{
			return default(DateTime);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x7EA760", Offset = "0x7E9B60", VA = "0x1807EA760")]
	public NNPCDBKGBGI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
[AttributeUsage(AttributeTargets.Interface | AttributeTargets.Delegate)]
public class IHCDKBCAINB : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x7F1AF0", Offset = "0x7F0EF0", VA = "0x1807F1AF0")]
	public IHCDKBCAINB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public delegate TResult LFCJGAHCEEI<T, out TResult>(in T FADMIIJIPLK);
[Cpp2IlInjected.Token(Token = "0x2000022")]
public delegate TResult OCIJKPEILLD<T1, T2, out TResult>(in T1 HIFHFOIAGJC, in T2 IINHHGAOOEA);
[Cpp2IlInjected.Token(Token = "0x2000023")]
public sealed class KOPJEJIKGHN : CAIMKLEKLDA, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public static readonly TimeSpan ODIOJKGOGHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	private readonly System.Timers.Timer ADGMBKKGEOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	private TimeSpan ECADEOGJFGK;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public TimeSpan CNMKOHGCOKG
	{
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x7E8120", Offset = "0x7E7520", VA = "0x1807E8120", Slot = "4")]
		get
		{
			return default(TimeSpan);
		}
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x6EB9940", Offset = "0x6EB8D40", VA = "0x186EB9940", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public Action? DACNEIACIPG
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x7E8110", Offset = "0x7E7510", VA = "0x1807E8110", Slot = "11")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x7F3140", Offset = "0x7F2540", VA = "0x1807F3140", Slot = "6")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x6EB9CF0", Offset = "0x6EB90F0", VA = "0x186EB9CF0")]
	[Preserve]
	public KOPJEJIKGHN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x6EB9D60", Offset = "0x6EB9160", VA = "0x186EB9D60")]
	public KOPJEJIKGHN(TimeSpan ECADEOGJFGK, [Optional] Action? AICPPDCCKMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x6EB9B30", Offset = "0x6EB8F30", VA = "0x186EB9B30", Slot = "7")]
	public void ENLGDLEAANC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x6EB9B90", Offset = "0x6EB8F90", VA = "0x186EB9B90", Slot = "8")]
	public void FICOAOPNFHG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x6EB9C50", Offset = "0x6EB9050", VA = "0x186EB9C50", Slot = "9")]
	public void IOLEHDCJDGA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0xA27170", Offset = "0xA26570", VA = "0x180A27170")]
	private void BMHAEPNKEGE(object AHNODGPGJKH, ElapsedEventArgs LEIKOJAKNJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x6EB9BD0", Offset = "0x6EB8FD0", VA = "0x186EB9BD0")]
	private static void GPNBBGKHCNJ(ref TimeSpan NGIAFBBDBMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x6EB9A90", Offset = "0x6EB8E90", VA = "0x186EB9A90", Slot = "10")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
[AttributeUsage(AttributeTargets.Class)]
public class BFHCHFMBBNB : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x7F1AF0", Offset = "0x7F0EF0", VA = "0x1807F1AF0")]
	public BFHCHFMBBNB()
	{
	}
}
namespace RecRoom.NoEngine.Common
{
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public class PreserveAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x7F1AF0", Offset = "0x7F0EF0", VA = "0x1807F1AF0")]
		public PreserveAttribute()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
[AttributeUsage(AttributeTargets.Method | AttributeTargets.Parameter)]
public class GIHCKDALKPA : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x7F1AF0", Offset = "0x7F0EF0", VA = "0x1807F1AF0")]
	public GIHCKDALKPA(string PDMKOABNPND)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public interface OCNCPDJOIDH
{
	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	DateTime IOFDEDJPKFO
	{
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[StructLayout((LayoutKind)2)]
[Cpp2IlInjected.Token(Token = "0x2000028")]
[DebuggerDisplay("U32: {U32}, I32: {I32}, F32: {F32}, U16_0: {U16_0}, I16_1: {I16_1}, Char_0: '{Char_0}', Char_1: '{Char_1}', U8_0: {U8_0}, U8_1: {U8_1}, U8_2: {U8_2}, U8_3: {U8_3}, Bool_0: {Bool_0}, Bool_1: {Bool_1}, Bool_2: {Bool_2}, Bool_3: {Bool_3}")]
public struct LCJKJPGHEAA : IEquatable<LCJKJPGHEAA>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	public uint MJCNHKCINFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	public int JJNOKGCOKBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	public float APDOHFIKOMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	public ushort HKGGIGMLGGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	public ushort MBLPMLIKBAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	public short OMMNDELBIGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	public short FMFMKCFPAGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public char FFEIABEGGAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public char KAMGEOLBKEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public byte NECOMFBPNIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	public byte FGMFBCKABPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	public byte BJCAJCCHNMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	public byte PGJGOHOOPJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	public bool MKOOFECOMDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	public bool LLDNGDDLMHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	public bool JGOKJPIFDMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	public bool EALHMGHAFMC;

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x142F0D0", Offset = "0x142E4D0", VA = "0x18142F0D0")]
	public static LCJKJPGHEAA JBGCKLLAPIB(uint MLFCBNABIDL)
	{
		return default(LCJKJPGHEAA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x142F0D0", Offset = "0x142E4D0", VA = "0x18142F0D0")]
	public static LCJKJPGHEAA KFACKAHIJFF(int GEBCLKOIIHK)
	{
		return default(LCJKJPGHEAA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x6EBA030", Offset = "0x6EB9430", VA = "0x186EBA030")]
	public static LCJKJPGHEAA JJENAPFOOKP(float PIHHIGKBCBP)
	{
		return default(LCJKJPGHEAA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x6EBA010", Offset = "0x6EB9410", VA = "0x186EBA010")]
	public static LCJKJPGHEAA JECPKIBPBOB(byte ALEDEGPGNJM, byte EOJOJJFDLIK, byte CGBKIEMLJCL, byte CNMCFCJCNPO)
	{
		return default(LCJKJPGHEAA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x6EBA010", Offset = "0x6EB9410", VA = "0x186EBA010")]
	public static LCJKJPGHEAA GKHNIILMFFN(bool IIEEKKIPDJI, bool LEBIBDLMDDJ, bool FJAHFNHIEFL, bool BJHEMFPKJEO)
	{
		return default(LCJKJPGHEAA);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x52B3CC0", Offset = "0x52B30C0", VA = "0x1852B3CC0")]
	public static bool MCJHDEKAHDI(LCJKJPGHEAA LLKHFJFGFIB, LCJKJPGHEAA LDJLPHFLLEO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x3BD2C90", Offset = "0x3BD2090", VA = "0x183BD2C90", Slot = "4")]
	public bool Equals(LCJKJPGHEAA LNOOAJJNCAE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x6EB9F80", Offset = "0x6EB9380", VA = "0x186EB9F80", Slot = "0")]
	public override bool Equals(object ICNDEPGFBMI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x1878BA0", Offset = "0x1877FA0", VA = "0x181878BA0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x6EBA040", Offset = "0x6EB9440", VA = "0x186EBA040", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
[EMKCLHFPCCP("Now that `#nullable enable` is supported in our project, we should probably prefer that. The whole point of this type was to force checking before getting a value.`#nullable enable` can also force checking.")]
public readonly struct NNJDIBIFCBF<T> : IEquatable<NNJDIBIFCBF<T>> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	public readonly T EEMAOFBHODN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	public readonly bool PEEBDMMNPNN;

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public bool OLBFCHKKEHD
	{
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x2AA1CE0", Offset = "0x2AA10E0", VA = "0x182AA1CE0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x2AA2060", Offset = "0x2AA1460", VA = "0x182AA2060")]
	public NNJDIBIFCBF(in T KKIAKNLLHIO, bool LCPADJGNILD)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x2AA19A0", Offset = "0x2AA0DA0", VA = "0x182AA19A0")]
	public static bool MCJHDEKAHDI([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6EC880", Offset = "0x6EBC80")] in NNJDIBIFCBF<T> OEMIPMEJOAJ, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6EC8F0", Offset = "0x6EBCF0")] in NNJDIBIFCBF<T> NJNCIEAMKKF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x2AA0F50", Offset = "0x2AA0350", VA = "0x182AA0F50", Slot = "4")]
	public bool Equals([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6EC960", Offset = "0x6EBD60")] NNJDIBIFCBF<T> LNOOAJJNCAE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x2AA12B0", Offset = "0x2AA06B0", VA = "0x182AA12B0", Slot = "0")]
	public override bool Equals(object LNOOAJJNCAE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x2AA18A0", Offset = "0x2AA0CA0", VA = "0x182AA18A0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x2AA1FA0", Offset = "0x2AA13A0", VA = "0x182AA1FA0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public static class LCPLBEBKABJ
{
	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x2423450", Offset = "0x2422850", VA = "0x182423450")]
	public static NNJDIBIFCBF<T> EGMGBKJDKPG<T>(in T KKIAKNLLHIO) where T : notnull
	{
		return default(NNJDIBIFCBF<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x24235C0", Offset = "0x24229C0", VA = "0x1824235C0")]
	public static NNJDIBIFCBF<T?> NJGLJICFIPF<T>()
	{
		return default(NNJDIBIFCBF<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x2423550", Offset = "0x2422950", VA = "0x182423550")]
	public static bool HOBAHBGNEDB<T>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6EC9C0", Offset = "0x6EBDC0")] this in NNJDIBIFCBF<T> CAMOMFKCJFH, [PIJLCHPMKPF(true)] out T KKIAKNLLHIO) where T : notnull
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public interface EIMBCPMDPDA<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool PCEGJADMELK(in T LNOOAJJNCAE);
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public readonly struct EDKKGKNBFEM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	public readonly PDMPMCKFIIH KGPCFLCAIBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	public readonly MPLFHLICMEF DBKFIMEMCPA;

	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public static readonly PDMPMCKFIIH IJKPLMMLDFP;

	[Cpp2IlInjected.Token(Token = "0x400006A")]
	public static readonly MPLFHLICMEF DFIDNIGOLLO;

	[Cpp2IlInjected.Token(Token = "0x400006B")]
	public static readonly EDKKGKNBFEM OJIJINABCLB;

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public bool NGKCNIJNPNN
	{
		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x6EB82E0", Offset = "0x6EB76E0", VA = "0x186EB82E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0xD82A00", Offset = "0xD81E00", VA = "0x180D82A00")]
	public EDKKGKNBFEM(PDMPMCKFIIH CDDBFOECEAD, MPLFHLICMEF IFNCPDLOJGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x7EB120", Offset = "0x7EA520", VA = "0x1807EB120")]
	private static void FNNKLIMENKM(string DKPHPKDPBCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x7EB120", Offset = "0x7EA520", VA = "0x1807EB120")]
	private static void ENCNLBFGKIG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x6EB83B0", Offset = "0x6EB77B0", VA = "0x186EB83B0")]
	private static EDKKGKNBFEM LKAGDJJLKJI()
	{
		return default(EDKKGKNBFEM);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public static class BLIPJGHGGHP
{
	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x33068B0", Offset = "0x3305CB0", VA = "0x1833068B0")]
	public static bool PCEGJADMELK<T, U>(in T JCOLBAAGCGE, in U ICNDEPGFBMI) where T : notnull, EIMBCPMDPDA<T> where U : notnull
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public sealed class BAAHNHLMDAE<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private static readonly EqualityComparer<T> EDJLLHCFIHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	public T EEMAOFBHODN;

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x24BB2E0", Offset = "0x24BA6E0", VA = "0x1824BB2E0")]
	public BAAHNHLMDAE(in T KKIAKNLLHIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x24BAA50", Offset = "0x24B9E50", VA = "0x1824BAA50", Slot = "0")]
	public override bool Equals(object ICNDEPGFBMI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x24BADE0", Offset = "0x24BA1E0", VA = "0x1824BADE0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x24BAEC0", Offset = "0x24BA2C0", VA = "0x1824BAEC0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public static class GNBBMEONHAA
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public static long AICAAHIHMKJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x6EB87F0", Offset = "0x6EB7BF0", VA = "0x186EB87F0")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public static long LMFBKHFDHME
	{
		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x6EB86E0", Offset = "0x6EB7AE0", VA = "0x186EB86E0")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public static double BKCPFCDHNGH
	{
		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x6EB8BF0", Offset = "0x6EB7FF0", VA = "0x186EB8BF0")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public static double BEPAJLELGBB
	{
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x6EB8C50", Offset = "0x6EB8050", VA = "0x186EB8C50")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public static double OGAPCFBHNIH
	{
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x6EB8A30", Offset = "0x6EB7E30", VA = "0x186EB8A30")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public static double GFCKNIMBJDN
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x6EB8850", Offset = "0x6EB7C50", VA = "0x186EB8850")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x6EB8B40", Offset = "0x6EB7F40", VA = "0x186EB8B40")]
	public static double LGNGGBMAJGJ(long AIMILDDFLEF)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x6EB8A90", Offset = "0x6EB7E90", VA = "0x186EB8A90")]
	public static double LDIFIDPBBII(long AIMILDDFLEF)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x6EB8740", Offset = "0x6EB7B40", VA = "0x186EB8740")]
	public static double EPDJDCOHOFB(double MNOGGODLEPP)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x6EB8630", Offset = "0x6EB7A30", VA = "0x186EB8630")]
	public static long CCGGGFLAAKI(long FBDCHBAJFIH)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x6EB8A20", Offset = "0x6EB7E20", VA = "0x186EB8A20")]
	public static long JGNBKCEFEPH(long GCNGCLEFNBK, long GLHGLIIKPNP)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x6EB8920", Offset = "0x6EB7D20", VA = "0x186EB8920")]
	public static double IBJIHHCFMNO(long GCNGCLEFNBK, long GLHGLIIKPNP)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x6EB88B0", Offset = "0x6EB7CB0", VA = "0x186EB88B0")]
	public static double IBJHIKPPEIC(long GCNGCLEFNBK, long GLHGLIIKPNP)
	{
		return default(double);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public static class NONPGKFKFDH
{
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	private sealed class APHJCCJNKPB<T> : ISet<T>, ICollection<T>, IEnumerable<T>, IEnumerable where T : notnull
	{
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		public static readonly ISet<T> HLFGGJBLCBK;

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public int NPBPHODFKMP
		{
			[Cpp2IlInjected.Token(Token = "0x60000C7")]
			[Cpp2IlInjected.Address(RVA = "0x7F35A0", Offset = "0x7F29A0", VA = "0x1807F35A0", Slot = "7")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public bool PAJHIMACICC
		{
			[Cpp2IlInjected.Token(Token = "0x60000C8")]
			[Cpp2IlInjected.Address(RVA = "0x7FFD60", Offset = "0x7FF160", VA = "0x1807FFD60", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x25743E0", Offset = "0x25737E0", VA = "0x1825743E0", Slot = "4")]
		public bool Add(T ADJFAODNAMI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x7EB120", Offset = "0x7EA520", VA = "0x1807EB120", Slot = "6")]
		public void IntersectWith(IEnumerable<T> LNOOAJJNCAE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x2574540", Offset = "0x2573940", VA = "0x182574540", Slot = "5")]
		public void UnionWith(IEnumerable<T> LNOOAJJNCAE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x25744A0", Offset = "0x25738A0", VA = "0x1825744A0", Slot = "9")]
		void ICollection<T>.Add(T ADJFAODNAMI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x7EB120", Offset = "0x7EA520", VA = "0x1807EB120", Slot = "10")]
		public void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x7F2D20", Offset = "0x7F2120", VA = "0x1807F2D20", Slot = "11")]
		public bool Contains(T ADJFAODNAMI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x7EB120", Offset = "0x7EA520", VA = "0x1807EB120", Slot = "12")]
		public void CopyTo(T[] KGHLGBOMEFA, int BHHKGKOCFBG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x7F2D20", Offset = "0x7F2120", VA = "0x1807F2D20", Slot = "13")]
		public bool Remove(T ADJFAODNAMI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x2574430", Offset = "0x2573830", VA = "0x182574430", Slot = "14")]
		public IEnumerator<T> GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x23045C0", Offset = "0x23039C0", VA = "0x1823045C0", Slot = "15")]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x928540", Offset = "0x927940", VA = "0x180928540")]
		public APHJCCJNKPB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x7E8000", Offset = "0x7E7400", VA = "0x1807E8000")]
	public static ISet<T> KECGGMGEEOE<T>() where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
[IHCDKBCAINB]
public delegate void GNHOOJBJGAM(string HGJHDPGFLKO);
[Cpp2IlInjected.Token(Token = "0x2000033")]
[IHCDKBCAINB]
public delegate string KGNEJPNDPMN(object ICNDEPGFBMI);
[Cpp2IlInjected.Token(Token = "0x2000034")]
[IHCDKBCAINB]
public delegate void MPLFHLICMEF();
[Cpp2IlInjected.Token(Token = "0x2000035")]
public delegate object AJNDBPKFAJA<T>(in T KLEPOOAJLPJ);
[Cpp2IlInjected.Token(Token = "0x2000036")]
public delegate object HCIKPAIKCFN();
[Cpp2IlInjected.Token(Token = "0x2000037")]
[IHCDKBCAINB]
public delegate string JMNIJDKCOPG(string LIOFBOCKKOC, string? OPCAJEKMCHC, bool NCLDFBHCAND);
[Cpp2IlInjected.Token(Token = "0x2000038")]
[IHCDKBCAINB]
public delegate bool EILIAHNFJHP();
[Cpp2IlInjected.Token(Token = "0x2000039")]
public delegate object CPMAMLPMNCK<T>(T KLEPOOAJLPJ);
[Cpp2IlInjected.Token(Token = "0x200003A")]
[IHCDKBCAINB]
public delegate void PDMPMCKFIIH(string DKPHPKDPBCM);
[Cpp2IlInjected.Token(Token = "0x200003B")]
[IHCDKBCAINB]
public delegate void KPOHMLIKLLA(Exception PJBDDELIPHM);
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
