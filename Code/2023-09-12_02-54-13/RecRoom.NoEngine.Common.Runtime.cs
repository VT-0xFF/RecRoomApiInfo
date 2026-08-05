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
		[Cpp2IlInjected.Address(RVA = "0x8CB040", Offset = "0x8CA440", VA = "0x1808CB040")]
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
		[Cpp2IlInjected.Address(RVA = "0x7149910", Offset = "0x7148D10", VA = "0x187149910")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xA6EF70", Offset = "0xA6E370", VA = "0x180A6EF70")]
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
		[Cpp2IlInjected.Address(RVA = "0xA6EFA0", Offset = "0xA6E3A0", VA = "0x180A6EFA0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Parameter | AttributeTargets.ReturnValue)]
public sealed class NDJEELBJGFB : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x8CB040", Offset = "0x8CA440", VA = "0x1808CB040")]
	public NDJEELBJGFB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[AttributeUsage(AttributeTargets.Parameter)]
public sealed class LOPEJNOEKCJ : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0xA6EFA0", Offset = "0xA6E3A0", VA = "0x180A6EFA0")]
	public LOPEJNOEKCJ(bool KHKACDBJKBM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
[AttributeUsage(AttributeTargets.Parameter)]
public sealed class MABOPGHNNNM : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0xA6EFA0", Offset = "0xA6E3A0", VA = "0x180A6EFA0")]
	public MABOPGHNNNM(bool KHKACDBJKBM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Parameter | AttributeTargets.ReturnValue)]
public sealed class IPKHGMGPMGJ : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x8CB040", Offset = "0x8CA440", VA = "0x1808CB040")]
	public IPKHGMGPMGJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
[AttributeUsage(AttributeTargets.Method | AttributeTargets.Property)]
public sealed class CDCOPLCCHBB : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x7146660", Offset = "0x7145A60", VA = "0x187146660")]
	public CDCOPLCCHBB(bool KHKACDBJKBM, string FOEIGMLOHDP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
[AttributeUsage(AttributeTargets.All)]
public class EFPBIFFAEEN : Attribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public readonly string JCNOHAELOOD;

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0xA6EF70", Offset = "0xA6E370", VA = "0x180A6EF70")]
	public EFPBIFFAEEN(string NLDGENPEJBJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public static class CLMKGFBGPAB
{
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public delegate bool NNADNCDEODA<in TInput, TResult>(TInput MNNPDPNIFNM, out TResult MOOEDNDCGLB);

	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[CompilerGenerated]
	private sealed class GLHHIBMGHJM<TResult> where TResult : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public TaskCompletionSource<TResult> tcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public CancellationToken token;

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x92E880", Offset = "0x92DC80", VA = "0x18092E880")]
		public GLHHIBMGHJM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x2230960", Offset = "0x222FD60", VA = "0x182230960")]
		internal void IBHKIPJBJCB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	private sealed class POOPENEAGNO<TResult> where TResult : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public CancellationTokenRegistration registration;

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x92E880", Offset = "0x92DC80", VA = "0x18092E880")]
		public POOPENEAGNO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x24532A0", Offset = "0x24526A0", VA = "0x1824532A0")]
		internal void PDKCKNHFIHA(Task<TResult> _)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[CompilerGenerated]
	private sealed class PHDDPOPABLL<TInput, TResult> : IAsyncStateMachine where TInput : notnull where TResult : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public AsyncTaskMethodBuilder<List<TResult>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x71D230", Offset = "0x71C630")]
		public Task<List<TInput>> task;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public NNADNCDEODA<TInput, TResult> transformFunction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private List<TInput> <unparsedResults>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private List<TResult> <parsedResults>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private List<TInput> <>s__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private List<TInput>.Enumerator <>s__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private TInput <unparsedResult>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private TResult <parsed>5__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x71D290", Offset = "0x71C690")]
		private TaskAwaiter<List<TInput>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x92E880", Offset = "0x92DC80", VA = "0x18092E880")]
		public PHDDPOPABLL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x2C46A90", Offset = "0x2C45E90", VA = "0x182C46A90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[CompilerGenerated]
	private sealed class GAFIGJKHIGB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public AsyncTaskMethodBuilder<TaskStatus> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public Task selfInternal;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private Exception <ex>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80")]
		public GAFIGJKHIGB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x7147CE0", Offset = "0x71470E0", VA = "0x187147CE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x7146AC0", Offset = "0x7145EC0", VA = "0x187146AC0")]
	public static Task<TaskStatus> OLHCFGFJNNM(this Task ODBHDBFBMOB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x21C99E0", Offset = "0x21C8DE0", VA = "0x1821C99E0")]
	public static Task<T> CDCCPIOGJHD<T>() where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x7146740", Offset = "0x7145B40", VA = "0x187146740")]
	public static Task ADLFGPPDDEK(this Task NOKNMHIKNGD, CancellationToken AEMEEHLIDCM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x21C8C80", Offset = "0x21C8080", VA = "0x1821C8C80")]
	public static Task<TResult> ADLFGPPDDEK<TResult>(this Task<TResult> NOKNMHIKNGD, CancellationToken AEMEEHLIDCM) where TResult : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x21C9620", Offset = "0x21C8A20", VA = "0x1821C9620")]
	public static TaskCompletionSource<TResult> ADLFGPPDDEK<TResult>(this TaskCompletionSource<TResult> ECBAFHPLLCN, CancellationToken AEMEEHLIDCM) where TResult : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x16DFE00", Offset = "0x16DF200", VA = "0x1816DFE00")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(PHDDPOPABLL<, >))]
	public static Task<List<TResult>> GDILHLABNPJ<TResult, TInput>(this Task<List<TInput>> NOKNMHIKNGD, NNADNCDEODA<TInput, TResult> HKDPFKBGBLM) where TResult : notnull where TInput : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x7146970", Offset = "0x7145D70", VA = "0x187146970")]
	[DebuggerStepThrough]
	[CompilerGenerated]
	[AsyncStateMachine(typeof(GAFIGJKHIGB))]
	internal static Task<TaskStatus> HFALPHNOMNI(Task MLFJKFJDFKI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface HECCOAPKEEN : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	TimeSpan AGPHPFFIPPN
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	Action? AEJAOKABKLL
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(Slot = "2")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void OPKOFIPIHJD();

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void MHJOFGEIPDB();

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void KAEFBDOJFHE();
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public readonly struct AABPINMOHNN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public readonly string EKGBCCDIAJC;

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x8BE820", Offset = "0x8BDC20", VA = "0x1808BE820")]
	public AABPINMOHNN(string AGLCIEKHLEE)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x81F0A0", Offset = "0x81E4A0", VA = "0x18081F0A0")]
	public static string LFFBPOODCDC(in AABPINMOHNN ODBHDBFBMOB)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0xBBDC60", Offset = "0xBBD060", VA = "0x180BBDC60")]
	public static AABPINMOHNN LFFBPOODCDC(string ICELKIGIKKP)
	{
		return default(AABPINMOHNN);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x71452F0", Offset = "0x71446F0", VA = "0x1871452F0")]
	public string HFJDIJBEMNM(string LECIMCCDIIM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x71451F0", Offset = "0x71445F0", VA = "0x1871451F0")]
	public string CCLOILOJOMP(object KJEBJAPHFDB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x81F0A0", Offset = "0x81E4A0", VA = "0x18081F0A0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public readonly struct HKJOLMGMDIB<T> : IEquatable<HKJOLMGMDIB<T>>, GMDIBMAAGEJ<HKJOLMGMDIB<T>> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public readonly T EKGBCCDIAJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public readonly int FKHPMLNOHLM;

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x176B620", Offset = "0x176AA20", VA = "0x18176B620")]
	public HKJOLMGMDIB(in T AGLCIEKHLEE, int BNOAGGNAMKG)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x31CE0B0", Offset = "0x31CD4B0", VA = "0x1831CE0B0")]
	public static bool PHJEMBLBEDF([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x71D370", Offset = "0x71C770")] in HKJOLMGMDIB<T> FINJCDHFPJB, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x71D3E0", Offset = "0x71C7E0")] in HKJOLMGMDIB<T> JHJGODIMNAF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x2078A80", Offset = "0x2077E80", VA = "0x182078A80", Slot = "4")]
	public bool Equals([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x71D450", Offset = "0x71C850")] HKJOLMGMDIB<T> ICELKIGIKKP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x31CD400", Offset = "0x31CC800", VA = "0x1831CD400", Slot = "0")]
	public override bool Equals(object ICELKIGIKKP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x31CD500", Offset = "0x31CC900", VA = "0x1831CD500")]
	public bool FCBBFOADOJJ([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x71D4B0", Offset = "0x71C8B0")] in HKJOLMGMDIB<T> ICELKIGIKKP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x31CD810", Offset = "0x31CCC10", VA = "0x1831CD810", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x31CEA00", Offset = "0x31CDE00", VA = "0x1831CEA00", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x31CCD20", Offset = "0x31CC120", VA = "0x1831CCD20")]
	public void CILAAEFJCBE(out T AGLCIEKHLEE, out int BNOAGGNAMKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x31CDDA0", Offset = "0x31CD1A0", VA = "0x1831CDDA0")]
	public (T, int) HOIGGFBKBJP()
	{
		return default((T, int));
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x31CDE20", Offset = "0x31CD220", VA = "0x1831CDE20", Slot = "5")]
	private bool JAIMCOFLBKH([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x71D520", Offset = "0x71C920")] in HKJOLMGMDIB<T> ICELKIGIKKP)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public static class FDPICNMELGB
{
	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x17AAEF0", Offset = "0x17AA2F0", VA = "0x1817AAEF0")]
	public static HKJOLMGMDIB<T> NAILOIKCJEC<T>(in T AGLCIEKHLEE, int BNOAGGNAMKG) where T : notnull
	{
		return default(HKJOLMGMDIB<T>);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000017")]
public readonly struct PNGLJAGHHDL : IEquatable<PNGLJAGHHDL>
{
	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x823C20", Offset = "0x823020", VA = "0x180823C20", Slot = "4")]
	public bool Equals(PNGLJAGHHDL ICELKIGIKKP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x71499A0", Offset = "0x7148DA0", VA = "0x1871499A0", Slot = "0")]
	public override bool Equals(object ICELKIGIKKP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x71499F0", Offset = "0x7148DF0", VA = "0x1871499F0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x7149A00", Offset = "0x7148E00", VA = "0x187149A00", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public readonly struct EPLOLPPBFMO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public readonly ABKMJDCFONC ODFLOOHMOGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public readonly FANLNBOBJFD JNABJMBNIDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public readonly PGNMOIKIPNJ LOHOMBAKKEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public readonly CNOOPCECPEE OKNAKHACBHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public readonly AGCBMIFJODD JACCHJFNOIM;

	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public static readonly PGNMOIKIPNJ OPDNKONJMKE;

	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public static readonly CNOOPCECPEE FDOOKDAANAM;

	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public static readonly AGCBMIFJODD BCCPFCNBBDF;

	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public static readonly EPLOLPPBFMO AOKDNNAFLGL;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool CGCNKCIPCIA
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x71474B0", Offset = "0x71468B0", VA = "0x1871474B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x7147960", Offset = "0x7146D60", VA = "0x187147960")]
	public EPLOLPPBFMO(in ABKMJDCFONC FGIHEEGJCAC, in FANLNBOBJFD PCAKGMOOPDI, PGNMOIKIPNJ LLCNAFHMAAI, CNOOPCECPEE DFJFKFEJPDK, AGCBMIFJODD OENJKBFGGBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x71475F0", Offset = "0x71469F0", VA = "0x1871475F0")]
	private static string LNKLODKAKOP(object HFAGBIOODHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x821EB0", Offset = "0x8212B0", VA = "0x180821EB0")]
	private static long EGAJNJFIADN()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x8C40A0", Offset = "0x8C34A0", VA = "0x1808C40A0")]
	private static string OCGOPKAEMPE(string OABFELNKNEB, string? CKIGCBDGMFI, bool EIOLCJIKMFI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x7147390", Offset = "0x7146790", VA = "0x187147390")]
	private static EPLOLPPBFMO BCDNDNHIEEB()
	{
		return default(EPLOLPPBFMO);
	}
}
[StructLayout((LayoutKind)2)]
[Cpp2IlInjected.Token(Token = "0x2000019")]
public struct KEIMDBCPPJN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	public ulong CGHFLLCAAAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	public long ENGGBCBADOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	public double ILFIKJOBDND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	public uint GOPJMGMHIEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	public uint MPKFGGKINHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	public int EPLODFLGGJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public int HFGFMIBPOLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public float IGFKPAECFBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public float LACCPOPHBPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public ushort ILDHIFCGAGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public ushort NDJHNMFIKGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public ushort JFACNLIIAJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public ushort LADCAMEEKMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public short PEEDIIEKKBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public short GMFFAPMMOMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public short CNIAKLGAHAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public short PIJIMEJJBHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public char DHCNIPEEDFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public char DKEFEAHIPDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public char NBFNNOIEMCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public char ELIGILAJELO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	public byte KPJDNLONCNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	public byte KKLDGMFLLJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public byte LFGGNBDGCEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public byte HPIJPMFPMCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public byte AMBNNFENPJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	public byte MFLCLCCCCAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public byte LGEJMAEHMGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	public byte FEIAHHDCMJG;

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x7148F20", Offset = "0x7148320", VA = "0x187148F20")]
	public static KEIMDBCPPJN NAILOIKCJEC(byte AHHODKCDCND, byte HOBBCPIJOGG, byte BBKKCNLNPHA, byte MBKHEPMPACF, byte EIDMGKBFEKA, byte MNCFFFEBCLD, byte FPOKLIMDPNN, byte INBHCJFGNGM)
	{
		return default(KEIMDBCPPJN);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public class POEFMLPAFNP<TResult> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public delegate Task<TResult> BNANGICOFBH(CancellationToken ODBDCIFDKPJ);

	[Cpp2IlInjected.Token(Token = "0x200001C")]
	[CompilerGenerated]
	private sealed class CMLHIBDHNIG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public AsyncTaskMethodBuilder<TResult> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public BNANGICOFBH taskGenerator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public POEFMLPAFNP<TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x71D720", Offset = "0x71CB20")]
		private TaskCompletionSource<TResult> <tcs>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		private CancellationTokenSource <runningCancellationTokenSource>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		private TResult <result>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		private TResult <>s__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		private Exception <ex>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		private TResult <>s__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		private TaskAwaiter<TResult> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x92E880", Offset = "0x92DC80", VA = "0x18092E880")]
		public CMLHIBDHNIG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x383D460", Offset = "0x383C860", VA = "0x18383D460", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	private readonly CancellationTokenSource OCLAFKPHAEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	private CancellationTokenSource? AGLEPKAMGCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x71D5F0", Offset = "0x71C9F0")]
	private TaskCompletionSource<TResult> BMPCANHCCGP;

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x244A0D0", Offset = "0x24494D0", VA = "0x18244A0D0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(POEFMLPAFNP<>.CMLHIBDHNIG))]
	public Task<TResult> GPHEJGIAGOG([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x71D6C0", Offset = "0x71CAC0")] POEFMLPAFNP<TResult>.BNANGICOFBH JFOFCDKOLIB, [Optional] CancellationToken ODBDCIFDKPJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x244A060", Offset = "0x2449460", VA = "0x18244A060", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x244A2D0", Offset = "0x24496D0", VA = "0x18244A2D0")]
	public POEFMLPAFNP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public readonly struct ABKMJDCFONC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	public readonly PLGCDPKBEBB PCGBDFOECEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	public readonly OCCPNAOAPME MKPAEJIDKOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	public readonly PLGCDPKBEBB JBENLPPLAJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	public readonly OCCPNAOAPME ILIKBMDDJCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public readonly PLGCDPKBEBB NAKFCAFHBFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public readonly OCCPNAOAPME CBDMMCHJBML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public readonly DMJEDAEBANK CNHGLMABGJD;

	[Cpp2IlInjected.Token(Token = "0x400005E")]
	public static readonly PLGCDPKBEBB MONFIFPDIED;

	[Cpp2IlInjected.Token(Token = "0x400005F")]
	public static readonly OCCPNAOAPME NKCGJFGFLED;

	[Cpp2IlInjected.Token(Token = "0x4000060")]
	public static readonly PLGCDPKBEBB HDHJEOIMBPL;

	[Cpp2IlInjected.Token(Token = "0x4000061")]
	public static readonly OCCPNAOAPME IIPJLHCMOLA;

	[Cpp2IlInjected.Token(Token = "0x4000062")]
	public static readonly PLGCDPKBEBB EGPPJPAABGC;

	[Cpp2IlInjected.Token(Token = "0x4000063")]
	public static readonly OCCPNAOAPME AOFGKJEEKFF;

	[Cpp2IlInjected.Token(Token = "0x4000064")]
	public static readonly DMJEDAEBANK BHMJBIGJPHL;

	[Cpp2IlInjected.Token(Token = "0x4000065")]
	public static readonly ABKMJDCFONC AOKDNNAFLGL;

	[Cpp2IlInjected.Token(Token = "0x4000066")]
	public static readonly PLGCDPKBEBB PPGHGGMEBIM;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public bool CGCNKCIPCIA
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x71455F0", Offset = "0x71449F0", VA = "0x1871455F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x13A9E60", Offset = "0x13A9260", VA = "0x1813A9E60")]
	public ABKMJDCFONC(PLGCDPKBEBB BBDOLNPBNAO, OCCPNAOAPME GBMBJOKCOMI, PLGCDPKBEBB CEAHHHKCINP, OCCPNAOAPME PGODOIACDAJ, PLGCDPKBEBB KAELEHLGIKI, OCCPNAOAPME MJEJMNJIKBN, DMJEDAEBANK CJHEJCDIHLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x822D60", Offset = "0x822160", VA = "0x180822D60")]
	private static bool JEKAFGGNFEL()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490")]
	private static void HAJEDPGGMKH(string FHDJIGKOLJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x822D60", Offset = "0x822160", VA = "0x180822D60")]
	private static bool JEEHGADPEID()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490")]
	private static void MHEOHBJOKDN(string FHDJIGKOLJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x822D60", Offset = "0x822160", VA = "0x180822D60")]
	private static bool MDLOJIBMKMC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490")]
	private static void ABAHAIJCOGM(string FHDJIGKOLJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490")]
	private static void PDJHDDIFADG(Exception DEFKCOPBBKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x7145340", Offset = "0x7144740", VA = "0x187145340")]
	private static ABKMJDCFONC BCDNDNHIEEB()
	{
		return default(ABKMJDCFONC);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x823C20", Offset = "0x823020", VA = "0x180823C20")]
	private static bool PGPEEENFHEO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x7145580", Offset = "0x7144980", VA = "0x187145580")]
	public void JGFJHJADKIM(object FHDJIGKOLJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x7145480", Offset = "0x7144880", VA = "0x187145480")]
	public void DKPPJPJAMMM(object FHDJIGKOLJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x7145830", Offset = "0x7144C30", VA = "0x187145830")]
	public void JPCLODNKDFI(Exception DEFKCOPBBKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x71454F0", Offset = "0x71448F0", VA = "0x1871454F0")]
	public void DKPPJPJAMMM(FDJBDILJNKF FHDJIGKOLJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x15D91A0", Offset = "0x15D85A0", VA = "0x1815D91A0")]
	public void DKPPJPJAMMM<T>(T LBKPMPMCPAG, HNBHIEJEHPN<T> FHDJIGKOLJM) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x15D9220", Offset = "0x15D8620", VA = "0x1815D9220")]
	public void JGFJHJADKIM<T>(in T LBKPMPMCPAG, PIIGOBJBBHC<T> FHDJIGKOLJM) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x7145850", Offset = "0x7144C50", VA = "0x187145850")]
	public bool KHLENBEFBIO(bool IGGOFNKLKDD, string FHDJIGKOLJM)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public static class LGEBBBEAEJE
{
	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x21C07B0", Offset = "0x21BFBB0", VA = "0x1821C07B0")]
	public static IEnumerable<T> LPDKKOEOKMG<T>() where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x8C40A0", Offset = "0x8C34A0", VA = "0x1808C40A0")]
	public static T[] IJJEKHHCFKC<T>(params T[] MAKLLFPMKCD) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x8C40A0", Offset = "0x8C34A0", VA = "0x1808C40A0")]
	public static IEnumerable<T> LGLCGHBLNBG<T>(params T[] MAKLLFPMKCD) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x163D130", Offset = "0x163C530", VA = "0x18163D130")]
	public static HashSet<T> ALELODLIFCC<T>(params T[] MAKLLFPMKCD) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x2386F80", Offset = "0x2386380", VA = "0x182386F80")]
	public static KeyValuePair<TKey, TValue> IJIPNPBDBID<TKey, TValue>(in TKey PMMAAICOJOP, in TValue AGLCIEKHLEE) where TKey : notnull where TValue : notnull
	{
		return default(KeyValuePair<TKey, TValue>);
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x163D130", Offset = "0x163C530", VA = "0x18163D130")]
	public static List<T> HAFEFEKANIO<T>(IEnumerable<T> LEJDAGMDLDH) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
[AttributeUsage(AttributeTargets.All)]
public sealed class HDLDGNIEHAF : Attribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	public readonly string IOHGDIKBKML;

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0xA6EF70", Offset = "0xA6E370", VA = "0x180A6EF70")]
	public HDLDGNIEHAF(string ILPHELCGIDD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public static class DMNFMDGLNEP
{
	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x2C84290", Offset = "0x2C83690", VA = "0x182C84290")]
	public static AABPINMOHNN DPKBDBBFBDO<T>()
	{
		return default(AABPINMOHNN);
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x2C84040", Offset = "0x2C83440", VA = "0x182C84040")]
	public static AABPINMOHNN BFBBOKFHOIG<T>([CallerMemberName] string GDKOBCHHFLB = "") where T : notnull
	{
		return default(AABPINMOHNN);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x2C84320", Offset = "0x2C83720", VA = "0x182C84320")]
	public static AABPINMOHNN DPKBDBBFBDO<T>(this T PIALDONBLBA) where T : notnull
	{
		return default(AABPINMOHNN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x2C843B0", Offset = "0x2C837B0", VA = "0x182C843B0")]
	public static AABPINMOHNN PLMDMICINLE<T>(this T PIALDONBLBA, [CallerMemberName] string GDKOBCHHFLB = "") where T : notnull
	{
		return default(AABPINMOHNN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x2C840D0", Offset = "0x2C834D0", VA = "0x182C840D0")]
	public static AABPINMOHNN BFBBOKFHOIG<T>(this T ODBHDBFBMOB, [CallerMemberName] string GDKOBCHHFLB = "") where T : notnull
	{
		return default(AABPINMOHNN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x7146C10", Offset = "0x7146010", VA = "0x187146C10")]
	public static AABPINMOHNN BFBBOKFHOIG(string LKCKKIMKBEP, [CallerMemberName] string GDKOBCHHFLB = "")
	{
		return default(AABPINMOHNN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x7146C90", Offset = "0x7146090", VA = "0x187146C90")]
	public static string FILNIGLNABI(this object ODBHDBFBMOB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
[DPOBFNBLFMH]
public delegate long CNOOPCECPEE();
[Cpp2IlInjected.Token(Token = "0x2000022")]
public delegate void HOGJNOKFNKA<T>(in T LBKPMPMCPAG);
[Cpp2IlInjected.Token(Token = "0x2000023")]
public static class AKGAGIMMLGP
{
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private static EPLOLPPBFMO AFPMOLHDCHK;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public static EPLOLPPBFMO NFBLBBKNJCE
	{
		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x71460B0", Offset = "0x71454B0", VA = "0x1871460B0")]
		get
		{
			return default(EPLOLPPBFMO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public static ABKMJDCFONC ODFLOOHMOGI
	{
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x7146480", Offset = "0x7145880", VA = "0x187146480")]
		get
		{
			return default(ABKMJDCFONC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public static FANLNBOBJFD JNABJMBNIDK
	{
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x7146550", Offset = "0x7145950", VA = "0x187146550")]
		get
		{
			return default(FANLNBOBJFD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x7146110", Offset = "0x7145510", VA = "0x187146110")]
	public static void IHJJBPELJEC(in EPLOLPPBFMO KLFMIOGNGLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x7146270", Offset = "0x7145670", VA = "0x187146270")]
	public static void JGFJHJADKIM(string FHDJIGKOLJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x7145F80", Offset = "0x7145380", VA = "0x187145F80")]
	public static void DKPPJPJAMMM(string FHDJIGKOLJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x15E73F0", Offset = "0x15E67F0", VA = "0x1815E73F0")]
	public static void DKPPJPJAMMM<T>(T LBKPMPMCPAG, HNBHIEJEHPN<T> FHDJIGKOLJM) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x7146320", Offset = "0x7145720", VA = "0x187146320")]
	public static void JPCLODNKDFI(Exception DEFKCOPBBKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x7146030", Offset = "0x7145430", VA = "0x187146030")]
	public static string FILNIGLNABI(object HFAGBIOODHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x71464E0", Offset = "0x71458E0", VA = "0x1871464E0")]
	public static long NBEFKDOLFAO()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x71463A0", Offset = "0x71457A0", VA = "0x1871463A0")]
	public static bool KHLENBEFBIO(bool IGGOFNKLKDD, string FHDJIGKOLJM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x7145E90", Offset = "0x7145290", VA = "0x187145E90")]
	public static double DGMEJFJNFKB()
	{
		return default(double);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public class AFPIMDOKKGM : HEMECLGPDGP
{
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public static readonly HEMECLGPDGP FNGGPKJOCFE;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public DateTime PPBEOMMIAAP
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x7145D50", Offset = "0x7145150", VA = "0x187145D50", Slot = "4")]
		get
		{
			return default(DateTime);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80")]
	public AFPIMDOKKGM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
[AttributeUsage(AttributeTargets.Interface | AttributeTargets.Delegate)]
public class DPOBFNBLFMH : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x8CB040", Offset = "0x8CA440", VA = "0x1808CB040")]
	public DPOBFNBLFMH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public delegate TResult IEIGBGICOAC<T, out TResult>(in T LBKPMPMCPAG);
[Cpp2IlInjected.Token(Token = "0x2000027")]
public delegate TResult NFPKPCDNHMM<T1, T2, out TResult>(in T1 IFHDCDMOABL, in T2 JDNMJJOMOAK);
[Cpp2IlInjected.Token(Token = "0x2000028")]
public sealed class DPELCCMHLOC : HECCOAPKEEN, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	public static readonly TimeSpan HMNKOEJACBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private readonly System.Timers.Timer INJHLEJHFLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	private TimeSpan GKNKCKJFGCG;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public TimeSpan AGPHPFFIPPN
	{
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x823C10", Offset = "0x823010", VA = "0x180823C10", Slot = "4")]
		get
		{
			return default(TimeSpan);
		}
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x7146EE0", Offset = "0x71462E0", VA = "0x187146EE0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public Action? AEJAOKABKLL
	{
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x81F0B0", Offset = "0x81E4B0", VA = "0x18081F0B0", Slot = "11")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x8BBD20", Offset = "0x8BB120", VA = "0x1808BBD20", Slot = "6")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x7147100", Offset = "0x7146500", VA = "0x187147100")]
	[Preserve]
	public DPELCCMHLOC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x7147170", Offset = "0x7146570", VA = "0x187147170")]
	public DPELCCMHLOC(TimeSpan GKNKCKJFGCG, [Optional] Action? FCMOALNOCHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x7147030", Offset = "0x7146430", VA = "0x187147030", Slot = "7")]
	public void OPKOFIPIHJD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x7146EA0", Offset = "0x71462A0", VA = "0x187146EA0", Slot = "8")]
	public void MHJOFGEIPDB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x7146E70", Offset = "0x7146270", VA = "0x187146E70", Slot = "9")]
	public void KAEFBDOJFHE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x8BF920", Offset = "0x8BED20", VA = "0x1808BF920")]
	private void BDJEGKMJNFE(object PIALDONBLBA, ElapsedEventArgs KILINMNGHIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x7146D50", Offset = "0x7146150", VA = "0x187146D50")]
	private static void CFIEKNDBBMI(ref TimeSpan KEBDHGBGKHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x7146DD0", Offset = "0x71461D0", VA = "0x187146DD0", Slot = "10")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct)]
public class NPECACBIKJK : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x8CB040", Offset = "0x8CA440", VA = "0x1808CB040")]
	public NPECACBIKJK()
	{
	}
}
namespace RecRoom.NoEngine.Common
{
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	public class PreserveAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x8CB040", Offset = "0x8CA440", VA = "0x1808CB040")]
		public PreserveAttribute()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
[AttributeUsage(AttributeTargets.Method | AttributeTargets.Parameter)]
public class IKABEMBKOLE : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x8CB040", Offset = "0x8CA440", VA = "0x1808CB040")]
	public IKABEMBKOLE(string EHKONGBMOKG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public interface HEMECLGPDGP
{
	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	DateTime PPBEOMMIAAP
	{
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[StructLayout((LayoutKind)2)]
[Cpp2IlInjected.Token(Token = "0x200002D")]
[DebuggerDisplay("U32: {U32}, I32: {I32}, F32: {F32}, U16_0: {U16_0}, I16_1: {I16_1}, Char_0: '{Char_0}', Char_1: '{Char_1}', U8_0: {U8_0}, U8_1: {U8_1}, U8_2: {U8_2}, U8_3: {U8_3}, Bool_0: {Bool_0}, Bool_1: {Bool_1}, Bool_2: {Bool_2}, Bool_3: {Bool_3}")]
public struct GPCPBLECAGM : IEquatable<GPCPBLECAGM>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	public uint CMCPBFNFCOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	public int JPBOKNOEPGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	public float IOHFACKALMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	public ushort ILDHIFCGAGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	public ushort NDJHNMFIKGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	public short PEEDIIEKKBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	public short GMFFAPMMOMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	public char DHCNIPEEDFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	public char DKEFEAHIPDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	public byte KPJDNLONCNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	public byte KKLDGMFLLJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	public byte LFGGNBDGCEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	public byte HPIJPMFPMCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	public bool MMINJLBAOOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	public bool AFGMKEKAAKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	public bool EIIDLBFMGMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	public bool FMIPPFDNKNO;

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x1FACE80", Offset = "0x1FAC280", VA = "0x181FACE80")]
	public static GPCPBLECAGM HHBBNEFNOLK(uint MJNCHFBGNON)
	{
		return default(GPCPBLECAGM);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x1FACE80", Offset = "0x1FAC280", VA = "0x181FACE80")]
	public static GPCPBLECAGM BBLOJEAAGCM(int BOLJDNFMPOG)
	{
		return default(GPCPBLECAGM);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x7147EE0", Offset = "0x71472E0", VA = "0x187147EE0")]
	public static GPCPBLECAGM DOLFOHNIIFP(float OGBIMEHCGCF)
	{
		return default(GPCPBLECAGM);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x7147F80", Offset = "0x7147380", VA = "0x187147F80")]
	public static GPCPBLECAGM LNOGLFJPIAB(byte AHHODKCDCND, byte HOBBCPIJOGG, byte BBKKCNLNPHA, byte MBKHEPMPACF)
	{
		return default(GPCPBLECAGM);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x7147F80", Offset = "0x7147380", VA = "0x187147F80")]
	public static GPCPBLECAGM NMPCDCGHKDF(bool JBNHBAOOKCM, bool DMNKCMFMMNO, bool AKMFEBKCGFF, bool KHLJPMIMBKG)
	{
		return default(GPCPBLECAGM);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x542DA30", Offset = "0x542CE30", VA = "0x18542DA30")]
	public static bool PHJEMBLBEDF(GPCPBLECAGM CAOIKBDHEDK, GPCPBLECAGM ELHFHDBGEMK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x3DA53C0", Offset = "0x3DA47C0", VA = "0x183DA53C0", Slot = "4")]
	public bool Equals(GPCPBLECAGM ICELKIGIKKP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x7147EF0", Offset = "0x71472F0", VA = "0x187147EF0", Slot = "0")]
	public override bool Equals(object HFAGBIOODHL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x18F8710", Offset = "0x18F7B10", VA = "0x1818F8710", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x7147FA0", Offset = "0x71473A0", VA = "0x187147FA0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
[EFPBIFFAEEN("Now that `#nullable enable` is supported in our project, we should probably prefer that. The whole point of this type was to force checking before getting a value.`#nullable enable` can also force checking.")]
public readonly struct HEPMAEEBAEJ<T> : IEquatable<HEPMAEEBAEJ<T>> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	public readonly T EKGBCCDIAJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	public readonly bool LDMBJHFJNND;

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public bool FOFLCHEAGEG
	{
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x20791D0", Offset = "0x20785D0", VA = "0x1820791D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x20798E0", Offset = "0x2078CE0", VA = "0x1820798E0")]
	public HEPMAEEBAEJ(in T AGLCIEKHLEE, bool OHENPCHNGPI)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x20791E0", Offset = "0x20785E0", VA = "0x1820791E0")]
	public static bool PHJEMBLBEDF([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x71DA40", Offset = "0x71CE40")] in HEPMAEEBAEJ<T> FINJCDHFPJB, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x71DAB0", Offset = "0x71CEB0")] in HEPMAEEBAEJ<T> JHJGODIMNAF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x2078A80", Offset = "0x2077E80", VA = "0x182078A80", Slot = "4")]
	public bool Equals([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x71DB20", Offset = "0x71CF20")] HEPMAEEBAEJ<T> ICELKIGIKKP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x2078C80", Offset = "0x2078080", VA = "0x182078C80", Slot = "0")]
	public override bool Equals(object ICELKIGIKKP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x2078F50", Offset = "0x2078350", VA = "0x182078F50", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x20795E0", Offset = "0x20789E0", VA = "0x1820795E0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public static class NBCAIEDNKMK
{
	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x2400FF0", Offset = "0x24003F0", VA = "0x182400FF0")]
	public static HEPMAEEBAEJ<T> BKKBHJOCIAK<T>(in T AGLCIEKHLEE) where T : notnull
	{
		return default(HEPMAEEBAEJ<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x2401160", Offset = "0x2400560", VA = "0x182401160")]
	public static HEPMAEEBAEJ<T?> OEHECDJECAB<T>()
	{
		return default(HEPMAEEBAEJ<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x24010F0", Offset = "0x24004F0", VA = "0x1824010F0")]
	public static bool HNPLDFCAJBA<T>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x71DBC0", Offset = "0x71CFC0")] this in HEPMAEEBAEJ<T> CPPPAEPPJAG, [LOPEJNOEKCJ(true)] out T AGLCIEKHLEE) where T : notnull
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public interface GMDIBMAAGEJ<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool FCBBFOADOJJ(in T ICELKIGIKKP);
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public readonly struct FANLNBOBJFD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	public readonly FJNGMDMIEEK NDEJGECAING;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	public readonly OHHGAPNHIEN MBOOACOKNIN;

	[Cpp2IlInjected.Token(Token = "0x4000083")]
	public static readonly FJNGMDMIEEK INDGDGKAIGB;

	[Cpp2IlInjected.Token(Token = "0x4000084")]
	public static readonly OHHGAPNHIEN BMBIMHNEBON;

	[Cpp2IlInjected.Token(Token = "0x4000085")]
	public static readonly FANLNBOBJFD AOKDNNAFLGL;

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public bool CGCNKCIPCIA
	{
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x7147A80", Offset = "0x7146E80", VA = "0x187147A80")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0xD06A00", Offset = "0xD05E00", VA = "0x180D06A00")]
	public FANLNBOBJFD(FJNGMDMIEEK FCMMFHGOBAN, OHHGAPNHIEN OKLBDMNPCGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490")]
	private static void HIOLMEKDDCE(string GDKOBCHHFLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490")]
	private static void PKKGFEDMAFL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x71479F0", Offset = "0x7146DF0", VA = "0x1871479F0")]
	private static FANLNBOBJFD BCDNDNHIEEB()
	{
		return default(FANLNBOBJFD);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public static class IJGHPBIEECC
{
	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x1024DD0", Offset = "0x10241D0", VA = "0x181024DD0")]
	public static bool FCBBFOADOJJ<T, U>(in T ODBHDBFBMOB, in U HFAGBIOODHL) where T : notnull, GMDIBMAAGEJ<T> where U : notnull
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public sealed class BIBJDKPCHAA<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	private static readonly EqualityComparer<T> CIEBAFNHLJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	public T EKGBCCDIAJC;

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x2060C10", Offset = "0x2060010", VA = "0x182060C10")]
	public BIBJDKPCHAA(in T AGLCIEKHLEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x20600B0", Offset = "0x205F4B0", VA = "0x1820600B0", Slot = "0")]
	public override bool Equals(object HFAGBIOODHL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x20606B0", Offset = "0x205FAB0", VA = "0x1820606B0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x2060990", Offset = "0x205FD90", VA = "0x182060990", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public static class LEBPNIPHJOD
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public static long HKLHPEDMCOE
	{
		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x7149050", Offset = "0x7148450", VA = "0x187149050")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public static long LMNKBEOBEKG
	{
		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x7149110", Offset = "0x7148510", VA = "0x187149110")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public static double OFJJMDLPEDE
	{
		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x71490B0", Offset = "0x71484B0", VA = "0x1871490B0")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public static double IIAJHAKFACO
	{
		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x7149170", Offset = "0x7148570", VA = "0x187149170")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public static double BPHCGMGANEM
	{
		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x7148FF0", Offset = "0x71483F0", VA = "0x187148FF0")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public static double LIEINMJEFHJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x7149280", Offset = "0x7148680", VA = "0x187149280")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x71491D0", Offset = "0x71485D0", VA = "0x1871491D0")]
	public static double HJALEKHMIJN(long KINFGKGGBGJ)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x71492E0", Offset = "0x71486E0", VA = "0x1871492E0")]
	public static double KDLLHHEDPBA(long KINFGKGGBGJ)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x7149390", Offset = "0x7148790", VA = "0x187149390")]
	public static double KOPEPCDGOJG(double NAJLBNIBOJJ)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x7149440", Offset = "0x7148840", VA = "0x187149440")]
	public static long LBJIHIIFNJN(long KEGCBGNJKBP)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x71494F0", Offset = "0x71488F0", VA = "0x1871494F0")]
	public static long NHAMBMAHCMD(long PPNBOCGEKMM, long DMAKJFKPNIF)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x7149500", Offset = "0x7148900", VA = "0x187149500")]
	public static double PGACIEONGGH(long PPNBOCGEKMM, long DMAKJFKPNIF)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x7148F80", Offset = "0x7148380", VA = "0x187148F80")]
	public static double CNNOLHBLJBG(long PPNBOCGEKMM, long DMAKJFKPNIF)
	{
		return default(double);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public static class AODLBJFNJOG
{
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	private sealed class IGABDKHKOIO<T> : ISet<T>, ICollection<T>, IEnumerable<T>, IEnumerable where T : notnull
	{
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		public static readonly ISet<T> FNGGPKJOCFE;

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public int HIBMACOFNKK
		{
			[Cpp2IlInjected.Token(Token = "0x60000D9")]
			[Cpp2IlInjected.Address(RVA = "0x821EB0", Offset = "0x8212B0", VA = "0x180821EB0", Slot = "7")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public bool BAJNPCIAOLM
		{
			[Cpp2IlInjected.Token(Token = "0x60000DA")]
			[Cpp2IlInjected.Address(RVA = "0x823C20", Offset = "0x823020", VA = "0x180823C20", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x15D87D0", Offset = "0x15D7BD0", VA = "0x1815D87D0", Slot = "4")]
		public bool Add(T CFHFBNLLHPN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490", Slot = "6")]
		public void IntersectWith(IEnumerable<T> ICELKIGIKKP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x15D8980", Offset = "0x15D7D80", VA = "0x1815D8980", Slot = "5")]
		public void UnionWith(IEnumerable<T> ICELKIGIKKP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x15D8930", Offset = "0x15D7D30", VA = "0x1815D8930", Slot = "9")]
		void ICollection<T>.Add(T CFHFBNLLHPN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490", Slot = "10")]
		public void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x822D60", Offset = "0x822160", VA = "0x180822D60", Slot = "11")]
		public bool Contains(T CFHFBNLLHPN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490", Slot = "12")]
		public void CopyTo(T[] EACKPMFPNLH, int LKNMOMDDHBI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x822D60", Offset = "0x822160", VA = "0x180822D60", Slot = "13")]
		public bool Remove(T CFHFBNLLHPN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x15D8870", Offset = "0x15D7C70", VA = "0x1815D8870", Slot = "14")]
		public IEnumerator<T> GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x1306BC0", Offset = "0x1305FC0", VA = "0x181306BC0", Slot = "15")]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x92E880", Offset = "0x92DC80", VA = "0x18092E880")]
		public IGABDKHKOIO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x81F000", Offset = "0x81E400", VA = "0x18081F000")]
	public static ISet<T> JMJDMDPKILH<T>() where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
[DPOBFNBLFMH]
public delegate void OCCPNAOAPME(string FHDJIGKOLJM);
[Cpp2IlInjected.Token(Token = "0x2000038")]
[DPOBFNBLFMH]
public delegate string PGNMOIKIPNJ(object HFAGBIOODHL);
[Cpp2IlInjected.Token(Token = "0x2000039")]
[DPOBFNBLFMH]
public delegate void OHHGAPNHIEN();
[Cpp2IlInjected.Token(Token = "0x200003A")]
public delegate object PIIGOBJBBHC<T>(in T AIEGNLJMEEC);
[Cpp2IlInjected.Token(Token = "0x200003B")]
public delegate object FDJBDILJNKF();
[Cpp2IlInjected.Token(Token = "0x200003C")]
[DPOBFNBLFMH]
public delegate string AGCBMIFJODD(string OABFELNKNEB, string? CKIGCBDGMFI, bool EIOLCJIKMFI);
[Cpp2IlInjected.Token(Token = "0x200003D")]
[DPOBFNBLFMH]
public delegate bool PLGCDPKBEBB();
[Cpp2IlInjected.Token(Token = "0x200003E")]
public delegate object HNBHIEJEHPN<T>(T AIEGNLJMEEC);
[Cpp2IlInjected.Token(Token = "0x200003F")]
[DPOBFNBLFMH]
public delegate void FJNGMDMIEEK(string GDKOBCHHFLB);
[Cpp2IlInjected.Token(Token = "0x2000040")]
[DPOBFNBLFMH]
public delegate void DMJEDAEBANK(Exception DEFKCOPBBKE);
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
