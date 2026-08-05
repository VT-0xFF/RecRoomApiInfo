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
		[Cpp2IlInjected.Address(RVA = "0x29327B0", Offset = "0x29315B0", VA = "0x1829327B0")]
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
namespace Circuits.Shared.Core.ByteCode
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public static class ORFDXBOITGH
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x39786A0", Offset = "0x39774A0", VA = "0x1839786A0")]
		public static Id32<XTKEAPQLAYR<a>> QIQQHZPWXRF<a>(this int a)
		{
			return default(Id32<XTKEAPQLAYR<a>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x2932830", Offset = "0x2931630", VA = "0x182932830")]
		public static Id32<PIICLSZAHGS> SYKCISZPZTS(this int a)
		{
			return default(Id32<PIICLSZAHGS>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x39786A0", Offset = "0x39774A0", VA = "0x1839786A0")]
		public static Id32<BPTUUJZBQIH<b>> UZAIXLGCOBD<b>(this int a)
		{
			return default(Id32<BPTUUJZBQIH<b>>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public sealed class XTKEAPQLAYR<a>
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public sealed class ELPJGPWQKEO
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public sealed class WEGIHCAWWIL
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public sealed class PIICLSZAHGS
	{
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public sealed class YMMBJBIAQGE
	{
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public sealed class JGUTABHGOJQ
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
	public static class ILDWOLBNSVP
	{
		[Cpp2IlInjected.Token(Token = "0x200000E")]
		public readonly struct ProcessOpDelegate<TContext, TDeps, TCompileState>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000091")]
			private readonly IntPtr _impl;

			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0xC9F870", Offset = "0xC9E670", VA = "0x180C9F870")]
			public ProcessOpDelegate(IntPtr impl)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x5C9C9B0", Offset = "0x5C9B7B0", VA = "0x185C9C9B0")]
			public int Invoke(TDeps deps, TContext ctx, TCompileState compileState, [In] UnsafeList<byte> fromByteCode, int byteCodePtr)
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x37DA2C0", Offset = "0x37D90C0", VA = "0x1837DA2C0")]
		public static void ICMUFETVHMC<TDeps, TContext, TCompileState>(TDeps a, TContext b, TCompileState c, [In] UnsafeList<byte> oldByteCode, UnsafeList<byte> newByteCode, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processAddF32_F32i_F32i_F32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processAddF32_F32i_F32r_F32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processAddF32_F32r_F32r_F32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processAddI32_I32i_I32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processAddI32_I32i_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processAddI32_I32r_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processAndI32_I32i_I32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processAndI32_I32i_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processAndI32_I32r_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfEqualF32_F32i_F32i_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfEqualF32_F32i_F32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfEqualF32_F32r_F32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfEqualI32_I32i_I32i_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfEqualI32_I32i_I32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfEqualI32_I32r_I32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfGreaterOrEqualF32_F32i_F32i_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfGreaterOrEqualF32_F32i_F32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfGreaterOrEqualF32_F32r_F32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfGreaterOrEqualI32_I32i_I32i_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfGreaterOrEqualI32_I32i_I32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfGreaterOrEqualI32_I32r_I32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfLessF32_F32i_F32i_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfLessF32_F32i_F32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfLessF32_F32r_F32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfLessI32_I32i_I32i_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfLessI32_I32i_I32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfLessI32_I32r_I32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfLessOrEqualF32_F32i_F32i_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfLessOrEqualF32_F32i_F32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfLessOrEqualF32_F32r_F32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfLessOrEqualI32_I32i_I32i_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfLessOrEqualI32_I32i_I32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfLessOrEqualI32_I32r_I32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfNotEqualF32_F32i_F32i_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfNotEqualF32_F32i_F32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfNotEqualF32_F32r_F32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfNotEqualI32_I32i_I32i_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfNotEqualI32_I32i_I32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfNotEqualI32_I32r_I32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfNotZeroF32_F32i_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfNotZeroF32_F32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfNotZeroI32_I32i_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfNotZeroI32_I32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfZeroF32_F32i_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfZeroF32_F32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfZeroI32_I32i_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfZeroI32_I32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processCallInternal_I32i_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processCallInternal_I32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processCallExternal_I32i_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processCallExternal_I32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processCallRuntime_I32i_I32i_Xi, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processCopyI32_I32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processCopyI32_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processCopyX_Xr_I32i_Xi, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processCopyX_Xr_Xr_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processDivideF32_F32i_F32i_F32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processDivideF32_F32i_F32r_F32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processDivideF32_F32r_F32r_F32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processDivideI32_I32i_I32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processDivideI32_I32i_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processDivideI32_I32r_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processEqualF32_F32i_F32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processEqualF32_F32i_F32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processEqualF32_F32r_F32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processEqualI32_I32i_I32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processEqualI32_I32i_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processEqualI32_I32r_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processEnd, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processGreaterF32_F32i_F32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processGreaterF32_F32i_F32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processGreaterF32_F32r_F32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processGreaterI32_I32i_I32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processGreaterI32_I32i_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processGreaterI32_I32r_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processGreaterOrEqualF32_F32i_F32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processGreaterOrEqualF32_F32i_F32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processGreaterOrEqualF32_F32r_F32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processGreaterOrEqualI32_I32i_I32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processGreaterOrEqualI32_I32i_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processGreaterOrEqualI32_I32r_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processJump_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processJump_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processLessF32_F32i_F32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processLessF32_F32i_F32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processLessF32_F32r_F32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processLessI32_I32i_I32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processLessI32_I32i_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processLessI32_I32r_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processLessOrEqualF32_F32i_F32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processLessOrEqualF32_F32i_F32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processLessOrEqualF32_F32r_F32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processLessOrEqualI32_I32i_I32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processLessOrEqualI32_I32i_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processLessOrEqualI32_I32r_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processModI32_I32i_I32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processModI32_I32i_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processModI32_I32r_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processMultiplyF32_F32i_F32i_F32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processMultiplyF32_F32i_F32r_F32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processMultiplyF32_F32r_F32r_F32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processMultiplyI32_I32i_I32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processMultiplyI32_I32i_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processMultiplyI32_I32r_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processNegateF32_F32i_F32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processNegateF32_F32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processNegateF32_F32r_F32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processNegateI32_I32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processNegateI32_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processNegateI32_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processNoOp, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processNotEqualF32_F32i_F32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processNotEqualF32_F32i_F32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processNotEqualF32_F32r_F32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processNotEqualI32_I32i_I32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processNotEqualI32_I32i_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processNotEqualI32_I32r_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processNotI32_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processNotI32_I32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processNotI32_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processOrI32_I32i_I32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processOrI32_I32i_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processOrI32_I32r_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processReturn, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processStaticCastF32I32_F32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processStaticCastI32F32_I32r_F32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processSubtractF32_F32i_F32i_F32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processSubtractF32_F32i_F32r_F32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processSubtractF32_F32r_F32r_F32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processSubtractI32_I32i_I32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processSubtractI32_I32i_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processSubtractI32_I32r_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processXorI32_I32i_I32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processXorI32_I32i_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processXorI32_I32r_I32r_I32r) where TDeps : notnull where TContext : notnull where TCompileState : notnull
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x292C6A0", Offset = "0x292B4A0", VA = "0x18292C6A0")]
		private static int JIRNDYDHGOY([In] UnsafeList<byte> from, UnsafeList<byte> a, int b, int c)
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public static class LJHGHSVPDBC
	{
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		public static readonly int OVWMHHFFUPI;

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x3846160", Offset = "0x3844F60", VA = "0x183846160")]
		public static Id32<XTKEAPQLAYR<a>> YQXHAMXQGYU<a>([In] this UnsafeList<byte> self)
		{
			return default(Id32<XTKEAPQLAYR<a>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x3846030", Offset = "0x3844E30", VA = "0x183846030")]
		public static Id32<XTKEAPQLAYR<XTKEAPQLAYR<b>>> LTLCUIJDRMP<b>(this UnsafeList<byte> a, [Optional] Id32<XTKEAPQLAYR<b>>? b)
		{
			return default(Id32<XTKEAPQLAYR<XTKEAPQLAYR<b>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x29320E0", Offset = "0x2930EE0", VA = "0x1829320E0")]
		public static Id32<XTKEAPQLAYR<CGBEZEBPUAA>> APDKBYAKJXN(this UnsafeList<byte> a, [Optional] Id32<CGBEZEBPUAA>? b)
		{
			return default(Id32<XTKEAPQLAYR<CGBEZEBPUAA>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x2932590", Offset = "0x2931390", VA = "0x182932590")]
		public static Id32<XTKEAPQLAYR<ELPJGPWQKEO>> TWJKKXUEYCP(this UnsafeList<byte> a, [Optional] float? b)
		{
			return default(Id32<XTKEAPQLAYR<ELPJGPWQKEO>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x29322D0", Offset = "0x29310D0", VA = "0x1829322D0")]
		public static Id32<XTKEAPQLAYR<WEGIHCAWWIL>> CDSLKLPYLYS(this UnsafeList<byte> a, [Optional] int? b)
		{
			return default(Id32<XTKEAPQLAYR<WEGIHCAWWIL>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x29323B0", Offset = "0x29311B0", VA = "0x1829323B0")]
		public static Id32<XTKEAPQLAYR<TMYLYEFQLQF>> LYIZLQWEXVO(this UnsafeList<byte> a, [Optional] Id32<TMYLYEFQLQF>? b)
		{
			return default(Id32<XTKEAPQLAYR<TMYLYEFQLQF>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x29321D0", Offset = "0x2930FD0", VA = "0x1829321D0")]
		public static Id32<XTKEAPQLAYR<JGUTABHGOJQ>> BQRTYREJDOF(this UnsafeList<byte> a, [Optional] byte? b)
		{
			return default(Id32<XTKEAPQLAYR<JGUTABHGOJQ>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x29324A0", Offset = "0x29312A0", VA = "0x1829324A0")]
		public static Id32<XTKEAPQLAYR<PIICLSZAHGS>> ROKCABILNWN(this UnsafeList<byte> a, [Optional] Id32<PIICLSZAHGS>? b)
		{
			return default(Id32<XTKEAPQLAYR<PIICLSZAHGS>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x2932680", Offset = "0x2931480", VA = "0x182932680")]
		public static Id32<XTKEAPQLAYR<YMMBJBIAQGE>> WQLRJOCUQFF(this UnsafeList<byte> a, [Optional] Op? b)
		{
			return default(Id32<XTKEAPQLAYR<YMMBJBIAQGE>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x3846030", Offset = "0x3844E30", VA = "0x183846030")]
		public static Id32<XTKEAPQLAYR<BPTUUJZBQIH<c>>> UCTNCHOQSAF<c>(this UnsafeList<byte> a, [Optional] Id32<BPTUUJZBQIH<c>>? b)
		{
			return default(Id32<XTKEAPQLAYR<BPTUUJZBQIH<c>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x292C550", Offset = "0x292B350", VA = "0x18292C550")]
		public static void TGWVXCEYYFZ(this UnsafeList<byte> a, Id32<XTKEAPQLAYR<WEGIHCAWWIL>> b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x3845F30", Offset = "0x3844D30", VA = "0x183845F30")]
		public static void MYYMZFZLDNI<d>(this UnsafeList<byte> a, Id32<XTKEAPQLAYR<XTKEAPQLAYR<d>>> b, Id32<XTKEAPQLAYR<d>> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x3845F30", Offset = "0x3844D30", VA = "0x183845F30")]
		public static void AXHEAEQEMUM<e>(this UnsafeList<byte> a, Id32<XTKEAPQLAYR<BPTUUJZBQIH<e>>> b, Id32<BPTUUJZBQIH<e>> c)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public static class DOKVGZVIVBP
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x292C630", Offset = "0x292B430", VA = "0x18292C630")]
		public static Union32 AFVYXTXZHPT([In] this ReadOnlySpan<byte> bytes, int a)
		{
			return default(Union32);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x292C590", Offset = "0x292B390", VA = "0x18292C590")]
		public static Union32 AFVYXTXZHPT([In] this UnsafeList<byte> bytes, int a)
		{
			return default(Union32);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x361C920", Offset = "0x361B720", VA = "0x18361C920")]
		public static Union32 AFVYXTXZHPT<f>(this ReadOnlyIdArray<f, byte> a, Id32<f> b)
		{
			return default(Union32);
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x361CB10", Offset = "0x361B910", VA = "0x18361CB10")]
		public static Union32 AFVYXTXZHPT<g>([In] this ReadOnlyIdSpan<g, byte> bytes, Id32<g> a)
		{
			return default(Union32);
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x361C8C0", Offset = "0x361B6C0", VA = "0x18361C8C0")]
		public static Union32 AFVYXTXZHPT<i>(this IdArray<i, byte> a, Id32<i> b)
		{
			return default(Union32);
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x361CAA0", Offset = "0x361B8A0", VA = "0x18361CAA0")]
		public static Union32 AFVYXTXZHPT<j>([In] this IdSpan<j, byte> bytes, Id32<j> a)
		{
			return default(Union32);
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x361CC90", Offset = "0x361BA90", VA = "0x18361CC90")]
		public static Union32 AFVYXTXZHPT<k>(this ReadOnlyIdArray<k, byte> a, Id32<k> b)
		{
			return default(Union32);
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x292C630", Offset = "0x292B430", VA = "0x18292C630")]
		public static int VKXNYZMDHJU([In] this ReadOnlySpan<byte> bytes, int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x292C480", Offset = "0x292B280", VA = "0x18292C480")]
		public static int VKXNYZMDHJU([In] this UnsafeList<byte> bytes, int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x361DBB0", Offset = "0x361C9B0", VA = "0x18361DBB0")]
		public static int VKXNYZMDHJU<p>(this ReadOnlyIdArray<p, byte> a, Id32<p> b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x361DAE0", Offset = "0x361C8E0", VA = "0x18361DAE0")]
		public static int VKXNYZMDHJU<s>(this IdArray<s, byte> a, Id32<s> b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x361DB60", Offset = "0x361C960", VA = "0x18361DB60")]
		public static int VKXNYZMDHJU<t>([In] this IdSpan<t, byte> bytes, Id32<t> a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x361DC00", Offset = "0x361CA00", VA = "0x18361DC00")]
		public static int VKXNYZMDHJU<u>(this ReadOnlyIdArray<u, byte> a, Id32<u> b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x361D460", Offset = "0x361C260", VA = "0x18361D460")]
		public static float QNHLWSFGHZJ<bc>(this IdArray<bc, byte> a, Id32<bc> b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x361D530", Offset = "0x361C330", VA = "0x18361D530")]
		public static float QNHLWSFGHZJ<bd>([In] this IdSpan<bd, byte> bytes, Id32<bd> a)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x361D4E0", Offset = "0x361C2E0", VA = "0x18361D4E0")]
		public static float QNHLWSFGHZJ<be>(this ReadOnlyIdArray<be, byte> a, Id32<be> b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x361D850", Offset = "0x361C650", VA = "0x18361D850")]
		public static byte QPXIVNBENCR<bj>(this ReadOnlyIdArray<bj, byte> a, Id32<bj> b)
		{
			return default(byte);
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x361D6B0", Offset = "0x361C4B0", VA = "0x18361D6B0")]
		public static byte QPXIVNBENCR<bk>([In] this ReadOnlyIdSpan<bk, byte> bytes, Id32<bk> a)
		{
			return default(byte);
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x361D700", Offset = "0x361C500", VA = "0x18361D700")]
		public static byte QPXIVNBENCR<bm>(this IdArray<bm, byte> a, Id32<bm> b)
		{
			return default(byte);
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x361D8A0", Offset = "0x361C6A0", VA = "0x18361D8A0")]
		public static byte QPXIVNBENCR<bn>([In] this IdSpan<bn, byte> bytes, Id32<bn> a)
		{
			return default(byte);
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x361D780", Offset = "0x361C580", VA = "0x18361D780")]
		public static byte QPXIVNBENCR<bo>(this ReadOnlyIdArray<bo, byte> a, Id32<bo> b)
		{
			return default(byte);
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x292C480", Offset = "0x292B280", VA = "0x18292C480")]
		public static Op GYHMMAJINYH([In] this UnsafeList<byte> bytes, int a)
		{
			return default(Op);
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x361CFC0", Offset = "0x361BDC0", VA = "0x18361CFC0")]
		public static Op GYHMMAJINYH<by>(this ReadOnlyIdArray<by, byte> a, Id32<by> b)
		{
			return default(Op);
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x361D2C0", Offset = "0x361C0C0", VA = "0x18361D2C0")]
		public static Id32<XTKEAPQLAYR<HIVQMCLTDUL>> QIMAQRIYWKL<cg>(this IdArray<cg, byte> a, Id32<cg> b)
		{
			return default(Id32<XTKEAPQLAYR<HIVQMCLTDUL>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x361D230", Offset = "0x361C030", VA = "0x18361D230")]
		public static Id32<XTKEAPQLAYR<HIVQMCLTDUL>> QIMAQRIYWKL<ch>([In] this IdSpan<ch, byte> bytes, Id32<ch> a)
		{
			return default(Id32<XTKEAPQLAYR<HIVQMCLTDUL>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x361D1A0", Offset = "0x361BFA0", VA = "0x18361D1A0")]
		public static Id32<XTKEAPQLAYR<HIVQMCLTDUL>> QIMAQRIYWKL<ci>(this ReadOnlyIdArray<ci, byte> a, Id32<ci> b)
		{
			return default(Id32<XTKEAPQLAYR<HIVQMCLTDUL>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x361D9B0", Offset = "0x361C7B0", VA = "0x18361D9B0")]
		public static Id32<BPTUUJZBQIH<HIVQMCLTDUL>> SHIINAEWNEN<cs>(this ReadOnlyIdArray<cs, byte> a, Id32<cs> b)
		{
			return default(Id32<BPTUUJZBQIH<HIVQMCLTDUL>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x361DEE0", Offset = "0x361CCE0", VA = "0x18361DEE0")]
		public static Id32<PIICLSZAHGS> ZLOCAROQVIV<da>(this IdArray<da, byte> a, Id32<da> b)
		{
			return default(Id32<PIICLSZAHGS>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x361DFF0", Offset = "0x361CDF0", VA = "0x18361DFF0")]
		public static Id32<PIICLSZAHGS> ZLOCAROQVIV<db>([In] this IdSpan<db, byte> bytes, Id32<db> a)
		{
			return default(Id32<PIICLSZAHGS>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x361DF60", Offset = "0x361CD60", VA = "0x18361DF60")]
		public static Id32<PIICLSZAHGS> ZLOCAROQVIV<dc>(this ReadOnlyIdArray<dc, byte> a, Id32<dc> b)
		{
			return default(Id32<PIICLSZAHGS>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x361CEE0", Offset = "0x361BCE0", VA = "0x18361CEE0")]
		public static Id32<CGBEZEBPUAA> EASJGHSJFJR<dl>([In] this IdSpan<dl, byte> bytes, Id32<dl> a)
		{
			return default(Id32<CGBEZEBPUAA>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x361CE50", Offset = "0x361BC50", VA = "0x18361CE50")]
		public static Id32<CGBEZEBPUAA> EASJGHSJFJR<dm>(this ReadOnlyIdArray<dm, byte> a, Id32<dm> b)
		{
			return default(Id32<CGBEZEBPUAA>);
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x361DCD0", Offset = "0x361CAD0", VA = "0x18361DCD0")]
		public static Id32<TMYLYEFQLQF> WFFAMIAITBY<dw>(this ReadOnlyIdArray<dw, byte> a, Id32<dw> b)
		{
			return default(Id32<TMYLYEFQLQF>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public static class PHACBWWWDJX
	{
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x29328E0", Offset = "0x29316E0", VA = "0x1829328E0")]
		public static void KWEZWUVWHAM(this UnsafeList<byte> a, int b, Union32 c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x29329A0", Offset = "0x29317A0", VA = "0x1829329A0")]
		public static void KWEZWUVWHAM(this byte[] a, int b, Union32 c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x2932A10", Offset = "0x2931810", VA = "0x182932A10")]
		public static void KWEZWUVWHAM([In] this Span<byte> bytes, int a, Union32 b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x3982B40", Offset = "0x3981940", VA = "0x183982B40")]
		public static void KWEZWUVWHAM<e>(this IdArray<e, byte> a, Id32<e> b, Union32 c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x3982C90", Offset = "0x3981A90", VA = "0x183982C90")]
		public static void KWEZWUVWHAM<f>([In] this IdSpan<f, byte> bytes, Id32<f> a, Union32 b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x292C550", Offset = "0x292B350", VA = "0x18292C550")]
		public static void TGWVXCEYYFZ(this UnsafeList<byte> a, int b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x2932B10", Offset = "0x2931910", VA = "0x182932B10")]
		public static void TGWVXCEYYFZ(this byte[] a, int b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x2932A90", Offset = "0x2931890", VA = "0x182932A90")]
		public static void TGWVXCEYYFZ([In] this Span<byte> bytes, int a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x3982EC0", Offset = "0x3981CC0", VA = "0x183982EC0")]
		public static void TGWVXCEYYFZ<h>(this IdArray<h, byte> a, Id32<h> b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x3982F20", Offset = "0x3981D20", VA = "0x183982F20")]
		public static void TGWVXCEYYFZ<i>([In] this IdSpan<i, byte> bytes, Id32<i> a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x2932B90", Offset = "0x2931990", VA = "0x182932B90")]
		public static void VURXPKVZVBA(this UnsafeList<byte> a, int b, float c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x3983060", Offset = "0x3981E60", VA = "0x183983060")]
		public static void VURXPKVZVBA<k>(this IdArray<k, byte> a, Id32<k> b, float c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x39830D0", Offset = "0x3981ED0", VA = "0x1839830D0")]
		public static void VURXPKVZVBA<l>([In] this IdSpan<l, byte> bytes, Id32<l> a, float b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x2932870", Offset = "0x2931670", VA = "0x182932870")]
		public static void FOWQYYJDZRU(this UnsafeList<byte> a, int b, byte c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x3982890", Offset = "0x3981690", VA = "0x183982890")]
		public static void FOWQYYJDZRU<n>(this IdArray<n, byte> a, Id32<n> b, byte c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x39828E0", Offset = "0x39816E0", VA = "0x1839828E0")]
		public static void FOWQYYJDZRU<o>([In] this IdSpan<o, byte> bytes, Id32<o> a, byte b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x3982760", Offset = "0x3981560", VA = "0x183982760")]
		public static void MYYMZFZLDNI<q>(this IdArray<q, byte> a, Id32<q> b, Id32<XTKEAPQLAYR<HIVQMCLTDUL>> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x39826E0", Offset = "0x39814E0", VA = "0x1839826E0")]
		public static void MYYMZFZLDNI<r>([In] this IdSpan<r, byte> bytes, Id32<r> a, Id32<XTKEAPQLAYR<HIVQMCLTDUL>> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x3982760", Offset = "0x3981560", VA = "0x183982760")]
		public static void BVFAISPUYQS<t>(this IdArray<t, byte> a, Id32<t> b, Id32<PIICLSZAHGS> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x39826E0", Offset = "0x39814E0", VA = "0x1839826E0")]
		public static void BVFAISPUYQS<u>([In] this IdSpan<u, byte> bytes, Id32<u> a, Id32<PIICLSZAHGS> b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public static class JMQIUTTJXJC
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x2931550", Offset = "0x2930350", VA = "0x182931550")]
		public static (Id32<XTKEAPQLAYR<YMMBJBIAQGE>>, Id32<XTKEAPQLAYR<ELPJGPWQKEO>>, Id32<XTKEAPQLAYR<ELPJGPWQKEO>>, Id32<XTKEAPQLAYR<BPTUUJZBQIH<ELPJGPWQKEO>>>) XRVLNGREYTE(this UnsafeList<byte> a, float b, float c, [Optional] Id32<BPTUUJZBQIH<ELPJGPWQKEO>>? d)
		{
			return default((Id32<XTKEAPQLAYR<YMMBJBIAQGE>>, Id32<XTKEAPQLAYR<ELPJGPWQKEO>>, Id32<XTKEAPQLAYR<ELPJGPWQKEO>>, Id32<XTKEAPQLAYR<BPTUUJZBQIH<ELPJGPWQKEO>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x29302B0", Offset = "0x292F0B0", VA = "0x1829302B0")]
		public static (Id32<XTKEAPQLAYR<YMMBJBIAQGE>>, Id32<XTKEAPQLAYR<ELPJGPWQKEO>>, Id32<XTKEAPQLAYR<BPTUUJZBQIH<ELPJGPWQKEO>>>, Id32<XTKEAPQLAYR<BPTUUJZBQIH<ELPJGPWQKEO>>>) QHNHQGJUNKF(this UnsafeList<byte> a, float b, [Optional] Id32<BPTUUJZBQIH<ELPJGPWQKEO>>? c, [Optional] Id32<BPTUUJZBQIH<ELPJGPWQKEO>>? d)
		{
			return default((Id32<XTKEAPQLAYR<YMMBJBIAQGE>>, Id32<XTKEAPQLAYR<ELPJGPWQKEO>>, Id32<XTKEAPQLAYR<BPTUUJZBQIH<ELPJGPWQKEO>>>, Id32<XTKEAPQLAYR<BPTUUJZBQIH<ELPJGPWQKEO>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x2930790", Offset = "0x292F590", VA = "0x182930790")]
		public static (Id32<XTKEAPQLAYR<YMMBJBIAQGE>>, Id32<XTKEAPQLAYR<BPTUUJZBQIH<ELPJGPWQKEO>>>, Id32<XTKEAPQLAYR<BPTUUJZBQIH<ELPJGPWQKEO>>>, Id32<XTKEAPQLAYR<BPTUUJZBQIH<ELPJGPWQKEO>>>) RQVYVUDIKSU(this UnsafeList<byte> a, [Optional] Id32<BPTUUJZBQIH<ELPJGPWQKEO>>? b, [Optional] Id32<BPTUUJZBQIH<ELPJGPWQKEO>>? c, [Optional] Id32<BPTUUJZBQIH<ELPJGPWQKEO>>? d)
		{
			return default((Id32<XTKEAPQLAYR<YMMBJBIAQGE>>, Id32<XTKEAPQLAYR<BPTUUJZBQIH<ELPJGPWQKEO>>>, Id32<XTKEAPQLAYR<BPTUUJZBQIH<ELPJGPWQKEO>>>, Id32<XTKEAPQLAYR<BPTUUJZBQIH<ELPJGPWQKEO>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x2930630", Offset = "0x292F430", VA = "0x182930630")]
		public static (Id32<XTKEAPQLAYR<YMMBJBIAQGE>>, Id32<XTKEAPQLAYR<WEGIHCAWWIL>>, Id32<XTKEAPQLAYR<WEGIHCAWWIL>>, Id32<XTKEAPQLAYR<BPTUUJZBQIH<WEGIHCAWWIL>>>) RGGJTQBJPQM(this UnsafeList<byte> a, int b, int c, [Optional] Id32<BPTUUJZBQIH<WEGIHCAWWIL>>? d)
		{
			return default((Id32<XTKEAPQLAYR<YMMBJBIAQGE>>, Id32<XTKEAPQLAYR<WEGIHCAWWIL>>, Id32<XTKEAPQLAYR<WEGIHCAWWIL>>, Id32<XTKEAPQLAYR<BPTUUJZBQIH<WEGIHCAWWIL>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x292FEC0", Offset = "0x292ECC0", VA = "0x18292FEC0")]
		public static (Id32<XTKEAPQLAYR<YMMBJBIAQGE>>, Id32<XTKEAPQLAYR<WEGIHCAWWIL>>, Id32<XTKEAPQLAYR<BPTUUJZBQIH<WEGIHCAWWIL>>>, Id32<XTKEAPQLAYR<BPTUUJZBQIH<WEGIHCAWWIL>>>) PYSVVOUSTDF(this UnsafeList<byte> a, int b, [Optional] Id32<BPTUUJZBQIH<WEGIHCAWWIL>>? c, [Optional] Id32<BPTUUJZBQIH<WEGIHCAWWIL>>? d)
		{
			return default((Id32<XTKEAPQLAYR<YMMBJBIAQGE>>, Id32<XTKEAPQLAYR<WEGIHCAWWIL>>, Id32<XTKEAPQLAYR<BPTUUJZBQIH<WEGIHCAWWIL>>>, Id32<XTKEAPQLAYR<BPTUUJZBQIH<WEGIHCAWWIL>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x2931AE0", Offset = "0x29308E0", VA = "0x182931AE0")]
		public static (Id32<XTKEAPQLAYR<YMMBJBIAQGE>>, Id32<XTKEAPQLAYR<BPTUUJZBQIH<WEGIHCAWWIL>>>, Id32<XTKEAPQLAYR<BPTUUJZBQIH<WEGIHCAWWIL>>>, Id32<XTKEAPQLAYR<BPTUUJZBQIH<WEGIHCAWWIL>>>) YFTZNGHQNJU(this UnsafeList<byte> a, [Optional] Id32<BPTUUJZBQIH<WEGIHCAWWIL>>? b, [Optional] Id32<BPTUUJZBQIH<WEGIHCAWWIL>>? c, [Optional] Id32<BPTUUJZBQIH<WEGIHCAWWIL>>? d)
		{
			return default((Id32<XTKEAPQLAYR<YMMBJBIAQGE>>, Id32<XTKEAPQLAYR<BPTUUJZBQIH<WEGIHCAWWIL>>>, Id32<XTKEAPQLAYR<BPTUUJZBQIH<WEGIHCAWWIL>>>, Id32<XTKEAPQLAYR<BPTUUJZBQIH<WEGIHCAWWIL>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x292E350", Offset = "0x292D150", VA = "0x18292E350")]
		public static (Id32<XTKEAPQLAYR<YMMBJBIAQGE>>, Id32<XTKEAPQLAYR<WEGIHCAWWIL>>, Id32<XTKEAPQLAYR<WEGIHCAWWIL>>, Id32<XTKEAPQLAYR<BPTUUJZBQIH<WEGIHCAWWIL>>>) KXSXGLZVMCC(this UnsafeList<byte> a, int b, int c, [Optional] Id32<BPTUUJZBQIH<WEGIHCAWWIL>>? d)
		{
			return default((Id32<XTKEAPQLAYR<YMMBJBIAQGE>>, Id32<XTKEAPQLAYR<WEGIHCAWWIL>>, Id32<XTKEAPQLAYR<WEGIHCAWWIL>>, Id32<XTKEAPQLAYR<BPTUUJZBQIH<WEGIHCAWWIL>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x292D160", Offset = "0x292BF60", VA = "0x18292D160")]
		public static (Id32<XTKEAPQLAYR<YMMBJBIAQGE>>, Id32<XTKEAPQLAYR<WEGIHCAWWIL>>, Id32<XTKEAPQLAYR<BPTUUJZBQIH<WEGIHCAWWIL>>>, Id32<XTKEAPQLAYR<BPTUUJZBQIH<WEGIHCAWWIL>>>) FHIYHJNVBHX(this UnsafeList<byte> a, int b, [Optional] Id32<BPTUUJZBQIH<WEGIHCAWWIL>>? c, [Optional] Id32<BPTUUJZBQIH<WEGIHCAWWIL>>? d)
		{
			return default((Id32<XTKEAPQLAYR<YMMBJBIAQGE>>, Id32<XTKEAPQLAYR<WEGIHCAWWIL>>, Id32<XTKEAPQLAYR<BPTUUJZBQIH<WEGIHCAWWIL>>>, Id32<XTKEAPQLAYR<BPTUUJZBQIH<WEGIHCAWWIL>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x292F740", Offset = "0x292E540", VA = "0x18292F740")]
		public static (Id32<XTKEAPQLAYR<YMMBJBIAQGE>>, Id32<XTKEAPQLAYR<BPTUUJZBQIH<WEGIHCAWWIL>>>, Id32<XTKEAPQLAYR<BPTUUJZBQIH<WEGIHCAWWIL>>>, Id32<XTKEAPQLAYR<BPTUUJZBQIH<WEGIHCAWWIL>>>) NVUESSOXTRC(this UnsafeList<byte> a, [Optional] Id32<BPTUUJZBQIH<WEGIHCAWWIL>>? b, [Optional] Id32<BPTUUJZBQIH<WEGIHCAWWIL>>? c, [Optional] Id32<BPTUUJZBQIH<WEGIHCAWWIL>>? d)
		{
			return default((Id32<XTKEAPQLAYR<YMMBJBIAQGE>>, Id32<XTKEAPQLAYR<BPTUUJZBQIH<WEGIHCAWWIL>>>, Id32<XTKEAPQLAYR<BPTUUJZBQIH<WEGIHCAWWIL>>>, Id32<XTKEAPQLAYR<BPTUUJZBQIH<WEGIHCAWWIL>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x292F4E0", Offset = "0x292E2E0", VA = "0x18292F4E0")]
		public static (Id32<XTKEAPQLAYR<YMMBJBIAQGE>>, Id32<XTKEAPQLAYR<WEGIHCAWWIL>>, Id32<XTKEAPQLAYR<XTKEAPQLAYR<YMMBJBIAQGE>>>) NDSTXNNDKKY(this UnsafeList<byte> a, [Optional] int? b, [Optional] Id32<XTKEAPQLAYR<YMMBJBIAQGE>>? c)
		{
			return default((Id32<XTKEAPQLAYR<YMMBJBIAQGE>>, Id32<XTKEAPQLAYR<WEGIHCAWWIL>>, Id32<XTKEAPQLAYR<XTKEAPQLAYR<YMMBJBIAQGE>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x292F260", Offset = "0x292E060", VA = "0x18292F260")]
		public static (Id32<XTKEAPQLAYR<YMMBJBIAQGE>>, Id32<XTKEAPQLAYR<BPTUUJZBQIH<WEGIHCAWWIL>>>, Id32<XTKEAPQLAYR<XTKEAPQLAYR<YMMBJBIAQGE>>>) MRRTQSBCNQT(this UnsafeList<byte> a, [Optional] Id32<BPTUUJZBQIH<WEGIHCAWWIL>>? b, [Optional] Id32<XTKEAPQLAYR<YMMBJBIAQGE>>? c)
		{
			return default((Id32<XTKEAPQLAYR<YMMBJBIAQGE>>, Id32<XTKEAPQLAYR<BPTUUJZBQIH<WEGIHCAWWIL>>>, Id32<XTKEAPQLAYR<XTKEAPQLAYR<YMMBJBIAQGE>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x2930D60", Offset = "0x292FB60", VA = "0x182930D60")]
		public static (Id32<XTKEAPQLAYR<YMMBJBIAQGE>>, Id32<XTKEAPQLAYR<WEGIHCAWWIL>>, Id32<XTKEAPQLAYR<XTKEAPQLAYR<YMMBJBIAQGE>>>) TFAWPCXKZFX(this UnsafeList<byte> a, [Optional] int? b, [Optional] Id32<XTKEAPQLAYR<YMMBJBIAQGE>>? c)
		{
			return default((Id32<XTKEAPQLAYR<YMMBJBIAQGE>>, Id32<XTKEAPQLAYR<WEGIHCAWWIL>>, Id32<XTKEAPQLAYR<XTKEAPQLAYR<YMMBJBIAQGE>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x2930510", Offset = "0x292F310", VA = "0x182930510")]
		public static (Id32<XTKEAPQLAYR<YMMBJBIAQGE>>, Id32<XTKEAPQLAYR<BPTUUJZBQIH<WEGIHCAWWIL>>>, Id32<XTKEAPQLAYR<XTKEAPQLAYR<YMMBJBIAQGE>>>) QLDHBJXCATY(this UnsafeList<byte> a, [Optional] Id32<BPTUUJZBQIH<WEGIHCAWWIL>>? b, [Optional] Id32<XTKEAPQLAYR<YMMBJBIAQGE>>? c)
		{
			return default((Id32<XTKEAPQLAYR<YMMBJBIAQGE>>, Id32<XTKEAPQLAYR<BPTUUJZBQIH<WEGIHCAWWIL>>>, Id32<XTKEAPQLAYR<XTKEAPQLAYR<YMMBJBIAQGE>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x292CC60", Offset = "0x292BA60", VA = "0x18292CC60")]
		public static (Id32<XTKEAPQLAYR<YMMBJBIAQGE>>, Id32<XTKEAPQLAYR<WEGIHCAWWIL>>, Id32<XTKEAPQLAYR<CGBEZEBPUAA>>) BWPGJYFZBUP(this UnsafeList<byte> a, [Optional] int? b, [Optional] Id32<CGBEZEBPUAA>? c)
		{
			return default((Id32<XTKEAPQLAYR<YMMBJBIAQGE>>, Id32<XTKEAPQLAYR<WEGIHCAWWIL>>, Id32<XTKEAPQLAYR<CGBEZEBPUAA>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x292CE10", Offset = "0x292BC10", VA = "0x18292CE10")]
		public static (Id32<XTKEAPQLAYR<YMMBJBIAQGE>>, Id32<XTKEAPQLAYR<WEGIHCAWWIL>>, Id32<XTKEAPQLAYR<BPTUUJZBQIH<CGBEZEBPUAA>>>) CBQWTLJLDSG(this UnsafeList<byte> a, [Optional] int? b, [Optional] Id32<BPTUUJZBQIH<CGBEZEBPUAA>>? c)
		{
			return default((Id32<XTKEAPQLAYR<YMMBJBIAQGE>>, Id32<XTKEAPQLAYR<WEGIHCAWWIL>>, Id32<XTKEAPQLAYR<BPTUUJZBQIH<CGBEZEBPUAA>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x292EBB0", Offset = "0x292D9B0", VA = "0x18292EBB0")]
		public static (Id32<XTKEAPQLAYR<YMMBJBIAQGE>>, Id32<XTKEAPQLAYR<WEGIHCAWWIL>>, Id32<XTKEAPQLAYR<PIICLSZAHGS>>) LKBHGJQZJUJ(this UnsafeList<byte> a, [Optional] int? b, [Optional] Id32<PIICLSZAHGS>? c)
		{
			return default((Id32<XTKEAPQLAYR<YMMBJBIAQGE>>, Id32<XTKEAPQLAYR<WEGIHCAWWIL>>, Id32<XTKEAPQLAYR<PIICLSZAHGS>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x292ED60", Offset = "0x292DB60", VA = "0x18292ED60")]
		public static (Id32<XTKEAPQLAYR<YMMBJBIAQGE>>, Id32<XTKEAPQLAYR<WEGIHCAWWIL>>, Id32<XTKEAPQLAYR<BPTUUJZBQIH<PIICLSZAHGS>>>) LLBPSRMMEZC(this UnsafeList<byte> a, [Optional] int? b, [Optional] Id32<BPTUUJZBQIH<PIICLSZAHGS>>? c)
		{
			return default((Id32<XTKEAPQLAYR<YMMBJBIAQGE>>, Id32<XTKEAPQLAYR<WEGIHCAWWIL>>, Id32<XTKEAPQLAYR<BPTUUJZBQIH<PIICLSZAHGS>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x3800B50", Offset = "0x37FF950", VA = "0x183800B50")]
		public static (Id32<XTKEAPQLAYR<YMMBJBIAQGE>>, Id32<XTKEAPQLAYR<TMYLYEFQLQF>>, Id32<XTKEAPQLAYR<WEGIHCAWWIL>>, Id32<XTKEAPQLAYR<a>>) XJIMNIJAOGK<a>(this UnsafeList<byte> a, [Optional] Id32<TMYLYEFQLQF>? b, [Optional][In] ReadOnlySpan<byte> data)
		{
			return default((Id32<XTKEAPQLAYR<YMMBJBIAQGE>>, Id32<XTKEAPQLAYR<TMYLYEFQLQF>>, Id32<XTKEAPQLAYR<WEGIHCAWWIL>>, Id32<XTKEAPQLAYR<a>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x2930FD0", Offset = "0x292FDD0", VA = "0x182930FD0")]
		public static (Id32<XTKEAPQLAYR<YMMBJBIAQGE>>, Id32<XTKEAPQLAYR<WEGIHCAWWIL>>, Id32<XTKEAPQLAYR<BPTUUJZBQIH<WEGIHCAWWIL>>>) UQGGWSVYLLO(this UnsafeList<byte> a, int b, [Optional] Id32<BPTUUJZBQIH<WEGIHCAWWIL>>? c)
		{
			return default((Id32<XTKEAPQLAYR<YMMBJBIAQGE>>, Id32<XTKEAPQLAYR<WEGIHCAWWIL>>, Id32<XTKEAPQLAYR<BPTUUJZBQIH<WEGIHCAWWIL>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x292D460", Offset = "0x292C260", VA = "0x18292D460")]
		public static (Id32<XTKEAPQLAYR<YMMBJBIAQGE>>, Id32<XTKEAPQLAYR<BPTUUJZBQIH<WEGIHCAWWIL>>>, Id32<XTKEAPQLAYR<BPTUUJZBQIH<WEGIHCAWWIL>>>) GKOUTMEEUAX(this UnsafeList<byte> a, [Optional] Id32<BPTUUJZBQIH<WEGIHCAWWIL>>? b, [Optional] Id32<BPTUUJZBQIH<WEGIHCAWWIL>>? c)
		{
			return default((Id32<XTKEAPQLAYR<YMMBJBIAQGE>>, Id32<XTKEAPQLAYR<BPTUUJZBQIH<WEGIHCAWWIL>>>, Id32<XTKEAPQLAYR<BPTUUJZBQIH<WEGIHCAWWIL>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x3800740", Offset = "0x37FF540", VA = "0x183800740")]
		public static (Id32<XTKEAPQLAYR<YMMBJBIAQGE>>, Id32<XTKEAPQLAYR<BPTUUJZBQIH<b>>>, Id32<XTKEAPQLAYR<WEGIHCAWWIL>>, Id32<XTKEAPQLAYR<b>>) IDPASAAZTCU<b>(this UnsafeList<byte> a, [Optional] Id32<BPTUUJZBQIH<b>>? b, [Optional] int? c, [Optional][In] ReadOnlySpan<byte> from)
		{
			return default((Id32<XTKEAPQLAYR<YMMBJBIAQGE>>, Id32<XTKEAPQLAYR<BPTUUJZBQIH<b>>>, Id32<XTKEAPQLAYR<WEGIHCAWWIL>>, Id32<XTKEAPQLAYR<b>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x3800410", Offset = "0x37FF210", VA = "0x183800410")]
		public static (Id32<XTKEAPQLAYR<YMMBJBIAQGE>>, Id32<XTKEAPQLAYR<BPTUUJZBQIH<c>>>, Id32<XTKEAPQLAYR<BPTUUJZBQIH<c>>>, Id32<XTKEAPQLAYR<WEGIHCAWWIL>>) FLMJYVRFEOL<c>(this UnsafeList<byte> a, [Optional] Id32<BPTUUJZBQIH<c>>? b, [Optional] Id32<BPTUUJZBQIH<c>>? c, [Optional] int? d)
		{
			return default((Id32<XTKEAPQLAYR<YMMBJBIAQGE>>, Id32<XTKEAPQLAYR<BPTUUJZBQIH<c>>>, Id32<XTKEAPQLAYR<BPTUUJZBQIH<c>>>, Id32<XTKEAPQLAYR<WEGIHCAWWIL>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x292E600", Offset = "0x292D400", VA = "0x18292E600")]
		public static (Id32<XTKEAPQLAYR<YMMBJBIAQGE>>, Id32<XTKEAPQLAYR<ELPJGPWQKEO>>, Id32<XTKEAPQLAYR<ELPJGPWQKEO>>, Id32<XTKEAPQLAYR<BPTUUJZBQIH<ELPJGPWQKEO>>>) KZMYADFKAEA(this UnsafeList<byte> a, float b, float c, [Optional] Id32<BPTUUJZBQIH<ELPJGPWQKEO>>? d)
		{
			return default((Id32<XTKEAPQLAYR<YMMBJBIAQGE>>, Id32<XTKEAPQLAYR<ELPJGPWQKEO>>, Id32<XTKEAPQLAYR<ELPJGPWQKEO>>, Id32<XTKEAPQLAYR<BPTUUJZBQIH<ELPJGPWQKEO>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x2931400", Offset = "0x2930200", VA = "0x182931400")]
		public static (Id32<XTKEAPQLAYR<YMMBJBIAQGE>>, Id32<XTKEAPQLAYR<ELPJGPWQKEO>>, Id32<XTKEAPQLAYR<BPTUUJZBQIH<ELPJGPWQKEO>>>, Id32<XTKEAPQLAYR<BPTUUJZBQIH<ELPJGPWQKEO>>>) XRVHEJPHAWT(this UnsafeList<byte> a, float b, [Optional] Id32<BPTUUJZBQIH<ELPJGPWQKEO>>? c, [Optional] Id32<BPTUUJZBQIH<ELPJGPWQKEO>>? d)
		{
			return default((Id32<XTKEAPQLAYR<YMMBJBIAQGE>>, Id32<XTKEAPQLAYR<ELPJGPWQKEO>>, Id32<XTKEAPQLAYR<BPTUUJZBQIH<ELPJGPWQKEO>>>, Id32<XTKEAPQLAYR<BPTUUJZBQIH<ELPJGPWQKEO>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x292DE80", Offset = "0x292CC80", VA = "0x18292DE80")]
		public static (Id32<XTKEAPQLAYR<YMMBJBIAQGE>>, Id32<XTKEAPQLAYR<BPTUUJZBQIH<ELPJGPWQKEO>>>, Id32<XTKEAPQLAYR<BPTUUJZBQIH<ELPJGPWQKEO>>>, Id32<XTKEAPQLAYR<BPTUUJZBQIH<ELPJGPWQKEO>>>) IOZLGWBBWOC(this UnsafeList<byte> a, [Optional] Id32<BPTUUJZBQIH<ELPJGPWQKEO>>? b, [Optional] Id32<BPTUUJZBQIH<ELPJGPWQKEO>>? c, [Optional] Id32<BPTUUJZBQIH<ELPJGPWQKEO>>? d)
		{
			return default((Id32<XTKEAPQLAYR<YMMBJBIAQGE>>, Id32<XTKEAPQLAYR<BPTUUJZBQIH<ELPJGPWQKEO>>>, Id32<XTKEAPQLAYR<BPTUUJZBQIH<ELPJGPWQKEO>>>, Id32<XTKEAPQLAYR<BPTUUJZBQIH<ELPJGPWQKEO>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x292EE70", Offset = "0x292DC70", VA = "0x18292EE70")]
		public static (Id32<XTKEAPQLAYR<YMMBJBIAQGE>>, Id32<XTKEAPQLAYR<WEGIHCAWWIL>>, Id32<XTKEAPQLAYR<WEGIHCAWWIL>>, Id32<XTKEAPQLAYR<BPTUUJZBQIH<WEGIHCAWWIL>>>) LNWYTREDZZY(this UnsafeList<byte> a, int b, int c, [Optional] Id32<BPTUUJZBQIH<WEGIHCAWWIL>>? d)
		{
			return default((Id32<XTKEAPQLAYR<YMMBJBIAQGE>>, Id32<XTKEAPQLAYR<WEGIHCAWWIL>>, Id32<XTKEAPQLAYR<WEGIHCAWWIL>>, Id32<XTKEAPQLAYR<BPTUUJZBQIH<WEGIHCAWWIL>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x292D950", Offset = "0x292C750", VA = "0x18292D950")]
		public static (Id32<XTKEAPQLAYR<YMMBJBIAQGE>>, Id32<XTKEAPQLAYR<WEGIHCAWWIL>>, Id32<XTKEAPQLAYR<BPTUUJZBQIH<WEGIHCAWWIL>>>, Id32<XTKEAPQLAYR<BPTUUJZBQIH<WEGIHCAWWIL>>>) HQXZYGAXZGR(this UnsafeList<byte> a, int b, [Optional] Id32<BPTUUJZBQIH<WEGIHCAWWIL>>? c, [Optional] Id32<BPTUUJZBQIH<WEGIHCAWWIL>>? d)
		{
			return default((Id32<XTKEAPQLAYR<YMMBJBIAQGE>>, Id32<XTKEAPQLAYR<WEGIHCAWWIL>>, Id32<XTKEAPQLAYR<BPTUUJZBQIH<WEGIHCAWWIL>>>, Id32<XTKEAPQLAYR<BPTUUJZBQIH<WEGIHCAWWIL>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x292FDA0", Offset = "0x292EBA0", VA = "0x18292FDA0")]
		public static (Id32<XTKEAPQLAYR<YMMBJBIAQGE>>, Id32<XTKEAPQLAYR<BPTUUJZBQIH<WEGIHCAWWIL>>>, Id32<XTKEAPQLAYR<BPTUUJZBQIH<WEGIHCAWWIL>>>, Id32<XTKEAPQLAYR<BPTUUJZBQIH<WEGIHCAWWIL>>>) PWXAPYSLKWE(this UnsafeList<byte> a, [Optional] Id32<BPTUUJZBQIH<WEGIHCAWWIL>>? b, [Optional] Id32<BPTUUJZBQIH<WEGIHCAWWIL>>? c, [Optional] Id32<BPTUUJZBQIH<WEGIHCAWWIL>>? d)
		{
			return default((Id32<XTKEAPQLAYR<YMMBJBIAQGE>>, Id32<XTKEAPQLAYR<BPTUUJZBQIH<WEGIHCAWWIL>>>, Id32<XTKEAPQLAYR<BPTUUJZBQIH<WEGIHCAWWIL>>>, Id32<XTKEAPQLAYR<BPTUUJZBQIH<WEGIHCAWWIL>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x2931980", Offset = "0x2930780", VA = "0x182931980")]
		public static (Id32<XTKEAPQLAYR<YMMBJBIAQGE>>, Id32<XTKEAPQLAYR<WEGIHCAWWIL>>, Id32<XTKEAPQLAYR<WEGIHCAWWIL>>, Id32<XTKEAPQLAYR<BPTUUJZBQIH<WEGIHCAWWIL>>>) XXCPFXTABML(this UnsafeList<byte> a, int b, int c, [Optional] Id32<BPTUUJZBQIH<WEGIHCAWWIL>>? d)
		{
			return default((Id32<XTKEAPQLAYR<YMMBJBIAQGE>>, Id32<XTKEAPQLAYR<WEGIHCAWWIL>>, Id32<XTKEAPQLAYR<WEGIHCAWWIL>>, Id32<XTKEAPQLAYR<BPTUUJZBQIH<WEGIHCAWWIL>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x292CB10", Offset = "0x292B910", VA = "0x18292CB10")]
		public static (Id32<XTKEAPQLAYR<YMMBJBIAQGE>>, Id32<XTKEAPQLAYR<WEGIHCAWWIL>>, Id32<XTKEAPQLAYR<BPTUUJZBQIH<WEGIHCAWWIL>>>, Id32<XTKEAPQLAYR<BPTUUJZBQIH<WEGIHCAWWIL>>>) BTRXMQXTCIY(this UnsafeList<byte> a, int b, [Optional] Id32<BPTUUJZBQIH<WEGIHCAWWIL>>? c, [Optional] Id32<BPTUUJZBQIH<WEGIHCAWWIL>>? d)
		{
			return default((Id32<XTKEAPQLAYR<YMMBJBIAQGE>>, Id32<XTKEAPQLAYR<WEGIHCAWWIL>>, Id32<XTKEAPQLAYR<BPTUUJZBQIH<WEGIHCAWWIL>>>, Id32<XTKEAPQLAYR<BPTUUJZBQIH<WEGIHCAWWIL>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x292D040", Offset = "0x292BE40", VA = "0x18292D040")]
		public static (Id32<XTKEAPQLAYR<YMMBJBIAQGE>>, Id32<XTKEAPQLAYR<BPTUUJZBQIH<WEGIHCAWWIL>>>, Id32<XTKEAPQLAYR<BPTUUJZBQIH<WEGIHCAWWIL>>>, Id32<XTKEAPQLAYR<BPTUUJZBQIH<WEGIHCAWWIL>>>) DSJJHHIGPTX(this UnsafeList<byte> a, [Optional] Id32<BPTUUJZBQIH<WEGIHCAWWIL>>? b, [Optional] Id32<BPTUUJZBQIH<WEGIHCAWWIL>>? c, [Optional] Id32<BPTUUJZBQIH<WEGIHCAWWIL>>? d)
		{
			return default((Id32<XTKEAPQLAYR<YMMBJBIAQGE>>, Id32<XTKEAPQLAYR<BPTUUJZBQIH<WEGIHCAWWIL>>>, Id32<XTKEAPQLAYR<BPTUUJZBQIH<WEGIHCAWWIL>>>, Id32<XTKEAPQLAYR<BPTUUJZBQIH<WEGIHCAWWIL>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x2931C00", Offset = "0x2930A00", VA = "0x182931C00")]
		public static (Id32<XTKEAPQLAYR<YMMBJBIAQGE>>, Id32<XTKEAPQLAYR<XTKEAPQLAYR<YMMBJBIAQGE>>>) YJXJQGXORCQ(this UnsafeList<byte> a, [Optional] Id32<XTKEAPQLAYR<YMMBJBIAQGE>>? b)
		{
			return default((Id32<XTKEAPQLAYR<YMMBJBIAQGE>>, Id32<XTKEAPQLAYR<XTKEAPQLAYR<YMMBJBIAQGE>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x2931100", Offset = "0x292FF00", VA = "0x182931100")]
		public static (Id32<XTKEAPQLAYR<YMMBJBIAQGE>>, Id32<XTKEAPQLAYR<ELPJGPWQKEO>>, Id32<XTKEAPQLAYR<ELPJGPWQKEO>>, Id32<XTKEAPQLAYR<BPTUUJZBQIH<WEGIHCAWWIL>>>) VRRYZSAYQZG(this UnsafeList<byte> a, float b, float c, [Optional] Id32<BPTUUJZBQIH<WEGIHCAWWIL>>? d)
		{
			return default((Id32<XTKEAPQLAYR<YMMBJBIAQGE>>, Id32<XTKEAPQLAYR<ELPJGPWQKEO>>, Id32<XTKEAPQLAYR<ELPJGPWQKEO>>, Id32<XTKEAPQLAYR<BPTUUJZBQIH<WEGIHCAWWIL>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x292F380", Offset = "0x292E180", VA = "0x18292F380")]
		public static (Id32<XTKEAPQLAYR<YMMBJBIAQGE>>, Id32<XTKEAPQLAYR<ELPJGPWQKEO>>, Id32<XTKEAPQLAYR<BPTUUJZBQIH<ELPJGPWQKEO>>>, Id32<XTKEAPQLAYR<BPTUUJZBQIH<WEGIHCAWWIL>>>) MYCUHKIMRHF(this UnsafeList<byte> a, float b, [Optional] Id32<BPTUUJZBQIH<ELPJGPWQKEO>>? c, [Optional] Id32<BPTUUJZBQIH<WEGIHCAWWIL>>? d)
		{
			return default((Id32<XTKEAPQLAYR<YMMBJBIAQGE>>, Id32<XTKEAPQLAYR<ELPJGPWQKEO>>, Id32<XTKEAPQLAYR<BPTUUJZBQIH<ELPJGPWQKEO>>>, Id32<XTKEAPQLAYR<BPTUUJZBQIH<WEGIHCAWWIL>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x292D2B0", Offset = "0x292C0B0", VA = "0x18292D2B0")]
		public static (Id32<XTKEAPQLAYR<YMMBJBIAQGE>>, Id32<XTKEAPQLAYR<BPTUUJZBQIH<ELPJGPWQKEO>>>, Id32<XTKEAPQLAYR<BPTUUJZBQIH<ELPJGPWQKEO>>>, Id32<XTKEAPQLAYR<BPTUUJZBQIH<WEGIHCAWWIL>>>) FOCUDBXLAMS(this UnsafeList<byte> a, [Optional] Id32<BPTUUJZBQIH<ELPJGPWQKEO>>? b, [Optional] Id32<BPTUUJZBQIH<ELPJGPWQKEO>>? c, [Optional] Id32<BPTUUJZBQIH<WEGIHCAWWIL>>? d)
		{
			return default((Id32<XTKEAPQLAYR<YMMBJBIAQGE>>, Id32<XTKEAPQLAYR<BPTUUJZBQIH<ELPJGPWQKEO>>>, Id32<XTKEAPQLAYR<BPTUUJZBQIH<ELPJGPWQKEO>>>, Id32<XTKEAPQLAYR<BPTUUJZBQIH<WEGIHCAWWIL>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x292DC00", Offset = "0x292CA00", VA = "0x18292DC00")]
		public static (Id32<XTKEAPQLAYR<YMMBJBIAQGE>>, Id32<XTKEAPQLAYR<WEGIHCAWWIL>>, Id32<XTKEAPQLAYR<WEGIHCAWWIL>>, Id32<XTKEAPQLAYR<BPTUUJZBQIH<WEGIHCAWWIL>>>) IHYLPMGMODX(this UnsafeList<byte> a, int b, int c, [Optional] Id32<BPTUUJZBQIH<WEGIHCAWWIL>>? d)
		{
			return default((Id32<XTKEAPQLAYR<YMMBJBIAQGE>>, Id32<XTKEAPQLAYR<WEGIHCAWWIL>>, Id32<XTKEAPQLAYR<WEGIHCAWWIL>>, Id32<XTKEAPQLAYR<BPTUUJZBQIH<WEGIHCAWWIL>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x292C860", Offset = "0x292B660", VA = "0x18292C860")]
		public static (Id32<XTKEAPQLAYR<YMMBJBIAQGE>>, Id32<XTKEAPQLAYR<WEGIHCAWWIL>>, Id32<XTKEAPQLAYR<BPTUUJZBQIH<WEGIHCAWWIL>>>, Id32<XTKEAPQLAYR<BPTUUJZBQIH<WEGIHCAWWIL>>>) ASTQJBWPDOS(this UnsafeList<byte> a, int b, [Optional] Id32<BPTUUJZBQIH<WEGIHCAWWIL>>? c, [Optional] Id32<BPTUUJZBQIH<WEGIHCAWWIL>>? d)
		{
			return default((Id32<XTKEAPQLAYR<YMMBJBIAQGE>>, Id32<XTKEAPQLAYR<WEGIHCAWWIL>>, Id32<XTKEAPQLAYR<BPTUUJZBQIH<WEGIHCAWWIL>>>, Id32<XTKEAPQLAYR<BPTUUJZBQIH<WEGIHCAWWIL>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x2930B20", Offset = "0x292F920", VA = "0x182930B20")]
		public static (Id32<XTKEAPQLAYR<YMMBJBIAQGE>>, Id32<XTKEAPQLAYR<BPTUUJZBQIH<WEGIHCAWWIL>>>, Id32<XTKEAPQLAYR<BPTUUJZBQIH<WEGIHCAWWIL>>>, Id32<XTKEAPQLAYR<BPTUUJZBQIH<WEGIHCAWWIL>>>) SLSMRKJRJID(this UnsafeList<byte> a, [Optional] Id32<BPTUUJZBQIH<WEGIHCAWWIL>>? b, [Optional] Id32<BPTUUJZBQIH<WEGIHCAWWIL>>? c, [Optional] Id32<BPTUUJZBQIH<WEGIHCAWWIL>>? d)
		{
			return default((Id32<XTKEAPQLAYR<YMMBJBIAQGE>>, Id32<XTKEAPQLAYR<BPTUUJZBQIH<WEGIHCAWWIL>>>, Id32<XTKEAPQLAYR<BPTUUJZBQIH<WEGIHCAWWIL>>>, Id32<XTKEAPQLAYR<BPTUUJZBQIH<WEGIHCAWWIL>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x292E8E0", Offset = "0x292D6E0", VA = "0x18292E8E0")]
		public static (Id32<XTKEAPQLAYR<YMMBJBIAQGE>>, Id32<XTKEAPQLAYR<ELPJGPWQKEO>>, Id32<XTKEAPQLAYR<ELPJGPWQKEO>>, Id32<XTKEAPQLAYR<BPTUUJZBQIH<WEGIHCAWWIL>>>) LCNXWMNTBYL(this UnsafeList<byte> a, float b, float c, [Optional] Id32<BPTUUJZBQIH<WEGIHCAWWIL>>? d)
		{
			return default((Id32<XTKEAPQLAYR<YMMBJBIAQGE>>, Id32<XTKEAPQLAYR<ELPJGPWQKEO>>, Id32<XTKEAPQLAYR<ELPJGPWQKEO>>, Id32<XTKEAPQLAYR<BPTUUJZBQIH<WEGIHCAWWIL>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x29316D0", Offset = "0x29304D0", VA = "0x1829316D0")]
		public static (Id32<XTKEAPQLAYR<YMMBJBIAQGE>>, Id32<XTKEAPQLAYR<ELPJGPWQKEO>>, Id32<XTKEAPQLAYR<BPTUUJZBQIH<ELPJGPWQKEO>>>, Id32<XTKEAPQLAYR<BPTUUJZBQIH<WEGIHCAWWIL>>>) XUHEENGBTPO(this UnsafeList<byte> a, float b, [Optional] Id32<BPTUUJZBQIH<ELPJGPWQKEO>>? c, [Optional] Id32<BPTUUJZBQIH<WEGIHCAWWIL>>? d)
		{
			return default((Id32<XTKEAPQLAYR<YMMBJBIAQGE>>, Id32<XTKEAPQLAYR<ELPJGPWQKEO>>, Id32<XTKEAPQLAYR<BPTUUJZBQIH<ELPJGPWQKEO>>>, Id32<XTKEAPQLAYR<BPTUUJZBQIH<WEGIHCAWWIL>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x292EFD0", Offset = "0x292DDD0", VA = "0x18292EFD0")]
		public static (Id32<XTKEAPQLAYR<YMMBJBIAQGE>>, Id32<XTKEAPQLAYR<BPTUUJZBQIH<ELPJGPWQKEO>>>, Id32<XTKEAPQLAYR<BPTUUJZBQIH<ELPJGPWQKEO>>>, Id32<XTKEAPQLAYR<BPTUUJZBQIH<WEGIHCAWWIL>>>) LQSRVHRISGN(this UnsafeList<byte> a, [Optional] Id32<BPTUUJZBQIH<ELPJGPWQKEO>>? b, [Optional] Id32<BPTUUJZBQIH<ELPJGPWQKEO>>? c, [Optional] Id32<BPTUUJZBQIH<WEGIHCAWWIL>>? d)
		{
			return default((Id32<XTKEAPQLAYR<YMMBJBIAQGE>>, Id32<XTKEAPQLAYR<BPTUUJZBQIH<ELPJGPWQKEO>>>, Id32<XTKEAPQLAYR<BPTUUJZBQIH<ELPJGPWQKEO>>>, Id32<XTKEAPQLAYR<BPTUUJZBQIH<WEGIHCAWWIL>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x292C9B0", Offset = "0x292B7B0", VA = "0x18292C9B0")]
		public static (Id32<XTKEAPQLAYR<YMMBJBIAQGE>>, Id32<XTKEAPQLAYR<WEGIHCAWWIL>>, Id32<XTKEAPQLAYR<WEGIHCAWWIL>>, Id32<XTKEAPQLAYR<BPTUUJZBQIH<WEGIHCAWWIL>>>) BRCALACSMJM(this UnsafeList<byte> a, int b, int c, [Optional] Id32<BPTUUJZBQIH<WEGIHCAWWIL>>? d)
		{
			return default((Id32<XTKEAPQLAYR<YMMBJBIAQGE>>, Id32<XTKEAPQLAYR<WEGIHCAWWIL>>, Id32<XTKEAPQLAYR<WEGIHCAWWIL>>, Id32<XTKEAPQLAYR<BPTUUJZBQIH<WEGIHCAWWIL>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x292EA60", Offset = "0x292D860", VA = "0x18292EA60")]
		public static (Id32<XTKEAPQLAYR<YMMBJBIAQGE>>, Id32<XTKEAPQLAYR<WEGIHCAWWIL>>, Id32<XTKEAPQLAYR<BPTUUJZBQIH<WEGIHCAWWIL>>>, Id32<XTKEAPQLAYR<BPTUUJZBQIH<WEGIHCAWWIL>>>) LHMMJFZVSKN(this UnsafeList<byte> a, int b, [Optional] Id32<BPTUUJZBQIH<WEGIHCAWWIL>>? c, [Optional] Id32<BPTUUJZBQIH<WEGIHCAWWIL>>? d)
		{
			return default((Id32<XTKEAPQLAYR<YMMBJBIAQGE>>, Id32<XTKEAPQLAYR<WEGIHCAWWIL>>, Id32<XTKEAPQLAYR<BPTUUJZBQIH<WEGIHCAWWIL>>>, Id32<XTKEAPQLAYR<BPTUUJZBQIH<WEGIHCAWWIL>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x292F9E0", Offset = "0x292E7E0", VA = "0x18292F9E0")]
		public static (Id32<XTKEAPQLAYR<YMMBJBIAQGE>>, Id32<XTKEAPQLAYR<BPTUUJZBQIH<WEGIHCAWWIL>>>, Id32<XTKEAPQLAYR<BPTUUJZBQIH<WEGIHCAWWIL>>>, Id32<XTKEAPQLAYR<BPTUUJZBQIH<WEGIHCAWWIL>>>) ODANRGRRHAE(this UnsafeList<byte> a, [Optional] Id32<BPTUUJZBQIH<WEGIHCAWWIL>>? b, [Optional] Id32<BPTUUJZBQIH<WEGIHCAWWIL>>? c, [Optional] Id32<BPTUUJZBQIH<WEGIHCAWWIL>>? d)
		{
			return default((Id32<XTKEAPQLAYR<YMMBJBIAQGE>>, Id32<XTKEAPQLAYR<BPTUUJZBQIH<WEGIHCAWWIL>>>, Id32<XTKEAPQLAYR<BPTUUJZBQIH<WEGIHCAWWIL>>>, Id32<XTKEAPQLAYR<BPTUUJZBQIH<WEGIHCAWWIL>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x2931280", Offset = "0x2930080", VA = "0x182931280")]
		public static (Id32<XTKEAPQLAYR<YMMBJBIAQGE>>, Id32<XTKEAPQLAYR<ELPJGPWQKEO>>, Id32<XTKEAPQLAYR<ELPJGPWQKEO>>, Id32<XTKEAPQLAYR<BPTUUJZBQIH<WEGIHCAWWIL>>>) VTGQXVKICWL(this UnsafeList<byte> a, float b, float c, [Optional] Id32<BPTUUJZBQIH<WEGIHCAWWIL>>? d)
		{
			return default((Id32<XTKEAPQLAYR<YMMBJBIAQGE>>, Id32<XTKEAPQLAYR<ELPJGPWQKEO>>, Id32<XTKEAPQLAYR<ELPJGPWQKEO>>, Id32<XTKEAPQLAYR<BPTUUJZBQIH<WEGIHCAWWIL>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x2930E70", Offset = "0x292FC70", VA = "0x182930E70")]
		public static (Id32<XTKEAPQLAYR<YMMBJBIAQGE>>, Id32<XTKEAPQLAYR<ELPJGPWQKEO>>, Id32<XTKEAPQLAYR<BPTUUJZBQIH<ELPJGPWQKEO>>>, Id32<XTKEAPQLAYR<BPTUUJZBQIH<WEGIHCAWWIL>>>) TFYPPXNBFEM(this UnsafeList<byte> a, float b, [Optional] Id32<BPTUUJZBQIH<ELPJGPWQKEO>>? c, [Optional] Id32<BPTUUJZBQIH<WEGIHCAWWIL>>? d)
		{
			return default((Id32<XTKEAPQLAYR<YMMBJBIAQGE>>, Id32<XTKEAPQLAYR<ELPJGPWQKEO>>, Id32<XTKEAPQLAYR<BPTUUJZBQIH<ELPJGPWQKEO>>>, Id32<XTKEAPQLAYR<BPTUUJZBQIH<WEGIHCAWWIL>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x2931CF0", Offset = "0x2930AF0", VA = "0x182931CF0")]
		public static (Id32<XTKEAPQLAYR<YMMBJBIAQGE>>, Id32<XTKEAPQLAYR<BPTUUJZBQIH<ELPJGPWQKEO>>>, Id32<XTKEAPQLAYR<BPTUUJZBQIH<ELPJGPWQKEO>>>, Id32<XTKEAPQLAYR<BPTUUJZBQIH<WEGIHCAWWIL>>>) YUKAQDFJGDL(this UnsafeList<byte> a, [Optional] Id32<BPTUUJZBQIH<ELPJGPWQKEO>>? b, [Optional] Id32<BPTUUJZBQIH<ELPJGPWQKEO>>? c, [Optional] Id32<BPTUUJZBQIH<WEGIHCAWWIL>>? d)
		{
			return default((Id32<XTKEAPQLAYR<YMMBJBIAQGE>>, Id32<XTKEAPQLAYR<BPTUUJZBQIH<ELPJGPWQKEO>>>, Id32<XTKEAPQLAYR<BPTUUJZBQIH<ELPJGPWQKEO>>>, Id32<XTKEAPQLAYR<BPTUUJZBQIH<WEGIHCAWWIL>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x2931F80", Offset = "0x2930D80", VA = "0x182931F80")]
		public static (Id32<XTKEAPQLAYR<YMMBJBIAQGE>>, Id32<XTKEAPQLAYR<WEGIHCAWWIL>>, Id32<XTKEAPQLAYR<WEGIHCAWWIL>>, Id32<XTKEAPQLAYR<BPTUUJZBQIH<WEGIHCAWWIL>>>) ZOTNLLJFJVQ(this UnsafeList<byte> a, int b, int c, [Optional] Id32<BPTUUJZBQIH<WEGIHCAWWIL>>? d)
		{
			return default((Id32<XTKEAPQLAYR<YMMBJBIAQGE>>, Id32<XTKEAPQLAYR<WEGIHCAWWIL>>, Id32<XTKEAPQLAYR<WEGIHCAWWIL>>, Id32<XTKEAPQLAYR<BPTUUJZBQIH<WEGIHCAWWIL>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x2930160", Offset = "0x292EF60", VA = "0x182930160")]
		public static (Id32<XTKEAPQLAYR<YMMBJBIAQGE>>, Id32<XTKEAPQLAYR<WEGIHCAWWIL>>, Id32<XTKEAPQLAYR<BPTUUJZBQIH<WEGIHCAWWIL>>>, Id32<XTKEAPQLAYR<BPTUUJZBQIH<WEGIHCAWWIL>>>) QCMMLTOIONP(this UnsafeList<byte> a, int b, [Optional] Id32<BPTUUJZBQIH<WEGIHCAWWIL>>? c, [Optional] Id32<BPTUUJZBQIH<WEGIHCAWWIL>>? d)
		{
			return default((Id32<XTKEAPQLAYR<YMMBJBIAQGE>>, Id32<XTKEAPQLAYR<WEGIHCAWWIL>>, Id32<XTKEAPQLAYR<BPTUUJZBQIH<WEGIHCAWWIL>>>, Id32<XTKEAPQLAYR<BPTUUJZBQIH<WEGIHCAWWIL>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x292FC80", Offset = "0x292EA80", VA = "0x18292FC80")]
		public static (Id32<XTKEAPQLAYR<YMMBJBIAQGE>>, Id32<XTKEAPQLAYR<BPTUUJZBQIH<WEGIHCAWWIL>>>, Id32<XTKEAPQLAYR<BPTUUJZBQIH<WEGIHCAWWIL>>>, Id32<XTKEAPQLAYR<BPTUUJZBQIH<WEGIHCAWWIL>>>) PJXXRRSCJIM(this UnsafeList<byte> a, [Optional] Id32<BPTUUJZBQIH<WEGIHCAWWIL>>? b, [Optional] Id32<BPTUUJZBQIH<WEGIHCAWWIL>>? c, [Optional] Id32<BPTUUJZBQIH<WEGIHCAWWIL>>? d)
		{
			return default((Id32<XTKEAPQLAYR<YMMBJBIAQGE>>, Id32<XTKEAPQLAYR<BPTUUJZBQIH<WEGIHCAWWIL>>>, Id32<XTKEAPQLAYR<BPTUUJZBQIH<WEGIHCAWWIL>>>, Id32<XTKEAPQLAYR<BPTUUJZBQIH<WEGIHCAWWIL>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x292DFA0", Offset = "0x292CDA0", VA = "0x18292DFA0")]
		public static (Id32<XTKEAPQLAYR<YMMBJBIAQGE>>, Id32<XTKEAPQLAYR<ELPJGPWQKEO>>, Id32<XTKEAPQLAYR<ELPJGPWQKEO>>, Id32<XTKEAPQLAYR<BPTUUJZBQIH<WEGIHCAWWIL>>>) IQSMYQXDHSW(this UnsafeList<byte> a, float b, float c, [Optional] Id32<BPTUUJZBQIH<WEGIHCAWWIL>>? d)
		{
			return default((Id32<XTKEAPQLAYR<YMMBJBIAQGE>>, Id32<XTKEAPQLAYR<ELPJGPWQKEO>>, Id32<XTKEAPQLAYR<ELPJGPWQKEO>>, Id32<XTKEAPQLAYR<BPTUUJZBQIH<WEGIHCAWWIL>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x292D6A0", Offset = "0x292C4A0", VA = "0x18292D6A0")]
		public static (Id32<XTKEAPQLAYR<YMMBJBIAQGE>>, Id32<XTKEAPQLAYR<ELPJGPWQKEO>>, Id32<XTKEAPQLAYR<BPTUUJZBQIH<ELPJGPWQKEO>>>, Id32<XTKEAPQLAYR<BPTUUJZBQIH<WEGIHCAWWIL>>>) GWIPDWAVTOZ(this UnsafeList<byte> a, float b, [Optional] Id32<BPTUUJZBQIH<ELPJGPWQKEO>>? c, [Optional] Id32<BPTUUJZBQIH<WEGIHCAWWIL>>? d)
		{
			return default((Id32<XTKEAPQLAYR<YMMBJBIAQGE>>, Id32<XTKEAPQLAYR<ELPJGPWQKEO>>, Id32<XTKEAPQLAYR<BPTUUJZBQIH<ELPJGPWQKEO>>>, Id32<XTKEAPQLAYR<BPTUUJZBQIH<WEGIHCAWWIL>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x292D570", Offset = "0x292C370", VA = "0x18292D570")]
		public static (Id32<XTKEAPQLAYR<YMMBJBIAQGE>>, Id32<XTKEAPQLAYR<BPTUUJZBQIH<ELPJGPWQKEO>>>, Id32<XTKEAPQLAYR<BPTUUJZBQIH<ELPJGPWQKEO>>>, Id32<XTKEAPQLAYR<BPTUUJZBQIH<WEGIHCAWWIL>>>) GTADUMMDTBS(this UnsafeList<byte> a, [Optional] Id32<BPTUUJZBQIH<ELPJGPWQKEO>>? b, [Optional] Id32<BPTUUJZBQIH<ELPJGPWQKEO>>? c, [Optional] Id32<BPTUUJZBQIH<WEGIHCAWWIL>>? d)
		{
			return default((Id32<XTKEAPQLAYR<YMMBJBIAQGE>>, Id32<XTKEAPQLAYR<BPTUUJZBQIH<ELPJGPWQKEO>>>, Id32<XTKEAPQLAYR<BPTUUJZBQIH<ELPJGPWQKEO>>>, Id32<XTKEAPQLAYR<BPTUUJZBQIH<WEGIHCAWWIL>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x2931E20", Offset = "0x2930C20", VA = "0x182931E20")]
		public static (Id32<XTKEAPQLAYR<YMMBJBIAQGE>>, Id32<XTKEAPQLAYR<WEGIHCAWWIL>>, Id32<XTKEAPQLAYR<WEGIHCAWWIL>>, Id32<XTKEAPQLAYR<BPTUUJZBQIH<WEGIHCAWWIL>>>) YWFLCTRAETJ(this UnsafeList<byte> a, int b, int c, [Optional] Id32<BPTUUJZBQIH<WEGIHCAWWIL>>? d)
		{
			return default((Id32<XTKEAPQLAYR<YMMBJBIAQGE>>, Id32<XTKEAPQLAYR<WEGIHCAWWIL>>, Id32<XTKEAPQLAYR<WEGIHCAWWIL>>, Id32<XTKEAPQLAYR<BPTUUJZBQIH<WEGIHCAWWIL>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x292D800", Offset = "0x292C600", VA = "0x18292D800")]
		public static (Id32<XTKEAPQLAYR<YMMBJBIAQGE>>, Id32<XTKEAPQLAYR<WEGIHCAWWIL>>, Id32<XTKEAPQLAYR<BPTUUJZBQIH<WEGIHCAWWIL>>>, Id32<XTKEAPQLAYR<BPTUUJZBQIH<WEGIHCAWWIL>>>) HPRDMJUZQRW(this UnsafeList<byte> a, int b, [Optional] Id32<BPTUUJZBQIH<WEGIHCAWWIL>>? c, [Optional] Id32<BPTUUJZBQIH<WEGIHCAWWIL>>? d)
		{
			return default((Id32<XTKEAPQLAYR<YMMBJBIAQGE>>, Id32<XTKEAPQLAYR<WEGIHCAWWIL>>, Id32<XTKEAPQLAYR<BPTUUJZBQIH<WEGIHCAWWIL>>>, Id32<XTKEAPQLAYR<BPTUUJZBQIH<WEGIHCAWWIL>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x292C740", Offset = "0x292B540", VA = "0x18292C740")]
		public static (Id32<XTKEAPQLAYR<YMMBJBIAQGE>>, Id32<XTKEAPQLAYR<BPTUUJZBQIH<WEGIHCAWWIL>>>, Id32<XTKEAPQLAYR<BPTUUJZBQIH<WEGIHCAWWIL>>>, Id32<XTKEAPQLAYR<BPTUUJZBQIH<WEGIHCAWWIL>>>) ANBUTAZUTND(this UnsafeList<byte> a, [Optional] Id32<BPTUUJZBQIH<WEGIHCAWWIL>>? b, [Optional] Id32<BPTUUJZBQIH<WEGIHCAWWIL>>? c, [Optional] Id32<BPTUUJZBQIH<WEGIHCAWWIL>>? d)
		{
			return default((Id32<XTKEAPQLAYR<YMMBJBIAQGE>>, Id32<XTKEAPQLAYR<BPTUUJZBQIH<WEGIHCAWWIL>>>, Id32<XTKEAPQLAYR<BPTUUJZBQIH<WEGIHCAWWIL>>>, Id32<XTKEAPQLAYR<BPTUUJZBQIH<WEGIHCAWWIL>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x292FB00", Offset = "0x292E900", VA = "0x18292FB00")]
		public static (Id32<XTKEAPQLAYR<YMMBJBIAQGE>>, Id32<XTKEAPQLAYR<ELPJGPWQKEO>>, Id32<XTKEAPQLAYR<ELPJGPWQKEO>>, Id32<XTKEAPQLAYR<BPTUUJZBQIH<ELPJGPWQKEO>>>) OUGJSYWDSYB(this UnsafeList<byte> a, float b, float c, [Optional] Id32<BPTUUJZBQIH<ELPJGPWQKEO>>? d)
		{
			return default((Id32<XTKEAPQLAYR<YMMBJBIAQGE>>, Id32<XTKEAPQLAYR<ELPJGPWQKEO>>, Id32<XTKEAPQLAYR<ELPJGPWQKEO>>, Id32<XTKEAPQLAYR<BPTUUJZBQIH<ELPJGPWQKEO>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x2930010", Offset = "0x292EE10", VA = "0x182930010")]
		public static (Id32<XTKEAPQLAYR<YMMBJBIAQGE>>, Id32<XTKEAPQLAYR<ELPJGPWQKEO>>, Id32<XTKEAPQLAYR<BPTUUJZBQIH<ELPJGPWQKEO>>>, Id32<XTKEAPQLAYR<BPTUUJZBQIH<ELPJGPWQKEO>>>) PZQEWRZJXOW(this UnsafeList<byte> a, float b, [Optional] Id32<BPTUUJZBQIH<ELPJGPWQKEO>>? c, [Optional] Id32<BPTUUJZBQIH<ELPJGPWQKEO>>? d)
		{
			return default((Id32<XTKEAPQLAYR<YMMBJBIAQGE>>, Id32<XTKEAPQLAYR<ELPJGPWQKEO>>, Id32<XTKEAPQLAYR<BPTUUJZBQIH<ELPJGPWQKEO>>>, Id32<XTKEAPQLAYR<BPTUUJZBQIH<ELPJGPWQKEO>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x292CF20", Offset = "0x292BD20", VA = "0x18292CF20")]
		public static (Id32<XTKEAPQLAYR<YMMBJBIAQGE>>, Id32<XTKEAPQLAYR<BPTUUJZBQIH<ELPJGPWQKEO>>>, Id32<XTKEAPQLAYR<BPTUUJZBQIH<ELPJGPWQKEO>>>, Id32<XTKEAPQLAYR<BPTUUJZBQIH<ELPJGPWQKEO>>>) DNILHRRDINF(this UnsafeList<byte> a, [Optional] Id32<BPTUUJZBQIH<ELPJGPWQKEO>>? b, [Optional] Id32<BPTUUJZBQIH<ELPJGPWQKEO>>? c, [Optional] Id32<BPTUUJZBQIH<ELPJGPWQKEO>>? d)
		{
			return default((Id32<XTKEAPQLAYR<YMMBJBIAQGE>>, Id32<XTKEAPQLAYR<BPTUUJZBQIH<ELPJGPWQKEO>>>, Id32<XTKEAPQLAYR<BPTUUJZBQIH<ELPJGPWQKEO>>>, Id32<XTKEAPQLAYR<BPTUUJZBQIH<ELPJGPWQKEO>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x292F100", Offset = "0x292DF00", VA = "0x18292F100")]
		public static (Id32<XTKEAPQLAYR<YMMBJBIAQGE>>, Id32<XTKEAPQLAYR<WEGIHCAWWIL>>, Id32<XTKEAPQLAYR<WEGIHCAWWIL>>, Id32<XTKEAPQLAYR<BPTUUJZBQIH<WEGIHCAWWIL>>>) LZXWRPZYFET(this UnsafeList<byte> a, int b, int c, [Optional] Id32<BPTUUJZBQIH<WEGIHCAWWIL>>? d)
		{
			return default((Id32<XTKEAPQLAYR<YMMBJBIAQGE>>, Id32<XTKEAPQLAYR<WEGIHCAWWIL>>, Id32<XTKEAPQLAYR<WEGIHCAWWIL>>, Id32<XTKEAPQLAYR<BPTUUJZBQIH<WEGIHCAWWIL>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x292E4B0", Offset = "0x292D2B0", VA = "0x18292E4B0")]
		public static (Id32<XTKEAPQLAYR<YMMBJBIAQGE>>, Id32<XTKEAPQLAYR<WEGIHCAWWIL>>, Id32<XTKEAPQLAYR<BPTUUJZBQIH<WEGIHCAWWIL>>>, Id32<XTKEAPQLAYR<BPTUUJZBQIH<WEGIHCAWWIL>>>) KYLEYERNOBG(this UnsafeList<byte> a, int b, [Optional] Id32<BPTUUJZBQIH<WEGIHCAWWIL>>? c, [Optional] Id32<BPTUUJZBQIH<WEGIHCAWWIL>>? d)
		{
			return default((Id32<XTKEAPQLAYR<YMMBJBIAQGE>>, Id32<XTKEAPQLAYR<WEGIHCAWWIL>>, Id32<XTKEAPQLAYR<BPTUUJZBQIH<WEGIHCAWWIL>>>, Id32<XTKEAPQLAYR<BPTUUJZBQIH<WEGIHCAWWIL>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x292DD60", Offset = "0x292CB60", VA = "0x18292DD60")]
		public static (Id32<XTKEAPQLAYR<YMMBJBIAQGE>>, Id32<XTKEAPQLAYR<BPTUUJZBQIH<WEGIHCAWWIL>>>, Id32<XTKEAPQLAYR<BPTUUJZBQIH<WEGIHCAWWIL>>>, Id32<XTKEAPQLAYR<BPTUUJZBQIH<WEGIHCAWWIL>>>) IMNXORQWFPP(this UnsafeList<byte> a, [Optional] Id32<BPTUUJZBQIH<WEGIHCAWWIL>>? b, [Optional] Id32<BPTUUJZBQIH<WEGIHCAWWIL>>? c, [Optional] Id32<BPTUUJZBQIH<WEGIHCAWWIL>>? d)
		{
			return default((Id32<XTKEAPQLAYR<YMMBJBIAQGE>>, Id32<XTKEAPQLAYR<BPTUUJZBQIH<WEGIHCAWWIL>>>, Id32<XTKEAPQLAYR<BPTUUJZBQIH<WEGIHCAWWIL>>>, Id32<XTKEAPQLAYR<BPTUUJZBQIH<WEGIHCAWWIL>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x2930400", Offset = "0x292F200", VA = "0x182930400")]
		public static (Id32<XTKEAPQLAYR<YMMBJBIAQGE>>, Id32<XTKEAPQLAYR<WEGIHCAWWIL>>, Id32<XTKEAPQLAYR<BPTUUJZBQIH<WEGIHCAWWIL>>>) QLDGCBXUXNW(this UnsafeList<byte> a, [Optional] int? b, [Optional] Id32<BPTUUJZBQIH<WEGIHCAWWIL>>? c)
		{
			return default((Id32<XTKEAPQLAYR<YMMBJBIAQGE>>, Id32<XTKEAPQLAYR<WEGIHCAWWIL>>, Id32<XTKEAPQLAYR<BPTUUJZBQIH<WEGIHCAWWIL>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x292E240", Offset = "0x292D040", VA = "0x18292E240")]
		public static (Id32<XTKEAPQLAYR<YMMBJBIAQGE>>, Id32<XTKEAPQLAYR<BPTUUJZBQIH<WEGIHCAWWIL>>>, Id32<XTKEAPQLAYR<BPTUUJZBQIH<WEGIHCAWWIL>>>) KRQJGCVJFAX(this UnsafeList<byte> a, [Optional] Id32<BPTUUJZBQIH<WEGIHCAWWIL>>? b, [Optional] Id32<BPTUUJZBQIH<WEGIHCAWWIL>>? c)
		{
			return default((Id32<XTKEAPQLAYR<YMMBJBIAQGE>>, Id32<XTKEAPQLAYR<BPTUUJZBQIH<WEGIHCAWWIL>>>, Id32<XTKEAPQLAYR<BPTUUJZBQIH<WEGIHCAWWIL>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x292D3E0", Offset = "0x292C1E0", VA = "0x18292D3E0")]
		public static Id32<XTKEAPQLAYR<YMMBJBIAQGE>> GFPHBFALDIC(this UnsafeList<byte> a)
		{
			return default(Id32<XTKEAPQLAYR<YMMBJBIAQGE>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x292F860", Offset = "0x292E660", VA = "0x18292F860")]
		public static (Id32<XTKEAPQLAYR<YMMBJBIAQGE>>, Id32<XTKEAPQLAYR<ELPJGPWQKEO>>, Id32<XTKEAPQLAYR<ELPJGPWQKEO>>, Id32<XTKEAPQLAYR<BPTUUJZBQIH<ELPJGPWQKEO>>>) NZZAUAPMXCV(this UnsafeList<byte> a, float b, float c, [Optional] Id32<BPTUUJZBQIH<ELPJGPWQKEO>>? d)
		{
			return default((Id32<XTKEAPQLAYR<YMMBJBIAQGE>>, Id32<XTKEAPQLAYR<ELPJGPWQKEO>>, Id32<XTKEAPQLAYR<ELPJGPWQKEO>>, Id32<XTKEAPQLAYR<BPTUUJZBQIH<ELPJGPWQKEO>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x2931830", Offset = "0x2930630", VA = "0x182931830")]
		public static (Id32<XTKEAPQLAYR<YMMBJBIAQGE>>, Id32<XTKEAPQLAYR<ELPJGPWQKEO>>, Id32<XTKEAPQLAYR<BPTUUJZBQIH<ELPJGPWQKEO>>>, Id32<XTKEAPQLAYR<BPTUUJZBQIH<ELPJGPWQKEO>>>) XWJKELUTICO(this UnsafeList<byte> a, float b, [Optional] Id32<BPTUUJZBQIH<ELPJGPWQKEO>>? c, [Optional] Id32<BPTUUJZBQIH<ELPJGPWQKEO>>? d)
		{
			return default((Id32<XTKEAPQLAYR<YMMBJBIAQGE>>, Id32<XTKEAPQLAYR<ELPJGPWQKEO>>, Id32<XTKEAPQLAYR<BPTUUJZBQIH<ELPJGPWQKEO>>>, Id32<XTKEAPQLAYR<BPTUUJZBQIH<ELPJGPWQKEO>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x2930A00", Offset = "0x292F800", VA = "0x182930A00")]
		public static (Id32<XTKEAPQLAYR<YMMBJBIAQGE>>, Id32<XTKEAPQLAYR<BPTUUJZBQIH<ELPJGPWQKEO>>>, Id32<XTKEAPQLAYR<BPTUUJZBQIH<ELPJGPWQKEO>>>, Id32<XTKEAPQLAYR<BPTUUJZBQIH<ELPJGPWQKEO>>>) RZHTRGHRBAH(this UnsafeList<byte> a, [Optional] Id32<BPTUUJZBQIH<ELPJGPWQKEO>>? b, [Optional] Id32<BPTUUJZBQIH<ELPJGPWQKEO>>? c, [Optional] Id32<BPTUUJZBQIH<ELPJGPWQKEO>>? d)
		{
			return default((Id32<XTKEAPQLAYR<YMMBJBIAQGE>>, Id32<XTKEAPQLAYR<BPTUUJZBQIH<ELPJGPWQKEO>>>, Id32<XTKEAPQLAYR<BPTUUJZBQIH<ELPJGPWQKEO>>>, Id32<XTKEAPQLAYR<BPTUUJZBQIH<ELPJGPWQKEO>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x292DAA0", Offset = "0x292C8A0", VA = "0x18292DAA0")]
		public static (Id32<XTKEAPQLAYR<YMMBJBIAQGE>>, Id32<XTKEAPQLAYR<WEGIHCAWWIL>>, Id32<XTKEAPQLAYR<WEGIHCAWWIL>>, Id32<XTKEAPQLAYR<BPTUUJZBQIH<WEGIHCAWWIL>>>) HRGVVIUBPEX(this UnsafeList<byte> a, int b, int c, [Optional] Id32<BPTUUJZBQIH<WEGIHCAWWIL>>? d)
		{
			return default((Id32<XTKEAPQLAYR<YMMBJBIAQGE>>, Id32<XTKEAPQLAYR<WEGIHCAWWIL>>, Id32<XTKEAPQLAYR<WEGIHCAWWIL>>, Id32<XTKEAPQLAYR<BPTUUJZBQIH<WEGIHCAWWIL>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x292F5F0", Offset = "0x292E3F0", VA = "0x18292F5F0")]
		public static (Id32<XTKEAPQLAYR<YMMBJBIAQGE>>, Id32<XTKEAPQLAYR<WEGIHCAWWIL>>, Id32<XTKEAPQLAYR<BPTUUJZBQIH<WEGIHCAWWIL>>>, Id32<XTKEAPQLAYR<BPTUUJZBQIH<WEGIHCAWWIL>>>) NKTSRHWNHRW(this UnsafeList<byte> a, int b, [Optional] Id32<BPTUUJZBQIH<WEGIHCAWWIL>>? c, [Optional] Id32<BPTUUJZBQIH<WEGIHCAWWIL>>? d)
		{
			return default((Id32<XTKEAPQLAYR<YMMBJBIAQGE>>, Id32<XTKEAPQLAYR<WEGIHCAWWIL>>, Id32<XTKEAPQLAYR<BPTUUJZBQIH<WEGIHCAWWIL>>>, Id32<XTKEAPQLAYR<BPTUUJZBQIH<WEGIHCAWWIL>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x2930C40", Offset = "0x292FA40", VA = "0x182930C40")]
		public static (Id32<XTKEAPQLAYR<YMMBJBIAQGE>>, Id32<XTKEAPQLAYR<BPTUUJZBQIH<WEGIHCAWWIL>>>, Id32<XTKEAPQLAYR<BPTUUJZBQIH<WEGIHCAWWIL>>>, Id32<XTKEAPQLAYR<BPTUUJZBQIH<WEGIHCAWWIL>>>) SMEMCXPEYQN(this UnsafeList<byte> a, [Optional] Id32<BPTUUJZBQIH<WEGIHCAWWIL>>? b, [Optional] Id32<BPTUUJZBQIH<WEGIHCAWWIL>>? c, [Optional] Id32<BPTUUJZBQIH<WEGIHCAWWIL>>? d)
		{
			return default((Id32<XTKEAPQLAYR<YMMBJBIAQGE>>, Id32<XTKEAPQLAYR<BPTUUJZBQIH<WEGIHCAWWIL>>>, Id32<XTKEAPQLAYR<BPTUUJZBQIH<WEGIHCAWWIL>>>, Id32<XTKEAPQLAYR<BPTUUJZBQIH<WEGIHCAWWIL>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x292E780", Offset = "0x292D580", VA = "0x18292E780")]
		public static (Id32<XTKEAPQLAYR<YMMBJBIAQGE>>, Id32<XTKEAPQLAYR<WEGIHCAWWIL>>, Id32<XTKEAPQLAYR<WEGIHCAWWIL>>, Id32<XTKEAPQLAYR<BPTUUJZBQIH<WEGIHCAWWIL>>>) LBZNNVKCEXM(this UnsafeList<byte> a, int b, int c, [Optional] Id32<BPTUUJZBQIH<WEGIHCAWWIL>>? d)
		{
			return default((Id32<XTKEAPQLAYR<YMMBJBIAQGE>>, Id32<XTKEAPQLAYR<WEGIHCAWWIL>>, Id32<XTKEAPQLAYR<WEGIHCAWWIL>>, Id32<XTKEAPQLAYR<BPTUUJZBQIH<WEGIHCAWWIL>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x29308B0", Offset = "0x292F6B0", VA = "0x1829308B0")]
		public static (Id32<XTKEAPQLAYR<YMMBJBIAQGE>>, Id32<XTKEAPQLAYR<WEGIHCAWWIL>>, Id32<XTKEAPQLAYR<BPTUUJZBQIH<WEGIHCAWWIL>>>, Id32<XTKEAPQLAYR<BPTUUJZBQIH<WEGIHCAWWIL>>>) RTZSSOQUZVX(this UnsafeList<byte> a, int b, [Optional] Id32<BPTUUJZBQIH<WEGIHCAWWIL>>? c, [Optional] Id32<BPTUUJZBQIH<WEGIHCAWWIL>>? d)
		{
			return default((Id32<XTKEAPQLAYR<YMMBJBIAQGE>>, Id32<XTKEAPQLAYR<WEGIHCAWWIL>>, Id32<XTKEAPQLAYR<BPTUUJZBQIH<WEGIHCAWWIL>>>, Id32<XTKEAPQLAYR<BPTUUJZBQIH<WEGIHCAWWIL>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x292E120", Offset = "0x292CF20", VA = "0x18292E120")]
		public static (Id32<XTKEAPQLAYR<YMMBJBIAQGE>>, Id32<XTKEAPQLAYR<BPTUUJZBQIH<WEGIHCAWWIL>>>, Id32<XTKEAPQLAYR<BPTUUJZBQIH<WEGIHCAWWIL>>>, Id32<XTKEAPQLAYR<BPTUUJZBQIH<WEGIHCAWWIL>>>) JOMGMDBYMKQ(this UnsafeList<byte> a, [Optional] Id32<BPTUUJZBQIH<WEGIHCAWWIL>>? b, [Optional] Id32<BPTUUJZBQIH<WEGIHCAWWIL>>? c, [Optional] Id32<BPTUUJZBQIH<WEGIHCAWWIL>>? d)
		{
			return default((Id32<XTKEAPQLAYR<YMMBJBIAQGE>>, Id32<XTKEAPQLAYR<BPTUUJZBQIH<WEGIHCAWWIL>>>, Id32<XTKEAPQLAYR<BPTUUJZBQIH<WEGIHCAWWIL>>>, Id32<XTKEAPQLAYR<BPTUUJZBQIH<WEGIHCAWWIL>>>));
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
