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
using RecRoom.Logging.Attributes;
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
		[Cpp2IlInjected.Address(RVA = "0x8AF980", Offset = "0x8ADF80", VA = "0x1808AF980")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[Microsoft.CodeAnalysis.Embedded]
	[CompilerGenerated]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter, AllowMultiple = false, Inherited = false)]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x6A5EED0", Offset = "0x6A5D4D0", VA = "0x186A5EED0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x8B0AE0", Offset = "0x8AF0E0", VA = "0x1808B0AE0")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x8B0B20", Offset = "0x8AF120", VA = "0x1808B0B20")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
namespace _LogRegistration.RecRoom_Cameras_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[RecRoom.Logging.Attributes.Preserve]
	[CompilerGenerated]
	public class LogRegistrationIndex : BGIOGCHCHCM
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x6A5EE40", Offset = "0x6A5D440", VA = "0x186A5EE40", Slot = "4")]
		public override void JJJMHPMEAIK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x8AF980", Offset = "0x8ADF80", VA = "0x1808AF980")]
		public LogRegistrationIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[NHFFCNPJGMC]
public class GJIELAFFKOA : EEGEOAIGKHO, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	internal enum EFPCDAPJLCI
	{
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		Invalid,
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		ShowingCamera,
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		FadingToBlack,
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		ShowingBlack,
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		FadingToCamera
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private struct ABOBICEKLDK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public GJIELAFFKOA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private CancellationTokenSource <tokenSource>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x6A5A680", Offset = "0x6A58C80", VA = "0x186A5A680", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x6A5AAB0", Offset = "0x6A590B0", VA = "0x186A5AAB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private sealed class KIAMEJCIDIF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		public CancellationTokenSource cts;

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x8912C0", Offset = "0x88F8C0", VA = "0x1808912C0")]
		public KIAMEJCIDIF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x6A5E3D0", Offset = "0x6A5C9D0", VA = "0x186A5E3D0")]
		internal void ABDAEOHFLNC(EFPCDAPJLCI fadeState)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CompilerGenerated]
	private struct BADPNBFMFCP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		public EFPCDAPJLCI completedState;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		public GJIELAFFKOA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		public Func<BFGAIIKGIIB> durationFetch;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public float endOpacity;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private KIAMEJCIDIF <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private object <animateInOutSuppressionToken>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private float <transitionStart>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private CancellationToken <cancellationToken>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private object <>7__wrap4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private int <>7__wrap5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private float? <lastFadeSlope>5__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private float <lerpTimeStart>5__8;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private float <lerpTimeEnd>5__9;

		[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private float <lerpStartValue>5__10;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private float <lerpEndValue>5__11;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x6A5AB10", Offset = "0x6A59110", VA = "0x186A5AB10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x6A5BB40", Offset = "0x6A5A140", VA = "0x186A5BB40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private struct LKKFJADOKBH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public GJIELAFFKOA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private CancellationTokenSource <tokenSource>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x6A5E9B0", Offset = "0x6A5CFB0", VA = "0x186A5E9B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x6A5EDE0", Offset = "0x6A5D3E0", VA = "0x186A5EDE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private sealed class KPMPBCABEHO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public TaskCompletionSource<EFPCDAPJLCI> tcs;

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x8912C0", Offset = "0x88F8C0", VA = "0x1808912C0")]
		public KPMPBCABEHO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x6A5E400", Offset = "0x6A5CA00", VA = "0x186A5E400")]
		internal void CAAPGMEANIE()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[CompilerGenerated]
	private struct OPANPJHDNBL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public ICollection<TaskCompletionSource<EFPCDAPJLCI>> tcsList;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private KPMPBCABEHO <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private IDisposable <registration>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private TaskAwaiter<EFPCDAPJLCI> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x6A5EF50", Offset = "0x6A5D550", VA = "0x186A5EF50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x6A5F5C0", Offset = "0x6A5DBC0", VA = "0x186A5F5C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private static readonly CMICIECANPG FPPDOFKLJHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly CECBMOAOPOL FGAFMALKNGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private readonly NCHEPLAKICF NIFGDGPJONE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly LEBBOCDPOJL JGGOGAFIBCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly FBOOCBJFLEP JGGFKNPGHFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private readonly MNJPELKAOIM BCFFMMGGNHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly Func<Task> PDFGECKMIKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private readonly LCIDEFJMLHM AMMKHEOLPNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private readonly LCIDEFJMLHM NOBCAAENKOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private readonly CancellationTokenSource ODFDCEOBEAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly CancellationToken PENOJLKKMIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private readonly FNNHLEBNCBD<EAFCCNKEDEM> BNPLLHAEBLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private readonly object ILIMGNGLNKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private readonly object APJNLDKHFKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private readonly List<TaskCompletionSource<EFPCDAPJLCI>> MAJIECHFEJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private readonly List<TaskCompletionSource<EFPCDAPJLCI>> NPIHPNEFEMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private EFPCDAPJLCI PKDLNJPJIGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9C")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	internal bool LFMABGEEONG;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public bool COGKAIOBEJA
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x6A5C2A0", Offset = "0x6A5A8A0", VA = "0x186A5C2A0", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public bool LAJOIFAONFL
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x6A5C2F0", Offset = "0x6A5A8F0", VA = "0x186A5C2F0", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool PGDPDFINFMK
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x6A5C300", Offset = "0x6A5A900", VA = "0x186A5C300", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public float MELBGLGBDFA
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xB34CF0", Offset = "0xB332F0", VA = "0x180B34CF0", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0xB64DC0", Offset = "0xB633C0", VA = "0x180B64DC0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	private EFPCDAPJLCI CCMNMDEJADK
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0xF76270", Offset = "0xF74870", VA = "0x180F76270")]
		get
		{
			return default(EFPCDAPJLCI);
		}
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x6A5C7E0", Offset = "0x6A5ADE0", VA = "0x186A5C7E0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public bool HGIKFLEEHOD
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x6A5CDE0", Offset = "0x6A5B3E0", VA = "0x186A5CDE0", Slot = "11")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	private event Action<EFPCDAPJLCI> HDBDDALBHOC
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x6A5CD20", Offset = "0x6A5B320", VA = "0x186A5CD20")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x6A5C350", Offset = "0x6A5A950", VA = "0x186A5C350")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x6A5E0A0", Offset = "0x6A5C6A0", VA = "0x186A5E0A0")]
	[RecRoom.NoEngine.Common.Preserve]
	public GJIELAFFKOA([OLJNBPOCBCJ(null)] CECBMOAOPOL FGAFMALKNGF, [OLJNBPOCBCJ(null)] NCHEPLAKICF NIFGDGPJONE, [OLJNBPOCBCJ(null)] LEBBOCDPOJL JGGOGAFIBCM, [OLJNBPOCBCJ("CameraFadeTimeoutDetector")] FBOOCBJFLEP JGGFKNPGHFI, [OLJNBPOCBCJ(null)] MNJPELKAOIM BCFFMMGGNHH, [OLJNBPOCBCJ(null)] BOPGAAOHCAO<CameraFadeOptions> CLJCAFMAPFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x6A5D9F0", Offset = "0x6A5BFF0", VA = "0x186A5D9F0")]
	internal GJIELAFFKOA(CECBMOAOPOL FGAFMALKNGF, NCHEPLAKICF NIFGDGPJONE, LEBBOCDPOJL JGGOGAFIBCM, FBOOCBJFLEP JGGFKNPGHFI, MNJPELKAOIM BCFFMMGGNHH, BOPGAAOHCAO<CameraFadeOptions> CLJCAFMAPFP, Func<Task>? PDFGECKMIKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x6A5D2F0", Offset = "0x6A5B8F0", VA = "0x186A5D2F0", Slot = "8")]
	public PDAOGCILCGI OMOCCBGMPMA(EAFCCNKEDEM FLLNLBHFENG, [Optional] CLBMAILFFFC? MBBMCCMEHKA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x6A5CA50", Offset = "0x6A5B050", VA = "0x186A5CA50", Slot = "9")]
	[AsyncStateMachine(typeof(ABOBICEKLDK))]
	public Task IBJIBLNAPAD([Optional] CancellationToken IONNNJNKLMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x6A5CCD0", Offset = "0x6A5B2D0", VA = "0x186A5CCD0", Slot = "10")]
	public IReadOnlyCollection<EAFCCNKEDEM> KIGHPKMPIGL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x6A5C660", Offset = "0x6A5AC60", VA = "0x186A5C660")]
	internal void GMCMGLCEAKF(EAFCCNKEDEM FLLNLBHFENG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x6A5D2C0", Offset = "0x6A5B8C0", VA = "0x186A5D2C0")]
	private BFGAIIKGIIB OFKMIDEEKFB()
	{
		return default(BFGAIIKGIIB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x6A5C2C0", Offset = "0x6A5A8C0", VA = "0x186A5C2C0")]
	private BFGAIIKGIIB BKEMKLCKPMA()
	{
		return default(BFGAIIKGIIB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x6A5CF90", Offset = "0x6A5B590", VA = "0x186A5CF90")]
	internal void MGEKFBEGMKL(EAFCCNKEDEM FLLNLBHFENG, CLBMAILFFFC MKIILFDIKNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x6A5CE50", Offset = "0x6A5B450", VA = "0x186A5CE50")]
	private static void MBLMOMBKEHC(IReadOnlyList<TaskCompletionSource<EFPCDAPJLCI>> BHBDMAIPDDC, EFPCDAPJLCI FHELMKILDKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x6A5CB40", Offset = "0x6A5B140", VA = "0x186A5CB40")]
	private void JHLILELNEBC(float OKMLNIJAMGF, Func<BFGAIIKGIIB> ADGFAHCINMA, EFPCDAPJLCI EGEAEGKLJMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x6A5D140", Offset = "0x6A5B740", VA = "0x186A5D140")]
	private static bool NADDAMGHMGN(float MOKDKAEJAPP, float MKGNFMMEFHC, float LMAJKHMLMPD = 0.0001f)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x6A5C410", Offset = "0x6A5AA10", VA = "0x186A5C410")]
	[AsyncStateMachine(typeof(BADPNBFMFCP))]
	private Task FNBJFNHHLNO(CancellationToken LBFDJGLPAMK, float OKMLNIJAMGF, Func<BFGAIIKGIIB> CFGBCFJEPMG, EFPCDAPJLCI EGEAEGKLJMD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x6A5C550", Offset = "0x6A5AB50", VA = "0x186A5C550")]
	private void GFFPCPNFMOB(float HGBLEEODKPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x6A5C960", Offset = "0x6A5AF60", VA = "0x186A5C960")]
	[AsyncStateMachine(typeof(LKKFJADOKBH))]
	internal Task HIEOBFEPFPN([Optional] CancellationToken IONNNJNKLMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x6A5D1C0", Offset = "0x6A5B7C0", VA = "0x186A5D1C0")]
	[AsyncStateMachine(typeof(OPANPJHDNBL))]
	private static Task NIJNGDKJHGM(ICollection<TaskCompletionSource<EFPCDAPJLCI>> BHBDMAIPDDC, CancellationToken IONNNJNKLMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x6A5C310", Offset = "0x6A5A910", VA = "0x186A5C310", Slot = "12")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
internal class EOHBPFJFLHC : PDAOGCILCGI, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[CompilerGenerated]
	private struct HIGAGGPHHEB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public EOHBPFJFLHC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x6A5E0F0", Offset = "0x6A5C6F0", VA = "0x186A5E0F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x6A5E370", Offset = "0x6A5C970", VA = "0x186A5E370", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private static readonly string MAHAGFFCNBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	private readonly OGMGECKBGAC PPEADJBLEAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	private readonly GJIELAFFKOA NDGOGLFJEPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	private readonly EAFCCNKEDEM FLLNLBHFENG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	private bool HHCLANPDDNK;

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x6A5C1A0", Offset = "0x6A5A7A0", VA = "0x186A5C1A0")]
	internal EOHBPFJFLHC(GJIELAFFKOA NDGOGLFJEPL, EAFCCNKEDEM FLLNLBHFENG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x6A5C030", Offset = "0x6A5A630", VA = "0x186A5C030", Slot = "4")]
	[AsyncStateMachine(typeof(HIGAGGPHHEB))]
	public Task JOJLPGCBIGG([Optional] CancellationToken IONNNJNKLMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x6A5BE80", Offset = "0x6A5A480", VA = "0x186A5BE80", Slot = "5")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
internal readonly struct BFGAIIKGIIB : IEquatable<BFGAIIKGIIB>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	public readonly bool LCMNGGDBBIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	public readonly float OPCAOFJKNHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	public readonly float KCDDIEAAKMI;

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x6A5BDB0", Offset = "0x6A5A3B0", VA = "0x186A5BDB0")]
	public BFGAIIKGIIB(float ICCODBNIHBP, float MCPPIEMELEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x6A5BBA0", Offset = "0x6A5A1A0", VA = "0x186A5BBA0", Slot = "4")]
	public bool Equals(BFGAIIKGIIB PLNBHPCFEOK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x6A5BBE0", Offset = "0x6A5A1E0", VA = "0x186A5BBE0", Slot = "0")]
	public override bool Equals(object? GHMNBJIOGAM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x6A5BC90", Offset = "0x6A5A290", VA = "0x186A5BC90", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x6A5BD10", Offset = "0x6A5A310", VA = "0x186A5BD10", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
internal class LCIDEFJMLHM
{
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public enum DLKNKGKELHA : byte
	{
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		FastestFade,
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		SlowestFade
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private readonly DLKNKGKELHA DBMMHEPNHIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private readonly Dictionary<object, BFGAIIKGIIB> FEIGALEAJBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private readonly BFGAIIKGIIB OKFKAJMGBDO;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public BFGAIIKGIIB PGPGCBGPPOH
	{
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0xCA7230", Offset = "0xCA5830", VA = "0x180CA7230")]
		[CompilerGenerated]
		get
		{
			return default(BFGAIIKGIIB);
		}
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0xCA77D0", Offset = "0xCA5DD0", VA = "0x180CA77D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x6A5E8F0", Offset = "0x6A5CEF0", VA = "0x186A5E8F0")]
	public LCIDEFJMLHM(DLKNKGKELHA DBMMHEPNHIH, BFGAIIKGIIB OKFKAJMGBDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x6A5E450", Offset = "0x6A5CA50", VA = "0x186A5E450")]
	public void AOODIPOHCIK(object FLLNLBHFENG, BFGAIIKGIIB CDCFCCCJEOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x6A5E5B0", Offset = "0x6A5CBB0", VA = "0x186A5E5B0")]
	public void MBEEDABKNGP(object FLLNLBHFENG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x6A5E6C0", Offset = "0x6A5CCC0", VA = "0x186A5E6C0")]
	public void MPAAPCHGDCP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x6A5E620", Offset = "0x6A5CC20", VA = "0x186A5E620")]
	private void MJHGDOJCIIC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x6A5E710", Offset = "0x6A5CD10", VA = "0x186A5E710")]
	private BFGAIIKGIIB PKCFBFNKBMD()
	{
		return default(BFGAIIKGIIB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x6A5E570", Offset = "0x6A5CB70", VA = "0x186A5E570")]
	private BFGAIIKGIIB EPLPDLKKLIC()
	{
		return default(BFGAIIKGIIB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x6A5E750", Offset = "0x6A5CD50", VA = "0x186A5E750")]
	private BFGAIIKGIIB PMKPCENGHBI(int DJHEPFHAJAI)
	{
		return default(BFGAIIKGIIB);
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
