using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using RecRoom.DataLayer.Attributes;
using RecRoom.NoEngine.Common;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface CJEGNMKBHPN
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task CENGOEIEFLI(int OHAHDFKOMDO, CancellationToken IONNNJNKLMJ);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task CENGOEIEFLI(TimeSpan CJOIGEMFBNI, CancellationToken IONNNJNKLMJ);
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public class KJJGJGMFDIN : CJEGNMKBHPN
{
	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x72D8390", Offset = "0x72D6D90", VA = "0x1872D8390")]
	[DJINMBCHLNM.LIHKMGLKGEL.LIKIBBIAMKP]
	internal static void ABFKOJMEBJE(JEFLJDHAGDI EOPOOELIKIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x8A32C0", Offset = "0x8A1CC0", VA = "0x1808A32C0")]
	[RecRoom.NoEngine.Common.Preserve]
	public KJJGJGMFDIN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x72D8490", Offset = "0x72D6E90", VA = "0x1872D8490", Slot = "4")]
	public Task CENGOEIEFLI(int OHAHDFKOMDO, CancellationToken IONNNJNKLMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x72D84F0", Offset = "0x72D6EF0", VA = "0x1872D84F0", Slot = "5")]
	public Task CENGOEIEFLI(TimeSpan CJOIGEMFBNI, CancellationToken IONNNJNKLMJ)
	{
		return null;
	}
}
namespace _AssemblyRegistry.RecRoom_RoomEconomy_Core_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[CompilerGenerated]
	[RecRoom.DataLayer.Attributes.Preserve]
	public class _AssemblyIndex : PBJLLMOALLO
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x72D8550", Offset = "0x72D6F50", VA = "0x1872D8550", Slot = "8")]
		public override void BHEMPDPJNII(CGCPPALGHJA registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x632F010", Offset = "0x632DA10", VA = "0x18632F010")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class DMAOGJEKEEM<TRequest, TResult> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	private struct AACALOHIGGI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public TRequest OLJLEKCKCBG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public TaskCompletionSource<TResult> PEEFPIPMMGL;

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0xD09E10", Offset = "0xD08810", VA = "0x180D09E10")]
		public AACALOHIGGI(TRequest NEKCFCOLDAN, TaskCompletionSource<TResult> CFGILIGCGBD)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	private struct JECEDOGGGLB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public AsyncTaskMethodBuilder<TResult> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public DMAOGJEKEEM<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public TRequest request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private TaskAwaiter<TResult> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x427CC50", Offset = "0x427B650", VA = "0x18427CC50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x3EEB3D0", Offset = "0x3EE9DD0", VA = "0x183EEB3D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CompilerGenerated]
	private struct HMOCPKCFEGE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public DMAOGJEKEEM<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x3F52900", Offset = "0x3F51300", VA = "0x183F52900", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x3F52CF0", Offset = "0x3F516F0", VA = "0x183F52CF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private struct MGBCAKGPHCH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public DMAOGJEKEEM<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public CancellationToken taskDelayCancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public CancellationToken outgoingRequestCancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x4769E70", Offset = "0x4768870", VA = "0x184769E70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x476A330", Offset = "0x4768D30", VA = "0x18476A330", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CompilerGenerated]
	private struct IHLLAAPMKCA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public DMAOGJEKEEM<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private List<TRequest> <requests>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private TaskAwaiter<List<TResult>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x408D220", Offset = "0x408BC20", VA = "0x18408D220", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x408E440", Offset = "0x408CE40", VA = "0x18408E440", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private readonly DPODCFIBAEI<TRequest, TResult> GCMDBMHGBNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly float ODJMAIPNNNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly CJEGNMKBHPN JMHNCEGLNMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private readonly bool BNLNKEHDNFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly List<AACALOHIGGI> JOODHKJJGIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly List<AACALOHIGGI> NIMMBAAFABM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private bool FMAKILLMOCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly CancellationTokenSource LCOKIHHFLFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private CancellationTokenSource MJCFFOJIEJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private Task DOIBELCFJLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private float AOEGMABFJHE;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool LEALCMGAHLN
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x899AE0", Offset = "0x8984E0", VA = "0x180899AE0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x899840", Offset = "0x898240", VA = "0x180899840")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x5B55E80", Offset = "0x5B54880", VA = "0x185B55E80")]
	public DMAOGJEKEEM(DPODCFIBAEI<TRequest, TResult> GCMDBMHGBNL, TimeSpan ODJMAIPNNNM, bool BNLNKEHDNFL, [Optional] CJEGNMKBHPN JMHNCEGLNMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x5B55540", Offset = "0x5B53F40", VA = "0x185B55540", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x5B55B90", Offset = "0x5B54590", VA = "0x185B55B90")]
	[AsyncStateMachine(typeof(DMAOGJEKEEM<, >.JECEDOGGGLB))]
	public Task<TResult> MAEIGFKIAJK(TRequest NEKCFCOLDAN, [Optional] CancellationToken IONNNJNKLMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x5B55AF0", Offset = "0x5B544F0", VA = "0x185B55AF0")]
	private void MAEIGFKIAJK(TRequest NEKCFCOLDAN, TaskCompletionSource<TResult> CFGILIGCGBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x5B55480", Offset = "0x5B53E80", VA = "0x185B55480")]
	public Task DPKKLGLKNIP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x5B55CC0", Offset = "0x5B546C0", VA = "0x185B55CC0")]
	[AsyncStateMachine(typeof(DMAOGJEKEEM<, >.HMOCPKCFEGE))]
	private Task OABKBPJOFNE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x5B55780", Offset = "0x5B54180", VA = "0x185B55780")]
	[AsyncStateMachine(typeof(DMAOGJEKEEM<, >.MGBCAKGPHCH))]
	private Task JAMFNMFKKOM(CancellationToken NDKNIJKACKL, CancellationToken NGKELEEIEOF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x5B559F0", Offset = "0x5B543F0", VA = "0x185B559F0")]
	[AsyncStateMachine(typeof(DMAOGJEKEEM<, >.IHLLAAPMKCA))]
	private Task LIPKCENDHPB(CancellationToken IONNNJNKLMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x5B55DA0", Offset = "0x5B547A0", VA = "0x185B55DA0")]
	private TimeSpan PPMFALIPNMK()
	{
		return default(TimeSpan);
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x5B55360", Offset = "0x5B53D60", VA = "0x185B55360")]
	private Task<List<TResult>> BBPHCCNGHCC(IReadOnlyList<TRequest> KPCGMGOBFKD, CancellationToken IONNNJNKLMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x5B55950", Offset = "0x5B54350", VA = "0x185B55950")]
	private float KGLCHJGDGEA()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x5B558A0", Offset = "0x5B542A0", VA = "0x185B558A0")]
	private void JHEOOOKEGKB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public class OACLADDBKID<TItemId, TResult> : DPODCFIBAEI<BAKJNNDGGBH<TItemId>, TResult> where TItemId : IEquatable<TItemId>
{
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public delegate Task<Dictionary<TItemId, TResult>> PCDGCBJDJDA(Dictionary<TItemId, int> KPCGMGOBFKD, CancellationToken IONNNJNKLMJ);

	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[CompilerGenerated]
	private sealed class GIJOKGILIBE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		public Dictionary<TItemId, TResult> results;

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x8A32C0", Offset = "0x8A1CC0", VA = "0x1808A32C0")]
		public GIJOKGILIBE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x3ED89D0", Offset = "0x3ED73D0", VA = "0x183ED89D0")]
		internal TResult FJIPILDAHPB(BAKJNNDGGBH<TItemId> r)
		{
			return (TResult)null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[CompilerGenerated]
	private struct JOEDGDALPMD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public AsyncTaskMethodBuilder<List<TResult>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public IReadOnlyList<BAKJNNDGGBH<TItemId>> requests;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public OACLADDBKID<TItemId, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private GIJOKGILIBE <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private TaskAwaiter<Dictionary<TItemId, TResult>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x43278D0", Offset = "0x43262D0", VA = "0x1843278D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x43286C0", Offset = "0x43270C0", VA = "0x1843286C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private readonly PCDGCBJDJDA FBNMCPAOAEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private readonly IEqualityComparer<TItemId> NBGPDLBENLO;

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x48DC900", Offset = "0x48DB300", VA = "0x1848DC900")]
	public OACLADDBKID(PCDGCBJDJDA FBNMCPAOAEM, [Optional] IEqualityComparer<TItemId> NBGPDLBENLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x48DC7B0", Offset = "0x48DB1B0", VA = "0x1848DC7B0", Slot = "4")]
	[AsyncStateMachine(typeof(OACLADDBKID<, >.JOEDGDALPMD))]
	public Task<List<TResult>> FJCEGOOKHDJ(IReadOnlyList<BAKJNNDGGBH<TItemId>> KPCGMGOBFKD, CancellationToken IONNNJNKLMJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class BAALDBMNKBD<TRequest, TResult> : DPODCFIBAEI<TRequest, TResult> where TRequest : IEquatable<TRequest>
{
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public delegate Task<List<TResult>> JIHPGOMFEIH(IEnumerable<TRequest> IIEHIGOJAEJ, CancellationToken IONNNJNKLMJ);

	[Cpp2IlInjected.Token(Token = "0x2000014")]
	[CompilerGenerated]
	private sealed class FMHCKBPHGGK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public Dictionary<TRequest, TResult> requestResponseMap;

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x8A32C0", Offset = "0x8A1CC0", VA = "0x1808A32C0")]
		public FMHCKBPHGGK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x3E0A9B0", Offset = "0x3E093B0", VA = "0x183E0A9B0")]
		internal TResult FJIPILDAHPB(TRequest request)
		{
			return (TResult)null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[CompilerGenerated]
	private struct HPANHMPOFED : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		public AsyncTaskMethodBuilder<List<TResult>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public IReadOnlyList<TRequest> requests;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public BAALDBMNKBD<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		private FMHCKBPHGGK <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private List<TRequest> <distinctRequests>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private TaskAwaiter<List<TResult>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x3F5A4F0", Offset = "0x3F58EF0", VA = "0x183F5A4F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x3F5B3F0", Offset = "0x3F59DF0", VA = "0x183F5B3F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private readonly JIHPGOMFEIH FBNMCPAOAEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private readonly IEqualityComparer<TRequest> NBGPDLBENLO;

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x48DC900", Offset = "0x48DB300", VA = "0x1848DC900")]
	public BAALDBMNKBD(JIHPGOMFEIH FBNMCPAOAEM, [Optional] IEqualityComparer<TRequest> NBGPDLBENLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x50FE5B0", Offset = "0x50FCFB0", VA = "0x1850FE5B0", Slot = "4")]
	[AsyncStateMachine(typeof(BAALDBMNKBD<, >.HPANHMPOFED))]
	public Task<List<TResult>> FJCEGOOKHDJ(IReadOnlyList<TRequest> KPCGMGOBFKD, CancellationToken IONNNJNKLMJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public interface DPODCFIBAEI<TRequest, TResult>
{
	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<List<TResult>> FJCEGOOKHDJ(IReadOnlyList<TRequest> KPCGMGOBFKD, CancellationToken IONNNJNKLMJ);
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class JMGIIOIELJO<TItemId, TResult> : DPODCFIBAEI<MHOFNOHIPNI<TItemId>, object> where TItemId : IEquatable<TItemId>
{
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public delegate Task DONNEHFCPFJ(IReadOnlyDictionary<TItemId, MHOFNOHIPNI<TItemId>.JJJDIKAEBCC> KPCGMGOBFKD, CancellationToken IONNNJNKLMJ);

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[CompilerGenerated]
	private struct PMLCDMFGMLE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public AsyncTaskMethodBuilder<List<object>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public JMGIIOIELJO<TItemId, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public IReadOnlyList<MHOFNOHIPNI<TItemId>> requests;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x4A07BE0", Offset = "0x4A065E0", VA = "0x184A07BE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x4A08160", Offset = "0x4A06B60", VA = "0x184A08160", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	private readonly DONNEHFCPFJ BJFAFEALKPA;

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x8962A0", Offset = "0x894CA0", VA = "0x1808962A0")]
	public JMGIIOIELJO(DONNEHFCPFJ BJFAFEALKPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x4323E50", Offset = "0x4322850", VA = "0x184323E50", Slot = "4")]
	[AsyncStateMachine(typeof(JMGIIOIELJO<, >.PMLCDMFGMLE))]
	public Task<List<object>> FJCEGOOKHDJ(IReadOnlyList<MHOFNOHIPNI<TItemId>> KPCGMGOBFKD, CancellationToken IONNNJNKLMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x4323F90", Offset = "0x4322990", VA = "0x184323F90")]
	private IReadOnlyDictionary<TItemId, MHOFNOHIPNI<TItemId>.JJJDIKAEBCC> IJOKCBIDFFB(IReadOnlyList<MHOFNOHIPNI<TItemId>> PELECNCGCGO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class OIJJIFDGOFK<TItemId, TResult> : DPODCFIBAEI<BAKJNNDGGBH<TItemId>, TResult> where TItemId : IEquatable<TItemId>
{
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	public delegate Task<Dictionary<TItemId, TResult>> NFLJPKIDMMN(Dictionary<TItemId, int> KPCGMGOBFKD, CancellationToken IONNNJNKLMJ);

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[CompilerGenerated]
	private struct EJLIKKFOMFD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public AsyncTaskMethodBuilder<List<TResult>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public IReadOnlyList<BAKJNNDGGBH<TItemId>> requests;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public OIJJIFDGOFK<TItemId, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		private TaskAwaiter<Dictionary<TItemId, TResult>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x3A37CD0", Offset = "0x3A366D0", VA = "0x183A37CD0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x3A396F0", Offset = "0x3A380F0", VA = "0x183A396F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	private readonly NFLJPKIDMMN KAPMJAOJJHO;

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x8962A0", Offset = "0x894CA0", VA = "0x1808962A0")]
	public OIJJIFDGOFK(NFLJPKIDMMN FBNMCPAOAEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x48FB7F0", Offset = "0x48FA1F0", VA = "0x1848FB7F0", Slot = "4")]
	[AsyncStateMachine(typeof(OIJJIFDGOFK<, >.EJLIKKFOMFD))]
	public Task<List<TResult>> FJCEGOOKHDJ(IReadOnlyList<BAKJNNDGGBH<TItemId>> KPCGMGOBFKD, CancellationToken IONNNJNKLMJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class NOLPAKGPJCP<T> : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private Dictionary<string, OKCGCELKKAL> KLNOMPBCHMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private List<T> DOCGOLBBECA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private Func<IEnumerable<T>> PNNJMBDKNCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private Func<T, string> PAELCPCDMHF;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public IReadOnlyDictionary<string, OKCGCELKKAL> MIMKNDLALFK
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x8961B0", Offset = "0x894BB0", VA = "0x1808961B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public IReadOnlyList<T> EIKCIPFOGMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x899050", Offset = "0x897A50", VA = "0x180899050")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public int IAGHIOGCOJM
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x941880", Offset = "0x940280", VA = "0x180941880")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x9D22F0", Offset = "0x9D0CF0", VA = "0x1809D22F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x4807050", Offset = "0x4805A50", VA = "0x184807050")]
	public NOLPAKGPJCP(Func<IEnumerable<T>> PNNJMBDKNCI, Func<T, string> PAELCPCDMHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x4806D80", Offset = "0x4805780", VA = "0x184806D80")]
	public void KOLHFLEMELG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x4806CF0", Offset = "0x48056F0", VA = "0x184806CF0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public class DOOIMCCIPBA<TItemId, TResult> : DMAOGJEKEEM<BAKJNNDGGBH<TItemId>, TResult> where TItemId : IEquatable<TItemId>
{
	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x432AA50", Offset = "0x4329450", VA = "0x18432AA50")]
	public DOOIMCCIPBA(DPODCFIBAEI<BAKJNNDGGBH<TItemId>, TResult> GCMDBMHGBNL, TimeSpan ODJMAIPNNNM, bool BNLNKEHDNFL, [Optional] CJEGNMKBHPN JMHNCEGLNMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x5B5CF70", Offset = "0x5B5B970", VA = "0x185B5CF70")]
	public Task<TResult> MAEIGFKIAJK(TItemId LFOBGDLOPID, int OGKJJPEBIOK, [Optional] CancellationToken IONNNJNKLMJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public class BAKJNNDGGBH<TItemId> where TItemId : IEquatable<TItemId>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public TItemId LKEJKFMKCKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public int OAMNCDNBFKA;

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x50FF190", Offset = "0x50FDB90", VA = "0x1850FF190")]
	public BAKJNNDGGBH(TItemId EAOAFMGNILC, int OGKJJPEBIOK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public interface OEHKPMPEBMC<TResult>
{
	[Cpp2IlInjected.Token(Token = "0x17000007")]
	Guid BJHFNHBAIOB
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	Task<TResult> KMEDLCHNELM
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public class HNJEJMNGEBK : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	private interface CIFCCDBPCKN
	{
		[Cpp2IlInjected.Token(Token = "0x17000009")]
		int AHMPLIOBMKJ
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		bool LJFNBAJLDLC<TParam>(TParam KLABJGGMBGH);

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(Slot = "2")]
		bool LLOLOEMNLCB(Exception FKDHFMCKMKA);

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(Slot = "3")]
		bool GBJJBODLGHP();
	}

	[Cpp2IlInjected.Token(Token = "0x2000025")]
	private class LIHCJGFDOMG<TResult> : CIFCCDBPCKN, OEHKPMPEBMC<TResult>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		private readonly TaskCompletionSource<TResult> NKDMIPFFBGD;

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public Guid BJHFNHBAIOB
		{
			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0xA13B20", Offset = "0xA12520", VA = "0x180A13B20", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public int AHMPLIOBMKJ
		{
			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x941880", Offset = "0x940280", VA = "0x180941880", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public Task<TResult> KMEDLCHNELM
		{
			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x44D41A0", Offset = "0x44D2BA0", VA = "0x1844D41A0", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x44D42C0", Offset = "0x44D2CC0", VA = "0x1844D42C0")]
		public LIHCJGFDOMG(int EMOGMMCICJL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x2D714E0", Offset = "0x2D6FEE0", VA = "0x182D714E0", Slot = "5")]
		public bool LJFNBAJLDLC<TParam>(TParam KLABJGGMBGH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x44D4260", Offset = "0x44D2C60", VA = "0x1844D4260", Slot = "6")]
		public bool LLOLOEMNLCB(Exception FKDHFMCKMKA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x44D4200", Offset = "0x44D2C00", VA = "0x1844D4200", Slot = "7")]
		public bool GBJJBODLGHP()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400005E")]
	public const string EJLPAGNJIAK = "Remote player disconnected";

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private readonly Dictionary<Guid, CIFCCDBPCKN> KIEBLPBOBDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private readonly ABCENOCDHAO FCACAMNOIHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private bool HNGJKNFNHOG;

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x72D8290", Offset = "0x72D6C90", VA = "0x1872D8290")]
	public HNJEJMNGEBK([Optional] ABCENOCDHAO FCACAMNOIHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x72D7E60", Offset = "0x72D6860", VA = "0x1872D7E60", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x2DE2D30", Offset = "0x2DE1730", VA = "0x182DE2D30")]
	public OEHKPMPEBMC<TResult> LNDEPFHNBFK<TResult>(int FDMLHJCKMBC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x2DE29C0", Offset = "0x2DE13C0", VA = "0x182DE29C0")]
	public bool CNEKOHCGNAB<TResult>(Guid FAOKHBLGHEO, TResult POBDLJBBBCI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x72D7F70", Offset = "0x72D6970", VA = "0x1872D7F70")]
	private void EDLCAPGHGAH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x72D7E60", Offset = "0x72D6860", VA = "0x1872D7E60")]
	private void LEJOFCGIEHP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x72D7B70", Offset = "0x72D6570", VA = "0x1872D7B70")]
	private void AABNEBJGOKD(int EMOGMMCICJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x72D8090", Offset = "0x72D6A90", VA = "0x1872D8090")]
	private void HHBGJDKKLDO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public enum DKKDKPCPBCG
{
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	EQUIPMENT_SLOTS,
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	CV2_USE_INVENTORY_ITEM,
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	ROOM_INVENTORY_RRUI
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public class MHOFNOHIPNI<TItemId>
{
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public class JJJDIKAEBCC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public int HJLIOIELFMJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public int NIACABNCNAN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public int OKIGALGFEPP;

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x8A32C0", Offset = "0x8A1CC0", VA = "0x1808A32C0")]
		public JJJDIKAEBCC()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public TItemId LKEJKFMKCKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	public int OAMNCDNBFKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	public DKKDKPCPBCG EOMCDGMOHLI;

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x164E420", Offset = "0x164CE20", VA = "0x18164E420")]
	public MHOFNOHIPNI(TItemId EAOAFMGNILC, int OGKJJPEBIOK, DKKDKPCPBCG MKLJJBDOOGE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public class PNJOLDFCPIN<TItemId, TResult> : DMAOGJEKEEM<MHOFNOHIPNI<TItemId>, TResult> where TItemId : IEquatable<TItemId>
{
	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x4A1DF20", Offset = "0x4A1C920", VA = "0x184A1DF20")]
	public PNJOLDFCPIN(DPODCFIBAEI<MHOFNOHIPNI<TItemId>, TResult> GCMDBMHGBNL, TimeSpan ODJMAIPNNNM, [Optional] CJEGNMKBHPN JMHNCEGLNMN)
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
