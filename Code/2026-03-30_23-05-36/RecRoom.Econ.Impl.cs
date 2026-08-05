using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Circuits.Shared.Api;
using Cpp2IlInjected;
using Microsoft.CodeAnalysis;
using RecRoom.Econ.Abstractions;
using RecRoom.Econ.Abstractions.Error;
using RecRoom.NoEngine.Common;
using RecRoom.NoEngine.DataStructures;

[assembly: AssemblyVersion("0.0.0.0")]
namespace Microsoft.CodeAnalysis
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class EmbeddedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0xAF1770", Offset = "0xAF0570", VA = "0x180AF1770")]
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
		[Cpp2IlInjected.Address(RVA = "0x84F9B20", Offset = "0x84F8920", VA = "0x1884F9B20")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xAF1800", Offset = "0xAF0600", VA = "0x180AF1800")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xAF1840", Offset = "0xAF0640", VA = "0x180AF1840")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
namespace RecRoom.Econ.Impl
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public sealed class TDMPSAOIMEP : WMPLNHWRFMG
	{
		[Cpp2IlInjected.Token(Token = "0x2000006")]
		internal sealed class GNVLXBHUJNX : WMPLNHWRFMG.AZZDWMUNVDC, IEconErr
		{
			[Cpp2IlInjected.Token(Token = "0x17000001")]
			public int IXIQMNSLVYR
			{
				[Cpp2IlInjected.Token(Token = "0x600000B")]
				[Cpp2IlInjected.Address(RVA = "0xAC6110", Offset = "0xAC4F10", VA = "0x180AC6110", Slot = "4")]
				[CompilerGenerated]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0xAC9210", Offset = "0xAC8010", VA = "0x180AC9210")]
			public GNVLXBHUJNX(int a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000007")]
		internal sealed class JTNEEQBRBXT : WMPLNHWRFMG.UAWVHEOFZNE, IEconErr
		{
			[Cpp2IlInjected.Token(Token = "0x17000002")]
			public long SVQOUBYGYBC
			{
				[Cpp2IlInjected.Token(Token = "0x600000D")]
				[Cpp2IlInjected.Address(RVA = "0xACA860", Offset = "0xAC9660", VA = "0x180ACA860", Slot = "4")]
				[CompilerGenerated]
				get
				{
					return default(long);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000003")]
			public string UQOPWXCXGEO
			{
				[Cpp2IlInjected.Token(Token = "0x600000E")]
				[Cpp2IlInjected.Address(RVA = "0xAC91C0", Offset = "0xAC7FC0", VA = "0x180AC91C0", Slot = "5")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x4F2A5E0", Offset = "0x4F293E0", VA = "0x184F2A5E0")]
			public JTNEEQBRBXT(long a, string b)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		[CompilerGenerated]
		private struct <CheckoutGiftAsync>d__8 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000007")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000008")]
			public AsyncTaskMethodBuilder<Result<None, IEconErr>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000009")]
			public WMPLNHWRFMG.RFFGDHPIYRX deps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400000A")]
			public TDMPSAOIMEP <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400000B")]
			private Result<None, IEconErr> <r>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400000C")]
			private Id32<NIUKUHVMCZI>[] <recipients>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400000D")]
			private TaskAwaiter<Result<None, IEconErr>> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x400000E")]
			private TaskAwaiter<Result<Id32<NIUKUHVMCZI>[], IEconErr>> <>u__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x400000F")]
			private TaskAwaiter<Result<int, IEconErr>> <>u__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x4000010")]
			private TaskAwaiter <>u__4;

			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x84FA1E0", Offset = "0x84F8FE0", VA = "0x1884FA1E0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x84FAD90", Offset = "0x84F9B90", VA = "0x1884FAD90", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000009")]
		[CompilerGenerated]
		private struct <CheckoutGiftWithReportingAsync>d__9 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000011")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000012")]
			public AsyncTaskMethodBuilder<Result<None, IEconErr>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000013")]
			public TDMPSAOIMEP <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000014")]
			public WMPLNHWRFMG.NXXGYODVVJX deps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000015")]
			private object <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			private Result<None, IEconErr> <checkoutGiftAsyncRes>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			private TaskAwaiter<Result<None, IEconErr>> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			private TaskAwaiter <>u__2;

			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x84FAE00", Offset = "0x84F9C00", VA = "0x1884FAE00", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x84FB720", Offset = "0x84FA520", VA = "0x1884FB720", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000003")]
		public static readonly WMPLNHWRFMG PKFRARWZTTR;

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0xACC5C0", Offset = "0xACB3C0", VA = "0x180ACC5C0")]
		private TDMPSAOIMEP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x84F9BA0", Offset = "0x84F89A0", VA = "0x1884F9BA0", Slot = "6")]
		public Result<None, WMPLNHWRFMG.AZZDWMUNVDC> KHEDEUVLFOC(WMPLNHWRFMG.ZGLWDPIKZLN a)
		{
			return default(Result<None, WMPLNHWRFMG.AZZDWMUNVDC>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x84F9CB0", Offset = "0x84F8AB0", VA = "0x1884F9CB0", Slot = "5")]
		public Result<None, WMPLNHWRFMG.UAWVHEOFZNE> KZFCUVRHGDU(WMPLNHWRFMG.ZLHXRCUTKFT a)
		{
			return default(Result<None, WMPLNHWRFMG.UAWVHEOFZNE>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x84FA030", Offset = "0x84F8E30", VA = "0x1884FA030", Slot = "7")]
		[AsyncStateMachine(typeof(<CheckoutGiftAsync>d__8))]
		public Task<Result<None, IEconErr>> RHEYSVIRUVM(WMPLNHWRFMG.RFFGDHPIYRX a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x84F9F00", Offset = "0x84F8D00", VA = "0x1884F9F00", Slot = "4")]
		[AsyncStateMachine(typeof(<CheckoutGiftWithReportingAsync>d__9))]
		public Task<Result<None, IEconErr>> QOQOWXXNOUY(WMPLNHWRFMG.NXXGYODVVJX a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public readonly struct EconOperationCanceledErr : FFWLHVDQDZF, IEconErr
	{
		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public string Message
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0xC9F850", Offset = "0xC9E650", VA = "0x180C9F850", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0xEB4670", Offset = "0xEB3470", VA = "0x180EB4670")]
		public EconOperationCanceledErr(string message, OperationCanceledException exception)
		{
		}
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
