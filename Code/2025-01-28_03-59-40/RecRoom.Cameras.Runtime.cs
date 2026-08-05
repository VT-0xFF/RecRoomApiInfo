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
		[Cpp2IlInjected.Address(RVA = "0x91D620", Offset = "0x91C820", VA = "0x18091D620")]
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
		[Cpp2IlInjected.Address(RVA = "0x7106BE0", Offset = "0x7105DE0", VA = "0x187106BE0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x91E490", Offset = "0x91D690", VA = "0x18091E490")]
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
		[Cpp2IlInjected.Address(RVA = "0x91E4D0", Offset = "0x91D6D0", VA = "0x18091E4D0")]
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
	public class LogRegistrationIndex : FOFAFNFGNAM
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x7106B50", Offset = "0x7105D50", VA = "0x187106B50", Slot = "4")]
		public override void JMFBCAGPLCG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x91D620", Offset = "0x91C820", VA = "0x18091D620")]
		public LogRegistrationIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[KHFOLODBECL]
public class BGPAEBHAHCM : DMOINKDAIOD, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	internal enum GJLDPOHEMHN
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
	private struct CGNOHCHKBDJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public BGPAEBHAHCM <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x71041E0", Offset = "0x71033E0", VA = "0x1871041E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x7104620", Offset = "0x7103820", VA = "0x187104620", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private sealed class HLMLOEMACLK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		public CancellationTokenSource cts;

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x901140", Offset = "0x900340", VA = "0x180901140")]
		public HLMLOEMACLK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x7106450", Offset = "0x7105650", VA = "0x187106450")]
		internal void EGDBDEBFKID(GJLDPOHEMHN fadeState)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CompilerGenerated]
	private struct GHIAEDDHHNA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		public GJLDPOHEMHN completedState;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		public BGPAEBHAHCM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		public Func<EPNAGPNOPCG> durationFetch;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public float endOpacity;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private HLMLOEMACLK <>8__1;

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
		[Cpp2IlInjected.Address(RVA = "0x7105360", Offset = "0x7104560", VA = "0x187105360", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x71063A0", Offset = "0x71055A0", VA = "0x1871063A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private struct FHAONHHBHCN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public BGPAEBHAHCM <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x7104EC0", Offset = "0x71040C0", VA = "0x187104EC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x7105300", Offset = "0x7104500", VA = "0x187105300", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private sealed class HFDBKNELDBG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public TaskCompletionSource<GJLDPOHEMHN> tcs;

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x901140", Offset = "0x900340", VA = "0x180901140")]
		public HFDBKNELDBG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x7106400", Offset = "0x7105600", VA = "0x187106400")]
		internal void HDDDOCBKKNC()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[CompilerGenerated]
	private struct IAALJMNLLDA : IAsyncStateMachine
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
		public ICollection<TaskCompletionSource<GJLDPOHEMHN>> tcsList;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private HFDBKNELDBG <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private IDisposable <registration>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private TaskAwaiter<GJLDPOHEMHN> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x7106480", Offset = "0x7105680", VA = "0x187106480", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x7106AF0", Offset = "0x7105CF0", VA = "0x187106AF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private static readonly KJMCEDJMPPA MOKKIOIDAGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly ECCAIAKMGHM LCJHFFPOEEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private readonly FLLLOCNKNGF HDJNHJFPNJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly AFJINEAEPKI APAGJACOOAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly HKANKPBEDCO OBPLEGCFDJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private readonly AEIKKPCLJPA CJHNJLPANHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly Func<Task> MJNEPHIJPIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private readonly DLLCFIMALMF KNOFPMOIMCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private readonly DLLCFIMALMF LBKHJPKALNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private readonly CancellationTokenSource PJCPEOFKNIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly CancellationToken NPAGHABDOFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private readonly INKODEHPGIM<IGCCAEFBMNB> MAKODDCIAME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private readonly object AAECBPEMGFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private readonly object AFNCFJENHOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private readonly List<TaskCompletionSource<GJLDPOHEMHN>> NCGLPLPEHAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private readonly List<TaskCompletionSource<GJLDPOHEMHN>> DOCFLLGJOBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private GJLDPOHEMHN JPAAMKCKIHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9C")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	internal bool GDAAKCBHADH;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public bool IMHLMPPAPDD
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x7102600", Offset = "0x7101800", VA = "0x187102600", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public bool KDLHJIFMGPL
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x71028B0", Offset = "0x7101AB0", VA = "0x1871028B0", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool KKGKGHDPHJD
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x71025F0", Offset = "0x71017F0", VA = "0x1871025F0", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public float CAPNCGINNDD
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xAAAD70", Offset = "0xAA9F70", VA = "0x180AAAD70", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0xAFC9B0", Offset = "0xAFBBB0", VA = "0x180AFC9B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	private GJLDPOHEMHN PJKPHNCALLI
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0xC587D0", Offset = "0xC579D0", VA = "0x180C587D0")]
		get
		{
			return default(GJLDPOHEMHN);
		}
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x7103380", Offset = "0x7102580", VA = "0x187103380")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public bool CABNBOPAEKH
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x7103060", Offset = "0x7102260", VA = "0x187103060", Slot = "11")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	private event Action<GJLDPOHEMHN> EKFPBNGEGIF
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x71023B0", Offset = "0x71015B0", VA = "0x1871023B0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x7102760", Offset = "0x7101960", VA = "0x187102760")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x7104190", Offset = "0x7103390", VA = "0x187104190")]
	[RecRoom.NoEngine.Common.Preserve]
	public BGPAEBHAHCM([FMJHJHHALCB(null)] ECCAIAKMGHM LCJHFFPOEEO, [FMJHJHHALCB(null)] FLLLOCNKNGF HDJNHJFPNJG, [FMJHJHHALCB(null)] AFJINEAEPKI APAGJACOOAN, [FMJHJHHALCB("CameraFadeTimeoutDetector")] HKANKPBEDCO OBPLEGCFDJN, [FMJHJHHALCB(null)] AEIKKPCLJPA CJHNJLPANHO, [FMJHJHHALCB(null)] OIKOPNNNFIE<CameraFadeOptions> GPDCLNOGPJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x7103AE0", Offset = "0x7102CE0", VA = "0x187103AE0")]
	internal BGPAEBHAHCM(ECCAIAKMGHM LCJHFFPOEEO, FLLLOCNKNGF HDJNHJFPNJG, AFJINEAEPKI APAGJACOOAN, HKANKPBEDCO OBPLEGCFDJN, AEIKKPCLJPA CJHNJLPANHO, OIKOPNNNFIE<CameraFadeOptions> GPDCLNOGPJC, Func<Task>? MJNEPHIJPIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x71028C0", Offset = "0x7101AC0", VA = "0x1871028C0", Slot = "8")]
	public KJMDLICJGGB EIMOKJGFPEG(IGCCAEFBMNB BCOHKLCJCPM, [Optional] PEJHLIPHDFL? OMKPHDAKNBO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x7103500", Offset = "0x7102700", VA = "0x187103500", Slot = "9")]
	[AsyncStateMachine(typeof(CGNOHCHKBDJ))]
	public Task IKIPPGDIELH([Optional] CancellationToken BGEKICMONBE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x7102860", Offset = "0x7101A60", VA = "0x187102860", Slot = "10")]
	public IReadOnlyCollection<IGCCAEFBMNB> EAFIBPBEMJI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x7102470", Offset = "0x7101670", VA = "0x187102470")]
	internal void BMIKLDJDBEF(IGCCAEFBMNB BCOHKLCJCPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x7103720", Offset = "0x7102920", VA = "0x187103720")]
	private EPNAGPNOPCG KMMFJFNHNPH()
	{
		return default(EPNAGPNOPCG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x7102F30", Offset = "0x7102130", VA = "0x187102F30")]
	private EPNAGPNOPCG ELNPLDJGLBF()
	{
		return default(EPNAGPNOPCG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x71030D0", Offset = "0x71022D0", VA = "0x1871030D0")]
	internal void FOPHIPHMEMM(IGCCAEFBMNB BCOHKLCJCPM, PEJHLIPHDFL ECNJPPHPFLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x71035F0", Offset = "0x71027F0", VA = "0x1871035F0")]
	private static void JJHPNDLNJKE(IReadOnlyList<TaskCompletionSource<GJLDPOHEMHN>> MCLFEBHNDCE, GJLDPOHEMHN GNGFMPDKHCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x71038C0", Offset = "0x7102AC0", VA = "0x1871038C0")]
	private void NLGHKCCMFMO(float PIMODJKILFC, Func<EPNAGPNOPCG> JCIHBKCCGAH, GJLDPOHEMHN ADJDNGMDLHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x7103750", Offset = "0x7102950", VA = "0x187103750")]
	private static bool MBBMKEPAFEI(float KKLLOEEDINO, float NHCGDJCFKIC, float NOFNBBDPPIC = 0.0001f)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x7102620", Offset = "0x7101820", VA = "0x187102620")]
	[AsyncStateMachine(typeof(GHIAEDDHHNA))]
	private Task DCIGPONHPLK(CancellationToken LHPAGMJCDIN, float PIMODJKILFC, Func<EPNAGPNOPCG> PCCKBFCAAJH, GJLDPOHEMHN ADJDNGMDLHJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x7102F60", Offset = "0x7102160", VA = "0x187102F60")]
	private void EOBEMICMIPE(float AGNLMKHHOML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x71037D0", Offset = "0x71029D0", VA = "0x1871037D0")]
	[AsyncStateMachine(typeof(FHAONHHBHCN))]
	internal Task NJIBPFJNJLK([Optional] CancellationToken BGEKICMONBE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x7103280", Offset = "0x7102480", VA = "0x187103280")]
	[AsyncStateMachine(typeof(IAALJMNLLDA))]
	private static Task HNGGDBOKKGJ(ICollection<TaskCompletionSource<GJLDPOHEMHN>> MCLFEBHNDCE, CancellationToken BGEKICMONBE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x7102820", Offset = "0x7101A20", VA = "0x187102820", Slot = "12")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
internal class ACLLLOPJCGD : KJMDLICJGGB, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[CompilerGenerated]
	private struct BDDPEPNNOBL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public ACLLLOPJCGD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x71020D0", Offset = "0x71012D0", VA = "0x1871020D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x7102350", Offset = "0x7101550", VA = "0x187102350", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private static readonly string GHHFBPDNMND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	private readonly ADFPDBNKNIO JODDCHLNJDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	private readonly BGPAEBHAHCM BPOHFIDEMLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	private readonly IGCCAEFBMNB BCOHKLCJCPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	private bool CLAMDNBMMAC;

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x7101FD0", Offset = "0x71011D0", VA = "0x187101FD0")]
	internal ACLLLOPJCGD(BGPAEBHAHCM BPOHFIDEMLG, IGCCAEFBMNB BCOHKLCJCPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x7101E50", Offset = "0x7101050", VA = "0x187101E50", Slot = "4")]
	[AsyncStateMachine(typeof(BDDPEPNNOBL))]
	public Task GMFDKCNAAKK([Optional] CancellationToken BGEKICMONBE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x7101CA0", Offset = "0x7100EA0", VA = "0x187101CA0", Slot = "5")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
internal readonly struct EPNAGPNOPCG : IEquatable<EPNAGPNOPCG>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	public readonly bool AKMLIJFCJIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	public readonly float EHLECPGNMCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	public readonly float DHJIHLKKOGC;

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x7104DF0", Offset = "0x7103FF0", VA = "0x187104DF0")]
	public EPNAGPNOPCG(float PMKKNEFODKC, float NHFPPHNGOPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x7104BE0", Offset = "0x7103DE0", VA = "0x187104BE0", Slot = "4")]
	public bool Equals(EPNAGPNOPCG JAINJPLCLDO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x7104C20", Offset = "0x7103E20", VA = "0x187104C20", Slot = "0")]
	public override bool Equals(object? LCACGJDNDHA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x7104CD0", Offset = "0x7103ED0", VA = "0x187104CD0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x7104D50", Offset = "0x7103F50", VA = "0x187104D50", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
internal class DLLCFIMALMF
{
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public enum MAEKDANBADA : byte
	{
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		FastestFade,
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		SlowestFade
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private readonly MAEKDANBADA OIGOGFIAFND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private readonly Dictionary<object, EPNAGPNOPCG> HJHDLOHHNGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private readonly EPNAGPNOPCG MJIKPGNFPHJ;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public EPNAGPNOPCG ELOFPHHKCIM
	{
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0xBB4950", Offset = "0xBB3B50", VA = "0x180BB4950")]
		[CompilerGenerated]
		get
		{
			return default(EPNAGPNOPCG);
		}
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0xBB4A90", Offset = "0xBB3C90", VA = "0x180BB4A90")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x7104B20", Offset = "0x7103D20", VA = "0x187104B20")]
	public DLLCFIMALMF(MAEKDANBADA OIGOGFIAFND, EPNAGPNOPCG MJIKPGNFPHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x7104A00", Offset = "0x7103C00", VA = "0x187104A00")]
	public void MLJBCMJPNEN(object BCOHKLCJCPM, EPNAGPNOPCG AJHOLDNIPAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x71047F0", Offset = "0x71039F0", VA = "0x1871047F0")]
	public void GMODDBABBFK(object BCOHKLCJCPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x7104760", Offset = "0x7103960", VA = "0x187104760")]
	public void DBGBEIOBMKO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x71046C0", Offset = "0x71038C0", VA = "0x1871046C0")]
	private void BALAEKCABAD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x7104680", Offset = "0x7103880", VA = "0x187104680")]
	private EPNAGPNOPCG AMGFFBFJAGD()
	{
		return default(EPNAGPNOPCG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x71047B0", Offset = "0x71039B0", VA = "0x1871047B0")]
	private EPNAGPNOPCG DDNGCJLOLNH()
	{
		return default(EPNAGPNOPCG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x7104860", Offset = "0x7103A60", VA = "0x187104860")]
	private EPNAGPNOPCG IJKNOOKJFIL(int HHCLLHKCKOO)
	{
		return default(EPNAGPNOPCG);
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
