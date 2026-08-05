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
		[Cpp2IlInjected.Address(RVA = "0xACE190", Offset = "0xACD590", VA = "0x180ACE190")]
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
		[Cpp2IlInjected.Address(RVA = "0x2867DA0", Offset = "0x28671A0", VA = "0x182867DA0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xACEB40", Offset = "0xACDF40", VA = "0x180ACEB40")]
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
		[Cpp2IlInjected.Address(RVA = "0xACEB80", Offset = "0xACDF80", VA = "0x180ACEB80")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
namespace Circuits.Shared.Core.ByteCode
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public static class HTJCKJXWYCF
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x3660B90", Offset = "0x365FF90", VA = "0x183660B90")]
		public static Id32<SDWTKKVDDYT<a>> ULQYLLVQWXL<a>(this int a)
		{
			return default(Id32<SDWTKKVDDYT<a>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x2867CC0", Offset = "0x28670C0", VA = "0x182867CC0")]
		public static Id32<AKFVBWYPZLW> IIRNBDFVHSC(this int a)
		{
			return default(Id32<AKFVBWYPZLW>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x3660B90", Offset = "0x365FF90", VA = "0x183660B90")]
		public static Id32<IMFYYDLBECV<b>> XEZNERKVGBV<b>(this int a)
		{
			return default(Id32<IMFYYDLBECV<b>>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public sealed class SDWTKKVDDYT<a>
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public sealed class ZZWGXXGPIDC
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public sealed class GKDKIYQIDND
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public sealed class AKFVBWYPZLW
	{
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public sealed class IDPQTAFRJWO
	{
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public sealed class BHFGZKKMBRG
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
	public static class LEENTCNWBMX
	{
		[Cpp2IlInjected.Token(Token = "0x200000E")]
		public readonly struct ProcessOpDelegate<TContext, TDeps, TCompileState>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000091")]
			private readonly IntPtr _impl;

			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0xBB8570", Offset = "0xBB7970", VA = "0x180BB8570")]
			public ProcessOpDelegate(IntPtr impl)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x5A967E0", Offset = "0x5A95BE0", VA = "0x185A967E0")]
			public int Invoke(TDeps deps, TContext ctx, TCompileState compileState, [In] UnsafeList<byte> fromByteCode, int byteCodePtr)
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x3724190", Offset = "0x3723590", VA = "0x183724190")]
		public static void IIPQMJQONUM<TDeps, TContext, TCompileState>(TDeps a, TContext b, TCompileState c, [In] UnsafeList<byte> oldByteCode, UnsafeList<byte> newByteCode, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processAddF32_F32i_F32i_F32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processAddF32_F32i_F32r_F32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processAddF32_F32r_F32r_F32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processAddI32_I32i_I32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processAddI32_I32i_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processAddI32_I32r_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processAndI32_I32i_I32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processAndI32_I32i_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processAndI32_I32r_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfEqualF32_F32i_F32i_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfEqualF32_F32i_F32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfEqualF32_F32r_F32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfEqualI32_I32i_I32i_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfEqualI32_I32i_I32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfEqualI32_I32r_I32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfGreaterOrEqualF32_F32i_F32i_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfGreaterOrEqualF32_F32i_F32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfGreaterOrEqualF32_F32r_F32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfGreaterOrEqualI32_I32i_I32i_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfGreaterOrEqualI32_I32i_I32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfGreaterOrEqualI32_I32r_I32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfLessF32_F32i_F32i_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfLessF32_F32i_F32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfLessF32_F32r_F32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfLessI32_I32i_I32i_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfLessI32_I32i_I32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfLessI32_I32r_I32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfLessOrEqualF32_F32i_F32i_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfLessOrEqualF32_F32i_F32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfLessOrEqualF32_F32r_F32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfLessOrEqualI32_I32i_I32i_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfLessOrEqualI32_I32i_I32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfLessOrEqualI32_I32r_I32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfNotEqualF32_F32i_F32i_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfNotEqualF32_F32i_F32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfNotEqualF32_F32r_F32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfNotEqualI32_I32i_I32i_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfNotEqualI32_I32i_I32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfNotEqualI32_I32r_I32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfNotZeroF32_F32i_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfNotZeroF32_F32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfNotZeroI32_I32i_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfNotZeroI32_I32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfZeroF32_F32i_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfZeroF32_F32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfZeroI32_I32i_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfZeroI32_I32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processCallInternal_I32i_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processCallInternal_I32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processCallExternal_I32i_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processCallExternal_I32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processCallRuntime_I32i_I32i_Xi, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processCopyI32_I32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processCopyI32_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processCopyX_Xr_I32i_Xi, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processCopyX_Xr_Xr_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processDivideF32_F32i_F32i_F32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processDivideF32_F32i_F32r_F32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processDivideF32_F32r_F32r_F32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processDivideI32_I32i_I32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processDivideI32_I32i_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processDivideI32_I32r_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processEqualF32_F32i_F32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processEqualF32_F32i_F32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processEqualF32_F32r_F32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processEqualI32_I32i_I32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processEqualI32_I32i_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processEqualI32_I32r_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processEnd, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processGreaterF32_F32i_F32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processGreaterF32_F32i_F32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processGreaterF32_F32r_F32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processGreaterI32_I32i_I32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processGreaterI32_I32i_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processGreaterI32_I32r_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processGreaterOrEqualF32_F32i_F32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processGreaterOrEqualF32_F32i_F32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processGreaterOrEqualF32_F32r_F32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processGreaterOrEqualI32_I32i_I32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processGreaterOrEqualI32_I32i_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processGreaterOrEqualI32_I32r_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processJump_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processJump_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processLessF32_F32i_F32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processLessF32_F32i_F32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processLessF32_F32r_F32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processLessI32_I32i_I32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processLessI32_I32i_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processLessI32_I32r_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processLessOrEqualF32_F32i_F32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processLessOrEqualF32_F32i_F32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processLessOrEqualF32_F32r_F32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processLessOrEqualI32_I32i_I32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processLessOrEqualI32_I32i_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processLessOrEqualI32_I32r_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processModI32_I32i_I32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processModI32_I32i_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processModI32_I32r_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processMultiplyF32_F32i_F32i_F32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processMultiplyF32_F32i_F32r_F32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processMultiplyF32_F32r_F32r_F32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processMultiplyI32_I32i_I32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processMultiplyI32_I32i_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processMultiplyI32_I32r_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processNegateF32_F32i_F32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processNegateF32_F32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processNegateF32_F32r_F32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processNegateI32_I32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processNegateI32_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processNegateI32_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processNoOp, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processNotEqualF32_F32i_F32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processNotEqualF32_F32i_F32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processNotEqualF32_F32r_F32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processNotEqualI32_I32i_I32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processNotEqualI32_I32i_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processNotEqualI32_I32r_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processNotI32_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processNotI32_I32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processNotI32_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processOrI32_I32i_I32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processOrI32_I32i_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processOrI32_I32r_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processReturn, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processStaticCastF32I32_F32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processStaticCastI32F32_I32r_F32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processSubtractF32_F32i_F32i_F32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processSubtractF32_F32i_F32r_F32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processSubtractF32_F32r_F32r_F32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processSubtractI32_I32i_I32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processSubtractI32_I32i_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processSubtractI32_I32r_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processXorI32_I32i_I32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processXorI32_I32i_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processXorI32_I32r_I32r_I32r) where TDeps : notnull where TContext : notnull where TCompileState : notnull
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x2867D00", Offset = "0x2867100", VA = "0x182867D00")]
		private static int AKAHVORHPFA([In] UnsafeList<byte> from, UnsafeList<byte> a, int b, int c)
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public static class DDNDOOHEOPA
	{
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		public static readonly int FWUHYWXFZPK;

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x34FFEC0", Offset = "0x34FF2C0", VA = "0x1834FFEC0")]
		public static Id32<SDWTKKVDDYT<a>> OSSEEWQYFXA<a>([In] this UnsafeList<byte> self)
		{
			return default(Id32<SDWTKKVDDYT<a>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x3500020", Offset = "0x34FF420", VA = "0x183500020")]
		public static Id32<SDWTKKVDDYT<SDWTKKVDDYT<b>>> WTXXZXBLVWR<b>(this UnsafeList<byte> a, [Optional] Id32<SDWTKKVDDYT<b>>? b)
		{
			return default(Id32<SDWTKKVDDYT<SDWTKKVDDYT<b>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x28678C0", Offset = "0x2866CC0", VA = "0x1828678C0")]
		public static Id32<SDWTKKVDDYT<IZXQRWKUWLU>> ONMCCHEAGWB(this UnsafeList<byte> a, [Optional] Id32<IZXQRWKUWLU>? b)
		{
			return default(Id32<SDWTKKVDDYT<IZXQRWKUWLU>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x2867AA0", Offset = "0x2866EA0", VA = "0x182867AA0")]
		public static Id32<SDWTKKVDDYT<ZZWGXXGPIDC>> XKBBJGEHVIZ(this UnsafeList<byte> a, [Optional] float? b)
		{
			return default(Id32<SDWTKKVDDYT<ZZWGXXGPIDC>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x28676E0", Offset = "0x2866AE0", VA = "0x1828676E0")]
		public static Id32<SDWTKKVDDYT<GKDKIYQIDND>> CPAHEGCKELW(this UnsafeList<byte> a, [Optional] int? b)
		{
			return default(Id32<SDWTKKVDDYT<GKDKIYQIDND>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x28675F0", Offset = "0x28669F0", VA = "0x1828675F0")]
		public static Id32<SDWTKKVDDYT<NTOQNIRTTPF>> ATENCEXKFJI(this UnsafeList<byte> a, [Optional] Id32<NTOQNIRTTPF>? b)
		{
			return default(Id32<SDWTKKVDDYT<NTOQNIRTTPF>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x28677C0", Offset = "0x2866BC0", VA = "0x1828677C0")]
		public static Id32<SDWTKKVDDYT<BHFGZKKMBRG>> KERPVXDKZDN(this UnsafeList<byte> a, [Optional] byte? b)
		{
			return default(Id32<SDWTKKVDDYT<BHFGZKKMBRG>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x28679B0", Offset = "0x2866DB0", VA = "0x1828679B0")]
		public static Id32<SDWTKKVDDYT<AKFVBWYPZLW>> UJQGACQVIWD(this UnsafeList<byte> a, [Optional] Id32<AKFVBWYPZLW>? b)
		{
			return default(Id32<SDWTKKVDDYT<AKFVBWYPZLW>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x2867B90", Offset = "0x2866F90", VA = "0x182867B90")]
		public static Id32<SDWTKKVDDYT<IDPQTAFRJWO>> ZQVKVFQYQZD(this UnsafeList<byte> a, [Optional] Op? b)
		{
			return default(Id32<SDWTKKVDDYT<IDPQTAFRJWO>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x3500020", Offset = "0x34FF420", VA = "0x183500020")]
		public static Id32<SDWTKKVDDYT<IMFYYDLBECV<c>>> QMBXQGYQETR<c>(this UnsafeList<byte> a, [Optional] Id32<IMFYYDLBECV<c>>? b)
		{
			return default(Id32<SDWTKKVDDYT<IMFYYDLBECV<c>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x28674F0", Offset = "0x28668F0", VA = "0x1828674F0")]
		public static void LKUQKYDOEOV(this UnsafeList<byte> a, Id32<SDWTKKVDDYT<GKDKIYQIDND>> b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x34FFE60", Offset = "0x34FF260", VA = "0x1834FFE60")]
		public static void EXFBXPEEIYU<d>(this UnsafeList<byte> a, Id32<SDWTKKVDDYT<SDWTKKVDDYT<d>>> b, Id32<SDWTKKVDDYT<d>> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x34FFE60", Offset = "0x34FF260", VA = "0x1834FFE60")]
		public static void TUWWHEZIUUG<e>(this UnsafeList<byte> a, Id32<SDWTKKVDDYT<IMFYYDLBECV<e>>> b, Id32<IMFYYDLBECV<e>> c)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public static class RELNHUYYSSD
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x2867E20", Offset = "0x2867220", VA = "0x182867E20")]
		public static Union32 VRNUGCPWVUP([In] this ReadOnlySpan<byte> bytes, int a)
		{
			return default(Union32);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x2867E90", Offset = "0x2867290", VA = "0x182867E90")]
		public static Union32 VRNUGCPWVUP([In] this UnsafeList<byte> bytes, int a)
		{
			return default(Union32);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x399BF10", Offset = "0x399B310", VA = "0x18399BF10")]
		public static Union32 VRNUGCPWVUP<f>(this ReadOnlyIdArray<f, byte> a, Id32<f> b)
		{
			return default(Union32);
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x399BD30", Offset = "0x399B130", VA = "0x18399BD30")]
		public static Union32 VRNUGCPWVUP<g>([In] this ReadOnlyIdSpan<g, byte> bytes, Id32<g> a)
		{
			return default(Union32);
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x399BEB0", Offset = "0x399B2B0", VA = "0x18399BEB0")]
		public static Union32 VRNUGCPWVUP<i>(this IdArray<i, byte> a, Id32<i> b)
		{
			return default(Union32);
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x399C090", Offset = "0x399B490", VA = "0x18399C090")]
		public static Union32 VRNUGCPWVUP<j>([In] this IdSpan<j, byte> bytes, Id32<j> a)
		{
			return default(Union32);
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x399C100", Offset = "0x399B500", VA = "0x18399C100")]
		public static Union32 VRNUGCPWVUP<k>(this ReadOnlyIdArray<k, byte> a, Id32<k> b)
		{
			return default(Union32);
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x2867E20", Offset = "0x2867220", VA = "0x182867E20")]
		public static int PYOADTEVQEI([In] this ReadOnlySpan<byte> bytes, int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x2867440", Offset = "0x2866840", VA = "0x182867440")]
		public static int PYOADTEVQEI([In] this UnsafeList<byte> bytes, int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x399B110", Offset = "0x399A510", VA = "0x18399B110")]
		public static int PYOADTEVQEI<p>(this ReadOnlyIdArray<p, byte> a, Id32<p> b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x399B200", Offset = "0x399A600", VA = "0x18399B200")]
		public static int PYOADTEVQEI<s>(this IdArray<s, byte> a, Id32<s> b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x399B160", Offset = "0x399A560", VA = "0x18399B160")]
		public static int PYOADTEVQEI<t>([In] this IdSpan<t, byte> bytes, Id32<t> a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x399B1B0", Offset = "0x399A5B0", VA = "0x18399B1B0")]
		public static int PYOADTEVQEI<u>(this ReadOnlyIdArray<u, byte> a, Id32<u> b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x399C970", Offset = "0x399BD70", VA = "0x18399C970")]
		public static float ZFVQRBPTYXT<bc>(this IdArray<bc, byte> a, Id32<bc> b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x399C920", Offset = "0x399BD20", VA = "0x18399C920")]
		public static float ZFVQRBPTYXT<bd>([In] this IdSpan<bd, byte> bytes, Id32<bd> a)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x399C9F0", Offset = "0x399BDF0", VA = "0x18399C9F0")]
		public static float ZFVQRBPTYXT<be>(this ReadOnlyIdArray<be, byte> a, Id32<be> b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x399B9F0", Offset = "0x399ADF0", VA = "0x18399B9F0")]
		public static byte RUNPQOVEJLB<bj>(this ReadOnlyIdArray<bj, byte> a, Id32<bj> b)
		{
			return default(byte);
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x399B890", Offset = "0x399AC90", VA = "0x18399B890")]
		public static byte RUNPQOVEJLB<bk>([In] this ReadOnlyIdSpan<bk, byte> bytes, Id32<bk> a)
		{
			return default(byte);
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x399B970", Offset = "0x399AD70", VA = "0x18399B970")]
		public static byte RUNPQOVEJLB<bm>(this IdArray<bm, byte> a, Id32<bm> b)
		{
			return default(byte);
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x399B8E0", Offset = "0x399ACE0", VA = "0x18399B8E0")]
		public static byte RUNPQOVEJLB<bn>([In] this IdSpan<bn, byte> bytes, Id32<bn> a)
		{
			return default(byte);
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x399B7C0", Offset = "0x399ABC0", VA = "0x18399B7C0")]
		public static byte RUNPQOVEJLB<bo>(this ReadOnlyIdArray<bo, byte> a, Id32<bo> b)
		{
			return default(byte);
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x2867440", Offset = "0x2866840", VA = "0x182867440")]
		public static Op JYFHJRAYPJL([In] this UnsafeList<byte> bytes, int a)
		{
			return default(Op);
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x399AF00", Offset = "0x399A300", VA = "0x18399AF00")]
		public static Op JYFHJRAYPJL<by>(this ReadOnlyIdArray<by, byte> a, Id32<by> b)
		{
			return default(Op);
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x399C660", Offset = "0x399BA60", VA = "0x18399C660")]
		public static Id32<SDWTKKVDDYT<FVPAIKKPAFL>> YMZQVKVJKAN<cg>(this IdArray<cg, byte> a, Id32<cg> b)
		{
			return default(Id32<SDWTKKVDDYT<FVPAIKKPAFL>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x399C6E0", Offset = "0x399BAE0", VA = "0x18399C6E0")]
		public static Id32<SDWTKKVDDYT<FVPAIKKPAFL>> YMZQVKVJKAN<ch>([In] this IdSpan<ch, byte> bytes, Id32<ch> a)
		{
			return default(Id32<SDWTKKVDDYT<FVPAIKKPAFL>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x399C770", Offset = "0x399BB70", VA = "0x18399C770")]
		public static Id32<SDWTKKVDDYT<FVPAIKKPAFL>> YMZQVKVJKAN<ci>(this ReadOnlyIdArray<ci, byte> a, Id32<ci> b)
		{
			return default(Id32<SDWTKKVDDYT<FVPAIKKPAFL>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x399AFE0", Offset = "0x399A3E0", VA = "0x18399AFE0")]
		public static Id32<IMFYYDLBECV<FVPAIKKPAFL>> MAPNGTQPUEL<cs>(this ReadOnlyIdArray<cs, byte> a, Id32<cs> b)
		{
			return default(Id32<IMFYYDLBECV<FVPAIKKPAFL>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x399C460", Offset = "0x399B860", VA = "0x18399C460")]
		public static Id32<AKFVBWYPZLW> XYJXAEMOSGD<da>(this IdArray<da, byte> a, Id32<da> b)
		{
			return default(Id32<AKFVBWYPZLW>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x399C340", Offset = "0x399B740", VA = "0x18399C340")]
		public static Id32<AKFVBWYPZLW> XYJXAEMOSGD<db>([In] this IdSpan<db, byte> bytes, Id32<db> a)
		{
			return default(Id32<AKFVBWYPZLW>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x399C3D0", Offset = "0x399B7D0", VA = "0x18399C3D0")]
		public static Id32<AKFVBWYPZLW> XYJXAEMOSGD<dc>(this ReadOnlyIdArray<dc, byte> a, Id32<dc> b)
		{
			return default(Id32<AKFVBWYPZLW>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x399B520", Offset = "0x399A920", VA = "0x18399B520")]
		public static Id32<IZXQRWKUWLU> RRCHSHCQJSR<dl>([In] this IdSpan<dl, byte> bytes, Id32<dl> a)
		{
			return default(Id32<IZXQRWKUWLU>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x399B490", Offset = "0x399A890", VA = "0x18399B490")]
		public static Id32<IZXQRWKUWLU> RRCHSHCQJSR<dm>(this ReadOnlyIdArray<dm, byte> a, Id32<dm> b)
		{
			return default(Id32<IZXQRWKUWLU>);
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x399B300", Offset = "0x399A700", VA = "0x18399B300")]
		public static Id32<NTOQNIRTTPF> QAHKAEIYNMA<dw>(this ReadOnlyIdArray<dw, byte> a, Id32<dw> b)
		{
			return default(Id32<NTOQNIRTTPF>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public static class WNEHIKFRRVF
	{
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x286DA10", Offset = "0x286CE10", VA = "0x18286DA10")]
		public static void YEDDJRRFSAW(this UnsafeList<byte> a, int b, Union32 c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x286DB50", Offset = "0x286CF50", VA = "0x18286DB50")]
		public static void YEDDJRRFSAW(this byte[] a, int b, Union32 c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x286DAD0", Offset = "0x286CED0", VA = "0x18286DAD0")]
		public static void YEDDJRRFSAW([In] this Span<byte> bytes, int a, Union32 b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x3BF8DE0", Offset = "0x3BF81E0", VA = "0x183BF8DE0")]
		public static void YEDDJRRFSAW<e>(this IdArray<e, byte> a, Id32<e> b, Union32 c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x3BF8C90", Offset = "0x3BF8090", VA = "0x183BF8C90")]
		public static void YEDDJRRFSAW<f>([In] this IdSpan<f, byte> bytes, Id32<f> a, Union32 b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x28674F0", Offset = "0x28668F0", VA = "0x1828674F0")]
		public static void LKUQKYDOEOV(this UnsafeList<byte> a, int b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x286D990", Offset = "0x286CD90", VA = "0x18286D990")]
		public static void LKUQKYDOEOV(this byte[] a, int b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x286D910", Offset = "0x286CD10", VA = "0x18286D910")]
		public static void LKUQKYDOEOV([In] this Span<byte> bytes, int a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x3BF8A30", Offset = "0x3BF7E30", VA = "0x183BF8A30")]
		public static void LKUQKYDOEOV<h>(this IdArray<h, byte> a, Id32<h> b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x3BF89D0", Offset = "0x3BF7DD0", VA = "0x183BF89D0")]
		public static void LKUQKYDOEOV<i>([In] this IdSpan<i, byte> bytes, Id32<i> a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x286D8D0", Offset = "0x286CCD0", VA = "0x18286D8D0")]
		public static void DDKYKXRQHRS(this UnsafeList<byte> a, int b, float c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x3BF8650", Offset = "0x3BF7A50", VA = "0x183BF8650")]
		public static void DDKYKXRQHRS<k>(this IdArray<k, byte> a, Id32<k> b, float c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x3BF86C0", Offset = "0x3BF7AC0", VA = "0x183BF86C0")]
		public static void DDKYKXRQHRS<l>([In] this IdSpan<l, byte> bytes, Id32<l> a, float b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x286DBC0", Offset = "0x286CFC0", VA = "0x18286DBC0")]
		public static void ZBALEKXRCZK(this UnsafeList<byte> a, int b, byte c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x3BF8FE0", Offset = "0x3BF83E0", VA = "0x183BF8FE0")]
		public static void ZBALEKXRCZK<n>(this IdArray<n, byte> a, Id32<n> b, byte c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x3BF9030", Offset = "0x3BF8430", VA = "0x183BF9030")]
		public static void ZBALEKXRCZK<o>([In] this IdSpan<o, byte> bytes, Id32<o> a, byte b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x3BF8870", Offset = "0x3BF7C70", VA = "0x183BF8870")]
		public static void EXFBXPEEIYU<q>(this IdArray<q, byte> a, Id32<q> b, Id32<SDWTKKVDDYT<FVPAIKKPAFL>> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x3BF87F0", Offset = "0x3BF7BF0", VA = "0x183BF87F0")]
		public static void EXFBXPEEIYU<r>([In] this IdSpan<r, byte> bytes, Id32<r> a, Id32<SDWTKKVDDYT<FVPAIKKPAFL>> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x3BF8870", Offset = "0x3BF7C70", VA = "0x183BF8870")]
		public static void KWQPNBIISJO<t>(this IdArray<t, byte> a, Id32<t> b, Id32<AKFVBWYPZLW> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x3BF87F0", Offset = "0x3BF7BF0", VA = "0x183BF87F0")]
		public static void KWQPNBIISJO<u>([In] this IdSpan<u, byte> bytes, Id32<u> a, Id32<AKFVBWYPZLW> b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public static class SCUWUUKPAKK
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x286A250", Offset = "0x2869650", VA = "0x18286A250")]
		public static (Id32<SDWTKKVDDYT<IDPQTAFRJWO>>, Id32<SDWTKKVDDYT<ZZWGXXGPIDC>>, Id32<SDWTKKVDDYT<ZZWGXXGPIDC>>, Id32<SDWTKKVDDYT<IMFYYDLBECV<ZZWGXXGPIDC>>>) KILLLVTLHEE(this UnsafeList<byte> a, float b, float c, [Optional] Id32<IMFYYDLBECV<ZZWGXXGPIDC>>? d)
		{
			return default((Id32<SDWTKKVDDYT<IDPQTAFRJWO>>, Id32<SDWTKKVDDYT<ZZWGXXGPIDC>>, Id32<SDWTKKVDDYT<ZZWGXXGPIDC>>, Id32<SDWTKKVDDYT<IMFYYDLBECV<ZZWGXXGPIDC>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x2869020", Offset = "0x2868420", VA = "0x182869020")]
		public static (Id32<SDWTKKVDDYT<IDPQTAFRJWO>>, Id32<SDWTKKVDDYT<ZZWGXXGPIDC>>, Id32<SDWTKKVDDYT<IMFYYDLBECV<ZZWGXXGPIDC>>>, Id32<SDWTKKVDDYT<IMFYYDLBECV<ZZWGXXGPIDC>>>) DYRRQWOMXPN(this UnsafeList<byte> a, float b, [Optional] Id32<IMFYYDLBECV<ZZWGXXGPIDC>>? c, [Optional] Id32<IMFYYDLBECV<ZZWGXXGPIDC>>? d)
		{
			return default((Id32<SDWTKKVDDYT<IDPQTAFRJWO>>, Id32<SDWTKKVDDYT<ZZWGXXGPIDC>>, Id32<SDWTKKVDDYT<IMFYYDLBECV<ZZWGXXGPIDC>>>, Id32<SDWTKKVDDYT<IMFYYDLBECV<ZZWGXXGPIDC>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x286D580", Offset = "0x286C980", VA = "0x18286D580")]
		public static (Id32<SDWTKKVDDYT<IDPQTAFRJWO>>, Id32<SDWTKKVDDYT<IMFYYDLBECV<ZZWGXXGPIDC>>>, Id32<SDWTKKVDDYT<IMFYYDLBECV<ZZWGXXGPIDC>>>, Id32<SDWTKKVDDYT<IMFYYDLBECV<ZZWGXXGPIDC>>>) ZBVDCSPPGTY(this UnsafeList<byte> a, [Optional] Id32<IMFYYDLBECV<ZZWGXXGPIDC>>? b, [Optional] Id32<IMFYYDLBECV<ZZWGXXGPIDC>>? c, [Optional] Id32<IMFYYDLBECV<ZZWGXXGPIDC>>? d)
		{
			return default((Id32<SDWTKKVDDYT<IDPQTAFRJWO>>, Id32<SDWTKKVDDYT<IMFYYDLBECV<ZZWGXXGPIDC>>>, Id32<SDWTKKVDDYT<IMFYYDLBECV<ZZWGXXGPIDC>>>, Id32<SDWTKKVDDYT<IMFYYDLBECV<ZZWGXXGPIDC>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x286C190", Offset = "0x286B590", VA = "0x18286C190")]
		public static (Id32<SDWTKKVDDYT<IDPQTAFRJWO>>, Id32<SDWTKKVDDYT<GKDKIYQIDND>>, Id32<SDWTKKVDDYT<GKDKIYQIDND>>, Id32<SDWTKKVDDYT<IMFYYDLBECV<GKDKIYQIDND>>>) UFZDJYAFTLU(this UnsafeList<byte> a, int b, int c, [Optional] Id32<IMFYYDLBECV<GKDKIYQIDND>>? d)
		{
			return default((Id32<SDWTKKVDDYT<IDPQTAFRJWO>>, Id32<SDWTKKVDDYT<GKDKIYQIDND>>, Id32<SDWTKKVDDYT<GKDKIYQIDND>>, Id32<SDWTKKVDDYT<IMFYYDLBECV<GKDKIYQIDND>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x286A8B0", Offset = "0x2869CB0", VA = "0x18286A8B0")]
		public static (Id32<SDWTKKVDDYT<IDPQTAFRJWO>>, Id32<SDWTKKVDDYT<GKDKIYQIDND>>, Id32<SDWTKKVDDYT<IMFYYDLBECV<GKDKIYQIDND>>>, Id32<SDWTKKVDDYT<IMFYYDLBECV<GKDKIYQIDND>>>) MZSIDWMVOJX(this UnsafeList<byte> a, int b, [Optional] Id32<IMFYYDLBECV<GKDKIYQIDND>>? c, [Optional] Id32<IMFYYDLBECV<GKDKIYQIDND>>? d)
		{
			return default((Id32<SDWTKKVDDYT<IDPQTAFRJWO>>, Id32<SDWTKKVDDYT<GKDKIYQIDND>>, Id32<SDWTKKVDDYT<IMFYYDLBECV<GKDKIYQIDND>>>, Id32<SDWTKKVDDYT<IMFYYDLBECV<GKDKIYQIDND>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x286A130", Offset = "0x2869530", VA = "0x18286A130")]
		public static (Id32<SDWTKKVDDYT<IDPQTAFRJWO>>, Id32<SDWTKKVDDYT<IMFYYDLBECV<GKDKIYQIDND>>>, Id32<SDWTKKVDDYT<IMFYYDLBECV<GKDKIYQIDND>>>, Id32<SDWTKKVDDYT<IMFYYDLBECV<GKDKIYQIDND>>>) KFRESUJLNJC(this UnsafeList<byte> a, [Optional] Id32<IMFYYDLBECV<GKDKIYQIDND>>? b, [Optional] Id32<IMFYYDLBECV<GKDKIYQIDND>>? c, [Optional] Id32<IMFYYDLBECV<GKDKIYQIDND>>? d)
		{
			return default((Id32<SDWTKKVDDYT<IDPQTAFRJWO>>, Id32<SDWTKKVDDYT<IMFYYDLBECV<GKDKIYQIDND>>>, Id32<SDWTKKVDDYT<IMFYYDLBECV<GKDKIYQIDND>>>, Id32<SDWTKKVDDYT<IMFYYDLBECV<GKDKIYQIDND>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x286CC00", Offset = "0x286C000", VA = "0x18286CC00")]
		public static (Id32<SDWTKKVDDYT<IDPQTAFRJWO>>, Id32<SDWTKKVDDYT<GKDKIYQIDND>>, Id32<SDWTKKVDDYT<GKDKIYQIDND>>, Id32<SDWTKKVDDYT<IMFYYDLBECV<GKDKIYQIDND>>>) WSNPSWIYDOA(this UnsafeList<byte> a, int b, int c, [Optional] Id32<IMFYYDLBECV<GKDKIYQIDND>>? d)
		{
			return default((Id32<SDWTKKVDDYT<IDPQTAFRJWO>>, Id32<SDWTKKVDDYT<GKDKIYQIDND>>, Id32<SDWTKKVDDYT<GKDKIYQIDND>>, Id32<SDWTKKVDDYT<IMFYYDLBECV<GKDKIYQIDND>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x286BA40", Offset = "0x286AE40", VA = "0x18286BA40")]
		public static (Id32<SDWTKKVDDYT<IDPQTAFRJWO>>, Id32<SDWTKKVDDYT<GKDKIYQIDND>>, Id32<SDWTKKVDDYT<IMFYYDLBECV<GKDKIYQIDND>>>, Id32<SDWTKKVDDYT<IMFYYDLBECV<GKDKIYQIDND>>>) QWCKLNGEEYX(this UnsafeList<byte> a, int b, [Optional] Id32<IMFYYDLBECV<GKDKIYQIDND>>? c, [Optional] Id32<IMFYYDLBECV<GKDKIYQIDND>>? d)
		{
			return default((Id32<SDWTKKVDDYT<IDPQTAFRJWO>>, Id32<SDWTKKVDDYT<GKDKIYQIDND>>, Id32<SDWTKKVDDYT<IMFYYDLBECV<GKDKIYQIDND>>>, Id32<SDWTKKVDDYT<IMFYYDLBECV<GKDKIYQIDND>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x286BB90", Offset = "0x286AF90", VA = "0x18286BB90")]
		public static (Id32<SDWTKKVDDYT<IDPQTAFRJWO>>, Id32<SDWTKKVDDYT<IMFYYDLBECV<GKDKIYQIDND>>>, Id32<SDWTKKVDDYT<IMFYYDLBECV<GKDKIYQIDND>>>, Id32<SDWTKKVDDYT<IMFYYDLBECV<GKDKIYQIDND>>>) QYYRJYJIMXE(this UnsafeList<byte> a, [Optional] Id32<IMFYYDLBECV<GKDKIYQIDND>>? b, [Optional] Id32<IMFYYDLBECV<GKDKIYQIDND>>? c, [Optional] Id32<IMFYYDLBECV<GKDKIYQIDND>>? d)
		{
			return default((Id32<SDWTKKVDDYT<IDPQTAFRJWO>>, Id32<SDWTKKVDDYT<IMFYYDLBECV<GKDKIYQIDND>>>, Id32<SDWTKKVDDYT<IMFYYDLBECV<GKDKIYQIDND>>>, Id32<SDWTKKVDDYT<IMFYYDLBECV<GKDKIYQIDND>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x286D6A0", Offset = "0x286CAA0", VA = "0x18286D6A0")]
		public static (Id32<SDWTKKVDDYT<IDPQTAFRJWO>>, Id32<SDWTKKVDDYT<GKDKIYQIDND>>, Id32<SDWTKKVDDYT<SDWTKKVDDYT<IDPQTAFRJWO>>>) ZKPJMCPNDFI(this UnsafeList<byte> a, [Optional] int? b, [Optional] Id32<SDWTKKVDDYT<IDPQTAFRJWO>>? c)
		{
			return default((Id32<SDWTKKVDDYT<IDPQTAFRJWO>>, Id32<SDWTKKVDDYT<GKDKIYQIDND>>, Id32<SDWTKKVDDYT<SDWTKKVDDYT<IDPQTAFRJWO>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x2868DF0", Offset = "0x28681F0", VA = "0x182868DF0")]
		public static (Id32<SDWTKKVDDYT<IDPQTAFRJWO>>, Id32<SDWTKKVDDYT<IMFYYDLBECV<GKDKIYQIDND>>>, Id32<SDWTKKVDDYT<SDWTKKVDDYT<IDPQTAFRJWO>>>) DSTSSGVXLQB(this UnsafeList<byte> a, [Optional] Id32<IMFYYDLBECV<GKDKIYQIDND>>? b, [Optional] Id32<SDWTKKVDDYT<IDPQTAFRJWO>>? c)
		{
			return default((Id32<SDWTKKVDDYT<IDPQTAFRJWO>>, Id32<SDWTKKVDDYT<IMFYYDLBECV<GKDKIYQIDND>>>, Id32<SDWTKKVDDYT<SDWTKKVDDYT<IDPQTAFRJWO>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x28685B0", Offset = "0x28679B0", VA = "0x1828685B0")]
		public static (Id32<SDWTKKVDDYT<IDPQTAFRJWO>>, Id32<SDWTKKVDDYT<GKDKIYQIDND>>, Id32<SDWTKKVDDYT<SDWTKKVDDYT<IDPQTAFRJWO>>>) BNJEBHEOOTV(this UnsafeList<byte> a, [Optional] int? b, [Optional] Id32<SDWTKKVDDYT<IDPQTAFRJWO>>? c)
		{
			return default((Id32<SDWTKKVDDYT<IDPQTAFRJWO>>, Id32<SDWTKKVDDYT<GKDKIYQIDND>>, Id32<SDWTKKVDDYT<SDWTKKVDDYT<IDPQTAFRJWO>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x286A610", Offset = "0x2869A10", VA = "0x18286A610")]
		public static (Id32<SDWTKKVDDYT<IDPQTAFRJWO>>, Id32<SDWTKKVDDYT<IMFYYDLBECV<GKDKIYQIDND>>>, Id32<SDWTKKVDDYT<SDWTKKVDDYT<IDPQTAFRJWO>>>) LGPINDUGWXS(this UnsafeList<byte> a, [Optional] Id32<IMFYYDLBECV<GKDKIYQIDND>>? b, [Optional] Id32<SDWTKKVDDYT<IDPQTAFRJWO>>? c)
		{
			return default((Id32<SDWTKKVDDYT<IDPQTAFRJWO>>, Id32<SDWTKKVDDYT<IMFYYDLBECV<GKDKIYQIDND>>>, Id32<SDWTKKVDDYT<SDWTKKVDDYT<IDPQTAFRJWO>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x2868050", Offset = "0x2867450", VA = "0x182868050")]
		public static (Id32<SDWTKKVDDYT<IDPQTAFRJWO>>, Id32<SDWTKKVDDYT<GKDKIYQIDND>>, Id32<SDWTKKVDDYT<IZXQRWKUWLU>>) BDRHRBSDOSV(this UnsafeList<byte> a, [Optional] int? b, [Optional] Id32<IZXQRWKUWLU>? c)
		{
			return default((Id32<SDWTKKVDDYT<IDPQTAFRJWO>>, Id32<SDWTKKVDDYT<GKDKIYQIDND>>, Id32<SDWTKKVDDYT<IZXQRWKUWLU>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x2868200", Offset = "0x2867600", VA = "0x182868200")]
		public static (Id32<SDWTKKVDDYT<IDPQTAFRJWO>>, Id32<SDWTKKVDDYT<GKDKIYQIDND>>, Id32<SDWTKKVDDYT<IMFYYDLBECV<IZXQRWKUWLU>>>) BHXWLNUAEXC(this UnsafeList<byte> a, [Optional] int? b, [Optional] Id32<IMFYYDLBECV<IZXQRWKUWLU>>? c)
		{
			return default((Id32<SDWTKKVDDYT<IDPQTAFRJWO>>, Id32<SDWTKKVDDYT<GKDKIYQIDND>>, Id32<SDWTKKVDDYT<IMFYYDLBECV<IZXQRWKUWLU>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x286B890", Offset = "0x286AC90", VA = "0x18286B890")]
		public static (Id32<SDWTKKVDDYT<IDPQTAFRJWO>>, Id32<SDWTKKVDDYT<GKDKIYQIDND>>, Id32<SDWTKKVDDYT<AKFVBWYPZLW>>) QHYRCYFYHCP(this UnsafeList<byte> a, [Optional] int? b, [Optional] Id32<AKFVBWYPZLW>? c)
		{
			return default((Id32<SDWTKKVDDYT<IDPQTAFRJWO>>, Id32<SDWTKKVDDYT<GKDKIYQIDND>>, Id32<SDWTKKVDDYT<AKFVBWYPZLW>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x286B620", Offset = "0x286AA20", VA = "0x18286B620")]
		public static (Id32<SDWTKKVDDYT<IDPQTAFRJWO>>, Id32<SDWTKKVDDYT<GKDKIYQIDND>>, Id32<SDWTKKVDDYT<IMFYYDLBECV<AKFVBWYPZLW>>>) QGNUWCWQTBE(this UnsafeList<byte> a, [Optional] int? b, [Optional] Id32<IMFYYDLBECV<AKFVBWYPZLW>>? c)
		{
			return default((Id32<SDWTKKVDDYT<IDPQTAFRJWO>>, Id32<SDWTKKVDDYT<GKDKIYQIDND>>, Id32<SDWTKKVDDYT<IMFYYDLBECV<AKFVBWYPZLW>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x3A55870", Offset = "0x3A54C70", VA = "0x183A55870")]
		public static (Id32<SDWTKKVDDYT<IDPQTAFRJWO>>, Id32<SDWTKKVDDYT<NTOQNIRTTPF>>, Id32<SDWTKKVDDYT<GKDKIYQIDND>>, Id32<SDWTKKVDDYT<a>>) DALGHHKHOCE<a>(this UnsafeList<byte> a, [Optional] Id32<NTOQNIRTTPF>? b, [Optional][In] ReadOnlySpan<byte> data)
		{
			return default((Id32<SDWTKKVDDYT<IDPQTAFRJWO>>, Id32<SDWTKKVDDYT<NTOQNIRTTPF>>, Id32<SDWTKKVDDYT<GKDKIYQIDND>>, Id32<SDWTKKVDDYT<a>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x286C440", Offset = "0x286B840", VA = "0x18286C440")]
		public static (Id32<SDWTKKVDDYT<IDPQTAFRJWO>>, Id32<SDWTKKVDDYT<GKDKIYQIDND>>, Id32<SDWTKKVDDYT<IMFYYDLBECV<GKDKIYQIDND>>>) VPVMDUDGSJA(this UnsafeList<byte> a, int b, [Optional] Id32<IMFYYDLBECV<GKDKIYQIDND>>? c)
		{
			return default((Id32<SDWTKKVDDYT<IDPQTAFRJWO>>, Id32<SDWTKKVDDYT<GKDKIYQIDND>>, Id32<SDWTKKVDDYT<IMFYYDLBECV<GKDKIYQIDND>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x2868F10", Offset = "0x2868310", VA = "0x182868F10")]
		public static (Id32<SDWTKKVDDYT<IDPQTAFRJWO>>, Id32<SDWTKKVDDYT<IMFYYDLBECV<GKDKIYQIDND>>>, Id32<SDWTKKVDDYT<IMFYYDLBECV<GKDKIYQIDND>>>) DYNHFCPITJH(this UnsafeList<byte> a, [Optional] Id32<IMFYYDLBECV<GKDKIYQIDND>>? b, [Optional] Id32<IMFYYDLBECV<GKDKIYQIDND>>? c)
		{
			return default((Id32<SDWTKKVDDYT<IDPQTAFRJWO>>, Id32<SDWTKKVDDYT<IMFYYDLBECV<GKDKIYQIDND>>>, Id32<SDWTKKVDDYT<IMFYYDLBECV<GKDKIYQIDND>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x3A55460", Offset = "0x3A54860", VA = "0x183A55460")]
		public static (Id32<SDWTKKVDDYT<IDPQTAFRJWO>>, Id32<SDWTKKVDDYT<IMFYYDLBECV<b>>>, Id32<SDWTKKVDDYT<GKDKIYQIDND>>, Id32<SDWTKKVDDYT<b>>) AIBJLWBTDBY<b>(this UnsafeList<byte> a, [Optional] Id32<IMFYYDLBECV<b>>? b, [Optional] int? c, [Optional][In] ReadOnlySpan<byte> from)
		{
			return default((Id32<SDWTKKVDDYT<IDPQTAFRJWO>>, Id32<SDWTKKVDDYT<IMFYYDLBECV<b>>>, Id32<SDWTKKVDDYT<GKDKIYQIDND>>, Id32<SDWTKKVDDYT<b>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x3A55BB0", Offset = "0x3A54FB0", VA = "0x183A55BB0")]
		public static (Id32<SDWTKKVDDYT<IDPQTAFRJWO>>, Id32<SDWTKKVDDYT<IMFYYDLBECV<c>>>, Id32<SDWTKKVDDYT<IMFYYDLBECV<c>>>, Id32<SDWTKKVDDYT<GKDKIYQIDND>>) GGWLALQFPSN<c>(this UnsafeList<byte> a, [Optional] Id32<IMFYYDLBECV<c>>? b, [Optional] Id32<IMFYYDLBECV<c>>? c, [Optional] int? d)
		{
			return default((Id32<SDWTKKVDDYT<IDPQTAFRJWO>>, Id32<SDWTKKVDDYT<IMFYYDLBECV<c>>>, Id32<SDWTKKVDDYT<IMFYYDLBECV<c>>>, Id32<SDWTKKVDDYT<GKDKIYQIDND>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x286CA80", Offset = "0x286BE80", VA = "0x18286CA80")]
		public static (Id32<SDWTKKVDDYT<IDPQTAFRJWO>>, Id32<SDWTKKVDDYT<ZZWGXXGPIDC>>, Id32<SDWTKKVDDYT<ZZWGXXGPIDC>>, Id32<SDWTKKVDDYT<IMFYYDLBECV<ZZWGXXGPIDC>>>) WGIZNXGZYDY(this UnsafeList<byte> a, float b, float c, [Optional] Id32<IMFYYDLBECV<ZZWGXXGPIDC>>? d)
		{
			return default((Id32<SDWTKKVDDYT<IDPQTAFRJWO>>, Id32<SDWTKKVDDYT<ZZWGXXGPIDC>>, Id32<SDWTKKVDDYT<ZZWGXXGPIDC>>, Id32<SDWTKKVDDYT<IMFYYDLBECV<ZZWGXXGPIDC>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x286AA80", Offset = "0x2869E80", VA = "0x18286AA80")]
		public static (Id32<SDWTKKVDDYT<IDPQTAFRJWO>>, Id32<SDWTKKVDDYT<ZZWGXXGPIDC>>, Id32<SDWTKKVDDYT<IMFYYDLBECV<ZZWGXXGPIDC>>>, Id32<SDWTKKVDDYT<IMFYYDLBECV<ZZWGXXGPIDC>>>) NIAGKOWIWBH(this UnsafeList<byte> a, float b, [Optional] Id32<IMFYYDLBECV<ZZWGXXGPIDC>>? c, [Optional] Id32<IMFYYDLBECV<ZZWGXXGPIDC>>? d)
		{
			return default((Id32<SDWTKKVDDYT<IDPQTAFRJWO>>, Id32<SDWTKKVDDYT<ZZWGXXGPIDC>>, Id32<SDWTKKVDDYT<IMFYYDLBECV<ZZWGXXGPIDC>>>, Id32<SDWTKKVDDYT<IMFYYDLBECV<ZZWGXXGPIDC>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x286A3D0", Offset = "0x28697D0", VA = "0x18286A3D0")]
		public static (Id32<SDWTKKVDDYT<IDPQTAFRJWO>>, Id32<SDWTKKVDDYT<IMFYYDLBECV<ZZWGXXGPIDC>>>, Id32<SDWTKKVDDYT<IMFYYDLBECV<ZZWGXXGPIDC>>>, Id32<SDWTKKVDDYT<IMFYYDLBECV<ZZWGXXGPIDC>>>) KVNGYHNXDOM(this UnsafeList<byte> a, [Optional] Id32<IMFYYDLBECV<ZZWGXXGPIDC>>? b, [Optional] Id32<IMFYYDLBECV<ZZWGXXGPIDC>>? c, [Optional] Id32<IMFYYDLBECV<ZZWGXXGPIDC>>? d)
		{
			return default((Id32<SDWTKKVDDYT<IDPQTAFRJWO>>, Id32<SDWTKKVDDYT<IMFYYDLBECV<ZZWGXXGPIDC>>>, Id32<SDWTKKVDDYT<IMFYYDLBECV<ZZWGXXGPIDC>>>, Id32<SDWTKKVDDYT<IMFYYDLBECV<ZZWGXXGPIDC>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x286AF40", Offset = "0x286A340", VA = "0x18286AF40")]
		public static (Id32<SDWTKKVDDYT<IDPQTAFRJWO>>, Id32<SDWTKKVDDYT<GKDKIYQIDND>>, Id32<SDWTKKVDDYT<GKDKIYQIDND>>, Id32<SDWTKKVDDYT<IMFYYDLBECV<GKDKIYQIDND>>>) PAKFHSRJREI(this UnsafeList<byte> a, int b, int c, [Optional] Id32<IMFYYDLBECV<GKDKIYQIDND>>? d)
		{
			return default((Id32<SDWTKKVDDYT<IDPQTAFRJWO>>, Id32<SDWTKKVDDYT<GKDKIYQIDND>>, Id32<SDWTKKVDDYT<GKDKIYQIDND>>, Id32<SDWTKKVDDYT<IMFYYDLBECV<GKDKIYQIDND>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x286BE00", Offset = "0x286B200", VA = "0x18286BE00")]
		public static (Id32<SDWTKKVDDYT<IDPQTAFRJWO>>, Id32<SDWTKKVDDYT<GKDKIYQIDND>>, Id32<SDWTKKVDDYT<IMFYYDLBECV<GKDKIYQIDND>>>, Id32<SDWTKKVDDYT<IMFYYDLBECV<GKDKIYQIDND>>>) SAMVNBIMDZV(this UnsafeList<byte> a, int b, [Optional] Id32<IMFYYDLBECV<GKDKIYQIDND>>? c, [Optional] Id32<IMFYYDLBECV<GKDKIYQIDND>>? d)
		{
			return default((Id32<SDWTKKVDDYT<IDPQTAFRJWO>>, Id32<SDWTKKVDDYT<GKDKIYQIDND>>, Id32<SDWTKKVDDYT<IMFYYDLBECV<GKDKIYQIDND>>>, Id32<SDWTKKVDDYT<IMFYYDLBECV<GKDKIYQIDND>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x286A4F0", Offset = "0x28698F0", VA = "0x18286A4F0")]
		public static (Id32<SDWTKKVDDYT<IDPQTAFRJWO>>, Id32<SDWTKKVDDYT<IMFYYDLBECV<GKDKIYQIDND>>>, Id32<SDWTKKVDDYT<IMFYYDLBECV<GKDKIYQIDND>>>, Id32<SDWTKKVDDYT<IMFYYDLBECV<GKDKIYQIDND>>>) LFZCRXEUYUW(this UnsafeList<byte> a, [Optional] Id32<IMFYYDLBECV<GKDKIYQIDND>>? b, [Optional] Id32<IMFYYDLBECV<GKDKIYQIDND>>? c, [Optional] Id32<IMFYYDLBECV<GKDKIYQIDND>>? d)
		{
			return default((Id32<SDWTKKVDDYT<IDPQTAFRJWO>>, Id32<SDWTKKVDDYT<IMFYYDLBECV<GKDKIYQIDND>>>, Id32<SDWTKKVDDYT<IMFYYDLBECV<GKDKIYQIDND>>>, Id32<SDWTKKVDDYT<IMFYYDLBECV<GKDKIYQIDND>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x2869FD0", Offset = "0x28693D0", VA = "0x182869FD0")]
		public static (Id32<SDWTKKVDDYT<IDPQTAFRJWO>>, Id32<SDWTKKVDDYT<GKDKIYQIDND>>, Id32<SDWTKKVDDYT<GKDKIYQIDND>>, Id32<SDWTKKVDDYT<IMFYYDLBECV<GKDKIYQIDND>>>) JRSQUSZXFNX(this UnsafeList<byte> a, int b, int c, [Optional] Id32<IMFYYDLBECV<GKDKIYQIDND>>? d)
		{
			return default((Id32<SDWTKKVDDYT<IDPQTAFRJWO>>, Id32<SDWTKKVDDYT<GKDKIYQIDND>>, Id32<SDWTKKVDDYT<GKDKIYQIDND>>, Id32<SDWTKKVDDYT<IMFYYDLBECV<GKDKIYQIDND>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x286CD60", Offset = "0x286C160", VA = "0x18286CD60")]
		public static (Id32<SDWTKKVDDYT<IDPQTAFRJWO>>, Id32<SDWTKKVDDYT<GKDKIYQIDND>>, Id32<SDWTKKVDDYT<IMFYYDLBECV<GKDKIYQIDND>>>, Id32<SDWTKKVDDYT<IMFYYDLBECV<GKDKIYQIDND>>>) XCOKHNCARKS(this UnsafeList<byte> a, int b, [Optional] Id32<IMFYYDLBECV<GKDKIYQIDND>>? c, [Optional] Id32<IMFYYDLBECV<GKDKIYQIDND>>? d)
		{
			return default((Id32<SDWTKKVDDYT<IDPQTAFRJWO>>, Id32<SDWTKKVDDYT<GKDKIYQIDND>>, Id32<SDWTKKVDDYT<IMFYYDLBECV<GKDKIYQIDND>>>, Id32<SDWTKKVDDYT<IMFYYDLBECV<GKDKIYQIDND>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x2867F30", Offset = "0x2867330", VA = "0x182867F30")]
		public static (Id32<SDWTKKVDDYT<IDPQTAFRJWO>>, Id32<SDWTKKVDDYT<IMFYYDLBECV<GKDKIYQIDND>>>, Id32<SDWTKKVDDYT<IMFYYDLBECV<GKDKIYQIDND>>>, Id32<SDWTKKVDDYT<IMFYYDLBECV<GKDKIYQIDND>>>) ATXBFEIZRHV(this UnsafeList<byte> a, [Optional] Id32<IMFYYDLBECV<GKDKIYQIDND>>? b, [Optional] Id32<IMFYYDLBECV<GKDKIYQIDND>>? c, [Optional] Id32<IMFYYDLBECV<GKDKIYQIDND>>? d)
		{
			return default((Id32<SDWTKKVDDYT<IDPQTAFRJWO>>, Id32<SDWTKKVDDYT<IMFYYDLBECV<GKDKIYQIDND>>>, Id32<SDWTKKVDDYT<IMFYYDLBECV<GKDKIYQIDND>>>, Id32<SDWTKKVDDYT<IMFYYDLBECV<GKDKIYQIDND>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x2868950", Offset = "0x2867D50", VA = "0x182868950")]
		public static (Id32<SDWTKKVDDYT<IDPQTAFRJWO>>, Id32<SDWTKKVDDYT<SDWTKKVDDYT<IDPQTAFRJWO>>>) CGLFZIHJKOK(this UnsafeList<byte> a, [Optional] Id32<SDWTKKVDDYT<IDPQTAFRJWO>>? b)
		{
			return default((Id32<SDWTKKVDDYT<IDPQTAFRJWO>>, Id32<SDWTKKVDDYT<SDWTKKVDDYT<IDPQTAFRJWO>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x286A730", Offset = "0x2869B30", VA = "0x18286A730")]
		public static (Id32<SDWTKKVDDYT<IDPQTAFRJWO>>, Id32<SDWTKKVDDYT<ZZWGXXGPIDC>>, Id32<SDWTKKVDDYT<ZZWGXXGPIDC>>, Id32<SDWTKKVDDYT<IMFYYDLBECV<GKDKIYQIDND>>>) LQXDWYUSNVY(this UnsafeList<byte> a, float b, float c, [Optional] Id32<IMFYYDLBECV<GKDKIYQIDND>>? d)
		{
			return default((Id32<SDWTKKVDDYT<IDPQTAFRJWO>>, Id32<SDWTKKVDDYT<ZZWGXXGPIDC>>, Id32<SDWTKKVDDYT<ZZWGXXGPIDC>>, Id32<SDWTKKVDDYT<IMFYYDLBECV<GKDKIYQIDND>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x2869420", Offset = "0x2868820", VA = "0x182869420")]
		public static (Id32<SDWTKKVDDYT<IDPQTAFRJWO>>, Id32<SDWTKKVDDYT<ZZWGXXGPIDC>>, Id32<SDWTKKVDDYT<IMFYYDLBECV<ZZWGXXGPIDC>>>, Id32<SDWTKKVDDYT<IMFYYDLBECV<GKDKIYQIDND>>>) GANEXWISDBT(this UnsafeList<byte> a, float b, [Optional] Id32<IMFYYDLBECV<ZZWGXXGPIDC>>? c, [Optional] Id32<IMFYYDLBECV<GKDKIYQIDND>>? d)
		{
			return default((Id32<SDWTKKVDDYT<IDPQTAFRJWO>>, Id32<SDWTKKVDDYT<ZZWGXXGPIDC>>, Id32<SDWTKKVDDYT<IMFYYDLBECV<ZZWGXXGPIDC>>>, Id32<SDWTKKVDDYT<IMFYYDLBECV<GKDKIYQIDND>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x286C570", Offset = "0x286B970", VA = "0x18286C570")]
		public static (Id32<SDWTKKVDDYT<IDPQTAFRJWO>>, Id32<SDWTKKVDDYT<IMFYYDLBECV<ZZWGXXGPIDC>>>, Id32<SDWTKKVDDYT<IMFYYDLBECV<ZZWGXXGPIDC>>>, Id32<SDWTKKVDDYT<IMFYYDLBECV<GKDKIYQIDND>>>) VRSXTDOHPGQ(this UnsafeList<byte> a, [Optional] Id32<IMFYYDLBECV<ZZWGXXGPIDC>>? b, [Optional] Id32<IMFYYDLBECV<ZZWGXXGPIDC>>? c, [Optional] Id32<IMFYYDLBECV<GKDKIYQIDND>>? d)
		{
			return default((Id32<SDWTKKVDDYT<IDPQTAFRJWO>>, Id32<SDWTKKVDDYT<IMFYYDLBECV<ZZWGXXGPIDC>>>, Id32<SDWTKKVDDYT<IMFYYDLBECV<ZZWGXXGPIDC>>>, Id32<SDWTKKVDDYT<IMFYYDLBECV<GKDKIYQIDND>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x28696E0", Offset = "0x2868AE0", VA = "0x1828696E0")]
		public static (Id32<SDWTKKVDDYT<IDPQTAFRJWO>>, Id32<SDWTKKVDDYT<GKDKIYQIDND>>, Id32<SDWTKKVDDYT<GKDKIYQIDND>>, Id32<SDWTKKVDDYT<IMFYYDLBECV<GKDKIYQIDND>>>) GOWGOZBAPOP(this UnsafeList<byte> a, int b, int c, [Optional] Id32<IMFYYDLBECV<GKDKIYQIDND>>? d)
		{
			return default((Id32<SDWTKKVDDYT<IDPQTAFRJWO>>, Id32<SDWTKKVDDYT<GKDKIYQIDND>>, Id32<SDWTKKVDDYT<GKDKIYQIDND>>, Id32<SDWTKKVDDYT<IMFYYDLBECV<GKDKIYQIDND>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x286C2F0", Offset = "0x286B6F0", VA = "0x18286C2F0")]
		public static (Id32<SDWTKKVDDYT<IDPQTAFRJWO>>, Id32<SDWTKKVDDYT<GKDKIYQIDND>>, Id32<SDWTKKVDDYT<IMFYYDLBECV<GKDKIYQIDND>>>, Id32<SDWTKKVDDYT<IMFYYDLBECV<GKDKIYQIDND>>>) UUNSSFSUGZG(this UnsafeList<byte> a, int b, [Optional] Id32<IMFYYDLBECV<GKDKIYQIDND>>? c, [Optional] Id32<IMFYYDLBECV<GKDKIYQIDND>>? d)
		{
			return default((Id32<SDWTKKVDDYT<IDPQTAFRJWO>>, Id32<SDWTKKVDDYT<GKDKIYQIDND>>, Id32<SDWTKKVDDYT<IMFYYDLBECV<GKDKIYQIDND>>>, Id32<SDWTKKVDDYT<IMFYYDLBECV<GKDKIYQIDND>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x2868CD0", Offset = "0x28680D0", VA = "0x182868CD0")]
		public static (Id32<SDWTKKVDDYT<IDPQTAFRJWO>>, Id32<SDWTKKVDDYT<IMFYYDLBECV<GKDKIYQIDND>>>, Id32<SDWTKKVDDYT<IMFYYDLBECV<GKDKIYQIDND>>>, Id32<SDWTKKVDDYT<IMFYYDLBECV<GKDKIYQIDND>>>) DOOODCLARGR(this UnsafeList<byte> a, [Optional] Id32<IMFYYDLBECV<GKDKIYQIDND>>? b, [Optional] Id32<IMFYYDLBECV<GKDKIYQIDND>>? c, [Optional] Id32<IMFYYDLBECV<GKDKIYQIDND>>? d)
		{
			return default((Id32<SDWTKKVDDYT<IDPQTAFRJWO>>, Id32<SDWTKKVDDYT<IMFYYDLBECV<GKDKIYQIDND>>>, Id32<SDWTKKVDDYT<IMFYYDLBECV<GKDKIYQIDND>>>, Id32<SDWTKKVDDYT<IMFYYDLBECV<GKDKIYQIDND>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x2868B50", Offset = "0x2867F50", VA = "0x182868B50")]
		public static (Id32<SDWTKKVDDYT<IDPQTAFRJWO>>, Id32<SDWTKKVDDYT<ZZWGXXGPIDC>>, Id32<SDWTKKVDDYT<ZZWGXXGPIDC>>, Id32<SDWTKKVDDYT<IMFYYDLBECV<GKDKIYQIDND>>>) DCIACXWBKSN(this UnsafeList<byte> a, float b, float c, [Optional] Id32<IMFYYDLBECV<GKDKIYQIDND>>? d)
		{
			return default((Id32<SDWTKKVDDYT<IDPQTAFRJWO>>, Id32<SDWTKKVDDYT<ZZWGXXGPIDC>>, Id32<SDWTKKVDDYT<ZZWGXXGPIDC>>, Id32<SDWTKKVDDYT<IMFYYDLBECV<GKDKIYQIDND>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x2869580", Offset = "0x2868980", VA = "0x182869580")]
		public static (Id32<SDWTKKVDDYT<IDPQTAFRJWO>>, Id32<SDWTKKVDDYT<ZZWGXXGPIDC>>, Id32<SDWTKKVDDYT<IMFYYDLBECV<ZZWGXXGPIDC>>>, Id32<SDWTKKVDDYT<IMFYYDLBECV<GKDKIYQIDND>>>) GGDVUXGDHFA(this UnsafeList<byte> a, float b, [Optional] Id32<IMFYYDLBECV<ZZWGXXGPIDC>>? c, [Optional] Id32<IMFYYDLBECV<GKDKIYQIDND>>? d)
		{
			return default((Id32<SDWTKKVDDYT<IDPQTAFRJWO>>, Id32<SDWTKKVDDYT<ZZWGXXGPIDC>>, Id32<SDWTKKVDDYT<IMFYYDLBECV<ZZWGXXGPIDC>>>, Id32<SDWTKKVDDYT<IMFYYDLBECV<GKDKIYQIDND>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x286BF50", Offset = "0x286B350", VA = "0x18286BF50")]
		public static (Id32<SDWTKKVDDYT<IDPQTAFRJWO>>, Id32<SDWTKKVDDYT<IMFYYDLBECV<ZZWGXXGPIDC>>>, Id32<SDWTKKVDDYT<IMFYYDLBECV<ZZWGXXGPIDC>>>, Id32<SDWTKKVDDYT<IMFYYDLBECV<GKDKIYQIDND>>>) SWRWYWKEYHN(this UnsafeList<byte> a, [Optional] Id32<IMFYYDLBECV<ZZWGXXGPIDC>>? b, [Optional] Id32<IMFYYDLBECV<ZZWGXXGPIDC>>? c, [Optional] Id32<IMFYYDLBECV<GKDKIYQIDND>>? d)
		{
			return default((Id32<SDWTKKVDDYT<IDPQTAFRJWO>>, Id32<SDWTKKVDDYT<IMFYYDLBECV<ZZWGXXGPIDC>>>, Id32<SDWTKKVDDYT<IMFYYDLBECV<ZZWGXXGPIDC>>>, Id32<SDWTKKVDDYT<IMFYYDLBECV<GKDKIYQIDND>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x2869C30", Offset = "0x2869030", VA = "0x182869C30")]
		public static (Id32<SDWTKKVDDYT<IDPQTAFRJWO>>, Id32<SDWTKKVDDYT<GKDKIYQIDND>>, Id32<SDWTKKVDDYT<GKDKIYQIDND>>, Id32<SDWTKKVDDYT<IMFYYDLBECV<GKDKIYQIDND>>>) HNROQGOMSXG(this UnsafeList<byte> a, int b, int c, [Optional] Id32<IMFYYDLBECV<GKDKIYQIDND>>? d)
		{
			return default((Id32<SDWTKKVDDYT<IDPQTAFRJWO>>, Id32<SDWTKKVDDYT<GKDKIYQIDND>>, Id32<SDWTKKVDDYT<GKDKIYQIDND>>, Id32<SDWTKKVDDYT<IMFYYDLBECV<GKDKIYQIDND>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x2869170", Offset = "0x2868570", VA = "0x182869170")]
		public static (Id32<SDWTKKVDDYT<IDPQTAFRJWO>>, Id32<SDWTKKVDDYT<GKDKIYQIDND>>, Id32<SDWTKKVDDYT<IMFYYDLBECV<GKDKIYQIDND>>>, Id32<SDWTKKVDDYT<IMFYYDLBECV<GKDKIYQIDND>>>) FCNJXBNOGCH(this UnsafeList<byte> a, int b, [Optional] Id32<IMFYYDLBECV<GKDKIYQIDND>>? c, [Optional] Id32<IMFYYDLBECV<GKDKIYQIDND>>? d)
		{
			return default((Id32<SDWTKKVDDYT<IDPQTAFRJWO>>, Id32<SDWTKKVDDYT<GKDKIYQIDND>>, Id32<SDWTKKVDDYT<IMFYYDLBECV<GKDKIYQIDND>>>, Id32<SDWTKKVDDYT<IMFYYDLBECV<GKDKIYQIDND>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x286AE20", Offset = "0x286A220", VA = "0x18286AE20")]
		public static (Id32<SDWTKKVDDYT<IDPQTAFRJWO>>, Id32<SDWTKKVDDYT<IMFYYDLBECV<GKDKIYQIDND>>>, Id32<SDWTKKVDDYT<IMFYYDLBECV<GKDKIYQIDND>>>, Id32<SDWTKKVDDYT<IMFYYDLBECV<GKDKIYQIDND>>>) OPZBHFGWZOW(this UnsafeList<byte> a, [Optional] Id32<IMFYYDLBECV<GKDKIYQIDND>>? b, [Optional] Id32<IMFYYDLBECV<GKDKIYQIDND>>? c, [Optional] Id32<IMFYYDLBECV<GKDKIYQIDND>>? d)
		{
			return default((Id32<SDWTKKVDDYT<IDPQTAFRJWO>>, Id32<SDWTKKVDDYT<IMFYYDLBECV<GKDKIYQIDND>>>, Id32<SDWTKKVDDYT<IMFYYDLBECV<GKDKIYQIDND>>>, Id32<SDWTKKVDDYT<IMFYYDLBECV<GKDKIYQIDND>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x2869840", Offset = "0x2868C40", VA = "0x182869840")]
		public static (Id32<SDWTKKVDDYT<IDPQTAFRJWO>>, Id32<SDWTKKVDDYT<ZZWGXXGPIDC>>, Id32<SDWTKKVDDYT<ZZWGXXGPIDC>>, Id32<SDWTKKVDDYT<IMFYYDLBECV<GKDKIYQIDND>>>) GTBSPUDZZCV(this UnsafeList<byte> a, float b, float c, [Optional] Id32<IMFYYDLBECV<GKDKIYQIDND>>? d)
		{
			return default((Id32<SDWTKKVDDYT<IDPQTAFRJWO>>, Id32<SDWTKKVDDYT<ZZWGXXGPIDC>>, Id32<SDWTKKVDDYT<ZZWGXXGPIDC>>, Id32<SDWTKKVDDYT<IMFYYDLBECV<GKDKIYQIDND>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x286B730", Offset = "0x286AB30", VA = "0x18286B730")]
		public static (Id32<SDWTKKVDDYT<IDPQTAFRJWO>>, Id32<SDWTKKVDDYT<ZZWGXXGPIDC>>, Id32<SDWTKKVDDYT<IMFYYDLBECV<ZZWGXXGPIDC>>>, Id32<SDWTKKVDDYT<IMFYYDLBECV<GKDKIYQIDND>>>) QGSHTDWCRIW(this UnsafeList<byte> a, float b, [Optional] Id32<IMFYYDLBECV<ZZWGXXGPIDC>>? c, [Optional] Id32<IMFYYDLBECV<GKDKIYQIDND>>? d)
		{
			return default((Id32<SDWTKKVDDYT<IDPQTAFRJWO>>, Id32<SDWTKKVDDYT<ZZWGXXGPIDC>>, Id32<SDWTKKVDDYT<IMFYYDLBECV<ZZWGXXGPIDC>>>, Id32<SDWTKKVDDYT<IMFYYDLBECV<GKDKIYQIDND>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x28686C0", Offset = "0x2867AC0", VA = "0x1828686C0")]
		public static (Id32<SDWTKKVDDYT<IDPQTAFRJWO>>, Id32<SDWTKKVDDYT<IMFYYDLBECV<ZZWGXXGPIDC>>>, Id32<SDWTKKVDDYT<IMFYYDLBECV<ZZWGXXGPIDC>>>, Id32<SDWTKKVDDYT<IMFYYDLBECV<GKDKIYQIDND>>>) BNUYAGVPZRR(this UnsafeList<byte> a, [Optional] Id32<IMFYYDLBECV<ZZWGXXGPIDC>>? b, [Optional] Id32<IMFYYDLBECV<ZZWGXXGPIDC>>? c, [Optional] Id32<IMFYYDLBECV<GKDKIYQIDND>>? d)
		{
			return default((Id32<SDWTKKVDDYT<IDPQTAFRJWO>>, Id32<SDWTKKVDDYT<IMFYYDLBECV<ZZWGXXGPIDC>>>, Id32<SDWTKKVDDYT<IMFYYDLBECV<ZZWGXXGPIDC>>>, Id32<SDWTKKVDDYT<IMFYYDLBECV<GKDKIYQIDND>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x286B4C0", Offset = "0x286A8C0", VA = "0x18286B4C0")]
		public static (Id32<SDWTKKVDDYT<IDPQTAFRJWO>>, Id32<SDWTKKVDDYT<GKDKIYQIDND>>, Id32<SDWTKKVDDYT<GKDKIYQIDND>>, Id32<SDWTKKVDDYT<IMFYYDLBECV<GKDKIYQIDND>>>) QBPHUDZBDBS(this UnsafeList<byte> a, int b, int c, [Optional] Id32<IMFYYDLBECV<GKDKIYQIDND>>? d)
		{
			return default((Id32<SDWTKKVDDYT<IDPQTAFRJWO>>, Id32<SDWTKKVDDYT<GKDKIYQIDND>>, Id32<SDWTKKVDDYT<GKDKIYQIDND>>, Id32<SDWTKKVDDYT<IMFYYDLBECV<GKDKIYQIDND>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x286BCB0", Offset = "0x286B0B0", VA = "0x18286BCB0")]
		public static (Id32<SDWTKKVDDYT<IDPQTAFRJWO>>, Id32<SDWTKKVDDYT<GKDKIYQIDND>>, Id32<SDWTKKVDDYT<IMFYYDLBECV<GKDKIYQIDND>>>, Id32<SDWTKKVDDYT<IMFYYDLBECV<GKDKIYQIDND>>>) RDBZNPHLUFF(this UnsafeList<byte> a, int b, [Optional] Id32<IMFYYDLBECV<GKDKIYQIDND>>? c, [Optional] Id32<IMFYYDLBECV<GKDKIYQIDND>>? d)
		{
			return default((Id32<SDWTKKVDDYT<IDPQTAFRJWO>>, Id32<SDWTKKVDDYT<GKDKIYQIDND>>, Id32<SDWTKKVDDYT<IMFYYDLBECV<GKDKIYQIDND>>>, Id32<SDWTKKVDDYT<IMFYYDLBECV<GKDKIYQIDND>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x286D7B0", Offset = "0x286CBB0", VA = "0x18286D7B0")]
		public static (Id32<SDWTKKVDDYT<IDPQTAFRJWO>>, Id32<SDWTKKVDDYT<IMFYYDLBECV<GKDKIYQIDND>>>, Id32<SDWTKKVDDYT<IMFYYDLBECV<GKDKIYQIDND>>>, Id32<SDWTKKVDDYT<IMFYYDLBECV<GKDKIYQIDND>>>) ZYCFWZEIHXA(this UnsafeList<byte> a, [Optional] Id32<IMFYYDLBECV<GKDKIYQIDND>>? b, [Optional] Id32<IMFYYDLBECV<GKDKIYQIDND>>? c, [Optional] Id32<IMFYYDLBECV<GKDKIYQIDND>>? d)
		{
			return default((Id32<SDWTKKVDDYT<IDPQTAFRJWO>>, Id32<SDWTKKVDDYT<IMFYYDLBECV<GKDKIYQIDND>>>, Id32<SDWTKKVDDYT<IMFYYDLBECV<GKDKIYQIDND>>>, Id32<SDWTKKVDDYT<IMFYYDLBECV<GKDKIYQIDND>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x286B0A0", Offset = "0x286A4A0", VA = "0x18286B0A0")]
		public static (Id32<SDWTKKVDDYT<IDPQTAFRJWO>>, Id32<SDWTKKVDDYT<ZZWGXXGPIDC>>, Id32<SDWTKKVDDYT<ZZWGXXGPIDC>>, Id32<SDWTKKVDDYT<IMFYYDLBECV<GKDKIYQIDND>>>) PIFJKRDOXAU(this UnsafeList<byte> a, float b, float c, [Optional] Id32<IMFYYDLBECV<GKDKIYQIDND>>? d)
		{
			return default((Id32<SDWTKKVDDYT<IDPQTAFRJWO>>, Id32<SDWTKKVDDYT<ZZWGXXGPIDC>>, Id32<SDWTKKVDDYT<ZZWGXXGPIDC>>, Id32<SDWTKKVDDYT<IMFYYDLBECV<GKDKIYQIDND>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x286C920", Offset = "0x286BD20", VA = "0x18286C920")]
		public static (Id32<SDWTKKVDDYT<IDPQTAFRJWO>>, Id32<SDWTKKVDDYT<ZZWGXXGPIDC>>, Id32<SDWTKKVDDYT<IMFYYDLBECV<ZZWGXXGPIDC>>>, Id32<SDWTKKVDDYT<IMFYYDLBECV<GKDKIYQIDND>>>) WFCDOPQUJOP(this UnsafeList<byte> a, float b, [Optional] Id32<IMFYYDLBECV<ZZWGXXGPIDC>>? c, [Optional] Id32<IMFYYDLBECV<GKDKIYQIDND>>? d)
		{
			return default((Id32<SDWTKKVDDYT<IDPQTAFRJWO>>, Id32<SDWTKKVDDYT<ZZWGXXGPIDC>>, Id32<SDWTKKVDDYT<IMFYYDLBECV<ZZWGXXGPIDC>>>, Id32<SDWTKKVDDYT<IMFYYDLBECV<GKDKIYQIDND>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x286ACF0", Offset = "0x286A0F0", VA = "0x18286ACF0")]
		public static (Id32<SDWTKKVDDYT<IDPQTAFRJWO>>, Id32<SDWTKKVDDYT<IMFYYDLBECV<ZZWGXXGPIDC>>>, Id32<SDWTKKVDDYT<IMFYYDLBECV<ZZWGXXGPIDC>>>, Id32<SDWTKKVDDYT<IMFYYDLBECV<GKDKIYQIDND>>>) OEWGYLUGJCK(this UnsafeList<byte> a, [Optional] Id32<IMFYYDLBECV<ZZWGXXGPIDC>>? b, [Optional] Id32<IMFYYDLBECV<ZZWGXXGPIDC>>? c, [Optional] Id32<IMFYYDLBECV<GKDKIYQIDND>>? d)
		{
			return default((Id32<SDWTKKVDDYT<IDPQTAFRJWO>>, Id32<SDWTKKVDDYT<IMFYYDLBECV<ZZWGXXGPIDC>>>, Id32<SDWTKKVDDYT<IMFYYDLBECV<ZZWGXXGPIDC>>>, Id32<SDWTKKVDDYT<IMFYYDLBECV<GKDKIYQIDND>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x286C6A0", Offset = "0x286BAA0", VA = "0x18286C6A0")]
		public static (Id32<SDWTKKVDDYT<IDPQTAFRJWO>>, Id32<SDWTKKVDDYT<GKDKIYQIDND>>, Id32<SDWTKKVDDYT<GKDKIYQIDND>>, Id32<SDWTKKVDDYT<IMFYYDLBECV<GKDKIYQIDND>>>) WCJBKXFWPDT(this UnsafeList<byte> a, int b, int c, [Optional] Id32<IMFYYDLBECV<GKDKIYQIDND>>? d)
		{
			return default((Id32<SDWTKKVDDYT<IDPQTAFRJWO>>, Id32<SDWTKKVDDYT<GKDKIYQIDND>>, Id32<SDWTKKVDDYT<GKDKIYQIDND>>, Id32<SDWTKKVDDYT<IMFYYDLBECV<GKDKIYQIDND>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x286B220", Offset = "0x286A620", VA = "0x18286B220")]
		public static (Id32<SDWTKKVDDYT<IDPQTAFRJWO>>, Id32<SDWTKKVDDYT<GKDKIYQIDND>>, Id32<SDWTKKVDDYT<IMFYYDLBECV<GKDKIYQIDND>>>, Id32<SDWTKKVDDYT<IMFYYDLBECV<GKDKIYQIDND>>>) PKIWGDZDUFI(this UnsafeList<byte> a, int b, [Optional] Id32<IMFYYDLBECV<GKDKIYQIDND>>? c, [Optional] Id32<IMFYYDLBECV<GKDKIYQIDND>>? d)
		{
			return default((Id32<SDWTKKVDDYT<IDPQTAFRJWO>>, Id32<SDWTKKVDDYT<GKDKIYQIDND>>, Id32<SDWTKKVDDYT<IMFYYDLBECV<GKDKIYQIDND>>>, Id32<SDWTKKVDDYT<IMFYYDLBECV<GKDKIYQIDND>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x2869B10", Offset = "0x2868F10", VA = "0x182869B10")]
		public static (Id32<SDWTKKVDDYT<IDPQTAFRJWO>>, Id32<SDWTKKVDDYT<IMFYYDLBECV<GKDKIYQIDND>>>, Id32<SDWTKKVDDYT<IMFYYDLBECV<GKDKIYQIDND>>>, Id32<SDWTKKVDDYT<IMFYYDLBECV<GKDKIYQIDND>>>) HDHSOMMFZYT(this UnsafeList<byte> a, [Optional] Id32<IMFYYDLBECV<GKDKIYQIDND>>? b, [Optional] Id32<IMFYYDLBECV<GKDKIYQIDND>>? c, [Optional] Id32<IMFYYDLBECV<GKDKIYQIDND>>? d)
		{
			return default((Id32<SDWTKKVDDYT<IDPQTAFRJWO>>, Id32<SDWTKKVDDYT<IMFYYDLBECV<GKDKIYQIDND>>>, Id32<SDWTKKVDDYT<IMFYYDLBECV<GKDKIYQIDND>>>, Id32<SDWTKKVDDYT<IMFYYDLBECV<GKDKIYQIDND>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x286D400", Offset = "0x286C800", VA = "0x18286D400")]
		public static (Id32<SDWTKKVDDYT<IDPQTAFRJWO>>, Id32<SDWTKKVDDYT<ZZWGXXGPIDC>>, Id32<SDWTKKVDDYT<ZZWGXXGPIDC>>, Id32<SDWTKKVDDYT<IMFYYDLBECV<ZZWGXXGPIDC>>>) ZALUGYNVSQD(this UnsafeList<byte> a, float b, float c, [Optional] Id32<IMFYYDLBECV<ZZWGXXGPIDC>>? d)
		{
			return default((Id32<SDWTKKVDDYT<IDPQTAFRJWO>>, Id32<SDWTKKVDDYT<ZZWGXXGPIDC>>, Id32<SDWTKKVDDYT<ZZWGXXGPIDC>>, Id32<SDWTKKVDDYT<IMFYYDLBECV<ZZWGXXGPIDC>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x286CEB0", Offset = "0x286C2B0", VA = "0x18286CEB0")]
		public static (Id32<SDWTKKVDDYT<IDPQTAFRJWO>>, Id32<SDWTKKVDDYT<ZZWGXXGPIDC>>, Id32<SDWTKKVDDYT<IMFYYDLBECV<ZZWGXXGPIDC>>>, Id32<SDWTKKVDDYT<IMFYYDLBECV<ZZWGXXGPIDC>>>) XFZRYJAYEQE(this UnsafeList<byte> a, float b, [Optional] Id32<IMFYYDLBECV<ZZWGXXGPIDC>>? c, [Optional] Id32<IMFYYDLBECV<ZZWGXXGPIDC>>? d)
		{
			return default((Id32<SDWTKKVDDYT<IDPQTAFRJWO>>, Id32<SDWTKKVDDYT<ZZWGXXGPIDC>>, Id32<SDWTKKVDDYT<IMFYYDLBECV<ZZWGXXGPIDC>>>, Id32<SDWTKKVDDYT<IMFYYDLBECV<ZZWGXXGPIDC>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x286D000", Offset = "0x286C400", VA = "0x18286D000")]
		public static (Id32<SDWTKKVDDYT<IDPQTAFRJWO>>, Id32<SDWTKKVDDYT<IMFYYDLBECV<ZZWGXXGPIDC>>>, Id32<SDWTKKVDDYT<IMFYYDLBECV<ZZWGXXGPIDC>>>, Id32<SDWTKKVDDYT<IMFYYDLBECV<ZZWGXXGPIDC>>>) XMVHUPXSTLH(this UnsafeList<byte> a, [Optional] Id32<IMFYYDLBECV<ZZWGXXGPIDC>>? b, [Optional] Id32<IMFYYDLBECV<ZZWGXXGPIDC>>? c, [Optional] Id32<IMFYYDLBECV<ZZWGXXGPIDC>>? d)
		{
			return default((Id32<SDWTKKVDDYT<IDPQTAFRJWO>>, Id32<SDWTKKVDDYT<IMFYYDLBECV<ZZWGXXGPIDC>>>, Id32<SDWTKKVDDYT<IMFYYDLBECV<ZZWGXXGPIDC>>>, Id32<SDWTKKVDDYT<IMFYYDLBECV<ZZWGXXGPIDC>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x286D120", Offset = "0x286C520", VA = "0x18286D120")]
		public static (Id32<SDWTKKVDDYT<IDPQTAFRJWO>>, Id32<SDWTKKVDDYT<GKDKIYQIDND>>, Id32<SDWTKKVDDYT<GKDKIYQIDND>>, Id32<SDWTKKVDDYT<IMFYYDLBECV<GKDKIYQIDND>>>) XNXOSXJNLAF(this UnsafeList<byte> a, int b, int c, [Optional] Id32<IMFYYDLBECV<GKDKIYQIDND>>? d)
		{
			return default((Id32<SDWTKKVDDYT<IDPQTAFRJWO>>, Id32<SDWTKKVDDYT<GKDKIYQIDND>>, Id32<SDWTKKVDDYT<GKDKIYQIDND>>, Id32<SDWTKKVDDYT<IMFYYDLBECV<GKDKIYQIDND>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x2868310", Offset = "0x2867710", VA = "0x182868310")]
		public static (Id32<SDWTKKVDDYT<IDPQTAFRJWO>>, Id32<SDWTKKVDDYT<GKDKIYQIDND>>, Id32<SDWTKKVDDYT<IMFYYDLBECV<GKDKIYQIDND>>>, Id32<SDWTKKVDDYT<IMFYYDLBECV<GKDKIYQIDND>>>) BKWNOIMTLTM(this UnsafeList<byte> a, int b, [Optional] Id32<IMFYYDLBECV<GKDKIYQIDND>>? c, [Optional] Id32<IMFYYDLBECV<GKDKIYQIDND>>? d)
		{
			return default((Id32<SDWTKKVDDYT<IDPQTAFRJWO>>, Id32<SDWTKKVDDYT<GKDKIYQIDND>>, Id32<SDWTKKVDDYT<IMFYYDLBECV<GKDKIYQIDND>>>, Id32<SDWTKKVDDYT<IMFYYDLBECV<GKDKIYQIDND>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x2869D90", Offset = "0x2869190", VA = "0x182869D90")]
		public static (Id32<SDWTKKVDDYT<IDPQTAFRJWO>>, Id32<SDWTKKVDDYT<IMFYYDLBECV<GKDKIYQIDND>>>, Id32<SDWTKKVDDYT<IMFYYDLBECV<GKDKIYQIDND>>>, Id32<SDWTKKVDDYT<IMFYYDLBECV<GKDKIYQIDND>>>) IPIQDSFYQHF(this UnsafeList<byte> a, [Optional] Id32<IMFYYDLBECV<GKDKIYQIDND>>? b, [Optional] Id32<IMFYYDLBECV<GKDKIYQIDND>>? c, [Optional] Id32<IMFYYDLBECV<GKDKIYQIDND>>? d)
		{
			return default((Id32<SDWTKKVDDYT<IDPQTAFRJWO>>, Id32<SDWTKKVDDYT<IMFYYDLBECV<GKDKIYQIDND>>>, Id32<SDWTKKVDDYT<IMFYYDLBECV<GKDKIYQIDND>>>, Id32<SDWTKKVDDYT<IMFYYDLBECV<GKDKIYQIDND>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x286C080", Offset = "0x286B480", VA = "0x18286C080")]
		public static (Id32<SDWTKKVDDYT<IDPQTAFRJWO>>, Id32<SDWTKKVDDYT<GKDKIYQIDND>>, Id32<SDWTKKVDDYT<IMFYYDLBECV<GKDKIYQIDND>>>) TTQFJZSPYMC(this UnsafeList<byte> a, [Optional] int? b, [Optional] Id32<IMFYYDLBECV<GKDKIYQIDND>>? c)
		{
			return default((Id32<SDWTKKVDDYT<IDPQTAFRJWO>>, Id32<SDWTKKVDDYT<GKDKIYQIDND>>, Id32<SDWTKKVDDYT<IMFYYDLBECV<GKDKIYQIDND>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x2868A40", Offset = "0x2867E40", VA = "0x182868A40")]
		public static (Id32<SDWTKKVDDYT<IDPQTAFRJWO>>, Id32<SDWTKKVDDYT<IMFYYDLBECV<GKDKIYQIDND>>>, Id32<SDWTKKVDDYT<IMFYYDLBECV<GKDKIYQIDND>>>) CNEJXDTNQND(this UnsafeList<byte> a, [Optional] Id32<IMFYYDLBECV<GKDKIYQIDND>>? b, [Optional] Id32<IMFYYDLBECV<GKDKIYQIDND>>? c)
		{
			return default((Id32<SDWTKKVDDYT<IDPQTAFRJWO>>, Id32<SDWTKKVDDYT<IMFYYDLBECV<GKDKIYQIDND>>>, Id32<SDWTKKVDDYT<IMFYYDLBECV<GKDKIYQIDND>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x286AA00", Offset = "0x2869E00", VA = "0x18286AA00")]
		public static Id32<SDWTKKVDDYT<IDPQTAFRJWO>> NAQDWGYPLVO(this UnsafeList<byte> a)
		{
			return default(Id32<SDWTKKVDDYT<IDPQTAFRJWO>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x286D280", Offset = "0x286C680", VA = "0x18286D280")]
		public static (Id32<SDWTKKVDDYT<IDPQTAFRJWO>>, Id32<SDWTKKVDDYT<ZZWGXXGPIDC>>, Id32<SDWTKKVDDYT<ZZWGXXGPIDC>>, Id32<SDWTKKVDDYT<IMFYYDLBECV<ZZWGXXGPIDC>>>) XZMPKVXFEDZ(this UnsafeList<byte> a, float b, float c, [Optional] Id32<IMFYYDLBECV<ZZWGXXGPIDC>>? d)
		{
			return default((Id32<SDWTKKVDDYT<IDPQTAFRJWO>>, Id32<SDWTKKVDDYT<ZZWGXXGPIDC>>, Id32<SDWTKKVDDYT<ZZWGXXGPIDC>>, Id32<SDWTKKVDDYT<IMFYYDLBECV<ZZWGXXGPIDC>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x2868460", Offset = "0x2867860", VA = "0x182868460")]
		public static (Id32<SDWTKKVDDYT<IDPQTAFRJWO>>, Id32<SDWTKKVDDYT<ZZWGXXGPIDC>>, Id32<SDWTKKVDDYT<IMFYYDLBECV<ZZWGXXGPIDC>>>, Id32<SDWTKKVDDYT<IMFYYDLBECV<ZZWGXXGPIDC>>>) BMFWDOAYAJG(this UnsafeList<byte> a, float b, [Optional] Id32<IMFYYDLBECV<ZZWGXXGPIDC>>? c, [Optional] Id32<IMFYYDLBECV<ZZWGXXGPIDC>>? d)
		{
			return default((Id32<SDWTKKVDDYT<IDPQTAFRJWO>>, Id32<SDWTKKVDDYT<ZZWGXXGPIDC>>, Id32<SDWTKKVDDYT<IMFYYDLBECV<ZZWGXXGPIDC>>>, Id32<SDWTKKVDDYT<IMFYYDLBECV<ZZWGXXGPIDC>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x2869EB0", Offset = "0x28692B0", VA = "0x182869EB0")]
		public static (Id32<SDWTKKVDDYT<IDPQTAFRJWO>>, Id32<SDWTKKVDDYT<IMFYYDLBECV<ZZWGXXGPIDC>>>, Id32<SDWTKKVDDYT<IMFYYDLBECV<ZZWGXXGPIDC>>>, Id32<SDWTKKVDDYT<IMFYYDLBECV<ZZWGXXGPIDC>>>) IUQDHKMOMTP(this UnsafeList<byte> a, [Optional] Id32<IMFYYDLBECV<ZZWGXXGPIDC>>? b, [Optional] Id32<IMFYYDLBECV<ZZWGXXGPIDC>>? c, [Optional] Id32<IMFYYDLBECV<ZZWGXXGPIDC>>? d)
		{
			return default((Id32<SDWTKKVDDYT<IDPQTAFRJWO>>, Id32<SDWTKKVDDYT<IMFYYDLBECV<ZZWGXXGPIDC>>>, Id32<SDWTKKVDDYT<IMFYYDLBECV<ZZWGXXGPIDC>>>, Id32<SDWTKKVDDYT<IMFYYDLBECV<ZZWGXXGPIDC>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x28687F0", Offset = "0x2867BF0", VA = "0x1828687F0")]
		public static (Id32<SDWTKKVDDYT<IDPQTAFRJWO>>, Id32<SDWTKKVDDYT<GKDKIYQIDND>>, Id32<SDWTKKVDDYT<GKDKIYQIDND>>, Id32<SDWTKKVDDYT<IMFYYDLBECV<GKDKIYQIDND>>>) BOYHYNUYQTH(this UnsafeList<byte> a, int b, int c, [Optional] Id32<IMFYYDLBECV<GKDKIYQIDND>>? d)
		{
			return default((Id32<SDWTKKVDDYT<IDPQTAFRJWO>>, Id32<SDWTKKVDDYT<GKDKIYQIDND>>, Id32<SDWTKKVDDYT<GKDKIYQIDND>>, Id32<SDWTKKVDDYT<IMFYYDLBECV<GKDKIYQIDND>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x286B370", Offset = "0x286A770", VA = "0x18286B370")]
		public static (Id32<SDWTKKVDDYT<IDPQTAFRJWO>>, Id32<SDWTKKVDDYT<GKDKIYQIDND>>, Id32<SDWTKKVDDYT<IMFYYDLBECV<GKDKIYQIDND>>>, Id32<SDWTKKVDDYT<IMFYYDLBECV<GKDKIYQIDND>>>) POKUYDITTNU(this UnsafeList<byte> a, int b, [Optional] Id32<IMFYYDLBECV<GKDKIYQIDND>>? c, [Optional] Id32<IMFYYDLBECV<GKDKIYQIDND>>? d)
		{
			return default((Id32<SDWTKKVDDYT<IDPQTAFRJWO>>, Id32<SDWTKKVDDYT<GKDKIYQIDND>>, Id32<SDWTKKVDDYT<IMFYYDLBECV<GKDKIYQIDND>>>, Id32<SDWTKKVDDYT<IMFYYDLBECV<GKDKIYQIDND>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x286C800", Offset = "0x286BC00", VA = "0x18286C800")]
		public static (Id32<SDWTKKVDDYT<IDPQTAFRJWO>>, Id32<SDWTKKVDDYT<IMFYYDLBECV<GKDKIYQIDND>>>, Id32<SDWTKKVDDYT<IMFYYDLBECV<GKDKIYQIDND>>>, Id32<SDWTKKVDDYT<IMFYYDLBECV<GKDKIYQIDND>>>) WDTMNUOZGAH(this UnsafeList<byte> a, [Optional] Id32<IMFYYDLBECV<GKDKIYQIDND>>? b, [Optional] Id32<IMFYYDLBECV<GKDKIYQIDND>>? c, [Optional] Id32<IMFYYDLBECV<GKDKIYQIDND>>? d)
		{
			return default((Id32<SDWTKKVDDYT<IDPQTAFRJWO>>, Id32<SDWTKKVDDYT<IMFYYDLBECV<GKDKIYQIDND>>>, Id32<SDWTKKVDDYT<IMFYYDLBECV<GKDKIYQIDND>>>, Id32<SDWTKKVDDYT<IMFYYDLBECV<GKDKIYQIDND>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x28692C0", Offset = "0x28686C0", VA = "0x1828692C0")]
		public static (Id32<SDWTKKVDDYT<IDPQTAFRJWO>>, Id32<SDWTKKVDDYT<GKDKIYQIDND>>, Id32<SDWTKKVDDYT<GKDKIYQIDND>>, Id32<SDWTKKVDDYT<IMFYYDLBECV<GKDKIYQIDND>>>) FGEGOXIBBWQ(this UnsafeList<byte> a, int b, int c, [Optional] Id32<IMFYYDLBECV<GKDKIYQIDND>>? d)
		{
			return default((Id32<SDWTKKVDDYT<IDPQTAFRJWO>>, Id32<SDWTKKVDDYT<GKDKIYQIDND>>, Id32<SDWTKKVDDYT<GKDKIYQIDND>>, Id32<SDWTKKVDDYT<IMFYYDLBECV<GKDKIYQIDND>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x28699C0", Offset = "0x2868DC0", VA = "0x1828699C0")]
		public static (Id32<SDWTKKVDDYT<IDPQTAFRJWO>>, Id32<SDWTKKVDDYT<GKDKIYQIDND>>, Id32<SDWTKKVDDYT<IMFYYDLBECV<GKDKIYQIDND>>>, Id32<SDWTKKVDDYT<IMFYYDLBECV<GKDKIYQIDND>>>) GZPLPHCQPRB(this UnsafeList<byte> a, int b, [Optional] Id32<IMFYYDLBECV<GKDKIYQIDND>>? c, [Optional] Id32<IMFYYDLBECV<GKDKIYQIDND>>? d)
		{
			return default((Id32<SDWTKKVDDYT<IDPQTAFRJWO>>, Id32<SDWTKKVDDYT<GKDKIYQIDND>>, Id32<SDWTKKVDDYT<IMFYYDLBECV<GKDKIYQIDND>>>, Id32<SDWTKKVDDYT<IMFYYDLBECV<GKDKIYQIDND>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x286ABD0", Offset = "0x2869FD0", VA = "0x18286ABD0")]
		public static (Id32<SDWTKKVDDYT<IDPQTAFRJWO>>, Id32<SDWTKKVDDYT<IMFYYDLBECV<GKDKIYQIDND>>>, Id32<SDWTKKVDDYT<IMFYYDLBECV<GKDKIYQIDND>>>, Id32<SDWTKKVDDYT<IMFYYDLBECV<GKDKIYQIDND>>>) NUDZXSOIFSS(this UnsafeList<byte> a, [Optional] Id32<IMFYYDLBECV<GKDKIYQIDND>>? b, [Optional] Id32<IMFYYDLBECV<GKDKIYQIDND>>? c, [Optional] Id32<IMFYYDLBECV<GKDKIYQIDND>>? d)
		{
			return default((Id32<SDWTKKVDDYT<IDPQTAFRJWO>>, Id32<SDWTKKVDDYT<IMFYYDLBECV<GKDKIYQIDND>>>, Id32<SDWTKKVDDYT<IMFYYDLBECV<GKDKIYQIDND>>>, Id32<SDWTKKVDDYT<IMFYYDLBECV<GKDKIYQIDND>>>));
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
