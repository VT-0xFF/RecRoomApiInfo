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
		[Cpp2IlInjected.Address(RVA = "0x87BDE0", Offset = "0x87ADE0", VA = "0x18087BDE0")]
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
		[Cpp2IlInjected.Address(RVA = "0x1FCEDA0", Offset = "0x1FCDDA0", VA = "0x181FCEDA0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x87C700", Offset = "0x87B700", VA = "0x18087C700")]
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
		[Cpp2IlInjected.Address(RVA = "0x87C740", Offset = "0x87B740", VA = "0x18087C740")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public sealed class DLILHLIBGCM : IDisposable, BCGABBMOIEH, IEKGMONMFKA, BPNGGANLLCB, JMHNHGKNNAI
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public abstract class OMOBCFNHGIP : PHPPLIBINMB
	{
		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public abstract int GEAPIJFIKAO
		{
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(Slot = "10")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x1FCF680", Offset = "0x1FCE680", VA = "0x181FCF680", Slot = "5")]
		public GKLBAKCCLFN MEPJGECDHHA(NEPEMAJJGFH.DNFLCBHJCIE HPGJLJLFPIH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(Slot = "11")]
		public abstract void NMEEIBKJBEA();

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(Slot = "12")]
		public abstract void KGLOFCNAHEM();

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x1FCF7D0", Offset = "0x1FCE7D0", VA = "0x181FCF7D0", Slot = "13")]
		public virtual void OCFPPJHHNLO(DLILHLIBGCM OPKEKBBFIHG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x1FCF600", Offset = "0x1FCE600", VA = "0x181FCF600", Slot = "14")]
		public virtual void LLKAHBJIAFO(DLILHLIBGCM OPKEKBBFIHG, LJHEBKBBECA JFOAFIPDIOA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x85EB60", Offset = "0x85DB60", VA = "0x18085EB60")]
		protected OMOBCFNHGIP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public interface PHPPLIBINMB
	{
		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		int GEAPIJFIKAO
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(Slot = "1")]
		GKLBAKCCLFN MEPJGECDHHA(NEPEMAJJGFH.DNFLCBHJCIE HPGJLJLFPIH);

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void NMEEIBKJBEA();

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void KGLOFCNAHEM();

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void OCFPPJHHNLO(DLILHLIBGCM OPKEKBBFIHG);

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void LLKAHBJIAFO(DLILHLIBGCM OPKEKBBFIHG, LJHEBKBBECA JFOAFIPDIOA);
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	private readonly struct JLCPLBBOIAE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public readonly PAEDLKDBPDM<IIDFNFNFGMN, LJHEBKBBECA, DLILHLIBGCM, CPPIEJKJJPO.PGABJALLGMN<IIDFNFNFGMN, LJHEBKBBECA, DLILHLIBGCM>> FOIAGJPPEFL;

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x1FCAF60", Offset = "0x1FC9F60", VA = "0x181FCAF60")]
		internal JLCPLBBOIAE(PAEDLKDBPDM<IIDFNFNFGMN, LJHEBKBBECA, DLILHLIBGCM, CPPIEJKJJPO.PGABJALLGMN<IIDFNFNFGMN, LJHEBKBBECA, DLILHLIBGCM>> OEFGKJLECGH)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public sealed class BHIGMHDNBON : CPPIEJKJJPO.PGABJALLGMN<IIDFNFNFGMN, LJHEBKBBECA, DLILHLIBGCM>
	{
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public static readonly BHIGMHDNBON PNNELGGLBHA;

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x85EB60", Offset = "0x85DB60", VA = "0x18085EB60")]
		private BHIGMHDNBON()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0xBD6A10", Offset = "0xBD5A10", VA = "0x180BD6A10", Slot = "4")]
		public IIDFNFNFGMN PCLNFJBLPDN(LJHEBKBBECA KALCJEIICGB)
		{
			return default(IIDFNFNFGMN);
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x1FB38A0", Offset = "0x1FB28A0", VA = "0x181FB38A0", Slot = "5")]
		public void OCFPPJHHNLO(DLILHLIBGCM JMCFDCHCIPI, LJHEBKBBECA JFOAFIPDIOA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x1FB3790", Offset = "0x1FB2790", VA = "0x181FB3790", Slot = "6")]
		public void LLKAHBJIAFO(DLILHLIBGCM JMCFDCHCIPI, LJHEBKBBECA JFOAFIPDIOA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000A")]
	private struct LHEOCDJLNKD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public LFFDDJPJHBH<IIDFNFNFGMN, LJHEBKBBECA, DLILHLIBGCM, CPPIEJKJJPO.PGABJALLGMN<IIDFNFNFGMN, LJHEBKBBECA, DLILHLIBGCM>> FOIAGJPPEFL;

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x1FCC420", Offset = "0x1FCB420", VA = "0x181FCC420")]
		internal LHEOCDJLNKD(LFFDDJPJHBH<IIDFNFNFGMN, LJHEBKBBECA, DLILHLIBGCM, CPPIEJKJJPO.PGABJALLGMN<IIDFNFNFGMN, LJHEBKBBECA, DLILHLIBGCM>> OEFGKJLECGH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x1FCC3D0", Offset = "0x1FCB3D0", VA = "0x181FCC3D0")]
		public static LHEOCDJLNKD GAKCNKPJGEK()
		{
			return default(LHEOCDJLNKD);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public readonly struct IMAEJMCEEDD : BEHAKNDEKHC.KDFDHDDJNMA<LJHEBKBBECA, DLILHLIBGCM>
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200000C")]
		[CompilerGenerated]
		private struct GNMNMJKOHJM : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public AsyncTaskMethodBuilder<DFAHBLOKBPH<object, CKBHMJGLAPL>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			public DLILHLIBGCM receiver;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public LJHEBKBBECA action;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			public IMAEJMCEEDD <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			private TaskAwaiter<DFAHBLOKBPH<object, CKBHMJGLAPL>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x1FC8430", Offset = "0x1FC7430", VA = "0x181FC8430", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x1FC8610", Offset = "0x1FC7610", VA = "0x181FC8610", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x9B3030", Offset = "0x9B2030", VA = "0x1809B3030", Slot = "4")]
		public BGKDPCAKPBJ<GODBFGGEJLK> OIICCBHPNAN(DLILHLIBGCM PPGNDOHCHFE)
		{
			return default(BGKDPCAKPBJ<GODBFGGEJLK>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x1FCA520", Offset = "0x1FC9520", VA = "0x181FCA520", Slot = "5")]
		[AsyncStateMachine(typeof(GNMNMJKOHJM))]
		public Task<DFAHBLOKBPH<object, CKBHMJGLAPL>> PGLNJIEHCFO(DLILHLIBGCM PPGNDOHCHFE, LJHEBKBBECA JFOAFIPDIOA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x1FCA500", Offset = "0x1FC9500", VA = "0x181FCA500", Slot = "6")]
		public LJHEBKBBECA[] GIGPIMECHJC(DLILHLIBGCM PPGNDOHCHFE)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private struct KFPINGHILKN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public AsyncTaskMethodBuilder<DFAHBLOKBPH<bool, CKBHMJGLAPL>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public DLILHLIBGCM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public ACNLHJIMLEN rootData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public GONCODLINKC circuitRootData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		public OPGPLFDAFEE superRoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private TaskAwaiter<DFAHBLOKBPH<bool, CKBHMJGLAPL>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x1FCB220", Offset = "0x1FCA220", VA = "0x181FCB220", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x1FCB4A0", Offset = "0x1FCA4A0", VA = "0x181FCB4A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private struct GNGMHGNEMAI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public AsyncTaskMethodBuilder<DFAHBLOKBPH<bool, CKBHMJGLAPL>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public DLILHLIBGCM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private TaskAwaiter<DFAHBLOKBPH<bool, CKBHMJGLAPL>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x1FC8130", Offset = "0x1FC7130", VA = "0x181FC8130", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x1FC83C0", Offset = "0x1FC73C0", VA = "0x181FC83C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[CompilerGenerated]
	private struct ENOAFJBIHPD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		public AsyncTaskMethodBuilder<DFAHBLOKBPH<OKOMLKNINNF, CKBHMJGLAPL>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		public DLILHLIBGCM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private TaskAwaiter<DFAHBLOKBPH<OKOMLKNINNF, CKBHMJGLAPL>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x1FB64B0", Offset = "0x1FB54B0", VA = "0x181FB64B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x1FB6690", Offset = "0x1FB5690", VA = "0x181FB6690", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	private struct GIBKDAAOMOP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		public AsyncTaskMethodBuilder<DFAHBLOKBPH<object, CKBHMJGLAPL>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		public DLILHLIBGCM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		public LJHEBKBBECA action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private TaskAwaiter<DFAHBLOKBPH<object, CKBHMJGLAPL>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x1FC5340", Offset = "0x1FC4340", VA = "0x181FC5340", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x1FC5530", Offset = "0x1FC4530", VA = "0x181FC5530", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[CompilerGenerated]
	private struct ICPDCEADCJN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public AsyncTaskMethodBuilder<DFAHBLOKBPH<OKOMLKNINNF, CKBHMJGLAPL>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public DLILHLIBGCM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public Guid rootGraphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private TaskAwaiter<DFAHBLOKBPH<OKOMLKNINNF, CKBHMJGLAPL>> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private TaskAwaiter<DFAHBLOKBPH<bool, CKBHMJGLAPL>> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x1FC9670", Offset = "0x1FC8670", VA = "0x181FC9670", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x1FC9E60", Offset = "0x1FC8E60", VA = "0x181FC9E60", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private readonly BGKDPCAKPBJ<GODBFGGEJLK> DKPJFAEKHGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly JLCPLBBOIAE AMGMLNIEBFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly HOBLGDMMJFL NFFKCENAKAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	internal readonly KPPNBFBIOKN HBLLLANGEJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18F0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	internal readonly FAPDDLCEKJF GDNKCELMOKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18F8")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	internal readonly MHOOCAJAJNP.MBGNEMHFOFC MOKDACAENEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1918")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	internal readonly AJJDJAPDANI HOLMGFCBICD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1920")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	internal readonly FDGLIGGPHEK JFCBGJNMHGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1928")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	internal readonly OMAIHILJAJP FJKKIGPGINN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1930")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	internal readonly JJJMMGGCKPA FNEJGMAALEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1938")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private OJLHMOEKCHO KKLHIDIELEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1948")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private GANMBGGMEHJ GJKLAINJBKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1968")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	internal readonly HOBLGDMMJFL.OJDEPNGPMMA KJCGCOMAMEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1970")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	internal readonly FAOOALJKJLE BHABEMIFHBD;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public HOBLGDMMJFL BFHECOJLOCG
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x1FB4820", Offset = "0x1FB3820", VA = "0x181FB4820")]
		get
		{
			return default(HOBLGDMMJFL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	internal PHPPLIBINMB EBCLIEDFFAF
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x1FB5BB0", Offset = "0x1FB4BB0", VA = "0x181FB5BB0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	internal GKLBAKCCLFN HLBFCJNDBEP
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x1FB5BA0", Offset = "0x1FB4BA0", VA = "0x181FB5BA0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x1FB4800", Offset = "0x1FB3800", VA = "0x181FB4800")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	internal bool EIPAEAHAGJM
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x1FB4E60", Offset = "0x1FB3E60", VA = "0x181FB4E60")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x1FB5620", Offset = "0x1FB4620", VA = "0x181FB5620")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public KDEDGFHGAAC GEJDNFDMJDB
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x1FB5FF0", Offset = "0x1FB4FF0", VA = "0x181FB5FF0", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public JIFMDNHFFGL LAJEIPBAOHC
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x1FB6000", Offset = "0x1FB5000", VA = "0x181FB6000", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public GAMFGHBFMKK IBDIIEMBGKK
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x1FB6020", Offset = "0x1FB5020", VA = "0x181FB6020", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public BCMIFOGFBLK IOFNJCMNDKF
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x1FB6010", Offset = "0x1FB5010", VA = "0x181FB6010", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public MHOOCAJAJNP? HLFIHKBABHI
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x1FB5B20", Offset = "0x1FB4B20", VA = "0x181FB5B20", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	private GCBDAOEDPME? BPKPGGDIMIN
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x1FB5970", Offset = "0x1FB4970", VA = "0x181FB5970", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x1FB5CF0", Offset = "0x1FB4CF0", VA = "0x181FB5CF0")]
	private DLILHLIBGCM(FAPDDLCEKJF JAJIMFKDCOE, BGKDPCAKPBJ<GODBFGGEJLK> GCCAFDBPHMC, [In] JLCPLBBOIAE IOOBJBODIAO, [In] HOBLGDMMJFL OKAMMMKBGPO, [In] KPPNBFBIOKN IDOHAIMDPGC, GKLBAKCCLFN ANHAGJCBJNI, [In] MHOOCAJAJNP.MBGNEMHFOFC KBFGKGIBGKJ, HOBLGDMMJFL.OJDEPNGPMMA NLBHJBAKKAE, FAOOALJKJLE LNAIGMLAPIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x1FB5150", Offset = "0x1FB4150", VA = "0x181FB5150")]
	public static DLILHLIBGCM GAKCNKPJGEK(FAPDDLCEKJF HPGJLJLFPIH, [In] CCIDCFKCNKN JHOEHMIKHNB, DGFHOLMOKJF AGNGLNEIFCM, [In] NCOOLGMMHKF NCMELOBGPDH, LMPFDCDCDFM PMACJPCGOFC, BGKDPCAKPBJ<GODBFGGEJLK> GCCAFDBPHMC, BGKDPCAKPBJ<BDCJAIFHMFA> IHFFHIIMGBA, IGBBFLOOINI GBBAAFALICM, HGNFMGKMDKJ MDIBJABEEGP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x1FB4E70", Offset = "0x1FB3E70", VA = "0x181FB4E70")]
	public static DLILHLIBGCM GAKCNKPJGEK(FAPDDLCEKJF JAJIMFKDCOE, [In] HOBLGDMMJFL OKAMMMKBGPO, [In] KPPNBFBIOKN IDOHAIMDPGC, BGKDPCAKPBJ<GODBFGGEJLK> GCCAFDBPHMC, BGKDPCAKPBJ<BDCJAIFHMFA> IHFFHIIMGBA, IGBBFLOOINI GBBAAFALICM, HGNFMGKMDKJ MDIBJABEEGP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x1FB4B50", Offset = "0x1FB3B50", VA = "0x181FB4B50", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x1FB5630", Offset = "0x1FB4630", VA = "0x181FB5630")]
	[AsyncStateMachine(typeof(KFPINGHILKN))]
	internal Task<DFAHBLOKBPH<bool, CKBHMJGLAPL>> GOIHKIJOADG(ACNLHJIMLEN BJFDPEFNNCL, GONCODLINKC IINFNJFFILP, OPGPLFDAFEE LDGJIBHMHDH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x1FB5880", Offset = "0x1FB4880", VA = "0x181FB5880")]
	[AsyncStateMachine(typeof(GNGMHGNEMAI))]
	public Task<DFAHBLOKBPH<bool, CKBHMJGLAPL>> JKECMDGMMFB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x1FB5C00", Offset = "0x1FB4C00", VA = "0x181FB5C00")]
	[AsyncStateMachine(typeof(ENOAFJBIHPD))]
	public Task<DFAHBLOKBPH<OKOMLKNINNF, CKBHMJGLAPL>> OHIJCMFJKAM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x1FB4830", Offset = "0x1FB3830", VA = "0x181FB4830")]
	internal void ANMJAEFJBGD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x1FB5AA0", Offset = "0x1FB4AA0", VA = "0x181FB5AA0")]
	internal IHMGDPHFMFJ<LJHEBKBBECA> LJBEDAEENGG([In] JAKDGPEMKPM GAPEAKICJKJ)
	{
		return default(IHMGDPHFMFJ<LJHEBKBBECA>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x1FB5790", Offset = "0x1FB4790", VA = "0x181FB5790")]
	internal bool HNCECMNLMFN([In] JAKDGPEMKPM GAPEAKICJKJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x1FB5800", Offset = "0x1FB4800", VA = "0x181FB5800")]
	internal IHMGDPHFMFJ<LJHEBKBBECA> JENCHCPAHNO([In] NEBPGKEABNC JBLLHOEJLEK)
	{
		return default(IHMGDPHFMFJ<LJHEBKBBECA>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x1FB4A40", Offset = "0x1FB3A40", VA = "0x181FB4A40")]
	[AsyncStateMachine(typeof(GIBKDAAOMOP))]
	internal Task<DFAHBLOKBPH<object, CKBHMJGLAPL>> DBJMBLGIABI(LJHEBKBBECA JFOAFIPDIOA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x1FB5290", Offset = "0x1FB4290", VA = "0x181FB5290")]
	private LJHEBKBBECA[] GIGPIMECHJC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x1FB4D40", Offset = "0x1FB3D40", VA = "0x181FB4D40")]
	[AsyncStateMachine(typeof(ICPDCEADCJN))]
	public Task<DFAHBLOKBPH<OKOMLKNINNF, CKBHMJGLAPL>> EPENJPJHLJL(Guid LCJDEGDKNMH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public static class HBIMLHCAABI
{
	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x2BC04D0", Offset = "0x2BBF4D0", VA = "0x182BC04D0")]
	public static GANLJBAGKKE<(TPrev?, DLILHLIBGCM?), GCBDAOEDPME> CAMLBOELDHJ<TPrev>([In] this GANLJBAGKKE<TPrev, DLILHLIBGCM> KALCJEIICGB)
	{
		return default(GANLJBAGKKE<(TPrev, DLILHLIBGCM), GCBDAOEDPME>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x2BC0790", Offset = "0x2BBF790", VA = "0x182BC0790")]
	public static GANLJBAGKKE<TPrev?, DLILHLIBGCM?> LKGDBPPPFIP<TPrev>([In] this GANLJBAGKKE<TPrev, DLILHLIBGCM> KALCJEIICGB)
	{
		return default(GANLJBAGKKE<TPrev, DLILHLIBGCM>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public sealed class PNNFHGMEFEM<TData> : DNBIAPHIKOM, FAMMJDINKLG, GFEHMFEELCO where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly MFLENLEMIJF<PMIFAKHBGDE>? ABDEBAJLDED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public readonly string LOFJHBNFKMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public readonly TData KHBLMBBNMIA;

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public MFLENLEMIJF<PMIFAKHBGDE>? LHGIEIFBGBN
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x21F7C00", Offset = "0x21F6C00", VA = "0x1821F7C00", Slot = "13")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x8517B0", Offset = "0x8507B0", VA = "0x1808517B0", Slot = "7")]
	public override string DODDKOCHLNI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x47CC890", Offset = "0x47CB890", VA = "0x1847CC890")]
	internal PNNFHGMEFEM([In] MFLENLEMIJF<PMIFAKHBGDE>? JFGHLCKEPNE, BGKDPCAKPBJ<GBACLKKDIKL>? BCLBIAPLKBN, IOKind? IJCMLDFOFNJ, string KKHEHGHPOAA, [In] TData AHGAPHMJDIB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public static class PIMEDDFCBAD
{
	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x1FCFF70", Offset = "0x1FCEF70", VA = "0x181FCFF70")]
	public static DFAHBLOKBPH<HEKOFJCLKMP, FAMMJDINKLG> OKPGIKEKKLE([In] this AGEDJGEBDNF<PLAPNDKGGOJ> EBJLOJAEBDD)
	{
		return default(DFAHBLOKBPH<HEKOFJCLKMP, FAMMJDINKLG>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x2D7B970", Offset = "0x2D7A970", VA = "0x182D7B970")]
	public static DFAHBLOKBPH<TOk, FAMMJDINKLG> IPMPIIILODD<TOk>([In] this DFAHBLOKBPH<TOk, FAMMJDINKLG> KALCJEIICGB, [In] MFLENLEMIJF<PMIFAKHBGDE>? JFGHLCKEPNE, BGKDPCAKPBJ<GBACLKKDIKL>? BCLBIAPLKBN, IOKind? IJCMLDFOFNJ, string KKHEHGHPOAA) where TOk : notnull
	{
		return default(DFAHBLOKBPH<TOk, FAMMJDINKLG>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public interface FAPDDLCEKJF
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	OAJFADDLMBG.BLNFJBPLCOI OKGKGHOKADE
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	NEPEMAJJGFH.DNFLCBHJCIE JPGJEPJPAKA
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	DLILHLIBGCM.PHPPLIBINMB LJIFNGKAHJM
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	NBEHIIBMPBF.IKBJBOPHAJI OCIMDPOAHDJ
	{
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	CPPIEJKJJPO.PGABJALLGMN<IIDFNFNFGMN, LJHEBKBBECA, DLILHLIBGCM> DKBILLFHCAE
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	DPLHFMKJDOO AOJIMJDEJAC
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	GADMDCCKLNF GHGLJOHDPEM
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	HPAIHFKBLKJ IGBMLKJIJKF
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	KEGMKMHBKGO PMMKOLDHFDI
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	EIMDDECPHBC GIHDNHJBJMJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public static class LCNABGMOCNP
{
	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x1FCC020", Offset = "0x1FCB020", VA = "0x181FCC020")]
	public static LJHEBKBBECA NJDHJAJJGKE(this LJHEBKBBECA KALCJEIICGB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x1FCBF50", Offset = "0x1FCAF50", VA = "0x181FCBF50")]
	public static LJHEBKBBECA DCFBIEPCMBC(this IIDKHGAAKGK KALCJEIICGB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public readonly struct IIDKHGAAKGK
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[CompilerGenerated]
	private struct EKECKHODJPI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public AsyncTaskMethodBuilder<DFAHBLOKBPH<object, CKBHMJGLAPL>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public DLILHLIBGCM root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public IIDKHGAAKGK self;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private TaskAwaiter<DFAHBLOKBPH<object, CKBHMJGLAPL>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x1FB6180", Offset = "0x1FB5180", VA = "0x181FB6180", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x1FB6440", Offset = "0x1FB5440", VA = "0x181FB6440", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public readonly ByteString JMEAFIDIDGF;

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0xA111F0", Offset = "0xA101F0", VA = "0x180A111F0")]
	private IIDKHGAAKGK(ByteString JJCEIJMGOAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x1FCA040", Offset = "0x1FC9040", VA = "0x181FCA040")]
	public static LJHEBKBBECA JLAEGOCOMPP(ByteString JJCEIJMGOAB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x1FCA100", Offset = "0x1FC9100", VA = "0x181FCA100")]
	public static CAOIGAEMJKC<IIDFNFNFGMN, IIDKHGAAKGK> PPOONMGDPDJ(LJHEBKBBECA KEKBFAMAGGP)
	{
		return default(CAOIGAEMJKC<IIDFNFNFGMN, IIDKHGAAKGK>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x1FC9F30", Offset = "0x1FC8F30", VA = "0x181FC9F30")]
	[AsyncStateMachine(typeof(EKECKHODJPI))]
	public static Task<DFAHBLOKBPH<object, CKBHMJGLAPL>> DBJMBLGIABI(DLILHLIBGCM JMCFDCHCIPI, IIDKHGAAKGK KALCJEIICGB)
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000019")]
public readonly struct FPEFHPBBMIE
{
	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x1FB8F10", Offset = "0x1FB7F10", VA = "0x181FB8F10")]
	public static LJHEBKBBECA JLAEGOCOMPP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x1FB9030", Offset = "0x1FB8030", VA = "0x181FB9030")]
	public static CAOIGAEMJKC<IIDFNFNFGMN, FPEFHPBBMIE> PPOONMGDPDJ(LJHEBKBBECA KEKBFAMAGGP)
	{
		return default(CAOIGAEMJKC<IIDFNFNFGMN, FPEFHPBBMIE>);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x1FB8FB0", Offset = "0x1FB7FB0", VA = "0x181FB8FB0")]
	public static DFAHBLOKBPH<OKOMLKNINNF, LPIPGCLHAKC> NNHJJMFIHOC(DLILHLIBGCM JMCFDCHCIPI, [In] FPEFHPBBMIE KALCJEIICGB)
	{
		return default(DFAHBLOKBPH<OKOMLKNINNF, LPIPGCLHAKC>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public readonly struct IKBHNDBNPPM
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[CompilerGenerated]
	private struct OHPHIFPCIIF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public AsyncTaskMethodBuilder<DFAHBLOKBPH<OKOMLKNINNF, LPIPGCLHAKC>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public DLILHLIBGCM root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public IKBHNDBNPPM self;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private DFAHBLOKBPH<OKOMLKNINNF, LPIPGCLHAKC> <r>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x1FCF100", Offset = "0x1FCE100", VA = "0x181FCF100", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x1FCF470", Offset = "0x1FCE470", VA = "0x181FCF470", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	public readonly ACNLHJIMLEN? LPFHCOKPPPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public readonly GONCODLINKC? KDHOINCEFFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public readonly OPGPLFDAFEE? BCILBIMBKCM;

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x1EED100", Offset = "0x1EEC100", VA = "0x181EED100")]
	private IKBHNDBNPPM(ACNLHJIMLEN? BJFDPEFNNCL, GONCODLINKC? IINFNJFFILP, OPGPLFDAFEE? LDGJIBHMHDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x1FCA2F0", Offset = "0x1FC92F0", VA = "0x181FCA2F0")]
	public static LJHEBKBBECA? JLAEGOCOMPP(ACNLHJIMLEN? BJFDPEFNNCL, GONCODLINKC? IINFNJFFILP, OPGPLFDAFEE? LDGJIBHMHDH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x1FCA3F0", Offset = "0x1FC93F0", VA = "0x181FCA3F0")]
	public static CAOIGAEMJKC<IIDFNFNFGMN, IKBHNDBNPPM> PPOONMGDPDJ(LJHEBKBBECA KEKBFAMAGGP)
	{
		return default(CAOIGAEMJKC<IIDFNFNFGMN, IKBHNDBNPPM>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x1FCA1B0", Offset = "0x1FC91B0", VA = "0x181FCA1B0")]
	[AsyncStateMachine(typeof(OHPHIFPCIIF))]
	public static Task<DFAHBLOKBPH<OKOMLKNINNF, LPIPGCLHAKC>> DBJMBLGIABI(DLILHLIBGCM JMCFDCHCIPI, IKBHNDBNPPM KALCJEIICGB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public readonly struct LEJANHPPPHA
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	[CompilerGenerated]
	private struct DHFEIDBNGMM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public AsyncTaskMethodBuilder<DFAHBLOKBPH<KADDDLHOCKA, CKBHMJGLAPL>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public LEJANHPPPHA self;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public DLILHLIBGCM root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private DFAHBLOKBPH<KADDDLHOCKA, CKBHMJGLAPL> <r1>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		private DFAHBLOKBPH<object, GFEHMFEELCO>[] <aggregateResult>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		private int <i>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		private DFAHBLOKBPH<object, GFEHMFEELCO> <r2>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		private DFAHBLOKBPH<object, GFEHMFEELCO>[] <>7__wrap5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		private int <>7__wrap6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		private TaskAwaiter<DFAHBLOKBPH<object, CKBHMJGLAPL>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x1FB4330", Offset = "0x1FB3330", VA = "0x181FB4330", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x1FB4790", Offset = "0x1FB3790", VA = "0x181FB4790", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public readonly IReadOnlyList<LJHEBKBBECA> EOJHEBDFNBC;

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0xA111F0", Offset = "0xA101F0", VA = "0x180A111F0")]
	private LEJANHPPPHA(IReadOnlyList<LJHEBKBBECA> CECLMDMADKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x1FCC270", Offset = "0x1FCB270", VA = "0x181FCC270")]
	public static LJHEBKBBECA JLAEGOCOMPP(IReadOnlyList<LJHEBKBBECA> CECLMDMADKH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x1FCC330", Offset = "0x1FCB330", VA = "0x181FCC330")]
	public static CAOIGAEMJKC<IIDFNFNFGMN, LEJANHPPPHA> PPOONMGDPDJ(LJHEBKBBECA KEKBFAMAGGP)
	{
		return default(CAOIGAEMJKC<IIDFNFNFGMN, LEJANHPPPHA>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x1FCC130", Offset = "0x1FCB130", VA = "0x181FCC130")]
	[AsyncStateMachine(typeof(DHFEIDBNGMM))]
	public static Task<DFAHBLOKBPH<KADDDLHOCKA, CKBHMJGLAPL>> DBJMBLGIABI(DLILHLIBGCM JMCFDCHCIPI, LEJANHPPPHA KALCJEIICGB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public readonly struct NEBPGKEABNC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	public readonly int DHMBIHOHONP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	public readonly int LCNJIFOOGIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	public readonly byte[] KHBLMBBNMIA;

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x1BD6220", Offset = "0x1BD5220", VA = "0x181BD6220")]
	private NEBPGKEABNC(int DOPPKGNLPAC, int HCALFJOJKJO, byte[] AHGAPHMJDIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x1FCCF10", Offset = "0x1FCBF10", VA = "0x181FCCF10")]
	public static LJHEBKBBECA JLAEGOCOMPP(int DOPPKGNLPAC, int HCALFJOJKJO, ByteString AHGAPHMJDIB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x1FCD110", Offset = "0x1FCC110", VA = "0x181FCD110")]
	public static LJHEBKBBECA[] POFCJFPIKND(LJHEBKBBECA JFOAFIPDIOA, int LLBBMCIBMCH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x1FCD250", Offset = "0x1FCC250", VA = "0x181FCD250")]
	public static CAOIGAEMJKC<IIDFNFNFGMN, NEBPGKEABNC> PPOONMGDPDJ(LJHEBKBBECA KEKBFAMAGGP)
	{
		return default(CAOIGAEMJKC<IIDFNFNFGMN, NEBPGKEABNC>);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x1FCCFF0", Offset = "0x1FCBFF0", VA = "0x181FCCFF0")]
	public static DFAHBLOKBPH<LJHEBKBBECA, LPIPGCLHAKC> NNHJJMFIHOC(DLILHLIBGCM JMCFDCHCIPI, [In] NEBPGKEABNC KALCJEIICGB)
	{
		return default(DFAHBLOKBPH<LJHEBKBBECA, LPIPGCLHAKC>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public readonly struct JAKDGPEMKPM
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[CompilerGenerated]
	private struct EONLNEECOAF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public AsyncTaskMethodBuilder<DFAHBLOKBPH<bool, LPIPGCLHAKC>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public DLILHLIBGCM root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public JAKDGPEMKPM self;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		private DFAHBLOKBPH<bool, LPIPGCLHAKC> <r>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		private TaskAwaiter<DFAHBLOKBPH<OKOMLKNINNF, LPIPGCLHAKC>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x1FB6700", Offset = "0x1FB5700", VA = "0x181FB6700", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x1FB6D40", Offset = "0x1FB5D40", VA = "0x181FB6D40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public readonly int DHMBIHOHONP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public readonly int LCNJIFOOGIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public readonly byte[] KHBLMBBNMIA;

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x1BD6220", Offset = "0x1BD5220", VA = "0x181BD6220")]
	private JAKDGPEMKPM(int DOPPKGNLPAC, int HCALFJOJKJO, byte[] AHGAPHMJDIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x1FCA980", Offset = "0x1FC9980", VA = "0x181FCA980")]
	public static LJHEBKBBECA JLAEGOCOMPP(int DOPPKGNLPAC, int HCALFJOJKJO, ByteString AHGAPHMJDIB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x1FCA650", Offset = "0x1FC9650", VA = "0x181FCA650")]
	public static LJHEBKBBECA?[]? AJIGLGEGDHD(int LLBBMCIBMCH, ACNLHJIMLEN? BJFDPEFNNCL, GONCODLINKC? IINFNJFFILP, OPGPLFDAFEE? LDGJIBHMHDH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x1FCAA60", Offset = "0x1FC9A60", VA = "0x181FCAA60")]
	public static CAOIGAEMJKC<IIDFNFNFGMN, JAKDGPEMKPM> PPOONMGDPDJ(LJHEBKBBECA KEKBFAMAGGP)
	{
		return default(CAOIGAEMJKC<IIDFNFNFGMN, JAKDGPEMKPM>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x1FCA850", Offset = "0x1FC9850", VA = "0x181FCA850")]
	[AsyncStateMachine(typeof(EONLNEECOAF))]
	public static Task<DFAHBLOKBPH<bool, LPIPGCLHAKC>> DBJMBLGIABI(DLILHLIBGCM JMCFDCHCIPI, JAKDGPEMKPM KALCJEIICGB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public sealed class AJJDJAPDANI : KDEDGFHGAAC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private readonly DLILHLIBGCM CPJCBIFJBNF;

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public MHDNMAHLKBM? PNNELGGLBHA
	{
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x1FB33F0", Offset = "0x1FB23F0", VA = "0x181FB33F0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x858C30", Offset = "0x857C30", VA = "0x180858C30")]
	internal AJJDJAPDANI(DLILHLIBGCM OPKEKBBFIHG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public sealed class IBCHDJBNEDB : MHDNMAHLKBM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private readonly DLILHLIBGCM CPJCBIFJBNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private readonly FJEIPFCJKKB AMAHMNOIELH;

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x857060", Offset = "0x856060", VA = "0x180857060")]
	public IBCHDJBNEDB(DLILHLIBGCM OPKEKBBFIHG, FJEIPFCJKKB BPOAMAKEJBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x1FC9390", Offset = "0x1FC8390", VA = "0x181FC9390", Slot = "4")]
	public DFAHBLOKBPH<HEKOFJCLKMP, FAMMJDINKLG> LELNGFLBAOD(MFLENLEMIJF<PMIFAKHBGDE> GODNEBGANDJ, BGKDPCAKPBJ<IHOAGKINOHG> FCFGPBAFAPA, BGKDPCAKPBJ<HONMIPKGKFA> IMIBEIBKNDL)
	{
		return default(DFAHBLOKBPH<HEKOFJCLKMP, FAMMJDINKLG>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x1FC90B0", Offset = "0x1FC80B0", VA = "0x181FC90B0", Slot = "5")]
	public DFAHBLOKBPH<HEKOFJCLKMP, FAMMJDINKLG> CGFDJCNODBE(MFLENLEMIJF<PMIFAKHBGDE> GODNEBGANDJ, BGKDPCAKPBJ<IHOAGKINOHG> FCFGPBAFAPA, BGKDPCAKPBJ<KMABMDHMDOF> GPBEODKKKPJ)
	{
		return default(DFAHBLOKBPH<HEKOFJCLKMP, FAMMJDINKLG>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public sealed class OAJFADDLMBG : JJIBBBFHGIG, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public interface BLNFJBPLCOI
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Task<FJEIPFCJKKB> LIIPDIIGACB(DLILHLIBGCM OPKEKBBFIHG, GONCODLINKC? MBJAMOMBIEB, OPGPLFDAFEE? HLOAHIKAKFO, CancellationToken LABHBAHABKB);

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		BNLAJFLOIDN PHBFLLBGAHN(DLILHLIBGCM OPKEKBBFIHG, ACNLHJIMLEN CIKADECLAKM);
	}

	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public sealed class NLLDGMACOEP : BLNFJBPLCOI
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000028")]
		[CompilerGenerated]
		private struct NAPBPGGJJNP : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400006E")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400006F")]
			public AsyncTaskMethodBuilder<FJEIPFCJKKB> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000070")]
			public DLILHLIBGCM circuitsManager;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000071")]
			public GONCODLINKC cv2RoomData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000072")]
			public OPGPLFDAFEE cv2SuperRoomData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000073")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000074")]
			private TaskAwaiter<NBEHIIBMPBF> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0x1FCCCD0", Offset = "0x1FCBCD0", VA = "0x181FCCCD0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0x1FCCEA0", Offset = "0x1FCBEA0", VA = "0x181FCCEA0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public static readonly NLLDGMACOEP PNNELGGLBHA;

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x85EB60", Offset = "0x85DB60", VA = "0x18085EB60")]
		private NLLDGMACOEP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x1FCEBA0", Offset = "0x1FCDBA0", VA = "0x181FCEBA0", Slot = "4")]
		[AsyncStateMachine(typeof(NAPBPGGJJNP))]
		public Task<FJEIPFCJKKB> LIIPDIIGACB(DLILHLIBGCM OPKEKBBFIHG, GONCODLINKC? MBJAMOMBIEB, OPGPLFDAFEE? HLOAHIKAKFO, CancellationToken LABHBAHABKB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x1FCED00", Offset = "0x1FCDD00", VA = "0x181FCED00", Slot = "5")]
		public BNLAJFLOIDN PHBFLLBGAHN(DLILHLIBGCM OPKEKBBFIHG, ACNLHJIMLEN CIKADECLAKM)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	[CompilerGenerated]
	private struct KLALAGIPCAP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		public AsyncTaskMethodBuilder<OAJFADDLMBG> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		public DLILHLIBGCM circuitsManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		public GONCODLINKC cv2RoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		public OPGPLFDAFEE cv2SuperRoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public ACNLHJIMLEN evRoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		private BLNFJBPLCOI <selfDeps>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		private TaskAwaiter<FJEIPFCJKKB> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x1FCB510", Offset = "0x1FCA510", VA = "0x181FCB510", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x1FCBA10", Offset = "0x1FCAA10", VA = "0x181FCBA10", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private readonly FJEIPFCJKKB AMAHMNOIELH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private readonly BNLAJFLOIDN JPKHPIJHOPP;

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public MHOOCAJAJNP HLFIHKBABHI
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x1FCEE80", Offset = "0x1FCDE80", VA = "0x181FCEE80", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public GCBDAOEDPME LHFLHBJLKBA
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x1FCF040", Offset = "0x1FCE040", VA = "0x181FCF040", Slot = "5")]
		get
		{
			return default(GCBDAOEDPME);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public IBCHDJBNEDB LKCBLDPNJHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x854640", Offset = "0x853640", VA = "0x180854640", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public OIBHFGOJEEN JPGGKCKGDFG
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x8515D0", Offset = "0x8505D0", VA = "0x1808515D0", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x1EBA260", Offset = "0x1EB9260", VA = "0x181EBA260")]
	private OAJFADDLMBG(FJEIPFCJKKB BPOAMAKEJBM, BNLAJFLOIDN ADMGDGBIJKC, IBCHDJBNEDB HAEADDIGOIK, OIBHFGOJEEN EIKDIJAAOOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x1FCEED0", Offset = "0x1FCDED0", VA = "0x181FCEED0")]
	[AsyncStateMachine(typeof(KLALAGIPCAP))]
	public static Task<OAJFADDLMBG> NBLMOEHBGOH(DLILHLIBGCM OPKEKBBFIHG, ACNLHJIMLEN CIKADECLAKM, GONCODLINKC? MBJAMOMBIEB, OPGPLFDAFEE? HLOAHIKAKFO, CancellationToken LABHBAHABKB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x1FCEE20", Offset = "0x1FCDE20", VA = "0x181FCEE20", Slot = "8")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public sealed class NEPEMAJJGFH : GKLBAKCCLFN, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	public interface DNFLCBHJCIE
	{
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Task<JJIBBBFHGIG> NFGCMGECBMA(DLILHLIBGCM OPKEKBBFIHG, ACNLHJIMLEN CIKADECLAKM, GONCODLINKC? MBJAMOMBIEB, OPGPLFDAFEE? HLOAHIKAKFO, CancellationToken LABHBAHABKB);

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void JOJCNKADNEC();

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void GACNOLPCCGL();
	}

	[Cpp2IlInjected.Token(Token = "0x200002C")]
	public abstract class GJHMAKONJIG : DNFLCBHJCIE
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200002D")]
		[CompilerGenerated]
		private struct JBKAMPMFKNF : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000086")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000087")]
			public AsyncTaskMethodBuilder<JJIBBBFHGIG> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000088")]
			public DLILHLIBGCM circuitsManager;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000089")]
			public ACNLHJIMLEN evRoomData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400008A")]
			public GONCODLINKC cv2RoomData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400008B")]
			public OPGPLFDAFEE cv2SuperRoomData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400008C")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400008D")]
			private TaskAwaiter<OAJFADDLMBG> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0x1FCAB40", Offset = "0x1FC9B40", VA = "0x181FCAB40", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0x1FCAE80", Offset = "0x1FC9E80", VA = "0x181FCAE80", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x1FC55A0", Offset = "0x1FC45A0", VA = "0x181FC55A0", Slot = "4")]
		[AsyncStateMachine(typeof(JBKAMPMFKNF))]
		public Task<JJIBBBFHGIG> NFGCMGECBMA(DLILHLIBGCM OPKEKBBFIHG, ACNLHJIMLEN CIKADECLAKM, GONCODLINKC? MBJAMOMBIEB, OPGPLFDAFEE? HLOAHIKAKFO, CancellationToken LABHBAHABKB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(Slot = "7")]
		public abstract void JOJCNKADNEC();

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(Slot = "8")]
		public abstract void GACNOLPCCGL();

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x85EB60", Offset = "0x85DB60", VA = "0x18085EB60")]
		protected GJHMAKONJIG()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[CompilerGenerated]
	private struct LBDDGEFBMOH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		public AsyncTaskMethodBuilder<JJIBBBFHGIG> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		public NEPEMAJJGFH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		private TaskAwaiter<OKOMLKNINNF> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x1FCBA80", Offset = "0x1FCAA80", VA = "0x181FCBA80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x1FCBC80", Offset = "0x1FCAC80", VA = "0x181FCBC80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[CompilerGenerated]
	private struct NINFKDOLCBD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		public NEPEMAJJGFH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		public DLILHLIBGCM circuitsManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		public ACNLHJIMLEN evRoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		public GONCODLINKC cv2RoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		public OPGPLFDAFEE cv2SuperRoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		private TaskAwaiter<JJIBBBFHGIG> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x1FCE610", Offset = "0x1FCD610", VA = "0x181FCE610", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x1FCEB40", Offset = "0x1FCDB40", VA = "0x181FCEB40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	private readonly DNFLCBHJCIE OMOPLBNHPIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	private readonly TaskCompletionSource<OKOMLKNINNF> HMCDFHLCMKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	private readonly TaskCompletionSource<OKOMLKNINNF> PPMIBNBAJFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	private readonly CancellationTokenSource JJHLEPNGLAG;

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public bool EIPAEAHAGJM
	{
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0xA68730", Offset = "0xA67730", VA = "0x180A68730", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0xA68570", Offset = "0xA67570", VA = "0x180A68570")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public bool EFBLDNCDHCM
	{
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0xBA6770", Offset = "0xBA5770", VA = "0x180BA6770", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0xBA6790", Offset = "0xBA5790", VA = "0x180BA6790")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public bool ADJHKLKKCJP
	{
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x11DFE20", Offset = "0x11DEE20", VA = "0x1811DFE20")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x1FCD600", Offset = "0x1FCC600", VA = "0x181FCD600")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public JJIBBBFHGIG? BGNEDPJINED
	{
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x851840", Offset = "0x850840", VA = "0x180851840", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x851620", Offset = "0x850620", VA = "0x180851620")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x1FCD610", Offset = "0x1FCC610", VA = "0x181FCD610", Slot = "7")]
	[AsyncStateMachine(typeof(LBDDGEFBMOH))]
	public Task<JJIBBBFHGIG> KJOHOJBJGPN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x1FCD700", Offset = "0x1FCC700", VA = "0x181FCD700")]
	public NEPEMAJJGFH(DNFLCBHJCIE HPGJLJLFPIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x1FCD330", Offset = "0x1FCC330", VA = "0x181FCD330", Slot = "8")]
	[AsyncStateMachine(typeof(NINFKDOLCBD))]
	public Task ANKMDHOFENM(DLILHLIBGCM OPKEKBBFIHG, ACNLHJIMLEN CIKADECLAKM, GONCODLINKC? MBJAMOMBIEB, OPGPLFDAFEE? HLOAHIKAKFO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x1FCD490", Offset = "0x1FCC490", VA = "0x181FCD490", Slot = "9")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
internal sealed class EJDKDJFIHMJ : DJHNPBCMKFC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private readonly OIBHFGOJEEN PKJJGIHCLLH;

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x858C30", Offset = "0x857C30", VA = "0x180858C30")]
	public EJDKDJFIHMJ(OIBHFGOJEEN EIKDIJAAOOC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
internal static class HPFKIJMJLGF
{
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	private class HNLGAEIBOPG<TGraph> : GCFIMNCAKMI where TGraph : DFHKAHJLJKC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		protected readonly TGraph LGMMNGPILII;

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public virtual LLOMJEMEPOD? JHKFLGMBGKO
		{
			[Cpp2IlInjected.Token(Token = "0x60000AE")]
			[Cpp2IlInjected.Address(RVA = "0x1020F30", Offset = "0x101FF30", VA = "0x181020F30", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public BGKDPCAKPBJ<EHIJHEMDKLF> NGMAJELLEMM
		{
			[Cpp2IlInjected.Token(Token = "0x60000B0")]
			[Cpp2IlInjected.Address(RVA = "0x3DFC4E0", Offset = "0x3DFB4E0", VA = "0x183DFC4E0", Slot = "5")]
			get
			{
				return default(BGKDPCAKPBJ<EHIJHEMDKLF>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public BGKDPCAKPBJ<EHIJHEMDKLF>? JPHBNKBBJGI
		{
			[Cpp2IlInjected.Token(Token = "0x60000B1")]
			[Cpp2IlInjected.Address(RVA = "0x3DFC460", Offset = "0x3DFB460", VA = "0x183DFC460", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x858C30", Offset = "0x857C30", VA = "0x180858C30")]
		public HNLGAEIBOPG(TGraph MKCPNDCEKPI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000033")]
	private sealed class GOMDGCCCKCI : HNLGAEIBOPG<KMFKCPFHJPA>
	{
		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public override LLOMJEMEPOD? JHKFLGMBGKO
		{
			[Cpp2IlInjected.Token(Token = "0x60000B2")]
			[Cpp2IlInjected.Address(RVA = "0x1FC8680", Offset = "0x1FC7680", VA = "0x181FC8680", Slot = "7")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x1FC86A0", Offset = "0x1FC76A0", VA = "0x181FC86A0")]
		public GOMDGCCCKCI(KMFKCPFHJPA LBAMLBNKEJN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x1FC8F20", Offset = "0x1FC7F20", VA = "0x181FC8F20")]
	public static GCFIMNCAKMI GAKCNKPJGEK(DFHKAHJLJKC MKCPNDCEKPI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public sealed class GMKLOJNABAC : LDEHOBIEPBO, HADENNIHHJO, FDIFHNPIPOF, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	[CompilerGenerated]
	private sealed class KAOCKBKAFFJ
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
			public KAOCKBKAFFJ <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000AA")]
			public DPLHFMKJDOO errReporting_;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000AB")]
			private TaskAwaiter<DFAHBLOKBPH<OKOMLKNINNF, CKBHMJGLAPL>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60000E0")]
			[Cpp2IlInjected.Address(RVA = "0x1FD0410", Offset = "0x1FCF410", VA = "0x181FD0410", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E1")]
			[Cpp2IlInjected.Address(RVA = "0x1FD0680", Offset = "0x1FCF680", VA = "0x181FD0680", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		public GMKLOJNABAC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		public bool value;

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x85EB60", Offset = "0x85DB60", VA = "0x18085EB60")]
		public KAOCKBKAFFJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x1FCAF70", Offset = "0x1FC9F70", VA = "0x181FCAF70")]
		[AsyncStateMachine(typeof(<<RequestSetBoolDefaultValue>g__requestSetBoolDefaultValueInternal|0>d))]
		internal Task AFGNLOKKKAA(DPLHFMKJDOO errReporting_)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	[CompilerGenerated]
	private struct CACKFMMHEHP : IAsyncStateMachine
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
		public GMKLOJNABAC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		public string value;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		private TaskAwaiter<bool> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		private TaskAwaiter<DFAHBLOKBPH<OKOMLKNINNF, CKBHMJGLAPL>> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x1FB3DC0", Offset = "0x1FB2DC0", VA = "0x181FB3DC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x1FB42D0", Offset = "0x1FB32D0", VA = "0x181FB42D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000039")]
	[CompilerGenerated]
	private sealed class DPGKDCEBLBF
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
			public DPGKDCEBLBF <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000B8")]
			private TaskAwaiter<DFAHBLOKBPH<OKOMLKNINNF, CKBHMJGLAPL>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60000E6")]
			[Cpp2IlInjected.Address(RVA = "0x1FD06E0", Offset = "0x1FCF6E0", VA = "0x181FD06E0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E7")]
			[Cpp2IlInjected.Address(RVA = "0x1FD09C0", Offset = "0x1FCF9C0", VA = "0x181FD09C0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		public GMKLOJNABAC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		public int value;

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x85EB60", Offset = "0x85DB60", VA = "0x18085EB60")]
		public DPGKDCEBLBF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x1FB60B0", Offset = "0x1FB50B0", VA = "0x181FB60B0")]
		[AsyncStateMachine(typeof(<<RequestSetIntDefaultValue>g__requestSetIntDefaultValueInternal|0>d))]
		internal Task DDEHLJKDOOF(DPLHFMKJDOO errReporting_)
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private readonly AOJKPNALAMB KHOKJFNELJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private readonly ICollection<PBPMBDHCLNP> DBALDKLOLIG;

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	private FAPDDLCEKJF PICDEEMCPCA
	{
		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x1FC5A30", Offset = "0x1FC4A30", VA = "0x181FC5A30")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public BGKDPCAKPBJ<HONMIPKGKFA> HIPMIHFDBIH
	{
		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x99B590", Offset = "0x99A590", VA = "0x18099B590", Slot = "24")]
		[CompilerGenerated]
		get
		{
			return default(BGKDPCAKPBJ<HONMIPKGKFA>);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0xBBC000", Offset = "0xBBB000", VA = "0x180BBC000")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	private BGKDPCAKPBJ<HFFNHINIHLD> GGIMEDGLLOF
	{
		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0xBA4FA0", Offset = "0xBA3FA0", VA = "0x180BA4FA0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public BGKDPCAKPBJ<BLEKLEBBJEP> PILBDCIHNCO
	{
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x879460", Offset = "0x878460", VA = "0x180879460", Slot = "25")]
		[CompilerGenerated]
		get
		{
			return default(BGKDPCAKPBJ<BLEKLEBBJEP>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public override BGKDPCAKPBJ<GBACLKKDIKL> EAPPAGNBMDM
	{
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x1FC5980", Offset = "0x1FC4980", VA = "0x181FC5980", Slot = "20")]
		get
		{
			return default(BGKDPCAKPBJ<GBACLKKDIKL>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public bool NDJIHJEMJIB
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x1FC5B50", Offset = "0x1FC4B50", VA = "0x181FC5B50", Slot = "26")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x1FC7F10", Offset = "0x1FC6F10", VA = "0x181FC7F10")]
	private GMKLOJNABAC(DLILHLIBGCM OPKEKBBFIHG, EMGONNJLBBJ OHDOOCGHDGN, AOJKPNALAMB JOFAILJBGPJ, BGKDPCAKPBJ<IHOAGKINOHG> FCFGPBAFAPA, BGKDPCAKPBJ<HONMIPKGKFA> IMIBEIBKNDL, BGKDPCAKPBJ<HFFNHINIHLD> NODCCEJHLIA, bool IOKKBNCNMLC, string CKEJJGPNKGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x1FC5D20", Offset = "0x1FC4D20", VA = "0x181FC5D20")]
	public static GMKLOJNABAC GAKCNKPJGEK(DLILHLIBGCM OPKEKBBFIHG, EMGONNJLBBJ OHDOOCGHDGN, AOJKPNALAMB MIFEONEPPKP, BGKDPCAKPBJ<IHOAGKINOHG> FCFGPBAFAPA, BGKDPCAKPBJ<HFFNHINIHLD> NODCCEJHLIA, BGKDPCAKPBJ<HONMIPKGKFA> IMIBEIBKNDL, bool IOKKBNCNMLC, bool HBPNKNHGJMP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x1FC7750", Offset = "0x1FC6750", VA = "0x181FC7750", Slot = "21")]
	protected override void LFNNOPDGNGK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x1FC5A50", Offset = "0x1FC4A50", VA = "0x181FC5A50", Slot = "22")]
	public override void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x1FC59D0", Offset = "0x1FC49D0", VA = "0x181FC59D0", Slot = "30")]
	public void DCCFHAGHFLK(PBPMBDHCLNP FMBAOLNLHMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x1FC63E0", Offset = "0x1FC53E0", VA = "0x181FC63E0", Slot = "27")]
	public void HENBAHNFAMC(FPALLBOIGNO CAMMINKKHHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x1FC6BE0", Offset = "0x1FC5BE0", VA = "0x181FC6BE0", Slot = "28")]
	public void JPNHNMLJAAH(GGGEDMPGLBI HOCHGGDLMPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x1FC5BD0", Offset = "0x1FC4BD0", VA = "0x181FC5BD0", Slot = "23")]
	protected override void FJHGBBGONPO(FKDGIBAGNOJ AELMEPLFHIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x1FC6A70", Offset = "0x1FC5A70", VA = "0x181FC6A70", Slot = "32")]
	public string JMODHONAFGE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x1FC7950", Offset = "0x1FC6950", VA = "0x181FC7950", Slot = "29")]
	public string PCMJAKCACBH(int BEFMODGHLMP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x1FC7C10", Offset = "0x1FC6C10", VA = "0x181FC7C10")]
	private void PFMDJJBGKLK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x1FC69B0", Offset = "0x1FC59B0", VA = "0x181FC69B0", Slot = "31")]
	public void JECLMOPNKEF(PBPMBDHCLNP FMBAOLNLHMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x1FC60D0", Offset = "0x1FC50D0", VA = "0x181FC60D0")]
	private void GHJDDJKACDM(bool JJCEIJMGOAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x1FC7580", Offset = "0x1FC6580", VA = "0x181FC7580", Slot = "33")]
	[AsyncStateMachine(typeof(CACKFMMHEHP))]
	public Task KHGHMLBOFDH(string JJCEIJMGOAB, bool NDCGMEHKFJB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x1FC5750", Offset = "0x1FC4750", VA = "0x181FC5750")]
	public void AHJJCJELCKI(string JJCEIJMGOAB, bool NDCGMEHKFJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x1FC6810", Offset = "0x1FC5810", VA = "0x181FC6810")]
	private void JEBCKBKKLFL(int JJCEIJMGOAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0xBBC000", Offset = "0xBBB000", VA = "0x180BBC000")]
	internal void KBMPFAGDGFM(BGKDPCAKPBJ<HONMIPKGKFA> JJCEIJMGOAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x1FC5B40", Offset = "0x1FC4B40", VA = "0x181FC5B40")]
	[CompilerGenerated]
	private void EGGOGLCEKJE(string JJCEIJMGOAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x1FC7690", Offset = "0x1FC6690", VA = "0x181FC7690")]
	[CompilerGenerated]
	private bool KMHIHDFIHBO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x1FC6320", Offset = "0x1FC5320", VA = "0x181FC6320")]
	[CompilerGenerated]
	private bool HCLEGABHODA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x1FC5700", Offset = "0x1FC4700", VA = "0x181FC5700")]
	[CompilerGenerated]
	private int ABAHKCBKOIJ()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x1FC58A0", Offset = "0x1FC48A0", VA = "0x181FC58A0")]
	[CompilerGenerated]
	private bool ALKEJECENAH()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x1FC77F0", Offset = "0x1FC67F0", VA = "0x181FC77F0")]
	[CompilerGenerated]
	private void LNPIHHHGMKI(string JJCEIJMGOAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x1FC6750", Offset = "0x1FC5750", VA = "0x181FC6750")]
	[CompilerGenerated]
	private bool HJHJBENMAJO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x1FC5930", Offset = "0x1FC4930", VA = "0x181FC5930")]
	[CompilerGenerated]
	private bool CFDOGGJIBJC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x1FC6290", Offset = "0x1FC5290", VA = "0x181FC6290")]
	[CompilerGenerated]
	private bool GIOAKMIFHPM()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x1FC5700", Offset = "0x1FC4700", VA = "0x181FC5700")]
	[CompilerGenerated]
	private int ELOOHJBIHKM()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x1FC7E40", Offset = "0x1FC6E40", VA = "0x181FC7E40")]
	[CompilerGenerated]
	private bool PMAOJBLKJKK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x1FC5AF0", Offset = "0x1FC4AF0", VA = "0x181FC5AF0")]
	[CompilerGenerated]
	private int EAACDODFPJO()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x1FC7800", Offset = "0x1FC6800", VA = "0x181FC7800")]
	[CompilerGenerated]
	private void MCJIEHOEOIP(object JJCEIJMGOAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x1FC7880", Offset = "0x1FC6880", VA = "0x181FC7880")]
	[CompilerGenerated]
	private bool MINNIDCFMGF()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public static class GBFEFCHLLFG
{
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	public sealed class IFMFMJBKMJI : KIJMOGHLELH<FEFPJOLFBLK>
	{
		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public override DKMOPNEOHLH JODFAEOIPMC
		{
			[Cpp2IlInjected.Token(Token = "0x60000EA")]
			[Cpp2IlInjected.Address(RVA = "0x9A6590", Offset = "0x9A5590", VA = "0x1809A6590", Slot = "126")]
			get
			{
				return default(DKMOPNEOHLH);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x1FC9ED0", Offset = "0x1FC8ED0", VA = "0x181FC9ED0")]
		public IFMFMJBKMJI(DLILHLIBGCM OPKEKBBFIHG, FEFPJOLFBLK OEFGKJLECGH)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003D")]
	public sealed class HEKLFHOGOCB : CNGEGLEMEMP<HABHDAGHAFN>
	{
		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x1FC8AC0", Offset = "0x1FC7AC0", VA = "0x181FC8AC0")]
		public HEKLFHOGOCB(DLILHLIBGCM OPKEKBBFIHG, HABHDAGHAFN OHDOOCGHDGN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x1FC88F0", Offset = "0x1FC78F0", VA = "0x181FC88F0", Slot = "120")]
		protected override void GHIPLIDCNEB(OHIGDFFLHJA NMEBKEGDNCC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x1FC8A70", Offset = "0x1FC7A70", VA = "0x181FC8A70")]
		[CompilerGenerated]
		private bool NOELNNNNJAI()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x1FC87D0", Offset = "0x1FC77D0", VA = "0x181FC87D0")]
		[CompilerGenerated]
		private void FHBCLPJNPIJ(bool JJCEIJMGOAB)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003E")]
	public sealed class BPMGFJGDDLI : CNGEGLEMEMP<KAGPHKJKHPO>
	{
		[Cpp2IlInjected.Token(Token = "0x200003F")]
		[CompilerGenerated]
		private sealed class LCFCEABHFCO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000B9")]
			public PCILEDIMGBH nodeAdapterDeps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000BA")]
			public BPMGFJGDDLI <>4__this;

			[Cpp2IlInjected.Token(Token = "0x60000F1")]
			[Cpp2IlInjected.Address(RVA = "0x85EB60", Offset = "0x85DB60", VA = "0x18085EB60")]
			public LCFCEABHFCO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F2")]
			[Cpp2IlInjected.Address(RVA = "0x1FCBEB0", Offset = "0x1FCAEB0", VA = "0x181FCBEB0")]
			internal void NCGMJMFHGEA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F3")]
			[Cpp2IlInjected.Address(RVA = "0x1FCBF00", Offset = "0x1FCAF00", VA = "0x181FCBF00")]
			internal bool OIANKMMHODC()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000F4")]
			[Cpp2IlInjected.Address(RVA = "0x1FCBE60", Offset = "0x1FCAE60", VA = "0x181FCBE60")]
			internal bool GNDADNGFDLE()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000F5")]
			[Cpp2IlInjected.Address(RVA = "0x1FCBCF0", Offset = "0x1FCACF0", VA = "0x181FCBCF0")]
			internal void ADBLKAGNGFP(bool value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F6")]
			[Cpp2IlInjected.Address(RVA = "0x1FCBE10", Offset = "0x1FCAE10", VA = "0x181FCBE10")]
			internal bool DMNAKLFEOCK()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x1FB3D50", Offset = "0x1FB2D50", VA = "0x181FB3D50")]
		public BPMGFJGDDLI(DLILHLIBGCM OPKEKBBFIHG, KAGPHKJKHPO OHDOOCGHDGN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x1FB3A20", Offset = "0x1FB2A20", VA = "0x181FB3A20", Slot = "120")]
		protected override void GHIPLIDCNEB(OHIGDFFLHJA NMEBKEGDNCC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000040")]
	public sealed class LLEOKDMHEPD : CNGEGLEMEMP<GMLIKEPIHPP>
	{
		[Cpp2IlInjected.Token(Token = "0x2000041")]
		[CompilerGenerated]
		private sealed class ONHFOFPIDPB
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000BB")]
			public PCILEDIMGBH nodeAdapterDeps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000BC")]
			public LLEOKDMHEPD <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000BD")]
			public Predicate<Guid> <>9__7;

			[Cpp2IlInjected.Token(Token = "0x60000F9")]
			[Cpp2IlInjected.Address(RVA = "0x85EB60", Offset = "0x85DB60", VA = "0x18085EB60")]
			public ONHFOFPIDPB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FA")]
			[Cpp2IlInjected.Address(RVA = "0x1FCFBA0", Offset = "0x1FCEBA0", VA = "0x181FCFBA0")]
			internal object NCGMJMFHGEA()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000FB")]
			[Cpp2IlInjected.Address(RVA = "0x1FCFCA0", Offset = "0x1FCECA0", VA = "0x181FCFCA0")]
			internal bool OALPLEHLNDH(Guid id)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000FC")]
			[Cpp2IlInjected.Address(RVA = "0x1FCFD20", Offset = "0x1FCED20", VA = "0x181FCFD20")]
			internal void OIANKMMHODC(object value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FD")]
			[Cpp2IlInjected.Address(RVA = "0x1FCF9F0", Offset = "0x1FCE9F0", VA = "0x181FCF9F0")]
			internal string GNDADNGFDLE(object key)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000FE")]
			[Cpp2IlInjected.Address(RVA = "0x1FCF810", Offset = "0x1FCE810", VA = "0x181FCF810")]
			internal IReadOnlyList<object> ADBLKAGNGFP()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000FF")]
			[Cpp2IlInjected.Address(RVA = "0x1FCF980", Offset = "0x1FCE980", VA = "0x181FCF980")]
			internal bool DMNAKLFEOCK()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000100")]
			[Cpp2IlInjected.Address(RVA = "0x1FCFB50", Offset = "0x1FCEB50", VA = "0x181FCFB50")]
			internal bool LFNPCGFBCGF()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000101")]
			[Cpp2IlInjected.Address(RVA = "0x1FCF860", Offset = "0x1FCE860", VA = "0x181FCF860")]
			internal void CNOGCEECIJC(bool value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x1FCCB80", Offset = "0x1FCBB80", VA = "0x181FCCB80")]
		public LLEOKDMHEPD(DLILHLIBGCM OPKEKBBFIHG, GMLIKEPIHPP OHDOOCGHDGN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x1FCC430", Offset = "0x1FCB430", VA = "0x181FCC430", Slot = "120")]
		protected override void GHIPLIDCNEB(OHIGDFFLHJA NMEBKEGDNCC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000042")]
	public sealed class NHMMEEMEEOK : CNGEGLEMEMP<CHKPCMDLDGC>
	{
		[Cpp2IlInjected.Token(Token = "0x2000043")]
		[CompilerGenerated]
		private sealed class KDOLGAICEJE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000BE")]
			public NHMMEEMEEOK <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000BF")]
			public PCILEDIMGBH nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x6000104")]
			[Cpp2IlInjected.Address(RVA = "0x85EB60", Offset = "0x85DB60", VA = "0x18085EB60")]
			public KDOLGAICEJE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000105")]
			[Cpp2IlInjected.Address(RVA = "0x1FCB0B0", Offset = "0x1FCA0B0", VA = "0x181FCB0B0")]
			internal bool NCGMJMFHGEA()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000106")]
			[Cpp2IlInjected.Address(RVA = "0x1FCB100", Offset = "0x1FCA100", VA = "0x181FCB100")]
			internal void OIANKMMHODC(bool value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000107")]
			[Cpp2IlInjected.Address(RVA = "0x1FCB060", Offset = "0x1FCA060", VA = "0x181FCB060")]
			internal bool GNDADNGFDLE()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x1FCE5A0", Offset = "0x1FCD5A0", VA = "0x181FCE5A0")]
		public NHMMEEMEEOK(DLILHLIBGCM OPKEKBBFIHG, CHKPCMDLDGC OHDOOCGHDGN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x1FCE370", Offset = "0x1FCD370", VA = "0x181FCE370", Slot = "120")]
		protected override void GHIPLIDCNEB(OHIGDFFLHJA NMEBKEGDNCC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000044")]
	public abstract class EIGFGILKFHJ<TNode> : CNGEGLEMEMP<TNode> where TNode : notnull, OMGMBPFDAMG
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000045")]
		[CompilerGenerated]
		private struct ADKHDLLDNCC : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C0")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C1")]
			public AsyncTaskMethodBuilder<DFAHBLOKBPH<BGKDPCAKPBJ<IHOAGKINOHG>, CKBHMJGLAPL>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C2")]
			public EIGFGILKFHJ<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C3")]
			public string name;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C4")]
			private TaskAwaiter<DFAHBLOKBPH<BGKDPCAKPBJ<IHOAGKINOHG>, CKBHMJGLAPL>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000110")]
			[Cpp2IlInjected.Address(RVA = "0x3CEECD0", Offset = "0x3CEDCD0", VA = "0x183CEECD0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000111")]
			[Cpp2IlInjected.Address(RVA = "0x3CEF0C0", Offset = "0x3CEE0C0", VA = "0x183CEF0C0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000046")]
		[CompilerGenerated]
		private struct MEBNPEPCFAF : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C5")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C6")]
			public AsyncTaskMethodBuilder<DFAHBLOKBPH<OKOMLKNINNF, CKBHMJGLAPL>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C7")]
			public EIGFGILKFHJ<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C8")]
			public BGKDPCAKPBJ<IHOAGKINOHG> portGroupId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C9")]
			private TaskAwaiter<DFAHBLOKBPH<OKOMLKNINNF, CKBHMJGLAPL>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000112")]
			[Cpp2IlInjected.Address(RVA = "0x44DE400", Offset = "0x44DD400", VA = "0x1844DE400", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000113")]
			[Cpp2IlInjected.Address(RVA = "0x44DE7F0", Offset = "0x44DD7F0", VA = "0x1844DE7F0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public sealed override bool IFFEOKHGMHD
		{
			[Cpp2IlInjected.Token(Token = "0x6000108")]
			[Cpp2IlInjected.Address(RVA = "0x86C5D0", Offset = "0x86B5D0", VA = "0x18086C5D0", Slot = "115")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public sealed override BGKDPCAKPBJ<IHOAGKINOHG>? NGGHLMJBNGJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000109")]
			[Cpp2IlInjected.Address(RVA = "0x38A39C0", Offset = "0x38A29C0", VA = "0x1838A39C0", Slot = "119")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x38A3970", Offset = "0x38A2970", VA = "0x1838A3970")]
		protected EIGFGILKFHJ(DLILHLIBGCM OPKEKBBFIHG, TNode OHDOOCGHDGN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x38A3740", Offset = "0x38A2740", VA = "0x1838A3740", Slot = "100")]
		[AsyncStateMachine(typeof(EIGFGILKFHJ<>.ADKHDLLDNCC))]
		public override Task<DFAHBLOKBPH<BGKDPCAKPBJ<IHOAGKINOHG>, CKBHMJGLAPL>> PGIDCCGEGJH(string CKEJJGPNKGO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x38A36A0", Offset = "0x38A26A0", VA = "0x1838A36A0", Slot = "124")]
		public sealed override bool NFBEILNBBGL(BGKDPCAKPBJ<IHOAGKINOHG> FCFGPBAFAPA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x38A3600", Offset = "0x38A2600", VA = "0x1838A3600", Slot = "112")]
		protected sealed override bool LBIDOPNBACI(BGKDPCAKPBJ<IHOAGKINOHG> FCFGPBAFAPA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x38A3560", Offset = "0x38A2560", VA = "0x1838A3560", Slot = "113")]
		protected override bool IKBKACIOKDH(BGKDPCAKPBJ<IHOAGKINOHG> FCFGPBAFAPA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x38A3860", Offset = "0x38A2860", VA = "0x1838A3860", Slot = "101")]
		[AsyncStateMachine(typeof(EIGFGILKFHJ<>.MEBNPEPCFAF))]
		public override Task<DFAHBLOKBPH<OKOMLKNINNF, CKBHMJGLAPL>> PHDPIMFBHPJ(BGKDPCAKPBJ<IHOAGKINOHG> FCFGPBAFAPA)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000047")]
	public sealed class HJGPIOPONDN : AGBOAEKDJHB<MKDINKFMEIO>
	{
		[Cpp2IlInjected.Token(Token = "0x2000048")]
		[CompilerGenerated]
		private sealed class HKILOPBPEAB
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000CA")]
			public HJGPIOPONDN <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000CB")]
			public PCILEDIMGBH nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x6000116")]
			[Cpp2IlInjected.Address(RVA = "0x85EB60", Offset = "0x85DB60", VA = "0x18085EB60")]
			public HKILOPBPEAB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000117")]
			[Cpp2IlInjected.Address(RVA = "0x1FC8EA0", Offset = "0x1FC7EA0", VA = "0x181FC8EA0")]
			internal bool JGOHNCMNEGF()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000118")]
			[Cpp2IlInjected.Address(RVA = "0x1FC8DE0", Offset = "0x1FC7DE0", VA = "0x181FC8DE0")]
			internal void ICEKHBLOBBH(bool v)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x1FC8D80", Offset = "0x1FC7D80", VA = "0x181FC8D80")]
		public HJGPIOPONDN(DLILHLIBGCM OPKEKBBFIHG, MKDINKFMEIO OEFGKJLECGH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x1FC8B30", Offset = "0x1FC7B30", VA = "0x181FC8B30", Slot = "126")]
		protected override void LABKBIBMBCF(OHIGDFFLHJA NMEBKEGDNCC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000049")]
	private sealed class HDPFKJMJAFI : AMPJOCEGNLH<BOABBPMFCJN>
	{
		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public override NodeVisualizationKey NAKCNJCFEHA
		{
			[Cpp2IlInjected.Token(Token = "0x6000119")]
			[Cpp2IlInjected.Address(RVA = "0x9AF2F0", Offset = "0x9AE2F0", VA = "0x1809AF2F0", Slot = "91")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x1FC8770", Offset = "0x1FC7770", VA = "0x181FC8770")]
		public HDPFKJMJAFI(DLILHLIBGCM OPKEKBBFIHG, BOABBPMFCJN OHDOOCGHDGN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004A")]
	public abstract class AMPJOCEGNLH<TNode> : CNGEGLEMEMP<TNode> where TNode : notnull, JPMDFHBPACI
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200004B")]
		[CompilerGenerated]
		private struct DILIBMLEDPM : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D2")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D3")]
			public AsyncTaskMethodBuilder<DFAHBLOKBPH<BGKDPCAKPBJ<IHOAGKINOHG>, CKBHMJGLAPL>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D4")]
			public AMPJOCEGNLH<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D5")]
			public string name;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D6")]
			private TaskAwaiter<DFAHBLOKBPH<BGKDPCAKPBJ<IHOAGKINOHG>, CKBHMJGLAPL>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600013F")]
			[Cpp2IlInjected.Address(RVA = "0x586BF70", Offset = "0x586AF70", VA = "0x18586BF70", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000140")]
			[Cpp2IlInjected.Address(RVA = "0x586C400", Offset = "0x586B400", VA = "0x18586C400", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200004C")]
		[CompilerGenerated]
		private struct BBEBIGGNLJF : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D7")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D8")]
			public AsyncTaskMethodBuilder<DFAHBLOKBPH<OKOMLKNINNF, CKBHMJGLAPL>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D9")]
			public AMPJOCEGNLH<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000DA")]
			public BGKDPCAKPBJ<IHOAGKINOHG> portGroupId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000DB")]
			private TaskAwaiter<DFAHBLOKBPH<OKOMLKNINNF, CKBHMJGLAPL>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000141")]
			[Cpp2IlInjected.Address(RVA = "0x4E72B40", Offset = "0x4E71B40", VA = "0x184E72B40", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000142")]
			[Cpp2IlInjected.Address(RVA = "0x4E72FB0", Offset = "0x4E71FB0", VA = "0x184E72FB0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200004E")]
		[CompilerGenerated]
		private struct KLMBPHMJBOO : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000E0")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000E1")]
			public AsyncTaskMethodBuilder<DFAHBLOKBPH<KADDDLHOCKA, CKBHMJGLAPL>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000E2")]
			public AMPJOCEGNLH<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000E3")]
			private TaskAwaiter<DFAHBLOKBPH<KADDDLHOCKA, CKBHMJGLAPL>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000148")]
			[Cpp2IlInjected.Address(RVA = "0x424D640", Offset = "0x424C640", VA = "0x18424D640", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000149")]
			[Cpp2IlInjected.Address(RVA = "0x424DCF0", Offset = "0x424CCF0", VA = "0x18424DCF0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200004F")]
		[CompilerGenerated]
		private sealed class FAGJMJLAIFI
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
				public FAGJMJLAIFI <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000EC")]
				private TaskAwaiter<TaskStatus> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x600014F")]
				[Cpp2IlInjected.Address(RVA = "0x35C8F40", Offset = "0x35C7F40", VA = "0x1835C8F40", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000150")]
				[Cpp2IlInjected.Address(RVA = "0xA6A710", Offset = "0xA69710", VA = "0x180A6A710", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000E4")]
			public OHIGDFFLHJA configure;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000E5")]
			public PCILEDIMGBH nodeAdapterDeps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000E6")]
			public AMPJOCEGNLH<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000E7")]
			public Func<string, bool> <>9__6;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000E8")]
			public Action <>9__7;

			[Cpp2IlInjected.Token(Token = "0x600014A")]
			[Cpp2IlInjected.Address(RVA = "0x85EB60", Offset = "0x85DB60", VA = "0x18085EB60")]
			public FAGJMJLAIFI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600014B")]
			[Cpp2IlInjected.Address(RVA = "0x3C19EB0", Offset = "0x3C18EB0", VA = "0x183C19EB0")]
			internal bool CNOGCEECIJC(string text)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600014C")]
			[Cpp2IlInjected.Address(RVA = "0x3C19F90", Offset = "0x3C18F90", VA = "0x183C19F90")]
			internal void NCGMJMFHGEA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600014D")]
			[Cpp2IlInjected.Address(RVA = "0x3C1A270", Offset = "0x3C19270", VA = "0x183C1A270")]
			[AsyncStateMachine(typeof(AMPJOCEGNLH<>.FAGJMJLAIFI.<<BuildConfigMenuInternal>b__7>d))]
			internal void OALPLEHLNDH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600014E")]
			[Cpp2IlInjected.Address(RVA = "0x3C1A310", Offset = "0x3C19310", VA = "0x183C1A310")]
			internal bool OIANKMMHODC()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000051")]
		[CompilerGenerated]
		private sealed class GDHEEJPINJH
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
				public GDHEEJPINJH <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000F5")]
				private TaskAwaiter<bool> <>u__1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000F6")]
				private TaskAwaiter<TaskStatus> <>u__2;

				[Cpp2IlInjected.Token(Token = "0x6000156")]
				[Cpp2IlInjected.Address(RVA = "0x35C8BD0", Offset = "0x35C7BD0", VA = "0x1835C8BD0", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000157")]
				[Cpp2IlInjected.Address(RVA = "0xA6A710", Offset = "0xA69710", VA = "0x180A6A710", Slot = "5")]
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
			public FAGJMJLAIFI CS$<>8__locals1;

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
			[Cpp2IlInjected.Address(RVA = "0x85EB60", Offset = "0x85DB60", VA = "0x18085EB60")]
			public GDHEEJPINJH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000152")]
			[Cpp2IlInjected.Address(RVA = "0x3D55290", Offset = "0x3D54290", VA = "0x183D55290")]
			internal void GNDADNGFDLE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000153")]
			[Cpp2IlInjected.Address(RVA = "0x8518C0", Offset = "0x8508C0", VA = "0x1808518C0")]
			internal string ADBLKAGNGFP()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000154")]
			[Cpp2IlInjected.Address(RVA = "0x851910", Offset = "0x850910", VA = "0x180851910")]
			internal void DMNAKLFEOCK(string value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000155")]
			[Cpp2IlInjected.Address(RVA = "0x3D55630", Offset = "0x3D54630", VA = "0x183D55630")]
			[AsyncStateMachine(typeof(AMPJOCEGNLH<>.GDHEEJPINJH.<<BuildConfigMenuInternal>b__5>d))]
			internal void LFNPCGFBCGF()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000053")]
		[CompilerGenerated]
		private sealed class GPGFMCNCDPH
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
				public GPGFMCNCDPH <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000108")]
				private TaskAwaiter<TaskStatus> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x600016B")]
				[Cpp2IlInjected.Address(RVA = "0x35C8700", Offset = "0x35C7700", VA = "0x1835C8700", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600016C")]
				[Cpp2IlInjected.Address(RVA = "0xA6A710", Offset = "0xA69710", VA = "0x180A6A710", Slot = "5")]
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
				public GPGFMCNCDPH <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400010C")]
				private TaskAwaiter<DFAHBLOKBPH<BGKDPCAKPBJ<HFFNHINIHLD>, CKBHMJGLAPL>> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x600016D")]
				[Cpp2IlInjected.Address(RVA = "0x35C88E0", Offset = "0x35C78E0", VA = "0x1835C88E0", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600016E")]
				[Cpp2IlInjected.Address(RVA = "0xA6A710", Offset = "0xA69710", VA = "0x180A6A710", Slot = "5")]
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
				public GPGFMCNCDPH <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000110")]
				private TaskAwaiter<DFAHBLOKBPH<BGKDPCAKPBJ<MBMIEFKCJNG>, CKBHMJGLAPL>> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x600016F")]
				[Cpp2IlInjected.Address(RVA = "0x35C8040", Offset = "0x35C7040", VA = "0x1835C8040", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000170")]
				[Cpp2IlInjected.Address(RVA = "0xA6A710", Offset = "0xA69710", VA = "0x180A6A710", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000F7")]
			public AMPJOCEGNLH<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000F8")]
			public BGKDPCAKPBJ<IHOAGKINOHG> portGroupId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000F9")]
			public OHIGDFFLHJA configure;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000FA")]
			public PCILEDIMGBH nodeAdapterDeps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000FB")]
			public MOFLLCAHOFM nodeGroupAdapter;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000FC")]
			public int minGroupIndex;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000FD")]
			public int maxGroupIndex;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000FE")]
			public IDGADJBCIPI selectedInputType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000FF")]
			public string newInputFieldLabel;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000100")]
			public List<BPOJJFHBONF> inputs;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000101")]
			public IDGADJBCIPI selectedOutputType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000102")]
			public string newOutputFieldLabel;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000103")]
			public List<BPOJJFHBONF> outputs;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000104")]
			public Func<string, bool> <>9__17;

			[Cpp2IlInjected.Token(Token = "0x6000158")]
			[Cpp2IlInjected.Address(RVA = "0x85EB60", Offset = "0x85DB60", VA = "0x18085EB60")]
			public GPGFMCNCDPH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000159")]
			[Cpp2IlInjected.Address(RVA = "0x3D98650", Offset = "0x3D97650", VA = "0x183D98650")]
			internal bool BKADCIIFIPN()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600015A")]
			[Cpp2IlInjected.Address(RVA = "0x3D98B40", Offset = "0x3D97B40", VA = "0x183D98B40")]
			internal void ILBBHKGEHFB(bool value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600015B")]
			[Cpp2IlInjected.Address(RVA = "0x3D98900", Offset = "0x3D97900", VA = "0x183D98900")]
			internal bool DLINCHHBFNB(string text)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600015C")]
			[Cpp2IlInjected.Address(RVA = "0x3D98DC0", Offset = "0x3D97DC0", VA = "0x183D98DC0")]
			internal bool MEOJGEKAHPF()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600015D")]
			[Cpp2IlInjected.Address(RVA = "0x3D989E0", Offset = "0x3D979E0", VA = "0x183D989E0")]
			[AsyncStateMachine(typeof(AMPJOCEGNLH<>.GPGFMCNCDPH.<<AddDynamicNodeGroupSettingV2>b__2>d))]
			internal void EPCCGLPPBNL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600015E")]
			[Cpp2IlInjected.Address(RVA = "0x3D98D10", Offset = "0x3D97D10", VA = "0x183D98D10")]
			internal bool KMMJDALKLDE()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600015F")]
			[Cpp2IlInjected.Address(RVA = "0x3D98A80", Offset = "0x3D97A80", VA = "0x183D98A80")]
			internal void IAPIPIFMENN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000160")]
			[Cpp2IlInjected.Address(RVA = "0x3D98BB0", Offset = "0x3D97BB0", VA = "0x183D98BB0")]
			internal bool JDDDDHOHFDO()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000161")]
			[Cpp2IlInjected.Address(RVA = "0x3D986C0", Offset = "0x3D976C0", VA = "0x183D986C0")]
			internal void BMGEOEMEEHM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000162")]
			[Cpp2IlInjected.Address(RVA = "0x3D98C60", Offset = "0x3D97C60", VA = "0x183D98C60")]
			internal bool KGHKDMCAJIJ()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000163")]
			[Cpp2IlInjected.Address(RVA = "0x3D98820", Offset = "0x3D97820", VA = "0x183D98820")]
			internal bool CNANFBFOHPM()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000164")]
			[Cpp2IlInjected.Address(RVA = "0x3D98D50", Offset = "0x3D97D50", VA = "0x183D98D50")]
			internal void LDDMPOHCMID(bool value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000165")]
			[Cpp2IlInjected.Address(RVA = "0x3D985B0", Offset = "0x3D975B0", VA = "0x183D985B0")]
			[AsyncStateMachine(typeof(AMPJOCEGNLH<>.GPGFMCNCDPH.<<AddDynamicNodeGroupSettingV2>b__6>d))]
			internal void BDKKBKPGBOA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000166")]
			[Cpp2IlInjected.Address(RVA = "0x3D98ED0", Offset = "0x3D97ED0", VA = "0x183D98ED0")]
			internal bool OIHNAKBAELH()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000167")]
			[Cpp2IlInjected.Address(RVA = "0x3D98E00", Offset = "0x3D97E00", VA = "0x183D98E00")]
			internal bool MLPKLHMJBPP()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000168")]
			[Cpp2IlInjected.Address(RVA = "0x3D98890", Offset = "0x3D97890", VA = "0x183D98890")]
			internal void DFJGCOJPMEK(bool value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000169")]
			[Cpp2IlInjected.Address(RVA = "0x3D98780", Offset = "0x3D97780", VA = "0x183D98780")]
			[AsyncStateMachine(typeof(AMPJOCEGNLH<>.GPGFMCNCDPH.<<AddDynamicNodeGroupSettingV2>b__10>d))]
			internal void CKEGOCKKBNG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600016A")]
			[Cpp2IlInjected.Address(RVA = "0x3D98E70", Offset = "0x3D97E70", VA = "0x183D98E70")]
			internal bool OICBNJDLFED()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000057")]
		[CompilerGenerated]
		private sealed class AIBJDPAJGPK
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
				public AIBJDPAJGPK <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000119")]
				private TaskAwaiter<bool> <>u__1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400011A")]
				private TaskAwaiter<DFAHBLOKBPH<OKOMLKNINNF, CKBHMJGLAPL>> <>u__2;

				[Cpp2IlInjected.Token(Token = "0x6000176")]
				[Cpp2IlInjected.Address(RVA = "0x35C8330", Offset = "0x35C7330", VA = "0x1835C8330", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000177")]
				[Cpp2IlInjected.Address(RVA = "0xA6A710", Offset = "0xA69710", VA = "0x180A6A710", Slot = "5")]
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
			public GPGFMCNCDPH CS$<>8__locals1;

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
			[Cpp2IlInjected.Address(RVA = "0x85EB60", Offset = "0x85DB60", VA = "0x18085EB60")]
			public AIBJDPAJGPK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000172")]
			[Cpp2IlInjected.Address(RVA = "0x3D1A820", Offset = "0x3D19820", VA = "0x183D1A820")]
			internal void EPANJOJFOND()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000173")]
			[Cpp2IlInjected.Address(RVA = "0x8518C0", Offset = "0x8508C0", VA = "0x1808518C0")]
			internal string FPKADANIHPB()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000174")]
			[Cpp2IlInjected.Address(RVA = "0x851910", Offset = "0x850910", VA = "0x180851910")]
			internal void CJCIJAMKLIL(string value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000175")]
			[Cpp2IlInjected.Address(RVA = "0x3D1A780", Offset = "0x3D19780", VA = "0x183D1A780")]
			[AsyncStateMachine(typeof(AMPJOCEGNLH<>.AIBJDPAJGPK.<<AddDynamicNodeGroupSettingV2>b__16>d))]
			internal void DHDHOGAGHGF()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000059")]
		[CompilerGenerated]
		private sealed class AGEKPPNHKFK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400011B")]
			public bool inputs;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400011C")]
			public MOFLLCAHOFM nodeGroupAdapter;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400011D")]
			public List<BPOJJFHBONF> portMenu;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400011E")]
			public AMPJOCEGNLH<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400011F")]
			public BGKDPCAKPBJ<IHOAGKINOHG> portGroupId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000120")]
			public int portCount;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000121")]
			public Func<bool> <>9__1;

			[Cpp2IlInjected.Token(Token = "0x6000178")]
			[Cpp2IlInjected.Address(RVA = "0x85EB60", Offset = "0x85DB60", VA = "0x18085EB60")]
			public AGEKPPNHKFK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000179")]
			[Cpp2IlInjected.Address(RVA = "0x3D08B80", Offset = "0x3D07B80", VA = "0x183D08B80")]
			internal bool HIKBDPDOODM()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200005A")]
		[CompilerGenerated]
		private sealed class LBBLCNEPFLJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000122")]
			public FDIFHNPIPOF port;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000123")]
			public AGEKPPNHKFK CS$<>8__locals1;

			[Cpp2IlInjected.Token(Token = "0x600017A")]
			[Cpp2IlInjected.Address(RVA = "0x85EB60", Offset = "0x85DB60", VA = "0x18085EB60")]
			public LBBLCNEPFLJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600017B")]
			[Cpp2IlInjected.Address(RVA = "0x42D6FF0", Offset = "0x42D5FF0", VA = "0x1842D6FF0")]
			internal void LIEDNADDFAP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600017C")]
			[Cpp2IlInjected.Address(RVA = "0x42D6FA0", Offset = "0x42D5FA0", VA = "0x1842D6FA0")]
			internal bool JOJMLGHJJKL()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600017D")]
			[Cpp2IlInjected.Address(RVA = "0x42D6E80", Offset = "0x42D5E80", VA = "0x1842D6E80")]
			internal void HFKEGNGEOFA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600017E")]
			[Cpp2IlInjected.Address(RVA = "0x42D6E20", Offset = "0x42D5E20", VA = "0x1842D6E20")]
			internal bool ECPKKFEHBPO()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200005B")]
		[CompilerGenerated]
		private sealed class JEFBCCEBGLB
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000124")]
			public BPOJJFHBONF portControls;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000125")]
			public LBBLCNEPFLJ CS$<>8__locals2;

			[Cpp2IlInjected.Token(Token = "0x600017F")]
			[Cpp2IlInjected.Address(RVA = "0x85EB60", Offset = "0x85DB60", VA = "0x18085EB60")]
			public JEFBCCEBGLB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000180")]
			[Cpp2IlInjected.Address(RVA = "0x4107250", Offset = "0x4106250", VA = "0x184107250")]
			internal void PGFLLPNCIIN()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200005C")]
		[CompilerGenerated]
		private sealed class HFJCPICPPDI
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
				public HFJCPICPPDI <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000130")]
				public string value;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000131")]
				private TaskAwaiter<bool> <>u__1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000132")]
				private TaskAwaiter<DFAHBLOKBPH<OKOMLKNINNF, CKBHMJGLAPL>> <>u__2;

				[Cpp2IlInjected.Token(Token = "0x6000187")]
				[Cpp2IlInjected.Address(RVA = "0x35CA340", Offset = "0x35C9340", VA = "0x1835CA340", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000188")]
				[Cpp2IlInjected.Address(RVA = "0xA6A710", Offset = "0xA69710", VA = "0x180A6A710", Slot = "5")]
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
			public IDGADJBCIPI selectedType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000128")]
			public bool inputs;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000129")]
			public MOFLLCAHOFM nodeGroupAdapter;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400012A")]
			public FDIFHNPIPOF port;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400012B")]
			public string newName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400012C")]
			public PCILEDIMGBH nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x6000181")]
			[Cpp2IlInjected.Address(RVA = "0x85EB60", Offset = "0x85DB60", VA = "0x18085EB60")]
			public HFJCPICPPDI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000182")]
			[Cpp2IlInjected.Address(RVA = "0x3DCB210", Offset = "0x3DCA210", VA = "0x183DCB210")]
			internal int OIPGGNCAAKF()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000183")]
			[Cpp2IlInjected.Address(RVA = "0x3DCAFC0", Offset = "0x3DC9FC0", VA = "0x183DCAFC0")]
			internal void GLKNFKHEMCG(int val)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000184")]
			[Cpp2IlInjected.Address(RVA = "0x851840", Offset = "0x850840", VA = "0x180851840")]
			internal string LJKHGKKNOKM()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000185")]
			[Cpp2IlInjected.Address(RVA = "0x3DCAF00", Offset = "0x3DC9F00", VA = "0x183DCAF00")]
			[AsyncStateMachine(typeof(AMPJOCEGNLH<>.HFJCPICPPDI.<<CreatePortItemV2>b__3>d))]
			internal void DGENONKIGKA(string value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000186")]
			[Cpp2IlInjected.Address(RVA = "0x3DCB250", Offset = "0x3DCA250", VA = "0x183DCB250")]
			internal bool OJDCNGOFFOH(string text)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		private readonly Dictionary<BGKDPCAKPBJ<IHOAGKINOHG>, bool> FJGKCMAEALH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		private readonly Dictionary<BGKDPCAKPBJ<IHOAGKINOHG>, bool> MNKBAFFJBFN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		private readonly Dictionary<BGKDPCAKPBJ<IHOAGKINOHG>, bool> DPDGKLGFNGP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		private Dictionary<BGKDPCAKPBJ<IHOAGKINOHG>, bool> OEEMABLEIGH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		private Dictionary<BGKDPCAKPBJ<IHOAGKINOHG>, bool> IOMLJEEBDDM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		private Dictionary<BGKDPCAKPBJ<IHOAGKINOHG>, bool> JAENLCIODPA;

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public override bool BEAKBLDBAPD
		{
			[Cpp2IlInjected.Token(Token = "0x600011B")]
			[Cpp2IlInjected.Address(RVA = "0x86C5D0", Offset = "0x86B5D0", VA = "0x18086C5D0", Slot = "122")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		protected virtual bool BFHJICAEGMN
		{
			[Cpp2IlInjected.Token(Token = "0x600011C")]
			[Cpp2IlInjected.Address(RVA = "0x86C5D0", Offset = "0x86B5D0", VA = "0x18086C5D0", Slot = "126")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		protected virtual bool JADOKPBFLEC
		{
			[Cpp2IlInjected.Token(Token = "0x600011D")]
			[Cpp2IlInjected.Address(RVA = "0x86C5D0", Offset = "0x86B5D0", VA = "0x18086C5D0", Slot = "127")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		protected virtual bool MDHBKNEGBFB
		{
			[Cpp2IlInjected.Token(Token = "0x600011E")]
			[Cpp2IlInjected.Address(RVA = "0x86C5D0", Offset = "0x86B5D0", VA = "0x18086C5D0", Slot = "128")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public override BGKDPCAKPBJ<EHIJHEMDKLF>? IIKIBPOGNLE
		{
			[Cpp2IlInjected.Token(Token = "0x600011F")]
			[Cpp2IlInjected.Address(RVA = "0x3E2F5E0", Offset = "0x3E2E5E0", VA = "0x183E2F5E0", Slot = "116")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public override BGKDPCAKPBJ<IHOAGKINOHG>? NGGHLMJBNGJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000120")]
			[Cpp2IlInjected.Address(RVA = "0x3E2F8B0", Offset = "0x3E2E8B0", VA = "0x183E2F8B0", Slot = "119")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public override IEnumerable<MFLENLEMIJF<PMIFAKHBGDE>>? BEOOECKAFCB
		{
			[Cpp2IlInjected.Token(Token = "0x600012B")]
			[Cpp2IlInjected.Address(RVA = "0x3E2F6A0", Offset = "0x3E2E6A0", VA = "0x183E2F6A0", Slot = "111")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x3E2F3C0", Offset = "0x3E2E3C0", VA = "0x183E2F3C0")]
		public AMPJOCEGNLH(DLILHLIBGCM OPKEKBBFIHG, TNode OHDOOCGHDGN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x86C5D0", Offset = "0x86B5D0", VA = "0x18086C5D0", Slot = "129")]
		protected virtual bool BNCEMJEJPOL(int CCHMCNEPHDK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x86C5D0", Offset = "0x86B5D0", VA = "0x18086C5D0", Slot = "130")]
		protected virtual bool IFCIJLELFON(int CCHMCNEPHDK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x86C5D0", Offset = "0x86B5D0", VA = "0x18086C5D0", Slot = "131")]
		protected virtual bool BDPIBPPANKM(int CCHMCNEPHDK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x853950", Offset = "0x852950", VA = "0x180853950", Slot = "132")]
		protected virtual void OLCBFPGCCGD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x3E2E7A0", Offset = "0x3E2D7A0", VA = "0x183E2E7A0", Slot = "124")]
		public override bool NFBEILNBBGL(BGKDPCAKPBJ<IHOAGKINOHG> FCFGPBAFAPA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x3E2F190", Offset = "0x3E2E190", VA = "0x183E2F190", Slot = "100")]
		[AsyncStateMachine(typeof(AMPJOCEGNLH<>.DILIBMLEDPM))]
		public override Task<DFAHBLOKBPH<BGKDPCAKPBJ<IHOAGKINOHG>, CKBHMJGLAPL>> PGIDCCGEGJH(string CKEJJGPNKGO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x3E2F2B0", Offset = "0x3E2E2B0", VA = "0x183E2F2B0", Slot = "101")]
		[AsyncStateMachine(typeof(AMPJOCEGNLH<>.BBEBIGGNLJF))]
		public override Task<DFAHBLOKBPH<OKOMLKNINNF, CKBHMJGLAPL>> PHDPIMFBHPJ(BGKDPCAKPBJ<IHOAGKINOHG> FCFGPBAFAPA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x3E2BD90", Offset = "0x3E2AD90", VA = "0x183E2BD90", Slot = "102")]
		public override void FKHOGEFEOLJ(BGKDPCAKPBJ<IHOAGKINOHG> HCALFJOJKJO, BGKDPCAKPBJ<IHOAGKINOHG> KAEDHDLBKFF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x3E2E4A0", Offset = "0x3E2D4A0", VA = "0x183E2E4A0", Slot = "103")]
		public override IEnumerable<LJHEBKBBECA> MAINAJBNDIJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x3E2CC80", Offset = "0x3E2BC80", VA = "0x183E2CC80")]
		[AsyncStateMachine(typeof(AMPJOCEGNLH<>.KLMBPHMJBOO))]
		private Task<DFAHBLOKBPH<KADDDLHOCKA, CKBHMJGLAPL>> LLHJOONHILB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x86C5D0", Offset = "0x86B5D0", VA = "0x18086C5D0", Slot = "133")]
		protected virtual bool PAEEJENEHFM(BGKDPCAKPBJ<IHOAGKINOHG> FCFGPBAFAPA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x86C5D0", Offset = "0x86B5D0", VA = "0x18086C5D0", Slot = "134")]
		protected virtual bool MCJHLLDFIKM(BGKDPCAKPBJ<IHOAGKINOHG> FCFGPBAFAPA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x86C5D0", Offset = "0x86B5D0", VA = "0x18086C5D0", Slot = "135")]
		protected virtual bool FMMJKALAIDH(BGKDPCAKPBJ<IHOAGKINOHG> FCFGPBAFAPA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x86C5D0", Offset = "0x86B5D0", VA = "0x18086C5D0", Slot = "136")]
		protected virtual bool CNDLLDPIMDJ(BGKDPCAKPBJ<IHOAGKINOHG> FCFGPBAFAPA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x86C5D0", Offset = "0x86B5D0", VA = "0x18086C5D0", Slot = "137")]
		protected virtual bool FJFMHCOOBJL(BGKDPCAKPBJ<IHOAGKINOHG> FCFGPBAFAPA, int KLPHADDHJKI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x86C5D0", Offset = "0x86B5D0", VA = "0x18086C5D0", Slot = "138")]
		protected virtual bool PJHEOHLLIHC(BGKDPCAKPBJ<IHOAGKINOHG> FCFGPBAFAPA, int KLPHADDHJKI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x86C5D0", Offset = "0x86B5D0", VA = "0x18086C5D0", Slot = "139")]
		protected virtual bool HOBNLFLLAHJ(BGKDPCAKPBJ<IHOAGKINOHG> FCFGPBAFAPA, int ODBNMKOEOOJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x86C5D0", Offset = "0x86B5D0", VA = "0x18086C5D0", Slot = "140")]
		protected virtual bool DKMKAAFDBCN(BGKDPCAKPBJ<IHOAGKINOHG> FCFGPBAFAPA, int ODBNMKOEOOJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x86C5D0", Offset = "0x86B5D0", VA = "0x18086C5D0", Slot = "141")]
		protected virtual bool MCEDAFJOPKK(BGKDPCAKPBJ<IHOAGKINOHG> FCFGPBAFAPA, int MHMEGHMBDAL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x86C5D0", Offset = "0x86B5D0", VA = "0x18086C5D0", Slot = "142")]
		protected virtual bool IHDGHAMLAHH(BGKDPCAKPBJ<IHOAGKINOHG> FCFGPBAFAPA, int FCPCFFHNMNC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x3E2C9F0", Offset = "0x3E2B9F0", VA = "0x183E2C9F0", Slot = "143")]
		protected virtual List<IDGADJBCIPI> HCHFPBDCHNO(BGKDPCAKPBJ<IHOAGKINOHG> FCFGPBAFAPA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x853950", Offset = "0x852950", VA = "0x180853950", Slot = "144")]
		protected virtual void HKIJMBDDKDN(OHIGDFFLHJA NMEBKEGDNCC, HHMMBPIOEHB KIMEDLINIBA, MOFLLCAHOFM NBGBCENIDME)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x3E2BF90", Offset = "0x3E2AF90", VA = "0x183E2BF90", Slot = "120")]
		protected override void GHIPLIDCNEB(OHIGDFFLHJA NMEBKEGDNCC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x3E2CD80", Offset = "0x3E2BD80", VA = "0x183E2CD80")]
		private HHMMBPIOEHB LNDDNIJDNFD(OHIGDFFLHJA NMEBKEGDNCC, MOFLLCAHOFM NBGBCENIDME, BGKDPCAKPBJ<IHOAGKINOHG> FCFGPBAFAPA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x3E2AC50", Offset = "0x3E29C50", VA = "0x183E2AC50")]
		private List<BPOJJFHBONF> EKLIMKEEJJM(OHIGDFFLHJA NMEBKEGDNCC, MOFLLCAHOFM NBGBCENIDME, HHMMBPIOEHB MJFJGNEHMLP, bool FHCLAGOMKDK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x3E2E840", Offset = "0x3E2D840", VA = "0x183E2E840")]
		private List<BPOJJFHBONF> OLGKDIIKLJJ(OHIGDFFLHJA NMEBKEGDNCC, MOFLLCAHOFM NBGBCENIDME, FDIFHNPIPOF APLBJFAIJKB, bool FHCLAGOMKDK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x3E2AA60", Offset = "0x3E29A60", VA = "0x183E2AA60")]
		private IDGADJBCIPI BELCEAKOPKJ(List<IDGADJBCIPI> GLMIKEOEKED, FDIFHNPIPOF APLBJFAIJKB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x3E2E710", Offset = "0x3E2D710", VA = "0x183E2E710")]
		[CompilerGenerated]
		private LJHEBKBBECA MLNFHNHDKNF(EMGONNJLBBJ GGJGGMKAJPM)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005E")]
	public sealed class FLALDDJKPNE : CNGEGLEMEMP<KKPGPLCBGFD>
	{
		[Cpp2IlInjected.Token(Token = "0x200005F")]
		[CompilerGenerated]
		private sealed class MPCBHDDNFJN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000133")]
			public FLALDDJKPNE <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000134")]
			public PCILEDIMGBH nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x600018C")]
			[Cpp2IlInjected.Address(RVA = "0x85EB60", Offset = "0x85DB60", VA = "0x18085EB60")]
			public MPCBHDDNFJN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600018D")]
			[Cpp2IlInjected.Address(RVA = "0x1FCCBF0", Offset = "0x1FCBBF0", VA = "0x181FCCBF0")]
			internal int NCGMJMFHGEA()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x600018E")]
			[Cpp2IlInjected.Address(RVA = "0x1FCCC40", Offset = "0x1FCBC40", VA = "0x181FCCC40")]
			internal void OIANKMMHODC(int colorIndex)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public override NodeVisualizationKey NAKCNJCFEHA
		{
			[Cpp2IlInjected.Token(Token = "0x600018A")]
			[Cpp2IlInjected.Address(RVA = "0x996090", Offset = "0x995090", VA = "0x180996090", Slot = "91")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x1FB8EA0", Offset = "0x1FB7EA0", VA = "0x181FB8EA0")]
		public FLALDDJKPNE(DLILHLIBGCM OPKEKBBFIHG, KKPGPLCBGFD OHDOOCGHDGN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x1FB8CE0", Offset = "0x1FB7CE0", VA = "0x181FB8CE0", Slot = "120")]
		protected override void GHIPLIDCNEB(OHIGDFFLHJA NMEBKEGDNCC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000060")]
	public sealed class ALMPDJFDOCH : AGBOAEKDJHB<HNKALBKKLEJ>
	{
		[Cpp2IlInjected.Token(Token = "0x2000061")]
		[CompilerGenerated]
		private sealed class OJHEJEEDOOJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000135")]
			public ALMPDJFDOCH <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000136")]
			public PCILEDIMGBH nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x6000191")]
			[Cpp2IlInjected.Address(RVA = "0x85EB60", Offset = "0x85DB60", VA = "0x18085EB60")]
			public OJHEJEEDOOJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000192")]
			[Cpp2IlInjected.Address(RVA = "0x1FCF580", Offset = "0x1FCE580", VA = "0x181FCF580")]
			internal int JGOHNCMNEGF()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000193")]
			[Cpp2IlInjected.Address(RVA = "0x1FCF4E0", Offset = "0x1FCE4E0", VA = "0x181FCF4E0")]
			internal void ICEKHBLOBBH(int colorIndex)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x1FB3730", Offset = "0x1FB2730", VA = "0x181FB3730")]
		public ALMPDJFDOCH(DLILHLIBGCM OPKEKBBFIHG, HNKALBKKLEJ OEFGKJLECGH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x1FB34F0", Offset = "0x1FB24F0", VA = "0x181FB34F0", Slot = "126")]
		protected override void LABKBIBMBCF(OHIGDFFLHJA NMEBKEGDNCC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000062")]
	private sealed class JCNOFJKAAGH : CNGEGLEMEMP<ICJPLMABHCF>
	{
		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public override NodeVisualizationKey NAKCNJCFEHA
		{
			[Cpp2IlInjected.Token(Token = "0x6000194")]
			[Cpp2IlInjected.Address(RVA = "0x96C5A0", Offset = "0x96B5A0", VA = "0x18096C5A0", Slot = "91")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x1FCAEF0", Offset = "0x1FC9EF0", VA = "0x181FCAEF0")]
		public JCNOFJKAAGH(DLILHLIBGCM OPKEKBBFIHG, ICJPLMABHCF OHDOOCGHDGN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x853950", Offset = "0x852950", VA = "0x180853950", Slot = "120")]
		protected override void GHIPLIDCNEB(OHIGDFFLHJA NMEBKEGDNCC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000063")]
	public sealed class FKEFFFKIKAD : CNGEGLEMEMP<EDHMOEKBIJG>
	{
		[Cpp2IlInjected.Token(Token = "0x2000064")]
		[CompilerGenerated]
		private sealed class FPIPDIPEMPM
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000138")]
			public FKEFFFKIKAD <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000139")]
			public OHIGDFFLHJA configure;

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
			[Cpp2IlInjected.Address(RVA = "0x85EB60", Offset = "0x85DB60", VA = "0x18085EB60")]
			public FPIPDIPEMPM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600019A")]
			[Cpp2IlInjected.Address(RVA = "0x1FC30C0", Offset = "0x1FC20C0", VA = "0x181FC30C0")]
			internal bool NCGMJMFHGEA()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600019B")]
			[Cpp2IlInjected.Address(RVA = "0x1FC37D0", Offset = "0x1FC27D0", VA = "0x181FC37D0")]
			internal void OIANKMMHODC(bool x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600019C")]
			[Cpp2IlInjected.Address(RVA = "0x1FBA5A0", Offset = "0x1FB95A0", VA = "0x181FBA5A0")]
			internal bool DMNAKLFEOCK()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600019D")]
			[Cpp2IlInjected.Address(RVA = "0x1FC2910", Offset = "0x1FC1910", VA = "0x181FC2910")]
			internal bool LFNPCGFBCGF()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600019E")]
			[Cpp2IlInjected.Address(RVA = "0x1FBA1B0", Offset = "0x1FB91B0", VA = "0x181FBA1B0")]
			internal void CNOGCEECIJC(bool x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600019F")]
			[Cpp2IlInjected.Address(RVA = "0x1FC1730", Offset = "0x1FC0730", VA = "0x181FC1730")]
			internal bool HJJPONJCFNA()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001A0")]
			[Cpp2IlInjected.Address(RVA = "0x1FC3CC0", Offset = "0x1FC2CC0", VA = "0x181FC3CC0")]
			internal bool PDJOAMHIGED()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001A1")]
			[Cpp2IlInjected.Address(RVA = "0x1FB9190", Offset = "0x1FB8190", VA = "0x181FB9190")]
			internal void ACJOGNOGIIG(bool x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A2")]
			[Cpp2IlInjected.Address(RVA = "0x1FBA410", Offset = "0x1FB9410", VA = "0x181FBA410")]
			internal bool DEJALFELGHA()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001A3")]
			[Cpp2IlInjected.Address(RVA = "0x1FC2EC0", Offset = "0x1FC1EC0", VA = "0x181FC2EC0")]
			internal bool MHMBEFINAIM()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001A4")]
			[Cpp2IlInjected.Address(RVA = "0x1FBA7D0", Offset = "0x1FB97D0", VA = "0x181FBA7D0")]
			internal void EDDPMGNGHJG(bool x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A5")]
			[Cpp2IlInjected.Address(RVA = "0x1FC39F0", Offset = "0x1FC29F0", VA = "0x181FC39F0")]
			internal bool OOCDNOBGINM()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001A6")]
			[Cpp2IlInjected.Address(RVA = "0x1FB9380", Offset = "0x1FB8380", VA = "0x181FB9380")]
			internal bool AGGDHMELCAJ()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001A7")]
			[Cpp2IlInjected.Address(RVA = "0x1FB92E0", Offset = "0x1FB82E0", VA = "0x181FB92E0")]
			internal bool AGDNDCDPBFO()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001A8")]
			[Cpp2IlInjected.Address(RVA = "0x1FBA260", Offset = "0x1FB9260", VA = "0x181FBA260")]
			internal bool COOCLKNLEGN()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001A9")]
			[Cpp2IlInjected.Address(RVA = "0x1FC2410", Offset = "0x1FC1410", VA = "0x181FC2410")]
			internal bool KFAJCCBAOBM()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001AA")]
			[Cpp2IlInjected.Address(RVA = "0x1FC2A00", Offset = "0x1FC1A00", VA = "0x181FC2A00")]
			internal bool LGEMBGKCMJM()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001AB")]
			[Cpp2IlInjected.Address(RVA = "0x1FC3110", Offset = "0x1FC2110", VA = "0x181FC3110")]
			internal bool NCIEJDLEOEE()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001AC")]
			[Cpp2IlInjected.Address(RVA = "0x1FC3BD0", Offset = "0x1FC2BD0", VA = "0x181FC3BD0")]
			internal bool PBKJKMPCPJM()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001AD")]
			[Cpp2IlInjected.Address(RVA = "0x1FC1D10", Offset = "0x1FC0D10", VA = "0x181FC1D10")]
			internal bool ILLPFMLPKIA()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001AE")]
			[Cpp2IlInjected.Address(RVA = "0x1FC28B0", Offset = "0x1FC18B0", VA = "0x181FC28B0")]
			internal void LAEBKDGGCPD(bool x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001AF")]
			[Cpp2IlInjected.Address(RVA = "0x1FB9770", Offset = "0x1FB8770", VA = "0x181FB9770")]
			internal bool BCOGOIPIBNN()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001B0")]
			[Cpp2IlInjected.Address(RVA = "0x1FC0FC0", Offset = "0x1FBFFC0", VA = "0x181FC0FC0")]
			internal bool GCJKIMDDEOF()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001B1")]
			[Cpp2IlInjected.Address(RVA = "0x1FC3C20", Offset = "0x1FC2C20", VA = "0x181FC3C20")]
			internal bool PBNHBGBBIOG()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001B2")]
			[Cpp2IlInjected.Address(RVA = "0x1FB99A0", Offset = "0x1FB89A0", VA = "0x181FB99A0")]
			internal bool BMBGJFBICFJ()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001B3")]
			[Cpp2IlInjected.Address(RVA = "0x1FC2050", Offset = "0x1FC1050", VA = "0x181FC2050")]
			internal bool JFPKKJGENEH()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001B4")]
			[Cpp2IlInjected.Address(RVA = "0x1FBA690", Offset = "0x1FB9690", VA = "0x181FBA690")]
			internal bool DNLMLCJBAEO()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001B5")]
			[Cpp2IlInjected.Address(RVA = "0x1FC2C80", Offset = "0x1FC1C80", VA = "0x181FC2C80")]
			internal bool MACJGHFJHHH()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001B6")]
			[Cpp2IlInjected.Address(RVA = "0x1FC1AD0", Offset = "0x1FC0AD0", VA = "0x181FC1AD0")]
			internal bool IIKEBCBMCJO()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001B7")]
			[Cpp2IlInjected.Address(RVA = "0x1FC24D0", Offset = "0x1FC14D0", VA = "0x181FC24D0")]
			internal void KFOKBCFKFLF(bool x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001B8")]
			[Cpp2IlInjected.Address(RVA = "0x1FC33F0", Offset = "0x1FC23F0", VA = "0x181FC33F0")]
			internal bool NLMPNIPPJMO()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001B9")]
			[Cpp2IlInjected.Address(RVA = "0x1FBA640", Offset = "0x1FB9640", VA = "0x181FBA640")]
			internal bool DMPNLALHJPI()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001BA")]
			[Cpp2IlInjected.Address(RVA = "0x1FC2B80", Offset = "0x1FC1B80", VA = "0x181FC2B80")]
			internal void LOBCDJLEOBD(bool x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001BB")]
			[Cpp2IlInjected.Address(RVA = "0x1FBA060", Offset = "0x1FB9060", VA = "0x181FBA060")]
			internal bool CHMGGPDNNPO()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001BC")]
			[Cpp2IlInjected.Address(RVA = "0x1FBA830", Offset = "0x1FB9830", VA = "0x181FBA830")]
			internal bool EEENKNMMBFE()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001BD")]
			[Cpp2IlInjected.Address(RVA = "0x1FC1CB0", Offset = "0x1FC0CB0", VA = "0x181FC1CB0")]
			internal void ILHOLDICENJ(bool x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001BE")]
			[Cpp2IlInjected.Address(RVA = "0x1FBAA10", Offset = "0x1FB9A10", VA = "0x181FBAA10")]
			internal List<BPOJJFHBONF> EPEOEHOGJPD(string secondaryLabel)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001BF")]
			[Cpp2IlInjected.Address(RVA = "0x1FC2AE0", Offset = "0x1FC1AE0", VA = "0x181FC2AE0")]
			internal bool LHIBJCFNOLI()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001C0")]
			[Cpp2IlInjected.Address(RVA = "0x1FC20F0", Offset = "0x1FC10F0", VA = "0x181FC20F0")]
			internal int JJOKBNALIMK()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60001C1")]
			[Cpp2IlInjected.Address(RVA = "0x1FC3590", Offset = "0x1FC2590", VA = "0x181FC3590")]
			internal void NPOLIFBDIJK(int x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C2")]
			[Cpp2IlInjected.Address(RVA = "0x1FC1A30", Offset = "0x1FC0A30", VA = "0x181FC1A30")]
			internal bool IGABCOMACFM()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001C3")]
			[Cpp2IlInjected.Address(RVA = "0x1FC19E0", Offset = "0x1FC09E0", VA = "0x181FC19E0")]
			internal bool IEKNLILKANO()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001C4")]
			[Cpp2IlInjected.Address(RVA = "0x1FC3DB0", Offset = "0x1FC2DB0", VA = "0x181FC3DB0")]
			internal bool PIOIAJPMJCG()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001C5")]
			[Cpp2IlInjected.Address(RVA = "0x1FBA3C0", Offset = "0x1FB93C0", VA = "0x181FBA3C0")]
			internal int DBFCGNMODHB()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60001C6")]
			[Cpp2IlInjected.Address(RVA = "0x1FC23B0", Offset = "0x1FC13B0", VA = "0x181FC23B0")]
			internal void KABPIFEPOOH(int x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C7")]
			[Cpp2IlInjected.Address(RVA = "0x1FB91F0", Offset = "0x1FB81F0", VA = "0x181FB91F0")]
			internal bool ACLENAEJADC()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001C8")]
			[Cpp2IlInjected.Address(RVA = "0x1FC16E0", Offset = "0x1FC06E0", VA = "0x181FC16E0")]
			internal bool HJDMMEACFOM()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001C9")]
			[Cpp2IlInjected.Address(RVA = "0x1FC3B30", Offset = "0x1FC2B30", VA = "0x181FC3B30")]
			internal bool OPIIHFMMCAF()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001CA")]
			[Cpp2IlInjected.Address(RVA = "0x1FC0ED0", Offset = "0x1FBFED0", VA = "0x181FC0ED0")]
			internal bool GAABOMBFDMK()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001CB")]
			[Cpp2IlInjected.Address(RVA = "0x1FBA9C0", Offset = "0x1FB99C0", VA = "0x181FBA9C0")]
			internal bool ELGGKJDJBDP()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001CC")]
			[Cpp2IlInjected.Address(RVA = "0x1FC3880", Offset = "0x1FC2880", VA = "0x181FC3880")]
			internal bool OLEGDLFLJFN()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001CD")]
			[Cpp2IlInjected.Address(RVA = "0x1FC1EB0", Offset = "0x1FC0EB0", VA = "0x181FC1EB0")]
			internal string IOMDHFNAIHP()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001CE")]
			[Cpp2IlInjected.Address(RVA = "0x1FC2340", Offset = "0x1FC1340", VA = "0x181FC2340")]
			internal void JPMOCOKBOEB(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001CF")]
			[Cpp2IlInjected.Address(RVA = "0x1FC3B80", Offset = "0x1FC2B80", VA = "0x181FC3B80")]
			internal int PAAODHOGPCJ()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60001D0")]
			[Cpp2IlInjected.Address(RVA = "0x1FC1F50", Offset = "0x1FC0F50", VA = "0x181FC1F50")]
			internal void JAGPBGCPBGG(int x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001D1")]
			[Cpp2IlInjected.Address(RVA = "0x1FC21F0", Offset = "0x1FC11F0", VA = "0x181FC21F0")]
			internal bool JLABLILMCDE()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001D2")]
			[Cpp2IlInjected.Address(RVA = "0x1FC0DE0", Offset = "0x1FBFDE0", VA = "0x181FC0DE0")]
			internal bool FNMOEGJIBKH()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001D3")]
			[Cpp2IlInjected.Address(RVA = "0x1FC36E0", Offset = "0x1FC26E0", VA = "0x181FC36E0")]
			internal bool OEMNKGAEJBC()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001D4")]
			[Cpp2IlInjected.Address(RVA = "0x1FC2730", Offset = "0x1FC1730", VA = "0x181FC2730")]
			internal float KOHKNMCJHDN()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x60001D5")]
			[Cpp2IlInjected.Address(RVA = "0x1FC22E0", Offset = "0x1FC12E0", VA = "0x181FC22E0")]
			internal void JOCEALMKOEF(float x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001D6")]
			[Cpp2IlInjected.Address(RVA = "0x1FC1A80", Offset = "0x1FC0A80", VA = "0x181FC1A80")]
			internal bool IGGLFGKPGPK()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001D7")]
			[Cpp2IlInjected.Address(RVA = "0x1FC17F0", Offset = "0x1FC07F0", VA = "0x181FC17F0")]
			internal bool HMEMLAMIMGA()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001D8")]
			[Cpp2IlInjected.Address(RVA = "0x1FC0D30", Offset = "0x1FBFD30", VA = "0x181FC0D30")]
			internal bool FMBJDNDHKIF()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001D9")]
			[Cpp2IlInjected.Address(RVA = "0x1FB9240", Offset = "0x1FB8240", VA = "0x181FB9240")]
			internal bool AEDFEMHDBHL()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001DA")]
			[Cpp2IlInjected.Address(RVA = "0x1FC2F80", Offset = "0x1FC1F80", VA = "0x181FC2F80")]
			internal bool MILPLLICJHK()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001DB")]
			[Cpp2IlInjected.Address(RVA = "0x1FC1690", Offset = "0x1FC0690", VA = "0x181FC1690")]
			internal bool HHKHMJGJONB()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001DC")]
			[Cpp2IlInjected.Address(RVA = "0x1FB9A80", Offset = "0x1FB8A80", VA = "0x181FB9A80")]
			internal void BOMNIMLNNCB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001DD")]
			[Cpp2IlInjected.Address(RVA = "0x1FC3260", Offset = "0x1FC2260", VA = "0x181FC3260")]
			internal string NIGGJHNIEBC()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001DE")]
			[Cpp2IlInjected.Address(RVA = "0x1FC3E50", Offset = "0x1FC2E50", VA = "0x181FC3E50")]
			internal void POJENFJMCLD(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001DF")]
			[Cpp2IlInjected.Address(RVA = "0x1FC14B0", Offset = "0x1FC04B0", VA = "0x181FC14B0")]
			internal bool HBLPAEGFBMI()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001E0")]
			[Cpp2IlInjected.Address(RVA = "0x1FC2620", Offset = "0x1FC1620", VA = "0x181FC2620")]
			internal bool KKJAJFHHKFM()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001E1")]
			[Cpp2IlInjected.Address(RVA = "0x1FBA550", Offset = "0x1FB9550", VA = "0x181FBA550")]
			internal bool DJJIFPHBIOF()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001E2")]
			[Cpp2IlInjected.Address(RVA = "0x1FC1010", Offset = "0x1FC0010", VA = "0x181FC1010")]
			internal void GEJGEHBBEAN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001E3")]
			[Cpp2IlInjected.Address(RVA = "0x1FC3730", Offset = "0x1FC2730", VA = "0x181FC3730")]
			internal bool OFGAFLINEBH()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001E4")]
			[Cpp2IlInjected.Address(RVA = "0x1FB9900", Offset = "0x1FB8900", VA = "0x181FB9900")]
			internal bool BLDPLGIPHKB()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001E5")]
			[Cpp2IlInjected.Address(RVA = "0x1FC0E80", Offset = "0x1FBFE80", VA = "0x181FC0E80")]
			internal bool FPLFHHFKKBH()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001E6")]
			[Cpp2IlInjected.Address(RVA = "0x1FC2780", Offset = "0x1FC1780", VA = "0x181FC2780")]
			internal bool KPJGBJEEHID()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001E7")]
			[Cpp2IlInjected.Address(RVA = "0x1FC2CD0", Offset = "0x1FC1CD0", VA = "0x181FC2CD0")]
			internal void MAOFHMJMHBD(bool x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001E8")]
			[Cpp2IlInjected.Address(RVA = "0x1FB9290", Offset = "0x1FB8290", VA = "0x181FB9290")]
			internal bool AFDGBJBJLIB()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001E9")]
			[Cpp2IlInjected.Address(RVA = "0x1FC21A0", Offset = "0x1FC11A0", VA = "0x181FC21A0")]
			internal bool JKGJKCEHBIC()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001EA")]
			[Cpp2IlInjected.Address(RVA = "0x1FB9860", Offset = "0x1FB8860", VA = "0x181FB9860")]
			internal bool BGOHPHBLPLC()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001EB")]
			[Cpp2IlInjected.Address(RVA = "0x1FC1840", Offset = "0x1FC0840", VA = "0x181FC1840")]
			internal bool HNHDCDOMLLL()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001EC")]
			[Cpp2IlInjected.Address(RVA = "0x1FBA150", Offset = "0x1FB9150", VA = "0x181FBA150")]
			internal void CMGPFPCEOGI(bool x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001ED")]
			[Cpp2IlInjected.Address(RVA = "0x1FBA010", Offset = "0x1FB9010", VA = "0x181FBA010")]
			internal bool CGMKIJIMPAM()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001EE")]
			[Cpp2IlInjected.Address(RVA = "0x1FC15A0", Offset = "0x1FC05A0", VA = "0x181FC15A0")]
			internal bool HFDCHBCPBDH()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001EF")]
			[Cpp2IlInjected.Address(RVA = "0x1FC3D10", Offset = "0x1FC2D10", VA = "0x181FC3D10")]
			internal bool PDPEFEDENCN()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001F0")]
			[Cpp2IlInjected.Address(RVA = "0x1FB9440", Offset = "0x1FB8440", VA = "0x181FB9440")]
			internal bool AJAACJBKJON()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001F1")]
			[Cpp2IlInjected.Address(RVA = "0x1FBA210", Offset = "0x1FB9210", VA = "0x181FBA210")]
			internal int COHJNAFFPHK()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60001F2")]
			[Cpp2IlInjected.Address(RVA = "0x1FB99F0", Offset = "0x1FB89F0", VA = "0x181FB99F0")]
			internal void BNHKKENNEDL(object x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001F3")]
			[Cpp2IlInjected.Address(RVA = "0x1FC0F70", Offset = "0x1FBFF70", VA = "0x181FC0F70")]
			internal bool GBPPLPCOEKI()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001F4")]
			[Cpp2IlInjected.Address(RVA = "0x1FBA100", Offset = "0x1FB9100", VA = "0x181FBA100")]
			internal bool CJMCJOFDPDI()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001F5")]
			[Cpp2IlInjected.Address(RVA = "0x1FC2580", Offset = "0x1FC1580", VA = "0x181FC2580")]
			internal int KIBEFCHCDPL()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60001F6")]
			[Cpp2IlInjected.Address(RVA = "0x1FC31B0", Offset = "0x1FC21B0", VA = "0x181FC31B0")]
			internal void NDNGHCCHBBD(int x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001F7")]
			[Cpp2IlInjected.Address(RVA = "0x1FC3E00", Offset = "0x1FC2E00", VA = "0x181FC3E00")]
			internal bool PLCCKFAAAGB()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001F8")]
			[Cpp2IlInjected.Address(RVA = "0x1FC1550", Offset = "0x1FC0550", VA = "0x181FC1550")]
			internal bool HEPBBHHLNCA()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001F9")]
			[Cpp2IlInjected.Address(RVA = "0x1FC2BE0", Offset = "0x1FC1BE0", VA = "0x181FC2BE0")]
			internal int LOKHHJAOAIH()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60001FA")]
			[Cpp2IlInjected.Address(RVA = "0x1FC1DB0", Offset = "0x1FC0DB0", VA = "0x181FC1DB0")]
			internal void IMBPBGFPBME(int x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001FB")]
			[Cpp2IlInjected.Address(RVA = "0x1FC0C00", Offset = "0x1FBFC00", VA = "0x181FC0C00")]
			internal bool FCLDDFBLAEH()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001FC")]
			[Cpp2IlInjected.Address(RVA = "0x1FC35F0", Offset = "0x1FC25F0", VA = "0x181FC35F0")]
			internal bool OBJOOOICLDI()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001FD")]
			[Cpp2IlInjected.Address(RVA = "0x1FC0E30", Offset = "0x1FBFE30", VA = "0x181FC0E30")]
			internal bool FOBPFPNNLDK()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001FE")]
			[Cpp2IlInjected.Address(RVA = "0x1FC1330", Offset = "0x1FC0330", VA = "0x181FC1330")]
			internal int GMCEOKCPLBE()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60001FF")]
			[Cpp2IlInjected.Address(RVA = "0x1FC2140", Offset = "0x1FC1140", VA = "0x181FC2140")]
			internal void JKEFHAPMKKK(int x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000200")]
			[Cpp2IlInjected.Address(RVA = "0x1FC3D60", Offset = "0x1FC2D60", VA = "0x181FC3D60")]
			internal bool PGCLKDFHCNN()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000201")]
			[Cpp2IlInjected.Address(RVA = "0x1FC1940", Offset = "0x1FC0940", VA = "0x181FC1940")]
			internal bool IDBHBHONAMC()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000202")]
			[Cpp2IlInjected.Address(RVA = "0x1FC1E60", Offset = "0x1FC0E60", VA = "0x181FC1E60")]
			internal bool IOJPJEOGJKN()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000203")]
			[Cpp2IlInjected.Address(RVA = "0x1FB9FA0", Offset = "0x1FB8FA0", VA = "0x181FB9FA0")]
			internal object CFNPLJNEDGE()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000204")]
			[Cpp2IlInjected.Address(RVA = "0x1FC27D0", Offset = "0x1FC17D0", VA = "0x181FC27D0")]
			internal void LABHAKELCDN(object x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000205")]
			[Cpp2IlInjected.Address(RVA = "0x1FC3020", Offset = "0x1FC2020", VA = "0x181FC3020")]
			internal bool NAHHEDCNJCE()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000206")]
			[Cpp2IlInjected.Address(RVA = "0x1FC39A0", Offset = "0x1FC29A0", VA = "0x181FC39A0")]
			internal bool ONOGIJNFPBM()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000207")]
			[Cpp2IlInjected.Address(RVA = "0x1FC1C40", Offset = "0x1FC0C40", VA = "0x181FC1C40")]
			internal object ILELMLDGICM()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000208")]
			[Cpp2IlInjected.Address(RVA = "0x1FC2A50", Offset = "0x1FC1A50", VA = "0x181FC2A50")]
			internal void LGJMBNOKCDM(object x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000209")]
			[Cpp2IlInjected.Address(RVA = "0x1FC1BF0", Offset = "0x1FC0BF0", VA = "0x181FC1BF0")]
			internal bool IKIDCOHELKE()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600020A")]
			[Cpp2IlInjected.Address(RVA = "0x1FC1E10", Offset = "0x1FC0E10", VA = "0x181FC1E10")]
			internal int IMMIGDMEJFE()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x600020B")]
			[Cpp2IlInjected.Address(RVA = "0x1FC1B90", Offset = "0x1FC0B90", VA = "0x181FC1B90")]
			internal void IJJCOKHIGDD(int x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600020C")]
			[Cpp2IlInjected.Address(RVA = "0x1FC2290", Offset = "0x1FC1290", VA = "0x181FC2290")]
			internal bool JNPCBMMPLLF()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600020D")]
			[Cpp2IlInjected.Address(RVA = "0x1FC32B0", Offset = "0x1FC22B0", VA = "0x181FC32B0")]
			internal bool NIMJFGINBCI()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600020E")]
			[Cpp2IlInjected.Address(RVA = "0x1FB97C0", Offset = "0x1FB87C0", VA = "0x181FB97C0")]
			internal bool BDCFKMCPHDP()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600020F")]
			[Cpp2IlInjected.Address(RVA = "0x1FC34F0", Offset = "0x1FC24F0", VA = "0x181FC34F0")]
			internal int NOAJNLNAIHP()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000210")]
			[Cpp2IlInjected.Address(RVA = "0x1FC38D0", Offset = "0x1FC28D0", VA = "0x181FC38D0")]
			internal void OMCDHPKJIND(int x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000211")]
			[Cpp2IlInjected.Address(RVA = "0x1FB9580", Offset = "0x1FB8580", VA = "0x181FB9580")]
			internal bool AMCLPENEDAA()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000212")]
			[Cpp2IlInjected.Address(RVA = "0x1FB9720", Offset = "0x1FB8720", VA = "0x181FB9720")]
			internal bool BBHFOBDAEAC()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000213")]
			[Cpp2IlInjected.Address(RVA = "0x1FC3C70", Offset = "0x1FC2C70", VA = "0x181FC3C70")]
			internal bool PCNIFEMKJMO()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000214")]
			[Cpp2IlInjected.Address(RVA = "0x1FC0F20", Offset = "0x1FBFF20", VA = "0x181FC0F20")]
			internal float GBHINPPAOLC()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000215")]
			[Cpp2IlInjected.Address(RVA = "0x1FC1890", Offset = "0x1FC0890", VA = "0x181FC1890")]
			internal void HNMDFFCMBOK(float x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000216")]
			[Cpp2IlInjected.Address(RVA = "0x1FB9140", Offset = "0x1FB8140", VA = "0x181FB9140")]
			internal bool ACBCGCFEBPO()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000217")]
			[Cpp2IlInjected.Address(RVA = "0x1FC2D30", Offset = "0x1FC1D30", VA = "0x181FC2D30")]
			internal bool MBEDCCMIBGD()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000218")]
			[Cpp2IlInjected.Address(RVA = "0x1FC0B60", Offset = "0x1FBFB60", VA = "0x181FC0B60")]
			internal bool FAJMMJFPLIN()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000219")]
			[Cpp2IlInjected.Address(RVA = "0x1FC3830", Offset = "0x1FC2830", VA = "0x181FC3830")]
			internal float OINEALOLAGF()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x600021A")]
			[Cpp2IlInjected.Address(RVA = "0x1FC3440", Offset = "0x1FC2440", VA = "0x181FC3440")]
			internal void NLOOFDDGMBF(float x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600021B")]
			[Cpp2IlInjected.Address(RVA = "0x1FC1640", Offset = "0x1FC0640", VA = "0x181FC1640")]
			internal bool HHFNEJNGPPL()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600021C")]
			[Cpp2IlInjected.Address(RVA = "0x1FBA320", Offset = "0x1FB9320", VA = "0x181FBA320")]
			internal bool DABGDILMCMM()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600021D")]
			[Cpp2IlInjected.Address(RVA = "0x1FC2860", Offset = "0x1FC1860", VA = "0x181FC2860")]
			internal string LACGBBKKKPA()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600021E")]
			[Cpp2IlInjected.Address(RVA = "0x1FC1440", Offset = "0x1FC0440", VA = "0x181FC1440")]
			internal void HBCAMCHIKDE(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600021F")]
			[Cpp2IlInjected.Address(RVA = "0x1FC3350", Offset = "0x1FC2350", VA = "0x181FC3350")]
			internal bool NJNCJMPAAJI(string x)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000220")]
			[Cpp2IlInjected.Address(RVA = "0x1FBA460", Offset = "0x1FB9460", VA = "0x181FBA460")]
			internal bool DGBKCNPBDND()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000221")]
			[Cpp2IlInjected.Address(RVA = "0x1FC2E20", Offset = "0x1FC1E20", VA = "0x181FC2E20")]
			internal bool MEJJJFHFBPK()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000222")]
			[Cpp2IlInjected.Address(RVA = "0x1FC3640", Offset = "0x1FC2640", VA = "0x181FC3640")]
			internal bool ODLBMKAJGLI()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000223")]
			[Cpp2IlInjected.Address(RVA = "0x1FC3160", Offset = "0x1FC2160", VA = "0x181FC3160")]
			internal string NCLJACMMIAG()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000224")]
			[Cpp2IlInjected.Address(RVA = "0x1FC1B20", Offset = "0x1FC0B20", VA = "0x181FC1B20")]
			internal void IIPDBMDCFHM(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000225")]
			[Cpp2IlInjected.Address(RVA = "0x1FB9E40", Offset = "0x1FB8E40", VA = "0x181FB9E40")]
			internal bool BPELNKIEJEM(string x)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000226")]
			[Cpp2IlInjected.Address(RVA = "0x1FC3A90", Offset = "0x1FC2A90", VA = "0x181FC3A90")]
			internal bool OPIDJHOGMFK()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000227")]
			[Cpp2IlInjected.Address(RVA = "0x1FC2240", Offset = "0x1FC1240", VA = "0x181FC2240")]
			internal bool JLAMMPDMBPL()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000228")]
			[Cpp2IlInjected.Address(RVA = "0x1FC3A40", Offset = "0x1FC2A40", VA = "0x181FC3A40")]
			internal bool OOCPDGHGGHJ()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000229")]
			[Cpp2IlInjected.Address(RVA = "0x1FC1D60", Offset = "0x1FC0D60", VA = "0x181FC1D60")]
			internal string IMAOCKCFJAB()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600022A")]
			[Cpp2IlInjected.Address(RVA = "0x1FC0CC0", Offset = "0x1FBFCC0", VA = "0x181FC0CC0")]
			internal void FHMJGLGFMCA(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600022B")]
			[Cpp2IlInjected.Address(RVA = "0x1FBA0B0", Offset = "0x1FB90B0", VA = "0x181FBA0B0")]
			internal bool CJCLMJOILBG(string x)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600022C")]
			[Cpp2IlInjected.Address(RVA = "0x1FC2B30", Offset = "0x1FC1B30", VA = "0x181FC2B30")]
			internal bool LMAPMKIBLDA()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600022D")]
			[Cpp2IlInjected.Address(RVA = "0x1FB90F0", Offset = "0x1FB80F0", VA = "0x181FB90F0")]
			internal bool AAKKANJPDPA()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600022E")]
			[Cpp2IlInjected.Address(RVA = "0x1FC1F00", Offset = "0x1FC0F00", VA = "0x181FC1F00")]
			internal bool IPEGJIICIIL()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600022F")]
			[Cpp2IlInjected.Address(RVA = "0x1FB90A0", Offset = "0x1FB80A0", VA = "0x181FB90A0")]
			internal string AAFFOGPAEKO()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000230")]
			[Cpp2IlInjected.Address(RVA = "0x1FC1780", Offset = "0x1FC0780", VA = "0x181FC1780")]
			internal void HLKFAGFHGOI(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000231")]
			[Cpp2IlInjected.Address(RVA = "0x1FB9E90", Offset = "0x1FB8E90", VA = "0x181FB9E90")]
			internal bool CAMAIIENACF(string x)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000232")]
			[Cpp2IlInjected.Address(RVA = "0x1FB9490", Offset = "0x1FB8490", VA = "0x181FB9490")]
			internal bool AKJCFADCKFA()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000233")]
			[Cpp2IlInjected.Address(RVA = "0x1FB9950", Offset = "0x1FB8950", VA = "0x181FB9950")]
			internal bool BLJFANDAOKK()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000234")]
			[Cpp2IlInjected.Address(RVA = "0x1FC2E70", Offset = "0x1FC1E70", VA = "0x181FC2E70")]
			internal bool MEKMAMHBFCI()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000235")]
			[Cpp2IlInjected.Address(RVA = "0x1FC2530", Offset = "0x1FC1530", VA = "0x181FC2530")]
			internal string KGCAIJFCKFG()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000236")]
			[Cpp2IlInjected.Address(RVA = "0x1FB93D0", Offset = "0x1FB83D0", VA = "0x181FB93D0")]
			internal void AINMJEEMGCB(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000237")]
			[Cpp2IlInjected.Address(RVA = "0x1FC1990", Offset = "0x1FC0990", VA = "0x181FC1990")]
			internal bool IDJLNLOCLJL(string x)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000238")]
			[Cpp2IlInjected.Address(RVA = "0x1FBA5F0", Offset = "0x1FB95F0", VA = "0x181FBA5F0")]
			internal bool DMNGBCEHKHL()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000239")]
			[Cpp2IlInjected.Address(RVA = "0x1FC3690", Offset = "0x1FC2690", VA = "0x181FC3690")]
			internal bool OEIHMCKIKGC()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600023A")]
			[Cpp2IlInjected.Address(RVA = "0x1FC2960", Offset = "0x1FC1960", VA = "0x181FC2960")]
			internal bool LGAKMCAKDBB()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600023B")]
			[Cpp2IlInjected.Address(RVA = "0x1FC29B0", Offset = "0x1FC19B0", VA = "0x181FC29B0")]
			internal string LGDNHJKDPNK()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600023C")]
			[Cpp2IlInjected.Address(RVA = "0x1FC2460", Offset = "0x1FC1460", VA = "0x181FC2460")]
			internal void KFNENKOIGNM(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600023D")]
			[Cpp2IlInjected.Address(RVA = "0x1FC0BB0", Offset = "0x1FBFBB0", VA = "0x181FC0BB0")]
			internal bool FBAIJGMNAHC(string x)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600023E")]
			[Cpp2IlInjected.Address(RVA = "0x1FB98B0", Offset = "0x1FB88B0", VA = "0x181FB98B0")]
			internal bool BKDKDCELCHK()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600023F")]
			[Cpp2IlInjected.Address(RVA = "0x1FB9F50", Offset = "0x1FB8F50", VA = "0x181FB9F50")]
			internal bool CENKGKKLNII()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000240")]
			[Cpp2IlInjected.Address(RVA = "0x1FB9680", Offset = "0x1FB8680", VA = "0x181FB9680")]
			internal bool AONNPLDPKMO()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000241")]
			[Cpp2IlInjected.Address(RVA = "0x1FBA370", Offset = "0x1FB9370", VA = "0x181FBA370")]
			internal string DAPFIILKMPG()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000242")]
			[Cpp2IlInjected.Address(RVA = "0x1FC3930", Offset = "0x1FC2930", VA = "0x181FC3930")]
			internal void ONJLPIKHIDH(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000243")]
			[Cpp2IlInjected.Address(RVA = "0x1FB9330", Offset = "0x1FB8330", VA = "0x181FB9330")]
			internal bool AGFIBBMJPEO(string x)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000244")]
			[Cpp2IlInjected.Address(RVA = "0x1FBA780", Offset = "0x1FB9780", VA = "0x181FBA780")]
			internal bool ECMDEPBOGBJ()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000245")]
			[Cpp2IlInjected.Address(RVA = "0x1FC2000", Offset = "0x1FC1000", VA = "0x181FC2000")]
			internal bool JENJPFDEPGF()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000246")]
			[Cpp2IlInjected.Address(RVA = "0x1FC13F0", Offset = "0x1FC03F0", VA = "0x181FC13F0")]
			internal bool GPBDOJFHHKA()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000247")]
			[Cpp2IlInjected.Address(RVA = "0x1FB9530", Offset = "0x1FB8530", VA = "0x181FB9530")]
			internal string AMCFLODMPEE()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000248")]
			[Cpp2IlInjected.Address(RVA = "0x1FC26C0", Offset = "0x1FC16C0", VA = "0x181FC26C0")]
			internal void KNOMAHPINIC(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000249")]
			[Cpp2IlInjected.Address(RVA = "0x1FBA6E0", Offset = "0x1FB96E0", VA = "0x181FBA6E0")]
			internal bool DPMFBCEOGFC(string x)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600024A")]
			[Cpp2IlInjected.Address(RVA = "0x1FB95D0", Offset = "0x1FB85D0", VA = "0x181FB95D0")]
			internal bool ANDGPGEFPAH()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600024B")]
			[Cpp2IlInjected.Address(RVA = "0x1FC12E0", Offset = "0x1FC02E0", VA = "0x181FC12E0")]
			internal bool GGJKMBMLKHG()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600024C")]
			[Cpp2IlInjected.Address(RVA = "0x1FC33A0", Offset = "0x1FC23A0", VA = "0x181FC33A0")]
			internal bool NKKLPMIJOBN()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600024D")]
			[Cpp2IlInjected.Address(RVA = "0x1FC25D0", Offset = "0x1FC15D0", VA = "0x181FC25D0")]
			internal string KJNDLLOOCFJ()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600024E")]
			[Cpp2IlInjected.Address(RVA = "0x1FC1380", Offset = "0x1FC0380", VA = "0x181FC1380")]
			internal void GNMOPHJMOPI(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600024F")]
			[Cpp2IlInjected.Address(RVA = "0x1FC3300", Offset = "0x1FC2300", VA = "0x181FC3300")]
			internal bool NJMBEGPLJLI(string x)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000250")]
			[Cpp2IlInjected.Address(RVA = "0x1FC3210", Offset = "0x1FC2210", VA = "0x181FC3210")]
			internal bool NHPADADCMJH()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000251")]
			[Cpp2IlInjected.Address(RVA = "0x1FC1500", Offset = "0x1FC0500", VA = "0x181FC1500")]
			internal bool HBPHCONGFED()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000252")]
			[Cpp2IlInjected.Address(RVA = "0x1FC2C30", Offset = "0x1FC1C30", VA = "0x181FC2C30")]
			internal bool LPADGOOGNBG()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000253")]
			[Cpp2IlInjected.Address(RVA = "0x1FB96D0", Offset = "0x1FB86D0", VA = "0x181FB96D0")]
			internal string APGEHOCAGGO()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000254")]
			[Cpp2IlInjected.Address(RVA = "0x1FC2F10", Offset = "0x1FC1F10", VA = "0x181FC2F10")]
			internal void MIFFCACHBMB(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000255")]
			[Cpp2IlInjected.Address(RVA = "0x1FC2FD0", Offset = "0x1FC1FD0", VA = "0x181FC2FD0")]
			internal bool MPAIHAHCHDO()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000256")]
			[Cpp2IlInjected.Address(RVA = "0x1FBA4B0", Offset = "0x1FB94B0", VA = "0x181FBA4B0")]
			internal bool DGHCPLPBCAP()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000257")]
			[Cpp2IlInjected.Address(RVA = "0x1FBA500", Offset = "0x1FB9500", VA = "0x181FBA500")]
			internal bool DGILMMHLBBG()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000258")]
			[Cpp2IlInjected.Address(RVA = "0x1FB94E0", Offset = "0x1FB84E0", VA = "0x181FB94E0")]
			internal string AMCCJAJPBLP()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000259")]
			[Cpp2IlInjected.Address(RVA = "0x1FC0C50", Offset = "0x1FBFC50", VA = "0x181FC0C50")]
			internal void FDAAJGAJEKP(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600025A")]
			[Cpp2IlInjected.Address(RVA = "0x1FC34A0", Offset = "0x1FC24A0", VA = "0x181FC34A0")]
			internal bool NNIHGEDKPLI()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600025B")]
			[Cpp2IlInjected.Address(RVA = "0x1FB9810", Offset = "0x1FB8810", VA = "0x181FB9810")]
			internal bool BDEOPJKIJIE()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600025C")]
			[Cpp2IlInjected.Address(RVA = "0x1FC2670", Offset = "0x1FC1670", VA = "0x181FC2670")]
			internal bool KNABOPJNEIJ()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600025D")]
			[Cpp2IlInjected.Address(RVA = "0x1FBA920", Offset = "0x1FB9920", VA = "0x181FBA920")]
			internal string EJJNNOPIMGP()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600025E")]
			[Cpp2IlInjected.Address(RVA = "0x1FB9EE0", Offset = "0x1FB8EE0", VA = "0x181FB9EE0")]
			internal void CDNCJGCEONE(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600025F")]
			[Cpp2IlInjected.Address(RVA = "0x1FC2D80", Offset = "0x1FC1D80", VA = "0x181FC2D80")]
			internal bool MEDDBKIMLCH()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000260")]
			[Cpp2IlInjected.Address(RVA = "0x1FC3070", Offset = "0x1FC2070", VA = "0x181FC3070")]
			internal bool NBDGGGHILBI()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000261")]
			[Cpp2IlInjected.Address(RVA = "0x1FBA8D0", Offset = "0x1FB98D0", VA = "0x181FBA8D0")]
			internal bool EGOMPIFGJEI()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000262")]
			[Cpp2IlInjected.Address(RVA = "0x1FC2DD0", Offset = "0x1FC1DD0", VA = "0x181FC2DD0")]
			internal string MEHMJPGIJGP()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000263")]
			[Cpp2IlInjected.Address(RVA = "0x1FBA2B0", Offset = "0x1FB92B0", VA = "0x181FBA2B0")]
			internal void CPODNFGANOP(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000264")]
			[Cpp2IlInjected.Address(RVA = "0x1FC15F0", Offset = "0x1FC05F0", VA = "0x181FC15F0")]
			internal bool HFKFBJNOAAC()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000265")]
			[Cpp2IlInjected.Address(RVA = "0x1FC3780", Offset = "0x1FC2780", VA = "0x181FC3780")]
			internal bool OHFOMACKLJN(string x)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000266")]
			[Cpp2IlInjected.Address(RVA = "0x1FC1FB0", Offset = "0x1FC0FB0", VA = "0x181FC1FB0")]
			internal float JDKAKBOHAKH()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000267")]
			[Cpp2IlInjected.Address(RVA = "0x1FC0D80", Offset = "0x1FBFD80", VA = "0x181FC0D80")]
			internal void FNHDEIGMANA(float x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000268")]
			[Cpp2IlInjected.Address(RVA = "0x1FC3AE0", Offset = "0x1FC2AE0", VA = "0x181FC3AE0")]
			internal bool OPIHFELACBL()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000269")]
			[Cpp2IlInjected.Address(RVA = "0x1FC3540", Offset = "0x1FC2540", VA = "0x181FC3540")]
			internal bool NPLMOKNHKCF()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600026A")]
			[Cpp2IlInjected.Address(RVA = "0x1FBA730", Offset = "0x1FB9730", VA = "0x181FBA730")]
			internal bool ECJOKDDAIIF()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600026B")]
			[Cpp2IlInjected.Address(RVA = "0x1FBA970", Offset = "0x1FB9970", VA = "0x181FBA970")]
			internal int EKKPAACJBKF()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x600026C")]
			[Cpp2IlInjected.Address(RVA = "0x1FB9620", Offset = "0x1FB8620", VA = "0x181FB9620")]
			internal void AOAMLNFIDKJ(int x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600026D")]
			[Cpp2IlInjected.Address(RVA = "0x1FC18F0", Offset = "0x1FC08F0", VA = "0x181FC18F0")]
			internal bool IBAMDCOFFLJ()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600026E")]
			[Cpp2IlInjected.Address(RVA = "0x1FBA880", Offset = "0x1FB9880", VA = "0x181FBA880")]
			internal bool EFOIDJDIJHG()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600026F")]
			[Cpp2IlInjected.Address(RVA = "0x1FC20A0", Offset = "0x1FC10A0", VA = "0x181FC20A0")]
			internal bool JGLIHIPFPJP()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000065")]
		[CompilerGenerated]
		private sealed class NFGLGMICMKH
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000148")]
			public string secondaryLabel;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000149")]
			public FPIPDIPEMPM CS$<>8__locals1;

			[Cpp2IlInjected.Token(Token = "0x6000270")]
			[Cpp2IlInjected.Address(RVA = "0x85EB60", Offset = "0x85DB60", VA = "0x18085EB60")]
			public NFGLGMICMKH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000271")]
			[Cpp2IlInjected.Address(RVA = "0x1FCD810", Offset = "0x1FCC810", VA = "0x181FCD810")]
			internal void MALKNAALDON()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000066")]
		[CompilerGenerated]
		private sealed class DMCAPHONMFB
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400014A")]
			public char[] swizzleChars;

			[Cpp2IlInjected.Token(Token = "0x6000272")]
			[Cpp2IlInjected.Address(RVA = "0x85EB60", Offset = "0x85DB60", VA = "0x18085EB60")]
			public DMCAPHONMFB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000273")]
			[Cpp2IlInjected.Address(RVA = "0x1FB6030", Offset = "0x1FB5030", VA = "0x181FB6030")]
			internal bool DFBALBDFKAN(char c)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000137")]
		private readonly AFINNOIBIAO BBBKFKJIMNI;

		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x1FB8B80", Offset = "0x1FB7B80", VA = "0x181FB8B80")]
		public FKEFFFKIKAD(DLILHLIBGCM OPKEKBBFIHG, EDHMOEKBIJG OHDOOCGHDGN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x1FB6DB0", Offset = "0x1FB5DB0", VA = "0x181FB6DB0", Slot = "120")]
		protected override void GHIPLIDCNEB(OHIGDFFLHJA NMEBKEGDNCC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000068")]
	public sealed class MOKJOAKHJOC : CNGEGLEMEMP<MIEBDMFLIDC>
	{
		[Cpp2IlInjected.Token(Token = "0x2000069")]
		[CompilerGenerated]
		private sealed class EMMMBKJGDMF
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
				public EMMMBKJGDMF <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x4000178")]
				public string value;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x4000179")]
				private TaskAwaiter<bool> <>u__1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
				[Cpp2IlInjected.Token(Token = "0x400017A")]
				private TaskAwaiter<DFAHBLOKBPH<OKOMLKNINNF, CKBHMJGLAPL>> <>u__2;

				[Cpp2IlInjected.Token(Token = "0x60002A5")]
				[Cpp2IlInjected.Address(RVA = "0x1FECBA0", Offset = "0x1FEBBA0", VA = "0x181FECBA0", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60002A6")]
				[Cpp2IlInjected.Address(RVA = "0xA6A710", Offset = "0xA69710", VA = "0x180A6A710", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000173")]
			public MOKJOAKHJOC <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000174")]
			public PCILEDIMGBH nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x60002A0")]
			[Cpp2IlInjected.Address(RVA = "0x85EB60", Offset = "0x85DB60", VA = "0x18085EB60")]
			public EMMMBKJGDMF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002A1")]
			[Cpp2IlInjected.Address(RVA = "0x1FDB4F0", Offset = "0x1FDA4F0", VA = "0x181FDB4F0")]
			internal string NCGMJMFHGEA()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002A2")]
			[Cpp2IlInjected.Address(RVA = "0x1FDB540", Offset = "0x1FDA540", VA = "0x181FDB540")]
			[AsyncStateMachine(typeof(<<BuildConfigMenuInternal>b__1>d))]
			internal void OIANKMMHODC(string value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002A3")]
			[Cpp2IlInjected.Address(RVA = "0x1FDB4A0", Offset = "0x1FDA4A0", VA = "0x181FDB4A0")]
			internal int GNDADNGFDLE()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60002A4")]
			[Cpp2IlInjected.Address(RVA = "0x1FDB410", Offset = "0x1FDA410", VA = "0x181FDB410")]
			internal void ADBLKAGNGFP(int value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public override NodeVisualizationKey NAKCNJCFEHA
		{
			[Cpp2IlInjected.Token(Token = "0x600029E")]
			[Cpp2IlInjected.Address(RVA = "0x996090", Offset = "0x995090", VA = "0x180996090", Slot = "91")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600029D")]
		[Cpp2IlInjected.Address(RVA = "0x1FE5040", Offset = "0x1FE4040", VA = "0x181FE5040")]
		public MOKJOAKHJOC(DLILHLIBGCM OPKEKBBFIHG, MIEBDMFLIDC OEFGKJLECGH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029F")]
		[Cpp2IlInjected.Address(RVA = "0x1FE4CF0", Offset = "0x1FE3CF0", VA = "0x181FE4CF0", Slot = "120")]
		protected override void GHIPLIDCNEB(OHIGDFFLHJA NMEBKEGDNCC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006B")]
	public sealed class FLLAFEBDEHI : CNGEGLEMEMP<LJCKOLLMGON>
	{
		[Cpp2IlInjected.Token(Token = "0x200006C")]
		[CompilerGenerated]
		private sealed class KGHGCGNLBFP
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
				public KGHGCGNLBFP <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x4000180")]
				public string value;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x4000181")]
				private TaskAwaiter<bool> <>u__1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
				[Cpp2IlInjected.Token(Token = "0x4000182")]
				private TaskAwaiter<DFAHBLOKBPH<OKOMLKNINNF, CKBHMJGLAPL>> <>u__2;

				[Cpp2IlInjected.Token(Token = "0x60002BA")]
				[Cpp2IlInjected.Address(RVA = "0x1FECEB0", Offset = "0x1FEBEB0", VA = "0x181FECEB0", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60002BB")]
				[Cpp2IlInjected.Address(RVA = "0xA6A710", Offset = "0xA69710", VA = "0x180A6A710", Slot = "5")]
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
				public KGHGCGNLBFP <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x4000186")]
				public string value;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x4000187")]
				private TaskAwaiter<bool> <>u__1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
				[Cpp2IlInjected.Token(Token = "0x4000188")]
				private TaskAwaiter<DFAHBLOKBPH<OKOMLKNINNF, CKBHMJGLAPL>> <>u__2;

				[Cpp2IlInjected.Token(Token = "0x60002BC")]
				[Cpp2IlInjected.Address(RVA = "0x1FED1F0", Offset = "0x1FEC1F0", VA = "0x181FED1F0", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60002BD")]
				[Cpp2IlInjected.Address(RVA = "0xA6A710", Offset = "0xA69710", VA = "0x180A6A710", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400017B")]
			public FLLAFEBDEHI <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400017C")]
			public PCILEDIMGBH nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x60002AA")]
			[Cpp2IlInjected.Address(RVA = "0x85EB60", Offset = "0x85DB60", VA = "0x18085EB60")]
			public KGHGCGNLBFP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002AB")]
			[Cpp2IlInjected.Address(RVA = "0x1FE21D0", Offset = "0x1FE11D0", VA = "0x181FE21D0")]
			internal string NCGMJMFHGEA()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002AC")]
			[Cpp2IlInjected.Address(RVA = "0x1FE22B0", Offset = "0x1FE12B0", VA = "0x181FE22B0")]
			[AsyncStateMachine(typeof(<<BuildConfigMenuInternal>b__1>d))]
			internal void OIANKMMHODC(string value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002AD")]
			[Cpp2IlInjected.Address(RVA = "0x1FE1FD0", Offset = "0x1FE0FD0", VA = "0x181FE1FD0")]
			internal int GNDADNGFDLE()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60002AE")]
			[Cpp2IlInjected.Address(RVA = "0x1FE1D30", Offset = "0x1FE0D30", VA = "0x181FE1D30")]
			internal void ADBLKAGNGFP(int colorIndex)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002AF")]
			[Cpp2IlInjected.Address(RVA = "0x1FE1F20", Offset = "0x1FE0F20", VA = "0x181FE1F20")]
			internal string DMNAKLFEOCK()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002B0")]
			[Cpp2IlInjected.Address(RVA = "0x1FE2100", Offset = "0x1FE1100", VA = "0x181FE2100")]
			[AsyncStateMachine(typeof(<<BuildConfigMenuInternal>b__5>d))]
			internal void LFNPCGFBCGF(string value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002B1")]
			[Cpp2IlInjected.Address(RVA = "0x1FE1E60", Offset = "0x1FE0E60", VA = "0x181FE1E60")]
			internal bool CNOGCEECIJC()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60002B2")]
			[Cpp2IlInjected.Address(RVA = "0x1FE2220", Offset = "0x1FE1220", VA = "0x181FE2220")]
			internal void OALPLEHLNDH(bool value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002B3")]
			[Cpp2IlInjected.Address(RVA = "0x1FE2020", Offset = "0x1FE1020", VA = "0x181FE2020")]
			internal bool HAJPJDODEHN()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60002B4")]
			[Cpp2IlInjected.Address(RVA = "0x1FE2070", Offset = "0x1FE1070", VA = "0x181FE2070")]
			internal void HJJPONJCFNA(bool value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002B5")]
			[Cpp2IlInjected.Address(RVA = "0x1FE2380", Offset = "0x1FE1380", VA = "0x181FE2380")]
			internal float PDJOAMHIGED()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x60002B6")]
			[Cpp2IlInjected.Address(RVA = "0x1FE1CA0", Offset = "0x1FE0CA0", VA = "0x181FE1CA0")]
			internal void ACJOGNOGIIG(float value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002B7")]
			[Cpp2IlInjected.Address(RVA = "0x1FE1F70", Offset = "0x1FE0F70", VA = "0x181FE1F70")]
			internal int GDMOGBNJLMO()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60002B8")]
			[Cpp2IlInjected.Address(RVA = "0x1FE1DC0", Offset = "0x1FE0DC0", VA = "0x181FE1DC0")]
			internal void BJCEBCMMADO(int value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002B9")]
			[Cpp2IlInjected.Address(RVA = "0x1FE1EB0", Offset = "0x1FE0EB0", VA = "0x181FE1EB0")]
			internal bool DEJALFELGHA()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		public override NodeVisualizationKey NAKCNJCFEHA
		{
			[Cpp2IlInjected.Token(Token = "0x60002A8")]
			[Cpp2IlInjected.Address(RVA = "0x996090", Offset = "0x995090", VA = "0x180996090", Slot = "91")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002A7")]
		[Cpp2IlInjected.Address(RVA = "0x1FDCEC0", Offset = "0x1FDBEC0", VA = "0x181FDCEC0")]
		public FLLAFEBDEHI(DLILHLIBGCM OPKEKBBFIHG, LJCKOLLMGON OHDOOCGHDGN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A9")]
		[Cpp2IlInjected.Address(RVA = "0x1FDC480", Offset = "0x1FDB480", VA = "0x181FDC480", Slot = "120")]
		protected override void GHIPLIDCNEB(OHIGDFFLHJA NMEBKEGDNCC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006F")]
	public sealed class FACHJELHGCF : CNGEGLEMEMP<HKKDDOFJNKJ>
	{
		[Cpp2IlInjected.Token(Token = "0x2000070")]
		[CompilerGenerated]
		private sealed class ENPLIFCLIKN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000189")]
			public PCILEDIMGBH nodeAdapterDeps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400018A")]
			public FACHJELHGCF <>4__this;

			[Cpp2IlInjected.Token(Token = "0x60002C1")]
			[Cpp2IlInjected.Address(RVA = "0x85EB60", Offset = "0x85DB60", VA = "0x18085EB60")]
			public ENPLIFCLIKN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002C2")]
			[Cpp2IlInjected.Address(RVA = "0x1FDB890", Offset = "0x1FDA890", VA = "0x181FDB890")]
			internal Dictionary<string, KDGMAMLGGIL> NCGMJMFHGEA()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002C3")]
			[Cpp2IlInjected.Address(RVA = "0x1FDB930", Offset = "0x1FDA930", VA = "0x181FDB930")]
			internal int OIANKMMHODC()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60002C4")]
			[Cpp2IlInjected.Address(RVA = "0x1FDB770", Offset = "0x1FDA770", VA = "0x181FDB770")]
			internal void GNDADNGFDLE(int value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002C5")]
			[Cpp2IlInjected.Address(RVA = "0x1FDB6F0", Offset = "0x1FDA6F0", VA = "0x181FDB6F0")]
			internal bool ADBLKAGNGFP()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public override NodeVisualizationKey NAKCNJCFEHA
		{
			[Cpp2IlInjected.Token(Token = "0x60002BF")]
			[Cpp2IlInjected.Address(RVA = "0x996090", Offset = "0x995090", VA = "0x180996090", Slot = "91")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002BE")]
		[Cpp2IlInjected.Address(RVA = "0x1FDBC50", Offset = "0x1FDAC50", VA = "0x181FDBC50")]
		public FACHJELHGCF(DLILHLIBGCM OPKEKBBFIHG, HKKDDOFJNKJ OEFGKJLECGH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C0")]
		[Cpp2IlInjected.Address(RVA = "0x1FDB980", Offset = "0x1FDA980", VA = "0x181FDB980", Slot = "120")]
		protected override void GHIPLIDCNEB(OHIGDFFLHJA NMEBKEGDNCC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000071")]
	public sealed class MAEHADNFDON : CNGEGLEMEMP<OABAHNBPKFH>
	{
		[Cpp2IlInjected.Token(Token = "0x2000072")]
		[CompilerGenerated]
		private sealed class LADDIBIHAOC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400018B")]
			public PCILEDIMGBH nodeAdapterDeps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400018C")]
			public MAEHADNFDON <>4__this;

			[Cpp2IlInjected.Token(Token = "0x60002C9")]
			[Cpp2IlInjected.Address(RVA = "0x85EB60", Offset = "0x85DB60", VA = "0x18085EB60")]
			public LADDIBIHAOC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002CA")]
			[Cpp2IlInjected.Address(RVA = "0x1FE2BD0", Offset = "0x1FE1BD0", VA = "0x181FE2BD0")]
			internal void NCGMJMFHGEA()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		public override NodeVisualizationKey NAKCNJCFEHA
		{
			[Cpp2IlInjected.Token(Token = "0x60002C7")]
			[Cpp2IlInjected.Address(RVA = "0x996090", Offset = "0x995090", VA = "0x180996090", Slot = "91")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002C6")]
		[Cpp2IlInjected.Address(RVA = "0x1FE44B0", Offset = "0x1FE34B0", VA = "0x181FE44B0")]
		public MAEHADNFDON(DLILHLIBGCM OPKEKBBFIHG, OABAHNBPKFH OEFGKJLECGH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C8")]
		[Cpp2IlInjected.Address(RVA = "0x1FE4330", Offset = "0x1FE3330", VA = "0x181FE4330", Slot = "120")]
		protected override void GHIPLIDCNEB(OHIGDFFLHJA NMEBKEGDNCC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000073")]
	private sealed class BPDPPBICEMA : AMPJOCEGNLH<FAJIJCACJOI>
	{
		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public override bool HPNAOALGLGH
		{
			[Cpp2IlInjected.Token(Token = "0x60002CB")]
			[Cpp2IlInjected.Address(RVA = "0x86C5D0", Offset = "0x86B5D0", VA = "0x18086C5D0", Slot = "93")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		public override bool GJJDOEEDBBO
		{
			[Cpp2IlInjected.Token(Token = "0x60002CC")]
			[Cpp2IlInjected.Address(RVA = "0x1FD9B20", Offset = "0x1FD8B20", VA = "0x181FD9B20", Slot = "117")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public override NodeVisualizationKey NAKCNJCFEHA
		{
			[Cpp2IlInjected.Token(Token = "0x60002CD")]
			[Cpp2IlInjected.Address(RVA = "0x9A8AD0", Offset = "0x9A7AD0", VA = "0x1809A8AD0", Slot = "91")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002CE")]
		[Cpp2IlInjected.Address(RVA = "0x1FD9AC0", Offset = "0x1FD8AC0", VA = "0x181FD9AC0")]
		public BPDPPBICEMA(DLILHLIBGCM OPKEKBBFIHG, FAJIJCACJOI OHDOOCGHDGN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CF")]
		[Cpp2IlInjected.Address(RVA = "0x853950", Offset = "0x852950", VA = "0x180853950", Slot = "120")]
		protected override void GHIPLIDCNEB(OHIGDFFLHJA NMEBKEGDNCC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000074")]
	private sealed class LNKGMHAPDCK : CNGEGLEMEMP<KHCNCGMNNJE>
	{
		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		public override NodeVisualizationKey NAKCNJCFEHA
		{
			[Cpp2IlInjected.Token(Token = "0x60002D0")]
			[Cpp2IlInjected.Address(RVA = "0x95F740", Offset = "0x95E740", VA = "0x18095F740", Slot = "91")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002D1")]
		[Cpp2IlInjected.Address(RVA = "0x1FE42C0", Offset = "0x1FE32C0", VA = "0x181FE42C0")]
		public LNKGMHAPDCK(DLILHLIBGCM OPKEKBBFIHG, KHCNCGMNNJE OHDOOCGHDGN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D2")]
		[Cpp2IlInjected.Address(RVA = "0x853950", Offset = "0x852950", VA = "0x180853950", Slot = "120")]
		protected override void GHIPLIDCNEB(OHIGDFFLHJA NMEBKEGDNCC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000075")]
	private sealed class DGIGFPPGEFK : CNGEGLEMEMP<NFAHHPPDOFJ>
	{
		[Cpp2IlInjected.Token(Token = "0x17000040")]
		public override NodeVisualizationKey NAKCNJCFEHA
		{
			[Cpp2IlInjected.Token(Token = "0x60002D3")]
			[Cpp2IlInjected.Address(RVA = "0x9AF190", Offset = "0x9AE190", VA = "0x1809AF190", Slot = "91")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002D4")]
		[Cpp2IlInjected.Address(RVA = "0x1FDACE0", Offset = "0x1FD9CE0", VA = "0x181FDACE0")]
		public DGIGFPPGEFK(DLILHLIBGCM OPKEKBBFIHG, NFAHHPPDOFJ OHDOOCGHDGN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D5")]
		[Cpp2IlInjected.Address(RVA = "0x86C5D0", Offset = "0x86B5D0", VA = "0x18086C5D0", Slot = "112")]
		protected override bool LBIDOPNBACI(BGKDPCAKPBJ<IHOAGKINOHG> FCFGPBAFAPA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D6")]
		[Cpp2IlInjected.Address(RVA = "0x853950", Offset = "0x852950", VA = "0x180853950", Slot = "120")]
		protected override void GHIPLIDCNEB(OHIGDFFLHJA NMEBKEGDNCC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000076")]
	private sealed class OBOPLBIPBMM : CNGEGLEMEMP<NAAPMGBBPOD>
	{
		[Cpp2IlInjected.Token(Token = "0x17000041")]
		public override NodeVisualizationKey NAKCNJCFEHA
		{
			[Cpp2IlInjected.Token(Token = "0x60002D7")]
			[Cpp2IlInjected.Address(RVA = "0x9AA090", Offset = "0x9A9090", VA = "0x1809AA090", Slot = "91")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		public override bool AJINHILPFLH
		{
			[Cpp2IlInjected.Token(Token = "0x60002D8")]
			[Cpp2IlInjected.Address(RVA = "0x1FE6680", Offset = "0x1FE5680", VA = "0x181FE6680", Slot = "92")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000043")]
		protected override bool INMILKLEPML
		{
			[Cpp2IlInjected.Token(Token = "0x60002D9")]
			[Cpp2IlInjected.Address(RVA = "0x86C5D0", Offset = "0x86B5D0", VA = "0x18086C5D0", Slot = "90")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002DA")]
		[Cpp2IlInjected.Address(RVA = "0x1FE6610", Offset = "0x1FE5610", VA = "0x181FE6610")]
		public OBOPLBIPBMM(DLILHLIBGCM OPKEKBBFIHG, NAAPMGBBPOD OHDOOCGHDGN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DB")]
		[Cpp2IlInjected.Address(RVA = "0x853950", Offset = "0x852950", VA = "0x180853950", Slot = "120")]
		protected override void GHIPLIDCNEB(OHIGDFFLHJA NMEBKEGDNCC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000077")]
	private sealed class CJJDKNEMCPA : CNGEGLEMEMP<CJKEAPABOAC>
	{
		[Cpp2IlInjected.Token(Token = "0x17000044")]
		public override NodeVisualizationKey NAKCNJCFEHA
		{
			[Cpp2IlInjected.Token(Token = "0x60002DC")]
			[Cpp2IlInjected.Address(RVA = "0x9A6590", Offset = "0x9A5590", VA = "0x1809A6590", Slot = "91")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000045")]
		public override bool AJINHILPFLH
		{
			[Cpp2IlInjected.Token(Token = "0x60002DD")]
			[Cpp2IlInjected.Address(RVA = "0x1FDA650", Offset = "0x1FD9650", VA = "0x181FDA650", Slot = "92")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000046")]
		protected override bool INMILKLEPML
		{
			[Cpp2IlInjected.Token(Token = "0x60002DE")]
			[Cpp2IlInjected.Address(RVA = "0x86C5D0", Offset = "0x86B5D0", VA = "0x18086C5D0", Slot = "90")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002DF")]
		[Cpp2IlInjected.Address(RVA = "0x1FDA5E0", Offset = "0x1FD95E0", VA = "0x181FDA5E0")]
		public CJJDKNEMCPA(DLILHLIBGCM OPKEKBBFIHG, CJKEAPABOAC OHDOOCGHDGN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E0")]
		[Cpp2IlInjected.Address(RVA = "0x853950", Offset = "0x852950", VA = "0x180853950", Slot = "120")]
		protected override void GHIPLIDCNEB(OHIGDFFLHJA NMEBKEGDNCC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000078")]
	public sealed class OMGFAHDKIIL : AGBOAEKDJHB<CMKMEGEKCEN>
	{
		[Cpp2IlInjected.Token(Token = "0x2000079")]
		[CompilerGenerated]
		private sealed class OAKFDFFHDBC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400018D")]
			public OMGFAHDKIIL <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400018E")]
			public PCILEDIMGBH nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x60002E3")]
			[Cpp2IlInjected.Address(RVA = "0x85EB60", Offset = "0x85DB60", VA = "0x18085EB60")]
			public OAKFDFFHDBC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002E4")]
			[Cpp2IlInjected.Address(RVA = "0x1FE6590", Offset = "0x1FE5590", VA = "0x181FE6590")]
			internal float JGOHNCMNEGF()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x60002E5")]
			[Cpp2IlInjected.Address(RVA = "0x1FE64F0", Offset = "0x1FE54F0", VA = "0x181FE64F0")]
			internal void ICEKHBLOBBH(float value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002E1")]
		[Cpp2IlInjected.Address(RVA = "0x1FEB980", Offset = "0x1FEA980", VA = "0x181FEB980")]
		public OMGFAHDKIIL(DLILHLIBGCM OPKEKBBFIHG, CMKMEGEKCEN OEFGKJLECGH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E2")]
		[Cpp2IlInjected.Address(RVA = "0x1FEB700", Offset = "0x1FEA700", VA = "0x181FEB700", Slot = "126")]
		protected override void LABKBIBMBCF(OHIGDFFLHJA NMEBKEGDNCC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007A")]
	public sealed class JGMCJNCGOEK : CNGEGLEMEMP<JIBACFMIKAL>
	{
		[Cpp2IlInjected.Token(Token = "0x200007B")]
		[CompilerGenerated]
		private sealed class BHONDPOAFKO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400018F")]
			public JGMCJNCGOEK <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000190")]
			public PCILEDIMGBH nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x60002E8")]
			[Cpp2IlInjected.Address(RVA = "0x85EB60", Offset = "0x85DB60", VA = "0x18085EB60")]
			public BHONDPOAFKO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002E9")]
			[Cpp2IlInjected.Address(RVA = "0x1FD33B0", Offset = "0x1FD23B0", VA = "0x181FD33B0")]
			internal bool NCGMJMFHGEA()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60002EA")]
			[Cpp2IlInjected.Address(RVA = "0x1FD3400", Offset = "0x1FD2400", VA = "0x181FD3400")]
			internal void OIANKMMHODC(bool value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002E6")]
		[Cpp2IlInjected.Address(RVA = "0x1FDF370", Offset = "0x1FDE370", VA = "0x181FDF370")]
		public JGMCJNCGOEK(DLILHLIBGCM OPKEKBBFIHG, JIBACFMIKAL OEFGKJLECGH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E7")]
		[Cpp2IlInjected.Address(RVA = "0x1FDF0C0", Offset = "0x1FDE0C0", VA = "0x181FDF0C0", Slot = "120")]
		protected override void GHIPLIDCNEB(OHIGDFFLHJA NMEBKEGDNCC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007C")]
	public sealed class PHBIFIMDPAJ : CNGEGLEMEMP<JOENKBPNIJP>
	{
		[Cpp2IlInjected.Token(Token = "0x200007D")]
		[CompilerGenerated]
		private sealed class CECGGBAPKLL
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000191")]
			public PCILEDIMGBH nodeAdapterDeps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000192")]
			public PHBIFIMDPAJ <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000193")]
			public Predicate<Guid> <>9__7;

			[Cpp2IlInjected.Token(Token = "0x60002ED")]
			[Cpp2IlInjected.Address(RVA = "0x85EB60", Offset = "0x85DB60", VA = "0x18085EB60")]
			public CECGGBAPKLL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002EE")]
			[Cpp2IlInjected.Address(RVA = "0x1FD9F10", Offset = "0x1FD8F10", VA = "0x181FD9F10")]
			internal object NCGMJMFHGEA()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002EF")]
			[Cpp2IlInjected.Address(RVA = "0x1FDA040", Offset = "0x1FD9040", VA = "0x181FDA040")]
			internal bool OALPLEHLNDH(Guid id)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60002F0")]
			[Cpp2IlInjected.Address(RVA = "0x1FDA0C0", Offset = "0x1FD90C0", VA = "0x181FDA0C0")]
			internal void OIANKMMHODC(object value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002F1")]
			[Cpp2IlInjected.Address(RVA = "0x1FD9D60", Offset = "0x1FD8D60", VA = "0x181FD9D60")]
			internal string GNDADNGFDLE(object key)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002F2")]
			[Cpp2IlInjected.Address(RVA = "0x1FD9B80", Offset = "0x1FD8B80", VA = "0x181FD9B80")]
			internal IReadOnlyList<object> ADBLKAGNGFP()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002F3")]
			[Cpp2IlInjected.Address(RVA = "0x1FD9CF0", Offset = "0x1FD8CF0", VA = "0x181FD9CF0")]
			internal bool DMNAKLFEOCK()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60002F4")]
			[Cpp2IlInjected.Address(RVA = "0x1FD9EC0", Offset = "0x1FD8EC0", VA = "0x181FD9EC0")]
			internal bool LFNPCGFBCGF()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60002F5")]
			[Cpp2IlInjected.Address(RVA = "0x1FD9BD0", Offset = "0x1FD8BD0", VA = "0x181FD9BD0")]
			internal void CNOGCEECIJC(bool value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002EB")]
		[Cpp2IlInjected.Address(RVA = "0x1FEC3C0", Offset = "0x1FEB3C0", VA = "0x181FEC3C0")]
		public PHBIFIMDPAJ(DLILHLIBGCM OPKEKBBFIHG, JOENKBPNIJP OEFGKJLECGH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EC")]
		[Cpp2IlInjected.Address(RVA = "0x1FEBBB0", Offset = "0x1FEABB0", VA = "0x181FEBBB0", Slot = "120")]
		protected override void GHIPLIDCNEB(OHIGDFFLHJA NMEBKEGDNCC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007E")]
	public sealed class NEKMFAENPPI : EIGFGILKFHJ<CEJKGCALNOK>
	{
		[Cpp2IlInjected.Token(Token = "0x17000047")]
		public override NodeVisualizationKey NAKCNJCFEHA
		{
			[Cpp2IlInjected.Token(Token = "0x60002F6")]
			[Cpp2IlInjected.Address(RVA = "0xB773D0", Offset = "0xB763D0", VA = "0x180B773D0", Slot = "91")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002F7")]
		[Cpp2IlInjected.Address(RVA = "0x1FE5230", Offset = "0x1FE4230", VA = "0x181FE5230")]
		public NEKMFAENPPI(DLILHLIBGCM OPKEKBBFIHG, CEJKGCALNOK OHDOOCGHDGN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007F")]
	public sealed class MBJDADGJCHI : AGBOAEKDJHB<HNJMCBHEGAI>
	{
		[Cpp2IlInjected.Token(Token = "0x2000080")]
		[CompilerGenerated]
		private sealed class AALKKLNIOMB
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000194")]
			public MBJDADGJCHI <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000195")]
			public PCILEDIMGBH nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x60002FA")]
			[Cpp2IlInjected.Address(RVA = "0x85EB60", Offset = "0x85DB60", VA = "0x18085EB60")]
			public AALKKLNIOMB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002FB")]
			[Cpp2IlInjected.Address(RVA = "0x1FD1D40", Offset = "0x1FD0D40", VA = "0x181FD1D40")]
			internal int JGOHNCMNEGF()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60002FC")]
			[Cpp2IlInjected.Address(RVA = "0x1FD1CA0", Offset = "0x1FD0CA0", VA = "0x181FD1CA0")]
			internal void ICEKHBLOBBH(int value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002F8")]
		[Cpp2IlInjected.Address(RVA = "0x1FE47B0", Offset = "0x1FE37B0", VA = "0x181FE47B0")]
		public MBJDADGJCHI(DLILHLIBGCM OPKEKBBFIHG, HNJMCBHEGAI OEFGKJLECGH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F9")]
		[Cpp2IlInjected.Address(RVA = "0x1FE4520", Offset = "0x1FE3520", VA = "0x181FE4520", Slot = "126")]
		protected override void LABKBIBMBCF(OHIGDFFLHJA NMEBKEGDNCC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000081")]
	public sealed class AMPOJPEJDCD : CNGEGLEMEMP<AGNLBHLNBAP>
	{
		[Cpp2IlInjected.Token(Token = "0x2000082")]
		[CompilerGenerated]
		private sealed class KDKNCLMLAFO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000196")]
			public AMPOJPEJDCD <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000197")]
			public PCILEDIMGBH nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x60002FF")]
			[Cpp2IlInjected.Address(RVA = "0x85EB60", Offset = "0x85DB60", VA = "0x18085EB60")]
			public KDKNCLMLAFO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000300")]
			[Cpp2IlInjected.Address(RVA = "0x1FE1BC0", Offset = "0x1FE0BC0", VA = "0x181FE1BC0")]
			internal bool NCGMJMFHGEA()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000301")]
			[Cpp2IlInjected.Address(RVA = "0x1FE1C10", Offset = "0x1FE0C10", VA = "0x181FE1C10")]
			internal void OIANKMMHODC(bool value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002FD")]
		[Cpp2IlInjected.Address(RVA = "0x1FD2B10", Offset = "0x1FD1B10", VA = "0x181FD2B10")]
		public AMPOJPEJDCD(DLILHLIBGCM OPKEKBBFIHG, AGNLBHLNBAP OEFGKJLECGH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002FE")]
		[Cpp2IlInjected.Address(RVA = "0x1FD2930", Offset = "0x1FD1930", VA = "0x181FD2930", Slot = "120")]
		protected override void GHIPLIDCNEB(OHIGDFFLHJA NMEBKEGDNCC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000083")]
	public sealed class DEKBIKMNKJL : CNGEGLEMEMP<EIIEEOCOALN>
	{
		[Cpp2IlInjected.Token(Token = "0x2000084")]
		[CompilerGenerated]
		private sealed class OPICLLOLCOL
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000198")]
			public DEKBIKMNKJL <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000199")]
			public PCILEDIMGBH nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x6000304")]
			[Cpp2IlInjected.Address(RVA = "0x85EB60", Offset = "0x85DB60", VA = "0x18085EB60")]
			public OPICLLOLCOL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000305")]
			[Cpp2IlInjected.Address(RVA = "0x1FEB9E0", Offset = "0x1FEA9E0", VA = "0x181FEB9E0")]
			internal bool NCGMJMFHGEA()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000306")]
			[Cpp2IlInjected.Address(RVA = "0x1FEBA30", Offset = "0x1FEAA30", VA = "0x181FEBA30")]
			internal void OIANKMMHODC(bool value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000302")]
		[Cpp2IlInjected.Address(RVA = "0x1FDAC70", Offset = "0x1FD9C70", VA = "0x181FDAC70")]
		public DEKBIKMNKJL(DLILHLIBGCM OPKEKBBFIHG, EIIEEOCOALN OEFGKJLECGH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000303")]
		[Cpp2IlInjected.Address(RVA = "0x1FDAA90", Offset = "0x1FD9A90", VA = "0x181FDAA90", Slot = "120")]
		protected override void GHIPLIDCNEB(OHIGDFFLHJA NMEBKEGDNCC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000085")]
	public sealed class CHILGPANJLO : CNGEGLEMEMP<HAFPNJNDIFK>
	{
		[Cpp2IlInjected.Token(Token = "0x2000086")]
		[CompilerGenerated]
		private sealed class ENIKAKEOLEJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400019A")]
			public CHILGPANJLO <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400019B")]
			public PCILEDIMGBH nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x6000309")]
			[Cpp2IlInjected.Address(RVA = "0x85EB60", Offset = "0x85DB60", VA = "0x18085EB60")]
			public ENIKAKEOLEJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600030A")]
			[Cpp2IlInjected.Address(RVA = "0x1FDB610", Offset = "0x1FDA610", VA = "0x181FDB610")]
			internal int NCGMJMFHGEA()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x600030B")]
			[Cpp2IlInjected.Address(RVA = "0x1FDB660", Offset = "0x1FDA660", VA = "0x181FDB660")]
			internal void OIANKMMHODC(int value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000307")]
		[Cpp2IlInjected.Address(RVA = "0x1FDA570", Offset = "0x1FD9570", VA = "0x181FDA570")]
		public CHILGPANJLO(DLILHLIBGCM OPKEKBBFIHG, HAFPNJNDIFK OEFGKJLECGH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000308")]
		[Cpp2IlInjected.Address(RVA = "0x1FDA310", Offset = "0x1FD9310", VA = "0x181FDA310", Slot = "120")]
		protected override void GHIPLIDCNEB(OHIGDFFLHJA NMEBKEGDNCC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000087")]
	public sealed class LAACEMNPCLL : KIJMOGHLELH<ONCOONCAGFP>
	{
		[Cpp2IlInjected.Token(Token = "0x17000048")]
		public override DKMOPNEOHLH JODFAEOIPMC
		{
			[Cpp2IlInjected.Token(Token = "0x600030D")]
			[Cpp2IlInjected.Address(RVA = "0x9AF2F0", Offset = "0x9AE2F0", VA = "0x1809AF2F0", Slot = "126")]
			get
			{
				return default(DKMOPNEOHLH);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600030C")]
		[Cpp2IlInjected.Address(RVA = "0x1FE2B70", Offset = "0x1FE1B70", VA = "0x181FE2B70")]
		public LAACEMNPCLL(DLILHLIBGCM OPKEKBBFIHG, ONCOONCAGFP OEFGKJLECGH)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000088")]
	public class GOIJLODPFMF : CNGEGLEMEMP<EMGONNJLBBJ>
	{
		[Cpp2IlInjected.Token(Token = "0x600030E")]
		[Cpp2IlInjected.Address(RVA = "0x1FDD390", Offset = "0x1FDC390", VA = "0x181FDD390")]
		public GOIJLODPFMF(DLILHLIBGCM OPKEKBBFIHG, EMGONNJLBBJ OHDOOCGHDGN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000089")]
	public abstract class CNGEGLEMEMP<TNode> : BHHANIGFAMG, IDisposable where TNode : notnull, EMGONNJLBBJ
	{
		[Cpp2IlInjected.Token(Token = "0x200008A")]
		[CompilerGenerated]
		private sealed class CANKECNLAFO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001B3")]
			public CNGEGLEMEMP<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001B4")]
			public DLILHLIBGCM circuitsManager;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001B5")]
			public TNode node;

			[Cpp2IlInjected.Token(Token = "0x600038C")]
			[Cpp2IlInjected.Address(RVA = "0x85EB60", Offset = "0x85DB60", VA = "0x18085EB60")]
			public CANKECNLAFO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600038D")]
			[Cpp2IlInjected.Address(RVA = "0x50A8970", Offset = "0x50A7970", VA = "0x1850A8970")]
			internal BNIFOFOKPDE JPDFCCPHLKF(KDAKJINBHOH portGroup, int id)
			{
				return null;
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200008B")]
		[CompilerGenerated]
		private struct NNIKEDBANNE : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001B6")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001B7")]
			public AsyncVoidMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001B8")]
			public CNGEGLEMEMP<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001B9")]
			public int newColor;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001BA")]
			private TaskAwaiter<DFAHBLOKBPH<OKOMLKNINNF, CKBHMJGLAPL>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600038E")]
			[Cpp2IlInjected.Address(RVA = "0x46034D0", Offset = "0x46024D0", VA = "0x1846034D0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600038F")]
			[Cpp2IlInjected.Address(RVA = "0xA6A710", Offset = "0xA69710", VA = "0x180A6A710", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200008C")]
		[CompilerGenerated]
		private struct HKHLLGCNEHK : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001BB")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001BC")]
			public AsyncTaskMethodBuilder<DFAHBLOKBPH<OKOMLKNINNF, CKBHMJGLAPL>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001BD")]
			public CNGEGLEMEMP<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001BE")]
			public DOAHODDKGGE? localPosition;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001BF")]
			public DLLFCGBFLBH? localRotation;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001C0")]
			private TaskAwaiter<DFAHBLOKBPH<OKOMLKNINNF, CKBHMJGLAPL>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000390")]
			[Cpp2IlInjected.Address(RVA = "0x3DE30D0", Offset = "0x3DE20D0", VA = "0x183DE30D0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000391")]
			[Cpp2IlInjected.Address(RVA = "0x3DE3370", Offset = "0x3DE2370", VA = "0x183DE3370", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200008D")]
		[CompilerGenerated]
		private sealed class HHKNPNFHCOI
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
				public HHKNPNFHCOI <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001CB")]
				private TaskAwaiter<bool> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x6000396")]
				[Cpp2IlInjected.Address(RVA = "0x35C9140", Offset = "0x35C8140", VA = "0x1835C9140", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000397")]
				[Cpp2IlInjected.Address(RVA = "0xA6A710", Offset = "0xA69710", VA = "0x180A6A710", Slot = "5")]
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
			public PCILEDIMGBH nodeAdapterDeps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001C4")]
			public CNGEGLEMEMP<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001C5")]
			public Func<string> getConfigurableName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001C6")]
			public OHIGDFFLHJA configure;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001C7")]
			public Action<string> setConfigurableName;

			[Cpp2IlInjected.Token(Token = "0x6000392")]
			[Cpp2IlInjected.Address(RVA = "0x85EB60", Offset = "0x85DB60", VA = "0x18085EB60")]
			public HHKNPNFHCOI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000393")]
			[Cpp2IlInjected.Address(RVA = "0x8518C0", Offset = "0x8508C0", VA = "0x1808518C0")]
			internal string JEGGOKLKPIJ()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000394")]
			[Cpp2IlInjected.Address(RVA = "0x851910", Offset = "0x850910", VA = "0x180851910")]
			internal void EGIOOFLHAHK(string value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000395")]
			[Cpp2IlInjected.Address(RVA = "0x3DDAEB0", Offset = "0x3DD9EB0", VA = "0x183DDAEB0")]
			[AsyncStateMachine(typeof(CNGEGLEMEMP<>.HHKNPNFHCOI.<<BuildStringChangeMenuInternal>b__2>d))]
			internal void PENLJCGPHLI()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200008F")]
		[CompilerGenerated]
		private sealed class BIMMPEBBKIL
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001CC")]
			public PCILEDIMGBH nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x6000398")]
			[Cpp2IlInjected.Address(RVA = "0x85EB60", Offset = "0x85DB60", VA = "0x18085EB60")]
			public BIMMPEBBKIL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000399")]
			[Cpp2IlInjected.Address(RVA = "0x4E945D0", Offset = "0x4E935D0", VA = "0x184E945D0")]
			internal bool JHLLNMJCLAI(string text)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600039A")]
			[Cpp2IlInjected.Address(RVA = "0x4E945C0", Offset = "0x4E935C0", VA = "0x184E945C0")]
			internal bool DADIBIMAMLA(string text)
			{
				return default(bool);
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000090")]
		[CompilerGenerated]
		private struct PICBEDJPBEA : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001CD")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001CE")]
			public AsyncTaskMethodBuilder<DFAHBLOKBPH<OKOMLKNINNF, CKBHMJGLAPL>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001CF")]
			public CNGEGLEMEMP<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001D0")]
			public string newName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001D1")]
			private TaskAwaiter<DFAHBLOKBPH<OKOMLKNINNF, CKBHMJGLAPL>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600039B")]
			[Cpp2IlInjected.Address(RVA = "0x47A4EA0", Offset = "0x47A3EA0", VA = "0x1847A4EA0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600039C")]
			[Cpp2IlInjected.Address(RVA = "0x47A51A0", Offset = "0x47A41A0", VA = "0x1847A51A0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400019C")]
		private readonly DLILHLIBGCM CPJCBIFJBNF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400019D")]
		private readonly bool LEEEOGFCEKK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400019E")]
		private PKEPENJENKF<IHOAGKINOHG, BNIFOFOKPDE> BFEIFGMHGOB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400019F")]
		private PKEPENJENKF<IHOAGKINOHG, MOFLLCAHOFM> LJBHKJEFKEG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001A7")]
		private List<Action> KHIGLPIDBNK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001AF")]
		[CompilerGenerated]
		private Action<BGKDPCAKPBJ<IHOAGKINOHG>>? FEFABNLGFEL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001B0")]
		[CompilerGenerated]
		private Action<BGKDPCAKPBJ<IHOAGKINOHG>, MOFLLCAHOFM>? HPCGCNMMEKO;

		[Cpp2IlInjected.Token(Token = "0x17000049")]
		protected OIBAKLEHGAH JPGGKCKGDFG
		{
			[Cpp2IlInjected.Token(Token = "0x600030F")]
			[Cpp2IlInjected.Address(RVA = "0x553CEA0", Offset = "0x553BEA0", VA = "0x18553CEA0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004A")]
		protected PCILEDIMGBH GEOBPHNOLHB
		{
			[Cpp2IlInjected.Token(Token = "0x6000310")]
			[Cpp2IlInjected.Address(RVA = "0x55405B0", Offset = "0x553F5B0", VA = "0x1855405B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004B")]
		protected TNode CPFJDMHAFGD
		{
			[Cpp2IlInjected.Token(Token = "0x6000314")]
			[Cpp2IlInjected.Address(RVA = "0x851920", Offset = "0x850920", VA = "0x180851920")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004C")]
		public MFLENLEMIJF<CLCGFMMKGBC> OJMEPLIFEFO
		{
			[Cpp2IlInjected.Token(Token = "0x6000315")]
			[Cpp2IlInjected.Address(RVA = "0xC115A0", Offset = "0xC105A0", VA = "0x180C115A0", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(MFLENLEMIJF<CLCGFMMKGBC>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004D")]
		public BGKDPCAKPBJ<ABFLKBFLLLK> DJKMKNEOOKN
		{
			[Cpp2IlInjected.Token(Token = "0x6000316")]
			[Cpp2IlInjected.Address(RVA = "0x5541970", Offset = "0x5540970", VA = "0x185541970", Slot = "6")]
			get
			{
				return default(BGKDPCAKPBJ<ABFLKBFLLLK>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004E")]
		public object HLIPLMDLIEL
		{
			[Cpp2IlInjected.Token(Token = "0x6000317")]
			[Cpp2IlInjected.Address(RVA = "0x38FCC80", Offset = "0x38FBC80", VA = "0x1838FCC80", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004F")]
		public virtual bool FICPPNNAFKH
		{
			[Cpp2IlInjected.Token(Token = "0x6000318")]
			[Cpp2IlInjected.Address(RVA = "0x86C5D0", Offset = "0x86B5D0", VA = "0x18086C5D0", Slot = "89")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000050")]
		public int JCCNEGPADMB
		{
			[Cpp2IlInjected.Token(Token = "0x6000319")]
			[Cpp2IlInjected.Address(RVA = "0x55415E0", Offset = "0x55405E0", VA = "0x1855415E0", Slot = "8")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000051")]
		public LIIMFCKBCIO FDJHLHBLJNF
		{
			[Cpp2IlInjected.Token(Token = "0x600031B")]
			[Cpp2IlInjected.Address(RVA = "0x5541590", Offset = "0x5540590", VA = "0x185541590", Slot = "10")]
			get
			{
				return default(LIIMFCKBCIO);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000052")]
		public string IEACFMJMCGD
		{
			[Cpp2IlInjected.Token(Token = "0x600031C")]
			[Cpp2IlInjected.Address(RVA = "0x5541B20", Offset = "0x5540B20", VA = "0x185541B20", Slot = "11")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000053")]
		protected virtual bool INMILKLEPML
		{
			[Cpp2IlInjected.Token(Token = "0x600031D")]
			[Cpp2IlInjected.Address(RVA = "0x89A950", Offset = "0x899950", VA = "0x18089A950", Slot = "90")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000054")]
		public virtual NodeVisualizationKey NAKCNJCFEHA
		{
			[Cpp2IlInjected.Token(Token = "0x600031E")]
			[Cpp2IlInjected.Address(RVA = "0x853960", Offset = "0x852960", VA = "0x180853960", Slot = "91")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000055")]
		public BGKDPCAKPBJ<JCPBGLHIAPE> KCNPEGOEDME
		{
			[Cpp2IlInjected.Token(Token = "0x600031F")]
			[Cpp2IlInjected.Address(RVA = "0x9F2000", Offset = "0x9F1000", VA = "0x1809F2000", Slot = "13")]
			[CompilerGenerated]
			get
			{
				return default(BGKDPCAKPBJ<JCPBGLHIAPE>);
			}
			[Cpp2IlInjected.Token(Token = "0x6000320")]
			[Cpp2IlInjected.Address(RVA = "0xBFEF00", Offset = "0xBFDF00", VA = "0x180BFEF00")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000056")]
		public virtual bool AJINHILPFLH
		{
			[Cpp2IlInjected.Token(Token = "0x6000321")]
			[Cpp2IlInjected.Address(RVA = "0x89A950", Offset = "0x899950", VA = "0x18089A950", Slot = "92")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000057")]
		public virtual bool HPNAOALGLGH
		{
			[Cpp2IlInjected.Token(Token = "0x6000322")]
			[Cpp2IlInjected.Address(RVA = "0x89A950", Offset = "0x899950", VA = "0x18089A950", Slot = "93")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000058")]
		public virtual LNNDEAMLFKK LGLNDOOCKBH
		{
			[Cpp2IlInjected.Token(Token = "0x6000323")]
			[Cpp2IlInjected.Address(RVA = "0x95FC80", Offset = "0x95EC80", VA = "0x18095FC80", Slot = "94")]
			get
			{
				return default(LNNDEAMLFKK);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000059")]
		public bool IKNDCNLCDAN
		{
			[Cpp2IlInjected.Token(Token = "0x6000324")]
			[Cpp2IlInjected.Address(RVA = "0x5541300", Offset = "0x5540300", VA = "0x185541300", Slot = "17")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005A")]
		public bool EKKPBPCJPOD
		{
			[Cpp2IlInjected.Token(Token = "0x6000325")]
			[Cpp2IlInjected.Address(RVA = "0x5541360", Offset = "0x5540360", VA = "0x185541360", Slot = "18")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005B")]
		public bool KBGLDGJLBGO
		{
			[Cpp2IlInjected.Token(Token = "0x6000326")]
			[Cpp2IlInjected.Address(RVA = "0x55413C0", Offset = "0x55403C0", VA = "0x1855413C0", Slot = "19")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005C")]
		public int FALBPIKPELB
		{
			[Cpp2IlInjected.Token(Token = "0x6000327")]
			[Cpp2IlInjected.Address(RVA = "0x5541920", Offset = "0x5540920", VA = "0x185541920", Slot = "20")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005D")]
		public bool JGGNFAFHGFG
		{
			[Cpp2IlInjected.Token(Token = "0x6000328")]
			[Cpp2IlInjected.Address(RVA = "0x5541760", Offset = "0x5540760", VA = "0x185541760", Slot = "21")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005E")]
		public bool JJPCBONLOKN
		{
			[Cpp2IlInjected.Token(Token = "0x6000329")]
			[Cpp2IlInjected.Address(RVA = "0x55414D0", Offset = "0x55404D0", VA = "0x1855414D0", Slot = "22")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005F")]
		public bool CFHHDNFECDJ
		{
			[Cpp2IlInjected.Token(Token = "0x600032A")]
			[Cpp2IlInjected.Address(RVA = "0x5541470", Offset = "0x5540470", VA = "0x185541470", Slot = "23")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000060")]
		public bool JBDIPGLKBGI
		{
			[Cpp2IlInjected.Token(Token = "0x600032B")]
			[Cpp2IlInjected.Address(RVA = "0xD57E60", Offset = "0xD56E60", VA = "0x180D57E60", Slot = "24")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600032C")]
			[Cpp2IlInjected.Address(RVA = "0xD58270", Offset = "0xD57270", VA = "0x180D58270")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000061")]
		public virtual bool ENGGLEMFGFM
		{
			[Cpp2IlInjected.Token(Token = "0x600032D")]
			[Cpp2IlInjected.Address(RVA = "0x89A950", Offset = "0x899950", VA = "0x18089A950", Slot = "95")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000062")]
		public virtual bool ECGIHADMMKP
		{
			[Cpp2IlInjected.Token(Token = "0x600032E")]
			[Cpp2IlInjected.Address(RVA = "0x5541420", Offset = "0x5540420", VA = "0x185541420", Slot = "96")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000063")]
		public bool LMFIGGGNILN
		{
			[Cpp2IlInjected.Token(Token = "0x600032F")]
			[Cpp2IlInjected.Address(RVA = "0x5541690", Offset = "0x5540690", VA = "0x185541690", Slot = "27")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000064")]
		public DOAHODDKGGE OFOBIKFANPO
		{
			[Cpp2IlInjected.Token(Token = "0x6000330")]
			[Cpp2IlInjected.Address(RVA = "0x5541860", Offset = "0x5540860", VA = "0x185541860", Slot = "28")]
			get
			{
				return default(DOAHODDKGGE);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000065")]
		public DLLFCGBFLBH IMOOEMJKGCC
		{
			[Cpp2IlInjected.Token(Token = "0x6000332")]
			[Cpp2IlInjected.Address(RVA = "0x55418C0", Offset = "0x55408C0", VA = "0x1855418C0", Slot = "30")]
			get
			{
				return default(DLLFCGBFLBH);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000066")]
		public virtual bool NBFHMIKMHKN
		{
			[Cpp2IlInjected.Token(Token = "0x6000350")]
			[Cpp2IlInjected.Address(RVA = "0x89A950", Offset = "0x899950", VA = "0x18089A950", Slot = "108")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000067")]
		public virtual JKHKFPFKCBP? DMNLJLPJHDK
		{
			[Cpp2IlInjected.Token(Token = "0x6000351")]
			[Cpp2IlInjected.Address(RVA = "0x853960", Offset = "0x852960", VA = "0x180853960", Slot = "109")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000068")]
		public virtual GNMBOACGMBD? EMINCJAEADG
		{
			[Cpp2IlInjected.Token(Token = "0x6000352")]
			[Cpp2IlInjected.Address(RVA = "0x853960", Offset = "0x852960", VA = "0x180853960", Slot = "110")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000069")]
		public virtual IEnumerable<MFLENLEMIJF<PMIFAKHBGDE>>? BEOOECKAFCB
		{
			[Cpp2IlInjected.Token(Token = "0x6000353")]
			[Cpp2IlInjected.Address(RVA = "0x853960", Offset = "0x852960", VA = "0x180853960", Slot = "111")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006A")]
		public bool MHJKKHBCAML
		{
			[Cpp2IlInjected.Token(Token = "0x6000357")]
			[Cpp2IlInjected.Address(RVA = "0x5541530", Offset = "0x5540530", VA = "0x185541530", Slot = "114")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006B")]
		public MFLENLEMIJF<EHIJHEMDKLF> EBCJHIBBHLN
		{
			[Cpp2IlInjected.Token(Token = "0x6000358")]
			[Cpp2IlInjected.Address(RVA = "0x55417B0", Offset = "0x55407B0", VA = "0x1855417B0", Slot = "62")]
			get
			{
				return default(MFLENLEMIJF<EHIJHEMDKLF>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006C")]
		public BGKDPCAKPBJ<EHIJHEMDKLF> NGMAJELLEMM
		{
			[Cpp2IlInjected.Token(Token = "0x6000359")]
			[Cpp2IlInjected.Address(RVA = "0x5541630", Offset = "0x5540630", VA = "0x185541630", Slot = "56")]
			get
			{
				return default(BGKDPCAKPBJ<EHIJHEMDKLF>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006D")]
		public virtual bool IFFEOKHGMHD
		{
			[Cpp2IlInjected.Token(Token = "0x600035A")]
			[Cpp2IlInjected.Address(RVA = "0x89A950", Offset = "0x899950", VA = "0x18089A950", Slot = "115")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006E")]
		public virtual BGKDPCAKPBJ<EHIJHEMDKLF>? IIKIBPOGNLE
		{
			[Cpp2IlInjected.Token(Token = "0x600035B")]
			[Cpp2IlInjected.Address(RVA = "0x853960", Offset = "0x852960", VA = "0x180853960", Slot = "116")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006F")]
		public virtual bool GJJDOEEDBBO
		{
			[Cpp2IlInjected.Token(Token = "0x600035C")]
			[Cpp2IlInjected.Address(RVA = "0x89A950", Offset = "0x899950", VA = "0x18089A950", Slot = "117")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000070")]
		public bool HHKHDCDMJGC
		{
			[Cpp2IlInjected.Token(Token = "0x600035D")]
			[Cpp2IlInjected.Address(RVA = "0x55416F0", Offset = "0x55406F0", VA = "0x1855416F0", Slot = "61")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000071")]
		public string NPDJPDJBDCA
		{
			[Cpp2IlInjected.Token(Token = "0x600035E")]
			[Cpp2IlInjected.Address(RVA = "0x85FB20", Offset = "0x85EB20", VA = "0x18085FB20", Slot = "64")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600035F")]
			[Cpp2IlInjected.Address(RVA = "0x85FB30", Offset = "0x85EB30", VA = "0x18085FB30")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000072")]
		private string BKELHPKNOHP
		{
			[Cpp2IlInjected.Token(Token = "0x6000360")]
			[Cpp2IlInjected.Address(RVA = "0x85FC80", Offset = "0x85EC80", VA = "0x18085FC80")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000073")]
		public MFLENLEMIJF<PMIFAKHBGDE> BOFDPMBCPAD
		{
			[Cpp2IlInjected.Token(Token = "0x6000361")]
			[Cpp2IlInjected.Address(RVA = "0x5541810", Offset = "0x5540810", VA = "0x185541810", Slot = "63")]
			get
			{
				return default(MFLENLEMIJF<PMIFAKHBGDE>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000074")]
		public MFLENLEMIJF<PMIFAKHBGDE>? JDIBBMOHMNE
		{
			[Cpp2IlInjected.Token(Token = "0x6000362")]
			[Cpp2IlInjected.Address(RVA = "0x55419F0", Offset = "0x55409F0", VA = "0x1855419F0", Slot = "118")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000075")]
		public CFDIOFGMMPB<IHOAGKINOHG, MOFLLCAHOFM> JNGNMAEADFG
		{
			[Cpp2IlInjected.Token(Token = "0x6000363")]
			[Cpp2IlInjected.Address(RVA = "0x5541AE0", Offset = "0x5540AE0", VA = "0x185541AE0", Slot = "65")]
			get
			{
				return default(CFDIOFGMMPB<IHOAGKINOHG, MOFLLCAHOFM>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000076")]
		public virtual BGKDPCAKPBJ<IHOAGKINOHG>? NGGHLMJBNGJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000364")]
			[Cpp2IlInjected.Address(RVA = "0x853960", Offset = "0x852960", VA = "0x180853960", Slot = "119")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000077")]
		public virtual bool BEAKBLDBAPD
		{
			[Cpp2IlInjected.Token(Token = "0x6000377")]
			[Cpp2IlInjected.Address(RVA = "0x89A950", Offset = "0x899950", VA = "0x18089A950", Slot = "122")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000078")]
		public virtual bool NHIOJFMBBEH
		{
			[Cpp2IlInjected.Token(Token = "0x6000378")]
			[Cpp2IlInjected.Address(RVA = "0x86C5D0", Offset = "0x86B5D0", VA = "0x18086C5D0", Slot = "123")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action LHMBGIDALFH
		{
			[Cpp2IlInjected.Token(Token = "0x6000339")]
			[Cpp2IlInjected.Address(RVA = "0x553E050", Offset = "0x553D050", VA = "0x18553E050", Slot = "37")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600033A")]
			[Cpp2IlInjected.Address(RVA = "0x553F0E0", Offset = "0x553E0E0", VA = "0x18553F0E0", Slot = "38")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event MEFFFOJCHNN ECEHLDGLDCJ
		{
			[Cpp2IlInjected.Token(Token = "0x600033C")]
			[Cpp2IlInjected.Address(RVA = "0x553E4B0", Offset = "0x553D4B0", VA = "0x18553E4B0", Slot = "39")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600033D")]
			[Cpp2IlInjected.Address(RVA = "0x553F700", Offset = "0x553E700", VA = "0x18553F700", Slot = "40")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		public event DGFCKIJPLAP MJLOCFIMMCG
		{
			[Cpp2IlInjected.Token(Token = "0x600033E")]
			[Cpp2IlInjected.Address(RVA = "0x553CBC0", Offset = "0x553BBC0", VA = "0x18553CBC0", Slot = "41")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600033F")]
			[Cpp2IlInjected.Address(RVA = "0x553DFB0", Offset = "0x553CFB0", VA = "0x18553DFB0", Slot = "42")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000004")]
		public event Action IOFAHGBDBFI
		{
			[Cpp2IlInjected.Token(Token = "0x6000340")]
			[Cpp2IlInjected.Address(RVA = "0x553DA50", Offset = "0x553CA50", VA = "0x18553DA50", Slot = "43")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000341")]
			[Cpp2IlInjected.Address(RVA = "0x553E6A0", Offset = "0x553D6A0", VA = "0x18553E6A0", Slot = "44")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000005")]
		public event Action JMIMNMAIOEP
		{
			[Cpp2IlInjected.Token(Token = "0x6000342")]
			[Cpp2IlInjected.Address(RVA = "0x5540CA0", Offset = "0x553FCA0", VA = "0x185540CA0", Slot = "45")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000343")]
			[Cpp2IlInjected.Address(RVA = "0x553E550", Offset = "0x553D550", VA = "0x18553E550", Slot = "46")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000006")]
		public event Action<BGKDPCAKPBJ<IHOAGKINOHG>, MOFLLCAHOFM> LJOKJOKDOED
		{
			[Cpp2IlInjected.Token(Token = "0x6000365")]
			[Cpp2IlInjected.Address(RVA = "0x553E3F0", Offset = "0x553D3F0", VA = "0x18553E3F0", Slot = "67")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000366")]
			[Cpp2IlInjected.Address(RVA = "0x553CD20", Offset = "0x553BD20", VA = "0x18553CD20", Slot = "68")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000007")]
		public event Action<BGKDPCAKPBJ<IHOAGKINOHG>, MOFLLCAHOFM> KLCHKBAMPDH
		{
			[Cpp2IlInjected.Token(Token = "0x6000367")]
			[Cpp2IlInjected.Address(RVA = "0x553EDD0", Offset = "0x553DDD0", VA = "0x18553EDD0", Slot = "71")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000368")]
			[Cpp2IlInjected.Address(RVA = "0x55404F0", Offset = "0x553F4F0", VA = "0x1855404F0", Slot = "72")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000008")]
		public event Action<BGKDPCAKPBJ<IHOAGKINOHG>> FMMBFAHLFBG
		{
			[Cpp2IlInjected.Token(Token = "0x6000369")]
			[Cpp2IlInjected.Address(RVA = "0x553CDE0", Offset = "0x553BDE0", VA = "0x18553CDE0", Slot = "69")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600036A")]
			[Cpp2IlInjected.Address(RVA = "0x553EE90", Offset = "0x553DE90", VA = "0x18553EE90", Slot = "70")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000009")]
		public event Action<BGKDPCAKPBJ<IHOAGKINOHG>, BGKDPCAKPBJ<IHOAGKINOHG>> EAFFDDGMONE
		{
			[Cpp2IlInjected.Token(Token = "0x600036B")]
			[Cpp2IlInjected.Address(RVA = "0x553C280", Offset = "0x553B280", VA = "0x18553C280", Slot = "73")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600036C")]
			[Cpp2IlInjected.Address(RVA = "0x553CC60", Offset = "0x553BC60", VA = "0x18553CC60", Slot = "74")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000A")]
		public event Action<BGKDPCAKPBJ<IHOAGKINOHG>, MOFLLCAHOFM> IKBAEMCCBJO
		{
			[Cpp2IlInjected.Token(Token = "0x600036D")]
			[Cpp2IlInjected.Address(RVA = "0x553D840", Offset = "0x553C840", VA = "0x18553D840", Slot = "75")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600036E")]
			[Cpp2IlInjected.Address(RVA = "0x553C3B0", Offset = "0x553B3B0", VA = "0x18553C3B0", Slot = "76")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000B")]
		public event Action<BGKDPCAKPBJ<IHOAGKINOHG>, BGKDPCAKPBJ<IHOAGKINOHG>> NDJBGAKMFJA
		{
			[Cpp2IlInjected.Token(Token = "0x600036F")]
			[Cpp2IlInjected.Address(RVA = "0x553E0F0", Offset = "0x553D0F0", VA = "0x18553E0F0", Slot = "77")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000370")]
			[Cpp2IlInjected.Address(RVA = "0x553CF00", Offset = "0x553BF00", VA = "0x18553CF00", Slot = "78")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000311")]
		[Cpp2IlInjected.Address(RVA = "0x5540D40", Offset = "0x553FD40", VA = "0x185540D40")]
		[KLDKOFJPICD("Need to handle `Name` better.")]
		[KLDKOFJPICD("Creating the port adapter needs to actually read the `canInteract` state rather than just passing in `true`.")]
		protected CNGEGLEMEMP(DLILHLIBGCM OPKEKBBFIHG, TNode OHDOOCGHDGN, bool HBPNKNHGJMP = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000312")]
		[Cpp2IlInjected.Address(RVA = "0x553FAC0", Offset = "0x553EAC0", VA = "0x18553FAC0", Slot = "87")]
		protected virtual void LFNNOPDGNGK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000313")]
		[Cpp2IlInjected.Address(RVA = "0x553CFC0", Offset = "0x553BFC0", VA = "0x18553CFC0", Slot = "88")]
		public virtual void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600031A")]
		[Cpp2IlInjected.Address(RVA = "0x553E5F0", Offset = "0x553D5F0", VA = "0x18553E5F0", Slot = "9")]
		[AsyncStateMachine(typeof(CNGEGLEMEMP<>.NNIKEDBANNE))]
		public void HPEKBGNDODL(int OIALFGBDFGI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000331")]
		[Cpp2IlInjected.Address(RVA = "0x5540A90", Offset = "0x553FA90", VA = "0x185540A90")]
		public bool PDDNJAILNEJ([In] DOAHODDKGGE JJCEIJMGOAB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000333")]
		[Cpp2IlInjected.Address(RVA = "0x553E230", Offset = "0x553D230", VA = "0x18553E230")]
		public bool GLNOPJJOAFP([In] DLLFCGBFLBH JJCEIJMGOAB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000334")]
		[Cpp2IlInjected.Address(RVA = "0x553C470", Offset = "0x553B470", VA = "0x18553C470", Slot = "32")]
		public void BBELKCJGNCI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000335")]
		[Cpp2IlInjected.Address(RVA = "0x553E2A0", Offset = "0x553D2A0", VA = "0x18553E2A0", Slot = "33")]
		[AsyncStateMachine(typeof(CNGEGLEMEMP<>.HKHLLGCNEHK))]
		public Task<DFAHBLOKBPH<OKOMLKNINNF, CKBHMJGLAPL>> GNNKHPCICCG(DOAHODDKGGE? IJLMJJLHNIG, DLLFCGBFLBH? EJNJAFFEDPH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000336")]
		[Cpp2IlInjected.Address(RVA = "0x853950", Offset = "0x852950", VA = "0x180853950", Slot = "97")]
		public virtual void GDADKPELLDI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000337")]
		[Cpp2IlInjected.Address(RVA = "0x853950", Offset = "0x852950", VA = "0x180853950", Slot = "98")]
		public virtual void KNHJMBJMHGK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000338")]
		[Cpp2IlInjected.Address(RVA = "0x853950", Offset = "0x852950", VA = "0x180853950", Slot = "99")]
		public virtual void KNLOHIFGCFN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600033B")]
		[Cpp2IlInjected.Address(RVA = "0x1E4E980", Offset = "0x1E4D980", VA = "0x181E4E980")]
		protected void GDGDHKJKABA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000344")]
		[Cpp2IlInjected.Address(RVA = "0x49B8B00", Offset = "0x49B7B00", VA = "0x1849B8B00")]
		protected void BEOKAACELMD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000345")]
		[Cpp2IlInjected.Address(RVA = "0x21D53F0", Offset = "0x21D43F0", VA = "0x1821D53F0")]
		private void BLANDJFBJFA([In] DLLFCGBFLBH BCKIPOGEHOJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000346")]
		[Cpp2IlInjected.Address(RVA = "0x5540B00", Offset = "0x553FB00", VA = "0x185540B00", Slot = "100")]
		public virtual Task<DFAHBLOKBPH<BGKDPCAKPBJ<IHOAGKINOHG>, CKBHMJGLAPL>> PGIDCCGEGJH(string CKEJJGPNKGO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000347")]
		[Cpp2IlInjected.Address(RVA = "0x5540BD0", Offset = "0x553FBD0", VA = "0x185540BD0", Slot = "101")]
		public virtual Task<DFAHBLOKBPH<OKOMLKNINNF, CKBHMJGLAPL>> PHDPIMFBHPJ(BGKDPCAKPBJ<IHOAGKINOHG> FCFGPBAFAPA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000348")]
		[Cpp2IlInjected.Address(RVA = "0x853950", Offset = "0x852950", VA = "0x180853950", Slot = "102")]
		public virtual void FKHOGEFEOLJ(BGKDPCAKPBJ<IHOAGKINOHG> PCLHMJBKBOE, BGKDPCAKPBJ<IHOAGKINOHG> GLDJGMGHKEK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000349")]
		[Cpp2IlInjected.Address(RVA = "0x55401D0", Offset = "0x553F1D0", VA = "0x1855401D0", Slot = "103")]
		public virtual IEnumerable<LJHEBKBBECA> MAINAJBNDIJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600034A")]
		[Cpp2IlInjected.Address(RVA = "0x553DB20", Offset = "0x553CB20", VA = "0x18553DB20", Slot = "104")]
		public DFAHBLOKBPH<OKOMLKNINNF, CKBHMJGLAPL> FBNOBAIAEMG(string NHLKGOCGEKM)
		{
			return default(DFAHBLOKBPH<OKOMLKNINNF, CKBHMJGLAPL>);
		}

		[Cpp2IlInjected.Token(Token = "0x600034B")]
		[Cpp2IlInjected.Address(RVA = "0x553D900", Offset = "0x553C900", VA = "0x18553D900", Slot = "47")]
		public bool EIPHLHLEPJC([Out] Guid NBLGHAFFFJF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600034C")]
		[Cpp2IlInjected.Address(RVA = "0x553F460", Offset = "0x553E460", VA = "0x18553F460")]
		public bool KEMLBAMNEIP([In] Guid GFIFEILMJAD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600034D")]
		[Cpp2IlInjected.Address(RVA = "0x853950", Offset = "0x852950", VA = "0x180853950", Slot = "105")]
		public virtual void CLDDABPDPLI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600034E")]
		[Cpp2IlInjected.Address(RVA = "0x853950", Offset = "0x852950", VA = "0x180853950", Slot = "106")]
		public virtual void MKFCDMLDGDL(bool BJKPLBPHGAP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600034F")]
		[Cpp2IlInjected.Address(RVA = "0x853960", Offset = "0x852960", VA = "0x180853960", Slot = "107")]
		public virtual MKMFJANEALN FLDMAFKAOHC([In] OMEKJBJNFNL HLKIEHIKPOA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000354")]
		[Cpp2IlInjected.Address(RVA = "0x5540260", Offset = "0x553F260", VA = "0x185540260")]
		protected void MFLJDHHCGGI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000355")]
		[Cpp2IlInjected.Address(RVA = "0x553FA80", Offset = "0x553EA80", VA = "0x18553FA80", Slot = "112")]
		protected virtual bool LBIDOPNBACI(BGKDPCAKPBJ<IHOAGKINOHG> FCFGPBAFAPA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000356")]
		[Cpp2IlInjected.Address(RVA = "0x89A950", Offset = "0x899950", VA = "0x18089A950", Slot = "113")]
		protected virtual bool IKBKACIOKDH(BGKDPCAKPBJ<IHOAGKINOHG> FCFGPBAFAPA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000371")]
		[Cpp2IlInjected.Address(RVA = "0x853950", Offset = "0x852950", VA = "0x180853950", Slot = "120")]
		protected virtual void GHIPLIDCNEB(OHIGDFFLHJA CLEDMCKMNOK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000372")]
		[Cpp2IlInjected.Address(RVA = "0x55406A0", Offset = "0x553F6A0", VA = "0x1855406A0")]
		protected void NPDCOBDCINI(OHIGDFFLHJA NMEBKEGDNCC, Func<string> MLPNCBIAKDA, Action<string> DFLMLNIELDG, string AANEPGIOCCK, string JCMPNLDAMEI, string BBAHHIIANLF, LNEFHIMNJJG BBMFMHLPFHF, GEJIFILBGNI NKIABLHOCLE, Func<string, bool> OJCPDAAKJDJ, string DLOOFDIIGGK, Func<string, bool> EBNLJPCLNJF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000373")]
		[Cpp2IlInjected.Address(RVA = "0x553F180", Offset = "0x553E180", VA = "0x18553F180")]
		protected void KCAOOLNAMDD(OHIGDFFLHJA NMEBKEGDNCC, Func<string> MLPNCBIAKDA, Action<string> DFLMLNIELDG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000374")]
		[Cpp2IlInjected.Address(RVA = "0x553C670", Offset = "0x553B670", VA = "0x18553C670", Slot = "121")]
		protected virtual void BBPCMGMEEFK(OHIGDFFLHJA NMEBKEGDNCC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000375")]
		[Cpp2IlInjected.Address(RVA = "0x553F090", Offset = "0x553E090", VA = "0x18553F090", Slot = "80")]
		public void JPNHNMLJAAH(OHIGDFFLHJA NMEBKEGDNCC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000376")]
		[Cpp2IlInjected.Address(RVA = "0x553E700", Offset = "0x553D700", VA = "0x18553E700", Slot = "81")]
		public OHGCEAGLHOO ICBEPPKLLGA()
		{
			return default(OHGCEAGLHOO);
		}

		[Cpp2IlInjected.Token(Token = "0x6000379")]
		[Cpp2IlInjected.Address(RVA = "0x89A950", Offset = "0x899950", VA = "0x18089A950", Slot = "124")]
		public virtual bool NFBEILNBBGL(BGKDPCAKPBJ<IHOAGKINOHG> FCFGPBAFAPA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600037A")]
		[Cpp2IlInjected.Address(RVA = "0x14BD930", Offset = "0x14BC930", VA = "0x1814BD930")]
		private void JJMMCPGAJMM([In] DOAHODDKGGE LLLHNMGEKPM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037B")]
		[Cpp2IlInjected.Address(RVA = "0x553F7A0", Offset = "0x553E7A0", VA = "0x18553F7A0")]
		private void KKGIMFPPEHF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037C")]
		[Cpp2IlInjected.Address(RVA = "0x553E890", Offset = "0x553D890", VA = "0x18553E890")]
		private void IIHMPNDECAF(BGKDPCAKPBJ<IHOAGKINOHG> FCFGPBAFAPA, KDAKJINBHOH BEBLGLINBBD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037D")]
		[Cpp2IlInjected.Address(RVA = "0x97FBD0", Offset = "0x97EBD0", VA = "0x18097FBD0")]
		private void OBFOENGADCB(BGKDPCAKPBJ<IHOAGKINOHG> KHLDDJPHOBA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037E")]
		[Cpp2IlInjected.Address(RVA = "0x553EF50", Offset = "0x553DF50", VA = "0x18553EF50")]
		private void JONLLDPIGDI(BGKDPCAKPBJ<IHOAGKINOHG> KHLDDJPHOBA, KDAKJINBHOH DHPJGFDPDFG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037F")]
		[Cpp2IlInjected.Address(RVA = "0x553C810", Offset = "0x553B810", VA = "0x18553C810")]
		private void BOMDILHFAOK(BGKDPCAKPBJ<IHOAGKINOHG> PCLHMJBKBOE, BGKDPCAKPBJ<IHOAGKINOHG> GLDJGMGHKEK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000380")]
		[Cpp2IlInjected.Address(RVA = "0x9801E0", Offset = "0x97F1E0", VA = "0x1809801E0")]
		private void LBLCEAIFEAK(BGKDPCAKPBJ<IHOAGKINOHG> PCLHMJBKBOE, BGKDPCAKPBJ<IHOAGKINOHG> GLDJGMGHKEK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000381")]
		[Cpp2IlInjected.Address(RVA = "0x4EBCF70", Offset = "0x4EBBF70", VA = "0x184EBCF70")]
		private void FCKCCEKDELB(BGKDPCAKPBJ<IHOAGKINOHG> FCFGPBAFAPA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000382")]
		[Cpp2IlInjected.Address(RVA = "0x553DBA0", Offset = "0x553CBA0", VA = "0x18553DBA0")]
		private void FHCMHLDDGMH(BGKDPCAKPBJ<IHOAGKINOHG> FCFGPBAFAPA, KDAKJINBHOH BEBLGLINBBD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000383")]
		[Cpp2IlInjected.Address(RVA = "0x5540440", Offset = "0x553F440", VA = "0x185540440")]
		private void MMBFGILHCPC(BGKDPCAKPBJ<IHOAGKINOHG> FCFGPBAFAPA, KDAKJINBHOH DHPJGFDPDFG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000384")]
		[Cpp2IlInjected.Address(RVA = "0x553F8F0", Offset = "0x553E8F0", VA = "0x18553F8F0", Slot = "125")]
		[AsyncStateMachine(typeof(CNGEGLEMEMP<>.PICBEDJPBEA))]
		public Task<DFAHBLOKBPH<OKOMLKNINNF, CKBHMJGLAPL>> KMIAPAEOJJG(string NHLKGOCGEKM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000385")]
		[Cpp2IlInjected.Address(RVA = "0x553C340", Offset = "0x553B340", VA = "0x18553C340", Slot = "54")]
		private void ALOFMBOLMOE(object DGODJGFMOPC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000386")]
		[Cpp2IlInjected.Address(RVA = "0x553FA10", Offset = "0x553EA10", VA = "0x18553FA10", Slot = "55")]
		private void KMKPFOBBPHD(object DGODJGFMOPC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000387")]
		[Cpp2IlInjected.Address(RVA = "0x553E1F0", Offset = "0x553D1F0", VA = "0x18553E1F0", Slot = "29")]
		private bool GKMHPLNCGKO([In] DOAHODDKGGE JJCEIJMGOAB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000388")]
		[Cpp2IlInjected.Address(RVA = "0x553E1B0", Offset = "0x553D1B0", VA = "0x18553E1B0", Slot = "31")]
		private bool GGCEGHHBFMC([In] DLLFCGBFLBH JJCEIJMGOAB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000389")]
		[Cpp2IlInjected.Address(RVA = "0x55404B0", Offset = "0x553F4B0", VA = "0x1855404B0", Slot = "48")]
		private bool MNOHJHIPPKG([In] Guid GFIFEILMJAD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600038A")]
		[Cpp2IlInjected.Address(RVA = "0x4DC9060", Offset = "0x4DC8060", VA = "0x184DC9060")]
		[CompilerGenerated]
		private string OKCHOFMLDFF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600038B")]
		[Cpp2IlInjected.Address(RVA = "0x553E7F0", Offset = "0x553D7F0", VA = "0x18553E7F0")]
		[CompilerGenerated]
		private void IDNIOMLGHBL(string CKEJJGPNKGO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000091")]
	public sealed class PNGCDELDNCN : EIGFGILKFHJ<CEFNLANEOEF>
	{
		[Cpp2IlInjected.Token(Token = "0x17000079")]
		public override NodeVisualizationKey NAKCNJCFEHA
		{
			[Cpp2IlInjected.Token(Token = "0x600039D")]
			[Cpp2IlInjected.Address(RVA = "0xD181C0", Offset = "0xD171C0", VA = "0x180D181C0", Slot = "91")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600039E")]
		[Cpp2IlInjected.Address(RVA = "0x1FEC830", Offset = "0x1FEB830", VA = "0x181FEC830")]
		public PNGCDELDNCN(DLILHLIBGCM OPKEKBBFIHG, CEFNLANEOEF OHDOOCGHDGN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000092")]
	private sealed class GOGPJPDMOGO : AMPJOCEGNLH<ODBPFAGGKEM>
	{
		[Cpp2IlInjected.Token(Token = "0x1700007A")]
		public override NodeVisualizationKey NAKCNJCFEHA
		{
			[Cpp2IlInjected.Token(Token = "0x600039F")]
			[Cpp2IlInjected.Address(RVA = "0x9AF2F0", Offset = "0x9AE2F0", VA = "0x1809AF2F0", Slot = "91")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003A0")]
		[Cpp2IlInjected.Address(RVA = "0x1FDD330", Offset = "0x1FDC330", VA = "0x181FDD330")]
		public GOGPJPDMOGO(DLILHLIBGCM OPKEKBBFIHG, ODBPFAGGKEM OHDOOCGHDGN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A1")]
		[Cpp2IlInjected.Address(RVA = "0x853950", Offset = "0x852950", VA = "0x180853950", Slot = "120")]
		protected override void GHIPLIDCNEB(OHIGDFFLHJA NMEBKEGDNCC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000093")]
	public abstract class KIJMOGHLELH<T> : CNGEGLEMEMP<T> where T : notnull, JFMEMECDHCB
	{
		[Cpp2IlInjected.Token(Token = "0x2000094")]
		[CompilerGenerated]
		private sealed class LOLLOFIAJIP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001D2")]
			public IReadOnlyList<KeyValuePair<string, KDGMAMLGGIL>> clipOptions;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001D3")]
			public KIJMOGHLELH<T> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001D4")]
			public IReadOnlyDictionary<Guid, int> clipGuidToIndex;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001D5")]
			public IReadOnlyDictionary<int, Guid> clipIndexToGuid;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001D6")]
			public PCILEDIMGBH nodeAdapterDeps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001D7")]
			public DKMOPNEOHLH clipType;

			[Cpp2IlInjected.Token(Token = "0x60003A6")]
			[Cpp2IlInjected.Address(RVA = "0x85EB60", Offset = "0x85DB60", VA = "0x18085EB60")]
			public LOLLOFIAJIP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003A7")]
			[Cpp2IlInjected.Address(RVA = "0x8518C0", Offset = "0x8508C0", VA = "0x1808518C0")]
			internal IReadOnlyList<KeyValuePair<string, KDGMAMLGGIL>> NCGMJMFHGEA()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60003A8")]
			[Cpp2IlInjected.Address(RVA = "0x4312A80", Offset = "0x4311A80", VA = "0x184312A80")]
			internal int OIANKMMHODC()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60003A9")]
			[Cpp2IlInjected.Address(RVA = "0x43126C0", Offset = "0x43116C0", VA = "0x1843126C0")]
			internal void GNDADNGFDLE(int clipIndex)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003AA")]
			[Cpp2IlInjected.Address(RVA = "0x43123C0", Offset = "0x43113C0", VA = "0x1843123C0")]
			internal void ADBLKAGNGFP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003AB")]
			[Cpp2IlInjected.Address(RVA = "0x4312520", Offset = "0x4311520", VA = "0x184312520")]
			internal void DMNAKLFEOCK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003AC")]
			[Cpp2IlInjected.Address(RVA = "0x43129F0", Offset = "0x43119F0", VA = "0x1843129F0")]
			internal bool LFNPCGFBCGF()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60003AD")]
			[Cpp2IlInjected.Address(RVA = "0x43124D0", Offset = "0x43114D0", VA = "0x1843124D0")]
			internal void CNOGCEECIJC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003AE")]
			[Cpp2IlInjected.Address(RVA = "0x43129F0", Offset = "0x43119F0", VA = "0x1843129F0")]
			internal bool OALPLEHLNDH()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60003AF")]
			[Cpp2IlInjected.Address(RVA = "0x43128E0", Offset = "0x43118E0", VA = "0x1843128E0")]
			internal float HAJPJDODEHN()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x60003B0")]
			[Cpp2IlInjected.Address(RVA = "0x4312930", Offset = "0x4311930", VA = "0x184312930")]
			internal void HJJPONJCFNA(float value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003B1")]
			[Cpp2IlInjected.Address(RVA = "0x4312BD0", Offset = "0x4311BD0", VA = "0x184312BD0")]
			internal float PDJOAMHIGED()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x60003B2")]
			[Cpp2IlInjected.Address(RVA = "0x4312300", Offset = "0x4311300", VA = "0x184312300")]
			internal void ACJOGNOGIIG(float value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003B3")]
			[Cpp2IlInjected.Address(RVA = "0x4312670", Offset = "0x4311670", VA = "0x184312670")]
			internal float GDMOGBNJLMO()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x60003B4")]
			[Cpp2IlInjected.Address(RVA = "0x4312410", Offset = "0x4311410", VA = "0x184312410")]
			internal void BJCEBCMMADO(float value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007B")]
		public override NodeVisualizationKey NAKCNJCFEHA
		{
			[Cpp2IlInjected.Token(Token = "0x60003A3")]
			[Cpp2IlInjected.Address(RVA = "0x996090", Offset = "0x995090", VA = "0x180996090", Slot = "91")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007C")]
		public abstract DKMOPNEOHLH JODFAEOIPMC
		{
			[Cpp2IlInjected.Token(Token = "0x60003A4")]
			[Cpp2IlInjected.Address(Slot = "126")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x60003A2")]
		[Cpp2IlInjected.Address(RVA = "0x42419E0", Offset = "0x42409E0", VA = "0x1842419E0")]
		public KIJMOGHLELH(DLILHLIBGCM OPKEKBBFIHG, T OHDOOCGHDGN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A5")]
		[Cpp2IlInjected.Address(RVA = "0x4240E90", Offset = "0x423FE90", VA = "0x184240E90", Slot = "120")]
		protected sealed override void GHIPLIDCNEB(OHIGDFFLHJA NMEBKEGDNCC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000095")]
	private sealed class BEBFCDGPOEI : CNGEGLEMEMP<KIEPDHGHCPM>
	{
		[Cpp2IlInjected.Token(Token = "0x1700007D")]
		public override NodeVisualizationKey NAKCNJCFEHA
		{
			[Cpp2IlInjected.Token(Token = "0x60003B5")]
			[Cpp2IlInjected.Address(RVA = "0x9F7510", Offset = "0x9F6510", VA = "0x1809F7510", Slot = "91")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003B6")]
		[Cpp2IlInjected.Address(RVA = "0x1FD2E30", Offset = "0x1FD1E30", VA = "0x181FD2E30")]
		public BEBFCDGPOEI(DLILHLIBGCM OPKEKBBFIHG, KIEPDHGHCPM OHDOOCGHDGN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000096")]
	public sealed class CMMNJFBKNND : CNGEGLEMEMP<FOFCEDENMKN>
	{
		[Cpp2IlInjected.Token(Token = "0x2000097")]
		[CompilerGenerated]
		private sealed class BGMJBJFPHHN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40001D9")]
			public CMMNJFBKNND <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40001DA")]
			public PCILEDIMGBH nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x60003B9")]
			[Cpp2IlInjected.Address(RVA = "0x85EB60", Offset = "0x85DB60", VA = "0x18085EB60")]
			public BGMJBJFPHHN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003BA")]
			[Cpp2IlInjected.Address(RVA = "0x1FD3360", Offset = "0x1FD2360", VA = "0x181FD3360")]
			internal int OIANKMMHODC()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60003BB")]
			[Cpp2IlInjected.Address(RVA = "0x1FD32D0", Offset = "0x1FD22D0", VA = "0x181FD32D0")]
			internal void GNDADNGFDLE(int value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40001D8")]
		private static Dictionary<string, KDGMAMLGGIL>? HEAPFAOMEIP;

		[Cpp2IlInjected.Token(Token = "0x60003B7")]
		[Cpp2IlInjected.Address(RVA = "0x1FDAA20", Offset = "0x1FD9A20", VA = "0x181FDAA20")]
		public CMMNJFBKNND(DLILHLIBGCM OPKEKBBFIHG, FOFCEDENMKN OHDOOCGHDGN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B8")]
		[Cpp2IlInjected.Address(RVA = "0x1FDA6A0", Offset = "0x1FD96A0", VA = "0x181FDA6A0", Slot = "120")]
		protected override void GHIPLIDCNEB(OHIGDFFLHJA NMEBKEGDNCC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000099")]
	public sealed class NMEKCOHLBHL : KIJMOGHLELH<ANPOLJHIINF>
	{
		[Cpp2IlInjected.Token(Token = "0x1700007E")]
		public override DKMOPNEOHLH JODFAEOIPMC
		{
			[Cpp2IlInjected.Token(Token = "0x60003C0")]
			[Cpp2IlInjected.Address(RVA = "0x853960", Offset = "0x852960", VA = "0x180853960", Slot = "126")]
			get
			{
				return default(DKMOPNEOHLH);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003BF")]
		[Cpp2IlInjected.Address(RVA = "0x1FE6490", Offset = "0x1FE5490", VA = "0x181FE6490")]
		public NMEKCOHLBHL(DLILHLIBGCM OPKEKBBFIHG, ANPOLJHIINF OEFGKJLECGH)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200009A")]
	private sealed class GPBEIKIPJCM : AMPJOCEGNLH<FPLEMAIFGIL>
	{
		[Cpp2IlInjected.Token(Token = "0x1700007F")]
		public override NodeVisualizationKey NAKCNJCFEHA
		{
			[Cpp2IlInjected.Token(Token = "0x60003C1")]
			[Cpp2IlInjected.Address(RVA = "0x9AF2F0", Offset = "0x9AE2F0", VA = "0x1809AF2F0", Slot = "91")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003C2")]
		[Cpp2IlInjected.Address(RVA = "0x1FDD400", Offset = "0x1FDC400", VA = "0x181FDD400")]
		public GPBEIKIPJCM(DLILHLIBGCM OPKEKBBFIHG, FPLEMAIFGIL OHDOOCGHDGN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C3")]
		[Cpp2IlInjected.Address(RVA = "0x853950", Offset = "0x852950", VA = "0x180853950", Slot = "120")]
		protected override void GHIPLIDCNEB(OHIGDFFLHJA NMEBKEGDNCC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200009B")]
	private sealed class FHEHGOFDLLL : AMPJOCEGNLH<OHEACFGELFC>
	{
		[Cpp2IlInjected.Token(Token = "0x17000080")]
		public override NodeVisualizationKey NAKCNJCFEHA
		{
			[Cpp2IlInjected.Token(Token = "0x60003C4")]
			[Cpp2IlInjected.Address(RVA = "0x9AF2F0", Offset = "0x9AE2F0", VA = "0x1809AF2F0", Slot = "91")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003C5")]
		[Cpp2IlInjected.Address(RVA = "0x1FDC420", Offset = "0x1FDB420", VA = "0x181FDC420")]
		public FHEHGOFDLLL(DLILHLIBGCM OPKEKBBFIHG, OHEACFGELFC OHDOOCGHDGN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C6")]
		[Cpp2IlInjected.Address(RVA = "0x853950", Offset = "0x852950", VA = "0x180853950", Slot = "120")]
		protected override void GHIPLIDCNEB(OHIGDFFLHJA NMEBKEGDNCC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200009C")]
	public sealed class JGKAANMAAFB : AGBOAEKDJHB<IEEPMGEAHNK>
	{
		[Cpp2IlInjected.Token(Token = "0x200009D")]
		[CompilerGenerated]
		private sealed class LJKMDJDPBLJ
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
				public LJKMDJDPBLJ <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x40001E2")]
				public string value;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x40001E3")]
				private TaskAwaiter<bool> <>u__1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
				[Cpp2IlInjected.Token(Token = "0x40001E4")]
				private TaskAwaiter<DFAHBLOKBPH<OKOMLKNINNF, CKBHMJGLAPL>> <>u__2;

				[Cpp2IlInjected.Token(Token = "0x60003CB")]
				[Cpp2IlInjected.Address(RVA = "0x1FEC890", Offset = "0x1FEB890", VA = "0x181FEC890", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60003CC")]
				[Cpp2IlInjected.Address(RVA = "0xA6A710", Offset = "0xA69710", VA = "0x180A6A710", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40001DD")]
			public PCILEDIMGBH nodeAdapterDeps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40001DE")]
			public JGKAANMAAFB <>4__this;

			[Cpp2IlInjected.Token(Token = "0x60003C9")]
			[Cpp2IlInjected.Address(RVA = "0x85EB60", Offset = "0x85DB60", VA = "0x18085EB60")]
			public LJKMDJDPBLJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003CA")]
			[Cpp2IlInjected.Address(RVA = "0x1FE41F0", Offset = "0x1FE31F0", VA = "0x181FE41F0")]
			[AsyncStateMachine(typeof(<<AddHomeValueSetting>b__0>d))]
			internal void JGOHNCMNEGF(string value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003C7")]
		[Cpp2IlInjected.Address(RVA = "0x1FDF060", Offset = "0x1FDE060", VA = "0x181FDF060")]
		public JGKAANMAAFB(DLILHLIBGCM OPKEKBBFIHG, IEEPMGEAHNK OEFGKJLECGH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C8")]
		[Cpp2IlInjected.Address(RVA = "0x1FDED80", Offset = "0x1FDDD80", VA = "0x181FDED80", Slot = "126")]
		protected override void LABKBIBMBCF(OHIGDFFLHJA NMEBKEGDNCC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200009F")]
	public sealed class JIHCECDEAOM : KIJMOGHLELH<NCGIPHHDNHM>
	{
		[Cpp2IlInjected.Token(Token = "0x17000081")]
		public override DKMOPNEOHLH JODFAEOIPMC
		{
			[Cpp2IlInjected.Token(Token = "0x60003CE")]
			[Cpp2IlInjected.Address(RVA = "0x9AA090", Offset = "0x9A9090", VA = "0x1809AA090", Slot = "126")]
			get
			{
				return default(DKMOPNEOHLH);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003CD")]
		[Cpp2IlInjected.Address(RVA = "0x1FDF3E0", Offset = "0x1FDE3E0", VA = "0x181FDF3E0")]
		public JIHCECDEAOM(DLILHLIBGCM OPKEKBBFIHG, NCGIPHHDNHM OEFGKJLECGH)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A0")]
	private sealed class BEMPLAOPJKB : CNGEGLEMEMP<LMPKMADMBAF>
	{
		[Cpp2IlInjected.Token(Token = "0x17000082")]
		public override NodeVisualizationKey NAKCNJCFEHA
		{
			[Cpp2IlInjected.Token(Token = "0x60003CF")]
			[Cpp2IlInjected.Address(RVA = "0x9F06D0", Offset = "0x9EF6D0", VA = "0x1809F06D0", Slot = "91")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003D0")]
		[Cpp2IlInjected.Address(RVA = "0x1FD3260", Offset = "0x1FD2260", VA = "0x181FD3260")]
		public BEMPLAOPJKB(DLILHLIBGCM OPKEKBBFIHG, LMPKMADMBAF OHDOOCGHDGN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D1")]
		[Cpp2IlInjected.Address(RVA = "0x853950", Offset = "0x852950", VA = "0x180853950", Slot = "120")]
		protected override void GHIPLIDCNEB(OHIGDFFLHJA NMEBKEGDNCC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A1")]
	public sealed class KNIAMGPAMAN : CNGEGLEMEMP<NMMPKOKIGDF>
	{
		[Cpp2IlInjected.Token(Token = "0x17000083")]
		public sealed override NodeVisualizationKey NAKCNJCFEHA
		{
			[Cpp2IlInjected.Token(Token = "0x60003D2")]
			[Cpp2IlInjected.Address(RVA = "0x853960", Offset = "0x852960", VA = "0x180853960", Slot = "91")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000084")]
		public sealed override bool AJINHILPFLH
		{
			[Cpp2IlInjected.Token(Token = "0x60003D3")]
			[Cpp2IlInjected.Address(RVA = "0x86C5D0", Offset = "0x86B5D0", VA = "0x18086C5D0", Slot = "92")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000085")]
		protected sealed override bool INMILKLEPML
		{
			[Cpp2IlInjected.Token(Token = "0x60003D4")]
			[Cpp2IlInjected.Address(RVA = "0x86C5D0", Offset = "0x86B5D0", VA = "0x18086C5D0", Slot = "90")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003D5")]
		[Cpp2IlInjected.Address(RVA = "0x1FE2B00", Offset = "0x1FE1B00", VA = "0x181FE2B00")]
		public KNIAMGPAMAN(DLILHLIBGCM OPKEKBBFIHG, NMMPKOKIGDF OHDOOCGHDGN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D6")]
		[Cpp2IlInjected.Address(RVA = "0x1FE2730", Offset = "0x1FE1730", VA = "0x181FE2730", Slot = "120")]
		protected override void GHIPLIDCNEB(OHIGDFFLHJA NMEBKEGDNCC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D7")]
		[Cpp2IlInjected.Address(RVA = "0x1FE2A60", Offset = "0x1FE1A60", VA = "0x181FE2A60")]
		private int JHGEJDMDMIL()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60003D8")]
		[Cpp2IlInjected.Address(RVA = "0x1FE2AA0", Offset = "0x1FE1AA0", VA = "0x181FE2AA0")]
		private void OAKELEPBGAC(int EIIABACMOFJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A2")]
	public class PHPHICACGEI : GOIJLODPFMF
	{
		[Cpp2IlInjected.Token(Token = "0x60003D9")]
		[Cpp2IlInjected.Address(RVA = "0x1FDD390", Offset = "0x1FDC390", VA = "0x181FDD390")]
		public PHPHICACGEI(DLILHLIBGCM OPKEKBBFIHG, EMGONNJLBBJ OHDOOCGHDGN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003DA")]
		[Cpp2IlInjected.Address(RVA = "0x853950", Offset = "0x852950", VA = "0x180853950", Slot = "120")]
		protected override void GHIPLIDCNEB(OHIGDFFLHJA NMEBKEGDNCC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A3")]
	public sealed class KNADHBCGBBK : AGBOAEKDJHB<DPHELKNBJAP>
	{
		[Cpp2IlInjected.Token(Token = "0x60003DB")]
		[Cpp2IlInjected.Address(RVA = "0x1FE26D0", Offset = "0x1FE16D0", VA = "0x181FE26D0")]
		public KNADHBCGBBK(DLILHLIBGCM OPKEKBBFIHG, DPHELKNBJAP OHDOOCGHDGN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A4")]
	public abstract class AGBOAEKDJHB<TVariableNode> : CNGEGLEMEMP<TVariableNode> where TVariableNode : notnull, DPHELKNBJAP
	{
		[Cpp2IlInjected.Token(Token = "0x20000A5")]
		[CompilerGenerated]
		private sealed class PEKACDDEGLO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001E5")]
			public AGBOAEKDJHB<TVariableNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001E6")]
			public PCILEDIMGBH nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x60003E3")]
			[Cpp2IlInjected.Address(RVA = "0x85EB60", Offset = "0x85DB60", VA = "0x18085EB60")]
			public PEKACDDEGLO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003E4")]
			[Cpp2IlInjected.Address(RVA = "0x47A2FB0", Offset = "0x47A1FB0", VA = "0x1847A2FB0")]
			internal bool NCGMJMFHGEA()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60003E5")]
			[Cpp2IlInjected.Address(RVA = "0x47A3000", Offset = "0x47A2000", VA = "0x1847A3000")]
			internal void OIANKMMHODC(bool v)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003E6")]
			[Cpp2IlInjected.Address(RVA = "0x47A2F60", Offset = "0x47A1F60", VA = "0x1847A2F60")]
			internal bool GNDADNGFDLE()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60003E7")]
			[Cpp2IlInjected.Address(RVA = "0x47A2DF0", Offset = "0x47A1DF0", VA = "0x1847A2DF0")]
			internal void ADBLKAGNGFP(bool v)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003E8")]
			[Cpp2IlInjected.Address(RVA = "0x47A2EB0", Offset = "0x47A1EB0", VA = "0x1847A2EB0")]
			internal bool DMNAKLFEOCK()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000A6")]
		[CompilerGenerated]
		private sealed class DGBCCGFIBHK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001E7")]
			public PCILEDIMGBH nodeAdapterDeps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001E8")]
			public AGBOAEKDJHB<TVariableNode> <>4__this;

			[Cpp2IlInjected.Token(Token = "0x60003E9")]
			[Cpp2IlInjected.Address(RVA = "0x85EB60", Offset = "0x85DB60", VA = "0x18085EB60")]
			public DGBCCGFIBHK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003EA")]
			[Cpp2IlInjected.Address(RVA = "0x58342E0", Offset = "0x58332E0", VA = "0x1858342E0")]
			internal void JGOHNCMNEGF(string v)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000086")]
		public override NodeVisualizationKey NAKCNJCFEHA
		{
			[Cpp2IlInjected.Token(Token = "0x60003DC")]
			[Cpp2IlInjected.Address(RVA = "0xB69810", Offset = "0xB68810", VA = "0x180B69810", Slot = "91")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000087")]
		public override LNNDEAMLFKK LGLNDOOCKBH
		{
			[Cpp2IlInjected.Token(Token = "0x60003DD")]
			[Cpp2IlInjected.Address(RVA = "0x3D06000", Offset = "0x3D05000", VA = "0x183D06000", Slot = "94")]
			get
			{
				return default(LNNDEAMLFKK);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003DE")]
		[Cpp2IlInjected.Address(RVA = "0x3D05E70", Offset = "0x3D04E70", VA = "0x183D05E70")]
		protected AGBOAEKDJHB(DLILHLIBGCM OPKEKBBFIHG, TVariableNode OHDOOCGHDGN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003DF")]
		[Cpp2IlInjected.Address(RVA = "0x3D054F0", Offset = "0x3D044F0", VA = "0x183D054F0", Slot = "88")]
		public override void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E0")]
		[Cpp2IlInjected.Address(RVA = "0x3D05670", Offset = "0x3D04670", VA = "0x183D05670", Slot = "120")]
		protected override void GHIPLIDCNEB(OHIGDFFLHJA NMEBKEGDNCC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E1")]
		[Cpp2IlInjected.Address(RVA = "0x3D05AF0", Offset = "0x3D04AF0", VA = "0x183D05AF0", Slot = "126")]
		protected virtual void LABKBIBMBCF(OHIGDFFLHJA NMEBKEGDNCC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E2")]
		[Cpp2IlInjected.Address(RVA = "0x3D05400", Offset = "0x3D04400", VA = "0x183D05400", Slot = "105")]
		public override void CLDDABPDPLI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x1FC3EC0", Offset = "0x1FC2EC0", VA = "0x181FC3EC0")]
	public static BHHANIGFAMG GAKCNKPJGEK(DLILHLIBGCM OPKEKBBFIHG, EMGONNJLBBJ OHDOOCGHDGN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A7")]
public sealed class AAMDLLJOGPJ : LDEHOBIEPBO, BKHHEMNGJNC, FDIFHNPIPOF, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000088")]
	public BGKDPCAKPBJ<LMEADFHGDCP> HLGAJPGBNDN
	{
		[Cpp2IlInjected.Token(Token = "0x60003EB")]
		[Cpp2IlInjected.Address(RVA = "0xB3DDE0", Offset = "0xB3CDE0", VA = "0x180B3DDE0", Slot = "24")]
		[CompilerGenerated]
		get
		{
			return default(BGKDPCAKPBJ<LMEADFHGDCP>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000089")]
	public BGKDPCAKPBJ<KMABMDHMDOF> OCBMMAOKGNC
	{
		[Cpp2IlInjected.Token(Token = "0x60003EC")]
		[Cpp2IlInjected.Address(RVA = "0xFCE960", Offset = "0xFCD960", VA = "0x180FCE960", Slot = "25")]
		[CompilerGenerated]
		get
		{
			return default(BGKDPCAKPBJ<KMABMDHMDOF>);
		}
		[Cpp2IlInjected.Token(Token = "0x60003ED")]
		[Cpp2IlInjected.Address(RVA = "0x1FD1E10", Offset = "0x1FD0E10", VA = "0x181FD1E10")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008A")]
	private BGKDPCAKPBJ<MBMIEFKCJNG> MLHKCKPOIKE
	{
		[Cpp2IlInjected.Token(Token = "0x60003EE")]
		[Cpp2IlInjected.Address(RVA = "0xBCD8C0", Offset = "0xBCC8C0", VA = "0x180BCD8C0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008B")]
	public override BGKDPCAKPBJ<GBACLKKDIKL> EAPPAGNBMDM
	{
		[Cpp2IlInjected.Token(Token = "0x60003EF")]
		[Cpp2IlInjected.Address(RVA = "0x1FD1DC0", Offset = "0x1FD0DC0", VA = "0x181FD1DC0", Slot = "20")]
		get
		{
			return default(BGKDPCAKPBJ<GBACLKKDIKL>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003F0")]
	[Cpp2IlInjected.Address(RVA = "0x1FD2170", Offset = "0x1FD1170", VA = "0x181FD2170")]
	private AAMDLLJOGPJ(DLILHLIBGCM OPKEKBBFIHG, EMGONNJLBBJ OHDOOCGHDGN, GOEJKOMPEKH LEGJLLOEFEA, BGKDPCAKPBJ<IHOAGKINOHG> FCFGPBAFAPA, BGKDPCAKPBJ<KMABMDHMDOF> GPBEODKKKPJ, BGKDPCAKPBJ<MBMIEFKCJNG> NCOFEOALOGH, bool IOKKBNCNMLC, string CKEJJGPNKGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F1")]
	[Cpp2IlInjected.Address(RVA = "0x1FD1E20", Offset = "0x1FD0E20", VA = "0x181FD1E20")]
	public static AAMDLLJOGPJ GAKCNKPJGEK(DLILHLIBGCM OPKEKBBFIHG, EMGONNJLBBJ OHDOOCGHDGN, GOEJKOMPEKH CKLHFLIDCEO, BGKDPCAKPBJ<IHOAGKINOHG> FCFGPBAFAPA, BGKDPCAKPBJ<MBMIEFKCJNG> NCOFEOALOGH, BGKDPCAKPBJ<KMABMDHMDOF> GPBEODKKKPJ, bool IOKKBNCNMLC, bool HBPNKNHGJMP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F2")]
	[Cpp2IlInjected.Address(RVA = "0x1FD1E10", Offset = "0x1FD0E10", VA = "0x181FD1E10")]
	internal void DJIDECLPDEF(BGKDPCAKPBJ<KMABMDHMDOF> JJCEIJMGOAB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A8")]
public abstract class LDEHOBIEPBO : FDIFHNPIPOF, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000A9")]
	private struct IDGLLFCHDHI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001F5")]
		private NHMECIJIBNC? EAOEJEOHEPA;

		[Cpp2IlInjected.Token(Token = "0x6000410")]
		[Cpp2IlInjected.Address(RVA = "0x1FDD9B0", Offset = "0x1FDC9B0", VA = "0x181FDD9B0")]
		public void PKAGCAPLLKG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000411")]
		[Cpp2IlInjected.Address(RVA = "0x1FDD910", Offset = "0x1FDC910", VA = "0x181FDD910")]
		public NHMECIJIBNC HAOEAPLJFJH(LDEHOBIEPBO GNEPPCKINCG)
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001EC")]
	protected readonly DLILHLIBGCM CPJCBIFJBNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001ED")]
	protected readonly EMGONNJLBBJ FIBDEFKFLJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001EE")]
	private IDGLLFCHDHI GOHLHBHIPIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001EF")]
	private readonly HFHHDHFDBPL KOEGCLFLDDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001F0")]
	private readonly List<HFIIGBBAAIG> CJMGHJLIDJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40001F1")]
	private readonly List<ECCOPGPDNPK> NHJDNFBIAHH;

	[Cpp2IlInjected.Token(Token = "0x1700008C")]
	[KLDKOFJPICD("To be deprecated with NodeConnection")]
	public IEnumerable<StaticEdge> CAOIOHPMEOL
	{
		[Cpp2IlInjected.Token(Token = "0x60003F3")]
		[Cpp2IlInjected.Address(RVA = "0x1FE3E80", Offset = "0x1FE2E80", VA = "0x181FE3E80", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008D")]
	public DisplayKind CJKDKCIFALD
	{
		[Cpp2IlInjected.Token(Token = "0x60003F4")]
		[Cpp2IlInjected.Address(RVA = "0x861470", Offset = "0x860470", VA = "0x180861470", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(DisplayKind);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008E")]
	public BGKDPCAKPBJ<EHIJHEMDKLF> NGMAJELLEMM
	{
		[Cpp2IlInjected.Token(Token = "0x60003F5")]
		[Cpp2IlInjected.Address(RVA = "0x1FE4060", Offset = "0x1FE3060", VA = "0x181FE4060", Slot = "6")]
		get
		{
			return default(BGKDPCAKPBJ<EHIJHEMDKLF>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008F")]
	public MFLENLEMIJF<EHIJHEMDKLF> EBCJHIBBHLN
	{
		[Cpp2IlInjected.Token(Token = "0x60003F6")]
		[Cpp2IlInjected.Address(RVA = "0x1FE4030", Offset = "0x1FE3030", VA = "0x181FE4030", Slot = "7")]
		get
		{
			return default(MFLENLEMIJF<EHIJHEMDKLF>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000090")]
	public PPILJEFFHKO PEMPBELBNOP
	{
		[Cpp2IlInjected.Token(Token = "0x60003F7")]
		[Cpp2IlInjected.Address(RVA = "0x1CE3F00", Offset = "0x1CE2F00", VA = "0x181CE3F00")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000091")]
	public IAEEJDHFOGP CGHEKJANJDH
	{
		[Cpp2IlInjected.Token(Token = "0x60003F8")]
		[Cpp2IlInjected.Address(RVA = "0x1FE3020", Offset = "0x1FE2020", VA = "0x181FE3020", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000092")]
	protected NHMECIJIBNC KPFHECNBPNM
	{
		[Cpp2IlInjected.Token(Token = "0x60003F9")]
		[Cpp2IlInjected.Address(RVA = "0x1FE3020", Offset = "0x1FE2020", VA = "0x181FE3020")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000093")]
	public PortImage NGLHDGIGIAH
	{
		[Cpp2IlInjected.Token(Token = "0x60003FA")]
		[Cpp2IlInjected.Address(RVA = "0x1FE2EF0", Offset = "0x1FE1EF0", VA = "0x181FE2EF0", Slot = "13")]
		get
		{
			return default(PortImage);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000094")]
	public string NPDJPDJBDCA
	{
		[Cpp2IlInjected.Token(Token = "0x60003FB")]
		[Cpp2IlInjected.Address(RVA = "0x8517F0", Offset = "0x8507F0", VA = "0x1808517F0", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60003FC")]
		[Cpp2IlInjected.Address(RVA = "0x851820", Offset = "0x850820", VA = "0x180851820")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000095")]
	public MFLENLEMIJF<PMIFAKHBGDE> BOFDPMBCPAD
	{
		[Cpp2IlInjected.Token(Token = "0x60003FD")]
		[Cpp2IlInjected.Address(RVA = "0x1FE3CB0", Offset = "0x1FE2CB0", VA = "0x181FE3CB0", Slot = "9")]
		get
		{
			return default(MFLENLEMIJF<PMIFAKHBGDE>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000096")]
	public BGKDPCAKPBJ<IHOAGKINOHG> ALALEMMLKHC
	{
		[Cpp2IlInjected.Token(Token = "0x60003FE")]
		[Cpp2IlInjected.Address(RVA = "0xA9ECF0", Offset = "0xA9DCF0", VA = "0x180A9ECF0", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return default(BGKDPCAKPBJ<IHOAGKINOHG>);
		}
		[Cpp2IlInjected.Token(Token = "0x60003FF")]
		[Cpp2IlInjected.Address(RVA = "0xF680B0", Offset = "0xF670B0", VA = "0x180F680B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000097")]
	public abstract BGKDPCAKPBJ<GBACLKKDIKL> EAPPAGNBMDM
	{
		[Cpp2IlInjected.Token(Token = "0x6000400")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000401")]
	[Cpp2IlInjected.Address(RVA = "0x1FE4090", Offset = "0x1FE3090", VA = "0x181FE4090")]
	protected LDEHOBIEPBO(DLILHLIBGCM OPKEKBBFIHG, EMGONNJLBBJ OHDOOCGHDGN, HFHHDHFDBPL APLBJFAIJKB, BGKDPCAKPBJ<IHOAGKINOHG> FCFGPBAFAPA, bool IOKKBNCNMLC, string CKEJJGPNKGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000402")]
	[Cpp2IlInjected.Address(RVA = "0x1FE3D30", Offset = "0x1FE2D30", VA = "0x181FE3D30", Slot = "21")]
	protected virtual void LFNNOPDGNGK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000403")]
	[Cpp2IlInjected.Address(RVA = "0x1FE3740", Offset = "0x1FE2740", VA = "0x181FE3740", Slot = "22")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000404")]
	[Cpp2IlInjected.Address(RVA = "0x1FE3C50", Offset = "0x1FE2C50", VA = "0x181FE3C50", Slot = "14")]
	public void HOPBHDGELGD(HFIIGBBAAIG AMEOOEAAAOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000405")]
	[Cpp2IlInjected.Address(RVA = "0x1FE3CD0", Offset = "0x1FE2CD0", VA = "0x181FE3CD0", Slot = "15")]
	public void IODAALEMHLE(ECCOPGPDNPK AMEOOEAAAOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000406")]
	[Cpp2IlInjected.Address(RVA = "0x1FE30C0", Offset = "0x1FE20C0", VA = "0x181FE30C0", Slot = "16")]
	public void DMEKDKLAGGK(FKDGIBAGNOJ AELMEPLFHIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000407")]
	[Cpp2IlInjected.Address(RVA = "0x1FE3A40", Offset = "0x1FE2A40", VA = "0x181FE3A40", Slot = "23")]
	protected virtual void FJHGBBGONPO(FKDGIBAGNOJ AELMEPLFHIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000408")]
	[Cpp2IlInjected.Address(RVA = "0x1FE3AA0", Offset = "0x1FE2AA0", VA = "0x181FE3AA0")]
	private void FJKGCHKCJEI(bool PGMBMLICCAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000409")]
	[Cpp2IlInjected.Address(RVA = "0x1FE2D40", Offset = "0x1FE1D40", VA = "0x181FE2D40")]
	private void BNNNPKHHJCN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040A")]
	[Cpp2IlInjected.Address(RVA = "0x1FE3890", Offset = "0x1FE2890", VA = "0x181FE3890")]
	private void EHFDMCMBNMF([In] BIIFICHMALK GKIODBLPKMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040B")]
	[Cpp2IlInjected.Address(RVA = "0x1FE3FD0", Offset = "0x1FE2FD0", VA = "0x181FE3FD0", Slot = "17")]
	public void MIECIOFBBMB(HFIIGBBAAIG AMEOOEAAAOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040C")]
	[Cpp2IlInjected.Address(RVA = "0x1FE2CE0", Offset = "0x1FE1CE0", VA = "0x181FE2CE0", Slot = "18")]
	public void AALHJICKLFO(ECCOPGPDNPK AMEOOEAAAOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040D")]
	[Cpp2IlInjected.Address(RVA = "0x851820", Offset = "0x850820", VA = "0x180851820")]
	internal void LEHONNAEPEC(string CKEJJGPNKGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040E")]
	[Cpp2IlInjected.Address(RVA = "0x1FE3C30", Offset = "0x1FE2C30", VA = "0x181FE3C30")]
	internal void GKJBKKLGKDE(CHEDDAFAOPO HPGJLJLFPIH, PPILJEFFHKO HNGLFCFOHLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040F")]
	[Cpp2IlInjected.Address(RVA = "0xF680B0", Offset = "0xF670B0", VA = "0x180F680B0")]
	internal void CJMOCOIOAIP(BGKDPCAKPBJ<IHOAGKINOHG> FCFGPBAFAPA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AB")]
public sealed class BNIFOFOKPDE : MOFLLCAHOFM, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000AC")]
	[CompilerGenerated]
	private sealed class MCEFNFFGFFI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000215")]
		public DLILHLIBGCM circuitsManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000216")]
		public EMGONNJLBBJ node;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000217")]
		public BGKDPCAKPBJ<IHOAGKINOHG> portGroupId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000218")]
		public bool canInteract;

		[Cpp2IlInjected.FieldOffset(Offset = "0x25")]
		[Cpp2IlInjected.Token(Token = "0x4000219")]
		public bool ignoreChipConfigPortNames;

		[Cpp2IlInjected.Token(Token = "0x600045C")]
		[Cpp2IlInjected.Address(RVA = "0x85EB60", Offset = "0x85DB60", VA = "0x18085EB60")]
		public MCEFNFFGFFI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600045D")]
		[Cpp2IlInjected.Address(RVA = "0x1FE48A0", Offset = "0x1FE38A0", VA = "0x181FE48A0")]
		internal GMKLOJNABAC IPBADBJGLBM((int PortDescIndex, int PortIndex, AOJKPNALAMB InputPort) i)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600045E")]
		[Cpp2IlInjected.Address(RVA = "0x1FE4810", Offset = "0x1FE3810", VA = "0x181FE4810")]
		internal AAMDLLJOGPJ BHLBANIPLMG(GOEJKOMPEKH i, int idx)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000AD")]
	[CompilerGenerated]
	private struct AJNOBIENMON : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400021A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400021B")]
		public AsyncTaskMethodBuilder<DFAHBLOKBPH<OKOMLKNINNF, CKBHMJGLAPL>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400021C")]
		public BNIFOFOKPDE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400021D")]
		private DPLHFMKJDOO <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400021E")]
		private TaskAwaiter<DFAHBLOKBPH<OKOMLKNINNF, CKBHMJGLAPL>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600045F")]
		[Cpp2IlInjected.Address(RVA = "0x1FD2460", Offset = "0x1FD1460", VA = "0x181FD2460", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000460")]
		[Cpp2IlInjected.Address(RVA = "0x1FD28C0", Offset = "0x1FD18C0", VA = "0x181FD28C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000AF")]
	[CompilerGenerated]
	private struct BELJBOKMBPP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000221")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000222")]
		public AsyncTaskMethodBuilder<DFAHBLOKBPH<OKOMLKNINNF, CKBHMJGLAPL>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000223")]
		public BNIFOFOKPDE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000224")]
		public BGKDPCAKPBJ<HFFNHINIHLD> inputDefId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000225")]
		private DPLHFMKJDOO <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000226")]
		private TaskAwaiter<DFAHBLOKBPH<OKOMLKNINNF, CKBHMJGLAPL>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000464")]
		[Cpp2IlInjected.Address(RVA = "0x1FD2EA0", Offset = "0x1FD1EA0", VA = "0x181FD2EA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000465")]
		[Cpp2IlInjected.Address(RVA = "0x1FD31F0", Offset = "0x1FD21F0", VA = "0x181FD31F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B0")]
	[CompilerGenerated]
	private struct MGGFBCLGFCF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000227")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000228")]
		public AsyncTaskMethodBuilder<DFAHBLOKBPH<OKOMLKNINNF, CKBHMJGLAPL>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000229")]
		public BNIFOFOKPDE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400022A")]
		public BGKDPCAKPBJ<MBMIEFKCJNG> outputDefId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400022B")]
		private DPLHFMKJDOO <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400022C")]
		private TaskAwaiter<DFAHBLOKBPH<OKOMLKNINNF, CKBHMJGLAPL>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000466")]
		[Cpp2IlInjected.Address(RVA = "0x1FE4930", Offset = "0x1FE3930", VA = "0x181FE4930", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000467")]
		[Cpp2IlInjected.Address(RVA = "0x1FE4C80", Offset = "0x1FE3C80", VA = "0x181FE4C80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B1")]
	[CompilerGenerated]
	private struct NHACKCADHPE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400022D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400022E")]
		public AsyncTaskMethodBuilder<DFAHBLOKBPH<OKOMLKNINNF, CKBHMJGLAPL>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400022F")]
		public BNIFOFOKPDE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000230")]
		public BGKDPCAKPBJ<HFFNHINIHLD> inputDefId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000231")]
		public BGKDPCAKPBJ<HFFNHINIHLD> targetIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000232")]
		private DPLHFMKJDOO <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000233")]
		private TaskAwaiter<DFAHBLOKBPH<OKOMLKNINNF, CKBHMJGLAPL>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000468")]
		[Cpp2IlInjected.Address(RVA = "0x1FE5290", Offset = "0x1FE4290", VA = "0x181FE5290", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000469")]
		[Cpp2IlInjected.Address(RVA = "0x1FE55E0", Offset = "0x1FE45E0", VA = "0x181FE55E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B2")]
	[CompilerGenerated]
	private struct FCILOGMGBFP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000234")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000235")]
		public AsyncTaskMethodBuilder<DFAHBLOKBPH<OKOMLKNINNF, CKBHMJGLAPL>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000236")]
		public BNIFOFOKPDE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000237")]
		public BGKDPCAKPBJ<MBMIEFKCJNG> outputDefId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000238")]
		public BGKDPCAKPBJ<MBMIEFKCJNG> targetIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000239")]
		private DPLHFMKJDOO <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400023A")]
		private TaskAwaiter<DFAHBLOKBPH<OKOMLKNINNF, CKBHMJGLAPL>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600046A")]
		[Cpp2IlInjected.Address(RVA = "0x1FDC040", Offset = "0x1FDB040", VA = "0x181FDC040", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600046B")]
		[Cpp2IlInjected.Address(RVA = "0x1FDC390", Offset = "0x1FDB390", VA = "0x181FDC390", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B3")]
	[CompilerGenerated]
	private struct IJFBMEFMANH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400023B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400023C")]
		public AsyncTaskMethodBuilder<DFAHBLOKBPH<OKOMLKNINNF, CKBHMJGLAPL>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400023D")]
		public BNIFOFOKPDE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400023E")]
		private DPLHFMKJDOO <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400023F")]
		private TaskAwaiter<DFAHBLOKBPH<OKOMLKNINNF, CKBHMJGLAPL>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600046C")]
		[Cpp2IlInjected.Address(RVA = "0x1FDDD80", Offset = "0x1FDCD80", VA = "0x181FDDD80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600046D")]
		[Cpp2IlInjected.Address(RVA = "0x1FDE1F0", Offset = "0x1FDD1F0", VA = "0x181FDE1F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B4")]
	[CompilerGenerated]
	private struct IKHGBJDKKKG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000240")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000241")]
		public AsyncTaskMethodBuilder<DFAHBLOKBPH<OKOMLKNINNF, CKBHMJGLAPL>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000242")]
		public BNIFOFOKPDE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000243")]
		public string newName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000244")]
		private DPLHFMKJDOO <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000245")]
		private TaskAwaiter<DFAHBLOKBPH<OKOMLKNINNF, CKBHMJGLAPL>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600046E")]
		[Cpp2IlInjected.Address(RVA = "0x1FDE6B0", Offset = "0x1FDD6B0", VA = "0x181FDE6B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600046F")]
		[Cpp2IlInjected.Address(RVA = "0x1FDEA00", Offset = "0x1FDDA00", VA = "0x181FDEA00", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B5")]
	[CompilerGenerated]
	private struct IGDAHFHMNBM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000246")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000247")]
		public AsyncTaskMethodBuilder<DFAHBLOKBPH<OKOMLKNINNF, CKBHMJGLAPL>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000248")]
		public BNIFOFOKPDE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000249")]
		public BGKDPCAKPBJ<HFFNHINIHLD> inputDefId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400024A")]
		public string name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400024B")]
		private DPLHFMKJDOO <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400024C")]
		private TaskAwaiter<DFAHBLOKBPH<OKOMLKNINNF, CKBHMJGLAPL>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000470")]
		[Cpp2IlInjected.Address(RVA = "0x1FDD9C0", Offset = "0x1FDC9C0", VA = "0x181FDD9C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000471")]
		[Cpp2IlInjected.Address(RVA = "0x1FDDD10", Offset = "0x1FDCD10", VA = "0x181FDDD10", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B6")]
	[CompilerGenerated]
	private struct NLKBPOACKME : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400024D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400024E")]
		public AsyncTaskMethodBuilder<DFAHBLOKBPH<OKOMLKNINNF, CKBHMJGLAPL>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400024F")]
		public BNIFOFOKPDE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000250")]
		public BGKDPCAKPBJ<MBMIEFKCJNG> outputDefId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000251")]
		public string name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000252")]
		private DPLHFMKJDOO <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000253")]
		private TaskAwaiter<DFAHBLOKBPH<OKOMLKNINNF, CKBHMJGLAPL>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000472")]
		[Cpp2IlInjected.Address(RVA = "0x1FE60D0", Offset = "0x1FE50D0", VA = "0x181FE60D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000473")]
		[Cpp2IlInjected.Address(RVA = "0x1FE6420", Offset = "0x1FE5420", VA = "0x181FE6420", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B7")]
	[CompilerGenerated]
	private struct PNEKLIJJHLN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000254")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000255")]
		public AsyncTaskMethodBuilder<DFAHBLOKBPH<OKOMLKNINNF, CKBHMJGLAPL>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000256")]
		public BNIFOFOKPDE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000257")]
		public IDGADJBCIPI type;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000258")]
		public BGKDPCAKPBJ<HFFNHINIHLD> inputDefId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000259")]
		private DPLHFMKJDOO <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400025A")]
		private TaskAwaiter<DFAHBLOKBPH<OKOMLKNINNF, CKBHMJGLAPL>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000474")]
		[Cpp2IlInjected.Address(RVA = "0x1FEC430", Offset = "0x1FEB430", VA = "0x181FEC430", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000475")]
		[Cpp2IlInjected.Address(RVA = "0x1FEC7C0", Offset = "0x1FEB7C0", VA = "0x181FEC7C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B8")]
	[CompilerGenerated]
	private struct GLMHHHMNONP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400025B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400025C")]
		public AsyncTaskMethodBuilder<DFAHBLOKBPH<OKOMLKNINNF, CKBHMJGLAPL>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400025D")]
		public BNIFOFOKPDE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400025E")]
		public IDGADJBCIPI type;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400025F")]
		public BGKDPCAKPBJ<MBMIEFKCJNG> outputDefId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000260")]
		private DPLHFMKJDOO <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000261")]
		private TaskAwaiter<DFAHBLOKBPH<OKOMLKNINNF, CKBHMJGLAPL>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000476")]
		[Cpp2IlInjected.Address(RVA = "0x1FDCF30", Offset = "0x1FDBF30", VA = "0x181FDCF30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000477")]
		[Cpp2IlInjected.Address(RVA = "0x1FDD2C0", Offset = "0x1FDC2C0", VA = "0x181FDD2C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001F8")]
	private readonly bool BHBBONLCIBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001F9")]
	private readonly DLILHLIBGCM CPJCBIFJBNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001FA")]
	private readonly bool CCOAMFPLOMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001FB")]
	private CFDIOFGMMPB<HONMIPKGKFA, GMKLOJNABAC> KKKKJIMPKML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001FC")]
	private CFDIOFGMMPB<HONMIPKGKFA, HADENNIHHJO> KAIAOMKLJGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40001FD")]
	private readonly EMGONNJLBBJ FIBDEFKFLJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40001FE")]
	private CFDIOFGMMPB<KMABMDHMDOF, AAMDLLJOGPJ> NKGNOPIAADJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40001FF")]
	private CFDIOFGMMPB<KMABMDHMDOF, BKHHEMNGJNC> JKLHCNPLBJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000200")]
	private string? LCOEJOADDNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000201")]
	private readonly KDAKJINBHOH GFFMIHPGIIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000202")]
	private BGKDPCAKPBJ<IHOAGKINOHG> BBENPIJDMED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x4000203")]
	private readonly bool LEEEOGFCEKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000204")]
	[CompilerGenerated]
	private Action? ILEELDOBDOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000206")]
	[CompilerGenerated]
	private Action? ENDLGNLMHHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x400020E")]
	[CompilerGenerated]
	private Action<BGKDPCAKPBJ<HONMIPKGKFA>>? GKEIBOILOON;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x4000212")]
	[CompilerGenerated]
	private Action<BGKDPCAKPBJ<KMABMDHMDOF>>? CEPNENOOCEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x4000214")]
	[CompilerGenerated]
	private MOFLLCAHOFM.OIDDEMMDMNF? DCPCHANNPMD;

	[Cpp2IlInjected.Token(Token = "0x17000098")]
	public bool DPNMFEHLCMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000415")]
		[Cpp2IlInjected.Address(RVA = "0x1FD8B00", Offset = "0x1FD7B00", VA = "0x181FD8B00", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000099")]
	public bool BLLCOHDPFFE
	{
		[Cpp2IlInjected.Token(Token = "0x6000416")]
		[Cpp2IlInjected.Address(RVA = "0x1FD6D80", Offset = "0x1FD5D80", VA = "0x181FD6D80", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009A")]
	public bool FKPDJFAIPJH
	{
		[Cpp2IlInjected.Token(Token = "0x6000417")]
		[Cpp2IlInjected.Address(RVA = "0x1FD5A80", Offset = "0x1FD4A80", VA = "0x181FD5A80", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009B")]
	public MFLENLEMIJF<EHIJHEMDKLF> EBCJHIBBHLN
	{
		[Cpp2IlInjected.Token(Token = "0x6000418")]
		[Cpp2IlInjected.Address(RVA = "0x1FD9140", Offset = "0x1FD8140", VA = "0x181FD9140", Slot = "7")]
		get
		{
			return default(MFLENLEMIJF<EHIJHEMDKLF>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009C")]
	public bool KDCPDIHLBOL
	{
		[Cpp2IlInjected.Token(Token = "0x6000419")]
		[Cpp2IlInjected.Address(RVA = "0x1FD9420", Offset = "0x1FD8420", VA = "0x181FD9420", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009D")]
	public CFDIOFGMMPB<HONMIPKGKFA, HADENNIHHJO> HKEAEEHCCHP
	{
		[Cpp2IlInjected.Token(Token = "0x600041A")]
		[Cpp2IlInjected.Address(RVA = "0x851920", Offset = "0x850920", VA = "0x180851920", Slot = "9")]
		get
		{
			return default(CFDIOFGMMPB<HONMIPKGKFA, HADENNIHHJO>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009E")]
	public string NPDJPDJBDCA
	{
		[Cpp2IlInjected.Token(Token = "0x600041B")]
		[Cpp2IlInjected.Address(RVA = "0x1FD9770", Offset = "0x1FD8770", VA = "0x181FD9770", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009F")]
	public MFLENLEMIJF<PMIFAKHBGDE> BOFDPMBCPAD
	{
		[Cpp2IlInjected.Token(Token = "0x600041C")]
		[Cpp2IlInjected.Address(RVA = "0x1FD6D60", Offset = "0x1FD5D60", VA = "0x181FD6D60", Slot = "11")]
		get
		{
			return default(MFLENLEMIJF<PMIFAKHBGDE>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A0")]
	public CFDIOFGMMPB<KMABMDHMDOF, BKHHEMNGJNC> ENGIBKFCJOF
	{
		[Cpp2IlInjected.Token(Token = "0x600041D")]
		[Cpp2IlInjected.Address(RVA = "0x8517F0", Offset = "0x8507F0", VA = "0x1808517F0", Slot = "12")]
		get
		{
			return default(CFDIOFGMMPB<KMABMDHMDOF, BKHHEMNGJNC>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A1")]
	public BGKDPCAKPBJ<IHOAGKINOHG> ALALEMMLKHC
	{
		[Cpp2IlInjected.Token(Token = "0x600041E")]
		[Cpp2IlInjected.Address(RVA = "0xBCF530", Offset = "0xBCE530", VA = "0x180BCF530", Slot = "13")]
		get
		{
			return default(BGKDPCAKPBJ<IHOAGKINOHG>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	public event Action NPDGJMGDPIC
	{
		[Cpp2IlInjected.Token(Token = "0x600041F")]
		[Cpp2IlInjected.Address(RVA = "0x1FD96D0", Offset = "0x1FD86D0", VA = "0x181FD96D0", Slot = "14")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000420")]
		[Cpp2IlInjected.Address(RVA = "0x1FD5B40", Offset = "0x1FD4B40", VA = "0x181FD5B40", Slot = "15")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	public event Action PCBMAKNOCEN
	{
		[Cpp2IlInjected.Token(Token = "0x6000421")]
		[Cpp2IlInjected.Address(RVA = "0x1FD8520", Offset = "0x1FD7520", VA = "0x181FD8520", Slot = "16")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000422")]
		[Cpp2IlInjected.Address(RVA = "0x1FD59D0", Offset = "0x1FD49D0", VA = "0x181FD59D0", Slot = "17")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000E")]
	public event Action<BGKDPCAKPBJ<HONMIPKGKFA>, BGKDPCAKPBJ<HONMIPKGKFA>> FOGDKECKJGE
	{
		[Cpp2IlInjected.Token(Token = "0x6000423")]
		[Cpp2IlInjected.Address(RVA = "0x1FD6150", Offset = "0x1FD5150", VA = "0x181FD6150", Slot = "18")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000424")]
		[Cpp2IlInjected.Address(RVA = "0x1FD54A0", Offset = "0x1FD44A0", VA = "0x181FD54A0", Slot = "19")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000F")]
	public event Action<BGKDPCAKPBJ<HONMIPKGKFA>, BGKDPCAKPBJ<HONMIPKGKFA>> HMPAGNLNOCF
	{
		[Cpp2IlInjected.Token(Token = "0x6000425")]
		[Cpp2IlInjected.Address(RVA = "0x1FD3DC0", Offset = "0x1FD2DC0", VA = "0x181FD3DC0", Slot = "20")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000426")]
		[Cpp2IlInjected.Address(RVA = "0x1FD6AC0", Offset = "0x1FD5AC0", VA = "0x181FD6AC0", Slot = "21")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000010")]
	public event Action<BGKDPCAKPBJ<KMABMDHMDOF>, BGKDPCAKPBJ<KMABMDHMDOF>> DOMCDDDEIJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000427")]
		[Cpp2IlInjected.Address(RVA = "0x1FD7450", Offset = "0x1FD6450", VA = "0x181FD7450", Slot = "22")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000428")]
		[Cpp2IlInjected.Address(RVA = "0x1FD9080", Offset = "0x1FD8080", VA = "0x181FD9080", Slot = "23")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000011")]
	public event Action<BGKDPCAKPBJ<KMABMDHMDOF>, BGKDPCAKPBJ<KMABMDHMDOF>> BOLCECCPDDK
	{
		[Cpp2IlInjected.Token(Token = "0x6000429")]
		[Cpp2IlInjected.Address(RVA = "0x1FD7530", Offset = "0x1FD6530", VA = "0x181FD7530", Slot = "24")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600042A")]
		[Cpp2IlInjected.Address(RVA = "0x1FD6B80", Offset = "0x1FD5B80", VA = "0x181FD6B80", Slot = "25")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000012")]
	public event Action<BGKDPCAKPBJ<HONMIPKGKFA>, HADENNIHHJO> LKELKKHJLJK
	{
		[Cpp2IlInjected.Token(Token = "0x600042B")]
		[Cpp2IlInjected.Address(RVA = "0x1FD7E60", Offset = "0x1FD6E60", VA = "0x181FD7E60", Slot = "26")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600042C")]
		[Cpp2IlInjected.Address(RVA = "0x1FD6940", Offset = "0x1FD5940", VA = "0x181FD6940", Slot = "27")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000013")]
	public event Action<BGKDPCAKPBJ<HONMIPKGKFA>> MCEPBNEECPJ
	{
		[Cpp2IlInjected.Token(Token = "0x600042D")]
		[Cpp2IlInjected.Address(RVA = "0x1FD9170", Offset = "0x1FD8170", VA = "0x181FD9170", Slot = "28")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600042E")]
		[Cpp2IlInjected.Address(RVA = "0x1FD8460", Offset = "0x1FD7460", VA = "0x181FD8460", Slot = "29")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000014")]
	public event Action<BGKDPCAKPBJ<HONMIPKGKFA>, HADENNIHHJO> NBBDAIIBINE
	{
		[Cpp2IlInjected.Token(Token = "0x600042F")]
		[Cpp2IlInjected.Address(RVA = "0x1FD9230", Offset = "0x1FD8230", VA = "0x181FD9230", Slot = "30")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000430")]
		[Cpp2IlInjected.Address(RVA = "0x1FD7DA0", Offset = "0x1FD6DA0", VA = "0x181FD7DA0", Slot = "31")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000015")]
	public event Action<BGKDPCAKPBJ<KMABMDHMDOF>, BKHHEMNGJNC> PGFIPCKIOAH
	{
		[Cpp2IlInjected.Token(Token = "0x6000431")]
		[Cpp2IlInjected.Address(RVA = "0x1FD6270", Offset = "0x1FD5270", VA = "0x181FD6270", Slot = "32")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000432")]
		[Cpp2IlInjected.Address(RVA = "0x1FD6A00", Offset = "0x1FD5A00", VA = "0x181FD6A00", Slot = "33")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000016")]
	public event Action<BGKDPCAKPBJ<KMABMDHMDOF>> MMEJCDDFFAM
	{
		[Cpp2IlInjected.Token(Token = "0x6000433")]
		[Cpp2IlInjected.Address(RVA = "0x1FD85D0", Offset = "0x1FD75D0", VA = "0x181FD85D0", Slot = "34")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000434")]
		[Cpp2IlInjected.Address(RVA = "0x1FD3D00", Offset = "0x1FD2D00", VA = "0x181FD3D00", Slot = "35")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000017")]
	public event Action<BGKDPCAKPBJ<KMABMDHMDOF>, BKHHEMNGJNC> ONGCPLHFJIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000435")]
		[Cpp2IlInjected.Address(RVA = "0x1FD38D0", Offset = "0x1FD28D0", VA = "0x181FD38D0", Slot = "36")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000436")]
		[Cpp2IlInjected.Address(RVA = "0x1FD6330", Offset = "0x1FD5330", VA = "0x181FD6330", Slot = "37")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000437")]
	[Cpp2IlInjected.Address(RVA = "0x1FD97A0", Offset = "0x1FD87A0", VA = "0x181FD97A0")]
	private BNIFOFOKPDE(bool IOKKBNCNMLC, DLILHLIBGCM OPKEKBBFIHG, bool BGCNCJFNKOH, CFDIOFGMMPB<HONMIPKGKFA, GMKLOJNABAC> FHCLAGOMKDK, CFDIOFGMMPB<HONMIPKGKFA, HADENNIHHJO> EGGDHJHGIGG, EMGONNJLBBJ OHDOOCGHDGN, CFDIOFGMMPB<KMABMDHMDOF, AAMDLLJOGPJ> FNPAAGAEKPL, CFDIOFGMMPB<KMABMDHMDOF, BKHHEMNGJNC> CACGKKKCEFK, string? OMGGELLOPHP, KDAKJINBHOH BEBLGLINBBD, BGKDPCAKPBJ<IHOAGKINOHG> FCFGPBAFAPA, bool HBPNKNHGJMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000438")]
	[Cpp2IlInjected.Address(RVA = "0x1FD5BE0", Offset = "0x1FD4BE0", VA = "0x181FD5BE0")]
	public static BNIFOFOKPDE GAKCNKPJGEK(bool IOKKBNCNMLC, DLILHLIBGCM OPKEKBBFIHG, bool BGCNCJFNKOH, EMGONNJLBBJ OHDOOCGHDGN, KDAKJINBHOH BEBLGLINBBD, BGKDPCAKPBJ<IHOAGKINOHG> FCFGPBAFAPA, bool HBPNKNHGJMP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000439")]
	[Cpp2IlInjected.Address(RVA = "0x1FD75F0", Offset = "0x1FD65F0", VA = "0x181FD75F0")]
	private void LFNNOPDGNGK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043A")]
	[Cpp2IlInjected.Address(RVA = "0x1FD49A0", Offset = "0x1FD39A0", VA = "0x181FD49A0", Slot = "49")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043B")]
	[Cpp2IlInjected.Address(RVA = "0x1FD4670", Offset = "0x1FD3670", VA = "0x181FD4670", Slot = "38")]
	[AsyncStateMachine(typeof(AJNOBIENMON))]
	public Task<DFAHBLOKBPH<OKOMLKNINNF, CKBHMJGLAPL>> CNHPPPBOMHK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600043C")]
	[Cpp2IlInjected.Address(RVA = "0x1FD94A0", Offset = "0x1FD84A0", VA = "0x181FD94A0")]
	private (KDELCGPPBKK, int)? PHFGONEJIPI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600043D")]
	[Cpp2IlInjected.Address(RVA = "0x1FD4450", Offset = "0x1FD3450", VA = "0x181FD4450")]
	private void CLCCDDHFGNN(int LDILGLAONLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043E")]
	[Cpp2IlInjected.Address(RVA = "0x1515CB0", Offset = "0x1514CB0", VA = "0x181515CB0")]
	private void EAGCNOIHFOK(int LDILGLAONLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043F")]
	[Cpp2IlInjected.Address(RVA = "0x1FD6450", Offset = "0x1FD5450", VA = "0x181FD6450")]
	private void GKNJGPEDCGO(int AHJMBOFDKPL, int NIMONDEIANP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000440")]
	[Cpp2IlInjected.Address(RVA = "0x1FD6210", Offset = "0x1FD5210", VA = "0x181FD6210")]
	private void GCINBFPEPLK(int AHJMBOFDKPL, int NIMONDEIANP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000441")]
	[Cpp2IlInjected.Address(RVA = "0x1FD6DC0", Offset = "0x1FD5DC0", VA = "0x181FD6DC0")]
	private void JFABOAKGAOB(int LDILGLAONLG, BGKDPCAKPBJ<HONMIPKGKFA> OIJKJCMGPKB, AOJKPNALAMB GEMGCEDHMEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000442")]
	[Cpp2IlInjected.Address(RVA = "0x1FD4850", Offset = "0x1FD3850", VA = "0x181FD4850")]
	private void DFMCCCLNKME(int PGMBMLICCAI, BGKDPCAKPBJ<HONMIPKGKFA> OIJKJCMGPKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000443")]
	[Cpp2IlInjected.Address(RVA = "0x1FD8690", Offset = "0x1FD7690", VA = "0x181FD8690")]
	private void NNBPLFNPLDJ(int PGMBMLICCAI, BGKDPCAKPBJ<HONMIPKGKFA> OIJKJCMGPKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000444")]
	[Cpp2IlInjected.Address(RVA = "0x1FD86B0", Offset = "0x1FD76B0", VA = "0x181FD86B0")]
	private void NOMONKAONHN(int LDILGLAONLG, BGKDPCAKPBJ<HONMIPKGKFA> OIJKJCMGPKB, AOJKPNALAMB GEMGCEDHMEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000445")]
	[Cpp2IlInjected.Address(RVA = "0x1FD67F0", Offset = "0x1FD57F0", VA = "0x181FD67F0")]
	private void GLDEKKBINEG(int LDILGLAONLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000446")]
	[Cpp2IlInjected.Address(RVA = "0xBA56D0", Offset = "0xBA46D0", VA = "0x180BA56D0")]
	private void BDFFJOOMFEH(int LDILGLAONLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000447")]
	[Cpp2IlInjected.Address(RVA = "0x1FD3E80", Offset = "0x1FD2E80", VA = "0x181FD3E80")]
	private void CJGGHDJCEPD(int LDILGLAONLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000448")]
	[Cpp2IlInjected.Address(RVA = "0x1515CB0", Offset = "0x1514CB0", VA = "0x181515CB0")]
	private void CBAIICPOHGA(int LDILGLAONLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000449")]
	[Cpp2IlInjected.Address(RVA = "0x1FD8BC0", Offset = "0x1FD7BC0", VA = "0x181FD8BC0")]
	private void OHNCDKOOJFH(int AHJMBOFDKPL, int NIMONDEIANP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044A")]
	[Cpp2IlInjected.Address(RVA = "0x1FD63F0", Offset = "0x1FD53F0", VA = "0x181FD63F0")]
	private void GIAJDDHBCCH(int AHJMBOFDKPL, int NIMONDEIANP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044B")]
	[Cpp2IlInjected.Address(RVA = "0x1FD7F20", Offset = "0x1FD6F20", VA = "0x181FD7F20")]
	private void MEGEACLJDOL(int LDILGLAONLG, BGKDPCAKPBJ<KMABMDHMDOF> OIJKJCMGPKB, GOEJKOMPEKH GEMGCEDHMEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044C")]
	[Cpp2IlInjected.Address(RVA = "0x1FD7510", Offset = "0x1FD6510", VA = "0x181FD7510")]
	private void KIKMJNFLINH(int PGMBMLICCAI, BGKDPCAKPBJ<KMABMDHMDOF> OIJKJCMGPKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044D")]
	[Cpp2IlInjected.Address(RVA = "0x1FD4870", Offset = "0x1FD3870", VA = "0x181FD4870")]
	private void DHKIBKBNAAH(int PGMBMLICCAI, BGKDPCAKPBJ<KMABMDHMDOF> OIJKJCMGPKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044E")]
	[Cpp2IlInjected.Address(RVA = "0x1FD5560", Offset = "0x1FD4560", VA = "0x181FD5560")]
	private void EKCBCNMFBPM(int LDILGLAONLG, BGKDPCAKPBJ<KMABMDHMDOF> OIJKJCMGPKB, GOEJKOMPEKH GEMGCEDHMEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044F")]
	[Cpp2IlInjected.Address(RVA = "0x1FD7300", Offset = "0x1FD6300", VA = "0x181FD7300")]
	private void JHDHMNEDDAH(int LDILGLAONLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000450")]
	[Cpp2IlInjected.Address(RVA = "0xBA56D0", Offset = "0xBA46D0", VA = "0x180BA56D0")]
	private void LGGDALGKFDC(int LDILGLAONLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000451")]
	[Cpp2IlInjected.Address(RVA = "0x1FD3AC0", Offset = "0x1FD2AC0", VA = "0x181FD3AC0", Slot = "39")]
	[AsyncStateMachine(typeof(BELJBOKMBPP))]
	public Task<DFAHBLOKBPH<OKOMLKNINNF, CKBHMJGLAPL>> AKFANOOPAEL(BGKDPCAKPBJ<HFFNHINIHLD> NODCCEJHLIA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000452")]
	[Cpp2IlInjected.Address(RVA = "0x1FD4890", Offset = "0x1FD3890", VA = "0x181FD4890", Slot = "40")]
	[AsyncStateMachine(typeof(MGGFBCLGFCF))]
	public Task<DFAHBLOKBPH<OKOMLKNINNF, CKBHMJGLAPL>> DOPLAEFFDFO(BGKDPCAKPBJ<MBMIEFKCJNG> NCOFEOALOGH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000453")]
	[Cpp2IlInjected.Address(RVA = "0x1FD8F60", Offset = "0x1FD7F60", VA = "0x181FD8F60", Slot = "41")]
	[AsyncStateMachine(typeof(NHACKCADHPE))]
	public Task<DFAHBLOKBPH<OKOMLKNINNF, CKBHMJGLAPL>> PANOLFECGLO(BGKDPCAKPBJ<HFFNHINIHLD> NODCCEJHLIA, BGKDPCAKPBJ<HFFNHINIHLD> GBIBFEAMAFP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000454")]
	[Cpp2IlInjected.Address(RVA = "0x1FD4330", Offset = "0x1FD3330", VA = "0x181FD4330", Slot = "42")]
	[AsyncStateMachine(typeof(FCILOGMGBFP))]
	public Task<DFAHBLOKBPH<OKOMLKNINNF, CKBHMJGLAPL>> CKPANPLBNHD(BGKDPCAKPBJ<MBMIEFKCJNG> NCOFEOALOGH, BGKDPCAKPBJ<MBMIEFKCJNG> GBIBFEAMAFP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000455")]
	[Cpp2IlInjected.Address(RVA = "0x1FD4760", Offset = "0x1FD3760", VA = "0x181FD4760", Slot = "43")]
	[AsyncStateMachine(typeof(IJFBMEFMANH))]
	public Task<DFAHBLOKBPH<OKOMLKNINNF, CKBHMJGLAPL>> COKLDNOCHLH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000456")]
	[Cpp2IlInjected.Address(RVA = "0x1FD6C40", Offset = "0x1FD5C40", VA = "0x181FD6C40", Slot = "44")]
	[AsyncStateMachine(typeof(IKHGBJDKKKG))]
	public Task<DFAHBLOKBPH<OKOMLKNINNF, CKBHMJGLAPL>> HKLCGLOLOPK(string NHLKGOCGEKM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000457")]
	[Cpp2IlInjected.Address(RVA = "0x1FD92F0", Offset = "0x1FD82F0", VA = "0x181FD92F0", Slot = "45")]
	[AsyncStateMachine(typeof(IGDAHFHMNBM))]
	public Task<DFAHBLOKBPH<OKOMLKNINNF, CKBHMJGLAPL>> PDCJBJDPFAB(BGKDPCAKPBJ<HFFNHINIHLD> NODCCEJHLIA, string CKEJJGPNKGO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000458")]
	[Cpp2IlInjected.Address(RVA = "0x1FD4540", Offset = "0x1FD3540", VA = "0x181FD4540", Slot = "46")]
	[AsyncStateMachine(typeof(NLKBPOACKME))]
	public Task<DFAHBLOKBPH<OKOMLKNINNF, CKBHMJGLAPL>> CNCIADMEECL(BGKDPCAKPBJ<MBMIEFKCJNG> NCOFEOALOGH, string CKEJJGPNKGO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000459")]
	[Cpp2IlInjected.Address(RVA = "0x1FD3BD0", Offset = "0x1FD2BD0", VA = "0x181FD3BD0", Slot = "47")]
	[AsyncStateMachine(typeof(PNEKLIJJHLN))]
	public Task<DFAHBLOKBPH<OKOMLKNINNF, CKBHMJGLAPL>> BDAMEDDKLFA(BGKDPCAKPBJ<HFFNHINIHLD> NODCCEJHLIA, IDGADJBCIPI HNGLFCFOHLI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600045A")]
	[Cpp2IlInjected.Address(RVA = "0x1FD3990", Offset = "0x1FD2990", VA = "0x181FD3990", Slot = "48")]
	[AsyncStateMachine(typeof(GLMHHHMNONP))]
	public Task<DFAHBLOKBPH<OKOMLKNINNF, CKBHMJGLAPL>> AFAMDKGJBAN(BGKDPCAKPBJ<MBMIEFKCJNG> NCOFEOALOGH, IDGADJBCIPI HNGLFCFOHLI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600045B")]
	[Cpp2IlInjected.Address(RVA = "0x1FD3F70", Offset = "0x1FD2F70", VA = "0x181FD3F70")]
	internal void CJMOCOIOAIP(BGKDPCAKPBJ<IHOAGKINOHG> JJCEIJMGOAB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B9")]
public sealed class NBEHIIBMPBF : FJEIPFCJKKB, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000BA")]
	public interface IKBJBOPHAJI
	{
		[Cpp2IlInjected.Token(Token = "0x170000A3")]
		CHEDDAFAOPO JMAAADBMBIM
		{
			[Cpp2IlInjected.Token(Token = "0x600047C")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x600047D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		Task<GONCODLINKC> BEELAJIPPGB(CancellationToken LABHBAHABKB);

		[Cpp2IlInjected.Token(Token = "0x600047E")]
		[Cpp2IlInjected.Address(Slot = "2")]
		Task<OPGPLFDAFEE> AFDIEGFEKDE(CancellationToken LABHBAHABKB);

		[Cpp2IlInjected.Token(Token = "0x600047F")]
		[Cpp2IlInjected.Address(Slot = "3")]
		Task<DJMMCDEOJKM> LFIMJGFBHCP(CancellationToken LABHBAHABKB);
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000BB")]
	[CompilerGenerated]
	private struct NIDKAKIPGIA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000263")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000264")]
		public AsyncTaskMethodBuilder<NBEHIIBMPBF> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000265")]
		public DLILHLIBGCM circuitsManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000266")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000267")]
		public GONCODLINKC roomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000268")]
		public OPGPLFDAFEE superRoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000269")]
		private IKBJBOPHAJI <selfDeps>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400026A")]
		private OPGPLFDAFEE <finalSuperRoomData>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400026B")]
		private TaskAwaiter<GONCODLINKC> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400026C")]
		private TaskAwaiter<OPGPLFDAFEE> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400026D")]
		private TaskAwaiter<DJMMCDEOJKM> <>u__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400026E")]
		private TaskAwaiter<MHOOCAJAJNP> <>u__4;

		[Cpp2IlInjected.Token(Token = "0x6000480")]
		[Cpp2IlInjected.Address(RVA = "0x1FE5650", Offset = "0x1FE4650", VA = "0x181FE5650", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000481")]
		[Cpp2IlInjected.Address(RVA = "0x1FE6060", Offset = "0x1FE5060", VA = "0x181FE6060", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000262")]
	private readonly MHOOCAJAJNP AFDEHDPPNKG;

	[Cpp2IlInjected.Token(Token = "0x170000A2")]
	public MHOOCAJAJNP HLFIHKBABHI
	{
		[Cpp2IlInjected.Token(Token = "0x600047B")]
		[Cpp2IlInjected.Address(RVA = "0x8518C0", Offset = "0x8508C0", VA = "0x1808518C0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000478")]
	[Cpp2IlInjected.Address(RVA = "0x858C30", Offset = "0x857C30", VA = "0x180858C30")]
	private NBEHIIBMPBF(MHOOCAJAJNP KBOJBCMAJIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000479")]
	[Cpp2IlInjected.Address(RVA = "0x1FE50D0", Offset = "0x1FE40D0", VA = "0x181FE50D0")]
	[AsyncStateMachine(typeof(NIDKAKIPGIA))]
	public static Task<NBEHIIBMPBF> NBLMOEHBGOH(DLILHLIBGCM OPKEKBBFIHG, GONCODLINKC? KBAPBJOHBKA, OPGPLFDAFEE? LDGJIBHMHDH, CancellationToken LABHBAHABKB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600047A")]
	[Cpp2IlInjected.Address(RVA = "0x1FE50B0", Offset = "0x1FE40B0", VA = "0x181FE50B0", Slot = "5")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BC")]
public readonly struct FAOOALJKJLE
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000BD")]
	[CompilerGenerated]
	private struct KKNEGGFDMNL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000270")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000271")]
		public AsyncTaskMethodBuilder<DFAHBLOKBPH<object, CKBHMJGLAPL>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000272")]
		public FAOOALJKJLE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000273")]
		public LJHEBKBBECA action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000274")]
		public bool clearBufferedRpcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000275")]
		private TaskAwaiter<DFAHBLOKBPH<object, CKBHMJGLAPL>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000486")]
		[Cpp2IlInjected.Address(RVA = "0x1FE23D0", Offset = "0x1FE13D0", VA = "0x181FE23D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000487")]
		[Cpp2IlInjected.Address(RVA = "0x1FE2660", Offset = "0x1FE1660", VA = "0x181FE2660", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000BE")]
	[CompilerGenerated]
	private struct IJKKNPGOEGN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000276")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000277")]
		public AsyncTaskMethodBuilder<DFAHBLOKBPH<bool, CKBHMJGLAPL>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000278")]
		public int splitSizeBytes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000279")]
		public ACNLHJIMLEN rootData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400027A")]
		public GONCODLINKC circuitRootData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400027B")]
		public OPGPLFDAFEE superRoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400027C")]
		public FAOOALJKJLE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400027D")]
		private LJHEBKBBECA[] <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400027E")]
		private int <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400027F")]
		private TaskAwaiter<DFAHBLOKBPH<object, CKBHMJGLAPL>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000488")]
		[Cpp2IlInjected.Address(RVA = "0x1FDE260", Offset = "0x1FDD260", VA = "0x181FDE260", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000489")]
		[Cpp2IlInjected.Address(RVA = "0x1FDE640", Offset = "0x1FDD640", VA = "0x181FDE640", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000BF")]
	[CompilerGenerated]
	private struct BBBKJEAHJIN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000280")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000281")]
		public AsyncTaskMethodBuilder<DFAHBLOKBPH<OKOMLKNINNF, CKBHMJGLAPL>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000282")]
		public FAOOALJKJLE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000283")]
		private TaskAwaiter<DFAHBLOKBPH<object, CKBHMJGLAPL>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600048A")]
		[Cpp2IlInjected.Address(RVA = "0x1FD2B80", Offset = "0x1FD1B80", VA = "0x181FD2B80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600048B")]
		[Cpp2IlInjected.Address(RVA = "0x1FD2DC0", Offset = "0x1FD1DC0", VA = "0x181FD2DC0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400026F")]
	private readonly IGBBFLOOINI PIGKBJPAHGN;

	[Cpp2IlInjected.Token(Token = "0x6000482")]
	[Cpp2IlInjected.Address(RVA = "0xA111F0", Offset = "0xA101F0", VA = "0x180A111F0")]
	public FAOOALJKJLE(IGBBFLOOINI GBBAAFALICM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000483")]
	[Cpp2IlInjected.Address(RVA = "0x1FDBDB0", Offset = "0x1FDADB0", VA = "0x181FDBDB0")]
	[AsyncStateMachine(typeof(KKNEGGFDMNL))]
	private Task<DFAHBLOKBPH<object, CKBHMJGLAPL>> DKBJKMAMMMJ(LJHEBKBBECA JFOAFIPDIOA, bool AMHHLKAOAOK = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000484")]
	[Cpp2IlInjected.Address(RVA = "0x1FDBEE0", Offset = "0x1FDAEE0", VA = "0x181FDBEE0")]
	[AsyncStateMachine(typeof(IJKKNPGOEGN))]
	public Task<DFAHBLOKBPH<bool, CKBHMJGLAPL?>>? FLAHLLJBCGA(int LLBBMCIBMCH, ACNLHJIMLEN? BJFDPEFNNCL, GONCODLINKC? IINFNJFFILP, OPGPLFDAFEE? LDGJIBHMHDH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000485")]
	[Cpp2IlInjected.Address(RVA = "0x1FDBCC0", Offset = "0x1FDACC0", VA = "0x181FDBCC0")]
	[AsyncStateMachine(typeof(BBBKJEAHJIN))]
	public Task<DFAHBLOKBPH<OKOMLKNINNF, CKBHMJGLAPL>> CANECBKHGDE()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C0")]
public sealed class BOLIAKIDGHO : BNLAJFLOIDN, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000284")]
	private readonly AMHALAAKCHN MFFKJNKNIDJ;

	[Cpp2IlInjected.Token(Token = "0x170000A4")]
	public AMHALAAKCHN GHGJPBJKCEJ
	{
		[Cpp2IlInjected.Token(Token = "0x600048F")]
		[Cpp2IlInjected.Address(RVA = "0x8518C0", Offset = "0x8508C0", VA = "0x1808518C0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600048C")]
	[Cpp2IlInjected.Address(RVA = "0x858C30", Offset = "0x857C30", VA = "0x180858C30")]
	private BOLIAKIDGHO(AMHALAAKCHN HBDOBCGGHIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048D")]
	[Cpp2IlInjected.Address(RVA = "0x1FD98C0", Offset = "0x1FD88C0", VA = "0x181FD98C0")]
	public static BOLIAKIDGHO PPFECFLIGJE(DLILHLIBGCM OPKEKBBFIHG, ACNLHJIMLEN CIKADECLAKM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600048E")]
	[Cpp2IlInjected.Address(RVA = "0x1FD98A0", Offset = "0x1FD88A0", VA = "0x181FD98A0", Slot = "5")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C1")]
public interface JJIBBBFHGIG : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x170000A5")]
	MHOOCAJAJNP HLFIHKBABHI
	{
		[Cpp2IlInjected.Token(Token = "0x6000490")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A6")]
	GCBDAOEDPME LHFLHBJLKBA
	{
		[Cpp2IlInjected.Token(Token = "0x6000491")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A7")]
	IBCHDJBNEDB LKCBLDPNJHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000492")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A8")]
	OIBHFGOJEEN JPGGKCKGDFG
	{
		[Cpp2IlInjected.Token(Token = "0x6000493")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C2")]
public interface GKLBAKCCLFN : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x170000A9")]
	JJIBBBFHGIG? BGNEDPJINED
	{
		[Cpp2IlInjected.Token(Token = "0x6000494")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000AA")]
	bool EFBLDNCDHCM
	{
		[Cpp2IlInjected.Token(Token = "0x6000495")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000AB")]
	bool EIPAEAHAGJM
	{
		[Cpp2IlInjected.Token(Token = "0x6000496")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000497")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Task<JJIBBBFHGIG?>? KJOHOJBJGPN();

	[Cpp2IlInjected.Token(Token = "0x6000498")]
	[Cpp2IlInjected.Address(Slot = "4")]
	Task ANKMDHOFENM(DLILHLIBGCM OPKEKBBFIHG, ACNLHJIMLEN CIKADECLAKM, GONCODLINKC? MBJAMOMBIEB, OPGPLFDAFEE? HLOAHIKAKFO);
}
[Cpp2IlInjected.Token(Token = "0x20000C3")]
[OPGEBIIGIGA("IStaticCV2Instance")]
public interface FJEIPFCJKKB : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x170000AC")]
	MHOOCAJAJNP HLFIHKBABHI
	{
		[Cpp2IlInjected.Token(Token = "0x6000499")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C4")]
[OPGEBIIGIGA("IStaticEVInstance")]
public interface BNLAJFLOIDN : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x170000AD")]
	AMHALAAKCHN GHGJPBJKCEJ
	{
		[Cpp2IlInjected.Token(Token = "0x600049A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C5")]
public static class HKKHNBEKHKJ
{
	[Cpp2IlInjected.Token(Token = "0x600049B")]
	[Cpp2IlInjected.Address(RVA = "0x1FDD460", Offset = "0x1FDC460", VA = "0x181FDD460")]
	public static LFFDDJPJHBH<IIDFNFNFGMN, LJHEBKBBECA, DLILHLIBGCM, CPPIEJKJJPO.PGABJALLGMN<IIDFNFNFGMN, LJHEBKBBECA, DLILHLIBGCM>> PBDADKEJCJC([In] this LFFDDJPJHBH<IIDFNFNFGMN, LJHEBKBBECA, DLILHLIBGCM, CPPIEJKJJPO.PGABJALLGMN<IIDFNFNFGMN, LJHEBKBBECA, DLILHLIBGCM>> PDHIADMHHCK)
	{
		return default(LFFDDJPJHBH<IIDFNFNFGMN, LJHEBKBBECA, DLILHLIBGCM, CPPIEJKJJPO.PGABJALLGMN<IIDFNFNFGMN, LJHEBKBBECA, DLILHLIBGCM>>);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C6")]
public sealed class FDGLIGGPHEK : JIFMDNHFFGL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000285")]
	private readonly DLILHLIBGCM CPJCBIFJBNF;

	[Cpp2IlInjected.Token(Token = "0x170000AE")]
	public bool EIPAEAHAGJM
	{
		[Cpp2IlInjected.Token(Token = "0x600049C")]
		[Cpp2IlInjected.Address(RVA = "0x1FDC400", Offset = "0x1FDB400", VA = "0x181FDC400", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600049D")]
	[Cpp2IlInjected.Address(RVA = "0x858C30", Offset = "0x857C30", VA = "0x180858C30")]
	internal FDGLIGGPHEK(DLILHLIBGCM OPKEKBBFIHG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C7")]
internal sealed class OMAIHILJAJP : BCMIFOGFBLK
{
	[Cpp2IlInjected.Token(Token = "0x600049E")]
	[Cpp2IlInjected.Address(RVA = "0x1FEB660", Offset = "0x1FEA660", VA = "0x181FEB660", Slot = "4")]
	public COOAOOMPNKE? KFGPDFJPLAC(string? EHMAHHPLCCO, string? NCHCJLKACLN, string? CHLJBPKGPBH, DPCELDFLDDD.DIMHDMJHMDG.LJBPIIEBGDD AGCINFENBGB, bool JCBLNIGJPBD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600049F")]
	[Cpp2IlInjected.Address(RVA = "0x85EB60", Offset = "0x85DB60", VA = "0x18085EB60")]
	public OMAIHILJAJP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C8")]
public sealed class JJJMMGGCKPA : GAMFGHBFMKK
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000C9")]
	[CompilerGenerated]
	private struct JBMEADALKFB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000288")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000289")]
		public AsyncTaskMethodBuilder<OIBAKLEHGAH> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400028A")]
		public JJJMMGGCKPA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400028B")]
		private TaskAwaiter<JJIBBBFHGIG?> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004A9")]
		[Cpp2IlInjected.Address(RVA = "0x1FDEA70", Offset = "0x1FDDA70", VA = "0x181FDEA70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004AA")]
		[Cpp2IlInjected.Address(RVA = "0x1FDED10", Offset = "0x1FDDD10", VA = "0x181FDED10", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000286")]
	private readonly DLILHLIBGCM CPJCBIFJBNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000287")]
	private IReadOnlyList<MFLENLEMIJF<CLCGFMMKGBC>>? BGOJKHODEME;

	[Cpp2IlInjected.Token(Token = "0x170000AF")]
	public OIBAKLEHGAH? PNNELGGLBHA
	{
		[Cpp2IlInjected.Token(Token = "0x60004A0")]
		[Cpp2IlInjected.Address(RVA = "0x1FDF530", Offset = "0x1FDE530", VA = "0x181FDF530", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B0")]
	public OIBHFGOJEEN? LLIPMAOHOMO
	{
		[Cpp2IlInjected.Token(Token = "0x60004A1")]
		[Cpp2IlInjected.Address(RVA = "0x1FDFD80", Offset = "0x1FDED80", VA = "0x181FDFD80")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B1")]
	public bool OEPKHHLLNEF
	{
		[Cpp2IlInjected.Token(Token = "0x60004A2")]
		[Cpp2IlInjected.Address(RVA = "0x1FDFD20", Offset = "0x1FDED20", VA = "0x181FDFD20", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B2")]
	public bool NJOGMELAOFF
	{
		[Cpp2IlInjected.Token(Token = "0x60004A3")]
		[Cpp2IlInjected.Address(RVA = "0x1FDFE00", Offset = "0x1FDEE00", VA = "0x181FDFE00", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004A4")]
	[Cpp2IlInjected.Address(RVA = "0x858C30", Offset = "0x857C30", VA = "0x180858C30")]
	internal JJJMMGGCKPA(DLILHLIBGCM OPKEKBBFIHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A5")]
	[Cpp2IlInjected.Address(RVA = "0x1FDF440", Offset = "0x1FDE440", VA = "0x181FDF440", Slot = "7")]
	[AsyncStateMachine(typeof(JBMEADALKFB))]
	public Task<OIBAKLEHGAH> ABOIOJMADFH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004A6")]
	[Cpp2IlInjected.Address(RVA = "0x1FDF5B0", Offset = "0x1FDE5B0", VA = "0x181FDF5B0", Slot = "9")]
	public IReadOnlyDictionary<MFLENLEMIJF<EHIJHEMDKLF>, Guid> GAKKKBOHHJN(IEnumerable<ENFIPLJHHAN> HDOMMJFKDOL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004A7")]
	[Cpp2IlInjected.Address(RVA = "0x1FDF920", Offset = "0x1FDE920", VA = "0x181FDF920")]
	public DFAHBLOKBPH<MNECEFBBKEI, GFEHMFEELCO> GEEDKOMEHDA([In] MNECEFBBKEI KPKEOFFNDED, IEnumerable<ENFIPLJHHAN> NIMIEHKGAPI, int FOONJGPILCK)
	{
		return default(DFAHBLOKBPH<MNECEFBBKEI, GFEHMFEELCO>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004A8")]
	[Cpp2IlInjected.Address(RVA = "0x1FDFB20", Offset = "0x1FDEB20", VA = "0x181FDFB20", Slot = "8")]
	private DFAHBLOKBPH<MNECEFBBKEI, GFEHMFEELCO> HGPABHACLBI([In] MNECEFBBKEI KPKEOFFNDED, IEnumerable<ENFIPLJHHAN> NIMIEHKGAPI, int FOONJGPILCK)
	{
		return default(DFAHBLOKBPH<MNECEFBBKEI, GFEHMFEELCO>);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CA")]
public sealed class OIBHFGOJEEN : OIBAKLEHGAH
{
	[Cpp2IlInjected.Token(Token = "0x20000CB")]
	internal static class JNKCODCKEKE
	{
		[Cpp2IlInjected.Token(Token = "0x20000CC")]
		[CompilerGenerated]
		private sealed class PEBECGJOCPD
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000294")]
			public MHOOCAJAJNP state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000295")]
			public DFHKAHJLJKC spawnIntoGraph;

			[Cpp2IlInjected.Token(Token = "0x60004F7")]
			[Cpp2IlInjected.Address(RVA = "0x85EB60", Offset = "0x85DB60", VA = "0x18085EB60")]
			public PEBECGJOCPD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004F8")]
			[Cpp2IlInjected.Address(RVA = "0x1FEBAC0", Offset = "0x1FEAAC0", VA = "0x181FEBAC0")]
			internal bool JFGHIJDOCEJ(LFFAJIBKBJA n)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000CD")]
		[CompilerGenerated]
		private sealed class CDECAAIMGPE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000296")]
			public int makerPenInteractionFilterKeyValue;

			[Cpp2IlInjected.Token(Token = "0x60004F9")]
			[Cpp2IlInjected.Address(RVA = "0x85EB60", Offset = "0x85DB60", VA = "0x18085EB60")]
			public CDECAAIMGPE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004FA")]
			[Cpp2IlInjected.Address(RVA = "0x1FD9B60", Offset = "0x1FD8B60", VA = "0x181FD9B60")]
			internal void BICNEKGIJIP(LFFAJIBKBJA n)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60004F1")]
		[Cpp2IlInjected.Address(RVA = "0x1FE1630", Offset = "0x1FE0630", VA = "0x181FE1630")]
		public static DFAHBLOKBPH<OIBAKLEHGAH.HMCBNEIEENK, NMADAPLGOEB> PCBFBKDIPKL(OIBHFGOJEEN KALCJEIICGB, [In] OIBAKLEHGAH.LCMCGOALKGM DJNIHGJAOCO)
		{
			return default(DFAHBLOKBPH<OIBAKLEHGAH.HMCBNEIEENK, NMADAPLGOEB>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004F2")]
		[Cpp2IlInjected.Address(RVA = "0x1FDFE60", Offset = "0x1FDEE60", VA = "0x181FDFE60")]
		internal static DFAHBLOKBPH<(FKMCCCBOCLI, OPIOJLMIGPE), NMADAPLGOEB> EJKALIPBENE(OIBHFGOJEEN KALCJEIICGB, OPIOJLMIGPE BGGJPPAKMBN, bool KDMNABFPADL, [In] MFLENLEMIJF<EHIJHEMDKLF> CHBEBDKJCPH, [In] int? MNDBDLFNHLF, [In] OHGCEAGLHOO? MHDLJEMEOKA, [In] OHGCEAGLHOO? GKLLFOCPKMF)
		{
			return default(DFAHBLOKBPH<(FKMCCCBOCLI, OPIOJLMIGPE), NMADAPLGOEB>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004F3")]
		[Cpp2IlInjected.Address(RVA = "0x1FE11F0", Offset = "0x1FE01F0", VA = "0x181FE11F0")]
		private static void KDLACAKNBKG(bool KDMNABFPADL, ENFIPLJHHAN HNOBJNPONNI, FKMCCCBOCLI LFCLHKOGAKM, [In] MFLENLEMIJF<EHIJHEMDKLF> CHBEBDKJCPH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004F4")]
		[Cpp2IlInjected.Address(RVA = "0x1FE0CD0", Offset = "0x1FDFCD0", VA = "0x181FE0CD0")]
		public static void HEHPCPMGCEJ(MFPHCOJFMLN GODEMGGABOE, [In] OIBAKLEHGAH.MMOOGIJDGFD HCFIEBAENLH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004F5")]
		[Cpp2IlInjected.Address(RVA = "0x1FE1100", Offset = "0x1FE0100", VA = "0x181FE1100")]
		[CompilerGenerated]
		internal static bool JKHIKDAIKAN(MHOOCAJAJNP IPKIKLMJDIL, DFHKAHJLJKC DMPDKNEKKIA, LFFAJIBKBJA DLJMFFBHDIF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60004F6")]
		[Cpp2IlInjected.Address(RVA = "0x1FE10D0", Offset = "0x1FE00D0", VA = "0x181FE10D0")]
		[CompilerGenerated]
		internal static bool INCAGFDEKPE(LFFAJIBKBJA CBKMIAOMAIC)
		{
			return default(bool);
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000D0")]
	[CompilerGenerated]
	private struct EMILLLFDMCO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400029B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400029C")]
		public AsyncTaskMethodBuilder<DFAHBLOKBPH<OKOMLKNINNF, CKBHMJGLAPL>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400029D")]
		public OIBHFGOJEEN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400029E")]
		public BGKDPCAKPBJ<EHIJHEMDKLF> graphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x400029F")]
		public BGKDPCAKPBJ<LMEADFHGDCP> srcId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002A0")]
		public BGKDPCAKPBJ<BLEKLEBBJEP> dstId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002A1")]
		private TaskAwaiter<DFAHBLOKBPH<OKOMLKNINNF, CKBHMJGLAPL>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000501")]
		[Cpp2IlInjected.Address(RVA = "0x1FDAD50", Offset = "0x1FD9D50", VA = "0x181FDAD50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000502")]
		[Cpp2IlInjected.Address(RVA = "0x1FDB3A0", Offset = "0x1FDA3A0", VA = "0x181FDB3A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000D1")]
	[CompilerGenerated]
	private struct BLDIAADCJGD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002A2")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002A3")]
		public AsyncTaskMethodBuilder<DFAHBLOKBPH<OKOMLKNINNF, CKBHMJGLAPL>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002A4")]
		public OIBHFGOJEEN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002A5")]
		public MFLENLEMIJF<PMIFAKHBGDE> inputNodeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002A6")]
		public MFLENLEMIJF<EHIJHEMDKLF> graphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002A7")]
		public BGKDPCAKPBJ<IHOAGKINOHG> inputPortGroupId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x40002A8")]
		public BGKDPCAKPBJ<HONMIPKGKFA> inputId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40002A9")]
		private TaskAwaiter<DFAHBLOKBPH<OKOMLKNINNF, CKBHMJGLAPL>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000503")]
		[Cpp2IlInjected.Address(RVA = "0x1FD3520", Offset = "0x1FD2520", VA = "0x181FD3520", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000504")]
		[Cpp2IlInjected.Address(RVA = "0x1FD3860", Offset = "0x1FD2860", VA = "0x181FD3860", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000D2")]
	[CompilerGenerated]
	private struct HMOOLFJPBBD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002AA")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002AB")]
		public AsyncTaskMethodBuilder<DFAHBLOKBPH<OKOMLKNINNF, CKBHMJGLAPL>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002AC")]
		public OIBHFGOJEEN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002AD")]
		public MFLENLEMIJF<PMIFAKHBGDE> outputNodeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002AE")]
		public MFLENLEMIJF<EHIJHEMDKLF> graphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002AF")]
		public BGKDPCAKPBJ<IHOAGKINOHG> outputPortGroupId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x40002B0")]
		public BGKDPCAKPBJ<KMABMDHMDOF> outputId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40002B1")]
		private TaskAwaiter<DFAHBLOKBPH<OKOMLKNINNF, CKBHMJGLAPL>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000505")]
		[Cpp2IlInjected.Address(RVA = "0x1FEEE40", Offset = "0x1FEDE40", VA = "0x181FEEE40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000506")]
		[Cpp2IlInjected.Address(RVA = "0x1FEF180", Offset = "0x1FEE180", VA = "0x181FEF180", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400028C")]
	private readonly DLILHLIBGCM CPJCBIFJBNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400028D")]
	private readonly FJEIPFCJKKB AMAHMNOIELH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400028E")]
	private readonly BNLAJFLOIDN JPKHPIJHOPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400028F")]
	private readonly AFINNOIBIAO BBBKFKJIMNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000290")]
	private readonly JJJMMGGCKPA CCGIHGHILDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000291")]
	private Dictionary<MFLENLEMIJF<PMIFAKHBGDE>, BHHANIGFAMG> HFKMJKNOKEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000293")]
	[CompilerGenerated]
	private Action<MFLENLEMIJF<PMIFAKHBGDE>>? IOFAHGBDBFI;

	[Cpp2IlInjected.Token(Token = "0x170000B3")]
	public MFLENLEMIJF<EHIJHEMDKLF> OCEGGEFHAPK
	{
		[Cpp2IlInjected.Token(Token = "0x60004AB")]
		[Cpp2IlInjected.Address(RVA = "0x1FE8BC0", Offset = "0x1FE7BC0", VA = "0x181FE8BC0", Slot = "4")]
		get
		{
			return default(MFLENLEMIJF<EHIJHEMDKLF>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B4")]
	public AFINNOIBIAO NDLOBNBBLNJ
	{
		[Cpp2IlInjected.Token(Token = "0x60004AC")]
		[Cpp2IlInjected.Address(RVA = "0x1FB4820", Offset = "0x1FB3820", VA = "0x181FB4820", Slot = "5")]
		get
		{
			return default(AFINNOIBIAO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004AD")]
	[Cpp2IlInjected.Address(RVA = "0x1FEB140", Offset = "0x1FEA140", VA = "0x181FEB140")]
	public OIBHFGOJEEN(DLILHLIBGCM OPKEKBBFIHG, FJEIPFCJKKB BPOAMAKEJBM, BNLAJFLOIDN ADMGDGBIJKC, JJJMMGGCKPA AKCHBKJDFOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004AE")]
	[Cpp2IlInjected.Address(RVA = "0x1FE84D0", Offset = "0x1FE74D0", VA = "0x181FE84D0", Slot = "46")]
	public BGKDPCAKPBJ<ALJLFFFDPAK> GEPBGHBCFPM(BGKDPCAKPBJ<EHIJHEMDKLF> GFIFEILMJAD, BGKDPCAKPBJ<BLEKLEBBJEP> IMIBEIBKNDL)
	{
		return default(BGKDPCAKPBJ<ALJLFFFDPAK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004AF")]
	[Cpp2IlInjected.Address(RVA = "0x1FE9600", Offset = "0x1FE8600", VA = "0x181FE9600", Slot = "47")]
	public BGKDPCAKPBJ<DNOPJNGOIKD> JJGCCIGAILB(BGKDPCAKPBJ<EHIJHEMDKLF> GFIFEILMJAD, BGKDPCAKPBJ<LMEADFHGDCP> GPBEODKKKPJ)
	{
		return default(BGKDPCAKPBJ<DNOPJNGOIKD>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004B0")]
	[Cpp2IlInjected.Address(RVA = "0x1FE7B30", Offset = "0x1FE6B30", VA = "0x181FE7B30", Slot = "6")]
	public (bool, bool) FNCMOLBMHHJ(BGKDPCAKPBJ<EHIJHEMDKLF> GFIFEILMJAD, BGKDPCAKPBJ<LMEADFHGDCP> IKFLPLKDBHA, BGKDPCAKPBJ<BLEKLEBBJEP> MENIIPDDBJO)
	{
		return default((bool, bool));
	}

	[Cpp2IlInjected.Token(Token = "0x60004B1")]
	[Cpp2IlInjected.Address(RVA = "0x1FE92B0", Offset = "0x1FE82B0", VA = "0x181FE92B0")]
	public bool JFHBLMBFEKH(BGKDPCAKPBJ<EHIJHEMDKLF> GFIFEILMJAD, [In] CCOOMODFCBM CMEEBKIKDNF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004B2")]
	[Cpp2IlInjected.Address(RVA = "0x1FE7A30", Offset = "0x1FE6A30", VA = "0x181FE7A30", Slot = "8")]
	public bool FHLGCGKJPNH(HADENNIHHJO KGEPHIGIPOJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004B3")]
	[Cpp2IlInjected.Address(RVA = "0x1FE9870", Offset = "0x1FE8870", VA = "0x181FE9870", Slot = "9")]
	public bool KANPLGAHCKJ(BKHHEMNGJNC HGHKMBPMOAO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004B4")]
	[Cpp2IlInjected.Address(RVA = "0x1FE6830", Offset = "0x1FE5830", VA = "0x181FE6830", Slot = "10")]
	public IEnumerable<BGKDPCAKPBJ<GOIGCNELGDH>> AKFNNAJNIIO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004B5")]
	[Cpp2IlInjected.Address(RVA = "0x1FE8F60", Offset = "0x1FE7F60", VA = "0x181FE8F60", Slot = "11")]
	public string IENLOFNMIJN(BGKDPCAKPBJ<GOIGCNELGDH> MKFHBDCFMAH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004B6")]
	[Cpp2IlInjected.Address(RVA = "0x1FEA220", Offset = "0x1FE9220", VA = "0x181FEA220", Slot = "12")]
	public string LHKJPOCDGEE(BGKDPCAKPBJ<GOIGCNELGDH> MKFHBDCFMAH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004B7")]
	[Cpp2IlInjected.Address(RVA = "0x1FE9040", Offset = "0x1FE8040", VA = "0x181FE9040")]
	public BHHANIGFAMG? IONCAPDFAJD([In] MFLENLEMIJF<PMIFAKHBGDE> GODNEBGANDJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004B8")]
	[Cpp2IlInjected.Address(RVA = "0x1FE77D0", Offset = "0x1FE67D0", VA = "0x181FE77D0")]
	public BGKDPCAKPBJ<PMIFAKHBGDE> EEFDFDFFMGH(BGKDPCAKPBJ<EHIJHEMDKLF> GFIFEILMJAD, [In] MFLENLEMIJF<PMIFAKHBGDE> MEAECMPPEMH)
	{
		return default(BGKDPCAKPBJ<PMIFAKHBGDE>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004B9")]
	[Cpp2IlInjected.Address(RVA = "0x1FEA480", Offset = "0x1FE9480", VA = "0x181FEA480", Slot = "24")]
	public BGKDPCAKPBJ<PMIFAKHBGDE> MBAPBBGDMKM(BGKDPCAKPBJ<EHIJHEMDKLF> GFIFEILMJAD, BGKDPCAKPBJ<BLEKLEBBJEP> IMIBEIBKNDL)
	{
		return default(BGKDPCAKPBJ<PMIFAKHBGDE>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004BA")]
	[Cpp2IlInjected.Address(RVA = "0x1FE6A20", Offset = "0x1FE5A20", VA = "0x181FE6A20", Slot = "25")]
	public BGKDPCAKPBJ<PMIFAKHBGDE> BEJPFLDGIKH(BGKDPCAKPBJ<EHIJHEMDKLF> GFIFEILMJAD, BGKDPCAKPBJ<LMEADFHGDCP> GPBEODKKKPJ)
	{
		return default(BGKDPCAKPBJ<PMIFAKHBGDE>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004BB")]
	[Cpp2IlInjected.Address(RVA = "0x1FE8C20", Offset = "0x1FE7C20", VA = "0x181FE8C20")]
	private void HLKECHIABEJ(MFLENLEMIJF<PMIFAKHBGDE> GODNEBGANDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004BC")]
	[Cpp2IlInjected.Address(RVA = "0x1FE9140", Offset = "0x1FE8140", VA = "0x181FE9140")]
	public IEnumerable<BHHANIGFAMG> JBBEIHKOINE([In] MFLENLEMIJF<EHIJHEMDKLF> GFIFEILMJAD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004BD")]
	[Cpp2IlInjected.Address(RVA = "0x1FEA500", Offset = "0x1FE9500", VA = "0x181FEA500", Slot = "23")]
	public BGKDPCAKPBJ<BLEKLEBBJEP> MCKPMOAMJAE(BGKDPCAKPBJ<EHIJHEMDKLF> GFIFEILMJAD, BGKDPCAKPBJ<PMIFAKHBGDE> GODNEBGANDJ, BGKDPCAKPBJ<ALJLFFFDPAK> MHMEGHMBDAL)
	{
		return default(BGKDPCAKPBJ<BLEKLEBBJEP>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004BE")]
	[Cpp2IlInjected.Address(RVA = "0x1FE9220", Offset = "0x1FE8220", VA = "0x181FE9220", Slot = "26")]
	public BGKDPCAKPBJ<LMEADFHGDCP> JEFGDOOIPEO(BGKDPCAKPBJ<EHIJHEMDKLF> GFIFEILMJAD, BGKDPCAKPBJ<PMIFAKHBGDE> GODNEBGANDJ, BGKDPCAKPBJ<DNOPJNGOIKD> FCPCFFHNMNC)
	{
		return default(BGKDPCAKPBJ<LMEADFHGDCP>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004BF")]
	[Cpp2IlInjected.Address(RVA = "0x1FEA7B0", Offset = "0x1FE97B0", VA = "0x181FEA7B0")]
	private BHHANIGFAMG? MPBHGNMMDAD([In] MFLENLEMIJF<PMIFAKHBGDE> GODNEBGANDJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004C0")]
	[Cpp2IlInjected.Address(RVA = "0x1FE68E0", Offset = "0x1FE58E0", VA = "0x181FE68E0")]
	private BHHANIGFAMG AKGMMLGFEHM([In] MFLENLEMIJF<PMIFAKHBGDE> GODNEBGANDJ, EMGONNJLBBJ OHDOOCGHDGN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004C1")]
	[Cpp2IlInjected.Address(RVA = "0x1FEAEE0", Offset = "0x1FE9EE0", VA = "0x181FEAEE0")]
	public EMGONNJLBBJ? OGNPEENIPKP([In] MFLENLEMIJF<PMIFAKHBGDE> GODNEBGANDJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004C2")]
	[Cpp2IlInjected.Address(RVA = "0x1FE8690", Offset = "0x1FE7690", VA = "0x181FE8690")]
	public GCFIMNCAKMI? PLKAANHBOKD([In] MFLENLEMIJF<EHIJHEMDKLF> GFIFEILMJAD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004C3")]
	[Cpp2IlInjected.Address(RVA = "0x1FE85D0", Offset = "0x1FE75D0", VA = "0x181FE85D0", Slot = "18")]
	public IEnumerable<PFGOCDDNEGH> GLFLHAKCHKO(BGKDPCAKPBJ<EHIJHEMDKLF> GFIFEILMJAD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004C4")]
	[Cpp2IlInjected.Address(RVA = "0x1FEA590", Offset = "0x1FE9590", VA = "0x181FEA590", Slot = "19")]
	public bool MMEEBEBPKEP(BGKDPCAKPBJ<GOIGCNELGDH> MKFHBDCFMAH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004C5")]
	[Cpp2IlInjected.Address(RVA = "0x1FE8940", Offset = "0x1FE7940", VA = "0x181FE8940", Slot = "20")]
	public IEnumerable<CCOOMODFCBM> HKBDBFCJLOP(BGKDPCAKPBJ<EHIJHEMDKLF> GFIFEILMJAD, BGKDPCAKPBJ<LMEADFHGDCP> IKFLPLKDBHA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004C6")]
	[Cpp2IlInjected.Address(RVA = "0x1FE6AA0", Offset = "0x1FE5AA0", VA = "0x181FE6AA0", Slot = "21")]
	public IEnumerable<CCOOMODFCBM> BLLAIPPCJMM(BGKDPCAKPBJ<EHIJHEMDKLF> GFIFEILMJAD, BGKDPCAKPBJ<BLEKLEBBJEP> MENIIPDDBJO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004C7")]
	[Cpp2IlInjected.Address(RVA = "0x1FE7AB0", Offset = "0x1FE6AB0", VA = "0x181FE7AB0")]
	public BGKDPCAKPBJ<EHIJHEMDKLF> FNPOMIGIJHO([In] MFLENLEMIJF<EHIJHEMDKLF> GFIFEILMJAD)
	{
		return default(BGKDPCAKPBJ<EHIJHEMDKLF>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004C8")]
	[Cpp2IlInjected.Address(RVA = "0x1FE8CB0", Offset = "0x1FE7CB0", VA = "0x181FE8CB0")]
	public BGKDPCAKPBJ<EHIJHEMDKLF>? KCKGKEIBOGC([In] MFLENLEMIJF<EHIJHEMDKLF> GFIFEILMJAD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004C9")]
	[Cpp2IlInjected.Address(RVA = "0x1FE98F0", Offset = "0x1FE88F0", VA = "0x181FE98F0")]
	private DFHKAHJLJKC? KEPIKKFGOLC([In] MFLENLEMIJF<EHIJHEMDKLF> GFIFEILMJAD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004CA")]
	[Cpp2IlInjected.Address(RVA = "0x1FE8690", Offset = "0x1FE7690", VA = "0x181FE8690")]
	private GCFIMNCAKMI? GMICBOMDNLG([In] MFLENLEMIJF<EHIJHEMDKLF> GFIFEILMJAD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004CB")]
	[Cpp2IlInjected.Address(RVA = "0x1FE69B0", Offset = "0x1FE59B0", VA = "0x181FE69B0", Slot = "30")]
	public MFLENLEMIJF<EHIJHEMDKLF> AMJFNIMELJL(BGKDPCAKPBJ<EHIJHEMDKLF> GFIFEILMJAD)
	{
		return default(MFLENLEMIJF<EHIJHEMDKLF>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004CC")]
	[Cpp2IlInjected.Address(RVA = "0x1FEA380", Offset = "0x1FE9380", VA = "0x181FEA380", Slot = "27")]
	public IEnumerable<IDGADJBCIPI> LOBCDPKNNBH(GMJJODJAHPH NEGEGDLHJMJ, bool JCKMKHJBIDL, bool HJAFCFPIHFL, bool GIMHGPJFBLH, bool FDGFLNNINAE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004CD")]
	[Cpp2IlInjected.Address(RVA = "0x1FEA800", Offset = "0x1FE9800", VA = "0x181FEA800", Slot = "28")]
	public IDGADJBCIPI NKIMNFFIKMB(GMJJODJAHPH NEGEGDLHJMJ, FDIFHNPIPOF HLCDAFEKLAL, bool JCKMKHJBIDL, bool HJAFCFPIHFL, bool GIMHGPJFBLH, bool FDGFLNNINAE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004CE")]
	[Cpp2IlInjected.Address(RVA = "0x1FE6DA0", Offset = "0x1FE5DA0", VA = "0x181FE6DA0")]
	public PFGOCDDNEGH FKDAGCMLFOL(BGKDPCAKPBJ<EHIJHEMDKLF> GFIFEILMJAD, [In] CCOOMODFCBM CMEEBKIKDNF)
	{
		return default(PFGOCDDNEGH);
	}

	[Cpp2IlInjected.Token(Token = "0x60004CF")]
	[Cpp2IlInjected.Address(RVA = "0x1FE8D30", Offset = "0x1FE7D30", VA = "0x181FE8D30", Slot = "31")]
	public CCOOMODFCBM HPMJCJHHNLE(BGKDPCAKPBJ<EHIJHEMDKLF> GFIFEILMJAD, BGKDPCAKPBJ<LMEADFHGDCP> IKFLPLKDBHA, BGKDPCAKPBJ<BLEKLEBBJEP> MENIIPDDBJO)
	{
		return default(CCOOMODFCBM);
	}

	[Cpp2IlInjected.Token(Token = "0x60004D0")]
	[Cpp2IlInjected.Address(RVA = "0x1FE7850", Offset = "0x1FE6850", VA = "0x181FE7850", Slot = "32")]
	public bool EIKFICEHAHE(BGKDPCAKPBJ<EHIJHEMDKLF> GFIFEILMJAD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004D1")]
	[Cpp2IlInjected.Address(RVA = "0x1FE8550", Offset = "0x1FE7550", VA = "0x181FE8550", Slot = "33")]
	public bool GHIECJGCACL(BGKDPCAKPBJ<EHIJHEMDKLF> GFIFEILMJAD, BGKDPCAKPBJ<BLEKLEBBJEP> IMIBEIBKNDL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004D2")]
	[Cpp2IlInjected.Address(RVA = "0x1FE6D20", Offset = "0x1FE5D20", VA = "0x181FE6D20", Slot = "34")]
	public bool CBECAKCACAG(BGKDPCAKPBJ<EHIJHEMDKLF> GFIFEILMJAD, BGKDPCAKPBJ<LMEADFHGDCP> GPBEODKKKPJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004D3")]
	[Cpp2IlInjected.Address(RVA = "0x1FE75E0", Offset = "0x1FE65E0", VA = "0x181FE75E0")]
	public DFAHBLOKBPH<OIBAKLEHGAH.HMCBNEIEENK, NMADAPLGOEB> FOOGOHJKFKO([In] OIBAKLEHGAH.LCMCGOALKGM DJNIHGJAOCO)
	{
		return default(DFAHBLOKBPH<OIBAKLEHGAH.HMCBNEIEENK, NMADAPLGOEB>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004D4")]
	[Cpp2IlInjected.Address(RVA = "0x1FEA680", Offset = "0x1FE9680", VA = "0x181FEA680", Slot = "36")]
	[AsyncStateMachine(typeof(EMILLLFDMCO))]
	public Task<DFAHBLOKBPH<OKOMLKNINNF, CKBHMJGLAPL>> MOAGKKNODBI(BGKDPCAKPBJ<EHIJHEMDKLF> GFIFEILMJAD, BGKDPCAKPBJ<LMEADFHGDCP> IKFLPLKDBHA, BGKDPCAKPBJ<BLEKLEBBJEP> MENIIPDDBJO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004D5")]
	[Cpp2IlInjected.Address(RVA = "0x1FEAAF0", Offset = "0x1FE9AF0", VA = "0x181FEAAF0", Slot = "37")]
	public DFAHBLOKBPH<KKMPFKFDEHN, GFEHMFEELCO> NNEEHLIKLEM(MFLENLEMIJF<EHIJHEMDKLF> GFIFEILMJAD, KKMPFKFDEHN CMFDIOODAJB, DLLFCGBFLBH JOODGLKBLJO)
	{
		return default(DFAHBLOKBPH<KKMPFKFDEHN, GFEHMFEELCO>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004D6")]
	[Cpp2IlInjected.Address(RVA = "0x1FE7670", Offset = "0x1FE6670", VA = "0x181FE7670", Slot = "38")]
	[AsyncStateMachine(typeof(BLDIAADCJGD))]
	public Task<DFAHBLOKBPH<OKOMLKNINNF, CKBHMJGLAPL>> DKILCMMHLEG(MFLENLEMIJF<EHIJHEMDKLF> GFIFEILMJAD, MFLENLEMIJF<PMIFAKHBGDE> KNIGNAFHCPF, BGKDPCAKPBJ<IHOAGKINOHG> OCFJEMOHHEF, BGKDPCAKPBJ<HONMIPKGKFA> IMIBEIBKNDL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004D7")]
	[Cpp2IlInjected.Address(RVA = "0x1FE66D0", Offset = "0x1FE56D0", VA = "0x181FE66D0", Slot = "39")]
	[AsyncStateMachine(typeof(HMOOLFJPBBD))]
	public Task<DFAHBLOKBPH<OKOMLKNINNF, CKBHMJGLAPL>> ACKOFCEPADB(MFLENLEMIJF<EHIJHEMDKLF> GFIFEILMJAD, MFLENLEMIJF<PMIFAKHBGDE> KBCGGIGLCBB, BGKDPCAKPBJ<IHOAGKINOHG> OLPJHMPMEPI, BGKDPCAKPBJ<KMABMDHMDOF> GPBEODKKKPJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004D8")]
	[Cpp2IlInjected.Address(RVA = "0x1FE9680", Offset = "0x1FE8680", VA = "0x181FE9680", Slot = "40")]
	public CJBJOPCDJDC KAEOHHCGDFA(IEnumerable<ENFIPLJHHAN> NIMIEHKGAPI)
	{
		return default(CJBJOPCDJDC);
	}

	[Cpp2IlInjected.Token(Token = "0x60004D9")]
	[Cpp2IlInjected.Address(RVA = "0x1FE86C0", Offset = "0x1FE76C0", VA = "0x181FE86C0", Slot = "41")]
	public CJBJOPCDJDC HAFMGKDOBEN()
	{
		return default(CJBJOPCDJDC);
	}

	[Cpp2IlInjected.Token(Token = "0x60004DA")]
	[Cpp2IlInjected.Address(RVA = "0x1FE9D30", Offset = "0x1FE8D30", VA = "0x181FE9D30")]
	private NMEOLNOBIKL KMMIOEAJIEO(IPJBDCHEGJH PCFGGPLJIPA, BGKDPCAKPBJ<EHIJHEMDKLF> NFAGKHAOKNB, IEnumerable<MFLENLEMIJF<EHIJHEMDKLF>> DBJDPEIPMJM, IEnumerable<MFLENLEMIJF<PMIFAKHBGDE>> DKDGNHMNBAJ)
	{
		return default(NMEOLNOBIKL);
	}

	[Cpp2IlInjected.Token(Token = "0x60004DB")]
	[Cpp2IlInjected.Address(RVA = "0x1FE9EE0", Offset = "0x1FE8EE0", VA = "0x181FE9EE0", Slot = "42")]
	public NMEOLNOBIKL KMMIOEAJIEO(IPJBDCHEGJH PCFGGPLJIPA, BGKDPCAKPBJ<EHIJHEMDKLF> NFAGKHAOKNB, IEnumerable<MFLENLEMIJF<PMIFAKHBGDE>> DKDGNHMNBAJ, IEnumerable<ENFIPLJHHAN> NIMIEHKGAPI)
	{
		return default(NMEOLNOBIKL);
	}

	[Cpp2IlInjected.Token(Token = "0x60004DC")]
	[Cpp2IlInjected.Address(RVA = "0x1FE99B0", Offset = "0x1FE89B0", VA = "0x181FE99B0")]
	private static IEnumerable<MFLENLEMIJF<EHIJHEMDKLF>> KGHHGMAAACH(IEnumerable<ENFIPLJHHAN> NIMIEHKGAPI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004DD")]
	[Cpp2IlInjected.Address(RVA = "0x1FE8030", Offset = "0x1FE7030", VA = "0x181FE8030")]
	private IEnumerable<MFLENLEMIJF<PMIFAKHBGDE>> FPMGGCEJIHE(IEnumerable<ENFIPLJHHAN> NIMIEHKGAPI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004DE")]
	[Cpp2IlInjected.Address(RVA = "0x1FE78C0", Offset = "0x1FE68C0", VA = "0x181FE78C0", Slot = "43")]
	public List<CBAEBFNJEIL> FCPNLBNNBDO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004DF")]
	[Cpp2IlInjected.Address(RVA = "0x1FE6F10", Offset = "0x1FE5F10", VA = "0x181FE6F10")]
	public (List<CBAEBFNJEIL>, bool) CLEHNBAIPLH([In] OBDNKBLAGKE LPPKMOPBGHD, string PDLLDMABKGP, [In] FAECHCHMHFD NLNMGDFLGFL, IHCHAEAAJPO JADHBKIHHOD, CKAILMOBALD NEPGFLKHNMN)
	{
		return default((List<CBAEBFNJEIL>, bool));
	}

	[Cpp2IlInjected.Token(Token = "0x60004E0")]
	[Cpp2IlInjected.Address(RVA = "0x1FEB050", Offset = "0x1FEA050", VA = "0x181FEB050", Slot = "45")]
	public bool PFNHPCAJOGK(BGKDPCAKPBJ<EHIJHEMDKLF> GFIFEILMJAD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004E1")]
	[Cpp2IlInjected.Address(RVA = "0x1FE7610", Offset = "0x1FE6610", VA = "0x181FE7610")]
	internal void DFGJIDNKFNC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E2")]
	[Cpp2IlInjected.Address(RVA = "0x1FE7950", Offset = "0x1FE6950", VA = "0x181FE7950")]
	internal Task FEEFBKLAACD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E3")]
	[Cpp2IlInjected.Address(RVA = "0x1FEA7F0", Offset = "0x1FE97F0", VA = "0x181FEA7F0", Slot = "7")]
	private bool NFAJPAHAHKC(BGKDPCAKPBJ<EHIJHEMDKLF> GFIFEILMJAD, [In] CCOOMODFCBM CMEEBKIKDNF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004E4")]
	[Cpp2IlInjected.Address(RVA = "0x1FE8690", Offset = "0x1FE7690", VA = "0x181FE8690", Slot = "13")]
	private GCFIMNCAKMI MANBCOKEFAI([In] MFLENLEMIJF<EHIJHEMDKLF> GFIFEILMJAD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E5")]
	[Cpp2IlInjected.Address(RVA = "0x1FE7AB0", Offset = "0x1FE6AB0", VA = "0x181FE7AB0", Slot = "14")]
	private BGKDPCAKPBJ<EHIJHEMDKLF> FKFJADJHNKL([In] MFLENLEMIJF<EHIJHEMDKLF> GFIFEILMJAD)
	{
		return default(BGKDPCAKPBJ<EHIJHEMDKLF>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004E6")]
	[Cpp2IlInjected.Address(RVA = "0x1FE8CB0", Offset = "0x1FE7CB0", VA = "0x181FE8CB0", Slot = "15")]
	private BGKDPCAKPBJ<EHIJHEMDKLF>? HPHBAMFLCPE([In] MFLENLEMIJF<EHIJHEMDKLF> GFIFEILMJAD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E7")]
	[Cpp2IlInjected.Address(RVA = "0x1FE87E0", Offset = "0x1FE77E0", VA = "0x181FE87E0", Slot = "16")]
	private BHHANIGFAMG HFHJOMBGFGE([In] MFLENLEMIJF<PMIFAKHBGDE> GODNEBGANDJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E8")]
	[Cpp2IlInjected.Address(RVA = "0x1FE77D0", Offset = "0x1FE67D0", VA = "0x181FE77D0", Slot = "17")]
	private BGKDPCAKPBJ<PMIFAKHBGDE> KOBCNBBDBOP(BGKDPCAKPBJ<EHIJHEMDKLF> GFIFEILMJAD, [In] MFLENLEMIJF<PMIFAKHBGDE> MEAECMPPEMH)
	{
		return default(BGKDPCAKPBJ<PMIFAKHBGDE>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004E9")]
	[Cpp2IlInjected.Address(RVA = "0x1FEAF70", Offset = "0x1FE9F70", VA = "0x181FEAF70", Slot = "22")]
	private IEnumerable<BHHANIGFAMG> OOAONDPPPED([In] MFLENLEMIJF<EHIJHEMDKLF> GFIFEILMJAD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004EA")]
	[Cpp2IlInjected.Address(RVA = "0x1FE6DA0", Offset = "0x1FE5DA0", VA = "0x181FE6DA0", Slot = "29")]
	private PFGOCDDNEGH CFFEGOAJBMP(BGKDPCAKPBJ<EHIJHEMDKLF> GFIFEILMJAD, [In] CCOOMODFCBM CMEEBKIKDNF)
	{
		return default(PFGOCDDNEGH);
	}

	[Cpp2IlInjected.Token(Token = "0x60004EB")]
	[Cpp2IlInjected.Address(RVA = "0x1FE75E0", Offset = "0x1FE65E0", VA = "0x181FE75E0", Slot = "35")]
	private DFAHBLOKBPH<OIBAKLEHGAH.HMCBNEIEENK, NMADAPLGOEB> COPIPDJDAFJ([In] OIBAKLEHGAH.LCMCGOALKGM DJNIHGJAOCO)
	{
		return default(DFAHBLOKBPH<OIBAKLEHGAH.HMCBNEIEENK, NMADAPLGOEB>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004EC")]
	[Cpp2IlInjected.Address(RVA = "0x1FEA620", Offset = "0x1FE9620", VA = "0x181FEA620", Slot = "44")]
	private (List<CBAEBFNJEIL>, bool) MMHIKGIJJJJ([In] OBDNKBLAGKE LPPKMOPBGHD, string PDLLDMABKGP, [In] FAECHCHMHFD NLNMGDFLGFL, IHCHAEAAJPO JADHBKIHHOD, CKAILMOBALD NEPGFLKHNMN)
	{
		return default((List<CBAEBFNJEIL>, bool));
	}

	[Cpp2IlInjected.Token(Token = "0x60004ED")]
	[Cpp2IlInjected.Address(RVA = "0x1FEA290", Offset = "0x1FE9290", VA = "0x181FEA290")]
	[CompilerGenerated]
	private BHHANIGFAMG LJMINMMLKMD(EMGONNJLBBJ GGJGGMKAJPM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004EE")]
	[Cpp2IlInjected.Address(RVA = "0x1FE79B0", Offset = "0x1FE69B0", VA = "0x181FE79B0")]
	[CompilerGenerated]
	private BHIABPKGOLC FFNEBKEGKDG(PPILJEFFHKO GGJGGMKAJPM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004EF")]
	[Cpp2IlInjected.Address(RVA = "0x1FE8FD0", Offset = "0x1FE7FD0", VA = "0x181FE8FD0")]
	[CompilerGenerated]
	private EMGONNJLBBJ ILINADIHKGL(MFLENLEMIJF<PMIFAKHBGDE> GGJGGMKAJPM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F0")]
	[Cpp2IlInjected.Address(RVA = "0x1FE88D0", Offset = "0x1FE78D0", VA = "0x181FE88D0")]
	[CompilerGenerated]
	private DFHKAHJLJKC HIIEDMFEDBE(MFLENLEMIJF<EHIJHEMDKLF> GGJGGMKAJPM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D3")]
public sealed class BHIABPKGOLC : IDGADJBCIPI
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000D4")]
	[CompilerGenerated]
	private struct OLPICJCMAPE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002B5")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002B6")]
		public AsyncTaskMethodBuilder<DFAHBLOKBPH<BGKDPCAKPBJ<HFFNHINIHLD>, CKBHMJGLAPL>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002B7")]
		public BHIABPKGOLC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002B8")]
		public MFLENLEMIJF<EHIJHEMDKLF> graphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002B9")]
		public MFLENLEMIJF<PMIFAKHBGDE> nodeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002BA")]
		public BGKDPCAKPBJ<IHOAGKINOHG> portGroupId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40002BB")]
		public string name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40002BC")]
		private TaskAwaiter<DFAHBLOKBPH<BGKDPCAKPBJ<HFFNHINIHLD>, CKBHMJGLAPL>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600050D")]
		[Cpp2IlInjected.Address(RVA = "0x1FF1BB0", Offset = "0x1FF0BB0", VA = "0x181FF1BB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600050E")]
		[Cpp2IlInjected.Address(RVA = "0x1FF1E30", Offset = "0x1FF0E30", VA = "0x181FF1E30", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000D5")]
	[CompilerGenerated]
	private struct FKLJKAJNEPD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002BD")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002BE")]
		public AsyncTaskMethodBuilder<DFAHBLOKBPH<BGKDPCAKPBJ<MBMIEFKCJNG>, CKBHMJGLAPL>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002BF")]
		public BHIABPKGOLC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002C0")]
		public MFLENLEMIJF<EHIJHEMDKLF> graphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002C1")]
		public MFLENLEMIJF<PMIFAKHBGDE> nodeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002C2")]
		public BGKDPCAKPBJ<IHOAGKINOHG> portGroupId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40002C3")]
		public string name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40002C4")]
		private TaskAwaiter<DFAHBLOKBPH<BGKDPCAKPBJ<MBMIEFKCJNG>, CKBHMJGLAPL>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600050F")]
		[Cpp2IlInjected.Address(RVA = "0x1FEE940", Offset = "0x1FED940", VA = "0x181FEE940", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000510")]
		[Cpp2IlInjected.Address(RVA = "0x1FEEBC0", Offset = "0x1FEDBC0", VA = "0x181FEEBC0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002B2")]
	private readonly PPILJEFFHKO LFKPFAELHOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002B3")]
	private readonly FJEIPFCJKKB AMAHMNOIELH;

	[Cpp2IlInjected.Token(Token = "0x170000B5")]
	public TypeKey EOBEHPKDOGC
	{
		[Cpp2IlInjected.Token(Token = "0x6000508")]
		[Cpp2IlInjected.Address(RVA = "0x9ABFE0", Offset = "0x9AAFE0", VA = "0x1809ABFE0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(TypeKey);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B6")]
	public string BFNOOLGOHAC
	{
		[Cpp2IlInjected.Token(Token = "0x6000509")]
		[Cpp2IlInjected.Address(RVA = "0x1FEE400", Offset = "0x1FED400", VA = "0x181FEE400", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B7")]
	public PPILJEFFHKO EPGPKPDGGDH
	{
		[Cpp2IlInjected.Token(Token = "0x600050A")]
		[Cpp2IlInjected.Address(RVA = "0x8518C0", Offset = "0x8508C0", VA = "0x1808518C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000507")]
	[Cpp2IlInjected.Address(RVA = "0x1FEE430", Offset = "0x1FED430", VA = "0x181FEE430")]
	public BHIABPKGOLC(PPILJEFFHKO EBMBGLOIJOC, FJEIPFCJKKB BPOAMAKEJBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600050B")]
	[Cpp2IlInjected.Address(RVA = "0x1FEE120", Offset = "0x1FED120", VA = "0x181FEE120", Slot = "6")]
	[AsyncStateMachine(typeof(OLPICJCMAPE))]
	public Task<DFAHBLOKBPH<BGKDPCAKPBJ<HFFNHINIHLD>, CKBHMJGLAPL>> DAFLGNOECML(MFLENLEMIJF<EHIJHEMDKLF> GFIFEILMJAD, MFLENLEMIJF<PMIFAKHBGDE> GODNEBGANDJ, BGKDPCAKPBJ<IHOAGKINOHG> FCFGPBAFAPA, string CKEJJGPNKGO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600050C")]
	[Cpp2IlInjected.Address(RVA = "0x1FEE290", Offset = "0x1FED290", VA = "0x181FEE290", Slot = "7")]
	[AsyncStateMachine(typeof(FKLJKAJNEPD))]
	public Task<DFAHBLOKBPH<BGKDPCAKPBJ<MBMIEFKCJNG>, CKBHMJGLAPL>> FJMLBEHBGFC(MFLENLEMIJF<EHIJHEMDKLF> GFIFEILMJAD, MFLENLEMIJF<PMIFAKHBGDE> GODNEBGANDJ, BGKDPCAKPBJ<IHOAGKINOHG> FCFGPBAFAPA, string CKEJJGPNKGO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D6")]
public sealed class NHMECIJIBNC : IAEEJDHFOGP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002C5")]
	private readonly PPILJEFFHKO HKOHEKBCCKM;

	[Cpp2IlInjected.Token(Token = "0x40002C6")]
	private static readonly HashSet<PPILJEFFHKO> JIMBFLDFKPG;

	[Cpp2IlInjected.Token(Token = "0x40002C7")]
	private static readonly HashSet<PPILJEFFHKO> IPMJDHDIPPJ;

	[Cpp2IlInjected.Token(Token = "0x40002C8")]
	private static readonly HashSet<PPILJEFFHKO> PCJIJDHOIAL;

	[Cpp2IlInjected.Token(Token = "0x170000B8")]
	public TypeKey NAKCNJCFEHA
	{
		[Cpp2IlInjected.Token(Token = "0x6000511")]
		[Cpp2IlInjected.Address(RVA = "0x1FF19E0", Offset = "0x1FF09E0", VA = "0x181FF19E0", Slot = "6")]
		get
		{
			return default(TypeKey);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B9")]
	public bool BJDGBJHFCNC
	{
		[Cpp2IlInjected.Token(Token = "0x6000512")]
		[Cpp2IlInjected.Address(RVA = "0x1FF19D0", Offset = "0x1FF09D0", VA = "0x181FF19D0", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BA")]
	public bool OODPOAPGHGH
	{
		[Cpp2IlInjected.Token(Token = "0x6000516")]
		[Cpp2IlInjected.Address(RVA = "0x1FF1A30", Offset = "0x1FF0A30", VA = "0x181FF1A30", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BB")]
	public bool AABLEEMEMCH
	{
		[Cpp2IlInjected.Token(Token = "0x6000517")]
		[Cpp2IlInjected.Address(RVA = "0x1FF1950", Offset = "0x1FF0950", VA = "0x181FF1950", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000513")]
	[Cpp2IlInjected.Address(RVA = "0x1FF05F0", Offset = "0x1FEF5F0", VA = "0x181FF05F0")]
	public bool CAHLEGDMAGH(string JJCEIJMGOAB, [Out] HFFKEOCOCOF MIDACIPKCOI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000514")]
	[Cpp2IlInjected.Address(RVA = "0x858C30", Offset = "0x857C30", VA = "0x180858C30")]
	public NHMECIJIBNC(PPILJEFFHKO OEFGKJLECGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000515")]
	[Cpp2IlInjected.Address(RVA = "0x1FF0460", Offset = "0x1FEF460", VA = "0x181FF0460")]
	internal static TypeKey AEMGIPBGDJL(PPILJEFFHKO HNGLFCFOHLI)
	{
		return default(TypeKey);
	}

	[Cpp2IlInjected.Token(Token = "0x6000518")]
	[Cpp2IlInjected.Address(RVA = "0x1FEE400", Offset = "0x1FED400", VA = "0x181FEE400", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000D7")]
public readonly struct BOBFOCEMACP : BEHAKNDEKHC.FEJJICLFGLD<LJHEBKBBECA, OKOMLKNINNF>
{
	[Cpp2IlInjected.Token(Token = "0x600051A")]
	[Cpp2IlInjected.Address(RVA = "0x1FEE5A0", Offset = "0x1FED5A0", VA = "0x181FEE5A0", Slot = "4")]
	public int NEAFFGOCCCG(OKOMLKNINNF PGMBMLICCAI, LJHEBKBBECA JFOAFIPDIOA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600051B")]
	[Cpp2IlInjected.Address(RVA = "0x1FEE580", Offset = "0x1FED580", VA = "0x181FEE580", Slot = "5")]
	public LJHEBKBBECA MJFBIHKLOPF(OKOMLKNINNF PGMBMLICCAI, LJHEBKBBECA JFOAFIPDIOA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600051C")]
	[Cpp2IlInjected.Address(RVA = "0x1FEE550", Offset = "0x1FED550", VA = "0x181FEE550", Slot = "6")]
	public LJHEBKBBECA LIBHGGLDGNJ(OKOMLKNINNF PGMBMLICCAI, LJHEBKBBECA JFOAFIPDIOA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600051D")]
	[Cpp2IlInjected.Address(RVA = "0x1FEE5E0", Offset = "0x1FED5E0", VA = "0x181FEE5E0", Slot = "7")]
	public IReadOnlyList<LJHEBKBBECA> ONPLNENAKIA(OKOMLKNINNF PGMBMLICCAI, LJHEBKBBECA JFOAFIPDIOA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600051E")]
	[Cpp2IlInjected.Address(RVA = "0x1FEE590", Offset = "0x1FED590", VA = "0x181FEE590", Slot = "8")]
	public LJHEBKBBECA[] MNGOGIGJEDF(OKOMLKNINNF PGMBMLICCAI, LJHEBKBBECA JFOAFIPDIOA, int FFDAJIKOHDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600051F")]
	[Cpp2IlInjected.Address(RVA = "0x1FEE530", Offset = "0x1FED530", VA = "0x181FEE530", Slot = "9")]
	public bool KACKIDCEHPA(OKOMLKNINNF PGMBMLICCAI, LJHEBKBBECA JFOAFIPDIOA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000520")]
	[Cpp2IlInjected.Address(RVA = "0x1FEE510", Offset = "0x1FED510", VA = "0x181FEE510", Slot = "10")]
	public bool HLCKDDNADKF(OKOMLKNINNF PGMBMLICCAI, LJHEBKBBECA JFOAFIPDIOA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000521")]
	[Cpp2IlInjected.Address(RVA = "0x1FEE4D0", Offset = "0x1FED4D0", VA = "0x181FEE4D0", Slot = "11")]
	public bool BLJFBMJPGJN(OKOMLKNINNF PGMBMLICCAI, LJHEBKBBECA JFOAFIPDIOA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000522")]
	[Cpp2IlInjected.Address(RVA = "0x1FEE4F0", Offset = "0x1FED4F0", VA = "0x181FEE4F0", Slot = "12")]
	public bool BPNAPBEIJPE(OKOMLKNINNF PGMBMLICCAI, LJHEBKBBECA JFOAFIPDIOA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000523")]
	[Cpp2IlInjected.Address(RVA = "0x1FEE600", Offset = "0x1FED600", VA = "0x181FEE600", Slot = "13")]
	public bool PMJCBEBMLAL(OKOMLKNINNF KHPBGKMELMP, LJHEBKBBECA JFOAFIPDIOA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000524")]
	[Cpp2IlInjected.Address(RVA = "0x1FEE5C0", Offset = "0x1FED5C0", VA = "0x181FEE5C0", Slot = "14")]
	public bool OECHDOKJCAI(OKOMLKNINNF PGMBMLICCAI, LJHEBKBBECA JFOAFIPDIOA)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D8")]
public abstract class HBIPHFDDCOB : FAPDDLCEKJF
{
	[Cpp2IlInjected.Token(Token = "0x170000BC")]
	public OAJFADDLMBG.BLNFJBPLCOI OKGKGHOKADE
	{
		[Cpp2IlInjected.Token(Token = "0x6000525")]
		[Cpp2IlInjected.Address(RVA = "0x1FEEDA0", Offset = "0x1FEDDA0", VA = "0x181FEEDA0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BD")]
	public abstract NEPEMAJJGFH.DNFLCBHJCIE JPGJEPJPAKA
	{
		[Cpp2IlInjected.Token(Token = "0x6000526")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000BE")]
	public abstract DLILHLIBGCM.PHPPLIBINMB LJIFNGKAHJM
	{
		[Cpp2IlInjected.Token(Token = "0x6000527")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000BF")]
	public abstract NBEHIIBMPBF.IKBJBOPHAJI OCIMDPOAHDJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000528")]
		[Cpp2IlInjected.Address(Slot = "16")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000C0")]
	public CPPIEJKJJPO.PGABJALLGMN<IIDFNFNFGMN, LJHEBKBBECA, DLILHLIBGCM> DKBILLFHCAE
	{
		[Cpp2IlInjected.Token(Token = "0x6000529")]
		[Cpp2IlInjected.Address(RVA = "0x1FEEDF0", Offset = "0x1FEDDF0", VA = "0x181FEEDF0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C1")]
	public abstract DPLHFMKJDOO AOJIMJDEJAC
	{
		[Cpp2IlInjected.Token(Token = "0x600052A")]
		[Cpp2IlInjected.Address(Slot = "17")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000C2")]
	public abstract GADMDCCKLNF GHGLJOHDPEM
	{
		[Cpp2IlInjected.Token(Token = "0x600052B")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000C3")]
	public abstract HPAIHFKBLKJ IGBMLKJIJKF
	{
		[Cpp2IlInjected.Token(Token = "0x600052C")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000C4")]
	public abstract KEGMKMHBKGO PMMKOLDHFDI
	{
		[Cpp2IlInjected.Token(Token = "0x600052D")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000C5")]
	public abstract EIMDDECPHBC GIHDNHJBJMJ
	{
		[Cpp2IlInjected.Token(Token = "0x600052E")]
		[Cpp2IlInjected.Address(Slot = "21")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600052F")]
	[Cpp2IlInjected.Address(RVA = "0x85EB60", Offset = "0x85DB60", VA = "0x18085EB60")]
	protected HBIPHFDDCOB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D9")]
public sealed class IFEMBIKKDON : GPHGMKLHBMD
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000DA")]
	[CompilerGenerated]
	private struct MNDGLIEBKLI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002CA")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002CB")]
		public AsyncTaskMethodBuilder<DFAHBLOKBPH<object, CKBHMJGLAPL>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002CC")]
		public IFEMBIKKDON <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002CD")]
		public LJHEBKBBECA action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002CE")]
		public bool clearBufferedRpcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002CF")]
		private TaskAwaiter<DFAHBLOKBPH<object, CKBHMJGLAPL>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000533")]
		[Cpp2IlInjected.Address(RVA = "0x1FF0150", Offset = "0x1FEF150", VA = "0x181FF0150", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000534")]
		[Cpp2IlInjected.Address(RVA = "0x1FF03F0", Offset = "0x1FEF3F0", VA = "0x181FF03F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000DB")]
	[CompilerGenerated]
	private struct BGKDJPCOIFE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002D0")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002D1")]
		public AsyncTaskMethodBuilder<DFAHBLOKBPH<KADDDLHOCKA, CKBHMJGLAPL>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002D2")]
		public IFEMBIKKDON <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002D3")]
		public IReadOnlyList<LJHEBKBBECA> actions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002D4")]
		public bool clearBufferedRpcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002D5")]
		private TaskAwaiter<DFAHBLOKBPH<object, CKBHMJGLAPL>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000535")]
		[Cpp2IlInjected.Address(RVA = "0x1FEDD30", Offset = "0x1FECD30", VA = "0x181FEDD30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000536")]
		[Cpp2IlInjected.Address(RVA = "0x1FEE0B0", Offset = "0x1FED0B0", VA = "0x181FEE0B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002C9")]
	private readonly IGBBFLOOINI PIGKBJPAHGN;

	[Cpp2IlInjected.Token(Token = "0x6000530")]
	[Cpp2IlInjected.Address(RVA = "0x858C30", Offset = "0x857C30", VA = "0x180858C30")]
	public IFEMBIKKDON(IGBBFLOOINI GBBAAFALICM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000531")]
	[Cpp2IlInjected.Address(RVA = "0x1FEF1F0", Offset = "0x1FEE1F0", VA = "0x181FEF1F0")]
	[AsyncStateMachine(typeof(MNDGLIEBKLI))]
	private Task<DFAHBLOKBPH<object, CKBHMJGLAPL>> DKBJKMAMMMJ(LJHEBKBBECA JFOAFIPDIOA, bool AMHHLKAOAOK = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000532")]
	[Cpp2IlInjected.Address(RVA = "0x1FEF320", Offset = "0x1FEE320", VA = "0x181FEF320", Slot = "4")]
	[AsyncStateMachine(typeof(BGKDJPCOIFE))]
	public Task<DFAHBLOKBPH<KADDDLHOCKA, CKBHMJGLAPL>> LEIEADHJFOI(IReadOnlyList<LJHEBKBBECA> CECLMDMADKH, bool AMHHLKAOAOK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DC")]
public struct GANMBGGMEHJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40002D6")]
	internal JODAHGKHIGK<NEBPGKEABNC, LJHEBKBBECA, LMAMABOMHOL> HKOHEKBCCKM;

	[Cpp2IlInjected.Token(Token = "0x6000537")]
	[Cpp2IlInjected.Address(RVA = "0x1FCAF60", Offset = "0x1FC9F60", VA = "0x181FCAF60")]
	private GANMBGGMEHJ([In] JODAHGKHIGK<NEBPGKEABNC, LJHEBKBBECA, LMAMABOMHOL> CMHKMANEFPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000538")]
	[Cpp2IlInjected.Address(RVA = "0x1FEEC30", Offset = "0x1FEDC30", VA = "0x181FEEC30")]
	public static GANMBGGMEHJ GAKCNKPJGEK()
	{
		return default(GANMBGGMEHJ);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DD")]
public static class KAHPCAJHEAO
{
	[Cpp2IlInjected.Token(Token = "0x6000539")]
	[Cpp2IlInjected.Address(RVA = "0x97DF10", Offset = "0x97CF10", VA = "0x18097DF10")]
	public static JODAHGKHIGK<NEBPGKEABNC, LJHEBKBBECA, LMAMABOMHOL> LJMLCJIBFEC(this GANMBGGMEHJ KALCJEIICGB)
	{
		return default(JODAHGKHIGK<NEBPGKEABNC, LJHEBKBBECA, LMAMABOMHOL>);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000DE")]
public struct LMAMABOMHOL : MGCGLEKEGMJ.FDMABEBONLD<NEBPGKEABNC, LJHEBKBBECA>
{
	[Cpp2IlInjected.Token(Token = "0x600053A")]
	[Cpp2IlInjected.Address(RVA = "0x1FEFF60", Offset = "0x1FEEF60", VA = "0x181FEFF60", Slot = "5")]
	public LJHEBKBBECA CHODIIAOOOB(NEBPGKEABNC[] ODFGEPEOENL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600053B")]
	[Cpp2IlInjected.Address(RVA = "0x1696830", Offset = "0x1695830", VA = "0x181696830")]
	public int APPKNMBAHFA([In] NEBPGKEABNC GDJPJALDDDJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600053C")]
	[Cpp2IlInjected.Address(RVA = "0x1696830", Offset = "0x1695830", VA = "0x181696830", Slot = "4")]
	private int OAIMODBJPNK([In] NEBPGKEABNC CKDLHIGKMND)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E0")]
public struct OJLHMOEKCHO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40002D9")]
	internal ACFKJEJKBHI<JAKDGPEMKPM, LJHEBKBBECA, KONBMLHONNM> HKOHEKBCCKM;

	[Cpp2IlInjected.Token(Token = "0x6000540")]
	[Cpp2IlInjected.Address(RVA = "0x1FCAF60", Offset = "0x1FC9F60", VA = "0x181FCAF60")]
	private OJLHMOEKCHO([In] ACFKJEJKBHI<JAKDGPEMKPM, LJHEBKBBECA, KONBMLHONNM> FIDNOHIDMDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000541")]
	[Cpp2IlInjected.Address(RVA = "0x1FF1B50", Offset = "0x1FF0B50", VA = "0x181FF1B50")]
	public static OJLHMOEKCHO GAKCNKPJGEK()
	{
		return default(OJLHMOEKCHO);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E1")]
public static class NJBJEFKPHGF
{
	[Cpp2IlInjected.Token(Token = "0x6000542")]
	[Cpp2IlInjected.Address(RVA = "0x97DF10", Offset = "0x97CF10", VA = "0x18097DF10")]
	public static ACFKJEJKBHI<JAKDGPEMKPM, LJHEBKBBECA, KONBMLHONNM> LJMLCJIBFEC(this OJLHMOEKCHO KALCJEIICGB)
	{
		return default(ACFKJEJKBHI<JAKDGPEMKPM, LJHEBKBBECA, KONBMLHONNM>);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000E2")]
public struct KONBMLHONNM : BNLGCIGJNKB.PNOMGFGLABG<JAKDGPEMKPM, LJHEBKBBECA>
{
	[Cpp2IlInjected.Token(Token = "0x6000543")]
	[Cpp2IlInjected.Address(RVA = "0x1696830", Offset = "0x1695830", VA = "0x181696830")]
	public int FFKEICBFAAP([In] JAKDGPEMKPM GDJPJALDDDJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000544")]
	[Cpp2IlInjected.Address(RVA = "0x1FEFD70", Offset = "0x1FEED70", VA = "0x181FEFD70", Slot = "5")]
	public LJHEBKBBECA LKBPOFLIODJ(JAKDGPEMKPM[] MCAMIHCICOB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000545")]
	[Cpp2IlInjected.Address(RVA = "0x1696830", Offset = "0x1695830", VA = "0x181696830", Slot = "4")]
	private int ILEKMFJLFBP([In] JAKDGPEMKPM GDJPJALDDDJ)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E4")]
public class DFGMEMCOOLE : DNBIAPHIKOM, NMADAPLGOEB, CKBHMJGLAPL, GFEHMFEELCO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40002DD")]
	private readonly GFEHMFEELCO? FIFLIMOJPLJ;

	[Cpp2IlInjected.Token(Token = "0x170000C6")]
	public AKADJCODKHK LKJKDCPLELI
	{
		[Cpp2IlInjected.Token(Token = "0x6000549")]
		[Cpp2IlInjected.Address(RVA = "0x85BDB0", Offset = "0x85ADB0", VA = "0x18085BDB0", Slot = "13")]
		[CompilerGenerated]
		get
		{
			return default(AKADJCODKHK);
		}
		[Cpp2IlInjected.Token(Token = "0x600054A")]
		[Cpp2IlInjected.Address(RVA = "0x85BDC0", Offset = "0x85ADC0", VA = "0x18085BDC0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C7")]
	public override GFEHMFEELCO? FNKBBKALOCP
	{
		[Cpp2IlInjected.Token(Token = "0x600054B")]
		[Cpp2IlInjected.Address(RVA = "0x854640", Offset = "0x853640", VA = "0x180854640", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600054C")]
	[Cpp2IlInjected.Address(RVA = "0x1FEE690", Offset = "0x1FED690", VA = "0x181FEE690", Slot = "7")]
	public override string DODDKOCHLNI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600054D")]
	[Cpp2IlInjected.Address(RVA = "0x1FEE900", Offset = "0x1FED900", VA = "0x181FEE900")]
	private DFGMEMCOOLE(AKADJCODKHK GKANCDPDLNF, GFEHMFEELCO? PHPAMCLCIHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600054E")]
	[Cpp2IlInjected.Address(RVA = "0x1FEE880", Offset = "0x1FED880", VA = "0x181FEE880")]
	public static DFGMEMCOOLE LJLLIPMLIDC(GFEHMFEELCO PHPAMCLCIHP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600054F")]
	[Cpp2IlInjected.Address(RVA = "0x1FEE810", Offset = "0x1FED810", VA = "0x181FEE810")]
	public static DFGMEMCOOLE IAELNNHBEKD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000550")]
	[Cpp2IlInjected.Address(RVA = "0x1FEE620", Offset = "0x1FED620", VA = "0x181FEE620")]
	public static DFGMEMCOOLE CDNEBBLJPHM()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E5")]
public static class JNPEKJMEGBD
{
	[Cpp2IlInjected.Token(Token = "0x6000551")]
	[Cpp2IlInjected.Address(RVA = "0x2C3FDD0", Offset = "0x2C3EDD0", VA = "0x182C3FDD0")]
	public static DFAHBLOKBPH<TOk, NMADAPLGOEB> DOJMKKPIBKI<TOk>([In] this DFAHBLOKBPH<TOk, NMADAPLGOEB> KALCJEIICGB, GFEHMFEELCO PHPAMCLCIHP) where TOk : notnull
	{
		return default(DFAHBLOKBPH<TOk, NMADAPLGOEB>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000552")]
	[Cpp2IlInjected.Address(RVA = "0x2C3FCD0", Offset = "0x2C3ECD0", VA = "0x182C3FCD0")]
	public static DFAHBLOKBPH<TOk?, NMADAPLGOEB?> DDDFOKDOKKP<TOk>([In] this DFAHBLOKBPH<TOk, NMADAPLGOEB> KALCJEIICGB)
	{
		return default(DFAHBLOKBPH<TOk, NMADAPLGOEB>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000553")]
	[Cpp2IlInjected.Address(RVA = "0x2C3FEB0", Offset = "0x2C3EEB0", VA = "0x182C3FEB0")]
	public static DFAHBLOKBPH<TOk?, NMADAPLGOEB?> FAJJJONBKII<TOk>([In] this DFAHBLOKBPH<TOk, NMADAPLGOEB> KALCJEIICGB)
	{
		return default(DFAHBLOKBPH<TOk, NMADAPLGOEB>);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E6")]
public interface DPLHFMKJDOO
{
	[Cpp2IlInjected.Token(Token = "0x6000554")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool DGNGADDAPLC([In] DFAHBLOKBPH<OKOMLKNINNF, GFEHMFEELCO> KNFGDDANCCK);
}
[Cpp2IlInjected.Token(Token = "0x20000E7")]
public static class CMEGAMKKMBO
{
	[Cpp2IlInjected.Token(Token = "0x6000555")]
	[Cpp2IlInjected.Address(RVA = "0x29A5970", Offset = "0x29A4970", VA = "0x1829A5970")]
	public static bool DGNGADDAPLC<TOk, TErr>(this DPLHFMKJDOO KALCJEIICGB, [In] DFAHBLOKBPH<TOk, TErr> KNFGDDANCCK) where TOk : notnull where TErr : notnull, GFEHMFEELCO
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E8")]
public interface GADMDCCKLNF
{
	[Cpp2IlInjected.Token(Token = "0x170000C8")]
	PIAOFMEGMEM GCDGICFLMJA
	{
		[Cpp2IlInjected.Token(Token = "0x6000556")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E9")]
public interface HPAIHFKBLKJ
{
	[Cpp2IlInjected.Token(Token = "0x6000557")]
	[Cpp2IlInjected.Address(Slot = "0")]
	LIIMFCKBCIO FFKBFEOEPCD(int GMEOHJCNADI);
}
[Cpp2IlInjected.Token(Token = "0x20000EA")]
public interface EDAEILFOGHK
{
	[Cpp2IlInjected.Token(Token = "0x170000C9")]
	string NPDJPDJBDCA
	{
		[Cpp2IlInjected.Token(Token = "0x6000558")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EB")]
public interface MEDGPOJINEI
{
	[Cpp2IlInjected.Token(Token = "0x6000559")]
	[Cpp2IlInjected.Address(Slot = "0")]
	ODBDBAEEOFP? OLNEDIKDOFO(BGKDPCAKPBJ<IHOAGKINOHG> FCFGPBAFAPA);
}
[Cpp2IlInjected.Token(Token = "0x20000EC")]
public interface CCLIICIIAKM
{
	[Cpp2IlInjected.Token(Token = "0x170000CA")]
	string NPDJPDJBDCA
	{
		[Cpp2IlInjected.Token(Token = "0x600055A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000ED")]
public interface ODBDBAEEOFP
{
	[Cpp2IlInjected.Token(Token = "0x170000CB")]
	string NPDJPDJBDCA
	{
		[Cpp2IlInjected.Token(Token = "0x600055B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600055C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	CCLIICIIAKM? CNMAGNDEABP(BGKDPCAKPBJ<HFFNHINIHLD> NODCCEJHLIA);

	[Cpp2IlInjected.Token(Token = "0x600055D")]
	[Cpp2IlInjected.Address(Slot = "2")]
	EDAEILFOGHK? CABCKCNOJHB(BGKDPCAKPBJ<MBMIEFKCJNG> NCOFEOALOGH);
}
[Cpp2IlInjected.Token(Token = "0x20000EE")]
public interface KEGMKMHBKGO
{
	[Cpp2IlInjected.Token(Token = "0x600055E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<bool> DIGKCOALAGN(string JJCEIJMGOAB, string PDLLDMABKGP);
}
[Cpp2IlInjected.Token(Token = "0x20000EF")]
public interface EIMDDECPHBC
{
	[Cpp2IlInjected.Token(Token = "0x600055F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	MEDGPOJINEI? CNOFDCCNFLM([In] MFLENLEMIJF<CLCGFMMKGBC> EABGJPHBOPH);
}
[Cpp2IlInjected.Token(Token = "0x20000F0")]
public sealed class KIEJNFNEJDJ
{
	[Cpp2IlInjected.Token(Token = "0x20000F1")]
	private struct HACPHIJDJMO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002E1")]
		public int LCNJIFOOGIB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002E2")]
		public GONCODLINKC? KHLKMNJIOFO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002E3")]
		public GONCODLINKC? FCBHKPCJABN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002E4")]
		public readonly List<LJHEBKBBECA> EOJHEBDFNBC;

		[Cpp2IlInjected.Token(Token = "0x6000568")]
		[Cpp2IlInjected.Address(RVA = "0x1FEED50", Offset = "0x1FEDD50", VA = "0x181FEED50")]
		private HACPHIJDJMO(int HCALFJOJKJO, GONCODLINKC? MBOMMBIDDCC, GONCODLINKC? NMELIDOJIED, List<LJHEBKBBECA> CECLMDMADKH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000569")]
		[Cpp2IlInjected.Address(RVA = "0x1FEEC90", Offset = "0x1FEDC90", VA = "0x181FEEC90")]
		public static HACPHIJDJMO GAKCNKPJGEK()
		{
			return default(HACPHIJDJMO);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002E0")]
	private readonly AJDNIJFDEKM<HACPHIJDJMO> BMOJMJPPCNO;

	[Cpp2IlInjected.Token(Token = "0x170000CC")]
	public static KIEJNFNEJDJ PNNELGGLBHA
	{
		[Cpp2IlInjected.Token(Token = "0x6000560")]
		[Cpp2IlInjected.Address(RVA = "0x1FEF7B0", Offset = "0x1FEE7B0", VA = "0x181FEF7B0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CD")]
	public bool KCPACJHPGEM
	{
		[Cpp2IlInjected.Token(Token = "0x6000561")]
		[Cpp2IlInjected.Address(RVA = "0x8A3710", Offset = "0x8A2710", VA = "0x1808A3710")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000562")]
		[Cpp2IlInjected.Address(RVA = "0xAD05B0", Offset = "0xACF5B0", VA = "0x180AD05B0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000563")]
	[Cpp2IlInjected.Address(RVA = "0x1FEF800", Offset = "0x1FEE800", VA = "0x181FEF800")]
	public void JOMJOIABDBG(MHOOCAJAJNP NMELIDOJIED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000564")]
	[Cpp2IlInjected.Address(RVA = "0x1FEF8C0", Offset = "0x1FEE8C0", VA = "0x181FEF8C0")]
	public void MHCIAEIMNKF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000565")]
	[Cpp2IlInjected.Address(RVA = "0x1FEF450", Offset = "0x1FEE450", VA = "0x181FEF450")]
	private static string? AIJCGNHJEIG([In] HACPHIJDJMO HNKNBIOFNIB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000566")]
	[Cpp2IlInjected.Address(RVA = "0x1FEFCC0", Offset = "0x1FEECC0", VA = "0x181FEFCC0")]
	public KIEJNFNEJDJ()
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
