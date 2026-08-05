using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Circuits.Shared.Api;
using Cpp2IlInjected;
using Microsoft.CodeAnalysis;
using RecRoom.NoEngine.Common;
using RecRoom.NoEngine.DataStructures.Performance;

[assembly: AssemblyVersion("0.0.0.0")]
namespace Microsoft.CodeAnalysis
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class EmbeddedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0xD341B0", Offset = "0xD32BB0", VA = "0x180D341B0")]
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
		[Cpp2IlInjected.Address(RVA = "0x2B91E70", Offset = "0x2B90870", VA = "0x182B91E70")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xD34A80", Offset = "0xD33480", VA = "0x180D34A80")]
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
		[Cpp2IlInjected.Address(RVA = "0xD34AC0", Offset = "0xD334C0", VA = "0x180D34AC0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
namespace Circuits.Shared.Core.ByteCode
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public static class ESSANMMATEX
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x397A8D0", Offset = "0x39792D0", VA = "0x18397A8D0")]
		public static Id32<TVAMPUAMYRD<a>> QADLEDHWMTB<a>(this int a)
		{
			return default(Id32<TVAMPUAMYRD<a>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x2B8BDC0", Offset = "0x2B8A7C0", VA = "0x182B8BDC0")]
		public static Id32<AUNNIJUAVXE> PIFYEWNPSKE(this int a)
		{
			return default(Id32<AUNNIJUAVXE>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x397A8D0", Offset = "0x39792D0", VA = "0x18397A8D0")]
		public static Id32<XSPVEGMZPQH<b>> EXOJWMCIYWF<b>(this int a)
		{
			return default(Id32<XSPVEGMZPQH<b>>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public sealed class TVAMPUAMYRD<a>
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public sealed class GQNEASXRVOC
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public sealed class VFMZCREDNZR
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public sealed class AUNNIJUAVXE
	{
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public sealed class NODNFPCIRRW
	{
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public sealed class GKVHHRWJLQS
	{
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public enum Op
	{
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		AddF32_F32i_F32i_F32r,
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		AddF32_F32i_F32r_F32r,
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		AddF32_F32r_F32r_F32r,
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		AddI32_I32i_I32i_I32r,
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		AddI32_I32i_I32r_I32r,
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		AddI32_I32r_I32r_I32r,
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		AndI32_I32i_I32i_I32r,
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		AndI32_I32i_I32r_I32r,
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		AndI32_I32r_I32r_I32r,
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		BranchIfEqualF32_F32i_F32i_I32i,
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		BranchIfEqualF32_F32i_F32r_I32i,
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		BranchIfEqualF32_F32r_F32r_I32i,
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		BranchIfEqualI32_I32i_I32i_I32i,
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		BranchIfEqualI32_I32i_I32r_I32i,
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		BranchIfEqualI32_I32r_I32r_I32i,
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		BranchIfGreaterF32_F32i_F32i_I32i,
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		BranchIfGreaterF32_F32i_F32r_I32i,
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		BranchIfGreaterF32_F32r_F32r_I32i,
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		BranchIfGreaterI32_I32i_I32i_I32i,
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		BranchIfGreaterI32_I32i_I32r_I32i,
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		BranchIfGreaterI32_I32r_I32r_I32i,
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		BranchIfGreaterOrEqualF32_F32i_F32i_I32i,
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		BranchIfGreaterOrEqualF32_F32i_F32r_I32i,
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		BranchIfGreaterOrEqualF32_F32r_F32r_I32i,
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		BranchIfGreaterOrEqualI32_I32i_I32i_I32i,
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		BranchIfGreaterOrEqualI32_I32i_I32r_I32i,
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		BranchIfGreaterOrEqualI32_I32r_I32r_I32i,
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		BranchIfLessF32_F32i_F32i_I32i,
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		BranchIfLessF32_F32i_F32r_I32i,
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		BranchIfLessF32_F32r_F32r_I32i,
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		BranchIfLessI32_I32i_I32i_I32i,
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		BranchIfLessI32_I32i_I32r_I32i,
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		BranchIfLessI32_I32r_I32r_I32i,
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		BranchIfLessOrEqualF32_F32i_F32i_I32i,
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		BranchIfLessOrEqualF32_F32i_F32r_I32i,
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		BranchIfLessOrEqualF32_F32r_F32r_I32i,
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		BranchIfLessOrEqualI32_I32i_I32i_I32i,
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		BranchIfLessOrEqualI32_I32i_I32r_I32i,
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		BranchIfLessOrEqualI32_I32r_I32r_I32i,
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		BranchIfNotEqualF32_F32i_F32i_I32i,
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		BranchIfNotEqualF32_F32i_F32r_I32i,
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		BranchIfNotEqualF32_F32r_F32r_I32i,
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		BranchIfNotEqualI32_I32i_I32i_I32i,
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		BranchIfNotEqualI32_I32i_I32r_I32i,
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		BranchIfNotEqualI32_I32r_I32r_I32i,
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		BranchIfNotZeroF32_F32i_I32i,
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		BranchIfNotZeroF32_F32r_I32i,
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		BranchIfNotZeroI32_I32i_I32i,
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		BranchIfNotZeroI32_I32r_I32i,
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		BranchIfZeroF32_F32i_I32i,
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		BranchIfZeroF32_F32r_I32i,
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		BranchIfZeroI32_I32i_I32i,
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		BranchIfZeroI32_I32r_I32i,
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		CallInternal_I32i_I32i,
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		CallInternal_I32i_I32r,
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		CallExternal_I32i_I32i,
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		CallExternal_I32i_I32r,
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		CallRuntime_I32i_I32i_Xi,
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		CopyI32_I32i_I32r,
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		CopyI32_I32r_I32r,
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		CopyX_Xr_I32i_Xi,
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		CopyX_Xr_Xr_I32i,
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		DivideF32_F32i_F32i_F32r,
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		DivideF32_F32i_F32r_F32r,
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		DivideF32_F32r_F32r_F32r,
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		DivideI32_I32i_I32i_I32r,
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		DivideI32_I32i_I32r_I32r,
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		DivideI32_I32r_I32r_I32r,
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		EqualF32_F32i_F32i_I32r,
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		EqualF32_F32i_F32r_I32r,
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		EqualF32_F32r_F32r_I32r,
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		EqualI32_I32i_I32i_I32r,
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		EqualI32_I32i_I32r_I32r,
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		EqualI32_I32r_I32r_I32r,
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		End,
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		GreaterF32_F32i_F32i_I32r,
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		GreaterF32_F32i_F32r_I32r,
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		GreaterF32_F32r_F32r_I32r,
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		GreaterI32_I32i_I32i_I32r,
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		GreaterI32_I32i_I32r_I32r,
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		GreaterI32_I32r_I32r_I32r,
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		GreaterOrEqualF32_F32i_F32i_I32r,
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		GreaterOrEqualF32_F32i_F32r_I32r,
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		GreaterOrEqualF32_F32r_F32r_I32r,
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		GreaterOrEqualI32_I32i_I32i_I32r,
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		GreaterOrEqualI32_I32i_I32r_I32r,
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		GreaterOrEqualI32_I32r_I32r_I32r,
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		Jump_I32i,
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		Jump_I32r,
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		LessF32_F32i_F32i_I32r,
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		LessF32_F32i_F32r_I32r,
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		LessF32_F32r_F32r_I32r,
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		LessI32_I32i_I32i_I32r,
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		LessI32_I32i_I32r_I32r,
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		LessI32_I32r_I32r_I32r,
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		LessOrEqualF32_F32i_F32i_I32r,
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		LessOrEqualF32_F32i_F32r_I32r,
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		LessOrEqualF32_F32r_F32r_I32r,
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		LessOrEqualI32_I32i_I32i_I32r,
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		LessOrEqualI32_I32i_I32r_I32r,
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		LessOrEqualI32_I32r_I32r_I32r,
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		ModI32_I32i_I32i_I32r,
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		ModI32_I32i_I32r_I32r,
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		ModI32_I32r_I32r_I32r,
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		MultiplyF32_F32i_F32i_F32r,
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		MultiplyF32_F32i_F32r_F32r,
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		MultiplyF32_F32r_F32r_F32r,
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		MultiplyI32_I32i_I32i_I32r,
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		MultiplyI32_I32i_I32r_I32r,
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		MultiplyI32_I32r_I32r_I32r,
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		NegateF32_F32i_F32r,
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		NegateF32_F32r,
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		NegateF32_F32r_F32r,
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		NegateI32_I32i_I32r,
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		NegateI32_I32r,
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		NegateI32_I32r_I32r,
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		NoOp,
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		NotEqualF32_F32i_F32i_I32r,
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		NotEqualF32_F32i_F32r_I32r,
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		NotEqualF32_F32r_F32r_I32r,
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		NotEqualI32_I32i_I32i_I32r,
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		NotEqualI32_I32i_I32r_I32r,
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		NotEqualI32_I32r_I32r_I32r,
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		NotI32_I32r,
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		NotI32_I32i_I32r,
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		NotI32_I32r_I32r,
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		OrI32_I32i_I32i_I32r,
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		OrI32_I32i_I32r_I32r,
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		OrI32_I32r_I32r_I32r,
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		Return,
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		StaticCastF32I32_F32r_I32r,
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		StaticCastI32F32_I32r_F32r,
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		SubtractF32_F32i_F32i_F32r,
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		SubtractF32_F32i_F32r_F32r,
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		SubtractF32_F32r_F32r_F32r,
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		SubtractI32_I32i_I32i_I32r,
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		SubtractI32_I32i_I32r_I32r,
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		SubtractI32_I32r_I32r_I32r,
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		XorI32_I32i_I32i_I32r,
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		XorI32_I32i_I32r_I32r,
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		XorI32_I32r_I32r_I32r
	}
}
namespace Circuits.Shared.Core.ByteCode.IO
{
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public static class VJGUIMINNZP
	{
		[Cpp2IlInjected.Token(Token = "0x200000E")]
		public readonly struct ProcessOpDelegate<TContext, TDeps, TCompileState>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000091")]
			private readonly IntPtr _impl;

			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0xEF0480", Offset = "0xEEEE80", VA = "0x180EF0480")]
			public ProcessOpDelegate(IntPtr impl)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x7715B40", Offset = "0x7714540", VA = "0x187715B40")]
			public int Invoke(TDeps deps, TContext ctx, TCompileState compileState, [In] UnsafeList<byte> fromByteCode, int byteCodePtr)
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x40D3050", Offset = "0x40D1A50", VA = "0x1840D3050")]
		public static void XUPHFYVGNDY<TDeps, TContext, TCompileState>(TDeps a, TContext b, TCompileState c, [In] UnsafeList<byte> oldByteCode, UnsafeList<byte> newByteCode, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processAddF32_F32i_F32i_F32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processAddF32_F32i_F32r_F32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processAddF32_F32r_F32r_F32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processAddI32_I32i_I32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processAddI32_I32i_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processAddI32_I32r_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processAndI32_I32i_I32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processAndI32_I32i_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processAndI32_I32r_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfEqualF32_F32i_F32i_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfEqualF32_F32i_F32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfEqualF32_F32r_F32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfEqualI32_I32i_I32i_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfEqualI32_I32i_I32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfEqualI32_I32r_I32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfGreaterOrEqualF32_F32i_F32i_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfGreaterOrEqualF32_F32i_F32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfGreaterOrEqualF32_F32r_F32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfGreaterOrEqualI32_I32i_I32i_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfGreaterOrEqualI32_I32i_I32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfGreaterOrEqualI32_I32r_I32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfLessF32_F32i_F32i_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfLessF32_F32i_F32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfLessF32_F32r_F32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfLessI32_I32i_I32i_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfLessI32_I32i_I32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfLessI32_I32r_I32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfLessOrEqualF32_F32i_F32i_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfLessOrEqualF32_F32i_F32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfLessOrEqualF32_F32r_F32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfLessOrEqualI32_I32i_I32i_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfLessOrEqualI32_I32i_I32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfLessOrEqualI32_I32r_I32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfNotEqualF32_F32i_F32i_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfNotEqualF32_F32i_F32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfNotEqualF32_F32r_F32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfNotEqualI32_I32i_I32i_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfNotEqualI32_I32i_I32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfNotEqualI32_I32r_I32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfNotZeroF32_F32i_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfNotZeroF32_F32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfNotZeroI32_I32i_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfNotZeroI32_I32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfZeroF32_F32i_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfZeroF32_F32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfZeroI32_I32i_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfZeroI32_I32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processCallInternal_I32i_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processCallInternal_I32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processCallExternal_I32i_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processCallExternal_I32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processCallRuntime_I32i_I32i_Xi, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processCopyI32_I32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processCopyI32_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processCopyX_Xr_I32i_Xi, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processCopyX_Xr_Xr_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processDivideF32_F32i_F32i_F32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processDivideF32_F32i_F32r_F32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processDivideF32_F32r_F32r_F32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processDivideI32_I32i_I32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processDivideI32_I32i_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processDivideI32_I32r_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processEqualF32_F32i_F32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processEqualF32_F32i_F32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processEqualF32_F32r_F32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processEqualI32_I32i_I32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processEqualI32_I32i_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processEqualI32_I32r_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processEnd, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processGreaterF32_F32i_F32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processGreaterF32_F32i_F32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processGreaterF32_F32r_F32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processGreaterI32_I32i_I32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processGreaterI32_I32i_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processGreaterI32_I32r_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processGreaterOrEqualF32_F32i_F32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processGreaterOrEqualF32_F32i_F32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processGreaterOrEqualF32_F32r_F32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processGreaterOrEqualI32_I32i_I32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processGreaterOrEqualI32_I32i_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processGreaterOrEqualI32_I32r_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processJump_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processJump_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processLessF32_F32i_F32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processLessF32_F32i_F32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processLessF32_F32r_F32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processLessI32_I32i_I32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processLessI32_I32i_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processLessI32_I32r_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processLessOrEqualF32_F32i_F32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processLessOrEqualF32_F32i_F32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processLessOrEqualF32_F32r_F32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processLessOrEqualI32_I32i_I32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processLessOrEqualI32_I32i_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processLessOrEqualI32_I32r_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processModI32_I32i_I32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processModI32_I32i_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processModI32_I32r_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processMultiplyF32_F32i_F32i_F32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processMultiplyF32_F32i_F32r_F32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processMultiplyF32_F32r_F32r_F32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processMultiplyI32_I32i_I32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processMultiplyI32_I32i_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processMultiplyI32_I32r_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processNegateF32_F32i_F32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processNegateF32_F32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processNegateF32_F32r_F32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processNegateI32_I32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processNegateI32_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processNegateI32_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processNoOp, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processNotEqualF32_F32i_F32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processNotEqualF32_F32i_F32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processNotEqualF32_F32r_F32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processNotEqualI32_I32i_I32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processNotEqualI32_I32i_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processNotEqualI32_I32r_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processNotI32_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processNotI32_I32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processNotI32_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processOrI32_I32i_I32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processOrI32_I32i_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processOrI32_I32r_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processReturn, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processStaticCastF32I32_F32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processStaticCastI32F32_I32r_F32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processSubtractF32_F32i_F32i_F32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processSubtractF32_F32i_F32r_F32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processSubtractF32_F32r_F32r_F32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processSubtractI32_I32i_I32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processSubtractI32_I32i_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processSubtractI32_I32r_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processXorI32_I32i_I32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processXorI32_I32i_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processXorI32_I32r_I32r_I32r) where TDeps : notnull where TContext : notnull where TCompileState : notnull
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x2B92000", Offset = "0x2B90A00", VA = "0x182B92000")]
		private static int COFHVNHPNOY([In] UnsafeList<byte> from, UnsafeList<byte> a, int b, int c)
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public static class NVDTRZUIQHG
	{
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		public static readonly int LCEZMPWVQMC;

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x3D3D480", Offset = "0x3D3BE80", VA = "0x183D3D480")]
		public static Id32<TVAMPUAMYRD<a>> LXWHBGNYOWE<a>([In] this UnsafeList<byte> self)
		{
			return default(Id32<TVAMPUAMYRD<a>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x3D3D350", Offset = "0x3D3BD50", VA = "0x183D3D350")]
		public static Id32<TVAMPUAMYRD<TVAMPUAMYRD<b>>> BVONTSKDQDZ<b>(this UnsafeList<byte> a, [Optional] Id32<TVAMPUAMYRD<b>>? b)
		{
			return default(Id32<TVAMPUAMYRD<TVAMPUAMYRD<b>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x2B91B60", Offset = "0x2B90560", VA = "0x182B91B60")]
		public static Id32<TVAMPUAMYRD<JIFIDYBYJAI>> UUEIOETTQUT(this UnsafeList<byte> a, [Optional] Id32<JIFIDYBYJAI>? b)
		{
			return default(Id32<TVAMPUAMYRD<JIFIDYBYJAI>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x2B918A0", Offset = "0x2B902A0", VA = "0x182B918A0")]
		public static Id32<TVAMPUAMYRD<GQNEASXRVOC>> IKTTJILTUMX(this UnsafeList<byte> a, [Optional] float? b)
		{
			return default(Id32<TVAMPUAMYRD<GQNEASXRVOC>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x2B91A80", Offset = "0x2B90480", VA = "0x182B91A80")]
		public static Id32<TVAMPUAMYRD<VFMZCREDNZR>> TVTYHKFICBI(this UnsafeList<byte> a, [Optional] int? b)
		{
			return default(Id32<TVAMPUAMYRD<VFMZCREDNZR>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x2B91D40", Offset = "0x2B90740", VA = "0x182B91D40")]
		public static Id32<TVAMPUAMYRD<PLGQQUCWUUF>> ZZHAFNCMFPG(this UnsafeList<byte> a, [Optional] Id32<PLGQQUCWUUF>? b)
		{
			return default(Id32<TVAMPUAMYRD<PLGQQUCWUUF>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x2B917A0", Offset = "0x2B901A0", VA = "0x182B917A0")]
		public static Id32<TVAMPUAMYRD<GKVHHRWJLQS>> FCXKAVSKYTD(this UnsafeList<byte> a, [Optional] byte? b)
		{
			return default(Id32<TVAMPUAMYRD<GKVHHRWJLQS>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x2B91C50", Offset = "0x2B90650", VA = "0x182B91C50")]
		public static Id32<TVAMPUAMYRD<AUNNIJUAVXE>> WFNAGZRROGF(this UnsafeList<byte> a, [Optional] Id32<AUNNIJUAVXE>? b)
		{
			return default(Id32<TVAMPUAMYRD<AUNNIJUAVXE>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x2B91990", Offset = "0x2B90390", VA = "0x182B91990")]
		public static Id32<TVAMPUAMYRD<NODNFPCIRRW>> QQRNOVDXSTV(this UnsafeList<byte> a, [Optional] Op? b)
		{
			return default(Id32<TVAMPUAMYRD<NODNFPCIRRW>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x3D3D350", Offset = "0x3D3BD50", VA = "0x183D3D350")]
		public static Id32<TVAMPUAMYRD<XSPVEGMZPQH<c>>> DERGYOMJTAN<c>(this UnsafeList<byte> a, [Optional] Id32<XSPVEGMZPQH<c>>? b)
		{
			return default(Id32<TVAMPUAMYRD<XSPVEGMZPQH<c>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x2B8BCC0", Offset = "0x2B8A6C0", VA = "0x182B8BCC0")]
		public static void IFOSWBJTEEP(this UnsafeList<byte> a, Id32<TVAMPUAMYRD<VFMZCREDNZR>> b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x3D3D250", Offset = "0x3D3BC50", VA = "0x183D3D250")]
		public static void CHJBOCQADEO<d>(this UnsafeList<byte> a, Id32<TVAMPUAMYRD<TVAMPUAMYRD<d>>> b, Id32<TVAMPUAMYRD<d>> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x3D3D250", Offset = "0x3D3BC50", VA = "0x183D3D250")]
		public static void BURGHWQAZFK<e>(this UnsafeList<byte> a, Id32<TVAMPUAMYRD<XSPVEGMZPQH<e>>> b, Id32<XSPVEGMZPQH<e>> c)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public static class OIFGQWXAVQN
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x2B91EF0", Offset = "0x2B908F0", VA = "0x182B91EF0")]
		public static Union32 FMECMLZDOLD([In] this ReadOnlySpan<byte> bytes, int a)
		{
			return default(Union32);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x2B91F60", Offset = "0x2B90960", VA = "0x182B91F60")]
		public static Union32 FMECMLZDOLD([In] this UnsafeList<byte> bytes, int a)
		{
			return default(Union32);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x3D69350", Offset = "0x3D67D50", VA = "0x183D69350")]
		public static Union32 FMECMLZDOLD<f>(this ReadOnlyIdArray<f, byte> a, Id32<f> b)
		{
			return default(Union32);
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x3D69590", Offset = "0x3D67F90", VA = "0x183D69590")]
		public static Union32 FMECMLZDOLD<g>([In] this ReadOnlyIdSpan<g, byte> bytes, Id32<g> a)
		{
			return default(Union32);
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x3D69780", Offset = "0x3D68180", VA = "0x183D69780")]
		public static Union32 FMECMLZDOLD<i>(this IdArray<i, byte> a, Id32<i> b)
		{
			return default(Union32);
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x3D69710", Offset = "0x3D68110", VA = "0x183D69710")]
		public static Union32 FMECMLZDOLD<j>([In] this IdSpan<j, byte> bytes, Id32<j> a)
		{
			return default(Union32);
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x3D694D0", Offset = "0x3D67ED0", VA = "0x183D694D0")]
		public static Union32 FMECMLZDOLD<k>(this ReadOnlyIdArray<k, byte> a, Id32<k> b)
		{
			return default(Union32);
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x2B91EF0", Offset = "0x2B908F0", VA = "0x182B91EF0")]
		public static int KAJWUAPOHBQ([In] this ReadOnlySpan<byte> bytes, int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x2B8BCB0", Offset = "0x2B8A6B0", VA = "0x182B8BCB0")]
		public static int KAJWUAPOHBQ([In] this UnsafeList<byte> bytes, int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x3D69C30", Offset = "0x3D68630", VA = "0x183D69C30")]
		public static int KAJWUAPOHBQ<p>(this ReadOnlyIdArray<p, byte> a, Id32<p> b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x3D69B60", Offset = "0x3D68560", VA = "0x183D69B60")]
		public static int KAJWUAPOHBQ<s>(this IdArray<s, byte> a, Id32<s> b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x3D69BE0", Offset = "0x3D685E0", VA = "0x183D69BE0")]
		public static int KAJWUAPOHBQ<t>([In] this IdSpan<t, byte> bytes, Id32<t> a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x3D69B10", Offset = "0x3D68510", VA = "0x183D69B10")]
		public static int KAJWUAPOHBQ<u>(this ReadOnlyIdArray<u, byte> a, Id32<u> b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x3D69950", Offset = "0x3D68350", VA = "0x183D69950")]
		public static float HMOVBRYNKGP<bc>(this IdArray<bc, byte> a, Id32<bc> b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x3D699D0", Offset = "0x3D683D0", VA = "0x183D699D0")]
		public static float HMOVBRYNKGP<bd>([In] this IdSpan<bd, byte> bytes, Id32<bd> a)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x3D69900", Offset = "0x3D68300", VA = "0x183D69900")]
		public static float HMOVBRYNKGP<be>(this ReadOnlyIdArray<be, byte> a, Id32<be> b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x3D6A6D0", Offset = "0x3D690D0", VA = "0x183D6A6D0")]
		public static byte YUSHZBKPKRD<bj>(this ReadOnlyIdArray<bj, byte> a, Id32<bj> b)
		{
			return default(byte);
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x3D6A680", Offset = "0x3D69080", VA = "0x183D6A680")]
		public static byte YUSHZBKPKRD<bk>([In] this ReadOnlyIdSpan<bk, byte> bytes, Id32<bk> a)
		{
			return default(byte);
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x3D6A600", Offset = "0x3D69000", VA = "0x183D6A600")]
		public static byte YUSHZBKPKRD<bm>(this IdArray<bm, byte> a, Id32<bm> b)
		{
			return default(byte);
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x3D6A570", Offset = "0x3D68F70", VA = "0x183D6A570")]
		public static byte YUSHZBKPKRD<bn>([In] this IdSpan<bn, byte> bytes, Id32<bn> a)
		{
			return default(byte);
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x3D6A720", Offset = "0x3D69120", VA = "0x183D6A720")]
		public static byte YUSHZBKPKRD<bo>(this ReadOnlyIdArray<bo, byte> a, Id32<bo> b)
		{
			return default(byte);
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x2B8BCB0", Offset = "0x2B8A6B0", VA = "0x182B8BCB0")]
		public static Op OZWFHKMJQNF([In] this UnsafeList<byte> bytes, int a)
		{
			return default(Op);
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x3D69EA0", Offset = "0x3D688A0", VA = "0x183D69EA0")]
		public static Op OZWFHKMJQNF<by>(this ReadOnlyIdArray<by, byte> a, Id32<by> b)
		{
			return default(Op);
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x3D6A080", Offset = "0x3D68A80", VA = "0x183D6A080")]
		public static Id32<TVAMPUAMYRD<RTIMFYESSKP>> PRMECUQLQYD<cg>(this IdArray<cg, byte> a, Id32<cg> b)
		{
			return default(Id32<TVAMPUAMYRD<RTIMFYESSKP>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x3D6A190", Offset = "0x3D68B90", VA = "0x183D6A190")]
		public static Id32<TVAMPUAMYRD<RTIMFYESSKP>> PRMECUQLQYD<ch>([In] this IdSpan<ch, byte> bytes, Id32<ch> a)
		{
			return default(Id32<TVAMPUAMYRD<RTIMFYESSKP>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x3D6A100", Offset = "0x3D68B00", VA = "0x183D6A100")]
		public static Id32<TVAMPUAMYRD<RTIMFYESSKP>> PRMECUQLQYD<ci>(this ReadOnlyIdArray<ci, byte> a, Id32<ci> b)
		{
			return default(Id32<TVAMPUAMYRD<RTIMFYESSKP>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x3D6A3B0", Offset = "0x3D68DB0", VA = "0x183D6A3B0")]
		public static Id32<XSPVEGMZPQH<RTIMFYESSKP>> SZHOWNRNHZX<cs>(this ReadOnlyIdArray<cs, byte> a, Id32<cs> b)
		{
			return default(Id32<XSPVEGMZPQH<RTIMFYESSKP>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x3D68DE0", Offset = "0x3D677E0", VA = "0x183D68DE0")]
		public static Id32<AUNNIJUAVXE> CQVWMTYUIPH<da>(this IdArray<da, byte> a, Id32<da> b)
		{
			return default(Id32<AUNNIJUAVXE>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x3D68E60", Offset = "0x3D67860", VA = "0x183D68E60")]
		public static Id32<AUNNIJUAVXE> CQVWMTYUIPH<db>([In] this IdSpan<db, byte> bytes, Id32<db> a)
		{
			return default(Id32<AUNNIJUAVXE>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x3D68EF0", Offset = "0x3D678F0", VA = "0x183D68EF0")]
		public static Id32<AUNNIJUAVXE> CQVWMTYUIPH<dc>(this ReadOnlyIdArray<dc, byte> a, Id32<dc> b)
		{
			return default(Id32<AUNNIJUAVXE>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x3D69E10", Offset = "0x3D68810", VA = "0x183D69E10")]
		public static Id32<JIFIDYBYJAI> OCTCKIRDOCH<dl>([In] this IdSpan<dl, byte> bytes, Id32<dl> a)
		{
			return default(Id32<JIFIDYBYJAI>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x3D69D80", Offset = "0x3D68780", VA = "0x183D69D80")]
		public static Id32<JIFIDYBYJAI> OCTCKIRDOCH<dm>(this ReadOnlyIdArray<dm, byte> a, Id32<dm> b)
		{
			return default(Id32<JIFIDYBYJAI>);
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x3D6A2A0", Offset = "0x3D68CA0", VA = "0x183D6A2A0")]
		public static Id32<PLGQQUCWUUF> QLFBMRHHALE<dw>(this ReadOnlyIdArray<dw, byte> a, Id32<dw> b)
		{
			return default(Id32<PLGQQUCWUUF>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public static class XPAONVDHOEZ
	{
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x2B922D0", Offset = "0x2B90CD0", VA = "0x182B922D0")]
		public static void RMBHUITCBEQ(this UnsafeList<byte> a, int b, Union32 c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x2B92390", Offset = "0x2B90D90", VA = "0x182B92390")]
		public static void RMBHUITCBEQ(this byte[] a, int b, Union32 c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x2B92250", Offset = "0x2B90C50", VA = "0x182B92250")]
		public static void RMBHUITCBEQ([In] this Span<byte> bytes, int a, Union32 b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x412DC20", Offset = "0x412C620", VA = "0x18412DC20")]
		public static void RMBHUITCBEQ<e>(this IdArray<e, byte> a, Id32<e> b, Union32 c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x412DAD0", Offset = "0x412C4D0", VA = "0x18412DAD0")]
		public static void RMBHUITCBEQ<f>([In] this IdSpan<f, byte> bytes, Id32<f> a, Union32 b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x2B8BCC0", Offset = "0x2B8A6C0", VA = "0x182B8BCC0")]
		public static void IFOSWBJTEEP(this UnsafeList<byte> a, int b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x2B92120", Offset = "0x2B90B20", VA = "0x182B92120")]
		public static void IFOSWBJTEEP(this byte[] a, int b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x2B920A0", Offset = "0x2B90AA0", VA = "0x182B920A0")]
		public static void IFOSWBJTEEP([In] this Span<byte> bytes, int a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x412D550", Offset = "0x412BF50", VA = "0x18412D550")]
		public static void IFOSWBJTEEP<h>(this IdArray<h, byte> a, Id32<h> b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x412D4F0", Offset = "0x412BEF0", VA = "0x18412D4F0")]
		public static void IFOSWBJTEEP<i>([In] this IdSpan<i, byte> bytes, Id32<i> a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x2B921A0", Offset = "0x2B90BA0", VA = "0x182B921A0")]
		public static void NDEUYIQQDPA(this UnsafeList<byte> a, int b, float c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x412D700", Offset = "0x412C100", VA = "0x18412D700")]
		public static void NDEUYIQQDPA<k>(this IdArray<k, byte> a, Id32<k> b, float c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x412D690", Offset = "0x412C090", VA = "0x18412D690")]
		public static void NDEUYIQQDPA<l>([In] this IdSpan<l, byte> bytes, Id32<l> a, float b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x2B921E0", Offset = "0x2B90BE0", VA = "0x182B921E0")]
		public static void QWUNCAJUKWK(this UnsafeList<byte> a, int b, byte c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x412D880", Offset = "0x412C280", VA = "0x18412D880")]
		public static void QWUNCAJUKWK<n>(this IdArray<n, byte> a, Id32<n> b, byte c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x412D820", Offset = "0x412C220", VA = "0x18412D820")]
		public static void QWUNCAJUKWK<o>([In] this IdSpan<o, byte> bytes, Id32<o> a, byte b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x412D310", Offset = "0x412BD10", VA = "0x18412D310")]
		public static void CHJBOCQADEO<q>(this IdArray<q, byte> a, Id32<q> b, Id32<TVAMPUAMYRD<RTIMFYESSKP>> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x412D390", Offset = "0x412BD90", VA = "0x18412D390")]
		public static void CHJBOCQADEO<r>([In] this IdSpan<r, byte> bytes, Id32<r> a, Id32<TVAMPUAMYRD<RTIMFYESSKP>> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x412D310", Offset = "0x412BD10", VA = "0x18412D310")]
		public static void JZLVBFQINKO<t>(this IdArray<t, byte> a, Id32<t> b, Id32<AUNNIJUAVXE> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x412D390", Offset = "0x412BD90", VA = "0x18412D390")]
		public static void JZLVBFQINKO<u>([In] this IdSpan<u, byte> bytes, Id32<u> a, Id32<AUNNIJUAVXE> b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public static class FEGDLISMRZO
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x2B910F0", Offset = "0x2B8FAF0", VA = "0x182B910F0")]
		public static (Id32<TVAMPUAMYRD<NODNFPCIRRW>>, Id32<TVAMPUAMYRD<GQNEASXRVOC>>, Id32<TVAMPUAMYRD<GQNEASXRVOC>>, Id32<TVAMPUAMYRD<XSPVEGMZPQH<GQNEASXRVOC>>>) ZEEASFPTOFU(this UnsafeList<byte> a, float b, float c, [Optional] Id32<XSPVEGMZPQH<GQNEASXRVOC>>? d)
		{
			return default((Id32<TVAMPUAMYRD<NODNFPCIRRW>>, Id32<TVAMPUAMYRD<GQNEASXRVOC>>, Id32<TVAMPUAMYRD<GQNEASXRVOC>>, Id32<TVAMPUAMYRD<XSPVEGMZPQH<GQNEASXRVOC>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x2B90E10", Offset = "0x2B8F810", VA = "0x182B90E10")]
		public static (Id32<TVAMPUAMYRD<NODNFPCIRRW>>, Id32<TVAMPUAMYRD<GQNEASXRVOC>>, Id32<TVAMPUAMYRD<XSPVEGMZPQH<GQNEASXRVOC>>>, Id32<TVAMPUAMYRD<XSPVEGMZPQH<GQNEASXRVOC>>>) XYUFOMMNJOZ(this UnsafeList<byte> a, float b, [Optional] Id32<XSPVEGMZPQH<GQNEASXRVOC>>? c, [Optional] Id32<XSPVEGMZPQH<GQNEASXRVOC>>? d)
		{
			return default((Id32<TVAMPUAMYRD<NODNFPCIRRW>>, Id32<TVAMPUAMYRD<GQNEASXRVOC>>, Id32<TVAMPUAMYRD<XSPVEGMZPQH<GQNEASXRVOC>>>, Id32<TVAMPUAMYRD<XSPVEGMZPQH<GQNEASXRVOC>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x2B8E1A0", Offset = "0x2B8CBA0", VA = "0x182B8E1A0")]
		public static (Id32<TVAMPUAMYRD<NODNFPCIRRW>>, Id32<TVAMPUAMYRD<XSPVEGMZPQH<GQNEASXRVOC>>>, Id32<TVAMPUAMYRD<XSPVEGMZPQH<GQNEASXRVOC>>>, Id32<TVAMPUAMYRD<XSPVEGMZPQH<GQNEASXRVOC>>>) KYUFKKQVBYY(this UnsafeList<byte> a, [Optional] Id32<XSPVEGMZPQH<GQNEASXRVOC>>? b, [Optional] Id32<XSPVEGMZPQH<GQNEASXRVOC>>? c, [Optional] Id32<XSPVEGMZPQH<GQNEASXRVOC>>? d)
		{
			return default((Id32<TVAMPUAMYRD<NODNFPCIRRW>>, Id32<TVAMPUAMYRD<XSPVEGMZPQH<GQNEASXRVOC>>>, Id32<TVAMPUAMYRD<XSPVEGMZPQH<GQNEASXRVOC>>>, Id32<TVAMPUAMYRD<XSPVEGMZPQH<GQNEASXRVOC>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x2B8FF70", Offset = "0x2B8E970", VA = "0x182B8FF70")]
		public static (Id32<TVAMPUAMYRD<NODNFPCIRRW>>, Id32<TVAMPUAMYRD<VFMZCREDNZR>>, Id32<TVAMPUAMYRD<VFMZCREDNZR>>, Id32<TVAMPUAMYRD<XSPVEGMZPQH<VFMZCREDNZR>>>) SZZFHRAKUAU(this UnsafeList<byte> a, int b, int c, [Optional] Id32<XSPVEGMZPQH<VFMZCREDNZR>>? d)
		{
			return default((Id32<TVAMPUAMYRD<NODNFPCIRRW>>, Id32<TVAMPUAMYRD<VFMZCREDNZR>>, Id32<TVAMPUAMYRD<VFMZCREDNZR>>, Id32<TVAMPUAMYRD<XSPVEGMZPQH<VFMZCREDNZR>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x2B8E7E0", Offset = "0x2B8D1E0", VA = "0x182B8E7E0")]
		public static (Id32<TVAMPUAMYRD<NODNFPCIRRW>>, Id32<TVAMPUAMYRD<VFMZCREDNZR>>, Id32<TVAMPUAMYRD<XSPVEGMZPQH<VFMZCREDNZR>>>, Id32<TVAMPUAMYRD<XSPVEGMZPQH<VFMZCREDNZR>>>) NGMILRXZBNV(this UnsafeList<byte> a, int b, [Optional] Id32<XSPVEGMZPQH<VFMZCREDNZR>>? c, [Optional] Id32<XSPVEGMZPQH<VFMZCREDNZR>>? d)
		{
			return default((Id32<TVAMPUAMYRD<NODNFPCIRRW>>, Id32<TVAMPUAMYRD<VFMZCREDNZR>>, Id32<TVAMPUAMYRD<XSPVEGMZPQH<VFMZCREDNZR>>>, Id32<TVAMPUAMYRD<XSPVEGMZPQH<VFMZCREDNZR>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x2B90250", Offset = "0x2B8EC50", VA = "0x182B90250")]
		public static (Id32<TVAMPUAMYRD<NODNFPCIRRW>>, Id32<TVAMPUAMYRD<XSPVEGMZPQH<VFMZCREDNZR>>>, Id32<TVAMPUAMYRD<XSPVEGMZPQH<VFMZCREDNZR>>>, Id32<TVAMPUAMYRD<XSPVEGMZPQH<VFMZCREDNZR>>>) TYBRTXLYGTQ(this UnsafeList<byte> a, [Optional] Id32<XSPVEGMZPQH<VFMZCREDNZR>>? b, [Optional] Id32<XSPVEGMZPQH<VFMZCREDNZR>>? c, [Optional] Id32<XSPVEGMZPQH<VFMZCREDNZR>>? d)
		{
			return default((Id32<TVAMPUAMYRD<NODNFPCIRRW>>, Id32<TVAMPUAMYRD<XSPVEGMZPQH<VFMZCREDNZR>>>, Id32<TVAMPUAMYRD<XSPVEGMZPQH<VFMZCREDNZR>>>, Id32<TVAMPUAMYRD<XSPVEGMZPQH<VFMZCREDNZR>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x2B8FE10", Offset = "0x2B8E810", VA = "0x182B8FE10")]
		public static (Id32<TVAMPUAMYRD<NODNFPCIRRW>>, Id32<TVAMPUAMYRD<VFMZCREDNZR>>, Id32<TVAMPUAMYRD<VFMZCREDNZR>>, Id32<TVAMPUAMYRD<XSPVEGMZPQH<VFMZCREDNZR>>>) SHCHONPMUWG(this UnsafeList<byte> a, int b, int c, [Optional] Id32<XSPVEGMZPQH<VFMZCREDNZR>>? d)
		{
			return default((Id32<TVAMPUAMYRD<NODNFPCIRRW>>, Id32<TVAMPUAMYRD<VFMZCREDNZR>>, Id32<TVAMPUAMYRD<VFMZCREDNZR>>, Id32<TVAMPUAMYRD<XSPVEGMZPQH<VFMZCREDNZR>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x2B91650", Offset = "0x2B90050", VA = "0x182B91650")]
		public static (Id32<TVAMPUAMYRD<NODNFPCIRRW>>, Id32<TVAMPUAMYRD<VFMZCREDNZR>>, Id32<TVAMPUAMYRD<XSPVEGMZPQH<VFMZCREDNZR>>>, Id32<TVAMPUAMYRD<XSPVEGMZPQH<VFMZCREDNZR>>>) ZWHCUXZKFLL(this UnsafeList<byte> a, int b, [Optional] Id32<XSPVEGMZPQH<VFMZCREDNZR>>? c, [Optional] Id32<XSPVEGMZPQH<VFMZCREDNZR>>? d)
		{
			return default((Id32<TVAMPUAMYRD<NODNFPCIRRW>>, Id32<TVAMPUAMYRD<VFMZCREDNZR>>, Id32<TVAMPUAMYRD<XSPVEGMZPQH<VFMZCREDNZR>>>, Id32<TVAMPUAMYRD<XSPVEGMZPQH<VFMZCREDNZR>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x2B8C0A0", Offset = "0x2B8AAA0", VA = "0x182B8C0A0")]
		public static (Id32<TVAMPUAMYRD<NODNFPCIRRW>>, Id32<TVAMPUAMYRD<XSPVEGMZPQH<VFMZCREDNZR>>>, Id32<TVAMPUAMYRD<XSPVEGMZPQH<VFMZCREDNZR>>>, Id32<TVAMPUAMYRD<XSPVEGMZPQH<VFMZCREDNZR>>>) AUNLVJKCBRG(this UnsafeList<byte> a, [Optional] Id32<XSPVEGMZPQH<VFMZCREDNZR>>? b, [Optional] Id32<XSPVEGMZPQH<VFMZCREDNZR>>? c, [Optional] Id32<XSPVEGMZPQH<VFMZCREDNZR>>? d)
		{
			return default((Id32<TVAMPUAMYRD<NODNFPCIRRW>>, Id32<TVAMPUAMYRD<XSPVEGMZPQH<VFMZCREDNZR>>>, Id32<TVAMPUAMYRD<XSPVEGMZPQH<VFMZCREDNZR>>>, Id32<TVAMPUAMYRD<XSPVEGMZPQH<VFMZCREDNZR>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x2B8E090", Offset = "0x2B8CA90", VA = "0x182B8E090")]
		public static (Id32<TVAMPUAMYRD<NODNFPCIRRW>>, Id32<TVAMPUAMYRD<VFMZCREDNZR>>, Id32<TVAMPUAMYRD<TVAMPUAMYRD<NODNFPCIRRW>>>) JXSLMLTNYYQ(this UnsafeList<byte> a, [Optional] int? b, [Optional] Id32<TVAMPUAMYRD<NODNFPCIRRW>>? c)
		{
			return default((Id32<TVAMPUAMYRD<NODNFPCIRRW>>, Id32<TVAMPUAMYRD<VFMZCREDNZR>>, Id32<TVAMPUAMYRD<TVAMPUAMYRD<NODNFPCIRRW>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x2B8F420", Offset = "0x2B8DE20", VA = "0x182B8F420")]
		public static (Id32<TVAMPUAMYRD<NODNFPCIRRW>>, Id32<TVAMPUAMYRD<XSPVEGMZPQH<VFMZCREDNZR>>>, Id32<TVAMPUAMYRD<TVAMPUAMYRD<NODNFPCIRRW>>>) PRTEOFZSXPB(this UnsafeList<byte> a, [Optional] Id32<XSPVEGMZPQH<VFMZCREDNZR>>? b, [Optional] Id32<TVAMPUAMYRD<NODNFPCIRRW>>? c)
		{
			return default((Id32<TVAMPUAMYRD<NODNFPCIRRW>>, Id32<TVAMPUAMYRD<XSPVEGMZPQH<VFMZCREDNZR>>>, Id32<TVAMPUAMYRD<TVAMPUAMYRD<NODNFPCIRRW>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x2B90F60", Offset = "0x2B8F960", VA = "0x182B90F60")]
		public static (Id32<TVAMPUAMYRD<NODNFPCIRRW>>, Id32<TVAMPUAMYRD<VFMZCREDNZR>>, Id32<TVAMPUAMYRD<TVAMPUAMYRD<NODNFPCIRRW>>>) YLQQYWEFHEN(this UnsafeList<byte> a, [Optional] int? b, [Optional] Id32<TVAMPUAMYRD<NODNFPCIRRW>>? c)
		{
			return default((Id32<TVAMPUAMYRD<NODNFPCIRRW>>, Id32<TVAMPUAMYRD<VFMZCREDNZR>>, Id32<TVAMPUAMYRD<TVAMPUAMYRD<NODNFPCIRRW>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x2B8E410", Offset = "0x2B8CE10", VA = "0x182B8E410")]
		public static (Id32<TVAMPUAMYRD<NODNFPCIRRW>>, Id32<TVAMPUAMYRD<XSPVEGMZPQH<VFMZCREDNZR>>>, Id32<TVAMPUAMYRD<TVAMPUAMYRD<NODNFPCIRRW>>>) LTMWWHYBWQS(this UnsafeList<byte> a, [Optional] Id32<XSPVEGMZPQH<VFMZCREDNZR>>? b, [Optional] Id32<TVAMPUAMYRD<NODNFPCIRRW>>? c)
		{
			return default((Id32<TVAMPUAMYRD<NODNFPCIRRW>>, Id32<TVAMPUAMYRD<XSPVEGMZPQH<VFMZCREDNZR>>>, Id32<TVAMPUAMYRD<TVAMPUAMYRD<NODNFPCIRRW>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x2B90370", Offset = "0x2B8ED70", VA = "0x182B90370")]
		public static (Id32<TVAMPUAMYRD<NODNFPCIRRW>>, Id32<TVAMPUAMYRD<VFMZCREDNZR>>, Id32<TVAMPUAMYRD<JIFIDYBYJAI>>) VKRUGICKJPF(this UnsafeList<byte> a, [Optional] int? b, [Optional] Id32<JIFIDYBYJAI>? c)
		{
			return default((Id32<TVAMPUAMYRD<NODNFPCIRRW>>, Id32<TVAMPUAMYRD<VFMZCREDNZR>>, Id32<TVAMPUAMYRD<JIFIDYBYJAI>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x2B90520", Offset = "0x2B8EF20", VA = "0x182B90520")]
		public static (Id32<TVAMPUAMYRD<NODNFPCIRRW>>, Id32<TVAMPUAMYRD<VFMZCREDNZR>>, Id32<TVAMPUAMYRD<XSPVEGMZPQH<JIFIDYBYJAI>>>) VPTKPVFWLMW(this UnsafeList<byte> a, [Optional] int? b, [Optional] Id32<XSPVEGMZPQH<JIFIDYBYJAI>>? c)
		{
			return default((Id32<TVAMPUAMYRD<NODNFPCIRRW>>, Id32<TVAMPUAMYRD<VFMZCREDNZR>>, Id32<TVAMPUAMYRD<XSPVEGMZPQH<JIFIDYBYJAI>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x2B90630", Offset = "0x2B8F030", VA = "0x182B90630")]
		public static (Id32<TVAMPUAMYRD<NODNFPCIRRW>>, Id32<TVAMPUAMYRD<VFMZCREDNZR>>, Id32<TVAMPUAMYRD<AUNNIJUAVXE>>) WNEUJSYEGMJ(this UnsafeList<byte> a, [Optional] int? b, [Optional] Id32<AUNNIJUAVXE>? c)
		{
			return default((Id32<TVAMPUAMYRD<NODNFPCIRRW>>, Id32<TVAMPUAMYRD<VFMZCREDNZR>>, Id32<TVAMPUAMYRD<AUNNIJUAVXE>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x2B907E0", Offset = "0x2B8F1E0", VA = "0x182B907E0")]
		public static (Id32<TVAMPUAMYRD<NODNFPCIRRW>>, Id32<TVAMPUAMYRD<VFMZCREDNZR>>, Id32<TVAMPUAMYRD<XSPVEGMZPQH<AUNNIJUAVXE>>>) WRLJEFAAWQQ(this UnsafeList<byte> a, [Optional] int? b, [Optional] Id32<XSPVEGMZPQH<AUNNIJUAVXE>>? c)
		{
			return default((Id32<TVAMPUAMYRD<NODNFPCIRRW>>, Id32<TVAMPUAMYRD<VFMZCREDNZR>>, Id32<TVAMPUAMYRD<XSPVEGMZPQH<AUNNIJUAVXE>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x3ADAB30", Offset = "0x3AD9530", VA = "0x183ADAB30")]
		public static (Id32<TVAMPUAMYRD<NODNFPCIRRW>>, Id32<TVAMPUAMYRD<PLGQQUCWUUF>>, Id32<TVAMPUAMYRD<VFMZCREDNZR>>, Id32<TVAMPUAMYRD<a>>) TNQGSSNGJIO<a>(this UnsafeList<byte> a, [Optional] Id32<PLGQQUCWUUF>? b, [Optional][In] ReadOnlySpan<byte> data)
		{
			return default((Id32<TVAMPUAMYRD<NODNFPCIRRW>>, Id32<TVAMPUAMYRD<PLGQQUCWUUF>>, Id32<TVAMPUAMYRD<VFMZCREDNZR>>, Id32<TVAMPUAMYRD<a>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x2B8DE10", Offset = "0x2B8C810", VA = "0x182B8DE10")]
		public static (Id32<TVAMPUAMYRD<NODNFPCIRRW>>, Id32<TVAMPUAMYRD<VFMZCREDNZR>>, Id32<TVAMPUAMYRD<XSPVEGMZPQH<VFMZCREDNZR>>>) JRSUBITUHLC(this UnsafeList<byte> a, int b, [Optional] Id32<XSPVEGMZPQH<VFMZCREDNZR>>? c)
		{
			return default((Id32<TVAMPUAMYRD<NODNFPCIRRW>>, Id32<TVAMPUAMYRD<VFMZCREDNZR>>, Id32<TVAMPUAMYRD<XSPVEGMZPQH<VFMZCREDNZR>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x2B8F8D0", Offset = "0x2B8E2D0", VA = "0x182B8F8D0")]
		public static (Id32<TVAMPUAMYRD<NODNFPCIRRW>>, Id32<TVAMPUAMYRD<XSPVEGMZPQH<VFMZCREDNZR>>>, Id32<TVAMPUAMYRD<XSPVEGMZPQH<VFMZCREDNZR>>>) RCJHMRBGRQH(this UnsafeList<byte> a, [Optional] Id32<XSPVEGMZPQH<VFMZCREDNZR>>? b, [Optional] Id32<XSPVEGMZPQH<VFMZCREDNZR>>? c)
		{
			return default((Id32<TVAMPUAMYRD<NODNFPCIRRW>>, Id32<TVAMPUAMYRD<XSPVEGMZPQH<VFMZCREDNZR>>>, Id32<TVAMPUAMYRD<XSPVEGMZPQH<VFMZCREDNZR>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x3ADA720", Offset = "0x3AD9120", VA = "0x183ADA720")]
		public static (Id32<TVAMPUAMYRD<NODNFPCIRRW>>, Id32<TVAMPUAMYRD<XSPVEGMZPQH<b>>>, Id32<TVAMPUAMYRD<VFMZCREDNZR>>, Id32<TVAMPUAMYRD<b>>) GHPXRKUXNAE<b>(this UnsafeList<byte> a, [Optional] Id32<XSPVEGMZPQH<b>>? b, [Optional] int? c, [Optional][In] ReadOnlySpan<byte> from)
		{
			return default((Id32<TVAMPUAMYRD<NODNFPCIRRW>>, Id32<TVAMPUAMYRD<XSPVEGMZPQH<b>>>, Id32<TVAMPUAMYRD<VFMZCREDNZR>>, Id32<TVAMPUAMYRD<b>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x3ADAE70", Offset = "0x3AD9870", VA = "0x183ADAE70")]
		public static (Id32<TVAMPUAMYRD<NODNFPCIRRW>>, Id32<TVAMPUAMYRD<XSPVEGMZPQH<c>>>, Id32<TVAMPUAMYRD<XSPVEGMZPQH<c>>>, Id32<TVAMPUAMYRD<VFMZCREDNZR>>) ZYZCLRSHOVR<c>(this UnsafeList<byte> a, [Optional] Id32<XSPVEGMZPQH<c>>? b, [Optional] Id32<XSPVEGMZPQH<c>>? c, [Optional] int? d)
		{
			return default((Id32<TVAMPUAMYRD<NODNFPCIRRW>>, Id32<TVAMPUAMYRD<XSPVEGMZPQH<c>>>, Id32<TVAMPUAMYRD<XSPVEGMZPQH<c>>>, Id32<TVAMPUAMYRD<VFMZCREDNZR>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x2B900D0", Offset = "0x2B8EAD0", VA = "0x182B900D0")]
		public static (Id32<TVAMPUAMYRD<NODNFPCIRRW>>, Id32<TVAMPUAMYRD<GQNEASXRVOC>>, Id32<TVAMPUAMYRD<GQNEASXRVOC>>, Id32<TVAMPUAMYRD<XSPVEGMZPQH<GQNEASXRVOC>>>) TLIJHBKFXBW(this UnsafeList<byte> a, float b, float c, [Optional] Id32<XSPVEGMZPQH<GQNEASXRVOC>>? d)
		{
			return default((Id32<TVAMPUAMYRD<NODNFPCIRRW>>, Id32<TVAMPUAMYRD<GQNEASXRVOC>>, Id32<TVAMPUAMYRD<GQNEASXRVOC>>, Id32<TVAMPUAMYRD<XSPVEGMZPQH<GQNEASXRVOC>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x2B8EA80", Offset = "0x2B8D480", VA = "0x182B8EA80")]
		public static (Id32<TVAMPUAMYRD<NODNFPCIRRW>>, Id32<TVAMPUAMYRD<GQNEASXRVOC>>, Id32<TVAMPUAMYRD<XSPVEGMZPQH<GQNEASXRVOC>>>, Id32<TVAMPUAMYRD<XSPVEGMZPQH<GQNEASXRVOC>>>) NMWARFOTWZJ(this UnsafeList<byte> a, float b, [Optional] Id32<XSPVEGMZPQH<GQNEASXRVOC>>? c, [Optional] Id32<XSPVEGMZPQH<GQNEASXRVOC>>? d)
		{
			return default((Id32<TVAMPUAMYRD<NODNFPCIRRW>>, Id32<TVAMPUAMYRD<GQNEASXRVOC>>, Id32<TVAMPUAMYRD<XSPVEGMZPQH<GQNEASXRVOC>>>, Id32<TVAMPUAMYRD<XSPVEGMZPQH<GQNEASXRVOC>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x2B90CF0", Offset = "0x2B8F6F0", VA = "0x182B90CF0")]
		public static (Id32<TVAMPUAMYRD<NODNFPCIRRW>>, Id32<TVAMPUAMYRD<XSPVEGMZPQH<GQNEASXRVOC>>>, Id32<TVAMPUAMYRD<XSPVEGMZPQH<GQNEASXRVOC>>>, Id32<TVAMPUAMYRD<XSPVEGMZPQH<GQNEASXRVOC>>>) XLJJDDKOJXQ(this UnsafeList<byte> a, [Optional] Id32<XSPVEGMZPQH<GQNEASXRVOC>>? b, [Optional] Id32<XSPVEGMZPQH<GQNEASXRVOC>>? c, [Optional] Id32<XSPVEGMZPQH<GQNEASXRVOC>>? d)
		{
			return default((Id32<TVAMPUAMYRD<NODNFPCIRRW>>, Id32<TVAMPUAMYRD<XSPVEGMZPQH<GQNEASXRVOC>>>, Id32<TVAMPUAMYRD<XSPVEGMZPQH<GQNEASXRVOC>>>, Id32<TVAMPUAMYRD<XSPVEGMZPQH<GQNEASXRVOC>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x2B913D0", Offset = "0x2B8FDD0", VA = "0x182B913D0")]
		public static (Id32<TVAMPUAMYRD<NODNFPCIRRW>>, Id32<TVAMPUAMYRD<VFMZCREDNZR>>, Id32<TVAMPUAMYRD<VFMZCREDNZR>>, Id32<TVAMPUAMYRD<XSPVEGMZPQH<VFMZCREDNZR>>>) ZPJLGYSRPHQ(this UnsafeList<byte> a, int b, int c, [Optional] Id32<XSPVEGMZPQH<VFMZCREDNZR>>? d)
		{
			return default((Id32<TVAMPUAMYRD<NODNFPCIRRW>>, Id32<TVAMPUAMYRD<VFMZCREDNZR>>, Id32<TVAMPUAMYRD<VFMZCREDNZR>>, Id32<TVAMPUAMYRD<XSPVEGMZPQH<VFMZCREDNZR>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x2B8E690", Offset = "0x2B8D090", VA = "0x182B8E690")]
		public static (Id32<TVAMPUAMYRD<NODNFPCIRRW>>, Id32<TVAMPUAMYRD<VFMZCREDNZR>>, Id32<TVAMPUAMYRD<XSPVEGMZPQH<VFMZCREDNZR>>>, Id32<TVAMPUAMYRD<XSPVEGMZPQH<VFMZCREDNZR>>>) MNSALBHOTIZ(this UnsafeList<byte> a, int b, [Optional] Id32<XSPVEGMZPQH<VFMZCREDNZR>>? c, [Optional] Id32<XSPVEGMZPQH<VFMZCREDNZR>>? d)
		{
			return default((Id32<TVAMPUAMYRD<NODNFPCIRRW>>, Id32<TVAMPUAMYRD<VFMZCREDNZR>>, Id32<TVAMPUAMYRD<XSPVEGMZPQH<VFMZCREDNZR>>>, Id32<TVAMPUAMYRD<XSPVEGMZPQH<VFMZCREDNZR>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x2B8C860", Offset = "0x2B8B260", VA = "0x182B8C860")]
		public static (Id32<TVAMPUAMYRD<NODNFPCIRRW>>, Id32<TVAMPUAMYRD<XSPVEGMZPQH<VFMZCREDNZR>>>, Id32<TVAMPUAMYRD<XSPVEGMZPQH<VFMZCREDNZR>>>, Id32<TVAMPUAMYRD<XSPVEGMZPQH<VFMZCREDNZR>>>) CSYFRXVOTWU(this UnsafeList<byte> a, [Optional] Id32<XSPVEGMZPQH<VFMZCREDNZR>>? b, [Optional] Id32<XSPVEGMZPQH<VFMZCREDNZR>>? c, [Optional] Id32<XSPVEGMZPQH<VFMZCREDNZR>>? d)
		{
			return default((Id32<TVAMPUAMYRD<NODNFPCIRRW>>, Id32<TVAMPUAMYRD<XSPVEGMZPQH<VFMZCREDNZR>>>, Id32<TVAMPUAMYRD<XSPVEGMZPQH<VFMZCREDNZR>>>, Id32<TVAMPUAMYRD<XSPVEGMZPQH<VFMZCREDNZR>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x2B8F080", Offset = "0x2B8DA80", VA = "0x182B8F080")]
		public static (Id32<TVAMPUAMYRD<NODNFPCIRRW>>, Id32<TVAMPUAMYRD<VFMZCREDNZR>>, Id32<TVAMPUAMYRD<VFMZCREDNZR>>, Id32<TVAMPUAMYRD<XSPVEGMZPQH<VFMZCREDNZR>>>) PBYQERFWCMT(this UnsafeList<byte> a, int b, int c, [Optional] Id32<XSPVEGMZPQH<VFMZCREDNZR>>? d)
		{
			return default((Id32<TVAMPUAMYRD<NODNFPCIRRW>>, Id32<TVAMPUAMYRD<VFMZCREDNZR>>, Id32<TVAMPUAMYRD<VFMZCREDNZR>>, Id32<TVAMPUAMYRD<XSPVEGMZPQH<VFMZCREDNZR>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x2B8FB40", Offset = "0x2B8E540", VA = "0x182B8FB40")]
		public static (Id32<TVAMPUAMYRD<NODNFPCIRRW>>, Id32<TVAMPUAMYRD<VFMZCREDNZR>>, Id32<TVAMPUAMYRD<XSPVEGMZPQH<VFMZCREDNZR>>>, Id32<TVAMPUAMYRD<XSPVEGMZPQH<VFMZCREDNZR>>>) RNCUXWGUPHS(this UnsafeList<byte> a, int b, [Optional] Id32<XSPVEGMZPQH<VFMZCREDNZR>>? c, [Optional] Id32<XSPVEGMZPQH<VFMZCREDNZR>>? d)
		{
			return default((Id32<TVAMPUAMYRD<NODNFPCIRRW>>, Id32<TVAMPUAMYRD<VFMZCREDNZR>>, Id32<TVAMPUAMYRD<XSPVEGMZPQH<VFMZCREDNZR>>>, Id32<TVAMPUAMYRD<XSPVEGMZPQH<VFMZCREDNZR>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x2B91530", Offset = "0x2B8FF30", VA = "0x182B91530")]
		public static (Id32<TVAMPUAMYRD<NODNFPCIRRW>>, Id32<TVAMPUAMYRD<XSPVEGMZPQH<VFMZCREDNZR>>>, Id32<TVAMPUAMYRD<XSPVEGMZPQH<VFMZCREDNZR>>>, Id32<TVAMPUAMYRD<XSPVEGMZPQH<VFMZCREDNZR>>>) ZUEMMMTISEN(this UnsafeList<byte> a, [Optional] Id32<XSPVEGMZPQH<VFMZCREDNZR>>? b, [Optional] Id32<XSPVEGMZPQH<VFMZCREDNZR>>? c, [Optional] Id32<XSPVEGMZPQH<VFMZCREDNZR>>? d)
		{
			return default((Id32<TVAMPUAMYRD<NODNFPCIRRW>>, Id32<TVAMPUAMYRD<XSPVEGMZPQH<VFMZCREDNZR>>>, Id32<TVAMPUAMYRD<XSPVEGMZPQH<VFMZCREDNZR>>>, Id32<TVAMPUAMYRD<XSPVEGMZPQH<VFMZCREDNZR>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x2B8ECF0", Offset = "0x2B8D6F0", VA = "0x182B8ECF0")]
		public static (Id32<TVAMPUAMYRD<NODNFPCIRRW>>, Id32<TVAMPUAMYRD<TVAMPUAMYRD<NODNFPCIRRW>>>) OLJVOZWUCZK(this UnsafeList<byte> a, [Optional] Id32<TVAMPUAMYRD<NODNFPCIRRW>>? b)
		{
			return default((Id32<TVAMPUAMYRD<NODNFPCIRRW>>, Id32<TVAMPUAMYRD<TVAMPUAMYRD<NODNFPCIRRW>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x2B8D7C0", Offset = "0x2B8C1C0", VA = "0x182B8D7C0")]
		public static (Id32<TVAMPUAMYRD<NODNFPCIRRW>>, Id32<TVAMPUAMYRD<GQNEASXRVOC>>, Id32<TVAMPUAMYRD<GQNEASXRVOC>>, Id32<TVAMPUAMYRD<XSPVEGMZPQH<VFMZCREDNZR>>>) HRFJATDKQZC(this UnsafeList<byte> a, float b, float c, [Optional] Id32<XSPVEGMZPQH<VFMZCREDNZR>>? d)
		{
			return default((Id32<TVAMPUAMYRD<NODNFPCIRRW>>, Id32<TVAMPUAMYRD<GQNEASXRVOC>>, Id32<TVAMPUAMYRD<GQNEASXRVOC>>, Id32<TVAMPUAMYRD<XSPVEGMZPQH<VFMZCREDNZR>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x2B8E530", Offset = "0x2B8CF30", VA = "0x182B8E530")]
		public static (Id32<TVAMPUAMYRD<NODNFPCIRRW>>, Id32<TVAMPUAMYRD<GQNEASXRVOC>>, Id32<TVAMPUAMYRD<XSPVEGMZPQH<GQNEASXRVOC>>>, Id32<TVAMPUAMYRD<XSPVEGMZPQH<VFMZCREDNZR>>>) MEVJJUJRNUX(this UnsafeList<byte> a, float b, [Optional] Id32<XSPVEGMZPQH<GQNEASXRVOC>>? c, [Optional] Id32<XSPVEGMZPQH<VFMZCREDNZR>>? d)
		{
			return default((Id32<TVAMPUAMYRD<NODNFPCIRRW>>, Id32<TVAMPUAMYRD<GQNEASXRVOC>>, Id32<TVAMPUAMYRD<XSPVEGMZPQH<GQNEASXRVOC>>>, Id32<TVAMPUAMYRD<XSPVEGMZPQH<VFMZCREDNZR>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x2B8C5B0", Offset = "0x2B8AFB0", VA = "0x182B8C5B0")]
		public static (Id32<TVAMPUAMYRD<NODNFPCIRRW>>, Id32<TVAMPUAMYRD<XSPVEGMZPQH<GQNEASXRVOC>>>, Id32<TVAMPUAMYRD<XSPVEGMZPQH<GQNEASXRVOC>>>, Id32<TVAMPUAMYRD<XSPVEGMZPQH<VFMZCREDNZR>>>) CBHGQEMTBZI(this UnsafeList<byte> a, [Optional] Id32<XSPVEGMZPQH<GQNEASXRVOC>>? b, [Optional] Id32<XSPVEGMZPQH<GQNEASXRVOC>>? c, [Optional] Id32<XSPVEGMZPQH<VFMZCREDNZR>>? d)
		{
			return default((Id32<TVAMPUAMYRD<NODNFPCIRRW>>, Id32<TVAMPUAMYRD<XSPVEGMZPQH<GQNEASXRVOC>>>, Id32<TVAMPUAMYRD<XSPVEGMZPQH<GQNEASXRVOC>>>, Id32<TVAMPUAMYRD<XSPVEGMZPQH<VFMZCREDNZR>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x2B8D660", Offset = "0x2B8C060", VA = "0x182B8D660")]
		public static (Id32<TVAMPUAMYRD<NODNFPCIRRW>>, Id32<TVAMPUAMYRD<VFMZCREDNZR>>, Id32<TVAMPUAMYRD<VFMZCREDNZR>>, Id32<TVAMPUAMYRD<XSPVEGMZPQH<VFMZCREDNZR>>>) HMPYBRYNVLH(this UnsafeList<byte> a, int b, int c, [Optional] Id32<XSPVEGMZPQH<VFMZCREDNZR>>? d)
		{
			return default((Id32<TVAMPUAMYRD<NODNFPCIRRW>>, Id32<TVAMPUAMYRD<VFMZCREDNZR>>, Id32<TVAMPUAMYRD<VFMZCREDNZR>>, Id32<TVAMPUAMYRD<XSPVEGMZPQH<VFMZCREDNZR>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x2B8EF30", Offset = "0x2B8D930", VA = "0x182B8EF30")]
		public static (Id32<TVAMPUAMYRD<NODNFPCIRRW>>, Id32<TVAMPUAMYRD<VFMZCREDNZR>>, Id32<TVAMPUAMYRD<XSPVEGMZPQH<VFMZCREDNZR>>>, Id32<TVAMPUAMYRD<XSPVEGMZPQH<VFMZCREDNZR>>>) OSWTHTLYANE(this UnsafeList<byte> a, int b, [Optional] Id32<XSPVEGMZPQH<VFMZCREDNZR>>? c, [Optional] Id32<XSPVEGMZPQH<VFMZCREDNZR>>? d)
		{
			return default((Id32<TVAMPUAMYRD<NODNFPCIRRW>>, Id32<TVAMPUAMYRD<VFMZCREDNZR>>, Id32<TVAMPUAMYRD<XSPVEGMZPQH<VFMZCREDNZR>>>, Id32<TVAMPUAMYRD<XSPVEGMZPQH<VFMZCREDNZR>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x2B8CFE0", Offset = "0x2B8B9E0", VA = "0x182B8CFE0")]
		public static (Id32<TVAMPUAMYRD<NODNFPCIRRW>>, Id32<TVAMPUAMYRD<XSPVEGMZPQH<VFMZCREDNZR>>>, Id32<TVAMPUAMYRD<XSPVEGMZPQH<VFMZCREDNZR>>>, Id32<TVAMPUAMYRD<XSPVEGMZPQH<VFMZCREDNZR>>>) FEGWXGWTHXZ(this UnsafeList<byte> a, [Optional] Id32<XSPVEGMZPQH<VFMZCREDNZR>>? b, [Optional] Id32<XSPVEGMZPQH<VFMZCREDNZR>>? c, [Optional] Id32<XSPVEGMZPQH<VFMZCREDNZR>>? d)
		{
			return default((Id32<TVAMPUAMYRD<NODNFPCIRRW>>, Id32<TVAMPUAMYRD<XSPVEGMZPQH<VFMZCREDNZR>>>, Id32<TVAMPUAMYRD<XSPVEGMZPQH<VFMZCREDNZR>>>, Id32<TVAMPUAMYRD<XSPVEGMZPQH<VFMZCREDNZR>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x2B90A50", Offset = "0x2B8F450", VA = "0x182B90A50")]
		public static (Id32<TVAMPUAMYRD<NODNFPCIRRW>>, Id32<TVAMPUAMYRD<GQNEASXRVOC>>, Id32<TVAMPUAMYRD<GQNEASXRVOC>>, Id32<TVAMPUAMYRD<XSPVEGMZPQH<VFMZCREDNZR>>>) WVTILJANOHF(this UnsafeList<byte> a, float b, float c, [Optional] Id32<XSPVEGMZPQH<VFMZCREDNZR>>? d)
		{
			return default((Id32<TVAMPUAMYRD<NODNFPCIRRW>>, Id32<TVAMPUAMYRD<GQNEASXRVOC>>, Id32<TVAMPUAMYRD<GQNEASXRVOC>>, Id32<TVAMPUAMYRD<XSPVEGMZPQH<VFMZCREDNZR>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x2B908F0", Offset = "0x2B8F2F0", VA = "0x182B908F0")]
		public static (Id32<TVAMPUAMYRD<NODNFPCIRRW>>, Id32<TVAMPUAMYRD<GQNEASXRVOC>>, Id32<TVAMPUAMYRD<XSPVEGMZPQH<GQNEASXRVOC>>>, Id32<TVAMPUAMYRD<XSPVEGMZPQH<VFMZCREDNZR>>>) WTDCPNRYMBC(this UnsafeList<byte> a, float b, [Optional] Id32<XSPVEGMZPQH<GQNEASXRVOC>>? c, [Optional] Id32<XSPVEGMZPQH<VFMZCREDNZR>>? d)
		{
			return default((Id32<TVAMPUAMYRD<NODNFPCIRRW>>, Id32<TVAMPUAMYRD<GQNEASXRVOC>>, Id32<TVAMPUAMYRD<XSPVEGMZPQH<GQNEASXRVOC>>>, Id32<TVAMPUAMYRD<XSPVEGMZPQH<VFMZCREDNZR>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x2B8C320", Offset = "0x2B8AD20", VA = "0x182B8C320")]
		public static (Id32<TVAMPUAMYRD<NODNFPCIRRW>>, Id32<TVAMPUAMYRD<XSPVEGMZPQH<GQNEASXRVOC>>>, Id32<TVAMPUAMYRD<XSPVEGMZPQH<GQNEASXRVOC>>>, Id32<TVAMPUAMYRD<XSPVEGMZPQH<VFMZCREDNZR>>>) BREJGICKAJL(this UnsafeList<byte> a, [Optional] Id32<XSPVEGMZPQH<GQNEASXRVOC>>? b, [Optional] Id32<XSPVEGMZPQH<GQNEASXRVOC>>? c, [Optional] Id32<XSPVEGMZPQH<VFMZCREDNZR>>? d)
		{
			return default((Id32<TVAMPUAMYRD<NODNFPCIRRW>>, Id32<TVAMPUAMYRD<XSPVEGMZPQH<GQNEASXRVOC>>>, Id32<TVAMPUAMYRD<XSPVEGMZPQH<GQNEASXRVOC>>>, Id32<TVAMPUAMYRD<XSPVEGMZPQH<VFMZCREDNZR>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x2B8C1C0", Offset = "0x2B8ABC0", VA = "0x182B8C1C0")]
		public static (Id32<TVAMPUAMYRD<NODNFPCIRRW>>, Id32<TVAMPUAMYRD<VFMZCREDNZR>>, Id32<TVAMPUAMYRD<VFMZCREDNZR>>, Id32<TVAMPUAMYRD<XSPVEGMZPQH<VFMZCREDNZR>>>) BMCZYTCUIYS(this UnsafeList<byte> a, int b, int c, [Optional] Id32<XSPVEGMZPQH<VFMZCREDNZR>>? d)
		{
			return default((Id32<TVAMPUAMYRD<NODNFPCIRRW>>, Id32<TVAMPUAMYRD<VFMZCREDNZR>>, Id32<TVAMPUAMYRD<VFMZCREDNZR>>, Id32<TVAMPUAMYRD<XSPVEGMZPQH<VFMZCREDNZR>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x2B8E2C0", Offset = "0x2B8CCC0", VA = "0x182B8E2C0")]
		public static (Id32<TVAMPUAMYRD<NODNFPCIRRW>>, Id32<TVAMPUAMYRD<VFMZCREDNZR>>, Id32<TVAMPUAMYRD<XSPVEGMZPQH<VFMZCREDNZR>>>, Id32<TVAMPUAMYRD<XSPVEGMZPQH<VFMZCREDNZR>>>) LBDSFTKSRGN(this UnsafeList<byte> a, int b, [Optional] Id32<XSPVEGMZPQH<VFMZCREDNZR>>? c, [Optional] Id32<XSPVEGMZPQH<VFMZCREDNZR>>? d)
		{
			return default((Id32<TVAMPUAMYRD<NODNFPCIRRW>>, Id32<TVAMPUAMYRD<VFMZCREDNZR>>, Id32<TVAMPUAMYRD<XSPVEGMZPQH<VFMZCREDNZR>>>, Id32<TVAMPUAMYRD<XSPVEGMZPQH<VFMZCREDNZR>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x2B8C980", Offset = "0x2B8B380", VA = "0x182B8C980")]
		public static (Id32<TVAMPUAMYRD<NODNFPCIRRW>>, Id32<TVAMPUAMYRD<XSPVEGMZPQH<VFMZCREDNZR>>>, Id32<TVAMPUAMYRD<XSPVEGMZPQH<VFMZCREDNZR>>>, Id32<TVAMPUAMYRD<XSPVEGMZPQH<VFMZCREDNZR>>>) CVQFZHVWDVG(this UnsafeList<byte> a, [Optional] Id32<XSPVEGMZPQH<VFMZCREDNZR>>? b, [Optional] Id32<XSPVEGMZPQH<VFMZCREDNZR>>? c, [Optional] Id32<XSPVEGMZPQH<VFMZCREDNZR>>? d)
		{
			return default((Id32<TVAMPUAMYRD<NODNFPCIRRW>>, Id32<TVAMPUAMYRD<XSPVEGMZPQH<VFMZCREDNZR>>>, Id32<TVAMPUAMYRD<XSPVEGMZPQH<VFMZCREDNZR>>>, Id32<TVAMPUAMYRD<XSPVEGMZPQH<VFMZCREDNZR>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x2B8CE60", Offset = "0x2B8B860", VA = "0x182B8CE60")]
		public static (Id32<TVAMPUAMYRD<NODNFPCIRRW>>, Id32<TVAMPUAMYRD<GQNEASXRVOC>>, Id32<TVAMPUAMYRD<GQNEASXRVOC>>, Id32<TVAMPUAMYRD<XSPVEGMZPQH<VFMZCREDNZR>>>) ETERVEBPKBJ(this UnsafeList<byte> a, float b, float c, [Optional] Id32<XSPVEGMZPQH<VFMZCREDNZR>>? d)
		{
			return default((Id32<TVAMPUAMYRD<NODNFPCIRRW>>, Id32<TVAMPUAMYRD<GQNEASXRVOC>>, Id32<TVAMPUAMYRD<GQNEASXRVOC>>, Id32<TVAMPUAMYRD<XSPVEGMZPQH<VFMZCREDNZR>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x2B8DCB0", Offset = "0x2B8C6B0", VA = "0x182B8DCB0")]
		public static (Id32<TVAMPUAMYRD<NODNFPCIRRW>>, Id32<TVAMPUAMYRD<GQNEASXRVOC>>, Id32<TVAMPUAMYRD<XSPVEGMZPQH<GQNEASXRVOC>>>, Id32<TVAMPUAMYRD<XSPVEGMZPQH<VFMZCREDNZR>>>) JEETOZAOUOY(this UnsafeList<byte> a, float b, [Optional] Id32<XSPVEGMZPQH<GQNEASXRVOC>>? c, [Optional] Id32<XSPVEGMZPQH<VFMZCREDNZR>>? d)
		{
			return default((Id32<TVAMPUAMYRD<NODNFPCIRRW>>, Id32<TVAMPUAMYRD<GQNEASXRVOC>>, Id32<TVAMPUAMYRD<XSPVEGMZPQH<GQNEASXRVOC>>>, Id32<TVAMPUAMYRD<XSPVEGMZPQH<VFMZCREDNZR>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x2B8F1E0", Offset = "0x2B8DBE0", VA = "0x182B8F1E0")]
		public static (Id32<TVAMPUAMYRD<NODNFPCIRRW>>, Id32<TVAMPUAMYRD<XSPVEGMZPQH<GQNEASXRVOC>>>, Id32<TVAMPUAMYRD<XSPVEGMZPQH<GQNEASXRVOC>>>, Id32<TVAMPUAMYRD<XSPVEGMZPQH<VFMZCREDNZR>>>) PCBHDRAVUHP(this UnsafeList<byte> a, [Optional] Id32<XSPVEGMZPQH<GQNEASXRVOC>>? b, [Optional] Id32<XSPVEGMZPQH<GQNEASXRVOC>>? c, [Optional] Id32<XSPVEGMZPQH<VFMZCREDNZR>>? d)
		{
			return default((Id32<TVAMPUAMYRD<NODNFPCIRRW>>, Id32<TVAMPUAMYRD<XSPVEGMZPQH<GQNEASXRVOC>>>, Id32<TVAMPUAMYRD<XSPVEGMZPQH<GQNEASXRVOC>>>, Id32<TVAMPUAMYRD<XSPVEGMZPQH<VFMZCREDNZR>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x2B8F540", Offset = "0x2B8DF40", VA = "0x182B8F540")]
		public static (Id32<TVAMPUAMYRD<NODNFPCIRRW>>, Id32<TVAMPUAMYRD<VFMZCREDNZR>>, Id32<TVAMPUAMYRD<VFMZCREDNZR>>, Id32<TVAMPUAMYRD<XSPVEGMZPQH<VFMZCREDNZR>>>) QGBXJYLGESG(this UnsafeList<byte> a, int b, int c, [Optional] Id32<XSPVEGMZPQH<VFMZCREDNZR>>? d)
		{
			return default((Id32<TVAMPUAMYRD<NODNFPCIRRW>>, Id32<TVAMPUAMYRD<VFMZCREDNZR>>, Id32<TVAMPUAMYRD<VFMZCREDNZR>>, Id32<TVAMPUAMYRD<XSPVEGMZPQH<VFMZCREDNZR>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x2B8EDE0", Offset = "0x2B8D7E0", VA = "0x182B8EDE0")]
		public static (Id32<TVAMPUAMYRD<NODNFPCIRRW>>, Id32<TVAMPUAMYRD<VFMZCREDNZR>>, Id32<TVAMPUAMYRD<XSPVEGMZPQH<VFMZCREDNZR>>>, Id32<TVAMPUAMYRD<XSPVEGMZPQH<VFMZCREDNZR>>>) ONKOVAAKZIR(this UnsafeList<byte> a, int b, [Optional] Id32<XSPVEGMZPQH<VFMZCREDNZR>>? c, [Optional] Id32<XSPVEGMZPQH<VFMZCREDNZR>>? d)
		{
			return default((Id32<TVAMPUAMYRD<NODNFPCIRRW>>, Id32<TVAMPUAMYRD<VFMZCREDNZR>>, Id32<TVAMPUAMYRD<XSPVEGMZPQH<VFMZCREDNZR>>>, Id32<TVAMPUAMYRD<XSPVEGMZPQH<VFMZCREDNZR>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x2B8F7B0", Offset = "0x2B8E1B0", VA = "0x182B8F7B0")]
		public static (Id32<TVAMPUAMYRD<NODNFPCIRRW>>, Id32<TVAMPUAMYRD<XSPVEGMZPQH<VFMZCREDNZR>>>, Id32<TVAMPUAMYRD<XSPVEGMZPQH<VFMZCREDNZR>>>, Id32<TVAMPUAMYRD<XSPVEGMZPQH<VFMZCREDNZR>>>) QZXETOYZPHC(this UnsafeList<byte> a, [Optional] Id32<XSPVEGMZPQH<VFMZCREDNZR>>? b, [Optional] Id32<XSPVEGMZPQH<VFMZCREDNZR>>? c, [Optional] Id32<XSPVEGMZPQH<VFMZCREDNZR>>? d)
		{
			return default((Id32<TVAMPUAMYRD<NODNFPCIRRW>>, Id32<TVAMPUAMYRD<XSPVEGMZPQH<VFMZCREDNZR>>>, Id32<TVAMPUAMYRD<XSPVEGMZPQH<VFMZCREDNZR>>>, Id32<TVAMPUAMYRD<XSPVEGMZPQH<VFMZCREDNZR>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x2B8C6E0", Offset = "0x2B8B0E0", VA = "0x182B8C6E0")]
		public static (Id32<TVAMPUAMYRD<NODNFPCIRRW>>, Id32<TVAMPUAMYRD<GQNEASXRVOC>>, Id32<TVAMPUAMYRD<GQNEASXRVOC>>, Id32<TVAMPUAMYRD<XSPVEGMZPQH<VFMZCREDNZR>>>) CJHPVKRVRTQ(this UnsafeList<byte> a, float b, float c, [Optional] Id32<XSPVEGMZPQH<VFMZCREDNZR>>? d)
		{
			return default((Id32<TVAMPUAMYRD<NODNFPCIRRW>>, Id32<TVAMPUAMYRD<GQNEASXRVOC>>, Id32<TVAMPUAMYRD<GQNEASXRVOC>>, Id32<TVAMPUAMYRD<XSPVEGMZPQH<VFMZCREDNZR>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x2B8C450", Offset = "0x2B8AE50", VA = "0x182B8C450")]
		public static (Id32<TVAMPUAMYRD<NODNFPCIRRW>>, Id32<TVAMPUAMYRD<GQNEASXRVOC>>, Id32<TVAMPUAMYRD<XSPVEGMZPQH<GQNEASXRVOC>>>, Id32<TVAMPUAMYRD<XSPVEGMZPQH<VFMZCREDNZR>>>) BRGWAOUQNOF(this UnsafeList<byte> a, float b, [Optional] Id32<XSPVEGMZPQH<GQNEASXRVOC>>? c, [Optional] Id32<XSPVEGMZPQH<VFMZCREDNZR>>? d)
		{
			return default((Id32<TVAMPUAMYRD<NODNFPCIRRW>>, Id32<TVAMPUAMYRD<GQNEASXRVOC>>, Id32<TVAMPUAMYRD<XSPVEGMZPQH<GQNEASXRVOC>>>, Id32<TVAMPUAMYRD<XSPVEGMZPQH<VFMZCREDNZR>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x2B8DA60", Offset = "0x2B8C460", VA = "0x182B8DA60")]
		public static (Id32<TVAMPUAMYRD<NODNFPCIRRW>>, Id32<TVAMPUAMYRD<XSPVEGMZPQH<GQNEASXRVOC>>>, Id32<TVAMPUAMYRD<XSPVEGMZPQH<GQNEASXRVOC>>>, Id32<TVAMPUAMYRD<XSPVEGMZPQH<VFMZCREDNZR>>>) IOJAJDLLVZW(this UnsafeList<byte> a, [Optional] Id32<XSPVEGMZPQH<GQNEASXRVOC>>? b, [Optional] Id32<XSPVEGMZPQH<GQNEASXRVOC>>? c, [Optional] Id32<XSPVEGMZPQH<VFMZCREDNZR>>? d)
		{
			return default((Id32<TVAMPUAMYRD<NODNFPCIRRW>>, Id32<TVAMPUAMYRD<XSPVEGMZPQH<GQNEASXRVOC>>>, Id32<TVAMPUAMYRD<XSPVEGMZPQH<GQNEASXRVOC>>>, Id32<TVAMPUAMYRD<XSPVEGMZPQH<VFMZCREDNZR>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x2B8D500", Offset = "0x2B8BF00", VA = "0x182B8D500")]
		public static (Id32<TVAMPUAMYRD<NODNFPCIRRW>>, Id32<TVAMPUAMYRD<VFMZCREDNZR>>, Id32<TVAMPUAMYRD<VFMZCREDNZR>>, Id32<TVAMPUAMYRD<XSPVEGMZPQH<VFMZCREDNZR>>>) HKVYBFWSUBR(this UnsafeList<byte> a, int b, int c, [Optional] Id32<XSPVEGMZPQH<VFMZCREDNZR>>? d)
		{
			return default((Id32<TVAMPUAMYRD<NODNFPCIRRW>>, Id32<TVAMPUAMYRD<VFMZCREDNZR>>, Id32<TVAMPUAMYRD<VFMZCREDNZR>>, Id32<TVAMPUAMYRD<XSPVEGMZPQH<VFMZCREDNZR>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x2B8D3B0", Offset = "0x2B8BDB0", VA = "0x182B8D3B0")]
		public static (Id32<TVAMPUAMYRD<NODNFPCIRRW>>, Id32<TVAMPUAMYRD<VFMZCREDNZR>>, Id32<TVAMPUAMYRD<XSPVEGMZPQH<VFMZCREDNZR>>>, Id32<TVAMPUAMYRD<XSPVEGMZPQH<VFMZCREDNZR>>>) GJYSUMEDNTS(this UnsafeList<byte> a, int b, [Optional] Id32<XSPVEGMZPQH<VFMZCREDNZR>>? c, [Optional] Id32<XSPVEGMZPQH<VFMZCREDNZR>>? d)
		{
			return default((Id32<TVAMPUAMYRD<NODNFPCIRRW>>, Id32<TVAMPUAMYRD<VFMZCREDNZR>>, Id32<TVAMPUAMYRD<XSPVEGMZPQH<VFMZCREDNZR>>>, Id32<TVAMPUAMYRD<XSPVEGMZPQH<VFMZCREDNZR>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x2B8CD40", Offset = "0x2B8B740", VA = "0x182B8CD40")]
		public static (Id32<TVAMPUAMYRD<NODNFPCIRRW>>, Id32<TVAMPUAMYRD<XSPVEGMZPQH<VFMZCREDNZR>>>, Id32<TVAMPUAMYRD<XSPVEGMZPQH<VFMZCREDNZR>>>, Id32<TVAMPUAMYRD<XSPVEGMZPQH<VFMZCREDNZR>>>) EJBLZEPBBVH(this UnsafeList<byte> a, [Optional] Id32<XSPVEGMZPQH<VFMZCREDNZR>>? b, [Optional] Id32<XSPVEGMZPQH<VFMZCREDNZR>>? c, [Optional] Id32<XSPVEGMZPQH<VFMZCREDNZR>>? d)
		{
			return default((Id32<TVAMPUAMYRD<NODNFPCIRRW>>, Id32<TVAMPUAMYRD<XSPVEGMZPQH<VFMZCREDNZR>>>, Id32<TVAMPUAMYRD<XSPVEGMZPQH<VFMZCREDNZR>>>, Id32<TVAMPUAMYRD<XSPVEGMZPQH<VFMZCREDNZR>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x2B8FC90", Offset = "0x2B8E690", VA = "0x182B8FC90")]
		public static (Id32<TVAMPUAMYRD<NODNFPCIRRW>>, Id32<TVAMPUAMYRD<GQNEASXRVOC>>, Id32<TVAMPUAMYRD<GQNEASXRVOC>>, Id32<TVAMPUAMYRD<XSPVEGMZPQH<GQNEASXRVOC>>>) SASCCROACZT(this UnsafeList<byte> a, float b, float c, [Optional] Id32<XSPVEGMZPQH<GQNEASXRVOC>>? d)
		{
			return default((Id32<TVAMPUAMYRD<NODNFPCIRRW>>, Id32<TVAMPUAMYRD<GQNEASXRVOC>>, Id32<TVAMPUAMYRD<GQNEASXRVOC>>, Id32<TVAMPUAMYRD<XSPVEGMZPQH<GQNEASXRVOC>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x2B8BE00", Offset = "0x2B8A800", VA = "0x182B8BE00")]
		public static (Id32<TVAMPUAMYRD<NODNFPCIRRW>>, Id32<TVAMPUAMYRD<GQNEASXRVOC>>, Id32<TVAMPUAMYRD<XSPVEGMZPQH<GQNEASXRVOC>>>, Id32<TVAMPUAMYRD<XSPVEGMZPQH<GQNEASXRVOC>>>) AJQBGOFHPNU(this UnsafeList<byte> a, float b, [Optional] Id32<XSPVEGMZPQH<GQNEASXRVOC>>? c, [Optional] Id32<XSPVEGMZPQH<GQNEASXRVOC>>? d)
		{
			return default((Id32<TVAMPUAMYRD<NODNFPCIRRW>>, Id32<TVAMPUAMYRD<GQNEASXRVOC>>, Id32<TVAMPUAMYRD<XSPVEGMZPQH<GQNEASXRVOC>>>, Id32<TVAMPUAMYRD<XSPVEGMZPQH<GQNEASXRVOC>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x2B8D940", Offset = "0x2B8C340", VA = "0x182B8D940")]
		public static (Id32<TVAMPUAMYRD<NODNFPCIRRW>>, Id32<TVAMPUAMYRD<XSPVEGMZPQH<GQNEASXRVOC>>>, Id32<TVAMPUAMYRD<XSPVEGMZPQH<GQNEASXRVOC>>>, Id32<TVAMPUAMYRD<XSPVEGMZPQH<GQNEASXRVOC>>>) HWCITTJPTLB(this UnsafeList<byte> a, [Optional] Id32<XSPVEGMZPQH<GQNEASXRVOC>>? b, [Optional] Id32<XSPVEGMZPQH<GQNEASXRVOC>>? c, [Optional] Id32<XSPVEGMZPQH<GQNEASXRVOC>>? d)
		{
			return default((Id32<TVAMPUAMYRD<NODNFPCIRRW>>, Id32<TVAMPUAMYRD<XSPVEGMZPQH<GQNEASXRVOC>>>, Id32<TVAMPUAMYRD<XSPVEGMZPQH<GQNEASXRVOC>>>, Id32<TVAMPUAMYRD<XSPVEGMZPQH<GQNEASXRVOC>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x2B91270", Offset = "0x2B8FC70", VA = "0x182B91270")]
		public static (Id32<TVAMPUAMYRD<NODNFPCIRRW>>, Id32<TVAMPUAMYRD<VFMZCREDNZR>>, Id32<TVAMPUAMYRD<VFMZCREDNZR>>, Id32<TVAMPUAMYRD<XSPVEGMZPQH<VFMZCREDNZR>>>) ZHOSUMCQDKD(this UnsafeList<byte> a, int b, int c, [Optional] Id32<XSPVEGMZPQH<VFMZCREDNZR>>? d)
		{
			return default((Id32<TVAMPUAMYRD<NODNFPCIRRW>>, Id32<TVAMPUAMYRD<VFMZCREDNZR>>, Id32<TVAMPUAMYRD<VFMZCREDNZR>>, Id32<TVAMPUAMYRD<XSPVEGMZPQH<VFMZCREDNZR>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x2B8E930", Offset = "0x2B8D330", VA = "0x182B8E930")]
		public static (Id32<TVAMPUAMYRD<NODNFPCIRRW>>, Id32<TVAMPUAMYRD<VFMZCREDNZR>>, Id32<TVAMPUAMYRD<XSPVEGMZPQH<VFMZCREDNZR>>>, Id32<TVAMPUAMYRD<XSPVEGMZPQH<VFMZCREDNZR>>>) NMPJGLSRXUY(this UnsafeList<byte> a, int b, [Optional] Id32<XSPVEGMZPQH<VFMZCREDNZR>>? c, [Optional] Id32<XSPVEGMZPQH<VFMZCREDNZR>>? d)
		{
			return default((Id32<TVAMPUAMYRD<NODNFPCIRRW>>, Id32<TVAMPUAMYRD<VFMZCREDNZR>>, Id32<TVAMPUAMYRD<XSPVEGMZPQH<VFMZCREDNZR>>>, Id32<TVAMPUAMYRD<XSPVEGMZPQH<VFMZCREDNZR>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x2B8CAA0", Offset = "0x2B8B4A0", VA = "0x182B8CAA0")]
		public static (Id32<TVAMPUAMYRD<NODNFPCIRRW>>, Id32<TVAMPUAMYRD<XSPVEGMZPQH<VFMZCREDNZR>>>, Id32<TVAMPUAMYRD<XSPVEGMZPQH<VFMZCREDNZR>>>, Id32<TVAMPUAMYRD<XSPVEGMZPQH<VFMZCREDNZR>>>) DCMWIZILYWZ(this UnsafeList<byte> a, [Optional] Id32<XSPVEGMZPQH<VFMZCREDNZR>>? b, [Optional] Id32<XSPVEGMZPQH<VFMZCREDNZR>>? c, [Optional] Id32<XSPVEGMZPQH<VFMZCREDNZR>>? d)
		{
			return default((Id32<TVAMPUAMYRD<NODNFPCIRRW>>, Id32<TVAMPUAMYRD<XSPVEGMZPQH<VFMZCREDNZR>>>, Id32<TVAMPUAMYRD<XSPVEGMZPQH<VFMZCREDNZR>>>, Id32<TVAMPUAMYRD<XSPVEGMZPQH<VFMZCREDNZR>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x2B8F6A0", Offset = "0x2B8E0A0", VA = "0x182B8F6A0")]
		public static (Id32<TVAMPUAMYRD<NODNFPCIRRW>>, Id32<TVAMPUAMYRD<VFMZCREDNZR>>, Id32<TVAMPUAMYRD<XSPVEGMZPQH<VFMZCREDNZR>>>) QOEQZBNEVME(this UnsafeList<byte> a, [Optional] int? b, [Optional] Id32<XSPVEGMZPQH<VFMZCREDNZR>>? c)
		{
			return default((Id32<TVAMPUAMYRD<NODNFPCIRRW>>, Id32<TVAMPUAMYRD<VFMZCREDNZR>>, Id32<TVAMPUAMYRD<XSPVEGMZPQH<VFMZCREDNZR>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x2B8F310", Offset = "0x2B8DD10", VA = "0x182B8F310")]
		public static (Id32<TVAMPUAMYRD<NODNFPCIRRW>>, Id32<TVAMPUAMYRD<XSPVEGMZPQH<VFMZCREDNZR>>>, Id32<TVAMPUAMYRD<XSPVEGMZPQH<VFMZCREDNZR>>>) PGRDBAGNYYX(this UnsafeList<byte> a, [Optional] Id32<XSPVEGMZPQH<VFMZCREDNZR>>? b, [Optional] Id32<XSPVEGMZPQH<VFMZCREDNZR>>? c)
		{
			return default((Id32<TVAMPUAMYRD<NODNFPCIRRW>>, Id32<TVAMPUAMYRD<XSPVEGMZPQH<VFMZCREDNZR>>>, Id32<TVAMPUAMYRD<XSPVEGMZPQH<VFMZCREDNZR>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x2B91070", Offset = "0x2B8FA70", VA = "0x182B91070")]
		public static Id32<TVAMPUAMYRD<NODNFPCIRRW>> YWDEGVDFTOK(this UnsafeList<byte> a)
		{
			return default(Id32<TVAMPUAMYRD<NODNFPCIRRW>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x2B8CBC0", Offset = "0x2B8B5C0", VA = "0x182B8CBC0")]
		public static (Id32<TVAMPUAMYRD<NODNFPCIRRW>>, Id32<TVAMPUAMYRD<GQNEASXRVOC>>, Id32<TVAMPUAMYRD<GQNEASXRVOC>>, Id32<TVAMPUAMYRD<XSPVEGMZPQH<GQNEASXRVOC>>>) EHOBWQUHUDD(this UnsafeList<byte> a, float b, float c, [Optional] Id32<XSPVEGMZPQH<GQNEASXRVOC>>? d)
		{
			return default((Id32<TVAMPUAMYRD<NODNFPCIRRW>>, Id32<TVAMPUAMYRD<GQNEASXRVOC>>, Id32<TVAMPUAMYRD<GQNEASXRVOC>>, Id32<TVAMPUAMYRD<XSPVEGMZPQH<GQNEASXRVOC>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x2B8DF40", Offset = "0x2B8C940", VA = "0x182B8DF40")]
		public static (Id32<TVAMPUAMYRD<NODNFPCIRRW>>, Id32<TVAMPUAMYRD<GQNEASXRVOC>>, Id32<TVAMPUAMYRD<XSPVEGMZPQH<GQNEASXRVOC>>>, Id32<TVAMPUAMYRD<XSPVEGMZPQH<GQNEASXRVOC>>>) JTDZXRRHFRY(this UnsafeList<byte> a, float b, [Optional] Id32<XSPVEGMZPQH<GQNEASXRVOC>>? c, [Optional] Id32<XSPVEGMZPQH<GQNEASXRVOC>>? d)
		{
			return default((Id32<TVAMPUAMYRD<NODNFPCIRRW>>, Id32<TVAMPUAMYRD<GQNEASXRVOC>>, Id32<TVAMPUAMYRD<XSPVEGMZPQH<GQNEASXRVOC>>>, Id32<TVAMPUAMYRD<XSPVEGMZPQH<GQNEASXRVOC>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x2B90BD0", Offset = "0x2B8F5D0", VA = "0x182B90BD0")]
		public static (Id32<TVAMPUAMYRD<NODNFPCIRRW>>, Id32<TVAMPUAMYRD<XSPVEGMZPQH<GQNEASXRVOC>>>, Id32<TVAMPUAMYRD<XSPVEGMZPQH<GQNEASXRVOC>>>, Id32<TVAMPUAMYRD<XSPVEGMZPQH<GQNEASXRVOC>>>) XIYURJNWXKH(this UnsafeList<byte> a, [Optional] Id32<XSPVEGMZPQH<GQNEASXRVOC>>? b, [Optional] Id32<XSPVEGMZPQH<GQNEASXRVOC>>? c, [Optional] Id32<XSPVEGMZPQH<GQNEASXRVOC>>? d)
		{
			return default((Id32<TVAMPUAMYRD<NODNFPCIRRW>>, Id32<TVAMPUAMYRD<XSPVEGMZPQH<GQNEASXRVOC>>>, Id32<TVAMPUAMYRD<XSPVEGMZPQH<GQNEASXRVOC>>>, Id32<TVAMPUAMYRD<XSPVEGMZPQH<GQNEASXRVOC>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x2B8F9E0", Offset = "0x2B8E3E0", VA = "0x182B8F9E0")]
		public static (Id32<TVAMPUAMYRD<NODNFPCIRRW>>, Id32<TVAMPUAMYRD<VFMZCREDNZR>>, Id32<TVAMPUAMYRD<VFMZCREDNZR>>, Id32<TVAMPUAMYRD<XSPVEGMZPQH<VFMZCREDNZR>>>) RHXVAXDNMEX(this UnsafeList<byte> a, int b, int c, [Optional] Id32<XSPVEGMZPQH<VFMZCREDNZR>>? d)
		{
			return default((Id32<TVAMPUAMYRD<NODNFPCIRRW>>, Id32<TVAMPUAMYRD<VFMZCREDNZR>>, Id32<TVAMPUAMYRD<VFMZCREDNZR>>, Id32<TVAMPUAMYRD<XSPVEGMZPQH<VFMZCREDNZR>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x2B8D100", Offset = "0x2B8BB00", VA = "0x182B8D100")]
		public static (Id32<TVAMPUAMYRD<NODNFPCIRRW>>, Id32<TVAMPUAMYRD<VFMZCREDNZR>>, Id32<TVAMPUAMYRD<XSPVEGMZPQH<VFMZCREDNZR>>>, Id32<TVAMPUAMYRD<XSPVEGMZPQH<VFMZCREDNZR>>>) FNPHEDVHDPO(this UnsafeList<byte> a, int b, [Optional] Id32<XSPVEGMZPQH<VFMZCREDNZR>>? c, [Optional] Id32<XSPVEGMZPQH<VFMZCREDNZR>>? d)
		{
			return default((Id32<TVAMPUAMYRD<NODNFPCIRRW>>, Id32<TVAMPUAMYRD<VFMZCREDNZR>>, Id32<TVAMPUAMYRD<XSPVEGMZPQH<VFMZCREDNZR>>>, Id32<TVAMPUAMYRD<XSPVEGMZPQH<VFMZCREDNZR>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x2B8EBD0", Offset = "0x2B8D5D0", VA = "0x182B8EBD0")]
		public static (Id32<TVAMPUAMYRD<NODNFPCIRRW>>, Id32<TVAMPUAMYRD<XSPVEGMZPQH<VFMZCREDNZR>>>, Id32<TVAMPUAMYRD<XSPVEGMZPQH<VFMZCREDNZR>>>, Id32<TVAMPUAMYRD<XSPVEGMZPQH<VFMZCREDNZR>>>) OHQCPANNNWZ(this UnsafeList<byte> a, [Optional] Id32<XSPVEGMZPQH<VFMZCREDNZR>>? b, [Optional] Id32<XSPVEGMZPQH<VFMZCREDNZR>>? c, [Optional] Id32<XSPVEGMZPQH<VFMZCREDNZR>>? d)
		{
			return default((Id32<TVAMPUAMYRD<NODNFPCIRRW>>, Id32<TVAMPUAMYRD<XSPVEGMZPQH<VFMZCREDNZR>>>, Id32<TVAMPUAMYRD<XSPVEGMZPQH<VFMZCREDNZR>>>, Id32<TVAMPUAMYRD<XSPVEGMZPQH<VFMZCREDNZR>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x2B8D250", Offset = "0x2B8BC50", VA = "0x182B8D250")]
		public static (Id32<TVAMPUAMYRD<NODNFPCIRRW>>, Id32<TVAMPUAMYRD<VFMZCREDNZR>>, Id32<TVAMPUAMYRD<VFMZCREDNZR>>, Id32<TVAMPUAMYRD<XSPVEGMZPQH<VFMZCREDNZR>>>) GBNSTKMLGDA(this UnsafeList<byte> a, int b, int c, [Optional] Id32<XSPVEGMZPQH<VFMZCREDNZR>>? d)
		{
			return default((Id32<TVAMPUAMYRD<NODNFPCIRRW>>, Id32<TVAMPUAMYRD<VFMZCREDNZR>>, Id32<TVAMPUAMYRD<VFMZCREDNZR>>, Id32<TVAMPUAMYRD<XSPVEGMZPQH<VFMZCREDNZR>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x2B8BF50", Offset = "0x2B8A950", VA = "0x182B8BF50")]
		public static (Id32<TVAMPUAMYRD<NODNFPCIRRW>>, Id32<TVAMPUAMYRD<VFMZCREDNZR>>, Id32<TVAMPUAMYRD<XSPVEGMZPQH<VFMZCREDNZR>>>, Id32<TVAMPUAMYRD<XSPVEGMZPQH<VFMZCREDNZR>>>) ALDTUIAKVIV(this UnsafeList<byte> a, int b, [Optional] Id32<XSPVEGMZPQH<VFMZCREDNZR>>? c, [Optional] Id32<XSPVEGMZPQH<VFMZCREDNZR>>? d)
		{
			return default((Id32<TVAMPUAMYRD<NODNFPCIRRW>>, Id32<TVAMPUAMYRD<VFMZCREDNZR>>, Id32<TVAMPUAMYRD<XSPVEGMZPQH<VFMZCREDNZR>>>, Id32<TVAMPUAMYRD<XSPVEGMZPQH<VFMZCREDNZR>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x2B8DB90", Offset = "0x2B8C590", VA = "0x182B8DB90")]
		public static (Id32<TVAMPUAMYRD<NODNFPCIRRW>>, Id32<TVAMPUAMYRD<XSPVEGMZPQH<VFMZCREDNZR>>>, Id32<TVAMPUAMYRD<XSPVEGMZPQH<VFMZCREDNZR>>>, Id32<TVAMPUAMYRD<XSPVEGMZPQH<VFMZCREDNZR>>>) IZPAFRBNNSA(this UnsafeList<byte> a, [Optional] Id32<XSPVEGMZPQH<VFMZCREDNZR>>? b, [Optional] Id32<XSPVEGMZPQH<VFMZCREDNZR>>? c, [Optional] Id32<XSPVEGMZPQH<VFMZCREDNZR>>? d)
		{
			return default((Id32<TVAMPUAMYRD<NODNFPCIRRW>>, Id32<TVAMPUAMYRD<XSPVEGMZPQH<VFMZCREDNZR>>>, Id32<TVAMPUAMYRD<XSPVEGMZPQH<VFMZCREDNZR>>>, Id32<TVAMPUAMYRD<XSPVEGMZPQH<VFMZCREDNZR>>>));
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
