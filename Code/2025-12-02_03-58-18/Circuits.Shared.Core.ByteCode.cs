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
		[Cpp2IlInjected.Address(RVA = "0xABFE50", Offset = "0xABEA50", VA = "0x180ABFE50")]
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
		[Cpp2IlInjected.Address(RVA = "0x2899500", Offset = "0x2898100", VA = "0x182899500")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xAC01D0", Offset = "0xABEDD0", VA = "0x180AC01D0")]
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
		[Cpp2IlInjected.Address(RVA = "0xAC0210", Offset = "0xABEE10", VA = "0x180AC0210")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
namespace Circuits.Shared.Core.ByteCode
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public static class JZTUIHVVDEU
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x37272F0", Offset = "0x3725EF0", VA = "0x1837272F0")]
		public static Id32<IMGRICEYMPU<a>> QMODFXLFLXI<a>(this int a)
		{
			return default(Id32<IMGRICEYMPU<a>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x28994C0", Offset = "0x28980C0", VA = "0x1828994C0")]
		public static Id32<HDOGPWGYNWD> KCLRSSEFTGL(this int a)
		{
			return default(Id32<HDOGPWGYNWD>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x37272F0", Offset = "0x3725EF0", VA = "0x1837272F0")]
		public static Id32<IMAAHXSZDBK<b>> GYEETYEMJFK<b>(this int a)
		{
			return default(Id32<IMAAHXSZDBK<b>>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public sealed class IMGRICEYMPU<a>
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public sealed class HFAOHXLHBSJ
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public sealed class JBNFXJGCZAM
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public sealed class HDOGPWGYNWD
	{
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public sealed class FFTLZZJTBOR
	{
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public sealed class PWVXIVCPESP
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
	public static class HLTIVIYDFSQ
	{
		[Cpp2IlInjected.Token(Token = "0x200000E")]
		public readonly struct ProcessOpDelegate<TContext, TDeps, TCompileState>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000091")]
			private readonly IntPtr _impl;

			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0xBB8EF0", Offset = "0xBB7AF0", VA = "0x180BB8EF0")]
			public ProcessOpDelegate(IntPtr impl)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x5A10490", Offset = "0x5A0F090", VA = "0x185A10490")]
			public int Invoke(TDeps deps, TContext ctx, TCompileState compileState, [In] UnsafeList<byte> fromByteCode, int byteCodePtr)
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x36ADBE0", Offset = "0x36AC7E0", VA = "0x1836ADBE0")]
		public static void HHCQFZRNMFZ<TDeps, TContext, TCompileState>(TDeps a, TContext b, TCompileState c, [In] UnsafeList<byte> oldByteCode, UnsafeList<byte> newByteCode, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processAddF32_F32i_F32i_F32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processAddF32_F32i_F32r_F32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processAddF32_F32r_F32r_F32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processAddI32_I32i_I32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processAddI32_I32i_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processAddI32_I32r_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processAndI32_I32i_I32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processAndI32_I32i_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processAndI32_I32r_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfEqualF32_F32i_F32i_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfEqualF32_F32i_F32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfEqualF32_F32r_F32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfEqualI32_I32i_I32i_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfEqualI32_I32i_I32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfEqualI32_I32r_I32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfGreaterOrEqualF32_F32i_F32i_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfGreaterOrEqualF32_F32i_F32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfGreaterOrEqualF32_F32r_F32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfGreaterOrEqualI32_I32i_I32i_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfGreaterOrEqualI32_I32i_I32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfGreaterOrEqualI32_I32r_I32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfLessF32_F32i_F32i_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfLessF32_F32i_F32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfLessF32_F32r_F32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfLessI32_I32i_I32i_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfLessI32_I32i_I32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfLessI32_I32r_I32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfLessOrEqualF32_F32i_F32i_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfLessOrEqualF32_F32i_F32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfLessOrEqualF32_F32r_F32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfLessOrEqualI32_I32i_I32i_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfLessOrEqualI32_I32i_I32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfLessOrEqualI32_I32r_I32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfNotEqualF32_F32i_F32i_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfNotEqualF32_F32i_F32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfNotEqualF32_F32r_F32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfNotEqualI32_I32i_I32i_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfNotEqualI32_I32i_I32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfNotEqualI32_I32r_I32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfNotZeroF32_F32i_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfNotZeroF32_F32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfNotZeroI32_I32i_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfNotZeroI32_I32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfZeroF32_F32i_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfZeroF32_F32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfZeroI32_I32i_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfZeroI32_I32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processCallInternal_I32i_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processCallInternal_I32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processCallExternal_I32i_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processCallExternal_I32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processCallRuntime_I32i_I32i_Xi, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processCopyI32_I32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processCopyI32_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processCopyX_Xr_I32i_Xi, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processCopyX_Xr_Xr_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processDivideF32_F32i_F32i_F32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processDivideF32_F32i_F32r_F32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processDivideF32_F32r_F32r_F32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processDivideI32_I32i_I32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processDivideI32_I32i_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processDivideI32_I32r_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processEqualF32_F32i_F32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processEqualF32_F32i_F32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processEqualF32_F32r_F32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processEqualI32_I32i_I32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processEqualI32_I32i_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processEqualI32_I32r_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processEnd, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processGreaterF32_F32i_F32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processGreaterF32_F32i_F32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processGreaterF32_F32r_F32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processGreaterI32_I32i_I32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processGreaterI32_I32i_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processGreaterI32_I32r_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processGreaterOrEqualF32_F32i_F32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processGreaterOrEqualF32_F32i_F32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processGreaterOrEqualF32_F32r_F32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processGreaterOrEqualI32_I32i_I32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processGreaterOrEqualI32_I32i_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processGreaterOrEqualI32_I32r_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processJump_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processJump_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processLessF32_F32i_F32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processLessF32_F32i_F32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processLessF32_F32r_F32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processLessI32_I32i_I32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processLessI32_I32i_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processLessI32_I32r_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processLessOrEqualF32_F32i_F32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processLessOrEqualF32_F32i_F32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processLessOrEqualF32_F32r_F32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processLessOrEqualI32_I32i_I32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processLessOrEqualI32_I32i_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processLessOrEqualI32_I32r_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processModI32_I32i_I32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processModI32_I32i_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processModI32_I32r_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processMultiplyF32_F32i_F32i_F32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processMultiplyF32_F32i_F32r_F32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processMultiplyF32_F32r_F32r_F32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processMultiplyI32_I32i_I32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processMultiplyI32_I32i_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processMultiplyI32_I32r_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processNegateF32_F32i_F32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processNegateF32_F32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processNegateF32_F32r_F32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processNegateI32_I32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processNegateI32_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processNegateI32_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processNoOp, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processNotEqualF32_F32i_F32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processNotEqualF32_F32i_F32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processNotEqualF32_F32r_F32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processNotEqualI32_I32i_I32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processNotEqualI32_I32i_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processNotEqualI32_I32r_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processNotI32_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processNotI32_I32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processNotI32_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processOrI32_I32i_I32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processOrI32_I32i_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processOrI32_I32r_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processReturn, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processStaticCastF32I32_F32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processStaticCastI32F32_I32r_F32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processSubtractF32_F32i_F32i_F32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processSubtractF32_F32i_F32r_F32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processSubtractF32_F32r_F32r_F32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processSubtractI32_I32i_I32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processSubtractI32_I32i_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processSubtractI32_I32r_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processXorI32_I32i_I32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processXorI32_I32i_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processXorI32_I32r_I32r_I32r) where TDeps : notnull where TContext : notnull where TCompileState : notnull
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x28990C0", Offset = "0x2897CC0", VA = "0x1828990C0")]
		private static int WYUBGXEZBRX([In] UnsafeList<byte> from, UnsafeList<byte> a, int b, int c)
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public static class GCEXWFPYXGL
	{
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		public static readonly int VXBHUWMHLYT;

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x369E380", Offset = "0x369CF80", VA = "0x18369E380")]
		public static Id32<IMGRICEYMPU<a>> FCRMDIEZQLP<a>([In] this UnsafeList<byte> self)
		{
			return default(Id32<IMGRICEYMPU<a>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x369E4E0", Offset = "0x369D0E0", VA = "0x18369E4E0")]
		public static Id32<IMGRICEYMPU<IMGRICEYMPU<b>>> ZZCRXCCSRAC<b>(this UnsafeList<byte> a, [Optional] Id32<IMGRICEYMPU<b>>? b)
		{
			return default(Id32<IMGRICEYMPU<IMGRICEYMPU<b>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x2898AE0", Offset = "0x28976E0", VA = "0x182898AE0")]
		public static Id32<IMGRICEYMPU<NFQUWHUKAZT>> DZLPGFSDQMM(this UnsafeList<byte> a, [Optional] Id32<NFQUWHUKAZT>? b)
		{
			return default(Id32<IMGRICEYMPU<NFQUWHUKAZT>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x2898CC0", Offset = "0x28978C0", VA = "0x182898CC0")]
		public static Id32<IMGRICEYMPU<HFAOHXLHBSJ>> IBNUHHAZFVQ(this UnsafeList<byte> a, [Optional] float? b)
		{
			return default(Id32<IMGRICEYMPU<HFAOHXLHBSJ>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x2898EB0", Offset = "0x2897AB0", VA = "0x182898EB0")]
		public static Id32<IMGRICEYMPU<JBNFXJGCZAM>> QLAOBKCYZDB(this UnsafeList<byte> a, [Optional] int? b)
		{
			return default(Id32<IMGRICEYMPU<JBNFXJGCZAM>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x28989F0", Offset = "0x28975F0", VA = "0x1828989F0")]
		public static Id32<IMGRICEYMPU<BPIYIPOBZCK>> DQUSKOOVCWZ(this UnsafeList<byte> a, [Optional] Id32<BPIYIPOBZCK>? b)
		{
			return default(Id32<IMGRICEYMPU<BPIYIPOBZCK>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x2898DB0", Offset = "0x28979B0", VA = "0x182898DB0")]
		public static Id32<IMGRICEYMPU<PWVXIVCPESP>> NCWAFCXKVJE(this UnsafeList<byte> a, [Optional] byte? b)
		{
			return default(Id32<IMGRICEYMPU<PWVXIVCPESP>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x2898BD0", Offset = "0x28977D0", VA = "0x182898BD0")]
		public static Id32<IMGRICEYMPU<HDOGPWGYNWD>> EDUYXCVPSRQ(this UnsafeList<byte> a, [Optional] Id32<HDOGPWGYNWD>? b)
		{
			return default(Id32<IMGRICEYMPU<HDOGPWGYNWD>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x2898F90", Offset = "0x2897B90", VA = "0x182898F90")]
		public static Id32<IMGRICEYMPU<FFTLZZJTBOR>> TZRTMRQQLLG(this UnsafeList<byte> a, [Optional] Op? b)
		{
			return default(Id32<IMGRICEYMPU<FFTLZZJTBOR>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x369E4E0", Offset = "0x369D0E0", VA = "0x18369E4E0")]
		public static Id32<IMGRICEYMPU<IMAAHXSZDBK<c>>> LXMMETDROBS<c>(this UnsafeList<byte> a, [Optional] Id32<IMAAHXSZDBK<c>>? b)
		{
			return default(Id32<IMGRICEYMPU<IMAAHXSZDBK<c>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x2898840", Offset = "0x2897440", VA = "0x182898840")]
		public static void FPFMTDZQAPO(this UnsafeList<byte> a, Id32<IMGRICEYMPU<JBNFXJGCZAM>> b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x369E5C0", Offset = "0x369D1C0", VA = "0x18369E5C0")]
		public static void UZEFVCFDBGR<d>(this UnsafeList<byte> a, Id32<IMGRICEYMPU<IMGRICEYMPU<d>>> b, Id32<IMGRICEYMPU<d>> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x369E5C0", Offset = "0x369D1C0", VA = "0x18369E5C0")]
		public static void MVJHAUTMYKL<e>(this UnsafeList<byte> a, Id32<IMGRICEYMPU<IMAAHXSZDBK<e>>> b, Id32<IMAAHXSZDBK<e>> c)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public static class VTYRKVPWMZM
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x289EFC0", Offset = "0x289DBC0", VA = "0x18289EFC0")]
		public static Union32 QNCAXCBWGCI([In] this ReadOnlySpan<byte> bytes, int a)
		{
			return default(Union32);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x289EF20", Offset = "0x289DB20", VA = "0x18289EF20")]
		public static Union32 QNCAXCBWGCI([In] this UnsafeList<byte> bytes, int a)
		{
			return default(Union32);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x3BD37B0", Offset = "0x3BD23B0", VA = "0x183BD37B0")]
		public static Union32 QNCAXCBWGCI<f>(this ReadOnlyIdArray<f, byte> a, Id32<f> b)
		{
			return default(Union32);
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x3BD3930", Offset = "0x3BD2530", VA = "0x183BD3930")]
		public static Union32 QNCAXCBWGCI<g>([In] this ReadOnlyIdSpan<g, byte> bytes, Id32<g> a)
		{
			return default(Union32);
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x3BD3B70", Offset = "0x3BD2770", VA = "0x183BD3B70")]
		public static Union32 QNCAXCBWGCI<i>(this IdArray<i, byte> a, Id32<i> b)
		{
			return default(Union32);
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x3BD3BD0", Offset = "0x3BD27D0", VA = "0x183BD3BD0")]
		public static Union32 QNCAXCBWGCI<j>([In] this IdSpan<j, byte> bytes, Id32<j> a)
		{
			return default(Union32);
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x3BD3AB0", Offset = "0x3BD26B0", VA = "0x183BD3AB0")]
		public static Union32 QNCAXCBWGCI<k>(this ReadOnlyIdArray<k, byte> a, Id32<k> b)
		{
			return default(Union32);
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x289EFC0", Offset = "0x289DBC0", VA = "0x18289EFC0")]
		public static int WGBUZLMXLSP([In] this ReadOnlySpan<byte> bytes, int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x28989E0", Offset = "0x28975E0", VA = "0x1828989E0")]
		public static int WGBUZLMXLSP([In] this UnsafeList<byte> bytes, int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x3BD3D90", Offset = "0x3BD2990", VA = "0x183BD3D90")]
		public static int WGBUZLMXLSP<p>(this ReadOnlyIdArray<p, byte> a, Id32<p> b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x3BD3DE0", Offset = "0x3BD29E0", VA = "0x183BD3DE0")]
		public static int WGBUZLMXLSP<s>(this IdArray<s, byte> a, Id32<s> b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x3BD3E60", Offset = "0x3BD2A60", VA = "0x183BD3E60")]
		public static int WGBUZLMXLSP<t>([In] this IdSpan<t, byte> bytes, Id32<t> a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x3BD3EB0", Offset = "0x3BD2AB0", VA = "0x183BD3EB0")]
		public static int WGBUZLMXLSP<u>(this ReadOnlyIdArray<u, byte> a, Id32<u> b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x3BD44F0", Offset = "0x3BD30F0", VA = "0x183BD44F0")]
		public static float YHXUREEFAKO<bc>(this IdArray<bc, byte> a, Id32<bc> b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x3BD44A0", Offset = "0x3BD30A0", VA = "0x183BD44A0")]
		public static float YHXUREEFAKO<bd>([In] this IdSpan<bd, byte> bytes, Id32<bd> a)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x3BD4450", Offset = "0x3BD3050", VA = "0x183BD4450")]
		public static float YHXUREEFAKO<be>(this ReadOnlyIdArray<be, byte> a, Id32<be> b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x3BD3470", Offset = "0x3BD2070", VA = "0x183BD3470")]
		public static byte MXOPVDNRXQS<bj>(this ReadOnlyIdArray<bj, byte> a, Id32<bj> b)
		{
			return default(byte);
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x3BD32D0", Offset = "0x3BD1ED0", VA = "0x183BD32D0")]
		public static byte MXOPVDNRXQS<bk>([In] this ReadOnlyIdSpan<bk, byte> bytes, Id32<bk> a)
		{
			return default(byte);
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x3BD33F0", Offset = "0x3BD1FF0", VA = "0x183BD33F0")]
		public static byte MXOPVDNRXQS<bm>(this IdArray<bm, byte> a, Id32<bm> b)
		{
			return default(byte);
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x3BD3240", Offset = "0x3BD1E40", VA = "0x183BD3240")]
		public static byte MXOPVDNRXQS<bn>([In] this IdSpan<bn, byte> bytes, Id32<bn> a)
		{
			return default(byte);
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x3BD3320", Offset = "0x3BD1F20", VA = "0x183BD3320")]
		public static byte MXOPVDNRXQS<bo>(this ReadOnlyIdArray<bo, byte> a, Id32<bo> b)
		{
			return default(byte);
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x28989E0", Offset = "0x28975E0", VA = "0x1828989E0")]
		public static Op TAYXFSUQRVO([In] this UnsafeList<byte> bytes, int a)
		{
			return default(Op);
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x3BD3C90", Offset = "0x3BD2890", VA = "0x183BD3C90")]
		public static Op TAYXFSUQRVO<by>(this ReadOnlyIdArray<by, byte> a, Id32<by> b)
		{
			return default(Op);
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x3BD2D00", Offset = "0x3BD1900", VA = "0x183BD2D00")]
		public static Id32<IMGRICEYMPU<EJGGWQPBGFS>> DCVGYIBYFPA<cg>(this IdArray<cg, byte> a, Id32<cg> b)
		{
			return default(Id32<IMGRICEYMPU<EJGGWQPBGFS>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x3BD2C70", Offset = "0x3BD1870", VA = "0x183BD2C70")]
		public static Id32<IMGRICEYMPU<EJGGWQPBGFS>> DCVGYIBYFPA<ch>([In] this IdSpan<ch, byte> bytes, Id32<ch> a)
		{
			return default(Id32<IMGRICEYMPU<EJGGWQPBGFS>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x3BD2D80", Offset = "0x3BD1980", VA = "0x183BD2D80")]
		public static Id32<IMGRICEYMPU<EJGGWQPBGFS>> DCVGYIBYFPA<ci>(this ReadOnlyIdArray<ci, byte> a, Id32<ci> b)
		{
			return default(Id32<IMGRICEYMPU<EJGGWQPBGFS>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x3BD2A60", Offset = "0x3BD1660", VA = "0x183BD2A60")]
		public static Id32<IMAAHXSZDBK<EJGGWQPBGFS>> CHSWYAEAJHO<cs>(this ReadOnlyIdArray<cs, byte> a, Id32<cs> b)
		{
			return default(Id32<IMAAHXSZDBK<EJGGWQPBGFS>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x3BD41A0", Offset = "0x3BD2DA0", VA = "0x183BD41A0")]
		public static Id32<HDOGPWGYNWD> XCGNABIBOGM<da>(this IdArray<da, byte> a, Id32<da> b)
		{
			return default(Id32<HDOGPWGYNWD>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x3BD4080", Offset = "0x3BD2C80", VA = "0x183BD4080")]
		public static Id32<HDOGPWGYNWD> XCGNABIBOGM<db>([In] this IdSpan<db, byte> bytes, Id32<db> a)
		{
			return default(Id32<HDOGPWGYNWD>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x3BD4110", Offset = "0x3BD2D10", VA = "0x183BD4110")]
		public static Id32<HDOGPWGYNWD> XCGNABIBOGM<dc>(this ReadOnlyIdArray<dc, byte> a, Id32<dc> b)
		{
			return default(Id32<HDOGPWGYNWD>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x3BD2FA0", Offset = "0x3BD1BA0", VA = "0x183BD2FA0")]
		public static Id32<NFQUWHUKAZT> DQMWFSNSXEC<dl>([In] this IdSpan<dl, byte> bytes, Id32<dl> a)
		{
			return default(Id32<NFQUWHUKAZT>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x3BD2F10", Offset = "0x3BD1B10", VA = "0x183BD2F10")]
		public static Id32<NFQUWHUKAZT> DQMWFSNSXEC<dm>(this ReadOnlyIdArray<dm, byte> a, Id32<dm> b)
		{
			return default(Id32<NFQUWHUKAZT>);
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x3BD42A0", Offset = "0x3BD2EA0", VA = "0x183BD42A0")]
		public static Id32<BPIYIPOBZCK> XVZHPOVXUNX<dw>(this ReadOnlyIdArray<dw, byte> a, Id32<dw> b)
		{
			return default(Id32<BPIYIPOBZCK>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public static class JWELFEIGQRQ
	{
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x2899400", Offset = "0x2898000", VA = "0x182899400")]
		public static void QWXVVSJYFEL(this UnsafeList<byte> a, int b, Union32 c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x2899310", Offset = "0x2897F10", VA = "0x182899310")]
		public static void QWXVVSJYFEL(this byte[] a, int b, Union32 c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x2899380", Offset = "0x2897F80", VA = "0x182899380")]
		public static void QWXVVSJYFEL([In] this Span<byte> bytes, int a, Union32 b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x3725F50", Offset = "0x3724B50", VA = "0x183725F50")]
		public static void QWXVVSJYFEL<e>(this IdArray<e, byte> a, Id32<e> b, Union32 c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x37260A0", Offset = "0x3724CA0", VA = "0x1837260A0")]
		public static void QWXVVSJYFEL<f>([In] this IdSpan<f, byte> bytes, Id32<f> a, Union32 b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x2898840", Offset = "0x2897440", VA = "0x182898840")]
		public static void FPFMTDZQAPO(this UnsafeList<byte> a, int b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x2899220", Offset = "0x2897E20", VA = "0x182899220")]
		public static void FPFMTDZQAPO(this byte[] a, int b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x28991A0", Offset = "0x2897DA0", VA = "0x1828991A0")]
		public static void FPFMTDZQAPO([In] this Span<byte> bytes, int a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x3725B30", Offset = "0x3724730", VA = "0x183725B30")]
		public static void FPFMTDZQAPO<h>(this IdArray<h, byte> a, Id32<h> b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x3725B90", Offset = "0x3724790", VA = "0x183725B90")]
		public static void FPFMTDZQAPO<i>([In] this IdSpan<i, byte> bytes, Id32<i> a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x2899160", Offset = "0x2897D60", VA = "0x182899160")]
		public static void AKGGYEBNRMR(this UnsafeList<byte> a, int b, float c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x37259E0", Offset = "0x37245E0", VA = "0x1837259E0")]
		public static void AKGGYEBNRMR<k>(this IdArray<k, byte> a, Id32<k> b, float c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x3725970", Offset = "0x3724570", VA = "0x183725970")]
		public static void AKGGYEBNRMR<l>([In] this IdSpan<l, byte> bytes, Id32<l> a, float b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x28992A0", Offset = "0x2897EA0", VA = "0x1828992A0")]
		public static void IXRUOKKCLGX(this UnsafeList<byte> a, int b, byte c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x3725CA0", Offset = "0x37248A0", VA = "0x183725CA0")]
		public static void IXRUOKKCLGX<n>(this IdArray<n, byte> a, Id32<n> b, byte c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x3725CF0", Offset = "0x37248F0", VA = "0x183725CF0")]
		public static void IXRUOKKCLGX<o>([In] this IdSpan<o, byte> bytes, Id32<o> a, byte b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x37262B0", Offset = "0x3724EB0", VA = "0x1837262B0")]
		public static void UZEFVCFDBGR<q>(this IdArray<q, byte> a, Id32<q> b, Id32<IMGRICEYMPU<EJGGWQPBGFS>> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x3726330", Offset = "0x3724F30", VA = "0x183726330")]
		public static void UZEFVCFDBGR<r>([In] this IdSpan<r, byte> bytes, Id32<r> a, Id32<IMGRICEYMPU<EJGGWQPBGFS>> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x37262B0", Offset = "0x3724EB0", VA = "0x1837262B0")]
		public static void XYGUSAVTFNJ<t>(this IdArray<t, byte> a, Id32<t> b, Id32<HDOGPWGYNWD> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x3726330", Offset = "0x3724F30", VA = "0x183726330")]
		public static void XYGUSAVTFNJ<u>([In] this IdSpan<u, byte> bytes, Id32<u> a, Id32<HDOGPWGYNWD> b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public static class PUQHAQGMBHV
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x289A980", Offset = "0x2899580", VA = "0x18289A980")]
		public static (Id32<IMGRICEYMPU<FFTLZZJTBOR>>, Id32<IMGRICEYMPU<HFAOHXLHBSJ>>, Id32<IMGRICEYMPU<HFAOHXLHBSJ>>, Id32<IMGRICEYMPU<IMAAHXSZDBK<HFAOHXLHBSJ>>>) FXVNFIUGEQT(this UnsafeList<byte> a, float b, float c, [Optional] Id32<IMAAHXSZDBK<HFAOHXLHBSJ>>? d)
		{
			return default((Id32<IMGRICEYMPU<FFTLZZJTBOR>>, Id32<IMGRICEYMPU<HFAOHXLHBSJ>>, Id32<IMGRICEYMPU<HFAOHXLHBSJ>>, Id32<IMGRICEYMPU<IMAAHXSZDBK<HFAOHXLHBSJ>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x289A0C0", Offset = "0x2898CC0", VA = "0x18289A0C0")]
		public static (Id32<IMGRICEYMPU<FFTLZZJTBOR>>, Id32<IMGRICEYMPU<HFAOHXLHBSJ>>, Id32<IMGRICEYMPU<IMAAHXSZDBK<HFAOHXLHBSJ>>>, Id32<IMGRICEYMPU<IMAAHXSZDBK<HFAOHXLHBSJ>>>) CUWPUPDWIRK(this UnsafeList<byte> a, float b, [Optional] Id32<IMAAHXSZDBK<HFAOHXLHBSJ>>? c, [Optional] Id32<IMAAHXSZDBK<HFAOHXLHBSJ>>? d)
		{
			return default((Id32<IMGRICEYMPU<FFTLZZJTBOR>>, Id32<IMGRICEYMPU<HFAOHXLHBSJ>>, Id32<IMGRICEYMPU<IMAAHXSZDBK<HFAOHXLHBSJ>>>, Id32<IMGRICEYMPU<IMAAHXSZDBK<HFAOHXLHBSJ>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x289A210", Offset = "0x2898E10", VA = "0x18289A210")]
		public static (Id32<IMGRICEYMPU<FFTLZZJTBOR>>, Id32<IMGRICEYMPU<IMAAHXSZDBK<HFAOHXLHBSJ>>>, Id32<IMGRICEYMPU<IMAAHXSZDBK<HFAOHXLHBSJ>>>, Id32<IMGRICEYMPU<IMAAHXSZDBK<HFAOHXLHBSJ>>>) CXADKQMFFBL(this UnsafeList<byte> a, [Optional] Id32<IMAAHXSZDBK<HFAOHXLHBSJ>>? b, [Optional] Id32<IMAAHXSZDBK<HFAOHXLHBSJ>>? c, [Optional] Id32<IMAAHXSZDBK<HFAOHXLHBSJ>>? d)
		{
			return default((Id32<IMGRICEYMPU<FFTLZZJTBOR>>, Id32<IMGRICEYMPU<IMAAHXSZDBK<HFAOHXLHBSJ>>>, Id32<IMGRICEYMPU<IMAAHXSZDBK<HFAOHXLHBSJ>>>, Id32<IMGRICEYMPU<IMAAHXSZDBK<HFAOHXLHBSJ>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x289EDC0", Offset = "0x289D9C0", VA = "0x18289EDC0")]
		public static (Id32<IMGRICEYMPU<FFTLZZJTBOR>>, Id32<IMGRICEYMPU<JBNFXJGCZAM>>, Id32<IMGRICEYMPU<JBNFXJGCZAM>>, Id32<IMGRICEYMPU<IMAAHXSZDBK<JBNFXJGCZAM>>>) ZWCZHTSOPLP(this UnsafeList<byte> a, int b, int c, [Optional] Id32<IMAAHXSZDBK<JBNFXJGCZAM>>? d)
		{
			return default((Id32<IMGRICEYMPU<FFTLZZJTBOR>>, Id32<IMGRICEYMPU<JBNFXJGCZAM>>, Id32<IMGRICEYMPU<JBNFXJGCZAM>>, Id32<IMGRICEYMPU<IMAAHXSZDBK<JBNFXJGCZAM>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x289B860", Offset = "0x289A460", VA = "0x18289B860")]
		public static (Id32<IMGRICEYMPU<FFTLZZJTBOR>>, Id32<IMGRICEYMPU<JBNFXJGCZAM>>, Id32<IMGRICEYMPU<IMAAHXSZDBK<JBNFXJGCZAM>>>, Id32<IMGRICEYMPU<IMAAHXSZDBK<JBNFXJGCZAM>>>) KAFBFSLDTRA(this UnsafeList<byte> a, int b, [Optional] Id32<IMAAHXSZDBK<JBNFXJGCZAM>>? c, [Optional] Id32<IMAAHXSZDBK<JBNFXJGCZAM>>? d)
		{
			return default((Id32<IMGRICEYMPU<FFTLZZJTBOR>>, Id32<IMGRICEYMPU<JBNFXJGCZAM>>, Id32<IMGRICEYMPU<IMAAHXSZDBK<JBNFXJGCZAM>>>, Id32<IMGRICEYMPU<IMAAHXSZDBK<JBNFXJGCZAM>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x289E100", Offset = "0x289CD00", VA = "0x18289E100")]
		public static (Id32<IMGRICEYMPU<FFTLZZJTBOR>>, Id32<IMGRICEYMPU<IMAAHXSZDBK<JBNFXJGCZAM>>>, Id32<IMGRICEYMPU<IMAAHXSZDBK<JBNFXJGCZAM>>>, Id32<IMGRICEYMPU<IMAAHXSZDBK<JBNFXJGCZAM>>>) UMCRAWELNGT(this UnsafeList<byte> a, [Optional] Id32<IMAAHXSZDBK<JBNFXJGCZAM>>? b, [Optional] Id32<IMAAHXSZDBK<JBNFXJGCZAM>>? c, [Optional] Id32<IMAAHXSZDBK<JBNFXJGCZAM>>? d)
		{
			return default((Id32<IMGRICEYMPU<FFTLZZJTBOR>>, Id32<IMGRICEYMPU<IMAAHXSZDBK<JBNFXJGCZAM>>>, Id32<IMGRICEYMPU<IMAAHXSZDBK<JBNFXJGCZAM>>>, Id32<IMGRICEYMPU<IMAAHXSZDBK<JBNFXJGCZAM>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x289D570", Offset = "0x289C170", VA = "0x18289D570")]
		public static (Id32<IMGRICEYMPU<FFTLZZJTBOR>>, Id32<IMGRICEYMPU<JBNFXJGCZAM>>, Id32<IMGRICEYMPU<JBNFXJGCZAM>>, Id32<IMGRICEYMPU<IMAAHXSZDBK<JBNFXJGCZAM>>>) RZJQNCXILBR(this UnsafeList<byte> a, int b, int c, [Optional] Id32<IMAAHXSZDBK<JBNFXJGCZAM>>? d)
		{
			return default((Id32<IMGRICEYMPU<FFTLZZJTBOR>>, Id32<IMGRICEYMPU<JBNFXJGCZAM>>, Id32<IMGRICEYMPU<JBNFXJGCZAM>>, Id32<IMGRICEYMPU<IMAAHXSZDBK<JBNFXJGCZAM>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x289A700", Offset = "0x2899300", VA = "0x18289A700")]
		public static (Id32<IMGRICEYMPU<FFTLZZJTBOR>>, Id32<IMGRICEYMPU<JBNFXJGCZAM>>, Id32<IMGRICEYMPU<IMAAHXSZDBK<JBNFXJGCZAM>>>, Id32<IMGRICEYMPU<IMAAHXSZDBK<JBNFXJGCZAM>>>) ERCWVDPRCSU(this UnsafeList<byte> a, int b, [Optional] Id32<IMAAHXSZDBK<JBNFXJGCZAM>>? c, [Optional] Id32<IMAAHXSZDBK<JBNFXJGCZAM>>? d)
		{
			return default((Id32<IMGRICEYMPU<FFTLZZJTBOR>>, Id32<IMGRICEYMPU<JBNFXJGCZAM>>, Id32<IMGRICEYMPU<IMAAHXSZDBK<JBNFXJGCZAM>>>, Id32<IMGRICEYMPU<IMAAHXSZDBK<JBNFXJGCZAM>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x2899910", Offset = "0x2898510", VA = "0x182899910")]
		public static (Id32<IMGRICEYMPU<FFTLZZJTBOR>>, Id32<IMGRICEYMPU<IMAAHXSZDBK<JBNFXJGCZAM>>>, Id32<IMGRICEYMPU<IMAAHXSZDBK<JBNFXJGCZAM>>>, Id32<IMGRICEYMPU<IMAAHXSZDBK<JBNFXJGCZAM>>>) ARXXZBFUWJP(this UnsafeList<byte> a, [Optional] Id32<IMAAHXSZDBK<JBNFXJGCZAM>>? b, [Optional] Id32<IMAAHXSZDBK<JBNFXJGCZAM>>? c, [Optional] Id32<IMAAHXSZDBK<JBNFXJGCZAM>>? d)
		{
			return default((Id32<IMGRICEYMPU<FFTLZZJTBOR>>, Id32<IMGRICEYMPU<IMAAHXSZDBK<JBNFXJGCZAM>>>, Id32<IMGRICEYMPU<IMAAHXSZDBK<JBNFXJGCZAM>>>, Id32<IMGRICEYMPU<IMAAHXSZDBK<JBNFXJGCZAM>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x289AB00", Offset = "0x2899700", VA = "0x18289AB00")]
		public static (Id32<IMGRICEYMPU<FFTLZZJTBOR>>, Id32<IMGRICEYMPU<JBNFXJGCZAM>>, Id32<IMGRICEYMPU<IMGRICEYMPU<FFTLZZJTBOR>>>) GCZZCVNSOWP(this UnsafeList<byte> a, [Optional] int? b, [Optional] Id32<IMGRICEYMPU<FFTLZZJTBOR>>? c)
		{
			return default((Id32<IMGRICEYMPU<FFTLZZJTBOR>>, Id32<IMGRICEYMPU<JBNFXJGCZAM>>, Id32<IMGRICEYMPU<IMGRICEYMPU<FFTLZZJTBOR>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x289E7A0", Offset = "0x289D3A0", VA = "0x18289E7A0")]
		public static (Id32<IMGRICEYMPU<FFTLZZJTBOR>>, Id32<IMGRICEYMPU<IMAAHXSZDBK<JBNFXJGCZAM>>>, Id32<IMGRICEYMPU<IMGRICEYMPU<FFTLZZJTBOR>>>) XLYSYUGICWU(this UnsafeList<byte> a, [Optional] Id32<IMAAHXSZDBK<JBNFXJGCZAM>>? b, [Optional] Id32<IMGRICEYMPU<FFTLZZJTBOR>>? c)
		{
			return default((Id32<IMGRICEYMPU<FFTLZZJTBOR>>, Id32<IMGRICEYMPU<IMAAHXSZDBK<JBNFXJGCZAM>>>, Id32<IMGRICEYMPU<IMGRICEYMPU<FFTLZZJTBOR>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x2899580", Offset = "0x2898180", VA = "0x182899580")]
		public static (Id32<IMGRICEYMPU<FFTLZZJTBOR>>, Id32<IMGRICEYMPU<JBNFXJGCZAM>>, Id32<IMGRICEYMPU<IMGRICEYMPU<FFTLZZJTBOR>>>) AFRZUFUHSUA(this UnsafeList<byte> a, [Optional] int? b, [Optional] Id32<IMGRICEYMPU<FFTLZZJTBOR>>? c)
		{
			return default((Id32<IMGRICEYMPU<FFTLZZJTBOR>>, Id32<IMGRICEYMPU<JBNFXJGCZAM>>, Id32<IMGRICEYMPU<IMGRICEYMPU<FFTLZZJTBOR>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x289AFF0", Offset = "0x2899BF0", VA = "0x18289AFF0")]
		public static (Id32<IMGRICEYMPU<FFTLZZJTBOR>>, Id32<IMGRICEYMPU<IMAAHXSZDBK<JBNFXJGCZAM>>>, Id32<IMGRICEYMPU<IMGRICEYMPU<FFTLZZJTBOR>>>) HIUYPILUYHN(this UnsafeList<byte> a, [Optional] Id32<IMAAHXSZDBK<JBNFXJGCZAM>>? b, [Optional] Id32<IMGRICEYMPU<FFTLZZJTBOR>>? c)
		{
			return default((Id32<IMGRICEYMPU<FFTLZZJTBOR>>, Id32<IMGRICEYMPU<IMAAHXSZDBK<JBNFXJGCZAM>>>, Id32<IMGRICEYMPU<IMGRICEYMPU<FFTLZZJTBOR>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x289D930", Offset = "0x289C530", VA = "0x18289D930")]
		public static (Id32<IMGRICEYMPU<FFTLZZJTBOR>>, Id32<IMGRICEYMPU<JBNFXJGCZAM>>, Id32<IMGRICEYMPU<NFQUWHUKAZT>>) SLLMDFKZMQE(this UnsafeList<byte> a, [Optional] int? b, [Optional] Id32<NFQUWHUKAZT>? c)
		{
			return default((Id32<IMGRICEYMPU<FFTLZZJTBOR>>, Id32<IMGRICEYMPU<JBNFXJGCZAM>>, Id32<IMGRICEYMPU<NFQUWHUKAZT>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x289D820", Offset = "0x289C420", VA = "0x18289D820")]
		public static (Id32<IMGRICEYMPU<FFTLZZJTBOR>>, Id32<IMGRICEYMPU<JBNFXJGCZAM>>, Id32<IMGRICEYMPU<IMAAHXSZDBK<NFQUWHUKAZT>>>) SKLDQXPMRLL(this UnsafeList<byte> a, [Optional] int? b, [Optional] Id32<IMAAHXSZDBK<NFQUWHUKAZT>>? c)
		{
			return default((Id32<IMGRICEYMPU<FFTLZZJTBOR>>, Id32<IMGRICEYMPU<JBNFXJGCZAM>>, Id32<IMGRICEYMPU<IMAAHXSZDBK<NFQUWHUKAZT>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x289C9E0", Offset = "0x289B5E0", VA = "0x18289C9E0")]
		public static (Id32<IMGRICEYMPU<FFTLZZJTBOR>>, Id32<IMGRICEYMPU<JBNFXJGCZAM>>, Id32<IMGRICEYMPU<HDOGPWGYNWD>>) OKPNTFZYPSO(this UnsafeList<byte> a, [Optional] int? b, [Optional] Id32<HDOGPWGYNWD>? c)
		{
			return default((Id32<IMGRICEYMPU<FFTLZZJTBOR>>, Id32<IMGRICEYMPU<JBNFXJGCZAM>>, Id32<IMGRICEYMPU<HDOGPWGYNWD>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x289C750", Offset = "0x289B350", VA = "0x18289C750")]
		public static (Id32<IMGRICEYMPU<FFTLZZJTBOR>>, Id32<IMGRICEYMPU<JBNFXJGCZAM>>, Id32<IMGRICEYMPU<IMAAHXSZDBK<HDOGPWGYNWD>>>) OFNXJSWMNUX(this UnsafeList<byte> a, [Optional] int? b, [Optional] Id32<IMAAHXSZDBK<HDOGPWGYNWD>>? c)
		{
			return default((Id32<IMGRICEYMPU<FFTLZZJTBOR>>, Id32<IMGRICEYMPU<JBNFXJGCZAM>>, Id32<IMGRICEYMPU<IMAAHXSZDBK<HDOGPWGYNWD>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x38D6370", Offset = "0x38D4F70", VA = "0x1838D6370")]
		public static (Id32<IMGRICEYMPU<FFTLZZJTBOR>>, Id32<IMGRICEYMPU<BPIYIPOBZCK>>, Id32<IMGRICEYMPU<JBNFXJGCZAM>>, Id32<IMGRICEYMPU<a>>) YQMWVWJCDNL<a>(this UnsafeList<byte> a, [Optional] Id32<BPIYIPOBZCK>? b, [Optional][In] ReadOnlySpan<byte> data)
		{
			return default((Id32<IMGRICEYMPU<FFTLZZJTBOR>>, Id32<IMGRICEYMPU<BPIYIPOBZCK>>, Id32<IMGRICEYMPU<JBNFXJGCZAM>>, Id32<IMGRICEYMPU<a>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x289BB10", Offset = "0x289A710", VA = "0x18289BB10")]
		public static (Id32<IMGRICEYMPU<FFTLZZJTBOR>>, Id32<IMGRICEYMPU<JBNFXJGCZAM>>, Id32<IMGRICEYMPU<IMAAHXSZDBK<JBNFXJGCZAM>>>) KNFRKSOTDHP(this UnsafeList<byte> a, int b, [Optional] Id32<IMAAHXSZDBK<JBNFXJGCZAM>>? c)
		{
			return default((Id32<IMGRICEYMPU<FFTLZZJTBOR>>, Id32<IMGRICEYMPU<JBNFXJGCZAM>>, Id32<IMGRICEYMPU<IMAAHXSZDBK<JBNFXJGCZAM>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x289BC40", Offset = "0x289A840", VA = "0x18289BC40")]
		public static (Id32<IMGRICEYMPU<FFTLZZJTBOR>>, Id32<IMGRICEYMPU<IMAAHXSZDBK<JBNFXJGCZAM>>>, Id32<IMGRICEYMPU<IMAAHXSZDBK<JBNFXJGCZAM>>>) KPJBAEOBJVQ(this UnsafeList<byte> a, [Optional] Id32<IMAAHXSZDBK<JBNFXJGCZAM>>? b, [Optional] Id32<IMAAHXSZDBK<JBNFXJGCZAM>>? c)
		{
			return default((Id32<IMGRICEYMPU<FFTLZZJTBOR>>, Id32<IMGRICEYMPU<IMAAHXSZDBK<JBNFXJGCZAM>>>, Id32<IMGRICEYMPU<IMAAHXSZDBK<JBNFXJGCZAM>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x38D5F60", Offset = "0x38D4B60", VA = "0x1838D5F60")]
		public static (Id32<IMGRICEYMPU<FFTLZZJTBOR>>, Id32<IMGRICEYMPU<IMAAHXSZDBK<b>>>, Id32<IMGRICEYMPU<JBNFXJGCZAM>>, Id32<IMGRICEYMPU<b>>) WKJHGVSWEGL<b>(this UnsafeList<byte> a, [Optional] Id32<IMAAHXSZDBK<b>>? b, [Optional] int? c, [Optional][In] ReadOnlySpan<byte> from)
		{
			return default((Id32<IMGRICEYMPU<FFTLZZJTBOR>>, Id32<IMGRICEYMPU<IMAAHXSZDBK<b>>>, Id32<IMGRICEYMPU<JBNFXJGCZAM>>, Id32<IMGRICEYMPU<b>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x38D5C30", Offset = "0x38D4830", VA = "0x1838D5C30")]
		public static (Id32<IMGRICEYMPU<FFTLZZJTBOR>>, Id32<IMGRICEYMPU<IMAAHXSZDBK<c>>>, Id32<IMGRICEYMPU<IMAAHXSZDBK<c>>>, Id32<IMGRICEYMPU<JBNFXJGCZAM>>) UHYLEXXZWIE<c>(this UnsafeList<byte> a, [Optional] Id32<IMAAHXSZDBK<c>>? b, [Optional] Id32<IMAAHXSZDBK<c>>? c, [Optional] int? d)
		{
			return default((Id32<IMGRICEYMPU<FFTLZZJTBOR>>, Id32<IMGRICEYMPU<IMAAHXSZDBK<c>>>, Id32<IMGRICEYMPU<IMAAHXSZDBK<c>>>, Id32<IMGRICEYMPU<JBNFXJGCZAM>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x289C5D0", Offset = "0x289B1D0", VA = "0x18289C5D0")]
		public static (Id32<IMGRICEYMPU<FFTLZZJTBOR>>, Id32<IMGRICEYMPU<HFAOHXLHBSJ>>, Id32<IMGRICEYMPU<HFAOHXLHBSJ>>, Id32<IMGRICEYMPU<IMAAHXSZDBK<HFAOHXLHBSJ>>>) NYJZXVRVPCP(this UnsafeList<byte> a, float b, float c, [Optional] Id32<IMAAHXSZDBK<HFAOHXLHBSJ>>? d)
		{
			return default((Id32<IMGRICEYMPU<FFTLZZJTBOR>>, Id32<IMGRICEYMPU<HFAOHXLHBSJ>>, Id32<IMGRICEYMPU<HFAOHXLHBSJ>>, Id32<IMGRICEYMPU<IMAAHXSZDBK<HFAOHXLHBSJ>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x2899F70", Offset = "0x2898B70", VA = "0x182899F70")]
		public static (Id32<IMGRICEYMPU<FFTLZZJTBOR>>, Id32<IMGRICEYMPU<HFAOHXLHBSJ>>, Id32<IMGRICEYMPU<IMAAHXSZDBK<HFAOHXLHBSJ>>>, Id32<IMGRICEYMPU<IMAAHXSZDBK<HFAOHXLHBSJ>>>) CTZWOVHJODK(this UnsafeList<byte> a, float b, [Optional] Id32<IMAAHXSZDBK<HFAOHXLHBSJ>>? c, [Optional] Id32<IMAAHXSZDBK<HFAOHXLHBSJ>>? d)
		{
			return default((Id32<IMGRICEYMPU<FFTLZZJTBOR>>, Id32<IMGRICEYMPU<HFAOHXLHBSJ>>, Id32<IMGRICEYMPU<IMAAHXSZDBK<HFAOHXLHBSJ>>>, Id32<IMGRICEYMPU<IMAAHXSZDBK<HFAOHXLHBSJ>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x289CB90", Offset = "0x289B790", VA = "0x18289CB90")]
		public static (Id32<IMGRICEYMPU<FFTLZZJTBOR>>, Id32<IMGRICEYMPU<IMAAHXSZDBK<HFAOHXLHBSJ>>>, Id32<IMGRICEYMPU<IMAAHXSZDBK<HFAOHXLHBSJ>>>, Id32<IMGRICEYMPU<IMAAHXSZDBK<HFAOHXLHBSJ>>>) OMMAWONPAUV(this UnsafeList<byte> a, [Optional] Id32<IMAAHXSZDBK<HFAOHXLHBSJ>>? b, [Optional] Id32<IMAAHXSZDBK<HFAOHXLHBSJ>>? c, [Optional] Id32<IMAAHXSZDBK<HFAOHXLHBSJ>>? d)
		{
			return default((Id32<IMGRICEYMPU<FFTLZZJTBOR>>, Id32<IMGRICEYMPU<IMAAHXSZDBK<HFAOHXLHBSJ>>>, Id32<IMGRICEYMPU<IMAAHXSZDBK<HFAOHXLHBSJ>>>, Id32<IMGRICEYMPU<IMAAHXSZDBK<HFAOHXLHBSJ>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x289E220", Offset = "0x289CE20", VA = "0x18289E220")]
		public static (Id32<IMGRICEYMPU<FFTLZZJTBOR>>, Id32<IMGRICEYMPU<JBNFXJGCZAM>>, Id32<IMGRICEYMPU<JBNFXJGCZAM>>, Id32<IMGRICEYMPU<IMAAHXSZDBK<JBNFXJGCZAM>>>) UZMGIHAORIZ(this UnsafeList<byte> a, int b, int c, [Optional] Id32<IMAAHXSZDBK<JBNFXJGCZAM>>? d)
		{
			return default((Id32<IMGRICEYMPU<FFTLZZJTBOR>>, Id32<IMGRICEYMPU<JBNFXJGCZAM>>, Id32<IMGRICEYMPU<JBNFXJGCZAM>>, Id32<IMGRICEYMPU<IMAAHXSZDBK<JBNFXJGCZAM>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x289CDD0", Offset = "0x289B9D0", VA = "0x18289CDD0")]
		public static (Id32<IMGRICEYMPU<FFTLZZJTBOR>>, Id32<IMGRICEYMPU<JBNFXJGCZAM>>, Id32<IMGRICEYMPU<IMAAHXSZDBK<JBNFXJGCZAM>>>, Id32<IMGRICEYMPU<IMAAHXSZDBK<JBNFXJGCZAM>>>) QHHYEDRWUDE(this UnsafeList<byte> a, int b, [Optional] Id32<IMAAHXSZDBK<JBNFXJGCZAM>>? c, [Optional] Id32<IMAAHXSZDBK<JBNFXJGCZAM>>? d)
		{
			return default((Id32<IMGRICEYMPU<FFTLZZJTBOR>>, Id32<IMGRICEYMPU<JBNFXJGCZAM>>, Id32<IMGRICEYMPU<IMAAHXSZDBK<JBNFXJGCZAM>>>, Id32<IMGRICEYMPU<IMAAHXSZDBK<JBNFXJGCZAM>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x289B540", Offset = "0x289A140", VA = "0x18289B540")]
		public static (Id32<IMGRICEYMPU<FFTLZZJTBOR>>, Id32<IMGRICEYMPU<IMAAHXSZDBK<JBNFXJGCZAM>>>, Id32<IMGRICEYMPU<IMAAHXSZDBK<JBNFXJGCZAM>>>, Id32<IMGRICEYMPU<IMAAHXSZDBK<JBNFXJGCZAM>>>) IAGUMMEYZWP(this UnsafeList<byte> a, [Optional] Id32<IMAAHXSZDBK<JBNFXJGCZAM>>? b, [Optional] Id32<IMAAHXSZDBK<JBNFXJGCZAM>>? c, [Optional] Id32<IMAAHXSZDBK<JBNFXJGCZAM>>? d)
		{
			return default((Id32<IMGRICEYMPU<FFTLZZJTBOR>>, Id32<IMGRICEYMPU<IMAAHXSZDBK<JBNFXJGCZAM>>>, Id32<IMGRICEYMPU<IMAAHXSZDBK<JBNFXJGCZAM>>>, Id32<IMGRICEYMPU<IMAAHXSZDBK<JBNFXJGCZAM>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x289D170", Offset = "0x289BD70", VA = "0x18289D170")]
		public static (Id32<IMGRICEYMPU<FFTLZZJTBOR>>, Id32<IMGRICEYMPU<JBNFXJGCZAM>>, Id32<IMGRICEYMPU<JBNFXJGCZAM>>, Id32<IMGRICEYMPU<IMAAHXSZDBK<JBNFXJGCZAM>>>) RMBWYAFBHIO(this UnsafeList<byte> a, int b, int c, [Optional] Id32<IMAAHXSZDBK<JBNFXJGCZAM>>? d)
		{
			return default((Id32<IMGRICEYMPU<FFTLZZJTBOR>>, Id32<IMGRICEYMPU<JBNFXJGCZAM>>, Id32<IMGRICEYMPU<JBNFXJGCZAM>>, Id32<IMGRICEYMPU<IMAAHXSZDBK<JBNFXJGCZAM>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x2899E20", Offset = "0x2898A20", VA = "0x182899E20")]
		public static (Id32<IMGRICEYMPU<FFTLZZJTBOR>>, Id32<IMGRICEYMPU<JBNFXJGCZAM>>, Id32<IMGRICEYMPU<IMAAHXSZDBK<JBNFXJGCZAM>>>, Id32<IMGRICEYMPU<IMAAHXSZDBK<JBNFXJGCZAM>>>) CRUFBPSIVSF(this UnsafeList<byte> a, int b, [Optional] Id32<IMAAHXSZDBK<JBNFXJGCZAM>>? c, [Optional] Id32<IMAAHXSZDBK<JBNFXJGCZAM>>? d)
		{
			return default((Id32<IMGRICEYMPU<FFTLZZJTBOR>>, Id32<IMGRICEYMPU<JBNFXJGCZAM>>, Id32<IMGRICEYMPU<IMAAHXSZDBK<JBNFXJGCZAM>>>, Id32<IMGRICEYMPU<IMAAHXSZDBK<JBNFXJGCZAM>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x2899D00", Offset = "0x2898900", VA = "0x182899D00")]
		public static (Id32<IMGRICEYMPU<FFTLZZJTBOR>>, Id32<IMGRICEYMPU<IMAAHXSZDBK<JBNFXJGCZAM>>>, Id32<IMGRICEYMPU<IMAAHXSZDBK<JBNFXJGCZAM>>>, Id32<IMGRICEYMPU<IMAAHXSZDBK<JBNFXJGCZAM>>>) CKSKESOJLQQ(this UnsafeList<byte> a, [Optional] Id32<IMAAHXSZDBK<JBNFXJGCZAM>>? b, [Optional] Id32<IMAAHXSZDBK<JBNFXJGCZAM>>? c, [Optional] Id32<IMAAHXSZDBK<JBNFXJGCZAM>>? d)
		{
			return default((Id32<IMGRICEYMPU<FFTLZZJTBOR>>, Id32<IMGRICEYMPU<IMAAHXSZDBK<JBNFXJGCZAM>>>, Id32<IMGRICEYMPU<IMAAHXSZDBK<JBNFXJGCZAM>>>, Id32<IMGRICEYMPU<IMAAHXSZDBK<JBNFXJGCZAM>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x289B660", Offset = "0x289A260", VA = "0x18289B660")]
		public static (Id32<IMGRICEYMPU<FFTLZZJTBOR>>, Id32<IMGRICEYMPU<IMGRICEYMPU<FFTLZZJTBOR>>>) JKWZQYTASER(this UnsafeList<byte> a, [Optional] Id32<IMGRICEYMPU<FFTLZZJTBOR>>? b)
		{
			return default((Id32<IMGRICEYMPU<FFTLZZJTBOR>>, Id32<IMGRICEYMPU<IMGRICEYMPU<FFTLZZJTBOR>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x289B3C0", Offset = "0x2899FC0", VA = "0x18289B3C0")]
		public static (Id32<IMGRICEYMPU<FFTLZZJTBOR>>, Id32<IMGRICEYMPU<HFAOHXLHBSJ>>, Id32<IMGRICEYMPU<HFAOHXLHBSJ>>, Id32<IMGRICEYMPU<IMAAHXSZDBK<JBNFXJGCZAM>>>) HVQHMFBGZFH(this UnsafeList<byte> a, float b, float c, [Optional] Id32<IMAAHXSZDBK<JBNFXJGCZAM>>? d)
		{
			return default((Id32<IMGRICEYMPU<FFTLZZJTBOR>>, Id32<IMGRICEYMPU<HFAOHXLHBSJ>>, Id32<IMGRICEYMPU<HFAOHXLHBSJ>>, Id32<IMGRICEYMPU<IMAAHXSZDBK<JBNFXJGCZAM>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x289BD50", Offset = "0x289A950", VA = "0x18289BD50")]
		public static (Id32<IMGRICEYMPU<FFTLZZJTBOR>>, Id32<IMGRICEYMPU<HFAOHXLHBSJ>>, Id32<IMGRICEYMPU<IMAAHXSZDBK<HFAOHXLHBSJ>>>, Id32<IMGRICEYMPU<IMAAHXSZDBK<JBNFXJGCZAM>>>) KXSMPICCZEW(this UnsafeList<byte> a, float b, [Optional] Id32<IMAAHXSZDBK<HFAOHXLHBSJ>>? c, [Optional] Id32<IMAAHXSZDBK<JBNFXJGCZAM>>? d)
		{
			return default((Id32<IMGRICEYMPU<FFTLZZJTBOR>>, Id32<IMGRICEYMPU<HFAOHXLHBSJ>>, Id32<IMGRICEYMPU<IMAAHXSZDBK<HFAOHXLHBSJ>>>, Id32<IMGRICEYMPU<IMAAHXSZDBK<JBNFXJGCZAM>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x2899690", Offset = "0x2898290", VA = "0x182899690")]
		public static (Id32<IMGRICEYMPU<FFTLZZJTBOR>>, Id32<IMGRICEYMPU<IMAAHXSZDBK<HFAOHXLHBSJ>>>, Id32<IMGRICEYMPU<IMAAHXSZDBK<HFAOHXLHBSJ>>>, Id32<IMGRICEYMPU<IMAAHXSZDBK<JBNFXJGCZAM>>>) AIKXXHZPJPN(this UnsafeList<byte> a, [Optional] Id32<IMAAHXSZDBK<HFAOHXLHBSJ>>? b, [Optional] Id32<IMAAHXSZDBK<HFAOHXLHBSJ>>? c, [Optional] Id32<IMAAHXSZDBK<JBNFXJGCZAM>>? d)
		{
			return default((Id32<IMGRICEYMPU<FFTLZZJTBOR>>, Id32<IMGRICEYMPU<IMAAHXSZDBK<HFAOHXLHBSJ>>>, Id32<IMGRICEYMPU<IMAAHXSZDBK<HFAOHXLHBSJ>>>, Id32<IMGRICEYMPU<IMAAHXSZDBK<JBNFXJGCZAM>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x289AE90", Offset = "0x2899A90", VA = "0x18289AE90")]
		public static (Id32<IMGRICEYMPU<FFTLZZJTBOR>>, Id32<IMGRICEYMPU<JBNFXJGCZAM>>, Id32<IMGRICEYMPU<JBNFXJGCZAM>>, Id32<IMGRICEYMPU<IMAAHXSZDBK<JBNFXJGCZAM>>>) GQISCRMDAAQ(this UnsafeList<byte> a, int b, int c, [Optional] Id32<IMAAHXSZDBK<JBNFXJGCZAM>>? d)
		{
			return default((Id32<IMGRICEYMPU<FFTLZZJTBOR>>, Id32<IMGRICEYMPU<JBNFXJGCZAM>>, Id32<IMGRICEYMPU<JBNFXJGCZAM>>, Id32<IMGRICEYMPU<IMAAHXSZDBK<JBNFXJGCZAM>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x289DD30", Offset = "0x289C930", VA = "0x18289DD30")]
		public static (Id32<IMGRICEYMPU<FFTLZZJTBOR>>, Id32<IMGRICEYMPU<JBNFXJGCZAM>>, Id32<IMGRICEYMPU<IMAAHXSZDBK<JBNFXJGCZAM>>>, Id32<IMGRICEYMPU<IMAAHXSZDBK<JBNFXJGCZAM>>>) TYPLUQTUIJN(this UnsafeList<byte> a, int b, [Optional] Id32<IMAAHXSZDBK<JBNFXJGCZAM>>? c, [Optional] Id32<IMAAHXSZDBK<JBNFXJGCZAM>>? d)
		{
			return default((Id32<IMGRICEYMPU<FFTLZZJTBOR>>, Id32<IMGRICEYMPU<JBNFXJGCZAM>>, Id32<IMGRICEYMPU<IMAAHXSZDBK<JBNFXJGCZAM>>>, Id32<IMGRICEYMPU<IMAAHXSZDBK<JBNFXJGCZAM>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x289CCB0", Offset = "0x289B8B0", VA = "0x18289CCB0")]
		public static (Id32<IMGRICEYMPU<FFTLZZJTBOR>>, Id32<IMGRICEYMPU<IMAAHXSZDBK<JBNFXJGCZAM>>>, Id32<IMGRICEYMPU<IMAAHXSZDBK<JBNFXJGCZAM>>>, Id32<IMGRICEYMPU<IMAAHXSZDBK<JBNFXJGCZAM>>>) QGHHHGOUJGK(this UnsafeList<byte> a, [Optional] Id32<IMAAHXSZDBK<JBNFXJGCZAM>>? b, [Optional] Id32<IMAAHXSZDBK<JBNFXJGCZAM>>? c, [Optional] Id32<IMAAHXSZDBK<JBNFXJGCZAM>>? d)
		{
			return default((Id32<IMGRICEYMPU<FFTLZZJTBOR>>, Id32<IMGRICEYMPU<IMAAHXSZDBK<JBNFXJGCZAM>>>, Id32<IMGRICEYMPU<IMAAHXSZDBK<JBNFXJGCZAM>>>, Id32<IMGRICEYMPU<IMAAHXSZDBK<JBNFXJGCZAM>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x289D2D0", Offset = "0x289BED0", VA = "0x18289D2D0")]
		public static (Id32<IMGRICEYMPU<FFTLZZJTBOR>>, Id32<IMGRICEYMPU<HFAOHXLHBSJ>>, Id32<IMGRICEYMPU<HFAOHXLHBSJ>>, Id32<IMGRICEYMPU<IMAAHXSZDBK<JBNFXJGCZAM>>>) RQWBSDGKXJS(this UnsafeList<byte> a, float b, float c, [Optional] Id32<IMAAHXSZDBK<JBNFXJGCZAM>>? d)
		{
			return default((Id32<IMGRICEYMPU<FFTLZZJTBOR>>, Id32<IMGRICEYMPU<HFAOHXLHBSJ>>, Id32<IMGRICEYMPU<HFAOHXLHBSJ>>, Id32<IMGRICEYMPU<IMAAHXSZDBK<JBNFXJGCZAM>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x289A480", Offset = "0x2899080", VA = "0x18289A480")]
		public static (Id32<IMGRICEYMPU<FFTLZZJTBOR>>, Id32<IMGRICEYMPU<HFAOHXLHBSJ>>, Id32<IMGRICEYMPU<IMAAHXSZDBK<HFAOHXLHBSJ>>>, Id32<IMGRICEYMPU<IMAAHXSZDBK<JBNFXJGCZAM>>>) DLEPOWORFZB(this UnsafeList<byte> a, float b, [Optional] Id32<IMAAHXSZDBK<HFAOHXLHBSJ>>? c, [Optional] Id32<IMAAHXSZDBK<JBNFXJGCZAM>>? d)
		{
			return default((Id32<IMGRICEYMPU<FFTLZZJTBOR>>, Id32<IMGRICEYMPU<HFAOHXLHBSJ>>, Id32<IMGRICEYMPU<IMAAHXSZDBK<HFAOHXLHBSJ>>>, Id32<IMGRICEYMPU<IMAAHXSZDBK<JBNFXJGCZAM>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x289D040", Offset = "0x289BC40", VA = "0x18289D040")]
		public static (Id32<IMGRICEYMPU<FFTLZZJTBOR>>, Id32<IMGRICEYMPU<IMAAHXSZDBK<HFAOHXLHBSJ>>>, Id32<IMGRICEYMPU<IMAAHXSZDBK<HFAOHXLHBSJ>>>, Id32<IMGRICEYMPU<IMAAHXSZDBK<JBNFXJGCZAM>>>) QNMOJRMIKYS(this UnsafeList<byte> a, [Optional] Id32<IMAAHXSZDBK<HFAOHXLHBSJ>>? b, [Optional] Id32<IMAAHXSZDBK<HFAOHXLHBSJ>>? c, [Optional] Id32<IMAAHXSZDBK<JBNFXJGCZAM>>? d)
		{
			return default((Id32<IMGRICEYMPU<FFTLZZJTBOR>>, Id32<IMGRICEYMPU<IMAAHXSZDBK<HFAOHXLHBSJ>>>, Id32<IMGRICEYMPU<IMAAHXSZDBK<HFAOHXLHBSJ>>>, Id32<IMGRICEYMPU<IMAAHXSZDBK<JBNFXJGCZAM>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x289C210", Offset = "0x289AE10", VA = "0x18289C210")]
		public static (Id32<IMGRICEYMPU<FFTLZZJTBOR>>, Id32<IMGRICEYMPU<JBNFXJGCZAM>>, Id32<IMGRICEYMPU<JBNFXJGCZAM>>, Id32<IMGRICEYMPU<IMAAHXSZDBK<JBNFXJGCZAM>>>) MMDEFWUUMVT(this UnsafeList<byte> a, int b, int c, [Optional] Id32<IMAAHXSZDBK<JBNFXJGCZAM>>? d)
		{
			return default((Id32<IMGRICEYMPU<FFTLZZJTBOR>>, Id32<IMGRICEYMPU<JBNFXJGCZAM>>, Id32<IMGRICEYMPU<JBNFXJGCZAM>>, Id32<IMGRICEYMPU<IMAAHXSZDBK<JBNFXJGCZAM>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x289C480", Offset = "0x289B080", VA = "0x18289C480")]
		public static (Id32<IMGRICEYMPU<FFTLZZJTBOR>>, Id32<IMGRICEYMPU<JBNFXJGCZAM>>, Id32<IMGRICEYMPU<IMAAHXSZDBK<JBNFXJGCZAM>>>, Id32<IMGRICEYMPU<IMAAHXSZDBK<JBNFXJGCZAM>>>) NEDYASRZRBE(this UnsafeList<byte> a, int b, [Optional] Id32<IMAAHXSZDBK<JBNFXJGCZAM>>? c, [Optional] Id32<IMAAHXSZDBK<JBNFXJGCZAM>>? d)
		{
			return default((Id32<IMGRICEYMPU<FFTLZZJTBOR>>, Id32<IMGRICEYMPU<JBNFXJGCZAM>>, Id32<IMGRICEYMPU<IMAAHXSZDBK<JBNFXJGCZAM>>>, Id32<IMGRICEYMPU<IMAAHXSZDBK<JBNFXJGCZAM>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x289AC10", Offset = "0x2899810", VA = "0x18289AC10")]
		public static (Id32<IMGRICEYMPU<FFTLZZJTBOR>>, Id32<IMGRICEYMPU<IMAAHXSZDBK<JBNFXJGCZAM>>>, Id32<IMGRICEYMPU<IMAAHXSZDBK<JBNFXJGCZAM>>>, Id32<IMGRICEYMPU<IMAAHXSZDBK<JBNFXJGCZAM>>>) GJPJSHGIAZN(this UnsafeList<byte> a, [Optional] Id32<IMAAHXSZDBK<JBNFXJGCZAM>>? b, [Optional] Id32<IMAAHXSZDBK<JBNFXJGCZAM>>? c, [Optional] Id32<IMAAHXSZDBK<JBNFXJGCZAM>>? d)
		{
			return default((Id32<IMGRICEYMPU<FFTLZZJTBOR>>, Id32<IMGRICEYMPU<IMAAHXSZDBK<JBNFXJGCZAM>>>, Id32<IMGRICEYMPU<IMAAHXSZDBK<JBNFXJGCZAM>>>, Id32<IMGRICEYMPU<IMAAHXSZDBK<JBNFXJGCZAM>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x289BEB0", Offset = "0x289AAB0", VA = "0x18289BEB0")]
		public static (Id32<IMGRICEYMPU<FFTLZZJTBOR>>, Id32<IMGRICEYMPU<HFAOHXLHBSJ>>, Id32<IMGRICEYMPU<HFAOHXLHBSJ>>, Id32<IMGRICEYMPU<IMAAHXSZDBK<JBNFXJGCZAM>>>) KZNMORJFMVC(this UnsafeList<byte> a, float b, float c, [Optional] Id32<IMAAHXSZDBK<JBNFXJGCZAM>>? d)
		{
			return default((Id32<IMGRICEYMPU<FFTLZZJTBOR>>, Id32<IMGRICEYMPU<HFAOHXLHBSJ>>, Id32<IMGRICEYMPU<HFAOHXLHBSJ>>, Id32<IMGRICEYMPU<IMAAHXSZDBK<JBNFXJGCZAM>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x289C030", Offset = "0x289AC30", VA = "0x18289C030")]
		public static (Id32<IMGRICEYMPU<FFTLZZJTBOR>>, Id32<IMGRICEYMPU<HFAOHXLHBSJ>>, Id32<IMGRICEYMPU<IMAAHXSZDBK<HFAOHXLHBSJ>>>, Id32<IMGRICEYMPU<IMAAHXSZDBK<JBNFXJGCZAM>>>) LCPPRSZCMHF(this UnsafeList<byte> a, float b, [Optional] Id32<IMAAHXSZDBK<HFAOHXLHBSJ>>? c, [Optional] Id32<IMAAHXSZDBK<JBNFXJGCZAM>>? d)
		{
			return default((Id32<IMGRICEYMPU<FFTLZZJTBOR>>, Id32<IMGRICEYMPU<HFAOHXLHBSJ>>, Id32<IMGRICEYMPU<IMAAHXSZDBK<HFAOHXLHBSJ>>>, Id32<IMGRICEYMPU<IMAAHXSZDBK<JBNFXJGCZAM>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x289A850", Offset = "0x2899450", VA = "0x18289A850")]
		public static (Id32<IMGRICEYMPU<FFTLZZJTBOR>>, Id32<IMGRICEYMPU<IMAAHXSZDBK<HFAOHXLHBSJ>>>, Id32<IMGRICEYMPU<IMAAHXSZDBK<HFAOHXLHBSJ>>>, Id32<IMGRICEYMPU<IMAAHXSZDBK<JBNFXJGCZAM>>>) FARXUPVSNYK(this UnsafeList<byte> a, [Optional] Id32<IMAAHXSZDBK<HFAOHXLHBSJ>>? b, [Optional] Id32<IMAAHXSZDBK<HFAOHXLHBSJ>>? c, [Optional] Id32<IMAAHXSZDBK<JBNFXJGCZAM>>? d)
		{
			return default((Id32<IMGRICEYMPU<FFTLZZJTBOR>>, Id32<IMGRICEYMPU<IMAAHXSZDBK<HFAOHXLHBSJ>>>, Id32<IMGRICEYMPU<IMAAHXSZDBK<HFAOHXLHBSJ>>>, Id32<IMGRICEYMPU<IMAAHXSZDBK<JBNFXJGCZAM>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x289EA20", Offset = "0x289D620", VA = "0x18289EA20")]
		public static (Id32<IMGRICEYMPU<FFTLZZJTBOR>>, Id32<IMGRICEYMPU<JBNFXJGCZAM>>, Id32<IMGRICEYMPU<JBNFXJGCZAM>>, Id32<IMGRICEYMPU<IMAAHXSZDBK<JBNFXJGCZAM>>>) XSAKBELOFZD(this UnsafeList<byte> a, int b, int c, [Optional] Id32<IMAAHXSZDBK<JBNFXJGCZAM>>? d)
		{
			return default((Id32<IMGRICEYMPU<FFTLZZJTBOR>>, Id32<IMGRICEYMPU<JBNFXJGCZAM>>, Id32<IMGRICEYMPU<JBNFXJGCZAM>>, Id32<IMGRICEYMPU<IMAAHXSZDBK<JBNFXJGCZAM>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x289B110", Offset = "0x2899D10", VA = "0x18289B110")]
		public static (Id32<IMGRICEYMPU<FFTLZZJTBOR>>, Id32<IMGRICEYMPU<JBNFXJGCZAM>>, Id32<IMGRICEYMPU<IMAAHXSZDBK<JBNFXJGCZAM>>>, Id32<IMGRICEYMPU<IMAAHXSZDBK<JBNFXJGCZAM>>>) HREGOCNRXWW(this UnsafeList<byte> a, int b, [Optional] Id32<IMAAHXSZDBK<JBNFXJGCZAM>>? c, [Optional] Id32<IMAAHXSZDBK<JBNFXJGCZAM>>? d)
		{
			return default((Id32<IMGRICEYMPU<FFTLZZJTBOR>>, Id32<IMGRICEYMPU<JBNFXJGCZAM>>, Id32<IMGRICEYMPU<IMAAHXSZDBK<JBNFXJGCZAM>>>, Id32<IMGRICEYMPU<IMAAHXSZDBK<JBNFXJGCZAM>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x289EB80", Offset = "0x289D780", VA = "0x18289EB80")]
		public static (Id32<IMGRICEYMPU<FFTLZZJTBOR>>, Id32<IMGRICEYMPU<IMAAHXSZDBK<JBNFXJGCZAM>>>, Id32<IMGRICEYMPU<IMAAHXSZDBK<JBNFXJGCZAM>>>, Id32<IMGRICEYMPU<IMAAHXSZDBK<JBNFXJGCZAM>>>) XYVLNUPWSTN(this UnsafeList<byte> a, [Optional] Id32<IMAAHXSZDBK<JBNFXJGCZAM>>? b, [Optional] Id32<IMAAHXSZDBK<JBNFXJGCZAM>>? c, [Optional] Id32<IMAAHXSZDBK<JBNFXJGCZAM>>? d)
		{
			return default((Id32<IMGRICEYMPU<FFTLZZJTBOR>>, Id32<IMGRICEYMPU<IMAAHXSZDBK<JBNFXJGCZAM>>>, Id32<IMGRICEYMPU<IMAAHXSZDBK<JBNFXJGCZAM>>>, Id32<IMGRICEYMPU<IMAAHXSZDBK<JBNFXJGCZAM>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x289E380", Offset = "0x289CF80", VA = "0x18289E380")]
		public static (Id32<IMGRICEYMPU<FFTLZZJTBOR>>, Id32<IMGRICEYMPU<HFAOHXLHBSJ>>, Id32<IMGRICEYMPU<HFAOHXLHBSJ>>, Id32<IMGRICEYMPU<IMAAHXSZDBK<JBNFXJGCZAM>>>) VBNBDXWBQUL(this UnsafeList<byte> a, float b, float c, [Optional] Id32<IMAAHXSZDBK<JBNFXJGCZAM>>? d)
		{
			return default((Id32<IMGRICEYMPU<FFTLZZJTBOR>>, Id32<IMGRICEYMPU<HFAOHXLHBSJ>>, Id32<IMGRICEYMPU<HFAOHXLHBSJ>>, Id32<IMGRICEYMPU<IMAAHXSZDBK<JBNFXJGCZAM>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x289E8C0", Offset = "0x289D4C0", VA = "0x18289E8C0")]
		public static (Id32<IMGRICEYMPU<FFTLZZJTBOR>>, Id32<IMGRICEYMPU<HFAOHXLHBSJ>>, Id32<IMGRICEYMPU<IMAAHXSZDBK<HFAOHXLHBSJ>>>, Id32<IMGRICEYMPU<IMAAHXSZDBK<JBNFXJGCZAM>>>) XRTWOZCGBKE(this UnsafeList<byte> a, float b, [Optional] Id32<IMAAHXSZDBK<HFAOHXLHBSJ>>? c, [Optional] Id32<IMAAHXSZDBK<JBNFXJGCZAM>>? d)
		{
			return default((Id32<IMGRICEYMPU<FFTLZZJTBOR>>, Id32<IMGRICEYMPU<HFAOHXLHBSJ>>, Id32<IMGRICEYMPU<IMAAHXSZDBK<HFAOHXLHBSJ>>>, Id32<IMGRICEYMPU<IMAAHXSZDBK<JBNFXJGCZAM>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x289DC00", Offset = "0x289C800", VA = "0x18289DC00")]
		public static (Id32<IMGRICEYMPU<FFTLZZJTBOR>>, Id32<IMGRICEYMPU<IMAAHXSZDBK<HFAOHXLHBSJ>>>, Id32<IMGRICEYMPU<IMAAHXSZDBK<HFAOHXLHBSJ>>>, Id32<IMGRICEYMPU<IMAAHXSZDBK<JBNFXJGCZAM>>>) TSIRKSMDXMZ(this UnsafeList<byte> a, [Optional] Id32<IMAAHXSZDBK<HFAOHXLHBSJ>>? b, [Optional] Id32<IMAAHXSZDBK<HFAOHXLHBSJ>>? c, [Optional] Id32<IMAAHXSZDBK<JBNFXJGCZAM>>? d)
		{
			return default((Id32<IMGRICEYMPU<FFTLZZJTBOR>>, Id32<IMGRICEYMPU<IMAAHXSZDBK<HFAOHXLHBSJ>>>, Id32<IMGRICEYMPU<IMAAHXSZDBK<HFAOHXLHBSJ>>>, Id32<IMGRICEYMPU<IMAAHXSZDBK<JBNFXJGCZAM>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x289B9B0", Offset = "0x289A5B0", VA = "0x18289B9B0")]
		public static (Id32<IMGRICEYMPU<FFTLZZJTBOR>>, Id32<IMGRICEYMPU<JBNFXJGCZAM>>, Id32<IMGRICEYMPU<JBNFXJGCZAM>>, Id32<IMGRICEYMPU<IMAAHXSZDBK<JBNFXJGCZAM>>>) KIOPPZONODU(this UnsafeList<byte> a, int b, int c, [Optional] Id32<IMAAHXSZDBK<JBNFXJGCZAM>>? d)
		{
			return default((Id32<IMGRICEYMPU<FFTLZZJTBOR>>, Id32<IMGRICEYMPU<JBNFXJGCZAM>>, Id32<IMGRICEYMPU<JBNFXJGCZAM>>, Id32<IMGRICEYMPU<IMAAHXSZDBK<JBNFXJGCZAM>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x289E500", Offset = "0x289D100", VA = "0x18289E500")]
		public static (Id32<IMGRICEYMPU<FFTLZZJTBOR>>, Id32<IMGRICEYMPU<JBNFXJGCZAM>>, Id32<IMGRICEYMPU<IMAAHXSZDBK<JBNFXJGCZAM>>>, Id32<IMGRICEYMPU<IMAAHXSZDBK<JBNFXJGCZAM>>>) WVYXFGABEMN(this UnsafeList<byte> a, int b, [Optional] Id32<IMAAHXSZDBK<JBNFXJGCZAM>>? c, [Optional] Id32<IMAAHXSZDBK<JBNFXJGCZAM>>? d)
		{
			return default((Id32<IMGRICEYMPU<FFTLZZJTBOR>>, Id32<IMGRICEYMPU<JBNFXJGCZAM>>, Id32<IMGRICEYMPU<IMAAHXSZDBK<JBNFXJGCZAM>>>, Id32<IMGRICEYMPU<IMAAHXSZDBK<JBNFXJGCZAM>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x289D450", Offset = "0x289C050", VA = "0x18289D450")]
		public static (Id32<IMGRICEYMPU<FFTLZZJTBOR>>, Id32<IMGRICEYMPU<IMAAHXSZDBK<JBNFXJGCZAM>>>, Id32<IMGRICEYMPU<IMAAHXSZDBK<JBNFXJGCZAM>>>, Id32<IMGRICEYMPU<IMAAHXSZDBK<JBNFXJGCZAM>>>) RUODTQHJNNW(this UnsafeList<byte> a, [Optional] Id32<IMAAHXSZDBK<JBNFXJGCZAM>>? b, [Optional] Id32<IMAAHXSZDBK<JBNFXJGCZAM>>? c, [Optional] Id32<IMAAHXSZDBK<JBNFXJGCZAM>>? d)
		{
			return default((Id32<IMGRICEYMPU<FFTLZZJTBOR>>, Id32<IMGRICEYMPU<IMAAHXSZDBK<JBNFXJGCZAM>>>, Id32<IMGRICEYMPU<IMAAHXSZDBK<JBNFXJGCZAM>>>, Id32<IMGRICEYMPU<IMAAHXSZDBK<JBNFXJGCZAM>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x2899A30", Offset = "0x2898630", VA = "0x182899A30")]
		public static (Id32<IMGRICEYMPU<FFTLZZJTBOR>>, Id32<IMGRICEYMPU<HFAOHXLHBSJ>>, Id32<IMGRICEYMPU<HFAOHXLHBSJ>>, Id32<IMGRICEYMPU<IMAAHXSZDBK<HFAOHXLHBSJ>>>) BCEVRKLPLOG(this UnsafeList<byte> a, float b, float c, [Optional] Id32<IMAAHXSZDBK<HFAOHXLHBSJ>>? d)
		{
			return default((Id32<IMGRICEYMPU<FFTLZZJTBOR>>, Id32<IMGRICEYMPU<HFAOHXLHBSJ>>, Id32<IMGRICEYMPU<HFAOHXLHBSJ>>, Id32<IMGRICEYMPU<IMAAHXSZDBK<HFAOHXLHBSJ>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x289A330", Offset = "0x2898F30", VA = "0x18289A330")]
		public static (Id32<IMGRICEYMPU<FFTLZZJTBOR>>, Id32<IMGRICEYMPU<HFAOHXLHBSJ>>, Id32<IMGRICEYMPU<IMAAHXSZDBK<HFAOHXLHBSJ>>>, Id32<IMGRICEYMPU<IMAAHXSZDBK<HFAOHXLHBSJ>>>) DKGFAGHWVPH(this UnsafeList<byte> a, float b, [Optional] Id32<IMAAHXSZDBK<HFAOHXLHBSJ>>? c, [Optional] Id32<IMAAHXSZDBK<HFAOHXLHBSJ>>? d)
		{
			return default((Id32<IMGRICEYMPU<FFTLZZJTBOR>>, Id32<IMGRICEYMPU<HFAOHXLHBSJ>>, Id32<IMGRICEYMPU<IMAAHXSZDBK<HFAOHXLHBSJ>>>, Id32<IMGRICEYMPU<IMAAHXSZDBK<HFAOHXLHBSJ>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x289CF20", Offset = "0x289BB20", VA = "0x18289CF20")]
		public static (Id32<IMGRICEYMPU<FFTLZZJTBOR>>, Id32<IMGRICEYMPU<IMAAHXSZDBK<HFAOHXLHBSJ>>>, Id32<IMGRICEYMPU<IMAAHXSZDBK<HFAOHXLHBSJ>>>, Id32<IMGRICEYMPU<IMAAHXSZDBK<HFAOHXLHBSJ>>>) QMAHQGPXUKI(this UnsafeList<byte> a, [Optional] Id32<IMAAHXSZDBK<HFAOHXLHBSJ>>? b, [Optional] Id32<IMAAHXSZDBK<HFAOHXLHBSJ>>? c, [Optional] Id32<IMAAHXSZDBK<HFAOHXLHBSJ>>? d)
		{
			return default((Id32<IMGRICEYMPU<FFTLZZJTBOR>>, Id32<IMGRICEYMPU<IMAAHXSZDBK<HFAOHXLHBSJ>>>, Id32<IMGRICEYMPU<IMAAHXSZDBK<HFAOHXLHBSJ>>>, Id32<IMGRICEYMPU<IMAAHXSZDBK<HFAOHXLHBSJ>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x289B260", Offset = "0x2899E60", VA = "0x18289B260")]
		public static (Id32<IMGRICEYMPU<FFTLZZJTBOR>>, Id32<IMGRICEYMPU<JBNFXJGCZAM>>, Id32<IMGRICEYMPU<JBNFXJGCZAM>>, Id32<IMGRICEYMPU<IMAAHXSZDBK<JBNFXJGCZAM>>>) HTOALJLDSGY(this UnsafeList<byte> a, int b, int c, [Optional] Id32<IMAAHXSZDBK<JBNFXJGCZAM>>? d)
		{
			return default((Id32<IMGRICEYMPU<FFTLZZJTBOR>>, Id32<IMGRICEYMPU<JBNFXJGCZAM>>, Id32<IMGRICEYMPU<JBNFXJGCZAM>>, Id32<IMGRICEYMPU<IMAAHXSZDBK<JBNFXJGCZAM>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x289E650", Offset = "0x289D250", VA = "0x18289E650")]
		public static (Id32<IMGRICEYMPU<FFTLZZJTBOR>>, Id32<IMGRICEYMPU<JBNFXJGCZAM>>, Id32<IMGRICEYMPU<IMAAHXSZDBK<JBNFXJGCZAM>>>, Id32<IMGRICEYMPU<IMAAHXSZDBK<JBNFXJGCZAM>>>) XALPMNANZVF(this UnsafeList<byte> a, int b, [Optional] Id32<IMAAHXSZDBK<JBNFXJGCZAM>>? c, [Optional] Id32<IMAAHXSZDBK<JBNFXJGCZAM>>? d)
		{
			return default((Id32<IMGRICEYMPU<FFTLZZJTBOR>>, Id32<IMGRICEYMPU<JBNFXJGCZAM>>, Id32<IMGRICEYMPU<IMAAHXSZDBK<JBNFXJGCZAM>>>, Id32<IMGRICEYMPU<IMAAHXSZDBK<JBNFXJGCZAM>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x289A5E0", Offset = "0x28991E0", VA = "0x18289A5E0")]
		public static (Id32<IMGRICEYMPU<FFTLZZJTBOR>>, Id32<IMGRICEYMPU<IMAAHXSZDBK<JBNFXJGCZAM>>>, Id32<IMGRICEYMPU<IMAAHXSZDBK<JBNFXJGCZAM>>>, Id32<IMGRICEYMPU<IMAAHXSZDBK<JBNFXJGCZAM>>>) DSPONEYVGHA(this UnsafeList<byte> a, [Optional] Id32<IMAAHXSZDBK<JBNFXJGCZAM>>? b, [Optional] Id32<IMAAHXSZDBK<JBNFXJGCZAM>>? c, [Optional] Id32<IMAAHXSZDBK<JBNFXJGCZAM>>? d)
		{
			return default((Id32<IMGRICEYMPU<FFTLZZJTBOR>>, Id32<IMGRICEYMPU<IMAAHXSZDBK<JBNFXJGCZAM>>>, Id32<IMGRICEYMPU<IMAAHXSZDBK<JBNFXJGCZAM>>>, Id32<IMGRICEYMPU<IMAAHXSZDBK<JBNFXJGCZAM>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x289B750", Offset = "0x289A350", VA = "0x18289B750")]
		public static (Id32<IMGRICEYMPU<FFTLZZJTBOR>>, Id32<IMGRICEYMPU<JBNFXJGCZAM>>, Id32<IMGRICEYMPU<IMAAHXSZDBK<JBNFXJGCZAM>>>) JUJQRRIXNZF(this UnsafeList<byte> a, [Optional] int? b, [Optional] Id32<IMAAHXSZDBK<JBNFXJGCZAM>>? c)
		{
			return default((Id32<IMGRICEYMPU<FFTLZZJTBOR>>, Id32<IMGRICEYMPU<JBNFXJGCZAM>>, Id32<IMGRICEYMPU<IMAAHXSZDBK<JBNFXJGCZAM>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x289C370", Offset = "0x289AF70", VA = "0x18289C370")]
		public static (Id32<IMGRICEYMPU<FFTLZZJTBOR>>, Id32<IMGRICEYMPU<IMAAHXSZDBK<JBNFXJGCZAM>>>, Id32<IMGRICEYMPU<IMAAHXSZDBK<JBNFXJGCZAM>>>) NDRQIZFUNSE(this UnsafeList<byte> a, [Optional] Id32<IMAAHXSZDBK<JBNFXJGCZAM>>? b, [Optional] Id32<IMAAHXSZDBK<JBNFXJGCZAM>>? c)
		{
			return default((Id32<IMGRICEYMPU<FFTLZZJTBOR>>, Id32<IMGRICEYMPU<IMAAHXSZDBK<JBNFXJGCZAM>>>, Id32<IMGRICEYMPU<IMAAHXSZDBK<JBNFXJGCZAM>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x289C190", Offset = "0x289AD90", VA = "0x18289C190")]
		public static Id32<IMGRICEYMPU<FFTLZZJTBOR>> MHWSGFSWCPP(this UnsafeList<byte> a)
		{
			return default(Id32<IMGRICEYMPU<FFTLZZJTBOR>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x289C860", Offset = "0x289B460", VA = "0x18289C860")]
		public static (Id32<IMGRICEYMPU<FFTLZZJTBOR>>, Id32<IMGRICEYMPU<HFAOHXLHBSJ>>, Id32<IMGRICEYMPU<HFAOHXLHBSJ>>, Id32<IMGRICEYMPU<IMAAHXSZDBK<HFAOHXLHBSJ>>>) OHSOXQYLJHY(this UnsafeList<byte> a, float b, float c, [Optional] Id32<IMAAHXSZDBK<HFAOHXLHBSJ>>? d)
		{
			return default((Id32<IMGRICEYMPU<FFTLZZJTBOR>>, Id32<IMGRICEYMPU<HFAOHXLHBSJ>>, Id32<IMGRICEYMPU<HFAOHXLHBSJ>>, Id32<IMGRICEYMPU<IMAAHXSZDBK<HFAOHXLHBSJ>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x2899BB0", Offset = "0x28987B0", VA = "0x182899BB0")]
		public static (Id32<IMGRICEYMPU<FFTLZZJTBOR>>, Id32<IMGRICEYMPU<HFAOHXLHBSJ>>, Id32<IMGRICEYMPU<IMAAHXSZDBK<HFAOHXLHBSJ>>>, Id32<IMGRICEYMPU<IMAAHXSZDBK<HFAOHXLHBSJ>>>) CISYLGPFUHH(this UnsafeList<byte> a, float b, [Optional] Id32<IMAAHXSZDBK<HFAOHXLHBSJ>>? c, [Optional] Id32<IMAAHXSZDBK<HFAOHXLHBSJ>>? d)
		{
			return default((Id32<IMGRICEYMPU<FFTLZZJTBOR>>, Id32<IMGRICEYMPU<HFAOHXLHBSJ>>, Id32<IMGRICEYMPU<IMAAHXSZDBK<HFAOHXLHBSJ>>>, Id32<IMGRICEYMPU<IMAAHXSZDBK<HFAOHXLHBSJ>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x289DE80", Offset = "0x289CA80", VA = "0x18289DE80")]
		public static (Id32<IMGRICEYMPU<FFTLZZJTBOR>>, Id32<IMGRICEYMPU<IMAAHXSZDBK<HFAOHXLHBSJ>>>, Id32<IMGRICEYMPU<IMAAHXSZDBK<HFAOHXLHBSJ>>>, Id32<IMGRICEYMPU<IMAAHXSZDBK<HFAOHXLHBSJ>>>) UDNDRPVSEQY(this UnsafeList<byte> a, [Optional] Id32<IMAAHXSZDBK<HFAOHXLHBSJ>>? b, [Optional] Id32<IMAAHXSZDBK<HFAOHXLHBSJ>>? c, [Optional] Id32<IMAAHXSZDBK<HFAOHXLHBSJ>>? d)
		{
			return default((Id32<IMGRICEYMPU<FFTLZZJTBOR>>, Id32<IMGRICEYMPU<IMAAHXSZDBK<HFAOHXLHBSJ>>>, Id32<IMGRICEYMPU<IMAAHXSZDBK<HFAOHXLHBSJ>>>, Id32<IMGRICEYMPU<IMAAHXSZDBK<HFAOHXLHBSJ>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x289AD30", Offset = "0x2899930", VA = "0x18289AD30")]
		public static (Id32<IMGRICEYMPU<FFTLZZJTBOR>>, Id32<IMGRICEYMPU<JBNFXJGCZAM>>, Id32<IMGRICEYMPU<JBNFXJGCZAM>>, Id32<IMGRICEYMPU<IMAAHXSZDBK<JBNFXJGCZAM>>>) GNGPZCFKKEY(this UnsafeList<byte> a, int b, int c, [Optional] Id32<IMAAHXSZDBK<JBNFXJGCZAM>>? d)
		{
			return default((Id32<IMGRICEYMPU<FFTLZZJTBOR>>, Id32<IMGRICEYMPU<JBNFXJGCZAM>>, Id32<IMGRICEYMPU<JBNFXJGCZAM>>, Id32<IMGRICEYMPU<IMAAHXSZDBK<JBNFXJGCZAM>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x289D6D0", Offset = "0x289C2D0", VA = "0x18289D6D0")]
		public static (Id32<IMGRICEYMPU<FFTLZZJTBOR>>, Id32<IMGRICEYMPU<JBNFXJGCZAM>>, Id32<IMGRICEYMPU<IMAAHXSZDBK<JBNFXJGCZAM>>>, Id32<IMGRICEYMPU<IMAAHXSZDBK<JBNFXJGCZAM>>>) SHPDVVNQSUH(this UnsafeList<byte> a, int b, [Optional] Id32<IMAAHXSZDBK<JBNFXJGCZAM>>? c, [Optional] Id32<IMAAHXSZDBK<JBNFXJGCZAM>>? d)
		{
			return default((Id32<IMGRICEYMPU<FFTLZZJTBOR>>, Id32<IMGRICEYMPU<JBNFXJGCZAM>>, Id32<IMGRICEYMPU<IMAAHXSZDBK<JBNFXJGCZAM>>>, Id32<IMGRICEYMPU<IMAAHXSZDBK<JBNFXJGCZAM>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x289DAE0", Offset = "0x289C6E0", VA = "0x18289DAE0")]
		public static (Id32<IMGRICEYMPU<FFTLZZJTBOR>>, Id32<IMGRICEYMPU<IMAAHXSZDBK<JBNFXJGCZAM>>>, Id32<IMGRICEYMPU<IMAAHXSZDBK<JBNFXJGCZAM>>>, Id32<IMGRICEYMPU<IMAAHXSZDBK<JBNFXJGCZAM>>>) SXGXRGDDTYG(this UnsafeList<byte> a, [Optional] Id32<IMAAHXSZDBK<JBNFXJGCZAM>>? b, [Optional] Id32<IMAAHXSZDBK<JBNFXJGCZAM>>? c, [Optional] Id32<IMAAHXSZDBK<JBNFXJGCZAM>>? d)
		{
			return default((Id32<IMGRICEYMPU<FFTLZZJTBOR>>, Id32<IMGRICEYMPU<IMAAHXSZDBK<JBNFXJGCZAM>>>, Id32<IMGRICEYMPU<IMAAHXSZDBK<JBNFXJGCZAM>>>, Id32<IMGRICEYMPU<IMAAHXSZDBK<JBNFXJGCZAM>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x289DFA0", Offset = "0x289CBA0", VA = "0x18289DFA0")]
		public static (Id32<IMGRICEYMPU<FFTLZZJTBOR>>, Id32<IMGRICEYMPU<JBNFXJGCZAM>>, Id32<IMGRICEYMPU<JBNFXJGCZAM>>, Id32<IMGRICEYMPU<IMAAHXSZDBK<JBNFXJGCZAM>>>) UJLVRFZXIGX(this UnsafeList<byte> a, int b, int c, [Optional] Id32<IMAAHXSZDBK<JBNFXJGCZAM>>? d)
		{
			return default((Id32<IMGRICEYMPU<FFTLZZJTBOR>>, Id32<IMGRICEYMPU<JBNFXJGCZAM>>, Id32<IMGRICEYMPU<JBNFXJGCZAM>>, Id32<IMGRICEYMPU<IMAAHXSZDBK<JBNFXJGCZAM>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x28997C0", Offset = "0x28983C0", VA = "0x1828997C0")]
		public static (Id32<IMGRICEYMPU<FFTLZZJTBOR>>, Id32<IMGRICEYMPU<JBNFXJGCZAM>>, Id32<IMGRICEYMPU<IMAAHXSZDBK<JBNFXJGCZAM>>>, Id32<IMGRICEYMPU<IMAAHXSZDBK<JBNFXJGCZAM>>>) APUIKUXZVJG(this UnsafeList<byte> a, int b, [Optional] Id32<IMAAHXSZDBK<JBNFXJGCZAM>>? c, [Optional] Id32<IMAAHXSZDBK<JBNFXJGCZAM>>? d)
		{
			return default((Id32<IMGRICEYMPU<FFTLZZJTBOR>>, Id32<IMGRICEYMPU<JBNFXJGCZAM>>, Id32<IMGRICEYMPU<IMAAHXSZDBK<JBNFXJGCZAM>>>, Id32<IMGRICEYMPU<IMAAHXSZDBK<JBNFXJGCZAM>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x289ECA0", Offset = "0x289D8A0", VA = "0x18289ECA0")]
		public static (Id32<IMGRICEYMPU<FFTLZZJTBOR>>, Id32<IMGRICEYMPU<IMAAHXSZDBK<JBNFXJGCZAM>>>, Id32<IMGRICEYMPU<IMAAHXSZDBK<JBNFXJGCZAM>>>, Id32<IMGRICEYMPU<IMAAHXSZDBK<JBNFXJGCZAM>>>) YDHSMFZLFKV(this UnsafeList<byte> a, [Optional] Id32<IMAAHXSZDBK<JBNFXJGCZAM>>? b, [Optional] Id32<IMAAHXSZDBK<JBNFXJGCZAM>>? c, [Optional] Id32<IMAAHXSZDBK<JBNFXJGCZAM>>? d)
		{
			return default((Id32<IMGRICEYMPU<FFTLZZJTBOR>>, Id32<IMGRICEYMPU<IMAAHXSZDBK<JBNFXJGCZAM>>>, Id32<IMGRICEYMPU<IMAAHXSZDBK<JBNFXJGCZAM>>>, Id32<IMGRICEYMPU<IMAAHXSZDBK<JBNFXJGCZAM>>>));
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
