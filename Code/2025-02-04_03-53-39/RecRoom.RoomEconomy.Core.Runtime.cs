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
using RecRoom.DataLayer.Registration;
using RecRoom.NoEngine.Common;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface AGGOAABOFIO
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task DEIKBBEJPAO(int BFLNCHEGFBD, CancellationToken FEHCANHDGHE);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task DEIKBBEJPAO(TimeSpan HAMLPNGKHMH, CancellationToken FEHCANHDGHE);
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public class FAHIEFIJINE : AGGOAABOFIO
{
	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x798D790", Offset = "0x798C590", VA = "0x18798D790")]
	[FOLINPJCBJN.HMBDLNHFFEJ.EKAOCHOMHGE]
	internal static void LHLKGADJEGF(IEPIHLKICIO BCNFHKMHIOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x8FE490", Offset = "0x8FD290", VA = "0x1808FE490")]
	[RecRoom.NoEngine.Common.Preserve]
	public FAHIEFIJINE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x798D6D0", Offset = "0x798C4D0", VA = "0x18798D6D0", Slot = "4")]
	public Task DEIKBBEJPAO(int BFLNCHEGFBD, CancellationToken FEHCANHDGHE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x798D730", Offset = "0x798C530", VA = "0x18798D730", Slot = "5")]
	public Task DEIKBBEJPAO(TimeSpan HAMLPNGKHMH, CancellationToken FEHCANHDGHE)
	{
		return null;
	}
}
namespace _AssemblyRegistry.RecRoom_RoomEconomy_Core_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[CompilerGenerated]
	[RecRoom.DataLayer.Attributes.Preserve]
	public class _AssemblyIndex : AssemblyIndex
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x798D880", Offset = "0x798C680", VA = "0x18798D880", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x2408FF0", Offset = "0x2407DF0", VA = "0x182408FF0")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class CAGKLKOMBJK<TRequest, TResult> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	private struct ABPGJGOHHFO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public TRequest BNAIIDEPKCK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public TaskCompletionSource<TResult> DONNLBPMIDG;

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x956F00", Offset = "0x955D00", VA = "0x180956F00")]
		public ABPGJGOHHFO(TRequest HJFGAIAKKLJ, TaskCompletionSource<TResult> LHILFOPNIIF)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	private struct AOAHGLNHMGL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public AsyncTaskMethodBuilder<TResult> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public CAGKLKOMBJK<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public TRequest request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private TaskAwaiter<TResult> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x452B0F0", Offset = "0x4529EF0", VA = "0x18452B0F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x452B600", Offset = "0x452A400", VA = "0x18452B600", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CompilerGenerated]
	private struct HGCBJHMLLBA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public CAGKLKOMBJK<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x456EB90", Offset = "0x456D990", VA = "0x18456EB90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x456EF70", Offset = "0x456DD70", VA = "0x18456EF70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private struct EGICEOOOAAM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public CAGKLKOMBJK<TRequest, TResult> <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x3FDD7B0", Offset = "0x3FDC5B0", VA = "0x183FDD7B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x3FDDC60", Offset = "0x3FDCA60", VA = "0x183FDDC60", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CompilerGenerated]
	private struct OALEIEHBPGE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public CAGKLKOMBJK<TRequest, TResult> <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x4E1D050", Offset = "0x4E1BE50", VA = "0x184E1D050", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x4E1E200", Offset = "0x4E1D000", VA = "0x184E1E200", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private readonly EKKDNJPNFAI<TRequest, TResult> JCAPPOLMDMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly float KJBAFKOKIME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly AGGOAABOFIO HOEGACLAPEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private readonly bool FEOBCADGLEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly List<ABPGJGOHHFO> MIEKLIKJPMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly List<ABPGJGOHHFO> DDLBDLLFOKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private bool COPNDIFMIEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly CancellationTokenSource LIGBPAEPHHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private CancellationTokenSource DGDKNGGNJEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private Task EEKOONAOMFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private float PHNLKIDFNOA;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool OBOEGBKEDDJ
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x8F41D0", Offset = "0x8F2FD0", VA = "0x1808F41D0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x8F4400", Offset = "0x8F3200", VA = "0x1808F4400")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x576ACA0", Offset = "0x5769AA0", VA = "0x18576ACA0")]
	public CAGKLKOMBJK(EKKDNJPNFAI<TRequest, TResult> JCAPPOLMDMO, TimeSpan KJBAFKOKIME, bool FEOBCADGLEE, [Optional] AGGOAABOFIO HOEGACLAPEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x576A390", Offset = "0x5769190", VA = "0x18576A390", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x576A920", Offset = "0x5769720", VA = "0x18576A920")]
	[AsyncStateMachine(typeof(CAGKLKOMBJK<, >.AOAHGLNHMGL))]
	public Task<TResult> NFOEIFFBLOK(TRequest HJFGAIAKKLJ, [Optional] CancellationToken FEHCANHDGHE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x576A880", Offset = "0x5769680", VA = "0x18576A880")]
	private void NFOEIFFBLOK(TRequest HJFGAIAKKLJ, TaskCompletionSource<TResult> LHILFOPNIIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x576A2D0", Offset = "0x57690D0", VA = "0x18576A2D0")]
	public Task DNMPMMBGLIG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x576A5D0", Offset = "0x57693D0", VA = "0x18576A5D0")]
	[AsyncStateMachine(typeof(CAGKLKOMBJK<, >.HGCBJHMLLBA))]
	private Task GDFJAGDDMPG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x576AA40", Offset = "0x5769840", VA = "0x18576AA40")]
	[AsyncStateMachine(typeof(CAGKLKOMBJK<, >.EGICEOOOAAM))]
	private Task NGGKEBLLCAD(CancellationToken NGDCMIEFNBM, CancellationToken BGAKLKBOAKE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x576A6A0", Offset = "0x57694A0", VA = "0x18576A6A0")]
	[AsyncStateMachine(typeof(CAGKLKOMBJK<, >.OALEIEHBPGE))]
	private Task HLCHHJFOPCM(CancellationToken FEHCANHDGHE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x576A7A0", Offset = "0x57695A0", VA = "0x18576A7A0")]
	private TimeSpan LPEEHDPCEEI()
	{
		return default(TimeSpan);
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x576A1B0", Offset = "0x5768FB0", VA = "0x18576A1B0")]
	private Task<List<TResult>> ACDNCMIELBF(IReadOnlyList<TRequest> ANBIEBHOEKC, CancellationToken FEHCANHDGHE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x576AB60", Offset = "0x5769960", VA = "0x18576AB60")]
	private float NMODEPDNMEC()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x576AC00", Offset = "0x5769A00", VA = "0x18576AC00")]
	private void OECEJMBGMGN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public class EKOBDIFJIAI<TItemId, TResult> : EKKDNJPNFAI<DPFNABKGCHH<TItemId>, TResult> where TItemId : IEquatable<TItemId>
{
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public delegate Task<Dictionary<TItemId, TResult>> DGEPLBOLAAN(Dictionary<TItemId, int> ANBIEBHOEKC, CancellationToken FEHCANHDGHE);

	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[CompilerGenerated]
	private sealed class HKDAHCEKALD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		public Dictionary<TItemId, TResult> results;

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x8FE490", Offset = "0x8FD290", VA = "0x1808FE490")]
		public HKDAHCEKALD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x457F3B0", Offset = "0x457E1B0", VA = "0x18457F3B0")]
		internal TResult AKGMLDMOEGD(DPFNABKGCHH<TItemId> r)
		{
			return (TResult)null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[CompilerGenerated]
	private struct LDIDCOKLPAI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public AsyncTaskMethodBuilder<List<TResult>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public IReadOnlyList<DPFNABKGCHH<TItemId>> requests;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public EKOBDIFJIAI<TItemId, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private HKDAHCEKALD <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private TaskAwaiter<Dictionary<TItemId, TResult>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x4A78820", Offset = "0x4A77620", VA = "0x184A78820", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x4A79580", Offset = "0x4A78380", VA = "0x184A79580", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private readonly DGEPLBOLAAN IFBJLGPOEID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private readonly IEqualityComparer<TItemId> LKDCBGBNMHJ;

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x3F61C10", Offset = "0x3F60A10", VA = "0x183F61C10")]
	public EKOBDIFJIAI(DGEPLBOLAAN IFBJLGPOEID, [Optional] IEqualityComparer<TItemId> LKDCBGBNMHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x3FF60B0", Offset = "0x3FF4EB0", VA = "0x183FF60B0", Slot = "4")]
	[AsyncStateMachine(typeof(EKOBDIFJIAI<, >.LDIDCOKLPAI))]
	public Task<List<TResult>> NDDCDHFMAOC(IReadOnlyList<DPFNABKGCHH<TItemId>> ANBIEBHOEKC, CancellationToken FEHCANHDGHE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class EBBJAONKNKO<TRequest, TResult> : EKKDNJPNFAI<TRequest, TResult> where TRequest : IEquatable<TRequest>
{
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public delegate Task<List<TResult>> OAOFACJGCMI(IEnumerable<TRequest> HDFFLCGIMDO, CancellationToken FEHCANHDGHE);

	[Cpp2IlInjected.Token(Token = "0x2000014")]
	[CompilerGenerated]
	private sealed class BMGDDIHCFPO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public Dictionary<TRequest, TResult> requestResponseMap;

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x8FE490", Offset = "0x8FD290", VA = "0x1808FE490")]
		public BMGDDIHCFPO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x3FEB7B0", Offset = "0x3FEA5B0", VA = "0x183FEB7B0")]
		internal TResult AKGMLDMOEGD(TRequest request)
		{
			return (TResult)null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[CompilerGenerated]
	private struct NABCAHHDCLG : IAsyncStateMachine
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
		public EBBJAONKNKO<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		private BMGDDIHCFPO <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private List<TRequest> <distinctRequests>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private TaskAwaiter<List<TResult>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x4D14A90", Offset = "0x4D13890", VA = "0x184D14A90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x4D158F0", Offset = "0x4D146F0", VA = "0x184D158F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private readonly OAOFACJGCMI IFBJLGPOEID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private readonly IEqualityComparer<TRequest> LKDCBGBNMHJ;

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x3F61C10", Offset = "0x3F60A10", VA = "0x183F61C10")]
	public EBBJAONKNKO(OAOFACJGCMI IFBJLGPOEID, [Optional] IEqualityComparer<TRequest> LKDCBGBNMHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x3F61AD0", Offset = "0x3F608D0", VA = "0x183F61AD0", Slot = "4")]
	[AsyncStateMachine(typeof(EBBJAONKNKO<, >.NABCAHHDCLG))]
	public Task<List<TResult>> NDDCDHFMAOC(IReadOnlyList<TRequest> ANBIEBHOEKC, CancellationToken FEHCANHDGHE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public interface EKKDNJPNFAI<TRequest, TResult>
{
	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<List<TResult>> NDDCDHFMAOC(IReadOnlyList<TRequest> ANBIEBHOEKC, CancellationToken FEHCANHDGHE);
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class GIHBHCPKJMB<TItemId, TResult> : EKKDNJPNFAI<KHAGDIHDBIA<TItemId>, object> where TItemId : IEquatable<TItemId>
{
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public delegate Task EBNJEJBOEPL(IReadOnlyDictionary<TItemId, KHAGDIHDBIA<TItemId>.LDFMLOPPJBO> ANBIEBHOEKC, CancellationToken FEHCANHDGHE);

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[CompilerGenerated]
	private struct EEDHKDDLKIF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public AsyncTaskMethodBuilder<List<object>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public GIHBHCPKJMB<TItemId, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public IReadOnlyList<KHAGDIHDBIA<TItemId>> requests;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x3FA6610", Offset = "0x3FA5410", VA = "0x183FA6610", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x3FA6B70", Offset = "0x3FA5970", VA = "0x183FA6B70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	private readonly EBNJEJBOEPL MELBBPNMOII;

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x8FE740", Offset = "0x8FD540", VA = "0x1808FE740")]
	public GIHBHCPKJMB(EBNJEJBOEPL MELBBPNMOII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x44C3210", Offset = "0x44C2010", VA = "0x1844C3210", Slot = "4")]
	[AsyncStateMachine(typeof(GIHBHCPKJMB<, >.EEDHKDDLKIF))]
	public Task<List<object>> NDDCDHFMAOC(IReadOnlyList<KHAGDIHDBIA<TItemId>> ANBIEBHOEKC, CancellationToken FEHCANHDGHE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x44C2D90", Offset = "0x44C1B90", VA = "0x1844C2D90")]
	private IReadOnlyDictionary<TItemId, KHAGDIHDBIA<TItemId>.LDFMLOPPJBO> FEGPHPCOGNE(IReadOnlyList<KHAGDIHDBIA<TItemId>> LMICADEAACL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class NCPOFGGMIOH<TItemId, TResult> : EKKDNJPNFAI<DPFNABKGCHH<TItemId>, TResult> where TItemId : IEquatable<TItemId>
{
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	public delegate Task<Dictionary<TItemId, TResult>> PCCOFOBEPMM(Dictionary<TItemId, int> ANBIEBHOEKC, CancellationToken FEHCANHDGHE);

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[CompilerGenerated]
	private struct EMDBJNONBLN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public AsyncTaskMethodBuilder<List<TResult>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public IReadOnlyList<DPFNABKGCHH<TItemId>> requests;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public NCPOFGGMIOH<TItemId, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		private TaskAwaiter<Dictionary<TItemId, TResult>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x40020F0", Offset = "0x4000EF0", VA = "0x1840020F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x4002DB0", Offset = "0x4001BB0", VA = "0x184002DB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	private readonly PCCOFOBEPMM GPGIMILFDPO;

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x8FE740", Offset = "0x8FD540", VA = "0x1808FE740")]
	public NCPOFGGMIOH(PCCOFOBEPMM IFBJLGPOEID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x4D24400", Offset = "0x4D23200", VA = "0x184D24400", Slot = "4")]
	[AsyncStateMachine(typeof(NCPOFGGMIOH<, >.EMDBJNONBLN))]
	public Task<List<TResult>> NDDCDHFMAOC(IReadOnlyList<DPFNABKGCHH<TItemId>> ANBIEBHOEKC, CancellationToken FEHCANHDGHE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class EGLAHLIFOMP<T> : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private Dictionary<string, NNDGLBEAKFC> PJDHEOLJCAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private List<T> MOBIKBOCMPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private Func<IEnumerable<T>> DGANFEGFFBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private Func<T, string> ALKJEKBHJOM;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public IReadOnlyDictionary<string, NNDGLBEAKFC> LIIFCKGGANM
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x8F4460", Offset = "0x8F3260", VA = "0x1808F4460")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public IReadOnlyList<T> HKLHAMGIEAF
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x8F4430", Offset = "0x8F3230", VA = "0x1808F4430")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public int ECNBDJGCNHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0xAB5DD0", Offset = "0xAB4BD0", VA = "0x180AB5DD0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0xB4A980", Offset = "0xB49780", VA = "0x180B4A980")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x3FDE8E0", Offset = "0x3FDD6E0", VA = "0x183FDE8E0")]
	public EGLAHLIFOMP(Func<IEnumerable<T>> DGANFEGFFBA, Func<T, string> ALKJEKBHJOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x3FDE620", Offset = "0x3FDD420", VA = "0x183FDE620")]
	public void IGIPDIBMNHA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x3FDE590", Offset = "0x3FDD390", VA = "0x183FDE590", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public class BLAJMICFKCG<TItemId, TResult> : CAGKLKOMBJK<DPFNABKGCHH<TItemId>, TResult> where TItemId : IEquatable<TItemId>
{
	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x5679860", Offset = "0x5678660", VA = "0x185679860")]
	public BLAJMICFKCG(EKKDNJPNFAI<DPFNABKGCHH<TItemId>, TResult> JCAPPOLMDMO, TimeSpan KJBAFKOKIME, bool FEOBCADGLEE, [Optional] AGGOAABOFIO HOEGACLAPEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x56793B0", Offset = "0x56781B0", VA = "0x1856793B0")]
	public Task<TResult> NFOEIFFBLOK(TItemId FFOHLCGHDKA, int FDHKHEAGCEI, [Optional] CancellationToken FEHCANHDGHE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public class DPFNABKGCHH<TItemId> where TItemId : IEquatable<TItemId>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public TItemId CADEDKIAKND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public int JLMPJFJGPIF;

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x612DD80", Offset = "0x612CB80", VA = "0x18612DD80")]
	public DPFNABKGCHH(TItemId JAKPCLIAKMF, int FDHKHEAGCEI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public interface AMFMFEGPFGI<TResult>
{
	[Cpp2IlInjected.Token(Token = "0x17000007")]
	Guid GCOEJOABMDP
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	Task<TResult> CCDEOALEJHE
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public class EGJEAOKEOGD : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	private interface NOJPHBBHOJC
	{
		[Cpp2IlInjected.Token(Token = "0x17000009")]
		int CMGAGNNEJON
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		bool BACDDNGILEG<TParam>(TParam IPHILEOFJLB);

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(Slot = "2")]
		bool IIJEOMLOCIJ(Exception OMIBAPCKLFH);

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(Slot = "3")]
		bool HNILNGJDLHG();
	}

	[Cpp2IlInjected.Token(Token = "0x2000025")]
	private class JKDOIGJJKKB<TResult> : NOJPHBBHOJC, AMFMFEGPFGI<TResult>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		private readonly TaskCompletionSource<TResult> FCHHBDBKHLJ;

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public Guid GCOEJOABMDP
		{
			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0xB21E50", Offset = "0xB20C50", VA = "0x180B21E50", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public int CMGAGNNEJON
		{
			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0xAB5DD0", Offset = "0xAB4BD0", VA = "0x180AB5DD0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public Task<TResult> CCDEOALEJHE
		{
			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x48CB260", Offset = "0x48CA060", VA = "0x1848CB260", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x48CB350", Offset = "0x48CA150", VA = "0x1848CB350")]
		public JKDOIGJJKKB(int BGIEJKGGLPP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x35B4F70", Offset = "0x35B3D70", VA = "0x1835B4F70", Slot = "5")]
		public bool BACDDNGILEG<TParam>(TParam IPHILEOFJLB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x48CB300", Offset = "0x48CA100", VA = "0x1848CB300", Slot = "6")]
		public bool IIJEOMLOCIJ(Exception OMIBAPCKLFH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x48CB2B0", Offset = "0x48CA0B0", VA = "0x1848CB2B0", Slot = "7")]
		public bool HNILNGJDLHG()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400005E")]
	public const string ADJALGPGHBH = "Remote player disconnected";

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private readonly Dictionary<Guid, NOJPHBBHOJC> ADFLPFLOBCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private readonly GIBKNDJJJFP FNPCHIAGAIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private bool GLLKEMCINHO;

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x798D5D0", Offset = "0x798C3D0", VA = "0x18798D5D0")]
	public EGJEAOKEOGD([Optional] GIBKNDJJJFP FNPCHIAGAIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x798D3A0", Offset = "0x798C1A0", VA = "0x18798D3A0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x31693C0", Offset = "0x31681C0", VA = "0x1831693C0")]
	public AMFMFEGPFGI<TResult> NFAKGNLMGLE<TResult>(int EDCJEIFOODM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x3169050", Offset = "0x3167E50", VA = "0x183169050")]
	public bool EKBLBKGJAKO<TResult>(Guid KCDDPKBGHIL, TResult LDEANEOLAOA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x798D4B0", Offset = "0x798C2B0", VA = "0x18798D4B0")]
	private void LMCHCEMAINA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x798D3A0", Offset = "0x798C1A0", VA = "0x18798D3A0")]
	private void IPLABFPHIEM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x798CEC0", Offset = "0x798BCC0", VA = "0x18798CEC0")]
	private void DNPOFCKMLPB(int BGIEJKGGLPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x798D1A0", Offset = "0x798BFA0", VA = "0x18798D1A0")]
	private void DOGLPPJDAHB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public enum PCGBIFCIFPE
{
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	EQUIPMENT_SLOTS,
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	CV2_USE_INVENTORY_ITEM,
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	ROOM_INVENTORY_RRUI
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public class KHAGDIHDBIA<TItemId>
{
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public class LDFMLOPPJBO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public int CCKPGMPDBCL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public int OANFMHMOGOH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public int KHNMBINMJGE;

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x8FE490", Offset = "0x8FD290", VA = "0x1808FE490")]
		public LDFMLOPPJBO()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public TItemId CADEDKIAKND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	public int JLMPJFJGPIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	public PCGBIFCIFPE MENCOOOAIJP;

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x1BF04D0", Offset = "0x1BEF2D0", VA = "0x181BF04D0")]
	public KHAGDIHDBIA(TItemId JAKPCLIAKMF, int FDHKHEAGCEI, PCGBIFCIFPE EDLHCINOAKH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public class CMIEMBBMILL<TItemId, TResult> : CAGKLKOMBJK<KHAGDIHDBIA<TItemId>, TResult> where TItemId : IEquatable<TItemId>
{
	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x596CF40", Offset = "0x596BD40", VA = "0x18596CF40")]
	public CMIEMBBMILL(EKKDNJPNFAI<KHAGDIHDBIA<TItemId>, TResult> JCAPPOLMDMO, TimeSpan KJBAFKOKIME, [Optional] AGGOAABOFIO HOEGACLAPEC)
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
