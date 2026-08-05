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
		[Cpp2IlInjected.Address(RVA = "0xAD7680", Offset = "0xAD5E80", VA = "0x180AD7680")]
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
		[Cpp2IlInjected.Address(RVA = "0x28D2AF0", Offset = "0x28D12F0", VA = "0x1828D2AF0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xAD7810", Offset = "0xAD6010", VA = "0x180AD7810")]
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
		[Cpp2IlInjected.Address(RVA = "0xAD7850", Offset = "0xAD6050", VA = "0x180AD7850")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
namespace Circuits.Shared.Core.ByteCode
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public static class FUALIJSRHLS
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x36B07C0", Offset = "0x36AEFC0", VA = "0x1836B07C0")]
		public static Id32<BMUDIFIQDFI<a>> WCFOSWFBLGO<a>(this int a)
		{
			return default(Id32<BMUDIFIQDFI<a>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x28D2AB0", Offset = "0x28D12B0", VA = "0x1828D2AB0")]
		public static Id32<JVDVMJBLEIH> BXUKRAPDSGD(this int a)
		{
			return default(Id32<JVDVMJBLEIH>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x36B07C0", Offset = "0x36AEFC0", VA = "0x1836B07C0")]
		public static Id32<GZQXHQYHYRK<b>> MXOSWBXAHXC<b>(this int a)
		{
			return default(Id32<GZQXHQYHYRK<b>>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public sealed class BMUDIFIQDFI<a>
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public sealed class EAYDFNCAMWR
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public sealed class MYAKJBUXDCU
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public sealed class JVDVMJBLEIH
	{
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public sealed class GMQAJYKQXXD
	{
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public sealed class NMGQLSMGBBZ
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
	public static class QLEHJPFNNYA
	{
		[Cpp2IlInjected.Token(Token = "0x200000E")]
		public readonly struct ProcessOpDelegate<TContext, TDeps, TCompileState>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000091")]
			private readonly IntPtr _impl;

			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0xC21680", Offset = "0xC1FE80", VA = "0x180C21680")]
			public ProcessOpDelegate(IntPtr impl)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x5AF0240", Offset = "0x5AEEA40", VA = "0x185AF0240")]
			public int Invoke(TDeps deps, TContext ctx, TCompileState compileState, [In] UnsafeList<byte> fromByteCode, int byteCodePtr)
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x396F690", Offset = "0x396DE90", VA = "0x18396F690")]
		public static void JRZGAXJSFVB<TDeps, TContext, TCompileState>(TDeps a, TContext b, TCompileState c, [In] UnsafeList<byte> oldByteCode, UnsafeList<byte> newByteCode, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processAddF32_F32i_F32i_F32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processAddF32_F32i_F32r_F32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processAddF32_F32r_F32r_F32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processAddI32_I32i_I32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processAddI32_I32i_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processAddI32_I32r_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processAndI32_I32i_I32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processAndI32_I32i_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processAndI32_I32r_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfEqualF32_F32i_F32i_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfEqualF32_F32i_F32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfEqualF32_F32r_F32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfEqualI32_I32i_I32i_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfEqualI32_I32i_I32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfEqualI32_I32r_I32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfGreaterOrEqualF32_F32i_F32i_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfGreaterOrEqualF32_F32i_F32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfGreaterOrEqualF32_F32r_F32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfGreaterOrEqualI32_I32i_I32i_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfGreaterOrEqualI32_I32i_I32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfGreaterOrEqualI32_I32r_I32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfLessF32_F32i_F32i_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfLessF32_F32i_F32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfLessF32_F32r_F32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfLessI32_I32i_I32i_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfLessI32_I32i_I32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfLessI32_I32r_I32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfLessOrEqualF32_F32i_F32i_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfLessOrEqualF32_F32i_F32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfLessOrEqualF32_F32r_F32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfLessOrEqualI32_I32i_I32i_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfLessOrEqualI32_I32i_I32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfLessOrEqualI32_I32r_I32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfNotEqualF32_F32i_F32i_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfNotEqualF32_F32i_F32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfNotEqualF32_F32r_F32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfNotEqualI32_I32i_I32i_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfNotEqualI32_I32i_I32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfNotEqualI32_I32r_I32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfNotZeroF32_F32i_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfNotZeroF32_F32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfNotZeroI32_I32i_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfNotZeroI32_I32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfZeroF32_F32i_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfZeroF32_F32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfZeroI32_I32i_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfZeroI32_I32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processCallInternal_I32i_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processCallInternal_I32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processCallExternal_I32i_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processCallExternal_I32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processCallRuntime_I32i_I32i_Xi, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processCopyI32_I32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processCopyI32_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processCopyX_Xr_I32i_Xi, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processCopyX_Xr_Xr_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processDivideF32_F32i_F32i_F32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processDivideF32_F32i_F32r_F32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processDivideF32_F32r_F32r_F32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processDivideI32_I32i_I32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processDivideI32_I32i_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processDivideI32_I32r_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processEqualF32_F32i_F32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processEqualF32_F32i_F32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processEqualF32_F32r_F32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processEqualI32_I32i_I32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processEqualI32_I32i_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processEqualI32_I32r_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processEnd, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processGreaterF32_F32i_F32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processGreaterF32_F32i_F32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processGreaterF32_F32r_F32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processGreaterI32_I32i_I32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processGreaterI32_I32i_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processGreaterI32_I32r_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processGreaterOrEqualF32_F32i_F32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processGreaterOrEqualF32_F32i_F32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processGreaterOrEqualF32_F32r_F32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processGreaterOrEqualI32_I32i_I32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processGreaterOrEqualI32_I32i_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processGreaterOrEqualI32_I32r_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processJump_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processJump_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processLessF32_F32i_F32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processLessF32_F32i_F32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processLessF32_F32r_F32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processLessI32_I32i_I32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processLessI32_I32i_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processLessI32_I32r_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processLessOrEqualF32_F32i_F32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processLessOrEqualF32_F32i_F32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processLessOrEqualF32_F32r_F32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processLessOrEqualI32_I32i_I32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processLessOrEqualI32_I32i_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processLessOrEqualI32_I32r_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processModI32_I32i_I32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processModI32_I32i_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processModI32_I32r_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processMultiplyF32_F32i_F32i_F32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processMultiplyF32_F32i_F32r_F32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processMultiplyF32_F32r_F32r_F32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processMultiplyI32_I32i_I32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processMultiplyI32_I32i_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processMultiplyI32_I32r_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processNegateF32_F32i_F32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processNegateF32_F32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processNegateF32_F32r_F32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processNegateI32_I32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processNegateI32_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processNegateI32_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processNoOp, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processNotEqualF32_F32i_F32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processNotEqualF32_F32i_F32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processNotEqualF32_F32r_F32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processNotEqualI32_I32i_I32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processNotEqualI32_I32i_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processNotEqualI32_I32r_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processNotI32_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processNotI32_I32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processNotI32_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processOrI32_I32i_I32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processOrI32_I32i_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processOrI32_I32r_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processReturn, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processStaticCastF32I32_F32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processStaticCastI32F32_I32r_F32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processSubtractF32_F32i_F32i_F32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processSubtractF32_F32i_F32r_F32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processSubtractF32_F32r_F32r_F32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processSubtractI32_I32i_I32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processSubtractI32_I32i_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processSubtractI32_I32r_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processXorI32_I32i_I32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processXorI32_I32i_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processXorI32_I32r_I32r_I32r) where TDeps : notnull where TContext : notnull where TCompileState : notnull
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x28D2B70", Offset = "0x28D1370", VA = "0x1828D2B70")]
		private static int NULFYMVCNYN([In] UnsafeList<byte> from, UnsafeList<byte> a, int b, int c)
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public static class EXCBWUDMRXN
	{
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		public static readonly int USWIZGBGEUD;

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x35D3210", Offset = "0x35D1A10", VA = "0x1835D3210")]
		public static Id32<BMUDIFIQDFI<a>> SNUYLNVUNTX<a>([In] this UnsafeList<byte> self)
		{
			return default(Id32<BMUDIFIQDFI<a>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x35D30E0", Offset = "0x35D18E0", VA = "0x1835D30E0")]
		public static Id32<BMUDIFIQDFI<BMUDIFIQDFI<b>>> JORSCFWNMGW<b>(this UnsafeList<byte> a, [Optional] Id32<BMUDIFIQDFI<b>>? b)
		{
			return default(Id32<BMUDIFIQDFI<BMUDIFIQDFI<b>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x28D2980", Offset = "0x28D1180", VA = "0x1828D2980")]
		public static Id32<BMUDIFIQDFI<ULSOTBCMXIN>> TOXCYJHJGMY(this UnsafeList<byte> a, [Optional] Id32<ULSOTBCMXIN>? b)
		{
			return default(Id32<BMUDIFIQDFI<ULSOTBCMXIN>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x28D24E0", Offset = "0x28D0CE0", VA = "0x1828D24E0")]
		public static Id32<BMUDIFIQDFI<EAYDFNCAMWR>> GRVXGUNSSUK(this UnsafeList<byte> a, [Optional] float? b)
		{
			return default(Id32<BMUDIFIQDFI<EAYDFNCAMWR>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x28D26C0", Offset = "0x28D0EC0", VA = "0x1828D26C0")]
		public static Id32<BMUDIFIQDFI<MYAKJBUXDCU>> SJVFGLSYXWP(this UnsafeList<byte> a, [Optional] int? b)
		{
			return default(Id32<BMUDIFIQDFI<MYAKJBUXDCU>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x28D2890", Offset = "0x28D1090", VA = "0x1828D2890")]
		public static Id32<BMUDIFIQDFI<PBOKRPYDFLU>> SRRYYFDHCWF(this UnsafeList<byte> a, [Optional] Id32<PBOKRPYDFLU>? b)
		{
			return default(Id32<BMUDIFIQDFI<PBOKRPYDFLU>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x28D23E0", Offset = "0x28D0BE0", VA = "0x1828D23E0")]
		public static Id32<BMUDIFIQDFI<NMGQLSMGBBZ>> FYCXKLPVXZI(this UnsafeList<byte> a, [Optional] byte? b)
		{
			return default(Id32<BMUDIFIQDFI<NMGQLSMGBBZ>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x28D27A0", Offset = "0x28D0FA0", VA = "0x1828D27A0")]
		public static Id32<BMUDIFIQDFI<JVDVMJBLEIH>> SNDNBOZTTMC(this UnsafeList<byte> a, [Optional] Id32<JVDVMJBLEIH>? b)
		{
			return default(Id32<BMUDIFIQDFI<JVDVMJBLEIH>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x28D25D0", Offset = "0x28D0DD0", VA = "0x1828D25D0")]
		public static Id32<BMUDIFIQDFI<GMQAJYKQXXD>> NBLDIIVVEAM(this UnsafeList<byte> a, [Optional] Op? b)
		{
			return default(Id32<BMUDIFIQDFI<GMQAJYKQXXD>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x35D30E0", Offset = "0x35D18E0", VA = "0x1835D30E0")]
		public static Id32<BMUDIFIQDFI<GZQXHQYHYRK<c>>> YPGEOECIVKQ<c>(this UnsafeList<byte> a, [Optional] Id32<GZQXHQYHYRK<c>>? b)
		{
			return default(Id32<BMUDIFIQDFI<GZQXHQYHYRK<c>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x28D2230", Offset = "0x28D0A30", VA = "0x1828D2230")]
		public static void KWUDUQPTYVW(this UnsafeList<byte> a, Id32<BMUDIFIQDFI<MYAKJBUXDCU>> b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x35D2FE0", Offset = "0x35D17E0", VA = "0x1835D2FE0")]
		public static void FGPJIEHTUPH<d>(this UnsafeList<byte> a, Id32<BMUDIFIQDFI<BMUDIFIQDFI<d>>> b, Id32<BMUDIFIQDFI<d>> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x35D2FE0", Offset = "0x35D17E0", VA = "0x1835D2FE0")]
		public static void NRQBFTOGHXB<e>(this UnsafeList<byte> a, Id32<BMUDIFIQDFI<GZQXHQYHYRK<e>>> b, Id32<GZQXHQYHYRK<e>> c)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public static class ZLKTGVFDJKC
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x28D8910", Offset = "0x28D7110", VA = "0x1828D8910")]
		public static Union32 XEQYPMWOKCE([In] this ReadOnlySpan<byte> bytes, int a)
		{
			return default(Union32);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x28D8980", Offset = "0x28D7180", VA = "0x1828D8980")]
		public static Union32 XEQYPMWOKCE([In] this UnsafeList<byte> bytes, int a)
		{
			return default(Union32);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x3C44E20", Offset = "0x3C43620", VA = "0x183C44E20")]
		public static Union32 XEQYPMWOKCE<f>(this ReadOnlyIdArray<f, byte> a, Id32<f> b)
		{
			return default(Union32);
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x3C45070", Offset = "0x3C43870", VA = "0x183C45070")]
		public static Union32 XEQYPMWOKCE<g>([In] this ReadOnlyIdSpan<g, byte> bytes, Id32<g> a)
		{
			return default(Union32);
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x3C44FA0", Offset = "0x3C437A0", VA = "0x183C44FA0")]
		public static Union32 XEQYPMWOKCE<i>(this IdArray<i, byte> a, Id32<i> b)
		{
			return default(Union32);
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x3C45000", Offset = "0x3C43800", VA = "0x183C45000")]
		public static Union32 XEQYPMWOKCE<j>([In] this IdSpan<j, byte> bytes, Id32<j> a)
		{
			return default(Union32);
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x3C451F0", Offset = "0x3C439F0", VA = "0x183C451F0")]
		public static Union32 XEQYPMWOKCE<k>(this ReadOnlyIdArray<k, byte> a, Id32<k> b)
		{
			return default(Union32);
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x28D8910", Offset = "0x28D7110", VA = "0x1828D8910")]
		public static int IMJHSBGWORB([In] this ReadOnlySpan<byte> bytes, int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x28D2330", Offset = "0x28D0B30", VA = "0x1828D2330")]
		public static int IMJHSBGWORB([In] this UnsafeList<byte> bytes, int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x3C43FC0", Offset = "0x3C427C0", VA = "0x183C43FC0")]
		public static int IMJHSBGWORB<p>(this ReadOnlyIdArray<p, byte> a, Id32<p> b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x3C44060", Offset = "0x3C42860", VA = "0x183C44060")]
		public static int IMJHSBGWORB<s>(this IdArray<s, byte> a, Id32<s> b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x3C44010", Offset = "0x3C42810", VA = "0x183C44010")]
		public static int IMJHSBGWORB<t>([In] this IdSpan<t, byte> bytes, Id32<t> a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x3C440E0", Offset = "0x3C428E0", VA = "0x183C440E0")]
		public static int IMJHSBGWORB<u>(this ReadOnlyIdArray<u, byte> a, Id32<u> b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x3C447F0", Offset = "0x3C42FF0", VA = "0x183C447F0")]
		public static float QTSIRPCQCNE<bc>(this IdArray<bc, byte> a, Id32<bc> b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x3C44870", Offset = "0x3C43070", VA = "0x183C44870")]
		public static float QTSIRPCQCNE<bd>([In] this IdSpan<bd, byte> bytes, Id32<bd> a)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x3C448C0", Offset = "0x3C430C0", VA = "0x183C448C0")]
		public static float QTSIRPCQCNE<be>(this ReadOnlyIdArray<be, byte> a, Id32<be> b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x3C43C50", Offset = "0x3C42450", VA = "0x183C43C50")]
		public static byte BIWMGTUYCKG<bj>(this ReadOnlyIdArray<bj, byte> a, Id32<bj> b)
		{
			return default(byte);
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x3C43CA0", Offset = "0x3C424A0", VA = "0x183C43CA0")]
		public static byte BIWMGTUYCKG<bk>([In] this ReadOnlyIdSpan<bk, byte> bytes, Id32<bk> a)
		{
			return default(byte);
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x3C43DC0", Offset = "0x3C425C0", VA = "0x183C43DC0")]
		public static byte BIWMGTUYCKG<bm>(this IdArray<bm, byte> a, Id32<bm> b)
		{
			return default(byte);
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x3C43E40", Offset = "0x3C42640", VA = "0x183C43E40")]
		public static byte BIWMGTUYCKG<bn>([In] this IdSpan<bn, byte> bytes, Id32<bn> a)
		{
			return default(byte);
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x3C43CF0", Offset = "0x3C424F0", VA = "0x183C43CF0")]
		public static byte BIWMGTUYCKG<bo>(this ReadOnlyIdArray<bo, byte> a, Id32<bo> b)
		{
			return default(byte);
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x28D2330", Offset = "0x28D0B30", VA = "0x1828D2330")]
		public static Op POPWCLWRSKM([In] this UnsafeList<byte> bytes, int a)
		{
			return default(Op);
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x3C44670", Offset = "0x3C42E70", VA = "0x183C44670")]
		public static Op POPWCLWRSKM<by>(this ReadOnlyIdArray<by, byte> a, Id32<by> b)
		{
			return default(Op);
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x3C44450", Offset = "0x3C42C50", VA = "0x183C44450")]
		public static Id32<BMUDIFIQDFI<JRUSPVYOFZC>> MZCUARVJZWO<cg>(this IdArray<cg, byte> a, Id32<cg> b)
		{
			return default(Id32<BMUDIFIQDFI<JRUSPVYOFZC>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x3C443C0", Offset = "0x3C42BC0", VA = "0x183C443C0")]
		public static Id32<BMUDIFIQDFI<JRUSPVYOFZC>> MZCUARVJZWO<ch>([In] this IdSpan<ch, byte> bytes, Id32<ch> a)
		{
			return default(Id32<BMUDIFIQDFI<JRUSPVYOFZC>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x3C444D0", Offset = "0x3C42CD0", VA = "0x183C444D0")]
		public static Id32<BMUDIFIQDFI<JRUSPVYOFZC>> MZCUARVJZWO<ci>(this ReadOnlyIdArray<ci, byte> a, Id32<ci> b)
		{
			return default(Id32<BMUDIFIQDFI<JRUSPVYOFZC>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x3C445E0", Offset = "0x3C42DE0", VA = "0x183C445E0")]
		public static Id32<GZQXHQYHYRK<JRUSPVYOFZC>> OJJFAXNJDVG<cs>(this ReadOnlyIdArray<cs, byte> a, Id32<cs> b)
		{
			return default(Id32<GZQXHQYHYRK<JRUSPVYOFZC>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x3C438A0", Offset = "0x3C420A0", VA = "0x183C438A0")]
		public static Id32<JVDVMJBLEIH> AAXUYBXZZCU<da>(this IdArray<da, byte> a, Id32<da> b)
		{
			return default(Id32<JVDVMJBLEIH>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x3C43920", Offset = "0x3C42120", VA = "0x183C43920")]
		public static Id32<JVDVMJBLEIH> AAXUYBXZZCU<db>([In] this IdSpan<db, byte> bytes, Id32<db> a)
		{
			return default(Id32<JVDVMJBLEIH>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x3C439B0", Offset = "0x3C421B0", VA = "0x183C439B0")]
		public static Id32<JVDVMJBLEIH> AAXUYBXZZCU<dc>(this ReadOnlyIdArray<dc, byte> a, Id32<dc> b)
		{
			return default(Id32<JVDVMJBLEIH>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x3C44A10", Offset = "0x3C43210", VA = "0x183C44A10")]
		public static Id32<ULSOTBCMXIN> XEQSEYSIHRM<dl>([In] this IdSpan<dl, byte> bytes, Id32<dl> a)
		{
			return default(Id32<ULSOTBCMXIN>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x3C44AA0", Offset = "0x3C432A0", VA = "0x183C44AA0")]
		public static Id32<ULSOTBCMXIN> XEQSEYSIHRM<dm>(this ReadOnlyIdArray<dm, byte> a, Id32<dm> b)
		{
			return default(Id32<ULSOTBCMXIN>);
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x3C441B0", Offset = "0x3C429B0", VA = "0x183C441B0")]
		public static Id32<PBOKRPYDFLU> KDZBJCTPVAJ<dw>(this ReadOnlyIdArray<dw, byte> a, Id32<dw> b)
		{
			return default(Id32<PBOKRPYDFLU>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public static class XDUQDUUSISS
	{
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x28D87E0", Offset = "0x28D6FE0", VA = "0x1828D87E0")]
		public static void NSTKUSZPRCT(this UnsafeList<byte> a, int b, Union32 c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x28D8770", Offset = "0x28D6F70", VA = "0x1828D8770")]
		public static void NSTKUSZPRCT(this byte[] a, int b, Union32 c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x28D86F0", Offset = "0x28D6EF0", VA = "0x1828D86F0")]
		public static void NSTKUSZPRCT([In] this Span<byte> bytes, int a, Union32 b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x3C11B70", Offset = "0x3C10370", VA = "0x183C11B70")]
		public static void NSTKUSZPRCT<e>(this IdArray<e, byte> a, Id32<e> b, Union32 c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x3C11A20", Offset = "0x3C10220", VA = "0x183C11A20")]
		public static void NSTKUSZPRCT<f>([In] this IdSpan<f, byte> bytes, Id32<f> a, Union32 b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x28D2230", Offset = "0x28D0A30", VA = "0x1828D2230")]
		public static void KWUDUQPTYVW(this UnsafeList<byte> a, int b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x28D8670", Offset = "0x28D6E70", VA = "0x1828D8670")]
		public static void KWUDUQPTYVW(this byte[] a, int b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x28D85F0", Offset = "0x28D6DF0", VA = "0x1828D85F0")]
		public static void KWUDUQPTYVW([In] this Span<byte> bytes, int a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x3C11760", Offset = "0x3C0FF60", VA = "0x183C11760")]
		public static void KWUDUQPTYVW<h>(this IdArray<h, byte> a, Id32<h> b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x3C117C0", Offset = "0x3C0FFC0", VA = "0x183C117C0")]
		public static void KWUDUQPTYVW<i>([In] this IdSpan<i, byte> bytes, Id32<i> a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x28D85B0", Offset = "0x28D6DB0", VA = "0x1828D85B0")]
		public static void JAHMFEUYBNT(this UnsafeList<byte> a, int b, float c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x3C115A0", Offset = "0x3C0FDA0", VA = "0x183C115A0")]
		public static void JAHMFEUYBNT<k>(this IdArray<k, byte> a, Id32<k> b, float c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x3C11610", Offset = "0x3C0FE10", VA = "0x183C11610")]
		public static void JAHMFEUYBNT<l>([In] this IdSpan<l, byte> bytes, Id32<l> a, float b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x28D88A0", Offset = "0x28D70A0", VA = "0x1828D88A0")]
		public static void PTCRGXBIBAX(this UnsafeList<byte> a, int b, byte c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x3C11D70", Offset = "0x3C10570", VA = "0x183C11D70")]
		public static void PTCRGXBIBAX<n>(this IdArray<n, byte> a, Id32<n> b, byte c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x3C11DC0", Offset = "0x3C105C0", VA = "0x183C11DC0")]
		public static void PTCRGXBIBAX<o>([In] this IdSpan<o, byte> bytes, Id32<o> a, byte b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x3C113C0", Offset = "0x3C0FBC0", VA = "0x183C113C0")]
		public static void FGPJIEHTUPH<q>(this IdArray<q, byte> a, Id32<q> b, Id32<BMUDIFIQDFI<JRUSPVYOFZC>> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x3C11440", Offset = "0x3C0FC40", VA = "0x183C11440")]
		public static void FGPJIEHTUPH<r>([In] this IdSpan<r, byte> bytes, Id32<r> a, Id32<BMUDIFIQDFI<JRUSPVYOFZC>> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x3C113C0", Offset = "0x3C0FBC0", VA = "0x183C113C0")]
		public static void XILHDFEOXRN<t>(this IdArray<t, byte> a, Id32<t> b, Id32<JVDVMJBLEIH> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x3C11440", Offset = "0x3C0FC40", VA = "0x183C11440")]
		public static void XILHDFEOXRN<u>([In] this IdSpan<u, byte> bytes, Id32<u> a, Id32<JVDVMJBLEIH> b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public static class RDTKMFVEYUL
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x28D2FD0", Offset = "0x28D17D0", VA = "0x1828D2FD0")]
		public static (Id32<BMUDIFIQDFI<GMQAJYKQXXD>>, Id32<BMUDIFIQDFI<EAYDFNCAMWR>>, Id32<BMUDIFIQDFI<EAYDFNCAMWR>>, Id32<BMUDIFIQDFI<GZQXHQYHYRK<EAYDFNCAMWR>>>) BNGEDJQZFID(this UnsafeList<byte> a, float b, float c, [Optional] Id32<GZQXHQYHYRK<EAYDFNCAMWR>>? d)
		{
			return default((Id32<BMUDIFIQDFI<GMQAJYKQXXD>>, Id32<BMUDIFIQDFI<EAYDFNCAMWR>>, Id32<BMUDIFIQDFI<EAYDFNCAMWR>>, Id32<BMUDIFIQDFI<GZQXHQYHYRK<EAYDFNCAMWR>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x28D4720", Offset = "0x28D2F20", VA = "0x1828D4720")]
		public static (Id32<BMUDIFIQDFI<GMQAJYKQXXD>>, Id32<BMUDIFIQDFI<EAYDFNCAMWR>>, Id32<BMUDIFIQDFI<GZQXHQYHYRK<EAYDFNCAMWR>>>, Id32<BMUDIFIQDFI<GZQXHQYHYRK<EAYDFNCAMWR>>>) HWZXYIVXOWU(this UnsafeList<byte> a, float b, [Optional] Id32<GZQXHQYHYRK<EAYDFNCAMWR>>? c, [Optional] Id32<GZQXHQYHYRK<EAYDFNCAMWR>>? d)
		{
			return default((Id32<BMUDIFIQDFI<GMQAJYKQXXD>>, Id32<BMUDIFIQDFI<EAYDFNCAMWR>>, Id32<BMUDIFIQDFI<GZQXHQYHYRK<EAYDFNCAMWR>>>, Id32<BMUDIFIQDFI<GZQXHQYHYRK<EAYDFNCAMWR>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x28D66C0", Offset = "0x28D4EC0", VA = "0x1828D66C0")]
		public static (Id32<BMUDIFIQDFI<GMQAJYKQXXD>>, Id32<BMUDIFIQDFI<GZQXHQYHYRK<EAYDFNCAMWR>>>, Id32<BMUDIFIQDFI<GZQXHQYHYRK<EAYDFNCAMWR>>>, Id32<BMUDIFIQDFI<GZQXHQYHYRK<EAYDFNCAMWR>>>) PFKFCFHOBHD(this UnsafeList<byte> a, [Optional] Id32<GZQXHQYHYRK<EAYDFNCAMWR>>? b, [Optional] Id32<GZQXHQYHYRK<EAYDFNCAMWR>>? c, [Optional] Id32<GZQXHQYHYRK<EAYDFNCAMWR>>? d)
		{
			return default((Id32<BMUDIFIQDFI<GMQAJYKQXXD>>, Id32<BMUDIFIQDFI<GZQXHQYHYRK<EAYDFNCAMWR>>>, Id32<BMUDIFIQDFI<GZQXHQYHYRK<EAYDFNCAMWR>>>, Id32<BMUDIFIQDFI<GZQXHQYHYRK<EAYDFNCAMWR>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x28D3950", Offset = "0x28D2150", VA = "0x1828D3950")]
		public static (Id32<BMUDIFIQDFI<GMQAJYKQXXD>>, Id32<BMUDIFIQDFI<MYAKJBUXDCU>>, Id32<BMUDIFIQDFI<MYAKJBUXDCU>>, Id32<BMUDIFIQDFI<GZQXHQYHYRK<MYAKJBUXDCU>>>) FCRWRBOSRXL(this UnsafeList<byte> a, int b, int c, [Optional] Id32<GZQXHQYHYRK<MYAKJBUXDCU>>? d)
		{
			return default((Id32<BMUDIFIQDFI<GMQAJYKQXXD>>, Id32<BMUDIFIQDFI<MYAKJBUXDCU>>, Id32<BMUDIFIQDFI<MYAKJBUXDCU>>, Id32<BMUDIFIQDFI<GZQXHQYHYRK<MYAKJBUXDCU>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x28D7C80", Offset = "0x28D6480", VA = "0x1828D7C80")]
		public static (Id32<BMUDIFIQDFI<GMQAJYKQXXD>>, Id32<BMUDIFIQDFI<MYAKJBUXDCU>>, Id32<BMUDIFIQDFI<GZQXHQYHYRK<MYAKJBUXDCU>>>, Id32<BMUDIFIQDFI<GZQXHQYHYRK<MYAKJBUXDCU>>>) VZEWSYDTIBI(this UnsafeList<byte> a, int b, [Optional] Id32<GZQXHQYHYRK<MYAKJBUXDCU>>? c, [Optional] Id32<GZQXHQYHYRK<MYAKJBUXDCU>>? d)
		{
			return default((Id32<BMUDIFIQDFI<GMQAJYKQXXD>>, Id32<BMUDIFIQDFI<MYAKJBUXDCU>>, Id32<BMUDIFIQDFI<GZQXHQYHYRK<MYAKJBUXDCU>>>, Id32<BMUDIFIQDFI<GZQXHQYHYRK<MYAKJBUXDCU>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x28D8490", Offset = "0x28D6C90", VA = "0x1828D8490")]
		public static (Id32<BMUDIFIQDFI<GMQAJYKQXXD>>, Id32<BMUDIFIQDFI<GZQXHQYHYRK<MYAKJBUXDCU>>>, Id32<BMUDIFIQDFI<GZQXHQYHYRK<MYAKJBUXDCU>>>, Id32<BMUDIFIQDFI<GZQXHQYHYRK<MYAKJBUXDCU>>>) ZRNBGIITHEL(this UnsafeList<byte> a, [Optional] Id32<GZQXHQYHYRK<MYAKJBUXDCU>>? b, [Optional] Id32<GZQXHQYHYRK<MYAKJBUXDCU>>? c, [Optional] Id32<GZQXHQYHYRK<MYAKJBUXDCU>>? d)
		{
			return default((Id32<BMUDIFIQDFI<GMQAJYKQXXD>>, Id32<BMUDIFIQDFI<GZQXHQYHYRK<MYAKJBUXDCU>>>, Id32<BMUDIFIQDFI<GZQXHQYHYRK<MYAKJBUXDCU>>>, Id32<BMUDIFIQDFI<GZQXHQYHYRK<MYAKJBUXDCU>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x28D7DD0", Offset = "0x28D65D0", VA = "0x1828D7DD0")]
		public static (Id32<BMUDIFIQDFI<GMQAJYKQXXD>>, Id32<BMUDIFIQDFI<MYAKJBUXDCU>>, Id32<BMUDIFIQDFI<MYAKJBUXDCU>>, Id32<BMUDIFIQDFI<GZQXHQYHYRK<MYAKJBUXDCU>>>) WCXNSMTFOML(this UnsafeList<byte> a, int b, int c, [Optional] Id32<GZQXHQYHYRK<MYAKJBUXDCU>>? d)
		{
			return default((Id32<BMUDIFIQDFI<GMQAJYKQXXD>>, Id32<BMUDIFIQDFI<MYAKJBUXDCU>>, Id32<BMUDIFIQDFI<MYAKJBUXDCU>>, Id32<BMUDIFIQDFI<GZQXHQYHYRK<MYAKJBUXDCU>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x28D2D60", Offset = "0x28D1560", VA = "0x1828D2D60")]
		public static (Id32<BMUDIFIQDFI<GMQAJYKQXXD>>, Id32<BMUDIFIQDFI<MYAKJBUXDCU>>, Id32<BMUDIFIQDFI<GZQXHQYHYRK<MYAKJBUXDCU>>>, Id32<BMUDIFIQDFI<GZQXHQYHYRK<MYAKJBUXDCU>>>) ANXPMHSEZAA(this UnsafeList<byte> a, int b, [Optional] Id32<GZQXHQYHYRK<MYAKJBUXDCU>>? c, [Optional] Id32<GZQXHQYHYRK<MYAKJBUXDCU>>? d)
		{
			return default((Id32<BMUDIFIQDFI<GMQAJYKQXXD>>, Id32<BMUDIFIQDFI<MYAKJBUXDCU>>, Id32<BMUDIFIQDFI<GZQXHQYHYRK<MYAKJBUXDCU>>>, Id32<BMUDIFIQDFI<GZQXHQYHYRK<MYAKJBUXDCU>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x28D78E0", Offset = "0x28D60E0", VA = "0x1828D78E0")]
		public static (Id32<BMUDIFIQDFI<GMQAJYKQXXD>>, Id32<BMUDIFIQDFI<GZQXHQYHYRK<MYAKJBUXDCU>>>, Id32<BMUDIFIQDFI<GZQXHQYHYRK<MYAKJBUXDCU>>>, Id32<BMUDIFIQDFI<GZQXHQYHYRK<MYAKJBUXDCU>>>) VMLMTWLSYRT(this UnsafeList<byte> a, [Optional] Id32<GZQXHQYHYRK<MYAKJBUXDCU>>? b, [Optional] Id32<GZQXHQYHYRK<MYAKJBUXDCU>>? c, [Optional] Id32<GZQXHQYHYRK<MYAKJBUXDCU>>? d)
		{
			return default((Id32<BMUDIFIQDFI<GMQAJYKQXXD>>, Id32<BMUDIFIQDFI<GZQXHQYHYRK<MYAKJBUXDCU>>>, Id32<BMUDIFIQDFI<GZQXHQYHYRK<MYAKJBUXDCU>>>, Id32<BMUDIFIQDFI<GZQXHQYHYRK<MYAKJBUXDCU>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x28D72D0", Offset = "0x28D5AD0", VA = "0x1828D72D0")]
		public static (Id32<BMUDIFIQDFI<GMQAJYKQXXD>>, Id32<BMUDIFIQDFI<MYAKJBUXDCU>>, Id32<BMUDIFIQDFI<BMUDIFIQDFI<GMQAJYKQXXD>>>) UXRRIUVMWKL(this UnsafeList<byte> a, [Optional] int? b, [Optional] Id32<BMUDIFIQDFI<GMQAJYKQXXD>>? c)
		{
			return default((Id32<BMUDIFIQDFI<GMQAJYKQXXD>>, Id32<BMUDIFIQDFI<MYAKJBUXDCU>>, Id32<BMUDIFIQDFI<BMUDIFIQDFI<GMQAJYKQXXD>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x28D4600", Offset = "0x28D2E00", VA = "0x1828D4600")]
		public static (Id32<BMUDIFIQDFI<GMQAJYKQXXD>>, Id32<BMUDIFIQDFI<GZQXHQYHYRK<MYAKJBUXDCU>>>, Id32<BMUDIFIQDFI<BMUDIFIQDFI<GMQAJYKQXXD>>>) HNXRLRZPOWA(this UnsafeList<byte> a, [Optional] Id32<GZQXHQYHYRK<MYAKJBUXDCU>>? b, [Optional] Id32<BMUDIFIQDFI<GMQAJYKQXXD>>? c)
		{
			return default((Id32<BMUDIFIQDFI<GMQAJYKQXXD>>, Id32<BMUDIFIQDFI<GZQXHQYHYRK<MYAKJBUXDCU>>>, Id32<BMUDIFIQDFI<BMUDIFIQDFI<GMQAJYKQXXD>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x28D36F0", Offset = "0x28D1EF0", VA = "0x1828D36F0")]
		public static (Id32<BMUDIFIQDFI<GMQAJYKQXXD>>, Id32<BMUDIFIQDFI<MYAKJBUXDCU>>, Id32<BMUDIFIQDFI<BMUDIFIQDFI<GMQAJYKQXXD>>>) DNMKYEGGFKU(this UnsafeList<byte> a, [Optional] int? b, [Optional] Id32<BMUDIFIQDFI<GMQAJYKQXXD>>? c)
		{
			return default((Id32<BMUDIFIQDFI<GMQAJYKQXXD>>, Id32<BMUDIFIQDFI<MYAKJBUXDCU>>, Id32<BMUDIFIQDFI<BMUDIFIQDFI<GMQAJYKQXXD>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x28D7060", Offset = "0x28D5860", VA = "0x1828D7060")]
		public static (Id32<BMUDIFIQDFI<GMQAJYKQXXD>>, Id32<BMUDIFIQDFI<GZQXHQYHYRK<MYAKJBUXDCU>>>, Id32<BMUDIFIQDFI<BMUDIFIQDFI<GMQAJYKQXXD>>>) TVQADNFSVAD(this UnsafeList<byte> a, [Optional] Id32<GZQXHQYHYRK<MYAKJBUXDCU>>? b, [Optional] Id32<BMUDIFIQDFI<GMQAJYKQXXD>>? c)
		{
			return default((Id32<BMUDIFIQDFI<GMQAJYKQXXD>>, Id32<BMUDIFIQDFI<GZQXHQYHYRK<MYAKJBUXDCU>>>, Id32<BMUDIFIQDFI<BMUDIFIQDFI<GMQAJYKQXXD>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x28D3430", Offset = "0x28D1C30", VA = "0x1828D3430")]
		public static (Id32<BMUDIFIQDFI<GMQAJYKQXXD>>, Id32<BMUDIFIQDFI<MYAKJBUXDCU>>, Id32<BMUDIFIQDFI<ULSOTBCMXIN>>) CFFWOMFPHOQ(this UnsafeList<byte> a, [Optional] int? b, [Optional] Id32<ULSOTBCMXIN>? c)
		{
			return default((Id32<BMUDIFIQDFI<GMQAJYKQXXD>>, Id32<BMUDIFIQDFI<MYAKJBUXDCU>>, Id32<BMUDIFIQDFI<ULSOTBCMXIN>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x28D35E0", Offset = "0x28D1DE0", VA = "0x1828D35E0")]
		public static (Id32<BMUDIFIQDFI<GMQAJYKQXXD>>, Id32<BMUDIFIQDFI<MYAKJBUXDCU>>, Id32<BMUDIFIQDFI<GZQXHQYHYRK<ULSOTBCMXIN>>>) CKSASMWWCIZ(this UnsafeList<byte> a, [Optional] int? b, [Optional] Id32<GZQXHQYHYRK<ULSOTBCMXIN>>? c)
		{
			return default((Id32<BMUDIFIQDFI<GMQAJYKQXXD>>, Id32<BMUDIFIQDFI<MYAKJBUXDCU>>, Id32<BMUDIFIQDFI<GZQXHQYHYRK<ULSOTBCMXIN>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x28D42D0", Offset = "0x28D2AD0", VA = "0x1828D42D0")]
		public static (Id32<BMUDIFIQDFI<GMQAJYKQXXD>>, Id32<BMUDIFIQDFI<MYAKJBUXDCU>>, Id32<BMUDIFIQDFI<JVDVMJBLEIH>>) HDPUHHPOMDE(this UnsafeList<byte> a, [Optional] int? b, [Optional] Id32<JVDVMJBLEIH>? c)
		{
			return default((Id32<BMUDIFIQDFI<GMQAJYKQXXD>>, Id32<BMUDIFIQDFI<MYAKJBUXDCU>>, Id32<BMUDIFIQDFI<JVDVMJBLEIH>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x28D41C0", Offset = "0x28D29C0", VA = "0x1828D41C0")]
		public static (Id32<BMUDIFIQDFI<GMQAJYKQXXD>>, Id32<BMUDIFIQDFI<MYAKJBUXDCU>>, Id32<BMUDIFIQDFI<GZQXHQYHYRK<JVDVMJBLEIH>>>) HBUKFYSMFFB(this UnsafeList<byte> a, [Optional] int? b, [Optional] Id32<GZQXHQYHYRK<JVDVMJBLEIH>>? c)
		{
			return default((Id32<BMUDIFIQDFI<GMQAJYKQXXD>>, Id32<BMUDIFIQDFI<MYAKJBUXDCU>>, Id32<BMUDIFIQDFI<GZQXHQYHYRK<JVDVMJBLEIH>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x397CCD0", Offset = "0x397B4D0", VA = "0x18397CCD0")]
		public static (Id32<BMUDIFIQDFI<GMQAJYKQXXD>>, Id32<BMUDIFIQDFI<PBOKRPYDFLU>>, Id32<BMUDIFIQDFI<MYAKJBUXDCU>>, Id32<BMUDIFIQDFI<a>>) LGSKQSMPMRD<a>(this UnsafeList<byte> a, [Optional] Id32<PBOKRPYDFLU>? b, [Optional][In] ReadOnlySpan<byte> data)
		{
			return default((Id32<BMUDIFIQDFI<GMQAJYKQXXD>>, Id32<BMUDIFIQDFI<PBOKRPYDFLU>>, Id32<BMUDIFIQDFI<MYAKJBUXDCU>>, Id32<BMUDIFIQDFI<a>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x28D3E60", Offset = "0x28D2660", VA = "0x1828D3E60")]
		public static (Id32<BMUDIFIQDFI<GMQAJYKQXXD>>, Id32<BMUDIFIQDFI<MYAKJBUXDCU>>, Id32<BMUDIFIQDFI<GZQXHQYHYRK<MYAKJBUXDCU>>>) FZAHNTPMCIN(this UnsafeList<byte> a, int b, [Optional] Id32<GZQXHQYHYRK<MYAKJBUXDCU>>? c)
		{
			return default((Id32<BMUDIFIQDFI<GMQAJYKQXXD>>, Id32<BMUDIFIQDFI<MYAKJBUXDCU>>, Id32<BMUDIFIQDFI<GZQXHQYHYRK<MYAKJBUXDCU>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x28D6F50", Offset = "0x28D5750", VA = "0x1828D6F50")]
		public static (Id32<BMUDIFIQDFI<GMQAJYKQXXD>>, Id32<BMUDIFIQDFI<GZQXHQYHYRK<MYAKJBUXDCU>>>, Id32<BMUDIFIQDFI<GZQXHQYHYRK<MYAKJBUXDCU>>>) TARSJRAOYHE(this UnsafeList<byte> a, [Optional] Id32<GZQXHQYHYRK<MYAKJBUXDCU>>? b, [Optional] Id32<GZQXHQYHYRK<MYAKJBUXDCU>>? c)
		{
			return default((Id32<BMUDIFIQDFI<GMQAJYKQXXD>>, Id32<BMUDIFIQDFI<GZQXHQYHYRK<MYAKJBUXDCU>>>, Id32<BMUDIFIQDFI<GZQXHQYHYRK<MYAKJBUXDCU>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x397D340", Offset = "0x397BB40", VA = "0x18397D340")]
		public static (Id32<BMUDIFIQDFI<GMQAJYKQXXD>>, Id32<BMUDIFIQDFI<GZQXHQYHYRK<b>>>, Id32<BMUDIFIQDFI<MYAKJBUXDCU>>, Id32<BMUDIFIQDFI<b>>) QPQWAOBDHVN<b>(this UnsafeList<byte> a, [Optional] Id32<GZQXHQYHYRK<b>>? b, [Optional] int? c, [Optional][In] ReadOnlySpan<byte> from)
		{
			return default((Id32<BMUDIFIQDFI<GMQAJYKQXXD>>, Id32<BMUDIFIQDFI<GZQXHQYHYRK<b>>>, Id32<BMUDIFIQDFI<MYAKJBUXDCU>>, Id32<BMUDIFIQDFI<b>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x397D010", Offset = "0x397B810", VA = "0x18397D010")]
		public static (Id32<BMUDIFIQDFI<GMQAJYKQXXD>>, Id32<BMUDIFIQDFI<GZQXHQYHYRK<c>>>, Id32<BMUDIFIQDFI<GZQXHQYHYRK<c>>>, Id32<BMUDIFIQDFI<MYAKJBUXDCU>>) PAICOPOIMOU<c>(this UnsafeList<byte> a, [Optional] Id32<GZQXHQYHYRK<c>>? b, [Optional] Id32<GZQXHQYHYRK<c>>? c, [Optional] int? d)
		{
			return default((Id32<BMUDIFIQDFI<GMQAJYKQXXD>>, Id32<BMUDIFIQDFI<GZQXHQYHYRK<c>>>, Id32<BMUDIFIQDFI<GZQXHQYHYRK<c>>>, Id32<BMUDIFIQDFI<MYAKJBUXDCU>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x28D4EF0", Offset = "0x28D36F0", VA = "0x1828D4EF0")]
		public static (Id32<BMUDIFIQDFI<GMQAJYKQXXD>>, Id32<BMUDIFIQDFI<EAYDFNCAMWR>>, Id32<BMUDIFIQDFI<EAYDFNCAMWR>>, Id32<BMUDIFIQDFI<GZQXHQYHYRK<EAYDFNCAMWR>>>) JHTLQWOTFSL(this UnsafeList<byte> a, float b, float c, [Optional] Id32<GZQXHQYHYRK<EAYDFNCAMWR>>? d)
		{
			return default((Id32<BMUDIFIQDFI<GMQAJYKQXXD>>, Id32<BMUDIFIQDFI<EAYDFNCAMWR>>, Id32<BMUDIFIQDFI<EAYDFNCAMWR>>, Id32<BMUDIFIQDFI<GZQXHQYHYRK<EAYDFNCAMWR>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x28D4AD0", Offset = "0x28D32D0", VA = "0x1828D4AD0")]
		public static (Id32<BMUDIFIQDFI<GMQAJYKQXXD>>, Id32<BMUDIFIQDFI<EAYDFNCAMWR>>, Id32<BMUDIFIQDFI<GZQXHQYHYRK<EAYDFNCAMWR>>>, Id32<BMUDIFIQDFI<GZQXHQYHYRK<EAYDFNCAMWR>>>) IQRWSCIYMHG(this UnsafeList<byte> a, float b, [Optional] Id32<GZQXHQYHYRK<EAYDFNCAMWR>>? c, [Optional] Id32<GZQXHQYHYRK<EAYDFNCAMWR>>? d)
		{
			return default((Id32<BMUDIFIQDFI<GMQAJYKQXXD>>, Id32<BMUDIFIQDFI<EAYDFNCAMWR>>, Id32<BMUDIFIQDFI<GZQXHQYHYRK<EAYDFNCAMWR>>>, Id32<BMUDIFIQDFI<GZQXHQYHYRK<EAYDFNCAMWR>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x28D6260", Offset = "0x28D4A60", VA = "0x1828D6260")]
		public static (Id32<BMUDIFIQDFI<GMQAJYKQXXD>>, Id32<BMUDIFIQDFI<GZQXHQYHYRK<EAYDFNCAMWR>>>, Id32<BMUDIFIQDFI<GZQXHQYHYRK<EAYDFNCAMWR>>>, Id32<BMUDIFIQDFI<GZQXHQYHYRK<EAYDFNCAMWR>>>) ONDVQLZKERP(this UnsafeList<byte> a, [Optional] Id32<GZQXHQYHYRK<EAYDFNCAMWR>>? b, [Optional] Id32<GZQXHQYHYRK<EAYDFNCAMWR>>? c, [Optional] Id32<GZQXHQYHYRK<EAYDFNCAMWR>>? d)
		{
			return default((Id32<BMUDIFIQDFI<GMQAJYKQXXD>>, Id32<BMUDIFIQDFI<GZQXHQYHYRK<EAYDFNCAMWR>>>, Id32<BMUDIFIQDFI<GZQXHQYHYRK<EAYDFNCAMWR>>>, Id32<BMUDIFIQDFI<GZQXHQYHYRK<EAYDFNCAMWR>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x28D6380", Offset = "0x28D4B80", VA = "0x1828D6380")]
		public static (Id32<BMUDIFIQDFI<GMQAJYKQXXD>>, Id32<BMUDIFIQDFI<MYAKJBUXDCU>>, Id32<BMUDIFIQDFI<MYAKJBUXDCU>>, Id32<BMUDIFIQDFI<GZQXHQYHYRK<MYAKJBUXDCU>>>) OOIKEPMFXQN(this UnsafeList<byte> a, int b, int c, [Optional] Id32<GZQXHQYHYRK<MYAKJBUXDCU>>? d)
		{
			return default((Id32<BMUDIFIQDFI<GMQAJYKQXXD>>, Id32<BMUDIFIQDFI<MYAKJBUXDCU>>, Id32<BMUDIFIQDFI<MYAKJBUXDCU>>, Id32<BMUDIFIQDFI<GZQXHQYHYRK<MYAKJBUXDCU>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x28D3800", Offset = "0x28D2000", VA = "0x1828D3800")]
		public static (Id32<BMUDIFIQDFI<GMQAJYKQXXD>>, Id32<BMUDIFIQDFI<MYAKJBUXDCU>>, Id32<BMUDIFIQDFI<GZQXHQYHYRK<MYAKJBUXDCU>>>, Id32<BMUDIFIQDFI<GZQXHQYHYRK<MYAKJBUXDCU>>>) EXXYGJPCRPM(this UnsafeList<byte> a, int b, [Optional] Id32<GZQXHQYHYRK<MYAKJBUXDCU>>? c, [Optional] Id32<GZQXHQYHYRK<MYAKJBUXDCU>>? d)
		{
			return default((Id32<BMUDIFIQDFI<GMQAJYKQXXD>>, Id32<BMUDIFIQDFI<MYAKJBUXDCU>>, Id32<BMUDIFIQDFI<GZQXHQYHYRK<MYAKJBUXDCU>>>, Id32<BMUDIFIQDFI<GZQXHQYHYRK<MYAKJBUXDCU>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x28D5560", Offset = "0x28D3D60", VA = "0x1828D5560")]
		public static (Id32<BMUDIFIQDFI<GMQAJYKQXXD>>, Id32<BMUDIFIQDFI<GZQXHQYHYRK<MYAKJBUXDCU>>>, Id32<BMUDIFIQDFI<GZQXHQYHYRK<MYAKJBUXDCU>>>, Id32<BMUDIFIQDFI<GZQXHQYHYRK<MYAKJBUXDCU>>>) KZXCYPCZNXB(this UnsafeList<byte> a, [Optional] Id32<GZQXHQYHYRK<MYAKJBUXDCU>>? b, [Optional] Id32<GZQXHQYHYRK<MYAKJBUXDCU>>? c, [Optional] Id32<GZQXHQYHYRK<MYAKJBUXDCU>>? d)
		{
			return default((Id32<BMUDIFIQDFI<GMQAJYKQXXD>>, Id32<BMUDIFIQDFI<GZQXHQYHYRK<MYAKJBUXDCU>>>, Id32<BMUDIFIQDFI<GZQXHQYHYRK<MYAKJBUXDCU>>>, Id32<BMUDIFIQDFI<GZQXHQYHYRK<MYAKJBUXDCU>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x28D64E0", Offset = "0x28D4CE0", VA = "0x1828D64E0")]
		public static (Id32<BMUDIFIQDFI<GMQAJYKQXXD>>, Id32<BMUDIFIQDFI<MYAKJBUXDCU>>, Id32<BMUDIFIQDFI<MYAKJBUXDCU>>, Id32<BMUDIFIQDFI<GZQXHQYHYRK<MYAKJBUXDCU>>>) OPGNWPHKEYW(this UnsafeList<byte> a, int b, int c, [Optional] Id32<GZQXHQYHYRK<MYAKJBUXDCU>>? d)
		{
			return default((Id32<BMUDIFIQDFI<GMQAJYKQXXD>>, Id32<BMUDIFIQDFI<MYAKJBUXDCU>>, Id32<BMUDIFIQDFI<MYAKJBUXDCU>>, Id32<BMUDIFIQDFI<GZQXHQYHYRK<MYAKJBUXDCU>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x28D5070", Offset = "0x28D3870", VA = "0x1828D5070")]
		public static (Id32<BMUDIFIQDFI<GMQAJYKQXXD>>, Id32<BMUDIFIQDFI<MYAKJBUXDCU>>, Id32<BMUDIFIQDFI<GZQXHQYHYRK<MYAKJBUXDCU>>>, Id32<BMUDIFIQDFI<GZQXHQYHYRK<MYAKJBUXDCU>>>) JQKZZGRLLZT(this UnsafeList<byte> a, int b, [Optional] Id32<GZQXHQYHYRK<MYAKJBUXDCU>>? c, [Optional] Id32<GZQXHQYHYRK<MYAKJBUXDCU>>? d)
		{
			return default((Id32<BMUDIFIQDFI<GMQAJYKQXXD>>, Id32<BMUDIFIQDFI<MYAKJBUXDCU>>, Id32<BMUDIFIQDFI<GZQXHQYHYRK<MYAKJBUXDCU>>>, Id32<BMUDIFIQDFI<GZQXHQYHYRK<MYAKJBUXDCU>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x28D6A60", Offset = "0x28D5260", VA = "0x1828D6A60")]
		public static (Id32<BMUDIFIQDFI<GMQAJYKQXXD>>, Id32<BMUDIFIQDFI<GZQXHQYHYRK<MYAKJBUXDCU>>>, Id32<BMUDIFIQDFI<GZQXHQYHYRK<MYAKJBUXDCU>>>, Id32<BMUDIFIQDFI<GZQXHQYHYRK<MYAKJBUXDCU>>>) QTAISPMQJEM(this UnsafeList<byte> a, [Optional] Id32<GZQXHQYHYRK<MYAKJBUXDCU>>? b, [Optional] Id32<GZQXHQYHYRK<MYAKJBUXDCU>>? c, [Optional] Id32<GZQXHQYHYRK<MYAKJBUXDCU>>? d)
		{
			return default((Id32<BMUDIFIQDFI<GMQAJYKQXXD>>, Id32<BMUDIFIQDFI<GZQXHQYHYRK<MYAKJBUXDCU>>>, Id32<BMUDIFIQDFI<GZQXHQYHYRK<MYAKJBUXDCU>>>, Id32<BMUDIFIQDFI<GZQXHQYHYRK<MYAKJBUXDCU>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x28D5D70", Offset = "0x28D4570", VA = "0x1828D5D70")]
		public static (Id32<BMUDIFIQDFI<GMQAJYKQXXD>>, Id32<BMUDIFIQDFI<BMUDIFIQDFI<GMQAJYKQXXD>>>) MUEASPKCEHX(this UnsafeList<byte> a, [Optional] Id32<BMUDIFIQDFI<GMQAJYKQXXD>>? b)
		{
			return default((Id32<BMUDIFIQDFI<GMQAJYKQXXD>>, Id32<BMUDIFIQDFI<BMUDIFIQDFI<GMQAJYKQXXD>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x28D4D70", Offset = "0x28D3570", VA = "0x1828D4D70")]
		public static (Id32<BMUDIFIQDFI<GMQAJYKQXXD>>, Id32<BMUDIFIQDFI<EAYDFNCAMWR>>, Id32<BMUDIFIQDFI<EAYDFNCAMWR>>, Id32<BMUDIFIQDFI<GZQXHQYHYRK<MYAKJBUXDCU>>>) IVCTLLRFZTX(this UnsafeList<byte> a, float b, float c, [Optional] Id32<GZQXHQYHYRK<MYAKJBUXDCU>>? d)
		{
			return default((Id32<BMUDIFIQDFI<GMQAJYKQXXD>>, Id32<BMUDIFIQDFI<EAYDFNCAMWR>>, Id32<BMUDIFIQDFI<EAYDFNCAMWR>>, Id32<BMUDIFIQDFI<GZQXHQYHYRK<MYAKJBUXDCU>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x28D67E0", Offset = "0x28D4FE0", VA = "0x1828D67E0")]
		public static (Id32<BMUDIFIQDFI<GMQAJYKQXXD>>, Id32<BMUDIFIQDFI<EAYDFNCAMWR>>, Id32<BMUDIFIQDFI<GZQXHQYHYRK<EAYDFNCAMWR>>>, Id32<BMUDIFIQDFI<GZQXHQYHYRK<MYAKJBUXDCU>>>) QBJORNEQEVU(this UnsafeList<byte> a, float b, [Optional] Id32<GZQXHQYHYRK<EAYDFNCAMWR>>? c, [Optional] Id32<GZQXHQYHYRK<MYAKJBUXDCU>>? d)
		{
			return default((Id32<BMUDIFIQDFI<GMQAJYKQXXD>>, Id32<BMUDIFIQDFI<EAYDFNCAMWR>>, Id32<BMUDIFIQDFI<GZQXHQYHYRK<EAYDFNCAMWR>>>, Id32<BMUDIFIQDFI<GZQXHQYHYRK<MYAKJBUXDCU>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x28D5430", Offset = "0x28D3C30", VA = "0x1828D5430")]
		public static (Id32<BMUDIFIQDFI<GMQAJYKQXXD>>, Id32<BMUDIFIQDFI<GZQXHQYHYRK<EAYDFNCAMWR>>>, Id32<BMUDIFIQDFI<GZQXHQYHYRK<EAYDFNCAMWR>>>, Id32<BMUDIFIQDFI<GZQXHQYHYRK<MYAKJBUXDCU>>>) KWWAHXXDRFF(this UnsafeList<byte> a, [Optional] Id32<GZQXHQYHYRK<EAYDFNCAMWR>>? b, [Optional] Id32<GZQXHQYHYRK<EAYDFNCAMWR>>? c, [Optional] Id32<GZQXHQYHYRK<MYAKJBUXDCU>>? d)
		{
			return default((Id32<BMUDIFIQDFI<GMQAJYKQXXD>>, Id32<BMUDIFIQDFI<GZQXHQYHYRK<EAYDFNCAMWR>>>, Id32<BMUDIFIQDFI<GZQXHQYHYRK<EAYDFNCAMWR>>>, Id32<BMUDIFIQDFI<GZQXHQYHYRK<MYAKJBUXDCU>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x28D6100", Offset = "0x28D4900", VA = "0x1828D6100")]
		public static (Id32<BMUDIFIQDFI<GMQAJYKQXXD>>, Id32<BMUDIFIQDFI<MYAKJBUXDCU>>, Id32<BMUDIFIQDFI<MYAKJBUXDCU>>, Id32<BMUDIFIQDFI<GZQXHQYHYRK<MYAKJBUXDCU>>>) OLUXPMSZKKA(this UnsafeList<byte> a, int b, int c, [Optional] Id32<GZQXHQYHYRK<MYAKJBUXDCU>>? d)
		{
			return default((Id32<BMUDIFIQDFI<GMQAJYKQXXD>>, Id32<BMUDIFIQDFI<MYAKJBUXDCU>>, Id32<BMUDIFIQDFI<MYAKJBUXDCU>>, Id32<BMUDIFIQDFI<GZQXHQYHYRK<MYAKJBUXDCU>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x28D6CA0", Offset = "0x28D54A0", VA = "0x1828D6CA0")]
		public static (Id32<BMUDIFIQDFI<GMQAJYKQXXD>>, Id32<BMUDIFIQDFI<MYAKJBUXDCU>>, Id32<BMUDIFIQDFI<GZQXHQYHYRK<MYAKJBUXDCU>>>, Id32<BMUDIFIQDFI<GZQXHQYHYRK<MYAKJBUXDCU>>>) RNXWCBLLFXR(this UnsafeList<byte> a, int b, [Optional] Id32<GZQXHQYHYRK<MYAKJBUXDCU>>? c, [Optional] Id32<GZQXHQYHYRK<MYAKJBUXDCU>>? d)
		{
			return default((Id32<BMUDIFIQDFI<GMQAJYKQXXD>>, Id32<BMUDIFIQDFI<MYAKJBUXDCU>>, Id32<BMUDIFIQDFI<GZQXHQYHYRK<MYAKJBUXDCU>>>, Id32<BMUDIFIQDFI<GZQXHQYHYRK<MYAKJBUXDCU>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x28D2EB0", Offset = "0x28D16B0", VA = "0x1828D2EB0")]
		public static (Id32<BMUDIFIQDFI<GMQAJYKQXXD>>, Id32<BMUDIFIQDFI<GZQXHQYHYRK<MYAKJBUXDCU>>>, Id32<BMUDIFIQDFI<GZQXHQYHYRK<MYAKJBUXDCU>>>, Id32<BMUDIFIQDFI<GZQXHQYHYRK<MYAKJBUXDCU>>>) BGGRCJJGLBA(this UnsafeList<byte> a, [Optional] Id32<GZQXHQYHYRK<MYAKJBUXDCU>>? b, [Optional] Id32<GZQXHQYHYRK<MYAKJBUXDCU>>? c, [Optional] Id32<GZQXHQYHYRK<MYAKJBUXDCU>>? d)
		{
			return default((Id32<BMUDIFIQDFI<GMQAJYKQXXD>>, Id32<BMUDIFIQDFI<GZQXHQYHYRK<MYAKJBUXDCU>>>, Id32<BMUDIFIQDFI<GZQXHQYHYRK<MYAKJBUXDCU>>>, Id32<BMUDIFIQDFI<GZQXHQYHYRK<MYAKJBUXDCU>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x28D4480", Offset = "0x28D2C80", VA = "0x1828D4480")]
		public static (Id32<BMUDIFIQDFI<GMQAJYKQXXD>>, Id32<BMUDIFIQDFI<EAYDFNCAMWR>>, Id32<BMUDIFIQDFI<EAYDFNCAMWR>>, Id32<BMUDIFIQDFI<GZQXHQYHYRK<MYAKJBUXDCU>>>) HHGYYZDOXPS(this UnsafeList<byte> a, float b, float c, [Optional] Id32<GZQXHQYHYRK<MYAKJBUXDCU>>? d)
		{
			return default((Id32<BMUDIFIQDFI<GMQAJYKQXXD>>, Id32<BMUDIFIQDFI<EAYDFNCAMWR>>, Id32<BMUDIFIQDFI<EAYDFNCAMWR>>, Id32<BMUDIFIQDFI<GZQXHQYHYRK<MYAKJBUXDCU>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x28D3150", Offset = "0x28D1950", VA = "0x1828D3150")]
		public static (Id32<BMUDIFIQDFI<GMQAJYKQXXD>>, Id32<BMUDIFIQDFI<EAYDFNCAMWR>>, Id32<BMUDIFIQDFI<GZQXHQYHYRK<EAYDFNCAMWR>>>, Id32<BMUDIFIQDFI<GZQXHQYHYRK<MYAKJBUXDCU>>>) BNUCDABDFCT(this UnsafeList<byte> a, float b, [Optional] Id32<GZQXHQYHYRK<EAYDFNCAMWR>>? c, [Optional] Id32<GZQXHQYHYRK<MYAKJBUXDCU>>? d)
		{
			return default((Id32<BMUDIFIQDFI<GMQAJYKQXXD>>, Id32<BMUDIFIQDFI<EAYDFNCAMWR>>, Id32<BMUDIFIQDFI<GZQXHQYHYRK<EAYDFNCAMWR>>>, Id32<BMUDIFIQDFI<GZQXHQYHYRK<MYAKJBUXDCU>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x28D4870", Offset = "0x28D3070", VA = "0x1828D4870")]
		public static (Id32<BMUDIFIQDFI<GMQAJYKQXXD>>, Id32<BMUDIFIQDFI<GZQXHQYHYRK<EAYDFNCAMWR>>>, Id32<BMUDIFIQDFI<GZQXHQYHYRK<EAYDFNCAMWR>>>, Id32<BMUDIFIQDFI<GZQXHQYHYRK<MYAKJBUXDCU>>>) IFGQMOQHZYK(this UnsafeList<byte> a, [Optional] Id32<GZQXHQYHYRK<EAYDFNCAMWR>>? b, [Optional] Id32<GZQXHQYHYRK<EAYDFNCAMWR>>? c, [Optional] Id32<GZQXHQYHYRK<MYAKJBUXDCU>>? d)
		{
			return default((Id32<BMUDIFIQDFI<GMQAJYKQXXD>>, Id32<BMUDIFIQDFI<GZQXHQYHYRK<EAYDFNCAMWR>>>, Id32<BMUDIFIQDFI<GZQXHQYHYRK<EAYDFNCAMWR>>>, Id32<BMUDIFIQDFI<GZQXHQYHYRK<MYAKJBUXDCU>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x28D5940", Offset = "0x28D4140", VA = "0x1828D5940")]
		public static (Id32<BMUDIFIQDFI<GMQAJYKQXXD>>, Id32<BMUDIFIQDFI<MYAKJBUXDCU>>, Id32<BMUDIFIQDFI<MYAKJBUXDCU>>, Id32<BMUDIFIQDFI<GZQXHQYHYRK<MYAKJBUXDCU>>>) LTHCLGVXMGF(this UnsafeList<byte> a, int b, int c, [Optional] Id32<GZQXHQYHYRK<MYAKJBUXDCU>>? d)
		{
			return default((Id32<BMUDIFIQDFI<GMQAJYKQXXD>>, Id32<BMUDIFIQDFI<MYAKJBUXDCU>>, Id32<BMUDIFIQDFI<MYAKJBUXDCU>>, Id32<BMUDIFIQDFI<GZQXHQYHYRK<MYAKJBUXDCU>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x28D7B30", Offset = "0x28D6330", VA = "0x1828D7B30")]
		public static (Id32<BMUDIFIQDFI<GMQAJYKQXXD>>, Id32<BMUDIFIQDFI<MYAKJBUXDCU>>, Id32<BMUDIFIQDFI<GZQXHQYHYRK<MYAKJBUXDCU>>>, Id32<BMUDIFIQDFI<GZQXHQYHYRK<MYAKJBUXDCU>>>) VXJEJFOMQLQ(this UnsafeList<byte> a, int b, [Optional] Id32<GZQXHQYHYRK<MYAKJBUXDCU>>? c, [Optional] Id32<GZQXHQYHYRK<MYAKJBUXDCU>>? d)
		{
			return default((Id32<BMUDIFIQDFI<GMQAJYKQXXD>>, Id32<BMUDIFIQDFI<MYAKJBUXDCU>>, Id32<BMUDIFIQDFI<GZQXHQYHYRK<MYAKJBUXDCU>>>, Id32<BMUDIFIQDFI<GZQXHQYHYRK<MYAKJBUXDCU>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x28D3F90", Offset = "0x28D2790", VA = "0x1828D3F90")]
		public static (Id32<BMUDIFIQDFI<GMQAJYKQXXD>>, Id32<BMUDIFIQDFI<GZQXHQYHYRK<MYAKJBUXDCU>>>, Id32<BMUDIFIQDFI<GZQXHQYHYRK<MYAKJBUXDCU>>>, Id32<BMUDIFIQDFI<GZQXHQYHYRK<MYAKJBUXDCU>>>) GJGUEJHUKBJ(this UnsafeList<byte> a, [Optional] Id32<GZQXHQYHYRK<MYAKJBUXDCU>>? b, [Optional] Id32<GZQXHQYHYRK<MYAKJBUXDCU>>? c, [Optional] Id32<GZQXHQYHYRK<MYAKJBUXDCU>>? d)
		{
			return default((Id32<BMUDIFIQDFI<GMQAJYKQXXD>>, Id32<BMUDIFIQDFI<GZQXHQYHYRK<MYAKJBUXDCU>>>, Id32<BMUDIFIQDFI<GZQXHQYHYRK<MYAKJBUXDCU>>>, Id32<BMUDIFIQDFI<GZQXHQYHYRK<MYAKJBUXDCU>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x28D5AA0", Offset = "0x28D42A0", VA = "0x1828D5AA0")]
		public static (Id32<BMUDIFIQDFI<GMQAJYKQXXD>>, Id32<BMUDIFIQDFI<EAYDFNCAMWR>>, Id32<BMUDIFIQDFI<EAYDFNCAMWR>>, Id32<BMUDIFIQDFI<GZQXHQYHYRK<MYAKJBUXDCU>>>) LWRYHFUUQRO(this UnsafeList<byte> a, float b, float c, [Optional] Id32<GZQXHQYHYRK<MYAKJBUXDCU>>? d)
		{
			return default((Id32<BMUDIFIQDFI<GMQAJYKQXXD>>, Id32<BMUDIFIQDFI<EAYDFNCAMWR>>, Id32<BMUDIFIQDFI<EAYDFNCAMWR>>, Id32<BMUDIFIQDFI<GZQXHQYHYRK<MYAKJBUXDCU>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x28D8330", Offset = "0x28D6B30", VA = "0x1828D8330")]
		public static (Id32<BMUDIFIQDFI<GMQAJYKQXXD>>, Id32<BMUDIFIQDFI<EAYDFNCAMWR>>, Id32<BMUDIFIQDFI<GZQXHQYHYRK<EAYDFNCAMWR>>>, Id32<BMUDIFIQDFI<GZQXHQYHYRK<MYAKJBUXDCU>>>) XRAMDZDAZGX(this UnsafeList<byte> a, float b, [Optional] Id32<GZQXHQYHYRK<EAYDFNCAMWR>>? c, [Optional] Id32<GZQXHQYHYRK<MYAKJBUXDCU>>? d)
		{
			return default((Id32<BMUDIFIQDFI<GMQAJYKQXXD>>, Id32<BMUDIFIQDFI<EAYDFNCAMWR>>, Id32<BMUDIFIQDFI<GZQXHQYHYRK<EAYDFNCAMWR>>>, Id32<BMUDIFIQDFI<GZQXHQYHYRK<MYAKJBUXDCU>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x28D49A0", Offset = "0x28D31A0", VA = "0x1828D49A0")]
		public static (Id32<BMUDIFIQDFI<GMQAJYKQXXD>>, Id32<BMUDIFIQDFI<GZQXHQYHYRK<EAYDFNCAMWR>>>, Id32<BMUDIFIQDFI<GZQXHQYHYRK<EAYDFNCAMWR>>>, Id32<BMUDIFIQDFI<GZQXHQYHYRK<MYAKJBUXDCU>>>) IJPYVKTGXLQ(this UnsafeList<byte> a, [Optional] Id32<GZQXHQYHYRK<EAYDFNCAMWR>>? b, [Optional] Id32<GZQXHQYHYRK<EAYDFNCAMWR>>? c, [Optional] Id32<GZQXHQYHYRK<MYAKJBUXDCU>>? d)
		{
			return default((Id32<BMUDIFIQDFI<GMQAJYKQXXD>>, Id32<BMUDIFIQDFI<GZQXHQYHYRK<EAYDFNCAMWR>>>, Id32<BMUDIFIQDFI<GZQXHQYHYRK<EAYDFNCAMWR>>>, Id32<BMUDIFIQDFI<GZQXHQYHYRK<MYAKJBUXDCU>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x28D8050", Offset = "0x28D6850", VA = "0x1828D8050")]
		public static (Id32<BMUDIFIQDFI<GMQAJYKQXXD>>, Id32<BMUDIFIQDFI<MYAKJBUXDCU>>, Id32<BMUDIFIQDFI<MYAKJBUXDCU>>, Id32<BMUDIFIQDFI<GZQXHQYHYRK<MYAKJBUXDCU>>>) WLUDMFMJSCB(this UnsafeList<byte> a, int b, int c, [Optional] Id32<GZQXHQYHYRK<MYAKJBUXDCU>>? d)
		{
			return default((Id32<BMUDIFIQDFI<GMQAJYKQXXD>>, Id32<BMUDIFIQDFI<MYAKJBUXDCU>>, Id32<BMUDIFIQDFI<MYAKJBUXDCU>>, Id32<BMUDIFIQDFI<GZQXHQYHYRK<MYAKJBUXDCU>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x28D51C0", Offset = "0x28D39C0", VA = "0x1828D51C0")]
		public static (Id32<BMUDIFIQDFI<GMQAJYKQXXD>>, Id32<BMUDIFIQDFI<MYAKJBUXDCU>>, Id32<BMUDIFIQDFI<GZQXHQYHYRK<MYAKJBUXDCU>>>, Id32<BMUDIFIQDFI<GZQXHQYHYRK<MYAKJBUXDCU>>>) JWPWYZONDYW(this UnsafeList<byte> a, int b, [Optional] Id32<GZQXHQYHYRK<MYAKJBUXDCU>>? c, [Optional] Id32<GZQXHQYHYRK<MYAKJBUXDCU>>? d)
		{
			return default((Id32<BMUDIFIQDFI<GMQAJYKQXXD>>, Id32<BMUDIFIQDFI<MYAKJBUXDCU>>, Id32<BMUDIFIQDFI<GZQXHQYHYRK<MYAKJBUXDCU>>>, Id32<BMUDIFIQDFI<GZQXHQYHYRK<MYAKJBUXDCU>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x28D6940", Offset = "0x28D5140", VA = "0x1828D6940")]
		public static (Id32<BMUDIFIQDFI<GMQAJYKQXXD>>, Id32<BMUDIFIQDFI<GZQXHQYHYRK<MYAKJBUXDCU>>>, Id32<BMUDIFIQDFI<GZQXHQYHYRK<MYAKJBUXDCU>>>, Id32<BMUDIFIQDFI<GZQXHQYHYRK<MYAKJBUXDCU>>>) QKZAYXWRRFJ(this UnsafeList<byte> a, [Optional] Id32<GZQXHQYHYRK<MYAKJBUXDCU>>? b, [Optional] Id32<GZQXHQYHYRK<MYAKJBUXDCU>>? c, [Optional] Id32<GZQXHQYHYRK<MYAKJBUXDCU>>? d)
		{
			return default((Id32<BMUDIFIQDFI<GMQAJYKQXXD>>, Id32<BMUDIFIQDFI<GZQXHQYHYRK<MYAKJBUXDCU>>>, Id32<BMUDIFIQDFI<GZQXHQYHYRK<MYAKJBUXDCU>>>, Id32<BMUDIFIQDFI<GZQXHQYHYRK<MYAKJBUXDCU>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x28D81B0", Offset = "0x28D69B0", VA = "0x1828D81B0")]
		public static (Id32<BMUDIFIQDFI<GMQAJYKQXXD>>, Id32<BMUDIFIQDFI<EAYDFNCAMWR>>, Id32<BMUDIFIQDFI<EAYDFNCAMWR>>, Id32<BMUDIFIQDFI<GZQXHQYHYRK<MYAKJBUXDCU>>>) XCOKZSOCEBV(this UnsafeList<byte> a, float b, float c, [Optional] Id32<GZQXHQYHYRK<MYAKJBUXDCU>>? d)
		{
			return default((Id32<BMUDIFIQDFI<GMQAJYKQXXD>>, Id32<BMUDIFIQDFI<EAYDFNCAMWR>>, Id32<BMUDIFIQDFI<EAYDFNCAMWR>>, Id32<BMUDIFIQDFI<GZQXHQYHYRK<MYAKJBUXDCU>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x28D57E0", Offset = "0x28D3FE0", VA = "0x1828D57E0")]
		public static (Id32<BMUDIFIQDFI<GMQAJYKQXXD>>, Id32<BMUDIFIQDFI<EAYDFNCAMWR>>, Id32<BMUDIFIQDFI<GZQXHQYHYRK<EAYDFNCAMWR>>>, Id32<BMUDIFIQDFI<GZQXHQYHYRK<MYAKJBUXDCU>>>) LLLTOVUAUGU(this UnsafeList<byte> a, float b, [Optional] Id32<GZQXHQYHYRK<EAYDFNCAMWR>>? c, [Optional] Id32<GZQXHQYHYRK<MYAKJBUXDCU>>? d)
		{
			return default((Id32<BMUDIFIQDFI<GMQAJYKQXXD>>, Id32<BMUDIFIQDFI<EAYDFNCAMWR>>, Id32<BMUDIFIQDFI<GZQXHQYHYRK<EAYDFNCAMWR>>>, Id32<BMUDIFIQDFI<GZQXHQYHYRK<MYAKJBUXDCU>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x28D7A00", Offset = "0x28D6200", VA = "0x1828D7A00")]
		public static (Id32<BMUDIFIQDFI<GMQAJYKQXXD>>, Id32<BMUDIFIQDFI<GZQXHQYHYRK<EAYDFNCAMWR>>>, Id32<BMUDIFIQDFI<GZQXHQYHYRK<EAYDFNCAMWR>>>, Id32<BMUDIFIQDFI<GZQXHQYHYRK<MYAKJBUXDCU>>>) VUGATOOLIBX(this UnsafeList<byte> a, [Optional] Id32<GZQXHQYHYRK<EAYDFNCAMWR>>? b, [Optional] Id32<GZQXHQYHYRK<EAYDFNCAMWR>>? c, [Optional] Id32<GZQXHQYHYRK<MYAKJBUXDCU>>? d)
		{
			return default((Id32<BMUDIFIQDFI<GMQAJYKQXXD>>, Id32<BMUDIFIQDFI<GZQXHQYHYRK<EAYDFNCAMWR>>>, Id32<BMUDIFIQDFI<GZQXHQYHYRK<EAYDFNCAMWR>>>, Id32<BMUDIFIQDFI<GZQXHQYHYRK<MYAKJBUXDCU>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x28D6DF0", Offset = "0x28D55F0", VA = "0x1828D6DF0")]
		public static (Id32<BMUDIFIQDFI<GMQAJYKQXXD>>, Id32<BMUDIFIQDFI<MYAKJBUXDCU>>, Id32<BMUDIFIQDFI<MYAKJBUXDCU>>, Id32<BMUDIFIQDFI<GZQXHQYHYRK<MYAKJBUXDCU>>>) SWFQUMTLMJM(this UnsafeList<byte> a, int b, int c, [Optional] Id32<GZQXHQYHYRK<MYAKJBUXDCU>>? d)
		{
			return default((Id32<BMUDIFIQDFI<GMQAJYKQXXD>>, Id32<BMUDIFIQDFI<MYAKJBUXDCU>>, Id32<BMUDIFIQDFI<MYAKJBUXDCU>>, Id32<BMUDIFIQDFI<GZQXHQYHYRK<MYAKJBUXDCU>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x28D4C20", Offset = "0x28D3420", VA = "0x1828D4C20")]
		public static (Id32<BMUDIFIQDFI<GMQAJYKQXXD>>, Id32<BMUDIFIQDFI<MYAKJBUXDCU>>, Id32<BMUDIFIQDFI<GZQXHQYHYRK<MYAKJBUXDCU>>>, Id32<BMUDIFIQDFI<GZQXHQYHYRK<MYAKJBUXDCU>>>) ISDOWOAWIEB(this UnsafeList<byte> a, int b, [Optional] Id32<GZQXHQYHYRK<MYAKJBUXDCU>>? c, [Optional] Id32<GZQXHQYHYRK<MYAKJBUXDCU>>? d)
		{
			return default((Id32<BMUDIFIQDFI<GMQAJYKQXXD>>, Id32<BMUDIFIQDFI<MYAKJBUXDCU>>, Id32<BMUDIFIQDFI<GZQXHQYHYRK<MYAKJBUXDCU>>>, Id32<BMUDIFIQDFI<GZQXHQYHYRK<MYAKJBUXDCU>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x28D7660", Offset = "0x28D5E60", VA = "0x1828D7660")]
		public static (Id32<BMUDIFIQDFI<GMQAJYKQXXD>>, Id32<BMUDIFIQDFI<GZQXHQYHYRK<MYAKJBUXDCU>>>, Id32<BMUDIFIQDFI<GZQXHQYHYRK<MYAKJBUXDCU>>>, Id32<BMUDIFIQDFI<GZQXHQYHYRK<MYAKJBUXDCU>>>) VKBTCKVJCMY(this UnsafeList<byte> a, [Optional] Id32<GZQXHQYHYRK<MYAKJBUXDCU>>? b, [Optional] Id32<GZQXHQYHYRK<MYAKJBUXDCU>>? c, [Optional] Id32<GZQXHQYHYRK<MYAKJBUXDCU>>? d)
		{
			return default((Id32<BMUDIFIQDFI<GMQAJYKQXXD>>, Id32<BMUDIFIQDFI<GZQXHQYHYRK<MYAKJBUXDCU>>>, Id32<BMUDIFIQDFI<GZQXHQYHYRK<MYAKJBUXDCU>>>, Id32<BMUDIFIQDFI<GZQXHQYHYRK<MYAKJBUXDCU>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x28D3AB0", Offset = "0x28D22B0", VA = "0x1828D3AB0")]
		public static (Id32<BMUDIFIQDFI<GMQAJYKQXXD>>, Id32<BMUDIFIQDFI<EAYDFNCAMWR>>, Id32<BMUDIFIQDFI<EAYDFNCAMWR>>, Id32<BMUDIFIQDFI<GZQXHQYHYRK<EAYDFNCAMWR>>>) FNWVVFCKENA(this UnsafeList<byte> a, float b, float c, [Optional] Id32<GZQXHQYHYRK<EAYDFNCAMWR>>? d)
		{
			return default((Id32<BMUDIFIQDFI<GMQAJYKQXXD>>, Id32<BMUDIFIQDFI<EAYDFNCAMWR>>, Id32<BMUDIFIQDFI<EAYDFNCAMWR>>, Id32<BMUDIFIQDFI<GZQXHQYHYRK<EAYDFNCAMWR>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x28D5FB0", Offset = "0x28D47B0", VA = "0x1828D5FB0")]
		public static (Id32<BMUDIFIQDFI<GMQAJYKQXXD>>, Id32<BMUDIFIQDFI<EAYDFNCAMWR>>, Id32<BMUDIFIQDFI<GZQXHQYHYRK<EAYDFNCAMWR>>>, Id32<BMUDIFIQDFI<GZQXHQYHYRK<EAYDFNCAMWR>>>) MZRLXYEQDBX(this UnsafeList<byte> a, float b, [Optional] Id32<GZQXHQYHYRK<EAYDFNCAMWR>>? c, [Optional] Id32<GZQXHQYHYRK<EAYDFNCAMWR>>? d)
		{
			return default((Id32<BMUDIFIQDFI<GMQAJYKQXXD>>, Id32<BMUDIFIQDFI<EAYDFNCAMWR>>, Id32<BMUDIFIQDFI<GZQXHQYHYRK<EAYDFNCAMWR>>>, Id32<BMUDIFIQDFI<GZQXHQYHYRK<EAYDFNCAMWR>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x28D3C30", Offset = "0x28D2430", VA = "0x1828D3C30")]
		public static (Id32<BMUDIFIQDFI<GMQAJYKQXXD>>, Id32<BMUDIFIQDFI<GZQXHQYHYRK<EAYDFNCAMWR>>>, Id32<BMUDIFIQDFI<GZQXHQYHYRK<EAYDFNCAMWR>>>, Id32<BMUDIFIQDFI<GZQXHQYHYRK<EAYDFNCAMWR>>>) FRHEUBSZQRO(this UnsafeList<byte> a, [Optional] Id32<GZQXHQYHYRK<EAYDFNCAMWR>>? b, [Optional] Id32<GZQXHQYHYRK<EAYDFNCAMWR>>? c, [Optional] Id32<GZQXHQYHYRK<EAYDFNCAMWR>>? d)
		{
			return default((Id32<BMUDIFIQDFI<GMQAJYKQXXD>>, Id32<BMUDIFIQDFI<GZQXHQYHYRK<EAYDFNCAMWR>>>, Id32<BMUDIFIQDFI<GZQXHQYHYRK<EAYDFNCAMWR>>>, Id32<BMUDIFIQDFI<GZQXHQYHYRK<EAYDFNCAMWR>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x28D5680", Offset = "0x28D3E80", VA = "0x1828D5680")]
		public static (Id32<BMUDIFIQDFI<GMQAJYKQXXD>>, Id32<BMUDIFIQDFI<MYAKJBUXDCU>>, Id32<BMUDIFIQDFI<MYAKJBUXDCU>>, Id32<BMUDIFIQDFI<GZQXHQYHYRK<MYAKJBUXDCU>>>) LDFXAGTNFOY(this UnsafeList<byte> a, int b, int c, [Optional] Id32<GZQXHQYHYRK<MYAKJBUXDCU>>? d)
		{
			return default((Id32<BMUDIFIQDFI<GMQAJYKQXXD>>, Id32<BMUDIFIQDFI<MYAKJBUXDCU>>, Id32<BMUDIFIQDFI<MYAKJBUXDCU>>, Id32<BMUDIFIQDFI<GZQXHQYHYRK<MYAKJBUXDCU>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x28D5C20", Offset = "0x28D4420", VA = "0x1828D5C20")]
		public static (Id32<BMUDIFIQDFI<GMQAJYKQXXD>>, Id32<BMUDIFIQDFI<MYAKJBUXDCU>>, Id32<BMUDIFIQDFI<GZQXHQYHYRK<MYAKJBUXDCU>>>, Id32<BMUDIFIQDFI<GZQXHQYHYRK<MYAKJBUXDCU>>>) MESOTSBXWSL(this UnsafeList<byte> a, int b, [Optional] Id32<GZQXHQYHYRK<MYAKJBUXDCU>>? c, [Optional] Id32<GZQXHQYHYRK<MYAKJBUXDCU>>? d)
		{
			return default((Id32<BMUDIFIQDFI<GMQAJYKQXXD>>, Id32<BMUDIFIQDFI<MYAKJBUXDCU>>, Id32<BMUDIFIQDFI<GZQXHQYHYRK<MYAKJBUXDCU>>>, Id32<BMUDIFIQDFI<GZQXHQYHYRK<MYAKJBUXDCU>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x28D7540", Offset = "0x28D5D40", VA = "0x1828D7540")]
		public static (Id32<BMUDIFIQDFI<GMQAJYKQXXD>>, Id32<BMUDIFIQDFI<GZQXHQYHYRK<MYAKJBUXDCU>>>, Id32<BMUDIFIQDFI<GZQXHQYHYRK<MYAKJBUXDCU>>>, Id32<BMUDIFIQDFI<GZQXHQYHYRK<MYAKJBUXDCU>>>) UZSVDBYUKKG(this UnsafeList<byte> a, [Optional] Id32<GZQXHQYHYRK<MYAKJBUXDCU>>? b, [Optional] Id32<GZQXHQYHYRK<MYAKJBUXDCU>>? c, [Optional] Id32<GZQXHQYHYRK<MYAKJBUXDCU>>? d)
		{
			return default((Id32<BMUDIFIQDFI<GMQAJYKQXXD>>, Id32<BMUDIFIQDFI<GZQXHQYHYRK<MYAKJBUXDCU>>>, Id32<BMUDIFIQDFI<GZQXHQYHYRK<MYAKJBUXDCU>>>, Id32<BMUDIFIQDFI<GZQXHQYHYRK<MYAKJBUXDCU>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x28D40B0", Offset = "0x28D28B0", VA = "0x1828D40B0")]
		public static (Id32<BMUDIFIQDFI<GMQAJYKQXXD>>, Id32<BMUDIFIQDFI<MYAKJBUXDCU>>, Id32<BMUDIFIQDFI<GZQXHQYHYRK<MYAKJBUXDCU>>>) GWOKEWMAWAH(this UnsafeList<byte> a, [Optional] int? b, [Optional] Id32<GZQXHQYHYRK<MYAKJBUXDCU>>? c)
		{
			return default((Id32<BMUDIFIQDFI<GMQAJYKQXXD>>, Id32<BMUDIFIQDFI<MYAKJBUXDCU>>, Id32<BMUDIFIQDFI<GZQXHQYHYRK<MYAKJBUXDCU>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x28D3D50", Offset = "0x28D2550", VA = "0x1828D3D50")]
		public static (Id32<BMUDIFIQDFI<GMQAJYKQXXD>>, Id32<BMUDIFIQDFI<GZQXHQYHYRK<MYAKJBUXDCU>>>, Id32<BMUDIFIQDFI<GZQXHQYHYRK<MYAKJBUXDCU>>>) FVBSLLDQEWU(this UnsafeList<byte> a, [Optional] Id32<GZQXHQYHYRK<MYAKJBUXDCU>>? b, [Optional] Id32<GZQXHQYHYRK<MYAKJBUXDCU>>? c)
		{
			return default((Id32<BMUDIFIQDFI<GMQAJYKQXXD>>, Id32<BMUDIFIQDFI<GZQXHQYHYRK<MYAKJBUXDCU>>>, Id32<BMUDIFIQDFI<GZQXHQYHYRK<MYAKJBUXDCU>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x28D6640", Offset = "0x28D4E40", VA = "0x1828D6640")]
		public static Id32<BMUDIFIQDFI<GMQAJYKQXXD>> OUAMDYNDKRP(this UnsafeList<byte> a)
		{
			return default(Id32<BMUDIFIQDFI<GMQAJYKQXXD>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x28D32B0", Offset = "0x28D1AB0", VA = "0x1828D32B0")]
		public static (Id32<BMUDIFIQDFI<GMQAJYKQXXD>>, Id32<BMUDIFIQDFI<EAYDFNCAMWR>>, Id32<BMUDIFIQDFI<EAYDFNCAMWR>>, Id32<BMUDIFIQDFI<GZQXHQYHYRK<EAYDFNCAMWR>>>) BQMGQXYVULA(this UnsafeList<byte> a, float b, float c, [Optional] Id32<GZQXHQYHYRK<EAYDFNCAMWR>>? d)
		{
			return default((Id32<BMUDIFIQDFI<GMQAJYKQXXD>>, Id32<BMUDIFIQDFI<EAYDFNCAMWR>>, Id32<BMUDIFIQDFI<EAYDFNCAMWR>>, Id32<BMUDIFIQDFI<GZQXHQYHYRK<EAYDFNCAMWR>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x28D2C10", Offset = "0x28D1410", VA = "0x1828D2C10")]
		public static (Id32<BMUDIFIQDFI<GMQAJYKQXXD>>, Id32<BMUDIFIQDFI<EAYDFNCAMWR>>, Id32<BMUDIFIQDFI<GZQXHQYHYRK<EAYDFNCAMWR>>>, Id32<BMUDIFIQDFI<GZQXHQYHYRK<EAYDFNCAMWR>>>) ALCLNEVPPUF(this UnsafeList<byte> a, float b, [Optional] Id32<GZQXHQYHYRK<EAYDFNCAMWR>>? c, [Optional] Id32<GZQXHQYHYRK<EAYDFNCAMWR>>? d)
		{
			return default((Id32<BMUDIFIQDFI<GMQAJYKQXXD>>, Id32<BMUDIFIQDFI<EAYDFNCAMWR>>, Id32<BMUDIFIQDFI<GZQXHQYHYRK<EAYDFNCAMWR>>>, Id32<BMUDIFIQDFI<GZQXHQYHYRK<EAYDFNCAMWR>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x28D5310", Offset = "0x28D3B10", VA = "0x1828D5310")]
		public static (Id32<BMUDIFIQDFI<GMQAJYKQXXD>>, Id32<BMUDIFIQDFI<GZQXHQYHYRK<EAYDFNCAMWR>>>, Id32<BMUDIFIQDFI<GZQXHQYHYRK<EAYDFNCAMWR>>>, Id32<BMUDIFIQDFI<GZQXHQYHYRK<EAYDFNCAMWR>>>) KOBYGVYRUUU(this UnsafeList<byte> a, [Optional] Id32<GZQXHQYHYRK<EAYDFNCAMWR>>? b, [Optional] Id32<GZQXHQYHYRK<EAYDFNCAMWR>>? c, [Optional] Id32<GZQXHQYHYRK<EAYDFNCAMWR>>? d)
		{
			return default((Id32<BMUDIFIQDFI<GMQAJYKQXXD>>, Id32<BMUDIFIQDFI<GZQXHQYHYRK<EAYDFNCAMWR>>>, Id32<BMUDIFIQDFI<GZQXHQYHYRK<EAYDFNCAMWR>>>, Id32<BMUDIFIQDFI<GZQXHQYHYRK<EAYDFNCAMWR>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x28D7780", Offset = "0x28D5F80", VA = "0x1828D7780")]
		public static (Id32<BMUDIFIQDFI<GMQAJYKQXXD>>, Id32<BMUDIFIQDFI<MYAKJBUXDCU>>, Id32<BMUDIFIQDFI<MYAKJBUXDCU>>, Id32<BMUDIFIQDFI<GZQXHQYHYRK<MYAKJBUXDCU>>>) VMHLGJJNAGA(this UnsafeList<byte> a, int b, int c, [Optional] Id32<GZQXHQYHYRK<MYAKJBUXDCU>>? d)
		{
			return default((Id32<BMUDIFIQDFI<GMQAJYKQXXD>>, Id32<BMUDIFIQDFI<MYAKJBUXDCU>>, Id32<BMUDIFIQDFI<MYAKJBUXDCU>>, Id32<BMUDIFIQDFI<GZQXHQYHYRK<MYAKJBUXDCU>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x28D5E60", Offset = "0x28D4660", VA = "0x1828D5E60")]
		public static (Id32<BMUDIFIQDFI<GMQAJYKQXXD>>, Id32<BMUDIFIQDFI<MYAKJBUXDCU>>, Id32<BMUDIFIQDFI<GZQXHQYHYRK<MYAKJBUXDCU>>>, Id32<BMUDIFIQDFI<GZQXHQYHYRK<MYAKJBUXDCU>>>) MVUBIDFVUJR(this UnsafeList<byte> a, int b, [Optional] Id32<GZQXHQYHYRK<MYAKJBUXDCU>>? c, [Optional] Id32<GZQXHQYHYRK<MYAKJBUXDCU>>? d)
		{
			return default((Id32<BMUDIFIQDFI<GMQAJYKQXXD>>, Id32<BMUDIFIQDFI<MYAKJBUXDCU>>, Id32<BMUDIFIQDFI<GZQXHQYHYRK<MYAKJBUXDCU>>>, Id32<BMUDIFIQDFI<GZQXHQYHYRK<MYAKJBUXDCU>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x28D7F30", Offset = "0x28D6730", VA = "0x1828D7F30")]
		public static (Id32<BMUDIFIQDFI<GMQAJYKQXXD>>, Id32<BMUDIFIQDFI<GZQXHQYHYRK<MYAKJBUXDCU>>>, Id32<BMUDIFIQDFI<GZQXHQYHYRK<MYAKJBUXDCU>>>, Id32<BMUDIFIQDFI<GZQXHQYHYRK<MYAKJBUXDCU>>>) WKJXSPVAMYW(this UnsafeList<byte> a, [Optional] Id32<GZQXHQYHYRK<MYAKJBUXDCU>>? b, [Optional] Id32<GZQXHQYHYRK<MYAKJBUXDCU>>? c, [Optional] Id32<GZQXHQYHYRK<MYAKJBUXDCU>>? d)
		{
			return default((Id32<BMUDIFIQDFI<GMQAJYKQXXD>>, Id32<BMUDIFIQDFI<GZQXHQYHYRK<MYAKJBUXDCU>>>, Id32<BMUDIFIQDFI<GZQXHQYHYRK<MYAKJBUXDCU>>>, Id32<BMUDIFIQDFI<GZQXHQYHYRK<MYAKJBUXDCU>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x28D73E0", Offset = "0x28D5BE0", VA = "0x1828D73E0")]
		public static (Id32<BMUDIFIQDFI<GMQAJYKQXXD>>, Id32<BMUDIFIQDFI<MYAKJBUXDCU>>, Id32<BMUDIFIQDFI<MYAKJBUXDCU>>, Id32<BMUDIFIQDFI<GZQXHQYHYRK<MYAKJBUXDCU>>>) UYPUGFDQHNB(this UnsafeList<byte> a, int b, int c, [Optional] Id32<GZQXHQYHYRK<MYAKJBUXDCU>>? d)
		{
			return default((Id32<BMUDIFIQDFI<GMQAJYKQXXD>>, Id32<BMUDIFIQDFI<MYAKJBUXDCU>>, Id32<BMUDIFIQDFI<MYAKJBUXDCU>>, Id32<BMUDIFIQDFI<GZQXHQYHYRK<MYAKJBUXDCU>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x28D7180", Offset = "0x28D5980", VA = "0x1828D7180")]
		public static (Id32<BMUDIFIQDFI<GMQAJYKQXXD>>, Id32<BMUDIFIQDFI<MYAKJBUXDCU>>, Id32<BMUDIFIQDFI<GZQXHQYHYRK<MYAKJBUXDCU>>>, Id32<BMUDIFIQDFI<GZQXHQYHYRK<MYAKJBUXDCU>>>) TXDCMTVFQJO(this UnsafeList<byte> a, int b, [Optional] Id32<GZQXHQYHYRK<MYAKJBUXDCU>>? c, [Optional] Id32<GZQXHQYHYRK<MYAKJBUXDCU>>? d)
		{
			return default((Id32<BMUDIFIQDFI<GMQAJYKQXXD>>, Id32<BMUDIFIQDFI<MYAKJBUXDCU>>, Id32<BMUDIFIQDFI<GZQXHQYHYRK<MYAKJBUXDCU>>>, Id32<BMUDIFIQDFI<GZQXHQYHYRK<MYAKJBUXDCU>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x28D6B80", Offset = "0x28D5380", VA = "0x1828D6B80")]
		public static (Id32<BMUDIFIQDFI<GMQAJYKQXXD>>, Id32<BMUDIFIQDFI<GZQXHQYHYRK<MYAKJBUXDCU>>>, Id32<BMUDIFIQDFI<GZQXHQYHYRK<MYAKJBUXDCU>>>, Id32<BMUDIFIQDFI<GZQXHQYHYRK<MYAKJBUXDCU>>>) RLFVDGUOHXX(this UnsafeList<byte> a, [Optional] Id32<GZQXHQYHYRK<MYAKJBUXDCU>>? b, [Optional] Id32<GZQXHQYHYRK<MYAKJBUXDCU>>? c, [Optional] Id32<GZQXHQYHYRK<MYAKJBUXDCU>>? d)
		{
			return default((Id32<BMUDIFIQDFI<GMQAJYKQXXD>>, Id32<BMUDIFIQDFI<GZQXHQYHYRK<MYAKJBUXDCU>>>, Id32<BMUDIFIQDFI<GZQXHQYHYRK<MYAKJBUXDCU>>>, Id32<BMUDIFIQDFI<GZQXHQYHYRK<MYAKJBUXDCU>>>));
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
