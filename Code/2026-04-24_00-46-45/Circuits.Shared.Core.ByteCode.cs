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
		[Cpp2IlInjected.Address(RVA = "0xD3AE50", Offset = "0xD39850", VA = "0x180D3AE50")]
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
		[Cpp2IlInjected.Address(RVA = "0x2BAB5B0", Offset = "0x2BA9FB0", VA = "0x182BAB5B0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xD3B3B0", Offset = "0xD39DB0", VA = "0x180D3B3B0")]
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
		[Cpp2IlInjected.Address(RVA = "0xD3B3F0", Offset = "0xD39DF0", VA = "0x180D3B3F0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
namespace Circuits.Shared.Core.ByteCode
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public static class FZJVEQAFKHD
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x3AEB620", Offset = "0x3AEA020", VA = "0x183AEB620")]
		public static Id32<EWICTHMTERF<a>> ZYJADWXNGQJ<a>(this int a)
		{
			return default(Id32<EWICTHMTERF<a>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x2BAB210", Offset = "0x2BA9C10", VA = "0x182BAB210")]
		public static Id32<THWZKYKDWOE> XIUEQAZGFGK(this int a)
		{
			return default(Id32<THWZKYKDWOE>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x3AEB620", Offset = "0x3AEA020", VA = "0x183AEB620")]
		public static Id32<OXBJHRVWJBD<b>> JXIHVBUSHGX<b>(this int a)
		{
			return default(Id32<OXBJHRVWJBD<b>>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public sealed class EWICTHMTERF<a>
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public sealed class LRDRLGWKAMQ
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public sealed class RBMWJAHCKAJ
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public sealed class THWZKYKDWOE
	{
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public sealed class QIRCDDDMPGO
	{
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public sealed class BDLDICASVGU
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
	public static class SCJHMKLORLB
	{
		[Cpp2IlInjected.Token(Token = "0x200000E")]
		public readonly struct ProcessOpDelegate<TContext, TDeps, TCompileState>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000091")]
			private readonly IntPtr _impl;

			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0xEF9580", Offset = "0xEF7F80", VA = "0x180EF9580")]
			public ProcessOpDelegate(IntPtr impl)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x75ACB40", Offset = "0x75AB540", VA = "0x1875ACB40")]
			public int Invoke(TDeps deps, TContext ctx, TCompileState compileState, [In] UnsafeList<byte> fromByteCode, int byteCodePtr)
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x3F17240", Offset = "0x3F15C40", VA = "0x183F17240")]
		public static void ZGOHTZUPVGA<TDeps, TContext, TCompileState>(TDeps a, TContext b, TCompileState c, [In] UnsafeList<byte> oldByteCode, UnsafeList<byte> newByteCode, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processAddF32_F32i_F32i_F32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processAddF32_F32i_F32r_F32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processAddF32_F32r_F32r_F32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processAddI32_I32i_I32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processAddI32_I32i_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processAddI32_I32r_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processAndI32_I32i_I32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processAndI32_I32i_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processAndI32_I32r_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfEqualF32_F32i_F32i_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfEqualF32_F32i_F32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfEqualF32_F32r_F32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfEqualI32_I32i_I32i_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfEqualI32_I32i_I32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfEqualI32_I32r_I32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfGreaterOrEqualF32_F32i_F32i_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfGreaterOrEqualF32_F32i_F32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfGreaterOrEqualF32_F32r_F32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfGreaterOrEqualI32_I32i_I32i_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfGreaterOrEqualI32_I32i_I32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfGreaterOrEqualI32_I32r_I32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfLessF32_F32i_F32i_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfLessF32_F32i_F32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfLessF32_F32r_F32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfLessI32_I32i_I32i_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfLessI32_I32i_I32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfLessI32_I32r_I32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfLessOrEqualF32_F32i_F32i_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfLessOrEqualF32_F32i_F32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfLessOrEqualF32_F32r_F32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfLessOrEqualI32_I32i_I32i_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfLessOrEqualI32_I32i_I32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfLessOrEqualI32_I32r_I32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfNotEqualF32_F32i_F32i_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfNotEqualF32_F32i_F32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfNotEqualF32_F32r_F32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfNotEqualI32_I32i_I32i_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfNotEqualI32_I32i_I32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfNotEqualI32_I32r_I32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfNotZeroF32_F32i_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfNotZeroF32_F32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfNotZeroI32_I32i_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfNotZeroI32_I32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfZeroF32_F32i_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfZeroF32_F32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfZeroI32_I32i_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfZeroI32_I32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processCallInternal_I32i_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processCallInternal_I32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processCallExternal_I32i_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processCallExternal_I32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processCallRuntime_I32i_I32i_Xi, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processCopyI32_I32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processCopyI32_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processCopyX_Xr_I32i_Xi, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processCopyX_Xr_Xr_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processDivideF32_F32i_F32i_F32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processDivideF32_F32i_F32r_F32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processDivideF32_F32r_F32r_F32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processDivideI32_I32i_I32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processDivideI32_I32i_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processDivideI32_I32r_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processEqualF32_F32i_F32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processEqualF32_F32i_F32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processEqualF32_F32r_F32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processEqualI32_I32i_I32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processEqualI32_I32i_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processEqualI32_I32r_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processEnd, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processGreaterF32_F32i_F32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processGreaterF32_F32i_F32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processGreaterF32_F32r_F32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processGreaterI32_I32i_I32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processGreaterI32_I32i_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processGreaterI32_I32r_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processGreaterOrEqualF32_F32i_F32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processGreaterOrEqualF32_F32i_F32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processGreaterOrEqualF32_F32r_F32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processGreaterOrEqualI32_I32i_I32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processGreaterOrEqualI32_I32i_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processGreaterOrEqualI32_I32r_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processJump_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processJump_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processLessF32_F32i_F32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processLessF32_F32i_F32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processLessF32_F32r_F32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processLessI32_I32i_I32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processLessI32_I32i_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processLessI32_I32r_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processLessOrEqualF32_F32i_F32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processLessOrEqualF32_F32i_F32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processLessOrEqualF32_F32r_F32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processLessOrEqualI32_I32i_I32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processLessOrEqualI32_I32i_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processLessOrEqualI32_I32r_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processModI32_I32i_I32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processModI32_I32i_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processModI32_I32r_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processMultiplyF32_F32i_F32i_F32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processMultiplyF32_F32i_F32r_F32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processMultiplyF32_F32r_F32r_F32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processMultiplyI32_I32i_I32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processMultiplyI32_I32i_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processMultiplyI32_I32r_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processNegateF32_F32i_F32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processNegateF32_F32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processNegateF32_F32r_F32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processNegateI32_I32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processNegateI32_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processNegateI32_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processNoOp, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processNotEqualF32_F32i_F32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processNotEqualF32_F32i_F32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processNotEqualF32_F32r_F32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processNotEqualI32_I32i_I32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processNotEqualI32_I32i_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processNotEqualI32_I32r_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processNotI32_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processNotI32_I32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processNotI32_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processOrI32_I32i_I32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processOrI32_I32i_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processOrI32_I32r_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processReturn, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processStaticCastF32I32_F32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processStaticCastI32F32_I32r_F32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processSubtractF32_F32i_F32i_F32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processSubtractF32_F32i_F32r_F32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processSubtractF32_F32r_F32r_F32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processSubtractI32_I32i_I32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processSubtractI32_I32i_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processSubtractI32_I32r_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processXorI32_I32i_I32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processXorI32_I32i_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processXorI32_I32r_I32r_I32r) where TDeps : notnull where TContext : notnull where TCompileState : notnull
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x2BAB630", Offset = "0x2BAA030", VA = "0x182BAB630")]
		private static int GEVZXHJXLGG([In] UnsafeList<byte> from, UnsafeList<byte> a, int b, int c)
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public static class FJOUEEFIAVM
	{
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		public static readonly int SCNSVZVSEGQ;

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x3AD80E0", Offset = "0x3AD6AE0", VA = "0x183AD80E0")]
		public static Id32<EWICTHMTERF<a>> RCIVJPWVKXU<a>([In] this UnsafeList<byte> self)
		{
			return default(Id32<EWICTHMTERF<a>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x3AD7FA0", Offset = "0x3AD69A0", VA = "0x183AD7FA0")]
		public static Id32<EWICTHMTERF<EWICTHMTERF<b>>> DRXVYNJOLJD<b>(this UnsafeList<byte> a, [Optional] Id32<EWICTHMTERF<b>>? b)
		{
			return default(Id32<EWICTHMTERF<EWICTHMTERF<b>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x2BAAA30", Offset = "0x2BA9430", VA = "0x182BAAA30")]
		public static Id32<EWICTHMTERF<PSFHTYHJPFE>> BSWTARMDHOF(this UnsafeList<byte> a, [Optional] Id32<PSFHTYHJPFE>? b)
		{
			return default(Id32<EWICTHMTERF<PSFHTYHJPFE>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x2BAAD00", Offset = "0x2BA9700", VA = "0x182BAAD00")]
		public static Id32<EWICTHMTERF<LRDRLGWKAMQ>> MRDAODIZVWN(this UnsafeList<byte> a, [Optional] float? b)
		{
			return default(Id32<EWICTHMTERF<LRDRLGWKAMQ>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x2BAADF0", Offset = "0x2BA97F0", VA = "0x182BAADF0")]
		public static Id32<EWICTHMTERF<RBMWJAHCKAJ>> RWCGJDHCEZK(this UnsafeList<byte> a, [Optional] int? b)
		{
			return default(Id32<EWICTHMTERF<RBMWJAHCKAJ>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x2BAAED0", Offset = "0x2BA98D0", VA = "0x182BAAED0")]
		public static Id32<EWICTHMTERF<AWGGZWOVPWP>> VFUQAZRJILA(this UnsafeList<byte> a, [Optional] Id32<AWGGZWOVPWP>? b)
		{
			return default(Id32<EWICTHMTERF<AWGGZWOVPWP>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x2BAAFC0", Offset = "0x2BA99C0", VA = "0x182BAAFC0")]
		public static Id32<EWICTHMTERF<BDLDICASVGU>> YWRLMCIYELB(this UnsafeList<byte> a, [Optional] byte? b)
		{
			return default(Id32<EWICTHMTERF<BDLDICASVGU>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x2BAAB20", Offset = "0x2BA9520", VA = "0x182BAAB20")]
		public static Id32<EWICTHMTERF<THWZKYKDWOE>> CUJANIZCNVB(this UnsafeList<byte> a, [Optional] Id32<THWZKYKDWOE>? b)
		{
			return default(Id32<EWICTHMTERF<THWZKYKDWOE>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x2BAAC10", Offset = "0x2BA9610", VA = "0x182BAAC10")]
		public static Id32<EWICTHMTERF<QIRCDDDMPGO>> EADUJJQWMTP(this UnsafeList<byte> a, [Optional] Op? b)
		{
			return default(Id32<EWICTHMTERF<QIRCDDDMPGO>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x3AD7FA0", Offset = "0x3AD69A0", VA = "0x183AD7FA0")]
		public static Id32<EWICTHMTERF<OXBJHRVWJBD<c>>> MHJXGVNKWGL<c>(this UnsafeList<byte> a, [Optional] Id32<OXBJHRVWJBD<c>>? b)
		{
			return default(Id32<EWICTHMTERF<OXBJHRVWJBD<c>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x2BA4F90", Offset = "0x2BA3990", VA = "0x182BA4F90")]
		public static void HVSNCJHRCOV(this UnsafeList<byte> a, Id32<EWICTHMTERF<RBMWJAHCKAJ>> b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x3AD8080", Offset = "0x3AD6A80", VA = "0x183AD8080")]
		public static void KZPBIGPRRII<d>(this UnsafeList<byte> a, Id32<EWICTHMTERF<EWICTHMTERF<d>>> b, Id32<EWICTHMTERF<d>> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x3AD8080", Offset = "0x3AD6A80", VA = "0x183AD8080")]
		public static void HRQEFMWQYGC<e>(this UnsafeList<byte> a, Id32<EWICTHMTERF<OXBJHRVWJBD<e>>> b, Id32<OXBJHRVWJBD<e>> c)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public static class FNFCAORUZNJ
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x2BAB100", Offset = "0x2BA9B00", VA = "0x182BAB100")]
		public static Union32 ONAISROUOGH([In] this ReadOnlySpan<byte> bytes, int a)
		{
			return default(Union32);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x2BAB170", Offset = "0x2BA9B70", VA = "0x182BAB170")]
		public static Union32 ONAISROUOGH([In] this UnsafeList<byte> bytes, int a)
		{
			return default(Union32);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x3AD9310", Offset = "0x3AD7D10", VA = "0x183AD9310")]
		public static Union32 ONAISROUOGH<f>(this ReadOnlyIdArray<f, byte> a, Id32<f> b)
		{
			return default(Union32);
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x3AD9490", Offset = "0x3AD7E90", VA = "0x183AD9490")]
		public static Union32 ONAISROUOGH<g>([In] this ReadOnlyIdSpan<g, byte> bytes, Id32<g> a)
		{
			return default(Union32);
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x3AD9180", Offset = "0x3AD7B80", VA = "0x183AD9180")]
		public static Union32 ONAISROUOGH<i>(this IdArray<i, byte> a, Id32<i> b)
		{
			return default(Union32);
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x3AD92A0", Offset = "0x3AD7CA0", VA = "0x183AD92A0")]
		public static Union32 ONAISROUOGH<j>([In] this IdSpan<j, byte> bytes, Id32<j> a)
		{
			return default(Union32);
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x3AD91E0", Offset = "0x3AD7BE0", VA = "0x183AD91E0")]
		public static Union32 ONAISROUOGH<k>(this ReadOnlyIdArray<k, byte> a, Id32<k> b)
		{
			return default(Union32);
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x2BAB100", Offset = "0x2BA9B00", VA = "0x182BAB100")]
		public static int GCIMSKFRXAU([In] this ReadOnlySpan<byte> bytes, int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x2BA4EE0", Offset = "0x2BA38E0", VA = "0x182BA4EE0")]
		public static int GCIMSKFRXAU([In] this UnsafeList<byte> bytes, int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x3AD8350", Offset = "0x3AD6D50", VA = "0x183AD8350")]
		public static int GCIMSKFRXAU<p>(this ReadOnlyIdArray<p, byte> a, Id32<p> b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x3AD83F0", Offset = "0x3AD6DF0", VA = "0x183AD83F0")]
		public static int GCIMSKFRXAU<s>(this IdArray<s, byte> a, Id32<s> b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x3AD83A0", Offset = "0x3AD6DA0", VA = "0x183AD83A0")]
		public static int GCIMSKFRXAU<t>([In] this IdSpan<t, byte> bytes, Id32<t> a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x3AD8470", Offset = "0x3AD6E70", VA = "0x183AD8470")]
		public static int GCIMSKFRXAU<u>(this ReadOnlyIdArray<u, byte> a, Id32<u> b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x3AD89C0", Offset = "0x3AD73C0", VA = "0x183AD89C0")]
		public static float MMPQDLPKSKV<bc>(this IdArray<bc, byte> a, Id32<bc> b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x3AD8970", Offset = "0x3AD7370", VA = "0x183AD8970")]
		public static float MMPQDLPKSKV<bd>([In] this IdSpan<bd, byte> bytes, Id32<bd> a)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x3AD8A40", Offset = "0x3AD7440", VA = "0x183AD8A40")]
		public static float MMPQDLPKSKV<be>(this ReadOnlyIdArray<be, byte> a, Id32<be> b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x3AD9AE0", Offset = "0x3AD84E0", VA = "0x183AD9AE0")]
		public static byte ZDLNFEOWJZF<bj>(this ReadOnlyIdArray<bj, byte> a, Id32<bj> b)
		{
			return default(byte);
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x3AD9C00", Offset = "0x3AD8600", VA = "0x183AD9C00")]
		public static byte ZDLNFEOWJZF<bk>([In] this ReadOnlyIdSpan<bk, byte> bytes, Id32<bk> a)
		{
			return default(byte);
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x3AD9A60", Offset = "0x3AD8460", VA = "0x183AD9A60")]
		public static byte ZDLNFEOWJZF<bm>(this IdArray<bm, byte> a, Id32<bm> b)
		{
			return default(byte);
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x3AD9C50", Offset = "0x3AD8650", VA = "0x183AD9C50")]
		public static byte ZDLNFEOWJZF<bn>([In] this IdSpan<bn, byte> bytes, Id32<bn> a)
		{
			return default(byte);
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x3AD9B30", Offset = "0x3AD8530", VA = "0x183AD9B30")]
		public static byte ZDLNFEOWJZF<bo>(this ReadOnlyIdArray<bo, byte> a, Id32<bo> b)
		{
			return default(byte);
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x2BA4EE0", Offset = "0x2BA38E0", VA = "0x182BA4EE0")]
		public static Op JYFOKDMCPZL([In] this UnsafeList<byte> bytes, int a)
		{
			return default(Op);
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x3AD86E0", Offset = "0x3AD70E0", VA = "0x183AD86E0")]
		public static Op JYFOKDMCPZL<by>(this ReadOnlyIdArray<by, byte> a, Id32<by> b)
		{
			return default(Op);
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x3AD8C10", Offset = "0x3AD7610", VA = "0x183AD8C10")]
		public static Id32<EWICTHMTERF<CEGVXPWDZCF>> NBVCGCZBJTT<cg>(this IdArray<cg, byte> a, Id32<cg> b)
		{
			return default(Id32<EWICTHMTERF<CEGVXPWDZCF>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x3AD8D20", Offset = "0x3AD7720", VA = "0x183AD8D20")]
		public static Id32<EWICTHMTERF<CEGVXPWDZCF>> NBVCGCZBJTT<ch>([In] this IdSpan<ch, byte> bytes, Id32<ch> a)
		{
			return default(Id32<EWICTHMTERF<CEGVXPWDZCF>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x3AD8C90", Offset = "0x3AD7690", VA = "0x183AD8C90")]
		public static Id32<EWICTHMTERF<CEGVXPWDZCF>> NBVCGCZBJTT<ci>(this ReadOnlyIdArray<ci, byte> a, Id32<ci> b)
		{
			return default(Id32<EWICTHMTERF<CEGVXPWDZCF>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x3AD81D0", Offset = "0x3AD6BD0", VA = "0x183AD81D0")]
		public static Id32<OXBJHRVWJBD<CEGVXPWDZCF>> DXMJKDIDUBJ<cs>(this ReadOnlyIdArray<cs, byte> a, Id32<cs> b)
		{
			return default(Id32<OXBJHRVWJBD<CEGVXPWDZCF>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x3AD9820", Offset = "0x3AD8220", VA = "0x183AD9820")]
		public static Id32<THWZKYKDWOE> UEOPHJCQYCT<da>(this IdArray<da, byte> a, Id32<da> b)
		{
			return default(Id32<THWZKYKDWOE>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x3AD98A0", Offset = "0x3AD82A0", VA = "0x183AD98A0")]
		public static Id32<THWZKYKDWOE> UEOPHJCQYCT<db>([In] this IdSpan<db, byte> bytes, Id32<db> a)
		{
			return default(Id32<THWZKYKDWOE>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x3AD9790", Offset = "0x3AD8190", VA = "0x183AD9790")]
		public static Id32<THWZKYKDWOE> UEOPHJCQYCT<dc>(this ReadOnlyIdArray<dc, byte> a, Id32<dc> b)
		{
			return default(Id32<THWZKYKDWOE>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x3AD8650", Offset = "0x3AD7050", VA = "0x183AD8650")]
		public static Id32<PSFHTYHJPFE> GEYNEHYSLGB<dl>([In] this IdSpan<dl, byte> bytes, Id32<dl> a)
		{
			return default(Id32<PSFHTYHJPFE>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x3AD85C0", Offset = "0x3AD6FC0", VA = "0x183AD85C0")]
		public static Id32<PSFHTYHJPFE> GEYNEHYSLGB<dm>(this ReadOnlyIdArray<dm, byte> a, Id32<dm> b)
		{
			return default(Id32<PSFHTYHJPFE>);
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x3AD87C0", Offset = "0x3AD71C0", VA = "0x183AD87C0")]
		public static Id32<AWGGZWOVPWP> KRTFALIDMPO<dw>(this ReadOnlyIdArray<dw, byte> a, Id32<dw> b)
		{
			return default(Id32<AWGGZWOVPWP>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public static class LFFJRFKBGBZ
	{
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x2BAB4B0", Offset = "0x2BA9EB0", VA = "0x182BAB4B0")]
		public static void JMXUHQWWHVY(this UnsafeList<byte> a, int b, Union32 c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x2BAB440", Offset = "0x2BA9E40", VA = "0x182BAB440")]
		public static void JMXUHQWWHVY(this byte[] a, int b, Union32 c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x2BAB3C0", Offset = "0x2BA9DC0", VA = "0x182BAB3C0")]
		public static void JMXUHQWWHVY([In] this Span<byte> bytes, int a, Union32 b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x3C0B220", Offset = "0x3C09C20", VA = "0x183C0B220")]
		public static void JMXUHQWWHVY<e>(this IdArray<e, byte> a, Id32<e> b, Union32 c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x3C0B0D0", Offset = "0x3C09AD0", VA = "0x183C0B0D0")]
		public static void JMXUHQWWHVY<f>([In] this IdSpan<f, byte> bytes, Id32<f> a, Union32 b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x2BA4F90", Offset = "0x2BA3990", VA = "0x182BA4F90")]
		public static void HVSNCJHRCOV(this UnsafeList<byte> a, int b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x2BAB250", Offset = "0x2BA9C50", VA = "0x182BAB250")]
		public static void HVSNCJHRCOV(this byte[] a, int b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x2BAB2D0", Offset = "0x2BA9CD0", VA = "0x182BAB2D0")]
		public static void HVSNCJHRCOV([In] this Span<byte> bytes, int a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x3C0ACB0", Offset = "0x3C096B0", VA = "0x183C0ACB0")]
		public static void HVSNCJHRCOV<h>(this IdArray<h, byte> a, Id32<h> b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x3C0AD10", Offset = "0x3C09710", VA = "0x183C0AD10")]
		public static void HVSNCJHRCOV<i>([In] this IdSpan<i, byte> bytes, Id32<i> a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x2BAB570", Offset = "0x2BA9F70", VA = "0x182BAB570")]
		public static void YOKWPAWSTVK(this UnsafeList<byte> a, int b, float c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x3C0B450", Offset = "0x3C09E50", VA = "0x183C0B450")]
		public static void YOKWPAWSTVK<k>(this IdArray<k, byte> a, Id32<k> b, float c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x3C0B4C0", Offset = "0x3C09EC0", VA = "0x183C0B4C0")]
		public static void YOKWPAWSTVK<l>([In] this IdSpan<l, byte> bytes, Id32<l> a, float b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x2BAB350", Offset = "0x2BA9D50", VA = "0x182BAB350")]
		public static void JAXDWAEWPZO(this UnsafeList<byte> a, int b, byte c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x3C0AE20", Offset = "0x3C09820", VA = "0x183C0AE20")]
		public static void JAXDWAEWPZO<n>(this IdArray<n, byte> a, Id32<n> b, byte c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x3C0AE70", Offset = "0x3C09870", VA = "0x183C0AE70")]
		public static void JAXDWAEWPZO<o>([In] this IdSpan<o, byte> bytes, Id32<o> a, byte b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x3C0AAD0", Offset = "0x3C094D0", VA = "0x183C0AAD0")]
		public static void KZPBIGPRRII<q>(this IdArray<q, byte> a, Id32<q> b, Id32<EWICTHMTERF<CEGVXPWDZCF>> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x3C0AB50", Offset = "0x3C09550", VA = "0x183C0AB50")]
		public static void KZPBIGPRRII<r>([In] this IdSpan<r, byte> bytes, Id32<r> a, Id32<EWICTHMTERF<CEGVXPWDZCF>> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x3C0AAD0", Offset = "0x3C094D0", VA = "0x183C0AAD0")]
		public static void AVIJEJEOMWU<t>(this IdArray<t, byte> a, Id32<t> b, Id32<THWZKYKDWOE> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x3C0AB50", Offset = "0x3C09550", VA = "0x183C0AB50")]
		public static void AVIJEJEOMWU<u>([In] this IdSpan<u, byte> bytes, Id32<u> a, Id32<THWZKYKDWOE> b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public static class AMWKMFBRETA
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x2BA7240", Offset = "0x2BA5C40", VA = "0x182BA7240")]
		public static (Id32<EWICTHMTERF<QIRCDDDMPGO>>, Id32<EWICTHMTERF<LRDRLGWKAMQ>>, Id32<EWICTHMTERF<LRDRLGWKAMQ>>, Id32<EWICTHMTERF<OXBJHRVWJBD<LRDRLGWKAMQ>>>) LHSZZYRKXIU(this UnsafeList<byte> a, float b, float c, [Optional] Id32<OXBJHRVWJBD<LRDRLGWKAMQ>>? d)
		{
			return default((Id32<EWICTHMTERF<QIRCDDDMPGO>>, Id32<EWICTHMTERF<LRDRLGWKAMQ>>, Id32<EWICTHMTERF<LRDRLGWKAMQ>>, Id32<EWICTHMTERF<OXBJHRVWJBD<LRDRLGWKAMQ>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x2BA7B70", Offset = "0x2BA6570", VA = "0x182BA7B70")]
		public static (Id32<EWICTHMTERF<QIRCDDDMPGO>>, Id32<EWICTHMTERF<LRDRLGWKAMQ>>, Id32<EWICTHMTERF<OXBJHRVWJBD<LRDRLGWKAMQ>>>, Id32<EWICTHMTERF<OXBJHRVWJBD<LRDRLGWKAMQ>>>) NHFNAXBMGPR(this UnsafeList<byte> a, float b, [Optional] Id32<OXBJHRVWJBD<LRDRLGWKAMQ>>? c, [Optional] Id32<OXBJHRVWJBD<LRDRLGWKAMQ>>? d)
		{
			return default((Id32<EWICTHMTERF<QIRCDDDMPGO>>, Id32<EWICTHMTERF<LRDRLGWKAMQ>>, Id32<EWICTHMTERF<OXBJHRVWJBD<LRDRLGWKAMQ>>>, Id32<EWICTHMTERF<OXBJHRVWJBD<LRDRLGWKAMQ>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x2BAA030", Offset = "0x2BA8A30", VA = "0x182BAA030")]
		public static (Id32<EWICTHMTERF<QIRCDDDMPGO>>, Id32<EWICTHMTERF<OXBJHRVWJBD<LRDRLGWKAMQ>>>, Id32<EWICTHMTERF<OXBJHRVWJBD<LRDRLGWKAMQ>>>, Id32<EWICTHMTERF<OXBJHRVWJBD<LRDRLGWKAMQ>>>) WMXQLGQMVSO(this UnsafeList<byte> a, [Optional] Id32<OXBJHRVWJBD<LRDRLGWKAMQ>>? b, [Optional] Id32<OXBJHRVWJBD<LRDRLGWKAMQ>>? c, [Optional] Id32<OXBJHRVWJBD<LRDRLGWKAMQ>>? d)
		{
			return default((Id32<EWICTHMTERF<QIRCDDDMPGO>>, Id32<EWICTHMTERF<OXBJHRVWJBD<LRDRLGWKAMQ>>>, Id32<EWICTHMTERF<OXBJHRVWJBD<LRDRLGWKAMQ>>>, Id32<EWICTHMTERF<OXBJHRVWJBD<LRDRLGWKAMQ>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x2BA9330", Offset = "0x2BA7D30", VA = "0x182BA9330")]
		public static (Id32<EWICTHMTERF<QIRCDDDMPGO>>, Id32<EWICTHMTERF<RBMWJAHCKAJ>>, Id32<EWICTHMTERF<RBMWJAHCKAJ>>, Id32<EWICTHMTERF<OXBJHRVWJBD<RBMWJAHCKAJ>>>) TJLKSDSKNPM(this UnsafeList<byte> a, int b, int c, [Optional] Id32<OXBJHRVWJBD<RBMWJAHCKAJ>>? d)
		{
			return default((Id32<EWICTHMTERF<QIRCDDDMPGO>>, Id32<EWICTHMTERF<RBMWJAHCKAJ>>, Id32<EWICTHMTERF<RBMWJAHCKAJ>>, Id32<EWICTHMTERF<OXBJHRVWJBD<RBMWJAHCKAJ>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x2BA8740", Offset = "0x2BA7140", VA = "0x182BA8740")]
		public static (Id32<EWICTHMTERF<QIRCDDDMPGO>>, Id32<EWICTHMTERF<RBMWJAHCKAJ>>, Id32<EWICTHMTERF<OXBJHRVWJBD<RBMWJAHCKAJ>>>, Id32<EWICTHMTERF<OXBJHRVWJBD<RBMWJAHCKAJ>>>) RHQJXCDRHZT(this UnsafeList<byte> a, int b, [Optional] Id32<OXBJHRVWJBD<RBMWJAHCKAJ>>? c, [Optional] Id32<OXBJHRVWJBD<RBMWJAHCKAJ>>? d)
		{
			return default((Id32<EWICTHMTERF<QIRCDDDMPGO>>, Id32<EWICTHMTERF<RBMWJAHCKAJ>>, Id32<EWICTHMTERF<OXBJHRVWJBD<RBMWJAHCKAJ>>>, Id32<EWICTHMTERF<OXBJHRVWJBD<RBMWJAHCKAJ>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x2BAA400", Offset = "0x2BA8E00", VA = "0x182BAA400")]
		public static (Id32<EWICTHMTERF<QIRCDDDMPGO>>, Id32<EWICTHMTERF<OXBJHRVWJBD<RBMWJAHCKAJ>>>, Id32<EWICTHMTERF<OXBJHRVWJBD<RBMWJAHCKAJ>>>, Id32<EWICTHMTERF<OXBJHRVWJBD<RBMWJAHCKAJ>>>) YKFSQKYWFEM(this UnsafeList<byte> a, [Optional] Id32<OXBJHRVWJBD<RBMWJAHCKAJ>>? b, [Optional] Id32<OXBJHRVWJBD<RBMWJAHCKAJ>>? c, [Optional] Id32<OXBJHRVWJBD<RBMWJAHCKAJ>>? d)
		{
			return default((Id32<EWICTHMTERF<QIRCDDDMPGO>>, Id32<EWICTHMTERF<OXBJHRVWJBD<RBMWJAHCKAJ>>>, Id32<EWICTHMTERF<OXBJHRVWJBD<RBMWJAHCKAJ>>>, Id32<EWICTHMTERF<OXBJHRVWJBD<RBMWJAHCKAJ>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x2BAA2A0", Offset = "0x2BA8CA0", VA = "0x182BAA2A0")]
		public static (Id32<EWICTHMTERF<QIRCDDDMPGO>>, Id32<EWICTHMTERF<RBMWJAHCKAJ>>, Id32<EWICTHMTERF<RBMWJAHCKAJ>>, Id32<EWICTHMTERF<OXBJHRVWJBD<RBMWJAHCKAJ>>>) WSBAFYYVPYU(this UnsafeList<byte> a, int b, int c, [Optional] Id32<OXBJHRVWJBD<RBMWJAHCKAJ>>? d)
		{
			return default((Id32<EWICTHMTERF<QIRCDDDMPGO>>, Id32<EWICTHMTERF<RBMWJAHCKAJ>>, Id32<EWICTHMTERF<RBMWJAHCKAJ>>, Id32<EWICTHMTERF<OXBJHRVWJBD<RBMWJAHCKAJ>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x2BAA8E0", Offset = "0x2BA92E0", VA = "0x182BAA8E0")]
		public static (Id32<EWICTHMTERF<QIRCDDDMPGO>>, Id32<EWICTHMTERF<RBMWJAHCKAJ>>, Id32<EWICTHMTERF<OXBJHRVWJBD<RBMWJAHCKAJ>>>, Id32<EWICTHMTERF<OXBJHRVWJBD<RBMWJAHCKAJ>>>) ZQTSUEMEKNN(this UnsafeList<byte> a, int b, [Optional] Id32<OXBJHRVWJBD<RBMWJAHCKAJ>>? c, [Optional] Id32<OXBJHRVWJBD<RBMWJAHCKAJ>>? d)
		{
			return default((Id32<EWICTHMTERF<QIRCDDDMPGO>>, Id32<EWICTHMTERF<RBMWJAHCKAJ>>, Id32<EWICTHMTERF<OXBJHRVWJBD<RBMWJAHCKAJ>>>, Id32<EWICTHMTERF<OXBJHRVWJBD<RBMWJAHCKAJ>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x2BA8C80", Offset = "0x2BA7680", VA = "0x182BA8C80")]
		public static (Id32<EWICTHMTERF<QIRCDDDMPGO>>, Id32<EWICTHMTERF<OXBJHRVWJBD<RBMWJAHCKAJ>>>, Id32<EWICTHMTERF<OXBJHRVWJBD<RBMWJAHCKAJ>>>, Id32<EWICTHMTERF<OXBJHRVWJBD<RBMWJAHCKAJ>>>) SCHFBVFIGIS(this UnsafeList<byte> a, [Optional] Id32<OXBJHRVWJBD<RBMWJAHCKAJ>>? b, [Optional] Id32<OXBJHRVWJBD<RBMWJAHCKAJ>>? c, [Optional] Id32<OXBJHRVWJBD<RBMWJAHCKAJ>>? d)
		{
			return default((Id32<EWICTHMTERF<QIRCDDDMPGO>>, Id32<EWICTHMTERF<OXBJHRVWJBD<RBMWJAHCKAJ>>>, Id32<EWICTHMTERF<OXBJHRVWJBD<RBMWJAHCKAJ>>>, Id32<EWICTHMTERF<OXBJHRVWJBD<RBMWJAHCKAJ>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x2BA9AB0", Offset = "0x2BA84B0", VA = "0x182BA9AB0")]
		public static (Id32<EWICTHMTERF<QIRCDDDMPGO>>, Id32<EWICTHMTERF<RBMWJAHCKAJ>>, Id32<EWICTHMTERF<EWICTHMTERF<QIRCDDDMPGO>>>) UONLEARSCYG(this UnsafeList<byte> a, [Optional] int? b, [Optional] Id32<EWICTHMTERF<QIRCDDDMPGO>>? c)
		{
			return default((Id32<EWICTHMTERF<QIRCDDDMPGO>>, Id32<EWICTHMTERF<RBMWJAHCKAJ>>, Id32<EWICTHMTERF<EWICTHMTERF<QIRCDDDMPGO>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x2BA7E10", Offset = "0x2BA6810", VA = "0x182BA7E10")]
		public static (Id32<EWICTHMTERF<QIRCDDDMPGO>>, Id32<EWICTHMTERF<OXBJHRVWJBD<RBMWJAHCKAJ>>>, Id32<EWICTHMTERF<EWICTHMTERF<QIRCDDDMPGO>>>) NVURHZJFHVP(this UnsafeList<byte> a, [Optional] Id32<OXBJHRVWJBD<RBMWJAHCKAJ>>? b, [Optional] Id32<EWICTHMTERF<QIRCDDDMPGO>>? c)
		{
			return default((Id32<EWICTHMTERF<QIRCDDDMPGO>>, Id32<EWICTHMTERF<OXBJHRVWJBD<RBMWJAHCKAJ>>>, Id32<EWICTHMTERF<EWICTHMTERF<QIRCDDDMPGO>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x2BA62F0", Offset = "0x2BA4CF0", VA = "0x182BA62F0")]
		public static (Id32<EWICTHMTERF<QIRCDDDMPGO>>, Id32<EWICTHMTERF<RBMWJAHCKAJ>>, Id32<EWICTHMTERF<EWICTHMTERF<QIRCDDDMPGO>>>) FZVLJSJVQDV(this UnsafeList<byte> a, [Optional] int? b, [Optional] Id32<EWICTHMTERF<QIRCDDDMPGO>>? c)
		{
			return default((Id32<EWICTHMTERF<QIRCDDDMPGO>>, Id32<EWICTHMTERF<RBMWJAHCKAJ>>, Id32<EWICTHMTERF<EWICTHMTERF<QIRCDDDMPGO>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x2BA9BC0", Offset = "0x2BA85C0", VA = "0x182BA9BC0")]
		public static (Id32<EWICTHMTERF<QIRCDDDMPGO>>, Id32<EWICTHMTERF<OXBJHRVWJBD<RBMWJAHCKAJ>>>, Id32<EWICTHMTERF<EWICTHMTERF<QIRCDDDMPGO>>>) VMKWIJOHTXG(this UnsafeList<byte> a, [Optional] Id32<OXBJHRVWJBD<RBMWJAHCKAJ>>? b, [Optional] Id32<EWICTHMTERF<QIRCDDDMPGO>>? c)
		{
			return default((Id32<EWICTHMTERF<QIRCDDDMPGO>>, Id32<EWICTHMTERF<OXBJHRVWJBD<RBMWJAHCKAJ>>>, Id32<EWICTHMTERF<EWICTHMTERF<QIRCDDDMPGO>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x2BA6F60", Offset = "0x2BA5960", VA = "0x182BA6F60")]
		public static (Id32<EWICTHMTERF<QIRCDDDMPGO>>, Id32<EWICTHMTERF<RBMWJAHCKAJ>>, Id32<EWICTHMTERF<PSFHTYHJPFE>>) KVDIHMJBRHX(this UnsafeList<byte> a, [Optional] int? b, [Optional] Id32<PSFHTYHJPFE>? c)
		{
			return default((Id32<EWICTHMTERF<QIRCDDDMPGO>>, Id32<EWICTHMTERF<RBMWJAHCKAJ>>, Id32<EWICTHMTERF<PSFHTYHJPFE>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x2BA6D00", Offset = "0x2BA5700", VA = "0x182BA6D00")]
		public static (Id32<EWICTHMTERF<QIRCDDDMPGO>>, Id32<EWICTHMTERF<RBMWJAHCKAJ>>, Id32<EWICTHMTERF<OXBJHRVWJBD<PSFHTYHJPFE>>>) KSXKLPYERNC(this UnsafeList<byte> a, [Optional] int? b, [Optional] Id32<OXBJHRVWJBD<PSFHTYHJPFE>>? c)
		{
			return default((Id32<EWICTHMTERF<QIRCDDDMPGO>>, Id32<EWICTHMTERF<RBMWJAHCKAJ>>, Id32<EWICTHMTERF<OXBJHRVWJBD<PSFHTYHJPFE>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x2BA7780", Offset = "0x2BA6180", VA = "0x182BA7780")]
		public static (Id32<EWICTHMTERF<QIRCDDDMPGO>>, Id32<EWICTHMTERF<RBMWJAHCKAJ>>, Id32<EWICTHMTERF<THWZKYKDWOE>>) MWTGIUYTTIL(this UnsafeList<byte> a, [Optional] int? b, [Optional] Id32<THWZKYKDWOE>? c)
		{
			return default((Id32<EWICTHMTERF<QIRCDDDMPGO>>, Id32<EWICTHMTERF<RBMWJAHCKAJ>>, Id32<EWICTHMTERF<THWZKYKDWOE>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x2BA7930", Offset = "0x2BA6330", VA = "0x182BA7930")]
		public static (Id32<EWICTHMTERF<QIRCDDDMPGO>>, Id32<EWICTHMTERF<RBMWJAHCKAJ>>, Id32<EWICTHMTERF<OXBJHRVWJBD<THWZKYKDWOE>>>) NBUWSICFVGC(this UnsafeList<byte> a, [Optional] int? b, [Optional] Id32<OXBJHRVWJBD<THWZKYKDWOE>>? c)
		{
			return default((Id32<EWICTHMTERF<QIRCDDDMPGO>>, Id32<EWICTHMTERF<RBMWJAHCKAJ>>, Id32<EWICTHMTERF<OXBJHRVWJBD<THWZKYKDWOE>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x33A57E0", Offset = "0x33A41E0", VA = "0x1833A57E0")]
		public static (Id32<EWICTHMTERF<QIRCDDDMPGO>>, Id32<EWICTHMTERF<AWGGZWOVPWP>>, Id32<EWICTHMTERF<RBMWJAHCKAJ>>, Id32<EWICTHMTERF<a>>) EIMSTPADMRW<a>(this UnsafeList<byte> a, [Optional] Id32<AWGGZWOVPWP>? b, [Optional][In] ReadOnlySpan<byte> data)
		{
			return default((Id32<EWICTHMTERF<QIRCDDDMPGO>>, Id32<EWICTHMTERF<AWGGZWOVPWP>>, Id32<EWICTHMTERF<RBMWJAHCKAJ>>, Id32<EWICTHMTERF<a>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x2BA7A40", Offset = "0x2BA6440", VA = "0x182BA7A40")]
		public static (Id32<EWICTHMTERF<QIRCDDDMPGO>>, Id32<EWICTHMTERF<RBMWJAHCKAJ>>, Id32<EWICTHMTERF<OXBJHRVWJBD<RBMWJAHCKAJ>>>) NFBVIQZYBDA(this UnsafeList<byte> a, int b, [Optional] Id32<OXBJHRVWJBD<RBMWJAHCKAJ>>? c)
		{
			return default((Id32<EWICTHMTERF<QIRCDDDMPGO>>, Id32<EWICTHMTERF<RBMWJAHCKAJ>>, Id32<EWICTHMTERF<OXBJHRVWJBD<RBMWJAHCKAJ>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x2BA95F0", Offset = "0x2BA7FF0", VA = "0x182BA95F0")]
		public static (Id32<EWICTHMTERF<QIRCDDDMPGO>>, Id32<EWICTHMTERF<OXBJHRVWJBD<RBMWJAHCKAJ>>>, Id32<EWICTHMTERF<OXBJHRVWJBD<RBMWJAHCKAJ>>>) TXCANKGQWBL(this UnsafeList<byte> a, [Optional] Id32<OXBJHRVWJBD<RBMWJAHCKAJ>>? b, [Optional] Id32<OXBJHRVWJBD<RBMWJAHCKAJ>>? c)
		{
			return default((Id32<EWICTHMTERF<QIRCDDDMPGO>>, Id32<EWICTHMTERF<OXBJHRVWJBD<RBMWJAHCKAJ>>>, Id32<EWICTHMTERF<OXBJHRVWJBD<RBMWJAHCKAJ>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x33A5E50", Offset = "0x33A4850", VA = "0x1833A5E50")]
		public static (Id32<EWICTHMTERF<QIRCDDDMPGO>>, Id32<EWICTHMTERF<OXBJHRVWJBD<b>>>, Id32<EWICTHMTERF<RBMWJAHCKAJ>>, Id32<EWICTHMTERF<b>>) IIWMTCGWOXY<b>(this UnsafeList<byte> a, [Optional] Id32<OXBJHRVWJBD<b>>? b, [Optional] int? c, [Optional][In] ReadOnlySpan<byte> from)
		{
			return default((Id32<EWICTHMTERF<QIRCDDDMPGO>>, Id32<EWICTHMTERF<OXBJHRVWJBD<b>>>, Id32<EWICTHMTERF<RBMWJAHCKAJ>>, Id32<EWICTHMTERF<b>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x33A5B20", Offset = "0x33A4520", VA = "0x1833A5B20")]
		public static (Id32<EWICTHMTERF<QIRCDDDMPGO>>, Id32<EWICTHMTERF<OXBJHRVWJBD<c>>>, Id32<EWICTHMTERF<OXBJHRVWJBD<c>>>, Id32<EWICTHMTERF<RBMWJAHCKAJ>>) IDFTPNJBGLH<c>(this UnsafeList<byte> a, [Optional] Id32<OXBJHRVWJBD<c>>? b, [Optional] Id32<OXBJHRVWJBD<c>>? c, [Optional] int? d)
		{
			return default((Id32<EWICTHMTERF<QIRCDDDMPGO>>, Id32<EWICTHMTERF<OXBJHRVWJBD<c>>>, Id32<EWICTHMTERF<OXBJHRVWJBD<c>>>, Id32<EWICTHMTERF<RBMWJAHCKAJ>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x2BA7F30", Offset = "0x2BA6930", VA = "0x182BA7F30")]
		public static (Id32<EWICTHMTERF<QIRCDDDMPGO>>, Id32<EWICTHMTERF<LRDRLGWKAMQ>>, Id32<EWICTHMTERF<LRDRLGWKAMQ>>, Id32<EWICTHMTERF<OXBJHRVWJBD<LRDRLGWKAMQ>>>) NXAIYSAWXZI(this UnsafeList<byte> a, float b, float c, [Optional] Id32<OXBJHRVWJBD<LRDRLGWKAMQ>>? d)
		{
			return default((Id32<EWICTHMTERF<QIRCDDDMPGO>>, Id32<EWICTHMTERF<LRDRLGWKAMQ>>, Id32<EWICTHMTERF<LRDRLGWKAMQ>>, Id32<EWICTHMTERF<OXBJHRVWJBD<LRDRLGWKAMQ>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x2BA7CC0", Offset = "0x2BA66C0", VA = "0x182BA7CC0")]
		public static (Id32<EWICTHMTERF<QIRCDDDMPGO>>, Id32<EWICTHMTERF<LRDRLGWKAMQ>>, Id32<EWICTHMTERF<OXBJHRVWJBD<LRDRLGWKAMQ>>>, Id32<EWICTHMTERF<OXBJHRVWJBD<LRDRLGWKAMQ>>>) NLAFBXJCDUV(this UnsafeList<byte> a, float b, [Optional] Id32<OXBJHRVWJBD<LRDRLGWKAMQ>>? c, [Optional] Id32<OXBJHRVWJBD<LRDRLGWKAMQ>>? d)
		{
			return default((Id32<EWICTHMTERF<QIRCDDDMPGO>>, Id32<EWICTHMTERF<LRDRLGWKAMQ>>, Id32<EWICTHMTERF<OXBJHRVWJBD<LRDRLGWKAMQ>>>, Id32<EWICTHMTERF<OXBJHRVWJBD<LRDRLGWKAMQ>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x2BA5F10", Offset = "0x2BA4910", VA = "0x182BA5F10")]
		public static (Id32<EWICTHMTERF<QIRCDDDMPGO>>, Id32<EWICTHMTERF<OXBJHRVWJBD<LRDRLGWKAMQ>>>, Id32<EWICTHMTERF<OXBJHRVWJBD<LRDRLGWKAMQ>>>, Id32<EWICTHMTERF<OXBJHRVWJBD<LRDRLGWKAMQ>>>) FJCWYXFPUDW(this UnsafeList<byte> a, [Optional] Id32<OXBJHRVWJBD<LRDRLGWKAMQ>>? b, [Optional] Id32<OXBJHRVWJBD<LRDRLGWKAMQ>>? c, [Optional] Id32<OXBJHRVWJBD<LRDRLGWKAMQ>>? d)
		{
			return default((Id32<EWICTHMTERF<QIRCDDDMPGO>>, Id32<EWICTHMTERF<OXBJHRVWJBD<LRDRLGWKAMQ>>>, Id32<EWICTHMTERF<OXBJHRVWJBD<LRDRLGWKAMQ>>>, Id32<EWICTHMTERF<OXBJHRVWJBD<LRDRLGWKAMQ>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x2BA8210", Offset = "0x2BA6C10", VA = "0x182BA8210")]
		public static (Id32<EWICTHMTERF<QIRCDDDMPGO>>, Id32<EWICTHMTERF<RBMWJAHCKAJ>>, Id32<EWICTHMTERF<RBMWJAHCKAJ>>, Id32<EWICTHMTERF<OXBJHRVWJBD<RBMWJAHCKAJ>>>) PGMTNZBZTFW(this UnsafeList<byte> a, int b, int c, [Optional] Id32<OXBJHRVWJBD<RBMWJAHCKAJ>>? d)
		{
			return default((Id32<EWICTHMTERF<QIRCDDDMPGO>>, Id32<EWICTHMTERF<RBMWJAHCKAJ>>, Id32<EWICTHMTERF<RBMWJAHCKAJ>>, Id32<EWICTHMTERF<OXBJHRVWJBD<RBMWJAHCKAJ>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x2BA7630", Offset = "0x2BA6030", VA = "0x182BA7630")]
		public static (Id32<EWICTHMTERF<QIRCDDDMPGO>>, Id32<EWICTHMTERF<RBMWJAHCKAJ>>, Id32<EWICTHMTERF<OXBJHRVWJBD<RBMWJAHCKAJ>>>, Id32<EWICTHMTERF<OXBJHRVWJBD<RBMWJAHCKAJ>>>) MQFYCXVVIQD(this UnsafeList<byte> a, int b, [Optional] Id32<OXBJHRVWJBD<RBMWJAHCKAJ>>? c, [Optional] Id32<OXBJHRVWJBD<RBMWJAHCKAJ>>? d)
		{
			return default((Id32<EWICTHMTERF<QIRCDDDMPGO>>, Id32<EWICTHMTERF<RBMWJAHCKAJ>>, Id32<EWICTHMTERF<OXBJHRVWJBD<RBMWJAHCKAJ>>>, Id32<EWICTHMTERF<OXBJHRVWJBD<RBMWJAHCKAJ>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x2BAA7C0", Offset = "0x2BA91C0", VA = "0x182BAA7C0")]
		public static (Id32<EWICTHMTERF<QIRCDDDMPGO>>, Id32<EWICTHMTERF<OXBJHRVWJBD<RBMWJAHCKAJ>>>, Id32<EWICTHMTERF<OXBJHRVWJBD<RBMWJAHCKAJ>>>, Id32<EWICTHMTERF<OXBJHRVWJBD<RBMWJAHCKAJ>>>) ZHHVFNBIBRA(this UnsafeList<byte> a, [Optional] Id32<OXBJHRVWJBD<RBMWJAHCKAJ>>? b, [Optional] Id32<OXBJHRVWJBD<RBMWJAHCKAJ>>? c, [Optional] Id32<OXBJHRVWJBD<RBMWJAHCKAJ>>? d)
		{
			return default((Id32<EWICTHMTERF<QIRCDDDMPGO>>, Id32<EWICTHMTERF<OXBJHRVWJBD<RBMWJAHCKAJ>>>, Id32<EWICTHMTERF<OXBJHRVWJBD<RBMWJAHCKAJ>>>, Id32<EWICTHMTERF<OXBJHRVWJBD<RBMWJAHCKAJ>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x2BA6030", Offset = "0x2BA4A30", VA = "0x182BA6030")]
		public static (Id32<EWICTHMTERF<QIRCDDDMPGO>>, Id32<EWICTHMTERF<RBMWJAHCKAJ>>, Id32<EWICTHMTERF<RBMWJAHCKAJ>>, Id32<EWICTHMTERF<OXBJHRVWJBD<RBMWJAHCKAJ>>>) FTBFKIQVQHX(this UnsafeList<byte> a, int b, int c, [Optional] Id32<OXBJHRVWJBD<RBMWJAHCKAJ>>? d)
		{
			return default((Id32<EWICTHMTERF<QIRCDDDMPGO>>, Id32<EWICTHMTERF<RBMWJAHCKAJ>>, Id32<EWICTHMTERF<RBMWJAHCKAJ>>, Id32<EWICTHMTERF<OXBJHRVWJBD<RBMWJAHCKAJ>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x2BAA150", Offset = "0x2BA8B50", VA = "0x182BAA150")]
		public static (Id32<EWICTHMTERF<QIRCDDDMPGO>>, Id32<EWICTHMTERF<RBMWJAHCKAJ>>, Id32<EWICTHMTERF<OXBJHRVWJBD<RBMWJAHCKAJ>>>, Id32<EWICTHMTERF<OXBJHRVWJBD<RBMWJAHCKAJ>>>) WPOFMFFWGLU(this UnsafeList<byte> a, int b, [Optional] Id32<OXBJHRVWJBD<RBMWJAHCKAJ>>? c, [Optional] Id32<OXBJHRVWJBD<RBMWJAHCKAJ>>? d)
		{
			return default((Id32<EWICTHMTERF<QIRCDDDMPGO>>, Id32<EWICTHMTERF<RBMWJAHCKAJ>>, Id32<EWICTHMTERF<OXBJHRVWJBD<RBMWJAHCKAJ>>>, Id32<EWICTHMTERF<OXBJHRVWJBD<RBMWJAHCKAJ>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x2BA5470", Offset = "0x2BA3E70", VA = "0x182BA5470")]
		public static (Id32<EWICTHMTERF<QIRCDDDMPGO>>, Id32<EWICTHMTERF<OXBJHRVWJBD<RBMWJAHCKAJ>>>, Id32<EWICTHMTERF<OXBJHRVWJBD<RBMWJAHCKAJ>>>, Id32<EWICTHMTERF<OXBJHRVWJBD<RBMWJAHCKAJ>>>) DEWXBWMBSYH(this UnsafeList<byte> a, [Optional] Id32<OXBJHRVWJBD<RBMWJAHCKAJ>>? b, [Optional] Id32<OXBJHRVWJBD<RBMWJAHCKAJ>>? c, [Optional] Id32<OXBJHRVWJBD<RBMWJAHCKAJ>>? d)
		{
			return default((Id32<EWICTHMTERF<QIRCDDDMPGO>>, Id32<EWICTHMTERF<OXBJHRVWJBD<RBMWJAHCKAJ>>>, Id32<EWICTHMTERF<OXBJHRVWJBD<RBMWJAHCKAJ>>>, Id32<EWICTHMTERF<OXBJHRVWJBD<RBMWJAHCKAJ>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x2BA6800", Offset = "0x2BA5200", VA = "0x182BA6800")]
		public static (Id32<EWICTHMTERF<QIRCDDDMPGO>>, Id32<EWICTHMTERF<EWICTHMTERF<QIRCDDDMPGO>>>) HORCPVBPTGW(this UnsafeList<byte> a, [Optional] Id32<EWICTHMTERF<QIRCDDDMPGO>>? b)
		{
			return default((Id32<EWICTHMTERF<QIRCDDDMPGO>>, Id32<EWICTHMTERF<EWICTHMTERF<QIRCDDDMPGO>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x2BA5590", Offset = "0x2BA3F90", VA = "0x182BA5590")]
		public static (Id32<EWICTHMTERF<QIRCDDDMPGO>>, Id32<EWICTHMTERF<LRDRLGWKAMQ>>, Id32<EWICTHMTERF<LRDRLGWKAMQ>>, Id32<EWICTHMTERF<OXBJHRVWJBD<RBMWJAHCKAJ>>>) DVUUDWUMMYO(this UnsafeList<byte> a, float b, float c, [Optional] Id32<OXBJHRVWJBD<RBMWJAHCKAJ>>? d)
		{
			return default((Id32<EWICTHMTERF<QIRCDDDMPGO>>, Id32<EWICTHMTERF<LRDRLGWKAMQ>>, Id32<EWICTHMTERF<LRDRLGWKAMQ>>, Id32<EWICTHMTERF<OXBJHRVWJBD<RBMWJAHCKAJ>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x2BA5C30", Offset = "0x2BA4630", VA = "0x182BA5C30")]
		public static (Id32<EWICTHMTERF<QIRCDDDMPGO>>, Id32<EWICTHMTERF<LRDRLGWKAMQ>>, Id32<EWICTHMTERF<OXBJHRVWJBD<LRDRLGWKAMQ>>>, Id32<EWICTHMTERF<OXBJHRVWJBD<RBMWJAHCKAJ>>>) EYLJLIZKMEB(this UnsafeList<byte> a, float b, [Optional] Id32<OXBJHRVWJBD<LRDRLGWKAMQ>>? c, [Optional] Id32<OXBJHRVWJBD<RBMWJAHCKAJ>>? d)
		{
			return default((Id32<EWICTHMTERF<QIRCDDDMPGO>>, Id32<EWICTHMTERF<LRDRLGWKAMQ>>, Id32<EWICTHMTERF<OXBJHRVWJBD<LRDRLGWKAMQ>>>, Id32<EWICTHMTERF<OXBJHRVWJBD<RBMWJAHCKAJ>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x2BA51F0", Offset = "0x2BA3BF0", VA = "0x182BA51F0")]
		public static (Id32<EWICTHMTERF<QIRCDDDMPGO>>, Id32<EWICTHMTERF<OXBJHRVWJBD<LRDRLGWKAMQ>>>, Id32<EWICTHMTERF<OXBJHRVWJBD<LRDRLGWKAMQ>>>, Id32<EWICTHMTERF<OXBJHRVWJBD<RBMWJAHCKAJ>>>) BYCKZSJMYHK(this UnsafeList<byte> a, [Optional] Id32<OXBJHRVWJBD<LRDRLGWKAMQ>>? b, [Optional] Id32<OXBJHRVWJBD<LRDRLGWKAMQ>>? c, [Optional] Id32<OXBJHRVWJBD<RBMWJAHCKAJ>>? d)
		{
			return default((Id32<EWICTHMTERF<QIRCDDDMPGO>>, Id32<EWICTHMTERF<OXBJHRVWJBD<LRDRLGWKAMQ>>>, Id32<EWICTHMTERF<OXBJHRVWJBD<LRDRLGWKAMQ>>>, Id32<EWICTHMTERF<OXBJHRVWJBD<RBMWJAHCKAJ>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x2BA9700", Offset = "0x2BA8100", VA = "0x182BA9700")]
		public static (Id32<EWICTHMTERF<QIRCDDDMPGO>>, Id32<EWICTHMTERF<RBMWJAHCKAJ>>, Id32<EWICTHMTERF<RBMWJAHCKAJ>>, Id32<EWICTHMTERF<OXBJHRVWJBD<RBMWJAHCKAJ>>>) UBHSHZOJJZB(this UnsafeList<byte> a, int b, int c, [Optional] Id32<OXBJHRVWJBD<RBMWJAHCKAJ>>? d)
		{
			return default((Id32<EWICTHMTERF<QIRCDDDMPGO>>, Id32<EWICTHMTERF<RBMWJAHCKAJ>>, Id32<EWICTHMTERF<RBMWJAHCKAJ>>, Id32<EWICTHMTERF<OXBJHRVWJBD<RBMWJAHCKAJ>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x2BA5320", Offset = "0x2BA3D20", VA = "0x182BA5320")]
		public static (Id32<EWICTHMTERF<QIRCDDDMPGO>>, Id32<EWICTHMTERF<RBMWJAHCKAJ>>, Id32<EWICTHMTERF<OXBJHRVWJBD<RBMWJAHCKAJ>>>, Id32<EWICTHMTERF<OXBJHRVWJBD<RBMWJAHCKAJ>>>) CUTKRPSIVXO(this UnsafeList<byte> a, int b, [Optional] Id32<OXBJHRVWJBD<RBMWJAHCKAJ>>? c, [Optional] Id32<OXBJHRVWJBD<RBMWJAHCKAJ>>? d)
		{
			return default((Id32<EWICTHMTERF<QIRCDDDMPGO>>, Id32<EWICTHMTERF<RBMWJAHCKAJ>>, Id32<EWICTHMTERF<OXBJHRVWJBD<RBMWJAHCKAJ>>>, Id32<EWICTHMTERF<OXBJHRVWJBD<RBMWJAHCKAJ>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x2BA9CE0", Offset = "0x2BA86E0", VA = "0x182BA9CE0")]
		public static (Id32<EWICTHMTERF<QIRCDDDMPGO>>, Id32<EWICTHMTERF<OXBJHRVWJBD<RBMWJAHCKAJ>>>, Id32<EWICTHMTERF<OXBJHRVWJBD<RBMWJAHCKAJ>>>, Id32<EWICTHMTERF<OXBJHRVWJBD<RBMWJAHCKAJ>>>) VSEBYGXDYSV(this UnsafeList<byte> a, [Optional] Id32<OXBJHRVWJBD<RBMWJAHCKAJ>>? b, [Optional] Id32<OXBJHRVWJBD<RBMWJAHCKAJ>>? c, [Optional] Id32<OXBJHRVWJBD<RBMWJAHCKAJ>>? d)
		{
			return default((Id32<EWICTHMTERF<QIRCDDDMPGO>>, Id32<EWICTHMTERF<OXBJHRVWJBD<RBMWJAHCKAJ>>>, Id32<EWICTHMTERF<OXBJHRVWJBD<RBMWJAHCKAJ>>>, Id32<EWICTHMTERF<OXBJHRVWJBD<RBMWJAHCKAJ>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x2BA5D90", Offset = "0x2BA4790", VA = "0x182BA5D90")]
		public static (Id32<EWICTHMTERF<QIRCDDDMPGO>>, Id32<EWICTHMTERF<LRDRLGWKAMQ>>, Id32<EWICTHMTERF<LRDRLGWKAMQ>>, Id32<EWICTHMTERF<OXBJHRVWJBD<RBMWJAHCKAJ>>>) FGQTDCGMCKV(this UnsafeList<byte> a, float b, float c, [Optional] Id32<OXBJHRVWJBD<RBMWJAHCKAJ>>? d)
		{
			return default((Id32<EWICTHMTERF<QIRCDDDMPGO>>, Id32<EWICTHMTERF<LRDRLGWKAMQ>>, Id32<EWICTHMTERF<LRDRLGWKAMQ>>, Id32<EWICTHMTERF<OXBJHRVWJBD<RBMWJAHCKAJ>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x2BA8DA0", Offset = "0x2BA77A0", VA = "0x182BA8DA0")]
		public static (Id32<EWICTHMTERF<QIRCDDDMPGO>>, Id32<EWICTHMTERF<LRDRLGWKAMQ>>, Id32<EWICTHMTERF<OXBJHRVWJBD<LRDRLGWKAMQ>>>, Id32<EWICTHMTERF<OXBJHRVWJBD<RBMWJAHCKAJ>>>) SCVCSHJVHRY(this UnsafeList<byte> a, float b, [Optional] Id32<OXBJHRVWJBD<LRDRLGWKAMQ>>? c, [Optional] Id32<OXBJHRVWJBD<RBMWJAHCKAJ>>? d)
		{
			return default((Id32<EWICTHMTERF<QIRCDDDMPGO>>, Id32<EWICTHMTERF<LRDRLGWKAMQ>>, Id32<EWICTHMTERF<OXBJHRVWJBD<LRDRLGWKAMQ>>>, Id32<EWICTHMTERF<OXBJHRVWJBD<RBMWJAHCKAJ>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x2BA6A80", Offset = "0x2BA5480", VA = "0x182BA6A80")]
		public static (Id32<EWICTHMTERF<QIRCDDDMPGO>>, Id32<EWICTHMTERF<OXBJHRVWJBD<LRDRLGWKAMQ>>>, Id32<EWICTHMTERF<OXBJHRVWJBD<LRDRLGWKAMQ>>>, Id32<EWICTHMTERF<OXBJHRVWJBD<RBMWJAHCKAJ>>>) JZGRRBDWZPJ(this UnsafeList<byte> a, [Optional] Id32<OXBJHRVWJBD<LRDRLGWKAMQ>>? b, [Optional] Id32<OXBJHRVWJBD<LRDRLGWKAMQ>>? c, [Optional] Id32<OXBJHRVWJBD<RBMWJAHCKAJ>>? d)
		{
			return default((Id32<EWICTHMTERF<QIRCDDDMPGO>>, Id32<EWICTHMTERF<OXBJHRVWJBD<LRDRLGWKAMQ>>>, Id32<EWICTHMTERF<OXBJHRVWJBD<LRDRLGWKAMQ>>>, Id32<EWICTHMTERF<OXBJHRVWJBD<RBMWJAHCKAJ>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x2BA85E0", Offset = "0x2BA6FE0", VA = "0x182BA85E0")]
		public static (Id32<EWICTHMTERF<QIRCDDDMPGO>>, Id32<EWICTHMTERF<RBMWJAHCKAJ>>, Id32<EWICTHMTERF<RBMWJAHCKAJ>>, Id32<EWICTHMTERF<OXBJHRVWJBD<RBMWJAHCKAJ>>>) QNSKQITWIPO(this UnsafeList<byte> a, int b, int c, [Optional] Id32<OXBJHRVWJBD<RBMWJAHCKAJ>>? d)
		{
			return default((Id32<EWICTHMTERF<QIRCDDDMPGO>>, Id32<EWICTHMTERF<RBMWJAHCKAJ>>, Id32<EWICTHMTERF<RBMWJAHCKAJ>>, Id32<EWICTHMTERF<OXBJHRVWJBD<RBMWJAHCKAJ>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x2BA6E10", Offset = "0x2BA5810", VA = "0x182BA6E10")]
		public static (Id32<EWICTHMTERF<QIRCDDDMPGO>>, Id32<EWICTHMTERF<RBMWJAHCKAJ>>, Id32<EWICTHMTERF<OXBJHRVWJBD<RBMWJAHCKAJ>>>, Id32<EWICTHMTERF<OXBJHRVWJBD<RBMWJAHCKAJ>>>) KUFNUJRKQCP(this UnsafeList<byte> a, int b, [Optional] Id32<OXBJHRVWJBD<RBMWJAHCKAJ>>? c, [Optional] Id32<OXBJHRVWJBD<RBMWJAHCKAJ>>? d)
		{
			return default((Id32<EWICTHMTERF<QIRCDDDMPGO>>, Id32<EWICTHMTERF<RBMWJAHCKAJ>>, Id32<EWICTHMTERF<OXBJHRVWJBD<RBMWJAHCKAJ>>>, Id32<EWICTHMTERF<OXBJHRVWJBD<RBMWJAHCKAJ>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x2BA9860", Offset = "0x2BA8260", VA = "0x182BA9860")]
		public static (Id32<EWICTHMTERF<QIRCDDDMPGO>>, Id32<EWICTHMTERF<OXBJHRVWJBD<RBMWJAHCKAJ>>>, Id32<EWICTHMTERF<OXBJHRVWJBD<RBMWJAHCKAJ>>>, Id32<EWICTHMTERF<OXBJHRVWJBD<RBMWJAHCKAJ>>>) UIVKEWGPIRU(this UnsafeList<byte> a, [Optional] Id32<OXBJHRVWJBD<RBMWJAHCKAJ>>? b, [Optional] Id32<OXBJHRVWJBD<RBMWJAHCKAJ>>? c, [Optional] Id32<OXBJHRVWJBD<RBMWJAHCKAJ>>? d)
		{
			return default((Id32<EWICTHMTERF<QIRCDDDMPGO>>, Id32<EWICTHMTERF<OXBJHRVWJBD<RBMWJAHCKAJ>>>, Id32<EWICTHMTERF<OXBJHRVWJBD<RBMWJAHCKAJ>>>, Id32<EWICTHMTERF<OXBJHRVWJBD<RBMWJAHCKAJ>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x2BA6560", Offset = "0x2BA4F60", VA = "0x182BA6560")]
		public static (Id32<EWICTHMTERF<QIRCDDDMPGO>>, Id32<EWICTHMTERF<LRDRLGWKAMQ>>, Id32<EWICTHMTERF<LRDRLGWKAMQ>>, Id32<EWICTHMTERF<OXBJHRVWJBD<RBMWJAHCKAJ>>>) GJSICVEAVRH(this UnsafeList<byte> a, float b, float c, [Optional] Id32<OXBJHRVWJBD<RBMWJAHCKAJ>>? d)
		{
			return default((Id32<EWICTHMTERF<QIRCDDDMPGO>>, Id32<EWICTHMTERF<LRDRLGWKAMQ>>, Id32<EWICTHMTERF<LRDRLGWKAMQ>>, Id32<EWICTHMTERF<OXBJHRVWJBD<RBMWJAHCKAJ>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x2BA9490", Offset = "0x2BA7E90", VA = "0x182BA9490")]
		public static (Id32<EWICTHMTERF<QIRCDDDMPGO>>, Id32<EWICTHMTERF<LRDRLGWKAMQ>>, Id32<EWICTHMTERF<OXBJHRVWJBD<LRDRLGWKAMQ>>>, Id32<EWICTHMTERF<OXBJHRVWJBD<RBMWJAHCKAJ>>>) TLJSYSPDRPY(this UnsafeList<byte> a, float b, [Optional] Id32<OXBJHRVWJBD<LRDRLGWKAMQ>>? c, [Optional] Id32<OXBJHRVWJBD<RBMWJAHCKAJ>>? d)
		{
			return default((Id32<EWICTHMTERF<QIRCDDDMPGO>>, Id32<EWICTHMTERF<LRDRLGWKAMQ>>, Id32<EWICTHMTERF<OXBJHRVWJBD<LRDRLGWKAMQ>>>, Id32<EWICTHMTERF<OXBJHRVWJBD<RBMWJAHCKAJ>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x2BA9980", Offset = "0x2BA8380", VA = "0x182BA9980")]
		public static (Id32<EWICTHMTERF<QIRCDDDMPGO>>, Id32<EWICTHMTERF<OXBJHRVWJBD<LRDRLGWKAMQ>>>, Id32<EWICTHMTERF<OXBJHRVWJBD<LRDRLGWKAMQ>>>, Id32<EWICTHMTERF<OXBJHRVWJBD<RBMWJAHCKAJ>>>) ULYCHXDTEZF(this UnsafeList<byte> a, [Optional] Id32<OXBJHRVWJBD<LRDRLGWKAMQ>>? b, [Optional] Id32<OXBJHRVWJBD<LRDRLGWKAMQ>>? c, [Optional] Id32<OXBJHRVWJBD<RBMWJAHCKAJ>>? d)
		{
			return default((Id32<EWICTHMTERF<QIRCDDDMPGO>>, Id32<EWICTHMTERF<OXBJHRVWJBD<LRDRLGWKAMQ>>>, Id32<EWICTHMTERF<OXBJHRVWJBD<LRDRLGWKAMQ>>>, Id32<EWICTHMTERF<OXBJHRVWJBD<RBMWJAHCKAJ>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x2BA6190", Offset = "0x2BA4B90", VA = "0x182BA6190")]
		public static (Id32<EWICTHMTERF<QIRCDDDMPGO>>, Id32<EWICTHMTERF<RBMWJAHCKAJ>>, Id32<EWICTHMTERF<RBMWJAHCKAJ>>, Id32<EWICTHMTERF<OXBJHRVWJBD<RBMWJAHCKAJ>>>) FZPSUBPPSTC(this UnsafeList<byte> a, int b, int c, [Optional] Id32<OXBJHRVWJBD<RBMWJAHCKAJ>>? d)
		{
			return default((Id32<EWICTHMTERF<QIRCDDDMPGO>>, Id32<EWICTHMTERF<RBMWJAHCKAJ>>, Id32<EWICTHMTERF<RBMWJAHCKAJ>>, Id32<EWICTHMTERF<OXBJHRVWJBD<RBMWJAHCKAJ>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x2BA89E0", Offset = "0x2BA73E0", VA = "0x182BA89E0")]
		public static (Id32<EWICTHMTERF<QIRCDDDMPGO>>, Id32<EWICTHMTERF<RBMWJAHCKAJ>>, Id32<EWICTHMTERF<OXBJHRVWJBD<RBMWJAHCKAJ>>>, Id32<EWICTHMTERF<OXBJHRVWJBD<RBMWJAHCKAJ>>>) RQSKEYJRCOD(this UnsafeList<byte> a, int b, [Optional] Id32<OXBJHRVWJBD<RBMWJAHCKAJ>>? c, [Optional] Id32<OXBJHRVWJBD<RBMWJAHCKAJ>>? d)
		{
			return default((Id32<EWICTHMTERF<QIRCDDDMPGO>>, Id32<EWICTHMTERF<RBMWJAHCKAJ>>, Id32<EWICTHMTERF<OXBJHRVWJBD<RBMWJAHCKAJ>>>, Id32<EWICTHMTERF<OXBJHRVWJBD<RBMWJAHCKAJ>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x2BA5710", Offset = "0x2BA4110", VA = "0x182BA5710")]
		public static (Id32<EWICTHMTERF<QIRCDDDMPGO>>, Id32<EWICTHMTERF<OXBJHRVWJBD<RBMWJAHCKAJ>>>, Id32<EWICTHMTERF<OXBJHRVWJBD<RBMWJAHCKAJ>>>, Id32<EWICTHMTERF<OXBJHRVWJBD<RBMWJAHCKAJ>>>) EIFQVRHIDQG(this UnsafeList<byte> a, [Optional] Id32<OXBJHRVWJBD<RBMWJAHCKAJ>>? b, [Optional] Id32<OXBJHRVWJBD<RBMWJAHCKAJ>>? c, [Optional] Id32<OXBJHRVWJBD<RBMWJAHCKAJ>>? d)
		{
			return default((Id32<EWICTHMTERF<QIRCDDDMPGO>>, Id32<EWICTHMTERF<OXBJHRVWJBD<RBMWJAHCKAJ>>>, Id32<EWICTHMTERF<OXBJHRVWJBD<RBMWJAHCKAJ>>>, Id32<EWICTHMTERF<OXBJHRVWJBD<RBMWJAHCKAJ>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x2BAA520", Offset = "0x2BA8F20", VA = "0x182BAA520")]
		public static (Id32<EWICTHMTERF<QIRCDDDMPGO>>, Id32<EWICTHMTERF<LRDRLGWKAMQ>>, Id32<EWICTHMTERF<LRDRLGWKAMQ>>, Id32<EWICTHMTERF<OXBJHRVWJBD<RBMWJAHCKAJ>>>) YREPUEZFBRK(this UnsafeList<byte> a, float b, float c, [Optional] Id32<OXBJHRVWJBD<RBMWJAHCKAJ>>? d)
		{
			return default((Id32<EWICTHMTERF<QIRCDDDMPGO>>, Id32<EWICTHMTERF<LRDRLGWKAMQ>>, Id32<EWICTHMTERF<LRDRLGWKAMQ>>, Id32<EWICTHMTERF<OXBJHRVWJBD<RBMWJAHCKAJ>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x2BA5090", Offset = "0x2BA3A90", VA = "0x182BA5090")]
		public static (Id32<EWICTHMTERF<QIRCDDDMPGO>>, Id32<EWICTHMTERF<LRDRLGWKAMQ>>, Id32<EWICTHMTERF<OXBJHRVWJBD<LRDRLGWKAMQ>>>, Id32<EWICTHMTERF<OXBJHRVWJBD<RBMWJAHCKAJ>>>) BEMRCCWLZJJ(this UnsafeList<byte> a, float b, [Optional] Id32<OXBJHRVWJBD<LRDRLGWKAMQ>>? c, [Optional] Id32<OXBJHRVWJBD<RBMWJAHCKAJ>>? d)
		{
			return default((Id32<EWICTHMTERF<QIRCDDDMPGO>>, Id32<EWICTHMTERF<LRDRLGWKAMQ>>, Id32<EWICTHMTERF<OXBJHRVWJBD<LRDRLGWKAMQ>>>, Id32<EWICTHMTERF<OXBJHRVWJBD<RBMWJAHCKAJ>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x2BA7110", Offset = "0x2BA5B10", VA = "0x182BA7110")]
		public static (Id32<EWICTHMTERF<QIRCDDDMPGO>>, Id32<EWICTHMTERF<OXBJHRVWJBD<LRDRLGWKAMQ>>>, Id32<EWICTHMTERF<OXBJHRVWJBD<LRDRLGWKAMQ>>>, Id32<EWICTHMTERF<OXBJHRVWJBD<RBMWJAHCKAJ>>>) LFVDCKPAVNM(this UnsafeList<byte> a, [Optional] Id32<OXBJHRVWJBD<LRDRLGWKAMQ>>? b, [Optional] Id32<OXBJHRVWJBD<LRDRLGWKAMQ>>? c, [Optional] Id32<OXBJHRVWJBD<RBMWJAHCKAJ>>? d)
		{
			return default((Id32<EWICTHMTERF<QIRCDDDMPGO>>, Id32<EWICTHMTERF<OXBJHRVWJBD<LRDRLGWKAMQ>>>, Id32<EWICTHMTERF<OXBJHRVWJBD<LRDRLGWKAMQ>>>, Id32<EWICTHMTERF<OXBJHRVWJBD<RBMWJAHCKAJ>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x2BA9050", Offset = "0x2BA7A50", VA = "0x182BA9050")]
		public static (Id32<EWICTHMTERF<QIRCDDDMPGO>>, Id32<EWICTHMTERF<RBMWJAHCKAJ>>, Id32<EWICTHMTERF<RBMWJAHCKAJ>>, Id32<EWICTHMTERF<OXBJHRVWJBD<RBMWJAHCKAJ>>>) SKQXMTMWINL(this UnsafeList<byte> a, int b, int c, [Optional] Id32<OXBJHRVWJBD<RBMWJAHCKAJ>>? d)
		{
			return default((Id32<EWICTHMTERF<QIRCDDDMPGO>>, Id32<EWICTHMTERF<RBMWJAHCKAJ>>, Id32<EWICTHMTERF<RBMWJAHCKAJ>>, Id32<EWICTHMTERF<OXBJHRVWJBD<RBMWJAHCKAJ>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x2BA8890", Offset = "0x2BA7290", VA = "0x182BA8890")]
		public static (Id32<EWICTHMTERF<QIRCDDDMPGO>>, Id32<EWICTHMTERF<RBMWJAHCKAJ>>, Id32<EWICTHMTERF<OXBJHRVWJBD<RBMWJAHCKAJ>>>, Id32<EWICTHMTERF<OXBJHRVWJBD<RBMWJAHCKAJ>>>) ROMQMXTXHXY(this UnsafeList<byte> a, int b, [Optional] Id32<OXBJHRVWJBD<RBMWJAHCKAJ>>? c, [Optional] Id32<OXBJHRVWJBD<RBMWJAHCKAJ>>? d)
		{
			return default((Id32<EWICTHMTERF<QIRCDDDMPGO>>, Id32<EWICTHMTERF<RBMWJAHCKAJ>>, Id32<EWICTHMTERF<OXBJHRVWJBD<RBMWJAHCKAJ>>>, Id32<EWICTHMTERF<OXBJHRVWJBD<RBMWJAHCKAJ>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x2BA5990", Offset = "0x2BA4390", VA = "0x182BA5990")]
		public static (Id32<EWICTHMTERF<QIRCDDDMPGO>>, Id32<EWICTHMTERF<OXBJHRVWJBD<RBMWJAHCKAJ>>>, Id32<EWICTHMTERF<OXBJHRVWJBD<RBMWJAHCKAJ>>>, Id32<EWICTHMTERF<OXBJHRVWJBD<RBMWJAHCKAJ>>>) EPYSIEMVWZV(this UnsafeList<byte> a, [Optional] Id32<OXBJHRVWJBD<RBMWJAHCKAJ>>? b, [Optional] Id32<OXBJHRVWJBD<RBMWJAHCKAJ>>? c, [Optional] Id32<OXBJHRVWJBD<RBMWJAHCKAJ>>? d)
		{
			return default((Id32<EWICTHMTERF<QIRCDDDMPGO>>, Id32<EWICTHMTERF<OXBJHRVWJBD<RBMWJAHCKAJ>>>, Id32<EWICTHMTERF<OXBJHRVWJBD<RBMWJAHCKAJ>>>, Id32<EWICTHMTERF<OXBJHRVWJBD<RBMWJAHCKAJ>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x2BA5AB0", Offset = "0x2BA44B0", VA = "0x182BA5AB0")]
		public static (Id32<EWICTHMTERF<QIRCDDDMPGO>>, Id32<EWICTHMTERF<LRDRLGWKAMQ>>, Id32<EWICTHMTERF<LRDRLGWKAMQ>>, Id32<EWICTHMTERF<OXBJHRVWJBD<LRDRLGWKAMQ>>>) EYFBPRZJGCP(this UnsafeList<byte> a, float b, float c, [Optional] Id32<OXBJHRVWJBD<LRDRLGWKAMQ>>? d)
		{
			return default((Id32<EWICTHMTERF<QIRCDDDMPGO>>, Id32<EWICTHMTERF<LRDRLGWKAMQ>>, Id32<EWICTHMTERF<LRDRLGWKAMQ>>, Id32<EWICTHMTERF<OXBJHRVWJBD<LRDRLGWKAMQ>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x2BA74E0", Offset = "0x2BA5EE0", VA = "0x182BA74E0")]
		public static (Id32<EWICTHMTERF<QIRCDDDMPGO>>, Id32<EWICTHMTERF<LRDRLGWKAMQ>>, Id32<EWICTHMTERF<OXBJHRVWJBD<LRDRLGWKAMQ>>>, Id32<EWICTHMTERF<OXBJHRVWJBD<LRDRLGWKAMQ>>>) MEUFISDHXXK(this UnsafeList<byte> a, float b, [Optional] Id32<OXBJHRVWJBD<LRDRLGWKAMQ>>? c, [Optional] Id32<OXBJHRVWJBD<LRDRLGWKAMQ>>? d)
		{
			return default((Id32<EWICTHMTERF<QIRCDDDMPGO>>, Id32<EWICTHMTERF<LRDRLGWKAMQ>>, Id32<EWICTHMTERF<OXBJHRVWJBD<LRDRLGWKAMQ>>>, Id32<EWICTHMTERF<OXBJHRVWJBD<LRDRLGWKAMQ>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x2BAA6A0", Offset = "0x2BA90A0", VA = "0x182BAA6A0")]
		public static (Id32<EWICTHMTERF<QIRCDDDMPGO>>, Id32<EWICTHMTERF<OXBJHRVWJBD<LRDRLGWKAMQ>>>, Id32<EWICTHMTERF<OXBJHRVWJBD<LRDRLGWKAMQ>>>, Id32<EWICTHMTERF<OXBJHRVWJBD<LRDRLGWKAMQ>>>) ZDACSRVGZCJ(this UnsafeList<byte> a, [Optional] Id32<OXBJHRVWJBD<LRDRLGWKAMQ>>? b, [Optional] Id32<OXBJHRVWJBD<LRDRLGWKAMQ>>? c, [Optional] Id32<OXBJHRVWJBD<LRDRLGWKAMQ>>? d)
		{
			return default((Id32<EWICTHMTERF<QIRCDDDMPGO>>, Id32<EWICTHMTERF<OXBJHRVWJBD<LRDRLGWKAMQ>>>, Id32<EWICTHMTERF<OXBJHRVWJBD<LRDRLGWKAMQ>>>, Id32<EWICTHMTERF<OXBJHRVWJBD<LRDRLGWKAMQ>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x2BA80B0", Offset = "0x2BA6AB0", VA = "0x182BA80B0")]
		public static (Id32<EWICTHMTERF<QIRCDDDMPGO>>, Id32<EWICTHMTERF<RBMWJAHCKAJ>>, Id32<EWICTHMTERF<RBMWJAHCKAJ>>, Id32<EWICTHMTERF<OXBJHRVWJBD<RBMWJAHCKAJ>>>) ONTEBSGHPNT(this UnsafeList<byte> a, int b, int c, [Optional] Id32<OXBJHRVWJBD<RBMWJAHCKAJ>>? d)
		{
			return default((Id32<EWICTHMTERF<QIRCDDDMPGO>>, Id32<EWICTHMTERF<RBMWJAHCKAJ>>, Id32<EWICTHMTERF<RBMWJAHCKAJ>>, Id32<EWICTHMTERF<OXBJHRVWJBD<RBMWJAHCKAJ>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x2BA8490", Offset = "0x2BA6E90", VA = "0x182BA8490")]
		public static (Id32<EWICTHMTERF<QIRCDDDMPGO>>, Id32<EWICTHMTERF<RBMWJAHCKAJ>>, Id32<EWICTHMTERF<OXBJHRVWJBD<RBMWJAHCKAJ>>>, Id32<EWICTHMTERF<OXBJHRVWJBD<RBMWJAHCKAJ>>>) QIDBWNCPDRQ(this UnsafeList<byte> a, int b, [Optional] Id32<OXBJHRVWJBD<RBMWJAHCKAJ>>? c, [Optional] Id32<OXBJHRVWJBD<RBMWJAHCKAJ>>? d)
		{
			return default((Id32<EWICTHMTERF<QIRCDDDMPGO>>, Id32<EWICTHMTERF<RBMWJAHCKAJ>>, Id32<EWICTHMTERF<OXBJHRVWJBD<RBMWJAHCKAJ>>>, Id32<EWICTHMTERF<OXBJHRVWJBD<RBMWJAHCKAJ>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x2BA73C0", Offset = "0x2BA5DC0", VA = "0x182BA73C0")]
		public static (Id32<EWICTHMTERF<QIRCDDDMPGO>>, Id32<EWICTHMTERF<OXBJHRVWJBD<RBMWJAHCKAJ>>>, Id32<EWICTHMTERF<OXBJHRVWJBD<RBMWJAHCKAJ>>>, Id32<EWICTHMTERF<OXBJHRVWJBD<RBMWJAHCKAJ>>>) LYCKXCOFUTV(this UnsafeList<byte> a, [Optional] Id32<OXBJHRVWJBD<RBMWJAHCKAJ>>? b, [Optional] Id32<OXBJHRVWJBD<RBMWJAHCKAJ>>? c, [Optional] Id32<OXBJHRVWJBD<RBMWJAHCKAJ>>? d)
		{
			return default((Id32<EWICTHMTERF<QIRCDDDMPGO>>, Id32<EWICTHMTERF<OXBJHRVWJBD<RBMWJAHCKAJ>>>, Id32<EWICTHMTERF<OXBJHRVWJBD<RBMWJAHCKAJ>>>, Id32<EWICTHMTERF<OXBJHRVWJBD<RBMWJAHCKAJ>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x2BA6970", Offset = "0x2BA5370", VA = "0x182BA6970")]
		public static (Id32<EWICTHMTERF<QIRCDDDMPGO>>, Id32<EWICTHMTERF<RBMWJAHCKAJ>>, Id32<EWICTHMTERF<OXBJHRVWJBD<RBMWJAHCKAJ>>>) JHNLWIEVFSS(this UnsafeList<byte> a, [Optional] int? b, [Optional] Id32<OXBJHRVWJBD<RBMWJAHCKAJ>>? c)
		{
			return default((Id32<EWICTHMTERF<QIRCDDDMPGO>>, Id32<EWICTHMTERF<RBMWJAHCKAJ>>, Id32<EWICTHMTERF<OXBJHRVWJBD<RBMWJAHCKAJ>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x2BA9E00", Offset = "0x2BA8800", VA = "0x182BA9E00")]
		public static (Id32<EWICTHMTERF<QIRCDDDMPGO>>, Id32<EWICTHMTERF<OXBJHRVWJBD<RBMWJAHCKAJ>>>, Id32<EWICTHMTERF<OXBJHRVWJBD<RBMWJAHCKAJ>>>) VUXTLOQIWBL(this UnsafeList<byte> a, [Optional] Id32<OXBJHRVWJBD<RBMWJAHCKAJ>>? b, [Optional] Id32<OXBJHRVWJBD<RBMWJAHCKAJ>>? c)
		{
			return default((Id32<EWICTHMTERF<QIRCDDDMPGO>>, Id32<EWICTHMTERF<OXBJHRVWJBD<RBMWJAHCKAJ>>>, Id32<EWICTHMTERF<OXBJHRVWJBD<RBMWJAHCKAJ>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x2BA68F0", Offset = "0x2BA52F0", VA = "0x182BA68F0")]
		public static Id32<EWICTHMTERF<QIRCDDDMPGO>> HUQMOFJIWTO(this UnsafeList<byte> a)
		{
			return default(Id32<EWICTHMTERF<QIRCDDDMPGO>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x2BA91B0", Offset = "0x2BA7BB0", VA = "0x182BA91B0")]
		public static (Id32<EWICTHMTERF<QIRCDDDMPGO>>, Id32<EWICTHMTERF<LRDRLGWKAMQ>>, Id32<EWICTHMTERF<LRDRLGWKAMQ>>, Id32<EWICTHMTERF<OXBJHRVWJBD<LRDRLGWKAMQ>>>) SVYWYRNIZBR(this UnsafeList<byte> a, float b, float c, [Optional] Id32<OXBJHRVWJBD<LRDRLGWKAMQ>>? d)
		{
			return default((Id32<EWICTHMTERF<QIRCDDDMPGO>>, Id32<EWICTHMTERF<LRDRLGWKAMQ>>, Id32<EWICTHMTERF<LRDRLGWKAMQ>>, Id32<EWICTHMTERF<OXBJHRVWJBD<LRDRLGWKAMQ>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x2BA6BB0", Offset = "0x2BA55B0", VA = "0x182BA6BB0")]
		public static (Id32<EWICTHMTERF<QIRCDDDMPGO>>, Id32<EWICTHMTERF<LRDRLGWKAMQ>>, Id32<EWICTHMTERF<OXBJHRVWJBD<LRDRLGWKAMQ>>>, Id32<EWICTHMTERF<OXBJHRVWJBD<LRDRLGWKAMQ>>>) KASLPVGKZMU(this UnsafeList<byte> a, float b, [Optional] Id32<OXBJHRVWJBD<LRDRLGWKAMQ>>? c, [Optional] Id32<OXBJHRVWJBD<LRDRLGWKAMQ>>? d)
		{
			return default((Id32<EWICTHMTERF<QIRCDDDMPGO>>, Id32<EWICTHMTERF<LRDRLGWKAMQ>>, Id32<EWICTHMTERF<OXBJHRVWJBD<LRDRLGWKAMQ>>>, Id32<EWICTHMTERF<OXBJHRVWJBD<LRDRLGWKAMQ>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x2BA8370", Offset = "0x2BA6D70", VA = "0x182BA8370")]
		public static (Id32<EWICTHMTERF<QIRCDDDMPGO>>, Id32<EWICTHMTERF<OXBJHRVWJBD<LRDRLGWKAMQ>>>, Id32<EWICTHMTERF<OXBJHRVWJBD<LRDRLGWKAMQ>>>, Id32<EWICTHMTERF<OXBJHRVWJBD<LRDRLGWKAMQ>>>) PMDFIZERGPH(this UnsafeList<byte> a, [Optional] Id32<OXBJHRVWJBD<LRDRLGWKAMQ>>? b, [Optional] Id32<OXBJHRVWJBD<LRDRLGWKAMQ>>? c, [Optional] Id32<OXBJHRVWJBD<LRDRLGWKAMQ>>? d)
		{
			return default((Id32<EWICTHMTERF<QIRCDDDMPGO>>, Id32<EWICTHMTERF<OXBJHRVWJBD<LRDRLGWKAMQ>>>, Id32<EWICTHMTERF<OXBJHRVWJBD<LRDRLGWKAMQ>>>, Id32<EWICTHMTERF<OXBJHRVWJBD<LRDRLGWKAMQ>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x2BA5830", Offset = "0x2BA4230", VA = "0x182BA5830")]
		public static (Id32<EWICTHMTERF<QIRCDDDMPGO>>, Id32<EWICTHMTERF<RBMWJAHCKAJ>>, Id32<EWICTHMTERF<RBMWJAHCKAJ>>, Id32<EWICTHMTERF<OXBJHRVWJBD<RBMWJAHCKAJ>>>) EIYIERJRPYB(this UnsafeList<byte> a, int b, int c, [Optional] Id32<OXBJHRVWJBD<RBMWJAHCKAJ>>? d)
		{
			return default((Id32<EWICTHMTERF<QIRCDDDMPGO>>, Id32<EWICTHMTERF<RBMWJAHCKAJ>>, Id32<EWICTHMTERF<RBMWJAHCKAJ>>, Id32<EWICTHMTERF<OXBJHRVWJBD<RBMWJAHCKAJ>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x2BA8F00", Offset = "0x2BA7900", VA = "0x182BA8F00")]
		public static (Id32<EWICTHMTERF<QIRCDDDMPGO>>, Id32<EWICTHMTERF<RBMWJAHCKAJ>>, Id32<EWICTHMTERF<OXBJHRVWJBD<RBMWJAHCKAJ>>>, Id32<EWICTHMTERF<OXBJHRVWJBD<RBMWJAHCKAJ>>>) SFRSWVKKZTY(this UnsafeList<byte> a, int b, [Optional] Id32<OXBJHRVWJBD<RBMWJAHCKAJ>>? c, [Optional] Id32<OXBJHRVWJBD<RBMWJAHCKAJ>>? d)
		{
			return default((Id32<EWICTHMTERF<QIRCDDDMPGO>>, Id32<EWICTHMTERF<RBMWJAHCKAJ>>, Id32<EWICTHMTERF<OXBJHRVWJBD<RBMWJAHCKAJ>>>, Id32<EWICTHMTERF<OXBJHRVWJBD<RBMWJAHCKAJ>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x2BA9F10", Offset = "0x2BA8910", VA = "0x182BA9F10")]
		public static (Id32<EWICTHMTERF<QIRCDDDMPGO>>, Id32<EWICTHMTERF<OXBJHRVWJBD<RBMWJAHCKAJ>>>, Id32<EWICTHMTERF<OXBJHRVWJBD<RBMWJAHCKAJ>>>, Id32<EWICTHMTERF<OXBJHRVWJBD<RBMWJAHCKAJ>>>) WITRSMWPZOP(this UnsafeList<byte> a, [Optional] Id32<OXBJHRVWJBD<RBMWJAHCKAJ>>? b, [Optional] Id32<OXBJHRVWJBD<RBMWJAHCKAJ>>? c, [Optional] Id32<OXBJHRVWJBD<RBMWJAHCKAJ>>? d)
		{
			return default((Id32<EWICTHMTERF<QIRCDDDMPGO>>, Id32<EWICTHMTERF<OXBJHRVWJBD<RBMWJAHCKAJ>>>, Id32<EWICTHMTERF<OXBJHRVWJBD<RBMWJAHCKAJ>>>, Id32<EWICTHMTERF<OXBJHRVWJBD<RBMWJAHCKAJ>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x2BA6400", Offset = "0x2BA4E00", VA = "0x182BA6400")]
		public static (Id32<EWICTHMTERF<QIRCDDDMPGO>>, Id32<EWICTHMTERF<RBMWJAHCKAJ>>, Id32<EWICTHMTERF<RBMWJAHCKAJ>>, Id32<EWICTHMTERF<OXBJHRVWJBD<RBMWJAHCKAJ>>>) GFKKQBMGDRS(this UnsafeList<byte> a, int b, int c, [Optional] Id32<OXBJHRVWJBD<RBMWJAHCKAJ>>? d)
		{
			return default((Id32<EWICTHMTERF<QIRCDDDMPGO>>, Id32<EWICTHMTERF<RBMWJAHCKAJ>>, Id32<EWICTHMTERF<RBMWJAHCKAJ>>, Id32<EWICTHMTERF<OXBJHRVWJBD<RBMWJAHCKAJ>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x2BA8B30", Offset = "0x2BA7530", VA = "0x182BA8B30")]
		public static (Id32<EWICTHMTERF<QIRCDDDMPGO>>, Id32<EWICTHMTERF<RBMWJAHCKAJ>>, Id32<EWICTHMTERF<OXBJHRVWJBD<RBMWJAHCKAJ>>>, Id32<EWICTHMTERF<OXBJHRVWJBD<RBMWJAHCKAJ>>>) RZSYMUUMMHB(this UnsafeList<byte> a, int b, [Optional] Id32<OXBJHRVWJBD<RBMWJAHCKAJ>>? c, [Optional] Id32<OXBJHRVWJBD<RBMWJAHCKAJ>>? d)
		{
			return default((Id32<EWICTHMTERF<QIRCDDDMPGO>>, Id32<EWICTHMTERF<RBMWJAHCKAJ>>, Id32<EWICTHMTERF<OXBJHRVWJBD<RBMWJAHCKAJ>>>, Id32<EWICTHMTERF<OXBJHRVWJBD<RBMWJAHCKAJ>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x2BA66E0", Offset = "0x2BA50E0", VA = "0x182BA66E0")]
		public static (Id32<EWICTHMTERF<QIRCDDDMPGO>>, Id32<EWICTHMTERF<OXBJHRVWJBD<RBMWJAHCKAJ>>>, Id32<EWICTHMTERF<OXBJHRVWJBD<RBMWJAHCKAJ>>>, Id32<EWICTHMTERF<OXBJHRVWJBD<RBMWJAHCKAJ>>>) GTUIRYIFVKK(this UnsafeList<byte> a, [Optional] Id32<OXBJHRVWJBD<RBMWJAHCKAJ>>? b, [Optional] Id32<OXBJHRVWJBD<RBMWJAHCKAJ>>? c, [Optional] Id32<OXBJHRVWJBD<RBMWJAHCKAJ>>? d)
		{
			return default((Id32<EWICTHMTERF<QIRCDDDMPGO>>, Id32<EWICTHMTERF<OXBJHRVWJBD<RBMWJAHCKAJ>>>, Id32<EWICTHMTERF<OXBJHRVWJBD<RBMWJAHCKAJ>>>, Id32<EWICTHMTERF<OXBJHRVWJBD<RBMWJAHCKAJ>>>));
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
