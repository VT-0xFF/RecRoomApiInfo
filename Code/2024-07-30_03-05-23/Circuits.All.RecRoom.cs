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
		[Cpp2IlInjected.Address(RVA = "0x890970", Offset = "0x88EF70", VA = "0x180890970")]
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
		[Cpp2IlInjected.Address(RVA = "0x1FC0000", Offset = "0x1FBE600", VA = "0x181FC0000")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x8917F0", Offset = "0x88FDF0", VA = "0x1808917F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x891830", Offset = "0x88FE30", VA = "0x180891830")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public sealed class PJNMBNAHIFL : IDisposable, NBEFODDOPGK, MHOLLOLDLAB, JOABBEEONEI, BJOCNHKJCEG
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public abstract class EJECJGGLGIG : JAIGKHDFLIN
	{
		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public abstract int GFDDCFMPJHA
		{
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(Slot = "10")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x1FACE10", Offset = "0x1FAB410", VA = "0x181FACE10", Slot = "5")]
		public PKEFOPMHOCD GBOHCEJCMNN(BAAJHLLICGI.AKCICGNFDEE BPGHBBHBELB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(Slot = "11")]
		public abstract void NDILFJHHICG();

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(Slot = "12")]
		public abstract void FFBAGFOCOCN();

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x1FACDD0", Offset = "0x1FAB3D0", VA = "0x181FACDD0", Slot = "13")]
		public virtual void GAGHMKLMHJA(PJNMBNAHIFL ALELNINOAGK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x1FACF60", Offset = "0x1FAB560", VA = "0x181FACF60", Slot = "14")]
		public virtual void MIAFMEBANBD(PJNMBNAHIFL ALELNINOAGK, EIJGBFLAMII PEMICEIPPPL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x86C4B0", Offset = "0x86AAB0", VA = "0x18086C4B0")]
		protected EJECJGGLGIG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public interface JAIGKHDFLIN
	{
		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		int GFDDCFMPJHA
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(Slot = "1")]
		PKEFOPMHOCD GBOHCEJCMNN(BAAJHLLICGI.AKCICGNFDEE BPGHBBHBELB);

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void NDILFJHHICG();

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void FFBAGFOCOCN();

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void GAGHMKLMHJA(PJNMBNAHIFL ALELNINOAGK);

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void MIAFMEBANBD(PJNMBNAHIFL ALELNINOAGK, EIJGBFLAMII PEMICEIPPPL);
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	private readonly struct DGMNGAFFABC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public readonly DALDOBJLHKC<LKJBELODGDI, EIJGBFLAMII, PJNMBNAHIFL, JJGBIGJGLEO.DCMFKDFHIDD<LKJBELODGDI, EIJGBFLAMII, PJNMBNAHIFL>> FFCIBIMIEJM;

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x1FABA70", Offset = "0x1FAA070", VA = "0x181FABA70")]
		internal DGMNGAFFABC(DALDOBJLHKC<LKJBELODGDI, EIJGBFLAMII, PJNMBNAHIFL, JJGBIGJGLEO.DCMFKDFHIDD<LKJBELODGDI, EIJGBFLAMII, PJNMBNAHIFL>> AKLCDEBLEOF)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public sealed class BEBGAGLBDJI : JJGBIGJGLEO.DCMFKDFHIDD<LKJBELODGDI, EIJGBFLAMII, PJNMBNAHIFL>
	{
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public static readonly BEBGAGLBDJI CFNNMJAMDBB;

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x86C4B0", Offset = "0x86AAB0", VA = "0x18086C4B0")]
		private BEBGAGLBDJI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0xB928B0", Offset = "0xB90EB0", VA = "0x180B928B0", Slot = "4")]
		public LKJBELODGDI FPOPJGIPLPD(EIJGBFLAMII HLIDMKMINHN)
		{
			return default(LKJBELODGDI);
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x1FA9880", Offset = "0x1FA7E80", VA = "0x181FA9880", Slot = "5")]
		public void GAGHMKLMHJA(PJNMBNAHIFL OPJBDKMKMOF, EIJGBFLAMII PEMICEIPPPL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x1FA9990", Offset = "0x1FA7F90", VA = "0x181FA9990", Slot = "6")]
		public void MIAFMEBANBD(PJNMBNAHIFL OPJBDKMKMOF, EIJGBFLAMII PEMICEIPPPL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000A")]
	private struct PEAMCKFCBCC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public LCNOMMPGMCL<LKJBELODGDI, EIJGBFLAMII, PJNMBNAHIFL, JJGBIGJGLEO.DCMFKDFHIDD<LKJBELODGDI, EIJGBFLAMII, PJNMBNAHIFL>> FFCIBIMIEJM;

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x1FC35A0", Offset = "0x1FC1BA0", VA = "0x181FC35A0")]
		internal PEAMCKFCBCC(LCNOMMPGMCL<LKJBELODGDI, EIJGBFLAMII, PJNMBNAHIFL, JJGBIGJGLEO.DCMFKDFHIDD<LKJBELODGDI, EIJGBFLAMII, PJNMBNAHIFL>> AKLCDEBLEOF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x1FC3550", Offset = "0x1FC1B50", VA = "0x181FC3550")]
		public static PEAMCKFCBCC ENFOKLPNHAF()
		{
			return default(PEAMCKFCBCC);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public readonly struct BGANCKHFDEG : KLDPKNMOOBM.MHEKMDGDJBP<EIJGBFLAMII, PJNMBNAHIFL>
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200000C")]
		[CompilerGenerated]
		private struct MBCNJFFADOK : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public AsyncTaskMethodBuilder<CBDPDIPONCF<object, FBDDJIHDMAI>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			public PJNMBNAHIFL receiver;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public EIJGBFLAMII action;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			public BGANCKHFDEG <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			private TaskAwaiter<CBDPDIPONCF<object, FBDDJIHDMAI>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x1FBD060", Offset = "0x1FBB660", VA = "0x181FBD060", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x1FBD240", Offset = "0x1FBB840", VA = "0x181FBD240", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x90D070", Offset = "0x90B670", VA = "0x18090D070", Slot = "4")]
		public CGBGMGFBCKF<LCNEPMDCCCO> DHGDPFDPCLM(PJNMBNAHIFL DOCMHCDNIBE)
		{
			return default(CGBGMGFBCKF<LCNEPMDCCCO>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x1FA9B20", Offset = "0x1FA8120", VA = "0x181FA9B20", Slot = "5")]
		[AsyncStateMachine(typeof(MBCNJFFADOK))]
		public Task<CBDPDIPONCF<object, FBDDJIHDMAI>> DKJMJKFDAJG(PJNMBNAHIFL DOCMHCDNIBE, EIJGBFLAMII PEMICEIPPPL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x1FA9C50", Offset = "0x1FA8250", VA = "0x181FA9C50", Slot = "6")]
		public EIJGBFLAMII[] KHBMNFAHNMD(PJNMBNAHIFL DOCMHCDNIBE)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private struct BNJLDONHJHM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public AsyncTaskMethodBuilder<CBDPDIPONCF<bool, FBDDJIHDMAI>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public PJNMBNAHIFL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public EHHGJCHGBMN rootData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public JJBCGHIHKLB circuitRootData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		public IOHGNKJIFDJ superRoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private TaskAwaiter<CBDPDIPONCF<bool, FBDDJIHDMAI>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x1FAAB60", Offset = "0x1FA9160", VA = "0x181FAAB60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x1FAADE0", Offset = "0x1FA93E0", VA = "0x181FAADE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private struct IAIOEBHJMHG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public AsyncTaskMethodBuilder<CBDPDIPONCF<bool, FBDDJIHDMAI>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public PJNMBNAHIFL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private TaskAwaiter<CBDPDIPONCF<bool, FBDDJIHDMAI>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x1FB8CE0", Offset = "0x1FB72E0", VA = "0x181FB8CE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x1FB8F70", Offset = "0x1FB7570", VA = "0x181FB8F70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[CompilerGenerated]
	private struct AJPCDFIIEPC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		public AsyncTaskMethodBuilder<CBDPDIPONCF<COKMANPFJNC, FBDDJIHDMAI>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		public PJNMBNAHIFL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private TaskAwaiter<CBDPDIPONCF<COKMANPFJNC, FBDDJIHDMAI>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x1FA8380", Offset = "0x1FA6980", VA = "0x181FA8380", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x1FA8560", Offset = "0x1FA6B60", VA = "0x181FA8560", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	private struct LCNJOCIAPML : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		public AsyncTaskMethodBuilder<CBDPDIPONCF<object, FBDDJIHDMAI>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		public PJNMBNAHIFL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		public EIJGBFLAMII action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private TaskAwaiter<CBDPDIPONCF<object, FBDDJIHDMAI>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x1FBCA20", Offset = "0x1FBB020", VA = "0x181FBCA20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x1FBCC10", Offset = "0x1FBB210", VA = "0x181FBCC10", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[CompilerGenerated]
	private struct OPPAHNPMIEM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public AsyncTaskMethodBuilder<CBDPDIPONCF<COKMANPFJNC, FBDDJIHDMAI>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public PJNMBNAHIFL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public Guid rootGraphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private TaskAwaiter<CBDPDIPONCF<COKMANPFJNC, FBDDJIHDMAI>> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private TaskAwaiter<CBDPDIPONCF<bool, FBDDJIHDMAI>> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x1FC02A0", Offset = "0x1FBE8A0", VA = "0x181FC02A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x1FC0A90", Offset = "0x1FBF090", VA = "0x181FC0A90", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private readonly CGBGMGFBCKF<LCNEPMDCCCO> JAENDPCMCHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly DGMNGAFFABC PJJPJNCNNFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly EDBAHDNNLHP GDJKFLHHIPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	internal readonly GPIDEHKKBIM JHCKKBBKPKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18D0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	internal readonly BGCMFBBEEPB FCPKMHCJPEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18D8")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	internal readonly DDBLDNMCNDP.FLJKNKJLDDG GMBJEKJAJGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18F8")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	internal readonly BGMBFJEEEEO EDCLHCHOFPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1900")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	internal readonly DCMAMDMEEGH JPAGNGHDDLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1908")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	internal readonly BHNDPHMKPDJ MNIEMFOBCOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1910")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	internal readonly MMGFHDPCBNM FPAILGAGEJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1918")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private PMNMAGINNBI HBMJGALKODB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1928")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private HEMEDIGGNCJ BGJAKFDCFDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1948")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	internal readonly EDBAHDNNLHP.OHLMNOAEDCB EDIAGKPBKPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1950")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	internal readonly HEDIHINCIPG DCFLJLJEKFJ;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public EDBAHDNNLHP CDJIAIPNJHP
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x1FC4550", Offset = "0x1FC2B50", VA = "0x181FC4550")]
		get
		{
			return default(EDBAHDNNLHP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	internal JAIGKHDFLIN LGDNANMLOEN
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x1FC3F20", Offset = "0x1FC2520", VA = "0x181FC3F20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	internal PKEFOPMHOCD KEHEDMDHAPN
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x1FC4670", Offset = "0x1FC2C70", VA = "0x181FC4670")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x1FC4060", Offset = "0x1FC2660", VA = "0x181FC4060")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	internal bool ADNHKDCFBHB
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x1FC3800", Offset = "0x1FC1E00", VA = "0x181FC3800")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x1FC4080", Offset = "0x1FC2680", VA = "0x181FC4080")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public HJBDOOOBICO DPMBBKNAEEM
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x1FC4DA0", Offset = "0x1FC33A0", VA = "0x181FC4DA0", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public ENMHNBHKDNK GLNDNOHNHBE
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x1FC4DB0", Offset = "0x1FC33B0", VA = "0x181FC4DB0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public FEHAEHGEOOA HKHLDGOIAAD
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x1FC4DD0", Offset = "0x1FC33D0", VA = "0x181FC4DD0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public KGOGOKBEBFG EDPAEDMMFBJ
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x1FC4DC0", Offset = "0x1FC33C0", VA = "0x181FC4DC0", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public DDBLDNMCNDP? KHJKLDCJFLC
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x1FC3EA0", Offset = "0x1FC24A0", VA = "0x181FC3EA0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	private AJNGKLOBPDA? MBEONONLDCF
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x1FC4420", Offset = "0x1FC2A20", VA = "0x181FC4420", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x1FC4AA0", Offset = "0x1FC30A0", VA = "0x181FC4AA0")]
	private PJNMBNAHIFL(BGCMFBBEEPB OPDBIHNNONK, CGBGMGFBCKF<LCNEPMDCCCO> FFHBHOMFFND, [In] DGMNGAFFABC FHKHJGNEEJI, [In] EDBAHDNNLHP KKCNEBNFMMC, [In] GPIDEHKKBIM ONPCEPCDANC, PKEFOPMHOCD BBPFLBEOAOO, [In] DDBLDNMCNDP.FLJKNKJLDDG GGIBIPANPJC, EDBAHDNNLHP.OHLMNOAEDCB HJEGMIACBJO, HEDIHINCIPG NJKJPOIPGEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x1FC3D60", Offset = "0x1FC2360", VA = "0x181FC3D60")]
	public static PJNMBNAHIFL ENFOKLPNHAF(BGCMFBBEEPB BPGHBBHBELB, [In] HFPLGFBJJOJ FLBLEAPFCLH, CEBHFKPMBIP AGFGFJNOOKN, [In] MIAMHIPAJAL KANBOOIANBP, IDHONDANLPB OFJJANJELOC, CGBGMGFBCKF<LCNEPMDCCCO> FFHBHOMFFND, CGBGMGFBCKF<OGENPBGBOIO> KFBLKDNHEMD, PLCHFMGPMPF LGGGFEEKDDL, PBKJPNMGEIH PLLBIDFPAID)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x1FC3A80", Offset = "0x1FC2080", VA = "0x181FC3A80")]
	public static PJNMBNAHIFL ENFOKLPNHAF(BGCMFBBEEPB OPDBIHNNONK, [In] EDBAHDNNLHP KKCNEBNFMMC, [In] GPIDEHKKBIM ONPCEPCDANC, CGBGMGFBCKF<LCNEPMDCCCO> FFHBHOMFFND, CGBGMGFBCKF<OGENPBGBOIO> KFBLKDNHEMD, PLCHFMGPMPF LGGGFEEKDDL, PBKJPNMGEIH PLLBIDFPAID)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x1FC3810", Offset = "0x1FC1E10", VA = "0x181FC3810", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x1FC3630", Offset = "0x1FC1C30", VA = "0x181FC3630")]
	[AsyncStateMachine(typeof(BNJLDONHJHM))]
	internal Task<CBDPDIPONCF<bool, FBDDJIHDMAI>> CHMKFJOCCKD(EHHGJCHGBMN GEIBOHFEECI, JJBCGHIHKLB OMJCIEDKBFM, IOHGNKJIFDJ KNMFEIKCDGI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x1FC3F70", Offset = "0x1FC2570", VA = "0x181FC3F70")]
	[AsyncStateMachine(typeof(IAIOEBHJMHG))]
	public Task<CBDPDIPONCF<bool, FBDDJIHDMAI>> JCJOBLANLFG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x1FC4680", Offset = "0x1FC2C80", VA = "0x181FC4680")]
	[AsyncStateMachine(typeof(AJPCDFIIEPC))]
	public Task<CBDPDIPONCF<COKMANPFJNC, FBDDJIHDMAI>> MHKAAIMMAEL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x1FC4890", Offset = "0x1FC2E90", VA = "0x181FC4890")]
	internal void PNKDBACLCPG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x1FC3A00", Offset = "0x1FC2000", VA = "0x181FC3A00")]
	internal MADCGGOAHGO<EIJGBFLAMII> EHHFOKBNMKJ([In] NCJCIPAFOLM CIGLCCECCGH)
	{
		return default(MADCGGOAHGO<EIJGBFLAMII>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x1FC3790", Offset = "0x1FC1D90", VA = "0x181FC3790")]
	internal bool DDFCIDFKEEE([In] NCJCIPAFOLM CIGLCCECCGH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x1FC35B0", Offset = "0x1FC1BB0", VA = "0x181FC35B0")]
	internal MADCGGOAHGO<EIJGBFLAMII> ABIJJKENBOI([In] JFDDIOGFCLI JDOHBODLILC)
	{
		return default(MADCGGOAHGO<EIJGBFLAMII>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x1FC4560", Offset = "0x1FC2B60", VA = "0x181FC4560")]
	[AsyncStateMachine(typeof(LCNJOCIAPML))]
	internal Task<CBDPDIPONCF<object, FBDDJIHDMAI>> LPKEJCOBKEB(EIJGBFLAMII PEMICEIPPPL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x1FC4090", Offset = "0x1FC2690", VA = "0x181FC4090")]
	private EIJGBFLAMII[] KHBMNFAHNMD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x1FC4770", Offset = "0x1FC2D70", VA = "0x181FC4770")]
	[AsyncStateMachine(typeof(OPPAHNPMIEM))]
	public Task<CBDPDIPONCF<COKMANPFJNC, FBDDJIHDMAI>> NHABNBFJJKB(Guid KFDLPDMPHDH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public static class NNGDANJNMOK
{
	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x2CDA450", Offset = "0x2CD8A50", VA = "0x182CDA450")]
	public static HEEKAEOMLAP<(TPrev?, PJNMBNAHIFL?), AJNGKLOBPDA> JDPLKEHEOFL<TPrev>([In] this HEEKAEOMLAP<TPrev, PJNMBNAHIFL> HLIDMKMINHN)
	{
		return default(HEEKAEOMLAP<(TPrev, PJNMBNAHIFL), AJNGKLOBPDA>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x2CDA230", Offset = "0x2CD8830", VA = "0x182CDA230")]
	public static HEEKAEOMLAP<TPrev?, PJNMBNAHIFL?> AFFKEGLODCD<TPrev>([In] this HEEKAEOMLAP<TPrev, PJNMBNAHIFL> HLIDMKMINHN)
	{
		return default(HEEKAEOMLAP<TPrev, PJNMBNAHIFL>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public sealed class EGFEOBNANHG<TData> : PJDAENIABGC, MFOECDNIOPO, GJMJCOBOHDO where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly HBIPEINCKFG<JBMJEMLAFJB>? EBBLPFLDIGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public readonly string NGFLOAALGEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public readonly TData GDPGJFHLHOH;

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public HBIPEINCKFG<JBMJEMLAFJB>? NIACKMJNKIF
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x21E16B0", Offset = "0x21DFCB0", VA = "0x1821E16B0", Slot = "13")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x8736F0", Offset = "0x871CF0", VA = "0x1808736F0", Slot = "7")]
	public override string AFLHKEIDPKB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x38652A0", Offset = "0x38638A0", VA = "0x1838652A0")]
	internal EGFEOBNANHG([In] HBIPEINCKFG<JBMJEMLAFJB>? OGICAKBPCHC, CGBGMGFBCKF<HECEFCAIFNP>? MKMIELCJKNF, IOKind? ANGPIOCMAFI, string ELIMFPDKMPD, [In] TData MMDLBEBNCGC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public static class DCEOANCPKIF
{
	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x1FAB4F0", Offset = "0x1FA9AF0", VA = "0x181FAB4F0")]
	public static CBDPDIPONCF<MMEFBPFPPPD, MFOECDNIOPO> EPEOCNIGHKB([In] this EOHHDAEKEKM<LLKPOGOPLPB> DBPDDNONJJA)
	{
		return default(CBDPDIPONCF<MMEFBPFPPPD, MFOECDNIOPO>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x29E5D60", Offset = "0x29E4360", VA = "0x1829E5D60")]
	public static CBDPDIPONCF<TOk, MFOECDNIOPO> ANGMHICLLJE<TOk>([In] this CBDPDIPONCF<TOk, MFOECDNIOPO> HLIDMKMINHN, [In] HBIPEINCKFG<JBMJEMLAFJB>? OGICAKBPCHC, CGBGMGFBCKF<HECEFCAIFNP>? MKMIELCJKNF, IOKind? ANGPIOCMAFI, string ELIMFPDKMPD) where TOk : notnull
	{
		return default(CBDPDIPONCF<TOk, MFOECDNIOPO>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public interface BGCMFBBEEPB
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	ALAEJLFBHLG.KMKANABDJKK IHGPAMGJADL
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	BAAJHLLICGI.AKCICGNFDEE FJDJMFHKOBK
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	PJNMBNAHIFL.JAIGKHDFLIN GFCEPJINNMJ
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	BIOFEIDPHNA.HJAFHNCLGOA AFFOMEKPOGM
	{
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	JJGBIGJGLEO.DCMFKDFHIDD<LKJBELODGDI, EIJGBFLAMII, PJNMBNAHIFL> ACKBFGKLOCM
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	MBPPFDMCEAB ACDJIFFJFJI
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	MECKJJBBCAK KHEAKPLPEKP
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	FMJEHGKGMDB NODKJBCDHGO
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	EECCFHIPBFA HCPLGEAOOFO
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	JAAOPFDDNHM OEBGIMHBCAI
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public static class MAKBOBAHCIP
{
	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x1FBCE80", Offset = "0x1FBB480", VA = "0x181FBCE80")]
	public static EIJGBFLAMII EGLEBCCABKD(this EIJGBFLAMII HLIDMKMINHN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x1FBCF90", Offset = "0x1FBB590", VA = "0x181FBCF90")]
	public static EIJGBFLAMII JDPPJHBPCGD(this BIMLINPOKKP HLIDMKMINHN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public readonly struct BIMLINPOKKP
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[CompilerGenerated]
	private struct FLNDIMJAKKF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public AsyncTaskMethodBuilder<CBDPDIPONCF<object, FBDDJIHDMAI>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public PJNMBNAHIFL root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public BIMLINPOKKP self;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private TaskAwaiter<CBDPDIPONCF<object, FBDDJIHDMAI>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x1FAD640", Offset = "0x1FABC40", VA = "0x181FAD640", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x1FAD900", Offset = "0x1FABF00", VA = "0x181FAD900", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public readonly ByteString FJLALGMPANI;

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x958AF0", Offset = "0x9570F0", VA = "0x180958AF0")]
	private BIMLINPOKKP(ByteString DMNGPNKHPKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x1FA9F40", Offset = "0x1FA8540", VA = "0x181FA9F40")]
	public static EIJGBFLAMII NDIGIDDHLPJ(ByteString DMNGPNKHPKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x1FA9D80", Offset = "0x1FA8380", VA = "0x181FA9D80")]
	public static HPKKLOLKELF<LKJBELODGDI, BIMLINPOKKP> BAPBCJGBEDO(EIJGBFLAMII LECHCDDBDND)
	{
		return default(HPKKLOLKELF<LKJBELODGDI, BIMLINPOKKP>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x1FA9E30", Offset = "0x1FA8430", VA = "0x181FA9E30")]
	[AsyncStateMachine(typeof(FLNDIMJAKKF))]
	public static Task<CBDPDIPONCF<object, FBDDJIHDMAI>> LPKEJCOBKEB(PJNMBNAHIFL OPJBDKMKMOF, BIMLINPOKKP HLIDMKMINHN)
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000019")]
public readonly struct JDPNDLHJMBB
{
	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x1FB9310", Offset = "0x1FB7910", VA = "0x181FB9310")]
	public static EIJGBFLAMII NDIGIDDHLPJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x1FB9220", Offset = "0x1FB7820", VA = "0x181FB9220")]
	public static HPKKLOLKELF<LKJBELODGDI, JDPNDLHJMBB> BAPBCJGBEDO(EIJGBFLAMII LECHCDDBDND)
	{
		return default(HPKKLOLKELF<LKJBELODGDI, JDPNDLHJMBB>);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x1FB9290", Offset = "0x1FB7890", VA = "0x181FB9290")]
	public static CBDPDIPONCF<COKMANPFJNC, IFONDHBKBCD> MIMELGANJCJ(PJNMBNAHIFL OPJBDKMKMOF, [In] JDPNDLHJMBB HLIDMKMINHN)
	{
		return default(CBDPDIPONCF<COKMANPFJNC, IFONDHBKBCD>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public readonly struct NIICABKINOO
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[CompilerGenerated]
	private struct HCBIAJKOIHG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public AsyncTaskMethodBuilder<CBDPDIPONCF<COKMANPFJNC, IFONDHBKBCD>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public PJNMBNAHIFL root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public NIICABKINOO self;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private CBDPDIPONCF<COKMANPFJNC, IFONDHBKBCD> <r>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x1FB8900", Offset = "0x1FB6F00", VA = "0x181FB8900", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x1FB8C70", Offset = "0x1FB7270", VA = "0x181FB8C70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	public readonly EHHGJCHGBMN? MOFKODGPJOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public readonly JJBCGHIHKLB? GFLKCHMJHBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public readonly IOHGNKJIFDJ? OIPAHHBBIAE;

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x1EE1420", Offset = "0x1EDFA20", VA = "0x181EE1420")]
	private NIICABKINOO(EHHGJCHGBMN? GEIBOHFEECI, JJBCGHIHKLB? OMJCIEDKBFM, IOHGNKJIFDJ? KNMFEIKCDGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x1FBF760", Offset = "0x1FBDD60", VA = "0x181FBF760")]
	public static EIJGBFLAMII? NDIGIDDHLPJ(EHHGJCHGBMN? GEIBOHFEECI, JJBCGHIHKLB? OMJCIEDKBFM, IOHGNKJIFDJ? KNMFEIKCDGI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x1FBF510", Offset = "0x1FBDB10", VA = "0x181FBF510")]
	public static HPKKLOLKELF<LKJBELODGDI, NIICABKINOO> BAPBCJGBEDO(EIJGBFLAMII LECHCDDBDND)
	{
		return default(HPKKLOLKELF<LKJBELODGDI, NIICABKINOO>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x1FBF620", Offset = "0x1FBDC20", VA = "0x181FBF620")]
	[AsyncStateMachine(typeof(HCBIAJKOIHG))]
	public static Task<CBDPDIPONCF<COKMANPFJNC, IFONDHBKBCD>> LPKEJCOBKEB(PJNMBNAHIFL OPJBDKMKMOF, NIICABKINOO HLIDMKMINHN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public readonly struct MGJIMECKOEH
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	[CompilerGenerated]
	private struct AMCAMNPNBPN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public AsyncTaskMethodBuilder<CBDPDIPONCF<BDCBLKCBAEO, FBDDJIHDMAI>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public MGJIMECKOEH self;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public PJNMBNAHIFL root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private CBDPDIPONCF<BDCBLKCBAEO, FBDDJIHDMAI> <r1>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		private CBDPDIPONCF<object, GJMJCOBOHDO>[] <aggregateResult>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		private int <i>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		private CBDPDIPONCF<object, GJMJCOBOHDO> <r2>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		private CBDPDIPONCF<object, GJMJCOBOHDO>[] <>7__wrap5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		private int <>7__wrap6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		private TaskAwaiter<CBDPDIPONCF<object, FBDDJIHDMAI>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x1FA8B60", Offset = "0x1FA7160", VA = "0x181FA8B60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x1FA8FD0", Offset = "0x1FA75D0", VA = "0x181FA8FD0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public readonly IReadOnlyList<EIJGBFLAMII> APNINLMKGAI;

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x958AF0", Offset = "0x9570F0", VA = "0x180958AF0")]
	private MGJIMECKOEH(IReadOnlyList<EIJGBFLAMII> EPOBEFECONA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x1FBD5D0", Offset = "0x1FBBBD0", VA = "0x181FBD5D0")]
	public static EIJGBFLAMII NDIGIDDHLPJ(IReadOnlyList<EIJGBFLAMII> EPOBEFECONA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x1FBD3F0", Offset = "0x1FBB9F0", VA = "0x181FBD3F0")]
	public static HPKKLOLKELF<LKJBELODGDI, MGJIMECKOEH> BAPBCJGBEDO(EIJGBFLAMII LECHCDDBDND)
	{
		return default(HPKKLOLKELF<LKJBELODGDI, MGJIMECKOEH>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x1FBD490", Offset = "0x1FBBA90", VA = "0x181FBD490")]
	[AsyncStateMachine(typeof(AMCAMNPNBPN))]
	public static Task<CBDPDIPONCF<BDCBLKCBAEO, FBDDJIHDMAI>> LPKEJCOBKEB(PJNMBNAHIFL OPJBDKMKMOF, MGJIMECKOEH HLIDMKMINHN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public readonly struct JFDDIOGFCLI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	public readonly int ABEHPFBIDOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	public readonly int MIMJDCDEIKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	public readonly byte[] GDPGJFHLHOH;

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x1AFEB30", Offset = "0x1AFD130", VA = "0x181AFEB30")]
	private JFDDIOGFCLI(int BMKFLHFENBJ, int PDMMEDBMFPP, byte[] MMDLBEBNCGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x1FB9950", Offset = "0x1FB7F50", VA = "0x181FB9950")]
	public static EIJGBFLAMII NDIGIDDHLPJ(int BMKFLHFENBJ, int PDMMEDBMFPP, ByteString MMDLBEBNCGC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x1FB96F0", Offset = "0x1FB7CF0", VA = "0x181FB96F0")]
	public static EIJGBFLAMII[] BDCBEFPFHAH(EIJGBFLAMII PEMICEIPPPL, int OLONDLMBCGF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x1FB9610", Offset = "0x1FB7C10", VA = "0x181FB9610")]
	public static HPKKLOLKELF<LKJBELODGDI, JFDDIOGFCLI> BAPBCJGBEDO(EIJGBFLAMII LECHCDDBDND)
	{
		return default(HPKKLOLKELF<LKJBELODGDI, JFDDIOGFCLI>);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x1FB9830", Offset = "0x1FB7E30", VA = "0x181FB9830")]
	public static CBDPDIPONCF<EIJGBFLAMII, IFONDHBKBCD> MIMELGANJCJ(PJNMBNAHIFL OPJBDKMKMOF, [In] JFDDIOGFCLI HLIDMKMINHN)
	{
		return default(CBDPDIPONCF<EIJGBFLAMII, IFONDHBKBCD>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public readonly struct NCJCIPAFOLM
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[CompilerGenerated]
	private struct JKBAMJJNANC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public AsyncTaskMethodBuilder<CBDPDIPONCF<bool, IFONDHBKBCD>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public PJNMBNAHIFL root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public NCJCIPAFOLM self;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		private CBDPDIPONCF<bool, IFONDHBKBCD> <r>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		private TaskAwaiter<CBDPDIPONCF<COKMANPFJNC, IFONDHBKBCD>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x1FB9A30", Offset = "0x1FB8030", VA = "0x181FB9A30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x1FBA070", Offset = "0x1FB8670", VA = "0x181FBA070", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public readonly int ABEHPFBIDOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public readonly int MIMJDCDEIKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public readonly byte[] GDPGJFHLHOH;

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x1AFEB30", Offset = "0x1AFD130", VA = "0x181AFEB30")]
	private NCJCIPAFOLM(int BMKFLHFENBJ, int PDMMEDBMFPP, byte[] MMDLBEBNCGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x1FBDD10", Offset = "0x1FBC310", VA = "0x181FBDD10")]
	public static EIJGBFLAMII NDIGIDDHLPJ(int BMKFLHFENBJ, int PDMMEDBMFPP, ByteString MMDLBEBNCGC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x1FBDB10", Offset = "0x1FBC110", VA = "0x181FBDB10")]
	public static EIJGBFLAMII?[]? MALDIMMCOLJ(int OLONDLMBCGF, EHHGJCHGBMN? GEIBOHFEECI, JJBCGHIHKLB? OMJCIEDKBFM, IOHGNKJIFDJ? KNMFEIKCDGI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x1FBD900", Offset = "0x1FBBF00", VA = "0x181FBD900")]
	public static HPKKLOLKELF<LKJBELODGDI, NCJCIPAFOLM> BAPBCJGBEDO(EIJGBFLAMII LECHCDDBDND)
	{
		return default(HPKKLOLKELF<LKJBELODGDI, NCJCIPAFOLM>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x1FBD9E0", Offset = "0x1FBBFE0", VA = "0x181FBD9E0")]
	[AsyncStateMachine(typeof(JKBAMJJNANC))]
	public static Task<CBDPDIPONCF<bool, IFONDHBKBCD>> LPKEJCOBKEB(PJNMBNAHIFL OPJBDKMKMOF, NCJCIPAFOLM HLIDMKMINHN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public sealed class BGMBFJEEEEO : HJBDOOOBICO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private readonly PJNMBNAHIFL NKJLAAKEIDF;

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public DHEMLKJGKDJ? CFNNMJAMDBB
	{
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x1FA9C70", Offset = "0x1FA8270", VA = "0x181FA9C70", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x872130", Offset = "0x870730", VA = "0x180872130")]
	internal BGMBFJEEEEO(PJNMBNAHIFL ALELNINOAGK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public sealed class DMPGPAAEJAF : DHEMLKJGKDJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private readonly PJNMBNAHIFL NKJLAAKEIDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private readonly HFIAJFGBMJC CBEGFJIJEAA;

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x872E80", Offset = "0x871480", VA = "0x180872E80")]
	public DMPGPAAEJAF(PJNMBNAHIFL ALELNINOAGK, HFIAJFGBMJC LDELOABMCDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x1FABE30", Offset = "0x1FAA430", VA = "0x181FABE30", Slot = "4")]
	public CBDPDIPONCF<MMEFBPFPPPD, MFOECDNIOPO> FIJCEMBONGF(HBIPEINCKFG<JBMJEMLAFJB> CNJMIDDPAFB, CGBGMGFBCKF<HGFEOPBBPIG> GKEOEKGAILK, CGBGMGFBCKF<NLKCJCDLMOJ> BEHIJEKELGM)
	{
		return default(CBDPDIPONCF<MMEFBPFPPPD, MFOECDNIOPO>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x1FAC110", Offset = "0x1FAA710", VA = "0x181FAC110", Slot = "5")]
	public CBDPDIPONCF<MMEFBPFPPPD, MFOECDNIOPO> GJDGLAMIBLP(HBIPEINCKFG<JBMJEMLAFJB> CNJMIDDPAFB, CGBGMGFBCKF<HGFEOPBBPIG> GKEOEKGAILK, CGBGMGFBCKF<CPECOCNOBEE> PDHFLBHDHCA)
	{
		return default(CBDPDIPONCF<MMEFBPFPPPD, MFOECDNIOPO>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public sealed class ALAEJLFBHLG : JGOGPKBGDJJ, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public interface KMKANABDJKK
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Task<HFIAJFGBMJC> JIKEENJBDII(PJNMBNAHIFL ALELNINOAGK, JJBCGHIHKLB? OKGEABKLJFB, IOHGNKJIFDJ? JGGJMHOEJAC, CancellationToken FIMAIPEFOAM);

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		JJFJBDJBODL NHFCJLKBEDO(PJNMBNAHIFL ALELNINOAGK, EHHGJCHGBMN DMLCBPHDENE);
	}

	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public sealed class LFDINAACCMI : KMKANABDJKK
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000028")]
		[CompilerGenerated]
		private struct INPJADFPAIB : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400006E")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400006F")]
			public AsyncTaskMethodBuilder<HFIAJFGBMJC> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000070")]
			public PJNMBNAHIFL circuitsManager;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000071")]
			public JJBCGHIHKLB cv2RoomData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000072")]
			public IOHGNKJIFDJ cv2SuperRoomData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000073")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000074")]
			private TaskAwaiter<BIOFEIDPHNA> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0x1FB8FE0", Offset = "0x1FB75E0", VA = "0x181FB8FE0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0x1FB91B0", Offset = "0x1FB77B0", VA = "0x181FB91B0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public static readonly LFDINAACCMI CFNNMJAMDBB;

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x86C4B0", Offset = "0x86AAB0", VA = "0x18086C4B0")]
		private LFDINAACCMI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x1FBCC80", Offset = "0x1FBB280", VA = "0x181FBCC80", Slot = "4")]
		[AsyncStateMachine(typeof(INPJADFPAIB))]
		public Task<HFIAJFGBMJC> JIKEENJBDII(PJNMBNAHIFL ALELNINOAGK, JJBCGHIHKLB? OKGEABKLJFB, IOHGNKJIFDJ? JGGJMHOEJAC, CancellationToken FIMAIPEFOAM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x1FBCDE0", Offset = "0x1FBB3E0", VA = "0x181FBCDE0", Slot = "5")]
		public JJFJBDJBODL NHFCJLKBEDO(PJNMBNAHIFL ALELNINOAGK, EHHGJCHGBMN DMLCBPHDENE)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	[CompilerGenerated]
	private struct FHIHIPILEPN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		public AsyncTaskMethodBuilder<ALAEJLFBHLG> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		public PJNMBNAHIFL circuitsManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		public JJBCGHIHKLB cv2RoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		public IOHGNKJIFDJ cv2SuperRoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public EHHGJCHGBMN evRoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		private KMKANABDJKK <selfDeps>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		private TaskAwaiter<HFIAJFGBMJC> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x1FAD0D0", Offset = "0x1FAB6D0", VA = "0x181FAD0D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x1FAD5D0", Offset = "0x1FABBD0", VA = "0x181FAD5D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private readonly HFIAJFGBMJC CBEGFJIJEAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private readonly JJFJBDJBODL KFMHBEFONIA;

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public DDBLDNMCNDP KHJKLDCJFLC
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x1FA87A0", Offset = "0x1FA6DA0", VA = "0x181FA87A0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public AJNGKLOBPDA FGLFHDCOOPA
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x1FA87F0", Offset = "0x1FA6DF0", VA = "0x181FA87F0", Slot = "5")]
		get
		{
			return default(AJNGKLOBPDA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public DMPGPAAEJAF GLKEIFIPMCA
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x868200", Offset = "0x866800", VA = "0x180868200", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public KDAIKKDGJPC IACAOFPFCMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x868210", Offset = "0x866810", VA = "0x180868210", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x1DD9B80", Offset = "0x1DD8180", VA = "0x181DD9B80")]
	private ALAEJLFBHLG(HFIAJFGBMJC LDELOABMCDO, JJFJBDJBODL EHJLLLOAOFJ, DMPGPAAEJAF DNCCIBLMCEM, KDAIKKDGJPC PFHPEIICPCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x1FA85D0", Offset = "0x1FA6BD0", VA = "0x181FA85D0")]
	[AsyncStateMachine(typeof(FHIHIPILEPN))]
	public static Task<ALAEJLFBHLG> DKDKEPCPNMG(PJNMBNAHIFL ALELNINOAGK, EHHGJCHGBMN DMLCBPHDENE, JJBCGHIHKLB? OKGEABKLJFB, IOHGNKJIFDJ? JGGJMHOEJAC, CancellationToken FIMAIPEFOAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x1FA8740", Offset = "0x1FA6D40", VA = "0x181FA8740", Slot = "8")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public sealed class BAAJHLLICGI : PKEFOPMHOCD, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	public interface AKCICGNFDEE
	{
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Task<JGOGPKBGDJJ> EEHIEGJMMFK(PJNMBNAHIFL ALELNINOAGK, EHHGJCHGBMN DMLCBPHDENE, JJBCGHIHKLB? OKGEABKLJFB, IOHGNKJIFDJ? JGGJMHOEJAC, CancellationToken FIMAIPEFOAM);

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void FEGGOLNJHEE();

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void JHODJDHPGJG();
	}

	[Cpp2IlInjected.Token(Token = "0x200002C")]
	public abstract class FPCAOLPMMLF : AKCICGNFDEE
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200002D")]
		[CompilerGenerated]
		private struct DLKEKFPGALJ : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000086")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000087")]
			public AsyncTaskMethodBuilder<JGOGPKBGDJJ> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000088")]
			public PJNMBNAHIFL circuitsManager;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000089")]
			public EHHGJCHGBMN evRoomData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400008A")]
			public JJBCGHIHKLB cv2RoomData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400008B")]
			public IOHGNKJIFDJ cv2SuperRoomData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400008C")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400008D")]
			private TaskAwaiter<ALAEJLFBHLG> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0x1FABA80", Offset = "0x1FAA080", VA = "0x181FABA80", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0x1FABDC0", Offset = "0x1FAA3C0", VA = "0x181FABDC0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x1FAD970", Offset = "0x1FABF70", VA = "0x181FAD970", Slot = "4")]
		[AsyncStateMachine(typeof(DLKEKFPGALJ))]
		public Task<JGOGPKBGDJJ> EEHIEGJMMFK(PJNMBNAHIFL ALELNINOAGK, EHHGJCHGBMN DMLCBPHDENE, JJBCGHIHKLB? OKGEABKLJFB, IOHGNKJIFDJ? JGGJMHOEJAC, CancellationToken FIMAIPEFOAM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(Slot = "7")]
		public abstract void FEGGOLNJHEE();

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(Slot = "8")]
		public abstract void JHODJDHPGJG();

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x86C4B0", Offset = "0x86AAB0", VA = "0x18086C4B0")]
		protected FPCAOLPMMLF()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[CompilerGenerated]
	private struct MNGLLPHGGDF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		public AsyncTaskMethodBuilder<JGOGPKBGDJJ> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		public BAAJHLLICGI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		private TaskAwaiter<COKMANPFJNC> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x1FBD690", Offset = "0x1FBBC90", VA = "0x181FBD690", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x1FBD890", Offset = "0x1FBBE90", VA = "0x181FBD890", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[CompilerGenerated]
	private struct NKODIMALGCF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		public BAAJHLLICGI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		public PJNMBNAHIFL circuitsManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		public EHHGJCHGBMN evRoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		public JJBCGHIHKLB cv2RoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		public IOHGNKJIFDJ cv2SuperRoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		private TaskAwaiter<JGOGPKBGDJJ> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x1FBF8E0", Offset = "0x1FBDEE0", VA = "0x181FBF8E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x1FBFE10", Offset = "0x1FBE410", VA = "0x181FBFE10", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	private readonly AKCICGNFDEE IMCLEPLPDAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	private readonly TaskCompletionSource<COKMANPFJNC> DLOILIJJEFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	private readonly TaskCompletionSource<COKMANPFJNC> LDKODMNFLLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	private readonly CancellationTokenSource OGGLBFNNMGE;

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public bool ADNHKDCFBHB
	{
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x9F6C60", Offset = "0x9F5260", VA = "0x1809F6C60", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0xA1E7F0", Offset = "0xA1CDF0", VA = "0x180A1E7F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public bool BGBBMOLNFII
	{
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0xB0D210", Offset = "0xB0B810", VA = "0x180B0D210", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0xB0D200", Offset = "0xB0B800", VA = "0x180B0D200")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public bool LMHGONANDDN
	{
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x112E1A0", Offset = "0x112C7A0", VA = "0x18112E1A0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x1FA92A0", Offset = "0x1FA78A0", VA = "0x181FA92A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public JGOGPKBGDJJ? DKGAHKAKKLD
	{
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x868EE0", Offset = "0x8674E0", VA = "0x180868EE0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x868CD0", Offset = "0x8672D0", VA = "0x180868CD0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x1FA91B0", Offset = "0x1FA77B0", VA = "0x181FA91B0", Slot = "7")]
	[AsyncStateMachine(typeof(MNGLLPHGGDF))]
	public Task<JGOGPKBGDJJ> ECDFCGJKIKH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x1FA9410", Offset = "0x1FA7A10", VA = "0x181FA9410")]
	public BAAJHLLICGI(AKCICGNFDEE BPGHBBHBELB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x1FA92B0", Offset = "0x1FA78B0", VA = "0x181FA92B0", Slot = "8")]
	[AsyncStateMachine(typeof(NKODIMALGCF))]
	public Task OJLAJHNHBNB(PJNMBNAHIFL ALELNINOAGK, EHHGJCHGBMN DMLCBPHDENE, JJBCGHIHKLB? OKGEABKLJFB, IOHGNKJIFDJ? JGGJMHOEJAC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x1FA9040", Offset = "0x1FA7640", VA = "0x181FA9040", Slot = "9")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
internal sealed class HKJPBJMPMPH : GAGDLMKFIHD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private readonly KDAIKKDGJPC FHMJCELJAKF;

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x872130", Offset = "0x870730", VA = "0x180872130")]
	public HKJPBJMPMPH(KDAIKKDGJPC PFHPEIICPCN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
internal static class DOIDBKGBPIE
{
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	private class FPMDOAMOGOG<TGraph> : BGIBPOPOOLN where TGraph : JNLMEDOKAOJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		protected readonly TGraph DFKGGPDDMFJ;

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public virtual FDJBAOEBKDJ? OEGDJFNEKEN
		{
			[Cpp2IlInjected.Token(Token = "0x60000AE")]
			[Cpp2IlInjected.Address(RVA = "0xF4CDD0", Offset = "0xF4B3D0", VA = "0x180F4CDD0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public CGBGMGFBCKF<NPIPKFBHIBO> IHPNLCLNIBJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000B0")]
			[Cpp2IlInjected.Address(RVA = "0x3C5B720", Offset = "0x3C59D20", VA = "0x183C5B720", Slot = "5")]
			get
			{
				return default(CGBGMGFBCKF<NPIPKFBHIBO>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public CGBGMGFBCKF<NPIPKFBHIBO>? GEDMLGKPMEB
		{
			[Cpp2IlInjected.Token(Token = "0x60000B1")]
			[Cpp2IlInjected.Address(RVA = "0x3C5B740", Offset = "0x3C59D40", VA = "0x183C5B740", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x872130", Offset = "0x870730", VA = "0x180872130")]
		public FPMDOAMOGOG(TGraph BBOKFOJNMIE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000033")]
	private sealed class ENDMNHHLLCJ : FPMDOAMOGOG<JMDLMHIPBMM>
	{
		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public override FDJBAOEBKDJ? OEGDJFNEKEN
		{
			[Cpp2IlInjected.Token(Token = "0x60000B2")]
			[Cpp2IlInjected.Address(RVA = "0x1FACFE0", Offset = "0x1FAB5E0", VA = "0x181FACFE0", Slot = "7")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x1FAD000", Offset = "0x1FAB600", VA = "0x181FAD000")]
		public ENDMNHHLLCJ(JMDLMHIPBMM LCDGLKBBOGB)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x1FAC3F0", Offset = "0x1FAA9F0", VA = "0x181FAC3F0")]
	public static BGIBPOPOOLN ENFOKLPNHAF(JNLMEDOKAOJ BBOKFOJNMIE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public sealed class PALNNNBJCJE : FKBGMNABOAN, PGFKPKOPNBP, GFPIIFJFFHL, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	[CompilerGenerated]
	private sealed class EHAIFPJOJDA
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000037")]
		private struct <<RequestSetBoolDefaultValue>g__requestSetBoolDefaultValueInternal|0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A7")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40000A8")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000A9")]
			public EHAIFPJOJDA <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000AA")]
			public MBPPFDMCEAB errReporting_;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000AB")]
			private TaskAwaiter<CBDPDIPONCF<COKMANPFJNC, FBDDJIHDMAI>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60000E0")]
			[Cpp2IlInjected.Address(RVA = "0x1FC4EB0", Offset = "0x1FC34B0", VA = "0x181FC4EB0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E1")]
			[Cpp2IlInjected.Address(RVA = "0x1FC5120", Offset = "0x1FC3720", VA = "0x181FC5120", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		public PALNNNBJCJE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		public bool value;

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x86C4B0", Offset = "0x86AAB0", VA = "0x18086C4B0")]
		public EHAIFPJOJDA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x1FACCE0", Offset = "0x1FAB2E0", VA = "0x181FACCE0")]
		[AsyncStateMachine(typeof(<<RequestSetBoolDefaultValue>g__requestSetBoolDefaultValueInternal|0>d))]
		internal Task KBONKECILBK(MBPPFDMCEAB errReporting_)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	[CompilerGenerated]
	private struct AGJHBLFBEIH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		public bool checkStringPurity;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		public PALNNNBJCJE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		public string value;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		private TaskAwaiter<bool> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		private TaskAwaiter<CBDPDIPONCF<COKMANPFJNC, FBDDJIHDMAI>> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x1FA7E10", Offset = "0x1FA6410", VA = "0x181FA7E10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x1FA8320", Offset = "0x1FA6920", VA = "0x181FA8320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000039")]
	[CompilerGenerated]
	private sealed class PMNJCDEMPFB
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200003A")]
		private struct <<RequestSetIntDefaultValue>g__requestSetIntDefaultValueInternal|0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000B5")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40000B6")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000B7")]
			public PMNJCDEMPFB <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000B8")]
			private TaskAwaiter<CBDPDIPONCF<COKMANPFJNC, FBDDJIHDMAI>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60000E6")]
			[Cpp2IlInjected.Address(RVA = "0x1FC5180", Offset = "0x1FC3780", VA = "0x181FC5180", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E7")]
			[Cpp2IlInjected.Address(RVA = "0x1FC5460", Offset = "0x1FC3A60", VA = "0x181FC5460", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		public PALNNNBJCJE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		public int value;

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x86C4B0", Offset = "0x86AAB0", VA = "0x18086C4B0")]
		public PMNJCDEMPFB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x1FC4DE0", Offset = "0x1FC33E0", VA = "0x181FC4DE0")]
		[AsyncStateMachine(typeof(<<RequestSetIntDefaultValue>g__requestSetIntDefaultValueInternal|0>d))]
		internal Task FKOPIFEDNDK(MBPPFDMCEAB errReporting_)
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private readonly JNAGHLPMJGM GNDAEOKPEPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private readonly ICollection<HLONAHHFBKD> MOEBOHIIMBO;

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	private BGCMFBBEEPB NMLPGGLMMPL
	{
		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x1FC1980", Offset = "0x1FBFF80", VA = "0x181FC1980")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public CGBGMGFBCKF<NLKCJCDLMOJ> ICDFGBAFPNK
	{
		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x8F7E40", Offset = "0x8F6440", VA = "0x1808F7E40", Slot = "24")]
		[CompilerGenerated]
		get
		{
			return default(CGBGMGFBCKF<NLKCJCDLMOJ>);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0xB7CE10", Offset = "0xB7B410", VA = "0x180B7CE10")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	private CGBGMGFBCKF<JJKDMNECOCJ> MBBMILLMPKI
	{
		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0xB040C0", Offset = "0xB026C0", VA = "0x180B040C0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public CGBGMGFBCKF<HHDHBHHIDEB> PKMGJFNFBFE
	{
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x88DFF0", Offset = "0x88C5F0", VA = "0x18088DFF0", Slot = "25")]
		[CompilerGenerated]
		get
		{
			return default(CGBGMGFBCKF<HHDHBHHIDEB>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public override CGBGMGFBCKF<HECEFCAIFNP> JILPHPPAAHE
	{
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x1FC0E40", Offset = "0x1FBF440", VA = "0x181FC0E40", Slot = "20")]
		get
		{
			return default(CGBGMGFBCKF<HECEFCAIFNP>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public bool LNAJGAEDHBK
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x1FC0DC0", Offset = "0x1FBF3C0", VA = "0x181FC0DC0", Slot = "26")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x1FC3330", Offset = "0x1FC1930", VA = "0x181FC3330")]
	private PALNNNBJCJE(PJNMBNAHIFL ALELNINOAGK, JJAEOPCJMCB EMDFCFPCFGG, JNAGHLPMJGM IFKBNPFMHKC, CGBGMGFBCKF<HGFEOPBBPIG> GKEOEKGAILK, CGBGMGFBCKF<NLKCJCDLMOJ> BEHIJEKELGM, CGBGMGFBCKF<JJKDMNECOCJ> JMCNEMAGKLA, bool LGIAMDHGCNK, string GJEDHMJMNJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x1FC1250", Offset = "0x1FBF850", VA = "0x181FC1250")]
	public static PALNNNBJCJE ENFOKLPNHAF(PJNMBNAHIFL ALELNINOAGK, JJAEOPCJMCB EMDFCFPCFGG, JNAGHLPMJGM BNBKMKBLLLG, CGBGMGFBCKF<HGFEOPBBPIG> GKEOEKGAILK, CGBGMGFBCKF<JJKDMNECOCJ> JMCNEMAGKLA, CGBGMGFBCKF<NLKCJCDLMOJ> BEHIJEKELGM, bool LGIAMDHGCNK, bool JGBMGBJLMOK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x1FC3290", Offset = "0x1FC1890", VA = "0x181FC3290", Slot = "21")]
	protected override void PNLKNBIHCGI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x1FC10E0", Offset = "0x1FBF6E0", VA = "0x181FC10E0", Slot = "22")]
	public override void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x1FC1EB0", Offset = "0x1FC04B0", VA = "0x181FC1EB0", Slot = "30")]
	public void JPAPDLEKFIJ(HLONAHHFBKD EFKPKLOMKDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x1FC1F10", Offset = "0x1FC0510", VA = "0x181FC1F10", Slot = "27")]
	public void KJDKIDFFPLA(BJOKDCBNPMG CGMHFGHJLJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x1FC2620", Offset = "0x1FC0C20", VA = "0x181FC2620", Slot = "28")]
	public void MBEDFBOJBDH(JLJDIKCDIEC HDGKFFCHDDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x1FC19A0", Offset = "0x1FBFFA0", VA = "0x181FC19A0", Slot = "23")]
	protected override void IBGNIFAHKIP(JEBFMDIELNP MEELEAGKCMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x1FC24B0", Offset = "0x1FC0AB0", VA = "0x181FC24B0", Slot = "32")]
	public string LIHJHOBFGEE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x1FC0B00", Offset = "0x1FBF100", VA = "0x181FC0B00", Slot = "29")]
	public string AFNGEPJGGMA(int LANOKLGBLAA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x1FC2280", Offset = "0x1FC0880", VA = "0x181FC2280")]
	private void KOKBFFCAHED()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x1FC1180", Offset = "0x1FBF780", VA = "0x181FC1180", Slot = "31")]
	public void EGMFCJKFAJG(HLONAHHFBKD EFKPKLOMKDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x1FC1CF0", Offset = "0x1FC02F0", VA = "0x181FC1CF0")]
	private void JEPJDKEOEEN(bool DMNGPNKHPKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x1FC1BC0", Offset = "0x1FC01C0", VA = "0x181FC1BC0", Slot = "33")]
	[AsyncStateMachine(typeof(AGJHBLFBEIH))]
	public Task IHNLAGCPHNG(string DMNGPNKHPKF, bool JAEJPOAFNPM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x1FC1600", Offset = "0x1FBFC00", VA = "0x181FC1600")]
	public void FAMKKPCJHBF(string DMNGPNKHPKF, bool JAEJPOAFNPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x1FC1750", Offset = "0x1FBFD50", VA = "0x181FC1750")]
	private void GDAKNGKHDGE(int DMNGPNKHPKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0xB7CE10", Offset = "0xB7B410", VA = "0x180B7CE10")]
	internal void LBOAECCPKLP(CGBGMGFBCKF<NLKCJCDLMOJ> DMNGPNKHPKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x1FC1CE0", Offset = "0x1FC02E0", VA = "0x181FC1CE0")]
	[CompilerGenerated]
	private void IKMMFGLBKKD(string DMNGPNKHPKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x1FC0E90", Offset = "0x1FBF490", VA = "0x181FC0E90")]
	[CompilerGenerated]
	private bool COCEFAPAJOI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x1FC31D0", Offset = "0x1FC17D0", VA = "0x181FC31D0")]
	[CompilerGenerated]
	private bool PJFLJPDADCH()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x1FC1090", Offset = "0x1FBF690", VA = "0x181FC1090")]
	[CompilerGenerated]
	private int PJHIEDMOAFK()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x1FC18F0", Offset = "0x1FBFEF0", VA = "0x181FC18F0")]
	[CompilerGenerated]
	private bool HAGGMFHICEL()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x1FC1CD0", Offset = "0x1FC02D0", VA = "0x181FC1CD0")]
	[CompilerGenerated]
	private void IHOABIOEJKH(string DMNGPNKHPKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x1FC0FD0", Offset = "0x1FBF5D0", VA = "0x181FC0FD0")]
	[CompilerGenerated]
	private bool DOFLHKLCKHD()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x1FC3180", Offset = "0x1FC1780", VA = "0x181FC3180")]
	[CompilerGenerated]
	private bool PACHLIKFBEP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x1FC30A0", Offset = "0x1FC16A0", VA = "0x181FC30A0")]
	[CompilerGenerated]
	private bool NCKNIHNCBBN()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x1FC1090", Offset = "0x1FBF690", VA = "0x181FC1090")]
	[CompilerGenerated]
	private int DPKFMNHHNOA()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x1FC1AF0", Offset = "0x1FC00F0", VA = "0x181FC1AF0")]
	[CompilerGenerated]
	private bool IGKOFGJIHLH()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x1FC3130", Offset = "0x1FC1730", VA = "0x181FC3130")]
	[CompilerGenerated]
	private int NMLMLAGAEOK()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x1FC0F50", Offset = "0x1FBF550", VA = "0x181FC0F50")]
	[CompilerGenerated]
	private void DOFAILHMEBB(object DMNGPNKHPKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x1FC2FD0", Offset = "0x1FC15D0", VA = "0x181FC2FD0")]
	[CompilerGenerated]
	private bool MKCGIBDKCKH()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public static class NHEPOKEBEON
{
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	public sealed class OMBFFGJGJOA : ONPIPBFAAKM<IGKHIMHEPGN>
	{
		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public override BDJFDBHNNED MFPOPCILKGP
		{
			[Cpp2IlInjected.Token(Token = "0x60000EA")]
			[Cpp2IlInjected.Address(RVA = "0x8F6240", Offset = "0x8F4840", VA = "0x1808F6240", Slot = "126")]
			get
			{
				return default(BDJFDBHNNED);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x1FC0080", Offset = "0x1FBE680", VA = "0x181FC0080")]
		public OMBFFGJGJOA(PJNMBNAHIFL ALELNINOAGK, IGKHIMHEPGN AKLCDEBLEOF)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003D")]
	public sealed class BCCJIKGMKCF : DCANGPMKHHL<JFKKFHOGMJC>
	{
		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x1FA9810", Offset = "0x1FA7E10", VA = "0x181FA9810")]
		public BCCJIKGMKCF(PJNMBNAHIFL ALELNINOAGK, JFKKFHOGMJC EMDFCFPCFGG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x1FA9520", Offset = "0x1FA7B20", VA = "0x181FA9520", Slot = "120")]
		protected override void AANCPJNHLHN(GDJFKKGDGFJ KMONEIKIHIC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x1FA96A0", Offset = "0x1FA7CA0", VA = "0x181FA96A0")]
		[CompilerGenerated]
		private bool IEEGHFLFOAG()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x1FA96F0", Offset = "0x1FA7CF0", VA = "0x181FA96F0")]
		[CompilerGenerated]
		private void MGBMKNINDEL(bool DMNGPNKHPKF)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003E")]
	public sealed class BOALJEHMMOG : DCANGPMKHHL<PHLIGMBFEJE>
	{
		[Cpp2IlInjected.Token(Token = "0x200003F")]
		[CompilerGenerated]
		private sealed class JEFDJEPLBJJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000B9")]
			public BKKHOHENKFL nodeAdapterDeps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000BA")]
			public BOALJEHMMOG <>4__this;

			[Cpp2IlInjected.Token(Token = "0x60000F1")]
			[Cpp2IlInjected.Address(RVA = "0x86C4B0", Offset = "0x86AAB0", VA = "0x18086C4B0")]
			public JEFDJEPLBJJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F2")]
			[Cpp2IlInjected.Address(RVA = "0x1FB94A0", Offset = "0x1FB7AA0", VA = "0x181FB94A0")]
			internal void MGLFNJMCMEN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F3")]
			[Cpp2IlInjected.Address(RVA = "0x1FB9450", Offset = "0x1FB7A50", VA = "0x181FB9450")]
			internal bool KGEOJKOADPA()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000F4")]
			[Cpp2IlInjected.Address(RVA = "0x1FB9400", Offset = "0x1FB7A00", VA = "0x181FB9400")]
			internal bool GLPPOLAGMCH()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000F5")]
			[Cpp2IlInjected.Address(RVA = "0x1FB94F0", Offset = "0x1FB7AF0", VA = "0x181FB94F0")]
			internal void PDHBGEGHGHC(bool value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F6")]
			[Cpp2IlInjected.Address(RVA = "0x1FB93B0", Offset = "0x1FB79B0", VA = "0x181FB93B0")]
			internal bool AAMBPKPGDKI()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x1FAB180", Offset = "0x1FA9780", VA = "0x181FAB180")]
		public BOALJEHMMOG(PJNMBNAHIFL ALELNINOAGK, PHLIGMBFEJE EMDFCFPCFGG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x1FAAE50", Offset = "0x1FA9450", VA = "0x181FAAE50", Slot = "120")]
		protected override void AANCPJNHLHN(GDJFKKGDGFJ KMONEIKIHIC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000040")]
	public sealed class JLCAOJLNJCA : DCANGPMKHHL<EBHELAJEOPJ>
	{
		[Cpp2IlInjected.Token(Token = "0x2000041")]
		[CompilerGenerated]
		private sealed class EGEJJEELFGL
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000BB")]
			public BKKHOHENKFL nodeAdapterDeps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000BC")]
			public JLCAOJLNJCA <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000BD")]
			public Predicate<Guid> <>9__7;

			[Cpp2IlInjected.Token(Token = "0x60000F9")]
			[Cpp2IlInjected.Address(RVA = "0x86C4B0", Offset = "0x86AAB0", VA = "0x18086C4B0")]
			public EGEJJEELFGL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FA")]
			[Cpp2IlInjected.Address(RVA = "0x1FACB40", Offset = "0x1FAB140", VA = "0x181FACB40")]
			internal object MGLFNJMCMEN()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000FB")]
			[Cpp2IlInjected.Address(RVA = "0x1FAC750", Offset = "0x1FAAD50", VA = "0x181FAC750")]
			internal bool KANOGPFMDHK(Guid id)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000FC")]
			[Cpp2IlInjected.Address(RVA = "0x1FAC7D0", Offset = "0x1FAADD0", VA = "0x181FAC7D0")]
			internal void KGEOJKOADPA(object value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FD")]
			[Cpp2IlInjected.Address(RVA = "0x1FAC5F0", Offset = "0x1FAABF0", VA = "0x181FAC5F0")]
			internal string GLPPOLAGMCH(object key)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000FE")]
			[Cpp2IlInjected.Address(RVA = "0x1FACC90", Offset = "0x1FAB290", VA = "0x181FACC90")]
			internal IReadOnlyList<object> PDHBGEGHGHC()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000FF")]
			[Cpp2IlInjected.Address(RVA = "0x1FAC580", Offset = "0x1FAAB80", VA = "0x181FAC580")]
			internal bool AAMBPKPGDKI()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000100")]
			[Cpp2IlInjected.Address(RVA = "0x1FACC40", Offset = "0x1FAB240", VA = "0x181FACC40")]
			internal bool NJBIAFHPNMH()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000101")]
			[Cpp2IlInjected.Address(RVA = "0x1FACA20", Offset = "0x1FAB020", VA = "0x181FACA20")]
			internal void LEKNKPMGLOF(bool value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x1FBA840", Offset = "0x1FB8E40", VA = "0x181FBA840")]
		public JLCAOJLNJCA(PJNMBNAHIFL ALELNINOAGK, EBHELAJEOPJ EMDFCFPCFGG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x1FBA0E0", Offset = "0x1FB86E0", VA = "0x181FBA0E0", Slot = "120")]
		protected override void AANCPJNHLHN(GDJFKKGDGFJ KMONEIKIHIC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000042")]
	public sealed class NEKIBPDBDGN : DCANGPMKHHL<AMMLAEIEEFF>
	{
		[Cpp2IlInjected.Token(Token = "0x2000043")]
		[CompilerGenerated]
		private sealed class OOMEPGLOJII
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000BE")]
			public NEKIBPDBDGN <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000BF")]
			public BKKHOHENKFL nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x6000104")]
			[Cpp2IlInjected.Address(RVA = "0x86C4B0", Offset = "0x86AAB0", VA = "0x18086C4B0")]
			public OOMEPGLOJII()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000105")]
			[Cpp2IlInjected.Address(RVA = "0x1FC0250", Offset = "0x1FBE850", VA = "0x181FC0250")]
			internal bool MGLFNJMCMEN()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000106")]
			[Cpp2IlInjected.Address(RVA = "0x1FC0130", Offset = "0x1FBE730", VA = "0x181FC0130")]
			internal void KGEOJKOADPA(bool value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000107")]
			[Cpp2IlInjected.Address(RVA = "0x1FC00E0", Offset = "0x1FBE6E0", VA = "0x181FC00E0")]
			internal bool GLPPOLAGMCH()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x1FBE020", Offset = "0x1FBC620", VA = "0x181FBE020")]
		public NEKIBPDBDGN(PJNMBNAHIFL ALELNINOAGK, AMMLAEIEEFF EMDFCFPCFGG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x1FBDDF0", Offset = "0x1FBC3F0", VA = "0x181FBDDF0", Slot = "120")]
		protected override void AANCPJNHLHN(GDJFKKGDGFJ KMONEIKIHIC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000044")]
	public abstract class BDHLCPDJKEP<TNode> : DCANGPMKHHL<TNode> where TNode : notnull, EHIAADHMLOA
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000045")]
		[CompilerGenerated]
		private struct CECFLFPHFNL : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C0")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C1")]
			public AsyncTaskMethodBuilder<CBDPDIPONCF<CGBGMGFBCKF<HGFEOPBBPIG>, FBDDJIHDMAI>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C2")]
			public BDHLCPDJKEP<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C3")]
			public string name;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C4")]
			private TaskAwaiter<CBDPDIPONCF<CGBGMGFBCKF<HGFEOPBBPIG>, FBDDJIHDMAI>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000110")]
			[Cpp2IlInjected.Address(RVA = "0x52A0700", Offset = "0x529ED00", VA = "0x1852A0700", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000111")]
			[Cpp2IlInjected.Address(RVA = "0x52A0B00", Offset = "0x529F100", VA = "0x1852A0B00", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000046")]
		[CompilerGenerated]
		private struct CGDAEEBIADL : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C5")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C6")]
			public AsyncTaskMethodBuilder<CBDPDIPONCF<COKMANPFJNC, FBDDJIHDMAI>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C7")]
			public BDHLCPDJKEP<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C8")]
			public CGBGMGFBCKF<HGFEOPBBPIG> portGroupId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C9")]
			private TaskAwaiter<CBDPDIPONCF<COKMANPFJNC, FBDDJIHDMAI>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000112")]
			[Cpp2IlInjected.Address(RVA = "0x52AC5B0", Offset = "0x52AABB0", VA = "0x1852AC5B0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000113")]
			[Cpp2IlInjected.Address(RVA = "0x52AC9B0", Offset = "0x52AAFB0", VA = "0x1852AC9B0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public sealed override bool MNPAIJIEJCB
		{
			[Cpp2IlInjected.Token(Token = "0x6000108")]
			[Cpp2IlInjected.Address(RVA = "0x881710", Offset = "0x87FD10", VA = "0x180881710", Slot = "115")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public sealed override CGBGMGFBCKF<HGFEOPBBPIG>? EGGCNCGGPCM
		{
			[Cpp2IlInjected.Token(Token = "0x6000109")]
			[Cpp2IlInjected.Address(RVA = "0x4EC5C60", Offset = "0x4EC4260", VA = "0x184EC5C60", Slot = "119")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x42F7990", Offset = "0x42F5F90", VA = "0x1842F7990")]
		protected BDHLCPDJKEP(PJNMBNAHIFL ALELNINOAGK, TNode EMDFCFPCFGG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x4EC5B40", Offset = "0x4EC4140", VA = "0x184EC5B40", Slot = "100")]
		[AsyncStateMachine(typeof(BDHLCPDJKEP<>.CECFLFPHFNL))]
		public override Task<CBDPDIPONCF<CGBGMGFBCKF<HGFEOPBBPIG>, FBDDJIHDMAI>> OMABNNMENMJ(string GJEDHMJMNJA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x4EC5A00", Offset = "0x4EC4000", VA = "0x184EC5A00", Slot = "124")]
		public sealed override bool JCHBGBLIJGB(CGBGMGFBCKF<HGFEOPBBPIG> GKEOEKGAILK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x4EC5AA0", Offset = "0x4EC40A0", VA = "0x184EC5AA0", Slot = "112")]
		protected sealed override bool ODKENONLAJO(CGBGMGFBCKF<HGFEOPBBPIG> GKEOEKGAILK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x4EC5960", Offset = "0x4EC3F60", VA = "0x184EC5960", Slot = "113")]
		protected override bool IDKIGCHOMFB(CGBGMGFBCKF<HGFEOPBBPIG> GKEOEKGAILK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x4EC5850", Offset = "0x4EC3E50", VA = "0x184EC5850", Slot = "101")]
		[AsyncStateMachine(typeof(BDHLCPDJKEP<>.CGDAEEBIADL))]
		public override Task<CBDPDIPONCF<COKMANPFJNC, FBDDJIHDMAI>> GHBJPLCMBLJ(CGBGMGFBCKF<HGFEOPBBPIG> GKEOEKGAILK)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000047")]
	public sealed class ALCAKGAKJIL : PDOMBIKABAA<INNIDLKKAIJ>
	{
		[Cpp2IlInjected.Token(Token = "0x2000048")]
		[CompilerGenerated]
		private sealed class MFAILCJGAHN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000CA")]
			public ALCAKGAKJIL <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000CB")]
			public BKKHOHENKFL nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x6000116")]
			[Cpp2IlInjected.Address(RVA = "0x86C4B0", Offset = "0x86AAB0", VA = "0x18086C4B0")]
			public MFAILCJGAHN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000117")]
			[Cpp2IlInjected.Address(RVA = "0x1FBD2B0", Offset = "0x1FBB8B0", VA = "0x181FBD2B0")]
			internal bool EEPGJPPHOAA()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000118")]
			[Cpp2IlInjected.Address(RVA = "0x1FBD330", Offset = "0x1FBB930", VA = "0x181FBD330")]
			internal void PHEGNFLGKBH(bool v)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x1FA8B00", Offset = "0x1FA7100", VA = "0x181FA8B00")]
		public ALCAKGAKJIL(PJNMBNAHIFL ALELNINOAGK, INNIDLKKAIJ AKLCDEBLEOF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x1FA88B0", Offset = "0x1FA6EB0", VA = "0x181FA88B0", Slot = "126")]
		protected override void NOFDDFDGBMI(GDJFKKGDGFJ KMONEIKIHIC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000049")]
	private sealed class CEJHEAFJCEK : FLCNKOKNGMP<CGOGJKCFDJK>
	{
		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public override NodeVisualizationKey EHBGNDCNEJA
		{
			[Cpp2IlInjected.Token(Token = "0x6000119")]
			[Cpp2IlInjected.Address(RVA = "0x8F3C30", Offset = "0x8F2230", VA = "0x1808F3C30", Slot = "91")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x1FAB490", Offset = "0x1FA9A90", VA = "0x181FAB490")]
		public CEJHEAFJCEK(PJNMBNAHIFL ALELNINOAGK, CGOGJKCFDJK EMDFCFPCFGG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004A")]
	public abstract class FLCNKOKNGMP<TNode> : DCANGPMKHHL<TNode> where TNode : notnull, DGJIBBFPMBB
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200004B")]
		[CompilerGenerated]
		private struct OIDIDBAOPOP : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D2")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D3")]
			public AsyncTaskMethodBuilder<CBDPDIPONCF<CGBGMGFBCKF<HGFEOPBBPIG>, FBDDJIHDMAI>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D4")]
			public FLCNKOKNGMP<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D5")]
			public string name;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D6")]
			private TaskAwaiter<CBDPDIPONCF<CGBGMGFBCKF<HGFEOPBBPIG>, FBDDJIHDMAI>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600013F")]
			[Cpp2IlInjected.Address(RVA = "0x46D9DB0", Offset = "0x46D83B0", VA = "0x1846D9DB0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000140")]
			[Cpp2IlInjected.Address(RVA = "0x46DA270", Offset = "0x46D8870", VA = "0x1846DA270", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200004C")]
		[CompilerGenerated]
		private struct AJLJJEBDBDA : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D7")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D8")]
			public AsyncTaskMethodBuilder<CBDPDIPONCF<COKMANPFJNC, FBDDJIHDMAI>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D9")]
			public FLCNKOKNGMP<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000DA")]
			public CGBGMGFBCKF<HGFEOPBBPIG> portGroupId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000DB")]
			private TaskAwaiter<CBDPDIPONCF<COKMANPFJNC, FBDDJIHDMAI>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000141")]
			[Cpp2IlInjected.Address(RVA = "0x3D6E030", Offset = "0x3D6C630", VA = "0x183D6E030", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000142")]
			[Cpp2IlInjected.Address(RVA = "0x3D6E4C0", Offset = "0x3D6CAC0", VA = "0x183D6E4C0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200004E")]
		[CompilerGenerated]
		private struct OGNBIHCIPBI : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000E0")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000E1")]
			public AsyncTaskMethodBuilder<CBDPDIPONCF<BDCBLKCBAEO, FBDDJIHDMAI>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000E2")]
			public FLCNKOKNGMP<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000E3")]
			private TaskAwaiter<CBDPDIPONCF<BDCBLKCBAEO, FBDDJIHDMAI>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000148")]
			[Cpp2IlInjected.Address(RVA = "0x46D5EE0", Offset = "0x46D44E0", VA = "0x1846D5EE0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000149")]
			[Cpp2IlInjected.Address(RVA = "0x46D65E0", Offset = "0x46D4BE0", VA = "0x1846D65E0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200004F")]
		[CompilerGenerated]
		private sealed class JFKNEBPAFDG
		{
			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x2000050")]
			private struct <<BuildConfigMenuInternal>b__7>d : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000E9")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000EA")]
				public AsyncVoidMethodBuilder <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000EB")]
				public JFKNEBPAFDG <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000EC")]
				private TaskAwaiter<TaskStatus> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x600014F")]
				[Cpp2IlInjected.Address(RVA = "0x35BA0B0", Offset = "0x35B86B0", VA = "0x1835BA0B0", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000150")]
				[Cpp2IlInjected.Address(RVA = "0xA20370", Offset = "0xA1E970", VA = "0x180A20370", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000E4")]
			public GDJFKKGDGFJ configure;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000E5")]
			public BKKHOHENKFL nodeAdapterDeps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000E6")]
			public FLCNKOKNGMP<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000E7")]
			public Func<string, bool> <>9__6;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000E8")]
			public Action <>9__7;

			[Cpp2IlInjected.Token(Token = "0x600014A")]
			[Cpp2IlInjected.Address(RVA = "0x86C4B0", Offset = "0x86AAB0", VA = "0x18086C4B0")]
			public JFKNEBPAFDG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600014B")]
			[Cpp2IlInjected.Address(RVA = "0x4086CA0", Offset = "0x40852A0", VA = "0x184086CA0")]
			internal bool LEKNKPMGLOF(string text)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600014C")]
			[Cpp2IlInjected.Address(RVA = "0x4086D80", Offset = "0x4085380", VA = "0x184086D80")]
			internal void MGLFNJMCMEN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600014D")]
			[Cpp2IlInjected.Address(RVA = "0x40867F0", Offset = "0x4084DF0", VA = "0x1840867F0")]
			[AsyncStateMachine(typeof(FLCNKOKNGMP<>.JFKNEBPAFDG.<<BuildConfigMenuInternal>b__7>d))]
			internal void KANOGPFMDHK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600014E")]
			[Cpp2IlInjected.Address(RVA = "0x4086890", Offset = "0x4084E90", VA = "0x184086890")]
			internal bool KGEOJKOADPA()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000051")]
		[CompilerGenerated]
		private sealed class IEHPJENPMIA
		{
			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x2000052")]
			private struct <<BuildConfigMenuInternal>b__5>d : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000F2")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000F3")]
				public AsyncVoidMethodBuilder <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000F4")]
				public IEHPJENPMIA <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000F5")]
				private TaskAwaiter<bool> <>u__1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000F6")]
				private TaskAwaiter<TaskStatus> <>u__2;

				[Cpp2IlInjected.Token(Token = "0x6000156")]
				[Cpp2IlInjected.Address(RVA = "0x35B9D30", Offset = "0x35B8330", VA = "0x1835B9D30", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000157")]
				[Cpp2IlInjected.Address(RVA = "0xA20370", Offset = "0xA1E970", VA = "0x180A20370", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000ED")]
			public string newFunctionName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000EE")]
			public JFKNEBPAFDG CS$<>8__locals1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000EF")]
			public Func<string> <>9__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000F0")]
			public Action<string> <>9__4;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000F1")]
			public Action <>9__5;

			[Cpp2IlInjected.Token(Token = "0x6000151")]
			[Cpp2IlInjected.Address(RVA = "0x86C4B0", Offset = "0x86AAB0", VA = "0x18086C4B0")]
			public IEHPJENPMIA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000152")]
			[Cpp2IlInjected.Address(RVA = "0x3E5F970", Offset = "0x3E5DF70", VA = "0x183E5F970")]
			internal void GLPPOLAGMCH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000153")]
			[Cpp2IlInjected.Address(RVA = "0x868220", Offset = "0x866820", VA = "0x180868220")]
			internal string PDHBGEGHGHC()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000154")]
			[Cpp2IlInjected.Address(RVA = "0x868250", Offset = "0x866850", VA = "0x180868250")]
			internal void AAMBPKPGDKI(string value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000155")]
			[Cpp2IlInjected.Address(RVA = "0x3E5FDA0", Offset = "0x3E5E3A0", VA = "0x183E5FDA0")]
			[AsyncStateMachine(typeof(FLCNKOKNGMP<>.IEHPJENPMIA.<<BuildConfigMenuInternal>b__5>d))]
			internal void NJBIAFHPNMH()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000053")]
		[CompilerGenerated]
		private sealed class OOPKNMLJMLL
		{
			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x2000054")]
			private struct <<AddDynamicNodeGroupSettingV2>b__2>d : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000105")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000106")]
				public AsyncVoidMethodBuilder <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000107")]
				public OOPKNMLJMLL <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000108")]
				private TaskAwaiter<TaskStatus> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x600016B")]
				[Cpp2IlInjected.Address(RVA = "0x35B9860", Offset = "0x35B7E60", VA = "0x1835B9860", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600016C")]
				[Cpp2IlInjected.Address(RVA = "0xA20370", Offset = "0xA1E970", VA = "0x180A20370", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x2000055")]
			private struct <<AddDynamicNodeGroupSettingV2>b__6>d : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000109")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400010A")]
				public AsyncVoidMethodBuilder <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400010B")]
				public OOPKNMLJMLL <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400010C")]
				private TaskAwaiter<CBDPDIPONCF<CGBGMGFBCKF<JJKDMNECOCJ>, FBDDJIHDMAI>> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x600016D")]
				[Cpp2IlInjected.Address(RVA = "0x35B9A40", Offset = "0x35B8040", VA = "0x1835B9A40", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600016E")]
				[Cpp2IlInjected.Address(RVA = "0xA20370", Offset = "0xA1E970", VA = "0x180A20370", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x2000056")]
			private struct <<AddDynamicNodeGroupSettingV2>b__10>d : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400010D")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400010E")]
				public AsyncVoidMethodBuilder <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400010F")]
				public OOPKNMLJMLL <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000110")]
				private TaskAwaiter<CBDPDIPONCF<CGBGMGFBCKF<FLNLEKBDPAB>, FBDDJIHDMAI>> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x600016F")]
				[Cpp2IlInjected.Address(RVA = "0x35B9190", Offset = "0x35B7790", VA = "0x1835B9190", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000170")]
				[Cpp2IlInjected.Address(RVA = "0xA20370", Offset = "0xA1E970", VA = "0x180A20370", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000F7")]
			public FLCNKOKNGMP<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000F8")]
			public CGBGMGFBCKF<HGFEOPBBPIG> portGroupId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000F9")]
			public GDJFKKGDGFJ configure;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000FA")]
			public BKKHOHENKFL nodeAdapterDeps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000FB")]
			public PDDIJOAHCGO nodeGroupAdapter;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000FC")]
			public int minGroupIndex;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000FD")]
			public int maxGroupIndex;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000FE")]
			public GPEGJBGOEPB selectedInputType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000FF")]
			public string newInputFieldLabel;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000100")]
			public List<KPLJPKPGNLN> inputs;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000101")]
			public GPEGJBGOEPB selectedOutputType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000102")]
			public string newOutputFieldLabel;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000103")]
			public List<KPLJPKPGNLN> outputs;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000104")]
			public Func<string, bool> <>9__17;

			[Cpp2IlInjected.Token(Token = "0x6000158")]
			[Cpp2IlInjected.Address(RVA = "0x86C4B0", Offset = "0x86AAB0", VA = "0x18086C4B0")]
			public OOPKNMLJMLL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000159")]
			[Cpp2IlInjected.Address(RVA = "0x46FB750", Offset = "0x46F9D50", VA = "0x1846FB750")]
			internal bool LCMOEGBEPGE()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600015A")]
			[Cpp2IlInjected.Address(RVA = "0x46FB990", Offset = "0x46F9F90", VA = "0x1846FB990")]
			internal void OPBIIBMHPGD(bool value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600015B")]
			[Cpp2IlInjected.Address(RVA = "0x46FB670", Offset = "0x46F9C70", VA = "0x1846FB670")]
			internal bool KGKHANPGABN(string text)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600015C")]
			[Cpp2IlInjected.Address(RVA = "0x46FB390", Offset = "0x46F9990", VA = "0x1846FB390")]
			internal bool FHLKBOCGOPD()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600015D")]
			[Cpp2IlInjected.Address(RVA = "0x46FB240", Offset = "0x46F9840", VA = "0x1846FB240")]
			[AsyncStateMachine(typeof(FLCNKOKNGMP<>.OOPKNMLJMLL.<<AddDynamicNodeGroupSettingV2>b__2>d))]
			internal void DLGCNIALACN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600015E")]
			[Cpp2IlInjected.Address(RVA = "0x46FB350", Offset = "0x46F9950", VA = "0x1846FB350")]
			internal bool EIMNCDJELEP()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600015F")]
			[Cpp2IlInjected.Address(RVA = "0x46FB860", Offset = "0x46F9E60", VA = "0x1846FB860")]
			internal void NPBDOCBBHPO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000160")]
			[Cpp2IlInjected.Address(RVA = "0x46FB4A0", Offset = "0x46F9AA0", VA = "0x1846FB4A0")]
			internal bool HCMDCJMFBJM()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000161")]
			[Cpp2IlInjected.Address(RVA = "0x46FB0E0", Offset = "0x46F96E0", VA = "0x1846FB0E0")]
			internal void AOLLMNKCDGL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000162")]
			[Cpp2IlInjected.Address(RVA = "0x46FB550", Offset = "0x46F9B50", VA = "0x1846FB550")]
			internal bool JICKKEBJIEB()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000163")]
			[Cpp2IlInjected.Address(RVA = "0x46FB3D0", Offset = "0x46F99D0", VA = "0x1846FB3D0")]
			internal bool GIGEMALNMEG()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000164")]
			[Cpp2IlInjected.Address(RVA = "0x46FB600", Offset = "0x46F9C00", VA = "0x1846FB600")]
			internal void JNILEEPNOBD(bool value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000165")]
			[Cpp2IlInjected.Address(RVA = "0x46FB7C0", Offset = "0x46F9DC0", VA = "0x1846FB7C0")]
			[AsyncStateMachine(typeof(FLCNKOKNGMP<>.OOPKNMLJMLL.<<AddDynamicNodeGroupSettingV2>b__6>d))]
			internal void LEMAIBPOKDO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000166")]
			[Cpp2IlInjected.Address(RVA = "0x46FBA00", Offset = "0x46FA000", VA = "0x1846FBA00")]
			internal bool PKPPDIHNAFG()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000167")]
			[Cpp2IlInjected.Address(RVA = "0x46FB920", Offset = "0x46F9F20", VA = "0x1846FB920")]
			internal bool OFHMICIFKPH()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000168")]
			[Cpp2IlInjected.Address(RVA = "0x46FB2E0", Offset = "0x46F98E0", VA = "0x1846FB2E0")]
			internal void EHPANMIMLIO(bool value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000169")]
			[Cpp2IlInjected.Address(RVA = "0x46FB1A0", Offset = "0x46F97A0", VA = "0x1846FB1A0")]
			[AsyncStateMachine(typeof(FLCNKOKNGMP<>.OOPKNMLJMLL.<<AddDynamicNodeGroupSettingV2>b__10>d))]
			internal void BDDMFKJNJID()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600016A")]
			[Cpp2IlInjected.Address(RVA = "0x46FB440", Offset = "0x46F9A40", VA = "0x1846FB440")]
			internal bool GMMPOEKDAPI()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000057")]
		[CompilerGenerated]
		private sealed class KMIOGHIHDJH
		{
			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x2000058")]
			private struct <<AddDynamicNodeGroupSettingV2>b__16>d : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000116")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000117")]
				public AsyncVoidMethodBuilder <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000118")]
				public KMIOGHIHDJH <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000119")]
				private TaskAwaiter<bool> <>u__1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400011A")]
				private TaskAwaiter<CBDPDIPONCF<COKMANPFJNC, FBDDJIHDMAI>> <>u__2;

				[Cpp2IlInjected.Token(Token = "0x6000176")]
				[Cpp2IlInjected.Address(RVA = "0x35B9480", Offset = "0x35B7A80", VA = "0x1835B9480", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000177")]
				[Cpp2IlInjected.Address(RVA = "0xA20370", Offset = "0xA1E970", VA = "0x180A20370", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000111")]
			public string newName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000112")]
			public OOPKNMLJMLL CS$<>8__locals1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000113")]
			public Func<string> <>9__14;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000114")]
			public Action<string> <>9__15;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000115")]
			public Action <>9__16;

			[Cpp2IlInjected.Token(Token = "0x6000171")]
			[Cpp2IlInjected.Address(RVA = "0x86C4B0", Offset = "0x86AAB0", VA = "0x18086C4B0")]
			public KMIOGHIHDJH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000172")]
			[Cpp2IlInjected.Address(RVA = "0x41C5580", Offset = "0x41C3B80", VA = "0x1841C5580")]
			internal void KEFJHDEHONK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000173")]
			[Cpp2IlInjected.Address(RVA = "0x868220", Offset = "0x866820", VA = "0x180868220")]
			internal string JMNDEHMLCMK()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000174")]
			[Cpp2IlInjected.Address(RVA = "0x868250", Offset = "0x866850", VA = "0x180868250")]
			internal void PLHMHHIILDM(string value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000175")]
			[Cpp2IlInjected.Address(RVA = "0x41C54E0", Offset = "0x41C3AE0", VA = "0x1841C54E0")]
			[AsyncStateMachine(typeof(FLCNKOKNGMP<>.KMIOGHIHDJH.<<AddDynamicNodeGroupSettingV2>b__16>d))]
			internal void EBIEMOPAAHC()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000059")]
		[CompilerGenerated]
		private sealed class OAECKBFIMFM
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400011B")]
			public bool inputs;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400011C")]
			public PDDIJOAHCGO nodeGroupAdapter;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400011D")]
			public List<KPLJPKPGNLN> portMenu;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400011E")]
			public FLCNKOKNGMP<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400011F")]
			public CGBGMGFBCKF<HGFEOPBBPIG> portGroupId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000120")]
			public int portCount;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000121")]
			public Func<bool> <>9__1;

			[Cpp2IlInjected.Token(Token = "0x6000178")]
			[Cpp2IlInjected.Address(RVA = "0x86C4B0", Offset = "0x86AAB0", VA = "0x18086C4B0")]
			public OAECKBFIMFM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000179")]
			[Cpp2IlInjected.Address(RVA = "0x46AE9E0", Offset = "0x46ACFE0", VA = "0x1846AE9E0")]
			internal bool GDGEINENFNO()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200005A")]
		[CompilerGenerated]
		private sealed class GKFGPABLFGE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000122")]
			public GFPIIFJFFHL port;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000123")]
			public OAECKBFIMFM CS$<>8__locals1;

			[Cpp2IlInjected.Token(Token = "0x600017A")]
			[Cpp2IlInjected.Address(RVA = "0x86C4B0", Offset = "0x86AAB0", VA = "0x18086C4B0")]
			public GKFGPABLFGE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600017B")]
			[Cpp2IlInjected.Address(RVA = "0x3D35F50", Offset = "0x3D34550", VA = "0x183D35F50")]
			internal void CFEHLGDKFPH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600017C")]
			[Cpp2IlInjected.Address(RVA = "0x3D36180", Offset = "0x3D34780", VA = "0x183D36180")]
			internal bool GKNOEAIJOMO()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600017D")]
			[Cpp2IlInjected.Address(RVA = "0x3D36060", Offset = "0x3D34660", VA = "0x183D36060")]
			internal void CKDABMHLJAJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600017E")]
			[Cpp2IlInjected.Address(RVA = "0x3D361D0", Offset = "0x3D347D0", VA = "0x183D361D0")]
			internal bool PHENJFJKMBI()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200005B")]
		[CompilerGenerated]
		private sealed class ILFOPIKFNOF
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000124")]
			public KPLJPKPGNLN portControls;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000125")]
			public GKFGPABLFGE CS$<>8__locals2;

			[Cpp2IlInjected.Token(Token = "0x600017F")]
			[Cpp2IlInjected.Address(RVA = "0x86C4B0", Offset = "0x86AAB0", VA = "0x18086C4B0")]
			public ILFOPIKFNOF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000180")]
			[Cpp2IlInjected.Address(RVA = "0x3E81C90", Offset = "0x3E80290", VA = "0x183E81C90")]
			internal void OANNFPFACDB()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200005C")]
		[CompilerGenerated]
		private sealed class MDCDDNOKKJP
		{
			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x200005D")]
			private struct <<CreatePortItemV2>b__3>d : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400012D")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400012E")]
				public AsyncVoidMethodBuilder <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400012F")]
				public MDCDDNOKKJP <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000130")]
				public string value;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000131")]
				private TaskAwaiter<bool> <>u__1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000132")]
				private TaskAwaiter<CBDPDIPONCF<COKMANPFJNC, FBDDJIHDMAI>> <>u__2;

				[Cpp2IlInjected.Token(Token = "0x6000187")]
				[Cpp2IlInjected.Address(RVA = "0x35BB520", Offset = "0x35B9B20", VA = "0x1835BB520", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000188")]
				[Cpp2IlInjected.Address(RVA = "0xA20370", Offset = "0xA1E970", VA = "0x180A20370", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000126")]
			public List<object> allTypeObjects;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000127")]
			public GPEGJBGOEPB selectedType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000128")]
			public bool inputs;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000129")]
			public PDDIJOAHCGO nodeGroupAdapter;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400012A")]
			public GFPIIFJFFHL port;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400012B")]
			public string newName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400012C")]
			public BKKHOHENKFL nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x6000181")]
			[Cpp2IlInjected.Address(RVA = "0x86C4B0", Offset = "0x86AAB0", VA = "0x18086C4B0")]
			public MDCDDNOKKJP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000182")]
			[Cpp2IlInjected.Address(RVA = "0x44BD340", Offset = "0x44BB940", VA = "0x1844BD340")]
			internal int ALLPABHCAMG()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000183")]
			[Cpp2IlInjected.Address(RVA = "0x44BD520", Offset = "0x44BBB20", VA = "0x1844BD520")]
			internal void OJKNCFAAEPF(int val)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000184")]
			[Cpp2IlInjected.Address(RVA = "0x868EE0", Offset = "0x8674E0", VA = "0x180868EE0")]
			internal string EBIKALHEELC()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000185")]
			[Cpp2IlInjected.Address(RVA = "0x44BD380", Offset = "0x44BB980", VA = "0x1844BD380")]
			[AsyncStateMachine(typeof(FLCNKOKNGMP<>.MDCDDNOKKJP.<<CreatePortItemV2>b__3>d))]
			internal void GANNIFIIDEP(string value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000186")]
			[Cpp2IlInjected.Address(RVA = "0x44BD440", Offset = "0x44BBA40", VA = "0x1844BD440")]
			internal bool JFLIBCEMBFB(string text)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		private readonly Dictionary<CGBGMGFBCKF<HGFEOPBBPIG>, bool> MDHHJIDFHGP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		private readonly Dictionary<CGBGMGFBCKF<HGFEOPBBPIG>, bool> IEBKELFFIBD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		private readonly Dictionary<CGBGMGFBCKF<HGFEOPBBPIG>, bool> JJHJIFIELNC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		private Dictionary<CGBGMGFBCKF<HGFEOPBBPIG>, bool> KNDINCFLCMP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		private Dictionary<CGBGMGFBCKF<HGFEOPBBPIG>, bool> MGPHCKOJPIK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		private Dictionary<CGBGMGFBCKF<HGFEOPBBPIG>, bool> AKIEENHJAKF;

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public override bool DKPCAJPJEOH
		{
			[Cpp2IlInjected.Token(Token = "0x600011B")]
			[Cpp2IlInjected.Address(RVA = "0x881710", Offset = "0x87FD10", VA = "0x180881710", Slot = "122")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		protected virtual bool DMPBLEDKEPJ
		{
			[Cpp2IlInjected.Token(Token = "0x600011C")]
			[Cpp2IlInjected.Address(RVA = "0x881710", Offset = "0x87FD10", VA = "0x180881710", Slot = "126")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		protected virtual bool DCJENBFGBFM
		{
			[Cpp2IlInjected.Token(Token = "0x600011D")]
			[Cpp2IlInjected.Address(RVA = "0x881710", Offset = "0x87FD10", VA = "0x180881710", Slot = "127")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		protected virtual bool PHGABNCKCLP
		{
			[Cpp2IlInjected.Token(Token = "0x600011E")]
			[Cpp2IlInjected.Address(RVA = "0x881710", Offset = "0x87FD10", VA = "0x180881710", Slot = "128")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public override CGBGMGFBCKF<NPIPKFBHIBO>? FHJFMOPJJKD
		{
			[Cpp2IlInjected.Token(Token = "0x600011F")]
			[Cpp2IlInjected.Address(RVA = "0x3C38030", Offset = "0x3C36630", VA = "0x183C38030", Slot = "116")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public override CGBGMGFBCKF<HGFEOPBBPIG>? EGGCNCGGPCM
		{
			[Cpp2IlInjected.Token(Token = "0x6000120")]
			[Cpp2IlInjected.Address(RVA = "0x3C38310", Offset = "0x3C36910", VA = "0x183C38310", Slot = "119")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public override IEnumerable<HBIPEINCKFG<JBMJEMLAFJB>>? HMFMHOKBOJA
		{
			[Cpp2IlInjected.Token(Token = "0x600012B")]
			[Cpp2IlInjected.Address(RVA = "0x3C380F0", Offset = "0x3C366F0", VA = "0x183C380F0", Slot = "111")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x3C37E10", Offset = "0x3C36410", VA = "0x183C37E10")]
		public FLCNKOKNGMP(PJNMBNAHIFL ALELNINOAGK, TNode EMDFCFPCFGG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x881710", Offset = "0x87FD10", VA = "0x180881710", Slot = "129")]
		protected virtual bool PHBEAJKNMKP(int GKMANBBJOMA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x881710", Offset = "0x87FD10", VA = "0x180881710", Slot = "130")]
		protected virtual bool ICCLHDLCPJI(int GKMANBBJOMA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x881710", Offset = "0x87FD10", VA = "0x180881710", Slot = "131")]
		protected virtual bool MPCELMBHKPG(int GKMANBBJOMA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x867790", Offset = "0x865D90", VA = "0x180867790", Slot = "132")]
		protected virtual void JGOHHAMDEFP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x3C36FB0", Offset = "0x3C355B0", VA = "0x183C36FB0", Slot = "124")]
		public override bool JCHBGBLIJGB(CGBGMGFBCKF<HGFEOPBBPIG> GKEOEKGAILK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x3C37CF0", Offset = "0x3C362F0", VA = "0x183C37CF0", Slot = "100")]
		[AsyncStateMachine(typeof(FLCNKOKNGMP<>.OIDIDBAOPOP))]
		public override Task<CBDPDIPONCF<CGBGMGFBCKF<HGFEOPBBPIG>, FBDDJIHDMAI>> OMABNNMENMJ(string GJEDHMJMNJA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x3C36DA0", Offset = "0x3C353A0", VA = "0x183C36DA0", Slot = "101")]
		[AsyncStateMachine(typeof(FLCNKOKNGMP<>.AJLJJEBDBDA))]
		public override Task<CBDPDIPONCF<COKMANPFJNC, FBDDJIHDMAI>> GHBJPLCMBLJ(CGBGMGFBCKF<HGFEOPBBPIG> GKEOEKGAILK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x3C33E10", Offset = "0x3C32410", VA = "0x183C33E10", Slot = "102")]
		public override void AECGFIDLIOF(CGBGMGFBCKF<HGFEOPBBPIG> PDMMEDBMFPP, CGBGMGFBCKF<HGFEOPBBPIG> PABFDMCLKCE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x3C35390", Offset = "0x3C33990", VA = "0x183C35390", Slot = "103")]
		public override IEnumerable<EIJGBFLAMII> EGNMLFCDJNN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x3C36EB0", Offset = "0x3C354B0", VA = "0x183C36EB0")]
		[AsyncStateMachine(typeof(FLCNKOKNGMP<>.OGNBIHCIPBI))]
		private Task<CBDPDIPONCF<BDCBLKCBAEO, FBDDJIHDMAI>> ICCKDFEIKGE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x881710", Offset = "0x87FD10", VA = "0x180881710", Slot = "133")]
		protected virtual bool LPFABKODICB(CGBGMGFBCKF<HGFEOPBBPIG> GKEOEKGAILK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x881710", Offset = "0x87FD10", VA = "0x180881710", Slot = "134")]
		protected virtual bool LDGMAKLFNAP(CGBGMGFBCKF<HGFEOPBBPIG> GKEOEKGAILK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x881710", Offset = "0x87FD10", VA = "0x180881710", Slot = "135")]
		protected virtual bool KCDCCJFFOOF(CGBGMGFBCKF<HGFEOPBBPIG> GKEOEKGAILK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x881710", Offset = "0x87FD10", VA = "0x180881710", Slot = "136")]
		protected virtual bool NFDOLHFGDBF(CGBGMGFBCKF<HGFEOPBBPIG> GKEOEKGAILK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x881710", Offset = "0x87FD10", VA = "0x180881710", Slot = "137")]
		protected virtual bool OGOGHDJGLAH(CGBGMGFBCKF<HGFEOPBBPIG> GKEOEKGAILK, int GEEOEHKGGHC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x881710", Offset = "0x87FD10", VA = "0x180881710", Slot = "138")]
		protected virtual bool HELGGMGCPHB(CGBGMGFBCKF<HGFEOPBBPIG> GKEOEKGAILK, int GEEOEHKGGHC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x881710", Offset = "0x87FD10", VA = "0x180881710", Slot = "139")]
		protected virtual bool PFPDAMJNGJC(CGBGMGFBCKF<HGFEOPBBPIG> GKEOEKGAILK, int CKGKCNOKOJB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x881710", Offset = "0x87FD10", VA = "0x180881710", Slot = "140")]
		protected virtual bool GNKKGDLEFFB(CGBGMGFBCKF<HGFEOPBBPIG> GKEOEKGAILK, int CKGKCNOKOJB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x881710", Offset = "0x87FD10", VA = "0x180881710", Slot = "141")]
		protected virtual bool IAIEENMNKJC(CGBGMGFBCKF<HGFEOPBBPIG> GKEOEKGAILK, int AFHHNDIHHIG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x881710", Offset = "0x87FD10", VA = "0x180881710", Slot = "142")]
		protected virtual bool NDEHKMLNIMD(CGBGMGFBCKF<HGFEOPBBPIG> GKEOEKGAILK, int GMIICDFKBBD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x3C37050", Offset = "0x3C35650", VA = "0x183C37050", Slot = "143")]
		protected virtual List<GPEGJBGOEPB> JOKECNAFHPF(CGBGMGFBCKF<HGFEOPBBPIG> GKEOEKGAILK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x867790", Offset = "0x865D90", VA = "0x180867790", Slot = "144")]
		protected virtual void HJNLJJAJHND(GDJFKKGDGFJ KMONEIKIHIC, MGEDFGMGGPN GBHNOCNINJM, PDDIJOAHCGO FADLBPICCBD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x3C33380", Offset = "0x3C31980", VA = "0x183C33380", Slot = "120")]
		protected override void AANCPJNHLHN(GDJFKKGDGFJ KMONEIKIHIC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x3C35620", Offset = "0x3C33C20", VA = "0x183C35620")]
		private MGEDFGMGGPN EHBJOFKEOEK(GDJFKKGDGFJ KMONEIKIHIC, PDDIJOAHCGO FADLBPICCBD, CGBGMGFBCKF<HGFEOPBBPIG> GKEOEKGAILK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x3C34020", Offset = "0x3C32620", VA = "0x183C34020")]
		private List<KPLJPKPGNLN> CMMPHFLNLKJ(GDJFKKGDGFJ KMONEIKIHIC, PDDIJOAHCGO FADLBPICCBD, MGEDFGMGGPN PGCJBBGAPAD, bool CJDHDEHLPDF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x3C37390", Offset = "0x3C35990", VA = "0x183C37390")]
		private List<KPLJPKPGNLN> NOFPHDLDAPL(GDJFKKGDGFJ KMONEIKIHIC, PDDIJOAHCGO FADLBPICCBD, GFPIIFJFFHL OJDLGPLPDJG, bool CJDHDEHLPDF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x3C351A0", Offset = "0x3C337A0", VA = "0x183C351A0")]
		private GPEGJBGOEPB CPFGOEJOBEL(List<GPEGJBGOEPB> BNFFMFODPHJ, GFPIIFJFFHL OJDLGPLPDJG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x3C372F0", Offset = "0x3C358F0", VA = "0x183C372F0")]
		[CompilerGenerated]
		private EIJGBFLAMII MDBOOAIPLIP(JJAEOPCJMCB BILDLIKNGJF)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005E")]
	public sealed class KDONJAIOBGK : DCANGPMKHHL<MFKHCIBAEIN>
	{
		[Cpp2IlInjected.Token(Token = "0x200005F")]
		[CompilerGenerated]
		private sealed class DFLEKLPFFLA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000133")]
			public KDONJAIOBGK <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000134")]
			public BKKHOHENKFL nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x600018C")]
			[Cpp2IlInjected.Address(RVA = "0x86C4B0", Offset = "0x86AAB0", VA = "0x18086C4B0")]
			public DFLEKLPFFLA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600018D")]
			[Cpp2IlInjected.Address(RVA = "0x1FABA20", Offset = "0x1FAA020", VA = "0x181FABA20")]
			internal int MGLFNJMCMEN()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x600018E")]
			[Cpp2IlInjected.Address(RVA = "0x1FAB990", Offset = "0x1FA9F90", VA = "0x181FAB990")]
			internal void KGEOJKOADPA(int colorIndex)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public override NodeVisualizationKey EHBGNDCNEJA
		{
			[Cpp2IlInjected.Token(Token = "0x600018A")]
			[Cpp2IlInjected.Address(RVA = "0x8EF840", Offset = "0x8EDE40", VA = "0x1808EF840", Slot = "91")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x1FBC9B0", Offset = "0x1FBAFB0", VA = "0x181FBC9B0")]
		public KDONJAIOBGK(PJNMBNAHIFL ALELNINOAGK, MFKHCIBAEIN EMDFCFPCFGG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x1FBC7F0", Offset = "0x1FBADF0", VA = "0x181FBC7F0", Slot = "120")]
		protected override void AANCPJNHLHN(GDJFKKGDGFJ KMONEIKIHIC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000060")]
	public sealed class CEBBBDIDDDA : PDOMBIKABAA<NNLCEOOABJN>
	{
		[Cpp2IlInjected.Token(Token = "0x2000061")]
		[CompilerGenerated]
		private sealed class NOLKNJBCFAO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000135")]
			public CEBBBDIDDDA <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000136")]
			public BKKHOHENKFL nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x6000191")]
			[Cpp2IlInjected.Address(RVA = "0x86C4B0", Offset = "0x86AAB0", VA = "0x18086C4B0")]
			public NOLKNJBCFAO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000192")]
			[Cpp2IlInjected.Address(RVA = "0x1FBFE70", Offset = "0x1FBE470", VA = "0x181FBFE70")]
			internal int EEPGJPPHOAA()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000193")]
			[Cpp2IlInjected.Address(RVA = "0x1FBFEF0", Offset = "0x1FBE4F0", VA = "0x181FBFEF0")]
			internal void PHEGNFLGKBH(int colorIndex)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x1FAB430", Offset = "0x1FA9A30", VA = "0x181FAB430")]
		public CEBBBDIDDDA(PJNMBNAHIFL ALELNINOAGK, NNLCEOOABJN AKLCDEBLEOF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x1FAB1F0", Offset = "0x1FA97F0", VA = "0x181FAB1F0", Slot = "126")]
		protected override void NOFDDFDGBMI(GDJFKKGDGFJ KMONEIKIHIC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000062")]
	private sealed class NPNDHOPIIDN : DCANGPMKHHL<JOPLOEBDKBB>
	{
		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public override NodeVisualizationKey EHBGNDCNEJA
		{
			[Cpp2IlInjected.Token(Token = "0x6000194")]
			[Cpp2IlInjected.Address(RVA = "0x8F6D30", Offset = "0x8F5330", VA = "0x1808F6D30", Slot = "91")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x1FBFF90", Offset = "0x1FBE590", VA = "0x181FBFF90")]
		public NPNDHOPIIDN(PJNMBNAHIFL ALELNINOAGK, JOPLOEBDKBB EMDFCFPCFGG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x867790", Offset = "0x865D90", VA = "0x180867790", Slot = "120")]
		protected override void AANCPJNHLHN(GDJFKKGDGFJ KMONEIKIHIC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000063")]
	public sealed class JLLOIKPAMOD : DCANGPMKHHL<IEHHOKNMOAI>
	{
		[Cpp2IlInjected.Token(Token = "0x2000064")]
		[CompilerGenerated]
		private sealed class GGDBAOKNHKJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000138")]
			public JLLOIKPAMOD <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000139")]
			public GDJFKKGDGFJ configure;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400013A")]
			public Func<string> <>9__224;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400013B")]
			public Action<string> <>9__225;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400013C")]
			public Func<int> <>9__228;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400013D")]
			public Action<int> <>9__229;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400013E")]
			public Func<bool> <>9__230;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400013F")]
			public Func<bool> <>9__231;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000140")]
			public Func<bool> <>9__232;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4000141")]
			public Func<float> <>9__233;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x4000142")]
			public Action<float> <>9__234;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x4000143")]
			public Func<bool> <>9__235;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x4000144")]
			public Func<bool> <>9__236;

			[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
			[Cpp2IlInjected.Token(Token = "0x4000145")]
			public Func<bool> <>9__237;

			[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
			[Cpp2IlInjected.Token(Token = "0x4000146")]
			public Func<string> <>9__238;

			[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
			[Cpp2IlInjected.Token(Token = "0x4000147")]
			public Action<string> <>9__239;

			[Cpp2IlInjected.Token(Token = "0x6000199")]
			[Cpp2IlInjected.Address(RVA = "0x86C4B0", Offset = "0x86AAB0", VA = "0x18086C4B0")]
			public GGDBAOKNHKJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600019A")]
			[Cpp2IlInjected.Address(RVA = "0x1FB72D0", Offset = "0x1FB58D0", VA = "0x181FB72D0")]
			internal bool MGLFNJMCMEN()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600019B")]
			[Cpp2IlInjected.Address(RVA = "0x1FB67F0", Offset = "0x1FB4DF0", VA = "0x181FB67F0")]
			internal void KGEOJKOADPA(bool x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600019C")]
			[Cpp2IlInjected.Address(RVA = "0x1FADAD0", Offset = "0x1FAC0D0", VA = "0x181FADAD0")]
			internal bool AAMBPKPGDKI()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600019D")]
			[Cpp2IlInjected.Address(RVA = "0x1FB7AB0", Offset = "0x1FB60B0", VA = "0x181FB7AB0")]
			internal bool NJBIAFHPNMH()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600019E")]
			[Cpp2IlInjected.Address(RVA = "0x1FB6DA0", Offset = "0x1FB53A0", VA = "0x181FB6DA0")]
			internal void LEKNKPMGLOF(bool x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600019F")]
			[Cpp2IlInjected.Address(RVA = "0x1FB6A00", Offset = "0x1FB5000", VA = "0x181FB6A00")]
			internal bool KLLKKHMCDPD()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001A0")]
			[Cpp2IlInjected.Address(RVA = "0x1FAF9E0", Offset = "0x1FADFE0", VA = "0x181FAF9E0")]
			internal bool HPHIAECADLD()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001A1")]
			[Cpp2IlInjected.Address(RVA = "0x1FAE4F0", Offset = "0x1FACAF0", VA = "0x181FAE4F0")]
			internal void CGNAFIIFHFC(bool x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A2")]
			[Cpp2IlInjected.Address(RVA = "0x1FAE1D0", Offset = "0x1FAC7D0", VA = "0x181FAE1D0")]
			internal bool BNFANILJMNA()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001A3")]
			[Cpp2IlInjected.Address(RVA = "0x1FB5B90", Offset = "0x1FB4190", VA = "0x181FB5B90")]
			internal bool HPLOPFDELJC()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001A4")]
			[Cpp2IlInjected.Address(RVA = "0x1FB6BB0", Offset = "0x1FB51B0", VA = "0x181FB6BB0")]
			internal void LAJIJEAMMML(bool x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A5")]
			[Cpp2IlInjected.Address(RVA = "0x1FB7030", Offset = "0x1FB5630", VA = "0x181FB7030")]
			internal bool LPDKAGMDNJO()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001A6")]
			[Cpp2IlInjected.Address(RVA = "0x1FB6650", Offset = "0x1FB4C50", VA = "0x181FB6650")]
			internal bool KEAHIMFCBJL()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001A7")]
			[Cpp2IlInjected.Address(RVA = "0x1FB8480", Offset = "0x1FB6A80", VA = "0x181FB8480")]
			internal bool OMNNLJKNPOG()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001A8")]
			[Cpp2IlInjected.Address(RVA = "0x1FAE060", Offset = "0x1FAC660", VA = "0x181FAE060")]
			internal bool BIBDKKPPFOK()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001A9")]
			[Cpp2IlInjected.Address(RVA = "0x1FAF760", Offset = "0x1FADD60", VA = "0x181FAF760")]
			internal bool HIAPDFOMHFA()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001AA")]
			[Cpp2IlInjected.Address(RVA = "0x1FADEC0", Offset = "0x1FAC4C0", VA = "0x181FADEC0")]
			internal bool ALKNONEPGJO()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001AB")]
			[Cpp2IlInjected.Address(RVA = "0x1FB68A0", Offset = "0x1FB4EA0", VA = "0x181FB68A0")]
			internal bool KIDNPENDAKO()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001AC")]
			[Cpp2IlInjected.Address(RVA = "0x1FB60A0", Offset = "0x1FB46A0", VA = "0x181FB60A0")]
			internal bool ILEKHLDNMNH()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001AD")]
			[Cpp2IlInjected.Address(RVA = "0x1FAE940", Offset = "0x1FACF40", VA = "0x181FAE940")]
			internal bool ECLIGLBGGIE()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001AE")]
			[Cpp2IlInjected.Address(RVA = "0x1FAE0B0", Offset = "0x1FAC6B0", VA = "0x181FAE0B0")]
			internal void BJJELAIPAAM(bool x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001AF")]
			[Cpp2IlInjected.Address(RVA = "0x1FB6050", Offset = "0x1FB4650", VA = "0x181FB6050")]
			internal bool IKEGGKLKGJI()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001B0")]
			[Cpp2IlInjected.Address(RVA = "0x1FB5C30", Offset = "0x1FB4230", VA = "0x181FB5C30")]
			internal bool ICADFGCCHGM()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001B1")]
			[Cpp2IlInjected.Address(RVA = "0x1FADBC0", Offset = "0x1FAC1C0", VA = "0x181FADBC0")]
			internal bool AECMCDHKMAE()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001B2")]
			[Cpp2IlInjected.Address(RVA = "0x1FAE850", Offset = "0x1FACE50", VA = "0x181FAE850")]
			internal bool EAGCFKIHHOI()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001B3")]
			[Cpp2IlInjected.Address(RVA = "0x1FB6B60", Offset = "0x1FB5160", VA = "0x181FB6B60")]
			internal bool LAGKEPIPKIP()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001B4")]
			[Cpp2IlInjected.Address(RVA = "0x1FAE760", Offset = "0x1FACD60", VA = "0x181FAE760")]
			internal bool DIPCGPKMCGN()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001B5")]
			[Cpp2IlInjected.Address(RVA = "0x1FB7870", Offset = "0x1FB5E70", VA = "0x181FB7870")]
			internal bool NELIFBPBMAD()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001B6")]
			[Cpp2IlInjected.Address(RVA = "0x1FB62D0", Offset = "0x1FB48D0", VA = "0x181FB62D0")]
			internal bool JDFIBFLIPAO()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001B7")]
			[Cpp2IlInjected.Address(RVA = "0x1FAEEB0", Offset = "0x1FAD4B0", VA = "0x181FAEEB0")]
			internal void FHCIKEOMPGI(bool x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001B8")]
			[Cpp2IlInjected.Address(RVA = "0x1FAEDA0", Offset = "0x1FAD3A0", VA = "0x181FAEDA0")]
			internal bool FAOBGFHHIDC()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001B9")]
			[Cpp2IlInjected.Address(RVA = "0x1FAE9E0", Offset = "0x1FACFE0", VA = "0x181FAE9E0")]
			internal bool EDOKKGIGODI()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001BA")]
			[Cpp2IlInjected.Address(RVA = "0x1FAF2A0", Offset = "0x1FAD8A0", VA = "0x181FAF2A0")]
			internal void GKMFICLPDGN(bool x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001BB")]
			[Cpp2IlInjected.Address(RVA = "0x1FAF7B0", Offset = "0x1FADDB0", VA = "0x181FAF7B0")]
			internal bool HKNNMMMCONE()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001BC")]
			[Cpp2IlInjected.Address(RVA = "0x1FB85E0", Offset = "0x1FB6BE0", VA = "0x181FB85E0")]
			internal bool PDHIKNCBDMF()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001BD")]
			[Cpp2IlInjected.Address(RVA = "0x1FB8830", Offset = "0x1FB6E30", VA = "0x181FB8830")]
			internal void POGINKOIENO(bool x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001BE")]
			[Cpp2IlInjected.Address(RVA = "0x1FAFA30", Offset = "0x1FAE030", VA = "0x181FAFA30")]
			internal List<KPLJPKPGNLN> HPLCNKMIAEP(string secondaryLabel)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001BF")]
			[Cpp2IlInjected.Address(RVA = "0x1FAF190", Offset = "0x1FAD790", VA = "0x181FAF190")]
			internal bool GIBCBFODICP()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001C0")]
			[Cpp2IlInjected.Address(RVA = "0x1FB7230", Offset = "0x1FB5830", VA = "0x181FB7230")]
			internal int MGAAOOBHJPB()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60001C1")]
			[Cpp2IlInjected.Address(RVA = "0x1FB7A00", Offset = "0x1FB6000", VA = "0x181FB7A00")]
			internal void NHGBIEFFKJE(int x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C2")]
			[Cpp2IlInjected.Address(RVA = "0x1FB6EA0", Offset = "0x1FB54A0", VA = "0x181FB6EA0")]
			internal bool LHBDFJNFMIC()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001C3")]
			[Cpp2IlInjected.Address(RVA = "0x1FAF5B0", Offset = "0x1FADBB0", VA = "0x181FAF5B0")]
			internal bool HGINGLLEIEC()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001C4")]
			[Cpp2IlInjected.Address(RVA = "0x1FAF850", Offset = "0x1FADE50", VA = "0x181FAF850")]
			internal bool HNMMDPPMKLG()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001C5")]
			[Cpp2IlInjected.Address(RVA = "0x1FB6600", Offset = "0x1FB4C00", VA = "0x181FB6600")]
			internal int KBAIDJBOOND()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60001C6")]
			[Cpp2IlInjected.Address(RVA = "0x1FAEB60", Offset = "0x1FAD160", VA = "0x181FAEB60")]
			internal void EKPFJICBLGA(int x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C7")]
			[Cpp2IlInjected.Address(RVA = "0x1FB6D00", Offset = "0x1FB5300", VA = "0x181FB6D00")]
			internal bool LCNHJLEOIPA()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001C8")]
			[Cpp2IlInjected.Address(RVA = "0x1FB5FB0", Offset = "0x1FB45B0", VA = "0x181FB5FB0")]
			internal bool IIKJGEKAKOA()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001C9")]
			[Cpp2IlInjected.Address(RVA = "0x1FB5BE0", Offset = "0x1FB41E0", VA = "0x181FB5BE0")]
			internal bool IAKGDBJOOJI()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001CA")]
			[Cpp2IlInjected.Address(RVA = "0x1FB80F0", Offset = "0x1FB66F0", VA = "0x181FB80F0")]
			internal bool ODMBKBFIAFL()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001CB")]
			[Cpp2IlInjected.Address(RVA = "0x1FB7820", Offset = "0x1FB5E20", VA = "0x181FB7820")]
			internal bool NBLGNJMFDNP()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001CC")]
			[Cpp2IlInjected.Address(RVA = "0x1FAF940", Offset = "0x1FADF40", VA = "0x181FAF940")]
			internal bool HOFNFONIALK()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001CD")]
			[Cpp2IlInjected.Address(RVA = "0x1FB6190", Offset = "0x1FB4790", VA = "0x181FB6190")]
			internal string IOGJLMODCGM()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001CE")]
			[Cpp2IlInjected.Address(RVA = "0x1FAF1E0", Offset = "0x1FAD7E0", VA = "0x181FAF1E0")]
			internal void GIGLLGFAEOA(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001CF")]
			[Cpp2IlInjected.Address(RVA = "0x1FAE5A0", Offset = "0x1FACBA0", VA = "0x181FAE5A0")]
			internal int COKPLELIGFI()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60001D0")]
			[Cpp2IlInjected.Address(RVA = "0x1FB6550", Offset = "0x1FB4B50", VA = "0x181FB6550")]
			internal void KANELAAKIII(int x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001D1")]
			[Cpp2IlInjected.Address(RVA = "0x1FB6E00", Offset = "0x1FB5400", VA = "0x181FB6E00")]
			internal bool LGDDPFFOJOP()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001D2")]
			[Cpp2IlInjected.Address(RVA = "0x1FB7960", Offset = "0x1FB5F60", VA = "0x181FB7960")]
			internal bool NFPEPHMOOPA()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001D3")]
			[Cpp2IlInjected.Address(RVA = "0x1FADF10", Offset = "0x1FAC510", VA = "0x181FADF10")]
			internal bool AMGEBECIMBF()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001D4")]
			[Cpp2IlInjected.Address(RVA = "0x1FB7280", Offset = "0x1FB5880", VA = "0x181FB7280")]
			internal float MGGHHDIJKIG()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x60001D5")]
			[Cpp2IlInjected.Address(RVA = "0x1FAF500", Offset = "0x1FADB00", VA = "0x181FAF500")]
			internal void HDHJOBAFPEK(float x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001D6")]
			[Cpp2IlInjected.Address(RVA = "0x1FAEC10", Offset = "0x1FAD210", VA = "0x181FAEC10")]
			internal bool EMGKPJFHEKB()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001D7")]
			[Cpp2IlInjected.Address(RVA = "0x1FAED50", Offset = "0x1FAD350", VA = "0x181FAED50")]
			internal bool EOLIKOGIOBP()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001D8")]
			[Cpp2IlInjected.Address(RVA = "0x1FB7730", Offset = "0x1FB5D30", VA = "0x181FB7730")]
			internal bool MOGIIKBOKJJ()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001D9")]
			[Cpp2IlInjected.Address(RVA = "0x1FAF140", Offset = "0x1FAD740", VA = "0x181FAF140")]
			internal bool GGLIEKOBGMN()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001DA")]
			[Cpp2IlInjected.Address(RVA = "0x1FB7E70", Offset = "0x1FB6470", VA = "0x181FB7E70")]
			internal bool NNBCFGIHLCM()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001DB")]
			[Cpp2IlInjected.Address(RVA = "0x1FADCC0", Offset = "0x1FAC2C0", VA = "0x181FADCC0")]
			internal bool AIKHBCMCCDA()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001DC")]
			[Cpp2IlInjected.Address(RVA = "0x1FB7370", Offset = "0x1FB5970", VA = "0x181FB7370")]
			internal void MHJBDHNFALO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001DD")]
			[Cpp2IlInjected.Address(RVA = "0x1FB66A0", Offset = "0x1FB4CA0", VA = "0x181FB66A0")]
			internal string KELPHJDJDFH()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001DE")]
			[Cpp2IlInjected.Address(RVA = "0x1FB87C0", Offset = "0x1FB6DC0", VA = "0x181FB87C0")]
			internal void PNNKKKOGELN(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001DF")]
			[Cpp2IlInjected.Address(RVA = "0x1FAF300", Offset = "0x1FAD900", VA = "0x181FAF300")]
			internal bool GLEEGFJOAEF()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001E0")]
			[Cpp2IlInjected.Address(RVA = "0x1FADFC0", Offset = "0x1FAC5C0", VA = "0x181FADFC0")]
			internal bool BDDMEKOHFAB()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001E1")]
			[Cpp2IlInjected.Address(RVA = "0x1FB6E50", Offset = "0x1FB5450", VA = "0x181FB6E50")]
			internal bool LGKCPCMHGME()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001E2")]
			[Cpp2IlInjected.Address(RVA = "0x1FB7BA0", Offset = "0x1FB61A0", VA = "0x181FB7BA0")]
			internal void NMLLHEGIAKG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001E3")]
			[Cpp2IlInjected.Address(RVA = "0x1FB7190", Offset = "0x1FB5790", VA = "0x181FB7190")]
			internal bool MCOMGDMBGDL()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001E4")]
			[Cpp2IlInjected.Address(RVA = "0x1FAEFB0", Offset = "0x1FAD5B0", VA = "0x181FAEFB0")]
			internal bool FJCNBFKKENO()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001E5")]
			[Cpp2IlInjected.Address(RVA = "0x1FB8320", Offset = "0x1FB6920", VA = "0x181FB8320")]
			internal bool OKIECABFHHD()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001E6")]
			[Cpp2IlInjected.Address(RVA = "0x1FB7B00", Offset = "0x1FB6100", VA = "0x181FB7B00")]
			internal bool NJILCBBMCMM()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001E7")]
			[Cpp2IlInjected.Address(RVA = "0x1FB8420", Offset = "0x1FB6A20", VA = "0x181FB8420")]
			internal void OMFOAHKPFNJ(bool x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001E8")]
			[Cpp2IlInjected.Address(RVA = "0x1FAE640", Offset = "0x1FACC40", VA = "0x181FAE640")]
			internal bool DDFPPIMGHAI()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001E9")]
			[Cpp2IlInjected.Address(RVA = "0x1FB7320", Offset = "0x1FB5920", VA = "0x181FB7320")]
			internal bool MHCFOEKFJPB()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001EA")]
			[Cpp2IlInjected.Address(RVA = "0x1FAE390", Offset = "0x1FAC990", VA = "0x181FAE390")]
			internal bool CDBEPKHGIJB()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001EB")]
			[Cpp2IlInjected.Address(RVA = "0x1FB8720", Offset = "0x1FB6D20", VA = "0x181FB8720")]
			internal bool PMBNOJBKBII()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001EC")]
			[Cpp2IlInjected.Address(RVA = "0x1FAE690", Offset = "0x1FACC90", VA = "0x181FAE690")]
			internal void DICPBPHJPNL(bool x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001ED")]
			[Cpp2IlInjected.Address(RVA = "0x1FAE990", Offset = "0x1FACF90", VA = "0x181FAE990")]
			internal bool EDCMFKNLDBB()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001EE")]
			[Cpp2IlInjected.Address(RVA = "0x1FB8140", Offset = "0x1FB6740", VA = "0x181FB8140")]
			internal bool ODMHNMDNPJJ()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001EF")]
			[Cpp2IlInjected.Address(RVA = "0x1FADDB0", Offset = "0x1FAC3B0", VA = "0x181FADDB0")]
			internal bool AJOANEMMGMF()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001F0")]
			[Cpp2IlInjected.Address(RVA = "0x1FAE7B0", Offset = "0x1FACDB0", VA = "0x181FAE7B0")]
			internal bool DJOCNEBFFNN()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001F1")]
			[Cpp2IlInjected.Address(RVA = "0x1FB8680", Offset = "0x1FB6C80", VA = "0x181FB8680")]
			internal int PHGLBILFPFM()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60001F2")]
			[Cpp2IlInjected.Address(RVA = "0x1FB5ED0", Offset = "0x1FB44D0", VA = "0x181FB5ED0")]
			internal void IIINFEPOOPJ(object x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001F3")]
			[Cpp2IlInjected.Address(RVA = "0x1FB6C60", Offset = "0x1FB5260", VA = "0x181FB6C60")]
			internal bool LBFKGDFJMAO()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001F4")]
			[Cpp2IlInjected.Address(RVA = "0x1FAF3C0", Offset = "0x1FAD9C0", VA = "0x181FAF3C0")]
			internal bool GMJFMFKAILP()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001F5")]
			[Cpp2IlInjected.Address(RVA = "0x1FB6230", Offset = "0x1FB4830", VA = "0x181FB6230")]
			internal int IPDMAHAGFHK()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60001F6")]
			[Cpp2IlInjected.Address(RVA = "0x1FADF60", Offset = "0x1FAC560", VA = "0x181FADF60")]
			internal void BCHDEMEPPEJ(int x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001F7")]
			[Cpp2IlInjected.Address(RVA = "0x1FB5D20", Offset = "0x1FB4320", VA = "0x181FB5D20")]
			internal bool IFFAPMOMILI()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001F8")]
			[Cpp2IlInjected.Address(RVA = "0x1FB8770", Offset = "0x1FB6D70", VA = "0x181FB8770")]
			internal bool PNHJONKOFLG()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001F9")]
			[Cpp2IlInjected.Address(RVA = "0x1FAE550", Offset = "0x1FACB50", VA = "0x181FAE550")]
			internal int CMJMEILGEBB()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60001FA")]
			[Cpp2IlInjected.Address(RVA = "0x1FB6740", Offset = "0x1FB4D40", VA = "0x181FB6740")]
			internal void KFAAGCGNMAA(int x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001FB")]
			[Cpp2IlInjected.Address(RVA = "0x1FB6000", Offset = "0x1FB4600", VA = "0x181FB6000")]
			internal bool IJGJEOLAPBC()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001FC")]
			[Cpp2IlInjected.Address(RVA = "0x1FB80A0", Offset = "0x1FB66A0", VA = "0x181FB80A0")]
			internal bool ODHILLHHDHB()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001FD")]
			[Cpp2IlInjected.Address(RVA = "0x1FAE010", Offset = "0x1FAC610", VA = "0x181FAE010")]
			internal bool BDKALHOOKOD()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001FE")]
			[Cpp2IlInjected.Address(RVA = "0x1FAF4B0", Offset = "0x1FADAB0", VA = "0x181FAF4B0")]
			internal int HDAKIKKBPKG()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60001FF")]
			[Cpp2IlInjected.Address(RVA = "0x1FAE270", Offset = "0x1FAC870", VA = "0x181FAE270")]
			internal void BOBAGNJHAMJ(int x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000200")]
			[Cpp2IlInjected.Address(RVA = "0x1FAF000", Offset = "0x1FAD600", VA = "0x181FAF000")]
			internal bool GAEGMBJJDJN()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000201")]
			[Cpp2IlInjected.Address(RVA = "0x1FAEF60", Offset = "0x1FAD560", VA = "0x181FAEF60")]
			internal bool FJBJCAPDLMM()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000202")]
			[Cpp2IlInjected.Address(RVA = "0x1FAF800", Offset = "0x1FADE00", VA = "0x181FAF800")]
			internal bool HLILHMGOBBF()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000203")]
			[Cpp2IlInjected.Address(RVA = "0x1FB70D0", Offset = "0x1FB56D0", VA = "0x181FB70D0")]
			internal object MABEHJKKFKH()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000204")]
			[Cpp2IlInjected.Address(RVA = "0x1FAEA80", Offset = "0x1FAD080", VA = "0x181FAEA80")]
			internal void EGPJLNBIHIH(object x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000205")]
			[Cpp2IlInjected.Address(RVA = "0x1FB7910", Offset = "0x1FB5F10", VA = "0x181FB7910")]
			internal bool NFFEBHLFOOM()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000206")]
			[Cpp2IlInjected.Address(RVA = "0x1FAF250", Offset = "0x1FAD850", VA = "0x181FAF250")]
			internal bool GJFGIFGNGOI()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000207")]
			[Cpp2IlInjected.Address(RVA = "0x1FAE6F0", Offset = "0x1FACCF0", VA = "0x181FAE6F0")]
			internal object DIONFJAMGHA()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000208")]
			[Cpp2IlInjected.Address(RVA = "0x1FB7FB0", Offset = "0x1FB65B0", VA = "0x181FB7FB0")]
			internal void ODABLODJKPC(object x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000209")]
			[Cpp2IlInjected.Address(RVA = "0x1FB6CB0", Offset = "0x1FB52B0", VA = "0x181FB6CB0")]
			internal bool LCAGBNDBPCM()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600020A")]
			[Cpp2IlInjected.Address(RVA = "0x1FB6C10", Offset = "0x1FB5210", VA = "0x181FB6C10")]
			internal int LBBNKGNJPLP()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x600020B")]
			[Cpp2IlInjected.Address(RVA = "0x1FADC60", Offset = "0x1FAC260", VA = "0x181FADC60")]
			internal void AHIJKPIFKKC(int x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600020C")]
			[Cpp2IlInjected.Address(RVA = "0x1FB6AA0", Offset = "0x1FB50A0", VA = "0x181FB6AA0")]
			internal bool KOHKCICHCAF()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600020D")]
			[Cpp2IlInjected.Address(RVA = "0x1FAE8F0", Offset = "0x1FACEF0", VA = "0x181FAE8F0")]
			internal bool EBECMFJNFLJ()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600020E")]
			[Cpp2IlInjected.Address(RVA = "0x1FAEE60", Offset = "0x1FAD460", VA = "0x181FAEE60")]
			internal bool FFHIMGIOOPO()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600020F")]
			[Cpp2IlInjected.Address(RVA = "0x1FB79B0", Offset = "0x1FB5FB0", VA = "0x181FB79B0")]
			internal int NGGJCCIHMIC()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000210")]
			[Cpp2IlInjected.Address(RVA = "0x1FB8040", Offset = "0x1FB6640", VA = "0x181FB8040")]
			internal void ODAMHCJCMAC(int x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000211")]
			[Cpp2IlInjected.Address(RVA = "0x1FB5F60", Offset = "0x1FB4560", VA = "0x181FB5F60")]
			internal bool IIIONCNFECL()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000212")]
			[Cpp2IlInjected.Address(RVA = "0x1FAF6C0", Offset = "0x1FADCC0", VA = "0x181FAF6C0")]
			internal bool HHDHJBOJAIO()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000213")]
			[Cpp2IlInjected.Address(RVA = "0x1FAE4A0", Offset = "0x1FACAA0", VA = "0x181FAE4A0")]
			internal bool CENJPCOJENI()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000214")]
			[Cpp2IlInjected.Address(RVA = "0x1FAE5F0", Offset = "0x1FACBF0", VA = "0x181FAE5F0")]
			internal float CONELNBDIAA()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000215")]
			[Cpp2IlInjected.Address(RVA = "0x1FB64F0", Offset = "0x1FB4AF0", VA = "0x181FB64F0")]
			internal void KADKELAELLP(float x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000216")]
			[Cpp2IlInjected.Address(RVA = "0x1FB8370", Offset = "0x1FB6970", VA = "0x181FB8370")]
			internal bool OLKLEGIPKAK()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000217")]
			[Cpp2IlInjected.Address(RVA = "0x1FAEA30", Offset = "0x1FAD030", VA = "0x181FAEA30")]
			internal bool EFGOJOJBGKD()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000218")]
			[Cpp2IlInjected.Address(RVA = "0x1FAE800", Offset = "0x1FACE00", VA = "0x181FAE800")]
			internal bool DPIIKKCAIEF()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000219")]
			[Cpp2IlInjected.Address(RVA = "0x1FAF990", Offset = "0x1FADF90", VA = "0x181FAF990")]
			internal float HPEJMFFCALI()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x600021A")]
			[Cpp2IlInjected.Address(RVA = "0x1FADE60", Offset = "0x1FAC460", VA = "0x181FADE60")]
			internal void AKHCIIBOEDA(float x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600021B")]
			[Cpp2IlInjected.Address(RVA = "0x1FB81E0", Offset = "0x1FB67E0", VA = "0x181FB81E0")]
			internal bool OEFFEFKBEBI()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600021C")]
			[Cpp2IlInjected.Address(RVA = "0x1FB67A0", Offset = "0x1FB4DA0", VA = "0x181FB67A0")]
			internal bool KFLKMIAGDGD()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600021D")]
			[Cpp2IlInjected.Address(RVA = "0x1FAF0A0", Offset = "0x1FAD6A0", VA = "0x181FAF0A0")]
			internal string GBNKFGAABKH()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600021E")]
			[Cpp2IlInjected.Address(RVA = "0x1FB63C0", Offset = "0x1FB49C0", VA = "0x181FB63C0")]
			internal void JKMLBODJKMC(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600021F")]
			[Cpp2IlInjected.Address(RVA = "0x1FAF8A0", Offset = "0x1FADEA0", VA = "0x181FAF8A0")]
			internal bool HOEJPOONMBN(string x)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000220")]
			[Cpp2IlInjected.Address(RVA = "0x1FAF710", Offset = "0x1FADD10", VA = "0x181FAF710")]
			internal bool HIABFJOENIP()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000221")]
			[Cpp2IlInjected.Address(RVA = "0x1FB6370", Offset = "0x1FB4970", VA = "0x181FB6370")]
			internal bool JHJHLPAEENK()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000222")]
			[Cpp2IlInjected.Address(RVA = "0x1FAEF10", Offset = "0x1FAD510", VA = "0x181FAEF10")]
			internal bool FIBHPBFGGPL()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000223")]
			[Cpp2IlInjected.Address(RVA = "0x1FAECB0", Offset = "0x1FAD2B0", VA = "0x181FAECB0")]
			internal string ENBBHFIDNJL()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000224")]
			[Cpp2IlInjected.Address(RVA = "0x1FB6AF0", Offset = "0x1FB50F0", VA = "0x181FB6AF0")]
			internal void LAGHDFCKBCP(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000225")]
			[Cpp2IlInjected.Address(RVA = "0x1FB71E0", Offset = "0x1FB57E0", VA = "0x181FB71E0")]
			internal bool MFOBICLLGNK(string x)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000226")]
			[Cpp2IlInjected.Address(RVA = "0x1FB65B0", Offset = "0x1FB4BB0", VA = "0x181FB65B0")]
			internal bool KAODPHKBAKI()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000227")]
			[Cpp2IlInjected.Address(RVA = "0x1FB8540", Offset = "0x1FB6B40", VA = "0x181FB8540")]
			internal bool ONMOEMIJGFI()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000228")]
			[Cpp2IlInjected.Address(RVA = "0x1FB8230", Offset = "0x1FB6830", VA = "0x181FB8230")]
			internal bool OFBNEALEFCM()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000229")]
			[Cpp2IlInjected.Address(RVA = "0x1FADD10", Offset = "0x1FAC310", VA = "0x181FADD10")]
			internal string AILADHIOLFL()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600022A")]
			[Cpp2IlInjected.Address(RVA = "0x1FAF600", Offset = "0x1FADC00", VA = "0x181FAF600")]
			internal void HGKDKNKCIGO(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600022B")]
			[Cpp2IlInjected.Address(RVA = "0x1FB6940", Offset = "0x1FB4F40", VA = "0x181FB6940")]
			internal bool KKLMDNEHBNJ(string x)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600022C")]
			[Cpp2IlInjected.Address(RVA = "0x1FAF0F0", Offset = "0x1FAD6F0", VA = "0x181FAF0F0")]
			internal bool GFAPIFGACMK()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600022D")]
			[Cpp2IlInjected.Address(RVA = "0x1FB7080", Offset = "0x1FB5680", VA = "0x181FB7080")]
			internal bool LPNIELACIFL()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600022E")]
			[Cpp2IlInjected.Address(RVA = "0x1FB77D0", Offset = "0x1FB5DD0", VA = "0x181FB77D0")]
			internal bool MPPDAAFMJPC()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600022F")]
			[Cpp2IlInjected.Address(RVA = "0x1FB5CD0", Offset = "0x1FB42D0", VA = "0x181FB5CD0")]
			internal string IEFBLELHENN()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000230")]
			[Cpp2IlInjected.Address(RVA = "0x1FB6990", Offset = "0x1FB4F90", VA = "0x181FB6990")]
			internal void KLDEKMALHNN(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000231")]
			[Cpp2IlInjected.Address(RVA = "0x1FAEC60", Offset = "0x1FAD260", VA = "0x181FAEC60")]
			internal bool EMMAKEBFNHL(string x)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000232")]
			[Cpp2IlInjected.Address(RVA = "0x1FB7A60", Offset = "0x1FB6060", VA = "0x181FB7A60")]
			internal bool NIHLBFBHLPJ()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000233")]
			[Cpp2IlInjected.Address(RVA = "0x1FB6A50", Offset = "0x1FB5050", VA = "0x181FB6A50")]
			internal bool KNGDFLJPPGK()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000234")]
			[Cpp2IlInjected.Address(RVA = "0x1FB61E0", Offset = "0x1FB47E0", VA = "0x181FB61E0")]
			internal bool IONMDNPEBOM()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000235")]
			[Cpp2IlInjected.Address(RVA = "0x1FAF410", Offset = "0x1FADA10", VA = "0x181FAF410")]
			internal string GOLFPIJACPO()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000236")]
			[Cpp2IlInjected.Address(RVA = "0x1FB6430", Offset = "0x1FB4A30", VA = "0x181FB6430")]
			internal void JMJMFMOFHDI(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000237")]
			[Cpp2IlInjected.Address(RVA = "0x1FB5E80", Offset = "0x1FB4480", VA = "0x181FB5E80")]
			internal bool IGKNGGADMEI(string x)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000238")]
			[Cpp2IlInjected.Address(RVA = "0x1FB6D50", Offset = "0x1FB5350", VA = "0x181FB6D50")]
			internal bool LDMNPCBBMED()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000239")]
			[Cpp2IlInjected.Address(RVA = "0x1FB6F90", Offset = "0x1FB5590", VA = "0x181FB6F90")]
			internal bool LNFELLNMMED()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600023A")]
			[Cpp2IlInjected.Address(RVA = "0x1FADB70", Offset = "0x1FAC170", VA = "0x181FADB70")]
			internal bool ACOLECBDMLB()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600023B")]
			[Cpp2IlInjected.Address(RVA = "0x1FB5C80", Offset = "0x1FB4280", VA = "0x181FB5C80")]
			internal string IDNONPGEHBK()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600023C")]
			[Cpp2IlInjected.Address(RVA = "0x1FB8890", Offset = "0x1FB6E90", VA = "0x181FB8890")]
			internal void PPDEKKFHIDD(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600023D")]
			[Cpp2IlInjected.Address(RVA = "0x1FAF8F0", Offset = "0x1FADEF0", VA = "0x181FAF8F0")]
			internal bool HOFEMHMMKIP(string x)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600023E")]
			[Cpp2IlInjected.Address(RVA = "0x1FB6FE0", Offset = "0x1FB55E0", VA = "0x181FB6FE0")]
			internal bool LNNBIMEJIOE()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600023F")]
			[Cpp2IlInjected.Address(RVA = "0x1FB8280", Offset = "0x1FB6880", VA = "0x181FB8280")]
			internal bool OJADJJIEIOA()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000240")]
			[Cpp2IlInjected.Address(RVA = "0x1FADC10", Offset = "0x1FAC210", VA = "0x181FADC10")]
			internal bool AFEPCHNGJHB()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000241")]
			[Cpp2IlInjected.Address(RVA = "0x1FAEBC0", Offset = "0x1FAD1C0", VA = "0x181FAEBC0")]
			internal string ELANGEFIHAA()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000242")]
			[Cpp2IlInjected.Address(RVA = "0x1FAEDF0", Offset = "0x1FAD3F0", VA = "0x181FAEDF0")]
			internal void FBKDHGENMCI(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000243")]
			[Cpp2IlInjected.Address(RVA = "0x1FB7F60", Offset = "0x1FB6560", VA = "0x181FB7F60")]
			internal bool OCJGDHGBNLD(string x)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000244")]
			[Cpp2IlInjected.Address(RVA = "0x1FB60F0", Offset = "0x1FB46F0", VA = "0x181FB60F0")]
			internal bool INGEJEJMFBK()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000245")]
			[Cpp2IlInjected.Address(RVA = "0x1FB86D0", Offset = "0x1FB6CD0", VA = "0x181FB86D0")]
			internal bool PIPCLPCGGKG()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000246")]
			[Cpp2IlInjected.Address(RVA = "0x1FB78C0", Offset = "0x1FB5EC0", VA = "0x181FB78C0")]
			internal bool NEPFDFNGIPA()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000247")]
			[Cpp2IlInjected.Address(RVA = "0x1FB82D0", Offset = "0x1FB68D0", VA = "0x181FB82D0")]
			internal string OKFNJLFJNAC()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000248")]
			[Cpp2IlInjected.Address(RVA = "0x1FAE320", Offset = "0x1FAC920", VA = "0x181FAE320")]
			internal void CCMNJPPFPMI(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000249")]
			[Cpp2IlInjected.Address(RVA = "0x1FB7780", Offset = "0x1FB5D80", VA = "0x181FB7780")]
			internal bool MPHJOPDFLHO(string x)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600024A")]
			[Cpp2IlInjected.Address(RVA = "0x1FB6280", Offset = "0x1FB4880", VA = "0x181FB6280")]
			internal bool JAAHLNJDPFP()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600024B")]
			[Cpp2IlInjected.Address(RVA = "0x1FAE8A0", Offset = "0x1FACEA0", VA = "0x181FAE8A0")]
			internal bool EBCACGDLAEO()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600024C")]
			[Cpp2IlInjected.Address(RVA = "0x1FB8590", Offset = "0x1FB6B90", VA = "0x181FB8590")]
			internal bool OPLGHKLGJCJ()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600024D")]
			[Cpp2IlInjected.Address(RVA = "0x1FB7EC0", Offset = "0x1FB64C0", VA = "0x181FB7EC0")]
			internal string NNBFPALKHFP()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600024E")]
			[Cpp2IlInjected.Address(RVA = "0x1FB5DC0", Offset = "0x1FB43C0", VA = "0x181FB5DC0")]
			internal void IGJOJCFGBOJ(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600024F")]
			[Cpp2IlInjected.Address(RVA = "0x1FB7F10", Offset = "0x1FB6510", VA = "0x181FB7F10")]
			internal bool OBJPPJLGNHP(string x)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000250")]
			[Cpp2IlInjected.Address(RVA = "0x1FAEB10", Offset = "0x1FAD110", VA = "0x181FAEB10")]
			internal bool EKODILBNBLJ()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000251")]
			[Cpp2IlInjected.Address(RVA = "0x1FADB20", Offset = "0x1FAC120", VA = "0x181FADB20")]
			internal bool ABDIKCCGHCC()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000252")]
			[Cpp2IlInjected.Address(RVA = "0x1FAE220", Offset = "0x1FAC820", VA = "0x181FAE220")]
			internal bool BNMNGKKKILN()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000253")]
			[Cpp2IlInjected.Address(RVA = "0x1FB6140", Offset = "0x1FB4740", VA = "0x181FB6140")]
			internal string IOCJKLAOMPA()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000254")]
			[Cpp2IlInjected.Address(RVA = "0x1FAF350", Offset = "0x1FAD950", VA = "0x181FAF350")]
			internal void GMEADLAFMFN(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000255")]
			[Cpp2IlInjected.Address(RVA = "0x1FB8190", Offset = "0x1FB6790", VA = "0x181FB8190")]
			internal bool OEBLOFGPMHA()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000256")]
			[Cpp2IlInjected.Address(RVA = "0x1FB7140", Offset = "0x1FB5740", VA = "0x181FB7140")]
			internal bool MANDPOLGDAK()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000257")]
			[Cpp2IlInjected.Address(RVA = "0x1FB5D70", Offset = "0x1FB4370", VA = "0x181FB5D70")]
			internal bool IFOOHJGHEIL()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000258")]
			[Cpp2IlInjected.Address(RVA = "0x1FB6850", Offset = "0x1FB4E50", VA = "0x181FB6850")]
			internal string KHCIGGLAHMO()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000259")]
			[Cpp2IlInjected.Address(RVA = "0x1FAE110", Offset = "0x1FAC710", VA = "0x181FAE110")]
			internal void BJLPNOOABCM(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600025A")]
			[Cpp2IlInjected.Address(RVA = "0x1FB6F40", Offset = "0x1FB5540", VA = "0x181FB6F40")]
			internal bool LLJLOOEONIG()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600025B")]
			[Cpp2IlInjected.Address(RVA = "0x1FB6EF0", Offset = "0x1FB54F0", VA = "0x181FB6EF0")]
			internal bool LHPBGPDCIMG()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600025C")]
			[Cpp2IlInjected.Address(RVA = "0x1FAF050", Offset = "0x1FAD650", VA = "0x181FAF050")]
			internal bool GBBPONBMKJK()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600025D")]
			[Cpp2IlInjected.Address(RVA = "0x1FAE180", Offset = "0x1FAC780", VA = "0x181FAE180")]
			internal string BMCNPFBEDKK()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600025E")]
			[Cpp2IlInjected.Address(RVA = "0x1FAE3E0", Offset = "0x1FAC9E0", VA = "0x181FAE3E0")]
			internal void CDJCOCJDNJA(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600025F")]
			[Cpp2IlInjected.Address(RVA = "0x1FAF560", Offset = "0x1FADB60", VA = "0x181FAF560")]
			internal bool HDPDPFNGFKM()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000260")]
			[Cpp2IlInjected.Address(RVA = "0x1FB8630", Offset = "0x1FB6C30", VA = "0x181FB8630")]
			internal bool PGDKPPOLMFL()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000261")]
			[Cpp2IlInjected.Address(RVA = "0x1FAE2D0", Offset = "0x1FAC8D0", VA = "0x181FAE2D0")]
			internal bool BOCJKFDNOKB()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000262")]
			[Cpp2IlInjected.Address(RVA = "0x1FAF460", Offset = "0x1FADA60", VA = "0x181FAF460")]
			internal string HBIAPCKOBND()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000263")]
			[Cpp2IlInjected.Address(RVA = "0x1FB84D0", Offset = "0x1FB6AD0", VA = "0x181FB84D0")]
			internal void ONDHBGAFDKG(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000264")]
			[Cpp2IlInjected.Address(RVA = "0x1FAE450", Offset = "0x1FACA50", VA = "0x181FAE450")]
			internal bool CDLINAGJBJA()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000265")]
			[Cpp2IlInjected.Address(RVA = "0x1FB6320", Offset = "0x1FB4920", VA = "0x181FB6320")]
			internal bool JHICAKJOKKH(string x)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000266")]
			[Cpp2IlInjected.Address(RVA = "0x1FADD60", Offset = "0x1FAC360", VA = "0x181FADD60")]
			internal float AJBAIBNANBD()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000267")]
			[Cpp2IlInjected.Address(RVA = "0x1FADE00", Offset = "0x1FAC400", VA = "0x181FADE00")]
			internal void AKFGHOCLJFA(float x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000268")]
			[Cpp2IlInjected.Address(RVA = "0x1FB64A0", Offset = "0x1FB4AA0", VA = "0x181FB64A0")]
			internal bool JNNOFIHICGG()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000269")]
			[Cpp2IlInjected.Address(RVA = "0x1FB68F0", Offset = "0x1FB4EF0", VA = "0x181FB68F0")]
			internal bool KIDPJNFNMMP()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600026A")]
			[Cpp2IlInjected.Address(RVA = "0x1FB66F0", Offset = "0x1FB4CF0", VA = "0x181FB66F0")]
			internal bool KEOFAJGEIFF()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600026B")]
			[Cpp2IlInjected.Address(RVA = "0x1FB5E30", Offset = "0x1FB4430", VA = "0x181FB5E30")]
			internal int IGKEEFFKDBE()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x600026C")]
			[Cpp2IlInjected.Address(RVA = "0x1FB83C0", Offset = "0x1FB69C0", VA = "0x181FB83C0")]
			internal void OMFLFMPONOK(int x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600026D")]
			[Cpp2IlInjected.Address(RVA = "0x1FAF670", Offset = "0x1FADC70", VA = "0x181FAF670")]
			internal bool HHCAOHOAGLI()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600026E")]
			[Cpp2IlInjected.Address(RVA = "0x1FB7B50", Offset = "0x1FB6150", VA = "0x181FB7B50")]
			internal bool NMKLHOOINAB()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600026F")]
			[Cpp2IlInjected.Address(RVA = "0x1FAED00", Offset = "0x1FAD300", VA = "0x181FAED00")]
			internal bool ENNMLNBCCGP()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000065")]
		[CompilerGenerated]
		private sealed class BKNJANLGCAF
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000148")]
			public string secondaryLabel;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000149")]
			public GGDBAOKNHKJ CS$<>8__locals1;

			[Cpp2IlInjected.Token(Token = "0x6000270")]
			[Cpp2IlInjected.Address(RVA = "0x86C4B0", Offset = "0x86AAB0", VA = "0x18086C4B0")]
			public BKNJANLGCAF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000271")]
			[Cpp2IlInjected.Address(RVA = "0x1FAA000", Offset = "0x1FA8600", VA = "0x181FAA000")]
			internal void HBDLLCLBCBL()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000066")]
		[CompilerGenerated]
		private sealed class NJHHHBIDNCJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400014A")]
			public char[] swizzleChars;

			[Cpp2IlInjected.Token(Token = "0x6000272")]
			[Cpp2IlInjected.Address(RVA = "0x86C4B0", Offset = "0x86AAB0", VA = "0x18086C4B0")]
			public NJHHHBIDNCJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000273")]
			[Cpp2IlInjected.Address(RVA = "0x1FBF860", Offset = "0x1FBDE60", VA = "0x181FBF860")]
			internal bool KJMPOJIOIFH(char c)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000137")]
		private readonly ALIEIFONOHB JCBECJGAKCD;

		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x1FBC690", Offset = "0x1FBAC90", VA = "0x181FBC690")]
		public JLLOIKPAMOD(PJNMBNAHIFL ALELNINOAGK, IEHHOKNMOAI EMDFCFPCFGG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x1FBA8B0", Offset = "0x1FB8EB0", VA = "0x181FBA8B0", Slot = "120")]
		protected override void AANCPJNHLHN(GDJFKKGDGFJ KMONEIKIHIC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000068")]
	public sealed class AGFJAOBLFPF : DCANGPMKHHL<GNOJHFKNIKC>
	{
		[Cpp2IlInjected.Token(Token = "0x2000069")]
		[CompilerGenerated]
		private sealed class AMBGKHIMHID
		{
			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x200006A")]
			private struct <<BuildConfigMenuInternal>b__1>d : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000175")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x4000176")]
				public AsyncVoidMethodBuilder <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x4000177")]
				public AMBGKHIMHID <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x4000178")]
				public string value;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x4000179")]
				private TaskAwaiter<bool> <>u__1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
				[Cpp2IlInjected.Token(Token = "0x400017A")]
				private TaskAwaiter<CBDPDIPONCF<COKMANPFJNC, FBDDJIHDMAI>> <>u__2;

				[Cpp2IlInjected.Token(Token = "0x60002A5")]
				[Cpp2IlInjected.Address(RVA = "0x1FE1410", Offset = "0x1FDFA10", VA = "0x181FE1410", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60002A6")]
				[Cpp2IlInjected.Address(RVA = "0xA20370", Offset = "0xA1E970", VA = "0x180A20370", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000173")]
			public AGFJAOBLFPF <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000174")]
			public BKKHOHENKFL nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x60002A0")]
			[Cpp2IlInjected.Address(RVA = "0x86C4B0", Offset = "0x86AAB0", VA = "0x18086C4B0")]
			public AMBGKHIMHID()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002A1")]
			[Cpp2IlInjected.Address(RVA = "0x1FC6C20", Offset = "0x1FC5220", VA = "0x181FC6C20")]
			internal string MGLFNJMCMEN()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002A2")]
			[Cpp2IlInjected.Address(RVA = "0x1FC6B50", Offset = "0x1FC5150", VA = "0x181FC6B50")]
			[AsyncStateMachine(typeof(<<BuildConfigMenuInternal>b__1>d))]
			internal void KGEOJKOADPA(string value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002A3")]
			[Cpp2IlInjected.Address(RVA = "0x1FC6B00", Offset = "0x1FC5100", VA = "0x181FC6B00")]
			internal int GLPPOLAGMCH()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60002A4")]
			[Cpp2IlInjected.Address(RVA = "0x1FC6C70", Offset = "0x1FC5270", VA = "0x181FC6C70")]
			internal void PDHBGEGHGHC(int value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public override NodeVisualizationKey EHBGNDCNEJA
		{
			[Cpp2IlInjected.Token(Token = "0x600029E")]
			[Cpp2IlInjected.Address(RVA = "0x8EF840", Offset = "0x8EDE40", VA = "0x1808EF840", Slot = "91")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600029D")]
		[Cpp2IlInjected.Address(RVA = "0x1FC6A90", Offset = "0x1FC5090", VA = "0x181FC6A90")]
		public AGFJAOBLFPF(PJNMBNAHIFL ALELNINOAGK, GNOJHFKNIKC AKLCDEBLEOF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029F")]
		[Cpp2IlInjected.Address(RVA = "0x1FC6740", Offset = "0x1FC4D40", VA = "0x181FC6740", Slot = "120")]
		protected override void AANCPJNHLHN(GDJFKKGDGFJ KMONEIKIHIC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006B")]
	public sealed class FNPICADDFCG : DCANGPMKHHL<BHBDAAPECOA>
	{
		[Cpp2IlInjected.Token(Token = "0x200006C")]
		[CompilerGenerated]
		private sealed class OEKBPJBKPHO
		{
			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x200006D")]
			private struct <<BuildConfigMenuInternal>b__1>d : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400017D")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x400017E")]
				public AsyncVoidMethodBuilder <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x400017F")]
				public OEKBPJBKPHO <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x4000180")]
				public string value;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x4000181")]
				private TaskAwaiter<bool> <>u__1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
				[Cpp2IlInjected.Token(Token = "0x4000182")]
				private TaskAwaiter<CBDPDIPONCF<COKMANPFJNC, FBDDJIHDMAI>> <>u__2;

				[Cpp2IlInjected.Token(Token = "0x60002BA")]
				[Cpp2IlInjected.Address(RVA = "0x1FE1720", Offset = "0x1FDFD20", VA = "0x181FE1720", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60002BB")]
				[Cpp2IlInjected.Address(RVA = "0xA20370", Offset = "0xA1E970", VA = "0x180A20370", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x200006E")]
			private struct <<BuildConfigMenuInternal>b__5>d : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000183")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x4000184")]
				public AsyncVoidMethodBuilder <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x4000185")]
				public OEKBPJBKPHO <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x4000186")]
				public string value;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x4000187")]
				private TaskAwaiter<bool> <>u__1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
				[Cpp2IlInjected.Token(Token = "0x4000188")]
				private TaskAwaiter<CBDPDIPONCF<COKMANPFJNC, FBDDJIHDMAI>> <>u__2;

				[Cpp2IlInjected.Token(Token = "0x60002BC")]
				[Cpp2IlInjected.Address(RVA = "0x1FE1A60", Offset = "0x1FE0060", VA = "0x181FE1A60", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60002BD")]
				[Cpp2IlInjected.Address(RVA = "0xA20370", Offset = "0xA1E970", VA = "0x180A20370", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400017B")]
			public FNPICADDFCG <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400017C")]
			public BKKHOHENKFL nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x60002AA")]
			[Cpp2IlInjected.Address(RVA = "0x86C4B0", Offset = "0x86AAB0", VA = "0x18086C4B0")]
			public OEKBPJBKPHO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002AB")]
			[Cpp2IlInjected.Address(RVA = "0x1FDDA30", Offset = "0x1FDC030", VA = "0x181FDDA30")]
			internal string MGLFNJMCMEN()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002AC")]
			[Cpp2IlInjected.Address(RVA = "0x1FDD880", Offset = "0x1FDBE80", VA = "0x181FDD880")]
			[AsyncStateMachine(typeof(<<BuildConfigMenuInternal>b__1>d))]
			internal void KGEOJKOADPA(string value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002AD")]
			[Cpp2IlInjected.Address(RVA = "0x1FDD750", Offset = "0x1FDBD50", VA = "0x181FDD750")]
			internal int GLPPOLAGMCH()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60002AE")]
			[Cpp2IlInjected.Address(RVA = "0x1FDDB50", Offset = "0x1FDC150", VA = "0x181FDDB50")]
			internal void PDHBGEGHGHC(int colorIndex)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002AF")]
			[Cpp2IlInjected.Address(RVA = "0x1FDD500", Offset = "0x1FDBB00", VA = "0x181FDD500")]
			internal string AAMBPKPGDKI()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002B0")]
			[Cpp2IlInjected.Address(RVA = "0x1FDDA80", Offset = "0x1FDC080", VA = "0x181FDDA80")]
			[AsyncStateMachine(typeof(<<BuildConfigMenuInternal>b__5>d))]
			internal void NJBIAFHPNMH(string value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002B1")]
			[Cpp2IlInjected.Address(RVA = "0x1FDD9E0", Offset = "0x1FDBFE0", VA = "0x181FDD9E0")]
			internal bool LEKNKPMGLOF()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60002B2")]
			[Cpp2IlInjected.Address(RVA = "0x1FDD7F0", Offset = "0x1FDBDF0", VA = "0x181FDD7F0")]
			internal void KANOGPFMDHK(bool value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002B3")]
			[Cpp2IlInjected.Address(RVA = "0x1FDDBE0", Offset = "0x1FDC1E0", VA = "0x181FDDBE0")]
			internal bool PJINBHMPEAG()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60002B4")]
			[Cpp2IlInjected.Address(RVA = "0x1FDD950", Offset = "0x1FDBF50", VA = "0x181FDD950")]
			internal void KLLKKHMCDPD(bool value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002B5")]
			[Cpp2IlInjected.Address(RVA = "0x1FDD7A0", Offset = "0x1FDBDA0", VA = "0x181FDD7A0")]
			internal float HPHIAECADLD()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x60002B6")]
			[Cpp2IlInjected.Address(RVA = "0x1FDD6C0", Offset = "0x1FDBCC0", VA = "0x181FDD6C0")]
			internal void CGNAFIIFHFC(float value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002B7")]
			[Cpp2IlInjected.Address(RVA = "0x1FDD660", Offset = "0x1FDBC60", VA = "0x181FDD660")]
			internal int BNIJAPHJHMC()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60002B8")]
			[Cpp2IlInjected.Address(RVA = "0x1FDD550", Offset = "0x1FDBB50", VA = "0x181FDD550")]
			internal void ANPBCEJMOLF(int value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002B9")]
			[Cpp2IlInjected.Address(RVA = "0x1FDD5F0", Offset = "0x1FDBBF0", VA = "0x181FDD5F0")]
			internal bool BNFANILJMNA()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		public override NodeVisualizationKey EHBGNDCNEJA
		{
			[Cpp2IlInjected.Token(Token = "0x60002A8")]
			[Cpp2IlInjected.Address(RVA = "0x8EF840", Offset = "0x8EDE40", VA = "0x1808EF840", Slot = "91")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002A7")]
		[Cpp2IlInjected.Address(RVA = "0x1FCCE20", Offset = "0x1FCB420", VA = "0x181FCCE20")]
		public FNPICADDFCG(PJNMBNAHIFL ALELNINOAGK, BHBDAAPECOA EMDFCFPCFGG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A9")]
		[Cpp2IlInjected.Address(RVA = "0x1FCC3E0", Offset = "0x1FCA9E0", VA = "0x181FCC3E0", Slot = "120")]
		protected override void AANCPJNHLHN(GDJFKKGDGFJ KMONEIKIHIC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006F")]
	public sealed class DHNLPINGHKN : DCANGPMKHHL<AEEJJGFAIAB>
	{
		[Cpp2IlInjected.Token(Token = "0x2000070")]
		[CompilerGenerated]
		private sealed class KEHGLPABIND
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000189")]
			public BKKHOHENKFL nodeAdapterDeps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400018A")]
			public DHNLPINGHKN <>4__this;

			[Cpp2IlInjected.Token(Token = "0x60002C1")]
			[Cpp2IlInjected.Address(RVA = "0x86C4B0", Offset = "0x86AAB0", VA = "0x18086C4B0")]
			public KEHGLPABIND()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002C2")]
			[Cpp2IlInjected.Address(RVA = "0x1FD3880", Offset = "0x1FD1E80", VA = "0x181FD3880")]
			internal Dictionary<string, OJKMPFKGAPM> MGLFNJMCMEN()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002C3")]
			[Cpp2IlInjected.Address(RVA = "0x1FD3830", Offset = "0x1FD1E30", VA = "0x181FD3830")]
			internal int KGEOJKOADPA()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60002C4")]
			[Cpp2IlInjected.Address(RVA = "0x1FD3710", Offset = "0x1FD1D10", VA = "0x181FD3710")]
			internal void GLPPOLAGMCH(int value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002C5")]
			[Cpp2IlInjected.Address(RVA = "0x1FD3920", Offset = "0x1FD1F20", VA = "0x181FD3920")]
			internal bool PDHBGEGHGHC()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public override NodeVisualizationKey EHBGNDCNEJA
		{
			[Cpp2IlInjected.Token(Token = "0x60002BF")]
			[Cpp2IlInjected.Address(RVA = "0x8EF840", Offset = "0x8EDE40", VA = "0x1808EF840", Slot = "91")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002BE")]
		[Cpp2IlInjected.Address(RVA = "0x1FC8B60", Offset = "0x1FC7160", VA = "0x181FC8B60")]
		public DHNLPINGHKN(PJNMBNAHIFL ALELNINOAGK, AEEJJGFAIAB AKLCDEBLEOF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C0")]
		[Cpp2IlInjected.Address(RVA = "0x1FC8890", Offset = "0x1FC6E90", VA = "0x181FC8890", Slot = "120")]
		protected override void AANCPJNHLHN(GDJFKKGDGFJ KMONEIKIHIC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000071")]
	public sealed class KOHJMBLPDKO : DCANGPMKHHL<OGCEOFPGINL>
	{
		[Cpp2IlInjected.Token(Token = "0x2000072")]
		[CompilerGenerated]
		private sealed class GBGJGGPDIDN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400018B")]
			public BKKHOHENKFL nodeAdapterDeps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400018C")]
			public KOHJMBLPDKO <>4__this;

			[Cpp2IlInjected.Token(Token = "0x60002C9")]
			[Cpp2IlInjected.Address(RVA = "0x86C4B0", Offset = "0x86AAB0", VA = "0x18086C4B0")]
			public GBGJGGPDIDN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002CA")]
			[Cpp2IlInjected.Address(RVA = "0x1FCCE90", Offset = "0x1FCB490", VA = "0x181FCCE90")]
			internal void MGLFNJMCMEN()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		public override NodeVisualizationKey EHBGNDCNEJA
		{
			[Cpp2IlInjected.Token(Token = "0x60002C7")]
			[Cpp2IlInjected.Address(RVA = "0x8EF840", Offset = "0x8EDE40", VA = "0x1808EF840", Slot = "91")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002C6")]
		[Cpp2IlInjected.Address(RVA = "0x1FD3E90", Offset = "0x1FD2490", VA = "0x181FD3E90")]
		public KOHJMBLPDKO(PJNMBNAHIFL ALELNINOAGK, OGCEOFPGINL AKLCDEBLEOF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C8")]
		[Cpp2IlInjected.Address(RVA = "0x1FD3D10", Offset = "0x1FD2310", VA = "0x181FD3D10", Slot = "120")]
		protected override void AANCPJNHLHN(GDJFKKGDGFJ KMONEIKIHIC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000073")]
	private sealed class KFBHCLEJADH : FLCNKOKNGMP<BPBMKJLOKNL>
	{
		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public override bool NOEBMMEIBJC
		{
			[Cpp2IlInjected.Token(Token = "0x60002CB")]
			[Cpp2IlInjected.Address(RVA = "0x881710", Offset = "0x87FD10", VA = "0x180881710", Slot = "93")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		public override bool GNCHDNHHGCP
		{
			[Cpp2IlInjected.Token(Token = "0x60002CC")]
			[Cpp2IlInjected.Address(RVA = "0x1FD3A00", Offset = "0x1FD2000", VA = "0x181FD3A00", Slot = "117")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public override NodeVisualizationKey EHBGNDCNEJA
		{
			[Cpp2IlInjected.Token(Token = "0x60002CD")]
			[Cpp2IlInjected.Address(RVA = "0x906FA0", Offset = "0x9055A0", VA = "0x180906FA0", Slot = "91")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002CE")]
		[Cpp2IlInjected.Address(RVA = "0x1FD39A0", Offset = "0x1FD1FA0", VA = "0x181FD39A0")]
		public KFBHCLEJADH(PJNMBNAHIFL ALELNINOAGK, BPBMKJLOKNL EMDFCFPCFGG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CF")]
		[Cpp2IlInjected.Address(RVA = "0x867790", Offset = "0x865D90", VA = "0x180867790", Slot = "120")]
		protected override void AANCPJNHLHN(GDJFKKGDGFJ KMONEIKIHIC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000074")]
	private sealed class NGIADEAAKEF : DCANGPMKHHL<LOAECKFMKMB>
	{
		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		public override NodeVisualizationKey EHBGNDCNEJA
		{
			[Cpp2IlInjected.Token(Token = "0x60002D0")]
			[Cpp2IlInjected.Address(RVA = "0x8F20E0", Offset = "0x8F06E0", VA = "0x1808F20E0", Slot = "91")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002D1")]
		[Cpp2IlInjected.Address(RVA = "0x1FDC3E0", Offset = "0x1FDA9E0", VA = "0x181FDC3E0")]
		public NGIADEAAKEF(PJNMBNAHIFL ALELNINOAGK, LOAECKFMKMB EMDFCFPCFGG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D2")]
		[Cpp2IlInjected.Address(RVA = "0x867790", Offset = "0x865D90", VA = "0x180867790", Slot = "120")]
		protected override void AANCPJNHLHN(GDJFKKGDGFJ KMONEIKIHIC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000075")]
	private sealed class IEAPJNBDPJM : DCANGPMKHHL<MDJFCHDECOM>
	{
		[Cpp2IlInjected.Token(Token = "0x17000040")]
		public override NodeVisualizationKey EHBGNDCNEJA
		{
			[Cpp2IlInjected.Token(Token = "0x60002D3")]
			[Cpp2IlInjected.Address(RVA = "0x8FF710", Offset = "0x8FDD10", VA = "0x1808FF710", Slot = "91")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002D4")]
		[Cpp2IlInjected.Address(RVA = "0x1FCE670", Offset = "0x1FCCC70", VA = "0x181FCE670")]
		public IEAPJNBDPJM(PJNMBNAHIFL ALELNINOAGK, MDJFCHDECOM EMDFCFPCFGG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D5")]
		[Cpp2IlInjected.Address(RVA = "0x881710", Offset = "0x87FD10", VA = "0x180881710", Slot = "112")]
		protected override bool ODKENONLAJO(CGBGMGFBCKF<HGFEOPBBPIG> GKEOEKGAILK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D6")]
		[Cpp2IlInjected.Address(RVA = "0x867790", Offset = "0x865D90", VA = "0x180867790", Slot = "120")]
		protected override void AANCPJNHLHN(GDJFKKGDGFJ KMONEIKIHIC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000076")]
	private sealed class AOLLGEMDLCE : DCANGPMKHHL<NGHDIIANLIA>
	{
		[Cpp2IlInjected.Token(Token = "0x17000041")]
		public override NodeVisualizationKey EHBGNDCNEJA
		{
			[Cpp2IlInjected.Token(Token = "0x60002D7")]
			[Cpp2IlInjected.Address(RVA = "0x8FC7E0", Offset = "0x8FADE0", VA = "0x1808FC7E0", Slot = "91")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		public override bool JGICPFBHJJF
		{
			[Cpp2IlInjected.Token(Token = "0x60002D8")]
			[Cpp2IlInjected.Address(RVA = "0x1FC6D70", Offset = "0x1FC5370", VA = "0x181FC6D70", Slot = "92")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000043")]
		protected override bool MGJFPKPAAAN
		{
			[Cpp2IlInjected.Token(Token = "0x60002D9")]
			[Cpp2IlInjected.Address(RVA = "0x881710", Offset = "0x87FD10", VA = "0x180881710", Slot = "90")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002DA")]
		[Cpp2IlInjected.Address(RVA = "0x1FC6D00", Offset = "0x1FC5300", VA = "0x181FC6D00")]
		public AOLLGEMDLCE(PJNMBNAHIFL ALELNINOAGK, NGHDIIANLIA EMDFCFPCFGG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DB")]
		[Cpp2IlInjected.Address(RVA = "0x867790", Offset = "0x865D90", VA = "0x180867790", Slot = "120")]
		protected override void AANCPJNHLHN(GDJFKKGDGFJ KMONEIKIHIC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000077")]
	private sealed class NLLJPLPLLEF : DCANGPMKHHL<JLNIIMOKMAB>
	{
		[Cpp2IlInjected.Token(Token = "0x17000044")]
		public override NodeVisualizationKey EHBGNDCNEJA
		{
			[Cpp2IlInjected.Token(Token = "0x60002DC")]
			[Cpp2IlInjected.Address(RVA = "0x8F6240", Offset = "0x8F4840", VA = "0x1808F6240", Slot = "91")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000045")]
		public override bool JGICPFBHJJF
		{
			[Cpp2IlInjected.Token(Token = "0x60002DD")]
			[Cpp2IlInjected.Address(RVA = "0x1FDCB10", Offset = "0x1FDB110", VA = "0x181FDCB10", Slot = "92")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000046")]
		protected override bool MGJFPKPAAAN
		{
			[Cpp2IlInjected.Token(Token = "0x60002DE")]
			[Cpp2IlInjected.Address(RVA = "0x881710", Offset = "0x87FD10", VA = "0x180881710", Slot = "90")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002DF")]
		[Cpp2IlInjected.Address(RVA = "0x1FDCAA0", Offset = "0x1FDB0A0", VA = "0x181FDCAA0")]
		public NLLJPLPLLEF(PJNMBNAHIFL ALELNINOAGK, JLNIIMOKMAB EMDFCFPCFGG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E0")]
		[Cpp2IlInjected.Address(RVA = "0x867790", Offset = "0x865D90", VA = "0x180867790", Slot = "120")]
		protected override void AANCPJNHLHN(GDJFKKGDGFJ KMONEIKIHIC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000078")]
	public sealed class MLLKCIACCFG : PDOMBIKABAA<FKNJHBPCCHN>
	{
		[Cpp2IlInjected.Token(Token = "0x2000079")]
		[CompilerGenerated]
		private sealed class CGHCBDKAIKE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400018D")]
			public MLLKCIACCFG <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400018E")]
			public BKKHOHENKFL nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x60002E3")]
			[Cpp2IlInjected.Address(RVA = "0x86C4B0", Offset = "0x86AAB0", VA = "0x18086C4B0")]
			public CGHCBDKAIKE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002E4")]
			[Cpp2IlInjected.Address(RVA = "0x1FC7E80", Offset = "0x1FC6480", VA = "0x181FC7E80")]
			internal float EEPGJPPHOAA()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x60002E5")]
			[Cpp2IlInjected.Address(RVA = "0x1FC7F00", Offset = "0x1FC6500", VA = "0x181FC7F00")]
			internal void PHEGNFLGKBH(float value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002E1")]
		[Cpp2IlInjected.Address(RVA = "0x1FD5390", Offset = "0x1FD3990", VA = "0x181FD5390")]
		public MLLKCIACCFG(PJNMBNAHIFL ALELNINOAGK, FKNJHBPCCHN AKLCDEBLEOF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E2")]
		[Cpp2IlInjected.Address(RVA = "0x1FD5110", Offset = "0x1FD3710", VA = "0x181FD5110", Slot = "126")]
		protected override void NOFDDFDGBMI(GDJFKKGDGFJ KMONEIKIHIC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007A")]
	public sealed class NHFCLCNMFOO : DCANGPMKHHL<LAJAOABDFFP>
	{
		[Cpp2IlInjected.Token(Token = "0x200007B")]
		[CompilerGenerated]
		private sealed class LBIEOFDBMOP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400018F")]
			public NHFCLCNMFOO <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000190")]
			public BKKHOHENKFL nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x60002E8")]
			[Cpp2IlInjected.Address(RVA = "0x86C4B0", Offset = "0x86AAB0", VA = "0x18086C4B0")]
			public LBIEOFDBMOP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002E9")]
			[Cpp2IlInjected.Address(RVA = "0x1FD4020", Offset = "0x1FD2620", VA = "0x181FD4020")]
			internal bool MGLFNJMCMEN()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60002EA")]
			[Cpp2IlInjected.Address(RVA = "0x1FD3F00", Offset = "0x1FD2500", VA = "0x181FD3F00")]
			internal void KGEOJKOADPA(bool value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002E6")]
		[Cpp2IlInjected.Address(RVA = "0x1FDC700", Offset = "0x1FDAD00", VA = "0x181FDC700")]
		public NHFCLCNMFOO(PJNMBNAHIFL ALELNINOAGK, LAJAOABDFFP AKLCDEBLEOF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E7")]
		[Cpp2IlInjected.Address(RVA = "0x1FDC450", Offset = "0x1FDAA50", VA = "0x181FDC450", Slot = "120")]
		protected override void AANCPJNHLHN(GDJFKKGDGFJ KMONEIKIHIC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007C")]
	public sealed class EMLEMDLAAPD : DCANGPMKHHL<CPHMKJPFLAC>
	{
		[Cpp2IlInjected.Token(Token = "0x200007D")]
		[CompilerGenerated]
		private sealed class GKBNDCJKEPM
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000191")]
			public BKKHOHENKFL nodeAdapterDeps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000192")]
			public EMLEMDLAAPD <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000193")]
			public Predicate<Guid> <>9__7;

			[Cpp2IlInjected.Token(Token = "0x60002ED")]
			[Cpp2IlInjected.Address(RVA = "0x86C4B0", Offset = "0x86AAB0", VA = "0x18086C4B0")]
			public GKBNDCJKEPM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002EE")]
			[Cpp2IlInjected.Address(RVA = "0x1FCDB70", Offset = "0x1FCC170", VA = "0x181FCDB70")]
			internal object MGLFNJMCMEN()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002EF")]
			[Cpp2IlInjected.Address(RVA = "0x1FCD780", Offset = "0x1FCBD80", VA = "0x181FCD780")]
			internal bool KANOGPFMDHK(Guid id)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60002F0")]
			[Cpp2IlInjected.Address(RVA = "0x1FCD800", Offset = "0x1FCBE00", VA = "0x181FCD800")]
			internal void KGEOJKOADPA(object value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002F1")]
			[Cpp2IlInjected.Address(RVA = "0x1FCD620", Offset = "0x1FCBC20", VA = "0x181FCD620")]
			internal string GLPPOLAGMCH(object key)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002F2")]
			[Cpp2IlInjected.Address(RVA = "0x1FCDCF0", Offset = "0x1FCC2F0", VA = "0x181FCDCF0")]
			internal IReadOnlyList<object> PDHBGEGHGHC()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002F3")]
			[Cpp2IlInjected.Address(RVA = "0x1FCD5B0", Offset = "0x1FCBBB0", VA = "0x181FCD5B0")]
			internal bool AAMBPKPGDKI()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60002F4")]
			[Cpp2IlInjected.Address(RVA = "0x1FCDCA0", Offset = "0x1FCC2A0", VA = "0x181FCDCA0")]
			internal bool NJBIAFHPNMH()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60002F5")]
			[Cpp2IlInjected.Address(RVA = "0x1FCDA50", Offset = "0x1FCC050", VA = "0x181FCDA50")]
			internal void LEKNKPMGLOF(bool value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002EB")]
		[Cpp2IlInjected.Address(RVA = "0x1FCA9C0", Offset = "0x1FC8FC0", VA = "0x181FCA9C0")]
		public EMLEMDLAAPD(PJNMBNAHIFL ALELNINOAGK, CPHMKJPFLAC AKLCDEBLEOF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EC")]
		[Cpp2IlInjected.Address(RVA = "0x1FCA190", Offset = "0x1FC8790", VA = "0x181FCA190", Slot = "120")]
		protected override void AANCPJNHLHN(GDJFKKGDGFJ KMONEIKIHIC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007E")]
	public sealed class PLCMLPJDIGM : BDHLCPDJKEP<BKCKPHCPBHC>
	{
		[Cpp2IlInjected.Token(Token = "0x17000047")]
		public override NodeVisualizationKey EHBGNDCNEJA
		{
			[Cpp2IlInjected.Token(Token = "0x60002F6")]
			[Cpp2IlInjected.Address(RVA = "0xAD3100", Offset = "0xAD1700", VA = "0x180AD3100", Slot = "91")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002F7")]
		[Cpp2IlInjected.Address(RVA = "0x1FE1040", Offset = "0x1FDF640", VA = "0x181FE1040")]
		public PLCMLPJDIGM(PJNMBNAHIFL ALELNINOAGK, BKCKPHCPBHC EMDFCFPCFGG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007F")]
	public sealed class ODMHDDIGHDA : PDOMBIKABAA<CLOEIMOGPOE>
	{
		[Cpp2IlInjected.Token(Token = "0x2000080")]
		[CompilerGenerated]
		private sealed class IMJOMLKOIIN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000194")]
			public ODMHDDIGHDA <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000195")]
			public BKKHOHENKFL nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x60002FA")]
			[Cpp2IlInjected.Address(RVA = "0x86C4B0", Offset = "0x86AAB0", VA = "0x18086C4B0")]
			public IMJOMLKOIIN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002FB")]
			[Cpp2IlInjected.Address(RVA = "0x1FCE7C0", Offset = "0x1FCCDC0", VA = "0x181FCE7C0")]
			internal int EEPGJPPHOAA()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60002FC")]
			[Cpp2IlInjected.Address(RVA = "0x1FCE840", Offset = "0x1FCCE40", VA = "0x181FCE840")]
			internal void PHEGNFLGKBH(int value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002F8")]
		[Cpp2IlInjected.Address(RVA = "0x1FDD4A0", Offset = "0x1FDBAA0", VA = "0x181FDD4A0")]
		public ODMHDDIGHDA(PJNMBNAHIFL ALELNINOAGK, CLOEIMOGPOE AKLCDEBLEOF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F9")]
		[Cpp2IlInjected.Address(RVA = "0x1FDD210", Offset = "0x1FDB810", VA = "0x181FDD210", Slot = "126")]
		protected override void NOFDDFDGBMI(GDJFKKGDGFJ KMONEIKIHIC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000081")]
	public sealed class OCANDLCNDKD : DCANGPMKHHL<HKHPIEFNJPO>
	{
		[Cpp2IlInjected.Token(Token = "0x2000082")]
		[CompilerGenerated]
		private sealed class OOEHJPPJJAF
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000196")]
			public OCANDLCNDKD <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000197")]
			public BKKHOHENKFL nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x60002FF")]
			[Cpp2IlInjected.Address(RVA = "0x86C4B0", Offset = "0x86AAB0", VA = "0x18086C4B0")]
			public OOEHJPPJJAF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000300")]
			[Cpp2IlInjected.Address(RVA = "0x1FDE090", Offset = "0x1FDC690", VA = "0x181FDE090")]
			internal bool MGLFNJMCMEN()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000301")]
			[Cpp2IlInjected.Address(RVA = "0x1FDE000", Offset = "0x1FDC600", VA = "0x181FDE000")]
			internal void KGEOJKOADPA(bool value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002FD")]
		[Cpp2IlInjected.Address(RVA = "0x1FDD1A0", Offset = "0x1FDB7A0", VA = "0x181FDD1A0")]
		public OCANDLCNDKD(PJNMBNAHIFL ALELNINOAGK, HKHPIEFNJPO AKLCDEBLEOF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002FE")]
		[Cpp2IlInjected.Address(RVA = "0x1FDCFC0", Offset = "0x1FDB5C0", VA = "0x181FDCFC0", Slot = "120")]
		protected override void AANCPJNHLHN(GDJFKKGDGFJ KMONEIKIHIC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000083")]
	public sealed class OIBDBIMLAPG : DCANGPMKHHL<OMDCMIEGDEM>
	{
		[Cpp2IlInjected.Token(Token = "0x2000084")]
		[CompilerGenerated]
		private sealed class IFGLJEEGIDH
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000198")]
			public OIBDBIMLAPG <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000199")]
			public BKKHOHENKFL nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x6000304")]
			[Cpp2IlInjected.Address(RVA = "0x86C4B0", Offset = "0x86AAB0", VA = "0x18086C4B0")]
			public IFGLJEEGIDH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000305")]
			[Cpp2IlInjected.Address(RVA = "0x1FCE770", Offset = "0x1FCCD70", VA = "0x181FCE770")]
			internal bool MGLFNJMCMEN()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000306")]
			[Cpp2IlInjected.Address(RVA = "0x1FCE6E0", Offset = "0x1FCCCE0", VA = "0x181FCE6E0")]
			internal void KGEOJKOADPA(bool value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000302")]
		[Cpp2IlInjected.Address(RVA = "0x1FDDF30", Offset = "0x1FDC530", VA = "0x181FDDF30")]
		public OIBDBIMLAPG(PJNMBNAHIFL ALELNINOAGK, OMDCMIEGDEM AKLCDEBLEOF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000303")]
		[Cpp2IlInjected.Address(RVA = "0x1FDDD50", Offset = "0x1FDC350", VA = "0x181FDDD50", Slot = "120")]
		protected override void AANCPJNHLHN(GDJFKKGDGFJ KMONEIKIHIC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000085")]
	public sealed class KKONEAMEPPI : DCANGPMKHHL<KCPCHPDMICJ>
	{
		[Cpp2IlInjected.Token(Token = "0x2000086")]
		[CompilerGenerated]
		private sealed class GINEMKLHIND
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400019A")]
			public KKONEAMEPPI <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400019B")]
			public BKKHOHENKFL nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x6000309")]
			[Cpp2IlInjected.Address(RVA = "0x86C4B0", Offset = "0x86AAB0", VA = "0x18086C4B0")]
			public GINEMKLHIND()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600030A")]
			[Cpp2IlInjected.Address(RVA = "0x1FCD560", Offset = "0x1FCBB60", VA = "0x181FCD560")]
			internal int MGLFNJMCMEN()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x600030B")]
			[Cpp2IlInjected.Address(RVA = "0x1FCD4D0", Offset = "0x1FCBAD0", VA = "0x181FCD4D0")]
			internal void KGEOJKOADPA(int value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000307")]
		[Cpp2IlInjected.Address(RVA = "0x1FD3CA0", Offset = "0x1FD22A0", VA = "0x181FD3CA0")]
		public KKONEAMEPPI(PJNMBNAHIFL ALELNINOAGK, KCPCHPDMICJ AKLCDEBLEOF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000308")]
		[Cpp2IlInjected.Address(RVA = "0x1FD3A40", Offset = "0x1FD2040", VA = "0x181FD3A40", Slot = "120")]
		protected override void AANCPJNHLHN(GDJFKKGDGFJ KMONEIKIHIC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000087")]
	public sealed class ELOOILLEOID : ONPIPBFAAKM<CDLAFMBJIII>
	{
		[Cpp2IlInjected.Token(Token = "0x17000048")]
		public override BDJFDBHNNED MFPOPCILKGP
		{
			[Cpp2IlInjected.Token(Token = "0x600030D")]
			[Cpp2IlInjected.Address(RVA = "0x8F3C30", Offset = "0x8F2230", VA = "0x1808F3C30", Slot = "126")]
			get
			{
				return default(BDJFDBHNNED);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600030C")]
		[Cpp2IlInjected.Address(RVA = "0x1FCA130", Offset = "0x1FC8730", VA = "0x181FCA130")]
		public ELOOILLEOID(PJNMBNAHIFL ALELNINOAGK, CDLAFMBJIII AKLCDEBLEOF)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000088")]
	public class FBMCAPJFHHI : DCANGPMKHHL<JJAEOPCJMCB>
	{
		[Cpp2IlInjected.Token(Token = "0x600030E")]
		[Cpp2IlInjected.Address(RVA = "0x1FCA0C0", Offset = "0x1FC86C0", VA = "0x181FCA0C0")]
		public FBMCAPJFHHI(PJNMBNAHIFL ALELNINOAGK, JJAEOPCJMCB EMDFCFPCFGG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000089")]
	public abstract class DCANGPMKHHL<TNode> : INBEHHBGGBG, IDisposable where TNode : notnull, JJAEOPCJMCB
	{
		[Cpp2IlInjected.Token(Token = "0x200008A")]
		[CompilerGenerated]
		private sealed class LOCDGMGNKIH
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001B3")]
			public DCANGPMKHHL<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001B4")]
			public PJNMBNAHIFL circuitsManager;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001B5")]
			public TNode node;

			[Cpp2IlInjected.Token(Token = "0x600038C")]
			[Cpp2IlInjected.Address(RVA = "0x86C4B0", Offset = "0x86AAB0", VA = "0x18086C4B0")]
			public LOCDGMGNKIH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600038D")]
			[Cpp2IlInjected.Address(RVA = "0x42ECE30", Offset = "0x42EB430", VA = "0x1842ECE30")]
			internal NBEMJHPNING CILOCLHPDGG(DFIHDLEBDJG portGroup, int id)
			{
				return null;
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200008B")]
		[CompilerGenerated]
		private struct LFIPMNAABNP : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001B6")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001B7")]
			public AsyncVoidMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001B8")]
			public DCANGPMKHHL<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001B9")]
			public int newColor;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001BA")]
			private TaskAwaiter<CBDPDIPONCF<COKMANPFJNC, FBDDJIHDMAI>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600038E")]
			[Cpp2IlInjected.Address(RVA = "0x42CB820", Offset = "0x42C9E20", VA = "0x1842CB820", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600038F")]
			[Cpp2IlInjected.Address(RVA = "0xA20370", Offset = "0xA1E970", VA = "0x180A20370", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200008C")]
		[CompilerGenerated]
		private struct IDHKAOMAFLG : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001BB")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001BC")]
			public AsyncTaskMethodBuilder<CBDPDIPONCF<COKMANPFJNC, FBDDJIHDMAI>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001BD")]
			public DCANGPMKHHL<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001BE")]
			public DHNIBFCDNLJ? localPosition;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001BF")]
			public PBDCHDIIPAE? localRotation;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001C0")]
			private TaskAwaiter<CBDPDIPONCF<COKMANPFJNC, FBDDJIHDMAI>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000390")]
			[Cpp2IlInjected.Address(RVA = "0x3E59D90", Offset = "0x3E58390", VA = "0x183E59D90", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000391")]
			[Cpp2IlInjected.Address(RVA = "0x3E5A040", Offset = "0x3E58640", VA = "0x183E5A040", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200008D")]
		[CompilerGenerated]
		private sealed class DOKAABDPINA
		{
			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x200008E")]
			private struct <<BuildStringChangeMenuInternal>b__2>d : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001C8")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001C9")]
				public AsyncVoidMethodBuilder <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001CA")]
				public DOKAABDPINA <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001CB")]
				private TaskAwaiter<bool> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x6000396")]
				[Cpp2IlInjected.Address(RVA = "0x35BA2C0", Offset = "0x35B88C0", VA = "0x1835BA2C0", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000397")]
				[Cpp2IlInjected.Address(RVA = "0xA20370", Offset = "0xA1E970", VA = "0x180A20370", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001C1")]
			public string newName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001C2")]
			public Func<string, bool> submitValidator;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001C3")]
			public BKKHOHENKFL nodeAdapterDeps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001C4")]
			public DCANGPMKHHL<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001C5")]
			public Func<string> getConfigurableName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001C6")]
			public GDJFKKGDGFJ configure;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001C7")]
			public Action<string> setConfigurableName;

			[Cpp2IlInjected.Token(Token = "0x6000392")]
			[Cpp2IlInjected.Address(RVA = "0x86C4B0", Offset = "0x86AAB0", VA = "0x18086C4B0")]
			public DOKAABDPINA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000393")]
			[Cpp2IlInjected.Address(RVA = "0x868220", Offset = "0x866820", VA = "0x180868220")]
			internal string AHKJIKCKFNK()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000394")]
			[Cpp2IlInjected.Address(RVA = "0x868250", Offset = "0x866850", VA = "0x180868250")]
			internal void EDLICCABIOP(string value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000395")]
			[Cpp2IlInjected.Address(RVA = "0x58EC750", Offset = "0x58EAD50", VA = "0x1858EC750")]
			[AsyncStateMachine(typeof(DCANGPMKHHL<>.DOKAABDPINA.<<BuildStringChangeMenuInternal>b__2>d))]
			internal void GIECPDIBGAO()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200008F")]
		[CompilerGenerated]
		private sealed class CHBNNOHOEDD
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001CC")]
			public BKKHOHENKFL nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x6000398")]
			[Cpp2IlInjected.Address(RVA = "0x86C4B0", Offset = "0x86AAB0", VA = "0x18086C4B0")]
			public CHBNNOHOEDD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000399")]
			[Cpp2IlInjected.Address(RVA = "0x538F940", Offset = "0x538DF40", VA = "0x18538F940")]
			internal bool JANABOIEFLP(string text)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600039A")]
			[Cpp2IlInjected.Address(RVA = "0x538F930", Offset = "0x538DF30", VA = "0x18538F930")]
			internal bool GCOCIPHLGKO(string text)
			{
				return default(bool);
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000090")]
		[CompilerGenerated]
		private struct IELHNGIMPLK : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001CD")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001CE")]
			public AsyncTaskMethodBuilder<CBDPDIPONCF<COKMANPFJNC, FBDDJIHDMAI>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001CF")]
			public DCANGPMKHHL<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001D0")]
			public string newName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001D1")]
			private TaskAwaiter<CBDPDIPONCF<COKMANPFJNC, FBDDJIHDMAI>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600039B")]
			[Cpp2IlInjected.Address(RVA = "0x3E66640", Offset = "0x3E64C40", VA = "0x183E66640", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600039C")]
			[Cpp2IlInjected.Address(RVA = "0x3E669D0", Offset = "0x3E64FD0", VA = "0x183E669D0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400019C")]
		private readonly PJNMBNAHIFL NKJLAAKEIDF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400019D")]
		private readonly bool FDDBMMLIEEC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400019E")]
		private GBHAABHCALK<HGFEOPBBPIG, NBEMJHPNING> NPFFIIBGCAJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400019F")]
		private GBHAABHCALK<HGFEOPBBPIG, PDDIJOAHCGO> APCNONIAKGI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001A7")]
		private List<Action> HMEIBDENCFO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001AF")]
		[CompilerGenerated]
		private Action<CGBGMGFBCKF<HGFEOPBBPIG>>? IGKPJEALKJA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001B0")]
		[CompilerGenerated]
		private Action<CGBGMGFBCKF<HGFEOPBBPIG>, PDDIJOAHCGO>? BKLMJNJKLFK;

		[Cpp2IlInjected.Token(Token = "0x17000049")]
		protected LCKLOOAKLPO IACAOFPFCMI
		{
			[Cpp2IlInjected.Token(Token = "0x600030F")]
			[Cpp2IlInjected.Address(RVA = "0x58AFCA0", Offset = "0x58AE2A0", VA = "0x1858AFCA0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004A")]
		protected BKKHOHENKFL MFJGCCHKLHJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000310")]
			[Cpp2IlInjected.Address(RVA = "0x58AEBD0", Offset = "0x58AD1D0", VA = "0x1858AEBD0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004B")]
		protected TNode NGEKAEDBOBA
		{
			[Cpp2IlInjected.Token(Token = "0x6000314")]
			[Cpp2IlInjected.Address(RVA = "0x868260", Offset = "0x866860", VA = "0x180868260")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004C")]
		public HBIPEINCKFG<HCHFDOFEDKE> EDIECAKKAOJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000315")]
			[Cpp2IlInjected.Address(RVA = "0xB4CD00", Offset = "0xB4B300", VA = "0x180B4CD00", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(HBIPEINCKFG<HCHFDOFEDKE>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004D")]
		public CGBGMGFBCKF<DLDOKKGNCJH> FHHEADOLFNG
		{
			[Cpp2IlInjected.Token(Token = "0x6000316")]
			[Cpp2IlInjected.Address(RVA = "0x58B3A00", Offset = "0x58B2000", VA = "0x1858B3A00", Slot = "6")]
			get
			{
				return default(CGBGMGFBCKF<DLDOKKGNCJH>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004E")]
		public object JFGGKCGEEOA
		{
			[Cpp2IlInjected.Token(Token = "0x6000317")]
			[Cpp2IlInjected.Address(RVA = "0x38DB8A0", Offset = "0x38D9EA0", VA = "0x1838DB8A0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004F")]
		public virtual bool KKOCKJIEIBO
		{
			[Cpp2IlInjected.Token(Token = "0x6000318")]
			[Cpp2IlInjected.Address(RVA = "0x881710", Offset = "0x87FD10", VA = "0x180881710", Slot = "89")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000050")]
		public int MPMBBOKEEJM
		{
			[Cpp2IlInjected.Token(Token = "0x6000319")]
			[Cpp2IlInjected.Address(RVA = "0x58B3630", Offset = "0x58B1C30", VA = "0x1858B3630", Slot = "8")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000051")]
		public MPHLCIAMIGI LLGDPCFLHLM
		{
			[Cpp2IlInjected.Token(Token = "0x600031B")]
			[Cpp2IlInjected.Address(RVA = "0x58B35D0", Offset = "0x58B1BD0", VA = "0x1858B35D0", Slot = "10")]
			get
			{
				return default(MPHLCIAMIGI);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000052")]
		public string AMHNJMKGOID
		{
			[Cpp2IlInjected.Token(Token = "0x600031C")]
			[Cpp2IlInjected.Address(RVA = "0x58B3BC0", Offset = "0x58B21C0", VA = "0x1858B3BC0", Slot = "11")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000053")]
		protected virtual bool MGJFPKPAAAN
		{
			[Cpp2IlInjected.Token(Token = "0x600031D")]
			[Cpp2IlInjected.Address(RVA = "0x8AF060", Offset = "0x8AD660", VA = "0x1808AF060", Slot = "90")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000054")]
		public virtual NodeVisualizationKey EHBGNDCNEJA
		{
			[Cpp2IlInjected.Token(Token = "0x600031E")]
			[Cpp2IlInjected.Address(RVA = "0x8677A0", Offset = "0x865DA0", VA = "0x1808677A0", Slot = "91")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000055")]
		public CGBGMGFBCKF<BFIJLMKHKDC> BGBCDDOGGBB
		{
			[Cpp2IlInjected.Token(Token = "0x600031F")]
			[Cpp2IlInjected.Address(RVA = "0x9502D0", Offset = "0x94E8D0", VA = "0x1809502D0", Slot = "13")]
			[CompilerGenerated]
			get
			{
				return default(CGBGMGFBCKF<BFIJLMKHKDC>);
			}
			[Cpp2IlInjected.Token(Token = "0x6000320")]
			[Cpp2IlInjected.Address(RVA = "0xB3DD80", Offset = "0xB3C380", VA = "0x180B3DD80")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000056")]
		public virtual bool JGICPFBHJJF
		{
			[Cpp2IlInjected.Token(Token = "0x6000321")]
			[Cpp2IlInjected.Address(RVA = "0x8AF060", Offset = "0x8AD660", VA = "0x1808AF060", Slot = "92")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000057")]
		public virtual bool NOEBMMEIBJC
		{
			[Cpp2IlInjected.Token(Token = "0x6000322")]
			[Cpp2IlInjected.Address(RVA = "0x8AF060", Offset = "0x8AD660", VA = "0x1808AF060", Slot = "93")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000058")]
		public virtual MBKFEDOAILK JOIPAAJINPE
		{
			[Cpp2IlInjected.Token(Token = "0x6000323")]
			[Cpp2IlInjected.Address(RVA = "0xAA5560", Offset = "0xAA3B60", VA = "0x180AA5560", Slot = "94")]
			get
			{
				return default(MBKFEDOAILK);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000059")]
		public bool AJKFFNCHECJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000324")]
			[Cpp2IlInjected.Address(RVA = "0x58B32E0", Offset = "0x58B18E0", VA = "0x1858B32E0", Slot = "17")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005A")]
		public bool DPOCFHEPJNM
		{
			[Cpp2IlInjected.Token(Token = "0x6000325")]
			[Cpp2IlInjected.Address(RVA = "0x58B3350", Offset = "0x58B1950", VA = "0x1858B3350", Slot = "18")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005B")]
		public bool FCJLEIBLBJN
		{
			[Cpp2IlInjected.Token(Token = "0x6000326")]
			[Cpp2IlInjected.Address(RVA = "0x58B33C0", Offset = "0x58B19C0", VA = "0x1858B33C0", Slot = "19")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005C")]
		public int CMHNDLBHKCP
		{
			[Cpp2IlInjected.Token(Token = "0x6000327")]
			[Cpp2IlInjected.Address(RVA = "0x58B39A0", Offset = "0x58B1FA0", VA = "0x1858B39A0", Slot = "20")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005D")]
		public bool FHIHLBGGGLP
		{
			[Cpp2IlInjected.Token(Token = "0x6000328")]
			[Cpp2IlInjected.Address(RVA = "0x58B37C0", Offset = "0x58B1DC0", VA = "0x1858B37C0", Slot = "21")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005E")]
		public bool PCKFAFPMBIP
		{
			[Cpp2IlInjected.Token(Token = "0x6000329")]
			[Cpp2IlInjected.Address(RVA = "0x58B34F0", Offset = "0x58B1AF0", VA = "0x1858B34F0", Slot = "22")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005F")]
		public bool LGFABDBLNHI
		{
			[Cpp2IlInjected.Token(Token = "0x600032A")]
			[Cpp2IlInjected.Address(RVA = "0x58B3480", Offset = "0x58B1A80", VA = "0x1858B3480", Slot = "23")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000060")]
		public bool IPKKCAGDKJN
		{
			[Cpp2IlInjected.Token(Token = "0x600032B")]
			[Cpp2IlInjected.Address(RVA = "0xC8F2A0", Offset = "0xC8D8A0", VA = "0x180C8F2A0", Slot = "24")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600032C")]
			[Cpp2IlInjected.Address(RVA = "0xC8F290", Offset = "0xC8D890", VA = "0x180C8F290")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000061")]
		public virtual bool JAHMOGOAEJL
		{
			[Cpp2IlInjected.Token(Token = "0x600032D")]
			[Cpp2IlInjected.Address(RVA = "0x8AF060", Offset = "0x8AD660", VA = "0x1808AF060", Slot = "95")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000062")]
		public virtual bool LGEOILJKEBD
		{
			[Cpp2IlInjected.Token(Token = "0x600032E")]
			[Cpp2IlInjected.Address(RVA = "0x58B3430", Offset = "0x58B1A30", VA = "0x1858B3430", Slot = "96")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000063")]
		public bool COAHFOCMDEJ
		{
			[Cpp2IlInjected.Token(Token = "0x600032F")]
			[Cpp2IlInjected.Address(RVA = "0x58B36F0", Offset = "0x58B1CF0", VA = "0x1858B36F0", Slot = "27")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000064")]
		public DHNIBFCDNLJ AFDJHIPPHGC
		{
			[Cpp2IlInjected.Token(Token = "0x6000330")]
			[Cpp2IlInjected.Address(RVA = "0x58B38E0", Offset = "0x58B1EE0", VA = "0x1858B38E0", Slot = "28")]
			get
			{
				return default(DHNIBFCDNLJ);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000065")]
		public PBDCHDIIPAE JGMGNPPDNFI
		{
			[Cpp2IlInjected.Token(Token = "0x6000332")]
			[Cpp2IlInjected.Address(RVA = "0x58B3940", Offset = "0x58B1F40", VA = "0x1858B3940", Slot = "30")]
			get
			{
				return default(PBDCHDIIPAE);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000066")]
		public virtual bool BCJPHDDCINF
		{
			[Cpp2IlInjected.Token(Token = "0x6000350")]
			[Cpp2IlInjected.Address(RVA = "0x8AF060", Offset = "0x8AD660", VA = "0x1808AF060", Slot = "108")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000067")]
		public virtual KNGNPJIJJFG? IIJLADBNDAF
		{
			[Cpp2IlInjected.Token(Token = "0x6000351")]
			[Cpp2IlInjected.Address(RVA = "0x8677A0", Offset = "0x865DA0", VA = "0x1808677A0", Slot = "109")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000068")]
		public virtual PJMGFNIBBIA? LGIAKLGBONN
		{
			[Cpp2IlInjected.Token(Token = "0x6000352")]
			[Cpp2IlInjected.Address(RVA = "0x8677A0", Offset = "0x865DA0", VA = "0x1808677A0", Slot = "110")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000069")]
		public virtual IEnumerable<HBIPEINCKFG<JBMJEMLAFJB>>? HMFMHOKBOJA
		{
			[Cpp2IlInjected.Token(Token = "0x6000353")]
			[Cpp2IlInjected.Address(RVA = "0x8677A0", Offset = "0x865DA0", VA = "0x1808677A0", Slot = "111")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006A")]
		public bool PNFICLNKNPJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000357")]
			[Cpp2IlInjected.Address(RVA = "0x58B3560", Offset = "0x58B1B60", VA = "0x1858B3560", Slot = "114")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006B")]
		public HBIPEINCKFG<NPIPKFBHIBO> GCGDLJPBLCE
		{
			[Cpp2IlInjected.Token(Token = "0x6000358")]
			[Cpp2IlInjected.Address(RVA = "0x58B3820", Offset = "0x58B1E20", VA = "0x1858B3820", Slot = "62")]
			get
			{
				return default(HBIPEINCKFG<NPIPKFBHIBO>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006C")]
		public CGBGMGFBCKF<NPIPKFBHIBO> IHPNLCLNIBJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000359")]
			[Cpp2IlInjected.Address(RVA = "0x58B3690", Offset = "0x58B1C90", VA = "0x1858B3690", Slot = "56")]
			get
			{
				return default(CGBGMGFBCKF<NPIPKFBHIBO>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006D")]
		public virtual bool MNPAIJIEJCB
		{
			[Cpp2IlInjected.Token(Token = "0x600035A")]
			[Cpp2IlInjected.Address(RVA = "0x8AF060", Offset = "0x8AD660", VA = "0x1808AF060", Slot = "115")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006E")]
		public virtual CGBGMGFBCKF<NPIPKFBHIBO>? FHJFMOPJJKD
		{
			[Cpp2IlInjected.Token(Token = "0x600035B")]
			[Cpp2IlInjected.Address(RVA = "0x8677A0", Offset = "0x865DA0", VA = "0x1808677A0", Slot = "116")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006F")]
		public virtual bool GNCHDNHHGCP
		{
			[Cpp2IlInjected.Token(Token = "0x600035C")]
			[Cpp2IlInjected.Address(RVA = "0x8AF060", Offset = "0x8AD660", VA = "0x1808AF060", Slot = "117")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000070")]
		public bool PFIDFDBNDAH
		{
			[Cpp2IlInjected.Token(Token = "0x600035D")]
			[Cpp2IlInjected.Address(RVA = "0x58B3750", Offset = "0x58B1D50", VA = "0x1858B3750", Slot = "61")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000071")]
		public string OABCLOFHIGC
		{
			[Cpp2IlInjected.Token(Token = "0x600035E")]
			[Cpp2IlInjected.Address(RVA = "0x86C8D0", Offset = "0x86AED0", VA = "0x18086C8D0", Slot = "64")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600035F")]
			[Cpp2IlInjected.Address(RVA = "0x86C8E0", Offset = "0x86AEE0", VA = "0x18086C8E0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000072")]
		private string BEEHAMNLMFN
		{
			[Cpp2IlInjected.Token(Token = "0x6000360")]
			[Cpp2IlInjected.Address(RVA = "0x86C8C0", Offset = "0x86AEC0", VA = "0x18086C8C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000073")]
		public HBIPEINCKFG<JBMJEMLAFJB> MNNCLHPABOH
		{
			[Cpp2IlInjected.Token(Token = "0x6000361")]
			[Cpp2IlInjected.Address(RVA = "0x58B3880", Offset = "0x58B1E80", VA = "0x1858B3880", Slot = "63")]
			get
			{
				return default(HBIPEINCKFG<JBMJEMLAFJB>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000074")]
		public HBIPEINCKFG<JBMJEMLAFJB>? NCIEACDBCNC
		{
			[Cpp2IlInjected.Token(Token = "0x6000362")]
			[Cpp2IlInjected.Address(RVA = "0x58B3A90", Offset = "0x58B2090", VA = "0x1858B3A90", Slot = "118")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000075")]
		public OEMHKMDMOFO<HGFEOPBBPIG, PDDIJOAHCGO> NFCGABJGBIL
		{
			[Cpp2IlInjected.Token(Token = "0x6000363")]
			[Cpp2IlInjected.Address(RVA = "0x58B3B80", Offset = "0x58B2180", VA = "0x1858B3B80", Slot = "65")]
			get
			{
				return default(OEMHKMDMOFO<HGFEOPBBPIG, PDDIJOAHCGO>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000076")]
		public virtual CGBGMGFBCKF<HGFEOPBBPIG>? EGGCNCGGPCM
		{
			[Cpp2IlInjected.Token(Token = "0x6000364")]
			[Cpp2IlInjected.Address(RVA = "0x8677A0", Offset = "0x865DA0", VA = "0x1808677A0", Slot = "119")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000077")]
		public virtual bool DKPCAJPJEOH
		{
			[Cpp2IlInjected.Token(Token = "0x6000377")]
			[Cpp2IlInjected.Address(RVA = "0x8AF060", Offset = "0x8AD660", VA = "0x1808AF060", Slot = "122")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000078")]
		public virtual bool OOODBLNAFBF
		{
			[Cpp2IlInjected.Token(Token = "0x6000378")]
			[Cpp2IlInjected.Address(RVA = "0x881710", Offset = "0x87FD10", VA = "0x180881710", Slot = "123")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action LMKKHKCLPCC
		{
			[Cpp2IlInjected.Token(Token = "0x6000339")]
			[Cpp2IlInjected.Address(RVA = "0x58AE570", Offset = "0x58ACB70", VA = "0x1858AE570", Slot = "37")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600033A")]
			[Cpp2IlInjected.Address(RVA = "0x58B1040", Offset = "0x58AF640", VA = "0x1858B1040", Slot = "38")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event AHHIACMADKG IDECNOPANHC
		{
			[Cpp2IlInjected.Token(Token = "0x600033C")]
			[Cpp2IlInjected.Address(RVA = "0x58B1840", Offset = "0x58AFE40", VA = "0x1858B1840", Slot = "39")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600033D")]
			[Cpp2IlInjected.Address(RVA = "0x58AE8D0", Offset = "0x58ACED0", VA = "0x1858AE8D0", Slot = "40")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		public event GDJKDJLIJOO NLLFDIDLHKP
		{
			[Cpp2IlInjected.Token(Token = "0x600033E")]
			[Cpp2IlInjected.Address(RVA = "0x58AFC00", Offset = "0x58AE200", VA = "0x1858AFC00", Slot = "41")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600033F")]
			[Cpp2IlInjected.Address(RVA = "0x58AE610", Offset = "0x58ACC10", VA = "0x1858AE610", Slot = "42")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000004")]
		public event Action CEHIEGKIECK
		{
			[Cpp2IlInjected.Token(Token = "0x6000340")]
			[Cpp2IlInjected.Address(RVA = "0x58AE450", Offset = "0x58ACA50", VA = "0x1858AE450", Slot = "43")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000341")]
			[Cpp2IlInjected.Address(RVA = "0x58B1A80", Offset = "0x58B0080", VA = "0x1858B1A80", Slot = "44")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000005")]
		public event Action CLMANBJLFGE
		{
			[Cpp2IlInjected.Token(Token = "0x6000342")]
			[Cpp2IlInjected.Address(RVA = "0x58AE070", Offset = "0x58AC670", VA = "0x1858AE070", Slot = "45")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000343")]
			[Cpp2IlInjected.Address(RVA = "0x58B0FA0", Offset = "0x58AF5A0", VA = "0x1858B0FA0", Slot = "46")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000006")]
		public event Action<CGBGMGFBCKF<HGFEOPBBPIG>, PDDIJOAHCGO> KEJGNGOMDKO
		{
			[Cpp2IlInjected.Token(Token = "0x6000365")]
			[Cpp2IlInjected.Address(RVA = "0x58B0EE0", Offset = "0x58AF4E0", VA = "0x1858B0EE0", Slot = "67")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000366")]
			[Cpp2IlInjected.Address(RVA = "0x58B1710", Offset = "0x58AFD10", VA = "0x1858B1710", Slot = "68")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000007")]
		public event Action<CGBGMGFBCKF<HGFEOPBBPIG>, PDDIJOAHCGO> JPFJKKPHNLF
		{
			[Cpp2IlInjected.Token(Token = "0x6000367")]
			[Cpp2IlInjected.Address(RVA = "0x58AE810", Offset = "0x58ACE10", VA = "0x1858AE810", Slot = "71")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000368")]
			[Cpp2IlInjected.Address(RVA = "0x58AE970", Offset = "0x58ACF70", VA = "0x1858AE970", Slot = "72")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000008")]
		public event Action<CGBGMGFBCKF<HGFEOPBBPIG>> JILEEEDLGND
		{
			[Cpp2IlInjected.Token(Token = "0x6000369")]
			[Cpp2IlInjected.Address(RVA = "0x58B10E0", Offset = "0x58AF6E0", VA = "0x1858B10E0", Slot = "69")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600036A")]
			[Cpp2IlInjected.Address(RVA = "0x58B19C0", Offset = "0x58AFFC0", VA = "0x1858B19C0", Slot = "70")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000009")]
		public event Action<CGBGMGFBCKF<HGFEOPBBPIG>, CGBGMGFBCKF<HGFEOPBBPIG>> HJKHKDHDNFA
		{
			[Cpp2IlInjected.Token(Token = "0x600036B")]
			[Cpp2IlInjected.Address(RVA = "0x58B0C40", Offset = "0x58AF240", VA = "0x1858B0C40", Slot = "73")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600036C")]
			[Cpp2IlInjected.Address(RVA = "0x58AE180", Offset = "0x58AC780", VA = "0x1858AE180", Slot = "74")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000A")]
		public event Action<CGBGMGFBCKF<HGFEOPBBPIG>, PDDIJOAHCGO> KMODNPHIGIK
		{
			[Cpp2IlInjected.Token(Token = "0x600036D")]
			[Cpp2IlInjected.Address(RVA = "0x58B1F80", Offset = "0x58B0580", VA = "0x1858B1F80", Slot = "75")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600036E")]
			[Cpp2IlInjected.Address(RVA = "0x58B0D00", Offset = "0x58AF300", VA = "0x1858B0D00", Slot = "76")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000B")]
		public event Action<CGBGMGFBCKF<HGFEOPBBPIG>, CGBGMGFBCKF<HGFEOPBBPIG>> BJEOBNAKEFH
		{
			[Cpp2IlInjected.Token(Token = "0x600036F")]
			[Cpp2IlInjected.Address(RVA = "0x58AE4B0", Offset = "0x58ACAB0", VA = "0x1858AE4B0", Slot = "77")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000370")]
			[Cpp2IlInjected.Address(RVA = "0x58B1650", Offset = "0x58AFC50", VA = "0x1858B1650", Slot = "78")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000311")]
		[Cpp2IlInjected.Address(RVA = "0x58B2CD0", Offset = "0x58B12D0", VA = "0x1858B2CD0")]
		[DFMFJMBJIGJ("Creating the port adapter needs to actually read the `canInteract` state rather than just passing in `true`.")]
		[DFMFJMBJIGJ("Need to handle `Name` better.")]
		protected DCANGPMKHHL(PJNMBNAHIFL ALELNINOAGK, TNode EMDFCFPCFGG, bool JGBMGBJLMOK = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000312")]
		[Cpp2IlInjected.Address(RVA = "0x58B2560", Offset = "0x58B0B60", VA = "0x1858B2560", Slot = "87")]
		protected virtual void PNLKNBIHCGI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000313")]
		[Cpp2IlInjected.Address(RVA = "0x58AF290", Offset = "0x58AD890", VA = "0x1858AF290", Slot = "88")]
		public virtual void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600031A")]
		[Cpp2IlInjected.Address(RVA = "0x58B03A0", Offset = "0x58AE9A0", VA = "0x1858B03A0", Slot = "9")]
		[AsyncStateMachine(typeof(DCANGPMKHHL<>.LFIPMNAABNP))]
		public void HEAEENOPBFC(int ENCGGFFGNMO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000331")]
		[Cpp2IlInjected.Address(RVA = "0x58AE110", Offset = "0x58AC710", VA = "0x1858AE110")]
		public bool AEJCIOEKOAH([In] DHNIBFCDNLJ DMNGPNKHPKF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000333")]
		[Cpp2IlInjected.Address(RVA = "0x58B17D0", Offset = "0x58AFDD0", VA = "0x1858B17D0")]
		public bool LEBFIMGCNJA([In] PBDCHDIIPAE DMNGPNKHPKF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000334")]
		[Cpp2IlInjected.Address(RVA = "0x58AE240", Offset = "0x58AC840", VA = "0x1858AE240", Slot = "32")]
		public void AMGJLBFFDFA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000335")]
		[Cpp2IlInjected.Address(RVA = "0x58AF140", Offset = "0x58AD740", VA = "0x1858AF140", Slot = "33")]
		[AsyncStateMachine(typeof(DCANGPMKHHL<>.IDHKAOMAFLG))]
		public Task<CBDPDIPONCF<COKMANPFJNC, FBDDJIHDMAI>> DECHGHGNMMC(DHNIBFCDNLJ? DJCNMBEIKME, PBDCHDIIPAE? CAANIPGJBEP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000336")]
		[Cpp2IlInjected.Address(RVA = "0x867790", Offset = "0x865D90", VA = "0x180867790", Slot = "97")]
		public virtual void LGNGCKLCNNO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000337")]
		[Cpp2IlInjected.Address(RVA = "0x867790", Offset = "0x865D90", VA = "0x180867790", Slot = "98")]
		public virtual void DDGFFLKOFKN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000338")]
		[Cpp2IlInjected.Address(RVA = "0x867790", Offset = "0x865D90", VA = "0x180867790", Slot = "99")]
		public virtual void IAJHLANOIAJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600033B")]
		[Cpp2IlInjected.Address(RVA = "0x1D99FC0", Offset = "0x1D985C0", VA = "0x181D99FC0")]
		protected void FFJBJMLHLBC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000344")]
		[Cpp2IlInjected.Address(RVA = "0x49FD4F0", Offset = "0x49FBAF0", VA = "0x1849FD4F0")]
		protected void GHFHBMNOLCM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000345")]
		[Cpp2IlInjected.Address(RVA = "0x21D2930", Offset = "0x21D0F30", VA = "0x1821D2930")]
		private void CPMNEOJNJON([In] PBDCHDIIPAE GLKHDAMNPBA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000346")]
		[Cpp2IlInjected.Address(RVA = "0x58B2450", Offset = "0x58B0A50", VA = "0x1858B2450", Slot = "100")]
		public virtual Task<CBDPDIPONCF<CGBGMGFBCKF<HGFEOPBBPIG>, FBDDJIHDMAI>> OMABNNMENMJ(string GJEDHMJMNJA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000347")]
		[Cpp2IlInjected.Address(RVA = "0x58AFD00", Offset = "0x58AE300", VA = "0x1858AFD00", Slot = "101")]
		public virtual Task<CBDPDIPONCF<COKMANPFJNC, FBDDJIHDMAI>> GHBJPLCMBLJ(CGBGMGFBCKF<HGFEOPBBPIG> GKEOEKGAILK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000348")]
		[Cpp2IlInjected.Address(RVA = "0x867790", Offset = "0x865D90", VA = "0x180867790", Slot = "102")]
		public virtual void AECGFIDLIOF(CGBGMGFBCKF<HGFEOPBBPIG> AIFJGOKDOII, CGBGMGFBCKF<HGFEOPBBPIG> DPOPPJJGJJF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000349")]
		[Cpp2IlInjected.Address(RVA = "0x58AFB70", Offset = "0x58AE170", VA = "0x1858AFB70", Slot = "103")]
		public virtual IEnumerable<EIJGBFLAMII> EGNMLFCDJNN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600034A")]
		[Cpp2IlInjected.Address(RVA = "0x58B18E0", Offset = "0x58AFEE0", VA = "0x1858B18E0", Slot = "104")]
		public CBDPDIPONCF<COKMANPFJNC, FBDDJIHDMAI> LLGBDALCILB(string BEEOOAHHFHA)
		{
			return default(CBDPDIPONCF<COKMANPFJNC, FBDDJIHDMAI>);
		}

		[Cpp2IlInjected.Token(Token = "0x600034B")]
		[Cpp2IlInjected.Address(RVA = "0x58B1E20", Offset = "0x58B0420", VA = "0x1858B1E20", Slot = "47")]
		public bool OFFHNIDIMGN([Out] Guid JOOKFOILIMG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600034C")]
		[Cpp2IlInjected.Address(RVA = "0x58B1B20", Offset = "0x58B0120", VA = "0x1858B1B20")]
		public bool ODJDAGMCCBL([In] Guid EHLNCLBLNMA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600034D")]
		[Cpp2IlInjected.Address(RVA = "0x867790", Offset = "0x865D90", VA = "0x180867790", Slot = "105")]
		public virtual void LJOBMJGJKLI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600034E")]
		[Cpp2IlInjected.Address(RVA = "0x867790", Offset = "0x865D90", VA = "0x180867790", Slot = "106")]
		public virtual void PHAHLJCOMKJ(bool IOEHFMNGHFA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600034F")]
		[Cpp2IlInjected.Address(RVA = "0x8677A0", Offset = "0x865DA0", VA = "0x1808677A0", Slot = "107")]
		public virtual JHHBDPGEKPB FAMDLMOEMPJ([In] LNCLGCFLBOD KHFBDFAIFIJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000354")]
		[Cpp2IlInjected.Address(RVA = "0x58B04C0", Offset = "0x58AEAC0", VA = "0x1858B04C0")]
		protected void HHDEOHPHOLG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000355")]
		[Cpp2IlInjected.Address(RVA = "0x58B1DE0", Offset = "0x58B03E0", VA = "0x1858B1DE0", Slot = "112")]
		protected virtual bool ODKENONLAJO(CGBGMGFBCKF<HGFEOPBBPIG> GKEOEKGAILK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000356")]
		[Cpp2IlInjected.Address(RVA = "0x8AF060", Offset = "0x8AD660", VA = "0x1808AF060", Slot = "113")]
		protected virtual bool IDKIGCHOMFB(CGBGMGFBCKF<HGFEOPBBPIG> GKEOEKGAILK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000371")]
		[Cpp2IlInjected.Address(RVA = "0x867790", Offset = "0x865D90", VA = "0x180867790", Slot = "120")]
		protected virtual void AANCPJNHLHN(GDJFKKGDGFJ JNMOBHDDOBG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000372")]
		[Cpp2IlInjected.Address(RVA = "0x58AECC0", Offset = "0x58AD2C0", VA = "0x1858AECC0")]
		protected void CPMPIFJINBK(GDJFKKGDGFJ KMONEIKIHIC, Func<string> MIMKHHKMHJK, Action<string> OFAAEAAHLIN, string OHAJDBEKPIG, string FPDDBFKIJKC, string BNMBKHKDJKJ, BHHIBOIMCNB KCLCIOCKMCF, BLJOKFHDJLK PKFCGNDFEJB, Func<string, bool> MNENNADLLDH, string MNFLJPEDOFO, Func<string, bool> PGJHOFEDNDC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000373")]
		[Cpp2IlInjected.Address(RVA = "0x58AFDD0", Offset = "0x58AE3D0", VA = "0x1858AFDD0")]
		protected void GJKKJELIHMB(GDJFKKGDGFJ KMONEIKIHIC, Func<string> MIMKHHKMHJK, Action<string> OFAAEAAHLIN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000374")]
		[Cpp2IlInjected.Address(RVA = "0x58B00D0", Offset = "0x58AE6D0", VA = "0x1858B00D0", Slot = "121")]
		protected virtual void GNGKCJOCHAB(GDJFKKGDGFJ KMONEIKIHIC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000375")]
		[Cpp2IlInjected.Address(RVA = "0x58B1970", Offset = "0x58AFF70", VA = "0x1858B1970", Slot = "80")]
		public void MBEDFBOJBDH(GDJFKKGDGFJ KMONEIKIHIC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000376")]
		[Cpp2IlInjected.Address(RVA = "0x58B11A0", Offset = "0x58AF7A0", VA = "0x1858B11A0", Slot = "81")]
		public KAFMIGBJCLH KGKPHGJNKLF()
		{
			return default(KAFMIGBJCLH);
		}

		[Cpp2IlInjected.Token(Token = "0x6000379")]
		[Cpp2IlInjected.Address(RVA = "0x8AF060", Offset = "0x8AD660", VA = "0x1808AF060", Slot = "124")]
		public virtual bool JCHBGBLIJGB(CGBGMGFBCKF<HGFEOPBBPIG> GKEOEKGAILK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600037A")]
		[Cpp2IlInjected.Address(RVA = "0x140CA50", Offset = "0x140B050", VA = "0x18140CA50")]
		private void JHLEGPHCGAO([In] DHNIBFCDNLJ MCPNOOFMAHG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037B")]
		[Cpp2IlInjected.Address(RVA = "0x58AE6B0", Offset = "0x58ACCB0", VA = "0x1858AE6B0")]
		private void BLNDBIPEGKG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037C")]
		[Cpp2IlInjected.Address(RVA = "0x58B0700", Offset = "0x58AED00", VA = "0x1858B0700")]
		private void IACOKKGAIHJ(CGBGMGFBCKF<HGFEOPBBPIG> GKEOEKGAILK, DFIHDLEBDJG DJAFENBDNED)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037D")]
		[Cpp2IlInjected.Address(RVA = "0x8DC0D0", Offset = "0x8DA6D0", VA = "0x1808DC0D0")]
		private void ICPGMHHGFDL(CGBGMGFBCKF<HGFEOPBBPIG> DAIJJLLIENA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037E")]
		[Cpp2IlInjected.Address(RVA = "0x58AEA30", Offset = "0x58AD030", VA = "0x1858AEA30")]
		private void CFBMGKJACGB(CGBGMGFBCKF<HGFEOPBBPIG> DAIJJLLIENA, DFIHDLEBDJG KFHKAEFLENM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037F")]
		[Cpp2IlInjected.Address(RVA = "0x58B12A0", Offset = "0x58AF8A0", VA = "0x1858B12A0")]
		private void KHAAHLJDLGO(CGBGMGFBCKF<HGFEOPBBPIG> AIFJGOKDOII, CGBGMGFBCKF<HGFEOPBBPIG> DPOPPJJGJJF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000380")]
		[Cpp2IlInjected.Address(RVA = "0x8DC050", Offset = "0x8DA650", VA = "0x1808DC050")]
		private void PGBEOGFFEIN(CGBGMGFBCKF<HGFEOPBBPIG> AIFJGOKDOII, CGBGMGFBCKF<HGFEOPBBPIG> DPOPPJJGJJF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000381")]
		[Cpp2IlInjected.Address(RVA = "0x4F3E3E0", Offset = "0x4F3C9E0", VA = "0x184F3E3E0")]
		private void BOAKJPPKAOG(CGBGMGFBCKF<HGFEOPBBPIG> GKEOEKGAILK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000382")]
		[Cpp2IlInjected.Address(RVA = "0x58B2040", Offset = "0x58B0640", VA = "0x1858B2040")]
		private void OKJKBKNNGAA(CGBGMGFBCKF<HGFEOPBBPIG> GKEOEKGAILK, DFIHDLEBDJG DJAFENBDNED)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000383")]
		[Cpp2IlInjected.Address(RVA = "0x58AEB60", Offset = "0x58AD160", VA = "0x1858AEB60")]
		private void CIPHOMKHPAN(CGBGMGFBCKF<HGFEOPBBPIG> GKEOEKGAILK, DFIHDLEBDJG KFHKAEFLENM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000384")]
		[Cpp2IlInjected.Address(RVA = "0x58B0DC0", Offset = "0x58AF3C0", VA = "0x1858B0DC0", Slot = "125")]
		[AsyncStateMachine(typeof(DCANGPMKHHL<>.IELHNGIMPLK))]
		public Task<CBDPDIPONCF<COKMANPFJNC, FBDDJIHDMAI>> IGOMGAKFBJC(string BEEOOAHHFHA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000385")]
		[Cpp2IlInjected.Address(RVA = "0x58AF0D0", Offset = "0x58AD6D0", VA = "0x1858AF0D0", Slot = "54")]
		private void DDJKLDPOJEG(object HPENBFHBMFE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000386")]
		[Cpp2IlInjected.Address(RVA = "0x58B0450", Offset = "0x58AEA50", VA = "0x1858B0450", Slot = "55")]
		private void HHADHKPHDFF(object HPENBFHBMFE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000387")]
		[Cpp2IlInjected.Address(RVA = "0x58B1AE0", Offset = "0x58B00E0", VA = "0x1858B1AE0", Slot = "29")]
		private bool NOIFPFMMFBP([In] DHNIBFCDNLJ DMNGPNKHPKF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000388")]
		[Cpp2IlInjected.Address(RVA = "0x58B2520", Offset = "0x58B0B20", VA = "0x1858B2520", Slot = "31")]
		private bool OMMOAPEDEPN([In] PBDCHDIIPAE DMNGPNKHPKF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000389")]
		[Cpp2IlInjected.Address(RVA = "0x58B06C0", Offset = "0x58AECC0", VA = "0x1858B06C0", Slot = "48")]
		private bool HHEKMAJJLKH([In] Guid EHLNCLBLNMA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600038A")]
		[Cpp2IlInjected.Address(RVA = "0x4D5C9D0", Offset = "0x4D5AFD0", VA = "0x184D5C9D0")]
		[CompilerGenerated]
		private string KBFODBGJALA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600038B")]
		[Cpp2IlInjected.Address(RVA = "0x58B02F0", Offset = "0x58AE8F0", VA = "0x1858B02F0")]
		[CompilerGenerated]
		private void HCDKJLGGOEL(string GJEDHMJMNJA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000091")]
	public sealed class GDFPEAKGLIB : BDHLCPDJKEP<KAHHKKCOEBK>
	{
		[Cpp2IlInjected.Token(Token = "0x17000079")]
		public override NodeVisualizationKey EHBGNDCNEJA
		{
			[Cpp2IlInjected.Token(Token = "0x600039D")]
			[Cpp2IlInjected.Address(RVA = "0xCD39B0", Offset = "0xCD1FB0", VA = "0x180CD39B0", Slot = "91")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600039E")]
		[Cpp2IlInjected.Address(RVA = "0x1FCCFA0", Offset = "0x1FCB5A0", VA = "0x181FCCFA0")]
		public GDFPEAKGLIB(PJNMBNAHIFL ALELNINOAGK, KAHHKKCOEBK EMDFCFPCFGG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000092")]
	private sealed class NPGDEEBECCK : FLCNKOKNGMP<BFCFHPGCPEH>
	{
		[Cpp2IlInjected.Token(Token = "0x1700007A")]
		public override NodeVisualizationKey EHBGNDCNEJA
		{
			[Cpp2IlInjected.Token(Token = "0x600039F")]
			[Cpp2IlInjected.Address(RVA = "0x8F3C30", Offset = "0x8F2230", VA = "0x1808F3C30", Slot = "91")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003A0")]
		[Cpp2IlInjected.Address(RVA = "0x1FDCB60", Offset = "0x1FDB160", VA = "0x181FDCB60")]
		public NPGDEEBECCK(PJNMBNAHIFL ALELNINOAGK, BFCFHPGCPEH EMDFCFPCFGG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A1")]
		[Cpp2IlInjected.Address(RVA = "0x867790", Offset = "0x865D90", VA = "0x180867790", Slot = "120")]
		protected override void AANCPJNHLHN(GDJFKKGDGFJ KMONEIKIHIC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000093")]
	public abstract class ONPIPBFAAKM<T> : DCANGPMKHHL<T> where T : notnull, ICMFOJGJLPG
	{
		[Cpp2IlInjected.Token(Token = "0x2000094")]
		[CompilerGenerated]
		private sealed class KMODAFGEEDM
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001D2")]
			public IReadOnlyList<KeyValuePair<string, OJKMPFKGAPM>> clipOptions;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001D3")]
			public ONPIPBFAAKM<T> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001D4")]
			public IReadOnlyDictionary<Guid, int> clipGuidToIndex;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001D5")]
			public IReadOnlyDictionary<int, Guid> clipIndexToGuid;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001D6")]
			public BKKHOHENKFL nodeAdapterDeps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001D7")]
			public BDJFDBHNNED clipType;

			[Cpp2IlInjected.Token(Token = "0x60003A6")]
			[Cpp2IlInjected.Address(RVA = "0x86C4B0", Offset = "0x86AAB0", VA = "0x18086C4B0")]
			public KMODAFGEEDM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003A7")]
			[Cpp2IlInjected.Address(RVA = "0x868220", Offset = "0x866820", VA = "0x180868220")]
			internal IReadOnlyList<KeyValuePair<string, OJKMPFKGAPM>> MGLFNJMCMEN()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60003A8")]
			[Cpp2IlInjected.Address(RVA = "0x41C7240", Offset = "0x41C5840", VA = "0x1841C7240")]
			internal int KGEOJKOADPA()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60003A9")]
			[Cpp2IlInjected.Address(RVA = "0x41C6F30", Offset = "0x41C5530", VA = "0x1841C6F30")]
			internal void GLPPOLAGMCH(int clipIndex)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003AA")]
			[Cpp2IlInjected.Address(RVA = "0x41C74B0", Offset = "0x41C5AB0", VA = "0x1841C74B0")]
			internal void PDHBGEGHGHC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003AB")]
			[Cpp2IlInjected.Address(RVA = "0x41C6C00", Offset = "0x41C5200", VA = "0x1841C6C00")]
			internal void AAMBPKPGDKI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003AC")]
			[Cpp2IlInjected.Address(RVA = "0x41C71B0", Offset = "0x41C57B0", VA = "0x1841C71B0")]
			internal bool NJBIAFHPNMH()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60003AD")]
			[Cpp2IlInjected.Address(RVA = "0x41C7460", Offset = "0x41C5A60", VA = "0x1841C7460")]
			internal void LEKNKPMGLOF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003AE")]
			[Cpp2IlInjected.Address(RVA = "0x41C71B0", Offset = "0x41C57B0", VA = "0x1841C71B0")]
			internal bool KANOGPFMDHK()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60003AF")]
			[Cpp2IlInjected.Address(RVA = "0x41C7500", Offset = "0x41C5B00", VA = "0x1841C7500")]
			internal float PJINBHMPEAG()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x60003B0")]
			[Cpp2IlInjected.Address(RVA = "0x41C73A0", Offset = "0x41C59A0", VA = "0x1841C73A0")]
			internal void KLLKKHMCDPD(float value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003B1")]
			[Cpp2IlInjected.Address(RVA = "0x41C7150", Offset = "0x41C5750", VA = "0x1841C7150")]
			internal float HPHIAECADLD()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x60003B2")]
			[Cpp2IlInjected.Address(RVA = "0x41C6E70", Offset = "0x41C5470", VA = "0x1841C6E70")]
			internal void CGNAFIIFHFC(float value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003B3")]
			[Cpp2IlInjected.Address(RVA = "0x41C6E10", Offset = "0x41C5410", VA = "0x1841C6E10")]
			internal float BNIJAPHJHMC()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x60003B4")]
			[Cpp2IlInjected.Address(RVA = "0x41C6D50", Offset = "0x41C5350", VA = "0x1841C6D50")]
			internal void ANPBCEJMOLF(float value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007B")]
		public override NodeVisualizationKey EHBGNDCNEJA
		{
			[Cpp2IlInjected.Token(Token = "0x60003A3")]
			[Cpp2IlInjected.Address(RVA = "0x8EF840", Offset = "0x8EDE40", VA = "0x1808EF840", Slot = "91")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007C")]
		public abstract BDJFDBHNNED MFPOPCILKGP
		{
			[Cpp2IlInjected.Token(Token = "0x60003A4")]
			[Cpp2IlInjected.Address(Slot = "126")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x60003A2")]
		[Cpp2IlInjected.Address(RVA = "0x46F9DF0", Offset = "0x46F83F0", VA = "0x1846F9DF0")]
		public ONPIPBFAAKM(PJNMBNAHIFL ALELNINOAGK, T EMDFCFPCFGG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A5")]
		[Cpp2IlInjected.Address(RVA = "0x46F92D0", Offset = "0x46F78D0", VA = "0x1846F92D0", Slot = "120")]
		protected sealed override void AANCPJNHLHN(GDJFKKGDGFJ KMONEIKIHIC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000095")]
	private sealed class MGNEOEMADMM : DCANGPMKHHL<KFBKCMOOMOK>
	{
		[Cpp2IlInjected.Token(Token = "0x1700007D")]
		public override NodeVisualizationKey EHBGNDCNEJA
		{
			[Cpp2IlInjected.Token(Token = "0x60003B5")]
			[Cpp2IlInjected.Address(RVA = "0x953440", Offset = "0x951A40", VA = "0x180953440", Slot = "91")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003B6")]
		[Cpp2IlInjected.Address(RVA = "0x1FD50A0", Offset = "0x1FD36A0", VA = "0x181FD50A0")]
		public MGNEOEMADMM(PJNMBNAHIFL ALELNINOAGK, KFBKCMOOMOK EMDFCFPCFGG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000096")]
	public sealed class DBNOFJONCBG : DCANGPMKHHL<JGDJPADOJIJ>
	{
		[Cpp2IlInjected.Token(Token = "0x2000097")]
		[CompilerGenerated]
		private sealed class OOKFHKCLJCG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40001D9")]
			public DBNOFJONCBG <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40001DA")]
			public BKKHOHENKFL nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x60003B9")]
			[Cpp2IlInjected.Address(RVA = "0x86C4B0", Offset = "0x86AAB0", VA = "0x18086C4B0")]
			public OOKFHKCLJCG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003BA")]
			[Cpp2IlInjected.Address(RVA = "0x1FDE170", Offset = "0x1FDC770", VA = "0x181FDE170")]
			internal int KGEOJKOADPA()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60003BB")]
			[Cpp2IlInjected.Address(RVA = "0x1FDE0E0", Offset = "0x1FDC6E0", VA = "0x181FDE0E0")]
			internal void GLPPOLAGMCH(int value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40001D8")]
		private static Dictionary<string, OJKMPFKGAPM>? GLNPIMHCLED;

		[Cpp2IlInjected.Token(Token = "0x60003B7")]
		[Cpp2IlInjected.Address(RVA = "0x1FC8800", Offset = "0x1FC6E00", VA = "0x181FC8800")]
		public DBNOFJONCBG(PJNMBNAHIFL ALELNINOAGK, JGDJPADOJIJ EMDFCFPCFGG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B8")]
		[Cpp2IlInjected.Address(RVA = "0x1FC8480", Offset = "0x1FC6A80", VA = "0x181FC8480", Slot = "120")]
		protected override void AANCPJNHLHN(GDJFKKGDGFJ KMONEIKIHIC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000099")]
	public sealed class HINMEPEGJEM : ONPIPBFAAKM<IABCLGGAJCB>
	{
		[Cpp2IlInjected.Token(Token = "0x1700007E")]
		public override BDJFDBHNNED MFPOPCILKGP
		{
			[Cpp2IlInjected.Token(Token = "0x60003C0")]
			[Cpp2IlInjected.Address(RVA = "0x8677A0", Offset = "0x865DA0", VA = "0x1808677A0", Slot = "126")]
			get
			{
				return default(BDJFDBHNNED);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003BF")]
		[Cpp2IlInjected.Address(RVA = "0x1FCE1D0", Offset = "0x1FCC7D0", VA = "0x181FCE1D0")]
		public HINMEPEGJEM(PJNMBNAHIFL ALELNINOAGK, IABCLGGAJCB AKLCDEBLEOF)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200009A")]
	private sealed class POFJJDGKFIG : FLCNKOKNGMP<LHLKCKAONJE>
	{
		[Cpp2IlInjected.Token(Token = "0x1700007F")]
		public override NodeVisualizationKey EHBGNDCNEJA
		{
			[Cpp2IlInjected.Token(Token = "0x60003C1")]
			[Cpp2IlInjected.Address(RVA = "0x8F3C30", Offset = "0x8F2230", VA = "0x1808F3C30", Slot = "91")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003C2")]
		[Cpp2IlInjected.Address(RVA = "0x1FE10A0", Offset = "0x1FDF6A0", VA = "0x181FE10A0")]
		public POFJJDGKFIG(PJNMBNAHIFL ALELNINOAGK, LHLKCKAONJE EMDFCFPCFGG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C3")]
		[Cpp2IlInjected.Address(RVA = "0x867790", Offset = "0x865D90", VA = "0x180867790", Slot = "120")]
		protected override void AANCPJNHLHN(GDJFKKGDGFJ KMONEIKIHIC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200009B")]
	private sealed class OOCEDLGIILO : FLCNKOKNGMP<ALDHIKLENEL>
	{
		[Cpp2IlInjected.Token(Token = "0x17000080")]
		public override NodeVisualizationKey EHBGNDCNEJA
		{
			[Cpp2IlInjected.Token(Token = "0x60003C4")]
			[Cpp2IlInjected.Address(RVA = "0x8F3C30", Offset = "0x8F2230", VA = "0x1808F3C30", Slot = "91")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003C5")]
		[Cpp2IlInjected.Address(RVA = "0x1FDDFA0", Offset = "0x1FDC5A0", VA = "0x181FDDFA0")]
		public OOCEDLGIILO(PJNMBNAHIFL ALELNINOAGK, ALDHIKLENEL EMDFCFPCFGG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C6")]
		[Cpp2IlInjected.Address(RVA = "0x867790", Offset = "0x865D90", VA = "0x180867790", Slot = "120")]
		protected override void AANCPJNHLHN(GDJFKKGDGFJ KMONEIKIHIC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200009C")]
	public sealed class NDDNGKPJDDP : PDOMBIKABAA<DINCBCKCILA>
	{
		[Cpp2IlInjected.Token(Token = "0x200009D")]
		[CompilerGenerated]
		private sealed class FJCKHANCABD
		{
			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x200009E")]
			private struct <<AddHomeValueSetting>b__0>d : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001DF")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x40001E0")]
				public AsyncVoidMethodBuilder <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x40001E1")]
				public FJCKHANCABD <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x40001E2")]
				public string value;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x40001E3")]
				private TaskAwaiter<bool> <>u__1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
				[Cpp2IlInjected.Token(Token = "0x40001E4")]
				private TaskAwaiter<CBDPDIPONCF<COKMANPFJNC, FBDDJIHDMAI>> <>u__2;

				[Cpp2IlInjected.Token(Token = "0x60003CB")]
				[Cpp2IlInjected.Address(RVA = "0x1FE1100", Offset = "0x1FDF700", VA = "0x181FE1100", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60003CC")]
				[Cpp2IlInjected.Address(RVA = "0xA20370", Offset = "0xA1E970", VA = "0x180A20370", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40001DD")]
			public BKKHOHENKFL nodeAdapterDeps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40001DE")]
			public NDDNGKPJDDP <>4__this;

			[Cpp2IlInjected.Token(Token = "0x60003C9")]
			[Cpp2IlInjected.Address(RVA = "0x86C4B0", Offset = "0x86AAB0", VA = "0x18086C4B0")]
			public FJCKHANCABD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003CA")]
			[Cpp2IlInjected.Address(RVA = "0x1FCADF0", Offset = "0x1FC93F0", VA = "0x181FCADF0")]
			[AsyncStateMachine(typeof(<<AddHomeValueSetting>b__0>d))]
			internal void EEPGJPPHOAA(string value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003C7")]
		[Cpp2IlInjected.Address(RVA = "0x1FDC380", Offset = "0x1FDA980", VA = "0x181FDC380")]
		public NDDNGKPJDDP(PJNMBNAHIFL ALELNINOAGK, DINCBCKCILA AKLCDEBLEOF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C8")]
		[Cpp2IlInjected.Address(RVA = "0x1FDC0A0", Offset = "0x1FDA6A0", VA = "0x181FDC0A0", Slot = "126")]
		protected override void NOFDDFDGBMI(GDJFKKGDGFJ KMONEIKIHIC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200009F")]
	public sealed class BEHBGAFLPLA : ONPIPBFAAKM<KACBLEEDGAA>
	{
		[Cpp2IlInjected.Token(Token = "0x17000081")]
		public override BDJFDBHNNED MFPOPCILKGP
		{
			[Cpp2IlInjected.Token(Token = "0x60003CE")]
			[Cpp2IlInjected.Address(RVA = "0x8FC7E0", Offset = "0x8FADE0", VA = "0x1808FC7E0", Slot = "126")]
			get
			{
				return default(BDJFDBHNNED);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003CD")]
		[Cpp2IlInjected.Address(RVA = "0x1FC7540", Offset = "0x1FC5B40", VA = "0x181FC7540")]
		public BEHBGAFLPLA(PJNMBNAHIFL ALELNINOAGK, KACBLEEDGAA AKLCDEBLEOF)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A0")]
	private sealed class LDNMMJCINOB : DCANGPMKHHL<DILGCNCPDPP>
	{
		[Cpp2IlInjected.Token(Token = "0x17000082")]
		public override NodeVisualizationKey EHBGNDCNEJA
		{
			[Cpp2IlInjected.Token(Token = "0x60003CF")]
			[Cpp2IlInjected.Address(RVA = "0x951520", Offset = "0x94FB20", VA = "0x180951520", Slot = "91")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003D0")]
		[Cpp2IlInjected.Address(RVA = "0x1FD4070", Offset = "0x1FD2670", VA = "0x181FD4070")]
		public LDNMMJCINOB(PJNMBNAHIFL ALELNINOAGK, DILGCNCPDPP EMDFCFPCFGG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D1")]
		[Cpp2IlInjected.Address(RVA = "0x867790", Offset = "0x865D90", VA = "0x180867790", Slot = "120")]
		protected override void AANCPJNHLHN(GDJFKKGDGFJ KMONEIKIHIC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A1")]
	public sealed class IBJDJJKIGNH : DCANGPMKHHL<DJCIHPENCIF>
	{
		[Cpp2IlInjected.Token(Token = "0x17000083")]
		public sealed override NodeVisualizationKey EHBGNDCNEJA
		{
			[Cpp2IlInjected.Token(Token = "0x60003D2")]
			[Cpp2IlInjected.Address(RVA = "0x8677A0", Offset = "0x865DA0", VA = "0x1808677A0", Slot = "91")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000084")]
		public sealed override bool JGICPFBHJJF
		{
			[Cpp2IlInjected.Token(Token = "0x60003D3")]
			[Cpp2IlInjected.Address(RVA = "0x881710", Offset = "0x87FD10", VA = "0x180881710", Slot = "92")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000085")]
		protected sealed override bool MGJFPKPAAAN
		{
			[Cpp2IlInjected.Token(Token = "0x60003D4")]
			[Cpp2IlInjected.Address(RVA = "0x881710", Offset = "0x87FD10", VA = "0x180881710", Slot = "90")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003D5")]
		[Cpp2IlInjected.Address(RVA = "0x1FCE600", Offset = "0x1FCCC00", VA = "0x181FCE600")]
		public IBJDJJKIGNH(PJNMBNAHIFL ALELNINOAGK, DJCIHPENCIF EMDFCFPCFGG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D6")]
		[Cpp2IlInjected.Address(RVA = "0x1FCE230", Offset = "0x1FCC830", VA = "0x181FCE230", Slot = "120")]
		protected override void AANCPJNHLHN(GDJFKKGDGFJ KMONEIKIHIC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D7")]
		[Cpp2IlInjected.Address(RVA = "0x1FCE5C0", Offset = "0x1FCCBC0", VA = "0x181FCE5C0")]
		private int PHCOPAOGGBH()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60003D8")]
		[Cpp2IlInjected.Address(RVA = "0x1FCE560", Offset = "0x1FCCB60", VA = "0x181FCE560")]
		private void DGGEFLNAHCI(int ANPOJJGGDDM)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A2")]
	public class EIGJCLGOCEC : FBMCAPJFHHI
	{
		[Cpp2IlInjected.Token(Token = "0x60003D9")]
		[Cpp2IlInjected.Address(RVA = "0x1FCA0C0", Offset = "0x1FC86C0", VA = "0x181FCA0C0")]
		public EIGJCLGOCEC(PJNMBNAHIFL ALELNINOAGK, JJAEOPCJMCB EMDFCFPCFGG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003DA")]
		[Cpp2IlInjected.Address(RVA = "0x867790", Offset = "0x865D90", VA = "0x180867790", Slot = "120")]
		protected override void AANCPJNHLHN(GDJFKKGDGFJ KMONEIKIHIC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A3")]
	public sealed class HHHGFIHAEIA : PDOMBIKABAA<KLDNDACODFL>
	{
		[Cpp2IlInjected.Token(Token = "0x60003DB")]
		[Cpp2IlInjected.Address(RVA = "0x1FCE170", Offset = "0x1FCC770", VA = "0x181FCE170")]
		public HHHGFIHAEIA(PJNMBNAHIFL ALELNINOAGK, KLDNDACODFL EMDFCFPCFGG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A4")]
	public abstract class PDOMBIKABAA<TVariableNode> : DCANGPMKHHL<TVariableNode> where TVariableNode : notnull, KLDNDACODFL
	{
		[Cpp2IlInjected.Token(Token = "0x20000A5")]
		[CompilerGenerated]
		private sealed class OFAGMPLFMIP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001E5")]
			public PDOMBIKABAA<TVariableNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001E6")]
			public BKKHOHENKFL nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x60003E3")]
			[Cpp2IlInjected.Address(RVA = "0x86C4B0", Offset = "0x86AAB0", VA = "0x18086C4B0")]
			public OFAGMPLFMIP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003E4")]
			[Cpp2IlInjected.Address(RVA = "0x46CE7B0", Offset = "0x46CCDB0", VA = "0x1846CE7B0")]
			internal bool MGLFNJMCMEN()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60003E5")]
			[Cpp2IlInjected.Address(RVA = "0x46CE6F0", Offset = "0x46CCCF0", VA = "0x1846CE6F0")]
			internal void KGEOJKOADPA(bool v)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003E6")]
			[Cpp2IlInjected.Address(RVA = "0x46CE690", Offset = "0x46CCC90", VA = "0x1846CE690")]
			internal bool GLPPOLAGMCH()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60003E7")]
			[Cpp2IlInjected.Address(RVA = "0x46CE810", Offset = "0x46CCE10", VA = "0x1846CE810")]
			internal void PDHBGEGHGHC(bool v)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003E8")]
			[Cpp2IlInjected.Address(RVA = "0x46CE5E0", Offset = "0x46CCBE0", VA = "0x1846CE5E0")]
			internal bool AAMBPKPGDKI()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000A6")]
		[CompilerGenerated]
		private sealed class AEJGOHEJJDB
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001E7")]
			public BKKHOHENKFL nodeAdapterDeps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001E8")]
			public PDOMBIKABAA<TVariableNode> <>4__this;

			[Cpp2IlInjected.Token(Token = "0x60003E9")]
			[Cpp2IlInjected.Address(RVA = "0x86C4B0", Offset = "0x86AAB0", VA = "0x18086C4B0")]
			public AEJGOHEJJDB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003EA")]
			[Cpp2IlInjected.Address(RVA = "0x3CAEE00", Offset = "0x3CAD400", VA = "0x183CAEE00")]
			internal void EEPGJPPHOAA(string v)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000086")]
		public override NodeVisualizationKey EHBGNDCNEJA
		{
			[Cpp2IlInjected.Token(Token = "0x60003DC")]
			[Cpp2IlInjected.Address(RVA = "0xAC7EA0", Offset = "0xAC64A0", VA = "0x180AC7EA0", Slot = "91")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000087")]
		public override MBKFEDOAILK JOIPAAJINPE
		{
			[Cpp2IlInjected.Token(Token = "0x60003DD")]
			[Cpp2IlInjected.Address(RVA = "0x47ABAA0", Offset = "0x47AA0A0", VA = "0x1847ABAA0", Slot = "94")]
			get
			{
				return default(MBKFEDOAILK);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003DE")]
		[Cpp2IlInjected.Address(RVA = "0x47AB8F0", Offset = "0x47A9EF0", VA = "0x1847AB8F0")]
		protected PDOMBIKABAA(PJNMBNAHIFL ALELNINOAGK, TVariableNode EMDFCFPCFGG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003DF")]
		[Cpp2IlInjected.Address(RVA = "0x47AB2B0", Offset = "0x47A98B0", VA = "0x1847AB2B0", Slot = "88")]
		public override void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E0")]
		[Cpp2IlInjected.Address(RVA = "0x47AAE00", Offset = "0x47A9400", VA = "0x1847AAE00", Slot = "120")]
		protected override void AANCPJNHLHN(GDJFKKGDGFJ KMONEIKIHIC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E1")]
		[Cpp2IlInjected.Address(RVA = "0x47AB550", Offset = "0x47A9B50", VA = "0x1847AB550", Slot = "126")]
		protected virtual void NOFDDFDGBMI(GDJFKKGDGFJ KMONEIKIHIC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E2")]
		[Cpp2IlInjected.Address(RVA = "0x47AB450", Offset = "0x47A9A50", VA = "0x1847AB450", Slot = "105")]
		public override void LJOBMJGJKLI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x1FBE090", Offset = "0x1FBC690", VA = "0x181FBE090")]
	public static INBEHHBGGBG ENFOKLPNHAF(PJNMBNAHIFL ALELNINOAGK, JJAEOPCJMCB EMDFCFPCFGG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A7")]
public sealed class DIANJOIJIDE : FKBGMNABOAN, EEBGPMMBBHA, GFPIIFJFFHL, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000088")]
	public CGBGMGFBCKF<FELHHAAOOHO> PKPJICHDOJE
	{
		[Cpp2IlInjected.Token(Token = "0x60003EB")]
		[Cpp2IlInjected.Address(RVA = "0xA9B840", Offset = "0xA99E40", VA = "0x180A9B840", Slot = "24")]
		[CompilerGenerated]
		get
		{
			return default(CGBGMGFBCKF<FELHHAAOOHO>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000089")]
	public CGBGMGFBCKF<CPECOCNOBEE> PDMKMCGJJMG
	{
		[Cpp2IlInjected.Token(Token = "0x60003EC")]
		[Cpp2IlInjected.Address(RVA = "0xF99C90", Offset = "0xF98290", VA = "0x180F99C90", Slot = "25")]
		[CompilerGenerated]
		get
		{
			return default(CGBGMGFBCKF<CPECOCNOBEE>);
		}
		[Cpp2IlInjected.Token(Token = "0x60003ED")]
		[Cpp2IlInjected.Address(RVA = "0x1FC8F70", Offset = "0x1FC7570", VA = "0x181FC8F70")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008A")]
	private CGBGMGFBCKF<FLNLEKBDPAB> KDFCLPNIKJN
	{
		[Cpp2IlInjected.Token(Token = "0x60003EE")]
		[Cpp2IlInjected.Address(RVA = "0xBF5990", Offset = "0xBF3F90", VA = "0x180BF5990")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008B")]
	public override CGBGMGFBCKF<HECEFCAIFNP> JILPHPPAAHE
	{
		[Cpp2IlInjected.Token(Token = "0x60003EF")]
		[Cpp2IlInjected.Address(RVA = "0x1FC8BD0", Offset = "0x1FC71D0", VA = "0x181FC8BD0", Slot = "20")]
		get
		{
			return default(CGBGMGFBCKF<HECEFCAIFNP>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003F0")]
	[Cpp2IlInjected.Address(RVA = "0x1FC8F80", Offset = "0x1FC7580", VA = "0x181FC8F80")]
	private DIANJOIJIDE(PJNMBNAHIFL ALELNINOAGK, JJAEOPCJMCB EMDFCFPCFGG, GFEFKCHBKCA PHJMHCMKHNI, CGBGMGFBCKF<HGFEOPBBPIG> GKEOEKGAILK, CGBGMGFBCKF<CPECOCNOBEE> PDHFLBHDHCA, CGBGMGFBCKF<FLNLEKBDPAB> KHJIHNBGKNK, bool LGIAMDHGCNK, string GJEDHMJMNJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F1")]
	[Cpp2IlInjected.Address(RVA = "0x1FC8C20", Offset = "0x1FC7220", VA = "0x181FC8C20")]
	public static DIANJOIJIDE ENFOKLPNHAF(PJNMBNAHIFL ALELNINOAGK, JJAEOPCJMCB EMDFCFPCFGG, GFEFKCHBKCA NPMJDIPDBFJ, CGBGMGFBCKF<HGFEOPBBPIG> GKEOEKGAILK, CGBGMGFBCKF<FLNLEKBDPAB> KHJIHNBGKNK, CGBGMGFBCKF<CPECOCNOBEE> PDHFLBHDHCA, bool LGIAMDHGCNK, bool JGBMGBJLMOK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F2")]
	[Cpp2IlInjected.Address(RVA = "0x1FC8F70", Offset = "0x1FC7570", VA = "0x181FC8F70")]
	internal void OIHPBMDEJMI(CGBGMGFBCKF<CPECOCNOBEE> DMNGPNKHPKF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A8")]
public abstract class FKBGMNABOAN : GFPIIFJFFHL, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000A9")]
	private struct HFBCDOPINGB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001F5")]
		private LMKMNJCAEMF? NOGCEGLNLGB;

		[Cpp2IlInjected.Token(Token = "0x6000410")]
		[Cpp2IlInjected.Address(RVA = "0x1FCE0C0", Offset = "0x1FCC6C0", VA = "0x181FCE0C0")]
		public void DMCFOMNOLLC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000411")]
		[Cpp2IlInjected.Address(RVA = "0x1FCE0D0", Offset = "0x1FCC6D0", VA = "0x181FCE0D0")]
		public LMKMNJCAEMF HGBIJIONGFJ(FKBGMNABOAN MFGJNJDALCH)
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001EC")]
	protected readonly PJNMBNAHIFL NKJLAAKEIDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001ED")]
	protected readonly JJAEOPCJMCB NHPEOKOCKNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001EE")]
	private HFBCDOPINGB LGKMLEMAKOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001EF")]
	private readonly GKAPBNCBGCC CBLBNCHOCHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001F0")]
	private readonly List<PNGKIAHILPC> NMJFOIGHMND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40001F1")]
	private readonly List<AGEHGOPMMNJ> DJMIJHOEMCG;

	[Cpp2IlInjected.Token(Token = "0x1700008C")]
	[DFMFJMBJIGJ("To be deprecated with NodeConnection")]
	public IEnumerable<StaticEdge> HDCBCNKHMGO
	{
		[Cpp2IlInjected.Token(Token = "0x60003F3")]
		[Cpp2IlInjected.Address(RVA = "0x1FCB930", Offset = "0x1FC9F30", VA = "0x181FCB930", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008D")]
	public DisplayKind CHEPIMMMIIB
	{
		[Cpp2IlInjected.Token(Token = "0x60003F4")]
		[Cpp2IlInjected.Address(RVA = "0x8764A0", Offset = "0x874AA0", VA = "0x1808764A0", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(DisplayKind);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008E")]
	public CGBGMGFBCKF<NPIPKFBHIBO> IHPNLCLNIBJ
	{
		[Cpp2IlInjected.Token(Token = "0x60003F5")]
		[Cpp2IlInjected.Address(RVA = "0x1FCB520", Offset = "0x1FC9B20", VA = "0x181FCB520", Slot = "6")]
		get
		{
			return default(CGBGMGFBCKF<NPIPKFBHIBO>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008F")]
	public HBIPEINCKFG<NPIPKFBHIBO> GCGDLJPBLCE
	{
		[Cpp2IlInjected.Token(Token = "0x60003F6")]
		[Cpp2IlInjected.Address(RVA = "0x1FCB490", Offset = "0x1FC9A90", VA = "0x181FCB490", Slot = "7")]
		get
		{
			return default(HBIPEINCKFG<NPIPKFBHIBO>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000090")]
	public MBGGCGEEENC LLGBEJPLKFI
	{
		[Cpp2IlInjected.Token(Token = "0x60003F7")]
		[Cpp2IlInjected.Address(RVA = "0x1C276E0", Offset = "0x1C25CE0", VA = "0x181C276E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000091")]
	public JFHMPAIIPCH JDLEJDFGHEO
	{
		[Cpp2IlInjected.Token(Token = "0x60003F8")]
		[Cpp2IlInjected.Address(RVA = "0x1FCAEC0", Offset = "0x1FC94C0", VA = "0x181FCAEC0", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000092")]
	protected LMKMNJCAEMF HMFOCLDMKIL
	{
		[Cpp2IlInjected.Token(Token = "0x60003F9")]
		[Cpp2IlInjected.Address(RVA = "0x1FCAEC0", Offset = "0x1FC94C0", VA = "0x181FCAEC0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000093")]
	public PortImage DEGFPALMCME
	{
		[Cpp2IlInjected.Token(Token = "0x60003FA")]
		[Cpp2IlInjected.Address(RVA = "0x1FCB020", Offset = "0x1FC9620", VA = "0x181FCB020", Slot = "13")]
		get
		{
			return default(PortImage);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000094")]
	public string OABCLOFHIGC
	{
		[Cpp2IlInjected.Token(Token = "0x60003FB")]
		[Cpp2IlInjected.Address(RVA = "0x868CC0", Offset = "0x8672C0", VA = "0x180868CC0", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60003FC")]
		[Cpp2IlInjected.Address(RVA = "0x868CA0", Offset = "0x8672A0", VA = "0x180868CA0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000095")]
	public HBIPEINCKFG<JBMJEMLAFJB> MNNCLHPABOH
	{
		[Cpp2IlInjected.Token(Token = "0x60003FD")]
		[Cpp2IlInjected.Address(RVA = "0x1FCBA80", Offset = "0x1FCA080", VA = "0x181FCBA80", Slot = "9")]
		get
		{
			return default(HBIPEINCKFG<JBMJEMLAFJB>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000096")]
	public CGBGMGFBCKF<HGFEOPBBPIG> LCHCILLFDEP
	{
		[Cpp2IlInjected.Token(Token = "0x60003FE")]
		[Cpp2IlInjected.Address(RVA = "0x9DDFA0", Offset = "0x9DC5A0", VA = "0x1809DDFA0", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return default(CGBGMGFBCKF<HGFEOPBBPIG>);
		}
		[Cpp2IlInjected.Token(Token = "0x60003FF")]
		[Cpp2IlInjected.Address(RVA = "0xED2660", Offset = "0xED0C60", VA = "0x180ED2660")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000097")]
	public abstract CGBGMGFBCKF<HECEFCAIFNP> JILPHPPAAHE
	{
		[Cpp2IlInjected.Token(Token = "0x6000400")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000401")]
	[Cpp2IlInjected.Address(RVA = "0x1FCC280", Offset = "0x1FCA880", VA = "0x181FCC280")]
	protected FKBGMNABOAN(PJNMBNAHIFL ALELNINOAGK, JJAEOPCJMCB EMDFCFPCFGG, GKAPBNCBGCC OJDLGPLPDJG, CGBGMGFBCKF<HGFEOPBBPIG> GKEOEKGAILK, bool LGIAMDHGCNK, string GJEDHMJMNJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000402")]
	[Cpp2IlInjected.Address(RVA = "0x1FCC130", Offset = "0x1FCA730", VA = "0x181FCC130", Slot = "21")]
	protected virtual void PNLKNBIHCGI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000403")]
	[Cpp2IlInjected.Address(RVA = "0x1FCB150", Offset = "0x1FC9750", VA = "0x181FCB150", Slot = "22")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000404")]
	[Cpp2IlInjected.Address(RVA = "0x1FCB4C0", Offset = "0x1FC9AC0", VA = "0x181FCB4C0", Slot = "14")]
	public void IOPMHCCPEHM(PNGKIAHILPC MEDPKOGPCIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000405")]
	[Cpp2IlInjected.Address(RVA = "0x1FCB550", Offset = "0x1FC9B50", VA = "0x181FCB550", Slot = "15")]
	public void JDGEJKOLFEC(AGEHGOPMMNJ MEDPKOGPCIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000406")]
	[Cpp2IlInjected.Address(RVA = "0x1FCBAA0", Offset = "0x1FCA0A0", VA = "0x181FCBAA0", Slot = "16")]
	public void PAADAKCBHJH(JEBFMDIELNP MEELEAGKCMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000407")]
	[Cpp2IlInjected.Address(RVA = "0x1FCB430", Offset = "0x1FC9A30", VA = "0x181FCB430", Slot = "23")]
	protected virtual void IBGNIFAHKIP(JEBFMDIELNP MEELEAGKCMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000408")]
	[Cpp2IlInjected.Address(RVA = "0x1FCB2A0", Offset = "0x1FC98A0", VA = "0x181FCB2A0")]
	private void FOPHGHFFMHJ(bool INKFLMKONLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000409")]
	[Cpp2IlInjected.Address(RVA = "0x1FCB5B0", Offset = "0x1FC9BB0", VA = "0x181FCB5B0")]
	private void LCBELABMCGC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040A")]
	[Cpp2IlInjected.Address(RVA = "0x1FCB780", Offset = "0x1FC9D80", VA = "0x181FCB780")]
	private void MECNDDKNDNB([In] OJHBJKCGJOI IGDFPGCMJMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040B")]
	[Cpp2IlInjected.Address(RVA = "0x1FCAFC0", Offset = "0x1FC95C0", VA = "0x181FCAFC0", Slot = "17")]
	public void CJMDJLHEDEH(PNGKIAHILPC MEDPKOGPCIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040C")]
	[Cpp2IlInjected.Address(RVA = "0x1FCAF60", Offset = "0x1FC9560", VA = "0x181FCAF60", Slot = "18")]
	public void BLOLJFMCOOP(AGEHGOPMMNJ MEDPKOGPCIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040D")]
	[Cpp2IlInjected.Address(RVA = "0x868CA0", Offset = "0x8672A0", VA = "0x180868CA0")]
	internal void JNBGAJOMABB(string GJEDHMJMNJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040E")]
	[Cpp2IlInjected.Address(RVA = "0x1FCB760", Offset = "0x1FC9D60", VA = "0x181FCB760")]
	internal void LPMLKJHHION(OGKPNNCIPIA BPGHBBHBELB, MBGGCGEEENC GOAECDHCJMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040F")]
	[Cpp2IlInjected.Address(RVA = "0xED2660", Offset = "0xED0C60", VA = "0x180ED2660")]
	internal void HONAOLNMLMM(CGBGMGFBCKF<HGFEOPBBPIG> GKEOEKGAILK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AB")]
public sealed class NBEMJHPNING : PDDIJOAHCGO, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000AC")]
	[CompilerGenerated]
	private sealed class OFLKFIDAJOB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000215")]
		public PJNMBNAHIFL circuitsManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000216")]
		public JJAEOPCJMCB node;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000217")]
		public CGBGMGFBCKF<HGFEOPBBPIG> portGroupId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000218")]
		public bool canInteract;

		[Cpp2IlInjected.FieldOffset(Offset = "0x25")]
		[Cpp2IlInjected.Token(Token = "0x4000219")]
		public bool ignoreChipConfigPortNames;

		[Cpp2IlInjected.Token(Token = "0x600045C")]
		[Cpp2IlInjected.Address(RVA = "0x86C4B0", Offset = "0x86AAB0", VA = "0x18086C4B0")]
		public OFLKFIDAJOB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600045D")]
		[Cpp2IlInjected.Address(RVA = "0x1FDDCC0", Offset = "0x1FDC2C0", VA = "0x181FDDCC0")]
		internal PALNNNBJCJE PIHAAKAPBJI((int PortDescIndex, int PortIndex, JNAGHLPMJGM InputPort) i)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600045E")]
		[Cpp2IlInjected.Address(RVA = "0x1FDDC30", Offset = "0x1FDC230", VA = "0x181FDDC30")]
		internal DIANJOIJIDE LOKPHJCDKPK(GFEFKCHBKCA i, int idx)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000AD")]
	[CompilerGenerated]
	private struct GDIBHGKJFOG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400021A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400021B")]
		public AsyncTaskMethodBuilder<CBDPDIPONCF<COKMANPFJNC, FBDDJIHDMAI>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400021C")]
		public NBEMJHPNING <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400021D")]
		private MBPPFDMCEAB <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400021E")]
		private TaskAwaiter<CBDPDIPONCF<COKMANPFJNC, FBDDJIHDMAI>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600045F")]
		[Cpp2IlInjected.Address(RVA = "0x1FCD000", Offset = "0x1FCB600", VA = "0x181FCD000", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000460")]
		[Cpp2IlInjected.Address(RVA = "0x1FCD460", Offset = "0x1FCBA60", VA = "0x181FCD460", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000AF")]
	[CompilerGenerated]
	private struct ENPKJMNFAEG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000221")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000222")]
		public AsyncTaskMethodBuilder<CBDPDIPONCF<COKMANPFJNC, FBDDJIHDMAI>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000223")]
		public NBEMJHPNING <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000224")]
		public CGBGMGFBCKF<JJKDMNECOCJ> inputDefId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000225")]
		private MBPPFDMCEAB <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000226")]
		private TaskAwaiter<CBDPDIPONCF<COKMANPFJNC, FBDDJIHDMAI>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000464")]
		[Cpp2IlInjected.Address(RVA = "0x1FCAA30", Offset = "0x1FC9030", VA = "0x181FCAA30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000465")]
		[Cpp2IlInjected.Address(RVA = "0x1FCAD80", Offset = "0x1FC9380", VA = "0x181FCAD80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B0")]
	[CompilerGenerated]
	private struct BCGGMIOGCKF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000227")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000228")]
		public AsyncTaskMethodBuilder<CBDPDIPONCF<COKMANPFJNC, FBDDJIHDMAI>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000229")]
		public NBEMJHPNING <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400022A")]
		public CGBGMGFBCKF<FLNLEKBDPAB> outputDefId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400022B")]
		private MBPPFDMCEAB <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400022C")]
		private TaskAwaiter<CBDPDIPONCF<COKMANPFJNC, FBDDJIHDMAI>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000466")]
		[Cpp2IlInjected.Address(RVA = "0x1FC7180", Offset = "0x1FC5780", VA = "0x181FC7180", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000467")]
		[Cpp2IlInjected.Address(RVA = "0x1FC74D0", Offset = "0x1FC5AD0", VA = "0x181FC74D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B1")]
	[CompilerGenerated]
	private struct AONPOAKIBIK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400022D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400022E")]
		public AsyncTaskMethodBuilder<CBDPDIPONCF<COKMANPFJNC, FBDDJIHDMAI>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400022F")]
		public NBEMJHPNING <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000230")]
		public CGBGMGFBCKF<JJKDMNECOCJ> inputDefId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000231")]
		public CGBGMGFBCKF<JJKDMNECOCJ> targetIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000232")]
		private MBPPFDMCEAB <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000233")]
		private TaskAwaiter<CBDPDIPONCF<COKMANPFJNC, FBDDJIHDMAI>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000468")]
		[Cpp2IlInjected.Address(RVA = "0x1FC6DC0", Offset = "0x1FC53C0", VA = "0x181FC6DC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000469")]
		[Cpp2IlInjected.Address(RVA = "0x1FC7110", Offset = "0x1FC5710", VA = "0x181FC7110", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B2")]
	[CompilerGenerated]
	private struct MEPNPJEFEFD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000234")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000235")]
		public AsyncTaskMethodBuilder<CBDPDIPONCF<COKMANPFJNC, FBDDJIHDMAI>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000236")]
		public NBEMJHPNING <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000237")]
		public CGBGMGFBCKF<FLNLEKBDPAB> outputDefId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000238")]
		public CGBGMGFBCKF<FLNLEKBDPAB> targetIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000239")]
		private MBPPFDMCEAB <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400023A")]
		private TaskAwaiter<CBDPDIPONCF<COKMANPFJNC, FBDDJIHDMAI>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600046A")]
		[Cpp2IlInjected.Address(RVA = "0x1FD4CE0", Offset = "0x1FD32E0", VA = "0x181FD4CE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600046B")]
		[Cpp2IlInjected.Address(RVA = "0x1FD5030", Offset = "0x1FD3630", VA = "0x181FD5030", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B3")]
	[CompilerGenerated]
	private struct CHBLNGEEMNK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400023B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400023C")]
		public AsyncTaskMethodBuilder<CBDPDIPONCF<COKMANPFJNC, FBDDJIHDMAI>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400023D")]
		public NBEMJHPNING <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400023E")]
		private MBPPFDMCEAB <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400023F")]
		private TaskAwaiter<CBDPDIPONCF<COKMANPFJNC, FBDDJIHDMAI>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600046C")]
		[Cpp2IlInjected.Address(RVA = "0x1FC7FA0", Offset = "0x1FC65A0", VA = "0x181FC7FA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600046D")]
		[Cpp2IlInjected.Address(RVA = "0x1FC8410", Offset = "0x1FC6A10", VA = "0x181FC8410", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B4")]
	[CompilerGenerated]
	private struct EFACPIPILFL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000240")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000241")]
		public AsyncTaskMethodBuilder<CBDPDIPONCF<COKMANPFJNC, FBDDJIHDMAI>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000242")]
		public NBEMJHPNING <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000243")]
		public string newName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000244")]
		private MBPPFDMCEAB <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000245")]
		private TaskAwaiter<CBDPDIPONCF<COKMANPFJNC, FBDDJIHDMAI>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600046E")]
		[Cpp2IlInjected.Address(RVA = "0x1FC9940", Offset = "0x1FC7F40", VA = "0x181FC9940", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600046F")]
		[Cpp2IlInjected.Address(RVA = "0x1FC9C90", Offset = "0x1FC8290", VA = "0x181FC9C90", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B5")]
	[CompilerGenerated]
	private struct CFKCJHHCDLO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000246")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000247")]
		public AsyncTaskMethodBuilder<CBDPDIPONCF<COKMANPFJNC, FBDDJIHDMAI>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000248")]
		public NBEMJHPNING <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000249")]
		public CGBGMGFBCKF<JJKDMNECOCJ> inputDefId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400024A")]
		public string name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400024B")]
		private MBPPFDMCEAB <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400024C")]
		private TaskAwaiter<CBDPDIPONCF<COKMANPFJNC, FBDDJIHDMAI>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000470")]
		[Cpp2IlInjected.Address(RVA = "0x1FC7AC0", Offset = "0x1FC60C0", VA = "0x181FC7AC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000471")]
		[Cpp2IlInjected.Address(RVA = "0x1FC7E10", Offset = "0x1FC6410", VA = "0x181FC7E10", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B6")]
	[CompilerGenerated]
	private struct EGEHKCAAEJH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400024D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400024E")]
		public AsyncTaskMethodBuilder<CBDPDIPONCF<COKMANPFJNC, FBDDJIHDMAI>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400024F")]
		public NBEMJHPNING <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000250")]
		public CGBGMGFBCKF<FLNLEKBDPAB> outputDefId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000251")]
		public string name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000252")]
		private MBPPFDMCEAB <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000253")]
		private TaskAwaiter<CBDPDIPONCF<COKMANPFJNC, FBDDJIHDMAI>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000472")]
		[Cpp2IlInjected.Address(RVA = "0x1FC9D00", Offset = "0x1FC8300", VA = "0x181FC9D00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000473")]
		[Cpp2IlInjected.Address(RVA = "0x1FCA050", Offset = "0x1FC8650", VA = "0x181FCA050", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B7")]
	[CompilerGenerated]
	private struct NPPFHMLBAMK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000254")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000255")]
		public AsyncTaskMethodBuilder<CBDPDIPONCF<COKMANPFJNC, FBDDJIHDMAI>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000256")]
		public NBEMJHPNING <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000257")]
		public GPEGJBGOEPB type;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000258")]
		public CGBGMGFBCKF<JJKDMNECOCJ> inputDefId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000259")]
		private MBPPFDMCEAB <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400025A")]
		private TaskAwaiter<CBDPDIPONCF<COKMANPFJNC, FBDDJIHDMAI>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000474")]
		[Cpp2IlInjected.Address(RVA = "0x1FDCBC0", Offset = "0x1FDB1C0", VA = "0x181FDCBC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000475")]
		[Cpp2IlInjected.Address(RVA = "0x1FDCF50", Offset = "0x1FDB550", VA = "0x181FDCF50", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B8")]
	[CompilerGenerated]
	private struct LPGLAMFBJNL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400025B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400025C")]
		public AsyncTaskMethodBuilder<CBDPDIPONCF<COKMANPFJNC, FBDDJIHDMAI>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400025D")]
		public NBEMJHPNING <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400025E")]
		public GPEGJBGOEPB type;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400025F")]
		public CGBGMGFBCKF<FLNLEKBDPAB> outputDefId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000260")]
		private MBPPFDMCEAB <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000261")]
		private TaskAwaiter<CBDPDIPONCF<COKMANPFJNC, FBDDJIHDMAI>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000476")]
		[Cpp2IlInjected.Address(RVA = "0x1FD48E0", Offset = "0x1FD2EE0", VA = "0x181FD48E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000477")]
		[Cpp2IlInjected.Address(RVA = "0x1FD4C70", Offset = "0x1FD3270", VA = "0x181FD4C70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001F8")]
	private readonly bool GAGPDHDAPJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001F9")]
	private readonly PJNMBNAHIFL NKJLAAKEIDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001FA")]
	private readonly bool OFEBONFCOPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001FB")]
	private OEMHKMDMOFO<NLKCJCDLMOJ, PALNNNBJCJE> NGEHKINMJIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001FC")]
	private OEMHKMDMOFO<NLKCJCDLMOJ, PGFKPKOPNBP> KJAGNGFKCPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40001FD")]
	private readonly JJAEOPCJMCB NHPEOKOCKNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40001FE")]
	private OEMHKMDMOFO<CPECOCNOBEE, DIANJOIJIDE> GDLOMIACNOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40001FF")]
	private OEMHKMDMOFO<CPECOCNOBEE, EEBGPMMBBHA> MHMNKFJMNDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000200")]
	private string? GEFNBHGDDGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000201")]
	private readonly DFIHDLEBDJG KFIDIMJLJHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000202")]
	private CGBGMGFBCKF<HGFEOPBBPIG> JCDFFHCMOJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x4000203")]
	private readonly bool FDDBMMLIEEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000204")]
	[CompilerGenerated]
	private Action? LAHMKCPDBKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000206")]
	[CompilerGenerated]
	private Action? ANFDEKPOCAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x400020E")]
	[CompilerGenerated]
	private Action<CGBGMGFBCKF<NLKCJCDLMOJ>>? JKBNHIBGJIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x4000212")]
	[CompilerGenerated]
	private Action<CGBGMGFBCKF<CPECOCNOBEE>>? LNMGKHFOAJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x4000214")]
	[CompilerGenerated]
	private PDDIJOAHCGO.CIKDOHMLOKE? PDMGHMMCIDA;

	[Cpp2IlInjected.Token(Token = "0x17000098")]
	public bool OMDFKDBLBHB
	{
		[Cpp2IlInjected.Token(Token = "0x6000415")]
		[Cpp2IlInjected.Address(RVA = "0x1FDAD80", Offset = "0x1FD9380", VA = "0x181FDAD80", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000099")]
	public bool BNOMDCLEGBP
	{
		[Cpp2IlInjected.Token(Token = "0x6000416")]
		[Cpp2IlInjected.Address(RVA = "0x1FD9180", Offset = "0x1FD7780", VA = "0x181FD9180", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009A")]
	public bool EAJONICPBJP
	{
		[Cpp2IlInjected.Token(Token = "0x6000417")]
		[Cpp2IlInjected.Address(RVA = "0x1FDAF80", Offset = "0x1FD9580", VA = "0x181FDAF80", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009B")]
	public HBIPEINCKFG<NPIPKFBHIBO> GCGDLJPBLCE
	{
		[Cpp2IlInjected.Token(Token = "0x6000418")]
		[Cpp2IlInjected.Address(RVA = "0x1FD9150", Offset = "0x1FD7750", VA = "0x181FD9150", Slot = "7")]
		get
		{
			return default(HBIPEINCKFG<NPIPKFBHIBO>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009C")]
	public bool LJPMMNDDEHG
	{
		[Cpp2IlInjected.Token(Token = "0x6000419")]
		[Cpp2IlInjected.Address(RVA = "0x1FDB040", Offset = "0x1FD9640", VA = "0x181FDB040", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009D")]
	public OEMHKMDMOFO<NLKCJCDLMOJ, PGFKPKOPNBP> AIOPCCLPLKC
	{
		[Cpp2IlInjected.Token(Token = "0x600041A")]
		[Cpp2IlInjected.Address(RVA = "0x868260", Offset = "0x866860", VA = "0x180868260", Slot = "9")]
		get
		{
			return default(OEMHKMDMOFO<NLKCJCDLMOJ, PGFKPKOPNBP>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009E")]
	public string OABCLOFHIGC
	{
		[Cpp2IlInjected.Token(Token = "0x600041B")]
		[Cpp2IlInjected.Address(RVA = "0x1FDA010", Offset = "0x1FD8610", VA = "0x181FDA010", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009F")]
	public HBIPEINCKFG<JBMJEMLAFJB> MNNCLHPABOH
	{
		[Cpp2IlInjected.Token(Token = "0x600041C")]
		[Cpp2IlInjected.Address(RVA = "0x1FDB2F0", Offset = "0x1FD98F0", VA = "0x181FDB2F0", Slot = "11")]
		get
		{
			return default(HBIPEINCKFG<JBMJEMLAFJB>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A0")]
	public OEMHKMDMOFO<CPECOCNOBEE, EEBGPMMBBHA> PHABLGLAKNC
	{
		[Cpp2IlInjected.Token(Token = "0x600041D")]
		[Cpp2IlInjected.Address(RVA = "0x868CC0", Offset = "0x8672C0", VA = "0x180868CC0", Slot = "12")]
		get
		{
			return default(OEMHKMDMOFO<CPECOCNOBEE, EEBGPMMBBHA>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A1")]
	public CGBGMGFBCKF<HGFEOPBBPIG> LCHCILLFDEP
	{
		[Cpp2IlInjected.Token(Token = "0x600041E")]
		[Cpp2IlInjected.Address(RVA = "0xBF7AA0", Offset = "0xBF60A0", VA = "0x180BF7AA0", Slot = "13")]
		get
		{
			return default(CGBGMGFBCKF<HGFEOPBBPIG>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	public event Action KHODJPEBKGF
	{
		[Cpp2IlInjected.Token(Token = "0x600041F")]
		[Cpp2IlInjected.Address(RVA = "0x1FDB750", Offset = "0x1FD9D50", VA = "0x181FDB750", Slot = "14")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000420")]
		[Cpp2IlInjected.Address(RVA = "0x1FDACE0", Offset = "0x1FD92E0", VA = "0x181FDACE0", Slot = "15")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	public event Action NCIBBFNHCNK
	{
		[Cpp2IlInjected.Token(Token = "0x6000421")]
		[Cpp2IlInjected.Address(RVA = "0x1FD6860", Offset = "0x1FD4E60", VA = "0x181FD6860", Slot = "16")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000422")]
		[Cpp2IlInjected.Address(RVA = "0x1FDB6A0", Offset = "0x1FD9CA0", VA = "0x181FDB6A0", Slot = "17")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000E")]
	public event Action<CGBGMGFBCKF<NLKCJCDLMOJ>, CGBGMGFBCKF<NLKCJCDLMOJ>> NIGDJKNJAFK
	{
		[Cpp2IlInjected.Token(Token = "0x6000423")]
		[Cpp2IlInjected.Address(RVA = "0x1FD6400", Offset = "0x1FD4A00", VA = "0x181FD6400", Slot = "18")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000424")]
		[Cpp2IlInjected.Address(RVA = "0x1FD9090", Offset = "0x1FD7690", VA = "0x181FD9090", Slot = "19")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000F")]
	public event Action<CGBGMGFBCKF<NLKCJCDLMOJ>, CGBGMGFBCKF<NLKCJCDLMOJ>> OPJMJHPOPHK
	{
		[Cpp2IlInjected.Token(Token = "0x6000425")]
		[Cpp2IlInjected.Address(RVA = "0x1FDB230", Offset = "0x1FD9830", VA = "0x181FDB230", Slot = "20")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000426")]
		[Cpp2IlInjected.Address(RVA = "0x1FD6210", Offset = "0x1FD4810", VA = "0x181FD6210", Slot = "21")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000010")]
	public event Action<CGBGMGFBCKF<CPECOCNOBEE>, CGBGMGFBCKF<CPECOCNOBEE>> GCALFOANEPN
	{
		[Cpp2IlInjected.Token(Token = "0x6000427")]
		[Cpp2IlInjected.Address(RVA = "0x1FDB310", Offset = "0x1FD9910", VA = "0x181FDB310", Slot = "22")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000428")]
		[Cpp2IlInjected.Address(RVA = "0x1FDAEC0", Offset = "0x1FD94C0", VA = "0x181FDAEC0", Slot = "23")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000011")]
	public event Action<CGBGMGFBCKF<CPECOCNOBEE>, CGBGMGFBCKF<CPECOCNOBEE>> AJBKLEEHIDH
	{
		[Cpp2IlInjected.Token(Token = "0x6000429")]
		[Cpp2IlInjected.Address(RVA = "0x1FD9E30", Offset = "0x1FD8430", VA = "0x181FD9E30", Slot = "24")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600042A")]
		[Cpp2IlInjected.Address(RVA = "0x1FD8930", Offset = "0x1FD6F30", VA = "0x181FD8930", Slot = "25")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000012")]
	public event Action<CGBGMGFBCKF<NLKCJCDLMOJ>, PGFKPKOPNBP> MODEFBDDCOE
	{
		[Cpp2IlInjected.Token(Token = "0x600042B")]
		[Cpp2IlInjected.Address(RVA = "0x1FDB3D0", Offset = "0x1FD99D0", VA = "0x181FDB3D0", Slot = "26")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600042C")]
		[Cpp2IlInjected.Address(RVA = "0x1FDB490", Offset = "0x1FD9A90", VA = "0x181FDB490", Slot = "27")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000013")]
	public event Action<CGBGMGFBCKF<NLKCJCDLMOJ>> GBPHGGAKMPL
	{
		[Cpp2IlInjected.Token(Token = "0x600042D")]
		[Cpp2IlInjected.Address(RVA = "0x1FDA640", Offset = "0x1FD8C40", VA = "0x181FDA640", Slot = "28")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600042E")]
		[Cpp2IlInjected.Address(RVA = "0x1FD66B0", Offset = "0x1FD4CB0", VA = "0x181FD66B0", Slot = "29")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000014")]
	public event Action<CGBGMGFBCKF<NLKCJCDLMOJ>, PGFKPKOPNBP> FDLAGEKBLAD
	{
		[Cpp2IlInjected.Token(Token = "0x600042F")]
		[Cpp2IlInjected.Address(RVA = "0x1FDAB60", Offset = "0x1FD9160", VA = "0x181FDAB60", Slot = "30")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000430")]
		[Cpp2IlInjected.Address(RVA = "0x1FD7F30", Offset = "0x1FD6530", VA = "0x181FD7F30", Slot = "31")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000015")]
	public event Action<CGBGMGFBCKF<CPECOCNOBEE>, EEBGPMMBBHA> ONOAMFAJDLP
	{
		[Cpp2IlInjected.Token(Token = "0x6000431")]
		[Cpp2IlInjected.Address(RVA = "0x1FD7FF0", Offset = "0x1FD65F0", VA = "0x181FD7FF0", Slot = "32")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000432")]
		[Cpp2IlInjected.Address(RVA = "0x1FDA700", Offset = "0x1FD8D00", VA = "0x181FDA700", Slot = "33")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000016")]
	public event Action<CGBGMGFBCKF<CPECOCNOBEE>> NIOLCHHIEMO
	{
		[Cpp2IlInjected.Token(Token = "0x6000433")]
		[Cpp2IlInjected.Address(RVA = "0x1FD64C0", Offset = "0x1FD4AC0", VA = "0x181FD64C0", Slot = "34")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000434")]
		[Cpp2IlInjected.Address(RVA = "0x1FD8B10", Offset = "0x1FD7110", VA = "0x181FD8B10", Slot = "35")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000017")]
	public event Action<CGBGMGFBCKF<CPECOCNOBEE>, EEBGPMMBBHA> JANNKMFDFON
	{
		[Cpp2IlInjected.Token(Token = "0x6000435")]
		[Cpp2IlInjected.Address(RVA = "0x1FDAC20", Offset = "0x1FD9220", VA = "0x181FDAC20", Slot = "36")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000436")]
		[Cpp2IlInjected.Address(RVA = "0x1FDA580", Offset = "0x1FD8B80", VA = "0x181FDA580", Slot = "37")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000437")]
	[Cpp2IlInjected.Address(RVA = "0x1FDBFA0", Offset = "0x1FDA5A0", VA = "0x181FDBFA0")]
	private NBEMJHPNING(bool LGIAMDHGCNK, PJNMBNAHIFL ALELNINOAGK, bool INGGJMAEGFD, OEMHKMDMOFO<NLKCJCDLMOJ, PALNNNBJCJE> CJDHDEHLPDF, OEMHKMDMOFO<NLKCJCDLMOJ, PGFKPKOPNBP> HKMAIEAJDOD, JJAEOPCJMCB EMDFCFPCFGG, OEMHKMDMOFO<CPECOCNOBEE, DIANJOIJIDE> PEKOCFEDPPE, OEMHKMDMOFO<CPECOCNOBEE, EEBGPMMBBHA> DMENOCMOCJO, string? CGBNGJNCNOJ, DFIHDLEBDJG DJAFENBDNED, CGBGMGFBCKF<HGFEOPBBPIG> GKEOEKGAILK, bool JGBMGBJLMOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000438")]
	[Cpp2IlInjected.Address(RVA = "0x1FD78D0", Offset = "0x1FD5ED0", VA = "0x181FD78D0")]
	public static NBEMJHPNING ENFOKLPNHAF(bool LGIAMDHGCNK, PJNMBNAHIFL ALELNINOAGK, bool INGGJMAEGFD, JJAEOPCJMCB EMDFCFPCFGG, DFIHDLEBDJG DJAFENBDNED, CGBGMGFBCKF<HGFEOPBBPIG> GKEOEKGAILK, bool JGBMGBJLMOK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000439")]
	[Cpp2IlInjected.Address(RVA = "0x1FDB7F0", Offset = "0x1FD9DF0", VA = "0x181FDB7F0")]
	private void PNLKNBIHCGI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043A")]
	[Cpp2IlInjected.Address(RVA = "0x1FD6A30", Offset = "0x1FD5030", VA = "0x181FD6A30", Slot = "49")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043B")]
	[Cpp2IlInjected.Address(RVA = "0x1FD7E40", Offset = "0x1FD6440", VA = "0x181FD7E40", Slot = "38")]
	[AsyncStateMachine(typeof(GDIBHGKJFOG))]
	public Task<CBDPDIPONCF<COKMANPFJNC, FBDDJIHDMAI>> FAFAMBBJPGI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600043C")]
	[Cpp2IlInjected.Address(RVA = "0x1FD8700", Offset = "0x1FD6D00", VA = "0x181FD8700")]
	private (MKFAAJHOOBB, int)? HDGDJJMIHNG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600043D")]
	[Cpp2IlInjected.Address(RVA = "0x1FD6770", Offset = "0x1FD4D70", VA = "0x181FD6770")]
	private void CJDIHBPLCIH(int ODJJEBBGIEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043E")]
	[Cpp2IlInjected.Address(RVA = "0x1462D90", Offset = "0x1461390", VA = "0x181462D90")]
	private void CDHFPPMOKCF(int ODJJEBBGIEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043F")]
	[Cpp2IlInjected.Address(RVA = "0x1FDA7C0", Offset = "0x1FD8DC0", VA = "0x181FDA7C0")]
	private void LPAOPIGPMJE(int FALDEEFFGNB, int JBGJKFDHAAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000440")]
	[Cpp2IlInjected.Address(RVA = "0x1FDAE40", Offset = "0x1FD9440", VA = "0x181FDAE40")]
	private void NANGKIBDEMM(int FALDEEFFGNB, int JBGJKFDHAAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000441")]
	[Cpp2IlInjected.Address(RVA = "0x1FD81C0", Offset = "0x1FD67C0", VA = "0x181FD81C0")]
	private void HANHPDKLJFM(int ODJJEBBGIEI, CGBGMGFBCKF<NLKCJCDLMOJ> IGBNMPKLCEJ, JNAGHLPMJGM FFJDFAKILFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000442")]
	[Cpp2IlInjected.Address(RVA = "0x1FDAEA0", Offset = "0x1FD94A0", VA = "0x181FDAEA0")]
	private void NBDIANJELLD(int INKFLMKONLP, CGBGMGFBCKF<NLKCJCDLMOJ> IGBNMPKLCEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000443")]
	[Cpp2IlInjected.Address(RVA = "0x1FDB550", Offset = "0x1FD9B50", VA = "0x181FDB550")]
	private void PIDFNAMFDCO(int INKFLMKONLP, CGBGMGFBCKF<NLKCJCDLMOJ> IGBNMPKLCEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000444")]
	[Cpp2IlInjected.Address(RVA = "0x1FD99C0", Offset = "0x1FD7FC0", VA = "0x181FD99C0")]
	private void JPKFEDNDNMC(int ODJJEBBGIEI, CGBGMGFBCKF<NLKCJCDLMOJ> IGBNMPKLCEJ, JNAGHLPMJGM FFJDFAKILFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000445")]
	[Cpp2IlInjected.Address(RVA = "0x1FDB0C0", Offset = "0x1FD96C0", VA = "0x181FDB0C0")]
	private void NOOIODFLNII(int ODJJEBBGIEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000446")]
	[Cpp2IlInjected.Address(RVA = "0xB040D0", Offset = "0xB026D0", VA = "0x180B040D0")]
	private void BKGFFJPHAIE(int ODJJEBBGIEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000447")]
	[Cpp2IlInjected.Address(RVA = "0x1FD6120", Offset = "0x1FD4720", VA = "0x181FD6120")]
	private void ABNDNAMKAEN(int ODJJEBBGIEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000448")]
	[Cpp2IlInjected.Address(RVA = "0x1462D90", Offset = "0x1461390", VA = "0x181462D90")]
	private void PNMCIKAMNFM(int ODJJEBBGIEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000449")]
	[Cpp2IlInjected.Address(RVA = "0x1FD7530", Offset = "0x1FD5B30", VA = "0x181FD7530")]
	private void EHJNAIEDKAC(int FALDEEFFGNB, int JBGJKFDHAAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044A")]
	[Cpp2IlInjected.Address(RVA = "0x1FD60C0", Offset = "0x1FD46C0", VA = "0x181FD60C0")]
	private void AAGJBDECEGO(int FALDEEFFGNB, int JBGJKFDHAAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044B")]
	[Cpp2IlInjected.Address(RVA = "0x1FDA040", Offset = "0x1FD8640", VA = "0x181FDA040")]
	private void LBMDLPDNKBD(int ODJJEBBGIEI, CGBGMGFBCKF<CPECOCNOBEE> IGBNMPKLCEJ, GFEFKCHBKCA FFJDFAKILFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044C")]
	[Cpp2IlInjected.Address(RVA = "0x1FD9E10", Offset = "0x1FD8410", VA = "0x181FD9E10")]
	private void KCIHGHBDAGD(int INKFLMKONLP, CGBGMGFBCKF<CPECOCNOBEE> IGBNMPKLCEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044D")]
	[Cpp2IlInjected.Address(RVA = "0x1FDB210", Offset = "0x1FD9810", VA = "0x181FDB210")]
	private void OABJJMBMJBH(int INKFLMKONLP, CGBGMGFBCKF<CPECOCNOBEE> IGBNMPKLCEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044E")]
	[Cpp2IlInjected.Address(RVA = "0x1FD9420", Offset = "0x1FD7A20", VA = "0x181FD9420")]
	private void JBBJCDPHEEI(int ODJJEBBGIEI, CGBGMGFBCKF<CPECOCNOBEE> IGBNMPKLCEJ, GFEFKCHBKCA FFJDFAKILFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044F")]
	[Cpp2IlInjected.Address(RVA = "0x1FD91C0", Offset = "0x1FD77C0", VA = "0x181FD91C0")]
	private void IIHFBIAOOLK(int ODJJEBBGIEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000450")]
	[Cpp2IlInjected.Address(RVA = "0xB040D0", Offset = "0xB026D0", VA = "0x180B040D0")]
	private void HELEODJLCKF(int ODJJEBBGIEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000451")]
	[Cpp2IlInjected.Address(RVA = "0x1FD9310", Offset = "0x1FD7910", VA = "0x181FD9310", Slot = "39")]
	[AsyncStateMachine(typeof(ENPKJMNFAEG))]
	public Task<CBDPDIPONCF<COKMANPFJNC, FBDDJIHDMAI>> ILJCOGOBKBD(CGBGMGFBCKF<JJKDMNECOCJ> JMCNEMAGKLA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000452")]
	[Cpp2IlInjected.Address(RVA = "0x1FD80B0", Offset = "0x1FD66B0", VA = "0x181FD80B0", Slot = "40")]
	[AsyncStateMachine(typeof(BCGGMIOGCKF))]
	public Task<CBDPDIPONCF<COKMANPFJNC, FBDDJIHDMAI>> GNCBEDDLAEG(CGBGMGFBCKF<FLNLEKBDPAB> KHJIHNBGKNK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000453")]
	[Cpp2IlInjected.Address(RVA = "0x1FD9EF0", Offset = "0x1FD84F0", VA = "0x181FD9EF0", Slot = "41")]
	[AsyncStateMachine(typeof(AONPOAKIBIK))]
	public Task<CBDPDIPONCF<COKMANPFJNC, FBDDJIHDMAI>> KHFMHBOHIHN(CGBGMGFBCKF<JJKDMNECOCJ> JMCNEMAGKLA, CGBGMGFBCKF<JJKDMNECOCJ> IPIBDDBMGNN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000454")]
	[Cpp2IlInjected.Address(RVA = "0x1FD6910", Offset = "0x1FD4F10", VA = "0x181FD6910", Slot = "42")]
	[AsyncStateMachine(typeof(MEPNPJEFEFD))]
	public Task<CBDPDIPONCF<COKMANPFJNC, FBDDJIHDMAI>> DKOLOLPGION(CGBGMGFBCKF<FLNLEKBDPAB> KHJIHNBGKNK, CGBGMGFBCKF<FLNLEKBDPAB> IPIBDDBMGNN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000455")]
	[Cpp2IlInjected.Address(RVA = "0x1FD8BD0", Offset = "0x1FD71D0", VA = "0x181FD8BD0", Slot = "43")]
	[AsyncStateMachine(typeof(CHBLNGEEMNK))]
	public Task<CBDPDIPONCF<COKMANPFJNC, FBDDJIHDMAI>> HNFEPGOKMNK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000456")]
	[Cpp2IlInjected.Address(RVA = "0x1FD89F0", Offset = "0x1FD6FF0", VA = "0x181FD89F0", Slot = "44")]
	[AsyncStateMachine(typeof(EFACPIPILFL))]
	public Task<CBDPDIPONCF<COKMANPFJNC, FBDDJIHDMAI>> HINHBDDEHJF(string BEEOOAHHFHA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000457")]
	[Cpp2IlInjected.Address(RVA = "0x1FD62D0", Offset = "0x1FD48D0", VA = "0x181FD62D0", Slot = "45")]
	[AsyncStateMachine(typeof(CFKCJHHCDLO))]
	public Task<CBDPDIPONCF<COKMANPFJNC, FBDDJIHDMAI>> AMPLNIIKPON(CGBGMGFBCKF<JJKDMNECOCJ> JMCNEMAGKLA, string GJEDHMJMNJA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000458")]
	[Cpp2IlInjected.Address(RVA = "0x1FD9890", Offset = "0x1FD7E90", VA = "0x181FD9890", Slot = "46")]
	[AsyncStateMachine(typeof(EGEHKCAAEJH))]
	public Task<CBDPDIPONCF<COKMANPFJNC, FBDDJIHDMAI>> JGGDHAIDIGA(CGBGMGFBCKF<FLNLEKBDPAB> KHJIHNBGKNK, string GJEDHMJMNJA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000459")]
	[Cpp2IlInjected.Address(RVA = "0x1FD6580", Offset = "0x1FD4B80", VA = "0x181FD6580", Slot = "47")]
	[AsyncStateMachine(typeof(NPPFHMLBAMK))]
	public Task<CBDPDIPONCF<COKMANPFJNC, FBDDJIHDMAI>> BIGFPHADCAH(CGBGMGFBCKF<JJKDMNECOCJ> JMCNEMAGKLA, GPEGJBGOEPB GOAECDHCJMK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600045A")]
	[Cpp2IlInjected.Address(RVA = "0x1FDB570", Offset = "0x1FD9B70", VA = "0x181FDB570", Slot = "48")]
	[AsyncStateMachine(typeof(LPGLAMFBJNL))]
	public Task<CBDPDIPONCF<COKMANPFJNC, FBDDJIHDMAI>> PKCJDOIDIJC(CGBGMGFBCKF<FLNLEKBDPAB> KHJIHNBGKNK, GPEGJBGOEPB GOAECDHCJMK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600045B")]
	[Cpp2IlInjected.Address(RVA = "0x1FD8CC0", Offset = "0x1FD72C0", VA = "0x181FD8CC0")]
	internal void HONAOLNMLMM(CGBGMGFBCKF<HGFEOPBBPIG> DMNGPNKHPKF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B9")]
public sealed class BIOFEIDPHNA : HFIAJFGBMJC, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000BA")]
	public interface HJAFHNCLGOA
	{
		[Cpp2IlInjected.Token(Token = "0x170000A3")]
		OGKPNNCIPIA LPOCEGAKGDI
		{
			[Cpp2IlInjected.Token(Token = "0x600047C")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x600047D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		Task<JJBCGHIHKLB> KNGBLKIFIED(CancellationToken FIMAIPEFOAM);

		[Cpp2IlInjected.Token(Token = "0x600047E")]
		[Cpp2IlInjected.Address(Slot = "2")]
		Task<IOHGNKJIFDJ> DIAIKHNIJPN(CancellationToken FIMAIPEFOAM);

		[Cpp2IlInjected.Token(Token = "0x600047F")]
		[Cpp2IlInjected.Address(Slot = "3")]
		Task<JMIPDJJHHAC> PAHPILHOJGM(CancellationToken FIMAIPEFOAM);
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000BB")]
	[CompilerGenerated]
	private struct PJDMCPMMGNC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000263")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000264")]
		public AsyncTaskMethodBuilder<BIOFEIDPHNA> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000265")]
		public PJNMBNAHIFL circuitsManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000266")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000267")]
		public JJBCGHIHKLB roomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000268")]
		public IOHGNKJIFDJ superRoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000269")]
		private HJAFHNCLGOA <selfDeps>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400026A")]
		private IOHGNKJIFDJ <finalSuperRoomData>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400026B")]
		private TaskAwaiter<JJBCGHIHKLB> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400026C")]
		private TaskAwaiter<IOHGNKJIFDJ> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400026D")]
		private TaskAwaiter<JMIPDJJHHAC> <>u__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400026E")]
		private TaskAwaiter<DDBLDNMCNDP> <>u__4;

		[Cpp2IlInjected.Token(Token = "0x6000480")]
		[Cpp2IlInjected.Address(RVA = "0x1FE05A0", Offset = "0x1FDEBA0", VA = "0x181FE05A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000481")]
		[Cpp2IlInjected.Address(RVA = "0x1FE0FD0", Offset = "0x1FDF5D0", VA = "0x181FE0FD0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000262")]
	private readonly DDBLDNMCNDP EGLIEEGMHNC;

	[Cpp2IlInjected.Token(Token = "0x170000A2")]
	public DDBLDNMCNDP KHJKLDCJFLC
	{
		[Cpp2IlInjected.Token(Token = "0x600047B")]
		[Cpp2IlInjected.Address(RVA = "0x868220", Offset = "0x866820", VA = "0x180868220", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000478")]
	[Cpp2IlInjected.Address(RVA = "0x872130", Offset = "0x870730", VA = "0x180872130")]
	private BIOFEIDPHNA(DDBLDNMCNDP OOIKCJPNOGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000479")]
	[Cpp2IlInjected.Address(RVA = "0x1FC7640", Offset = "0x1FC5C40", VA = "0x181FC7640")]
	[AsyncStateMachine(typeof(PJDMCPMMGNC))]
	public static Task<BIOFEIDPHNA> DKDKEPCPNMG(PJNMBNAHIFL ALELNINOAGK, JJBCGHIHKLB? FPDNBDDHMAO, IOHGNKJIFDJ? KNMFEIKCDGI, CancellationToken FIMAIPEFOAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600047A")]
	[Cpp2IlInjected.Address(RVA = "0x1FC77A0", Offset = "0x1FC5DA0", VA = "0x181FC77A0", Slot = "5")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BC")]
public readonly struct HEDIHINCIPG
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000BD")]
	[CompilerGenerated]
	private struct BLPIDNOLPFL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000270")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000271")]
		public AsyncTaskMethodBuilder<CBDPDIPONCF<object, FBDDJIHDMAI>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000272")]
		public HEDIHINCIPG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000273")]
		public EIJGBFLAMII action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000274")]
		public bool clearBufferedRpcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000275")]
		private TaskAwaiter<CBDPDIPONCF<object, FBDDJIHDMAI>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000486")]
		[Cpp2IlInjected.Address(RVA = "0x1FC77C0", Offset = "0x1FC5DC0", VA = "0x181FC77C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000487")]
		[Cpp2IlInjected.Address(RVA = "0x1FC7A50", Offset = "0x1FC6050", VA = "0x181FC7A50", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000BE")]
	[CompilerGenerated]
	private struct LHNMOFMMDGN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000276")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000277")]
		public AsyncTaskMethodBuilder<CBDPDIPONCF<bool, FBDDJIHDMAI>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000278")]
		public int splitSizeBytes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000279")]
		public EHHGJCHGBMN rootData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400027A")]
		public JJBCGHIHKLB circuitRootData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400027B")]
		public IOHGNKJIFDJ superRoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400027C")]
		public HEDIHINCIPG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400027D")]
		private EIJGBFLAMII[] <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400027E")]
		private int <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400027F")]
		private TaskAwaiter<CBDPDIPONCF<object, FBDDJIHDMAI>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000488")]
		[Cpp2IlInjected.Address(RVA = "0x1FD4490", Offset = "0x1FD2A90", VA = "0x181FD4490", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000489")]
		[Cpp2IlInjected.Address(RVA = "0x1FD4870", Offset = "0x1FD2E70", VA = "0x181FD4870", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000BF")]
	[CompilerGenerated]
	private struct MMILLPLOAML : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000280")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000281")]
		public AsyncTaskMethodBuilder<CBDPDIPONCF<COKMANPFJNC, FBDDJIHDMAI>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000282")]
		public HEDIHINCIPG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000283")]
		private TaskAwaiter<CBDPDIPONCF<object, FBDDJIHDMAI>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600048A")]
		[Cpp2IlInjected.Address(RVA = "0x1FD5E10", Offset = "0x1FD4410", VA = "0x181FD5E10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600048B")]
		[Cpp2IlInjected.Address(RVA = "0x1FD6050", Offset = "0x1FD4650", VA = "0x181FD6050", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400026F")]
	private readonly PLCHFMGPMPF EGCCOKJIONM;

	[Cpp2IlInjected.Token(Token = "0x6000482")]
	[Cpp2IlInjected.Address(RVA = "0x958AF0", Offset = "0x9570F0", VA = "0x180958AF0")]
	public HEDIHINCIPG(PLCHFMGPMPF LGGGFEEKDDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000483")]
	[Cpp2IlInjected.Address(RVA = "0x1FCDD40", Offset = "0x1FCC340", VA = "0x181FCDD40")]
	[AsyncStateMachine(typeof(BLPIDNOLPFL))]
	private Task<CBDPDIPONCF<object, FBDDJIHDMAI>> FDGENAOKLLI(EIJGBFLAMII PEMICEIPPPL, bool FINFIEKODAH = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000484")]
	[Cpp2IlInjected.Address(RVA = "0x1FCDF60", Offset = "0x1FCC560", VA = "0x181FCDF60")]
	[AsyncStateMachine(typeof(LHNMOFMMDGN))]
	public Task<CBDPDIPONCF<bool, FBDDJIHDMAI?>>? NHFEJGMJIBM(int OLONDLMBCGF, EHHGJCHGBMN? GEIBOHFEECI, JJBCGHIHKLB? OMJCIEDKBFM, IOHGNKJIFDJ? KNMFEIKCDGI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000485")]
	[Cpp2IlInjected.Address(RVA = "0x1FCDE70", Offset = "0x1FCC470", VA = "0x181FCDE70")]
	[AsyncStateMachine(typeof(MMILLPLOAML))]
	public Task<CBDPDIPONCF<COKMANPFJNC, FBDDJIHDMAI>> IHOPKBJIMEI()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C0")]
public sealed class NKPNLGGFFOJ : JJFJBDJBODL, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000284")]
	private readonly ICCDGPHNGEH BGNKNHGEPMM;

	[Cpp2IlInjected.Token(Token = "0x170000A4")]
	public ICCDGPHNGEH FLGMCBGEDOL
	{
		[Cpp2IlInjected.Token(Token = "0x600048F")]
		[Cpp2IlInjected.Address(RVA = "0x868220", Offset = "0x866820", VA = "0x180868220", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600048C")]
	[Cpp2IlInjected.Address(RVA = "0x872130", Offset = "0x870730", VA = "0x180872130")]
	private NKPNLGGFFOJ(ICCDGPHNGEH FAPANDBPCNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048D")]
	[Cpp2IlInjected.Address(RVA = "0x1FDC8A0", Offset = "0x1FDAEA0", VA = "0x181FDC8A0")]
	public static NKPNLGGFFOJ OJPHNAHFOOE(PJNMBNAHIFL ALELNINOAGK, EHHGJCHGBMN DMLCBPHDENE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600048E")]
	[Cpp2IlInjected.Address(RVA = "0x1FDC880", Offset = "0x1FDAE80", VA = "0x181FDC880", Slot = "5")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C1")]
public interface JGOGPKBGDJJ : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x170000A5")]
	DDBLDNMCNDP KHJKLDCJFLC
	{
		[Cpp2IlInjected.Token(Token = "0x6000490")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A6")]
	AJNGKLOBPDA FGLFHDCOOPA
	{
		[Cpp2IlInjected.Token(Token = "0x6000491")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A7")]
	DMPGPAAEJAF GLKEIFIPMCA
	{
		[Cpp2IlInjected.Token(Token = "0x6000492")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A8")]
	KDAIKKDGJPC IACAOFPFCMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000493")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C2")]
public interface PKEFOPMHOCD : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x170000A9")]
	JGOGPKBGDJJ? DKGAHKAKKLD
	{
		[Cpp2IlInjected.Token(Token = "0x6000494")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000AA")]
	bool BGBBMOLNFII
	{
		[Cpp2IlInjected.Token(Token = "0x6000495")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000AB")]
	bool ADNHKDCFBHB
	{
		[Cpp2IlInjected.Token(Token = "0x6000496")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000497")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Task<JGOGPKBGDJJ?>? ECDFCGJKIKH();

	[Cpp2IlInjected.Token(Token = "0x6000498")]
	[Cpp2IlInjected.Address(Slot = "4")]
	Task OJLAJHNHBNB(PJNMBNAHIFL ALELNINOAGK, EHHGJCHGBMN DMLCBPHDENE, JJBCGHIHKLB? OKGEABKLJFB, IOHGNKJIFDJ? JGGJMHOEJAC);
}
[Cpp2IlInjected.Token(Token = "0x20000C3")]
[FNPBPKLPLIC("IStaticCV2Instance")]
public interface HFIAJFGBMJC : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x170000AC")]
	DDBLDNMCNDP KHJKLDCJFLC
	{
		[Cpp2IlInjected.Token(Token = "0x6000499")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C4")]
[FNPBPKLPLIC("IStaticEVInstance")]
public interface JJFJBDJBODL : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x170000AD")]
	ICCDGPHNGEH FLGMCBGEDOL
	{
		[Cpp2IlInjected.Token(Token = "0x600049A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C5")]
public static class JGEFMBHPBEI
{
	[Cpp2IlInjected.Token(Token = "0x600049B")]
	[Cpp2IlInjected.Address(RVA = "0x1FCE8E0", Offset = "0x1FCCEE0", VA = "0x181FCE8E0")]
	public static LCNOMMPGMCL<LKJBELODGDI, EIJGBFLAMII, PJNMBNAHIFL, JJGBIGJGLEO.DCMFKDFHIDD<LKJBELODGDI, EIJGBFLAMII, PJNMBNAHIFL>> LDCJJBGIDBC([In] this LCNOMMPGMCL<LKJBELODGDI, EIJGBFLAMII, PJNMBNAHIFL, JJGBIGJGLEO.DCMFKDFHIDD<LKJBELODGDI, EIJGBFLAMII, PJNMBNAHIFL>> PMFDAEILHAJ)
	{
		return default(LCNOMMPGMCL<LKJBELODGDI, EIJGBFLAMII, PJNMBNAHIFL, JJGBIGJGLEO.DCMFKDFHIDD<LKJBELODGDI, EIJGBFLAMII, PJNMBNAHIFL>>);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C6")]
public sealed class DCMAMDMEEGH : ENMHNBHKDNK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000285")]
	private readonly PJNMBNAHIFL NKJLAAKEIDF;

	[Cpp2IlInjected.Token(Token = "0x170000AE")]
	public bool ADNHKDCFBHB
	{
		[Cpp2IlInjected.Token(Token = "0x600049C")]
		[Cpp2IlInjected.Address(RVA = "0x1FC8870", Offset = "0x1FC6E70", VA = "0x181FC8870", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600049D")]
	[Cpp2IlInjected.Address(RVA = "0x872130", Offset = "0x870730", VA = "0x180872130")]
	internal DCMAMDMEEGH(PJNMBNAHIFL ALELNINOAGK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C7")]
internal sealed class BHNDPHMKPDJ : KGOGOKBEBFG
{
	[Cpp2IlInjected.Token(Token = "0x600049E")]
	[Cpp2IlInjected.Address(RVA = "0x1FC75A0", Offset = "0x1FC5BA0", VA = "0x181FC75A0", Slot = "4")]
	public BDNLPIDPGEP? KAPHPIOAFJF(string? KLMFGPBLIAH, string? LLEIDJFKJKD, string? MBKKABGIEBF, INGJBLBOFCA.ALMOKFDKNJI.EKMKDOMNDPI HOHOMAOMMMO, bool IPFAHKLONED)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600049F")]
	[Cpp2IlInjected.Address(RVA = "0x86C4B0", Offset = "0x86AAB0", VA = "0x18086C4B0")]
	public BHNDPHMKPDJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C8")]
public sealed class MMGFHDPCBNM : FEHAEHGEOOA
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000C9")]
	[CompilerGenerated]
	private struct DIDAKBKDHHG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000288")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000289")]
		public AsyncTaskMethodBuilder<LCKLOOAKLPO> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400028A")]
		public MMGFHDPCBNM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400028B")]
		private TaskAwaiter<JGOGPKBGDJJ?> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004A9")]
		[Cpp2IlInjected.Address(RVA = "0x1FC9270", Offset = "0x1FC7870", VA = "0x181FC9270", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004AA")]
		[Cpp2IlInjected.Address(RVA = "0x1FC9520", Offset = "0x1FC7B20", VA = "0x181FC9520", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000286")]
	private readonly PJNMBNAHIFL NKJLAAKEIDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000287")]
	private IReadOnlyList<HBIPEINCKFG<HCHFDOFEDKE>>? HMBHABFHADN;

	[Cpp2IlInjected.Token(Token = "0x170000AF")]
	public LCKLOOAKLPO? CFNNMJAMDBB
	{
		[Cpp2IlInjected.Token(Token = "0x60004A0")]
		[Cpp2IlInjected.Address(RVA = "0x1FD56D0", Offset = "0x1FD3CD0", VA = "0x181FD56D0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B0")]
	public KDAIKKDGJPC? JIGDDMPNFBI
	{
		[Cpp2IlInjected.Token(Token = "0x60004A1")]
		[Cpp2IlInjected.Address(RVA = "0x1FD53F0", Offset = "0x1FD39F0", VA = "0x181FD53F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B1")]
	public bool JELDILBNHOK
	{
		[Cpp2IlInjected.Token(Token = "0x60004A2")]
		[Cpp2IlInjected.Address(RVA = "0x1FD5CC0", Offset = "0x1FD42C0", VA = "0x181FD5CC0", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B2")]
	public bool FJHOLODKNPP
	{
		[Cpp2IlInjected.Token(Token = "0x60004A3")]
		[Cpp2IlInjected.Address(RVA = "0x1FD5670", Offset = "0x1FD3C70", VA = "0x181FD5670", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004A4")]
	[Cpp2IlInjected.Address(RVA = "0x872130", Offset = "0x870730", VA = "0x180872130")]
	internal MMGFHDPCBNM(PJNMBNAHIFL ALELNINOAGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A5")]
	[Cpp2IlInjected.Address(RVA = "0x1FD5D20", Offset = "0x1FD4320", VA = "0x181FD5D20", Slot = "7")]
	[AsyncStateMachine(typeof(DIDAKBKDHHG))]
	public Task<LCKLOOAKLPO> PNPCHIJKGAI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004A6")]
	[Cpp2IlInjected.Address(RVA = "0x1FD5750", Offset = "0x1FD3D50", VA = "0x181FD5750", Slot = "9")]
	public IReadOnlyDictionary<HBIPEINCKFG<NPIPKFBHIBO>, Guid> GJDCCKKDMPN(IEnumerable<LDEHKHFLDMK> AMJCKCKICPP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004A7")]
	[Cpp2IlInjected.Address(RVA = "0x1FD5470", Offset = "0x1FD3A70", VA = "0x181FD5470")]
	public CBDPDIPONCF<JAAJFBFPOEE, GJMJCOBOHDO> AIKAJLELGKC([In] JAAJFBFPOEE MDGPKFEIMNM, IEnumerable<LDEHKHFLDMK> GKFDPPMDGBE, int JENLNIEJHPK)
	{
		return default(CBDPDIPONCF<JAAJFBFPOEE, GJMJCOBOHDO>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004A8")]
	[Cpp2IlInjected.Address(RVA = "0x1FD5AC0", Offset = "0x1FD40C0", VA = "0x181FD5AC0", Slot = "8")]
	private CBDPDIPONCF<JAAJFBFPOEE, GJMJCOBOHDO> JIKAHNDMIIN([In] JAAJFBFPOEE MDGPKFEIMNM, IEnumerable<LDEHKHFLDMK> GKFDPPMDGBE, int JENLNIEJHPK)
	{
		return default(CBDPDIPONCF<JAAJFBFPOEE, GJMJCOBOHDO>);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CA")]
public sealed class KDAIKKDGJPC : LCKLOOAKLPO
{
	[Cpp2IlInjected.Token(Token = "0x20000CB")]
	internal static class PBIEGLMJAMK
	{
		[Cpp2IlInjected.Token(Token = "0x20000CC")]
		[CompilerGenerated]
		private sealed class NJKADEBBLOP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000294")]
			public DDBLDNMCNDP state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000295")]
			public JNLMEDOKAOJ spawnIntoGraph;

			[Cpp2IlInjected.Token(Token = "0x60004F1")]
			[Cpp2IlInjected.Address(RVA = "0x86C4B0", Offset = "0x86AAB0", VA = "0x18086C4B0")]
			public NJKADEBBLOP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004F2")]
			[Cpp2IlInjected.Address(RVA = "0x1FDC770", Offset = "0x1FDAD70", VA = "0x181FDC770")]
			internal bool DLKIPPAKBIG(IKGHPMJOIBK n)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000CD")]
		[CompilerGenerated]
		private sealed class NKFPDNHOKDF
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000296")]
			public int makerPenInteractionFilterKeyValue;

			[Cpp2IlInjected.Token(Token = "0x60004F3")]
			[Cpp2IlInjected.Address(RVA = "0x86C4B0", Offset = "0x86AAB0", VA = "0x18086C4B0")]
			public NKFPDNHOKDF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004F4")]
			[Cpp2IlInjected.Address(RVA = "0x1FDC860", Offset = "0x1FDAE60", VA = "0x181FDC860")]
			internal void PNCBMFJKAKJ(IKGHPMJOIBK n)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60004EB")]
		[Cpp2IlInjected.Address(RVA = "0x1FDF790", Offset = "0x1FDDD90", VA = "0x181FDF790")]
		public static CBDPDIPONCF<LCKLOOAKLPO.EKOLNIAAMLI, GGDFCMAGDGD> DKNNLLCHPCG(KDAIKKDGJPC HLIDMKMINHN, [In] LCKLOOAKLPO.POABJDOENPO CNKOAIGMGCF)
		{
			return default(CBDPDIPONCF<LCKLOOAKLPO.EKOLNIAAMLI, GGDFCMAGDGD>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004EC")]
		[Cpp2IlInjected.Address(RVA = "0x1FDE880", Offset = "0x1FDCE80", VA = "0x181FDE880")]
		internal static CBDPDIPONCF<(FEMCAPMOICI, IHPCFKGJNIN), GGDFCMAGDGD> CBDFLLIGDII(KDAIKKDGJPC HLIDMKMINHN, IHPCFKGJNIN HGDCEMPIHAM, bool CEPCJFJPBLI, [In] HBIPEINCKFG<NPIPKFBHIBO> JFLKCPBODMJ, [In] int? MIKCAPDAIKI, [In] KAFMIGBJCLH? JGFLAMMKGIA, [In] KAFMIGBJCLH? HJGEABGHCHH)
		{
			return default(CBDPDIPONCF<(FEMCAPMOICI, IHPCFKGJNIN), GGDFCMAGDGD>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004ED")]
		[Cpp2IlInjected.Address(RVA = "0x1FDFD20", Offset = "0x1FDE320", VA = "0x181FDFD20")]
		private static void HLHEHGJDKDE(bool CEPCJFJPBLI, LDEHKHFLDMK FJBKCCGEENF, FEMCAPMOICI PEKBLOCNDEK, [In] HBIPEINCKFG<NPIPKFBHIBO> JFLKCPBODMJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004EE")]
		[Cpp2IlInjected.Address(RVA = "0x1FE0160", Offset = "0x1FDE760", VA = "0x181FE0160")]
		public static void JHMHDGKCDIO(EGGNHEHGNIN KJLGLBHIMMA, [In] LCKLOOAKLPO.HAKCOFBDENB OHJAEOKLFJD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004EF")]
		[Cpp2IlInjected.Address(RVA = "0x1FDF6A0", Offset = "0x1FDDCA0", VA = "0x181FDF6A0")]
		[CompilerGenerated]
		internal static bool DAHKBJKFOII(DDBLDNMCNDP KIAANMHHMBN, JNLMEDOKAOJ DGMIPGLDMJE, IKGHPMJOIBK EJFEOAPFNNA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60004F0")]
		[Cpp2IlInjected.Address(RVA = "0x1FE0570", Offset = "0x1FDEB70", VA = "0x181FE0570")]
		[CompilerGenerated]
		internal static bool KOPOPIFCMPJ(IKGHPMJOIBK LFGGKMKJGKE)
		{
			return default(bool);
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000CF")]
	[CompilerGenerated]
	private struct OPLKPABFNJH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000299")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400029A")]
		public AsyncTaskMethodBuilder<CBDPDIPONCF<COKMANPFJNC, FBDDJIHDMAI>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400029B")]
		public KDAIKKDGJPC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400029C")]
		public CGBGMGFBCKF<NPIPKFBHIBO> graphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x400029D")]
		public CGBGMGFBCKF<FELHHAAOOHO> srcId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400029E")]
		public CGBGMGFBCKF<HHDHBHHIDEB> dstId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400029F")]
		private TaskAwaiter<CBDPDIPONCF<COKMANPFJNC, FBDDJIHDMAI>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004F8")]
		[Cpp2IlInjected.Address(RVA = "0x1FDE1C0", Offset = "0x1FDC7C0", VA = "0x181FDE1C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004F9")]
		[Cpp2IlInjected.Address(RVA = "0x1FDE810", Offset = "0x1FDCE10", VA = "0x181FDE810", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000D0")]
	[CompilerGenerated]
	private struct KBGFPNFCOFN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002A0")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002A1")]
		public AsyncTaskMethodBuilder<CBDPDIPONCF<COKMANPFJNC, FBDDJIHDMAI>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002A2")]
		public KDAIKKDGJPC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002A3")]
		public HBIPEINCKFG<JBMJEMLAFJB> inputNodeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002A4")]
		public HBIPEINCKFG<NPIPKFBHIBO> graphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002A5")]
		public CGBGMGFBCKF<HGFEOPBBPIG> inputPortGroupId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x40002A6")]
		public CGBGMGFBCKF<NLKCJCDLMOJ> inputId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40002A7")]
		private TaskAwaiter<CBDPDIPONCF<COKMANPFJNC, FBDDJIHDMAI>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004FA")]
		[Cpp2IlInjected.Address(RVA = "0x1FCED90", Offset = "0x1FCD390", VA = "0x181FCED90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004FB")]
		[Cpp2IlInjected.Address(RVA = "0x1FCF0D0", Offset = "0x1FCD6D0", VA = "0x181FCF0D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000D1")]
	[CompilerGenerated]
	private struct DNCHEKIGNKI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002A8")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002A9")]
		public AsyncTaskMethodBuilder<CBDPDIPONCF<COKMANPFJNC, FBDDJIHDMAI>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002AA")]
		public KDAIKKDGJPC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002AB")]
		public HBIPEINCKFG<JBMJEMLAFJB> outputNodeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002AC")]
		public HBIPEINCKFG<NPIPKFBHIBO> graphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002AD")]
		public CGBGMGFBCKF<HGFEOPBBPIG> outputPortGroupId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x40002AE")]
		public CGBGMGFBCKF<CPECOCNOBEE> outputId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40002AF")]
		private TaskAwaiter<CBDPDIPONCF<COKMANPFJNC, FBDDJIHDMAI>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004FC")]
		[Cpp2IlInjected.Address(RVA = "0x1FC9590", Offset = "0x1FC7B90", VA = "0x181FC9590", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004FD")]
		[Cpp2IlInjected.Address(RVA = "0x1FC98D0", Offset = "0x1FC7ED0", VA = "0x181FC98D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400028C")]
	private readonly PJNMBNAHIFL NKJLAAKEIDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400028D")]
	private readonly HFIAJFGBMJC CBEGFJIJEAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400028E")]
	private readonly JJFJBDJBODL KFMHBEFONIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400028F")]
	private readonly ALIEIFONOHB JCBECJGAKCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000290")]
	private readonly MMGFHDPCBNM OGIJEAFPAHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000291")]
	private Dictionary<HBIPEINCKFG<JBMJEMLAFJB>, INBEHHBGGBG> NIPBFDGEJKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000293")]
	[CompilerGenerated]
	private Action<HBIPEINCKFG<JBMJEMLAFJB>>? CEHIEGKIECK;

	[Cpp2IlInjected.Token(Token = "0x170000B3")]
	public HBIPEINCKFG<NPIPKFBHIBO> MHHEINBMPKF
	{
		[Cpp2IlInjected.Token(Token = "0x60004AB")]
		[Cpp2IlInjected.Address(RVA = "0x1FD03C0", Offset = "0x1FCE9C0", VA = "0x181FD03C0", Slot = "4")]
		get
		{
			return default(HBIPEINCKFG<NPIPKFBHIBO>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B4")]
	public ALIEIFONOHB ADOOGPDPIME
	{
		[Cpp2IlInjected.Token(Token = "0x60004AC")]
		[Cpp2IlInjected.Address(RVA = "0x1FC4550", Offset = "0x1FC2B50", VA = "0x181FC4550", Slot = "5")]
		get
		{
			return default(ALIEIFONOHB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004AD")]
	[Cpp2IlInjected.Address(RVA = "0x1FD31F0", Offset = "0x1FD17F0", VA = "0x181FD31F0")]
	public KDAIKKDGJPC(PJNMBNAHIFL ALELNINOAGK, HFIAJFGBMJC LDELOABMCDO, JJFJBDJBODL EHJLLLOAOFJ, MMGFHDPCBNM IDEADFGFBBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004AE")]
	[Cpp2IlInjected.Address(RVA = "0x1FD0DF0", Offset = "0x1FCF3F0", VA = "0x181FD0DF0", Slot = "41")]
	public CGBGMGFBCKF<DBIPPKJLLJH> JFLIANFKMPA(CGBGMGFBCKF<NPIPKFBHIBO> EHLNCLBLNMA, CGBGMGFBCKF<HHDHBHHIDEB> BEHIJEKELGM)
	{
		return default(CGBGMGFBCKF<DBIPPKJLLJH>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004AF")]
	[Cpp2IlInjected.Address(RVA = "0x1FD1B90", Offset = "0x1FD0190", VA = "0x181FD1B90", Slot = "42")]
	public CGBGMGFBCKF<DNPEBGLPOMO> LMHMCDABJIO(CGBGMGFBCKF<NPIPKFBHIBO> EHLNCLBLNMA, CGBGMGFBCKF<FELHHAAOOHO> PDHFLBHDHCA)
	{
		return default(CGBGMGFBCKF<DNPEBGLPOMO>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004B0")]
	[Cpp2IlInjected.Address(RVA = "0x1FD1720", Offset = "0x1FCFD20", VA = "0x181FD1720", Slot = "6")]
	public bool KLPHICGKACO(CGBGMGFBCKF<NPIPKFBHIBO> EHLNCLBLNMA, CGBGMGFBCKF<FELHHAAOOHO> LIOCIKIPKPI, CGBGMGFBCKF<HHDHBHHIDEB> ADCFLPJKMEF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004B1")]
	[Cpp2IlInjected.Address(RVA = "0x1FD2DB0", Offset = "0x1FD13B0", VA = "0x181FD2DB0")]
	public bool PEEANLPMILD(CGBGMGFBCKF<NPIPKFBHIBO> EHLNCLBLNMA, [In] HOBJKJIDHGO KEJKIDCGMCI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004B2")]
	[Cpp2IlInjected.Address(RVA = "0x1FD15B0", Offset = "0x1FCFBB0", VA = "0x181FD15B0", Slot = "8")]
	public bool KJAGCFMAMHA(PGFKPKOPNBP ONDOGKFOANO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004B3")]
	[Cpp2IlInjected.Address(RVA = "0x1FD0340", Offset = "0x1FCE940", VA = "0x181FD0340", Slot = "9")]
	public bool ECDBAPAAGHC(EEBGPMMBBHA ADABOHPHOEH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004B4")]
	[Cpp2IlInjected.Address(RVA = "0x1FD2A80", Offset = "0x1FD1080", VA = "0x181FD2A80")]
	public INBEHHBGGBG? NPLKNABEGGJ([In] HBIPEINCKFG<JBMJEMLAFJB> CNJMIDDPAFB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004B5")]
	[Cpp2IlInjected.Address(RVA = "0x1FD1C10", Offset = "0x1FD0210", VA = "0x181FD1C10")]
	public CGBGMGFBCKF<JBMJEMLAFJB> LMIACBHPOCI(CGBGMGFBCKF<NPIPKFBHIBO> EHLNCLBLNMA, [In] HBIPEINCKFG<JBMJEMLAFJB> ONEGIKMCBHN)
	{
		return default(CGBGMGFBCKF<JBMJEMLAFJB>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004B6")]
	[Cpp2IlInjected.Address(RVA = "0x1FD01C0", Offset = "0x1FCE7C0", VA = "0x181FD01C0", Slot = "20")]
	public CGBGMGFBCKF<JBMJEMLAFJB> DODANDPDNGG(CGBGMGFBCKF<NPIPKFBHIBO> EHLNCLBLNMA, CGBGMGFBCKF<HHDHBHHIDEB> BEHIJEKELGM)
	{
		return default(CGBGMGFBCKF<JBMJEMLAFJB>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004B7")]
	[Cpp2IlInjected.Address(RVA = "0x1FD1630", Offset = "0x1FCFC30", VA = "0x181FD1630", Slot = "21")]
	public CGBGMGFBCKF<JBMJEMLAFJB> KKAMMLDFOBN(CGBGMGFBCKF<NPIPKFBHIBO> EHLNCLBLNMA, CGBGMGFBCKF<FELHHAAOOHO> PDHFLBHDHCA)
	{
		return default(CGBGMGFBCKF<JBMJEMLAFJB>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004B8")]
	[Cpp2IlInjected.Address(RVA = "0x1FD0A90", Offset = "0x1FCF090", VA = "0x181FD0A90")]
	private void HADAONJEAKO(HBIPEINCKFG<JBMJEMLAFJB> CNJMIDDPAFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B9")]
	[Cpp2IlInjected.Address(RVA = "0x1FCF7D0", Offset = "0x1FCDDD0", VA = "0x181FCF7D0")]
	public IEnumerable<INBEHHBGGBG> AMBKEGCCJPN([In] HBIPEINCKFG<NPIPKFBHIBO> EHLNCLBLNMA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004BA")]
	[Cpp2IlInjected.Address(RVA = "0x1FCFA20", Offset = "0x1FCE020", VA = "0x181FCFA20", Slot = "19")]
	public CGBGMGFBCKF<HHDHBHHIDEB> CBCFOFLDCHC(CGBGMGFBCKF<NPIPKFBHIBO> EHLNCLBLNMA, CGBGMGFBCKF<JBMJEMLAFJB> CNJMIDDPAFB, CGBGMGFBCKF<DBIPPKJLLJH> AFHHNDIHHIG)
	{
		return default(CGBGMGFBCKF<HHDHBHHIDEB>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004BB")]
	[Cpp2IlInjected.Address(RVA = "0x1FCFBD0", Offset = "0x1FCE1D0", VA = "0x181FCFBD0", Slot = "22")]
	public CGBGMGFBCKF<FELHHAAOOHO> CEKICAKAMOP(CGBGMGFBCKF<NPIPKFBHIBO> EHLNCLBLNMA, CGBGMGFBCKF<JBMJEMLAFJB> CNJMIDDPAFB, CGBGMGFBCKF<DNPEBGLPOMO> GMIICDFKBBD)
	{
		return default(CGBGMGFBCKF<FELHHAAOOHO>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004BC")]
	[Cpp2IlInjected.Address(RVA = "0x1FD0420", Offset = "0x1FCEA20", VA = "0x181FD0420")]
	private INBEHHBGGBG? FNDFGGBGNPL([In] HBIPEINCKFG<JBMJEMLAFJB> CNJMIDDPAFB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004BD")]
	[Cpp2IlInjected.Address(RVA = "0x1FD0900", Offset = "0x1FCEF00", VA = "0x181FD0900")]
	private INBEHHBGGBG GBLNFDDAMHK([In] HBIPEINCKFG<JBMJEMLAFJB> CNJMIDDPAFB, JJAEOPCJMCB EMDFCFPCFGG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004BE")]
	[Cpp2IlInjected.Address(RVA = "0x1FD0B90", Offset = "0x1FCF190", VA = "0x181FD0B90")]
	public JJAEOPCJMCB? IBBGBBFIDMO([In] HBIPEINCKFG<JBMJEMLAFJB> CNJMIDDPAFB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004BF")]
	[Cpp2IlInjected.Address(RVA = "0x1FCF5C0", Offset = "0x1FCDBC0", VA = "0x181FCF5C0")]
	public BGIBPOPOOLN? IGAADMLPECB([In] HBIPEINCKFG<NPIPKFBHIBO> EHLNCLBLNMA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004C0")]
	[Cpp2IlInjected.Address(RVA = "0x1FCFB10", Offset = "0x1FCE110", VA = "0x181FCFB10", Slot = "15")]
	public IEnumerable<EJKPMMNHGEK> CEGCJIEDCIH(CGBGMGFBCKF<NPIPKFBHIBO> EHLNCLBLNMA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004C1")]
	[Cpp2IlInjected.Address(RVA = "0x1FCFCE0", Offset = "0x1FCE2E0", VA = "0x181FCFCE0", Slot = "16")]
	public IEnumerable<HOBJKJIDHGO> CHMCKPKIMGG(CGBGMGFBCKF<NPIPKFBHIBO> EHLNCLBLNMA, CGBGMGFBCKF<FELHHAAOOHO> LIOCIKIPKPI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004C2")]
	[Cpp2IlInjected.Address(RVA = "0x1FD0E70", Offset = "0x1FCF470", VA = "0x181FD0E70", Slot = "17")]
	public IEnumerable<HOBJKJIDHGO> JLFFIDCBNIF(CGBGMGFBCKF<NPIPKFBHIBO> EHLNCLBLNMA, CGBGMGFBCKF<HHDHBHHIDEB> ADCFLPJKMEF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004C3")]
	[Cpp2IlInjected.Address(RVA = "0x1FD0C20", Offset = "0x1FCF220", VA = "0x181FD0C20")]
	public CGBGMGFBCKF<NPIPKFBHIBO> MBHPLAANBAA([In] HBIPEINCKFG<NPIPKFBHIBO> EHLNCLBLNMA)
	{
		return default(CGBGMGFBCKF<NPIPKFBHIBO>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004C4")]
	[Cpp2IlInjected.Address(RVA = "0x1FCF5F0", Offset = "0x1FCDBF0", VA = "0x181FCF5F0")]
	public CGBGMGFBCKF<NPIPKFBHIBO>? LBNJNABBGME([In] HBIPEINCKFG<NPIPKFBHIBO> EHLNCLBLNMA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004C5")]
	[Cpp2IlInjected.Address(RVA = "0x1FD09D0", Offset = "0x1FCEFD0", VA = "0x181FD09D0")]
	private JNLMEDOKAOJ? GKEFEFIBDFC([In] HBIPEINCKFG<NPIPKFBHIBO> EHLNCLBLNMA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004C6")]
	[Cpp2IlInjected.Address(RVA = "0x1FCF5C0", Offset = "0x1FCDBC0", VA = "0x181FCF5C0")]
	private BGIBPOPOOLN? EADBBGPJOOP([In] HBIPEINCKFG<NPIPKFBHIBO> EHLNCLBLNMA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004C7")]
	[Cpp2IlInjected.Address(RVA = "0x1FD0B20", Offset = "0x1FCF120", VA = "0x181FD0B20", Slot = "26")]
	public HBIPEINCKFG<NPIPKFBHIBO> HCHPFHKJKJE(CGBGMGFBCKF<NPIPKFBHIBO> EHLNCLBLNMA)
	{
		return default(HBIPEINCKFG<NPIPKFBHIBO>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004C8")]
	[Cpp2IlInjected.Address(RVA = "0x1FD13C0", Offset = "0x1FCF9C0", VA = "0x181FD13C0", Slot = "23")]
	public IEnumerable<GPEGJBGOEPB> KFHNGEIEIGI(FMLMFCLNNJC GGIELKFPGAC, bool GMMEANDEEKJ, bool ABLDJNLDHEM, bool FMJCNGAJNGL, bool LCNAMAGFBFK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004C9")]
	[Cpp2IlInjected.Address(RVA = "0x1FD2780", Offset = "0x1FD0D80", VA = "0x181FD2780", Slot = "24")]
	public GPEGJBGOEPB NNANAPPFOMH(FMLMFCLNNJC GGIELKFPGAC, GFPIIFJFFHL PPJPJCJKKKP, bool GMMEANDEEKJ, bool ABLDJNLDHEM, bool FMJCNGAJNGL, bool LCNAMAGFBFK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004CA")]
	[Cpp2IlInjected.Address(RVA = "0x1FCF8B0", Offset = "0x1FCDEB0", VA = "0x181FCF8B0")]
	public EJKPMMNHGEK HHHMNFCOOCO(CGBGMGFBCKF<NPIPKFBHIBO> EHLNCLBLNMA, [In] HOBJKJIDHGO KEJKIDCGMCI)
	{
		return default(EJKPMMNHGEK);
	}

	[Cpp2IlInjected.Token(Token = "0x60004CB")]
	[Cpp2IlInjected.Address(RVA = "0x1FD2B80", Offset = "0x1FD1180", VA = "0x181FD2B80", Slot = "27")]
	public HOBJKJIDHGO OOCKIDBKMIC(CGBGMGFBCKF<NPIPKFBHIBO> EHLNCLBLNMA, CGBGMGFBCKF<FELHHAAOOHO> LIOCIKIPKPI, CGBGMGFBCKF<HHDHBHHIDEB> ADCFLPJKMEF)
	{
		return default(HOBJKJIDHGO);
	}

	[Cpp2IlInjected.Token(Token = "0x60004CC")]
	[Cpp2IlInjected.Address(RVA = "0x1FD16B0", Offset = "0x1FCFCB0", VA = "0x181FD16B0", Slot = "28")]
	public bool KKNEFDBOKNF(CGBGMGFBCKF<NPIPKFBHIBO> EHLNCLBLNMA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004CD")]
	[Cpp2IlInjected.Address(RVA = "0x1FCFC60", Offset = "0x1FCE260", VA = "0x181FCFC60", Slot = "29")]
	public bool CFFDOCCOPME(CGBGMGFBCKF<NPIPKFBHIBO> EHLNCLBLNMA, CGBGMGFBCKF<HHDHBHHIDEB> BEHIJEKELGM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004CE")]
	[Cpp2IlInjected.Address(RVA = "0x1FD1340", Offset = "0x1FCF940", VA = "0x181FD1340", Slot = "30")]
	public bool KAFGLOGKFGL(CGBGMGFBCKF<NPIPKFBHIBO> EHLNCLBLNMA, CGBGMGFBCKF<FELHHAAOOHO> PDHFLBHDHCA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004CF")]
	[Cpp2IlInjected.Address(RVA = "0x1FD21E0", Offset = "0x1FD07E0", VA = "0x181FD21E0")]
	public CBDPDIPONCF<LCKLOOAKLPO.EKOLNIAAMLI, GGDFCMAGDGD> MLMHOAHMBGF([In] LCKLOOAKLPO.POABJDOENPO CNKOAIGMGCF)
	{
		return default(CBDPDIPONCF<LCKLOOAKLPO.EKOLNIAAMLI, GGDFCMAGDGD>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004D0")]
	[Cpp2IlInjected.Address(RVA = "0x1FD10F0", Offset = "0x1FCF6F0", VA = "0x181FD10F0", Slot = "32")]
	[AsyncStateMachine(typeof(OPLKPABFNJH))]
	public Task<CBDPDIPONCF<COKMANPFJNC, FBDDJIHDMAI>> JPABFPBKFNB(CGBGMGFBCKF<NPIPKFBHIBO> EHLNCLBLNMA, CGBGMGFBCKF<FELHHAAOOHO> LIOCIKIPKPI, CGBGMGFBCKF<HHDHBHHIDEB> ADCFLPJKMEF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004D1")]
	[Cpp2IlInjected.Address(RVA = "0x1FCF140", Offset = "0x1FCD740", VA = "0x181FCF140", Slot = "33")]
	public CBDPDIPONCF<LMACGBMEBFC, GJMJCOBOHDO> AGLPBGFEMCC(HBIPEINCKFG<NPIPKFBHIBO> EHLNCLBLNMA, LMACGBMEBFC ILKBIMMGPDO, PBDCHDIIPAE HOIGIFJIPOO)
	{
		return default(CBDPDIPONCF<LMACGBMEBFC, GJMJCOBOHDO>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004D2")]
	[Cpp2IlInjected.Address(RVA = "0x1FCF670", Offset = "0x1FCDC70", VA = "0x181FCF670", Slot = "34")]
	[AsyncStateMachine(typeof(KBGFPNFCOFN))]
	public Task<CBDPDIPONCF<COKMANPFJNC, FBDDJIHDMAI>> ALHDKGFOLIN(HBIPEINCKFG<NPIPKFBHIBO> EHLNCLBLNMA, HBIPEINCKFG<JBMJEMLAFJB> MLCHFFOCOFN, CGBGMGFBCKF<HGFEOPBBPIG> DKMJAJKHKBP, CGBGMGFBCKF<NLKCJCDLMOJ> BEHIJEKELGM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004D3")]
	[Cpp2IlInjected.Address(RVA = "0x1FCFF70", Offset = "0x1FCE570", VA = "0x181FCFF70", Slot = "35")]
	[AsyncStateMachine(typeof(DNCHEKIGNKI))]
	public Task<CBDPDIPONCF<COKMANPFJNC, FBDDJIHDMAI>> DAPGCJJHNEG(HBIPEINCKFG<NPIPKFBHIBO> EHLNCLBLNMA, HBIPEINCKFG<JBMJEMLAFJB> JJKJJFCBAOG, CGBGMGFBCKF<HGFEOPBBPIG> LECEEDHKHAI, CGBGMGFBCKF<CPECOCNOBEE> PDHFLBHDHCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004D4")]
	[Cpp2IlInjected.Address(RVA = "0x1FD2590", Offset = "0x1FD0B90", VA = "0x181FD2590", Slot = "36")]
	public CPODEIGKFAA NAPKJFNMCNA(IEnumerable<LDEHKHFLDMK> GKFDPPMDGBE)
	{
		return default(CPODEIGKFAA);
	}

	[Cpp2IlInjected.Token(Token = "0x60004D5")]
	[Cpp2IlInjected.Address(RVA = "0x1FD1220", Offset = "0x1FCF820", VA = "0x181FD1220", Slot = "37")]
	public CPODEIGKFAA JPCLEEEKADO()
	{
		return default(CPODEIGKFAA);
	}

	[Cpp2IlInjected.Token(Token = "0x60004D6")]
	[Cpp2IlInjected.Address(RVA = "0x1FD1CF0", Offset = "0x1FD02F0", VA = "0x181FD1CF0")]
	private LFGNEHMEKOI MFDDJKFMBAN(GECOPOBPOFG JJCNIIKKOMD, CGBGMGFBCKF<NPIPKFBHIBO> BOCKLOLBFPI, IEnumerable<HBIPEINCKFG<NPIPKFBHIBO>> GNDODMLJJFK, IEnumerable<HBIPEINCKFG<JBMJEMLAFJB>> ABBGIBAIGDN)
	{
		return default(LFGNEHMEKOI);
	}

	[Cpp2IlInjected.Token(Token = "0x60004D7")]
	[Cpp2IlInjected.Address(RVA = "0x1FD1EA0", Offset = "0x1FD04A0", VA = "0x181FD1EA0", Slot = "38")]
	public LFGNEHMEKOI MFDDJKFMBAN(GECOPOBPOFG JJCNIIKKOMD, CGBGMGFBCKF<NPIPKFBHIBO> BOCKLOLBFPI, IEnumerable<HBIPEINCKFG<JBMJEMLAFJB>> ABBGIBAIGDN, IEnumerable<LDEHKHFLDMK> GKFDPPMDGBE)
	{
		return default(LFGNEHMEKOI);
	}

	[Cpp2IlInjected.Token(Token = "0x60004D8")]
	[Cpp2IlInjected.Address(RVA = "0x1FD2210", Offset = "0x1FD0810", VA = "0x181FD2210")]
	private static IEnumerable<HBIPEINCKFG<NPIPKFBHIBO>> NAAGMLMHKDB(IEnumerable<LDEHKHFLDMK> GKFDPPMDGBE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004D9")]
	[Cpp2IlInjected.Address(RVA = "0x1FD0460", Offset = "0x1FCEA60", VA = "0x181FD0460")]
	private IEnumerable<HBIPEINCKFG<JBMJEMLAFJB>> FOGLDKMKJFG(IEnumerable<LDEHKHFLDMK> GKFDPPMDGBE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004DA")]
	[Cpp2IlInjected.Address(RVA = "0x1FCF530", Offset = "0x1FCDB30", VA = "0x181FCF530", Slot = "39")]
	public List<OIJNDBNCGHL> AHEAEMABGBF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004DB")]
	[Cpp2IlInjected.Address(RVA = "0x1FD3100", Offset = "0x1FD1700", VA = "0x181FD3100", Slot = "40")]
	public bool PEGOFPMDMIH(CGBGMGFBCKF<NPIPKFBHIBO> EHLNCLBLNMA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004DC")]
	[Cpp2IlInjected.Address(RVA = "0x1FD1C90", Offset = "0x1FD0290", VA = "0x181FD1C90")]
	internal void LNLGLGMMCEN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004DD")]
	[Cpp2IlInjected.Address(RVA = "0x1FCFAB0", Offset = "0x1FCE0B0", VA = "0x181FCFAB0")]
	internal Task CDHIKDDALPI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004DE")]
	[Cpp2IlInjected.Address(RVA = "0x1FD0240", Offset = "0x1FCE840", VA = "0x181FD0240", Slot = "7")]
	private bool DPAOJAGCACN(CGBGMGFBCKF<NPIPKFBHIBO> EHLNCLBLNMA, [In] HOBJKJIDHGO KEJKIDCGMCI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004DF")]
	[Cpp2IlInjected.Address(RVA = "0x1FCF5C0", Offset = "0x1FCDBC0", VA = "0x181FCF5C0", Slot = "10")]
	private BGIBPOPOOLN AIFKNBLPFDA([In] HBIPEINCKFG<NPIPKFBHIBO> EHLNCLBLNMA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E0")]
	[Cpp2IlInjected.Address(RVA = "0x1FD0C20", Offset = "0x1FCF220", VA = "0x181FD0C20", Slot = "11")]
	private CGBGMGFBCKF<NPIPKFBHIBO> IECBIGKFCPG([In] HBIPEINCKFG<NPIPKFBHIBO> EHLNCLBLNMA)
	{
		return default(CGBGMGFBCKF<NPIPKFBHIBO>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004E1")]
	[Cpp2IlInjected.Address(RVA = "0x1FCF5F0", Offset = "0x1FCDBF0", VA = "0x181FCF5F0", Slot = "12")]
	private CGBGMGFBCKF<NPIPKFBHIBO>? AKFFGDFHFON([In] HBIPEINCKFG<NPIPKFBHIBO> EHLNCLBLNMA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E2")]
	[Cpp2IlInjected.Address(RVA = "0x1FD00D0", Offset = "0x1FCE6D0", VA = "0x181FD00D0", Slot = "13")]
	private INBEHHBGGBG DHCPPHOPAEK([In] HBIPEINCKFG<JBMJEMLAFJB> CNJMIDDPAFB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E3")]
	[Cpp2IlInjected.Address(RVA = "0x1FD1C10", Offset = "0x1FD0210", VA = "0x181FD1C10", Slot = "14")]
	private CGBGMGFBCKF<JBMJEMLAFJB> MMOGHGCIJMH(CGBGMGFBCKF<NPIPKFBHIBO> EHLNCLBLNMA, [In] HBIPEINCKFG<JBMJEMLAFJB> ONEGIKMCBHN)
	{
		return default(CGBGMGFBCKF<JBMJEMLAFJB>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004E4")]
	[Cpp2IlInjected.Address(RVA = "0x1FD0D10", Offset = "0x1FCF310", VA = "0x181FD0D10", Slot = "18")]
	private IEnumerable<INBEHHBGGBG> IMOEBCBPHJI([In] HBIPEINCKFG<NPIPKFBHIBO> EHLNCLBLNMA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E5")]
	[Cpp2IlInjected.Address(RVA = "0x1FCF8B0", Offset = "0x1FCDEB0", VA = "0x181FCF8B0", Slot = "25")]
	private EJKPMMNHGEK AMCEPOCILGO(CGBGMGFBCKF<NPIPKFBHIBO> EHLNCLBLNMA, [In] HOBJKJIDHGO KEJKIDCGMCI)
	{
		return default(EJKPMMNHGEK);
	}

	[Cpp2IlInjected.Token(Token = "0x60004E6")]
	[Cpp2IlInjected.Address(RVA = "0x1FD21E0", Offset = "0x1FD07E0", VA = "0x181FD21E0", Slot = "31")]
	private CBDPDIPONCF<LCKLOOAKLPO.EKOLNIAAMLI, GGDFCMAGDGD> OECCKKNLCLO([In] LCKLOOAKLPO.POABJDOENPO CNKOAIGMGCF)
	{
		return default(CBDPDIPONCF<LCKLOOAKLPO.EKOLNIAAMLI, GGDFCMAGDGD>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004E7")]
	[Cpp2IlInjected.Address(RVA = "0x1FD14C0", Offset = "0x1FCFAC0", VA = "0x181FD14C0")]
	[CompilerGenerated]
	private INBEHHBGGBG KHIMLNBEJKN(JJAEOPCJMCB BILDLIKNGJF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E8")]
	[Cpp2IlInjected.Address(RVA = "0x1FD0250", Offset = "0x1FCE850", VA = "0x181FD0250")]
	[CompilerGenerated]
	private LEBEEIAPMIP EAGGFLMLNCJ(MBGGCGEEENC BILDLIKNGJF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E9")]
	[Cpp2IlInjected.Address(RVA = "0x1FD0CA0", Offset = "0x1FCF2A0", VA = "0x181FD0CA0")]
	[CompilerGenerated]
	private JJAEOPCJMCB IMKIOLMOLJB(HBIPEINCKFG<JBMJEMLAFJB> BILDLIKNGJF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004EA")]
	[Cpp2IlInjected.Address(RVA = "0x1FD02D0", Offset = "0x1FCE8D0", VA = "0x181FD02D0")]
	[CompilerGenerated]
	private JNLMEDOKAOJ EBMKPLHJKEE(HBIPEINCKFG<NPIPKFBHIBO> BILDLIKNGJF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D2")]
public sealed class LEBEEIAPMIP : GPEGJBGOEPB
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000D3")]
	[CompilerGenerated]
	private struct DMKLGCMKBNC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002B3")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002B4")]
		public AsyncTaskMethodBuilder<CBDPDIPONCF<CGBGMGFBCKF<JJKDMNECOCJ>, FBDDJIHDMAI>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002B5")]
		public LEBEEIAPMIP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002B6")]
		public HBIPEINCKFG<NPIPKFBHIBO> graphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002B7")]
		public HBIPEINCKFG<JBMJEMLAFJB> nodeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002B8")]
		public CGBGMGFBCKF<HGFEOPBBPIG> portGroupId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40002B9")]
		public string name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40002BA")]
		private TaskAwaiter<CBDPDIPONCF<CGBGMGFBCKF<JJKDMNECOCJ>, FBDDJIHDMAI>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000504")]
		[Cpp2IlInjected.Address(RVA = "0x1FE30F0", Offset = "0x1FE16F0", VA = "0x181FE30F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000505")]
		[Cpp2IlInjected.Address(RVA = "0x1FE3370", Offset = "0x1FE1970", VA = "0x181FE3370", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000D4")]
	[CompilerGenerated]
	private struct HFHJLGJMINM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002BB")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002BC")]
		public AsyncTaskMethodBuilder<CBDPDIPONCF<CGBGMGFBCKF<FLNLEKBDPAB>, FBDDJIHDMAI>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002BD")]
		public LEBEEIAPMIP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002BE")]
		public HBIPEINCKFG<NPIPKFBHIBO> graphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002BF")]
		public HBIPEINCKFG<JBMJEMLAFJB> nodeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002C0")]
		public CGBGMGFBCKF<HGFEOPBBPIG> portGroupId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40002C1")]
		public string name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40002C2")]
		private TaskAwaiter<CBDPDIPONCF<CGBGMGFBCKF<FLNLEKBDPAB>, FBDDJIHDMAI>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000506")]
		[Cpp2IlInjected.Address(RVA = "0x1FE3630", Offset = "0x1FE1C30", VA = "0x181FE3630", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000507")]
		[Cpp2IlInjected.Address(RVA = "0x1FE38B0", Offset = "0x1FE1EB0", VA = "0x181FE38B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002B0")]
	private readonly MBGGCGEEENC ANFBKNDKCNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002B1")]
	private readonly HFIAJFGBMJC CBEGFJIJEAA;

	[Cpp2IlInjected.Token(Token = "0x170000B5")]
	public TypeKey NCPMMHLMHOA
	{
		[Cpp2IlInjected.Token(Token = "0x60004FF")]
		[Cpp2IlInjected.Address(RVA = "0x8F0D30", Offset = "0x8EF330", VA = "0x1808F0D30", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(TypeKey);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B6")]
	public string BJIKOEMLOPD
	{
		[Cpp2IlInjected.Token(Token = "0x6000500")]
		[Cpp2IlInjected.Address(RVA = "0x1FD40E0", Offset = "0x1FD26E0", VA = "0x181FD40E0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B7")]
	public MBGGCGEEENC AHPOIBMAKNE
	{
		[Cpp2IlInjected.Token(Token = "0x6000501")]
		[Cpp2IlInjected.Address(RVA = "0x868220", Offset = "0x866820", VA = "0x180868220")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004FE")]
	[Cpp2IlInjected.Address(RVA = "0x1FD43F0", Offset = "0x1FD29F0", VA = "0x181FD43F0")]
	public LEBEEIAPMIP(MBGGCGEEENC NPOOIAJJIAO, HFIAJFGBMJC LDELOABMCDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000502")]
	[Cpp2IlInjected.Address(RVA = "0x1FD4280", Offset = "0x1FD2880", VA = "0x181FD4280", Slot = "6")]
	[AsyncStateMachine(typeof(DMKLGCMKBNC))]
	public Task<CBDPDIPONCF<CGBGMGFBCKF<JJKDMNECOCJ>, FBDDJIHDMAI>> OKMPJKFDIMK(HBIPEINCKFG<NPIPKFBHIBO> EHLNCLBLNMA, HBIPEINCKFG<JBMJEMLAFJB> CNJMIDDPAFB, CGBGMGFBCKF<HGFEOPBBPIG> GKEOEKGAILK, string GJEDHMJMNJA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000503")]
	[Cpp2IlInjected.Address(RVA = "0x1FD4110", Offset = "0x1FD2710", VA = "0x181FD4110", Slot = "7")]
	[AsyncStateMachine(typeof(HFHJLGJMINM))]
	public Task<CBDPDIPONCF<CGBGMGFBCKF<FLNLEKBDPAB>, FBDDJIHDMAI>> EEDLDIDDFIN(HBIPEINCKFG<NPIPKFBHIBO> EHLNCLBLNMA, HBIPEINCKFG<JBMJEMLAFJB> CNJMIDDPAFB, CGBGMGFBCKF<HGFEOPBBPIG> GKEOEKGAILK, string GJEDHMJMNJA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D5")]
public sealed class LMKMNJCAEMF : JFHMPAIIPCH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002C3")]
	private readonly MBGGCGEEENC HCHBBIIKJDJ;

	[Cpp2IlInjected.Token(Token = "0x40002C4")]
	private static readonly HashSet<MBGGCGEEENC> NKHEOIAGCOM;

	[Cpp2IlInjected.Token(Token = "0x40002C5")]
	private static readonly HashSet<MBGGCGEEENC> BEIMDIHAFCO;

	[Cpp2IlInjected.Token(Token = "0x40002C6")]
	private static readonly HashSet<MBGGCGEEENC> KKMPKALLFAI;

	[Cpp2IlInjected.Token(Token = "0x170000B8")]
	public TypeKey EHBGNDCNEJA
	{
		[Cpp2IlInjected.Token(Token = "0x6000508")]
		[Cpp2IlInjected.Address(RVA = "0x1FE52F0", Offset = "0x1FE38F0", VA = "0x181FE52F0", Slot = "6")]
		get
		{
			return default(TypeKey);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B9")]
	public bool KKHFHODDCEP
	{
		[Cpp2IlInjected.Token(Token = "0x6000509")]
		[Cpp2IlInjected.Address(RVA = "0x1FE52E0", Offset = "0x1FE38E0", VA = "0x181FE52E0", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BA")]
	public bool NEFGJOFNAIC
	{
		[Cpp2IlInjected.Token(Token = "0x600050D")]
		[Cpp2IlInjected.Address(RVA = "0x1FE54B0", Offset = "0x1FE3AB0", VA = "0x181FE54B0", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BB")]
	public bool NEIAEIHBHPE
	{
		[Cpp2IlInjected.Token(Token = "0x600050E")]
		[Cpp2IlInjected.Address(RVA = "0x1FE5260", Offset = "0x1FE3860", VA = "0x181FE5260", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600050A")]
	[Cpp2IlInjected.Address(RVA = "0x1FE3DE0", Offset = "0x1FE23E0", VA = "0x181FE3DE0")]
	public bool DDJKHJNFBHF(string DMNGPNKHPKF, [Out] IDOPCFOAAJL LFODGFACIGH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600050B")]
	[Cpp2IlInjected.Address(RVA = "0x872130", Offset = "0x870730", VA = "0x180872130")]
	public LMKMNJCAEMF(MBGGCGEEENC AKLCDEBLEOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600050C")]
	[Cpp2IlInjected.Address(RVA = "0x1FE3FE0", Offset = "0x1FE25E0", VA = "0x181FE3FE0")]
	internal static TypeKey NDPECDEKPBE(MBGGCGEEENC GOAECDHCJMK)
	{
		return default(TypeKey);
	}

	[Cpp2IlInjected.Token(Token = "0x600050F")]
	[Cpp2IlInjected.Address(RVA = "0x1FD40E0", Offset = "0x1FD26E0", VA = "0x181FD40E0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000D6")]
public readonly struct KELFNBMMGFB : KLDPKNMOOBM.NIFGKHGODDN<EIJGBFLAMII, COKMANPFJNC>
{
	[Cpp2IlInjected.Token(Token = "0x6000511")]
	[Cpp2IlInjected.Address(RVA = "0x1FE3C40", Offset = "0x1FE2240", VA = "0x181FE3C40", Slot = "4")]
	public int FNJMBIPMFCO(COKMANPFJNC INKFLMKONLP, EIJGBFLAMII PEMICEIPPPL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000512")]
	[Cpp2IlInjected.Address(RVA = "0x1FE3BF0", Offset = "0x1FE21F0", VA = "0x181FE3BF0", Slot = "5")]
	public EIJGBFLAMII FEFOHEGJEHA(COKMANPFJNC INKFLMKONLP, EIJGBFLAMII PEMICEIPPPL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000513")]
	[Cpp2IlInjected.Address(RVA = "0x1FE3BC0", Offset = "0x1FE21C0", VA = "0x181FE3BC0", Slot = "6")]
	public EIJGBFLAMII FBNKFLLMFIF(COKMANPFJNC INKFLMKONLP, EIJGBFLAMII PEMICEIPPPL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000514")]
	[Cpp2IlInjected.Address(RVA = "0x1FE3B80", Offset = "0x1FE2180", VA = "0x181FE3B80", Slot = "7")]
	public IReadOnlyList<EIJGBFLAMII> BIAIIFEFFJH(COKMANPFJNC INKFLMKONLP, EIJGBFLAMII PEMICEIPPPL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000515")]
	[Cpp2IlInjected.Address(RVA = "0x1FE3CC0", Offset = "0x1FE22C0", VA = "0x181FE3CC0", Slot = "8")]
	public EIJGBFLAMII[] LDPGKLFGEGP(COKMANPFJNC INKFLMKONLP, EIJGBFLAMII PEMICEIPPPL, int LHIGNCKHLPA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000516")]
	[Cpp2IlInjected.Address(RVA = "0x1FE3C80", Offset = "0x1FE2280", VA = "0x181FE3C80", Slot = "9")]
	public bool GIEMFMLBFIN(COKMANPFJNC INKFLMKONLP, EIJGBFLAMII PEMICEIPPPL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000517")]
	[Cpp2IlInjected.Address(RVA = "0x1FE3C20", Offset = "0x1FE2220", VA = "0x181FE3C20", Slot = "10")]
	public bool FIILPFELPJE(COKMANPFJNC INKFLMKONLP, EIJGBFLAMII PEMICEIPPPL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000518")]
	[Cpp2IlInjected.Address(RVA = "0x1FE3C00", Offset = "0x1FE2200", VA = "0x181FE3C00", Slot = "11")]
	public bool FENFDJFDHAJ(COKMANPFJNC INKFLMKONLP, EIJGBFLAMII PEMICEIPPPL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000519")]
	[Cpp2IlInjected.Address(RVA = "0x1FE3CA0", Offset = "0x1FE22A0", VA = "0x181FE3CA0", Slot = "12")]
	public bool KDFAJDEJOGK(COKMANPFJNC INKFLMKONLP, EIJGBFLAMII PEMICEIPPPL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600051A")]
	[Cpp2IlInjected.Address(RVA = "0x1FE3BA0", Offset = "0x1FE21A0", VA = "0x181FE3BA0", Slot = "13")]
	public bool EBACHLLAIKJ(COKMANPFJNC GFJBHGCNBIH, EIJGBFLAMII PEMICEIPPPL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600051B")]
	[Cpp2IlInjected.Address(RVA = "0x1FE3C60", Offset = "0x1FE2260", VA = "0x181FE3C60", Slot = "14")]
	public bool GBDOALHBCBB(COKMANPFJNC INKFLMKONLP, EIJGBFLAMII PEMICEIPPPL)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D7")]
public abstract class NBONOPDFMLI : BGCMFBBEEPB
{
	[Cpp2IlInjected.Token(Token = "0x170000BC")]
	public ALAEJLFBHLG.KMKANABDJKK IHGPAMGJADL
	{
		[Cpp2IlInjected.Token(Token = "0x600051C")]
		[Cpp2IlInjected.Address(RVA = "0x1FE55D0", Offset = "0x1FE3BD0", VA = "0x181FE55D0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BD")]
	public abstract BAAJHLLICGI.AKCICGNFDEE FJDJMFHKOBK
	{
		[Cpp2IlInjected.Token(Token = "0x600051D")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000BE")]
	public abstract PJNMBNAHIFL.JAIGKHDFLIN GFCEPJINNMJ
	{
		[Cpp2IlInjected.Token(Token = "0x600051E")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000BF")]
	public abstract BIOFEIDPHNA.HJAFHNCLGOA AFFOMEKPOGM
	{
		[Cpp2IlInjected.Token(Token = "0x600051F")]
		[Cpp2IlInjected.Address(Slot = "16")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000C0")]
	public JJGBIGJGLEO.DCMFKDFHIDD<LKJBELODGDI, EIJGBFLAMII, PJNMBNAHIFL> ACKBFGKLOCM
	{
		[Cpp2IlInjected.Token(Token = "0x6000520")]
		[Cpp2IlInjected.Address(RVA = "0x1FE5620", Offset = "0x1FE3C20", VA = "0x181FE5620", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C1")]
	public abstract MBPPFDMCEAB ACDJIFFJFJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000521")]
		[Cpp2IlInjected.Address(Slot = "17")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000C2")]
	public abstract MECKJJBBCAK KHEAKPLPEKP
	{
		[Cpp2IlInjected.Token(Token = "0x6000522")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000C3")]
	public abstract FMJEHGKGMDB NODKJBCDHGO
	{
		[Cpp2IlInjected.Token(Token = "0x6000523")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000C4")]
	public abstract EECCFHIPBFA HCPLGEAOOFO
	{
		[Cpp2IlInjected.Token(Token = "0x6000524")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000C5")]
	public abstract JAAOPFDDNHM OEBGIMHBCAI
	{
		[Cpp2IlInjected.Token(Token = "0x6000525")]
		[Cpp2IlInjected.Address(Slot = "21")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000526")]
	[Cpp2IlInjected.Address(RVA = "0x86C4B0", Offset = "0x86AAB0", VA = "0x18086C4B0")]
	protected NBONOPDFMLI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D8")]
public sealed class JELHOHCFLNG : GNBFBLLEELD
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000D9")]
	[CompilerGenerated]
	private struct CPPCNNGBIOM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002C8")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002C9")]
		public AsyncTaskMethodBuilder<CBDPDIPONCF<object, FBDDJIHDMAI>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002CA")]
		public JELHOHCFLNG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002CB")]
		public EIJGBFLAMII action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002CC")]
		public bool clearBufferedRpcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002CD")]
		private TaskAwaiter<CBDPDIPONCF<object, FBDDJIHDMAI>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600052A")]
		[Cpp2IlInjected.Address(RVA = "0x1FE2BF0", Offset = "0x1FE11F0", VA = "0x181FE2BF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600052B")]
		[Cpp2IlInjected.Address(RVA = "0x1FE2E90", Offset = "0x1FE1490", VA = "0x181FE2E90", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000DA")]
	[CompilerGenerated]
	private struct BDJJDHCHLKF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002CE")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002CF")]
		public AsyncTaskMethodBuilder<CBDPDIPONCF<BDCBLKCBAEO, FBDDJIHDMAI>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002D0")]
		public JELHOHCFLNG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002D1")]
		public IReadOnlyList<EIJGBFLAMII> actions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002D2")]
		public bool clearBufferedRpcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002D3")]
		private TaskAwaiter<CBDPDIPONCF<object, FBDDJIHDMAI>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600052C")]
		[Cpp2IlInjected.Address(RVA = "0x1FE24E0", Offset = "0x1FE0AE0", VA = "0x181FE24E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600052D")]
		[Cpp2IlInjected.Address(RVA = "0x1FE2860", Offset = "0x1FE0E60", VA = "0x181FE2860", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002C7")]
	private readonly PLCHFMGPMPF EGCCOKJIONM;

	[Cpp2IlInjected.Token(Token = "0x6000527")]
	[Cpp2IlInjected.Address(RVA = "0x872130", Offset = "0x870730", VA = "0x180872130")]
	public JELHOHCFLNG(PLCHFMGPMPF LGGGFEEKDDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000528")]
	[Cpp2IlInjected.Address(RVA = "0x1FE3920", Offset = "0x1FE1F20", VA = "0x181FE3920")]
	[AsyncStateMachine(typeof(CPPCNNGBIOM))]
	private Task<CBDPDIPONCF<object, FBDDJIHDMAI>> FDGENAOKLLI(EIJGBFLAMII PEMICEIPPPL, bool FINFIEKODAH = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000529")]
	[Cpp2IlInjected.Address(RVA = "0x1FE3A50", Offset = "0x1FE2050", VA = "0x181FE3A50", Slot = "4")]
	[AsyncStateMachine(typeof(BDJJDHCHLKF))]
	public Task<CBDPDIPONCF<BDCBLKCBAEO, FBDDJIHDMAI>> PJBPAKHKCII(IReadOnlyList<EIJGBFLAMII> EPOBEFECONA, bool FINFIEKODAH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DB")]
public struct HEMEDIGGNCJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40002D4")]
	internal EJOHLFBKMKN<JFDDIOGFCLI, EIJGBFLAMII, GOFMMPHDHLD> HCHBBIIKJDJ;

	[Cpp2IlInjected.Token(Token = "0x600052E")]
	[Cpp2IlInjected.Address(RVA = "0x1FABA70", Offset = "0x1FAA070", VA = "0x181FABA70")]
	private HEMEDIGGNCJ([In] EJOHLFBKMKN<JFDDIOGFCLI, EIJGBFLAMII, GOFMMPHDHLD> ONEIGHMMLEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600052F")]
	[Cpp2IlInjected.Address(RVA = "0x1FE35D0", Offset = "0x1FE1BD0", VA = "0x181FE35D0")]
	public static HEMEDIGGNCJ ENFOKLPNHAF()
	{
		return default(HEMEDIGGNCJ);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DC")]
public static class ICBBIOBDLAM
{
	[Cpp2IlInjected.Token(Token = "0x6000530")]
	[Cpp2IlInjected.Address(RVA = "0x8DA780", Offset = "0x8D8D80", VA = "0x1808DA780")]
	public static EJOHLFBKMKN<JFDDIOGFCLI, EIJGBFLAMII, GOFMMPHDHLD> CMLCKEFLJIC(this HEMEDIGGNCJ HLIDMKMINHN)
	{
		return default(EJOHLFBKMKN<JFDDIOGFCLI, EIJGBFLAMII, GOFMMPHDHLD>);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000DD")]
public struct GOFMMPHDHLD : LJMGAPLNLLJ.OKNFBMBIILO<JFDDIOGFCLI, EIJGBFLAMII>
{
	[Cpp2IlInjected.Token(Token = "0x6000531")]
	[Cpp2IlInjected.Address(RVA = "0x1FE33E0", Offset = "0x1FE19E0", VA = "0x181FE33E0", Slot = "5")]
	public EIJGBFLAMII HJKMCKHECCI(JFDDIOGFCLI[] IAFLPPNCLIA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000532")]
	[Cpp2IlInjected.Address(RVA = "0x15E3110", Offset = "0x15E1710", VA = "0x1815E3110")]
	public int OIICCGCLLCF([In] JFDDIOGFCLI CMJJGMHOKHM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000533")]
	[Cpp2IlInjected.Address(RVA = "0x15E3110", Offset = "0x15E1710", VA = "0x1815E3110", Slot = "4")]
	private int OJHJEPENMKH([In] JFDDIOGFCLI LNPJFMEOKLF)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DF")]
public struct PMNMAGINNBI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40002D7")]
	internal EAEIAEHPNFO<NCJCIPAFOLM, EIJGBFLAMII, DANJGLADNAK> HCHBBIIKJDJ;

	[Cpp2IlInjected.Token(Token = "0x6000537")]
	[Cpp2IlInjected.Address(RVA = "0x1FABA70", Offset = "0x1FAA070", VA = "0x181FABA70")]
	private PMNMAGINNBI([In] EAEIAEHPNFO<NCJCIPAFOLM, EIJGBFLAMII, DANJGLADNAK> HKOOANPEHCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000538")]
	[Cpp2IlInjected.Address(RVA = "0x1FE5F90", Offset = "0x1FE4590", VA = "0x181FE5F90")]
	public static PMNMAGINNBI ENFOKLPNHAF()
	{
		return default(PMNMAGINNBI);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E0")]
public static class ILMKNJAIBOB
{
	[Cpp2IlInjected.Token(Token = "0x6000539")]
	[Cpp2IlInjected.Address(RVA = "0x8DA780", Offset = "0x8D8D80", VA = "0x1808DA780")]
	public static EAEIAEHPNFO<NCJCIPAFOLM, EIJGBFLAMII, DANJGLADNAK> CMLCKEFLJIC(this PMNMAGINNBI HLIDMKMINHN)
	{
		return default(EAEIAEHPNFO<NCJCIPAFOLM, EIJGBFLAMII, DANJGLADNAK>);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000E1")]
public struct DANJGLADNAK : KLCKLHMBIKJ.OKJPNPJHNMP<NCJCIPAFOLM, EIJGBFLAMII>
{
	[Cpp2IlInjected.Token(Token = "0x600053A")]
	[Cpp2IlInjected.Address(RVA = "0x15E3110", Offset = "0x15E1710", VA = "0x1815E3110")]
	public int IDPKOJJDIHA([In] NCJCIPAFOLM CMJJGMHOKHM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600053B")]
	[Cpp2IlInjected.Address(RVA = "0x1FE2F00", Offset = "0x1FE1500", VA = "0x181FE2F00", Slot = "5")]
	public EIJGBFLAMII APKAENDOFIG(NCJCIPAFOLM[] LIPCPMOBIAL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600053C")]
	[Cpp2IlInjected.Address(RVA = "0x15E3110", Offset = "0x15E1710", VA = "0x1815E3110", Slot = "4")]
	private int HJLDBNIMHFP([In] NCJCIPAFOLM CMJJGMHOKHM)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E3")]
public class BLCNLNGINKF : PJDAENIABGC, GGDFCMAGDGD, FBDDJIHDMAI, GJMJCOBOHDO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40002DB")]
	private readonly GJMJCOBOHDO? CLNLAFPHEIK;

	[Cpp2IlInjected.Token(Token = "0x170000C6")]
	public PGKLLKHCCLM IBPIHMNGPMC
	{
		[Cpp2IlInjected.Token(Token = "0x6000540")]
		[Cpp2IlInjected.Address(RVA = "0x86C7E0", Offset = "0x86ADE0", VA = "0x18086C7E0", Slot = "13")]
		[CompilerGenerated]
		get
		{
			return default(PGKLLKHCCLM);
		}
		[Cpp2IlInjected.Token(Token = "0x6000541")]
		[Cpp2IlInjected.Address(RVA = "0x86E8E0", Offset = "0x86CEE0", VA = "0x18086E8E0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C7")]
	public override GJMJCOBOHDO? ELGANDKGCMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000542")]
		[Cpp2IlInjected.Address(RVA = "0x868200", Offset = "0x866800", VA = "0x180868200", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000543")]
	[Cpp2IlInjected.Address(RVA = "0x1FE2940", Offset = "0x1FE0F40", VA = "0x181FE2940", Slot = "7")]
	public override string AFLHKEIDPKB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000544")]
	[Cpp2IlInjected.Address(RVA = "0x1FE2BB0", Offset = "0x1FE11B0", VA = "0x181FE2BB0")]
	private BLCNLNGINKF(PGKLLKHCCLM GNLDGJDNMDL, GJMJCOBOHDO? KGLGMNNABNO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000545")]
	[Cpp2IlInjected.Address(RVA = "0x1FE2AC0", Offset = "0x1FE10C0", VA = "0x181FE2AC0")]
	public static BLCNLNGINKF BIHJDDECPEC(GJMJCOBOHDO KGLGMNNABNO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000546")]
	[Cpp2IlInjected.Address(RVA = "0x1FE28D0", Offset = "0x1FE0ED0", VA = "0x181FE28D0")]
	public static BLCNLNGINKF AALPHBKAFJO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000547")]
	[Cpp2IlInjected.Address(RVA = "0x1FE2B40", Offset = "0x1FE1140", VA = "0x181FE2B40")]
	public static BLCNLNGINKF DBGCAHPOJDP()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E4")]
public static class GJHDNDCAKNN
{
	[Cpp2IlInjected.Token(Token = "0x6000548")]
	[Cpp2IlInjected.Address(RVA = "0x2B963F0", Offset = "0x2B949F0", VA = "0x182B963F0")]
	public static CBDPDIPONCF<TOk, GGDFCMAGDGD> KMJHBGKIGFH<TOk>([In] this CBDPDIPONCF<TOk, GGDFCMAGDGD> HLIDMKMINHN, GJMJCOBOHDO KGLGMNNABNO) where TOk : notnull
	{
		return default(CBDPDIPONCF<TOk, GGDFCMAGDGD>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000549")]
	[Cpp2IlInjected.Address(RVA = "0x2B96200", Offset = "0x2B94800", VA = "0x182B96200")]
	public static CBDPDIPONCF<TOk?, GGDFCMAGDGD?> JAGHCJMOLCC<TOk>([In] this CBDPDIPONCF<TOk, GGDFCMAGDGD> HLIDMKMINHN)
	{
		return default(CBDPDIPONCF<TOk, GGDFCMAGDGD>);
	}

	[Cpp2IlInjected.Token(Token = "0x600054A")]
	[Cpp2IlInjected.Address(RVA = "0x2B962F0", Offset = "0x2B948F0", VA = "0x182B962F0")]
	public static CBDPDIPONCF<TOk?, GGDFCMAGDGD?> KEGGOADLAKF<TOk>([In] this CBDPDIPONCF<TOk, GGDFCMAGDGD> HLIDMKMINHN)
	{
		return default(CBDPDIPONCF<TOk, GGDFCMAGDGD>);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E5")]
public interface MBPPFDMCEAB
{
	[Cpp2IlInjected.Token(Token = "0x600054B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool FLCGDFEELGM([In] CBDPDIPONCF<COKMANPFJNC, GJMJCOBOHDO> IAFCFGOKEAK);
}
[Cpp2IlInjected.Token(Token = "0x20000E6")]
public static class CCFJIFIHJOJ
{
	[Cpp2IlInjected.Token(Token = "0x600054C")]
	[Cpp2IlInjected.Address(RVA = "0x2997B90", Offset = "0x2996190", VA = "0x182997B90")]
	public static bool FLCGDFEELGM<TOk, TErr>(this MBPPFDMCEAB HLIDMKMINHN, [In] CBDPDIPONCF<TOk, TErr> IAFCFGOKEAK) where TOk : notnull where TErr : notnull, GJMJCOBOHDO
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E7")]
public interface MECKJJBBCAK
{
	[Cpp2IlInjected.Token(Token = "0x170000C8")]
	EFBDEBMEPGM MDBFDNDNMHH
	{
		[Cpp2IlInjected.Token(Token = "0x600054D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E8")]
public interface FMJEHGKGMDB
{
	[Cpp2IlInjected.Token(Token = "0x600054E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	MPHLCIAMIGI HNCPLJCPKGG(int NBBKLPGFGFD);
}
[Cpp2IlInjected.Token(Token = "0x20000E9")]
public interface DMAKMAHIEBA
{
	[Cpp2IlInjected.Token(Token = "0x170000C9")]
	string OABCLOFHIGC
	{
		[Cpp2IlInjected.Token(Token = "0x600054F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EA")]
public interface GBHIDAIIDDA
{
	[Cpp2IlInjected.Token(Token = "0x6000550")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IADLCFGNPKL? CILNCMLEKBD(CGBGMGFBCKF<HGFEOPBBPIG> GKEOEKGAILK);
}
[Cpp2IlInjected.Token(Token = "0x20000EB")]
public interface MGBHCOGMLEH
{
	[Cpp2IlInjected.Token(Token = "0x170000CA")]
	string OABCLOFHIGC
	{
		[Cpp2IlInjected.Token(Token = "0x6000551")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EC")]
public interface IADLCFGNPKL
{
	[Cpp2IlInjected.Token(Token = "0x170000CB")]
	string OABCLOFHIGC
	{
		[Cpp2IlInjected.Token(Token = "0x6000552")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000553")]
	[Cpp2IlInjected.Address(Slot = "1")]
	MGBHCOGMLEH? MALGOKJFBKD(CGBGMGFBCKF<JJKDMNECOCJ> JMCNEMAGKLA);

	[Cpp2IlInjected.Token(Token = "0x6000554")]
	[Cpp2IlInjected.Address(Slot = "2")]
	DMAKMAHIEBA? KKPDNAPHLJD(CGBGMGFBCKF<FLNLEKBDPAB> KHJIHNBGKNK);
}
[Cpp2IlInjected.Token(Token = "0x20000ED")]
public interface EECCFHIPBFA
{
	[Cpp2IlInjected.Token(Token = "0x6000555")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<bool> ECDLFJBCDGP(string DMNGPNKHPKF, string CAMDIODFJJE);
}
[Cpp2IlInjected.Token(Token = "0x20000EE")]
public interface JAAOPFDDNHM
{
	[Cpp2IlInjected.Token(Token = "0x6000556")]
	[Cpp2IlInjected.Address(Slot = "0")]
	GBHIDAIIDDA? OPKMDPAECDM([In] HBIPEINCKFG<HCHFDOFEDKE> KOGEFMMICBM);
}
[Cpp2IlInjected.Token(Token = "0x20000EF")]
public sealed class PJKJGJMHHLG
{
	[Cpp2IlInjected.Token(Token = "0x20000F0")]
	private struct LGIMLHJDGDB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002DF")]
		public int MIMJDCDEIKK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002E0")]
		public JJBCGHIHKLB? ENLMDOIBBHI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002E1")]
		public JJBCGHIHKLB? JABIGAGDNOE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002E2")]
		public readonly List<EIJGBFLAMII> APNINLMKGAI;

		[Cpp2IlInjected.Token(Token = "0x600055F")]
		[Cpp2IlInjected.Address(RVA = "0x1FE3D90", Offset = "0x1FE2390", VA = "0x181FE3D90")]
		private LGIMLHJDGDB(int PDMMEDBMFPP, JJBCGHIHKLB? FBMECONBAAJ, JJBCGHIHKLB? OLIBKIFPBEF, List<EIJGBFLAMII> EPOBEFECONA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000560")]
		[Cpp2IlInjected.Address(RVA = "0x1FE3CD0", Offset = "0x1FE22D0", VA = "0x181FE3CD0")]
		public static LGIMLHJDGDB ENFOKLPNHAF()
		{
			return default(LGIMLHJDGDB);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002DE")]
	private readonly KFAPHNLJDLJ<LGIMLHJDGDB> NFCJEEDIHHG;

	[Cpp2IlInjected.Token(Token = "0x170000CC")]
	public static PJKJGJMHHLG CFNNMJAMDBB
	{
		[Cpp2IlInjected.Token(Token = "0x6000557")]
		[Cpp2IlInjected.Address(RVA = "0x1FE5A90", Offset = "0x1FE4090", VA = "0x181FE5A90")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CD")]
	public bool FINPODCJAOB
	{
		[Cpp2IlInjected.Token(Token = "0x6000558")]
		[Cpp2IlInjected.Address(RVA = "0x8B83E0", Offset = "0x8B69E0", VA = "0x1808B83E0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000559")]
		[Cpp2IlInjected.Address(RVA = "0x9E7AA0", Offset = "0x9E60A0", VA = "0x1809E7AA0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600055A")]
	[Cpp2IlInjected.Address(RVA = "0x1FE59D0", Offset = "0x1FE3FD0", VA = "0x181FE59D0")]
	public void BKHAJKDALJI(DDBLDNMCNDP OLIBKIFPBEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600055B")]
	[Cpp2IlInjected.Address(RVA = "0x1FE5AE0", Offset = "0x1FE40E0", VA = "0x181FE5AE0")]
	public void MBFIJHMJIHP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600055C")]
	[Cpp2IlInjected.Address(RVA = "0x1FE5670", Offset = "0x1FE3C70", VA = "0x181FE5670")]
	private static string? AJCCFJGPDPH([In] LGIMLHJDGDB LFFCBNDAENB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600055D")]
	[Cpp2IlInjected.Address(RVA = "0x1FE5EE0", Offset = "0x1FE44E0", VA = "0x181FE5EE0")]
	public PJKJGJMHHLG()
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
