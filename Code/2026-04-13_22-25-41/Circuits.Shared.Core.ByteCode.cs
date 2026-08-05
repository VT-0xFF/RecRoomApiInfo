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
		[Cpp2IlInjected.Address(RVA = "0xD18E40", Offset = "0xD17840", VA = "0x180D18E40")]
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
		[Cpp2IlInjected.Address(RVA = "0x2B74060", Offset = "0x2B72A60", VA = "0x182B74060")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xD19810", Offset = "0xD18210", VA = "0x180D19810")]
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
		[Cpp2IlInjected.Address(RVA = "0xD19850", Offset = "0xD18250", VA = "0x180D19850")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
namespace Circuits.Shared.Core.ByteCode
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public static class LHPJXAITWTZ
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x3BEDCB0", Offset = "0x3BEC6B0", VA = "0x183BEDCB0")]
		public static Id32<KGMTAGLYNTP<a>> KFNFAOCWMAD<a>(this int a)
		{
			return default(Id32<KGMTAGLYNTP<a>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x2B74020", Offset = "0x2B72A20", VA = "0x182B74020")]
		public static Id32<BVTCYCWYPSS> CKLJDWLAFOU(this int a)
		{
			return default(Id32<BVTCYCWYPSS>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x3BEDCB0", Offset = "0x3BEC6B0", VA = "0x183BEDCB0")]
		public static Id32<UTDLMYHANGH<b>> GAKPTQSBAFT<b>(this int a)
		{
			return default(Id32<UTDLMYHANGH<b>>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public sealed class KGMTAGLYNTP<a>
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public sealed class ZIFRBIBKQGK
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public sealed class WUKPIZKJTLJ
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public sealed class BVTCYCWYPSS
	{
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public sealed class ELLAOEGXNOQ
	{
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public sealed class MKZPDGHNCPU
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
	public static class CDHEZIAERUN
	{
		[Cpp2IlInjected.Token(Token = "0x200000E")]
		public readonly struct ProcessOpDelegate<TContext, TDeps, TCompileState>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000091")]
			private readonly IntPtr _impl;

			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0xEC80B0", Offset = "0xEC6AB0", VA = "0x180EC80B0")]
			public ProcessOpDelegate(IntPtr impl)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x7581300", Offset = "0x757FD00", VA = "0x187581300")]
			public int Invoke(TDeps deps, TContext ctx, TCompileState compileState, [In] UnsafeList<byte> fromByteCode, int byteCodePtr)
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x37DAAE0", Offset = "0x37D94E0", VA = "0x1837DAAE0")]
		public static void LWKRZGXHSLY<TDeps, TContext, TCompileState>(TDeps a, TContext b, TCompileState c, [In] UnsafeList<byte> oldByteCode, UnsafeList<byte> newByteCode, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processAddF32_F32i_F32i_F32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processAddF32_F32i_F32r_F32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processAddF32_F32r_F32r_F32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processAddI32_I32i_I32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processAddI32_I32i_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processAddI32_I32r_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processAndI32_I32i_I32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processAndI32_I32i_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processAndI32_I32r_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfEqualF32_F32i_F32i_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfEqualF32_F32i_F32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfEqualF32_F32r_F32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfEqualI32_I32i_I32i_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfEqualI32_I32i_I32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfEqualI32_I32r_I32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfGreaterOrEqualF32_F32i_F32i_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfGreaterOrEqualF32_F32i_F32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfGreaterOrEqualF32_F32r_F32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfGreaterOrEqualI32_I32i_I32i_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfGreaterOrEqualI32_I32i_I32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfGreaterOrEqualI32_I32r_I32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfLessF32_F32i_F32i_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfLessF32_F32i_F32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfLessF32_F32r_F32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfLessI32_I32i_I32i_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfLessI32_I32i_I32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfLessI32_I32r_I32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfLessOrEqualF32_F32i_F32i_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfLessOrEqualF32_F32i_F32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfLessOrEqualF32_F32r_F32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfLessOrEqualI32_I32i_I32i_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfLessOrEqualI32_I32i_I32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfLessOrEqualI32_I32r_I32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfNotEqualF32_F32i_F32i_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfNotEqualF32_F32i_F32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfNotEqualF32_F32r_F32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfNotEqualI32_I32i_I32i_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfNotEqualI32_I32i_I32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfNotEqualI32_I32r_I32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfNotZeroF32_F32i_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfNotZeroF32_F32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfNotZeroI32_I32i_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfNotZeroI32_I32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfZeroF32_F32i_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfZeroF32_F32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfZeroI32_I32i_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfZeroI32_I32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processCallInternal_I32i_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processCallInternal_I32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processCallExternal_I32i_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processCallExternal_I32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processCallRuntime_I32i_I32i_Xi, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processCopyI32_I32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processCopyI32_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processCopyX_Xr_I32i_Xi, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processCopyX_Xr_Xr_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processDivideF32_F32i_F32i_F32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processDivideF32_F32i_F32r_F32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processDivideF32_F32r_F32r_F32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processDivideI32_I32i_I32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processDivideI32_I32i_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processDivideI32_I32r_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processEqualF32_F32i_F32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processEqualF32_F32i_F32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processEqualF32_F32r_F32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processEqualI32_I32i_I32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processEqualI32_I32i_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processEqualI32_I32r_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processEnd, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processGreaterF32_F32i_F32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processGreaterF32_F32i_F32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processGreaterF32_F32r_F32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processGreaterI32_I32i_I32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processGreaterI32_I32i_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processGreaterI32_I32r_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processGreaterOrEqualF32_F32i_F32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processGreaterOrEqualF32_F32i_F32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processGreaterOrEqualF32_F32r_F32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processGreaterOrEqualI32_I32i_I32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processGreaterOrEqualI32_I32i_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processGreaterOrEqualI32_I32r_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processJump_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processJump_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processLessF32_F32i_F32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processLessF32_F32i_F32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processLessF32_F32r_F32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processLessI32_I32i_I32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processLessI32_I32i_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processLessI32_I32r_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processLessOrEqualF32_F32i_F32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processLessOrEqualF32_F32i_F32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processLessOrEqualF32_F32r_F32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processLessOrEqualI32_I32i_I32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processLessOrEqualI32_I32i_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processLessOrEqualI32_I32r_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processModI32_I32i_I32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processModI32_I32i_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processModI32_I32r_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processMultiplyF32_F32i_F32i_F32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processMultiplyF32_F32i_F32r_F32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processMultiplyF32_F32r_F32r_F32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processMultiplyI32_I32i_I32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processMultiplyI32_I32i_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processMultiplyI32_I32r_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processNegateF32_F32i_F32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processNegateF32_F32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processNegateF32_F32r_F32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processNegateI32_I32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processNegateI32_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processNegateI32_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processNoOp, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processNotEqualF32_F32i_F32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processNotEqualF32_F32i_F32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processNotEqualF32_F32r_F32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processNotEqualI32_I32i_I32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processNotEqualI32_I32i_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processNotEqualI32_I32r_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processNotI32_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processNotI32_I32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processNotI32_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processOrI32_I32i_I32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processOrI32_I32i_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processOrI32_I32r_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processReturn, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processStaticCastF32I32_F32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processStaticCastI32F32_I32r_F32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processSubtractF32_F32i_F32i_F32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processSubtractF32_F32i_F32r_F32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processSubtractF32_F32r_F32r_F32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processSubtractI32_I32i_I32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processSubtractI32_I32i_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processSubtractI32_I32r_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processXorI32_I32i_I32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processXorI32_I32i_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processXorI32_I32r_I32r_I32r) where TDeps : notnull where TContext : notnull where TCompileState : notnull
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x2B6DF10", Offset = "0x2B6C910", VA = "0x182B6DF10")]
		private static int GLKYHZXZZOU([In] UnsafeList<byte> from, UnsafeList<byte> a, int b, int c)
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public static class FWBVZXRBXDW
	{
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		public static readonly int LBUTZQYOFOO;

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x3AC33F0", Offset = "0x3AC1DF0", VA = "0x183AC33F0")]
		public static Id32<KGMTAGLYNTP<a>> EIOJUTQZOKA<a>([In] this UnsafeList<byte> self)
		{
			return default(Id32<KGMTAGLYNTP<a>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x3AC3550", Offset = "0x3AC1F50", VA = "0x183AC3550")]
		public static Id32<KGMTAGLYNTP<KGMTAGLYNTP<b>>> EXXIRHGPLKD<b>(this UnsafeList<byte> a, [Optional] Id32<KGMTAGLYNTP<b>>? b)
		{
			return default(Id32<KGMTAGLYNTP<KGMTAGLYNTP<b>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x2B6E1A0", Offset = "0x2B6CBA0", VA = "0x182B6E1A0")]
		public static Id32<KGMTAGLYNTP<CQQKHLGBDOQ>> UDQMRHZMPIT(this UnsafeList<byte> a, [Optional] Id32<CQQKHLGBDOQ>? b)
		{
			return default(Id32<KGMTAGLYNTP<CQQKHLGBDOQ>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x2B6E470", Offset = "0x2B6CE70", VA = "0x182B6E470")]
		public static Id32<KGMTAGLYNTP<ZIFRBIBKQGK>> WXEUJOWKEJR(this UnsafeList<byte> a, [Optional] float? b)
		{
			return default(Id32<KGMTAGLYNTP<ZIFRBIBKQGK>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x2B6E560", Offset = "0x2B6CF60", VA = "0x182B6E560")]
		public static Id32<KGMTAGLYNTP<WUKPIZKJTLJ>> ZKZWBXNLBES(this UnsafeList<byte> a, [Optional] int? b)
		{
			return default(Id32<KGMTAGLYNTP<WUKPIZKJTLJ>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x2B6E0B0", Offset = "0x2B6CAB0", VA = "0x182B6E0B0")]
		public static Id32<KGMTAGLYNTP<FKAHYQVBHTH>> HIPFBNPDXMY(this UnsafeList<byte> a, [Optional] Id32<FKAHYQVBHTH>? b)
		{
			return default(Id32<KGMTAGLYNTP<FKAHYQVBHTH>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x2B6DFB0", Offset = "0x2B6C9B0", VA = "0x182B6DFB0")]
		public static Id32<KGMTAGLYNTP<MKZPDGHNCPU>> FXOJOEQTYQF(this UnsafeList<byte> a, [Optional] byte? b)
		{
			return default(Id32<KGMTAGLYNTP<MKZPDGHNCPU>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x2B6E290", Offset = "0x2B6CC90", VA = "0x182B6E290")]
		public static Id32<KGMTAGLYNTP<BVTCYCWYPSS>> VIQHLRFSNIZ(this UnsafeList<byte> a, [Optional] Id32<BVTCYCWYPSS>? b)
		{
			return default(Id32<KGMTAGLYNTP<BVTCYCWYPSS>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x2B6E380", Offset = "0x2B6CD80", VA = "0x182B6E380")]
		public static Id32<KGMTAGLYNTP<ELLAOEGXNOQ>> WCSGWNSOEMH(this UnsafeList<byte> a, [Optional] Op? b)
		{
			return default(Id32<KGMTAGLYNTP<ELLAOEGXNOQ>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x3AC3550", Offset = "0x3AC1F50", VA = "0x183AC3550")]
		public static Id32<KGMTAGLYNTP<UTDLMYHANGH<c>>> LCTGNHIWPVH<c>(this UnsafeList<byte> a, [Optional] Id32<UTDLMYHANGH<c>>? b)
		{
			return default(Id32<KGMTAGLYNTP<UTDLMYHANGH<c>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x2B6DE20", Offset = "0x2B6C820", VA = "0x182B6DE20")]
		public static void SJKGECQAURJ(this UnsafeList<byte> a, Id32<KGMTAGLYNTP<WUKPIZKJTLJ>> b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x3AC3630", Offset = "0x3AC2030", VA = "0x183AC3630")]
		public static void SPMAYAIRCFE<d>(this UnsafeList<byte> a, Id32<KGMTAGLYNTP<KGMTAGLYNTP<d>>> b, Id32<KGMTAGLYNTP<d>> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x3AC3630", Offset = "0x3AC2030", VA = "0x183AC3630")]
		public static void JORHJXFIFNG<e>(this UnsafeList<byte> a, Id32<KGMTAGLYNTP<UTDLMYHANGH<e>>> b, Id32<UTDLMYHANGH<e>> c)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public static class RUDKHQDPZYZ
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x2B74440", Offset = "0x2B72E40", VA = "0x182B74440")]
		public static Union32 UZAKFUXQPMB([In] this ReadOnlySpan<byte> bytes, int a)
		{
			return default(Union32);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x2B744B0", Offset = "0x2B72EB0", VA = "0x182B744B0")]
		public static Union32 UZAKFUXQPMB([In] this UnsafeList<byte> bytes, int a)
		{
			return default(Union32);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x3ED7640", Offset = "0x3ED6040", VA = "0x183ED7640")]
		public static Union32 UZAKFUXQPMB<f>(this ReadOnlyIdArray<f, byte> a, Id32<f> b)
		{
			return default(Union32);
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x3ED74C0", Offset = "0x3ED5EC0", VA = "0x183ED74C0")]
		public static Union32 UZAKFUXQPMB<g>([In] this ReadOnlyIdSpan<g, byte> bytes, Id32<g> a)
		{
			return default(Union32);
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x3ED7880", Offset = "0x3ED6280", VA = "0x183ED7880")]
		public static Union32 UZAKFUXQPMB<i>(this IdArray<i, byte> a, Id32<i> b)
		{
			return default(Union32);
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x3ED78E0", Offset = "0x3ED62E0", VA = "0x183ED78E0")]
		public static Union32 UZAKFUXQPMB<j>([In] this IdSpan<j, byte> bytes, Id32<j> a)
		{
			return default(Union32);
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x3ED77C0", Offset = "0x3ED61C0", VA = "0x183ED77C0")]
		public static Union32 UZAKFUXQPMB<k>(this ReadOnlyIdArray<k, byte> a, Id32<k> b)
		{
			return default(Union32);
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x2B74440", Offset = "0x2B72E40", VA = "0x182B74440")]
		public static int WWSEBKZPKSG([In] this ReadOnlySpan<byte> bytes, int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x2B6DF00", Offset = "0x2B6C900", VA = "0x182B6DF00")]
		public static int WWSEBKZPKSG([In] this UnsafeList<byte> bytes, int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x3ED7DC0", Offset = "0x3ED67C0", VA = "0x183ED7DC0")]
		public static int WWSEBKZPKSG<p>(this ReadOnlyIdArray<p, byte> a, Id32<p> b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x3ED7E10", Offset = "0x3ED6810", VA = "0x183ED7E10")]
		public static int WWSEBKZPKSG<s>(this IdArray<s, byte> a, Id32<s> b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x3ED7E90", Offset = "0x3ED6890", VA = "0x183ED7E90")]
		public static int WWSEBKZPKSG<t>([In] this IdSpan<t, byte> bytes, Id32<t> a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x3ED7EE0", Offset = "0x3ED68E0", VA = "0x183ED7EE0")]
		public static int WWSEBKZPKSG<u>(this ReadOnlyIdArray<u, byte> a, Id32<u> b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x3ED6D20", Offset = "0x3ED5720", VA = "0x183ED6D20")]
		public static float LLRZDJGBDDV<bc>(this IdArray<bc, byte> a, Id32<bc> b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x3ED6CD0", Offset = "0x3ED56D0", VA = "0x183ED6CD0")]
		public static float LLRZDJGBDDV<bd>([In] this IdSpan<bd, byte> bytes, Id32<bd> a)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x3ED6C80", Offset = "0x3ED5680", VA = "0x183ED6C80")]
		public static float LLRZDJGBDDV<be>(this ReadOnlyIdArray<be, byte> a, Id32<be> b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x3ED69B0", Offset = "0x3ED53B0", VA = "0x183ED69B0")]
		public static byte CERKLUVSAIB<bj>(this ReadOnlyIdArray<bj, byte> a, Id32<bj> b)
		{
			return default(byte);
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x3ED6A00", Offset = "0x3ED5400", VA = "0x183ED6A00")]
		public static byte CERKLUVSAIB<bk>([In] this ReadOnlyIdSpan<bk, byte> bytes, Id32<bk> a)
		{
			return default(byte);
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x3ED67D0", Offset = "0x3ED51D0", VA = "0x183ED67D0")]
		public static byte CERKLUVSAIB<bm>(this IdArray<bm, byte> a, Id32<bm> b)
		{
			return default(byte);
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x3ED6850", Offset = "0x3ED5250", VA = "0x183ED6850")]
		public static byte CERKLUVSAIB<bn>([In] this IdSpan<bn, byte> bytes, Id32<bn> a)
		{
			return default(byte);
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x3ED68E0", Offset = "0x3ED52E0", VA = "0x183ED68E0")]
		public static byte CERKLUVSAIB<bo>(this ReadOnlyIdArray<bo, byte> a, Id32<bo> b)
		{
			return default(byte);
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x2B6DF00", Offset = "0x2B6C900", VA = "0x182B6DF00")]
		public static Op WBHDBFOTGDF([In] this UnsafeList<byte> bytes, int a)
		{
			return default(Op);
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x3ED79A0", Offset = "0x3ED63A0", VA = "0x183ED79A0")]
		public static Op WBHDBFOTGDF<by>(this ReadOnlyIdArray<by, byte> a, Id32<by> b)
		{
			return default(Op);
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x3ED7150", Offset = "0x3ED5B50", VA = "0x183ED7150")]
		public static Id32<KGMTAGLYNTP<RRRVXHRUCXR>> QSIEYQLJZEL<cg>(this IdArray<cg, byte> a, Id32<cg> b)
		{
			return default(Id32<KGMTAGLYNTP<RRRVXHRUCXR>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x3ED7030", Offset = "0x3ED5A30", VA = "0x183ED7030")]
		public static Id32<KGMTAGLYNTP<RRRVXHRUCXR>> QSIEYQLJZEL<ch>([In] this IdSpan<ch, byte> bytes, Id32<ch> a)
		{
			return default(Id32<KGMTAGLYNTP<RRRVXHRUCXR>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x3ED70C0", Offset = "0x3ED5AC0", VA = "0x183ED70C0")]
		public static Id32<KGMTAGLYNTP<RRRVXHRUCXR>> QSIEYQLJZEL<ci>(this ReadOnlyIdArray<ci, byte> a, Id32<ci> b)
		{
			return default(Id32<KGMTAGLYNTP<RRRVXHRUCXR>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x3ED6AD0", Offset = "0x3ED54D0", VA = "0x183ED6AD0")]
		public static Id32<UTDLMYHANGH<RRRVXHRUCXR>> IXFLJILCTRL<cs>(this ReadOnlyIdArray<cs, byte> a, Id32<cs> b)
		{
			return default(Id32<UTDLMYHANGH<RRRVXHRUCXR>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x3ED7B80", Offset = "0x3ED6580", VA = "0x183ED7B80")]
		public static Id32<BVTCYCWYPSS> WGOOSJREOKF<da>(this IdArray<da, byte> a, Id32<da> b)
		{
			return default(Id32<BVTCYCWYPSS>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x3ED7C00", Offset = "0x3ED6600", VA = "0x183ED7C00")]
		public static Id32<BVTCYCWYPSS> WGOOSJREOKF<db>([In] this IdSpan<db, byte> bytes, Id32<db> a)
		{
			return default(Id32<BVTCYCWYPSS>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x3ED7C90", Offset = "0x3ED6690", VA = "0x183ED7C90")]
		public static Id32<BVTCYCWYPSS> WGOOSJREOKF<dc>(this ReadOnlyIdArray<dc, byte> a, Id32<dc> b)
		{
			return default(Id32<BVTCYCWYPSS>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x3ED8030", Offset = "0x3ED6A30", VA = "0x183ED8030")]
		public static Id32<CQQKHLGBDOQ> YJRHWKVSPOX<dl>([In] this IdSpan<dl, byte> bytes, Id32<dl> a)
		{
			return default(Id32<CQQKHLGBDOQ>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x3ED80C0", Offset = "0x3ED6AC0", VA = "0x183ED80C0")]
		public static Id32<CQQKHLGBDOQ> YJRHWKVSPOX<dm>(this ReadOnlyIdArray<dm, byte> a, Id32<dm> b)
		{
			return default(Id32<CQQKHLGBDOQ>);
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x3ED6E20", Offset = "0x3ED5820", VA = "0x183ED6E20")]
		public static Id32<FKAHYQVBHTH> MVTWUQPPEBE<dw>(this ReadOnlyIdArray<dw, byte> a, Id32<dw> b)
		{
			return default(Id32<FKAHYQVBHTH>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public static class QTNZHCJASZT
	{
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x2B74280", Offset = "0x2B72C80", VA = "0x182B74280")]
		public static void PNKZEAGFCKM(this UnsafeList<byte> a, int b, Union32 c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x2B74190", Offset = "0x2B72B90", VA = "0x182B74190")]
		public static void PNKZEAGFCKM(this byte[] a, int b, Union32 c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x2B74200", Offset = "0x2B72C00", VA = "0x182B74200")]
		public static void PNKZEAGFCKM([In] this Span<byte> bytes, int a, Union32 b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x3E396B0", Offset = "0x3E380B0", VA = "0x183E396B0")]
		public static void PNKZEAGFCKM<e>(this IdArray<e, byte> a, Id32<e> b, Union32 c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x3E39560", Offset = "0x3E37F60", VA = "0x183E39560")]
		public static void PNKZEAGFCKM<f>([In] this IdSpan<f, byte> bytes, Id32<f> a, Union32 b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x2B6DE20", Offset = "0x2B6C820", VA = "0x182B6DE20")]
		public static void SJKGECQAURJ(this UnsafeList<byte> a, int b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x2B743C0", Offset = "0x2B72DC0", VA = "0x182B743C0")]
		public static void SJKGECQAURJ(this byte[] a, int b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x2B74340", Offset = "0x2B72D40", VA = "0x182B74340")]
		public static void SJKGECQAURJ([In] this Span<byte> bytes, int a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x3E39940", Offset = "0x3E38340", VA = "0x183E39940")]
		public static void SJKGECQAURJ<h>(this IdArray<h, byte> a, Id32<h> b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x3E398E0", Offset = "0x3E382E0", VA = "0x183E398E0")]
		public static void SJKGECQAURJ<i>([In] this IdSpan<i, byte> bytes, Id32<i> a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x2B740E0", Offset = "0x2B72AE0", VA = "0x182B740E0")]
		public static void DNTUFXMZVWW(this UnsafeList<byte> a, int b, float c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x3E39120", Offset = "0x3E37B20", VA = "0x183E39120")]
		public static void DNTUFXMZVWW<k>(this IdArray<k, byte> a, Id32<k> b, float c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x3E39190", Offset = "0x3E37B90", VA = "0x183E39190")]
		public static void DNTUFXMZVWW<l>([In] this IdSpan<l, byte> bytes, Id32<l> a, float b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x2B74120", Offset = "0x2B72B20", VA = "0x182B74120")]
		public static void OUMFIRMMXYW(this UnsafeList<byte> a, int b, byte c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x3E392B0", Offset = "0x3E37CB0", VA = "0x183E392B0")]
		public static void OUMFIRMMXYW<n>(this IdArray<n, byte> a, Id32<n> b, byte c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x3E39300", Offset = "0x3E37D00", VA = "0x183E39300")]
		public static void OUMFIRMMXYW<o>([In] this IdSpan<o, byte> bytes, Id32<o> a, byte b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x3E39A60", Offset = "0x3E38460", VA = "0x183E39A60")]
		public static void SPMAYAIRCFE<q>(this IdArray<q, byte> a, Id32<q> b, Id32<KGMTAGLYNTP<RRRVXHRUCXR>> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x3E39AE0", Offset = "0x3E384E0", VA = "0x183E39AE0")]
		public static void SPMAYAIRCFE<r>([In] this IdSpan<r, byte> bytes, Id32<r> a, Id32<KGMTAGLYNTP<RRRVXHRUCXR>> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x3E39A60", Offset = "0x3E38460", VA = "0x183E39A60")]
		public static void XQEPEAPMDFM<t>(this IdArray<t, byte> a, Id32<t> b, Id32<BVTCYCWYPSS> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x3E39AE0", Offset = "0x3E384E0", VA = "0x183E39AE0")]
		public static void XQEPEAPMDFM<u>([In] this IdSpan<u, byte> bytes, Id32<u> a, Id32<BVTCYCWYPSS> b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public static class HIOGKEDYBBK
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x2B6FFD0", Offset = "0x2B6E9D0", VA = "0x182B6FFD0")]
		public static (Id32<KGMTAGLYNTP<ELLAOEGXNOQ>>, Id32<KGMTAGLYNTP<ZIFRBIBKQGK>>, Id32<KGMTAGLYNTP<ZIFRBIBKQGK>>, Id32<KGMTAGLYNTP<UTDLMYHANGH<ZIFRBIBKQGK>>>) FYJVPGJCRRM(this UnsafeList<byte> a, float b, float c, [Optional] Id32<UTDLMYHANGH<ZIFRBIBKQGK>>? d)
		{
			return default((Id32<KGMTAGLYNTP<ELLAOEGXNOQ>>, Id32<KGMTAGLYNTP<ZIFRBIBKQGK>>, Id32<KGMTAGLYNTP<ZIFRBIBKQGK>>, Id32<KGMTAGLYNTP<UTDLMYHANGH<ZIFRBIBKQGK>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x2B72E40", Offset = "0x2B71840", VA = "0x182B72E40")]
		public static (Id32<KGMTAGLYNTP<ELLAOEGXNOQ>>, Id32<KGMTAGLYNTP<ZIFRBIBKQGK>>, Id32<KGMTAGLYNTP<UTDLMYHANGH<ZIFRBIBKQGK>>>, Id32<KGMTAGLYNTP<UTDLMYHANGH<ZIFRBIBKQGK>>>) TZKFCVZXCQV(this UnsafeList<byte> a, float b, [Optional] Id32<UTDLMYHANGH<ZIFRBIBKQGK>>? c, [Optional] Id32<UTDLMYHANGH<ZIFRBIBKQGK>>? d)
		{
			return default((Id32<KGMTAGLYNTP<ELLAOEGXNOQ>>, Id32<KGMTAGLYNTP<ZIFRBIBKQGK>>, Id32<KGMTAGLYNTP<UTDLMYHANGH<ZIFRBIBKQGK>>>, Id32<KGMTAGLYNTP<UTDLMYHANGH<ZIFRBIBKQGK>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x2B70D90", Offset = "0x2B6F790", VA = "0x182B70D90")]
		public static (Id32<KGMTAGLYNTP<ELLAOEGXNOQ>>, Id32<KGMTAGLYNTP<UTDLMYHANGH<ZIFRBIBKQGK>>>, Id32<KGMTAGLYNTP<UTDLMYHANGH<ZIFRBIBKQGK>>>, Id32<KGMTAGLYNTP<UTDLMYHANGH<ZIFRBIBKQGK>>>) LUEKJFGJNAM(this UnsafeList<byte> a, [Optional] Id32<UTDLMYHANGH<ZIFRBIBKQGK>>? b, [Optional] Id32<UTDLMYHANGH<ZIFRBIBKQGK>>? c, [Optional] Id32<UTDLMYHANGH<ZIFRBIBKQGK>>? d)
		{
			return default((Id32<KGMTAGLYNTP<ELLAOEGXNOQ>>, Id32<KGMTAGLYNTP<UTDLMYHANGH<ZIFRBIBKQGK>>>, Id32<KGMTAGLYNTP<UTDLMYHANGH<ZIFRBIBKQGK>>>, Id32<KGMTAGLYNTP<UTDLMYHANGH<ZIFRBIBKQGK>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x2B73DA0", Offset = "0x2B727A0", VA = "0x182B73DA0")]
		public static (Id32<KGMTAGLYNTP<ELLAOEGXNOQ>>, Id32<KGMTAGLYNTP<WUKPIZKJTLJ>>, Id32<KGMTAGLYNTP<WUKPIZKJTLJ>>, Id32<KGMTAGLYNTP<UTDLMYHANGH<WUKPIZKJTLJ>>>) YDXWQRQBSOM(this UnsafeList<byte> a, int b, int c, [Optional] Id32<UTDLMYHANGH<WUKPIZKJTLJ>>? d)
		{
			return default((Id32<KGMTAGLYNTP<ELLAOEGXNOQ>>, Id32<KGMTAGLYNTP<WUKPIZKJTLJ>>, Id32<KGMTAGLYNTP<WUKPIZKJTLJ>>, Id32<KGMTAGLYNTP<UTDLMYHANGH<WUKPIZKJTLJ>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x2B71390", Offset = "0x2B6FD90", VA = "0x182B71390")]
		public static (Id32<KGMTAGLYNTP<ELLAOEGXNOQ>>, Id32<KGMTAGLYNTP<WUKPIZKJTLJ>>, Id32<KGMTAGLYNTP<UTDLMYHANGH<WUKPIZKJTLJ>>>, Id32<KGMTAGLYNTP<UTDLMYHANGH<WUKPIZKJTLJ>>>) MVGXPRZNONF(this UnsafeList<byte> a, int b, [Optional] Id32<UTDLMYHANGH<WUKPIZKJTLJ>>? c, [Optional] Id32<UTDLMYHANGH<WUKPIZKJTLJ>>? d)
		{
			return default((Id32<KGMTAGLYNTP<ELLAOEGXNOQ>>, Id32<KGMTAGLYNTP<WUKPIZKJTLJ>>, Id32<KGMTAGLYNTP<UTDLMYHANGH<WUKPIZKJTLJ>>>, Id32<KGMTAGLYNTP<UTDLMYHANGH<WUKPIZKJTLJ>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x2B71790", Offset = "0x2B70190", VA = "0x182B71790")]
		public static (Id32<KGMTAGLYNTP<ELLAOEGXNOQ>>, Id32<KGMTAGLYNTP<UTDLMYHANGH<WUKPIZKJTLJ>>>, Id32<KGMTAGLYNTP<UTDLMYHANGH<WUKPIZKJTLJ>>>, Id32<KGMTAGLYNTP<UTDLMYHANGH<WUKPIZKJTLJ>>>) NKYRLCPAPRE(this UnsafeList<byte> a, [Optional] Id32<UTDLMYHANGH<WUKPIZKJTLJ>>? b, [Optional] Id32<UTDLMYHANGH<WUKPIZKJTLJ>>? c, [Optional] Id32<UTDLMYHANGH<WUKPIZKJTLJ>>? d)
		{
			return default((Id32<KGMTAGLYNTP<ELLAOEGXNOQ>>, Id32<KGMTAGLYNTP<UTDLMYHANGH<WUKPIZKJTLJ>>>, Id32<KGMTAGLYNTP<UTDLMYHANGH<WUKPIZKJTLJ>>>, Id32<KGMTAGLYNTP<UTDLMYHANGH<WUKPIZKJTLJ>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x2B72CE0", Offset = "0x2B716E0", VA = "0x182B72CE0")]
		public static (Id32<KGMTAGLYNTP<ELLAOEGXNOQ>>, Id32<KGMTAGLYNTP<WUKPIZKJTLJ>>, Id32<KGMTAGLYNTP<WUKPIZKJTLJ>>, Id32<KGMTAGLYNTP<UTDLMYHANGH<WUKPIZKJTLJ>>>) TZDQRRTTAUG(this UnsafeList<byte> a, int b, int c, [Optional] Id32<UTDLMYHANGH<WUKPIZKJTLJ>>? d)
		{
			return default((Id32<KGMTAGLYNTP<ELLAOEGXNOQ>>, Id32<KGMTAGLYNTP<WUKPIZKJTLJ>>, Id32<KGMTAGLYNTP<WUKPIZKJTLJ>>, Id32<KGMTAGLYNTP<UTDLMYHANGH<WUKPIZKJTLJ>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x2B6EAB0", Offset = "0x2B6D4B0", VA = "0x182B6EAB0")]
		public static (Id32<KGMTAGLYNTP<ELLAOEGXNOQ>>, Id32<KGMTAGLYNTP<WUKPIZKJTLJ>>, Id32<KGMTAGLYNTP<UTDLMYHANGH<WUKPIZKJTLJ>>>, Id32<KGMTAGLYNTP<UTDLMYHANGH<WUKPIZKJTLJ>>>) ASNPNQPQTLX(this UnsafeList<byte> a, int b, [Optional] Id32<UTDLMYHANGH<WUKPIZKJTLJ>>? c, [Optional] Id32<UTDLMYHANGH<WUKPIZKJTLJ>>? d)
		{
			return default((Id32<KGMTAGLYNTP<ELLAOEGXNOQ>>, Id32<KGMTAGLYNTP<WUKPIZKJTLJ>>, Id32<KGMTAGLYNTP<UTDLMYHANGH<WUKPIZKJTLJ>>>, Id32<KGMTAGLYNTP<UTDLMYHANGH<WUKPIZKJTLJ>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x2B6FBE0", Offset = "0x2B6E5E0", VA = "0x182B6FBE0")]
		public static (Id32<KGMTAGLYNTP<ELLAOEGXNOQ>>, Id32<KGMTAGLYNTP<UTDLMYHANGH<WUKPIZKJTLJ>>>, Id32<KGMTAGLYNTP<UTDLMYHANGH<WUKPIZKJTLJ>>>, Id32<KGMTAGLYNTP<UTDLMYHANGH<WUKPIZKJTLJ>>>) FBPZZSRREGU(this UnsafeList<byte> a, [Optional] Id32<UTDLMYHANGH<WUKPIZKJTLJ>>? b, [Optional] Id32<UTDLMYHANGH<WUKPIZKJTLJ>>? c, [Optional] Id32<UTDLMYHANGH<WUKPIZKJTLJ>>? d)
		{
			return default((Id32<KGMTAGLYNTP<ELLAOEGXNOQ>>, Id32<KGMTAGLYNTP<UTDLMYHANGH<WUKPIZKJTLJ>>>, Id32<KGMTAGLYNTP<UTDLMYHANGH<WUKPIZKJTLJ>>>, Id32<KGMTAGLYNTP<UTDLMYHANGH<WUKPIZKJTLJ>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x2B739E0", Offset = "0x2B723E0", VA = "0x182B739E0")]
		public static (Id32<KGMTAGLYNTP<ELLAOEGXNOQ>>, Id32<KGMTAGLYNTP<WUKPIZKJTLJ>>, Id32<KGMTAGLYNTP<KGMTAGLYNTP<ELLAOEGXNOQ>>>) XFQZVRCSXRO(this UnsafeList<byte> a, [Optional] int? b, [Optional] Id32<KGMTAGLYNTP<ELLAOEGXNOQ>>? c)
		{
			return default((Id32<KGMTAGLYNTP<ELLAOEGXNOQ>>, Id32<KGMTAGLYNTP<WUKPIZKJTLJ>>, Id32<KGMTAGLYNTP<KGMTAGLYNTP<ELLAOEGXNOQ>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x2B70150", Offset = "0x2B6EB50", VA = "0x182B70150")]
		public static (Id32<KGMTAGLYNTP<ELLAOEGXNOQ>>, Id32<KGMTAGLYNTP<UTDLMYHANGH<WUKPIZKJTLJ>>>, Id32<KGMTAGLYNTP<KGMTAGLYNTP<ELLAOEGXNOQ>>>) GJZJVBPMXVR(this UnsafeList<byte> a, [Optional] Id32<UTDLMYHANGH<WUKPIZKJTLJ>>? b, [Optional] Id32<KGMTAGLYNTP<ELLAOEGXNOQ>>? c)
		{
			return default((Id32<KGMTAGLYNTP<ELLAOEGXNOQ>>, Id32<KGMTAGLYNTP<UTDLMYHANGH<WUKPIZKJTLJ>>>, Id32<KGMTAGLYNTP<KGMTAGLYNTP<ELLAOEGXNOQ>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x2B70270", Offset = "0x2B6EC70", VA = "0x182B70270")]
		public static (Id32<KGMTAGLYNTP<ELLAOEGXNOQ>>, Id32<KGMTAGLYNTP<WUKPIZKJTLJ>>, Id32<KGMTAGLYNTP<KGMTAGLYNTP<ELLAOEGXNOQ>>>) HBRZXQVCIJL(this UnsafeList<byte> a, [Optional] int? b, [Optional] Id32<KGMTAGLYNTP<ELLAOEGXNOQ>>? c)
		{
			return default((Id32<KGMTAGLYNTP<ELLAOEGXNOQ>>, Id32<KGMTAGLYNTP<WUKPIZKJTLJ>>, Id32<KGMTAGLYNTP<KGMTAGLYNTP<ELLAOEGXNOQ>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x2B73620", Offset = "0x2B72020", VA = "0x182B73620")]
		public static (Id32<KGMTAGLYNTP<ELLAOEGXNOQ>>, Id32<KGMTAGLYNTP<UTDLMYHANGH<WUKPIZKJTLJ>>>, Id32<KGMTAGLYNTP<KGMTAGLYNTP<ELLAOEGXNOQ>>>) WLLHMLDBSAO(this UnsafeList<byte> a, [Optional] Id32<UTDLMYHANGH<WUKPIZKJTLJ>>? b, [Optional] Id32<KGMTAGLYNTP<ELLAOEGXNOQ>>? c)
		{
			return default((Id32<KGMTAGLYNTP<ELLAOEGXNOQ>>, Id32<KGMTAGLYNTP<UTDLMYHANGH<WUKPIZKJTLJ>>>, Id32<KGMTAGLYNTP<KGMTAGLYNTP<ELLAOEGXNOQ>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x2B6EC00", Offset = "0x2B6D600", VA = "0x182B6EC00")]
		public static (Id32<KGMTAGLYNTP<ELLAOEGXNOQ>>, Id32<KGMTAGLYNTP<WUKPIZKJTLJ>>, Id32<KGMTAGLYNTP<CQQKHLGBDOQ>>) ATLPWQJFITF(this UnsafeList<byte> a, [Optional] int? b, [Optional] Id32<CQQKHLGBDOQ>? c)
		{
			return default((Id32<KGMTAGLYNTP<ELLAOEGXNOQ>>, Id32<KGMTAGLYNTP<WUKPIZKJTLJ>>, Id32<KGMTAGLYNTP<CQQKHLGBDOQ>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x2B6EDB0", Offset = "0x2B6D7B0", VA = "0x182B6EDB0")]
		public static (Id32<KGMTAGLYNTP<ELLAOEGXNOQ>>, Id32<KGMTAGLYNTP<WUKPIZKJTLJ>>, Id32<KGMTAGLYNTP<UTDLMYHANGH<CQQKHLGBDOQ>>>) AVGZXZGHPRI(this UnsafeList<byte> a, [Optional] int? b, [Optional] Id32<UTDLMYHANGH<CQQKHLGBDOQ>>? c)
		{
			return default((Id32<KGMTAGLYNTP<ELLAOEGXNOQ>>, Id32<KGMTAGLYNTP<WUKPIZKJTLJ>>, Id32<KGMTAGLYNTP<UTDLMYHANGH<CQQKHLGBDOQ>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x2B6F650", Offset = "0x2B6E050", VA = "0x182B6F650")]
		public static (Id32<KGMTAGLYNTP<ELLAOEGXNOQ>>, Id32<KGMTAGLYNTP<WUKPIZKJTLJ>>, Id32<KGMTAGLYNTP<BVTCYCWYPSS>>) EGBIAIZLVEB(this UnsafeList<byte> a, [Optional] int? b, [Optional] Id32<BVTCYCWYPSS>? c)
		{
			return default((Id32<KGMTAGLYNTP<ELLAOEGXNOQ>>, Id32<KGMTAGLYNTP<WUKPIZKJTLJ>>, Id32<KGMTAGLYNTP<BVTCYCWYPSS>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x2B6F800", Offset = "0x2B6E200", VA = "0x182B6F800")]
		public static (Id32<KGMTAGLYNTP<ELLAOEGXNOQ>>, Id32<KGMTAGLYNTP<WUKPIZKJTLJ>>, Id32<KGMTAGLYNTP<UTDLMYHANGH<BVTCYCWYPSS>>>) EKHWUVBILII(this UnsafeList<byte> a, [Optional] int? b, [Optional] Id32<UTDLMYHANGH<BVTCYCWYPSS>>? c)
		{
			return default((Id32<KGMTAGLYNTP<ELLAOEGXNOQ>>, Id32<KGMTAGLYNTP<WUKPIZKJTLJ>>, Id32<KGMTAGLYNTP<UTDLMYHANGH<BVTCYCWYPSS>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x3AF2980", Offset = "0x3AF1380", VA = "0x183AF2980")]
		public static (Id32<KGMTAGLYNTP<ELLAOEGXNOQ>>, Id32<KGMTAGLYNTP<FKAHYQVBHTH>>, Id32<KGMTAGLYNTP<WUKPIZKJTLJ>>, Id32<KGMTAGLYNTP<a>>) UNYMIPPOVTU<a>(this UnsafeList<byte> a, [Optional] Id32<FKAHYQVBHTH>? b, [Optional][In] ReadOnlySpan<byte> data)
		{
			return default((Id32<KGMTAGLYNTP<ELLAOEGXNOQ>>, Id32<KGMTAGLYNTP<FKAHYQVBHTH>>, Id32<KGMTAGLYNTP<WUKPIZKJTLJ>>, Id32<KGMTAGLYNTP<a>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x2B72A50", Offset = "0x2B71450", VA = "0x182B72A50")]
		public static (Id32<KGMTAGLYNTP<ELLAOEGXNOQ>>, Id32<KGMTAGLYNTP<WUKPIZKJTLJ>>, Id32<KGMTAGLYNTP<UTDLMYHANGH<WUKPIZKJTLJ>>>) TPPIXYLUFJS(this UnsafeList<byte> a, int b, [Optional] Id32<UTDLMYHANGH<WUKPIZKJTLJ>>? c)
		{
			return default((Id32<KGMTAGLYNTP<ELLAOEGXNOQ>>, Id32<KGMTAGLYNTP<WUKPIZKJTLJ>>, Id32<KGMTAGLYNTP<UTDLMYHANGH<WUKPIZKJTLJ>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x2B733B0", Offset = "0x2B71DB0", VA = "0x182B733B0")]
		public static (Id32<KGMTAGLYNTP<ELLAOEGXNOQ>>, Id32<KGMTAGLYNTP<UTDLMYHANGH<WUKPIZKJTLJ>>>, Id32<KGMTAGLYNTP<UTDLMYHANGH<WUKPIZKJTLJ>>>) WCXKFWJBDBR(this UnsafeList<byte> a, [Optional] Id32<UTDLMYHANGH<WUKPIZKJTLJ>>? b, [Optional] Id32<UTDLMYHANGH<WUKPIZKJTLJ>>? c)
		{
			return default((Id32<KGMTAGLYNTP<ELLAOEGXNOQ>>, Id32<KGMTAGLYNTP<UTDLMYHANGH<WUKPIZKJTLJ>>>, Id32<KGMTAGLYNTP<UTDLMYHANGH<WUKPIZKJTLJ>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x3AF2300", Offset = "0x3AF0D00", VA = "0x183AF2300")]
		public static (Id32<KGMTAGLYNTP<ELLAOEGXNOQ>>, Id32<KGMTAGLYNTP<UTDLMYHANGH<b>>>, Id32<KGMTAGLYNTP<WUKPIZKJTLJ>>, Id32<KGMTAGLYNTP<b>>) IEYHOKHGELG<b>(this UnsafeList<byte> a, [Optional] Id32<UTDLMYHANGH<b>>? b, [Optional] int? c, [Optional][In] ReadOnlySpan<byte> from)
		{
			return default((Id32<KGMTAGLYNTP<ELLAOEGXNOQ>>, Id32<KGMTAGLYNTP<UTDLMYHANGH<b>>>, Id32<KGMTAGLYNTP<WUKPIZKJTLJ>>, Id32<KGMTAGLYNTP<b>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x3AF2630", Offset = "0x3AF1030", VA = "0x183AF2630")]
		public static (Id32<KGMTAGLYNTP<ELLAOEGXNOQ>>, Id32<KGMTAGLYNTP<UTDLMYHANGH<c>>>, Id32<KGMTAGLYNTP<UTDLMYHANGH<c>>>, Id32<KGMTAGLYNTP<WUKPIZKJTLJ>>) TRIMDBDSSNN<c>(this UnsafeList<byte> a, [Optional] Id32<UTDLMYHANGH<c>>? b, [Optional] Id32<UTDLMYHANGH<c>>? c, [Optional] int? d)
		{
			return default((Id32<KGMTAGLYNTP<ELLAOEGXNOQ>>, Id32<KGMTAGLYNTP<UTDLMYHANGH<c>>>, Id32<KGMTAGLYNTP<UTDLMYHANGH<c>>>, Id32<KGMTAGLYNTP<WUKPIZKJTLJ>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x2B6F910", Offset = "0x2B6E310", VA = "0x182B6F910")]
		public static (Id32<KGMTAGLYNTP<ELLAOEGXNOQ>>, Id32<KGMTAGLYNTP<ZIFRBIBKQGK>>, Id32<KGMTAGLYNTP<ZIFRBIBKQGK>>, Id32<KGMTAGLYNTP<UTDLMYHANGH<ZIFRBIBKQGK>>>) ENVOXYFKKUQ(this UnsafeList<byte> a, float b, float c, [Optional] Id32<UTDLMYHANGH<ZIFRBIBKQGK>>? d)
		{
			return default((Id32<KGMTAGLYNTP<ELLAOEGXNOQ>>, Id32<KGMTAGLYNTP<ZIFRBIBKQGK>>, Id32<KGMTAGLYNTP<ZIFRBIBKQGK>>, Id32<KGMTAGLYNTP<UTDLMYHANGH<ZIFRBIBKQGK>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x2B71640", Offset = "0x2B70040", VA = "0x182B71640")]
		public static (Id32<KGMTAGLYNTP<ELLAOEGXNOQ>>, Id32<KGMTAGLYNTP<ZIFRBIBKQGK>>, Id32<KGMTAGLYNTP<UTDLMYHANGH<ZIFRBIBKQGK>>>, Id32<KGMTAGLYNTP<UTDLMYHANGH<ZIFRBIBKQGK>>>) NJCAGUMIKJN(this UnsafeList<byte> a, float b, [Optional] Id32<UTDLMYHANGH<ZIFRBIBKQGK>>? c, [Optional] Id32<UTDLMYHANGH<ZIFRBIBKQGK>>? d)
		{
			return default((Id32<KGMTAGLYNTP<ELLAOEGXNOQ>>, Id32<KGMTAGLYNTP<ZIFRBIBKQGK>>, Id32<KGMTAGLYNTP<UTDLMYHANGH<ZIFRBIBKQGK>>>, Id32<KGMTAGLYNTP<UTDLMYHANGH<ZIFRBIBKQGK>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x2B6F2C0", Offset = "0x2B6DCC0", VA = "0x182B6F2C0")]
		public static (Id32<KGMTAGLYNTP<ELLAOEGXNOQ>>, Id32<KGMTAGLYNTP<UTDLMYHANGH<ZIFRBIBKQGK>>>, Id32<KGMTAGLYNTP<UTDLMYHANGH<ZIFRBIBKQGK>>>, Id32<KGMTAGLYNTP<UTDLMYHANGH<ZIFRBIBKQGK>>>) CSKGYBVUMUO(this UnsafeList<byte> a, [Optional] Id32<UTDLMYHANGH<ZIFRBIBKQGK>>? b, [Optional] Id32<UTDLMYHANGH<ZIFRBIBKQGK>>? c, [Optional] Id32<UTDLMYHANGH<ZIFRBIBKQGK>>? d)
		{
			return default((Id32<KGMTAGLYNTP<ELLAOEGXNOQ>>, Id32<KGMTAGLYNTP<UTDLMYHANGH<ZIFRBIBKQGK>>>, Id32<KGMTAGLYNTP<UTDLMYHANGH<ZIFRBIBKQGK>>>, Id32<KGMTAGLYNTP<UTDLMYHANGH<ZIFRBIBKQGK>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x2B72F90", Offset = "0x2B71990", VA = "0x182B72F90")]
		public static (Id32<KGMTAGLYNTP<ELLAOEGXNOQ>>, Id32<KGMTAGLYNTP<WUKPIZKJTLJ>>, Id32<KGMTAGLYNTP<WUKPIZKJTLJ>>, Id32<KGMTAGLYNTP<UTDLMYHANGH<WUKPIZKJTLJ>>>) UHNMIYPTOHA(this UnsafeList<byte> a, int b, int c, [Optional] Id32<UTDLMYHANGH<WUKPIZKJTLJ>>? d)
		{
			return default((Id32<KGMTAGLYNTP<ELLAOEGXNOQ>>, Id32<KGMTAGLYNTP<WUKPIZKJTLJ>>, Id32<KGMTAGLYNTP<WUKPIZKJTLJ>>, Id32<KGMTAGLYNTP<UTDLMYHANGH<WUKPIZKJTLJ>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x2B6F3E0", Offset = "0x2B6DDE0", VA = "0x182B6F3E0")]
		public static (Id32<KGMTAGLYNTP<ELLAOEGXNOQ>>, Id32<KGMTAGLYNTP<WUKPIZKJTLJ>>, Id32<KGMTAGLYNTP<UTDLMYHANGH<WUKPIZKJTLJ>>>, Id32<KGMTAGLYNTP<UTDLMYHANGH<WUKPIZKJTLJ>>>) DXXYHEMWUIB(this UnsafeList<byte> a, int b, [Optional] Id32<UTDLMYHANGH<WUKPIZKJTLJ>>? c, [Optional] Id32<UTDLMYHANGH<WUKPIZKJTLJ>>? d)
		{
			return default((Id32<KGMTAGLYNTP<ELLAOEGXNOQ>>, Id32<KGMTAGLYNTP<WUKPIZKJTLJ>>, Id32<KGMTAGLYNTP<UTDLMYHANGH<WUKPIZKJTLJ>>>, Id32<KGMTAGLYNTP<UTDLMYHANGH<WUKPIZKJTLJ>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x2B70600", Offset = "0x2B6F000", VA = "0x182B70600")]
		public static (Id32<KGMTAGLYNTP<ELLAOEGXNOQ>>, Id32<KGMTAGLYNTP<UTDLMYHANGH<WUKPIZKJTLJ>>>, Id32<KGMTAGLYNTP<UTDLMYHANGH<WUKPIZKJTLJ>>>, Id32<KGMTAGLYNTP<UTDLMYHANGH<WUKPIZKJTLJ>>>) IHAITGOXFCY(this UnsafeList<byte> a, [Optional] Id32<UTDLMYHANGH<WUKPIZKJTLJ>>? b, [Optional] Id32<UTDLMYHANGH<WUKPIZKJTLJ>>? c, [Optional] Id32<UTDLMYHANGH<WUKPIZKJTLJ>>? d)
		{
			return default((Id32<KGMTAGLYNTP<ELLAOEGXNOQ>>, Id32<KGMTAGLYNTP<UTDLMYHANGH<WUKPIZKJTLJ>>>, Id32<KGMTAGLYNTP<UTDLMYHANGH<WUKPIZKJTLJ>>>, Id32<KGMTAGLYNTP<UTDLMYHANGH<WUKPIZKJTLJ>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x2B6E680", Offset = "0x2B6D080", VA = "0x182B6E680")]
		public static (Id32<KGMTAGLYNTP<ELLAOEGXNOQ>>, Id32<KGMTAGLYNTP<WUKPIZKJTLJ>>, Id32<KGMTAGLYNTP<WUKPIZKJTLJ>>, Id32<KGMTAGLYNTP<UTDLMYHANGH<WUKPIZKJTLJ>>>) AEGETHUQNUT(this UnsafeList<byte> a, int b, int c, [Optional] Id32<UTDLMYHANGH<WUKPIZKJTLJ>>? d)
		{
			return default((Id32<KGMTAGLYNTP<ELLAOEGXNOQ>>, Id32<KGMTAGLYNTP<WUKPIZKJTLJ>>, Id32<KGMTAGLYNTP<WUKPIZKJTLJ>>, Id32<KGMTAGLYNTP<UTDLMYHANGH<WUKPIZKJTLJ>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x2B73C50", Offset = "0x2B72650", VA = "0x182B73C50")]
		public static (Id32<KGMTAGLYNTP<ELLAOEGXNOQ>>, Id32<KGMTAGLYNTP<WUKPIZKJTLJ>>, Id32<KGMTAGLYNTP<UTDLMYHANGH<WUKPIZKJTLJ>>>, Id32<KGMTAGLYNTP<UTDLMYHANGH<WUKPIZKJTLJ>>>) XQYDLJXJQCU(this UnsafeList<byte> a, int b, [Optional] Id32<UTDLMYHANGH<WUKPIZKJTLJ>>? c, [Optional] Id32<UTDLMYHANGH<WUKPIZKJTLJ>>? d)
		{
			return default((Id32<KGMTAGLYNTP<ELLAOEGXNOQ>>, Id32<KGMTAGLYNTP<WUKPIZKJTLJ>>, Id32<KGMTAGLYNTP<UTDLMYHANGH<WUKPIZKJTLJ>>>, Id32<KGMTAGLYNTP<UTDLMYHANGH<WUKPIZKJTLJ>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x2B72120", Offset = "0x2B70B20", VA = "0x182B72120")]
		public static (Id32<KGMTAGLYNTP<ELLAOEGXNOQ>>, Id32<KGMTAGLYNTP<UTDLMYHANGH<WUKPIZKJTLJ>>>, Id32<KGMTAGLYNTP<UTDLMYHANGH<WUKPIZKJTLJ>>>, Id32<KGMTAGLYNTP<UTDLMYHANGH<WUKPIZKJTLJ>>>) PKZCTRFWENH(this UnsafeList<byte> a, [Optional] Id32<UTDLMYHANGH<WUKPIZKJTLJ>>? b, [Optional] Id32<UTDLMYHANGH<WUKPIZKJTLJ>>? c, [Optional] Id32<UTDLMYHANGH<WUKPIZKJTLJ>>? d)
		{
			return default((Id32<KGMTAGLYNTP<ELLAOEGXNOQ>>, Id32<KGMTAGLYNTP<UTDLMYHANGH<WUKPIZKJTLJ>>>, Id32<KGMTAGLYNTP<UTDLMYHANGH<WUKPIZKJTLJ>>>, Id32<KGMTAGLYNTP<UTDLMYHANGH<WUKPIZKJTLJ>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x2B72030", Offset = "0x2B70A30", VA = "0x182B72030")]
		public static (Id32<KGMTAGLYNTP<ELLAOEGXNOQ>>, Id32<KGMTAGLYNTP<KGMTAGLYNTP<ELLAOEGXNOQ>>>) OPCTOHDOGOM(this UnsafeList<byte> a, [Optional] Id32<KGMTAGLYNTP<ELLAOEGXNOQ>>? b)
		{
			return default((Id32<KGMTAGLYNTP<ELLAOEGXNOQ>>, Id32<KGMTAGLYNTP<KGMTAGLYNTP<ELLAOEGXNOQ>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x2B6E7E0", Offset = "0x2B6D1E0", VA = "0x182B6E7E0")]
		public static (Id32<KGMTAGLYNTP<ELLAOEGXNOQ>>, Id32<KGMTAGLYNTP<ZIFRBIBKQGK>>, Id32<KGMTAGLYNTP<ZIFRBIBKQGK>>, Id32<KGMTAGLYNTP<UTDLMYHANGH<WUKPIZKJTLJ>>>) AEPGCVKICGE(this UnsafeList<byte> a, float b, float c, [Optional] Id32<UTDLMYHANGH<WUKPIZKJTLJ>>? d)
		{
			return default((Id32<KGMTAGLYNTP<ELLAOEGXNOQ>>, Id32<KGMTAGLYNTP<ZIFRBIBKQGK>>, Id32<KGMTAGLYNTP<ZIFRBIBKQGK>>, Id32<KGMTAGLYNTP<UTDLMYHANGH<WUKPIZKJTLJ>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x2B718B0", Offset = "0x2B702B0", VA = "0x182B718B0")]
		public static (Id32<KGMTAGLYNTP<ELLAOEGXNOQ>>, Id32<KGMTAGLYNTP<ZIFRBIBKQGK>>, Id32<KGMTAGLYNTP<UTDLMYHANGH<ZIFRBIBKQGK>>>, Id32<KGMTAGLYNTP<UTDLMYHANGH<WUKPIZKJTLJ>>>) NMVZUURZKPB(this UnsafeList<byte> a, float b, [Optional] Id32<UTDLMYHANGH<ZIFRBIBKQGK>>? c, [Optional] Id32<UTDLMYHANGH<WUKPIZKJTLJ>>? d)
		{
			return default((Id32<KGMTAGLYNTP<ELLAOEGXNOQ>>, Id32<KGMTAGLYNTP<ZIFRBIBKQGK>>, Id32<KGMTAGLYNTP<UTDLMYHANGH<ZIFRBIBKQGK>>>, Id32<KGMTAGLYNTP<UTDLMYHANGH<WUKPIZKJTLJ>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x2B71000", Offset = "0x2B6FA00", VA = "0x182B71000")]
		public static (Id32<KGMTAGLYNTP<ELLAOEGXNOQ>>, Id32<KGMTAGLYNTP<UTDLMYHANGH<ZIFRBIBKQGK>>>, Id32<KGMTAGLYNTP<UTDLMYHANGH<ZIFRBIBKQGK>>>, Id32<KGMTAGLYNTP<UTDLMYHANGH<WUKPIZKJTLJ>>>) MMHQLQDJXFU(this UnsafeList<byte> a, [Optional] Id32<UTDLMYHANGH<ZIFRBIBKQGK>>? b, [Optional] Id32<UTDLMYHANGH<ZIFRBIBKQGK>>? c, [Optional] Id32<UTDLMYHANGH<WUKPIZKJTLJ>>? d)
		{
			return default((Id32<KGMTAGLYNTP<ELLAOEGXNOQ>>, Id32<KGMTAGLYNTP<UTDLMYHANGH<ZIFRBIBKQGK>>>, Id32<KGMTAGLYNTP<UTDLMYHANGH<ZIFRBIBKQGK>>>, Id32<KGMTAGLYNTP<UTDLMYHANGH<WUKPIZKJTLJ>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x2B73250", Offset = "0x2B71C50", VA = "0x182B73250")]
		public static (Id32<KGMTAGLYNTP<ELLAOEGXNOQ>>, Id32<KGMTAGLYNTP<WUKPIZKJTLJ>>, Id32<KGMTAGLYNTP<WUKPIZKJTLJ>>, Id32<KGMTAGLYNTP<UTDLMYHANGH<WUKPIZKJTLJ>>>) VJJNHDEIGVL(this UnsafeList<byte> a, int b, int c, [Optional] Id32<UTDLMYHANGH<WUKPIZKJTLJ>>? d)
		{
			return default((Id32<KGMTAGLYNTP<ELLAOEGXNOQ>>, Id32<KGMTAGLYNTP<WUKPIZKJTLJ>>, Id32<KGMTAGLYNTP<WUKPIZKJTLJ>>, Id32<KGMTAGLYNTP<UTDLMYHANGH<WUKPIZKJTLJ>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x2B6FA90", Offset = "0x2B6E490", VA = "0x182B6FA90")]
		public static (Id32<KGMTAGLYNTP<ELLAOEGXNOQ>>, Id32<KGMTAGLYNTP<WUKPIZKJTLJ>>, Id32<KGMTAGLYNTP<UTDLMYHANGH<WUKPIZKJTLJ>>>, Id32<KGMTAGLYNTP<UTDLMYHANGH<WUKPIZKJTLJ>>>) EXACKMWKZBM(this UnsafeList<byte> a, int b, [Optional] Id32<UTDLMYHANGH<WUKPIZKJTLJ>>? c, [Optional] Id32<UTDLMYHANGH<WUKPIZKJTLJ>>? d)
		{
			return default((Id32<KGMTAGLYNTP<ELLAOEGXNOQ>>, Id32<KGMTAGLYNTP<WUKPIZKJTLJ>>, Id32<KGMTAGLYNTP<UTDLMYHANGH<WUKPIZKJTLJ>>>, Id32<KGMTAGLYNTP<UTDLMYHANGH<WUKPIZKJTLJ>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x2B70380", Offset = "0x2B6ED80", VA = "0x182B70380")]
		public static (Id32<KGMTAGLYNTP<ELLAOEGXNOQ>>, Id32<KGMTAGLYNTP<UTDLMYHANGH<WUKPIZKJTLJ>>>, Id32<KGMTAGLYNTP<UTDLMYHANGH<WUKPIZKJTLJ>>>, Id32<KGMTAGLYNTP<UTDLMYHANGH<WUKPIZKJTLJ>>>) HREIOIUMEMP(this UnsafeList<byte> a, [Optional] Id32<UTDLMYHANGH<WUKPIZKJTLJ>>? b, [Optional] Id32<UTDLMYHANGH<WUKPIZKJTLJ>>? c, [Optional] Id32<UTDLMYHANGH<WUKPIZKJTLJ>>? d)
		{
			return default((Id32<KGMTAGLYNTP<ELLAOEGXNOQ>>, Id32<KGMTAGLYNTP<UTDLMYHANGH<WUKPIZKJTLJ>>>, Id32<KGMTAGLYNTP<UTDLMYHANGH<WUKPIZKJTLJ>>>, Id32<KGMTAGLYNTP<UTDLMYHANGH<WUKPIZKJTLJ>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x2B73740", Offset = "0x2B72140", VA = "0x182B73740")]
		public static (Id32<KGMTAGLYNTP<ELLAOEGXNOQ>>, Id32<KGMTAGLYNTP<ZIFRBIBKQGK>>, Id32<KGMTAGLYNTP<ZIFRBIBKQGK>>, Id32<KGMTAGLYNTP<UTDLMYHANGH<WUKPIZKJTLJ>>>) WOQAUPJEZET(this UnsafeList<byte> a, float b, float c, [Optional] Id32<UTDLMYHANGH<WUKPIZKJTLJ>>? d)
		{
			return default((Id32<KGMTAGLYNTP<ELLAOEGXNOQ>>, Id32<KGMTAGLYNTP<ZIFRBIBKQGK>>, Id32<KGMTAGLYNTP<ZIFRBIBKQGK>>, Id32<KGMTAGLYNTP<UTDLMYHANGH<WUKPIZKJTLJ>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x2B730F0", Offset = "0x2B71AF0", VA = "0x182B730F0")]
		public static (Id32<KGMTAGLYNTP<ELLAOEGXNOQ>>, Id32<KGMTAGLYNTP<ZIFRBIBKQGK>>, Id32<KGMTAGLYNTP<UTDLMYHANGH<ZIFRBIBKQGK>>>, Id32<KGMTAGLYNTP<UTDLMYHANGH<WUKPIZKJTLJ>>>) UZDBQJOQIIQ(this UnsafeList<byte> a, float b, [Optional] Id32<UTDLMYHANGH<ZIFRBIBKQGK>>? c, [Optional] Id32<UTDLMYHANGH<WUKPIZKJTLJ>>? d)
		{
			return default((Id32<KGMTAGLYNTP<ELLAOEGXNOQ>>, Id32<KGMTAGLYNTP<ZIFRBIBKQGK>>, Id32<KGMTAGLYNTP<UTDLMYHANGH<ZIFRBIBKQGK>>>, Id32<KGMTAGLYNTP<UTDLMYHANGH<WUKPIZKJTLJ>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x2B72360", Offset = "0x2B70D60", VA = "0x182B72360")]
		public static (Id32<KGMTAGLYNTP<ELLAOEGXNOQ>>, Id32<KGMTAGLYNTP<UTDLMYHANGH<ZIFRBIBKQGK>>>, Id32<KGMTAGLYNTP<UTDLMYHANGH<ZIFRBIBKQGK>>>, Id32<KGMTAGLYNTP<UTDLMYHANGH<WUKPIZKJTLJ>>>) PRHZXGVJCFH(this UnsafeList<byte> a, [Optional] Id32<UTDLMYHANGH<ZIFRBIBKQGK>>? b, [Optional] Id32<UTDLMYHANGH<ZIFRBIBKQGK>>? c, [Optional] Id32<UTDLMYHANGH<WUKPIZKJTLJ>>? d)
		{
			return default((Id32<KGMTAGLYNTP<ELLAOEGXNOQ>>, Id32<KGMTAGLYNTP<UTDLMYHANGH<ZIFRBIBKQGK>>>, Id32<KGMTAGLYNTP<UTDLMYHANGH<ZIFRBIBKQGK>>>, Id32<KGMTAGLYNTP<UTDLMYHANGH<WUKPIZKJTLJ>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x2B734C0", Offset = "0x2B71EC0", VA = "0x182B734C0")]
		public static (Id32<KGMTAGLYNTP<ELLAOEGXNOQ>>, Id32<KGMTAGLYNTP<WUKPIZKJTLJ>>, Id32<KGMTAGLYNTP<WUKPIZKJTLJ>>, Id32<KGMTAGLYNTP<UTDLMYHANGH<WUKPIZKJTLJ>>>) WKEBRYGQLTU(this UnsafeList<byte> a, int b, int c, [Optional] Id32<UTDLMYHANGH<WUKPIZKJTLJ>>? d)
		{
			return default((Id32<KGMTAGLYNTP<ELLAOEGXNOQ>>, Id32<KGMTAGLYNTP<WUKPIZKJTLJ>>, Id32<KGMTAGLYNTP<WUKPIZKJTLJ>>, Id32<KGMTAGLYNTP<UTDLMYHANGH<WUKPIZKJTLJ>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x2B70EB0", Offset = "0x2B6F8B0", VA = "0x182B70EB0")]
		public static (Id32<KGMTAGLYNTP<ELLAOEGXNOQ>>, Id32<KGMTAGLYNTP<WUKPIZKJTLJ>>, Id32<KGMTAGLYNTP<UTDLMYHANGH<WUKPIZKJTLJ>>>, Id32<KGMTAGLYNTP<UTDLMYHANGH<WUKPIZKJTLJ>>>) MASKQPIPAUZ(this UnsafeList<byte> a, int b, [Optional] Id32<UTDLMYHANGH<WUKPIZKJTLJ>>? c, [Optional] Id32<UTDLMYHANGH<WUKPIZKJTLJ>>? d)
		{
			return default((Id32<KGMTAGLYNTP<ELLAOEGXNOQ>>, Id32<KGMTAGLYNTP<WUKPIZKJTLJ>>, Id32<KGMTAGLYNTP<UTDLMYHANGH<WUKPIZKJTLJ>>>, Id32<KGMTAGLYNTP<UTDLMYHANGH<WUKPIZKJTLJ>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x2B71F10", Offset = "0x2B70910", VA = "0x182B71F10")]
		public static (Id32<KGMTAGLYNTP<ELLAOEGXNOQ>>, Id32<KGMTAGLYNTP<UTDLMYHANGH<WUKPIZKJTLJ>>>, Id32<KGMTAGLYNTP<UTDLMYHANGH<WUKPIZKJTLJ>>>, Id32<KGMTAGLYNTP<UTDLMYHANGH<WUKPIZKJTLJ>>>) OMPSACJGJGQ(this UnsafeList<byte> a, [Optional] Id32<UTDLMYHANGH<WUKPIZKJTLJ>>? b, [Optional] Id32<UTDLMYHANGH<WUKPIZKJTLJ>>? c, [Optional] Id32<UTDLMYHANGH<WUKPIZKJTLJ>>? d)
		{
			return default((Id32<KGMTAGLYNTP<ELLAOEGXNOQ>>, Id32<KGMTAGLYNTP<UTDLMYHANGH<WUKPIZKJTLJ>>>, Id32<KGMTAGLYNTP<UTDLMYHANGH<WUKPIZKJTLJ>>>, Id32<KGMTAGLYNTP<UTDLMYHANGH<WUKPIZKJTLJ>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x2B6FE50", Offset = "0x2B6E850", VA = "0x182B6FE50")]
		public static (Id32<KGMTAGLYNTP<ELLAOEGXNOQ>>, Id32<KGMTAGLYNTP<ZIFRBIBKQGK>>, Id32<KGMTAGLYNTP<ZIFRBIBKQGK>>, Id32<KGMTAGLYNTP<UTDLMYHANGH<WUKPIZKJTLJ>>>) FRYIJCBIATJ(this UnsafeList<byte> a, float b, float c, [Optional] Id32<UTDLMYHANGH<WUKPIZKJTLJ>>? d)
		{
			return default((Id32<KGMTAGLYNTP<ELLAOEGXNOQ>>, Id32<KGMTAGLYNTP<ZIFRBIBKQGK>>, Id32<KGMTAGLYNTP<ZIFRBIBKQGK>>, Id32<KGMTAGLYNTP<UTDLMYHANGH<WUKPIZKJTLJ>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x2B72B80", Offset = "0x2B71580", VA = "0x182B72B80")]
		public static (Id32<KGMTAGLYNTP<ELLAOEGXNOQ>>, Id32<KGMTAGLYNTP<ZIFRBIBKQGK>>, Id32<KGMTAGLYNTP<UTDLMYHANGH<ZIFRBIBKQGK>>>, Id32<KGMTAGLYNTP<UTDLMYHANGH<WUKPIZKJTLJ>>>) TXPUMITBSEA(this UnsafeList<byte> a, float b, [Optional] Id32<UTDLMYHANGH<ZIFRBIBKQGK>>? c, [Optional] Id32<UTDLMYHANGH<WUKPIZKJTLJ>>? d)
		{
			return default((Id32<KGMTAGLYNTP<ELLAOEGXNOQ>>, Id32<KGMTAGLYNTP<ZIFRBIBKQGK>>, Id32<KGMTAGLYNTP<UTDLMYHANGH<ZIFRBIBKQGK>>>, Id32<KGMTAGLYNTP<UTDLMYHANGH<WUKPIZKJTLJ>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x2B70720", Offset = "0x2B6F120", VA = "0x182B70720")]
		public static (Id32<KGMTAGLYNTP<ELLAOEGXNOQ>>, Id32<KGMTAGLYNTP<UTDLMYHANGH<ZIFRBIBKQGK>>>, Id32<KGMTAGLYNTP<UTDLMYHANGH<ZIFRBIBKQGK>>>, Id32<KGMTAGLYNTP<UTDLMYHANGH<WUKPIZKJTLJ>>>) JZULWUHZRMN(this UnsafeList<byte> a, [Optional] Id32<UTDLMYHANGH<ZIFRBIBKQGK>>? b, [Optional] Id32<UTDLMYHANGH<ZIFRBIBKQGK>>? c, [Optional] Id32<UTDLMYHANGH<WUKPIZKJTLJ>>? d)
		{
			return default((Id32<KGMTAGLYNTP<ELLAOEGXNOQ>>, Id32<KGMTAGLYNTP<UTDLMYHANGH<ZIFRBIBKQGK>>>, Id32<KGMTAGLYNTP<UTDLMYHANGH<ZIFRBIBKQGK>>>, Id32<KGMTAGLYNTP<UTDLMYHANGH<WUKPIZKJTLJ>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x2B73AF0", Offset = "0x2B724F0", VA = "0x182B73AF0")]
		public static (Id32<KGMTAGLYNTP<ELLAOEGXNOQ>>, Id32<KGMTAGLYNTP<WUKPIZKJTLJ>>, Id32<KGMTAGLYNTP<WUKPIZKJTLJ>>, Id32<KGMTAGLYNTP<UTDLMYHANGH<WUKPIZKJTLJ>>>) XPTSSTMQIOK(this UnsafeList<byte> a, int b, int c, [Optional] Id32<UTDLMYHANGH<WUKPIZKJTLJ>>? d)
		{
			return default((Id32<KGMTAGLYNTP<ELLAOEGXNOQ>>, Id32<KGMTAGLYNTP<WUKPIZKJTLJ>>, Id32<KGMTAGLYNTP<WUKPIZKJTLJ>>, Id32<KGMTAGLYNTP<UTDLMYHANGH<WUKPIZKJTLJ>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x2B72730", Offset = "0x2B71130", VA = "0x182B72730")]
		public static (Id32<KGMTAGLYNTP<ELLAOEGXNOQ>>, Id32<KGMTAGLYNTP<WUKPIZKJTLJ>>, Id32<KGMTAGLYNTP<UTDLMYHANGH<WUKPIZKJTLJ>>>, Id32<KGMTAGLYNTP<UTDLMYHANGH<WUKPIZKJTLJ>>>) ROXJYNBIYSN(this UnsafeList<byte> a, int b, [Optional] Id32<UTDLMYHANGH<WUKPIZKJTLJ>>? c, [Optional] Id32<UTDLMYHANGH<WUKPIZKJTLJ>>? d)
		{
			return default((Id32<KGMTAGLYNTP<ELLAOEGXNOQ>>, Id32<KGMTAGLYNTP<WUKPIZKJTLJ>>, Id32<KGMTAGLYNTP<UTDLMYHANGH<WUKPIZKJTLJ>>>, Id32<KGMTAGLYNTP<UTDLMYHANGH<WUKPIZKJTLJ>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x2B72240", Offset = "0x2B70C40", VA = "0x182B72240")]
		public static (Id32<KGMTAGLYNTP<ELLAOEGXNOQ>>, Id32<KGMTAGLYNTP<UTDLMYHANGH<WUKPIZKJTLJ>>>, Id32<KGMTAGLYNTP<UTDLMYHANGH<WUKPIZKJTLJ>>>, Id32<KGMTAGLYNTP<UTDLMYHANGH<WUKPIZKJTLJ>>>) PQFYDWQVLHO(this UnsafeList<byte> a, [Optional] Id32<UTDLMYHANGH<WUKPIZKJTLJ>>? b, [Optional] Id32<UTDLMYHANGH<WUKPIZKJTLJ>>? c, [Optional] Id32<UTDLMYHANGH<WUKPIZKJTLJ>>? d)
		{
			return default((Id32<KGMTAGLYNTP<ELLAOEGXNOQ>>, Id32<KGMTAGLYNTP<UTDLMYHANGH<WUKPIZKJTLJ>>>, Id32<KGMTAGLYNTP<UTDLMYHANGH<WUKPIZKJTLJ>>>, Id32<KGMTAGLYNTP<UTDLMYHANGH<WUKPIZKJTLJ>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x2B725B0", Offset = "0x2B70FB0", VA = "0x182B725B0")]
		public static (Id32<KGMTAGLYNTP<ELLAOEGXNOQ>>, Id32<KGMTAGLYNTP<ZIFRBIBKQGK>>, Id32<KGMTAGLYNTP<ZIFRBIBKQGK>>, Id32<KGMTAGLYNTP<UTDLMYHANGH<WUKPIZKJTLJ>>>) QUDNUTTPJZA(this UnsafeList<byte> a, float b, float c, [Optional] Id32<UTDLMYHANGH<WUKPIZKJTLJ>>? d)
		{
			return default((Id32<KGMTAGLYNTP<ELLAOEGXNOQ>>, Id32<KGMTAGLYNTP<ZIFRBIBKQGK>>, Id32<KGMTAGLYNTP<ZIFRBIBKQGK>>, Id32<KGMTAGLYNTP<UTDLMYHANGH<WUKPIZKJTLJ>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x2B71A10", Offset = "0x2B70410", VA = "0x182B71A10")]
		public static (Id32<KGMTAGLYNTP<ELLAOEGXNOQ>>, Id32<KGMTAGLYNTP<ZIFRBIBKQGK>>, Id32<KGMTAGLYNTP<UTDLMYHANGH<ZIFRBIBKQGK>>>, Id32<KGMTAGLYNTP<UTDLMYHANGH<WUKPIZKJTLJ>>>) NQHSCUJNNMN(this UnsafeList<byte> a, float b, [Optional] Id32<UTDLMYHANGH<ZIFRBIBKQGK>>? c, [Optional] Id32<UTDLMYHANGH<WUKPIZKJTLJ>>? d)
		{
			return default((Id32<KGMTAGLYNTP<ELLAOEGXNOQ>>, Id32<KGMTAGLYNTP<ZIFRBIBKQGK>>, Id32<KGMTAGLYNTP<UTDLMYHANGH<ZIFRBIBKQGK>>>, Id32<KGMTAGLYNTP<UTDLMYHANGH<WUKPIZKJTLJ>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x2B6F010", Offset = "0x2B6DA10", VA = "0x182B6F010")]
		public static (Id32<KGMTAGLYNTP<ELLAOEGXNOQ>>, Id32<KGMTAGLYNTP<UTDLMYHANGH<ZIFRBIBKQGK>>>, Id32<KGMTAGLYNTP<UTDLMYHANGH<ZIFRBIBKQGK>>>, Id32<KGMTAGLYNTP<UTDLMYHANGH<WUKPIZKJTLJ>>>) BGFLNLHVLJK(this UnsafeList<byte> a, [Optional] Id32<UTDLMYHANGH<ZIFRBIBKQGK>>? b, [Optional] Id32<UTDLMYHANGH<ZIFRBIBKQGK>>? c, [Optional] Id32<UTDLMYHANGH<WUKPIZKJTLJ>>? d)
		{
			return default((Id32<KGMTAGLYNTP<ELLAOEGXNOQ>>, Id32<KGMTAGLYNTP<UTDLMYHANGH<ZIFRBIBKQGK>>>, Id32<KGMTAGLYNTP<UTDLMYHANGH<ZIFRBIBKQGK>>>, Id32<KGMTAGLYNTP<UTDLMYHANGH<WUKPIZKJTLJ>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x2B71B70", Offset = "0x2B70570", VA = "0x182B71B70")]
		public static (Id32<KGMTAGLYNTP<ELLAOEGXNOQ>>, Id32<KGMTAGLYNTP<WUKPIZKJTLJ>>, Id32<KGMTAGLYNTP<WUKPIZKJTLJ>>, Id32<KGMTAGLYNTP<UTDLMYHANGH<WUKPIZKJTLJ>>>) OFHCJBOAQKL(this UnsafeList<byte> a, int b, int c, [Optional] Id32<UTDLMYHANGH<WUKPIZKJTLJ>>? d)
		{
			return default((Id32<KGMTAGLYNTP<ELLAOEGXNOQ>>, Id32<KGMTAGLYNTP<WUKPIZKJTLJ>>, Id32<KGMTAGLYNTP<WUKPIZKJTLJ>>, Id32<KGMTAGLYNTP<UTDLMYHANGH<WUKPIZKJTLJ>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x2B71130", Offset = "0x2B6FB30", VA = "0x182B71130")]
		public static (Id32<KGMTAGLYNTP<ELLAOEGXNOQ>>, Id32<KGMTAGLYNTP<WUKPIZKJTLJ>>, Id32<KGMTAGLYNTP<UTDLMYHANGH<WUKPIZKJTLJ>>>, Id32<KGMTAGLYNTP<UTDLMYHANGH<WUKPIZKJTLJ>>>) MPUDEVTLZOI(this UnsafeList<byte> a, int b, [Optional] Id32<UTDLMYHANGH<WUKPIZKJTLJ>>? c, [Optional] Id32<UTDLMYHANGH<WUKPIZKJTLJ>>? d)
		{
			return default((Id32<KGMTAGLYNTP<ELLAOEGXNOQ>>, Id32<KGMTAGLYNTP<WUKPIZKJTLJ>>, Id32<KGMTAGLYNTP<UTDLMYHANGH<WUKPIZKJTLJ>>>, Id32<KGMTAGLYNTP<UTDLMYHANGH<WUKPIZKJTLJ>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x2B72490", Offset = "0x2B70E90", VA = "0x182B72490")]
		public static (Id32<KGMTAGLYNTP<ELLAOEGXNOQ>>, Id32<KGMTAGLYNTP<UTDLMYHANGH<WUKPIZKJTLJ>>>, Id32<KGMTAGLYNTP<UTDLMYHANGH<WUKPIZKJTLJ>>>, Id32<KGMTAGLYNTP<UTDLMYHANGH<WUKPIZKJTLJ>>>) PSMZTOWXTLH(this UnsafeList<byte> a, [Optional] Id32<UTDLMYHANGH<WUKPIZKJTLJ>>? b, [Optional] Id32<UTDLMYHANGH<WUKPIZKJTLJ>>? c, [Optional] Id32<UTDLMYHANGH<WUKPIZKJTLJ>>? d)
		{
			return default((Id32<KGMTAGLYNTP<ELLAOEGXNOQ>>, Id32<KGMTAGLYNTP<UTDLMYHANGH<WUKPIZKJTLJ>>>, Id32<KGMTAGLYNTP<UTDLMYHANGH<WUKPIZKJTLJ>>>, Id32<KGMTAGLYNTP<UTDLMYHANGH<WUKPIZKJTLJ>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x2B6F140", Offset = "0x2B6DB40", VA = "0x182B6F140")]
		public static (Id32<KGMTAGLYNTP<ELLAOEGXNOQ>>, Id32<KGMTAGLYNTP<ZIFRBIBKQGK>>, Id32<KGMTAGLYNTP<ZIFRBIBKQGK>>, Id32<KGMTAGLYNTP<UTDLMYHANGH<ZIFRBIBKQGK>>>) CSIEZMWFUOV(this UnsafeList<byte> a, float b, float c, [Optional] Id32<UTDLMYHANGH<ZIFRBIBKQGK>>? d)
		{
			return default((Id32<KGMTAGLYNTP<ELLAOEGXNOQ>>, Id32<KGMTAGLYNTP<ZIFRBIBKQGK>>, Id32<KGMTAGLYNTP<ZIFRBIBKQGK>>, Id32<KGMTAGLYNTP<UTDLMYHANGH<ZIFRBIBKQGK>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x2B6FD00", Offset = "0x2B6E700", VA = "0x182B6FD00")]
		public static (Id32<KGMTAGLYNTP<ELLAOEGXNOQ>>, Id32<KGMTAGLYNTP<ZIFRBIBKQGK>>, Id32<KGMTAGLYNTP<UTDLMYHANGH<ZIFRBIBKQGK>>>, Id32<KGMTAGLYNTP<UTDLMYHANGH<ZIFRBIBKQGK>>>) FGXPYGRZSUG(this UnsafeList<byte> a, float b, [Optional] Id32<UTDLMYHANGH<ZIFRBIBKQGK>>? c, [Optional] Id32<UTDLMYHANGH<ZIFRBIBKQGK>>? d)
		{
			return default((Id32<KGMTAGLYNTP<ELLAOEGXNOQ>>, Id32<KGMTAGLYNTP<ZIFRBIBKQGK>>, Id32<KGMTAGLYNTP<UTDLMYHANGH<ZIFRBIBKQGK>>>, Id32<KGMTAGLYNTP<UTDLMYHANGH<ZIFRBIBKQGK>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x2B71CD0", Offset = "0x2B706D0", VA = "0x182B71CD0")]
		public static (Id32<KGMTAGLYNTP<ELLAOEGXNOQ>>, Id32<KGMTAGLYNTP<UTDLMYHANGH<ZIFRBIBKQGK>>>, Id32<KGMTAGLYNTP<UTDLMYHANGH<ZIFRBIBKQGK>>>, Id32<KGMTAGLYNTP<UTDLMYHANGH<ZIFRBIBKQGK>>>) OIESXIUKQSD(this UnsafeList<byte> a, [Optional] Id32<UTDLMYHANGH<ZIFRBIBKQGK>>? b, [Optional] Id32<UTDLMYHANGH<ZIFRBIBKQGK>>? c, [Optional] Id32<UTDLMYHANGH<ZIFRBIBKQGK>>? d)
		{
			return default((Id32<KGMTAGLYNTP<ELLAOEGXNOQ>>, Id32<KGMTAGLYNTP<UTDLMYHANGH<ZIFRBIBKQGK>>>, Id32<KGMTAGLYNTP<UTDLMYHANGH<ZIFRBIBKQGK>>>, Id32<KGMTAGLYNTP<UTDLMYHANGH<ZIFRBIBKQGK>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x2B714E0", Offset = "0x2B6FEE0", VA = "0x182B714E0")]
		public static (Id32<KGMTAGLYNTP<ELLAOEGXNOQ>>, Id32<KGMTAGLYNTP<WUKPIZKJTLJ>>, Id32<KGMTAGLYNTP<WUKPIZKJTLJ>>, Id32<KGMTAGLYNTP<UTDLMYHANGH<WUKPIZKJTLJ>>>) MYRPAKONBHF(this UnsafeList<byte> a, int b, int c, [Optional] Id32<UTDLMYHANGH<WUKPIZKJTLJ>>? d)
		{
			return default((Id32<KGMTAGLYNTP<ELLAOEGXNOQ>>, Id32<KGMTAGLYNTP<WUKPIZKJTLJ>>, Id32<KGMTAGLYNTP<WUKPIZKJTLJ>>, Id32<KGMTAGLYNTP<UTDLMYHANGH<WUKPIZKJTLJ>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x2B6EEC0", Offset = "0x2B6D8C0", VA = "0x182B6EEC0")]
		public static (Id32<KGMTAGLYNTP<ELLAOEGXNOQ>>, Id32<KGMTAGLYNTP<WUKPIZKJTLJ>>, Id32<KGMTAGLYNTP<UTDLMYHANGH<WUKPIZKJTLJ>>>, Id32<KGMTAGLYNTP<UTDLMYHANGH<WUKPIZKJTLJ>>>) BEJBDRGGSRW(this UnsafeList<byte> a, int b, [Optional] Id32<UTDLMYHANGH<WUKPIZKJTLJ>>? c, [Optional] Id32<UTDLMYHANGH<WUKPIZKJTLJ>>? d)
		{
			return default((Id32<KGMTAGLYNTP<ELLAOEGXNOQ>>, Id32<KGMTAGLYNTP<WUKPIZKJTLJ>>, Id32<KGMTAGLYNTP<UTDLMYHANGH<WUKPIZKJTLJ>>>, Id32<KGMTAGLYNTP<UTDLMYHANGH<WUKPIZKJTLJ>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x2B6F530", Offset = "0x2B6DF30", VA = "0x182B6F530")]
		public static (Id32<KGMTAGLYNTP<ELLAOEGXNOQ>>, Id32<KGMTAGLYNTP<UTDLMYHANGH<WUKPIZKJTLJ>>>, Id32<KGMTAGLYNTP<UTDLMYHANGH<WUKPIZKJTLJ>>>, Id32<KGMTAGLYNTP<UTDLMYHANGH<WUKPIZKJTLJ>>>) DYKEOTJQTSR(this UnsafeList<byte> a, [Optional] Id32<UTDLMYHANGH<WUKPIZKJTLJ>>? b, [Optional] Id32<UTDLMYHANGH<WUKPIZKJTLJ>>? c, [Optional] Id32<UTDLMYHANGH<WUKPIZKJTLJ>>? d)
		{
			return default((Id32<KGMTAGLYNTP<ELLAOEGXNOQ>>, Id32<KGMTAGLYNTP<UTDLMYHANGH<WUKPIZKJTLJ>>>, Id32<KGMTAGLYNTP<UTDLMYHANGH<WUKPIZKJTLJ>>>, Id32<KGMTAGLYNTP<UTDLMYHANGH<WUKPIZKJTLJ>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x2B71280", Offset = "0x2B6FC80", VA = "0x182B71280")]
		public static (Id32<KGMTAGLYNTP<ELLAOEGXNOQ>>, Id32<KGMTAGLYNTP<WUKPIZKJTLJ>>, Id32<KGMTAGLYNTP<UTDLMYHANGH<WUKPIZKJTLJ>>>) MUZYBTAJBEI(this UnsafeList<byte> a, [Optional] int? b, [Optional] Id32<UTDLMYHANGH<WUKPIZKJTLJ>>? c)
		{
			return default((Id32<KGMTAGLYNTP<ELLAOEGXNOQ>>, Id32<KGMTAGLYNTP<WUKPIZKJTLJ>>, Id32<KGMTAGLYNTP<UTDLMYHANGH<WUKPIZKJTLJ>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x2B70850", Offset = "0x2B6F250", VA = "0x182B70850")]
		public static (Id32<KGMTAGLYNTP<ELLAOEGXNOQ>>, Id32<KGMTAGLYNTP<UTDLMYHANGH<WUKPIZKJTLJ>>>, Id32<KGMTAGLYNTP<UTDLMYHANGH<WUKPIZKJTLJ>>>) KETCQRUEQOP(this UnsafeList<byte> a, [Optional] Id32<UTDLMYHANGH<WUKPIZKJTLJ>>? b, [Optional] Id32<UTDLMYHANGH<WUKPIZKJTLJ>>? c)
		{
			return default((Id32<KGMTAGLYNTP<ELLAOEGXNOQ>>, Id32<KGMTAGLYNTP<UTDLMYHANGH<WUKPIZKJTLJ>>>, Id32<KGMTAGLYNTP<UTDLMYHANGH<WUKPIZKJTLJ>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x2B729D0", Offset = "0x2B713D0", VA = "0x182B729D0")]
		public static Id32<KGMTAGLYNTP<ELLAOEGXNOQ>> TMWHGJEHLXU(this UnsafeList<byte> a)
		{
			return default(Id32<KGMTAGLYNTP<ELLAOEGXNOQ>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x2B70AB0", Offset = "0x2B6F4B0", VA = "0x182B70AB0")]
		public static (Id32<KGMTAGLYNTP<ELLAOEGXNOQ>>, Id32<KGMTAGLYNTP<ZIFRBIBKQGK>>, Id32<KGMTAGLYNTP<ZIFRBIBKQGK>>, Id32<KGMTAGLYNTP<UTDLMYHANGH<ZIFRBIBKQGK>>>) KVAOHIYTKQN(this UnsafeList<byte> a, float b, float c, [Optional] Id32<UTDLMYHANGH<ZIFRBIBKQGK>>? d)
		{
			return default((Id32<KGMTAGLYNTP<ELLAOEGXNOQ>>, Id32<KGMTAGLYNTP<ZIFRBIBKQGK>>, Id32<KGMTAGLYNTP<ZIFRBIBKQGK>>, Id32<KGMTAGLYNTP<UTDLMYHANGH<ZIFRBIBKQGK>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x2B72880", Offset = "0x2B71280", VA = "0x182B72880")]
		public static (Id32<KGMTAGLYNTP<ELLAOEGXNOQ>>, Id32<KGMTAGLYNTP<ZIFRBIBKQGK>>, Id32<KGMTAGLYNTP<UTDLMYHANGH<ZIFRBIBKQGK>>>, Id32<KGMTAGLYNTP<UTDLMYHANGH<ZIFRBIBKQGK>>>) SFISEJGDVZM(this UnsafeList<byte> a, float b, [Optional] Id32<UTDLMYHANGH<ZIFRBIBKQGK>>? c, [Optional] Id32<UTDLMYHANGH<ZIFRBIBKQGK>>? d)
		{
			return default((Id32<KGMTAGLYNTP<ELLAOEGXNOQ>>, Id32<KGMTAGLYNTP<ZIFRBIBKQGK>>, Id32<KGMTAGLYNTP<UTDLMYHANGH<ZIFRBIBKQGK>>>, Id32<KGMTAGLYNTP<UTDLMYHANGH<ZIFRBIBKQGK>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x2B73F00", Offset = "0x2B72900", VA = "0x182B73F00")]
		public static (Id32<KGMTAGLYNTP<ELLAOEGXNOQ>>, Id32<KGMTAGLYNTP<UTDLMYHANGH<ZIFRBIBKQGK>>>, Id32<KGMTAGLYNTP<UTDLMYHANGH<ZIFRBIBKQGK>>>, Id32<KGMTAGLYNTP<UTDLMYHANGH<ZIFRBIBKQGK>>>) YXEGEWSUIYL(this UnsafeList<byte> a, [Optional] Id32<UTDLMYHANGH<ZIFRBIBKQGK>>? b, [Optional] Id32<UTDLMYHANGH<ZIFRBIBKQGK>>? c, [Optional] Id32<UTDLMYHANGH<ZIFRBIBKQGK>>? d)
		{
			return default((Id32<KGMTAGLYNTP<ELLAOEGXNOQ>>, Id32<KGMTAGLYNTP<UTDLMYHANGH<ZIFRBIBKQGK>>>, Id32<KGMTAGLYNTP<UTDLMYHANGH<ZIFRBIBKQGK>>>, Id32<KGMTAGLYNTP<UTDLMYHANGH<ZIFRBIBKQGK>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x2B70C30", Offset = "0x2B6F630", VA = "0x182B70C30")]
		public static (Id32<KGMTAGLYNTP<ELLAOEGXNOQ>>, Id32<KGMTAGLYNTP<WUKPIZKJTLJ>>, Id32<KGMTAGLYNTP<WUKPIZKJTLJ>>, Id32<KGMTAGLYNTP<UTDLMYHANGH<WUKPIZKJTLJ>>>) KXKOULYRQNB(this UnsafeList<byte> a, int b, int c, [Optional] Id32<UTDLMYHANGH<WUKPIZKJTLJ>>? d)
		{
			return default((Id32<KGMTAGLYNTP<ELLAOEGXNOQ>>, Id32<KGMTAGLYNTP<WUKPIZKJTLJ>>, Id32<KGMTAGLYNTP<WUKPIZKJTLJ>>, Id32<KGMTAGLYNTP<UTDLMYHANGH<WUKPIZKJTLJ>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x2B70960", Offset = "0x2B6F360", VA = "0x182B70960")]
		public static (Id32<KGMTAGLYNTP<ELLAOEGXNOQ>>, Id32<KGMTAGLYNTP<WUKPIZKJTLJ>>, Id32<KGMTAGLYNTP<UTDLMYHANGH<WUKPIZKJTLJ>>>, Id32<KGMTAGLYNTP<UTDLMYHANGH<WUKPIZKJTLJ>>>) KUUIYQQCOGY(this UnsafeList<byte> a, int b, [Optional] Id32<UTDLMYHANGH<WUKPIZKJTLJ>>? c, [Optional] Id32<UTDLMYHANGH<WUKPIZKJTLJ>>? d)
		{
			return default((Id32<KGMTAGLYNTP<ELLAOEGXNOQ>>, Id32<KGMTAGLYNTP<WUKPIZKJTLJ>>, Id32<KGMTAGLYNTP<UTDLMYHANGH<WUKPIZKJTLJ>>>, Id32<KGMTAGLYNTP<UTDLMYHANGH<WUKPIZKJTLJ>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x2B738C0", Offset = "0x2B722C0", VA = "0x182B738C0")]
		public static (Id32<KGMTAGLYNTP<ELLAOEGXNOQ>>, Id32<KGMTAGLYNTP<UTDLMYHANGH<WUKPIZKJTLJ>>>, Id32<KGMTAGLYNTP<UTDLMYHANGH<WUKPIZKJTLJ>>>, Id32<KGMTAGLYNTP<UTDLMYHANGH<WUKPIZKJTLJ>>>) XAYPSPUNDSN(this UnsafeList<byte> a, [Optional] Id32<UTDLMYHANGH<WUKPIZKJTLJ>>? b, [Optional] Id32<UTDLMYHANGH<WUKPIZKJTLJ>>? c, [Optional] Id32<UTDLMYHANGH<WUKPIZKJTLJ>>? d)
		{
			return default((Id32<KGMTAGLYNTP<ELLAOEGXNOQ>>, Id32<KGMTAGLYNTP<UTDLMYHANGH<WUKPIZKJTLJ>>>, Id32<KGMTAGLYNTP<UTDLMYHANGH<WUKPIZKJTLJ>>>, Id32<KGMTAGLYNTP<UTDLMYHANGH<WUKPIZKJTLJ>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x2B704A0", Offset = "0x2B6EEA0", VA = "0x182B704A0")]
		public static (Id32<KGMTAGLYNTP<ELLAOEGXNOQ>>, Id32<KGMTAGLYNTP<WUKPIZKJTLJ>>, Id32<KGMTAGLYNTP<WUKPIZKJTLJ>>, Id32<KGMTAGLYNTP<UTDLMYHANGH<WUKPIZKJTLJ>>>) IDRZMPDSFJM(this UnsafeList<byte> a, int b, int c, [Optional] Id32<UTDLMYHANGH<WUKPIZKJTLJ>>? d)
		{
			return default((Id32<KGMTAGLYNTP<ELLAOEGXNOQ>>, Id32<KGMTAGLYNTP<WUKPIZKJTLJ>>, Id32<KGMTAGLYNTP<WUKPIZKJTLJ>>, Id32<KGMTAGLYNTP<UTDLMYHANGH<WUKPIZKJTLJ>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x2B6E960", Offset = "0x2B6D360", VA = "0x182B6E960")]
		public static (Id32<KGMTAGLYNTP<ELLAOEGXNOQ>>, Id32<KGMTAGLYNTP<WUKPIZKJTLJ>>, Id32<KGMTAGLYNTP<UTDLMYHANGH<WUKPIZKJTLJ>>>, Id32<KGMTAGLYNTP<UTDLMYHANGH<WUKPIZKJTLJ>>>) AQJERBQYICB(this UnsafeList<byte> a, int b, [Optional] Id32<UTDLMYHANGH<WUKPIZKJTLJ>>? c, [Optional] Id32<UTDLMYHANGH<WUKPIZKJTLJ>>? d)
		{
			return default((Id32<KGMTAGLYNTP<ELLAOEGXNOQ>>, Id32<KGMTAGLYNTP<WUKPIZKJTLJ>>, Id32<KGMTAGLYNTP<UTDLMYHANGH<WUKPIZKJTLJ>>>, Id32<KGMTAGLYNTP<UTDLMYHANGH<WUKPIZKJTLJ>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x2B71DF0", Offset = "0x2B707F0", VA = "0x182B71DF0")]
		public static (Id32<KGMTAGLYNTP<ELLAOEGXNOQ>>, Id32<KGMTAGLYNTP<UTDLMYHANGH<WUKPIZKJTLJ>>>, Id32<KGMTAGLYNTP<UTDLMYHANGH<WUKPIZKJTLJ>>>, Id32<KGMTAGLYNTP<UTDLMYHANGH<WUKPIZKJTLJ>>>) OKEXXCMNSQM(this UnsafeList<byte> a, [Optional] Id32<UTDLMYHANGH<WUKPIZKJTLJ>>? b, [Optional] Id32<UTDLMYHANGH<WUKPIZKJTLJ>>? c, [Optional] Id32<UTDLMYHANGH<WUKPIZKJTLJ>>? d)
		{
			return default((Id32<KGMTAGLYNTP<ELLAOEGXNOQ>>, Id32<KGMTAGLYNTP<UTDLMYHANGH<WUKPIZKJTLJ>>>, Id32<KGMTAGLYNTP<UTDLMYHANGH<WUKPIZKJTLJ>>>, Id32<KGMTAGLYNTP<UTDLMYHANGH<WUKPIZKJTLJ>>>));
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
