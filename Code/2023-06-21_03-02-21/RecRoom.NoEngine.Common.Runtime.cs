using System;
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
		[Cpp2IlInjected.Address(RVA = "0x841A80", Offset = "0x840C80", VA = "0x180841A80")]
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
		[Cpp2IlInjected.Address(RVA = "0x709DE40", Offset = "0x709D040", VA = "0x18709DE40")]
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
	[CompilerGenerated]
	[Embedded]
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
[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Parameter | AttributeTargets.ReturnValue)]
public sealed class EBMMMLIJGOH : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x841A80", Offset = "0x840C80", VA = "0x180841A80")]
	public EBMMMLIJGOH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[AttributeUsage(AttributeTargets.Parameter)]
public sealed class OPJMDPNHGGA : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0xE73C20", Offset = "0xE72E20", VA = "0x180E73C20")]
	public OPJMDPNHGGA(bool EEKPPFAJCIM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
[AttributeUsage(AttributeTargets.Parameter)]
public sealed class IKMCMOGPPMB : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0xE73C20", Offset = "0xE72E20", VA = "0x180E73C20")]
	public IKMCMOGPPMB(bool EEKPPFAJCIM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
[AttributeUsage(AttributeTargets.Method | AttributeTargets.Property)]
public sealed class LNPKNGPGOJJ : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x709DAD0", Offset = "0x709CCD0", VA = "0x18709DAD0")]
	public LNPKNGPGOJJ(bool EEKPPFAJCIM, string CGFMKFONLJJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
[AttributeUsage(AttributeTargets.All)]
public class AMLFBPMMCGO : Attribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public readonly string NELILPDIEDH;

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x8F3350", Offset = "0x8F2550", VA = "0x1808F3350")]
	public AMLFBPMMCGO(string JDAIAPJCJIG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public static class COFEJDEDDLP
{
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private sealed class BJEEGMEFEAK<TResult> where TResult : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public TaskCompletionSource<TResult> tcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public CancellationToken token;

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x1913A50", Offset = "0x1912C50", VA = "0x181913A50")]
		public BJEEGMEFEAK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x33FBA40", Offset = "0x33FAC40", VA = "0x1833FBA40")]
		internal void IDNFOFMIHPN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private sealed class DEAKBGLDLML<TResult> where TResult : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public CancellationTokenRegistration registration;

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x1913A50", Offset = "0x1912C50", VA = "0x181913A50")]
		public DEAKBGLDLML()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x1554310", Offset = "0x1553510", VA = "0x181554310")]
		internal void FFNKCIMENPE(Task<TResult> _)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[CompilerGenerated]
	private sealed class NHGAJMKJBJE : IAsyncStateMachine
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

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x84C440", Offset = "0x84B640", VA = "0x18084C440")]
		public NHGAJMKJBJE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x709DC40", Offset = "0x709CE40", VA = "0x18709DC40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x841A70", Offset = "0x840C70", VA = "0x180841A70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x709B920", Offset = "0x709AB20", VA = "0x18709B920")]
	public static Task<TaskStatus> KPPEPFIIECH(this Task DCMHODHEGEC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x2E4B650", Offset = "0x2E4A850", VA = "0x182E4B650")]
	public static Task<T> DGJPHGOKFIC<T>() where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x709B5A0", Offset = "0x709A7A0", VA = "0x18709B5A0")]
	public static Task BPPBPBHPHHG(this Task ONPFLGLLMLP, CancellationToken IBIKCCMDMHA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x2E4A8F0", Offset = "0x2E49AF0", VA = "0x182E4A8F0")]
	public static Task<TResult> BPPBPBHPHHG<TResult>(this Task<TResult> ONPFLGLLMLP, CancellationToken IBIKCCMDMHA) where TResult : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x2E4B290", Offset = "0x2E4A490", VA = "0x182E4B290")]
	public static TaskCompletionSource<TResult> BPPBPBHPHHG<TResult>(this TaskCompletionSource<TResult> ELJNJOHOLGB, CancellationToken IBIKCCMDMHA) where TResult : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x709B7D0", Offset = "0x709A9D0", VA = "0x18709B7D0")]
	[DebuggerStepThrough]
	[CompilerGenerated]
	[AsyncStateMachine(typeof(NHGAJMKJBJE))]
	internal static Task<TaskStatus> FAGDLGDLDHK(Task MGALAFPACKK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface IAIJJIFLDDJ : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	TimeSpan DBAGEHMIJNI
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	Action? BGLAJCBIDKA
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(Slot = "2")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void PBELNPMEPJD();

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void MIAKLFHAKNJ();

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void BFAKIAFHDEO();
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public readonly struct LKOOFNGFLIN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public readonly string IHPKAGOHFMA;

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0xD48AD0", Offset = "0xD47CD0", VA = "0x180D48AD0")]
	public LKOOFNGFLIN(string ACKOJNNBEBO)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x8D6B50", Offset = "0x8D5D50", VA = "0x1808D6B50")]
	public static string MDCOPBLGMCP(in LKOOFNGFLIN DCMHODHEGEC)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x141E120", Offset = "0x141D320", VA = "0x18141E120")]
	public static LKOOFNGFLIN MDCOPBLGMCP(string HPOECFLNEOJ)
	{
		return default(LKOOFNGFLIN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x709D980", Offset = "0x709CB80", VA = "0x18709D980")]
	public string DBNLJPLNHKH(string NGMCLNPINFA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x709D9D0", Offset = "0x709CBD0", VA = "0x18709D9D0")]
	public string JLKDDBOLMMO(object PLBIEEFAOCI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x8D6B50", Offset = "0x8D5D50", VA = "0x1808D6B50", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public readonly struct AOBPECIGIAH<T> : IEquatable<AOBPECIGIAH<T>>, MFKMHCNJACH<AOBPECIGIAH<T>> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public readonly T IHPKAGOHFMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public readonly int FPMEKFLEFKK;

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x141B510", Offset = "0x141A710", VA = "0x18141B510")]
	public AOBPECIGIAH(in T ACKOJNNBEBO, int MMFFFGBLCAP)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x3933650", Offset = "0x3932850", VA = "0x183933650")]
	public static bool JGKKLLGINAK([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7E9810", Offset = "0x7E8C10")] in AOBPECIGIAH<T> NGKKOMJDENH, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7E9880", Offset = "0x7E8C80")] in AOBPECIGIAH<T> KEJINCBACKA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x2F60050", Offset = "0x2F5F250", VA = "0x182F60050", Slot = "4")]
	public bool Equals([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7E98F0", Offset = "0x7E8CF0")] AOBPECIGIAH<T> HPOECFLNEOJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x39327F0", Offset = "0x39319F0", VA = "0x1839327F0", Slot = "0")]
	public override bool Equals(object HPOECFLNEOJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x3932770", Offset = "0x3931970", VA = "0x183932770")]
	public bool DMPMLAKNGKG([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7E9950", Offset = "0x7E8D50")] in AOBPECIGIAH<T> HPOECFLNEOJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x3933020", Offset = "0x3932220", VA = "0x183933020", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x3933D20", Offset = "0x3932F20", VA = "0x183933D20", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x3932A30", Offset = "0x3931C30", VA = "0x183932A30")]
	public void GLEFOFFFOIN(out T ACKOJNNBEBO, out int MMFFFGBLCAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x39337D0", Offset = "0x39329D0", VA = "0x1839337D0")]
	public (T, int) LCDEPCKBAJK()
	{
		return default((T, int));
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x3933290", Offset = "0x3932490", VA = "0x183933290", Slot = "5")]
	private bool IJKHEPNJBLJ([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7E99C0", Offset = "0x7E8DC0")] in AOBPECIGIAH<T> HPOECFLNEOJ)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public static class EDDBDDEBGME
{
	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x33BDFA0", Offset = "0x33BD1A0", VA = "0x1833BDFA0")]
	public static AOBPECIGIAH<T> NMBJFIHLDEO<T>(in T ACKOJNNBEBO, int MMFFFGBLCAP) where T : notnull
	{
		return default(AOBPECIGIAH<T>);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000014")]
public readonly struct HHFDPGOJPDI : IEquatable<HHFDPGOJPDI>
{
	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x844770", Offset = "0x843970", VA = "0x180844770", Slot = "4")]
	public bool Equals(HHFDPGOJPDI HPOECFLNEOJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x709BA70", Offset = "0x709AC70", VA = "0x18709BA70", Slot = "0")]
	public override bool Equals(object HPOECFLNEOJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x709BAC0", Offset = "0x709ACC0", VA = "0x18709BAC0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x709BAD0", Offset = "0x709ACD0", VA = "0x18709BAD0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public readonly struct BNOIADHJNMG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public readonly LHBFBBLAEKP HDAOJPMLHFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	public readonly KOAHJPMAMBA CFHAHLALAHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public readonly MBCJLNPMGJB FBHNPCAGEDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public readonly GBIBJMHMIDP CONFJNLOKGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public readonly LOEDOAAOELI PIBGCHJAIGJ;

	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public static readonly MBCJLNPMGJB KGJADFJPMIC;

	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public static readonly GBIBJMHMIDP LODAGMFIKMJ;

	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public static readonly LOEDOAAOELI HBCDMCOLILJ;

	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public static readonly BNOIADHJNMG GKMFIPLKNAE;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool JNICLPBNKND
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x709AF40", Offset = "0x709A140", VA = "0x18709AF40")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x709B510", Offset = "0x709A710", VA = "0x18709B510")]
	public BNOIADHJNMG(in LHBFBBLAEKP CFHKPMDHLKF, in KOAHJPMAMBA BHOECJGGAIJ, MBCJLNPMGJB FIAJHLGHOPH, GBIBJMHMIDP PFLBCNMEOPN, LOEDOAAOELI OKDIMOKGNBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x709B1A0", Offset = "0x709A3A0", VA = "0x18709B1A0")]
	private static string GJKOJPDHKPO(object BHEOHCEHIBM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x825480", Offset = "0x824680", VA = "0x180825480")]
	private static long JMEPOOBFJGI()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x9A16E0", Offset = "0x9A08E0", VA = "0x1809A16E0")]
	private static string KKIPNMHPDEC(string MKPBIBAIDNM, string? BMMBLDABIAH, bool BDNFFALPGBH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x709B080", Offset = "0x709A280", VA = "0x18709B080")]
	private static BNOIADHJNMG GICNFEGBEKA()
	{
		return default(BNOIADHJNMG);
	}
}
[StructLayout((LayoutKind)2)]
[Cpp2IlInjected.Token(Token = "0x2000016")]
public struct OLLDMAFPDHN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public ulong BDCFMEPKNHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public long CNAPMMLNKLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public double IKJGNKIPBJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public uint MOACKENJNEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public uint JANIFCGBBGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public int ANOMKFNJKHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public int MLDJKIPFJCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public float OHJDJGJFOOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public float FNCFPOONDFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public ushort CEDMNAILJNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public ushort GIAPDMPCAGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	public ushort ACLAKIHNMLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	public ushort ADBCMIOGMHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	public short PPHKGMFDFNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	public short CHNJJAIHOFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	public short IOEHDPGIBGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	public short OAMJFOEIBAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public char KELAINPGKOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public char KKPDOCKEIJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public char AFJIHBPPOJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public char ICBKAEAKLJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public byte CMDLMJINFJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public byte DMAAEKBENGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public byte FFEHOCAPMKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public byte KBLMKNIIEAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public byte LPHANLCAMFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public byte EFEDPLJPLLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public byte PELMHEJIOLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public byte CKNLDFIDHHK;

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x709DED0", Offset = "0x709D0D0", VA = "0x18709DED0")]
	public static OLLDMAFPDHN NMBJFIHLDEO(byte CFFHINLNIGC, byte EGHBKCJEMNM, byte DDCNLFNFEBI, byte DFINJFBJNGH, byte AMOHPHJDLEC, byte OGOPOCLGJNP, byte IDFFGBDBOFP, byte DKBPOBMMHOL)
	{
		return default(OLLDMAFPDHN);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public readonly struct LHBFBBLAEKP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public readonly BBMNDEOMHKI LAGNLCKLPCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public readonly PNLFGDJJHEM ILKOMKGIBPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public readonly BBMNDEOMHKI CKGFJPCKJPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	public readonly PNLFGDJJHEM PDBGGMJLPJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	public readonly BBMNDEOMHKI LCHGDJNDGDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public readonly PNLFGDJJHEM AIFAGPOPGLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public readonly BDFNEMLKGLD IDMBCLBJPHA;

	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public static readonly BBMNDEOMHKI KFOLKBIKJMN;

	[Cpp2IlInjected.Token(Token = "0x4000045")]
	public static readonly PNLFGDJJHEM MODLOLCEJEA;

	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public static readonly BBMNDEOMHKI HBHGHJIIDHI;

	[Cpp2IlInjected.Token(Token = "0x4000047")]
	public static readonly PNLFGDJJHEM PCJJMFGNIHC;

	[Cpp2IlInjected.Token(Token = "0x4000048")]
	public static readonly BBMNDEOMHKI JKLLFKOIPAC;

	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public static readonly PNLFGDJJHEM BOIOOJJHMBC;

	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public static readonly BDFNEMLKGLD MCAHHLEOJDE;

	[Cpp2IlInjected.Token(Token = "0x400004B")]
	public static readonly LHBFBBLAEKP GKMFIPLKNAE;

	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public static readonly BBMNDEOMHKI GAAOFJMDDPK;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public bool JNICLPBNKND
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x709D070", Offset = "0x709C270", VA = "0x18709D070")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x1933040", Offset = "0x1932240", VA = "0x181933040")]
	public LHBFBBLAEKP(BBMNDEOMHKI AHCKEJBIEOL, PNLFGDJJHEM BGGNGAFAJPC, BBMNDEOMHKI OGLIGIHINNF, PNLFGDJJHEM PECPHCNEGLL, BBMNDEOMHKI FEDCINIAFAP, PNLFGDJJHEM EILLKADAKCH, BDFNEMLKGLD MMJLOMAKCGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x844710", Offset = "0x843910", VA = "0x180844710")]
	private static bool HNFCHIOIAEH()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x841A70", Offset = "0x840C70", VA = "0x180841A70")]
	private static void IEICAIIPFGD(string CEOMJLPEFPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x844710", Offset = "0x843910", VA = "0x180844710")]
	private static bool MPHGPAHMHLF()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x841A70", Offset = "0x840C70", VA = "0x180841A70")]
	private static void BOFHIBJEIHC(string CEOMJLPEFPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x844710", Offset = "0x843910", VA = "0x180844710")]
	private static bool OEDBPDHJILM()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x841A70", Offset = "0x840C70", VA = "0x180841A70")]
	private static void EKLIIMFOANO(string CEOMJLPEFPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x841A70", Offset = "0x840C70", VA = "0x180841A70")]
	private static void HAPAPLBJCCG(Exception ODBCLHKGDHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x709D2B0", Offset = "0x709C4B0", VA = "0x18709D2B0")]
	private static LHBFBBLAEKP GICNFEGBEKA()
	{
		return default(LHBFBBLAEKP);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x844770", Offset = "0x843970", VA = "0x180844770")]
	private static bool LOMLHMDCOMD()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x709D000", Offset = "0x709C200", VA = "0x18709D000")]
	public void DJGNNKLAGEN(object CEOMJLPEFPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x709D470", Offset = "0x709C670", VA = "0x18709D470")]
	public void OGMMPBDDHNK(object CEOMJLPEFPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x709D4E0", Offset = "0x709C6E0", VA = "0x18709D4E0")]
	public void PCFFBPOOGPA(Exception ODBCLHKGDHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x3342790", Offset = "0x3341990", VA = "0x183342790")]
	public void OGMMPBDDHNK<T>(T ANPLPNKHBJM, PNMIMODDLFE<T> CEOMJLPEFPB) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x3342690", Offset = "0x3341890", VA = "0x183342690")]
	public void DJGNNKLAGEN<T>(in T ANPLPNKHBJM, ICCMEODNNAF<T> CEOMJLPEFPB) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x709D3F0", Offset = "0x709C5F0", VA = "0x18709D3F0")]
	public bool LMKFLCDMFNO(bool FDGKKJMBOEA, string CEOMJLPEFPB)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public static class ECCJGEBPMKM
{
	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x322E8F0", Offset = "0x322DAF0", VA = "0x18322E8F0")]
	public static IEnumerable<T> PMCAAJEHLAN<T>() where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x9A16E0", Offset = "0x9A08E0", VA = "0x1809A16E0")]
	public static T[] MIMFEGOOBAA<T>(params T[] NAFCJNMGHAF) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x9A16E0", Offset = "0x9A08E0", VA = "0x1809A16E0")]
	public static IEnumerable<T> BKKFEIMBBBK<T>(params T[] NAFCJNMGHAF) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x268FC40", Offset = "0x268EE40", VA = "0x18268FC40")]
	public static HashSet<T> JDKICNJNBCP<T>(params T[] NAFCJNMGHAF) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x33BD600", Offset = "0x33BC800", VA = "0x1833BD600")]
	public static KeyValuePair<TKey, TValue> PAOBAAPKHGI<TKey, TValue>(in TKey PPNIGBBPGOI, in TValue ACKOJNNBEBO) where TKey : notnull where TValue : notnull
	{
		return default(KeyValuePair<TKey, TValue>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x268FC40", Offset = "0x268EE40", VA = "0x18268FC40")]
	public static List<T> CHGKONPLCBI<T>(IEnumerable<T> CAGPAHEIADO) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
[AttributeUsage(AttributeTargets.All)]
public sealed class EPKOOFOCCHI : Attribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public readonly string NICKJKBMFBM;

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x8F3350", Offset = "0x8F2550", VA = "0x1808F3350")]
	public EPKOOFOCCHI(string JJGLHLPJGFK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public static class AIEEJMPFEED
{
	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x2AE65E0", Offset = "0x2AE57E0", VA = "0x182AE65E0")]
	public static LKOOFNGFLIN BDFGEPJOIKK<T>()
	{
		return default(LKOOFNGFLIN);
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x2AE67F0", Offset = "0x2AE59F0", VA = "0x182AE67F0")]
	public static LKOOFNGFLIN KHLBBJNKOHL<T>([CallerMemberName] string PCKMHBLNCII = "") where T : notnull
	{
		return default(LKOOFNGFLIN);
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x2AE6550", Offset = "0x2AE5750", VA = "0x182AE6550")]
	public static LKOOFNGFLIN BDFGEPJOIKK<T>(this T AGKOCALGANA) where T : notnull
	{
		return default(LKOOFNGFLIN);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x2AE6670", Offset = "0x2AE5870", VA = "0x182AE6670")]
	public static LKOOFNGFLIN ENKKLIEDGDK<T>(this T AGKOCALGANA, [CallerMemberName] string PCKMHBLNCII = "") where T : notnull
	{
		return default(LKOOFNGFLIN);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x2AE6880", Offset = "0x2AE5A80", VA = "0x182AE6880")]
	public static LKOOFNGFLIN KHLBBJNKOHL<T>(this T DCMHODHEGEC, [CallerMemberName] string PCKMHBLNCII = "") where T : notnull
	{
		return default(LKOOFNGFLIN);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x709A880", Offset = "0x7099A80", VA = "0x18709A880")]
	public static LKOOFNGFLIN KHLBBJNKOHL(string FGMHNFMCACE, [CallerMemberName] string PCKMHBLNCII = "")
	{
		return default(LKOOFNGFLIN);
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x709A7C0", Offset = "0x70999C0", VA = "0x18709A7C0")]
	public static string EBGIFGFLIGL(this object DCMHODHEGEC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
[ICLMCEBKHND]
public delegate long GBIBJMHMIDP();
[Cpp2IlInjected.Token(Token = "0x200001C")]
public delegate void NPNFOJGFFIC<T>(in T ANPLPNKHBJM);
[Cpp2IlInjected.Token(Token = "0x200001D")]
public static class HHMNNOJNIGK
{
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	private static BNOIADHJNMG PPOIDAGJEOI;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public static BNOIADHJNMG HCNPKCFAIBF
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x709BB00", Offset = "0x709AD00", VA = "0x18709BB00")]
		get
		{
			return default(BNOIADHJNMG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public static LHBFBBLAEKP HDAOJPMLHFH
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x709C020", Offset = "0x709B220", VA = "0x18709C020")]
		get
		{
			return default(LHBFBBLAEKP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public static KOAHJPMAMBA CFHAHLALAHN
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x709BEE0", Offset = "0x709B0E0", VA = "0x18709BEE0")]
		get
		{
			return default(KOAHJPMAMBA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x709BD80", Offset = "0x709AF80", VA = "0x18709BD80")]
	public static void HOGNHDPJMMD(in BNOIADHJNMG LNLKNAMFEED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x709BB60", Offset = "0x709AD60", VA = "0x18709BB60")]
	public static void DJGNNKLAGEN(string CEOMJLPEFPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x709C080", Offset = "0x709B280", VA = "0x18709C080")]
	public static void OGMMPBDDHNK(string CEOMJLPEFPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x286D920", Offset = "0x286CB20", VA = "0x18286D920")]
	public static void OGMMPBDDHNK<T>(T ANPLPNKHBJM, PNMIMODDLFE<T> CEOMJLPEFPB) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x709C1A0", Offset = "0x709B3A0", VA = "0x18709C1A0")]
	public static void PCFFBPOOGPA(Exception ODBCLHKGDHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x709BC10", Offset = "0x709AE10", VA = "0x18709BC10")]
	public static string EBGIFGFLIGL(object BHEOHCEHIBM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x709C130", Offset = "0x709B330", VA = "0x18709C130")]
	public static long OLAPGBFBBBH()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x709BF40", Offset = "0x709B140", VA = "0x18709BF40")]
	public static bool LMKFLCDMFNO(bool FDGKKJMBOEA, string CEOMJLPEFPB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x709BC90", Offset = "0x709AE90", VA = "0x18709BC90")]
	public static double EKHCJNOCMMB()
	{
		return default(double);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class JFDFMAIBEOF : BLICLPBACAC
{
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	public static readonly BLICLPBACAC EBEPLDELFOG;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public DateTime IECNEGFGECD
	{
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x709C2D0", Offset = "0x709B4D0", VA = "0x18709C2D0", Slot = "4")]
		get
		{
			return default(DateTime);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x84C440", Offset = "0x84B640", VA = "0x18084C440")]
	public JFDFMAIBEOF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
[AttributeUsage(AttributeTargets.Interface | AttributeTargets.Delegate)]
public class ICLMCEBKHND : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x841A80", Offset = "0x840C80", VA = "0x180841A80")]
	public ICLMCEBKHND()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public delegate TResult HCJBICPEBFB<T, out TResult>(in T ANPLPNKHBJM);
[Cpp2IlInjected.Token(Token = "0x2000021")]
public delegate TResult KKIJJMKAJCA<T1, T2, out TResult>(in T1 LBPGCLOOOKE, in T2 IOBLOMLNBDO);
[Cpp2IlInjected.Token(Token = "0x2000022")]
public sealed class BNCPFMDBEJN : IAIJJIFLDDJ, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public static readonly TimeSpan LJHAJLGOJOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	private readonly System.Timers.Timer FIIEBNCLKIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	private TimeSpan HJLEAHGMGHL;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public TimeSpan DBAGEHMIJNI
	{
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x8D7C00", Offset = "0x8D6E00", VA = "0x1808D7C00", Slot = "4")]
		get
		{
			return default(TimeSpan);
		}
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x709A9D0", Offset = "0x7099BD0", VA = "0x18709A9D0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public Action? BGLAJCBIDKA
	{
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x8D4AB0", Offset = "0x8D3CB0", VA = "0x1808D4AB0", Slot = "11")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x8F7D20", Offset = "0x8F6F20", VA = "0x1808F7D20", Slot = "6")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x709ACB0", Offset = "0x7099EB0", VA = "0x18709ACB0")]
	[Preserve]
	public BNCPFMDBEJN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x709AD20", Offset = "0x7099F20", VA = "0x18709AD20")]
	public BNCPFMDBEJN(TimeSpan HJLEAHGMGHL, [Optional] Action? OJBLAIGHMDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x709ABE0", Offset = "0x7099DE0", VA = "0x18709ABE0", Slot = "7")]
	public void PBELNPMEPJD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x709ABA0", Offset = "0x7099DA0", VA = "0x18709ABA0", Slot = "8")]
	public void MIAKLFHAKNJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x709A900", Offset = "0x7099B00", VA = "0x18709A900", Slot = "9")]
	public void BFAKIAFHDEO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x15BB090", Offset = "0x15BA290", VA = "0x1815BB090")]
	private void BDLOCOHBBKI(object AGKOCALGANA, ElapsedEventArgs BLPAFIMLKLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x709AB20", Offset = "0x7099D20", VA = "0x18709AB20")]
	private static void LDLFDBKKAJA(ref TimeSpan LGJKKBDIEEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x709A930", Offset = "0x7099B30", VA = "0x18709A930", Slot = "10")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
[AttributeUsage(AttributeTargets.Class)]
public class HMFLENOJLJJ : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x841A80", Offset = "0x840C80", VA = "0x180841A80")]
	public HMFLENOJLJJ()
	{
	}
}
namespace RecRoom.NoEngine.Common
{
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public class PreserveAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x841A80", Offset = "0x840C80", VA = "0x180841A80")]
		public PreserveAttribute()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
[AttributeUsage(AttributeTargets.Method | AttributeTargets.Parameter)]
public class CMFCANKAKKJ : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x841A80", Offset = "0x840C80", VA = "0x180841A80")]
	public CMFCANKAKKJ(string DGBAJFDLILP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public interface BLICLPBACAC
{
	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	DateTime IECNEGFGECD
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[StructLayout((LayoutKind)2)]
[Cpp2IlInjected.Token(Token = "0x2000027")]
[DebuggerDisplay("U32: {U32}, I32: {I32}, F32: {F32}, U16_0: {U16_0}, I16_1: {I16_1}, Char_0: '{Char_0}', Char_1: '{Char_1}', U8_0: {U8_0}, U8_1: {U8_1}, U8_2: {U8_2}, U8_3: {U8_3}, Bool_0: {Bool_0}, Bool_1: {Bool_1}, Bool_2: {Bool_2}, Bool_3: {Bool_3}")]
public struct AHFJHCNGBPI : IEquatable<AHFJHCNGBPI>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	public uint PKJGBFFADMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	public int KPFDPENCJPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	public float INMHDJHLMAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	public ushort CEDMNAILJNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	public ushort GIAPDMPCAGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	public short PPHKGMFDFNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	public short CHNJJAIHOFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public char KELAINPGKOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public char KKPDOCKEIJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public byte CMDLMJINFJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	public byte DMAAEKBENGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	public byte FFEHOCAPMKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	public byte KBLMKNIIEAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	public bool LAFJLGBFHFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	public bool HOBIBGAJIHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	public bool GMAGHHMBLOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	public bool HJGFJMIBELA;

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0xBC5BE0", Offset = "0xBC4DE0", VA = "0x180BC5BE0")]
	public static AHFJHCNGBPI HLKEJFGDFNB(uint GIAHINFMMBE)
	{
		return default(AHFJHCNGBPI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0xBC5BE0", Offset = "0xBC4DE0", VA = "0x180BC5BE0")]
	public static AHFJHCNGBPI DBHGMBKMHKH(int MMKALEFDCNE)
	{
		return default(AHFJHCNGBPI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x7099830", Offset = "0x7098A30", VA = "0x187099830")]
	public static AHFJHCNGBPI KNOONGFGKBP(float PDOOBLCNIKH)
	{
		return default(AHFJHCNGBPI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x7099780", Offset = "0x7098980", VA = "0x187099780")]
	public static AHFJHCNGBPI LFAAEAJEDAA(byte CFFHINLNIGC, byte EGHBKCJEMNM, byte DDCNLFNFEBI, byte DFINJFBJNGH)
	{
		return default(AHFJHCNGBPI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x7099780", Offset = "0x7098980", VA = "0x187099780")]
	public static AHFJHCNGBPI CHLDKKPAACM(bool MHLBGFIIIPJ, bool LGHOINIDOLI, bool NIHEDAKMADJ, bool NLBKGIFIBOK)
	{
		return default(AHFJHCNGBPI);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x56BBAF0", Offset = "0x56BACF0", VA = "0x1856BBAF0")]
	public static bool JGKKLLGINAK(AHFJHCNGBPI JFHIJPMPOBA, AHFJHCNGBPI LPNFMADJDAF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0xBC4020", Offset = "0xBC3220", VA = "0x180BC4020", Slot = "4")]
	public bool Equals(AHFJHCNGBPI HPOECFLNEOJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x70997A0", Offset = "0x70989A0", VA = "0x1870997A0", Slot = "0")]
	public override bool Equals(object BHEOHCEHIBM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x2314B50", Offset = "0x2313D50", VA = "0x182314B50", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x7099840", Offset = "0x7098A40", VA = "0x187099840", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
[AMLFBPMMCGO("Now that `#nullable enable` is supported in our project, we should probably prefer that. The whole point of this type was to force checking before getting a value.`#nullable enable` can also force checking.")]
public readonly struct NFEJPMDMHAA<T> : IEquatable<NFEJPMDMHAA<T>> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	public readonly T IHPKAGOHFMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	public readonly bool HIADHBJBMGJ;

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public bool JOLJJBHMBCM
	{
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x2F61410", Offset = "0x2F60610", VA = "0x182F61410")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x2F619A0", Offset = "0x2F60BA0", VA = "0x182F619A0")]
	public NFEJPMDMHAA(in T ACKOJNNBEBO, bool DEMFCAKJAON)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x2F60F10", Offset = "0x2F60110", VA = "0x182F60F10")]
	public static bool JGKKLLGINAK([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7E9DF0", Offset = "0x7E91F0")] in NFEJPMDMHAA<T> NGKKOMJDENH, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7E9E60", Offset = "0x7E9260")] in NFEJPMDMHAA<T> KEJINCBACKA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x2F60350", Offset = "0x2F5F550", VA = "0x182F60350", Slot = "4")]
	public bool Equals([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7E9ED0", Offset = "0x7E92D0")] NFEJPMDMHAA<T> HPOECFLNEOJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x2F60250", Offset = "0x2F5F450", VA = "0x182F60250", Slot = "0")]
	public override bool Equals(object HPOECFLNEOJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x2F60C20", Offset = "0x2F5FE20", VA = "0x182F60C20", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x2F61850", Offset = "0x2F60A50", VA = "0x182F61850", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public static class GADEEHMDMCJ
{
	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x2AFE9E0", Offset = "0x2AFDBE0", VA = "0x182AFE9E0")]
	public static NFEJPMDMHAA<T> AOFGHMDOGDB<T>(in T ACKOJNNBEBO) where T : notnull
	{
		return default(NFEJPMDMHAA<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x2AFEB00", Offset = "0x2AFDD00", VA = "0x182AFEB00")]
	public static NFEJPMDMHAA<T?> FGEMDMBCDHM<T>()
	{
		return default(NFEJPMDMHAA<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x2AFEC00", Offset = "0x2AFDE00", VA = "0x182AFEC00")]
	public static bool PAKAJHADCAC<T>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7E9F30", Offset = "0x7E9330")] this in NFEJPMDMHAA<T> OIEJCLNIMPC, [OPJMDPNHGGA(true)] out T ACKOJNNBEBO) where T : notnull
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public interface MFKMHCNJACH<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool DMPMLAKNGKG(in T HPOECFLNEOJ);
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public readonly struct KOAHJPMAMBA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	public readonly MIALGJBKMLJ KADFHICNDEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	public readonly MKOEOIJABGB CJGKOAIBFCP;

	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public static readonly MIALGJBKMLJ EFMGJFJPLCJ;

	[Cpp2IlInjected.Token(Token = "0x400006A")]
	public static readonly MKOEOIJABGB BAHLBNHGHFF;

	[Cpp2IlInjected.Token(Token = "0x400006B")]
	public static readonly KOAHJPMAMBA GKMFIPLKNAE;

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public bool JNICLPBNKND
	{
		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x709CD10", Offset = "0x709BF10", VA = "0x18709CD10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0xA5F7B0", Offset = "0xA5E9B0", VA = "0x180A5F7B0")]
	public KOAHJPMAMBA(MIALGJBKMLJ BPHEGIEKLPO, MKOEOIJABGB GFDNFAJIOFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x841A70", Offset = "0x840C70", VA = "0x180841A70")]
	private static void JMKKNJPNELG(string PCKMHBLNCII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x841A70", Offset = "0x840C70", VA = "0x180841A70")]
	private static void PDKLLHGOFKB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x709CDE0", Offset = "0x709BFE0", VA = "0x18709CDE0")]
	private static KOAHJPMAMBA GICNFEGBEKA()
	{
		return default(KOAHJPMAMBA);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public static class MIOLDDIPHOI
{
	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x38B43B0", Offset = "0x38B35B0", VA = "0x1838B43B0")]
	public static bool DMPMLAKNGKG<T, U>(in T DCMHODHEGEC, in U BHEOHCEHIBM) where T : notnull, MFKMHCNJACH<T> where U : notnull
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public sealed class OLFNOFLLMPC<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private static readonly EqualityComparer<T> COHMJOIFJDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	public T IHPKAGOHFMA;

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x3E3F840", Offset = "0x3E3EA40", VA = "0x183E3F840")]
	public OLFNOFLLMPC(in T ACKOJNNBEBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x3E3F160", Offset = "0x3E3E360", VA = "0x183E3F160", Slot = "0")]
	public override bool Equals(object BHEOHCEHIBM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x3E3F490", Offset = "0x3E3E690", VA = "0x183E3F490", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x3E3F6D0", Offset = "0x3E3E8D0", VA = "0x183E3F6D0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public static class JNCEEIFINFB
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public static long NCIGFKEGMMD
	{
		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x709C780", Offset = "0x709B980", VA = "0x18709C780")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public static long GEHPIJJAPEK
	{
		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x709C640", Offset = "0x709B840", VA = "0x18709C640")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public static double NIHFNHEHPII
	{
		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x709C6A0", Offset = "0x709B8A0", VA = "0x18709C6A0")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public static double MPDNPEMJMNM
	{
		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x709C9A0", Offset = "0x709BBA0", VA = "0x18709C9A0")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public static double LCEFBOIJDOL
	{
		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x709C530", Offset = "0x709B730", VA = "0x18709C530")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public static double KOBDEPABEBD
	{
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x709C7E0", Offset = "0x709B9E0", VA = "0x18709C7E0")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x709C380", Offset = "0x709B580", VA = "0x18709C380")]
	public static double ADCNEBFMFGC(long HOEEAPEHNOP)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x709C590", Offset = "0x709B790", VA = "0x18709C590")]
	public static double IFEICGAKDOH(long HOEEAPEHNOP)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x709C8F0", Offset = "0x709BAF0", VA = "0x18709C8F0")]
	public static double NKEDJJMOOCF(double GAGOOHKAJBF)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x709C840", Offset = "0x709BA40", VA = "0x18709C840")]
	public static long NDFADBMCGCI(long KFAABCMFLLA)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x709C700", Offset = "0x709B900", VA = "0x18709C700")]
	public static long JGGHIDJEFEH(long APPKKFNODMC, long BPKPENBEOAG)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x709C430", Offset = "0x709B630", VA = "0x18709C430")]
	public static double AJCFKMODKBO(long APPKKFNODMC, long BPKPENBEOAG)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x709C710", Offset = "0x709B910", VA = "0x18709C710")]
	public static double JJNDFBDAGAJ(long APPKKFNODMC, long BPKPENBEOAG)
	{
		return default(double);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
[ICLMCEBKHND]
public delegate void PNLFGDJJHEM(string CEOMJLPEFPB);
[Cpp2IlInjected.Token(Token = "0x2000030")]
[ICLMCEBKHND]
public delegate string MBCJLNPMGJB(object BHEOHCEHIBM);
[Cpp2IlInjected.Token(Token = "0x2000031")]
[ICLMCEBKHND]
public delegate void MKOEOIJABGB();
[Cpp2IlInjected.Token(Token = "0x2000032")]
public delegate object ICCMEODNNAF<T>(in T AHLCEBMCJMF);
[Cpp2IlInjected.Token(Token = "0x2000033")]
public delegate object HJMICIAMIGF();
[Cpp2IlInjected.Token(Token = "0x2000034")]
[ICLMCEBKHND]
public delegate string LOEDOAAOELI(string MKPBIBAIDNM, string? BMMBLDABIAH, bool BDNFFALPGBH);
[Cpp2IlInjected.Token(Token = "0x2000035")]
[ICLMCEBKHND]
public delegate bool BBMNDEOMHKI();
[Cpp2IlInjected.Token(Token = "0x2000036")]
public delegate object PNMIMODDLFE<T>(T AHLCEBMCJMF);
[Cpp2IlInjected.Token(Token = "0x2000037")]
[ICLMCEBKHND]
public delegate void MIALGJBKMLJ(string PCKMHBLNCII);
[Cpp2IlInjected.Token(Token = "0x2000038")]
[ICLMCEBKHND]
public delegate void BDFNEMLKGLD(Exception ODBCLHKGDHB);
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
