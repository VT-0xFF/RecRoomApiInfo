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
public interface PCFDOHACCDJ
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task NOPIAIIGCKK(int HKMEBDLJNJH, CancellationToken HIMDFBHMPLL);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task NOPIAIIGCKK(TimeSpan FGEHCLHENDH, CancellationToken HIMDFBHMPLL);
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public class CODFMMDCNEB : PCFDOHACCDJ
{
	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x88E4C40", Offset = "0x88E3A40", VA = "0x1888E4C40")]
	[ONLJNMLDJBD.KDDDMPKOLFO.GACHHHHOLBP]
	internal static void DKGNAIFEGAN(LOAHJOOKLEP CHDHLAGMCKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0xA5DEF0", Offset = "0xA5CCF0", VA = "0x180A5DEF0")]
	[RecRoom.NoEngine.Common.Preserve]
	public CODFMMDCNEB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x88E4D10", Offset = "0x88E3B10", VA = "0x1888E4D10", Slot = "4")]
	public Task NOPIAIIGCKK(int HKMEBDLJNJH, CancellationToken HIMDFBHMPLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x88E4CB0", Offset = "0x88E3AB0", VA = "0x1888E4CB0", Slot = "5")]
	public Task NOPIAIIGCKK(TimeSpan FGEHCLHENDH, CancellationToken HIMDFBHMPLL)
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
		[Cpp2IlInjected.Address(RVA = "0x88E5790", Offset = "0x88E4590", VA = "0x1888E5790", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x286F3E0", Offset = "0x286E1E0", VA = "0x18286F3E0")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class FNKCABJLOPI : CMDKPBENHLK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private BJBPLDNFCLM BDLEFGEKEMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly DEEMOICOGGP<bool> OEBBCBGNLEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly DEEMOICOGGP<bool> KAPFCLBDPKF;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool HFPNLEOKADC
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x88E5600", Offset = "0x88E4400", VA = "0x1888E5600", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public bool FGCDCHEFDPA
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x88E5650", Offset = "0x88E4450", VA = "0x1888E5650", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x88E5590", Offset = "0x88E4390", VA = "0x1888E5590")]
	[ONLJNMLDJBD.KDDDMPKOLFO.GACHHHHOLBP]
	internal static void DKGNAIFEGAN(LOAHJOOKLEP CHDHLAGMCKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x88E56A0", Offset = "0x88E44A0", VA = "0x1888E56A0")]
	[RecRoom.NoEngine.Common.Preserve]
	public FNKCABJLOPI([OLOAAHJODHH(null)][NotNull] BJBPLDNFCLM BDLEFGEKEMA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public class EIGBNAHEDDG<TRequest, TResult> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	private struct AHFHLNNHIDB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public TRequest LLACDHIICPL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public TaskCompletionSource<TResult> NOPPMHGFFJM;

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0xBC8270", Offset = "0xBC7070", VA = "0x180BC8270")]
		public AHFHLNNHIDB(TRequest OHNONCFAIKH, TaskCompletionSource<TResult> KPLLGNNGGHN)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CompilerGenerated]
	private struct EPEMEMHIEFF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public AsyncTaskMethodBuilder<TResult> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public EIGBNAHEDDG<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public TRequest request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private TaskAwaiter<TResult> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x4845A60", Offset = "0x4844860", VA = "0x184845A60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x4845F40", Offset = "0x4844D40", VA = "0x184845F40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private struct KPNJCMGAOKE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public EIGBNAHEDDG<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x536E2D0", Offset = "0x536D0D0", VA = "0x18536E2D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x536E6A0", Offset = "0x536D4A0", VA = "0x18536E6A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private struct GELFCLEKNHE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public EIGBNAHEDDG<TRequest, TResult> <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x4D7EA50", Offset = "0x4D7D850", VA = "0x184D7EA50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x4D7EEF0", Offset = "0x4D7DCF0", VA = "0x184D7EEF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private struct LAEKLIFJEJH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		public EIGBNAHEDDG<TRequest, TResult> <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x53F9070", Offset = "0x53F7E70", VA = "0x1853F9070", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x53FA190", Offset = "0x53F8F90", VA = "0x1853FA190", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private readonly JHKKKLOEGCC<TRequest, TResult> KJAOEKNIHDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly float LIAFEPIKJKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly PCFDOHACCDJ HEGIOABGJAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private readonly bool KNALBFLAKHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly List<AHFHLNNHIDB> GOIAKGBEOKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private readonly List<AHFHLNNHIDB> AOLEEHEJKPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private bool GPHEGCDHIHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private readonly CancellationTokenSource IADCIAKCLBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private CancellationTokenSource JKNMDMKNMHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private Task KHKLJJPFIMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private float BKJAEPBOJJL;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public bool DDMFODGPIEN
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0xA604D0", Offset = "0xA5F2D0", VA = "0x180A604D0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0xA605C0", Offset = "0xA5F3C0", VA = "0x180A605C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x4825260", Offset = "0x4824060", VA = "0x184825260")]
	public EIGBNAHEDDG(JHKKKLOEGCC<TRequest, TResult> KJAOEKNIHDD, TimeSpan LIAFEPIKJKE, bool KNALBFLAKHI, [Optional] PCFDOHACCDJ HEGIOABGJAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x48248C0", Offset = "0x48236C0", VA = "0x1848248C0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x4824C80", Offset = "0x4823A80", VA = "0x184824C80")]
	[AsyncStateMachine(typeof(EIGBNAHEDDG<, >.EPEMEMHIEFF))]
	public Task<TResult> GCJNGLKCKJI(TRequest OHNONCFAIKH, [Optional] CancellationToken HIMDFBHMPLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x4824DA0", Offset = "0x4823BA0", VA = "0x184824DA0")]
	private void GCJNGLKCKJI(TRequest OHNONCFAIKH, TaskCompletionSource<TResult> KPLLGNNGGHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x4824AE0", Offset = "0x48238E0", VA = "0x184824AE0")]
	public Task ELJEIOHFBID()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x4824BA0", Offset = "0x48239A0", VA = "0x184824BA0")]
	[AsyncStateMachine(typeof(EIGBNAHEDDG<, >.KPNJCMGAOKE))]
	private Task FOHKPNIAFIN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x4824FE0", Offset = "0x4823DE0", VA = "0x184824FE0")]
	[AsyncStateMachine(typeof(EIGBNAHEDDG<, >.GELFCLEKNHE))]
	private Task IFMOJGBJGBB(CancellationToken FOJJMIHMKNH, CancellationToken LCPDHLMHMDG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x48247C0", Offset = "0x48235C0", VA = "0x1848247C0")]
	[AsyncStateMachine(typeof(EIGBNAHEDDG<, >.LAEKLIFJEJH))]
	private Task AAEOCEKODPG(CancellationToken HIMDFBHMPLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x4825100", Offset = "0x4823F00", VA = "0x184825100")]
	private TimeSpan IJAGLBHOFAE()
	{
		return default(TimeSpan);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x4824E30", Offset = "0x4823C30", VA = "0x184824E30")]
	private Task<List<TResult>> HNNLGBFMCAC(IReadOnlyList<TRequest> AEACCKLIIMF, CancellationToken HIMDFBHMPLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x4824F40", Offset = "0x4823D40", VA = "0x184824F40")]
	private float HOEENODMFAE()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x48251D0", Offset = "0x4823FD0", VA = "0x1848251D0")]
	private void KJLBHEMPPLB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public class EIDGACKIHJG<TItemId, TResult> : JHKKKLOEGCC<OHAFPFOPHBP<TItemId>, TResult> where TItemId : IEquatable<TItemId>
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public delegate Task<Dictionary<TItemId, TResult>> OOPMGMNKNKJ(Dictionary<TItemId, int> AEACCKLIIMF, CancellationToken HIMDFBHMPLL);

	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	private sealed class FJPGOEPOCPA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		public Dictionary<TItemId, TResult> results;

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0xA5DEF0", Offset = "0xA5CCF0", VA = "0x180A5DEF0")]
		public FJPGOEPOCPA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x4CB9570", Offset = "0x4CB8370", VA = "0x184CB9570")]
		internal TResult FMJAHJDANGM(OHAFPFOPHBP<TItemId> r)
		{
			return (TResult)null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[CompilerGenerated]
	private struct NOBMFKDHAFP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		public AsyncTaskMethodBuilder<List<TResult>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public IReadOnlyList<OHAFPFOPHBP<TItemId>> requests;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public EIDGACKIHJG<TItemId, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private FJPGOEPOCPA <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private TaskAwaiter<Dictionary<TItemId, TResult>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x5711710", Offset = "0x5710510", VA = "0x185711710", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x5712460", Offset = "0x5711260", VA = "0x185712460", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private readonly OOPMGMNKNKJ IAOGFPKLFJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private readonly IEqualityComparer<TItemId> JPJEBIEBIKM;

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x4824730", Offset = "0x4823530", VA = "0x184824730")]
	public EIDGACKIHJG(OOPMGMNKNKJ IAOGFPKLFJE, [Optional] IEqualityComparer<TItemId> JPJEBIEBIKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x48245E0", Offset = "0x48233E0", VA = "0x1848245E0", Slot = "4")]
	[AsyncStateMachine(typeof(EIDGACKIHJG<, >.NOBMFKDHAFP))]
	public Task<List<TResult>> COILKCLNBNK(IReadOnlyList<OHAFPFOPHBP<TItemId>> AEACCKLIIMF, CancellationToken HIMDFBHMPLL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public class KDMOKFBMPEH<TRequest, TResult> : JHKKKLOEGCC<TRequest, TResult> where TRequest : IEquatable<TRequest>
{
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public delegate Task<List<TResult>> EEJLNDOAGNG(IEnumerable<TRequest> IMFHDPFBBGA, CancellationToken HIMDFBHMPLL);

	[Cpp2IlInjected.Token(Token = "0x2000015")]
	[CompilerGenerated]
	private sealed class CFMGKCIPBOK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public Dictionary<TRequest, TResult> requestResponseMap;

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0xA5DEF0", Offset = "0xA5CCF0", VA = "0x180A5DEF0")]
		public CFMGKCIPBOK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x4E1B350", Offset = "0x4E1A150", VA = "0x184E1B350")]
		internal TResult FMJAHJDANGM(TRequest request)
		{
			return (TResult)null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[CompilerGenerated]
	private struct EAIOHDPHOBP : IAsyncStateMachine
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
		public KDMOKFBMPEH<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private CFMGKCIPBOK <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private List<TRequest> <distinctRequests>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private TaskAwaiter<List<TResult>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x47FE480", Offset = "0x47FD280", VA = "0x1847FE480", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x47FF2B0", Offset = "0x47FE0B0", VA = "0x1847FF2B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private readonly EEJLNDOAGNG IAOGFPKLFJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private readonly IEqualityComparer<TRequest> JPJEBIEBIKM;

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x4824730", Offset = "0x4823530", VA = "0x184824730")]
	public KDMOKFBMPEH(EEJLNDOAGNG IAOGFPKLFJE, [Optional] IEqualityComparer<TRequest> JPJEBIEBIKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x52C3D00", Offset = "0x52C2B00", VA = "0x1852C3D00", Slot = "4")]
	[AsyncStateMachine(typeof(KDMOKFBMPEH<, >.EAIOHDPHOBP))]
	public Task<List<TResult>> COILKCLNBNK(IReadOnlyList<TRequest> AEACCKLIIMF, CancellationToken HIMDFBHMPLL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface JHKKKLOEGCC<TRequest, TResult>
{
	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<List<TResult>> COILKCLNBNK(IReadOnlyList<TRequest> AEACCKLIIMF, CancellationToken HIMDFBHMPLL);
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public class EDCLNMLPEPP<TItemId, TResult> : JHKKKLOEGCC<LBDPDGOPPPJ<TItemId>, object> where TItemId : IEquatable<TItemId>
{
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public delegate Task CEOPJHOAMNC(IReadOnlyDictionary<TItemId, LBDPDGOPPPJ<TItemId>.MMIKCIBDILO> AEACCKLIIMF, CancellationToken HIMDFBHMPLL);

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	[CompilerGenerated]
	private struct EPCHPCACKOI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public AsyncTaskMethodBuilder<List<object>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public EDCLNMLPEPP<TItemId, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public IReadOnlyList<LBDPDGOPPPJ<TItemId>> requests;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x48454C0", Offset = "0x48442C0", VA = "0x1848454C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x48459F0", Offset = "0x48447F0", VA = "0x1848459F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private readonly CEOPJHOAMNC LBBCKOFECKB;

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0xA665B0", Offset = "0xA653B0", VA = "0x180A665B0")]
	public EDCLNMLPEPP(CEOPJHOAMNC LBBCKOFECKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x480C240", Offset = "0x480B040", VA = "0x18480C240", Slot = "4")]
	[AsyncStateMachine(typeof(EDCLNMLPEPP<, >.EPCHPCACKOI))]
	public Task<List<object>> COILKCLNBNK(IReadOnlyList<LBDPDGOPPPJ<TItemId>> AEACCKLIIMF, CancellationToken HIMDFBHMPLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x480BDB0", Offset = "0x480ABB0", VA = "0x18480BDB0")]
	private IReadOnlyDictionary<TItemId, LBDPDGOPPPJ<TItemId>.MMIKCIBDILO> APNNKOJGJHG(IReadOnlyList<LBDPDGOPPPJ<TItemId>> BPJMAJCDMHI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class DGECNCKACKM<TItemId, TResult> : JHKKKLOEGCC<OHAFPFOPHBP<TItemId>, TResult> where TItemId : IEquatable<TItemId>
{
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public delegate Task<Dictionary<TItemId, TResult>> HCKJOLCDDHP(Dictionary<TItemId, int> AEACCKLIIMF, CancellationToken HIMDFBHMPLL);

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[CompilerGenerated]
	private struct OIGCHNAGAFG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public AsyncTaskMethodBuilder<List<TResult>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public IReadOnlyList<OHAFPFOPHBP<TItemId>> requests;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public DGECNCKACKM<TItemId, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		private TaskAwaiter<Dictionary<TItemId, TResult>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x5858930", Offset = "0x5857730", VA = "0x185858930", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x585A230", Offset = "0x5859030", VA = "0x18585A230", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	private readonly HCKJOLCDDHP FCJNNHEOJKN;

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0xA665B0", Offset = "0xA653B0", VA = "0x180A665B0")]
	public DGECNCKACKM(HCKJOLCDDHP IAOGFPKLFJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x6DDC130", Offset = "0x6DDAF30", VA = "0x186DDC130", Slot = "4")]
	[AsyncStateMachine(typeof(DGECNCKACKM<, >.OIGCHNAGAFG))]
	public Task<List<TResult>> COILKCLNBNK(IReadOnlyList<OHAFPFOPHBP<TItemId>> AEACCKLIIMF, CancellationToken HIMDFBHMPLL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public class NLEJCFIMJDA<T> : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private Dictionary<string, FEPMDMDELPI> MBHCANJIBAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private List<T> CIKCFAELFJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private Func<IEnumerable<T>> NKLNEPCEALD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private Func<T, string> EMKIBHLALME;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public IReadOnlyDictionary<string, FEPMDMDELPI> BKONHJMODGO
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0xA598A0", Offset = "0xA586A0", VA = "0x180A598A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public IReadOnlyList<T> CKKDNEMECOI
	{
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0xA59870", Offset = "0xA58670", VA = "0x180A59870")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public int HEJDHHNNFOL
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0xAAEA50", Offset = "0xAAD850", VA = "0x180AAEA50")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0xAAEA60", Offset = "0xAAD860", VA = "0x180AAEA60")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x570A100", Offset = "0x5708F00", VA = "0x18570A100")]
	public NLEJCFIMJDA(Func<IEnumerable<T>> NKLNEPCEALD, Func<T, string> EMKIBHLALME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x5709E80", Offset = "0x5708C80", VA = "0x185709E80")]
	public void FLCGEBIGNJN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x5709E10", Offset = "0x5708C10", VA = "0x185709E10", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public class GEIBIGOKNHM<TItemId, TResult> : EIGBNAHEDDG<OHAFPFOPHBP<TItemId>, TResult> where TItemId : IEquatable<TItemId>
{
	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x4D7EA20", Offset = "0x4D7D820", VA = "0x184D7EA20")]
	public GEIBIGOKNHM(JHKKKLOEGCC<OHAFPFOPHBP<TItemId>, TResult> KJAOEKNIHDD, TimeSpan LIAFEPIKJKE, bool KNALBFLAKHI, [Optional] PCFDOHACCDJ HEGIOABGJAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x4D7E770", Offset = "0x4D7D570", VA = "0x184D7E770")]
	public Task<TResult> GCJNGLKCKJI(TItemId MAHBBBBCDEL, int MFCGKLNJBDB, [Optional] CancellationToken HIMDFBHMPLL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public class OHAFPFOPHBP<TItemId> where TItemId : IEquatable<TItemId>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	public TItemId MOHBHNJGKND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	public int DNPHDJGLALO;

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x5857BE0", Offset = "0x58569E0", VA = "0x185857BE0")]
	public OHAFPFOPHBP(TItemId NENMJCEFFAO, int MFCGKLNJBDB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public interface GECDAJFIEAJ<TResult>
{
	[Cpp2IlInjected.Token(Token = "0x17000009")]
	Guid GGHLJDMBIIL
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	Task<TResult> PELEODOOCPG
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public class FNEKDCANECH : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	private interface LNCMBGBPLND
	{
		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		int MPBOFFCJKJB
		{
			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		bool BGBBFOPLJEE<TParam>(TParam BNECONOIKOE);

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(Slot = "2")]
		bool LJIJOEFNOEC(Exception OLHKHMAKOHL);

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(Slot = "3")]
		bool FIMBAOIOFOH();
	}

	[Cpp2IlInjected.Token(Token = "0x2000026")]
	private class CAFCNKOAHDF<TResult> : LNCMBGBPLND, GECDAJFIEAJ<TResult>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		private readonly TaskCompletionSource<TResult> HLJEBJIJODM;

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public Guid GGHLJDMBIIL
		{
			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0xE4BDD0", Offset = "0xE4ABD0", VA = "0x180E4BDD0", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public int MPBOFFCJKJB
		{
			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0xAAEA50", Offset = "0xAAD850", VA = "0x180AAEA50", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public Task<TResult> PELEODOOCPG
		{
			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0x56C36A0", Offset = "0x56C24A0", VA = "0x1856C36A0", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x66320A0", Offset = "0x6630EA0", VA = "0x1866320A0")]
		public CAFCNKOAHDF(int AADBDLCBGMP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x3F350C0", Offset = "0x3F33EC0", VA = "0x183F350C0", Slot = "5")]
		public bool BGBBFOPLJEE<TParam>(TParam BNECONOIKOE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x6632060", Offset = "0x6630E60", VA = "0x186632060", Slot = "6")]
		public bool LJIJOEFNOEC(Exception OLHKHMAKOHL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x6632020", Offset = "0x6630E20", VA = "0x186632020", Slot = "7")]
		public bool FIMBAOIOFOH()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000061")]
	public const string GAPMCFCPPBA = "Remote player disconnected";

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private readonly Dictionary<Guid, LNCMBGBPLND> GIAJOFCBCJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private readonly DOLGGPJDNFA PBMCFLOFCLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private bool HGENBLJJCLP;

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x88E5490", Offset = "0x88E4290", VA = "0x1888E5490")]
	public FNEKDCANECH([Optional] DOLGGPJDNFA PBMCFLOFCLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x88E5260", Offset = "0x88E4060", VA = "0x1888E5260", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x3B6B260", Offset = "0x3B6A060", VA = "0x183B6B260")]
	public GECDAJFIEAJ<TResult> COJBNNNBMPL<TResult>(int JJFBHOMIBFB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x3B6B500", Offset = "0x3B6A300", VA = "0x183B6B500")]
	public bool LKOPPFMIKML<TResult>(Guid ALEMANCBDEO, TResult OHLBIIOAJDL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x88E5370", Offset = "0x88E4170", VA = "0x1888E5370")]
	private void FEFBFMPNKKJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x88E5260", Offset = "0x88E4060", VA = "0x1888E5260")]
	private void NHAEGGEHMLF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x88E4D70", Offset = "0x88E3B70", VA = "0x1888E4D70")]
	private void CNGHBJPKBCK(int AADBDLCBGMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x88E5060", Offset = "0x88E3E60", VA = "0x1888E5060")]
	private void DLJDHIKDLIA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public enum BIBBMJOMLEI
{
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	EQUIPMENT_SLOTS,
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	CV2_USE_INVENTORY_ITEM,
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	ROOM_INVENTORY_RRUI
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public class LBDPDGOPPPJ<TItemId>
{
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public class MMIKCIBDILO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		public int EACIICLLHCB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		public int EKJGEJAGEKJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public int DODDIDMFLLI;

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0xA5DEF0", Offset = "0xA5CCF0", VA = "0x180A5DEF0")]
		public MMIKCIBDILO()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	public TItemId MOHBHNJGKND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	public int DNPHDJGLALO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	public BIBBMJOMLEI PLCLJPFLOHI;

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x2099960", Offset = "0x2098760", VA = "0x182099960")]
	public LBDPDGOPPPJ(TItemId NENMJCEFFAO, int MFCGKLNJBDB, BIBBMJOMLEI PBOOMELBCNJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public class AKAHMKHFBPL<TItemId, TResult> : EIGBNAHEDDG<LBDPDGOPPPJ<TItemId>, TResult> where TItemId : IEquatable<TItemId>
{
	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x50AFBB0", Offset = "0x50AE9B0", VA = "0x1850AFBB0")]
	public AKAHMKHFBPL(JHKKKLOEGCC<LBDPDGOPPPJ<TItemId>, TResult> KJAOEKNIHDD, TimeSpan LIAFEPIKJKE, [Optional] PCFDOHACCDJ HEGIOABGJAG)
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
