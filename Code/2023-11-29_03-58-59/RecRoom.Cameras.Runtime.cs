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
		[Cpp2IlInjected.Address(RVA = "0x79B610", Offset = "0x79AA10", VA = "0x18079B610")]
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
		[Cpp2IlInjected.Address(RVA = "0x5D3F9E0", Offset = "0x5D3EDE0", VA = "0x185D3F9E0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x79C170", Offset = "0x79B570", VA = "0x18079C170")]
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
		[Cpp2IlInjected.Address(RVA = "0x79C1B0", Offset = "0x79B5B0", VA = "0x18079C1B0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
[GOIFFELMODE]
public class KGHNAEILJCB : AEGAFFOCNDM, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	internal enum APCKLCMKNCM
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
	private struct PGHEEKLCNHL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		public KGHNAEILJCB <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x5D405D0", Offset = "0x5D3F9D0", VA = "0x185D405D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x5D409D0", Offset = "0x5D3FDD0", VA = "0x185D409D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private sealed class PEFGPKECFPF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		public CancellationTokenSource cts;

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x778200", Offset = "0x777600", VA = "0x180778200")]
		public PEFGPKECFPF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x5D405A0", Offset = "0x5D3F9A0", VA = "0x185D405A0")]
		internal void IINCKAPNMCF(APCKLCMKNCM fadeState)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private struct DILJHMBFNJE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		public APCKLCMKNCM completedState;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		public KGHNAEILJCB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		public Func<GJMCHMCEONL> durationFetch;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		public float endOpacity;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private PEFGPKECFPF <>8__1;

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
		[Cpp2IlInjected.Address(RVA = "0x5D3C480", Offset = "0x5D3B880", VA = "0x185D3C480", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x5D3D1C0", Offset = "0x5D3C5C0", VA = "0x185D3D1C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CompilerGenerated]
	private struct ODAHCLDLPFB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public KGHNAEILJCB <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x5D3FA60", Offset = "0x5D3EE60", VA = "0x185D3FA60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x5D3FE70", Offset = "0x5D3F270", VA = "0x185D3FE70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private sealed class CKHHLEPLFGI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public TaskCompletionSource<APCKLCMKNCM> tcs;

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x778200", Offset = "0x777600", VA = "0x180778200")]
		public CKHHLEPLFGI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x5D3C430", Offset = "0x5D3B830", VA = "0x185D3C430")]
		internal void GHBELOHGEHM()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private struct PDCDBFPNDJK : IAsyncStateMachine
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
		public ICollection<TaskCompletionSource<APCKLCMKNCM>> tcsList;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		private CKHHLEPLFGI <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private IDisposable <registration>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private TaskAwaiter<APCKLCMKNCM> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x5D3FED0", Offset = "0x5D3F2D0", VA = "0x185D3FED0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x5D40540", Offset = "0x5D3F940", VA = "0x185D40540", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly LOJGJANFOID GAIKOINNEEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly NEDLPONFJLF MEBNJBGCGNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private readonly PJDIJGNCNFN JCHOEGIBNNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly NELOGBOAHAJ MFIEEMGDPHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly OPINAPCLPAM OBNKGKILPCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private readonly Func<Task> CBOMHAMHFDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly LNDBPJGBADL ELEMKFJCDFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private readonly LNDBPJGBADL HANKMOPDFCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private readonly CancellationTokenSource GBMJMIMJJMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private readonly CancellationToken DOBJDOEOGKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly HNKCHOLMMMA<JHKAELLEKMH> MICEMCHEFDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private readonly object IGCNBOIIKBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private readonly object HHIBAJLFIKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private readonly List<TaskCompletionSource<APCKLCMKNCM>> FHAKMGMJJCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private readonly List<TaskCompletionSource<APCKLCMKNCM>> HCBGNIGMOGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private APCKLCMKNCM CACJMFLCLAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9C")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	internal bool EODMNJPOGOL;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public bool BDCLOHCOLNN
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x5D3DBB0", Offset = "0x5D3CFB0", VA = "0x185D3DBB0", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public bool KKOFIJOHLLE
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x5D3D960", Offset = "0x5D3CD60", VA = "0x185D3D960", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool BFJHHOICIKN
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x5D3DEB0", Offset = "0x5D3D2B0", VA = "0x185D3DEB0", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public float GMIBLGPGILI
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0xB38F30", Offset = "0xB38330", VA = "0x180B38F30", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0xB38F10", Offset = "0xB38310", VA = "0x180B38F10")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	private APCKLCMKNCM MBDOKHDJNOG
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0xB98AB0", Offset = "0xB97EB0", VA = "0x180B98AB0")]
		get
		{
			return default(APCKLCMKNCM);
		}
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x5D3DEC0", Offset = "0x5D3D2C0", VA = "0x185D3DEC0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	private event Action<APCKLCMKNCM> GHAOECHBHEJ
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x5D3DAF0", Offset = "0x5D3CEF0", VA = "0x185D3DAF0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x5D3D810", Offset = "0x5D3CC10", VA = "0x185D3D810")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x5D3F430", Offset = "0x5D3E830", VA = "0x185D3F430")]
	[Preserve]
	public KGHNAEILJCB([MJHHGJKKIMK(null)] LOJGJANFOID GAIKOINNEEJ, [MJHHGJKKIMK(null)] NEDLPONFJLF MEBNJBGCGNF, [MJHHGJKKIMK(null)] PJDIJGNCNFN JCHOEGIBNNI, [MJHHGJKKIMK("CameraFadeTimeoutDetector")] NELOGBOAHAJ MFIEEMGDPHK, [MJHHGJKKIMK(null)] OPINAPCLPAM OBNKGKILPCB, [MJHHGJKKIMK(null)] NHELDJDFIBJ<CameraFadeOptions> AHMINIDFCHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x5D3ED80", Offset = "0x5D3E180", VA = "0x185D3ED80")]
	internal KGHNAEILJCB(LOJGJANFOID GAIKOINNEEJ, NEDLPONFJLF MEBNJBGCGNF, PJDIJGNCNFN JCHOEGIBNNI, NELOGBOAHAJ MFIEEMGDPHK, OPINAPCLPAM OBNKGKILPCB, NHELDJDFIBJ<CameraFadeOptions> AHMINIDFCHC, Func<Task>? CBOMHAMHFDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x5D3E2E0", Offset = "0x5D3D6E0", VA = "0x185D3E2E0", Slot = "8")]
	public IFGOOECJGBC MBEBDHACJDI(JHKAELLEKMH NOEAHPPKHNC, [Optional] BAFKLHOCDLH? MIHHBFBPDCI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x5D3DDC0", Offset = "0x5D3D1C0", VA = "0x185D3DDC0", Slot = "9")]
	[AsyncStateMachine(typeof(PGHEEKLCNHL))]
	public Task ILPHFKFMPDE([Optional] CancellationToken EANFAKGANNH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x5D3D8D0", Offset = "0x5D3CCD0", VA = "0x185D3D8D0", Slot = "10")]
	public IReadOnlyCollection<JHKAELLEKMH> DJHPCPPNHPF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x5D3EAC0", Offset = "0x5D3DEC0", VA = "0x185D3EAC0")]
	internal void OLLEFGNCLKL(JHKAELLEKMH NOEAHPPKHNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x5D3D7E0", Offset = "0x5D3CBE0", VA = "0x185D3D7E0")]
	private GJMCHMCEONL BBLMNPFMCHJ()
	{
		return default(GJMCHMCEONL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x5D3EC40", Offset = "0x5D3E040", VA = "0x185D3EC40")]
	private GJMCHMCEONL PCFPKDCFJFF()
	{
		return default(GJMCHMCEONL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x5D3E130", Offset = "0x5D3D530", VA = "0x185D3E130")]
	internal void KOCFKDOAAJN(JHKAELLEKMH NOEAHPPKHNC, BAFKLHOCDLH PAPFFAEPPBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x5D3DFF0", Offset = "0x5D3D3F0", VA = "0x185D3DFF0")]
	private static void JPLHJAFPCPK(IReadOnlyList<TaskCompletionSource<APCKLCMKNCM>> BNKMJOKMJPA, APCKLCMKNCM GPFEJOJBBAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x5D3D970", Offset = "0x5D3CD70", VA = "0x185D3D970")]
	private void EFLHAGEPJNO(float JHJDIBAGPJO, Func<GJMCHMCEONL> MPNDENNIANN, APCKLCMKNCM AMFGNKHNCOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x5D3E900", Offset = "0x5D3DD00", VA = "0x185D3E900")]
	private static bool MCHEGFCELPJ(float JMHOJIPAIMC, float MLKGDIFPGGI, float CMCCJIPFMGD = 0.0001f)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x5D3E980", Offset = "0x5D3DD80", VA = "0x185D3E980")]
	[AsyncStateMachine(typeof(DILJHMBFNJE))]
	private Task OILGAENFCAA(CancellationToken DIGBFHNOFEL, float JHJDIBAGPJO, Func<GJMCHMCEONL> HDBFIJMCLLC, APCKLCMKNCM AMFGNKHNCOA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x5D3EC70", Offset = "0x5D3E070", VA = "0x185D3EC70")]
	private void PDCGPMPAEEB(float ONGMDNCBBMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x5D3DBD0", Offset = "0x5D3CFD0", VA = "0x185D3DBD0")]
	[AsyncStateMachine(typeof(ODAHCLDLPFB))]
	internal Task FALHNIKOAKO([Optional] CancellationToken EANFAKGANNH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x5D3DCC0", Offset = "0x5D3D0C0", VA = "0x185D3DCC0")]
	[AsyncStateMachine(typeof(PDCDBFPNDJK))]
	private static Task GJKIHOHFAPF(ICollection<TaskCompletionSource<APCKLCMKNCM>> BNKMJOKMJPA, CancellationToken EANFAKGANNH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x5D3D920", Offset = "0x5D3CD20", VA = "0x185D3D920", Slot = "11")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
internal class POMKHNIOBMD : IFGOOECJGBC, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	private struct ECBFFJNEHKL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public POMKHNIOBMD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x5D3D220", Offset = "0x5D3C620", VA = "0x185D3D220", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x5D3D4A0", Offset = "0x5D3C8A0", VA = "0x185D3D4A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	private readonly EOJHLDCAFED HBOLJCGABGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	private readonly KGHNAEILJCB FEECEFMJACG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	private readonly JHKAELLEKMH NOEAHPPKHNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private bool CIECAMCCGCB;

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x5D40CD0", Offset = "0x5D400D0", VA = "0x185D40CD0")]
	internal POMKHNIOBMD(KGHNAEILJCB FEECEFMJACG, JHKAELLEKMH NOEAHPPKHNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x5D40BE0", Offset = "0x5D3FFE0", VA = "0x185D40BE0", Slot = "4")]
	[AsyncStateMachine(typeof(ECBFFJNEHKL))]
	public Task JKJPEFDDEFC([Optional] CancellationToken EANFAKGANNH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x5D40A30", Offset = "0x5D3FE30", VA = "0x185D40A30", Slot = "5")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
internal readonly struct GJMCHMCEONL : IEquatable<GJMCHMCEONL>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public readonly bool HCMNBCLGHBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	public readonly float DGPCOONALHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	public readonly float GCJFODAJKLB;

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x5D3D710", Offset = "0x5D3CB10", VA = "0x185D3D710")]
	public GJMCHMCEONL(float AFEPFOOMLOB, float EMNJLCFBMME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x5D3D5B0", Offset = "0x5D3C9B0", VA = "0x185D3D5B0", Slot = "4")]
	public bool Equals(GJMCHMCEONL LFMLAKDHEFO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x5D3D500", Offset = "0x5D3C900", VA = "0x185D3D500", Slot = "0")]
	public override bool Equals(object? ECLCDMJMICA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x5D3D5F0", Offset = "0x5D3C9F0", VA = "0x185D3D5F0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x5D3D670", Offset = "0x5D3CA70", VA = "0x185D3D670", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
internal class LNDBPJGBADL
{
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public enum IAODPCCJJBO : byte
	{
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		FastestFade,
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		SlowestFade
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	private readonly IAODPCCJJBO GFOPHEIJGEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	private readonly Dictionary<object, GJMCHMCEONL> IMKDJPGCFHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	private readonly GJMCHMCEONL OEIGDDBGEII;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public GJMCHMCEONL ILNPCEAPFCH
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x8D2490", Offset = "0x8D1890", VA = "0x1808D2490")]
		[CompilerGenerated]
		get
		{
			return default(GJMCHMCEONL);
		}
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x8D2130", Offset = "0x8D1530", VA = "0x1808D2130")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x5D3F920", Offset = "0x5D3ED20", VA = "0x185D3F920")]
	public LNDBPJGBADL(IAODPCCJJBO GFOPHEIJGEE, GJMCHMCEONL OEIGDDBGEII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x5D3F590", Offset = "0x5D3E990", VA = "0x185D3F590")]
	public void ILNFIDMGJDH(object NOEAHPPKHNC, GJMCHMCEONL COOMFNJJEDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x5D3F520", Offset = "0x5D3E920", VA = "0x185D3F520")]
	public void HBMDGHADMGB(object NOEAHPPKHNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x5D3F6B0", Offset = "0x5D3EAB0", VA = "0x185D3F6B0")]
	public void ILNOFIHDCKG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x5D3F480", Offset = "0x5D3E880", VA = "0x185D3F480")]
	private void AJECFMNBMND()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x5D3F700", Offset = "0x5D3EB00", VA = "0x185D3F700")]
	private GJMCHMCEONL JBKNDKJFMLP()
	{
		return default(GJMCHMCEONL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x5D3F740", Offset = "0x5D3EB40", VA = "0x185D3F740")]
	private GJMCHMCEONL LLEGAHGCNEP()
	{
		return default(GJMCHMCEONL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x5D3F780", Offset = "0x5D3EB80", VA = "0x185D3F780")]
	private GJMCHMCEONL MLHOGHNPGLO(int IOENJEHNMNE)
	{
		return default(GJMCHMCEONL);
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
