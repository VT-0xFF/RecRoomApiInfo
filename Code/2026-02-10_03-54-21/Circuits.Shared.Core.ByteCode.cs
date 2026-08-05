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
		[Cpp2IlInjected.Address(RVA = "0xAE0820", Offset = "0xADFA20", VA = "0x180AE0820")]
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
		[Cpp2IlInjected.Address(RVA = "0x28FCC70", Offset = "0x28FBE70", VA = "0x1828FCC70")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xAE0A40", Offset = "0xADFC40", VA = "0x180AE0A40")]
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
		[Cpp2IlInjected.Address(RVA = "0xAE0A80", Offset = "0xADFC80", VA = "0x180AE0A80")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
namespace Circuits.Shared.Core.ByteCode
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public static class UQAGWEKRRTJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x3BFBAE0", Offset = "0x3BFACE0", VA = "0x183BFBAE0")]
		public static Id32<VNZZUSDPSXP<a>> SHYQVOSVQDB<a>(this int a)
		{
			return default(Id32<VNZZUSDPSXP<a>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x28FCE00", Offset = "0x28FC000", VA = "0x1828FCE00")]
		public static Id32<SYLDEMURFRQ> CQCJXYYOJHW(this int a)
		{
			return default(Id32<SYLDEMURFRQ>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x3BFBAE0", Offset = "0x3BFACE0", VA = "0x183BFBAE0")]
		public static Id32<MVLILCSWAQD<b>> DBXLXDETJUF<b>(this int a)
		{
			return default(Id32<MVLILCSWAQD<b>>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public sealed class VNZZUSDPSXP<a>
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public sealed class PGBJJZOTRYG
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public sealed class NFLUJZJCFXF
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public sealed class SYLDEMURFRQ
	{
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public sealed class MMYRGMCMOOI
	{
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public sealed class SMRIUYFBFWW
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
	public static class ACVOPBFENVH
	{
		[Cpp2IlInjected.Token(Token = "0x200000E")]
		public readonly struct ProcessOpDelegate<TContext, TDeps, TCompileState>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000091")]
			private readonly IntPtr _impl;

			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0xC504D0", Offset = "0xC4F6D0", VA = "0x180C504D0")]
			public ProcessOpDelegate(IntPtr impl)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x5C4CE20", Offset = "0x5C4C020", VA = "0x185C4CE20")]
			public int Invoke(TDeps deps, TContext ctx, TCompileState compileState, [In] UnsafeList<byte> fromByteCode, int byteCodePtr)
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x30A2790", Offset = "0x30A1990", VA = "0x1830A2790")]
		public static void GUQWNQURTXY<TDeps, TContext, TCompileState>(TDeps a, TContext b, TCompileState c, [In] UnsafeList<byte> oldByteCode, UnsafeList<byte> newByteCode, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processAddF32_F32i_F32i_F32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processAddF32_F32i_F32r_F32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processAddF32_F32r_F32r_F32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processAddI32_I32i_I32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processAddI32_I32i_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processAddI32_I32r_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processAndI32_I32i_I32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processAndI32_I32i_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processAndI32_I32r_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfEqualF32_F32i_F32i_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfEqualF32_F32i_F32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfEqualF32_F32r_F32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfEqualI32_I32i_I32i_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfEqualI32_I32i_I32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfEqualI32_I32r_I32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfGreaterOrEqualF32_F32i_F32i_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfGreaterOrEqualF32_F32i_F32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfGreaterOrEqualF32_F32r_F32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfGreaterOrEqualI32_I32i_I32i_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfGreaterOrEqualI32_I32i_I32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfGreaterOrEqualI32_I32r_I32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfLessF32_F32i_F32i_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfLessF32_F32i_F32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfLessF32_F32r_F32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfLessI32_I32i_I32i_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfLessI32_I32i_I32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfLessI32_I32r_I32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfLessOrEqualF32_F32i_F32i_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfLessOrEqualF32_F32i_F32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfLessOrEqualF32_F32r_F32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfLessOrEqualI32_I32i_I32i_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfLessOrEqualI32_I32i_I32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfLessOrEqualI32_I32r_I32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfNotEqualF32_F32i_F32i_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfNotEqualF32_F32i_F32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfNotEqualF32_F32r_F32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfNotEqualI32_I32i_I32i_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfNotEqualI32_I32i_I32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfNotEqualI32_I32r_I32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfNotZeroF32_F32i_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfNotZeroF32_F32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfNotZeroI32_I32i_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfNotZeroI32_I32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfZeroF32_F32i_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfZeroF32_F32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfZeroI32_I32i_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfZeroI32_I32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processCallInternal_I32i_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processCallInternal_I32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processCallExternal_I32i_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processCallExternal_I32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processCallRuntime_I32i_I32i_Xi, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processCopyI32_I32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processCopyI32_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processCopyX_Xr_I32i_Xi, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processCopyX_Xr_Xr_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processDivideF32_F32i_F32i_F32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processDivideF32_F32i_F32r_F32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processDivideF32_F32r_F32r_F32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processDivideI32_I32i_I32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processDivideI32_I32i_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processDivideI32_I32r_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processEqualF32_F32i_F32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processEqualF32_F32i_F32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processEqualF32_F32r_F32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processEqualI32_I32i_I32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processEqualI32_I32i_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processEqualI32_I32r_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processEnd, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processGreaterF32_F32i_F32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processGreaterF32_F32i_F32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processGreaterF32_F32r_F32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processGreaterI32_I32i_I32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processGreaterI32_I32i_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processGreaterI32_I32r_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processGreaterOrEqualF32_F32i_F32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processGreaterOrEqualF32_F32i_F32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processGreaterOrEqualF32_F32r_F32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processGreaterOrEqualI32_I32i_I32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processGreaterOrEqualI32_I32i_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processGreaterOrEqualI32_I32r_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processJump_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processJump_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processLessF32_F32i_F32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processLessF32_F32i_F32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processLessF32_F32r_F32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processLessI32_I32i_I32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processLessI32_I32i_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processLessI32_I32r_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processLessOrEqualF32_F32i_F32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processLessOrEqualF32_F32i_F32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processLessOrEqualF32_F32r_F32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processLessOrEqualI32_I32i_I32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processLessOrEqualI32_I32i_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processLessOrEqualI32_I32r_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processModI32_I32i_I32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processModI32_I32i_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processModI32_I32r_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processMultiplyF32_F32i_F32i_F32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processMultiplyF32_F32i_F32r_F32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processMultiplyF32_F32r_F32r_F32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processMultiplyI32_I32i_I32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processMultiplyI32_I32i_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processMultiplyI32_I32r_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processNegateF32_F32i_F32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processNegateF32_F32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processNegateF32_F32r_F32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processNegateI32_I32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processNegateI32_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processNegateI32_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processNoOp, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processNotEqualF32_F32i_F32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processNotEqualF32_F32i_F32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processNotEqualF32_F32r_F32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processNotEqualI32_I32i_I32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processNotEqualI32_I32i_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processNotEqualI32_I32r_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processNotI32_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processNotI32_I32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processNotI32_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processOrI32_I32i_I32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processOrI32_I32i_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processOrI32_I32r_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processReturn, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processStaticCastF32I32_F32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processStaticCastI32F32_I32r_F32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processSubtractF32_F32i_F32i_F32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processSubtractF32_F32i_F32r_F32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processSubtractF32_F32r_F32r_F32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processSubtractI32_I32i_I32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processSubtractI32_I32i_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processSubtractI32_I32r_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processXorI32_I32i_I32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processXorI32_I32i_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processXorI32_I32r_I32r_I32r) where TDeps : notnull where TContext : notnull where TCompileState : notnull
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x28F6800", Offset = "0x28F5A00", VA = "0x1828F6800")]
		private static int TDQVPRDDGNW([In] UnsafeList<byte> from, UnsafeList<byte> a, int b, int c)
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public static class CDWICPIHLPK
	{
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		public static readonly int KNONTIEBGMC;

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x34D25A0", Offset = "0x34D17A0", VA = "0x1834D25A0")]
		public static Id32<VNZZUSDPSXP<a>> GIPWKIECZGA<a>([In] this UnsafeList<byte> self)
		{
			return default(Id32<VNZZUSDPSXP<a>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x34D2710", Offset = "0x34D1910", VA = "0x1834D2710")]
		public static Id32<VNZZUSDPSXP<VNZZUSDPSXP<b>>> NWDSGTSQWDB<b>(this UnsafeList<byte> a, [Optional] Id32<VNZZUSDPSXP<b>>? b)
		{
			return default(Id32<VNZZUSDPSXP<VNZZUSDPSXP<b>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x28F68A0", Offset = "0x28F5AA0", VA = "0x1828F68A0")]
		public static Id32<VNZZUSDPSXP<FDGPVGVZFUQ>> GSLJTWJIDMX(this UnsafeList<byte> a, [Optional] Id32<FDGPVGVZFUQ>? b)
		{
			return default(Id32<VNZZUSDPSXP<FDGPVGVZFUQ>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x28F6990", Offset = "0x28F5B90", VA = "0x1828F6990")]
		public static Id32<VNZZUSDPSXP<PGBJJZOTRYG>> IDTFQTTACKT(this UnsafeList<byte> a, [Optional] float? b)
		{
			return default(Id32<VNZZUSDPSXP<PGBJJZOTRYG>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x28F6B70", Offset = "0x28F5D70", VA = "0x1828F6B70")]
		public static Id32<VNZZUSDPSXP<NFLUJZJCFXF>> NBJHTAZXBVE(this UnsafeList<byte> a, [Optional] int? b)
		{
			return default(Id32<VNZZUSDPSXP<NFLUJZJCFXF>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x28F6C50", Offset = "0x28F5E50", VA = "0x1828F6C50")]
		public static Id32<VNZZUSDPSXP<OTRYTJZBOPP>> PMDWNFTDHUM(this UnsafeList<byte> a, [Optional] Id32<OTRYTJZBOPP>? b)
		{
			return default(Id32<VNZZUSDPSXP<OTRYTJZBOPP>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x28F6D40", Offset = "0x28F5F40", VA = "0x1828F6D40")]
		public static Id32<VNZZUSDPSXP<SMRIUYFBFWW>> WFRHJIIJWMR(this UnsafeList<byte> a, [Optional] byte? b)
		{
			return default(Id32<VNZZUSDPSXP<SMRIUYFBFWW>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x28F6E40", Offset = "0x28F6040", VA = "0x1828F6E40")]
		public static Id32<VNZZUSDPSXP<SYLDEMURFRQ>> ZKCNOAFHIYR(this UnsafeList<byte> a, [Optional] Id32<SYLDEMURFRQ>? b)
		{
			return default(Id32<VNZZUSDPSXP<SYLDEMURFRQ>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x28F6A80", Offset = "0x28F5C80", VA = "0x1828F6A80")]
		public static Id32<VNZZUSDPSXP<MMYRGMCMOOI>> LODMMNRNLLZ(this UnsafeList<byte> a, [Optional] Op? b)
		{
			return default(Id32<VNZZUSDPSXP<MMYRGMCMOOI>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x34D2710", Offset = "0x34D1910", VA = "0x1834D2710")]
		public static Id32<VNZZUSDPSXP<MVLILCSWAQD<c>>> OAMZNLOSDZT<c>(this UnsafeList<byte> a, [Optional] Id32<MVLILCSWAQD<c>>? b)
		{
			return default(Id32<VNZZUSDPSXP<MVLILCSWAQD<c>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x28F6650", Offset = "0x28F5850", VA = "0x1828F6650")]
		public static void GGKVQCMUQFV(this UnsafeList<byte> a, Id32<VNZZUSDPSXP<NFLUJZJCFXF>> b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x34D2610", Offset = "0x34D1810", VA = "0x1834D2610")]
		public static void KIPPUFIQHPY<d>(this UnsafeList<byte> a, Id32<VNZZUSDPSXP<VNZZUSDPSXP<d>>> b, Id32<VNZZUSDPSXP<d>> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x34D2610", Offset = "0x34D1810", VA = "0x1834D2610")]
		public static void ZLNRCMULNGQ<e>(this UnsafeList<byte> a, Id32<VNZZUSDPSXP<MVLILCSWAQD<e>>> b, Id32<MVLILCSWAQD<e>> c)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public static class OFVYMITWVKR
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x28FCCF0", Offset = "0x28FBEF0", VA = "0x1828FCCF0")]
		public static Union32 QVAHUUYALJT([In] this ReadOnlySpan<byte> bytes, int a)
		{
			return default(Union32);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x28FCD60", Offset = "0x28FBF60", VA = "0x1828FCD60")]
		public static Union32 QVAHUUYALJT([In] this UnsafeList<byte> bytes, int a)
		{
			return default(Union32);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x3922D60", Offset = "0x3921F60", VA = "0x183922D60")]
		public static Union32 QVAHUUYALJT<f>(this ReadOnlyIdArray<f, byte> a, Id32<f> b)
		{
			return default(Union32);
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x3922EE0", Offset = "0x39220E0", VA = "0x183922EE0")]
		public static Union32 QVAHUUYALJT<g>([In] this ReadOnlyIdSpan<g, byte> bytes, Id32<g> a)
		{
			return default(Union32);
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x3922D00", Offset = "0x3921F00", VA = "0x183922D00")]
		public static Union32 QVAHUUYALJT<i>(this IdArray<i, byte> a, Id32<i> b)
		{
			return default(Union32);
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x3922BD0", Offset = "0x3921DD0", VA = "0x183922BD0")]
		public static Union32 QVAHUUYALJT<j>([In] this IdSpan<j, byte> bytes, Id32<j> a)
		{
			return default(Union32);
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x3922C40", Offset = "0x3921E40", VA = "0x183922C40")]
		public static Union32 QVAHUUYALJT<k>(this ReadOnlyIdArray<k, byte> a, Id32<k> b)
		{
			return default(Union32);
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x28FCCF0", Offset = "0x28FBEF0", VA = "0x1828FCCF0")]
		public static int GRVUMDZRCEG([In] this ReadOnlySpan<byte> bytes, int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x28F6750", Offset = "0x28F5950", VA = "0x1828F6750")]
		public static int GRVUMDZRCEG([In] this UnsafeList<byte> bytes, int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x3922380", Offset = "0x3921580", VA = "0x183922380")]
		public static int GRVUMDZRCEG<p>(this ReadOnlyIdArray<p, byte> a, Id32<p> b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x39222B0", Offset = "0x39214B0", VA = "0x1839222B0")]
		public static int GRVUMDZRCEG<s>(this IdArray<s, byte> a, Id32<s> b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x3922260", Offset = "0x3921460", VA = "0x183922260")]
		public static int GRVUMDZRCEG<t>([In] this IdSpan<t, byte> bytes, Id32<t> a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x3922330", Offset = "0x3921530", VA = "0x183922330")]
		public static int GRVUMDZRCEG<u>(this ReadOnlyIdArray<u, byte> a, Id32<u> b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x39239B0", Offset = "0x3922BB0", VA = "0x1839239B0")]
		public static float YKMTMQDXOID<bc>(this IdArray<bc, byte> a, Id32<bc> b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x3923A30", Offset = "0x3922C30", VA = "0x183923A30")]
		public static float YKMTMQDXOID<bd>([In] this IdSpan<bd, byte> bytes, Id32<bd> a)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x3923960", Offset = "0x3922B60", VA = "0x183923960")]
		public static float YKMTMQDXOID<be>(this ReadOnlyIdArray<be, byte> a, Id32<be> b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x3923210", Offset = "0x3922410", VA = "0x183923210")]
		public static byte UGWFFSRQEND<bj>(this ReadOnlyIdArray<bj, byte> a, Id32<bj> b)
		{
			return default(byte);
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x3923260", Offset = "0x3922460", VA = "0x183923260")]
		public static byte UGWFFSRQEND<bk>([In] this ReadOnlyIdSpan<bk, byte> bytes, Id32<bk> a)
		{
			return default(byte);
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x3923190", Offset = "0x3922390", VA = "0x183923190")]
		public static byte UGWFFSRQEND<bm>(this IdArray<bm, byte> a, Id32<bm> b)
		{
			return default(byte);
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x3923380", Offset = "0x3922580", VA = "0x183923380")]
		public static byte UGWFFSRQEND<bn>([In] this IdSpan<bn, byte> bytes, Id32<bn> a)
		{
			return default(byte);
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x39232B0", Offset = "0x39224B0", VA = "0x1839232B0")]
		public static byte UGWFFSRQEND<bo>(this ReadOnlyIdArray<bo, byte> a, Id32<bo> b)
		{
			return default(byte);
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x28F6750", Offset = "0x28F5950", VA = "0x1828F6750")]
		public static Op EXYQOOKMHRB([In] this UnsafeList<byte> bytes, int a)
		{
			return default(Op);
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x3922160", Offset = "0x3921360", VA = "0x183922160")]
		public static Op EXYQOOKMHRB<by>(this ReadOnlyIdArray<by, byte> a, Id32<by> b)
		{
			return default(Op);
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x39226F0", Offset = "0x39218F0", VA = "0x1839226F0")]
		public static Id32<VNZZUSDPSXP<FQPBODQMINB>> OQWPEDPRLEX<cg>(this IdArray<cg, byte> a, Id32<cg> b)
		{
			return default(Id32<VNZZUSDPSXP<FQPBODQMINB>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x3922660", Offset = "0x3921860", VA = "0x183922660")]
		public static Id32<VNZZUSDPSXP<FQPBODQMINB>> OQWPEDPRLEX<ch>([In] this IdSpan<ch, byte> bytes, Id32<ch> a)
		{
			return default(Id32<VNZZUSDPSXP<FQPBODQMINB>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x3922770", Offset = "0x3921970", VA = "0x183922770")]
		public static Id32<VNZZUSDPSXP<FQPBODQMINB>> OQWPEDPRLEX<ci>(this ReadOnlyIdArray<ci, byte> a, Id32<ci> b)
		{
			return default(Id32<VNZZUSDPSXP<FQPBODQMINB>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x3922450", Offset = "0x3921650", VA = "0x183922450")]
		public static Id32<MVLILCSWAQD<FQPBODQMINB>> HOTMUZDQMBD<cs>(this ReadOnlyIdArray<cs, byte> a, Id32<cs> b)
		{
			return default(Id32<MVLILCSWAQD<FQPBODQMINB>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x3923590", Offset = "0x3922790", VA = "0x183923590")]
		public static Id32<SYLDEMURFRQ> VBGINHOAOOR<da>(this IdArray<da, byte> a, Id32<da> b)
		{
			return default(Id32<SYLDEMURFRQ>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x39236A0", Offset = "0x39228A0", VA = "0x1839236A0")]
		public static Id32<SYLDEMURFRQ> VBGINHOAOOR<db>([In] this IdSpan<db, byte> bytes, Id32<db> a)
		{
			return default(Id32<SYLDEMURFRQ>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x3923610", Offset = "0x3922810", VA = "0x183923610")]
		public static Id32<SYLDEMURFRQ> VBGINHOAOOR<dc>(this ReadOnlyIdArray<dc, byte> a, Id32<dc> b)
		{
			return default(Id32<SYLDEMURFRQ>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x3921FF0", Offset = "0x39211F0", VA = "0x183921FF0")]
		public static Id32<FDGPVGVZFUQ> ABIDYMBAZBF<dl>([In] this IdSpan<dl, byte> bytes, Id32<dl> a)
		{
			return default(Id32<FDGPVGVZFUQ>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x3922080", Offset = "0x3921280", VA = "0x183922080")]
		public static Id32<FDGPVGVZFUQ> ABIDYMBAZBF<dm>(this ReadOnlyIdArray<dm, byte> a, Id32<dm> b)
		{
			return default(Id32<FDGPVGVZFUQ>);
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x39237B0", Offset = "0x39229B0", VA = "0x1839237B0")]
		public static Id32<OTRYTJZBOPP> XXMXNKAZDDQ<dw>(this ReadOnlyIdArray<dw, byte> a, Id32<dw> b)
		{
			return default(Id32<OTRYTJZBOPP>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public static class GITOMQBUMFH
	{
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x28FCBB0", Offset = "0x28FBDB0", VA = "0x1828FCBB0")]
		public static void UYSMNOCMLQY(this UnsafeList<byte> a, int b, Union32 c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x28FCB40", Offset = "0x28FBD40", VA = "0x1828FCB40")]
		public static void UYSMNOCMLQY(this byte[] a, int b, Union32 c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x28FCAC0", Offset = "0x28FBCC0", VA = "0x1828FCAC0")]
		public static void UYSMNOCMLQY([In] this Span<byte> bytes, int a, Union32 b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x37336F0", Offset = "0x37328F0", VA = "0x1837336F0")]
		public static void UYSMNOCMLQY<e>(this IdArray<e, byte> a, Id32<e> b, Union32 c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x37335A0", Offset = "0x37327A0", VA = "0x1837335A0")]
		public static void UYSMNOCMLQY<f>([In] this IdSpan<f, byte> bytes, Id32<f> a, Union32 b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x28F6650", Offset = "0x28F5850", VA = "0x1828F6650")]
		public static void GGKVQCMUQFV(this UnsafeList<byte> a, int b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x28FC990", Offset = "0x28FBB90", VA = "0x1828FC990")]
		public static void GGKVQCMUQFV(this byte[] a, int b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x28FC910", Offset = "0x28FBB10", VA = "0x1828FC910")]
		public static void GGKVQCMUQFV([In] this Span<byte> bytes, int a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x3732E00", Offset = "0x3732000", VA = "0x183732E00")]
		public static void GGKVQCMUQFV<h>(this IdArray<h, byte> a, Id32<h> b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x3732E60", Offset = "0x3732060", VA = "0x183732E60")]
		public static void GGKVQCMUQFV<i>([In] this IdSpan<i, byte> bytes, Id32<i> a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x28FCA80", Offset = "0x28FBC80", VA = "0x1828FCA80")]
		public static void RRLAOEGIXUG(this UnsafeList<byte> a, int b, float c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x37332C0", Offset = "0x37324C0", VA = "0x1837332C0")]
		public static void RRLAOEGIXUG<k>(this IdArray<k, byte> a, Id32<k> b, float c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x3733330", Offset = "0x3732530", VA = "0x183733330")]
		public static void RRLAOEGIXUG<l>([In] this IdSpan<l, byte> bytes, Id32<l> a, float b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x28FCA10", Offset = "0x28FBC10", VA = "0x1828FCA10")]
		public static void QHAYSNBCKPI(this UnsafeList<byte> a, int b, byte c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x3733190", Offset = "0x3732390", VA = "0x183733190")]
		public static void QHAYSNBCKPI<n>(this IdArray<n, byte> a, Id32<n> b, byte c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x3733130", Offset = "0x3732330", VA = "0x183733130")]
		public static void QHAYSNBCKPI<o>([In] this IdSpan<o, byte> bytes, Id32<o> a, byte b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x3732F80", Offset = "0x3732180", VA = "0x183732F80")]
		public static void KIPPUFIQHPY<q>(this IdArray<q, byte> a, Id32<q> b, Id32<VNZZUSDPSXP<FQPBODQMINB>> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x3733000", Offset = "0x3732200", VA = "0x183733000")]
		public static void KIPPUFIQHPY<r>([In] this IdSpan<r, byte> bytes, Id32<r> a, Id32<VNZZUSDPSXP<FQPBODQMINB>> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x3732F80", Offset = "0x3732180", VA = "0x183732F80")]
		public static void QZKUVDCYNGO<t>(this IdArray<t, byte> a, Id32<t> b, Id32<SYLDEMURFRQ> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x3733000", Offset = "0x3732200", VA = "0x183733000")]
		public static void QZKUVDCYNGO<u>([In] this IdSpan<u, byte> bytes, Id32<u> a, Id32<SYLDEMURFRQ> b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public static class EKPDAQSFVEA
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x28FA9E0", Offset = "0x28F9BE0", VA = "0x1828FA9E0")]
		public static (Id32<VNZZUSDPSXP<MMYRGMCMOOI>>, Id32<VNZZUSDPSXP<PGBJJZOTRYG>>, Id32<VNZZUSDPSXP<PGBJJZOTRYG>>, Id32<VNZZUSDPSXP<MVLILCSWAQD<PGBJJZOTRYG>>>) PMCXFAEINBA(this UnsafeList<byte> a, float b, float c, [Optional] Id32<MVLILCSWAQD<PGBJJZOTRYG>>? d)
		{
			return default((Id32<VNZZUSDPSXP<MMYRGMCMOOI>>, Id32<VNZZUSDPSXP<PGBJJZOTRYG>>, Id32<VNZZUSDPSXP<PGBJJZOTRYG>>, Id32<VNZZUSDPSXP<MVLILCSWAQD<PGBJJZOTRYG>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x28F86D0", Offset = "0x28F78D0", VA = "0x1828F86D0")]
		public static (Id32<VNZZUSDPSXP<MMYRGMCMOOI>>, Id32<VNZZUSDPSXP<PGBJJZOTRYG>>, Id32<VNZZUSDPSXP<MVLILCSWAQD<PGBJJZOTRYG>>>, Id32<VNZZUSDPSXP<MVLILCSWAQD<PGBJJZOTRYG>>>) GNUEBRTRKYJ(this UnsafeList<byte> a, float b, [Optional] Id32<MVLILCSWAQD<PGBJJZOTRYG>>? c, [Optional] Id32<MVLILCSWAQD<PGBJJZOTRYG>>? d)
		{
			return default((Id32<VNZZUSDPSXP<MMYRGMCMOOI>>, Id32<VNZZUSDPSXP<PGBJJZOTRYG>>, Id32<VNZZUSDPSXP<MVLILCSWAQD<PGBJJZOTRYG>>>, Id32<VNZZUSDPSXP<MVLILCSWAQD<PGBJJZOTRYG>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x28F8130", Offset = "0x28F7330", VA = "0x1828F8130")]
		public static (Id32<VNZZUSDPSXP<MMYRGMCMOOI>>, Id32<VNZZUSDPSXP<MVLILCSWAQD<PGBJJZOTRYG>>>, Id32<VNZZUSDPSXP<MVLILCSWAQD<PGBJJZOTRYG>>>, Id32<VNZZUSDPSXP<MVLILCSWAQD<PGBJJZOTRYG>>>) EBHEPKLFSLO(this UnsafeList<byte> a, [Optional] Id32<MVLILCSWAQD<PGBJJZOTRYG>>? b, [Optional] Id32<MVLILCSWAQD<PGBJJZOTRYG>>? c, [Optional] Id32<MVLILCSWAQD<PGBJJZOTRYG>>? d)
		{
			return default((Id32<VNZZUSDPSXP<MMYRGMCMOOI>>, Id32<VNZZUSDPSXP<MVLILCSWAQD<PGBJJZOTRYG>>>, Id32<VNZZUSDPSXP<MVLILCSWAQD<PGBJJZOTRYG>>>, Id32<VNZZUSDPSXP<MVLILCSWAQD<PGBJJZOTRYG>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x28F8CF0", Offset = "0x28F7EF0", VA = "0x1828F8CF0")]
		public static (Id32<VNZZUSDPSXP<MMYRGMCMOOI>>, Id32<VNZZUSDPSXP<NFLUJZJCFXF>>, Id32<VNZZUSDPSXP<NFLUJZJCFXF>>, Id32<VNZZUSDPSXP<MVLILCSWAQD<NFLUJZJCFXF>>>) IGECYVOSGBK(this UnsafeList<byte> a, int b, int c, [Optional] Id32<MVLILCSWAQD<NFLUJZJCFXF>>? d)
		{
			return default((Id32<VNZZUSDPSXP<MMYRGMCMOOI>>, Id32<VNZZUSDPSXP<NFLUJZJCFXF>>, Id32<VNZZUSDPSXP<NFLUJZJCFXF>>, Id32<VNZZUSDPSXP<MVLILCSWAQD<NFLUJZJCFXF>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x28F99E0", Offset = "0x28F8BE0", VA = "0x1828F99E0")]
		public static (Id32<VNZZUSDPSXP<MMYRGMCMOOI>>, Id32<VNZZUSDPSXP<NFLUJZJCFXF>>, Id32<VNZZUSDPSXP<MVLILCSWAQD<NFLUJZJCFXF>>>, Id32<VNZZUSDPSXP<MVLILCSWAQD<NFLUJZJCFXF>>>) LGGTEEFUSWX(this UnsafeList<byte> a, int b, [Optional] Id32<MVLILCSWAQD<NFLUJZJCFXF>>? c, [Optional] Id32<MVLILCSWAQD<NFLUJZJCFXF>>? d)
		{
			return default((Id32<VNZZUSDPSXP<MMYRGMCMOOI>>, Id32<VNZZUSDPSXP<NFLUJZJCFXF>>, Id32<VNZZUSDPSXP<MVLILCSWAQD<NFLUJZJCFXF>>>, Id32<VNZZUSDPSXP<MVLILCSWAQD<NFLUJZJCFXF>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x28F84A0", Offset = "0x28F76A0", VA = "0x1828F84A0")]
		public static (Id32<VNZZUSDPSXP<MMYRGMCMOOI>>, Id32<VNZZUSDPSXP<MVLILCSWAQD<NFLUJZJCFXF>>>, Id32<VNZZUSDPSXP<MVLILCSWAQD<NFLUJZJCFXF>>>, Id32<VNZZUSDPSXP<MVLILCSWAQD<NFLUJZJCFXF>>>) ELTAJACDNRY(this UnsafeList<byte> a, [Optional] Id32<MVLILCSWAQD<NFLUJZJCFXF>>? b, [Optional] Id32<MVLILCSWAQD<NFLUJZJCFXF>>? c, [Optional] Id32<MVLILCSWAQD<NFLUJZJCFXF>>? d)
		{
			return default((Id32<VNZZUSDPSXP<MMYRGMCMOOI>>, Id32<VNZZUSDPSXP<MVLILCSWAQD<NFLUJZJCFXF>>>, Id32<VNZZUSDPSXP<MVLILCSWAQD<NFLUJZJCFXF>>>, Id32<VNZZUSDPSXP<MVLILCSWAQD<NFLUJZJCFXF>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x28FADF0", Offset = "0x28F9FF0", VA = "0x1828FADF0")]
		public static (Id32<VNZZUSDPSXP<MMYRGMCMOOI>>, Id32<VNZZUSDPSXP<NFLUJZJCFXF>>, Id32<VNZZUSDPSXP<NFLUJZJCFXF>>, Id32<VNZZUSDPSXP<MVLILCSWAQD<NFLUJZJCFXF>>>) RRVUNMOPOYK(this UnsafeList<byte> a, int b, int c, [Optional] Id32<MVLILCSWAQD<NFLUJZJCFXF>>? d)
		{
			return default((Id32<VNZZUSDPSXP<MMYRGMCMOOI>>, Id32<VNZZUSDPSXP<NFLUJZJCFXF>>, Id32<VNZZUSDPSXP<NFLUJZJCFXF>>, Id32<VNZZUSDPSXP<MVLILCSWAQD<NFLUJZJCFXF>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x28F7E90", Offset = "0x28F7090", VA = "0x1828F7E90")]
		public static (Id32<VNZZUSDPSXP<MMYRGMCMOOI>>, Id32<VNZZUSDPSXP<NFLUJZJCFXF>>, Id32<VNZZUSDPSXP<MVLILCSWAQD<NFLUJZJCFXF>>>, Id32<VNZZUSDPSXP<MVLILCSWAQD<NFLUJZJCFXF>>>) DSJHNXAUMDX(this UnsafeList<byte> a, int b, [Optional] Id32<MVLILCSWAQD<NFLUJZJCFXF>>? c, [Optional] Id32<MVLILCSWAQD<NFLUJZJCFXF>>? d)
		{
			return default((Id32<VNZZUSDPSXP<MMYRGMCMOOI>>, Id32<VNZZUSDPSXP<NFLUJZJCFXF>>, Id32<VNZZUSDPSXP<MVLILCSWAQD<NFLUJZJCFXF>>>, Id32<VNZZUSDPSXP<MVLILCSWAQD<NFLUJZJCFXF>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x28F9110", Offset = "0x28F8310", VA = "0x1828F9110")]
		public static (Id32<VNZZUSDPSXP<MMYRGMCMOOI>>, Id32<VNZZUSDPSXP<MVLILCSWAQD<NFLUJZJCFXF>>>, Id32<VNZZUSDPSXP<MVLILCSWAQD<NFLUJZJCFXF>>>, Id32<VNZZUSDPSXP<MVLILCSWAQD<NFLUJZJCFXF>>>) IWMVGELBEJK(this UnsafeList<byte> a, [Optional] Id32<MVLILCSWAQD<NFLUJZJCFXF>>? b, [Optional] Id32<MVLILCSWAQD<NFLUJZJCFXF>>? c, [Optional] Id32<MVLILCSWAQD<NFLUJZJCFXF>>? d)
		{
			return default((Id32<VNZZUSDPSXP<MMYRGMCMOOI>>, Id32<VNZZUSDPSXP<MVLILCSWAQD<NFLUJZJCFXF>>>, Id32<VNZZUSDPSXP<MVLILCSWAQD<NFLUJZJCFXF>>>, Id32<VNZZUSDPSXP<MVLILCSWAQD<NFLUJZJCFXF>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x28F8820", Offset = "0x28F7A20", VA = "0x1828F8820")]
		public static (Id32<VNZZUSDPSXP<MMYRGMCMOOI>>, Id32<VNZZUSDPSXP<NFLUJZJCFXF>>, Id32<VNZZUSDPSXP<VNZZUSDPSXP<MMYRGMCMOOI>>>) GVPLJKZQHVC(this UnsafeList<byte> a, [Optional] int? b, [Optional] Id32<VNZZUSDPSXP<MMYRGMCMOOI>>? c)
		{
			return default((Id32<VNZZUSDPSXP<MMYRGMCMOOI>>, Id32<VNZZUSDPSXP<NFLUJZJCFXF>>, Id32<VNZZUSDPSXP<VNZZUSDPSXP<MMYRGMCMOOI>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x28F9760", Offset = "0x28F8960", VA = "0x1828F9760")]
		public static (Id32<VNZZUSDPSXP<MMYRGMCMOOI>>, Id32<VNZZUSDPSXP<MVLILCSWAQD<NFLUJZJCFXF>>>, Id32<VNZZUSDPSXP<VNZZUSDPSXP<MMYRGMCMOOI>>>) JWPONTRDCET(this UnsafeList<byte> a, [Optional] Id32<MVLILCSWAQD<NFLUJZJCFXF>>? b, [Optional] Id32<VNZZUSDPSXP<MMYRGMCMOOI>>? c)
		{
			return default((Id32<VNZZUSDPSXP<MMYRGMCMOOI>>, Id32<VNZZUSDPSXP<MVLILCSWAQD<NFLUJZJCFXF>>>, Id32<VNZZUSDPSXP<VNZZUSDPSXP<MMYRGMCMOOI>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x28F9B30", Offset = "0x28F8D30", VA = "0x1828F9B30")]
		public static (Id32<VNZZUSDPSXP<MMYRGMCMOOI>>, Id32<VNZZUSDPSXP<NFLUJZJCFXF>>, Id32<VNZZUSDPSXP<VNZZUSDPSXP<MMYRGMCMOOI>>>) LICVUJKJOHL(this UnsafeList<byte> a, [Optional] int? b, [Optional] Id32<VNZZUSDPSXP<MMYRGMCMOOI>>? c)
		{
			return default((Id32<VNZZUSDPSXP<MMYRGMCMOOI>>, Id32<VNZZUSDPSXP<NFLUJZJCFXF>>, Id32<VNZZUSDPSXP<VNZZUSDPSXP<MMYRGMCMOOI>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x28FA040", Offset = "0x28F9240", VA = "0x1828FA040")]
		public static (Id32<VNZZUSDPSXP<MMYRGMCMOOI>>, Id32<VNZZUSDPSXP<MVLILCSWAQD<NFLUJZJCFXF>>>, Id32<VNZZUSDPSXP<VNZZUSDPSXP<MMYRGMCMOOI>>>) MQSUNTEJWHU(this UnsafeList<byte> a, [Optional] Id32<MVLILCSWAQD<NFLUJZJCFXF>>? b, [Optional] Id32<VNZZUSDPSXP<MMYRGMCMOOI>>? c)
		{
			return default((Id32<VNZZUSDPSXP<MMYRGMCMOOI>>, Id32<VNZZUSDPSXP<MVLILCSWAQD<NFLUJZJCFXF>>>, Id32<VNZZUSDPSXP<VNZZUSDPSXP<MMYRGMCMOOI>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x28F8F60", Offset = "0x28F8160", VA = "0x1828F8F60")]
		public static (Id32<VNZZUSDPSXP<MMYRGMCMOOI>>, Id32<VNZZUSDPSXP<NFLUJZJCFXF>>, Id32<VNZZUSDPSXP<FDGPVGVZFUQ>>) IUKFZPJMJNB(this UnsafeList<byte> a, [Optional] int? b, [Optional] Id32<FDGPVGVZFUQ>? c)
		{
			return default((Id32<VNZZUSDPSXP<MMYRGMCMOOI>>, Id32<VNZZUSDPSXP<NFLUJZJCFXF>>, Id32<VNZZUSDPSXP<FDGPVGVZFUQ>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x28F8E50", Offset = "0x28F8050", VA = "0x1828F8E50")]
		public static (Id32<VNZZUSDPSXP<MMYRGMCMOOI>>, Id32<VNZZUSDPSXP<NFLUJZJCFXF>>, Id32<VNZZUSDPSXP<MVLILCSWAQD<FDGPVGVZFUQ>>>) IPTDKPTVAMC(this UnsafeList<byte> a, [Optional] int? b, [Optional] Id32<MVLILCSWAQD<FDGPVGVZFUQ>>? c)
		{
			return default((Id32<VNZZUSDPSXP<MMYRGMCMOOI>>, Id32<VNZZUSDPSXP<NFLUJZJCFXF>>, Id32<VNZZUSDPSXP<MVLILCSWAQD<FDGPVGVZFUQ>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x28F6F70", Offset = "0x28F6170", VA = "0x1828F6F70")]
		public static (Id32<VNZZUSDPSXP<MMYRGMCMOOI>>, Id32<VNZZUSDPSXP<NFLUJZJCFXF>>, Id32<VNZZUSDPSXP<SYLDEMURFRQ>>) AFKSIKZIPOZ(this UnsafeList<byte> a, [Optional] int? b, [Optional] Id32<SYLDEMURFRQ>? c)
		{
			return default((Id32<VNZZUSDPSXP<MMYRGMCMOOI>>, Id32<VNZZUSDPSXP<NFLUJZJCFXF>>, Id32<VNZZUSDPSXP<SYLDEMURFRQ>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x28F72A0", Offset = "0x28F64A0", VA = "0x1828F72A0")]
		public static (Id32<VNZZUSDPSXP<MMYRGMCMOOI>>, Id32<VNZZUSDPSXP<NFLUJZJCFXF>>, Id32<VNZZUSDPSXP<MVLILCSWAQD<SYLDEMURFRQ>>>) AGLAUSUVKTS(this UnsafeList<byte> a, [Optional] int? b, [Optional] Id32<MVLILCSWAQD<SYLDEMURFRQ>>? c)
		{
			return default((Id32<VNZZUSDPSXP<MMYRGMCMOOI>>, Id32<VNZZUSDPSXP<NFLUJZJCFXF>>, Id32<VNZZUSDPSXP<MVLILCSWAQD<SYLDEMURFRQ>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x36297A0", Offset = "0x36289A0", VA = "0x1836297A0")]
		public static (Id32<VNZZUSDPSXP<MMYRGMCMOOI>>, Id32<VNZZUSDPSXP<OTRYTJZBOPP>>, Id32<VNZZUSDPSXP<NFLUJZJCFXF>>, Id32<VNZZUSDPSXP<a>>) LOAKYAQOCOW<a>(this UnsafeList<byte> a, [Optional] Id32<OTRYTJZBOPP>? b, [Optional][In] ReadOnlySpan<byte> data)
		{
			return default((Id32<VNZZUSDPSXP<MMYRGMCMOOI>>, Id32<VNZZUSDPSXP<OTRYTJZBOPP>>, Id32<VNZZUSDPSXP<NFLUJZJCFXF>>, Id32<VNZZUSDPSXP<a>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x28F7C70", Offset = "0x28F6E70", VA = "0x1828F7C70")]
		public static (Id32<VNZZUSDPSXP<MMYRGMCMOOI>>, Id32<VNZZUSDPSXP<NFLUJZJCFXF>>, Id32<VNZZUSDPSXP<MVLILCSWAQD<NFLUJZJCFXF>>>) DJKDWBFRQNK(this UnsafeList<byte> a, int b, [Optional] Id32<MVLILCSWAQD<NFLUJZJCFXF>>? c)
		{
			return default((Id32<VNZZUSDPSXP<MMYRGMCMOOI>>, Id32<VNZZUSDPSXP<NFLUJZJCFXF>>, Id32<VNZZUSDPSXP<MVLILCSWAQD<NFLUJZJCFXF>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x28F85C0", Offset = "0x28F77C0", VA = "0x1828F85C0")]
		public static (Id32<VNZZUSDPSXP<MMYRGMCMOOI>>, Id32<VNZZUSDPSXP<MVLILCSWAQD<NFLUJZJCFXF>>>, Id32<VNZZUSDPSXP<MVLILCSWAQD<NFLUJZJCFXF>>>) GLNCIPYDMBB(this UnsafeList<byte> a, [Optional] Id32<MVLILCSWAQD<NFLUJZJCFXF>>? b, [Optional] Id32<MVLILCSWAQD<NFLUJZJCFXF>>? c)
		{
			return default((Id32<VNZZUSDPSXP<MMYRGMCMOOI>>, Id32<VNZZUSDPSXP<MVLILCSWAQD<NFLUJZJCFXF>>>, Id32<VNZZUSDPSXP<MVLILCSWAQD<NFLUJZJCFXF>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x3629390", Offset = "0x3628590", VA = "0x183629390")]
		public static (Id32<VNZZUSDPSXP<MMYRGMCMOOI>>, Id32<VNZZUSDPSXP<MVLILCSWAQD<b>>>, Id32<VNZZUSDPSXP<NFLUJZJCFXF>>, Id32<VNZZUSDPSXP<b>>) JFOINCSBVUU<b>(this UnsafeList<byte> a, [Optional] Id32<MVLILCSWAQD<b>>? b, [Optional] int? c, [Optional][In] ReadOnlySpan<byte> from)
		{
			return default((Id32<VNZZUSDPSXP<MMYRGMCMOOI>>, Id32<VNZZUSDPSXP<MVLILCSWAQD<b>>>, Id32<VNZZUSDPSXP<NFLUJZJCFXF>>, Id32<VNZZUSDPSXP<b>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x3629060", Offset = "0x3628260", VA = "0x183629060")]
		public static (Id32<VNZZUSDPSXP<MMYRGMCMOOI>>, Id32<VNZZUSDPSXP<MVLILCSWAQD<c>>>, Id32<VNZZUSDPSXP<MVLILCSWAQD<c>>>, Id32<VNZZUSDPSXP<NFLUJZJCFXF>>) FGMIOPEMDEH<c>(this UnsafeList<byte> a, [Optional] Id32<MVLILCSWAQD<c>>? b, [Optional] Id32<MVLILCSWAQD<c>>? c, [Optional] int? d)
		{
			return default((Id32<VNZZUSDPSXP<MMYRGMCMOOI>>, Id32<VNZZUSDPSXP<MVLILCSWAQD<c>>>, Id32<VNZZUSDPSXP<MVLILCSWAQD<c>>>, Id32<VNZZUSDPSXP<NFLUJZJCFXF>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x28F8B70", Offset = "0x28F7D70", VA = "0x1828F8B70")]
		public static (Id32<VNZZUSDPSXP<MMYRGMCMOOI>>, Id32<VNZZUSDPSXP<PGBJJZOTRYG>>, Id32<VNZZUSDPSXP<PGBJJZOTRYG>>, Id32<VNZZUSDPSXP<MVLILCSWAQD<PGBJJZOTRYG>>>) IESJSPAFGIM(this UnsafeList<byte> a, float b, float c, [Optional] Id32<MVLILCSWAQD<PGBJJZOTRYG>>? d)
		{
			return default((Id32<VNZZUSDPSXP<MMYRGMCMOOI>>, Id32<VNZZUSDPSXP<PGBJJZOTRYG>>, Id32<VNZZUSDPSXP<PGBJJZOTRYG>>, Id32<VNZZUSDPSXP<MVLILCSWAQD<PGBJJZOTRYG>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x28F9D90", Offset = "0x28F8F90", VA = "0x1828F9D90")]
		public static (Id32<VNZZUSDPSXP<MMYRGMCMOOI>>, Id32<VNZZUSDPSXP<PGBJJZOTRYG>>, Id32<VNZZUSDPSXP<MVLILCSWAQD<PGBJJZOTRYG>>>, Id32<VNZZUSDPSXP<MVLILCSWAQD<PGBJJZOTRYG>>>) MCBQDBNKXHJ(this UnsafeList<byte> a, float b, [Optional] Id32<MVLILCSWAQD<PGBJJZOTRYG>>? c, [Optional] Id32<MVLILCSWAQD<PGBJJZOTRYG>>? d)
		{
			return default((Id32<VNZZUSDPSXP<MMYRGMCMOOI>>, Id32<VNZZUSDPSXP<PGBJJZOTRYG>>, Id32<VNZZUSDPSXP<MVLILCSWAQD<PGBJJZOTRYG>>>, Id32<VNZZUSDPSXP<MVLILCSWAQD<PGBJJZOTRYG>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x28FB490", Offset = "0x28FA690", VA = "0x1828FB490")]
		public static (Id32<VNZZUSDPSXP<MMYRGMCMOOI>>, Id32<VNZZUSDPSXP<MVLILCSWAQD<PGBJJZOTRYG>>>, Id32<VNZZUSDPSXP<MVLILCSWAQD<PGBJJZOTRYG>>>, Id32<VNZZUSDPSXP<MVLILCSWAQD<PGBJJZOTRYG>>>) THHORAEXHPI(this UnsafeList<byte> a, [Optional] Id32<MVLILCSWAQD<PGBJJZOTRYG>>? b, [Optional] Id32<MVLILCSWAQD<PGBJJZOTRYG>>? c, [Optional] Id32<MVLILCSWAQD<PGBJJZOTRYG>>? d)
		{
			return default((Id32<VNZZUSDPSXP<MMYRGMCMOOI>>, Id32<VNZZUSDPSXP<MVLILCSWAQD<PGBJJZOTRYG>>>, Id32<VNZZUSDPSXP<MVLILCSWAQD<PGBJJZOTRYG>>>, Id32<VNZZUSDPSXP<MVLILCSWAQD<PGBJJZOTRYG>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x28F9380", Offset = "0x28F8580", VA = "0x1828F9380")]
		public static (Id32<VNZZUSDPSXP<MMYRGMCMOOI>>, Id32<VNZZUSDPSXP<NFLUJZJCFXF>>, Id32<VNZZUSDPSXP<NFLUJZJCFXF>>, Id32<VNZZUSDPSXP<MVLILCSWAQD<NFLUJZJCFXF>>>) JIUFGETXDCK(this UnsafeList<byte> a, int b, int c, [Optional] Id32<MVLILCSWAQD<NFLUJZJCFXF>>? d)
		{
			return default((Id32<VNZZUSDPSXP<MMYRGMCMOOI>>, Id32<VNZZUSDPSXP<NFLUJZJCFXF>>, Id32<VNZZUSDPSXP<NFLUJZJCFXF>>, Id32<VNZZUSDPSXP<MVLILCSWAQD<NFLUJZJCFXF>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x28FBDD0", Offset = "0x28FAFD0", VA = "0x1828FBDD0")]
		public static (Id32<VNZZUSDPSXP<MMYRGMCMOOI>>, Id32<VNZZUSDPSXP<NFLUJZJCFXF>>, Id32<VNZZUSDPSXP<MVLILCSWAQD<NFLUJZJCFXF>>>, Id32<VNZZUSDPSXP<MVLILCSWAQD<NFLUJZJCFXF>>>) UZIWVPWAIMV(this UnsafeList<byte> a, int b, [Optional] Id32<MVLILCSWAQD<NFLUJZJCFXF>>? c, [Optional] Id32<MVLILCSWAQD<NFLUJZJCFXF>>? d)
		{
			return default((Id32<VNZZUSDPSXP<MMYRGMCMOOI>>, Id32<VNZZUSDPSXP<NFLUJZJCFXF>>, Id32<VNZZUSDPSXP<MVLILCSWAQD<NFLUJZJCFXF>>>, Id32<VNZZUSDPSXP<MVLILCSWAQD<NFLUJZJCFXF>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x28FA160", Offset = "0x28F9360", VA = "0x1828FA160")]
		public static (Id32<VNZZUSDPSXP<MMYRGMCMOOI>>, Id32<VNZZUSDPSXP<MVLILCSWAQD<NFLUJZJCFXF>>>, Id32<VNZZUSDPSXP<MVLILCSWAQD<NFLUJZJCFXF>>>, Id32<VNZZUSDPSXP<MVLILCSWAQD<NFLUJZJCFXF>>>) MSHFGZJMFQA(this UnsafeList<byte> a, [Optional] Id32<MVLILCSWAQD<NFLUJZJCFXF>>? b, [Optional] Id32<MVLILCSWAQD<NFLUJZJCFXF>>? c, [Optional] Id32<MVLILCSWAQD<NFLUJZJCFXF>>? d)
		{
			return default((Id32<VNZZUSDPSXP<MMYRGMCMOOI>>, Id32<VNZZUSDPSXP<MVLILCSWAQD<NFLUJZJCFXF>>>, Id32<VNZZUSDPSXP<MVLILCSWAQD<NFLUJZJCFXF>>>, Id32<VNZZUSDPSXP<MVLILCSWAQD<NFLUJZJCFXF>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x28FC070", Offset = "0x28FB270", VA = "0x1828FC070")]
		public static (Id32<VNZZUSDPSXP<MMYRGMCMOOI>>, Id32<VNZZUSDPSXP<NFLUJZJCFXF>>, Id32<VNZZUSDPSXP<NFLUJZJCFXF>>, Id32<VNZZUSDPSXP<MVLILCSWAQD<NFLUJZJCFXF>>>) VGIEUUWMASH(this UnsafeList<byte> a, int b, int c, [Optional] Id32<MVLILCSWAQD<NFLUJZJCFXF>>? d)
		{
			return default((Id32<VNZZUSDPSXP<MMYRGMCMOOI>>, Id32<VNZZUSDPSXP<NFLUJZJCFXF>>, Id32<VNZZUSDPSXP<NFLUJZJCFXF>>, Id32<VNZZUSDPSXP<MVLILCSWAQD<NFLUJZJCFXF>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x28FBF20", Offset = "0x28FB120", VA = "0x1828FBF20")]
		public static (Id32<VNZZUSDPSXP<MMYRGMCMOOI>>, Id32<VNZZUSDPSXP<NFLUJZJCFXF>>, Id32<VNZZUSDPSXP<MVLILCSWAQD<NFLUJZJCFXF>>>, Id32<VNZZUSDPSXP<MVLILCSWAQD<NFLUJZJCFXF>>>) VDRYYZNWYME(this UnsafeList<byte> a, int b, [Optional] Id32<MVLILCSWAQD<NFLUJZJCFXF>>? c, [Optional] Id32<MVLILCSWAQD<NFLUJZJCFXF>>? d)
		{
			return default((Id32<VNZZUSDPSXP<MMYRGMCMOOI>>, Id32<VNZZUSDPSXP<NFLUJZJCFXF>>, Id32<VNZZUSDPSXP<MVLILCSWAQD<NFLUJZJCFXF>>>, Id32<VNZZUSDPSXP<MVLILCSWAQD<NFLUJZJCFXF>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x28F8A50", Offset = "0x28F7C50", VA = "0x1828F8A50")]
		public static (Id32<VNZZUSDPSXP<MMYRGMCMOOI>>, Id32<VNZZUSDPSXP<MVLILCSWAQD<NFLUJZJCFXF>>>, Id32<VNZZUSDPSXP<MVLILCSWAQD<NFLUJZJCFXF>>>, Id32<VNZZUSDPSXP<MVLILCSWAQD<NFLUJZJCFXF>>>) HJWFSYSHNXT(this UnsafeList<byte> a, [Optional] Id32<MVLILCSWAQD<NFLUJZJCFXF>>? b, [Optional] Id32<MVLILCSWAQD<NFLUJZJCFXF>>? c, [Optional] Id32<MVLILCSWAQD<NFLUJZJCFXF>>? d)
		{
			return default((Id32<VNZZUSDPSXP<MMYRGMCMOOI>>, Id32<VNZZUSDPSXP<MVLILCSWAQD<NFLUJZJCFXF>>>, Id32<VNZZUSDPSXP<MVLILCSWAQD<NFLUJZJCFXF>>>, Id32<VNZZUSDPSXP<MVLILCSWAQD<NFLUJZJCFXF>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x28F7DA0", Offset = "0x28F6FA0", VA = "0x1828F7DA0")]
		public static (Id32<VNZZUSDPSXP<MMYRGMCMOOI>>, Id32<VNZZUSDPSXP<VNZZUSDPSXP<MMYRGMCMOOI>>>) DOMCFPIXYBC(this UnsafeList<byte> a, [Optional] Id32<VNZZUSDPSXP<MMYRGMCMOOI>>? b)
		{
			return default((Id32<VNZZUSDPSXP<MMYRGMCMOOI>>, Id32<VNZZUSDPSXP<VNZZUSDPSXP<MMYRGMCMOOI>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x28F7120", Offset = "0x28F6320", VA = "0x1828F7120")]
		public static (Id32<VNZZUSDPSXP<MMYRGMCMOOI>>, Id32<VNZZUSDPSXP<PGBJJZOTRYG>>, Id32<VNZZUSDPSXP<PGBJJZOTRYG>>, Id32<VNZZUSDPSXP<MVLILCSWAQD<NFLUJZJCFXF>>>) AFZVRPGRAVK(this UnsafeList<byte> a, float b, float c, [Optional] Id32<MVLILCSWAQD<NFLUJZJCFXF>>? d)
		{
			return default((Id32<VNZZUSDPSXP<MMYRGMCMOOI>>, Id32<VNZZUSDPSXP<PGBJJZOTRYG>>, Id32<VNZZUSDPSXP<PGBJJZOTRYG>>, Id32<VNZZUSDPSXP<MVLILCSWAQD<NFLUJZJCFXF>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x28FBB20", Offset = "0x28FAD20", VA = "0x1828FBB20")]
		public static (Id32<VNZZUSDPSXP<MMYRGMCMOOI>>, Id32<VNZZUSDPSXP<PGBJJZOTRYG>>, Id32<VNZZUSDPSXP<MVLILCSWAQD<PGBJJZOTRYG>>>, Id32<VNZZUSDPSXP<MVLILCSWAQD<NFLUJZJCFXF>>>) UMMYVQEFIIL(this UnsafeList<byte> a, float b, [Optional] Id32<MVLILCSWAQD<PGBJJZOTRYG>>? c, [Optional] Id32<MVLILCSWAQD<NFLUJZJCFXF>>? d)
		{
			return default((Id32<VNZZUSDPSXP<MMYRGMCMOOI>>, Id32<VNZZUSDPSXP<PGBJJZOTRYG>>, Id32<VNZZUSDPSXP<MVLILCSWAQD<PGBJJZOTRYG>>>, Id32<VNZZUSDPSXP<MVLILCSWAQD<NFLUJZJCFXF>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x28F73B0", Offset = "0x28F65B0", VA = "0x1828F73B0")]
		public static (Id32<VNZZUSDPSXP<MMYRGMCMOOI>>, Id32<VNZZUSDPSXP<MVLILCSWAQD<PGBJJZOTRYG>>>, Id32<VNZZUSDPSXP<MVLILCSWAQD<PGBJJZOTRYG>>>, Id32<VNZZUSDPSXP<MVLILCSWAQD<NFLUJZJCFXF>>>) BDZNFETKDEC(this UnsafeList<byte> a, [Optional] Id32<MVLILCSWAQD<PGBJJZOTRYG>>? b, [Optional] Id32<MVLILCSWAQD<PGBJJZOTRYG>>? c, [Optional] Id32<MVLILCSWAQD<NFLUJZJCFXF>>? d)
		{
			return default((Id32<VNZZUSDPSXP<MMYRGMCMOOI>>, Id32<VNZZUSDPSXP<MVLILCSWAQD<PGBJJZOTRYG>>>, Id32<VNZZUSDPSXP<MVLILCSWAQD<PGBJJZOTRYG>>>, Id32<VNZZUSDPSXP<MVLILCSWAQD<NFLUJZJCFXF>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x28F7810", Offset = "0x28F6A10", VA = "0x1828F7810")]
		public static (Id32<VNZZUSDPSXP<MMYRGMCMOOI>>, Id32<VNZZUSDPSXP<NFLUJZJCFXF>>, Id32<VNZZUSDPSXP<NFLUJZJCFXF>>, Id32<VNZZUSDPSXP<MVLILCSWAQD<NFLUJZJCFXF>>>) BUZMBPXUCCN(this UnsafeList<byte> a, int b, int c, [Optional] Id32<MVLILCSWAQD<NFLUJZJCFXF>>? d)
		{
			return default((Id32<VNZZUSDPSXP<MMYRGMCMOOI>>, Id32<VNZZUSDPSXP<NFLUJZJCFXF>>, Id32<VNZZUSDPSXP<NFLUJZJCFXF>>, Id32<VNZZUSDPSXP<MVLILCSWAQD<NFLUJZJCFXF>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x28F9C40", Offset = "0x28F8E40", VA = "0x1828F9C40")]
		public static (Id32<VNZZUSDPSXP<MMYRGMCMOOI>>, Id32<VNZZUSDPSXP<NFLUJZJCFXF>>, Id32<VNZZUSDPSXP<MVLILCSWAQD<NFLUJZJCFXF>>>, Id32<VNZZUSDPSXP<MVLILCSWAQD<NFLUJZJCFXF>>>) LZBNZOQJGHY(this UnsafeList<byte> a, int b, [Optional] Id32<MVLILCSWAQD<NFLUJZJCFXF>>? c, [Optional] Id32<MVLILCSWAQD<NFLUJZJCFXF>>? d)
		{
			return default((Id32<VNZZUSDPSXP<MMYRGMCMOOI>>, Id32<VNZZUSDPSXP<NFLUJZJCFXF>>, Id32<VNZZUSDPSXP<MVLILCSWAQD<NFLUJZJCFXF>>>, Id32<VNZZUSDPSXP<MVLILCSWAQD<NFLUJZJCFXF>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x28FC2F0", Offset = "0x28FB4F0", VA = "0x1828FC2F0")]
		public static (Id32<VNZZUSDPSXP<MMYRGMCMOOI>>, Id32<VNZZUSDPSXP<MVLILCSWAQD<NFLUJZJCFXF>>>, Id32<VNZZUSDPSXP<MVLILCSWAQD<NFLUJZJCFXF>>>, Id32<VNZZUSDPSXP<MVLILCSWAQD<NFLUJZJCFXF>>>) WKZDUSJQZXR(this UnsafeList<byte> a, [Optional] Id32<MVLILCSWAQD<NFLUJZJCFXF>>? b, [Optional] Id32<MVLILCSWAQD<NFLUJZJCFXF>>? c, [Optional] Id32<MVLILCSWAQD<NFLUJZJCFXF>>? d)
		{
			return default((Id32<VNZZUSDPSXP<MMYRGMCMOOI>>, Id32<VNZZUSDPSXP<MVLILCSWAQD<NFLUJZJCFXF>>>, Id32<VNZZUSDPSXP<MVLILCSWAQD<NFLUJZJCFXF>>>, Id32<VNZZUSDPSXP<MVLILCSWAQD<NFLUJZJCFXF>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x28FB5B0", Offset = "0x28FA7B0", VA = "0x1828FB5B0")]
		public static (Id32<VNZZUSDPSXP<MMYRGMCMOOI>>, Id32<VNZZUSDPSXP<PGBJJZOTRYG>>, Id32<VNZZUSDPSXP<PGBJJZOTRYG>>, Id32<VNZZUSDPSXP<MVLILCSWAQD<NFLUJZJCFXF>>>) TPBODHXGERJ(this UnsafeList<byte> a, float b, float c, [Optional] Id32<MVLILCSWAQD<NFLUJZJCFXF>>? d)
		{
			return default((Id32<VNZZUSDPSXP<MMYRGMCMOOI>>, Id32<VNZZUSDPSXP<PGBJJZOTRYG>>, Id32<VNZZUSDPSXP<PGBJJZOTRYG>>, Id32<VNZZUSDPSXP<MVLILCSWAQD<NFLUJZJCFXF>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x28F76B0", Offset = "0x28F68B0", VA = "0x1828F76B0")]
		public static (Id32<VNZZUSDPSXP<MMYRGMCMOOI>>, Id32<VNZZUSDPSXP<PGBJJZOTRYG>>, Id32<VNZZUSDPSXP<MVLILCSWAQD<PGBJJZOTRYG>>>, Id32<VNZZUSDPSXP<MVLILCSWAQD<NFLUJZJCFXF>>>) BLDLZXGQJTS(this UnsafeList<byte> a, float b, [Optional] Id32<MVLILCSWAQD<PGBJJZOTRYG>>? c, [Optional] Id32<MVLILCSWAQD<NFLUJZJCFXF>>? d)
		{
			return default((Id32<VNZZUSDPSXP<MMYRGMCMOOI>>, Id32<VNZZUSDPSXP<PGBJJZOTRYG>>, Id32<VNZZUSDPSXP<MVLILCSWAQD<PGBJJZOTRYG>>>, Id32<VNZZUSDPSXP<MVLILCSWAQD<NFLUJZJCFXF>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x28F8370", Offset = "0x28F7570", VA = "0x1828F8370")]
		public static (Id32<VNZZUSDPSXP<MMYRGMCMOOI>>, Id32<VNZZUSDPSXP<MVLILCSWAQD<PGBJJZOTRYG>>>, Id32<VNZZUSDPSXP<MVLILCSWAQD<PGBJJZOTRYG>>>, Id32<VNZZUSDPSXP<MVLILCSWAQD<NFLUJZJCFXF>>>) EEEPERPUBFH(this UnsafeList<byte> a, [Optional] Id32<MVLILCSWAQD<PGBJJZOTRYG>>? b, [Optional] Id32<MVLILCSWAQD<PGBJJZOTRYG>>? c, [Optional] Id32<MVLILCSWAQD<NFLUJZJCFXF>>? d)
		{
			return default((Id32<VNZZUSDPSXP<MMYRGMCMOOI>>, Id32<VNZZUSDPSXP<MVLILCSWAQD<PGBJJZOTRYG>>>, Id32<VNZZUSDPSXP<MVLILCSWAQD<PGBJJZOTRYG>>>, Id32<VNZZUSDPSXP<MVLILCSWAQD<NFLUJZJCFXF>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x28F9880", Offset = "0x28F8A80", VA = "0x1828F9880")]
		public static (Id32<VNZZUSDPSXP<MMYRGMCMOOI>>, Id32<VNZZUSDPSXP<NFLUJZJCFXF>>, Id32<VNZZUSDPSXP<NFLUJZJCFXF>>, Id32<VNZZUSDPSXP<MVLILCSWAQD<NFLUJZJCFXF>>>) LCXGDELOTUW(this UnsafeList<byte> a, int b, int c, [Optional] Id32<MVLILCSWAQD<NFLUJZJCFXF>>? d)
		{
			return default((Id32<VNZZUSDPSXP<MMYRGMCMOOI>>, Id32<VNZZUSDPSXP<NFLUJZJCFXF>>, Id32<VNZZUSDPSXP<NFLUJZJCFXF>>, Id32<VNZZUSDPSXP<MVLILCSWAQD<NFLUJZJCFXF>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x28FB8B0", Offset = "0x28FAAB0", VA = "0x1828FB8B0")]
		public static (Id32<VNZZUSDPSXP<MMYRGMCMOOI>>, Id32<VNZZUSDPSXP<NFLUJZJCFXF>>, Id32<VNZZUSDPSXP<MVLILCSWAQD<NFLUJZJCFXF>>>, Id32<VNZZUSDPSXP<MVLILCSWAQD<NFLUJZJCFXF>>>) UGKGBHWODQZ(this UnsafeList<byte> a, int b, [Optional] Id32<MVLILCSWAQD<NFLUJZJCFXF>>? c, [Optional] Id32<MVLILCSWAQD<NFLUJZJCFXF>>? d)
		{
			return default((Id32<VNZZUSDPSXP<MMYRGMCMOOI>>, Id32<VNZZUSDPSXP<NFLUJZJCFXF>>, Id32<VNZZUSDPSXP<MVLILCSWAQD<NFLUJZJCFXF>>>, Id32<VNZZUSDPSXP<MVLILCSWAQD<NFLUJZJCFXF>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x28FC7F0", Offset = "0x28FB9F0", VA = "0x1828FC7F0")]
		public static (Id32<VNZZUSDPSXP<MMYRGMCMOOI>>, Id32<VNZZUSDPSXP<MVLILCSWAQD<NFLUJZJCFXF>>>, Id32<VNZZUSDPSXP<MVLILCSWAQD<NFLUJZJCFXF>>>, Id32<VNZZUSDPSXP<MVLILCSWAQD<NFLUJZJCFXF>>>) ZKNTTPGUVWM(this UnsafeList<byte> a, [Optional] Id32<MVLILCSWAQD<NFLUJZJCFXF>>? b, [Optional] Id32<MVLILCSWAQD<NFLUJZJCFXF>>? c, [Optional] Id32<MVLILCSWAQD<NFLUJZJCFXF>>? d)
		{
			return default((Id32<VNZZUSDPSXP<MMYRGMCMOOI>>, Id32<VNZZUSDPSXP<MVLILCSWAQD<NFLUJZJCFXF>>>, Id32<VNZZUSDPSXP<MVLILCSWAQD<NFLUJZJCFXF>>>, Id32<VNZZUSDPSXP<MVLILCSWAQD<NFLUJZJCFXF>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x28FAB60", Offset = "0x28F9D60", VA = "0x1828FAB60")]
		public static (Id32<VNZZUSDPSXP<MMYRGMCMOOI>>, Id32<VNZZUSDPSXP<PGBJJZOTRYG>>, Id32<VNZZUSDPSXP<PGBJJZOTRYG>>, Id32<VNZZUSDPSXP<MVLILCSWAQD<NFLUJZJCFXF>>>) POGXPUTADRF(this UnsafeList<byte> a, float b, float c, [Optional] Id32<MVLILCSWAQD<NFLUJZJCFXF>>? d)
		{
			return default((Id32<VNZZUSDPSXP<MMYRGMCMOOI>>, Id32<VNZZUSDPSXP<PGBJJZOTRYG>>, Id32<VNZZUSDPSXP<PGBJJZOTRYG>>, Id32<VNZZUSDPSXP<MVLILCSWAQD<NFLUJZJCFXF>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x28FA880", Offset = "0x28F9A80", VA = "0x1828FA880")]
		public static (Id32<VNZZUSDPSXP<MMYRGMCMOOI>>, Id32<VNZZUSDPSXP<PGBJJZOTRYG>>, Id32<VNZZUSDPSXP<MVLILCSWAQD<PGBJJZOTRYG>>>, Id32<VNZZUSDPSXP<MVLILCSWAQD<NFLUJZJCFXF>>>) PLQRTZKLBLC(this UnsafeList<byte> a, float b, [Optional] Id32<MVLILCSWAQD<PGBJJZOTRYG>>? c, [Optional] Id32<MVLILCSWAQD<NFLUJZJCFXF>>? d)
		{
			return default((Id32<VNZZUSDPSXP<MMYRGMCMOOI>>, Id32<VNZZUSDPSXP<PGBJJZOTRYG>>, Id32<VNZZUSDPSXP<MVLILCSWAQD<PGBJJZOTRYG>>>, Id32<VNZZUSDPSXP<MVLILCSWAQD<NFLUJZJCFXF>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x28FC6C0", Offset = "0x28FB8C0", VA = "0x1828FC6C0")]
		public static (Id32<VNZZUSDPSXP<MMYRGMCMOOI>>, Id32<VNZZUSDPSXP<MVLILCSWAQD<PGBJJZOTRYG>>>, Id32<VNZZUSDPSXP<MVLILCSWAQD<PGBJJZOTRYG>>>, Id32<VNZZUSDPSXP<MVLILCSWAQD<NFLUJZJCFXF>>>) XGSLNAWCDCV(this UnsafeList<byte> a, [Optional] Id32<MVLILCSWAQD<PGBJJZOTRYG>>? b, [Optional] Id32<MVLILCSWAQD<PGBJJZOTRYG>>? c, [Optional] Id32<MVLILCSWAQD<NFLUJZJCFXF>>? d)
		{
			return default((Id32<VNZZUSDPSXP<MMYRGMCMOOI>>, Id32<VNZZUSDPSXP<MVLILCSWAQD<PGBJJZOTRYG>>>, Id32<VNZZUSDPSXP<MVLILCSWAQD<PGBJJZOTRYG>>>, Id32<VNZZUSDPSXP<MVLILCSWAQD<NFLUJZJCFXF>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x28FC560", Offset = "0x28FB760", VA = "0x1828FC560")]
		public static (Id32<VNZZUSDPSXP<MMYRGMCMOOI>>, Id32<VNZZUSDPSXP<NFLUJZJCFXF>>, Id32<VNZZUSDPSXP<NFLUJZJCFXF>>, Id32<VNZZUSDPSXP<MVLILCSWAQD<NFLUJZJCFXF>>>) XBRCFLWMLSC(this UnsafeList<byte> a, int b, int c, [Optional] Id32<MVLILCSWAQD<NFLUJZJCFXF>>? d)
		{
			return default((Id32<VNZZUSDPSXP<MMYRGMCMOOI>>, Id32<VNZZUSDPSXP<NFLUJZJCFXF>>, Id32<VNZZUSDPSXP<NFLUJZJCFXF>>, Id32<VNZZUSDPSXP<MVLILCSWAQD<NFLUJZJCFXF>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x28F7FE0", Offset = "0x28F71E0", VA = "0x1828F7FE0")]
		public static (Id32<VNZZUSDPSXP<MMYRGMCMOOI>>, Id32<VNZZUSDPSXP<NFLUJZJCFXF>>, Id32<VNZZUSDPSXP<MVLILCSWAQD<NFLUJZJCFXF>>>, Id32<VNZZUSDPSXP<MVLILCSWAQD<NFLUJZJCFXF>>>) DTRHKFDFGQN(this UnsafeList<byte> a, int b, [Optional] Id32<MVLILCSWAQD<NFLUJZJCFXF>>? c, [Optional] Id32<MVLILCSWAQD<NFLUJZJCFXF>>? d)
		{
			return default((Id32<VNZZUSDPSXP<MMYRGMCMOOI>>, Id32<VNZZUSDPSXP<NFLUJZJCFXF>>, Id32<VNZZUSDPSXP<MVLILCSWAQD<NFLUJZJCFXF>>>, Id32<VNZZUSDPSXP<MVLILCSWAQD<NFLUJZJCFXF>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x28FC1D0", Offset = "0x28FB3D0", VA = "0x1828FC1D0")]
		public static (Id32<VNZZUSDPSXP<MMYRGMCMOOI>>, Id32<VNZZUSDPSXP<MVLILCSWAQD<NFLUJZJCFXF>>>, Id32<VNZZUSDPSXP<MVLILCSWAQD<NFLUJZJCFXF>>>, Id32<VNZZUSDPSXP<MVLILCSWAQD<NFLUJZJCFXF>>>) VODVDTOITFG(this UnsafeList<byte> a, [Optional] Id32<MVLILCSWAQD<NFLUJZJCFXF>>? b, [Optional] Id32<MVLILCSWAQD<NFLUJZJCFXF>>? c, [Optional] Id32<MVLILCSWAQD<NFLUJZJCFXF>>? d)
		{
			return default((Id32<VNZZUSDPSXP<MMYRGMCMOOI>>, Id32<VNZZUSDPSXP<MVLILCSWAQD<NFLUJZJCFXF>>>, Id32<VNZZUSDPSXP<MVLILCSWAQD<NFLUJZJCFXF>>>, Id32<VNZZUSDPSXP<MVLILCSWAQD<NFLUJZJCFXF>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x28F7AF0", Offset = "0x28F6CF0", VA = "0x1828F7AF0")]
		public static (Id32<VNZZUSDPSXP<MMYRGMCMOOI>>, Id32<VNZZUSDPSXP<PGBJJZOTRYG>>, Id32<VNZZUSDPSXP<PGBJJZOTRYG>>, Id32<VNZZUSDPSXP<MVLILCSWAQD<NFLUJZJCFXF>>>) CYKTHNHPCIS(this UnsafeList<byte> a, float b, float c, [Optional] Id32<MVLILCSWAQD<NFLUJZJCFXF>>? d)
		{
			return default((Id32<VNZZUSDPSXP<MMYRGMCMOOI>>, Id32<VNZZUSDPSXP<PGBJJZOTRYG>>, Id32<VNZZUSDPSXP<PGBJJZOTRYG>>, Id32<VNZZUSDPSXP<MVLILCSWAQD<NFLUJZJCFXF>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x28FA3A0", Offset = "0x28F95A0", VA = "0x1828FA3A0")]
		public static (Id32<VNZZUSDPSXP<MMYRGMCMOOI>>, Id32<VNZZUSDPSXP<PGBJJZOTRYG>>, Id32<VNZZUSDPSXP<MVLILCSWAQD<PGBJJZOTRYG>>>, Id32<VNZZUSDPSXP<MVLILCSWAQD<NFLUJZJCFXF>>>) OEDBLCUWQSJ(this UnsafeList<byte> a, float b, [Optional] Id32<MVLILCSWAQD<PGBJJZOTRYG>>? c, [Optional] Id32<MVLILCSWAQD<NFLUJZJCFXF>>? d)
		{
			return default((Id32<VNZZUSDPSXP<MMYRGMCMOOI>>, Id32<VNZZUSDPSXP<PGBJJZOTRYG>>, Id32<VNZZUSDPSXP<MVLILCSWAQD<PGBJJZOTRYG>>>, Id32<VNZZUSDPSXP<MVLILCSWAQD<NFLUJZJCFXF>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x28F9630", Offset = "0x28F8830", VA = "0x1828F9630")]
		public static (Id32<VNZZUSDPSXP<MMYRGMCMOOI>>, Id32<VNZZUSDPSXP<MVLILCSWAQD<PGBJJZOTRYG>>>, Id32<VNZZUSDPSXP<MVLILCSWAQD<PGBJJZOTRYG>>>, Id32<VNZZUSDPSXP<MVLILCSWAQD<NFLUJZJCFXF>>>) JRLWHGKYIZK(this UnsafeList<byte> a, [Optional] Id32<MVLILCSWAQD<PGBJJZOTRYG>>? b, [Optional] Id32<MVLILCSWAQD<PGBJJZOTRYG>>? c, [Optional] Id32<MVLILCSWAQD<NFLUJZJCFXF>>? d)
		{
			return default((Id32<VNZZUSDPSXP<MMYRGMCMOOI>>, Id32<VNZZUSDPSXP<MVLILCSWAQD<PGBJJZOTRYG>>>, Id32<VNZZUSDPSXP<MVLILCSWAQD<PGBJJZOTRYG>>>, Id32<VNZZUSDPSXP<MVLILCSWAQD<NFLUJZJCFXF>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x28FB330", Offset = "0x28FA530", VA = "0x1828FB330")]
		public static (Id32<VNZZUSDPSXP<MMYRGMCMOOI>>, Id32<VNZZUSDPSXP<NFLUJZJCFXF>>, Id32<VNZZUSDPSXP<NFLUJZJCFXF>>, Id32<VNZZUSDPSXP<MVLILCSWAQD<NFLUJZJCFXF>>>) SJWWXGMEPCD(this UnsafeList<byte> a, int b, int c, [Optional] Id32<MVLILCSWAQD<NFLUJZJCFXF>>? d)
		{
			return default((Id32<VNZZUSDPSXP<MMYRGMCMOOI>>, Id32<VNZZUSDPSXP<NFLUJZJCFXF>>, Id32<VNZZUSDPSXP<NFLUJZJCFXF>>, Id32<VNZZUSDPSXP<MVLILCSWAQD<NFLUJZJCFXF>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x28FC410", Offset = "0x28FB610", VA = "0x1828FC410")]
		public static (Id32<VNZZUSDPSXP<MMYRGMCMOOI>>, Id32<VNZZUSDPSXP<NFLUJZJCFXF>>, Id32<VNZZUSDPSXP<MVLILCSWAQD<NFLUJZJCFXF>>>, Id32<VNZZUSDPSXP<MVLILCSWAQD<NFLUJZJCFXF>>>) WUWYRBLDZPS(this UnsafeList<byte> a, int b, [Optional] Id32<MVLILCSWAQD<NFLUJZJCFXF>>? c, [Optional] Id32<MVLILCSWAQD<NFLUJZJCFXF>>? d)
		{
			return default((Id32<VNZZUSDPSXP<MMYRGMCMOOI>>, Id32<VNZZUSDPSXP<NFLUJZJCFXF>>, Id32<VNZZUSDPSXP<MVLILCSWAQD<NFLUJZJCFXF>>>, Id32<VNZZUSDPSXP<MVLILCSWAQD<NFLUJZJCFXF>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x28FAF50", Offset = "0x28FA150", VA = "0x1828FAF50")]
		public static (Id32<VNZZUSDPSXP<MMYRGMCMOOI>>, Id32<VNZZUSDPSXP<MVLILCSWAQD<NFLUJZJCFXF>>>, Id32<VNZZUSDPSXP<MVLILCSWAQD<NFLUJZJCFXF>>>, Id32<VNZZUSDPSXP<MVLILCSWAQD<NFLUJZJCFXF>>>) RTKVYQERZHL(this UnsafeList<byte> a, [Optional] Id32<MVLILCSWAQD<NFLUJZJCFXF>>? b, [Optional] Id32<MVLILCSWAQD<NFLUJZJCFXF>>? c, [Optional] Id32<MVLILCSWAQD<NFLUJZJCFXF>>? d)
		{
			return default((Id32<VNZZUSDPSXP<MMYRGMCMOOI>>, Id32<VNZZUSDPSXP<MVLILCSWAQD<NFLUJZJCFXF>>>, Id32<VNZZUSDPSXP<MVLILCSWAQD<NFLUJZJCFXF>>>, Id32<VNZZUSDPSXP<MVLILCSWAQD<NFLUJZJCFXF>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x28FB730", Offset = "0x28FA930", VA = "0x1828FB730")]
		public static (Id32<VNZZUSDPSXP<MMYRGMCMOOI>>, Id32<VNZZUSDPSXP<PGBJJZOTRYG>>, Id32<VNZZUSDPSXP<PGBJJZOTRYG>>, Id32<VNZZUSDPSXP<MVLILCSWAQD<PGBJJZOTRYG>>>) TXITEIBYVCF(this UnsafeList<byte> a, float b, float c, [Optional] Id32<MVLILCSWAQD<PGBJJZOTRYG>>? d)
		{
			return default((Id32<VNZZUSDPSXP<MMYRGMCMOOI>>, Id32<VNZZUSDPSXP<PGBJJZOTRYG>>, Id32<VNZZUSDPSXP<PGBJJZOTRYG>>, Id32<VNZZUSDPSXP<MVLILCSWAQD<PGBJJZOTRYG>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x28FBC80", Offset = "0x28FAE80", VA = "0x1828FBC80")]
		public static (Id32<VNZZUSDPSXP<MMYRGMCMOOI>>, Id32<VNZZUSDPSXP<PGBJJZOTRYG>>, Id32<VNZZUSDPSXP<MVLILCSWAQD<PGBJJZOTRYG>>>, Id32<VNZZUSDPSXP<MVLILCSWAQD<PGBJJZOTRYG>>>) UUNRAUTEJCK(this UnsafeList<byte> a, float b, [Optional] Id32<MVLILCSWAQD<PGBJJZOTRYG>>? c, [Optional] Id32<MVLILCSWAQD<PGBJJZOTRYG>>? d)
		{
			return default((Id32<VNZZUSDPSXP<MMYRGMCMOOI>>, Id32<VNZZUSDPSXP<PGBJJZOTRYG>>, Id32<VNZZUSDPSXP<MVLILCSWAQD<PGBJJZOTRYG>>>, Id32<VNZZUSDPSXP<MVLILCSWAQD<PGBJJZOTRYG>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x28FA280", Offset = "0x28F9480", VA = "0x1828FA280")]
		public static (Id32<VNZZUSDPSXP<MMYRGMCMOOI>>, Id32<VNZZUSDPSXP<MVLILCSWAQD<PGBJJZOTRYG>>>, Id32<VNZZUSDPSXP<MVLILCSWAQD<PGBJJZOTRYG>>>, Id32<VNZZUSDPSXP<MVLILCSWAQD<PGBJJZOTRYG>>>) NOOTSEIBDVV(this UnsafeList<byte> a, [Optional] Id32<MVLILCSWAQD<PGBJJZOTRYG>>? b, [Optional] Id32<MVLILCSWAQD<PGBJJZOTRYG>>? c, [Optional] Id32<MVLILCSWAQD<PGBJJZOTRYG>>? d)
		{
			return default((Id32<VNZZUSDPSXP<MMYRGMCMOOI>>, Id32<VNZZUSDPSXP<MVLILCSWAQD<PGBJJZOTRYG>>>, Id32<VNZZUSDPSXP<MVLILCSWAQD<PGBJJZOTRYG>>>, Id32<VNZZUSDPSXP<MVLILCSWAQD<PGBJJZOTRYG>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x28F9EE0", Offset = "0x28F90E0", VA = "0x1828F9EE0")]
		public static (Id32<VNZZUSDPSXP<MMYRGMCMOOI>>, Id32<VNZZUSDPSXP<NFLUJZJCFXF>>, Id32<VNZZUSDPSXP<NFLUJZJCFXF>>, Id32<VNZZUSDPSXP<MVLILCSWAQD<NFLUJZJCFXF>>>) MCUYYSMHFJV(this UnsafeList<byte> a, int b, int c, [Optional] Id32<MVLILCSWAQD<NFLUJZJCFXF>>? d)
		{
			return default((Id32<VNZZUSDPSXP<MMYRGMCMOOI>>, Id32<VNZZUSDPSXP<NFLUJZJCFXF>>, Id32<VNZZUSDPSXP<NFLUJZJCFXF>>, Id32<VNZZUSDPSXP<MVLILCSWAQD<NFLUJZJCFXF>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x28F9230", Offset = "0x28F8430", VA = "0x1828F9230")]
		public static (Id32<VNZZUSDPSXP<MMYRGMCMOOI>>, Id32<VNZZUSDPSXP<NFLUJZJCFXF>>, Id32<VNZZUSDPSXP<MVLILCSWAQD<NFLUJZJCFXF>>>, Id32<VNZZUSDPSXP<MVLILCSWAQD<NFLUJZJCFXF>>>) JCSITJVESOI(this UnsafeList<byte> a, int b, [Optional] Id32<MVLILCSWAQD<NFLUJZJCFXF>>? c, [Optional] Id32<MVLILCSWAQD<NFLUJZJCFXF>>? d)
		{
			return default((Id32<VNZZUSDPSXP<MMYRGMCMOOI>>, Id32<VNZZUSDPSXP<NFLUJZJCFXF>>, Id32<VNZZUSDPSXP<MVLILCSWAQD<NFLUJZJCFXF>>>, Id32<VNZZUSDPSXP<MVLILCSWAQD<NFLUJZJCFXF>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x28FBA00", Offset = "0x28FAC00", VA = "0x1828FBA00")]
		public static (Id32<VNZZUSDPSXP<MMYRGMCMOOI>>, Id32<VNZZUSDPSXP<MVLILCSWAQD<NFLUJZJCFXF>>>, Id32<VNZZUSDPSXP<MVLILCSWAQD<NFLUJZJCFXF>>>, Id32<VNZZUSDPSXP<MVLILCSWAQD<NFLUJZJCFXF>>>) UIJQEDBQHTL(this UnsafeList<byte> a, [Optional] Id32<MVLILCSWAQD<NFLUJZJCFXF>>? b, [Optional] Id32<MVLILCSWAQD<NFLUJZJCFXF>>? c, [Optional] Id32<MVLILCSWAQD<NFLUJZJCFXF>>? d)
		{
			return default((Id32<VNZZUSDPSXP<MMYRGMCMOOI>>, Id32<VNZZUSDPSXP<MVLILCSWAQD<NFLUJZJCFXF>>>, Id32<VNZZUSDPSXP<MVLILCSWAQD<NFLUJZJCFXF>>>, Id32<VNZZUSDPSXP<MVLILCSWAQD<NFLUJZJCFXF>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x28FA620", Offset = "0x28F9820", VA = "0x1828FA620")]
		public static (Id32<VNZZUSDPSXP<MMYRGMCMOOI>>, Id32<VNZZUSDPSXP<NFLUJZJCFXF>>, Id32<VNZZUSDPSXP<MVLILCSWAQD<NFLUJZJCFXF>>>) PBGSGEQFMMI(this UnsafeList<byte> a, [Optional] int? b, [Optional] Id32<MVLILCSWAQD<NFLUJZJCFXF>>? c)
		{
			return default((Id32<VNZZUSDPSXP<MMYRGMCMOOI>>, Id32<VNZZUSDPSXP<NFLUJZJCFXF>>, Id32<VNZZUSDPSXP<MVLILCSWAQD<NFLUJZJCFXF>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x28FACE0", Offset = "0x28F9EE0", VA = "0x1828FACE0")]
		public static (Id32<VNZZUSDPSXP<MMYRGMCMOOI>>, Id32<VNZZUSDPSXP<MVLILCSWAQD<NFLUJZJCFXF>>>, Id32<VNZZUSDPSXP<MVLILCSWAQD<NFLUJZJCFXF>>>) QURXGOKVAGT(this UnsafeList<byte> a, [Optional] Id32<MVLILCSWAQD<NFLUJZJCFXF>>? b, [Optional] Id32<MVLILCSWAQD<NFLUJZJCFXF>>? c)
		{
			return default((Id32<VNZZUSDPSXP<MMYRGMCMOOI>>, Id32<VNZZUSDPSXP<MVLILCSWAQD<NFLUJZJCFXF>>>, Id32<VNZZUSDPSXP<MVLILCSWAQD<NFLUJZJCFXF>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x28F74E0", Offset = "0x28F66E0", VA = "0x1828F74E0")]
		public static Id32<VNZZUSDPSXP<MMYRGMCMOOI>> BJLDNIWDUTM(this UnsafeList<byte> a)
		{
			return default(Id32<VNZZUSDPSXP<MMYRGMCMOOI>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x28F7970", Offset = "0x28F6B70", VA = "0x1828F7970")]
		public static (Id32<VNZZUSDPSXP<MMYRGMCMOOI>>, Id32<VNZZUSDPSXP<PGBJJZOTRYG>>, Id32<VNZZUSDPSXP<PGBJJZOTRYG>>, Id32<VNZZUSDPSXP<MVLILCSWAQD<PGBJJZOTRYG>>>) CPWXVAFJXRT(this UnsafeList<byte> a, float b, float c, [Optional] Id32<MVLILCSWAQD<PGBJJZOTRYG>>? d)
		{
			return default((Id32<VNZZUSDPSXP<MMYRGMCMOOI>>, Id32<VNZZUSDPSXP<PGBJJZOTRYG>>, Id32<VNZZUSDPSXP<PGBJJZOTRYG>>, Id32<VNZZUSDPSXP<MVLILCSWAQD<PGBJJZOTRYG>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x28F94E0", Offset = "0x28F86E0", VA = "0x1828F94E0")]
		public static (Id32<VNZZUSDPSXP<MMYRGMCMOOI>>, Id32<VNZZUSDPSXP<PGBJJZOTRYG>>, Id32<VNZZUSDPSXP<MVLILCSWAQD<PGBJJZOTRYG>>>, Id32<VNZZUSDPSXP<MVLILCSWAQD<PGBJJZOTRYG>>>) JKOWVOWCSVM(this UnsafeList<byte> a, float b, [Optional] Id32<MVLILCSWAQD<PGBJJZOTRYG>>? c, [Optional] Id32<MVLILCSWAQD<PGBJJZOTRYG>>? d)
		{
			return default((Id32<VNZZUSDPSXP<MMYRGMCMOOI>>, Id32<VNZZUSDPSXP<PGBJJZOTRYG>>, Id32<VNZZUSDPSXP<MVLILCSWAQD<PGBJJZOTRYG>>>, Id32<VNZZUSDPSXP<MVLILCSWAQD<PGBJJZOTRYG>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x28FA500", Offset = "0x28F9700", VA = "0x1828FA500")]
		public static (Id32<VNZZUSDPSXP<MMYRGMCMOOI>>, Id32<VNZZUSDPSXP<MVLILCSWAQD<PGBJJZOTRYG>>>, Id32<VNZZUSDPSXP<MVLILCSWAQD<PGBJJZOTRYG>>>, Id32<VNZZUSDPSXP<MVLILCSWAQD<PGBJJZOTRYG>>>) OHLLJSVAJRB(this UnsafeList<byte> a, [Optional] Id32<MVLILCSWAQD<PGBJJZOTRYG>>? b, [Optional] Id32<MVLILCSWAQD<PGBJJZOTRYG>>? c, [Optional] Id32<MVLILCSWAQD<PGBJJZOTRYG>>? d)
		{
			return default((Id32<VNZZUSDPSXP<MMYRGMCMOOI>>, Id32<VNZZUSDPSXP<MVLILCSWAQD<PGBJJZOTRYG>>>, Id32<VNZZUSDPSXP<MVLILCSWAQD<PGBJJZOTRYG>>>, Id32<VNZZUSDPSXP<MVLILCSWAQD<PGBJJZOTRYG>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x28FB070", Offset = "0x28FA270", VA = "0x1828FB070")]
		public static (Id32<VNZZUSDPSXP<MMYRGMCMOOI>>, Id32<VNZZUSDPSXP<NFLUJZJCFXF>>, Id32<VNZZUSDPSXP<NFLUJZJCFXF>>, Id32<VNZZUSDPSXP<MVLILCSWAQD<NFLUJZJCFXF>>>) RTPVBCDEVAL(this UnsafeList<byte> a, int b, int c, [Optional] Id32<MVLILCSWAQD<NFLUJZJCFXF>>? d)
		{
			return default((Id32<VNZZUSDPSXP<MMYRGMCMOOI>>, Id32<VNZZUSDPSXP<NFLUJZJCFXF>>, Id32<VNZZUSDPSXP<NFLUJZJCFXF>>, Id32<VNZZUSDPSXP<MVLILCSWAQD<NFLUJZJCFXF>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x28FA730", Offset = "0x28F9930", VA = "0x1828FA730")]
		public static (Id32<VNZZUSDPSXP<MMYRGMCMOOI>>, Id32<VNZZUSDPSXP<NFLUJZJCFXF>>, Id32<VNZZUSDPSXP<MVLILCSWAQD<NFLUJZJCFXF>>>, Id32<VNZZUSDPSXP<MVLILCSWAQD<NFLUJZJCFXF>>>) PGHTTEFXXIM(this UnsafeList<byte> a, int b, [Optional] Id32<MVLILCSWAQD<NFLUJZJCFXF>>? c, [Optional] Id32<MVLILCSWAQD<NFLUJZJCFXF>>? d)
		{
			return default((Id32<VNZZUSDPSXP<MMYRGMCMOOI>>, Id32<VNZZUSDPSXP<NFLUJZJCFXF>>, Id32<VNZZUSDPSXP<MVLILCSWAQD<NFLUJZJCFXF>>>, Id32<VNZZUSDPSXP<MVLILCSWAQD<NFLUJZJCFXF>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x28F8250", Offset = "0x28F7450", VA = "0x1828F8250")]
		public static (Id32<VNZZUSDPSXP<MMYRGMCMOOI>>, Id32<VNZZUSDPSXP<MVLILCSWAQD<NFLUJZJCFXF>>>, Id32<VNZZUSDPSXP<MVLILCSWAQD<NFLUJZJCFXF>>>, Id32<VNZZUSDPSXP<MVLILCSWAQD<NFLUJZJCFXF>>>) EDIFZENEYJP(this UnsafeList<byte> a, [Optional] Id32<MVLILCSWAQD<NFLUJZJCFXF>>? b, [Optional] Id32<MVLILCSWAQD<NFLUJZJCFXF>>? c, [Optional] Id32<MVLILCSWAQD<NFLUJZJCFXF>>? d)
		{
			return default((Id32<VNZZUSDPSXP<MMYRGMCMOOI>>, Id32<VNZZUSDPSXP<MVLILCSWAQD<NFLUJZJCFXF>>>, Id32<VNZZUSDPSXP<MVLILCSWAQD<NFLUJZJCFXF>>>, Id32<VNZZUSDPSXP<MVLILCSWAQD<NFLUJZJCFXF>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x28FB1D0", Offset = "0x28FA3D0", VA = "0x1828FB1D0")]
		public static (Id32<VNZZUSDPSXP<MMYRGMCMOOI>>, Id32<VNZZUSDPSXP<NFLUJZJCFXF>>, Id32<VNZZUSDPSXP<NFLUJZJCFXF>>, Id32<VNZZUSDPSXP<MVLILCSWAQD<NFLUJZJCFXF>>>) RUMHKAKJWCC(this UnsafeList<byte> a, int b, int c, [Optional] Id32<MVLILCSWAQD<NFLUJZJCFXF>>? d)
		{
			return default((Id32<VNZZUSDPSXP<MMYRGMCMOOI>>, Id32<VNZZUSDPSXP<NFLUJZJCFXF>>, Id32<VNZZUSDPSXP<NFLUJZJCFXF>>, Id32<VNZZUSDPSXP<MVLILCSWAQD<NFLUJZJCFXF>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x28F7560", Offset = "0x28F6760", VA = "0x1828F7560")]
		public static (Id32<VNZZUSDPSXP<MMYRGMCMOOI>>, Id32<VNZZUSDPSXP<NFLUJZJCFXF>>, Id32<VNZZUSDPSXP<MVLILCSWAQD<NFLUJZJCFXF>>>, Id32<VNZZUSDPSXP<MVLILCSWAQD<NFLUJZJCFXF>>>) BKWTIGHNCDD(this UnsafeList<byte> a, int b, [Optional] Id32<MVLILCSWAQD<NFLUJZJCFXF>>? c, [Optional] Id32<MVLILCSWAQD<NFLUJZJCFXF>>? d)
		{
			return default((Id32<VNZZUSDPSXP<MMYRGMCMOOI>>, Id32<VNZZUSDPSXP<NFLUJZJCFXF>>, Id32<VNZZUSDPSXP<MVLILCSWAQD<NFLUJZJCFXF>>>, Id32<VNZZUSDPSXP<MVLILCSWAQD<NFLUJZJCFXF>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x28F8930", Offset = "0x28F7B30", VA = "0x1828F8930")]
		public static (Id32<VNZZUSDPSXP<MMYRGMCMOOI>>, Id32<VNZZUSDPSXP<MVLILCSWAQD<NFLUJZJCFXF>>>, Id32<VNZZUSDPSXP<MVLILCSWAQD<NFLUJZJCFXF>>>, Id32<VNZZUSDPSXP<MVLILCSWAQD<NFLUJZJCFXF>>>) HDLHSOAOECE(this UnsafeList<byte> a, [Optional] Id32<MVLILCSWAQD<NFLUJZJCFXF>>? b, [Optional] Id32<MVLILCSWAQD<NFLUJZJCFXF>>? c, [Optional] Id32<MVLILCSWAQD<NFLUJZJCFXF>>? d)
		{
			return default((Id32<VNZZUSDPSXP<MMYRGMCMOOI>>, Id32<VNZZUSDPSXP<MVLILCSWAQD<NFLUJZJCFXF>>>, Id32<VNZZUSDPSXP<MVLILCSWAQD<NFLUJZJCFXF>>>, Id32<VNZZUSDPSXP<MVLILCSWAQD<NFLUJZJCFXF>>>));
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
