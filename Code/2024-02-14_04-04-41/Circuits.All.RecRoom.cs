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
		[Cpp2IlInjected.Address(RVA = "0x7C7B20", Offset = "0x7C6F20", VA = "0x1807C7B20")]
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
		[Cpp2IlInjected.Address(RVA = "0x1D3E720", Offset = "0x1D3DB20", VA = "0x181D3E720")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x7C8560", Offset = "0x7C7960", VA = "0x1807C8560")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[CompilerGenerated]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x7C85A0", Offset = "0x7C79A0", VA = "0x1807C85A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x1D2C470", Offset = "0x1D2B870", VA = "0x181D2C470", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x1D2C3F0", Offset = "0x1D2B7F0", VA = "0x181D2C3F0", Slot = "13")]
		public virtual void FIIPDKPDKIJ(EJHJLJPPHCN BALKEACFDJN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x1D2C330", Offset = "0x1D2B730", VA = "0x181D2C330", Slot = "14")]
		public virtual void CPNIDECCBPO(EJHJLJPPHCN BALKEACFDJN, PKBFCJOJFAD MCLCEMNNOFC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x7A4800", Offset = "0x7A3C00", VA = "0x1807A4800")]
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
		[Cpp2IlInjected.Address(RVA = "0x1D3B070", Offset = "0x1D3A470", VA = "0x181D3B070")]
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
		[Cpp2IlInjected.Address(RVA = "0x7A4800", Offset = "0x7A3C00", VA = "0x1807A4800")]
		private LDBKIKIABOO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0xA1A890", Offset = "0xA19C90", VA = "0x180A1A890", Slot = "4")]
		public KBBHNEGECJL GCPDNGMHCIA(PKBFCJOJFAD NHHBAHIFHJK)
		{
			return default(KBBHNEGECJL);
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x1D3CD60", Offset = "0x1D3C160", VA = "0x181D3CD60", Slot = "5")]
		public void FIIPDKPDKIJ(EJHJLJPPHCN LMAHFBOHCNI, PKBFCJOJFAD MCLCEMNNOFC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x1D3CC50", Offset = "0x1D3C050", VA = "0x181D3CC50", Slot = "6")]
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
		[Cpp2IlInjected.Address(RVA = "0x1D3E4C0", Offset = "0x1D3D8C0", VA = "0x181D3E4C0")]
		internal MOLOCMEDJOG(CHFDGNEIFAE<KBBHNEGECJL, PKBFCJOJFAD, EJHJLJPPHCN, LHINJBLMLPJ.HJMNPMINJNE<KBBHNEGECJL, PKBFCJOJFAD, EJHJLJPPHCN>> CEBGEIIIEAM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x1D3E470", Offset = "0x1D3D870", VA = "0x181D3E470")]
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
			[Cpp2IlInjected.Address(RVA = "0x1D3AE20", Offset = "0x1D3A220", VA = "0x181D3AE20", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x1D3B000", Offset = "0x1D3A400", VA = "0x181D3B000", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0xA1A890", Offset = "0xA19C90", VA = "0x180A1A890", Slot = "4")]
		public JLGMECJOLDI<LBODNCNHDMA> JBPEFEKEIIC(EJHJLJPPHCN KEHMNIODKBI)
		{
			return default(JLGMECJOLDI<LBODNCNHDMA>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x1D2BBF0", Offset = "0x1D2AFF0", VA = "0x181D2BBF0", Slot = "5")]
		[AsyncStateMachine(typeof(JNAFHALGJMO))]
		public Task<KKHLNMGODKL<object, MPIKAEBOCFI>> DOAIANMJEDP(EJHJLJPPHCN KEHMNIODKBI, PKBFCJOJFAD MCLCEMNNOFC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x1D2BD20", Offset = "0x1D2B120", VA = "0x181D2BD20", Slot = "6")]
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
		[Cpp2IlInjected.Address(RVA = "0x1D34120", Offset = "0x1D33520", VA = "0x181D34120", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x1D343A0", Offset = "0x1D337A0", VA = "0x181D343A0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x1D3BBA0", Offset = "0x1D3AFA0", VA = "0x181D3BBA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x1D3BE30", Offset = "0x1D3B230", VA = "0x181D3BE30", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x1D2B9A0", Offset = "0x1D2ADA0", VA = "0x181D2B9A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x1D2BB80", Offset = "0x1D2AF80", VA = "0x181D2BB80", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x1D38040", Offset = "0x1D37440", VA = "0x181D38040", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x1D38230", Offset = "0x1D37630", VA = "0x181D38230", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x1D3C3F0", Offset = "0x1D3B7F0", VA = "0x181D3C3F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x1D3CBE0", Offset = "0x1D3BFE0", VA = "0x181D3CBE0", Slot = "5")]
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

	[Cpp2IlInjected.FieldOffset(Offset = "0xFB0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	internal readonly NKJHHHEICAE PPDGJLNHBJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xFB8")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	internal readonly KLLNHDMNECI.JGNJLEGNCJM HGPNBDFICOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xFD8")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	internal readonly MDLFBMMKDDO AHBOHNFGIDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xFE0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	internal readonly MAPCCGGEAHJ EIIADEBOPOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xFE8")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	internal readonly JHKHAEKCONG IBNNHHIPGNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xFF0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	internal readonly ANLNOJDPDEI MILJKAAHMCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xFF8")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private NALNFODDAEP OFFIILMENIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1008")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private OHAADPEAMDL OPAHLHDCCFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1028")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	internal readonly IKGJOPKGMDP.KCNFLGBPKCA IFKKHDBNBHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1030")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	internal readonly IDOFCENLABL OAICDFINPOA;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public IKGJOPKGMDP EMBJCJMEOAC
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x1D32080", Offset = "0x1D31480", VA = "0x181D32080")]
		get
		{
			return default(IKGJOPKGMDP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	internal LMLIHKJGPHN LEPHIGFJLJH
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x1D31480", Offset = "0x1D30880", VA = "0x181D31480")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	internal OLOJIAHHKJN KEKPHNHNGMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x1D30F60", Offset = "0x1D30360", VA = "0x181D30F60")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x1D31A40", Offset = "0x1D30E40", VA = "0x181D31A40")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	internal bool LKCNFAOLEPN
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x1D314D0", Offset = "0x1D308D0", VA = "0x181D314D0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x1D32210", Offset = "0x1D31610", VA = "0x181D32210")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public LPABLGOPACM DJEKMCNOBDI
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x1D32540", Offset = "0x1D31940", VA = "0x181D32540", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public PDBOEIFOONC BKCFFPGAGKJ
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x1D32560", Offset = "0x1D31960", VA = "0x181D32560", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public EDBEDLNBPFG CFDJDGKKIAI
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x1D32570", Offset = "0x1D31970", VA = "0x181D32570", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public FBKBDOPBDJM AALAMFOJNEC
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x1D32550", Offset = "0x1D31950", VA = "0x181D32550", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	private IHOFOJLKFPJ? MGJLOBDHNDG
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x1D31F50", Offset = "0x1D31350", VA = "0x181D31F50", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	private NLKCBKLKPNJ? FPMPCKKBADK
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x1D31350", Offset = "0x1D30750", VA = "0x181D31350", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x1D32220", Offset = "0x1D31620", VA = "0x181D32220")]
	private EJHJLJPPHCN(NKJHHHEICAE MEIJHINEEKK, JLGMECJOLDI<LBODNCNHDMA> OHLLMKBPNCN, [In] KDBPMIGICMI PNBFMCMNGBB, [In] IKGJOPKGMDP FAJAINNMDDM, [In] DDDHJHEJOAC JMEAJDJFGKN, OLOJIAHHKJN APMOPJDEAAK, [In] KLLNHDMNECI.JGNJLEGNCJM NFGCFNMADEK, IKGJOPKGMDP.KCNFLGBPKCA IHCOLGMGLNJ, IDOFCENLABL FPCIECBBONA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x1D318E0", Offset = "0x1D30CE0", VA = "0x181D318E0")]
	public static EJHJLJPPHCN JKJFENIAMEL(NKJHHHEICAE NFFMMJBNJIB, IKGJOPKGMDP.BKGDLHIANGC BPIPFNDNMEN, JLGMECJOLDI<LBODNCNHDMA> OHLLMKBPNCN, JLGMECJOLDI<AGGCBADMAKJ> DNFNKCOAMIC, EDKKDEPLJLE BIHMJDLLGLH, CDOLAPOLICE GPEFEMMIGKM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x1D31600", Offset = "0x1D30A00", VA = "0x181D31600")]
	public static EJHJLJPPHCN JKJFENIAMEL(NKJHHHEICAE MEIJHINEEKK, [In] IKGJOPKGMDP FAJAINNMDDM, [In] DDDHJHEJOAC JMEAJDJFGKN, JLGMECJOLDI<LBODNCNHDMA> OHLLMKBPNCN, JLGMECJOLDI<AGGCBADMAKJ> DNFNKCOAMIC, EDKKDEPLJLE BIHMJDLLGLH, CDOLAPOLICE GPEFEMMIGKM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x1D31160", Offset = "0x1D30560", VA = "0x181D31160", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x1D31DF0", Offset = "0x1D311F0", VA = "0x181D31DF0")]
	[AsyncStateMachine(typeof(FJOHOFCDOMK))]
	internal Task<KKHLNMGODKL<bool, MPIKAEBOCFI>> MPPIJBCEKAD(FAPCIJNABKN NJFPPBLMKHP, HGAPEMBEHIA KCJNLIFKLJL, ODLEKMGFHLE JAMOLIKGFAA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x1D30E70", Offset = "0x1D30270", VA = "0x181D30E70")]
	[AsyncStateMachine(typeof(KGPDGNNHNFI))]
	public Task<KKHLNMGODKL<bool, MPIKAEBOCFI>> BCAAFANBGLD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x1D31070", Offset = "0x1D30470", VA = "0x181D31070")]
	[AsyncStateMachine(typeof(DCLPGLADKAD))]
	public Task<KKHLNMGODKL<PJHBHBBODGG, MPIKAEBOCFI>> DJMDFCBKOKH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x1D30C60", Offset = "0x1D30060", VA = "0x181D30C60")]
	internal void AJBEIMCCBMH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x1D30FF0", Offset = "0x1D303F0", VA = "0x181D30FF0")]
	internal IKGCKHLMHFG<PKBFCJOJFAD> CIJKNFPIACO([In] PPGJNIDOJJF MOFNFKOPDOA)
	{
		return default(IKGCKHLMHFG<PKBFCJOJFAD>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x1D32090", Offset = "0x1D31490", VA = "0x181D32090")]
	internal bool OIMOOJPKPOO([In] PPGJNIDOJJF MOFNFKOPDOA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x1D30F70", Offset = "0x1D30370", VA = "0x181D30F70")]
	internal IKGCKHLMHFG<PKBFCJOJFAD> BKNLKDILCPF([In] MECCDFBDFBI DJIDPCEHABN)
	{
		return default(IKGCKHLMHFG<PKBFCJOJFAD>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x1D32100", Offset = "0x1D31500", VA = "0x181D32100")]
	[AsyncStateMachine(typeof(IAJKPFKGGFO))]
	internal Task<KKHLNMGODKL<object, MPIKAEBOCFI>> OJJKOMMCNJN(PKBFCJOJFAD MCLCEMNNOFC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x1D31A60", Offset = "0x1D30E60", VA = "0x181D31A60")]
	private PKBFCJOJFAD[] LBBCAJIKAOF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x1D314E0", Offset = "0x1D308E0", VA = "0x181D314E0")]
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
	[Cpp2IlInjected.Address(RVA = "0x26DD500", Offset = "0x26DC900", VA = "0x1826DD500")]
	public static GGKILILAOPL<(TPrev?, EJHJLJPPHCN?), NLKCBKLKPNJ> MGILKPDEJCH<TPrev>([In] this GGKILILAOPL<TPrev, EJHJLJPPHCN> NHHBAHIFHJK)
	{
		return default(GGKILILAOPL<(TPrev, EJHJLJPPHCN), NLKCBKLKPNJ>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x26DD760", Offset = "0x26DCB60", VA = "0x1826DD760")]
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
		[Cpp2IlInjected.Address(RVA = "0x1ECDD70", Offset = "0x1ECD170", VA = "0x181ECDD70", Slot = "13")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x79F150", Offset = "0x79E550", VA = "0x18079F150", Slot = "7")]
	public override string GMMJBFEOGBG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x3595D30", Offset = "0x3595130", VA = "0x183595D30")]
	internal FNGEMALIHLK([In] JGKGEKHGJKB<PNMLFKAJNIK>? JOJFHEGFJIC, JLGMECJOLDI<FKIAAIPKAOJ>? NIKJMLODPHJ, IOKind? BNABONBOFFP, string DCKDMGKGDFN, [In] TData MFNOAEFOKBK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public static class JFGDKHNLNNK
{
	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x1D396A0", Offset = "0x1D38AA0", VA = "0x181D396A0")]
	public static KKHLNMGODKL<ACCHIDBIDPG, ANFENGAPHOD> GFOONLHMBFB([In] this PPDFEHDDBPE<BIBCPEMILGM> KELJFGOOBCN)
	{
		return default(KKHLNMGODKL<ACCHIDBIDPG, ANFENGAPHOD>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x2695AA0", Offset = "0x2694EA0", VA = "0x182695AA0")]
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
	[Cpp2IlInjected.Address(RVA = "0x1D2A400", Offset = "0x1D29800", VA = "0x181D2A400")]
	public static PKBFCJOJFAD DODMKLOKGJC(this PKBFCJOJFAD NHHBAHIFHJK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x1D2A330", Offset = "0x1D29730", VA = "0x181D2A330")]
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
		[Cpp2IlInjected.Address(RVA = "0x1D34410", Offset = "0x1D33810", VA = "0x181D34410", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x1D346D0", Offset = "0x1D33AD0", VA = "0x181D346D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public readonly ByteString NAJOFLHMBPO;

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x8BBF70", Offset = "0x8BB370", VA = "0x1808BBF70")]
	private HDHGDCLBMOB(ByteString FDFHGIHHGHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x1D35880", Offset = "0x1D34C80", VA = "0x181D35880")]
	public static PKBFCJOJFAD NHNGALPFEDB(ByteString FDFHGIHHGHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x1D35940", Offset = "0x1D34D40", VA = "0x181D35940")]
	public static OBFJIOOLHIO<KBBHNEGECJL, HDHGDCLBMOB> OFKDDLBANEJ(PKBFCJOJFAD NCDEJOGBLGM)
	{
		return default(OBFJIOOLHIO<KBBHNEGECJL, HDHGDCLBMOB>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x1D359F0", Offset = "0x1D34DF0", VA = "0x181D359F0")]
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
	[Cpp2IlInjected.Address(RVA = "0x1D3C2E0", Offset = "0x1D3B6E0", VA = "0x181D3C2E0")]
	public static PKBFCJOJFAD NHNGALPFEDB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x1D3C380", Offset = "0x1D3B780", VA = "0x181D3C380")]
	public static OBFJIOOLHIO<KBBHNEGECJL, LANHNLKALAF> OFKDDLBANEJ(PKBFCJOJFAD NCDEJOGBLGM)
	{
		return default(OBFJIOOLHIO<KBBHNEGECJL, LANHNLKALAF>);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x1D3C260", Offset = "0x1D3B660", VA = "0x181D3C260")]
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
		[Cpp2IlInjected.Address(RVA = "0x1D3F950", Offset = "0x1D3ED50", VA = "0x181D3F950", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x1D3FCC0", Offset = "0x1D3F0C0", VA = "0x181D3FCC0", Slot = "5")]
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
	[Cpp2IlInjected.Address(RVA = "0x1A31300", Offset = "0x1A30700", VA = "0x181A31300")]
	private OPLALMEHBIA(FAPCIJNABKN? NJFPPBLMKHP, HGAPEMBEHIA? KCJNLIFKLJL, ODLEKMGFHLE? JAMOLIKGFAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x1D3F600", Offset = "0x1D3EA00", VA = "0x181D3F600")]
	public static PKBFCJOJFAD? NHNGALPFEDB(FAPCIJNABKN? NJFPPBLMKHP, HGAPEMBEHIA? KCJNLIFKLJL, ODLEKMGFHLE? JAMOLIKGFAA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x1D3F700", Offset = "0x1D3EB00", VA = "0x181D3F700")]
	public static OBFJIOOLHIO<KBBHNEGECJL, OPLALMEHBIA> OFKDDLBANEJ(PKBFCJOJFAD NCDEJOGBLGM)
	{
		return default(OBFJIOOLHIO<KBBHNEGECJL, OPLALMEHBIA>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x1D3F810", Offset = "0x1D3EC10", VA = "0x181D3F810")]
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
		[Cpp2IlInjected.Address(RVA = "0x1D30780", Offset = "0x1D2FB80", VA = "0x181D30780", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x1D30BF0", Offset = "0x1D2FFF0", VA = "0x181D30BF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public readonly IReadOnlyList<PKBFCJOJFAD> GEKKCFAGEBB;

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x8BBF70", Offset = "0x8BB370", VA = "0x1808BBF70")]
	private HGDLALLEHNA(IReadOnlyList<PKBFCJOJFAD> BDOEJBMENLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x1D35B00", Offset = "0x1D34F00", VA = "0x181D35B00")]
	public static PKBFCJOJFAD NHNGALPFEDB(IReadOnlyList<PKBFCJOJFAD> BDOEJBMENLB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x1D35BC0", Offset = "0x1D34FC0", VA = "0x181D35BC0")]
	public static OBFJIOOLHIO<KBBHNEGECJL, HGDLALLEHNA> OFKDDLBANEJ(PKBFCJOJFAD NCDEJOGBLGM)
	{
		return default(OBFJIOOLHIO<KBBHNEGECJL, HGDLALLEHNA>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x1D35C60", Offset = "0x1D35060", VA = "0x181D35C60")]
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
	[Cpp2IlInjected.Address(RVA = "0x17A0F00", Offset = "0x17A0300", VA = "0x1817A0F00")]
	private MECCDFBDFBI(int DPBEIPGOMHN, int OJANCMLFDOJ, byte[] MFNOAEFOKBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x1D3D630", Offset = "0x1D3CA30", VA = "0x181D3D630")]
	public static PKBFCJOJFAD NHNGALPFEDB(int DPBEIPGOMHN, int OJANCMLFDOJ, ByteString MFNOAEFOKBK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x1D3D3D0", Offset = "0x1D3C7D0", VA = "0x181D3D3D0")]
	public static PKBFCJOJFAD[] CNDPFGKHEBH(PKBFCJOJFAD MCLCEMNNOFC, int ECEGNNEMCAK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x1D3D710", Offset = "0x1D3CB10", VA = "0x181D3D710")]
	public static OBFJIOOLHIO<KBBHNEGECJL, MECCDFBDFBI> OFKDDLBANEJ(PKBFCJOJFAD NCDEJOGBLGM)
	{
		return default(OBFJIOOLHIO<KBBHNEGECJL, MECCDFBDFBI>);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x1D3D510", Offset = "0x1D3C910", VA = "0x181D3D510")]
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
		[Cpp2IlInjected.Address(RVA = "0x1D3DDC0", Offset = "0x1D3D1C0", VA = "0x181D3DDC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x1D3E400", Offset = "0x1D3D800", VA = "0x181D3E400", Slot = "5")]
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
	[Cpp2IlInjected.Address(RVA = "0x17A0F00", Offset = "0x17A0300", VA = "0x1817A0F00")]
	private PPGJNIDOJJF(int DPBEIPGOMHN, int OJANCMLFDOJ, byte[] MFNOAEFOKBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x1D3FF30", Offset = "0x1D3F330", VA = "0x181D3FF30")]
	public static PKBFCJOJFAD NHNGALPFEDB(int DPBEIPGOMHN, int OJANCMLFDOJ, ByteString MFNOAEFOKBK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x1D3FD30", Offset = "0x1D3F130", VA = "0x181D3FD30")]
	public static PKBFCJOJFAD?[]? DPFOLKLGDOB(int ECEGNNEMCAK, FAPCIJNABKN? NJFPPBLMKHP, HGAPEMBEHIA? KCJNLIFKLJL, ODLEKMGFHLE? JAMOLIKGFAA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x1D40010", Offset = "0x1D3F410", VA = "0x181D40010")]
	public static OBFJIOOLHIO<KBBHNEGECJL, PPGJNIDOJJF> OFKDDLBANEJ(PKBFCJOJFAD NCDEJOGBLGM)
	{
		return default(OBFJIOOLHIO<KBBHNEGECJL, PPGJNIDOJJF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x1D400F0", Offset = "0x1D3F4F0", VA = "0x181D400F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x1D3D2C0", Offset = "0x1D3C6C0", VA = "0x181D3D2C0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x7ABBD0", Offset = "0x7AAFD0", VA = "0x1807ABBD0")]
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
	[Cpp2IlInjected.Address(RVA = "0x7A6130", Offset = "0x7A5530", VA = "0x1807A6130")]
	public BDFLODFADHK(EJHJLJPPHCN BALKEACFDJN, DEEIIACCHIP NEMDKECFAGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x1D2A8A0", Offset = "0x1D29CA0", VA = "0x181D2A8A0", Slot = "4")]
	public KKHLNMGODKL<ACCHIDBIDPG, ANFENGAPHOD> ADFPNOIMBLL(JGKGEKHGJKB<PNMLFKAJNIK> KOOMGHGCPCM, JLGMECJOLDI<EHGNFGGIBEB> NDKHLPHIJIN, JLGMECJOLDI<ALOBLIADAMK> FIPNEPOHCEF)
	{
		return default(KKHLNMGODKL<ACCHIDBIDPG, ANFENGAPHOD>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x1D2AB70", Offset = "0x1D29F70", VA = "0x181D2AB70", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x1D2A510", Offset = "0x1D29910", VA = "0x181D2A510", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(RVA = "0x1D2A830", Offset = "0x1D29C30", VA = "0x181D2A830", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public static readonly AJCPDJDPHGB MEGHANKAOBP;

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x7A4800", Offset = "0x7A3C00", VA = "0x1807A4800")]
		private AJCPDJDPHGB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x1D29F20", Offset = "0x1D29320", VA = "0x181D29F20", Slot = "4")]
		[AsyncStateMachine(typeof(BAJDHKCCMJO))]
		public Task<DEEIIACCHIP> IJFOANMNABG(EJHJLJPPHCN BALKEACFDJN, HGAPEMBEHIA? JLBKLFJBNIA, ODLEKMGFHLE? AMBABCKBIEK, CancellationToken HNLFPBLPOKJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x1D2A080", Offset = "0x1D29480", VA = "0x181D2A080", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x1D3D7F0", Offset = "0x1D3CBF0", VA = "0x181D3D7F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x1D3DD50", Offset = "0x1D3D150", VA = "0x181D3DD50", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x1D391D0", Offset = "0x1D385D0", VA = "0x181D391D0", Slot = "4")]
		get
		{
			return default(IHOFOJLKFPJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public NLKCBKLKPNJ GONJGKLODIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x1D39000", Offset = "0x1D38400", VA = "0x181D39000", Slot = "5")]
		get
		{
			return default(NLKCBKLKPNJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public BDFLODFADHK JFLAPBJFCIB
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x7A2270", Offset = "0x7A1670", VA = "0x1807A2270", Slot = "6")]
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
		[Cpp2IlInjected.Address(RVA = "0x79F1E0", Offset = "0x79E5E0", VA = "0x18079F1E0", Slot = "8")]
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
		[Cpp2IlInjected.Address(RVA = "0x79F100", Offset = "0x79E500", VA = "0x18079F100", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x1D39230", Offset = "0x1D38630", VA = "0x181D39230")]
	private IGOGAMCOFBL(DEEIIACCHIP NEMDKECFAGI, HDEAGHOKJFL JFANONPAIDP, BDFLODFADHK AJFAMPBIBKB, HPBOKLJNGGO PKHHPHECAPK, FOAFAGELKHL PHLJJJLOJIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x1D39060", Offset = "0x1D38460", VA = "0x181D39060")]
	[AsyncStateMachine(typeof(MEIHJHHPAOL))]
	public static Task<IGOGAMCOFBL> MNPMCBDFPDL(EJHJLJPPHCN BALKEACFDJN, FAPCIJNABKN DPLOCHMLAED, HGAPEMBEHIA? JLBKLFJBNIA, ODLEKMGFHLE? AMBABCKBIEK, CancellationToken HNLFPBLPOKJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x1D38FA0", Offset = "0x1D383A0", VA = "0x181D38FA0", Slot = "9")]
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
			[Cpp2IlInjected.Address(RVA = "0x1D303D0", Offset = "0x1D2F7D0", VA = "0x181D303D0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0x1D30710", Offset = "0x1D2FB10", VA = "0x181D30710", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x1D38700", Offset = "0x1D37B00", VA = "0x181D38700", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x7A4800", Offset = "0x7A3C00", VA = "0x1807A4800")]
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
		[Cpp2IlInjected.Address(RVA = "0x1D3E7A0", Offset = "0x1D3DBA0", VA = "0x181D3E7A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x1D3E9A0", Offset = "0x1D3DDA0", VA = "0x181D3E9A0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x1D3B610", Offset = "0x1D3AA10", VA = "0x181D3B610", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x1D3BB40", Offset = "0x1D3AF40", VA = "0x181D3BB40", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x7F4190", Offset = "0x7F3590", VA = "0x1807F4190", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x7F3C90", Offset = "0x7F3090", VA = "0x1807F3C90")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public bool FEJBNDKBHDE
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x8B84F0", Offset = "0x8B78F0", VA = "0x1808B84F0", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x8B84E0", Offset = "0x8B78E0", VA = "0x1808B84E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public bool LFHDMKJMKAD
	{
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0xEAB230", Offset = "0xEAA630", VA = "0x180EAB230")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x1D354F0", Offset = "0x1D348F0", VA = "0x181D354F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public HGBGBPBGNKL? OPHBLECMLLJ
	{
		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x79F320", Offset = "0x79E720", VA = "0x18079F320", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x79F430", Offset = "0x79E830", VA = "0x18079F430")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x1D35400", Offset = "0x1D34800", VA = "0x181D35400", Slot = "7")]
	[AsyncStateMachine(typeof(OCICHLFCAHA))]
	public Task<HGBGBPBGNKL> LMCNBJNHFCB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x1D35660", Offset = "0x1D34A60", VA = "0x181D35660")]
	public HAEEEJDFFEI(PBABOHLILAM NFFMMJBNJIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x1D35500", Offset = "0x1D34900", VA = "0x181D35500", Slot = "8")]
	[AsyncStateMachine(typeof(KFNLPFGEMDP))]
	public Task PDGIJEJGCPM(EJHJLJPPHCN BALKEACFDJN, FAPCIJNABKN DPLOCHMLAED, HGAPEMBEHIA? JLBKLFJBNIA, ODLEKMGFHLE? AMBABCKBIEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x1D35290", Offset = "0x1D34690", VA = "0x181D35290", Slot = "9")]
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
	[Cpp2IlInjected.Address(RVA = "0x7ABBD0", Offset = "0x7AAFD0", VA = "0x1807ABBD0")]
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
			[Cpp2IlInjected.Address(RVA = "0xD05070", Offset = "0xD04470", VA = "0x180D05070", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x7ABBD0", Offset = "0x7AAFD0", VA = "0x1807ABBD0")]
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
			[Cpp2IlInjected.Address(RVA = "0x1D3E4D0", Offset = "0x1D3D8D0", VA = "0x181D3E4D0", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x1D3E4F0", Offset = "0x1D3D8F0", VA = "0x181D3E4F0")]
		public MPDGOKCDLOI(PNEJKEHNLAC CACILELLPMI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x1D39B70", Offset = "0x1D38F70", VA = "0x181D39B70")]
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
			[Cpp2IlInjected.Address(RVA = "0x1D40220", Offset = "0x1D3F620", VA = "0x181D40220", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000DC")]
			[Cpp2IlInjected.Address(RVA = "0x1D40490", Offset = "0x1D3F890", VA = "0x181D40490", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x7A4800", Offset = "0x7A3C00", VA = "0x1807A4800")]
		public JGLBIBHCAHO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x1D39A80", Offset = "0x1D38E80", VA = "0x181D39A80")]
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
		[Cpp2IlInjected.Address(RVA = "0x1D34920", Offset = "0x1D33D20", VA = "0x181D34920", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x1D34E10", Offset = "0x1D34210", VA = "0x181D34E10", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x1D404F0", Offset = "0x1D3F8F0", VA = "0x181D404F0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E2")]
			[Cpp2IlInjected.Address(RVA = "0x1D407D0", Offset = "0x1D3FBD0", VA = "0x181D407D0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x7A4800", Offset = "0x7A3C00", VA = "0x1807A4800")]
		public AHBONKJNJKP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x1D29E50", Offset = "0x1D29250", VA = "0x181D29E50")]
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
		[Cpp2IlInjected.Address(RVA = "0x1D2E090", Offset = "0x1D2D490", VA = "0x181D2E090")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public JLGMECJOLDI<ALOBLIADAMK> BDHEBKDLLEB
	{
		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0xA1E920", Offset = "0xA1DD20", VA = "0x180A1E920", Slot = "23")]
		[CompilerGenerated]
		get
		{
			return default(JLGMECJOLDI<ALOBLIADAMK>);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0xA671C0", Offset = "0xA665C0", VA = "0x180A671C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public override JLGMECJOLDI<FKIAAIPKAOJ> HGIHJLEFAOP
	{
		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x1D2D590", Offset = "0x1D2C990", VA = "0x181D2D590", Slot = "19")]
		get
		{
			return default(JLGMECJOLDI<FKIAAIPKAOJ>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public bool BNJOECIGCMI
	{
		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x1D2D5D0", Offset = "0x1D2C9D0", VA = "0x181D2D5D0", Slot = "24")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x1D2FDF0", Offset = "0x1D2F1F0", VA = "0x181D2FDF0")]
	private DLKAMECFEEF(EJHJLJPPHCN BALKEACFDJN, DLLEFNELPBJ JACJPEOECBN, BFMMFHJHKDA EEJLGCKPMMH, JLGMECJOLDI<EHGNFGGIBEB> NDKHLPHIJIN, JLGMECJOLDI<ALOBLIADAMK> FIPNEPOHCEF, bool OBPFIAGBNAK, string OMHHPMIDNAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x1D2E200", Offset = "0x1D2D600", VA = "0x181D2E200")]
	public static DLKAMECFEEF JKJFENIAMEL(EJHJLJPPHCN BALKEACFDJN, DLLEFNELPBJ JACJPEOECBN, BFMMFHJHKDA KODNHMICLEA, JLGMECJOLDI<EHGNFGGIBEB> NDKHLPHIJIN, JLGMECJOLDI<NJIGMIHFIFI> AJIHFKHEMCB, JLGMECJOLDI<ALOBLIADAMK> FIPNEPOHCEF, bool OBPFIAGBNAK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x1D2F730", Offset = "0x1D2EB30", VA = "0x181D2F730", Slot = "20")]
	protected override void NGFHLNOOHDK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x1D2DAC0", Offset = "0x1D2CEC0", VA = "0x181D2DAC0", Slot = "21")]
	public override void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x1D2E130", Offset = "0x1D2D530", VA = "0x181D2E130", Slot = "28")]
	public void JCJBBLCGGML(NJAPPKBAIFA JLALALMCDDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x1D2EF30", Offset = "0x1D2E330", VA = "0x181D2EF30", Slot = "25")]
	public void LBDIMKICOHJ(LMBFPMLFMHF BOPLNCKCDIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x1D2E590", Offset = "0x1D2D990", VA = "0x181D2E590", Slot = "26")]
	public void JPABEFCEDBH(OKPDIANEPII NDIDFGEIGNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x1D2DFB0", Offset = "0x1D2D3B0", VA = "0x181D2DFB0", Slot = "22")]
	protected override void HAMKPEPNOEK(HMJEIHCLKCA EAEGBKJOMLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x1D2F310", Offset = "0x1D2E710", VA = "0x181D2F310", Slot = "30")]
	public string LOEMDIEPNLK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x1D2D790", Offset = "0x1D2CB90", VA = "0x181D2D790", Slot = "27")]
	public string DOJEMPOBIFN(int HPAEJNPCJHD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x1D2D360", Offset = "0x1D2C760", VA = "0x181D2D360")]
	private void CIMCFGLFJGF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x1D2FD20", Offset = "0x1D2F120", VA = "0x181D2FD20", Slot = "29")]
	public void PNKEJJOKHIP(NJAPPKBAIFA JLALALMCDDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x1D2F8F0", Offset = "0x1D2ECF0", VA = "0x181D2F8F0")]
	private void NHKENDKLAJF(bool FDFHGIHHGHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x1D2DC80", Offset = "0x1D2D080", VA = "0x181D2DC80", Slot = "31")]
	[AsyncStateMachine(typeof(FPJKIFOFKBA))]
	public Task EBGPJDNDFLH(string FDFHGIHHGHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x1D2D1E0", Offset = "0x1D2C5E0", VA = "0x181D2D1E0")]
	public void AHKEAJPEBFB(string FDFHGIHHGHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x1D2D040", Offset = "0x1D2C440", VA = "0x181D2D040")]
	private void AGBIGIKIGHM(int FDFHGIHHGHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0xA671C0", Offset = "0xA665C0", VA = "0x180A671C0")]
	internal void ONDPCBKJNAP(JLGMECJOLDI<ALOBLIADAMK> FDFHGIHHGHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x1D2DD80", Offset = "0x1D2D180", VA = "0x181D2DD80")]
	[CompilerGenerated]
	private bool ECLMCLOLCAD()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x1D2F5E0", Offset = "0x1D2E9E0", VA = "0x181D2F5E0")]
	[CompilerGenerated]
	private bool NDEDFFHFDPJ()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x1D2D310", Offset = "0x1D2C710", VA = "0x181D2D310")]
	[CompilerGenerated]
	private int MELALCAAJGD()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x1D2F480", Offset = "0x1D2E880", VA = "0x181D2F480")]
	[CompilerGenerated]
	private bool MAKNDBJNAFP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x1D2FBD0", Offset = "0x1D2EFD0", VA = "0x181D2FBD0")]
	[CompilerGenerated]
	private bool PIMAKMGKAJO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x1D2DED0", Offset = "0x1D2D2D0", VA = "0x181D2DED0")]
	[CompilerGenerated]
	private bool GKKPIPCAMNE()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x1D2DF20", Offset = "0x1D2D320", VA = "0x181D2DF20")]
	[CompilerGenerated]
	private bool GNJHAMJMEJK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x1D2D310", Offset = "0x1D2C710", VA = "0x181D2D310")]
	[CompilerGenerated]
	private int BKLIJFPKDPC()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x1D2F510", Offset = "0x1D2E910", VA = "0x181D2F510")]
	[CompilerGenerated]
	private bool MFFCOAMLOPL()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x1D2FAB0", Offset = "0x1D2EEB0", VA = "0x181D2FAB0")]
	[CompilerGenerated]
	private int OAOLCNMDIBB()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x1D2E0B0", Offset = "0x1D2D4B0", VA = "0x181D2E0B0")]
	[CompilerGenerated]
	private void JBMFMAFCNBI(object FDFHGIHHGHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x1D2FB00", Offset = "0x1D2EF00", VA = "0x181D2FB00")]
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
			[Cpp2IlInjected.Address(RVA = "0x3799690", Offset = "0x3798A90", VA = "0x183799690", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000ED")]
			[Cpp2IlInjected.Address(RVA = "0x3799A60", Offset = "0x3798E60", VA = "0x183799A60", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x3635CA0", Offset = "0x36350A0", VA = "0x183635CA0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000EF")]
			[Cpp2IlInjected.Address(RVA = "0x3636070", Offset = "0x3635470", VA = "0x183636070", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public sealed override bool HLPIPOKDALH
		{
			[Cpp2IlInjected.Token(Token = "0x60000E4")]
			[Cpp2IlInjected.Address(RVA = "0x7B8240", Offset = "0x7B7640", VA = "0x1807B8240", Slot = "110")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public sealed override JLGMECJOLDI<EHGNFGGIBEB>? PIKBKFBPJPI
		{
			[Cpp2IlInjected.Token(Token = "0x60000E5")]
			[Cpp2IlInjected.Address(RVA = "0x3F8EBD0", Offset = "0x3F8DFD0", VA = "0x183F8EBD0", Slot = "114")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x3B16790", Offset = "0x3B15B90", VA = "0x183B16790")]
		public PBLHJCOAKMM(EJHJLJPPHCN BALKEACFDJN, TNode JACJPEOECBN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x3F8E970", Offset = "0x3F8DD70", VA = "0x183F8E970", Slot = "93")]
		[AsyncStateMachine(typeof(PBLHJCOAKMM<>.IFEJPHPIGKP))]
		public override Task<KKHLNMGODKL<JLGMECJOLDI<EHGNFGGIBEB>, MPIKAEBOCFI>> IBIJJNOCACN(string OMHHPMIDNAN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x3F8E7C0", Offset = "0x3F8DBC0", VA = "0x183F8E7C0", Slot = "117")]
		public sealed override bool FAOJBIOIACL(JLGMECJOLDI<EHGNFGGIBEB> NDKHLPHIJIN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x3F8EA90", Offset = "0x3F8DE90", VA = "0x183F8EA90", Slot = "107")]
		protected sealed override bool NKCEPDJCADI(JLGMECJOLDI<EHGNFGGIBEB> NDKHLPHIJIN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x3F8EB30", Offset = "0x3F8DF30", VA = "0x183F8EB30", Slot = "108")]
		protected override bool PJFIHEFLFDO(JLGMECJOLDI<EHGNFGGIBEB> NDKHLPHIJIN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x3F8E860", Offset = "0x3F8DC60", VA = "0x183F8E860", Slot = "94")]
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
			[Cpp2IlInjected.Address(RVA = "0x7E8CB0", Offset = "0x7E80B0", VA = "0x1807E8CB0", Slot = "83")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x1D2A1C0", Offset = "0x1D295C0", VA = "0x181D2A1C0")]
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
			[Cpp2IlInjected.Address(RVA = "0x4867360", Offset = "0x4866760", VA = "0x184867360", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FB")]
			[Cpp2IlInjected.Address(RVA = "0x48676D0", Offset = "0x4866AD0", VA = "0x1848676D0", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x3B4BD50", Offset = "0x3B4B150", VA = "0x183B4BD50", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FD")]
			[Cpp2IlInjected.Address(RVA = "0x3B4C0A0", Offset = "0x3B4B4A0", VA = "0x183B4C0A0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public override JLGMECJOLDI<BIKLLPOLGEF>? IFELHIDPOGE
		{
			[Cpp2IlInjected.Token(Token = "0x60000F2")]
			[Cpp2IlInjected.Address(RVA = "0x3B167B0", Offset = "0x3B15BB0", VA = "0x183B167B0", Slot = "111")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public override JLGMECJOLDI<EHGNFGGIBEB>? PIKBKFBPJPI
		{
			[Cpp2IlInjected.Token(Token = "0x60000F3")]
			[Cpp2IlInjected.Address(RVA = "0x3B16860", Offset = "0x3B15C60", VA = "0x183B16860", Slot = "114")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x3B16790", Offset = "0x3B15B90", VA = "0x183B16790")]
		public LBIEPDJGOBN(EJHJLJPPHCN BALKEACFDJN, TNode JACJPEOECBN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x3B16530", Offset = "0x3B15930", VA = "0x183B16530", Slot = "93")]
		[AsyncStateMachine(typeof(LBIEPDJGOBN<>.CCIINCECPHC))]
		public override Task<KKHLNMGODKL<JLGMECJOLDI<EHGNFGGIBEB>, MPIKAEBOCFI>> IBIJJNOCACN(string OMHHPMIDNAN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x3B16380", Offset = "0x3B15780", VA = "0x183B16380", Slot = "117")]
		public sealed override bool FAOJBIOIACL(JLGMECJOLDI<EHGNFGGIBEB> NDKHLPHIJIN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x3B16650", Offset = "0x3B15A50", VA = "0x183B16650", Slot = "107")]
		protected sealed override bool NKCEPDJCADI(JLGMECJOLDI<EHGNFGGIBEB> NDKHLPHIJIN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x3B166F0", Offset = "0x3B15AF0", VA = "0x183B166F0", Slot = "108")]
		protected override bool PJFIHEFLFDO(JLGMECJOLDI<EHGNFGGIBEB> NDKHLPHIJIN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x3B16420", Offset = "0x3B15820", VA = "0x183B16420", Slot = "94")]
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
			[Cpp2IlInjected.Address(RVA = "0x9B8090", Offset = "0x9B7490", VA = "0x1809B8090", Slot = "83")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x1D2B4E0", Offset = "0x1D2A8E0", VA = "0x181D2B4E0")]
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
			[Cpp2IlInjected.Address(RVA = "0x7B8240", Offset = "0x7B7640", VA = "0x1807B8240", Slot = "85")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public override bool FFLOFPOGGHN
		{
			[Cpp2IlInjected.Token(Token = "0x6000101")]
			[Cpp2IlInjected.Address(RVA = "0x1D2A180", Offset = "0x1D29580", VA = "0x181D2A180", Slot = "112")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public override NodeVisualizationKey JFBDDAMOHDF
		{
			[Cpp2IlInjected.Token(Token = "0x6000102")]
			[Cpp2IlInjected.Address(RVA = "0x884380", Offset = "0x883780", VA = "0x180884380", Slot = "83")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x1D2A120", Offset = "0x1D29520", VA = "0x181D2A120")]
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
			[Cpp2IlInjected.Address(RVA = "0x10080D0", Offset = "0x10074D0", VA = "0x1810080D0", Slot = "83")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x1D3B0E0", Offset = "0x1D3A4E0", VA = "0x181D3B0E0")]
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
			[Cpp2IlInjected.Address(RVA = "0x8856A0", Offset = "0x884AA0", VA = "0x1808856A0", Slot = "83")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x1D32CD0", Offset = "0x1D320D0", VA = "0x181D32CD0")]
		public ENONBCKAPMP(EJHJLJPPHCN BALKEACFDJN, EEHADKDGBMH JACJPEOECBN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x7B8240", Offset = "0x7B7640", VA = "0x1807B8240", Slot = "107")]
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
			[Cpp2IlInjected.Address(RVA = "0x8985B0", Offset = "0x8979B0", VA = "0x1808985B0", Slot = "83")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public override bool CHDEIKLBCJC
		{
			[Cpp2IlInjected.Token(Token = "0x600010A")]
			[Cpp2IlInjected.Address(RVA = "0x1D2BDA0", Offset = "0x1D2B1A0", VA = "0x181D2BDA0", Slot = "84")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		protected override bool GGEOMGDLFKD
		{
			[Cpp2IlInjected.Token(Token = "0x600010B")]
			[Cpp2IlInjected.Address(RVA = "0x7B8240", Offset = "0x7B7640", VA = "0x1807B8240", Slot = "82")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x1D2BD40", Offset = "0x1D2B140", VA = "0x181D2BD40")]
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
			[Cpp2IlInjected.Address(RVA = "0x882E30", Offset = "0x882230", VA = "0x180882E30", Slot = "83")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public override bool CHDEIKLBCJC
		{
			[Cpp2IlInjected.Token(Token = "0x600010E")]
			[Cpp2IlInjected.Address(RVA = "0x1D3ADD0", Offset = "0x1D3A1D0", VA = "0x181D3ADD0", Slot = "84")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		protected override bool GGEOMGDLFKD
		{
			[Cpp2IlInjected.Token(Token = "0x600010F")]
			[Cpp2IlInjected.Address(RVA = "0x7B8240", Offset = "0x7B7640", VA = "0x1807B8240", Slot = "82")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x1D3AD70", Offset = "0x1D3A170", VA = "0x181D3AD70")]
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
			[Cpp2IlInjected.Address(RVA = "0x88FA80", Offset = "0x88EE80", VA = "0x18088FA80", Slot = "83")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x1D2B940", Offset = "0x1D2AD40", VA = "0x181D2B940")]
		public DBMKDPGGOOP(EJHJLJPPHCN BALKEACFDJN, ALFOCBEIAAF JACJPEOECBN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004A")]
	public class OJDKNDJFNFM<TNode> : MJLPNDIJFMP, IDisposable where TNode : notnull, DLLEFNELPBJ
	{
		[Cpp2IlInjected.Token(Token = "0x200004B")]
		[CompilerGenerated]
		private sealed class PHAAOGBJGCK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000E0")]
			public OJDKNDJFNFM<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000E1")]
			public EJHJLJPPHCN circuitsManager;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000E2")]
			public TNode node;

			[Cpp2IlInjected.Token(Token = "0x6000182")]
			[Cpp2IlInjected.Address(RVA = "0x7A4800", Offset = "0x7A3C00", VA = "0x1807A4800")]
			public PHAAOGBJGCK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000183")]
			[Cpp2IlInjected.Address(RVA = "0x3FA65F0", Offset = "0x3FA59F0", VA = "0x183FA65F0")]
			internal ABKJNJFGHFI IGIPGAMALAP(AHNMMIBEPOP portGroup, int index)
			{
				return null;
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200004C")]
		[CompilerGenerated]
		private struct ANLMKDHKMMJ : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000E3")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000E4")]
			public AsyncTaskMethodBuilder<KKHLNMGODKL<PJHBHBBODGG, MPIKAEBOCFI>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000E5")]
			public OJDKNDJFNFM<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000E6")]
			public GJDJJMDPPKC? localPosition;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000E7")]
			public FKIBNGAKAAJ? localRotation;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000E8")]
			private TaskAwaiter<KKHLNMGODKL<PJHBHBBODGG, MPIKAEBOCFI>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000184")]
			[Cpp2IlInjected.Address(RVA = "0x36735D0", Offset = "0x36729D0", VA = "0x1836735D0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000185")]
			[Cpp2IlInjected.Address(RVA = "0x3673870", Offset = "0x3672C70", VA = "0x183673870", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200004D")]
		[CompilerGenerated]
		private struct GGIDJIOFDCF : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000E9")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000EA")]
			public AsyncTaskMethodBuilder<KKHLNMGODKL<PJHBHBBODGG, MPIKAEBOCFI>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000EB")]
			public OJDKNDJFNFM<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000EC")]
			public string newName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000ED")]
			private TaskAwaiter<KKHLNMGODKL<PJHBHBBODGG, MPIKAEBOCFI>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000186")]
			[Cpp2IlInjected.Address(RVA = "0x36922E0", Offset = "0x36916E0", VA = "0x1836922E0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000187")]
			[Cpp2IlInjected.Address(RVA = "0x3692540", Offset = "0x3691940", VA = "0x183692540", Slot = "5")]
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
		private AGBIKGLHIDI<EHGNFGGIBEB, ABKJNJFGHFI> DOFIDNENBJA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		private AGBIKGLHIDI<EHGNFGGIBEB, EMOFHMMOPFO> HOMODKAODJD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		private List<Action> KGLCBDPIEPL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		[CompilerGenerated]
		private Action<JLGMECJOLDI<EHGNFGGIBEB>>? NLDAFIIEGBL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		[CompilerGenerated]
		private Action<JLGMECJOLDI<EHGNFGGIBEB>, EMOFHMMOPFO>? KENLPGNAOOE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		[CompilerGenerated]
		private Action<JLGMECJOLDI<EHGNFGGIBEB>, JLGMECJOLDI<EHGNFGGIBEB>>? CMIBCFAOMPF;

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		protected TNode ELLCAAINHDD
		{
			[Cpp2IlInjected.Token(Token = "0x6000116")]
			[Cpp2IlInjected.Address(RVA = "0x79F1E0", Offset = "0x79E5E0", VA = "0x18079F1E0")]
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
			[Cpp2IlInjected.Address(RVA = "0xE46BB0", Offset = "0xE45FB0", VA = "0x180E46BB0", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x31DEC80", Offset = "0x31DE080", VA = "0x1831DEC80", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		public virtual bool HBKLELLEJLD
		{
			[Cpp2IlInjected.Token(Token = "0x6000119")]
			[Cpp2IlInjected.Address(RVA = "0x7B8240", Offset = "0x7B7640", VA = "0x1807B8240", Slot = "80")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public int IBKABMHFCJI
		{
			[Cpp2IlInjected.Token(Token = "0x600011A")]
			[Cpp2IlInjected.Address(RVA = "0x3EF9890", Offset = "0x3EF8C90", VA = "0x183EF9890", Slot = "7")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		public PEMPOOCNEEL ADLLDGPLCHE
		{
			[Cpp2IlInjected.Token(Token = "0x600011C")]
			[Cpp2IlInjected.Address(RVA = "0x3EF9840", Offset = "0x3EF8C40", VA = "0x183EF9840", Slot = "9")]
			get
			{
				return default(PEMPOOCNEEL);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		public string GLFKKFLFNDA
		{
			[Cpp2IlInjected.Token(Token = "0x600011D")]
			[Cpp2IlInjected.Address(RVA = "0x3EF9C60", Offset = "0x3EF9060", VA = "0x183EF9C60", Slot = "10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		protected virtual bool GGEOMGDLFKD
		{
			[Cpp2IlInjected.Token(Token = "0x600011E")]
			[Cpp2IlInjected.Address(RVA = "0x7E58B0", Offset = "0x7E4CB0", VA = "0x1807E58B0", Slot = "82")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		public virtual NodeVisualizationKey JFBDDAMOHDF
		{
			[Cpp2IlInjected.Token(Token = "0x600011F")]
			[Cpp2IlInjected.Address(RVA = "0x79E380", Offset = "0x79D780", VA = "0x18079E380", Slot = "83")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000043")]
		public JLGMECJOLDI<IALGBNHAPFA> MEBHHGHLNPO
		{
			[Cpp2IlInjected.Token(Token = "0x6000120")]
			[Cpp2IlInjected.Address(RVA = "0x7AD1C0", Offset = "0x7AC5C0", VA = "0x1807AD1C0", Slot = "12")]
			[CompilerGenerated]
			get
			{
				return default(JLGMECJOLDI<IALGBNHAPFA>);
			}
			[Cpp2IlInjected.Token(Token = "0x6000121")]
			[Cpp2IlInjected.Address(RVA = "0xD052D0", Offset = "0xD046D0", VA = "0x180D052D0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		public virtual bool CHDEIKLBCJC
		{
			[Cpp2IlInjected.Token(Token = "0x6000122")]
			[Cpp2IlInjected.Address(RVA = "0x7E58B0", Offset = "0x7E4CB0", VA = "0x1807E58B0", Slot = "84")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000045")]
		public virtual bool PBPOOPJDMNC
		{
			[Cpp2IlInjected.Token(Token = "0x6000123")]
			[Cpp2IlInjected.Address(RVA = "0x7E58B0", Offset = "0x7E4CB0", VA = "0x1807E58B0", Slot = "85")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000046")]
		public virtual LEMGGEBFAJE ALJDHPPBEPA
		{
			[Cpp2IlInjected.Token(Token = "0x6000124")]
			[Cpp2IlInjected.Address(RVA = "0x87A650", Offset = "0x879A50", VA = "0x18087A650", Slot = "86")]
			get
			{
				return default(LEMGGEBFAJE);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000047")]
		public bool FMJFBMHJFOA
		{
			[Cpp2IlInjected.Token(Token = "0x6000125")]
			[Cpp2IlInjected.Address(RVA = "0x3EF9660", Offset = "0x3EF8A60", VA = "0x183EF9660", Slot = "16")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000048")]
		public bool MNPCELHFEEC
		{
			[Cpp2IlInjected.Token(Token = "0x6000126")]
			[Cpp2IlInjected.Address(RVA = "0x3EF96B0", Offset = "0x3EF8AB0", VA = "0x183EF96B0", Slot = "17")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000049")]
		public bool JBAKGHPBDFA
		{
			[Cpp2IlInjected.Token(Token = "0x6000127")]
			[Cpp2IlInjected.Address(RVA = "0x3EF9700", Offset = "0x3EF8B00", VA = "0x183EF9700", Slot = "18")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004A")]
		public int CDFNIFMFLKP
		{
			[Cpp2IlInjected.Token(Token = "0x6000128")]
			[Cpp2IlInjected.Address(RVA = "0x3EF9AB0", Offset = "0x3EF8EB0", VA = "0x183EF9AB0", Slot = "19")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004B")]
		public bool DBMPDDLEHON
		{
			[Cpp2IlInjected.Token(Token = "0x6000129")]
			[Cpp2IlInjected.Address(RVA = "0x3EF99D0", Offset = "0x3EF8DD0", VA = "0x183EF99D0", Slot = "20")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004C")]
		public bool FHEKIOHKPIO
		{
			[Cpp2IlInjected.Token(Token = "0x600012A")]
			[Cpp2IlInjected.Address(RVA = "0x3EF97A0", Offset = "0x3EF8BA0", VA = "0x183EF97A0", Slot = "21")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004D")]
		public bool EIJPLCMAMEK
		{
			[Cpp2IlInjected.Token(Token = "0x600012B")]
			[Cpp2IlInjected.Address(RVA = "0xBA3ED0", Offset = "0xBA32D0", VA = "0x180BA3ED0", Slot = "22")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600012C")]
			[Cpp2IlInjected.Address(RVA = "0xBAEA90", Offset = "0xBADE90", VA = "0x180BAEA90")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004E")]
		public virtual bool KGDMKDFPDEI
		{
			[Cpp2IlInjected.Token(Token = "0x600012D")]
			[Cpp2IlInjected.Address(RVA = "0x7E58B0", Offset = "0x7E4CB0", VA = "0x1807E58B0", Slot = "87")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004F")]
		public virtual bool OOJLOEKLLFO
		{
			[Cpp2IlInjected.Token(Token = "0x600012E")]
			[Cpp2IlInjected.Address(RVA = "0x3EF9750", Offset = "0x3EF8B50", VA = "0x183EF9750", Slot = "88")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000050")]
		public bool BOGEOJHEIBE
		{
			[Cpp2IlInjected.Token(Token = "0x600012F")]
			[Cpp2IlInjected.Address(RVA = "0x3EF9920", Offset = "0x3EF8D20", VA = "0x183EF9920", Slot = "25")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000051")]
		public GJDJJMDPPKC CMOOOBHDCMO
		{
			[Cpp2IlInjected.Token(Token = "0x6000130")]
			[Cpp2IlInjected.Address(RVA = "0x3EF9A10", Offset = "0x3EF8E10", VA = "0x183EF9A10", Slot = "26")]
			get
			{
				return default(GJDJJMDPPKC);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000052")]
		public FKIBNGAKAAJ KFNAMDFIKPK
		{
			[Cpp2IlInjected.Token(Token = "0x6000132")]
			[Cpp2IlInjected.Address(RVA = "0x3EF9A60", Offset = "0x3EF8E60", VA = "0x183EF9A60", Slot = "28")]
			get
			{
				return default(FKIBNGAKAAJ);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000053")]
		public virtual bool FJDNOGPEJCN
		{
			[Cpp2IlInjected.Token(Token = "0x6000150")]
			[Cpp2IlInjected.Address(RVA = "0x7E58B0", Offset = "0x7E4CB0", VA = "0x1807E58B0", Slot = "102")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000054")]
		public virtual PJMPOBCPFCC? FJODBLJGGDA
		{
			[Cpp2IlInjected.Token(Token = "0x6000151")]
			[Cpp2IlInjected.Address(RVA = "0x79E380", Offset = "0x79D780", VA = "0x18079E380", Slot = "103")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000055")]
		public virtual HAEIIAOAFCL? HENGNLPOJJG
		{
			[Cpp2IlInjected.Token(Token = "0x6000152")]
			[Cpp2IlInjected.Address(RVA = "0x79E380", Offset = "0x79D780", VA = "0x18079E380", Slot = "104")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000056")]
		public virtual IEnumerable<JGKGEKHGJKB<PNMLFKAJNIK>>? BBCCCKGLCDE
		{
			[Cpp2IlInjected.Token(Token = "0x6000153")]
			[Cpp2IlInjected.Address(RVA = "0x79E380", Offset = "0x79D780", VA = "0x18079E380", Slot = "105")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000057")]
		public bool EOILGIGIKCC
		{
			[Cpp2IlInjected.Token(Token = "0x6000158")]
			[Cpp2IlInjected.Address(RVA = "0x3EF97F0", Offset = "0x3EF8BF0", VA = "0x183EF97F0", Slot = "109")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000058")]
		public JGKGEKHGJKB<BIKLLPOLGEF> IIPFNMCCMGF
		{
			[Cpp2IlInjected.Token(Token = "0x6000159")]
			[Cpp2IlInjected.Address(RVA = "0x3EF98D0", Offset = "0x3EF8CD0", VA = "0x183EF98D0", Slot = "54")]
			get
			{
				return default(JGKGEKHGJKB<BIKLLPOLGEF>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000059")]
		public virtual bool HLPIPOKDALH
		{
			[Cpp2IlInjected.Token(Token = "0x600015A")]
			[Cpp2IlInjected.Address(RVA = "0x7E58B0", Offset = "0x7E4CB0", VA = "0x1807E58B0", Slot = "110")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005A")]
		public virtual JLGMECJOLDI<BIKLLPOLGEF>? IFELHIDPOGE
		{
			[Cpp2IlInjected.Token(Token = "0x600015B")]
			[Cpp2IlInjected.Address(RVA = "0x79E380", Offset = "0x79D780", VA = "0x18079E380", Slot = "111")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005B")]
		public virtual bool FFLOFPOGGHN
		{
			[Cpp2IlInjected.Token(Token = "0x600015C")]
			[Cpp2IlInjected.Address(RVA = "0x7E58B0", Offset = "0x7E4CB0", VA = "0x1807E58B0", Slot = "112")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005C")]
		public bool AIMOBMBMPIA
		{
			[Cpp2IlInjected.Token(Token = "0x600015D")]
			[Cpp2IlInjected.Address(RVA = "0x3EF9970", Offset = "0x3EF8D70", VA = "0x183EF9970", Slot = "59")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005D")]
		public string BJAHCKCNPKD
		{
			[Cpp2IlInjected.Token(Token = "0x600015E")]
			[Cpp2IlInjected.Address(RVA = "0x79F130", Offset = "0x79E530", VA = "0x18079F130", Slot = "61")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600015F")]
			[Cpp2IlInjected.Address(RVA = "0x79F1C0", Offset = "0x79E5C0", VA = "0x18079F1C0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005E")]
		public JGKGEKHGJKB<PNMLFKAJNIK> JPHLENIMIJH
		{
			[Cpp2IlInjected.Token(Token = "0x6000160")]
			[Cpp2IlInjected.Address(RVA = "0x3EF9AF0", Offset = "0x3EF8EF0", VA = "0x183EF9AF0", Slot = "60")]
			get
			{
				return default(JGKGEKHGJKB<PNMLFKAJNIK>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005F")]
		public JGKGEKHGJKB<PNMLFKAJNIK>? INJNJKBHJIC
		{
			[Cpp2IlInjected.Token(Token = "0x6000161")]
			[Cpp2IlInjected.Address(RVA = "0x3EF9B40", Offset = "0x3EF8F40", VA = "0x183EF9B40", Slot = "113")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000060")]
		public DFAMOHODBNL<EHGNFGGIBEB, EMOFHMMOPFO> NFDNOOJFNCI
		{
			[Cpp2IlInjected.Token(Token = "0x6000162")]
			[Cpp2IlInjected.Address(RVA = "0x3EF9C20", Offset = "0x3EF9020", VA = "0x183EF9C20", Slot = "62")]
			get
			{
				return default(DFAMOHODBNL<EHGNFGGIBEB, EMOFHMMOPFO>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000061")]
		public virtual JLGMECJOLDI<EHGNFGGIBEB>? PIKBKFBPJPI
		{
			[Cpp2IlInjected.Token(Token = "0x6000163")]
			[Cpp2IlInjected.Address(RVA = "0x79E380", Offset = "0x79D780", VA = "0x18079E380", Slot = "114")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action EOICCPCIGEE
		{
			[Cpp2IlInjected.Token(Token = "0x6000139")]
			[Cpp2IlInjected.Address(RVA = "0x3EF5980", Offset = "0x3EF4D80", VA = "0x183EF5980", Slot = "35")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600013A")]
			[Cpp2IlInjected.Address(RVA = "0x3EF90E0", Offset = "0x3EF84E0", VA = "0x183EF90E0", Slot = "36")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event NOABDFEDFIO ALGALAHDACJ
		{
			[Cpp2IlInjected.Token(Token = "0x600013C")]
			[Cpp2IlInjected.Address(RVA = "0x3EF8D30", Offset = "0x3EF8130", VA = "0x183EF8D30", Slot = "37")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600013D")]
			[Cpp2IlInjected.Address(RVA = "0x3EF6120", Offset = "0x3EF5520", VA = "0x183EF6120", Slot = "38")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		public event CAKONDCONNA GIKKJIGLELJ
		{
			[Cpp2IlInjected.Token(Token = "0x600013E")]
			[Cpp2IlInjected.Address(RVA = "0x3EF6FE0", Offset = "0x3EF63E0", VA = "0x183EF6FE0", Slot = "39")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600013F")]
			[Cpp2IlInjected.Address(RVA = "0x3EF61C0", Offset = "0x3EF55C0", VA = "0x183EF61C0", Slot = "40")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000004")]
		public event Action NAEBEFBEBCG
		{
			[Cpp2IlInjected.Token(Token = "0x6000140")]
			[Cpp2IlInjected.Address(RVA = "0x3EF73D0", Offset = "0x3EF67D0", VA = "0x183EF73D0", Slot = "41")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000141")]
			[Cpp2IlInjected.Address(RVA = "0x3EF7840", Offset = "0x3EF6C40", VA = "0x183EF7840", Slot = "42")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000005")]
		public event Action AMKKCFJADHK
		{
			[Cpp2IlInjected.Token(Token = "0x6000142")]
			[Cpp2IlInjected.Address(RVA = "0x3EF58E0", Offset = "0x3EF4CE0", VA = "0x183EF58E0", Slot = "43")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000143")]
			[Cpp2IlInjected.Address(RVA = "0x3EF6F40", Offset = "0x3EF6340", VA = "0x183EF6F40", Slot = "44")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000006")]
		public event Action<JLGMECJOLDI<EHGNFGGIBEB>, EMOFHMMOPFO> KFCDLLNLBFD
		{
			[Cpp2IlInjected.Token(Token = "0x6000164")]
			[Cpp2IlInjected.Address(RVA = "0x3EF80F0", Offset = "0x3EF74F0", VA = "0x183EF80F0", Slot = "64")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000165")]
			[Cpp2IlInjected.Address(RVA = "0x3EF82A0", Offset = "0x3EF76A0", VA = "0x183EF82A0", Slot = "65")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000007")]
		public event Action<JLGMECJOLDI<EHGNFGGIBEB>, EMOFHMMOPFO> HNNLOEFCHFP
		{
			[Cpp2IlInjected.Token(Token = "0x6000166")]
			[Cpp2IlInjected.Address(RVA = "0x3EF9210", Offset = "0x3EF8610", VA = "0x183EF9210", Slot = "68")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000167")]
			[Cpp2IlInjected.Address(RVA = "0x3EF72B0", Offset = "0x3EF66B0", VA = "0x183EF72B0", Slot = "69")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000008")]
		public event Action<JLGMECJOLDI<EHGNFGGIBEB>> KLMFJJHMOFB
		{
			[Cpp2IlInjected.Token(Token = "0x6000168")]
			[Cpp2IlInjected.Address(RVA = "0x3EF7150", Offset = "0x3EF6550", VA = "0x183EF7150", Slot = "66")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000169")]
			[Cpp2IlInjected.Address(RVA = "0x3EF7610", Offset = "0x3EF6A10", VA = "0x183EF7610", Slot = "67")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000009")]
		public event Action<JLGMECJOLDI<EHGNFGGIBEB>, JLGMECJOLDI<EHGNFGGIBEB>> BLLNGGJIFAE
		{
			[Cpp2IlInjected.Token(Token = "0x600016A")]
			[Cpp2IlInjected.Address(RVA = "0x3EF78A0", Offset = "0x3EF6CA0", VA = "0x183EF78A0", Slot = "70")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600016B")]
			[Cpp2IlInjected.Address(RVA = "0x3EF7780", Offset = "0x3EF6B80", VA = "0x183EF7780", Slot = "71")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000A")]
		public event Action<JLGMECJOLDI<EHGNFGGIBEB>, EMOFHMMOPFO> PHEDFFFDOGE
		{
			[Cpp2IlInjected.Token(Token = "0x600016C")]
			[Cpp2IlInjected.Address(RVA = "0x3EF7550", Offset = "0x3EF6950", VA = "0x183EF7550", Slot = "72")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600016D")]
			[Cpp2IlInjected.Address(RVA = "0x3EF8E70", Offset = "0x3EF8270", VA = "0x183EF8E70", Slot = "73")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x3EF9320", Offset = "0x3EF8720", VA = "0x183EF9320")]
		[AOICGJECGOP("Need to handle `Name` better.")]
		[AOICGJECGOP("Creating the port adapter needs to actually read the `canInteract` state rather than just passing in `true`.")]
		public OJDKNDJFNFM(EJHJLJPPHCN BALKEACFDJN, TNode JACJPEOECBN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x3EF84C0", Offset = "0x3EF78C0", VA = "0x183EF84C0", Slot = "78")]
		protected virtual void NGFHLNOOHDK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x3EF66D0", Offset = "0x3EF5AD0", VA = "0x183EF66D0", Slot = "79")]
		public virtual void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x3EF8F30", Offset = "0x3EF8330", VA = "0x183EF8F30", Slot = "81")]
		public virtual void OJNDMBEFBNB(int HOJFFFHJBLK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x3EF7370", Offset = "0x3EF6770", VA = "0x183EF7370")]
		public bool HLDAJJNGFAK([In] GJDJJMDPPKC FDFHGIHHGHO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x3EF8350", Offset = "0x3EF7750", VA = "0x183EF8350")]
		public bool MKMJMGLIEHC([In] FKIBNGAKAAJ FDFHGIHHGHO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x3EF7260", Offset = "0x3EF6660", VA = "0x183EF7260", Slot = "89")]
		public virtual void GPPOJGKKHEI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x3EF8BB0", Offset = "0x3EF7FB0", VA = "0x183EF8BB0", Slot = "31")]
		[AsyncStateMachine(typeof(OJDKNDJFNFM<>.ANLMKDHKMMJ))]
		public Task<KKHLNMGODKL<PJHBHBBODGG, MPIKAEBOCFI>> NGJADPLGLCB(GJDJJMDPPKC? HHCIOFKIDKC, FKIBNGAKAAJ? LBMMJMIDBPD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x79E370", Offset = "0x79D770", VA = "0x18079E370", Slot = "90")]
		public virtual void IBAAHCJONPM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x79E370", Offset = "0x79D770", VA = "0x18079E370", Slot = "91")]
		public virtual void NGJCCKGKGFH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x79E370", Offset = "0x79D770", VA = "0x18079E370", Slot = "92")]
		public virtual void HLLMLPFLLCL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x1470B00", Offset = "0x146FF00", VA = "0x181470B00")]
		protected void NMDGDBAJMCL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x1197720", Offset = "0x1196B20", VA = "0x181197720")]
		protected void GOGFMAINHLA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x1174CF0", Offset = "0x11740F0", VA = "0x181174CF0")]
		private void OGEPLIIHNDK([In] FKIBNGAKAAJ PGPLGEJKHLI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x3EF7480", Offset = "0x3EF6880", VA = "0x183EF7480", Slot = "93")]
		public virtual Task<KKHLNMGODKL<JLGMECJOLDI<EHGNFGGIBEB>, MPIKAEBOCFI>> IBIJJNOCACN(string OMHHPMIDNAN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x3EF7080", Offset = "0x3EF6480", VA = "0x183EF7080", Slot = "94")]
		public virtual Task<KKHLNMGODKL<PJHBHBBODGG, MPIKAEBOCFI>> FGDNNBPCBEC(JLGMECJOLDI<EHGNFGGIBEB> NDKHLPHIJIN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x3EF5890", Offset = "0x3EF4C90", VA = "0x183EF5890", Slot = "95")]
		public virtual void ACIPAJEEGDB(JLGMECJOLDI<EHGNFGGIBEB> OJANCMLFDOJ, JLGMECJOLDI<EHGNFGGIBEB> DAPOBFHGAGK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x3EF9180", Offset = "0x3EF8580", VA = "0x183EF9180", Slot = "96")]
		public virtual IEnumerable<PKBFCJOJFAD> PFCHNLEEGFF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x3EF5B40", Offset = "0x3EF4F40", VA = "0x183EF5B40", Slot = "97")]
		public KKHLNMGODKL<PJHBHBBODGG, MPIKAEBOCFI> CABDHOJJGIP(string PEICKGKGHAI)
		{
			return default(KKHLNMGODKL<PJHBHBBODGG, MPIKAEBOCFI>);
		}

		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x3EF7960", Offset = "0x3EF6D60", VA = "0x183EF7960", Slot = "45")]
		public bool JJMNPGOKCLH([Out] Guid DPMIIHFEEBA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x3EF7210", Offset = "0x3EF6610", VA = "0x183EF7210", Slot = "98")]
		public virtual bool GMOKNPMHOEJ([In] Guid KGGOGFBCEKB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x3EF7EB0", Offset = "0x3EF72B0", VA = "0x183EF7EB0", Slot = "99")]
		public virtual void KECAPFPCLAM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x79E370", Offset = "0x79D770", VA = "0x18079E370", Slot = "100")]
		public virtual void KKOJCHGOBJA(bool LIODGNOHHGC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x79E380", Offset = "0x79D780", VA = "0x18079E380", Slot = "101")]
		public virtual KILNJOKLPOP DGPJGAFCMFL([In] CALJGLBNEDG BICEODDIDAG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x3EF81A0", Offset = "0x3EF75A0", VA = "0x183EF81A0")]
		protected void MGMIOBGIPLH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x79E370", Offset = "0x79D770", VA = "0x18079E370", Slot = "106")]
		protected virtual void ILCFDPGELKK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x3EF8D00", Offset = "0x3EF8100", VA = "0x183EF8D00", Slot = "107")]
		protected virtual bool NKCEPDJCADI(JLGMECJOLDI<EHGNFGGIBEB> NDKHLPHIJIN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x7E58B0", Offset = "0x7E4CB0", VA = "0x1807E58B0", Slot = "108")]
		protected virtual bool PJFIHEFLFDO(JLGMECJOLDI<EHGNFGGIBEB> NDKHLPHIJIN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x79E370", Offset = "0x79D770", VA = "0x18079E370", Slot = "115")]
		protected virtual void OGMBKICALAL(GJCFPBDLHGK JHNIJCIGGOP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x79E370", Offset = "0x79D770", VA = "0x18079E370", Slot = "116")]
		protected virtual void AMOHDKNEFCM(GJCFPBDLHGK GCOOKAGLIEG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x3EF7AB0", Offset = "0x3EF6EB0", VA = "0x183EF7AB0", Slot = "74")]
		public void JPABEFCEDBH(GJCFPBDLHGK GCOOKAGLIEG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x3EF83B0", Offset = "0x3EF77B0", VA = "0x183EF83B0", Slot = "75")]
		public KIAFDOMBGOF MONCNJAMLHD()
		{
			return default(KIAFDOMBGOF);
		}

		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x7E58B0", Offset = "0x7E4CB0", VA = "0x1807E58B0", Slot = "117")]
		public virtual bool FAOJBIOIACL(JLGMECJOLDI<EHGNFGGIBEB> NDKHLPHIJIN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x3EF8F80", Offset = "0x3EF8380", VA = "0x183EF8F80")]
		private void PADIGDFDFMH([In] GJDJJMDPPKC HGKJDOIPDNM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x3EF7F70", Offset = "0x3EF7370", VA = "0x183EF7F70")]
		private void LKNFMCCHMEJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x3EF5BC0", Offset = "0x3EF4FC0", VA = "0x183EF5BC0")]
		private void CHGFPLOHHCK(int HMIKABPPNGL, AHNMMIBEPOP DDBONMICPOE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x3EF92D0", Offset = "0x3EF86D0", VA = "0x183EF92D0")]
		private void PNFKHFCLLKJ(int OJANCMLFDOJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x3EF8FA0", Offset = "0x3EF83A0", VA = "0x183EF8FA0")]
		private void PBEKNLGHNKF(int OJANCMLFDOJ, AHNMMIBEPOP DIEGEFNANKJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x3EF7B00", Offset = "0x3EF6F00", VA = "0x183EF7B00")]
		private void KBDHKHDEEDE(int NPHKOFFKJMB, int CPLMOFDCCAP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x3EF76D0", Offset = "0x3EF6AD0", VA = "0x183EF76D0")]
		private void IGNGNJLEGNJ(int NPHKOFFKJMB, int CPLMOFDCCAP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x3EF7730", Offset = "0x3EF6B30", VA = "0x183EF7730")]
		private void IJBNFFBCKDM(int OJANCMLFDOJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x3EF6260", Offset = "0x3EF5660", VA = "0x183EF6260")]
		private void DDMAJCBPCDO(int HMIKABPPNGL, AHNMMIBEPOP DDBONMICPOE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x3EF8070", Offset = "0x3EF7470", VA = "0x183EF8070")]
		private void MBKEABJABNG(int OJANCMLFDOJ, AHNMMIBEPOP DIEGEFNANKJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x3EF5A20", Offset = "0x3EF4E20", VA = "0x183EF5A20", Slot = "118")]
		[AsyncStateMachine(typeof(OJDKNDJFNFM<>.GGIDJIOFDCF))]
		public virtual Task<KKHLNMGODKL<PJHBHBBODGG, MPIKAEBOCFI>> BBEOJGOMDOI(string PEICKGKGHAI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x3EF7F00", Offset = "0x3EF7300", VA = "0x183EF7F00", Slot = "52")]
		private void LIHFFPNJJJC(object GBKOLHALMHO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x3EF8E00", Offset = "0x3EF8200", VA = "0x183EF8E00", Slot = "53")]
		private void OBDMIONHPPP(object GBKOLHALMHO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x3EF8DD0", Offset = "0x3EF81D0", VA = "0x183EF8DD0", Slot = "27")]
		private bool NOJFPLKJHEG([In] GJDJJMDPPKC FDFHGIHHGHO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x3EF8490", Offset = "0x3EF7890", VA = "0x183EF8490", Slot = "29")]
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
			[Cpp2IlInjected.Address(RVA = "0xAA0C80", Offset = "0xAA0080", VA = "0x180AA0C80", Slot = "83")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x1D392C0", Offset = "0x1D386C0", VA = "0x181D392C0")]
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
			[Cpp2IlInjected.Address(RVA = "0x7E8CB0", Offset = "0x7E80B0", VA = "0x1807E8CB0", Slot = "83")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x1D3E5C0", Offset = "0x1D3D9C0", VA = "0x181D3E5C0")]
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
			[Cpp2IlInjected.Address(RVA = "0x852C30", Offset = "0x852030", VA = "0x180852C30", Slot = "83")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x1D39320", Offset = "0x1D38720", VA = "0x181D39320")]
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
			[Cpp2IlInjected.Address(RVA = "0x7E8CB0", Offset = "0x7E80B0", VA = "0x1807E8CB0", Slot = "83")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x1D35820", Offset = "0x1D34C20", VA = "0x181D35820")]
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
			[Cpp2IlInjected.Address(RVA = "0x7E8CB0", Offset = "0x7E80B0", VA = "0x1807E8CB0", Slot = "83")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x1D386A0", Offset = "0x1D37AA0", VA = "0x181D386A0")]
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
			[Cpp2IlInjected.Address(RVA = "0x917C40", Offset = "0x917040", VA = "0x180917C40", Slot = "83")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x1D2C5C0", Offset = "0x1D2B9C0", VA = "0x181D2C5C0")]
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
			[Cpp2IlInjected.Address(RVA = "0x79E380", Offset = "0x79D780", VA = "0x18079E380", Slot = "83")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000069")]
		protected override bool GGEOMGDLFKD
		{
			[Cpp2IlInjected.Token(Token = "0x6000195")]
			[Cpp2IlInjected.Address(RVA = "0x7B8240", Offset = "0x7B7640", VA = "0x1807B8240", Slot = "82")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x1D35230", Offset = "0x1D34630", VA = "0x181D35230")]
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
			[Cpp2IlInjected.Address(RVA = "0x884CE0", Offset = "0x8840E0", VA = "0x180884CE0", Slot = "83")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x1D3B080", Offset = "0x1D3A480", VA = "0x181D3B080")]
		public KDNLPJJFLEG(EJHJLJPPHCN BALKEACFDJN, NPMIMCMCHEP JACJPEOECBN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x1D3EDD0", Offset = "0x1D3E1D0", VA = "0x181D3EDD0")]
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
		[Cpp2IlInjected.Address(RVA = "0xD073E0", Offset = "0xD067E0", VA = "0x180D073E0", Slot = "23")]
		[CompilerGenerated]
		get
		{
			return default(JLGMECJOLDI<NIIHBFDIOKM>);
		}
		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0xD065C0", Offset = "0xD059C0", VA = "0x180D065C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006C")]
	public override JLGMECJOLDI<FKIAAIPKAOJ> HGIHJLEFAOP
	{
		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x1D3CEF0", Offset = "0x1D3C2F0", VA = "0x181D3CEF0", Slot = "19")]
		get
		{
			return default(JLGMECJOLDI<FKIAAIPKAOJ>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(RVA = "0x1D3D250", Offset = "0x1D3C650", VA = "0x181D3D250")]
	private LJGDDJCHKDC(EJHJLJPPHCN BALKEACFDJN, DLLEFNELPBJ JACJPEOECBN, MIMLJFBOMCO KAJFPKMAFLJ, JLGMECJOLDI<EHGNFGGIBEB> NDKHLPHIJIN, JLGMECJOLDI<NIIHBFDIOKM> FLOGJHFICGN, bool OBPFIAGBNAK, string OMHHPMIDNAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0x1D3CF30", Offset = "0x1D3C330", VA = "0x181D3CF30")]
	public static LJGDDJCHKDC JKJFENIAMEL(EJHJLJPPHCN BALKEACFDJN, DLLEFNELPBJ JACJPEOECBN, MIMLJFBOMCO JJLMPGHEIDC, JLGMECJOLDI<EHGNFGGIBEB> NDKHLPHIJIN, JLGMECJOLDI<KFBDPPFJJPB> KKDLHAPIIII, JLGMECJOLDI<NIIHBFDIOKM> FLOGJHFICGN, bool OBPFIAGBNAK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(RVA = "0xD065C0", Offset = "0xD059C0", VA = "0x180D065C0")]
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
		[Cpp2IlInjected.Token(Token = "0x40000F8")]
		private MDAFEHJGBEE? AAPIAOJEHDB;

		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x1D35810", Offset = "0x1D34C10", VA = "0x181D35810")]
		public void NJLBNDAIMDB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x1D35770", Offset = "0x1D34B70", VA = "0x181D35770")]
		public MDAFEHJGBEE KNLIKPNPJOO(FFGBDPICEGI MLJFICGOGLJ)
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	protected readonly EJHJLJPPHCN CAPMIPILDGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	protected readonly DLLEFNELPBJ MPFJAIOGBBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	private HBCJLKCCPOD AMDANFLFGJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	private readonly AHBHEMABBDB CLFPCNLCEBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	private readonly List<HBPELELLOPD> AFPKBJMJDDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	private readonly List<CLPEBMKMKBN> FFAEJPOAAEH;

	[Cpp2IlInjected.Token(Token = "0x1700006D")]
	public IEnumerable<StaticEdge> NDCOMLFMJOB
	{
		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x1D33700", Offset = "0x1D32B00", VA = "0x181D33700", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006E")]
	public DisplayKind GGNLJELAGKI
	{
		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x7AD1C0", Offset = "0x7AC5C0", VA = "0x1807AD1C0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x1D33F30", Offset = "0x1D33330", VA = "0x181D33F30", Slot = "6")]
		get
		{
			return default(JGKGEKHGJKB<BIKLLPOLGEF>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000070")]
	public FFGBDNDMLII NOKBLKOHDHH
	{
		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x18C8270", Offset = "0x18C7670", VA = "0x1818C8270")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000071")]
	public JMOOPHLIAJE HICAOJAALEP
	{
		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0x1D33D40", Offset = "0x1D33140", VA = "0x181D33D40", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000072")]
	protected MDAFEHJGBEE CKPKCPOEFGL
	{
		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0x1D33D40", Offset = "0x1D33140", VA = "0x181D33D40")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000073")]
	public PortImage EBIDCBCELNF
	{
		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0x1D33C10", Offset = "0x1D33010", VA = "0x181D33C10", Slot = "12")]
		get
		{
			return default(PortImage);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000074")]
	public string BJAHCKCNPKD
	{
		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x79F220", Offset = "0x79E620", VA = "0x18079F220", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x79F240", Offset = "0x79E640", VA = "0x18079F240")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000075")]
	public JGKGEKHGJKB<PNMLFKAJNIK> JPHLENIMIJH
	{
		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x1D33BF0", Offset = "0x1D32FF0", VA = "0x181D33BF0", Slot = "8")]
		get
		{
			return default(JGKGEKHGJKB<PNMLFKAJNIK>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000076")]
	public JLGMECJOLDI<EHGNFGGIBEB> CGGGCAKEBIP
	{
		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x8709F0", Offset = "0x86FDF0", VA = "0x1808709F0", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return default(JLGMECJOLDI<EHGNFGGIBEB>);
		}
		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x1766FD0", Offset = "0x17663D0", VA = "0x181766FD0")]
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
	[Cpp2IlInjected.Address(RVA = "0x1D33FC0", Offset = "0x1D333C0", VA = "0x181D33FC0")]
	protected FFGBDPICEGI(EJHJLJPPHCN BALKEACFDJN, DLLEFNELPBJ JACJPEOECBN, AHBHEMABBDB MLNIMFJMHMP, JLGMECJOLDI<EHGNFGGIBEB> NDKHLPHIJIN, bool OBPFIAGBNAK, string OMHHPMIDNAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AD")]
	[Cpp2IlInjected.Address(RVA = "0x1D33DE0", Offset = "0x1D331E0", VA = "0x181D33DE0", Slot = "20")]
	protected virtual void NGFHLNOOHDK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AE")]
	[Cpp2IlInjected.Address(RVA = "0x1D33020", Offset = "0x1D32420", VA = "0x181D33020", Slot = "21")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AF")]
	[Cpp2IlInjected.Address(RVA = "0x1D32D30", Offset = "0x1D32130", VA = "0x181D32D30", Slot = "13")]
	public void BEOMHADBKBC(HBPELELLOPD AHCFJOOAJDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B0")]
	[Cpp2IlInjected.Address(RVA = "0x1D33F60", Offset = "0x1D33360", VA = "0x181D33F60", Slot = "14")]
	public void PBILCFLLJKP(CLPEBMKMKBN AHCFJOOAJDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B1")]
	[Cpp2IlInjected.Address(RVA = "0x1D33170", Offset = "0x1D32570", VA = "0x181D33170", Slot = "15")]
	public void ECDPDHKEDEL(HMJEIHCLKCA EAEGBKJOMLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B2")]
	[Cpp2IlInjected.Address(RVA = "0x1D33A00", Offset = "0x1D32E00", VA = "0x181D33A00", Slot = "22")]
	protected virtual void HAMKPEPNOEK(HMJEIHCLKCA EAEGBKJOMLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B3")]
	[Cpp2IlInjected.Address(RVA = "0x1D33A60", Offset = "0x1D32E60", VA = "0x181D33A60")]
	private void HEJOJAPCGCL(bool JHEMNDMHNOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B4")]
	[Cpp2IlInjected.Address(RVA = "0x1D32DF0", Offset = "0x1D321F0", VA = "0x181D32DF0")]
	private void BOCJJOLONDL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B5")]
	[Cpp2IlInjected.Address(RVA = "0x1D33850", Offset = "0x1D32C50", VA = "0x181D33850")]
	private void FMGCBIBPBID([In] EALLJECGGFN JADABKAPDDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(RVA = "0x1D32D90", Offset = "0x1D32190", VA = "0x181D32D90", Slot = "16")]
	public void BMJCAONCKMN(HBPELELLOPD AHCFJOOAJDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B7")]
	[Cpp2IlInjected.Address(RVA = "0x1D32FC0", Offset = "0x1D323C0", VA = "0x181D32FC0", Slot = "17")]
	public void DLKLFOJOJOH(CLPEBMKMKBN AHCFJOOAJDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(RVA = "0x79F240", Offset = "0x79E640", VA = "0x18079F240")]
	internal void NGHBEHLFFDA(string OMHHPMIDNAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B9")]
	[Cpp2IlInjected.Address(RVA = "0x1D32FA0", Offset = "0x1D323A0", VA = "0x181D32FA0")]
	internal void DEPPJACMFPB(DPEJEGBGJGD NFFMMJBNJIB, FFGBDNDMLII ADAMDPHPFAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BA")]
	[Cpp2IlInjected.Address(RVA = "0x1766FD0", Offset = "0x17663D0", VA = "0x181766FD0")]
	internal void NLFANOEJJPI(JLGMECJOLDI<EHGNFGGIBEB> NDKHLPHIJIN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public sealed class ABKJNJFGHFI : EMOFHMMOPFO, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200005B")]
	[CompilerGenerated]
	private sealed class NPDOOJPCCBO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000116")]
		public EJHJLJPPHCN circuitsManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000117")]
		public DLLEFNELPBJ node;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000118")]
		public JLGMECJOLDI<EHGNFGGIBEB> portGroupId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000119")]
		public bool canInteract;

		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(RVA = "0x7A4800", Offset = "0x7A3C00", VA = "0x1807A4800")]
		public NPDOOJPCCBO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(RVA = "0x1D3E6A0", Offset = "0x1D3DAA0", VA = "0x181D3E6A0")]
		internal DLKAMECFEEF FCLBCCELNKJ((int PortDescIndex, int PortIndex, BFMMFHJHKDA InputPort) i)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(RVA = "0x1D3E620", Offset = "0x1D3DA20", VA = "0x181D3E620")]
		internal LJGDDJCHKDC AELBGJCHLPC(MIMLJFBOMCO i, int idx)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200005C")]
	[CompilerGenerated]
	private struct KEJHCFKBBEM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400011A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400011B")]
		public AsyncTaskMethodBuilder<KKHLNMGODKL<PJHBHBBODGG, MPIKAEBOCFI>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400011C")]
		public ABKJNJFGHFI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400011D")]
		private CFPCGPKJOEC <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400011E")]
		private TaskAwaiter<KKHLNMGODKL<PJHBHBBODGG, MPIKAEBOCFI>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0x1D3B140", Offset = "0x1D3A540", VA = "0x181D3B140", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000207")]
		[Cpp2IlInjected.Address(RVA = "0x1D3B5A0", Offset = "0x1D3A9A0", VA = "0x181D3B5A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200005E")]
	[CompilerGenerated]
	private struct ACCNKBMJPCG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		public AsyncTaskMethodBuilder<KKHLNMGODKL<PJHBHBBODGG, MPIKAEBOCFI>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000123")]
		public ABKJNJFGHFI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000124")]
		public JLGMECJOLDI<NJIGMIHFIFI> inputDefId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000125")]
		private CFPCGPKJOEC <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000126")]
		private TaskAwaiter<KKHLNMGODKL<PJHBHBBODGG, MPIKAEBOCFI>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600020B")]
		[Cpp2IlInjected.Address(RVA = "0x1D29740", Offset = "0x1D28B40", VA = "0x181D29740", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0x1D29A90", Offset = "0x1D28E90", VA = "0x181D29A90", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200005F")]
	[CompilerGenerated]
	private struct GGCEAKIFEDC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000127")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000128")]
		public AsyncTaskMethodBuilder<KKHLNMGODKL<PJHBHBBODGG, MPIKAEBOCFI>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000129")]
		public ABKJNJFGHFI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400012A")]
		public JLGMECJOLDI<KFBDPPFJJPB> outputDefId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400012B")]
		private CFPCGPKJOEC <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400012C")]
		private TaskAwaiter<KKHLNMGODKL<PJHBHBBODGG, MPIKAEBOCFI>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(RVA = "0x1D34E70", Offset = "0x1D34270", VA = "0x181D34E70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0x1D351C0", Offset = "0x1D345C0", VA = "0x181D351C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000060")]
	[CompilerGenerated]
	private struct IDNIHOLOBNE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400012D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400012E")]
		public AsyncTaskMethodBuilder<KKHLNMGODKL<PJHBHBBODGG, MPIKAEBOCFI>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400012F")]
		public ABKJNJFGHFI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000130")]
		public JLGMECJOLDI<NJIGMIHFIFI> inputDefId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000131")]
		public JLGMECJOLDI<NJIGMIHFIFI> targetIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000132")]
		private CFPCGPKJOEC <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		private TaskAwaiter<KKHLNMGODKL<PJHBHBBODGG, MPIKAEBOCFI>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0x1D38860", Offset = "0x1D37C60", VA = "0x181D38860", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(RVA = "0x1D38BB0", Offset = "0x1D37FB0", VA = "0x181D38BB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000061")]
	[CompilerGenerated]
	private struct KHILCBIOODA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		public AsyncTaskMethodBuilder<KKHLNMGODKL<PJHBHBBODGG, MPIKAEBOCFI>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000136")]
		public ABKJNJFGHFI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000137")]
		public JLGMECJOLDI<KFBDPPFJJPB> outputDefId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000138")]
		public JLGMECJOLDI<KFBDPPFJJPB> targetIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000139")]
		private CFPCGPKJOEC <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400013A")]
		private TaskAwaiter<KKHLNMGODKL<PJHBHBBODGG, MPIKAEBOCFI>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(RVA = "0x1D3BEA0", Offset = "0x1D3B2A0", VA = "0x181D3BEA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(RVA = "0x1D3C1F0", Offset = "0x1D3B5F0", VA = "0x181D3C1F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000062")]
	[CompilerGenerated]
	private struct DMOJEPDPEPB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400013B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400013C")]
		public AsyncTaskMethodBuilder<KKHLNMGODKL<PJHBHBBODGG, MPIKAEBOCFI>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400013D")]
		public ABKJNJFGHFI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400013E")]
		private CFPCGPKJOEC <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400013F")]
		private TaskAwaiter<KKHLNMGODKL<PJHBHBBODGG, MPIKAEBOCFI>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000213")]
		[Cpp2IlInjected.Address(RVA = "0x1D2FEF0", Offset = "0x1D2F2F0", VA = "0x181D2FEF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000214")]
		[Cpp2IlInjected.Address(RVA = "0x1D30360", Offset = "0x1D2F760", VA = "0x181D30360", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000063")]
	[CompilerGenerated]
	private struct OEBFBFHCECN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000140")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000141")]
		public AsyncTaskMethodBuilder<KKHLNMGODKL<PJHBHBBODGG, MPIKAEBOCFI>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000142")]
		public ABKJNJFGHFI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000143")]
		public string newName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000144")]
		private CFPCGPKJOEC <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000145")]
		private TaskAwaiter<KKHLNMGODKL<PJHBHBBODGG, MPIKAEBOCFI>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000215")]
		[Cpp2IlInjected.Address(RVA = "0x1D3EA10", Offset = "0x1D3DE10", VA = "0x181D3EA10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000216")]
		[Cpp2IlInjected.Address(RVA = "0x1D3ED60", Offset = "0x1D3E160", VA = "0x181D3ED60", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000064")]
	[CompilerGenerated]
	private struct JKGCMGHCKKC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000146")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000147")]
		public AsyncTaskMethodBuilder<KKHLNMGODKL<PJHBHBBODGG, MPIKAEBOCFI>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000148")]
		public ABKJNJFGHFI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000149")]
		public JLGMECJOLDI<NJIGMIHFIFI> inputDefId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400014A")]
		public string name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400014B")]
		private CFPCGPKJOEC <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400014C")]
		private TaskAwaiter<KKHLNMGODKL<PJHBHBBODGG, MPIKAEBOCFI>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000217")]
		[Cpp2IlInjected.Address(RVA = "0x1D3A9B0", Offset = "0x1D39DB0", VA = "0x181D3A9B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000218")]
		[Cpp2IlInjected.Address(RVA = "0x1D3AD00", Offset = "0x1D3A100", VA = "0x181D3AD00", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000065")]
	[CompilerGenerated]
	private struct DEGEALDNEKO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400014D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400014E")]
		public AsyncTaskMethodBuilder<KKHLNMGODKL<PJHBHBBODGG, MPIKAEBOCFI>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400014F")]
		public ABKJNJFGHFI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000150")]
		public JLGMECJOLDI<KFBDPPFJJPB> outputDefId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000151")]
		public string name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000152")]
		private CFPCGPKJOEC <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000153")]
		private TaskAwaiter<KKHLNMGODKL<PJHBHBBODGG, MPIKAEBOCFI>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000219")]
		[Cpp2IlInjected.Address(RVA = "0x1D2BF70", Offset = "0x1D2B370", VA = "0x181D2BF70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(RVA = "0x1D2C2C0", Offset = "0x1D2B6C0", VA = "0x181D2C2C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000066")]
	[CompilerGenerated]
	private struct DBCIHAMABIA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000154")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000155")]
		public AsyncTaskMethodBuilder<KKHLNMGODKL<PJHBHBBODGG, MPIKAEBOCFI>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000156")]
		public ABKJNJFGHFI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000157")]
		public NKJCMKKBOGB type;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000158")]
		public JLGMECJOLDI<NJIGMIHFIFI> inputDefId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000159")]
		private CFPCGPKJOEC <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400015A")]
		private TaskAwaiter<KKHLNMGODKL<PJHBHBBODGG, MPIKAEBOCFI>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600021B")]
		[Cpp2IlInjected.Address(RVA = "0x1D2B540", Offset = "0x1D2A940", VA = "0x181D2B540", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021C")]
		[Cpp2IlInjected.Address(RVA = "0x1D2B8D0", Offset = "0x1D2ACD0", VA = "0x181D2B8D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000067")]
	[CompilerGenerated]
	private struct IBIFFKBNFDN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400015B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400015C")]
		public AsyncTaskMethodBuilder<KKHLNMGODKL<PJHBHBBODGG, MPIKAEBOCFI>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400015D")]
		public ABKJNJFGHFI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400015E")]
		public NKJCMKKBOGB type;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400015F")]
		public JLGMECJOLDI<KFBDPPFJJPB> outputDefId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000160")]
		private CFPCGPKJOEC <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000161")]
		private TaskAwaiter<KKHLNMGODKL<PJHBHBBODGG, MPIKAEBOCFI>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600021D")]
		[Cpp2IlInjected.Address(RVA = "0x1D382A0", Offset = "0x1D376A0", VA = "0x181D382A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021E")]
		[Cpp2IlInjected.Address(RVA = "0x1D38630", Offset = "0x1D37A30", VA = "0x181D38630", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	private readonly bool CMOOOKJJEEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	private readonly EJHJLJPPHCN CAPMIPILDGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	private readonly bool FBJKJDELMHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	private DFAMOHODBNL<ALOBLIADAMK, DLKAMECFEEF> LJGHFABDIPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	private DFAMOHODBNL<ALOBLIADAMK, GHLMOHBOPLK> EFACFLOGLMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	private readonly DLLEFNELPBJ MPFJAIOGBBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	private DFAMOHODBNL<NIIHBFDIOKM, LJGDDJCHKDC> JLABDEACJAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	private DFAMOHODBNL<NIIHBFDIOKM, INIGIGGLLDP> AAOHMCFBDII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	private string? GBKGIJJLONA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	private readonly AHNMMIBEPOP OKOLODFOFOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	private JLGMECJOLDI<EHGNFGGIBEB> BOMPOGNEMDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	[CompilerGenerated]
	private Action? FGBABIALFPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	[CompilerGenerated]
	private Action? EBAEOAHOCNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	[CompilerGenerated]
	private Action? INMOJHBDDFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	[CompilerGenerated]
	private Action<JLGMECJOLDI<ALOBLIADAMK>>? GOLJKNDPLLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	[CompilerGenerated]
	private Action<JLGMECJOLDI<NIIHBFDIOKM>>? ANEGBCNJKLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	[CompilerGenerated]
	private EMOFHMMOPFO.NFLNIJILDMN? CIKIFHCICLG;

	[Cpp2IlInjected.Token(Token = "0x17000078")]
	public bool DOHDMHACIJG
	{
		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x1D23B40", Offset = "0x1D22F40", VA = "0x181D23B40", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000079")]
	public bool JHMAFJDOLGD
	{
		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x1D254E0", Offset = "0x1D248E0", VA = "0x181D254E0", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007A")]
	public bool CLLLGBILEJF
	{
		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x1D27C00", Offset = "0x1D27000", VA = "0x181D27C00", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007B")]
	public JGKGEKHGJKB<BIKLLPOLGEF> IIPFNMCCMGF
	{
		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x1D290F0", Offset = "0x1D284F0", VA = "0x181D290F0", Slot = "7")]
		get
		{
			return default(JGKGEKHGJKB<BIKLLPOLGEF>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007C")]
	public bool BHCJBOKBHOL
	{
		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x1D26A50", Offset = "0x1D25E50", VA = "0x181D26A50", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007D")]
	public DFAMOHODBNL<ALOBLIADAMK, GHLMOHBOPLK> NNIPPIPAOAO
	{
		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x79F100", Offset = "0x79E500", VA = "0x18079F100", Slot = "9")]
		get
		{
			return default(DFAMOHODBNL<ALOBLIADAMK, GHLMOHBOPLK>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007E")]
	public string BJAHCKCNPKD
	{
		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x1D27E40", Offset = "0x1D27240", VA = "0x181D27E40", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007F")]
	public JGKGEKHGJKB<PNMLFKAJNIK> JPHLENIMIJH
	{
		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x1D27020", Offset = "0x1D26420", VA = "0x181D27020", Slot = "11")]
		get
		{
			return default(JGKGEKHGJKB<PNMLFKAJNIK>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000080")]
	public DFAMOHODBNL<NIIHBFDIOKM, INIGIGGLLDP> HFNDEPPAKNC
	{
		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x79F220", Offset = "0x79E620", VA = "0x18079F220", Slot = "12")]
		get
		{
			return default(DFAMOHODBNL<NIIHBFDIOKM, INIGIGGLLDP>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000081")]
	public JLGMECJOLDI<EHGNFGGIBEB> CGGGCAKEBIP
	{
		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x9A7A20", Offset = "0x9A6E20", VA = "0x1809A7A20", Slot = "13")]
		get
		{
			return default(JLGMECJOLDI<EHGNFGGIBEB>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000B")]
	public event Action? KKHOENEKGDJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x1D27E70", Offset = "0x1D27270", VA = "0x181D27E70", Slot = "14")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0x1D244C0", Offset = "0x1D238C0", VA = "0x181D244C0", Slot = "15")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	public event Action? CAKKNKOPLMI
	{
		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x1D27090", Offset = "0x1D26490", VA = "0x181D27090", Slot = "16")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0x1D265E0", Offset = "0x1D259E0", VA = "0x181D265E0", Slot = "17")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	public event Action<JLGMECJOLDI<ALOBLIADAMK?>, JLGMECJOLDI<ALOBLIADAMK?>>? ICPBMJFJEHL
	{
		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x1D27D80", Offset = "0x1D27180", VA = "0x181D27D80", Slot = "18")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x1D23A80", Offset = "0x1D22E80", VA = "0x181D23A80", Slot = "19")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000E")]
	public event Action<JLGMECJOLDI<NIIHBFDIOKM?>, JLGMECJOLDI<NIIHBFDIOKM?>>? IHPFCNBGHBJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0x1D27FD0", Offset = "0x1D273D0", VA = "0x181D27FD0", Slot = "20")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0x1D28E40", Offset = "0x1D28240", VA = "0x181D28E40", Slot = "21")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000F")]
	public event Action<JLGMECJOLDI<ALOBLIADAMK?>, GHLMOHBOPLK?>? PKHOMMGFKLL
	{
		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0x1D24400", Offset = "0x1D23800", VA = "0x181D24400", Slot = "22")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0x1D27CC0", Offset = "0x1D270C0", VA = "0x181D27CC0", Slot = "23")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000010")]
	public event Action<JLGMECJOLDI<ALOBLIADAMK?>>? HGADOELKHNP
	{
		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0x1D25DD0", Offset = "0x1D251D0", VA = "0x181D25DD0", Slot = "24")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x1D27B40", Offset = "0x1D26F40", VA = "0x181D27B40", Slot = "25")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000011")]
	public event Action<JLGMECJOLDI<ALOBLIADAMK?>, GHLMOHBOPLK?>? GONHKNBMKFO
	{
		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x1D25D10", Offset = "0x1D25110", VA = "0x181D25D10", Slot = "26")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0x1D26110", Offset = "0x1D25510", VA = "0x181D26110", Slot = "27")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000012")]
	public event Action<JLGMECJOLDI<NIIHBFDIOKM?>, INIGIGGLLDP?>? CAIOPPIGHPL
	{
		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0x1D23C00", Offset = "0x1D23000", VA = "0x181D23C00", Slot = "28")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(RVA = "0x1D24340", Offset = "0x1D23740", VA = "0x181D24340", Slot = "29")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000013")]
	public event Action<JLGMECJOLDI<NIIHBFDIOKM?>>? NGJKDNFPLOC
	{
		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(RVA = "0x1D23CC0", Offset = "0x1D230C0", VA = "0x181D23CC0", Slot = "30")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0x1D27F10", Offset = "0x1D27310", VA = "0x181D27F10", Slot = "31")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000014")]
	public event Action<JLGMECJOLDI<NIIHBFDIOKM?>, INIGIGGLLDP?>? PALBPCBNAHG
	{
		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x1D28F00", Offset = "0x1D28300", VA = "0x181D28F00", Slot = "32")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0x1D26410", Offset = "0x1D25810", VA = "0x181D26410", Slot = "33")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(RVA = "0x1D29650", Offset = "0x1D28A50", VA = "0x181D29650")]
	private ABKJNJFGHFI(bool OBPFIAGBNAK, EJHJLJPPHCN BALKEACFDJN, bool IGAMGJACJEK, DFAMOHODBNL<ALOBLIADAMK, DLKAMECFEEF> DEIKIDPPMCI, DFAMOHODBNL<ALOBLIADAMK, GHLMOHBOPLK> DCJHMAHIKGL, DLLEFNELPBJ JACJPEOECBN, DFAMOHODBNL<NIIHBFDIOKM, LJGDDJCHKDC> FFNCDJBPKGH, DFAMOHODBNL<NIIHBFDIOKM, INIGIGGLLDP> BBFABFEAFNF, string? CIBAIEJPDLH, AHNMMIBEPOP DDBONMICPOE, JLGMECJOLDI<EHGNFGGIBEB> NDKHLPHIJIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(RVA = "0x1D26AD0", Offset = "0x1D25ED0", VA = "0x181D26AD0")]
	public static ABKJNJFGHFI JKJFENIAMEL(bool OBPFIAGBNAK, EJHJLJPPHCN BALKEACFDJN, bool IGAMGJACJEK, DLLEFNELPBJ JACJPEOECBN, AHNMMIBEPOP DDBONMICPOE, JLGMECJOLDI<EHGNFGGIBEB> NDKHLPHIJIN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E0")]
	[Cpp2IlInjected.Address(RVA = "0x1D28090", Offset = "0x1D27490", VA = "0x181D28090")]
	private void NGFHLNOOHDK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E1")]
	[Cpp2IlInjected.Address(RVA = "0x1D24560", Offset = "0x1D23960", VA = "0x181D24560", Slot = "45")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E2")]
	[Cpp2IlInjected.Address(RVA = "0x1D26810", Offset = "0x1D25C10", VA = "0x181D26810", Slot = "34")]
	[AsyncStateMachine(typeof(KEJHCFKBBEM))]
	public Task<KKHLNMGODKL<PJHBHBBODGG, MPIKAEBOCFI?>>? JBPAFKMHMEI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E3")]
	[Cpp2IlInjected.Address(RVA = "0x1D28840", Offset = "0x1D27C40", VA = "0x181D28840")]
	private (CEKOIMKMDLP?, int)? NJHFHCPHKII()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(RVA = "0x1D27A50", Offset = "0x1D26E50", VA = "0x181D27A50")]
	private void KGAGPDFNPHJ(int KLCFAMMGJDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(RVA = "0x1197720", Offset = "0x1196B20", VA = "0x181197720")]
	private void PJCAKJIEHJO(int KLCFAMMGJDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(RVA = "0x1D27140", Offset = "0x1D26540", VA = "0x181D27140")]
	private void KAEEGFJIDFL(int JHGNNPAGBPA, int JPGEJIDHDJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(RVA = "0x1D23D80", Offset = "0x1D23180", VA = "0x181D23D80")]
	private void CGFMNFFJFIB(int KLCFAMMGJDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x1D29120", Offset = "0x1D28520", VA = "0x181D29120")]
	private void PNJPAEHNAKF(int KLCFAMMGJDD, int FHBLNFENHKJ, BFMMFHJHKDA BILHHBDBFLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0x1D27A00", Offset = "0x1D26E00", VA = "0x181D27A00")]
	private void KCGGCOJBFGP(int JHEMNDMHNOB, int FHBLNFENHKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x1D27040", Offset = "0x1D26440", VA = "0x181D27040")]
	private void JNHFOEDAAHC(int JHEMNDMHNOB, int FHBLNFENHKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x1D25640", Offset = "0x1D24A40", VA = "0x181D25640")]
	private void FGMBAEPOEEM(int KLCFAMMGJDD, int FHBLNFENHKJ, BFMMFHJHKDA BILHHBDBFLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(RVA = "0x1D26900", Offset = "0x1D25D00", VA = "0x181D26900")]
	private void JCFNKCNGADL(int KLCFAMMGJDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0x8B9BA0", Offset = "0x8B8FA0", VA = "0x1808B9BA0")]
	private void LHEHLGHGIHP(int KLCFAMMGJDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x1D23DA0", Offset = "0x1D231A0", VA = "0x181D23DA0")]
	private void CGJEKEIKNFE(int KLCFAMMGJDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(RVA = "0x1197720", Offset = "0x1196B20", VA = "0x181197720")]
	private void LNFBFKJCIPF(int KLCFAMMGJDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(RVA = "0x1D23E90", Offset = "0x1D23290", VA = "0x181D23E90")]
	private void CIKAJOKDKJF(int JHGNNPAGBPA, int JPGEJIDHDJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(RVA = "0x1D23D80", Offset = "0x1D23180", VA = "0x181D23D80")]
	private void KLBLENMKDEI(int KLCFAMMGJDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(RVA = "0x1D274E0", Offset = "0x1D268E0", VA = "0x181D274E0")]
	private void KBMGLKOHLHO(int KLCFAMMGJDD, int FHBLNFENHKJ, MIMLJFBOMCO BILHHBDBFLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(RVA = "0x1D26690", Offset = "0x1D25A90", VA = "0x181D26690")]
	private void ILJMPIIBLHH(int JHEMNDMHNOB, int FHBLNFENHKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(RVA = "0x1D25AA0", Offset = "0x1D24EA0", VA = "0x181D25AA0")]
	private void FHNPMIEJJBI(int JHEMNDMHNOB, int FHBLNFENHKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(RVA = "0x1D25060", Offset = "0x1D24460", VA = "0x181D25060")]
	private void EHIPECHHFDJ(int KLCFAMMGJDD, int FHBLNFENHKJ, MIMLJFBOMCO BILHHBDBFLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(RVA = "0x1D25E90", Offset = "0x1D25290", VA = "0x181D25E90")]
	private void GIIGCGJFLIJ(int KLCFAMMGJDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(RVA = "0x8B9BA0", Offset = "0x8B8FA0", VA = "0x1808B9BA0")]
	private void MDCLIAJOKBJ(int KLCFAMMGJDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(RVA = "0x1D24230", Offset = "0x1D23630", VA = "0x181D24230", Slot = "35")]
	[AsyncStateMachine(typeof(ACCNKBMJPCG))]
	public Task<KKHLNMGODKL<PJHBHBBODGG, MPIKAEBOCFI?>>? CLMFBEINPKH(JLGMECJOLDI<NJIGMIHFIFI> AJIHFKHEMCB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(RVA = "0x1D264D0", Offset = "0x1D258D0", VA = "0x181D264D0", Slot = "36")]
	[AsyncStateMachine(typeof(GGCEAKIFEDC))]
	public Task<KKHLNMGODKL<PJHBHBBODGG, MPIKAEBOCFI?>>? GPGLMCDCGOP(JLGMECJOLDI<KFBDPPFJJPB> KKDLHAPIIII)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(RVA = "0x1D262F0", Offset = "0x1D256F0", VA = "0x181D262F0", Slot = "37")]
	[AsyncStateMachine(typeof(IDNIHOLOBNE))]
	public Task<KKHLNMGODKL<PJHBHBBODGG, MPIKAEBOCFI?>>? GNLMPJILBGA(JLGMECJOLDI<NJIGMIHFIFI> AJIHFKHEMCB, JLGMECJOLDI<NJIGMIHFIFI> CPLMOFDCCAP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(RVA = "0x1D25520", Offset = "0x1D24920", VA = "0x181D25520", Slot = "38")]
	[AsyncStateMachine(typeof(KHILCBIOODA))]
	public Task<KKHLNMGODKL<PJHBHBBODGG, MPIKAEBOCFI?>>? FFHLBCLEOMO(JLGMECJOLDI<KFBDPPFJJPB> KKDLHAPIIII, JLGMECJOLDI<KFBDPPFJJPB> CPLMOFDCCAP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(RVA = "0x1D25AF0", Offset = "0x1D24EF0", VA = "0x181D25AF0", Slot = "39")]
	[AsyncStateMachine(typeof(DMOJEPDPEPB))]
	public Task<KKHLNMGODKL<PJHBHBBODGG, MPIKAEBOCFI?>>? FKOBFNOGDDN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x1D261D0", Offset = "0x1D255D0", VA = "0x181D261D0", Slot = "40")]
	[AsyncStateMachine(typeof(OEBFBFHCECN))]
	public Task<KKHLNMGODKL<PJHBHBBODGG, MPIKAEBOCFI>> GMPEKJFPEEH(string PEICKGKGHAI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(RVA = "0x1D25BE0", Offset = "0x1D24FE0", VA = "0x181D25BE0", Slot = "41")]
	[AsyncStateMachine(typeof(JKGCMGHCKKC))]
	public Task<KKHLNMGODKL<PJHBHBBODGG, MPIKAEBOCFI>> FODNLAGOBDJ(JLGMECJOLDI<NJIGMIHFIFI> AJIHFKHEMCB, string OMHHPMIDNAN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(RVA = "0x1D28FC0", Offset = "0x1D283C0", VA = "0x181D28FC0", Slot = "42")]
	[AsyncStateMachine(typeof(DEGEALDNEKO))]
	public Task<KKHLNMGODKL<PJHBHBBODGG, MPIKAEBOCFI>> OILJDCOHCFE(JLGMECJOLDI<KFBDPPFJJPB> KKDLHAPIIII, string OMHHPMIDNAN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000200")]
	[Cpp2IlInjected.Address(RVA = "0x1D266E0", Offset = "0x1D25AE0", VA = "0x181D266E0", Slot = "43")]
	[AsyncStateMachine(typeof(DBCIHAMABIA))]
	public Task<KKHLNMGODKL<PJHBHBBODGG, MPIKAEBOCFI>> INOHBEBEINM(JLGMECJOLDI<NJIGMIHFIFI> AJIHFKHEMCB, NKJCMKKBOGB ADAMDPHPFAA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000201")]
	[Cpp2IlInjected.Address(RVA = "0x1D25FE0", Offset = "0x1D253E0", VA = "0x181D25FE0", Slot = "44")]
	[AsyncStateMachine(typeof(IBIFFKBNFDN))]
	public Task<KKHLNMGODKL<PJHBHBBODGG, MPIKAEBOCFI>> GLLFLGFFDIC(JLGMECJOLDI<KFBDPPFJJPB> KKDLHAPIIII, NKJCMKKBOGB ADAMDPHPFAA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(RVA = "0x1D28A70", Offset = "0x1D27E70", VA = "0x181D28A70")]
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
		[Cpp2IlInjected.Token(Token = "0x4000163")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000164")]
		public AsyncTaskMethodBuilder<DEEBIGMHJGN> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000165")]
		public EJHJLJPPHCN circuitsManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000166")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000167")]
		public HGAPEMBEHIA roomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000168")]
		public ODLEKMGFHLE superRoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000169")]
		private PNAGPAIJMOJ <selfDeps>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400016A")]
		private ODLEKMGFHLE <finalSuperRoomData>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400016B")]
		private TaskAwaiter<HGAPEMBEHIA> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400016C")]
		private TaskAwaiter<ODLEKMGFHLE> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400016D")]
		private TaskAwaiter<BCPGLEEKCAN> <>u__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400016E")]
		private TaskAwaiter<KLLNHDMNECI> <>u__4;

		[Cpp2IlInjected.Token(Token = "0x6000227")]
		[Cpp2IlInjected.Address(RVA = "0x1D2C620", Offset = "0x1D2BA20", VA = "0x181D2C620", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(RVA = "0x1D2CFD0", Offset = "0x1D2C3D0", VA = "0x181D2CFD0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000162")]
	private readonly KLLNHDMNECI EFPOJPMPDJI;

	[Cpp2IlInjected.Token(Token = "0x17000082")]
	public KLLNHDMNECI MHABINIMOJG
	{
		[Cpp2IlInjected.Token(Token = "0x6000222")]
		[Cpp2IlInjected.Address(RVA = "0x79F200", Offset = "0x79E600", VA = "0x18079F200", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600021F")]
	[Cpp2IlInjected.Address(RVA = "0x7ABBD0", Offset = "0x7AAFD0", VA = "0x1807ABBD0")]
	private DEEBIGMHJGN(KLLNHDMNECI GLFFBACKIHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000220")]
	[Cpp2IlInjected.Address(RVA = "0x1D2BE10", Offset = "0x1D2B210", VA = "0x181D2BE10")]
	[AsyncStateMachine(typeof(DFNMDLEFPIM))]
	public static Task<DEEBIGMHJGN> MNPMCBDFPDL(EJHJLJPPHCN BALKEACFDJN, HGAPEMBEHIA? ILKGBPMJIJM, ODLEKMGFHLE? JAMOLIKGFAA, CancellationToken HNLFPBLPOKJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000221")]
	[Cpp2IlInjected.Address(RVA = "0x1D2BDF0", Offset = "0x1D2B1F0", VA = "0x181D2BDF0", Slot = "5")]
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
		[Cpp2IlInjected.Token(Token = "0x4000170")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000171")]
		public AsyncTaskMethodBuilder<KKHLNMGODKL<object, MPIKAEBOCFI>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000172")]
		public IDOFCENLABL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000173")]
		public PKBFCJOJFAD action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000174")]
		public bool clearBufferedRpcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000175")]
		private TaskAwaiter<KKHLNMGODKL<object, MPIKAEBOCFI>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600022D")]
		[Cpp2IlInjected.Address(RVA = "0x1D32580", Offset = "0x1D31980", VA = "0x181D32580", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022E")]
		[Cpp2IlInjected.Address(RVA = "0x1D32810", Offset = "0x1D31C10", VA = "0x181D32810", Slot = "5")]
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
		[Cpp2IlInjected.Token(Token = "0x4000176")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000177")]
		public AsyncTaskMethodBuilder<KKHLNMGODKL<bool, MPIKAEBOCFI>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000178")]
		public int splitSizeBytes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000179")]
		public FAPCIJNABKN rootData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400017A")]
		public HGAPEMBEHIA circuitRootData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400017B")]
		public ODLEKMGFHLE superRoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400017C")]
		public IDOFCENLABL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400017D")]
		private PKBFCJOJFAD[] <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400017E")]
		private int <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400017F")]
		private TaskAwaiter<KKHLNMGODKL<object, MPIKAEBOCFI>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600022F")]
		[Cpp2IlInjected.Address(RVA = "0x1D32880", Offset = "0x1D31C80", VA = "0x181D32880", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000230")]
		[Cpp2IlInjected.Address(RVA = "0x1D32C60", Offset = "0x1D32060", VA = "0x181D32C60", Slot = "5")]
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
		[Cpp2IlInjected.Token(Token = "0x4000180")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000181")]
		public AsyncTaskMethodBuilder<KKHLNMGODKL<PJHBHBBODGG, MPIKAEBOCFI>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000182")]
		public IDOFCENLABL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000183")]
		private TaskAwaiter<KKHLNMGODKL<object, MPIKAEBOCFI>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000231")]
		[Cpp2IlInjected.Address(RVA = "0x1D29B00", Offset = "0x1D28F00", VA = "0x181D29B00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0x1D29DE0", Offset = "0x1D291E0", VA = "0x181D29DE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400016F")]
	private readonly EDKKDEPLJLE JKHCKNDMHJK;

	[Cpp2IlInjected.Token(Token = "0x6000229")]
	[Cpp2IlInjected.Address(RVA = "0x8BBF70", Offset = "0x8BB370", VA = "0x1808BBF70")]
	public IDOFCENLABL(EDKKDEPLJLE BIHMJDLLGLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022A")]
	[Cpp2IlInjected.Address(RVA = "0x1D38C20", Offset = "0x1D38020", VA = "0x181D38C20")]
	[AsyncStateMachine(typeof(EJKGHFAEONI))]
	private Task<KKHLNMGODKL<object, MPIKAEBOCFI>> AOPGGACNBPB(PKBFCJOJFAD MCLCEMNNOFC, bool HPOBNPKLCBN = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022B")]
	[Cpp2IlInjected.Address(RVA = "0x1D38D50", Offset = "0x1D38150", VA = "0x181D38D50")]
	[AsyncStateMachine(typeof(EMHOIACJJNI))]
	public Task<KKHLNMGODKL<bool, MPIKAEBOCFI?>>? LKKCKPEPLOK(int ECEGNNEMCAK, FAPCIJNABKN? NJFPPBLMKHP, HGAPEMBEHIA? KCJNLIFKLJL, ODLEKMGFHLE? JAMOLIKGFAA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022C")]
	[Cpp2IlInjected.Address(RVA = "0x1D38EB0", Offset = "0x1D382B0", VA = "0x181D38EB0")]
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
	[Cpp2IlInjected.Token(Token = "0x4000184")]
	private readonly NGOLBPFHPEC JAKFMPICMKE;

	[Cpp2IlInjected.Token(Token = "0x17000084")]
	public NGOLBPFHPEC MGILNMFNJBF
	{
		[Cpp2IlInjected.Token(Token = "0x6000236")]
		[Cpp2IlInjected.Address(RVA = "0x79F200", Offset = "0x79E600", VA = "0x18079F200", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000233")]
	[Cpp2IlInjected.Address(RVA = "0x7ABBD0", Offset = "0x7AAFD0", VA = "0x1807ABBD0")]
	private CJIFINGOFIP(NGOLBPFHPEC ADOIDJOANPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000234")]
	[Cpp2IlInjected.Address(RVA = "0x1D2AE40", Offset = "0x1D2A240", VA = "0x181D2AE40")]
	public static CJIFINGOFIP AFFCBAMFOKP(EJHJLJPPHCN BALKEACFDJN, FAPCIJNABKN DPLOCHMLAED)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000235")]
	[Cpp2IlInjected.Address(RVA = "0x1D2B010", Offset = "0x1D2A410", VA = "0x181D2B010", Slot = "5")]
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
	[Cpp2IlInjected.Token(Token = "0x4000185")]
	private readonly EJHJLJPPHCN CAPMIPILDGH;

	[Cpp2IlInjected.Token(Token = "0x1700008F")]
	public OKFJHCOHBLL? MEGHANKAOBP
	{
		[Cpp2IlInjected.Token(Token = "0x6000243")]
		[Cpp2IlInjected.Address(RVA = "0x1D2A220", Offset = "0x1D29620", VA = "0x181D2A220", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000244")]
	[Cpp2IlInjected.Address(RVA = "0x7ABBD0", Offset = "0x7AAFD0", VA = "0x1807ABBD0")]
	internal ANLNOJDPDEI(EJHJLJPPHCN BALKEACFDJN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000075")]
public sealed class FOAFAGELKHL : OKFJHCOHBLL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000186")]
	private readonly DEEIIACCHIP PACOCMKCMKD;

	[Cpp2IlInjected.Token(Token = "0x17000090")]
	public OFFDGOOAMPM AOPGGACNBPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000245")]
		[Cpp2IlInjected.Address(RVA = "0x1D348C0", Offset = "0x1D33CC0", VA = "0x181D348C0", Slot = "4")]
		get
		{
			return default(OFFDGOOAMPM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000091")]
	public HNCOCAACANO EPNKCEAAJMG
	{
		[Cpp2IlInjected.Token(Token = "0x6000246")]
		[Cpp2IlInjected.Address(RVA = "0x1D34740", Offset = "0x1D33B40", VA = "0x181D34740", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000092")]
	public JGKGEKHGJKB<BIKLLPOLGEF> JDENOMGGILO
	{
		[Cpp2IlInjected.Token(Token = "0x6000247")]
		[Cpp2IlInjected.Address(RVA = "0x1D34860", Offset = "0x1D33C60", VA = "0x181D34860", Slot = "6")]
		get
		{
			return default(JGKGEKHGJKB<BIKLLPOLGEF>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000093")]
	public KLLNHDMNECI EDCEOHEGDCL
	{
		[Cpp2IlInjected.Token(Token = "0x6000248")]
		[Cpp2IlInjected.Address(RVA = "0x1D34810", Offset = "0x1D33C10", VA = "0x181D34810", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000249")]
	[Cpp2IlInjected.Address(RVA = "0x7ABBD0", Offset = "0x7AAFD0", VA = "0x1807ABBD0")]
	public FOAFAGELKHL(DEEIIACCHIP NEMDKECFAGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024A")]
	[Cpp2IlInjected.Address(RVA = "0x1D347A0", Offset = "0x1D33BA0", VA = "0x181D347A0")]
	public bool DNEDCKEKEOC([In] JGKGEKHGJKB<BIKLLPOLGEF> KGGOGFBCEKB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600024B")]
	[Cpp2IlInjected.Address(RVA = "0x1D347A0", Offset = "0x1D33BA0", VA = "0x181D347A0", Slot = "8")]
	private bool INKIOBKHKKP([In] JGKGEKHGJKB<BIKLLPOLGEF> KGGOGFBCEKB)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000076")]
public static class CKILJANGHFP
{
	[Cpp2IlInjected.Token(Token = "0x600024C")]
	[Cpp2IlInjected.Address(RVA = "0x1D2B030", Offset = "0x1D2A430", VA = "0x181D2B030")]
	public static CHFDGNEIFAE<KBBHNEGECJL, PKBFCJOJFAD, EJHJLJPPHCN, LHINJBLMLPJ.HJMNPMINJNE<KBBHNEGECJL, PKBFCJOJFAD, EJHJLJPPHCN>> PFINEGNAILA([In] this CHFDGNEIFAE<KBBHNEGECJL, PKBFCJOJFAD, EJHJLJPPHCN, LHINJBLMLPJ.HJMNPMINJNE<KBBHNEGECJL, PKBFCJOJFAD, EJHJLJPPHCN>> ONNPNLGHOAJ)
	{
		return default(CHFDGNEIFAE<KBBHNEGECJL, PKBFCJOJFAD, EJHJLJPPHCN, LHINJBLMLPJ.HJMNPMINJNE<KBBHNEGECJL, PKBFCJOJFAD, EJHJLJPPHCN>>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000077")]
public sealed class MAPCCGGEAHJ : PDBOEIFOONC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000187")]
	private readonly EJHJLJPPHCN CAPMIPILDGH;

	[Cpp2IlInjected.Token(Token = "0x17000094")]
	public bool LKCNFAOLEPN
	{
		[Cpp2IlInjected.Token(Token = "0x600024D")]
		[Cpp2IlInjected.Address(RVA = "0x1D3D2A0", Offset = "0x1D3C6A0", VA = "0x181D3D2A0", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600024E")]
	[Cpp2IlInjected.Address(RVA = "0x7ABBD0", Offset = "0x7AAFD0", VA = "0x1807ABBD0")]
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
		[Cpp2IlInjected.Token(Token = "0x400018A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400018B")]
		public AsyncTaskMethodBuilder<APAALMMIDKA> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400018C")]
		public JHKHAEKCONG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400018D")]
		private TaskAwaiter<HGBGBPBGNKL?> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600025A")]
		[Cpp2IlInjected.Address(RVA = "0x1D39380", Offset = "0x1D38780", VA = "0x181D39380", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025B")]
		[Cpp2IlInjected.Address(RVA = "0x1D39630", Offset = "0x1D38A30", VA = "0x181D39630", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000188")]
	private readonly EJHJLJPPHCN CAPMIPILDGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000189")]
	private IReadOnlyList<JGKGEKHGJKB<ELOBPGFADAE>>? FDKIHCGELDF;

	[Cpp2IlInjected.Token(Token = "0x17000095")]
	public APAALMMIDKA? MEGHANKAOBP
	{
		[Cpp2IlInjected.Token(Token = "0x600024F")]
		[Cpp2IlInjected.Address(RVA = "0x1D3A480", Offset = "0x1D39880", VA = "0x181D3A480", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000096")]
	public HPBOKLJNGGO? OMGLLANKMAE
	{
		[Cpp2IlInjected.Token(Token = "0x6000250")]
		[Cpp2IlInjected.Address(RVA = "0x1D3A500", Offset = "0x1D39900", VA = "0x181D3A500")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000097")]
	public bool FBGEGGIHHHI
	{
		[Cpp2IlInjected.Token(Token = "0x6000251")]
		[Cpp2IlInjected.Address(RVA = "0x1D3A5E0", Offset = "0x1D399E0", VA = "0x181D3A5E0", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000098")]
	public bool ODDAHJKENEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000252")]
		[Cpp2IlInjected.Address(RVA = "0x1D3A580", Offset = "0x1D39980", VA = "0x181D3A580", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000253")]
	[Cpp2IlInjected.Address(RVA = "0x7ABBD0", Offset = "0x7AAFD0", VA = "0x1807ABBD0")]
	internal JHKHAEKCONG(EJHJLJPPHCN BALKEACFDJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000254")]
	[Cpp2IlInjected.Address(RVA = "0x1D3A390", Offset = "0x1D39790", VA = "0x181D3A390", Slot = "7")]
	[AsyncStateMachine(typeof(JFFOIMFHOJM))]
	public Task<APAALMMIDKA> DIKPACPGGAH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000255")]
	[Cpp2IlInjected.Address(RVA = "0x1D3A640", Offset = "0x1D39A40", VA = "0x181D3A640")]
	internal Dictionary<JGKGEKHGJKB<BIKLLPOLGEF>, Guid> NOFINHOIFPB(IEnumerable<NEEDBNPPDKD> PJHLLPPLEAJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000256")]
	[Cpp2IlInjected.Address(RVA = "0x1D39D00", Offset = "0x1D39100", VA = "0x181D39D00")]
	public KKHLNMGODKL<EELEJFLMNKL, PKFDKDKJAIE> BBINFIIMDGO([In] EELEJFLMNKL JIGMOBMNNCI, IEnumerable<NEEDBNPPDKD> EBDMPFJBFKI, int KJPHDLDDKNB)
	{
		return default(KKHLNMGODKL<EELEJFLMNKL, PKFDKDKJAIE>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000257")]
	[Cpp2IlInjected.Address(RVA = "0x1D3A350", Offset = "0x1D39750", VA = "0x181D3A350")]
	internal static KIAFDOMBGOF DGLLFAFICJC(FLLKFBLHCCN CNCLKDOFGPK, DLLEFNELPBJ JACJPEOECBN)
	{
		return default(KIAFDOMBGOF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000258")]
	[Cpp2IlInjected.Address(RVA = "0x1D39F00", Offset = "0x1D39300", VA = "0x181D39F00", Slot = "8")]
	private KKHLNMGODKL<EELEJFLMNKL, PKFDKDKJAIE> BJBBOOLHDGD([In] EELEJFLMNKL JIGMOBMNNCI, IEnumerable<NEEDBNPPDKD> EBDMPFJBFKI, int KJPHDLDDKNB)
	{
		return default(KKHLNMGODKL<EELEJFLMNKL, PKFDKDKJAIE>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000259")]
	[Cpp2IlInjected.Address(RVA = "0x1D3A100", Offset = "0x1D39500", VA = "0x181D3A100")]
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
			[Cpp2IlInjected.Token(Token = "0x4000196")]
			public KLLNHDMNECI state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000197")]
			public BIGEIDAKKJG spawnIntoGraph;

			[Cpp2IlInjected.Token(Token = "0x600027B")]
			[Cpp2IlInjected.Address(RVA = "0x7A4800", Offset = "0x7A3C00", VA = "0x1807A4800")]
			public HDAFIHJGJCO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600027C")]
			[Cpp2IlInjected.Address(RVA = "0x1D44190", Offset = "0x1D43590", VA = "0x181D44190")]
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
			[Cpp2IlInjected.Token(Token = "0x4000198")]
			public int makerPenInteractionFilterKeyValue;

			[Cpp2IlInjected.Token(Token = "0x600027D")]
			[Cpp2IlInjected.Address(RVA = "0x7A4800", Offset = "0x7A3C00", VA = "0x1807A4800")]
			public PIAICCJEBAI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600027E")]
			[Cpp2IlInjected.Address(RVA = "0x1D469B0", Offset = "0x1D45DB0", VA = "0x181D469B0")]
			internal void DOJFMKOLJGD(ENHCHOGMCKE n)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000276")]
		[Cpp2IlInjected.Address(RVA = "0x1D42690", Offset = "0x1D41A90", VA = "0x181D42690")]
		public static KKHLNMGODKL<APAALMMIDKA.LMHHJJAKPPB, PKFDKDKJAIE> OLPPMELFJKG(HPBOKLJNGGO NHHBAHIFHJK, [In] APAALMMIDKA.DNOIJLLALMF AHLEFKCGEBC)
		{
			return default(KKHLNMGODKL<APAALMMIDKA.LMHHJJAKPPB, PKFDKDKJAIE>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000277")]
		[Cpp2IlInjected.Address(RVA = "0x1D41850", Offset = "0x1D40C50", VA = "0x181D41850")]
		internal static KKHLNMGODKL<(PNPLINPDKOO, CJPHMPPJPIA), MPIKAEBOCFI> ENLDEPKJNGK(HPBOKLJNGGO NHHBAHIFHJK, CJPHMPPJPIA LMHCJAGECHL, bool OBKOCIHLFKG, [In] JGKGEKHGJKB<BIKLLPOLGEF> AOIDNFEHPNL, [In] int? EHEAGHCFAJJ, [In] KIAFDOMBGOF? GFBOAAIOMED, [In] KIAFDOMBGOF? ODFAHHEPNLM)
		{
			return default(KKHLNMGODKL<(PNPLINPDKOO, CJPHMPPJPIA), MPIKAEBOCFI>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(RVA = "0x1D42BD0", Offset = "0x1D41FD0", VA = "0x181D42BD0")]
		private static void PGFMOFFJMJC(bool OBKOCIHLFKG, NEEDBNPPDKD GKOAKJGNMLA, PNPLINPDKOO FLHPEMKANCN, [In] JGKGEKHGJKB<BIKLLPOLGEF> AOIDNFEHPNL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(RVA = "0x1D43060", Offset = "0x1D42460", VA = "0x181D43060")]
		public static void PKDIPEGAKBD(KIIGMFKIPLN ICJKNJANKLL, [In] APAALMMIDKA.JHGEJOLGJMK JEKACLKFFJM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(RVA = "0x1D425A0", Offset = "0x1D419A0", VA = "0x181D425A0")]
		[CompilerGenerated]
		internal static bool OFJBGIIPKCJ(KLLNHDMNECI BDHICBCDBOF, BIGEIDAKKJG GDOPAEPAFHP, ENHCHOGMCKE JHECMPKPDPL)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400018E")]
	private readonly EJHJLJPPHCN CAPMIPILDGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400018F")]
	private readonly DEEIIACCHIP PACOCMKCMKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000190")]
	private readonly HDEAGHOKJFL ADDKLKFIIKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000191")]
	private readonly MAJHHNDLKFI JHFBEGPHNEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000192")]
	private readonly JHKHAEKCONG EPIINKCBBAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000193")]
	private Dictionary<JGKGEKHGJKB<PNMLFKAJNIK>, MJLPNDIJFMP> KMOHPFPPMMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000195")]
	[CompilerGenerated]
	private Action<JGKGEKHGJKB<PNMLFKAJNIK>>? NAEBEFBEBCG;

	[Cpp2IlInjected.Token(Token = "0x600025C")]
	[Cpp2IlInjected.Address(RVA = "0x1D37CC0", Offset = "0x1D370C0", VA = "0x181D37CC0")]
	public HPBOKLJNGGO(EJHJLJPPHCN BALKEACFDJN, DEEIIACCHIP NEMDKECFAGI, HDEAGHOKJFL JFANONPAIDP, JHKHAEKCONG POAJGEGMONE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025D")]
	[Cpp2IlInjected.Address(RVA = "0x1D36220", Offset = "0x1D35620", VA = "0x181D36220")]
	public MJLPNDIJFMP? CJDOPPMMLEH([In] JGKGEKHGJKB<PNMLFKAJNIK> KOOMGHGCPCM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025E")]
	[Cpp2IlInjected.Address(RVA = "0x1D37040", Offset = "0x1D36440", VA = "0x181D37040")]
	private void HDIOFOEAEPC(JGKGEKHGJKB<PNMLFKAJNIK> KOOMGHGCPCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025F")]
	[Cpp2IlInjected.Address(RVA = "0x1D36F10", Offset = "0x1D36310", VA = "0x181D36F10")]
	private MJLPNDIJFMP? FDJKLLEAHEM([In] JGKGEKHGJKB<PNMLFKAJNIK> KOOMGHGCPCM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000260")]
	[Cpp2IlInjected.Address(RVA = "0x1D36130", Offset = "0x1D35530", VA = "0x181D36130")]
	public DLLEFNELPBJ? AHJEHLIAIBO([In] JGKGEKHGJKB<PNMLFKAJNIK> KOOMGHGCPCM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000261")]
	[Cpp2IlInjected.Address(RVA = "0x1D36120", Offset = "0x1D35520", VA = "0x181D36120")]
	public BPPMJABJILE? ADFJBMPIMJC([In] JGKGEKHGJKB<BIKLLPOLGEF> KGGOGFBCEKB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000262")]
	[Cpp2IlInjected.Address(RVA = "0x1D370C0", Offset = "0x1D364C0", VA = "0x181D370C0")]
	private BIGEIDAKKJG? HILGPACCJJN([In] JGKGEKHGJKB<BIKLLPOLGEF> KGGOGFBCEKB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000263")]
	[Cpp2IlInjected.Address(RVA = "0x1D37620", Offset = "0x1D36A20", VA = "0x181D37620")]
	private BPPMJABJILE? NJEGKMLKAOL([In] JGKGEKHGJKB<BIKLLPOLGEF> KGGOGFBCEKB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000264")]
	[Cpp2IlInjected.Address(RVA = "0x1D37B40", Offset = "0x1D36F40", VA = "0x181D37B40", Slot = "6")]
	public IEnumerable<NKJCMKKBOGB> OFPFDNDGEAN(bool HGDDBHBEHGG, bool KIFCGAGOALG, bool BIOLBEKDMKA, bool NFEHPOAMHJJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000265")]
	[Cpp2IlInjected.Address(RVA = "0x1D36EE0", Offset = "0x1D362E0", VA = "0x181D36EE0")]
	public KKHLNMGODKL<APAALMMIDKA.LMHHJJAKPPB, PKFDKDKJAIE> EHNFDLDPKDE([In] APAALMMIDKA.DNOIJLLALMF AHLEFKCGEBC)
	{
		return default(KKHLNMGODKL<APAALMMIDKA.LMHHJJAKPPB, PKFDKDKJAIE>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000266")]
	[Cpp2IlInjected.Address(RVA = "0x1D371D0", Offset = "0x1D365D0", VA = "0x181D371D0", Slot = "8")]
	public KKHLNMGODKL<EDJPHBGOKGF, PKFDKDKJAIE> KAEBLKGBJJE(JGKGEKHGJKB<BIKLLPOLGEF> KGGOGFBCEKB, EDJPHBGOKGF CCJLBIBHGML, FKIBNGAKAAJ BIAANFIKPLH)
	{
		return default(KKHLNMGODKL<EDJPHBGOKGF, PKFDKDKJAIE>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000267")]
	[Cpp2IlInjected.Address(RVA = "0x1D37830", Offset = "0x1D36C30", VA = "0x181D37830", Slot = "9")]
	public GHACBNFAIEE OBKAFLKJCOL(IEnumerable<NEEDBNPPDKD> EBDMPFJBFKI)
	{
		return default(GHACBNFAIEE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000268")]
	[Cpp2IlInjected.Address(RVA = "0x1D37A20", Offset = "0x1D36E20", VA = "0x181D37A20", Slot = "10")]
	public GHACBNFAIEE OCEEPFDDELL()
	{
		return default(GHACBNFAIEE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000269")]
	[Cpp2IlInjected.Address(RVA = "0x1D366D0", Offset = "0x1D35AD0", VA = "0x181D366D0")]
	private ILLEFFCAAOI CKNLBIDIJAL(KMDIJJHPMKL KPNPBJJKALE, JLGMECJOLDI<BIKLLPOLGEF> IAONMJHKCGE, IEnumerable<JGKGEKHGJKB<BIKLLPOLGEF>> MMDHFHIMGHM, IEnumerable<JGKGEKHGJKB<PNMLFKAJNIK>> OAFDABMJNGH)
	{
		return default(ILLEFFCAAOI);
	}

	[Cpp2IlInjected.Token(Token = "0x600026A")]
	[Cpp2IlInjected.Address(RVA = "0x1D36390", Offset = "0x1D35790", VA = "0x181D36390", Slot = "11")]
	public ILLEFFCAAOI CKNLBIDIJAL(KMDIJJHPMKL KPNPBJJKALE, JLGMECJOLDI<BIKLLPOLGEF> IAONMJHKCGE, IEnumerable<JGKGEKHGJKB<PNMLFKAJNIK>> OAFDABMJNGH, IEnumerable<NEEDBNPPDKD> EBDMPFJBFKI)
	{
		return default(ILLEFFCAAOI);
	}

	[Cpp2IlInjected.Token(Token = "0x600026B")]
	[Cpp2IlInjected.Address(RVA = "0x1D35DA0", Offset = "0x1D351A0", VA = "0x181D35DA0")]
	private static IEnumerable<JGKGEKHGJKB<BIKLLPOLGEF>> ADALILHIICC(IEnumerable<NEEDBNPPDKD> EBDMPFJBFKI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600026C")]
	[Cpp2IlInjected.Address(RVA = "0x1D369D0", Offset = "0x1D35DD0", VA = "0x181D369D0")]
	private IEnumerable<JGKGEKHGJKB<PNMLFKAJNIK>> DAPGDCALOGE(IEnumerable<NEEDBNPPDKD> EBDMPFJBFKI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600026D")]
	[Cpp2IlInjected.Address(RVA = "0x1D37C30", Offset = "0x1D37030", VA = "0x181D37C30", Slot = "12")]
	public List<APGAMDAIPCO> OJAFKEGANJO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600026E")]
	[Cpp2IlInjected.Address(RVA = "0x1D361C0", Offset = "0x1D355C0", VA = "0x181D361C0")]
	internal void AKCBAGCJHJE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026F")]
	[Cpp2IlInjected.Address(RVA = "0x1D375C0", Offset = "0x1D369C0", VA = "0x181D375C0")]
	internal Task MLPDNOIKKPP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000270")]
	[Cpp2IlInjected.Address(RVA = "0x1D36120", Offset = "0x1D35520", VA = "0x181D36120", Slot = "4")]
	private BPPMJABJILE GDKKNCJKPFE([In] JGKGEKHGJKB<BIKLLPOLGEF> KGGOGFBCEKB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000271")]
	[Cpp2IlInjected.Address(RVA = "0x1D36880", Offset = "0x1D35C80", VA = "0x181D36880", Slot = "5")]
	private MJLPNDIJFMP CLJGFNNBGAE([In] JGKGEKHGJKB<PNMLFKAJNIK> KOOMGHGCPCM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000272")]
	[Cpp2IlInjected.Address(RVA = "0x1D36EE0", Offset = "0x1D362E0", VA = "0x181D36EE0", Slot = "7")]
	private KKHLNMGODKL<APAALMMIDKA.LMHHJJAKPPB, PKFDKDKJAIE> HNIONMJEEHI([In] APAALMMIDKA.DNOIJLLALMF AHLEFKCGEBC)
	{
		return default(KKHLNMGODKL<APAALMMIDKA.LMHHJJAKPPB, PKFDKDKJAIE>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000273")]
	[Cpp2IlInjected.Address(RVA = "0x1D36FC0", Offset = "0x1D363C0", VA = "0x181D36FC0")]
	[CompilerGenerated]
	private KBFFDIFJBJN FIIEPAIODLN(FFGBDNDMLII CCNHOKJIGCD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000274")]
	[Cpp2IlInjected.Address(RVA = "0x1D36E70", Offset = "0x1D36270", VA = "0x181D36E70")]
	[CompilerGenerated]
	private DLLEFNELPBJ EFOPFJJCLGN(JGKGEKHGJKB<PNMLFKAJNIK> CCNHOKJIGCD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000275")]
	[Cpp2IlInjected.Address(RVA = "0x1D37160", Offset = "0x1D36560", VA = "0x181D37160")]
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
		[Cpp2IlInjected.Token(Token = "0x400019C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400019D")]
		public AsyncTaskMethodBuilder<KKHLNMGODKL<JLGMECJOLDI<NJIGMIHFIFI>, MPIKAEBOCFI>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400019E")]
		public KBFFDIFJBJN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400019F")]
		public JGKGEKHGJKB<BIKLLPOLGEF> graphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001A0")]
		public JGKGEKHGJKB<PNMLFKAJNIK> nodeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001A1")]
		public JLGMECJOLDI<EHGNFGGIBEB> portGroupId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001A2")]
		public string name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001A3")]
		private TaskAwaiter<KKHLNMGODKL<JLGMECJOLDI<NJIGMIHFIFI>, MPIKAEBOCFI>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000285")]
		[Cpp2IlInjected.Address(RVA = "0x1D41560", Offset = "0x1D40960", VA = "0x181D41560", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000286")]
		[Cpp2IlInjected.Address(RVA = "0x1D417E0", Offset = "0x1D40BE0", VA = "0x181D417E0", Slot = "5")]
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
		[Cpp2IlInjected.Token(Token = "0x40001A4")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001A5")]
		public AsyncTaskMethodBuilder<KKHLNMGODKL<JLGMECJOLDI<KFBDPPFJJPB>, MPIKAEBOCFI>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001A6")]
		public KBFFDIFJBJN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001A7")]
		public JGKGEKHGJKB<BIKLLPOLGEF> graphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001A8")]
		public JGKGEKHGJKB<PNMLFKAJNIK> nodeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001A9")]
		public JLGMECJOLDI<EHGNFGGIBEB> portGroupId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001AA")]
		public string name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001AB")]
		private TaskAwaiter<KKHLNMGODKL<JLGMECJOLDI<KFBDPPFJJPB>, MPIKAEBOCFI>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000287")]
		[Cpp2IlInjected.Address(RVA = "0x1D44A10", Offset = "0x1D43E10", VA = "0x181D44A10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000288")]
		[Cpp2IlInjected.Address(RVA = "0x1D44C90", Offset = "0x1D44090", VA = "0x181D44C90", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000199")]
	private readonly FFGBDNDMLII ICMCLDLCFLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400019A")]
	private readonly DEEIIACCHIP PACOCMKCMKD;

	[Cpp2IlInjected.Token(Token = "0x17000099")]
	public TypeKey AGLCBPDPJFE
	{
		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0x8B8500", Offset = "0x8B7900", VA = "0x1808B8500", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x1D44490", Offset = "0x1D43890", VA = "0x181D44490", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009B")]
	public FFGBDNDMLII ODFHLKKMPKK
	{
		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0x79F200", Offset = "0x79E600", VA = "0x18079F200")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600027F")]
	[Cpp2IlInjected.Address(RVA = "0x1D44630", Offset = "0x1D43A30", VA = "0x181D44630")]
	public KBFFDIFJBJN(FFGBDNDMLII BPFDBMEGJBE, DEEIIACCHIP NEMDKECFAGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000283")]
	[Cpp2IlInjected.Address(RVA = "0x1D44320", Offset = "0x1D43720", VA = "0x181D44320", Slot = "6")]
	[AsyncStateMachine(typeof(CFGLHENEDAE))]
	public Task<KKHLNMGODKL<JLGMECJOLDI<NJIGMIHFIFI>, MPIKAEBOCFI>> LBAJODBLDPL(JGKGEKHGJKB<BIKLLPOLGEF> KGGOGFBCEKB, JGKGEKHGJKB<PNMLFKAJNIK> KOOMGHGCPCM, JLGMECJOLDI<EHGNFGGIBEB> NDKHLPHIJIN, string OMHHPMIDNAN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000284")]
	[Cpp2IlInjected.Address(RVA = "0x1D444C0", Offset = "0x1D438C0", VA = "0x181D444C0", Slot = "7")]
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
	[Cpp2IlInjected.Token(Token = "0x40001AC")]
	private readonly FFGBDNDMLII FADHFJMFNKI;

	[Cpp2IlInjected.Token(Token = "0x40001AD")]
	private static readonly HashSet<FFGBDNDMLII> ILOHNADNPJB;

	[Cpp2IlInjected.Token(Token = "0x40001AE")]
	private static readonly HashSet<FFGBDNDMLII> HGPHDGMACFP;

	[Cpp2IlInjected.Token(Token = "0x40001AF")]
	private static readonly HashSet<FFGBDNDMLII> MJKAJNCBFBG;

	[Cpp2IlInjected.Token(Token = "0x1700009C")]
	public TypeKey JFBDDAMOHDF
	{
		[Cpp2IlInjected.Token(Token = "0x6000289")]
		[Cpp2IlInjected.Address(RVA = "0x1D46590", Offset = "0x1D45990", VA = "0x181D46590", Slot = "6")]
		get
		{
			return default(TypeKey);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009D")]
	public bool IPLFONPJFLP
	{
		[Cpp2IlInjected.Token(Token = "0x600028A")]
		[Cpp2IlInjected.Address(RVA = "0x1D46580", Offset = "0x1D45980", VA = "0x181D46580", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009E")]
	public bool OGBCLDLCLEM
	{
		[Cpp2IlInjected.Token(Token = "0x600028E")]
		[Cpp2IlInjected.Address(RVA = "0x1D465E0", Offset = "0x1D459E0", VA = "0x181D465E0", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009F")]
	public bool DGOJMGHFKBI
	{
		[Cpp2IlInjected.Token(Token = "0x600028F")]
		[Cpp2IlInjected.Address(RVA = "0x1D46500", Offset = "0x1D45900", VA = "0x181D46500", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600028B")]
	[Cpp2IlInjected.Address(RVA = "0x1D450F0", Offset = "0x1D444F0", VA = "0x181D450F0")]
	public bool KDNFOKEGILP(string FDFHGIHHGHO, [Out] LPNODEDDNDJ BMPOHDNHCMO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600028C")]
	[Cpp2IlInjected.Address(RVA = "0x7ABBD0", Offset = "0x7AAFD0", VA = "0x1807ABBD0")]
	public MDAFEHJGBEE(FFGBDNDMLII CEBGEIIIEAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028D")]
	[Cpp2IlInjected.Address(RVA = "0x1D45360", Offset = "0x1D44760", VA = "0x181D45360")]
	internal static TypeKey LNFMLEPOFKH(FFGBDNDMLII ADAMDPHPFAA)
	{
		return default(TypeKey);
	}

	[Cpp2IlInjected.Token(Token = "0x6000290")]
	[Cpp2IlInjected.Address(RVA = "0x1D44490", Offset = "0x1D43890", VA = "0x181D44490", Slot = "3")]
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
	[Cpp2IlInjected.Address(RVA = "0x1D448E0", Offset = "0x1D43CE0", VA = "0x181D448E0", Slot = "4")]
	public int EDGFDJAOCDF(PJHBHBBODGG JHEMNDMHNOB, PKBFCJOJFAD MCLCEMNNOFC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000293")]
	[Cpp2IlInjected.Address(RVA = "0x1D449B0", Offset = "0x1D43DB0", VA = "0x181D449B0", Slot = "5")]
	public PKBFCJOJFAD KLEBHHEFNHE(PJHBHBBODGG JHEMNDMHNOB, PKBFCJOJFAD MCLCEMNNOFC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000294")]
	[Cpp2IlInjected.Address(RVA = "0x1D44920", Offset = "0x1D43D20", VA = "0x181D44920", Slot = "6")]
	public PKBFCJOJFAD HABHPEHAJMD(PJHBHBBODGG JHEMNDMHNOB, PKBFCJOJFAD MCLCEMNNOFC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000295")]
	[Cpp2IlInjected.Address(RVA = "0x1D44970", Offset = "0x1D43D70", VA = "0x181D44970", Slot = "7")]
	public IReadOnlyList<PKBFCJOJFAD> JHDGFOGGJND(PJHBHBBODGG JHEMNDMHNOB, PKBFCJOJFAD MCLCEMNNOFC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000296")]
	[Cpp2IlInjected.Address(RVA = "0x1D449C0", Offset = "0x1D43DC0", VA = "0x181D449C0", Slot = "8")]
	public PKBFCJOJFAD[] MGBFOKMFIPH(PJHBHBBODGG JHEMNDMHNOB, PKBFCJOJFAD MCLCEMNNOFC, int FLNOFAHKHFK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000297")]
	[Cpp2IlInjected.Address(RVA = "0x1D448C0", Offset = "0x1D43CC0", VA = "0x181D448C0", Slot = "9")]
	public bool CCCOKCGNEGO(PJHBHBBODGG JHEMNDMHNOB, PKBFCJOJFAD MCLCEMNNOFC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000298")]
	[Cpp2IlInjected.Address(RVA = "0x1D44990", Offset = "0x1D43D90", VA = "0x181D44990", Slot = "10")]
	public bool KFGNEKCHDAF(PJHBHBBODGG JHEMNDMHNOB, PKBFCJOJFAD MCLCEMNNOFC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000299")]
	[Cpp2IlInjected.Address(RVA = "0x1D449D0", Offset = "0x1D43DD0", VA = "0x181D449D0", Slot = "11")]
	public bool NDGCCALPIHJ(PJHBHBBODGG JHEMNDMHNOB, PKBFCJOJFAD MCLCEMNNOFC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600029A")]
	[Cpp2IlInjected.Address(RVA = "0x1D44900", Offset = "0x1D43D00", VA = "0x181D44900", Slot = "12")]
	public bool GPAAHBIPCMK(PJHBHBBODGG JHEMNDMHNOB, PKBFCJOJFAD MCLCEMNNOFC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600029B")]
	[Cpp2IlInjected.Address(RVA = "0x1D449F0", Offset = "0x1D43DF0", VA = "0x181D449F0", Slot = "13")]
	public bool OHGKELAKELP(PJHBHBBODGG JMAMNEHEBBI, PKBFCJOJFAD MCLCEMNNOFC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600029C")]
	[Cpp2IlInjected.Address(RVA = "0x1D44950", Offset = "0x1D43D50", VA = "0x181D44950", Slot = "14")]
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
		[Cpp2IlInjected.Address(RVA = "0x1D44280", Offset = "0x1D43680", VA = "0x181D44280", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x1D442D0", Offset = "0x1D436D0", VA = "0x181D442D0", Slot = "8")]
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
	[Cpp2IlInjected.Address(RVA = "0x7A4800", Offset = "0x7A3C00", VA = "0x1807A4800")]
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
		[Cpp2IlInjected.Token(Token = "0x40001B1")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001B2")]
		public AsyncTaskMethodBuilder<KKHLNMGODKL<object, MPIKAEBOCFI>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001B3")]
		public BNCBBPDHIMC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001B4")]
		public PKBFCJOJFAD action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001B5")]
		public bool clearBufferedRpcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001B6")]
		private TaskAwaiter<KKHLNMGODKL<object, MPIKAEBOCFI>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002AB")]
		[Cpp2IlInjected.Address(RVA = "0x1D43470", Offset = "0x1D42870", VA = "0x181D43470", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AC")]
		[Cpp2IlInjected.Address(RVA = "0x1D43710", Offset = "0x1D42B10", VA = "0x181D43710", Slot = "5")]
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
		[Cpp2IlInjected.Token(Token = "0x40001B7")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001B8")]
		public AsyncTaskMethodBuilder<KKHLNMGODKL<EPLJJHPILDK, MPIKAEBOCFI>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001B9")]
		public BNCBBPDHIMC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001BA")]
		public IReadOnlyList<PKBFCJOJFAD> actions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001BB")]
		public bool clearBufferedRpcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001BC")]
		private TaskAwaiter<KKHLNMGODKL<object, MPIKAEBOCFI>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002AD")]
		[Cpp2IlInjected.Address(RVA = "0x1D44D00", Offset = "0x1D44100", VA = "0x181D44D00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AE")]
		[Cpp2IlInjected.Address(RVA = "0x1D45080", Offset = "0x1D44480", VA = "0x181D45080", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001B0")]
	private readonly EDKKDEPLJLE JKHCKNDMHJK;

	[Cpp2IlInjected.Token(Token = "0x60002A8")]
	[Cpp2IlInjected.Address(RVA = "0x7ABBD0", Offset = "0x7AAFD0", VA = "0x1807ABBD0")]
	public BNCBBPDHIMC(EDKKDEPLJLE BIHMJDLLGLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A9")]
	[Cpp2IlInjected.Address(RVA = "0x1D41300", Offset = "0x1D40700", VA = "0x181D41300")]
	[AsyncStateMachine(typeof(EMHKNFOOFMG))]
	private Task<KKHLNMGODKL<object, MPIKAEBOCFI>> AOPGGACNBPB(PKBFCJOJFAD MCLCEMNNOFC, bool HPOBNPKLCBN = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002AA")]
	[Cpp2IlInjected.Address(RVA = "0x1D41430", Offset = "0x1D40830", VA = "0x181D41430", Slot = "4")]
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
	[Cpp2IlInjected.Token(Token = "0x40001BD")]
	internal MHCFONGEKFO<MECCDFBDFBI, PKBFCJOJFAD, KIGALKCCGCN> FADHFJMFNKI;

	[Cpp2IlInjected.Token(Token = "0x60002AF")]
	[Cpp2IlInjected.Address(RVA = "0x1D3B070", Offset = "0x1D3A470", VA = "0x181D3B070")]
	private OHAADPEAMDL([In] MHCFONGEKFO<MECCDFBDFBI, PKBFCJOJFAD, KIGALKCCGCN> BILGCBPECOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B0")]
	[Cpp2IlInjected.Address(RVA = "0x1D46950", Offset = "0x1D45D50", VA = "0x181D46950")]
	public static OHAADPEAMDL JKJFENIAMEL()
	{
		return default(OHAADPEAMDL);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000088")]
public static class DKLOGOGMIAK
{
	[Cpp2IlInjected.Token(Token = "0x60002B1")]
	[Cpp2IlInjected.Address(RVA = "0x86D430", Offset = "0x86C830", VA = "0x18086D430")]
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
	[Cpp2IlInjected.Address(RVA = "0x1D446D0", Offset = "0x1D43AD0", VA = "0x181D446D0", Slot = "5")]
	public PKBFCJOJFAD JJIDHPKBEDI(MECCDFBDFBI[] JKCGKOKJMJJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002B3")]
	[Cpp2IlInjected.Address(RVA = "0x1305790", Offset = "0x1304B90", VA = "0x181305790")]
	public int LEBDJEOHJEM([In] MECCDFBDFBI JHPHLKJCBPC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B4")]
	[Cpp2IlInjected.Address(RVA = "0x1305790", Offset = "0x1304B90", VA = "0x181305790", Slot = "4")]
	private int HBGLHPNENKN([In] MECCDFBDFBI DCPHEKAKJLP)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200008B")]
public struct NALNFODDAEP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001C0")]
	internal BOENFDIPHIP<PPGJNIDOJJF, PKBFCJOJFAD, NENOHMGKEMB> FADHFJMFNKI;

	[Cpp2IlInjected.Token(Token = "0x60002B8")]
	[Cpp2IlInjected.Address(RVA = "0x1D3B070", Offset = "0x1D3A470", VA = "0x181D3B070")]
	private NALNFODDAEP([In] BOENFDIPHIP<PPGJNIDOJJF, PKBFCJOJFAD, NENOHMGKEMB> OLNKKNMGCBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B9")]
	[Cpp2IlInjected.Address(RVA = "0x1D46700", Offset = "0x1D45B00", VA = "0x181D46700")]
	public static NALNFODDAEP JKJFENIAMEL()
	{
		return default(NALNFODDAEP);
	}
}
[Cpp2IlInjected.Token(Token = "0x200008C")]
public static class HFAIDPDMGDE
{
	[Cpp2IlInjected.Token(Token = "0x60002BA")]
	[Cpp2IlInjected.Address(RVA = "0x86D430", Offset = "0x86C830", VA = "0x18086D430")]
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
	[Cpp2IlInjected.Address(RVA = "0x1305790", Offset = "0x1304B90", VA = "0x181305790")]
	public int GMAGHOJLIEF([In] PPGJNIDOJJF JHPHLKJCBPC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BC")]
	[Cpp2IlInjected.Address(RVA = "0x1D46760", Offset = "0x1D45B60", VA = "0x181D46760", Slot = "5")]
	public PKBFCJOJFAD BDKDDDIGMIL(PPGJNIDOJJF[] OHCCAHIAAEL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002BD")]
	[Cpp2IlInjected.Address(RVA = "0x1305790", Offset = "0x1304B90", VA = "0x181305790", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x26E5530", Offset = "0x26E4930", VA = "0x1826E5530")]
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
		[Cpp2IlInjected.Token(Token = "0x40001C6")]
		public int MEJJBNBBHJJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001C7")]
		public HGAPEMBEHIA? MICBHMMHAEJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001C8")]
		public HGAPEMBEHIA? GOAJHCIHJKM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001C9")]
		public readonly List<PKBFCJOJFAD> GEKKCFAGEBB;

		[Cpp2IlInjected.Token(Token = "0x60002D5")]
		[Cpp2IlInjected.Address(RVA = "0x1D43840", Offset = "0x1D42C40", VA = "0x181D43840")]
		private FAJPFLODKHE(int OJANCMLFDOJ, HGAPEMBEHIA? KMNEGGDONJK, HGAPEMBEHIA? NPPJFAKMIBK, List<PKBFCJOJFAD> BDOEJBMENLB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D6")]
		[Cpp2IlInjected.Address(RVA = "0x1D43780", Offset = "0x1D42B80", VA = "0x181D43780")]
		public static FAJPFLODKHE JKJFENIAMEL()
		{
			return default(FAJPFLODKHE);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001C5")]
	private readonly IAGMEJPGGLG<FAJPFLODKHE> MLIIPKANEHN;

	[Cpp2IlInjected.Token(Token = "0x170000AE")]
	public static GHCDAODJGIM MEGHANKAOBP
	{
		[Cpp2IlInjected.Token(Token = "0x60002CD")]
		[Cpp2IlInjected.Address(RVA = "0x1D43890", Offset = "0x1D42C90", VA = "0x181D43890")]
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
		[Cpp2IlInjected.Address(RVA = "0x7EA420", Offset = "0x7E9820", VA = "0x1807EA420")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60002CF")]
		[Cpp2IlInjected.Address(RVA = "0x98D6C0", Offset = "0x98CAC0", VA = "0x18098D6C0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002D0")]
	[Cpp2IlInjected.Address(RVA = "0x1D43F20", Offset = "0x1D43320", VA = "0x181D43F20")]
	public void OALGIKAPGFC(KLLNHDMNECI NPPJFAKMIBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D1")]
	[Cpp2IlInjected.Address(RVA = "0x1D43C20", Offset = "0x1D43020", VA = "0x181D43C20")]
	public void NLDMOBIEIIB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D2")]
	[Cpp2IlInjected.Address(RVA = "0x1D438E0", Offset = "0x1D42CE0", VA = "0x181D438E0")]
	private static string? JOMJNALMAML([In] FAJPFLODKHE NMIDCKDPPMD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D3")]
	[Cpp2IlInjected.Address(RVA = "0x1D440E0", Offset = "0x1D434E0", VA = "0x181D440E0")]
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
