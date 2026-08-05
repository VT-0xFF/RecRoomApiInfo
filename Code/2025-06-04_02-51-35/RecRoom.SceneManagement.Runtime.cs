using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using RecRoom;
using RecRoom.DataLayer.Attributes;
using RecRoom.DataLayer.Registration;
using RecRoom.Logging.Attributes;
using UnityEngine;
using UnityEngine.SceneManagement;

[assembly: AssemblyVersion("0.0.0.0")]
namespace _LogRegistration.RecRoom_SceneManagement_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[RecRoom.Logging.Attributes.Preserve]
	public class LogRegistrationIndex : HJMIPPBHOKP
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x8A8D700", Offset = "0x8A8BF00", VA = "0x188A8D700", Slot = "4")]
		public override void KELFLPPCOLM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xA530A0", Offset = "0xA518A0", VA = "0x180A530A0")]
		public LogRegistrationIndex()
		{
		}
	}
}
namespace _AssemblyRegistry.RecRoom_SceneManagement_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[CompilerGenerated]
	[RecRoom.DataLayer.Attributes.Preserve]
	public class _AssemblyIndex : AssemblyIndex
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private int[] localIndices0;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private ServiceBitset bitset0;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public override string[] ServiceCategories
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0xA2D3B0", Offset = "0xA2BBB0", VA = "0x180A2D3B0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x8157C30", Offset = "0x8156430", VA = "0x188157C30", Slot = "5")]
		public override void SetServiceCategoryIndices(List<int> globalFromLocalIndices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x8A8F610", Offset = "0x8A8DE10", VA = "0x188A8F610")]
		private void MBKOFANELHN(IServiceRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x8A8F850", Offset = "0x8A8E050", VA = "0x188A8F850", Slot = "6")]
		public override void RegisterServices(IServiceRegistration registry, [In] ServiceBitsetFilter filter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x8A8F8B0", Offset = "0x8A8E0B0", VA = "0x188A8F8B0")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
internal class EBDGHBNLFHM : LCAHIKGPJLN
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	internal bool GOOMPECIKJM
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0xA2D4D0", Offset = "0xA2BCD0", VA = "0x180A2D4D0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	internal DKKFAAJNJJM<string>.BNLIHIFJPDL HJFBAMEHGFC
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0xA2D3B0", Offset = "0xA2BBB0", VA = "0x180A2D3B0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	internal TaskCompletionSource<Scene> HHAMEJOGDJI
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xA2D380", Offset = "0xA2BB80", VA = "0x180A2D380")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x8A89F10", Offset = "0x8A88710", VA = "0x188A89F10")]
	internal EBDGHBNLFHM(string ANDNLMEHDMG, LoadSceneMode JDNBDAPOGAO, bool JBDNOPCAAAA, DKKFAAJNJJM<string>.BNLIHIFJPDL KFAFPJFMHGE, TaskCompletionSource<Scene> OGLNKIOCAJP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
internal class FMDICAHNDLL : LCAHIKGPJLN, NIGHPONAAAI
{
	[Cpp2IlInjected.Token(Token = "0x17000005")]
	internal Scene? LNMFHAJICNM
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0xA2EE60", Offset = "0xA2D660", VA = "0x180A2EE60")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0xD35E30", Offset = "0xD34630", VA = "0x180D35E30")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	internal AsyncOperation GNKJPHCDDCK
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0xA2D3B0", Offset = "0xA2BBB0", VA = "0x180A2D3B0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0xA2EE70", Offset = "0xA2D670", VA = "0x180A2EE70")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	internal bool NNGLMGOIPAI
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0xA56260", Offset = "0xA54A60", VA = "0x180A56260")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0xA56080", Offset = "0xA54880", VA = "0x180A56080")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x8A89F90", Offset = "0x8A88790", VA = "0x188A89F90", Slot = "4")]
	public bool KPMGHGDBBOK([Out] Scene? FBEGPGJFHFP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x8A8A010", Offset = "0x8A88810", VA = "0x188A8A010")]
	internal FMDICAHNDLL(string ANDNLMEHDMG, LoadSceneMode JDNBDAPOGAO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
internal abstract class LCAHIKGPJLN
{
	[Cpp2IlInjected.Token(Token = "0x17000008")]
	internal string NNGMOPAICNC
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0xA2D240", Offset = "0xA2BA40", VA = "0x180A2D240")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	internal FFEDNIECGJF NOGKKPLMKGM
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0xA32B80", Offset = "0xA31380", VA = "0x180A32B80")]
		[CompilerGenerated]
		get
		{
			return default(FFEDNIECGJF);
		}
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0xA32440", Offset = "0xA30C40", VA = "0x180A32440")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	internal LoadSceneMode GBPDMPPEGIO
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0xA513E0", Offset = "0xA4FBE0", VA = "0x180A513E0")]
		[CompilerGenerated]
		get
		{
			return default(LoadSceneMode);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x8A8D080", Offset = "0x8A8B880", VA = "0x188A8D080")]
	internal LCAHIKGPJLN(string ANDNLMEHDMG, LoadSceneMode JDNBDAPOGAO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public enum FFEDNIECGJF
{
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	Queued,
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	Loading,
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	Preloaded,
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	Activated
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
[RegisterService(typeof(IDHNMEIGPID), new string[] { })]
public class AAEGJBLCKOI : IDHNMEIGPID, FHLMMIDFMKJ, GOCAAFFABHB
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CompilerGenerated]
	private struct HEIOGNNBMMI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public AsyncTaskMethodBuilder<Scene> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public LoadSceneMode loadSceneMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public bool stopOnEmptyScene;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public DKKFAAJNJJM<string>.BNLIHIFJPDL stackTimerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public AAEGJBLCKOI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private DKKFAAJNJJM<string> <toDispose>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private TaskCompletionSource<Scene> <taskCompletionSource>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private TaskAwaiter<Scene> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x8A8A070", Offset = "0x8A88870", VA = "0x188A8A070", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x8A8AA10", Offset = "0x8A89210", VA = "0x188A8AA10", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private struct OEAOCIFAAIB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public AsyncTaskMethodBuilder<AsyncOperation> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public HOPLNFPLGEB request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private AsyncOperation <op>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private OGBIDEAJDEB <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x8A8EBE0", Offset = "0x8A8D3E0", VA = "0x188A8EBE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x8A8F4D0", Offset = "0x8A8DCD0", VA = "0x188A8F4D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private struct NJINLDNKCEJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		public AsyncTaskMethodBuilder<NIGHPONAAAI> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		public HOPLNFPLGEB request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		public AAEGJBLCKOI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private AsyncOperation <op>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private OGBIDEAJDEB <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x8A8E230", Offset = "0x8A8CA30", VA = "0x188A8E230", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x8A8EB70", Offset = "0x8A8D370", VA = "0x188A8EB70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CompilerGenerated]
	private struct AMJBHMEECHK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public AAEGJBLCKOI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x8A883B0", Offset = "0x8A86BB0", VA = "0x188A883B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x8A88640", Offset = "0x8A86E40", VA = "0x188A88640", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private struct KGEIDMNDJJA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public AAEGJBLCKOI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private EBDGHBNLFHM <queuedSceneLoad>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x8A8CD10", Offset = "0x8A8B510", VA = "0x188A8CD10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x8A8D020", Offset = "0x8A8B820", VA = "0x188A8D020", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private sealed class AKCNEKBLGLG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public EKAOCHBHLIC<Scene> promise;

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
		public AKCNEKBLGLG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x8A88350", Offset = "0x8A86B50", VA = "0x188A88350")]
		internal void NDOLOLGJOHJ()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[CompilerGenerated]
	private struct IDNGKLKLAOO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public AsyncTaskMethodBuilder<Scene> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public AAEGJBLCKOI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public EBDGHBNLFHM sceneLoadInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private DKKFAAJNJJM<string>.BNLIHIFJPDL <loadSceneTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private DKKFAAJNJJM<string>.BNLIHIFJPDL <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private DKKFAAJNJJM<string>.BNLIHIFJPDL <>7__wrap3;

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x8A8B300", Offset = "0x8A89B00", VA = "0x188A8B300", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x8A8C1B0", Offset = "0x8A8A9B0", VA = "0x188A8C1B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	private sealed class DPAHPFNPHGN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public EKAOCHBHLIC<Scene> onCompletePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public IDisposable sample;

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
		public DPAHPFNPHGN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x8A89E90", Offset = "0x8A88690", VA = "0x188A89E90")]
		internal bool KHLFAIPCOAD(Scene scene)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x8A89D30", Offset = "0x8A88530", VA = "0x188A89D30")]
		internal void DKDNIDKBMAD(Scene scene, LoadSceneMode mode)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[CompilerGenerated]
	private sealed class CFFMPOCMNFK : IEnumerator<ENGFNCJEKHI>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private ENGFNCJEKHI <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public EKAOCHBHLIC<Scene> onCompletePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public AAEGJBLCKOI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public LoadSceneMode loadSceneMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private DPAHPFNPHGN <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		private OGBIDEAJDEB <_>5__2;

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		private ENGFNCJEKHI System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0xA2B650", Offset = "0xA29E50", VA = "0x180A2B650", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0xA2B650", Offset = "0xA29E50", VA = "0x180A2B650", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0xA2B740", Offset = "0xA29F40", VA = "0x180A2B740")]
		[DebuggerHidden]
		public CFFMPOCMNFK(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x8A890C0", Offset = "0x8A878C0", VA = "0x188A890C0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x8A88BE0", Offset = "0x8A873E0", VA = "0x188A88BE0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x8A88BC0", Offset = "0x8A873C0", VA = "0x188A88BC0")]
		private void EGKKBNFIFOD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x8A89070", Offset = "0x8A87870", VA = "0x188A89070", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[CompilerGenerated]
	private struct CPFBPCCGPOM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public AsyncTaskMethodBuilder<Scene> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public DKKFAAJNJJM<string>.BNLIHIFJPDL stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public AAEGJBLCKOI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		private Scene <emptyScene>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		private DKKFAAJNJJM<string>.BNLIHIFJPDL <emptySceneRoutineTimer>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		private DKKFAAJNJJM<string>.BNLIHIFJPDL <emptySceneTimer>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x8A89120", Offset = "0x8A87920", VA = "0x188A89120", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x8A89CC0", Offset = "0x8A884C0", VA = "0x188A89CC0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private static readonly BMELPJIFPCL GLHOMCPEEHH;

	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private static readonly BMELPJIFPCL IKMLAEJFFCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private Task PABMMKNLDEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private List<EBDGHBNLFHM> LOOMCPGONJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private HOPLNFPLGEB KEEFCPHHLNL;

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event Action<string, LoadSceneMode> DPJHMKBHDMB
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x8A87D30", Offset = "0x8A86530", VA = "0x188A87D30", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x8A86550", Offset = "0x8A84D50", VA = "0x188A86550", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event Action DJGGAOIDDGH
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x8A87880", Offset = "0x8A86080", VA = "0x188A87880", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x8A87220", Offset = "0x8A85A20", VA = "0x188A87220", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x8A87920", Offset = "0x8A86120", VA = "0x188A87920", Slot = "12")]
	public void InitReferences(OBECFEHHJHL NOKFLPEFADE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x8A88130", Offset = "0x8A86930", VA = "0x188A88130", Slot = "13")]
	public void ShutdownReferences()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x8A86500", Offset = "0x8A84D00", VA = "0x188A86500", Slot = "8")]
	public void ABKLJDGJIPJ(LoadSceneMode JDNBDAPOGAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x8A87DE0", Offset = "0x8A865E0", VA = "0x188A87DE0", Slot = "9")]
	[AsyncStateMachine(typeof(HEIOGNNBMMI))]
	public Task<Scene> OCKGJALJDLL(string ANDNLMEHDMG, LoadSceneMode JDNBDAPOGAO = LoadSceneMode.Single, bool JBDNOPCAAAA = false, [Optional] DKKFAAJNJJM<string>.BNLIHIFJPDL EHKOIFCHJFP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x8A88030", Offset = "0x8A86830", VA = "0x188A88030", Slot = "10")]
	public FDNEDNLHGAA PMHPMALOMGL(string ANDNLMEHDMG, LoadSceneMode JDNBDAPOGAO, CancellationToken DGACCOBPOIM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x8A86FF0", Offset = "0x8A857F0", VA = "0x188A86FF0", Slot = "11")]
	public bool DEJBLGHDPEF([Out] string GPHEDLFMGLC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x8A86600", Offset = "0x8A84E00", VA = "0x188A86600")]
	private void BMEKIMFJOOC(Scene DDKANJPKFJF, LoadSceneMode JDNBDAPOGAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x8A87640", Offset = "0x8A85E40", VA = "0x188A87640")]
	private void HMGDBBFDLCB(Scene PHGCAONCMOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x8A87F30", Offset = "0x8A86730", VA = "0x188A87F30")]
	[AsyncStateMachine(typeof(OEAOCIFAAIB))]
	internal Task<AsyncOperation> OHAMCKIGLFE(HOPLNFPLGEB FLPDPHNPDPK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x8A87C00", Offset = "0x8A86400", VA = "0x188A87C00")]
	[AsyncStateMachine(typeof(NJINLDNKCEJ))]
	internal Task<NIGHPONAAAI> LPEFCIBOCHP(HOPLNFPLGEB FLPDPHNPDPK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x8A87080", Offset = "0x8A85880", VA = "0x188A87080")]
	[AsyncStateMachine(typeof(AMJBHMEECHK))]
	private Task DGBFHHCHFLA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x8A87150", Offset = "0x8A85950", VA = "0x188A87150")]
	[AsyncStateMachine(typeof(KGEIDMNDJJA))]
	private Task EFLLKPLJKCI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x8A86DB0", Offset = "0x8A855B0", VA = "0x188A86DB0")]
	[AsyncStateMachine(typeof(IDNGKLKLAOO))]
	private Task<Scene> CEBJPFLEHDF(EBDGHBNLFHM BGCFGPGIKJN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x8A87B40", Offset = "0x8A86340", VA = "0x188A87B40")]
	[IteratorStateMachine(typeof(CFFMPOCMNFK))]
	private IEnumerator<ENGFNCJEKHI> KLAEBBDHJCL(string ANDNLMEHDMG, LoadSceneMode JDNBDAPOGAO, EKAOCHBHLIC<Scene> AIJFCDCELND)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x8A87A10", Offset = "0x8A86210", VA = "0x188A87A10")]
	[AsyncStateMachine(typeof(CPFBPCCGPOM))]
	internal Task<Scene> KCFFIOGPCBO(DKKFAAJNJJM<string>.BNLIHIFJPDL KFAFPJFMHGE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x8A87810", Offset = "0x8A86010", VA = "0x188A87810")]
	private void IAOLAMHDEBK(string ANDNLMEHDMG, LoadSceneMode JDNBDAPOGAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x8A872C0", Offset = "0x8A85AC0", VA = "0x188A872C0")]
	private bool FKNHBKMMAIC([Out] EBDGHBNLFHM LOIBODHBIEF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x8A86EE0", Offset = "0x8A856E0", VA = "0x188A86EE0")]
	private bool DCFGKCEJNIO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x8A882C0", Offset = "0x8A86AC0", VA = "0x188A882C0")]
	public AAEGJBLCKOI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class HOPLNFPLGEB : FDNEDNLHGAA
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	[CompilerGenerated]
	private struct CCEKDCCPPOE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public HOPLNFPLGEB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x8A886A0", Offset = "0x8A86EA0", VA = "0x188A886A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x8A88B60", Offset = "0x8A87360", VA = "0x188A88B60", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[CompilerGenerated]
	private struct INFNLIILMKB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public AsyncTaskMethodBuilder<NIGHPONAAAI> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public HOPLNFPLGEB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		private TaskAwaiter<bool> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x8A8C220", Offset = "0x8A8AA20", VA = "0x188A8C220", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x8A8C7A0", Offset = "0x8A8AFA0", VA = "0x188A8C7A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[CompilerGenerated]
	private struct MDNEJBDMFMI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public AsyncTaskMethodBuilder<NIGHPONAAAI> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public HOPLNFPLGEB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		private AsyncOperation <unfinishedPreloadOperation>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		private OOOIBDPNCAF <stackTimer>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		private TaskAwaiter<Scene> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private TaskAwaiter <>u__3;

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x8A8D7D0", Offset = "0x8A8BFD0", VA = "0x188A8D7D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x8A8E1C0", Offset = "0x8A8C9C0", VA = "0x188A8E1C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[CompilerGenerated]
	private struct LPMKCAEECHM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		public CancellationToken ct;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		public HOPLNFPLGEB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		private object <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		private int <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		private TaskAwaiter<AsyncOperation> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		private TaskAwaiter<NIGHPONAAAI> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x8A8D0D0", Offset = "0x8A8B8D0", VA = "0x188A8D0D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x8A8D6A0", Offset = "0x8A8BEA0", VA = "0x188A8D6A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	[CompilerGenerated]
	private struct JGHJDFDFLFE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		public AsyncTaskMethodBuilder<NIGHPONAAAI> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public HOPLNFPLGEB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		private TaskAwaiter<NIGHPONAAAI> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x8A8C810", Offset = "0x8A8B010", VA = "0x188A8C810", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x8A8CCA0", Offset = "0x8A8B4A0", VA = "0x188A8CCA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private static readonly BMELPJIFPCL GLHOMCPEEHH;

	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private static readonly BMELPJIFPCL IKMLAEJFFCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private readonly AAEGJBLCKOI FICILDKOHKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private readonly KBPDCLGJICP NJPABJOMFAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	internal readonly FMDICAHNDLL MIBCAODHEFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private Task DGLCGBKHIEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private TaskCompletionSource<bool> CBEHIKMLFEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private readonly CancellationTokenSource KFHNGCODDFA;

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x8A8B0A0", Offset = "0x8A898A0", VA = "0x188A8B0A0")]
	internal HOPLNFPLGEB(AAEGJBLCKOI ADHPKIJDMMJ, string ANDNLMEHDMG, LoadSceneMode JDNBDAPOGAO, CancellationToken DGACCOBPOIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x8A8AF10", Offset = "0x8A89710", VA = "0x188A8AF10", Slot = "4")]
	[AsyncStateMachine(typeof(CCEKDCCPPOE))]
	public Task OHAMCKIGLFE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x8A8AA80", Offset = "0x8A89280", VA = "0x188A8AA80", Slot = "5")]
	[AsyncStateMachine(typeof(INFNLIILMKB))]
	public Task<NIGHPONAAAI> ACIFNFNLLOE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x8A8AB70", Offset = "0x8A89370", VA = "0x188A8AB70")]
	internal bool AEFLKGHOMFB(string ANDNLMEHDMG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x8A8AFE0", Offset = "0x8A897E0", VA = "0x188A8AFE0")]
	internal bool PHKPPOHGPFO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x8A8ACA0", Offset = "0x8A894A0", VA = "0x188A8ACA0")]
	[AsyncStateMachine(typeof(MDNEJBDMFMI))]
	internal Task<NIGHPONAAAI> FBONGFMPKDI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x8A8AEA0", Offset = "0x8A896A0", VA = "0x188A8AEA0")]
	internal void OBICCPKFOJP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x8A8ABA0", Offset = "0x8A893A0", VA = "0x188A8ABA0")]
	[AsyncStateMachine(typeof(LPMKCAEECHM))]
	private Task EHIMNNFLLML(CancellationToken APHMMJPOLIP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x8A8ADB0", Offset = "0x8A895B0", VA = "0x188A8ADB0")]
	[AsyncStateMachine(typeof(JGHJDFDFLFE))]
	private Task<NIGHPONAAAI> LLBDDIGBNLP()
	{
		return null;
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
