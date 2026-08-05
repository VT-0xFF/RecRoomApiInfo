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
public interface NBFNIFIKEKM
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task NHODNMDMIHE(int HDNGPCOMJAA, CancellationToken JDDHIJBJNHP);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task NHODNMDMIHE(TimeSpan CKJEPJIMKEB, CancellationToken JDDHIJBJNHP);
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public class JKNGBKNGPEC : NBFNIFIKEKM
{
	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x828A560", Offset = "0x8289960", VA = "0x18828A560")]
	[ACPGCKDGGJH.EHOIKNIBKMA.DOIDFDFNIIB]
	internal static void MDKHJOIDCIP(NPCGGDCACLM INELJPKBMLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x9D3E50", Offset = "0x9D3250", VA = "0x1809D3E50")]
	[RecRoom.NoEngine.Common.Preserve]
	public JKNGBKNGPEC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x828A630", Offset = "0x8289A30", VA = "0x18828A630", Slot = "4")]
	public Task NHODNMDMIHE(int HDNGPCOMJAA, CancellationToken JDDHIJBJNHP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x828A5D0", Offset = "0x82899D0", VA = "0x18828A5D0", Slot = "5")]
	public Task NHODNMDMIHE(TimeSpan CKJEPJIMKEB, CancellationToken JDDHIJBJNHP)
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
		[Cpp2IlInjected.Address(RVA = "0x828AEB0", Offset = "0x828A2B0", VA = "0x18828AEB0", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x25D0340", Offset = "0x25CF740", VA = "0x1825D0340")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class FMJKCPMIGOG : ECLPMKOKGIJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private NIIIFLOLCGF KPEBOGPOPDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly CMGKKPHPKFI<bool> IEHEDGBABAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly CMGKKPHPKFI<bool> DACBHOPCBEK;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool GJPEFKNLNIN
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x828A420", Offset = "0x8289820", VA = "0x18828A420", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public bool AEKBBIDODLE
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x828A360", Offset = "0x8289760", VA = "0x18828A360", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x828A3B0", Offset = "0x82897B0", VA = "0x18828A3B0")]
	[ACPGCKDGGJH.EHOIKNIBKMA.DOIDFDFNIIB]
	internal static void MDKHJOIDCIP(NPCGGDCACLM INELJPKBMLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x828A470", Offset = "0x8289870", VA = "0x18828A470")]
	[RecRoom.NoEngine.Common.Preserve]
	public FMJKCPMIGOG([MGCCDFKFGBG(null)][NotNull] NIIIFLOLCGF KPEBOGPOPDO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public class NLGPJMOBEAM<TRequest, TResult> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	private struct EKPFDDJBJIL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public TRequest EONDIGCKHLE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public TaskCompletionSource<TResult> GLKIHGHLBJI;

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0xA813A0", Offset = "0xA807A0", VA = "0x180A813A0")]
		public EKPFDDJBJIL(TRequest LFFAIMMKIAM, TaskCompletionSource<TResult> BGBOPFLGEHK)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CompilerGenerated]
	private struct AEMEBLDODEC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public AsyncTaskMethodBuilder<TResult> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public NLGPJMOBEAM<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public TRequest request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private TaskAwaiter<TResult> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x48B0150", Offset = "0x48AF550", VA = "0x1848B0150", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x48B0690", Offset = "0x48AFA90", VA = "0x1848B0690", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private struct JAFPCECDKKD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public NLGPJMOBEAM<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x4C76460", Offset = "0x4C75860", VA = "0x184C76460", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x4C76850", Offset = "0x4C75C50", VA = "0x184C76850", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private struct PHGJHMPHJCO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public NLGPJMOBEAM<TRequest, TResult> <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x549D2F0", Offset = "0x549C6F0", VA = "0x18549D2F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x549D7B0", Offset = "0x549CBB0", VA = "0x18549D7B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private struct PODAENPLKLA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		public NLGPJMOBEAM<TRequest, TResult> <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x54C8860", Offset = "0x54C7C60", VA = "0x1854C8860", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x54C9AB0", Offset = "0x54C8EB0", VA = "0x1854C9AB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private readonly FGJLINKMKFI<TRequest, TResult> BCBBNCANFCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly float JKIHMEHAEHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly NBFNIFIKEKM AOLDFMKNPLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private readonly bool IMOHBADALEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly List<EKPFDDJBJIL> BPKGNGOJENJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private readonly List<EKPFDDJBJIL> PHDFJDLMNGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private bool PKJMGIFCMEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private readonly CancellationTokenSource IMFALBEABDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private CancellationTokenSource HNLINKJNCOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private Task BBICPEACMIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private float IBHKDHGBDFO;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public bool CMCDPHOIBJK
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x9CE390", Offset = "0x9CD790", VA = "0x1809CE390")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x9CE380", Offset = "0x9CD780", VA = "0x1809CE380")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x522C510", Offset = "0x522B910", VA = "0x18522C510")]
	public NLGPJMOBEAM(FGJLINKMKFI<TRequest, TResult> BCBBNCANFCN, TimeSpan JKIHMEHAEHC, bool IMOHBADALEJ, [Optional] NBFNIFIKEKM AOLDFMKNPLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x522BAA0", Offset = "0x522AEA0", VA = "0x18522BAA0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x522BD90", Offset = "0x522B190", VA = "0x18522BD90")]
	[AsyncStateMachine(typeof(NLGPJMOBEAM<, >.AEMEBLDODEC))]
	public Task<TResult> FGLIACCJCNB(TRequest LFFAIMMKIAM, [Optional] CancellationToken JDDHIJBJNHP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x522BCF0", Offset = "0x522B0F0", VA = "0x18522BCF0")]
	private void FGLIACCJCNB(TRequest LFFAIMMKIAM, TaskCompletionSource<TResult> BGBOPFLGEHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x522B9E0", Offset = "0x522ADE0", VA = "0x18522B9E0")]
	public Task DAPOIANPEFN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x522C260", Offset = "0x522B660", VA = "0x18522C260")]
	[AsyncStateMachine(typeof(NLGPJMOBEAM<, >.JAFPCECDKKD))]
	private Task LAGHAAPDECP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x522BFA0", Offset = "0x522B3A0", VA = "0x18522BFA0")]
	[AsyncStateMachine(typeof(NLGPJMOBEAM<, >.PHGJHMPHJCO))]
	private Task JFHPNPDMIDB(CancellationToken FJCLMLIAMID, CancellationToken DNJKKNDGMEJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x522C160", Offset = "0x522B560", VA = "0x18522C160")]
	[AsyncStateMachine(typeof(NLGPJMOBEAM<, >.PODAENPLKLA))]
	private Task KKPCDLPLJOC(CancellationToken JDDHIJBJNHP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x522BEC0", Offset = "0x522B2C0", VA = "0x18522BEC0")]
	private TimeSpan JABKGNKIEDO()
	{
		return default(TimeSpan);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x522C3F0", Offset = "0x522B7F0", VA = "0x18522C3F0")]
	private Task<List<TResult>> OJBLGPKLPHM(IReadOnlyList<TRequest> OBJMBPGIMHH, CancellationToken JDDHIJBJNHP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x522C0C0", Offset = "0x522B4C0", VA = "0x18522C0C0")]
	private float KABLAGHEOBL()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x522C340", Offset = "0x522B740", VA = "0x18522C340")]
	private void NBIFHCGJPGP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public class CFMKINDPHIN<TItemId, TResult> : FGJLINKMKFI<KMCMCAFPGAH<TItemId>, TResult> where TItemId : IEquatable<TItemId>
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public delegate Task<Dictionary<TItemId, TResult>> GOLCEDPAMKO(Dictionary<TItemId, int> OBJMBPGIMHH, CancellationToken JDDHIJBJNHP);

	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	private sealed class AKDFADOHIMG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		public Dictionary<TItemId, TResult> results;

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x9D3E50", Offset = "0x9D3250", VA = "0x1809D3E50")]
		public AKDFADOHIMG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x4BC3F60", Offset = "0x4BC3360", VA = "0x184BC3F60")]
		internal TResult MDIMJKLDDHJ(KMCMCAFPGAH<TItemId> r)
		{
			return (TResult)null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[CompilerGenerated]
	private struct GIMOIKBHPML : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		public AsyncTaskMethodBuilder<List<TResult>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public IReadOnlyList<KMCMCAFPGAH<TItemId>> requests;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public CFMKINDPHIN<TItemId, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private AKDFADOHIMG <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private TaskAwaiter<Dictionary<TItemId, TResult>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x48BCA60", Offset = "0x48BBE60", VA = "0x1848BCA60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x48BD870", Offset = "0x48BCC70", VA = "0x1848BD870", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private readonly GOLCEDPAMKO NLAHBJILJAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private readonly IEqualityComparer<TItemId> CIEFMHCOCHD;

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x6076B90", Offset = "0x6075F90", VA = "0x186076B90")]
	public CFMKINDPHIN(GOLCEDPAMKO NLAHBJILJAB, [Optional] IEqualityComparer<TItemId> CIEFMHCOCHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x646C060", Offset = "0x646B460", VA = "0x18646C060", Slot = "4")]
	[AsyncStateMachine(typeof(CFMKINDPHIN<, >.GIMOIKBHPML))]
	public Task<List<TResult>> NAEIGDHDHAJ(IReadOnlyList<KMCMCAFPGAH<TItemId>> OBJMBPGIMHH, CancellationToken JDDHIJBJNHP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public class BJGBPOFKMHA<TRequest, TResult> : FGJLINKMKFI<TRequest, TResult> where TRequest : IEquatable<TRequest>
{
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public delegate Task<List<TResult>> JBNEMOCGDIN(IEnumerable<TRequest> NEKLIAOKPCC, CancellationToken JDDHIJBJNHP);

	[Cpp2IlInjected.Token(Token = "0x2000015")]
	[CompilerGenerated]
	private sealed class IGJBMOBJPID
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public Dictionary<TRequest, TResult> requestResponseMap;

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x9D3E50", Offset = "0x9D3250", VA = "0x1809D3E50")]
		public IGJBMOBJPID()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x439E510", Offset = "0x439D910", VA = "0x18439E510")]
		internal TResult MDIMJKLDDHJ(TRequest request)
		{
			return (TResult)null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[CompilerGenerated]
	private struct LFLFHHKCBBM : IAsyncStateMachine
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
		public BJGBPOFKMHA<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private IGJBMOBJPID <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private List<TRequest> <distinctRequests>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private TaskAwaiter<List<TResult>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x4EB5190", Offset = "0x4EB4590", VA = "0x184EB5190", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x4EB60B0", Offset = "0x4EB54B0", VA = "0x184EB60B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private readonly JBNEMOCGDIN NLAHBJILJAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private readonly IEqualityComparer<TRequest> CIEFMHCOCHD;

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x6076B90", Offset = "0x6075F90", VA = "0x186076B90")]
	public BJGBPOFKMHA(JBNEMOCGDIN NLAHBJILJAB, [Optional] IEqualityComparer<TRequest> CIEFMHCOCHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x6076A40", Offset = "0x6075E40", VA = "0x186076A40", Slot = "4")]
	[AsyncStateMachine(typeof(BJGBPOFKMHA<, >.LFLFHHKCBBM))]
	public Task<List<TResult>> NAEIGDHDHAJ(IReadOnlyList<TRequest> OBJMBPGIMHH, CancellationToken JDDHIJBJNHP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface FGJLINKMKFI<TRequest, TResult>
{
	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<List<TResult>> NAEIGDHDHAJ(IReadOnlyList<TRequest> OBJMBPGIMHH, CancellationToken JDDHIJBJNHP);
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public class HEMKJIDANNB<TItemId, TResult> : FGJLINKMKFI<DLFDHAMMLOA<TItemId>, object> where TItemId : IEquatable<TItemId>
{
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public delegate Task MGKEMDLDJBM(IReadOnlyDictionary<TItemId, DLFDHAMMLOA<TItemId>.IAOIECANADJ> OBJMBPGIMHH, CancellationToken JDDHIJBJNHP);

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	[CompilerGenerated]
	private struct CKNDJLEMELH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public AsyncTaskMethodBuilder<List<object>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public HEMKJIDANNB<TItemId, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public IReadOnlyList<DLFDHAMMLOA<TItemId>> requests;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x662BD90", Offset = "0x662B190", VA = "0x18662BD90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x662C320", Offset = "0x662B720", VA = "0x18662C320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private readonly MGKEMDLDJBM CKOKDPEDDJC;

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x9D4E40", Offset = "0x9D4240", VA = "0x1809D4E40")]
	public HEMKJIDANNB(MGKEMDLDJBM CKOKDPEDDJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x491FF00", Offset = "0x491F300", VA = "0x18491FF00", Slot = "4")]
	[AsyncStateMachine(typeof(HEMKJIDANNB<, >.CKNDJLEMELH))]
	public Task<List<object>> NAEIGDHDHAJ(IReadOnlyList<DLFDHAMMLOA<TItemId>> OBJMBPGIMHH, CancellationToken JDDHIJBJNHP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x491FA60", Offset = "0x491EE60", VA = "0x18491FA60")]
	private IReadOnlyDictionary<TItemId, DLFDHAMMLOA<TItemId>.IAOIECANADJ> MFIKMOPNJBM(IReadOnlyList<DLFDHAMMLOA<TItemId>> GHNHJAIAPJJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class GMJLONAIDBA<TItemId, TResult> : FGJLINKMKFI<KMCMCAFPGAH<TItemId>, TResult> where TItemId : IEquatable<TItemId>
{
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public delegate Task<Dictionary<TItemId, TResult>> CDCKOPFJIAE(Dictionary<TItemId, int> OBJMBPGIMHH, CancellationToken JDDHIJBJNHP);

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[CompilerGenerated]
	private struct NLCKMAMFCDE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public AsyncTaskMethodBuilder<List<TResult>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public IReadOnlyList<KMCMCAFPGAH<TItemId>> requests;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public GMJLONAIDBA<TItemId, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		private TaskAwaiter<Dictionary<TItemId, TResult>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x5229490", Offset = "0x5228890", VA = "0x185229490", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x522A1B0", Offset = "0x52295B0", VA = "0x18522A1B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	private readonly CDCKOPFJIAE HJPJOIDCMAE;

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x9D4E40", Offset = "0x9D4240", VA = "0x1809D4E40")]
	public GMJLONAIDBA(CDCKOPFJIAE NLAHBJILJAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x48C8C40", Offset = "0x48C8040", VA = "0x1848C8C40", Slot = "4")]
	[AsyncStateMachine(typeof(GMJLONAIDBA<, >.NLCKMAMFCDE))]
	public Task<List<TResult>> NAEIGDHDHAJ(IReadOnlyList<KMCMCAFPGAH<TItemId>> OBJMBPGIMHH, CancellationToken JDDHIJBJNHP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public class HELLNLCNGGN<T> : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private Dictionary<string, BGKHLJCAAGH> MDMCCCEOFDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private List<T> EAKENBDHPCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private Func<IEnumerable<T>> JFPFCAKCDOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private Func<T, string> BLHDCAGKMFI;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public IReadOnlyDictionary<string, BGKHLJCAAGH> JPHJCLCDBFA
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x9C9460", Offset = "0x9C8860", VA = "0x1809C9460")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public IReadOnlyList<T> KGAJKHNMHOB
	{
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x9C9200", Offset = "0x9C8600", VA = "0x1809C9200")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public int OPACHKKHPKA
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0xBC4000", Offset = "0xBC3400", VA = "0x180BC4000")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0xC46200", Offset = "0xC45600", VA = "0x180C46200")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x491F8E0", Offset = "0x491ECE0", VA = "0x18491F8E0")]
	public HELLNLCNGGN(Func<IEnumerable<T>> JFPFCAKCDOG, Func<T, string> BLHDCAGKMFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x491F610", Offset = "0x491EA10", VA = "0x18491F610")]
	public void LFKOACHICEI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x491F580", Offset = "0x491E980", VA = "0x18491F580", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public class MEHJNEDEMEG<TItemId, TResult> : NLGPJMOBEAM<KMCMCAFPGAH<TItemId>, TResult> where TItemId : IEquatable<TItemId>
{
	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x48C2600", Offset = "0x48C1A00", VA = "0x1848C2600")]
	public MEHJNEDEMEG(FGJLINKMKFI<KMCMCAFPGAH<TItemId>, TResult> BCBBNCANFCN, TimeSpan JKIHMEHAEHC, bool IMOHBADALEJ, [Optional] NBFNIFIKEKM AOLDFMKNPLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x50B3030", Offset = "0x50B2430", VA = "0x1850B3030")]
	public Task<TResult> FGLIACCJCNB(TItemId IICGAABOENK, int MDJBHEDHFND, [Optional] CancellationToken JDDHIJBJNHP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public class KMCMCAFPGAH<TItemId> where TItemId : IEquatable<TItemId>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	public TItemId BHGAGKELPNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	public int OGGBFEJPBBE;

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x4E06D10", Offset = "0x4E06110", VA = "0x184E06D10")]
	public KMCMCAFPGAH(TItemId OFMELAFEMHB, int MDJBHEDHFND)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public interface PJDPJIPPEII<TResult>
{
	[Cpp2IlInjected.Token(Token = "0x17000009")]
	Guid NBHBLNGHIKI
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	Task<TResult> BCDCDCPAHDN
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public class PCCDDGINNGO : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	private interface HJMLCBHOMFI
	{
		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		int BKAJHPBFNOH
		{
			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		bool HINAPJKJAHD<TParam>(TParam OOEMJLHLIHJ);

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(Slot = "2")]
		bool LOHFHJLGCHC(Exception OHPACGAIPAF);

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(Slot = "3")]
		bool DJHGMHJPJKO();
	}

	[Cpp2IlInjected.Token(Token = "0x2000026")]
	private class GJDIDAGAOEG<TResult> : HJMLCBHOMFI, PJDPJIPPEII<TResult>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		private readonly TaskCompletionSource<TResult> CHBGNALCGDK;

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public Guid NBHBLNGHIKI
		{
			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0xEFF6E0", Offset = "0xEFEAE0", VA = "0x180EFF6E0", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public int BKAJHPBFNOH
		{
			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0xBC4000", Offset = "0xBC3400", VA = "0x180BC4000", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public Task<TResult> BCDCDCPAHDN
		{
			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0x48C0850", Offset = "0x48BFC50", VA = "0x1848C0850", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x48C08B0", Offset = "0x48BFCB0", VA = "0x1848C08B0")]
		public GJDIDAGAOEG(int LJHOEJLKFHL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x3AD70E0", Offset = "0x3AD64E0", VA = "0x183AD70E0", Slot = "5")]
		public bool HINAPJKJAHD<TParam>(TParam OOEMJLHLIHJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x48C07F0", Offset = "0x48BFBF0", VA = "0x1848C07F0", Slot = "6")]
		public bool LOHFHJLGCHC(Exception OHPACGAIPAF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x48C0790", Offset = "0x48BFB90", VA = "0x1848C0790", Slot = "7")]
		public bool DJHGMHJPJKO()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000061")]
	public const string OLBBLMOJIBN = "Remote player disconnected";

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private readonly Dictionary<Guid, HJMLCBHOMFI> IFKNMGDDPEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private readonly GJILHFEJHAA NIKDHJAGJCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private bool IOJIDPCJOJI;

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x828ADB0", Offset = "0x828A1B0", VA = "0x18828ADB0")]
	public PCCDDGINNGO([Optional] GJILHFEJHAA NIKDHJAGJCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x828A690", Offset = "0x8289A90", VA = "0x18828A690", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x38BDEE0", Offset = "0x38BD2E0", VA = "0x1838BDEE0")]
	public PJDPJIPPEII<TResult> PJFLEBFNLGO<TResult>(int PHEDFFKOLJP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x38BDB70", Offset = "0x38BCF70", VA = "0x1838BDB70")]
	public bool EMHKIIEPPHD<TResult>(Guid IAFOFMFFKIO, TResult APLCGCDLEGH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x828AC90", Offset = "0x828A090", VA = "0x18828AC90")]
	private void NDPCKKEDCEF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x828A690", Offset = "0x8289A90", VA = "0x18828A690")]
	private void BDCCEHDDECM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x828A7A0", Offset = "0x8289BA0", VA = "0x18828A7A0")]
	private void KNIFIPJDJBF(int LJHOEJLKFHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x828AA90", Offset = "0x8289E90", VA = "0x18828AA90")]
	private void MPILGGOFKKF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public enum FOJJHLKLEON
{
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	EQUIPMENT_SLOTS,
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	CV2_USE_INVENTORY_ITEM,
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	ROOM_INVENTORY_RRUI
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public class DLFDHAMMLOA<TItemId>
{
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public class IAOIECANADJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		public int ANFGAPLCEGJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		public int KBDNBACCBIC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public int FPJNHELAJBO;

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x9D3E50", Offset = "0x9D3250", VA = "0x1809D3E50")]
		public IAOIECANADJ()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	public TItemId BHGAGKELPNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	public int OGGBFEJPBBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	public FOJJHLKLEON IIPPGLOCPIB;

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x1DDB180", Offset = "0x1DDA580", VA = "0x181DDB180")]
	public DLFDHAMMLOA(TItemId OFMELAFEMHB, int MDJBHEDHFND, FOJJHLKLEON ILNONAAFECI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public class KNNHHMJFAHE<TItemId, TResult> : NLGPJMOBEAM<DLFDHAMMLOA<TItemId>, TResult> where TItemId : IEquatable<TItemId>
{
	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x4E154B0", Offset = "0x4E148B0", VA = "0x184E154B0")]
	public KNNHHMJFAHE(FGJLINKMKFI<DLFDHAMMLOA<TItemId>, TResult> BCBBNCANFCN, TimeSpan JKIHMEHAEHC, [Optional] NBFNIFIKEKM AOLDFMKNPLF)
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
