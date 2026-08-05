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
		[Cpp2IlInjected.Address(RVA = "0xACD060", Offset = "0xACC460", VA = "0x180ACD060")]
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
		[Cpp2IlInjected.Address(RVA = "0x28B67F0", Offset = "0x28B5BF0", VA = "0x1828B67F0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xACDAC0", Offset = "0xACCEC0", VA = "0x180ACDAC0")]
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
		[Cpp2IlInjected.Address(RVA = "0xACDB00", Offset = "0xACCF00", VA = "0x180ACDB00")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
namespace Circuits.Shared.Core.ByteCode
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public static class WPKDFKUISLH
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x3BE1880", Offset = "0x3BE0C80", VA = "0x183BE1880")]
		public static Id32<FXJTAPCMHIX<a>> IDPUBSCDBUR<a>(this int a)
		{
			return default(Id32<FXJTAPCMHIX<a>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x28B6A20", Offset = "0x28B5E20", VA = "0x1828B6A20")]
		public static Id32<RPGMTDOAAUE> ZAQMDGPZZJI(this int a)
		{
			return default(Id32<RPGMTDOAAUE>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x3BE1880", Offset = "0x3BE0C80", VA = "0x183BE1880")]
		public static Id32<DLSISDAFEUV<b>> XJERAHYGFWT<b>(this int a)
		{
			return default(Id32<DLSISDAFEUV<b>>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public sealed class FXJTAPCMHIX<a>
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public sealed class COKCDXEUNKE
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public sealed class WOIICPNDKNL
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public sealed class RPGMTDOAAUE
	{
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public sealed class KGGAHYYTTGC
	{
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public sealed class CGRLSWYEEEY
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
	public static class UTPXEGYPXUT
	{
		[Cpp2IlInjected.Token(Token = "0x200000E")]
		public readonly struct ProcessOpDelegate<TContext, TDeps, TCompileState>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000091")]
			private readonly IntPtr _impl;

			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0xBEF470", Offset = "0xBEE870", VA = "0x180BEF470")]
			public ProcessOpDelegate(IntPtr impl)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x5A8E810", Offset = "0x5A8DC10", VA = "0x185A8E810")]
			public int Invoke(TDeps deps, TContext ctx, TCompileState compileState, [In] UnsafeList<byte> fromByteCode, int byteCodePtr)
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x3B88060", Offset = "0x3B87460", VA = "0x183B88060")]
		public static void JRULWGZAWWY<TDeps, TContext, TCompileState>(TDeps a, TContext b, TCompileState c, [In] UnsafeList<byte> oldByteCode, UnsafeList<byte> newByteCode, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processAddF32_F32i_F32i_F32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processAddF32_F32i_F32r_F32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processAddF32_F32r_F32r_F32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processAddI32_I32i_I32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processAddI32_I32i_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processAddI32_I32r_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processAndI32_I32i_I32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processAndI32_I32i_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processAndI32_I32r_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfEqualF32_F32i_F32i_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfEqualF32_F32i_F32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfEqualF32_F32r_F32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfEqualI32_I32i_I32i_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfEqualI32_I32i_I32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfEqualI32_I32r_I32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfGreaterOrEqualF32_F32i_F32i_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfGreaterOrEqualF32_F32i_F32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfGreaterOrEqualF32_F32r_F32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfGreaterOrEqualI32_I32i_I32i_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfGreaterOrEqualI32_I32i_I32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfGreaterOrEqualI32_I32r_I32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfLessF32_F32i_F32i_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfLessF32_F32i_F32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfLessF32_F32r_F32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfLessI32_I32i_I32i_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfLessI32_I32i_I32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfLessI32_I32r_I32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfLessOrEqualF32_F32i_F32i_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfLessOrEqualF32_F32i_F32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfLessOrEqualF32_F32r_F32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfLessOrEqualI32_I32i_I32i_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfLessOrEqualI32_I32i_I32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfLessOrEqualI32_I32r_I32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfNotEqualF32_F32i_F32i_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfNotEqualF32_F32i_F32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfNotEqualF32_F32r_F32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfNotEqualI32_I32i_I32i_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfNotEqualI32_I32i_I32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfNotEqualI32_I32r_I32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfNotZeroF32_F32i_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfNotZeroF32_F32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfNotZeroI32_I32i_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfNotZeroI32_I32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfZeroF32_F32i_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfZeroF32_F32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfZeroI32_I32i_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfZeroI32_I32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processCallInternal_I32i_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processCallInternal_I32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processCallExternal_I32i_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processCallExternal_I32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processCallRuntime_I32i_I32i_Xi, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processCopyI32_I32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processCopyI32_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processCopyX_Xr_I32i_Xi, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processCopyX_Xr_Xr_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processDivideF32_F32i_F32i_F32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processDivideF32_F32i_F32r_F32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processDivideF32_F32r_F32r_F32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processDivideI32_I32i_I32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processDivideI32_I32i_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processDivideI32_I32r_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processEqualF32_F32i_F32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processEqualF32_F32i_F32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processEqualF32_F32r_F32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processEqualI32_I32i_I32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processEqualI32_I32i_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processEqualI32_I32r_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processEnd, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processGreaterF32_F32i_F32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processGreaterF32_F32i_F32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processGreaterF32_F32r_F32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processGreaterI32_I32i_I32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processGreaterI32_I32i_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processGreaterI32_I32r_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processGreaterOrEqualF32_F32i_F32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processGreaterOrEqualF32_F32i_F32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processGreaterOrEqualF32_F32r_F32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processGreaterOrEqualI32_I32i_I32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processGreaterOrEqualI32_I32i_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processGreaterOrEqualI32_I32r_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processJump_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processJump_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processLessF32_F32i_F32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processLessF32_F32i_F32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processLessF32_F32r_F32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processLessI32_I32i_I32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processLessI32_I32i_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processLessI32_I32r_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processLessOrEqualF32_F32i_F32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processLessOrEqualF32_F32i_F32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processLessOrEqualF32_F32r_F32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processLessOrEqualI32_I32i_I32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processLessOrEqualI32_I32i_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processLessOrEqualI32_I32r_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processModI32_I32i_I32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processModI32_I32i_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processModI32_I32r_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processMultiplyF32_F32i_F32i_F32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processMultiplyF32_F32i_F32r_F32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processMultiplyF32_F32r_F32r_F32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processMultiplyI32_I32i_I32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processMultiplyI32_I32i_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processMultiplyI32_I32r_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processNegateF32_F32i_F32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processNegateF32_F32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processNegateF32_F32r_F32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processNegateI32_I32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processNegateI32_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processNegateI32_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processNoOp, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processNotEqualF32_F32i_F32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processNotEqualF32_F32i_F32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processNotEqualF32_F32r_F32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processNotEqualI32_I32i_I32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processNotEqualI32_I32i_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processNotEqualI32_I32r_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processNotI32_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processNotI32_I32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processNotI32_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processOrI32_I32i_I32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processOrI32_I32i_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processOrI32_I32r_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processReturn, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processStaticCastF32I32_F32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processStaticCastI32F32_I32r_F32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processSubtractF32_F32i_F32i_F32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processSubtractF32_F32i_F32r_F32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processSubtractF32_F32r_F32r_F32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processSubtractI32_I32i_I32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processSubtractI32_I32i_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processSubtractI32_I32r_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processXorI32_I32i_I32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processXorI32_I32i_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processXorI32_I32r_I32r_I32r) where TDeps : notnull where TContext : notnull where TCompileState : notnull
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x28B6980", Offset = "0x28B5D80", VA = "0x1828B6980")]
		private static int EGSAATAQYLM([In] UnsafeList<byte> from, UnsafeList<byte> a, int b, int c)
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public static class BBFICEHROCO
	{
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		public static readonly int DPKIXSFPTME;

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x33B0560", Offset = "0x33AF960", VA = "0x1833B0560")]
		public static Id32<FXJTAPCMHIX<a>> AYTYXDZWWEO<a>([In] this UnsafeList<byte> self)
		{
			return default(Id32<FXJTAPCMHIX<a>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x33B06C0", Offset = "0x33AFAC0", VA = "0x1833B06C0")]
		public static Id32<FXJTAPCMHIX<FXJTAPCMHIX<b>>> RULAOXTUHYR<b>(this UnsafeList<byte> a, [Optional] Id32<FXJTAPCMHIX<b>>? b)
		{
			return default(Id32<FXJTAPCMHIX<FXJTAPCMHIX<b>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x28B09C0", Offset = "0x28AFDC0", VA = "0x1828B09C0")]
		public static Id32<FXJTAPCMHIX<RIYHSWPESUG>> ZOBDBLOCYWN(this UnsafeList<byte> a, [Optional] Id32<RIYHSWPESUG>? b)
		{
			return default(Id32<FXJTAPCMHIX<RIYHSWPESUG>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x28B0600", Offset = "0x28AFA00", VA = "0x1828B0600")]
		public static Id32<FXJTAPCMHIX<COKCDXEUNKE>> IITFQSBAGXT(this UnsafeList<byte> a, [Optional] float? b)
		{
			return default(Id32<FXJTAPCMHIX<COKCDXEUNKE>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x28B0420", Offset = "0x28AF820", VA = "0x1828B0420")]
		public static Id32<FXJTAPCMHIX<WOIICPNDKNL>> BYMCFQRHLNS(this UnsafeList<byte> a, [Optional] int? b)
		{
			return default(Id32<FXJTAPCMHIX<WOIICPNDKNL>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x28B08D0", Offset = "0x28AFCD0", VA = "0x1828B08D0")]
		public static Id32<FXJTAPCMHIX<ILIKHFFEBDR>> ZAGNEXCVMDM(this UnsafeList<byte> a, [Optional] Id32<ILIKHFFEBDR>? b)
		{
			return default(Id32<FXJTAPCMHIX<ILIKHFFEBDR>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x28B0500", Offset = "0x28AF900", VA = "0x1828B0500")]
		public static Id32<FXJTAPCMHIX<CGRLSWYEEEY>> GSPIUVNWSVJ(this UnsafeList<byte> a, [Optional] byte? b)
		{
			return default(Id32<FXJTAPCMHIX<CGRLSWYEEEY>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x28B06F0", Offset = "0x28AFAF0", VA = "0x1828B06F0")]
		public static Id32<FXJTAPCMHIX<RPGMTDOAAUE>> VYZBHRIRBMH(this UnsafeList<byte> a, [Optional] Id32<RPGMTDOAAUE>? b)
		{
			return default(Id32<FXJTAPCMHIX<RPGMTDOAAUE>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x28B07E0", Offset = "0x28AFBE0", VA = "0x1828B07E0")]
		public static Id32<FXJTAPCMHIX<KGGAHYYTTGC>> YWHANXTQYTT(this UnsafeList<byte> a, [Optional] Op? b)
		{
			return default(Id32<FXJTAPCMHIX<KGGAHYYTTGC>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x33B06C0", Offset = "0x33AFAC0", VA = "0x1833B06C0")]
		public static Id32<FXJTAPCMHIX<DLSISDAFEUV<c>>> IFBKCNQGFLZ<c>(this UnsafeList<byte> a, [Optional] Id32<DLSISDAFEUV<c>>? b)
		{
			return default(Id32<FXJTAPCMHIX<DLSISDAFEUV<c>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x28B0270", Offset = "0x28AF670", VA = "0x1828B0270")]
		public static void IQOYGMRQMZT(this UnsafeList<byte> a, Id32<FXJTAPCMHIX<WOIICPNDKNL>> b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x33B07A0", Offset = "0x33AFBA0", VA = "0x1833B07A0")]
		public static void OMWNCYIIUNO<d>(this UnsafeList<byte> a, Id32<FXJTAPCMHIX<FXJTAPCMHIX<d>>> b, Id32<FXJTAPCMHIX<d>> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x33B07A0", Offset = "0x33AFBA0", VA = "0x1833B07A0")]
		public static void RAFFLFMQGCG<e>(this UnsafeList<byte> a, Id32<FXJTAPCMHIX<DLSISDAFEUV<e>>> b, Id32<DLSISDAFEUV<e>> c)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public static class RQRYMVDQLDR
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x28B6910", Offset = "0x28B5D10", VA = "0x1828B6910")]
		public static Union32 BODGDPOOPET([In] this ReadOnlySpan<byte> bytes, int a)
		{
			return default(Union32);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x28B6870", Offset = "0x28B5C70", VA = "0x1828B6870")]
		public static Union32 BODGDPOOPET([In] this UnsafeList<byte> bytes, int a)
		{
			return default(Union32);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x3948BD0", Offset = "0x3947FD0", VA = "0x183948BD0")]
		public static Union32 BODGDPOOPET<f>(this ReadOnlyIdArray<f, byte> a, Id32<f> b)
		{
			return default(Union32);
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x39489F0", Offset = "0x3947DF0", VA = "0x1839489F0")]
		public static Union32 BODGDPOOPET<g>([In] this ReadOnlyIdSpan<g, byte> bytes, Id32<g> a)
		{
			return default(Union32);
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x3948B70", Offset = "0x3947F70", VA = "0x183948B70")]
		public static Union32 BODGDPOOPET<i>(this IdArray<i, byte> a, Id32<i> b)
		{
			return default(Union32);
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x39488C0", Offset = "0x3947CC0", VA = "0x1839488C0")]
		public static Union32 BODGDPOOPET<j>([In] this IdSpan<j, byte> bytes, Id32<j> a)
		{
			return default(Union32);
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x3948930", Offset = "0x3947D30", VA = "0x183948930")]
		public static Union32 BODGDPOOPET<k>(this ReadOnlyIdArray<k, byte> a, Id32<k> b)
		{
			return default(Union32);
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x28B6910", Offset = "0x28B5D10", VA = "0x1828B6910")]
		public static int JBGCXEGABQQ([In] this ReadOnlySpan<byte> bytes, int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x28B0410", Offset = "0x28AF810", VA = "0x1828B0410")]
		public static int JBGCXEGABQQ([In] this UnsafeList<byte> bytes, int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x3948FC0", Offset = "0x39483C0", VA = "0x183948FC0")]
		public static int JBGCXEGABQQ<p>(this ReadOnlyIdArray<p, byte> a, Id32<p> b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x3948F40", Offset = "0x3948340", VA = "0x183948F40")]
		public static int JBGCXEGABQQ<s>(this IdArray<s, byte> a, Id32<s> b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x3948EA0", Offset = "0x39482A0", VA = "0x183948EA0")]
		public static int JBGCXEGABQQ<t>([In] this IdSpan<t, byte> bytes, Id32<t> a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x3948EF0", Offset = "0x39482F0", VA = "0x183948EF0")]
		public static int JBGCXEGABQQ<u>(this ReadOnlyIdArray<u, byte> a, Id32<u> b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x3947FA0", Offset = "0x39473A0", VA = "0x183947FA0")]
		public static float AZGJZXGSFEJ<bc>(this IdArray<bc, byte> a, Id32<bc> b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x3948020", Offset = "0x3947420", VA = "0x183948020")]
		public static float AZGJZXGSFEJ<bd>([In] this IdSpan<bd, byte> bytes, Id32<bd> a)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x3948070", Offset = "0x3947470", VA = "0x183948070")]
		public static float AZGJZXGSFEJ<be>(this ReadOnlyIdArray<be, byte> a, Id32<be> b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x3949140", Offset = "0x3948540", VA = "0x183949140")]
		public static byte UDROGCZGSCD<bj>(this ReadOnlyIdArray<bj, byte> a, Id32<bj> b)
		{
			return default(byte);
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x39492F0", Offset = "0x39486F0", VA = "0x1839492F0")]
		public static byte UDROGCZGSCD<bk>([In] this ReadOnlyIdSpan<bk, byte> bytes, Id32<bk> a)
		{
			return default(byte);
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x3949340", Offset = "0x3948740", VA = "0x183949340")]
		public static byte UDROGCZGSCD<bm>(this IdArray<bm, byte> a, Id32<bm> b)
		{
			return default(byte);
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x3949260", Offset = "0x3948660", VA = "0x183949260")]
		public static byte UDROGCZGSCD<bn>([In] this IdSpan<bn, byte> bytes, Id32<bn> a)
		{
			return default(byte);
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x3949190", Offset = "0x3948590", VA = "0x183949190")]
		public static byte UDROGCZGSCD<bo>(this ReadOnlyIdArray<bo, byte> a, Id32<bo> b)
		{
			return default(byte);
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x28B0410", Offset = "0x28AF810", VA = "0x1828B0410")]
		public static Op IPXKSDNTYBL([In] this UnsafeList<byte> bytes, int a)
		{
			return default(Op);
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x3948DA0", Offset = "0x39481A0", VA = "0x183948DA0")]
		public static Op IPXKSDNTYBL<by>(this ReadOnlyIdArray<by, byte> a, Id32<by> b)
		{
			return default(Op);
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x39497F0", Offset = "0x3948BF0", VA = "0x1839497F0")]
		public static Id32<FXJTAPCMHIX<VVFCXQSNTUF>> VPYHPIJQOBH<cg>(this IdArray<cg, byte> a, Id32<cg> b)
		{
			return default(Id32<FXJTAPCMHIX<VVFCXQSNTUF>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x3949760", Offset = "0x3948B60", VA = "0x183949760")]
		public static Id32<FXJTAPCMHIX<VVFCXQSNTUF>> VPYHPIJQOBH<ch>([In] this IdSpan<ch, byte> bytes, Id32<ch> a)
		{
			return default(Id32<FXJTAPCMHIX<VVFCXQSNTUF>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x3949870", Offset = "0x3948C70", VA = "0x183949870")]
		public static Id32<FXJTAPCMHIX<VVFCXQSNTUF>> VPYHPIJQOBH<ci>(this ReadOnlyIdArray<ci, byte> a, Id32<ci> b)
		{
			return default(Id32<FXJTAPCMHIX<VVFCXQSNTUF>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x3949980", Offset = "0x3948D80", VA = "0x183949980")]
		public static Id32<DLSISDAFEUV<VVFCXQSNTUF>> YJGWINYUXFR<cs>(this ReadOnlyIdArray<cs, byte> a, Id32<cs> b)
		{
			return default(Id32<DLSISDAFEUV<VVFCXQSNTUF>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x39482D0", Offset = "0x39476D0", VA = "0x1839482D0")]
		public static Id32<RPGMTDOAAUE> BCZGPPBKWBB<da>(this IdArray<da, byte> a, Id32<da> b)
		{
			return default(Id32<RPGMTDOAAUE>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x3948350", Offset = "0x3947750", VA = "0x183948350")]
		public static Id32<RPGMTDOAAUE> BCZGPPBKWBB<db>([In] this IdSpan<db, byte> bytes, Id32<db> a)
		{
			return default(Id32<RPGMTDOAAUE>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x3948240", Offset = "0x3947640", VA = "0x183948240")]
		public static Id32<RPGMTDOAAUE> BCZGPPBKWBB<dc>(this ReadOnlyIdArray<dc, byte> a, Id32<dc> b)
		{
			return default(Id32<RPGMTDOAAUE>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x3949550", Offset = "0x3948950", VA = "0x183949550")]
		public static Id32<RIYHSWPESUG> UGMSRGHXDLT<dl>([In] this IdSpan<dl, byte> bytes, Id32<dl> a)
		{
			return default(Id32<RIYHSWPESUG>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x39494C0", Offset = "0x39488C0", VA = "0x1839494C0")]
		public static Id32<RIYHSWPESUG> UGMSRGHXDLT<dm>(this ReadOnlyIdArray<dm, byte> a, Id32<dm> b)
		{
			return default(Id32<RIYHSWPESUG>);
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x3948460", Offset = "0x3947860", VA = "0x183948460")]
		public static Id32<ILIKHFFEBDR> BKVKNLXRXVK<dw>(this ReadOnlyIdArray<dw, byte> a, Id32<dw> b)
		{
			return default(Id32<ILIKHFFEBDR>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public static class KXKLGOZKELB
	{
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x28B0D20", Offset = "0x28B0120", VA = "0x1828B0D20")]
		public static void YGXYHNGNNVE(this UnsafeList<byte> a, int b, Union32 c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x28B0DE0", Offset = "0x28B01E0", VA = "0x1828B0DE0")]
		public static void YGXYHNGNNVE(this byte[] a, int b, Union32 c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x28B0CA0", Offset = "0x28B00A0", VA = "0x1828B0CA0")]
		public static void YGXYHNGNNVE([In] this Span<byte> bytes, int a, Union32 b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x377F0D0", Offset = "0x377E4D0", VA = "0x18377F0D0")]
		public static void YGXYHNGNNVE<e>(this IdArray<e, byte> a, Id32<e> b, Union32 c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x377EF80", Offset = "0x377E380", VA = "0x18377EF80")]
		public static void YGXYHNGNNVE<f>([In] this IdSpan<f, byte> bytes, Id32<f> a, Union32 b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x28B0270", Offset = "0x28AF670", VA = "0x1828B0270")]
		public static void IQOYGMRQMZT(this UnsafeList<byte> a, int b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x28B0B60", Offset = "0x28AFF60", VA = "0x1828B0B60")]
		public static void IQOYGMRQMZT(this byte[] a, int b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x28B0BE0", Offset = "0x28AFFE0", VA = "0x1828B0BE0")]
		public static void IQOYGMRQMZT([In] this Span<byte> bytes, int a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x377EB00", Offset = "0x377DF00", VA = "0x18377EB00")]
		public static void IQOYGMRQMZT<h>(this IdArray<h, byte> a, Id32<h> b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x377EB60", Offset = "0x377DF60", VA = "0x18377EB60")]
		public static void IQOYGMRQMZT<i>([In] this IdSpan<i, byte> bytes, Id32<i> a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x28B0C60", Offset = "0x28B0060", VA = "0x1828B0C60")]
		public static void QNTGWTLMRJO(this UnsafeList<byte> a, int b, float c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x377ECA0", Offset = "0x377E0A0", VA = "0x18377ECA0")]
		public static void QNTGWTLMRJO<k>(this IdArray<k, byte> a, Id32<k> b, float c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x377ED10", Offset = "0x377E110", VA = "0x18377ED10")]
		public static void QNTGWTLMRJO<l>([In] this IdSpan<l, byte> bytes, Id32<l> a, float b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x28B0AF0", Offset = "0x28AFEF0", VA = "0x1828B0AF0")]
		public static void HHIUWQUHWMY(this UnsafeList<byte> a, int b, byte c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x377E970", Offset = "0x377DD70", VA = "0x18377E970")]
		public static void HHIUWQUHWMY<n>(this IdArray<n, byte> a, Id32<n> b, byte c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x377E9C0", Offset = "0x377DDC0", VA = "0x18377E9C0")]
		public static void HHIUWQUHWMY<o>([In] this IdSpan<o, byte> bytes, Id32<o> a, byte b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x377E7C0", Offset = "0x377DBC0", VA = "0x18377E7C0")]
		public static void OMWNCYIIUNO<q>(this IdArray<q, byte> a, Id32<q> b, Id32<FXJTAPCMHIX<VVFCXQSNTUF>> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x377E840", Offset = "0x377DC40", VA = "0x18377E840")]
		public static void OMWNCYIIUNO<r>([In] this IdSpan<r, byte> bytes, Id32<r> a, Id32<FXJTAPCMHIX<VVFCXQSNTUF>> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x377E7C0", Offset = "0x377DBC0", VA = "0x18377E7C0")]
		public static void AEXATRRERGM<t>(this IdArray<t, byte> a, Id32<t> b, Id32<RPGMTDOAAUE> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x377E840", Offset = "0x377DC40", VA = "0x18377E840")]
		public static void AEXATRRERGM<u>([In] this IdSpan<u, byte> bytes, Id32<u> a, Id32<RPGMTDOAAUE> b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public static class LRHCFGVYNZM
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x28B62A0", Offset = "0x28B56A0", VA = "0x1828B62A0")]
		public static (Id32<FXJTAPCMHIX<KGGAHYYTTGC>>, Id32<FXJTAPCMHIX<COKCDXEUNKE>>, Id32<FXJTAPCMHIX<COKCDXEUNKE>>, Id32<FXJTAPCMHIX<DLSISDAFEUV<COKCDXEUNKE>>>) YRLJKLAHHII(this UnsafeList<byte> a, float b, float c, [Optional] Id32<DLSISDAFEUV<COKCDXEUNKE>>? d)
		{
			return default((Id32<FXJTAPCMHIX<KGGAHYYTTGC>>, Id32<FXJTAPCMHIX<COKCDXEUNKE>>, Id32<FXJTAPCMHIX<COKCDXEUNKE>>, Id32<FXJTAPCMHIX<DLSISDAFEUV<COKCDXEUNKE>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x28B2820", Offset = "0x28B1C20", VA = "0x1828B2820")]
		public static (Id32<FXJTAPCMHIX<KGGAHYYTTGC>>, Id32<FXJTAPCMHIX<COKCDXEUNKE>>, Id32<FXJTAPCMHIX<DLSISDAFEUV<COKCDXEUNKE>>>, Id32<FXJTAPCMHIX<DLSISDAFEUV<COKCDXEUNKE>>>) IFEBLHKTVSL(this UnsafeList<byte> a, float b, [Optional] Id32<DLSISDAFEUV<COKCDXEUNKE>>? c, [Optional] Id32<DLSISDAFEUV<COKCDXEUNKE>>? d)
		{
			return default((Id32<FXJTAPCMHIX<KGGAHYYTTGC>>, Id32<FXJTAPCMHIX<COKCDXEUNKE>>, Id32<FXJTAPCMHIX<DLSISDAFEUV<COKCDXEUNKE>>>, Id32<FXJTAPCMHIX<DLSISDAFEUV<COKCDXEUNKE>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x28B2A90", Offset = "0x28B1E90", VA = "0x1828B2A90")]
		public static (Id32<FXJTAPCMHIX<KGGAHYYTTGC>>, Id32<FXJTAPCMHIX<DLSISDAFEUV<COKCDXEUNKE>>>, Id32<FXJTAPCMHIX<DLSISDAFEUV<COKCDXEUNKE>>>, Id32<FXJTAPCMHIX<DLSISDAFEUV<COKCDXEUNKE>>>) JQLMNITYJBE(this UnsafeList<byte> a, [Optional] Id32<DLSISDAFEUV<COKCDXEUNKE>>? b, [Optional] Id32<DLSISDAFEUV<COKCDXEUNKE>>? c, [Optional] Id32<DLSISDAFEUV<COKCDXEUNKE>>? d)
		{
			return default((Id32<FXJTAPCMHIX<KGGAHYYTTGC>>, Id32<FXJTAPCMHIX<DLSISDAFEUV<COKCDXEUNKE>>>, Id32<FXJTAPCMHIX<DLSISDAFEUV<COKCDXEUNKE>>>, Id32<FXJTAPCMHIX<DLSISDAFEUV<COKCDXEUNKE>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x28B4DE0", Offset = "0x28B41E0", VA = "0x1828B4DE0")]
		public static (Id32<FXJTAPCMHIX<KGGAHYYTTGC>>, Id32<FXJTAPCMHIX<WOIICPNDKNL>>, Id32<FXJTAPCMHIX<WOIICPNDKNL>>, Id32<FXJTAPCMHIX<DLSISDAFEUV<WOIICPNDKNL>>>) TELECFSLGPM(this UnsafeList<byte> a, int b, int c, [Optional] Id32<DLSISDAFEUV<WOIICPNDKNL>>? d)
		{
			return default((Id32<FXJTAPCMHIX<KGGAHYYTTGC>>, Id32<FXJTAPCMHIX<WOIICPNDKNL>>, Id32<FXJTAPCMHIX<WOIICPNDKNL>>, Id32<FXJTAPCMHIX<DLSISDAFEUV<WOIICPNDKNL>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x28B4B70", Offset = "0x28B3F70", VA = "0x1828B4B70")]
		public static (Id32<FXJTAPCMHIX<KGGAHYYTTGC>>, Id32<FXJTAPCMHIX<WOIICPNDKNL>>, Id32<FXJTAPCMHIX<DLSISDAFEUV<WOIICPNDKNL>>>, Id32<FXJTAPCMHIX<DLSISDAFEUV<WOIICPNDKNL>>>) SBFJVVWIIKZ(this UnsafeList<byte> a, int b, [Optional] Id32<DLSISDAFEUV<WOIICPNDKNL>>? c, [Optional] Id32<DLSISDAFEUV<WOIICPNDKNL>>? d)
		{
			return default((Id32<FXJTAPCMHIX<KGGAHYYTTGC>>, Id32<FXJTAPCMHIX<WOIICPNDKNL>>, Id32<FXJTAPCMHIX<DLSISDAFEUV<WOIICPNDKNL>>>, Id32<FXJTAPCMHIX<DLSISDAFEUV<WOIICPNDKNL>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x28B4A50", Offset = "0x28B3E50", VA = "0x1828B4A50")]
		public static (Id32<FXJTAPCMHIX<KGGAHYYTTGC>>, Id32<FXJTAPCMHIX<DLSISDAFEUV<WOIICPNDKNL>>>, Id32<FXJTAPCMHIX<DLSISDAFEUV<WOIICPNDKNL>>>, Id32<FXJTAPCMHIX<DLSISDAFEUV<WOIICPNDKNL>>>) RPDXRXFOVJW(this UnsafeList<byte> a, [Optional] Id32<DLSISDAFEUV<WOIICPNDKNL>>? b, [Optional] Id32<DLSISDAFEUV<WOIICPNDKNL>>? c, [Optional] Id32<DLSISDAFEUV<WOIICPNDKNL>>? d)
		{
			return default((Id32<FXJTAPCMHIX<KGGAHYYTTGC>>, Id32<FXJTAPCMHIX<DLSISDAFEUV<WOIICPNDKNL>>>, Id32<FXJTAPCMHIX<DLSISDAFEUV<WOIICPNDKNL>>>, Id32<FXJTAPCMHIX<DLSISDAFEUV<WOIICPNDKNL>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x28B15E0", Offset = "0x28B09E0", VA = "0x1828B15E0")]
		public static (Id32<FXJTAPCMHIX<KGGAHYYTTGC>>, Id32<FXJTAPCMHIX<WOIICPNDKNL>>, Id32<FXJTAPCMHIX<WOIICPNDKNL>>, Id32<FXJTAPCMHIX<DLSISDAFEUV<WOIICPNDKNL>>>) DONNXHTWEDW(this UnsafeList<byte> a, int b, int c, [Optional] Id32<DLSISDAFEUV<WOIICPNDKNL>>? d)
		{
			return default((Id32<FXJTAPCMHIX<KGGAHYYTTGC>>, Id32<FXJTAPCMHIX<WOIICPNDKNL>>, Id32<FXJTAPCMHIX<WOIICPNDKNL>>, Id32<FXJTAPCMHIX<DLSISDAFEUV<WOIICPNDKNL>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x28B2030", Offset = "0x28B1430", VA = "0x1828B2030")]
		public static (Id32<FXJTAPCMHIX<KGGAHYYTTGC>>, Id32<FXJTAPCMHIX<WOIICPNDKNL>>, Id32<FXJTAPCMHIX<DLSISDAFEUV<WOIICPNDKNL>>>, Id32<FXJTAPCMHIX<DLSISDAFEUV<WOIICPNDKNL>>>) GQQMJWMHZRN(this UnsafeList<byte> a, int b, [Optional] Id32<DLSISDAFEUV<WOIICPNDKNL>>? c, [Optional] Id32<DLSISDAFEUV<WOIICPNDKNL>>? d)
		{
			return default((Id32<FXJTAPCMHIX<KGGAHYYTTGC>>, Id32<FXJTAPCMHIX<WOIICPNDKNL>>, Id32<FXJTAPCMHIX<DLSISDAFEUV<WOIICPNDKNL>>>, Id32<FXJTAPCMHIX<DLSISDAFEUV<WOIICPNDKNL>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x28B42E0", Offset = "0x28B36E0", VA = "0x1828B42E0")]
		public static (Id32<FXJTAPCMHIX<KGGAHYYTTGC>>, Id32<FXJTAPCMHIX<DLSISDAFEUV<WOIICPNDKNL>>>, Id32<FXJTAPCMHIX<DLSISDAFEUV<WOIICPNDKNL>>>, Id32<FXJTAPCMHIX<DLSISDAFEUV<WOIICPNDKNL>>>) QIZHKEKDEUW(this UnsafeList<byte> a, [Optional] Id32<DLSISDAFEUV<WOIICPNDKNL>>? b, [Optional] Id32<DLSISDAFEUV<WOIICPNDKNL>>? c, [Optional] Id32<DLSISDAFEUV<WOIICPNDKNL>>? d)
		{
			return default((Id32<FXJTAPCMHIX<KGGAHYYTTGC>>, Id32<FXJTAPCMHIX<DLSISDAFEUV<WOIICPNDKNL>>>, Id32<FXJTAPCMHIX<DLSISDAFEUV<WOIICPNDKNL>>>, Id32<FXJTAPCMHIX<DLSISDAFEUV<WOIICPNDKNL>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x28B14D0", Offset = "0x28B08D0", VA = "0x1828B14D0")]
		public static (Id32<FXJTAPCMHIX<KGGAHYYTTGC>>, Id32<FXJTAPCMHIX<WOIICPNDKNL>>, Id32<FXJTAPCMHIX<FXJTAPCMHIX<KGGAHYYTTGC>>>) DNXWVDTEZZU(this UnsafeList<byte> a, [Optional] int? b, [Optional] Id32<FXJTAPCMHIX<KGGAHYYTTGC>>? c)
		{
			return default((Id32<FXJTAPCMHIX<KGGAHYYTTGC>>, Id32<FXJTAPCMHIX<WOIICPNDKNL>>, Id32<FXJTAPCMHIX<FXJTAPCMHIX<KGGAHYYTTGC>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x28B0FD0", Offset = "0x28B03D0", VA = "0x1828B0FD0")]
		public static (Id32<FXJTAPCMHIX<KGGAHYYTTGC>>, Id32<FXJTAPCMHIX<DLSISDAFEUV<WOIICPNDKNL>>>, Id32<FXJTAPCMHIX<FXJTAPCMHIX<KGGAHYYTTGC>>>) APPSBLTQYHT(this UnsafeList<byte> a, [Optional] Id32<DLSISDAFEUV<WOIICPNDKNL>>? b, [Optional] Id32<FXJTAPCMHIX<KGGAHYYTTGC>>? c)
		{
			return default((Id32<FXJTAPCMHIX<KGGAHYYTTGC>>, Id32<FXJTAPCMHIX<DLSISDAFEUV<WOIICPNDKNL>>>, Id32<FXJTAPCMHIX<FXJTAPCMHIX<KGGAHYYTTGC>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x28B1740", Offset = "0x28B0B40", VA = "0x1828B1740")]
		public static (Id32<FXJTAPCMHIX<KGGAHYYTTGC>>, Id32<FXJTAPCMHIX<WOIICPNDKNL>>, Id32<FXJTAPCMHIX<FXJTAPCMHIX<KGGAHYYTTGC>>>) DVMPAXWDZNB(this UnsafeList<byte> a, [Optional] int? b, [Optional] Id32<FXJTAPCMHIX<KGGAHYYTTGC>>? c)
		{
			return default((Id32<FXJTAPCMHIX<KGGAHYYTTGC>>, Id32<FXJTAPCMHIX<WOIICPNDKNL>>, Id32<FXJTAPCMHIX<FXJTAPCMHIX<KGGAHYYTTGC>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x28B4780", Offset = "0x28B3B80", VA = "0x1828B4780")]
		public static (Id32<FXJTAPCMHIX<KGGAHYYTTGC>>, Id32<FXJTAPCMHIX<DLSISDAFEUV<WOIICPNDKNL>>>, Id32<FXJTAPCMHIX<FXJTAPCMHIX<KGGAHYYTTGC>>>) QQEKCIQWPSE(this UnsafeList<byte> a, [Optional] Id32<DLSISDAFEUV<WOIICPNDKNL>>? b, [Optional] Id32<FXJTAPCMHIX<KGGAHYYTTGC>>? c)
		{
			return default((Id32<FXJTAPCMHIX<KGGAHYYTTGC>>, Id32<FXJTAPCMHIX<DLSISDAFEUV<WOIICPNDKNL>>>, Id32<FXJTAPCMHIX<FXJTAPCMHIX<KGGAHYYTTGC>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x28B2F40", Offset = "0x28B2340", VA = "0x1828B2F40")]
		public static (Id32<FXJTAPCMHIX<KGGAHYYTTGC>>, Id32<FXJTAPCMHIX<WOIICPNDKNL>>, Id32<FXJTAPCMHIX<RIYHSWPESUG>>) LSBISJNLTLL(this UnsafeList<byte> a, [Optional] int? b, [Optional] Id32<RIYHSWPESUG>? c)
		{
			return default((Id32<FXJTAPCMHIX<KGGAHYYTTGC>>, Id32<FXJTAPCMHIX<WOIICPNDKNL>>, Id32<FXJTAPCMHIX<RIYHSWPESUG>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x28B30F0", Offset = "0x28B24F0", VA = "0x1828B30F0")]
		public static (Id32<FXJTAPCMHIX<KGGAHYYTTGC>>, Id32<FXJTAPCMHIX<WOIICPNDKNL>>, Id32<FXJTAPCMHIX<DLSISDAFEUV<RIYHSWPESUG>>>) LTBRERIYOQE(this UnsafeList<byte> a, [Optional] int? b, [Optional] Id32<DLSISDAFEUV<RIYHSWPESUG>>? c)
		{
			return default((Id32<FXJTAPCMHIX<KGGAHYYTTGC>>, Id32<FXJTAPCMHIX<WOIICPNDKNL>>, Id32<FXJTAPCMHIX<DLSISDAFEUV<RIYHSWPESUG>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x28B48A0", Offset = "0x28B3CA0", VA = "0x1828B48A0")]
		public static (Id32<FXJTAPCMHIX<KGGAHYYTTGC>>, Id32<FXJTAPCMHIX<WOIICPNDKNL>>, Id32<FXJTAPCMHIX<RPGMTDOAAUE>>) QQWZBHCIEQT(this UnsafeList<byte> a, [Optional] int? b, [Optional] Id32<RPGMTDOAAUE>? c)
		{
			return default((Id32<FXJTAPCMHIX<KGGAHYYTTGC>>, Id32<FXJTAPCMHIX<WOIICPNDKNL>>, Id32<FXJTAPCMHIX<RPGMTDOAAUE>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x28B4670", Offset = "0x28B3A70", VA = "0x1828B4670")]
		public static (Id32<FXJTAPCMHIX<KGGAHYYTTGC>>, Id32<FXJTAPCMHIX<WOIICPNDKNL>>, Id32<FXJTAPCMHIX<DLSISDAFEUV<RPGMTDOAAUE>>>) QPMCULTAQPI(this UnsafeList<byte> a, [Optional] int? b, [Optional] Id32<DLSISDAFEUV<RPGMTDOAAUE>>? c)
		{
			return default((Id32<FXJTAPCMHIX<KGGAHYYTTGC>>, Id32<FXJTAPCMHIX<WOIICPNDKNL>>, Id32<FXJTAPCMHIX<DLSISDAFEUV<RPGMTDOAAUE>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x3791BC0", Offset = "0x3790FC0", VA = "0x183791BC0")]
		public static (Id32<FXJTAPCMHIX<KGGAHYYTTGC>>, Id32<FXJTAPCMHIX<ILIKHFFEBDR>>, Id32<FXJTAPCMHIX<WOIICPNDKNL>>, Id32<FXJTAPCMHIX<a>>) SQEHCBVKSSY<a>(this UnsafeList<byte> a, [Optional] Id32<ILIKHFFEBDR>? b, [Optional][In] ReadOnlySpan<byte> data)
		{
			return default((Id32<FXJTAPCMHIX<KGGAHYYTTGC>>, Id32<FXJTAPCMHIX<ILIKHFFEBDR>>, Id32<FXJTAPCMHIX<WOIICPNDKNL>>, Id32<FXJTAPCMHIX<a>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x28B56C0", Offset = "0x28B4AC0", VA = "0x1828B56C0")]
		public static (Id32<FXJTAPCMHIX<KGGAHYYTTGC>>, Id32<FXJTAPCMHIX<WOIICPNDKNL>>, Id32<FXJTAPCMHIX<DLSISDAFEUV<WOIICPNDKNL>>>) VOIAMJIGOZM(this UnsafeList<byte> a, int b, [Optional] Id32<DLSISDAFEUV<WOIICPNDKNL>>? c)
		{
			return default((Id32<FXJTAPCMHIX<KGGAHYYTTGC>>, Id32<FXJTAPCMHIX<WOIICPNDKNL>>, Id32<FXJTAPCMHIX<DLSISDAFEUV<WOIICPNDKNL>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x28B3920", Offset = "0x28B2D20", VA = "0x1828B3920")]
		public static (Id32<FXJTAPCMHIX<KGGAHYYTTGC>>, Id32<FXJTAPCMHIX<DLSISDAFEUV<WOIICPNDKNL>>>, Id32<FXJTAPCMHIX<DLSISDAFEUV<WOIICPNDKNL>>>) NAXOKZVAQVX(this UnsafeList<byte> a, [Optional] Id32<DLSISDAFEUV<WOIICPNDKNL>>? b, [Optional] Id32<DLSISDAFEUV<WOIICPNDKNL>>? c)
		{
			return default((Id32<FXJTAPCMHIX<KGGAHYYTTGC>>, Id32<FXJTAPCMHIX<DLSISDAFEUV<WOIICPNDKNL>>>, Id32<FXJTAPCMHIX<DLSISDAFEUV<WOIICPNDKNL>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x37917B0", Offset = "0x3790BB0", VA = "0x1837917B0")]
		public static (Id32<FXJTAPCMHIX<KGGAHYYTTGC>>, Id32<FXJTAPCMHIX<DLSISDAFEUV<b>>>, Id32<FXJTAPCMHIX<WOIICPNDKNL>>, Id32<FXJTAPCMHIX<b>>) HLWSRLXNHXI<b>(this UnsafeList<byte> a, [Optional] Id32<DLSISDAFEUV<b>>? b, [Optional] int? c, [Optional][In] ReadOnlySpan<byte> from)
		{
			return default((Id32<FXJTAPCMHIX<KGGAHYYTTGC>>, Id32<FXJTAPCMHIX<DLSISDAFEUV<b>>>, Id32<FXJTAPCMHIX<WOIICPNDKNL>>, Id32<FXJTAPCMHIX<b>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x3791F00", Offset = "0x3791300", VA = "0x183791F00")]
		public static (Id32<FXJTAPCMHIX<KGGAHYYTTGC>>, Id32<FXJTAPCMHIX<DLSISDAFEUV<c>>>, Id32<FXJTAPCMHIX<DLSISDAFEUV<c>>>, Id32<FXJTAPCMHIX<WOIICPNDKNL>>) ZAWJWPMELCR<c>(this UnsafeList<byte> a, [Optional] Id32<DLSISDAFEUV<c>>? b, [Optional] Id32<DLSISDAFEUV<c>>? c, [Optional] int? d)
		{
			return default((Id32<FXJTAPCMHIX<KGGAHYYTTGC>>, Id32<FXJTAPCMHIX<DLSISDAFEUV<c>>>, Id32<FXJTAPCMHIX<DLSISDAFEUV<c>>>, Id32<FXJTAPCMHIX<WOIICPNDKNL>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x28B0E50", Offset = "0x28B0250", VA = "0x1828B0E50")]
		public static (Id32<FXJTAPCMHIX<KGGAHYYTTGC>>, Id32<FXJTAPCMHIX<COKCDXEUNKE>>, Id32<FXJTAPCMHIX<COKCDXEUNKE>>, Id32<FXJTAPCMHIX<DLSISDAFEUV<COKCDXEUNKE>>>) AFMDJUTFKQS(this UnsafeList<byte> a, float b, float c, [Optional] Id32<DLSISDAFEUV<COKCDXEUNKE>>? d)
		{
			return default((Id32<FXJTAPCMHIX<KGGAHYYTTGC>>, Id32<FXJTAPCMHIX<COKCDXEUNKE>>, Id32<FXJTAPCMHIX<COKCDXEUNKE>>, Id32<FXJTAPCMHIX<DLSISDAFEUV<COKCDXEUNKE>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x28B66A0", Offset = "0x28B5AA0", VA = "0x1828B66A0")]
		public static (Id32<FXJTAPCMHIX<KGGAHYYTTGC>>, Id32<FXJTAPCMHIX<COKCDXEUNKE>>, Id32<FXJTAPCMHIX<DLSISDAFEUV<COKCDXEUNKE>>>, Id32<FXJTAPCMHIX<DLSISDAFEUV<COKCDXEUNKE>>>) ZIHFNIBZWQN(this UnsafeList<byte> a, float b, [Optional] Id32<DLSISDAFEUV<COKCDXEUNKE>>? c, [Optional] Id32<DLSISDAFEUV<COKCDXEUNKE>>? d)
		{
			return default((Id32<FXJTAPCMHIX<KGGAHYYTTGC>>, Id32<FXJTAPCMHIX<COKCDXEUNKE>>, Id32<FXJTAPCMHIX<DLSISDAFEUV<COKCDXEUNKE>>>, Id32<FXJTAPCMHIX<DLSISDAFEUV<COKCDXEUNKE>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x28B41C0", Offset = "0x28B35C0", VA = "0x1828B41C0")]
		public static (Id32<FXJTAPCMHIX<KGGAHYYTTGC>>, Id32<FXJTAPCMHIX<DLSISDAFEUV<COKCDXEUNKE>>>, Id32<FXJTAPCMHIX<DLSISDAFEUV<COKCDXEUNKE>>>, Id32<FXJTAPCMHIX<DLSISDAFEUV<COKCDXEUNKE>>>) PSYIJGXVXUU(this UnsafeList<byte> a, [Optional] Id32<DLSISDAFEUV<COKCDXEUNKE>>? b, [Optional] Id32<DLSISDAFEUV<COKCDXEUNKE>>? c, [Optional] Id32<DLSISDAFEUV<COKCDXEUNKE>>? d)
		{
			return default((Id32<FXJTAPCMHIX<KGGAHYYTTGC>>, Id32<FXJTAPCMHIX<DLSISDAFEUV<COKCDXEUNKE>>>, Id32<FXJTAPCMHIX<DLSISDAFEUV<COKCDXEUNKE>>>, Id32<FXJTAPCMHIX<DLSISDAFEUV<COKCDXEUNKE>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x28B1C20", Offset = "0x28B1020", VA = "0x1828B1C20")]
		public static (Id32<FXJTAPCMHIX<KGGAHYYTTGC>>, Id32<FXJTAPCMHIX<WOIICPNDKNL>>, Id32<FXJTAPCMHIX<WOIICPNDKNL>>, Id32<FXJTAPCMHIX<DLSISDAFEUV<WOIICPNDKNL>>>) FCPFBWWHTJC(this UnsafeList<byte> a, int b, int c, [Optional] Id32<DLSISDAFEUV<WOIICPNDKNL>>? d)
		{
			return default((Id32<FXJTAPCMHIX<KGGAHYYTTGC>>, Id32<FXJTAPCMHIX<WOIICPNDKNL>>, Id32<FXJTAPCMHIX<WOIICPNDKNL>>, Id32<FXJTAPCMHIX<DLSISDAFEUV<WOIICPNDKNL>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x28B6550", Offset = "0x28B5950", VA = "0x1828B6550")]
		public static (Id32<FXJTAPCMHIX<KGGAHYYTTGC>>, Id32<FXJTAPCMHIX<WOIICPNDKNL>>, Id32<FXJTAPCMHIX<DLSISDAFEUV<WOIICPNDKNL>>>, Id32<FXJTAPCMHIX<DLSISDAFEUV<WOIICPNDKNL>>>) ZGANLWFBHAL(this UnsafeList<byte> a, int b, [Optional] Id32<DLSISDAFEUV<WOIICPNDKNL>>? c, [Optional] Id32<DLSISDAFEUV<WOIICPNDKNL>>? d)
		{
			return default((Id32<FXJTAPCMHIX<KGGAHYYTTGC>>, Id32<FXJTAPCMHIX<WOIICPNDKNL>>, Id32<FXJTAPCMHIX<DLSISDAFEUV<WOIICPNDKNL>>>, Id32<FXJTAPCMHIX<DLSISDAFEUV<WOIICPNDKNL>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x28B4400", Offset = "0x28B3800", VA = "0x1828B4400")]
		public static (Id32<FXJTAPCMHIX<KGGAHYYTTGC>>, Id32<FXJTAPCMHIX<DLSISDAFEUV<WOIICPNDKNL>>>, Id32<FXJTAPCMHIX<DLSISDAFEUV<WOIICPNDKNL>>>, Id32<FXJTAPCMHIX<DLSISDAFEUV<WOIICPNDKNL>>>) QLROTDDWNRE(this UnsafeList<byte> a, [Optional] Id32<DLSISDAFEUV<WOIICPNDKNL>>? b, [Optional] Id32<DLSISDAFEUV<WOIICPNDKNL>>? c, [Optional] Id32<DLSISDAFEUV<WOIICPNDKNL>>? d)
		{
			return default((Id32<FXJTAPCMHIX<KGGAHYYTTGC>>, Id32<FXJTAPCMHIX<DLSISDAFEUV<WOIICPNDKNL>>>, Id32<FXJTAPCMHIX<DLSISDAFEUV<WOIICPNDKNL>>>, Id32<FXJTAPCMHIX<DLSISDAFEUV<WOIICPNDKNL>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x28B3200", Offset = "0x28B2600", VA = "0x1828B3200")]
		public static (Id32<FXJTAPCMHIX<KGGAHYYTTGC>>, Id32<FXJTAPCMHIX<WOIICPNDKNL>>, Id32<FXJTAPCMHIX<WOIICPNDKNL>>, Id32<FXJTAPCMHIX<DLSISDAFEUV<WOIICPNDKNL>>>) MIJIMLXXKYJ(this UnsafeList<byte> a, int b, int c, [Optional] Id32<DLSISDAFEUV<WOIICPNDKNL>>? d)
		{
			return default((Id32<FXJTAPCMHIX<KGGAHYYTTGC>>, Id32<FXJTAPCMHIX<WOIICPNDKNL>>, Id32<FXJTAPCMHIX<WOIICPNDKNL>>, Id32<FXJTAPCMHIX<DLSISDAFEUV<WOIICPNDKNL>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x28B3DF0", Offset = "0x28B31F0", VA = "0x1828B3DF0")]
		public static (Id32<FXJTAPCMHIX<KGGAHYYTTGC>>, Id32<FXJTAPCMHIX<WOIICPNDKNL>>, Id32<FXJTAPCMHIX<DLSISDAFEUV<WOIICPNDKNL>>>, Id32<FXJTAPCMHIX<DLSISDAFEUV<WOIICPNDKNL>>>) PHNFEEYLEVU(this UnsafeList<byte> a, int b, [Optional] Id32<DLSISDAFEUV<WOIICPNDKNL>>? c, [Optional] Id32<DLSISDAFEUV<WOIICPNDKNL>>? d)
		{
			return default((Id32<FXJTAPCMHIX<KGGAHYYTTGC>>, Id32<FXJTAPCMHIX<WOIICPNDKNL>>, Id32<FXJTAPCMHIX<DLSISDAFEUV<WOIICPNDKNL>>>, Id32<FXJTAPCMHIX<DLSISDAFEUV<WOIICPNDKNL>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x28B57F0", Offset = "0x28B4BF0", VA = "0x1828B57F0")]
		public static (Id32<FXJTAPCMHIX<KGGAHYYTTGC>>, Id32<FXJTAPCMHIX<DLSISDAFEUV<WOIICPNDKNL>>>, Id32<FXJTAPCMHIX<DLSISDAFEUV<WOIICPNDKNL>>>, Id32<FXJTAPCMHIX<DLSISDAFEUV<WOIICPNDKNL>>>) WCAXZJCCKAT(this UnsafeList<byte> a, [Optional] Id32<DLSISDAFEUV<WOIICPNDKNL>>? b, [Optional] Id32<DLSISDAFEUV<WOIICPNDKNL>>? c, [Optional] Id32<DLSISDAFEUV<WOIICPNDKNL>>? d)
		{
			return default((Id32<FXJTAPCMHIX<KGGAHYYTTGC>>, Id32<FXJTAPCMHIX<DLSISDAFEUV<WOIICPNDKNL>>>, Id32<FXJTAPCMHIX<DLSISDAFEUV<WOIICPNDKNL>>>, Id32<FXJTAPCMHIX<DLSISDAFEUV<WOIICPNDKNL>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x28B5B70", Offset = "0x28B4F70", VA = "0x1828B5B70")]
		public static (Id32<FXJTAPCMHIX<KGGAHYYTTGC>>, Id32<FXJTAPCMHIX<FXJTAPCMHIX<KGGAHYYTTGC>>>) WMJMTIDXSBI(this UnsafeList<byte> a, [Optional] Id32<FXJTAPCMHIX<KGGAHYYTTGC>>? b)
		{
			return default((Id32<FXJTAPCMHIX<KGGAHYYTTGC>>, Id32<FXJTAPCMHIX<FXJTAPCMHIX<KGGAHYYTTGC>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x28B3640", Offset = "0x28B2A40", VA = "0x1828B3640")]
		public static (Id32<FXJTAPCMHIX<KGGAHYYTTGC>>, Id32<FXJTAPCMHIX<COKCDXEUNKE>>, Id32<FXJTAPCMHIX<COKCDXEUNKE>>, Id32<FXJTAPCMHIX<DLSISDAFEUV<WOIICPNDKNL>>>) MWBLXTEGVZE(this UnsafeList<byte> a, float b, float c, [Optional] Id32<DLSISDAFEUV<WOIICPNDKNL>>? d)
		{
			return default((Id32<FXJTAPCMHIX<KGGAHYYTTGC>>, Id32<FXJTAPCMHIX<COKCDXEUNKE>>, Id32<FXJTAPCMHIX<COKCDXEUNKE>>, Id32<FXJTAPCMHIX<DLSISDAFEUV<WOIICPNDKNL>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x28B6140", Offset = "0x28B5540", VA = "0x1828B6140")]
		public static (Id32<FXJTAPCMHIX<KGGAHYYTTGC>>, Id32<FXJTAPCMHIX<COKCDXEUNKE>>, Id32<FXJTAPCMHIX<DLSISDAFEUV<COKCDXEUNKE>>>, Id32<FXJTAPCMHIX<DLSISDAFEUV<WOIICPNDKNL>>>) YBTUBIROKIV(this UnsafeList<byte> a, float b, [Optional] Id32<DLSISDAFEUV<COKCDXEUNKE>>? c, [Optional] Id32<DLSISDAFEUV<WOIICPNDKNL>>? d)
		{
			return default((Id32<FXJTAPCMHIX<KGGAHYYTTGC>>, Id32<FXJTAPCMHIX<COKCDXEUNKE>>, Id32<FXJTAPCMHIX<DLSISDAFEUV<COKCDXEUNKE>>>, Id32<FXJTAPCMHIX<DLSISDAFEUV<WOIICPNDKNL>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x28B5060", Offset = "0x28B4460", VA = "0x1828B5060")]
		public static (Id32<FXJTAPCMHIX<KGGAHYYTTGC>>, Id32<FXJTAPCMHIX<DLSISDAFEUV<COKCDXEUNKE>>>, Id32<FXJTAPCMHIX<DLSISDAFEUV<COKCDXEUNKE>>>, Id32<FXJTAPCMHIX<DLSISDAFEUV<WOIICPNDKNL>>>) TPCOXMHQCPW(this UnsafeList<byte> a, [Optional] Id32<DLSISDAFEUV<COKCDXEUNKE>>? b, [Optional] Id32<DLSISDAFEUV<COKCDXEUNKE>>? c, [Optional] Id32<DLSISDAFEUV<WOIICPNDKNL>>? d)
		{
			return default((Id32<FXJTAPCMHIX<KGGAHYYTTGC>>, Id32<FXJTAPCMHIX<DLSISDAFEUV<COKCDXEUNKE>>>, Id32<FXJTAPCMHIX<DLSISDAFEUV<COKCDXEUNKE>>>, Id32<FXJTAPCMHIX<DLSISDAFEUV<WOIICPNDKNL>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x28B1210", Offset = "0x28B0610", VA = "0x1828B1210")]
		public static (Id32<FXJTAPCMHIX<KGGAHYYTTGC>>, Id32<FXJTAPCMHIX<WOIICPNDKNL>>, Id32<FXJTAPCMHIX<WOIICPNDKNL>>, Id32<FXJTAPCMHIX<DLSISDAFEUV<WOIICPNDKNL>>>) CHNPNMIWISP(this UnsafeList<byte> a, int b, int c, [Optional] Id32<DLSISDAFEUV<WOIICPNDKNL>>? d)
		{
			return default((Id32<FXJTAPCMHIX<KGGAHYYTTGC>>, Id32<FXJTAPCMHIX<WOIICPNDKNL>>, Id32<FXJTAPCMHIX<WOIICPNDKNL>>, Id32<FXJTAPCMHIX<DLSISDAFEUV<WOIICPNDKNL>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x28B2180", Offset = "0x28B1580", VA = "0x1828B2180")]
		public static (Id32<FXJTAPCMHIX<KGGAHYYTTGC>>, Id32<FXJTAPCMHIX<WOIICPNDKNL>>, Id32<FXJTAPCMHIX<DLSISDAFEUV<WOIICPNDKNL>>>, Id32<FXJTAPCMHIX<DLSISDAFEUV<WOIICPNDKNL>>>) GSNRHHHVTGE(this UnsafeList<byte> a, int b, [Optional] Id32<DLSISDAFEUV<WOIICPNDKNL>>? c, [Optional] Id32<DLSISDAFEUV<WOIICPNDKNL>>? d)
		{
			return default((Id32<FXJTAPCMHIX<KGGAHYYTTGC>>, Id32<FXJTAPCMHIX<WOIICPNDKNL>>, Id32<FXJTAPCMHIX<DLSISDAFEUV<WOIICPNDKNL>>>, Id32<FXJTAPCMHIX<DLSISDAFEUV<WOIICPNDKNL>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x28B10F0", Offset = "0x28B04F0", VA = "0x1828B10F0")]
		public static (Id32<FXJTAPCMHIX<KGGAHYYTTGC>>, Id32<FXJTAPCMHIX<DLSISDAFEUV<WOIICPNDKNL>>>, Id32<FXJTAPCMHIX<DLSISDAFEUV<WOIICPNDKNL>>>, Id32<FXJTAPCMHIX<DLSISDAFEUV<WOIICPNDKNL>>>) BRBOOWBJSXX(this UnsafeList<byte> a, [Optional] Id32<DLSISDAFEUV<WOIICPNDKNL>>? b, [Optional] Id32<DLSISDAFEUV<WOIICPNDKNL>>? c, [Optional] Id32<DLSISDAFEUV<WOIICPNDKNL>>? d)
		{
			return default((Id32<FXJTAPCMHIX<KGGAHYYTTGC>>, Id32<FXJTAPCMHIX<DLSISDAFEUV<WOIICPNDKNL>>>, Id32<FXJTAPCMHIX<DLSISDAFEUV<WOIICPNDKNL>>>, Id32<FXJTAPCMHIX<DLSISDAFEUV<WOIICPNDKNL>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x28B1D80", Offset = "0x28B1180", VA = "0x1828B1D80")]
		public static (Id32<FXJTAPCMHIX<KGGAHYYTTGC>>, Id32<FXJTAPCMHIX<COKCDXEUNKE>>, Id32<FXJTAPCMHIX<COKCDXEUNKE>>, Id32<FXJTAPCMHIX<DLSISDAFEUV<WOIICPNDKNL>>>) GBKRODOAUVL(this UnsafeList<byte> a, float b, float c, [Optional] Id32<DLSISDAFEUV<WOIICPNDKNL>>? d)
		{
			return default((Id32<FXJTAPCMHIX<KGGAHYYTTGC>>, Id32<FXJTAPCMHIX<COKCDXEUNKE>>, Id32<FXJTAPCMHIX<COKCDXEUNKE>>, Id32<FXJTAPCMHIX<DLSISDAFEUV<WOIICPNDKNL>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x28B2420", Offset = "0x28B1820", VA = "0x1828B2420")]
		public static (Id32<FXJTAPCMHIX<KGGAHYYTTGC>>, Id32<FXJTAPCMHIX<COKCDXEUNKE>>, Id32<FXJTAPCMHIX<DLSISDAFEUV<COKCDXEUNKE>>>, Id32<FXJTAPCMHIX<DLSISDAFEUV<WOIICPNDKNL>>>) HEQLUNKDSZY(this UnsafeList<byte> a, float b, [Optional] Id32<DLSISDAFEUV<COKCDXEUNKE>>? c, [Optional] Id32<DLSISDAFEUV<WOIICPNDKNL>>? d)
		{
			return default((Id32<FXJTAPCMHIX<KGGAHYYTTGC>>, Id32<FXJTAPCMHIX<COKCDXEUNKE>>, Id32<FXJTAPCMHIX<DLSISDAFEUV<COKCDXEUNKE>>>, Id32<FXJTAPCMHIX<DLSISDAFEUV<WOIICPNDKNL>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x28B6420", Offset = "0x28B5820", VA = "0x1828B6420")]
		public static (Id32<FXJTAPCMHIX<KGGAHYYTTGC>>, Id32<FXJTAPCMHIX<DLSISDAFEUV<COKCDXEUNKE>>>, Id32<FXJTAPCMHIX<DLSISDAFEUV<COKCDXEUNKE>>>, Id32<FXJTAPCMHIX<DLSISDAFEUV<WOIICPNDKNL>>>) YSVOUYVRZGX(this UnsafeList<byte> a, [Optional] Id32<DLSISDAFEUV<COKCDXEUNKE>>? b, [Optional] Id32<DLSISDAFEUV<COKCDXEUNKE>>? c, [Optional] Id32<DLSISDAFEUV<WOIICPNDKNL>>? d)
		{
			return default((Id32<FXJTAPCMHIX<KGGAHYYTTGC>>, Id32<FXJTAPCMHIX<DLSISDAFEUV<COKCDXEUNKE>>>, Id32<FXJTAPCMHIX<DLSISDAFEUV<COKCDXEUNKE>>>, Id32<FXJTAPCMHIX<DLSISDAFEUV<WOIICPNDKNL>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x28B37C0", Offset = "0x28B2BC0", VA = "0x1828B37C0")]
		public static (Id32<FXJTAPCMHIX<KGGAHYYTTGC>>, Id32<FXJTAPCMHIX<WOIICPNDKNL>>, Id32<FXJTAPCMHIX<WOIICPNDKNL>>, Id32<FXJTAPCMHIX<DLSISDAFEUV<WOIICPNDKNL>>>) NAETKRXWCEI(this UnsafeList<byte> a, int b, int c, [Optional] Id32<DLSISDAFEUV<WOIICPNDKNL>>? d)
		{
			return default((Id32<FXJTAPCMHIX<KGGAHYYTTGC>>, Id32<FXJTAPCMHIX<WOIICPNDKNL>>, Id32<FXJTAPCMHIX<WOIICPNDKNL>>, Id32<FXJTAPCMHIX<DLSISDAFEUV<WOIICPNDKNL>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x28B3B90", Offset = "0x28B2F90", VA = "0x1828B3B90")]
		public static (Id32<FXJTAPCMHIX<KGGAHYYTTGC>>, Id32<FXJTAPCMHIX<WOIICPNDKNL>>, Id32<FXJTAPCMHIX<DLSISDAFEUV<WOIICPNDKNL>>>, Id32<FXJTAPCMHIX<DLSISDAFEUV<WOIICPNDKNL>>>) OTPYLBSLPYT(this UnsafeList<byte> a, int b, [Optional] Id32<DLSISDAFEUV<WOIICPNDKNL>>? c, [Optional] Id32<DLSISDAFEUV<WOIICPNDKNL>>? d)
		{
			return default((Id32<FXJTAPCMHIX<KGGAHYYTTGC>>, Id32<FXJTAPCMHIX<WOIICPNDKNL>>, Id32<FXJTAPCMHIX<DLSISDAFEUV<WOIICPNDKNL>>>, Id32<FXJTAPCMHIX<DLSISDAFEUV<WOIICPNDKNL>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x28B2CD0", Offset = "0x28B20D0", VA = "0x1828B2CD0")]
		public static (Id32<FXJTAPCMHIX<KGGAHYYTTGC>>, Id32<FXJTAPCMHIX<DLSISDAFEUV<WOIICPNDKNL>>>, Id32<FXJTAPCMHIX<DLSISDAFEUV<WOIICPNDKNL>>>, Id32<FXJTAPCMHIX<DLSISDAFEUV<WOIICPNDKNL>>>) LCHHNKLMQBQ(this UnsafeList<byte> a, [Optional] Id32<DLSISDAFEUV<WOIICPNDKNL>>? b, [Optional] Id32<DLSISDAFEUV<WOIICPNDKNL>>? c, [Optional] Id32<DLSISDAFEUV<WOIICPNDKNL>>? d)
		{
			return default((Id32<FXJTAPCMHIX<KGGAHYYTTGC>>, Id32<FXJTAPCMHIX<DLSISDAFEUV<WOIICPNDKNL>>>, Id32<FXJTAPCMHIX<DLSISDAFEUV<WOIICPNDKNL>>>, Id32<FXJTAPCMHIX<DLSISDAFEUV<WOIICPNDKNL>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x28B5F40", Offset = "0x28B5340", VA = "0x1828B5F40")]
		public static (Id32<FXJTAPCMHIX<KGGAHYYTTGC>>, Id32<FXJTAPCMHIX<COKCDXEUNKE>>, Id32<FXJTAPCMHIX<COKCDXEUNKE>>, Id32<FXJTAPCMHIX<DLSISDAFEUV<WOIICPNDKNL>>>) WYFXYPOTZFT(this UnsafeList<byte> a, float b, float c, [Optional] Id32<DLSISDAFEUV<WOIICPNDKNL>>? d)
		{
			return default((Id32<FXJTAPCMHIX<KGGAHYYTTGC>>, Id32<FXJTAPCMHIX<COKCDXEUNKE>>, Id32<FXJTAPCMHIX<COKCDXEUNKE>>, Id32<FXJTAPCMHIX<DLSISDAFEUV<WOIICPNDKNL>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x28B3A30", Offset = "0x28B2E30", VA = "0x1828B3A30")]
		public static (Id32<FXJTAPCMHIX<KGGAHYYTTGC>>, Id32<FXJTAPCMHIX<COKCDXEUNKE>>, Id32<FXJTAPCMHIX<DLSISDAFEUV<COKCDXEUNKE>>>, Id32<FXJTAPCMHIX<DLSISDAFEUV<WOIICPNDKNL>>>) NHVMAJRQTES(this UnsafeList<byte> a, float b, [Optional] Id32<DLSISDAFEUV<COKCDXEUNKE>>? c, [Optional] Id32<DLSISDAFEUV<WOIICPNDKNL>>? d)
		{
			return default((Id32<FXJTAPCMHIX<KGGAHYYTTGC>>, Id32<FXJTAPCMHIX<COKCDXEUNKE>>, Id32<FXJTAPCMHIX<DLSISDAFEUV<COKCDXEUNKE>>>, Id32<FXJTAPCMHIX<DLSISDAFEUV<WOIICPNDKNL>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x28B1F00", Offset = "0x28B1300", VA = "0x1828B1F00")]
		public static (Id32<FXJTAPCMHIX<KGGAHYYTTGC>>, Id32<FXJTAPCMHIX<DLSISDAFEUV<COKCDXEUNKE>>>, Id32<FXJTAPCMHIX<DLSISDAFEUV<COKCDXEUNKE>>>, Id32<FXJTAPCMHIX<DLSISDAFEUV<WOIICPNDKNL>>>) GQIXQVCLYJB(this UnsafeList<byte> a, [Optional] Id32<DLSISDAFEUV<COKCDXEUNKE>>? b, [Optional] Id32<DLSISDAFEUV<COKCDXEUNKE>>? c, [Optional] Id32<DLSISDAFEUV<WOIICPNDKNL>>? d)
		{
			return default((Id32<FXJTAPCMHIX<KGGAHYYTTGC>>, Id32<FXJTAPCMHIX<DLSISDAFEUV<COKCDXEUNKE>>>, Id32<FXJTAPCMHIX<DLSISDAFEUV<COKCDXEUNKE>>>, Id32<FXJTAPCMHIX<DLSISDAFEUV<WOIICPNDKNL>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x28B1AC0", Offset = "0x28B0EC0", VA = "0x1828B1AC0")]
		public static (Id32<FXJTAPCMHIX<KGGAHYYTTGC>>, Id32<FXJTAPCMHIX<WOIICPNDKNL>>, Id32<FXJTAPCMHIX<WOIICPNDKNL>>, Id32<FXJTAPCMHIX<DLSISDAFEUV<WOIICPNDKNL>>>) ETWYENOTWJK(this UnsafeList<byte> a, int b, int c, [Optional] Id32<DLSISDAFEUV<WOIICPNDKNL>>? d)
		{
			return default((Id32<FXJTAPCMHIX<KGGAHYYTTGC>>, Id32<FXJTAPCMHIX<WOIICPNDKNL>>, Id32<FXJTAPCMHIX<WOIICPNDKNL>>, Id32<FXJTAPCMHIX<DLSISDAFEUV<WOIICPNDKNL>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x28B4520", Offset = "0x28B3920", VA = "0x1828B4520")]
		public static (Id32<FXJTAPCMHIX<KGGAHYYTTGC>>, Id32<FXJTAPCMHIX<WOIICPNDKNL>>, Id32<FXJTAPCMHIX<DLSISDAFEUV<WOIICPNDKNL>>>, Id32<FXJTAPCMHIX<DLSISDAFEUV<WOIICPNDKNL>>>) QOWHSNYSBYP(this UnsafeList<byte> a, int b, [Optional] Id32<DLSISDAFEUV<WOIICPNDKNL>>? c, [Optional] Id32<DLSISDAFEUV<WOIICPNDKNL>>? d)
		{
			return default((Id32<FXJTAPCMHIX<KGGAHYYTTGC>>, Id32<FXJTAPCMHIX<WOIICPNDKNL>>, Id32<FXJTAPCMHIX<DLSISDAFEUV<WOIICPNDKNL>>>, Id32<FXJTAPCMHIX<DLSISDAFEUV<WOIICPNDKNL>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x28B2BB0", Offset = "0x28B1FB0", VA = "0x1828B2BB0")]
		public static (Id32<FXJTAPCMHIX<KGGAHYYTTGC>>, Id32<FXJTAPCMHIX<DLSISDAFEUV<WOIICPNDKNL>>>, Id32<FXJTAPCMHIX<DLSISDAFEUV<WOIICPNDKNL>>>, Id32<FXJTAPCMHIX<DLSISDAFEUV<WOIICPNDKNL>>>) KMXDAIKVFRA(this UnsafeList<byte> a, [Optional] Id32<DLSISDAFEUV<WOIICPNDKNL>>? b, [Optional] Id32<DLSISDAFEUV<WOIICPNDKNL>>? c, [Optional] Id32<DLSISDAFEUV<WOIICPNDKNL>>? d)
		{
			return default((Id32<FXJTAPCMHIX<KGGAHYYTTGC>>, Id32<FXJTAPCMHIX<DLSISDAFEUV<WOIICPNDKNL>>>, Id32<FXJTAPCMHIX<DLSISDAFEUV<WOIICPNDKNL>>>, Id32<FXJTAPCMHIX<DLSISDAFEUV<WOIICPNDKNL>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x28B26A0", Offset = "0x28B1AA0", VA = "0x1828B26A0")]
		public static (Id32<FXJTAPCMHIX<KGGAHYYTTGC>>, Id32<FXJTAPCMHIX<COKCDXEUNKE>>, Id32<FXJTAPCMHIX<COKCDXEUNKE>>, Id32<FXJTAPCMHIX<DLSISDAFEUV<WOIICPNDKNL>>>) HVWZSUEQOJC(this UnsafeList<byte> a, float b, float c, [Optional] Id32<DLSISDAFEUV<WOIICPNDKNL>>? d)
		{
			return default((Id32<FXJTAPCMHIX<KGGAHYYTTGC>>, Id32<FXJTAPCMHIX<COKCDXEUNKE>>, Id32<FXJTAPCMHIX<COKCDXEUNKE>>, Id32<FXJTAPCMHIX<DLSISDAFEUV<WOIICPNDKNL>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x28B1370", Offset = "0x28B0770", VA = "0x1828B1370")]
		public static (Id32<FXJTAPCMHIX<KGGAHYYTTGC>>, Id32<FXJTAPCMHIX<COKCDXEUNKE>>, Id32<FXJTAPCMHIX<DLSISDAFEUV<COKCDXEUNKE>>>, Id32<FXJTAPCMHIX<DLSISDAFEUV<WOIICPNDKNL>>>) DKWXYZFRDVN(this UnsafeList<byte> a, float b, [Optional] Id32<DLSISDAFEUV<COKCDXEUNKE>>? c, [Optional] Id32<DLSISDAFEUV<WOIICPNDKNL>>? d)
		{
			return default((Id32<FXJTAPCMHIX<KGGAHYYTTGC>>, Id32<FXJTAPCMHIX<COKCDXEUNKE>>, Id32<FXJTAPCMHIX<DLSISDAFEUV<COKCDXEUNKE>>>, Id32<FXJTAPCMHIX<DLSISDAFEUV<WOIICPNDKNL>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x28B3F40", Offset = "0x28B3340", VA = "0x1828B3F40")]
		public static (Id32<FXJTAPCMHIX<KGGAHYYTTGC>>, Id32<FXJTAPCMHIX<DLSISDAFEUV<COKCDXEUNKE>>>, Id32<FXJTAPCMHIX<DLSISDAFEUV<COKCDXEUNKE>>>, Id32<FXJTAPCMHIX<DLSISDAFEUV<WOIICPNDKNL>>>) PIHOSEJJGDI(this UnsafeList<byte> a, [Optional] Id32<DLSISDAFEUV<COKCDXEUNKE>>? b, [Optional] Id32<DLSISDAFEUV<COKCDXEUNKE>>? c, [Optional] Id32<DLSISDAFEUV<WOIICPNDKNL>>? d)
		{
			return default((Id32<FXJTAPCMHIX<KGGAHYYTTGC>>, Id32<FXJTAPCMHIX<DLSISDAFEUV<COKCDXEUNKE>>>, Id32<FXJTAPCMHIX<DLSISDAFEUV<COKCDXEUNKE>>>, Id32<FXJTAPCMHIX<DLSISDAFEUV<WOIICPNDKNL>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x28B3360", Offset = "0x28B2760", VA = "0x1828B3360")]
		public static (Id32<FXJTAPCMHIX<KGGAHYYTTGC>>, Id32<FXJTAPCMHIX<WOIICPNDKNL>>, Id32<FXJTAPCMHIX<WOIICPNDKNL>>, Id32<FXJTAPCMHIX<DLSISDAFEUV<WOIICPNDKNL>>>) MNJXXGTMTZD(this UnsafeList<byte> a, int b, int c, [Optional] Id32<DLSISDAFEUV<WOIICPNDKNL>>? d)
		{
			return default((Id32<FXJTAPCMHIX<KGGAHYYTTGC>>, Id32<FXJTAPCMHIX<WOIICPNDKNL>>, Id32<FXJTAPCMHIX<WOIICPNDKNL>>, Id32<FXJTAPCMHIX<DLSISDAFEUV<WOIICPNDKNL>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x28B4070", Offset = "0x28B3470", VA = "0x1828B4070")]
		public static (Id32<FXJTAPCMHIX<KGGAHYYTTGC>>, Id32<FXJTAPCMHIX<WOIICPNDKNL>>, Id32<FXJTAPCMHIX<DLSISDAFEUV<WOIICPNDKNL>>>, Id32<FXJTAPCMHIX<DLSISDAFEUV<WOIICPNDKNL>>>) PMNUOZUANWO(this UnsafeList<byte> a, int b, [Optional] Id32<DLSISDAFEUV<WOIICPNDKNL>>? c, [Optional] Id32<DLSISDAFEUV<WOIICPNDKNL>>? d)
		{
			return default((Id32<FXJTAPCMHIX<KGGAHYYTTGC>>, Id32<FXJTAPCMHIX<WOIICPNDKNL>>, Id32<FXJTAPCMHIX<DLSISDAFEUV<WOIICPNDKNL>>>, Id32<FXJTAPCMHIX<DLSISDAFEUV<WOIICPNDKNL>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x28B4F40", Offset = "0x28B4340", VA = "0x1828B4F40")]
		public static (Id32<FXJTAPCMHIX<KGGAHYYTTGC>>, Id32<FXJTAPCMHIX<DLSISDAFEUV<WOIICPNDKNL>>>, Id32<FXJTAPCMHIX<DLSISDAFEUV<WOIICPNDKNL>>>, Id32<FXJTAPCMHIX<DLSISDAFEUV<WOIICPNDKNL>>>) TKBAHWWMFSD(this UnsafeList<byte> a, [Optional] Id32<DLSISDAFEUV<WOIICPNDKNL>>? b, [Optional] Id32<DLSISDAFEUV<WOIICPNDKNL>>? c, [Optional] Id32<DLSISDAFEUV<WOIICPNDKNL>>? d)
		{
			return default((Id32<FXJTAPCMHIX<KGGAHYYTTGC>>, Id32<FXJTAPCMHIX<DLSISDAFEUV<WOIICPNDKNL>>>, Id32<FXJTAPCMHIX<DLSISDAFEUV<WOIICPNDKNL>>>, Id32<FXJTAPCMHIX<DLSISDAFEUV<WOIICPNDKNL>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x28B5DC0", Offset = "0x28B51C0", VA = "0x1828B5DC0")]
		public static (Id32<FXJTAPCMHIX<KGGAHYYTTGC>>, Id32<FXJTAPCMHIX<COKCDXEUNKE>>, Id32<FXJTAPCMHIX<COKCDXEUNKE>>, Id32<FXJTAPCMHIX<DLSISDAFEUV<COKCDXEUNKE>>>) WQOZIEKMABF(this UnsafeList<byte> a, float b, float c, [Optional] Id32<DLSISDAFEUV<COKCDXEUNKE>>? d)
		{
			return default((Id32<FXJTAPCMHIX<KGGAHYYTTGC>>, Id32<FXJTAPCMHIX<COKCDXEUNKE>>, Id32<FXJTAPCMHIX<COKCDXEUNKE>>, Id32<FXJTAPCMHIX<DLSISDAFEUV<COKCDXEUNKE>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x28B5910", Offset = "0x28B4D10", VA = "0x1828B5910")]
		public static (Id32<FXJTAPCMHIX<KGGAHYYTTGC>>, Id32<FXJTAPCMHIX<COKCDXEUNKE>>, Id32<FXJTAPCMHIX<DLSISDAFEUV<COKCDXEUNKE>>>, Id32<FXJTAPCMHIX<DLSISDAFEUV<COKCDXEUNKE>>>) WFASCLZVQNW(this UnsafeList<byte> a, float b, [Optional] Id32<DLSISDAFEUV<COKCDXEUNKE>>? c, [Optional] Id32<DLSISDAFEUV<COKCDXEUNKE>>? d)
		{
			return default((Id32<FXJTAPCMHIX<KGGAHYYTTGC>>, Id32<FXJTAPCMHIX<COKCDXEUNKE>>, Id32<FXJTAPCMHIX<DLSISDAFEUV<COKCDXEUNKE>>>, Id32<FXJTAPCMHIX<DLSISDAFEUV<COKCDXEUNKE>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x28B1850", Offset = "0x28B0C50", VA = "0x1828B1850")]
		public static (Id32<FXJTAPCMHIX<KGGAHYYTTGC>>, Id32<FXJTAPCMHIX<DLSISDAFEUV<COKCDXEUNKE>>>, Id32<FXJTAPCMHIX<DLSISDAFEUV<COKCDXEUNKE>>>, Id32<FXJTAPCMHIX<DLSISDAFEUV<COKCDXEUNKE>>>) EKVAXXUDFBH(this UnsafeList<byte> a, [Optional] Id32<DLSISDAFEUV<COKCDXEUNKE>>? b, [Optional] Id32<DLSISDAFEUV<COKCDXEUNKE>>? c, [Optional] Id32<DLSISDAFEUV<COKCDXEUNKE>>? d)
		{
			return default((Id32<FXJTAPCMHIX<KGGAHYYTTGC>>, Id32<FXJTAPCMHIX<DLSISDAFEUV<COKCDXEUNKE>>>, Id32<FXJTAPCMHIX<DLSISDAFEUV<COKCDXEUNKE>>>, Id32<FXJTAPCMHIX<DLSISDAFEUV<COKCDXEUNKE>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x28B5560", Offset = "0x28B4960", VA = "0x1828B5560")]
		public static (Id32<FXJTAPCMHIX<KGGAHYYTTGC>>, Id32<FXJTAPCMHIX<WOIICPNDKNL>>, Id32<FXJTAPCMHIX<WOIICPNDKNL>>, Id32<FXJTAPCMHIX<DLSISDAFEUV<WOIICPNDKNL>>>) UZSOBCJGYHP(this UnsafeList<byte> a, int b, int c, [Optional] Id32<DLSISDAFEUV<WOIICPNDKNL>>? d)
		{
			return default((Id32<FXJTAPCMHIX<KGGAHYYTTGC>>, Id32<FXJTAPCMHIX<WOIICPNDKNL>>, Id32<FXJTAPCMHIX<WOIICPNDKNL>>, Id32<FXJTAPCMHIX<DLSISDAFEUV<WOIICPNDKNL>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x28B1970", Offset = "0x28B0D70", VA = "0x1828B1970")]
		public static (Id32<FXJTAPCMHIX<KGGAHYYTTGC>>, Id32<FXJTAPCMHIX<WOIICPNDKNL>>, Id32<FXJTAPCMHIX<DLSISDAFEUV<WOIICPNDKNL>>>, Id32<FXJTAPCMHIX<DLSISDAFEUV<WOIICPNDKNL>>>) ENJDEMBJQNQ(this UnsafeList<byte> a, int b, [Optional] Id32<DLSISDAFEUV<WOIICPNDKNL>>? c, [Optional] Id32<DLSISDAFEUV<WOIICPNDKNL>>? d)
		{
			return default((Id32<FXJTAPCMHIX<KGGAHYYTTGC>>, Id32<FXJTAPCMHIX<WOIICPNDKNL>>, Id32<FXJTAPCMHIX<DLSISDAFEUV<WOIICPNDKNL>>>, Id32<FXJTAPCMHIX<DLSISDAFEUV<WOIICPNDKNL>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x28B2580", Offset = "0x28B1980", VA = "0x1828B2580")]
		public static (Id32<FXJTAPCMHIX<KGGAHYYTTGC>>, Id32<FXJTAPCMHIX<DLSISDAFEUV<WOIICPNDKNL>>>, Id32<FXJTAPCMHIX<DLSISDAFEUV<WOIICPNDKNL>>>, Id32<FXJTAPCMHIX<DLSISDAFEUV<WOIICPNDKNL>>>) HHNJIHZKVYT(this UnsafeList<byte> a, [Optional] Id32<DLSISDAFEUV<WOIICPNDKNL>>? b, [Optional] Id32<DLSISDAFEUV<WOIICPNDKNL>>? c, [Optional] Id32<DLSISDAFEUV<WOIICPNDKNL>>? d)
		{
			return default((Id32<FXJTAPCMHIX<KGGAHYYTTGC>>, Id32<FXJTAPCMHIX<DLSISDAFEUV<WOIICPNDKNL>>>, Id32<FXJTAPCMHIX<DLSISDAFEUV<WOIICPNDKNL>>>, Id32<FXJTAPCMHIX<DLSISDAFEUV<WOIICPNDKNL>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x28B5A60", Offset = "0x28B4E60", VA = "0x1828B5A60")]
		public static (Id32<FXJTAPCMHIX<KGGAHYYTTGC>>, Id32<FXJTAPCMHIX<WOIICPNDKNL>>, Id32<FXJTAPCMHIX<DLSISDAFEUV<WOIICPNDKNL>>>) WIBEFODXPJY(this UnsafeList<byte> a, [Optional] int? b, [Optional] Id32<DLSISDAFEUV<WOIICPNDKNL>>? c)
		{
			return default((Id32<FXJTAPCMHIX<KGGAHYYTTGC>>, Id32<FXJTAPCMHIX<WOIICPNDKNL>>, Id32<FXJTAPCMHIX<DLSISDAFEUV<WOIICPNDKNL>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x28B3CE0", Offset = "0x28B30E0", VA = "0x1828B3CE0")]
		public static (Id32<FXJTAPCMHIX<KGGAHYYTTGC>>, Id32<FXJTAPCMHIX<DLSISDAFEUV<WOIICPNDKNL>>>, Id32<FXJTAPCMHIX<DLSISDAFEUV<WOIICPNDKNL>>>) PBUIZMQNKIB(this UnsafeList<byte> a, [Optional] Id32<DLSISDAFEUV<WOIICPNDKNL>>? b, [Optional] Id32<DLSISDAFEUV<WOIICPNDKNL>>? c)
		{
			return default((Id32<FXJTAPCMHIX<KGGAHYYTTGC>>, Id32<FXJTAPCMHIX<DLSISDAFEUV<WOIICPNDKNL>>>, Id32<FXJTAPCMHIX<DLSISDAFEUV<WOIICPNDKNL>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x28B60C0", Offset = "0x28B54C0", VA = "0x1828B60C0")]
		public static Id32<FXJTAPCMHIX<KGGAHYYTTGC>> XZWWJVIFNGI(this UnsafeList<byte> a)
		{
			return default(Id32<FXJTAPCMHIX<KGGAHYYTTGC>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x28B34C0", Offset = "0x28B28C0", VA = "0x1828B34C0")]
		public static (Id32<FXJTAPCMHIX<KGGAHYYTTGC>>, Id32<FXJTAPCMHIX<COKCDXEUNKE>>, Id32<FXJTAPCMHIX<COKCDXEUNKE>>, Id32<FXJTAPCMHIX<DLSISDAFEUV<COKCDXEUNKE>>>) MRSZJSAEXLB(this UnsafeList<byte> a, float b, float c, [Optional] Id32<DLSISDAFEUV<COKCDXEUNKE>>? d)
		{
			return default((Id32<FXJTAPCMHIX<KGGAHYYTTGC>>, Id32<FXJTAPCMHIX<COKCDXEUNKE>>, Id32<FXJTAPCMHIX<COKCDXEUNKE>>, Id32<FXJTAPCMHIX<DLSISDAFEUV<COKCDXEUNKE>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x28B2DF0", Offset = "0x28B21F0", VA = "0x1828B2DF0")]
		public static (Id32<FXJTAPCMHIX<KGGAHYYTTGC>>, Id32<FXJTAPCMHIX<COKCDXEUNKE>>, Id32<FXJTAPCMHIX<DLSISDAFEUV<COKCDXEUNKE>>>, Id32<FXJTAPCMHIX<DLSISDAFEUV<COKCDXEUNKE>>>) LSASDNNSLAQ(this UnsafeList<byte> a, float b, [Optional] Id32<DLSISDAFEUV<COKCDXEUNKE>>? c, [Optional] Id32<DLSISDAFEUV<COKCDXEUNKE>>? d)
		{
			return default((Id32<FXJTAPCMHIX<KGGAHYYTTGC>>, Id32<FXJTAPCMHIX<COKCDXEUNKE>>, Id32<FXJTAPCMHIX<DLSISDAFEUV<COKCDXEUNKE>>>, Id32<FXJTAPCMHIX<DLSISDAFEUV<COKCDXEUNKE>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x28B5440", Offset = "0x28B4840", VA = "0x1828B5440")]
		public static (Id32<FXJTAPCMHIX<KGGAHYYTTGC>>, Id32<FXJTAPCMHIX<DLSISDAFEUV<COKCDXEUNKE>>>, Id32<FXJTAPCMHIX<DLSISDAFEUV<COKCDXEUNKE>>>, Id32<FXJTAPCMHIX<DLSISDAFEUV<COKCDXEUNKE>>>) UOWPKWROCLD(this UnsafeList<byte> a, [Optional] Id32<DLSISDAFEUV<COKCDXEUNKE>>? b, [Optional] Id32<DLSISDAFEUV<COKCDXEUNKE>>? c, [Optional] Id32<DLSISDAFEUV<COKCDXEUNKE>>? d)
		{
			return default((Id32<FXJTAPCMHIX<KGGAHYYTTGC>>, Id32<FXJTAPCMHIX<DLSISDAFEUV<COKCDXEUNKE>>>, Id32<FXJTAPCMHIX<DLSISDAFEUV<COKCDXEUNKE>>>, Id32<FXJTAPCMHIX<DLSISDAFEUV<COKCDXEUNKE>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x28B52E0", Offset = "0x28B46E0", VA = "0x1828B52E0")]
		public static (Id32<FXJTAPCMHIX<KGGAHYYTTGC>>, Id32<FXJTAPCMHIX<WOIICPNDKNL>>, Id32<FXJTAPCMHIX<WOIICPNDKNL>>, Id32<FXJTAPCMHIX<DLSISDAFEUV<WOIICPNDKNL>>>) UGUQGTOJVFD(this UnsafeList<byte> a, int b, int c, [Optional] Id32<DLSISDAFEUV<WOIICPNDKNL>>? d)
		{
			return default((Id32<FXJTAPCMHIX<KGGAHYYTTGC>>, Id32<FXJTAPCMHIX<WOIICPNDKNL>>, Id32<FXJTAPCMHIX<WOIICPNDKNL>>, Id32<FXJTAPCMHIX<DLSISDAFEUV<WOIICPNDKNL>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x28B22D0", Offset = "0x28B16D0", VA = "0x1828B22D0")]
		public static (Id32<FXJTAPCMHIX<KGGAHYYTTGC>>, Id32<FXJTAPCMHIX<WOIICPNDKNL>>, Id32<FXJTAPCMHIX<DLSISDAFEUV<WOIICPNDKNL>>>, Id32<FXJTAPCMHIX<DLSISDAFEUV<WOIICPNDKNL>>>) HCYZVYRTAMG(this UnsafeList<byte> a, int b, [Optional] Id32<DLSISDAFEUV<WOIICPNDKNL>>? c, [Optional] Id32<DLSISDAFEUV<WOIICPNDKNL>>? d)
		{
			return default((Id32<FXJTAPCMHIX<KGGAHYYTTGC>>, Id32<FXJTAPCMHIX<WOIICPNDKNL>>, Id32<FXJTAPCMHIX<DLSISDAFEUV<WOIICPNDKNL>>>, Id32<FXJTAPCMHIX<DLSISDAFEUV<WOIICPNDKNL>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x28B4CC0", Offset = "0x28B40C0", VA = "0x1828B4CC0")]
		public static (Id32<FXJTAPCMHIX<KGGAHYYTTGC>>, Id32<FXJTAPCMHIX<DLSISDAFEUV<WOIICPNDKNL>>>, Id32<FXJTAPCMHIX<DLSISDAFEUV<WOIICPNDKNL>>>, Id32<FXJTAPCMHIX<DLSISDAFEUV<WOIICPNDKNL>>>) SGMIYNKHQWP(this UnsafeList<byte> a, [Optional] Id32<DLSISDAFEUV<WOIICPNDKNL>>? b, [Optional] Id32<DLSISDAFEUV<WOIICPNDKNL>>? c, [Optional] Id32<DLSISDAFEUV<WOIICPNDKNL>>? d)
		{
			return default((Id32<FXJTAPCMHIX<KGGAHYYTTGC>>, Id32<FXJTAPCMHIX<DLSISDAFEUV<WOIICPNDKNL>>>, Id32<FXJTAPCMHIX<DLSISDAFEUV<WOIICPNDKNL>>>, Id32<FXJTAPCMHIX<DLSISDAFEUV<WOIICPNDKNL>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x28B5C60", Offset = "0x28B5060", VA = "0x1828B5C60")]
		public static (Id32<FXJTAPCMHIX<KGGAHYYTTGC>>, Id32<FXJTAPCMHIX<WOIICPNDKNL>>, Id32<FXJTAPCMHIX<WOIICPNDKNL>>, Id32<FXJTAPCMHIX<DLSISDAFEUV<WOIICPNDKNL>>>) WOXUHXHLNOU(this UnsafeList<byte> a, int b, int c, [Optional] Id32<DLSISDAFEUV<WOIICPNDKNL>>? d)
		{
			return default((Id32<FXJTAPCMHIX<KGGAHYYTTGC>>, Id32<FXJTAPCMHIX<WOIICPNDKNL>>, Id32<FXJTAPCMHIX<WOIICPNDKNL>>, Id32<FXJTAPCMHIX<DLSISDAFEUV<WOIICPNDKNL>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x28B5190", Offset = "0x28B4590", VA = "0x1828B5190")]
		public static (Id32<FXJTAPCMHIX<KGGAHYYTTGC>>, Id32<FXJTAPCMHIX<WOIICPNDKNL>>, Id32<FXJTAPCMHIX<DLSISDAFEUV<WOIICPNDKNL>>>, Id32<FXJTAPCMHIX<DLSISDAFEUV<WOIICPNDKNL>>>) TYQYWWBHCZB(this UnsafeList<byte> a, int b, [Optional] Id32<DLSISDAFEUV<WOIICPNDKNL>>? c, [Optional] Id32<DLSISDAFEUV<WOIICPNDKNL>>? d)
		{
			return default((Id32<FXJTAPCMHIX<KGGAHYYTTGC>>, Id32<FXJTAPCMHIX<WOIICPNDKNL>>, Id32<FXJTAPCMHIX<DLSISDAFEUV<WOIICPNDKNL>>>, Id32<FXJTAPCMHIX<DLSISDAFEUV<WOIICPNDKNL>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x28B2970", Offset = "0x28B1D70", VA = "0x1828B2970")]
		public static (Id32<FXJTAPCMHIX<KGGAHYYTTGC>>, Id32<FXJTAPCMHIX<DLSISDAFEUV<WOIICPNDKNL>>>, Id32<FXJTAPCMHIX<DLSISDAFEUV<WOIICPNDKNL>>>, Id32<FXJTAPCMHIX<DLSISDAFEUV<WOIICPNDKNL>>>) JMTJBSHZJJI(this UnsafeList<byte> a, [Optional] Id32<DLSISDAFEUV<WOIICPNDKNL>>? b, [Optional] Id32<DLSISDAFEUV<WOIICPNDKNL>>? c, [Optional] Id32<DLSISDAFEUV<WOIICPNDKNL>>? d)
		{
			return default((Id32<FXJTAPCMHIX<KGGAHYYTTGC>>, Id32<FXJTAPCMHIX<DLSISDAFEUV<WOIICPNDKNL>>>, Id32<FXJTAPCMHIX<DLSISDAFEUV<WOIICPNDKNL>>>, Id32<FXJTAPCMHIX<DLSISDAFEUV<WOIICPNDKNL>>>));
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
