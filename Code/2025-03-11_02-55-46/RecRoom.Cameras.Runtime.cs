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
		[Cpp2IlInjected.Address(RVA = "0x98FE40", Offset = "0x98F240", VA = "0x18098FE40")]
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
		[Cpp2IlInjected.Address(RVA = "0x74C9FC0", Offset = "0x74C93C0", VA = "0x1874C9FC0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x990590", Offset = "0x98F990", VA = "0x180990590")]
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
		[Cpp2IlInjected.Address(RVA = "0x9905D0", Offset = "0x98F9D0", VA = "0x1809905D0")]
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
	public class LogRegistrationIndex : KENHJELJHDP
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x74C9C50", Offset = "0x74C9050", VA = "0x1874C9C50", Slot = "4")]
		public override void ICLMLJMBJAH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x98FE40", Offset = "0x98F240", VA = "0x18098FE40")]
		public LogRegistrationIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[MENIDINFMMJ]
public class KAPNCPHAHHF : MOEMPDODMEG, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	internal enum DGCEFDKBMEI
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
	private struct LMEEEMAMPBG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public KAPNCPHAHHF <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x74C97B0", Offset = "0x74C8BB0", VA = "0x1874C97B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x74C9BF0", Offset = "0x74C8FF0", VA = "0x1874C9BF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private sealed class CBBLKODANOB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		public CancellationTokenSource cts;

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x96D700", Offset = "0x96CB00", VA = "0x18096D700")]
		public CBBLKODANOB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x74C50B0", Offset = "0x74C44B0", VA = "0x1874C50B0")]
		internal void HAFOGDIPOLO(DGCEFDKBMEI fadeState)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CompilerGenerated]
	private struct HGNBPELECFH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		public DGCEFDKBMEI completedState;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		public KAPNCPHAHHF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		public Func<CJPEGDNDKKA> durationFetch;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public float endOpacity;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private CBBLKODANOB <>8__1;

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
		[Cpp2IlInjected.Address(RVA = "0x74C57E0", Offset = "0x74C4BE0", VA = "0x1874C57E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x74C6820", Offset = "0x74C5C20", VA = "0x1874C6820", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private struct HJNFFENJODK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public KAPNCPHAHHF <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x74C6880", Offset = "0x74C5C80", VA = "0x1874C6880", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x74C6CC0", Offset = "0x74C60C0", VA = "0x1874C6CC0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private sealed class LEDOKIJBMHO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public TaskCompletionSource<DGCEFDKBMEI> tcs;

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x96D700", Offset = "0x96CB00", VA = "0x18096D700")]
		public LEDOKIJBMHO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x74C8B30", Offset = "0x74C7F30", VA = "0x1874C8B30")]
		internal void PPAAPHFKAGP()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[CompilerGenerated]
	private struct LGMOPAJEJNJ : IAsyncStateMachine
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
		public ICollection<TaskCompletionSource<DGCEFDKBMEI>> tcsList;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private LEDOKIJBMHO <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private IDisposable <registration>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private TaskAwaiter<DGCEFDKBMEI> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x74C8B80", Offset = "0x74C7F80", VA = "0x1874C8B80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x74C91F0", Offset = "0x74C85F0", VA = "0x1874C91F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private static readonly HLBHMADGLFA GCIBFPDCNDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly NGAPCMMMDNE JCNBACMLAFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private readonly KFCAGMIGMAK ELBCKLBJJEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly PAJFLGMBLIE OFOFLKGFIFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly LFEJENGEAGE BHFAEGODGLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private readonly BPDKBFIANMO BEIGAAKBPFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly Func<Task> DNHIMGNKJGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private readonly LIJGHEMFIFK MECEOFKNFAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private readonly LIJGHEMFIFK HINEGPAOBAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private readonly CancellationTokenSource HFLEFCCDEKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly CancellationToken AGBLPMNAHKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private readonly NJCGFGFFEKA<JBBPIGEHCDP> GHIPNBAACDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private readonly object JMCJJKGIBOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private readonly object IFLHPIOFKGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private readonly List<TaskCompletionSource<DGCEFDKBMEI>> CHPNCJBKLJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private readonly List<TaskCompletionSource<DGCEFDKBMEI>> DGMJLDICHEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private DGCEFDKBMEI CLMOMGPMILL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9C")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	internal bool PNDPLIEPIEL;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public bool BFFNNHIFKAM
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x74C7DC0", Offset = "0x74C71C0", VA = "0x1874C7DC0", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public bool GEFKCBIIHMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x659C6A0", Offset = "0x659BAA0", VA = "0x18659C6A0", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool AOAJOHJEGPC
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x29C1E80", Offset = "0x29C1280", VA = "0x1829C1E80", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public float GCABPIAMCOO
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xB0AF90", Offset = "0xB0A390", VA = "0x180B0AF90", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0xB701C0", Offset = "0xB6F5C0", VA = "0x180B701C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	private DGCEFDKBMEI CMAACNMCPCM
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0xCB7F10", Offset = "0xCB7310", VA = "0x180CB7F10")]
		get
		{
			return default(DGCEFDKBMEI);
		}
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x74C6F90", Offset = "0x74C6390", VA = "0x1874C6F90")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public bool FOGKPOFHNHC
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x74C7BA0", Offset = "0x74C6FA0", VA = "0x1874C7BA0", Slot = "11")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	private event Action<DGCEFDKBMEI> FDNHGKMBOOL
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x74C6ED0", Offset = "0x74C62D0", VA = "0x1874C6ED0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x74C82A0", Offset = "0x74C76A0", VA = "0x1874C82A0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x74C8AE0", Offset = "0x74C7EE0", VA = "0x1874C8AE0")]
	[RecRoom.NoEngine.Common.Preserve]
	public KAPNCPHAHHF([PNFCCJKFMBH(null)] NGAPCMMMDNE JCNBACMLAFF, [PNFCCJKFMBH(null)] KFCAGMIGMAK ELBCKLBJJEN, [PNFCCJKFMBH(null)] PAJFLGMBLIE OFOFLKGFIFD, [PNFCCJKFMBH("CameraFadeTimeoutDetector")] LFEJENGEAGE BHFAEGODGLN, [PNFCCJKFMBH(null)] BPDKBFIANMO BEIGAAKBPFK, [PNFCCJKFMBH(null)] FDJAODJIBPM<CameraFadeOptions> OMCEIGOCOKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x74C8430", Offset = "0x74C7830", VA = "0x1874C8430")]
	internal KAPNCPHAHHF(NGAPCMMMDNE JCNBACMLAFF, KFCAGMIGMAK ELBCKLBJJEN, PAJFLGMBLIE OFOFLKGFIFD, LFEJENGEAGE BHFAEGODGLN, BPDKBFIANMO BEIGAAKBPFK, FDJAODJIBPM<CameraFadeOptions> OMCEIGOCOKM, Func<Task>? DNHIMGNKJGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x74C7440", Offset = "0x74C6840", VA = "0x1874C7440", Slot = "8")]
	public LJPNEKMEFMK HJJIKICLJOE(JBBPIGEHCDP OCDOGNMJENC, [Optional] BABHJGGDBJM? MIIFDNCLCLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x74C7DE0", Offset = "0x74C71E0", VA = "0x1874C7DE0", Slot = "9")]
	[AsyncStateMachine(typeof(LMEEEMAMPBG))]
	public Task KOMANGBMEJK([Optional] CancellationToken MLAPMBKLAOF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x74C8360", Offset = "0x74C7760", VA = "0x1874C8360", Slot = "10")]
	public IReadOnlyCollection<JBBPIGEHCDP> PLCFPFJAPNO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x74C7290", Offset = "0x74C6690", VA = "0x1874C7290")]
	internal void FDBNDHACPJD(JBBPIGEHCDP OCDOGNMJENC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x74C6EA0", Offset = "0x74C62A0", VA = "0x1874C6EA0")]
	private CJPEGDNDKKA BCDPCMPLNHP()
	{
		return default(CJPEGDNDKKA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x74C7410", Offset = "0x74C6810", VA = "0x1874C7410")]
	private CJPEGDNDKKA FHCEIPPIJDN()
	{
		return default(CJPEGDNDKKA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x74C7C10", Offset = "0x74C7010", VA = "0x1874C7C10")]
	internal void JDCGDEBKHGE(JBBPIGEHCDP OCDOGNMJENC, BABHJGGDBJM ECNFCPHCMAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x74C7110", Offset = "0x74C6510", VA = "0x1874C7110")]
	private static void DNCBIHDALCL(IReadOnlyList<TaskCompletionSource<DGCEFDKBMEI>> NFMPNNMCEKF, DGCEFDKBMEI DMEOEKICAHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x74C8110", Offset = "0x74C7510", VA = "0x1874C8110")]
	private void NHFJBACMLGJ(float EBKCCFJCOIL, Func<CJPEGDNDKKA> EPACGCLCKDD, DGCEFDKBMEI FLOJLDMJKMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x74C6D20", Offset = "0x74C6120", VA = "0x1874C6D20")]
	private static bool ANIKEDGIFMG(float FJLJDCJDABK, float DOGHGFGEHNK, float NCJJHJLGCPM = 0.0001f)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x74C7FD0", Offset = "0x74C73D0", VA = "0x1874C7FD0")]
	[AsyncStateMachine(typeof(HGNBPELECFH))]
	private Task MMNGBJFAMED(CancellationToken IMBEMDEIDGJ, float EBKCCFJCOIL, Func<CJPEGDNDKKA> EJGNBDLNJOE, DGCEFDKBMEI FLOJLDMJKMP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x74C7ED0", Offset = "0x74C72D0", VA = "0x1874C7ED0")]
	private void MAKJLBNNGMC(float NLHJBKNODJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x74C7AB0", Offset = "0x74C6EB0", VA = "0x1874C7AB0")]
	[AsyncStateMachine(typeof(HJNFFENJODK))]
	internal Task IOENAHLPOIP([Optional] CancellationToken MLAPMBKLAOF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x74C6DA0", Offset = "0x74C61A0", VA = "0x1874C6DA0")]
	[AsyncStateMachine(typeof(LGMOPAJEJNJ))]
	private static Task BAFMFMPFLPB(ICollection<TaskCompletionSource<DGCEFDKBMEI>> NFMPNNMCEKF, CancellationToken MLAPMBKLAOF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x74C7250", Offset = "0x74C6650", VA = "0x1874C7250", Slot = "12")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
internal class FAPDDDKBJDM : LJPNEKMEFMK, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[CompilerGenerated]
	private struct MMNBKGIHLEC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public FAPDDDKBJDM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x74C9CE0", Offset = "0x74C90E0", VA = "0x1874C9CE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x74C9F60", Offset = "0x74C9360", VA = "0x1874C9F60", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private static readonly string GMMDAGJLPGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	private readonly JKGLJHBPGHO GNPGAJCIGII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	private readonly KAPNCPHAHHF GGIBPNKFKHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	private readonly JBBPIGEHCDP OCDOGNMJENC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	private bool JBOKBJOADDP;

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x74C56E0", Offset = "0x74C4AE0", VA = "0x1874C56E0")]
	internal FAPDDDKBJDM(KAPNCPHAHHF GGIBPNKFKHI, JBBPIGEHCDP OCDOGNMJENC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x74C5570", Offset = "0x74C4970", VA = "0x1874C5570", Slot = "4")]
	[AsyncStateMachine(typeof(MMNBKGIHLEC))]
	public Task KGBJFMEHACI([Optional] CancellationToken MLAPMBKLAOF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x74C53C0", Offset = "0x74C47C0", VA = "0x1874C53C0", Slot = "5")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
internal readonly struct CJPEGDNDKKA : IEquatable<CJPEGDNDKKA>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	public readonly bool MBGMIJCJJIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	public readonly float AAPFEJGCHGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	public readonly float IMANJHDNBHP;

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x74C52F0", Offset = "0x74C46F0", VA = "0x1874C52F0")]
	public CJPEGDNDKKA(float JCAOJFDLJIB, float NGAJLIGHCDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x74C50E0", Offset = "0x74C44E0", VA = "0x1874C50E0", Slot = "4")]
	public bool Equals(CJPEGDNDKKA MNALNBMKJLK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x74C5120", Offset = "0x74C4520", VA = "0x1874C5120", Slot = "0")]
	public override bool Equals(object? NBAMGPFDMIB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x74C51D0", Offset = "0x74C45D0", VA = "0x1874C51D0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x74C5250", Offset = "0x74C4650", VA = "0x1874C5250", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
internal class LIJGHEMFIFK
{
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public enum KHILHKLFCHM : byte
	{
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		FastestFade,
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		SlowestFade
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private readonly KHILHKLFCHM PMEPJMAGMLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private readonly Dictionary<object, CJPEGDNDKKA> EIGIDHIALNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private readonly CJPEGDNDKKA KEKILBINNMM;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public CJPEGDNDKKA KAMPPLLIEDO
	{
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0xC14340", Offset = "0xC13740", VA = "0x180C14340")]
		[CompilerGenerated]
		get
		{
			return default(CJPEGDNDKKA);
		}
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0xC14480", Offset = "0xC13880", VA = "0x180C14480")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x74C96F0", Offset = "0x74C8AF0", VA = "0x1874C96F0")]
	public LIJGHEMFIFK(KHILHKLFCHM PMEPJMAGMLF, CJPEGDNDKKA KEKILBINNMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x74C9250", Offset = "0x74C8650", VA = "0x1874C9250")]
	public void AIKDGPOKJOG(object OCDOGNMJENC, CJPEGDNDKKA EFPNMFFAOHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x74C9680", Offset = "0x74C8A80", VA = "0x1874C9680")]
	public void PBIACPFCCPC(object OCDOGNMJENC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x74C93B0", Offset = "0x74C87B0", VA = "0x1874C93B0")]
	public void JIMFDDOIBMF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x74C9440", Offset = "0x74C8840", VA = "0x1874C9440")]
	private void OIBBPIAFKCK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x74C9400", Offset = "0x74C8800", VA = "0x1874C9400")]
	private CJPEGDNDKKA KFAMAOHOFJD()
	{
		return default(CJPEGDNDKKA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x74C9370", Offset = "0x74C8770", VA = "0x1874C9370")]
	private CJPEGDNDKKA CDLMPCGICGM()
	{
		return default(CJPEGDNDKKA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x74C94E0", Offset = "0x74C88E0", VA = "0x1874C94E0")]
	private CJPEGDNDKKA OKOABANIJGF(int BIILCHGBINI)
	{
		return default(CJPEGDNDKKA);
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
