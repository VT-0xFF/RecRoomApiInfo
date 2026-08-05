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
		[Cpp2IlInjected.Address(RVA = "0x7D1B20", Offset = "0x7D0520", VA = "0x1807D1B20")]
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
		[Cpp2IlInjected.Address(RVA = "0x1D57C70", Offset = "0x1D56670", VA = "0x181D57C70")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x7D2560", Offset = "0x7D0F60", VA = "0x1807D2560")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[Microsoft.CodeAnalysis.Embedded]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	[CompilerGenerated]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x7D25A0", Offset = "0x7D0FA0", VA = "0x1807D25A0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public sealed class EJHJLJPPHCN : IDisposable, BBDMJJLMABP, GKIMMPCNOIE, OELGKEIKBPI, BABKFPODOPP
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public abstract class DFGKHGCBJKJ : LMLIHKJGPHN
	{
		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public abstract int EDDHEEAJBBD
		{
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(Slot = "10")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x1D45770", Offset = "0x1D44170", VA = "0x181D45770", Slot = "5")]
		public OLOJIAHHKJN GAEGOBALMPB(HAEEEJDFFEI.PBABOHLILAM NFFMMJBNJIB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(Slot = "11")]
		public abstract void CHPAHHBDAEE();

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(Slot = "12")]
		public abstract void AAFAILDMCPJ();

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x1D456F0", Offset = "0x1D440F0", VA = "0x181D456F0", Slot = "13")]
		public virtual void FIIPDKPDKIJ(EJHJLJPPHCN BALKEACFDJN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x1D45630", Offset = "0x1D44030", VA = "0x181D45630", Slot = "14")]
		public virtual void CPNIDECCBPO(EJHJLJPPHCN BALKEACFDJN, PKBFCJOJFAD MCLCEMNNOFC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x7AE800", Offset = "0x7AD200", VA = "0x1807AE800")]
		protected DFGKHGCBJKJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public interface LMLIHKJGPHN
	{
		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		int EDDHEEAJBBD
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(Slot = "1")]
		OLOJIAHHKJN GAEGOBALMPB(HAEEEJDFFEI.PBABOHLILAM NFFMMJBNJIB);

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void CHPAHHBDAEE();

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void AAFAILDMCPJ();

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void FIIPDKPDKIJ(EJHJLJPPHCN BALKEACFDJN);

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void CPNIDECCBPO(EJHJLJPPHCN BALKEACFDJN, PKBFCJOJFAD MCLCEMNNOFC);
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	private readonly struct KDBPMIGICMI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public readonly NHBPANFFCCL<KBBHNEGECJL, PKBFCJOJFAD, EJHJLJPPHCN, LHINJBLMLPJ.HJMNPMINJNE<KBBHNEGECJL, PKBFCJOJFAD, EJHJLJPPHCN>> EFMEBNACKAL;

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x1D542E0", Offset = "0x1D52CE0", VA = "0x181D542E0")]
		internal KDBPMIGICMI(NHBPANFFCCL<KBBHNEGECJL, PKBFCJOJFAD, EJHJLJPPHCN, LHINJBLMLPJ.HJMNPMINJNE<KBBHNEGECJL, PKBFCJOJFAD, EJHJLJPPHCN>> CEBGEIIIEAM)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public sealed class LDBKIKIABOO : LHINJBLMLPJ.HJMNPMINJNE<KBBHNEGECJL, PKBFCJOJFAD, EJHJLJPPHCN>
	{
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public static readonly LDBKIKIABOO MEGHANKAOBP;

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x7AE800", Offset = "0x7AD200", VA = "0x1807AE800")]
		private LDBKIKIABOO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0xA25F50", Offset = "0xA24950", VA = "0x180A25F50", Slot = "4")]
		public KBBHNEGECJL GCPDNGMHCIA(PKBFCJOJFAD NHHBAHIFHJK)
		{
			return default(KBBHNEGECJL);
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x1D55C30", Offset = "0x1D54630", VA = "0x181D55C30", Slot = "5")]
		public void FIIPDKPDKIJ(EJHJLJPPHCN LMAHFBOHCNI, PKBFCJOJFAD MCLCEMNNOFC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x1D55B20", Offset = "0x1D54520", VA = "0x181D55B20", Slot = "6")]
		public void CPNIDECCBPO(EJHJLJPPHCN LMAHFBOHCNI, PKBFCJOJFAD MCLCEMNNOFC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000A")]
	private struct MOLOCMEDJOG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public CHFDGNEIFAE<KBBHNEGECJL, PKBFCJOJFAD, EJHJLJPPHCN, LHINJBLMLPJ.HJMNPMINJNE<KBBHNEGECJL, PKBFCJOJFAD, EJHJLJPPHCN>> EFMEBNACKAL;

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x1D57750", Offset = "0x1D56150", VA = "0x181D57750")]
		internal MOLOCMEDJOG(CHFDGNEIFAE<KBBHNEGECJL, PKBFCJOJFAD, EJHJLJPPHCN, LHINJBLMLPJ.HJMNPMINJNE<KBBHNEGECJL, PKBFCJOJFAD, EJHJLJPPHCN>> CEBGEIIIEAM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x1D57700", Offset = "0x1D56100", VA = "0x181D57700")]
		public static MOLOCMEDJOG JKJFENIAMEL()
		{
			return default(MOLOCMEDJOG);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public readonly struct DCPCDKJBBMB : FPMPGDCBBDF.MOBDFAAEHLA<LBODNCNHDMA, PKBFCJOJFAD, EJHJLJPPHCN>
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200000C")]
		[CompilerGenerated]
		private struct JNAFHALGJMO : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public AsyncTaskMethodBuilder<KKHLNMGODKL<object, MPIKAEBOCFI>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			public EJHJLJPPHCN receiver;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public PKBFCJOJFAD action;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			public DCPCDKJBBMB <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			private TaskAwaiter<KKHLNMGODKL<object, MPIKAEBOCFI>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x1D53CD0", Offset = "0x1D526D0", VA = "0x181D53CD0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x1D53EB0", Offset = "0x1D528B0", VA = "0x181D53EB0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0xA25F50", Offset = "0xA24950", VA = "0x180A25F50", Slot = "4")]
		public JLGMECJOLDI<LBODNCNHDMA> JBPEFEKEIIC(EJHJLJPPHCN KEHMNIODKBI)
		{
			return default(JLGMECJOLDI<LBODNCNHDMA>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x1D452A0", Offset = "0x1D43CA0", VA = "0x181D452A0", Slot = "5")]
		[AsyncStateMachine(typeof(JNAFHALGJMO))]
		public Task<KKHLNMGODKL<object, MPIKAEBOCFI>> DOAIANMJEDP(EJHJLJPPHCN KEHMNIODKBI, PKBFCJOJFAD MCLCEMNNOFC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x1D453D0", Offset = "0x1D43DD0", VA = "0x181D453D0", Slot = "6")]
		public PKBFCJOJFAD[] LBBCAJIKAOF(EJHJLJPPHCN KEHMNIODKBI)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private struct FJOHOFCDOMK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public AsyncTaskMethodBuilder<KKHLNMGODKL<bool, MPIKAEBOCFI>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public EJHJLJPPHCN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public FAPCIJNABKN rootData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public HGAPEMBEHIA circuitRootData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		public ODLEKMGFHLE superRoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private TaskAwaiter<KKHLNMGODKL<bool, MPIKAEBOCFI>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x1D4DB20", Offset = "0x1D4C520", VA = "0x181D4DB20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x1D4DDA0", Offset = "0x1D4C7A0", VA = "0x181D4DDA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private struct KGPDGNNHNFI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public AsyncTaskMethodBuilder<KKHLNMGODKL<bool, MPIKAEBOCFI>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public EJHJLJPPHCN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private TaskAwaiter<KKHLNMGODKL<bool, MPIKAEBOCFI>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x1D54960", Offset = "0x1D53360", VA = "0x181D54960", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x1D54BF0", Offset = "0x1D535F0", VA = "0x181D54BF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[CompilerGenerated]
	private struct DCLPGLADKAD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		public AsyncTaskMethodBuilder<KKHLNMGODKL<PJHBHBBODGG, MPIKAEBOCFI>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		public EJHJLJPPHCN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private TaskAwaiter<KKHLNMGODKL<PJHBHBBODGG, MPIKAEBOCFI>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x1D45050", Offset = "0x1D43A50", VA = "0x181D45050", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x1D45230", Offset = "0x1D43C30", VA = "0x181D45230", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	private struct IAJKPFKGGFO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		public AsyncTaskMethodBuilder<KKHLNMGODKL<object, MPIKAEBOCFI>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		public EJHJLJPPHCN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		public PKBFCJOJFAD action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private TaskAwaiter<KKHLNMGODKL<object, MPIKAEBOCFI>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x1D51A50", Offset = "0x1D50450", VA = "0x181D51A50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x1D51C40", Offset = "0x1D50640", VA = "0x181D51C40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[CompilerGenerated]
	private struct LBJMKIFANCC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public AsyncTaskMethodBuilder<KKHLNMGODKL<PJHBHBBODGG, MPIKAEBOCFI>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public EJHJLJPPHCN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public Guid rootGraphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private TaskAwaiter<KKHLNMGODKL<PJHBHBBODGG, MPIKAEBOCFI>> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private TaskAwaiter<KKHLNMGODKL<bool, MPIKAEBOCFI>> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x1D552C0", Offset = "0x1D53CC0", VA = "0x181D552C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x1D55AB0", Offset = "0x1D544B0", VA = "0x181D55AB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private readonly JLGMECJOLDI<LBODNCNHDMA> KONBGKPOPBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly KDBPMIGICMI KGDCHGOFNJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly IKGJOPKGMDP OAILHHABOGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	internal readonly DDDHJHEJOAC BHDANOHGBLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xFD0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	internal readonly NKJHHHEICAE PPDGJLNHBJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xFD8")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	internal readonly KLLNHDMNECI.JGNJLEGNCJM HGPNBDFICOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xFF8")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	internal readonly MDLFBMMKDDO AHBOHNFGIDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1000")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	internal readonly MAPCCGGEAHJ EIIADEBOPOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1008")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	internal readonly JHKHAEKCONG IBNNHHIPGNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1010")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	internal readonly ANLNOJDPDEI MILJKAAHMCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1018")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private NALNFODDAEP OFFIILMENIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1028")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private OHAADPEAMDL OPAHLHDCCFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1048")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	internal readonly IKGJOPKGMDP.KCNFLGBPKCA IFKKHDBNBHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1050")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	internal readonly IDOFCENLABL OAICDFINPOA;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public IKGJOPKGMDP EMBJCJMEOAC
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x1D4B6B0", Offset = "0x1D4A0B0", VA = "0x181D4B6B0")]
		get
		{
			return default(IKGJOPKGMDP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	internal LMLIHKJGPHN LEPHIGFJLJH
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x1D4AAB0", Offset = "0x1D494B0", VA = "0x181D4AAB0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	internal OLOJIAHHKJN KEKPHNHNGMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x1D4A590", Offset = "0x1D48F90", VA = "0x181D4A590")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x1D4B070", Offset = "0x1D49A70", VA = "0x181D4B070")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	internal bool LKCNFAOLEPN
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x1D4AB00", Offset = "0x1D49500", VA = "0x181D4AB00")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x1D4B840", Offset = "0x1D4A240", VA = "0x181D4B840")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public LPABLGOPACM DJEKMCNOBDI
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x1D4BB70", Offset = "0x1D4A570", VA = "0x181D4BB70", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public PDBOEIFOONC BKCFFPGAGKJ
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x1D4BB90", Offset = "0x1D4A590", VA = "0x181D4BB90", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public EDBEDLNBPFG CFDJDGKKIAI
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x1D4BBA0", Offset = "0x1D4A5A0", VA = "0x181D4BBA0", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public FBKBDOPBDJM AALAMFOJNEC
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x1D4BB80", Offset = "0x1D4A580", VA = "0x181D4BB80", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	private IHOFOJLKFPJ? MGJLOBDHNDG
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x1D4B580", Offset = "0x1D49F80", VA = "0x181D4B580", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	private NLKCBKLKPNJ? FPMPCKKBADK
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x1D4A980", Offset = "0x1D49380", VA = "0x181D4A980", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x1D4B850", Offset = "0x1D4A250", VA = "0x181D4B850")]
	private EJHJLJPPHCN(NKJHHHEICAE MEIJHINEEKK, JLGMECJOLDI<LBODNCNHDMA> OHLLMKBPNCN, [In] KDBPMIGICMI PNBFMCMNGBB, [In] IKGJOPKGMDP FAJAINNMDDM, [In] DDDHJHEJOAC JMEAJDJFGKN, OLOJIAHHKJN APMOPJDEAAK, [In] KLLNHDMNECI.JGNJLEGNCJM NFGCFNMADEK, IKGJOPKGMDP.KCNFLGBPKCA IHCOLGMGLNJ, IDOFCENLABL FPCIECBBONA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x1D4AF10", Offset = "0x1D49910", VA = "0x181D4AF10")]
	public static EJHJLJPPHCN JKJFENIAMEL(NKJHHHEICAE NFFMMJBNJIB, IKGJOPKGMDP.BKGDLHIANGC BPIPFNDNMEN, JLGMECJOLDI<LBODNCNHDMA> OHLLMKBPNCN, JLGMECJOLDI<AGGCBADMAKJ> DNFNKCOAMIC, EDKKDEPLJLE BIHMJDLLGLH, CDOLAPOLICE GPEFEMMIGKM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x1D4AC30", Offset = "0x1D49630", VA = "0x181D4AC30")]
	public static EJHJLJPPHCN JKJFENIAMEL(NKJHHHEICAE MEIJHINEEKK, [In] IKGJOPKGMDP FAJAINNMDDM, [In] DDDHJHEJOAC JMEAJDJFGKN, JLGMECJOLDI<LBODNCNHDMA> OHLLMKBPNCN, JLGMECJOLDI<AGGCBADMAKJ> DNFNKCOAMIC, EDKKDEPLJLE BIHMJDLLGLH, CDOLAPOLICE GPEFEMMIGKM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x1D4A790", Offset = "0x1D49190", VA = "0x181D4A790", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x1D4B420", Offset = "0x1D49E20", VA = "0x181D4B420")]
	[AsyncStateMachine(typeof(FJOHOFCDOMK))]
	internal Task<KKHLNMGODKL<bool, MPIKAEBOCFI>> MPPIJBCEKAD(FAPCIJNABKN NJFPPBLMKHP, HGAPEMBEHIA KCJNLIFKLJL, ODLEKMGFHLE JAMOLIKGFAA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x1D4A4A0", Offset = "0x1D48EA0", VA = "0x181D4A4A0")]
	[AsyncStateMachine(typeof(KGPDGNNHNFI))]
	public Task<KKHLNMGODKL<bool, MPIKAEBOCFI>> BCAAFANBGLD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x1D4A6A0", Offset = "0x1D490A0", VA = "0x181D4A6A0")]
	[AsyncStateMachine(typeof(DCLPGLADKAD))]
	public Task<KKHLNMGODKL<PJHBHBBODGG, MPIKAEBOCFI>> DJMDFCBKOKH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x1D4A290", Offset = "0x1D48C90", VA = "0x181D4A290")]
	internal void AJBEIMCCBMH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x1D4A620", Offset = "0x1D49020", VA = "0x181D4A620")]
	internal IKGCKHLMHFG<PKBFCJOJFAD> CIJKNFPIACO([In] PPGJNIDOJJF MOFNFKOPDOA)
	{
		return default(IKGCKHLMHFG<PKBFCJOJFAD>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x1D4B6C0", Offset = "0x1D4A0C0", VA = "0x181D4B6C0")]
	internal bool OIMOOJPKPOO([In] PPGJNIDOJJF MOFNFKOPDOA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x1D4A5A0", Offset = "0x1D48FA0", VA = "0x181D4A5A0")]
	internal IKGCKHLMHFG<PKBFCJOJFAD> BKNLKDILCPF([In] MECCDFBDFBI DJIDPCEHABN)
	{
		return default(IKGCKHLMHFG<PKBFCJOJFAD>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x1D4B730", Offset = "0x1D4A130", VA = "0x181D4B730")]
	[AsyncStateMachine(typeof(IAJKPFKGGFO))]
	internal Task<KKHLNMGODKL<object, MPIKAEBOCFI>> OJJKOMMCNJN(PKBFCJOJFAD MCLCEMNNOFC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x1D4B090", Offset = "0x1D49A90", VA = "0x181D4B090")]
	private PKBFCJOJFAD[] LBBCAJIKAOF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x1D4AB10", Offset = "0x1D49510", VA = "0x181D4AB10")]
	[AsyncStateMachine(typeof(LBJMKIFANCC))]
	public Task<KKHLNMGODKL<PJHBHBBODGG, MPIKAEBOCFI>> HMFHCBOPOMB(Guid LAFLLNDHMPA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public static class KJDCGALCNAI
{
	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x27344E0", Offset = "0x2732EE0", VA = "0x1827344E0")]
	public static GGKILILAOPL<(TPrev?, EJHJLJPPHCN?), NLKCBKLKPNJ> MGILKPDEJCH<TPrev>([In] this GGKILILAOPL<TPrev, EJHJLJPPHCN> NHHBAHIFHJK)
	{
		return default(GGKILILAOPL<(TPrev, EJHJLJPPHCN), NLKCBKLKPNJ>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x2734740", Offset = "0x2733140", VA = "0x182734740")]
	public static GGKILILAOPL<TPrev?, EJHJLJPPHCN?> MHAKLBHJGPD<TPrev>([In] this GGKILILAOPL<TPrev, EJHJLJPPHCN> NHHBAHIFHJK)
	{
		return default(GGKILILAOPL<TPrev, EJHJLJPPHCN>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public sealed class FNGEMALIHLK<TData> : NOJMEPFJKIM, ANFENGAPHOD, PKFDKDKJAIE where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly JGKGEKHGJKB<PNMLFKAJNIK>? GIFACGCJHHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public readonly string FEMPLJOMNCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public readonly TData IHMOEAABGNA;

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public JGKGEKHGJKB<PNMLFKAJNIK>? JBBLPFIMGJF
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x1EEA3D0", Offset = "0x1EE8DD0", VA = "0x181EEA3D0", Slot = "13")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x7A9150", Offset = "0x7A7B50", VA = "0x1807A9150", Slot = "7")]
	public override string GMMJBFEOGBG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x35C2B10", Offset = "0x35C1510", VA = "0x1835C2B10")]
	internal FNGEMALIHLK([In] JGKGEKHGJKB<PNMLFKAJNIK>? JOJFHEGFJIC, JLGMECJOLDI<FKIAAIPKAOJ>? NIKJMLODPHJ, IOKind? BNABONBOFFP, string DCKDMGKGDFN, [In] TData MFNOAEFOKBK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public static class JFGDKHNLNNK
{
	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x1D52900", Offset = "0x1D51300", VA = "0x181D52900")]
	public static KKHLNMGODKL<ACCHIDBIDPG, ANFENGAPHOD> GFOONLHMBFB([In] this PPDFEHDDBPE<BIBCPEMILGM> KELJFGOOBCN)
	{
		return default(KKHLNMGODKL<ACCHIDBIDPG, ANFENGAPHOD>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x26FC840", Offset = "0x26FB240", VA = "0x1826FC840")]
	public static KKHLNMGODKL<TOk, ANFENGAPHOD> KGKKBGFOBCI<TOk>([In] this KKHLNMGODKL<TOk, ANFENGAPHOD> NHHBAHIFHJK, [In] JGKGEKHGJKB<PNMLFKAJNIK>? JOJFHEGFJIC, JLGMECJOLDI<FKIAAIPKAOJ>? NIKJMLODPHJ, IOKind? BNABONBOFFP, string DCKDMGKGDFN) where TOk : notnull
	{
		return default(KKHLNMGODKL<TOk, ANFENGAPHOD>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public interface NKJHHHEICAE
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	IGOGAMCOFBL.ELOIJMPPHFD EFMFMLPLCFP
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	HAEEEJDFFEI.PBABOHLILAM MKFKMBAGEIO
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	EJHJLJPPHCN.LMLIHKJGPHN LLJIGOLODLK
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	DEEBIGMHJGN.PNAGPAIJMOJ BIJCOPOIHBK
	{
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	LHINJBLMLPJ.HJMNPMINJNE<KBBHNEGECJL, PKBFCJOJFAD, EJHJLJPPHCN> CBLKBHAOONI
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	CFPCGPKJOEC FOKAODMOPLP
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	BPJNDDGFEIL MJCMICAACFL
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	PKABPKDGOFD HDFPEMOAFIH
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	HFGFELDOBHA IOLIEBECABI
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	EFOHNENLJMJ DKMKOMHFPLA
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public static class APOEPBPOMNJ
{
	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x1D43EA0", Offset = "0x1D428A0", VA = "0x181D43EA0")]
	public static PKBFCJOJFAD DODMKLOKGJC(this PKBFCJOJFAD NHHBAHIFHJK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x1D43DD0", Offset = "0x1D427D0", VA = "0x181D43DD0")]
	public static PKBFCJOJFAD CIKIDEBKALG(this HDHGDCLBMOB NHHBAHIFHJK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public readonly struct HDHGDCLBMOB
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[CompilerGenerated]
	private struct FNJGKAAMIBE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public AsyncTaskMethodBuilder<KKHLNMGODKL<object, MPIKAEBOCFI>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public EJHJLJPPHCN root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public HDHGDCLBMOB self;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private TaskAwaiter<KKHLNMGODKL<object, MPIKAEBOCFI>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x1D4DE10", Offset = "0x1D4C810", VA = "0x181D4DE10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x1D4E0D0", Offset = "0x1D4CAD0", VA = "0x181D4E0D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public readonly ByteString NAJOFLHMBPO;

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x8C6B40", Offset = "0x8C5540", VA = "0x1808C6B40")]
	private HDHGDCLBMOB(ByteString FDFHGIHHGHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x1D4F290", Offset = "0x1D4DC90", VA = "0x181D4F290")]
	public static PKBFCJOJFAD NHNGALPFEDB(ByteString FDFHGIHHGHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x1D4F350", Offset = "0x1D4DD50", VA = "0x181D4F350")]
	public static OBFJIOOLHIO<KBBHNEGECJL, HDHGDCLBMOB> OFKDDLBANEJ(PKBFCJOJFAD NCDEJOGBLGM)
	{
		return default(OBFJIOOLHIO<KBBHNEGECJL, HDHGDCLBMOB>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x1D4F400", Offset = "0x1D4DE00", VA = "0x181D4F400")]
	[AsyncStateMachine(typeof(FNJGKAAMIBE))]
	public static Task<KKHLNMGODKL<object, MPIKAEBOCFI>> OJJKOMMCNJN(EJHJLJPPHCN LMAHFBOHCNI, HDHGDCLBMOB NHHBAHIFHJK)
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000019")]
public readonly struct LANHNLKALAF
{
	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x1D551B0", Offset = "0x1D53BB0", VA = "0x181D551B0")]
	public static PKBFCJOJFAD NHNGALPFEDB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x1D55250", Offset = "0x1D53C50", VA = "0x181D55250")]
	public static OBFJIOOLHIO<KBBHNEGECJL, LANHNLKALAF> OFKDDLBANEJ(PKBFCJOJFAD NCDEJOGBLGM)
	{
		return default(OBFJIOOLHIO<KBBHNEGECJL, LANHNLKALAF>);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x1D55130", Offset = "0x1D53B30", VA = "0x181D55130")]
	public static KKHLNMGODKL<PJHBHBBODGG, BDPIDPDHGEO> EEFJNOANPLC(EJHJLJPPHCN LMAHFBOHCNI, [In] LANHNLKALAF NHHBAHIFHJK)
	{
		return default(KKHLNMGODKL<PJHBHBBODGG, BDPIDPDHGEO>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public readonly struct OPLALMEHBIA
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[CompilerGenerated]
	private struct PBPOKINDPID : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public AsyncTaskMethodBuilder<KKHLNMGODKL<PJHBHBBODGG, BDPIDPDHGEO>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public EJHJLJPPHCN root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public OPLALMEHBIA self;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private KKHLNMGODKL<PJHBHBBODGG, BDPIDPDHGEO> <r>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x1D58B10", Offset = "0x1D57510", VA = "0x181D58B10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x1D58E80", Offset = "0x1D57880", VA = "0x181D58E80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	public readonly FAPCIJNABKN? DOHPCCIFDAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public readonly HGAPEMBEHIA? OHFDGAPPNNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public readonly ODLEKMGFHLE? JOCKHKKCNOI;

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x1A4A020", Offset = "0x1A48A20", VA = "0x181A4A020")]
	private OPLALMEHBIA(FAPCIJNABKN? NJFPPBLMKHP, HGAPEMBEHIA? KCJNLIFKLJL, ODLEKMGFHLE? JAMOLIKGFAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x1D587C0", Offset = "0x1D571C0", VA = "0x181D587C0")]
	public static PKBFCJOJFAD? NHNGALPFEDB(FAPCIJNABKN? NJFPPBLMKHP, HGAPEMBEHIA? KCJNLIFKLJL, ODLEKMGFHLE? JAMOLIKGFAA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x1D588C0", Offset = "0x1D572C0", VA = "0x181D588C0")]
	public static OBFJIOOLHIO<KBBHNEGECJL, OPLALMEHBIA> OFKDDLBANEJ(PKBFCJOJFAD NCDEJOGBLGM)
	{
		return default(OBFJIOOLHIO<KBBHNEGECJL, OPLALMEHBIA>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x1D589D0", Offset = "0x1D573D0", VA = "0x181D589D0")]
	[AsyncStateMachine(typeof(PBPOKINDPID))]
	public static Task<KKHLNMGODKL<PJHBHBBODGG, BDPIDPDHGEO>> OJJKOMMCNJN(EJHJLJPPHCN LMAHFBOHCNI, OPLALMEHBIA NHHBAHIFHJK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public readonly struct HGDLALLEHNA
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	[CompilerGenerated]
	private struct EGFGIAAEOJI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public AsyncTaskMethodBuilder<KKHLNMGODKL<EPLJJHPILDK, MPIKAEBOCFI>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public HGDLALLEHNA self;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public EJHJLJPPHCN root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private KKHLNMGODKL<EPLJJHPILDK, MPIKAEBOCFI> <r1>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		private KKHLNMGODKL<object, PKFDKDKJAIE>[] <aggregateResult>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		private int <i>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		private KKHLNMGODKL<object, PKFDKDKJAIE> <r2>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		private KKHLNMGODKL<object, PKFDKDKJAIE>[] <>7__wrap5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		private int <>7__wrap6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		private TaskAwaiter<KKHLNMGODKL<object, MPIKAEBOCFI>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x1D49DB0", Offset = "0x1D487B0", VA = "0x181D49DB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x1D4A220", Offset = "0x1D48C20", VA = "0x181D4A220", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public readonly IReadOnlyList<PKBFCJOJFAD> GEKKCFAGEBB;

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x8C6B40", Offset = "0x8C5540", VA = "0x1808C6B40")]
	private HGDLALLEHNA(IReadOnlyList<PKBFCJOJFAD> BDOEJBMENLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x1D4F510", Offset = "0x1D4DF10", VA = "0x181D4F510")]
	public static PKBFCJOJFAD NHNGALPFEDB(IReadOnlyList<PKBFCJOJFAD> BDOEJBMENLB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x1D4F5D0", Offset = "0x1D4DFD0", VA = "0x181D4F5D0")]
	public static OBFJIOOLHIO<KBBHNEGECJL, HGDLALLEHNA> OFKDDLBANEJ(PKBFCJOJFAD NCDEJOGBLGM)
	{
		return default(OBFJIOOLHIO<KBBHNEGECJL, HGDLALLEHNA>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x1D4F670", Offset = "0x1D4E070", VA = "0x181D4F670")]
	[AsyncStateMachine(typeof(EGFGIAAEOJI))]
	public static Task<KKHLNMGODKL<EPLJJHPILDK, MPIKAEBOCFI>> OJJKOMMCNJN(EJHJLJPPHCN LMAHFBOHCNI, HGDLALLEHNA NHHBAHIFHJK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public readonly struct MECCDFBDFBI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	public readonly int OICIIFDIAGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	public readonly int MEJJBNBBHJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	public readonly byte[] IHMOEAABGNA;

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x17B8360", Offset = "0x17B6D60", VA = "0x1817B8360")]
	private MECCDFBDFBI(int DPBEIPGOMHN, int OJANCMLFDOJ, byte[] MFNOAEFOKBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x1D56500", Offset = "0x1D54F00", VA = "0x181D56500")]
	public static PKBFCJOJFAD NHNGALPFEDB(int DPBEIPGOMHN, int OJANCMLFDOJ, ByteString MFNOAEFOKBK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x1D562A0", Offset = "0x1D54CA0", VA = "0x181D562A0")]
	public static PKBFCJOJFAD[] CNDPFGKHEBH(PKBFCJOJFAD MCLCEMNNOFC, int ECEGNNEMCAK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x1D565E0", Offset = "0x1D54FE0", VA = "0x181D565E0")]
	public static OBFJIOOLHIO<KBBHNEGECJL, MECCDFBDFBI> OFKDDLBANEJ(PKBFCJOJFAD NCDEJOGBLGM)
	{
		return default(OBFJIOOLHIO<KBBHNEGECJL, MECCDFBDFBI>);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x1D563E0", Offset = "0x1D54DE0", VA = "0x181D563E0")]
	public static KKHLNMGODKL<PKBFCJOJFAD, BDPIDPDHGEO> EEFJNOANPLC(EJHJLJPPHCN LMAHFBOHCNI, [In] MECCDFBDFBI NHHBAHIFHJK)
	{
		return default(KKHLNMGODKL<PKBFCJOJFAD, BDPIDPDHGEO>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public readonly struct PPGJNIDOJJF
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[CompilerGenerated]
	private struct MMDDPFDBBJO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public AsyncTaskMethodBuilder<KKHLNMGODKL<bool, BDPIDPDHGEO>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public EJHJLJPPHCN root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public PPGJNIDOJJF self;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		private KKHLNMGODKL<bool, BDPIDPDHGEO> <r>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		private TaskAwaiter<KKHLNMGODKL<PJHBHBBODGG, BDPIDPDHGEO>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x1D57050", Offset = "0x1D55A50", VA = "0x181D57050", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x1D57690", Offset = "0x1D56090", VA = "0x181D57690", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public readonly int OICIIFDIAGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public readonly int MEJJBNBBHJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public readonly byte[] IHMOEAABGNA;

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x17B8360", Offset = "0x17B6D60", VA = "0x1817B8360")]
	private PPGJNIDOJJF(int DPBEIPGOMHN, int OJANCMLFDOJ, byte[] MFNOAEFOKBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x1D59D50", Offset = "0x1D58750", VA = "0x181D59D50")]
	public static PKBFCJOJFAD NHNGALPFEDB(int DPBEIPGOMHN, int OJANCMLFDOJ, ByteString MFNOAEFOKBK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x1D59B50", Offset = "0x1D58550", VA = "0x181D59B50")]
	public static PKBFCJOJFAD?[]? DPFOLKLGDOB(int ECEGNNEMCAK, FAPCIJNABKN? NJFPPBLMKHP, HGAPEMBEHIA? KCJNLIFKLJL, ODLEKMGFHLE? JAMOLIKGFAA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x1D59E30", Offset = "0x1D58830", VA = "0x181D59E30")]
	public static OBFJIOOLHIO<KBBHNEGECJL, PPGJNIDOJJF> OFKDDLBANEJ(PKBFCJOJFAD NCDEJOGBLGM)
	{
		return default(OBFJIOOLHIO<KBBHNEGECJL, PPGJNIDOJJF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x1D59F10", Offset = "0x1D58910", VA = "0x181D59F10")]
	[AsyncStateMachine(typeof(MMDDPFDBBJO))]
	public static Task<KKHLNMGODKL<bool, BDPIDPDHGEO>> OJJKOMMCNJN(EJHJLJPPHCN LMAHFBOHCNI, PPGJNIDOJJF NHHBAHIFHJK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public sealed class MDLFBMMKDDO : LPABLGOPACM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private readonly EJHJLJPPHCN CAPMIPILDGH;

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public DEFMCDINNPC? MEGHANKAOBP
	{
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x1D56190", Offset = "0x1D54B90", VA = "0x181D56190", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x7B5BD0", Offset = "0x7B45D0", VA = "0x1807B5BD0")]
	internal MDLFBMMKDDO(EJHJLJPPHCN BALKEACFDJN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public sealed class BDFLODFADHK : DEFMCDINNPC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private readonly EJHJLJPPHCN CAPMIPILDGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private readonly DEEIIACCHIP PACOCMKCMKD;

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x7B0130", Offset = "0x7AEB30", VA = "0x1807B0130")]
	public BDFLODFADHK(EJHJLJPPHCN BALKEACFDJN, DEEIIACCHIP NEMDKECFAGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x1D44340", Offset = "0x1D42D40", VA = "0x181D44340", Slot = "4")]
	public KKHLNMGODKL<ACCHIDBIDPG, ANFENGAPHOD> ADFPNOIMBLL(JGKGEKHGJKB<PNMLFKAJNIK> KOOMGHGCPCM, JLGMECJOLDI<EHGNFGGIBEB> NDKHLPHIJIN, JLGMECJOLDI<ALOBLIADAMK> FIPNEPOHCEF)
	{
		return default(KKHLNMGODKL<ACCHIDBIDPG, ANFENGAPHOD>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x1D44610", Offset = "0x1D43010", VA = "0x181D44610", Slot = "5")]
	public KKHLNMGODKL<ACCHIDBIDPG, ANFENGAPHOD> NBBIICNJMED(JGKGEKHGJKB<PNMLFKAJNIK> KOOMGHGCPCM, JLGMECJOLDI<EHGNFGGIBEB> NDKHLPHIJIN, JLGMECJOLDI<NIIHBFDIOKM> FLOGJHFICGN)
	{
		return default(KKHLNMGODKL<ACCHIDBIDPG, ANFENGAPHOD>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public sealed class IGOGAMCOFBL : HGBGBPBGNKL, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public interface ELOIJMPPHFD
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Task<DEEIIACCHIP> IJFOANMNABG(EJHJLJPPHCN BALKEACFDJN, HGAPEMBEHIA? JLBKLFJBNIA, ODLEKMGFHLE? AMBABCKBIEK, CancellationToken HNLFPBLPOKJ);

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		HDEAGHOKJFL LEMDBJDINDC(EJHJLJPPHCN BALKEACFDJN, FAPCIJNABKN DPLOCHMLAED);
	}

	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public sealed class AJCPDJDPHGB : ELOIJMPPHFD
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000028")]
		[CompilerGenerated]
		private struct BAJDHKCCMJO : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400006F")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000070")]
			public AsyncTaskMethodBuilder<DEEIIACCHIP> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000071")]
			public EJHJLJPPHCN circuitsManager;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000072")]
			public HGAPEMBEHIA cv2RoomData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000073")]
			public ODLEKMGFHLE cv2SuperRoomData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000074")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000075")]
			private TaskAwaiter<DEEBIGMHJGN> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0x1D43FB0", Offset = "0x1D429B0", VA = "0x181D43FB0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(RVA = "0x1D442D0", Offset = "0x1D42CD0", VA = "0x181D442D0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public static readonly AJCPDJDPHGB MEGHANKAOBP;

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x7AE800", Offset = "0x7AD200", VA = "0x1807AE800")]
		private AJCPDJDPHGB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x1D439C0", Offset = "0x1D423C0", VA = "0x181D439C0", Slot = "4")]
		[AsyncStateMachine(typeof(BAJDHKCCMJO))]
		public Task<DEEIIACCHIP> IJFOANMNABG(EJHJLJPPHCN BALKEACFDJN, HGAPEMBEHIA? JLBKLFJBNIA, ODLEKMGFHLE? AMBABCKBIEK, CancellationToken HNLFPBLPOKJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x1D43B20", Offset = "0x1D42520", VA = "0x181D43B20", Slot = "5")]
		public HDEAGHOKJFL LEMDBJDINDC(EJHJLJPPHCN BALKEACFDJN, FAPCIJNABKN DPLOCHMLAED)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	[CompilerGenerated]
	private struct MEIHJHHPAOL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		public AsyncTaskMethodBuilder<IGOGAMCOFBL> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		public EJHJLJPPHCN circuitsManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		public HGAPEMBEHIA cv2RoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		public ODLEKMGFHLE cv2SuperRoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		public FAPCIJNABKN evRoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		private ELOIJMPPHFD <selfDeps>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		private TaskAwaiter<DEEIIACCHIP> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x1D566C0", Offset = "0x1D550C0", VA = "0x181D566C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x1D56C20", Offset = "0x1D55620", VA = "0x181D56C20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private readonly DEEIIACCHIP PACOCMKCMKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private readonly HDEAGHOKJFL ADDKLKFIIKD;

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public IHOFOJLKFPJ EBBAPAOHNEF
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x1D52420", Offset = "0x1D50E20", VA = "0x181D52420", Slot = "4")]
		get
		{
			return default(IHOFOJLKFPJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public NLKCBKLKPNJ GONJGKLODIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x1D52250", Offset = "0x1D50C50", VA = "0x181D52250", Slot = "5")]
		get
		{
			return default(NLKCBKLKPNJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public BDFLODFADHK JFLAPBJFCIB
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x7AC270", Offset = "0x7AAC70", VA = "0x1807AC270", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public HPBOKLJNGGO LHFIPOKEMDD
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x7A91E0", Offset = "0x7A7BE0", VA = "0x1807A91E0", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public FOAFAGELKHL BHMKCHHPCLK
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x7A9100", Offset = "0x7A7B00", VA = "0x1807A9100", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x1D52480", Offset = "0x1D50E80", VA = "0x181D52480")]
	private IGOGAMCOFBL(DEEIIACCHIP NEMDKECFAGI, HDEAGHOKJFL JFANONPAIDP, BDFLODFADHK AJFAMPBIBKB, HPBOKLJNGGO PKHHPHECAPK, FOAFAGELKHL PHLJJJLOJIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x1D522B0", Offset = "0x1D50CB0", VA = "0x181D522B0")]
	[AsyncStateMachine(typeof(MEIHJHHPAOL))]
	public static Task<IGOGAMCOFBL> MNPMCBDFPDL(EJHJLJPPHCN BALKEACFDJN, FAPCIJNABKN DPLOCHMLAED, HGAPEMBEHIA? JLBKLFJBNIA, ODLEKMGFHLE? AMBABCKBIEK, CancellationToken HNLFPBLPOKJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x1D521F0", Offset = "0x1D50BF0", VA = "0x181D521F0", Slot = "9")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public sealed class HAEEEJDFFEI : OLOJIAHHKJN, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	public interface PBABOHLILAM
	{
		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Task<HGBGBPBGNKL> BOEHDAHOEPJ(EJHJLJPPHCN BALKEACFDJN, FAPCIJNABKN DPLOCHMLAED, HGAPEMBEHIA? JLBKLFJBNIA, ODLEKMGFHLE? AMBABCKBIEK, CancellationToken HNLFPBLPOKJ);

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void BEJNLHMFOBN();

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void PBBECODMJEK();
	}

	[Cpp2IlInjected.Token(Token = "0x200002C")]
	public abstract class ICMEOOKLKLK : PBABOHLILAM
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200002D")]
		[CompilerGenerated]
		private struct EDBBNPGCPJN : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000087")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000088")]
			public AsyncTaskMethodBuilder<HGBGBPBGNKL> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000089")]
			public EJHJLJPPHCN circuitsManager;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400008A")]
			public FAPCIJNABKN evRoomData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400008B")]
			public HGAPEMBEHIA cv2RoomData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400008C")]
			public ODLEKMGFHLE cv2SuperRoomData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400008D")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400008E")]
			private TaskAwaiter<IGOGAMCOFBL> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0x1D49A00", Offset = "0x1D48400", VA = "0x181D49A00", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0x1D49D40", Offset = "0x1D48740", VA = "0x181D49D40", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x1D51D10", Offset = "0x1D50710", VA = "0x181D51D10", Slot = "4")]
		[AsyncStateMachine(typeof(EDBBNPGCPJN))]
		public Task<HGBGBPBGNKL> BOEHDAHOEPJ(EJHJLJPPHCN BALKEACFDJN, FAPCIJNABKN DPLOCHMLAED, HGAPEMBEHIA? JLBKLFJBNIA, ODLEKMGFHLE? AMBABCKBIEK, CancellationToken HNLFPBLPOKJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(Slot = "7")]
		public abstract void BEJNLHMFOBN();

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(Slot = "8")]
		public abstract void PBBECODMJEK();

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x7AE800", Offset = "0x7AD200", VA = "0x1807AE800")]
		protected ICMEOOKLKLK()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[CompilerGenerated]
	private struct OCICHLFCAHA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		public AsyncTaskMethodBuilder<HGBGBPBGNKL> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		public HAEEEJDFFEI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		private TaskAwaiter<PJHBHBBODGG> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x1D57CF0", Offset = "0x1D566F0", VA = "0x181D57CF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x1D57EF0", Offset = "0x1D568F0", VA = "0x181D57EF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[CompilerGenerated]
	private struct KFNLPFGEMDP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		public HAEEEJDFFEI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		public EJHJLJPPHCN circuitsManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		public FAPCIJNABKN evRoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		public HGAPEMBEHIA cv2RoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		public ODLEKMGFHLE cv2SuperRoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		private TaskAwaiter<HGBGBPBGNKL> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x1D543D0", Offset = "0x1D52DD0", VA = "0x181D543D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x1D54900", Offset = "0x1D53300", VA = "0x181D54900", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	private readonly PBABOHLILAM KAIABCGDPPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	private readonly TaskCompletionSource<PJHBHBBODGG> EEHPIAJECIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	private readonly TaskCompletionSource<PJHBHBBODGG> BIHEFACCMMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	private readonly CancellationTokenSource AEBANFANPKI;

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public bool LKCNFAOLEPN
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x7FDF40", Offset = "0x7FC940", VA = "0x1807FDF40", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x7FDA40", Offset = "0x7FC440", VA = "0x1807FDA40")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public bool FEJBNDKBHDE
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x8C30B0", Offset = "0x8C1AB0", VA = "0x1808C30B0", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x8C30A0", Offset = "0x8C1AA0", VA = "0x1808C30A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public bool LFHDMKJMKAD
	{
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0xEBB110", Offset = "0xEB9B10", VA = "0x180EBB110")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x1D4EF00", Offset = "0x1D4D900", VA = "0x181D4EF00")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public HGBGBPBGNKL? OPHBLECMLLJ
	{
		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x7A9320", Offset = "0x7A7D20", VA = "0x1807A9320", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x7A9430", Offset = "0x7A7E30", VA = "0x1807A9430")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x1D4EE10", Offset = "0x1D4D810", VA = "0x181D4EE10", Slot = "7")]
	[AsyncStateMachine(typeof(OCICHLFCAHA))]
	public Task<HGBGBPBGNKL> LMCNBJNHFCB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x1D4F070", Offset = "0x1D4DA70", VA = "0x181D4F070")]
	public HAEEEJDFFEI(PBABOHLILAM NFFMMJBNJIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x1D4EF10", Offset = "0x1D4D910", VA = "0x181D4EF10", Slot = "8")]
	[AsyncStateMachine(typeof(KFNLPFGEMDP))]
	public Task PDGIJEJGCPM(EJHJLJPPHCN BALKEACFDJN, FAPCIJNABKN DPLOCHMLAED, HGAPEMBEHIA? JLBKLFJBNIA, ODLEKMGFHLE? AMBABCKBIEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x1D4ECA0", Offset = "0x1D4D6A0", VA = "0x181D4ECA0", Slot = "9")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
internal sealed class NKJNHENPNLB : NKLKMMLMAOB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private readonly HPBOKLJNGGO EHBPCNANEOD;

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x7B5BD0", Offset = "0x7B45D0", VA = "0x1807B5BD0")]
	public NKJNHENPNLB(HPBOKLJNGGO PKHHPHECAPK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
internal static class JHGLMBOPCKL
{
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	private class FGADKJPHGJM<TGraph> : BPPMJABJILE where TGraph : BIGEIDAKKJG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		protected readonly TGraph OBLMBMCEFND;

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public virtual NDIGFKEJEFH? CBEGBBPAABI
		{
			[Cpp2IlInjected.Token(Token = "0x60000AF")]
			[Cpp2IlInjected.Address(RVA = "0xD0AA40", Offset = "0xD09440", VA = "0x180D0AA40", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x7B5BD0", Offset = "0x7B45D0", VA = "0x1807B5BD0")]
		public FGADKJPHGJM(TGraph JJPPJPGOKAD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000033")]
	private sealed class MPDGOKCDLOI : FGADKJPHGJM<PNEJKEHNLAC>
	{
		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public override NDIGFKEJEFH? CBEGBBPAABI
		{
			[Cpp2IlInjected.Token(Token = "0x60000B1")]
			[Cpp2IlInjected.Address(RVA = "0x1D57760", Offset = "0x1D56160", VA = "0x181D57760", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x1D57780", Offset = "0x1D56180", VA = "0x181D57780")]
		public MPDGOKCDLOI(PNEJKEHNLAC CACILELLPMI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x1D52DD0", Offset = "0x1D517D0", VA = "0x181D52DD0")]
	public static BPPMJABJILE JKJFENIAMEL(BIGEIDAKKJG JJPPJPGOKAD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public sealed class DLKAMECFEEF : FFGBDPICEGI, GHLMOHBOPLK, HEBBHDMMKAE, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	[CompilerGenerated]
	private sealed class JGLBIBHCAHO
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000037")]
		private struct <<RequestSetBoolDefaultValue>g__requestSetBoolDefaultValueInternal|0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A6")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40000A7")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000A8")]
			public JGLBIBHCAHO <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000A9")]
			public CFPCGPKJOEC errReporting_;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000AA")]
			private TaskAwaiter<KKHLNMGODKL<PJHBHBBODGG, MPIKAEBOCFI>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60000DB")]
			[Cpp2IlInjected.Address(RVA = "0x1D5A040", Offset = "0x1D58A40", VA = "0x181D5A040", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000DC")]
			[Cpp2IlInjected.Address(RVA = "0x1D5A2B0", Offset = "0x1D58CB0", VA = "0x181D5A2B0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		public DLKAMECFEEF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		public bool value;

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x7AE800", Offset = "0x7AD200", VA = "0x1807AE800")]
		public JGLBIBHCAHO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x1D52CE0", Offset = "0x1D516E0", VA = "0x181D52CE0")]
		[AsyncStateMachine(typeof(<<RequestSetBoolDefaultValue>g__requestSetBoolDefaultValueInternal|0>d))]
		internal Task PGDLKDMPADK(CFPCGPKJOEC errReporting_)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	[CompilerGenerated]
	private struct FPJKIFOFKBA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		public DLKAMECFEEF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		public string value;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		private TaskAwaiter<bool> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		private TaskAwaiter<KKHLNMGODKL<PJHBHBBODGG, MPIKAEBOCFI>> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x1D4E320", Offset = "0x1D4CD20", VA = "0x181D4E320", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x1D4E810", Offset = "0x1D4D210", VA = "0x181D4E810", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000039")]
	[CompilerGenerated]
	private sealed class AHBONKJNJKP
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200003A")]
		private struct <<RequestSetIntDefaultValue>g__requestSetIntDefaultValueInternal|0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000B3")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40000B4")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000B5")]
			public AHBONKJNJKP <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000B6")]
			private TaskAwaiter<KKHLNMGODKL<PJHBHBBODGG, MPIKAEBOCFI>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60000E1")]
			[Cpp2IlInjected.Address(RVA = "0x1D5A310", Offset = "0x1D58D10", VA = "0x181D5A310", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E2")]
			[Cpp2IlInjected.Address(RVA = "0x1D5A5F0", Offset = "0x1D58FF0", VA = "0x181D5A5F0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		public DLKAMECFEEF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		public int value;

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x7AE800", Offset = "0x7AD200", VA = "0x1807AE800")]
		public AHBONKJNJKP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x1D437D0", Offset = "0x1D421D0", VA = "0x181D437D0")]
		[AsyncStateMachine(typeof(<<RequestSetIntDefaultValue>g__requestSetIntDefaultValueInternal|0>d))]
		internal Task GOELLIFMELL(CFPCGPKJOEC errReporting_)
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private readonly BFMMFHJHKDA NMDEBIEMKON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private readonly ICollection<NJAPPKBAIFA> CEBDHCJHHEI;

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	private NKJHHHEICAE NBFFNBIHJKK
	{
		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x1D47BA0", Offset = "0x1D465A0", VA = "0x181D47BA0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public JLGMECJOLDI<ALOBLIADAMK> BDHEBKDLLEB
	{
		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0xA29FE0", Offset = "0xA289E0", VA = "0x180A29FE0", Slot = "23")]
		[CompilerGenerated]
		get
		{
			return default(JLGMECJOLDI<ALOBLIADAMK>);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0xA72BC0", Offset = "0xA715C0", VA = "0x180A72BC0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public override JLGMECJOLDI<FKIAAIPKAOJ> HGIHJLEFAOP
	{
		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x1D470A0", Offset = "0x1D45AA0", VA = "0x181D470A0", Slot = "19")]
		get
		{
			return default(JLGMECJOLDI<FKIAAIPKAOJ>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public bool BNJOECIGCMI
	{
		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x1D470E0", Offset = "0x1D45AE0", VA = "0x181D470E0", Slot = "24")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x1D49900", Offset = "0x1D48300", VA = "0x181D49900")]
	private DLKAMECFEEF(EJHJLJPPHCN BALKEACFDJN, DLLEFNELPBJ JACJPEOECBN, BFMMFHJHKDA EEJLGCKPMMH, JLGMECJOLDI<EHGNFGGIBEB> NDKHLPHIJIN, JLGMECJOLDI<ALOBLIADAMK> FIPNEPOHCEF, bool OBPFIAGBNAK, string OMHHPMIDNAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x1D47D10", Offset = "0x1D46710", VA = "0x181D47D10")]
	public static DLKAMECFEEF JKJFENIAMEL(EJHJLJPPHCN BALKEACFDJN, DLLEFNELPBJ JACJPEOECBN, BFMMFHJHKDA KODNHMICLEA, JLGMECJOLDI<EHGNFGGIBEB> NDKHLPHIJIN, JLGMECJOLDI<NJIGMIHFIFI> AJIHFKHEMCB, JLGMECJOLDI<ALOBLIADAMK> FIPNEPOHCEF, bool OBPFIAGBNAK, bool JPDNBBJIKBE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x1D49240", Offset = "0x1D47C40", VA = "0x181D49240", Slot = "20")]
	protected override void NGFHLNOOHDK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x1D475D0", Offset = "0x1D45FD0", VA = "0x181D475D0", Slot = "21")]
	public override void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x1D47C40", Offset = "0x1D46640", VA = "0x181D47C40", Slot = "28")]
	public void JCJBBLCGGML(NJAPPKBAIFA JLALALMCDDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x1D48A40", Offset = "0x1D47440", VA = "0x181D48A40", Slot = "25")]
	public void LBDIMKICOHJ(LMBFPMLFMHF BOPLNCKCDIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x1D480A0", Offset = "0x1D46AA0", VA = "0x181D480A0", Slot = "26")]
	public void JPABEFCEDBH(OKPDIANEPII NDIDFGEIGNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x1D47AC0", Offset = "0x1D464C0", VA = "0x181D47AC0", Slot = "22")]
	protected override void HAMKPEPNOEK(HMJEIHCLKCA EAEGBKJOMLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x1D48E20", Offset = "0x1D47820", VA = "0x181D48E20", Slot = "30")]
	public string LOEMDIEPNLK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x1D472A0", Offset = "0x1D45CA0", VA = "0x181D472A0", Slot = "27")]
	public string DOJEMPOBIFN(int HPAEJNPCJHD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x1D46E70", Offset = "0x1D45870", VA = "0x181D46E70")]
	private void CIMCFGLFJGF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x1D49830", Offset = "0x1D48230", VA = "0x181D49830", Slot = "29")]
	public void PNKEJJOKHIP(NJAPPKBAIFA JLALALMCDDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x1D49400", Offset = "0x1D47E00", VA = "0x181D49400")]
	private void NHKENDKLAJF(bool FDFHGIHHGHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x1D47790", Offset = "0x1D46190", VA = "0x181D47790", Slot = "31")]
	[AsyncStateMachine(typeof(FPJKIFOFKBA))]
	public Task EBGPJDNDFLH(string FDFHGIHHGHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x1D46CF0", Offset = "0x1D456F0", VA = "0x181D46CF0")]
	public void AHKEAJPEBFB(string FDFHGIHHGHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x1D46B50", Offset = "0x1D45550", VA = "0x181D46B50")]
	private void AGBIGIKIGHM(int FDFHGIHHGHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0xA72BC0", Offset = "0xA715C0", VA = "0x180A72BC0")]
	internal void ONDPCBKJNAP(JLGMECJOLDI<ALOBLIADAMK> FDFHGIHHGHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x1D47890", Offset = "0x1D46290", VA = "0x181D47890")]
	[CompilerGenerated]
	private bool ECLMCLOLCAD()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x1D490F0", Offset = "0x1D47AF0", VA = "0x181D490F0")]
	[CompilerGenerated]
	private bool NDEDFFHFDPJ()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x1D46E20", Offset = "0x1D45820", VA = "0x181D46E20")]
	[CompilerGenerated]
	private int MELALCAAJGD()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x1D48F90", Offset = "0x1D47990", VA = "0x181D48F90")]
	[CompilerGenerated]
	private bool MAKNDBJNAFP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x1D496E0", Offset = "0x1D480E0", VA = "0x181D496E0")]
	[CompilerGenerated]
	private bool PIMAKMGKAJO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x1D479E0", Offset = "0x1D463E0", VA = "0x181D479E0")]
	[CompilerGenerated]
	private bool GKKPIPCAMNE()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x1D47A30", Offset = "0x1D46430", VA = "0x181D47A30")]
	[CompilerGenerated]
	private bool GNJHAMJMEJK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x1D46E20", Offset = "0x1D45820", VA = "0x181D46E20")]
	[CompilerGenerated]
	private int BKLIJFPKDPC()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x1D49020", Offset = "0x1D47A20", VA = "0x181D49020")]
	[CompilerGenerated]
	private bool MFFCOAMLOPL()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x1D495C0", Offset = "0x1D47FC0", VA = "0x181D495C0")]
	[CompilerGenerated]
	private int OAOLCNMDIBB()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x1D47BC0", Offset = "0x1D465C0", VA = "0x181D47BC0")]
	[CompilerGenerated]
	private void JBMFMAFCNBI(object FDFHGIHHGHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x1D49610", Offset = "0x1D48010", VA = "0x181D49610")]
	[CompilerGenerated]
	private bool PHPEJMODNMG()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public static class OGDLIFEHOGD
{
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	private abstract class PBLHJCOAKMM<TNode> : OJDKNDJFNFM<TNode> where TNode : notnull, GOEMHBJPFHJ
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200003D")]
		[CompilerGenerated]
		private struct IFEJPHPIGKP : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000B7")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000B8")]
			public AsyncTaskMethodBuilder<KKHLNMGODKL<JLGMECJOLDI<EHGNFGGIBEB>, MPIKAEBOCFI>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000B9")]
			public PBLHJCOAKMM<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000BA")]
			public string name;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000BB")]
			private TaskAwaiter<KKHLNMGODKL<JLGMECJOLDI<EHGNFGGIBEB>, MPIKAEBOCFI>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60000EC")]
			[Cpp2IlInjected.Address(RVA = "0x37D2A50", Offset = "0x37D1450", VA = "0x1837D2A50", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000ED")]
			[Cpp2IlInjected.Address(RVA = "0x37D2E20", Offset = "0x37D1820", VA = "0x1837D2E20", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200003E")]
		[CompilerGenerated]
		private struct AGHFDMCJHIP : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000BC")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000BD")]
			public AsyncTaskMethodBuilder<KKHLNMGODKL<PJHBHBBODGG, MPIKAEBOCFI>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000BE")]
			public PBLHJCOAKMM<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000BF")]
			public JLGMECJOLDI<EHGNFGGIBEB> portGroupId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C0")]
			private TaskAwaiter<KKHLNMGODKL<PJHBHBBODGG, MPIKAEBOCFI>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60000EE")]
			[Cpp2IlInjected.Address(RVA = "0x367AAE0", Offset = "0x36794E0", VA = "0x18367AAE0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000EF")]
			[Cpp2IlInjected.Address(RVA = "0x367AEB0", Offset = "0x36798B0", VA = "0x18367AEB0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public sealed override bool HLPIPOKDALH
		{
			[Cpp2IlInjected.Token(Token = "0x60000E4")]
			[Cpp2IlInjected.Address(RVA = "0x7C2240", Offset = "0x7C0C40", VA = "0x1807C2240", Slot = "110")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public sealed override JLGMECJOLDI<EHGNFGGIBEB>? PIKBKFBPJPI
		{
			[Cpp2IlInjected.Token(Token = "0x60000E5")]
			[Cpp2IlInjected.Address(RVA = "0x3FC5BA0", Offset = "0x3FC45A0", VA = "0x183FC5BA0", Slot = "114")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x3B46570", Offset = "0x3B44F70", VA = "0x183B46570")]
		public PBLHJCOAKMM(EJHJLJPPHCN BALKEACFDJN, TNode JACJPEOECBN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x3FC5940", Offset = "0x3FC4340", VA = "0x183FC5940", Slot = "93")]
		[AsyncStateMachine(typeof(PBLHJCOAKMM<>.IFEJPHPIGKP))]
		public override Task<KKHLNMGODKL<JLGMECJOLDI<EHGNFGGIBEB>, MPIKAEBOCFI>> IBIJJNOCACN(string OMHHPMIDNAN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x3FC5790", Offset = "0x3FC4190", VA = "0x183FC5790", Slot = "117")]
		public sealed override bool FAOJBIOIACL(JLGMECJOLDI<EHGNFGGIBEB> NDKHLPHIJIN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x3FC5A60", Offset = "0x3FC4460", VA = "0x183FC5A60", Slot = "107")]
		protected sealed override bool NKCEPDJCADI(JLGMECJOLDI<EHGNFGGIBEB> NDKHLPHIJIN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x3FC5B00", Offset = "0x3FC4500", VA = "0x183FC5B00", Slot = "108")]
		protected override bool PJFIHEFLFDO(JLGMECJOLDI<EHGNFGGIBEB> NDKHLPHIJIN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x3FC5830", Offset = "0x3FC4230", VA = "0x183FC5830", Slot = "94")]
		[AsyncStateMachine(typeof(PBLHJCOAKMM<>.AGHFDMCJHIP))]
		public override Task<KKHLNMGODKL<PJHBHBBODGG, MPIKAEBOCFI>> FGDNNBPCBEC(JLGMECJOLDI<EHGNFGGIBEB> NDKHLPHIJIN)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003F")]
	private sealed class AMOHMHDDLLC : LBIEPDJGOBN<NKCGOMCKOGL>
	{
		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public override NodeVisualizationKey JFBDDAMOHDF
		{
			[Cpp2IlInjected.Token(Token = "0x60000F0")]
			[Cpp2IlInjected.Address(RVA = "0x7F2CB0", Offset = "0x7F16B0", VA = "0x1807F2CB0", Slot = "83")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x1D43C60", Offset = "0x1D42660", VA = "0x181D43C60")]
		public AMOHMHDDLLC(EJHJLJPPHCN BALKEACFDJN, NKCGOMCKOGL JACJPEOECBN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000040")]
	private abstract class LBIEPDJGOBN<TNode> : OJDKNDJFNFM<TNode> where TNode : notnull, FOBKKHBPFJJ
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000041")]
		[CompilerGenerated]
		private struct CCIINCECPHC : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C1")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C2")]
			public AsyncTaskMethodBuilder<KKHLNMGODKL<JLGMECJOLDI<EHGNFGGIBEB>, MPIKAEBOCFI>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C3")]
			public LBIEPDJGOBN<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C4")]
			public string name;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C5")]
			private TaskAwaiter<KKHLNMGODKL<JLGMECJOLDI<EHGNFGGIBEB>, MPIKAEBOCFI>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60000FA")]
			[Cpp2IlInjected.Address(RVA = "0x4859690", Offset = "0x4858090", VA = "0x184859690", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FB")]
			[Cpp2IlInjected.Address(RVA = "0x4859A00", Offset = "0x4858400", VA = "0x184859A00", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000042")]
		[CompilerGenerated]
		private struct LFBFPOHJKHI : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C6")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C7")]
			public AsyncTaskMethodBuilder<KKHLNMGODKL<PJHBHBBODGG, MPIKAEBOCFI>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C8")]
			public LBIEPDJGOBN<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C9")]
			public JLGMECJOLDI<EHGNFGGIBEB> portGroupId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000CA")]
			private TaskAwaiter<KKHLNMGODKL<PJHBHBBODGG, MPIKAEBOCFI>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60000FC")]
			[Cpp2IlInjected.Address(RVA = "0x3B7BB40", Offset = "0x3B7A540", VA = "0x183B7BB40", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FD")]
			[Cpp2IlInjected.Address(RVA = "0x3B7BE90", Offset = "0x3B7A890", VA = "0x183B7BE90", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public override JLGMECJOLDI<BIKLLPOLGEF>? IFELHIDPOGE
		{
			[Cpp2IlInjected.Token(Token = "0x60000F2")]
			[Cpp2IlInjected.Address(RVA = "0x3B465A0", Offset = "0x3B44FA0", VA = "0x183B465A0", Slot = "111")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public override JLGMECJOLDI<EHGNFGGIBEB>? PIKBKFBPJPI
		{
			[Cpp2IlInjected.Token(Token = "0x60000F3")]
			[Cpp2IlInjected.Address(RVA = "0x3B46650", Offset = "0x3B45050", VA = "0x183B46650", Slot = "114")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x3B46570", Offset = "0x3B44F70", VA = "0x183B46570")]
		public LBIEPDJGOBN(EJHJLJPPHCN BALKEACFDJN, TNode JACJPEOECBN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x3B46310", Offset = "0x3B44D10", VA = "0x183B46310", Slot = "93")]
		[AsyncStateMachine(typeof(LBIEPDJGOBN<>.CCIINCECPHC))]
		public override Task<KKHLNMGODKL<JLGMECJOLDI<EHGNFGGIBEB>, MPIKAEBOCFI>> IBIJJNOCACN(string OMHHPMIDNAN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x3B46160", Offset = "0x3B44B60", VA = "0x183B46160", Slot = "117")]
		public sealed override bool FAOJBIOIACL(JLGMECJOLDI<EHGNFGGIBEB> NDKHLPHIJIN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x3B46430", Offset = "0x3B44E30", VA = "0x183B46430", Slot = "107")]
		protected sealed override bool NKCEPDJCADI(JLGMECJOLDI<EHGNFGGIBEB> NDKHLPHIJIN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x3B464D0", Offset = "0x3B44ED0", VA = "0x183B464D0", Slot = "108")]
		protected override bool PJFIHEFLFDO(JLGMECJOLDI<EHGNFGGIBEB> NDKHLPHIJIN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x3B46200", Offset = "0x3B44C00", VA = "0x183B46200", Slot = "94")]
		[AsyncStateMachine(typeof(LBIEPDJGOBN<>.LFBFPOHJKHI))]
		public override Task<KKHLNMGODKL<PJHBHBBODGG, MPIKAEBOCFI>> FGDNNBPCBEC(JLGMECJOLDI<EHGNFGGIBEB> NDKHLPHIJIN)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000043")]
	private sealed class CMOPEKPDOMO : OJDKNDJFNFM<LCMODHIKHGM>
	{
		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public override NodeVisualizationKey JFBDDAMOHDF
		{
			[Cpp2IlInjected.Token(Token = "0x60000FE")]
			[Cpp2IlInjected.Address(RVA = "0x9C3750", Offset = "0x9C2150", VA = "0x1809C3750", Slot = "83")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x1D44F80", Offset = "0x1D43980", VA = "0x181D44F80")]
		public CMOPEKPDOMO(EJHJLJPPHCN BALKEACFDJN, LCMODHIKHGM JACJPEOECBN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000044")]
	private sealed class AMGIEMEFGPN : LBIEPDJGOBN<MLJBLKEGNPG>
	{
		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public override bool PBPOOPJDMNC
		{
			[Cpp2IlInjected.Token(Token = "0x6000100")]
			[Cpp2IlInjected.Address(RVA = "0x7C2240", Offset = "0x7C0C40", VA = "0x1807C2240", Slot = "85")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public override bool FFLOFPOGGHN
		{
			[Cpp2IlInjected.Token(Token = "0x6000101")]
			[Cpp2IlInjected.Address(RVA = "0x1D43C20", Offset = "0x1D42620", VA = "0x181D43C20", Slot = "112")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public override NodeVisualizationKey JFBDDAMOHDF
		{
			[Cpp2IlInjected.Token(Token = "0x6000102")]
			[Cpp2IlInjected.Address(RVA = "0x88F880", Offset = "0x88E280", VA = "0x18088F880", Slot = "83")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x1D43BC0", Offset = "0x1D425C0", VA = "0x181D43BC0")]
		public AMGIEMEFGPN(EJHJLJPPHCN BALKEACFDJN, MLJBLKEGNPG JACJPEOECBN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000045")]
	private sealed class KEDHDHGGJMH : OJDKNDJFNFM<BDIKLEBDMNE>
	{
		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public override NodeVisualizationKey JFBDDAMOHDF
		{
			[Cpp2IlInjected.Token(Token = "0x6000104")]
			[Cpp2IlInjected.Address(RVA = "0xFBE4F0", Offset = "0xFBCEF0", VA = "0x180FBE4F0", Slot = "83")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x1D54360", Offset = "0x1D52D60", VA = "0x181D54360")]
		public KEDHDHGGJMH(EJHJLJPPHCN BALKEACFDJN, BDIKLEBDMNE JACJPEOECBN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000046")]
	private sealed class ENONBCKAPMP : OJDKNDJFNFM<EEHADKDGBMH>
	{
		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public override NodeVisualizationKey JFBDDAMOHDF
		{
			[Cpp2IlInjected.Token(Token = "0x6000106")]
			[Cpp2IlInjected.Address(RVA = "0x890BA0", Offset = "0x88F5A0", VA = "0x180890BA0", Slot = "83")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x1D4C6C0", Offset = "0x1D4B0C0", VA = "0x181D4C6C0")]
		public ENONBCKAPMP(EJHJLJPPHCN BALKEACFDJN, EEHADKDGBMH JACJPEOECBN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x7C2240", Offset = "0x7C0C40", VA = "0x1807C2240", Slot = "107")]
		protected override bool NKCEPDJCADI(JLGMECJOLDI<EHGNFGGIBEB> NDKHLPHIJIN)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000047")]
	private sealed class DDNCLNIJBHD : OJDKNDJFNFM<JEJEKDCABPG>
	{
		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public override NodeVisualizationKey JFBDDAMOHDF
		{
			[Cpp2IlInjected.Token(Token = "0x6000109")]
			[Cpp2IlInjected.Address(RVA = "0x8A3970", Offset = "0x8A2370", VA = "0x1808A3970", Slot = "83")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public override bool CHDEIKLBCJC
		{
			[Cpp2IlInjected.Token(Token = "0x600010A")]
			[Cpp2IlInjected.Address(RVA = "0x1D45460", Offset = "0x1D43E60", VA = "0x181D45460", Slot = "84")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		protected override bool GGEOMGDLFKD
		{
			[Cpp2IlInjected.Token(Token = "0x600010B")]
			[Cpp2IlInjected.Address(RVA = "0x7C2240", Offset = "0x7C0C40", VA = "0x1807C2240", Slot = "82")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x1D453F0", Offset = "0x1D43DF0", VA = "0x181D453F0")]
		public DDNCLNIJBHD(EJHJLJPPHCN BALKEACFDJN, JEJEKDCABPG JACJPEOECBN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000048")]
	private sealed class JMKBGHLDLJE : OJDKNDJFNFM<DFOHANJBDEB>
	{
		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public override NodeVisualizationKey JFBDDAMOHDF
		{
			[Cpp2IlInjected.Token(Token = "0x600010D")]
			[Cpp2IlInjected.Address(RVA = "0x88CF40", Offset = "0x88B940", VA = "0x18088CF40", Slot = "83")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public override bool CHDEIKLBCJC
		{
			[Cpp2IlInjected.Token(Token = "0x600010E")]
			[Cpp2IlInjected.Address(RVA = "0x1D53C80", Offset = "0x1D52680", VA = "0x181D53C80", Slot = "84")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		protected override bool GGEOMGDLFKD
		{
			[Cpp2IlInjected.Token(Token = "0x600010F")]
			[Cpp2IlInjected.Address(RVA = "0x7C2240", Offset = "0x7C0C40", VA = "0x1807C2240", Slot = "82")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x1D53C10", Offset = "0x1D52610", VA = "0x181D53C10")]
		public JMKBGHLDLJE(EJHJLJPPHCN BALKEACFDJN, DFOHANJBDEB JACJPEOECBN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000049")]
	private sealed class DBMKDPGGOOP : PBLHJCOAKMM<ALFOCBEIAAF>
	{
		[Cpp2IlInjected.Token(Token = "0x17000039")]
		public override NodeVisualizationKey JFBDDAMOHDF
		{
			[Cpp2IlInjected.Token(Token = "0x6000111")]
			[Cpp2IlInjected.Address(RVA = "0x89AE20", Offset = "0x899820", VA = "0x18089AE20", Slot = "83")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x1D44FF0", Offset = "0x1D439F0", VA = "0x181D44FF0")]
		public DBMKDPGGOOP(EJHJLJPPHCN BALKEACFDJN, ALFOCBEIAAF JACJPEOECBN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004A")]
	public class OJDKNDJFNFM<TNode> : MJLPNDIJFMP, IDisposable where TNode : notnull, DLLEFNELPBJ
	{
		[Cpp2IlInjected.Token(Token = "0x200004B")]
		[CompilerGenerated]
		private sealed class AINLDOCMOAP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000E1")]
			public OJDKNDJFNFM<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000E2")]
			public EJHJLJPPHCN circuitsManager;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000E3")]
			public TNode node;

			[Cpp2IlInjected.Token(Token = "0x6000182")]
			[Cpp2IlInjected.Address(RVA = "0x7AE800", Offset = "0x7AD200", VA = "0x1807AE800")]
			public AINLDOCMOAP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000183")]
			[Cpp2IlInjected.Address(RVA = "0x3684F40", Offset = "0x3683940", VA = "0x183684F40")]
			internal ABKJNJFGHFI IGIPGAMALAP(AHNMMIBEPOP portGroup, int index)
			{
				return null;
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200004C")]
		[CompilerGenerated]
		private struct KKEECBGKLHL : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000E4")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000E5")]
			public AsyncTaskMethodBuilder<KKHLNMGODKL<PJHBHBBODGG, MPIKAEBOCFI>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000E6")]
			public OJDKNDJFNFM<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000E7")]
			public GJDJJMDPPKC? localPosition;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000E8")]
			public FKIBNGAKAAJ? localRotation;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000E9")]
			private TaskAwaiter<KKHLNMGODKL<PJHBHBBODGG, MPIKAEBOCFI>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000184")]
			[Cpp2IlInjected.Address(RVA = "0x3AA8A80", Offset = "0x3AA7480", VA = "0x183AA8A80", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000185")]
			[Cpp2IlInjected.Address(RVA = "0x3AA8D20", Offset = "0x3AA7720", VA = "0x183AA8D20", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200004D")]
		[CompilerGenerated]
		private struct JPEADBLONEG : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000EA")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000EB")]
			public AsyncTaskMethodBuilder<KKHLNMGODKL<PJHBHBBODGG, MPIKAEBOCFI>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000EC")]
			public OJDKNDJFNFM<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000ED")]
			public string newName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000EE")]
			private TaskAwaiter<KKHLNMGODKL<PJHBHBBODGG, MPIKAEBOCFI>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000186")]
			[Cpp2IlInjected.Address(RVA = "0x3A434A0", Offset = "0x3A41EA0", VA = "0x183A434A0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000187")]
			[Cpp2IlInjected.Address(RVA = "0x3A43700", Offset = "0x3A42100", VA = "0x183A43700", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		private EJHJLJPPHCN CAPMIPILDGH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		private readonly bool FOFNNDDEFDM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		private AGBIKGLHIDI<EHGNFGGIBEB, ABKJNJFGHFI> DOFIDNENBJA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		private AGBIKGLHIDI<EHGNFGGIBEB, EMOFHMMOPFO> HOMODKAODJD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		private List<Action> KGLCBDPIEPL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		[CompilerGenerated]
		private Action<JLGMECJOLDI<EHGNFGGIBEB>>? NLDAFIIEGBL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		[CompilerGenerated]
		private Action<JLGMECJOLDI<EHGNFGGIBEB>, EMOFHMMOPFO>? KENLPGNAOOE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		[CompilerGenerated]
		private Action<JLGMECJOLDI<EHGNFGGIBEB>, JLGMECJOLDI<EHGNFGGIBEB>>? CMIBCFAOMPF;

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		protected TNode ELLCAAINHDD
		{
			[Cpp2IlInjected.Token(Token = "0x6000116")]
			[Cpp2IlInjected.Address(RVA = "0x7A9100", Offset = "0x7A7B00", VA = "0x1807A9100")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		public JGKGEKHGJKB<ELOBPGFADAE> JLGIBHMNBEO
		{
			[Cpp2IlInjected.Token(Token = "0x6000117")]
			[Cpp2IlInjected.Address(RVA = "0x91D030", Offset = "0x91BA30", VA = "0x18091D030", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(JGKGEKHGJKB<ELOBPGFADAE>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public object NFJEJMOKBJJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000118")]
			[Cpp2IlInjected.Address(RVA = "0x320E4E0", Offset = "0x320CEE0", VA = "0x18320E4E0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		public virtual bool HBKLELLEJLD
		{
			[Cpp2IlInjected.Token(Token = "0x6000119")]
			[Cpp2IlInjected.Address(RVA = "0x7C2240", Offset = "0x7C0C40", VA = "0x1807C2240", Slot = "80")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public int IBKABMHFCJI
		{
			[Cpp2IlInjected.Token(Token = "0x600011A")]
			[Cpp2IlInjected.Address(RVA = "0x3F2E6E0", Offset = "0x3F2D0E0", VA = "0x183F2E6E0", Slot = "7")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		public PEMPOOCNEEL ADLLDGPLCHE
		{
			[Cpp2IlInjected.Token(Token = "0x600011C")]
			[Cpp2IlInjected.Address(RVA = "0x3F2E690", Offset = "0x3F2D090", VA = "0x183F2E690", Slot = "9")]
			get
			{
				return default(PEMPOOCNEEL);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		public string GLFKKFLFNDA
		{
			[Cpp2IlInjected.Token(Token = "0x600011D")]
			[Cpp2IlInjected.Address(RVA = "0x3F2EAB0", Offset = "0x3F2D4B0", VA = "0x183F2EAB0", Slot = "10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		protected virtual bool GGEOMGDLFKD
		{
			[Cpp2IlInjected.Token(Token = "0x600011E")]
			[Cpp2IlInjected.Address(RVA = "0x7EF8B0", Offset = "0x7EE2B0", VA = "0x1807EF8B0", Slot = "82")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		public virtual NodeVisualizationKey JFBDDAMOHDF
		{
			[Cpp2IlInjected.Token(Token = "0x600011F")]
			[Cpp2IlInjected.Address(RVA = "0x7A8380", Offset = "0x7A6D80", VA = "0x1807A8380", Slot = "83")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000043")]
		public JLGMECJOLDI<IALGBNHAPFA> MEBHHGHLNPO
		{
			[Cpp2IlInjected.Token(Token = "0x6000120")]
			[Cpp2IlInjected.Address(RVA = "0x8D27F0", Offset = "0x8D11F0", VA = "0x1808D27F0", Slot = "12")]
			[CompilerGenerated]
			get
			{
				return default(JLGMECJOLDI<IALGBNHAPFA>);
			}
			[Cpp2IlInjected.Token(Token = "0x6000121")]
			[Cpp2IlInjected.Address(RVA = "0x8FAC90", Offset = "0x8F9690", VA = "0x1808FAC90")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		public virtual bool CHDEIKLBCJC
		{
			[Cpp2IlInjected.Token(Token = "0x6000122")]
			[Cpp2IlInjected.Address(RVA = "0x7EF8B0", Offset = "0x7EE2B0", VA = "0x1807EF8B0", Slot = "84")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000045")]
		public virtual bool PBPOOPJDMNC
		{
			[Cpp2IlInjected.Token(Token = "0x6000123")]
			[Cpp2IlInjected.Address(RVA = "0x7EF8B0", Offset = "0x7EE2B0", VA = "0x1807EF8B0", Slot = "85")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000046")]
		public virtual LEMGGEBFAJE ALJDHPPBEPA
		{
			[Cpp2IlInjected.Token(Token = "0x6000124")]
			[Cpp2IlInjected.Address(RVA = "0x884050", Offset = "0x882A50", VA = "0x180884050", Slot = "86")]
			get
			{
				return default(LEMGGEBFAJE);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000047")]
		public bool FMJFBMHJFOA
		{
			[Cpp2IlInjected.Token(Token = "0x6000125")]
			[Cpp2IlInjected.Address(RVA = "0x3F2E4B0", Offset = "0x3F2CEB0", VA = "0x183F2E4B0", Slot = "16")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000048")]
		public bool MNPCELHFEEC
		{
			[Cpp2IlInjected.Token(Token = "0x6000126")]
			[Cpp2IlInjected.Address(RVA = "0x3F2E500", Offset = "0x3F2CF00", VA = "0x183F2E500", Slot = "17")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000049")]
		public bool JBAKGHPBDFA
		{
			[Cpp2IlInjected.Token(Token = "0x6000127")]
			[Cpp2IlInjected.Address(RVA = "0x3F2E550", Offset = "0x3F2CF50", VA = "0x183F2E550", Slot = "18")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004A")]
		public int CDFNIFMFLKP
		{
			[Cpp2IlInjected.Token(Token = "0x6000128")]
			[Cpp2IlInjected.Address(RVA = "0x3F2E900", Offset = "0x3F2D300", VA = "0x183F2E900", Slot = "19")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004B")]
		public bool DBMPDDLEHON
		{
			[Cpp2IlInjected.Token(Token = "0x6000129")]
			[Cpp2IlInjected.Address(RVA = "0x3F2E7D0", Offset = "0x3F2D1D0", VA = "0x183F2E7D0", Slot = "20")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004C")]
		public bool FHEKIOHKPIO
		{
			[Cpp2IlInjected.Token(Token = "0x600012A")]
			[Cpp2IlInjected.Address(RVA = "0x3F2E5F0", Offset = "0x3F2CFF0", VA = "0x183F2E5F0", Slot = "21")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004D")]
		public bool EIJPLCMAMEK
		{
			[Cpp2IlInjected.Token(Token = "0x600012B")]
			[Cpp2IlInjected.Address(RVA = "0xA63D80", Offset = "0xA62780", VA = "0x180A63D80", Slot = "22")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600012C")]
			[Cpp2IlInjected.Address(RVA = "0xA63DF0", Offset = "0xA627F0", VA = "0x180A63DF0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004E")]
		public virtual bool KGDMKDFPDEI
		{
			[Cpp2IlInjected.Token(Token = "0x600012D")]
			[Cpp2IlInjected.Address(RVA = "0x7EF8B0", Offset = "0x7EE2B0", VA = "0x1807EF8B0", Slot = "87")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004F")]
		public virtual bool OOJLOEKLLFO
		{
			[Cpp2IlInjected.Token(Token = "0x600012E")]
			[Cpp2IlInjected.Address(RVA = "0x3F2E5A0", Offset = "0x3F2CFA0", VA = "0x183F2E5A0", Slot = "88")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000050")]
		public bool BOGEOJHEIBE
		{
			[Cpp2IlInjected.Token(Token = "0x600012F")]
			[Cpp2IlInjected.Address(RVA = "0x3F2E720", Offset = "0x3F2D120", VA = "0x183F2E720", Slot = "25")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000051")]
		public GJDJJMDPPKC CMOOOBHDCMO
		{
			[Cpp2IlInjected.Token(Token = "0x6000130")]
			[Cpp2IlInjected.Address(RVA = "0x3F2E860", Offset = "0x3F2D260", VA = "0x183F2E860", Slot = "26")]
			get
			{
				return default(GJDJJMDPPKC);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000052")]
		public FKIBNGAKAAJ KFNAMDFIKPK
		{
			[Cpp2IlInjected.Token(Token = "0x6000132")]
			[Cpp2IlInjected.Address(RVA = "0x3F2E8B0", Offset = "0x3F2D2B0", VA = "0x183F2E8B0", Slot = "28")]
			get
			{
				return default(FKIBNGAKAAJ);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000053")]
		public virtual bool FJDNOGPEJCN
		{
			[Cpp2IlInjected.Token(Token = "0x6000150")]
			[Cpp2IlInjected.Address(RVA = "0x7EF8B0", Offset = "0x7EE2B0", VA = "0x1807EF8B0", Slot = "102")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000054")]
		public virtual PJMPOBCPFCC? FJODBLJGGDA
		{
			[Cpp2IlInjected.Token(Token = "0x6000151")]
			[Cpp2IlInjected.Address(RVA = "0x7A8380", Offset = "0x7A6D80", VA = "0x1807A8380", Slot = "103")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000055")]
		public virtual HAEIIAOAFCL? HENGNLPOJJG
		{
			[Cpp2IlInjected.Token(Token = "0x6000152")]
			[Cpp2IlInjected.Address(RVA = "0x7A8380", Offset = "0x7A6D80", VA = "0x1807A8380", Slot = "104")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000056")]
		public virtual IEnumerable<JGKGEKHGJKB<PNMLFKAJNIK>>? BBCCCKGLCDE
		{
			[Cpp2IlInjected.Token(Token = "0x6000153")]
			[Cpp2IlInjected.Address(RVA = "0x7A8380", Offset = "0x7A6D80", VA = "0x1807A8380", Slot = "105")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000057")]
		public bool EOILGIGIKCC
		{
			[Cpp2IlInjected.Token(Token = "0x6000158")]
			[Cpp2IlInjected.Address(RVA = "0x3F2E640", Offset = "0x3F2D040", VA = "0x183F2E640", Slot = "109")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000058")]
		public JGKGEKHGJKB<BIKLLPOLGEF> FPDPBGGPGBI
		{
			[Cpp2IlInjected.Token(Token = "0x6000159")]
			[Cpp2IlInjected.Address(RVA = "0x3F2E810", Offset = "0x3F2D210", VA = "0x183F2E810", Slot = "54")]
			get
			{
				return default(JGKGEKHGJKB<BIKLLPOLGEF>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000059")]
		public virtual bool HLPIPOKDALH
		{
			[Cpp2IlInjected.Token(Token = "0x600015A")]
			[Cpp2IlInjected.Address(RVA = "0x7EF8B0", Offset = "0x7EE2B0", VA = "0x1807EF8B0", Slot = "110")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005A")]
		public virtual JLGMECJOLDI<BIKLLPOLGEF>? IFELHIDPOGE
		{
			[Cpp2IlInjected.Token(Token = "0x600015B")]
			[Cpp2IlInjected.Address(RVA = "0x7A8380", Offset = "0x7A6D80", VA = "0x1807A8380", Slot = "111")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005B")]
		public virtual bool FFLOFPOGGHN
		{
			[Cpp2IlInjected.Token(Token = "0x600015C")]
			[Cpp2IlInjected.Address(RVA = "0x7EF8B0", Offset = "0x7EE2B0", VA = "0x1807EF8B0", Slot = "112")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005C")]
		public bool AIMOBMBMPIA
		{
			[Cpp2IlInjected.Token(Token = "0x600015D")]
			[Cpp2IlInjected.Address(RVA = "0x3F2E770", Offset = "0x3F2D170", VA = "0x183F2E770", Slot = "59")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005D")]
		public string BJAHCKCNPKD
		{
			[Cpp2IlInjected.Token(Token = "0x600015E")]
			[Cpp2IlInjected.Address(RVA = "0x7B3590", Offset = "0x7B1F90", VA = "0x1807B3590", Slot = "61")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600015F")]
			[Cpp2IlInjected.Address(RVA = "0x7B3550", Offset = "0x7B1F50", VA = "0x1807B3550")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005E")]
		public JGKGEKHGJKB<PNMLFKAJNIK> JPHLENIMIJH
		{
			[Cpp2IlInjected.Token(Token = "0x6000160")]
			[Cpp2IlInjected.Address(RVA = "0x3F2E940", Offset = "0x3F2D340", VA = "0x183F2E940", Slot = "60")]
			get
			{
				return default(JGKGEKHGJKB<PNMLFKAJNIK>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005F")]
		public JGKGEKHGJKB<PNMLFKAJNIK>? INJNJKBHJIC
		{
			[Cpp2IlInjected.Token(Token = "0x6000161")]
			[Cpp2IlInjected.Address(RVA = "0x3F2E990", Offset = "0x3F2D390", VA = "0x183F2E990", Slot = "113")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000060")]
		public DFAMOHODBNL<EHGNFGGIBEB, EMOFHMMOPFO> NFDNOOJFNCI
		{
			[Cpp2IlInjected.Token(Token = "0x6000162")]
			[Cpp2IlInjected.Address(RVA = "0x3F2EA70", Offset = "0x3F2D470", VA = "0x183F2EA70", Slot = "62")]
			get
			{
				return default(DFAMOHODBNL<EHGNFGGIBEB, EMOFHMMOPFO>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000061")]
		public virtual JLGMECJOLDI<EHGNFGGIBEB>? PIKBKFBPJPI
		{
			[Cpp2IlInjected.Token(Token = "0x6000163")]
			[Cpp2IlInjected.Address(RVA = "0x7A8380", Offset = "0x7A6D80", VA = "0x1807A8380", Slot = "114")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action EOICCPCIGEE
		{
			[Cpp2IlInjected.Token(Token = "0x6000139")]
			[Cpp2IlInjected.Address(RVA = "0x3F2A820", Offset = "0x3F29220", VA = "0x183F2A820", Slot = "35")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600013A")]
			[Cpp2IlInjected.Address(RVA = "0x3F2DF30", Offset = "0x3F2C930", VA = "0x183F2DF30", Slot = "36")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event NOABDFEDFIO ALGALAHDACJ
		{
			[Cpp2IlInjected.Token(Token = "0x600013C")]
			[Cpp2IlInjected.Address(RVA = "0x3F2DBA0", Offset = "0x3F2C5A0", VA = "0x183F2DBA0", Slot = "37")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600013D")]
			[Cpp2IlInjected.Address(RVA = "0x3F2AF90", Offset = "0x3F29990", VA = "0x183F2AF90", Slot = "38")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		public event CAKONDCONNA GIKKJIGLELJ
		{
			[Cpp2IlInjected.Token(Token = "0x600013E")]
			[Cpp2IlInjected.Address(RVA = "0x3F2BE10", Offset = "0x3F2A810", VA = "0x183F2BE10", Slot = "39")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600013F")]
			[Cpp2IlInjected.Address(RVA = "0x3F2B030", Offset = "0x3F29A30", VA = "0x183F2B030", Slot = "40")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000004")]
		public event Action NAEBEFBEBCG
		{
			[Cpp2IlInjected.Token(Token = "0x6000140")]
			[Cpp2IlInjected.Address(RVA = "0x3F2C220", Offset = "0x3F2AC20", VA = "0x183F2C220", Slot = "41")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000141")]
			[Cpp2IlInjected.Address(RVA = "0x3F2C690", Offset = "0x3F2B090", VA = "0x183F2C690", Slot = "42")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000005")]
		public event Action AMKKCFJADHK
		{
			[Cpp2IlInjected.Token(Token = "0x6000142")]
			[Cpp2IlInjected.Address(RVA = "0x3F2A780", Offset = "0x3F29180", VA = "0x183F2A780", Slot = "43")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000143")]
			[Cpp2IlInjected.Address(RVA = "0x3F2BD70", Offset = "0x3F2A770", VA = "0x183F2BD70", Slot = "44")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000006")]
		public event Action<JLGMECJOLDI<EHGNFGGIBEB>, EMOFHMMOPFO> KFCDLLNLBFD
		{
			[Cpp2IlInjected.Token(Token = "0x6000164")]
			[Cpp2IlInjected.Address(RVA = "0x3F2CF40", Offset = "0x3F2B940", VA = "0x183F2CF40", Slot = "64")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000165")]
			[Cpp2IlInjected.Address(RVA = "0x3F2D100", Offset = "0x3F2BB00", VA = "0x183F2D100", Slot = "65")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000007")]
		public event Action<JLGMECJOLDI<EHGNFGGIBEB>, EMOFHMMOPFO> HNNLOEFCHFP
		{
			[Cpp2IlInjected.Token(Token = "0x6000166")]
			[Cpp2IlInjected.Address(RVA = "0x3F2E060", Offset = "0x3F2CA60", VA = "0x183F2E060", Slot = "68")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000167")]
			[Cpp2IlInjected.Address(RVA = "0x3F2C100", Offset = "0x3F2AB00", VA = "0x183F2C100", Slot = "69")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000008")]
		public event Action<JLGMECJOLDI<EHGNFGGIBEB>> KLMFJJHMOFB
		{
			[Cpp2IlInjected.Token(Token = "0x6000168")]
			[Cpp2IlInjected.Address(RVA = "0x3F2BF80", Offset = "0x3F2A980", VA = "0x183F2BF80", Slot = "66")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000169")]
			[Cpp2IlInjected.Address(RVA = "0x3F2C460", Offset = "0x3F2AE60", VA = "0x183F2C460", Slot = "67")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000009")]
		public event Action<JLGMECJOLDI<EHGNFGGIBEB>, JLGMECJOLDI<EHGNFGGIBEB>> BLLNGGJIFAE
		{
			[Cpp2IlInjected.Token(Token = "0x600016A")]
			[Cpp2IlInjected.Address(RVA = "0x3F2C6F0", Offset = "0x3F2B0F0", VA = "0x183F2C6F0", Slot = "70")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600016B")]
			[Cpp2IlInjected.Address(RVA = "0x3F2C5D0", Offset = "0x3F2AFD0", VA = "0x183F2C5D0", Slot = "71")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000A")]
		public event Action<JLGMECJOLDI<EHGNFGGIBEB>, EMOFHMMOPFO> PHEDFFFDOGE
		{
			[Cpp2IlInjected.Token(Token = "0x600016C")]
			[Cpp2IlInjected.Address(RVA = "0x3F2C3A0", Offset = "0x3F2ADA0", VA = "0x183F2C3A0", Slot = "72")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600016D")]
			[Cpp2IlInjected.Address(RVA = "0x3F2DCE0", Offset = "0x3F2C6E0", VA = "0x183F2DCE0", Slot = "73")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x3F2E170", Offset = "0x3F2CB70", VA = "0x183F2E170")]
		[AOICGJECGOP("Creating the port adapter needs to actually read the `canInteract` state rather than just passing in `true`.")]
		[AOICGJECGOP("Need to handle `Name` better.")]
		public OJDKNDJFNFM(EJHJLJPPHCN BALKEACFDJN, TNode JACJPEOECBN, bool JPDNBBJIKBE = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x3F2D330", Offset = "0x3F2BD30", VA = "0x183F2D330", Slot = "78")]
		protected virtual void NGFHLNOOHDK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x3F2B500", Offset = "0x3F29F00", VA = "0x183F2B500", Slot = "79")]
		public virtual void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x3F2DDA0", Offset = "0x3F2C7A0", VA = "0x183F2DDA0", Slot = "81")]
		public virtual void OJNDMBEFBNB(int HOJFFFHJBLK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x3F2C1C0", Offset = "0x3F2ABC0", VA = "0x183F2C1C0")]
		public bool HLDAJJNGFAK([In] GJDJJMDPPKC FDFHGIHHGHO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x3F2D1C0", Offset = "0x3F2BBC0", VA = "0x183F2D1C0")]
		public bool MKMJMGLIEHC([In] FKIBNGAKAAJ FDFHGIHHGHO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x3F2C0B0", Offset = "0x3F2AAB0", VA = "0x183F2C0B0", Slot = "89")]
		public virtual void GPPOJGKKHEI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x3F2DA20", Offset = "0x3F2C420", VA = "0x183F2DA20", Slot = "31")]
		[AsyncStateMachine(typeof(OJDKNDJFNFM<>.KKEECBGKLHL))]
		public Task<KKHLNMGODKL<PJHBHBBODGG, MPIKAEBOCFI>> NGJADPLGLCB(GJDJJMDPPKC? HHCIOFKIDKC, FKIBNGAKAAJ? LBMMJMIDBPD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x7A8370", Offset = "0x7A6D70", VA = "0x1807A8370", Slot = "90")]
		public virtual void IBAAHCJONPM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x7A8370", Offset = "0x7A6D70", VA = "0x1807A8370", Slot = "91")]
		public virtual void NGJCCKGKGFH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x7A8370", Offset = "0x7A6D70", VA = "0x1807A8370", Slot = "92")]
		public virtual void HLLMLPFLLCL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x1A46F90", Offset = "0x1A45990", VA = "0x181A46F90")]
		protected void NMDGDBAJMCL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x3F2C090", Offset = "0x3F2AA90", VA = "0x183F2C090")]
		protected void GOGFMAINHLA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x1EE0090", Offset = "0x1EDEA90", VA = "0x181EE0090")]
		private void OGEPLIIHNDK([In] FKIBNGAKAAJ PGPLGEJKHLI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x3F2C2D0", Offset = "0x3F2ACD0", VA = "0x183F2C2D0", Slot = "93")]
		public virtual Task<KKHLNMGODKL<JLGMECJOLDI<EHGNFGGIBEB>, MPIKAEBOCFI>> IBIJJNOCACN(string OMHHPMIDNAN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x3F2BEB0", Offset = "0x3F2A8B0", VA = "0x183F2BEB0", Slot = "94")]
		public virtual Task<KKHLNMGODKL<PJHBHBBODGG, MPIKAEBOCFI>> FGDNNBPCBEC(JLGMECJOLDI<EHGNFGGIBEB> NDKHLPHIJIN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x3F2A730", Offset = "0x3F29130", VA = "0x183F2A730", Slot = "95")]
		public virtual void ACIPAJEEGDB(JLGMECJOLDI<EHGNFGGIBEB> OJANCMLFDOJ, JLGMECJOLDI<EHGNFGGIBEB> DAPOBFHGAGK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x3F2DFD0", Offset = "0x3F2C9D0", VA = "0x183F2DFD0", Slot = "96")]
		public virtual IEnumerable<PKBFCJOJFAD> PFCHNLEEGFF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x3F2A9E0", Offset = "0x3F293E0", VA = "0x183F2A9E0", Slot = "97")]
		public KKHLNMGODKL<PJHBHBBODGG, MPIKAEBOCFI> CABDHOJJGIP(string PEICKGKGHAI)
		{
			return default(KKHLNMGODKL<PJHBHBBODGG, MPIKAEBOCFI>);
		}

		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x3F2C7B0", Offset = "0x3F2B1B0", VA = "0x183F2C7B0", Slot = "45")]
		public bool JJMNPGOKCLH([Out] Guid DPMIIHFEEBA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x3F2C040", Offset = "0x3F2AA40", VA = "0x183F2C040", Slot = "98")]
		public virtual bool GMOKNPMHOEJ([In] Guid KGGOGFBCEKB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x3F2CD00", Offset = "0x3F2B700", VA = "0x183F2CD00", Slot = "99")]
		public virtual void KECAPFPCLAM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x7A8370", Offset = "0x7A6D70", VA = "0x1807A8370", Slot = "100")]
		public virtual void KKOJCHGOBJA(bool LIODGNOHHGC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x7A8380", Offset = "0x7A6D80", VA = "0x1807A8380", Slot = "101")]
		public virtual KILNJOKLPOP DGPJGAFCMFL([In] CALJGLBNEDG BICEODDIDAG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x3F2D000", Offset = "0x3F2BA00", VA = "0x183F2D000")]
		protected void MGMIOBGIPLH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x7A8370", Offset = "0x7A6D70", VA = "0x1807A8370", Slot = "106")]
		protected virtual void ILCFDPGELKK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x3F2DB70", Offset = "0x3F2C570", VA = "0x183F2DB70", Slot = "107")]
		protected virtual bool NKCEPDJCADI(JLGMECJOLDI<EHGNFGGIBEB> NDKHLPHIJIN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x7EF8B0", Offset = "0x7EE2B0", VA = "0x1807EF8B0", Slot = "108")]
		protected virtual bool PJFIHEFLFDO(JLGMECJOLDI<EHGNFGGIBEB> NDKHLPHIJIN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x7A8370", Offset = "0x7A6D70", VA = "0x1807A8370", Slot = "115")]
		protected virtual void OGMBKICALAL(GJCFPBDLHGK JHNIJCIGGOP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x7A8370", Offset = "0x7A6D70", VA = "0x1807A8370", Slot = "116")]
		protected virtual void AMOHDKNEFCM(GJCFPBDLHGK GCOOKAGLIEG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x3F2C900", Offset = "0x3F2B300", VA = "0x183F2C900", Slot = "74")]
		public void JPABEFCEDBH(GJCFPBDLHGK GCOOKAGLIEG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x3F2D220", Offset = "0x3F2BC20", VA = "0x183F2D220", Slot = "75")]
		public KIAFDOMBGOF MONCNJAMLHD()
		{
			return default(KIAFDOMBGOF);
		}

		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x7EF8B0", Offset = "0x7EE2B0", VA = "0x1807EF8B0", Slot = "117")]
		public virtual bool FAOJBIOIACL(JLGMECJOLDI<EHGNFGGIBEB> NDKHLPHIJIN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x1189A30", Offset = "0x1188430", VA = "0x181189A30")]
		private void PADIGDFDFMH([In] GJDJJMDPPKC HGKJDOIPDNM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x3F2CDC0", Offset = "0x3F2B7C0", VA = "0x183F2CDC0")]
		private void LKNFMCCHMEJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x3F2AA60", Offset = "0x3F29460", VA = "0x183F2AA60")]
		private void CHGFPLOHHCK(int HMIKABPPNGL, AHNMMIBEPOP DDBONMICPOE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x3F2E120", Offset = "0x3F2CB20", VA = "0x183F2E120")]
		private void PNFKHFCLLKJ(int OJANCMLFDOJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x3F2DDF0", Offset = "0x3F2C7F0", VA = "0x183F2DDF0")]
		private void PBEKNLGHNKF(int OJANCMLFDOJ, AHNMMIBEPOP DIEGEFNANKJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x3F2C950", Offset = "0x3F2B350", VA = "0x183F2C950")]
		private void KBDHKHDEEDE(int NPHKOFFKJMB, int CPLMOFDCCAP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x3F2C520", Offset = "0x3F2AF20", VA = "0x183F2C520")]
		private void IGNGNJLEGNJ(int NPHKOFFKJMB, int CPLMOFDCCAP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x3F2C580", Offset = "0x3F2AF80", VA = "0x183F2C580")]
		private void IJBNFFBCKDM(int OJANCMLFDOJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x3F2B0D0", Offset = "0x3F29AD0", VA = "0x183F2B0D0")]
		private void DDMAJCBPCDO(int HMIKABPPNGL, AHNMMIBEPOP DDBONMICPOE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x3F2CEC0", Offset = "0x3F2B8C0", VA = "0x183F2CEC0")]
		private void MBKEABJABNG(int OJANCMLFDOJ, AHNMMIBEPOP DIEGEFNANKJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x3F2A8C0", Offset = "0x3F292C0", VA = "0x183F2A8C0", Slot = "118")]
		[AsyncStateMachine(typeof(OJDKNDJFNFM<>.JPEADBLONEG))]
		public virtual Task<KKHLNMGODKL<PJHBHBBODGG, MPIKAEBOCFI>> BBEOJGOMDOI(string PEICKGKGHAI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x3F2CD50", Offset = "0x3F2B750", VA = "0x183F2CD50", Slot = "52")]
		private void LIHFFPNJJJC(object GBKOLHALMHO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x3F2DC70", Offset = "0x3F2C670", VA = "0x183F2DC70", Slot = "53")]
		private void OBDMIONHPPP(object GBKOLHALMHO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x3F2DC40", Offset = "0x3F2C640", VA = "0x183F2DC40", Slot = "27")]
		private bool NOJFPLKJHEG([In] GJDJJMDPPKC FDFHGIHHGHO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x3F2D300", Offset = "0x3F2BD00", VA = "0x183F2D300", Slot = "29")]
		private bool NAKDKEJHCJF([In] FKIBNGAKAAJ FDFHGIHHGHO)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004E")]
	private sealed class IHMFLEFICDM : PBLHJCOAKMM<GBIECEFFBOA>
	{
		[Cpp2IlInjected.Token(Token = "0x17000062")]
		public override NodeVisualizationKey JFBDDAMOHDF
		{
			[Cpp2IlInjected.Token(Token = "0x6000188")]
			[Cpp2IlInjected.Address(RVA = "0xAAC680", Offset = "0xAAB080", VA = "0x180AAC680", Slot = "83")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x1D52510", Offset = "0x1D50F10", VA = "0x181D52510")]
		public IHMFLEFICDM(EJHJLJPPHCN BALKEACFDJN, GBIECEFFBOA JACJPEOECBN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004F")]
	private sealed class NFIOOJLNFMK : LBIEPDJGOBN<EGPCLGAOFMG>
	{
		[Cpp2IlInjected.Token(Token = "0x17000063")]
		public override NodeVisualizationKey JFBDDAMOHDF
		{
			[Cpp2IlInjected.Token(Token = "0x600018A")]
			[Cpp2IlInjected.Address(RVA = "0x7F2CB0", Offset = "0x7F16B0", VA = "0x1807F2CB0", Slot = "83")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x1D57850", Offset = "0x1D56250", VA = "0x181D57850")]
		public NFIOOJLNFMK(EJHJLJPPHCN BALKEACFDJN, EGPCLGAOFMG JACJPEOECBN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000050")]
	private sealed class JEGGHNFFBLD : OJDKNDJFNFM<IDNHOEDOLEK>
	{
		[Cpp2IlInjected.Token(Token = "0x17000064")]
		public override NodeVisualizationKey JFBDDAMOHDF
		{
			[Cpp2IlInjected.Token(Token = "0x600018C")]
			[Cpp2IlInjected.Address(RVA = "0x85D220", Offset = "0x85BC20", VA = "0x18085D220", Slot = "83")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x1D52570", Offset = "0x1D50F70", VA = "0x181D52570")]
		public JEGGHNFFBLD(EJHJLJPPHCN BALKEACFDJN, IDNHOEDOLEK JACJPEOECBN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000051")]
	private sealed class HCNJNPCNDCA : LBIEPDJGOBN<HKKDDCBLCIE>
	{
		[Cpp2IlInjected.Token(Token = "0x17000065")]
		public override NodeVisualizationKey JFBDDAMOHDF
		{
			[Cpp2IlInjected.Token(Token = "0x600018E")]
			[Cpp2IlInjected.Address(RVA = "0x7F2CB0", Offset = "0x7F16B0", VA = "0x1807F2CB0", Slot = "83")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x1D4F230", Offset = "0x1D4DC30", VA = "0x181D4F230")]
		public HCNJNPCNDCA(EJHJLJPPHCN BALKEACFDJN, HKKDDCBLCIE JACJPEOECBN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000052")]
	private sealed class IBMIFIEGDAL : LBIEPDJGOBN<ENDFNPOLALL>
	{
		[Cpp2IlInjected.Token(Token = "0x17000066")]
		public override NodeVisualizationKey JFBDDAMOHDF
		{
			[Cpp2IlInjected.Token(Token = "0x6000190")]
			[Cpp2IlInjected.Address(RVA = "0x7F2CB0", Offset = "0x7F16B0", VA = "0x1807F2CB0", Slot = "83")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x1D51CB0", Offset = "0x1D506B0", VA = "0x181D51CB0")]
		public IBMIFIEGDAL(EJHJLJPPHCN BALKEACFDJN, ENDFNPOLALL JACJPEOECBN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000053")]
	private sealed class DFKLOOPKHDP : OJDKNDJFNFM<MHNMLPPHAKO>
	{
		[Cpp2IlInjected.Token(Token = "0x17000067")]
		public override NodeVisualizationKey JFBDDAMOHDF
		{
			[Cpp2IlInjected.Token(Token = "0x6000192")]
			[Cpp2IlInjected.Address(RVA = "0xBB1DB0", Offset = "0xBB07B0", VA = "0x180BB1DB0", Slot = "83")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x1D458C0", Offset = "0x1D442C0", VA = "0x181D458C0")]
		public DFKLOOPKHDP(EJHJLJPPHCN BALKEACFDJN, MHNMLPPHAKO JACJPEOECBN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000054")]
	private sealed class GNEJJHPGHGP : OJDKNDJFNFM<BLJBEEIADDN>
	{
		[Cpp2IlInjected.Token(Token = "0x17000068")]
		public override NodeVisualizationKey JFBDDAMOHDF
		{
			[Cpp2IlInjected.Token(Token = "0x6000194")]
			[Cpp2IlInjected.Address(RVA = "0x7A8380", Offset = "0x7A6D80", VA = "0x1807A8380", Slot = "83")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000069")]
		protected override bool GGEOMGDLFKD
		{
			[Cpp2IlInjected.Token(Token = "0x6000195")]
			[Cpp2IlInjected.Address(RVA = "0x7C2240", Offset = "0x7C0C40", VA = "0x1807C2240", Slot = "82")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x1D4EC30", Offset = "0x1D4D630", VA = "0x181D4EC30")]
		public GNEJJHPGHGP(EJHJLJPPHCN BALKEACFDJN, BLJBEEIADDN JACJPEOECBN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000055")]
	private sealed class KDNLPJJFLEG : OJDKNDJFNFM<NPMIMCMCHEP>
	{
		[Cpp2IlInjected.Token(Token = "0x1700006A")]
		public override NodeVisualizationKey JFBDDAMOHDF
		{
			[Cpp2IlInjected.Token(Token = "0x6000197")]
			[Cpp2IlInjected.Address(RVA = "0x8901E0", Offset = "0x88EBE0", VA = "0x1808901E0", Slot = "83")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x1D542F0", Offset = "0x1D52CF0", VA = "0x181D542F0")]
		public KDNLPJJFLEG(EJHJLJPPHCN BALKEACFDJN, NPMIMCMCHEP JACJPEOECBN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x1D57F60", Offset = "0x1D56960", VA = "0x181D57F60")]
	internal static MJLPNDIJFMP JKJFENIAMEL(EJHJLJPPHCN BALKEACFDJN, DLLEFNELPBJ JACJPEOECBN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
public sealed class LJGDDJCHKDC : FFGBDPICEGI, INIGIGGLLDP, HEBBHDMMKAE, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700006B")]
	public JLGMECJOLDI<NIIHBFDIOKM> IFFFNFOMPKJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0xD0CBC0", Offset = "0xD0B5C0", VA = "0x180D0CBC0", Slot = "23")]
		[CompilerGenerated]
		get
		{
			return default(JLGMECJOLDI<NIIHBFDIOKM>);
		}
		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0xD0BDA0", Offset = "0xD0A7A0", VA = "0x180D0BDA0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006C")]
	public override JLGMECJOLDI<FKIAAIPKAOJ> HGIHJLEFAOP
	{
		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x1D55DC0", Offset = "0x1D547C0", VA = "0x181D55DC0", Slot = "19")]
		get
		{
			return default(JLGMECJOLDI<FKIAAIPKAOJ>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(RVA = "0x1D56120", Offset = "0x1D54B20", VA = "0x181D56120")]
	private LJGDDJCHKDC(EJHJLJPPHCN BALKEACFDJN, DLLEFNELPBJ JACJPEOECBN, MIMLJFBOMCO KAJFPKMAFLJ, JLGMECJOLDI<EHGNFGGIBEB> NDKHLPHIJIN, JLGMECJOLDI<NIIHBFDIOKM> FLOGJHFICGN, bool OBPFIAGBNAK, string OMHHPMIDNAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0x1D55E00", Offset = "0x1D54800", VA = "0x181D55E00")]
	public static LJGDDJCHKDC JKJFENIAMEL(EJHJLJPPHCN BALKEACFDJN, DLLEFNELPBJ JACJPEOECBN, MIMLJFBOMCO JJLMPGHEIDC, JLGMECJOLDI<EHGNFGGIBEB> NDKHLPHIJIN, JLGMECJOLDI<KFBDPPFJJPB> KKDLHAPIIII, JLGMECJOLDI<NIIHBFDIOKM> FLOGJHFICGN, bool OBPFIAGBNAK, bool JPDNBBJIKBE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(RVA = "0xD0BDA0", Offset = "0xD0A7A0", VA = "0x180D0BDA0")]
	internal void FAMPGMJOJEE(JLGMECJOLDI<NIIHBFDIOKM> FDFHGIHHGHO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
public abstract class FFGBDPICEGI : HEBBHDMMKAE, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000058")]
	private struct HBCJLKCCPOD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		private MDAFEHJGBEE? AAPIAOJEHDB;

		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x1D4F220", Offset = "0x1D4DC20", VA = "0x181D4F220")]
		public void NJLBNDAIMDB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x1D4F180", Offset = "0x1D4DB80", VA = "0x181D4F180")]
		public MDAFEHJGBEE KNLIKPNPJOO(FFGBDPICEGI MLJFICGOGLJ)
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	protected readonly EJHJLJPPHCN CAPMIPILDGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	protected readonly DLLEFNELPBJ MPFJAIOGBBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	private HBCJLKCCPOD AMDANFLFGJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	private readonly AHBHEMABBDB CLFPCNLCEBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	private readonly List<HBPELELLOPD> AFPKBJMJDDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	private readonly List<CLPEBMKMKBN> FFAEJPOAAEH;

	[Cpp2IlInjected.Token(Token = "0x1700006D")]
	public IEnumerable<StaticEdge> NDCOMLFMJOB
	{
		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x1D4D100", Offset = "0x1D4BB00", VA = "0x181D4D100", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006E")]
	public DisplayKind GGNLJELAGKI
	{
		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x7B71C0", Offset = "0x7B5BC0", VA = "0x1807B71C0", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(DisplayKind);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006F")]
	public JGKGEKHGJKB<BIKLLPOLGEF> IIPFNMCCMGF
	{
		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x1D4D930", Offset = "0x1D4C330", VA = "0x181D4D930", Slot = "6")]
		get
		{
			return default(JGKGEKHGJKB<BIKLLPOLGEF>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000070")]
	public FFGBDNDMLII NOKBLKOHDHH
	{
		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x18E0510", Offset = "0x18DEF10", VA = "0x1818E0510")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000071")]
	public JMOOPHLIAJE HICAOJAALEP
	{
		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0x1D4D740", Offset = "0x1D4C140", VA = "0x181D4D740", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000072")]
	protected MDAFEHJGBEE CKPKCPOEFGL
	{
		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0x1D4D740", Offset = "0x1D4C140", VA = "0x181D4D740")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000073")]
	public PortImage EBIDCBCELNF
	{
		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0x1D4D610", Offset = "0x1D4C010", VA = "0x181D4D610", Slot = "12")]
		get
		{
			return default(PortImage);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000074")]
	public string BJAHCKCNPKD
	{
		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x7A9220", Offset = "0x7A7C20", VA = "0x1807A9220", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x7A9240", Offset = "0x7A7C40", VA = "0x1807A9240")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000075")]
	public JGKGEKHGJKB<PNMLFKAJNIK> JPHLENIMIJH
	{
		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x1D4D5F0", Offset = "0x1D4BFF0", VA = "0x181D4D5F0", Slot = "8")]
		get
		{
			return default(JGKGEKHGJKB<PNMLFKAJNIK>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000076")]
	public JLGMECJOLDI<EHGNFGGIBEB> CGGGCAKEBIP
	{
		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x87A830", Offset = "0x879230", VA = "0x18087A830", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return default(JLGMECJOLDI<EHGNFGGIBEB>);
		}
		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x177AF90", Offset = "0x1779990", VA = "0x18177AF90")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000077")]
	public abstract JLGMECJOLDI<FKIAAIPKAOJ> HGIHJLEFAOP
	{
		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60001AC")]
	[Cpp2IlInjected.Address(RVA = "0x1D4D9C0", Offset = "0x1D4C3C0", VA = "0x181D4D9C0")]
	protected FFGBDPICEGI(EJHJLJPPHCN BALKEACFDJN, DLLEFNELPBJ JACJPEOECBN, AHBHEMABBDB MLNIMFJMHMP, JLGMECJOLDI<EHGNFGGIBEB> NDKHLPHIJIN, bool OBPFIAGBNAK, string OMHHPMIDNAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AD")]
	[Cpp2IlInjected.Address(RVA = "0x1D4D7E0", Offset = "0x1D4C1E0", VA = "0x181D4D7E0", Slot = "20")]
	protected virtual void NGFHLNOOHDK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AE")]
	[Cpp2IlInjected.Address(RVA = "0x1D4CA20", Offset = "0x1D4B420", VA = "0x181D4CA20", Slot = "21")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AF")]
	[Cpp2IlInjected.Address(RVA = "0x1D4C730", Offset = "0x1D4B130", VA = "0x181D4C730", Slot = "13")]
	public void BEOMHADBKBC(HBPELELLOPD AHCFJOOAJDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B0")]
	[Cpp2IlInjected.Address(RVA = "0x1D4D960", Offset = "0x1D4C360", VA = "0x181D4D960", Slot = "14")]
	public void PBILCFLLJKP(CLPEBMKMKBN AHCFJOOAJDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B1")]
	[Cpp2IlInjected.Address(RVA = "0x1D4CB70", Offset = "0x1D4B570", VA = "0x181D4CB70", Slot = "15")]
	public void ECDPDHKEDEL(HMJEIHCLKCA EAEGBKJOMLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B2")]
	[Cpp2IlInjected.Address(RVA = "0x1D4D400", Offset = "0x1D4BE00", VA = "0x181D4D400", Slot = "22")]
	protected virtual void HAMKPEPNOEK(HMJEIHCLKCA EAEGBKJOMLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B3")]
	[Cpp2IlInjected.Address(RVA = "0x1D4D460", Offset = "0x1D4BE60", VA = "0x181D4D460")]
	private void HEJOJAPCGCL(bool JHEMNDMHNOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B4")]
	[Cpp2IlInjected.Address(RVA = "0x1D4C7F0", Offset = "0x1D4B1F0", VA = "0x181D4C7F0")]
	private void BOCJJOLONDL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B5")]
	[Cpp2IlInjected.Address(RVA = "0x1D4D250", Offset = "0x1D4BC50", VA = "0x181D4D250")]
	private void FMGCBIBPBID([In] EALLJECGGFN JADABKAPDDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(RVA = "0x1D4C790", Offset = "0x1D4B190", VA = "0x181D4C790", Slot = "16")]
	public void BMJCAONCKMN(HBPELELLOPD AHCFJOOAJDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B7")]
	[Cpp2IlInjected.Address(RVA = "0x1D4C9C0", Offset = "0x1D4B3C0", VA = "0x181D4C9C0", Slot = "17")]
	public void DLKLFOJOJOH(CLPEBMKMKBN AHCFJOOAJDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(RVA = "0x7A9240", Offset = "0x7A7C40", VA = "0x1807A9240")]
	internal void NGHBEHLFFDA(string OMHHPMIDNAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B9")]
	[Cpp2IlInjected.Address(RVA = "0x1D4C9A0", Offset = "0x1D4B3A0", VA = "0x181D4C9A0")]
	internal void DEPPJACMFPB(DPEJEGBGJGD NFFMMJBNJIB, FFGBDNDMLII ADAMDPHPFAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BA")]
	[Cpp2IlInjected.Address(RVA = "0x177AF90", Offset = "0x1779990", VA = "0x18177AF90")]
	internal void NLFANOEJJPI(JLGMECJOLDI<EHGNFGGIBEB> NDKHLPHIJIN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public sealed class ABKJNJFGHFI : EMOFHMMOPFO, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200005B")]
	[CompilerGenerated]
	private sealed class AINKCEJDLMG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000118")]
		public EJHJLJPPHCN circuitsManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000119")]
		public DLLEFNELPBJ node;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400011A")]
		public JLGMECJOLDI<EHGNFGGIBEB> portGroupId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x400011B")]
		public bool canInteract;

		[Cpp2IlInjected.FieldOffset(Offset = "0x25")]
		[Cpp2IlInjected.Token(Token = "0x400011C")]
		public bool ignoreChipConfigPortNames;

		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(RVA = "0x7AE800", Offset = "0x7AD200", VA = "0x1807AE800")]
		public AINKCEJDLMG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(RVA = "0x1D43930", Offset = "0x1D42330", VA = "0x181D43930")]
		internal DLKAMECFEEF FCLBCCELNKJ((int PortDescIndex, int PortIndex, BFMMFHJHKDA InputPort) i)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(RVA = "0x1D438A0", Offset = "0x1D422A0", VA = "0x181D438A0")]
		internal LJGDDJCHKDC AELBGJCHLPC(MIMLJFBOMCO i, int idx)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200005C")]
	[CompilerGenerated]
	private struct KJLJCGMBGBK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400011D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400011E")]
		public AsyncTaskMethodBuilder<KKHLNMGODKL<PJHBHBBODGG, MPIKAEBOCFI>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400011F")]
		public ABKJNJFGHFI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000120")]
		private CFPCGPKJOEC <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		private TaskAwaiter<KKHLNMGODKL<PJHBHBBODGG, MPIKAEBOCFI>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0x1D54C60", Offset = "0x1D53660", VA = "0x181D54C60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000207")]
		[Cpp2IlInjected.Address(RVA = "0x1D550C0", Offset = "0x1D53AC0", VA = "0x181D550C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200005E")]
	[CompilerGenerated]
	private struct MLCJKLHGCCP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000124")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000125")]
		public AsyncTaskMethodBuilder<KKHLNMGODKL<PJHBHBBODGG, MPIKAEBOCFI>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000126")]
		public ABKJNJFGHFI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000127")]
		public JLGMECJOLDI<NJIGMIHFIFI> inputDefId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000128")]
		private CFPCGPKJOEC <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000129")]
		private TaskAwaiter<KKHLNMGODKL<PJHBHBBODGG, MPIKAEBOCFI>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600020B")]
		[Cpp2IlInjected.Address(RVA = "0x1D56C90", Offset = "0x1D55690", VA = "0x181D56C90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0x1D56FE0", Offset = "0x1D559E0", VA = "0x181D56FE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200005F")]
	[CompilerGenerated]
	private struct GMNJALFEDDK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400012A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400012B")]
		public AsyncTaskMethodBuilder<KKHLNMGODKL<PJHBHBBODGG, MPIKAEBOCFI>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400012C")]
		public ABKJNJFGHFI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400012D")]
		public JLGMECJOLDI<KFBDPPFJJPB> outputDefId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400012E")]
		private CFPCGPKJOEC <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400012F")]
		private TaskAwaiter<KKHLNMGODKL<PJHBHBBODGG, MPIKAEBOCFI>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(RVA = "0x1D4E870", Offset = "0x1D4D270", VA = "0x181D4E870", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0x1D4EBC0", Offset = "0x1D4D5C0", VA = "0x181D4EBC0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000060")]
	[CompilerGenerated]
	private struct EMCKLMEJJPD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000130")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000131")]
		public AsyncTaskMethodBuilder<KKHLNMGODKL<PJHBHBBODGG, MPIKAEBOCFI>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000132")]
		public ABKJNJFGHFI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		public JLGMECJOLDI<NJIGMIHFIFI> inputDefId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		public JLGMECJOLDI<NJIGMIHFIFI> targetIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		private CFPCGPKJOEC <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000136")]
		private TaskAwaiter<KKHLNMGODKL<PJHBHBBODGG, MPIKAEBOCFI>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0x1D4BEB0", Offset = "0x1D4A8B0", VA = "0x181D4BEB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(RVA = "0x1D4C200", Offset = "0x1D4AC00", VA = "0x181D4C200", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000061")]
	[CompilerGenerated]
	private struct KAAJPICKMAL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000137")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000138")]
		public AsyncTaskMethodBuilder<KKHLNMGODKL<PJHBHBBODGG, MPIKAEBOCFI>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000139")]
		public ABKJNJFGHFI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400013A")]
		public JLGMECJOLDI<KFBDPPFJJPB> outputDefId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x400013B")]
		public JLGMECJOLDI<KFBDPPFJJPB> targetIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400013C")]
		private CFPCGPKJOEC <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400013D")]
		private TaskAwaiter<KKHLNMGODKL<PJHBHBBODGG, MPIKAEBOCFI>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(RVA = "0x1D53F20", Offset = "0x1D52920", VA = "0x181D53F20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(RVA = "0x1D54270", Offset = "0x1D52C70", VA = "0x181D54270", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000062")]
	[CompilerGenerated]
	private struct PIJPHALKAMJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400013E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400013F")]
		public AsyncTaskMethodBuilder<KKHLNMGODKL<PJHBHBBODGG, MPIKAEBOCFI>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000140")]
		public ABKJNJFGHFI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000141")]
		private CFPCGPKJOEC <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000142")]
		private TaskAwaiter<KKHLNMGODKL<PJHBHBBODGG, MPIKAEBOCFI>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000213")]
		[Cpp2IlInjected.Address(RVA = "0x1D58EF0", Offset = "0x1D578F0", VA = "0x181D58EF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000214")]
		[Cpp2IlInjected.Address(RVA = "0x1D59360", Offset = "0x1D57D60", VA = "0x181D59360", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000063")]
	[CompilerGenerated]
	private struct PJEPKEAFJFA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000143")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000144")]
		public AsyncTaskMethodBuilder<KKHLNMGODKL<PJHBHBBODGG, MPIKAEBOCFI>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000145")]
		public ABKJNJFGHFI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000146")]
		public string newName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000147")]
		private CFPCGPKJOEC <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000148")]
		private TaskAwaiter<KKHLNMGODKL<PJHBHBBODGG, MPIKAEBOCFI>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000215")]
		[Cpp2IlInjected.Address(RVA = "0x1D593D0", Offset = "0x1D57DD0", VA = "0x181D593D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000216")]
		[Cpp2IlInjected.Address(RVA = "0x1D59720", Offset = "0x1D58120", VA = "0x181D59720", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000064")]
	[CompilerGenerated]
	private struct NGCNFGIGJLC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000149")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400014A")]
		public AsyncTaskMethodBuilder<KKHLNMGODKL<PJHBHBBODGG, MPIKAEBOCFI>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400014B")]
		public ABKJNJFGHFI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400014C")]
		public JLGMECJOLDI<NJIGMIHFIFI> inputDefId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400014D")]
		public string name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400014E")]
		private CFPCGPKJOEC <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400014F")]
		private TaskAwaiter<KKHLNMGODKL<PJHBHBBODGG, MPIKAEBOCFI>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000217")]
		[Cpp2IlInjected.Address(RVA = "0x1D578B0", Offset = "0x1D562B0", VA = "0x181D578B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000218")]
		[Cpp2IlInjected.Address(RVA = "0x1D57C00", Offset = "0x1D56600", VA = "0x181D57C00", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000065")]
	[CompilerGenerated]
	private struct PONKNCILGOP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000150")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000151")]
		public AsyncTaskMethodBuilder<KKHLNMGODKL<PJHBHBBODGG, MPIKAEBOCFI>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000152")]
		public ABKJNJFGHFI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000153")]
		public JLGMECJOLDI<KFBDPPFJJPB> outputDefId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000154")]
		public string name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000155")]
		private CFPCGPKJOEC <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000156")]
		private TaskAwaiter<KKHLNMGODKL<PJHBHBBODGG, MPIKAEBOCFI>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000219")]
		[Cpp2IlInjected.Address(RVA = "0x1D59790", Offset = "0x1D58190", VA = "0x181D59790", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(RVA = "0x1D59AE0", Offset = "0x1D584E0", VA = "0x181D59AE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000066")]
	[CompilerGenerated]
	private struct DGBGMJIBNAI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000157")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000158")]
		public AsyncTaskMethodBuilder<KKHLNMGODKL<PJHBHBBODGG, MPIKAEBOCFI>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000159")]
		public ABKJNJFGHFI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400015A")]
		public NKJCMKKBOGB type;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400015B")]
		public JLGMECJOLDI<NJIGMIHFIFI> inputDefId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400015C")]
		private CFPCGPKJOEC <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400015D")]
		private TaskAwaiter<KKHLNMGODKL<PJHBHBBODGG, MPIKAEBOCFI>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600021B")]
		[Cpp2IlInjected.Address(RVA = "0x1D46350", Offset = "0x1D44D50", VA = "0x181D46350", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021C")]
		[Cpp2IlInjected.Address(RVA = "0x1D466E0", Offset = "0x1D450E0", VA = "0x181D466E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000067")]
	[CompilerGenerated]
	private struct DGBPOGDBGID : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400015E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400015F")]
		public AsyncTaskMethodBuilder<KKHLNMGODKL<PJHBHBBODGG, MPIKAEBOCFI>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000160")]
		public ABKJNJFGHFI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000161")]
		public NKJCMKKBOGB type;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000162")]
		public JLGMECJOLDI<KFBDPPFJJPB> outputDefId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000163")]
		private CFPCGPKJOEC <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000164")]
		private TaskAwaiter<KKHLNMGODKL<PJHBHBBODGG, MPIKAEBOCFI>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600021D")]
		[Cpp2IlInjected.Address(RVA = "0x1D46750", Offset = "0x1D45150", VA = "0x181D46750", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021E")]
		[Cpp2IlInjected.Address(RVA = "0x1D46AE0", Offset = "0x1D454E0", VA = "0x181D46AE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	private readonly bool CMOOOKJJEEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	private readonly EJHJLJPPHCN CAPMIPILDGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	private readonly bool FBJKJDELMHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	private DFAMOHODBNL<ALOBLIADAMK, DLKAMECFEEF> LJGHFABDIPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	private DFAMOHODBNL<ALOBLIADAMK, GHLMOHBOPLK> EFACFLOGLMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	private readonly DLLEFNELPBJ MPFJAIOGBBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	private DFAMOHODBNL<NIIHBFDIOKM, LJGDDJCHKDC> JLABDEACJAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	private DFAMOHODBNL<NIIHBFDIOKM, INIGIGGLLDP> AAOHMCFBDII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	private string? GBKGIJJLONA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	private readonly AHNMMIBEPOP OKOLODFOFOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	private JLGMECJOLDI<EHGNFGGIBEB> BOMPOGNEMDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	private readonly bool FOFNNDDEFDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	[CompilerGenerated]
	private Action? FGBABIALFPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	[CompilerGenerated]
	private Action? EBAEOAHOCNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400010C")]
	[CompilerGenerated]
	private Action? INMOJHBDDFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	[CompilerGenerated]
	private Action<JLGMECJOLDI<ALOBLIADAMK>>? GOLJKNDPLLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	[CompilerGenerated]
	private Action<JLGMECJOLDI<NIIHBFDIOKM>>? ANEGBCNJKLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	[CompilerGenerated]
	private EMOFHMMOPFO.NFLNIJILDMN? CIKIFHCICLG;

	[Cpp2IlInjected.Token(Token = "0x17000078")]
	public bool DOHDMHACIJG
	{
		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x1D3D810", Offset = "0x1D3C210", VA = "0x181D3D810", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000079")]
	public bool JHMAFJDOLGD
	{
		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x1D3F1B0", Offset = "0x1D3DBB0", VA = "0x181D3F1B0", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007A")]
	public bool CLLLGBILEJF
	{
		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x1D41920", Offset = "0x1D40320", VA = "0x181D41920", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007B")]
	public JGKGEKHGJKB<BIKLLPOLGEF> IIPFNMCCMGF
	{
		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x1D42E10", Offset = "0x1D41810", VA = "0x181D42E10", Slot = "7")]
		get
		{
			return default(JGKGEKHGJKB<BIKLLPOLGEF>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007C")]
	public bool BHCJBOKBHOL
	{
		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x1D40720", Offset = "0x1D3F120", VA = "0x181D40720", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007D")]
	public DFAMOHODBNL<ALOBLIADAMK, GHLMOHBOPLK> NNIPPIPAOAO
	{
		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x7A9100", Offset = "0x7A7B00", VA = "0x1807A9100", Slot = "9")]
		get
		{
			return default(DFAMOHODBNL<ALOBLIADAMK, GHLMOHBOPLK>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007E")]
	public string BJAHCKCNPKD
	{
		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x1D41B60", Offset = "0x1D40560", VA = "0x181D41B60", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007F")]
	public JGKGEKHGJKB<PNMLFKAJNIK> JPHLENIMIJH
	{
		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x1D40D10", Offset = "0x1D3F710", VA = "0x181D40D10", Slot = "11")]
		get
		{
			return default(JGKGEKHGJKB<PNMLFKAJNIK>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000080")]
	public DFAMOHODBNL<NIIHBFDIOKM, INIGIGGLLDP> HFNDEPPAKNC
	{
		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x7A9220", Offset = "0x7A7C20", VA = "0x1807A9220", Slot = "12")]
		get
		{
			return default(DFAMOHODBNL<NIIHBFDIOKM, INIGIGGLLDP>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000081")]
	public JLGMECJOLDI<EHGNFGGIBEB> CGGGCAKEBIP
	{
		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x9B30E0", Offset = "0x9B1AE0", VA = "0x1809B30E0", Slot = "13")]
		get
		{
			return default(JLGMECJOLDI<EHGNFGGIBEB>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000B")]
	public event Action? KKHOENEKGDJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x1D41B90", Offset = "0x1D40590", VA = "0x181D41B90", Slot = "14")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0x1D3E190", Offset = "0x1D3CB90", VA = "0x181D3E190", Slot = "15")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	public event Action? CAKKNKOPLMI
	{
		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x1D40D80", Offset = "0x1D3F780", VA = "0x181D40D80", Slot = "16")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0x1D402B0", Offset = "0x1D3ECB0", VA = "0x181D402B0", Slot = "17")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	public event Action<JLGMECJOLDI<ALOBLIADAMK?>, JLGMECJOLDI<ALOBLIADAMK?>>? ICPBMJFJEHL
	{
		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x1D41AA0", Offset = "0x1D404A0", VA = "0x181D41AA0", Slot = "18")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x1D3D750", Offset = "0x1D3C150", VA = "0x181D3D750", Slot = "19")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000E")]
	public event Action<JLGMECJOLDI<NIIHBFDIOKM?>, JLGMECJOLDI<NIIHBFDIOKM?>>? IHPFCNBGHBJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0x1D41CF0", Offset = "0x1D406F0", VA = "0x181D41CF0", Slot = "20")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0x1D42B60", Offset = "0x1D41560", VA = "0x181D42B60", Slot = "21")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000F")]
	public event Action<JLGMECJOLDI<ALOBLIADAMK?>, GHLMOHBOPLK?>? PKHOMMGFKLL
	{
		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0x1D3E0D0", Offset = "0x1D3CAD0", VA = "0x181D3E0D0", Slot = "22")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0x1D419E0", Offset = "0x1D403E0", VA = "0x181D419E0", Slot = "23")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000010")]
	public event Action<JLGMECJOLDI<ALOBLIADAMK?>>? HGADOELKHNP
	{
		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0x1D3FAA0", Offset = "0x1D3E4A0", VA = "0x181D3FAA0", Slot = "24")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x1D41860", Offset = "0x1D40260", VA = "0x181D41860", Slot = "25")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000011")]
	public event Action<JLGMECJOLDI<ALOBLIADAMK?>, GHLMOHBOPLK?>? GONHKNBMKFO
	{
		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x1D3F9E0", Offset = "0x1D3E3E0", VA = "0x181D3F9E0", Slot = "26")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0x1D3FDE0", Offset = "0x1D3E7E0", VA = "0x181D3FDE0", Slot = "27")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000012")]
	public event Action<JLGMECJOLDI<NIIHBFDIOKM?>, INIGIGGLLDP?>? CAIOPPIGHPL
	{
		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0x1D3D8D0", Offset = "0x1D3C2D0", VA = "0x181D3D8D0", Slot = "28")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(RVA = "0x1D3E010", Offset = "0x1D3CA10", VA = "0x181D3E010", Slot = "29")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000013")]
	public event Action<JLGMECJOLDI<NIIHBFDIOKM?>>? NGJKDNFPLOC
	{
		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(RVA = "0x1D3D990", Offset = "0x1D3C390", VA = "0x181D3D990", Slot = "30")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0x1D41C30", Offset = "0x1D40630", VA = "0x181D41C30", Slot = "31")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000014")]
	public event Action<JLGMECJOLDI<NIIHBFDIOKM?>, INIGIGGLLDP?>? PALBPCBNAHG
	{
		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x1D42C20", Offset = "0x1D41620", VA = "0x181D42C20", Slot = "32")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0x1D400E0", Offset = "0x1D3EAE0", VA = "0x181D400E0", Slot = "33")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(RVA = "0x1D43380", Offset = "0x1D41D80", VA = "0x181D43380")]
	private ABKJNJFGHFI(bool OBPFIAGBNAK, EJHJLJPPHCN BALKEACFDJN, bool IGAMGJACJEK, DFAMOHODBNL<ALOBLIADAMK, DLKAMECFEEF> DEIKIDPPMCI, DFAMOHODBNL<ALOBLIADAMK, GHLMOHBOPLK> DCJHMAHIKGL, DLLEFNELPBJ JACJPEOECBN, DFAMOHODBNL<NIIHBFDIOKM, LJGDDJCHKDC> FFNCDJBPKGH, DFAMOHODBNL<NIIHBFDIOKM, INIGIGGLLDP> BBFABFEAFNF, string? CIBAIEJPDLH, AHNMMIBEPOP DDBONMICPOE, JLGMECJOLDI<EHGNFGGIBEB> NDKHLPHIJIN, bool JPDNBBJIKBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(RVA = "0x1D407A0", Offset = "0x1D3F1A0", VA = "0x181D407A0")]
	public static ABKJNJFGHFI JKJFENIAMEL(bool OBPFIAGBNAK, EJHJLJPPHCN BALKEACFDJN, bool IGAMGJACJEK, DLLEFNELPBJ JACJPEOECBN, AHNMMIBEPOP DDBONMICPOE, JLGMECJOLDI<EHGNFGGIBEB> NDKHLPHIJIN, bool JPDNBBJIKBE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E0")]
	[Cpp2IlInjected.Address(RVA = "0x1D41DB0", Offset = "0x1D407B0", VA = "0x181D41DB0")]
	private void NGFHLNOOHDK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E1")]
	[Cpp2IlInjected.Address(RVA = "0x1D3E230", Offset = "0x1D3CC30", VA = "0x181D3E230", Slot = "45")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E2")]
	[Cpp2IlInjected.Address(RVA = "0x1D404E0", Offset = "0x1D3EEE0", VA = "0x181D404E0", Slot = "34")]
	[AsyncStateMachine(typeof(KJLJCGMBGBK))]
	public Task<KKHLNMGODKL<PJHBHBBODGG, MPIKAEBOCFI?>>? JBPAFKMHMEI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E3")]
	[Cpp2IlInjected.Address(RVA = "0x1D42560", Offset = "0x1D40F60", VA = "0x181D42560")]
	private (CEKOIMKMDLP?, int)? NJHFHCPHKII()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(RVA = "0x1D41770", Offset = "0x1D40170", VA = "0x181D41770")]
	private void KGAGPDFNPHJ(int KLCFAMMGJDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(RVA = "0x11AC450", Offset = "0x11AAE50", VA = "0x1811AC450")]
	private void PJCAKJIEHJO(int KLCFAMMGJDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(RVA = "0x1D40E30", Offset = "0x1D3F830", VA = "0x181D40E30")]
	private void KAEEGFJIDFL(int JHGNNPAGBPA, int JPGEJIDHDJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(RVA = "0x1D3DA50", Offset = "0x1D3C450", VA = "0x181D3DA50")]
	private void CGFMNFFJFIB(int KLCFAMMGJDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x1D42E40", Offset = "0x1D41840", VA = "0x181D42E40")]
	private void PNJPAEHNAKF(int KLCFAMMGJDD, int FHBLNFENHKJ, BFMMFHJHKDA BILHHBDBFLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0x1D41720", Offset = "0x1D40120", VA = "0x181D41720")]
	private void KCGGCOJBFGP(int JHEMNDMHNOB, int FHBLNFENHKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x1D40D30", Offset = "0x1D3F730", VA = "0x181D40D30")]
	private void JNHFOEDAAHC(int JHEMNDMHNOB, int FHBLNFENHKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x1D3F310", Offset = "0x1D3DD10", VA = "0x181D3F310")]
	private void FGMBAEPOEEM(int KLCFAMMGJDD, int FHBLNFENHKJ, BFMMFHJHKDA BILHHBDBFLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(RVA = "0x1D405D0", Offset = "0x1D3EFD0", VA = "0x181D405D0")]
	private void JCFNKCNGADL(int KLCFAMMGJDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0x8C4770", Offset = "0x8C3170", VA = "0x1808C4770")]
	private void LHEHLGHGIHP(int KLCFAMMGJDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x1D3DA70", Offset = "0x1D3C470", VA = "0x181D3DA70")]
	private void CGJEKEIKNFE(int KLCFAMMGJDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(RVA = "0x11AC450", Offset = "0x11AAE50", VA = "0x1811AC450")]
	private void LNFBFKJCIPF(int KLCFAMMGJDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(RVA = "0x1D3DB60", Offset = "0x1D3C560", VA = "0x181D3DB60")]
	private void CIKAJOKDKJF(int JHGNNPAGBPA, int JPGEJIDHDJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(RVA = "0x1D3DA50", Offset = "0x1D3C450", VA = "0x181D3DA50")]
	private void KLBLENMKDEI(int KLCFAMMGJDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(RVA = "0x1D411D0", Offset = "0x1D3FBD0", VA = "0x181D411D0")]
	private void KBMGLKOHLHO(int KLCFAMMGJDD, int FHBLNFENHKJ, MIMLJFBOMCO BILHHBDBFLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(RVA = "0x1D40360", Offset = "0x1D3ED60", VA = "0x181D40360")]
	private void ILJMPIIBLHH(int JHEMNDMHNOB, int FHBLNFENHKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(RVA = "0x1D3F770", Offset = "0x1D3E170", VA = "0x181D3F770")]
	private void FHNPMIEJJBI(int JHEMNDMHNOB, int FHBLNFENHKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(RVA = "0x1D3ED30", Offset = "0x1D3D730", VA = "0x181D3ED30")]
	private void EHIPECHHFDJ(int KLCFAMMGJDD, int FHBLNFENHKJ, MIMLJFBOMCO BILHHBDBFLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(RVA = "0x1D3FB60", Offset = "0x1D3E560", VA = "0x181D3FB60")]
	private void GIIGCGJFLIJ(int KLCFAMMGJDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(RVA = "0x8C4770", Offset = "0x8C3170", VA = "0x1808C4770")]
	private void MDCLIAJOKBJ(int KLCFAMMGJDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(RVA = "0x1D3DF00", Offset = "0x1D3C900", VA = "0x181D3DF00", Slot = "35")]
	[AsyncStateMachine(typeof(MLCJKLHGCCP))]
	public Task<KKHLNMGODKL<PJHBHBBODGG, MPIKAEBOCFI?>>? CLMFBEINPKH(JLGMECJOLDI<NJIGMIHFIFI> AJIHFKHEMCB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(RVA = "0x1D401A0", Offset = "0x1D3EBA0", VA = "0x181D401A0", Slot = "36")]
	[AsyncStateMachine(typeof(GMNJALFEDDK))]
	public Task<KKHLNMGODKL<PJHBHBBODGG, MPIKAEBOCFI?>>? GPGLMCDCGOP(JLGMECJOLDI<KFBDPPFJJPB> KKDLHAPIIII)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(RVA = "0x1D3FFC0", Offset = "0x1D3E9C0", VA = "0x181D3FFC0", Slot = "37")]
	[AsyncStateMachine(typeof(EMCKLMEJJPD))]
	public Task<KKHLNMGODKL<PJHBHBBODGG, MPIKAEBOCFI?>>? GNLMPJILBGA(JLGMECJOLDI<NJIGMIHFIFI> AJIHFKHEMCB, JLGMECJOLDI<NJIGMIHFIFI> CPLMOFDCCAP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(RVA = "0x1D3F1F0", Offset = "0x1D3DBF0", VA = "0x181D3F1F0", Slot = "38")]
	[AsyncStateMachine(typeof(KAAJPICKMAL))]
	public Task<KKHLNMGODKL<PJHBHBBODGG, MPIKAEBOCFI?>>? FFHLBCLEOMO(JLGMECJOLDI<KFBDPPFJJPB> KKDLHAPIIII, JLGMECJOLDI<KFBDPPFJJPB> CPLMOFDCCAP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(RVA = "0x1D3F7C0", Offset = "0x1D3E1C0", VA = "0x181D3F7C0", Slot = "39")]
	[AsyncStateMachine(typeof(PIJPHALKAMJ))]
	public Task<KKHLNMGODKL<PJHBHBBODGG, MPIKAEBOCFI?>>? FKOBFNOGDDN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x1D3FEA0", Offset = "0x1D3E8A0", VA = "0x181D3FEA0", Slot = "40")]
	[AsyncStateMachine(typeof(PJEPKEAFJFA))]
	public Task<KKHLNMGODKL<PJHBHBBODGG, MPIKAEBOCFI>> GMPEKJFPEEH(string PEICKGKGHAI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(RVA = "0x1D3F8B0", Offset = "0x1D3E2B0", VA = "0x181D3F8B0", Slot = "41")]
	[AsyncStateMachine(typeof(NGCNFGIGJLC))]
	public Task<KKHLNMGODKL<PJHBHBBODGG, MPIKAEBOCFI>> FODNLAGOBDJ(JLGMECJOLDI<NJIGMIHFIFI> AJIHFKHEMCB, string OMHHPMIDNAN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(RVA = "0x1D42CE0", Offset = "0x1D416E0", VA = "0x181D42CE0", Slot = "42")]
	[AsyncStateMachine(typeof(PONKNCILGOP))]
	public Task<KKHLNMGODKL<PJHBHBBODGG, MPIKAEBOCFI>> OILJDCOHCFE(JLGMECJOLDI<KFBDPPFJJPB> KKDLHAPIIII, string OMHHPMIDNAN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000200")]
	[Cpp2IlInjected.Address(RVA = "0x1D403B0", Offset = "0x1D3EDB0", VA = "0x181D403B0", Slot = "43")]
	[AsyncStateMachine(typeof(DGBGMJIBNAI))]
	public Task<KKHLNMGODKL<PJHBHBBODGG, MPIKAEBOCFI>> INOHBEBEINM(JLGMECJOLDI<NJIGMIHFIFI> AJIHFKHEMCB, NKJCMKKBOGB ADAMDPHPFAA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000201")]
	[Cpp2IlInjected.Address(RVA = "0x1D3FCB0", Offset = "0x1D3E6B0", VA = "0x181D3FCB0", Slot = "44")]
	[AsyncStateMachine(typeof(DGBPOGDBGID))]
	public Task<KKHLNMGODKL<PJHBHBBODGG, MPIKAEBOCFI>> GLLFLGFFDIC(JLGMECJOLDI<KFBDPPFJJPB> KKDLHAPIIII, NKJCMKKBOGB ADAMDPHPFAA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(RVA = "0x1D42790", Offset = "0x1D41190", VA = "0x181D42790")]
	internal void NLFANOEJJPI(JLGMECJOLDI<EHGNFGGIBEB> FDFHGIHHGHO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000068")]
public sealed class DEEBIGMHJGN : DEEIIACCHIP, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000069")]
	public interface PNAGPAIJMOJ
	{
		[Cpp2IlInjected.Token(Token = "0x17000083")]
		DPEJEGBGJGD HMFMJCKGLMP
		{
			[Cpp2IlInjected.Token(Token = "0x6000223")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(Slot = "1")]
		Task<HGAPEMBEHIA> AIFGNDBFJAE(CancellationToken HNLFPBLPOKJ);

		[Cpp2IlInjected.Token(Token = "0x6000225")]
		[Cpp2IlInjected.Address(Slot = "2")]
		Task<ODLEKMGFHLE> KKKBPLDHCCA(CancellationToken HNLFPBLPOKJ);

		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(Slot = "3")]
		Task<BCPGLEEKCAN> BOBAPMKFMEJ(CancellationToken HNLFPBLPOKJ);
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200006A")]
	[CompilerGenerated]
	private struct DFNMDLEFPIM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000166")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000167")]
		public AsyncTaskMethodBuilder<DEEBIGMHJGN> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000168")]
		public EJHJLJPPHCN circuitsManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000169")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400016A")]
		public HGAPEMBEHIA roomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400016B")]
		public ODLEKMGFHLE superRoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400016C")]
		private PNAGPAIJMOJ <selfDeps>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400016D")]
		private ODLEKMGFHLE <finalSuperRoomData>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400016E")]
		private TaskAwaiter<HGAPEMBEHIA> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400016F")]
		private TaskAwaiter<ODLEKMGFHLE> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000170")]
		private TaskAwaiter<BCPGLEEKCAN> <>u__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000171")]
		private TaskAwaiter<KLLNHDMNECI> <>u__4;

		[Cpp2IlInjected.Token(Token = "0x6000227")]
		[Cpp2IlInjected.Address(RVA = "0x1D45930", Offset = "0x1D44330", VA = "0x181D45930", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(RVA = "0x1D462E0", Offset = "0x1D44CE0", VA = "0x181D462E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000165")]
	private readonly KLLNHDMNECI EFPOJPMPDJI;

	[Cpp2IlInjected.Token(Token = "0x17000082")]
	public KLLNHDMNECI MHABINIMOJG
	{
		[Cpp2IlInjected.Token(Token = "0x6000222")]
		[Cpp2IlInjected.Address(RVA = "0x7A9200", Offset = "0x7A7C00", VA = "0x1807A9200", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600021F")]
	[Cpp2IlInjected.Address(RVA = "0x7B5BD0", Offset = "0x7B45D0", VA = "0x1807B5BD0")]
	private DEEBIGMHJGN(KLLNHDMNECI GLFFBACKIHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000220")]
	[Cpp2IlInjected.Address(RVA = "0x1D454D0", Offset = "0x1D43ED0", VA = "0x181D454D0")]
	[AsyncStateMachine(typeof(DFNMDLEFPIM))]
	public static Task<DEEBIGMHJGN> MNPMCBDFPDL(EJHJLJPPHCN BALKEACFDJN, HGAPEMBEHIA? ILKGBPMJIJM, ODLEKMGFHLE? JAMOLIKGFAA, CancellationToken HNLFPBLPOKJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000221")]
	[Cpp2IlInjected.Address(RVA = "0x1D454B0", Offset = "0x1D43EB0", VA = "0x181D454B0", Slot = "5")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
public readonly struct IDOFCENLABL
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200006C")]
	[CompilerGenerated]
	private struct EJKGHFAEONI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000173")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000174")]
		public AsyncTaskMethodBuilder<KKHLNMGODKL<object, MPIKAEBOCFI>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000175")]
		public IDOFCENLABL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000176")]
		public PKBFCJOJFAD action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000177")]
		public bool clearBufferedRpcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000178")]
		private TaskAwaiter<KKHLNMGODKL<object, MPIKAEBOCFI>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600022D")]
		[Cpp2IlInjected.Address(RVA = "0x1D4BBB0", Offset = "0x1D4A5B0", VA = "0x181D4BBB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022E")]
		[Cpp2IlInjected.Address(RVA = "0x1D4BE40", Offset = "0x1D4A840", VA = "0x181D4BE40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200006D")]
	[CompilerGenerated]
	private struct EMHOIACJJNI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000179")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400017A")]
		public AsyncTaskMethodBuilder<KKHLNMGODKL<bool, MPIKAEBOCFI>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400017B")]
		public int splitSizeBytes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400017C")]
		public FAPCIJNABKN rootData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400017D")]
		public HGAPEMBEHIA circuitRootData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400017E")]
		public ODLEKMGFHLE superRoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400017F")]
		public IDOFCENLABL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000180")]
		private PKBFCJOJFAD[] <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000181")]
		private int <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000182")]
		private TaskAwaiter<KKHLNMGODKL<object, MPIKAEBOCFI>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600022F")]
		[Cpp2IlInjected.Address(RVA = "0x1D4C270", Offset = "0x1D4AC70", VA = "0x181D4C270", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000230")]
		[Cpp2IlInjected.Address(RVA = "0x1D4C650", Offset = "0x1D4B050", VA = "0x181D4C650", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200006E")]
	[CompilerGenerated]
	private struct AEPMDPONNIE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000183")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000184")]
		public AsyncTaskMethodBuilder<KKHLNMGODKL<PJHBHBBODGG, MPIKAEBOCFI>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000185")]
		public IDOFCENLABL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000186")]
		private TaskAwaiter<KKHLNMGODKL<object, MPIKAEBOCFI>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000231")]
		[Cpp2IlInjected.Address(RVA = "0x1D43480", Offset = "0x1D41E80", VA = "0x181D43480", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0x1D43760", Offset = "0x1D42160", VA = "0x181D43760", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000172")]
	private readonly EDKKDEPLJLE JKHCKNDMHJK;

	[Cpp2IlInjected.Token(Token = "0x6000229")]
	[Cpp2IlInjected.Address(RVA = "0x8C6B40", Offset = "0x8C5540", VA = "0x1808C6B40")]
	public IDOFCENLABL(EDKKDEPLJLE BIHMJDLLGLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022A")]
	[Cpp2IlInjected.Address(RVA = "0x1D51E70", Offset = "0x1D50870", VA = "0x181D51E70")]
	[AsyncStateMachine(typeof(EJKGHFAEONI))]
	private Task<KKHLNMGODKL<object, MPIKAEBOCFI>> AOPGGACNBPB(PKBFCJOJFAD MCLCEMNNOFC, bool HPOBNPKLCBN = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022B")]
	[Cpp2IlInjected.Address(RVA = "0x1D51FA0", Offset = "0x1D509A0", VA = "0x181D51FA0")]
	[AsyncStateMachine(typeof(EMHOIACJJNI))]
	public Task<KKHLNMGODKL<bool, MPIKAEBOCFI?>>? LKKCKPEPLOK(int ECEGNNEMCAK, FAPCIJNABKN? NJFPPBLMKHP, HGAPEMBEHIA? KCJNLIFKLJL, ODLEKMGFHLE? JAMOLIKGFAA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022C")]
	[Cpp2IlInjected.Address(RVA = "0x1D52100", Offset = "0x1D50B00", VA = "0x181D52100")]
	[AsyncStateMachine(typeof(AEPMDPONNIE))]
	public Task<KKHLNMGODKL<PJHBHBBODGG, MPIKAEBOCFI>> NNIMNMJHJOG()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
public sealed class CJIFINGOFIP : HDEAGHOKJFL, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000187")]
	private readonly NGOLBPFHPEC JAKFMPICMKE;

	[Cpp2IlInjected.Token(Token = "0x17000084")]
	public NGOLBPFHPEC MGILNMFNJBF
	{
		[Cpp2IlInjected.Token(Token = "0x6000236")]
		[Cpp2IlInjected.Address(RVA = "0x7A9200", Offset = "0x7A7C00", VA = "0x1807A9200", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000233")]
	[Cpp2IlInjected.Address(RVA = "0x7B5BD0", Offset = "0x7B45D0", VA = "0x1807B5BD0")]
	private CJIFINGOFIP(NGOLBPFHPEC ADOIDJOANPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000234")]
	[Cpp2IlInjected.Address(RVA = "0x1D448E0", Offset = "0x1D432E0", VA = "0x181D448E0")]
	public static CJIFINGOFIP AFFCBAMFOKP(EJHJLJPPHCN BALKEACFDJN, FAPCIJNABKN DPLOCHMLAED)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000235")]
	[Cpp2IlInjected.Address(RVA = "0x1D44AB0", Offset = "0x1D434B0", VA = "0x181D44AB0", Slot = "5")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
public interface HGBGBPBGNKL : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000085")]
	IHOFOJLKFPJ EBBAPAOHNEF
	{
		[Cpp2IlInjected.Token(Token = "0x6000237")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000086")]
	NLKCBKLKPNJ GONJGKLODIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000238")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000087")]
	BDFLODFADHK JFLAPBJFCIB
	{
		[Cpp2IlInjected.Token(Token = "0x6000239")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000088")]
	FOAFAGELKHL BHMKCHHPCLK
	{
		[Cpp2IlInjected.Token(Token = "0x600023A")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000089")]
	HPBOKLJNGGO LHFIPOKEMDD
	{
		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000071")]
public interface OLOJIAHHKJN : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700008A")]
	HGBGBPBGNKL? OPHBLECMLLJ
	{
		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700008B")]
	bool FEJBNDKBHDE
	{
		[Cpp2IlInjected.Token(Token = "0x600023D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700008C")]
	bool LKCNFAOLEPN
	{
		[Cpp2IlInjected.Token(Token = "0x600023E")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600023F")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Task<HGBGBPBGNKL?>? LMCNBJNHFCB();

	[Cpp2IlInjected.Token(Token = "0x6000240")]
	[Cpp2IlInjected.Address(Slot = "4")]
	Task PDGIJEJGCPM(EJHJLJPPHCN BALKEACFDJN, FAPCIJNABKN DPLOCHMLAED, HGAPEMBEHIA? JLBKLFJBNIA, ODLEKMGFHLE? AMBABCKBIEK);
}
[Cpp2IlInjected.Token(Token = "0x2000072")]
[NIGHNNDPAGO("IStaticCV2Instance")]
public interface DEEIIACCHIP : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700008D")]
	KLLNHDMNECI MHABINIMOJG
	{
		[Cpp2IlInjected.Token(Token = "0x6000241")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000073")]
[NIGHNNDPAGO("IStaticEVInstance")]
public interface HDEAGHOKJFL : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700008E")]
	NGOLBPFHPEC MGILNMFNJBF
	{
		[Cpp2IlInjected.Token(Token = "0x6000242")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
public sealed class ANLNOJDPDEI : FBKBDOPBDJM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000188")]
	private readonly EJHJLJPPHCN CAPMIPILDGH;

	[Cpp2IlInjected.Token(Token = "0x1700008F")]
	public OKFJHCOHBLL? MEGHANKAOBP
	{
		[Cpp2IlInjected.Token(Token = "0x6000243")]
		[Cpp2IlInjected.Address(RVA = "0x1D43CC0", Offset = "0x1D426C0", VA = "0x181D43CC0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000244")]
	[Cpp2IlInjected.Address(RVA = "0x7B5BD0", Offset = "0x7B45D0", VA = "0x1807B5BD0")]
	internal ANLNOJDPDEI(EJHJLJPPHCN BALKEACFDJN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000075")]
public sealed class FOAFAGELKHL : OKFJHCOHBLL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000189")]
	private readonly DEEIIACCHIP PACOCMKCMKD;

	[Cpp2IlInjected.Token(Token = "0x17000090")]
	public OFFDGOOAMPM AOPGGACNBPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000245")]
		[Cpp2IlInjected.Address(RVA = "0x1D4E2C0", Offset = "0x1D4CCC0", VA = "0x181D4E2C0", Slot = "4")]
		get
		{
			return default(OFFDGOOAMPM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000091")]
	public HNCOCAACANO EPNKCEAAJMG
	{
		[Cpp2IlInjected.Token(Token = "0x6000246")]
		[Cpp2IlInjected.Address(RVA = "0x1D4E140", Offset = "0x1D4CB40", VA = "0x181D4E140", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000092")]
	public JGKGEKHGJKB<BIKLLPOLGEF> JDENOMGGILO
	{
		[Cpp2IlInjected.Token(Token = "0x6000247")]
		[Cpp2IlInjected.Address(RVA = "0x1D4E260", Offset = "0x1D4CC60", VA = "0x181D4E260", Slot = "6")]
		get
		{
			return default(JGKGEKHGJKB<BIKLLPOLGEF>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000093")]
	public KLLNHDMNECI EDCEOHEGDCL
	{
		[Cpp2IlInjected.Token(Token = "0x6000248")]
		[Cpp2IlInjected.Address(RVA = "0x1D4E210", Offset = "0x1D4CC10", VA = "0x181D4E210", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000249")]
	[Cpp2IlInjected.Address(RVA = "0x7B5BD0", Offset = "0x7B45D0", VA = "0x1807B5BD0")]
	public FOAFAGELKHL(DEEIIACCHIP NEMDKECFAGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024A")]
	[Cpp2IlInjected.Address(RVA = "0x1D4E1A0", Offset = "0x1D4CBA0", VA = "0x181D4E1A0")]
	public bool DNEDCKEKEOC([In] JGKGEKHGJKB<BIKLLPOLGEF> KGGOGFBCEKB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600024B")]
	[Cpp2IlInjected.Address(RVA = "0x1D4E1A0", Offset = "0x1D4CBA0", VA = "0x181D4E1A0", Slot = "8")]
	private bool INKIOBKHKKP([In] JGKGEKHGJKB<BIKLLPOLGEF> KGGOGFBCEKB)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000076")]
public static class CKILJANGHFP
{
	[Cpp2IlInjected.Token(Token = "0x600024C")]
	[Cpp2IlInjected.Address(RVA = "0x1D44AD0", Offset = "0x1D434D0", VA = "0x181D44AD0")]
	public static CHFDGNEIFAE<KBBHNEGECJL, PKBFCJOJFAD, EJHJLJPPHCN, LHINJBLMLPJ.HJMNPMINJNE<KBBHNEGECJL, PKBFCJOJFAD, EJHJLJPPHCN>> PFINEGNAILA([In] this CHFDGNEIFAE<KBBHNEGECJL, PKBFCJOJFAD, EJHJLJPPHCN, LHINJBLMLPJ.HJMNPMINJNE<KBBHNEGECJL, PKBFCJOJFAD, EJHJLJPPHCN>> ONNPNLGHOAJ)
	{
		return default(CHFDGNEIFAE<KBBHNEGECJL, PKBFCJOJFAD, EJHJLJPPHCN, LHINJBLMLPJ.HJMNPMINJNE<KBBHNEGECJL, PKBFCJOJFAD, EJHJLJPPHCN>>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000077")]
public sealed class MAPCCGGEAHJ : PDBOEIFOONC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400018A")]
	private readonly EJHJLJPPHCN CAPMIPILDGH;

	[Cpp2IlInjected.Token(Token = "0x17000094")]
	public bool LKCNFAOLEPN
	{
		[Cpp2IlInjected.Token(Token = "0x600024D")]
		[Cpp2IlInjected.Address(RVA = "0x1D56170", Offset = "0x1D54B70", VA = "0x181D56170", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600024E")]
	[Cpp2IlInjected.Address(RVA = "0x7B5BD0", Offset = "0x7B45D0", VA = "0x1807B5BD0")]
	internal MAPCCGGEAHJ(EJHJLJPPHCN BALKEACFDJN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000078")]
public sealed class JHKHAEKCONG : EDBEDLNBPFG
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000079")]
	[CompilerGenerated]
	private struct JFFOIMFHOJM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400018D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400018E")]
		public AsyncTaskMethodBuilder<APAALMMIDKA> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400018F")]
		public JHKHAEKCONG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000190")]
		private TaskAwaiter<HGBGBPBGNKL?> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600025A")]
		[Cpp2IlInjected.Address(RVA = "0x1D525E0", Offset = "0x1D50FE0", VA = "0x181D525E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025B")]
		[Cpp2IlInjected.Address(RVA = "0x1D52890", Offset = "0x1D51290", VA = "0x181D52890", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400018B")]
	private readonly EJHJLJPPHCN CAPMIPILDGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400018C")]
	private IReadOnlyList<JGKGEKHGJKB<ELOBPGFADAE>>? FDKIHCGELDF;

	[Cpp2IlInjected.Token(Token = "0x17000095")]
	public APAALMMIDKA? MEGHANKAOBP
	{
		[Cpp2IlInjected.Token(Token = "0x600024F")]
		[Cpp2IlInjected.Address(RVA = "0x1D536E0", Offset = "0x1D520E0", VA = "0x181D536E0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000096")]
	public HPBOKLJNGGO? OMGLLANKMAE
	{
		[Cpp2IlInjected.Token(Token = "0x6000250")]
		[Cpp2IlInjected.Address(RVA = "0x1D53760", Offset = "0x1D52160", VA = "0x181D53760")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000097")]
	public bool FBGEGGIHHHI
	{
		[Cpp2IlInjected.Token(Token = "0x6000251")]
		[Cpp2IlInjected.Address(RVA = "0x1D53840", Offset = "0x1D52240", VA = "0x181D53840", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000098")]
	public bool ODDAHJKENEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000252")]
		[Cpp2IlInjected.Address(RVA = "0x1D537E0", Offset = "0x1D521E0", VA = "0x181D537E0", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000253")]
	[Cpp2IlInjected.Address(RVA = "0x7B5BD0", Offset = "0x7B45D0", VA = "0x1807B5BD0")]
	internal JHKHAEKCONG(EJHJLJPPHCN BALKEACFDJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000254")]
	[Cpp2IlInjected.Address(RVA = "0x1D535F0", Offset = "0x1D51FF0", VA = "0x181D535F0", Slot = "7")]
	[AsyncStateMachine(typeof(JFFOIMFHOJM))]
	public Task<APAALMMIDKA> DIKPACPGGAH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000255")]
	[Cpp2IlInjected.Address(RVA = "0x1D538A0", Offset = "0x1D522A0", VA = "0x181D538A0")]
	internal Dictionary<JGKGEKHGJKB<BIKLLPOLGEF>, Guid> NOFINHOIFPB(IEnumerable<NEEDBNPPDKD> PJHLLPPLEAJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000256")]
	[Cpp2IlInjected.Address(RVA = "0x1D52F60", Offset = "0x1D51960", VA = "0x181D52F60")]
	public KKHLNMGODKL<EELEJFLMNKL, PKFDKDKJAIE> BBINFIIMDGO([In] EELEJFLMNKL JIGMOBMNNCI, IEnumerable<NEEDBNPPDKD> EBDMPFJBFKI, int KJPHDLDDKNB)
	{
		return default(KKHLNMGODKL<EELEJFLMNKL, PKFDKDKJAIE>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000257")]
	[Cpp2IlInjected.Address(RVA = "0x1D535B0", Offset = "0x1D51FB0", VA = "0x181D535B0")]
	internal static KIAFDOMBGOF DGLLFAFICJC(FLLKFBLHCCN CNCLKDOFGPK, DLLEFNELPBJ JACJPEOECBN)
	{
		return default(KIAFDOMBGOF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000258")]
	[Cpp2IlInjected.Address(RVA = "0x1D53160", Offset = "0x1D51B60", VA = "0x181D53160", Slot = "8")]
	private KKHLNMGODKL<EELEJFLMNKL, PKFDKDKJAIE> BJBBOOLHDGD([In] EELEJFLMNKL JIGMOBMNNCI, IEnumerable<NEEDBNPPDKD> EBDMPFJBFKI, int KJPHDLDDKNB)
	{
		return default(KKHLNMGODKL<EELEJFLMNKL, PKFDKDKJAIE>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000259")]
	[Cpp2IlInjected.Address(RVA = "0x1D53360", Offset = "0x1D51D60", VA = "0x181D53360")]
	[CompilerGenerated]
	internal static KIAFDOMBGOF BKOIDJOABOF(FLLKFBLHCCN IGJCPMJBKCP, DLLEFNELPBJ CMDHHGJGNKB)
	{
		return default(KIAFDOMBGOF);
	}
}
[Cpp2IlInjected.Token(Token = "0x200007A")]
public sealed class HPBOKLJNGGO : APAALMMIDKA
{
	[Cpp2IlInjected.Token(Token = "0x200007B")]
	internal static class CLLFOLLOFJI
	{
		[Cpp2IlInjected.Token(Token = "0x200007C")]
		[CompilerGenerated]
		private sealed class HDAFIHJGJCO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000199")]
			public KLLNHDMNECI state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400019A")]
			public BIGEIDAKKJG spawnIntoGraph;

			[Cpp2IlInjected.Token(Token = "0x600027B")]
			[Cpp2IlInjected.Address(RVA = "0x7AE800", Offset = "0x7AD200", VA = "0x1807AE800")]
			public HDAFIHJGJCO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600027C")]
			[Cpp2IlInjected.Address(RVA = "0x1D5DFB0", Offset = "0x1D5C9B0", VA = "0x181D5DFB0")]
			internal bool IJNLLNKJMOC(ENHCHOGMCKE n)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200007D")]
		[CompilerGenerated]
		private sealed class PIAICCJEBAI
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400019B")]
			public int makerPenInteractionFilterKeyValue;

			[Cpp2IlInjected.Token(Token = "0x600027D")]
			[Cpp2IlInjected.Address(RVA = "0x7AE800", Offset = "0x7AD200", VA = "0x1807AE800")]
			public PIAICCJEBAI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600027E")]
			[Cpp2IlInjected.Address(RVA = "0x1D607D0", Offset = "0x1D5F1D0", VA = "0x181D607D0")]
			internal void DOJFMKOLJGD(ENHCHOGMCKE n)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000276")]
		[Cpp2IlInjected.Address(RVA = "0x1D5C4B0", Offset = "0x1D5AEB0", VA = "0x181D5C4B0")]
		public static KKHLNMGODKL<APAALMMIDKA.LMHHJJAKPPB, PKFDKDKJAIE> OLPPMELFJKG(HPBOKLJNGGO NHHBAHIFHJK, [In] APAALMMIDKA.DNOIJLLALMF AHLEFKCGEBC)
		{
			return default(KKHLNMGODKL<APAALMMIDKA.LMHHJJAKPPB, PKFDKDKJAIE>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000277")]
		[Cpp2IlInjected.Address(RVA = "0x1D5B670", Offset = "0x1D5A070", VA = "0x181D5B670")]
		internal static KKHLNMGODKL<(PNPLINPDKOO, CJPHMPPJPIA), MPIKAEBOCFI> ENLDEPKJNGK(HPBOKLJNGGO NHHBAHIFHJK, CJPHMPPJPIA LMHCJAGECHL, bool OBKOCIHLFKG, [In] JGKGEKHGJKB<BIKLLPOLGEF> AOIDNFEHPNL, [In] int? EHEAGHCFAJJ, [In] KIAFDOMBGOF? GFBOAAIOMED, [In] KIAFDOMBGOF? ODFAHHEPNLM)
		{
			return default(KKHLNMGODKL<(PNPLINPDKOO, CJPHMPPJPIA), MPIKAEBOCFI>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(RVA = "0x1D5C9F0", Offset = "0x1D5B3F0", VA = "0x181D5C9F0")]
		private static void PGFMOFFJMJC(bool OBKOCIHLFKG, NEEDBNPPDKD GKOAKJGNMLA, PNPLINPDKOO FLHPEMKANCN, [In] JGKGEKHGJKB<BIKLLPOLGEF> AOIDNFEHPNL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(RVA = "0x1D5CE80", Offset = "0x1D5B880", VA = "0x181D5CE80")]
		public static void PKDIPEGAKBD(KIIGMFKIPLN ICJKNJANKLL, [In] APAALMMIDKA.JHGEJOLGJMK JEKACLKFFJM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(RVA = "0x1D5C3C0", Offset = "0x1D5ADC0", VA = "0x181D5C3C0")]
		[CompilerGenerated]
		internal static bool OFJBGIIPKCJ(KLLNHDMNECI BDHICBCDBOF, BIGEIDAKKJG GDOPAEPAFHP, ENHCHOGMCKE JHECMPKPDPL)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000191")]
	private readonly EJHJLJPPHCN CAPMIPILDGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000192")]
	private readonly DEEIIACCHIP PACOCMKCMKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000193")]
	private readonly HDEAGHOKJFL ADDKLKFIIKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000194")]
	private readonly MAJHHNDLKFI JHFBEGPHNEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000195")]
	private readonly JHKHAEKCONG EPIINKCBBAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000196")]
	private Dictionary<JGKGEKHGJKB<PNMLFKAJNIK>, MJLPNDIJFMP> KMOHPFPPMMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000198")]
	[CompilerGenerated]
	private Action<JGKGEKHGJKB<PNMLFKAJNIK>>? NAEBEFBEBCG;

	[Cpp2IlInjected.Token(Token = "0x600025C")]
	[Cpp2IlInjected.Address(RVA = "0x1D516D0", Offset = "0x1D500D0", VA = "0x181D516D0")]
	public HPBOKLJNGGO(EJHJLJPPHCN BALKEACFDJN, DEEIIACCHIP NEMDKECFAGI, HDEAGHOKJFL JFANONPAIDP, JHKHAEKCONG POAJGEGMONE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025D")]
	[Cpp2IlInjected.Address(RVA = "0x1D4FC30", Offset = "0x1D4E630", VA = "0x181D4FC30")]
	public MJLPNDIJFMP? CJDOPPMMLEH([In] JGKGEKHGJKB<PNMLFKAJNIK> KOOMGHGCPCM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025E")]
	[Cpp2IlInjected.Address(RVA = "0x1D50A50", Offset = "0x1D4F450", VA = "0x181D50A50")]
	private void HDIOFOEAEPC(JGKGEKHGJKB<PNMLFKAJNIK> KOOMGHGCPCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025F")]
	[Cpp2IlInjected.Address(RVA = "0x1D50920", Offset = "0x1D4F320", VA = "0x181D50920")]
	private MJLPNDIJFMP? FDJKLLEAHEM([In] JGKGEKHGJKB<PNMLFKAJNIK> KOOMGHGCPCM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000260")]
	[Cpp2IlInjected.Address(RVA = "0x1D4FB40", Offset = "0x1D4E540", VA = "0x181D4FB40")]
	public DLLEFNELPBJ? AHJEHLIAIBO([In] JGKGEKHGJKB<PNMLFKAJNIK> KOOMGHGCPCM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000261")]
	[Cpp2IlInjected.Address(RVA = "0x1D4FB30", Offset = "0x1D4E530", VA = "0x181D4FB30")]
	public BPPMJABJILE? ADFJBMPIMJC([In] JGKGEKHGJKB<BIKLLPOLGEF> KGGOGFBCEKB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000262")]
	[Cpp2IlInjected.Address(RVA = "0x1D50AD0", Offset = "0x1D4F4D0", VA = "0x181D50AD0")]
	private BIGEIDAKKJG? HILGPACCJJN([In] JGKGEKHGJKB<BIKLLPOLGEF> KGGOGFBCEKB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000263")]
	[Cpp2IlInjected.Address(RVA = "0x1D51030", Offset = "0x1D4FA30", VA = "0x181D51030")]
	private BPPMJABJILE? NJEGKMLKAOL([In] JGKGEKHGJKB<BIKLLPOLGEF> KGGOGFBCEKB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000264")]
	[Cpp2IlInjected.Address(RVA = "0x1D51550", Offset = "0x1D4FF50", VA = "0x181D51550", Slot = "6")]
	public IEnumerable<NKJCMKKBOGB> OFPFDNDGEAN(bool HGDDBHBEHGG, bool KIFCGAGOALG, bool BIOLBEKDMKA, bool NFEHPOAMHJJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000265")]
	[Cpp2IlInjected.Address(RVA = "0x1D508F0", Offset = "0x1D4F2F0", VA = "0x181D508F0")]
	public KKHLNMGODKL<APAALMMIDKA.LMHHJJAKPPB, PKFDKDKJAIE> EHNFDLDPKDE([In] APAALMMIDKA.DNOIJLLALMF AHLEFKCGEBC)
	{
		return default(KKHLNMGODKL<APAALMMIDKA.LMHHJJAKPPB, PKFDKDKJAIE>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000266")]
	[Cpp2IlInjected.Address(RVA = "0x1D50BE0", Offset = "0x1D4F5E0", VA = "0x181D50BE0", Slot = "8")]
	public KKHLNMGODKL<EDJPHBGOKGF, PKFDKDKJAIE> KAEBLKGBJJE(JGKGEKHGJKB<BIKLLPOLGEF> KGGOGFBCEKB, EDJPHBGOKGF CCJLBIBHGML, FKIBNGAKAAJ BIAANFIKPLH)
	{
		return default(KKHLNMGODKL<EDJPHBGOKGF, PKFDKDKJAIE>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000267")]
	[Cpp2IlInjected.Address(RVA = "0x1D51240", Offset = "0x1D4FC40", VA = "0x181D51240", Slot = "9")]
	public GHACBNFAIEE OBKAFLKJCOL(IEnumerable<NEEDBNPPDKD> EBDMPFJBFKI)
	{
		return default(GHACBNFAIEE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000268")]
	[Cpp2IlInjected.Address(RVA = "0x1D51430", Offset = "0x1D4FE30", VA = "0x181D51430", Slot = "10")]
	public GHACBNFAIEE OCEEPFDDELL()
	{
		return default(GHACBNFAIEE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000269")]
	[Cpp2IlInjected.Address(RVA = "0x1D500E0", Offset = "0x1D4EAE0", VA = "0x181D500E0")]
	private ILLEFFCAAOI CKNLBIDIJAL(KMDIJJHPMKL KPNPBJJKALE, JLGMECJOLDI<BIKLLPOLGEF> IAONMJHKCGE, IEnumerable<JGKGEKHGJKB<BIKLLPOLGEF>> MMDHFHIMGHM, IEnumerable<JGKGEKHGJKB<PNMLFKAJNIK>> OAFDABMJNGH)
	{
		return default(ILLEFFCAAOI);
	}

	[Cpp2IlInjected.Token(Token = "0x600026A")]
	[Cpp2IlInjected.Address(RVA = "0x1D4FDA0", Offset = "0x1D4E7A0", VA = "0x181D4FDA0", Slot = "11")]
	public ILLEFFCAAOI CKNLBIDIJAL(KMDIJJHPMKL KPNPBJJKALE, JLGMECJOLDI<BIKLLPOLGEF> IAONMJHKCGE, IEnumerable<JGKGEKHGJKB<PNMLFKAJNIK>> OAFDABMJNGH, IEnumerable<NEEDBNPPDKD> EBDMPFJBFKI)
	{
		return default(ILLEFFCAAOI);
	}

	[Cpp2IlInjected.Token(Token = "0x600026B")]
	[Cpp2IlInjected.Address(RVA = "0x1D4F7B0", Offset = "0x1D4E1B0", VA = "0x181D4F7B0")]
	private static IEnumerable<JGKGEKHGJKB<BIKLLPOLGEF>> ADALILHIICC(IEnumerable<NEEDBNPPDKD> EBDMPFJBFKI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600026C")]
	[Cpp2IlInjected.Address(RVA = "0x1D503E0", Offset = "0x1D4EDE0", VA = "0x181D503E0")]
	private IEnumerable<JGKGEKHGJKB<PNMLFKAJNIK>> DAPGDCALOGE(IEnumerable<NEEDBNPPDKD> EBDMPFJBFKI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600026D")]
	[Cpp2IlInjected.Address(RVA = "0x1D51640", Offset = "0x1D50040", VA = "0x181D51640", Slot = "12")]
	public List<APGAMDAIPCO> OJAFKEGANJO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600026E")]
	[Cpp2IlInjected.Address(RVA = "0x1D4FBD0", Offset = "0x1D4E5D0", VA = "0x181D4FBD0")]
	internal void AKCBAGCJHJE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026F")]
	[Cpp2IlInjected.Address(RVA = "0x1D50FD0", Offset = "0x1D4F9D0", VA = "0x181D50FD0")]
	internal Task MLPDNOIKKPP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000270")]
	[Cpp2IlInjected.Address(RVA = "0x1D4FB30", Offset = "0x1D4E530", VA = "0x181D4FB30", Slot = "4")]
	private BPPMJABJILE GDKKNCJKPFE([In] JGKGEKHGJKB<BIKLLPOLGEF> KGGOGFBCEKB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000271")]
	[Cpp2IlInjected.Address(RVA = "0x1D50290", Offset = "0x1D4EC90", VA = "0x181D50290", Slot = "5")]
	private MJLPNDIJFMP CLJGFNNBGAE([In] JGKGEKHGJKB<PNMLFKAJNIK> KOOMGHGCPCM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000272")]
	[Cpp2IlInjected.Address(RVA = "0x1D508F0", Offset = "0x1D4F2F0", VA = "0x181D508F0", Slot = "7")]
	private KKHLNMGODKL<APAALMMIDKA.LMHHJJAKPPB, PKFDKDKJAIE> HNIONMJEEHI([In] APAALMMIDKA.DNOIJLLALMF AHLEFKCGEBC)
	{
		return default(KKHLNMGODKL<APAALMMIDKA.LMHHJJAKPPB, PKFDKDKJAIE>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000273")]
	[Cpp2IlInjected.Address(RVA = "0x1D509D0", Offset = "0x1D4F3D0", VA = "0x181D509D0")]
	[CompilerGenerated]
	private KBFFDIFJBJN FIIEPAIODLN(FFGBDNDMLII CCNHOKJIGCD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000274")]
	[Cpp2IlInjected.Address(RVA = "0x1D50880", Offset = "0x1D4F280", VA = "0x181D50880")]
	[CompilerGenerated]
	private DLLEFNELPBJ EFOPFJJCLGN(JGKGEKHGJKB<PNMLFKAJNIK> CCNHOKJIGCD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000275")]
	[Cpp2IlInjected.Address(RVA = "0x1D50B70", Offset = "0x1D4F570", VA = "0x181D50B70")]
	[CompilerGenerated]
	private BIGEIDAKKJG IDIKHMPGDBE(JGKGEKHGJKB<BIKLLPOLGEF> CCNHOKJIGCD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200007E")]
public sealed class KBFFDIFJBJN : NKJCMKKBOGB
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200007F")]
	[CompilerGenerated]
	private struct CFGLHENEDAE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400019F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001A0")]
		public AsyncTaskMethodBuilder<KKHLNMGODKL<JLGMECJOLDI<NJIGMIHFIFI>, MPIKAEBOCFI>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001A1")]
		public KBFFDIFJBJN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001A2")]
		public JGKGEKHGJKB<BIKLLPOLGEF> graphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001A3")]
		public JGKGEKHGJKB<PNMLFKAJNIK> nodeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001A4")]
		public JLGMECJOLDI<EHGNFGGIBEB> portGroupId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001A5")]
		public string name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001A6")]
		private TaskAwaiter<KKHLNMGODKL<JLGMECJOLDI<NJIGMIHFIFI>, MPIKAEBOCFI>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000285")]
		[Cpp2IlInjected.Address(RVA = "0x1D5B380", Offset = "0x1D59D80", VA = "0x181D5B380", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000286")]
		[Cpp2IlInjected.Address(RVA = "0x1D5B600", Offset = "0x1D5A000", VA = "0x181D5B600", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000080")]
	[CompilerGenerated]
	private struct LEHALNDNPLG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001A7")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001A8")]
		public AsyncTaskMethodBuilder<KKHLNMGODKL<JLGMECJOLDI<KFBDPPFJJPB>, MPIKAEBOCFI>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001A9")]
		public KBFFDIFJBJN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001AA")]
		public JGKGEKHGJKB<BIKLLPOLGEF> graphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001AB")]
		public JGKGEKHGJKB<PNMLFKAJNIK> nodeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001AC")]
		public JLGMECJOLDI<EHGNFGGIBEB> portGroupId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001AD")]
		public string name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001AE")]
		private TaskAwaiter<KKHLNMGODKL<JLGMECJOLDI<KFBDPPFJJPB>, MPIKAEBOCFI>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000287")]
		[Cpp2IlInjected.Address(RVA = "0x1D5E830", Offset = "0x1D5D230", VA = "0x181D5E830", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000288")]
		[Cpp2IlInjected.Address(RVA = "0x1D5EAB0", Offset = "0x1D5D4B0", VA = "0x181D5EAB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400019C")]
	private readonly FFGBDNDMLII ICMCLDLCFLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400019D")]
	private readonly DEEIIACCHIP PACOCMKCMKD;

	[Cpp2IlInjected.Token(Token = "0x17000099")]
	public TypeKey AGLCBPDPJFE
	{
		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0x8C30C0", Offset = "0x8C1AC0", VA = "0x1808C30C0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(TypeKey);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009A")]
	public string BKGDAFHIMOB
	{
		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0x1D5E2B0", Offset = "0x1D5CCB0", VA = "0x181D5E2B0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009B")]
	public FFGBDNDMLII ODFHLKKMPKK
	{
		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0x7A9200", Offset = "0x7A7C00", VA = "0x1807A9200")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600027F")]
	[Cpp2IlInjected.Address(RVA = "0x1D5E450", Offset = "0x1D5CE50", VA = "0x181D5E450")]
	public KBFFDIFJBJN(FFGBDNDMLII BPFDBMEGJBE, DEEIIACCHIP NEMDKECFAGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000283")]
	[Cpp2IlInjected.Address(RVA = "0x1D5E140", Offset = "0x1D5CB40", VA = "0x181D5E140", Slot = "6")]
	[AsyncStateMachine(typeof(CFGLHENEDAE))]
	public Task<KKHLNMGODKL<JLGMECJOLDI<NJIGMIHFIFI>, MPIKAEBOCFI>> LBAJODBLDPL(JGKGEKHGJKB<BIKLLPOLGEF> KGGOGFBCEKB, JGKGEKHGJKB<PNMLFKAJNIK> KOOMGHGCPCM, JLGMECJOLDI<EHGNFGGIBEB> NDKHLPHIJIN, string OMHHPMIDNAN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000284")]
	[Cpp2IlInjected.Address(RVA = "0x1D5E2E0", Offset = "0x1D5CCE0", VA = "0x181D5E2E0", Slot = "7")]
	[AsyncStateMachine(typeof(LEHALNDNPLG))]
	public Task<KKHLNMGODKL<JLGMECJOLDI<KFBDPPFJJPB>, MPIKAEBOCFI>> PBJPDIDOBNH(JGKGEKHGJKB<BIKLLPOLGEF> KGGOGFBCEKB, JGKGEKHGJKB<PNMLFKAJNIK> KOOMGHGCPCM, JLGMECJOLDI<EHGNFGGIBEB> NDKHLPHIJIN, string OMHHPMIDNAN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000081")]
public sealed class MDAFEHJGBEE : JMOOPHLIAJE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001AF")]
	private readonly FFGBDNDMLII FADHFJMFNKI;

	[Cpp2IlInjected.Token(Token = "0x40001B0")]
	private static readonly HashSet<FFGBDNDMLII> ILOHNADNPJB;

	[Cpp2IlInjected.Token(Token = "0x40001B1")]
	private static readonly HashSet<FFGBDNDMLII> HGPHDGMACFP;

	[Cpp2IlInjected.Token(Token = "0x40001B2")]
	private static readonly HashSet<FFGBDNDMLII> MJKAJNCBFBG;

	[Cpp2IlInjected.Token(Token = "0x1700009C")]
	public TypeKey JFBDDAMOHDF
	{
		[Cpp2IlInjected.Token(Token = "0x6000289")]
		[Cpp2IlInjected.Address(RVA = "0x1D603B0", Offset = "0x1D5EDB0", VA = "0x181D603B0", Slot = "6")]
		get
		{
			return default(TypeKey);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009D")]
	public bool IPLFONPJFLP
	{
		[Cpp2IlInjected.Token(Token = "0x600028A")]
		[Cpp2IlInjected.Address(RVA = "0x1D603A0", Offset = "0x1D5EDA0", VA = "0x181D603A0", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009E")]
	public bool OGBCLDLCLEM
	{
		[Cpp2IlInjected.Token(Token = "0x600028E")]
		[Cpp2IlInjected.Address(RVA = "0x1D60400", Offset = "0x1D5EE00", VA = "0x181D60400", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009F")]
	public bool DGOJMGHFKBI
	{
		[Cpp2IlInjected.Token(Token = "0x600028F")]
		[Cpp2IlInjected.Address(RVA = "0x1D60320", Offset = "0x1D5ED20", VA = "0x181D60320", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600028B")]
	[Cpp2IlInjected.Address(RVA = "0x1D5EF10", Offset = "0x1D5D910", VA = "0x181D5EF10")]
	public bool KDNFOKEGILP(string FDFHGIHHGHO, [Out] LPNODEDDNDJ BMPOHDNHCMO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600028C")]
	[Cpp2IlInjected.Address(RVA = "0x7B5BD0", Offset = "0x7B45D0", VA = "0x1807B5BD0")]
	public MDAFEHJGBEE(FFGBDNDMLII CEBGEIIIEAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028D")]
	[Cpp2IlInjected.Address(RVA = "0x1D5F180", Offset = "0x1D5DB80", VA = "0x181D5F180")]
	internal static TypeKey LNFMLEPOFKH(FFGBDNDMLII ADAMDPHPFAA)
	{
		return default(TypeKey);
	}

	[Cpp2IlInjected.Token(Token = "0x6000290")]
	[Cpp2IlInjected.Address(RVA = "0x1D5E2B0", Offset = "0x1D5CCB0", VA = "0x181D5E2B0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000082")]
public readonly struct LEGLLIIFDDP : FPMPGDCBBDF.FDCLCOJALAB<PKBFCJOJFAD, PJHBHBBODGG>
{
	[Cpp2IlInjected.Token(Token = "0x6000292")]
	[Cpp2IlInjected.Address(RVA = "0x1D5E700", Offset = "0x1D5D100", VA = "0x181D5E700", Slot = "4")]
	public int EDGFDJAOCDF(PJHBHBBODGG JHEMNDMHNOB, PKBFCJOJFAD MCLCEMNNOFC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000293")]
	[Cpp2IlInjected.Address(RVA = "0x1D5E7D0", Offset = "0x1D5D1D0", VA = "0x181D5E7D0", Slot = "5")]
	public PKBFCJOJFAD KLEBHHEFNHE(PJHBHBBODGG JHEMNDMHNOB, PKBFCJOJFAD MCLCEMNNOFC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000294")]
	[Cpp2IlInjected.Address(RVA = "0x1D5E740", Offset = "0x1D5D140", VA = "0x181D5E740", Slot = "6")]
	public PKBFCJOJFAD HABHPEHAJMD(PJHBHBBODGG JHEMNDMHNOB, PKBFCJOJFAD MCLCEMNNOFC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000295")]
	[Cpp2IlInjected.Address(RVA = "0x1D5E790", Offset = "0x1D5D190", VA = "0x181D5E790", Slot = "7")]
	public IReadOnlyList<PKBFCJOJFAD> JHDGFOGGJND(PJHBHBBODGG JHEMNDMHNOB, PKBFCJOJFAD MCLCEMNNOFC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000296")]
	[Cpp2IlInjected.Address(RVA = "0x1D5E7E0", Offset = "0x1D5D1E0", VA = "0x181D5E7E0", Slot = "8")]
	public PKBFCJOJFAD[] MGBFOKMFIPH(PJHBHBBODGG JHEMNDMHNOB, PKBFCJOJFAD MCLCEMNNOFC, int FLNOFAHKHFK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000297")]
	[Cpp2IlInjected.Address(RVA = "0x1D5E6E0", Offset = "0x1D5D0E0", VA = "0x181D5E6E0", Slot = "9")]
	public bool CCCOKCGNEGO(PJHBHBBODGG JHEMNDMHNOB, PKBFCJOJFAD MCLCEMNNOFC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000298")]
	[Cpp2IlInjected.Address(RVA = "0x1D5E7B0", Offset = "0x1D5D1B0", VA = "0x181D5E7B0", Slot = "10")]
	public bool KFGNEKCHDAF(PJHBHBBODGG JHEMNDMHNOB, PKBFCJOJFAD MCLCEMNNOFC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000299")]
	[Cpp2IlInjected.Address(RVA = "0x1D5E7F0", Offset = "0x1D5D1F0", VA = "0x181D5E7F0", Slot = "11")]
	public bool NDGCCALPIHJ(PJHBHBBODGG JHEMNDMHNOB, PKBFCJOJFAD MCLCEMNNOFC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600029A")]
	[Cpp2IlInjected.Address(RVA = "0x1D5E720", Offset = "0x1D5D120", VA = "0x181D5E720", Slot = "12")]
	public bool GPAAHBIPCMK(PJHBHBBODGG JHEMNDMHNOB, PKBFCJOJFAD MCLCEMNNOFC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600029B")]
	[Cpp2IlInjected.Address(RVA = "0x1D5E810", Offset = "0x1D5D210", VA = "0x181D5E810", Slot = "13")]
	public bool OHGKELAKELP(PJHBHBBODGG JMAMNEHEBBI, PKBFCJOJFAD MCLCEMNNOFC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600029C")]
	[Cpp2IlInjected.Address(RVA = "0x1D5E770", Offset = "0x1D5D170", VA = "0x181D5E770", Slot = "14")]
	public bool JEMBIMNAJFM(PJHBHBBODGG JHEMNDMHNOB, PKBFCJOJFAD MCLCEMNNOFC)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000083")]
public abstract class HJEHKHKICBN : NKJHHHEICAE
{
	[Cpp2IlInjected.Token(Token = "0x170000A0")]
	public IGOGAMCOFBL.ELOIJMPPHFD EFMFMLPLCFP
	{
		[Cpp2IlInjected.Token(Token = "0x600029D")]
		[Cpp2IlInjected.Address(RVA = "0x1D5E0A0", Offset = "0x1D5CAA0", VA = "0x181D5E0A0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A1")]
	public abstract HAEEEJDFFEI.PBABOHLILAM MKFKMBAGEIO
	{
		[Cpp2IlInjected.Token(Token = "0x600029E")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A2")]
	public abstract EJHJLJPPHCN.LMLIHKJGPHN LLJIGOLODLK
	{
		[Cpp2IlInjected.Token(Token = "0x600029F")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A3")]
	public abstract DEEBIGMHJGN.PNAGPAIJMOJ BIJCOPOIHBK
	{
		[Cpp2IlInjected.Token(Token = "0x60002A0")]
		[Cpp2IlInjected.Address(Slot = "16")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A4")]
	public LHINJBLMLPJ.HJMNPMINJNE<KBBHNEGECJL, PKBFCJOJFAD, EJHJLJPPHCN> CBLKBHAOONI
	{
		[Cpp2IlInjected.Token(Token = "0x60002A1")]
		[Cpp2IlInjected.Address(RVA = "0x1D5E0F0", Offset = "0x1D5CAF0", VA = "0x181D5E0F0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A5")]
	public abstract CFPCGPKJOEC FOKAODMOPLP
	{
		[Cpp2IlInjected.Token(Token = "0x60002A2")]
		[Cpp2IlInjected.Address(Slot = "17")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A6")]
	public abstract BPJNDDGFEIL MJCMICAACFL
	{
		[Cpp2IlInjected.Token(Token = "0x60002A3")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A7")]
	public abstract PKABPKDGOFD HDFPEMOAFIH
	{
		[Cpp2IlInjected.Token(Token = "0x60002A4")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A8")]
	public abstract HFGFELDOBHA IOLIEBECABI
	{
		[Cpp2IlInjected.Token(Token = "0x60002A5")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A9")]
	public abstract EFOHNENLJMJ DKMKOMHFPLA
	{
		[Cpp2IlInjected.Token(Token = "0x60002A6")]
		[Cpp2IlInjected.Address(Slot = "21")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60002A7")]
	[Cpp2IlInjected.Address(RVA = "0x7AE800", Offset = "0x7AD200", VA = "0x1807AE800")]
	protected HJEHKHKICBN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000084")]
public sealed class BNCBBPDHIMC : HNCOCAACANO
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000085")]
	[CompilerGenerated]
	private struct EMHKNFOOFMG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001B4")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001B5")]
		public AsyncTaskMethodBuilder<KKHLNMGODKL<object, MPIKAEBOCFI>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001B6")]
		public BNCBBPDHIMC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001B7")]
		public PKBFCJOJFAD action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001B8")]
		public bool clearBufferedRpcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001B9")]
		private TaskAwaiter<KKHLNMGODKL<object, MPIKAEBOCFI>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002AB")]
		[Cpp2IlInjected.Address(RVA = "0x1D5D290", Offset = "0x1D5BC90", VA = "0x181D5D290", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AC")]
		[Cpp2IlInjected.Address(RVA = "0x1D5D530", Offset = "0x1D5BF30", VA = "0x181D5D530", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000086")]
	[CompilerGenerated]
	private struct LIPFOBGLFBC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001BA")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001BB")]
		public AsyncTaskMethodBuilder<KKHLNMGODKL<EPLJJHPILDK, MPIKAEBOCFI>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001BC")]
		public BNCBBPDHIMC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001BD")]
		public IReadOnlyList<PKBFCJOJFAD> actions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001BE")]
		public bool clearBufferedRpcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001BF")]
		private TaskAwaiter<KKHLNMGODKL<object, MPIKAEBOCFI>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002AD")]
		[Cpp2IlInjected.Address(RVA = "0x1D5EB20", Offset = "0x1D5D520", VA = "0x181D5EB20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AE")]
		[Cpp2IlInjected.Address(RVA = "0x1D5EEA0", Offset = "0x1D5D8A0", VA = "0x181D5EEA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001B3")]
	private readonly EDKKDEPLJLE JKHCKNDMHJK;

	[Cpp2IlInjected.Token(Token = "0x60002A8")]
	[Cpp2IlInjected.Address(RVA = "0x7B5BD0", Offset = "0x7B45D0", VA = "0x1807B5BD0")]
	public BNCBBPDHIMC(EDKKDEPLJLE BIHMJDLLGLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A9")]
	[Cpp2IlInjected.Address(RVA = "0x1D5B120", Offset = "0x1D59B20", VA = "0x181D5B120")]
	[AsyncStateMachine(typeof(EMHKNFOOFMG))]
	private Task<KKHLNMGODKL<object, MPIKAEBOCFI>> AOPGGACNBPB(PKBFCJOJFAD MCLCEMNNOFC, bool HPOBNPKLCBN = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002AA")]
	[Cpp2IlInjected.Address(RVA = "0x1D5B250", Offset = "0x1D59C50", VA = "0x181D5B250", Slot = "4")]
	[AsyncStateMachine(typeof(LIPFOBGLFBC))]
	public Task<KKHLNMGODKL<EPLJJHPILDK, MPIKAEBOCFI>> IBPIJEDAPHO(IReadOnlyList<PKBFCJOJFAD> BDOEJBMENLB, bool HPOBNPKLCBN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000087")]
public struct OHAADPEAMDL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001C0")]
	internal MHCFONGEKFO<MECCDFBDFBI, PKBFCJOJFAD, KIGALKCCGCN> FADHFJMFNKI;

	[Cpp2IlInjected.Token(Token = "0x60002AF")]
	[Cpp2IlInjected.Address(RVA = "0x1D542E0", Offset = "0x1D52CE0", VA = "0x181D542E0")]
	private OHAADPEAMDL([In] MHCFONGEKFO<MECCDFBDFBI, PKBFCJOJFAD, KIGALKCCGCN> BILGCBPECOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B0")]
	[Cpp2IlInjected.Address(RVA = "0x1D60770", Offset = "0x1D5F170", VA = "0x181D60770")]
	public static OHAADPEAMDL JKJFENIAMEL()
	{
		return default(OHAADPEAMDL);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000088")]
public static class DKLOGOGMIAK
{
	[Cpp2IlInjected.Token(Token = "0x60002B1")]
	[Cpp2IlInjected.Address(RVA = "0x877270", Offset = "0x875C70", VA = "0x180877270")]
	public static MHCFONGEKFO<MECCDFBDFBI, PKBFCJOJFAD, KIGALKCCGCN> KLICMMJIFNF(this OHAADPEAMDL NHHBAHIFHJK)
	{
		return default(MHCFONGEKFO<MECCDFBDFBI, PKBFCJOJFAD, KIGALKCCGCN>);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000089")]
public struct KIGALKCCGCN : NPKGIMHOMIO.AOIFAHAKPLN<MECCDFBDFBI, PKBFCJOJFAD>
{
	[Cpp2IlInjected.Token(Token = "0x60002B2")]
	[Cpp2IlInjected.Address(RVA = "0x1D5E4F0", Offset = "0x1D5CEF0", VA = "0x181D5E4F0", Slot = "5")]
	public PKBFCJOJFAD JJIDHPKBEDI(MECCDFBDFBI[] JKCGKOKJMJJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002B3")]
	[Cpp2IlInjected.Address(RVA = "0x131A140", Offset = "0x1318B40", VA = "0x18131A140")]
	public int LEBDJEOHJEM([In] MECCDFBDFBI JHPHLKJCBPC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B4")]
	[Cpp2IlInjected.Address(RVA = "0x131A140", Offset = "0x1318B40", VA = "0x18131A140", Slot = "4")]
	private int HBGLHPNENKN([In] MECCDFBDFBI DCPHEKAKJLP)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200008B")]
public struct NALNFODDAEP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001C3")]
	internal BOENFDIPHIP<PPGJNIDOJJF, PKBFCJOJFAD, NENOHMGKEMB> FADHFJMFNKI;

	[Cpp2IlInjected.Token(Token = "0x60002B8")]
	[Cpp2IlInjected.Address(RVA = "0x1D542E0", Offset = "0x1D52CE0", VA = "0x181D542E0")]
	private NALNFODDAEP([In] BOENFDIPHIP<PPGJNIDOJJF, PKBFCJOJFAD, NENOHMGKEMB> OLNKKNMGCBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B9")]
	[Cpp2IlInjected.Address(RVA = "0x1D60520", Offset = "0x1D5EF20", VA = "0x181D60520")]
	public static NALNFODDAEP JKJFENIAMEL()
	{
		return default(NALNFODDAEP);
	}
}
[Cpp2IlInjected.Token(Token = "0x200008C")]
public static class HFAIDPDMGDE
{
	[Cpp2IlInjected.Token(Token = "0x60002BA")]
	[Cpp2IlInjected.Address(RVA = "0x877270", Offset = "0x875C70", VA = "0x180877270")]
	public static BOENFDIPHIP<PPGJNIDOJJF, PKBFCJOJFAD, NENOHMGKEMB> KLICMMJIFNF(this NALNFODDAEP NHHBAHIFHJK)
	{
		return default(BOENFDIPHIP<PPGJNIDOJJF, PKBFCJOJFAD, NENOHMGKEMB>);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200008D")]
public struct NENOHMGKEMB : EFNNPLBKPNO.BHFMHOLMGDJ<PPGJNIDOJJF, PKBFCJOJFAD>
{
	[Cpp2IlInjected.Token(Token = "0x60002BB")]
	[Cpp2IlInjected.Address(RVA = "0x131A140", Offset = "0x1318B40", VA = "0x18131A140")]
	public int GMAGHOJLIEF([In] PPGJNIDOJJF JHPHLKJCBPC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BC")]
	[Cpp2IlInjected.Address(RVA = "0x1D60580", Offset = "0x1D5EF80", VA = "0x181D60580", Slot = "5")]
	public PKBFCJOJFAD BDKDDDIGMIL(PPGJNIDOJJF[] OHCCAHIAAEL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002BD")]
	[Cpp2IlInjected.Address(RVA = "0x131A140", Offset = "0x1318B40", VA = "0x18131A140", Slot = "4")]
	private int FKJPBDCKBFI([In] PPGJNIDOJJF JHPHLKJCBPC)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200008F")]
public interface CFPCGPKJOEC
{
	[Cpp2IlInjected.Token(Token = "0x60002C1")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool FMNGJEMEGAD([In] KKHLNMGODKL<PJHBHBBODGG, PKFDKDKJAIE> MNKBHKEBOPJ);
}
[Cpp2IlInjected.Token(Token = "0x2000090")]
public static class KPJIOPLJFPK
{
	[Cpp2IlInjected.Token(Token = "0x60002C2")]
	[Cpp2IlInjected.Address(RVA = "0x273C510", Offset = "0x273AF10", VA = "0x18273C510")]
	public static bool FMNGJEMEGAD<TOk, TErr>(this CFPCGPKJOEC NHHBAHIFHJK, [In] KKHLNMGODKL<TOk, TErr> MNKBHKEBOPJ) where TOk : notnull where TErr : notnull, PKFDKDKJAIE
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000091")]
public interface BPJNDDGFEIL
{
	[Cpp2IlInjected.Token(Token = "0x170000AA")]
	JECJOIFOGKF BCJNALJJOOC
	{
		[Cpp2IlInjected.Token(Token = "0x60002C3")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000092")]
public interface PKABPKDGOFD
{
	[Cpp2IlInjected.Token(Token = "0x60002C4")]
	[Cpp2IlInjected.Address(Slot = "0")]
	PEMPOOCNEEL AFKPLMOGDBB(int MDEAOBPDKIL);
}
[Cpp2IlInjected.Token(Token = "0x2000093")]
public interface JFCMNKPDLPN
{
	[Cpp2IlInjected.Token(Token = "0x170000AB")]
	string BJAHCKCNPKD
	{
		[Cpp2IlInjected.Token(Token = "0x60002C5")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000094")]
public interface NIPFLGHAHKJ
{
	[Cpp2IlInjected.Token(Token = "0x60002C6")]
	[Cpp2IlInjected.Address(Slot = "0")]
	HHAFBDKOOKI? ACOMIMEPDBP(JLGMECJOLDI<EHGNFGGIBEB> NDKHLPHIJIN);
}
[Cpp2IlInjected.Token(Token = "0x2000095")]
public interface HNHEGECMNPA
{
	[Cpp2IlInjected.Token(Token = "0x170000AC")]
	string BJAHCKCNPKD
	{
		[Cpp2IlInjected.Token(Token = "0x60002C7")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000096")]
public interface HHAFBDKOOKI
{
	[Cpp2IlInjected.Token(Token = "0x170000AD")]
	string BJAHCKCNPKD
	{
		[Cpp2IlInjected.Token(Token = "0x60002C8")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60002C9")]
	[Cpp2IlInjected.Address(Slot = "1")]
	HNHEGECMNPA? AFLNIJHLHGC(JLGMECJOLDI<NJIGMIHFIFI> AJIHFKHEMCB);

	[Cpp2IlInjected.Token(Token = "0x60002CA")]
	[Cpp2IlInjected.Address(Slot = "2")]
	JFCMNKPDLPN? GJKPLLPDGEF(JLGMECJOLDI<KFBDPPFJJPB> KKDLHAPIIII);
}
[Cpp2IlInjected.Token(Token = "0x2000097")]
public interface HFGFELDOBHA
{
	[Cpp2IlInjected.Token(Token = "0x60002CB")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<bool> GEKGBCIBCNN(string FDFHGIHHGHO, string PEHINKLIDNC);
}
[Cpp2IlInjected.Token(Token = "0x2000098")]
public interface EFOHNENLJMJ
{
	[Cpp2IlInjected.Token(Token = "0x60002CC")]
	[Cpp2IlInjected.Address(Slot = "0")]
	NIPFLGHAHKJ? COGKNOEGCKH([In] JGKGEKHGJKB<ELOBPGFADAE> AJGEEMBDPHJ);
}
[Cpp2IlInjected.Token(Token = "0x2000099")]
public sealed class GHCDAODJGIM
{
	[Cpp2IlInjected.Token(Token = "0x200009A")]
	private struct FAJPFLODKHE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001C9")]
		public int MEJJBNBBHJJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001CA")]
		public HGAPEMBEHIA? MICBHMMHAEJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001CB")]
		public HGAPEMBEHIA? GOAJHCIHJKM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001CC")]
		public readonly List<PKBFCJOJFAD> GEKKCFAGEBB;

		[Cpp2IlInjected.Token(Token = "0x60002D5")]
		[Cpp2IlInjected.Address(RVA = "0x1D5D660", Offset = "0x1D5C060", VA = "0x181D5D660")]
		private FAJPFLODKHE(int OJANCMLFDOJ, HGAPEMBEHIA? KMNEGGDONJK, HGAPEMBEHIA? NPPJFAKMIBK, List<PKBFCJOJFAD> BDOEJBMENLB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D6")]
		[Cpp2IlInjected.Address(RVA = "0x1D5D5A0", Offset = "0x1D5BFA0", VA = "0x181D5D5A0")]
		public static FAJPFLODKHE JKJFENIAMEL()
		{
			return default(FAJPFLODKHE);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001C8")]
	private readonly IAGMEJPGGLG<FAJPFLODKHE> MLIIPKANEHN;

	[Cpp2IlInjected.Token(Token = "0x170000AE")]
	public static GHCDAODJGIM MEGHANKAOBP
	{
		[Cpp2IlInjected.Token(Token = "0x60002CD")]
		[Cpp2IlInjected.Address(RVA = "0x1D5D6B0", Offset = "0x1D5C0B0", VA = "0x181D5D6B0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AF")]
	public bool BGPPABNINDC
	{
		[Cpp2IlInjected.Token(Token = "0x60002CE")]
		[Cpp2IlInjected.Address(RVA = "0x7F4420", Offset = "0x7F2E20", VA = "0x1807F4420")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60002CF")]
		[Cpp2IlInjected.Address(RVA = "0x998D80", Offset = "0x997780", VA = "0x180998D80")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002D0")]
	[Cpp2IlInjected.Address(RVA = "0x1D5DD40", Offset = "0x1D5C740", VA = "0x181D5DD40")]
	public void OALGIKAPGFC(KLLNHDMNECI NPPJFAKMIBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D1")]
	[Cpp2IlInjected.Address(RVA = "0x1D5DA40", Offset = "0x1D5C440", VA = "0x181D5DA40")]
	public void NLDMOBIEIIB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D2")]
	[Cpp2IlInjected.Address(RVA = "0x1D5D700", Offset = "0x1D5C100", VA = "0x181D5D700")]
	private static string? JOMJNALMAML([In] FAJPFLODKHE NMIDCKDPPMD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D3")]
	[Cpp2IlInjected.Address(RVA = "0x1D5DF00", Offset = "0x1D5C900", VA = "0x181D5DF00")]
	public GHCDAODJGIM()
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
