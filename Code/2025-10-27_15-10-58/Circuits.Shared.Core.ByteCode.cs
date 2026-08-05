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
		[Cpp2IlInjected.Address(RVA = "0xAF86F0", Offset = "0xAF76F0", VA = "0x180AF86F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x2B72940", Offset = "0x2B71940", VA = "0x182B72940")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xAF8940", Offset = "0xAF7940", VA = "0x180AF8940")]
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
		[Cpp2IlInjected.Address(RVA = "0xAF8980", Offset = "0xAF7980", VA = "0x180AF8980")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
namespace Circuits.Shared.Core.ByteCode
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public static class LONGZSJYBLM
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x3A5EEA0", Offset = "0x3A5DEA0", VA = "0x183A5EEA0")]
		public static Id32<NJHHKJCVQUE<a>> JTPBCNHDMCI<a>(this int a)
		{
			return default(Id32<NJHHKJCVQUE<a>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x2B72900", Offset = "0x2B71900", VA = "0x182B72900")]
		public static Id32<MCZYZSSYBNX> JVPHXCEGDLT(this int a)
		{
			return default(Id32<MCZYZSSYBNX>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x3A5EEA0", Offset = "0x3A5DEA0", VA = "0x183A5EEA0")]
		public static Id32<XPYIVJGMLOO<b>> ZFIHIOPQDVA<b>(this int a)
		{
			return default(Id32<XPYIVJGMLOO<b>>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public sealed class NJHHKJCVQUE<a>
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public sealed class GMCOSWDRAOD
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public sealed class RXCTQXXFICO
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public sealed class MCZYZSSYBNX
	{
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public sealed class VAWWUJGMVPZ
	{
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public sealed class JNCTGJVABPH
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
	public static class AMAJZZUTRBA
	{
		[Cpp2IlInjected.Token(Token = "0x200000E")]
		public readonly struct ProcessOpDelegate<TContext, TDeps, TCompileState>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000091")]
			private readonly IntPtr _impl;

			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0xF99620", Offset = "0xF98620", VA = "0x180F99620")]
			public ProcessOpDelegate(IntPtr impl)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x5DF0630", Offset = "0x5DEF630", VA = "0x185DF0630")]
			public int Invoke(TDeps deps, TContext ctx, TCompileState compileState, [In] UnsafeList<byte> fromByteCode, int byteCodePtr)
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x3317830", Offset = "0x3316830", VA = "0x183317830")]
		public static void BFLPEPPGXDH<TDeps, TContext, TCompileState>(TDeps a, TContext b, TCompileState c, [In] UnsafeList<byte> oldByteCode, UnsafeList<byte> newByteCode, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processAddF32_F32i_F32i_F32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processAddF32_F32i_F32r_F32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processAddF32_F32r_F32r_F32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processAddI32_I32i_I32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processAddI32_I32i_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processAddI32_I32r_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processAndI32_I32i_I32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processAndI32_I32i_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processAndI32_I32r_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfEqualF32_F32i_F32i_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfEqualF32_F32i_F32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfEqualF32_F32r_F32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfEqualI32_I32i_I32i_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfEqualI32_I32i_I32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfEqualI32_I32r_I32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfGreaterOrEqualF32_F32i_F32i_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfGreaterOrEqualF32_F32i_F32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfGreaterOrEqualF32_F32r_F32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfGreaterOrEqualI32_I32i_I32i_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfGreaterOrEqualI32_I32i_I32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfGreaterOrEqualI32_I32r_I32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfLessF32_F32i_F32i_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfLessF32_F32i_F32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfLessF32_F32r_F32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfLessI32_I32i_I32i_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfLessI32_I32i_I32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfLessI32_I32r_I32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfLessOrEqualF32_F32i_F32i_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfLessOrEqualF32_F32i_F32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfLessOrEqualF32_F32r_F32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfLessOrEqualI32_I32i_I32i_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfLessOrEqualI32_I32i_I32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfLessOrEqualI32_I32r_I32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfNotEqualF32_F32i_F32i_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfNotEqualF32_F32i_F32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfNotEqualF32_F32r_F32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfNotEqualI32_I32i_I32i_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfNotEqualI32_I32i_I32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfNotEqualI32_I32r_I32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfNotZeroF32_F32i_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfNotZeroF32_F32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfNotZeroI32_I32i_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfNotZeroI32_I32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfZeroF32_F32i_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfZeroF32_F32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfZeroI32_I32i_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfZeroI32_I32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processCallInternal_I32i_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processCallInternal_I32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processCallExternal_I32i_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processCallExternal_I32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processCallRuntime_I32i_I32i_Xi, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processCopyI32_I32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processCopyI32_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processCopyX_Xr_I32i_Xi, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processCopyX_Xr_Xr_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processDivideF32_F32i_F32i_F32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processDivideF32_F32i_F32r_F32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processDivideF32_F32r_F32r_F32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processDivideI32_I32i_I32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processDivideI32_I32i_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processDivideI32_I32r_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processEqualF32_F32i_F32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processEqualF32_F32i_F32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processEqualF32_F32r_F32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processEqualI32_I32i_I32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processEqualI32_I32i_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processEqualI32_I32r_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processEnd, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processGreaterF32_F32i_F32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processGreaterF32_F32i_F32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processGreaterF32_F32r_F32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processGreaterI32_I32i_I32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processGreaterI32_I32i_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processGreaterI32_I32r_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processGreaterOrEqualF32_F32i_F32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processGreaterOrEqualF32_F32i_F32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processGreaterOrEqualF32_F32r_F32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processGreaterOrEqualI32_I32i_I32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processGreaterOrEqualI32_I32i_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processGreaterOrEqualI32_I32r_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processJump_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processJump_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processLessF32_F32i_F32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processLessF32_F32i_F32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processLessF32_F32r_F32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processLessI32_I32i_I32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processLessI32_I32i_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processLessI32_I32r_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processLessOrEqualF32_F32i_F32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processLessOrEqualF32_F32i_F32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processLessOrEqualF32_F32r_F32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processLessOrEqualI32_I32i_I32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processLessOrEqualI32_I32i_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processLessOrEqualI32_I32r_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processModI32_I32i_I32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processModI32_I32i_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processModI32_I32r_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processMultiplyF32_F32i_F32i_F32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processMultiplyF32_F32i_F32r_F32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processMultiplyF32_F32r_F32r_F32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processMultiplyI32_I32i_I32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processMultiplyI32_I32i_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processMultiplyI32_I32r_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processNegateF32_F32i_F32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processNegateF32_F32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processNegateF32_F32r_F32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processNegateI32_I32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processNegateI32_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processNegateI32_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processNoOp, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processNotEqualF32_F32i_F32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processNotEqualF32_F32i_F32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processNotEqualF32_F32r_F32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processNotEqualI32_I32i_I32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processNotEqualI32_I32i_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processNotEqualI32_I32r_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processNotI32_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processNotI32_I32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processNotI32_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processOrI32_I32i_I32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processOrI32_I32i_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processOrI32_I32r_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processReturn, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processStaticCastF32I32_F32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processStaticCastI32F32_I32r_F32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processSubtractF32_F32i_F32i_F32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processSubtractF32_F32i_F32r_F32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processSubtractF32_F32r_F32r_F32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processSubtractI32_I32i_I32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processSubtractI32_I32i_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processSubtractI32_I32r_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processXorI32_I32i_I32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processXorI32_I32i_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processXorI32_I32r_I32r_I32r) where TDeps : notnull where TContext : notnull where TCompileState : notnull
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x2B6C6E0", Offset = "0x2B6B6E0", VA = "0x182B6C6E0")]
		private static int SDSRVBDQYRJ([In] UnsafeList<byte> from, UnsafeList<byte> a, int b, int c)
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public static class IAMMIKXTECB
	{
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		public static readonly int NXVKVJERCSV;

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x39C5AA0", Offset = "0x39C4AA0", VA = "0x1839C5AA0")]
		public static Id32<NJHHKJCVQUE<a>> VJWBOHXDYNN<a>([In] this UnsafeList<byte> self)
		{
			return default(Id32<NJHHKJCVQUE<a>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x39C5970", Offset = "0x39C4970", VA = "0x1839C5970")]
		public static Id32<NJHHKJCVQUE<NJHHKJCVQUE<b>>> YZXZLRSPFYM<b>(this UnsafeList<byte> a, [Optional] Id32<NJHHKJCVQUE<b>>? b)
		{
			return default(Id32<NJHHKJCVQUE<NJHHKJCVQUE<b>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x2B72410", Offset = "0x2B71410", VA = "0x182B72410")]
		public static Id32<NJHHKJCVQUE<DMXLEVIULSD>> GZSAYXRNULY(this UnsafeList<byte> a, [Optional] Id32<DMXLEVIULSD>? b)
		{
			return default(Id32<NJHHKJCVQUE<DMXLEVIULSD>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x2B727D0", Offset = "0x2B717D0", VA = "0x182B727D0")]
		public static Id32<NJHHKJCVQUE<GMCOSWDRAOD>> WPBHQGFOTAY(this UnsafeList<byte> a, [Optional] float? b)
		{
			return default(Id32<NJHHKJCVQUE<GMCOSWDRAOD>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x2B72600", Offset = "0x2B71600", VA = "0x182B72600")]
		public static Id32<NJHHKJCVQUE<RXCTQXXFICO>> RKCBVGHMJYB(this UnsafeList<byte> a, [Optional] int? b)
		{
			return default(Id32<NJHHKJCVQUE<RXCTQXXFICO>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x2B72230", Offset = "0x2B71230", VA = "0x182B72230")]
		public static Id32<NJHHKJCVQUE<BFTZGTVHZPK>> AYLYJOJNOOP(this UnsafeList<byte> a, [Optional] Id32<BFTZGTVHZPK>? b)
		{
			return default(Id32<NJHHKJCVQUE<BFTZGTVHZPK>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x2B72500", Offset = "0x2B71500", VA = "0x182B72500")]
		public static Id32<NJHHKJCVQUE<JNCTGJVABPH>> HOVFKTHNLLW(this UnsafeList<byte> a, [Optional] byte? b)
		{
			return default(Id32<NJHHKJCVQUE<JNCTGJVABPH>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x2B72320", Offset = "0x2B71320", VA = "0x182B72320")]
		public static Id32<NJHHKJCVQUE<MCZYZSSYBNX>> DEIZUTXDLQU(this UnsafeList<byte> a, [Optional] Id32<MCZYZSSYBNX>? b)
		{
			return default(Id32<NJHHKJCVQUE<MCZYZSSYBNX>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x2B726E0", Offset = "0x2B716E0", VA = "0x182B726E0")]
		public static Id32<NJHHKJCVQUE<VAWWUJGMVPZ>> SJDXBTGTJPI(this UnsafeList<byte> a, [Optional] Op? b)
		{
			return default(Id32<NJHHKJCVQUE<VAWWUJGMVPZ>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x39C5970", Offset = "0x39C4970", VA = "0x1839C5970")]
		public static Id32<NJHHKJCVQUE<XPYIVJGMLOO<c>>> JSDHFESCONA<c>(this UnsafeList<byte> a, [Optional] Id32<XPYIVJGMLOO<c>>? b)
		{
			return default(Id32<NJHHKJCVQUE<XPYIVJGMLOO<c>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x2B6C6A0", Offset = "0x2B6B6A0", VA = "0x182B6C6A0")]
		public static void ZBDEGZUEROG(this UnsafeList<byte> a, Id32<NJHHKJCVQUE<RXCTQXXFICO>> b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x39C5870", Offset = "0x39C4870", VA = "0x1839C5870")]
		public static void EVUGCOUQDJF<d>(this UnsafeList<byte> a, Id32<NJHHKJCVQUE<NJHHKJCVQUE<d>>> b, Id32<NJHHKJCVQUE<d>> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x39C5870", Offset = "0x39C4870", VA = "0x1839C5870")]
		public static void YQAQSSFHZKV<e>(this UnsafeList<byte> a, Id32<NJHHKJCVQUE<XPYIVJGMLOO<e>>> b, Id32<XPYIVJGMLOO<e>> c)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public static class FKNWDONTMXW
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x2B72120", Offset = "0x2B71120", VA = "0x182B72120")]
		public static Union32 MWXYLZYZKZE([In] this ReadOnlySpan<byte> bytes, int a)
		{
			return default(Union32);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x2B72190", Offset = "0x2B71190", VA = "0x182B72190")]
		public static Union32 MWXYLZYZKZE([In] this UnsafeList<byte> bytes, int a)
		{
			return default(Union32);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x3978090", Offset = "0x3977090", VA = "0x183978090")]
		public static Union32 MWXYLZYZKZE<f>(this ReadOnlyIdArray<f, byte> a, Id32<f> b)
		{
			return default(Union32);
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x3977EA0", Offset = "0x3976EA0", VA = "0x183977EA0")]
		public static Union32 MWXYLZYZKZE<g>([In] this ReadOnlyIdSpan<g, byte> bytes, Id32<g> a)
		{
			return default(Union32);
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x3977E40", Offset = "0x3976E40", VA = "0x183977E40")]
		public static Union32 MWXYLZYZKZE<i>(this IdArray<i, byte> a, Id32<i> b)
		{
			return default(Union32);
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x3978020", Offset = "0x3977020", VA = "0x183978020")]
		public static Union32 MWXYLZYZKZE<j>([In] this IdSpan<j, byte> bytes, Id32<j> a)
		{
			return default(Union32);
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x3978210", Offset = "0x3977210", VA = "0x183978210")]
		public static Union32 MWXYLZYZKZE<k>(this ReadOnlyIdArray<k, byte> a, Id32<k> b)
		{
			return default(Union32);
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x2B72120", Offset = "0x2B71120", VA = "0x182B72120")]
		public static int ICFROCVVCJP([In] this ReadOnlySpan<byte> bytes, int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x2B6C530", Offset = "0x2B6B530", VA = "0x182B6C530")]
		public static int ICFROCVVCJP([In] this UnsafeList<byte> bytes, int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x3977670", Offset = "0x3976670", VA = "0x183977670")]
		public static int ICFROCVVCJP<p>(this ReadOnlyIdArray<p, byte> a, Id32<p> b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x3977550", Offset = "0x3976550", VA = "0x183977550")]
		public static int ICFROCVVCJP<s>(this IdArray<s, byte> a, Id32<s> b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x39775D0", Offset = "0x39765D0", VA = "0x1839775D0")]
		public static int ICFROCVVCJP<t>([In] this IdSpan<t, byte> bytes, Id32<t> a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x3977620", Offset = "0x3976620", VA = "0x183977620")]
		public static int ICFROCVVCJP<u>(this ReadOnlyIdArray<u, byte> a, Id32<u> b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x3978760", Offset = "0x3977760", VA = "0x183978760")]
		public static float UHUMXFRYEKM<bc>(this IdArray<bc, byte> a, Id32<bc> b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x3978710", Offset = "0x3977710", VA = "0x183978710")]
		public static float UHUMXFRYEKM<bd>([In] this IdSpan<bd, byte> bytes, Id32<bd> a)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x39787E0", Offset = "0x39777E0", VA = "0x1839787E0")]
		public static float UHUMXFRYEKM<be>(this ReadOnlyIdArray<be, byte> a, Id32<be> b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x3977B00", Offset = "0x3976B00", VA = "0x183977B00")]
		public static byte MEZUQMUARUA<bj>(this ReadOnlyIdArray<bj, byte> a, Id32<bj> b)
		{
			return default(byte);
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x3977AB0", Offset = "0x3976AB0", VA = "0x183977AB0")]
		public static byte MEZUQMUARUA<bk>([In] this ReadOnlyIdSpan<bk, byte> bytes, Id32<bk> a)
		{
			return default(byte);
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x3977A30", Offset = "0x3976A30", VA = "0x183977A30")]
		public static byte MEZUQMUARUA<bm>(this IdArray<bm, byte> a, Id32<bm> b)
		{
			return default(byte);
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x39778D0", Offset = "0x39768D0", VA = "0x1839778D0")]
		public static byte MEZUQMUARUA<bn>([In] this IdSpan<bn, byte> bytes, Id32<bn> a)
		{
			return default(byte);
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x3977960", Offset = "0x3976960", VA = "0x183977960")]
		public static byte MEZUQMUARUA<bo>(this ReadOnlyIdArray<bo, byte> a, Id32<bo> b)
		{
			return default(byte);
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x2B6C530", Offset = "0x2B6B530", VA = "0x182B6C530")]
		public static Op WWCFZIMWUXY([In] this UnsafeList<byte> bytes, int a)
		{
			return default(Op);
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x3978940", Offset = "0x3977940", VA = "0x183978940")]
		public static Op WWCFZIMWUXY<by>(this ReadOnlyIdArray<by, byte> a, Id32<by> b)
		{
			return default(Op);
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x3978570", Offset = "0x3977570", VA = "0x183978570")]
		public static Id32<NJHHKJCVQUE<SKRYMZOWBYC>> TIQKAQHULRG<cg>(this IdArray<cg, byte> a, Id32<cg> b)
		{
			return default(Id32<NJHHKJCVQUE<SKRYMZOWBYC>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x3978450", Offset = "0x3977450", VA = "0x183978450")]
		public static Id32<NJHHKJCVQUE<SKRYMZOWBYC>> TIQKAQHULRG<ch>([In] this IdSpan<ch, byte> bytes, Id32<ch> a)
		{
			return default(Id32<NJHHKJCVQUE<SKRYMZOWBYC>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x39784E0", Offset = "0x39774E0", VA = "0x1839784E0")]
		public static Id32<NJHHKJCVQUE<SKRYMZOWBYC>> TIQKAQHULRG<ci>(this ReadOnlyIdArray<ci, byte> a, Id32<ci> b)
		{
			return default(Id32<NJHHKJCVQUE<SKRYMZOWBYC>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x39788B0", Offset = "0x39778B0", VA = "0x1839788B0")]
		public static Id32<XPYIVJGMLOO<SKRYMZOWBYC>> WFGYEZKCNLU<cs>(this ReadOnlyIdArray<cs, byte> a, Id32<cs> b)
		{
			return default(Id32<XPYIVJGMLOO<SKRYMZOWBYC>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x3978B20", Offset = "0x3977B20", VA = "0x183978B20")]
		public static Id32<MCZYZSSYBNX> ZMZRLMLWULU<da>(this IdArray<da, byte> a, Id32<da> b)
		{
			return default(Id32<MCZYZSSYBNX>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x3978BA0", Offset = "0x3977BA0", VA = "0x183978BA0")]
		public static Id32<MCZYZSSYBNX> ZMZRLMLWULU<db>([In] this IdSpan<db, byte> bytes, Id32<db> a)
		{
			return default(Id32<MCZYZSSYBNX>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x3978C30", Offset = "0x3977C30", VA = "0x183978C30")]
		public static Id32<MCZYZSSYBNX> ZMZRLMLWULU<dc>(this ReadOnlyIdArray<dc, byte> a, Id32<dc> b)
		{
			return default(Id32<MCZYZSSYBNX>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x3977230", Offset = "0x3976230", VA = "0x183977230")]
		public static Id32<DMXLEVIULSD> ASCQFOLIDTS<dl>([In] this IdSpan<dl, byte> bytes, Id32<dl> a)
		{
			return default(Id32<DMXLEVIULSD>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x39772C0", Offset = "0x39762C0", VA = "0x1839772C0")]
		public static Id32<DMXLEVIULSD> ASCQFOLIDTS<dm>(this ReadOnlyIdArray<dm, byte> a, Id32<dm> b)
		{
			return default(Id32<DMXLEVIULSD>);
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x39773D0", Offset = "0x39763D0", VA = "0x1839773D0")]
		public static Id32<BFTZGTVHZPK> GRMPMDABLEX<dw>(this ReadOnlyIdArray<dw, byte> a, Id32<dw> b)
		{
			return default(Id32<BFTZGTVHZPK>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public static class ZETQNWOZDLC
	{
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x2B72A30", Offset = "0x2B71A30", VA = "0x182B72A30")]
		public static void JKUEFZFHQSV(this UnsafeList<byte> a, int b, Union32 c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x2B729C0", Offset = "0x2B719C0", VA = "0x182B729C0")]
		public static void JKUEFZFHQSV(this byte[] a, int b, Union32 c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x2B72AF0", Offset = "0x2B71AF0", VA = "0x182B72AF0")]
		public static void JKUEFZFHQSV([In] this Span<byte> bytes, int a, Union32 b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x3F7DC10", Offset = "0x3F7CC10", VA = "0x183F7DC10")]
		public static void JKUEFZFHQSV<e>(this IdArray<e, byte> a, Id32<e> b, Union32 c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x3F7DD60", Offset = "0x3F7CD60", VA = "0x183F7DD60")]
		public static void JKUEFZFHQSV<f>([In] this IdSpan<f, byte> bytes, Id32<f> a, Union32 b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x2B6C6A0", Offset = "0x2B6B6A0", VA = "0x182B6C6A0")]
		public static void ZBDEGZUEROG(this UnsafeList<byte> a, int b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x2B72CA0", Offset = "0x2B71CA0", VA = "0x182B72CA0")]
		public static void ZBDEGZUEROG(this byte[] a, int b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x2B72C20", Offset = "0x2B71C20", VA = "0x182B72C20")]
		public static void ZBDEGZUEROG([In] this Span<byte> bytes, int a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x3F7E2A0", Offset = "0x3F7D2A0", VA = "0x183F7E2A0")]
		public static void ZBDEGZUEROG<h>(this IdArray<h, byte> a, Id32<h> b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x3F7E300", Offset = "0x3F7D300", VA = "0x183F7E300")]
		public static void ZBDEGZUEROG<i>([In] this IdSpan<i, byte> bytes, Id32<i> a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x2B72BE0", Offset = "0x2B71BE0", VA = "0x182B72BE0")]
		public static void WNICORDDUTF(this UnsafeList<byte> a, int b, float c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x3F7E0E0", Offset = "0x3F7D0E0", VA = "0x183F7E0E0")]
		public static void WNICORDDUTF<k>(this IdArray<k, byte> a, Id32<k> b, float c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x3F7E150", Offset = "0x3F7D150", VA = "0x183F7E150")]
		public static void WNICORDDUTF<l>([In] this IdSpan<l, byte> bytes, Id32<l> a, float b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x2B72B70", Offset = "0x2B71B70", VA = "0x182B72B70")]
		public static void SFHSDRCYIRT(this UnsafeList<byte> a, int b, byte c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x3F7DFB0", Offset = "0x3F7CFB0", VA = "0x183F7DFB0")]
		public static void SFHSDRCYIRT<n>(this IdArray<n, byte> a, Id32<n> b, byte c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x3F7DF60", Offset = "0x3F7CF60", VA = "0x183F7DF60")]
		public static void SFHSDRCYIRT<o>([In] this IdSpan<o, byte> bytes, Id32<o> a, byte b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x3F7D990", Offset = "0x3F7C990", VA = "0x183F7D990")]
		public static void EVUGCOUQDJF<q>(this IdArray<q, byte> a, Id32<q> b, Id32<NJHHKJCVQUE<SKRYMZOWBYC>> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x3F7D910", Offset = "0x3F7C910", VA = "0x183F7D910")]
		public static void EVUGCOUQDJF<r>([In] this IdSpan<r, byte> bytes, Id32<r> a, Id32<NJHHKJCVQUE<SKRYMZOWBYC>> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x3F7D990", Offset = "0x3F7C990", VA = "0x183F7D990")]
		public static void GTQMTDJFVEV<t>(this IdArray<t, byte> a, Id32<t> b, Id32<MCZYZSSYBNX> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x3F7D910", Offset = "0x3F7C910", VA = "0x183F7D910")]
		public static void GTQMTDJFVEV<u>([In] this IdSpan<u, byte> bytes, Id32<u> a, Id32<MCZYZSSYBNX> b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public static class ANUETQUTWZH
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x2B6F7D0", Offset = "0x2B6E7D0", VA = "0x182B6F7D0")]
		public static (Id32<NJHHKJCVQUE<VAWWUJGMVPZ>>, Id32<NJHHKJCVQUE<GMCOSWDRAOD>>, Id32<NJHHKJCVQUE<GMCOSWDRAOD>>, Id32<NJHHKJCVQUE<XPYIVJGMLOO<GMCOSWDRAOD>>>) OIVORMJTITX(this UnsafeList<byte> a, float b, float c, [Optional] Id32<XPYIVJGMLOO<GMCOSWDRAOD>>? d)
		{
			return default((Id32<NJHHKJCVQUE<VAWWUJGMVPZ>>, Id32<NJHHKJCVQUE<GMCOSWDRAOD>>, Id32<NJHHKJCVQUE<GMCOSWDRAOD>>, Id32<NJHHKJCVQUE<XPYIVJGMLOO<GMCOSWDRAOD>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x2B71630", Offset = "0x2B70630", VA = "0x182B71630")]
		public static (Id32<NJHHKJCVQUE<VAWWUJGMVPZ>>, Id32<NJHHKJCVQUE<GMCOSWDRAOD>>, Id32<NJHHKJCVQUE<XPYIVJGMLOO<GMCOSWDRAOD>>>, Id32<NJHHKJCVQUE<XPYIVJGMLOO<GMCOSWDRAOD>>>) UVIQKUOLNHA(this UnsafeList<byte> a, float b, [Optional] Id32<XPYIVJGMLOO<GMCOSWDRAOD>>? c, [Optional] Id32<XPYIVJGMLOO<GMCOSWDRAOD>>? d)
		{
			return default((Id32<NJHHKJCVQUE<VAWWUJGMVPZ>>, Id32<NJHHKJCVQUE<GMCOSWDRAOD>>, Id32<NJHHKJCVQUE<XPYIVJGMLOO<GMCOSWDRAOD>>>, Id32<NJHHKJCVQUE<XPYIVJGMLOO<GMCOSWDRAOD>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x2B6F530", Offset = "0x2B6E530", VA = "0x182B6F530")]
		public static (Id32<NJHHKJCVQUE<VAWWUJGMVPZ>>, Id32<NJHHKJCVQUE<XPYIVJGMLOO<GMCOSWDRAOD>>>, Id32<NJHHKJCVQUE<XPYIVJGMLOO<GMCOSWDRAOD>>>, Id32<NJHHKJCVQUE<XPYIVJGMLOO<GMCOSWDRAOD>>>) NQCRWVWZCZB(this UnsafeList<byte> a, [Optional] Id32<XPYIVJGMLOO<GMCOSWDRAOD>>? b, [Optional] Id32<XPYIVJGMLOO<GMCOSWDRAOD>>? c, [Optional] Id32<XPYIVJGMLOO<GMCOSWDRAOD>>? d)
		{
			return default((Id32<NJHHKJCVQUE<VAWWUJGMVPZ>>, Id32<NJHHKJCVQUE<XPYIVJGMLOO<GMCOSWDRAOD>>>, Id32<NJHHKJCVQUE<XPYIVJGMLOO<GMCOSWDRAOD>>>, Id32<NJHHKJCVQUE<XPYIVJGMLOO<GMCOSWDRAOD>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x2B6DD70", Offset = "0x2B6CD70", VA = "0x182B6DD70")]
		public static (Id32<NJHHKJCVQUE<VAWWUJGMVPZ>>, Id32<NJHHKJCVQUE<RXCTQXXFICO>>, Id32<NJHHKJCVQUE<RXCTQXXFICO>>, Id32<NJHHKJCVQUE<XPYIVJGMLOO<RXCTQXXFICO>>>) GHSIJZUZXJN(this UnsafeList<byte> a, int b, int c, [Optional] Id32<XPYIVJGMLOO<RXCTQXXFICO>>? d)
		{
			return default((Id32<NJHHKJCVQUE<VAWWUJGMVPZ>>, Id32<NJHHKJCVQUE<RXCTQXXFICO>>, Id32<NJHHKJCVQUE<RXCTQXXFICO>>, Id32<NJHHKJCVQUE<XPYIVJGMLOO<RXCTQXXFICO>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x2B6E4F0", Offset = "0x2B6D4F0", VA = "0x182B6E4F0")]
		public static (Id32<NJHHKJCVQUE<VAWWUJGMVPZ>>, Id32<NJHHKJCVQUE<RXCTQXXFICO>>, Id32<NJHHKJCVQUE<XPYIVJGMLOO<RXCTQXXFICO>>>, Id32<NJHHKJCVQUE<XPYIVJGMLOO<RXCTQXXFICO>>>) IXZDVBBEHZG(this UnsafeList<byte> a, int b, [Optional] Id32<XPYIVJGMLOO<RXCTQXXFICO>>? c, [Optional] Id32<XPYIVJGMLOO<RXCTQXXFICO>>? d)
		{
			return default((Id32<NJHHKJCVQUE<VAWWUJGMVPZ>>, Id32<NJHHKJCVQUE<RXCTQXXFICO>>, Id32<NJHHKJCVQUE<XPYIVJGMLOO<RXCTQXXFICO>>>, Id32<NJHHKJCVQUE<XPYIVJGMLOO<RXCTQXXFICO>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x2B70220", Offset = "0x2B6F220", VA = "0x182B70220")]
		public static (Id32<NJHHKJCVQUE<VAWWUJGMVPZ>>, Id32<NJHHKJCVQUE<XPYIVJGMLOO<RXCTQXXFICO>>>, Id32<NJHHKJCVQUE<XPYIVJGMLOO<RXCTQXXFICO>>>, Id32<NJHHKJCVQUE<XPYIVJGMLOO<RXCTQXXFICO>>>) PVSLLXLYUCB(this UnsafeList<byte> a, [Optional] Id32<XPYIVJGMLOO<RXCTQXXFICO>>? b, [Optional] Id32<XPYIVJGMLOO<RXCTQXXFICO>>? c, [Optional] Id32<XPYIVJGMLOO<RXCTQXXFICO>>? d)
		{
			return default((Id32<NJHHKJCVQUE<VAWWUJGMVPZ>>, Id32<NJHHKJCVQUE<XPYIVJGMLOO<RXCTQXXFICO>>>, Id32<NJHHKJCVQUE<XPYIVJGMLOO<RXCTQXXFICO>>>, Id32<NJHHKJCVQUE<XPYIVJGMLOO<RXCTQXXFICO>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x2B6F200", Offset = "0x2B6E200", VA = "0x182B6F200")]
		public static (Id32<NJHHKJCVQUE<VAWWUJGMVPZ>>, Id32<NJHHKJCVQUE<RXCTQXXFICO>>, Id32<NJHHKJCVQUE<RXCTQXXFICO>>, Id32<NJHHKJCVQUE<XPYIVJGMLOO<RXCTQXXFICO>>>) MQBRBVRSXTD(this UnsafeList<byte> a, int b, int c, [Optional] Id32<XPYIVJGMLOO<RXCTQXXFICO>>? d)
		{
			return default((Id32<NJHHKJCVQUE<VAWWUJGMVPZ>>, Id32<NJHHKJCVQUE<RXCTQXXFICO>>, Id32<NJHHKJCVQUE<RXCTQXXFICO>>, Id32<NJHHKJCVQUE<XPYIVJGMLOO<RXCTQXXFICO>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x2B6CC90", Offset = "0x2B6BC90", VA = "0x182B6CC90")]
		public static (Id32<NJHHKJCVQUE<VAWWUJGMVPZ>>, Id32<NJHHKJCVQUE<RXCTQXXFICO>>, Id32<NJHHKJCVQUE<XPYIVJGMLOO<RXCTQXXFICO>>>, Id32<NJHHKJCVQUE<XPYIVJGMLOO<RXCTQXXFICO>>>) AZMZMKPPSIS(this UnsafeList<byte> a, int b, [Optional] Id32<XPYIVJGMLOO<RXCTQXXFICO>>? c, [Optional] Id32<XPYIVJGMLOO<RXCTQXXFICO>>? d)
		{
			return default((Id32<NJHHKJCVQUE<VAWWUJGMVPZ>>, Id32<NJHHKJCVQUE<RXCTQXXFICO>>, Id32<NJHHKJCVQUE<XPYIVJGMLOO<RXCTQXXFICO>>>, Id32<NJHHKJCVQUE<XPYIVJGMLOO<RXCTQXXFICO>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x2B70F30", Offset = "0x2B6FF30", VA = "0x182B70F30")]
		public static (Id32<NJHHKJCVQUE<VAWWUJGMVPZ>>, Id32<NJHHKJCVQUE<XPYIVJGMLOO<RXCTQXXFICO>>>, Id32<NJHHKJCVQUE<XPYIVJGMLOO<RXCTQXXFICO>>>, Id32<NJHHKJCVQUE<XPYIVJGMLOO<RXCTQXXFICO>>>) SEMTDASTEQX(this UnsafeList<byte> a, [Optional] Id32<XPYIVJGMLOO<RXCTQXXFICO>>? b, [Optional] Id32<XPYIVJGMLOO<RXCTQXXFICO>>? c, [Optional] Id32<XPYIVJGMLOO<RXCTQXXFICO>>? d)
		{
			return default((Id32<NJHHKJCVQUE<VAWWUJGMVPZ>>, Id32<NJHHKJCVQUE<XPYIVJGMLOO<RXCTQXXFICO>>>, Id32<NJHHKJCVQUE<XPYIVJGMLOO<RXCTQXXFICO>>>, Id32<NJHHKJCVQUE<XPYIVJGMLOO<RXCTQXXFICO>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x2B6E1A0", Offset = "0x2B6D1A0", VA = "0x182B6E1A0")]
		public static (Id32<NJHHKJCVQUE<VAWWUJGMVPZ>>, Id32<NJHHKJCVQUE<RXCTQXXFICO>>, Id32<NJHHKJCVQUE<NJHHKJCVQUE<VAWWUJGMVPZ>>>) IGUTXEWJLWB(this UnsafeList<byte> a, [Optional] int? b, [Optional] Id32<NJHHKJCVQUE<VAWWUJGMVPZ>>? c)
		{
			return default((Id32<NJHHKJCVQUE<VAWWUJGMVPZ>>, Id32<NJHHKJCVQUE<RXCTQXXFICO>>, Id32<NJHHKJCVQUE<NJHHKJCVQUE<VAWWUJGMVPZ>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x2B70100", Offset = "0x2B6F100", VA = "0x182B70100")]
		public static (Id32<NJHHKJCVQUE<VAWWUJGMVPZ>>, Id32<NJHHKJCVQUE<XPYIVJGMLOO<RXCTQXXFICO>>>, Id32<NJHHKJCVQUE<NJHHKJCVQUE<VAWWUJGMVPZ>>>) PJTMWYINVMG(this UnsafeList<byte> a, [Optional] Id32<XPYIVJGMLOO<RXCTQXXFICO>>? b, [Optional] Id32<NJHHKJCVQUE<VAWWUJGMVPZ>>? c)
		{
			return default((Id32<NJHHKJCVQUE<VAWWUJGMVPZ>>, Id32<NJHHKJCVQUE<XPYIVJGMLOO<RXCTQXXFICO>>>, Id32<NJHHKJCVQUE<NJHHKJCVQUE<VAWWUJGMVPZ>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x2B71F00", Offset = "0x2B70F00", VA = "0x182B71F00")]
		public static (Id32<NJHHKJCVQUE<VAWWUJGMVPZ>>, Id32<NJHHKJCVQUE<RXCTQXXFICO>>, Id32<NJHHKJCVQUE<NJHHKJCVQUE<VAWWUJGMVPZ>>>) ZGJOAHGWHXQ(this UnsafeList<byte> a, [Optional] int? b, [Optional] Id32<NJHHKJCVQUE<VAWWUJGMVPZ>>? c)
		{
			return default((Id32<NJHHKJCVQUE<VAWWUJGMVPZ>>, Id32<NJHHKJCVQUE<RXCTQXXFICO>>, Id32<NJHHKJCVQUE<NJHHKJCVQUE<VAWWUJGMVPZ>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x2B71B70", Offset = "0x2B70B70", VA = "0x182B71B70")]
		public static (Id32<NJHHKJCVQUE<VAWWUJGMVPZ>>, Id32<NJHHKJCVQUE<XPYIVJGMLOO<RXCTQXXFICO>>>, Id32<NJHHKJCVQUE<NJHHKJCVQUE<VAWWUJGMVPZ>>>) WIBJGPHIGFP(this UnsafeList<byte> a, [Optional] Id32<XPYIVJGMLOO<RXCTQXXFICO>>? b, [Optional] Id32<NJHHKJCVQUE<VAWWUJGMVPZ>>? c)
		{
			return default((Id32<NJHHKJCVQUE<VAWWUJGMVPZ>>, Id32<NJHHKJCVQUE<XPYIVJGMLOO<RXCTQXXFICO>>>, Id32<NJHHKJCVQUE<NJHHKJCVQUE<VAWWUJGMVPZ>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x2B704A0", Offset = "0x2B6F4A0", VA = "0x182B704A0")]
		public static (Id32<NJHHKJCVQUE<VAWWUJGMVPZ>>, Id32<NJHHKJCVQUE<RXCTQXXFICO>>, Id32<NJHHKJCVQUE<DMXLEVIULSD>>) QEBWWZKJCMW(this UnsafeList<byte> a, [Optional] int? b, [Optional] Id32<DMXLEVIULSD>? c)
		{
			return default((Id32<NJHHKJCVQUE<VAWWUJGMVPZ>>, Id32<NJHHKJCVQUE<RXCTQXXFICO>>, Id32<NJHHKJCVQUE<DMXLEVIULSD>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x2B707A0", Offset = "0x2B6F7A0", VA = "0x182B707A0")]
		public static (Id32<NJHHKJCVQUE<VAWWUJGMVPZ>>, Id32<NJHHKJCVQUE<RXCTQXXFICO>>, Id32<NJHHKJCVQUE<XPYIVJGMLOO<DMXLEVIULSD>>>) QFMTDUTQQOH(this UnsafeList<byte> a, [Optional] int? b, [Optional] Id32<XPYIVJGMLOO<DMXLEVIULSD>>? c)
		{
			return default((Id32<NJHHKJCVQUE<VAWWUJGMVPZ>>, Id32<NJHHKJCVQUE<RXCTQXXFICO>>, Id32<NJHHKJCVQUE<XPYIVJGMLOO<DMXLEVIULSD>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x2B6E640", Offset = "0x2B6D640", VA = "0x182B6E640")]
		public static (Id32<NJHHKJCVQUE<VAWWUJGMVPZ>>, Id32<NJHHKJCVQUE<RXCTQXXFICO>>, Id32<NJHHKJCVQUE<MCZYZSSYBNX>>) JGODAKLKEEM(this UnsafeList<byte> a, [Optional] int? b, [Optional] Id32<MCZYZSSYBNX>? c)
		{
			return default((Id32<NJHHKJCVQUE<VAWWUJGMVPZ>>, Id32<NJHHKJCVQUE<RXCTQXXFICO>>, Id32<NJHHKJCVQUE<MCZYZSSYBNX>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x2B6E970", Offset = "0x2B6D970", VA = "0x182B6E970")]
		public static (Id32<NJHHKJCVQUE<VAWWUJGMVPZ>>, Id32<NJHHKJCVQUE<RXCTQXXFICO>>, Id32<NJHHKJCVQUE<XPYIVJGMLOO<MCZYZSSYBNX>>>) JIUAWGWHDZH(this UnsafeList<byte> a, [Optional] int? b, [Optional] Id32<XPYIVJGMLOO<MCZYZSSYBNX>>? c)
		{
			return default((Id32<NJHHKJCVQUE<VAWWUJGMVPZ>>, Id32<NJHHKJCVQUE<RXCTQXXFICO>>, Id32<NJHHKJCVQUE<XPYIVJGMLOO<MCZYZSSYBNX>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x3320FB0", Offset = "0x331FFB0", VA = "0x183320FB0")]
		public static (Id32<NJHHKJCVQUE<VAWWUJGMVPZ>>, Id32<NJHHKJCVQUE<BFTZGTVHZPK>>, Id32<NJHHKJCVQUE<RXCTQXXFICO>>, Id32<NJHHKJCVQUE<a>>) YPKCONDJNGX<a>(this UnsafeList<byte> a, [Optional] Id32<BFTZGTVHZPK>? b, [Optional][In] ReadOnlySpan<byte> data)
		{
			return default((Id32<NJHHKJCVQUE<VAWWUJGMVPZ>>, Id32<NJHHKJCVQUE<BFTZGTVHZPK>>, Id32<NJHHKJCVQUE<RXCTQXXFICO>>, Id32<NJHHKJCVQUE<a>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x2B6EF80", Offset = "0x2B6DF80", VA = "0x182B6EF80")]
		public static (Id32<NJHHKJCVQUE<VAWWUJGMVPZ>>, Id32<NJHHKJCVQUE<RXCTQXXFICO>>, Id32<NJHHKJCVQUE<XPYIVJGMLOO<RXCTQXXFICO>>>) LRYYIWJQCTB(this UnsafeList<byte> a, int b, [Optional] Id32<XPYIVJGMLOO<RXCTQXXFICO>>? c)
		{
			return default((Id32<NJHHKJCVQUE<VAWWUJGMVPZ>>, Id32<NJHHKJCVQUE<RXCTQXXFICO>>, Id32<NJHHKJCVQUE<XPYIVJGMLOO<RXCTQXXFICO>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x2B72010", Offset = "0x2B71010", VA = "0x182B72010")]
		public static (Id32<NJHHKJCVQUE<VAWWUJGMVPZ>>, Id32<NJHHKJCVQUE<XPYIVJGMLOO<RXCTQXXFICO>>>, Id32<NJHHKJCVQUE<XPYIVJGMLOO<RXCTQXXFICO>>>) ZXQKMDBJUDS(this UnsafeList<byte> a, [Optional] Id32<XPYIVJGMLOO<RXCTQXXFICO>>? b, [Optional] Id32<XPYIVJGMLOO<RXCTQXXFICO>>? c)
		{
			return default((Id32<NJHHKJCVQUE<VAWWUJGMVPZ>>, Id32<NJHHKJCVQUE<XPYIVJGMLOO<RXCTQXXFICO>>>, Id32<NJHHKJCVQUE<XPYIVJGMLOO<RXCTQXXFICO>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x3320930", Offset = "0x331F930", VA = "0x183320930")]
		public static (Id32<NJHHKJCVQUE<VAWWUJGMVPZ>>, Id32<NJHHKJCVQUE<XPYIVJGMLOO<b>>>, Id32<NJHHKJCVQUE<RXCTQXXFICO>>, Id32<NJHHKJCVQUE<b>>) BXFEFGRWOVT<b>(this UnsafeList<byte> a, [Optional] Id32<XPYIVJGMLOO<b>>? b, [Optional] int? c, [Optional][In] ReadOnlySpan<byte> from)
		{
			return default((Id32<NJHHKJCVQUE<VAWWUJGMVPZ>>, Id32<NJHHKJCVQUE<XPYIVJGMLOO<b>>>, Id32<NJHHKJCVQUE<RXCTQXXFICO>>, Id32<NJHHKJCVQUE<b>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x3320C60", Offset = "0x331FC60", VA = "0x183320C60")]
		public static (Id32<NJHHKJCVQUE<VAWWUJGMVPZ>>, Id32<NJHHKJCVQUE<XPYIVJGMLOO<c>>>, Id32<NJHHKJCVQUE<XPYIVJGMLOO<c>>>, Id32<NJHHKJCVQUE<RXCTQXXFICO>>) HDXSBAZFNBI<c>(this UnsafeList<byte> a, [Optional] Id32<XPYIVJGMLOO<c>>? b, [Optional] Id32<XPYIVJGMLOO<c>>? c, [Optional] int? d)
		{
			return default((Id32<NJHHKJCVQUE<VAWWUJGMVPZ>>, Id32<NJHHKJCVQUE<XPYIVJGMLOO<c>>>, Id32<NJHHKJCVQUE<XPYIVJGMLOO<c>>>, Id32<NJHHKJCVQUE<RXCTQXXFICO>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x2B6FC20", Offset = "0x2B6EC20", VA = "0x182B6FC20")]
		public static (Id32<NJHHKJCVQUE<VAWWUJGMVPZ>>, Id32<NJHHKJCVQUE<GMCOSWDRAOD>>, Id32<NJHHKJCVQUE<GMCOSWDRAOD>>, Id32<NJHHKJCVQUE<XPYIVJGMLOO<GMCOSWDRAOD>>>) ORBAGPVYUQB(this UnsafeList<byte> a, float b, float c, [Optional] Id32<XPYIVJGMLOO<GMCOSWDRAOD>>? d)
		{
			return default((Id32<NJHHKJCVQUE<VAWWUJGMVPZ>>, Id32<NJHHKJCVQUE<GMCOSWDRAOD>>, Id32<NJHHKJCVQUE<GMCOSWDRAOD>>, Id32<NJHHKJCVQUE<XPYIVJGMLOO<GMCOSWDRAOD>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x2B6F0B0", Offset = "0x2B6E0B0", VA = "0x182B6F0B0")]
		public static (Id32<NJHHKJCVQUE<VAWWUJGMVPZ>>, Id32<NJHHKJCVQUE<GMCOSWDRAOD>>, Id32<NJHHKJCVQUE<XPYIVJGMLOO<GMCOSWDRAOD>>>, Id32<NJHHKJCVQUE<XPYIVJGMLOO<GMCOSWDRAOD>>>) MIZQXTZRKPA(this UnsafeList<byte> a, float b, [Optional] Id32<XPYIVJGMLOO<GMCOSWDRAOD>>? c, [Optional] Id32<XPYIVJGMLOO<GMCOSWDRAOD>>? d)
		{
			return default((Id32<NJHHKJCVQUE<VAWWUJGMVPZ>>, Id32<NJHHKJCVQUE<GMCOSWDRAOD>>, Id32<NJHHKJCVQUE<XPYIVJGMLOO<GMCOSWDRAOD>>>, Id32<NJHHKJCVQUE<XPYIVJGMLOO<GMCOSWDRAOD>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x2B6D300", Offset = "0x2B6C300", VA = "0x182B6D300")]
		public static (Id32<NJHHKJCVQUE<VAWWUJGMVPZ>>, Id32<NJHHKJCVQUE<XPYIVJGMLOO<GMCOSWDRAOD>>>, Id32<NJHHKJCVQUE<XPYIVJGMLOO<GMCOSWDRAOD>>>, Id32<NJHHKJCVQUE<XPYIVJGMLOO<GMCOSWDRAOD>>>) CWIXKRNTWGT(this UnsafeList<byte> a, [Optional] Id32<XPYIVJGMLOO<GMCOSWDRAOD>>? b, [Optional] Id32<XPYIVJGMLOO<GMCOSWDRAOD>>? c, [Optional] Id32<XPYIVJGMLOO<GMCOSWDRAOD>>? d)
		{
			return default((Id32<NJHHKJCVQUE<VAWWUJGMVPZ>>, Id32<NJHHKJCVQUE<XPYIVJGMLOO<GMCOSWDRAOD>>>, Id32<NJHHKJCVQUE<XPYIVJGMLOO<GMCOSWDRAOD>>>, Id32<NJHHKJCVQUE<XPYIVJGMLOO<GMCOSWDRAOD>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x2B6C8A0", Offset = "0x2B6B8A0", VA = "0x182B6C8A0")]
		public static (Id32<NJHHKJCVQUE<VAWWUJGMVPZ>>, Id32<NJHHKJCVQUE<RXCTQXXFICO>>, Id32<NJHHKJCVQUE<RXCTQXXFICO>>, Id32<NJHHKJCVQUE<XPYIVJGMLOO<RXCTQXXFICO>>>) AGKPEOBXEQX(this UnsafeList<byte> a, int b, int c, [Optional] Id32<XPYIVJGMLOO<RXCTQXXFICO>>? d)
		{
			return default((Id32<NJHHKJCVQUE<VAWWUJGMVPZ>>, Id32<NJHHKJCVQUE<RXCTQXXFICO>>, Id32<NJHHKJCVQUE<RXCTQXXFICO>>, Id32<NJHHKJCVQUE<XPYIVJGMLOO<RXCTQXXFICO>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x2B6CF40", Offset = "0x2B6BF40", VA = "0x182B6CF40")]
		public static (Id32<NJHHKJCVQUE<VAWWUJGMVPZ>>, Id32<NJHHKJCVQUE<RXCTQXXFICO>>, Id32<NJHHKJCVQUE<XPYIVJGMLOO<RXCTQXXFICO>>>, Id32<NJHHKJCVQUE<XPYIVJGMLOO<RXCTQXXFICO>>>) BWMYBTCXNEM(this UnsafeList<byte> a, int b, [Optional] Id32<XPYIVJGMLOO<RXCTQXXFICO>>? c, [Optional] Id32<XPYIVJGMLOO<RXCTQXXFICO>>? d)
		{
			return default((Id32<NJHHKJCVQUE<VAWWUJGMVPZ>>, Id32<NJHHKJCVQUE<RXCTQXXFICO>>, Id32<NJHHKJCVQUE<XPYIVJGMLOO<RXCTQXXFICO>>>, Id32<NJHHKJCVQUE<XPYIVJGMLOO<RXCTQXXFICO>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x2B70B60", Offset = "0x2B6FB60", VA = "0x182B70B60")]
		public static (Id32<NJHHKJCVQUE<VAWWUJGMVPZ>>, Id32<NJHHKJCVQUE<XPYIVJGMLOO<RXCTQXXFICO>>>, Id32<NJHHKJCVQUE<XPYIVJGMLOO<RXCTQXXFICO>>>, Id32<NJHHKJCVQUE<XPYIVJGMLOO<RXCTQXXFICO>>>) QLBEODAPHLX(this UnsafeList<byte> a, [Optional] Id32<XPYIVJGMLOO<RXCTQXXFICO>>? b, [Optional] Id32<XPYIVJGMLOO<RXCTQXXFICO>>? c, [Optional] Id32<XPYIVJGMLOO<RXCTQXXFICO>>? d)
		{
			return default((Id32<NJHHKJCVQUE<VAWWUJGMVPZ>>, Id32<NJHHKJCVQUE<XPYIVJGMLOO<RXCTQXXFICO>>>, Id32<NJHHKJCVQUE<XPYIVJGMLOO<RXCTQXXFICO>>>, Id32<NJHHKJCVQUE<XPYIVJGMLOO<RXCTQXXFICO>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x2B71170", Offset = "0x2B70170", VA = "0x182B71170")]
		public static (Id32<NJHHKJCVQUE<VAWWUJGMVPZ>>, Id32<NJHHKJCVQUE<RXCTQXXFICO>>, Id32<NJHHKJCVQUE<RXCTQXXFICO>>, Id32<NJHHKJCVQUE<XPYIVJGMLOO<RXCTQXXFICO>>>) SZTKWZDCEUM(this UnsafeList<byte> a, int b, int c, [Optional] Id32<XPYIVJGMLOO<RXCTQXXFICO>>? d)
		{
			return default((Id32<NJHHKJCVQUE<VAWWUJGMVPZ>>, Id32<NJHHKJCVQUE<RXCTQXXFICO>>, Id32<NJHHKJCVQUE<RXCTQXXFICO>>, Id32<NJHHKJCVQUE<XPYIVJGMLOO<RXCTQXXFICO>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x2B6ECD0", Offset = "0x2B6DCD0", VA = "0x182B6ECD0")]
		public static (Id32<NJHHKJCVQUE<VAWWUJGMVPZ>>, Id32<NJHHKJCVQUE<RXCTQXXFICO>>, Id32<NJHHKJCVQUE<XPYIVJGMLOO<RXCTQXXFICO>>>, Id32<NJHHKJCVQUE<XPYIVJGMLOO<RXCTQXXFICO>>>) LDRNAJTRZSD(this UnsafeList<byte> a, int b, [Optional] Id32<XPYIVJGMLOO<RXCTQXXFICO>>? c, [Optional] Id32<XPYIVJGMLOO<RXCTQXXFICO>>? d)
		{
			return default((Id32<NJHHKJCVQUE<VAWWUJGMVPZ>>, Id32<NJHHKJCVQUE<RXCTQXXFICO>>, Id32<NJHHKJCVQUE<XPYIVJGMLOO<RXCTQXXFICO>>>, Id32<NJHHKJCVQUE<XPYIVJGMLOO<RXCTQXXFICO>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x2B6FEC0", Offset = "0x2B6EEC0", VA = "0x182B6FEC0")]
		public static (Id32<NJHHKJCVQUE<VAWWUJGMVPZ>>, Id32<NJHHKJCVQUE<XPYIVJGMLOO<RXCTQXXFICO>>>, Id32<NJHHKJCVQUE<XPYIVJGMLOO<RXCTQXXFICO>>>, Id32<NJHHKJCVQUE<XPYIVJGMLOO<RXCTQXXFICO>>>) OYUYYUQTSUO(this UnsafeList<byte> a, [Optional] Id32<XPYIVJGMLOO<RXCTQXXFICO>>? b, [Optional] Id32<XPYIVJGMLOO<RXCTQXXFICO>>? c, [Optional] Id32<XPYIVJGMLOO<RXCTQXXFICO>>? d)
		{
			return default((Id32<NJHHKJCVQUE<VAWWUJGMVPZ>>, Id32<NJHHKJCVQUE<XPYIVJGMLOO<RXCTQXXFICO>>>, Id32<NJHHKJCVQUE<XPYIVJGMLOO<RXCTQXXFICO>>>, Id32<NJHHKJCVQUE<XPYIVJGMLOO<RXCTQXXFICO>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x2B71420", Offset = "0x2B70420", VA = "0x182B71420")]
		public static (Id32<NJHHKJCVQUE<VAWWUJGMVPZ>>, Id32<NJHHKJCVQUE<NJHHKJCVQUE<VAWWUJGMVPZ>>>) UHJNQRIVUZB(this UnsafeList<byte> a, [Optional] Id32<NJHHKJCVQUE<VAWWUJGMVPZ>>? b)
		{
			return default((Id32<NJHHKJCVQUE<VAWWUJGMVPZ>>, Id32<NJHHKJCVQUE<NJHHKJCVQUE<VAWWUJGMVPZ>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x2B6DBF0", Offset = "0x2B6CBF0", VA = "0x182B6DBF0")]
		public static (Id32<NJHHKJCVQUE<VAWWUJGMVPZ>>, Id32<NJHHKJCVQUE<GMCOSWDRAOD>>, Id32<NJHHKJCVQUE<GMCOSWDRAOD>>, Id32<NJHHKJCVQUE<XPYIVJGMLOO<RXCTQXXFICO>>>) ESCIJEZYVED(this UnsafeList<byte> a, float b, float c, [Optional] Id32<XPYIVJGMLOO<RXCTQXXFICO>>? d)
		{
			return default((Id32<NJHHKJCVQUE<VAWWUJGMVPZ>>, Id32<NJHHKJCVQUE<GMCOSWDRAOD>>, Id32<NJHHKJCVQUE<GMCOSWDRAOD>>, Id32<NJHHKJCVQUE<XPYIVJGMLOO<RXCTQXXFICO>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x2B70340", Offset = "0x2B6F340", VA = "0x182B70340")]
		public static (Id32<NJHHKJCVQUE<VAWWUJGMVPZ>>, Id32<NJHHKJCVQUE<GMCOSWDRAOD>>, Id32<NJHHKJCVQUE<XPYIVJGMLOO<GMCOSWDRAOD>>>, Id32<NJHHKJCVQUE<XPYIVJGMLOO<RXCTQXXFICO>>>) QDZDWBERXZS(this UnsafeList<byte> a, float b, [Optional] Id32<XPYIVJGMLOO<GMCOSWDRAOD>>? c, [Optional] Id32<XPYIVJGMLOO<RXCTQXXFICO>>? d)
		{
			return default((Id32<NJHHKJCVQUE<VAWWUJGMVPZ>>, Id32<NJHHKJCVQUE<GMCOSWDRAOD>>, Id32<NJHHKJCVQUE<XPYIVJGMLOO<GMCOSWDRAOD>>>, Id32<NJHHKJCVQUE<XPYIVJGMLOO<RXCTQXXFICO>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x2B6D420", Offset = "0x2B6C420", VA = "0x182B6D420")]
		public static (Id32<NJHHKJCVQUE<VAWWUJGMVPZ>>, Id32<NJHHKJCVQUE<XPYIVJGMLOO<GMCOSWDRAOD>>>, Id32<NJHHKJCVQUE<XPYIVJGMLOO<GMCOSWDRAOD>>>, Id32<NJHHKJCVQUE<XPYIVJGMLOO<RXCTQXXFICO>>>) DJTYDBAHZEF(this UnsafeList<byte> a, [Optional] Id32<XPYIVJGMLOO<GMCOSWDRAOD>>? b, [Optional] Id32<XPYIVJGMLOO<GMCOSWDRAOD>>? c, [Optional] Id32<XPYIVJGMLOO<RXCTQXXFICO>>? d)
		{
			return default((Id32<NJHHKJCVQUE<VAWWUJGMVPZ>>, Id32<NJHHKJCVQUE<XPYIVJGMLOO<GMCOSWDRAOD>>>, Id32<NJHHKJCVQUE<XPYIVJGMLOO<GMCOSWDRAOD>>>, Id32<NJHHKJCVQUE<XPYIVJGMLOO<RXCTQXXFICO>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x2B6CA00", Offset = "0x2B6BA00", VA = "0x182B6CA00")]
		public static (Id32<NJHHKJCVQUE<VAWWUJGMVPZ>>, Id32<NJHHKJCVQUE<RXCTQXXFICO>>, Id32<NJHHKJCVQUE<RXCTQXXFICO>>, Id32<NJHHKJCVQUE<XPYIVJGMLOO<RXCTQXXFICO>>>) ALTODZFIDLU(this UnsafeList<byte> a, int b, int c, [Optional] Id32<XPYIVJGMLOO<RXCTQXXFICO>>? d)
		{
			return default((Id32<NJHHKJCVQUE<VAWWUJGMVPZ>>, Id32<NJHHKJCVQUE<RXCTQXXFICO>>, Id32<NJHHKJCVQUE<RXCTQXXFICO>>, Id32<NJHHKJCVQUE<XPYIVJGMLOO<RXCTQXXFICO>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x2B708B0", Offset = "0x2B6F8B0", VA = "0x182B708B0")]
		public static (Id32<NJHHKJCVQUE<VAWWUJGMVPZ>>, Id32<NJHHKJCVQUE<RXCTQXXFICO>>, Id32<NJHHKJCVQUE<XPYIVJGMLOO<RXCTQXXFICO>>>, Id32<NJHHKJCVQUE<XPYIVJGMLOO<RXCTQXXFICO>>>) QHRMGAMSZGJ(this UnsafeList<byte> a, int b, [Optional] Id32<XPYIVJGMLOO<RXCTQXXFICO>>? c, [Optional] Id32<XPYIVJGMLOO<RXCTQXXFICO>>? d)
		{
			return default((Id32<NJHHKJCVQUE<VAWWUJGMVPZ>>, Id32<NJHHKJCVQUE<RXCTQXXFICO>>, Id32<NJHHKJCVQUE<XPYIVJGMLOO<RXCTQXXFICO>>>, Id32<NJHHKJCVQUE<XPYIVJGMLOO<RXCTQXXFICO>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x2B6C780", Offset = "0x2B6B780", VA = "0x182B6C780")]
		public static (Id32<NJHHKJCVQUE<VAWWUJGMVPZ>>, Id32<NJHHKJCVQUE<XPYIVJGMLOO<RXCTQXXFICO>>>, Id32<NJHHKJCVQUE<XPYIVJGMLOO<RXCTQXXFICO>>>, Id32<NJHHKJCVQUE<XPYIVJGMLOO<RXCTQXXFICO>>>) ACPDJQGAGFW(this UnsafeList<byte> a, [Optional] Id32<XPYIVJGMLOO<RXCTQXXFICO>>? b, [Optional] Id32<XPYIVJGMLOO<RXCTQXXFICO>>? c, [Optional] Id32<XPYIVJGMLOO<RXCTQXXFICO>>? d)
		{
			return default((Id32<NJHHKJCVQUE<VAWWUJGMVPZ>>, Id32<NJHHKJCVQUE<XPYIVJGMLOO<RXCTQXXFICO>>>, Id32<NJHHKJCVQUE<XPYIVJGMLOO<RXCTQXXFICO>>>, Id32<NJHHKJCVQUE<XPYIVJGMLOO<RXCTQXXFICO>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x2B6F650", Offset = "0x2B6E650", VA = "0x182B6F650")]
		public static (Id32<NJHHKJCVQUE<VAWWUJGMVPZ>>, Id32<NJHHKJCVQUE<GMCOSWDRAOD>>, Id32<NJHHKJCVQUE<GMCOSWDRAOD>>, Id32<NJHHKJCVQUE<XPYIVJGMLOO<RXCTQXXFICO>>>) NQCUTEPGXKO(this UnsafeList<byte> a, float b, float c, [Optional] Id32<XPYIVJGMLOO<RXCTQXXFICO>>? d)
		{
			return default((Id32<NJHHKJCVQUE<VAWWUJGMVPZ>>, Id32<NJHHKJCVQUE<GMCOSWDRAOD>>, Id32<NJHHKJCVQUE<GMCOSWDRAOD>>, Id32<NJHHKJCVQUE<XPYIVJGMLOO<RXCTQXXFICO>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x2B6D800", Offset = "0x2B6C800", VA = "0x182B6D800")]
		public static (Id32<NJHHKJCVQUE<VAWWUJGMVPZ>>, Id32<NJHHKJCVQUE<GMCOSWDRAOD>>, Id32<NJHHKJCVQUE<XPYIVJGMLOO<GMCOSWDRAOD>>>, Id32<NJHHKJCVQUE<XPYIVJGMLOO<RXCTQXXFICO>>>) EDVTTMUKCCN(this UnsafeList<byte> a, float b, [Optional] Id32<XPYIVJGMLOO<GMCOSWDRAOD>>? c, [Optional] Id32<XPYIVJGMLOO<RXCTQXXFICO>>? d)
		{
			return default((Id32<NJHHKJCVQUE<VAWWUJGMVPZ>>, Id32<NJHHKJCVQUE<GMCOSWDRAOD>>, Id32<NJHHKJCVQUE<XPYIVJGMLOO<GMCOSWDRAOD>>>, Id32<NJHHKJCVQUE<XPYIVJGMLOO<RXCTQXXFICO>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x2B6CB60", Offset = "0x2B6BB60", VA = "0x182B6CB60")]
		public static (Id32<NJHHKJCVQUE<VAWWUJGMVPZ>>, Id32<NJHHKJCVQUE<XPYIVJGMLOO<GMCOSWDRAOD>>>, Id32<NJHHKJCVQUE<XPYIVJGMLOO<GMCOSWDRAOD>>>, Id32<NJHHKJCVQUE<XPYIVJGMLOO<RXCTQXXFICO>>>) AXBPVAPLQUA(this UnsafeList<byte> a, [Optional] Id32<XPYIVJGMLOO<GMCOSWDRAOD>>? b, [Optional] Id32<XPYIVJGMLOO<GMCOSWDRAOD>>? c, [Optional] Id32<XPYIVJGMLOO<RXCTQXXFICO>>? d)
		{
			return default((Id32<NJHHKJCVQUE<VAWWUJGMVPZ>>, Id32<NJHHKJCVQUE<XPYIVJGMLOO<GMCOSWDRAOD>>>, Id32<NJHHKJCVQUE<XPYIVJGMLOO<GMCOSWDRAOD>>>, Id32<NJHHKJCVQUE<XPYIVJGMLOO<RXCTQXXFICO>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x2B71900", Offset = "0x2B70900", VA = "0x182B71900")]
		public static (Id32<NJHHKJCVQUE<VAWWUJGMVPZ>>, Id32<NJHHKJCVQUE<RXCTQXXFICO>>, Id32<NJHHKJCVQUE<RXCTQXXFICO>>, Id32<NJHHKJCVQUE<XPYIVJGMLOO<RXCTQXXFICO>>>) VYBRTGATBET(this UnsafeList<byte> a, int b, int c, [Optional] Id32<XPYIVJGMLOO<RXCTQXXFICO>>? d)
		{
			return default((Id32<NJHHKJCVQUE<VAWWUJGMVPZ>>, Id32<NJHHKJCVQUE<RXCTQXXFICO>>, Id32<NJHHKJCVQUE<RXCTQXXFICO>>, Id32<NJHHKJCVQUE<XPYIVJGMLOO<RXCTQXXFICO>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x2B712D0", Offset = "0x2B702D0", VA = "0x182B712D0")]
		public static (Id32<NJHHKJCVQUE<VAWWUJGMVPZ>>, Id32<NJHHKJCVQUE<RXCTQXXFICO>>, Id32<NJHHKJCVQUE<XPYIVJGMLOO<RXCTQXXFICO>>>, Id32<NJHHKJCVQUE<XPYIVJGMLOO<RXCTQXXFICO>>>) UEQMSWGDNKI(this UnsafeList<byte> a, int b, [Optional] Id32<XPYIVJGMLOO<RXCTQXXFICO>>? c, [Optional] Id32<XPYIVJGMLOO<RXCTQXXFICO>>? d)
		{
			return default((Id32<NJHHKJCVQUE<VAWWUJGMVPZ>>, Id32<NJHHKJCVQUE<RXCTQXXFICO>>, Id32<NJHHKJCVQUE<XPYIVJGMLOO<RXCTQXXFICO>>>, Id32<NJHHKJCVQUE<XPYIVJGMLOO<RXCTQXXFICO>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x2B71050", Offset = "0x2B70050", VA = "0x182B71050")]
		public static (Id32<NJHHKJCVQUE<VAWWUJGMVPZ>>, Id32<NJHHKJCVQUE<XPYIVJGMLOO<RXCTQXXFICO>>>, Id32<NJHHKJCVQUE<XPYIVJGMLOO<RXCTQXXFICO>>>, Id32<NJHHKJCVQUE<XPYIVJGMLOO<RXCTQXXFICO>>>) SSOPJBFIPYV(this UnsafeList<byte> a, [Optional] Id32<XPYIVJGMLOO<RXCTQXXFICO>>? b, [Optional] Id32<XPYIVJGMLOO<RXCTQXXFICO>>? c, [Optional] Id32<XPYIVJGMLOO<RXCTQXXFICO>>? d)
		{
			return default((Id32<NJHHKJCVQUE<VAWWUJGMVPZ>>, Id32<NJHHKJCVQUE<XPYIVJGMLOO<RXCTQXXFICO>>>, Id32<NJHHKJCVQUE<XPYIVJGMLOO<RXCTQXXFICO>>>, Id32<NJHHKJCVQUE<XPYIVJGMLOO<RXCTQXXFICO>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x2B6E020", Offset = "0x2B6D020", VA = "0x182B6E020")]
		public static (Id32<NJHHKJCVQUE<VAWWUJGMVPZ>>, Id32<NJHHKJCVQUE<GMCOSWDRAOD>>, Id32<NJHHKJCVQUE<GMCOSWDRAOD>>, Id32<NJHHKJCVQUE<XPYIVJGMLOO<RXCTQXXFICO>>>) IFMURZSPCPY(this UnsafeList<byte> a, float b, float c, [Optional] Id32<XPYIVJGMLOO<RXCTQXXFICO>>? d)
		{
			return default((Id32<NJHHKJCVQUE<VAWWUJGMVPZ>>, Id32<NJHHKJCVQUE<GMCOSWDRAOD>>, Id32<NJHHKJCVQUE<GMCOSWDRAOD>>, Id32<NJHHKJCVQUE<XPYIVJGMLOO<RXCTQXXFICO>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x2B6D960", Offset = "0x2B6C960", VA = "0x182B6D960")]
		public static (Id32<NJHHKJCVQUE<VAWWUJGMVPZ>>, Id32<NJHHKJCVQUE<GMCOSWDRAOD>>, Id32<NJHHKJCVQUE<XPYIVJGMLOO<GMCOSWDRAOD>>>, Id32<NJHHKJCVQUE<XPYIVJGMLOO<RXCTQXXFICO>>>) EINVWOPJBWR(this UnsafeList<byte> a, float b, [Optional] Id32<XPYIVJGMLOO<GMCOSWDRAOD>>? c, [Optional] Id32<XPYIVJGMLOO<RXCTQXXFICO>>? d)
		{
			return default((Id32<NJHHKJCVQUE<VAWWUJGMVPZ>>, Id32<NJHHKJCVQUE<GMCOSWDRAOD>>, Id32<NJHHKJCVQUE<XPYIVJGMLOO<GMCOSWDRAOD>>>, Id32<NJHHKJCVQUE<XPYIVJGMLOO<RXCTQXXFICO>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x2B6EA80", Offset = "0x2B6DA80", VA = "0x182B6EA80")]
		public static (Id32<NJHHKJCVQUE<VAWWUJGMVPZ>>, Id32<NJHHKJCVQUE<XPYIVJGMLOO<GMCOSWDRAOD>>>, Id32<NJHHKJCVQUE<XPYIVJGMLOO<GMCOSWDRAOD>>>, Id32<NJHHKJCVQUE<XPYIVJGMLOO<RXCTQXXFICO>>>) JQIXPRIQIAA(this UnsafeList<byte> a, [Optional] Id32<XPYIVJGMLOO<GMCOSWDRAOD>>? b, [Optional] Id32<XPYIVJGMLOO<GMCOSWDRAOD>>? c, [Optional] Id32<XPYIVJGMLOO<RXCTQXXFICO>>? d)
		{
			return default((Id32<NJHHKJCVQUE<VAWWUJGMVPZ>>, Id32<NJHHKJCVQUE<XPYIVJGMLOO<GMCOSWDRAOD>>>, Id32<NJHHKJCVQUE<XPYIVJGMLOO<GMCOSWDRAOD>>>, Id32<NJHHKJCVQUE<XPYIVJGMLOO<RXCTQXXFICO>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x2B6D550", Offset = "0x2B6C550", VA = "0x182B6D550")]
		public static (Id32<NJHHKJCVQUE<VAWWUJGMVPZ>>, Id32<NJHHKJCVQUE<RXCTQXXFICO>>, Id32<NJHHKJCVQUE<RXCTQXXFICO>>, Id32<NJHHKJCVQUE<XPYIVJGMLOO<RXCTQXXFICO>>>) DMWOYHGUMNF(this UnsafeList<byte> a, int b, int c, [Optional] Id32<XPYIVJGMLOO<RXCTQXXFICO>>? d)
		{
			return default((Id32<NJHHKJCVQUE<VAWWUJGMVPZ>>, Id32<NJHHKJCVQUE<RXCTQXXFICO>>, Id32<NJHHKJCVQUE<RXCTQXXFICO>>, Id32<NJHHKJCVQUE<XPYIVJGMLOO<RXCTQXXFICO>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x2B70650", Offset = "0x2B6F650", VA = "0x182B70650")]
		public static (Id32<NJHHKJCVQUE<VAWWUJGMVPZ>>, Id32<NJHHKJCVQUE<RXCTQXXFICO>>, Id32<NJHHKJCVQUE<XPYIVJGMLOO<RXCTQXXFICO>>>, Id32<NJHHKJCVQUE<XPYIVJGMLOO<RXCTQXXFICO>>>) QEPVGHZDEEI(this UnsafeList<byte> a, int b, [Optional] Id32<XPYIVJGMLOO<RXCTQXXFICO>>? c, [Optional] Id32<XPYIVJGMLOO<RXCTQXXFICO>>? d)
		{
			return default((Id32<NJHHKJCVQUE<VAWWUJGMVPZ>>, Id32<NJHHKJCVQUE<RXCTQXXFICO>>, Id32<NJHHKJCVQUE<XPYIVJGMLOO<RXCTQXXFICO>>>, Id32<NJHHKJCVQUE<XPYIVJGMLOO<RXCTQXXFICO>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x2B6FFE0", Offset = "0x2B6EFE0", VA = "0x182B6FFE0")]
		public static (Id32<NJHHKJCVQUE<VAWWUJGMVPZ>>, Id32<NJHHKJCVQUE<XPYIVJGMLOO<RXCTQXXFICO>>>, Id32<NJHHKJCVQUE<XPYIVJGMLOO<RXCTQXXFICO>>>, Id32<NJHHKJCVQUE<XPYIVJGMLOO<RXCTQXXFICO>>>) PCLJMMQMLEN(this UnsafeList<byte> a, [Optional] Id32<XPYIVJGMLOO<RXCTQXXFICO>>? b, [Optional] Id32<XPYIVJGMLOO<RXCTQXXFICO>>? c, [Optional] Id32<XPYIVJGMLOO<RXCTQXXFICO>>? d)
		{
			return default((Id32<NJHHKJCVQUE<VAWWUJGMVPZ>>, Id32<NJHHKJCVQUE<XPYIVJGMLOO<RXCTQXXFICO>>>, Id32<NJHHKJCVQUE<XPYIVJGMLOO<RXCTQXXFICO>>>, Id32<NJHHKJCVQUE<XPYIVJGMLOO<RXCTQXXFICO>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x2B71780", Offset = "0x2B70780", VA = "0x182B71780")]
		public static (Id32<NJHHKJCVQUE<VAWWUJGMVPZ>>, Id32<NJHHKJCVQUE<GMCOSWDRAOD>>, Id32<NJHHKJCVQUE<GMCOSWDRAOD>>, Id32<NJHHKJCVQUE<XPYIVJGMLOO<RXCTQXXFICO>>>) UXCMGHTUVQN(this UnsafeList<byte> a, float b, float c, [Optional] Id32<XPYIVJGMLOO<RXCTQXXFICO>>? d)
		{
			return default((Id32<NJHHKJCVQUE<VAWWUJGMVPZ>>, Id32<NJHHKJCVQUE<GMCOSWDRAOD>>, Id32<NJHHKJCVQUE<GMCOSWDRAOD>>, Id32<NJHHKJCVQUE<XPYIVJGMLOO<RXCTQXXFICO>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x2B6EE20", Offset = "0x2B6DE20", VA = "0x182B6EE20")]
		public static (Id32<NJHHKJCVQUE<VAWWUJGMVPZ>>, Id32<NJHHKJCVQUE<GMCOSWDRAOD>>, Id32<NJHHKJCVQUE<XPYIVJGMLOO<GMCOSWDRAOD>>>, Id32<NJHHKJCVQUE<XPYIVJGMLOO<RXCTQXXFICO>>>) LGSAIBWRPPM(this UnsafeList<byte> a, float b, [Optional] Id32<XPYIVJGMLOO<GMCOSWDRAOD>>? c, [Optional] Id32<XPYIVJGMLOO<RXCTQXXFICO>>? d)
		{
			return default((Id32<NJHHKJCVQUE<VAWWUJGMVPZ>>, Id32<NJHHKJCVQUE<GMCOSWDRAOD>>, Id32<NJHHKJCVQUE<XPYIVJGMLOO<GMCOSWDRAOD>>>, Id32<NJHHKJCVQUE<XPYIVJGMLOO<RXCTQXXFICO>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x2B6DAC0", Offset = "0x2B6CAC0", VA = "0x182B6DAC0")]
		public static (Id32<NJHHKJCVQUE<VAWWUJGMVPZ>>, Id32<NJHHKJCVQUE<XPYIVJGMLOO<GMCOSWDRAOD>>>, Id32<NJHHKJCVQUE<XPYIVJGMLOO<GMCOSWDRAOD>>>, Id32<NJHHKJCVQUE<XPYIVJGMLOO<RXCTQXXFICO>>>) EPFLYNHMUTV(this UnsafeList<byte> a, [Optional] Id32<XPYIVJGMLOO<GMCOSWDRAOD>>? b, [Optional] Id32<XPYIVJGMLOO<GMCOSWDRAOD>>? c, [Optional] Id32<XPYIVJGMLOO<RXCTQXXFICO>>? d)
		{
			return default((Id32<NJHHKJCVQUE<VAWWUJGMVPZ>>, Id32<NJHHKJCVQUE<XPYIVJGMLOO<GMCOSWDRAOD>>>, Id32<NJHHKJCVQUE<XPYIVJGMLOO<GMCOSWDRAOD>>>, Id32<NJHHKJCVQUE<XPYIVJGMLOO<RXCTQXXFICO>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x2B6D090", Offset = "0x2B6C090", VA = "0x182B6D090")]
		public static (Id32<NJHHKJCVQUE<VAWWUJGMVPZ>>, Id32<NJHHKJCVQUE<RXCTQXXFICO>>, Id32<NJHHKJCVQUE<RXCTQXXFICO>>, Id32<NJHHKJCVQUE<XPYIVJGMLOO<RXCTQXXFICO>>>) CSTMMFTUSUE(this UnsafeList<byte> a, int b, int c, [Optional] Id32<XPYIVJGMLOO<RXCTQXXFICO>>? d)
		{
			return default((Id32<NJHHKJCVQUE<VAWWUJGMVPZ>>, Id32<NJHHKJCVQUE<RXCTQXXFICO>>, Id32<NJHHKJCVQUE<RXCTQXXFICO>>, Id32<NJHHKJCVQUE<XPYIVJGMLOO<RXCTQXXFICO>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x2B6FAD0", Offset = "0x2B6EAD0", VA = "0x182B6FAD0")]
		public static (Id32<NJHHKJCVQUE<VAWWUJGMVPZ>>, Id32<NJHHKJCVQUE<RXCTQXXFICO>>, Id32<NJHHKJCVQUE<XPYIVJGMLOO<RXCTQXXFICO>>>, Id32<NJHHKJCVQUE<XPYIVJGMLOO<RXCTQXXFICO>>>) ONSWAGDSYJJ(this UnsafeList<byte> a, int b, [Optional] Id32<XPYIVJGMLOO<RXCTQXXFICO>>? c, [Optional] Id32<XPYIVJGMLOO<RXCTQXXFICO>>? d)
		{
			return default((Id32<NJHHKJCVQUE<VAWWUJGMVPZ>>, Id32<NJHHKJCVQUE<RXCTQXXFICO>>, Id32<NJHHKJCVQUE<XPYIVJGMLOO<RXCTQXXFICO>>>, Id32<NJHHKJCVQUE<XPYIVJGMLOO<RXCTQXXFICO>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x2B6E2B0", Offset = "0x2B6D2B0", VA = "0x182B6E2B0")]
		public static (Id32<NJHHKJCVQUE<VAWWUJGMVPZ>>, Id32<NJHHKJCVQUE<XPYIVJGMLOO<RXCTQXXFICO>>>, Id32<NJHHKJCVQUE<XPYIVJGMLOO<RXCTQXXFICO>>>, Id32<NJHHKJCVQUE<XPYIVJGMLOO<RXCTQXXFICO>>>) ILTRIAPWCBU(this UnsafeList<byte> a, [Optional] Id32<XPYIVJGMLOO<RXCTQXXFICO>>? b, [Optional] Id32<XPYIVJGMLOO<RXCTQXXFICO>>? c, [Optional] Id32<XPYIVJGMLOO<RXCTQXXFICO>>? d)
		{
			return default((Id32<NJHHKJCVQUE<VAWWUJGMVPZ>>, Id32<NJHHKJCVQUE<XPYIVJGMLOO<RXCTQXXFICO>>>, Id32<NJHHKJCVQUE<XPYIVJGMLOO<RXCTQXXFICO>>>, Id32<NJHHKJCVQUE<XPYIVJGMLOO<RXCTQXXFICO>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x2B6F950", Offset = "0x2B6E950", VA = "0x182B6F950")]
		public static (Id32<NJHHKJCVQUE<VAWWUJGMVPZ>>, Id32<NJHHKJCVQUE<GMCOSWDRAOD>>, Id32<NJHHKJCVQUE<GMCOSWDRAOD>>, Id32<NJHHKJCVQUE<XPYIVJGMLOO<GMCOSWDRAOD>>>) OJBJEGLGFKU(this UnsafeList<byte> a, float b, float c, [Optional] Id32<XPYIVJGMLOO<GMCOSWDRAOD>>? d)
		{
			return default((Id32<NJHHKJCVQUE<VAWWUJGMVPZ>>, Id32<NJHHKJCVQUE<GMCOSWDRAOD>>, Id32<NJHHKJCVQUE<GMCOSWDRAOD>>, Id32<NJHHKJCVQUE<XPYIVJGMLOO<GMCOSWDRAOD>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x2B6F360", Offset = "0x2B6E360", VA = "0x182B6F360")]
		public static (Id32<NJHHKJCVQUE<VAWWUJGMVPZ>>, Id32<NJHHKJCVQUE<GMCOSWDRAOD>>, Id32<NJHHKJCVQUE<XPYIVJGMLOO<GMCOSWDRAOD>>>, Id32<NJHHKJCVQUE<XPYIVJGMLOO<GMCOSWDRAOD>>>) MQVZOWGLEYT(this UnsafeList<byte> a, float b, [Optional] Id32<XPYIVJGMLOO<GMCOSWDRAOD>>? c, [Optional] Id32<XPYIVJGMLOO<GMCOSWDRAOD>>? d)
		{
			return default((Id32<NJHHKJCVQUE<VAWWUJGMVPZ>>, Id32<NJHHKJCVQUE<GMCOSWDRAOD>>, Id32<NJHHKJCVQUE<XPYIVJGMLOO<GMCOSWDRAOD>>>, Id32<NJHHKJCVQUE<XPYIVJGMLOO<GMCOSWDRAOD>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x2B71510", Offset = "0x2B70510", VA = "0x182B71510")]
		public static (Id32<NJHHKJCVQUE<VAWWUJGMVPZ>>, Id32<NJHHKJCVQUE<XPYIVJGMLOO<GMCOSWDRAOD>>>, Id32<NJHHKJCVQUE<XPYIVJGMLOO<GMCOSWDRAOD>>>, Id32<NJHHKJCVQUE<XPYIVJGMLOO<GMCOSWDRAOD>>>) UIHTNVSZZFE(this UnsafeList<byte> a, [Optional] Id32<XPYIVJGMLOO<GMCOSWDRAOD>>? b, [Optional] Id32<XPYIVJGMLOO<GMCOSWDRAOD>>? c, [Optional] Id32<XPYIVJGMLOO<GMCOSWDRAOD>>? d)
		{
			return default((Id32<NJHHKJCVQUE<VAWWUJGMVPZ>>, Id32<NJHHKJCVQUE<XPYIVJGMLOO<GMCOSWDRAOD>>>, Id32<NJHHKJCVQUE<XPYIVJGMLOO<GMCOSWDRAOD>>>, Id32<NJHHKJCVQUE<XPYIVJGMLOO<GMCOSWDRAOD>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x2B70A00", Offset = "0x2B6FA00", VA = "0x182B70A00")]
		public static (Id32<NJHHKJCVQUE<VAWWUJGMVPZ>>, Id32<NJHHKJCVQUE<RXCTQXXFICO>>, Id32<NJHHKJCVQUE<RXCTQXXFICO>>, Id32<NJHHKJCVQUE<XPYIVJGMLOO<RXCTQXXFICO>>>) QKBWGYPMEXM(this UnsafeList<byte> a, int b, int c, [Optional] Id32<XPYIVJGMLOO<RXCTQXXFICO>>? d)
		{
			return default((Id32<NJHHKJCVQUE<VAWWUJGMVPZ>>, Id32<NJHHKJCVQUE<RXCTQXXFICO>>, Id32<NJHHKJCVQUE<RXCTQXXFICO>>, Id32<NJHHKJCVQUE<XPYIVJGMLOO<RXCTQXXFICO>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x2B71C90", Offset = "0x2B70C90", VA = "0x182B71C90")]
		public static (Id32<NJHHKJCVQUE<VAWWUJGMVPZ>>, Id32<NJHHKJCVQUE<RXCTQXXFICO>>, Id32<NJHHKJCVQUE<XPYIVJGMLOO<RXCTQXXFICO>>>, Id32<NJHHKJCVQUE<XPYIVJGMLOO<RXCTQXXFICO>>>) XCCBLRWEZVX(this UnsafeList<byte> a, int b, [Optional] Id32<XPYIVJGMLOO<RXCTQXXFICO>>? c, [Optional] Id32<XPYIVJGMLOO<RXCTQXXFICO>>? d)
		{
			return default((Id32<NJHHKJCVQUE<VAWWUJGMVPZ>>, Id32<NJHHKJCVQUE<RXCTQXXFICO>>, Id32<NJHHKJCVQUE<XPYIVJGMLOO<RXCTQXXFICO>>>, Id32<NJHHKJCVQUE<XPYIVJGMLOO<RXCTQXXFICO>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x2B6FDA0", Offset = "0x2B6EDA0", VA = "0x182B6FDA0")]
		public static (Id32<NJHHKJCVQUE<VAWWUJGMVPZ>>, Id32<NJHHKJCVQUE<XPYIVJGMLOO<RXCTQXXFICO>>>, Id32<NJHHKJCVQUE<XPYIVJGMLOO<RXCTQXXFICO>>>, Id32<NJHHKJCVQUE<XPYIVJGMLOO<RXCTQXXFICO>>>) OWOPFGHIMKQ(this UnsafeList<byte> a, [Optional] Id32<XPYIVJGMLOO<RXCTQXXFICO>>? b, [Optional] Id32<XPYIVJGMLOO<RXCTQXXFICO>>? c, [Optional] Id32<XPYIVJGMLOO<RXCTQXXFICO>>? d)
		{
			return default((Id32<NJHHKJCVQUE<VAWWUJGMVPZ>>, Id32<NJHHKJCVQUE<XPYIVJGMLOO<RXCTQXXFICO>>>, Id32<NJHHKJCVQUE<XPYIVJGMLOO<RXCTQXXFICO>>>, Id32<NJHHKJCVQUE<XPYIVJGMLOO<RXCTQXXFICO>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x2B6D1F0", Offset = "0x2B6C1F0", VA = "0x182B6D1F0")]
		public static (Id32<NJHHKJCVQUE<VAWWUJGMVPZ>>, Id32<NJHHKJCVQUE<RXCTQXXFICO>>, Id32<NJHHKJCVQUE<XPYIVJGMLOO<RXCTQXXFICO>>>) CULPIDMELIB(this UnsafeList<byte> a, [Optional] int? b, [Optional] Id32<XPYIVJGMLOO<RXCTQXXFICO>>? c)
		{
			return default((Id32<NJHHKJCVQUE<VAWWUJGMVPZ>>, Id32<NJHHKJCVQUE<RXCTQXXFICO>>, Id32<NJHHKJCVQUE<XPYIVJGMLOO<RXCTQXXFICO>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x2B71A60", Offset = "0x2B70A60", VA = "0x182B71A60")]
		public static (Id32<NJHHKJCVQUE<VAWWUJGMVPZ>>, Id32<NJHHKJCVQUE<XPYIVJGMLOO<RXCTQXXFICO>>>, Id32<NJHHKJCVQUE<XPYIVJGMLOO<RXCTQXXFICO>>>) WCLKDKFLQJQ(this UnsafeList<byte> a, [Optional] Id32<XPYIVJGMLOO<RXCTQXXFICO>>? b, [Optional] Id32<XPYIVJGMLOO<RXCTQXXFICO>>? c)
		{
			return default((Id32<NJHHKJCVQUE<VAWWUJGMVPZ>>, Id32<NJHHKJCVQUE<XPYIVJGMLOO<RXCTQXXFICO>>>, Id32<NJHHKJCVQUE<XPYIVJGMLOO<RXCTQXXFICO>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x2B6F4B0", Offset = "0x2B6E4B0", VA = "0x182B6F4B0")]
		public static Id32<NJHHKJCVQUE<VAWWUJGMVPZ>> NOIYGBZTAJN(this UnsafeList<byte> a)
		{
			return default(Id32<NJHHKJCVQUE<VAWWUJGMVPZ>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x2B6E7F0", Offset = "0x2B6D7F0", VA = "0x182B6E7F0")]
		public static (Id32<NJHHKJCVQUE<VAWWUJGMVPZ>>, Id32<NJHHKJCVQUE<GMCOSWDRAOD>>, Id32<NJHHKJCVQUE<GMCOSWDRAOD>>, Id32<NJHHKJCVQUE<XPYIVJGMLOO<GMCOSWDRAOD>>>) JIGBDNAMONG(this UnsafeList<byte> a, float b, float c, [Optional] Id32<XPYIVJGMLOO<GMCOSWDRAOD>>? d)
		{
			return default((Id32<NJHHKJCVQUE<VAWWUJGMVPZ>>, Id32<NJHHKJCVQUE<GMCOSWDRAOD>>, Id32<NJHHKJCVQUE<GMCOSWDRAOD>>, Id32<NJHHKJCVQUE<XPYIVJGMLOO<GMCOSWDRAOD>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x2B6D6B0", Offset = "0x2B6C6B0", VA = "0x182B6D6B0")]
		public static (Id32<NJHHKJCVQUE<VAWWUJGMVPZ>>, Id32<NJHHKJCVQUE<GMCOSWDRAOD>>, Id32<NJHHKJCVQUE<XPYIVJGMLOO<GMCOSWDRAOD>>>, Id32<NJHHKJCVQUE<XPYIVJGMLOO<GMCOSWDRAOD>>>) DVQXKEYSUPJ(this UnsafeList<byte> a, float b, [Optional] Id32<XPYIVJGMLOO<GMCOSWDRAOD>>? c, [Optional] Id32<XPYIVJGMLOO<GMCOSWDRAOD>>? d)
		{
			return default((Id32<NJHHKJCVQUE<VAWWUJGMVPZ>>, Id32<NJHHKJCVQUE<GMCOSWDRAOD>>, Id32<NJHHKJCVQUE<XPYIVJGMLOO<GMCOSWDRAOD>>>, Id32<NJHHKJCVQUE<XPYIVJGMLOO<GMCOSWDRAOD>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x2B6EBB0", Offset = "0x2B6DBB0", VA = "0x182B6EBB0")]
		public static (Id32<NJHHKJCVQUE<VAWWUJGMVPZ>>, Id32<NJHHKJCVQUE<XPYIVJGMLOO<GMCOSWDRAOD>>>, Id32<NJHHKJCVQUE<XPYIVJGMLOO<GMCOSWDRAOD>>>, Id32<NJHHKJCVQUE<XPYIVJGMLOO<GMCOSWDRAOD>>>) KLHDVAJKVOG(this UnsafeList<byte> a, [Optional] Id32<XPYIVJGMLOO<GMCOSWDRAOD>>? b, [Optional] Id32<XPYIVJGMLOO<GMCOSWDRAOD>>? c, [Optional] Id32<XPYIVJGMLOO<GMCOSWDRAOD>>? d)
		{
			return default((Id32<NJHHKJCVQUE<VAWWUJGMVPZ>>, Id32<NJHHKJCVQUE<XPYIVJGMLOO<GMCOSWDRAOD>>>, Id32<NJHHKJCVQUE<XPYIVJGMLOO<GMCOSWDRAOD>>>, Id32<NJHHKJCVQUE<XPYIVJGMLOO<GMCOSWDRAOD>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x2B70C80", Offset = "0x2B6FC80", VA = "0x182B70C80")]
		public static (Id32<NJHHKJCVQUE<VAWWUJGMVPZ>>, Id32<NJHHKJCVQUE<RXCTQXXFICO>>, Id32<NJHHKJCVQUE<RXCTQXXFICO>>, Id32<NJHHKJCVQUE<XPYIVJGMLOO<RXCTQXXFICO>>>) RSUMHAQBGFE(this UnsafeList<byte> a, int b, int c, [Optional] Id32<XPYIVJGMLOO<RXCTQXXFICO>>? d)
		{
			return default((Id32<NJHHKJCVQUE<VAWWUJGMVPZ>>, Id32<NJHHKJCVQUE<RXCTQXXFICO>>, Id32<NJHHKJCVQUE<RXCTQXXFICO>>, Id32<NJHHKJCVQUE<XPYIVJGMLOO<RXCTQXXFICO>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x2B6DED0", Offset = "0x2B6CED0", VA = "0x182B6DED0")]
		public static (Id32<NJHHKJCVQUE<VAWWUJGMVPZ>>, Id32<NJHHKJCVQUE<RXCTQXXFICO>>, Id32<NJHHKJCVQUE<XPYIVJGMLOO<RXCTQXXFICO>>>, Id32<NJHHKJCVQUE<XPYIVJGMLOO<RXCTQXXFICO>>>) HTQPUCNXOHL(this UnsafeList<byte> a, int b, [Optional] Id32<XPYIVJGMLOO<RXCTQXXFICO>>? c, [Optional] Id32<XPYIVJGMLOO<RXCTQXXFICO>>? d)
		{
			return default((Id32<NJHHKJCVQUE<VAWWUJGMVPZ>>, Id32<NJHHKJCVQUE<RXCTQXXFICO>>, Id32<NJHHKJCVQUE<XPYIVJGMLOO<RXCTQXXFICO>>>, Id32<NJHHKJCVQUE<XPYIVJGMLOO<RXCTQXXFICO>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x2B6E3D0", Offset = "0x2B6D3D0", VA = "0x182B6E3D0")]
		public static (Id32<NJHHKJCVQUE<VAWWUJGMVPZ>>, Id32<NJHHKJCVQUE<XPYIVJGMLOO<RXCTQXXFICO>>>, Id32<NJHHKJCVQUE<XPYIVJGMLOO<RXCTQXXFICO>>>, Id32<NJHHKJCVQUE<XPYIVJGMLOO<RXCTQXXFICO>>>) IVVBNXWOHHG(this UnsafeList<byte> a, [Optional] Id32<XPYIVJGMLOO<RXCTQXXFICO>>? b, [Optional] Id32<XPYIVJGMLOO<RXCTQXXFICO>>? c, [Optional] Id32<XPYIVJGMLOO<RXCTQXXFICO>>? d)
		{
			return default((Id32<NJHHKJCVQUE<VAWWUJGMVPZ>>, Id32<NJHHKJCVQUE<XPYIVJGMLOO<RXCTQXXFICO>>>, Id32<NJHHKJCVQUE<XPYIVJGMLOO<RXCTQXXFICO>>>, Id32<NJHHKJCVQUE<XPYIVJGMLOO<RXCTQXXFICO>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x2B6CDE0", Offset = "0x2B6BDE0", VA = "0x182B6CDE0")]
		public static (Id32<NJHHKJCVQUE<VAWWUJGMVPZ>>, Id32<NJHHKJCVQUE<RXCTQXXFICO>>, Id32<NJHHKJCVQUE<RXCTQXXFICO>>, Id32<NJHHKJCVQUE<XPYIVJGMLOO<RXCTQXXFICO>>>) BHZNJRZNAXH(this UnsafeList<byte> a, int b, int c, [Optional] Id32<XPYIVJGMLOO<RXCTQXXFICO>>? d)
		{
			return default((Id32<NJHHKJCVQUE<VAWWUJGMVPZ>>, Id32<NJHHKJCVQUE<RXCTQXXFICO>>, Id32<NJHHKJCVQUE<RXCTQXXFICO>>, Id32<NJHHKJCVQUE<XPYIVJGMLOO<RXCTQXXFICO>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x2B70DE0", Offset = "0x2B6FDE0", VA = "0x182B70DE0")]
		public static (Id32<NJHHKJCVQUE<VAWWUJGMVPZ>>, Id32<NJHHKJCVQUE<RXCTQXXFICO>>, Id32<NJHHKJCVQUE<XPYIVJGMLOO<RXCTQXXFICO>>>, Id32<NJHHKJCVQUE<XPYIVJGMLOO<RXCTQXXFICO>>>) SEMNLOONRBE(this UnsafeList<byte> a, int b, [Optional] Id32<XPYIVJGMLOO<RXCTQXXFICO>>? c, [Optional] Id32<XPYIVJGMLOO<RXCTQXXFICO>>? d)
		{
			return default((Id32<NJHHKJCVQUE<VAWWUJGMVPZ>>, Id32<NJHHKJCVQUE<RXCTQXXFICO>>, Id32<NJHHKJCVQUE<XPYIVJGMLOO<RXCTQXXFICO>>>, Id32<NJHHKJCVQUE<XPYIVJGMLOO<RXCTQXXFICO>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x2B71DE0", Offset = "0x2B70DE0", VA = "0x182B71DE0")]
		public static (Id32<NJHHKJCVQUE<VAWWUJGMVPZ>>, Id32<NJHHKJCVQUE<XPYIVJGMLOO<RXCTQXXFICO>>>, Id32<NJHHKJCVQUE<XPYIVJGMLOO<RXCTQXXFICO>>>, Id32<NJHHKJCVQUE<XPYIVJGMLOO<RXCTQXXFICO>>>) YTVFBFUTDNR(this UnsafeList<byte> a, [Optional] Id32<XPYIVJGMLOO<RXCTQXXFICO>>? b, [Optional] Id32<XPYIVJGMLOO<RXCTQXXFICO>>? c, [Optional] Id32<XPYIVJGMLOO<RXCTQXXFICO>>? d)
		{
			return default((Id32<NJHHKJCVQUE<VAWWUJGMVPZ>>, Id32<NJHHKJCVQUE<XPYIVJGMLOO<RXCTQXXFICO>>>, Id32<NJHHKJCVQUE<XPYIVJGMLOO<RXCTQXXFICO>>>, Id32<NJHHKJCVQUE<XPYIVJGMLOO<RXCTQXXFICO>>>));
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
