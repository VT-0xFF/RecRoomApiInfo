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
		[Cpp2IlInjected.Address(RVA = "0xAF57C0", Offset = "0xAF47C0", VA = "0x180AF57C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x2917E80", Offset = "0x2916E80", VA = "0x182917E80")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xAF5A10", Offset = "0xAF4A10", VA = "0x180AF5A10")]
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
		[Cpp2IlInjected.Address(RVA = "0xAF5A50", Offset = "0xAF4A50", VA = "0x180AF5A50")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
namespace Circuits.Shared.Core.ByteCode
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public static class HMDSZQHVIAY
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x37637D0", Offset = "0x37627D0", VA = "0x1837637D0")]
		public static Id32<IPPVCHRMOTE<a>> URVAECSUDVE<a>(this int a)
		{
			return default(Id32<IPPVCHRMOTE<a>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x29124A0", Offset = "0x29114A0", VA = "0x1829124A0")]
		public static Id32<SQTEKUFGHFF> SAOHDOMGCGX(this int a)
		{
			return default(Id32<SQTEKUFGHFF>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x37637D0", Offset = "0x37627D0", VA = "0x1837637D0")]
		public static Id32<SDPQMIFAXNK<b>> AKDULVFDGHK<b>(this int a)
		{
			return default(Id32<SDPQMIFAXNK<b>>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public sealed class IPPVCHRMOTE<a>
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public sealed class PQJHRGFBYRH
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public sealed class BVYDAJBFASE
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public sealed class SQTEKUFGHFF
	{
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public sealed class OEBZQFUZUXL
	{
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public sealed class JDVXBCTLHOL
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
	public static class GRBIBFRWEUI
	{
		[Cpp2IlInjected.Token(Token = "0x200000E")]
		public readonly struct ProcessOpDelegate<TContext, TDeps, TCompileState>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000091")]
			private readonly IntPtr _impl;

			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0xC41C50", Offset = "0xC40C50", VA = "0x180C41C50")]
			public ProcessOpDelegate(IntPtr impl)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x5DFA5F0", Offset = "0x5DF95F0", VA = "0x185DFA5F0")]
			public int Invoke(TDeps deps, TContext ctx, TCompileState compileState, [In] UnsafeList<byte> fromByteCode, int byteCodePtr)
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x374F030", Offset = "0x374E030", VA = "0x18374F030")]
		public static void URIMNUXWGZR<TDeps, TContext, TCompileState>(TDeps a, TContext b, TCompileState c, [In] UnsafeList<byte> oldByteCode, UnsafeList<byte> newByteCode, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processAddF32_F32i_F32i_F32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processAddF32_F32i_F32r_F32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processAddF32_F32r_F32r_F32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processAddI32_I32i_I32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processAddI32_I32i_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processAddI32_I32r_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processAndI32_I32i_I32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processAndI32_I32i_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processAndI32_I32r_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfEqualF32_F32i_F32i_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfEqualF32_F32i_F32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfEqualF32_F32r_F32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfEqualI32_I32i_I32i_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfEqualI32_I32i_I32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfEqualI32_I32r_I32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfGreaterOrEqualF32_F32i_F32i_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfGreaterOrEqualF32_F32i_F32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfGreaterOrEqualF32_F32r_F32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfGreaterOrEqualI32_I32i_I32i_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfGreaterOrEqualI32_I32i_I32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfGreaterOrEqualI32_I32r_I32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfLessF32_F32i_F32i_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfLessF32_F32i_F32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfLessF32_F32r_F32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfLessI32_I32i_I32i_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfLessI32_I32i_I32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfLessI32_I32r_I32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfLessOrEqualF32_F32i_F32i_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfLessOrEqualF32_F32i_F32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfLessOrEqualF32_F32r_F32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfLessOrEqualI32_I32i_I32i_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfLessOrEqualI32_I32i_I32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfLessOrEqualI32_I32r_I32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfNotEqualF32_F32i_F32i_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfNotEqualF32_F32i_F32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfNotEqualF32_F32r_F32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfNotEqualI32_I32i_I32i_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfNotEqualI32_I32i_I32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfNotEqualI32_I32r_I32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfNotZeroF32_F32i_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfNotZeroF32_F32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfNotZeroI32_I32i_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfNotZeroI32_I32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfZeroF32_F32i_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfZeroF32_F32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfZeroI32_I32i_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfZeroI32_I32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processCallInternal_I32i_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processCallInternal_I32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processCallExternal_I32i_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processCallExternal_I32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processCallRuntime_I32i_I32i_Xi, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processCopyI32_I32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processCopyI32_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processCopyX_Xr_I32i_Xi, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processCopyX_Xr_Xr_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processDivideF32_F32i_F32i_F32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processDivideF32_F32i_F32r_F32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processDivideF32_F32r_F32r_F32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processDivideI32_I32i_I32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processDivideI32_I32i_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processDivideI32_I32r_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processEqualF32_F32i_F32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processEqualF32_F32i_F32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processEqualF32_F32r_F32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processEqualI32_I32i_I32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processEqualI32_I32i_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processEqualI32_I32r_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processEnd, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processGreaterF32_F32i_F32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processGreaterF32_F32i_F32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processGreaterF32_F32r_F32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processGreaterI32_I32i_I32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processGreaterI32_I32i_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processGreaterI32_I32r_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processGreaterOrEqualF32_F32i_F32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processGreaterOrEqualF32_F32i_F32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processGreaterOrEqualF32_F32r_F32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processGreaterOrEqualI32_I32i_I32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processGreaterOrEqualI32_I32i_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processGreaterOrEqualI32_I32r_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processJump_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processJump_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processLessF32_F32i_F32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processLessF32_F32i_F32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processLessF32_F32r_F32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processLessI32_I32i_I32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processLessI32_I32i_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processLessI32_I32r_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processLessOrEqualF32_F32i_F32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processLessOrEqualF32_F32i_F32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processLessOrEqualF32_F32r_F32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processLessOrEqualI32_I32i_I32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processLessOrEqualI32_I32i_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processLessOrEqualI32_I32r_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processModI32_I32i_I32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processModI32_I32i_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processModI32_I32r_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processMultiplyF32_F32i_F32i_F32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processMultiplyF32_F32i_F32r_F32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processMultiplyF32_F32r_F32r_F32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processMultiplyI32_I32i_I32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processMultiplyI32_I32i_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processMultiplyI32_I32r_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processNegateF32_F32i_F32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processNegateF32_F32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processNegateF32_F32r_F32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processNegateI32_I32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processNegateI32_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processNegateI32_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processNoOp, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processNotEqualF32_F32i_F32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processNotEqualF32_F32i_F32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processNotEqualF32_F32r_F32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processNotEqualI32_I32i_I32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processNotEqualI32_I32i_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processNotEqualI32_I32r_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processNotI32_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processNotI32_I32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processNotI32_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processOrI32_I32i_I32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processOrI32_I32i_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processOrI32_I32r_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processReturn, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processStaticCastF32I32_F32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processStaticCastI32F32_I32r_F32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processSubtractF32_F32i_F32i_F32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processSubtractF32_F32i_F32r_F32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processSubtractF32_F32r_F32r_F32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processSubtractI32_I32i_I32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processSubtractI32_I32i_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processSubtractI32_I32r_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processXorI32_I32i_I32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processXorI32_I32i_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processXorI32_I32r_I32r_I32r) where TDeps : notnull where TContext : notnull where TCompileState : notnull
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x2912400", Offset = "0x2911400", VA = "0x182912400")]
		private static int BSMMQLBEHZX([In] UnsafeList<byte> from, UnsafeList<byte> a, int b, int c)
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public static class BXPQYLJVWDF
	{
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		public static readonly int CAEPNLCEAVV;

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x342DC70", Offset = "0x342CC70", VA = "0x18342DC70")]
		public static Id32<IPPVCHRMOTE<a>> KLADDZAMJDT<a>([In] this UnsafeList<byte> self)
		{
			return default(Id32<IPPVCHRMOTE<a>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x342DB30", Offset = "0x342CB30", VA = "0x18342DB30")]
		public static Id32<IPPVCHRMOTE<IPPVCHRMOTE<b>>> CLUKEQNXDOG<b>(this UnsafeList<byte> a, [Optional] Id32<IPPVCHRMOTE<b>>? b)
		{
			return default(Id32<IPPVCHRMOTE<IPPVCHRMOTE<b>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x29122D0", Offset = "0x29112D0", VA = "0x1829122D0")]
		public static Id32<IPPVCHRMOTE<LSCPVJVXELH>> VVKIDOJBJAQ(this UnsafeList<byte> a, [Optional] Id32<LSCPVJVXELH>? b)
		{
			return default(Id32<IPPVCHRMOTE<LSCPVJVXELH>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x2911D30", Offset = "0x2910D30", VA = "0x182911D30")]
		public static Id32<IPPVCHRMOTE<PQJHRGFBYRH>> BGVRWIVKSAW(this UnsafeList<byte> a, [Optional] float? b)
		{
			return default(Id32<IPPVCHRMOTE<PQJHRGFBYRH>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x29121F0", Offset = "0x29111F0", VA = "0x1829121F0")]
		public static Id32<IPPVCHRMOTE<BVYDAJBFASE>> TZKPKCYRQBB(this UnsafeList<byte> a, [Optional] int? b)
		{
			return default(Id32<IPPVCHRMOTE<BVYDAJBFASE>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x2911F10", Offset = "0x2910F10", VA = "0x182911F10")]
		public static Id32<IPPVCHRMOTE<WNOXGYXOQBA>> LJADOFXXJKF(this UnsafeList<byte> a, [Optional] Id32<WNOXGYXOQBA>? b)
		{
			return default(Id32<IPPVCHRMOTE<WNOXGYXOQBA>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x29120F0", Offset = "0x29110F0", VA = "0x1829120F0")]
		public static Id32<IPPVCHRMOTE<JDVXBCTLHOL>> TRQZMADFIRA(this UnsafeList<byte> a, [Optional] byte? b)
		{
			return default(Id32<IPPVCHRMOTE<JDVXBCTLHOL>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x2912000", Offset = "0x2911000", VA = "0x182912000")]
		public static Id32<IPPVCHRMOTE<SQTEKUFGHFF>> PRLYXBWRFPI(this UnsafeList<byte> a, [Optional] Id32<SQTEKUFGHFF>? b)
		{
			return default(Id32<IPPVCHRMOTE<SQTEKUFGHFF>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x2911E20", Offset = "0x2910E20", VA = "0x182911E20")]
		public static Id32<IPPVCHRMOTE<OEBZQFUZUXL>> IXIHVADZKNO(this UnsafeList<byte> a, [Optional] Op? b)
		{
			return default(Id32<IPPVCHRMOTE<OEBZQFUZUXL>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x342DB30", Offset = "0x342CB30", VA = "0x18342DB30")]
		public static Id32<IPPVCHRMOTE<SDPQMIFAXNK<c>>> YCCXDRWFZTS<c>(this UnsafeList<byte> a, [Optional] Id32<SDPQMIFAXNK<c>>? b)
		{
			return default(Id32<IPPVCHRMOTE<SDPQMIFAXNK<c>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x2911B80", Offset = "0x2910B80", VA = "0x182911B80")]
		public static void GOQXRTBSCRS(this UnsafeList<byte> a, Id32<IPPVCHRMOTE<BVYDAJBFASE>> b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x342DC10", Offset = "0x342CC10", VA = "0x18342DC10")]
		public static void HFWFPXDDDIF<d>(this UnsafeList<byte> a, Id32<IPPVCHRMOTE<IPPVCHRMOTE<d>>> b, Id32<IPPVCHRMOTE<d>> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x342DC10", Offset = "0x342CC10", VA = "0x18342DC10")]
		public static void HSCJDQACFVJ<e>(this UnsafeList<byte> a, Id32<IPPVCHRMOTE<SDPQMIFAXNK<e>>> b, Id32<SDPQMIFAXNK<e>> c)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public static class TZTIAIALQCK
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x2918300", Offset = "0x2917300", VA = "0x182918300")]
		public static Union32 MGEQGVIUWRS([In] this ReadOnlySpan<byte> bytes, int a)
		{
			return default(Union32);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x2918260", Offset = "0x2917260", VA = "0x182918260")]
		public static Union32 MGEQGVIUWRS([In] this UnsafeList<byte> bytes, int a)
		{
			return default(Union32);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x3B0DB30", Offset = "0x3B0CB30", VA = "0x183B0DB30")]
		public static Union32 MGEQGVIUWRS<f>(this ReadOnlyIdArray<f, byte> a, Id32<f> b)
		{
			return default(Union32);
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x3B0E100", Offset = "0x3B0D100", VA = "0x183B0E100")]
		public static Union32 MGEQGVIUWRS<g>([In] this ReadOnlyIdSpan<g, byte> bytes, Id32<g> a)
		{
			return default(Union32);
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x3B0DAD0", Offset = "0x3B0CAD0", VA = "0x183B0DAD0")]
		public static Union32 MGEQGVIUWRS<i>(this IdArray<i, byte> a, Id32<i> b)
		{
			return default(Union32);
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x3B0E090", Offset = "0x3B0D090", VA = "0x183B0E090")]
		public static Union32 MGEQGVIUWRS<j>([In] this IdSpan<j, byte> bytes, Id32<j> a)
		{
			return default(Union32);
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x3B0E280", Offset = "0x3B0D280", VA = "0x183B0E280")]
		public static Union32 MGEQGVIUWRS<k>(this ReadOnlyIdArray<k, byte> a, Id32<k> b)
		{
			return default(Union32);
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x2918300", Offset = "0x2917300", VA = "0x182918300")]
		public static int XNWZJJTDBGP([In] this ReadOnlySpan<byte> bytes, int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x2911D20", Offset = "0x2910D20", VA = "0x182911D20")]
		public static int XNWZJJTDBGP([In] this UnsafeList<byte> bytes, int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x3B0EFB0", Offset = "0x3B0DFB0", VA = "0x183B0EFB0")]
		public static int XNWZJJTDBGP<p>(this ReadOnlyIdArray<p, byte> a, Id32<p> b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x3B0F000", Offset = "0x3B0E000", VA = "0x183B0F000")]
		public static int XNWZJJTDBGP<s>(this IdArray<s, byte> a, Id32<s> b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x3B0EF10", Offset = "0x3B0DF10", VA = "0x183B0EF10")]
		public static int XNWZJJTDBGP<t>([In] this IdSpan<t, byte> bytes, Id32<t> a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x3B0EF60", Offset = "0x3B0DF60", VA = "0x183B0EF60")]
		public static int XNWZJJTDBGP<u>(this ReadOnlyIdArray<u, byte> a, Id32<u> b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x3B0D970", Offset = "0x3B0C970", VA = "0x183B0D970")]
		public static float IYXEHLMRIVA<bc>(this IdArray<bc, byte> a, Id32<bc> b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x3B0D920", Offset = "0x3B0C920", VA = "0x183B0D920")]
		public static float IYXEHLMRIVA<bd>([In] this IdSpan<bd, byte> bytes, Id32<bd> a)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x3B0D9F0", Offset = "0x3B0C9F0", VA = "0x183B0D9F0")]
		public static float IYXEHLMRIVA<be>(this ReadOnlyIdArray<be, byte> a, Id32<be> b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x3B0D580", Offset = "0x3B0C580", VA = "0x183B0D580")]
		public static byte FJKRBSIOZZY<bj>(this ReadOnlyIdArray<bj, byte> a, Id32<bj> b)
		{
			return default(byte);
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x3B0D5D0", Offset = "0x3B0C5D0", VA = "0x183B0D5D0")]
		public static byte FJKRBSIOZZY<bk>([In] this ReadOnlyIdSpan<bk, byte> bytes, Id32<bk> a)
		{
			return default(byte);
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x3B0D6B0", Offset = "0x3B0C6B0", VA = "0x183B0D6B0")]
		public static byte FJKRBSIOZZY<bm>(this IdArray<bm, byte> a, Id32<bm> b)
		{
			return default(byte);
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x3B0D620", Offset = "0x3B0C620", VA = "0x183B0D620")]
		public static byte FJKRBSIOZZY<bn>([In] this IdSpan<bn, byte> bytes, Id32<bn> a)
		{
			return default(byte);
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x3B0D730", Offset = "0x3B0C730", VA = "0x183B0D730")]
		public static byte FJKRBSIOZZY<bo>(this ReadOnlyIdArray<bo, byte> a, Id32<bo> b)
		{
			return default(byte);
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x2911D20", Offset = "0x2910D20", VA = "0x182911D20")]
		public static Op UVOMBAWCRVO([In] this UnsafeList<byte> bytes, int a)
		{
			return default(Op);
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x3B0EE10", Offset = "0x3B0DE10", VA = "0x183B0EE10")]
		public static Op UVOMBAWCRVO<by>(this ReadOnlyIdArray<by, byte> a, Id32<by> b)
		{
			return default(Op);
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x3B0EBA0", Offset = "0x3B0DBA0", VA = "0x183B0EBA0")]
		public static Id32<IPPVCHRMOTE<WFYGDDOIHYI>> SRNZHNCUMWO<cg>(this IdArray<cg, byte> a, Id32<cg> b)
		{
			return default(Id32<IPPVCHRMOTE<WFYGDDOIHYI>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x3B0EC20", Offset = "0x3B0DC20", VA = "0x183B0EC20")]
		public static Id32<IPPVCHRMOTE<WFYGDDOIHYI>> SRNZHNCUMWO<ch>([In] this IdSpan<ch, byte> bytes, Id32<ch> a)
		{
			return default(Id32<IPPVCHRMOTE<WFYGDDOIHYI>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x3B0EB10", Offset = "0x3B0DB10", VA = "0x183B0EB10")]
		public static Id32<IPPVCHRMOTE<WFYGDDOIHYI>> SRNZHNCUMWO<ci>(this ReadOnlyIdArray<ci, byte> a, Id32<ci> b)
		{
			return default(Id32<IPPVCHRMOTE<WFYGDDOIHYI>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x3B0E900", Offset = "0x3B0D900", VA = "0x183B0E900")]
		public static Id32<SDPQMIFAXNK<WFYGDDOIHYI>> QUTLHBVEWBW<cs>(this ReadOnlyIdArray<cs, byte> a, Id32<cs> b)
		{
			return default(Id32<SDPQMIFAXNK<WFYGDDOIHYI>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x3B0E6E0", Offset = "0x3B0D6E0", VA = "0x183B0E6E0")]
		public static Id32<SQTEKUFGHFF> QKYIFUOXMMY<da>(this IdArray<da, byte> a, Id32<da> b)
		{
			return default(Id32<SQTEKUFGHFF>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x3B0E7F0", Offset = "0x3B0D7F0", VA = "0x183B0E7F0")]
		public static Id32<SQTEKUFGHFF> QKYIFUOXMMY<db>([In] this IdSpan<db, byte> bytes, Id32<db> a)
		{
			return default(Id32<SQTEKUFGHFF>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x3B0E760", Offset = "0x3B0D760", VA = "0x183B0E760")]
		public static Id32<SQTEKUFGHFF> QKYIFUOXMMY<dc>(this ReadOnlyIdArray<dc, byte> a, Id32<dc> b)
		{
			return default(Id32<SQTEKUFGHFF>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x3B0E4D0", Offset = "0x3B0D4D0", VA = "0x183B0E4D0")]
		public static Id32<LSCPVJVXELH> MPQMXOPEITY<dl>([In] this IdSpan<dl, byte> bytes, Id32<dl> a)
		{
			return default(Id32<LSCPVJVXELH>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x3B0E440", Offset = "0x3B0D440", VA = "0x183B0E440")]
		public static Id32<LSCPVJVXELH> MPQMXOPEITY<dm>(this ReadOnlyIdArray<dm, byte> a, Id32<dm> b)
		{
			return default(Id32<LSCPVJVXELH>);
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x3B0ED30", Offset = "0x3B0DD30", VA = "0x183B0ED30")]
		public static Id32<WNOXGYXOQBA> TMAQDHBMHSR<dw>(this ReadOnlyIdArray<dw, byte> a, Id32<dw> b)
		{
			return default(Id32<WNOXGYXOQBA>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public static class PFYXSIYSKJI
	{
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x2918000", Offset = "0x2917000", VA = "0x182918000")]
		public static void JKQERVLNUYP(this UnsafeList<byte> a, int b, Union32 c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x29180C0", Offset = "0x29170C0", VA = "0x1829180C0")]
		public static void JKQERVLNUYP(this byte[] a, int b, Union32 c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x2918130", Offset = "0x2917130", VA = "0x182918130")]
		public static void JKQERVLNUYP([In] this Span<byte> bytes, int a, Union32 b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x3971840", Offset = "0x3970840", VA = "0x183971840")]
		public static void JKQERVLNUYP<e>(this IdArray<e, byte> a, Id32<e> b, Union32 c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x39716F0", Offset = "0x39706F0", VA = "0x1839716F0")]
		public static void JKQERVLNUYP<f>([In] this IdSpan<f, byte> bytes, Id32<f> a, Union32 b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x2911B80", Offset = "0x2910B80", VA = "0x182911B80")]
		public static void GOQXRTBSCRS(this UnsafeList<byte> a, int b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x2917F00", Offset = "0x2916F00", VA = "0x182917F00")]
		public static void GOQXRTBSCRS(this byte[] a, int b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x2917F80", Offset = "0x2916F80", VA = "0x182917F80")]
		public static void GOQXRTBSCRS([In] this Span<byte> bytes, int a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x3971270", Offset = "0x3970270", VA = "0x183971270")]
		public static void GOQXRTBSCRS<h>(this IdArray<h, byte> a, Id32<h> b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x39712D0", Offset = "0x39702D0", VA = "0x1839712D0")]
		public static void GOQXRTBSCRS<i>([In] this IdSpan<i, byte> bytes, Id32<i> a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x2918220", Offset = "0x2917220", VA = "0x182918220")]
		public static void YMREUMCKGFL(this UnsafeList<byte> a, int b, float c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x3971BD0", Offset = "0x3970BD0", VA = "0x183971BD0")]
		public static void YMREUMCKGFL<k>(this IdArray<k, byte> a, Id32<k> b, float c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x3971C40", Offset = "0x3970C40", VA = "0x183971C40")]
		public static void YMREUMCKGFL<l>([In] this IdSpan<l, byte> bytes, Id32<l> a, float b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x29181B0", Offset = "0x29171B0", VA = "0x1829181B0")]
		public static void XKMZNFIUPYT(this UnsafeList<byte> a, int b, byte c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x3971AA0", Offset = "0x3970AA0", VA = "0x183971AA0")]
		public static void XKMZNFIUPYT<n>(this IdArray<n, byte> a, Id32<n> b, byte c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x3971A40", Offset = "0x3970A40", VA = "0x183971A40")]
		public static void XKMZNFIUPYT<o>([In] this IdSpan<o, byte> bytes, Id32<o> a, byte b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x3971470", Offset = "0x3970470", VA = "0x183971470")]
		public static void HFWFPXDDDIF<q>(this IdArray<q, byte> a, Id32<q> b, Id32<IPPVCHRMOTE<WFYGDDOIHYI>> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x39713F0", Offset = "0x39703F0", VA = "0x1839713F0")]
		public static void HFWFPXDDDIF<r>([In] this IdSpan<r, byte> bytes, Id32<r> a, Id32<IPPVCHRMOTE<WFYGDDOIHYI>> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x3971470", Offset = "0x3970470", VA = "0x183971470")]
		public static void TKEIRUHNNHF<t>(this IdArray<t, byte> a, Id32<t> b, Id32<SQTEKUFGHFF> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x39713F0", Offset = "0x39703F0", VA = "0x1839713F0")]
		public static void TKEIRUHNNHF<u>([In] this IdSpan<u, byte> bytes, Id32<u> a, Id32<SQTEKUFGHFF> b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public static class JBGARYBACDZ
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x2914E30", Offset = "0x2913E30", VA = "0x182914E30")]
		public static (Id32<IPPVCHRMOTE<OEBZQFUZUXL>>, Id32<IPPVCHRMOTE<PQJHRGFBYRH>>, Id32<IPPVCHRMOTE<PQJHRGFBYRH>>, Id32<IPPVCHRMOTE<SDPQMIFAXNK<PQJHRGFBYRH>>>) KQWUDLZELBN(this UnsafeList<byte> a, float b, float c, [Optional] Id32<SDPQMIFAXNK<PQJHRGFBYRH>>? d)
		{
			return default((Id32<IPPVCHRMOTE<OEBZQFUZUXL>>, Id32<IPPVCHRMOTE<PQJHRGFBYRH>>, Id32<IPPVCHRMOTE<PQJHRGFBYRH>>, Id32<IPPVCHRMOTE<SDPQMIFAXNK<PQJHRGFBYRH>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x2913910", Offset = "0x2912910", VA = "0x182913910")]
		public static (Id32<IPPVCHRMOTE<OEBZQFUZUXL>>, Id32<IPPVCHRMOTE<PQJHRGFBYRH>>, Id32<IPPVCHRMOTE<SDPQMIFAXNK<PQJHRGFBYRH>>>, Id32<IPPVCHRMOTE<SDPQMIFAXNK<PQJHRGFBYRH>>>) FZKESPLBJSE(this UnsafeList<byte> a, float b, [Optional] Id32<SDPQMIFAXNK<PQJHRGFBYRH>>? c, [Optional] Id32<SDPQMIFAXNK<PQJHRGFBYRH>>? d)
		{
			return default((Id32<IPPVCHRMOTE<OEBZQFUZUXL>>, Id32<IPPVCHRMOTE<PQJHRGFBYRH>>, Id32<IPPVCHRMOTE<SDPQMIFAXNK<PQJHRGFBYRH>>>, Id32<IPPVCHRMOTE<SDPQMIFAXNK<PQJHRGFBYRH>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x2914340", Offset = "0x2913340", VA = "0x182914340")]
		public static (Id32<IPPVCHRMOTE<OEBZQFUZUXL>>, Id32<IPPVCHRMOTE<SDPQMIFAXNK<PQJHRGFBYRH>>>, Id32<IPPVCHRMOTE<SDPQMIFAXNK<PQJHRGFBYRH>>>, Id32<IPPVCHRMOTE<SDPQMIFAXNK<PQJHRGFBYRH>>>) IZLCXGHZRTH(this UnsafeList<byte> a, [Optional] Id32<SDPQMIFAXNK<PQJHRGFBYRH>>? b, [Optional] Id32<SDPQMIFAXNK<PQJHRGFBYRH>>? c, [Optional] Id32<SDPQMIFAXNK<PQJHRGFBYRH>>? d)
		{
			return default((Id32<IPPVCHRMOTE<OEBZQFUZUXL>>, Id32<IPPVCHRMOTE<SDPQMIFAXNK<PQJHRGFBYRH>>>, Id32<IPPVCHRMOTE<SDPQMIFAXNK<PQJHRGFBYRH>>>, Id32<IPPVCHRMOTE<SDPQMIFAXNK<PQJHRGFBYRH>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x2912D20", Offset = "0x2911D20", VA = "0x182912D20")]
		public static (Id32<IPPVCHRMOTE<OEBZQFUZUXL>>, Id32<IPPVCHRMOTE<BVYDAJBFASE>>, Id32<IPPVCHRMOTE<BVYDAJBFASE>>, Id32<IPPVCHRMOTE<SDPQMIFAXNK<BVYDAJBFASE>>>) CMQJDAUCRAV(this UnsafeList<byte> a, int b, int c, [Optional] Id32<SDPQMIFAXNK<BVYDAJBFASE>>? d)
		{
			return default((Id32<IPPVCHRMOTE<OEBZQFUZUXL>>, Id32<IPPVCHRMOTE<BVYDAJBFASE>>, Id32<IPPVCHRMOTE<BVYDAJBFASE>>, Id32<IPPVCHRMOTE<SDPQMIFAXNK<BVYDAJBFASE>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x2912E80", Offset = "0x2911E80", VA = "0x182912E80")]
		public static (Id32<IPPVCHRMOTE<OEBZQFUZUXL>>, Id32<IPPVCHRMOTE<BVYDAJBFASE>>, Id32<IPPVCHRMOTE<SDPQMIFAXNK<BVYDAJBFASE>>>, Id32<IPPVCHRMOTE<SDPQMIFAXNK<BVYDAJBFASE>>>) COTSSMTKXOW(this UnsafeList<byte> a, int b, [Optional] Id32<SDPQMIFAXNK<BVYDAJBFASE>>? c, [Optional] Id32<SDPQMIFAXNK<BVYDAJBFASE>>? d)
		{
			return default((Id32<IPPVCHRMOTE<OEBZQFUZUXL>>, Id32<IPPVCHRMOTE<BVYDAJBFASE>>, Id32<IPPVCHRMOTE<SDPQMIFAXNK<BVYDAJBFASE>>>, Id32<IPPVCHRMOTE<SDPQMIFAXNK<BVYDAJBFASE>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x29147D0", Offset = "0x29137D0", VA = "0x1829147D0")]
		public static (Id32<IPPVCHRMOTE<OEBZQFUZUXL>>, Id32<IPPVCHRMOTE<SDPQMIFAXNK<BVYDAJBFASE>>>, Id32<IPPVCHRMOTE<SDPQMIFAXNK<BVYDAJBFASE>>>, Id32<IPPVCHRMOTE<SDPQMIFAXNK<BVYDAJBFASE>>>) JJHLNQXCCTV(this UnsafeList<byte> a, [Optional] Id32<SDPQMIFAXNK<BVYDAJBFASE>>? b, [Optional] Id32<SDPQMIFAXNK<BVYDAJBFASE>>? c, [Optional] Id32<SDPQMIFAXNK<BVYDAJBFASE>>? d)
		{
			return default((Id32<IPPVCHRMOTE<OEBZQFUZUXL>>, Id32<IPPVCHRMOTE<SDPQMIFAXNK<BVYDAJBFASE>>>, Id32<IPPVCHRMOTE<SDPQMIFAXNK<BVYDAJBFASE>>>, Id32<IPPVCHRMOTE<SDPQMIFAXNK<BVYDAJBFASE>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x2917950", Offset = "0x2916950", VA = "0x182917950")]
		public static (Id32<IPPVCHRMOTE<OEBZQFUZUXL>>, Id32<IPPVCHRMOTE<BVYDAJBFASE>>, Id32<IPPVCHRMOTE<BVYDAJBFASE>>, Id32<IPPVCHRMOTE<SDPQMIFAXNK<BVYDAJBFASE>>>) ZCFKTKBLTCP(this UnsafeList<byte> a, int b, int c, [Optional] Id32<SDPQMIFAXNK<BVYDAJBFASE>>? d)
		{
			return default((Id32<IPPVCHRMOTE<OEBZQFUZUXL>>, Id32<IPPVCHRMOTE<BVYDAJBFASE>>, Id32<IPPVCHRMOTE<BVYDAJBFASE>>, Id32<IPPVCHRMOTE<SDPQMIFAXNK<BVYDAJBFASE>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x29137C0", Offset = "0x29127C0", VA = "0x1829137C0")]
		public static (Id32<IPPVCHRMOTE<OEBZQFUZUXL>>, Id32<IPPVCHRMOTE<BVYDAJBFASE>>, Id32<IPPVCHRMOTE<SDPQMIFAXNK<BVYDAJBFASE>>>, Id32<IPPVCHRMOTE<SDPQMIFAXNK<BVYDAJBFASE>>>) FVVGCKHKHIM(this UnsafeList<byte> a, int b, [Optional] Id32<SDPQMIFAXNK<BVYDAJBFASE>>? c, [Optional] Id32<SDPQMIFAXNK<BVYDAJBFASE>>? d)
		{
			return default((Id32<IPPVCHRMOTE<OEBZQFUZUXL>>, Id32<IPPVCHRMOTE<BVYDAJBFASE>>, Id32<IPPVCHRMOTE<SDPQMIFAXNK<BVYDAJBFASE>>>, Id32<IPPVCHRMOTE<SDPQMIFAXNK<BVYDAJBFASE>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x2913FA0", Offset = "0x2912FA0", VA = "0x182913FA0")]
		public static (Id32<IPPVCHRMOTE<OEBZQFUZUXL>>, Id32<IPPVCHRMOTE<SDPQMIFAXNK<BVYDAJBFASE>>>, Id32<IPPVCHRMOTE<SDPQMIFAXNK<BVYDAJBFASE>>>, Id32<IPPVCHRMOTE<SDPQMIFAXNK<BVYDAJBFASE>>>) HUMRXARXUTL(this UnsafeList<byte> a, [Optional] Id32<SDPQMIFAXNK<BVYDAJBFASE>>? b, [Optional] Id32<SDPQMIFAXNK<BVYDAJBFASE>>? c, [Optional] Id32<SDPQMIFAXNK<BVYDAJBFASE>>? d)
		{
			return default((Id32<IPPVCHRMOTE<OEBZQFUZUXL>>, Id32<IPPVCHRMOTE<SDPQMIFAXNK<BVYDAJBFASE>>>, Id32<IPPVCHRMOTE<SDPQMIFAXNK<BVYDAJBFASE>>>, Id32<IPPVCHRMOTE<SDPQMIFAXNK<BVYDAJBFASE>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x2915270", Offset = "0x2914270", VA = "0x182915270")]
		public static (Id32<IPPVCHRMOTE<OEBZQFUZUXL>>, Id32<IPPVCHRMOTE<BVYDAJBFASE>>, Id32<IPPVCHRMOTE<IPPVCHRMOTE<OEBZQFUZUXL>>>) LSKMQJMWNWT(this UnsafeList<byte> a, [Optional] int? b, [Optional] Id32<IPPVCHRMOTE<OEBZQFUZUXL>>? c)
		{
			return default((Id32<IPPVCHRMOTE<OEBZQFUZUXL>>, Id32<IPPVCHRMOTE<BVYDAJBFASE>>, Id32<IPPVCHRMOTE<IPPVCHRMOTE<OEBZQFUZUXL>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x2917D60", Offset = "0x2916D60", VA = "0x182917D60")]
		public static (Id32<IPPVCHRMOTE<OEBZQFUZUXL>>, Id32<IPPVCHRMOTE<SDPQMIFAXNK<BVYDAJBFASE>>>, Id32<IPPVCHRMOTE<IPPVCHRMOTE<OEBZQFUZUXL>>>) ZSLDSJWCXHG(this UnsafeList<byte> a, [Optional] Id32<SDPQMIFAXNK<BVYDAJBFASE>>? b, [Optional] Id32<IPPVCHRMOTE<OEBZQFUZUXL>>? c)
		{
			return default((Id32<IPPVCHRMOTE<OEBZQFUZUXL>>, Id32<IPPVCHRMOTE<SDPQMIFAXNK<BVYDAJBFASE>>>, Id32<IPPVCHRMOTE<IPPVCHRMOTE<OEBZQFUZUXL>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x2917400", Offset = "0x2916400", VA = "0x182917400")]
		public static (Id32<IPPVCHRMOTE<OEBZQFUZUXL>>, Id32<IPPVCHRMOTE<BVYDAJBFASE>>, Id32<IPPVCHRMOTE<IPPVCHRMOTE<OEBZQFUZUXL>>>) WKNHEBSUKLS(this UnsafeList<byte> a, [Optional] int? b, [Optional] Id32<IPPVCHRMOTE<OEBZQFUZUXL>>? c)
		{
			return default((Id32<IPPVCHRMOTE<OEBZQFUZUXL>>, Id32<IPPVCHRMOTE<BVYDAJBFASE>>, Id32<IPPVCHRMOTE<IPPVCHRMOTE<OEBZQFUZUXL>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x2912C00", Offset = "0x2911C00", VA = "0x182912C00")]
		public static (Id32<IPPVCHRMOTE<OEBZQFUZUXL>>, Id32<IPPVCHRMOTE<SDPQMIFAXNK<BVYDAJBFASE>>>, Id32<IPPVCHRMOTE<IPPVCHRMOTE<OEBZQFUZUXL>>>) CEOAFVYZJCD(this UnsafeList<byte> a, [Optional] Id32<SDPQMIFAXNK<BVYDAJBFASE>>? b, [Optional] Id32<IPPVCHRMOTE<OEBZQFUZUXL>>? c)
		{
			return default((Id32<IPPVCHRMOTE<OEBZQFUZUXL>>, Id32<IPPVCHRMOTE<SDPQMIFAXNK<BVYDAJBFASE>>>, Id32<IPPVCHRMOTE<IPPVCHRMOTE<OEBZQFUZUXL>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x2917510", Offset = "0x2916510", VA = "0x182917510")]
		public static (Id32<IPPVCHRMOTE<OEBZQFUZUXL>>, Id32<IPPVCHRMOTE<BVYDAJBFASE>>, Id32<IPPVCHRMOTE<LSCPVJVXELH>>) WQTBCUGCZII(this UnsafeList<byte> a, [Optional] int? b, [Optional] Id32<LSCPVJVXELH>? c)
		{
			return default((Id32<IPPVCHRMOTE<OEBZQFUZUXL>>, Id32<IPPVCHRMOTE<BVYDAJBFASE>>, Id32<IPPVCHRMOTE<LSCPVJVXELH>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x29176C0", Offset = "0x29166C0", VA = "0x1829176C0")]
		public static (Id32<IPPVCHRMOTE<OEBZQFUZUXL>>, Id32<IPPVCHRMOTE<BVYDAJBFASE>>, Id32<IPPVCHRMOTE<SDPQMIFAXNK<LSCPVJVXELH>>>) WWFFGUXJUCR(this UnsafeList<byte> a, [Optional] int? b, [Optional] Id32<SDPQMIFAXNK<LSCPVJVXELH>>? c)
		{
			return default((Id32<IPPVCHRMOTE<OEBZQFUZUXL>>, Id32<IPPVCHRMOTE<BVYDAJBFASE>>, Id32<IPPVCHRMOTE<SDPQMIFAXNK<LSCPVJVXELH>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x2914FB0", Offset = "0x2913FB0", VA = "0x182914FB0")]
		public static (Id32<IPPVCHRMOTE<OEBZQFUZUXL>>, Id32<IPPVCHRMOTE<BVYDAJBFASE>>, Id32<IPPVCHRMOTE<SQTEKUFGHFF>>) KTJWZSIDAIW(this UnsafeList<byte> a, [Optional] int? b, [Optional] Id32<SQTEKUFGHFF>? c)
		{
			return default((Id32<IPPVCHRMOTE<OEBZQFUZUXL>>, Id32<IPPVCHRMOTE<BVYDAJBFASE>>, Id32<IPPVCHRMOTE<SQTEKUFGHFF>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x2915160", Offset = "0x2914160", VA = "0x182915160")]
		public static (Id32<IPPVCHRMOTE<OEBZQFUZUXL>>, Id32<IPPVCHRMOTE<BVYDAJBFASE>>, Id32<IPPVCHRMOTE<SDPQMIFAXNK<SQTEKUFGHFF>>>) KUUTGNRKOKH(this UnsafeList<byte> a, [Optional] int? b, [Optional] Id32<SDPQMIFAXNK<SQTEKUFGHFF>>? c)
		{
			return default((Id32<IPPVCHRMOTE<OEBZQFUZUXL>>, Id32<IPPVCHRMOTE<BVYDAJBFASE>>, Id32<IPPVCHRMOTE<SDPQMIFAXNK<SQTEKUFGHFF>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x37CE7E0", Offset = "0x37CD7E0", VA = "0x1837CE7E0")]
		public static (Id32<IPPVCHRMOTE<OEBZQFUZUXL>>, Id32<IPPVCHRMOTE<WNOXGYXOQBA>>, Id32<IPPVCHRMOTE<BVYDAJBFASE>>, Id32<IPPVCHRMOTE<a>>) CKUSVHISQWN<a>(this UnsafeList<byte> a, [Optional] Id32<WNOXGYXOQBA>? b, [Optional][In] ReadOnlySpan<byte> data)
		{
			return default((Id32<IPPVCHRMOTE<OEBZQFUZUXL>>, Id32<IPPVCHRMOTE<WNOXGYXOQBA>>, Id32<IPPVCHRMOTE<BVYDAJBFASE>>, Id32<IPPVCHRMOTE<a>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x29159B0", Offset = "0x29149B0", VA = "0x1829159B0")]
		public static (Id32<IPPVCHRMOTE<OEBZQFUZUXL>>, Id32<IPPVCHRMOTE<BVYDAJBFASE>>, Id32<IPPVCHRMOTE<SDPQMIFAXNK<BVYDAJBFASE>>>) NCCFFXJXHVT(this UnsafeList<byte> a, int b, [Optional] Id32<SDPQMIFAXNK<BVYDAJBFASE>>? c)
		{
			return default((Id32<IPPVCHRMOTE<OEBZQFUZUXL>>, Id32<IPPVCHRMOTE<BVYDAJBFASE>>, Id32<IPPVCHRMOTE<SDPQMIFAXNK<BVYDAJBFASE>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x2915380", Offset = "0x2914380", VA = "0x182915380")]
		public static (Id32<IPPVCHRMOTE<OEBZQFUZUXL>>, Id32<IPPVCHRMOTE<SDPQMIFAXNK<BVYDAJBFASE>>>, Id32<IPPVCHRMOTE<SDPQMIFAXNK<BVYDAJBFASE>>>) LZLPYLEZIQG(this UnsafeList<byte> a, [Optional] Id32<SDPQMIFAXNK<BVYDAJBFASE>>? b, [Optional] Id32<SDPQMIFAXNK<BVYDAJBFASE>>? c)
		{
			return default((Id32<IPPVCHRMOTE<OEBZQFUZUXL>>, Id32<IPPVCHRMOTE<SDPQMIFAXNK<BVYDAJBFASE>>>, Id32<IPPVCHRMOTE<SDPQMIFAXNK<BVYDAJBFASE>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x37CEE50", Offset = "0x37CDE50", VA = "0x1837CEE50")]
		public static (Id32<IPPVCHRMOTE<OEBZQFUZUXL>>, Id32<IPPVCHRMOTE<SDPQMIFAXNK<b>>>, Id32<IPPVCHRMOTE<BVYDAJBFASE>>, Id32<IPPVCHRMOTE<b>>) LGMILBABYKL<b>(this UnsafeList<byte> a, [Optional] Id32<SDPQMIFAXNK<b>>? b, [Optional] int? c, [Optional][In] ReadOnlySpan<byte> from)
		{
			return default((Id32<IPPVCHRMOTE<OEBZQFUZUXL>>, Id32<IPPVCHRMOTE<SDPQMIFAXNK<b>>>, Id32<IPPVCHRMOTE<BVYDAJBFASE>>, Id32<IPPVCHRMOTE<b>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x37CEB20", Offset = "0x37CDB20", VA = "0x1837CEB20")]
		public static (Id32<IPPVCHRMOTE<OEBZQFUZUXL>>, Id32<IPPVCHRMOTE<SDPQMIFAXNK<c>>>, Id32<IPPVCHRMOTE<SDPQMIFAXNK<c>>>, Id32<IPPVCHRMOTE<BVYDAJBFASE>>) JVRVBXKJQVK<c>(this UnsafeList<byte> a, [Optional] Id32<SDPQMIFAXNK<c>>? b, [Optional] Id32<SDPQMIFAXNK<c>>? c, [Optional] int? d)
		{
			return default((Id32<IPPVCHRMOTE<OEBZQFUZUXL>>, Id32<IPPVCHRMOTE<SDPQMIFAXNK<c>>>, Id32<IPPVCHRMOTE<SDPQMIFAXNK<c>>>, Id32<IPPVCHRMOTE<BVYDAJBFASE>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x2913B80", Offset = "0x2912B80", VA = "0x182913B80")]
		public static (Id32<IPPVCHRMOTE<OEBZQFUZUXL>>, Id32<IPPVCHRMOTE<PQJHRGFBYRH>>, Id32<IPPVCHRMOTE<PQJHRGFBYRH>>, Id32<IPPVCHRMOTE<SDPQMIFAXNK<PQJHRGFBYRH>>>) GXDWKRFWKSL(this UnsafeList<byte> a, float b, float c, [Optional] Id32<SDPQMIFAXNK<PQJHRGFBYRH>>? d)
		{
			return default((Id32<IPPVCHRMOTE<OEBZQFUZUXL>>, Id32<IPPVCHRMOTE<PQJHRGFBYRH>>, Id32<IPPVCHRMOTE<PQJHRGFBYRH>>, Id32<IPPVCHRMOTE<SDPQMIFAXNK<PQJHRGFBYRH>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x2917C10", Offset = "0x2916C10", VA = "0x182917C10")]
		public static (Id32<IPPVCHRMOTE<OEBZQFUZUXL>>, Id32<IPPVCHRMOTE<PQJHRGFBYRH>>, Id32<IPPVCHRMOTE<SDPQMIFAXNK<PQJHRGFBYRH>>>, Id32<IPPVCHRMOTE<SDPQMIFAXNK<PQJHRGFBYRH>>>) ZRBHABJTPLW(this UnsafeList<byte> a, float b, [Optional] Id32<SDPQMIFAXNK<PQJHRGFBYRH>>? c, [Optional] Id32<SDPQMIFAXNK<PQJHRGFBYRH>>? d)
		{
			return default((Id32<IPPVCHRMOTE<OEBZQFUZUXL>>, Id32<IPPVCHRMOTE<PQJHRGFBYRH>>, Id32<IPPVCHRMOTE<SDPQMIFAXNK<PQJHRGFBYRH>>>, Id32<IPPVCHRMOTE<SDPQMIFAXNK<PQJHRGFBYRH>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x2914550", Offset = "0x2913550", VA = "0x182914550")]
		public static (Id32<IPPVCHRMOTE<OEBZQFUZUXL>>, Id32<IPPVCHRMOTE<SDPQMIFAXNK<PQJHRGFBYRH>>>, Id32<IPPVCHRMOTE<SDPQMIFAXNK<PQJHRGFBYRH>>>, Id32<IPPVCHRMOTE<SDPQMIFAXNK<PQJHRGFBYRH>>>) JDJNNVOSXCV(this UnsafeList<byte> a, [Optional] Id32<SDPQMIFAXNK<PQJHRGFBYRH>>? b, [Optional] Id32<SDPQMIFAXNK<PQJHRGFBYRH>>? c, [Optional] Id32<SDPQMIFAXNK<PQJHRGFBYRH>>? d)
		{
			return default((Id32<IPPVCHRMOTE<OEBZQFUZUXL>>, Id32<IPPVCHRMOTE<SDPQMIFAXNK<PQJHRGFBYRH>>>, Id32<IPPVCHRMOTE<SDPQMIFAXNK<PQJHRGFBYRH>>>, Id32<IPPVCHRMOTE<SDPQMIFAXNK<PQJHRGFBYRH>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x2916970", Offset = "0x2915970", VA = "0x182916970")]
		public static (Id32<IPPVCHRMOTE<OEBZQFUZUXL>>, Id32<IPPVCHRMOTE<BVYDAJBFASE>>, Id32<IPPVCHRMOTE<BVYDAJBFASE>>, Id32<IPPVCHRMOTE<SDPQMIFAXNK<BVYDAJBFASE>>>) SSHTSJQMWSB(this UnsafeList<byte> a, int b, int c, [Optional] Id32<SDPQMIFAXNK<BVYDAJBFASE>>? d)
		{
			return default((Id32<IPPVCHRMOTE<OEBZQFUZUXL>>, Id32<IPPVCHRMOTE<BVYDAJBFASE>>, Id32<IPPVCHRMOTE<BVYDAJBFASE>>, Id32<IPPVCHRMOTE<SDPQMIFAXNK<BVYDAJBFASE>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x29148F0", Offset = "0x29138F0", VA = "0x1829148F0")]
		public static (Id32<IPPVCHRMOTE<OEBZQFUZUXL>>, Id32<IPPVCHRMOTE<BVYDAJBFASE>>, Id32<IPPVCHRMOTE<SDPQMIFAXNK<BVYDAJBFASE>>>, Id32<IPPVCHRMOTE<SDPQMIFAXNK<BVYDAJBFASE>>>) JYTPFFPPERA(this UnsafeList<byte> a, int b, [Optional] Id32<SDPQMIFAXNK<BVYDAJBFASE>>? c, [Optional] Id32<SDPQMIFAXNK<BVYDAJBFASE>>? d)
		{
			return default((Id32<IPPVCHRMOTE<OEBZQFUZUXL>>, Id32<IPPVCHRMOTE<BVYDAJBFASE>>, Id32<IPPVCHRMOTE<SDPQMIFAXNK<BVYDAJBFASE>>>, Id32<IPPVCHRMOTE<SDPQMIFAXNK<BVYDAJBFASE>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x2912AE0", Offset = "0x2911AE0", VA = "0x182912AE0")]
		public static (Id32<IPPVCHRMOTE<OEBZQFUZUXL>>, Id32<IPPVCHRMOTE<SDPQMIFAXNK<BVYDAJBFASE>>>, Id32<IPPVCHRMOTE<SDPQMIFAXNK<BVYDAJBFASE>>>, Id32<IPPVCHRMOTE<SDPQMIFAXNK<BVYDAJBFASE>>>) BDTIVVSSQZF(this UnsafeList<byte> a, [Optional] Id32<SDPQMIFAXNK<BVYDAJBFASE>>? b, [Optional] Id32<SDPQMIFAXNK<BVYDAJBFASE>>? c, [Optional] Id32<SDPQMIFAXNK<BVYDAJBFASE>>? d)
		{
			return default((Id32<IPPVCHRMOTE<OEBZQFUZUXL>>, Id32<IPPVCHRMOTE<SDPQMIFAXNK<BVYDAJBFASE>>>, Id32<IPPVCHRMOTE<SDPQMIFAXNK<BVYDAJBFASE>>>, Id32<IPPVCHRMOTE<SDPQMIFAXNK<BVYDAJBFASE>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x29155B0", Offset = "0x29145B0", VA = "0x1829155B0")]
		public static (Id32<IPPVCHRMOTE<OEBZQFUZUXL>>, Id32<IPPVCHRMOTE<BVYDAJBFASE>>, Id32<IPPVCHRMOTE<BVYDAJBFASE>>, Id32<IPPVCHRMOTE<SDPQMIFAXNK<BVYDAJBFASE>>>) MGCIZWHXUPE(this UnsafeList<byte> a, int b, int c, [Optional] Id32<SDPQMIFAXNK<BVYDAJBFASE>>? d)
		{
			return default((Id32<IPPVCHRMOTE<OEBZQFUZUXL>>, Id32<IPPVCHRMOTE<BVYDAJBFASE>>, Id32<IPPVCHRMOTE<BVYDAJBFASE>>, Id32<IPPVCHRMOTE<SDPQMIFAXNK<BVYDAJBFASE>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x2915AE0", Offset = "0x2914AE0", VA = "0x182915AE0")]
		public static (Id32<IPPVCHRMOTE<OEBZQFUZUXL>>, Id32<IPPVCHRMOTE<BVYDAJBFASE>>, Id32<IPPVCHRMOTE<SDPQMIFAXNK<BVYDAJBFASE>>>, Id32<IPPVCHRMOTE<SDPQMIFAXNK<BVYDAJBFASE>>>) NZXBVTNAJUB(this UnsafeList<byte> a, int b, [Optional] Id32<SDPQMIFAXNK<BVYDAJBFASE>>? c, [Optional] Id32<SDPQMIFAXNK<BVYDAJBFASE>>? d)
		{
			return default((Id32<IPPVCHRMOTE<OEBZQFUZUXL>>, Id32<IPPVCHRMOTE<BVYDAJBFASE>>, Id32<IPPVCHRMOTE<SDPQMIFAXNK<BVYDAJBFASE>>>, Id32<IPPVCHRMOTE<SDPQMIFAXNK<BVYDAJBFASE>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x2914D10", Offset = "0x2913D10", VA = "0x182914D10")]
		public static (Id32<IPPVCHRMOTE<OEBZQFUZUXL>>, Id32<IPPVCHRMOTE<SDPQMIFAXNK<BVYDAJBFASE>>>, Id32<IPPVCHRMOTE<SDPQMIFAXNK<BVYDAJBFASE>>>, Id32<IPPVCHRMOTE<SDPQMIFAXNK<BVYDAJBFASE>>>) KQVCPNVBJJO(this UnsafeList<byte> a, [Optional] Id32<SDPQMIFAXNK<BVYDAJBFASE>>? b, [Optional] Id32<SDPQMIFAXNK<BVYDAJBFASE>>? c, [Optional] Id32<SDPQMIFAXNK<BVYDAJBFASE>>? d)
		{
			return default((Id32<IPPVCHRMOTE<OEBZQFUZUXL>>, Id32<IPPVCHRMOTE<SDPQMIFAXNK<BVYDAJBFASE>>>, Id32<IPPVCHRMOTE<SDPQMIFAXNK<BVYDAJBFASE>>>, Id32<IPPVCHRMOTE<SDPQMIFAXNK<BVYDAJBFASE>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x2914460", Offset = "0x2913460", VA = "0x182914460")]
		public static (Id32<IPPVCHRMOTE<OEBZQFUZUXL>>, Id32<IPPVCHRMOTE<IPPVCHRMOTE<OEBZQFUZUXL>>>) JBVWLRWRLJD(this UnsafeList<byte> a, [Optional] Id32<IPPVCHRMOTE<OEBZQFUZUXL>>? b)
		{
			return default((Id32<IPPVCHRMOTE<OEBZQFUZUXL>>, Id32<IPPVCHRMOTE<IPPVCHRMOTE<OEBZQFUZUXL>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x2914A40", Offset = "0x2913A40", VA = "0x182914A40")]
		public static (Id32<IPPVCHRMOTE<OEBZQFUZUXL>>, Id32<IPPVCHRMOTE<PQJHRGFBYRH>>, Id32<IPPVCHRMOTE<PQJHRGFBYRH>>, Id32<IPPVCHRMOTE<SDPQMIFAXNK<BVYDAJBFASE>>>) KADKIRUTTFX(this UnsafeList<byte> a, float b, float c, [Optional] Id32<SDPQMIFAXNK<BVYDAJBFASE>>? d)
		{
			return default((Id32<IPPVCHRMOTE<OEBZQFUZUXL>>, Id32<IPPVCHRMOTE<PQJHRGFBYRH>>, Id32<IPPVCHRMOTE<PQJHRGFBYRH>>, Id32<IPPVCHRMOTE<SDPQMIFAXNK<BVYDAJBFASE>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x29124E0", Offset = "0x29114E0", VA = "0x1829124E0")]
		public static (Id32<IPPVCHRMOTE<OEBZQFUZUXL>>, Id32<IPPVCHRMOTE<PQJHRGFBYRH>>, Id32<IPPVCHRMOTE<SDPQMIFAXNK<PQJHRGFBYRH>>>, Id32<IPPVCHRMOTE<SDPQMIFAXNK<BVYDAJBFASE>>>) ALCSBRMVKYC(this UnsafeList<byte> a, float b, [Optional] Id32<SDPQMIFAXNK<PQJHRGFBYRH>>? c, [Optional] Id32<SDPQMIFAXNK<BVYDAJBFASE>>? d)
		{
			return default((Id32<IPPVCHRMOTE<OEBZQFUZUXL>>, Id32<IPPVCHRMOTE<PQJHRGFBYRH>>, Id32<IPPVCHRMOTE<SDPQMIFAXNK<PQJHRGFBYRH>>>, Id32<IPPVCHRMOTE<SDPQMIFAXNK<BVYDAJBFASE>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x2916B50", Offset = "0x2915B50", VA = "0x182916B50")]
		public static (Id32<IPPVCHRMOTE<OEBZQFUZUXL>>, Id32<IPPVCHRMOTE<SDPQMIFAXNK<PQJHRGFBYRH>>>, Id32<IPPVCHRMOTE<SDPQMIFAXNK<PQJHRGFBYRH>>>, Id32<IPPVCHRMOTE<SDPQMIFAXNK<BVYDAJBFASE>>>) TGUTDQVMCDJ(this UnsafeList<byte> a, [Optional] Id32<SDPQMIFAXNK<PQJHRGFBYRH>>? b, [Optional] Id32<SDPQMIFAXNK<PQJHRGFBYRH>>? c, [Optional] Id32<SDPQMIFAXNK<BVYDAJBFASE>>? d)
		{
			return default((Id32<IPPVCHRMOTE<OEBZQFUZUXL>>, Id32<IPPVCHRMOTE<SDPQMIFAXNK<PQJHRGFBYRH>>>, Id32<IPPVCHRMOTE<SDPQMIFAXNK<PQJHRGFBYRH>>>, Id32<IPPVCHRMOTE<SDPQMIFAXNK<BVYDAJBFASE>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x2915C30", Offset = "0x2914C30", VA = "0x182915C30")]
		public static (Id32<IPPVCHRMOTE<OEBZQFUZUXL>>, Id32<IPPVCHRMOTE<BVYDAJBFASE>>, Id32<IPPVCHRMOTE<BVYDAJBFASE>>, Id32<IPPVCHRMOTE<SDPQMIFAXNK<BVYDAJBFASE>>>) OHMYEOOXAIQ(this UnsafeList<byte> a, int b, int c, [Optional] Id32<SDPQMIFAXNK<BVYDAJBFASE>>? d)
		{
			return default((Id32<IPPVCHRMOTE<OEBZQFUZUXL>>, Id32<IPPVCHRMOTE<BVYDAJBFASE>>, Id32<IPPVCHRMOTE<BVYDAJBFASE>>, Id32<IPPVCHRMOTE<SDPQMIFAXNK<BVYDAJBFASE>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x2914BC0", Offset = "0x2913BC0", VA = "0x182914BC0")]
		public static (Id32<IPPVCHRMOTE<OEBZQFUZUXL>>, Id32<IPPVCHRMOTE<BVYDAJBFASE>>, Id32<IPPVCHRMOTE<SDPQMIFAXNK<BVYDAJBFASE>>>, Id32<IPPVCHRMOTE<SDPQMIFAXNK<BVYDAJBFASE>>>) KKXPXVKDZMD(this UnsafeList<byte> a, int b, [Optional] Id32<SDPQMIFAXNK<BVYDAJBFASE>>? c, [Optional] Id32<SDPQMIFAXNK<BVYDAJBFASE>>? d)
		{
			return default((Id32<IPPVCHRMOTE<OEBZQFUZUXL>>, Id32<IPPVCHRMOTE<BVYDAJBFASE>>, Id32<IPPVCHRMOTE<SDPQMIFAXNK<BVYDAJBFASE>>>, Id32<IPPVCHRMOTE<SDPQMIFAXNK<BVYDAJBFASE>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x2912FD0", Offset = "0x2911FD0", VA = "0x182912FD0")]
		public static (Id32<IPPVCHRMOTE<OEBZQFUZUXL>>, Id32<IPPVCHRMOTE<SDPQMIFAXNK<BVYDAJBFASE>>>, Id32<IPPVCHRMOTE<SDPQMIFAXNK<BVYDAJBFASE>>>, Id32<IPPVCHRMOTE<SDPQMIFAXNK<BVYDAJBFASE>>>) DKVDZWWTMIC(this UnsafeList<byte> a, [Optional] Id32<SDPQMIFAXNK<BVYDAJBFASE>>? b, [Optional] Id32<SDPQMIFAXNK<BVYDAJBFASE>>? c, [Optional] Id32<SDPQMIFAXNK<BVYDAJBFASE>>? d)
		{
			return default((Id32<IPPVCHRMOTE<OEBZQFUZUXL>>, Id32<IPPVCHRMOTE<SDPQMIFAXNK<BVYDAJBFASE>>>, Id32<IPPVCHRMOTE<SDPQMIFAXNK<BVYDAJBFASE>>>, Id32<IPPVCHRMOTE<SDPQMIFAXNK<BVYDAJBFASE>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x29130F0", Offset = "0x29120F0", VA = "0x1829130F0")]
		public static (Id32<IPPVCHRMOTE<OEBZQFUZUXL>>, Id32<IPPVCHRMOTE<PQJHRGFBYRH>>, Id32<IPPVCHRMOTE<PQJHRGFBYRH>>, Id32<IPPVCHRMOTE<SDPQMIFAXNK<BVYDAJBFASE>>>) DTDVVPEDTQU(this UnsafeList<byte> a, float b, float c, [Optional] Id32<SDPQMIFAXNK<BVYDAJBFASE>>? d)
		{
			return default((Id32<IPPVCHRMOTE<OEBZQFUZUXL>>, Id32<IPPVCHRMOTE<PQJHRGFBYRH>>, Id32<IPPVCHRMOTE<PQJHRGFBYRH>>, Id32<IPPVCHRMOTE<SDPQMIFAXNK<BVYDAJBFASE>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x2913660", Offset = "0x2912660", VA = "0x182913660")]
		public static (Id32<IPPVCHRMOTE<OEBZQFUZUXL>>, Id32<IPPVCHRMOTE<PQJHRGFBYRH>>, Id32<IPPVCHRMOTE<SDPQMIFAXNK<PQJHRGFBYRH>>>, Id32<IPPVCHRMOTE<SDPQMIFAXNK<BVYDAJBFASE>>>) FMPAVYYTHLF(this UnsafeList<byte> a, float b, [Optional] Id32<SDPQMIFAXNK<PQJHRGFBYRH>>? c, [Optional] Id32<SDPQMIFAXNK<BVYDAJBFASE>>? d)
		{
			return default((Id32<IPPVCHRMOTE<OEBZQFUZUXL>>, Id32<IPPVCHRMOTE<PQJHRGFBYRH>>, Id32<IPPVCHRMOTE<SDPQMIFAXNK<PQJHRGFBYRH>>>, Id32<IPPVCHRMOTE<SDPQMIFAXNK<BVYDAJBFASE>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x2913530", Offset = "0x2912530", VA = "0x182913530")]
		public static (Id32<IPPVCHRMOTE<OEBZQFUZUXL>>, Id32<IPPVCHRMOTE<SDPQMIFAXNK<PQJHRGFBYRH>>>, Id32<IPPVCHRMOTE<SDPQMIFAXNK<PQJHRGFBYRH>>>, Id32<IPPVCHRMOTE<SDPQMIFAXNK<BVYDAJBFASE>>>) FIYYMBSOCYS(this UnsafeList<byte> a, [Optional] Id32<SDPQMIFAXNK<PQJHRGFBYRH>>? b, [Optional] Id32<SDPQMIFAXNK<PQJHRGFBYRH>>? c, [Optional] Id32<SDPQMIFAXNK<BVYDAJBFASE>>? d)
		{
			return default((Id32<IPPVCHRMOTE<OEBZQFUZUXL>>, Id32<IPPVCHRMOTE<SDPQMIFAXNK<PQJHRGFBYRH>>>, Id32<IPPVCHRMOTE<SDPQMIFAXNK<PQJHRGFBYRH>>>, Id32<IPPVCHRMOTE<SDPQMIFAXNK<BVYDAJBFASE>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x29133D0", Offset = "0x29123D0", VA = "0x1829133D0")]
		public static (Id32<IPPVCHRMOTE<OEBZQFUZUXL>>, Id32<IPPVCHRMOTE<BVYDAJBFASE>>, Id32<IPPVCHRMOTE<BVYDAJBFASE>>, Id32<IPPVCHRMOTE<SDPQMIFAXNK<BVYDAJBFASE>>>) FHYYTDJJPCN(this UnsafeList<byte> a, int b, int c, [Optional] Id32<SDPQMIFAXNK<BVYDAJBFASE>>? d)
		{
			return default((Id32<IPPVCHRMOTE<OEBZQFUZUXL>>, Id32<IPPVCHRMOTE<BVYDAJBFASE>>, Id32<IPPVCHRMOTE<BVYDAJBFASE>>, Id32<IPPVCHRMOTE<SDPQMIFAXNK<BVYDAJBFASE>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x2915710", Offset = "0x2914710", VA = "0x182915710")]
		public static (Id32<IPPVCHRMOTE<OEBZQFUZUXL>>, Id32<IPPVCHRMOTE<BVYDAJBFASE>>, Id32<IPPVCHRMOTE<SDPQMIFAXNK<BVYDAJBFASE>>>, Id32<IPPVCHRMOTE<SDPQMIFAXNK<BVYDAJBFASE>>>) MVHTOQWDMJY(this UnsafeList<byte> a, int b, [Optional] Id32<SDPQMIFAXNK<BVYDAJBFASE>>? c, [Optional] Id32<SDPQMIFAXNK<BVYDAJBFASE>>? d)
		{
			return default((Id32<IPPVCHRMOTE<OEBZQFUZUXL>>, Id32<IPPVCHRMOTE<BVYDAJBFASE>>, Id32<IPPVCHRMOTE<SDPQMIFAXNK<BVYDAJBFASE>>>, Id32<IPPVCHRMOTE<SDPQMIFAXNK<BVYDAJBFASE>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x29129C0", Offset = "0x29119C0", VA = "0x1829129C0")]
		public static (Id32<IPPVCHRMOTE<OEBZQFUZUXL>>, Id32<IPPVCHRMOTE<SDPQMIFAXNK<BVYDAJBFASE>>>, Id32<IPPVCHRMOTE<SDPQMIFAXNK<BVYDAJBFASE>>>, Id32<IPPVCHRMOTE<SDPQMIFAXNK<BVYDAJBFASE>>>) AYGWLUJPQPZ(this UnsafeList<byte> a, [Optional] Id32<SDPQMIFAXNK<BVYDAJBFASE>>? b, [Optional] Id32<SDPQMIFAXNK<BVYDAJBFASE>>? c, [Optional] Id32<SDPQMIFAXNK<BVYDAJBFASE>>? d)
		{
			return default((Id32<IPPVCHRMOTE<OEBZQFUZUXL>>, Id32<IPPVCHRMOTE<SDPQMIFAXNK<BVYDAJBFASE>>>, Id32<IPPVCHRMOTE<SDPQMIFAXNK<BVYDAJBFASE>>>, Id32<IPPVCHRMOTE<SDPQMIFAXNK<BVYDAJBFASE>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x2916150", Offset = "0x2915150", VA = "0x182916150")]
		public static (Id32<IPPVCHRMOTE<OEBZQFUZUXL>>, Id32<IPPVCHRMOTE<PQJHRGFBYRH>>, Id32<IPPVCHRMOTE<PQJHRGFBYRH>>, Id32<IPPVCHRMOTE<SDPQMIFAXNK<BVYDAJBFASE>>>) PLEFCPJQGOI(this UnsafeList<byte> a, float b, float c, [Optional] Id32<SDPQMIFAXNK<BVYDAJBFASE>>? d)
		{
			return default((Id32<IPPVCHRMOTE<OEBZQFUZUXL>>, Id32<IPPVCHRMOTE<PQJHRGFBYRH>>, Id32<IPPVCHRMOTE<PQJHRGFBYRH>>, Id32<IPPVCHRMOTE<SDPQMIFAXNK<BVYDAJBFASE>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x2914670", Offset = "0x2913670", VA = "0x182914670")]
		public static (Id32<IPPVCHRMOTE<OEBZQFUZUXL>>, Id32<IPPVCHRMOTE<PQJHRGFBYRH>>, Id32<IPPVCHRMOTE<SDPQMIFAXNK<PQJHRGFBYRH>>>, Id32<IPPVCHRMOTE<SDPQMIFAXNK<BVYDAJBFASE>>>) JEVSJALNTLZ(this UnsafeList<byte> a, float b, [Optional] Id32<SDPQMIFAXNK<PQJHRGFBYRH>>? c, [Optional] Id32<SDPQMIFAXNK<BVYDAJBFASE>>? d)
		{
			return default((Id32<IPPVCHRMOTE<OEBZQFUZUXL>>, Id32<IPPVCHRMOTE<PQJHRGFBYRH>>, Id32<IPPVCHRMOTE<SDPQMIFAXNK<PQJHRGFBYRH>>>, Id32<IPPVCHRMOTE<SDPQMIFAXNK<BVYDAJBFASE>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x29172D0", Offset = "0x29162D0", VA = "0x1829172D0")]
		public static (Id32<IPPVCHRMOTE<OEBZQFUZUXL>>, Id32<IPPVCHRMOTE<SDPQMIFAXNK<PQJHRGFBYRH>>>, Id32<IPPVCHRMOTE<SDPQMIFAXNK<PQJHRGFBYRH>>>, Id32<IPPVCHRMOTE<SDPQMIFAXNK<BVYDAJBFASE>>>) VZGEMYGKDQC(this UnsafeList<byte> a, [Optional] Id32<SDPQMIFAXNK<PQJHRGFBYRH>>? b, [Optional] Id32<SDPQMIFAXNK<PQJHRGFBYRH>>? c, [Optional] Id32<SDPQMIFAXNK<BVYDAJBFASE>>? d)
		{
			return default((Id32<IPPVCHRMOTE<OEBZQFUZUXL>>, Id32<IPPVCHRMOTE<SDPQMIFAXNK<PQJHRGFBYRH>>>, Id32<IPPVCHRMOTE<SDPQMIFAXNK<PQJHRGFBYRH>>>, Id32<IPPVCHRMOTE<SDPQMIFAXNK<BVYDAJBFASE>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x2917AB0", Offset = "0x2916AB0", VA = "0x182917AB0")]
		public static (Id32<IPPVCHRMOTE<OEBZQFUZUXL>>, Id32<IPPVCHRMOTE<BVYDAJBFASE>>, Id32<IPPVCHRMOTE<BVYDAJBFASE>>, Id32<IPPVCHRMOTE<SDPQMIFAXNK<BVYDAJBFASE>>>) ZLSHLJNHYLL(this UnsafeList<byte> a, int b, int c, [Optional] Id32<SDPQMIFAXNK<BVYDAJBFASE>>? d)
		{
			return default((Id32<IPPVCHRMOTE<OEBZQFUZUXL>>, Id32<IPPVCHRMOTE<BVYDAJBFASE>>, Id32<IPPVCHRMOTE<BVYDAJBFASE>>, Id32<IPPVCHRMOTE<SDPQMIFAXNK<BVYDAJBFASE>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x2916450", Offset = "0x2915450", VA = "0x182916450")]
		public static (Id32<IPPVCHRMOTE<OEBZQFUZUXL>>, Id32<IPPVCHRMOTE<BVYDAJBFASE>>, Id32<IPPVCHRMOTE<SDPQMIFAXNK<BVYDAJBFASE>>>, Id32<IPPVCHRMOTE<SDPQMIFAXNK<BVYDAJBFASE>>>) PVHVNDQESKK(this UnsafeList<byte> a, int b, [Optional] Id32<SDPQMIFAXNK<BVYDAJBFASE>>? c, [Optional] Id32<SDPQMIFAXNK<BVYDAJBFASE>>? d)
		{
			return default((Id32<IPPVCHRMOTE<OEBZQFUZUXL>>, Id32<IPPVCHRMOTE<BVYDAJBFASE>>, Id32<IPPVCHRMOTE<SDPQMIFAXNK<BVYDAJBFASE>>>, Id32<IPPVCHRMOTE<SDPQMIFAXNK<BVYDAJBFASE>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x29171B0", Offset = "0x29161B0", VA = "0x1829171B0")]
		public static (Id32<IPPVCHRMOTE<OEBZQFUZUXL>>, Id32<IPPVCHRMOTE<SDPQMIFAXNK<BVYDAJBFASE>>>, Id32<IPPVCHRMOTE<SDPQMIFAXNK<BVYDAJBFASE>>>, Id32<IPPVCHRMOTE<SDPQMIFAXNK<BVYDAJBFASE>>>) VXHAFJEBORZ(this UnsafeList<byte> a, [Optional] Id32<SDPQMIFAXNK<BVYDAJBFASE>>? b, [Optional] Id32<SDPQMIFAXNK<BVYDAJBFASE>>? c, [Optional] Id32<SDPQMIFAXNK<BVYDAJBFASE>>? d)
		{
			return default((Id32<IPPVCHRMOTE<OEBZQFUZUXL>>, Id32<IPPVCHRMOTE<SDPQMIFAXNK<BVYDAJBFASE>>>, Id32<IPPVCHRMOTE<SDPQMIFAXNK<BVYDAJBFASE>>>, Id32<IPPVCHRMOTE<SDPQMIFAXNK<BVYDAJBFASE>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x29162D0", Offset = "0x29152D0", VA = "0x1829162D0")]
		public static (Id32<IPPVCHRMOTE<OEBZQFUZUXL>>, Id32<IPPVCHRMOTE<PQJHRGFBYRH>>, Id32<IPPVCHRMOTE<PQJHRGFBYRH>>, Id32<IPPVCHRMOTE<SDPQMIFAXNK<BVYDAJBFASE>>>) PRTWRZHJIRZ(this UnsafeList<byte> a, float b, float c, [Optional] Id32<SDPQMIFAXNK<BVYDAJBFASE>>? d)
		{
			return default((Id32<IPPVCHRMOTE<OEBZQFUZUXL>>, Id32<IPPVCHRMOTE<PQJHRGFBYRH>>, Id32<IPPVCHRMOTE<PQJHRGFBYRH>>, Id32<IPPVCHRMOTE<SDPQMIFAXNK<BVYDAJBFASE>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x29141E0", Offset = "0x29131E0", VA = "0x1829141E0")]
		public static (Id32<IPPVCHRMOTE<OEBZQFUZUXL>>, Id32<IPPVCHRMOTE<PQJHRGFBYRH>>, Id32<IPPVCHRMOTE<SDPQMIFAXNK<PQJHRGFBYRH>>>, Id32<IPPVCHRMOTE<SDPQMIFAXNK<BVYDAJBFASE>>>) IHDJGQZWYMU(this UnsafeList<byte> a, float b, [Optional] Id32<SDPQMIFAXNK<PQJHRGFBYRH>>? c, [Optional] Id32<SDPQMIFAXNK<BVYDAJBFASE>>? d)
		{
			return default((Id32<IPPVCHRMOTE<OEBZQFUZUXL>>, Id32<IPPVCHRMOTE<PQJHRGFBYRH>>, Id32<IPPVCHRMOTE<SDPQMIFAXNK<PQJHRGFBYRH>>>, Id32<IPPVCHRMOTE<SDPQMIFAXNK<BVYDAJBFASE>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x2916840", Offset = "0x2915840", VA = "0x182916840")]
		public static (Id32<IPPVCHRMOTE<OEBZQFUZUXL>>, Id32<IPPVCHRMOTE<SDPQMIFAXNK<PQJHRGFBYRH>>>, Id32<IPPVCHRMOTE<SDPQMIFAXNK<PQJHRGFBYRH>>>, Id32<IPPVCHRMOTE<SDPQMIFAXNK<BVYDAJBFASE>>>) SJTPTWKCACR(this UnsafeList<byte> a, [Optional] Id32<SDPQMIFAXNK<PQJHRGFBYRH>>? b, [Optional] Id32<SDPQMIFAXNK<PQJHRGFBYRH>>? c, [Optional] Id32<SDPQMIFAXNK<BVYDAJBFASE>>? d)
		{
			return default((Id32<IPPVCHRMOTE<OEBZQFUZUXL>>, Id32<IPPVCHRMOTE<SDPQMIFAXNK<PQJHRGFBYRH>>>, Id32<IPPVCHRMOTE<SDPQMIFAXNK<PQJHRGFBYRH>>>, Id32<IPPVCHRMOTE<SDPQMIFAXNK<BVYDAJBFASE>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x2917050", Offset = "0x2916050", VA = "0x182917050")]
		public static (Id32<IPPVCHRMOTE<OEBZQFUZUXL>>, Id32<IPPVCHRMOTE<BVYDAJBFASE>>, Id32<IPPVCHRMOTE<BVYDAJBFASE>>, Id32<IPPVCHRMOTE<SDPQMIFAXNK<BVYDAJBFASE>>>) VUZEVFYGUGW(this UnsafeList<byte> a, int b, int c, [Optional] Id32<SDPQMIFAXNK<BVYDAJBFASE>>? d)
		{
			return default((Id32<IPPVCHRMOTE<OEBZQFUZUXL>>, Id32<IPPVCHRMOTE<BVYDAJBFASE>>, Id32<IPPVCHRMOTE<BVYDAJBFASE>>, Id32<IPPVCHRMOTE<SDPQMIFAXNK<BVYDAJBFASE>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x2913D00", Offset = "0x2912D00", VA = "0x182913D00")]
		public static (Id32<IPPVCHRMOTE<OEBZQFUZUXL>>, Id32<IPPVCHRMOTE<BVYDAJBFASE>>, Id32<IPPVCHRMOTE<SDPQMIFAXNK<BVYDAJBFASE>>>, Id32<IPPVCHRMOTE<SDPQMIFAXNK<BVYDAJBFASE>>>) HARMYVLOIQN(this UnsafeList<byte> a, int b, [Optional] Id32<SDPQMIFAXNK<BVYDAJBFASE>>? c, [Optional] Id32<SDPQMIFAXNK<BVYDAJBFASE>>? d)
		{
			return default((Id32<IPPVCHRMOTE<OEBZQFUZUXL>>, Id32<IPPVCHRMOTE<BVYDAJBFASE>>, Id32<IPPVCHRMOTE<SDPQMIFAXNK<BVYDAJBFASE>>>, Id32<IPPVCHRMOTE<SDPQMIFAXNK<BVYDAJBFASE>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x2913A60", Offset = "0x2912A60", VA = "0x182913A60")]
		public static (Id32<IPPVCHRMOTE<OEBZQFUZUXL>>, Id32<IPPVCHRMOTE<SDPQMIFAXNK<BVYDAJBFASE>>>, Id32<IPPVCHRMOTE<SDPQMIFAXNK<BVYDAJBFASE>>>, Id32<IPPVCHRMOTE<SDPQMIFAXNK<BVYDAJBFASE>>>) GTPSBYHOYOY(this UnsafeList<byte> a, [Optional] Id32<SDPQMIFAXNK<BVYDAJBFASE>>? b, [Optional] Id32<SDPQMIFAXNK<BVYDAJBFASE>>? c, [Optional] Id32<SDPQMIFAXNK<BVYDAJBFASE>>? d)
		{
			return default((Id32<IPPVCHRMOTE<OEBZQFUZUXL>>, Id32<IPPVCHRMOTE<SDPQMIFAXNK<BVYDAJBFASE>>>, Id32<IPPVCHRMOTE<SDPQMIFAXNK<BVYDAJBFASE>>>, Id32<IPPVCHRMOTE<SDPQMIFAXNK<BVYDAJBFASE>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x29165A0", Offset = "0x29155A0", VA = "0x1829165A0")]
		public static (Id32<IPPVCHRMOTE<OEBZQFUZUXL>>, Id32<IPPVCHRMOTE<PQJHRGFBYRH>>, Id32<IPPVCHRMOTE<PQJHRGFBYRH>>, Id32<IPPVCHRMOTE<SDPQMIFAXNK<PQJHRGFBYRH>>>) QJZWSCSQBTE(this UnsafeList<byte> a, float b, float c, [Optional] Id32<SDPQMIFAXNK<PQJHRGFBYRH>>? d)
		{
			return default((Id32<IPPVCHRMOTE<OEBZQFUZUXL>>, Id32<IPPVCHRMOTE<PQJHRGFBYRH>>, Id32<IPPVCHRMOTE<PQJHRGFBYRH>>, Id32<IPPVCHRMOTE<SDPQMIFAXNK<PQJHRGFBYRH>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x2916000", Offset = "0x2915000", VA = "0x182916000")]
		public static (Id32<IPPVCHRMOTE<OEBZQFUZUXL>>, Id32<IPPVCHRMOTE<PQJHRGFBYRH>>, Id32<IPPVCHRMOTE<SDPQMIFAXNK<PQJHRGFBYRH>>>, Id32<IPPVCHRMOTE<SDPQMIFAXNK<PQJHRGFBYRH>>>) OTTSCOAOGBP(this UnsafeList<byte> a, float b, [Optional] Id32<SDPQMIFAXNK<PQJHRGFBYRH>>? c, [Optional] Id32<SDPQMIFAXNK<PQJHRGFBYRH>>? d)
		{
			return default((Id32<IPPVCHRMOTE<OEBZQFUZUXL>>, Id32<IPPVCHRMOTE<PQJHRGFBYRH>>, Id32<IPPVCHRMOTE<SDPQMIFAXNK<PQJHRGFBYRH>>>, Id32<IPPVCHRMOTE<SDPQMIFAXNK<PQJHRGFBYRH>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x2915EE0", Offset = "0x2914EE0", VA = "0x182915EE0")]
		public static (Id32<IPPVCHRMOTE<OEBZQFUZUXL>>, Id32<IPPVCHRMOTE<SDPQMIFAXNK<PQJHRGFBYRH>>>, Id32<IPPVCHRMOTE<SDPQMIFAXNK<PQJHRGFBYRH>>>, Id32<IPPVCHRMOTE<SDPQMIFAXNK<PQJHRGFBYRH>>>) OMYCGHDTRGM(this UnsafeList<byte> a, [Optional] Id32<SDPQMIFAXNK<PQJHRGFBYRH>>? b, [Optional] Id32<SDPQMIFAXNK<PQJHRGFBYRH>>? c, [Optional] Id32<SDPQMIFAXNK<PQJHRGFBYRH>>? d)
		{
			return default((Id32<IPPVCHRMOTE<OEBZQFUZUXL>>, Id32<IPPVCHRMOTE<SDPQMIFAXNK<PQJHRGFBYRH>>>, Id32<IPPVCHRMOTE<SDPQMIFAXNK<PQJHRGFBYRH>>>, Id32<IPPVCHRMOTE<SDPQMIFAXNK<PQJHRGFBYRH>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x2913270", Offset = "0x2912270", VA = "0x182913270")]
		public static (Id32<IPPVCHRMOTE<OEBZQFUZUXL>>, Id32<IPPVCHRMOTE<BVYDAJBFASE>>, Id32<IPPVCHRMOTE<BVYDAJBFASE>>, Id32<IPPVCHRMOTE<SDPQMIFAXNK<BVYDAJBFASE>>>) EPLNYIRQLZO(this UnsafeList<byte> a, int b, int c, [Optional] Id32<SDPQMIFAXNK<BVYDAJBFASE>>? d)
		{
			return default((Id32<IPPVCHRMOTE<OEBZQFUZUXL>>, Id32<IPPVCHRMOTE<BVYDAJBFASE>>, Id32<IPPVCHRMOTE<BVYDAJBFASE>>, Id32<IPPVCHRMOTE<SDPQMIFAXNK<BVYDAJBFASE>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x2913E50", Offset = "0x2912E50", VA = "0x182913E50")]
		public static (Id32<IPPVCHRMOTE<OEBZQFUZUXL>>, Id32<IPPVCHRMOTE<BVYDAJBFASE>>, Id32<IPPVCHRMOTE<SDPQMIFAXNK<BVYDAJBFASE>>>, Id32<IPPVCHRMOTE<SDPQMIFAXNK<BVYDAJBFASE>>>) HROMKXKCHNF(this UnsafeList<byte> a, int b, [Optional] Id32<SDPQMIFAXNK<BVYDAJBFASE>>? c, [Optional] Id32<SDPQMIFAXNK<BVYDAJBFASE>>? d)
		{
			return default((Id32<IPPVCHRMOTE<OEBZQFUZUXL>>, Id32<IPPVCHRMOTE<BVYDAJBFASE>>, Id32<IPPVCHRMOTE<SDPQMIFAXNK<BVYDAJBFASE>>>, Id32<IPPVCHRMOTE<SDPQMIFAXNK<BVYDAJBFASE>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x2916720", Offset = "0x2915720", VA = "0x182916720")]
		public static (Id32<IPPVCHRMOTE<OEBZQFUZUXL>>, Id32<IPPVCHRMOTE<SDPQMIFAXNK<BVYDAJBFASE>>>, Id32<IPPVCHRMOTE<SDPQMIFAXNK<BVYDAJBFASE>>>, Id32<IPPVCHRMOTE<SDPQMIFAXNK<BVYDAJBFASE>>>) RJXHLFHXMQO(this UnsafeList<byte> a, [Optional] Id32<SDPQMIFAXNK<BVYDAJBFASE>>? b, [Optional] Id32<SDPQMIFAXNK<BVYDAJBFASE>>? c, [Optional] Id32<SDPQMIFAXNK<BVYDAJBFASE>>? d)
		{
			return default((Id32<IPPVCHRMOTE<OEBZQFUZUXL>>, Id32<IPPVCHRMOTE<SDPQMIFAXNK<BVYDAJBFASE>>>, Id32<IPPVCHRMOTE<SDPQMIFAXNK<BVYDAJBFASE>>>, Id32<IPPVCHRMOTE<SDPQMIFAXNK<BVYDAJBFASE>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x2912750", Offset = "0x2911750", VA = "0x182912750")]
		public static (Id32<IPPVCHRMOTE<OEBZQFUZUXL>>, Id32<IPPVCHRMOTE<BVYDAJBFASE>>, Id32<IPPVCHRMOTE<SDPQMIFAXNK<BVYDAJBFASE>>>) ARZLQDZOIUD(this UnsafeList<byte> a, [Optional] int? b, [Optional] Id32<SDPQMIFAXNK<BVYDAJBFASE>>? c)
		{
			return default((Id32<IPPVCHRMOTE<OEBZQFUZUXL>>, Id32<IPPVCHRMOTE<BVYDAJBFASE>>, Id32<IPPVCHRMOTE<SDPQMIFAXNK<BVYDAJBFASE>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x2912640", Offset = "0x2911640", VA = "0x182912640")]
		public static (Id32<IPPVCHRMOTE<OEBZQFUZUXL>>, Id32<IPPVCHRMOTE<SDPQMIFAXNK<BVYDAJBFASE>>>, Id32<IPPVCHRMOTE<SDPQMIFAXNK<BVYDAJBFASE>>>) AOXINCJRJIA(this UnsafeList<byte> a, [Optional] Id32<SDPQMIFAXNK<BVYDAJBFASE>>? b, [Optional] Id32<SDPQMIFAXNK<BVYDAJBFASE>>? c)
		{
			return default((Id32<IPPVCHRMOTE<OEBZQFUZUXL>>, Id32<IPPVCHRMOTE<SDPQMIFAXNK<BVYDAJBFASE>>>, Id32<IPPVCHRMOTE<SDPQMIFAXNK<BVYDAJBFASE>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x2916AD0", Offset = "0x2915AD0", VA = "0x182916AD0")]
		public static Id32<IPPVCHRMOTE<OEBZQFUZUXL>> STKYLPPLNIR(this UnsafeList<byte> a)
		{
			return default(Id32<IPPVCHRMOTE<OEBZQFUZUXL>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x29177D0", Offset = "0x29167D0", VA = "0x1829177D0")]
		public static (Id32<IPPVCHRMOTE<OEBZQFUZUXL>>, Id32<IPPVCHRMOTE<PQJHRGFBYRH>>, Id32<IPPVCHRMOTE<PQJHRGFBYRH>>, Id32<IPPVCHRMOTE<SDPQMIFAXNK<PQJHRGFBYRH>>>) YDNZBQUIOBI(this UnsafeList<byte> a, float b, float c, [Optional] Id32<SDPQMIFAXNK<PQJHRGFBYRH>>? d)
		{
			return default((Id32<IPPVCHRMOTE<OEBZQFUZUXL>>, Id32<IPPVCHRMOTE<PQJHRGFBYRH>>, Id32<IPPVCHRMOTE<PQJHRGFBYRH>>, Id32<IPPVCHRMOTE<SDPQMIFAXNK<PQJHRGFBYRH>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x2915D90", Offset = "0x2914D90", VA = "0x182915D90")]
		public static (Id32<IPPVCHRMOTE<OEBZQFUZUXL>>, Id32<IPPVCHRMOTE<PQJHRGFBYRH>>, Id32<IPPVCHRMOTE<SDPQMIFAXNK<PQJHRGFBYRH>>>, Id32<IPPVCHRMOTE<SDPQMIFAXNK<PQJHRGFBYRH>>>) OMNEUPUOJUZ(this UnsafeList<byte> a, float b, [Optional] Id32<SDPQMIFAXNK<PQJHRGFBYRH>>? c, [Optional] Id32<SDPQMIFAXNK<PQJHRGFBYRH>>? d)
		{
			return default((Id32<IPPVCHRMOTE<OEBZQFUZUXL>>, Id32<IPPVCHRMOTE<PQJHRGFBYRH>>, Id32<IPPVCHRMOTE<SDPQMIFAXNK<PQJHRGFBYRH>>>, Id32<IPPVCHRMOTE<SDPQMIFAXNK<PQJHRGFBYRH>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x2915490", Offset = "0x2914490", VA = "0x182915490")]
		public static (Id32<IPPVCHRMOTE<OEBZQFUZUXL>>, Id32<IPPVCHRMOTE<SDPQMIFAXNK<PQJHRGFBYRH>>>, Id32<IPPVCHRMOTE<SDPQMIFAXNK<PQJHRGFBYRH>>>, Id32<IPPVCHRMOTE<SDPQMIFAXNK<PQJHRGFBYRH>>>) MFXEJXNWZVS(this UnsafeList<byte> a, [Optional] Id32<SDPQMIFAXNK<PQJHRGFBYRH>>? b, [Optional] Id32<SDPQMIFAXNK<PQJHRGFBYRH>>? c, [Optional] Id32<SDPQMIFAXNK<PQJHRGFBYRH>>? d)
		{
			return default((Id32<IPPVCHRMOTE<OEBZQFUZUXL>>, Id32<IPPVCHRMOTE<SDPQMIFAXNK<PQJHRGFBYRH>>>, Id32<IPPVCHRMOTE<SDPQMIFAXNK<PQJHRGFBYRH>>>, Id32<IPPVCHRMOTE<SDPQMIFAXNK<PQJHRGFBYRH>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x2912860", Offset = "0x2911860", VA = "0x182912860")]
		public static (Id32<IPPVCHRMOTE<OEBZQFUZUXL>>, Id32<IPPVCHRMOTE<BVYDAJBFASE>>, Id32<IPPVCHRMOTE<BVYDAJBFASE>>, Id32<IPPVCHRMOTE<SDPQMIFAXNK<BVYDAJBFASE>>>) AXUXJTUKJBK(this UnsafeList<byte> a, int b, int c, [Optional] Id32<SDPQMIFAXNK<BVYDAJBFASE>>? d)
		{
			return default((Id32<IPPVCHRMOTE<OEBZQFUZUXL>>, Id32<IPPVCHRMOTE<BVYDAJBFASE>>, Id32<IPPVCHRMOTE<BVYDAJBFASE>>, Id32<IPPVCHRMOTE<SDPQMIFAXNK<BVYDAJBFASE>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x2916DE0", Offset = "0x2915DE0", VA = "0x182916DE0")]
		public static (Id32<IPPVCHRMOTE<OEBZQFUZUXL>>, Id32<IPPVCHRMOTE<BVYDAJBFASE>>, Id32<IPPVCHRMOTE<SDPQMIFAXNK<BVYDAJBFASE>>>, Id32<IPPVCHRMOTE<SDPQMIFAXNK<BVYDAJBFASE>>>) VBJSCKRQKMH(this UnsafeList<byte> a, int b, [Optional] Id32<SDPQMIFAXNK<BVYDAJBFASE>>? c, [Optional] Id32<SDPQMIFAXNK<BVYDAJBFASE>>? d)
		{
			return default((Id32<IPPVCHRMOTE<OEBZQFUZUXL>>, Id32<IPPVCHRMOTE<BVYDAJBFASE>>, Id32<IPPVCHRMOTE<SDPQMIFAXNK<BVYDAJBFASE>>>, Id32<IPPVCHRMOTE<SDPQMIFAXNK<BVYDAJBFASE>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x2916F30", Offset = "0x2915F30", VA = "0x182916F30")]
		public static (Id32<IPPVCHRMOTE<OEBZQFUZUXL>>, Id32<IPPVCHRMOTE<SDPQMIFAXNK<BVYDAJBFASE>>>, Id32<IPPVCHRMOTE<SDPQMIFAXNK<BVYDAJBFASE>>>, Id32<IPPVCHRMOTE<SDPQMIFAXNK<BVYDAJBFASE>>>) VEFZAVUUSKO(this UnsafeList<byte> a, [Optional] Id32<SDPQMIFAXNK<BVYDAJBFASE>>? b, [Optional] Id32<SDPQMIFAXNK<BVYDAJBFASE>>? c, [Optional] Id32<SDPQMIFAXNK<BVYDAJBFASE>>? d)
		{
			return default((Id32<IPPVCHRMOTE<OEBZQFUZUXL>>, Id32<IPPVCHRMOTE<SDPQMIFAXNK<BVYDAJBFASE>>>, Id32<IPPVCHRMOTE<SDPQMIFAXNK<BVYDAJBFASE>>>, Id32<IPPVCHRMOTE<SDPQMIFAXNK<BVYDAJBFASE>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x2916C80", Offset = "0x2915C80", VA = "0x182916C80")]
		public static (Id32<IPPVCHRMOTE<OEBZQFUZUXL>>, Id32<IPPVCHRMOTE<BVYDAJBFASE>>, Id32<IPPVCHRMOTE<BVYDAJBFASE>>, Id32<IPPVCHRMOTE<SDPQMIFAXNK<BVYDAJBFASE>>>) UHYZVVJPQIT(this UnsafeList<byte> a, int b, int c, [Optional] Id32<SDPQMIFAXNK<BVYDAJBFASE>>? d)
		{
			return default((Id32<IPPVCHRMOTE<OEBZQFUZUXL>>, Id32<IPPVCHRMOTE<BVYDAJBFASE>>, Id32<IPPVCHRMOTE<BVYDAJBFASE>>, Id32<IPPVCHRMOTE<SDPQMIFAXNK<BVYDAJBFASE>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x2915860", Offset = "0x2914860", VA = "0x182915860")]
		public static (Id32<IPPVCHRMOTE<OEBZQFUZUXL>>, Id32<IPPVCHRMOTE<BVYDAJBFASE>>, Id32<IPPVCHRMOTE<SDPQMIFAXNK<BVYDAJBFASE>>>, Id32<IPPVCHRMOTE<SDPQMIFAXNK<BVYDAJBFASE>>>) MXIMKNCDGDO(this UnsafeList<byte> a, int b, [Optional] Id32<SDPQMIFAXNK<BVYDAJBFASE>>? c, [Optional] Id32<SDPQMIFAXNK<BVYDAJBFASE>>? d)
		{
			return default((Id32<IPPVCHRMOTE<OEBZQFUZUXL>>, Id32<IPPVCHRMOTE<BVYDAJBFASE>>, Id32<IPPVCHRMOTE<SDPQMIFAXNK<BVYDAJBFASE>>>, Id32<IPPVCHRMOTE<SDPQMIFAXNK<BVYDAJBFASE>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x29140C0", Offset = "0x29130C0", VA = "0x1829140C0")]
		public static (Id32<IPPVCHRMOTE<OEBZQFUZUXL>>, Id32<IPPVCHRMOTE<SDPQMIFAXNK<BVYDAJBFASE>>>, Id32<IPPVCHRMOTE<SDPQMIFAXNK<BVYDAJBFASE>>>, Id32<IPPVCHRMOTE<SDPQMIFAXNK<BVYDAJBFASE>>>) ICMWDAVYTAJ(this UnsafeList<byte> a, [Optional] Id32<SDPQMIFAXNK<BVYDAJBFASE>>? b, [Optional] Id32<SDPQMIFAXNK<BVYDAJBFASE>>? c, [Optional] Id32<SDPQMIFAXNK<BVYDAJBFASE>>? d)
		{
			return default((Id32<IPPVCHRMOTE<OEBZQFUZUXL>>, Id32<IPPVCHRMOTE<SDPQMIFAXNK<BVYDAJBFASE>>>, Id32<IPPVCHRMOTE<SDPQMIFAXNK<BVYDAJBFASE>>>, Id32<IPPVCHRMOTE<SDPQMIFAXNK<BVYDAJBFASE>>>));
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
