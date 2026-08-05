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
	public class LogRegistrationIndex : OPBNGIPOJLP
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x9053380", Offset = "0x9051D80", VA = "0x189053380", Slot = "4")]
		public override void NFFNLBFBLBL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xAD77F0", Offset = "0xAD61F0", VA = "0x180AD77F0")]
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
			[Cpp2IlInjected.Address(RVA = "0xAAE190", Offset = "0xAACB90", VA = "0x180AAE190", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x86BB110", Offset = "0x86B9B10", VA = "0x1886BB110", Slot = "5")]
		public override void SetServiceCategoryIndices(List<int> globalFromLocalIndices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x9055780", Offset = "0x9054180", VA = "0x189055780")]
		private void OFEEGALAMNF(IServiceRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x90559C0", Offset = "0x90543C0", VA = "0x1890559C0", Slot = "6")]
		public override void RegisterServices(IServiceRegistration registry, [In] ServiceBitsetFilter filter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x9055A20", Offset = "0x9054420", VA = "0x189055A20")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
internal class ANONOANFABI : EFLIBFFBOJI
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	internal bool HADHKKMIDGE
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0xAB5CA0", Offset = "0xAB46A0", VA = "0x180AB5CA0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	internal OEEGBKAOPAE<string>.BANCHJBJHFK EAHFGMPKCEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0xAAE190", Offset = "0xAACB90", VA = "0x180AAE190")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	internal TaskCompletionSource<Scene> AJECFGLEAFA
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xAAE120", Offset = "0xAACB20", VA = "0x180AAE120")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x904E420", Offset = "0x904CE20", VA = "0x18904E420")]
	internal ANONOANFABI(string GGEKNOFDIKM, LoadSceneMode JFHIEBMGOBN, bool PGKONOJOANP, OEEGBKAOPAE<string>.BANCHJBJHFK FCJPPPKIGAK, TaskCompletionSource<Scene> PKKFKHDGBKI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
internal class EPDJGMJNKKM : EFLIBFFBOJI, NAOLNCNMNOH
{
	[Cpp2IlInjected.Token(Token = "0x17000005")]
	internal Scene? JHEAGABIFJI
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0xAAE1A0", Offset = "0xAACBA0", VA = "0x180AAE1A0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0xE40A30", Offset = "0xE3F430", VA = "0x180E40A30")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	internal AsyncOperation EDFEKLKKABF
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0xAAE190", Offset = "0xAACB90", VA = "0x180AAE190")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0xAAE150", Offset = "0xAACB50", VA = "0x180AAE150")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	internal bool EKMNFIMOCBI
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0xADB270", Offset = "0xAD9C70", VA = "0x180ADB270")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0xADAFF0", Offset = "0xAD99F0", VA = "0x180ADAFF0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x9050AA0", Offset = "0x904F4A0", VA = "0x189050AA0", Slot = "4")]
	public bool DGODDBFNADP([Out] Scene? CFOJADJKDLM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x9050B20", Offset = "0x904F520", VA = "0x189050B20")]
	internal EPDJGMJNKKM(string GGEKNOFDIKM, LoadSceneMode JFHIEBMGOBN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
internal abstract class EFLIBFFBOJI
{
	[Cpp2IlInjected.Token(Token = "0x17000008")]
	internal string JMLMIELGCCL
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0xAAE170", Offset = "0xAACB70", VA = "0x180AAE170")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	internal LHPJDKONLKH PLEHJDEDHNB
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0xAB3B20", Offset = "0xAB2520", VA = "0x180AB3B20")]
		[CompilerGenerated]
		get
		{
			return default(LHPJDKONLKH);
		}
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0xAB33F0", Offset = "0xAB1DF0", VA = "0x180AB33F0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	internal LoadSceneMode PFIGBCAKJMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0xAD57F0", Offset = "0xAD41F0", VA = "0x180AD57F0")]
		[CompilerGenerated]
		get
		{
			return default(LoadSceneMode);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x9050A50", Offset = "0x904F450", VA = "0x189050A50")]
	internal EFLIBFFBOJI(string GGEKNOFDIKM, LoadSceneMode JFHIEBMGOBN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public enum LHPJDKONLKH
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
[RegisterService(typeof(PJFNAIEGFFD), new string[] { })]
public class AJCMKHNPFHH : PJFNAIEGFFD, BOHILICPPOJ, NIPGEDOBAJA
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CompilerGenerated]
	private struct GDHPDDDNBJM : IAsyncStateMachine
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
		public OEEGBKAOPAE<string>.BANCHJBJHFK stackTimerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public AJCMKHNPFHH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private OEEGBKAOPAE<string> <toDispose>5__2;

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
		[Cpp2IlInjected.Address(RVA = "0x9051970", Offset = "0x9050370", VA = "0x189051970", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x9052320", Offset = "0x9050D20", VA = "0x189052320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private struct KKCHKEHIMBB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public AsyncTaskMethodBuilder<AsyncOperation> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public BNDLGJHLCIO request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private AsyncOperation <op>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private PDJKNFENBKE <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x9052A20", Offset = "0x9051420", VA = "0x189052A20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x9053310", Offset = "0x9051D10", VA = "0x189053310", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private struct CCFMGNCLKGB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		public AsyncTaskMethodBuilder<NAOLNCNMNOH> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		public BNDLGJHLCIO request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		public AJCMKHNPFHH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private AsyncOperation <op>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private PDJKNFENBKE <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x904F7B0", Offset = "0x904E1B0", VA = "0x18904F7B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x9050100", Offset = "0x904EB00", VA = "0x189050100", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CompilerGenerated]
	private struct PDOMKACCMGC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public AJCMKHNPFHH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x90548B0", Offset = "0x90532B0", VA = "0x1890548B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x9054B40", Offset = "0x9053540", VA = "0x189054B40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private struct DOHDIKBMCKB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public AJCMKHNPFHH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private ANONOANFABI <queuedSceneLoad>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x90506E0", Offset = "0x904F0E0", VA = "0x1890506E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x90509F0", Offset = "0x904F3F0", VA = "0x1890509F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private sealed class GPHPECNLOOG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public MKNKHCFGBKA<Scene> promise;

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
		public GPHPECNLOOG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x90529C0", Offset = "0x90513C0", VA = "0x1890529C0")]
		internal void CDDIDEMFNNK()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[CompilerGenerated]
	private struct OFAGOCGENDP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public AsyncTaskMethodBuilder<Scene> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public AJCMKHNPFHH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public ANONOANFABI sceneLoadInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private OEEGBKAOPAE<string>.BANCHJBJHFK <loadSceneTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private OEEGBKAOPAE<string>.BANCHJBJHFK <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private OEEGBKAOPAE<string>.BANCHJBJHFK <>7__wrap3;

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x9053450", Offset = "0x9051E50", VA = "0x189053450", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x9054320", Offset = "0x9052D20", VA = "0x189054320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	private sealed class GCBHJINHHFA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public MKNKHCFGBKA<Scene> onCompletePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public IDisposable sample;

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
		public GCBHJINHHFA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x90518F0", Offset = "0x90502F0", VA = "0x1890518F0")]
		internal bool KMEDKNBDLGN(Scene scene)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x9051790", Offset = "0x9050190", VA = "0x189051790")]
		internal void BNJDMFCJBEN(Scene scene, LoadSceneMode mode)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[CompilerGenerated]
	private sealed class DCGEDOHGPHC : IEnumerator<JFFMJDIOLAN>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private JFFMJDIOLAN <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public MKNKHCFGBKA<Scene> onCompletePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public AJCMKHNPFHH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public LoadSceneMode loadSceneMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private GCBHJINHHFA <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		private PDJKNFENBKE <_>5__2;

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		private JFFMJDIOLAN System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0xAAE110", Offset = "0xAACB10", VA = "0x180AAE110", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0xAAE110", Offset = "0xAACB10", VA = "0x180AAE110", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0xAB33A0", Offset = "0xAB1DA0", VA = "0x180AB33A0")]
		[DebuggerHidden]
		public DCGEDOHGPHC(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x9050680", Offset = "0x904F080", VA = "0x189050680", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x9050190", Offset = "0x904EB90", VA = "0x189050190", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x9050170", Offset = "0x904EB70", VA = "0x189050170")]
		private void LLDKJPCFHKC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x9050630", Offset = "0x904F030", VA = "0x189050630", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[CompilerGenerated]
	private struct FHLKALDEEBF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public AsyncTaskMethodBuilder<Scene> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public OEEGBKAOPAE<string>.BANCHJBJHFK stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public AJCMKHNPFHH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		private Scene <emptyScene>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		private OEEGBKAOPAE<string>.BANCHJBJHFK <emptySceneRoutineTimer>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		private OEEGBKAOPAE<string>.BANCHJBJHFK <emptySceneTimer>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x9050B80", Offset = "0x904F580", VA = "0x189050B80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x9051720", Offset = "0x9050120", VA = "0x189051720", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private static readonly OLFEOKKCIEG JHGFKLHHPJD;

	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private static readonly OLFEOKKCIEG EJAKHDHBLOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private Task JJFNPPKAEPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private List<ANONOANFABI> FMOHEMODKDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private BNDLGJHLCIO NIILJJJMNIO;

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event Action<string, LoadSceneMode> EEEJMKMIMDB
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x904DEE0", Offset = "0x904C8E0", VA = "0x18904DEE0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x904E140", Offset = "0x904CB40", VA = "0x18904E140", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event Action NPKEHKICBDG
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x904C9F0", Offset = "0x904B3F0", VA = "0x18904C9F0", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x904DD40", Offset = "0x904C740", VA = "0x18904DD40", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x904D0D0", Offset = "0x904BAD0", VA = "0x18904D0D0", Slot = "12")]
	public void InitReferences(BDGILPFNAIO NBEKNJIPGOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x904E1F0", Offset = "0x904CBF0", VA = "0x18904E1F0", Slot = "13")]
	public void ShutdownReferences()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x904C6F0", Offset = "0x904B0F0", VA = "0x18904C6F0", Slot = "8")]
	public void DBNCKMCADBA(LoadSceneMode JFHIEBMGOBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x904D1C0", Offset = "0x904BBC0", VA = "0x18904D1C0", Slot = "9")]
	[AsyncStateMachine(typeof(GDHPDDDNBJM))]
	public Task<Scene> JODLEKMKBAG(string GGEKNOFDIKM, LoadSceneMode JFHIEBMGOBN = LoadSceneMode.Single, bool PGKONOJOANP = false, [Optional] OEEGBKAOPAE<string>.BANCHJBJHFK AKKOFJNCLAO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x904DDE0", Offset = "0x904C7E0", VA = "0x18904DDE0", Slot = "10")]
	public EAOBOKAGIGN NJHNGAKCAPG(string GGEKNOFDIKM, LoadSceneMode JFHIEBMGOBN, CancellationToken ICODIHINNBH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x904DF90", Offset = "0x904C990", VA = "0x18904DF90", Slot = "11")]
	public bool PDDEDIJDOBN([Out] string KODBAFKNPFG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x904D570", Offset = "0x904BF70", VA = "0x18904D570")]
	private void LIKKPMDGBKL(Scene IMKDFBNNIAM, LoadSceneMode JFHIEBMGOBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x904C740", Offset = "0x904B140", VA = "0x18904C740")]
	private void EGDOOENJDAP(Scene BNIIGJDGLIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x904CC30", Offset = "0x904B630", VA = "0x18904CC30")]
	[AsyncStateMachine(typeof(KKCHKEHIMBB))]
	internal Task<AsyncOperation> ILDMBLJKEID(BNDLGJHLCIO KGHMNJMLIBE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x904CB00", Offset = "0x904B500", VA = "0x18904CB00")]
	[AsyncStateMachine(typeof(CCFMGNCLKGB))]
	internal Task<NAOLNCNMNOH> HGBMBAEGAOJ(BNDLGJHLCIO KGHMNJMLIBE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x904C920", Offset = "0x904B320", VA = "0x18904C920")]
	[AsyncStateMachine(typeof(PDOMKACCMGC))]
	private Task EHECODPOCJA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x904C560", Offset = "0x904AF60", VA = "0x18904C560")]
	[AsyncStateMachine(typeof(DOHDIKBMCKB))]
	private Task AGMNGMEOHOF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x904D310", Offset = "0x904BD10", VA = "0x18904D310")]
	[AsyncStateMachine(typeof(OFAGOCGENDP))]
	private Task<Scene> KPBMIAINDHJ(ANONOANFABI NMGAPDBJLNB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x904C630", Offset = "0x904B030", VA = "0x18904C630")]
	[IteratorStateMachine(typeof(DCGEDOHGPHC))]
	private IEnumerator<JFFMJDIOLAN> CGIFOFIKGJD(string GGEKNOFDIKM, LoadSceneMode JFHIEBMGOBN, MKNKHCFGBKA<Scene> HIDEDMJLDMO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x904D440", Offset = "0x904BE40", VA = "0x18904D440")]
	[AsyncStateMachine(typeof(FHLKALDEEBF))]
	internal Task<Scene> LGPAGIMAEBB(OEEGBKAOPAE<string>.BANCHJBJHFK FCJPPPKIGAK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x904CA90", Offset = "0x904B490", VA = "0x18904CA90")]
	private void GKKHBJJANEJ(string GGEKNOFDIKM, LoadSceneMode JFHIEBMGOBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x904CD30", Offset = "0x904B730", VA = "0x18904CD30")]
	private bool IPPAKJPNNFK([Out] ANONOANFABI IDJKFNOHMFL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x904E020", Offset = "0x904CA20", VA = "0x18904E020")]
	private bool PMINBBGGIFI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x904E390", Offset = "0x904CD90", VA = "0x18904E390")]
	public AJCMKHNPFHH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class BNDLGJHLCIO : EAOBOKAGIGN
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	[CompilerGenerated]
	private struct OPAIFLCKCBE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public BNDLGJHLCIO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x9054390", Offset = "0x9052D90", VA = "0x189054390", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x9054850", Offset = "0x9053250", VA = "0x189054850", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[CompilerGenerated]
	private struct PGNIGDEOBAM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public AsyncTaskMethodBuilder<NAOLNCNMNOH> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public BNDLGJHLCIO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		private TaskAwaiter<bool> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x9054BA0", Offset = "0x90535A0", VA = "0x189054BA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x9055130", Offset = "0x9053B30", VA = "0x189055130", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[CompilerGenerated]
	private struct BIPBAFBBPHK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public AsyncTaskMethodBuilder<NAOLNCNMNOH> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public BNDLGJHLCIO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		private AsyncOperation <unfinishedPreloadOperation>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		private LBBOOFEPGPE <stackTimer>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		private TaskAwaiter<Scene> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private TaskAwaiter <>u__3;

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x904E4A0", Offset = "0x904CEA0", VA = "0x18904E4A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x904EEA0", Offset = "0x904D8A0", VA = "0x18904EEA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[CompilerGenerated]
	private struct GJNMPMCGPIF : IAsyncStateMachine
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
		public BNDLGJHLCIO <>4__this;

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
		private TaskAwaiter<NAOLNCNMNOH> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x9052390", Offset = "0x9050D90", VA = "0x189052390", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x9052960", Offset = "0x9051360", VA = "0x189052960", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	[CompilerGenerated]
	private struct PKMDHMACEHJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		public AsyncTaskMethodBuilder<NAOLNCNMNOH> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public BNDLGJHLCIO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		private TaskAwaiter<NAOLNCNMNOH> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x90551A0", Offset = "0x9053BA0", VA = "0x1890551A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x9055630", Offset = "0x9054030", VA = "0x189055630", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private static readonly OLFEOKKCIEG JHGFKLHHPJD;

	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private static readonly OLFEOKKCIEG EJAKHDHBLOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private readonly AJCMKHNPFHH DNOCOPKNAEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private readonly LLFOFNPHDOK FPPOABMDFLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	internal readonly EPDJGMJNKKM PFGBJGDNAGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private Task KMCGAIEOLAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private TaskCompletionSource<bool> DBLOJJFHFFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private readonly CancellationTokenSource OHFCLCGHNMB;

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x904F540", Offset = "0x904DF40", VA = "0x18904F540")]
	internal BNDLGJHLCIO(AJCMKHNPFHH NKPPNGHHBBK, string GGEKNOFDIKM, LoadSceneMode JFHIEBMGOBN, CancellationToken ICODIHINNBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x904EF10", Offset = "0x904D910", VA = "0x18904EF10", Slot = "4")]
	[AsyncStateMachine(typeof(OPAIFLCKCBE))]
	public Task ILDMBLJKEID()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x904EFE0", Offset = "0x904D9E0", VA = "0x18904EFE0", Slot = "5")]
	[AsyncStateMachine(typeof(PGNIGDEOBAM))]
	public Task<NAOLNCNMNOH> JCJEKAAIKKC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x904F460", Offset = "0x904DE60", VA = "0x18904F460")]
	internal bool NKODLPMABAI(string GGEKNOFDIKM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x904F1D0", Offset = "0x904DBD0", VA = "0x18904F1D0")]
	internal bool LEEPPJLDAMO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x904F1F0", Offset = "0x904DBF0", VA = "0x18904F1F0")]
	[AsyncStateMachine(typeof(BIPBAFBBPHK))]
	internal Task<NAOLNCNMNOH> LFPMCBHAIJL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x904F300", Offset = "0x904DD00", VA = "0x18904F300")]
	internal void LGKIIHEDPHK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x904F0D0", Offset = "0x904DAD0", VA = "0x18904F0D0")]
	[AsyncStateMachine(typeof(GJNMPMCGPIF))]
	private Task JNPDNLNDIMG(CancellationToken MOEFPNIEBLA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x904F370", Offset = "0x904DD70", VA = "0x18904F370")]
	[AsyncStateMachine(typeof(PKMDHMACEHJ))]
	private Task<NAOLNCNMNOH> NJELEIMFAEJ()
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
