using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Microsoft.CodeAnalysis;
using RecRoom.Cameras.Effects;
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
		[Cpp2IlInjected.Address(RVA = "0x787870", Offset = "0x786C70", VA = "0x180787870")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[Microsoft.CodeAnalysis.Embedded]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter, AllowMultiple = false, Inherited = false)]
	[CompilerGenerated]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x5BB0A00", Offset = "0x5BAFE00", VA = "0x185BB0A00")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x787CA0", Offset = "0x7870A0", VA = "0x180787CA0")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	[Microsoft.CodeAnalysis.Embedded]
	[CompilerGenerated]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x787CE0", Offset = "0x7870E0", VA = "0x180787CE0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
[LJJODHMGIKF]
public class HPFABDHKBBC : AOFOHBPGKFJ, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	internal enum HEEDFOOIGBE
	{
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		Invalid,
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		ShowingCamera,
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		FadingToBlack,
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		ShowingBlack,
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		FadingToCamera
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CompilerGenerated]
	private struct NCMNOHKGIDD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		public HPFABDHKBBC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private CancellationTokenSource <tokenSource>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x5BB05A0", Offset = "0x5BAF9A0", VA = "0x185BB05A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x5BB09A0", Offset = "0x5BAFDA0", VA = "0x185BB09A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private sealed class CDLINDPHIMC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		public CancellationTokenSource cts;

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x76C4B0", Offset = "0x76B8B0", VA = "0x18076C4B0")]
		public CDLINDPHIMC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x5BACF00", Offset = "0x5BAC300", VA = "0x185BACF00")]
		internal void BELCNAPHOLF(HEEDFOOIGBE fadeState)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private struct BBHOFJBGDEF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		public HEEDFOOIGBE completedState;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		public HPFABDHKBBC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		public Func<CPDPIBICAED> durationFetch;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		public float endOpacity;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private CDLINDPHIMC <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private object <animateInOutSuppressionToken>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private float <transitionStart>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private CancellationToken <cancellationToken>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private float? <lastFadeSlope>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private float <lerpTimeStart>5__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private float <lerpTimeEnd>5__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private float <lerpStartValue>5__8;

		[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private float <lerpEndValue>5__9;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x5BAC160", Offset = "0x5BAB560", VA = "0x185BAC160", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x5BACEA0", Offset = "0x5BAC2A0", VA = "0x185BACEA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CompilerGenerated]
	private struct DNJNHIOGLIK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public HPFABDHKBBC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private CancellationTokenSource <tokenSource>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x5BAD210", Offset = "0x5BAC610", VA = "0x185BAD210", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x5BAD620", Offset = "0x5BACA20", VA = "0x185BAD620", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private sealed class GHEIKOBAHGH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public TaskCompletionSource<HEEDFOOIGBE> tcs;

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x76C4B0", Offset = "0x76B8B0", VA = "0x18076C4B0")]
		public GHEIKOBAHGH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x5BAD680", Offset = "0x5BACA80", VA = "0x185BAD680")]
		internal void IGEJGMDDKGO()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private struct IHLNFEOKKJE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public ICollection<TaskCompletionSource<HEEDFOOIGBE>> tcsList;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		private GHEIKOBAHGH <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private IDisposable <registration>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private TaskAwaiter<HEEDFOOIGBE> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x5BAF620", Offset = "0x5BAEA20", VA = "0x185BAF620", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x5BAFC90", Offset = "0x5BAF090", VA = "0x185BAFC90", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly KALPBFKGJHE GLLGDKMPFEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly PEADKHJIEGM AAEMBMKEMEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private readonly DGBLBAOIOJK MLIJMAHFMDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly FOEGIMMGMHK JDMBLJPNIHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly CKGMNOICMOP MHIDGDMAFGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private readonly Func<Task> CHIDPJJMJKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly LAMCNGJDMND DIMHAIGODPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private readonly LAMCNGJDMND LHOGKOAMKCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private readonly CancellationTokenSource GHCHOIADFKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private readonly CancellationToken GBDKEKFMNLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly NNPJKIBOBEG<OELMHOEECPG> POJMHOLFOIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private readonly object FDKCMGMBGGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private readonly object OBHMPBLGGII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private readonly List<TaskCompletionSource<HEEDFOOIGBE>> OMFCFHBMJLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private readonly List<TaskCompletionSource<HEEDFOOIGBE>> OJDIKLLEPKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private HEEDFOOIGBE KOGGJAJLNKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9C")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	internal bool MBDHFKDLAEM;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public bool EMBOKGLKKCP
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x5BADAC0", Offset = "0x5BACEC0", VA = "0x185BADAC0", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public bool PGNNBGHOGME
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x5BADD20", Offset = "0x5BAD120", VA = "0x185BADD20", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool EEOPFJDFHKG
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x5BAED60", Offset = "0x5BAE160", VA = "0x185BAED60", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public float JBMCKDCBIBP
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0xA955B0", Offset = "0xA949B0", VA = "0x180A955B0", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0xA95590", Offset = "0xA94990", VA = "0x180A95590")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	private HEEDFOOIGBE CGHLFPGKMMK
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0xAE6C70", Offset = "0xAE6070", VA = "0x180AE6C70")]
		get
		{
			return default(HEEDFOOIGBE);
		}
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x5BAE940", Offset = "0x5BADD40", VA = "0x185BAE940")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	private event Action<HEEDFOOIGBE> AAGGAJPEOGF
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x5BAEE60", Offset = "0x5BAE260", VA = "0x185BAEE60")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x5BAE3E0", Offset = "0x5BAD7E0", VA = "0x185BAE3E0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x5BAEF20", Offset = "0x5BAE320", VA = "0x185BAEF20")]
	[Preserve]
	public HPFABDHKBBC([LOJAGCNCPBJ(null)] KALPBFKGJHE GLLGDKMPFEH, [LOJAGCNCPBJ(null)] PEADKHJIEGM AAEMBMKEMEO, [LOJAGCNCPBJ(null)] DGBLBAOIOJK MLIJMAHFMDD, [LOJAGCNCPBJ("CameraFadeTimeoutDetector")] FOEGIMMGMHK JDMBLJPNIHD, [LOJAGCNCPBJ(null)] CKGMNOICMOP MHIDGDMAFGC, [LOJAGCNCPBJ(null)] OEFHLHNIBAC<CameraFadeOptions> PHAIIGMLKHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x5BAEF70", Offset = "0x5BAE370", VA = "0x185BAEF70")]
	internal HPFABDHKBBC(KALPBFKGJHE GLLGDKMPFEH, PEADKHJIEGM AAEMBMKEMEO, DGBLBAOIOJK MLIJMAHFMDD, FOEGIMMGMHK JDMBLJPNIHD, CKGMNOICMOP MHIDGDMAFGC, OEFHLHNIBAC<CameraFadeOptions> PHAIIGMLKHM, Func<Task>? CHIDPJJMJKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x5BADDC0", Offset = "0x5BAD1C0", VA = "0x185BADDC0", Slot = "8")]
	public HJHALKHOOCD EIEONNCGGHM(OELMHOEECPG KJAGMGIFCEM, [Optional] HNFLKLADHDL? OHJEAJAOJCO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x5BAED70", Offset = "0x5BAE170", VA = "0x185BAED70", Slot = "9")]
	[AsyncStateMachine(typeof(NCMNOHKGIDD))]
	public Task PGOCDKEJHHL([Optional] CancellationToken ELGJALILGJE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x5BADD70", Offset = "0x5BAD170", VA = "0x185BADD70", Slot = "10")]
	public IReadOnlyCollection<OELMHOEECPG> EGAJMMGHNDK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x5BAEBB0", Offset = "0x5BADFB0", VA = "0x185BAEBB0")]
	internal void KJJHCAPPLPL(OELMHOEECPG KJAGMGIFCEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x5BAED30", Offset = "0x5BAE130", VA = "0x185BAED30")]
	private CPDPIBICAED LABKFOKMHAO()
	{
		return default(CPDPIBICAED);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x5BAE910", Offset = "0x5BADD10", VA = "0x185BAE910")]
	private CPDPIBICAED ICIGBILHCNO()
	{
		return default(CPDPIBICAED);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x5BAE520", Offset = "0x5BAD920", VA = "0x185BAE520")]
	internal void GFGNKAFPECA(OELMHOEECPG KJAGMGIFCEM, HNFLKLADHDL PJDJKJCOOHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x5BAEA70", Offset = "0x5BADE70", VA = "0x185BAEA70")]
	private static void JJILHHALEGN(IReadOnlyList<TaskCompletionSource<HEEDFOOIGBE>> BNEEEIBGKPD, HEEDFOOIGBE NMKDCDPKLBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x5BADAE0", Offset = "0x5BACEE0", VA = "0x185BADAE0")]
	private void BLDNOBODLEM(float AEMFHKGDFKL, Func<CPDPIBICAED> GIBHIJECMBH, HEEDFOOIGBE NLKIHFOKIFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x5BAE4A0", Offset = "0x5BAD8A0", VA = "0x185BAE4A0")]
	private static bool GFDKHEENMAA(float IFAOGMEBPFN, float DNPBOPMFFFF, float DKDDHNJPECP = 0.0001f)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x5BAE7D0", Offset = "0x5BADBD0", VA = "0x185BAE7D0")]
	[AsyncStateMachine(typeof(BBHOFJBGDEF))]
	private Task HNEKJCFMIMM(CancellationToken CLGPMABAGGJ, float AEMFHKGDFKL, Func<CPDPIBICAED> IFOKHIOJCCB, HEEDFOOIGBE NLKIHFOKIFB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x5BAD9B0", Offset = "0x5BACDB0", VA = "0x185BAD9B0")]
	private void AJPPINLDKLI(float IEDJKLEELLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x5BADC30", Offset = "0x5BAD030", VA = "0x185BADC30")]
	[AsyncStateMachine(typeof(DNJNHIOGLIK))]
	internal Task DAKIHKGDPFA([Optional] CancellationToken ELGJALILGJE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x5BAE6D0", Offset = "0x5BADAD0", VA = "0x185BAE6D0")]
	[AsyncStateMachine(typeof(IHLNFEOKKJE))]
	private static Task HKFDCBKONGH(ICollection<TaskCompletionSource<HEEDFOOIGBE>> BNEEEIBGKPD, CancellationToken ELGJALILGJE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x5BADD30", Offset = "0x5BAD130", VA = "0x185BADD30", Slot = "11")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
internal class IOEDFNJFDIL : HJHALKHOOCD, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	private struct GIOCGNMNKNK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public IOEDFNJFDIL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x5BAD6D0", Offset = "0x5BACAD0", VA = "0x185BAD6D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x5BAD950", Offset = "0x5BACD50", VA = "0x185BAD950", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	private readonly BLCHKNJPCEA FNGOMCOHKPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	private readonly HPFABDHKBBC MIEDADLAHAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	private readonly OELMHOEECPG KJAGMGIFCEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private bool GIAGFMCPJPC;

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x5BAFF90", Offset = "0x5BAF390", VA = "0x185BAFF90")]
	internal IOEDFNJFDIL(HPFABDHKBBC MIEDADLAHAK, OELMHOEECPG KJAGMGIFCEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x5BAFEA0", Offset = "0x5BAF2A0", VA = "0x185BAFEA0", Slot = "4")]
	[AsyncStateMachine(typeof(GIOCGNMNKNK))]
	public Task MNAKFJKHPMJ([Optional] CancellationToken ELGJALILGJE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x5BAFCF0", Offset = "0x5BAF0F0", VA = "0x185BAFCF0", Slot = "5")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
internal readonly struct CPDPIBICAED : IEquatable<CPDPIBICAED>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public readonly bool OADOJLMMPAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	public readonly float AAOPCPMBMOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	public readonly float PGNIFNLDJLJ;

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x5BAD140", Offset = "0x5BAC540", VA = "0x185BAD140")]
	public CPDPIBICAED(float MDFONMEDBBM, float DNJBPNBAMFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x5BACF30", Offset = "0x5BAC330", VA = "0x185BACF30", Slot = "4")]
	public bool Equals(CPDPIBICAED LJIBJAOOGGF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x5BACF70", Offset = "0x5BAC370", VA = "0x185BACF70", Slot = "0")]
	public override bool Equals(object? BAFDGKKJJJD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x5BAD020", Offset = "0x5BAC420", VA = "0x185BAD020", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x5BAD0A0", Offset = "0x5BAC4A0", VA = "0x185BAD0A0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
internal class LAMCNGJDMND
{
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public enum HGDHBMPJNEE : byte
	{
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		FastestFade,
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		SlowestFade
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	private readonly HGDHBMPJNEE HMKIICIKPGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	private readonly Dictionary<object, CPDPIBICAED> JBIODEMKJAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	private readonly CPDPIBICAED GEODCJIIJKG;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public CPDPIBICAED DFNAILAPHHN
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x8415D0", Offset = "0x8409D0", VA = "0x1808415D0")]
		[CompilerGenerated]
		get
		{
			return default(CPDPIBICAED);
		}
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x844540", Offset = "0x843940", VA = "0x180844540")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x5BB04E0", Offset = "0x5BAF8E0", VA = "0x185BB04E0")]
	public LAMCNGJDMND(HGDHBMPJNEE HMKIICIKPGD, CPDPIBICAED GEODCJIIJKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x5BB0100", Offset = "0x5BAF500", VA = "0x185BB0100")]
	public void CDPPOMFPNNH(object KJAGMGIFCEM, CPDPIBICAED AMNOMLAFNIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x5BB0040", Offset = "0x5BAF440", VA = "0x185BB0040")]
	public void BLFHNKIOGCM(object KJAGMGIFCEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x5BB00B0", Offset = "0x5BAF4B0", VA = "0x185BB00B0")]
	public void BPHEMFKLBDC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x5BB0220", Offset = "0x5BAF620", VA = "0x185BB0220")]
	private void HJGGCLFLOEM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x5BB02C0", Offset = "0x5BAF6C0", VA = "0x185BB02C0")]
	private CPDPIBICAED HPMCMKGBNPD()
	{
		return default(CPDPIBICAED);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x5BB04A0", Offset = "0x5BAF8A0", VA = "0x185BB04A0")]
	private CPDPIBICAED KDIABLKHLBL()
	{
		return default(CPDPIBICAED);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x5BB0300", Offset = "0x5BAF700", VA = "0x185BB0300")]
	private CPDPIBICAED IDLCAFCONKH(int DCNGCGCIFEJ)
	{
		return default(CPDPIBICAED);
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
