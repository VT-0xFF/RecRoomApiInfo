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
		[Cpp2IlInjected.Address(RVA = "0xAD08C0", Offset = "0xACEEC0", VA = "0x180AD08C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x2AF6250", Offset = "0x2AF4850", VA = "0x182AF6250")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xAD0950", Offset = "0xACEF50", VA = "0x180AD0950")]
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
		[Cpp2IlInjected.Address(RVA = "0xAD0990", Offset = "0xACEF90", VA = "0x180AD0990")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
namespace Circuits.Shared.Core.ByteCode
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public static class EJNDQFJVHCH
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x37F03F0", Offset = "0x37EE9F0", VA = "0x1837F03F0")]
		public static Id32<OPRBWAEKAQJ<a>> KWAGMYYLHDZ<a>(this int a)
		{
			return default(Id32<OPRBWAEKAQJ<a>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x2AF5E10", Offset = "0x2AF4410", VA = "0x182AF5E10")]
		public static Id32<QIASPGRRBJU> AABSLUAUVQY(this int a)
		{
			return default(Id32<QIASPGRRBJU>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x37F03F0", Offset = "0x37EE9F0", VA = "0x1837F03F0")]
		public static Id32<YGAASBJWVTN<b>> UAHKESAOSPH<b>(this int a)
		{
			return default(Id32<YGAASBJWVTN<b>>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public sealed class OPRBWAEKAQJ<a>
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public sealed class LOMMWLQLJQC
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public sealed class EHBKKFTSHQH
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public sealed class QIASPGRRBJU
	{
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public sealed class LYBQOQJENGA
	{
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public sealed class WSKIFQIKLJM
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
	public static class HHBBWSIGTOJ
	{
		[Cpp2IlInjected.Token(Token = "0x200000E")]
		public readonly struct ProcessOpDelegate<TContext, TDeps, TCompileState>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000091")]
			private readonly IntPtr _impl;

			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0xF411F0", Offset = "0xF3F7F0", VA = "0x180F411F0")]
			public ProcessOpDelegate(IntPtr impl)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x5CC3E50", Offset = "0x5CC2450", VA = "0x185CC3E50")]
			public int Invoke(TDeps deps, TContext ctx, TCompileState compileState, [In] UnsafeList<byte> fromByteCode, int byteCodePtr)
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x38F6FA0", Offset = "0x38F55A0", VA = "0x1838F6FA0")]
		public static void OWGWSXXWNES<TDeps, TContext, TCompileState>(TDeps a, TContext b, TCompileState c, [In] UnsafeList<byte> oldByteCode, UnsafeList<byte> newByteCode, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processAddF32_F32i_F32i_F32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processAddF32_F32i_F32r_F32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processAddF32_F32r_F32r_F32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processAddI32_I32i_I32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processAddI32_I32i_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processAddI32_I32r_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processAndI32_I32i_I32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processAndI32_I32i_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processAndI32_I32r_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfEqualF32_F32i_F32i_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfEqualF32_F32i_F32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfEqualF32_F32r_F32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfEqualI32_I32i_I32i_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfEqualI32_I32i_I32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfEqualI32_I32r_I32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfGreaterOrEqualF32_F32i_F32i_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfGreaterOrEqualF32_F32i_F32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfGreaterOrEqualF32_F32r_F32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfGreaterOrEqualI32_I32i_I32i_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfGreaterOrEqualI32_I32i_I32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfGreaterOrEqualI32_I32r_I32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfLessF32_F32i_F32i_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfLessF32_F32i_F32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfLessF32_F32r_F32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfLessI32_I32i_I32i_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfLessI32_I32i_I32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfLessI32_I32r_I32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfLessOrEqualF32_F32i_F32i_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfLessOrEqualF32_F32i_F32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfLessOrEqualF32_F32r_F32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfLessOrEqualI32_I32i_I32i_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfLessOrEqualI32_I32i_I32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfLessOrEqualI32_I32r_I32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfNotEqualF32_F32i_F32i_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfNotEqualF32_F32i_F32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfNotEqualF32_F32r_F32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfNotEqualI32_I32i_I32i_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfNotEqualI32_I32i_I32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfNotEqualI32_I32r_I32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfNotZeroF32_F32i_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfNotZeroF32_F32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfNotZeroI32_I32i_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfNotZeroI32_I32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfZeroF32_F32i_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfZeroF32_F32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfZeroI32_I32i_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfZeroI32_I32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processCallInternal_I32i_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processCallInternal_I32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processCallExternal_I32i_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processCallExternal_I32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processCallRuntime_I32i_I32i_Xi, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processCopyI32_I32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processCopyI32_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processCopyX_Xr_I32i_Xi, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processCopyX_Xr_Xr_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processDivideF32_F32i_F32i_F32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processDivideF32_F32i_F32r_F32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processDivideF32_F32r_F32r_F32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processDivideI32_I32i_I32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processDivideI32_I32i_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processDivideI32_I32r_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processEqualF32_F32i_F32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processEqualF32_F32i_F32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processEqualF32_F32r_F32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processEqualI32_I32i_I32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processEqualI32_I32i_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processEqualI32_I32r_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processEnd, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processGreaterF32_F32i_F32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processGreaterF32_F32i_F32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processGreaterF32_F32r_F32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processGreaterI32_I32i_I32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processGreaterI32_I32i_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processGreaterI32_I32r_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processGreaterOrEqualF32_F32i_F32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processGreaterOrEqualF32_F32i_F32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processGreaterOrEqualF32_F32r_F32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processGreaterOrEqualI32_I32i_I32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processGreaterOrEqualI32_I32i_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processGreaterOrEqualI32_I32r_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processJump_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processJump_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processLessF32_F32i_F32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processLessF32_F32i_F32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processLessF32_F32r_F32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processLessI32_I32i_I32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processLessI32_I32i_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processLessI32_I32r_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processLessOrEqualF32_F32i_F32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processLessOrEqualF32_F32i_F32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processLessOrEqualF32_F32r_F32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processLessOrEqualI32_I32i_I32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processLessOrEqualI32_I32i_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processLessOrEqualI32_I32r_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processModI32_I32i_I32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processModI32_I32i_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processModI32_I32r_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processMultiplyF32_F32i_F32i_F32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processMultiplyF32_F32i_F32r_F32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processMultiplyF32_F32r_F32r_F32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processMultiplyI32_I32i_I32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processMultiplyI32_I32i_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processMultiplyI32_I32r_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processNegateF32_F32i_F32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processNegateF32_F32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processNegateF32_F32r_F32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processNegateI32_I32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processNegateI32_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processNegateI32_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processNoOp, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processNotEqualF32_F32i_F32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processNotEqualF32_F32i_F32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processNotEqualF32_F32r_F32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processNotEqualI32_I32i_I32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processNotEqualI32_I32i_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processNotEqualI32_I32r_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processNotI32_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processNotI32_I32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processNotI32_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processOrI32_I32i_I32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processOrI32_I32i_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processOrI32_I32r_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processReturn, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processStaticCastF32I32_F32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processStaticCastI32F32_I32r_F32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processSubtractF32_F32i_F32i_F32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processSubtractF32_F32i_F32r_F32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processSubtractF32_F32r_F32r_F32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processSubtractI32_I32i_I32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processSubtractI32_I32i_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processSubtractI32_I32r_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processXorI32_I32i_I32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processXorI32_I32i_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processXorI32_I32r_I32r_I32r) where TDeps : notnull where TContext : notnull where TCompileState : notnull
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x2AF61B0", Offset = "0x2AF47B0", VA = "0x182AF61B0")]
		private static int HZNSDYPMOHG([In] UnsafeList<byte> from, UnsafeList<byte> a, int b, int c)
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public static class WTDFKZFUBPW
	{
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		public static readonly int QRCLKFWLXCO;

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x3EC6C90", Offset = "0x3EC5290", VA = "0x183EC6C90")]
		public static Id32<OPRBWAEKAQJ<a>> XSOCIRWTIDG<a>([In] this UnsafeList<byte> self)
		{
			return default(Id32<OPRBWAEKAQJ<a>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x3EC6B60", Offset = "0x3EC5160", VA = "0x183EC6B60")]
		public static Id32<OPRBWAEKAQJ<OPRBWAEKAQJ<b>>> FAJWZTKPJVV<b>(this UnsafeList<byte> a, [Optional] Id32<OPRBWAEKAQJ<b>>? b)
		{
			return default(Id32<OPRBWAEKAQJ<OPRBWAEKAQJ<b>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x2AFC320", Offset = "0x2AFA920", VA = "0x182AFC320")]
		public static Id32<OPRBWAEKAQJ<WTQCYPTFIQA>> QTWBISBSXMD(this UnsafeList<byte> a, [Optional] Id32<WTQCYPTFIQA>? b)
		{
			return default(Id32<OPRBWAEKAQJ<WTQCYPTFIQA>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x2AFBF60", Offset = "0x2AFA560", VA = "0x182AFBF60")]
		public static Id32<OPRBWAEKAQJ<LOMMWLQLJQC>> HFRBHSRGDIH(this UnsafeList<byte> a, [Optional] float? b)
		{
			return default(Id32<OPRBWAEKAQJ<LOMMWLQLJQC>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x2AFC240", Offset = "0x2AFA840", VA = "0x182AFC240")]
		public static Id32<OPRBWAEKAQJ<EHBKKFTSHQH>> ONCDTYNZFIC(this UnsafeList<byte> a, [Optional] int? b)
		{
			return default(Id32<OPRBWAEKAQJ<EHBKKFTSHQH>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x2AFC050", Offset = "0x2AFA650", VA = "0x182AFC050")]
		public static Id32<OPRBWAEKAQJ<TYMAZGWXABP>> HSJCRBQKXBG(this UnsafeList<byte> a, [Optional] Id32<TYMAZGWXABP>? b)
		{
			return default(Id32<OPRBWAEKAQJ<TYMAZGWXABP>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x2AFC140", Offset = "0x2AFA740", VA = "0x182AFC140")]
		public static Id32<OPRBWAEKAQJ<WSKIFQIKLJM>> MDXPCZPIFTT(this UnsafeList<byte> a, [Optional] byte? b)
		{
			return default(Id32<OPRBWAEKAQJ<WSKIFQIKLJM>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x2AFBD80", Offset = "0x2AFA380", VA = "0x182AFBD80")]
		public static Id32<OPRBWAEKAQJ<QIASPGRRBJU>> DYAFUPUIGDP(this UnsafeList<byte> a, [Optional] Id32<QIASPGRRBJU>? b)
		{
			return default(Id32<OPRBWAEKAQJ<QIASPGRRBJU>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x2AFBE70", Offset = "0x2AFA470", VA = "0x182AFBE70")]
		public static Id32<OPRBWAEKAQJ<LYBQOQJENGA>> HDRMNWNTSKT(this UnsafeList<byte> a, [Optional] Op? b)
		{
			return default(Id32<OPRBWAEKAQJ<LYBQOQJENGA>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x3EC6B60", Offset = "0x3EC5160", VA = "0x183EC6B60")]
		public static Id32<OPRBWAEKAQJ<YGAASBJWVTN<c>>> IOWSLJWYUGB<c>(this UnsafeList<byte> a, [Optional] Id32<YGAASBJWVTN<c>>? b)
		{
			return default(Id32<OPRBWAEKAQJ<YGAASBJWVTN<c>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x2AF5C60", Offset = "0x2AF4260", VA = "0x182AF5C60")]
		public static void GGMFNLHRAQD(this UnsafeList<byte> a, Id32<OPRBWAEKAQJ<EHBKKFTSHQH>> b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x3EC6A60", Offset = "0x3EC5060", VA = "0x183EC6A60")]
		public static void WGDDYNWFEJM<d>(this UnsafeList<byte> a, Id32<OPRBWAEKAQJ<OPRBWAEKAQJ<d>>> b, Id32<OPRBWAEKAQJ<d>> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x3EC6A60", Offset = "0x3EC5060", VA = "0x183EC6A60")]
		public static void BWCJGIKCSKI<e>(this UnsafeList<byte> a, Id32<OPRBWAEKAQJ<YGAASBJWVTN<e>>> b, Id32<YGAASBJWVTN<e>> c)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public static class SAMZSUTHRJX
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x2AF62D0", Offset = "0x2AF48D0", VA = "0x182AF62D0")]
		public static Union32 BDFTEEUORUR([In] this ReadOnlySpan<byte> bytes, int a)
		{
			return default(Union32);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x2AF6340", Offset = "0x2AF4940", VA = "0x182AF6340")]
		public static Union32 BDFTEEUORUR([In] this UnsafeList<byte> bytes, int a)
		{
			return default(Union32);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x3D15150", Offset = "0x3D13750", VA = "0x183D15150")]
		public static Union32 BDFTEEUORUR<f>(this ReadOnlyIdArray<f, byte> a, Id32<f> b)
		{
			return default(Union32);
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x3D14F60", Offset = "0x3D13560", VA = "0x183D14F60")]
		public static Union32 BDFTEEUORUR<g>([In] this ReadOnlyIdSpan<g, byte> bytes, Id32<g> a)
		{
			return default(Union32);
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x3D14F00", Offset = "0x3D13500", VA = "0x183D14F00")]
		public static Union32 BDFTEEUORUR<i>(this IdArray<i, byte> a, Id32<i> b)
		{
			return default(Union32);
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x3D150E0", Offset = "0x3D136E0", VA = "0x183D150E0")]
		public static Union32 BDFTEEUORUR<j>([In] this IdSpan<j, byte> bytes, Id32<j> a)
		{
			return default(Union32);
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x3D14E40", Offset = "0x3D13440", VA = "0x183D14E40")]
		public static Union32 BDFTEEUORUR<k>(this ReadOnlyIdArray<k, byte> a, Id32<k> b)
		{
			return default(Union32);
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x2AF62D0", Offset = "0x2AF48D0", VA = "0x182AF62D0")]
		public static int FRLNLTKZKLE([In] this ReadOnlySpan<byte> bytes, int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x2AF5E00", Offset = "0x2AF4400", VA = "0x182AF5E00")]
		public static int FRLNLTKZKLE([In] this UnsafeList<byte> bytes, int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x3D15840", Offset = "0x3D13E40", VA = "0x183D15840")]
		public static int FRLNLTKZKLE<p>(this ReadOnlyIdArray<p, byte> a, Id32<p> b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x3D158E0", Offset = "0x3D13EE0", VA = "0x183D158E0")]
		public static int FRLNLTKZKLE<s>(this IdArray<s, byte> a, Id32<s> b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x3D157F0", Offset = "0x3D13DF0", VA = "0x183D157F0")]
		public static int FRLNLTKZKLE<t>([In] this IdSpan<t, byte> bytes, Id32<t> a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x3D15890", Offset = "0x3D13E90", VA = "0x183D15890")]
		public static int FRLNLTKZKLE<u>(this ReadOnlyIdArray<u, byte> a, Id32<u> b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x3D14950", Offset = "0x3D12F50", VA = "0x183D14950")]
		public static float ATVLJMECLAT<bc>(this IdArray<bc, byte> a, Id32<bc> b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x3D149D0", Offset = "0x3D12FD0", VA = "0x183D149D0")]
		public static float ATVLJMECLAT<bd>([In] this IdSpan<bd, byte> bytes, Id32<bd> a)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x3D14A20", Offset = "0x3D13020", VA = "0x183D14A20")]
		public static float ATVLJMECLAT<be>(this ReadOnlyIdArray<be, byte> a, Id32<be> b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x3D15CC0", Offset = "0x3D142C0", VA = "0x183D15CC0")]
		public static byte IXDFXHWTEYR<bj>(this ReadOnlyIdArray<bj, byte> a, Id32<bj> b)
		{
			return default(byte);
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x3D15BF0", Offset = "0x3D141F0", VA = "0x183D15BF0")]
		public static byte IXDFXHWTEYR<bk>([In] this ReadOnlyIdSpan<bk, byte> bytes, Id32<bk> a)
		{
			return default(byte);
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x3D15C40", Offset = "0x3D14240", VA = "0x183D15C40")]
		public static byte IXDFXHWTEYR<bm>(this IdArray<bm, byte> a, Id32<bm> b)
		{
			return default(byte);
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x3D15B60", Offset = "0x3D14160", VA = "0x183D15B60")]
		public static byte IXDFXHWTEYR<bn>([In] this IdSpan<bn, byte> bytes, Id32<bn> a)
		{
			return default(byte);
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x3D15A90", Offset = "0x3D14090", VA = "0x183D15A90")]
		public static byte IXDFXHWTEYR<bo>(this ReadOnlyIdArray<bo, byte> a, Id32<bo> b)
		{
			return default(byte);
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x2AF5E00", Offset = "0x2AF4400", VA = "0x182AF5E00")]
		public static Op YFPLANFWTXZ([In] this UnsafeList<byte> bytes, int a)
		{
			return default(Op);
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x3D16360", Offset = "0x3D14960", VA = "0x183D16360")]
		public static Op YFPLANFWTXZ<by>(this ReadOnlyIdArray<by, byte> a, Id32<by> b)
		{
			return default(Op);
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x3D15560", Offset = "0x3D13B60", VA = "0x183D15560")]
		public static Id32<OPRBWAEKAQJ<RBQKWAEEJQD>> FJLMILCRZVZ<cg>(this IdArray<cg, byte> a, Id32<cg> b)
		{
			return default(Id32<OPRBWAEKAQJ<RBQKWAEEJQD>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x3D15670", Offset = "0x3D13C70", VA = "0x183D15670")]
		public static Id32<OPRBWAEKAQJ<RBQKWAEEJQD>> FJLMILCRZVZ<ch>([In] this IdSpan<ch, byte> bytes, Id32<ch> a)
		{
			return default(Id32<OPRBWAEKAQJ<RBQKWAEEJQD>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x3D155E0", Offset = "0x3D13BE0", VA = "0x183D155E0")]
		public static Id32<OPRBWAEKAQJ<RBQKWAEEJQD>> FJLMILCRZVZ<ci>(this ReadOnlyIdArray<ci, byte> a, Id32<ci> b)
		{
			return default(Id32<OPRBWAEKAQJ<RBQKWAEEJQD>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x3D15350", Offset = "0x3D13950", VA = "0x183D15350")]
		public static Id32<YGAASBJWVTN<RBQKWAEEJQD>> CQUGMVXNUJH<cs>(this ReadOnlyIdArray<cs, byte> a, Id32<cs> b)
		{
			return default(Id32<YGAASBJWVTN<RBQKWAEEJQD>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x3D160C0", Offset = "0x3D146C0", VA = "0x183D160C0")]
		public static Id32<QIASPGRRBJU> SFJMRKBILDP<da>(this IdArray<da, byte> a, Id32<da> b)
		{
			return default(Id32<QIASPGRRBJU>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x3D16030", Offset = "0x3D14630", VA = "0x183D16030")]
		public static Id32<QIASPGRRBJU> SFJMRKBILDP<db>([In] this IdSpan<db, byte> bytes, Id32<db> a)
		{
			return default(Id32<QIASPGRRBJU>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x3D15FA0", Offset = "0x3D145A0", VA = "0x183D15FA0")]
		public static Id32<QIASPGRRBJU> SFJMRKBILDP<dc>(this ReadOnlyIdArray<dc, byte> a, Id32<dc> b)
		{
			return default(Id32<QIASPGRRBJU>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x3D16240", Offset = "0x3D14840", VA = "0x183D16240")]
		public static Id32<WTQCYPTFIQA> XUBZCCXDJZB<dl>([In] this IdSpan<dl, byte> bytes, Id32<dl> a)
		{
			return default(Id32<WTQCYPTFIQA>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x3D162D0", Offset = "0x3D148D0", VA = "0x183D162D0")]
		public static Id32<WTQCYPTFIQA> XUBZCCXDJZB<dm>(this ReadOnlyIdArray<dm, byte> a, Id32<dm> b)
		{
			return default(Id32<WTQCYPTFIQA>);
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x3D15D90", Offset = "0x3D14390", VA = "0x183D15D90")]
		public static Id32<TYMAZGWXABP> QHZHJNZCXOW<dw>(this ReadOnlyIdArray<dw, byte> a, Id32<dw> b)
		{
			return default(Id32<TYMAZGWXABP>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public static class FSYDOHSVXKV
	{
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x2AF6070", Offset = "0x2AF4670", VA = "0x182AF6070")]
		public static void XVUJNDYOJKQ(this UnsafeList<byte> a, int b, Union32 c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x2AF6000", Offset = "0x2AF4600", VA = "0x182AF6000")]
		public static void XVUJNDYOJKQ(this byte[] a, int b, Union32 c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x2AF6130", Offset = "0x2AF4730", VA = "0x182AF6130")]
		public static void XVUJNDYOJKQ([In] this Span<byte> bytes, int a, Union32 b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x38CB5F0", Offset = "0x38C9BF0", VA = "0x1838CB5F0")]
		public static void XVUJNDYOJKQ<e>(this IdArray<e, byte> a, Id32<e> b, Union32 c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x38CB740", Offset = "0x38C9D40", VA = "0x1838CB740")]
		public static void XVUJNDYOJKQ<f>([In] this IdSpan<f, byte> bytes, Id32<f> a, Union32 b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x2AF5C60", Offset = "0x2AF4260", VA = "0x182AF5C60")]
		public static void GGMFNLHRAQD(this UnsafeList<byte> a, int b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x2AF5E50", Offset = "0x2AF4450", VA = "0x182AF5E50")]
		public static void GGMFNLHRAQD(this byte[] a, int b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x2AF5ED0", Offset = "0x2AF44D0", VA = "0x182AF5ED0")]
		public static void GGMFNLHRAQD([In] this Span<byte> bytes, int a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x38CB070", Offset = "0x38C9670", VA = "0x1838CB070")]
		public static void GGMFNLHRAQD<h>(this IdArray<h, byte> a, Id32<h> b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x38CB010", Offset = "0x38C9610", VA = "0x1838CB010")]
		public static void GGMFNLHRAQD<i>([In] this IdSpan<i, byte> bytes, Id32<i> a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x2AF5F50", Offset = "0x2AF4550", VA = "0x182AF5F50")]
		public static void HUJISLZRLOW(this UnsafeList<byte> a, int b, float c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x38CB1B0", Offset = "0x38C97B0", VA = "0x1838CB1B0")]
		public static void HUJISLZRLOW<k>(this IdArray<k, byte> a, Id32<k> b, float c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x38CB220", Offset = "0x38C9820", VA = "0x1838CB220")]
		public static void HUJISLZRLOW<l>([In] this IdSpan<l, byte> bytes, Id32<l> a, float b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x2AF5F90", Offset = "0x2AF4590", VA = "0x182AF5F90")]
		public static void TIEAVDRUXVM(this UnsafeList<byte> a, int b, byte c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x38CB340", Offset = "0x38C9940", VA = "0x1838CB340")]
		public static void TIEAVDRUXVM<n>(this IdArray<n, byte> a, Id32<n> b, byte c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x38CB390", Offset = "0x38C9990", VA = "0x1838CB390")]
		public static void TIEAVDRUXVM<o>([In] this IdSpan<o, byte> bytes, Id32<o> a, byte b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x38CAE30", Offset = "0x38C9430", VA = "0x1838CAE30")]
		public static void WGDDYNWFEJM<q>(this IdArray<q, byte> a, Id32<q> b, Id32<OPRBWAEKAQJ<RBQKWAEEJQD>> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x38CAEB0", Offset = "0x38C94B0", VA = "0x1838CAEB0")]
		public static void WGDDYNWFEJM<r>([In] this IdSpan<r, byte> bytes, Id32<r> a, Id32<OPRBWAEKAQJ<RBQKWAEEJQD>> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x38CAE30", Offset = "0x38C9430", VA = "0x1838CAE30")]
		public static void GCQEQBBWYFA<t>(this IdArray<t, byte> a, Id32<t> b, Id32<QIASPGRRBJU> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x38CAEB0", Offset = "0x38C94B0", VA = "0x1838CAEB0")]
		public static void GCQEQBBWYFA<u>([In] this IdSpan<u, byte> bytes, Id32<u> a, Id32<QIASPGRRBJU> b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public static class TBLYIDUHODC
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x2AF7880", Offset = "0x2AF5E80", VA = "0x182AF7880")]
		public static (Id32<OPRBWAEKAQJ<LYBQOQJENGA>>, Id32<OPRBWAEKAQJ<LOMMWLQLJQC>>, Id32<OPRBWAEKAQJ<LOMMWLQLJQC>>, Id32<OPRBWAEKAQJ<YGAASBJWVTN<LOMMWLQLJQC>>>) LBRGQLLHENY(this UnsafeList<byte> a, float b, float c, [Optional] Id32<YGAASBJWVTN<LOMMWLQLJQC>>? d)
		{
			return default((Id32<OPRBWAEKAQJ<LYBQOQJENGA>>, Id32<OPRBWAEKAQJ<LOMMWLQLJQC>>, Id32<OPRBWAEKAQJ<LOMMWLQLJQC>>, Id32<OPRBWAEKAQJ<YGAASBJWVTN<LOMMWLQLJQC>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x2AF6FA0", Offset = "0x2AF55A0", VA = "0x182AF6FA0")]
		public static (Id32<OPRBWAEKAQJ<LYBQOQJENGA>>, Id32<OPRBWAEKAQJ<LOMMWLQLJQC>>, Id32<OPRBWAEKAQJ<YGAASBJWVTN<LOMMWLQLJQC>>>, Id32<OPRBWAEKAQJ<YGAASBJWVTN<LOMMWLQLJQC>>>) EPEEXDGPAAV(this UnsafeList<byte> a, float b, [Optional] Id32<YGAASBJWVTN<LOMMWLQLJQC>>? c, [Optional] Id32<YGAASBJWVTN<LOMMWLQLJQC>>? d)
		{
			return default((Id32<OPRBWAEKAQJ<LYBQOQJENGA>>, Id32<OPRBWAEKAQJ<LOMMWLQLJQC>>, Id32<OPRBWAEKAQJ<YGAASBJWVTN<LOMMWLQLJQC>>>, Id32<OPRBWAEKAQJ<YGAASBJWVTN<LOMMWLQLJQC>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x2AFB8C0", Offset = "0x2AF9EC0", VA = "0x182AFB8C0")]
		public static (Id32<OPRBWAEKAQJ<LYBQOQJENGA>>, Id32<OPRBWAEKAQJ<YGAASBJWVTN<LOMMWLQLJQC>>>, Id32<OPRBWAEKAQJ<YGAASBJWVTN<LOMMWLQLJQC>>>, Id32<OPRBWAEKAQJ<YGAASBJWVTN<LOMMWLQLJQC>>>) ZDTLDZIISYI(this UnsafeList<byte> a, [Optional] Id32<YGAASBJWVTN<LOMMWLQLJQC>>? b, [Optional] Id32<YGAASBJWVTN<LOMMWLQLJQC>>? c, [Optional] Id32<YGAASBJWVTN<LOMMWLQLJQC>>? d)
		{
			return default((Id32<OPRBWAEKAQJ<LYBQOQJENGA>>, Id32<OPRBWAEKAQJ<YGAASBJWVTN<LOMMWLQLJQC>>>, Id32<OPRBWAEKAQJ<YGAASBJWVTN<LOMMWLQLJQC>>>, Id32<OPRBWAEKAQJ<YGAASBJWVTN<LOMMWLQLJQC>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x2AF6AA0", Offset = "0x2AF50A0", VA = "0x182AF6AA0")]
		public static (Id32<OPRBWAEKAQJ<LYBQOQJENGA>>, Id32<OPRBWAEKAQJ<EHBKKFTSHQH>>, Id32<OPRBWAEKAQJ<EHBKKFTSHQH>>, Id32<OPRBWAEKAQJ<YGAASBJWVTN<EHBKKFTSHQH>>>) CWBDKYTZMSE(this UnsafeList<byte> a, int b, int c, [Optional] Id32<YGAASBJWVTN<EHBKKFTSHQH>>? d)
		{
			return default((Id32<OPRBWAEKAQJ<LYBQOQJENGA>>, Id32<OPRBWAEKAQJ<EHBKKFTSHQH>>, Id32<OPRBWAEKAQJ<EHBKKFTSHQH>>, Id32<OPRBWAEKAQJ<YGAASBJWVTN<EHBKKFTSHQH>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x2AF6630", Offset = "0x2AF4C30", VA = "0x182AF6630")]
		public static (Id32<OPRBWAEKAQJ<LYBQOQJENGA>>, Id32<OPRBWAEKAQJ<EHBKKFTSHQH>>, Id32<OPRBWAEKAQJ<YGAASBJWVTN<EHBKKFTSHQH>>>, Id32<OPRBWAEKAQJ<YGAASBJWVTN<EHBKKFTSHQH>>>) BFYUNTSZEEP(this UnsafeList<byte> a, int b, [Optional] Id32<YGAASBJWVTN<EHBKKFTSHQH>>? c, [Optional] Id32<YGAASBJWVTN<EHBKKFTSHQH>>? d)
		{
			return default((Id32<OPRBWAEKAQJ<LYBQOQJENGA>>, Id32<OPRBWAEKAQJ<EHBKKFTSHQH>>, Id32<OPRBWAEKAQJ<YGAASBJWVTN<EHBKKFTSHQH>>>, Id32<OPRBWAEKAQJ<YGAASBJWVTN<EHBKKFTSHQH>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x2AF7600", Offset = "0x2AF5C00", VA = "0x182AF7600")]
		public static (Id32<OPRBWAEKAQJ<LYBQOQJENGA>>, Id32<OPRBWAEKAQJ<YGAASBJWVTN<EHBKKFTSHQH>>>, Id32<OPRBWAEKAQJ<YGAASBJWVTN<EHBKKFTSHQH>>>, Id32<OPRBWAEKAQJ<YGAASBJWVTN<EHBKKFTSHQH>>>) IHKSYXRHVIW(this UnsafeList<byte> a, [Optional] Id32<YGAASBJWVTN<EHBKKFTSHQH>>? b, [Optional] Id32<YGAASBJWVTN<EHBKKFTSHQH>>? c, [Optional] Id32<YGAASBJWVTN<EHBKKFTSHQH>>? d)
		{
			return default((Id32<OPRBWAEKAQJ<LYBQOQJENGA>>, Id32<OPRBWAEKAQJ<YGAASBJWVTN<EHBKKFTSHQH>>>, Id32<OPRBWAEKAQJ<YGAASBJWVTN<EHBKKFTSHQH>>>, Id32<OPRBWAEKAQJ<YGAASBJWVTN<EHBKKFTSHQH>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x2AF9380", Offset = "0x2AF7980", VA = "0x182AF9380")]
		public static (Id32<OPRBWAEKAQJ<LYBQOQJENGA>>, Id32<OPRBWAEKAQJ<EHBKKFTSHQH>>, Id32<OPRBWAEKAQJ<EHBKKFTSHQH>>, Id32<OPRBWAEKAQJ<YGAASBJWVTN<EHBKKFTSHQH>>>) PYRCCCMKCSS(this UnsafeList<byte> a, int b, int c, [Optional] Id32<YGAASBJWVTN<EHBKKFTSHQH>>? d)
		{
			return default((Id32<OPRBWAEKAQJ<LYBQOQJENGA>>, Id32<OPRBWAEKAQJ<EHBKKFTSHQH>>, Id32<OPRBWAEKAQJ<EHBKKFTSHQH>>, Id32<OPRBWAEKAQJ<YGAASBJWVTN<EHBKKFTSHQH>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x2AF7F20", Offset = "0x2AF6520", VA = "0x182AF7F20")]
		public static (Id32<OPRBWAEKAQJ<LYBQOQJENGA>>, Id32<OPRBWAEKAQJ<EHBKKFTSHQH>>, Id32<OPRBWAEKAQJ<YGAASBJWVTN<EHBKKFTSHQH>>>, Id32<OPRBWAEKAQJ<YGAASBJWVTN<EHBKKFTSHQH>>>) MBSDGRJEBZL(this UnsafeList<byte> a, int b, [Optional] Id32<YGAASBJWVTN<EHBKKFTSHQH>>? c, [Optional] Id32<YGAASBJWVTN<EHBKKFTSHQH>>? d)
		{
			return default((Id32<OPRBWAEKAQJ<LYBQOQJENGA>>, Id32<OPRBWAEKAQJ<EHBKKFTSHQH>>, Id32<OPRBWAEKAQJ<YGAASBJWVTN<EHBKKFTSHQH>>>, Id32<OPRBWAEKAQJ<YGAASBJWVTN<EHBKKFTSHQH>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x2AF9C90", Offset = "0x2AF8290", VA = "0x182AF9C90")]
		public static (Id32<OPRBWAEKAQJ<LYBQOQJENGA>>, Id32<OPRBWAEKAQJ<YGAASBJWVTN<EHBKKFTSHQH>>>, Id32<OPRBWAEKAQJ<YGAASBJWVTN<EHBKKFTSHQH>>>, Id32<OPRBWAEKAQJ<YGAASBJWVTN<EHBKKFTSHQH>>>) UHRDYKARNOY(this UnsafeList<byte> a, [Optional] Id32<YGAASBJWVTN<EHBKKFTSHQH>>? b, [Optional] Id32<YGAASBJWVTN<EHBKKFTSHQH>>? c, [Optional] Id32<YGAASBJWVTN<EHBKKFTSHQH>>? d)
		{
			return default((Id32<OPRBWAEKAQJ<LYBQOQJENGA>>, Id32<OPRBWAEKAQJ<YGAASBJWVTN<EHBKKFTSHQH>>>, Id32<OPRBWAEKAQJ<YGAASBJWVTN<EHBKKFTSHQH>>>, Id32<OPRBWAEKAQJ<YGAASBJWVTN<EHBKKFTSHQH>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x2AF8440", Offset = "0x2AF6A40", VA = "0x182AF8440")]
		public static (Id32<OPRBWAEKAQJ<LYBQOQJENGA>>, Id32<OPRBWAEKAQJ<EHBKKFTSHQH>>, Id32<OPRBWAEKAQJ<OPRBWAEKAQJ<LYBQOQJENGA>>>) MWIRDSTKREA(this UnsafeList<byte> a, [Optional] int? b, [Optional] Id32<OPRBWAEKAQJ<LYBQOQJENGA>>? c)
		{
			return default((Id32<OPRBWAEKAQJ<LYBQOQJENGA>>, Id32<OPRBWAEKAQJ<EHBKKFTSHQH>>, Id32<OPRBWAEKAQJ<OPRBWAEKAQJ<LYBQOQJENGA>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x2AF6800", Offset = "0x2AF4E00", VA = "0x182AF6800")]
		public static (Id32<OPRBWAEKAQJ<LYBQOQJENGA>>, Id32<OPRBWAEKAQJ<YGAASBJWVTN<EHBKKFTSHQH>>>, Id32<OPRBWAEKAQJ<OPRBWAEKAQJ<LYBQOQJENGA>>>) BPXGHHYFPOX(this UnsafeList<byte> a, [Optional] Id32<YGAASBJWVTN<EHBKKFTSHQH>>? b, [Optional] Id32<OPRBWAEKAQJ<LYBQOQJENGA>>? c)
		{
			return default((Id32<OPRBWAEKAQJ<LYBQOQJENGA>>, Id32<OPRBWAEKAQJ<YGAASBJWVTN<EHBKKFTSHQH>>>, Id32<OPRBWAEKAQJ<OPRBWAEKAQJ<LYBQOQJENGA>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x2AF8950", Offset = "0x2AF6F50", VA = "0x182AF8950")]
		public static (Id32<OPRBWAEKAQJ<LYBQOQJENGA>>, Id32<OPRBWAEKAQJ<EHBKKFTSHQH>>, Id32<OPRBWAEKAQJ<OPRBWAEKAQJ<LYBQOQJENGA>>>) ONCPPBMEWDX(this UnsafeList<byte> a, [Optional] int? b, [Optional] Id32<OPRBWAEKAQJ<LYBQOQJENGA>>? c)
		{
			return default((Id32<OPRBWAEKAQJ<LYBQOQJENGA>>, Id32<OPRBWAEKAQJ<EHBKKFTSHQH>>, Id32<OPRBWAEKAQJ<OPRBWAEKAQJ<LYBQOQJENGA>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x2AF74E0", Offset = "0x2AF5AE0", VA = "0x182AF74E0")]
		public static (Id32<OPRBWAEKAQJ<LYBQOQJENGA>>, Id32<OPRBWAEKAQJ<YGAASBJWVTN<EHBKKFTSHQH>>>, Id32<OPRBWAEKAQJ<OPRBWAEKAQJ<LYBQOQJENGA>>>) IDDISUTXVFI(this UnsafeList<byte> a, [Optional] Id32<YGAASBJWVTN<EHBKKFTSHQH>>? b, [Optional] Id32<OPRBWAEKAQJ<LYBQOQJENGA>>? c)
		{
			return default((Id32<OPRBWAEKAQJ<LYBQOQJENGA>>, Id32<OPRBWAEKAQJ<YGAASBJWVTN<EHBKKFTSHQH>>>, Id32<OPRBWAEKAQJ<OPRBWAEKAQJ<LYBQOQJENGA>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x2AF8E00", Offset = "0x2AF7400", VA = "0x182AF8E00")]
		public static (Id32<OPRBWAEKAQJ<LYBQOQJENGA>>, Id32<OPRBWAEKAQJ<EHBKKFTSHQH>>, Id32<OPRBWAEKAQJ<WTQCYPTFIQA>>) PCWPAOJBYET(this UnsafeList<byte> a, [Optional] int? b, [Optional] Id32<WTQCYPTFIQA>? c)
		{
			return default((Id32<OPRBWAEKAQJ<LYBQOQJENGA>>, Id32<OPRBWAEKAQJ<EHBKKFTSHQH>>, Id32<OPRBWAEKAQJ<WTQCYPTFIQA>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x2AF9270", Offset = "0x2AF7870", VA = "0x182AF9270")]
		public static (Id32<OPRBWAEKAQJ<LYBQOQJENGA>>, Id32<OPRBWAEKAQJ<EHBKKFTSHQH>>, Id32<OPRBWAEKAQJ<YGAASBJWVTN<WTQCYPTFIQA>>>) PHYFKBMOACK(this UnsafeList<byte> a, [Optional] int? b, [Optional] Id32<YGAASBJWVTN<WTQCYPTFIQA>>? c)
		{
			return default((Id32<OPRBWAEKAQJ<LYBQOQJENGA>>, Id32<OPRBWAEKAQJ<EHBKKFTSHQH>>, Id32<OPRBWAEKAQJ<YGAASBJWVTN<WTQCYPTFIQA>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x2AF8FB0", Offset = "0x2AF75B0", VA = "0x182AF8FB0")]
		public static (Id32<OPRBWAEKAQJ<LYBQOQJENGA>>, Id32<OPRBWAEKAQJ<EHBKKFTSHQH>>, Id32<OPRBWAEKAQJ<QIASPGRRBJU>>) PDDORKUGZHT(this UnsafeList<byte> a, [Optional] int? b, [Optional] Id32<QIASPGRRBJU>? c)
		{
			return default((Id32<OPRBWAEKAQJ<LYBQOQJENGA>>, Id32<OPRBWAEKAQJ<EHBKKFTSHQH>>, Id32<OPRBWAEKAQJ<QIASPGRRBJU>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x2AF9160", Offset = "0x2AF7760", VA = "0x182AF9160")]
		public static (Id32<OPRBWAEKAQJ<LYBQOQJENGA>>, Id32<OPRBWAEKAQJ<EHBKKFTSHQH>>, Id32<OPRBWAEKAQJ<YGAASBJWVTN<QIASPGRRBJU>>>) PEDXDSPTUMM(this UnsafeList<byte> a, [Optional] int? b, [Optional] Id32<YGAASBJWVTN<QIASPGRRBJU>>? c)
		{
			return default((Id32<OPRBWAEKAQJ<LYBQOQJENGA>>, Id32<OPRBWAEKAQJ<EHBKKFTSHQH>>, Id32<OPRBWAEKAQJ<YGAASBJWVTN<QIASPGRRBJU>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x3D5D7E0", Offset = "0x3D5BDE0", VA = "0x183D5D7E0")]
		public static (Id32<OPRBWAEKAQJ<LYBQOQJENGA>>, Id32<OPRBWAEKAQJ<TYMAZGWXABP>>, Id32<OPRBWAEKAQJ<EHBKKFTSHQH>>, Id32<OPRBWAEKAQJ<a>>) HRFNOTZTLPU<a>(this UnsafeList<byte> a, [Optional] Id32<TYMAZGWXABP>? b, [Optional][In] ReadOnlySpan<byte> data)
		{
			return default((Id32<OPRBWAEKAQJ<LYBQOQJENGA>>, Id32<OPRBWAEKAQJ<TYMAZGWXABP>>, Id32<OPRBWAEKAQJ<EHBKKFTSHQH>>, Id32<OPRBWAEKAQJ<a>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x2AF8A60", Offset = "0x2AF7060", VA = "0x182AF8A60")]
		public static (Id32<OPRBWAEKAQJ<LYBQOQJENGA>>, Id32<OPRBWAEKAQJ<EHBKKFTSHQH>>, Id32<OPRBWAEKAQJ<YGAASBJWVTN<EHBKKFTSHQH>>>) OWNMQOSQZCQ(this UnsafeList<byte> a, int b, [Optional] Id32<YGAASBJWVTN<EHBKKFTSHQH>>? c)
		{
			return default((Id32<OPRBWAEKAQJ<LYBQOQJENGA>>, Id32<OPRBWAEKAQJ<EHBKKFTSHQH>>, Id32<OPRBWAEKAQJ<YGAASBJWVTN<EHBKKFTSHQH>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x2AF9640", Offset = "0x2AF7C40", VA = "0x182AF9640")]
		public static (Id32<OPRBWAEKAQJ<LYBQOQJENGA>>, Id32<OPRBWAEKAQJ<YGAASBJWVTN<EHBKKFTSHQH>>>, Id32<OPRBWAEKAQJ<YGAASBJWVTN<EHBKKFTSHQH>>>) RVGFEUFZTRJ(this UnsafeList<byte> a, [Optional] Id32<YGAASBJWVTN<EHBKKFTSHQH>>? b, [Optional] Id32<YGAASBJWVTN<EHBKKFTSHQH>>? c)
		{
			return default((Id32<OPRBWAEKAQJ<LYBQOQJENGA>>, Id32<OPRBWAEKAQJ<YGAASBJWVTN<EHBKKFTSHQH>>>, Id32<OPRBWAEKAQJ<YGAASBJWVTN<EHBKKFTSHQH>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x3D5DBE0", Offset = "0x3D5C1E0", VA = "0x183D5DBE0")]
		public static (Id32<OPRBWAEKAQJ<LYBQOQJENGA>>, Id32<OPRBWAEKAQJ<YGAASBJWVTN<b>>>, Id32<OPRBWAEKAQJ<EHBKKFTSHQH>>, Id32<OPRBWAEKAQJ<b>>) IARQCMPHOTO<b>(this UnsafeList<byte> a, [Optional] Id32<YGAASBJWVTN<b>>? b, [Optional] int? c, [Optional][In] ReadOnlySpan<byte> from)
		{
			return default((Id32<OPRBWAEKAQJ<LYBQOQJENGA>>, Id32<OPRBWAEKAQJ<YGAASBJWVTN<b>>>, Id32<OPRBWAEKAQJ<EHBKKFTSHQH>>, Id32<OPRBWAEKAQJ<b>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x3D5D490", Offset = "0x3D5BA90", VA = "0x183D5D490")]
		public static (Id32<OPRBWAEKAQJ<LYBQOQJENGA>>, Id32<OPRBWAEKAQJ<YGAASBJWVTN<c>>>, Id32<OPRBWAEKAQJ<YGAASBJWVTN<c>>>, Id32<OPRBWAEKAQJ<EHBKKFTSHQH>>) DETFOBPIBVJ<c>(this UnsafeList<byte> a, [Optional] Id32<YGAASBJWVTN<c>>? b, [Optional] Id32<YGAASBJWVTN<c>>? c, [Optional] int? d)
		{
			return default((Id32<OPRBWAEKAQJ<LYBQOQJENGA>>, Id32<OPRBWAEKAQJ<YGAASBJWVTN<c>>>, Id32<OPRBWAEKAQJ<YGAASBJWVTN<c>>>, Id32<OPRBWAEKAQJ<EHBKKFTSHQH>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x2AF7DA0", Offset = "0x2AF63A0", VA = "0x182AF7DA0")]
		public static (Id32<OPRBWAEKAQJ<LYBQOQJENGA>>, Id32<OPRBWAEKAQJ<LOMMWLQLJQC>>, Id32<OPRBWAEKAQJ<LOMMWLQLJQC>>, Id32<OPRBWAEKAQJ<YGAASBJWVTN<LOMMWLQLJQC>>>) MACYDSDTLUM(this UnsafeList<byte> a, float b, float c, [Optional] Id32<YGAASBJWVTN<LOMMWLQLJQC>>? d)
		{
			return default((Id32<OPRBWAEKAQJ<LYBQOQJENGA>>, Id32<OPRBWAEKAQJ<LOMMWLQLJQC>>, Id32<OPRBWAEKAQJ<LOMMWLQLJQC>>, Id32<OPRBWAEKAQJ<YGAASBJWVTN<LOMMWLQLJQC>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x2AFAEC0", Offset = "0x2AF94C0", VA = "0x182AFAEC0")]
		public static (Id32<OPRBWAEKAQJ<LYBQOQJENGA>>, Id32<OPRBWAEKAQJ<LOMMWLQLJQC>>, Id32<OPRBWAEKAQJ<YGAASBJWVTN<LOMMWLQLJQC>>>, Id32<OPRBWAEKAQJ<YGAASBJWVTN<LOMMWLQLJQC>>>) XENBMSOFMTR(this UnsafeList<byte> a, float b, [Optional] Id32<YGAASBJWVTN<LOMMWLQLJQC>>? c, [Optional] Id32<YGAASBJWVTN<LOMMWLQLJQC>>? d)
		{
			return default((Id32<OPRBWAEKAQJ<LYBQOQJENGA>>, Id32<OPRBWAEKAQJ<LOMMWLQLJQC>>, Id32<OPRBWAEKAQJ<YGAASBJWVTN<LOMMWLQLJQC>>>, Id32<OPRBWAEKAQJ<YGAASBJWVTN<LOMMWLQLJQC>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x2AF8320", Offset = "0x2AF6920", VA = "0x182AF8320")]
		public static (Id32<OPRBWAEKAQJ<LYBQOQJENGA>>, Id32<OPRBWAEKAQJ<YGAASBJWVTN<LOMMWLQLJQC>>>, Id32<OPRBWAEKAQJ<YGAASBJWVTN<LOMMWLQLJQC>>>, Id32<OPRBWAEKAQJ<YGAASBJWVTN<LOMMWLQLJQC>>>) MSCKFGKFWBE(this UnsafeList<byte> a, [Optional] Id32<YGAASBJWVTN<LOMMWLQLJQC>>? b, [Optional] Id32<YGAASBJWVTN<LOMMWLQLJQC>>? c, [Optional] Id32<YGAASBJWVTN<LOMMWLQLJQC>>? d)
		{
			return default((Id32<OPRBWAEKAQJ<LYBQOQJENGA>>, Id32<OPRBWAEKAQJ<YGAASBJWVTN<LOMMWLQLJQC>>>, Id32<OPRBWAEKAQJ<YGAASBJWVTN<LOMMWLQLJQC>>>, Id32<OPRBWAEKAQJ<YGAASBJWVTN<LOMMWLQLJQC>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x2AF7720", Offset = "0x2AF5D20", VA = "0x182AF7720")]
		public static (Id32<OPRBWAEKAQJ<LYBQOQJENGA>>, Id32<OPRBWAEKAQJ<EHBKKFTSHQH>>, Id32<OPRBWAEKAQJ<EHBKKFTSHQH>>, Id32<OPRBWAEKAQJ<YGAASBJWVTN<EHBKKFTSHQH>>>) IVMCKCUBOHI(this UnsafeList<byte> a, int b, int c, [Optional] Id32<YGAASBJWVTN<EHBKKFTSHQH>>? d)
		{
			return default((Id32<OPRBWAEKAQJ<LYBQOQJENGA>>, Id32<OPRBWAEKAQJ<EHBKKFTSHQH>>, Id32<OPRBWAEKAQJ<EHBKKFTSHQH>>, Id32<OPRBWAEKAQJ<YGAASBJWVTN<EHBKKFTSHQH>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x2AF6C00", Offset = "0x2AF5200", VA = "0x182AF6C00")]
		public static (Id32<OPRBWAEKAQJ<LYBQOQJENGA>>, Id32<OPRBWAEKAQJ<EHBKKFTSHQH>>, Id32<OPRBWAEKAQJ<YGAASBJWVTN<EHBKKFTSHQH>>>, Id32<OPRBWAEKAQJ<YGAASBJWVTN<EHBKKFTSHQH>>>) DFCDLAIBDND(this UnsafeList<byte> a, int b, [Optional] Id32<YGAASBJWVTN<EHBKKFTSHQH>>? c, [Optional] Id32<YGAASBJWVTN<EHBKKFTSHQH>>? d)
		{
			return default((Id32<OPRBWAEKAQJ<LYBQOQJENGA>>, Id32<OPRBWAEKAQJ<EHBKKFTSHQH>>, Id32<OPRBWAEKAQJ<YGAASBJWVTN<EHBKKFTSHQH>>>, Id32<OPRBWAEKAQJ<YGAASBJWVTN<EHBKKFTSHQH>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x2AFB7A0", Offset = "0x2AF9DA0", VA = "0x182AFB7A0")]
		public static (Id32<OPRBWAEKAQJ<LYBQOQJENGA>>, Id32<OPRBWAEKAQJ<YGAASBJWVTN<EHBKKFTSHQH>>>, Id32<OPRBWAEKAQJ<YGAASBJWVTN<EHBKKFTSHQH>>>, Id32<OPRBWAEKAQJ<YGAASBJWVTN<EHBKKFTSHQH>>>) ZABYCKERWZW(this UnsafeList<byte> a, [Optional] Id32<YGAASBJWVTN<EHBKKFTSHQH>>? b, [Optional] Id32<YGAASBJWVTN<EHBKKFTSHQH>>? c, [Optional] Id32<YGAASBJWVTN<EHBKKFTSHQH>>? d)
		{
			return default((Id32<OPRBWAEKAQJ<LYBQOQJENGA>>, Id32<OPRBWAEKAQJ<YGAASBJWVTN<EHBKKFTSHQH>>>, Id32<OPRBWAEKAQJ<YGAASBJWVTN<EHBKKFTSHQH>>>, Id32<OPRBWAEKAQJ<YGAASBJWVTN<EHBKKFTSHQH>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x2AFA880", Offset = "0x2AF8E80", VA = "0x182AFA880")]
		public static (Id32<OPRBWAEKAQJ<LYBQOQJENGA>>, Id32<OPRBWAEKAQJ<EHBKKFTSHQH>>, Id32<OPRBWAEKAQJ<EHBKKFTSHQH>>, Id32<OPRBWAEKAQJ<YGAASBJWVTN<EHBKKFTSHQH>>>) WJEZKKHLXLV(this UnsafeList<byte> a, int b, int c, [Optional] Id32<YGAASBJWVTN<EHBKKFTSHQH>>? d)
		{
			return default((Id32<OPRBWAEKAQJ<LYBQOQJENGA>>, Id32<OPRBWAEKAQJ<EHBKKFTSHQH>>, Id32<OPRBWAEKAQJ<EHBKKFTSHQH>>, Id32<OPRBWAEKAQJ<YGAASBJWVTN<EHBKKFTSHQH>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x2AF9ED0", Offset = "0x2AF84D0", VA = "0x182AF9ED0")]
		public static (Id32<OPRBWAEKAQJ<LYBQOQJENGA>>, Id32<OPRBWAEKAQJ<EHBKKFTSHQH>>, Id32<OPRBWAEKAQJ<YGAASBJWVTN<EHBKKFTSHQH>>>, Id32<OPRBWAEKAQJ<YGAASBJWVTN<EHBKKFTSHQH>>>) UPTUKAMWJRK(this UnsafeList<byte> a, int b, [Optional] Id32<YGAASBJWVTN<EHBKKFTSHQH>>? c, [Optional] Id32<YGAASBJWVTN<EHBKKFTSHQH>>? d)
		{
			return default((Id32<OPRBWAEKAQJ<LYBQOQJENGA>>, Id32<OPRBWAEKAQJ<EHBKKFTSHQH>>, Id32<OPRBWAEKAQJ<YGAASBJWVTN<EHBKKFTSHQH>>>, Id32<OPRBWAEKAQJ<YGAASBJWVTN<EHBKKFTSHQH>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x2AF8B90", Offset = "0x2AF7190", VA = "0x182AF8B90")]
		public static (Id32<OPRBWAEKAQJ<LYBQOQJENGA>>, Id32<OPRBWAEKAQJ<YGAASBJWVTN<EHBKKFTSHQH>>>, Id32<OPRBWAEKAQJ<YGAASBJWVTN<EHBKKFTSHQH>>>, Id32<OPRBWAEKAQJ<YGAASBJWVTN<EHBKKFTSHQH>>>) OXFFZSTVHSJ(this UnsafeList<byte> a, [Optional] Id32<YGAASBJWVTN<EHBKKFTSHQH>>? b, [Optional] Id32<YGAASBJWVTN<EHBKKFTSHQH>>? c, [Optional] Id32<YGAASBJWVTN<EHBKKFTSHQH>>? d)
		{
			return default((Id32<OPRBWAEKAQJ<LYBQOQJENGA>>, Id32<OPRBWAEKAQJ<YGAASBJWVTN<EHBKKFTSHQH>>>, Id32<OPRBWAEKAQJ<YGAASBJWVTN<EHBKKFTSHQH>>>, Id32<OPRBWAEKAQJ<YGAASBJWVTN<EHBKKFTSHQH>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x2AFB560", Offset = "0x2AF9B60", VA = "0x182AFB560")]
		public static (Id32<OPRBWAEKAQJ<LYBQOQJENGA>>, Id32<OPRBWAEKAQJ<OPRBWAEKAQJ<LYBQOQJENGA>>>) YKHAQBJMGJW(this UnsafeList<byte> a, [Optional] Id32<OPRBWAEKAQJ<LYBQOQJENGA>>? b)
		{
			return default((Id32<OPRBWAEKAQJ<LYBQOQJENGA>>, Id32<OPRBWAEKAQJ<OPRBWAEKAQJ<LYBQOQJENGA>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x2AFA440", Offset = "0x2AF8A40", VA = "0x182AFA440")]
		public static (Id32<OPRBWAEKAQJ<LYBQOQJENGA>>, Id32<OPRBWAEKAQJ<LOMMWLQLJQC>>, Id32<OPRBWAEKAQJ<LOMMWLQLJQC>>, Id32<OPRBWAEKAQJ<YGAASBJWVTN<EHBKKFTSHQH>>>) VJCLOGWNLYM(this UnsafeList<byte> a, float b, float c, [Optional] Id32<YGAASBJWVTN<EHBKKFTSHQH>>? d)
		{
			return default((Id32<OPRBWAEKAQJ<LYBQOQJENGA>>, Id32<OPRBWAEKAQJ<LOMMWLQLJQC>>, Id32<OPRBWAEKAQJ<LOMMWLQLJQC>>, Id32<OPRBWAEKAQJ<YGAASBJWVTN<EHBKKFTSHQH>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x2AFA9E0", Offset = "0x2AF8FE0", VA = "0x182AFA9E0")]
		public static (Id32<OPRBWAEKAQJ<LYBQOQJENGA>>, Id32<OPRBWAEKAQJ<LOMMWLQLJQC>>, Id32<OPRBWAEKAQJ<YGAASBJWVTN<LOMMWLQLJQC>>>, Id32<OPRBWAEKAQJ<YGAASBJWVTN<EHBKKFTSHQH>>>) WKPDHSEYDBZ(this UnsafeList<byte> a, float b, [Optional] Id32<YGAASBJWVTN<LOMMWLQLJQC>>? c, [Optional] Id32<YGAASBJWVTN<EHBKKFTSHQH>>? d)
		{
			return default((Id32<OPRBWAEKAQJ<LYBQOQJENGA>>, Id32<OPRBWAEKAQJ<LOMMWLQLJQC>>, Id32<OPRBWAEKAQJ<YGAASBJWVTN<LOMMWLQLJQC>>>, Id32<OPRBWAEKAQJ<YGAASBJWVTN<EHBKKFTSHQH>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x2AF6E70", Offset = "0x2AF5470", VA = "0x182AF6E70")]
		public static (Id32<OPRBWAEKAQJ<LYBQOQJENGA>>, Id32<OPRBWAEKAQJ<YGAASBJWVTN<LOMMWLQLJQC>>>, Id32<OPRBWAEKAQJ<YGAASBJWVTN<LOMMWLQLJQC>>>, Id32<OPRBWAEKAQJ<YGAASBJWVTN<EHBKKFTSHQH>>>) ECWEXLGGFHY(this UnsafeList<byte> a, [Optional] Id32<YGAASBJWVTN<LOMMWLQLJQC>>? b, [Optional] Id32<YGAASBJWVTN<LOMMWLQLJQC>>? c, [Optional] Id32<YGAASBJWVTN<EHBKKFTSHQH>>? d)
		{
			return default((Id32<OPRBWAEKAQJ<LYBQOQJENGA>>, Id32<OPRBWAEKAQJ<YGAASBJWVTN<LOMMWLQLJQC>>>, Id32<OPRBWAEKAQJ<YGAASBJWVTN<LOMMWLQLJQC>>>, Id32<OPRBWAEKAQJ<YGAASBJWVTN<EHBKKFTSHQH>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x2AF7A00", Offset = "0x2AF6000", VA = "0x182AF7A00")]
		public static (Id32<OPRBWAEKAQJ<LYBQOQJENGA>>, Id32<OPRBWAEKAQJ<EHBKKFTSHQH>>, Id32<OPRBWAEKAQJ<EHBKKFTSHQH>>, Id32<OPRBWAEKAQJ<YGAASBJWVTN<EHBKKFTSHQH>>>) LEVEVPAIQSJ(this UnsafeList<byte> a, int b, int c, [Optional] Id32<YGAASBJWVTN<EHBKKFTSHQH>>? d)
		{
			return default((Id32<OPRBWAEKAQJ<LYBQOQJENGA>>, Id32<OPRBWAEKAQJ<EHBKKFTSHQH>>, Id32<OPRBWAEKAQJ<EHBKKFTSHQH>>, Id32<OPRBWAEKAQJ<YGAASBJWVTN<EHBKKFTSHQH>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x2AFB650", Offset = "0x2AF9C50", VA = "0x182AFB650")]
		public static (Id32<OPRBWAEKAQJ<LYBQOQJENGA>>, Id32<OPRBWAEKAQJ<EHBKKFTSHQH>>, Id32<OPRBWAEKAQJ<YGAASBJWVTN<EHBKKFTSHQH>>>, Id32<OPRBWAEKAQJ<YGAASBJWVTN<EHBKKFTSHQH>>>) YRKXGIOVAJQ(this UnsafeList<byte> a, int b, [Optional] Id32<YGAASBJWVTN<EHBKKFTSHQH>>? c, [Optional] Id32<YGAASBJWVTN<EHBKKFTSHQH>>? d)
		{
			return default((Id32<OPRBWAEKAQJ<LYBQOQJENGA>>, Id32<OPRBWAEKAQJ<EHBKKFTSHQH>>, Id32<OPRBWAEKAQJ<YGAASBJWVTN<EHBKKFTSHQH>>>, Id32<OPRBWAEKAQJ<YGAASBJWVTN<EHBKKFTSHQH>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x2AF7C80", Offset = "0x2AF6280", VA = "0x182AF7C80")]
		public static (Id32<OPRBWAEKAQJ<LYBQOQJENGA>>, Id32<OPRBWAEKAQJ<YGAASBJWVTN<EHBKKFTSHQH>>>, Id32<OPRBWAEKAQJ<YGAASBJWVTN<EHBKKFTSHQH>>>, Id32<OPRBWAEKAQJ<YGAASBJWVTN<EHBKKFTSHQH>>>) LZXQPPRDZHN(this UnsafeList<byte> a, [Optional] Id32<YGAASBJWVTN<EHBKKFTSHQH>>? b, [Optional] Id32<YGAASBJWVTN<EHBKKFTSHQH>>? c, [Optional] Id32<YGAASBJWVTN<EHBKKFTSHQH>>? d)
		{
			return default((Id32<OPRBWAEKAQJ<LYBQOQJENGA>>, Id32<OPRBWAEKAQJ<YGAASBJWVTN<EHBKKFTSHQH>>>, Id32<OPRBWAEKAQJ<YGAASBJWVTN<EHBKKFTSHQH>>>, Id32<OPRBWAEKAQJ<YGAASBJWVTN<EHBKKFTSHQH>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x2AFB290", Offset = "0x2AF9890", VA = "0x182AFB290")]
		public static (Id32<OPRBWAEKAQJ<LYBQOQJENGA>>, Id32<OPRBWAEKAQJ<LOMMWLQLJQC>>, Id32<OPRBWAEKAQJ<LOMMWLQLJQC>>, Id32<OPRBWAEKAQJ<YGAASBJWVTN<EHBKKFTSHQH>>>) YJHEVDKLEOT(this UnsafeList<byte> a, float b, float c, [Optional] Id32<YGAASBJWVTN<EHBKKFTSHQH>>? d)
		{
			return default((Id32<OPRBWAEKAQJ<LYBQOQJENGA>>, Id32<OPRBWAEKAQJ<LOMMWLQLJQC>>, Id32<OPRBWAEKAQJ<LOMMWLQLJQC>>, Id32<OPRBWAEKAQJ<YGAASBJWVTN<EHBKKFTSHQH>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x2AF81C0", Offset = "0x2AF67C0", VA = "0x182AF81C0")]
		public static (Id32<OPRBWAEKAQJ<LYBQOQJENGA>>, Id32<OPRBWAEKAQJ<LOMMWLQLJQC>>, Id32<OPRBWAEKAQJ<YGAASBJWVTN<LOMMWLQLJQC>>>, Id32<OPRBWAEKAQJ<YGAASBJWVTN<EHBKKFTSHQH>>>) MOYQYKCEVZK(this UnsafeList<byte> a, float b, [Optional] Id32<YGAASBJWVTN<LOMMWLQLJQC>>? c, [Optional] Id32<YGAASBJWVTN<EHBKKFTSHQH>>? d)
		{
			return default((Id32<OPRBWAEKAQJ<LYBQOQJENGA>>, Id32<OPRBWAEKAQJ<LOMMWLQLJQC>>, Id32<OPRBWAEKAQJ<YGAASBJWVTN<LOMMWLQLJQC>>>, Id32<OPRBWAEKAQJ<YGAASBJWVTN<EHBKKFTSHQH>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x2AFB9E0", Offset = "0x2AF9FE0", VA = "0x182AFB9E0")]
		public static (Id32<OPRBWAEKAQJ<LYBQOQJENGA>>, Id32<OPRBWAEKAQJ<YGAASBJWVTN<LOMMWLQLJQC>>>, Id32<OPRBWAEKAQJ<YGAASBJWVTN<LOMMWLQLJQC>>>, Id32<OPRBWAEKAQJ<YGAASBJWVTN<EHBKKFTSHQH>>>) ZFFCVSLQTIV(this UnsafeList<byte> a, [Optional] Id32<YGAASBJWVTN<LOMMWLQLJQC>>? b, [Optional] Id32<YGAASBJWVTN<LOMMWLQLJQC>>? c, [Optional] Id32<YGAASBJWVTN<EHBKKFTSHQH>>? d)
		{
			return default((Id32<OPRBWAEKAQJ<LYBQOQJENGA>>, Id32<OPRBWAEKAQJ<YGAASBJWVTN<LOMMWLQLJQC>>>, Id32<OPRBWAEKAQJ<YGAASBJWVTN<LOMMWLQLJQC>>>, Id32<OPRBWAEKAQJ<YGAASBJWVTN<EHBKKFTSHQH>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x2AF9750", Offset = "0x2AF7D50", VA = "0x182AF9750")]
		public static (Id32<OPRBWAEKAQJ<LYBQOQJENGA>>, Id32<OPRBWAEKAQJ<EHBKKFTSHQH>>, Id32<OPRBWAEKAQJ<EHBKKFTSHQH>>, Id32<OPRBWAEKAQJ<YGAASBJWVTN<EHBKKFTSHQH>>>) SJVUDHPNWRM(this UnsafeList<byte> a, int b, int c, [Optional] Id32<YGAASBJWVTN<EHBKKFTSHQH>>? d)
		{
			return default((Id32<OPRBWAEKAQJ<LYBQOQJENGA>>, Id32<OPRBWAEKAQJ<EHBKKFTSHQH>>, Id32<OPRBWAEKAQJ<EHBKKFTSHQH>>, Id32<OPRBWAEKAQJ<YGAASBJWVTN<EHBKKFTSHQH>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x2AF8550", Offset = "0x2AF6B50", VA = "0x182AF8550")]
		public static (Id32<OPRBWAEKAQJ<LYBQOQJENGA>>, Id32<OPRBWAEKAQJ<EHBKKFTSHQH>>, Id32<OPRBWAEKAQJ<YGAASBJWVTN<EHBKKFTSHQH>>>, Id32<OPRBWAEKAQJ<YGAASBJWVTN<EHBKKFTSHQH>>>) NLAGFYZPDSJ(this UnsafeList<byte> a, int b, [Optional] Id32<YGAASBJWVTN<EHBKKFTSHQH>>? c, [Optional] Id32<YGAASBJWVTN<EHBKKFTSHQH>>? d)
		{
			return default((Id32<OPRBWAEKAQJ<LYBQOQJENGA>>, Id32<OPRBWAEKAQJ<EHBKKFTSHQH>>, Id32<OPRBWAEKAQJ<YGAASBJWVTN<EHBKKFTSHQH>>>, Id32<OPRBWAEKAQJ<YGAASBJWVTN<EHBKKFTSHQH>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x2AF9DB0", Offset = "0x2AF83B0", VA = "0x182AF9DB0")]
		public static (Id32<OPRBWAEKAQJ<LYBQOQJENGA>>, Id32<OPRBWAEKAQJ<YGAASBJWVTN<EHBKKFTSHQH>>>, Id32<OPRBWAEKAQJ<YGAASBJWVTN<EHBKKFTSHQH>>>, Id32<OPRBWAEKAQJ<YGAASBJWVTN<EHBKKFTSHQH>>>) UNPOZHUUAXC(this UnsafeList<byte> a, [Optional] Id32<YGAASBJWVTN<EHBKKFTSHQH>>? b, [Optional] Id32<YGAASBJWVTN<EHBKKFTSHQH>>? c, [Optional] Id32<YGAASBJWVTN<EHBKKFTSHQH>>? d)
		{
			return default((Id32<OPRBWAEKAQJ<LYBQOQJENGA>>, Id32<OPRBWAEKAQJ<YGAASBJWVTN<EHBKKFTSHQH>>>, Id32<OPRBWAEKAQJ<YGAASBJWVTN<EHBKKFTSHQH>>>, Id32<OPRBWAEKAQJ<YGAASBJWVTN<EHBKKFTSHQH>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x2AF6920", Offset = "0x2AF4F20", VA = "0x182AF6920")]
		public static (Id32<OPRBWAEKAQJ<LYBQOQJENGA>>, Id32<OPRBWAEKAQJ<LOMMWLQLJQC>>, Id32<OPRBWAEKAQJ<LOMMWLQLJQC>>, Id32<OPRBWAEKAQJ<YGAASBJWVTN<EHBKKFTSHQH>>>) CDRWATJBMGL(this UnsafeList<byte> a, float b, float c, [Optional] Id32<YGAASBJWVTN<EHBKKFTSHQH>>? d)
		{
			return default((Id32<OPRBWAEKAQJ<LYBQOQJENGA>>, Id32<OPRBWAEKAQJ<LOMMWLQLJQC>>, Id32<OPRBWAEKAQJ<LOMMWLQLJQC>>, Id32<OPRBWAEKAQJ<YGAASBJWVTN<EHBKKFTSHQH>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x2AF94E0", Offset = "0x2AF7AE0", VA = "0x182AF94E0")]
		public static (Id32<OPRBWAEKAQJ<LYBQOQJENGA>>, Id32<OPRBWAEKAQJ<LOMMWLQLJQC>>, Id32<OPRBWAEKAQJ<YGAASBJWVTN<LOMMWLQLJQC>>>, Id32<OPRBWAEKAQJ<YGAASBJWVTN<EHBKKFTSHQH>>>) QMPEPWPACLK(this UnsafeList<byte> a, float b, [Optional] Id32<YGAASBJWVTN<LOMMWLQLJQC>>? c, [Optional] Id32<YGAASBJWVTN<EHBKKFTSHQH>>? d)
		{
			return default((Id32<OPRBWAEKAQJ<LYBQOQJENGA>>, Id32<OPRBWAEKAQJ<LOMMWLQLJQC>>, Id32<OPRBWAEKAQJ<YGAASBJWVTN<LOMMWLQLJQC>>>, Id32<OPRBWAEKAQJ<YGAASBJWVTN<EHBKKFTSHQH>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x2AF6500", Offset = "0x2AF4B00", VA = "0x182AF6500")]
		public static (Id32<OPRBWAEKAQJ<LYBQOQJENGA>>, Id32<OPRBWAEKAQJ<YGAASBJWVTN<LOMMWLQLJQC>>>, Id32<OPRBWAEKAQJ<YGAASBJWVTN<LOMMWLQLJQC>>>, Id32<OPRBWAEKAQJ<YGAASBJWVTN<EHBKKFTSHQH>>>) AVJLUPJKQGN(this UnsafeList<byte> a, [Optional] Id32<YGAASBJWVTN<LOMMWLQLJQC>>? b, [Optional] Id32<YGAASBJWVTN<LOMMWLQLJQC>>? c, [Optional] Id32<YGAASBJWVTN<EHBKKFTSHQH>>? d)
		{
			return default((Id32<OPRBWAEKAQJ<LYBQOQJENGA>>, Id32<OPRBWAEKAQJ<YGAASBJWVTN<LOMMWLQLJQC>>>, Id32<OPRBWAEKAQJ<YGAASBJWVTN<LOMMWLQLJQC>>>, Id32<OPRBWAEKAQJ<YGAASBJWVTN<EHBKKFTSHQH>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x2AFB130", Offset = "0x2AF9730", VA = "0x182AFB130")]
		public static (Id32<OPRBWAEKAQJ<LYBQOQJENGA>>, Id32<OPRBWAEKAQJ<EHBKKFTSHQH>>, Id32<OPRBWAEKAQJ<EHBKKFTSHQH>>, Id32<OPRBWAEKAQJ<YGAASBJWVTN<EHBKKFTSHQH>>>) XXJBVNOKUOC(this UnsafeList<byte> a, int b, int c, [Optional] Id32<YGAASBJWVTN<EHBKKFTSHQH>>? d)
		{
			return default((Id32<OPRBWAEKAQJ<LYBQOQJENGA>>, Id32<OPRBWAEKAQJ<EHBKKFTSHQH>>, Id32<OPRBWAEKAQJ<EHBKKFTSHQH>>, Id32<OPRBWAEKAQJ<YGAASBJWVTN<EHBKKFTSHQH>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x2AF86A0", Offset = "0x2AF6CA0", VA = "0x182AF86A0")]
		public static (Id32<OPRBWAEKAQJ<LYBQOQJENGA>>, Id32<OPRBWAEKAQJ<EHBKKFTSHQH>>, Id32<OPRBWAEKAQJ<YGAASBJWVTN<EHBKKFTSHQH>>>, Id32<OPRBWAEKAQJ<YGAASBJWVTN<EHBKKFTSHQH>>>) NTGZXOVVQIR(this UnsafeList<byte> a, int b, [Optional] Id32<YGAASBJWVTN<EHBKKFTSHQH>>? c, [Optional] Id32<YGAASBJWVTN<EHBKKFTSHQH>>? d)
		{
			return default((Id32<OPRBWAEKAQJ<LYBQOQJENGA>>, Id32<OPRBWAEKAQJ<EHBKKFTSHQH>>, Id32<OPRBWAEKAQJ<YGAASBJWVTN<EHBKKFTSHQH>>>, Id32<OPRBWAEKAQJ<YGAASBJWVTN<EHBKKFTSHQH>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x2AFB010", Offset = "0x2AF9610", VA = "0x182AFB010")]
		public static (Id32<OPRBWAEKAQJ<LYBQOQJENGA>>, Id32<OPRBWAEKAQJ<YGAASBJWVTN<EHBKKFTSHQH>>>, Id32<OPRBWAEKAQJ<YGAASBJWVTN<EHBKKFTSHQH>>>, Id32<OPRBWAEKAQJ<YGAASBJWVTN<EHBKKFTSHQH>>>) XOERBEPCXIE(this UnsafeList<byte> a, [Optional] Id32<YGAASBJWVTN<EHBKKFTSHQH>>? b, [Optional] Id32<YGAASBJWVTN<EHBKKFTSHQH>>? c, [Optional] Id32<YGAASBJWVTN<EHBKKFTSHQH>>? d)
		{
			return default((Id32<OPRBWAEKAQJ<LYBQOQJENGA>>, Id32<OPRBWAEKAQJ<YGAASBJWVTN<EHBKKFTSHQH>>>, Id32<OPRBWAEKAQJ<YGAASBJWVTN<EHBKKFTSHQH>>>, Id32<OPRBWAEKAQJ<YGAASBJWVTN<EHBKKFTSHQH>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x2AF70F0", Offset = "0x2AF56F0", VA = "0x182AF70F0")]
		public static (Id32<OPRBWAEKAQJ<LYBQOQJENGA>>, Id32<OPRBWAEKAQJ<LOMMWLQLJQC>>, Id32<OPRBWAEKAQJ<LOMMWLQLJQC>>, Id32<OPRBWAEKAQJ<YGAASBJWVTN<EHBKKFTSHQH>>>) FSOJWOMFPUC(this UnsafeList<byte> a, float b, float c, [Optional] Id32<YGAASBJWVTN<EHBKKFTSHQH>>? d)
		{
			return default((Id32<OPRBWAEKAQJ<LYBQOQJENGA>>, Id32<OPRBWAEKAQJ<LOMMWLQLJQC>>, Id32<OPRBWAEKAQJ<LOMMWLQLJQC>>, Id32<OPRBWAEKAQJ<YGAASBJWVTN<EHBKKFTSHQH>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x2AF9B30", Offset = "0x2AF8130", VA = "0x182AF9B30")]
		public static (Id32<OPRBWAEKAQJ<LYBQOQJENGA>>, Id32<OPRBWAEKAQJ<LOMMWLQLJQC>>, Id32<OPRBWAEKAQJ<YGAASBJWVTN<LOMMWLQLJQC>>>, Id32<OPRBWAEKAQJ<YGAASBJWVTN<EHBKKFTSHQH>>>) TJGVUPQDHCR(this UnsafeList<byte> a, float b, [Optional] Id32<YGAASBJWVTN<LOMMWLQLJQC>>? c, [Optional] Id32<YGAASBJWVTN<EHBKKFTSHQH>>? d)
		{
			return default((Id32<OPRBWAEKAQJ<LYBQOQJENGA>>, Id32<OPRBWAEKAQJ<LOMMWLQLJQC>>, Id32<OPRBWAEKAQJ<YGAASBJWVTN<LOMMWLQLJQC>>>, Id32<OPRBWAEKAQJ<YGAASBJWVTN<EHBKKFTSHQH>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x2AF9A00", Offset = "0x2AF8000", VA = "0x182AF9A00")]
		public static (Id32<OPRBWAEKAQJ<LYBQOQJENGA>>, Id32<OPRBWAEKAQJ<YGAASBJWVTN<LOMMWLQLJQC>>>, Id32<OPRBWAEKAQJ<YGAASBJWVTN<LOMMWLQLJQC>>>, Id32<OPRBWAEKAQJ<YGAASBJWVTN<EHBKKFTSHQH>>>) SZNEYKMKJDO(this UnsafeList<byte> a, [Optional] Id32<YGAASBJWVTN<LOMMWLQLJQC>>? b, [Optional] Id32<YGAASBJWVTN<LOMMWLQLJQC>>? c, [Optional] Id32<YGAASBJWVTN<EHBKKFTSHQH>>? d)
		{
			return default((Id32<OPRBWAEKAQJ<LYBQOQJENGA>>, Id32<OPRBWAEKAQJ<YGAASBJWVTN<LOMMWLQLJQC>>>, Id32<OPRBWAEKAQJ<YGAASBJWVTN<LOMMWLQLJQC>>>, Id32<OPRBWAEKAQJ<YGAASBJWVTN<EHBKKFTSHQH>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x2AF87F0", Offset = "0x2AF6DF0", VA = "0x182AF87F0")]
		public static (Id32<OPRBWAEKAQJ<LYBQOQJENGA>>, Id32<OPRBWAEKAQJ<EHBKKFTSHQH>>, Id32<OPRBWAEKAQJ<EHBKKFTSHQH>>, Id32<OPRBWAEKAQJ<YGAASBJWVTN<EHBKKFTSHQH>>>) OANGWPXRTOH(this UnsafeList<byte> a, int b, int c, [Optional] Id32<YGAASBJWVTN<EHBKKFTSHQH>>? d)
		{
			return default((Id32<OPRBWAEKAQJ<LYBQOQJENGA>>, Id32<OPRBWAEKAQJ<EHBKKFTSHQH>>, Id32<OPRBWAEKAQJ<EHBKKFTSHQH>>, Id32<OPRBWAEKAQJ<YGAASBJWVTN<EHBKKFTSHQH>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x2AF8070", Offset = "0x2AF6670", VA = "0x182AF8070")]
		public static (Id32<OPRBWAEKAQJ<LYBQOQJENGA>>, Id32<OPRBWAEKAQJ<EHBKKFTSHQH>>, Id32<OPRBWAEKAQJ<YGAASBJWVTN<EHBKKFTSHQH>>>, Id32<OPRBWAEKAQJ<YGAASBJWVTN<EHBKKFTSHQH>>>) MHCBWGDCFTW(this UnsafeList<byte> a, int b, [Optional] Id32<YGAASBJWVTN<EHBKKFTSHQH>>? c, [Optional] Id32<YGAASBJWVTN<EHBKKFTSHQH>>? d)
		{
			return default((Id32<OPRBWAEKAQJ<LYBQOQJENGA>>, Id32<OPRBWAEKAQJ<EHBKKFTSHQH>>, Id32<OPRBWAEKAQJ<YGAASBJWVTN<EHBKKFTSHQH>>>, Id32<OPRBWAEKAQJ<YGAASBJWVTN<EHBKKFTSHQH>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x2AF73C0", Offset = "0x2AF59C0", VA = "0x182AF73C0")]
		public static (Id32<OPRBWAEKAQJ<LYBQOQJENGA>>, Id32<OPRBWAEKAQJ<YGAASBJWVTN<EHBKKFTSHQH>>>, Id32<OPRBWAEKAQJ<YGAASBJWVTN<EHBKKFTSHQH>>>, Id32<OPRBWAEKAQJ<YGAASBJWVTN<EHBKKFTSHQH>>>) HXZRKEBBUYZ(this UnsafeList<byte> a, [Optional] Id32<YGAASBJWVTN<EHBKKFTSHQH>>? b, [Optional] Id32<YGAASBJWVTN<EHBKKFTSHQH>>? c, [Optional] Id32<YGAASBJWVTN<EHBKKFTSHQH>>? d)
		{
			return default((Id32<OPRBWAEKAQJ<LYBQOQJENGA>>, Id32<OPRBWAEKAQJ<YGAASBJWVTN<EHBKKFTSHQH>>>, Id32<OPRBWAEKAQJ<YGAASBJWVTN<EHBKKFTSHQH>>>, Id32<OPRBWAEKAQJ<YGAASBJWVTN<EHBKKFTSHQH>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x2AFA020", Offset = "0x2AF8620", VA = "0x182AFA020")]
		public static (Id32<OPRBWAEKAQJ<LYBQOQJENGA>>, Id32<OPRBWAEKAQJ<LOMMWLQLJQC>>, Id32<OPRBWAEKAQJ<LOMMWLQLJQC>>, Id32<OPRBWAEKAQJ<YGAASBJWVTN<LOMMWLQLJQC>>>) UXFFHZXOJVL(this UnsafeList<byte> a, float b, float c, [Optional] Id32<YGAASBJWVTN<LOMMWLQLJQC>>? d)
		{
			return default((Id32<OPRBWAEKAQJ<LYBQOQJENGA>>, Id32<OPRBWAEKAQJ<LOMMWLQLJQC>>, Id32<OPRBWAEKAQJ<LOMMWLQLJQC>>, Id32<OPRBWAEKAQJ<YGAASBJWVTN<LOMMWLQLJQC>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x2AFAC50", Offset = "0x2AF9250", VA = "0x182AFAC50")]
		public static (Id32<OPRBWAEKAQJ<LYBQOQJENGA>>, Id32<OPRBWAEKAQJ<LOMMWLQLJQC>>, Id32<OPRBWAEKAQJ<YGAASBJWVTN<LOMMWLQLJQC>>>, Id32<OPRBWAEKAQJ<YGAASBJWVTN<LOMMWLQLJQC>>>) WNLJXOPQFNA(this UnsafeList<byte> a, float b, [Optional] Id32<YGAASBJWVTN<LOMMWLQLJQC>>? c, [Optional] Id32<YGAASBJWVTN<LOMMWLQLJQC>>? d)
		{
			return default((Id32<OPRBWAEKAQJ<LYBQOQJENGA>>, Id32<OPRBWAEKAQJ<LOMMWLQLJQC>>, Id32<OPRBWAEKAQJ<YGAASBJWVTN<LOMMWLQLJQC>>>, Id32<OPRBWAEKAQJ<YGAASBJWVTN<LOMMWLQLJQC>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x2AF7B60", Offset = "0x2AF6160", VA = "0x182AF7B60")]
		public static (Id32<OPRBWAEKAQJ<LYBQOQJENGA>>, Id32<OPRBWAEKAQJ<YGAASBJWVTN<LOMMWLQLJQC>>>, Id32<OPRBWAEKAQJ<YGAASBJWVTN<LOMMWLQLJQC>>>, Id32<OPRBWAEKAQJ<YGAASBJWVTN<LOMMWLQLJQC>>>) LVQYARTEMDR(this UnsafeList<byte> a, [Optional] Id32<YGAASBJWVTN<LOMMWLQLJQC>>? b, [Optional] Id32<YGAASBJWVTN<LOMMWLQLJQC>>? c, [Optional] Id32<YGAASBJWVTN<LOMMWLQLJQC>>? d)
		{
			return default((Id32<OPRBWAEKAQJ<LYBQOQJENGA>>, Id32<OPRBWAEKAQJ<YGAASBJWVTN<LOMMWLQLJQC>>>, Id32<OPRBWAEKAQJ<YGAASBJWVTN<LOMMWLQLJQC>>>, Id32<OPRBWAEKAQJ<YGAASBJWVTN<LOMMWLQLJQC>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x2AFA720", Offset = "0x2AF8D20", VA = "0x182AFA720")]
		public static (Id32<OPRBWAEKAQJ<LYBQOQJENGA>>, Id32<OPRBWAEKAQJ<EHBKKFTSHQH>>, Id32<OPRBWAEKAQJ<EHBKKFTSHQH>>, Id32<OPRBWAEKAQJ<YGAASBJWVTN<EHBKKFTSHQH>>>) VXMZOQVOWVF(this UnsafeList<byte> a, int b, int c, [Optional] Id32<YGAASBJWVTN<EHBKKFTSHQH>>? d)
		{
			return default((Id32<OPRBWAEKAQJ<LYBQOQJENGA>>, Id32<OPRBWAEKAQJ<EHBKKFTSHQH>>, Id32<OPRBWAEKAQJ<EHBKKFTSHQH>>, Id32<OPRBWAEKAQJ<YGAASBJWVTN<EHBKKFTSHQH>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x2AF8CB0", Offset = "0x2AF72B0", VA = "0x182AF8CB0")]
		public static (Id32<OPRBWAEKAQJ<LYBQOQJENGA>>, Id32<OPRBWAEKAQJ<EHBKKFTSHQH>>, Id32<OPRBWAEKAQJ<YGAASBJWVTN<EHBKKFTSHQH>>>, Id32<OPRBWAEKAQJ<YGAASBJWVTN<EHBKKFTSHQH>>>) PAQFKSIJKHK(this UnsafeList<byte> a, int b, [Optional] Id32<YGAASBJWVTN<EHBKKFTSHQH>>? c, [Optional] Id32<YGAASBJWVTN<EHBKKFTSHQH>>? d)
		{
			return default((Id32<OPRBWAEKAQJ<LYBQOQJENGA>>, Id32<OPRBWAEKAQJ<EHBKKFTSHQH>>, Id32<OPRBWAEKAQJ<YGAASBJWVTN<EHBKKFTSHQH>>>, Id32<OPRBWAEKAQJ<YGAASBJWVTN<EHBKKFTSHQH>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x2AF6D50", Offset = "0x2AF5350", VA = "0x182AF6D50")]
		public static (Id32<OPRBWAEKAQJ<LYBQOQJENGA>>, Id32<OPRBWAEKAQJ<YGAASBJWVTN<EHBKKFTSHQH>>>, Id32<OPRBWAEKAQJ<YGAASBJWVTN<EHBKKFTSHQH>>>, Id32<OPRBWAEKAQJ<YGAASBJWVTN<EHBKKFTSHQH>>>) DFWRGMRBFPH(this UnsafeList<byte> a, [Optional] Id32<YGAASBJWVTN<EHBKKFTSHQH>>? b, [Optional] Id32<YGAASBJWVTN<EHBKKFTSHQH>>? c, [Optional] Id32<YGAASBJWVTN<EHBKKFTSHQH>>? d)
		{
			return default((Id32<OPRBWAEKAQJ<LYBQOQJENGA>>, Id32<OPRBWAEKAQJ<YGAASBJWVTN<EHBKKFTSHQH>>>, Id32<OPRBWAEKAQJ<YGAASBJWVTN<EHBKKFTSHQH>>>, Id32<OPRBWAEKAQJ<YGAASBJWVTN<EHBKKFTSHQH>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x2AFAB40", Offset = "0x2AF9140", VA = "0x182AFAB40")]
		public static (Id32<OPRBWAEKAQJ<LYBQOQJENGA>>, Id32<OPRBWAEKAQJ<EHBKKFTSHQH>>, Id32<OPRBWAEKAQJ<YGAASBJWVTN<EHBKKFTSHQH>>>) WMZUZKGUNQA(this UnsafeList<byte> a, [Optional] int? b, [Optional] Id32<YGAASBJWVTN<EHBKKFTSHQH>>? c)
		{
			return default((Id32<OPRBWAEKAQJ<LYBQOQJENGA>>, Id32<OPRBWAEKAQJ<EHBKKFTSHQH>>, Id32<OPRBWAEKAQJ<YGAASBJWVTN<EHBKKFTSHQH>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x2AFBC70", Offset = "0x2AFA270", VA = "0x182AFBC70")]
		public static (Id32<OPRBWAEKAQJ<LYBQOQJENGA>>, Id32<OPRBWAEKAQJ<YGAASBJWVTN<EHBKKFTSHQH>>>, Id32<OPRBWAEKAQJ<YGAASBJWVTN<EHBKKFTSHQH>>>) ZPCTLYZGJDR(this UnsafeList<byte> a, [Optional] Id32<YGAASBJWVTN<EHBKKFTSHQH>>? b, [Optional] Id32<YGAASBJWVTN<EHBKKFTSHQH>>? c)
		{
			return default((Id32<OPRBWAEKAQJ<LYBQOQJENGA>>, Id32<OPRBWAEKAQJ<YGAASBJWVTN<EHBKKFTSHQH>>>, Id32<OPRBWAEKAQJ<YGAASBJWVTN<EHBKKFTSHQH>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x2AF6780", Offset = "0x2AF4D80", VA = "0x182AF6780")]
		public static Id32<OPRBWAEKAQJ<LYBQOQJENGA>> BPDEOOWBHEK(this UnsafeList<byte> a)
		{
			return default(Id32<OPRBWAEKAQJ<LYBQOQJENGA>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x2AFA2C0", Offset = "0x2AF88C0", VA = "0x182AFA2C0")]
		public static (Id32<OPRBWAEKAQJ<LYBQOQJENGA>>, Id32<OPRBWAEKAQJ<LOMMWLQLJQC>>, Id32<OPRBWAEKAQJ<LOMMWLQLJQC>>, Id32<OPRBWAEKAQJ<YGAASBJWVTN<LOMMWLQLJQC>>>) VDYIBUNSETX(this UnsafeList<byte> a, float b, float c, [Optional] Id32<YGAASBJWVTN<LOMMWLQLJQC>>? d)
		{
			return default((Id32<OPRBWAEKAQJ<LYBQOQJENGA>>, Id32<OPRBWAEKAQJ<LOMMWLQLJQC>>, Id32<OPRBWAEKAQJ<LOMMWLQLJQC>>, Id32<OPRBWAEKAQJ<YGAASBJWVTN<LOMMWLQLJQC>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x2AF7270", Offset = "0x2AF5870", VA = "0x182AF7270")]
		public static (Id32<OPRBWAEKAQJ<LYBQOQJENGA>>, Id32<OPRBWAEKAQJ<LOMMWLQLJQC>>, Id32<OPRBWAEKAQJ<YGAASBJWVTN<LOMMWLQLJQC>>>, Id32<OPRBWAEKAQJ<YGAASBJWVTN<LOMMWLQLJQC>>>) GUUZJLLNGSW(this UnsafeList<byte> a, float b, [Optional] Id32<YGAASBJWVTN<LOMMWLQLJQC>>? c, [Optional] Id32<YGAASBJWVTN<LOMMWLQLJQC>>? d)
		{
			return default((Id32<OPRBWAEKAQJ<LYBQOQJENGA>>, Id32<OPRBWAEKAQJ<LOMMWLQLJQC>>, Id32<OPRBWAEKAQJ<YGAASBJWVTN<LOMMWLQLJQC>>>, Id32<OPRBWAEKAQJ<YGAASBJWVTN<LOMMWLQLJQC>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x2AFADA0", Offset = "0x2AF93A0", VA = "0x182AFADA0")]
		public static (Id32<OPRBWAEKAQJ<LYBQOQJENGA>>, Id32<OPRBWAEKAQJ<YGAASBJWVTN<LOMMWLQLJQC>>>, Id32<OPRBWAEKAQJ<YGAASBJWVTN<LOMMWLQLJQC>>>, Id32<OPRBWAEKAQJ<YGAASBJWVTN<LOMMWLQLJQC>>>) WWHQXNPSTUP(this UnsafeList<byte> a, [Optional] Id32<YGAASBJWVTN<LOMMWLQLJQC>>? b, [Optional] Id32<YGAASBJWVTN<LOMMWLQLJQC>>? c, [Optional] Id32<YGAASBJWVTN<LOMMWLQLJQC>>? d)
		{
			return default((Id32<OPRBWAEKAQJ<LYBQOQJENGA>>, Id32<OPRBWAEKAQJ<YGAASBJWVTN<LOMMWLQLJQC>>>, Id32<OPRBWAEKAQJ<YGAASBJWVTN<LOMMWLQLJQC>>>, Id32<OPRBWAEKAQJ<YGAASBJWVTN<LOMMWLQLJQC>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x2AFA5C0", Offset = "0x2AF8BC0", VA = "0x182AFA5C0")]
		public static (Id32<OPRBWAEKAQJ<LYBQOQJENGA>>, Id32<OPRBWAEKAQJ<EHBKKFTSHQH>>, Id32<OPRBWAEKAQJ<EHBKKFTSHQH>>, Id32<OPRBWAEKAQJ<YGAASBJWVTN<EHBKKFTSHQH>>>) VNXGCWUIFOD(this UnsafeList<byte> a, int b, int c, [Optional] Id32<YGAASBJWVTN<EHBKKFTSHQH>>? d)
		{
			return default((Id32<OPRBWAEKAQJ<LYBQOQJENGA>>, Id32<OPRBWAEKAQJ<EHBKKFTSHQH>>, Id32<OPRBWAEKAQJ<EHBKKFTSHQH>>, Id32<OPRBWAEKAQJ<YGAASBJWVTN<EHBKKFTSHQH>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x2AF98B0", Offset = "0x2AF7EB0", VA = "0x182AF98B0")]
		public static (Id32<OPRBWAEKAQJ<LYBQOQJENGA>>, Id32<OPRBWAEKAQJ<EHBKKFTSHQH>>, Id32<OPRBWAEKAQJ<YGAASBJWVTN<EHBKKFTSHQH>>>, Id32<OPRBWAEKAQJ<YGAASBJWVTN<EHBKKFTSHQH>>>) SLUHQIBWKAM(this UnsafeList<byte> a, int b, [Optional] Id32<YGAASBJWVTN<EHBKKFTSHQH>>? c, [Optional] Id32<YGAASBJWVTN<EHBKKFTSHQH>>? d)
		{
			return default((Id32<OPRBWAEKAQJ<LYBQOQJENGA>>, Id32<OPRBWAEKAQJ<EHBKKFTSHQH>>, Id32<OPRBWAEKAQJ<YGAASBJWVTN<EHBKKFTSHQH>>>, Id32<OPRBWAEKAQJ<YGAASBJWVTN<EHBKKFTSHQH>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x2AF63E0", Offset = "0x2AF49E0", VA = "0x182AF63E0")]
		public static (Id32<OPRBWAEKAQJ<LYBQOQJENGA>>, Id32<OPRBWAEKAQJ<YGAASBJWVTN<EHBKKFTSHQH>>>, Id32<OPRBWAEKAQJ<YGAASBJWVTN<EHBKKFTSHQH>>>, Id32<OPRBWAEKAQJ<YGAASBJWVTN<EHBKKFTSHQH>>>) ARHTWTQSXLT(this UnsafeList<byte> a, [Optional] Id32<YGAASBJWVTN<EHBKKFTSHQH>>? b, [Optional] Id32<YGAASBJWVTN<EHBKKFTSHQH>>? c, [Optional] Id32<YGAASBJWVTN<EHBKKFTSHQH>>? d)
		{
			return default((Id32<OPRBWAEKAQJ<LYBQOQJENGA>>, Id32<OPRBWAEKAQJ<YGAASBJWVTN<EHBKKFTSHQH>>>, Id32<OPRBWAEKAQJ<YGAASBJWVTN<EHBKKFTSHQH>>>, Id32<OPRBWAEKAQJ<YGAASBJWVTN<EHBKKFTSHQH>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x2AFBB10", Offset = "0x2AFA110", VA = "0x182AFBB10")]
		public static (Id32<OPRBWAEKAQJ<LYBQOQJENGA>>, Id32<OPRBWAEKAQJ<EHBKKFTSHQH>>, Id32<OPRBWAEKAQJ<EHBKKFTSHQH>>, Id32<OPRBWAEKAQJ<YGAASBJWVTN<EHBKKFTSHQH>>>) ZMWPVAVJRYW(this UnsafeList<byte> a, int b, int c, [Optional] Id32<YGAASBJWVTN<EHBKKFTSHQH>>? d)
		{
			return default((Id32<OPRBWAEKAQJ<LYBQOQJENGA>>, Id32<OPRBWAEKAQJ<EHBKKFTSHQH>>, Id32<OPRBWAEKAQJ<EHBKKFTSHQH>>, Id32<OPRBWAEKAQJ<YGAASBJWVTN<EHBKKFTSHQH>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x2AFB410", Offset = "0x2AF9A10", VA = "0x182AFB410")]
		public static (Id32<OPRBWAEKAQJ<LYBQOQJENGA>>, Id32<OPRBWAEKAQJ<EHBKKFTSHQH>>, Id32<OPRBWAEKAQJ<YGAASBJWVTN<EHBKKFTSHQH>>>, Id32<OPRBWAEKAQJ<YGAASBJWVTN<EHBKKFTSHQH>>>) YJQVOQZGTUJ(this UnsafeList<byte> a, int b, [Optional] Id32<YGAASBJWVTN<EHBKKFTSHQH>>? c, [Optional] Id32<YGAASBJWVTN<EHBKKFTSHQH>>? d)
		{
			return default((Id32<OPRBWAEKAQJ<LYBQOQJENGA>>, Id32<OPRBWAEKAQJ<EHBKKFTSHQH>>, Id32<OPRBWAEKAQJ<YGAASBJWVTN<EHBKKFTSHQH>>>, Id32<OPRBWAEKAQJ<YGAASBJWVTN<EHBKKFTSHQH>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x2AFA1A0", Offset = "0x2AF87A0", VA = "0x182AFA1A0")]
		public static (Id32<OPRBWAEKAQJ<LYBQOQJENGA>>, Id32<OPRBWAEKAQJ<YGAASBJWVTN<EHBKKFTSHQH>>>, Id32<OPRBWAEKAQJ<YGAASBJWVTN<EHBKKFTSHQH>>>, Id32<OPRBWAEKAQJ<YGAASBJWVTN<EHBKKFTSHQH>>>) VAOWILHHTJW(this UnsafeList<byte> a, [Optional] Id32<YGAASBJWVTN<EHBKKFTSHQH>>? b, [Optional] Id32<YGAASBJWVTN<EHBKKFTSHQH>>? c, [Optional] Id32<YGAASBJWVTN<EHBKKFTSHQH>>? d)
		{
			return default((Id32<OPRBWAEKAQJ<LYBQOQJENGA>>, Id32<OPRBWAEKAQJ<YGAASBJWVTN<EHBKKFTSHQH>>>, Id32<OPRBWAEKAQJ<YGAASBJWVTN<EHBKKFTSHQH>>>, Id32<OPRBWAEKAQJ<YGAASBJWVTN<EHBKKFTSHQH>>>));
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
