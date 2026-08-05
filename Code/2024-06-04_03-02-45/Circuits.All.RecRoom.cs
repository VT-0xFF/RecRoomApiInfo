using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Circuits.Shared.Api;
using Circuits.Static.Api;
using Cpp2IlInjected;
using Google.Protobuf;
using Microsoft.CodeAnalysis;

[assembly: AssemblyVersion("0.0.0.0")]
namespace Microsoft.CodeAnalysis
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class EmbeddedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x86CBD0", Offset = "0x86B3D0", VA = "0x18086CBD0")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter, AllowMultiple = false, Inherited = false)]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x1F00110", Offset = "0x1EFE910", VA = "0x181F00110")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x86D840", Offset = "0x86C040", VA = "0x18086D840")]
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
		[Cpp2IlInjected.Address(RVA = "0x86D880", Offset = "0x86C080", VA = "0x18086D880")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public sealed class BBIGJEMLFFM : IDisposable, EBICKCBJNLF, EILMJMGNMPA, IIGBDKMGMPF, APIEPECKJBO
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public abstract class GEJDEKIEMDA : NOGDCDBFNDC
	{
		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public abstract int PKPCPGDIOHE
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(Slot = "10")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x1EEF080", Offset = "0x1EED880", VA = "0x181EEF080", Slot = "5")]
		public DJDKLOIJFMF LIJDHCLCOIP(IBJGOCHMKAI.OHHNNMMCNCA DNJOEPEBEMJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(Slot = "11")]
		public abstract void LACCLMDJJGG();

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(Slot = "12")]
		public abstract void OMLKIGFDEJJ();

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x1EEF040", Offset = "0x1EED840", VA = "0x181EEF040", Slot = "13")]
		public virtual void DBEEDOCHEMG(BBIGJEMLFFM POJGEMMMHAN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x1EEF1D0", Offset = "0x1EED9D0", VA = "0x181EEF1D0", Slot = "14")]
		public virtual void LKDDOFFKCML(BBIGJEMLFFM POJGEMMMHAN, FFPCMKOBEGP BMOCGPMNBAF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
		protected GEJDEKIEMDA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public interface NOGDCDBFNDC
	{
		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		int PKPCPGDIOHE
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(Slot = "1")]
		DJDKLOIJFMF LIJDHCLCOIP(IBJGOCHMKAI.OHHNNMMCNCA DNJOEPEBEMJ);

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void LACCLMDJJGG();

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void OMLKIGFDEJJ();

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void DBEEDOCHEMG(BBIGJEMLFFM POJGEMMMHAN);

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void LKDDOFFKCML(BBIGJEMLFFM POJGEMMMHAN, FFPCMKOBEGP BMOCGPMNBAF);
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	private readonly struct FECANBFABLL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public readonly HLOBOENKPAF<CCBMGFEGKNJ, FFPCMKOBEGP, BBIGJEMLFFM, OPEEJNJBEAD.OHFECBHGEAO<CCBMGFEGKNJ, FFPCMKOBEGP, BBIGJEMLFFM>> DNPOJKCODIO;

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x1EEBEE0", Offset = "0x1EEA6E0", VA = "0x181EEBEE0")]
		internal FECANBFABLL(HLOBOENKPAF<CCBMGFEGKNJ, FFPCMKOBEGP, BBIGJEMLFFM, OPEEJNJBEAD.OHFECBHGEAO<CCBMGFEGKNJ, FFPCMKOBEGP, BBIGJEMLFFM>> LHMMDMHNIJC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public sealed class ILOADHBCCCI : OPEEJNJBEAD.OHFECBHGEAO<CCBMGFEGKNJ, FFPCMKOBEGP, BBIGJEMLFFM>
	{
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public static readonly ILOADHBCCCI DCEJKJKKEPJ;

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
		private ILOADHBCCCI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0xB73520", Offset = "0xB71D20", VA = "0x180B73520", Slot = "4")]
		public CCBMGFEGKNJ COFDKCFNEPN(FFPCMKOBEGP EGJINJKGIAK)
		{
			return default(CCBMGFEGKNJ);
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x1EF1780", Offset = "0x1EEFF80", VA = "0x181EF1780", Slot = "5")]
		public void DBEEDOCHEMG(BBIGJEMLFFM AHKBBGKKCNK, FFPCMKOBEGP BMOCGPMNBAF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x1EF1890", Offset = "0x1EF0090", VA = "0x181EF1890", Slot = "6")]
		public void LKDDOFFKCML(BBIGJEMLFFM AHKBBGKKCNK, FFPCMKOBEGP BMOCGPMNBAF)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000A")]
	private struct IOCKANAKJDC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public IMNPCNCFILD<CCBMGFEGKNJ, FFPCMKOBEGP, BBIGJEMLFFM, OPEEJNJBEAD.OHFECBHGEAO<CCBMGFEGKNJ, FFPCMKOBEGP, BBIGJEMLFFM>> DNPOJKCODIO;

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x1EF1A60", Offset = "0x1EF0260", VA = "0x181EF1A60")]
		internal IOCKANAKJDC(IMNPCNCFILD<CCBMGFEGKNJ, FFPCMKOBEGP, BBIGJEMLFFM, OPEEJNJBEAD.OHFECBHGEAO<CCBMGFEGKNJ, FFPCMKOBEGP, BBIGJEMLFFM>> LHMMDMHNIJC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x1EF1A10", Offset = "0x1EF0210", VA = "0x181EF1A10")]
		public static IOCKANAKJDC OJFFIHPLODM()
		{
			return default(IOCKANAKJDC);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public readonly struct NJGBGKDLFFP : CHGIKMOFLHD.EMGGKBOKKPF<FFPCMKOBEGP, BBIGJEMLFFM>
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200000C")]
		[CompilerGenerated]
		private struct OFHHLCKEPGG : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			public AsyncTaskMethodBuilder<MEKCEIEFNPI<object, MNGIPKBLGNG>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public BBIGJEMLFFM receiver;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			public FFPCMKOBEGP action;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			public NJGBGKDLFFP <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			private TaskAwaiter<MEKCEIEFNPI<object, MNGIPKBLGNG>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x1F03160", Offset = "0x1F01960", VA = "0x181F03160", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x1F03340", Offset = "0x1F01B40", VA = "0x181F03340", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x8CA720", Offset = "0x8C8F20", VA = "0x1808CA720", Slot = "4")]
		public KPFGDODNFBO<DFFIIDMIKOJ> KBGADOGIAAN(BBIGJEMLFFM GALEHIKOJBA)
		{
			return default(KPFGDODNFBO<DFFIIDMIKOJ>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x1EFFE00", Offset = "0x1EFE600", VA = "0x181EFFE00", Slot = "5")]
		[AsyncStateMachine(typeof(OFHHLCKEPGG))]
		public Task<MEKCEIEFNPI<object, MNGIPKBLGNG>> JHLMFAEHBED(BBIGJEMLFFM GALEHIKOJBA, FFPCMKOBEGP BMOCGPMNBAF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x1EFFDE0", Offset = "0x1EFE5E0", VA = "0x181EFFDE0", Slot = "6")]
		public FFPCMKOBEGP[] EODGDKJCOJD(BBIGJEMLFFM GALEHIKOJBA)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private struct NHPGLPKCOBA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public AsyncTaskMethodBuilder<MEKCEIEFNPI<bool, MNGIPKBLGNG>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public BBIGJEMLFFM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public DNCJDBJPHOD rootData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		public EALEPKELLAJ circuitRootData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public GMFGEGDFAPN superRoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private TaskAwaiter<MEKCEIEFNPI<bool, MNGIPKBLGNG>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x1EFFAF0", Offset = "0x1EFE2F0", VA = "0x181EFFAF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x1EFFD70", Offset = "0x1EFE570", VA = "0x181EFFD70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private struct EBOEJCOCNFC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public AsyncTaskMethodBuilder<MEKCEIEFNPI<bool, MNGIPKBLGNG>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public BBIGJEMLFFM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private TaskAwaiter<MEKCEIEFNPI<bool, MNGIPKBLGNG>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x1EEB160", Offset = "0x1EE9960", VA = "0x181EEB160", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x1EEB3F0", Offset = "0x1EE9BF0", VA = "0x181EEB3F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[CompilerGenerated]
	private struct PAGBLLOAJEA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		public AsyncTaskMethodBuilder<MEKCEIEFNPI<KNDENJDHONE, MNGIPKBLGNG>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		public BBIGJEMLFFM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private TaskAwaiter<MEKCEIEFNPI<KNDENJDHONE, MNGIPKBLGNG>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x1F03DE0", Offset = "0x1F025E0", VA = "0x181F03DE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x1F03FC0", Offset = "0x1F027C0", VA = "0x181F03FC0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	private struct FGEGEHFPAHO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		public AsyncTaskMethodBuilder<MEKCEIEFNPI<object, MNGIPKBLGNG>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		public BBIGJEMLFFM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public FFPCMKOBEGP action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private TaskAwaiter<MEKCEIEFNPI<object, MNGIPKBLGNG>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x1EEBEF0", Offset = "0x1EEA6F0", VA = "0x181EEBEF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x1EEC0E0", Offset = "0x1EEA8E0", VA = "0x181EEC0E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[CompilerGenerated]
	private struct FODEPEFPNEN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public AsyncTaskMethodBuilder<MEKCEIEFNPI<KNDENJDHONE, MNGIPKBLGNG>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public BBIGJEMLFFM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public Guid rootGraphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private TaskAwaiter<MEKCEIEFNPI<KNDENJDHONE, MNGIPKBLGNG>> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private TaskAwaiter<MEKCEIEFNPI<bool, MNGIPKBLGNG>> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x1EEE130", Offset = "0x1EEC930", VA = "0x181EEE130", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x1EEE920", Offset = "0x1EED120", VA = "0x181EEE920", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private readonly KPFGDODNFBO<DFFIIDMIKOJ> NJGDGMILODF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly FECANBFABLL CMANBFKIPIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly AENIBMFNBOO GGKGAABIMJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	internal readonly HDGKGFEBFPM EFMJDLJFMNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1308")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	internal readonly OGMIBBIPCFM PHHAFNCOPLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1310")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	internal readonly LODDICAHKEA.FFPALKBFMMF OKPOJJAEEKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1330")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	internal readonly DHKGAJEJCNB BGPLMDIGKPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1338")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	internal readonly IKNGINBJAEC JLGEIGFJKFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1340")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	internal readonly BFBLMJJGBME DHMPJEFGBNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1348")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	internal readonly FBKLOJGFHAJ NCBIAJCLABF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1350")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	internal readonly OKJJDEGPPDI JJPCBFLLPFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1358")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private DIDEKHLIKHD CMPEEKPDPNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1368")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private MCBMHOCLAPA IAHNEPKNGMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1388")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	internal readonly AENIBMFNBOO.HDIJGFHGDLD BLNGNAGGPHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1390")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	internal readonly FFNDJCFBCCI AOFOEDKJFGN;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public AENIBMFNBOO NJNLHHOPBKC
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x1EE9280", Offset = "0x1EE7A80", VA = "0x181EE9280")]
		get
		{
			return default(AENIBMFNBOO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	internal NOGDCDBFNDC OIHGLBHDCJK
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x1EE7D10", Offset = "0x1EE6510", VA = "0x181EE7D10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	internal DJDKLOIJFMF DKBAGFOMCJC
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x1EE8960", Offset = "0x1EE7160", VA = "0x181EE8960")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x1EE7CF0", Offset = "0x1EE64F0", VA = "0x181EE7CF0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	internal bool HLCECCKHFAA
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x1EE9270", Offset = "0x1EE7A70", VA = "0x181EE9270")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x1EE9260", Offset = "0x1EE7A60", VA = "0x181EE9260")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public OELKAHKLBKD JKMILGBOKLB
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x1EE95D0", Offset = "0x1EE7DD0", VA = "0x181EE95D0", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public MDDOCMAIDGE IKDIFFMBDNN
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x1EE95F0", Offset = "0x1EE7DF0", VA = "0x181EE95F0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public KJJENPKNFKF NEIPMAFCNHC
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x1EE9610", Offset = "0x1EE7E10", VA = "0x181EE9610", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public HAFPKFPPNPD KLLCLBIIEGD
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x1EE95E0", Offset = "0x1EE7DE0", VA = "0x181EE95E0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public JKDBEAGJKPD DCNIDMLKPPL
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x1EE9600", Offset = "0x1EE7E00", VA = "0x181EE9600", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	private CHJFBOCODMI? MENLMDOJMJD
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x1EE8970", Offset = "0x1EE7170", VA = "0x181EE8970", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	private BEMDKNAJANC? MCOACLDGFGM
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x1EE7D60", Offset = "0x1EE6560", VA = "0x181EE7D60", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x1EE9290", Offset = "0x1EE7A90", VA = "0x181EE9290")]
	private BBIGJEMLFFM(OGMIBBIPCFM FEIKIKEAPDP, KPFGDODNFBO<DFFIIDMIKOJ> HKJHDCJABMO, [In] FECANBFABLL IAKDNPALLEC, [In] AENIBMFNBOO PPMHPNOFLGJ, [In] HDGKGFEBFPM AHIFCFJCGEP, DJDKLOIJFMF MFEBACJMNKE, [In] LODDICAHKEA.FFPALKBFMMF JAGMKPEFDFH, AENIBMFNBOO.HDIJGFHGDLD DFAKDKIJLPN, FFNDJCFBCCI NAHKKOAPIFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x1EE8E00", Offset = "0x1EE7600", VA = "0x181EE8E00")]
	public static BBIGJEMLFFM OJFFIHPLODM(OGMIBBIPCFM DNJOEPEBEMJ, [In] KKFDFEGBEFJ GHBLJFBENFL, CKFIDAJDLPF LLPCAEHEIHL, [In] CPLABPGDENM JCEJKADGJNA, ECOFPDNGLIN HPGLJGLKHIL, KPFGDODNFBO<DFFIIDMIKOJ> HKJHDCJABMO, KPFGDODNFBO<INGMPPLKKGN> PHLOBBLOPDO, PFHKOKHNBAM CCFDAEFHGMO, JODGPHLINKF DKNOJOFEHGC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x1EE8B20", Offset = "0x1EE7320", VA = "0x181EE8B20")]
	public static BBIGJEMLFFM OJFFIHPLODM(OGMIBBIPCFM FEIKIKEAPDP, [In] AENIBMFNBOO PPMHPNOFLGJ, [In] HDGKGFEBFPM AHIFCFJCGEP, KPFGDODNFBO<DFFIIDMIKOJ> HKJHDCJABMO, KPFGDODNFBO<INGMPPLKKGN> PHLOBBLOPDO, PFHKOKHNBAM CCFDAEFHGMO, JODGPHLINKF DKNOJOFEHGC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x1EE7E90", Offset = "0x1EE6690", VA = "0x181EE7E90", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x1EE8710", Offset = "0x1EE6F10", VA = "0x181EE8710")]
	[AsyncStateMachine(typeof(NHPGLPKCOBA))]
	internal Task<MEKCEIEFNPI<bool, MNGIPKBLGNG>> HPDCEHDMKGI(DNCJDBJPHOD JDMOMCFHMKL, EALEPKELLAJ JJIHFFIJJCL, GMFGEGDFAPN KIPPBODDGFF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x1EE8080", Offset = "0x1EE6880", VA = "0x181EE8080")]
	[AsyncStateMachine(typeof(EBOEJCOCNFC))]
	public Task<MEKCEIEFNPI<bool, MNGIPKBLGNG>> EMAHLAMMBLB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x1EE8500", Offset = "0x1EE6D00", VA = "0x181EE8500")]
	[AsyncStateMachine(typeof(PAGBLLOAJEA))]
	public Task<MEKCEIEFNPI<KNDENJDHONE, MNGIPKBLGNG>> FLGDAMDGJBO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x1EE9050", Offset = "0x1EE7850", VA = "0x181EE9050")]
	internal void OPAFBIONGCK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x1EE88E0", Offset = "0x1EE70E0", VA = "0x181EE88E0")]
	internal JPEFLPACLHE<FFPCMKOBEGP> JBOKKLDGOPA([In] DODMAHJEIFG AJNOHHCAHBL)
	{
		return default(JPEFLPACLHE<FFPCMKOBEGP>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x1EE8870", Offset = "0x1EE7070", VA = "0x181EE8870")]
	internal bool IJCBMBPIOLP([In] DODMAHJEIFG AJNOHHCAHBL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x1EE8AA0", Offset = "0x1EE72A0", VA = "0x181EE8AA0")]
	internal JPEFLPACLHE<FFPCMKOBEGP> NOJBPKBDNBF([In] OFCGFGNGDLN NAJJNFGLGMK)
	{
		return default(JPEFLPACLHE<FFPCMKOBEGP>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x1EE8F40", Offset = "0x1EE7740", VA = "0x181EE8F40")]
	[AsyncStateMachine(typeof(FGEGEHFPAHO))]
	internal Task<MEKCEIEFNPI<object, MNGIPKBLGNG>> OMJFCELAODC(FFPCMKOBEGP BMOCGPMNBAF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x1EE8170", Offset = "0x1EE6970", VA = "0x181EE8170")]
	private FFPCMKOBEGP[] EODGDKJCOJD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x1EE85F0", Offset = "0x1EE6DF0", VA = "0x181EE85F0")]
	[AsyncStateMachine(typeof(FODEPEFPNEN))]
	public Task<MEKCEIEFNPI<KNDENJDHONE, MNGIPKBLGNG>> HMBKIGAGJGP(Guid BMOLLLCBODE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public static class PFHLDNGONKP
{
	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x2C4AEE0", Offset = "0x2C496E0", VA = "0x182C4AEE0")]
	public static CPELCGOJBOJ<(TPrev?, BBIGJEMLFFM?), BEMDKNAJANC> BFALLNJDFDH<TPrev>([In] this CPELCGOJBOJ<TPrev, BBIGJEMLFFM> EGJINJKGIAK)
	{
		return default(CPELCGOJBOJ<(TPrev, BBIGJEMLFFM), BEMDKNAJANC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x2C4B1A0", Offset = "0x2C499A0", VA = "0x182C4B1A0")]
	public static CPELCGOJBOJ<TPrev?, BBIGJEMLFFM?> OFIICEFPFKK<TPrev>([In] this CPELCGOJBOJ<TPrev, BBIGJEMLFFM> EGJINJKGIAK)
	{
		return default(CPELCGOJBOJ<TPrev, BBIGJEMLFFM>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public sealed class OBAMEMOFJMK<TData> : PLHOCJDFICM, ABFPKHFPAFK, DCIBOGBGGHI where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private readonly EOFGJNJAJLP<GHBFIOLFDBB>? LFGGPEJPHAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public readonly string PJHOPJJKDPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public readonly TData IGFBHOELDIM;

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public EOFGJNJAJLP<GHBFIOLFDBB>? DLELFIFNANN
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x210F210", Offset = "0x210DA10", VA = "0x18210F210", Slot = "13")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x8472C0", Offset = "0x845AC0", VA = "0x1808472C0", Slot = "7")]
	public override string ILHCPMBLOJC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x453D9A0", Offset = "0x453C1A0", VA = "0x18453D9A0")]
	internal OBAMEMOFJMK([In] EOFGJNJAJLP<GHBFIOLFDBB>? LPLEGACCMMJ, KPFGDODNFBO<KLPCKDHOMDF>? BOEHLIJBIMO, IOKind? APCAAAJJFKJ, string CLBGCJICGJG, [In] TData MLKNGAFFKGE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public static class GMDNDNOJLBM
{
	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x1EF02D0", Offset = "0x1EEEAD0", VA = "0x181EF02D0")]
	public static MEKCEIEFNPI<KNGLCMLCKEI, ABFPKHFPAFK> NEAFOEPICPB([In] this GNFEGCDDGII<OIAIIEEKGLB> IOEKJHODADJ)
	{
		return default(MEKCEIEFNPI<KNGLCMLCKEI, ABFPKHFPAFK>);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x2A9B1B0", Offset = "0x2A999B0", VA = "0x182A9B1B0")]
	public static MEKCEIEFNPI<TOk, ABFPKHFPAFK> FDHDCGJJNGK<TOk>([In] this MEKCEIEFNPI<TOk, ABFPKHFPAFK> EGJINJKGIAK, [In] EOFGJNJAJLP<GHBFIOLFDBB>? LPLEGACCMMJ, KPFGDODNFBO<KLPCKDHOMDF>? BOEHLIJBIMO, IOKind? APCAAAJJFKJ, string CLBGCJICGJG) where TOk : notnull
	{
		return default(MEKCEIEFNPI<TOk, ABFPKHFPAFK>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public interface OGMIBBIPCFM
{
	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	OIFCMCHIANM.HDGPGICGCFD KFMECLOIHAO
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	IBJGOCHMKAI.OHHNNMMCNCA HBMLOIGEJJB
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	BBIGJEMLFFM.NOGDCDBFNDC IHOPNGKMFPD
	{
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	LDNILKFEDEA.KEECOHCBNJH FGIDILIELAP
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	OPEEJNJBEAD.OHFECBHGEAO<CCBMGFEGKNJ, FFPCMKOBEGP, BBIGJEMLFFM> IPJPFPGIAMB
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	FKNKBHHKDOE IPPKMAKKFBL
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	NKOOGGOBMFP BAIDJOBCIIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	GEMBKHHAPFB FNGKDEFCFOP
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	IBLIAIPNJAC JOALCJBIKOB
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	MDKCAMDLDFJ OIPNHIBICBM
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public static class NMLPKFPHCFO
{
	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x1F00000", Offset = "0x1EFE800", VA = "0x181F00000")]
	public static FFPCMKOBEGP PBCONDPIGEC(this FFPCMKOBEGP EGJINJKGIAK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x1EFFF30", Offset = "0x1EFE730", VA = "0x181EFFF30")]
	public static FFPCMKOBEGP BGKGDADAMOD(this BGMMKDFHELO EGJINJKGIAK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public readonly struct BGMMKDFHELO
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[CompilerGenerated]
	private struct BDCNFOIIBHL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public AsyncTaskMethodBuilder<MEKCEIEFNPI<object, MNGIPKBLGNG>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public BBIGJEMLFFM root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		public BGMMKDFHELO self;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private TaskAwaiter<MEKCEIEFNPI<object, MNGIPKBLGNG>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x1EE9620", Offset = "0x1EE7E20", VA = "0x181EE9620", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x1EE98E0", Offset = "0x1EE80E0", VA = "0x181EE98E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public readonly ByteString JDDKPJKLOJP;

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x8EB4C0", Offset = "0x8E9CC0", VA = "0x1808EB4C0")]
	private BGMMKDFHELO(ByteString IPHHABIKCHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x1EE9950", Offset = "0x1EE8150", VA = "0x181EE9950")]
	public static FFPCMKOBEGP ANAAKPPODNK(ByteString IPHHABIKCHD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x1EE9A10", Offset = "0x1EE8210", VA = "0x181EE9A10")]
	public static KAPLCJNFCJL<CCBMGFEGKNJ, BGMMKDFHELO> LGDGMAPANEP(FFPCMKOBEGP GBNFLMDHJDA)
	{
		return default(KAPLCJNFCJL<CCBMGFEGKNJ, BGMMKDFHELO>);
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x1EE9AC0", Offset = "0x1EE82C0", VA = "0x181EE9AC0")]
	[AsyncStateMachine(typeof(BDCNFOIIBHL))]
	public static Task<MEKCEIEFNPI<object, MNGIPKBLGNG>> OMJFCELAODC(BBIGJEMLFFM AHKBBGKKCNK, BGMMKDFHELO EGJINJKGIAK)
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000019")]
public readonly struct OCMNAAGGMCD
{
	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x1F02BC0", Offset = "0x1F013C0", VA = "0x181F02BC0")]
	public static FFPCMKOBEGP ANAAKPPODNK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x1F02CE0", Offset = "0x1F014E0", VA = "0x181F02CE0")]
	public static KAPLCJNFCJL<CCBMGFEGKNJ, OCMNAAGGMCD> LGDGMAPANEP(FFPCMKOBEGP GBNFLMDHJDA)
	{
		return default(KAPLCJNFCJL<CCBMGFEGKNJ, OCMNAAGGMCD>);
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x1F02C60", Offset = "0x1F01460", VA = "0x181F02C60")]
	public static MEKCEIEFNPI<KNDENJDHONE, FDKFIPGCOGB> HBHJMBFCIJJ(BBIGJEMLFFM AHKBBGKKCNK, [In] OCMNAAGGMCD EGJINJKGIAK)
	{
		return default(MEKCEIEFNPI<KNDENJDHONE, FDKFIPGCOGB>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public readonly struct HPAPJMBLAIH
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[CompilerGenerated]
	private struct FCGELCNHMIL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public AsyncTaskMethodBuilder<MEKCEIEFNPI<KNDENJDHONE, FDKFIPGCOGB>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public BBIGJEMLFFM root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public HPAPJMBLAIH self;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private MEKCEIEFNPI<KNDENJDHONE, FDKFIPGCOGB> <r>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x1EEB970", Offset = "0x1EEA170", VA = "0x181EEB970", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x1EEBCE0", Offset = "0x1EEA4E0", VA = "0x181EEBCE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public readonly DNCJDBJPHOD? PJMKHGGJGIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public readonly EALEPKELLAJ? HBNPFOJKKAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public readonly GMFGEGDFAPN? DILHIBHHAMN;

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x1E23030", Offset = "0x1E21830", VA = "0x181E23030")]
	private HPAPJMBLAIH(DNCJDBJPHOD? JDMOMCFHMKL, EALEPKELLAJ? JJIHFFIJJCL, GMFGEGDFAPN? KIPPBODDGFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x1EF0990", Offset = "0x1EEF190", VA = "0x181EF0990")]
	public static FFPCMKOBEGP? ANAAKPPODNK(DNCJDBJPHOD? JDMOMCFHMKL, EALEPKELLAJ? JJIHFFIJJCL, GMFGEGDFAPN? KIPPBODDGFF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x1EF0A90", Offset = "0x1EEF290", VA = "0x181EF0A90")]
	public static KAPLCJNFCJL<CCBMGFEGKNJ, HPAPJMBLAIH> LGDGMAPANEP(FFPCMKOBEGP GBNFLMDHJDA)
	{
		return default(KAPLCJNFCJL<CCBMGFEGKNJ, HPAPJMBLAIH>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x1EF0BA0", Offset = "0x1EEF3A0", VA = "0x181EF0BA0")]
	[AsyncStateMachine(typeof(FCGELCNHMIL))]
	public static Task<MEKCEIEFNPI<KNDENJDHONE, FDKFIPGCOGB>> OMJFCELAODC(BBIGJEMLFFM AHKBBGKKCNK, HPAPJMBLAIH EGJINJKGIAK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public readonly struct BKFKBNNBNIF
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	[CompilerGenerated]
	private struct KLJKHEBBBOP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public AsyncTaskMethodBuilder<MEKCEIEFNPI<NHDCCNGJOAJ, MNGIPKBLGNG>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public BKFKBNNBNIF self;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public BBIGJEMLFFM root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		private MEKCEIEFNPI<NHDCCNGJOAJ, MNGIPKBLGNG> <r1>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		private MEKCEIEFNPI<object, DCIBOGBGGHI>[] <aggregateResult>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		private int <i>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		private MEKCEIEFNPI<object, DCIBOGBGGHI> <r2>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		private MEKCEIEFNPI<object, DCIBOGBGGHI>[] <>7__wrap5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		private int <>7__wrap6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		private TaskAwaiter<MEKCEIEFNPI<object, MNGIPKBLGNG>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x1EF4260", Offset = "0x1EF2A60", VA = "0x181EF4260", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x1EF46D0", Offset = "0x1EF2ED0", VA = "0x181EF46D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	public readonly IReadOnlyList<FFPCMKOBEGP> GCOMCMPDCAB;

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x8EB4C0", Offset = "0x8E9CC0", VA = "0x1808EB4C0")]
	private BKFKBNNBNIF(IReadOnlyList<FFPCMKOBEGP> GACINIPOCEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x1EE9BD0", Offset = "0x1EE83D0", VA = "0x181EE9BD0")]
	public static FFPCMKOBEGP ANAAKPPODNK(IReadOnlyList<FFPCMKOBEGP> GACINIPOCEF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x1EE9C90", Offset = "0x1EE8490", VA = "0x181EE9C90")]
	public static KAPLCJNFCJL<CCBMGFEGKNJ, BKFKBNNBNIF> LGDGMAPANEP(FFPCMKOBEGP GBNFLMDHJDA)
	{
		return default(KAPLCJNFCJL<CCBMGFEGKNJ, BKFKBNNBNIF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x1EE9D30", Offset = "0x1EE8530", VA = "0x181EE9D30")]
	[AsyncStateMachine(typeof(KLJKHEBBBOP))]
	public static Task<MEKCEIEFNPI<NHDCCNGJOAJ, MNGIPKBLGNG>> OMJFCELAODC(BBIGJEMLFFM AHKBBGKKCNK, BKFKBNNBNIF EGJINJKGIAK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public readonly struct OFCGFGNGDLN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	public readonly int HJCFDKBBGAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	public readonly int CFDBFCCMKIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	public readonly byte[] IGFBHOELDIM;

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x1A5B6C0", Offset = "0x1A59EC0", VA = "0x181A5B6C0")]
	private OFCGFGNGDLN(int POAAACAIHKJ, int JBDLDJOINOF, byte[] MLKNGAFFKGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x1F02D50", Offset = "0x1F01550", VA = "0x181F02D50")]
	public static FFPCMKOBEGP ANAAKPPODNK(int POAAACAIHKJ, int JBDLDJOINOF, ByteString MLKNGAFFKGE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x1F02E30", Offset = "0x1F01630", VA = "0x181F02E30")]
	public static FFPCMKOBEGP[] CHEDFBDKAIM(FFPCMKOBEGP BMOCGPMNBAF, int LJEMIJOBNIB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x1F03080", Offset = "0x1F01880", VA = "0x181F03080")]
	public static KAPLCJNFCJL<CCBMGFEGKNJ, OFCGFGNGDLN> LGDGMAPANEP(FFPCMKOBEGP GBNFLMDHJDA)
	{
		return default(KAPLCJNFCJL<CCBMGFEGKNJ, OFCGFGNGDLN>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x1F02F60", Offset = "0x1F01760", VA = "0x181F02F60")]
	public static MEKCEIEFNPI<FFPCMKOBEGP, FDKFIPGCOGB> HBHJMBFCIJJ(BBIGJEMLFFM AHKBBGKKCNK, [In] OFCGFGNGDLN EGJINJKGIAK)
	{
		return default(MEKCEIEFNPI<FFPCMKOBEGP, FDKFIPGCOGB>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public readonly struct DODMAHJEIFG
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[CompilerGenerated]
	private struct FOJNPDCPNJM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public AsyncTaskMethodBuilder<MEKCEIEFNPI<bool, FDKFIPGCOGB>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public BBIGJEMLFFM root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public DODMAHJEIFG self;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		private MEKCEIEFNPI<bool, FDKFIPGCOGB> <r>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		private TaskAwaiter<MEKCEIEFNPI<KNDENJDHONE, FDKFIPGCOGB>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x1EEE990", Offset = "0x1EED190", VA = "0x181EEE990", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x1EEEFD0", Offset = "0x1EED7D0", VA = "0x181EEEFD0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public readonly int HJCFDKBBGAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public readonly int CFDBFCCMKIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	public readonly byte[] IGFBHOELDIM;

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x1A5B6C0", Offset = "0x1A59EC0", VA = "0x181A5B6C0")]
	private DODMAHJEIFG(int POAAACAIHKJ, int JBDLDJOINOF, byte[] MLKNGAFFKGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x1EEAE70", Offset = "0x1EE9670", VA = "0x181EEAE70")]
	public static FFPCMKOBEGP ANAAKPPODNK(int POAAACAIHKJ, int JBDLDJOINOF, ByteString MLKNGAFFKGE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x1EEAC80", Offset = "0x1EE9480", VA = "0x181EEAC80")]
	public static FFPCMKOBEGP?[]? AJLBMLIKBAJ(int LJEMIJOBNIB, DNCJDBJPHOD? JDMOMCFHMKL, EALEPKELLAJ? JJIHFFIJJCL, GMFGEGDFAPN? KIPPBODDGFF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x1EEAF50", Offset = "0x1EE9750", VA = "0x181EEAF50")]
	public static KAPLCJNFCJL<CCBMGFEGKNJ, DODMAHJEIFG> LGDGMAPANEP(FFPCMKOBEGP GBNFLMDHJDA)
	{
		return default(KAPLCJNFCJL<CCBMGFEGKNJ, DODMAHJEIFG>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x1EEB030", Offset = "0x1EE9830", VA = "0x181EEB030")]
	[AsyncStateMachine(typeof(FOJNPDCPNJM))]
	public static Task<MEKCEIEFNPI<bool, FDKFIPGCOGB>> OMJFCELAODC(BBIGJEMLFFM AHKBBGKKCNK, DODMAHJEIFG EGJINJKGIAK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public sealed class DHKGAJEJCNB : OELKAHKLBKD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private readonly BBIGJEMLFFM NOLFNCBBDEO;

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public IGNHLLPIOMC? DCEJKJKKEPJ
	{
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x1EEAB70", Offset = "0x1EE9370", VA = "0x181EEAB70", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x8468E0", Offset = "0x8450E0", VA = "0x1808468E0")]
	internal DHKGAJEJCNB(BBIGJEMLFFM POJGEMMMHAN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public sealed class JEMMOIPDIID : IGNHLLPIOMC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private readonly BBIGJEMLFFM NOLFNCBBDEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private readonly NKLPINCAHPI CDMLJIFOEDL;

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x84B520", Offset = "0x849D20", VA = "0x18084B520")]
	public JEMMOIPDIID(BBIGJEMLFFM POJGEMMMHAN, NKLPINCAHPI KGAENLAMAOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x1EF2890", Offset = "0x1EF1090", VA = "0x181EF2890", Slot = "4")]
	public MEKCEIEFNPI<KNGLCMLCKEI, ABFPKHFPAFK> EMPFIPJCBCB(EOFGJNJAJLP<GHBFIOLFDBB> FMPAALMFOIG, KPFGDODNFBO<PKDEPFAFNML> KCJMKIMEENL, KPFGDODNFBO<LADMNJOONHG> CACIDFDKPBJ)
	{
		return default(MEKCEIEFNPI<KNGLCMLCKEI, ABFPKHFPAFK>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x1EF25C0", Offset = "0x1EF0DC0", VA = "0x181EF25C0", Slot = "5")]
	public MEKCEIEFNPI<KNGLCMLCKEI, ABFPKHFPAFK> COMDOPIBCIN(EOFGJNJAJLP<GHBFIOLFDBB> FMPAALMFOIG, KPFGDODNFBO<PKDEPFAFNML> KCJMKIMEENL, KPFGDODNFBO<BBEHFBIGKLK> CJCIDDLJNDI)
	{
		return default(MEKCEIEFNPI<KNGLCMLCKEI, ABFPKHFPAFK>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public sealed class OIFCMCHIANM : LGOKBJDJBBL, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public interface HDGPGICGCFD
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Task<NKLPINCAHPI> IEGGDJOPBEK(BBIGJEMLFFM POJGEMMMHAN, EALEPKELLAJ? LFKONOFAJCG, GMFGEGDFAPN? NKOOKCEENNJ, CancellationToken ODNHMAMKFFP);

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		DKEMDCNIIKB HOINOFLNOBL(BBIGJEMLFFM POJGEMMMHAN, DNCJDBJPHOD MPOAKIEMPHF);
	}

	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public sealed class HGHKHFAMPJL : HDGPGICGCFD
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000028")]
		[CompilerGenerated]
		private struct EMPBANPHMMH : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000070")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000071")]
			public AsyncTaskMethodBuilder<NKLPINCAHPI> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000072")]
			public BBIGJEMLFFM circuitsManager;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000073")]
			public EALEPKELLAJ cv2RoomData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000074")]
			public GMFGEGDFAPN cv2SuperRoomData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000075")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000076")]
			private TaskAwaiter<LDNILKFEDEA> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(RVA = "0x1EEB5D0", Offset = "0x1EE9DD0", VA = "0x181EEB5D0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0x1EEB7A0", Offset = "0x1EE9FA0", VA = "0x181EEB7A0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400006F")]
		public static readonly HGHKHFAMPJL DCEJKJKKEPJ;

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
		private HGHKHFAMPJL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x1EF07C0", Offset = "0x1EEEFC0", VA = "0x181EF07C0", Slot = "4")]
		[AsyncStateMachine(typeof(EMPBANPHMMH))]
		public Task<NKLPINCAHPI> IEGGDJOPBEK(BBIGJEMLFFM POJGEMMMHAN, EALEPKELLAJ? LFKONOFAJCG, GMFGEGDFAPN? NKOOKCEENNJ, CancellationToken ODNHMAMKFFP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x1EF07A0", Offset = "0x1EEEFA0", VA = "0x181EF07A0", Slot = "5")]
		public DKEMDCNIIKB HOINOFLNOBL(BBIGJEMLFFM POJGEMMMHAN, DNCJDBJPHOD MPOAKIEMPHF)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	[CompilerGenerated]
	private struct IBMCCOKLHBN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		public AsyncTaskMethodBuilder<OIFCMCHIANM> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		public BBIGJEMLFFM circuitsManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		public EALEPKELLAJ cv2RoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public GMFGEGDFAPN cv2SuperRoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public DNCJDBJPHOD evRoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		private HDGPGICGCFD <selfDeps>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		private TaskAwaiter<NKLPINCAHPI> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x1EF11C0", Offset = "0x1EEF9C0", VA = "0x181EF11C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x1EF1710", Offset = "0x1EEFF10", VA = "0x181EF1710", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private readonly NKLPINCAHPI CDMLJIFOEDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private readonly DKEMDCNIIKB LOLNPINEABM;

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public CHJFBOCODMI PKJNCODPJPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x1F03950", Offset = "0x1F02150", VA = "0x181F03950", Slot = "4")]
		get
		{
			return default(CHJFBOCODMI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public BEMDKNAJANC IELMDAHECEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x1F036C0", Offset = "0x1F01EC0", VA = "0x181F036C0", Slot = "5")]
		get
		{
			return default(BEMDKNAJANC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public JEMMOIPDIID ABNFLOEFEFL
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x84A260", Offset = "0x848A60", VA = "0x18084A260", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public IPCNJLMACLH KHDLLBIDKLG
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x8472F0", Offset = "0x845AF0", VA = "0x1808472F0", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public JOBKCMIPLCA ABGIOFHANMD
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x847480", Offset = "0x845C80", VA = "0x180847480", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x1F039B0", Offset = "0x1F021B0", VA = "0x181F039B0")]
	private OIFCMCHIANM(NKLPINCAHPI KGAENLAMAOA, DKEMDCNIIKB DPBKGBBCJOE, JEMMOIPDIID MEFEIHCGCJI, IPCNJLMACLH GFHGJNNHBJJ, JOBKCMIPLCA CEAFDEKCCND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x1F037E0", Offset = "0x1F01FE0", VA = "0x181F037E0")]
	[AsyncStateMachine(typeof(IBMCCOKLHBN))]
	public static Task<OIFCMCHIANM> LKAFENPIICK(BBIGJEMLFFM POJGEMMMHAN, DNCJDBJPHOD MPOAKIEMPHF, EALEPKELLAJ? LFKONOFAJCG, GMFGEGDFAPN? NKOOKCEENNJ, CancellationToken ODNHMAMKFFP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x1F03780", Offset = "0x1F01F80", VA = "0x181F03780", Slot = "9")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public sealed class IBJGOCHMKAI : DJDKLOIJFMF, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	public interface OHHNNMMCNCA
	{
		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Task<LGOKBJDJBBL> CEAJBKINHAD(BBIGJEMLFFM POJGEMMMHAN, DNCJDBJPHOD MPOAKIEMPHF, EALEPKELLAJ? LFKONOFAJCG, GMFGEGDFAPN? NKOOKCEENNJ, CancellationToken ODNHMAMKFFP);

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void ACFOMJPMDGH();

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void CHBAHMNKEBI();
	}

	[Cpp2IlInjected.Token(Token = "0x200002C")]
	public abstract class FABBLNEJJHB : OHHNNMMCNCA
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200002D")]
		[CompilerGenerated]
		private struct GFCOKMNEMAG : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000088")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000089")]
			public AsyncTaskMethodBuilder<LGOKBJDJBBL> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400008A")]
			public BBIGJEMLFFM circuitsManager;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400008B")]
			public DNCJDBJPHOD evRoomData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400008C")]
			public EALEPKELLAJ cv2RoomData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400008D")]
			public GMFGEGDFAPN cv2SuperRoomData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400008E")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400008F")]
			private TaskAwaiter<OIFCMCHIANM> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0x1EEF250", Offset = "0x1EEDA50", VA = "0x181EEF250", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A9")]
			[Cpp2IlInjected.Address(RVA = "0x1EEF590", Offset = "0x1EEDD90", VA = "0x181EEF590", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x1EEB810", Offset = "0x1EEA010", VA = "0x181EEB810", Slot = "4")]
		[AsyncStateMachine(typeof(GFCOKMNEMAG))]
		public Task<LGOKBJDJBBL> CEAJBKINHAD(BBIGJEMLFFM POJGEMMMHAN, DNCJDBJPHOD MPOAKIEMPHF, EALEPKELLAJ? LFKONOFAJCG, GMFGEGDFAPN? NKOOKCEENNJ, CancellationToken ODNHMAMKFFP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(Slot = "7")]
		public abstract void ACFOMJPMDGH();

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(Slot = "8")]
		public abstract void CHBAHMNKEBI();

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
		protected FABBLNEJJHB()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[CompilerGenerated]
	private struct MLGGMCFFJGC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		public AsyncTaskMethodBuilder<LGOKBJDJBBL> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		public IBJGOCHMKAI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		private TaskAwaiter<KNDENJDHONE> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x1EFF4A0", Offset = "0x1EFDCA0", VA = "0x181EFF4A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x1EFF6A0", Offset = "0x1EFDEA0", VA = "0x181EFF6A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[CompilerGenerated]
	private struct JCIHKMDOHGO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		public IBJGOCHMKAI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		public BBIGJEMLFFM circuitsManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		public DNCJDBJPHOD evRoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		public EALEPKELLAJ cv2RoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		public GMFGEGDFAPN cv2SuperRoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		private TaskAwaiter<LGOKBJDJBBL> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x1EF1CD0", Offset = "0x1EF04D0", VA = "0x181EF1CD0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x1EF2200", Offset = "0x1EF0A00", VA = "0x181EF2200", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	private readonly OHHNNMMCNCA KKHHCBLJJJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	private readonly TaskCompletionSource<KNDENJDHONE> AICIEKAPGOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	private readonly TaskCompletionSource<KNDENJDHONE> LGBODIILHKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	private readonly CancellationTokenSource GMPEGMHBFKC;

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public bool HLCECCKHFAA
	{
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x993570", Offset = "0x991D70", VA = "0x180993570", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0xA10950", Offset = "0xA0F150", VA = "0x180A10950")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public bool ICIDCBOPNAK
	{
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0xA84D70", Offset = "0xA83570", VA = "0x180A84D70", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0xA84D80", Offset = "0xA83580", VA = "0x180A84D80")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public bool ABAMNPMKPAF
	{
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x1085D40", Offset = "0x1084540", VA = "0x181085D40")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x1EF0E50", Offset = "0x1EEF650", VA = "0x181EF0E50")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public LGOKBJDJBBL? OCJLEGJMBDK
	{
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x8474A0", Offset = "0x845CA0", VA = "0x1808474A0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x847500", Offset = "0x845D00", VA = "0x180847500")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x1EF0E60", Offset = "0x1EEF660", VA = "0x181EF0E60", Slot = "7")]
	[AsyncStateMachine(typeof(MLGGMCFFJGC))]
	public Task<LGOKBJDJBBL> NFEPILDBMAB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x1EF10B0", Offset = "0x1EEF8B0", VA = "0x181EF10B0")]
	public IBJGOCHMKAI(OHHNNMMCNCA DNJOEPEBEMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x1EF0F50", Offset = "0x1EEF750", VA = "0x181EF0F50", Slot = "8")]
	[AsyncStateMachine(typeof(JCIHKMDOHGO))]
	public Task PIIKJJHALGM(BBIGJEMLFFM POJGEMMMHAN, DNCJDBJPHOD MPOAKIEMPHF, EALEPKELLAJ? LFKONOFAJCG, GMFGEGDFAPN? NKOOKCEENNJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x1EF0CE0", Offset = "0x1EEF4E0", VA = "0x181EF0CE0", Slot = "9")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
internal sealed class AMMFLKBDDPA : PLLKIKEHKCM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private readonly IPCNJLMACLH PPIPFCIOJDP;

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x8468E0", Offset = "0x8450E0", VA = "0x1808468E0")]
	public AMMFLKBDDPA(IPCNJLMACLH GFHGJNNHBJJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
internal static class FCIFCJEKNBO
{
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	private class BKNFIELOENF<TGraph> : DIOAIIMAGGE where TGraph : KJEAHHMOGFO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		protected readonly TGraph KCNHCJMGKGD;

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public virtual FHNMIKPMGNA? JJAMAJGLGCA
		{
			[Cpp2IlInjected.Token(Token = "0x60000B0")]
			[Cpp2IlInjected.Address(RVA = "0xEC3CB0", Offset = "0xEC24B0", VA = "0x180EC3CB0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public KPFGDODNFBO<GPCAGFNHADK> IIDMDJMPOHI
		{
			[Cpp2IlInjected.Token(Token = "0x60000B2")]
			[Cpp2IlInjected.Address(RVA = "0x4D34050", Offset = "0x4D32850", VA = "0x184D34050", Slot = "4")]
			get
			{
				return default(KPFGDODNFBO<GPCAGFNHADK>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x8468E0", Offset = "0x8450E0", VA = "0x1808468E0")]
		public BKNFIELOENF(TGraph NCNAHELFBKL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000033")]
	private sealed class EJPPLIGHHJL : BKNFIELOENF<FPIFPIDGJGD>
	{
		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public override FHNMIKPMGNA? JJAMAJGLGCA
		{
			[Cpp2IlInjected.Token(Token = "0x60000B3")]
			[Cpp2IlInjected.Address(RVA = "0x1EEB4E0", Offset = "0x1EE9CE0", VA = "0x181EEB4E0", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x1EEB500", Offset = "0x1EE9D00", VA = "0x181EEB500")]
		public EJPPLIGHHJL(FPIFPIDGJGD OIAFGCMAKOL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x1EEBD50", Offset = "0x1EEA550", VA = "0x181EEBD50")]
	public static DIOAIIMAGGE OJFFIHPLODM(KJEAHHMOGFO NCNAHELFBKL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public sealed class OCDGHLGOHKH : GENKCIDABNJ, ICBHAHEPKLA, DCDFABOKGOA, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	[CompilerGenerated]
	private sealed class GNBDHNNNOAO
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000037")]
		private struct <<RequestSetBoolDefaultValue>g__requestSetBoolDefaultValueInternal|0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A9")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40000AA")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000AB")]
			public GNBDHNNNOAO <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000AC")]
			public FKNKBHHKDOE errReporting_;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000AD")]
			private TaskAwaiter<MEKCEIEFNPI<KNDENJDHONE, MNGIPKBLGNG>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60000E1")]
			[Cpp2IlInjected.Address(RVA = "0x1F04C40", Offset = "0x1F03440", VA = "0x181F04C40", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E2")]
			[Cpp2IlInjected.Address(RVA = "0x1F04EB0", Offset = "0x1F036B0", VA = "0x181F04EB0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		public OCDGHLGOHKH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		public bool value;

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
		public GNBDHNNNOAO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x1EF06B0", Offset = "0x1EEEEB0", VA = "0x181EF06B0")]
		[AsyncStateMachine(typeof(<<RequestSetBoolDefaultValue>g__requestSetBoolDefaultValueInternal|0>d))]
		internal Task ELDOFIFEDIA(FKNKBHHKDOE errReporting_)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	[CompilerGenerated]
	private struct GIJPKCMBOHO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		public bool checkStringPurity;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		public OCDGHLGOHKH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		public string value;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		private TaskAwaiter<bool> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		private TaskAwaiter<MEKCEIEFNPI<KNDENJDHONE, MNGIPKBLGNG>> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x1EEFD60", Offset = "0x1EEE560", VA = "0x181EEFD60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x1EF0270", Offset = "0x1EEEA70", VA = "0x181EF0270", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000039")]
	[CompilerGenerated]
	private sealed class PNNGGCFAHJL
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200003A")]
		private struct <<RequestSetIntDefaultValue>g__requestSetIntDefaultValueInternal|0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000B7")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40000B8")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000B9")]
			public PNNGGCFAHJL <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000BA")]
			private TaskAwaiter<MEKCEIEFNPI<KNDENJDHONE, MNGIPKBLGNG>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60000E7")]
			[Cpp2IlInjected.Address(RVA = "0x1F04F10", Offset = "0x1F03710", VA = "0x181F04F10", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E8")]
			[Cpp2IlInjected.Address(RVA = "0x1F051F0", Offset = "0x1F039F0", VA = "0x181F051F0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		public OCDGHLGOHKH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		public int value;

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
		public PNNGGCFAHJL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x1F04940", Offset = "0x1F03140", VA = "0x181F04940")]
		[AsyncStateMachine(typeof(<<RequestSetIntDefaultValue>g__requestSetIntDefaultValueInternal|0>d))]
		internal Task EMBFFKLKGHJ(FKNKBHHKDOE errReporting_)
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private readonly GODMFLAOBFD MAFKHDNPPNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	private readonly ICollection<DBEEMEOFOME> MEJBJACFIEE;

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	private OGMIBBIPCFM MFLGLPAICLB
	{
		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x1F01630", Offset = "0x1EFFE30", VA = "0x181F01630")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public KPFGDODNFBO<LADMNJOONHG> HEGEGEENGCF
	{
		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x8B20A0", Offset = "0x8B08A0", VA = "0x1808B20A0", Slot = "24")]
		[CompilerGenerated]
		get
		{
			return default(KPFGDODNFBO<LADMNJOONHG>);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0xC42E30", Offset = "0xC41630", VA = "0x180C42E30")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	private KPFGDODNFBO<GOLMGBIAPOO> OJGNPECLLFB
	{
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0xA86250", Offset = "0xA84A50", VA = "0x180A86250")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public KPFGDODNFBO<CNIDNALDCPF> OKBNGFNHCNP
	{
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x86A250", Offset = "0x868A50", VA = "0x18086A250", Slot = "25")]
		[CompilerGenerated]
		get
		{
			return default(KPFGDODNFBO<CNIDNALDCPF>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public override KPFGDODNFBO<KLPCKDHOMDF> FKNDCFLHOIC
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x1F02A00", Offset = "0x1F01200", VA = "0x181F02A00", Slot = "20")]
		get
		{
			return default(KPFGDODNFBO<KLPCKDHOMDF>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public bool OIFELBHNDFP
	{
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x1F019E0", Offset = "0x1F001E0", VA = "0x181F019E0", Slot = "26")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x1F02A40", Offset = "0x1F01240", VA = "0x181F02A40")]
	private OCDGHLGOHKH(BBIGJEMLFFM POJGEMMMHAN, LAMDOCKGMNE DDLCNKGIKEK, GODMFLAOBFD CHDOBFOBNJG, KPFGDODNFBO<PKDEPFAFNML> KCJMKIMEENL, KPFGDODNFBO<LADMNJOONHG> CACIDFDKPBJ, KPFGDODNFBO<GOLMGBIAPOO> EFMFHDBJLDJ, bool LHBIAKHJHPD, string GCDLMFGKKMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x1F023C0", Offset = "0x1F00BC0", VA = "0x181F023C0")]
	public static OCDGHLGOHKH OJFFIHPLODM(BBIGJEMLFFM POJGEMMMHAN, LAMDOCKGMNE DDLCNKGIKEK, GODMFLAOBFD FDJIPPJKNDH, KPFGDODNFBO<PKDEPFAFNML> KCJMKIMEENL, KPFGDODNFBO<GOLMGBIAPOO> EFMFHDBJLDJ, KPFGDODNFBO<LADMNJOONHG> CACIDFDKPBJ, bool LHBIAKHJHPD, bool MDFLPMGGCAP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x1F00610", Offset = "0x1EFEE10", VA = "0x181F00610", Slot = "21")]
	protected override void DIHNAABPOCM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x1F006B0", Offset = "0x1EFEEB0", VA = "0x181F006B0", Slot = "22")]
	public override void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x1F018B0", Offset = "0x1F000B0", VA = "0x181F018B0", Slot = "30")]
	public void JLFPGJCJHLJ(DBEEMEOFOME OMELFDOGHEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x1F002A0", Offset = "0x1EFEAA0", VA = "0x181F002A0", Slot = "27")]
	public void BPBGDNNKBBI(GEBNCMNMMKC FFEKOHOBDPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x1F00A90", Offset = "0x1EFF290", VA = "0x181F00A90", Slot = "28")]
	public void HEFLPNAJNOJ(DMADIGJBAMD AJKPKFPALFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x1F01760", Offset = "0x1EFFF60", VA = "0x181F01760", Slot = "23")]
	protected override void IMPNCEOIIPH(GCBOKNEHCAE IDFDJCHKGCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x1F02250", Offset = "0x1F00A50", VA = "0x181F02250", Slot = "32")]
	public string OEFMDAJGBEK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x1F01D20", Offset = "0x1F00520", VA = "0x181F01D20", Slot = "29")]
	public string LJNFJJCNGNM(int JBKJHFHKKLA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x1F00860", Offset = "0x1EFF060", VA = "0x181F00860")]
	private void GCEAKKCNACP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x1F02180", Offset = "0x1F00980", VA = "0x181F02180", Slot = "31")]
	public void NBKLIAICLLF(DBEEMEOFOME OMELFDOGHEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x1F02840", Offset = "0x1F01040", VA = "0x181F02840")]
	private void PIIHHPPGCCD(bool IPHHABIKCHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x1F01650", Offset = "0x1EFFE50", VA = "0x181F01650", Slot = "33")]
	[AsyncStateMachine(typeof(GIJPKCMBOHO))]
	public Task IMEPLCIBPFG(string IPHHABIKCHD, bool IJLPBFILJDA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x1F01BD0", Offset = "0x1F003D0", VA = "0x181F01BD0")]
	public void LBKILLEFAGO(string IPHHABIKCHD, bool IJLPBFILJDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x1F01FE0", Offset = "0x1F007E0", VA = "0x181F01FE0")]
	private void MOIIPHFEBGI(int IPHHABIKCHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0xC42E30", Offset = "0xC41630", VA = "0x180C42E30")]
	internal void HGADHHPJFEJ(KPFGDODNFBO<LADMNJOONHG> IPHHABIKCHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x1F02830", Offset = "0x1F01030", VA = "0x181F02830")]
	[CompilerGenerated]
	private void OKHHJMKKFPI(string IPHHABIKCHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x1F014B0", Offset = "0x1EFFCB0", VA = "0x181F014B0")]
	[CompilerGenerated]
	private bool HOKNFOMBODB()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x1F00750", Offset = "0x1EFEF50", VA = "0x181F00750")]
	[CompilerGenerated]
	private bool ECFIJLLHDCB()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x1F01A60", Offset = "0x1F00260", VA = "0x181F01A60")]
	[CompilerGenerated]
	private int KDNEFKBIHLN()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x1F00190", Offset = "0x1EFE990", VA = "0x181F00190")]
	[CompilerGenerated]
	private bool ALAAHIAGAKA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x1F023B0", Offset = "0x1F00BB0", VA = "0x181F023B0")]
	[CompilerGenerated]
	private void OIFPBPHOFLM(string IPHHABIKCHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x1F01570", Offset = "0x1EFFD70", VA = "0x181F01570")]
	[CompilerGenerated]
	private bool IBCACECHGIE()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x1F01B80", Offset = "0x1F00380", VA = "0x181F01B80")]
	[CompilerGenerated]
	private bool KEHOMFMEGJM()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x1F01420", Offset = "0x1EFFC20", VA = "0x181F01420")]
	[CompilerGenerated]
	private bool HLHNMCIAOLL()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x1F01A60", Offset = "0x1F00260", VA = "0x181F01A60")]
	[CompilerGenerated]
	private int NIOCIKCDMMC()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x1F01AB0", Offset = "0x1F002B0", VA = "0x181F01AB0")]
	[CompilerGenerated]
	private bool KEFIJMPAOJL()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x1F00810", Offset = "0x1EFF010", VA = "0x181F00810")]
	[CompilerGenerated]
	private int FKAEOHKPDAN()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x1F00220", Offset = "0x1EFEA20", VA = "0x181F00220")]
	[CompilerGenerated]
	private void BEIHBBIBIJH(object IPHHABIKCHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x1F01910", Offset = "0x1F00110", VA = "0x181F01910")]
	[CompilerGenerated]
	private bool JPCHCDGIKBG()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public static class KEFCILIAMEE
{
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	public sealed class PHIKCACBOBM : LEBEFFPHJII<JMGCGMHBLBL>
	{
		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public override JLGGLBLNBGM BGHMEIKPHJP
		{
			[Cpp2IlInjected.Token(Token = "0x60000EB")]
			[Cpp2IlInjected.Address(RVA = "0x8BEAF0", Offset = "0x8BD2F0", VA = "0x1808BEAF0", Slot = "125")]
			get
			{
				return default(JLGGLBLNBGM);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x1F048E0", Offset = "0x1F030E0", VA = "0x181F048E0")]
		public PHIKCACBOBM(BBIGJEMLFFM POJGEMMMHAN, JMGCGMHBLBL LHMMDMHNIJC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003D")]
	public sealed class JCPLIJLHNMN : KBILGNIMNAC<JBGKEHCCKKG>
	{
		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x1EF2550", Offset = "0x1EF0D50", VA = "0x181EF2550")]
		public JCPLIJLHNMN(BBIGJEMLFFM POJGEMMMHAN, JBGKEHCCKKG DDLCNKGIKEK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x1EF2260", Offset = "0x1EF0A60", VA = "0x181EF2260", Slot = "119")]
		protected override void ACMFEFOOMLB(EJLAIGMFDKK BADOLCEECJG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x1EF2500", Offset = "0x1EF0D00", VA = "0x181EF2500")]
		[CompilerGenerated]
		private bool LFLLNPJOMEN()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x1EF23E0", Offset = "0x1EF0BE0", VA = "0x181EF23E0")]
		[CompilerGenerated]
		private void IHPJOECDOJH(bool IPHHABIKCHD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003E")]
	public sealed class OJIEOGCBEHA : KBILGNIMNAC<ECFDOIKAONA>
	{
		[Cpp2IlInjected.Token(Token = "0x200003F")]
		[CompilerGenerated]
		private sealed class JBHMPDELBFI
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000BB")]
			public AOONLOOENIF nodeAdapterDeps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000BC")]
			public OJIEOGCBEHA <>4__this;

			[Cpp2IlInjected.Token(Token = "0x60000F2")]
			[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
			public JBHMPDELBFI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F3")]
			[Cpp2IlInjected.Address(RVA = "0x1EF1C30", Offset = "0x1EF0430", VA = "0x181EF1C30")]
			internal void LMFIIKHIMLH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F4")]
			[Cpp2IlInjected.Address(RVA = "0x1EF1C80", Offset = "0x1EF0480", VA = "0x181EF1C80")]
			internal bool PFCOBPBKFAK()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000F5")]
			[Cpp2IlInjected.Address(RVA = "0x1EF1BE0", Offset = "0x1EF03E0", VA = "0x181EF1BE0")]
			internal bool HNPBNHGAOHN()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000F6")]
			[Cpp2IlInjected.Address(RVA = "0x1EF1AC0", Offset = "0x1EF02C0", VA = "0x181EF1AC0")]
			internal void HDLNADONHGI(bool value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F7")]
			[Cpp2IlInjected.Address(RVA = "0x1EF1A70", Offset = "0x1EF0270", VA = "0x181EF1A70")]
			internal bool EMLJHLHJDJF()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x1F03D70", Offset = "0x1F02570", VA = "0x181F03D70")]
		public OJIEOGCBEHA(BBIGJEMLFFM POJGEMMMHAN, ECFDOIKAONA DDLCNKGIKEK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x1F03A40", Offset = "0x1F02240", VA = "0x181F03A40", Slot = "119")]
		protected override void ACMFEFOOMLB(EJLAIGMFDKK BADOLCEECJG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000040")]
	public sealed class PCFEPDIHKGO : KBILGNIMNAC<EPIFOCGBBMB>
	{
		[Cpp2IlInjected.Token(Token = "0x2000041")]
		[CompilerGenerated]
		private sealed class GFECDKKNHFC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000BD")]
			public AOONLOOENIF nodeAdapterDeps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000BE")]
			public PCFEPDIHKGO <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000BF")]
			public Predicate<Guid> <>9__7;

			[Cpp2IlInjected.Token(Token = "0x60000FA")]
			[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
			public GFECDKKNHFC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FB")]
			[Cpp2IlInjected.Address(RVA = "0x1EEF870", Offset = "0x1EEE070", VA = "0x181EEF870")]
			internal object LMFIIKHIMLH()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000FC")]
			[Cpp2IlInjected.Address(RVA = "0x1EEFA90", Offset = "0x1EEE290", VA = "0x181EEFA90")]
			internal bool OIFMFDKHAFM(Guid id)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000FD")]
			[Cpp2IlInjected.Address(RVA = "0x1EEFB10", Offset = "0x1EEE310", VA = "0x181EEFB10")]
			internal void PFCOBPBKFAK(object value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FE")]
			[Cpp2IlInjected.Address(RVA = "0x1EEF710", Offset = "0x1EEDF10", VA = "0x181EEF710")]
			internal string HNPBNHGAOHN(object key)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000FF")]
			[Cpp2IlInjected.Address(RVA = "0x1EEF6C0", Offset = "0x1EEDEC0", VA = "0x181EEF6C0")]
			internal IReadOnlyList<object> HDLNADONHGI()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000100")]
			[Cpp2IlInjected.Address(RVA = "0x1EEF650", Offset = "0x1EEDE50", VA = "0x181EEF650")]
			internal bool EMLJHLHJDJF()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000101")]
			[Cpp2IlInjected.Address(RVA = "0x1EEF600", Offset = "0x1EEDE00", VA = "0x181EEF600")]
			internal bool DCEDNMKAINM()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000102")]
			[Cpp2IlInjected.Address(RVA = "0x1EEF970", Offset = "0x1EEE170", VA = "0x181EEF970")]
			internal void OACPCMEGBFK(bool value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x1F04870", Offset = "0x1F03070", VA = "0x181F04870")]
		public PCFEPDIHKGO(BBIGJEMLFFM POJGEMMMHAN, EPIFOCGBBMB DDLCNKGIKEK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x1F04110", Offset = "0x1F02910", VA = "0x181F04110", Slot = "119")]
		protected override void ACMFEFOOMLB(EJLAIGMFDKK BADOLCEECJG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000042")]
	public sealed class JPABJGACACP : KBILGNIMNAC<GAENHKNOFOH>
	{
		[Cpp2IlInjected.Token(Token = "0x2000043")]
		[CompilerGenerated]
		private sealed class CNFADGNKMNB
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000C0")]
			public JPABJGACACP <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000C1")]
			public AOONLOOENIF nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x6000105")]
			[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
			public CNFADGNKMNB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000106")]
			[Cpp2IlInjected.Address(RVA = "0x1EE9EC0", Offset = "0x1EE86C0", VA = "0x181EE9EC0")]
			internal bool LMFIIKHIMLH()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000107")]
			[Cpp2IlInjected.Address(RVA = "0x1EE9F10", Offset = "0x1EE8710", VA = "0x181EE9F10")]
			internal void PFCOBPBKFAK(bool value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000108")]
			[Cpp2IlInjected.Address(RVA = "0x1EE9E70", Offset = "0x1EE8670", VA = "0x181EE9E70")]
			internal bool HNPBNHGAOHN()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x1EF2D90", Offset = "0x1EF1590", VA = "0x181EF2D90")]
		public JPABJGACACP(BBIGJEMLFFM POJGEMMMHAN, GAENHKNOFOH DDLCNKGIKEK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x1EF2B60", Offset = "0x1EF1360", VA = "0x181EF2B60", Slot = "119")]
		protected override void ACMFEFOOMLB(EJLAIGMFDKK BADOLCEECJG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000044")]
	public abstract class JLPEDCDJKCE<TNode> : KBILGNIMNAC<TNode> where TNode : notnull, DNLGFCDNPAA
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000045")]
		[CompilerGenerated]
		private struct PHLJMMPDPHO : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C2")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C3")]
			public AsyncTaskMethodBuilder<MEKCEIEFNPI<KPFGDODNFBO<PKDEPFAFNML>, MNGIPKBLGNG>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C4")]
			public JLPEDCDJKCE<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C5")]
			public string name;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C6")]
			private TaskAwaiter<MEKCEIEFNPI<KPFGDODNFBO<PKDEPFAFNML>, MNGIPKBLGNG>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000111")]
			[Cpp2IlInjected.Address(RVA = "0x46586A0", Offset = "0x4656EA0", VA = "0x1846586A0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000112")]
			[Cpp2IlInjected.Address(RVA = "0x4658AA0", Offset = "0x46572A0", VA = "0x184658AA0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000046")]
		[CompilerGenerated]
		private struct IOMOHFIMAAH : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C7")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C8")]
			public AsyncTaskMethodBuilder<MEKCEIEFNPI<KNDENJDHONE, MNGIPKBLGNG>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C9")]
			public JLPEDCDJKCE<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000CA")]
			public KPFGDODNFBO<PKDEPFAFNML> portGroupId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000CB")]
			private TaskAwaiter<MEKCEIEFNPI<KNDENJDHONE, MNGIPKBLGNG>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000113")]
			[Cpp2IlInjected.Address(RVA = "0x3DBE930", Offset = "0x3DBD130", VA = "0x183DBE930", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000114")]
			[Cpp2IlInjected.Address(RVA = "0x3DBED30", Offset = "0x3DBD530", VA = "0x183DBED30", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public sealed override bool BGIOAPKMJLL
		{
			[Cpp2IlInjected.Token(Token = "0x6000109")]
			[Cpp2IlInjected.Address(RVA = "0x85D960", Offset = "0x85C160", VA = "0x18085D960", Slot = "114")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public sealed override KPFGDODNFBO<PKDEPFAFNML>? ILJINCGBOJM
		{
			[Cpp2IlInjected.Token(Token = "0x600010A")]
			[Cpp2IlInjected.Address(RVA = "0x3FAB4A0", Offset = "0x3FA9CA0", VA = "0x183FAB4A0", Slot = "118")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x3BC09B0", Offset = "0x3BBF1B0", VA = "0x183BC09B0")]
		protected JLPEDCDJKCE(BBIGJEMLFFM POJGEMMMHAN, TNode DDLCNKGIKEK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x3FAB270", Offset = "0x3FA9A70", VA = "0x183FAB270", Slot = "99")]
		[AsyncStateMachine(typeof(JLPEDCDJKCE<>.PHLJMMPDPHO))]
		public override Task<MEKCEIEFNPI<KPFGDODNFBO<PKDEPFAFNML>, MNGIPKBLGNG>> JHPBLFBJKCC(string GCDLMFGKKMH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x3FAB130", Offset = "0x3FA9930", VA = "0x183FAB130", Slot = "123")]
		public sealed override bool HJKGAKJBIAL(KPFGDODNFBO<PKDEPFAFNML> KCJMKIMEENL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x3FAB1D0", Offset = "0x3FA99D0", VA = "0x183FAB1D0", Slot = "111")]
		protected sealed override bool ICFHIJMEOPM(KPFGDODNFBO<PKDEPFAFNML> KCJMKIMEENL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x3FAB090", Offset = "0x3FA9890", VA = "0x183FAB090", Slot = "112")]
		protected override bool GNPCIJFFHOC(KPFGDODNFBO<PKDEPFAFNML> KCJMKIMEENL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x3FAB390", Offset = "0x3FA9B90", VA = "0x183FAB390", Slot = "100")]
		[AsyncStateMachine(typeof(JLPEDCDJKCE<>.IOMOHFIMAAH))]
		public override Task<MEKCEIEFNPI<KNDENJDHONE, MNGIPKBLGNG>> NMBJBIGKBIB(KPFGDODNFBO<PKDEPFAFNML> KCJMKIMEENL)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000047")]
	public sealed class OGIGAPCBDLK : LJJAHFFBFNG<FLFJFOCHJAG>
	{
		[Cpp2IlInjected.Token(Token = "0x2000048")]
		[CompilerGenerated]
		private sealed class NACCOKNGPMN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000CC")]
			public OGIGAPCBDLK <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000CD")]
			public AOONLOOENIF nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x6000117")]
			[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
			public NACCOKNGPMN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000118")]
			[Cpp2IlInjected.Address(RVA = "0x1EFFA70", Offset = "0x1EFE270", VA = "0x181EFFA70")]
			internal bool HGEEOBBKBOI()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000119")]
			[Cpp2IlInjected.Address(RVA = "0x1EFF9B0", Offset = "0x1EFE1B0", VA = "0x181EFF9B0")]
			internal void GCBJNFGANHE(bool v)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x1F03660", Offset = "0x1F01E60", VA = "0x181F03660")]
		public OGIGAPCBDLK(BBIGJEMLFFM POJGEMMMHAN, FLFJFOCHJAG LHMMDMHNIJC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x1F03410", Offset = "0x1F01C10", VA = "0x181F03410", Slot = "125")]
		protected override void DDNCMAKEJJM(EJLAIGMFDKK BADOLCEECJG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000049")]
	private sealed class OGEAAKNNOAA : GBJGPINBBDD<ILDPDBLDGJC>
	{
		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public override NodeVisualizationKey PJOIFALPHGK
		{
			[Cpp2IlInjected.Token(Token = "0x600011A")]
			[Cpp2IlInjected.Address(RVA = "0x8C4CA0", Offset = "0x8C34A0", VA = "0x1808C4CA0", Slot = "90")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x1F033B0", Offset = "0x1F01BB0", VA = "0x181F033B0")]
		public OGEAAKNNOAA(BBIGJEMLFFM POJGEMMMHAN, ILDPDBLDGJC DDLCNKGIKEK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x843530", Offset = "0x841D30", VA = "0x180843530", Slot = "119")]
		protected override void ACMFEFOOMLB(EJLAIGMFDKK BADOLCEECJG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004A")]
	private abstract class GBJGPINBBDD<TNode> : KBILGNIMNAC<TNode> where TNode : notnull, HEJLEFPFMDC
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200004B")]
		[CompilerGenerated]
		private struct OBKNPGPJJLI : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000CE")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000CF")]
			public AsyncTaskMethodBuilder<MEKCEIEFNPI<KPFGDODNFBO<PKDEPFAFNML>, MNGIPKBLGNG>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D0")]
			public GBJGPINBBDD<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D1")]
			public string name;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D2")]
			private TaskAwaiter<MEKCEIEFNPI<KPFGDODNFBO<PKDEPFAFNML>, MNGIPKBLGNG>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000126")]
			[Cpp2IlInjected.Address(RVA = "0x453E8B0", Offset = "0x453D0B0", VA = "0x18453E8B0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000127")]
			[Cpp2IlInjected.Address(RVA = "0x453EC50", Offset = "0x453D450", VA = "0x18453EC50", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200004C")]
		[CompilerGenerated]
		private struct MEBLGKNDNEO : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D3")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D4")]
			public AsyncTaskMethodBuilder<MEKCEIEFNPI<KNDENJDHONE, MNGIPKBLGNG>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D5")]
			public GBJGPINBBDD<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D6")]
			public KPFGDODNFBO<PKDEPFAFNML> portGroupId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D7")]
			private TaskAwaiter<MEKCEIEFNPI<KNDENJDHONE, MNGIPKBLGNG>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000128")]
			[Cpp2IlInjected.Address(RVA = "0x4341480", Offset = "0x433FC80", VA = "0x184341480", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000129")]
			[Cpp2IlInjected.Address(RVA = "0x4341800", Offset = "0x4340000", VA = "0x184341800", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public override KPFGDODNFBO<GPCAGFNHADK>? FLHDCAEDJPH
		{
			[Cpp2IlInjected.Token(Token = "0x600011D")]
			[Cpp2IlInjected.Address(RVA = "0x3BC0A00", Offset = "0x3BBF200", VA = "0x183BC0A00", Slot = "115")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public override KPFGDODNFBO<PKDEPFAFNML>? ILJINCGBOJM
		{
			[Cpp2IlInjected.Token(Token = "0x600011E")]
			[Cpp2IlInjected.Address(RVA = "0x3BC0AC0", Offset = "0x3BBF2C0", VA = "0x183BC0AC0", Slot = "118")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x3BC09B0", Offset = "0x3BBF1B0", VA = "0x183BC09B0")]
		public GBJGPINBBDD(BBIGJEMLFFM POJGEMMMHAN, TNode DDLCNKGIKEK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x3BC0780", Offset = "0x3BBEF80", VA = "0x183BC0780", Slot = "99")]
		[AsyncStateMachine(typeof(GBJGPINBBDD<>.OBKNPGPJJLI))]
		public override Task<MEKCEIEFNPI<KPFGDODNFBO<PKDEPFAFNML>, MNGIPKBLGNG>> JHPBLFBJKCC(string GCDLMFGKKMH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x3BC0640", Offset = "0x3BBEE40", VA = "0x183BC0640", Slot = "123")]
		public sealed override bool HJKGAKJBIAL(KPFGDODNFBO<PKDEPFAFNML> KCJMKIMEENL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x3BC06E0", Offset = "0x3BBEEE0", VA = "0x183BC06E0", Slot = "111")]
		protected sealed override bool ICFHIJMEOPM(KPFGDODNFBO<PKDEPFAFNML> KCJMKIMEENL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x3BC05A0", Offset = "0x3BBEDA0", VA = "0x183BC05A0", Slot = "112")]
		protected override bool GNPCIJFFHOC(KPFGDODNFBO<PKDEPFAFNML> KCJMKIMEENL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x3BC08A0", Offset = "0x3BBF0A0", VA = "0x183BC08A0", Slot = "100")]
		[AsyncStateMachine(typeof(GBJGPINBBDD<>.MEBLGKNDNEO))]
		public override Task<MEKCEIEFNPI<KNDENJDHONE, MNGIPKBLGNG>> NMBJBIGKBIB(KPFGDODNFBO<PKDEPFAFNML> KCJMKIMEENL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x843530", Offset = "0x841D30", VA = "0x180843530", Slot = "119")]
		protected override void ACMFEFOOMLB(EJLAIGMFDKK BADOLCEECJG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004D")]
	public sealed class PPACKMOKIIC : KBILGNIMNAC<FBDNKPAKHIP>
	{
		[Cpp2IlInjected.Token(Token = "0x200004E")]
		[CompilerGenerated]
		private sealed class PBKEMIFECJP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000D8")]
			public PPACKMOKIIC <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000D9")]
			public AOONLOOENIF nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x600012D")]
			[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
			public PBKEMIFECJP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600012E")]
			[Cpp2IlInjected.Address(RVA = "0x1F04030", Offset = "0x1F02830", VA = "0x181F04030")]
			internal int LMFIIKHIMLH()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x600012F")]
			[Cpp2IlInjected.Address(RVA = "0x1F04080", Offset = "0x1F02880", VA = "0x181F04080")]
			internal void PFCOBPBKFAK(int colorIndex)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public override NodeVisualizationKey PJOIFALPHGK
		{
			[Cpp2IlInjected.Token(Token = "0x600012B")]
			[Cpp2IlInjected.Address(RVA = "0x8AF8D0", Offset = "0x8AE0D0", VA = "0x1808AF8D0", Slot = "90")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x1F04BD0", Offset = "0x1F033D0", VA = "0x181F04BD0")]
		public PPACKMOKIIC(BBIGJEMLFFM POJGEMMMHAN, FBDNKPAKHIP DDLCNKGIKEK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x1F04A10", Offset = "0x1F03210", VA = "0x181F04A10", Slot = "119")]
		protected override void ACMFEFOOMLB(EJLAIGMFDKK BADOLCEECJG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004F")]
	public sealed class MMAEJDKIBME : LJJAHFFBFNG<HJBEIHGLEML>
	{
		[Cpp2IlInjected.Token(Token = "0x2000050")]
		[CompilerGenerated]
		private sealed class FLHAMHIEMKN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000DA")]
			public MMAEJDKIBME <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000DB")]
			public AOONLOOENIF nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x6000132")]
			[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
			public FLHAMHIEMKN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000133")]
			[Cpp2IlInjected.Address(RVA = "0x1EEC1F0", Offset = "0x1EEA9F0", VA = "0x181EEC1F0")]
			internal int HGEEOBBKBOI()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000134")]
			[Cpp2IlInjected.Address(RVA = "0x1EEC150", Offset = "0x1EEA950", VA = "0x181EEC150")]
			internal void GCBJNFGANHE(int colorIndex)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x1EFF950", Offset = "0x1EFE150", VA = "0x181EFF950")]
		public MMAEJDKIBME(BBIGJEMLFFM POJGEMMMHAN, HJBEIHGLEML LHMMDMHNIJC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x1EFF710", Offset = "0x1EFDF10", VA = "0x181EFF710", Slot = "125")]
		protected override void DDNCMAKEJJM(EJLAIGMFDKK BADOLCEECJG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000051")]
	private sealed class KMEDCBFLKKK : KBILGNIMNAC<NMMDCANBNDH>
	{
		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public override NodeVisualizationKey PJOIFALPHGK
		{
			[Cpp2IlInjected.Token(Token = "0x6000135")]
			[Cpp2IlInjected.Address(RVA = "0x8B3DA0", Offset = "0x8B25A0", VA = "0x1808B3DA0", Slot = "90")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x1EF4740", Offset = "0x1EF2F40", VA = "0x181EF4740")]
		public KMEDCBFLKKK(BBIGJEMLFFM POJGEMMMHAN, NMMDCANBNDH DDLCNKGIKEK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x843530", Offset = "0x841D30", VA = "0x180843530", Slot = "119")]
		protected override void ACMFEFOOMLB(EJLAIGMFDKK BADOLCEECJG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000052")]
	public sealed class FNPJHIJBNOO : KBILGNIMNAC<CNIJIKKGDDI>
	{
		[Cpp2IlInjected.Token(Token = "0x2000053")]
		[CompilerGenerated]
		private sealed class LNGKDGGJAMF
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000DD")]
			public FNPJHIJBNOO <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000DE")]
			public EJLAIGMFDKK configure;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000DF")]
			public Func<string> <>9__224;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000E0")]
			public Action<string> <>9__225;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000E1")]
			public Func<int> <>9__228;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40000E2")]
			public Action<int> <>9__229;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40000E3")]
			public Func<bool> <>9__230;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40000E4")]
			public Func<bool> <>9__231;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x40000E5")]
			public Func<bool> <>9__232;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x40000E6")]
			public Func<float> <>9__233;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x40000E7")]
			public Action<float> <>9__234;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x40000E8")]
			public Func<bool> <>9__235;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x40000E9")]
			public Func<bool> <>9__236;

			[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
			[Cpp2IlInjected.Token(Token = "0x40000EA")]
			public Func<bool> <>9__237;

			[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
			[Cpp2IlInjected.Token(Token = "0x40000EB")]
			public Func<string> <>9__238;

			[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
			[Cpp2IlInjected.Token(Token = "0x40000EC")]
			public Action<string> <>9__239;

			[Cpp2IlInjected.Token(Token = "0x600013A")]
			[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
			public LNGKDGGJAMF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600013B")]
			[Cpp2IlInjected.Address(RVA = "0x1EFDF90", Offset = "0x1EFC790", VA = "0x181EFDF90")]
			internal bool LMFIIKHIMLH()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600013C")]
			[Cpp2IlInjected.Address(RVA = "0x1EFF250", Offset = "0x1EFDA50", VA = "0x181EFF250")]
			internal void PFCOBPBKFAK(bool x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600013D")]
			[Cpp2IlInjected.Address(RVA = "0x1EFBD90", Offset = "0x1EFA590", VA = "0x181EFBD90")]
			internal bool EMLJHLHJDJF()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600013E")]
			[Cpp2IlInjected.Address(RVA = "0x1EFB490", Offset = "0x1EF9C90", VA = "0x181EFB490")]
			internal bool DCEDNMKAINM()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600013F")]
			[Cpp2IlInjected.Address(RVA = "0x1EFEA20", Offset = "0x1EFD220", VA = "0x181EFEA20")]
			internal void OACPCMEGBFK(bool x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000140")]
			[Cpp2IlInjected.Address(RVA = "0x1EFB090", Offset = "0x1EF9890", VA = "0x181EFB090")]
			internal bool CGLNLPKELMO()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000141")]
			[Cpp2IlInjected.Address(RVA = "0x1EFC5F0", Offset = "0x1EFADF0", VA = "0x181EFC5F0")]
			internal bool GKLELMAPCJF()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000142")]
			[Cpp2IlInjected.Address(RVA = "0x1EFE7E0", Offset = "0x1EFCFE0", VA = "0x181EFE7E0")]
			internal void NKAJLMDLLFL(bool x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000143")]
			[Cpp2IlInjected.Address(RVA = "0x1EFD7D0", Offset = "0x1EFBFD0", VA = "0x181EFD7D0")]
			internal bool JLFACIPAGBI()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000144")]
			[Cpp2IlInjected.Address(RVA = "0x1EFB790", Offset = "0x1EF9F90", VA = "0x181EFB790")]
			internal bool DHEKEJOOHNA()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000145")]
			[Cpp2IlInjected.Address(RVA = "0x1EFD2E0", Offset = "0x1EFBAE0", VA = "0x181EFD2E0")]
			internal void IKNKNLKJOEL(bool x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000146")]
			[Cpp2IlInjected.Address(RVA = "0x1EFDCC0", Offset = "0x1EFC4C0", VA = "0x181EFDCC0")]
			internal bool KNHAPDOBDHI()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000147")]
			[Cpp2IlInjected.Address(RVA = "0x1EFBDE0", Offset = "0x1EFA5E0", VA = "0x181EFBDE0")]
			internal bool ENNAHBAMNHK()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000148")]
			[Cpp2IlInjected.Address(RVA = "0x1EFC490", Offset = "0x1EFAC90", VA = "0x181EFC490")]
			internal bool GHFLEFLEELO()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000149")]
			[Cpp2IlInjected.Address(RVA = "0x1EFD150", Offset = "0x1EFB950", VA = "0x181EFD150")]
			internal bool IGDFKMDOPAO()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600014A")]
			[Cpp2IlInjected.Address(RVA = "0x1EFB680", Offset = "0x1EF9E80", VA = "0x181EFB680")]
			internal bool DFIFFFBHKFK()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600014B")]
			[Cpp2IlInjected.Address(RVA = "0x1EFE640", Offset = "0x1EFCE40", VA = "0x181EFE640")]
			internal bool NDEKHFGJEIF()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600014C")]
			[Cpp2IlInjected.Address(RVA = "0x1EFE790", Offset = "0x1EFCF90", VA = "0x181EFE790")]
			internal bool NINHOJODLLF()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600014D")]
			[Cpp2IlInjected.Address(RVA = "0x1EFC1A0", Offset = "0x1EFA9A0", VA = "0x181EFC1A0")]
			internal bool FMDHDNDEOHO()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600014E")]
			[Cpp2IlInjected.Address(RVA = "0x1EFDEF0", Offset = "0x1EFC6F0", VA = "0x181EFDEF0")]
			internal bool LLOFIGALINB()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600014F")]
			[Cpp2IlInjected.Address(RVA = "0x1EFAC70", Offset = "0x1EF9470", VA = "0x181EFAC70")]
			internal void BHABEDAPNKP(bool x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000150")]
			[Cpp2IlInjected.Address(RVA = "0x1EFE300", Offset = "0x1EFCB00", VA = "0x181EFE300")]
			internal bool MNAJMACOALO()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000151")]
			[Cpp2IlInjected.Address(RVA = "0x1EFBCA0", Offset = "0x1EFA4A0", VA = "0x181EFBCA0")]
			internal bool EIKBMGDBFBJ()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000152")]
			[Cpp2IlInjected.Address(RVA = "0x1EFE4E0", Offset = "0x1EFCCE0", VA = "0x181EFE4E0")]
			internal bool NBHBHPEAKDH()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000153")]
			[Cpp2IlInjected.Address(RVA = "0x1EFE2B0", Offset = "0x1EFCAB0", VA = "0x181EFE2B0")]
			internal bool MMOLPFMCDEN()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000154")]
			[Cpp2IlInjected.Address(RVA = "0x1EFEF50", Offset = "0x1EFD750", VA = "0x181EFEF50")]
			internal bool OMANAIMMBHJ()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000155")]
			[Cpp2IlInjected.Address(RVA = "0x1EFAFA0", Offset = "0x1EF97A0", VA = "0x181EFAFA0")]
			internal bool CDKBIFCNEEI()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000156")]
			[Cpp2IlInjected.Address(RVA = "0x1EFCE70", Offset = "0x1EFB670", VA = "0x181EFCE70")]
			internal bool HOKFHLCNKOK()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000157")]
			[Cpp2IlInjected.Address(RVA = "0x1EFC300", Offset = "0x1EFAB00", VA = "0x181EFC300")]
			internal bool GCHKHOOJODB()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000158")]
			[Cpp2IlInjected.Address(RVA = "0x1EFB3E0", Offset = "0x1EF9BE0", VA = "0x181EFB3E0")]
			internal void DBHBEPELGNF(bool x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000159")]
			[Cpp2IlInjected.Address(RVA = "0x1EFB530", Offset = "0x1EF9D30", VA = "0x181EFB530")]
			internal bool DDLOAAHHELG()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600015A")]
			[Cpp2IlInjected.Address(RVA = "0x1EFBB20", Offset = "0x1EFA320", VA = "0x181EFBB20")]
			internal bool EFBHNLNIJDI()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600015B")]
			[Cpp2IlInjected.Address(RVA = "0x1EFE9C0", Offset = "0x1EFD1C0", VA = "0x181EFE9C0")]
			internal void NPANGADAAPD(bool x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600015C")]
			[Cpp2IlInjected.Address(RVA = "0x1EFC820", Offset = "0x1EFB020", VA = "0x181EFC820")]
			internal bool HAIAOIFLFNC()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600015D")]
			[Cpp2IlInjected.Address(RVA = "0x1EFE8B0", Offset = "0x1EFD0B0", VA = "0x181EFE8B0")]
			internal bool NMMOPBLIHDE()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600015E")]
			[Cpp2IlInjected.Address(RVA = "0x1EFB930", Offset = "0x1EFA130", VA = "0x181EFB930")]
			internal void DJIDBOIDPGI(bool x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600015F")]
			[Cpp2IlInjected.Address(RVA = "0x1EF4A80", Offset = "0x1EF3280", VA = "0x181EF4A80")]
			internal List<CDOFJPCADPP> BCKPOCJBILH(string secondaryLabel)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000160")]
			[Cpp2IlInjected.Address(RVA = "0x1EFE350", Offset = "0x1EFCB50", VA = "0x181EFE350")]
			internal bool MNAMHKOFKJK()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000161")]
			[Cpp2IlInjected.Address(RVA = "0x1EFAD20", Offset = "0x1EF9520", VA = "0x181EFAD20")]
			internal int BLPDOJOEECI()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000162")]
			[Cpp2IlInjected.Address(RVA = "0x1EFC240", Offset = "0x1EFAA40", VA = "0x181EFC240")]
			internal void FMMGJAHALEN(int x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000163")]
			[Cpp2IlInjected.Address(RVA = "0x1EFBA80", Offset = "0x1EFA280", VA = "0x181EFBA80")]
			internal bool ECJAPNHJMGO()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000164")]
			[Cpp2IlInjected.Address(RVA = "0x1EFD870", Offset = "0x1EFC070", VA = "0x181EFD870")]
			internal bool JLPEKDFGPAL()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000165")]
			[Cpp2IlInjected.Address(RVA = "0x1EFC780", Offset = "0x1EFAF80", VA = "0x181EFC780")]
			internal bool GNMMHPNEIHI()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000166")]
			[Cpp2IlInjected.Address(RVA = "0x1EFB1A0", Offset = "0x1EF99A0", VA = "0x181EFB1A0")]
			internal int CJGJEIADCCK()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000167")]
			[Cpp2IlInjected.Address(RVA = "0x1EFB5D0", Offset = "0x1EF9DD0", VA = "0x181EFB5D0")]
			internal void DEELNOFLNCH(int x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000168")]
			[Cpp2IlInjected.Address(RVA = "0x1EFB990", Offset = "0x1EFA190", VA = "0x181EFB990")]
			internal bool DODDFJJKNNA()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000169")]
			[Cpp2IlInjected.Address(RVA = "0x1EFC7D0", Offset = "0x1EFAFD0", VA = "0x181EFC7D0")]
			internal bool GPBFEBICDFG()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600016A")]
			[Cpp2IlInjected.Address(RVA = "0x1EFDE50", Offset = "0x1EFC650", VA = "0x181EFDE50")]
			internal bool LHCKBHIEJBJ()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600016B")]
			[Cpp2IlInjected.Address(RVA = "0x1EFE3A0", Offset = "0x1EFCBA0", VA = "0x181EFE3A0")]
			internal bool MOKNACCFGCE()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600016C")]
			[Cpp2IlInjected.Address(RVA = "0x1EFCE20", Offset = "0x1EFB620", VA = "0x181EFCE20")]
			internal bool HOIOAMBEEND()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600016D")]
			[Cpp2IlInjected.Address(RVA = "0x1EF48A0", Offset = "0x1EF30A0", VA = "0x181EF48A0")]
			internal bool AIHFBNPJIAO()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600016E")]
			[Cpp2IlInjected.Address(RVA = "0x1EFAD70", Offset = "0x1EF9570", VA = "0x181EFAD70")]
			internal string BNBBPKNFANJ()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600016F")]
			[Cpp2IlInjected.Address(RVA = "0x1EFDAE0", Offset = "0x1EFC2E0", VA = "0x181EFDAE0")]
			internal void KDFKLBHJGHE(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000170")]
			[Cpp2IlInjected.Address(RVA = "0x1EFDA40", Offset = "0x1EFC240", VA = "0x181EFDA40")]
			internal int JPGGKMFHJKO()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000171")]
			[Cpp2IlInjected.Address(RVA = "0x1EFB240", Offset = "0x1EF9A40", VA = "0x181EFB240")]
			internal void CMBCNJHNFOG(int x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000172")]
			[Cpp2IlInjected.Address(RVA = "0x1EFE440", Offset = "0x1EFCC40", VA = "0x181EFE440")]
			internal bool NAMMBMEHOLE()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000173")]
			[Cpp2IlInjected.Address(RVA = "0x1EFBE30", Offset = "0x1EFA630", VA = "0x181EFBE30")]
			internal bool EOPNACBNOII()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000174")]
			[Cpp2IlInjected.Address(RVA = "0x1EFD060", Offset = "0x1EFB860", VA = "0x181EFD060")]
			internal bool IDKAPEEANNP()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000175")]
			[Cpp2IlInjected.Address(RVA = "0x1EFBED0", Offset = "0x1EFA6D0", VA = "0x181EFBED0")]
			internal float FCFBLOCGCLA()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000176")]
			[Cpp2IlInjected.Address(RVA = "0x1EFB880", Offset = "0x1EFA080", VA = "0x181EFB880")]
			internal void DIMNGPBAAJC(float x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000177")]
			[Cpp2IlInjected.Address(RVA = "0x1EFACD0", Offset = "0x1EF94D0", VA = "0x181EFACD0")]
			internal bool BLOJFCINEGL()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000178")]
			[Cpp2IlInjected.Address(RVA = "0x1EFB830", Offset = "0x1EFA030", VA = "0x181EFB830")]
			internal bool DIDKLMPOHHJ()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000179")]
			[Cpp2IlInjected.Address(RVA = "0x1EFE1C0", Offset = "0x1EFC9C0", VA = "0x181EFE1C0")]
			internal bool MKPIIPKMNAK()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600017A")]
			[Cpp2IlInjected.Address(RVA = "0x1EFBAD0", Offset = "0x1EFA2D0", VA = "0x181EFBAD0")]
			internal bool EEEMDAIHHHD()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600017B")]
			[Cpp2IlInjected.Address(RVA = "0x1EFDE00", Offset = "0x1EFC600", VA = "0x181EFDE00")]
			internal bool LGPCLCBGLMM()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600017C")]
			[Cpp2IlInjected.Address(RVA = "0x1EF4850", Offset = "0x1EF3050", VA = "0x181EF4850")]
			internal bool AIHBECKNFMO()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600017D")]
			[Cpp2IlInjected.Address(RVA = "0x1EFC9B0", Offset = "0x1EFB1B0", VA = "0x181EFC9B0")]
			internal void HLKCCGKFHNK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600017E")]
			[Cpp2IlInjected.Address(RVA = "0x1EFE210", Offset = "0x1EFCA10", VA = "0x181EFE210")]
			internal string MMMNKEPJBLI()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600017F")]
			[Cpp2IlInjected.Address(RVA = "0x1EFC580", Offset = "0x1EFAD80", VA = "0x181EFC580")]
			internal void GJDEDPACAPI(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000180")]
			[Cpp2IlInjected.Address(RVA = "0x1EFC3A0", Offset = "0x1EFABA0", VA = "0x181EFC3A0")]
			internal bool GEBIGKHLPGA()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000181")]
			[Cpp2IlInjected.Address(RVA = "0x1EFD010", Offset = "0x1EFB810", VA = "0x181EFD010")]
			internal bool IDAFHPFMKCA()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000182")]
			[Cpp2IlInjected.Address(RVA = "0x1EFD730", Offset = "0x1EFBF30", VA = "0x181EFD730")]
			internal bool JLDPIJGDNIA()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000183")]
			[Cpp2IlInjected.Address(RVA = "0x1EFEC30", Offset = "0x1EFD430", VA = "0x181EFEC30")]
			internal void OJJCHDJODNA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000184")]
			[Cpp2IlInjected.Address(RVA = "0x1EFAF00", Offset = "0x1EF9700", VA = "0x181EFAF00")]
			internal bool CBFNDFABJCE()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000185")]
			[Cpp2IlInjected.Address(RVA = "0x1EFEAD0", Offset = "0x1EFD2D0", VA = "0x181EFEAD0")]
			internal bool OBCIBLDJEOK()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000186")]
			[Cpp2IlInjected.Address(RVA = "0x1EFEA80", Offset = "0x1EFD280", VA = "0x181EFEA80")]
			internal bool OAPHEGLBDHE()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000187")]
			[Cpp2IlInjected.Address(RVA = "0x1EFF400", Offset = "0x1EFDC00", VA = "0x181EFF400")]
			internal bool PNKMCDCCHII()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000188")]
			[Cpp2IlInjected.Address(RVA = "0x1EFD590", Offset = "0x1EFBD90", VA = "0x181EFD590")]
			internal void JDIPJAPEOFI(bool x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000189")]
			[Cpp2IlInjected.Address(RVA = "0x1EFDD10", Offset = "0x1EFC510", VA = "0x181EFDD10")]
			internal bool KOEKFAFFLNF()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600018A")]
			[Cpp2IlInjected.Address(RVA = "0x1EFC4E0", Offset = "0x1EFACE0", VA = "0x181EFC4E0")]
			internal bool GIAOKGIOKEK()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600018B")]
			[Cpp2IlInjected.Address(RVA = "0x1EFB630", Offset = "0x1EF9E30", VA = "0x181EFB630")]
			internal bool DEKLFMOEILJ()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600018C")]
			[Cpp2IlInjected.Address(RVA = "0x1EFC060", Offset = "0x1EFA860", VA = "0x181EFC060")]
			internal bool FJEGAIPMGKG()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600018D")]
			[Cpp2IlInjected.Address(RVA = "0x1EFF100", Offset = "0x1EFD900", VA = "0x181EFF100")]
			internal void OOJIMBKAGAH(bool x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600018E")]
			[Cpp2IlInjected.Address(RVA = "0x1EFD240", Offset = "0x1EFBA40", VA = "0x181EFD240")]
			internal bool IKEEFKAGNHH()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600018F")]
			[Cpp2IlInjected.Address(RVA = "0x1EFD290", Offset = "0x1EFBA90", VA = "0x181EFD290")]
			internal bool IKMGMKLAFDL()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000190")]
			[Cpp2IlInjected.Address(RVA = "0x1EFB0E0", Offset = "0x1EF98E0", VA = "0x181EFB0E0")]
			internal bool CHEFIMMBLGE()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000191")]
			[Cpp2IlInjected.Address(RVA = "0x1EFAFF0", Offset = "0x1EF97F0", VA = "0x181EFAFF0")]
			internal bool CDOFJCEHEDD()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000192")]
			[Cpp2IlInjected.Address(RVA = "0x1EFC100", Offset = "0x1EFA900", VA = "0x181EFC100")]
			internal int FJOKHIHFEMG()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000193")]
			[Cpp2IlInjected.Address(RVA = "0x1EFBC10", Offset = "0x1EFA410", VA = "0x181EFBC10")]
			internal void EHLPEFEBGCE(object x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000194")]
			[Cpp2IlInjected.Address(RVA = "0x1EFD1F0", Offset = "0x1EFB9F0", VA = "0x181EFD1F0")]
			internal bool IIELEEOCPAH()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000195")]
			[Cpp2IlInjected.Address(RVA = "0x1EFBD40", Offset = "0x1EFA540", VA = "0x181EFBD40")]
			internal bool EMKPFOCEGBB()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000196")]
			[Cpp2IlInjected.Address(RVA = "0x1EFD1A0", Offset = "0x1EFB9A0", VA = "0x181EFD1A0")]
			internal int IGLMPMADMJJ()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000197")]
			[Cpp2IlInjected.Address(RVA = "0x1EFEEF0", Offset = "0x1EFD6F0", VA = "0x181EFEEF0")]
			internal void OLBOGNEAAGL(int x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000198")]
			[Cpp2IlInjected.Address(RVA = "0x1EFE030", Offset = "0x1EFC830", VA = "0x181EFE030")]
			internal bool MEBAMNIDMDC()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000199")]
			[Cpp2IlInjected.Address(RVA = "0x1EF4800", Offset = "0x1EF3000", VA = "0x181EF4800")]
			internal bool AHEKKODAKFF()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600019A")]
			[Cpp2IlInjected.Address(RVA = "0x1EFBCF0", Offset = "0x1EFA4F0", VA = "0x181EFBCF0")]
			internal int EJLCGAHFHMO()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x600019B")]
			[Cpp2IlInjected.Address(RVA = "0x1EFCF60", Offset = "0x1EFB760", VA = "0x181EFCF60")]
			internal void IBJCAGDCJJG(int x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600019C")]
			[Cpp2IlInjected.Address(RVA = "0x1EFF1B0", Offset = "0x1EFD9B0", VA = "0x181EFF1B0")]
			internal bool PBPBCHIDJEJ()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600019D")]
			[Cpp2IlInjected.Address(RVA = "0x1EFBB70", Offset = "0x1EFA370", VA = "0x181EFBB70")]
			internal bool EFKEELGEGFO()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600019E")]
			[Cpp2IlInjected.Address(RVA = "0x1EFC010", Offset = "0x1EFA810", VA = "0x181EFC010")]
			internal bool FIFONCNHAAL()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600019F")]
			[Cpp2IlInjected.Address(RVA = "0x1EFB7E0", Offset = "0x1EF9FE0", VA = "0x181EFB7E0")]
			internal int DICKGKPNGGK()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60001A0")]
			[Cpp2IlInjected.Address(RVA = "0x1EFDB50", Offset = "0x1EFC350", VA = "0x181EFDB50")]
			internal void KEAKEAGFNDL(int x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A1")]
			[Cpp2IlInjected.Address(RVA = "0x1EFF160", Offset = "0x1EFD960", VA = "0x181EFF160")]
			internal bool OPMJLGAAJMI()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001A2")]
			[Cpp2IlInjected.Address(RVA = "0x1EFD780", Offset = "0x1EFBF80", VA = "0x181EFD780")]
			internal bool JLEBBGPCGHN()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001A3")]
			[Cpp2IlInjected.Address(RVA = "0x1EFD920", Offset = "0x1EFC120", VA = "0x181EFD920")]
			internal bool JOAJJPBPHHJ()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001A4")]
			[Cpp2IlInjected.Address(RVA = "0x1EFF090", Offset = "0x1EFD890", VA = "0x181EFF090")]
			internal object OOAEBFJIGLM()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001A5")]
			[Cpp2IlInjected.Address(RVA = "0x1EFF370", Offset = "0x1EFDB70", VA = "0x181EFF370")]
			internal void PKIECPBMHCE(object x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A6")]
			[Cpp2IlInjected.Address(RVA = "0x1EFC960", Offset = "0x1EFB160", VA = "0x181EFC960")]
			internal bool HKIMOCPMKEH()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001A7")]
			[Cpp2IlInjected.Address(RVA = "0x1EFF200", Offset = "0x1EFDA00", VA = "0x181EFF200")]
			internal bool PDBKFBHCOJK()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001A8")]
			[Cpp2IlInjected.Address(RVA = "0x1EFCDB0", Offset = "0x1EFB5B0", VA = "0x181EFCDB0")]
			internal object HNKPDMFGLAL()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001A9")]
			[Cpp2IlInjected.Address(RVA = "0x1EFF000", Offset = "0x1EFD800", VA = "0x181EFF000")]
			internal void ONJIJCPNLNK(object x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001AA")]
			[Cpp2IlInjected.Address(RVA = "0x1EFD340", Offset = "0x1EFBB40", VA = "0x181EFD340")]
			internal bool ILEJJDEBCPJ()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001AB")]
			[Cpp2IlInjected.Address(RVA = "0x1EFD690", Offset = "0x1EFBE90", VA = "0x181EFD690")]
			internal int JEPHACLEPEN()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60001AC")]
			[Cpp2IlInjected.Address(RVA = "0x1EFE690", Offset = "0x1EFCE90", VA = "0x181EFE690")]
			internal void NFFAPIOEHFG(int x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001AD")]
			[Cpp2IlInjected.Address(RVA = "0x1EFDD60", Offset = "0x1EFC560", VA = "0x181EFDD60")]
			internal bool LCHDCKBGNHN()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001AE")]
			[Cpp2IlInjected.Address(RVA = "0x1EFE6F0", Offset = "0x1EFCEF0", VA = "0x181EFE6F0")]
			internal bool NGEAPNJBCNK()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001AF")]
			[Cpp2IlInjected.Address(RVA = "0x1EFB2A0", Offset = "0x1EF9AA0", VA = "0x181EFB2A0")]
			internal bool COLEAHLIGDC()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001B0")]
			[Cpp2IlInjected.Address(RVA = "0x1EFC530", Offset = "0x1EFAD30", VA = "0x181EFC530")]
			internal int GIJEFEJPGKC()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60001B1")]
			[Cpp2IlInjected.Address(RVA = "0x1EFC2A0", Offset = "0x1EFAAA0", VA = "0x181EFC2A0")]
			internal void FODFPHEBMOD(int x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001B2")]
			[Cpp2IlInjected.Address(RVA = "0x1EFE970", Offset = "0x1EFD170", VA = "0x181EFE970")]
			internal bool NOLNCKGKMEE()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001B3")]
			[Cpp2IlInjected.Address(RVA = "0x1EFB1F0", Offset = "0x1EF99F0", VA = "0x181EFB1F0")]
			internal bool CLCDLEKKEIE()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001B4")]
			[Cpp2IlInjected.Address(RVA = "0x1EFE0D0", Offset = "0x1EFC8D0", VA = "0x181EFE0D0")]
			internal bool MGDICDPBPHM()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001B5")]
			[Cpp2IlInjected.Address(RVA = "0x1EFABD0", Offset = "0x1EF93D0", VA = "0x181EFABD0")]
			internal float BGCDAJMGMAE()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x60001B6")]
			[Cpp2IlInjected.Address(RVA = "0x1EFD970", Offset = "0x1EFC170", VA = "0x181EFD970")]
			internal void JOOFKMGLIHI(float x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001B7")]
			[Cpp2IlInjected.Address(RVA = "0x1EFB9E0", Offset = "0x1EFA1E0", VA = "0x181EFB9E0")]
			internal bool DOMPPIGFHDE()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001B8")]
			[Cpp2IlInjected.Address(RVA = "0x1EFE740", Offset = "0x1EFCF40", VA = "0x181EFE740")]
			internal bool NGFIFIPODKJ()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001B9")]
			[Cpp2IlInjected.Address(RVA = "0x1EFDA90", Offset = "0x1EFC290", VA = "0x181EFDA90")]
			internal bool KBKLPPFGCNE()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001BA")]
			[Cpp2IlInjected.Address(RVA = "0x1EFBF20", Offset = "0x1EFA720", VA = "0x181EFBF20")]
			internal float FHBAGKIOCCM()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x60001BB")]
			[Cpp2IlInjected.Address(RVA = "0x1EFD8C0", Offset = "0x1EFC0C0", VA = "0x181EFD8C0")]
			internal void JMNDPDKDAMP(float x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001BC")]
			[Cpp2IlInjected.Address(RVA = "0x1EFC730", Offset = "0x1EFAF30", VA = "0x181EFC730")]
			internal bool GNDFDDOEBOL()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001BD")]
			[Cpp2IlInjected.Address(RVA = "0x1EFB340", Offset = "0x1EF9B40", VA = "0x181EFB340")]
			internal bool DAEJHLBEIPB()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001BE")]
			[Cpp2IlInjected.Address(RVA = "0x1EFDEA0", Offset = "0x1EFC6A0", VA = "0x181EFDEA0")]
			internal string LHLEEIEGDAE()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001BF")]
			[Cpp2IlInjected.Address(RVA = "0x1EFD480", Offset = "0x1EFBC80", VA = "0x181EFD480")]
			internal void IOMHBPNIGOL(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C0")]
			[Cpp2IlInjected.Address(RVA = "0x1EF48F0", Offset = "0x1EF30F0", VA = "0x181EF48F0")]
			internal bool AKIAICBPIAJ(string x)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001C1")]
			[Cpp2IlInjected.Address(RVA = "0x1EFAF50", Offset = "0x1EF9750", VA = "0x181EFAF50")]
			internal bool CCCAPNKGJMB()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001C2")]
			[Cpp2IlInjected.Address(RVA = "0x1EFB8E0", Offset = "0x1EFA0E0", VA = "0x181EFB8E0")]
			internal bool DJGALHEOHBI()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001C3")]
			[Cpp2IlInjected.Address(RVA = "0x1EFC3F0", Offset = "0x1EFABF0", VA = "0x181EFC3F0")]
			internal bool GEFODAAJINE()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001C4")]
			[Cpp2IlInjected.Address(RVA = "0x1EFDBB0", Offset = "0x1EFC3B0", VA = "0x181EFDBB0")]
			internal string KIDKABJMFFD()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001C5")]
			[Cpp2IlInjected.Address(RVA = "0x1EFE900", Offset = "0x1EFD100", VA = "0x181EFE900")]
			internal void NNGFEBDENPG(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C6")]
			[Cpp2IlInjected.Address(RVA = "0x1EFC440", Offset = "0x1EFAC40", VA = "0x181EFC440")]
			internal bool GGMJHOANBNP(string x)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001C7")]
			[Cpp2IlInjected.Address(RVA = "0x1EFCEC0", Offset = "0x1EFB6C0", VA = "0x181EFCEC0")]
			internal bool IBAELEBAALD()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001C8")]
			[Cpp2IlInjected.Address(RVA = "0x1EFCFC0", Offset = "0x1EFB7C0", VA = "0x181EFCFC0")]
			internal bool ICEMELDLAJK()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001C9")]
			[Cpp2IlInjected.Address(RVA = "0x1EFD5F0", Offset = "0x1EFBDF0", VA = "0x181EFD5F0")]
			internal bool JDNBIPGEGCM()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001CA")]
			[Cpp2IlInjected.Address(RVA = "0x1EFB390", Offset = "0x1EF9B90", VA = "0x181EFB390")]
			internal string DBEMJFMOBAL()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001CB")]
			[Cpp2IlInjected.Address(RVA = "0x1EFF300", Offset = "0x1EFDB00", VA = "0x181EFF300")]
			internal void PIPBNNPHALP(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001CC")]
			[Cpp2IlInjected.Address(RVA = "0x1EFEBE0", Offset = "0x1EFD3E0", VA = "0x181EFEBE0")]
			internal bool OFNIIIBNBPP(string x)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001CD")]
			[Cpp2IlInjected.Address(RVA = "0x1EFB4E0", Offset = "0x1EF9CE0", VA = "0x181EFB4E0")]
			internal bool DCKKMDLHMLM()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001CE")]
			[Cpp2IlInjected.Address(RVA = "0x1EFC350", Offset = "0x1EFAB50", VA = "0x181EFC350")]
			internal bool GDCCFILMMFM()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001CF")]
			[Cpp2IlInjected.Address(RVA = "0x1EFB440", Offset = "0x1EF9C40", VA = "0x181EFB440")]
			internal bool DBHFLKOCAMJ()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001D0")]
			[Cpp2IlInjected.Address(RVA = "0x1EFB740", Offset = "0x1EF9F40", VA = "0x181EFB740")]
			internal string DGMCCDNKMNE()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001D1")]
			[Cpp2IlInjected.Address(RVA = "0x1EFE840", Offset = "0x1EFD040", VA = "0x181EFE840")]
			internal void NKHNAHGENAC(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001D2")]
			[Cpp2IlInjected.Address(RVA = "0x1EFD4F0", Offset = "0x1EFBCF0", VA = "0x181EFD4F0")]
			internal bool JACGIOBBPPJ(string x)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001D3")]
			[Cpp2IlInjected.Address(RVA = "0x1EFD0B0", Offset = "0x1EFB8B0", VA = "0x181EFD0B0")]
			internal bool IECFEDKAPCB()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001D4")]
			[Cpp2IlInjected.Address(RVA = "0x1EFE530", Offset = "0x1EFCD30", VA = "0x181EFE530")]
			internal bool NBHGLPGJDPK()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001D5")]
			[Cpp2IlInjected.Address(RVA = "0x1EFE120", Offset = "0x1EFC920", VA = "0x181EFE120")]
			internal bool MINLDHAIMBN()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001D6")]
			[Cpp2IlInjected.Address(RVA = "0x1EFDC70", Offset = "0x1EFC470", VA = "0x181EFDC70")]
			internal string KMIEKICHAEM()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001D7")]
			[Cpp2IlInjected.Address(RVA = "0x1EFEB70", Offset = "0x1EFD370", VA = "0x181EFEB70")]
			internal void OCFBCECEMMN(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001D8")]
			[Cpp2IlInjected.Address(RVA = "0x1EFF2B0", Offset = "0x1EFDAB0", VA = "0x181EFF2B0")]
			internal bool PHJLICAGEEA(string x)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001D9")]
			[Cpp2IlInjected.Address(RVA = "0x1EFAE10", Offset = "0x1EF9610", VA = "0x181EFAE10")]
			internal bool BPHAPDFGNPB()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001DA")]
			[Cpp2IlInjected.Address(RVA = "0x1EFE3F0", Offset = "0x1EFCBF0", VA = "0x181EFE3F0")]
			internal bool MONOGDMNFAD()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001DB")]
			[Cpp2IlInjected.Address(RVA = "0x1EFE170", Offset = "0x1EFC970", VA = "0x181EFE170")]
			internal bool MJDNBBEEMDF()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001DC")]
			[Cpp2IlInjected.Address(RVA = "0x1EFC910", Offset = "0x1EFB110", VA = "0x181EFC910")]
			internal string HFHMFPGLOBB()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001DD")]
			[Cpp2IlInjected.Address(RVA = "0x1EF4A10", Offset = "0x1EF3210", VA = "0x181EF4A10")]
			internal void APBGOOHLJJN(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001DE")]
			[Cpp2IlInjected.Address(RVA = "0x1EF47B0", Offset = "0x1EF2FB0", VA = "0x181EF47B0")]
			internal bool ACFFKIMMCNC(string x)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001DF")]
			[Cpp2IlInjected.Address(RVA = "0x1EFD640", Offset = "0x1EFBE40", VA = "0x181EFD640")]
			internal bool JEBLONCPOOI()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001E0")]
			[Cpp2IlInjected.Address(RVA = "0x1EFDF40", Offset = "0x1EFC740", VA = "0x181EFDF40")]
			internal bool LMDHBOOEJFI()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001E1")]
			[Cpp2IlInjected.Address(RVA = "0x1EFCD60", Offset = "0x1EFB560", VA = "0x181EFCD60")]
			internal bool HLMBAPCKIFE()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001E2")]
			[Cpp2IlInjected.Address(RVA = "0x1EFD430", Offset = "0x1EFBC30", VA = "0x181EFD430")]
			internal string IOJLLOAEJJG()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001E3")]
			[Cpp2IlInjected.Address(RVA = "0x1EFDC00", Offset = "0x1EFC400", VA = "0x181EFDC00")]
			internal void KJLCDGLGMFC(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001E4")]
			[Cpp2IlInjected.Address(RVA = "0x1EFC1F0", Offset = "0x1EFA9F0", VA = "0x181EFC1F0")]
			internal bool FMFODOOCIPC(string x)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001E5")]
			[Cpp2IlInjected.Address(RVA = "0x1EFAE60", Offset = "0x1EF9660", VA = "0x181EFAE60")]
			internal bool CAABFKANEHE()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001E6")]
			[Cpp2IlInjected.Address(RVA = "0x1EFEB20", Offset = "0x1EFD320", VA = "0x181EFEB20")]
			internal bool OBDEEENJIFK()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001E7")]
			[Cpp2IlInjected.Address(RVA = "0x1EFCF10", Offset = "0x1EFB710", VA = "0x181EFCF10")]
			internal bool IBFBNIMPABM()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001E8")]
			[Cpp2IlInjected.Address(RVA = "0x1EFE5F0", Offset = "0x1EFCDF0", VA = "0x181EFE5F0")]
			internal string NCEEAAOACPO()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001E9")]
			[Cpp2IlInjected.Address(RVA = "0x1EFB6D0", Offset = "0x1EF9ED0", VA = "0x181EFB6D0")]
			internal void DGEABOJMEJM(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001EA")]
			[Cpp2IlInjected.Address(RVA = "0x1EFAB10", Offset = "0x1EF9310", VA = "0x181EFAB10")]
			internal bool BFGJJNKBBCE(string x)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001EB")]
			[Cpp2IlInjected.Address(RVA = "0x1EFF450", Offset = "0x1EFDC50", VA = "0x181EFF450")]
			internal bool PONAOOEONHM()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001EC")]
			[Cpp2IlInjected.Address(RVA = "0x1EFBFC0", Offset = "0x1EFA7C0", VA = "0x181EFBFC0")]
			internal bool FHMIKGIMHPL()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001ED")]
			[Cpp2IlInjected.Address(RVA = "0x1EFC690", Offset = "0x1EFAE90", VA = "0x181EFC690")]
			internal bool GMMBHANDAIM()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001EE")]
			[Cpp2IlInjected.Address(RVA = "0x1EFC8C0", Offset = "0x1EFB0C0", VA = "0x181EFC8C0")]
			internal string HCCKKCJFCAH()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001EF")]
			[Cpp2IlInjected.Address(RVA = "0x1EFD9D0", Offset = "0x1EFC1D0", VA = "0x181EFD9D0")]
			internal void JOPOAPIGGMM(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001F0")]
			[Cpp2IlInjected.Address(RVA = "0x1EFBA30", Offset = "0x1EFA230", VA = "0x181EFBA30")]
			internal bool DPKCPLOLHLE(string x)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001F1")]
			[Cpp2IlInjected.Address(RVA = "0x1EFADC0", Offset = "0x1EF95C0", VA = "0x181EFADC0")]
			internal bool BNFNLGKPDHL()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001F2")]
			[Cpp2IlInjected.Address(RVA = "0x1EFD390", Offset = "0x1EFBB90", VA = "0x181EFD390")]
			internal bool IMGOCAOLJGG()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001F3")]
			[Cpp2IlInjected.Address(RVA = "0x1EFB2F0", Offset = "0x1EF9AF0", VA = "0x181EFB2F0")]
			internal bool CPBJAGDGKOO()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001F4")]
			[Cpp2IlInjected.Address(RVA = "0x1EFAEB0", Offset = "0x1EF96B0", VA = "0x181EFAEB0")]
			internal string CAEPJINBFLD()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001F5")]
			[Cpp2IlInjected.Address(RVA = "0x1EFB130", Offset = "0x1EF9930", VA = "0x181EFB130")]
			internal void CHPMCEAPKBM(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001F6")]
			[Cpp2IlInjected.Address(RVA = "0x1EFB040", Offset = "0x1EF9840", VA = "0x181EFB040")]
			internal bool CEGEJHFFFPB()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001F7")]
			[Cpp2IlInjected.Address(RVA = "0x1EFD540", Offset = "0x1EFBD40", VA = "0x181EFD540")]
			internal bool JAHEPHOGDPH()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001F8")]
			[Cpp2IlInjected.Address(RVA = "0x1EFC640", Offset = "0x1EFAE40", VA = "0x181EFC640")]
			internal bool GLCCCMPBJED()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001F9")]
			[Cpp2IlInjected.Address(RVA = "0x1EFE260", Offset = "0x1EFCA60", VA = "0x181EFE260")]
			internal string MMOGKHAEDNJ()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001FA")]
			[Cpp2IlInjected.Address(RVA = "0x1EF4940", Offset = "0x1EF3140", VA = "0x181EF4940")]
			internal void ALELPJJDCLN(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001FB")]
			[Cpp2IlInjected.Address(RVA = "0x1EFAC20", Offset = "0x1EF9420", VA = "0x181EFAC20")]
			internal bool BGMAOGIAIFE()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001FC")]
			[Cpp2IlInjected.Address(RVA = "0x1EFBF70", Offset = "0x1EFA770", VA = "0x181EFBF70")]
			internal bool FHFLFCLPFLL()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001FD")]
			[Cpp2IlInjected.Address(RVA = "0x1EFDDB0", Offset = "0x1EFC5B0", VA = "0x181EFDDB0")]
			internal bool LFCCGBKLGNK()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001FE")]
			[Cpp2IlInjected.Address(RVA = "0x1EFC870", Offset = "0x1EFB070", VA = "0x181EFC870")]
			internal string HBCLODEFHKB()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001FF")]
			[Cpp2IlInjected.Address(RVA = "0x1EFE580", Offset = "0x1EFCD80", VA = "0x181EFE580")]
			internal void NBIGFJHBFCP(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000200")]
			[Cpp2IlInjected.Address(RVA = "0x1EFBBC0", Offset = "0x1EFA3C0", VA = "0x181EFBBC0")]
			internal bool EFLFBPEDLLB()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000201")]
			[Cpp2IlInjected.Address(RVA = "0x1EFC0B0", Offset = "0x1EFA8B0", VA = "0x181EFC0B0")]
			internal bool FJICPIEOOMC()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000202")]
			[Cpp2IlInjected.Address(RVA = "0x1EFE490", Offset = "0x1EFCC90", VA = "0x181EFE490")]
			internal bool NBEFEMOFHGI()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000203")]
			[Cpp2IlInjected.Address(RVA = "0x1EFD820", Offset = "0x1EFC020", VA = "0x181EFD820")]
			internal string JLOAJHBJNHP()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000204")]
			[Cpp2IlInjected.Address(RVA = "0x1EFAB60", Offset = "0x1EF9360", VA = "0x181EFAB60")]
			internal void BFPCHJKLHKK(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000205")]
			[Cpp2IlInjected.Address(RVA = "0x1EFD3E0", Offset = "0x1EFBBE0", VA = "0x181EFD3E0")]
			internal bool IMKOMMNHOJM()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000206")]
			[Cpp2IlInjected.Address(RVA = "0x1EFD100", Offset = "0x1EFB900", VA = "0x181EFD100")]
			internal bool IEIDBOOGMMC(string x)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000207")]
			[Cpp2IlInjected.Address(RVA = "0x1EFDFE0", Offset = "0x1EFC7E0", VA = "0x181EFDFE0")]
			internal float LMKFIPDOFKJ()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000208")]
			[Cpp2IlInjected.Address(RVA = "0x1EFEFA0", Offset = "0x1EFD7A0", VA = "0x181EFEFA0")]
			internal void OMCKJEPLBGK(float x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000209")]
			[Cpp2IlInjected.Address(RVA = "0x1EFC150", Offset = "0x1EFA950", VA = "0x181EFC150")]
			internal bool FKEFIJPANHH()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600020A")]
			[Cpp2IlInjected.Address(RVA = "0x1EFBE80", Offset = "0x1EFA680", VA = "0x181EFBE80")]
			internal bool EPHAFMACGFG()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600020B")]
			[Cpp2IlInjected.Address(RVA = "0x1EFC6E0", Offset = "0x1EFAEE0", VA = "0x181EFC6E0")]
			internal bool GMPCLJIBPNG()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600020C")]
			[Cpp2IlInjected.Address(RVA = "0x1EFD6E0", Offset = "0x1EFBEE0", VA = "0x181EFD6E0")]
			internal int JHHPFEAFNDM()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x600020D")]
			[Cpp2IlInjected.Address(RVA = "0x1EF49B0", Offset = "0x1EF31B0", VA = "0x181EF49B0")]
			internal void AOBILOLCBIA(int x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600020E")]
			[Cpp2IlInjected.Address(RVA = "0x1EFB580", Offset = "0x1EF9D80", VA = "0x181EFB580")]
			internal bool DDNAIJPMEBM()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600020F")]
			[Cpp2IlInjected.Address(RVA = "0x1EFAAC0", Offset = "0x1EF92C0", VA = "0x181EFAAC0")]
			internal bool BFBAIAJPDLF()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000210")]
			[Cpp2IlInjected.Address(RVA = "0x1EFE080", Offset = "0x1EFC880", VA = "0x181EFE080")]
			internal bool MGDEDCJOKEC()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000054")]
		[CompilerGenerated]
		private sealed class DFJMKLBFNIC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000ED")]
			public string secondaryLabel;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000EE")]
			public LNGKDGGJAMF CS$<>8__locals1;

			[Cpp2IlInjected.Token(Token = "0x6000211")]
			[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
			public DFJMKLBFNIC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000212")]
			[Cpp2IlInjected.Address(RVA = "0x1EEA030", Offset = "0x1EE8830", VA = "0x181EEA030")]
			internal void DEEPBPKFJGL()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000055")]
		[CompilerGenerated]
		private sealed class EHPKACIHPNH
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000EF")]
			public char[] swizzleChars;

			[Cpp2IlInjected.Token(Token = "0x6000213")]
			[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
			public EHPKACIHPNH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000214")]
			[Cpp2IlInjected.Address(RVA = "0x1EEB460", Offset = "0x1EE9C60", VA = "0x181EEB460")]
			internal bool CBLCIDJNGFJ(char c)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		private readonly FKPHKCLJCBL IJHFKCEGPLA;

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x1EEDFD0", Offset = "0x1EEC7D0", VA = "0x181EEDFD0")]
		public FNPJHIJBNOO(BBIGJEMLFFM POJGEMMMHAN, CNIJIKKGDDI DDLCNKGIKEK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x1EEC270", Offset = "0x1EEAA70", VA = "0x181EEC270", Slot = "119")]
		protected override void ACMFEFOOMLB(EJLAIGMFDKK BADOLCEECJG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000057")]
	public sealed class EKLDKEEIONA : KBILGNIMNAC<IIMHFPNNPFB>
	{
		[Cpp2IlInjected.Token(Token = "0x2000058")]
		[CompilerGenerated]
		private sealed class IIHBNLMFEBD
		{
			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x2000059")]
			private struct <<BuildConfigMenuInternal>b__1>d : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400011A")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x400011B")]
				public AsyncVoidMethodBuilder <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x400011C")]
				public IIHBNLMFEBD <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x400011D")]
				public string value;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x400011E")]
				private TaskAwaiter<bool> <>u__1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
				[Cpp2IlInjected.Token(Token = "0x400011F")]
				private TaskAwaiter<MEKCEIEFNPI<KNDENJDHONE, MNGIPKBLGNG>> <>u__2;

				[Cpp2IlInjected.Token(Token = "0x6000246")]
				[Cpp2IlInjected.Address(RVA = "0x1F21300", Offset = "0x1F1FB00", VA = "0x181F21300", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000247")]
				[Cpp2IlInjected.Address(RVA = "0x9A4BE0", Offset = "0x9A33E0", VA = "0x1809A4BE0", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000118")]
			public EKLDKEEIONA <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000119")]
			public AOONLOOENIF nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x6000241")]
			[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
			public IIHBNLMFEBD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000242")]
			[Cpp2IlInjected.Address(RVA = "0x1F161E0", Offset = "0x1F149E0", VA = "0x181F161E0")]
			internal string LMFIIKHIMLH()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000243")]
			[Cpp2IlInjected.Address(RVA = "0x1F16230", Offset = "0x1F14A30", VA = "0x181F16230")]
			[AsyncStateMachine(typeof(<<BuildConfigMenuInternal>b__1>d))]
			internal void PFCOBPBKFAK(string value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000244")]
			[Cpp2IlInjected.Address(RVA = "0x1F16190", Offset = "0x1F14990", VA = "0x181F16190")]
			internal int HNPBNHGAOHN()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000245")]
			[Cpp2IlInjected.Address(RVA = "0x1F16100", Offset = "0x1F14900", VA = "0x181F16100")]
			internal void HDLNADONHGI(int value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public override NodeVisualizationKey PJOIFALPHGK
		{
			[Cpp2IlInjected.Token(Token = "0x600023F")]
			[Cpp2IlInjected.Address(RVA = "0x8AF8D0", Offset = "0x8AE0D0", VA = "0x1808AF8D0", Slot = "90")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600023E")]
		[Cpp2IlInjected.Address(RVA = "0x1F10060", Offset = "0x1F0E860", VA = "0x181F10060")]
		public EKLDKEEIONA(BBIGJEMLFFM POJGEMMMHAN, IIMHFPNNPFB LHMMDMHNIJC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000240")]
		[Cpp2IlInjected.Address(RVA = "0x1F0FD10", Offset = "0x1F0E510", VA = "0x181F0FD10", Slot = "119")]
		protected override void ACMFEFOOMLB(EJLAIGMFDKK BADOLCEECJG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005A")]
	public sealed class KHJPANDONEM : KBILGNIMNAC<JFPFMCDFNHG>
	{
		[Cpp2IlInjected.Token(Token = "0x200005B")]
		[CompilerGenerated]
		private sealed class IKHMEKOMNLI
		{
			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x200005C")]
			private struct <<BuildConfigMenuInternal>b__1>d : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000122")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x4000123")]
				public AsyncVoidMethodBuilder <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x4000124")]
				public IKHMEKOMNLI <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x4000125")]
				public string value;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x4000126")]
				private TaskAwaiter<bool> <>u__1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
				[Cpp2IlInjected.Token(Token = "0x4000127")]
				private TaskAwaiter<MEKCEIEFNPI<KNDENJDHONE, MNGIPKBLGNG>> <>u__2;

				[Cpp2IlInjected.Token(Token = "0x600025B")]
				[Cpp2IlInjected.Address(RVA = "0x1F21610", Offset = "0x1F1FE10", VA = "0x181F21610", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600025C")]
				[Cpp2IlInjected.Address(RVA = "0x9A4BE0", Offset = "0x9A33E0", VA = "0x1809A4BE0", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x200005D")]
			private struct <<BuildConfigMenuInternal>b__5>d : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000128")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x4000129")]
				public AsyncVoidMethodBuilder <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x400012A")]
				public IKHMEKOMNLI <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x400012B")]
				public string value;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x400012C")]
				private TaskAwaiter<bool> <>u__1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
				[Cpp2IlInjected.Token(Token = "0x400012D")]
				private TaskAwaiter<MEKCEIEFNPI<KNDENJDHONE, MNGIPKBLGNG>> <>u__2;

				[Cpp2IlInjected.Token(Token = "0x600025D")]
				[Cpp2IlInjected.Address(RVA = "0x1F21950", Offset = "0x1F20150", VA = "0x181F21950", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600025E")]
				[Cpp2IlInjected.Address(RVA = "0x9A4BE0", Offset = "0x9A33E0", VA = "0x1809A4BE0", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000120")]
			public KHJPANDONEM <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000121")]
			public AOONLOOENIF nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x600024B")]
			[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
			public IKHMEKOMNLI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600024C")]
			[Cpp2IlInjected.Address(RVA = "0x1F16700", Offset = "0x1F14F00", VA = "0x181F16700")]
			internal string LMFIIKHIMLH()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600024D")]
			[Cpp2IlInjected.Address(RVA = "0x1F16960", Offset = "0x1F15160", VA = "0x181F16960")]
			[AsyncStateMachine(typeof(<<BuildConfigMenuInternal>b__1>d))]
			internal void PFCOBPBKFAK(string value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600024E")]
			[Cpp2IlInjected.Address(RVA = "0x1F16640", Offset = "0x1F14E40", VA = "0x181F16640")]
			internal int HNPBNHGAOHN()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x600024F")]
			[Cpp2IlInjected.Address(RVA = "0x1F16500", Offset = "0x1F14D00", VA = "0x181F16500")]
			internal void HDLNADONHGI(int colorIndex)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000250")]
			[Cpp2IlInjected.Address(RVA = "0x1F16460", Offset = "0x1F14C60", VA = "0x181F16460")]
			internal string EMLJHLHJDJF()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000251")]
			[Cpp2IlInjected.Address(RVA = "0x1F16390", Offset = "0x1F14B90", VA = "0x181F16390")]
			[AsyncStateMachine(typeof(<<BuildConfigMenuInternal>b__5>d))]
			internal void DCEDNMKAINM(string value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000252")]
			[Cpp2IlInjected.Address(RVA = "0x1F167E0", Offset = "0x1F14FE0", VA = "0x181F167E0")]
			internal bool OACPCMEGBFK()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000253")]
			[Cpp2IlInjected.Address(RVA = "0x1F16830", Offset = "0x1F15030", VA = "0x181F16830")]
			internal void OIFMFDKHAFM(bool value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000254")]
			[Cpp2IlInjected.Address(RVA = "0x1F165F0", Offset = "0x1F14DF0", VA = "0x181F165F0")]
			internal bool HKGCHHDCAOL()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000255")]
			[Cpp2IlInjected.Address(RVA = "0x1F16300", Offset = "0x1F14B00", VA = "0x181F16300")]
			internal void CGLNLPKELMO(bool value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000256")]
			[Cpp2IlInjected.Address(RVA = "0x1F164B0", Offset = "0x1F14CB0", VA = "0x181F164B0")]
			internal float GKLELMAPCJF()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000257")]
			[Cpp2IlInjected.Address(RVA = "0x1F16750", Offset = "0x1F14F50", VA = "0x181F16750")]
			internal void NKAJLMDLLFL(float value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000258")]
			[Cpp2IlInjected.Address(RVA = "0x1F16590", Offset = "0x1F14D90", VA = "0x181F16590")]
			internal int HFAMGEBEPIP()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000259")]
			[Cpp2IlInjected.Address(RVA = "0x1F168C0", Offset = "0x1F150C0", VA = "0x181F168C0")]
			internal void PDNJFFILHJA(int value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600025A")]
			[Cpp2IlInjected.Address(RVA = "0x1F16690", Offset = "0x1F14E90", VA = "0x181F16690")]
			internal bool JLFACIPAGBI()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public override NodeVisualizationKey PJOIFALPHGK
		{
			[Cpp2IlInjected.Token(Token = "0x6000249")]
			[Cpp2IlInjected.Address(RVA = "0x8AF8D0", Offset = "0x8AE0D0", VA = "0x1808AF8D0", Slot = "90")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000248")]
		[Cpp2IlInjected.Address(RVA = "0x1F1DAA0", Offset = "0x1F1C2A0", VA = "0x181F1DAA0")]
		public KHJPANDONEM(BBIGJEMLFFM POJGEMMMHAN, JFPFMCDFNHG DDLCNKGIKEK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024A")]
		[Cpp2IlInjected.Address(RVA = "0x1F1D060", Offset = "0x1F1B860", VA = "0x181F1D060", Slot = "119")]
		protected override void ACMFEFOOMLB(EJLAIGMFDKK BADOLCEECJG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005E")]
	public sealed class OOLNEHKHPBP : KBILGNIMNAC<AFJLOPPOHLP>
	{
		[Cpp2IlInjected.Token(Token = "0x200005F")]
		[CompilerGenerated]
		private sealed class ODOIMAAOHAD
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400012E")]
			public AOONLOOENIF nodeAdapterDeps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400012F")]
			public OOLNEHKHPBP <>4__this;

			[Cpp2IlInjected.Token(Token = "0x6000262")]
			[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
			public ODOIMAAOHAD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000263")]
			[Cpp2IlInjected.Address(RVA = "0x1F207B0", Offset = "0x1F1EFB0", VA = "0x181F207B0")]
			internal Dictionary<string, FOFCIDGPHKD> LMFIIKHIMLH()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000264")]
			[Cpp2IlInjected.Address(RVA = "0x1F20850", Offset = "0x1F1F050", VA = "0x181F20850")]
			internal int PFCOBPBKFAK()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000265")]
			[Cpp2IlInjected.Address(RVA = "0x1F20690", Offset = "0x1F1EE90", VA = "0x181F20690")]
			internal void HNPBNHGAOHN(int value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000266")]
			[Cpp2IlInjected.Address(RVA = "0x1F20610", Offset = "0x1F1EE10", VA = "0x181F20610")]
			internal bool HDLNADONHGI()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public override NodeVisualizationKey PJOIFALPHGK
		{
			[Cpp2IlInjected.Token(Token = "0x6000260")]
			[Cpp2IlInjected.Address(RVA = "0x8AF8D0", Offset = "0x8AE0D0", VA = "0x1808AF8D0", Slot = "90")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600025F")]
		[Cpp2IlInjected.Address(RVA = "0x1F20C50", Offset = "0x1F1F450", VA = "0x181F20C50")]
		public OOLNEHKHPBP(BBIGJEMLFFM POJGEMMMHAN, AFJLOPPOHLP LHMMDMHNIJC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000261")]
		[Cpp2IlInjected.Address(RVA = "0x1F209B0", Offset = "0x1F1F1B0", VA = "0x181F209B0", Slot = "119")]
		protected override void ACMFEFOOMLB(EJLAIGMFDKK BADOLCEECJG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000060")]
	public sealed class AGEDEKFFLKE : KBILGNIMNAC<KCLPOIONJBD>
	{
		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public override NodeVisualizationKey PJOIFALPHGK
		{
			[Cpp2IlInjected.Token(Token = "0x6000268")]
			[Cpp2IlInjected.Address(RVA = "0x8AF8D0", Offset = "0x8AE0D0", VA = "0x1808AF8D0", Slot = "90")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(RVA = "0x1F066A0", Offset = "0x1F04EA0", VA = "0x181F066A0")]
		public AGEDEKFFLKE(BBIGJEMLFFM POJGEMMMHAN, KCLPOIONJBD LHMMDMHNIJC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000269")]
		[Cpp2IlInjected.Address(RVA = "0x1F06490", Offset = "0x1F04C90", VA = "0x181F06490", Slot = "119")]
		protected override void ACMFEFOOMLB(EJLAIGMFDKK BADOLCEECJG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026A")]
		[Cpp2IlInjected.Address(RVA = "0x1F06580", Offset = "0x1F04D80", VA = "0x181F06580")]
		[CompilerGenerated]
		private void JIFNIBICFFF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000061")]
	private sealed class NNKELHIIOOK : GBJGPINBBDD<PNKDGDAGKBP>
	{
		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public override bool APBBAPOGAKA
		{
			[Cpp2IlInjected.Token(Token = "0x600026B")]
			[Cpp2IlInjected.Address(RVA = "0x85D960", Offset = "0x85C160", VA = "0x18085D960", Slot = "92")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		public override bool BPEAHFJKELM
		{
			[Cpp2IlInjected.Token(Token = "0x600026C")]
			[Cpp2IlInjected.Address(RVA = "0x1F20420", Offset = "0x1F1EC20", VA = "0x181F20420", Slot = "116")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public override NodeVisualizationKey PJOIFALPHGK
		{
			[Cpp2IlInjected.Token(Token = "0x600026D")]
			[Cpp2IlInjected.Address(RVA = "0x8B7280", Offset = "0x8B5A80", VA = "0x1808B7280", Slot = "90")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600026E")]
		[Cpp2IlInjected.Address(RVA = "0x1F203C0", Offset = "0x1F1EBC0", VA = "0x181F203C0")]
		public NNKELHIIOOK(BBIGJEMLFFM POJGEMMMHAN, PNKDGDAGKBP DDLCNKGIKEK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026F")]
		[Cpp2IlInjected.Address(RVA = "0x843530", Offset = "0x841D30", VA = "0x180843530", Slot = "119")]
		protected override void ACMFEFOOMLB(EJLAIGMFDKK BADOLCEECJG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000062")]
	private sealed class OAAFAGKJDFP : KBILGNIMNAC<DBCBIGIMOJE>
	{
		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		public override NodeVisualizationKey PJOIFALPHGK
		{
			[Cpp2IlInjected.Token(Token = "0x6000270")]
			[Cpp2IlInjected.Address(RVA = "0x8B0F10", Offset = "0x8AF710", VA = "0x1808B0F10", Slot = "90")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000271")]
		[Cpp2IlInjected.Address(RVA = "0x1F20540", Offset = "0x1F1ED40", VA = "0x181F20540")]
		public OAAFAGKJDFP(BBIGJEMLFFM POJGEMMMHAN, DBCBIGIMOJE DDLCNKGIKEK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(RVA = "0x843530", Offset = "0x841D30", VA = "0x180843530", Slot = "119")]
		protected override void ACMFEFOOMLB(EJLAIGMFDKK BADOLCEECJG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000063")]
	private sealed class MBIJEFGGAJM : KBILGNIMNAC<OFDCMOLDKKE>
	{
		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public override NodeVisualizationKey PJOIFALPHGK
		{
			[Cpp2IlInjected.Token(Token = "0x6000273")]
			[Cpp2IlInjected.Address(RVA = "0x8AD710", Offset = "0x8ABF10", VA = "0x1808AD710", Slot = "90")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000274")]
		[Cpp2IlInjected.Address(RVA = "0x1F1ECB0", Offset = "0x1F1D4B0", VA = "0x181F1ECB0")]
		public MBIJEFGGAJM(BBIGJEMLFFM POJGEMMMHAN, OFDCMOLDKKE DDLCNKGIKEK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000275")]
		[Cpp2IlInjected.Address(RVA = "0x85D960", Offset = "0x85C160", VA = "0x18085D960", Slot = "111")]
		protected override bool ICFHIJMEOPM(KPFGDODNFBO<PKDEPFAFNML> KCJMKIMEENL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000276")]
		[Cpp2IlInjected.Address(RVA = "0x843530", Offset = "0x841D30", VA = "0x180843530", Slot = "119")]
		protected override void ACMFEFOOMLB(EJLAIGMFDKK BADOLCEECJG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000064")]
	private sealed class LGGJLKHODJG : KBILGNIMNAC<FCLJBFBBDDI>
	{
		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		public override NodeVisualizationKey PJOIFALPHGK
		{
			[Cpp2IlInjected.Token(Token = "0x6000277")]
			[Cpp2IlInjected.Address(RVA = "0x8C4E00", Offset = "0x8C3600", VA = "0x1808C4E00", Slot = "90")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public override bool NPPHJEFJIBI
		{
			[Cpp2IlInjected.Token(Token = "0x6000278")]
			[Cpp2IlInjected.Address(RVA = "0x1F1E080", Offset = "0x1F1C880", VA = "0x181F1E080", Slot = "91")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		protected override bool LHGLLIAHKHJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000279")]
			[Cpp2IlInjected.Address(RVA = "0x85D960", Offset = "0x85C160", VA = "0x18085D960", Slot = "89")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(RVA = "0x1F1E010", Offset = "0x1F1C810", VA = "0x181F1E010")]
		public LGGJLKHODJG(BBIGJEMLFFM POJGEMMMHAN, FCLJBFBBDDI DDLCNKGIKEK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(RVA = "0x843530", Offset = "0x841D30", VA = "0x180843530", Slot = "119")]
		protected override void ACMFEFOOMLB(EJLAIGMFDKK BADOLCEECJG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000065")]
	private sealed class DCEGGGJPPIO : KBILGNIMNAC<JEBMOIFKPJE>
	{
		[Cpp2IlInjected.Token(Token = "0x17000040")]
		public override NodeVisualizationKey PJOIFALPHGK
		{
			[Cpp2IlInjected.Token(Token = "0x600027C")]
			[Cpp2IlInjected.Address(RVA = "0x8BEAF0", Offset = "0x8BD2F0", VA = "0x1808BEAF0", Slot = "90")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		public override bool NPPHJEFJIBI
		{
			[Cpp2IlInjected.Token(Token = "0x600027D")]
			[Cpp2IlInjected.Address(RVA = "0x1F0DB90", Offset = "0x1F0C390", VA = "0x181F0DB90", Slot = "91")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		protected override bool LHGLLIAHKHJ
		{
			[Cpp2IlInjected.Token(Token = "0x600027E")]
			[Cpp2IlInjected.Address(RVA = "0x85D960", Offset = "0x85C160", VA = "0x18085D960", Slot = "89")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0x1F0DB20", Offset = "0x1F0C320", VA = "0x181F0DB20")]
		public DCEGGGJPPIO(BBIGJEMLFFM POJGEMMMHAN, JEBMOIFKPJE DDLCNKGIKEK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0x843530", Offset = "0x841D30", VA = "0x180843530", Slot = "119")]
		protected override void ACMFEFOOMLB(EJLAIGMFDKK BADOLCEECJG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000066")]
	public sealed class EPJBCABNNPC : LJJAHFFBFNG<MDLAEMAGBKM>
	{
		[Cpp2IlInjected.Token(Token = "0x2000067")]
		[CompilerGenerated]
		private sealed class POKGPGEDGFF
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000130")]
			public EPJBCABNNPC <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000131")]
			public AOONLOOENIF nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x6000283")]
			[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
			public POKGPGEDGFF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000284")]
			[Cpp2IlInjected.Address(RVA = "0x1F20F70", Offset = "0x1F1F770", VA = "0x181F20F70")]
			internal float HGEEOBBKBOI()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000285")]
			[Cpp2IlInjected.Address(RVA = "0x1F20ED0", Offset = "0x1F1F6D0", VA = "0x181F20ED0")]
			internal void GCBJNFGANHE(float value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0x1F10520", Offset = "0x1F0ED20", VA = "0x181F10520")]
		public EPJBCABNNPC(BBIGJEMLFFM POJGEMMMHAN, MDLAEMAGBKM LHMMDMHNIJC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0x1F102A0", Offset = "0x1F0EAA0", VA = "0x181F102A0", Slot = "125")]
		protected override void DDNCMAKEJJM(EJLAIGMFDKK BADOLCEECJG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000068")]
	public sealed class DLONBNHGGEF : KBILGNIMNAC<PELCGEJFPHN>
	{
		[Cpp2IlInjected.Token(Token = "0x2000069")]
		[CompilerGenerated]
		private sealed class DIFECBKMIJC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000132")]
			public DLONBNHGGEF <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000133")]
			public AOONLOOENIF nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x6000288")]
			[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
			public DIFECBKMIJC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000289")]
			[Cpp2IlInjected.Address(RVA = "0x1F0E370", Offset = "0x1F0CB70", VA = "0x181F0E370")]
			internal bool LMFIIKHIMLH()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600028A")]
			[Cpp2IlInjected.Address(RVA = "0x1F0E3C0", Offset = "0x1F0CBC0", VA = "0x181F0E3C0")]
			internal void PFCOBPBKFAK(bool value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000286")]
		[Cpp2IlInjected.Address(RVA = "0x1F0EB40", Offset = "0x1F0D340", VA = "0x181F0EB40")]
		public DLONBNHGGEF(BBIGJEMLFFM POJGEMMMHAN, PELCGEJFPHN LHMMDMHNIJC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000287")]
		[Cpp2IlInjected.Address(RVA = "0x1F0E890", Offset = "0x1F0D090", VA = "0x181F0E890", Slot = "119")]
		protected override void ACMFEFOOMLB(EJLAIGMFDKK BADOLCEECJG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006A")]
	public sealed class DMHBKOABEHN : KBILGNIMNAC<BEIENJMONHG>
	{
		[Cpp2IlInjected.Token(Token = "0x200006B")]
		[CompilerGenerated]
		private sealed class DGILFDCKPGN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000134")]
			public AOONLOOENIF nodeAdapterDeps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000135")]
			public DMHBKOABEHN <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000136")]
			public Predicate<Guid> <>9__7;

			[Cpp2IlInjected.Token(Token = "0x600028D")]
			[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
			public DGILFDCKPGN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600028E")]
			[Cpp2IlInjected.Address(RVA = "0x1F0DE50", Offset = "0x1F0C650", VA = "0x181F0DE50")]
			internal object LMFIIKHIMLH()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600028F")]
			[Cpp2IlInjected.Address(RVA = "0x1F0E0A0", Offset = "0x1F0C8A0", VA = "0x181F0E0A0")]
			internal bool OIFMFDKHAFM(Guid id)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000290")]
			[Cpp2IlInjected.Address(RVA = "0x1F0E120", Offset = "0x1F0C920", VA = "0x181F0E120")]
			internal void PFCOBPBKFAK(object value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000291")]
			[Cpp2IlInjected.Address(RVA = "0x1F0DCF0", Offset = "0x1F0C4F0", VA = "0x181F0DCF0")]
			internal string HNPBNHGAOHN(object key)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000292")]
			[Cpp2IlInjected.Address(RVA = "0x1F0DCA0", Offset = "0x1F0C4A0", VA = "0x181F0DCA0")]
			internal IReadOnlyList<object> HDLNADONHGI()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000293")]
			[Cpp2IlInjected.Address(RVA = "0x1F0DC30", Offset = "0x1F0C430", VA = "0x181F0DC30")]
			internal bool EMLJHLHJDJF()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000294")]
			[Cpp2IlInjected.Address(RVA = "0x1F0DBE0", Offset = "0x1F0C3E0", VA = "0x181F0DBE0")]
			internal bool DCEDNMKAINM()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000295")]
			[Cpp2IlInjected.Address(RVA = "0x1F0DF80", Offset = "0x1F0C780", VA = "0x181F0DF80")]
			internal void OACPCMEGBFK(bool value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(RVA = "0x1F0F860", Offset = "0x1F0E060", VA = "0x181F0F860")]
		public DMHBKOABEHN(BBIGJEMLFFM POJGEMMMHAN, BEIENJMONHG LHMMDMHNIJC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028C")]
		[Cpp2IlInjected.Address(RVA = "0x1F0F060", Offset = "0x1F0D860", VA = "0x181F0F060", Slot = "119")]
		protected override void ACMFEFOOMLB(EJLAIGMFDKK BADOLCEECJG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006C")]
	public sealed class DPBAHBKEDBB : JLPEDCDJKCE<DAEGHOCEHAL>
	{
		[Cpp2IlInjected.Token(Token = "0x17000043")]
		public override NodeVisualizationKey PJOIFALPHGK
		{
			[Cpp2IlInjected.Token(Token = "0x6000296")]
			[Cpp2IlInjected.Address(RVA = "0xA58970", Offset = "0xA57170", VA = "0x180A58970", Slot = "90")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000297")]
		[Cpp2IlInjected.Address(RVA = "0x1F0F8D0", Offset = "0x1F0E0D0", VA = "0x181F0F8D0")]
		public DPBAHBKEDBB(BBIGJEMLFFM POJGEMMMHAN, DAEGHOCEHAL DDLCNKGIKEK)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006D")]
	public sealed class HAIKJAJKEDI : LJJAHFFBFNG<GHJDMPGOFFL>
	{
		[Cpp2IlInjected.Token(Token = "0x200006E")]
		[CompilerGenerated]
		private sealed class JEDKEIHOEPK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000137")]
			public HAIKJAJKEDI <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000138")]
			public AOONLOOENIF nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x600029A")]
			[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
			public JEDKEIHOEPK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600029B")]
			[Cpp2IlInjected.Address(RVA = "0x1F1B760", Offset = "0x1F19F60", VA = "0x181F1B760")]
			internal int HGEEOBBKBOI()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x600029C")]
			[Cpp2IlInjected.Address(RVA = "0x1F1B6C0", Offset = "0x1F19EC0", VA = "0x181F1B6C0")]
			internal void GCBJNFGANHE(int value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000298")]
		[Cpp2IlInjected.Address(RVA = "0x1F130A0", Offset = "0x1F118A0", VA = "0x181F130A0")]
		public HAIKJAJKEDI(BBIGJEMLFFM POJGEMMMHAN, GHJDMPGOFFL LHMMDMHNIJC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000299")]
		[Cpp2IlInjected.Address(RVA = "0x1F12E10", Offset = "0x1F11610", VA = "0x181F12E10", Slot = "125")]
		protected override void DDNCMAKEJJM(EJLAIGMFDKK BADOLCEECJG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006F")]
	public sealed class JIKDCFNDAOL : KBILGNIMNAC<PEMNAJKAGIL>
	{
		[Cpp2IlInjected.Token(Token = "0x2000070")]
		[CompilerGenerated]
		private sealed class NNNIPMAOGNJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000139")]
			public JIKDCFNDAOL <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400013A")]
			public AOONLOOENIF nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x600029F")]
			[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
			public NNNIPMAOGNJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002A0")]
			[Cpp2IlInjected.Address(RVA = "0x1F20460", Offset = "0x1F1EC60", VA = "0x181F20460")]
			internal bool LMFIIKHIMLH()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60002A1")]
			[Cpp2IlInjected.Address(RVA = "0x1F204B0", Offset = "0x1F1ECB0", VA = "0x181F204B0")]
			internal void PFCOBPBKFAK(bool value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600029D")]
		[Cpp2IlInjected.Address(RVA = "0x1F1C120", Offset = "0x1F1A920", VA = "0x181F1C120")]
		public JIKDCFNDAOL(BBIGJEMLFFM POJGEMMMHAN, PEMNAJKAGIL LHMMDMHNIJC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029E")]
		[Cpp2IlInjected.Address(RVA = "0x1F1BF40", Offset = "0x1F1A740", VA = "0x181F1BF40", Slot = "119")]
		protected override void ACMFEFOOMLB(EJLAIGMFDKK BADOLCEECJG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000071")]
	public sealed class MNENJHBHEPG : KBILGNIMNAC<FOCILIKFJEM>
	{
		[Cpp2IlInjected.Token(Token = "0x2000072")]
		[CompilerGenerated]
		private sealed class LNCMGCEFOMM
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400013B")]
			public MNENJHBHEPG <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400013C")]
			public AOONLOOENIF nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x60002A4")]
			[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
			public LNCMGCEFOMM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002A5")]
			[Cpp2IlInjected.Address(RVA = "0x1F1EB70", Offset = "0x1F1D370", VA = "0x181F1EB70")]
			internal bool LMFIIKHIMLH()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60002A6")]
			[Cpp2IlInjected.Address(RVA = "0x1F1EBC0", Offset = "0x1F1D3C0", VA = "0x181F1EBC0")]
			internal void PFCOBPBKFAK(bool value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002A2")]
		[Cpp2IlInjected.Address(RVA = "0x1F1F2C0", Offset = "0x1F1DAC0", VA = "0x181F1F2C0")]
		public MNENJHBHEPG(BBIGJEMLFFM POJGEMMMHAN, FOCILIKFJEM LHMMDMHNIJC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A3")]
		[Cpp2IlInjected.Address(RVA = "0x1F1F0E0", Offset = "0x1F1D8E0", VA = "0x181F1F0E0", Slot = "119")]
		protected override void ACMFEFOOMLB(EJLAIGMFDKK BADOLCEECJG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000073")]
	public sealed class CEFHKPJOLJG : KBILGNIMNAC<CGLOEJFAMCL>
	{
		[Cpp2IlInjected.Token(Token = "0x2000074")]
		[CompilerGenerated]
		private sealed class EPHLJFGJIHN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400013D")]
			public CEFHKPJOLJG <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400013E")]
			public AOONLOOENIF nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x60002A9")]
			[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
			public EPHLJFGJIHN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002AA")]
			[Cpp2IlInjected.Address(RVA = "0x1F101C0", Offset = "0x1F0E9C0", VA = "0x181F101C0")]
			internal int LMFIIKHIMLH()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60002AB")]
			[Cpp2IlInjected.Address(RVA = "0x1F10210", Offset = "0x1F0EA10", VA = "0x181F10210")]
			internal void PFCOBPBKFAK(int value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002A7")]
		[Cpp2IlInjected.Address(RVA = "0x1F0DA00", Offset = "0x1F0C200", VA = "0x181F0DA00")]
		public CEFHKPJOLJG(BBIGJEMLFFM POJGEMMMHAN, CGLOEJFAMCL LHMMDMHNIJC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A8")]
		[Cpp2IlInjected.Address(RVA = "0x1F0D7A0", Offset = "0x1F0BFA0", VA = "0x181F0D7A0", Slot = "119")]
		protected override void ACMFEFOOMLB(EJLAIGMFDKK BADOLCEECJG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000075")]
	public sealed class OCACNHANDND : LEBEFFPHJII<LPIDGIMKFHP>
	{
		[Cpp2IlInjected.Token(Token = "0x17000044")]
		public override JLGGLBLNBGM BGHMEIKPHJP
		{
			[Cpp2IlInjected.Token(Token = "0x60002AD")]
			[Cpp2IlInjected.Address(RVA = "0x8C4CA0", Offset = "0x8C34A0", VA = "0x1808C4CA0", Slot = "125")]
			get
			{
				return default(JLGGLBLNBGM);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002AC")]
		[Cpp2IlInjected.Address(RVA = "0x1F205B0", Offset = "0x1F1EDB0", VA = "0x181F205B0")]
		public OCACNHANDND(BBIGJEMLFFM POJGEMMMHAN, LPIDGIMKFHP LHMMDMHNIJC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000076")]
	public class PDFFDFFBFGF : KBILGNIMNAC<LAMDOCKGMNE>
	{
		[Cpp2IlInjected.Token(Token = "0x60002AE")]
		[Cpp2IlInjected.Address(RVA = "0x1F11840", Offset = "0x1F10040", VA = "0x181F11840")]
		public PDFFDFFBFGF(BBIGJEMLFFM POJGEMMMHAN, LAMDOCKGMNE DDLCNKGIKEK)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000077")]
	public abstract class KBILGNIMNAC<TNode> : NOABPNGHFKH, IDisposable where TNode : notnull, LAMDOCKGMNE
	{
		[Cpp2IlInjected.Token(Token = "0x2000078")]
		protected readonly struct NJKDGOPKHBN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000156")]
			public readonly string GBCCKLCIAKJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000157")]
			public readonly string IKFGNIABECD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000158")]
			public readonly string KGEINOBJCAC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000159")]
			public readonly MBJMCCAGDNI PHKNFLIJFAP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400015A")]
			public readonly HBOPFHOKDCJ BFHGELPEHBD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400015B")]
			public readonly Func<string, bool> CFBIEILAPCL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400015C")]
			public readonly string KOCLLLMLOLE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400015D")]
			public readonly Func<string, bool> PDLDJDNFDMA;

			[Cpp2IlInjected.Token(Token = "0x600032A")]
			[Cpp2IlInjected.Address(RVA = "0x4454BA0", Offset = "0x44533A0", VA = "0x184454BA0")]
			public NJKDGOPKHBN(string OHOCGBOJFEG, string KDHHAGPFBJN, string JAAKKNOJBMM, MBJMCCAGDNI GHHIMIDNCBN, HBOPFHOKDCJ NPKHHNEHNCN, Func<string, bool> DJLCKHAFLEJ, string EAHOOFNGENA, Func<string, bool> LJJJIBLCDJN)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000079")]
		[CompilerGenerated]
		private sealed class FMIBLNBAPIJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400015E")]
			public KBILGNIMNAC<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400015F")]
			public BBIGJEMLFFM circuitsManager;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000160")]
			public TNode node;

			[Cpp2IlInjected.Token(Token = "0x600032B")]
			[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
			public FMIBLNBAPIJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600032C")]
			[Cpp2IlInjected.Address(RVA = "0x3B04E60", Offset = "0x3B03660", VA = "0x183B04E60")]
			internal BPNJKEICMLI ECCKFHBADBK(MPKOJNBPMJD portGroup, int id)
			{
				return null;
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200007A")]
		[CompilerGenerated]
		private struct FNECMDAIDIJ : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000161")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000162")]
			public AsyncVoidMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000163")]
			public KBILGNIMNAC<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000164")]
			public int newColor;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000165")]
			private TaskAwaiter<MEKCEIEFNPI<KNDENJDHONE, MNGIPKBLGNG>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600032D")]
			[Cpp2IlInjected.Address(RVA = "0x3B0A490", Offset = "0x3B08C90", VA = "0x183B0A490", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600032E")]
			[Cpp2IlInjected.Address(RVA = "0x9A4BE0", Offset = "0x9A33E0", VA = "0x1809A4BE0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200007B")]
		[CompilerGenerated]
		private struct EOIFJDMEIKF : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000166")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000167")]
			public AsyncTaskMethodBuilder<MEKCEIEFNPI<KNDENJDHONE, MNGIPKBLGNG>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000168")]
			public KBILGNIMNAC<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000169")]
			public BAPMBLOBIME? localPosition;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400016A")]
			public FLOGLJPGMHF? localRotation;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400016B")]
			private TaskAwaiter<MEKCEIEFNPI<KNDENJDHONE, MNGIPKBLGNG>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600032F")]
			[Cpp2IlInjected.Address(RVA = "0x376ED90", Offset = "0x376D590", VA = "0x18376ED90", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000330")]
			[Cpp2IlInjected.Address(RVA = "0x376F040", Offset = "0x376D840", VA = "0x18376F040", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200007C")]
		[CompilerGenerated]
		private sealed class IGEPMHJPPGK
		{
			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x200007D")]
			private struct <<BuildStringChangeMenuInternal>b__2>d : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000173")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000174")]
				public AsyncVoidMethodBuilder <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000175")]
				public IGEPMHJPPGK <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000176")]
				private TaskAwaiter<bool> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x6000335")]
				[Cpp2IlInjected.Address(RVA = "0x34A7D40", Offset = "0x34A6540", VA = "0x1834A7D40", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000336")]
				[Cpp2IlInjected.Address(RVA = "0x9A4BE0", Offset = "0x9A33E0", VA = "0x1809A4BE0", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400016C")]
			public string newName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400016D")]
			public Func<string, bool> submitValidator;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400016E")]
			public AOONLOOENIF nodeAdapterDeps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400016F")]
			public KBILGNIMNAC<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000170")]
			public Func<string> getConfigurableName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000171")]
			public EJLAIGMFDKK configure;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000172")]
			public Action<string> setConfigurableName;

			[Cpp2IlInjected.Token(Token = "0x6000331")]
			[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
			public IGEPMHJPPGK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000332")]
			[Cpp2IlInjected.Address(RVA = "0x846800", Offset = "0x845000", VA = "0x180846800")]
			internal string DPIBHANBPLG()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000333")]
			[Cpp2IlInjected.Address(RVA = "0x8467F0", Offset = "0x844FF0", VA = "0x1808467F0")]
			internal void HDJJCDJEPEK(string value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000334")]
			[Cpp2IlInjected.Address(RVA = "0x3D8A5E0", Offset = "0x3D88DE0", VA = "0x183D8A5E0")]
			[AsyncStateMachine(typeof(KBILGNIMNAC<>.IGEPMHJPPGK.<<BuildStringChangeMenuInternal>b__2>d))]
			internal void DLHPMKKHDEL()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200007E")]
		[CompilerGenerated]
		private sealed class PINEOMFIAJK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000177")]
			public AOONLOOENIF nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x6000337")]
			[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
			public PINEOMFIAJK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000338")]
			[Cpp2IlInjected.Address(RVA = "0x4662690", Offset = "0x4660E90", VA = "0x184662690")]
			internal bool JBGDLDLMCOO(string text)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000339")]
			[Cpp2IlInjected.Address(RVA = "0x4662770", Offset = "0x4660F70", VA = "0x184662770")]
			internal bool LONJNPFOCHB(string text)
			{
				return default(bool);
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200007F")]
		[CompilerGenerated]
		private struct NNIELMHEMNL : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000178")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000179")]
			public AsyncTaskMethodBuilder<MEKCEIEFNPI<KNDENJDHONE, MNGIPKBLGNG>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400017A")]
			public KBILGNIMNAC<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400017B")]
			public string newName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400017C")]
			private TaskAwaiter<MEKCEIEFNPI<KNDENJDHONE, MNGIPKBLGNG>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600033A")]
			[Cpp2IlInjected.Address(RVA = "0x4464840", Offset = "0x4463040", VA = "0x184464840", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600033B")]
			[Cpp2IlInjected.Address(RVA = "0x4464BD0", Offset = "0x44633D0", VA = "0x184464BD0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400013F")]
		private readonly BBIGJEMLFFM NOLFNCBBDEO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000140")]
		private readonly bool PDAAOANLHNL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000141")]
		private CCPKKOHIOOB<PKDEPFAFNML, BPNJKEICMLI> OMLKAOGPLGO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000142")]
		private CCPKKOHIOOB<PKDEPFAFNML, FMHAPHMJOBC> AJJAAIBFIID;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400014A")]
		private List<Action> AFLPBHFJLIO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000152")]
		[CompilerGenerated]
		private Action<KPFGDODNFBO<PKDEPFAFNML>>? HEKMEOINGIN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000153")]
		[CompilerGenerated]
		private Action<KPFGDODNFBO<PKDEPFAFNML>, FMHAPHMJOBC>? GKLGOPJLAEB;

		[Cpp2IlInjected.Token(Token = "0x17000045")]
		protected AOONLOOENIF EIGMCAJIMEO
		{
			[Cpp2IlInjected.Token(Token = "0x60002AF")]
			[Cpp2IlInjected.Address(RVA = "0x4077290", Offset = "0x4075A90", VA = "0x184077290")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000046")]
		protected TNode LCCLDDFOOHK
		{
			[Cpp2IlInjected.Token(Token = "0x60002B3")]
			[Cpp2IlInjected.Address(RVA = "0x847480", Offset = "0x845C80", VA = "0x180847480")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000047")]
		public EOFGJNJAJLP<HACDMEHACNO> HKFDKMOAJCB
		{
			[Cpp2IlInjected.Token(Token = "0x60002B4")]
			[Cpp2IlInjected.Address(RVA = "0xABF500", Offset = "0xABDD00", VA = "0x180ABF500", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(EOFGJNJAJLP<HACDMEHACNO>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000048")]
		public KPFGDODNFBO<DNFJKNPMMBK> DCAJDKMPBIF
		{
			[Cpp2IlInjected.Token(Token = "0x60002B5")]
			[Cpp2IlInjected.Address(RVA = "0x407CAA0", Offset = "0x407B2A0", VA = "0x18407CAA0", Slot = "6")]
			get
			{
				return default(KPFGDODNFBO<DNFJKNPMMBK>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000049")]
		public object CLFKIENLAIL
		{
			[Cpp2IlInjected.Token(Token = "0x60002B6")]
			[Cpp2IlInjected.Address(RVA = "0x37BEA60", Offset = "0x37BD260", VA = "0x1837BEA60", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004A")]
		public virtual bool FKHNLAEBFJD
		{
			[Cpp2IlInjected.Token(Token = "0x60002B7")]
			[Cpp2IlInjected.Address(RVA = "0x85D960", Offset = "0x85C160", VA = "0x18085D960", Slot = "88")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004B")]
		public int BJDFJONKEEK
		{
			[Cpp2IlInjected.Token(Token = "0x60002B8")]
			[Cpp2IlInjected.Address(RVA = "0x407C6D0", Offset = "0x407AED0", VA = "0x18407C6D0", Slot = "8")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004C")]
		public HLAHBLIOIOJ HNEOCFLACOH
		{
			[Cpp2IlInjected.Token(Token = "0x60002BA")]
			[Cpp2IlInjected.Address(RVA = "0x407C670", Offset = "0x407AE70", VA = "0x18407C670", Slot = "10")]
			get
			{
				return default(HLAHBLIOIOJ);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004D")]
		public string OOOIKOKAHPM
		{
			[Cpp2IlInjected.Token(Token = "0x60002BB")]
			[Cpp2IlInjected.Address(RVA = "0x407CC60", Offset = "0x407B460", VA = "0x18407CC60", Slot = "11")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004E")]
		protected virtual bool LHGLLIAHKHJ
		{
			[Cpp2IlInjected.Token(Token = "0x60002BC")]
			[Cpp2IlInjected.Address(RVA = "0x88B320", Offset = "0x889B20", VA = "0x18088B320", Slot = "89")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004F")]
		public virtual NodeVisualizationKey PJOIFALPHGK
		{
			[Cpp2IlInjected.Token(Token = "0x60002BD")]
			[Cpp2IlInjected.Address(RVA = "0x843540", Offset = "0x841D40", VA = "0x180843540", Slot = "90")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000050")]
		public KPFGDODNFBO<JNDEINOEBGK> CMBBELMNOOK
		{
			[Cpp2IlInjected.Token(Token = "0x60002BE")]
			[Cpp2IlInjected.Address(RVA = "0x8E24D0", Offset = "0x8E0CD0", VA = "0x1808E24D0", Slot = "13")]
			[CompilerGenerated]
			get
			{
				return default(KPFGDODNFBO<JNDEINOEBGK>);
			}
			[Cpp2IlInjected.Token(Token = "0x60002BF")]
			[Cpp2IlInjected.Address(RVA = "0xAC66E0", Offset = "0xAC4EE0", VA = "0x180AC66E0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000051")]
		public virtual bool NPPHJEFJIBI
		{
			[Cpp2IlInjected.Token(Token = "0x60002C0")]
			[Cpp2IlInjected.Address(RVA = "0x88B320", Offset = "0x889B20", VA = "0x18088B320", Slot = "91")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000052")]
		public virtual bool APBBAPOGAKA
		{
			[Cpp2IlInjected.Token(Token = "0x60002C1")]
			[Cpp2IlInjected.Address(RVA = "0x88B320", Offset = "0x889B20", VA = "0x18088B320", Slot = "92")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000053")]
		public virtual HMFCDHFFFJA OGMFLAMNNOI
		{
			[Cpp2IlInjected.Token(Token = "0x60002C2")]
			[Cpp2IlInjected.Address(RVA = "0xA48C10", Offset = "0xA47410", VA = "0x180A48C10", Slot = "93")]
			get
			{
				return default(HMFCDHFFFJA);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000054")]
		public bool JIKNOLJKBIC
		{
			[Cpp2IlInjected.Token(Token = "0x60002C3")]
			[Cpp2IlInjected.Address(RVA = "0x407C3F0", Offset = "0x407ABF0", VA = "0x18407C3F0", Slot = "17")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000055")]
		public bool DKMFNABICBF
		{
			[Cpp2IlInjected.Token(Token = "0x60002C4")]
			[Cpp2IlInjected.Address(RVA = "0x407C460", Offset = "0x407AC60", VA = "0x18407C460", Slot = "18")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000056")]
		public bool JPEKDEIIOJE
		{
			[Cpp2IlInjected.Token(Token = "0x60002C5")]
			[Cpp2IlInjected.Address(RVA = "0x407C4D0", Offset = "0x407ACD0", VA = "0x18407C4D0", Slot = "19")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000057")]
		public int GGCKDJDKCBD
		{
			[Cpp2IlInjected.Token(Token = "0x60002C6")]
			[Cpp2IlInjected.Address(RVA = "0x407CA40", Offset = "0x407B240", VA = "0x18407CA40", Slot = "20")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000058")]
		public bool HEBBLOMMOBO
		{
			[Cpp2IlInjected.Token(Token = "0x60002C7")]
			[Cpp2IlInjected.Address(RVA = "0x407C860", Offset = "0x407B060", VA = "0x18407C860", Slot = "21")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000059")]
		public bool CIOONHNDLBH
		{
			[Cpp2IlInjected.Token(Token = "0x60002C8")]
			[Cpp2IlInjected.Address(RVA = "0x407C590", Offset = "0x407AD90", VA = "0x18407C590", Slot = "22")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005A")]
		public bool MHHAAJPIIFA
		{
			[Cpp2IlInjected.Token(Token = "0x60002C9")]
			[Cpp2IlInjected.Address(RVA = "0xC12CB0", Offset = "0xC114B0", VA = "0x180C12CB0", Slot = "23")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60002CA")]
			[Cpp2IlInjected.Address(RVA = "0xC12C60", Offset = "0xC11460", VA = "0x180C12C60")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005B")]
		public virtual bool FIGBFCEMHAL
		{
			[Cpp2IlInjected.Token(Token = "0x60002CB")]
			[Cpp2IlInjected.Address(RVA = "0x88B320", Offset = "0x889B20", VA = "0x18088B320", Slot = "94")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005C")]
		public virtual bool OLOKMLECPAI
		{
			[Cpp2IlInjected.Token(Token = "0x60002CC")]
			[Cpp2IlInjected.Address(RVA = "0x407C540", Offset = "0x407AD40", VA = "0x18407C540", Slot = "95")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005D")]
		public bool MLCFEDDEPLB
		{
			[Cpp2IlInjected.Token(Token = "0x60002CD")]
			[Cpp2IlInjected.Address(RVA = "0x407C790", Offset = "0x407AF90", VA = "0x18407C790", Slot = "26")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005E")]
		public BAPMBLOBIME NPNMPABLGFJ
		{
			[Cpp2IlInjected.Token(Token = "0x60002CE")]
			[Cpp2IlInjected.Address(RVA = "0x407C980", Offset = "0x407B180", VA = "0x18407C980", Slot = "27")]
			get
			{
				return default(BAPMBLOBIME);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005F")]
		public FLOGLJPGMHF NIILCMPNFAF
		{
			[Cpp2IlInjected.Token(Token = "0x60002D0")]
			[Cpp2IlInjected.Address(RVA = "0x407C9E0", Offset = "0x407B1E0", VA = "0x18407C9E0", Slot = "29")]
			get
			{
				return default(FLOGLJPGMHF);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000060")]
		public virtual bool OCBIBNIJPIG
		{
			[Cpp2IlInjected.Token(Token = "0x60002EE")]
			[Cpp2IlInjected.Address(RVA = "0x88B320", Offset = "0x889B20", VA = "0x18088B320", Slot = "107")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000061")]
		public virtual BAEHHCDPGGB? FOALBAOCNHM
		{
			[Cpp2IlInjected.Token(Token = "0x60002EF")]
			[Cpp2IlInjected.Address(RVA = "0x843540", Offset = "0x841D40", VA = "0x180843540", Slot = "108")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000062")]
		public virtual CHGHNGABLMN? KNJFNAPKLHM
		{
			[Cpp2IlInjected.Token(Token = "0x60002F0")]
			[Cpp2IlInjected.Address(RVA = "0x843540", Offset = "0x841D40", VA = "0x180843540", Slot = "109")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000063")]
		public virtual IEnumerable<EOFGJNJAJLP<GHBFIOLFDBB>>? IKHBBEEMBPJ
		{
			[Cpp2IlInjected.Token(Token = "0x60002F1")]
			[Cpp2IlInjected.Address(RVA = "0x843540", Offset = "0x841D40", VA = "0x180843540", Slot = "110")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000064")]
		public bool HBOKKBIMEJD
		{
			[Cpp2IlInjected.Token(Token = "0x60002F5")]
			[Cpp2IlInjected.Address(RVA = "0x407C600", Offset = "0x407AE00", VA = "0x18407C600", Slot = "113")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000065")]
		public EOFGJNJAJLP<GPCAGFNHADK> CDBLDIIPBAE
		{
			[Cpp2IlInjected.Token(Token = "0x60002F6")]
			[Cpp2IlInjected.Address(RVA = "0x407C8C0", Offset = "0x407B0C0", VA = "0x18407C8C0", Slot = "55")]
			get
			{
				return default(EOFGJNJAJLP<GPCAGFNHADK>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000066")]
		public KPFGDODNFBO<GPCAGFNHADK> IIDMDJMPOHI
		{
			[Cpp2IlInjected.Token(Token = "0x60002F7")]
			[Cpp2IlInjected.Address(RVA = "0x407C730", Offset = "0x407AF30", VA = "0x18407C730", Slot = "56")]
			get
			{
				return default(KPFGDODNFBO<GPCAGFNHADK>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000067")]
		public virtual bool BGIOAPKMJLL
		{
			[Cpp2IlInjected.Token(Token = "0x60002F8")]
			[Cpp2IlInjected.Address(RVA = "0x88B320", Offset = "0x889B20", VA = "0x18088B320", Slot = "114")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000068")]
		public virtual KPFGDODNFBO<GPCAGFNHADK>? FLHDCAEDJPH
		{
			[Cpp2IlInjected.Token(Token = "0x60002F9")]
			[Cpp2IlInjected.Address(RVA = "0x843540", Offset = "0x841D40", VA = "0x180843540", Slot = "115")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000069")]
		public virtual bool BPEAHFJKELM
		{
			[Cpp2IlInjected.Token(Token = "0x60002FA")]
			[Cpp2IlInjected.Address(RVA = "0x88B320", Offset = "0x889B20", VA = "0x18088B320", Slot = "116")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006A")]
		public bool LDHDCLLFPAN
		{
			[Cpp2IlInjected.Token(Token = "0x60002FB")]
			[Cpp2IlInjected.Address(RVA = "0x407C7F0", Offset = "0x407AFF0", VA = "0x18407C7F0", Slot = "61")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006B")]
		public string HMPIIAILGKB
		{
			[Cpp2IlInjected.Token(Token = "0x60002FC")]
			[Cpp2IlInjected.Address(RVA = "0x8513B0", Offset = "0x84FBB0", VA = "0x1808513B0", Slot = "63")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60002FD")]
			[Cpp2IlInjected.Address(RVA = "0x851370", Offset = "0x84FB70", VA = "0x180851370")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006C")]
		private string BJFOLLHABHF
		{
			[Cpp2IlInjected.Token(Token = "0x60002FE")]
			[Cpp2IlInjected.Address(RVA = "0x851360", Offset = "0x84FB60", VA = "0x180851360")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006D")]
		public EOFGJNJAJLP<GHBFIOLFDBB> MFGIBADHBOB
		{
			[Cpp2IlInjected.Token(Token = "0x60002FF")]
			[Cpp2IlInjected.Address(RVA = "0x407C920", Offset = "0x407B120", VA = "0x18407C920", Slot = "62")]
			get
			{
				return default(EOFGJNJAJLP<GHBFIOLFDBB>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006E")]
		public EOFGJNJAJLP<GHBFIOLFDBB>? EOGBEMKKANE
		{
			[Cpp2IlInjected.Token(Token = "0x6000300")]
			[Cpp2IlInjected.Address(RVA = "0x407CB30", Offset = "0x407B330", VA = "0x18407CB30", Slot = "117")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006F")]
		public DLDHEKEFPNA<PKDEPFAFNML, FMHAPHMJOBC> CGFHDIFIDLA
		{
			[Cpp2IlInjected.Token(Token = "0x6000301")]
			[Cpp2IlInjected.Address(RVA = "0x407CC20", Offset = "0x407B420", VA = "0x18407CC20", Slot = "64")]
			get
			{
				return default(DLDHEKEFPNA<PKDEPFAFNML, FMHAPHMJOBC>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000070")]
		public virtual KPFGDODNFBO<PKDEPFAFNML>? ILJINCGBOJM
		{
			[Cpp2IlInjected.Token(Token = "0x6000302")]
			[Cpp2IlInjected.Address(RVA = "0x843540", Offset = "0x841D40", VA = "0x180843540", Slot = "118")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000071")]
		public virtual bool JIONFOOMPIO
		{
			[Cpp2IlInjected.Token(Token = "0x6000315")]
			[Cpp2IlInjected.Address(RVA = "0x88B320", Offset = "0x889B20", VA = "0x18088B320", Slot = "121")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000072")]
		public virtual bool ECLEJHIJBDP
		{
			[Cpp2IlInjected.Token(Token = "0x6000316")]
			[Cpp2IlInjected.Address(RVA = "0x85D960", Offset = "0x85C160", VA = "0x18085D960", Slot = "122")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action HNLJBPMDLAH
		{
			[Cpp2IlInjected.Token(Token = "0x60002D7")]
			[Cpp2IlInjected.Address(RVA = "0x407A940", Offset = "0x4079140", VA = "0x18407A940", Slot = "36")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60002D8")]
			[Cpp2IlInjected.Address(RVA = "0x407B870", Offset = "0x407A070", VA = "0x18407B870", Slot = "37")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event HEAPAGNICBC HEMNJGPCDPI
		{
			[Cpp2IlInjected.Token(Token = "0x60002DA")]
			[Cpp2IlInjected.Address(RVA = "0x4079580", Offset = "0x4077D80", VA = "0x184079580", Slot = "38")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60002DB")]
			[Cpp2IlInjected.Address(RVA = "0x407AFE0", Offset = "0x40797E0", VA = "0x18407AFE0", Slot = "39")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		public event AEPLLKBADOI OBJEEGOMNLE
		{
			[Cpp2IlInjected.Token(Token = "0x60002DC")]
			[Cpp2IlInjected.Address(RVA = "0x4079CC0", Offset = "0x40784C0", VA = "0x184079CC0", Slot = "40")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60002DD")]
			[Cpp2IlInjected.Address(RVA = "0x40790B0", Offset = "0x40778B0", VA = "0x1840790B0", Slot = "41")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000004")]
		public event Action GJBGEHAHDDE
		{
			[Cpp2IlInjected.Token(Token = "0x60002DE")]
			[Cpp2IlInjected.Address(RVA = "0x4079150", Offset = "0x4077950", VA = "0x184079150", Slot = "42")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60002DF")]
			[Cpp2IlInjected.Address(RVA = "0x4079050", Offset = "0x4077850", VA = "0x184079050", Slot = "43")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000005")]
		public event Action PNFCNPDHKJC
		{
			[Cpp2IlInjected.Token(Token = "0x60002E0")]
			[Cpp2IlInjected.Address(RVA = "0x4078DA0", Offset = "0x40775A0", VA = "0x184078DA0", Slot = "44")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60002E1")]
			[Cpp2IlInjected.Address(RVA = "0x407B6A0", Offset = "0x4079EA0", VA = "0x18407B6A0", Slot = "45")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000006")]
		public event Action<KPFGDODNFBO<PKDEPFAFNML>, FMHAPHMJOBC> LCBAOMLLKCE
		{
			[Cpp2IlInjected.Token(Token = "0x6000303")]
			[Cpp2IlInjected.Address(RVA = "0x4077AF0", Offset = "0x40762F0", VA = "0x184077AF0", Slot = "66")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000304")]
			[Cpp2IlInjected.Address(RVA = "0x407A9E0", Offset = "0x40791E0", VA = "0x18407A9E0", Slot = "67")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000007")]
		public event Action<KPFGDODNFBO<PKDEPFAFNML>, FMHAPHMJOBC> KOKOIDKPOHJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000305")]
			[Cpp2IlInjected.Address(RVA = "0x4079A80", Offset = "0x4078280", VA = "0x184079A80", Slot = "70")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000306")]
			[Cpp2IlInjected.Address(RVA = "0x4079DA0", Offset = "0x40785A0", VA = "0x184079DA0", Slot = "71")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000008")]
		public event Action<KPFGDODNFBO<PKDEPFAFNML>> NLPKKNJIFFH
		{
			[Cpp2IlInjected.Token(Token = "0x6000307")]
			[Cpp2IlInjected.Address(RVA = "0x4078F90", Offset = "0x4077790", VA = "0x184078F90", Slot = "68")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000308")]
			[Cpp2IlInjected.Address(RVA = "0x407BC60", Offset = "0x407A460", VA = "0x18407BC60", Slot = "69")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000009")]
		public event Action<KPFGDODNFBO<PKDEPFAFNML>, KPFGDODNFBO<PKDEPFAFNML>> HJEGGCIJBOM
		{
			[Cpp2IlInjected.Token(Token = "0x6000309")]
			[Cpp2IlInjected.Address(RVA = "0x4079B40", Offset = "0x4078340", VA = "0x184079B40", Slot = "72")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600030A")]
			[Cpp2IlInjected.Address(RVA = "0x407B910", Offset = "0x407A110", VA = "0x18407B910", Slot = "73")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000A")]
		public event Action<KPFGDODNFBO<PKDEPFAFNML>, FMHAPHMJOBC> KNNCGEJPPGD
		{
			[Cpp2IlInjected.Token(Token = "0x600030B")]
			[Cpp2IlInjected.Address(RVA = "0x407A240", Offset = "0x4078A40", VA = "0x18407A240", Slot = "74")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600030C")]
			[Cpp2IlInjected.Address(RVA = "0x4079EA0", Offset = "0x40786A0", VA = "0x184079EA0", Slot = "75")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000B")]
		public event Action<KPFGDODNFBO<PKDEPFAFNML>, KPFGDODNFBO<PKDEPFAFNML>> GFIOELPPAOA
		{
			[Cpp2IlInjected.Token(Token = "0x600030D")]
			[Cpp2IlInjected.Address(RVA = "0x407BD20", Offset = "0x407A520", VA = "0x18407BD20", Slot = "76")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600030E")]
			[Cpp2IlInjected.Address(RVA = "0x4079C00", Offset = "0x4078400", VA = "0x184079C00", Slot = "77")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002B0")]
		[Cpp2IlInjected.Address(RVA = "0x407BDE0", Offset = "0x407A5E0", VA = "0x18407BDE0")]
		[MJCEKHIGJMA("Need to handle `Name` better.")]
		[MJCEKHIGJMA("Creating the port adapter needs to actually read the `canInteract` state rather than just passing in `true`.")]
		protected KBILGNIMNAC(BBIGJEMLFFM POJGEMMMHAN, TNode DDLCNKGIKEK, bool MDFLPMGGCAP = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B1")]
		[Cpp2IlInjected.Address(RVA = "0x4077BB0", Offset = "0x40763B0", VA = "0x184077BB0", Slot = "86")]
		protected virtual void DIHNAABPOCM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B2")]
		[Cpp2IlInjected.Address(RVA = "0x4078320", Offset = "0x4076B20", VA = "0x184078320", Slot = "87")]
		public virtual void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B9")]
		[Cpp2IlInjected.Address(RVA = "0x407A750", Offset = "0x4078F50", VA = "0x18407A750", Slot = "9")]
		[AsyncStateMachine(typeof(KBILGNIMNAC<>.FNECMDAIDIJ))]
		public void LFOENEFAIGH(int KNFCCBEGHEI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CF")]
		[Cpp2IlInjected.Address(RVA = "0x407B080", Offset = "0x4079880", VA = "0x18407B080")]
		public bool NGOKLNHOBNN([In] BAPMBLOBIME IPHHABIKCHD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D1")]
		[Cpp2IlInjected.Address(RVA = "0x407A1D0", Offset = "0x40789D0", VA = "0x18407A1D0")]
		public bool JBMBLIIDDKJ([In] FLOGLJPGMHF IPHHABIKCHD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D2")]
		[Cpp2IlInjected.Address(RVA = "0x4079370", Offset = "0x4077B70", VA = "0x184079370", Slot = "31")]
		public void GLCPGLLIGAC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D3")]
		[Cpp2IlInjected.Address(RVA = "0x4079220", Offset = "0x4077A20", VA = "0x184079220", Slot = "32")]
		[AsyncStateMachine(typeof(KBILGNIMNAC<>.EOIFJDMEIKF))]
		public Task<MEKCEIEFNPI<KNDENJDHONE, MNGIPKBLGNG>> GKDHCIJCGKC(BAPMBLOBIME? KKDCNJKFOII, FLOGLJPGMHF? HGJODEDMNMO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002D4")]
		[Cpp2IlInjected.Address(RVA = "0x843530", Offset = "0x841D30", VA = "0x180843530", Slot = "96")]
		public virtual void CNFDODNFEIF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D5")]
		[Cpp2IlInjected.Address(RVA = "0x843530", Offset = "0x841D30", VA = "0x180843530", Slot = "97")]
		public virtual void NJOAPFAMIIK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D6")]
		[Cpp2IlInjected.Address(RVA = "0x843530", Offset = "0x841D30", VA = "0x180843530", Slot = "98")]
		public virtual void MEGAMJMNMNA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D9")]
		[Cpp2IlInjected.Address(RVA = "0x1CCD590", Offset = "0x1CCBD90", VA = "0x181CCD590")]
		protected void DHBGBNJBLJC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E2")]
		[Cpp2IlInjected.Address(RVA = "0x407A870", Offset = "0x4079070", VA = "0x18407A870")]
		protected void LOKNBJPKFKG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E3")]
		[Cpp2IlInjected.Address(RVA = "0x20FB950", Offset = "0x20FA150", VA = "0x1820FB950")]
		private void OOOJOGMMOBD([In] FLOGLJPGMHF LOMIHBHMPMH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E4")]
		[Cpp2IlInjected.Address(RVA = "0x407A680", Offset = "0x4078E80", VA = "0x18407A680", Slot = "99")]
		public virtual Task<MEKCEIEFNPI<KPFGDODNFBO<PKDEPFAFNML>, MNGIPKBLGNG>> JHPBLFBJKCC(string GCDLMFGKKMH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002E5")]
		[Cpp2IlInjected.Address(RVA = "0x407B5D0", Offset = "0x4079DD0", VA = "0x18407B5D0", Slot = "100")]
		public virtual Task<MEKCEIEFNPI<KNDENJDHONE, MNGIPKBLGNG>> NMBJBIGKBIB(KPFGDODNFBO<PKDEPFAFNML> KCJMKIMEENL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002E6")]
		[Cpp2IlInjected.Address(RVA = "0x843530", Offset = "0x841D30", VA = "0x180843530", Slot = "101")]
		public virtual void OJKNBILFKMO(KPFGDODNFBO<PKDEPFAFNML> MDBLLOIGICC, KPFGDODNFBO<PKDEPFAFNML> FLAOBBKMPDB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E7")]
		[Cpp2IlInjected.Address(RVA = "0x407B9D0", Offset = "0x407A1D0", VA = "0x18407B9D0", Slot = "102")]
		public virtual IEnumerable<FFPCMKOBEGP> PEFGEBGMOGL()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002E8")]
		[Cpp2IlInjected.Address(RVA = "0x4077200", Offset = "0x4075A00", VA = "0x184077200", Slot = "103")]
		public MEKCEIEFNPI<KNDENJDHONE, MNGIPKBLGNG> BILDLCFDGND(string HCPHBBBNIHI)
		{
			return default(MEKCEIEFNPI<KNDENJDHONE, MNGIPKBLGNG>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002E9")]
		[Cpp2IlInjected.Address(RVA = "0x4078E40", Offset = "0x4077640", VA = "0x184078E40", Slot = "46")]
		public bool ELFBNHGDJCK([Out] Guid AKLBOKGHOKD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002EA")]
		[Cpp2IlInjected.Address(RVA = "0x40777C0", Offset = "0x4075FC0", VA = "0x1840777C0")]
		public bool CPPGMKCHDGP([In] Guid IKNLCPDILAM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002EB")]
		[Cpp2IlInjected.Address(RVA = "0x843530", Offset = "0x841D30", VA = "0x180843530", Slot = "104")]
		public virtual void NJEEDNGOJJI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EC")]
		[Cpp2IlInjected.Address(RVA = "0x843530", Offset = "0x841D30", VA = "0x180843530", Slot = "105")]
		public virtual void GOBABILMPNJ(bool LBDILBOKKFP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002ED")]
		[Cpp2IlInjected.Address(RVA = "0x843540", Offset = "0x841D40", VA = "0x180843540", Slot = "106")]
		public virtual DJOICKLMCKN FJDBDIBHNAA([In] IBHOGICFKJJ DGJAFIILBLM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002F2")]
		[Cpp2IlInjected.Address(RVA = "0x407BA60", Offset = "0x407A260", VA = "0x18407BA60")]
		protected void PIOPNIJDNHH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F3")]
		[Cpp2IlInjected.Address(RVA = "0x4079D60", Offset = "0x4078560", VA = "0x184079D60", Slot = "111")]
		protected virtual bool ICFHIJMEOPM(KPFGDODNFBO<PKDEPFAFNML> KCJMKIMEENL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002F4")]
		[Cpp2IlInjected.Address(RVA = "0x88B320", Offset = "0x889B20", VA = "0x18088B320", Slot = "112")]
		protected virtual bool GNPCIJFFHOC(KPFGDODNFBO<PKDEPFAFNML> KCJMKIMEENL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600030F")]
		[Cpp2IlInjected.Address(RVA = "0x843530", Offset = "0x841D30", VA = "0x180843530", Slot = "119")]
		protected virtual void ACMFEFOOMLB(EJLAIGMFDKK AKPBMJCIDKM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000310")]
		[Cpp2IlInjected.Address(RVA = "0x407B0F0", Offset = "0x40798F0", VA = "0x18407B0F0")]
		protected void NHANJPHBKMO(EJLAIGMFDKK BADOLCEECJG, Func<string> PMKCJAMMIFC, Action<string> CALGNKHEBOO, NJKDGOPKHBN EKJLJLJONBC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000311")]
		[Cpp2IlInjected.Address(RVA = "0x407A300", Offset = "0x4078B00", VA = "0x18407A300")]
		protected void JGEDCGCFONO(EJLAIGMFDKK BADOLCEECJG, Func<string> PMKCJAMMIFC, Action<string> CALGNKHEBOO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000312")]
		[Cpp2IlInjected.Address(RVA = "0x407A060", Offset = "0x4078860", VA = "0x18407A060", Slot = "120")]
		protected virtual void IPHODEGJAMB(EJLAIGMFDKK BADOLCEECJG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000313")]
		[Cpp2IlInjected.Address(RVA = "0x4079A30", Offset = "0x4078230", VA = "0x184079A30", Slot = "79")]
		public void HEFLPNAJNOJ(EJLAIGMFDKK BADOLCEECJG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000314")]
		[Cpp2IlInjected.Address(RVA = "0x4079F60", Offset = "0x4078760", VA = "0x184079F60", Slot = "80")]
		public AELAMIEJJIB IOCINNCMFCF()
		{
			return default(AELAMIEJJIB);
		}

		[Cpp2IlInjected.Token(Token = "0x6000317")]
		[Cpp2IlInjected.Address(RVA = "0x88B320", Offset = "0x889B20", VA = "0x18088B320", Slot = "123")]
		public virtual bool HJKGAKJBIAL(KPFGDODNFBO<PKDEPFAFNML> KCJMKIMEENL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000318")]
		[Cpp2IlInjected.Address(RVA = "0x1393E00", Offset = "0x1392600", VA = "0x181393E00")]
		private void DGHCJIEBDPF([In] BAPMBLOBIME GBKEBGLIOFD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000319")]
		[Cpp2IlInjected.Address(RVA = "0x4078C00", Offset = "0x4077400", VA = "0x184078C00")]
		private void EBBBHNPJMON()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600031A")]
		[Cpp2IlInjected.Address(RVA = "0x407AAA0", Offset = "0x40792A0", VA = "0x18407AAA0")]
		private void MPMIEAILADD(KPFGDODNFBO<PKDEPFAFNML> KCJMKIMEENL, MPKOJNBPMJD FLDLEPALJFJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600031B")]
		[Cpp2IlInjected.Address(RVA = "0x1DE5A20", Offset = "0x1DE4220", VA = "0x181DE5A20")]
		private void GEKKPJHHKFI(KPFGDODNFBO<PKDEPFAFNML> EGNLNANJFMI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600031C")]
		[Cpp2IlInjected.Address(RVA = "0x407B740", Offset = "0x4079F40", VA = "0x18407B740")]
		private void OHMOOOCPLMO(KPFGDODNFBO<PKDEPFAFNML> EGNLNANJFMI, MPKOJNBPMJD JOJIGBNOKEI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600031D")]
		[Cpp2IlInjected.Address(RVA = "0x40773F0", Offset = "0x4075BF0", VA = "0x1840773F0")]
		private void CHONFCAEECD(KPFGDODNFBO<PKDEPFAFNML> MDBLLOIGICC, KPFGDODNFBO<PKDEPFAFNML> FLAOBBKMPDB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600031E")]
		[Cpp2IlInjected.Address(RVA = "0x1DE5C50", Offset = "0x1DE4450", VA = "0x181DE5C50")]
		private void HNLPDBPAHND(KPFGDODNFBO<PKDEPFAFNML> MDBLLOIGICC, KPFGDODNFBO<PKDEPFAFNML> FLAOBBKMPDB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600031F")]
		[Cpp2IlInjected.Address(RVA = "0x40777A0", Offset = "0x4075FA0", VA = "0x1840777A0")]
		private void CPBNIBJPGKM(KPFGDODNFBO<PKDEPFAFNML> KCJMKIMEENL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000320")]
		[Cpp2IlInjected.Address(RVA = "0x4079620", Offset = "0x4077E20", VA = "0x184079620")]
		private void HAAJGPKHFAF(KPFGDODNFBO<PKDEPFAFNML> KCJMKIMEENL, MPKOJNBPMJD FLDLEPALJFJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000321")]
		[Cpp2IlInjected.Address(RVA = "0x4077380", Offset = "0x4075B80", VA = "0x184077380")]
		private void CFBPHECNJIM(KPFGDODNFBO<PKDEPFAFNML> KCJMKIMEENL, MPKOJNBPMJD JOJIGBNOKEI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000322")]
		[Cpp2IlInjected.Address(RVA = "0x40770E0", Offset = "0x40758E0", VA = "0x1840770E0", Slot = "124")]
		[AsyncStateMachine(typeof(KBILGNIMNAC<>.NNIELMHEMNL))]
		public Task<MEKCEIEFNPI<KNDENJDHONE, MNGIPKBLGNG>> BIGKKNODHGA(string HCPHBBBNIHI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000323")]
		[Cpp2IlInjected.Address(RVA = "0x4077A80", Offset = "0x4076280", VA = "0x184077A80", Slot = "53")]
		private void DCIODEHOAFG(object BIHCKDNFBEH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000324")]
		[Cpp2IlInjected.Address(RVA = "0x407A800", Offset = "0x4079000", VA = "0x18407A800", Slot = "54")]
		private void LJENHKMAEDN(object BIHCKDNFBEH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000325")]
		[Cpp2IlInjected.Address(RVA = "0x4077060", Offset = "0x4075860", VA = "0x184077060", Slot = "28")]
		private bool AMEAJAANBCH([In] BAPMBLOBIME IPHHABIKCHD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000326")]
		[Cpp2IlInjected.Address(RVA = "0x4078D60", Offset = "0x4077560", VA = "0x184078D60", Slot = "30")]
		private bool ECMEEACJCJD([In] FLOGLJPGMHF IPHHABIKCHD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000327")]
		[Cpp2IlInjected.Address(RVA = "0x40770A0", Offset = "0x40758A0", VA = "0x1840770A0", Slot = "47")]
		private bool BDJAENLLBGF([In] Guid IKNLCPDILAM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000328")]
		[Cpp2IlInjected.Address(RVA = "0x4079E60", Offset = "0x4078660", VA = "0x184079E60")]
		[CompilerGenerated]
		private string IGIKMHBKECO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000329")]
		[Cpp2IlInjected.Address(RVA = "0x407A890", Offset = "0x4079090", VA = "0x18407A890")]
		[CompilerGenerated]
		private void MAKIFPKHAHF(string GCDLMFGKKMH)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000080")]
	public sealed class PLKBMBDBNBI : JLPEDCDJKCE<DAIBNHPENIF>
	{
		[Cpp2IlInjected.Token(Token = "0x17000073")]
		public override NodeVisualizationKey PJOIFALPHGK
		{
			[Cpp2IlInjected.Token(Token = "0x600033C")]
			[Cpp2IlInjected.Address(RVA = "0xCBA1B0", Offset = "0xCB89B0", VA = "0x180CBA1B0", Slot = "90")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600033D")]
		[Cpp2IlInjected.Address(RVA = "0x1F20E70", Offset = "0x1F1F670", VA = "0x181F20E70")]
		public PLKBMBDBNBI(BBIGJEMLFFM POJGEMMMHAN, DAIBNHPENIF DDLCNKGIKEK)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000081")]
	private sealed class OOPLBOIPBJP : GBJGPINBBDD<AMNDCFGHAAI>
	{
		[Cpp2IlInjected.Token(Token = "0x17000074")]
		public override NodeVisualizationKey PJOIFALPHGK
		{
			[Cpp2IlInjected.Token(Token = "0x600033E")]
			[Cpp2IlInjected.Address(RVA = "0x8C4CA0", Offset = "0x8C34A0", VA = "0x1808C4CA0", Slot = "90")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600033F")]
		[Cpp2IlInjected.Address(RVA = "0x1F20CC0", Offset = "0x1F1F4C0", VA = "0x181F20CC0")]
		public OOPLBOIPBJP(BBIGJEMLFFM POJGEMMMHAN, AMNDCFGHAAI DDLCNKGIKEK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000340")]
		[Cpp2IlInjected.Address(RVA = "0x843530", Offset = "0x841D30", VA = "0x180843530", Slot = "119")]
		protected override void ACMFEFOOMLB(EJLAIGMFDKK BADOLCEECJG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000082")]
	public abstract class LEBEFFPHJII<T> : KBILGNIMNAC<T> where T : notnull, JDGLJHHOLBH
	{
		[Cpp2IlInjected.Token(Token = "0x2000083")]
		[CompilerGenerated]
		private sealed class PGIKNBOIACH
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400017D")]
			public IReadOnlyList<KeyValuePair<string, FOFCIDGPHKD>> clipOptions;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400017E")]
			public LEBEFFPHJII<T> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400017F")]
			public IReadOnlyDictionary<Guid, int> clipGuidToIndex;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000180")]
			public IReadOnlyDictionary<int, Guid> clipIndexToGuid;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000181")]
			public AOONLOOENIF nodeAdapterDeps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000182")]
			public JLGGLBLNBGM clipType;

			[Cpp2IlInjected.Token(Token = "0x6000345")]
			[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
			public PGIKNBOIACH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000346")]
			[Cpp2IlInjected.Address(RVA = "0x846800", Offset = "0x845000", VA = "0x180846800")]
			internal IReadOnlyList<KeyValuePair<string, FOFCIDGPHKD>> LMFIIKHIMLH()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000347")]
			[Cpp2IlInjected.Address(RVA = "0x46571B0", Offset = "0x46559B0", VA = "0x1846571B0")]
			internal int PFCOBPBKFAK()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000348")]
			[Cpp2IlInjected.Address(RVA = "0x4656DC0", Offset = "0x46555C0", VA = "0x184656DC0")]
			internal void HNPBNHGAOHN(int clipIndex)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000349")]
			[Cpp2IlInjected.Address(RVA = "0x4656CB0", Offset = "0x46554B0", VA = "0x184656CB0")]
			internal void HDLNADONHGI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600034A")]
			[Cpp2IlInjected.Address(RVA = "0x4656B00", Offset = "0x4655300", VA = "0x184656B00")]
			internal void EMLJHLHJDJF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600034B")]
			[Cpp2IlInjected.Address(RVA = "0x4656A70", Offset = "0x4655270", VA = "0x184656A70")]
			internal bool DCEDNMKAINM()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600034C")]
			[Cpp2IlInjected.Address(RVA = "0x46570A0", Offset = "0x46558A0", VA = "0x1846570A0")]
			internal void OACPCMEGBFK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600034D")]
			[Cpp2IlInjected.Address(RVA = "0x4656A70", Offset = "0x4655270", VA = "0x184656A70")]
			internal bool OIFMFDKHAFM()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600034E")]
			[Cpp2IlInjected.Address(RVA = "0x4656D60", Offset = "0x4655560", VA = "0x184656D60")]
			internal float HKGCHHDCAOL()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x600034F")]
			[Cpp2IlInjected.Address(RVA = "0x46569B0", Offset = "0x46551B0", VA = "0x1846569B0")]
			internal void CGLNLPKELMO(float value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000350")]
			[Cpp2IlInjected.Address(RVA = "0x4656C50", Offset = "0x4655450", VA = "0x184656C50")]
			internal float GKLELMAPCJF()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000351")]
			[Cpp2IlInjected.Address(RVA = "0x4656FE0", Offset = "0x46557E0", VA = "0x184656FE0")]
			internal void NKAJLMDLLFL(float value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000352")]
			[Cpp2IlInjected.Address(RVA = "0x4656D00", Offset = "0x4655500", VA = "0x184656D00")]
			internal float HFAMGEBEPIP()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000353")]
			[Cpp2IlInjected.Address(RVA = "0x46570F0", Offset = "0x46558F0", VA = "0x1846570F0")]
			internal void PDNJFFILHJA(float value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000075")]
		public override NodeVisualizationKey PJOIFALPHGK
		{
			[Cpp2IlInjected.Token(Token = "0x6000342")]
			[Cpp2IlInjected.Address(RVA = "0x8AF8D0", Offset = "0x8AE0D0", VA = "0x1808AF8D0", Slot = "90")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000076")]
		public abstract JLGGLBLNBGM BGHMEIKPHJP
		{
			[Cpp2IlInjected.Token(Token = "0x6000343")]
			[Cpp2IlInjected.Address(Slot = "125")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000341")]
		[Cpp2IlInjected.Address(RVA = "0x41438C0", Offset = "0x41420C0", VA = "0x1841438C0")]
		public LEBEFFPHJII(BBIGJEMLFFM POJGEMMMHAN, T DDLCNKGIKEK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000344")]
		[Cpp2IlInjected.Address(RVA = "0x4142D30", Offset = "0x4141530", VA = "0x184142D30", Slot = "119")]
		protected sealed override void ACMFEFOOMLB(EJLAIGMFDKK BADOLCEECJG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000084")]
	private sealed class PBLMGOPMGEC : KBILGNIMNAC<GIDLPJLCJJF>
	{
		[Cpp2IlInjected.Token(Token = "0x17000077")]
		public override NodeVisualizationKey PJOIFALPHGK
		{
			[Cpp2IlInjected.Token(Token = "0x6000354")]
			[Cpp2IlInjected.Address(RVA = "0x8E30D0", Offset = "0x8E18D0", VA = "0x1808E30D0", Slot = "90")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000355")]
		[Cpp2IlInjected.Address(RVA = "0x1F20D20", Offset = "0x1F1F520", VA = "0x181F20D20")]
		public PBLMGOPMGEC(BBIGJEMLFFM POJGEMMMHAN, GIDLPJLCJJF DDLCNKGIKEK)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000085")]
	public sealed class NLCDJHMIDLH : KBILGNIMNAC<KOCPNLLHPDC>
	{
		[Cpp2IlInjected.Token(Token = "0x2000086")]
		[CompilerGenerated]
		private sealed class PJABOFKKLCD
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000184")]
			public NLCDJHMIDLH <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000185")]
			public AOONLOOENIF nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x6000358")]
			[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
			public PJABOFKKLCD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000359")]
			[Cpp2IlInjected.Address(RVA = "0x1F20E20", Offset = "0x1F1F620", VA = "0x181F20E20")]
			internal int PFCOBPBKFAK()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x600035A")]
			[Cpp2IlInjected.Address(RVA = "0x1F20D90", Offset = "0x1F1F590", VA = "0x181F20D90")]
			internal void HNPBNHGAOHN(int value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000183")]
		private static Dictionary<string, FOFCIDGPHKD>? JHCJCLOIDDE;

		[Cpp2IlInjected.Token(Token = "0x6000356")]
		[Cpp2IlInjected.Address(RVA = "0x1F1FA00", Offset = "0x1F1E200", VA = "0x181F1FA00")]
		public NLCDJHMIDLH(BBIGJEMLFFM POJGEMMMHAN, KOCPNLLHPDC DDLCNKGIKEK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000357")]
		[Cpp2IlInjected.Address(RVA = "0x1F1F690", Offset = "0x1F1DE90", VA = "0x181F1F690", Slot = "119")]
		protected override void ACMFEFOOMLB(EJLAIGMFDKK BADOLCEECJG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000088")]
	public sealed class JFAMPDPKGGD : LEBEFFPHJII<JMAFBNJFCFH>
	{
		[Cpp2IlInjected.Token(Token = "0x17000078")]
		public override JLGGLBLNBGM BGHMEIKPHJP
		{
			[Cpp2IlInjected.Token(Token = "0x600035F")]
			[Cpp2IlInjected.Address(RVA = "0x843540", Offset = "0x841D40", VA = "0x180843540", Slot = "125")]
			get
			{
				return default(JLGGLBLNBGM);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600035E")]
		[Cpp2IlInjected.Address(RVA = "0x1F1B7E0", Offset = "0x1F19FE0", VA = "0x181F1B7E0")]
		public JFAMPDPKGGD(BBIGJEMLFFM POJGEMMMHAN, JMAFBNJFCFH LHMMDMHNIJC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000089")]
	private sealed class GFAMCNBJOFM : GBJGPINBBDD<JHOMCDACHEB>
	{
		[Cpp2IlInjected.Token(Token = "0x17000079")]
		public override NodeVisualizationKey PJOIFALPHGK
		{
			[Cpp2IlInjected.Token(Token = "0x6000360")]
			[Cpp2IlInjected.Address(RVA = "0x8C4CA0", Offset = "0x8C34A0", VA = "0x1808C4CA0", Slot = "90")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000361")]
		[Cpp2IlInjected.Address(RVA = "0x1F12DB0", Offset = "0x1F115B0", VA = "0x181F12DB0")]
		public GFAMCNBJOFM(BBIGJEMLFFM POJGEMMMHAN, JHOMCDACHEB DDLCNKGIKEK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000362")]
		[Cpp2IlInjected.Address(RVA = "0x843530", Offset = "0x841D30", VA = "0x180843530", Slot = "119")]
		protected override void ACMFEFOOMLB(EJLAIGMFDKK BADOLCEECJG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008A")]
	private sealed class CDGFGNEIBIC : GBJGPINBBDD<OLGJOJJGJIA>
	{
		[Cpp2IlInjected.Token(Token = "0x1700007A")]
		public override NodeVisualizationKey PJOIFALPHGK
		{
			[Cpp2IlInjected.Token(Token = "0x6000363")]
			[Cpp2IlInjected.Address(RVA = "0x8C4CA0", Offset = "0x8C34A0", VA = "0x1808C4CA0", Slot = "90")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000364")]
		[Cpp2IlInjected.Address(RVA = "0x1F0D740", Offset = "0x1F0BF40", VA = "0x181F0D740")]
		public CDGFGNEIBIC(BBIGJEMLFFM POJGEMMMHAN, OLGJOJJGJIA DDLCNKGIKEK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000365")]
		[Cpp2IlInjected.Address(RVA = "0x843530", Offset = "0x841D30", VA = "0x180843530", Slot = "119")]
		protected override void ACMFEFOOMLB(EJLAIGMFDKK BADOLCEECJG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008B")]
	public sealed class JGHFOPBMMBE : LJJAHFFBFNG<NMGLGCMHLLE>
	{
		[Cpp2IlInjected.Token(Token = "0x200008C")]
		[CompilerGenerated]
		private sealed class LFDIBKJIHLN
		{
			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x200008D")]
			private struct <<AddHomeValueSetting>b__0>d : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400018A")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x400018B")]
				public AsyncVoidMethodBuilder <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x400018C")]
				public LFDIBKJIHLN <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x400018D")]
				public string value;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x400018E")]
				private TaskAwaiter<bool> <>u__1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
				[Cpp2IlInjected.Token(Token = "0x400018F")]
				private TaskAwaiter<MEKCEIEFNPI<KNDENJDHONE, MNGIPKBLGNG>> <>u__2;

				[Cpp2IlInjected.Token(Token = "0x600036A")]
				[Cpp2IlInjected.Address(RVA = "0x1F20FF0", Offset = "0x1F1F7F0", VA = "0x181F20FF0", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600036B")]
				[Cpp2IlInjected.Address(RVA = "0x9A4BE0", Offset = "0x9A33E0", VA = "0x1809A4BE0", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000188")]
			public AOONLOOENIF nodeAdapterDeps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000189")]
			public JGHFOPBMMBE <>4__this;

			[Cpp2IlInjected.Token(Token = "0x6000368")]
			[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
			public LFDIBKJIHLN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000369")]
			[Cpp2IlInjected.Address(RVA = "0x1F1DF40", Offset = "0x1F1C740", VA = "0x181F1DF40")]
			[AsyncStateMachine(typeof(<<AddHomeValueSetting>b__0>d))]
			internal void HGEEOBBKBOI(string value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000366")]
		[Cpp2IlInjected.Address(RVA = "0x1F1BEE0", Offset = "0x1F1A6E0", VA = "0x181F1BEE0")]
		public JGHFOPBMMBE(BBIGJEMLFFM POJGEMMMHAN, NMGLGCMHLLE LHMMDMHNIJC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000367")]
		[Cpp2IlInjected.Address(RVA = "0x1F1BC00", Offset = "0x1F1A400", VA = "0x181F1BC00", Slot = "125")]
		protected override void DDNCMAKEJJM(EJLAIGMFDKK BADOLCEECJG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008E")]
	public sealed class MAODKIFNNOI : LEBEFFPHJII<EDLFMIDEFPC>
	{
		[Cpp2IlInjected.Token(Token = "0x1700007B")]
		public override JLGGLBLNBGM BGHMEIKPHJP
		{
			[Cpp2IlInjected.Token(Token = "0x600036D")]
			[Cpp2IlInjected.Address(RVA = "0x8C4E00", Offset = "0x8C3600", VA = "0x1808C4E00", Slot = "125")]
			get
			{
				return default(JLGGLBLNBGM);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600036C")]
		[Cpp2IlInjected.Address(RVA = "0x1F1EC50", Offset = "0x1F1D450", VA = "0x181F1EC50")]
		public MAODKIFNNOI(BBIGJEMLFFM POJGEMMMHAN, EDLFMIDEFPC LHMMDMHNIJC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008F")]
	private sealed class FFPNLNGLHDJ : KBILGNIMNAC<ECCIDKKLLKL>
	{
		[Cpp2IlInjected.Token(Token = "0x1700007C")]
		public override NodeVisualizationKey PJOIFALPHGK
		{
			[Cpp2IlInjected.Token(Token = "0x600036E")]
			[Cpp2IlInjected.Address(RVA = "0x8E60C0", Offset = "0x8E48C0", VA = "0x1808E60C0", Slot = "90")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600036F")]
		[Cpp2IlInjected.Address(RVA = "0x1F115B0", Offset = "0x1F0FDB0", VA = "0x181F115B0")]
		public FFPNLNGLHDJ(BBIGJEMLFFM POJGEMMMHAN, ECCIDKKLLKL DDLCNKGIKEK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000370")]
		[Cpp2IlInjected.Address(RVA = "0x843530", Offset = "0x841D30", VA = "0x180843530", Slot = "119")]
		protected override void ACMFEFOOMLB(EJLAIGMFDKK BADOLCEECJG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000090")]
	public sealed class CDEDJEHGBLO : KBILGNIMNAC<AHDCLPIFIKO>
	{
		[Cpp2IlInjected.Token(Token = "0x1700007D")]
		public sealed override NodeVisualizationKey PJOIFALPHGK
		{
			[Cpp2IlInjected.Token(Token = "0x6000371")]
			[Cpp2IlInjected.Address(RVA = "0x843540", Offset = "0x841D40", VA = "0x180843540", Slot = "90")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007E")]
		public sealed override bool NPPHJEFJIBI
		{
			[Cpp2IlInjected.Token(Token = "0x6000372")]
			[Cpp2IlInjected.Address(RVA = "0x85D960", Offset = "0x85C160", VA = "0x18085D960", Slot = "91")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007F")]
		protected sealed override bool LHGLLIAHKHJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000373")]
			[Cpp2IlInjected.Address(RVA = "0x85D960", Offset = "0x85C160", VA = "0x18085D960", Slot = "89")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000374")]
		[Cpp2IlInjected.Address(RVA = "0x1F0D310", Offset = "0x1F0BB10", VA = "0x181F0D310")]
		public CDEDJEHGBLO(BBIGJEMLFFM POJGEMMMHAN, AHDCLPIFIKO DDLCNKGIKEK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000375")]
		[Cpp2IlInjected.Address(RVA = "0x1F0CF40", Offset = "0x1F0B740", VA = "0x181F0CF40", Slot = "119")]
		protected override void ACMFEFOOMLB(EJLAIGMFDKK BADOLCEECJG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000376")]
		[Cpp2IlInjected.Address(RVA = "0x1F0D2D0", Offset = "0x1F0BAD0", VA = "0x181F0D2D0")]
		private int PIHEMFPKOIK()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000377")]
		[Cpp2IlInjected.Address(RVA = "0x1F0D270", Offset = "0x1F0BA70", VA = "0x181F0D270")]
		private void JINOFLCFGAP(int GNHCOHKDBJO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000091")]
	public class GAAPMIPOPJF : PDFFDFFBFGF
	{
		[Cpp2IlInjected.Token(Token = "0x6000378")]
		[Cpp2IlInjected.Address(RVA = "0x1F11840", Offset = "0x1F10040", VA = "0x181F11840")]
		public GAAPMIPOPJF(BBIGJEMLFFM POJGEMMMHAN, LAMDOCKGMNE DDLCNKGIKEK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000379")]
		[Cpp2IlInjected.Address(RVA = "0x843530", Offset = "0x841D30", VA = "0x180843530", Slot = "119")]
		protected override void ACMFEFOOMLB(EJLAIGMFDKK BADOLCEECJG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000092")]
	public sealed class NFEFKJJMJKN : LJJAHFFBFNG<FKDHDOCEMPB>
	{
		[Cpp2IlInjected.Token(Token = "0x600037A")]
		[Cpp2IlInjected.Address(RVA = "0x1F1F630", Offset = "0x1F1DE30", VA = "0x181F1F630")]
		public NFEFKJJMJKN(BBIGJEMLFFM POJGEMMMHAN, FKDHDOCEMPB DDLCNKGIKEK)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000093")]
	public abstract class LJJAHFFBFNG<TVariableNode> : KBILGNIMNAC<TVariableNode> where TVariableNode : notnull, FKDHDOCEMPB
	{
		[Cpp2IlInjected.Token(Token = "0x2000094")]
		[CompilerGenerated]
		private sealed class FHLFIEAOENI
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000190")]
			public LJJAHFFBFNG<TVariableNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000191")]
			public AOONLOOENIF nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x6000382")]
			[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
			public FHLFIEAOENI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000383")]
			[Cpp2IlInjected.Address(RVA = "0x3AE8BD0", Offset = "0x3AE73D0", VA = "0x183AE8BD0")]
			internal bool LMFIIKHIMLH()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000384")]
			[Cpp2IlInjected.Address(RVA = "0x3AE8C30", Offset = "0x3AE7430", VA = "0x183AE8C30")]
			internal void PFCOBPBKFAK(bool v)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000385")]
			[Cpp2IlInjected.Address(RVA = "0x3AE8B70", Offset = "0x3AE7370", VA = "0x183AE8B70")]
			internal bool HNPBNHGAOHN()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000386")]
			[Cpp2IlInjected.Address(RVA = "0x3AE8AB0", Offset = "0x3AE72B0", VA = "0x183AE8AB0")]
			internal void HDLNADONHGI(bool v)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000387")]
			[Cpp2IlInjected.Address(RVA = "0x3AE8A00", Offset = "0x3AE7200", VA = "0x183AE8A00")]
			internal bool EMLJHLHJDJF()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000095")]
		[CompilerGenerated]
		private sealed class CLNAAIBIFHC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000192")]
			public AOONLOOENIF nodeAdapterDeps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000193")]
			public LJJAHFFBFNG<TVariableNode> <>4__this;

			[Cpp2IlInjected.Token(Token = "0x6000388")]
			[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
			public CLNAAIBIFHC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000389")]
			[Cpp2IlInjected.Address(RVA = "0x50776F0", Offset = "0x5075EF0", VA = "0x1850776F0")]
			internal void HGEEOBBKBOI(string v)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000080")]
		public override NodeVisualizationKey PJOIFALPHGK
		{
			[Cpp2IlInjected.Token(Token = "0x600037B")]
			[Cpp2IlInjected.Address(RVA = "0xA4C130", Offset = "0xA4A930", VA = "0x180A4C130", Slot = "90")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000081")]
		public override HMFCDHFFFJA OGMFLAMNNOI
		{
			[Cpp2IlInjected.Token(Token = "0x600037C")]
			[Cpp2IlInjected.Address(RVA = "0x41544D0", Offset = "0x4152CD0", VA = "0x1841544D0", Slot = "93")]
			get
			{
				return default(HMFCDHFFFJA);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600037D")]
		[Cpp2IlInjected.Address(RVA = "0x4154320", Offset = "0x4152B20", VA = "0x184154320")]
		protected LJJAHFFBFNG(BBIGJEMLFFM POJGEMMMHAN, TVariableNode DDLCNKGIKEK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037E")]
		[Cpp2IlInjected.Address(RVA = "0x4154080", Offset = "0x4152880", VA = "0x184154080", Slot = "87")]
		public override void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037F")]
		[Cpp2IlInjected.Address(RVA = "0x4153820", Offset = "0x4152020", VA = "0x184153820", Slot = "119")]
		protected override void ACMFEFOOMLB(EJLAIGMFDKK BADOLCEECJG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000380")]
		[Cpp2IlInjected.Address(RVA = "0x4153CE0", Offset = "0x41524E0", VA = "0x184153CE0", Slot = "125")]
		protected virtual void DDNCMAKEJJM(EJLAIGMFDKK BADOLCEECJG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000381")]
		[Cpp2IlInjected.Address(RVA = "0x4154220", Offset = "0x4152A20", VA = "0x184154220", Slot = "104")]
		public override void NJEEDNGOJJI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x1EF2E00", Offset = "0x1EF1600", VA = "0x181EF2E00")]
	public static NOABPNGHFKH OJFFIHPLODM(BBIGJEMLFFM POJGEMMMHAN, LAMDOCKGMNE DDLCNKGIKEK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000096")]
public sealed class NMIONLECNCB : GENKCIDABNJ, EJLOOICLGGB, DCDFABOKGOA, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000082")]
	public KPFGDODNFBO<FICFLFAPGGD> DJDHGGEDNOL
	{
		[Cpp2IlInjected.Token(Token = "0x600038A")]
		[Cpp2IlInjected.Address(RVA = "0xEC5E40", Offset = "0xEC4640", VA = "0x180EC5E40", Slot = "24")]
		[CompilerGenerated]
		get
		{
			return default(KPFGDODNFBO<FICFLFAPGGD>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000083")]
	public KPFGDODNFBO<BBEHFBIGKLK> NAJAPLOHLAG
	{
		[Cpp2IlInjected.Token(Token = "0x600038B")]
		[Cpp2IlInjected.Address(RVA = "0x119FAA0", Offset = "0x119E2A0", VA = "0x18119FAA0", Slot = "25")]
		[CompilerGenerated]
		get
		{
			return default(KPFGDODNFBO<BBEHFBIGKLK>);
		}
		[Cpp2IlInjected.Token(Token = "0x600038C")]
		[Cpp2IlInjected.Address(RVA = "0x1F1FA70", Offset = "0x1F1E270", VA = "0x181F1FA70")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000084")]
	private KPFGDODNFBO<DBEENCOBDHN> MIEOMDOGOFP
	{
		[Cpp2IlInjected.Token(Token = "0x600038D")]
		[Cpp2IlInjected.Address(RVA = "0xB7D760", Offset = "0xB7BF60", VA = "0x180B7D760")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000085")]
	public override KPFGDODNFBO<KLPCKDHOMDF> FKNDCFLHOIC
	{
		[Cpp2IlInjected.Token(Token = "0x600038E")]
		[Cpp2IlInjected.Address(RVA = "0x1F1FDD0", Offset = "0x1F1E5D0", VA = "0x181F1FDD0", Slot = "20")]
		get
		{
			return default(KPFGDODNFBO<KLPCKDHOMDF>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600038F")]
	[Cpp2IlInjected.Address(RVA = "0x1F1FE10", Offset = "0x1F1E610", VA = "0x181F1FE10")]
	private NMIONLECNCB(BBIGJEMLFFM POJGEMMMHAN, LAMDOCKGMNE DDLCNKGIKEK, JAFPMONAHDN CBGDLMODMOD, KPFGDODNFBO<PKDEPFAFNML> KCJMKIMEENL, KPFGDODNFBO<BBEHFBIGKLK> CJCIDDLJNDI, KPFGDODNFBO<DBEENCOBDHN> FGHCEPLGCAD, bool LHBIAKHJHPD, string GCDLMFGKKMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000390")]
	[Cpp2IlInjected.Address(RVA = "0x1F1FA80", Offset = "0x1F1E280", VA = "0x181F1FA80")]
	public static NMIONLECNCB OJFFIHPLODM(BBIGJEMLFFM POJGEMMMHAN, LAMDOCKGMNE DDLCNKGIKEK, JAFPMONAHDN FALADFAFJNF, KPFGDODNFBO<PKDEPFAFNML> KCJMKIMEENL, KPFGDODNFBO<DBEENCOBDHN> FGHCEPLGCAD, KPFGDODNFBO<BBEHFBIGKLK> CJCIDDLJNDI, bool LHBIAKHJHPD, bool MDFLPMGGCAP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000391")]
	[Cpp2IlInjected.Address(RVA = "0x1F1FA70", Offset = "0x1F1E270", VA = "0x181F1FA70")]
	internal void FDLOKGFFIGE(KPFGDODNFBO<BBEHFBIGKLK> IPHHABIKCHD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000097")]
public abstract class GENKCIDABNJ : DCDFABOKGOA, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000098")]
	private struct DAGDDDKKNMH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001A0")]
		private JOKLJJEPCLN? ALGKEOECAHB;

		[Cpp2IlInjected.Token(Token = "0x60003AF")]
		[Cpp2IlInjected.Address(RVA = "0x1F0DB10", Offset = "0x1F0C310", VA = "0x181F0DB10")]
		public void GLOOIBDLHCC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B0")]
		[Cpp2IlInjected.Address(RVA = "0x1F0DA70", Offset = "0x1F0C270", VA = "0x181F0DA70")]
		public JOKLJJEPCLN GIBIPAOOOJB(GENKCIDABNJ IKFLBCHJHAC)
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000197")]
	protected readonly BBIGJEMLFFM NOLFNCBBDEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000198")]
	protected readonly LAMDOCKGMNE PEDFPCOJMIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000199")]
	private DAGDDDKKNMH FPNEAEKPOEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400019A")]
	private readonly ABPGABMNNAF HGMJEIEDEDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400019B")]
	private readonly List<IGHLGLMLFPM> BDFLDJFKMKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400019C")]
	private readonly List<OMFBFBCCJCF> AANHECKAMKO;

	[Cpp2IlInjected.Token(Token = "0x17000086")]
	[MJCEKHIGJMA("To be deprecated with NodeConnection")]
	public IEnumerable<StaticEdge> LLHJNKEHEEI
	{
		[Cpp2IlInjected.Token(Token = "0x6000392")]
		[Cpp2IlInjected.Address(RVA = "0x1F12680", Offset = "0x1F10E80", VA = "0x181F12680", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000087")]
	public DisplayKind CEKAPNIFFJJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000393")]
		[Cpp2IlInjected.Address(RVA = "0x852490", Offset = "0x850C90", VA = "0x180852490", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(DisplayKind);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000088")]
	public KPFGDODNFBO<GPCAGFNHADK> IIDMDJMPOHI
	{
		[Cpp2IlInjected.Token(Token = "0x6000394")]
		[Cpp2IlInjected.Address(RVA = "0x1F122D0", Offset = "0x1F10AD0", VA = "0x181F122D0", Slot = "6")]
		get
		{
			return default(KPFGDODNFBO<GPCAGFNHADK>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000089")]
	public EOFGJNJAJLP<GPCAGFNHADK> CDBLDIIPBAE
	{
		[Cpp2IlInjected.Token(Token = "0x6000395")]
		[Cpp2IlInjected.Address(RVA = "0x1F12C20", Offset = "0x1F11420", VA = "0x181F12C20", Slot = "7")]
		get
		{
			return default(EOFGJNJAJLP<GPCAGFNHADK>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008A")]
	public PKOMODIBNOD NPKMJEGKKJJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000396")]
		[Cpp2IlInjected.Address(RVA = "0x1B65020", Offset = "0x1B63820", VA = "0x181B65020")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008B")]
	public BJJMJNOAIGC LEBNKBHOBAD
	{
		[Cpp2IlInjected.Token(Token = "0x6000397")]
		[Cpp2IlInjected.Address(RVA = "0x1F11910", Offset = "0x1F10110", VA = "0x181F11910", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008C")]
	protected JOKLJJEPCLN IFNAPGNMOEI
	{
		[Cpp2IlInjected.Token(Token = "0x6000398")]
		[Cpp2IlInjected.Address(RVA = "0x1F11910", Offset = "0x1F10110", VA = "0x181F11910")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008D")]
	public PortImage BAPHOIEIDNG
	{
		[Cpp2IlInjected.Token(Token = "0x6000399")]
		[Cpp2IlInjected.Address(RVA = "0x1F12550", Offset = "0x1F10D50", VA = "0x181F12550", Slot = "13")]
		get
		{
			return default(PortImage);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008E")]
	public string HMPIIAILGKB
	{
		[Cpp2IlInjected.Token(Token = "0x600039A")]
		[Cpp2IlInjected.Address(RVA = "0x8473D0", Offset = "0x845BD0", VA = "0x1808473D0", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600039B")]
		[Cpp2IlInjected.Address(RVA = "0x8472D0", Offset = "0x845AD0", VA = "0x1808472D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008F")]
	public EOFGJNJAJLP<GHBFIOLFDBB> MFGIBADHBOB
	{
		[Cpp2IlInjected.Token(Token = "0x600039C")]
		[Cpp2IlInjected.Address(RVA = "0x1F124B0", Offset = "0x1F10CB0", VA = "0x181F124B0", Slot = "9")]
		get
		{
			return default(EOFGJNJAJLP<GHBFIOLFDBB>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000090")]
	public KPFGDODNFBO<PKDEPFAFNML> BAADHBCICDB
	{
		[Cpp2IlInjected.Token(Token = "0x600039D")]
		[Cpp2IlInjected.Address(RVA = "0x96A740", Offset = "0x968F40", VA = "0x18096A740", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return default(KPFGDODNFBO<PKDEPFAFNML>);
		}
		[Cpp2IlInjected.Token(Token = "0x600039E")]
		[Cpp2IlInjected.Address(RVA = "0xE56E00", Offset = "0xE55600", VA = "0x180E56E00")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000091")]
	public abstract KPFGDODNFBO<KLPCKDHOMDF> FKNDCFLHOIC
	{
		[Cpp2IlInjected.Token(Token = "0x600039F")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60003A0")]
	[Cpp2IlInjected.Address(RVA = "0x1F12C50", Offset = "0x1F11450", VA = "0x181F12C50")]
	protected GENKCIDABNJ(BBIGJEMLFFM POJGEMMMHAN, LAMDOCKGMNE DDLCNKGIKEK, ABPGABMNNAF MEOPEAGBICP, KPFGDODNFBO<PKDEPFAFNML> KCJMKIMEENL, bool LHBIAKHJHPD, string GCDLMFGKKMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A1")]
	[Cpp2IlInjected.Address(RVA = "0x1F119B0", Offset = "0x1F101B0", VA = "0x181F119B0", Slot = "21")]
	protected virtual void DIHNAABPOCM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A2")]
	[Cpp2IlInjected.Address(RVA = "0x1F12180", Offset = "0x1F10980", VA = "0x181F12180", Slot = "22")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A3")]
	[Cpp2IlInjected.Address(RVA = "0x1F12950", Offset = "0x1F11150", VA = "0x181F12950", Slot = "14")]
	public void LBHOMHFMBKE(IGHLGLMLFPM FAGDFPGILCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A4")]
	[Cpp2IlInjected.Address(RVA = "0x1F118B0", Offset = "0x1F100B0", VA = "0x181F118B0", Slot = "15")]
	public void AIJMDKLICEH(OMFBFBCCJCF FAGDFPGILCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A5")]
	[Cpp2IlInjected.Address(RVA = "0x1F11B00", Offset = "0x1F10300", VA = "0x181F11B00", Slot = "16")]
	public void DMNDLBJNNHL(GCBOKNEHCAE IDFDJCHKGCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A6")]
	[Cpp2IlInjected.Address(RVA = "0x1F124F0", Offset = "0x1F10CF0", VA = "0x181F124F0", Slot = "23")]
	protected virtual void IMPNCEOIIPH(GCBOKNEHCAE IDFDJCHKGCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A7")]
	[Cpp2IlInjected.Address(RVA = "0x1F127C0", Offset = "0x1F10FC0", VA = "0x181F127C0")]
	private void KLMPJLEJFIJ(bool NOFEINPOGPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A8")]
	[Cpp2IlInjected.Address(RVA = "0x1F12300", Offset = "0x1F10B00", VA = "0x181F12300")]
	private void FEKOHGONHAG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A9")]
	[Cpp2IlInjected.Address(RVA = "0x1F12A70", Offset = "0x1F11270", VA = "0x181F12A70")]
	private void OBKHPKGLLGH([In] BKADBAMLLHA DLDCPCNEODE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AA")]
	[Cpp2IlInjected.Address(RVA = "0x1F12A10", Offset = "0x1F11210", VA = "0x181F12A10", Slot = "17")]
	public void NCHFIHNLHDE(IGHLGLMLFPM FAGDFPGILCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AB")]
	[Cpp2IlInjected.Address(RVA = "0x1F129B0", Offset = "0x1F111B0", VA = "0x181F129B0", Slot = "18")]
	public void LLDOLOHHGCN(OMFBFBCCJCF FAGDFPGILCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AC")]
	[Cpp2IlInjected.Address(RVA = "0x8472D0", Offset = "0x845AD0", VA = "0x1808472D0")]
	internal void CFHDLLILHHI(string GCDLMFGKKMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AD")]
	[Cpp2IlInjected.Address(RVA = "0x1F124D0", Offset = "0x1F10CD0", VA = "0x181F124D0")]
	internal void HBPPFKOPJBL(IGHPPGMPAAH DNJOEPEBEMJ, PKOMODIBNOD HKAKMPIMEOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AE")]
	[Cpp2IlInjected.Address(RVA = "0xE56E00", Offset = "0xE55600", VA = "0x180E56E00")]
	internal void HHCCPIDBCJA(KPFGDODNFBO<PKDEPFAFNML> KCJMKIMEENL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009A")]
public sealed class BPNJKEICMLI : FMHAPHMJOBC, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200009B")]
	[CompilerGenerated]
	private sealed class KFOKDPIAICP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001C0")]
		public BBIGJEMLFFM circuitsManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001C1")]
		public LAMDOCKGMNE node;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001C2")]
		public KPFGDODNFBO<PKDEPFAFNML> portGroupId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40001C3")]
		public bool canInteract;

		[Cpp2IlInjected.FieldOffset(Offset = "0x25")]
		[Cpp2IlInjected.Token(Token = "0x40001C4")]
		public bool ignoreChipConfigPortNames;

		[Cpp2IlInjected.Token(Token = "0x60003FB")]
		[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
		public KFOKDPIAICP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003FC")]
		[Cpp2IlInjected.Address(RVA = "0x1F1CB80", Offset = "0x1F1B380", VA = "0x181F1CB80")]
		internal OCDGHLGOHKH HLLDJBIOODD((int PortDescIndex, int PortIndex, GODMFLAOBFD InputPort) i)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003FD")]
		[Cpp2IlInjected.Address(RVA = "0x1F1CC10", Offset = "0x1F1B410", VA = "0x181F1CC10")]
		internal NMIONLECNCB NODAFBKKLCD(JAFPMONAHDN i, int idx)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200009C")]
	[CompilerGenerated]
	private struct HDKEKMONAOD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001C5")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001C6")]
		public AsyncTaskMethodBuilder<MEKCEIEFNPI<KNDENJDHONE, MNGIPKBLGNG>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001C7")]
		public BPNJKEICMLI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001C8")]
		private FKNKBHHKDOE <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001C9")]
		private TaskAwaiter<MEKCEIEFNPI<KNDENJDHONE, MNGIPKBLGNG>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60003FE")]
		[Cpp2IlInjected.Address(RVA = "0x1F137C0", Offset = "0x1F11FC0", VA = "0x181F137C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003FF")]
		[Cpp2IlInjected.Address(RVA = "0x1F13C20", Offset = "0x1F12420", VA = "0x181F13C20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200009E")]
	[CompilerGenerated]
	private struct MHGCINEMFJF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001CC")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001CD")]
		public AsyncTaskMethodBuilder<MEKCEIEFNPI<KNDENJDHONE, MNGIPKBLGNG>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001CE")]
		public BPNJKEICMLI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001CF")]
		public KPFGDODNFBO<GOLMGBIAPOO> inputDefId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001D0")]
		private FKNKBHHKDOE <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001D1")]
		private TaskAwaiter<MEKCEIEFNPI<KNDENJDHONE, MNGIPKBLGNG>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000403")]
		[Cpp2IlInjected.Address(RVA = "0x1F1ED20", Offset = "0x1F1D520", VA = "0x181F1ED20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000404")]
		[Cpp2IlInjected.Address(RVA = "0x1F1F070", Offset = "0x1F1D870", VA = "0x181F1F070", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200009F")]
	[CompilerGenerated]
	private struct JFNNJHPFOLG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001D2")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001D3")]
		public AsyncTaskMethodBuilder<MEKCEIEFNPI<KNDENJDHONE, MNGIPKBLGNG>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001D4")]
		public BPNJKEICMLI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001D5")]
		public KPFGDODNFBO<DBEENCOBDHN> outputDefId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001D6")]
		private FKNKBHHKDOE <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001D7")]
		private TaskAwaiter<MEKCEIEFNPI<KNDENJDHONE, MNGIPKBLGNG>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000405")]
		[Cpp2IlInjected.Address(RVA = "0x1F1B840", Offset = "0x1F1A040", VA = "0x181F1B840", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000406")]
		[Cpp2IlInjected.Address(RVA = "0x1F1BB90", Offset = "0x1F1A390", VA = "0x181F1BB90", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000A0")]
	[CompilerGenerated]
	private struct CDFLLANILCK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001D8")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001D9")]
		public AsyncTaskMethodBuilder<MEKCEIEFNPI<KNDENJDHONE, MNGIPKBLGNG>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001DA")]
		public BPNJKEICMLI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001DB")]
		public KPFGDODNFBO<GOLMGBIAPOO> inputDefId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40001DC")]
		public KPFGDODNFBO<GOLMGBIAPOO> targetIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001DD")]
		private FKNKBHHKDOE <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001DE")]
		private TaskAwaiter<MEKCEIEFNPI<KNDENJDHONE, MNGIPKBLGNG>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000407")]
		[Cpp2IlInjected.Address(RVA = "0x1F0D380", Offset = "0x1F0BB80", VA = "0x181F0D380", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000408")]
		[Cpp2IlInjected.Address(RVA = "0x1F0D6D0", Offset = "0x1F0BED0", VA = "0x181F0D6D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000A1")]
	[CompilerGenerated]
	private struct IFJMAFAFHNO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001DF")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001E0")]
		public AsyncTaskMethodBuilder<MEKCEIEFNPI<KNDENJDHONE, MNGIPKBLGNG>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001E1")]
		public BPNJKEICMLI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001E2")]
		public KPFGDODNFBO<DBEENCOBDHN> outputDefId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40001E3")]
		public KPFGDODNFBO<DBEENCOBDHN> targetIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001E4")]
		private FKNKBHHKDOE <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001E5")]
		private TaskAwaiter<MEKCEIEFNPI<KNDENJDHONE, MNGIPKBLGNG>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000409")]
		[Cpp2IlInjected.Address(RVA = "0x1F15D40", Offset = "0x1F14540", VA = "0x181F15D40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600040A")]
		[Cpp2IlInjected.Address(RVA = "0x1F16090", Offset = "0x1F14890", VA = "0x181F16090", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000A2")]
	[CompilerGenerated]
	private struct IBANNOBGCPG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001E6")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001E7")]
		public AsyncTaskMethodBuilder<MEKCEIEFNPI<KNDENJDHONE, MNGIPKBLGNG>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001E8")]
		public BPNJKEICMLI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001E9")]
		private FKNKBHHKDOE <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001EA")]
		private TaskAwaiter<MEKCEIEFNPI<KNDENJDHONE, MNGIPKBLGNG>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600040B")]
		[Cpp2IlInjected.Address(RVA = "0x1F15860", Offset = "0x1F14060", VA = "0x181F15860", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600040C")]
		[Cpp2IlInjected.Address(RVA = "0x1F15CD0", Offset = "0x1F144D0", VA = "0x181F15CD0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000A3")]
	[CompilerGenerated]
	private struct KGHBDJLPKIH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001EB")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001EC")]
		public AsyncTaskMethodBuilder<MEKCEIEFNPI<KNDENJDHONE, MNGIPKBLGNG>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001ED")]
		public BPNJKEICMLI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001EE")]
		public string newName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001EF")]
		private FKNKBHHKDOE <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001F0")]
		private TaskAwaiter<MEKCEIEFNPI<KNDENJDHONE, MNGIPKBLGNG>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600040D")]
		[Cpp2IlInjected.Address(RVA = "0x1F1CCA0", Offset = "0x1F1B4A0", VA = "0x181F1CCA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600040E")]
		[Cpp2IlInjected.Address(RVA = "0x1F1CFF0", Offset = "0x1F1B7F0", VA = "0x181F1CFF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000A4")]
	[CompilerGenerated]
	private struct KDFDGFPGBLB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001F1")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001F2")]
		public AsyncTaskMethodBuilder<MEKCEIEFNPI<KNDENJDHONE, MNGIPKBLGNG>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001F3")]
		public BPNJKEICMLI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001F4")]
		public KPFGDODNFBO<GOLMGBIAPOO> inputDefId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001F5")]
		public string name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001F6")]
		private FKNKBHHKDOE <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001F7")]
		private TaskAwaiter<MEKCEIEFNPI<KNDENJDHONE, MNGIPKBLGNG>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600040F")]
		[Cpp2IlInjected.Address(RVA = "0x1F1C370", Offset = "0x1F1AB70", VA = "0x181F1C370", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000410")]
		[Cpp2IlInjected.Address(RVA = "0x1F1C6C0", Offset = "0x1F1AEC0", VA = "0x181F1C6C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000A5")]
	[CompilerGenerated]
	private struct EDKMDFCNADC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001F8")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001F9")]
		public AsyncTaskMethodBuilder<MEKCEIEFNPI<KNDENJDHONE, MNGIPKBLGNG>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001FA")]
		public BPNJKEICMLI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001FB")]
		public KPFGDODNFBO<DBEENCOBDHN> outputDefId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001FC")]
		public string name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001FD")]
		private FKNKBHHKDOE <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001FE")]
		private TaskAwaiter<MEKCEIEFNPI<KNDENJDHONE, MNGIPKBLGNG>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000411")]
		[Cpp2IlInjected.Address(RVA = "0x1F0F950", Offset = "0x1F0E150", VA = "0x181F0F950", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000412")]
		[Cpp2IlInjected.Address(RVA = "0x1F0FCA0", Offset = "0x1F0E4A0", VA = "0x181F0FCA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000A6")]
	[CompilerGenerated]
	private struct BLBKEIDEAFL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001FF")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000200")]
		public AsyncTaskMethodBuilder<MEKCEIEFNPI<KNDENJDHONE, MNGIPKBLGNG>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000201")]
		public BPNJKEICMLI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000202")]
		public OLOFMDFDPDP type;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000203")]
		public KPFGDODNFBO<GOLMGBIAPOO> inputDefId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000204")]
		private FKNKBHHKDOE <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000205")]
		private TaskAwaiter<MEKCEIEFNPI<KNDENJDHONE, MNGIPKBLGNG>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000413")]
		[Cpp2IlInjected.Address(RVA = "0x1F06B60", Offset = "0x1F05360", VA = "0x181F06B60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000414")]
		[Cpp2IlInjected.Address(RVA = "0x1F06EF0", Offset = "0x1F056F0", VA = "0x181F06EF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000A7")]
	[CompilerGenerated]
	private struct IPHFHMIGMHE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000206")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000207")]
		public AsyncTaskMethodBuilder<MEKCEIEFNPI<KNDENJDHONE, MNGIPKBLGNG>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000208")]
		public BPNJKEICMLI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000209")]
		public OLOFMDFDPDP type;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400020A")]
		public KPFGDODNFBO<DBEENCOBDHN> outputDefId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400020B")]
		private FKNKBHHKDOE <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400020C")]
		private TaskAwaiter<MEKCEIEFNPI<KNDENJDHONE, MNGIPKBLGNG>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000415")]
		[Cpp2IlInjected.Address(RVA = "0x1F1B2C0", Offset = "0x1F19AC0", VA = "0x181F1B2C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000416")]
		[Cpp2IlInjected.Address(RVA = "0x1F1B650", Offset = "0x1F19E50", VA = "0x181F1B650", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001A3")]
	private readonly bool IEEKCGOAKPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001A4")]
	private readonly BBIGJEMLFFM NOLFNCBBDEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001A5")]
	private readonly bool CCEMOOEKHLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001A6")]
	private DLDHEKEFPNA<LADMNJOONHG, OCDGHLGOHKH> LAONLMFCGIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001A7")]
	private DLDHEKEFPNA<LADMNJOONHG, ICBHAHEPKLA> IOKNKCKHHAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40001A8")]
	private readonly LAMDOCKGMNE PEDFPCOJMIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40001A9")]
	private DLDHEKEFPNA<BBEHFBIGKLK, NMIONLECNCB> ENJHHOIFOKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40001AA")]
	private DLDHEKEFPNA<BBEHFBIGKLK, EJLOOICLGGB> JBKEOKGBLGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40001AB")]
	private string? HHEMJPPADOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40001AC")]
	private readonly MPKOJNBPMJD KEOHCMJCBKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40001AD")]
	private KPFGDODNFBO<PKDEPFAFNML> EOBGICJACII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x40001AE")]
	private readonly bool PDAAOANLHNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40001AF")]
	[CompilerGenerated]
	private Action? BDPFAIMFBHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x40001B1")]
	[CompilerGenerated]
	private Action? DLMNOOPAPHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x40001B9")]
	[CompilerGenerated]
	private Action<KPFGDODNFBO<LADMNJOONHG>>? KLJJEPJHKDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x40001BD")]
	[CompilerGenerated]
	private Action<KPFGDODNFBO<BBEHFBIGKLK>>? MFAEDHBIOBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x40001BF")]
	[CompilerGenerated]
	private FMHAPHMJOBC.OBDEONGDOGK? PJELEBMFFOG;

	[Cpp2IlInjected.Token(Token = "0x17000092")]
	public bool AGLEBMOGLCE
	{
		[Cpp2IlInjected.Token(Token = "0x60003B4")]
		[Cpp2IlInjected.Address(RVA = "0x1F0B3E0", Offset = "0x1F09BE0", VA = "0x181F0B3E0", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000093")]
	public bool JLPMDHEADFN
	{
		[Cpp2IlInjected.Token(Token = "0x60003B5")]
		[Cpp2IlInjected.Address(RVA = "0x1F0A510", Offset = "0x1F08D10", VA = "0x181F0A510", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000094")]
	public bool IFEIPNHPDNB
	{
		[Cpp2IlInjected.Token(Token = "0x60003B6")]
		[Cpp2IlInjected.Address(RVA = "0x1F07190", Offset = "0x1F05990", VA = "0x181F07190", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000095")]
	public EOFGJNJAJLP<GPCAGFNHADK> CDBLDIIPBAE
	{
		[Cpp2IlInjected.Token(Token = "0x60003B7")]
		[Cpp2IlInjected.Address(RVA = "0x1F0CE10", Offset = "0x1F0B610", VA = "0x181F0CE10", Slot = "7")]
		get
		{
			return default(EOFGJNJAJLP<GPCAGFNHADK>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000096")]
	public bool DAOACIAFOIK
	{
		[Cpp2IlInjected.Token(Token = "0x60003B8")]
		[Cpp2IlInjected.Address(RVA = "0x1F0B6F0", Offset = "0x1F09EF0", VA = "0x181F0B6F0", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000097")]
	public DLDHEKEFPNA<LADMNJOONHG, ICBHAHEPKLA> BKAHNEONHKK
	{
		[Cpp2IlInjected.Token(Token = "0x60003B9")]
		[Cpp2IlInjected.Address(RVA = "0x847480", Offset = "0x845C80", VA = "0x180847480", Slot = "9")]
		get
		{
			return default(DLDHEKEFPNA<LADMNJOONHG, ICBHAHEPKLA>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000098")]
	public string HMPIIAILGKB
	{
		[Cpp2IlInjected.Token(Token = "0x60003BA")]
		[Cpp2IlInjected.Address(RVA = "0x1F07250", Offset = "0x1F05A50", VA = "0x181F07250", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000099")]
	public EOFGJNJAJLP<GHBFIOLFDBB> MFGIBADHBOB
	{
		[Cpp2IlInjected.Token(Token = "0x60003BB")]
		[Cpp2IlInjected.Address(RVA = "0x1F09B40", Offset = "0x1F08340", VA = "0x181F09B40", Slot = "11")]
		get
		{
			return default(EOFGJNJAJLP<GHBFIOLFDBB>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009A")]
	public DLDHEKEFPNA<BBEHFBIGKLK, EJLOOICLGGB> NEBGAHDKBFC
	{
		[Cpp2IlInjected.Token(Token = "0x60003BC")]
		[Cpp2IlInjected.Address(RVA = "0x8473D0", Offset = "0x845BD0", VA = "0x1808473D0", Slot = "12")]
		get
		{
			return default(DLDHEKEFPNA<BBEHFBIGKLK, EJLOOICLGGB>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009B")]
	public KPFGDODNFBO<PKDEPFAFNML> BAADHBCICDB
	{
		[Cpp2IlInjected.Token(Token = "0x60003BD")]
		[Cpp2IlInjected.Address(RVA = "0xB7F1F0", Offset = "0xB7D9F0", VA = "0x180B7F1F0", Slot = "13")]
		get
		{
			return default(KPFGDODNFBO<PKDEPFAFNML>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	public event Action DEGOGKEGMDD
	{
		[Cpp2IlInjected.Token(Token = "0x60003BE")]
		[Cpp2IlInjected.Address(RVA = "0x1F09DE0", Offset = "0x1F085E0", VA = "0x181F09DE0", Slot = "14")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003BF")]
		[Cpp2IlInjected.Address(RVA = "0x1F09200", Offset = "0x1F07A00", VA = "0x181F09200", Slot = "15")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	public event Action GINBKNMDEAN
	{
		[Cpp2IlInjected.Token(Token = "0x60003C0")]
		[Cpp2IlInjected.Address(RVA = "0x1F0B860", Offset = "0x1F0A060", VA = "0x181F0B860", Slot = "16")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003C1")]
		[Cpp2IlInjected.Address(RVA = "0x1F0C180", Offset = "0x1F0A980", VA = "0x181F0C180", Slot = "17")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000E")]
	public event Action<KPFGDODNFBO<LADMNJOONHG>, KPFGDODNFBO<LADMNJOONHG>> DKMFBKNBCNF
	{
		[Cpp2IlInjected.Token(Token = "0x60003C2")]
		[Cpp2IlInjected.Address(RVA = "0x1F09C40", Offset = "0x1F08440", VA = "0x181F09C40", Slot = "18")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003C3")]
		[Cpp2IlInjected.Address(RVA = "0x1F0A430", Offset = "0x1F08C30", VA = "0x181F0A430", Slot = "19")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000F")]
	public event Action<KPFGDODNFBO<LADMNJOONHG>, KPFGDODNFBO<LADMNJOONHG>> GKLPHCNOFNP
	{
		[Cpp2IlInjected.Token(Token = "0x60003C4")]
		[Cpp2IlInjected.Address(RVA = "0x1F0C9B0", Offset = "0x1F0B1B0", VA = "0x181F0C9B0", Slot = "20")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003C5")]
		[Cpp2IlInjected.Address(RVA = "0x1F09010", Offset = "0x1F07810", VA = "0x181F09010", Slot = "21")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000010")]
	public event Action<KPFGDODNFBO<BBEHFBIGKLK>, KPFGDODNFBO<BBEHFBIGKLK>> CKKMMHCOCHA
	{
		[Cpp2IlInjected.Token(Token = "0x60003C6")]
		[Cpp2IlInjected.Address(RVA = "0x1F09550", Offset = "0x1F07D50", VA = "0x181F09550", Slot = "22")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003C7")]
		[Cpp2IlInjected.Address(RVA = "0x1F0A370", Offset = "0x1F08B70", VA = "0x181F0A370", Slot = "23")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000011")]
	public event Action<KPFGDODNFBO<BBEHFBIGKLK>, KPFGDODNFBO<BBEHFBIGKLK>> HNIJHEBFKIK
	{
		[Cpp2IlInjected.Token(Token = "0x60003C8")]
		[Cpp2IlInjected.Address(RVA = "0x1F0C0C0", Offset = "0x1F0A8C0", VA = "0x181F0C0C0", Slot = "24")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003C9")]
		[Cpp2IlInjected.Address(RVA = "0x1F07580", Offset = "0x1F05D80", VA = "0x181F07580", Slot = "25")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000012")]
	public event Action<KPFGDODNFBO<LADMNJOONHG>, ICBHAHEPKLA> KCIJPJAFCKI
	{
		[Cpp2IlInjected.Token(Token = "0x60003CA")]
		[Cpp2IlInjected.Address(RVA = "0x1F093D0", Offset = "0x1F07BD0", VA = "0x181F093D0", Slot = "26")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003CB")]
		[Cpp2IlInjected.Address(RVA = "0x1F09A80", Offset = "0x1F08280", VA = "0x181F09A80", Slot = "27")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000013")]
	public event Action<KPFGDODNFBO<LADMNJOONHG>> HEFMPFPAGEN
	{
		[Cpp2IlInjected.Token(Token = "0x60003CC")]
		[Cpp2IlInjected.Address(RVA = "0x1F0B110", Offset = "0x1F09910", VA = "0x181F0B110", Slot = "28")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003CD")]
		[Cpp2IlInjected.Address(RVA = "0x1F09D20", Offset = "0x1F08520", VA = "0x181F09D20", Slot = "29")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000014")]
	public event Action<KPFGDODNFBO<LADMNJOONHG>, ICBHAHEPKLA> IEOMPDINOHG
	{
		[Cpp2IlInjected.Token(Token = "0x60003CE")]
		[Cpp2IlInjected.Address(RVA = "0x1F0B4C0", Offset = "0x1F09CC0", VA = "0x181F0B4C0", Slot = "30")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003CF")]
		[Cpp2IlInjected.Address(RVA = "0x1F0C000", Offset = "0x1F0A800", VA = "0x181F0C000", Slot = "31")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000015")]
	public event Action<KPFGDODNFBO<BBEHFBIGKLK>, EJLOOICLGGB> KHGEOHCCCLF
	{
		[Cpp2IlInjected.Token(Token = "0x60003D0")]
		[Cpp2IlInjected.Address(RVA = "0x1F0B320", Offset = "0x1F09B20", VA = "0x181F0B320", Slot = "32")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003D1")]
		[Cpp2IlInjected.Address(RVA = "0x1F0BF40", Offset = "0x1F0A740", VA = "0x181F0BF40", Slot = "33")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000016")]
	public event Action<KPFGDODNFBO<BBEHFBIGKLK>> PAPNMEALCID
	{
		[Cpp2IlInjected.Token(Token = "0x60003D2")]
		[Cpp2IlInjected.Address(RVA = "0x1F07640", Offset = "0x1F05E40", VA = "0x181F07640", Slot = "34")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003D3")]
		[Cpp2IlInjected.Address(RVA = "0x1F07280", Offset = "0x1F05A80", VA = "0x181F07280", Slot = "35")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000017")]
	public event Action<KPFGDODNFBO<BBEHFBIGKLK>, EJLOOICLGGB> KAJGAAGFCBL
	{
		[Cpp2IlInjected.Token(Token = "0x60003D4")]
		[Cpp2IlInjected.Address(RVA = "0x1F09B80", Offset = "0x1F08380", VA = "0x181F09B80", Slot = "36")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003D5")]
		[Cpp2IlInjected.Address(RVA = "0x1F09490", Offset = "0x1F07C90", VA = "0x181F09490", Slot = "37")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003D6")]
	[Cpp2IlInjected.Address(RVA = "0x1F0CE40", Offset = "0x1F0B640", VA = "0x181F0CE40")]
	private BPNJKEICMLI(bool LHBIAKHJHPD, BBIGJEMLFFM POJGEMMMHAN, bool NKHDNDMHLAA, DLDHEKEFPNA<LADMNJOONHG, OCDGHLGOHKH> FPMJPCCLAIC, DLDHEKEFPNA<LADMNJOONHG, ICBHAHEPKLA> NJPNNDLAAGA, LAMDOCKGMNE DDLCNKGIKEK, DLDHEKEFPNA<BBEHFBIGKLK, NMIONLECNCB> CJLPBJALDFK, DLDHEKEFPNA<BBEHFBIGKLK, EJLOOICLGGB> CHMMBCIMPCL, string? PCCFNCDACGF, MPKOJNBPMJD FLDLEPALJFJ, KPFGDODNFBO<PKDEPFAFNML> KCJMKIMEENL, bool MDFLPMGGCAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D7")]
	[Cpp2IlInjected.Address(RVA = "0x1F0C320", Offset = "0x1F0AB20", VA = "0x181F0C320")]
	public static BPNJKEICMLI OJFFIHPLODM(bool LHBIAKHJHPD, BBIGJEMLFFM POJGEMMMHAN, bool NKHDNDMHLAA, LAMDOCKGMNE DDLCNKGIKEK, MPKOJNBPMJD FLDLEPALJFJ, KPFGDODNFBO<PKDEPFAFNML> KCJMKIMEENL, bool MDFLPMGGCAP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D8")]
	[Cpp2IlInjected.Address(RVA = "0x1F07760", Offset = "0x1F05F60", VA = "0x181F07760")]
	private void DIHNAABPOCM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D9")]
	[Cpp2IlInjected.Address(RVA = "0x1F08170", Offset = "0x1F06970", VA = "0x181F08170", Slot = "49")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003DA")]
	[Cpp2IlInjected.Address(RVA = "0x1F0B910", Offset = "0x1F0A110", VA = "0x181F0B910", Slot = "38")]
	[AsyncStateMachine(typeof(HDKEKMONAOD))]
	public Task<MEKCEIEFNPI<KNDENJDHONE, MNGIPKBLGNG>> MPMDGOLNDFF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003DB")]
	[Cpp2IlInjected.Address(RVA = "0x1F06F60", Offset = "0x1F05760", VA = "0x181F06F60")]
	private (JFEIDABHCJA, int)? ADBGBJNGFGD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003DC")]
	[Cpp2IlInjected.Address(RVA = "0x1F0B770", Offset = "0x1F09F70", VA = "0x181F0B770")]
	private void MLIEOCBLMJE(int CPOOPCEPBAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003DD")]
	[Cpp2IlInjected.Address(RVA = "0x13B04A0", Offset = "0x13AECA0", VA = "0x1813B04A0")]
	private void BPGHBGJGJMM(int CPOOPCEPBAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003DE")]
	[Cpp2IlInjected.Address(RVA = "0x1F0CA70", Offset = "0x1F0B270", VA = "0x181F0CA70")]
	private void OMHPCFDLINP(int ECPLCDILJCA, int AABHMBLLCKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003DF")]
	[Cpp2IlInjected.Address(RVA = "0x1F07700", Offset = "0x1F05F00", VA = "0x181F07700")]
	private void DFHLLCMMKGD(int ECPLCDILJCA, int AABHMBLLCKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E0")]
	[Cpp2IlInjected.Address(RVA = "0x1F0BA00", Offset = "0x1F0A200", VA = "0x181F0BA00")]
	private void NBCKDCHPNJA(int CPOOPCEPBAI, KPFGDODNFBO<LADMNJOONHG> KGEJHDKAFFN, GODMFLAOBFD IGEIIMLGHIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E1")]
	[Cpp2IlInjected.Address(RVA = "0x1F0B4A0", Offset = "0x1F09CA0", VA = "0x181F0B4A0")]
	private void LAIMDCJDKOJ(int NOFEINPOGPG, KPFGDODNFBO<LADMNJOONHG> KGEJHDKAFFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E2")]
	[Cpp2IlInjected.Address(RVA = "0x1F0A4F0", Offset = "0x1F08CF0", VA = "0x181F0A4F0")]
	private void IAMOBAPIOIH(int NOFEINPOGPG, KPFGDODNFBO<LADMNJOONHG> KGEJHDKAFFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E3")]
	[Cpp2IlInjected.Address(RVA = "0x1F0ABB0", Offset = "0x1F093B0", VA = "0x181F0ABB0")]
	private void KCELPDJLKEP(int CPOOPCEPBAI, KPFGDODNFBO<LADMNJOONHG> KGEJHDKAFFN, GODMFLAOBFD IGEIIMLGHIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E4")]
	[Cpp2IlInjected.Address(RVA = "0x1F0B1D0", Offset = "0x1F099D0", VA = "0x181F0B1D0")]
	private void KNEEJOEOMCG(int CPOOPCEPBAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E5")]
	[Cpp2IlInjected.Address(RVA = "0xA86260", Offset = "0xA84A60", VA = "0x180A86260")]
	private void HJICDKKNBHN(int CPOOPCEPBAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E6")]
	[Cpp2IlInjected.Address(RVA = "0x1F0C230", Offset = "0x1F0AA30", VA = "0x181F0C230")]
	private void NPKEKAPHPMH(int CPOOPCEPBAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E7")]
	[Cpp2IlInjected.Address(RVA = "0x13B04A0", Offset = "0x13AECA0", VA = "0x1813B04A0")]
	private void FAKOMLLPFKA(int CPOOPCEPBAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E8")]
	[Cpp2IlInjected.Address(RVA = "0x1F08C70", Offset = "0x1F07470", VA = "0x181F08C70")]
	private void EBIPEOLCGEP(int ECPLCDILJCA, int AABHMBLLCKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E9")]
	[Cpp2IlInjected.Address(RVA = "0x1F0B580", Offset = "0x1F09D80", VA = "0x181F0B580")]
	private void LMODEPIIMDF(int ECPLCDILJCA, int AABHMBLLCKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003EA")]
	[Cpp2IlInjected.Address(RVA = "0x1F0A550", Offset = "0x1F08D50", VA = "0x181F0A550")]
	private void ILGHMLFGONL(int CPOOPCEPBAI, KPFGDODNFBO<BBEHFBIGKLK> KGEJHDKAFFN, JAFPMONAHDN IGEIIMLGHIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003EB")]
	[Cpp2IlInjected.Address(RVA = "0x1F09B60", Offset = "0x1F08360", VA = "0x181F09B60")]
	private void GKJJFLHBHLI(int NOFEINPOGPG, KPFGDODNFBO<BBEHFBIGKLK> KGEJHDKAFFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003EC")]
	[Cpp2IlInjected.Address(RVA = "0x1F09D00", Offset = "0x1F08500", VA = "0x181F09D00")]
	private void GNCCIALDHLI(int NOFEINPOGPG, KPFGDODNFBO<BBEHFBIGKLK> KGEJHDKAFFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003ED")]
	[Cpp2IlInjected.Address(RVA = "0x1F09610", Offset = "0x1F07E10", VA = "0x181F09610")]
	private void GHPJEHAJEKE(int CPOOPCEPBAI, KPFGDODNFBO<BBEHFBIGKLK> KGEJHDKAFFN, JAFPMONAHDN IGEIIMLGHIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003EE")]
	[Cpp2IlInjected.Address(RVA = "0x1F07340", Offset = "0x1F05B40", VA = "0x181F07340")]
	private void CDKIENBKENF(int CPOOPCEPBAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003EF")]
	[Cpp2IlInjected.Address(RVA = "0xA86260", Offset = "0xA84A60", VA = "0x180A86260")]
	private void LFDBPMGPJBD(int CPOOPCEPBAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F0")]
	[Cpp2IlInjected.Address(RVA = "0x1F0B000", Offset = "0x1F09800", VA = "0x181F0B000", Slot = "39")]
	[AsyncStateMachine(typeof(MHGCINEMFJF))]
	public Task<MEKCEIEFNPI<KNDENJDHONE, MNGIPKBLGNG>> KFIKPMGIAAF(KPFGDODNFBO<GOLMGBIAPOO> EFMFHDBJLDJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F1")]
	[Cpp2IlInjected.Address(RVA = "0x1F0B5E0", Offset = "0x1F09DE0", VA = "0x181F0B5E0", Slot = "40")]
	[AsyncStateMachine(typeof(JFNNJHPFOLG))]
	public Task<MEKCEIEFNPI<KNDENJDHONE, MNGIPKBLGNG>> LNIIOAHAKPF(KPFGDODNFBO<DBEENCOBDHN> FGHCEPLGCAD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F2")]
	[Cpp2IlInjected.Address(RVA = "0x1F0AA90", Offset = "0x1F09290", VA = "0x181F0AA90", Slot = "41")]
	[AsyncStateMachine(typeof(CDFLLANILCK))]
	public Task<MEKCEIEFNPI<KNDENJDHONE, MNGIPKBLGNG>> KBLOFLHDOFH(KPFGDODNFBO<GOLMGBIAPOO> EFMFHDBJLDJ, KPFGDODNFBO<GOLMGBIAPOO> IMFOENNOCPD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F3")]
	[Cpp2IlInjected.Address(RVA = "0x1F0A250", Offset = "0x1F08A50", VA = "0x181F0A250", Slot = "42")]
	[AsyncStateMachine(typeof(IFJMAFAFHNO))]
	public Task<MEKCEIEFNPI<KNDENJDHONE, MNGIPKBLGNG>> HHCKBKCKNDP(KPFGDODNFBO<DBEENCOBDHN> FGHCEPLGCAD, KPFGDODNFBO<DBEENCOBDHN> IMFOENNOCPD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F4")]
	[Cpp2IlInjected.Address(RVA = "0x1F07490", Offset = "0x1F05C90", VA = "0x181F07490", Slot = "43")]
	[AsyncStateMachine(typeof(IBANNOBGCPG))]
	public Task<MEKCEIEFNPI<KNDENJDHONE, MNGIPKBLGNG>> CFAPPABLBBO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F5")]
	[Cpp2IlInjected.Address(RVA = "0x1F0C890", Offset = "0x1F0B090", VA = "0x181F0C890", Slot = "44")]
	[AsyncStateMachine(typeof(KGHBDJLPKIH))]
	public Task<MEKCEIEFNPI<KNDENJDHONE, MNGIPKBLGNG>> OJFIMNONFBG(string HCPHBBBNIHI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F6")]
	[Cpp2IlInjected.Address(RVA = "0x1F07F10", Offset = "0x1F06710", VA = "0x181F07F10", Slot = "45")]
	[AsyncStateMachine(typeof(KDFDGFPGBLB))]
	public Task<MEKCEIEFNPI<KNDENJDHONE, MNGIPKBLGNG>> DKCCCDPJNOD(KPFGDODNFBO<GOLMGBIAPOO> EFMFHDBJLDJ, string GCDLMFGKKMH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F7")]
	[Cpp2IlInjected.Address(RVA = "0x1F08040", Offset = "0x1F06840", VA = "0x181F08040", Slot = "46")]
	[AsyncStateMachine(typeof(EDKMDFCNADC))]
	public Task<MEKCEIEFNPI<KNDENJDHONE, MNGIPKBLGNG>> DNOJGCABMPK(KPFGDODNFBO<DBEENCOBDHN> FGHCEPLGCAD, string GCDLMFGKKMH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F8")]
	[Cpp2IlInjected.Address(RVA = "0x1F090D0", Offset = "0x1F078D0", VA = "0x181F090D0", Slot = "47")]
	[AsyncStateMachine(typeof(BLBKEIDEAFL))]
	public Task<MEKCEIEFNPI<KNDENJDHONE, MNGIPKBLGNG>> FDPJIBPJOPC(KPFGDODNFBO<GOLMGBIAPOO> EFMFHDBJLDJ, OLOFMDFDPDP HKAKMPIMEOA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F9")]
	[Cpp2IlInjected.Address(RVA = "0x1F092A0", Offset = "0x1F07AA0", VA = "0x181F092A0", Slot = "48")]
	[AsyncStateMachine(typeof(IPHFHMIGMHE))]
	public Task<MEKCEIEFNPI<KNDENJDHONE, MNGIPKBLGNG>> FGBFIHHDJOM(KPFGDODNFBO<DBEENCOBDHN> FGHCEPLGCAD, OLOFMDFDPDP HKAKMPIMEOA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003FA")]
	[Cpp2IlInjected.Address(RVA = "0x1F09E80", Offset = "0x1F08680", VA = "0x181F09E80")]
	internal void HHCCPIDBCJA(KPFGDODNFBO<PKDEPFAFNML> IPHHABIKCHD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A8")]
public sealed class LDNILKFEDEA : NKLPINCAHPI, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000A9")]
	public interface KEECOHCBNJH
	{
		[Cpp2IlInjected.Token(Token = "0x1700009D")]
		IGHPPGMPAAH LDOPDBMNNMP
		{
			[Cpp2IlInjected.Token(Token = "0x600041B")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x600041C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		Task<EALEPKELLAJ> JOGAJNNOONE(CancellationToken ODNHMAMKFFP);

		[Cpp2IlInjected.Token(Token = "0x600041D")]
		[Cpp2IlInjected.Address(Slot = "2")]
		Task<GMFGEGDFAPN> JIJHFHODPMB(CancellationToken ODNHMAMKFFP);

		[Cpp2IlInjected.Token(Token = "0x600041E")]
		[Cpp2IlInjected.Address(Slot = "3")]
		Task<EJNOBLPAPNM> HEIMABLJLDL(CancellationToken ODNHMAMKFFP);
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000AA")]
	[CompilerGenerated]
	private struct LMNBFMEHFFD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400020E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400020F")]
		public AsyncTaskMethodBuilder<LDNILKFEDEA> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000210")]
		public BBIGJEMLFFM circuitsManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000211")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000212")]
		public EALEPKELLAJ roomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000213")]
		public GMFGEGDFAPN superRoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000214")]
		private KEECOHCBNJH <selfDeps>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000215")]
		private GMFGEGDFAPN <finalSuperRoomData>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000216")]
		private TaskAwaiter<EALEPKELLAJ> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000217")]
		private TaskAwaiter<GMFGEGDFAPN> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000218")]
		private TaskAwaiter<EJNOBLPAPNM> <>u__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000219")]
		private TaskAwaiter<LODDICAHKEA> <>u__4;

		[Cpp2IlInjected.Token(Token = "0x600041F")]
		[Cpp2IlInjected.Address(RVA = "0x1F1E0D0", Offset = "0x1F1C8D0", VA = "0x181F1E0D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000420")]
		[Cpp2IlInjected.Address(RVA = "0x1F1EB00", Offset = "0x1F1D300", VA = "0x181F1EB00", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400020D")]
	private readonly LODDICAHKEA HBAMEFDCKOP;

	[Cpp2IlInjected.Token(Token = "0x1700009C")]
	public LODDICAHKEA PDDDOCBDKIE
	{
		[Cpp2IlInjected.Token(Token = "0x600041A")]
		[Cpp2IlInjected.Address(RVA = "0x846800", Offset = "0x845000", VA = "0x180846800", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000417")]
	[Cpp2IlInjected.Address(RVA = "0x8468E0", Offset = "0x8450E0", VA = "0x1808468E0")]
	private LDNILKFEDEA(LODDICAHKEA GGLDPMBGEDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000418")]
	[Cpp2IlInjected.Address(RVA = "0x1F1DDE0", Offset = "0x1F1C5E0", VA = "0x181F1DDE0")]
	[AsyncStateMachine(typeof(LMNBFMEHFFD))]
	public static Task<LDNILKFEDEA> LKAFENPIICK(BBIGJEMLFFM POJGEMMMHAN, EALEPKELLAJ? OLHDNFLDIIE, GMFGEGDFAPN? KIPPBODDGFF, CancellationToken ODNHMAMKFFP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000419")]
	[Cpp2IlInjected.Address(RVA = "0x1F1DDC0", Offset = "0x1F1C5C0", VA = "0x181F1DDC0", Slot = "5")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AB")]
public readonly struct FFNDJCFBCCI
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000AC")]
	[CompilerGenerated]
	private struct NAHDAHFDMKJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400021B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400021C")]
		public AsyncTaskMethodBuilder<MEKCEIEFNPI<object, MNGIPKBLGNG>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400021D")]
		public FFNDJCFBCCI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400021E")]
		public FFPCMKOBEGP action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400021F")]
		public bool clearBufferedRpcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000220")]
		private TaskAwaiter<MEKCEIEFNPI<object, MNGIPKBLGNG>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000425")]
		[Cpp2IlInjected.Address(RVA = "0x1F1F330", Offset = "0x1F1DB30", VA = "0x181F1F330", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000426")]
		[Cpp2IlInjected.Address(RVA = "0x1F1F5C0", Offset = "0x1F1DDC0", VA = "0x181F1F5C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000AD")]
	[CompilerGenerated]
	private struct KEOLDDHCKPI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000221")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000222")]
		public AsyncTaskMethodBuilder<MEKCEIEFNPI<bool, MNGIPKBLGNG>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000223")]
		public int splitSizeBytes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000224")]
		public DNCJDBJPHOD rootData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000225")]
		public EALEPKELLAJ circuitRootData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000226")]
		public GMFGEGDFAPN superRoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000227")]
		public FFNDJCFBCCI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000228")]
		private FFPCMKOBEGP[] <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000229")]
		private int <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400022A")]
		private TaskAwaiter<MEKCEIEFNPI<object, MNGIPKBLGNG>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000427")]
		[Cpp2IlInjected.Address(RVA = "0x1F1C730", Offset = "0x1F1AF30", VA = "0x181F1C730", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000428")]
		[Cpp2IlInjected.Address(RVA = "0x1F1CB10", Offset = "0x1F1B310", VA = "0x181F1CB10", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000AE")]
	[CompilerGenerated]
	private struct KJFPBCEALNH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400022B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400022C")]
		public AsyncTaskMethodBuilder<MEKCEIEFNPI<KNDENJDHONE, MNGIPKBLGNG>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400022D")]
		public FFNDJCFBCCI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400022E")]
		private TaskAwaiter<MEKCEIEFNPI<object, MNGIPKBLGNG>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000429")]
		[Cpp2IlInjected.Address(RVA = "0x1F1DB10", Offset = "0x1F1C310", VA = "0x181F1DB10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600042A")]
		[Cpp2IlInjected.Address(RVA = "0x1F1DD50", Offset = "0x1F1C550", VA = "0x181F1DD50", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400021A")]
	private readonly PFHKOKHNBAM MMBGMPGEOID;

	[Cpp2IlInjected.Token(Token = "0x6000421")]
	[Cpp2IlInjected.Address(RVA = "0x8EB4C0", Offset = "0x8E9CC0", VA = "0x1808EB4C0")]
	public FFNDJCFBCCI(PFHKOKHNBAM CCFDAEFHGMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000422")]
	[Cpp2IlInjected.Address(RVA = "0x1F11230", Offset = "0x1F0FA30", VA = "0x181F11230")]
	[AsyncStateMachine(typeof(NAHDAHFDMKJ))]
	private Task<MEKCEIEFNPI<object, MNGIPKBLGNG>> BEMKHEPJCBL(FFPCMKOBEGP BMOCGPMNBAF, bool IFCNCLOFHHB = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000423")]
	[Cpp2IlInjected.Address(RVA = "0x1F11450", Offset = "0x1F0FC50", VA = "0x181F11450")]
	[AsyncStateMachine(typeof(KEOLDDHCKPI))]
	public Task<MEKCEIEFNPI<bool, MNGIPKBLGNG?>>? POLGCLHCNCE(int LJEMIJOBNIB, DNCJDBJPHOD? JDMOMCFHMKL, EALEPKELLAJ? JJIHFFIJJCL, GMFGEGDFAPN? KIPPBODDGFF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000424")]
	[Cpp2IlInjected.Address(RVA = "0x1F11360", Offset = "0x1F0FB60", VA = "0x181F11360")]
	[AsyncStateMachine(typeof(KJFPBCEALNH))]
	public Task<MEKCEIEFNPI<KNDENJDHONE, MNGIPKBLGNG>> PGFGBHFCFEG()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AF")]
public sealed class FPFPMGHAFKG : DKEMDCNIIKB, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400022F")]
	private readonly EPLGAHDLMCC FODIGCNFNPL;

	[Cpp2IlInjected.Token(Token = "0x1700009E")]
	public EPLGAHDLMCC KHHCDOONBDA
	{
		[Cpp2IlInjected.Token(Token = "0x600042E")]
		[Cpp2IlInjected.Address(RVA = "0x846800", Offset = "0x845000", VA = "0x180846800", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600042B")]
	[Cpp2IlInjected.Address(RVA = "0x8468E0", Offset = "0x8450E0", VA = "0x1808468E0")]
	private FPFPMGHAFKG(EPLGAHDLMCC LMHKFCKHHCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600042C")]
	[Cpp2IlInjected.Address(RVA = "0x1F11640", Offset = "0x1F0FE40", VA = "0x181F11640")]
	public static FPFPMGHAFKG PKPMANIAHDL(BBIGJEMLFFM POJGEMMMHAN, DNCJDBJPHOD MPOAKIEMPHF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600042D")]
	[Cpp2IlInjected.Address(RVA = "0x1F11620", Offset = "0x1F0FE20", VA = "0x181F11620", Slot = "5")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B0")]
public interface LGOKBJDJBBL : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700009F")]
	CHJFBOCODMI PKJNCODPJPJ
	{
		[Cpp2IlInjected.Token(Token = "0x600042F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A0")]
	BEMDKNAJANC IELMDAHECEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000430")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A1")]
	JEMMOIPDIID ABNFLOEFEFL
	{
		[Cpp2IlInjected.Token(Token = "0x6000431")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A2")]
	JOBKCMIPLCA ABGIOFHANMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000432")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A3")]
	IPCNJLMACLH KHDLLBIDKLG
	{
		[Cpp2IlInjected.Token(Token = "0x6000433")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B1")]
public interface DJDKLOIJFMF : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x170000A4")]
	LGOKBJDJBBL? OCJLEGJMBDK
	{
		[Cpp2IlInjected.Token(Token = "0x6000434")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A5")]
	bool ICIDCBOPNAK
	{
		[Cpp2IlInjected.Token(Token = "0x6000435")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A6")]
	bool HLCECCKHFAA
	{
		[Cpp2IlInjected.Token(Token = "0x6000436")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000437")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Task<LGOKBJDJBBL?>? NFEPILDBMAB();

	[Cpp2IlInjected.Token(Token = "0x6000438")]
	[Cpp2IlInjected.Address(Slot = "4")]
	Task PIIKJJHALGM(BBIGJEMLFFM POJGEMMMHAN, DNCJDBJPHOD MPOAKIEMPHF, EALEPKELLAJ? LFKONOFAJCG, GMFGEGDFAPN? NKOOKCEENNJ);
}
[Cpp2IlInjected.Token(Token = "0x20000B2")]
[KLCEBOKGMJG("IStaticCV2Instance")]
public interface NKLPINCAHPI : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x170000A7")]
	LODDICAHKEA PDDDOCBDKIE
	{
		[Cpp2IlInjected.Token(Token = "0x6000439")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B3")]
[KLCEBOKGMJG("IStaticEVInstance")]
public interface DKEMDCNIIKB : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x170000A8")]
	EPLGAHDLMCC KHHCDOONBDA
	{
		[Cpp2IlInjected.Token(Token = "0x600043A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B4")]
public sealed class OKJJDEGPPDI : HAFPKFPPNPD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000230")]
	private readonly BBIGJEMLFFM NOLFNCBBDEO;

	[Cpp2IlInjected.Token(Token = "0x170000A9")]
	public FKOODBLBJNL? DCEJKJKKEPJ
	{
		[Cpp2IlInjected.Token(Token = "0x600043B")]
		[Cpp2IlInjected.Address(RVA = "0x1F208A0", Offset = "0x1F1F0A0", VA = "0x181F208A0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600043C")]
	[Cpp2IlInjected.Address(RVA = "0x8468E0", Offset = "0x8450E0", VA = "0x1808468E0")]
	internal OKJJDEGPPDI(BBIGJEMLFFM POJGEMMMHAN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B5")]
public sealed class JOBKCMIPLCA : FKOODBLBJNL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000231")]
	private readonly NKLPINCAHPI CDMLJIFOEDL;

	[Cpp2IlInjected.Token(Token = "0x170000AA")]
	public CDCMNEKDAME BEMKHEPJCBL
	{
		[Cpp2IlInjected.Token(Token = "0x600043D")]
		[Cpp2IlInjected.Address(RVA = "0x1F1C2B0", Offset = "0x1F1AAB0", VA = "0x181F1C2B0", Slot = "4")]
		get
		{
			return default(CDCMNEKDAME);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AB")]
	public AKEGCEKHDOL GODPOBMLKDK
	{
		[Cpp2IlInjected.Token(Token = "0x600043E")]
		[Cpp2IlInjected.Address(RVA = "0x1F1C250", Offset = "0x1F1AA50", VA = "0x181F1C250", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AC")]
	public EOFGJNJAJLP<GPCAGFNHADK> LIEIDGAIGFK
	{
		[Cpp2IlInjected.Token(Token = "0x600043F")]
		[Cpp2IlInjected.Address(RVA = "0x1F1C310", Offset = "0x1F1AB10", VA = "0x181F1C310", Slot = "6")]
		get
		{
			return default(EOFGJNJAJLP<GPCAGFNHADK>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AD")]
	public LODDICAHKEA BKCAPMPLDOB
	{
		[Cpp2IlInjected.Token(Token = "0x6000440")]
		[Cpp2IlInjected.Address(RVA = "0x1F1C200", Offset = "0x1F1AA00", VA = "0x181F1C200", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000441")]
	[Cpp2IlInjected.Address(RVA = "0x8468E0", Offset = "0x8450E0", VA = "0x1808468E0")]
	public JOBKCMIPLCA(NKLPINCAHPI KGAENLAMAOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000442")]
	[Cpp2IlInjected.Address(RVA = "0x1F1C190", Offset = "0x1F1A990", VA = "0x181F1C190")]
	public bool FKCJNDCIOLB([In] EOFGJNJAJLP<GPCAGFNHADK> IKNLCPDILAM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000443")]
	[Cpp2IlInjected.Address(RVA = "0x1F1C190", Offset = "0x1F1A990", VA = "0x181F1C190", Slot = "8")]
	private bool ILLDCEJDIMN([In] EOFGJNJAJLP<GPCAGFNHADK> IKNLCPDILAM)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B6")]
public static class DMCHPANGDFK
{
	[Cpp2IlInjected.Token(Token = "0x6000444")]
	[Cpp2IlInjected.Address(RVA = "0x1F0EBB0", Offset = "0x1F0D3B0", VA = "0x181F0EBB0")]
	public static IMNPCNCFILD<CCBMGFEGKNJ, FFPCMKOBEGP, BBIGJEMLFFM, OPEEJNJBEAD.OHFECBHGEAO<CCBMGFEGKNJ, FFPCMKOBEGP, BBIGJEMLFFM>> MHGDKHJPFFK([In] this IMNPCNCFILD<CCBMGFEGKNJ, FFPCMKOBEGP, BBIGJEMLFFM, OPEEJNJBEAD.OHFECBHGEAO<CCBMGFEGKNJ, FFPCMKOBEGP, BBIGJEMLFFM>> IELOOBIDFCI)
	{
		return default(IMNPCNCFILD<CCBMGFEGKNJ, FFPCMKOBEGP, BBIGJEMLFFM, OPEEJNJBEAD.OHFECBHGEAO<CCBMGFEGKNJ, FFPCMKOBEGP, BBIGJEMLFFM>>);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B7")]
public sealed class IKNGINBJAEC : MDDOCMAIDGE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000232")]
	private readonly BBIGJEMLFFM NOLFNCBBDEO;

	[Cpp2IlInjected.Token(Token = "0x170000AE")]
	public bool HLCECCKHFAA
	{
		[Cpp2IlInjected.Token(Token = "0x6000445")]
		[Cpp2IlInjected.Address(RVA = "0x1F16A30", Offset = "0x1F15230", VA = "0x181F16A30", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000446")]
	[Cpp2IlInjected.Address(RVA = "0x8468E0", Offset = "0x8450E0", VA = "0x1808468E0")]
	internal IKNGINBJAEC(BBIGJEMLFFM POJGEMMMHAN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B8")]
internal sealed class BFBLMJJGBME : JKDBEAGJKPD
{
	[Cpp2IlInjected.Token(Token = "0x6000447")]
	[Cpp2IlInjected.Address(RVA = "0x1F06AC0", Offset = "0x1F052C0", VA = "0x181F06AC0", Slot = "4")]
	public BKCGBNCEENM? PCAMEHLBBGM(string? EDOCIOODCNJ, string? ICJPNELIGNB, string? ONKAJFIPBMI, NIOGJILHKHF.GCNAOKJAPEE.NEGOFLKJCEB IOMCJEEJGFB, bool CCANDPFDOCE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000448")]
	[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
	public BFBLMJJGBME()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B9")]
public sealed class FBKLOJGFHAJ : KJJENPKNFKF
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000BA")]
	[CompilerGenerated]
	private struct NNEECCHALID : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000235")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000236")]
		public AsyncTaskMethodBuilder<CJADAAFBGMJ> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000237")]
		public FBKLOJGFHAJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000238")]
		private TaskAwaiter<LGOKBJDJBBL?> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000454")]
		[Cpp2IlInjected.Address(RVA = "0x1F200A0", Offset = "0x1F1E8A0", VA = "0x181F200A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000455")]
		[Cpp2IlInjected.Address(RVA = "0x1F20350", Offset = "0x1F1EB50", VA = "0x181F20350", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000233")]
	private readonly BBIGJEMLFFM NOLFNCBBDEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000234")]
	private IReadOnlyList<EOFGJNJAJLP<HACDMEHACNO>>? CJMGBMOGKLA;

	[Cpp2IlInjected.Token(Token = "0x170000AF")]
	public CJADAAFBGMJ? DCEJKJKKEPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000449")]
		[Cpp2IlInjected.Address(RVA = "0x1F10B80", Offset = "0x1F0F380", VA = "0x181F10B80", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B0")]
	public IPCNJLMACLH? HHCHGNOLECG
	{
		[Cpp2IlInjected.Token(Token = "0x600044A")]
		[Cpp2IlInjected.Address(RVA = "0x1F10670", Offset = "0x1F0EE70", VA = "0x181F10670")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B1")]
	public bool KCNGABAFIDB
	{
		[Cpp2IlInjected.Token(Token = "0x600044B")]
		[Cpp2IlInjected.Address(RVA = "0x1F10C00", Offset = "0x1F0F400", VA = "0x181F10C00", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B2")]
	public bool FADIDFMHBPG
	{
		[Cpp2IlInjected.Token(Token = "0x600044C")]
		[Cpp2IlInjected.Address(RVA = "0x1F10C60", Offset = "0x1F0F460", VA = "0x181F10C60", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600044D")]
	[Cpp2IlInjected.Address(RVA = "0x8468E0", Offset = "0x8450E0", VA = "0x1808468E0")]
	internal FBKLOJGFHAJ(BBIGJEMLFFM POJGEMMMHAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044E")]
	[Cpp2IlInjected.Address(RVA = "0x1F10580", Offset = "0x1F0ED80", VA = "0x181F10580", Slot = "7")]
	[AsyncStateMachine(typeof(NNEECCHALID))]
	public Task<CJADAAFBGMJ> APFMHCPKKBE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600044F")]
	[Cpp2IlInjected.Address(RVA = "0x1F10EC0", Offset = "0x1F0F6C0", VA = "0x181F10EC0")]
	internal Dictionary<EOFGJNJAJLP<GPCAGFNHADK>, Guid> PEKOMMODHCO(IEnumerable<FHCGEGKCGMN> DNHAJBHDMMP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000450")]
	[Cpp2IlInjected.Address(RVA = "0x1F10CC0", Offset = "0x1F0F4C0", VA = "0x181F10CC0")]
	public MEKCEIEFNPI<MOGALBDFPMI, DCIBOGBGGHI> OMOABMOKLJE([In] MOGALBDFPMI DKELEPINKMN, IEnumerable<FHCGEGKCGMN> FOLKBANEJNA, int EDPLHPFGEHO)
	{
		return default(MEKCEIEFNPI<MOGALBDFPMI, DCIBOGBGGHI>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000451")]
	[Cpp2IlInjected.Address(RVA = "0x1F10B40", Offset = "0x1F0F340", VA = "0x181F10B40")]
	internal static AELAMIEJJIB JBNPJDDDEKK(JOKOGGGEHGJ NCPKCNFBLKP, LAMDOCKGMNE DDLCNKGIKEK)
	{
		return default(AELAMIEJJIB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000452")]
	[Cpp2IlInjected.Address(RVA = "0x1F106F0", Offset = "0x1F0EEF0", VA = "0x181F106F0", Slot = "8")]
	private MEKCEIEFNPI<MOGALBDFPMI, DCIBOGBGGHI> BFNBIBMDNBK([In] MOGALBDFPMI DKELEPINKMN, IEnumerable<FHCGEGKCGMN> FOLKBANEJNA, int EDPLHPFGEHO)
	{
		return default(MEKCEIEFNPI<MOGALBDFPMI, DCIBOGBGGHI>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000453")]
	[Cpp2IlInjected.Address(RVA = "0x1F108F0", Offset = "0x1F0F0F0", VA = "0x181F108F0")]
	[CompilerGenerated]
	internal static AELAMIEJJIB IIPPEAPLKED(JOKOGGGEHGJ JMCGOONLNBE, LAMDOCKGMNE ILEGHHANFKN)
	{
		return default(AELAMIEJJIB);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BB")]
public sealed class IPCNJLMACLH : CJADAAFBGMJ
{
	[Cpp2IlInjected.Token(Token = "0x20000BC")]
	internal static class HFDLCNOOFMI
	{
		[Cpp2IlInjected.Token(Token = "0x20000BD")]
		[CompilerGenerated]
		private sealed class EKOJPEEIBGP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000241")]
			public LODDICAHKEA state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000242")]
			public KJEAHHMOGFO spawnIntoGraph;

			[Cpp2IlInjected.Token(Token = "0x600049A")]
			[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
			public EKOJPEEIBGP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600049B")]
			[Cpp2IlInjected.Address(RVA = "0x1F100D0", Offset = "0x1F0E8D0", VA = "0x181F100D0")]
			internal bool DDMKGIGCLEH(EGMDOGLJGFG n)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000BE")]
		[CompilerGenerated]
		private sealed class EALLDBEGMOG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000243")]
			public int makerPenInteractionFilterKeyValue;

			[Cpp2IlInjected.Token(Token = "0x600049C")]
			[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
			public EALLDBEGMOG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600049D")]
			[Cpp2IlInjected.Address(RVA = "0x1F0F930", Offset = "0x1F0E130", VA = "0x181F0F930")]
			internal void KEAPPIDHDLC(EGMDOGLJGFG n)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000495")]
		[Cpp2IlInjected.Address(RVA = "0x1F15320", Offset = "0x1F13B20", VA = "0x181F15320")]
		public static MEKCEIEFNPI<CJADAAFBGMJ.PKPEAAOIPCK, DCIBOGBGGHI> OHLHHBJPLCP(IPCNJLMACLH EGJINJKGIAK, [In] CJADAAFBGMJ.POJNDOMDGEC EKJLJLJONBC)
		{
			return default(MEKCEIEFNPI<CJADAAFBGMJ.PKPEAAOIPCK, DCIBOGBGGHI>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000496")]
		[Cpp2IlInjected.Address(RVA = "0x1F140A0", Offset = "0x1F128A0", VA = "0x181F140A0")]
		internal static MEKCEIEFNPI<(IPKJHBPIEIE, LGCPAOJOLDD), MNGIPKBLGNG> CCHOPGGAEOG(IPCNJLMACLH EGJINJKGIAK, LGCPAOJOLDD OLOLIOAGKHH, bool IFIKJLHEEEA, [In] EOFGJNJAJLP<GPCAGFNHADK> LAGLADJCPOH, [In] int? JHFBBELKCPP, [In] AELAMIEJJIB? DPHBCKDJBPA, [In] AELAMIEJJIB? POELHKECCFB)
		{
			return default(MEKCEIEFNPI<(IPKJHBPIEIE, LGCPAOJOLDD), MNGIPKBLGNG>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000497")]
		[Cpp2IlInjected.Address(RVA = "0x1F14DF0", Offset = "0x1F135F0", VA = "0x181F14DF0")]
		private static void MGOEDJEFENA(bool IFIKJLHEEEA, FHCGEGKCGMN FJLLLIBFOLI, IPKJHBPIEIE BOPKANGKMFK, [In] EOFGJNJAJLP<GPCAGFNHADK> LAGLADJCPOH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000498")]
		[Cpp2IlInjected.Address(RVA = "0x1F13C90", Offset = "0x1F12490", VA = "0x181F13C90")]
		public static void AFGFEOBKONK(PPEMLGPHPLC CCOOJDBLBMF, [In] CJADAAFBGMJ.KJJMKOAJLGE ECKJMGCDLLG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000499")]
		[Cpp2IlInjected.Address(RVA = "0x1F15230", Offset = "0x1F13A30", VA = "0x181F15230")]
		[CompilerGenerated]
		internal static bool NBHKMMOOHPH(LODDICAHKEA IIAKNOPALIF, KJEAHHMOGFO KININGGEMPG, EGMDOGLJGFG BLOHJPAAJDB)
		{
			return default(bool);
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000BF")]
	[CompilerGenerated]
	private struct HDAADMKCCJH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000244")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000245")]
		public AsyncTaskMethodBuilder<MEKCEIEFNPI<KNDENJDHONE, MNGIPKBLGNG>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000246")]
		public IPCNJLMACLH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000247")]
		public KPFGDODNFBO<GPCAGFNHADK> graphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000248")]
		public KPFGDODNFBO<FICFLFAPGGD> srcId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000249")]
		public KPFGDODNFBO<CNIDNALDCPF> dstId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400024A")]
		private TaskAwaiter<MEKCEIEFNPI<KNDENJDHONE, MNGIPKBLGNG>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600049E")]
		[Cpp2IlInjected.Address(RVA = "0x1F13100", Offset = "0x1F11900", VA = "0x181F13100", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600049F")]
		[Cpp2IlInjected.Address(RVA = "0x1F13750", Offset = "0x1F11F50", VA = "0x181F13750", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000C0")]
	[CompilerGenerated]
	private struct AGELOHFGIKF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400024B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400024C")]
		public AsyncTaskMethodBuilder<MEKCEIEFNPI<KNDENJDHONE, MNGIPKBLGNG>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400024D")]
		public IPCNJLMACLH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400024E")]
		public EOFGJNJAJLP<GHBFIOLFDBB> inputNodeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400024F")]
		public EOFGJNJAJLP<GPCAGFNHADK> graphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000250")]
		public KPFGDODNFBO<PKDEPFAFNML> inputPortGroupId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x4000251")]
		public KPFGDODNFBO<LADMNJOONHG> inputId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000252")]
		private TaskAwaiter<MEKCEIEFNPI<KNDENJDHONE, MNGIPKBLGNG>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004A0")]
		[Cpp2IlInjected.Address(RVA = "0x1F06710", Offset = "0x1F04F10", VA = "0x181F06710", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004A1")]
		[Cpp2IlInjected.Address(RVA = "0x1F06A50", Offset = "0x1F05250", VA = "0x181F06A50", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000C1")]
	[CompilerGenerated]
	private struct DIGLDNLHLLO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000253")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000254")]
		public AsyncTaskMethodBuilder<MEKCEIEFNPI<KNDENJDHONE, MNGIPKBLGNG>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000255")]
		public IPCNJLMACLH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000256")]
		public EOFGJNJAJLP<GHBFIOLFDBB> outputNodeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000257")]
		public EOFGJNJAJLP<GPCAGFNHADK> graphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000258")]
		public KPFGDODNFBO<PKDEPFAFNML> outputPortGroupId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x4000259")]
		public KPFGDODNFBO<BBEHFBIGKLK> outputId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400025A")]
		private TaskAwaiter<MEKCEIEFNPI<KNDENJDHONE, MNGIPKBLGNG>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004A2")]
		[Cpp2IlInjected.Address(RVA = "0x1F0E4E0", Offset = "0x1F0CCE0", VA = "0x181F0E4E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004A3")]
		[Cpp2IlInjected.Address(RVA = "0x1F0E820", Offset = "0x1F0D020", VA = "0x181F0E820", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000239")]
	private readonly BBIGJEMLFFM NOLFNCBBDEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400023A")]
	private readonly NKLPINCAHPI CDMLJIFOEDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400023B")]
	private readonly DKEMDCNIIKB LOLNPINEABM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400023C")]
	private readonly FKPHKCLJCBL IJHFKCEGPLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400023D")]
	private readonly FBKLOJGFHAJ LLJLMHFJEFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400023E")]
	private Dictionary<EOFGJNJAJLP<GHBFIOLFDBB>, NOABPNGHFKH> NENAENGOANE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000240")]
	[CompilerGenerated]
	private Action<EOFGJNJAJLP<GHBFIOLFDBB>>? GJBGEHAHDDE;

	[Cpp2IlInjected.Token(Token = "0x170000B3")]
	public FKPHKCLJCBL BCPKJPMKMFI
	{
		[Cpp2IlInjected.Token(Token = "0x6000456")]
		[Cpp2IlInjected.Address(RVA = "0x1EE9280", Offset = "0x1EE7A80", VA = "0x181EE9280", Slot = "4")]
		get
		{
			return default(FKPHKCLJCBL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000457")]
	[Cpp2IlInjected.Address(RVA = "0x1F1ADA0", Offset = "0x1F195A0", VA = "0x181F1ADA0")]
	public IPCNJLMACLH(BBIGJEMLFFM POJGEMMMHAN, NKLPINCAHPI KGAENLAMAOA, DKEMDCNIIKB DPBKGBBCJOE, FBKLOJGFHAJ PODMMCINPOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000458")]
	[Cpp2IlInjected.Address(RVA = "0x1F16AD0", Offset = "0x1F152D0", VA = "0x181F16AD0", Slot = "38")]
	public KPFGDODNFBO<ODOGGMIGDCC> ANNNNHDBKLK(KPFGDODNFBO<GPCAGFNHADK> IKNLCPDILAM, KPFGDODNFBO<CNIDNALDCPF> CACIDFDKPBJ)
	{
		return default(KPFGDODNFBO<ODOGGMIGDCC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000459")]
	[Cpp2IlInjected.Address(RVA = "0x1F196C0", Offset = "0x1F17EC0", VA = "0x181F196C0", Slot = "39")]
	public KPFGDODNFBO<LNFGFFCKMPO> JCNPAKFCELB(KPFGDODNFBO<GPCAGFNHADK> IKNLCPDILAM, KPFGDODNFBO<FICFLFAPGGD> CJCIDDLJNDI)
	{
		return default(KPFGDODNFBO<LNFGFFCKMPO>);
	}

	[Cpp2IlInjected.Token(Token = "0x600045A")]
	[Cpp2IlInjected.Address(RVA = "0x1F18080", Offset = "0x1F16880", VA = "0x181F18080", Slot = "5")]
	public bool EEICMANPKJP(KPFGDODNFBO<GPCAGFNHADK> IKNLCPDILAM, KPFGDODNFBO<FICFLFAPGGD> NBEKJKEDPBE, KPFGDODNFBO<CNIDNALDCPF> OPNPBHOMMHD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600045B")]
	[Cpp2IlInjected.Address(RVA = "0x1F1A7D0", Offset = "0x1F18FD0", VA = "0x181F1A7D0")]
	public bool ONBAHMLNONA(KPFGDODNFBO<GPCAGFNHADK> IKNLCPDILAM, [In] MCODEGMJPBO PGAMEILHHEL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600045C")]
	[Cpp2IlInjected.Address(RVA = "0x1F1AB50", Offset = "0x1F19350", VA = "0x181F1AB50", Slot = "7")]
	public bool PDDGHANACLF(ICBHAHEPKLA GPPCCCCNDND)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600045D")]
	[Cpp2IlInjected.Address(RVA = "0x1F17EA0", Offset = "0x1F166A0", VA = "0x181F17EA0", Slot = "8")]
	public bool DGMCLHDDMMK(EJLOOICLGGB DCNAGKHHOBB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600045E")]
	[Cpp2IlInjected.Address(RVA = "0x1F19F40", Offset = "0x1F18740", VA = "0x181F19F40")]
	public NOABPNGHFKH? LMEPJKHEDCN([In] EOFGJNJAJLP<GHBFIOLFDBB> FMPAALMFOIG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600045F")]
	[Cpp2IlInjected.Address(RVA = "0x1F194E0", Offset = "0x1F17CE0", VA = "0x181F194E0")]
	public KPFGDODNFBO<GHBFIOLFDBB> IMONNBMKEAH(KPFGDODNFBO<GPCAGFNHADK> IKNLCPDILAM, [In] EOFGJNJAJLP<GHBFIOLFDBB> BLLCNIIGJLD)
	{
		return default(KPFGDODNFBO<GHBFIOLFDBB>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000460")]
	[Cpp2IlInjected.Address(RVA = "0x1F19030", Offset = "0x1F17830", VA = "0x181F19030", Slot = "18")]
	public KPFGDODNFBO<GHBFIOLFDBB> HOLOIDLEDJE(KPFGDODNFBO<GPCAGFNHADK> IKNLCPDILAM, KPFGDODNFBO<CNIDNALDCPF> CACIDFDKPBJ)
	{
		return default(KPFGDODNFBO<GHBFIOLFDBB>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000461")]
	[Cpp2IlInjected.Address(RVA = "0x1F18FB0", Offset = "0x1F177B0", VA = "0x181F18FB0", Slot = "19")]
	public KPFGDODNFBO<GHBFIOLFDBB> HHDDPICPMDF(KPFGDODNFBO<GPCAGFNHADK> IKNLCPDILAM, KPFGDODNFBO<FICFLFAPGGD> CJCIDDLJNDI)
	{
		return default(KPFGDODNFBO<GHBFIOLFDBB>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000462")]
	[Cpp2IlInjected.Address(RVA = "0x1F1A4D0", Offset = "0x1F18CD0", VA = "0x181F1A4D0")]
	private void NBIOCMFNMJM(EOFGJNJAJLP<GHBFIOLFDBB> FMPAALMFOIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000463")]
	[Cpp2IlInjected.Address(RVA = "0x1F19BD0", Offset = "0x1F183D0", VA = "0x181F19BD0")]
	public IEnumerable<NOABPNGHFKH> KFMGEIABLKK([In] EOFGJNJAJLP<GPCAGFNHADK> IKNLCPDILAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000464")]
	[Cpp2IlInjected.Address(RVA = "0x1F1A790", Offset = "0x1F18F90", VA = "0x181F1A790")]
	private NOABPNGHFKH? OFLBBDDMNIP([In] EOFGJNJAJLP<GHBFIOLFDBB> FMPAALMFOIG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000465")]
	[Cpp2IlInjected.Address(RVA = "0x1F17F20", Offset = "0x1F16720", VA = "0x181F17F20")]
	private NOABPNGHFKH DPDMAAGMHMI([In] EOFGJNJAJLP<GHBFIOLFDBB> FMPAALMFOIG, LAMDOCKGMNE DDLCNKGIKEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000466")]
	[Cpp2IlInjected.Address(RVA = "0x1F17FF0", Offset = "0x1F167F0", VA = "0x181F17FF0")]
	public LAMDOCKGMNE? EEGIPLDKLNF([In] EOFGJNJAJLP<GHBFIOLFDBB> FMPAALMFOIG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000467")]
	[Cpp2IlInjected.Address(RVA = "0x1F16BC0", Offset = "0x1F153C0", VA = "0x181F16BC0")]
	public DIOAIIMAGGE? IEAJBIOGMEL([In] EOFGJNJAJLP<GPCAGFNHADK> IKNLCPDILAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000468")]
	[Cpp2IlInjected.Address(RVA = "0x1F190B0", Offset = "0x1F178B0", VA = "0x181F190B0", Slot = "14")]
	public IEnumerable<HIJBFILPINN> IBNBJMOFDIO(KPFGDODNFBO<GPCAGFNHADK> IKNLCPDILAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000469")]
	[Cpp2IlInjected.Address(RVA = "0x1F19CB0", Offset = "0x1F184B0", VA = "0x181F19CB0", Slot = "15")]
	public IEnumerable<MCODEGMJPBO> LFCOJFFMNCJ(KPFGDODNFBO<GPCAGFNHADK> IKNLCPDILAM, KPFGDODNFBO<FICFLFAPGGD> NBEKJKEDPBE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600046A")]
	[Cpp2IlInjected.Address(RVA = "0x1F16BF0", Offset = "0x1F153F0", VA = "0x181F16BF0", Slot = "16")]
	public IEnumerable<MCODEGMJPBO> BFNAJJFKHEJ(KPFGDODNFBO<GPCAGFNHADK> IKNLCPDILAM, KPFGDODNFBO<CNIDNALDCPF> OPNPBHOMMHD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600046B")]
	[Cpp2IlInjected.Address(RVA = "0x1F1A450", Offset = "0x1F18C50", VA = "0x181F1A450")]
	public KPFGDODNFBO<GPCAGFNHADK> NBFLKIPPNFB([In] EOFGJNJAJLP<GPCAGFNHADK> IKNLCPDILAM)
	{
		return default(KPFGDODNFBO<GPCAGFNHADK>);
	}

	[Cpp2IlInjected.Token(Token = "0x600046C")]
	[Cpp2IlInjected.Address(RVA = "0x1F188B0", Offset = "0x1F170B0", VA = "0x181F188B0")]
	public KPFGDODNFBO<GPCAGFNHADK>? GDDFAAOLBPL([In] EOFGJNJAJLP<GPCAGFNHADK> IKNLCPDILAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600046D")]
	[Cpp2IlInjected.Address(RVA = "0x1F19B30", Offset = "0x1F18330", VA = "0x181F19B30")]
	private KJEAHHMOGFO? KFGJFNADPCJ([In] EOFGJNJAJLP<GPCAGFNHADK> IKNLCPDILAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600046E")]
	[Cpp2IlInjected.Address(RVA = "0x1F16BC0", Offset = "0x1F153C0", VA = "0x181F16BC0")]
	private DIOAIIMAGGE? GKENDKKGGHJ([In] EOFGJNJAJLP<GPCAGFNHADK> IKNLCPDILAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600046F")]
	[Cpp2IlInjected.Address(RVA = "0x1F16A60", Offset = "0x1F15260", VA = "0x181F16A60", Slot = "23")]
	public EOFGJNJAJLP<GPCAGFNHADK> AJOOMCKGLKA(KPFGDODNFBO<GPCAGFNHADK> IKNLCPDILAM)
	{
		return default(EOFGJNJAJLP<GPCAGFNHADK>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000470")]
	[Cpp2IlInjected.Address(RVA = "0x1F1A040", Offset = "0x1F18840", VA = "0x181F1A040")]
	public KPFGDODNFBO<CNIDNALDCPF> MCMKHOALPFF(KPFGDODNFBO<GPCAGFNHADK> IKNLCPDILAM, KPFGDODNFBO<GHBFIOLFDBB> FMPAALMFOIG, int OHHOEGDMHEB)
	{
		return default(KPFGDODNFBO<CNIDNALDCPF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000471")]
	[Cpp2IlInjected.Address(RVA = "0x1F19450", Offset = "0x1F17C50", VA = "0x181F19450")]
	public KPFGDODNFBO<FICFLFAPGGD> IDMNEHDPIEK(KPFGDODNFBO<GPCAGFNHADK> IKNLCPDILAM, KPFGDODNFBO<GHBFIOLFDBB> FMPAALMFOIG, int JFOGABNIOHM)
	{
		return default(KPFGDODNFBO<FICFLFAPGGD>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000472")]
	[Cpp2IlInjected.Address(RVA = "0x1F1A0D0", Offset = "0x1F188D0", VA = "0x181F1A0D0", Slot = "20")]
	public IEnumerable<OLOFMDFDPDP> MFDMBHMMEFL(NGANAJKCJBN DHMPLGEOOMG, bool GFCJBBLNPDH, bool FDGJMKCOBJK, bool HNLPNJHDPNO, bool HIEPEEIHHFG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000473")]
	[Cpp2IlInjected.Address(RVA = "0x1F18B50", Offset = "0x1F17350", VA = "0x181F18B50", Slot = "21")]
	public OLOFMDFDPDP GMFGMKEEMJM(NGANAJKCJBN DHMPLGEOOMG, DCDFABOKGOA HLCFJLLLDNI, bool GFCJBBLNPDH, bool FDGJMKCOBJK, bool HNLPNJHDPNO, bool HIEPEEIHHFG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000474")]
	[Cpp2IlInjected.Address(RVA = "0x1F18560", Offset = "0x1F16D60", VA = "0x181F18560")]
	public HIJBFILPINN OFMDBHGOINE(KPFGDODNFBO<GPCAGFNHADK> IKNLCPDILAM, [In] MCODEGMJPBO PGAMEILHHEL)
	{
		return default(HIJBFILPINN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000475")]
	[Cpp2IlInjected.Address(RVA = "0x1F1A560", Offset = "0x1F18D60", VA = "0x181F1A560", Slot = "24")]
	public MCODEGMJPBO NNJCABMPLNN(KPFGDODNFBO<GPCAGFNHADK> IKNLCPDILAM, KPFGDODNFBO<FICFLFAPGGD> NBEKJKEDPBE, KPFGDODNFBO<CNIDNALDCPF> OPNPBHOMMHD)
	{
		return default(MCODEGMJPBO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000476")]
	[Cpp2IlInjected.Address(RVA = "0x1F18750", Offset = "0x1F16F50", VA = "0x181F18750", Slot = "25")]
	public bool FKCJNDCIOLB(KPFGDODNFBO<GPCAGFNHADK> IKNLCPDILAM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000477")]
	[Cpp2IlInjected.Address(RVA = "0x1F18A50", Offset = "0x1F17250", VA = "0x181F18A50", Slot = "26")]
	public bool GFHEJEJOANM(KPFGDODNFBO<GPCAGFNHADK> IKNLCPDILAM, KPFGDODNFBO<CNIDNALDCPF> CACIDFDKPBJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000478")]
	[Cpp2IlInjected.Address(RVA = "0x1F18AD0", Offset = "0x1F172D0", VA = "0x181F18AD0", Slot = "27")]
	public bool GLIKEDNCFNF(KPFGDODNFBO<GPCAGFNHADK> IKNLCPDILAM, KPFGDODNFBO<FICFLFAPGGD> CJCIDDLJNDI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000479")]
	[Cpp2IlInjected.Address(RVA = "0x1F17450", Offset = "0x1F15C50", VA = "0x181F17450")]
	public MEKCEIEFNPI<CJADAAFBGMJ.PKPEAAOIPCK, DCIBOGBGGHI> OBOHHHDMHDA([In] CJADAAFBGMJ.POJNDOMDGEC EKJLJLJONBC)
	{
		return default(MEKCEIEFNPI<CJADAAFBGMJ.PKPEAAOIPCK, DCIBOGBGGHI>);
	}

	[Cpp2IlInjected.Token(Token = "0x600047A")]
	[Cpp2IlInjected.Address(RVA = "0x1F16E70", Offset = "0x1F15670", VA = "0x181F16E70", Slot = "29")]
	[AsyncStateMachine(typeof(HDAADMKCCJH))]
	public Task<MEKCEIEFNPI<KNDENJDHONE, MNGIPKBLGNG>> BFPDNPPDKBJ(KPFGDODNFBO<GPCAGFNHADK> IKNLCPDILAM, KPFGDODNFBO<FICFLFAPGGD> NBEKJKEDPBE, KPFGDODNFBO<CNIDNALDCPF> OPNPBHOMMHD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600047B")]
	[Cpp2IlInjected.Address(RVA = "0x1F19740", Offset = "0x1F17F40", VA = "0x181F19740", Slot = "30")]
	public MEKCEIEFNPI<BIFCJNCAGFG, DCIBOGBGGHI> KCMEOJPPIBP(EOFGJNJAJLP<GPCAGFNHADK> IKNLCPDILAM, BIFCJNCAGFG OEMLHFGDPJN, FLOGLJPGMHF FADJHDBKJGF)
	{
		return default(MEKCEIEFNPI<BIFCJNCAGFG, DCIBOGBGGHI>);
	}

	[Cpp2IlInjected.Token(Token = "0x600047C")]
	[Cpp2IlInjected.Address(RVA = "0x1F19560", Offset = "0x1F17D60", VA = "0x181F19560", Slot = "31")]
	[AsyncStateMachine(typeof(AGELOHFGIKF))]
	public Task<MEKCEIEFNPI<KNDENJDHONE, MNGIPKBLGNG>> JCNOBHAKIBD(EOFGJNJAJLP<GPCAGFNHADK> IKNLCPDILAM, EOFGJNJAJLP<GHBFIOLFDBB> PDBBGNEMOAN, KPFGDODNFBO<PKDEPFAFNML> AHBLACEOAID, KPFGDODNFBO<LADMNJOONHG> CACIDFDKPBJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600047D")]
	[Cpp2IlInjected.Address(RVA = "0x1F18E50", Offset = "0x1F17650", VA = "0x181F18E50", Slot = "32")]
	[AsyncStateMachine(typeof(DIGLDNLHLLO))]
	public Task<MEKCEIEFNPI<KNDENJDHONE, MNGIPKBLGNG>> HAOHEKMCBND(EOFGJNJAJLP<GPCAGFNHADK> IKNLCPDILAM, EOFGJNJAJLP<GHBFIOLFDBB> OHACLBPPJOJ, KPFGDODNFBO<PKDEPFAFNML> GBKLAJANFDG, KPFGDODNFBO<BBEHFBIGKLK> CJCIDDLJNDI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600047E")]
	[Cpp2IlInjected.Address(RVA = "0x1F1A260", Offset = "0x1F18A60", VA = "0x181F1A260", Slot = "33")]
	public LNHNPDGEGNL MPCPKENFDAK(IEnumerable<FHCGEGKCGMN> FOLKBANEJNA)
	{
		return default(LNHNPDGEGNL);
	}

	[Cpp2IlInjected.Token(Token = "0x600047F")]
	[Cpp2IlInjected.Address(RVA = "0x1F18930", Offset = "0x1F17130", VA = "0x181F18930", Slot = "34")]
	public LNHNPDGEGNL GEJCCPOJEKC()
	{
		return default(LNHNPDGEGNL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000480")]
	[Cpp2IlInjected.Address(RVA = "0x1F17970", Offset = "0x1F16170", VA = "0x181F17970")]
	private IJHEHKLODEB CNENHMAFIJI(EGNELGNFODM EPBCFCEKFLM, KPFGDODNFBO<GPCAGFNHADK> MAOCFENGGHE, IEnumerable<EOFGJNJAJLP<GPCAGFNHADK>> AKKMJPINBIM, IEnumerable<EOFGJNJAJLP<GHBFIOLFDBB>> OHKDIKBGECO)
	{
		return default(IJHEHKLODEB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000481")]
	[Cpp2IlInjected.Address(RVA = "0x1F17630", Offset = "0x1F15E30", VA = "0x181F17630", Slot = "35")]
	public IJHEHKLODEB CNENHMAFIJI(EGNELGNFODM EPBCFCEKFLM, KPFGDODNFBO<GPCAGFNHADK> MAOCFENGGHE, IEnumerable<EOFGJNJAJLP<GHBFIOLFDBB>> OHKDIKBGECO, IEnumerable<FHCGEGKCGMN> FOLKBANEJNA)
	{
		return default(IJHEHKLODEB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000482")]
	[Cpp2IlInjected.Address(RVA = "0x1F17B20", Offset = "0x1F16320", VA = "0x181F17B20")]
	private static IEnumerable<EOFGJNJAJLP<GPCAGFNHADK>> DFGJFKFEEMK(IEnumerable<FHCGEGKCGMN> FOLKBANEJNA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000483")]
	[Cpp2IlInjected.Address(RVA = "0x1F16FA0", Offset = "0x1F157A0", VA = "0x181F16FA0")]
	private IEnumerable<EOFGJNJAJLP<GHBFIOLFDBB>> BNOKMAIDMCA(IEnumerable<FHCGEGKCGMN> FOLKBANEJNA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000484")]
	[Cpp2IlInjected.Address(RVA = "0x1F1A1D0", Offset = "0x1F189D0", VA = "0x181F1A1D0", Slot = "36")]
	public List<BMBGHHGNDNP> MICLABCPLBE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000485")]
	[Cpp2IlInjected.Address(RVA = "0x1F1ABD0", Offset = "0x1F193D0", VA = "0x181F1ABD0", Slot = "37")]
	public bool PDNODHNKNJL(KPFGDODNFBO<GPCAGFNHADK> IKNLCPDILAM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000486")]
	[Cpp2IlInjected.Address(RVA = "0x1F17570", Offset = "0x1F15D70", VA = "0x181F17570")]
	internal void CMIFDPFMKOK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000487")]
	[Cpp2IlInjected.Address(RVA = "0x1F175D0", Offset = "0x1F15DD0", VA = "0x181F175D0")]
	internal Task CNCLMIEMEAM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000488")]
	[Cpp2IlInjected.Address(RVA = "0x1F16A50", Offset = "0x1F15250", VA = "0x181F16A50", Slot = "6")]
	private bool AGDLDMENDEL(KPFGDODNFBO<GPCAGFNHADK> IKNLCPDILAM, [In] MCODEGMJPBO PGAMEILHHEL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000489")]
	[Cpp2IlInjected.Address(RVA = "0x1F16BC0", Offset = "0x1F153C0", VA = "0x181F16BC0", Slot = "9")]
	private DIOAIIMAGGE BFJJBJILLPN([In] EOFGJNJAJLP<GPCAGFNHADK> IKNLCPDILAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600048A")]
	[Cpp2IlInjected.Address(RVA = "0x1F1A450", Offset = "0x1F18C50", VA = "0x181F1A450", Slot = "10")]
	private KPFGDODNFBO<GPCAGFNHADK> PGILMPKBKKM([In] EOFGJNJAJLP<GPCAGFNHADK> IKNLCPDILAM)
	{
		return default(KPFGDODNFBO<GPCAGFNHADK>);
	}

	[Cpp2IlInjected.Token(Token = "0x600048B")]
	[Cpp2IlInjected.Address(RVA = "0x1F188B0", Offset = "0x1F170B0", VA = "0x181F188B0", Slot = "11")]
	private KPFGDODNFBO<GPCAGFNHADK>? MBDADOIBOKE([In] EOFGJNJAJLP<GPCAGFNHADK> IKNLCPDILAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600048C")]
	[Cpp2IlInjected.Address(RVA = "0x1F187C0", Offset = "0x1F16FC0", VA = "0x181F187C0", Slot = "12")]
	private NOABPNGHFKH FPPACGHFAJA([In] EOFGJNJAJLP<GHBFIOLFDBB> FMPAALMFOIG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600048D")]
	[Cpp2IlInjected.Address(RVA = "0x1F194E0", Offset = "0x1F17CE0", VA = "0x181F194E0", Slot = "13")]
	private KPFGDODNFBO<GHBFIOLFDBB> ONKMPLLCEKJ(KPFGDODNFBO<GPCAGFNHADK> IKNLCPDILAM, [In] EOFGJNJAJLP<GHBFIOLFDBB> BLLCNIIGJLD)
	{
		return default(KPFGDODNFBO<GHBFIOLFDBB>);
	}

	[Cpp2IlInjected.Token(Token = "0x600048E")]
	[Cpp2IlInjected.Address(RVA = "0x1F1ACC0", Offset = "0x1F194C0", VA = "0x181F1ACC0", Slot = "17")]
	private IEnumerable<NOABPNGHFKH> PFBJILIAAHB([In] EOFGJNJAJLP<GPCAGFNHADK> IKNLCPDILAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600048F")]
	[Cpp2IlInjected.Address(RVA = "0x1F18560", Offset = "0x1F16D60", VA = "0x181F18560", Slot = "22")]
	private HIJBFILPINN FECMGENIOCB(KPFGDODNFBO<GPCAGFNHADK> IKNLCPDILAM, [In] MCODEGMJPBO PGAMEILHHEL)
	{
		return default(HIJBFILPINN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000490")]
	[Cpp2IlInjected.Address(RVA = "0x1F17450", Offset = "0x1F15C50", VA = "0x181F17450", Slot = "28")]
	private MEKCEIEFNPI<CJADAAFBGMJ.PKPEAAOIPCK, DCIBOGBGGHI> BPJCJDGPPLE([In] CJADAAFBGMJ.POJNDOMDGEC EKJLJLJONBC)
	{
		return default(MEKCEIEFNPI<CJADAAFBGMJ.PKPEAAOIPCK, DCIBOGBGGHI>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000491")]
	[Cpp2IlInjected.Address(RVA = "0x1F17480", Offset = "0x1F15C80", VA = "0x181F17480")]
	[CompilerGenerated]
	private NOABPNGHFKH CFIIGFJIPHO(LAMDOCKGMNE JIAIKHGLBJE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000492")]
	[Cpp2IlInjected.Address(RVA = "0x1F186D0", Offset = "0x1F16ED0", VA = "0x181F186D0")]
	[CompilerGenerated]
	private FHDJELKEMGM FIEGHGOGLDC(PKOMODIBNOD JIAIKHGLBJE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000493")]
	[Cpp2IlInjected.Address(RVA = "0x1F184F0", Offset = "0x1F16CF0", VA = "0x181F184F0")]
	[CompilerGenerated]
	private LAMDOCKGMNE EMHDBKPMGFF(EOFGJNJAJLP<GHBFIOLFDBB> JIAIKHGLBJE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000494")]
	[Cpp2IlInjected.Address(RVA = "0x1F16B50", Offset = "0x1F15350", VA = "0x181F16B50")]
	[CompilerGenerated]
	private KJEAHHMOGFO BDHBGAAPFLL(EOFGJNJAJLP<GPCAGFNHADK> JIAIKHGLBJE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C2")]
public sealed class FHDJELKEMGM : OLOFMDFDPDP
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000C3")]
	[CompilerGenerated]
	private struct GIFELGGKFPL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400025E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400025F")]
		public AsyncTaskMethodBuilder<MEKCEIEFNPI<KPFGDODNFBO<GOLMGBIAPOO>, MNGIPKBLGNG>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000260")]
		public FHDJELKEMGM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000261")]
		public EOFGJNJAJLP<GPCAGFNHADK> graphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000262")]
		public EOFGJNJAJLP<GHBFIOLFDBB> nodeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000263")]
		public KPFGDODNFBO<PKDEPFAFNML> portGroupId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000264")]
		public string name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000265")]
		private TaskAwaiter<MEKCEIEFNPI<KPFGDODNFBO<GOLMGBIAPOO>, MNGIPKBLGNG>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004AA")]
		[Cpp2IlInjected.Address(RVA = "0x1F23470", Offset = "0x1F21C70", VA = "0x181F23470", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004AB")]
		[Cpp2IlInjected.Address(RVA = "0x1F236F0", Offset = "0x1F21EF0", VA = "0x181F236F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000C4")]
	[CompilerGenerated]
	private struct COLJOCLCKEH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000266")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000267")]
		public AsyncTaskMethodBuilder<MEKCEIEFNPI<KPFGDODNFBO<DBEENCOBDHN>, MNGIPKBLGNG>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000268")]
		public FHDJELKEMGM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000269")]
		public EOFGJNJAJLP<GPCAGFNHADK> graphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400026A")]
		public EOFGJNJAJLP<GHBFIOLFDBB> nodeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400026B")]
		public KPFGDODNFBO<PKDEPFAFNML> portGroupId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400026C")]
		public string name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400026D")]
		private TaskAwaiter<MEKCEIEFNPI<KPFGDODNFBO<DBEENCOBDHN>, MNGIPKBLGNG>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004AC")]
		[Cpp2IlInjected.Address(RVA = "0x1F22280", Offset = "0x1F20A80", VA = "0x181F22280", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004AD")]
		[Cpp2IlInjected.Address(RVA = "0x1F22500", Offset = "0x1F20D00", VA = "0x181F22500", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400025B")]
	private readonly PKOMODIBNOD FGNCPLHKIJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400025C")]
	private readonly NKLPINCAHPI CDMLJIFOEDL;

	[Cpp2IlInjected.Token(Token = "0x170000B4")]
	public TypeKey GGFHHAGLADA
	{
		[Cpp2IlInjected.Token(Token = "0x60004A5")]
		[Cpp2IlInjected.Address(RVA = "0x8B89F0", Offset = "0x8B71F0", VA = "0x1808B89F0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(TypeKey);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B5")]
	public string NFMECEPFBKM
	{
		[Cpp2IlInjected.Token(Token = "0x60004A6")]
		[Cpp2IlInjected.Address(RVA = "0x1F22920", Offset = "0x1F21120", VA = "0x181F22920", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B6")]
	public PKOMODIBNOD PCMKDPPMLOH
	{
		[Cpp2IlInjected.Token(Token = "0x60004A7")]
		[Cpp2IlInjected.Address(RVA = "0x846800", Offset = "0x845000", VA = "0x180846800")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004A4")]
	[Cpp2IlInjected.Address(RVA = "0x1F22AC0", Offset = "0x1F212C0", VA = "0x181F22AC0")]
	public FHDJELKEMGM(PKOMODIBNOD JPCNFDCDDOP, NKLPINCAHPI KGAENLAMAOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A8")]
	[Cpp2IlInjected.Address(RVA = "0x1F227B0", Offset = "0x1F20FB0", VA = "0x181F227B0", Slot = "6")]
	[AsyncStateMachine(typeof(GIFELGGKFPL))]
	public Task<MEKCEIEFNPI<KPFGDODNFBO<GOLMGBIAPOO>, MNGIPKBLGNG>> CPBLDGDPFKA(EOFGJNJAJLP<GPCAGFNHADK> IKNLCPDILAM, EOFGJNJAJLP<GHBFIOLFDBB> FMPAALMFOIG, KPFGDODNFBO<PKDEPFAFNML> KCJMKIMEENL, string GCDLMFGKKMH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004A9")]
	[Cpp2IlInjected.Address(RVA = "0x1F22950", Offset = "0x1F21150", VA = "0x181F22950", Slot = "7")]
	[AsyncStateMachine(typeof(COLJOCLCKEH))]
	public Task<MEKCEIEFNPI<KPFGDODNFBO<DBEENCOBDHN>, MNGIPKBLGNG>> LIIGPHEJFCN(EOFGJNJAJLP<GPCAGFNHADK> IKNLCPDILAM, EOFGJNJAJLP<GHBFIOLFDBB> FMPAALMFOIG, KPFGDODNFBO<PKDEPFAFNML> KCJMKIMEENL, string GCDLMFGKKMH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C5")]
public sealed class JOKLJJEPCLN : BJJMJNOAIGC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400026E")]
	private readonly PKOMODIBNOD LJGDFLKDFMH;

	[Cpp2IlInjected.Token(Token = "0x400026F")]
	private static readonly HashSet<PKOMODIBNOD> CCGJPPJGKPH;

	[Cpp2IlInjected.Token(Token = "0x4000270")]
	private static readonly HashSet<PKOMODIBNOD> CJJLMLNJPMH;

	[Cpp2IlInjected.Token(Token = "0x4000271")]
	private static readonly HashSet<PKOMODIBNOD> CHGFCPEKLCC;

	[Cpp2IlInjected.Token(Token = "0x170000B7")]
	public TypeKey PJOIFALPHGK
	{
		[Cpp2IlInjected.Token(Token = "0x60004AE")]
		[Cpp2IlInjected.Address(RVA = "0x1F253B0", Offset = "0x1F23BB0", VA = "0x181F253B0", Slot = "6")]
		get
		{
			return default(TypeKey);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B8")]
	public bool MEFAHOBFGHM
	{
		[Cpp2IlInjected.Token(Token = "0x60004AF")]
		[Cpp2IlInjected.Address(RVA = "0x1F253A0", Offset = "0x1F23BA0", VA = "0x181F253A0", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B9")]
	public bool DCMHLDEFEFB
	{
		[Cpp2IlInjected.Token(Token = "0x60004B3")]
		[Cpp2IlInjected.Address(RVA = "0x1F25400", Offset = "0x1F23C00", VA = "0x181F25400", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BA")]
	public bool MEAOLDFBNBK
	{
		[Cpp2IlInjected.Token(Token = "0x60004B4")]
		[Cpp2IlInjected.Address(RVA = "0x1F25320", Offset = "0x1F23B20", VA = "0x181F25320", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004B0")]
	[Cpp2IlInjected.Address(RVA = "0x1F24010", Offset = "0x1F22810", VA = "0x181F24010")]
	public bool IAKACANKKGG(string IPHHABIKCHD, [Out] OMFAIINJNJC BKEBPEFLNMI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004B1")]
	[Cpp2IlInjected.Address(RVA = "0x8468E0", Offset = "0x8450E0", VA = "0x1808468E0")]
	public JOKLJJEPCLN(PKOMODIBNOD LHMMDMHNIJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B2")]
	[Cpp2IlInjected.Address(RVA = "0x1F23E80", Offset = "0x1F22680", VA = "0x181F23E80")]
	internal static TypeKey CONFLGMEAJF(PKOMODIBNOD HKAKMPIMEOA)
	{
		return default(TypeKey);
	}

	[Cpp2IlInjected.Token(Token = "0x60004B5")]
	[Cpp2IlInjected.Address(RVA = "0x1F22920", Offset = "0x1F21120", VA = "0x181F22920", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000C6")]
public readonly struct HFBDJCMIPDG : CHGIKMOFLHD.CNDMEMJOEFP<FFPCMKOBEGP, KNDENJDHONE>
{
	[Cpp2IlInjected.Token(Token = "0x60004B7")]
	[Cpp2IlInjected.Address(RVA = "0x1F239A0", Offset = "0x1F221A0", VA = "0x181F239A0", Slot = "4")]
	public int CLFKLPPACHI(KNDENJDHONE NOFEINPOGPG, FFPCMKOBEGP BMOCGPMNBAF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60004B8")]
	[Cpp2IlInjected.Address(RVA = "0x1F23A50", Offset = "0x1F22250", VA = "0x181F23A50", Slot = "5")]
	public FFPCMKOBEGP KLABIHKIBIF(KNDENJDHONE NOFEINPOGPG, FFPCMKOBEGP BMOCGPMNBAF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004B9")]
	[Cpp2IlInjected.Address(RVA = "0x1F239C0", Offset = "0x1F221C0", VA = "0x181F239C0", Slot = "6")]
	public FFPCMKOBEGP DDCDNKBMAPM(KNDENJDHONE NOFEINPOGPG, FFPCMKOBEGP BMOCGPMNBAF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004BA")]
	[Cpp2IlInjected.Address(RVA = "0x1F23A10", Offset = "0x1F22210", VA = "0x181F23A10", Slot = "7")]
	public IReadOnlyList<FFPCMKOBEGP> HJHDFCEMEHD(KNDENJDHONE NOFEINPOGPG, FFPCMKOBEGP BMOCGPMNBAF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004BB")]
	[Cpp2IlInjected.Address(RVA = "0x1F23A60", Offset = "0x1F22260", VA = "0x181F23A60", Slot = "8")]
	public FFPCMKOBEGP[] KNDPFBFDFOE(KNDENJDHONE NOFEINPOGPG, FFPCMKOBEGP BMOCGPMNBAF, int BMJHLNEKCFG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004BC")]
	[Cpp2IlInjected.Address(RVA = "0x1F23A70", Offset = "0x1F22270", VA = "0x181F23A70", Slot = "9")]
	public bool NFAPKBBIFLJ(KNDENJDHONE NOFEINPOGPG, FFPCMKOBEGP BMOCGPMNBAF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004BD")]
	[Cpp2IlInjected.Address(RVA = "0x1F23A30", Offset = "0x1F22230", VA = "0x181F23A30", Slot = "10")]
	public bool JKDHAECINDP(KNDENJDHONE NOFEINPOGPG, FFPCMKOBEGP BMOCGPMNBAF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004BE")]
	[Cpp2IlInjected.Address(RVA = "0x1F23960", Offset = "0x1F22160", VA = "0x181F23960", Slot = "11")]
	public bool APOJIKCOKAF(KNDENJDHONE NOFEINPOGPG, FFPCMKOBEGP BMOCGPMNBAF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004BF")]
	[Cpp2IlInjected.Address(RVA = "0x1F23980", Offset = "0x1F22180", VA = "0x181F23980", Slot = "12")]
	public bool CDABCBJBDFE(KNDENJDHONE NOFEINPOGPG, FFPCMKOBEGP BMOCGPMNBAF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004C0")]
	[Cpp2IlInjected.Address(RVA = "0x1F23940", Offset = "0x1F22140", VA = "0x181F23940", Slot = "13")]
	public bool ALGJOBJOLGJ(KNDENJDHONE AFDJFGJJOLK, FFPCMKOBEGP BMOCGPMNBAF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004C1")]
	[Cpp2IlInjected.Address(RVA = "0x1F239F0", Offset = "0x1F221F0", VA = "0x181F239F0", Slot = "14")]
	public bool EJNIHPOKOFA(KNDENJDHONE NOFEINPOGPG, FFPCMKOBEGP BMOCGPMNBAF)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C7")]
public abstract class MKOCHPOCLFG : OGMIBBIPCFM
{
	[Cpp2IlInjected.Token(Token = "0x170000BB")]
	public OIFCMCHIANM.HDGPGICGCFD KFMECLOIHAO
	{
		[Cpp2IlInjected.Token(Token = "0x60004C2")]
		[Cpp2IlInjected.Address(RVA = "0x1F256E0", Offset = "0x1F23EE0", VA = "0x181F256E0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BC")]
	public abstract IBJGOCHMKAI.OHHNNMMCNCA HBMLOIGEJJB
	{
		[Cpp2IlInjected.Token(Token = "0x60004C3")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000BD")]
	public abstract BBIGJEMLFFM.NOGDCDBFNDC IHOPNGKMFPD
	{
		[Cpp2IlInjected.Token(Token = "0x60004C4")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000BE")]
	public abstract LDNILKFEDEA.KEECOHCBNJH FGIDILIELAP
	{
		[Cpp2IlInjected.Token(Token = "0x60004C5")]
		[Cpp2IlInjected.Address(Slot = "16")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000BF")]
	public OPEEJNJBEAD.OHFECBHGEAO<CCBMGFEGKNJ, FFPCMKOBEGP, BBIGJEMLFFM> IPJPFPGIAMB
	{
		[Cpp2IlInjected.Token(Token = "0x60004C6")]
		[Cpp2IlInjected.Address(RVA = "0x1F25690", Offset = "0x1F23E90", VA = "0x181F25690", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C0")]
	public abstract FKNKBHHKDOE IPPKMAKKFBL
	{
		[Cpp2IlInjected.Token(Token = "0x60004C7")]
		[Cpp2IlInjected.Address(Slot = "17")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000C1")]
	public abstract NKOOGGOBMFP BAIDJOBCIIM
	{
		[Cpp2IlInjected.Token(Token = "0x60004C8")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000C2")]
	public abstract GEMBKHHAPFB FNGKDEFCFOP
	{
		[Cpp2IlInjected.Token(Token = "0x60004C9")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000C3")]
	public abstract IBLIAIPNJAC JOALCJBIKOB
	{
		[Cpp2IlInjected.Token(Token = "0x60004CA")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000C4")]
	public abstract MDKCAMDLDFJ OIPNHIBICBM
	{
		[Cpp2IlInjected.Token(Token = "0x60004CB")]
		[Cpp2IlInjected.Address(Slot = "21")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60004CC")]
	[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
	protected MKOCHPOCLFG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C8")]
public sealed class OHJDMCKMACJ : AKEGCEKHDOL
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000C9")]
	[CompilerGenerated]
	private struct NOJHDHPNMLL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000273")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000274")]
		public AsyncTaskMethodBuilder<MEKCEIEFNPI<object, MNGIPKBLGNG>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000275")]
		public OHJDMCKMACJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000276")]
		public FFPCMKOBEGP action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000277")]
		public bool clearBufferedRpcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000278")]
		private TaskAwaiter<MEKCEIEFNPI<object, MNGIPKBLGNG>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004D0")]
		[Cpp2IlInjected.Address(RVA = "0x1F25730", Offset = "0x1F23F30", VA = "0x181F25730", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004D1")]
		[Cpp2IlInjected.Address(RVA = "0x1F259D0", Offset = "0x1F241D0", VA = "0x181F259D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000CA")]
	[CompilerGenerated]
	private struct IPJDAOKJEFD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000279")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400027A")]
		public AsyncTaskMethodBuilder<MEKCEIEFNPI<NHDCCNGJOAJ, MNGIPKBLGNG>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400027B")]
		public OHJDMCKMACJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400027C")]
		public IReadOnlyList<FFPCMKOBEGP> actions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400027D")]
		public bool clearBufferedRpcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400027E")]
		private TaskAwaiter<MEKCEIEFNPI<object, MNGIPKBLGNG>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004D2")]
		[Cpp2IlInjected.Address(RVA = "0x1F23A90", Offset = "0x1F22290", VA = "0x181F23A90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004D3")]
		[Cpp2IlInjected.Address(RVA = "0x1F23E10", Offset = "0x1F22610", VA = "0x181F23E10", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000272")]
	private readonly PFHKOKHNBAM MMBGMPGEOID;

	[Cpp2IlInjected.Token(Token = "0x60004CD")]
	[Cpp2IlInjected.Address(RVA = "0x8468E0", Offset = "0x8450E0", VA = "0x1808468E0")]
	public OHJDMCKMACJ(PFHKOKHNBAM CCFDAEFHGMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004CE")]
	[Cpp2IlInjected.Address(RVA = "0x1F25A40", Offset = "0x1F24240", VA = "0x181F25A40")]
	[AsyncStateMachine(typeof(NOJHDHPNMLL))]
	private Task<MEKCEIEFNPI<object, MNGIPKBLGNG>> BEMKHEPJCBL(FFPCMKOBEGP BMOCGPMNBAF, bool IFCNCLOFHHB = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004CF")]
	[Cpp2IlInjected.Address(RVA = "0x1F25B70", Offset = "0x1F24370", VA = "0x181F25B70", Slot = "4")]
	[AsyncStateMachine(typeof(IPJDAOKJEFD))]
	public Task<MEKCEIEFNPI<NHDCCNGJOAJ, MNGIPKBLGNG>> DHFIIPAKLLM(IReadOnlyList<FFPCMKOBEGP> GACINIPOCEF, bool IFCNCLOFHHB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CB")]
public struct MCBMHOCLAPA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400027F")]
	internal BCLKMBLKBBB<OFCGFGNGDLN, FFPCMKOBEGP, CPACFFIMLAM> LJGDFLKDFMH;

	[Cpp2IlInjected.Token(Token = "0x60004D4")]
	[Cpp2IlInjected.Address(RVA = "0x1EEBEE0", Offset = "0x1EEA6E0", VA = "0x181EEBEE0")]
	private MCBMHOCLAPA([In] BCLKMBLKBBB<OFCGFGNGDLN, FFPCMKOBEGP, CPACFFIMLAM> EBBBKHAFPDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D5")]
	[Cpp2IlInjected.Address(RVA = "0x1F25630", Offset = "0x1F23E30", VA = "0x181F25630")]
	public static MCBMHOCLAPA OJFFIHPLODM()
	{
		return default(MCBMHOCLAPA);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CC")]
public static class ADHGAACDIIN
{
	[Cpp2IlInjected.Token(Token = "0x60004D6")]
	[Cpp2IlInjected.Address(RVA = "0x8E2600", Offset = "0x8E0E00", VA = "0x1808E2600")]
	public static BCLKMBLKBBB<OFCGFGNGDLN, FFPCMKOBEGP, CPACFFIMLAM> NNHFKLOCKDB(this MCBMHOCLAPA EGJINJKGIAK)
	{
		return default(BCLKMBLKBBB<OFCGFGNGDLN, FFPCMKOBEGP, CPACFFIMLAM>);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000CD")]
public struct CPACFFIMLAM : KBKNGFMIHBJ.EFJFCPNHLMA<OFCGFGNGDLN, FFPCMKOBEGP>
{
	[Cpp2IlInjected.Token(Token = "0x60004D7")]
	[Cpp2IlInjected.Address(RVA = "0x1F22570", Offset = "0x1F20D70", VA = "0x181F22570", Slot = "5")]
	public FFPCMKOBEGP LHNKINMGCEI(OFCGFGNGDLN[] CBIGELEDANN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004D8")]
	[Cpp2IlInjected.Address(RVA = "0x154BCE0", Offset = "0x154A4E0", VA = "0x18154BCE0")]
	public int IPKJLBNEIMP([In] OFCGFGNGDLN PEDFGKDGNBE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60004D9")]
	[Cpp2IlInjected.Address(RVA = "0x154BCE0", Offset = "0x154A4E0", VA = "0x18154BCE0", Slot = "4")]
	private int BCMEMBIJEPA([In] OFCGFGNGDLN FOJJEODKFKL)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CF")]
public struct DIDEKHLIKHD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000282")]
	internal FDBIHECNLKD<DODMAHJEIFG, FFPCMKOBEGP, HCKFBPPOFMK> LJGDFLKDFMH;

	[Cpp2IlInjected.Token(Token = "0x60004DD")]
	[Cpp2IlInjected.Address(RVA = "0x1EEBEE0", Offset = "0x1EEA6E0", VA = "0x181EEBEE0")]
	private DIDEKHLIKHD([In] FDBIHECNLKD<DODMAHJEIFG, FFPCMKOBEGP, HCKFBPPOFMK> CLIFHKHDNII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004DE")]
	[Cpp2IlInjected.Address(RVA = "0x1F22750", Offset = "0x1F20F50", VA = "0x181F22750")]
	public static DIDEKHLIKHD OJFFIHPLODM()
	{
		return default(DIDEKHLIKHD);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D0")]
public static class ODFKOGHDCEA
{
	[Cpp2IlInjected.Token(Token = "0x60004DF")]
	[Cpp2IlInjected.Address(RVA = "0x8E2600", Offset = "0x8E0E00", VA = "0x1808E2600")]
	public static FDBIHECNLKD<DODMAHJEIFG, FFPCMKOBEGP, HCKFBPPOFMK> NNHFKLOCKDB(this DIDEKHLIKHD EGJINJKGIAK)
	{
		return default(FDBIHECNLKD<DODMAHJEIFG, FFPCMKOBEGP, HCKFBPPOFMK>);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000D1")]
public struct HCKFBPPOFMK : CECLJKAAPLF.FBEBCEGOADC<DODMAHJEIFG, FFPCMKOBEGP>
{
	[Cpp2IlInjected.Token(Token = "0x60004E0")]
	[Cpp2IlInjected.Address(RVA = "0x154BCE0", Offset = "0x154A4E0", VA = "0x18154BCE0")]
	public int NFAOLGAPGGL([In] DODMAHJEIFG PEDFGKDGNBE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60004E1")]
	[Cpp2IlInjected.Address(RVA = "0x1F23760", Offset = "0x1F21F60", VA = "0x181F23760", Slot = "5")]
	public FFPCMKOBEGP EOOAGFPJADI(DODMAHJEIFG[] ODLNFHJAJKH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E2")]
	[Cpp2IlInjected.Address(RVA = "0x154BCE0", Offset = "0x154A4E0", VA = "0x18154BCE0", Slot = "4")]
	private int CCBFHNGJNMM([In] DODMAHJEIFG PEDFGKDGNBE)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D3")]
public interface FKNKBHHKDOE
{
	[Cpp2IlInjected.Token(Token = "0x60004E6")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool IJNBBPALEIJ([In] MEKCEIEFNPI<KNDENJDHONE, DCIBOGBGGHI> KKBKNCNBBJP);
}
[Cpp2IlInjected.Token(Token = "0x20000D4")]
public static class NFEOGFPKLBP
{
	[Cpp2IlInjected.Token(Token = "0x60004E7")]
	[Cpp2IlInjected.Address(RVA = "0x2BD8B60", Offset = "0x2BD7360", VA = "0x182BD8B60")]
	public static bool IJNBBPALEIJ<TOk, TErr>(this FKNKBHHKDOE EGJINJKGIAK, [In] MEKCEIEFNPI<TOk, TErr> KKBKNCNBBJP) where TOk : notnull where TErr : notnull, DCIBOGBGGHI
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D5")]
public interface NKOOGGOBMFP
{
	[Cpp2IlInjected.Token(Token = "0x170000C5")]
	DEMIGMEKPCO OCEGOFHDNGP
	{
		[Cpp2IlInjected.Token(Token = "0x60004E8")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D6")]
public interface GEMBKHHAPFB
{
	[Cpp2IlInjected.Token(Token = "0x60004E9")]
	[Cpp2IlInjected.Address(Slot = "0")]
	HLAHBLIOIOJ IFPBNHGJEOK(int JFFEGGOHLCG);
}
[Cpp2IlInjected.Token(Token = "0x20000D7")]
public interface AHHEOGAANCH
{
	[Cpp2IlInjected.Token(Token = "0x170000C6")]
	string HMPIIAILGKB
	{
		[Cpp2IlInjected.Token(Token = "0x60004EA")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D8")]
public interface MHIMMGEHFEG
{
	[Cpp2IlInjected.Token(Token = "0x60004EB")]
	[Cpp2IlInjected.Address(Slot = "0")]
	AEDDEFDJFGF? HPLNMBINOIF(KPFGDODNFBO<PKDEPFAFNML> KCJMKIMEENL);
}
[Cpp2IlInjected.Token(Token = "0x20000D9")]
public interface PBNJCDMHFFB
{
	[Cpp2IlInjected.Token(Token = "0x170000C7")]
	string HMPIIAILGKB
	{
		[Cpp2IlInjected.Token(Token = "0x60004EC")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DA")]
public interface AEDDEFDJFGF
{
	[Cpp2IlInjected.Token(Token = "0x170000C8")]
	string HMPIIAILGKB
	{
		[Cpp2IlInjected.Token(Token = "0x60004ED")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60004EE")]
	[Cpp2IlInjected.Address(Slot = "1")]
	PBNJCDMHFFB? KGDDADPEIKL(KPFGDODNFBO<GOLMGBIAPOO> EFMFHDBJLDJ);

	[Cpp2IlInjected.Token(Token = "0x60004EF")]
	[Cpp2IlInjected.Address(Slot = "2")]
	AHHEOGAANCH? MNNNNMJDOJO(KPFGDODNFBO<DBEENCOBDHN> FGHCEPLGCAD);
}
[Cpp2IlInjected.Token(Token = "0x20000DB")]
public interface IBLIAIPNJAC
{
	[Cpp2IlInjected.Token(Token = "0x60004F0")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<bool> HNOJCEHOGJJ(string IPHHABIKCHD, string BHFMOMNKABO);
}
[Cpp2IlInjected.Token(Token = "0x20000DC")]
public interface MDKCAMDLDFJ
{
	[Cpp2IlInjected.Token(Token = "0x60004F1")]
	[Cpp2IlInjected.Address(Slot = "0")]
	MHIMMGEHFEG? ANMGLEAICKB([In] EOFGJNJAJLP<HACDMEHACNO> CCLNLBGLPDP);
}
[Cpp2IlInjected.Token(Token = "0x20000DD")]
public sealed class GCAECFPFFJB
{
	[Cpp2IlInjected.Token(Token = "0x20000DE")]
	private struct KFKJNJGABCH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000288")]
		public int CFDBFCCMKIM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000289")]
		public EALEPKELLAJ? FPMDJKOKNMO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400028A")]
		public EALEPKELLAJ? HMNJJKJLMPH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400028B")]
		public readonly List<FFPCMKOBEGP> GCOMCMPDCAB;

		[Cpp2IlInjected.Token(Token = "0x60004FA")]
		[Cpp2IlInjected.Address(RVA = "0x1F255E0", Offset = "0x1F23DE0", VA = "0x181F255E0")]
		private KFKJNJGABCH(int JBDLDJOINOF, EALEPKELLAJ? MHMCGMCHLMA, EALEPKELLAJ? BCMCJEBILPE, List<FFPCMKOBEGP> GACINIPOCEF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004FB")]
		[Cpp2IlInjected.Address(RVA = "0x1F25520", Offset = "0x1F23D20", VA = "0x181F25520")]
		public static KFKJNJGABCH OJFFIHPLODM()
		{
			return default(KFKJNJGABCH);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000287")]
	private readonly MOCDJGEDIGE<KFKJNJGABCH> BDDGKEDKCPB;

	[Cpp2IlInjected.Token(Token = "0x170000C9")]
	public static GCAECFPFFJB DCEJKJKKEPJ
	{
		[Cpp2IlInjected.Token(Token = "0x60004F2")]
		[Cpp2IlInjected.Address(RVA = "0x1F22EC0", Offset = "0x1F216C0", VA = "0x181F22EC0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CA")]
	public bool NGGIMPCGDOJ
	{
		[Cpp2IlInjected.Token(Token = "0x60004F3")]
		[Cpp2IlInjected.Address(RVA = "0x895EE0", Offset = "0x8946E0", VA = "0x180895EE0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60004F4")]
		[Cpp2IlInjected.Address(RVA = "0x981410", Offset = "0x97FC10", VA = "0x180981410")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004F5")]
	[Cpp2IlInjected.Address(RVA = "0x1F23200", Offset = "0x1F21A00", VA = "0x181F23200")]
	public void PGJIJEKNDMH(LODDICAHKEA BCMCJEBILPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F6")]
	[Cpp2IlInjected.Address(RVA = "0x1F22F10", Offset = "0x1F21710", VA = "0x181F22F10")]
	public void OENBNMPBOMN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F7")]
	[Cpp2IlInjected.Address(RVA = "0x1F22B60", Offset = "0x1F21360", VA = "0x181F22B60")]
	private static string? GLKFPPKOCBC([In] KFKJNJGABCH FFLOIOBGPGD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F8")]
	[Cpp2IlInjected.Address(RVA = "0x1F233C0", Offset = "0x1F21BC0", VA = "0x181F233C0")]
	public GCAECFPFFJB()
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
