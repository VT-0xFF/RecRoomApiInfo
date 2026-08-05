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
		[Cpp2IlInjected.Address(RVA = "0x79A600", Offset = "0x799600", VA = "0x18079A600")]
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
		[Cpp2IlInjected.Address(RVA = "0x5D22EB0", Offset = "0x5D21EB0", VA = "0x185D22EB0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x79B560", Offset = "0x79A560", VA = "0x18079B560")]
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
		[Cpp2IlInjected.Address(RVA = "0x79B5A0", Offset = "0x79A5A0", VA = "0x18079B5A0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
[DCMGMDBOPDL]
public class MJEBKIJPJFF : DICJKFHJMPC, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	internal enum DABCCGNBBAK
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
	private struct LNPKEEOLLAB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		public MJEBKIJPJFF <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x5D20AA0", Offset = "0x5D1FAA0", VA = "0x185D20AA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x5D20EA0", Offset = "0x5D1FEA0", VA = "0x185D20EA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private sealed class MDGFJLDHEDH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		public CancellationTokenSource cts;

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x7734B0", Offset = "0x7724B0", VA = "0x1807734B0")]
		public MDGFJLDHEDH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x5D20F00", Offset = "0x5D1FF00", VA = "0x185D20F00")]
		internal void ACIPPHKEPNI(DABCCGNBBAK fadeState)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private struct GCCIEHLDHJB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		public DABCCGNBBAK completedState;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		public MJEBKIJPJFF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		public Func<AELMDIDBLGG> durationFetch;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		public float endOpacity;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private MDGFJLDHEDH <>8__1;

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
		[Cpp2IlInjected.Address(RVA = "0x5D1F080", Offset = "0x5D1E080", VA = "0x185D1F080", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x5D1FDC0", Offset = "0x5D1EDC0", VA = "0x185D1FDC0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CompilerGenerated]
	private struct ANHPEJHFJJG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public MJEBKIJPJFF <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x5D1E8C0", Offset = "0x5D1D8C0", VA = "0x185D1E8C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x5D1ECD0", Offset = "0x5D1DCD0", VA = "0x185D1ECD0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private sealed class HAMFPAENABM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public TaskCompletionSource<DABCCGNBBAK> tcs;

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x7734B0", Offset = "0x7724B0", VA = "0x1807734B0")]
		public HAMFPAENABM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x5D20380", Offset = "0x5D1F380", VA = "0x185D20380")]
		internal void PCBGNPEACCO()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private struct JMGBAACDJBN : IAsyncStateMachine
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
		public ICollection<TaskCompletionSource<DABCCGNBBAK>> tcsList;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		private HAMFPAENABM <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private IDisposable <registration>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private TaskAwaiter<DABCCGNBBAK> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x5D203D0", Offset = "0x5D1F3D0", VA = "0x185D203D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x5D20A40", Offset = "0x5D1FA40", VA = "0x185D20A40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly NKNOLCAOGBK LGINBKIPKGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly OLBPPEJAJOK FJLOBLPOOOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private readonly MDJCEOLJBNI HFMMICCLHEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly KDHLNHAGGJM MJGIGKJLKEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly MFPBFMJJMGI DINGKEEDGLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private readonly Func<Task> INDDOMFANDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly GLDHBLDGNEP JEFGOALNGNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private readonly GLDHBLDGNEP OELJBOCKCNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private readonly CancellationTokenSource KKHNDPIAJFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private readonly CancellationToken FGICKNAIGJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly HHPOCKOFDAH<APINBDFMKOH> OLADJIPGABO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private readonly object KCINPDGMBKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private readonly object MADGMPJIPPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private readonly List<TaskCompletionSource<DABCCGNBBAK>> OMCEOGINOMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private readonly List<TaskCompletionSource<DABCCGNBBAK>> HKNOBOKIFCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private DABCCGNBBAK BLOJHNKBFOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9C")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	internal bool HECFPDDNALA;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public bool GLJCFJEJPGG
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x5D224B0", Offset = "0x5D214B0", VA = "0x185D224B0", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public bool OJCNPIBLODD
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x5D223A0", Offset = "0x5D213A0", VA = "0x185D223A0", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool NJAJFJBGMMF
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x5D223B0", Offset = "0x5D213B0", VA = "0x185D223B0", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public float OMGJGLLDOFH
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0xAEF5D0", Offset = "0xAEE5D0", VA = "0x180AEF5D0", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0xAEF5F0", Offset = "0xAEE5F0", VA = "0x180AEF5F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	private DABCCGNBBAK EEMHEOGOAEI
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0xB64770", Offset = "0xB63770", VA = "0x180B64770")]
		get
		{
			return default(DABCCGNBBAK);
		}
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x5D21070", Offset = "0x5D20070", VA = "0x185D21070")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	private event Action<DABCCGNBBAK> CLELFAPCPOF
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x5D220B0", Offset = "0x5D210B0", VA = "0x185D220B0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x5D211A0", Offset = "0x5D201A0", VA = "0x185D211A0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x5D22B80", Offset = "0x5D21B80", VA = "0x185D22B80")]
	[Preserve]
	public MJEBKIJPJFF([KHIPNIHHNOH(null)] NKNOLCAOGBK LGINBKIPKGK, [KHIPNIHHNOH(null)] OLBPPEJAJOK FJLOBLPOOOF, [KHIPNIHHNOH(null)] MDJCEOLJBNI HFMMICCLHEK, [KHIPNIHHNOH("CameraFadeTimeoutDetector")] KDHLNHAGGJM MJGIGKJLKEB, [KHIPNIHHNOH(null)] MFPBFMJJMGI DINGKEEDGLH, [KHIPNIHHNOH(null)] EJACHDOAIDJ<CameraFadeOptions> DGHDFHCPCLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x5D224D0", Offset = "0x5D214D0", VA = "0x185D224D0")]
	internal MJEBKIJPJFF(NKNOLCAOGBK LGINBKIPKGK, OLBPPEJAJOK FJLOBLPOOOF, MDJCEOLJBNI HFMMICCLHEK, KDHLNHAGGJM MJGIGKJLKEB, MFPBFMJJMGI DINGKEEDGLH, EJACHDOAIDJ<CameraFadeOptions> DGHDFHCPCLI, Func<Task>? INDDOMFANDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x5D21440", Offset = "0x5D20440", VA = "0x185D21440", Slot = "8")]
	public FPAACNFKCED CPIGFNDMIME(APINBDFMKOH PDIBILKHEBM, [Optional] LCALKLBOPNP? EPAEBNDABHK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x5D221A0", Offset = "0x5D211A0", VA = "0x185D221A0", Slot = "9")]
	[AsyncStateMachine(typeof(LNPKEEOLLAB))]
	public Task NGKOPHLHDMB([Optional] CancellationToken JEBPNJAPHEL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x5D21D20", Offset = "0x5D20D20", VA = "0x185D21D20", Slot = "10")]
	public IReadOnlyCollection<APINBDFMKOH> HDDEMNKKJEH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x5D21EB0", Offset = "0x5D20EB0", VA = "0x185D21EB0")]
	internal void JKIGIFDLMEF(APINBDFMKOH PDIBILKHEBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x5D21260", Offset = "0x5D20260", VA = "0x185D21260")]
	private AELMDIDBLGG CCHBOMKILGC()
	{
		return default(AELMDIDBLGG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x5D22170", Offset = "0x5D21170", VA = "0x185D22170")]
	private AELMDIDBLGG LKKHBBJDDHL()
	{
		return default(AELMDIDBLGG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x5D21290", Offset = "0x5D20290", VA = "0x185D21290")]
	internal void COKDLCMEIAD(APINBDFMKOH PDIBILKHEBM, LCALKLBOPNP GFJGPOFJGLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x5D21D70", Offset = "0x5D20D70", VA = "0x185D21D70")]
	private static void HDFMCLDPLPI(IReadOnlyList<TaskCompletionSource<DABCCGNBBAK>> MKKBLIMLBFH, DABCCGNBBAK DPLMONBFHHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x5D21BA0", Offset = "0x5D20BA0", VA = "0x185D21BA0")]
	private void EEFIFNNHDHN(float OEEKOABKPPE, Func<AELMDIDBLGG> HIKNPJFPCMC, DABCCGNBBAK FPFCNKIGDCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x5D22030", Offset = "0x5D21030", VA = "0x185D22030")]
	private static bool LAHBOABMKPC(float HMDDIJJDAIK, float NDOJJCKFJID, float NENPBHHKANE = 0.0001f)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x5D20F30", Offset = "0x5D1FF30", VA = "0x185D20F30")]
	[AsyncStateMachine(typeof(GCCIEHLDHJB))]
	private Task ANHAMGMNCHG(CancellationToken PMLBMCIFPPF, float OEEKOABKPPE, Func<AELMDIDBLGG> HIJBECBLPMK, DABCCGNBBAK FPFCNKIGDCC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x5D22290", Offset = "0x5D21290", VA = "0x185D22290")]
	private void NPJBHINCDNM(float PFAEPDMMENP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x5D223C0", Offset = "0x5D213C0", VA = "0x185D223C0")]
	[AsyncStateMachine(typeof(ANHPEJHFJJG))]
	internal Task OLFAFNKCHIH([Optional] CancellationToken JEBPNJAPHEL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x5D21A60", Offset = "0x5D20A60", VA = "0x185D21A60")]
	[AsyncStateMachine(typeof(JMGBAACDJBN))]
	private static Task DDEOKNNDCCH(ICollection<TaskCompletionSource<DABCCGNBBAK>> MKKBLIMLBFH, CancellationToken JEBPNJAPHEL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x5D21B60", Offset = "0x5D20B60", VA = "0x185D21B60", Slot = "11")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
internal class CJGODHKDOBK : FPAACNFKCED, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	private struct NOHHCDLCNAJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public CJGODHKDOBK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x5D22BD0", Offset = "0x5D21BD0", VA = "0x185D22BD0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x5D22E50", Offset = "0x5D21E50", VA = "0x185D22E50", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	private readonly MIOAKCNPAIL OCNBNKFEBFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	private readonly MJEBKIJPJFF CHDNMPPKMOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	private readonly APINBDFMKOH PDIBILKHEBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private bool EDDFAKMICOP;

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x5D1EFD0", Offset = "0x5D1DFD0", VA = "0x185D1EFD0")]
	internal CJGODHKDOBK(MJEBKIJPJFF CHDNMPPKMOG, APINBDFMKOH PDIBILKHEBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x5D1EEE0", Offset = "0x5D1DEE0", VA = "0x185D1EEE0", Slot = "4")]
	[AsyncStateMachine(typeof(NOHHCDLCNAJ))]
	public Task GJDMNPCIAHB([Optional] CancellationToken JEBPNJAPHEL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x5D1ED30", Offset = "0x5D1DD30", VA = "0x185D1ED30", Slot = "5")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
internal readonly struct AELMDIDBLGG : IEquatable<AELMDIDBLGG>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public readonly bool JJHICGOPJOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	public readonly float EPHHBEAPOAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	public readonly float OBGEJPLCAKE;

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x5D1E7F0", Offset = "0x5D1D7F0", VA = "0x185D1E7F0")]
	public AELMDIDBLGG(float JIHKKGCPEGL, float GNOBHKOCPOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x5D1E5E0", Offset = "0x5D1D5E0", VA = "0x185D1E5E0", Slot = "4")]
	public bool Equals(AELMDIDBLGG EJEDDDCGMMB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x5D1E620", Offset = "0x5D1D620", VA = "0x185D1E620", Slot = "0")]
	public override bool Equals(object? GPCHHCACPPJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x5D1E6D0", Offset = "0x5D1D6D0", VA = "0x185D1E6D0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x5D1E750", Offset = "0x5D1D750", VA = "0x185D1E750", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
internal class GLDHBLDGNEP
{
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public enum MJGOIGPACHJ : byte
	{
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		FastestFade,
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		SlowestFade
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	private readonly MJGOIGPACHJ CMBMKFKNLLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	private readonly Dictionary<object, AELMDIDBLGG> MLHAMCOJDEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	private readonly AELMDIDBLGG BNHPGKHDHIN;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public AELMDIDBLGG INAJMIAKCCF
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x89B130", Offset = "0x89A130", VA = "0x18089B130")]
		[CompilerGenerated]
		get
		{
			return default(AELMDIDBLGG);
		}
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x89ACE0", Offset = "0x899CE0", VA = "0x18089ACE0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x5D202C0", Offset = "0x5D1F2C0", VA = "0x185D202C0")]
	public GLDHBLDGNEP(MJGOIGPACHJ CMBMKFKNLLJ, AELMDIDBLGG BNHPGKHDHIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x5D20040", Offset = "0x5D1F040", VA = "0x185D20040")]
	public void MLOHBEEHILC(object PDIBILKHEBM, AELMDIDBLGG DJPCLCJBNGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x5D20160", Offset = "0x5D1F160", VA = "0x185D20160")]
	public void MOJJDBCCFOB(object PDIBILKHEBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x5D20270", Offset = "0x5D1F270", VA = "0x185D20270")]
	public void PMEKKAMOFIE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x5D201D0", Offset = "0x5D1F1D0", VA = "0x185D201D0")]
	private void PCOKKEIEKMF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x5D1FE20", Offset = "0x5D1EE20", VA = "0x185D1FE20")]
	private AELMDIDBLGG FMOHHHCMGDI()
	{
		return default(AELMDIDBLGG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x5D20000", Offset = "0x5D1F000", VA = "0x185D20000")]
	private AELMDIDBLGG KNABGGIGDHJ()
	{
		return default(AELMDIDBLGG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x5D1FE60", Offset = "0x5D1EE60", VA = "0x185D1FE60")]
	private AELMDIDBLGG FOGLGGLMIPI(int BHHABMJGFOP)
	{
		return default(AELMDIDBLGG);
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
