using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using RecRoom.DataLayer.Attributes;
using RecRoom.DataLayer.Registration;
using RecRoom.NoEngine.Common;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface NJLJCACGDMN
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task KFCKJEDLNFN(int BJKDBONLPFE, CancellationToken FHBCOAHILMJ);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task KFCKJEDLNFN(TimeSpan ECCMPIMOCBJ, CancellationToken FHBCOAHILMJ);
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public class OKGEHMGFGBP : NJLJCACGDMN
{
	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x84530D0", Offset = "0x84522D0", VA = "0x1884530D0")]
	[MGCKGAIBEHC.PCMIGKEOIEO.MAPPJIPMPIK]
	internal static void EFOCMBOIKDL(FJCFOKJAKFO MBLPEFIMNGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0xA07160", Offset = "0xA06360", VA = "0x180A07160")]
	[RecRoom.NoEngine.Common.Preserve]
	public OKGEHMGFGBP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x84531A0", Offset = "0x84523A0", VA = "0x1884531A0", Slot = "4")]
	public Task KFCKJEDLNFN(int BJKDBONLPFE, CancellationToken FHBCOAHILMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x8453140", Offset = "0x8452340", VA = "0x188453140", Slot = "5")]
	public Task KFCKJEDLNFN(TimeSpan ECCMPIMOCBJ, CancellationToken FHBCOAHILMJ)
	{
		return null;
	}
}
namespace _AssemblyRegistry.RecRoom_RoomEconomy_Core_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[RecRoom.DataLayer.Attributes.Preserve]
	[CompilerGenerated]
	public class _AssemblyIndex : AssemblyIndex
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x8453200", Offset = "0x8452400", VA = "0x188453200", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x274B560", Offset = "0x274A760", VA = "0x18274B560")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class MDGCLKBLMJH : JDKKLONLMJF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private BBFDHHPKPFP DKAHOLGLFHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly BAAGNFFPKHJ<bool> BGOIIBNKFME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly BAAGNFFPKHJ<bool> JPFEMPDHIFB;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool CILECEFDPLF
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x8452F40", Offset = "0x8452140", VA = "0x188452F40", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public bool PPALCLBLEGL
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x8452F90", Offset = "0x8452190", VA = "0x188452F90", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x8452ED0", Offset = "0x84520D0", VA = "0x188452ED0")]
	[MGCKGAIBEHC.PCMIGKEOIEO.MAPPJIPMPIK]
	internal static void EFOCMBOIKDL(FJCFOKJAKFO MBLPEFIMNGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x8452FE0", Offset = "0x84521E0", VA = "0x188452FE0")]
	[RecRoom.NoEngine.Common.Preserve]
	public MDGCLKBLMJH([NGLIAOPBMFM(null)][NotNull] BBFDHHPKPFP DKAHOLGLFHG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public class CBBPAAANFDJ<TRequest, TResult> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	private struct HAHJBBABLKC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public TRequest LGCFKMHHNDK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public TaskCompletionSource<TResult> MFIDLPIPDDE;

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0xB268B0", Offset = "0xB25AB0", VA = "0x180B268B0")]
		public HAHJBBABLKC(TRequest IKFDGIFGHKP, TaskCompletionSource<TResult> DKKCCOLBJGK)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CompilerGenerated]
	private struct GEJKPDMNJMJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public AsyncTaskMethodBuilder<TResult> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public CBBPAAANFDJ<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public TRequest request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private TaskAwaiter<TResult> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x4BFB350", Offset = "0x4BFA550", VA = "0x184BFB350", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x467C230", Offset = "0x467B430", VA = "0x18467C230", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private struct PLMLJAMJJFH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public CBBPAAANFDJ<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x5706110", Offset = "0x5705310", VA = "0x185706110", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x57064D0", Offset = "0x57056D0", VA = "0x1857064D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private struct EGAFHEEGLKO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public CBBPAAANFDJ<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public CancellationToken taskDelayCancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		public CancellationToken outgoingRequestCancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x46758A0", Offset = "0x4674AA0", VA = "0x1846758A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x4675D40", Offset = "0x4674F40", VA = "0x184675D40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private struct LMLPNFKDBFF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		public CBBPAAANFDJ<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private List<TRequest> <requests>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private TaskAwaiter<List<TResult>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x5229570", Offset = "0x5228770", VA = "0x185229570", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x522A5E0", Offset = "0x52297E0", VA = "0x18522A5E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private readonly ONIAJJFLJJO<TRequest, TResult> HMGOHCGFGIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly float HMHMBHGOLLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly NJLJCACGDMN GBBPKAPFBDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private readonly bool PBFGPLDPKOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly List<HAHJBBABLKC> MGHKNDPKALH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private readonly List<HAHJBBABLKC> DKEMKFCADGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private bool DPNPDOBEKGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private readonly CancellationTokenSource CEOCECGPAAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private CancellationTokenSource ICJCPLODKGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private Task AJKAMLIBCBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private float AMILNCJNHFO;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public bool OIFFEBPIEBO
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0xA0FD20", Offset = "0xA0EF20", VA = "0x180A0FD20")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0xA0FD30", Offset = "0xA0EF30", VA = "0x180A0FD30")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x65EE900", Offset = "0x65EDB00", VA = "0x1865EE900")]
	public CBBPAAANFDJ(ONIAJJFLJJO<TRequest, TResult> HMGOHCGFGIH, TimeSpan HMHMBHGOLLD, bool PBFGPLDPKOP, [Optional] NJLJCACGDMN GBBPKAPFBDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x65EDF70", Offset = "0x65ED170", VA = "0x1865EDF70", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x65EE370", Offset = "0x65ED570", VA = "0x1865EE370")]
	[AsyncStateMachine(typeof(CBBPAAANFDJ<, >.GEJKPDMNJMJ))]
	public Task<TResult> GNCNNALACEC(TRequest IKFDGIFGHKP, [Optional] CancellationToken FHBCOAHILMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x65EE490", Offset = "0x65ED690", VA = "0x1865EE490")]
	private void GNCNNALACEC(TRequest IKFDGIFGHKP, TaskCompletionSource<TResult> DKKCCOLBJGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x65EDEB0", Offset = "0x65ED0B0", VA = "0x1865EDEB0")]
	public Task ADMOGCJJFON()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x65EE640", Offset = "0x65ED840", VA = "0x1865EE640")]
	[AsyncStateMachine(typeof(CBBPAAANFDJ<, >.PLMLJAMJJFH))]
	private Task LBKBEMCNKLN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x65EE7E0", Offset = "0x65ED9E0", VA = "0x1865EE7E0")]
	[AsyncStateMachine(typeof(CBBPAAANFDJ<, >.EGAFHEEGLKO))]
	private Task PBKNDMCGJNA(CancellationToken KGOBOLCPEAJ, CancellationToken JDACJJKCBGL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x65EE170", Offset = "0x65ED370", VA = "0x1865EE170")]
	[AsyncStateMachine(typeof(CBBPAAANFDJ<, >.LMLPNFKDBFF))]
	private Task GCCMKNBPHLE(CancellationToken FHBCOAHILMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x65EE710", Offset = "0x65ED910", VA = "0x1865EE710")]
	private TimeSpan NKJLKEHMELO()
	{
		return default(TimeSpan);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x65EE270", Offset = "0x65ED470", VA = "0x1865EE270")]
	private Task<List<TResult>> GJAIACNIHGG(IReadOnlyList<TRequest> FLJIMAANFGD, CancellationToken FHBCOAHILMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x65EE5A0", Offset = "0x65ED7A0", VA = "0x1865EE5A0")]
	private float KCLLJHDDOGE()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x65EE510", Offset = "0x65ED710", VA = "0x1865EE510")]
	private void INECCPEMEMB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public class GICMNCDGMDK<TItemId, TResult> : ONIAJJFLJJO<IHHDGLAFADB<TItemId>, TResult> where TItemId : IEquatable<TItemId>
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public delegate Task<Dictionary<TItemId, TResult>> LOEBBCGINJG(Dictionary<TItemId, int> FLJIMAANFGD, CancellationToken FHBCOAHILMJ);

	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	private sealed class ADNKGDGPBEM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		public Dictionary<TItemId, TResult> results;

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0xA07160", Offset = "0xA06360", VA = "0x180A07160")]
		public ADNKGDGPBEM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x4E486C0", Offset = "0x4E478C0", VA = "0x184E486C0")]
		internal TResult EDCDNCNOKBN(IHHDGLAFADB<TItemId> r)
		{
			return (TResult)null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[CompilerGenerated]
	private struct MKBLCPKFDMJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		public AsyncTaskMethodBuilder<List<TResult>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public IReadOnlyList<IHHDGLAFADB<TItemId>> requests;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public GICMNCDGMDK<TItemId, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private ADNKGDGPBEM <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private TaskAwaiter<Dictionary<TItemId, TResult>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x5427210", Offset = "0x5426410", VA = "0x185427210", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x5427E90", Offset = "0x5427090", VA = "0x185427E90", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private readonly LOEBBCGINJG MADFFEDACHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private readonly IEqualityComparer<TItemId> PFCONGNHPEJ;

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x4C0B5A0", Offset = "0x4C0A7A0", VA = "0x184C0B5A0")]
	public GICMNCDGMDK(LOEBBCGINJG MADFFEDACHO, [Optional] IEqualityComparer<TItemId> PFCONGNHPEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x4C0B460", Offset = "0x4C0A660", VA = "0x184C0B460", Slot = "4")]
	[AsyncStateMachine(typeof(GICMNCDGMDK<, >.MKBLCPKFDMJ))]
	public Task<List<TResult>> NAPBNLCNLHH(IReadOnlyList<IHHDGLAFADB<TItemId>> FLJIMAANFGD, CancellationToken FHBCOAHILMJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public class JNDDNNFNCAK<TRequest, TResult> : ONIAJJFLJJO<TRequest, TResult> where TRequest : IEquatable<TRequest>
{
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public delegate Task<List<TResult>> MHKBBAGNJID(IEnumerable<TRequest> BJBPJLJOPHC, CancellationToken FHBCOAHILMJ);

	[Cpp2IlInjected.Token(Token = "0x2000015")]
	[CompilerGenerated]
	private sealed class PGNHDHIKKFJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public Dictionary<TRequest, TResult> requestResponseMap;

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0xA07160", Offset = "0xA06360", VA = "0x180A07160")]
		public PGNHDHIKKFJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x5044D90", Offset = "0x5043F90", VA = "0x185044D90")]
		internal TResult EDCDNCNOKBN(TRequest request)
		{
			return (TResult)null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[CompilerGenerated]
	private struct AJKOCBDJFKB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public AsyncTaskMethodBuilder<List<TResult>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public IReadOnlyList<TRequest> requests;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public JNDDNNFNCAK<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private PGNHDHIKKFJ <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private List<TRequest> <distinctRequests>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private TaskAwaiter<List<TResult>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x4F34110", Offset = "0x4F33310", VA = "0x184F34110", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x4F34E60", Offset = "0x4F34060", VA = "0x184F34E60", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private readonly MHKBBAGNJID MADFFEDACHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private readonly IEqualityComparer<TRequest> PFCONGNHPEJ;

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x4C0B5A0", Offset = "0x4C0A7A0", VA = "0x184C0B5A0")]
	public JNDDNNFNCAK(MHKBBAGNJID MADFFEDACHO, [Optional] IEqualityComparer<TRequest> PFCONGNHPEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x507D0E0", Offset = "0x507C2E0", VA = "0x18507D0E0", Slot = "4")]
	[AsyncStateMachine(typeof(JNDDNNFNCAK<, >.AJKOCBDJFKB))]
	public Task<List<TResult>> NAPBNLCNLHH(IReadOnlyList<TRequest> FLJIMAANFGD, CancellationToken FHBCOAHILMJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface ONIAJJFLJJO<TRequest, TResult>
{
	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<List<TResult>> NAPBNLCNLHH(IReadOnlyList<TRequest> FLJIMAANFGD, CancellationToken FHBCOAHILMJ);
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public class IEHJIJNENEP<TItemId, TResult> : ONIAJJFLJJO<FIHPJFGNEFE<TItemId>, object> where TItemId : IEquatable<TItemId>
{
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public delegate Task IPPKEBGNPAE(IReadOnlyDictionary<TItemId, FIHPJFGNEFE<TItemId>.CMELJEMCBIL> FLJIMAANFGD, CancellationToken FHBCOAHILMJ);

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	[CompilerGenerated]
	private struct POHNJGDOEFG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public AsyncTaskMethodBuilder<List<object>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public IEHJIJNENEP<TItemId, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public IReadOnlyList<FIHPJFGNEFE<TItemId>> requests;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x57094C0", Offset = "0x57086C0", VA = "0x1857094C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x57099B0", Offset = "0x5708BB0", VA = "0x1857099B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private readonly IPPKEBGNPAE EEJPNMJMPED;

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0xA0F6B0", Offset = "0xA0E8B0", VA = "0x180A0F6B0")]
	public IEHJIJNENEP(IPPKEBGNPAE EEJPNMJMPED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x4DDDDE0", Offset = "0x4DDCFE0", VA = "0x184DDDDE0", Slot = "4")]
	[AsyncStateMachine(typeof(IEHJIJNENEP<, >.POHNJGDOEFG))]
	public Task<List<object>> NAPBNLCNLHH(IReadOnlyList<FIHPJFGNEFE<TItemId>> FLJIMAANFGD, CancellationToken FHBCOAHILMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x4DDD980", Offset = "0x4DDCB80", VA = "0x184DDD980")]
	private IReadOnlyDictionary<TItemId, FIHPJFGNEFE<TItemId>.CMELJEMCBIL> BKNEDBENCCP(IReadOnlyList<FIHPJFGNEFE<TItemId>> PHEDEEFLPHJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class GNIFNDECNCB<TItemId, TResult> : ONIAJJFLJJO<IHHDGLAFADB<TItemId>, TResult> where TItemId : IEquatable<TItemId>
{
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public delegate Task<Dictionary<TItemId, TResult>> FBBBDBMENNP(Dictionary<TItemId, int> FLJIMAANFGD, CancellationToken FHBCOAHILMJ);

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[CompilerGenerated]
	private struct EFIENMNCAAC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public AsyncTaskMethodBuilder<List<TResult>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public IReadOnlyList<IHHDGLAFADB<TItemId>> requests;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public GNIFNDECNCB<TItemId, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		private TaskAwaiter<Dictionary<TItemId, TResult>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x4672C30", Offset = "0x4671E30", VA = "0x184672C30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x4673850", Offset = "0x4672A50", VA = "0x184673850", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	private readonly FBBBDBMENNP LAPMGPMLOGD;

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0xA0F6B0", Offset = "0xA0E8B0", VA = "0x180A0F6B0")]
	public GNIFNDECNCB(FBBBDBMENNP MADFFEDACHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x4C60740", Offset = "0x4C5F940", VA = "0x184C60740", Slot = "4")]
	[AsyncStateMachine(typeof(GNIFNDECNCB<, >.EFIENMNCAAC))]
	public Task<List<TResult>> NAPBNLCNLHH(IReadOnlyList<IHHDGLAFADB<TItemId>> FLJIMAANFGD, CancellationToken FHBCOAHILMJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public class FDBBJLOINDM<T> : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private Dictionary<string, EDAIBIHNMDK> IIFKKLHMFPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private List<T> DOFHLIDBCEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private Func<IEnumerable<T>> GJFCBHFLFJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private Func<T, string> EMEJKONCIHH;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public IReadOnlyDictionary<string, EDAIBIHNMDK> NGMDLFCEIDG
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0xA011A0", Offset = "0xA003A0", VA = "0x180A011A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public IReadOnlyList<T> JKOGEFFMONK
	{
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0xA00BA0", Offset = "0x9FFDA0", VA = "0x180A00BA0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public int IIKIEJGBAPE
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0xA67480", Offset = "0xA66680", VA = "0x180A67480")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0xCEC9C0", Offset = "0xCEBBC0", VA = "0x180CEC9C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x4B2ECF0", Offset = "0x4B2DEF0", VA = "0x184B2ECF0")]
	public FDBBJLOINDM(Func<IEnumerable<T>> GJFCBHFLFJH, Func<T, string> EMEJKONCIHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x4B2EAA0", Offset = "0x4B2DCA0", VA = "0x184B2EAA0")]
	public void KJFMNLEBHBJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x4B2EA30", Offset = "0x4B2DC30", VA = "0x184B2EA30", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public class CKMDLKMDMIA<TItemId, TResult> : CBBPAAANFDJ<IHHDGLAFADB<TItemId>, TResult> where TItemId : IEquatable<TItemId>
{
	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x4DADF90", Offset = "0x4DAD190", VA = "0x184DADF90")]
	public CKMDLKMDMIA(ONIAJJFLJJO<IHHDGLAFADB<TItemId>, TResult> HMGOHCGFGIH, TimeSpan HMHMBHGOLLD, bool PBFGPLDPKOP, [Optional] NJLJCACGDMN GBBPKAPFBDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x67D05E0", Offset = "0x67CF7E0", VA = "0x1867D05E0")]
	public Task<TResult> GNCNNALACEC(TItemId MHDODBCCAJB, int MIKCOPHLPJK, [Optional] CancellationToken FHBCOAHILMJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public class IHHDGLAFADB<TItemId> where TItemId : IEquatable<TItemId>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	public TItemId JEDAIOPDMBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	public int BAOBLBIIGKA;

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x4DECD10", Offset = "0x4DEBF10", VA = "0x184DECD10")]
	public IHHDGLAFADB(TItemId LNHCNANPEGB, int MIKCOPHLPJK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public interface PJMNFFPGCGE<TResult>
{
	[Cpp2IlInjected.Token(Token = "0x17000009")]
	Guid BKBCBLBMHGC
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	Task<TResult> IHKALMFJGDI
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public class BPOKLEGHBBP : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	private interface IKNNFBKOKFI
	{
		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		int OKNPLADIOFO
		{
			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		bool IFDFGDGPDAN<TParam>(TParam KJIOHKMJAPE);

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(Slot = "2")]
		bool MIDIFBOLLHD(Exception GMBDOBOLCOA);

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(Slot = "3")]
		bool AHCFMGFEOPG();
	}

	[Cpp2IlInjected.Token(Token = "0x2000026")]
	private class ODCGMLOOGCK<TResult> : IKNNFBKOKFI, PJMNFFPGCGE<TResult>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		private readonly TaskCompletionSource<TResult> EMLEFEFPNEJ;

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public Guid BKBCBLBMHGC
		{
			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0xD9D5F0", Offset = "0xD9C7F0", VA = "0x180D9D5F0", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public int OKNPLADIOFO
		{
			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0xA67480", Offset = "0xA66680", VA = "0x180A67480", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public Task<TResult> IHKALMFJGDI
		{
			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0x54654A0", Offset = "0x54646A0", VA = "0x1854654A0", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x560AF00", Offset = "0x560A100", VA = "0x18560AF00")]
		public ODCGMLOOGCK(int MFGHHELBNPL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x4169190", Offset = "0x4168390", VA = "0x184169190", Slot = "5")]
		public bool IFDFGDGPDAN<TParam>(TParam KJIOHKMJAPE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x560AEC0", Offset = "0x560A0C0", VA = "0x18560AEC0", Slot = "6")]
		public bool MIDIFBOLLHD(Exception GMBDOBOLCOA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x560AE80", Offset = "0x560A080", VA = "0x18560AE80", Slot = "7")]
		public bool AHCFMGFEOPG()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000061")]
	public const string BGKFLNMJHKM = "Remote player disconnected";

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private readonly Dictionary<Guid, IKNNFBKOKFI> KAFPFIKJAOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private readonly COLNEIINCGP PLFKEJEGLDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private bool NOJENLLMOGG;

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x8452DD0", Offset = "0x8451FD0", VA = "0x188452DD0")]
	public BPOKLEGHBBP([Optional] COLNEIINCGP PLFKEJEGLDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x84529A0", Offset = "0x8451BA0", VA = "0x1884529A0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x3791960", Offset = "0x3790B60", VA = "0x183791960")]
	public PJMNFFPGCGE<TResult> BMPNDADNOMK<TResult>(int GPHLHMHCIBL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x3791C00", Offset = "0x3790E00", VA = "0x183791C00")]
	public bool JBHNJDHBKLB<TResult>(Guid GHIHMOONOIF, TResult ACALKMLJJOL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x8452CB0", Offset = "0x8451EB0", VA = "0x188452CB0")]
	private void JGDKADLIFNN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x84529A0", Offset = "0x8451BA0", VA = "0x1884529A0")]
	private void INPGHCMJBJP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x84526B0", Offset = "0x84518B0", VA = "0x1884526B0")]
	private void CDLEGGIJBJP(int MFGHHELBNPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x8452AB0", Offset = "0x8451CB0", VA = "0x188452AB0")]
	private void IKDCJFFKOKI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public enum PPMIBJGIOCP
{
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	EQUIPMENT_SLOTS,
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	CV2_USE_INVENTORY_ITEM,
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	ROOM_INVENTORY_RRUI
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public class FIHPJFGNEFE<TItemId>
{
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public class CMELJEMCBIL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		public int EJJAILFAAIH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		public int OIFMHFJCIGG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public int OLBEOOBNKKL;

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0xA07160", Offset = "0xA06360", VA = "0x180A07160")]
		public CMELJEMCBIL()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	public TItemId JEDAIOPDMBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	public int BAOBLBIIGKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	public PPMIBJGIOCP CCGAMOFDCJM;

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x1F58E10", Offset = "0x1F58010", VA = "0x181F58E10")]
	public FIHPJFGNEFE(TItemId LNHCNANPEGB, int MIKCOPHLPJK, PPMIBJGIOCP MLMPPNLIAEF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public class INFNKDJIHKM<TItemId, TResult> : CBBPAAANFDJ<FIHPJFGNEFE<TItemId>, TResult> where TItemId : IEquatable<TItemId>
{
	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x4E01D20", Offset = "0x4E00F20", VA = "0x184E01D20")]
	public INFNKDJIHKM(ONIAJJFLJJO<FIHPJFGNEFE<TItemId>, TResult> HMGOHCGFGIH, TimeSpan HMHMBHGOLLD, [Optional] NJLJCACGDMN GBBPKAPFBDN)
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
