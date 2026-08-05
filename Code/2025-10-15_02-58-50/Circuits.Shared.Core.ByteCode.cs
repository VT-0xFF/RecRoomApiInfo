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
		[Cpp2IlInjected.Address(RVA = "0xAC7BE0", Offset = "0xAC69E0", VA = "0x180AC7BE0")]
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
		[Cpp2IlInjected.Address(RVA = "0x2B10B30", Offset = "0x2B0F930", VA = "0x182B10B30")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xAC7F30", Offset = "0xAC6D30", VA = "0x180AC7F30")]
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
		[Cpp2IlInjected.Address(RVA = "0xAC7F70", Offset = "0xAC6D70", VA = "0x180AC7F70")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
namespace Circuits.Shared.Core.ByteCode
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public static class OBWUNZYSCYQ
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x3AE9D90", Offset = "0x3AE8B90", VA = "0x183AE9D90")]
		public static Id32<PWFCKDZBCDU<a>> WDBAAERBWGO<a>(this int a)
		{
			return default(Id32<PWFCKDZBCDU<a>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x2B10BB0", Offset = "0x2B0F9B0", VA = "0x182B10BB0")]
		public static Id32<HPBIAVPMDDB> IJREJPYMTEP(this int a)
		{
			return default(Id32<HPBIAVPMDDB>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x3AE9D90", Offset = "0x3AE8B90", VA = "0x183AE9D90")]
		public static Id32<MTKWVKXUIVO<b>> ZHZFDVDMPVK<b>(this int a)
		{
			return default(Id32<MTKWVKXUIVO<b>>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public sealed class PWFCKDZBCDU<a>
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public sealed class NCXCJLSDETL
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public sealed class GSPYYKIKJJK
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public sealed class HPBIAVPMDDB
	{
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public sealed class XVONRNCPECF
	{
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public sealed class NAUMMOFIYBZ
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
	public static class HTDOSECDQQQ
	{
		[Cpp2IlInjected.Token(Token = "0x200000E")]
		public readonly struct ProcessOpDelegate<TContext, TDeps, TCompileState>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000091")]
			private readonly IntPtr _impl;

			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0xF3B1C0", Offset = "0xF39FC0", VA = "0x180F3B1C0")]
			public ProcessOpDelegate(IntPtr impl)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x5CC53C0", Offset = "0x5CC41C0", VA = "0x185CC53C0")]
			public int Invoke(TDeps deps, TContext ctx, TCompileState compileState, [In] UnsafeList<byte> fromByteCode, int byteCodePtr)
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x39050C0", Offset = "0x3903EC0", VA = "0x1839050C0")]
		public static void OYHXAEEMUXF<TDeps, TContext, TCompileState>(TDeps a, TContext b, TCompileState c, [In] UnsafeList<byte> oldByteCode, UnsafeList<byte> newByteCode, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processAddF32_F32i_F32i_F32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processAddF32_F32i_F32r_F32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processAddF32_F32r_F32r_F32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processAddI32_I32i_I32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processAddI32_I32i_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processAddI32_I32r_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processAndI32_I32i_I32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processAndI32_I32i_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processAndI32_I32r_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfEqualF32_F32i_F32i_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfEqualF32_F32i_F32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfEqualF32_F32r_F32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfEqualI32_I32i_I32i_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfEqualI32_I32i_I32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfEqualI32_I32r_I32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfGreaterOrEqualF32_F32i_F32i_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfGreaterOrEqualF32_F32i_F32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfGreaterOrEqualF32_F32r_F32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfGreaterOrEqualI32_I32i_I32i_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfGreaterOrEqualI32_I32i_I32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfGreaterOrEqualI32_I32r_I32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfLessF32_F32i_F32i_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfLessF32_F32i_F32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfLessF32_F32r_F32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfLessI32_I32i_I32i_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfLessI32_I32i_I32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfLessI32_I32r_I32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfLessOrEqualF32_F32i_F32i_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfLessOrEqualF32_F32i_F32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfLessOrEqualF32_F32r_F32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfLessOrEqualI32_I32i_I32i_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfLessOrEqualI32_I32i_I32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfLessOrEqualI32_I32r_I32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfNotEqualF32_F32i_F32i_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfNotEqualF32_F32i_F32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfNotEqualF32_F32r_F32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfNotEqualI32_I32i_I32i_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfNotEqualI32_I32i_I32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfNotEqualI32_I32r_I32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfNotZeroF32_F32i_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfNotZeroF32_F32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfNotZeroI32_I32i_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfNotZeroI32_I32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfZeroF32_F32i_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfZeroF32_F32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfZeroI32_I32i_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfZeroI32_I32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processCallInternal_I32i_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processCallInternal_I32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processCallExternal_I32i_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processCallExternal_I32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processCallRuntime_I32i_I32i_Xi, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processCopyI32_I32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processCopyI32_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processCopyX_Xr_I32i_Xi, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processCopyX_Xr_Xr_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processDivideF32_F32i_F32i_F32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processDivideF32_F32i_F32r_F32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processDivideF32_F32r_F32r_F32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processDivideI32_I32i_I32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processDivideI32_I32i_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processDivideI32_I32r_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processEqualF32_F32i_F32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processEqualF32_F32i_F32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processEqualF32_F32r_F32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processEqualI32_I32i_I32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processEqualI32_I32i_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processEqualI32_I32r_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processEnd, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processGreaterF32_F32i_F32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processGreaterF32_F32i_F32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processGreaterF32_F32r_F32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processGreaterI32_I32i_I32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processGreaterI32_I32i_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processGreaterI32_I32r_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processGreaterOrEqualF32_F32i_F32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processGreaterOrEqualF32_F32i_F32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processGreaterOrEqualF32_F32r_F32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processGreaterOrEqualI32_I32i_I32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processGreaterOrEqualI32_I32i_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processGreaterOrEqualI32_I32r_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processJump_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processJump_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processLessF32_F32i_F32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processLessF32_F32i_F32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processLessF32_F32r_F32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processLessI32_I32i_I32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processLessI32_I32i_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processLessI32_I32r_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processLessOrEqualF32_F32i_F32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processLessOrEqualF32_F32i_F32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processLessOrEqualF32_F32r_F32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processLessOrEqualI32_I32i_I32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processLessOrEqualI32_I32i_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processLessOrEqualI32_I32r_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processModI32_I32i_I32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processModI32_I32i_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processModI32_I32r_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processMultiplyF32_F32i_F32i_F32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processMultiplyF32_F32i_F32r_F32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processMultiplyF32_F32r_F32r_F32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processMultiplyI32_I32i_I32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processMultiplyI32_I32i_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processMultiplyI32_I32r_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processNegateF32_F32i_F32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processNegateF32_F32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processNegateF32_F32r_F32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processNegateI32_I32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processNegateI32_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processNegateI32_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processNoOp, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processNotEqualF32_F32i_F32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processNotEqualF32_F32i_F32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processNotEqualF32_F32r_F32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processNotEqualI32_I32i_I32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processNotEqualI32_I32i_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processNotEqualI32_I32r_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processNotI32_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processNotI32_I32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processNotI32_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processOrI32_I32i_I32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processOrI32_I32i_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processOrI32_I32r_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processReturn, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processStaticCastF32I32_F32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processStaticCastI32F32_I32r_F32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processSubtractF32_F32i_F32i_F32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processSubtractF32_F32i_F32r_F32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processSubtractF32_F32r_F32r_F32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processSubtractI32_I32i_I32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processSubtractI32_I32i_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processSubtractI32_I32r_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processXorI32_I32i_I32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processXorI32_I32i_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processXorI32_I32r_I32r_I32r) where TDeps : notnull where TContext : notnull where TCompileState : notnull
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x2B0B0F0", Offset = "0x2B09EF0", VA = "0x182B0B0F0")]
		private static int CYLGKMMFZMB([In] UnsafeList<byte> from, UnsafeList<byte> a, int b, int c)
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public static class DFMSLPSCSQT
	{
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		public static readonly int FBDQUJTVHFJ;

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x37BCE80", Offset = "0x37BBC80", VA = "0x1837BCE80")]
		public static Id32<PWFCKDZBCDU<a>> GXQFWEDPOEV<a>([In] this UnsafeList<byte> self)
		{
			return default(Id32<PWFCKDZBCDU<a>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x37BCD50", Offset = "0x37BBB50", VA = "0x1837BCD50")]
		public static Id32<PWFCKDZBCDU<PWFCKDZBCDU<b>>> AWAYEGHAFNI<b>(this UnsafeList<byte> a, [Optional] Id32<PWFCKDZBCDU<b>>? b)
		{
			return default(Id32<PWFCKDZBCDU<PWFCKDZBCDU<b>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x2B0AD00", Offset = "0x2B09B00", VA = "0x182B0AD00")]
		public static Id32<PWFCKDZBCDU<HJVJIQEFSCR>> OYHHYVSTWIE(this UnsafeList<byte> a, [Optional] Id32<HJVJIQEFSCR>? b)
		{
			return default(Id32<PWFCKDZBCDU<HJVJIQEFSCR>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x2B0AC10", Offset = "0x2B09A10", VA = "0x182B0AC10")]
		public static Id32<PWFCKDZBCDU<NCXCJLSDETL>> OXFJKXELZPU(this UnsafeList<byte> a, [Optional] float? b)
		{
			return default(Id32<PWFCKDZBCDU<NCXCJLSDETL>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x2B0AFD0", Offset = "0x2B09DD0", VA = "0x182B0AFD0")]
		public static Id32<PWFCKDZBCDU<GSPYYKIKJJK>> VSOMYXPRVRF(this UnsafeList<byte> a, [Optional] int? b)
		{
			return default(Id32<PWFCKDZBCDU<GSPYYKIKJJK>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x2B0AEE0", Offset = "0x2B09CE0", VA = "0x182B0AEE0")]
		public static Id32<PWFCKDZBCDU<VHIMMWYWAFQ>> VEIOUSBKEFL(this UnsafeList<byte> a, [Optional] Id32<VHIMMWYWAFQ>? b)
		{
			return default(Id32<PWFCKDZBCDU<VHIMMWYWAFQ>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x2B0AA20", Offset = "0x2B09820", VA = "0x182B0AA20")]
		public static Id32<PWFCKDZBCDU<NAUMMOFIYBZ>> ELUHACUWIUS(this UnsafeList<byte> a, [Optional] byte? b)
		{
			return default(Id32<PWFCKDZBCDU<NAUMMOFIYBZ>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x2B0AB20", Offset = "0x2B09920", VA = "0x182B0AB20")]
		public static Id32<PWFCKDZBCDU<HPBIAVPMDDB>> GPJBZFXRZKS(this UnsafeList<byte> a, [Optional] Id32<HPBIAVPMDDB>? b)
		{
			return default(Id32<PWFCKDZBCDU<HPBIAVPMDDB>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x2B0ADF0", Offset = "0x2B09BF0", VA = "0x182B0ADF0")]
		public static Id32<PWFCKDZBCDU<XVONRNCPECF>> PDIBWXLSTVK(this UnsafeList<byte> a, [Optional] Op? b)
		{
			return default(Id32<PWFCKDZBCDU<XVONRNCPECF>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x37BCD50", Offset = "0x37BBB50", VA = "0x1837BCD50")]
		public static Id32<PWFCKDZBCDU<MTKWVKXUIVO<c>>> DLLFWVFZAZS<c>(this UnsafeList<byte> a, [Optional] Id32<MTKWVKXUIVO<c>>? b)
		{
			return default(Id32<PWFCKDZBCDU<MTKWVKXUIVO<c>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x2B0A510", Offset = "0x2B09310", VA = "0x182B0A510")]
		public static void TICMQUEYUZS(this UnsafeList<byte> a, Id32<PWFCKDZBCDU<GSPYYKIKJJK>> b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x37BCEF0", Offset = "0x37BBCF0", VA = "0x1837BCEF0")]
		public static void NSEXUNZBSWV<d>(this UnsafeList<byte> a, Id32<PWFCKDZBCDU<PWFCKDZBCDU<d>>> b, Id32<PWFCKDZBCDU<d>> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x37BCEF0", Offset = "0x37BBCF0", VA = "0x1837BCEF0")]
		public static void KPDIONSYGMX<e>(this UnsafeList<byte> a, Id32<PWFCKDZBCDU<MTKWVKXUIVO<e>>> b, Id32<MTKWVKXUIVO<e>> c)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public static class OXXBQVENVTU
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x2B10BF0", Offset = "0x2B0F9F0", VA = "0x182B10BF0")]
		public static Union32 SNPIWFPHPVW([In] this ReadOnlySpan<byte> bytes, int a)
		{
			return default(Union32);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x2B10C60", Offset = "0x2B0FA60", VA = "0x182B10C60")]
		public static Union32 SNPIWFPHPVW([In] this UnsafeList<byte> bytes, int a)
		{
			return default(Union32);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x3AF4510", Offset = "0x3AF3310", VA = "0x183AF4510")]
		public static Union32 SNPIWFPHPVW<f>(this ReadOnlyIdArray<f, byte> a, Id32<f> b)
		{
			return default(Union32);
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x3AF4690", Offset = "0x3AF3490", VA = "0x183AF4690")]
		public static Union32 SNPIWFPHPVW<g>([In] this ReadOnlyIdSpan<g, byte> bytes, Id32<g> a)
		{
			return default(Union32);
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x3AF4810", Offset = "0x3AF3610", VA = "0x183AF4810")]
		public static Union32 SNPIWFPHPVW<i>(this IdArray<i, byte> a, Id32<i> b)
		{
			return default(Union32);
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x3AF44A0", Offset = "0x3AF32A0", VA = "0x183AF44A0")]
		public static Union32 SNPIWFPHPVW<j>([In] this IdSpan<j, byte> bytes, Id32<j> a)
		{
			return default(Union32);
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x3AF43E0", Offset = "0x3AF31E0", VA = "0x183AF43E0")]
		public static Union32 SNPIWFPHPVW<k>(this ReadOnlyIdArray<k, byte> a, Id32<k> b)
		{
			return default(Union32);
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x2B10BF0", Offset = "0x2B0F9F0", VA = "0x182B10BF0")]
		public static int NEBFNNGESBN([In] this ReadOnlySpan<byte> bytes, int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x2B0A610", Offset = "0x2B09410", VA = "0x182B0A610")]
		public static int NEBFNNGESBN([In] this UnsafeList<byte> bytes, int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x3AF3950", Offset = "0x3AF2750", VA = "0x183AF3950")]
		public static int NEBFNNGESBN<p>(this ReadOnlyIdArray<p, byte> a, Id32<p> b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x3AF38D0", Offset = "0x3AF26D0", VA = "0x183AF38D0")]
		public static int NEBFNNGESBN<s>(this IdArray<s, byte> a, Id32<s> b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x3AF3880", Offset = "0x3AF2680", VA = "0x183AF3880")]
		public static int NEBFNNGESBN<t>([In] this IdSpan<t, byte> bytes, Id32<t> a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x3AF3830", Offset = "0x3AF2630", VA = "0x183AF3830")]
		public static int NEBFNNGESBN<u>(this ReadOnlyIdArray<u, byte> a, Id32<u> b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x3AF3EF0", Offset = "0x3AF2CF0", VA = "0x183AF3EF0")]
		public static float SBRHPUNBRLY<bc>(this IdArray<bc, byte> a, Id32<bc> b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x3AF3FC0", Offset = "0x3AF2DC0", VA = "0x183AF3FC0")]
		public static float SBRHPUNBRLY<bd>([In] this IdSpan<bd, byte> bytes, Id32<bd> a)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x3AF3F70", Offset = "0x3AF2D70", VA = "0x183AF3F70")]
		public static float SBRHPUNBRLY<be>(this ReadOnlyIdArray<be, byte> a, Id32<be> b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x3AF4A20", Offset = "0x3AF3820", VA = "0x183AF4A20")]
		public static byte TRZDUMPYDGG<bj>(this ReadOnlyIdArray<bj, byte> a, Id32<bj> b)
		{
			return default(byte);
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x3AF4A70", Offset = "0x3AF3870", VA = "0x183AF4A70")]
		public static byte TRZDUMPYDGG<bk>([In] this ReadOnlyIdSpan<bk, byte> bytes, Id32<bk> a)
		{
			return default(byte);
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x3AF49A0", Offset = "0x3AF37A0", VA = "0x183AF49A0")]
		public static byte TRZDUMPYDGG<bm>(this IdArray<bm, byte> a, Id32<bm> b)
		{
			return default(byte);
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x3AF4AC0", Offset = "0x3AF38C0", VA = "0x183AF4AC0")]
		public static byte TRZDUMPYDGG<bn>([In] this IdSpan<bn, byte> bytes, Id32<bn> a)
		{
			return default(byte);
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x3AF4B50", Offset = "0x3AF3950", VA = "0x183AF4B50")]
		public static byte TRZDUMPYDGG<bo>(this ReadOnlyIdArray<bo, byte> a, Id32<bo> b)
		{
			return default(byte);
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x2B0A610", Offset = "0x2B09410", VA = "0x182B0A610")]
		public static Op MSINSSOJABK([In] this UnsafeList<byte> bytes, int a)
		{
			return default(Op);
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x3AF3730", Offset = "0x3AF2530", VA = "0x183AF3730")]
		public static Op MSINSSOJABK<by>(this ReadOnlyIdArray<by, byte> a, Id32<by> b)
		{
			return default(Op);
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x3AF4F40", Offset = "0x3AF3D40", VA = "0x183AF4F40")]
		public static Id32<PWFCKDZBCDU<CJHMTIIQUWA>> WIADLRZFCYS<cg>(this IdArray<cg, byte> a, Id32<cg> b)
		{
			return default(Id32<PWFCKDZBCDU<CJHMTIIQUWA>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x3AF4EB0", Offset = "0x3AF3CB0", VA = "0x183AF4EB0")]
		public static Id32<PWFCKDZBCDU<CJHMTIIQUWA>> WIADLRZFCYS<ch>([In] this IdSpan<ch, byte> bytes, Id32<ch> a)
		{
			return default(Id32<PWFCKDZBCDU<CJHMTIIQUWA>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x3AF4FC0", Offset = "0x3AF3DC0", VA = "0x183AF4FC0")]
		public static Id32<PWFCKDZBCDU<CJHMTIIQUWA>> WIADLRZFCYS<ci>(this ReadOnlyIdArray<ci, byte> a, Id32<ci> b)
		{
			return default(Id32<PWFCKDZBCDU<CJHMTIIQUWA>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x3AF3D40", Offset = "0x3AF2B40", VA = "0x183AF3D40")]
		public static Id32<MTKWVKXUIVO<CJHMTIIQUWA>> PQQSBZTRNQE<cs>(this ReadOnlyIdArray<cs, byte> a, Id32<cs> b)
		{
			return default(Id32<MTKWVKXUIVO<CJHMTIIQUWA>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x3AF3C40", Offset = "0x3AF2A40", VA = "0x183AF3C40")]
		public static Id32<HPBIAVPMDDB> NWBVFDDKOYI<da>(this IdArray<da, byte> a, Id32<da> b)
		{
			return default(Id32<HPBIAVPMDDB>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x3AF3BB0", Offset = "0x3AF29B0", VA = "0x183AF3BB0")]
		public static Id32<HPBIAVPMDDB> NWBVFDDKOYI<db>([In] this IdSpan<db, byte> bytes, Id32<db> a)
		{
			return default(Id32<HPBIAVPMDDB>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x3AF3B20", Offset = "0x3AF2920", VA = "0x183AF3B20")]
		public static Id32<HPBIAVPMDDB> NWBVFDDKOYI<dc>(this ReadOnlyIdArray<dc, byte> a, Id32<dc> b)
		{
			return default(Id32<HPBIAVPMDDB>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x3AF35C0", Offset = "0x3AF23C0", VA = "0x183AF35C0")]
		public static Id32<HJVJIQEFSCR> LCXSMTKWWFU<dl>([In] this IdSpan<dl, byte> bytes, Id32<dl> a)
		{
			return default(Id32<HJVJIQEFSCR>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x3AF3650", Offset = "0x3AF2450", VA = "0x183AF3650")]
		public static Id32<HJVJIQEFSCR> LCXSMTKWWFU<dm>(this ReadOnlyIdArray<dm, byte> a, Id32<dm> b)
		{
			return default(Id32<HJVJIQEFSCR>);
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x3AF4CA0", Offset = "0x3AF3AA0", VA = "0x183AF4CA0")]
		public static Id32<VHIMMWYWAFQ> VXAWPVJXLIF<dw>(this ReadOnlyIdArray<dw, byte> a, Id32<dw> b)
		{
			return default(Id32<VHIMMWYWAFQ>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public static class CHMNLXWZWGG
	{
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x2B0A870", Offset = "0x2B09670", VA = "0x182B0A870")]
		public static void YATQOFVHTNZ(this UnsafeList<byte> a, int b, Union32 c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x2B0A930", Offset = "0x2B09730", VA = "0x182B0A930")]
		public static void YATQOFVHTNZ(this byte[] a, int b, Union32 c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x2B0A9A0", Offset = "0x2B097A0", VA = "0x182B0A9A0")]
		public static void YATQOFVHTNZ([In] this Span<byte> bytes, int a, Union32 b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x36DDCC0", Offset = "0x36DCAC0", VA = "0x1836DDCC0")]
		public static void YATQOFVHTNZ<e>(this IdArray<e, byte> a, Id32<e> b, Union32 c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x36DDE10", Offset = "0x36DCC10", VA = "0x1836DDE10")]
		public static void YATQOFVHTNZ<f>([In] this IdSpan<f, byte> bytes, Id32<f> a, Union32 b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x2B0A510", Offset = "0x2B09310", VA = "0x182B0A510")]
		public static void TICMQUEYUZS(this UnsafeList<byte> a, int b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x2B0A7F0", Offset = "0x2B095F0", VA = "0x182B0A7F0")]
		public static void TICMQUEYUZS(this byte[] a, int b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x2B0A770", Offset = "0x2B09570", VA = "0x182B0A770")]
		public static void TICMQUEYUZS([In] this Span<byte> bytes, int a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x36DDA60", Offset = "0x36DC860", VA = "0x1836DDA60")]
		public static void TICMQUEYUZS<h>(this IdArray<h, byte> a, Id32<h> b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x36DDA00", Offset = "0x36DC800", VA = "0x1836DDA00")]
		public static void TICMQUEYUZS<i>([In] this IdSpan<i, byte> bytes, Id32<i> a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x2B0A730", Offset = "0x2B09530", VA = "0x182B0A730")]
		public static void NIASPMNHSCZ(this UnsafeList<byte> a, int b, float c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x36DD8B0", Offset = "0x36DC6B0", VA = "0x1836DD8B0")]
		public static void NIASPMNHSCZ<k>(this IdArray<k, byte> a, Id32<k> b, float c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x36DD840", Offset = "0x36DC640", VA = "0x1836DD840")]
		public static void NIASPMNHSCZ<l>([In] this IdSpan<l, byte> bytes, Id32<l> a, float b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x2B0A6C0", Offset = "0x2B094C0", VA = "0x182B0A6C0")]
		public static void HZLMDFRJBFJ(this UnsafeList<byte> a, int b, byte c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x36DD710", Offset = "0x36DC510", VA = "0x1836DD710")]
		public static void HZLMDFRJBFJ<n>(this IdArray<n, byte> a, Id32<n> b, byte c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x36DD6B0", Offset = "0x36DC4B0", VA = "0x1836DD6B0")]
		public static void HZLMDFRJBFJ<o>([In] this IdSpan<o, byte> bytes, Id32<o> a, byte b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x36DD580", Offset = "0x36DC380", VA = "0x1836DD580")]
		public static void NSEXUNZBSWV<q>(this IdArray<q, byte> a, Id32<q> b, Id32<PWFCKDZBCDU<CJHMTIIQUWA>> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x36DD500", Offset = "0x36DC300", VA = "0x1836DD500")]
		public static void NSEXUNZBSWV<r>([In] this IdSpan<r, byte> bytes, Id32<r> a, Id32<PWFCKDZBCDU<CJHMTIIQUWA>> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x36DD580", Offset = "0x36DC380", VA = "0x1836DD580")]
		public static void FVSQPBSNOWT<t>(this IdArray<t, byte> a, Id32<t> b, Id32<HPBIAVPMDDB> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x36DD500", Offset = "0x36DC300", VA = "0x1836DD500")]
		public static void FVSQPBSNOWT<u>([In] this IdSpan<u, byte> bytes, Id32<u> a, Id32<HPBIAVPMDDB> b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public static class MILORYKQXSH
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x2B0DC60", Offset = "0x2B0CA60", VA = "0x182B0DC60")]
		public static (Id32<PWFCKDZBCDU<XVONRNCPECF>>, Id32<PWFCKDZBCDU<NCXCJLSDETL>>, Id32<PWFCKDZBCDU<NCXCJLSDETL>>, Id32<PWFCKDZBCDU<MTKWVKXUIVO<NCXCJLSDETL>>>) MVHPGFXSGFR(this UnsafeList<byte> a, float b, float c, [Optional] Id32<MTKWVKXUIVO<NCXCJLSDETL>>? d)
		{
			return default((Id32<PWFCKDZBCDU<XVONRNCPECF>>, Id32<PWFCKDZBCDU<NCXCJLSDETL>>, Id32<PWFCKDZBCDU<NCXCJLSDETL>>, Id32<PWFCKDZBCDU<MTKWVKXUIVO<NCXCJLSDETL>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x2B0C340", Offset = "0x2B0B140", VA = "0x182B0C340")]
		public static (Id32<PWFCKDZBCDU<XVONRNCPECF>>, Id32<PWFCKDZBCDU<NCXCJLSDETL>>, Id32<PWFCKDZBCDU<MTKWVKXUIVO<NCXCJLSDETL>>>, Id32<PWFCKDZBCDU<MTKWVKXUIVO<NCXCJLSDETL>>>) FHKUFZLGPOE(this UnsafeList<byte> a, float b, [Optional] Id32<MTKWVKXUIVO<NCXCJLSDETL>>? c, [Optional] Id32<MTKWVKXUIVO<NCXCJLSDETL>>? d)
		{
			return default((Id32<PWFCKDZBCDU<XVONRNCPECF>>, Id32<PWFCKDZBCDU<NCXCJLSDETL>>, Id32<PWFCKDZBCDU<MTKWVKXUIVO<NCXCJLSDETL>>>, Id32<PWFCKDZBCDU<MTKWVKXUIVO<NCXCJLSDETL>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x2B102F0", Offset = "0x2B0F0F0", VA = "0x182B102F0")]
		public static (Id32<PWFCKDZBCDU<XVONRNCPECF>>, Id32<PWFCKDZBCDU<MTKWVKXUIVO<NCXCJLSDETL>>>, Id32<PWFCKDZBCDU<MTKWVKXUIVO<NCXCJLSDETL>>>, Id32<PWFCKDZBCDU<MTKWVKXUIVO<NCXCJLSDETL>>>) WLFWLUYTCON(this UnsafeList<byte> a, [Optional] Id32<MTKWVKXUIVO<NCXCJLSDETL>>? b, [Optional] Id32<MTKWVKXUIVO<NCXCJLSDETL>>? c, [Optional] Id32<MTKWVKXUIVO<NCXCJLSDETL>>? d)
		{
			return default((Id32<PWFCKDZBCDU<XVONRNCPECF>>, Id32<PWFCKDZBCDU<MTKWVKXUIVO<NCXCJLSDETL>>>, Id32<PWFCKDZBCDU<MTKWVKXUIVO<NCXCJLSDETL>>>, Id32<PWFCKDZBCDU<MTKWVKXUIVO<NCXCJLSDETL>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x2B0D340", Offset = "0x2B0C140", VA = "0x182B0D340")]
		public static (Id32<PWFCKDZBCDU<XVONRNCPECF>>, Id32<PWFCKDZBCDU<GSPYYKIKJJK>>, Id32<PWFCKDZBCDU<GSPYYKIKJJK>>, Id32<PWFCKDZBCDU<MTKWVKXUIVO<GSPYYKIKJJK>>>) KFEMDBRGLTX(this UnsafeList<byte> a, int b, int c, [Optional] Id32<MTKWVKXUIVO<GSPYYKIKJJK>>? d)
		{
			return default((Id32<PWFCKDZBCDU<XVONRNCPECF>>, Id32<PWFCKDZBCDU<GSPYYKIKJJK>>, Id32<PWFCKDZBCDU<GSPYYKIKJJK>>, Id32<PWFCKDZBCDU<MTKWVKXUIVO<GSPYYKIKJJK>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x2B0D870", Offset = "0x2B0C670", VA = "0x182B0D870")]
		public static (Id32<PWFCKDZBCDU<XVONRNCPECF>>, Id32<PWFCKDZBCDU<GSPYYKIKJJK>>, Id32<PWFCKDZBCDU<MTKWVKXUIVO<GSPYYKIKJJK>>>, Id32<PWFCKDZBCDU<MTKWVKXUIVO<GSPYYKIKJJK>>>) MGZMYDFZRJQ(this UnsafeList<byte> a, int b, [Optional] Id32<MTKWVKXUIVO<GSPYYKIKJJK>>? c, [Optional] Id32<MTKWVKXUIVO<GSPYYKIKJJK>>? d)
		{
			return default((Id32<PWFCKDZBCDU<XVONRNCPECF>>, Id32<PWFCKDZBCDU<GSPYYKIKJJK>>, Id32<PWFCKDZBCDU<MTKWVKXUIVO<GSPYYKIKJJK>>>, Id32<PWFCKDZBCDU<MTKWVKXUIVO<GSPYYKIKJJK>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x2B10690", Offset = "0x2B0F490", VA = "0x182B10690")]
		public static (Id32<PWFCKDZBCDU<XVONRNCPECF>>, Id32<PWFCKDZBCDU<MTKWVKXUIVO<GSPYYKIKJJK>>>, Id32<PWFCKDZBCDU<MTKWVKXUIVO<GSPYYKIKJJK>>>, Id32<PWFCKDZBCDU<MTKWVKXUIVO<GSPYYKIKJJK>>>) YLTTYFBYRDR(this UnsafeList<byte> a, [Optional] Id32<MTKWVKXUIVO<GSPYYKIKJJK>>? b, [Optional] Id32<MTKWVKXUIVO<GSPYYKIKJJK>>? c, [Optional] Id32<MTKWVKXUIVO<GSPYYKIKJJK>>? d)
		{
			return default((Id32<PWFCKDZBCDU<XVONRNCPECF>>, Id32<PWFCKDZBCDU<MTKWVKXUIVO<GSPYYKIKJJK>>>, Id32<PWFCKDZBCDU<MTKWVKXUIVO<GSPYYKIKJJK>>>, Id32<PWFCKDZBCDU<MTKWVKXUIVO<GSPYYKIKJJK>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x2B0EED0", Offset = "0x2B0DCD0", VA = "0x182B0EED0")]
		public static (Id32<PWFCKDZBCDU<XVONRNCPECF>>, Id32<PWFCKDZBCDU<GSPYYKIKJJK>>, Id32<PWFCKDZBCDU<GSPYYKIKJJK>>, Id32<PWFCKDZBCDU<MTKWVKXUIVO<GSPYYKIKJJK>>>) RSATFQKIQBV(this UnsafeList<byte> a, int b, int c, [Optional] Id32<MTKWVKXUIVO<GSPYYKIKJJK>>? d)
		{
			return default((Id32<PWFCKDZBCDU<XVONRNCPECF>>, Id32<PWFCKDZBCDU<GSPYYKIKJJK>>, Id32<PWFCKDZBCDU<GSPYYKIKJJK>>, Id32<PWFCKDZBCDU<MTKWVKXUIVO<GSPYYKIKJJK>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x2B0F680", Offset = "0x2B0E480", VA = "0x182B0F680")]
		public static (Id32<PWFCKDZBCDU<XVONRNCPECF>>, Id32<PWFCKDZBCDU<GSPYYKIKJJK>>, Id32<PWFCKDZBCDU<MTKWVKXUIVO<GSPYYKIKJJK>>>, Id32<PWFCKDZBCDU<MTKWVKXUIVO<GSPYYKIKJJK>>>) SZOHDRQZMPC(this UnsafeList<byte> a, int b, [Optional] Id32<MTKWVKXUIVO<GSPYYKIKJJK>>? c, [Optional] Id32<MTKWVKXUIVO<GSPYYKIKJJK>>? d)
		{
			return default((Id32<PWFCKDZBCDU<XVONRNCPECF>>, Id32<PWFCKDZBCDU<GSPYYKIKJJK>>, Id32<PWFCKDZBCDU<MTKWVKXUIVO<GSPYYKIKJJK>>>, Id32<PWFCKDZBCDU<MTKWVKXUIVO<GSPYYKIKJJK>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x2B0F7D0", Offset = "0x2B0E5D0", VA = "0x182B0F7D0")]
		public static (Id32<PWFCKDZBCDU<XVONRNCPECF>>, Id32<PWFCKDZBCDU<MTKWVKXUIVO<GSPYYKIKJJK>>>, Id32<PWFCKDZBCDU<MTKWVKXUIVO<GSPYYKIKJJK>>>, Id32<PWFCKDZBCDU<MTKWVKXUIVO<GSPYYKIKJJK>>>) TFGQQDTFTCR(this UnsafeList<byte> a, [Optional] Id32<MTKWVKXUIVO<GSPYYKIKJJK>>? b, [Optional] Id32<MTKWVKXUIVO<GSPYYKIKJJK>>? c, [Optional] Id32<MTKWVKXUIVO<GSPYYKIKJJK>>? d)
		{
			return default((Id32<PWFCKDZBCDU<XVONRNCPECF>>, Id32<PWFCKDZBCDU<MTKWVKXUIVO<GSPYYKIKJJK>>>, Id32<PWFCKDZBCDU<MTKWVKXUIVO<GSPYYKIKJJK>>>, Id32<PWFCKDZBCDU<MTKWVKXUIVO<GSPYYKIKJJK>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x2B0CEB0", Offset = "0x2B0BCB0", VA = "0x182B0CEB0")]
		public static (Id32<PWFCKDZBCDU<XVONRNCPECF>>, Id32<PWFCKDZBCDU<GSPYYKIKJJK>>, Id32<PWFCKDZBCDU<PWFCKDZBCDU<XVONRNCPECF>>>) HVFVEFFYPTB(this UnsafeList<byte> a, [Optional] int? b, [Optional] Id32<PWFCKDZBCDU<XVONRNCPECF>>? c)
		{
			return default((Id32<PWFCKDZBCDU<XVONRNCPECF>>, Id32<PWFCKDZBCDU<GSPYYKIKJJK>>, Id32<PWFCKDZBCDU<PWFCKDZBCDU<XVONRNCPECF>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x2B10410", Offset = "0x2B0F210", VA = "0x182B10410")]
		public static (Id32<PWFCKDZBCDU<XVONRNCPECF>>, Id32<PWFCKDZBCDU<MTKWVKXUIVO<GSPYYKIKJJK>>>, Id32<PWFCKDZBCDU<PWFCKDZBCDU<XVONRNCPECF>>>) WSXNSAGEEWU(this UnsafeList<byte> a, [Optional] Id32<MTKWVKXUIVO<GSPYYKIKJJK>>? b, [Optional] Id32<PWFCKDZBCDU<XVONRNCPECF>>? c)
		{
			return default((Id32<PWFCKDZBCDU<XVONRNCPECF>>, Id32<PWFCKDZBCDU<MTKWVKXUIVO<GSPYYKIKJJK>>>, Id32<PWFCKDZBCDU<PWFCKDZBCDU<XVONRNCPECF>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x2B0F310", Offset = "0x2B0E110", VA = "0x182B0F310")]
		public static (Id32<PWFCKDZBCDU<XVONRNCPECF>>, Id32<PWFCKDZBCDU<GSPYYKIKJJK>>, Id32<PWFCKDZBCDU<PWFCKDZBCDU<XVONRNCPECF>>>) SAAKIXHPHMU(this UnsafeList<byte> a, [Optional] int? b, [Optional] Id32<PWFCKDZBCDU<XVONRNCPECF>>? c)
		{
			return default((Id32<PWFCKDZBCDU<XVONRNCPECF>>, Id32<PWFCKDZBCDU<GSPYYKIKJJK>>, Id32<PWFCKDZBCDU<PWFCKDZBCDU<XVONRNCPECF>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x2B0F8F0", Offset = "0x2B0E6F0", VA = "0x182B0F8F0")]
		public static (Id32<PWFCKDZBCDU<XVONRNCPECF>>, Id32<PWFCKDZBCDU<MTKWVKXUIVO<GSPYYKIKJJK>>>, Id32<PWFCKDZBCDU<PWFCKDZBCDU<XVONRNCPECF>>>) TYZSQIDTKZR(this UnsafeList<byte> a, [Optional] Id32<MTKWVKXUIVO<GSPYYKIKJJK>>? b, [Optional] Id32<PWFCKDZBCDU<XVONRNCPECF>>? c)
		{
			return default((Id32<PWFCKDZBCDU<XVONRNCPECF>>, Id32<PWFCKDZBCDU<MTKWVKXUIVO<GSPYYKIKJJK>>>, Id32<PWFCKDZBCDU<PWFCKDZBCDU<XVONRNCPECF>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x2B0B590", Offset = "0x2B0A390", VA = "0x182B0B590")]
		public static (Id32<PWFCKDZBCDU<XVONRNCPECF>>, Id32<PWFCKDZBCDU<GSPYYKIKJJK>>, Id32<PWFCKDZBCDU<HJVJIQEFSCR>>) BTKCRGFJNXC(this UnsafeList<byte> a, [Optional] int? b, [Optional] Id32<HJVJIQEFSCR>? c)
		{
			return default((Id32<PWFCKDZBCDU<XVONRNCPECF>>, Id32<PWFCKDZBCDU<GSPYYKIKJJK>>, Id32<PWFCKDZBCDU<HJVJIQEFSCR>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x2B0B740", Offset = "0x2B0A540", VA = "0x182B0B740")]
		public static (Id32<PWFCKDZBCDU<XVONRNCPECF>>, Id32<PWFCKDZBCDU<GSPYYKIKJJK>>, Id32<PWFCKDZBCDU<MTKWVKXUIVO<HJVJIQEFSCR>>>) BVQANCQGNRX(this UnsafeList<byte> a, [Optional] int? b, [Optional] Id32<MTKWVKXUIVO<HJVJIQEFSCR>>? c)
		{
			return default((Id32<PWFCKDZBCDU<XVONRNCPECF>>, Id32<PWFCKDZBCDU<GSPYYKIKJJK>>, Id32<PWFCKDZBCDU<MTKWVKXUIVO<HJVJIQEFSCR>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x2B0F160", Offset = "0x2B0DF60", VA = "0x182B0F160")]
		public static (Id32<PWFCKDZBCDU<XVONRNCPECF>>, Id32<PWFCKDZBCDU<GSPYYKIKJJK>>, Id32<PWFCKDZBCDU<HPBIAVPMDDB>>) RZSZDTCFSEO(this UnsafeList<byte> a, [Optional] int? b, [Optional] Id32<HPBIAVPMDDB>? c)
		{
			return default((Id32<PWFCKDZBCDU<XVONRNCPECF>>, Id32<PWFCKDZBCDU<GSPYYKIKJJK>>, Id32<PWFCKDZBCDU<HPBIAVPMDDB>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x2B0F420", Offset = "0x2B0E220", VA = "0x182B0F420")]
		public static (Id32<PWFCKDZBCDU<XVONRNCPECF>>, Id32<PWFCKDZBCDU<GSPYYKIKJJK>>, Id32<PWFCKDZBCDU<MTKWVKXUIVO<HPBIAVPMDDB>>>) SEKBSSRXBFN(this UnsafeList<byte> a, [Optional] int? b, [Optional] Id32<MTKWVKXUIVO<HPBIAVPMDDB>>? c)
		{
			return default((Id32<PWFCKDZBCDU<XVONRNCPECF>>, Id32<PWFCKDZBCDU<GSPYYKIKJJK>>, Id32<PWFCKDZBCDU<MTKWVKXUIVO<HPBIAVPMDDB>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x39EAAA0", Offset = "0x39E98A0", VA = "0x1839EAAA0")]
		public static (Id32<PWFCKDZBCDU<XVONRNCPECF>>, Id32<PWFCKDZBCDU<VHIMMWYWAFQ>>, Id32<PWFCKDZBCDU<GSPYYKIKJJK>>, Id32<PWFCKDZBCDU<a>>) ESMFVQUSZQN<a>(this UnsafeList<byte> a, [Optional] Id32<VHIMMWYWAFQ>? b, [Optional][In] ReadOnlySpan<byte> data)
		{
			return default((Id32<PWFCKDZBCDU<XVONRNCPECF>>, Id32<PWFCKDZBCDU<VHIMMWYWAFQ>>, Id32<PWFCKDZBCDU<GSPYYKIKJJK>>, Id32<PWFCKDZBCDU<a>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x2B0E420", Offset = "0x2B0D220", VA = "0x182B0E420")]
		public static (Id32<PWFCKDZBCDU<XVONRNCPECF>>, Id32<PWFCKDZBCDU<GSPYYKIKJJK>>, Id32<PWFCKDZBCDU<MTKWVKXUIVO<GSPYYKIKJJK>>>) PHCYYEVHHQN(this UnsafeList<byte> a, int b, [Optional] Id32<MTKWVKXUIVO<GSPYYKIKJJK>>? c)
		{
			return default((Id32<PWFCKDZBCDU<XVONRNCPECF>>, Id32<PWFCKDZBCDU<GSPYYKIKJJK>>, Id32<PWFCKDZBCDU<MTKWVKXUIVO<GSPYYKIKJJK>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x2B0CFC0", Offset = "0x2B0BDC0", VA = "0x182B0CFC0")]
		public static (Id32<PWFCKDZBCDU<XVONRNCPECF>>, Id32<PWFCKDZBCDU<MTKWVKXUIVO<GSPYYKIKJJK>>>, Id32<PWFCKDZBCDU<MTKWVKXUIVO<GSPYYKIKJJK>>>) INTACFZJOYW(this UnsafeList<byte> a, [Optional] Id32<MTKWVKXUIVO<GSPYYKIKJJK>>? b, [Optional] Id32<MTKWVKXUIVO<GSPYYKIKJJK>>? c)
		{
			return default((Id32<PWFCKDZBCDU<XVONRNCPECF>>, Id32<PWFCKDZBCDU<MTKWVKXUIVO<GSPYYKIKJJK>>>, Id32<PWFCKDZBCDU<MTKWVKXUIVO<GSPYYKIKJJK>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x39EAEA0", Offset = "0x39E9CA0", VA = "0x1839EAEA0")]
		public static (Id32<PWFCKDZBCDU<XVONRNCPECF>>, Id32<PWFCKDZBCDU<MTKWVKXUIVO<b>>>, Id32<PWFCKDZBCDU<GSPYYKIKJJK>>, Id32<PWFCKDZBCDU<b>>) XMLSIHCPHKX<b>(this UnsafeList<byte> a, [Optional] Id32<MTKWVKXUIVO<b>>? b, [Optional] int? c, [Optional][In] ReadOnlySpan<byte> from)
		{
			return default((Id32<PWFCKDZBCDU<XVONRNCPECF>>, Id32<PWFCKDZBCDU<MTKWVKXUIVO<b>>>, Id32<PWFCKDZBCDU<GSPYYKIKJJK>>, Id32<PWFCKDZBCDU<b>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x39EA750", Offset = "0x39E9550", VA = "0x1839EA750")]
		public static (Id32<PWFCKDZBCDU<XVONRNCPECF>>, Id32<PWFCKDZBCDU<MTKWVKXUIVO<c>>>, Id32<PWFCKDZBCDU<MTKWVKXUIVO<c>>>, Id32<PWFCKDZBCDU<GSPYYKIKJJK>>) AUTUYWJWZDK<c>(this UnsafeList<byte> a, [Optional] Id32<MTKWVKXUIVO<c>>? b, [Optional] Id32<MTKWVKXUIVO<c>>? c, [Optional] int? d)
		{
			return default((Id32<PWFCKDZBCDU<XVONRNCPECF>>, Id32<PWFCKDZBCDU<MTKWVKXUIVO<c>>>, Id32<PWFCKDZBCDU<MTKWVKXUIVO<c>>>, Id32<PWFCKDZBCDU<GSPYYKIKJJK>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x2B0C060", Offset = "0x2B0AE60", VA = "0x182B0C060")]
		public static (Id32<PWFCKDZBCDU<XVONRNCPECF>>, Id32<PWFCKDZBCDU<NCXCJLSDETL>>, Id32<PWFCKDZBCDU<NCXCJLSDETL>>, Id32<PWFCKDZBCDU<MTKWVKXUIVO<NCXCJLSDETL>>>) EYQGZBXTDNZ(this UnsafeList<byte> a, float b, float c, [Optional] Id32<MTKWVKXUIVO<NCXCJLSDETL>>? d)
		{
			return default((Id32<PWFCKDZBCDU<XVONRNCPECF>>, Id32<PWFCKDZBCDU<NCXCJLSDETL>>, Id32<PWFCKDZBCDU<NCXCJLSDETL>>, Id32<PWFCKDZBCDU<MTKWVKXUIVO<NCXCJLSDETL>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x2B0BDB0", Offset = "0x2B0ABB0", VA = "0x182B0BDB0")]
		public static (Id32<PWFCKDZBCDU<XVONRNCPECF>>, Id32<PWFCKDZBCDU<NCXCJLSDETL>>, Id32<PWFCKDZBCDU<MTKWVKXUIVO<NCXCJLSDETL>>>, Id32<PWFCKDZBCDU<MTKWVKXUIVO<NCXCJLSDETL>>>) ENBZTJNCUAQ(this UnsafeList<byte> a, float b, [Optional] Id32<MTKWVKXUIVO<NCXCJLSDETL>>? c, [Optional] Id32<MTKWVKXUIVO<NCXCJLSDETL>>? d)
		{
			return default((Id32<PWFCKDZBCDU<XVONRNCPECF>>, Id32<PWFCKDZBCDU<NCXCJLSDETL>>, Id32<PWFCKDZBCDU<MTKWVKXUIVO<NCXCJLSDETL>>>, Id32<PWFCKDZBCDU<MTKWVKXUIVO<NCXCJLSDETL>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x2B0DB40", Offset = "0x2B0C940", VA = "0x182B0DB40")]
		public static (Id32<PWFCKDZBCDU<XVONRNCPECF>>, Id32<PWFCKDZBCDU<MTKWVKXUIVO<NCXCJLSDETL>>>, Id32<PWFCKDZBCDU<MTKWVKXUIVO<NCXCJLSDETL>>>, Id32<PWFCKDZBCDU<MTKWVKXUIVO<NCXCJLSDETL>>>) MSWIOVHKIOB(this UnsafeList<byte> a, [Optional] Id32<MTKWVKXUIVO<NCXCJLSDETL>>? b, [Optional] Id32<MTKWVKXUIVO<NCXCJLSDETL>>? c, [Optional] Id32<MTKWVKXUIVO<NCXCJLSDETL>>? d)
		{
			return default((Id32<PWFCKDZBCDU<XVONRNCPECF>>, Id32<PWFCKDZBCDU<MTKWVKXUIVO<NCXCJLSDETL>>>, Id32<PWFCKDZBCDU<MTKWVKXUIVO<NCXCJLSDETL>>>, Id32<PWFCKDZBCDU<MTKWVKXUIVO<NCXCJLSDETL>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x2B0B9B0", Offset = "0x2B0A7B0", VA = "0x182B0B9B0")]
		public static (Id32<PWFCKDZBCDU<XVONRNCPECF>>, Id32<PWFCKDZBCDU<GSPYYKIKJJK>>, Id32<PWFCKDZBCDU<GSPYYKIKJJK>>, Id32<PWFCKDZBCDU<MTKWVKXUIVO<GSPYYKIKJJK>>>) DHTVRZWOBUJ(this UnsafeList<byte> a, int b, int c, [Optional] Id32<MTKWVKXUIVO<GSPYYKIKJJK>>? d)
		{
			return default((Id32<PWFCKDZBCDU<XVONRNCPECF>>, Id32<PWFCKDZBCDU<GSPYYKIKJJK>>, Id32<PWFCKDZBCDU<GSPYYKIKJJK>>, Id32<PWFCKDZBCDU<MTKWVKXUIVO<GSPYYKIKJJK>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x2B0DDE0", Offset = "0x2B0CBE0", VA = "0x182B0DDE0")]
		public static (Id32<PWFCKDZBCDU<XVONRNCPECF>>, Id32<PWFCKDZBCDU<GSPYYKIKJJK>>, Id32<PWFCKDZBCDU<MTKWVKXUIVO<GSPYYKIKJJK>>>, Id32<PWFCKDZBCDU<MTKWVKXUIVO<GSPYYKIKJJK>>>) MVKKVJOQUAK(this UnsafeList<byte> a, int b, [Optional] Id32<MTKWVKXUIVO<GSPYYKIKJJK>>? c, [Optional] Id32<MTKWVKXUIVO<GSPYYKIKJJK>>? d)
		{
			return default((Id32<PWFCKDZBCDU<XVONRNCPECF>>, Id32<PWFCKDZBCDU<GSPYYKIKJJK>>, Id32<PWFCKDZBCDU<MTKWVKXUIVO<GSPYYKIKJJK>>>, Id32<PWFCKDZBCDU<MTKWVKXUIVO<GSPYYKIKJJK>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x2B0E8F0", Offset = "0x2B0D6F0", VA = "0x182B0E8F0")]
		public static (Id32<PWFCKDZBCDU<XVONRNCPECF>>, Id32<PWFCKDZBCDU<MTKWVKXUIVO<GSPYYKIKJJK>>>, Id32<PWFCKDZBCDU<MTKWVKXUIVO<GSPYYKIKJJK>>>, Id32<PWFCKDZBCDU<MTKWVKXUIVO<GSPYYKIKJJK>>>) PPOQZFMRZLN(this UnsafeList<byte> a, [Optional] Id32<MTKWVKXUIVO<GSPYYKIKJJK>>? b, [Optional] Id32<MTKWVKXUIVO<GSPYYKIKJJK>>? c, [Optional] Id32<MTKWVKXUIVO<GSPYYKIKJJK>>? d)
		{
			return default((Id32<PWFCKDZBCDU<XVONRNCPECF>>, Id32<PWFCKDZBCDU<MTKWVKXUIVO<GSPYYKIKJJK>>>, Id32<PWFCKDZBCDU<MTKWVKXUIVO<GSPYYKIKJJK>>>, Id32<PWFCKDZBCDU<MTKWVKXUIVO<GSPYYKIKJJK>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x2B0D4A0", Offset = "0x2B0C2A0", VA = "0x182B0D4A0")]
		public static (Id32<PWFCKDZBCDU<XVONRNCPECF>>, Id32<PWFCKDZBCDU<GSPYYKIKJJK>>, Id32<PWFCKDZBCDU<GSPYYKIKJJK>>, Id32<PWFCKDZBCDU<MTKWVKXUIVO<GSPYYKIKJJK>>>) KQDIXPEFZPI(this UnsafeList<byte> a, int b, int c, [Optional] Id32<MTKWVKXUIVO<GSPYYKIKJJK>>? d)
		{
			return default((Id32<PWFCKDZBCDU<XVONRNCPECF>>, Id32<PWFCKDZBCDU<GSPYYKIKJJK>>, Id32<PWFCKDZBCDU<GSPYYKIKJJK>>, Id32<PWFCKDZBCDU<MTKWVKXUIVO<GSPYYKIKJJK>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x2B0D1F0", Offset = "0x2B0BFF0", VA = "0x182B0D1F0")]
		public static (Id32<PWFCKDZBCDU<XVONRNCPECF>>, Id32<PWFCKDZBCDU<GSPYYKIKJJK>>, Id32<PWFCKDZBCDU<MTKWVKXUIVO<GSPYYKIKJJK>>>, Id32<PWFCKDZBCDU<MTKWVKXUIVO<GSPYYKIKJJK>>>) JYCPCTHAVJX(this UnsafeList<byte> a, int b, [Optional] Id32<MTKWVKXUIVO<GSPYYKIKJJK>>? c, [Optional] Id32<MTKWVKXUIVO<GSPYYKIKJJK>>? d)
		{
			return default((Id32<PWFCKDZBCDU<XVONRNCPECF>>, Id32<PWFCKDZBCDU<GSPYYKIKJJK>>, Id32<PWFCKDZBCDU<MTKWVKXUIVO<GSPYYKIKJJK>>>, Id32<PWFCKDZBCDU<MTKWVKXUIVO<GSPYYKIKJJK>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x2B0E6B0", Offset = "0x2B0D4B0", VA = "0x182B0E6B0")]
		public static (Id32<PWFCKDZBCDU<XVONRNCPECF>>, Id32<PWFCKDZBCDU<MTKWVKXUIVO<GSPYYKIKJJK>>>, Id32<PWFCKDZBCDU<MTKWVKXUIVO<GSPYYKIKJJK>>>, Id32<PWFCKDZBCDU<MTKWVKXUIVO<GSPYYKIKJJK>>>) PIDRSRYIAWQ(this UnsafeList<byte> a, [Optional] Id32<MTKWVKXUIVO<GSPYYKIKJJK>>? b, [Optional] Id32<MTKWVKXUIVO<GSPYYKIKJJK>>? c, [Optional] Id32<MTKWVKXUIVO<GSPYYKIKJJK>>? d)
		{
			return default((Id32<PWFCKDZBCDU<XVONRNCPECF>>, Id32<PWFCKDZBCDU<MTKWVKXUIVO<GSPYYKIKJJK>>>, Id32<PWFCKDZBCDU<MTKWVKXUIVO<GSPYYKIKJJK>>>, Id32<PWFCKDZBCDU<MTKWVKXUIVO<GSPYYKIKJJK>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x2B0DF30", Offset = "0x2B0CD30", VA = "0x182B0DF30")]
		public static (Id32<PWFCKDZBCDU<XVONRNCPECF>>, Id32<PWFCKDZBCDU<PWFCKDZBCDU<XVONRNCPECF>>>) MZGAADVUJIF(this UnsafeList<byte> a, [Optional] Id32<PWFCKDZBCDU<XVONRNCPECF>>? b)
		{
			return default((Id32<PWFCKDZBCDU<XVONRNCPECF>>, Id32<PWFCKDZBCDU<PWFCKDZBCDU<XVONRNCPECF>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x2B0B190", Offset = "0x2B09F90", VA = "0x182B0B190")]
		public static (Id32<PWFCKDZBCDU<XVONRNCPECF>>, Id32<PWFCKDZBCDU<NCXCJLSDETL>>, Id32<PWFCKDZBCDU<NCXCJLSDETL>>, Id32<PWFCKDZBCDU<MTKWVKXUIVO<GSPYYKIKJJK>>>) AJUBPEGTTOF(this UnsafeList<byte> a, float b, float c, [Optional] Id32<MTKWVKXUIVO<GSPYYKIKJJK>>? d)
		{
			return default((Id32<PWFCKDZBCDU<XVONRNCPECF>>, Id32<PWFCKDZBCDU<NCXCJLSDETL>>, Id32<PWFCKDZBCDU<NCXCJLSDETL>>, Id32<PWFCKDZBCDU<MTKWVKXUIVO<GSPYYKIKJJK>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x2B0C1E0", Offset = "0x2B0AFE0", VA = "0x182B0C1E0")]
		public static (Id32<PWFCKDZBCDU<XVONRNCPECF>>, Id32<PWFCKDZBCDU<NCXCJLSDETL>>, Id32<PWFCKDZBCDU<MTKWVKXUIVO<NCXCJLSDETL>>>, Id32<PWFCKDZBCDU<MTKWVKXUIVO<GSPYYKIKJJK>>>) EZLXGJSUMHE(this UnsafeList<byte> a, float b, [Optional] Id32<MTKWVKXUIVO<NCXCJLSDETL>>? c, [Optional] Id32<MTKWVKXUIVO<GSPYYKIKJJK>>? d)
		{
			return default((Id32<PWFCKDZBCDU<XVONRNCPECF>>, Id32<PWFCKDZBCDU<NCXCJLSDETL>>, Id32<PWFCKDZBCDU<MTKWVKXUIVO<NCXCJLSDETL>>>, Id32<PWFCKDZBCDU<MTKWVKXUIVO<GSPYYKIKJJK>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x2B0F030", Offset = "0x2B0DE30", VA = "0x182B0F030")]
		public static (Id32<PWFCKDZBCDU<XVONRNCPECF>>, Id32<PWFCKDZBCDU<MTKWVKXUIVO<NCXCJLSDETL>>>, Id32<PWFCKDZBCDU<MTKWVKXUIVO<NCXCJLSDETL>>>, Id32<PWFCKDZBCDU<MTKWVKXUIVO<GSPYYKIKJJK>>>) RXDYLOVDHHN(this UnsafeList<byte> a, [Optional] Id32<MTKWVKXUIVO<NCXCJLSDETL>>? b, [Optional] Id32<MTKWVKXUIVO<NCXCJLSDETL>>? c, [Optional] Id32<MTKWVKXUIVO<GSPYYKIKJJK>>? d)
		{
			return default((Id32<PWFCKDZBCDU<XVONRNCPECF>>, Id32<PWFCKDZBCDU<MTKWVKXUIVO<NCXCJLSDETL>>>, Id32<PWFCKDZBCDU<MTKWVKXUIVO<NCXCJLSDETL>>>, Id32<PWFCKDZBCDU<MTKWVKXUIVO<GSPYYKIKJJK>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x2B10530", Offset = "0x2B0F330", VA = "0x182B10530")]
		public static (Id32<PWFCKDZBCDU<XVONRNCPECF>>, Id32<PWFCKDZBCDU<GSPYYKIKJJK>>, Id32<PWFCKDZBCDU<GSPYYKIKJJK>>, Id32<PWFCKDZBCDU<MTKWVKXUIVO<GSPYYKIKJJK>>>) XRJNUVUWNIM(this UnsafeList<byte> a, int b, int c, [Optional] Id32<MTKWVKXUIVO<GSPYYKIKJJK>>? d)
		{
			return default((Id32<PWFCKDZBCDU<XVONRNCPECF>>, Id32<PWFCKDZBCDU<GSPYYKIKJJK>>, Id32<PWFCKDZBCDU<GSPYYKIKJJK>>, Id32<PWFCKDZBCDU<MTKWVKXUIVO<GSPYYKIKJJK>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x2B107B0", Offset = "0x2B0F5B0", VA = "0x182B107B0")]
		public static (Id32<PWFCKDZBCDU<XVONRNCPECF>>, Id32<PWFCKDZBCDU<GSPYYKIKJJK>>, Id32<PWFCKDZBCDU<MTKWVKXUIVO<GSPYYKIKJJK>>>, Id32<PWFCKDZBCDU<MTKWVKXUIVO<GSPYYKIKJJK>>>) ZGWMZBPLEEP(this UnsafeList<byte> a, int b, [Optional] Id32<MTKWVKXUIVO<GSPYYKIKJJK>>? c, [Optional] Id32<MTKWVKXUIVO<GSPYYKIKJJK>>? d)
		{
			return default((Id32<PWFCKDZBCDU<XVONRNCPECF>>, Id32<PWFCKDZBCDU<GSPYYKIKJJK>>, Id32<PWFCKDZBCDU<MTKWVKXUIVO<GSPYYKIKJJK>>>, Id32<PWFCKDZBCDU<MTKWVKXUIVO<GSPYYKIKJJK>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x2B0C890", Offset = "0x2B0B690", VA = "0x182B0C890")]
		public static (Id32<PWFCKDZBCDU<XVONRNCPECF>>, Id32<PWFCKDZBCDU<MTKWVKXUIVO<GSPYYKIKJJK>>>, Id32<PWFCKDZBCDU<MTKWVKXUIVO<GSPYYKIKJJK>>>, Id32<PWFCKDZBCDU<MTKWVKXUIVO<GSPYYKIKJJK>>>) HNXQQTCIYLE(this UnsafeList<byte> a, [Optional] Id32<MTKWVKXUIVO<GSPYYKIKJJK>>? b, [Optional] Id32<MTKWVKXUIVO<GSPYYKIKJJK>>? c, [Optional] Id32<MTKWVKXUIVO<GSPYYKIKJJK>>? d)
		{
			return default((Id32<PWFCKDZBCDU<XVONRNCPECF>>, Id32<PWFCKDZBCDU<MTKWVKXUIVO<GSPYYKIKJJK>>>, Id32<PWFCKDZBCDU<MTKWVKXUIVO<GSPYYKIKJJK>>>, Id32<PWFCKDZBCDU<MTKWVKXUIVO<GSPYYKIKJJK>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x2B0E2A0", Offset = "0x2B0D0A0", VA = "0x182B0E2A0")]
		public static (Id32<PWFCKDZBCDU<XVONRNCPECF>>, Id32<PWFCKDZBCDU<NCXCJLSDETL>>, Id32<PWFCKDZBCDU<NCXCJLSDETL>>, Id32<PWFCKDZBCDU<MTKWVKXUIVO<GSPYYKIKJJK>>>) PEGVNVUBDVK(this UnsafeList<byte> a, float b, float c, [Optional] Id32<MTKWVKXUIVO<GSPYYKIKJJK>>? d)
		{
			return default((Id32<PWFCKDZBCDU<XVONRNCPECF>>, Id32<PWFCKDZBCDU<NCXCJLSDETL>>, Id32<PWFCKDZBCDU<NCXCJLSDETL>>, Id32<PWFCKDZBCDU<MTKWVKXUIVO<GSPYYKIKJJK>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x2B0B310", Offset = "0x2B0A110", VA = "0x182B0B310")]
		public static (Id32<PWFCKDZBCDU<XVONRNCPECF>>, Id32<PWFCKDZBCDU<NCXCJLSDETL>>, Id32<PWFCKDZBCDU<MTKWVKXUIVO<NCXCJLSDETL>>>, Id32<PWFCKDZBCDU<MTKWVKXUIVO<GSPYYKIKJJK>>>) AVJMYSOCNQL(this UnsafeList<byte> a, float b, [Optional] Id32<MTKWVKXUIVO<NCXCJLSDETL>>? c, [Optional] Id32<MTKWVKXUIVO<GSPYYKIKJJK>>? d)
		{
			return default((Id32<PWFCKDZBCDU<XVONRNCPECF>>, Id32<PWFCKDZBCDU<NCXCJLSDETL>>, Id32<PWFCKDZBCDU<MTKWVKXUIVO<NCXCJLSDETL>>>, Id32<PWFCKDZBCDU<MTKWVKXUIVO<GSPYYKIKJJK>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x2B0EA10", Offset = "0x2B0D810", VA = "0x182B0EA10")]
		public static (Id32<PWFCKDZBCDU<XVONRNCPECF>>, Id32<PWFCKDZBCDU<MTKWVKXUIVO<NCXCJLSDETL>>>, Id32<PWFCKDZBCDU<MTKWVKXUIVO<NCXCJLSDETL>>>, Id32<PWFCKDZBCDU<MTKWVKXUIVO<GSPYYKIKJJK>>>) PRCLSHGYPYW(this UnsafeList<byte> a, [Optional] Id32<MTKWVKXUIVO<NCXCJLSDETL>>? b, [Optional] Id32<MTKWVKXUIVO<NCXCJLSDETL>>? c, [Optional] Id32<MTKWVKXUIVO<GSPYYKIKJJK>>? d)
		{
			return default((Id32<PWFCKDZBCDU<XVONRNCPECF>>, Id32<PWFCKDZBCDU<MTKWVKXUIVO<NCXCJLSDETL>>>, Id32<PWFCKDZBCDU<MTKWVKXUIVO<NCXCJLSDETL>>>, Id32<PWFCKDZBCDU<MTKWVKXUIVO<GSPYYKIKJJK>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x2B0E550", Offset = "0x2B0D350", VA = "0x182B0E550")]
		public static (Id32<PWFCKDZBCDU<XVONRNCPECF>>, Id32<PWFCKDZBCDU<GSPYYKIKJJK>>, Id32<PWFCKDZBCDU<GSPYYKIKJJK>>, Id32<PWFCKDZBCDU<MTKWVKXUIVO<GSPYYKIKJJK>>>) PHHAMDQLIYF(this UnsafeList<byte> a, int b, int c, [Optional] Id32<MTKWVKXUIVO<GSPYYKIKJJK>>? d)
		{
			return default((Id32<PWFCKDZBCDU<XVONRNCPECF>>, Id32<PWFCKDZBCDU<GSPYYKIKJJK>>, Id32<PWFCKDZBCDU<GSPYYKIKJJK>>, Id32<PWFCKDZBCDU<MTKWVKXUIVO<GSPYYKIKJJK>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x2B0F530", Offset = "0x2B0E330", VA = "0x182B0F530")]
		public static (Id32<PWFCKDZBCDU<XVONRNCPECF>>, Id32<PWFCKDZBCDU<GSPYYKIKJJK>>, Id32<PWFCKDZBCDU<MTKWVKXUIVO<GSPYYKIKJJK>>>, Id32<PWFCKDZBCDU<MTKWVKXUIVO<GSPYYKIKJJK>>>) SJJFPGRHIXU(this UnsafeList<byte> a, int b, [Optional] Id32<MTKWVKXUIVO<GSPYYKIKJJK>>? c, [Optional] Id32<MTKWVKXUIVO<GSPYYKIKJJK>>? d)
		{
			return default((Id32<PWFCKDZBCDU<XVONRNCPECF>>, Id32<PWFCKDZBCDU<GSPYYKIKJJK>>, Id32<PWFCKDZBCDU<MTKWVKXUIVO<GSPYYKIKJJK>>>, Id32<PWFCKDZBCDU<MTKWVKXUIVO<GSPYYKIKJJK>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x2B0D0D0", Offset = "0x2B0BED0", VA = "0x182B0D0D0")]
		public static (Id32<PWFCKDZBCDU<XVONRNCPECF>>, Id32<PWFCKDZBCDU<MTKWVKXUIVO<GSPYYKIKJJK>>>, Id32<PWFCKDZBCDU<MTKWVKXUIVO<GSPYYKIKJJK>>>, Id32<PWFCKDZBCDU<MTKWVKXUIVO<GSPYYKIKJJK>>>) JOIZFWUKVFZ(this UnsafeList<byte> a, [Optional] Id32<MTKWVKXUIVO<GSPYYKIKJJK>>? b, [Optional] Id32<MTKWVKXUIVO<GSPYYKIKJJK>>? c, [Optional] Id32<MTKWVKXUIVO<GSPYYKIKJJK>>? d)
		{
			return default((Id32<PWFCKDZBCDU<XVONRNCPECF>>, Id32<PWFCKDZBCDU<MTKWVKXUIVO<GSPYYKIKJJK>>>, Id32<PWFCKDZBCDU<MTKWVKXUIVO<GSPYYKIKJJK>>>, Id32<PWFCKDZBCDU<MTKWVKXUIVO<GSPYYKIKJJK>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x2B0FB90", Offset = "0x2B0E990", VA = "0x182B0FB90")]
		public static (Id32<PWFCKDZBCDU<XVONRNCPECF>>, Id32<PWFCKDZBCDU<NCXCJLSDETL>>, Id32<PWFCKDZBCDU<NCXCJLSDETL>>, Id32<PWFCKDZBCDU<MTKWVKXUIVO<GSPYYKIKJJK>>>) UDAGNEXJHHK(this UnsafeList<byte> a, float b, float c, [Optional] Id32<MTKWVKXUIVO<GSPYYKIKJJK>>? d)
		{
			return default((Id32<PWFCKDZBCDU<XVONRNCPECF>>, Id32<PWFCKDZBCDU<NCXCJLSDETL>>, Id32<PWFCKDZBCDU<NCXCJLSDETL>>, Id32<PWFCKDZBCDU<MTKWVKXUIVO<GSPYYKIKJJK>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x2B0E140", Offset = "0x2B0CF40", VA = "0x182B0E140")]
		public static (Id32<PWFCKDZBCDU<XVONRNCPECF>>, Id32<PWFCKDZBCDU<NCXCJLSDETL>>, Id32<PWFCKDZBCDU<MTKWVKXUIVO<NCXCJLSDETL>>>, Id32<PWFCKDZBCDU<MTKWVKXUIVO<GSPYYKIKJJK>>>) OJNJRFUXOUL(this UnsafeList<byte> a, float b, [Optional] Id32<MTKWVKXUIVO<NCXCJLSDETL>>? c, [Optional] Id32<MTKWVKXUIVO<GSPYYKIKJJK>>? d)
		{
			return default((Id32<PWFCKDZBCDU<XVONRNCPECF>>, Id32<PWFCKDZBCDU<NCXCJLSDETL>>, Id32<PWFCKDZBCDU<MTKWVKXUIVO<NCXCJLSDETL>>>, Id32<PWFCKDZBCDU<MTKWVKXUIVO<GSPYYKIKJJK>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x2B0FE60", Offset = "0x2B0EC60", VA = "0x182B0FE60")]
		public static (Id32<PWFCKDZBCDU<XVONRNCPECF>>, Id32<PWFCKDZBCDU<MTKWVKXUIVO<NCXCJLSDETL>>>, Id32<PWFCKDZBCDU<MTKWVKXUIVO<NCXCJLSDETL>>>, Id32<PWFCKDZBCDU<MTKWVKXUIVO<GSPYYKIKJJK>>>) VAZYAUKCJQC(this UnsafeList<byte> a, [Optional] Id32<MTKWVKXUIVO<NCXCJLSDETL>>? b, [Optional] Id32<MTKWVKXUIVO<NCXCJLSDETL>>? c, [Optional] Id32<MTKWVKXUIVO<GSPYYKIKJJK>>? d)
		{
			return default((Id32<PWFCKDZBCDU<XVONRNCPECF>>, Id32<PWFCKDZBCDU<MTKWVKXUIVO<NCXCJLSDETL>>>, Id32<PWFCKDZBCDU<MTKWVKXUIVO<NCXCJLSDETL>>>, Id32<PWFCKDZBCDU<MTKWVKXUIVO<GSPYYKIKJJK>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x2B10190", Offset = "0x2B0EF90", VA = "0x182B10190")]
		public static (Id32<PWFCKDZBCDU<XVONRNCPECF>>, Id32<PWFCKDZBCDU<GSPYYKIKJJK>>, Id32<PWFCKDZBCDU<GSPYYKIKJJK>>, Id32<PWFCKDZBCDU<MTKWVKXUIVO<GSPYYKIKJJK>>>) VRZWXFOMION(this UnsafeList<byte> a, int b, int c, [Optional] Id32<MTKWVKXUIVO<GSPYYKIKJJK>>? d)
		{
			return default((Id32<PWFCKDZBCDU<XVONRNCPECF>>, Id32<PWFCKDZBCDU<GSPYYKIKJJK>>, Id32<PWFCKDZBCDU<GSPYYKIKJJK>>, Id32<PWFCKDZBCDU<MTKWVKXUIVO<GSPYYKIKJJK>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x2B0C5F0", Offset = "0x2B0B3F0", VA = "0x182B0C5F0")]
		public static (Id32<PWFCKDZBCDU<XVONRNCPECF>>, Id32<PWFCKDZBCDU<GSPYYKIKJJK>>, Id32<PWFCKDZBCDU<MTKWVKXUIVO<GSPYYKIKJJK>>>, Id32<PWFCKDZBCDU<MTKWVKXUIVO<GSPYYKIKJJK>>>) FWBYVEHBMTY(this UnsafeList<byte> a, int b, [Optional] Id32<MTKWVKXUIVO<GSPYYKIKJJK>>? c, [Optional] Id32<MTKWVKXUIVO<GSPYYKIKJJK>>? d)
		{
			return default((Id32<PWFCKDZBCDU<XVONRNCPECF>>, Id32<PWFCKDZBCDU<GSPYYKIKJJK>>, Id32<PWFCKDZBCDU<MTKWVKXUIVO<GSPYYKIKJJK>>>, Id32<PWFCKDZBCDU<MTKWVKXUIVO<GSPYYKIKJJK>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x2B0EC60", Offset = "0x2B0DA60", VA = "0x182B0EC60")]
		public static (Id32<PWFCKDZBCDU<XVONRNCPECF>>, Id32<PWFCKDZBCDU<MTKWVKXUIVO<GSPYYKIKJJK>>>, Id32<PWFCKDZBCDU<MTKWVKXUIVO<GSPYYKIKJJK>>>, Id32<PWFCKDZBCDU<MTKWVKXUIVO<GSPYYKIKJJK>>>) QHZOQIAJGJR(this UnsafeList<byte> a, [Optional] Id32<MTKWVKXUIVO<GSPYYKIKJJK>>? b, [Optional] Id32<MTKWVKXUIVO<GSPYYKIKJJK>>? c, [Optional] Id32<MTKWVKXUIVO<GSPYYKIKJJK>>? d)
		{
			return default((Id32<PWFCKDZBCDU<XVONRNCPECF>>, Id32<PWFCKDZBCDU<MTKWVKXUIVO<GSPYYKIKJJK>>>, Id32<PWFCKDZBCDU<MTKWVKXUIVO<GSPYYKIKJJK>>>, Id32<PWFCKDZBCDU<MTKWVKXUIVO<GSPYYKIKJJK>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x2B0FA10", Offset = "0x2B0E810", VA = "0x182B0FA10")]
		public static (Id32<PWFCKDZBCDU<XVONRNCPECF>>, Id32<PWFCKDZBCDU<NCXCJLSDETL>>, Id32<PWFCKDZBCDU<NCXCJLSDETL>>, Id32<PWFCKDZBCDU<MTKWVKXUIVO<GSPYYKIKJJK>>>) UBZPGUPCLPB(this UnsafeList<byte> a, float b, float c, [Optional] Id32<MTKWVKXUIVO<GSPYYKIKJJK>>? d)
		{
			return default((Id32<PWFCKDZBCDU<XVONRNCPECF>>, Id32<PWFCKDZBCDU<NCXCJLSDETL>>, Id32<PWFCKDZBCDU<NCXCJLSDETL>>, Id32<PWFCKDZBCDU<MTKWVKXUIVO<GSPYYKIKJJK>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x2B0B850", Offset = "0x2B0A650", VA = "0x182B0B850")]
		public static (Id32<PWFCKDZBCDU<XVONRNCPECF>>, Id32<PWFCKDZBCDU<NCXCJLSDETL>>, Id32<PWFCKDZBCDU<MTKWVKXUIVO<NCXCJLSDETL>>>, Id32<PWFCKDZBCDU<MTKWVKXUIVO<GSPYYKIKJJK>>>) BYBNDJYMQRK(this UnsafeList<byte> a, float b, [Optional] Id32<MTKWVKXUIVO<NCXCJLSDETL>>? c, [Optional] Id32<MTKWVKXUIVO<GSPYYKIKJJK>>? d)
		{
			return default((Id32<PWFCKDZBCDU<XVONRNCPECF>>, Id32<PWFCKDZBCDU<NCXCJLSDETL>>, Id32<PWFCKDZBCDU<MTKWVKXUIVO<NCXCJLSDETL>>>, Id32<PWFCKDZBCDU<MTKWVKXUIVO<GSPYYKIKJJK>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x2B0C9B0", Offset = "0x2B0B7B0", VA = "0x182B0C9B0")]
		public static (Id32<PWFCKDZBCDU<XVONRNCPECF>>, Id32<PWFCKDZBCDU<MTKWVKXUIVO<NCXCJLSDETL>>>, Id32<PWFCKDZBCDU<MTKWVKXUIVO<NCXCJLSDETL>>>, Id32<PWFCKDZBCDU<MTKWVKXUIVO<GSPYYKIKJJK>>>) HODDKLIVVMJ(this UnsafeList<byte> a, [Optional] Id32<MTKWVKXUIVO<NCXCJLSDETL>>? b, [Optional] Id32<MTKWVKXUIVO<NCXCJLSDETL>>? c, [Optional] Id32<MTKWVKXUIVO<GSPYYKIKJJK>>? d)
		{
			return default((Id32<PWFCKDZBCDU<XVONRNCPECF>>, Id32<PWFCKDZBCDU<MTKWVKXUIVO<NCXCJLSDETL>>>, Id32<PWFCKDZBCDU<MTKWVKXUIVO<NCXCJLSDETL>>>, Id32<PWFCKDZBCDU<MTKWVKXUIVO<GSPYYKIKJJK>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x2B0D600", Offset = "0x2B0C400", VA = "0x182B0D600")]
		public static (Id32<PWFCKDZBCDU<XVONRNCPECF>>, Id32<PWFCKDZBCDU<GSPYYKIKJJK>>, Id32<PWFCKDZBCDU<GSPYYKIKJJK>>, Id32<PWFCKDZBCDU<MTKWVKXUIVO<GSPYYKIKJJK>>>) LPVHGRDLASO(this UnsafeList<byte> a, int b, int c, [Optional] Id32<MTKWVKXUIVO<GSPYYKIKJJK>>? d)
		{
			return default((Id32<PWFCKDZBCDU<XVONRNCPECF>>, Id32<PWFCKDZBCDU<GSPYYKIKJJK>>, Id32<PWFCKDZBCDU<GSPYYKIKJJK>>, Id32<PWFCKDZBCDU<MTKWVKXUIVO<GSPYYKIKJJK>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x2B0FD10", Offset = "0x2B0EB10", VA = "0x182B0FD10")]
		public static (Id32<PWFCKDZBCDU<XVONRNCPECF>>, Id32<PWFCKDZBCDU<GSPYYKIKJJK>>, Id32<PWFCKDZBCDU<MTKWVKXUIVO<GSPYYKIKJJK>>>, Id32<PWFCKDZBCDU<MTKWVKXUIVO<GSPYYKIKJJK>>>) UTIHEUOKKOR(this UnsafeList<byte> a, int b, [Optional] Id32<MTKWVKXUIVO<GSPYYKIKJJK>>? c, [Optional] Id32<MTKWVKXUIVO<GSPYYKIKJJK>>? d)
		{
			return default((Id32<PWFCKDZBCDU<XVONRNCPECF>>, Id32<PWFCKDZBCDU<GSPYYKIKJJK>>, Id32<PWFCKDZBCDU<MTKWVKXUIVO<GSPYYKIKJJK>>>, Id32<PWFCKDZBCDU<MTKWVKXUIVO<GSPYYKIKJJK>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x2B10A10", Offset = "0x2B0F810", VA = "0x182B10A10")]
		public static (Id32<PWFCKDZBCDU<XVONRNCPECF>>, Id32<PWFCKDZBCDU<MTKWVKXUIVO<GSPYYKIKJJK>>>, Id32<PWFCKDZBCDU<MTKWVKXUIVO<GSPYYKIKJJK>>>, Id32<PWFCKDZBCDU<MTKWVKXUIVO<GSPYYKIKJJK>>>) ZXLUXBYRCUE(this UnsafeList<byte> a, [Optional] Id32<MTKWVKXUIVO<GSPYYKIKJJK>>? b, [Optional] Id32<MTKWVKXUIVO<GSPYYKIKJJK>>? c, [Optional] Id32<MTKWVKXUIVO<GSPYYKIKJJK>>? d)
		{
			return default((Id32<PWFCKDZBCDU<XVONRNCPECF>>, Id32<PWFCKDZBCDU<MTKWVKXUIVO<GSPYYKIKJJK>>>, Id32<PWFCKDZBCDU<MTKWVKXUIVO<GSPYYKIKJJK>>>, Id32<PWFCKDZBCDU<MTKWVKXUIVO<GSPYYKIKJJK>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x2B0D9C0", Offset = "0x2B0C7C0", VA = "0x182B0D9C0")]
		public static (Id32<PWFCKDZBCDU<XVONRNCPECF>>, Id32<PWFCKDZBCDU<NCXCJLSDETL>>, Id32<PWFCKDZBCDU<NCXCJLSDETL>>, Id32<PWFCKDZBCDU<MTKWVKXUIVO<NCXCJLSDETL>>>) MMKTNRTBBTU(this UnsafeList<byte> a, float b, float c, [Optional] Id32<MTKWVKXUIVO<NCXCJLSDETL>>? d)
		{
			return default((Id32<PWFCKDZBCDU<XVONRNCPECF>>, Id32<PWFCKDZBCDU<NCXCJLSDETL>>, Id32<PWFCKDZBCDU<NCXCJLSDETL>>, Id32<PWFCKDZBCDU<MTKWVKXUIVO<NCXCJLSDETL>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x2B0ED80", Offset = "0x2B0DB80", VA = "0x182B0ED80")]
		public static (Id32<PWFCKDZBCDU<XVONRNCPECF>>, Id32<PWFCKDZBCDU<NCXCJLSDETL>>, Id32<PWFCKDZBCDU<MTKWVKXUIVO<NCXCJLSDETL>>>, Id32<PWFCKDZBCDU<MTKWVKXUIVO<NCXCJLSDETL>>>) QLJIOKBWUSF(this UnsafeList<byte> a, float b, [Optional] Id32<MTKWVKXUIVO<NCXCJLSDETL>>? c, [Optional] Id32<MTKWVKXUIVO<NCXCJLSDETL>>? d)
		{
			return default((Id32<PWFCKDZBCDU<XVONRNCPECF>>, Id32<PWFCKDZBCDU<NCXCJLSDETL>>, Id32<PWFCKDZBCDU<MTKWVKXUIVO<NCXCJLSDETL>>>, Id32<PWFCKDZBCDU<MTKWVKXUIVO<NCXCJLSDETL>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x2B0CAE0", Offset = "0x2B0B8E0", VA = "0x182B0CAE0")]
		public static (Id32<PWFCKDZBCDU<XVONRNCPECF>>, Id32<PWFCKDZBCDU<MTKWVKXUIVO<NCXCJLSDETL>>>, Id32<PWFCKDZBCDU<MTKWVKXUIVO<NCXCJLSDETL>>>, Id32<PWFCKDZBCDU<MTKWVKXUIVO<NCXCJLSDETL>>>) HONLHAYBDHS(this UnsafeList<byte> a, [Optional] Id32<MTKWVKXUIVO<NCXCJLSDETL>>? b, [Optional] Id32<MTKWVKXUIVO<NCXCJLSDETL>>? c, [Optional] Id32<MTKWVKXUIVO<NCXCJLSDETL>>? d)
		{
			return default((Id32<PWFCKDZBCDU<XVONRNCPECF>>, Id32<PWFCKDZBCDU<MTKWVKXUIVO<NCXCJLSDETL>>>, Id32<PWFCKDZBCDU<MTKWVKXUIVO<NCXCJLSDETL>>>, Id32<PWFCKDZBCDU<MTKWVKXUIVO<NCXCJLSDETL>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x2B0CC00", Offset = "0x2B0BA00", VA = "0x182B0CC00")]
		public static (Id32<PWFCKDZBCDU<XVONRNCPECF>>, Id32<PWFCKDZBCDU<GSPYYKIKJJK>>, Id32<PWFCKDZBCDU<GSPYYKIKJJK>>, Id32<PWFCKDZBCDU<MTKWVKXUIVO<GSPYYKIKJJK>>>) HQGOGLCCEZS(this UnsafeList<byte> a, int b, int c, [Optional] Id32<MTKWVKXUIVO<GSPYYKIKJJK>>? d)
		{
			return default((Id32<PWFCKDZBCDU<XVONRNCPECF>>, Id32<PWFCKDZBCDU<GSPYYKIKJJK>>, Id32<PWFCKDZBCDU<GSPYYKIKJJK>>, Id32<PWFCKDZBCDU<MTKWVKXUIVO<GSPYYKIKJJK>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x2B0CD60", Offset = "0x2B0BB60", VA = "0x182B0CD60")]
		public static (Id32<PWFCKDZBCDU<XVONRNCPECF>>, Id32<PWFCKDZBCDU<GSPYYKIKJJK>>, Id32<PWFCKDZBCDU<MTKWVKXUIVO<GSPYYKIKJJK>>>, Id32<PWFCKDZBCDU<MTKWVKXUIVO<GSPYYKIKJJK>>>) HSWUCGKRHFV(this UnsafeList<byte> a, int b, [Optional] Id32<MTKWVKXUIVO<GSPYYKIKJJK>>? c, [Optional] Id32<MTKWVKXUIVO<GSPYYKIKJJK>>? d)
		{
			return default((Id32<PWFCKDZBCDU<XVONRNCPECF>>, Id32<PWFCKDZBCDU<GSPYYKIKJJK>>, Id32<PWFCKDZBCDU<MTKWVKXUIVO<GSPYYKIKJJK>>>, Id32<PWFCKDZBCDU<MTKWVKXUIVO<GSPYYKIKJJK>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x2B0EB40", Offset = "0x2B0D940", VA = "0x182B0EB40")]
		public static (Id32<PWFCKDZBCDU<XVONRNCPECF>>, Id32<PWFCKDZBCDU<MTKWVKXUIVO<GSPYYKIKJJK>>>, Id32<PWFCKDZBCDU<MTKWVKXUIVO<GSPYYKIKJJK>>>, Id32<PWFCKDZBCDU<MTKWVKXUIVO<GSPYYKIKJJK>>>) PRWHBGPNOOS(this UnsafeList<byte> a, [Optional] Id32<MTKWVKXUIVO<GSPYYKIKJJK>>? b, [Optional] Id32<MTKWVKXUIVO<GSPYYKIKJJK>>? c, [Optional] Id32<MTKWVKXUIVO<GSPYYKIKJJK>>? d)
		{
			return default((Id32<PWFCKDZBCDU<XVONRNCPECF>>, Id32<PWFCKDZBCDU<MTKWVKXUIVO<GSPYYKIKJJK>>>, Id32<PWFCKDZBCDU<MTKWVKXUIVO<GSPYYKIKJJK>>>, Id32<PWFCKDZBCDU<MTKWVKXUIVO<GSPYYKIKJJK>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x2B0D760", Offset = "0x2B0C560", VA = "0x182B0D760")]
		public static (Id32<PWFCKDZBCDU<XVONRNCPECF>>, Id32<PWFCKDZBCDU<GSPYYKIKJJK>>, Id32<PWFCKDZBCDU<MTKWVKXUIVO<GSPYYKIKJJK>>>) LRUBRBHTEHF(this UnsafeList<byte> a, [Optional] int? b, [Optional] Id32<MTKWVKXUIVO<GSPYYKIKJJK>>? c)
		{
			return default((Id32<PWFCKDZBCDU<XVONRNCPECF>>, Id32<PWFCKDZBCDU<GSPYYKIKJJK>>, Id32<PWFCKDZBCDU<MTKWVKXUIVO<GSPYYKIKJJK>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x2B10900", Offset = "0x2B0F700", VA = "0x182B10900")]
		public static (Id32<PWFCKDZBCDU<XVONRNCPECF>>, Id32<PWFCKDZBCDU<MTKWVKXUIVO<GSPYYKIKJJK>>>, Id32<PWFCKDZBCDU<MTKWVKXUIVO<GSPYYKIKJJK>>>) ZWUSDAXUYSA(this UnsafeList<byte> a, [Optional] Id32<MTKWVKXUIVO<GSPYYKIKJJK>>? b, [Optional] Id32<MTKWVKXUIVO<GSPYYKIKJJK>>? c)
		{
			return default((Id32<PWFCKDZBCDU<XVONRNCPECF>>, Id32<PWFCKDZBCDU<MTKWVKXUIVO<GSPYYKIKJJK>>>, Id32<PWFCKDZBCDU<MTKWVKXUIVO<GSPYYKIKJJK>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x2B0FF90", Offset = "0x2B0ED90", VA = "0x182B0FF90")]
		public static Id32<PWFCKDZBCDU<XVONRNCPECF>> VEDBIVDJQRD(this UnsafeList<byte> a)
		{
			return default(Id32<PWFCKDZBCDU<XVONRNCPECF>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x2B10010", Offset = "0x2B0EE10", VA = "0x182B10010")]
		public static (Id32<PWFCKDZBCDU<XVONRNCPECF>>, Id32<PWFCKDZBCDU<NCXCJLSDETL>>, Id32<PWFCKDZBCDU<NCXCJLSDETL>>, Id32<PWFCKDZBCDU<MTKWVKXUIVO<NCXCJLSDETL>>>) VIPWGMCOMGW(this UnsafeList<byte> a, float b, float c, [Optional] Id32<MTKWVKXUIVO<NCXCJLSDETL>>? d)
		{
			return default((Id32<PWFCKDZBCDU<XVONRNCPECF>>, Id32<PWFCKDZBCDU<NCXCJLSDETL>>, Id32<PWFCKDZBCDU<NCXCJLSDETL>>, Id32<PWFCKDZBCDU<MTKWVKXUIVO<NCXCJLSDETL>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x2B0BB10", Offset = "0x2B0A910", VA = "0x182B0BB10")]
		public static (Id32<PWFCKDZBCDU<XVONRNCPECF>>, Id32<PWFCKDZBCDU<NCXCJLSDETL>>, Id32<PWFCKDZBCDU<MTKWVKXUIVO<NCXCJLSDETL>>>, Id32<PWFCKDZBCDU<MTKWVKXUIVO<NCXCJLSDETL>>>) EGMUVSMFPCF(this UnsafeList<byte> a, float b, [Optional] Id32<MTKWVKXUIVO<NCXCJLSDETL>>? c, [Optional] Id32<MTKWVKXUIVO<NCXCJLSDETL>>? d)
		{
			return default((Id32<PWFCKDZBCDU<XVONRNCPECF>>, Id32<PWFCKDZBCDU<NCXCJLSDETL>>, Id32<PWFCKDZBCDU<MTKWVKXUIVO<NCXCJLSDETL>>>, Id32<PWFCKDZBCDU<MTKWVKXUIVO<NCXCJLSDETL>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x2B0B470", Offset = "0x2B0A270", VA = "0x182B0B470")]
		public static (Id32<PWFCKDZBCDU<XVONRNCPECF>>, Id32<PWFCKDZBCDU<MTKWVKXUIVO<NCXCJLSDETL>>>, Id32<PWFCKDZBCDU<MTKWVKXUIVO<NCXCJLSDETL>>>, Id32<PWFCKDZBCDU<MTKWVKXUIVO<NCXCJLSDETL>>>) AVVBSAZEWBO(this UnsafeList<byte> a, [Optional] Id32<MTKWVKXUIVO<NCXCJLSDETL>>? b, [Optional] Id32<MTKWVKXUIVO<NCXCJLSDETL>>? c, [Optional] Id32<MTKWVKXUIVO<NCXCJLSDETL>>? d)
		{
			return default((Id32<PWFCKDZBCDU<XVONRNCPECF>>, Id32<PWFCKDZBCDU<MTKWVKXUIVO<NCXCJLSDETL>>>, Id32<PWFCKDZBCDU<MTKWVKXUIVO<NCXCJLSDETL>>>, Id32<PWFCKDZBCDU<MTKWVKXUIVO<NCXCJLSDETL>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x2B0C490", Offset = "0x2B0B290", VA = "0x182B0C490")]
		public static (Id32<PWFCKDZBCDU<XVONRNCPECF>>, Id32<PWFCKDZBCDU<GSPYYKIKJJK>>, Id32<PWFCKDZBCDU<GSPYYKIKJJK>>, Id32<PWFCKDZBCDU<MTKWVKXUIVO<GSPYYKIKJJK>>>) FIFZUFYFTDO(this UnsafeList<byte> a, int b, int c, [Optional] Id32<MTKWVKXUIVO<GSPYYKIKJJK>>? d)
		{
			return default((Id32<PWFCKDZBCDU<XVONRNCPECF>>, Id32<PWFCKDZBCDU<GSPYYKIKJJK>>, Id32<PWFCKDZBCDU<GSPYYKIKJJK>>, Id32<PWFCKDZBCDU<MTKWVKXUIVO<GSPYYKIKJJK>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x2B0BC60", Offset = "0x2B0AA60", VA = "0x182B0BC60")]
		public static (Id32<PWFCKDZBCDU<XVONRNCPECF>>, Id32<PWFCKDZBCDU<GSPYYKIKJJK>>, Id32<PWFCKDZBCDU<MTKWVKXUIVO<GSPYYKIKJJK>>>, Id32<PWFCKDZBCDU<MTKWVKXUIVO<GSPYYKIKJJK>>>) EJWUNBIPMOL(this UnsafeList<byte> a, int b, [Optional] Id32<MTKWVKXUIVO<GSPYYKIKJJK>>? c, [Optional] Id32<MTKWVKXUIVO<GSPYYKIKJJK>>? d)
		{
			return default((Id32<PWFCKDZBCDU<XVONRNCPECF>>, Id32<PWFCKDZBCDU<GSPYYKIKJJK>>, Id32<PWFCKDZBCDU<MTKWVKXUIVO<GSPYYKIKJJK>>>, Id32<PWFCKDZBCDU<MTKWVKXUIVO<GSPYYKIKJJK>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x2B0E020", Offset = "0x2B0CE20", VA = "0x182B0E020")]
		public static (Id32<PWFCKDZBCDU<XVONRNCPECF>>, Id32<PWFCKDZBCDU<MTKWVKXUIVO<GSPYYKIKJJK>>>, Id32<PWFCKDZBCDU<MTKWVKXUIVO<GSPYYKIKJJK>>>, Id32<PWFCKDZBCDU<MTKWVKXUIVO<GSPYYKIKJJK>>>) NEXAWLFMAGG(this UnsafeList<byte> a, [Optional] Id32<MTKWVKXUIVO<GSPYYKIKJJK>>? b, [Optional] Id32<MTKWVKXUIVO<GSPYYKIKJJK>>? c, [Optional] Id32<MTKWVKXUIVO<GSPYYKIKJJK>>? d)
		{
			return default((Id32<PWFCKDZBCDU<XVONRNCPECF>>, Id32<PWFCKDZBCDU<MTKWVKXUIVO<GSPYYKIKJJK>>>, Id32<PWFCKDZBCDU<MTKWVKXUIVO<GSPYYKIKJJK>>>, Id32<PWFCKDZBCDU<MTKWVKXUIVO<GSPYYKIKJJK>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x2B0BF00", Offset = "0x2B0AD00", VA = "0x182B0BF00")]
		public static (Id32<PWFCKDZBCDU<XVONRNCPECF>>, Id32<PWFCKDZBCDU<GSPYYKIKJJK>>, Id32<PWFCKDZBCDU<GSPYYKIKJJK>>, Id32<PWFCKDZBCDU<MTKWVKXUIVO<GSPYYKIKJJK>>>) ERTHPAWSKFZ(this UnsafeList<byte> a, int b, int c, [Optional] Id32<MTKWVKXUIVO<GSPYYKIKJJK>>? d)
		{
			return default((Id32<PWFCKDZBCDU<XVONRNCPECF>>, Id32<PWFCKDZBCDU<GSPYYKIKJJK>>, Id32<PWFCKDZBCDU<GSPYYKIKJJK>>, Id32<PWFCKDZBCDU<MTKWVKXUIVO<GSPYYKIKJJK>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x2B0C740", Offset = "0x2B0B540", VA = "0x182B0C740")]
		public static (Id32<PWFCKDZBCDU<XVONRNCPECF>>, Id32<PWFCKDZBCDU<GSPYYKIKJJK>>, Id32<PWFCKDZBCDU<MTKWVKXUIVO<GSPYYKIKJJK>>>, Id32<PWFCKDZBCDU<MTKWVKXUIVO<GSPYYKIKJJK>>>) HCXMIFXQXAY(this UnsafeList<byte> a, int b, [Optional] Id32<MTKWVKXUIVO<GSPYYKIKJJK>>? c, [Optional] Id32<MTKWVKXUIVO<GSPYYKIKJJK>>? d)
		{
			return default((Id32<PWFCKDZBCDU<XVONRNCPECF>>, Id32<PWFCKDZBCDU<GSPYYKIKJJK>>, Id32<PWFCKDZBCDU<MTKWVKXUIVO<GSPYYKIKJJK>>>, Id32<PWFCKDZBCDU<MTKWVKXUIVO<GSPYYKIKJJK>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x2B0E7D0", Offset = "0x2B0D5D0", VA = "0x182B0E7D0")]
		public static (Id32<PWFCKDZBCDU<XVONRNCPECF>>, Id32<PWFCKDZBCDU<MTKWVKXUIVO<GSPYYKIKJJK>>>, Id32<PWFCKDZBCDU<MTKWVKXUIVO<GSPYYKIKJJK>>>, Id32<PWFCKDZBCDU<MTKWVKXUIVO<GSPYYKIKJJK>>>) PJZDWWKEZXT(this UnsafeList<byte> a, [Optional] Id32<MTKWVKXUIVO<GSPYYKIKJJK>>? b, [Optional] Id32<MTKWVKXUIVO<GSPYYKIKJJK>>? c, [Optional] Id32<MTKWVKXUIVO<GSPYYKIKJJK>>? d)
		{
			return default((Id32<PWFCKDZBCDU<XVONRNCPECF>>, Id32<PWFCKDZBCDU<MTKWVKXUIVO<GSPYYKIKJJK>>>, Id32<PWFCKDZBCDU<MTKWVKXUIVO<GSPYYKIKJJK>>>, Id32<PWFCKDZBCDU<MTKWVKXUIVO<GSPYYKIKJJK>>>));
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
