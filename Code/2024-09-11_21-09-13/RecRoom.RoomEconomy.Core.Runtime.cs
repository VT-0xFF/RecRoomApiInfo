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
	[Cpp2IlInjected.Address(RVA = "0x71ECE60", Offset = "0x71EB460", VA = "0x1871ECE60")]
	[DJINMBCHLNM.LIHKMGLKGEL.LIKIBBIAMKP]
	internal static void ABFKOJMEBJE(JEFLJDHAGDI EOPOOELIKIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x8912C0", Offset = "0x88F8C0", VA = "0x1808912C0")]
	[RecRoom.NoEngine.Common.Preserve]
	public KJJGJGMFDIN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x71ECF60", Offset = "0x71EB560", VA = "0x1871ECF60", Slot = "4")]
	public Task CENGOEIEFLI(int OHAHDFKOMDO, CancellationToken IONNNJNKLMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x71ECFC0", Offset = "0x71EB5C0", VA = "0x1871ECFC0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x71ED020", Offset = "0x71EB620", VA = "0x1871ED020", Slot = "8")]
		public override void BHEMPDPJNII(CGCPPALGHJA registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x624B890", Offset = "0x6249E90", VA = "0x18624B890")]
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
		[Cpp2IlInjected.Address(RVA = "0xC51880", Offset = "0xC4FE80", VA = "0x180C51880")]
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
		[Cpp2IlInjected.Address(RVA = "0x41A4AF0", Offset = "0x41A30F0", VA = "0x1841A4AF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x3DFD1D0", Offset = "0x3DFB7D0", VA = "0x183DFD1D0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x3E89AF0", Offset = "0x3E880F0", VA = "0x183E89AF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x3E89EE0", Offset = "0x3E884E0", VA = "0x183E89EE0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x4693520", Offset = "0x4691B20", VA = "0x184693520", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x46939E0", Offset = "0x4691FE0", VA = "0x1846939E0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x3FBCA80", Offset = "0x3FBB080", VA = "0x183FBCA80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x3FBDCA0", Offset = "0x3FBC2A0", VA = "0x183FBDCA0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x887AE0", Offset = "0x8860E0", VA = "0x180887AE0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x887840", Offset = "0x885E40", VA = "0x180887840")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x5A6D650", Offset = "0x5A6BC50", VA = "0x185A6D650")]
	public DMAOGJEKEEM(DPODCFIBAEI<TRequest, TResult> GCMDBMHGBNL, TimeSpan ODJMAIPNNNM, bool BNLNKEHDNFL, [Optional] CJEGNMKBHPN JMHNCEGLNMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x5A6CD10", Offset = "0x5A6B310", VA = "0x185A6CD10", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x5A6D360", Offset = "0x5A6B960", VA = "0x185A6D360")]
	[AsyncStateMachine(typeof(DMAOGJEKEEM<, >.JECEDOGGGLB))]
	public Task<TResult> MAEIGFKIAJK(TRequest NEKCFCOLDAN, [Optional] CancellationToken IONNNJNKLMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x5A6D2C0", Offset = "0x5A6B8C0", VA = "0x185A6D2C0")]
	private void MAEIGFKIAJK(TRequest NEKCFCOLDAN, TaskCompletionSource<TResult> CFGILIGCGBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x5A6CC50", Offset = "0x5A6B250", VA = "0x185A6CC50")]
	public Task DPKKLGLKNIP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x5A6D490", Offset = "0x5A6BA90", VA = "0x185A6D490")]
	[AsyncStateMachine(typeof(DMAOGJEKEEM<, >.HMOCPKCFEGE))]
	private Task OABKBPJOFNE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x5A6CF50", Offset = "0x5A6B550", VA = "0x185A6CF50")]
	[AsyncStateMachine(typeof(DMAOGJEKEEM<, >.MGBCAKGPHCH))]
	private Task JAMFNMFKKOM(CancellationToken NDKNIJKACKL, CancellationToken NGKELEEIEOF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x5A6D1C0", Offset = "0x5A6B7C0", VA = "0x185A6D1C0")]
	[AsyncStateMachine(typeof(DMAOGJEKEEM<, >.IHLLAAPMKCA))]
	private Task LIPKCENDHPB(CancellationToken IONNNJNKLMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x5A6D570", Offset = "0x5A6BB70", VA = "0x185A6D570")]
	private TimeSpan PPMFALIPNMK()
	{
		return default(TimeSpan);
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x5A6CB30", Offset = "0x5A6B130", VA = "0x185A6CB30")]
	private Task<List<TResult>> BBPHCCNGHCC(IReadOnlyList<TRequest> KPCGMGOBFKD, CancellationToken IONNNJNKLMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x5A6D120", Offset = "0x5A6B720", VA = "0x185A6D120")]
	private float KGLCHJGDGEA()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x5A6D070", Offset = "0x5A6B670", VA = "0x185A6D070")]
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
		[Cpp2IlInjected.Address(RVA = "0x8912C0", Offset = "0x88F8C0", VA = "0x1808912C0")]
		public GIJOKGILIBE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x3DEA730", Offset = "0x3DE8D30", VA = "0x183DEA730")]
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
		[Cpp2IlInjected.Address(RVA = "0x42550E0", Offset = "0x42536E0", VA = "0x1842550E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x4255ED0", Offset = "0x42544D0", VA = "0x184255ED0", Slot = "5")]
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
	[Cpp2IlInjected.Address(RVA = "0x4808970", Offset = "0x4806F70", VA = "0x184808970")]
	public OACLADDBKID(PCDGCBJDJDA FBNMCPAOAEM, [Optional] IEqualityComparer<TItemId> NBGPDLBENLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x4808820", Offset = "0x4806E20", VA = "0x184808820", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x8912C0", Offset = "0x88F8C0", VA = "0x1808912C0")]
		public FMHCKBPHGGK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x3D38690", Offset = "0x3D36C90", VA = "0x183D38690")]
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
		[Cpp2IlInjected.Address(RVA = "0x3E924D0", Offset = "0x3E90AD0", VA = "0x183E924D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x3E933D0", Offset = "0x3E919D0", VA = "0x183E933D0", Slot = "5")]
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
	[Cpp2IlInjected.Address(RVA = "0x4808970", Offset = "0x4806F70", VA = "0x184808970")]
	public BAALDBMNKBD(JIHPGOMFEIH FBNMCPAOAEM, [Optional] IEqualityComparer<TRequest> NBGPDLBENLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x501E450", Offset = "0x501CA50", VA = "0x18501E450", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x4930850", Offset = "0x492EE50", VA = "0x184930850", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x4930DD0", Offset = "0x492F3D0", VA = "0x184930DD0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	private readonly DONNEHFCPFJ BJFAFEALKPA;

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x8842A0", Offset = "0x8828A0", VA = "0x1808842A0")]
	public JMGIIOIELJO(DONNEHFCPFJ BJFAFEALKPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x42515A0", Offset = "0x424FBA0", VA = "0x1842515A0", Slot = "4")]
	[AsyncStateMachine(typeof(JMGIIOIELJO<, >.PMLCDMFGMLE))]
	public Task<List<object>> FJCEGOOKHDJ(IReadOnlyList<MHOFNOHIPNI<TItemId>> KPCGMGOBFKD, CancellationToken IONNNJNKLMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x42516E0", Offset = "0x424FCE0", VA = "0x1842516E0")]
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
		[Cpp2IlInjected.Address(RVA = "0x39633C0", Offset = "0x39619C0", VA = "0x1839633C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x3964DE0", Offset = "0x39633E0", VA = "0x183964DE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	private readonly NFLJPKIDMMN KAPMJAOJJHO;

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x8842A0", Offset = "0x8828A0", VA = "0x1808842A0")]
	public OIJJIFDGOFK(NFLJPKIDMMN FBNMCPAOAEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x4828530", Offset = "0x4826B30", VA = "0x184828530", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x8841B0", Offset = "0x8827B0", VA = "0x1808841B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public IReadOnlyList<T> EIKCIPFOGMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x887050", Offset = "0x885650", VA = "0x180887050")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public int IAGHIOGCOJM
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x8F5280", Offset = "0x8F3880", VA = "0x1808F5280")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x91F1E0", Offset = "0x91D7E0", VA = "0x18091F1E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x47309C0", Offset = "0x472EFC0", VA = "0x1847309C0")]
	public NOLPAKGPJCP(Func<IEnumerable<T>> PNNJMBDKNCI, Func<T, string> PAELCPCDMHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x47306F0", Offset = "0x472ECF0", VA = "0x1847306F0")]
	public void KOLHFLEMELG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x4730660", Offset = "0x472EC60", VA = "0x184730660", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public class DOOIMCCIPBA<TItemId, TResult> : DMAOGJEKEEM<BAKJNNDGGBH<TItemId>, TResult> where TItemId : IEquatable<TItemId>
{
	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x4258260", Offset = "0x4256860", VA = "0x184258260")]
	public DOOIMCCIPBA(DPODCFIBAEI<BAKJNNDGGBH<TItemId>, TResult> GCMDBMHGBNL, TimeSpan ODJMAIPNNNM, bool BNLNKEHDNFL, [Optional] CJEGNMKBHPN JMHNCEGLNMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x5A74720", Offset = "0x5A72D20", VA = "0x185A74720")]
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
	[Cpp2IlInjected.Address(RVA = "0x501F030", Offset = "0x501D630", VA = "0x18501F030")]
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
			[Cpp2IlInjected.Address(RVA = "0x96B660", Offset = "0x969C60", VA = "0x18096B660", Slot = "8")]
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
			[Cpp2IlInjected.Address(RVA = "0x8F5280", Offset = "0x8F3880", VA = "0x1808F5280", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x43FD2E0", Offset = "0x43FB8E0", VA = "0x1843FD2E0", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x43FD400", Offset = "0x43FBA00", VA = "0x1843FD400")]
		public LIHCJGFDOMG(int EMOGMMCICJL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x2C03AD0", Offset = "0x2C020D0", VA = "0x182C03AD0", Slot = "5")]
		public bool LJFNBAJLDLC<TParam>(TParam KLABJGGMBGH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x43FD3A0", Offset = "0x43FB9A0", VA = "0x1843FD3A0", Slot = "6")]
		public bool LLOLOEMNLCB(Exception FKDHFMCKMKA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x43FD340", Offset = "0x43FB940", VA = "0x1843FD340", Slot = "7")]
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
	[Cpp2IlInjected.Address(RVA = "0x71ECD60", Offset = "0x71EB360", VA = "0x1871ECD60")]
	public HNJEJMNGEBK([Optional] ABCENOCDHAO FCACAMNOIHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x71EC930", Offset = "0x71EAF30", VA = "0x1871EC930", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x2D03510", Offset = "0x2D01B10", VA = "0x182D03510")]
	public OEHKPMPEBMC<TResult> LNDEPFHNBFK<TResult>(int FDMLHJCKMBC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x2D031A0", Offset = "0x2D017A0", VA = "0x182D031A0")]
	public bool CNEKOHCGNAB<TResult>(Guid FAOKHBLGHEO, TResult POBDLJBBBCI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x71ECA40", Offset = "0x71EB040", VA = "0x1871ECA40")]
	private void EDLCAPGHGAH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x71EC930", Offset = "0x71EAF30", VA = "0x1871EC930")]
	private void LEJOFCGIEHP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x71EC640", Offset = "0x71EAC40", VA = "0x1871EC640")]
	private void AABNEBJGOKD(int EMOGMMCICJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x71ECB60", Offset = "0x71EB160", VA = "0x1871ECB60")]
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
		[Cpp2IlInjected.Address(RVA = "0x8912C0", Offset = "0x88F8C0", VA = "0x1808912C0")]
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
	[Cpp2IlInjected.Address(RVA = "0x1528B30", Offset = "0x1527130", VA = "0x181528B30")]
	public MHOFNOHIPNI(TItemId EAOAFMGNILC, int OGKJJPEBIOK, DKKDKPCPBCG MKLJJBDOOGE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public class PNJOLDFCPIN<TItemId, TResult> : DMAOGJEKEEM<MHOFNOHIPNI<TItemId>, TResult> where TItemId : IEquatable<TItemId>
{
	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x4945BB0", Offset = "0x49441B0", VA = "0x184945BB0")]
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
