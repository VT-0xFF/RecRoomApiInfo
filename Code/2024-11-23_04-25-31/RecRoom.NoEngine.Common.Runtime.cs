using System;
using System.Buffers;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
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
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class EmbeddedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x8D6960", Offset = "0x8D5360", VA = "0x1808D6960")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[CompilerGenerated]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter, AllowMultiple = false, Inherited = false)]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x6EE5CD0", Offset = "0x6EE46D0", VA = "0x186EE5CD0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x8D7890", Offset = "0x8D6290", VA = "0x1808D7890")]
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
		[Cpp2IlInjected.Address(RVA = "0x8D78D0", Offset = "0x8D62D0", VA = "0x1808D78D0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class IFCDAOOCHCL
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x6EE14C0", Offset = "0x6EDFEC0", VA = "0x186EE14C0")]
	public static string FEKDNLKELGI(this Encoding MIJJPFCFOOA, [In] ReadOnlySequence<byte> FFGGPAIGPAA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x2F22F60", Offset = "0x2F21960", VA = "0x182F22F60")]
	private static void DCEFKGCKJOM<T>(this ReadOnlySequence<T> BGDACOFHFBK, [Out] ReadOnlySpan<T> MBEPDBKPKKH, [Out] SequencePosition CFANALLNGDN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
[AttributeUsage(AttributeTargets.Method | AttributeTargets.Property, AllowMultiple = true, Inherited = false)]
public sealed class OKBGOJFPIIE : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x6EE5D50", Offset = "0x6EE4750", VA = "0x186EE5D50")]
	public OKBGOJFPIIE(bool OBFHPBKLECO, string FEILINGEOHL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class JDDEMAJDHFN
{
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface KPNNIPMAFBL
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool FFBHBGLPGOE
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void KPFOKGJPEPJ(string PNABAFEIDND, double PKCLPFEIPFH, [Optional] string? JFBIIGIMAEB);
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public class MDHIGFDJFCM<TResult> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public delegate Task<TResult> LNDEMNKEOLK(CancellationToken PPLDCJFFMEP);

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CompilerGenerated]
	private struct OICJMIFMBIG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public AsyncTaskMethodBuilder<TResult> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public MDHIGFDJFCM<TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public LNDEMNKEOLK taskGenerator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private TaskCompletionSource<TResult> <tcs>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private CancellationTokenSource <runningCancellationTokenSource>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private TaskAwaiter<TResult> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x4A5FA80", Offset = "0x4A5E480", VA = "0x184A5FA80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x4A60BC0", Offset = "0x4A5F5C0", VA = "0x184A60BC0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly CancellationTokenSource KPJNJINNMPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private CancellationTokenSource? NHCDEJHFKAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private TaskCompletionSource<TResult>? HBIPABEIIHG;

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x4899970", Offset = "0x4898370", VA = "0x184899970")]
	[AsyncStateMachine(typeof(MDHIGFDJFCM<>.OICJMIFMBIG))]
	public Task<TResult> GMCDCBPGCKE(LNDEMNKEOLK JBEABAHCPJN, [Optional] CancellationToken PPLDCJFFMEP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x4899900", Offset = "0x4898300", VA = "0x184899900", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x4899AC0", Offset = "0x48984C0", VA = "0x184899AC0")]
	public MDHIGFDJFCM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public sealed class EPGEKMGKHMI<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private static readonly EqualityComparer<T> ALAPABCKGCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public T IPHIEALFCML;

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x3BAB2E0", Offset = "0x3BA9CE0", VA = "0x183BAB2E0")]
	public EPGEKMGKHMI([In] T PKCLPFEIPFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x3BAA5A0", Offset = "0x3BA8FA0", VA = "0x183BAA5A0", Slot = "0")]
	public override bool Equals(object BBNKFKDCOLP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x3BAAC20", Offset = "0x3BA9620", VA = "0x183BAAC20", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x3BAADB0", Offset = "0x3BA97B0", VA = "0x183BAADB0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public sealed class IKJKGINLDNF
{
	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x2CE9660", Offset = "0x2CE8060", VA = "0x182CE9660")]
	public static EPGEKMGKHMI<T> AELHPDENENI<T>([In] T PKCLPFEIPFH) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class DJJDDKFIINJ
{
	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x6EDC770", Offset = "0x6EDB170", VA = "0x186EDC770")]
	public static void ENHJAIFKGKN(this CancellationTokenSource KPJNJINNMPF, bool PNDLNKDEOAL = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
[AttributeUsage(AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false)]
public class IGGIBFFOGDM : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x8D6960", Offset = "0x8D5360", VA = "0x1808D6960")]
	public IGGIBFFOGDM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
[AttributeUsage(AttributeTargets.Method | AttributeTargets.Parameter, AllowMultiple = false)]
public class NDHJFHFMOBL : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x8D6960", Offset = "0x8D5360", VA = "0x1808D6960")]
	public NDHJFHFMOBL(string BNEKKOOIIIG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public static class IIEOKGFJCOD
{
	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x2F27BE0", Offset = "0x2F265E0", VA = "0x182F27BE0")]
	public static AAMDACFJKLP AMKINMEHPCP<T>()
	{
		return default(AAMDACFJKLP);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x2F27E80", Offset = "0x2F26880", VA = "0x182F27E80")]
	public static AAMDACFJKLP GMHPJPEEBMF<T>([CallerMemberName] string JHJFHDOAMLG = "") where T : notnull
	{
		return default(AAMDACFJKLP);
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x2F27C60", Offset = "0x2F26660", VA = "0x182F27C60")]
	public static AAMDACFJKLP AMKINMEHPCP<T>(this T HBABIBCNPCH) where T : notnull
	{
		return default(AAMDACFJKLP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x2F27CE0", Offset = "0x2F266E0", VA = "0x182F27CE0")]
	public static AAMDACFJKLP FBGLAEKAJNA<T>(this T HBABIBCNPCH, [CallerMemberName] string JHJFHDOAMLG = "") where T : notnull
	{
		return default(AAMDACFJKLP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x2F27F20", Offset = "0x2F26920", VA = "0x182F27F20")]
	public static AAMDACFJKLP GMHPJPEEBMF<T>(this T PCBICLOONMH, [CallerMemberName] string JHJFHDOAMLG = "") where T : notnull
	{
		return default(AAMDACFJKLP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x6EE2EC0", Offset = "0x6EE18C0", VA = "0x186EE2EC0")]
	public static AAMDACFJKLP GMHPJPEEBMF(string PLMEAECKHPE, [CallerMemberName] string JHJFHDOAMLG = "")
	{
		return default(AAMDACFJKLP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x6EE2F40", Offset = "0x6EE1940", VA = "0x186EE2F40")]
	public static string LOKMGHLDCKJ(this object PCBICLOONMH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public delegate bool MDOAPCHBOHI();
[Cpp2IlInjected.Token(Token = "0x2000014")]
[IGGIBFFOGDM]
public delegate long NIHFFCGGBHK();
[Cpp2IlInjected.Token(Token = "0x2000015")]
public static class NJHJAKCMBPH
{
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private static ENCNBHNBCHH FMIEFBHAACK;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static ENCNBHNBCHH PGGFBFNPGOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x6EE47B0", Offset = "0x6EE31B0", VA = "0x186EE47B0")]
		get
		{
			return default(ENCNBHNBCHH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public static BPBKMBJMGOF PKMOLCCJFBG
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x6EE4AC0", Offset = "0x6EE34C0", VA = "0x186EE4AC0")]
		get
		{
			return default(BPBKMBJMGOF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public static AKEIJILMEEL JOLAAGOBGPL
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x6EE4B80", Offset = "0x6EE3580", VA = "0x186EE4B80")]
		get
		{
			return default(AKEIJILMEEL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public static bool JEOCPPPMHMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x6EE4E80", Offset = "0x6EE3880", VA = "0x186EE4E80")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x6EE4BD0", Offset = "0x6EE35D0", VA = "0x186EE4BD0")]
	public static void KKKPBMJOFKI([In] ENCNBHNBCHH HALPINJCDPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x6EE4EF0", Offset = "0x6EE38F0", VA = "0x186EE4EF0")]
	public static void PMAPEFGPDFK(string FCMDIEEAPHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x6EE4970", Offset = "0x6EE3370", VA = "0x186EE4970")]
	public static void DKAOGHLAPOM(string FCMDIEEAPHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x304EBE0", Offset = "0x304D5E0", VA = "0x18304EBE0")]
	public static void DKAOGHLAPOM<T>(T BCHPPGPOGNC, PMINAEHANDA<T> FCMDIEEAPHD) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x6EE4800", Offset = "0x6EE3200", VA = "0x186EE4800")]
	public static void APNNNHFDEBM(Exception AENFONOHPNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x6EE4A40", Offset = "0x6EE3440", VA = "0x186EE4A40")]
	public static void GOOKMIOIMDC(string JHJFHDOAMLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x6EE4FC0", Offset = "0x6EE39C0", VA = "0x186EE4FC0")]
	public static void PPABHHEAFLH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x6EE4D70", Offset = "0x6EE3770", VA = "0x186EE4D70")]
	public static string LOKMGHLDCKJ(object BBNKFKDCOLP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x6EE4B10", Offset = "0x6EE3510", VA = "0x186EE4B10")]
	public static long HILIAHLAJGI()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x6EE4DE0", Offset = "0x6EE37E0", VA = "0x186EE4DE0")]
	public static bool OEBFLOGGGDC(bool KPFOFBGGJLH, string FCMDIEEAPHD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x6EE48A0", Offset = "0x6EE32A0", VA = "0x186EE48A0")]
	public static double CKNHNOMMHBL()
	{
		return default(double);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public readonly struct ENCNBHNBCHH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public readonly BPBKMBJMGOF PKMOLCCJFBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public readonly AKEIJILMEEL JOLAAGOBGPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public readonly NNKAPOHDIJF NILOCLGJPOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	public readonly NIHFFCGGBHK EKDBNECMPBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public readonly MDHPEBLHBFO GFMAIKOBMPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public readonly MDOAPCHBOHI PGMCPAPGOBJ;

	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public static readonly NNKAPOHDIJF DKMHLIKCLBI;

	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public static readonly NIHFFCGGBHK OBKNBJODDHL;

	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public static readonly MDHPEBLHBFO IFDEIAICCJN;

	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public static readonly MDOAPCHBOHI GPPPMDDDMJL;

	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public static readonly ENCNBHNBCHH BDDJBNJILLK;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public bool EFLKLBKLPDG
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x6EDDC70", Offset = "0x6EDC670", VA = "0x186EDDC70")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x6EDE600", Offset = "0x6EDD000", VA = "0x186EDE600")]
	public ENCNBHNBCHH([In] BPBKMBJMGOF MDOODMOJKBN, [In] AKEIJILMEEL CNIMMKAPECF, NNKAPOHDIJF DDLNFIHAMCP, NIHFFCGGBHK MLHCGGLDJFN, MDHPEBLHBFO EJLNAJOEOBF, MDOAPCHBOHI GOGBHFOJJML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x6EDDF00", Offset = "0x6EDC900", VA = "0x186EDDF00")]
	private static string OBFLBLADKND(object BBNKFKDCOLP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x8ACA60", Offset = "0x8AB460", VA = "0x1808ACA60")]
	private static long GDAFELNDOAC()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0xA09F00", Offset = "0xA08900", VA = "0x180A09F00")]
	private static string AICCHKMDPEN(string JBIHOCOCJKD, string? BLBINOCFPJK, bool NHKLOAEFNEJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x8F5BB0", Offset = "0x8F45B0", VA = "0x1808F5BB0")]
	private static bool AKOLABGMMBF()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x6EDDE00", Offset = "0x6EDC800", VA = "0x186EDDE00")]
	private static ENCNBHNBCHH CDLBKGPOFII()
	{
		return default(ENCNBHNBCHH);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public interface KNCNMGIPFCE
{
	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(Slot = "0")]
	GJOOGINBAMA IFHANBOIBIK();
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface GJOOGINBAMA : INotifyCompletion
{
	[Cpp2IlInjected.Token(Token = "0x17000007")]
	bool OEMBJOBGAJG
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void JGNMEKLNHNN();
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public interface OKIKCDAEAAO<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool PGEDFKHCPLD([In] T GDOGPMPJPOO);
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public delegate void GGCGNHLFHOM<T>([In] T BCHPPGPOGNC);
[Cpp2IlInjected.Token(Token = "0x200001B")]
public readonly struct DMDFCNAGDMN<T> : IEquatable<DMDFCNAGDMN<T>>, OKIKCDAEAAO<DMDFCNAGDMN<T>> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public readonly T IPHIEALFCML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public readonly int BPKEJBPHLFM;

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x22AEB30", Offset = "0x22AD530", VA = "0x1822AEB30")]
	public DMDFCNAGDMN([In] T PKCLPFEIPFH, int GCBONJOGHCD)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x5C89910", Offset = "0x5C88310", VA = "0x185C89910")]
	public static bool EKIKFCPHGPG([In] DMDFCNAGDMN<T> FCKNABCAAPB, [In] DMDFCNAGDMN<T> JGIIKLPFBFG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x5284880", Offset = "0x5283280", VA = "0x185284880", Slot = "4")]
	public bool Equals(DMDFCNAGDMN<T> GDOGPMPJPOO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x4A53710", Offset = "0x4A52110", VA = "0x184A53710", Slot = "0")]
	public override bool Equals(object GDOGPMPJPOO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x5C8AC20", Offset = "0x5C89620", VA = "0x185C8AC20")]
	public bool PGEDFKHCPLD([In] DMDFCNAGDMN<T> GDOGPMPJPOO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x5C89DE0", Offset = "0x5C887E0", VA = "0x185C89DE0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x5C8B120", Offset = "0x5C89B20", VA = "0x185C8B120", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x5C8A720", Offset = "0x5C89120", VA = "0x185C8A720")]
	public void KGDOKCMJMKM([Out] T PKCLPFEIPFH, [Out] int GCBONJOGHCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x5C8A840", Offset = "0x5C89240", VA = "0x185C8A840")]
	public (T, int) NJHGPHLJDBE()
	{
		return default((T, int));
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x5C8A7F0", Offset = "0x5C891F0", VA = "0x185C8A7F0", Slot = "5")]
	private bool LOKJMAFDBLJ([In] DMDFCNAGDMN<T> GDOGPMPJPOO)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public static class DEPIJKJJGMP
{
	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x2D1E5B0", Offset = "0x2D1CFB0", VA = "0x182D1E5B0")]
	public static DMDFCNAGDMN<T> AELHPDENENI<T>([In] T PKCLPFEIPFH, int GCBONJOGHCD) where T : notnull
	{
		return default(DMDFCNAGDMN<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public static class NJFEHPPNOIL
{
	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x304DE30", Offset = "0x304C830", VA = "0x18304DE30")]
	public static bool PGEDFKHCPLD<T, U>([In] T PCBICLOONMH, [In] U BBNKFKDCOLP) where T : notnull, OKIKCDAEAAO<T> where U : notnull
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public delegate TResult EEAFKEBEEFO<T, out TResult>([In] T BCHPPGPOGNC);
[Cpp2IlInjected.Token(Token = "0x200001F")]
public interface CNHCNFCGJGK : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000008")]
	TimeSpan LLPDJPEEEKA
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	Action? ONGNCANIFPC
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(Slot = "2")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void PMHKFLKJGHI();

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void DKHJOFINOJA();

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void OJLNFIHNJLA();
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public readonly struct BPBKMBJMGOF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public readonly LCPLECODMNH CEMJDIFFHKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public readonly ABMMNOAANGI JDLELLALGHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public readonly LCPLECODMNH LPALKIHIHJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public readonly ABMMNOAANGI EKEABFAHGNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public readonly LCPLECODMNH JFFCDBFCDAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public readonly ABMMNOAANGI DJGJNDDENKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public readonly KMLPMKJPNBK CJDAOFHLKGA;

	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public static readonly LCPLECODMNH EKBNGECDMIF;

	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public static readonly ABMMNOAANGI IJALMLLDKDN;

	[Cpp2IlInjected.Token(Token = "0x400002B")]
	public static readonly LCPLECODMNH IIKNDOHKBJF;

	[Cpp2IlInjected.Token(Token = "0x400002C")]
	public static readonly ABMMNOAANGI JLKCJDFDPEN;

	[Cpp2IlInjected.Token(Token = "0x400002D")]
	public static readonly LCPLECODMNH NFNIFLONHDG;

	[Cpp2IlInjected.Token(Token = "0x400002E")]
	public static readonly ABMMNOAANGI CDJBFCBMKEI;

	[Cpp2IlInjected.Token(Token = "0x400002F")]
	public static readonly KMLPMKJPNBK CEFJDMGOCOJ;

	[Cpp2IlInjected.Token(Token = "0x4000030")]
	public static readonly BPBKMBJMGOF BDDJBNJILLK;

	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public static readonly LCPLECODMNH LPFJJPPNEPN;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public bool EFLKLBKLPDG
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x6EDB5D0", Offset = "0x6ED9FD0", VA = "0x186EDB5D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x940E00", Offset = "0x93F800", VA = "0x180940E00")]
	public BPBKMBJMGOF(LCPLECODMNH HOILEODFDAI, ABMMNOAANGI KAGBEGKKPBL, LCPLECODMNH AFHHGGPIMND, ABMMNOAANGI NOMBFBMIODD, LCPLECODMNH DDDBPNKEJNC, ABMMNOAANGI LKAMOFJMHNE, KMLPMKJPNBK MOKKHCKNJPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x8F5BB0", Offset = "0x8F45B0", VA = "0x1808F5BB0")]
	private static bool PABHMBMDAAI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x8ACA50", Offset = "0x8AB450", VA = "0x1808ACA50")]
	private static void GKMLEEIIMGG(string FCMDIEEAPHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x8F5BB0", Offset = "0x8F45B0", VA = "0x1808F5BB0")]
	private static bool BOCJIIBLIII()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x8ACA50", Offset = "0x8AB450", VA = "0x1808ACA50")]
	private static void BMDGGBGOINI(string FCMDIEEAPHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x8F5BB0", Offset = "0x8F45B0", VA = "0x1808F5BB0")]
	private static bool CLGIFANABBN()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x8ACA50", Offset = "0x8AB450", VA = "0x1808ACA50")]
	private static void AMIOFJMIALL(string FCMDIEEAPHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x8ACA50", Offset = "0x8AB450", VA = "0x1808ACA50")]
	private static void FAHBJHHNLEK(Exception AENFONOHPNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x6EDB7B0", Offset = "0x6EDA1B0", VA = "0x186EDB7B0")]
	private static BPBKMBJMGOF CDLBKGPOFII()
	{
		return default(BPBKMBJMGOF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x8C7620", Offset = "0x8C6020", VA = "0x1808C7620")]
	private static bool CENBFHEHKLL()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x6EDBB10", Offset = "0x6EDA510", VA = "0x186EDBB10")]
	public void PMAPEFGPDFK(object FCMDIEEAPHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x6EDB9D0", Offset = "0x6EDA3D0", VA = "0x186EDB9D0")]
	public void DKAOGHLAPOM(object FCMDIEEAPHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x9407F0", Offset = "0x93F1F0", VA = "0x1809407F0")]
	public void APNNNHFDEBM(Exception AENFONOHPNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x6EDB8F0", Offset = "0x6EDA2F0", VA = "0x186EDB8F0")]
	public void DKAOGHLAPOM(DDLLKCBDMBL FCMDIEEAPHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x2C87000", Offset = "0x2C85A00", VA = "0x182C87000")]
	public void DKAOGHLAPOM<T>(T BCHPPGPOGNC, PMINAEHANDA<T> FCMDIEEAPHD) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x2C870D0", Offset = "0x2C85AD0", VA = "0x182C870D0")]
	public void PMAPEFGPDFK<T>([In] T BCHPPGPOGNC, MPHKGHPPOHN<T> FCMDIEEAPHD) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x2C86D90", Offset = "0x2C85790", VA = "0x182C86D90")]
	public void DKAOGHLAPOM<T>([In] T BCHPPGPOGNC, MPHKGHPPOHN<T> FCMDIEEAPHD) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x6EDBA40", Offset = "0x6EDA440", VA = "0x186EDBA40")]
	public bool OEBFLOGGGDC(bool KPFOFBGGJLH, string FCMDIEEAPHD)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public readonly struct AAMDACFJKLP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public readonly string IPHIEALFCML;

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x957790", Offset = "0x956190", VA = "0x180957790")]
	public AAMDACFJKLP(string PKCLPFEIPFH)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x957780", Offset = "0x956180", VA = "0x180957780")]
	public static string OLKJPEKNNFN([In] AAMDACFJKLP PCBICLOONMH)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0xCDEBA0", Offset = "0xCDD5A0", VA = "0x180CDEBA0")]
	public static AAMDACFJKLP OLKJPEKNNFN(string GDOGPMPJPOO)
	{
		return default(AAMDACFJKLP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x6EDAA90", Offset = "0x6ED9490", VA = "0x186EDAA90")]
	public string DHEKLEHJEJH(string BPNIIFAEJIL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x6EDA9B0", Offset = "0x6ED93B0", VA = "0x186EDA9B0")]
	public string AHIJHMNDBAD(object NIPPEPNPBAG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x957780", Offset = "0x956180", VA = "0x180957780", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000022")]
public readonly struct NEDLODCHJKB : IEquatable<NEDLODCHJKB>
{
	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x8C7620", Offset = "0x8C6020", VA = "0x1808C7620", Slot = "4")]
	public bool Equals(NEDLODCHJKB GDOGPMPJPOO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x6EE4610", Offset = "0x6EE3010", VA = "0x186EE4610", Slot = "0")]
	public override bool Equals(object GDOGPMPJPOO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x6EE4660", Offset = "0x6EE3060", VA = "0x186EE4660", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x6EE4670", Offset = "0x6EE3070", VA = "0x186EE4670", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
[IEODDIDMNFH("Now that `#nullable enable` is supported in our project, we should probably prefer that. The whole point of this type was to force checking before getting a value.`#nullable enable` can also force checking.")]
public readonly struct BHEDPLGAJGK<T> : IEquatable<BHEDPLGAJGK<T>> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public readonly T IPHIEALFCML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public readonly bool GEGPPCKEMJI;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public bool OGIHJGDEMGP
	{
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x5285770", Offset = "0x5284170", VA = "0x185285770")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x5285ED0", Offset = "0x52848D0", VA = "0x185285ED0")]
	public BHEDPLGAJGK([In] T PKCLPFEIPFH, bool OGAKDCBHIGE)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x52842C0", Offset = "0x5282CC0", VA = "0x1852842C0")]
	public static bool EKIKFCPHGPG([In] BHEDPLGAJGK<T> FCKNABCAAPB, [In] BHEDPLGAJGK<T> JGIIKLPFBFG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x5284880", Offset = "0x5283280", VA = "0x185284880", Slot = "4")]
	public bool Equals(BHEDPLGAJGK<T> GDOGPMPJPOO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x5284FE0", Offset = "0x52839E0", VA = "0x185284FE0", Slot = "0")]
	public override bool Equals(object GDOGPMPJPOO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x52851E0", Offset = "0x5283BE0", VA = "0x1852851E0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x5285B00", Offset = "0x5284500", VA = "0x185285B00", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public static class LMCIGAPMPGM
{
	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x2FB1E30", Offset = "0x2FB0830", VA = "0x182FB1E30")]
	public static BHEDPLGAJGK<T> KAIDKGJIHHK<T>([In] T PKCLPFEIPFH) where T : notnull
	{
		return default(BHEDPLGAJGK<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x2FB1C00", Offset = "0x2FB0600", VA = "0x182FB1C00")]
	public static BHEDPLGAJGK<T?> BHHOKODJJMO<T>()
	{
		return default(BHEDPLGAJGK<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x2FB1D70", Offset = "0x2FB0770", VA = "0x182FB1D70")]
	public static bool HIFAGCHLOAP<T>([In] this BHEDPLGAJGK<T> CDPKDAFFPIH, [Out][NotNullWhen(true)] T PKCLPFEIPFH) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x2FB1D10", Offset = "0x2FB0710", VA = "0x182FB1D10")]
	public static T? DLGJMDHKNJK<T>([In] this BHEDPLGAJGK<T> CDPKDAFFPIH, T? PFGHNJEFBFP)
	{
		return (T?)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public readonly struct AKEIJILMEEL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public readonly IntPtr GOOKMIOIMDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public readonly IntPtr PPABHHEAFLH;

	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public static readonly IntPtr FODEHAGONEB;

	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public static readonly IntPtr KFEFEAMHKIP;

	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public static readonly AKEIJILMEEL BDDJBNJILLK;

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public bool EFLKLBKLPDG
	{
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x6EDAB30", Offset = "0x6ED9530", VA = "0x186EDAB30")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0xE07750", Offset = "0xE06150", VA = "0x180E07750")]
	public AKEIJILMEEL(IntPtr IJKBHKOCIGA, IntPtr IOHEDDHHILN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x8ACA50", Offset = "0x8AB450", VA = "0x1808ACA50")]
	private static void BALHLMGECEG(string JHJFHDOAMLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x8ACA50", Offset = "0x8AB450", VA = "0x1808ACA50")]
	private static void FKIKGJHBNBB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x6EDAC00", Offset = "0x6ED9600", VA = "0x186EDAC00")]
	private static AKEIJILMEEL CDLBKGPOFII()
	{
		return default(AKEIJILMEEL);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public readonly struct DHPDMBIPJIL : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private readonly IntPtr OHBFKHINEIJ;

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x957790", Offset = "0x956190", VA = "0x180957790")]
	private DHPDMBIPJIL(IntPtr IOHEDDHHILN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x6EDC750", Offset = "0x6EDB150", VA = "0x186EDC750", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x6EDC650", Offset = "0x6EDB050", VA = "0x186EDC650")]
	public static DHPDMBIPJIL AELHPDENENI(string JHJFHDOAMLG)
	{
		return default(DHPDMBIPJIL);
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x228C0E0", Offset = "0x228AAE0", VA = "0x18228C0E0")]
	public static DHPDMBIPJIL AELHPDENENI([In] AKEIJILMEEL CNIMMKAPECF, string JHJFHDOAMLG)
	{
		return default(DHPDMBIPJIL);
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x228C460", Offset = "0x228AE60", VA = "0x18228C460")]
	public static DHPDMBIPJIL AELHPDENENI([In] AKEIJILMEEL CNIMMKAPECF, Func<string> JHJFHDOAMLG)
	{
		return default(DHPDMBIPJIL);
	}
}
namespace RecRoom.NoEngine.Common
{
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public class PreserveAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x8D6960", Offset = "0x8D5360", VA = "0x1808D6960")]
		public PreserveAttribute()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public static class IEAMFCHNINK
{
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public delegate bool KFCNDGJDNEA<in TInput, TResult>(TInput CPOLINJHFNA, [Out] TResult KIBAOEBFCJF);

	[Cpp2IlInjected.Token(Token = "0x200002A")]
	private sealed class EACKCOAHINN : KNCNMGIPFCE
	{
		[Cpp2IlInjected.Token(Token = "0x200002B")]
		private sealed class IJCDCAEPCAN : GJOOGINBAMA, INotifyCompletion
		{
			[Cpp2IlInjected.Token(Token = "0x400003E")]
			public static readonly IJCDCAEPCAN JOLICDCBKGF;

			[Cpp2IlInjected.Token(Token = "0x1700000E")]
			public bool OEMBJOBGAJG
			{
				[Cpp2IlInjected.Token(Token = "0x60000BD")]
				[Cpp2IlInjected.Address(RVA = "0x6EE2FE0", Offset = "0x6EE19E0", VA = "0x186EE2FE0", Slot = "4")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000BE")]
			[Cpp2IlInjected.Address(RVA = "0x6EE3040", Offset = "0x6EE1A40", VA = "0x186EE3040", Slot = "6")]
			public void OnCompleted(Action LGCHAKDNBND)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000BF")]
			[Cpp2IlInjected.Address(RVA = "0x8ACA50", Offset = "0x8AB450", VA = "0x1808ACA50", Slot = "5")]
			public void JGNMEKLNHNN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C0")]
			[Cpp2IlInjected.Address(RVA = "0x8B4380", Offset = "0x8B2D80", VA = "0x1808B4380")]
			public IJCDCAEPCAN()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public static readonly EACKCOAHINN JOLICDCBKGF;

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x8B4380", Offset = "0x8B2D80", VA = "0x1808B4380")]
		private EACKCOAHINN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x6EDC810", Offset = "0x6EDB210", VA = "0x186EDC810", Slot = "4")]
		public GJOOGINBAMA IFHANBOIBIK()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002D")]
	private sealed class MNNFAEPFLGH : KNCNMGIPFCE
	{
		[Cpp2IlInjected.Token(Token = "0x200002E")]
		private sealed class OLHOIIJFHMB : GJOOGINBAMA, INotifyCompletion
		{
			[Cpp2IlInjected.Token(Token = "0x4000042")]
			public static readonly OLHOIIJFHMB JOLICDCBKGF;

			[Cpp2IlInjected.Token(Token = "0x1700000F")]
			public bool OEMBJOBGAJG
			{
				[Cpp2IlInjected.Token(Token = "0x60000C8")]
				[Cpp2IlInjected.Address(RVA = "0x6EE5E20", Offset = "0x6EE4820", VA = "0x186EE5E20", Slot = "4")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000C9")]
			[Cpp2IlInjected.Address(RVA = "0x6EE5E40", Offset = "0x6EE4840", VA = "0x186EE5E40", Slot = "6")]
			public void OnCompleted(Action LGCHAKDNBND)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000CA")]
			[Cpp2IlInjected.Address(RVA = "0x8ACA50", Offset = "0x8AB450", VA = "0x1808ACA50", Slot = "5")]
			public void JGNMEKLNHNN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000CB")]
			[Cpp2IlInjected.Address(RVA = "0x8B4380", Offset = "0x8B2D80", VA = "0x1808B4380")]
			public OLHOIIJFHMB()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public static readonly MNNFAEPFLGH JOLICDCBKGF;

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x8B4380", Offset = "0x8B2D80", VA = "0x1808B4380")]
		private MNNFAEPFLGH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x6EE4550", Offset = "0x6EE2F50", VA = "0x186EE4550", Slot = "4")]
		public GJOOGINBAMA IFHANBOIBIK()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000031")]
	[CompilerGenerated]
	private sealed class KBIOPPEOJHB<TResult> where TResult : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public TaskCompletionSource<TResult> tcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public CancellationToken token;

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x8B4380", Offset = "0x8B2D80", VA = "0x1808B4380")]
		public KBIOPPEOJHB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x42593E0", Offset = "0x4257DE0", VA = "0x1842593E0")]
		internal void GCBCPEADFNL()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000032")]
	[CompilerGenerated]
	private sealed class EBJGCMOKBMO<TResult> where TResult : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public CancellationTokenRegistration registration;

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x8B4380", Offset = "0x8B2D80", VA = "0x1808B4380")]
		public EBJGCMOKBMO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x3B62F00", Offset = "0x3B61900", VA = "0x183B62F00")]
		internal void CDGCFIGANCM(Task<TResult> _)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	[CompilerGenerated]
	private struct CEBOJLBBHAE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public AsyncVoidMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public Task t;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x6EDC130", Offset = "0x6EDAB30", VA = "0x186EDC130", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x903690", Offset = "0x902090", VA = "0x180903690", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	[CompilerGenerated]
	private struct JDOJKOPELJJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public AsyncVoidMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public Task t;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x6EE3470", Offset = "0x6EE1E70", VA = "0x186EE3470", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x903690", Offset = "0x902090", VA = "0x180903690", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	[CompilerGenerated]
	private struct DJEFHEOADEG<TException> : IAsyncStateMachine where TException : notnull, Exception
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public Task t;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x5C851F0", Offset = "0x5C83BF0", VA = "0x185C851F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x5C85360", Offset = "0x5C83D60", VA = "0x185C85360", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	[CompilerGenerated]
	private struct PHIJJLKIACD<T> : IAsyncStateMachine where T : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public AsyncTaskMethodBuilder<T> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public Task<T> self;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		private TaskAwaiter<TaskStatus> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		private TaskAwaiter<T> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x4B6CCD0", Offset = "0x4B6B6D0", VA = "0x184B6CCD0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x4B6D120", Offset = "0x4B6BB20", VA = "0x184B6D120", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	[CompilerGenerated]
	private struct IKPFIHKPONK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public AsyncTaskMethodBuilder<TaskStatus> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public Task self;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x6EE3200", Offset = "0x6EE1C00", VA = "0x186EE3200", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x6EE3400", Offset = "0x6EE1E00", VA = "0x186EE3400", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000038")]
	[CompilerGenerated]
	private sealed class ILOJKJFFDKG<T> where T : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public TaskCompletionSource<T> taskCompletionSource;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public CancellationTokenRegistration registration;

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x8B4380", Offset = "0x8B2D80", VA = "0x1808B4380")]
		public ILOJKJFFDKG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x42593E0", Offset = "0x4257DE0", VA = "0x1842593E0")]
		internal void MONEKCCNFFH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x4259360", Offset = "0x4257D60", VA = "0x184259360")]
		internal void LGOHMHCJIAH(T arg1)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	[CompilerGenerated]
	private struct KONNFOEPMOE<TInput, TResult> : IAsyncStateMachine where TInput : notnull where TResult : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public AsyncTaskMethodBuilder<List<TResult>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public Task<List<TInput>> task;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public KFCNDGJDNEA<TInput, TResult> transformFunction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		private TaskAwaiter<List<TInput>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x45D7340", Offset = "0x45D5D40", VA = "0x1845D7340", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x45D7AA0", Offset = "0x45D64A0", VA = "0x1845D7AA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	[CompilerGenerated]
	private struct EJLBPIPMFFA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public Func<CancellationToken, Task> innerTaskConstructor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public Task t;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private CancellationTokenSource <innerTaskCancellationTokenSource>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		private Task <innerTask>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		private object <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		private int <>7__wrap4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private TaskAwaiter<TaskStatus> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x6EDD420", Offset = "0x6EDBE20", VA = "0x186EDD420", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x6EDDC10", Offset = "0x6EDC610", VA = "0x186EDDC10", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	[CompilerGenerated]
	private struct IHFHHEDNPHB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		public TimeSpan timeout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		public Func<CancellationToken, Task> taskBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		public Action<OperationCanceledException> handleTimeout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		private CancellationTokenSource <linkedCTS>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x6EE2920", Offset = "0x6EE1320", VA = "0x186EE2920", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x6EE2E60", Offset = "0x6EE1860", VA = "0x186EE2E60", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	[CompilerGenerated]
	private struct JEANLFEOIPA<T> : IAsyncStateMachine where T : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		public AsyncTaskMethodBuilder<T> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		public TimeSpan timeout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public Func<CancellationToken, Task<T>> taskBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public Func<OperationCanceledException, T> handleTimeout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		private CancellationTokenSource <linkedCTS>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		private TaskAwaiter<T> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x4415220", Offset = "0x4413C20", VA = "0x184415220", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x3F801B0", Offset = "0x3F7EBB0", VA = "0x183F801B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003D")]
	[CompilerGenerated]
	private sealed class NJFHMHBOBAB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public TaskCompletionSource<NEDLODCHJKB> tcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		public int tasksRemaining;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public Action<Task> <>9__0;

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x8B4380", Offset = "0x8B2D80", VA = "0x1808B4380")]
		public NJFHMHBOBAB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x6EE46A0", Offset = "0x6EE30A0", VA = "0x186EE46A0")]
		internal void GCKECBFNAAC(Task t)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	[CompilerGenerated]
	private struct PEADBFDNGCI<T> : IAsyncStateMachine where T : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public AsyncTaskMethodBuilder<IEnumerable<Task<T>>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public IEnumerable<Task<T>> tasks;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		private Task<T>[] <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		private int <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		private TaskAwaiter<T> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x4B63860", Offset = "0x4B62260", VA = "0x184B63860", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x38CF520", Offset = "0x38CDF20", VA = "0x1838CF520", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	[CompilerGenerated]
	private struct ODOOLAGGFDL<T1, T2, T3, T4> : IAsyncStateMachine where T1 : notnull where T2 : notnull where T3 : notnull where T4 : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public AsyncTaskMethodBuilder<(T1, T2, T3, T4)> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		public Task<T1> task1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		public Task<T2> task2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		public Task<T3> task3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		public Task<T4> task4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x4A523A0", Offset = "0x4A50DA0", VA = "0x184A523A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x4A530F0", Offset = "0x4A51AF0", VA = "0x184A530F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	[CompilerGenerated]
	private struct NJOHLJBLHDD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		public Func<bool> condition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x6EE50F0", Offset = "0x6EE3AF0", VA = "0x186EE50F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x6EE52D0", Offset = "0x6EE3CD0", VA = "0x186EE52D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	[CompilerGenerated]
	private struct GMOHJOOFJLO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		public TimeSpan pollingInterval;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		public Func<bool> condition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x6EDEA70", Offset = "0x6EDD470", VA = "0x186EDEA70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x6EDEDD0", Offset = "0x6EDD7D0", VA = "0x186EDEDD0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	[CompilerGenerated]
	private struct DFGNKPNEHAG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		public Func<bool> condition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		public TimeSpan timeout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		public Action<OperationCanceledException> handleTimeout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x6EDC300", Offset = "0x6EDAD00", VA = "0x186EDC300", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x6EDC5F0", Offset = "0x6EDAFF0", VA = "0x186EDC5F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000043")]
	[CompilerGenerated]
	private sealed class DKDHDIBOOMM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		public Func<bool> condition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		public TimeSpan pollingInterval;

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x8B4380", Offset = "0x8B2D80", VA = "0x1808B4380")]
		public DKDHDIBOOMM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x6EDC7A0", Offset = "0x6EDB1A0", VA = "0x186EDC7A0")]
		internal Task ICPDALFEGDK(CancellationToken timeoutToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	[CompilerGenerated]
	private struct NMIGCCIMKBC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		public Func<bool> condition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		public TimeSpan pollingInterval;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		public TimeSpan timeout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		public Action<OperationCanceledException> handleTimeout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x6EE5A10", Offset = "0x6EE4410", VA = "0x186EE5A10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x6EE5C70", Offset = "0x6EE4670", VA = "0x186EE5C70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	[CompilerGenerated]
	private struct EFLCNFHBGAM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		public Func<bool> condition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x6EDD1E0", Offset = "0x6EDBBE0", VA = "0x186EDD1E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x6EDD3C0", Offset = "0x6EDBDC0", VA = "0x186EDD3C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000046")]
	[CompilerGenerated]
	private struct FJGHLBKHKEH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		public TimeSpan pollingInterval;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		public Func<bool> condition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x6EDE6B0", Offset = "0x6EDD0B0", VA = "0x186EDE6B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x6EDEA10", Offset = "0x6EDD410", VA = "0x186EDEA10", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000047")]
	[CompilerGenerated]
	private struct HLPDFEJBJDP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		public Func<bool> condition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		public TimeSpan timeout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		public Action<OperationCanceledException> handleTimeout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x6EDEF40", Offset = "0x6EDD940", VA = "0x186EDEF40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x6EDF230", Offset = "0x6EDDC30", VA = "0x186EDF230", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000048")]
	[CompilerGenerated]
	private sealed class CEMBBPADCKM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		public Func<bool> condition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		public TimeSpan pollingInterval;

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x8B4380", Offset = "0x8B2D80", VA = "0x1808B4380")]
		public CEMBBPADCKM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x6EDC290", Offset = "0x6EDAC90", VA = "0x186EDC290")]
		internal Task GAINGDGNPLH(CancellationToken timeoutToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000049")]
	[CompilerGenerated]
	private struct EAIFNELPICO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		public Func<bool> condition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		public TimeSpan pollingInterval;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		public TimeSpan timeout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		public Action<OperationCanceledException> handleTimeout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x6EDC8D0", Offset = "0x6EDB2D0", VA = "0x186EDC8D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x6EDCB30", Offset = "0x6EDB530", VA = "0x186EDCB30", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004A")]
	[CompilerGenerated]
	private struct JFJKEMMAIOJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		public Task task;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		public Action then;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x6EE3580", Offset = "0x6EE1F80", VA = "0x186EE3580", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x6EE3700", Offset = "0x6EE2100", VA = "0x186EE3700", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004B")]
	[CompilerGenerated]
	private struct IBEMDBOABAB<T> : IAsyncStateMachine where T : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		public Task<T> task;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		public Action<T> then;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		private TaskAwaiter<T> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x423B780", Offset = "0x423A180", VA = "0x18423B780", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x423BA00", Offset = "0x423A400", VA = "0x18423BA00", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004C")]
	[CompilerGenerated]
	private struct MJINKBNKAPH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		public Func<Task> function;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		private object <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x6EE41C0", Offset = "0x6EE2BC0", VA = "0x186EE41C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x6EE44F0", Offset = "0x6EE2EF0", VA = "0x186EE44F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private static SynchronizationContext? EMPCJENMJAE;

	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private static readonly TaskCompletionSource<NEDLODCHJKB> POFGFFAAMFH;

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public static Task FAJKCGCEAPC
	{
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x6EDF340", Offset = "0x6EDDD40", VA = "0x186EDF340")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x6EDF9E0", Offset = "0x6EDE3E0", VA = "0x186EDF9E0")]
	public static bool DHBMBCBOFNL(this Task LPAAFOGOHKE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x2F21C70", Offset = "0x2F20670", VA = "0x182F21C70")]
	public static Task<T> JJBJBNBKEKJ<T>() where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x6EDF710", Offset = "0x6EDE110", VA = "0x186EDF710")]
	public static Task CGMDBEANLHC(this Task LPAAFOGOHKE, CancellationToken AICEIDIHFDO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x2F1F550", Offset = "0x2F1DF50", VA = "0x182F1F550")]
	public static Task<TResult> CGMDBEANLHC<TResult>(this Task<TResult> LPAAFOGOHKE, CancellationToken AICEIDIHFDO) where TResult : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x2F20B00", Offset = "0x2F1F500", VA = "0x182F20B00")]
	public static TaskCompletionSource<TResult> CGMDBEANLHC<TResult>(this TaskCompletionSource<TResult> DDBCLGDDBCK, CancellationToken AICEIDIHFDO) where TResult : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x6EDFF10", Offset = "0x6EDE910", VA = "0x186EDFF10")]
	public static IDisposable? GEDGOPFOOHO(CancellationToken FKMCNHAODFI, CancellationToken JOHOKJEAALC, [Out] CancellationToken FMGEHJGPCEA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x6EDF290", Offset = "0x6EDDC90", VA = "0x186EDF290")]
	[AsyncStateMachine(typeof(CEBOJLBBHAE))]
	public static void ACGMPICDFBB(this Task FOFGABNNIOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x6EE1120", Offset = "0x6EDFB20", VA = "0x186EE1120")]
	[AsyncStateMachine(typeof(JDOJKOPELJJ))]
	public static void PIIHCDPFMJM(this Task FOFGABNNIOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x2F221D0", Offset = "0x2F20BD0", VA = "0x182F221D0")]
	[AsyncStateMachine(typeof(DJEFHEOADEG<>))]
	public static Task MILKMBEPJOH<TException>(this Task FOFGABNNIOJ) where TException : notnull, Exception
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x2F1D3F0", Offset = "0x2F1BDF0", VA = "0x182F1D3F0")]
	[AsyncStateMachine(typeof(PHIJJLKIACD<>))]
	public static Task<T> CBONLPACBIA<T>(this Task<T> PCBICLOONMH) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x6EDF620", Offset = "0x6EDE020", VA = "0x186EDF620")]
	[AsyncStateMachine(typeof(IKPFIHKPONK))]
	public static Task<TaskStatus> CDCNDBOGKCG(this Task PCBICLOONMH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x2F21730", Offset = "0x2F20130", VA = "0x182F21730")]
	public static (Task<T?>?, Action<T?>?) HHINNPAEJAI<T>([Optional] CancellationToken PPLDCJFFMEP)
	{
		return default((Task<T>, Action<T>));
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x2F21FD0", Offset = "0x2F209D0", VA = "0x182F21FD0")]
	[AsyncStateMachine(typeof(KONNFOEPMOE<, >))]
	public static Task<List<TResult>> KCDCCIKKNKB<TResult, TInput>(this Task<List<TInput>> LPAAFOGOHKE, KFCNDGJDNEA<TInput, TResult> FJJOFHHEHOH) where TResult : notnull where TInput : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x6EE0FF0", Offset = "0x6EDF9F0", VA = "0x186EE0FF0")]
	[AsyncStateMachine(typeof(EJLBPIPMFFA))]
	public static Task PGDJPKPHFNA(Task FOFGABNNIOJ, CancellationToken AGFJCKJDLDL, Func<CancellationToken, Task> CMOLHJNPOKN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x6EDFA10", Offset = "0x6EDE410", VA = "0x186EDFA10")]
	[AsyncStateMachine(typeof(IHFHHEDNPHB))]
	public static Task ELLCDJGNJKD(Func<CancellationToken, Task> CNHGHEFAGAD, TimeSpan GELCEFJHMAH, [Optional] CancellationToken AGFJCKJDLDL, [Optional] Action<OperationCanceledException>? OAEANDMJHJM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x2F21490", Offset = "0x2F1FE90", VA = "0x182F21490")]
	[AsyncStateMachine(typeof(JEANLFEOIPA<>))]
	public static Task<T> ELLCDJGNJKD<T>(Func<CancellationToken, Task<T>> CNHGHEFAGAD, TimeSpan GELCEFJHMAH, [Optional] CancellationToken AGFJCKJDLDL, [Optional] Func<OperationCanceledException, T>? OAEANDMJHJM) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x6EE0650", Offset = "0x6EDF050", VA = "0x186EE0650")]
	public static Task JJLCJACGEHC(params Task[] PDLMNGFHLHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x6EE06A0", Offset = "0x6EDF0A0", VA = "0x186EE06A0")]
	public static Task JJLCJACGEHC(IEnumerable<Task> PDLMNGFHLHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x2F21EE0", Offset = "0x2F208E0", VA = "0x182F21EE0")]
	[AsyncStateMachine(typeof(PEADBFDNGCI<>))]
	public static Task<IEnumerable<Task<T>>> JNKNBMCOLKO<T>(IEnumerable<Task<T>> PDLMNGFHLHO) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x2F219B0", Offset = "0x2F203B0", VA = "0x182F219B0")]
	[AsyncStateMachine(typeof(ODOOLAGGFDL<, , , >))]
	public static Task<(T1, T2, T3, T4)> JIAHKIFFOJJ<T1, T2, T3, T4>(Task<T1> HDLLOJKDGBP, Task<T2> FOFDGCNLNJA, Task<T3> LAAKNNKIIDL, Task<T4> MABCMNBOEDB) where T1 : notnull where T2 : notnull where T3 : notnull where T4 : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x6EE0F00", Offset = "0x6EDF900", VA = "0x186EE0F00")]
	[AsyncStateMachine(typeof(NJOHLJBLHDD))]
	public static Task OPLFCFIPOAF(Func<bool> KPFOFBGGJLH, [Optional] CancellationToken PPLDCJFFMEP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x6EE0DF0", Offset = "0x6EDF7F0", VA = "0x186EE0DF0")]
	[AsyncStateMachine(typeof(GMOHJOOFJLO))]
	public static Task OPLFCFIPOAF(Func<bool> KPFOFBGGJLH, TimeSpan PGPAJCACIOB, [Optional] CancellationToken PPLDCJFFMEP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x6EDFDE0", Offset = "0x6EDE7E0", VA = "0x186EDFDE0")]
	[AsyncStateMachine(typeof(DFGNKPNEHAG))]
	public static Task GDILAMHLCPA(Func<bool> KPFOFBGGJLH, TimeSpan GELCEFJHMAH, [Optional] CancellationToken PPLDCJFFMEP, [Optional] Action<OperationCanceledException>? OAEANDMJHJM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x6EDFCA0", Offset = "0x6EDE6A0", VA = "0x186EDFCA0")]
	[AsyncStateMachine(typeof(NMIGCCIMKBC))]
	public static Task GDILAMHLCPA(Func<bool> KPFOFBGGJLH, TimeSpan GELCEFJHMAH, TimeSpan PGPAJCACIOB, [Optional] CancellationToken PPLDCJFFMEP, [Optional] Action<OperationCanceledException>? OAEANDMJHJM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x6EE0450", Offset = "0x6EDEE50", VA = "0x186EE0450")]
	[AsyncStateMachine(typeof(EFLCNFHBGAM))]
	public static Task IPDILMIJMOA(Func<bool> KPFOFBGGJLH, [Optional] CancellationToken PPLDCJFFMEP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x6EE0540", Offset = "0x6EDEF40", VA = "0x186EE0540")]
	[AsyncStateMachine(typeof(FJGHLBKHKEH))]
	public static Task IPDILMIJMOA(Func<bool> KPFOFBGGJLH, TimeSpan PGPAJCACIOB, [Optional] CancellationToken PPLDCJFFMEP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x6EDF4F0", Offset = "0x6EDDEF0", VA = "0x186EDF4F0")]
	[AsyncStateMachine(typeof(HLPDFEJBJDP))]
	public static Task BIEBBHAEJDN(Func<bool> KPFOFBGGJLH, TimeSpan GELCEFJHMAH, [Optional] CancellationToken PPLDCJFFMEP, [Optional] Action<OperationCanceledException>? OAEANDMJHJM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x6EDF3B0", Offset = "0x6EDDDB0", VA = "0x186EDF3B0")]
	[AsyncStateMachine(typeof(EAIFNELPICO))]
	public static Task BIEBBHAEJDN(Func<bool> KPFOFBGGJLH, TimeSpan GELCEFJHMAH, TimeSpan PGPAJCACIOB, [Optional] CancellationToken PPLDCJFFMEP, [Optional] Action<OperationCanceledException>? OAEANDMJHJM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x6EE0B60", Offset = "0x6EDF560", VA = "0x186EE0B60")]
	[AsyncStateMachine(typeof(JFJKEMMAIOJ))]
	[Obsolete]
	public static Task KHLDJDICPJP(this Task LPAAFOGOHKE, Action BJGJEBMIMIC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x2F220E0", Offset = "0x2F20AE0", VA = "0x182F220E0")]
	[Obsolete]
	[AsyncStateMachine(typeof(IBEMDBOABAB<>))]
	public static Task KHLDJDICPJP<T>(this Task<T> LPAAFOGOHKE, Action<T> BJGJEBMIMIC) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x6EE1350", Offset = "0x6EDFD50", VA = "0x186EE1350")]
	private static void PNHBPIFAHHN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x6EE00F0", Offset = "0x6EDEAF0", VA = "0x186EE00F0")]
	public static bool HJJAGCNMJNK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x6EE11D0", Offset = "0x6EDFBD0", VA = "0x186EE11D0")]
	private static void PJHONGHMMLD(SynchronizationContext PKCLPFEIPFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x6EDFB90", Offset = "0x6EDE590", VA = "0x186EDFB90")]
	private static void FHHLGBAGFIL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x6EE0D20", Offset = "0x6EDF720", VA = "0x186EE0D20")]
	public static void OOIMBJNMECA([Optional] string? FCMDIEEAPHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x6EDF960", Offset = "0x6EDE360", VA = "0x186EDF960")]
	public static void DDNCFMNJDME([Optional] string? FCMDIEEAPHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x6EE00A0", Offset = "0x6EDEAA0", VA = "0x186EE00A0")]
	public static KNCNMGIPFCE GMMFFMOFMHF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x6EDFB40", Offset = "0x6EDE540", VA = "0x186EDFB40")]
	public static KNCNMGIPFCE FEMNNMHEEHJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x6EE0C50", Offset = "0x6EDF650", VA = "0x186EE0C50")]
	[AsyncStateMachine(typeof(MJINKBNKAPH))]
	public static Task LBBLGJDPGON(Func<Task> KAMLMGFPOBL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct)]
public class AOOPPFIKPBO : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x8D6960", Offset = "0x8D5360", VA = "0x1808D6960")]
	public AOOPPFIKPBO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public class GNKDMPFHNAM : PLNKBKLAEPP
{
	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	public static readonly PLNKBKLAEPP JOLICDCBKGF;

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public DateTime JFEONMFBLKP
	{
		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x6EDEE30", Offset = "0x6EDD830", VA = "0x186EDEE30", Slot = "4")]
		get
		{
			return default(DateTime);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public DateTimeOffset FFMFGCIBAPC
	{
		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x6EDEE70", Offset = "0x6EDD870", VA = "0x186EDEE70", Slot = "5")]
		get
		{
			return default(DateTimeOffset);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x8B4380", Offset = "0x8B2D80", VA = "0x1808B4380")]
	public GNKDMPFHNAM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public interface PLNKBKLAEPP
{
	[Cpp2IlInjected.Token(Token = "0x17000012")]
	DateTime JFEONMFBLKP
	{
		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	DateTimeOffset FFMFGCIBAPC
	{
		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public static class BFLLMGNPCHP
{
	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public static long OFNMNJIIPDA
	{
		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x6EDB150", Offset = "0x6ED9B50", VA = "0x186EDB150")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public static long GHMLMKJFOFP
	{
		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x6EDB100", Offset = "0x6ED9B00", VA = "0x186EDB100")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public static double AHFMJCDINOC
	{
		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x6EDB1B0", Offset = "0x6ED9BB0", VA = "0x186EDB1B0")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public static double MPCHPBNFIAD
	{
		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x6EDAF80", Offset = "0x6ED9980", VA = "0x186EDAF80")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public static double NEHNAGOFLIN
	{
		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x6EDB200", Offset = "0x6ED9C00", VA = "0x186EDB200")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public static double LECLJFKPPAL
	{
		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x6EDB250", Offset = "0x6ED9C50", VA = "0x186EDB250")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x6EDAE60", Offset = "0x6ED9860", VA = "0x186EDAE60")]
	public static double ALHILBKGONL(long BPJKOIBFJCL)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x6EDB2A0", Offset = "0x6ED9CA0", VA = "0x186EDB2A0")]
	public static double PKNGBHMDDMD(long BPJKOIBFJCL)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x6EDAEF0", Offset = "0x6ED98F0", VA = "0x186EDAEF0")]
	public static double BCINFFIAFGF(double GJBBLBBKJFO)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x6EDADD0", Offset = "0x6ED97D0", VA = "0x186EDADD0")]
	public static long ADMKBPODKFA(long FPEHIEEJIAO)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x6EDB1A0", Offset = "0x6ED9BA0", VA = "0x186EDB1A0")]
	public static long LBNNHJIGELI(long LPOLBGDONLI, long KANKILFNCIN)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x6EDB030", Offset = "0x6ED9A30", VA = "0x186EDB030")]
	public static double EOHKHIIBIND(long LPOLBGDONLI, long KANKILFNCIN)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x6EDAFD0", Offset = "0x6ED99D0", VA = "0x186EDAFD0")]
	public static double EAEKPNPHEJA(long LPOLBGDONLI, long KANKILFNCIN)
	{
		return default(double);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public sealed class NJPPHBMJLOI : CNHCNFCGJGK, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	public static readonly TimeSpan PBFKMDKPDAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	private readonly System.Timers.Timer PILOCADBFFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	private TimeSpan GELCEFJHMAH;

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public TimeSpan LLPDJPEEEKA
	{
		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x8AD770", Offset = "0x8AC170", VA = "0x1808AD770", Slot = "4")]
		get
		{
			return default(TimeSpan);
		}
		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x6EE5330", Offset = "0x6EE3D30", VA = "0x186EE5330", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public Action? ONGNCANIFPC
	{
		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x8AD560", Offset = "0x8ABF60", VA = "0x1808AD560", Slot = "11")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x8AD970", Offset = "0x8AC370", VA = "0x1808AD970", Slot = "6")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x6EE5760", Offset = "0x6EE4160", VA = "0x186EE5760")]
	[Preserve]
	public NJPPHBMJLOI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x6EE57C0", Offset = "0x6EE41C0", VA = "0x186EE57C0")]
	public NJPPHBMJLOI(TimeSpan GELCEFJHMAH, [Optional] Action? BDJPFGFBEKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x6EE5660", Offset = "0x6EE4060", VA = "0x186EE5660", Slot = "7")]
	public void PMHKFLKJGHI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x6EE5490", Offset = "0x6EE3E90", VA = "0x186EE5490", Slot = "8")]
	public void DKHJOFINOJA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x6EE5630", Offset = "0x6EE4030", VA = "0x186EE5630", Slot = "9")]
	public void OJLNFIHNJLA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0xC8F420", Offset = "0xC8DE20", VA = "0x180C8F420")]
	private void JJJIAAANGBM(object HBABIBCNPCH, ElapsedEventArgs CNEOEDNPIDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x6EE55A0", Offset = "0x6EE3FA0", VA = "0x186EE55A0")]
	private static void KADMJIJECAJ(TimeSpan NIAMHAAHGAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x6EE5500", Offset = "0x6EE3F00", VA = "0x186EE5500", Slot = "10")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
[AttributeUsage(AttributeTargets.All, AllowMultiple = true)]
public class IEODDIDMNFH : Attribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	public readonly string? GEPAFFHBOIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	public readonly string CCIAPIMMKLE;

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x6944DC0", Offset = "0x69437C0", VA = "0x186944DC0")]
	public IEODDIDMNFH(string IGIOLLIFOOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x427CDC0", Offset = "0x427B7C0", VA = "0x18427CDC0")]
	public IEODDIDMNFH(string KLBPNCLBHIJ, string IGIOLLIFOOJ)
	{
	}
}
[StructLayout((LayoutKind)2)]
[Cpp2IlInjected.Token(Token = "0x2000053")]
[DebuggerDisplay("U32: {U32}, I32: {I32}, F32: {F32}, U16_0: {U16_0}, I16_1: {I16_1}, Char_0: '{Char_0}', Char_1: '{Char_1}', U8_0: {U8_0}, U8_1: {U8_1}, U8_2: {U8_2}, U8_3: {U8_3}, Bool_0: {Bool_0}, Bool_1: {Bool_1}, Bool_2: {Bool_2}, Bool_3: {Bool_3}")]
public struct IGKJGOKFFBO : IEquatable<IGKJGOKFFBO>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	public uint LGJIIJFGPIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	public int IEKBDGJMPEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	public float LGBKKLFBLMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	public ushort JDENOAGFHFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	public ushort IJIHCCDPDKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	public short DEMODJKNMGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	public short PCKAFOHOCJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	public char HKAJGJFOFAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	public char LNJMBDDLNJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	public byte DBIFIFHMLBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	public byte JPNCIPGBLGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	public byte FLHKMOJMGHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	public byte FPAJOCNIKGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	public bool FNJPNDECBDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	public bool OKJOLKKNDJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	public bool GONMAJAHLGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	public bool IOGIKLFGLKG;

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x1721280", Offset = "0x171FC80", VA = "0x181721280")]
	public static IGKJGOKFFBO BNHEABDMCFD(uint PBAJALHKLBG)
	{
		return default(IGKJGOKFFBO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x1721280", Offset = "0x171FC80", VA = "0x181721280")]
	public static IGKJGOKFFBO HCECBLOMKNF(int FGAMAJFPEOH)
	{
		return default(IGKJGOKFFBO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x6EE1B20", Offset = "0x6EE0520", VA = "0x186EE1B20")]
	public static IGKJGOKFFBO JILBOEEAAJB(float GKAHHCDFEOF)
	{
		return default(IGKJGOKFFBO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x6EE1B00", Offset = "0x6EE0500", VA = "0x186EE1B00")]
	public static IGKJGOKFFBO GLLIGCBAONE(byte GKAILBBJLKI, byte LNEHLHCJELK, byte OHNKIEFEKHG, byte BABFEJPJELJ)
	{
		return default(IGKJGOKFFBO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x6EE1B00", Offset = "0x6EE0500", VA = "0x186EE1B00")]
	public static IGKJGOKFFBO HJLMADGEGHB(bool OMIOMONJCBA, bool EHBBDPFAHJI, bool CHCAMFGOKGG, bool GHMJDBGKCDE)
	{
		return default(IGKJGOKFFBO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x6EE1B00", Offset = "0x6EE0500", VA = "0x186EE1B00")]
	public static IGKJGOKFFBO MDHDAEDKPGF(byte NIOCOMNLCMD, byte JHAKLMNDIDC, byte BKAICNNKEDD, byte PHJJAHEDKKK)
	{
		return default(IGKJGOKFFBO);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x200A8B0", Offset = "0x20092B0", VA = "0x18200A8B0")]
	public static bool EKIKFCPHGPG(IGKJGOKFFBO GPBGMCKGICE, IGKJGOKFFBO PGFJAECCPCN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x200A890", Offset = "0x2009290", VA = "0x18200A890", Slot = "4")]
	public bool Equals(IGKJGOKFFBO GDOGPMPJPOO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x6EE1A80", Offset = "0x6EE0480", VA = "0x186EE1A80", Slot = "0")]
	public override bool Equals(object BBNKFKDCOLP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0xDE4820", Offset = "0xDE3220", VA = "0x180DE4820", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x6EE1B30", Offset = "0x6EE0530", VA = "0x186EE1B30", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[StructLayout((LayoutKind)2)]
[Cpp2IlInjected.Token(Token = "0x2000054")]
public struct ABDHAJKJMAH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	public ulong CNBEBEDHELG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	public long PEKGPCIMHMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	public double KGCCIJBEDNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	public uint JIPFEGLANNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	public uint KDPCMBGINHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	public int BMFDGMOMIJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	public int PDLGJNEGBNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	public float BDFIMKOCCND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	public float OBJFFPFDIFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	public ushort JDENOAGFHFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	public ushort IJIHCCDPDKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	public ushort PFOEHMOKDHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	public ushort KPGONFGHKFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	public short DEMODJKNMGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	public short PCKAFOHOCJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400010B")]
	public short KKJOLCLJPIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
	[Cpp2IlInjected.Token(Token = "0x400010C")]
	public short LBGMPENPBAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400010D")]
	public char HKAJGJFOFAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	public char LNJMBDDLNJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	public char DJKJAECIGGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	public char GHCPHLDEBNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	public byte DBIFIFHMLBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	public byte JPNCIPGBLGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	public byte FLHKMOJMGHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	public byte FPAJOCNIKGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	public byte JGFMANEIHEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5")]
	[Cpp2IlInjected.Token(Token = "0x4000116")]
	public byte IIMJLBJMMHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	public byte IABKLDKBMLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7")]
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	public byte HFAAINJKMPH;

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0xA09F00", Offset = "0xA08900", VA = "0x180A09F00")]
	public static ABDHAJKJMAH AELHPDENENI(long OOAJPECNNMK)
	{
		return default(ABDHAJKJMAH);
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x6EDAAE0", Offset = "0x6ED94E0", VA = "0x186EDAAE0")]
	public static ABDHAJKJMAH AELHPDENENI(byte GKAILBBJLKI, byte LNEHLHCJELK, byte OHNKIEFEKHG, byte BABFEJPJELJ, byte MGJOEDGAPGM, byte MLLDGFFNDIH, byte COPJCEDGNBK, byte LEKNNDAMENH)
	{
		return default(ABDHAJKJMAH);
	}
}
[StructLayout((LayoutKind)2)]
[Cpp2IlInjected.Token(Token = "0x2000055")]
[DebuggerDisplay("U8: {U8}, Bool: {Bool}")]
public struct PKKNBJFNOKF : IEquatable<PKKNBJFNOKF>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	public byte OOBJJOPEIEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	public bool LGADBMICKPN;

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x2892D70", Offset = "0x2891770", VA = "0x182892D70")]
	public static PKKNBJFNOKF GLLIGCBAONE(byte OMOLFAMMLJI)
	{
		return default(PKKNBJFNOKF);
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x2892D70", Offset = "0x2891770", VA = "0x182892D70")]
	public static PKKNBJFNOKF HJLMADGEGHB(bool HAFNGMKIFDJ)
	{
		return default(PKKNBJFNOKF);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x6EE5F00", Offset = "0x6EE4900", VA = "0x186EE5F00")]
	public static bool EKIKFCPHGPG(PKKNBJFNOKF GPBGMCKGICE, PKKNBJFNOKF PGFJAECCPCN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x600E040", Offset = "0x600CA40", VA = "0x18600E040", Slot = "4")]
	public bool Equals(PKKNBJFNOKF GDOGPMPJPOO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x6EE5F10", Offset = "0x6EE4910", VA = "0x186EE5F10", Slot = "0")]
	public override bool Equals(object BBNKFKDCOLP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x6EE5FA0", Offset = "0x6EE49A0", VA = "0x186EE5FA0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x6EE5FB0", Offset = "0x6EE49B0", VA = "0x186EE5FB0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
public class PDBIEBGMMNO<T> : Exception where T : struct
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400011B")]
	public readonly T AHEAGFDAGBA;

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x4B5D3A0", Offset = "0x4B5BDA0", VA = "0x184B5D3A0")]
	public PDBIEBGMMNO(T DJNJIGPPKJH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
public static class IKBPAPGGIPJ
{
	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x2D6B5C0", Offset = "0x2D69FC0", VA = "0x182D6B5C0")]
	public static IEnumerable<T> ADJFAMLIKKI<T>() where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0xA09F00", Offset = "0xA08900", VA = "0x180A09F00")]
	public static T[] FPGGOOCKJMM<T>(params T[] APANIGAAHJJ) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0xA09F00", Offset = "0xA08900", VA = "0x180A09F00")]
	public static IEnumerable<T> JAEFCJJPLIF<T>(params T[] APANIGAAHJJ) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x2CE9660", Offset = "0x2CE8060", VA = "0x182CE9660")]
	public static HashSet<T> LFFLCLFJKPE<T>(params T[] APANIGAAHJJ) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x2F2AF20", Offset = "0x2F29920", VA = "0x182F2AF20")]
	public static KeyValuePair<TKey, TValue> KKOAFPGJLHF<TKey, TValue>([In] TKey PNABAFEIDND, [In] TValue PKCLPFEIPFH) where TKey : notnull where TValue : notnull
	{
		return default(KeyValuePair<TKey, TValue>);
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x2CE9660", Offset = "0x2CE8060", VA = "0x182CE9660")]
	public static List<T> HFDNPHDOAOJ<T>(IEnumerable<T> FAPCKKJDJFC) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
[AttributeUsage(AttributeTargets.All)]
public sealed class JJJPBIKDBBE : Attribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400011C")]
	public readonly string NBODLMMGNGD;

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x8D7890", Offset = "0x8D6290", VA = "0x1808D7890")]
	public JJJPBIKDBBE(string DIJABOFBAKO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public delegate object MPHKGHPPOHN<T>([In] T LPLPEHNKFMM);
[Cpp2IlInjected.Token(Token = "0x200005A")]
public delegate object PMINAEHANDA<T>(T LPLPEHNKFMM);
[Cpp2IlInjected.Token(Token = "0x200005B")]
[IGGIBFFOGDM]
public delegate string MDHPEBLHBFO(string JBIHOCOCJKD, string? BLBINOCFPJK, bool NHKLOAEFNEJ);
[Cpp2IlInjected.Token(Token = "0x200005C")]
[IGGIBFFOGDM]
public delegate void ABMMNOAANGI(string FCMDIEEAPHD);
[Cpp2IlInjected.Token(Token = "0x200005D")]
[IGGIBFFOGDM]
public delegate void KMLPMKJPNBK(Exception AENFONOHPNM);
[Cpp2IlInjected.Token(Token = "0x200005E")]
public delegate object DDLLKCBDMBL();
[Cpp2IlInjected.Token(Token = "0x200005F")]
[IGGIBFFOGDM]
public delegate bool LCPLECODMNH();
[Cpp2IlInjected.Token(Token = "0x2000060")]
[IGGIBFFOGDM]
public delegate string NNKAPOHDIJF(object BBNKFKDCOLP);
[Cpp2IlInjected.Token(Token = "0x2000061")]
[AttributeUsage(AttributeTargets.Enum)]
public class HJIHADHOOKN : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x8D6960", Offset = "0x8D5360", VA = "0x1808D6960")]
	public HJIHADHOOKN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
public static class EFEGNLIHKGI
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000064")]
	[CompilerGenerated]
	private struct JJKJBIMAIGE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		public AsyncTaskMethodBuilder<bool> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000123")]
		public int millisecondsDelay;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000124")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000125")]
		private CancellationTokenRegistration <cancellationTokenRegistration>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000126")]
		private System.Threading.Timer <timer>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000127")]
		private object <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000128")]
		private int <>7__wrap4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x4000129")]
		private bool <>7__wrap5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400012A")]
		private object <>7__wrap6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400012B")]
		private int <>7__wrap7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x400012C")]
		private bool <>7__wrap8;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400012D")]
		private TaskAwaiter<bool> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400012E")]
		private ValueTaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x6EE3760", Offset = "0x6EE2160", VA = "0x186EE3760", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x6EE4050", Offset = "0x6EE2A50", VA = "0x186EE4050", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400011D")]
	private static readonly TimerCallback MFMACJGDLDH;

	[Cpp2IlInjected.Token(Token = "0x400011E")]
	private static readonly Action<object?> KPHBAKAAKHI;

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x6EDCD50", Offset = "0x6EDB750", VA = "0x186EDCD50")]
	public static Task<bool> MHKKEMOPFHI(int FJPMPIBIKFH, [Optional] CancellationToken PPLDCJFFMEP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x6EDCC20", Offset = "0x6EDB620", VA = "0x186EDCC20")]
	[AsyncStateMachine(typeof(JJKJBIMAIGE))]
	private static Task<bool> IGFECHCOMFH(int FJPMPIBIKFH, CancellationToken PPLDCJFFMEP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x6EDD050", Offset = "0x6EDBA50", VA = "0x186EDD050")]
	private static void MLKNFDEEOLK(object? DPGCKOGOMEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x6EDCB90", Offset = "0x6EDB590", VA = "0x186EDCB90")]
	private static void BPHPFFKENJB(object? DPGCKOGOMEN)
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
