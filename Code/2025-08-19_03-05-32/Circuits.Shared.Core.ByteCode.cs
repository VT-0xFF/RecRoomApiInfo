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
		[Cpp2IlInjected.Address(RVA = "0xAE81C0", Offset = "0xAE6FC0", VA = "0x180AE81C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x2ADF2A0", Offset = "0x2ADE0A0", VA = "0x182ADF2A0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xAE8B20", Offset = "0xAE7920", VA = "0x180AE8B20")]
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
		[Cpp2IlInjected.Address(RVA = "0xAE8B60", Offset = "0xAE7960", VA = "0x180AE8B60")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
namespace Circuits.Shared.Core.ByteCode
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public static class GNIFZIJPKTS
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x3909C10", Offset = "0x3908A10", VA = "0x183909C10")]
		public static Id32<DXZFAYBWXNM<a>> RZAOZFZHYKG<a>(this int a)
		{
			return default(Id32<DXZFAYBWXNM<a>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x2AD98C0", Offset = "0x2AD86C0", VA = "0x182AD98C0")]
		public static Id32<RFIESXCFEKH> CQTXKEGWQYL(this int a)
		{
			return default(Id32<RFIESXCFEKH>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x3909C10", Offset = "0x3908A10", VA = "0x183909C10")]
		public static Id32<CIAGZBHOAUA<b>> UDPDOYKHKCM<b>(this int a)
		{
			return default(Id32<CIAGZBHOAUA<b>>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public sealed class DXZFAYBWXNM<a>
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public sealed class MEHUWZMIAXD
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public sealed class OAUMMLHDYFG
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public sealed class RFIESXCFEKH
	{
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public sealed class JPROXOTIKYR
	{
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public sealed class DPNNVDSTLTJ
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
	public static class TPRBCAVYLAE
	{
		[Cpp2IlInjected.Token(Token = "0x200000E")]
		public readonly struct ProcessOpDelegate<TContext, TDeps, TCompileState>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000091")]
			private readonly IntPtr _impl;

			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0xECEFD0", Offset = "0xECDDD0", VA = "0x180ECEFD0")]
			public ProcessOpDelegate(IntPtr impl)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x5DA38B0", Offset = "0x5DA26B0", VA = "0x185DA38B0")]
			public int Invoke(TDeps deps, TContext ctx, TCompileState compileState, [In] UnsafeList<byte> fromByteCode, int byteCodePtr)
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x3D37C40", Offset = "0x3D36A40", VA = "0x183D37C40")]
		public static void BNZXPOVSNRF<TDeps, TContext, TCompileState>(TDeps a, TContext b, TCompileState c, [In] UnsafeList<byte> oldByteCode, UnsafeList<byte> newByteCode, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processAddF32_F32i_F32i_F32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processAddF32_F32i_F32r_F32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processAddF32_F32r_F32r_F32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processAddI32_I32i_I32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processAddI32_I32i_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processAddI32_I32r_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processAndI32_I32i_I32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processAndI32_I32i_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processAndI32_I32r_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfEqualF32_F32i_F32i_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfEqualF32_F32i_F32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfEqualF32_F32r_F32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfEqualI32_I32i_I32i_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfEqualI32_I32i_I32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfEqualI32_I32r_I32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfGreaterOrEqualF32_F32i_F32i_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfGreaterOrEqualF32_F32i_F32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfGreaterOrEqualF32_F32r_F32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfGreaterOrEqualI32_I32i_I32i_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfGreaterOrEqualI32_I32i_I32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfGreaterOrEqualI32_I32r_I32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfLessF32_F32i_F32i_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfLessF32_F32i_F32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfLessF32_F32r_F32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfLessI32_I32i_I32i_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfLessI32_I32i_I32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfLessI32_I32r_I32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfLessOrEqualF32_F32i_F32i_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfLessOrEqualF32_F32i_F32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfLessOrEqualF32_F32r_F32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfLessOrEqualI32_I32i_I32i_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfLessOrEqualI32_I32i_I32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfLessOrEqualI32_I32r_I32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfNotEqualF32_F32i_F32i_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfNotEqualF32_F32i_F32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfNotEqualF32_F32r_F32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfNotEqualI32_I32i_I32i_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfNotEqualI32_I32i_I32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfNotEqualI32_I32r_I32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfNotZeroF32_F32i_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfNotZeroF32_F32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfNotZeroI32_I32i_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfNotZeroI32_I32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfZeroF32_F32i_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfZeroF32_F32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfZeroI32_I32i_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfZeroI32_I32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processCallInternal_I32i_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processCallInternal_I32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processCallExternal_I32i_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processCallExternal_I32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processCallRuntime_I32i_I32i_Xi, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processCopyI32_I32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processCopyI32_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processCopyX_Xr_I32i_Xi, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processCopyX_Xr_Xr_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processDivideF32_F32i_F32i_F32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processDivideF32_F32i_F32r_F32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processDivideF32_F32r_F32r_F32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processDivideI32_I32i_I32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processDivideI32_I32i_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processDivideI32_I32r_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processEqualF32_F32i_F32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processEqualF32_F32i_F32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processEqualF32_F32r_F32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processEqualI32_I32i_I32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processEqualI32_I32i_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processEqualI32_I32r_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processEnd, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processGreaterF32_F32i_F32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processGreaterF32_F32i_F32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processGreaterF32_F32r_F32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processGreaterI32_I32i_I32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processGreaterI32_I32i_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processGreaterI32_I32r_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processGreaterOrEqualF32_F32i_F32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processGreaterOrEqualF32_F32i_F32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processGreaterOrEqualF32_F32r_F32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processGreaterOrEqualI32_I32i_I32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processGreaterOrEqualI32_I32i_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processGreaterOrEqualI32_I32r_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processJump_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processJump_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processLessF32_F32i_F32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processLessF32_F32i_F32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processLessF32_F32r_F32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processLessI32_I32i_I32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processLessI32_I32i_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processLessI32_I32r_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processLessOrEqualF32_F32i_F32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processLessOrEqualF32_F32i_F32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processLessOrEqualF32_F32r_F32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processLessOrEqualI32_I32i_I32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processLessOrEqualI32_I32i_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processLessOrEqualI32_I32r_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processModI32_I32i_I32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processModI32_I32i_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processModI32_I32r_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processMultiplyF32_F32i_F32i_F32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processMultiplyF32_F32i_F32r_F32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processMultiplyF32_F32r_F32r_F32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processMultiplyI32_I32i_I32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processMultiplyI32_I32i_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processMultiplyI32_I32r_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processNegateF32_F32i_F32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processNegateF32_F32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processNegateF32_F32r_F32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processNegateI32_I32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processNegateI32_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processNegateI32_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processNoOp, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processNotEqualF32_F32i_F32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processNotEqualF32_F32i_F32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processNotEqualF32_F32r_F32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processNotEqualI32_I32i_I32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processNotEqualI32_I32i_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processNotEqualI32_I32r_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processNotI32_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processNotI32_I32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processNotI32_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processOrI32_I32i_I32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processOrI32_I32i_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processOrI32_I32r_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processReturn, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processStaticCastF32I32_F32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processStaticCastI32F32_I32r_F32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processSubtractF32_F32i_F32i_F32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processSubtractF32_F32i_F32r_F32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processSubtractF32_F32r_F32r_F32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processSubtractI32_I32i_I32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processSubtractI32_I32i_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processSubtractI32_I32r_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processXorI32_I32i_I32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processXorI32_I32i_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processXorI32_I32r_I32r_I32r) where TDeps : notnull where TContext : notnull where TCompileState : notnull
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x2ADF320", Offset = "0x2ADE120", VA = "0x182ADF320")]
		private static int TGEQWKOVVQR([In] UnsafeList<byte> from, UnsafeList<byte> a, int b, int c)
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public static class EBVLWIAGEWH
	{
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		public static readonly int PJRUPTJDLOX;

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x37F1D40", Offset = "0x37F0B40", VA = "0x1837F1D40")]
		public static Id32<DXZFAYBWXNM<a>> CNDQIJARWQF<a>([In] this UnsafeList<byte> self)
		{
			return default(Id32<DXZFAYBWXNM<a>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x37F1EB0", Offset = "0x37F0CB0", VA = "0x1837F1EB0")]
		public static Id32<DXZFAYBWXNM<DXZFAYBWXNM<b>>> RQUEVVNUADI<b>(this UnsafeList<byte> a, [Optional] Id32<DXZFAYBWXNM<b>>? b)
		{
			return default(Id32<DXZFAYBWXNM<DXZFAYBWXNM<b>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x2AD95C0", Offset = "0x2AD83C0", VA = "0x182AD95C0")]
		public static Id32<DXZFAYBWXNM<YVHVHYLYUBD>> RQJFLCMSEFK(this UnsafeList<byte> a, [Optional] Id32<YVHVHYLYUBD>? b)
		{
			return default(Id32<DXZFAYBWXNM<YVHVHYLYUBD>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x2AD92F0", Offset = "0x2AD80F0", VA = "0x182AD92F0")]
		public static Id32<DXZFAYBWXNM<MEHUWZMIAXD>> FWUJDZRVAGK(this UnsafeList<byte> a, [Optional] float? b)
		{
			return default(Id32<DXZFAYBWXNM<MEHUWZMIAXD>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x2AD97A0", Offset = "0x2AD85A0", VA = "0x182AD97A0")]
		public static Id32<DXZFAYBWXNM<OAUMMLHDYFG>> XPLIELWBMKH(this UnsafeList<byte> a, [Optional] int? b)
		{
			return default(Id32<DXZFAYBWXNM<OAUMMLHDYFG>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x2AD93E0", Offset = "0x2AD81E0", VA = "0x182AD93E0")]
		public static Id32<DXZFAYBWXNM<NLLDXUHMLOS>> HAPWUWHCEAF(this UnsafeList<byte> a, [Optional] Id32<NLLDXUHMLOS>? b)
		{
			return default(Id32<DXZFAYBWXNM<NLLDXUHMLOS>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x2AD91F0", Offset = "0x2AD7FF0", VA = "0x182AD91F0")]
		public static Id32<DXZFAYBWXNM<DPNNVDSTLTJ>> BEVHCPVDXHY(this UnsafeList<byte> a, [Optional] byte? b)
		{
			return default(Id32<DXZFAYBWXNM<DPNNVDSTLTJ>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x2AD96B0", Offset = "0x2AD84B0", VA = "0x182AD96B0")]
		public static Id32<DXZFAYBWXNM<RFIESXCFEKH>> WRESJOVLSRA(this UnsafeList<byte> a, [Optional] Id32<RFIESXCFEKH>? b)
		{
			return default(Id32<DXZFAYBWXNM<RFIESXCFEKH>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x2AD94D0", Offset = "0x2AD82D0", VA = "0x182AD94D0")]
		public static Id32<DXZFAYBWXNM<JPROXOTIKYR>> PKOQYHWXNIE(this UnsafeList<byte> a, [Optional] Op? b)
		{
			return default(Id32<DXZFAYBWXNM<JPROXOTIKYR>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x37F1EB0", Offset = "0x37F0CB0", VA = "0x1837F1EB0")]
		public static Id32<DXZFAYBWXNM<CIAGZBHOAUA<c>>> TBAPWBFTECA<c>(this UnsafeList<byte> a, [Optional] Id32<CIAGZBHOAUA<c>>? b)
		{
			return default(Id32<DXZFAYBWXNM<CIAGZBHOAUA<c>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x2AD8DA0", Offset = "0x2AD7BA0", VA = "0x182AD8DA0")]
		public static void FESBTGSDLDC(this UnsafeList<byte> a, Id32<DXZFAYBWXNM<OAUMMLHDYFG>> b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x37F1DB0", Offset = "0x37F0BB0", VA = "0x1837F1DB0")]
		public static void MQFMRNZUBVT<d>(this UnsafeList<byte> a, Id32<DXZFAYBWXNM<DXZFAYBWXNM<d>>> b, Id32<DXZFAYBWXNM<d>> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x37F1DB0", Offset = "0x37F0BB0", VA = "0x1837F1DB0")]
		public static void PJOBKTOYLAD<e>(this UnsafeList<byte> a, Id32<DXZFAYBWXNM<CIAGZBHOAUA<e>>> b, Id32<CIAGZBHOAUA<e>> c)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public static class YZWKGFRFWYW
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x2ADF3C0", Offset = "0x2ADE1C0", VA = "0x182ADF3C0")]
		public static Union32 SHYYXXBBMTO([In] this ReadOnlySpan<byte> bytes, int a)
		{
			return default(Union32);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x2ADF430", Offset = "0x2ADE230", VA = "0x182ADF430")]
		public static Union32 SHYYXXBBMTO([In] this UnsafeList<byte> bytes, int a)
		{
			return default(Union32);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x3EA9280", Offset = "0x3EA8080", VA = "0x183EA9280")]
		public static Union32 SHYYXXBBMTO<f>(this ReadOnlyIdArray<f, byte> a, Id32<f> b)
		{
			return default(Union32);
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x3EA8FD0", Offset = "0x3EA7DD0", VA = "0x183EA8FD0")]
		public static Union32 SHYYXXBBMTO<g>([In] this ReadOnlyIdSpan<g, byte> bytes, Id32<g> a)
		{
			return default(Union32);
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x3EA9400", Offset = "0x3EA8200", VA = "0x183EA9400")]
		public static Union32 SHYYXXBBMTO<i>(this IdArray<i, byte> a, Id32<i> b)
		{
			return default(Union32);
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x3EA9150", Offset = "0x3EA7F50", VA = "0x183EA9150")]
		public static Union32 SHYYXXBBMTO<j>([In] this IdSpan<j, byte> bytes, Id32<j> a)
		{
			return default(Union32);
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x3EA91C0", Offset = "0x3EA7FC0", VA = "0x183EA91C0")]
		public static Union32 SHYYXXBBMTO<k>(this ReadOnlyIdArray<k, byte> a, Id32<k> b)
		{
			return default(Union32);
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x2ADF3C0", Offset = "0x2ADE1C0", VA = "0x182ADF3C0")]
		public static int DPRIALLJRIL([In] this ReadOnlySpan<byte> bytes, int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x2AD8DE0", Offset = "0x2AD7BE0", VA = "0x182AD8DE0")]
		public static int DPRIALLJRIL([In] this UnsafeList<byte> bytes, int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x3EA7FA0", Offset = "0x3EA6DA0", VA = "0x183EA7FA0")]
		public static int DPRIALLJRIL<p>(this ReadOnlyIdArray<p, byte> a, Id32<p> b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x3EA7ED0", Offset = "0x3EA6CD0", VA = "0x183EA7ED0")]
		public static int DPRIALLJRIL<s>(this IdArray<s, byte> a, Id32<s> b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x3EA7E80", Offset = "0x3EA6C80", VA = "0x183EA7E80")]
		public static int DPRIALLJRIL<t>([In] this IdSpan<t, byte> bytes, Id32<t> a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x3EA7F50", Offset = "0x3EA6D50", VA = "0x183EA7F50")]
		public static int DPRIALLJRIL<u>(this ReadOnlyIdArray<u, byte> a, Id32<u> b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x3EA8750", Offset = "0x3EA7550", VA = "0x183EA8750")]
		public static float PARMYNEXYWW<bc>(this IdArray<bc, byte> a, Id32<bc> b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x3EA8700", Offset = "0x3EA7500", VA = "0x183EA8700")]
		public static float PARMYNEXYWW<bd>([In] this IdSpan<bd, byte> bytes, Id32<bd> a)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x3EA86B0", Offset = "0x3EA74B0", VA = "0x183EA86B0")]
		public static float PARMYNEXYWW<be>(this ReadOnlyIdArray<be, byte> a, Id32<be> b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x3EA9770", Offset = "0x3EA8570", VA = "0x183EA9770")]
		public static byte VNHRUOJSTXU<bj>(this ReadOnlyIdArray<bj, byte> a, Id32<bj> b)
		{
			return default(byte);
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x3EA97C0", Offset = "0x3EA85C0", VA = "0x183EA97C0")]
		public static byte VNHRUOJSTXU<bk>([In] this ReadOnlyIdSpan<bk, byte> bytes, Id32<bk> a)
		{
			return default(byte);
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x3EA98A0", Offset = "0x3EA86A0", VA = "0x183EA98A0")]
		public static byte VNHRUOJSTXU<bm>(this IdArray<bm, byte> a, Id32<bm> b)
		{
			return default(byte);
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x3EA9810", Offset = "0x3EA8610", VA = "0x183EA9810")]
		public static byte VNHRUOJSTXU<bn>([In] this IdSpan<bn, byte> bytes, Id32<bn> a)
		{
			return default(byte);
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x3EA96A0", Offset = "0x3EA84A0", VA = "0x183EA96A0")]
		public static byte VNHRUOJSTXU<bo>(this ReadOnlyIdArray<bo, byte> a, Id32<bo> b)
		{
			return default(byte);
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x2AD8DE0", Offset = "0x2AD7BE0", VA = "0x182AD8DE0")]
		public static Op IZPPTGZFOAU([In] this UnsafeList<byte> bytes, int a)
		{
			return default(Op);
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x3EA8210", Offset = "0x3EA7010", VA = "0x183EA8210")]
		public static Op IZPPTGZFOAU<by>(this ReadOnlyIdArray<by, byte> a, Id32<by> b)
		{
			return default(Op);
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x3EA83F0", Offset = "0x3EA71F0", VA = "0x183EA83F0")]
		public static Id32<DXZFAYBWXNM<NLAXFVYHLZG>> OZINNZTYQSW<cg>(this IdArray<cg, byte> a, Id32<cg> b)
		{
			return default(Id32<DXZFAYBWXNM<NLAXFVYHLZG>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x3EA8470", Offset = "0x3EA7270", VA = "0x183EA8470")]
		public static Id32<DXZFAYBWXNM<NLAXFVYHLZG>> OZINNZTYQSW<ch>([In] this IdSpan<ch, byte> bytes, Id32<ch> a)
		{
			return default(Id32<DXZFAYBWXNM<NLAXFVYHLZG>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x3EA8500", Offset = "0x3EA7300", VA = "0x183EA8500")]
		public static Id32<DXZFAYBWXNM<NLAXFVYHLZG>> OZINNZTYQSW<ci>(this ReadOnlyIdArray<ci, byte> a, Id32<ci> b)
		{
			return default(Id32<DXZFAYBWXNM<NLAXFVYHLZG>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x3EA8B70", Offset = "0x3EA7970", VA = "0x183EA8B70")]
		public static Id32<CIAGZBHOAUA<NLAXFVYHLZG>> SEGSRQGJKHS<cs>(this ReadOnlyIdArray<cs, byte> a, Id32<cs> b)
		{
			return default(Id32<CIAGZBHOAUA<NLAXFVYHLZG>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x3EA8A70", Offset = "0x3EA7870", VA = "0x183EA8A70")]
		public static Id32<RFIESXCFEKH> QEBVDJRBCVW<da>(this IdArray<da, byte> a, Id32<da> b)
		{
			return default(Id32<RFIESXCFEKH>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x3EA89E0", Offset = "0x3EA77E0", VA = "0x183EA89E0")]
		public static Id32<RFIESXCFEKH> QEBVDJRBCVW<db>([In] this IdSpan<db, byte> bytes, Id32<db> a)
		{
			return default(Id32<RFIESXCFEKH>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x3EA8950", Offset = "0x3EA7750", VA = "0x183EA8950")]
		public static Id32<RFIESXCFEKH> QEBVDJRBCVW<dc>(this ReadOnlyIdArray<dc, byte> a, Id32<dc> b)
		{
			return default(Id32<RFIESXCFEKH>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x3EA8180", Offset = "0x3EA6F80", VA = "0x183EA8180")]
		public static Id32<YVHVHYLYUBD> HFPWEGIYRQS<dl>([In] this IdSpan<dl, byte> bytes, Id32<dl> a)
		{
			return default(Id32<YVHVHYLYUBD>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x3EA80F0", Offset = "0x3EA6EF0", VA = "0x183EA80F0")]
		public static Id32<YVHVHYLYUBD> HFPWEGIYRQS<dm>(this ReadOnlyIdArray<dm, byte> a, Id32<dm> b)
		{
			return default(Id32<YVHVHYLYUBD>);
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x3EA94E0", Offset = "0x3EA82E0", VA = "0x183EA94E0")]
		public static Id32<NLLDXUHMLOS> THZMSXWLPCJ<dw>(this ReadOnlyIdArray<dw, byte> a, Id32<dw> b)
		{
			return default(Id32<NLLDXUHMLOS>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public static class BBIDQRSTDIW
	{
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x2AD8E90", Offset = "0x2AD7C90", VA = "0x182AD8E90")]
		public static void AOPSBZBXMAP(this UnsafeList<byte> a, int b, Union32 c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x2AD8F50", Offset = "0x2AD7D50", VA = "0x182AD8F50")]
		public static void AOPSBZBXMAP(this byte[] a, int b, Union32 c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x2AD8FC0", Offset = "0x2AD7DC0", VA = "0x182AD8FC0")]
		public static void AOPSBZBXMAP([In] this Span<byte> bytes, int a, Union32 b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x36165B0", Offset = "0x36153B0", VA = "0x1836165B0")]
		public static void AOPSBZBXMAP<e>(this IdArray<e, byte> a, Id32<e> b, Union32 c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x3616700", Offset = "0x3615500", VA = "0x183616700")]
		public static void AOPSBZBXMAP<f>([In] this IdSpan<f, byte> bytes, Id32<f> a, Union32 b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x2AD8DA0", Offset = "0x2AD7BA0", VA = "0x182AD8DA0")]
		public static void FESBTGSDLDC(this UnsafeList<byte> a, int b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x2AD90C0", Offset = "0x2AD7EC0", VA = "0x182AD90C0")]
		public static void FESBTGSDLDC(this byte[] a, int b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x2AD9040", Offset = "0x2AD7E40", VA = "0x182AD9040")]
		public static void FESBTGSDLDC([In] this Span<byte> bytes, int a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x3616990", Offset = "0x3615790", VA = "0x183616990")]
		public static void FESBTGSDLDC<h>(this IdArray<h, byte> a, Id32<h> b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x3616930", Offset = "0x3615730", VA = "0x183616930")]
		public static void FESBTGSDLDC<i>([In] this IdSpan<i, byte> bytes, Id32<i> a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x2AD91B0", Offset = "0x2AD7FB0", VA = "0x182AD91B0")]
		public static void ZZSVYGUBCAF(this UnsafeList<byte> a, int b, float c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x3616DF0", Offset = "0x3615BF0", VA = "0x183616DF0")]
		public static void ZZSVYGUBCAF<k>(this IdArray<k, byte> a, Id32<k> b, float c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x3616E60", Offset = "0x3615C60", VA = "0x183616E60")]
		public static void ZZSVYGUBCAF<l>([In] this IdSpan<l, byte> bytes, Id32<l> a, float b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x2AD9140", Offset = "0x2AD7F40", VA = "0x182AD9140")]
		public static void TWIHXIQMCKT(this UnsafeList<byte> a, int b, byte c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x3616C60", Offset = "0x3615A60", VA = "0x183616C60")]
		public static void TWIHXIQMCKT<n>(this IdArray<n, byte> a, Id32<n> b, byte c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x3616CB0", Offset = "0x3615AB0", VA = "0x183616CB0")]
		public static void TWIHXIQMCKT<o>([In] this IdSpan<o, byte> bytes, Id32<o> a, byte b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x3616B30", Offset = "0x3615930", VA = "0x183616B30")]
		public static void MQFMRNZUBVT<q>(this IdArray<q, byte> a, Id32<q> b, Id32<DXZFAYBWXNM<NLAXFVYHLZG>> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x3616AB0", Offset = "0x36158B0", VA = "0x183616AB0")]
		public static void MQFMRNZUBVT<r>([In] this IdSpan<r, byte> bytes, Id32<r> a, Id32<DXZFAYBWXNM<NLAXFVYHLZG>> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x3616B30", Offset = "0x3615930", VA = "0x183616B30")]
		public static void KYUYAUDQBUL<t>(this IdArray<t, byte> a, Id32<t> b, Id32<RFIESXCFEKH> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x3616AB0", Offset = "0x36158B0", VA = "0x183616AB0")]
		public static void KYUYAUDQBUL<u>([In] this IdSpan<u, byte> bytes, Id32<u> a, Id32<RFIESXCFEKH> b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public static class NFFLWFAZQUP
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x2ADE810", Offset = "0x2ADD610", VA = "0x182ADE810")]
		public static (Id32<DXZFAYBWXNM<JPROXOTIKYR>>, Id32<DXZFAYBWXNM<MEHUWZMIAXD>>, Id32<DXZFAYBWXNM<MEHUWZMIAXD>>, Id32<DXZFAYBWXNM<CIAGZBHOAUA<MEHUWZMIAXD>>>) XOLNWQOLNHB(this UnsafeList<byte> a, float b, float c, [Optional] Id32<CIAGZBHOAUA<MEHUWZMIAXD>>? d)
		{
			return default((Id32<DXZFAYBWXNM<JPROXOTIKYR>>, Id32<DXZFAYBWXNM<MEHUWZMIAXD>>, Id32<DXZFAYBWXNM<MEHUWZMIAXD>>, Id32<DXZFAYBWXNM<CIAGZBHOAUA<MEHUWZMIAXD>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x2ADA8B0", Offset = "0x2AD96B0", VA = "0x182ADA8B0")]
		public static (Id32<DXZFAYBWXNM<JPROXOTIKYR>>, Id32<DXZFAYBWXNM<MEHUWZMIAXD>>, Id32<DXZFAYBWXNM<CIAGZBHOAUA<MEHUWZMIAXD>>>, Id32<DXZFAYBWXNM<CIAGZBHOAUA<MEHUWZMIAXD>>>) FWEVAQUNHGU(this UnsafeList<byte> a, float b, [Optional] Id32<CIAGZBHOAUA<MEHUWZMIAXD>>? c, [Optional] Id32<CIAGZBHOAUA<MEHUWZMIAXD>>? d)
		{
			return default((Id32<DXZFAYBWXNM<JPROXOTIKYR>>, Id32<DXZFAYBWXNM<MEHUWZMIAXD>>, Id32<DXZFAYBWXNM<CIAGZBHOAUA<MEHUWZMIAXD>>>, Id32<DXZFAYBWXNM<CIAGZBHOAUA<MEHUWZMIAXD>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x2ADDEA0", Offset = "0x2ADCCA0", VA = "0x182ADDEA0")]
		public static (Id32<DXZFAYBWXNM<JPROXOTIKYR>>, Id32<DXZFAYBWXNM<CIAGZBHOAUA<MEHUWZMIAXD>>>, Id32<DXZFAYBWXNM<CIAGZBHOAUA<MEHUWZMIAXD>>>, Id32<DXZFAYBWXNM<CIAGZBHOAUA<MEHUWZMIAXD>>>) UJMDWVIIAEJ(this UnsafeList<byte> a, [Optional] Id32<CIAGZBHOAUA<MEHUWZMIAXD>>? b, [Optional] Id32<CIAGZBHOAUA<MEHUWZMIAXD>>? c, [Optional] Id32<CIAGZBHOAUA<MEHUWZMIAXD>>? d)
		{
			return default((Id32<DXZFAYBWXNM<JPROXOTIKYR>>, Id32<DXZFAYBWXNM<CIAGZBHOAUA<MEHUWZMIAXD>>>, Id32<DXZFAYBWXNM<CIAGZBHOAUA<MEHUWZMIAXD>>>, Id32<DXZFAYBWXNM<CIAGZBHOAUA<MEHUWZMIAXD>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x2ADCD40", Offset = "0x2ADBB40", VA = "0x182ADCD40")]
		public static (Id32<DXZFAYBWXNM<JPROXOTIKYR>>, Id32<DXZFAYBWXNM<OAUMMLHDYFG>>, Id32<DXZFAYBWXNM<OAUMMLHDYFG>>, Id32<DXZFAYBWXNM<CIAGZBHOAUA<OAUMMLHDYFG>>>) PYMSUAKQSWF(this UnsafeList<byte> a, int b, int c, [Optional] Id32<CIAGZBHOAUA<OAUMMLHDYFG>>? d)
		{
			return default((Id32<DXZFAYBWXNM<JPROXOTIKYR>>, Id32<DXZFAYBWXNM<OAUMMLHDYFG>>, Id32<DXZFAYBWXNM<OAUMMLHDYFG>>, Id32<DXZFAYBWXNM<CIAGZBHOAUA<OAUMMLHDYFG>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x2ADE1F0", Offset = "0x2ADCFF0", VA = "0x182ADE1F0")]
		public static (Id32<DXZFAYBWXNM<JPROXOTIKYR>>, Id32<DXZFAYBWXNM<OAUMMLHDYFG>>, Id32<DXZFAYBWXNM<CIAGZBHOAUA<OAUMMLHDYFG>>>, Id32<DXZFAYBWXNM<CIAGZBHOAUA<OAUMMLHDYFG>>>) VOWRTCWRDQK(this UnsafeList<byte> a, int b, [Optional] Id32<CIAGZBHOAUA<OAUMMLHDYFG>>? c, [Optional] Id32<CIAGZBHOAUA<OAUMMLHDYFG>>? d)
		{
			return default((Id32<DXZFAYBWXNM<JPROXOTIKYR>>, Id32<DXZFAYBWXNM<OAUMMLHDYFG>>, Id32<DXZFAYBWXNM<CIAGZBHOAUA<OAUMMLHDYFG>>>, Id32<DXZFAYBWXNM<CIAGZBHOAUA<OAUMMLHDYFG>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x2ADADC0", Offset = "0x2AD9BC0", VA = "0x182ADADC0")]
		public static (Id32<DXZFAYBWXNM<JPROXOTIKYR>>, Id32<DXZFAYBWXNM<CIAGZBHOAUA<OAUMMLHDYFG>>>, Id32<DXZFAYBWXNM<CIAGZBHOAUA<OAUMMLHDYFG>>>, Id32<DXZFAYBWXNM<CIAGZBHOAUA<OAUMMLHDYFG>>>) GZXSBDPYWTV(this UnsafeList<byte> a, [Optional] Id32<CIAGZBHOAUA<OAUMMLHDYFG>>? b, [Optional] Id32<CIAGZBHOAUA<OAUMMLHDYFG>>? c, [Optional] Id32<CIAGZBHOAUA<OAUMMLHDYFG>>? d)
		{
			return default((Id32<DXZFAYBWXNM<JPROXOTIKYR>>, Id32<DXZFAYBWXNM<CIAGZBHOAUA<OAUMMLHDYFG>>>, Id32<DXZFAYBWXNM<CIAGZBHOAUA<OAUMMLHDYFG>>>, Id32<DXZFAYBWXNM<CIAGZBHOAUA<OAUMMLHDYFG>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x2AD9BD0", Offset = "0x2AD89D0", VA = "0x182AD9BD0")]
		public static (Id32<DXZFAYBWXNM<JPROXOTIKYR>>, Id32<DXZFAYBWXNM<OAUMMLHDYFG>>, Id32<DXZFAYBWXNM<OAUMMLHDYFG>>, Id32<DXZFAYBWXNM<CIAGZBHOAUA<OAUMMLHDYFG>>>) BFXOBZIBBLN(this UnsafeList<byte> a, int b, int c, [Optional] Id32<CIAGZBHOAUA<OAUMMLHDYFG>>? d)
		{
			return default((Id32<DXZFAYBWXNM<JPROXOTIKYR>>, Id32<DXZFAYBWXNM<OAUMMLHDYFG>>, Id32<DXZFAYBWXNM<OAUMMLHDYFG>>, Id32<DXZFAYBWXNM<CIAGZBHOAUA<OAUMMLHDYFG>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x2ADEED0", Offset = "0x2ADDCD0", VA = "0x182ADEED0")]
		public static (Id32<DXZFAYBWXNM<JPROXOTIKYR>>, Id32<DXZFAYBWXNM<OAUMMLHDYFG>>, Id32<DXZFAYBWXNM<CIAGZBHOAUA<OAUMMLHDYFG>>>, Id32<DXZFAYBWXNM<CIAGZBHOAUA<OAUMMLHDYFG>>>) ZMMJBPNLNRC(this UnsafeList<byte> a, int b, [Optional] Id32<CIAGZBHOAUA<OAUMMLHDYFG>>? c, [Optional] Id32<CIAGZBHOAUA<OAUMMLHDYFG>>? d)
		{
			return default((Id32<DXZFAYBWXNM<JPROXOTIKYR>>, Id32<DXZFAYBWXNM<OAUMMLHDYFG>>, Id32<DXZFAYBWXNM<CIAGZBHOAUA<OAUMMLHDYFG>>>, Id32<DXZFAYBWXNM<CIAGZBHOAUA<OAUMMLHDYFG>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x2ADE5A0", Offset = "0x2ADD3A0", VA = "0x182ADE5A0")]
		public static (Id32<DXZFAYBWXNM<JPROXOTIKYR>>, Id32<DXZFAYBWXNM<CIAGZBHOAUA<OAUMMLHDYFG>>>, Id32<DXZFAYBWXNM<CIAGZBHOAUA<OAUMMLHDYFG>>>, Id32<DXZFAYBWXNM<CIAGZBHOAUA<OAUMMLHDYFG>>>) WQYHTOVPZBL(this UnsafeList<byte> a, [Optional] Id32<CIAGZBHOAUA<OAUMMLHDYFG>>? b, [Optional] Id32<CIAGZBHOAUA<OAUMMLHDYFG>>? c, [Optional] Id32<CIAGZBHOAUA<OAUMMLHDYFG>>? d)
		{
			return default((Id32<DXZFAYBWXNM<JPROXOTIKYR>>, Id32<DXZFAYBWXNM<CIAGZBHOAUA<OAUMMLHDYFG>>>, Id32<DXZFAYBWXNM<CIAGZBHOAUA<OAUMMLHDYFG>>>, Id32<DXZFAYBWXNM<CIAGZBHOAUA<OAUMMLHDYFG>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x2ADB060", Offset = "0x2AD9E60", VA = "0x182ADB060")]
		public static (Id32<DXZFAYBWXNM<JPROXOTIKYR>>, Id32<DXZFAYBWXNM<OAUMMLHDYFG>>, Id32<DXZFAYBWXNM<DXZFAYBWXNM<JPROXOTIKYR>>>) IHQQXMWQWUT(this UnsafeList<byte> a, [Optional] int? b, [Optional] Id32<DXZFAYBWXNM<JPROXOTIKYR>>? c)
		{
			return default((Id32<DXZFAYBWXNM<JPROXOTIKYR>>, Id32<DXZFAYBWXNM<OAUMMLHDYFG>>, Id32<DXZFAYBWXNM<DXZFAYBWXNM<JPROXOTIKYR>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x2ADACA0", Offset = "0x2AD9AA0", VA = "0x182ADACA0")]
		public static (Id32<DXZFAYBWXNM<JPROXOTIKYR>>, Id32<DXZFAYBWXNM<CIAGZBHOAUA<OAUMMLHDYFG>>>, Id32<DXZFAYBWXNM<DXZFAYBWXNM<JPROXOTIKYR>>>) GWOYGRFSASU(this UnsafeList<byte> a, [Optional] Id32<CIAGZBHOAUA<OAUMMLHDYFG>>? b, [Optional] Id32<DXZFAYBWXNM<JPROXOTIKYR>>? c)
		{
			return default((Id32<DXZFAYBWXNM<JPROXOTIKYR>>, Id32<DXZFAYBWXNM<CIAGZBHOAUA<OAUMMLHDYFG>>>, Id32<DXZFAYBWXNM<DXZFAYBWXNM<JPROXOTIKYR>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x2ADC600", Offset = "0x2ADB400", VA = "0x182ADC600")]
		public static (Id32<DXZFAYBWXNM<JPROXOTIKYR>>, Id32<DXZFAYBWXNM<OAUMMLHDYFG>>, Id32<DXZFAYBWXNM<DXZFAYBWXNM<JPROXOTIKYR>>>) MZASPAMEXME(this UnsafeList<byte> a, [Optional] int? b, [Optional] Id32<DXZFAYBWXNM<JPROXOTIKYR>>? c)
		{
			return default((Id32<DXZFAYBWXNM<JPROXOTIKYR>>, Id32<DXZFAYBWXNM<OAUMMLHDYFG>>, Id32<DXZFAYBWXNM<DXZFAYBWXNM<JPROXOTIKYR>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x2ADCEA0", Offset = "0x2ADBCA0", VA = "0x182ADCEA0")]
		public static (Id32<DXZFAYBWXNM<JPROXOTIKYR>>, Id32<DXZFAYBWXNM<CIAGZBHOAUA<OAUMMLHDYFG>>>, Id32<DXZFAYBWXNM<DXZFAYBWXNM<JPROXOTIKYR>>>) QBVJJLGXFFV(this UnsafeList<byte> a, [Optional] Id32<CIAGZBHOAUA<OAUMMLHDYFG>>? b, [Optional] Id32<DXZFAYBWXNM<JPROXOTIKYR>>? c)
		{
			return default((Id32<DXZFAYBWXNM<JPROXOTIKYR>>, Id32<DXZFAYBWXNM<CIAGZBHOAUA<OAUMMLHDYFG>>>, Id32<DXZFAYBWXNM<DXZFAYBWXNM<JPROXOTIKYR>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x2ADB930", Offset = "0x2ADA730", VA = "0x182ADB930")]
		public static (Id32<DXZFAYBWXNM<JPROXOTIKYR>>, Id32<DXZFAYBWXNM<OAUMMLHDYFG>>, Id32<DXZFAYBWXNM<YVHVHYLYUBD>>) JQGXWGXWPYA(this UnsafeList<byte> a, [Optional] int? b, [Optional] Id32<YVHVHYLYUBD>? c)
		{
			return default((Id32<DXZFAYBWXNM<JPROXOTIKYR>>, Id32<DXZFAYBWXNM<OAUMMLHDYFG>>, Id32<DXZFAYBWXNM<YVHVHYLYUBD>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x2ADBAE0", Offset = "0x2ADA8E0", VA = "0x182ADBAE0")]
		public static (Id32<DXZFAYBWXNM<JPROXOTIKYR>>, Id32<DXZFAYBWXNM<OAUMMLHDYFG>>, Id32<DXZFAYBWXNM<CIAGZBHOAUA<YVHVHYLYUBD>>>) JVTCAHPDKSJ(this UnsafeList<byte> a, [Optional] int? b, [Optional] Id32<CIAGZBHOAUA<YVHVHYLYUBD>>? c)
		{
			return default((Id32<DXZFAYBWXNM<JPROXOTIKYR>>, Id32<DXZFAYBWXNM<OAUMMLHDYFG>>, Id32<DXZFAYBWXNM<CIAGZBHOAUA<YVHVHYLYUBD>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x2ADB170", Offset = "0x2AD9F70", VA = "0x182ADB170")]
		public static (Id32<DXZFAYBWXNM<JPROXOTIKYR>>, Id32<DXZFAYBWXNM<OAUMMLHDYFG>>, Id32<DXZFAYBWXNM<RFIESXCFEKH>>) ILBHZSBHZRY(this UnsafeList<byte> a, [Optional] int? b, [Optional] Id32<RFIESXCFEKH>? c)
		{
			return default((Id32<DXZFAYBWXNM<JPROXOTIKYR>>, Id32<DXZFAYBWXNM<OAUMMLHDYFG>>, Id32<DXZFAYBWXNM<RFIESXCFEKH>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x2ADB320", Offset = "0x2ADA120", VA = "0x182ADB320")]
		public static (Id32<DXZFAYBWXNM<JPROXOTIKYR>>, Id32<DXZFAYBWXNM<OAUMMLHDYFG>>, Id32<DXZFAYBWXNM<CIAGZBHOAUA<RFIESXCFEKH>>>) IMMEGNKPNTJ(this UnsafeList<byte> a, [Optional] int? b, [Optional] Id32<CIAGZBHOAUA<RFIESXCFEKH>>? c)
		{
			return default((Id32<DXZFAYBWXNM<JPROXOTIKYR>>, Id32<DXZFAYBWXNM<OAUMMLHDYFG>>, Id32<DXZFAYBWXNM<CIAGZBHOAUA<RFIESXCFEKH>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x3ACFF10", Offset = "0x3ACED10", VA = "0x183ACFF10")]
		public static (Id32<DXZFAYBWXNM<JPROXOTIKYR>>, Id32<DXZFAYBWXNM<NLLDXUHMLOS>>, Id32<DXZFAYBWXNM<OAUMMLHDYFG>>, Id32<DXZFAYBWXNM<a>>) OVMJAFUFFCJ<a>(this UnsafeList<byte> a, [Optional] Id32<NLLDXUHMLOS>? b, [Optional][In] ReadOnlySpan<byte> data)
		{
			return default((Id32<DXZFAYBWXNM<JPROXOTIKYR>>, Id32<DXZFAYBWXNM<NLLDXUHMLOS>>, Id32<DXZFAYBWXNM<OAUMMLHDYFG>>, Id32<DXZFAYBWXNM<a>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x2ADC4D0", Offset = "0x2ADB2D0", VA = "0x182ADC4D0")]
		public static (Id32<DXZFAYBWXNM<JPROXOTIKYR>>, Id32<DXZFAYBWXNM<OAUMMLHDYFG>>, Id32<DXZFAYBWXNM<CIAGZBHOAUA<OAUMMLHDYFG>>>) MLLZGKIKIQJ(this UnsafeList<byte> a, int b, [Optional] Id32<CIAGZBHOAUA<OAUMMLHDYFG>>? c)
		{
			return default((Id32<DXZFAYBWXNM<JPROXOTIKYR>>, Id32<DXZFAYBWXNM<OAUMMLHDYFG>>, Id32<DXZFAYBWXNM<CIAGZBHOAUA<OAUMMLHDYFG>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x2ADE340", Offset = "0x2ADD140", VA = "0x182ADE340")]
		public static (Id32<DXZFAYBWXNM<JPROXOTIKYR>>, Id32<DXZFAYBWXNM<CIAGZBHOAUA<OAUMMLHDYFG>>>, Id32<DXZFAYBWXNM<CIAGZBHOAUA<OAUMMLHDYFG>>>) VXTAGCDHDYK(this UnsafeList<byte> a, [Optional] Id32<CIAGZBHOAUA<OAUMMLHDYFG>>? b, [Optional] Id32<CIAGZBHOAUA<OAUMMLHDYFG>>? c)
		{
			return default((Id32<DXZFAYBWXNM<JPROXOTIKYR>>, Id32<DXZFAYBWXNM<CIAGZBHOAUA<OAUMMLHDYFG>>>, Id32<DXZFAYBWXNM<CIAGZBHOAUA<OAUMMLHDYFG>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x3AD0310", Offset = "0x3ACF110", VA = "0x183AD0310")]
		public static (Id32<DXZFAYBWXNM<JPROXOTIKYR>>, Id32<DXZFAYBWXNM<CIAGZBHOAUA<b>>>, Id32<DXZFAYBWXNM<OAUMMLHDYFG>>, Id32<DXZFAYBWXNM<b>>) VCQRXGUTTLV<b>(this UnsafeList<byte> a, [Optional] Id32<CIAGZBHOAUA<b>>? b, [Optional] int? c, [Optional][In] ReadOnlySpan<byte> from)
		{
			return default((Id32<DXZFAYBWXNM<JPROXOTIKYR>>, Id32<DXZFAYBWXNM<CIAGZBHOAUA<b>>>, Id32<DXZFAYBWXNM<OAUMMLHDYFG>>, Id32<DXZFAYBWXNM<b>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x3ACFBC0", Offset = "0x3ACE9C0", VA = "0x183ACFBC0")]
		public static (Id32<DXZFAYBWXNM<JPROXOTIKYR>>, Id32<DXZFAYBWXNM<CIAGZBHOAUA<c>>>, Id32<DXZFAYBWXNM<CIAGZBHOAUA<c>>>, Id32<DXZFAYBWXNM<OAUMMLHDYFG>>) IQHHZOWQODO<c>(this UnsafeList<byte> a, [Optional] Id32<CIAGZBHOAUA<c>>? b, [Optional] Id32<CIAGZBHOAUA<c>>? c, [Optional] int? d)
		{
			return default((Id32<DXZFAYBWXNM<JPROXOTIKYR>>, Id32<DXZFAYBWXNM<CIAGZBHOAUA<c>>>, Id32<DXZFAYBWXNM<CIAGZBHOAUA<c>>>, Id32<DXZFAYBWXNM<OAUMMLHDYFG>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x2ADCBC0", Offset = "0x2ADB9C0", VA = "0x182ADCBC0")]
		public static (Id32<DXZFAYBWXNM<JPROXOTIKYR>>, Id32<DXZFAYBWXNM<MEHUWZMIAXD>>, Id32<DXZFAYBWXNM<MEHUWZMIAXD>>, Id32<DXZFAYBWXNM<CIAGZBHOAUA<MEHUWZMIAXD>>>) PVOUTIIDEJV(this UnsafeList<byte> a, float b, float c, [Optional] Id32<CIAGZBHOAUA<MEHUWZMIAXD>>? d)
		{
			return default((Id32<DXZFAYBWXNM<JPROXOTIKYR>>, Id32<DXZFAYBWXNM<MEHUWZMIAXD>>, Id32<DXZFAYBWXNM<MEHUWZMIAXD>>, Id32<DXZFAYBWXNM<CIAGZBHOAUA<MEHUWZMIAXD>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x2ADA4F0", Offset = "0x2AD92F0", VA = "0x182ADA4F0")]
		public static (Id32<DXZFAYBWXNM<JPROXOTIKYR>>, Id32<DXZFAYBWXNM<MEHUWZMIAXD>>, Id32<DXZFAYBWXNM<CIAGZBHOAUA<MEHUWZMIAXD>>>, Id32<DXZFAYBWXNM<CIAGZBHOAUA<MEHUWZMIAXD>>>) EPBVDONCKFO(this UnsafeList<byte> a, float b, [Optional] Id32<CIAGZBHOAUA<MEHUWZMIAXD>>? c, [Optional] Id32<CIAGZBHOAUA<MEHUWZMIAXD>>? d)
		{
			return default((Id32<DXZFAYBWXNM<JPROXOTIKYR>>, Id32<DXZFAYBWXNM<MEHUWZMIAXD>>, Id32<DXZFAYBWXNM<CIAGZBHOAUA<MEHUWZMIAXD>>>, Id32<DXZFAYBWXNM<CIAGZBHOAUA<MEHUWZMIAXD>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x2ADAB80", Offset = "0x2AD9980", VA = "0x182ADAB80")]
		public static (Id32<DXZFAYBWXNM<JPROXOTIKYR>>, Id32<DXZFAYBWXNM<CIAGZBHOAUA<MEHUWZMIAXD>>>, Id32<DXZFAYBWXNM<CIAGZBHOAUA<MEHUWZMIAXD>>>, Id32<DXZFAYBWXNM<CIAGZBHOAUA<MEHUWZMIAXD>>>) GVRVOGTTUEV(this UnsafeList<byte> a, [Optional] Id32<CIAGZBHOAUA<MEHUWZMIAXD>>? b, [Optional] Id32<CIAGZBHOAUA<MEHUWZMIAXD>>? c, [Optional] Id32<CIAGZBHOAUA<MEHUWZMIAXD>>? d)
		{
			return default((Id32<DXZFAYBWXNM<JPROXOTIKYR>>, Id32<DXZFAYBWXNM<CIAGZBHOAUA<MEHUWZMIAXD>>>, Id32<DXZFAYBWXNM<CIAGZBHOAUA<MEHUWZMIAXD>>>, Id32<DXZFAYBWXNM<CIAGZBHOAUA<MEHUWZMIAXD>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x2ADD700", Offset = "0x2ADC500", VA = "0x182ADD700")]
		public static (Id32<DXZFAYBWXNM<JPROXOTIKYR>>, Id32<DXZFAYBWXNM<OAUMMLHDYFG>>, Id32<DXZFAYBWXNM<OAUMMLHDYFG>>, Id32<DXZFAYBWXNM<CIAGZBHOAUA<OAUMMLHDYFG>>>) RTSDXXVNKBT(this UnsafeList<byte> a, int b, int c, [Optional] Id32<CIAGZBHOAUA<OAUMMLHDYFG>>? d)
		{
			return default((Id32<DXZFAYBWXNM<JPROXOTIKYR>>, Id32<DXZFAYBWXNM<OAUMMLHDYFG>>, Id32<DXZFAYBWXNM<OAUMMLHDYFG>>, Id32<DXZFAYBWXNM<CIAGZBHOAUA<OAUMMLHDYFG>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x2ADD0D0", Offset = "0x2ADBED0", VA = "0x182ADD0D0")]
		public static (Id32<DXZFAYBWXNM<JPROXOTIKYR>>, Id32<DXZFAYBWXNM<OAUMMLHDYFG>>, Id32<DXZFAYBWXNM<CIAGZBHOAUA<OAUMMLHDYFG>>>, Id32<DXZFAYBWXNM<CIAGZBHOAUA<OAUMMLHDYFG>>>) QXNWYCCOJMG(this UnsafeList<byte> a, int b, [Optional] Id32<CIAGZBHOAUA<OAUMMLHDYFG>>? c, [Optional] Id32<CIAGZBHOAUA<OAUMMLHDYFG>>? d)
		{
			return default((Id32<DXZFAYBWXNM<JPROXOTIKYR>>, Id32<DXZFAYBWXNM<OAUMMLHDYFG>>, Id32<DXZFAYBWXNM<CIAGZBHOAUA<OAUMMLHDYFG>>>, Id32<DXZFAYBWXNM<CIAGZBHOAUA<OAUMMLHDYFG>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x2ADA3D0", Offset = "0x2AD91D0", VA = "0x182ADA3D0")]
		public static (Id32<DXZFAYBWXNM<JPROXOTIKYR>>, Id32<DXZFAYBWXNM<CIAGZBHOAUA<OAUMMLHDYFG>>>, Id32<DXZFAYBWXNM<CIAGZBHOAUA<OAUMMLHDYFG>>>, Id32<DXZFAYBWXNM<CIAGZBHOAUA<OAUMMLHDYFG>>>) DYZYTIVMYOD(this UnsafeList<byte> a, [Optional] Id32<CIAGZBHOAUA<OAUMMLHDYFG>>? b, [Optional] Id32<CIAGZBHOAUA<OAUMMLHDYFG>>? c, [Optional] Id32<CIAGZBHOAUA<OAUMMLHDYFG>>? d)
		{
			return default((Id32<DXZFAYBWXNM<JPROXOTIKYR>>, Id32<DXZFAYBWXNM<CIAGZBHOAUA<OAUMMLHDYFG>>>, Id32<DXZFAYBWXNM<CIAGZBHOAUA<OAUMMLHDYFG>>>, Id32<DXZFAYBWXNM<CIAGZBHOAUA<OAUMMLHDYFG>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x2ADDC20", Offset = "0x2ADCA20", VA = "0x182ADDC20")]
		public static (Id32<DXZFAYBWXNM<JPROXOTIKYR>>, Id32<DXZFAYBWXNM<OAUMMLHDYFG>>, Id32<DXZFAYBWXNM<OAUMMLHDYFG>>, Id32<DXZFAYBWXNM<CIAGZBHOAUA<OAUMMLHDYFG>>>) TDPRCDLRLHI(this UnsafeList<byte> a, int b, int c, [Optional] Id32<CIAGZBHOAUA<OAUMMLHDYFG>>? d)
		{
			return default((Id32<DXZFAYBWXNM<JPROXOTIKYR>>, Id32<DXZFAYBWXNM<OAUMMLHDYFG>>, Id32<DXZFAYBWXNM<OAUMMLHDYFG>>, Id32<DXZFAYBWXNM<CIAGZBHOAUA<OAUMMLHDYFG>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x2ADE990", Offset = "0x2ADD790", VA = "0x182ADE990")]
		public static (Id32<DXZFAYBWXNM<JPROXOTIKYR>>, Id32<DXZFAYBWXNM<OAUMMLHDYFG>>, Id32<DXZFAYBWXNM<CIAGZBHOAUA<OAUMMLHDYFG>>>, Id32<DXZFAYBWXNM<CIAGZBHOAUA<OAUMMLHDYFG>>>) XVTZGGUJIND(this UnsafeList<byte> a, int b, [Optional] Id32<CIAGZBHOAUA<OAUMMLHDYFG>>? c, [Optional] Id32<CIAGZBHOAUA<OAUMMLHDYFG>>? d)
		{
			return default((Id32<DXZFAYBWXNM<JPROXOTIKYR>>, Id32<DXZFAYBWXNM<OAUMMLHDYFG>>, Id32<DXZFAYBWXNM<CIAGZBHOAUA<OAUMMLHDYFG>>>, Id32<DXZFAYBWXNM<CIAGZBHOAUA<OAUMMLHDYFG>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x2ADEC60", Offset = "0x2ADDA60", VA = "0x182ADEC60")]
		public static (Id32<DXZFAYBWXNM<JPROXOTIKYR>>, Id32<DXZFAYBWXNM<CIAGZBHOAUA<OAUMMLHDYFG>>>, Id32<DXZFAYBWXNM<CIAGZBHOAUA<OAUMMLHDYFG>>>, Id32<DXZFAYBWXNM<CIAGZBHOAUA<OAUMMLHDYFG>>>) YUAIGSFBESY(this UnsafeList<byte> a, [Optional] Id32<CIAGZBHOAUA<OAUMMLHDYFG>>? b, [Optional] Id32<CIAGZBHOAUA<OAUMMLHDYFG>>? c, [Optional] Id32<CIAGZBHOAUA<OAUMMLHDYFG>>? d)
		{
			return default((Id32<DXZFAYBWXNM<JPROXOTIKYR>>, Id32<DXZFAYBWXNM<CIAGZBHOAUA<OAUMMLHDYFG>>>, Id32<DXZFAYBWXNM<CIAGZBHOAUA<OAUMMLHDYFG>>>, Id32<DXZFAYBWXNM<CIAGZBHOAUA<OAUMMLHDYFG>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x2ADC130", Offset = "0x2ADAF30", VA = "0x182ADC130")]
		public static (Id32<DXZFAYBWXNM<JPROXOTIKYR>>, Id32<DXZFAYBWXNM<DXZFAYBWXNM<JPROXOTIKYR>>>) LQRVVBKJHDP(this UnsafeList<byte> a, [Optional] Id32<DXZFAYBWXNM<JPROXOTIKYR>>? b)
		{
			return default((Id32<DXZFAYBWXNM<JPROXOTIKYR>>, Id32<DXZFAYBWXNM<DXZFAYBWXNM<JPROXOTIKYR>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x2ADEAE0", Offset = "0x2ADD8E0", VA = "0x182ADEAE0")]
		public static (Id32<DXZFAYBWXNM<JPROXOTIKYR>>, Id32<DXZFAYBWXNM<MEHUWZMIAXD>>, Id32<DXZFAYBWXNM<MEHUWZMIAXD>>, Id32<DXZFAYBWXNM<CIAGZBHOAUA<OAUMMLHDYFG>>>) YTKYMUCFWCJ(this UnsafeList<byte> a, float b, float c, [Optional] Id32<CIAGZBHOAUA<OAUMMLHDYFG>>? d)
		{
			return default((Id32<DXZFAYBWXNM<JPROXOTIKYR>>, Id32<DXZFAYBWXNM<MEHUWZMIAXD>>, Id32<DXZFAYBWXNM<MEHUWZMIAXD>>, Id32<DXZFAYBWXNM<CIAGZBHOAUA<OAUMMLHDYFG>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x2ADF140", Offset = "0x2ADDF40", VA = "0x182ADF140")]
		public static (Id32<DXZFAYBWXNM<JPROXOTIKYR>>, Id32<DXZFAYBWXNM<MEHUWZMIAXD>>, Id32<DXZFAYBWXNM<CIAGZBHOAUA<MEHUWZMIAXD>>>, Id32<DXZFAYBWXNM<CIAGZBHOAUA<OAUMMLHDYFG>>>) ZWQSTDYIUGW(this UnsafeList<byte> a, float b, [Optional] Id32<CIAGZBHOAUA<MEHUWZMIAXD>>? c, [Optional] Id32<CIAGZBHOAUA<OAUMMLHDYFG>>? d)
		{
			return default((Id32<DXZFAYBWXNM<JPROXOTIKYR>>, Id32<DXZFAYBWXNM<MEHUWZMIAXD>>, Id32<DXZFAYBWXNM<CIAGZBHOAUA<MEHUWZMIAXD>>>, Id32<DXZFAYBWXNM<CIAGZBHOAUA<OAUMMLHDYFG>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x2ADD340", Offset = "0x2ADC140", VA = "0x182ADD340")]
		public static (Id32<DXZFAYBWXNM<JPROXOTIKYR>>, Id32<DXZFAYBWXNM<CIAGZBHOAUA<MEHUWZMIAXD>>>, Id32<DXZFAYBWXNM<CIAGZBHOAUA<MEHUWZMIAXD>>>, Id32<DXZFAYBWXNM<CIAGZBHOAUA<OAUMMLHDYFG>>>) RKVVTPJXANV(this UnsafeList<byte> a, [Optional] Id32<CIAGZBHOAUA<MEHUWZMIAXD>>? b, [Optional] Id32<CIAGZBHOAUA<MEHUWZMIAXD>>? c, [Optional] Id32<CIAGZBHOAUA<OAUMMLHDYFG>>? d)
		{
			return default((Id32<DXZFAYBWXNM<JPROXOTIKYR>>, Id32<DXZFAYBWXNM<CIAGZBHOAUA<MEHUWZMIAXD>>>, Id32<DXZFAYBWXNM<CIAGZBHOAUA<MEHUWZMIAXD>>>, Id32<DXZFAYBWXNM<CIAGZBHOAUA<OAUMMLHDYFG>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x2ADB430", Offset = "0x2ADA230", VA = "0x182ADB430")]
		public static (Id32<DXZFAYBWXNM<JPROXOTIKYR>>, Id32<DXZFAYBWXNM<OAUMMLHDYFG>>, Id32<DXZFAYBWXNM<OAUMMLHDYFG>>, Id32<DXZFAYBWXNM<CIAGZBHOAUA<OAUMMLHDYFG>>>) IPFNLPNGQUQ(this UnsafeList<byte> a, int b, int c, [Optional] Id32<CIAGZBHOAUA<OAUMMLHDYFG>>? d)
		{
			return default((Id32<DXZFAYBWXNM<JPROXOTIKYR>>, Id32<DXZFAYBWXNM<OAUMMLHDYFG>>, Id32<DXZFAYBWXNM<OAUMMLHDYFG>>, Id32<DXZFAYBWXNM<CIAGZBHOAUA<OAUMMLHDYFG>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x2ADBE80", Offset = "0x2ADAC80", VA = "0x182ADBE80")]
		public static (Id32<DXZFAYBWXNM<JPROXOTIKYR>>, Id32<DXZFAYBWXNM<OAUMMLHDYFG>>, Id32<DXZFAYBWXNM<CIAGZBHOAUA<OAUMMLHDYFG>>>, Id32<DXZFAYBWXNM<CIAGZBHOAUA<OAUMMLHDYFG>>>) KIQSLZHWEPB(this UnsafeList<byte> a, int b, [Optional] Id32<CIAGZBHOAUA<OAUMMLHDYFG>>? c, [Optional] Id32<CIAGZBHOAUA<OAUMMLHDYFG>>? d)
		{
			return default((Id32<DXZFAYBWXNM<JPROXOTIKYR>>, Id32<DXZFAYBWXNM<OAUMMLHDYFG>>, Id32<DXZFAYBWXNM<CIAGZBHOAUA<OAUMMLHDYFG>>>, Id32<DXZFAYBWXNM<CIAGZBHOAUA<OAUMMLHDYFG>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x2ADA2B0", Offset = "0x2AD90B0", VA = "0x182ADA2B0")]
		public static (Id32<DXZFAYBWXNM<JPROXOTIKYR>>, Id32<DXZFAYBWXNM<CIAGZBHOAUA<OAUMMLHDYFG>>>, Id32<DXZFAYBWXNM<CIAGZBHOAUA<OAUMMLHDYFG>>>, Id32<DXZFAYBWXNM<CIAGZBHOAUA<OAUMMLHDYFG>>>) DUHOMAZRRIO(this UnsafeList<byte> a, [Optional] Id32<CIAGZBHOAUA<OAUMMLHDYFG>>? b, [Optional] Id32<CIAGZBHOAUA<OAUMMLHDYFG>>? c, [Optional] Id32<CIAGZBHOAUA<OAUMMLHDYFG>>? d)
		{
			return default((Id32<DXZFAYBWXNM<JPROXOTIKYR>>, Id32<DXZFAYBWXNM<CIAGZBHOAUA<OAUMMLHDYFG>>>, Id32<DXZFAYBWXNM<CIAGZBHOAUA<OAUMMLHDYFG>>>, Id32<DXZFAYBWXNM<CIAGZBHOAUA<OAUMMLHDYFG>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x2ADAEE0", Offset = "0x2AD9CE0", VA = "0x182ADAEE0")]
		public static (Id32<DXZFAYBWXNM<JPROXOTIKYR>>, Id32<DXZFAYBWXNM<MEHUWZMIAXD>>, Id32<DXZFAYBWXNM<MEHUWZMIAXD>>, Id32<DXZFAYBWXNM<CIAGZBHOAUA<OAUMMLHDYFG>>>) HWFNOBODNAM(this UnsafeList<byte> a, float b, float c, [Optional] Id32<CIAGZBHOAUA<OAUMMLHDYFG>>? d)
		{
			return default((Id32<DXZFAYBWXNM<JPROXOTIKYR>>, Id32<DXZFAYBWXNM<MEHUWZMIAXD>>, Id32<DXZFAYBWXNM<MEHUWZMIAXD>>, Id32<DXZFAYBWXNM<CIAGZBHOAUA<OAUMMLHDYFG>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x2AD9D30", Offset = "0x2AD8B30", VA = "0x182AD9D30")]
		public static (Id32<DXZFAYBWXNM<JPROXOTIKYR>>, Id32<DXZFAYBWXNM<MEHUWZMIAXD>>, Id32<DXZFAYBWXNM<CIAGZBHOAUA<MEHUWZMIAXD>>>, Id32<DXZFAYBWXNM<CIAGZBHOAUA<OAUMMLHDYFG>>>) BZUIGSLJOLJ(this UnsafeList<byte> a, float b, [Optional] Id32<CIAGZBHOAUA<MEHUWZMIAXD>>? c, [Optional] Id32<CIAGZBHOAUA<OAUMMLHDYFG>>? d)
		{
			return default((Id32<DXZFAYBWXNM<JPROXOTIKYR>>, Id32<DXZFAYBWXNM<MEHUWZMIAXD>>, Id32<DXZFAYBWXNM<CIAGZBHOAUA<MEHUWZMIAXD>>>, Id32<DXZFAYBWXNM<CIAGZBHOAUA<OAUMMLHDYFG>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x2ADD5D0", Offset = "0x2ADC3D0", VA = "0x182ADD5D0")]
		public static (Id32<DXZFAYBWXNM<JPROXOTIKYR>>, Id32<DXZFAYBWXNM<CIAGZBHOAUA<MEHUWZMIAXD>>>, Id32<DXZFAYBWXNM<CIAGZBHOAUA<MEHUWZMIAXD>>>, Id32<DXZFAYBWXNM<CIAGZBHOAUA<OAUMMLHDYFG>>>) RRVOCHMMXUW(this UnsafeList<byte> a, [Optional] Id32<CIAGZBHOAUA<MEHUWZMIAXD>>? b, [Optional] Id32<CIAGZBHOAUA<MEHUWZMIAXD>>? c, [Optional] Id32<CIAGZBHOAUA<OAUMMLHDYFG>>? d)
		{
			return default((Id32<DXZFAYBWXNM<JPROXOTIKYR>>, Id32<DXZFAYBWXNM<CIAGZBHOAUA<MEHUWZMIAXD>>>, Id32<DXZFAYBWXNM<CIAGZBHOAUA<MEHUWZMIAXD>>>, Id32<DXZFAYBWXNM<CIAGZBHOAUA<OAUMMLHDYFG>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x2ADBBF0", Offset = "0x2ADA9F0", VA = "0x182ADBBF0")]
		public static (Id32<DXZFAYBWXNM<JPROXOTIKYR>>, Id32<DXZFAYBWXNM<OAUMMLHDYFG>>, Id32<DXZFAYBWXNM<OAUMMLHDYFG>>, Id32<DXZFAYBWXNM<CIAGZBHOAUA<OAUMMLHDYFG>>>) KFQUNMKNCDX(this UnsafeList<byte> a, int b, int c, [Optional] Id32<CIAGZBHOAUA<OAUMMLHDYFG>>? d)
		{
			return default((Id32<DXZFAYBWXNM<JPROXOTIKYR>>, Id32<DXZFAYBWXNM<OAUMMLHDYFG>>, Id32<DXZFAYBWXNM<OAUMMLHDYFG>>, Id32<DXZFAYBWXNM<CIAGZBHOAUA<OAUMMLHDYFG>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x2ADE6C0", Offset = "0x2ADD4C0", VA = "0x182ADE6C0")]
		public static (Id32<DXZFAYBWXNM<JPROXOTIKYR>>, Id32<DXZFAYBWXNM<OAUMMLHDYFG>>, Id32<DXZFAYBWXNM<CIAGZBHOAUA<OAUMMLHDYFG>>>, Id32<DXZFAYBWXNM<CIAGZBHOAUA<OAUMMLHDYFG>>>) XHIFJJVPYCO(this UnsafeList<byte> a, int b, [Optional] Id32<CIAGZBHOAUA<OAUMMLHDYFG>>? c, [Optional] Id32<CIAGZBHOAUA<OAUMMLHDYFG>>? d)
		{
			return default((Id32<DXZFAYBWXNM<JPROXOTIKYR>>, Id32<DXZFAYBWXNM<OAUMMLHDYFG>>, Id32<DXZFAYBWXNM<CIAGZBHOAUA<OAUMMLHDYFG>>>, Id32<DXZFAYBWXNM<CIAGZBHOAUA<OAUMMLHDYFG>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x2ADA640", Offset = "0x2AD9440", VA = "0x182ADA640")]
		public static (Id32<DXZFAYBWXNM<JPROXOTIKYR>>, Id32<DXZFAYBWXNM<CIAGZBHOAUA<OAUMMLHDYFG>>>, Id32<DXZFAYBWXNM<CIAGZBHOAUA<OAUMMLHDYFG>>>, Id32<DXZFAYBWXNM<CIAGZBHOAUA<OAUMMLHDYFG>>>) EVUTBTCMCHJ(this UnsafeList<byte> a, [Optional] Id32<CIAGZBHOAUA<OAUMMLHDYFG>>? b, [Optional] Id32<CIAGZBHOAUA<OAUMMLHDYFG>>? c, [Optional] Id32<CIAGZBHOAUA<OAUMMLHDYFG>>? d)
		{
			return default((Id32<DXZFAYBWXNM<JPROXOTIKYR>>, Id32<DXZFAYBWXNM<CIAGZBHOAUA<OAUMMLHDYFG>>>, Id32<DXZFAYBWXNM<CIAGZBHOAUA<OAUMMLHDYFG>>>, Id32<DXZFAYBWXNM<CIAGZBHOAUA<OAUMMLHDYFG>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x2ADC710", Offset = "0x2ADB510", VA = "0x182ADC710")]
		public static (Id32<DXZFAYBWXNM<JPROXOTIKYR>>, Id32<DXZFAYBWXNM<MEHUWZMIAXD>>, Id32<DXZFAYBWXNM<MEHUWZMIAXD>>, Id32<DXZFAYBWXNM<CIAGZBHOAUA<OAUMMLHDYFG>>>) NEIJQCNPMCQ(this UnsafeList<byte> a, float b, float c, [Optional] Id32<CIAGZBHOAUA<OAUMMLHDYFG>>? d)
		{
			return default((Id32<DXZFAYBWXNM<JPROXOTIKYR>>, Id32<DXZFAYBWXNM<MEHUWZMIAXD>>, Id32<DXZFAYBWXNM<MEHUWZMIAXD>>, Id32<DXZFAYBWXNM<CIAGZBHOAUA<OAUMMLHDYFG>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x2ADBFD0", Offset = "0x2ADADD0", VA = "0x182ADBFD0")]
		public static (Id32<DXZFAYBWXNM<JPROXOTIKYR>>, Id32<DXZFAYBWXNM<MEHUWZMIAXD>>, Id32<DXZFAYBWXNM<CIAGZBHOAUA<MEHUWZMIAXD>>>, Id32<DXZFAYBWXNM<CIAGZBHOAUA<OAUMMLHDYFG>>>) KOBOFBHLBMX(this UnsafeList<byte> a, float b, [Optional] Id32<CIAGZBHOAUA<MEHUWZMIAXD>>? c, [Optional] Id32<CIAGZBHOAUA<OAUMMLHDYFG>>? d)
		{
			return default((Id32<DXZFAYBWXNM<JPROXOTIKYR>>, Id32<DXZFAYBWXNM<MEHUWZMIAXD>>, Id32<DXZFAYBWXNM<CIAGZBHOAUA<MEHUWZMIAXD>>>, Id32<DXZFAYBWXNM<CIAGZBHOAUA<OAUMMLHDYFG>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x2ADBD50", Offset = "0x2ADAB50", VA = "0x182ADBD50")]
		public static (Id32<DXZFAYBWXNM<JPROXOTIKYR>>, Id32<DXZFAYBWXNM<CIAGZBHOAUA<MEHUWZMIAXD>>>, Id32<DXZFAYBWXNM<CIAGZBHOAUA<MEHUWZMIAXD>>>, Id32<DXZFAYBWXNM<CIAGZBHOAUA<OAUMMLHDYFG>>>) KHMFWPVMFXE(this UnsafeList<byte> a, [Optional] Id32<CIAGZBHOAUA<MEHUWZMIAXD>>? b, [Optional] Id32<CIAGZBHOAUA<MEHUWZMIAXD>>? c, [Optional] Id32<CIAGZBHOAUA<OAUMMLHDYFG>>? d)
		{
			return default((Id32<DXZFAYBWXNM<JPROXOTIKYR>>, Id32<DXZFAYBWXNM<CIAGZBHOAUA<MEHUWZMIAXD>>>, Id32<DXZFAYBWXNM<CIAGZBHOAUA<MEHUWZMIAXD>>>, Id32<DXZFAYBWXNM<CIAGZBHOAUA<OAUMMLHDYFG>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x2AD9FF0", Offset = "0x2AD8DF0", VA = "0x182AD9FF0")]
		public static (Id32<DXZFAYBWXNM<JPROXOTIKYR>>, Id32<DXZFAYBWXNM<OAUMMLHDYFG>>, Id32<DXZFAYBWXNM<OAUMMLHDYFG>>, Id32<DXZFAYBWXNM<CIAGZBHOAUA<OAUMMLHDYFG>>>) DBZRZJJWLKB(this UnsafeList<byte> a, int b, int c, [Optional] Id32<CIAGZBHOAUA<OAUMMLHDYFG>>? d)
		{
			return default((Id32<DXZFAYBWXNM<JPROXOTIKYR>>, Id32<DXZFAYBWXNM<OAUMMLHDYFG>>, Id32<DXZFAYBWXNM<OAUMMLHDYFG>>, Id32<DXZFAYBWXNM<CIAGZBHOAUA<OAUMMLHDYFG>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x2ADA760", Offset = "0x2AD9560", VA = "0x182ADA760")]
		public static (Id32<DXZFAYBWXNM<JPROXOTIKYR>>, Id32<DXZFAYBWXNM<OAUMMLHDYFG>>, Id32<DXZFAYBWXNM<CIAGZBHOAUA<OAUMMLHDYFG>>>, Id32<DXZFAYBWXNM<CIAGZBHOAUA<OAUMMLHDYFG>>>) FDUSUKYPQZU(this UnsafeList<byte> a, int b, [Optional] Id32<CIAGZBHOAUA<OAUMMLHDYFG>>? c, [Optional] Id32<CIAGZBHOAUA<OAUMMLHDYFG>>? d)
		{
			return default((Id32<DXZFAYBWXNM<JPROXOTIKYR>>, Id32<DXZFAYBWXNM<OAUMMLHDYFG>>, Id32<DXZFAYBWXNM<CIAGZBHOAUA<OAUMMLHDYFG>>>, Id32<DXZFAYBWXNM<CIAGZBHOAUA<OAUMMLHDYFG>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x2ADD220", Offset = "0x2ADC020", VA = "0x182ADD220")]
		public static (Id32<DXZFAYBWXNM<JPROXOTIKYR>>, Id32<DXZFAYBWXNM<CIAGZBHOAUA<OAUMMLHDYFG>>>, Id32<DXZFAYBWXNM<CIAGZBHOAUA<OAUMMLHDYFG>>>, Id32<DXZFAYBWXNM<CIAGZBHOAUA<OAUMMLHDYFG>>>) RIOZUMUOQTV(this UnsafeList<byte> a, [Optional] Id32<CIAGZBHOAUA<OAUMMLHDYFG>>? b, [Optional] Id32<CIAGZBHOAUA<OAUMMLHDYFG>>? c, [Optional] Id32<CIAGZBHOAUA<OAUMMLHDYFG>>? d)
		{
			return default((Id32<DXZFAYBWXNM<JPROXOTIKYR>>, Id32<DXZFAYBWXNM<CIAGZBHOAUA<OAUMMLHDYFG>>>, Id32<DXZFAYBWXNM<CIAGZBHOAUA<OAUMMLHDYFG>>>, Id32<DXZFAYBWXNM<CIAGZBHOAUA<OAUMMLHDYFG>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x2ADAA00", Offset = "0x2AD9800", VA = "0x182ADAA00")]
		public static (Id32<DXZFAYBWXNM<JPROXOTIKYR>>, Id32<DXZFAYBWXNM<MEHUWZMIAXD>>, Id32<DXZFAYBWXNM<MEHUWZMIAXD>>, Id32<DXZFAYBWXNM<CIAGZBHOAUA<OAUMMLHDYFG>>>) GQXZYMFADPJ(this UnsafeList<byte> a, float b, float c, [Optional] Id32<CIAGZBHOAUA<OAUMMLHDYFG>>? d)
		{
			return default((Id32<DXZFAYBWXNM<JPROXOTIKYR>>, Id32<DXZFAYBWXNM<MEHUWZMIAXD>>, Id32<DXZFAYBWXNM<MEHUWZMIAXD>>, Id32<DXZFAYBWXNM<CIAGZBHOAUA<OAUMMLHDYFG>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x2ADA150", Offset = "0x2AD8F50", VA = "0x182ADA150")]
		public static (Id32<DXZFAYBWXNM<JPROXOTIKYR>>, Id32<DXZFAYBWXNM<MEHUWZMIAXD>>, Id32<DXZFAYBWXNM<CIAGZBHOAUA<MEHUWZMIAXD>>>, Id32<DXZFAYBWXNM<CIAGZBHOAUA<OAUMMLHDYFG>>>) DQVJTDNXQTW(this UnsafeList<byte> a, float b, [Optional] Id32<CIAGZBHOAUA<MEHUWZMIAXD>>? c, [Optional] Id32<CIAGZBHOAUA<OAUMMLHDYFG>>? d)
		{
			return default((Id32<DXZFAYBWXNM<JPROXOTIKYR>>, Id32<DXZFAYBWXNM<MEHUWZMIAXD>>, Id32<DXZFAYBWXNM<CIAGZBHOAUA<MEHUWZMIAXD>>>, Id32<DXZFAYBWXNM<CIAGZBHOAUA<OAUMMLHDYFG>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x2ADB800", Offset = "0x2ADA600", VA = "0x182ADB800")]
		public static (Id32<DXZFAYBWXNM<JPROXOTIKYR>>, Id32<DXZFAYBWXNM<CIAGZBHOAUA<MEHUWZMIAXD>>>, Id32<DXZFAYBWXNM<CIAGZBHOAUA<MEHUWZMIAXD>>>, Id32<DXZFAYBWXNM<CIAGZBHOAUA<OAUMMLHDYFG>>>) JOOHWZBMACR(this UnsafeList<byte> a, [Optional] Id32<CIAGZBHOAUA<MEHUWZMIAXD>>? b, [Optional] Id32<CIAGZBHOAUA<MEHUWZMIAXD>>? c, [Optional] Id32<CIAGZBHOAUA<OAUMMLHDYFG>>? d)
		{
			return default((Id32<DXZFAYBWXNM<JPROXOTIKYR>>, Id32<DXZFAYBWXNM<CIAGZBHOAUA<MEHUWZMIAXD>>>, Id32<DXZFAYBWXNM<CIAGZBHOAUA<MEHUWZMIAXD>>>, Id32<DXZFAYBWXNM<CIAGZBHOAUA<OAUMMLHDYFG>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x2ADC9E0", Offset = "0x2ADB7E0", VA = "0x182ADC9E0")]
		public static (Id32<DXZFAYBWXNM<JPROXOTIKYR>>, Id32<DXZFAYBWXNM<OAUMMLHDYFG>>, Id32<DXZFAYBWXNM<OAUMMLHDYFG>>, Id32<DXZFAYBWXNM<CIAGZBHOAUA<OAUMMLHDYFG>>>) PHFJZQVZGQC(this UnsafeList<byte> a, int b, int c, [Optional] Id32<CIAGZBHOAUA<OAUMMLHDYFG>>? d)
		{
			return default((Id32<DXZFAYBWXNM<JPROXOTIKYR>>, Id32<DXZFAYBWXNM<OAUMMLHDYFG>>, Id32<DXZFAYBWXNM<OAUMMLHDYFG>>, Id32<DXZFAYBWXNM<CIAGZBHOAUA<OAUMMLHDYFG>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x2AD9A80", Offset = "0x2AD8880", VA = "0x182AD9A80")]
		public static (Id32<DXZFAYBWXNM<JPROXOTIKYR>>, Id32<DXZFAYBWXNM<OAUMMLHDYFG>>, Id32<DXZFAYBWXNM<CIAGZBHOAUA<OAUMMLHDYFG>>>, Id32<DXZFAYBWXNM<CIAGZBHOAUA<OAUMMLHDYFG>>>) AXUBPBYCMAN(this UnsafeList<byte> a, int b, [Optional] Id32<CIAGZBHOAUA<OAUMMLHDYFG>>? c, [Optional] Id32<CIAGZBHOAUA<OAUMMLHDYFG>>? d)
		{
			return default((Id32<DXZFAYBWXNM<JPROXOTIKYR>>, Id32<DXZFAYBWXNM<OAUMMLHDYFG>>, Id32<DXZFAYBWXNM<CIAGZBHOAUA<OAUMMLHDYFG>>>, Id32<DXZFAYBWXNM<CIAGZBHOAUA<OAUMMLHDYFG>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x2ADD860", Offset = "0x2ADC660", VA = "0x182ADD860")]
		public static (Id32<DXZFAYBWXNM<JPROXOTIKYR>>, Id32<DXZFAYBWXNM<CIAGZBHOAUA<OAUMMLHDYFG>>>, Id32<DXZFAYBWXNM<CIAGZBHOAUA<OAUMMLHDYFG>>>, Id32<DXZFAYBWXNM<CIAGZBHOAUA<OAUMMLHDYFG>>>) SQSKALLOJDS(this UnsafeList<byte> a, [Optional] Id32<CIAGZBHOAUA<OAUMMLHDYFG>>? b, [Optional] Id32<CIAGZBHOAUA<OAUMMLHDYFG>>? c, [Optional] Id32<CIAGZBHOAUA<OAUMMLHDYFG>>? d)
		{
			return default((Id32<DXZFAYBWXNM<JPROXOTIKYR>>, Id32<DXZFAYBWXNM<CIAGZBHOAUA<OAUMMLHDYFG>>>, Id32<DXZFAYBWXNM<CIAGZBHOAUA<OAUMMLHDYFG>>>, Id32<DXZFAYBWXNM<CIAGZBHOAUA<OAUMMLHDYFG>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x2AD9900", Offset = "0x2AD8700", VA = "0x182AD9900")]
		public static (Id32<DXZFAYBWXNM<JPROXOTIKYR>>, Id32<DXZFAYBWXNM<MEHUWZMIAXD>>, Id32<DXZFAYBWXNM<MEHUWZMIAXD>>, Id32<DXZFAYBWXNM<CIAGZBHOAUA<MEHUWZMIAXD>>>) ANOJFHRDOYG(this UnsafeList<byte> a, float b, float c, [Optional] Id32<CIAGZBHOAUA<MEHUWZMIAXD>>? d)
		{
			return default((Id32<DXZFAYBWXNM<JPROXOTIKYR>>, Id32<DXZFAYBWXNM<MEHUWZMIAXD>>, Id32<DXZFAYBWXNM<MEHUWZMIAXD>>, Id32<DXZFAYBWXNM<CIAGZBHOAUA<MEHUWZMIAXD>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x2ADE450", Offset = "0x2ADD250", VA = "0x182ADE450")]
		public static (Id32<DXZFAYBWXNM<JPROXOTIKYR>>, Id32<DXZFAYBWXNM<MEHUWZMIAXD>>, Id32<DXZFAYBWXNM<CIAGZBHOAUA<MEHUWZMIAXD>>>, Id32<DXZFAYBWXNM<CIAGZBHOAUA<MEHUWZMIAXD>>>) WLEAZHMRWYB(this UnsafeList<byte> a, float b, [Optional] Id32<CIAGZBHOAUA<MEHUWZMIAXD>>? c, [Optional] Id32<CIAGZBHOAUA<MEHUWZMIAXD>>? d)
		{
			return default((Id32<DXZFAYBWXNM<JPROXOTIKYR>>, Id32<DXZFAYBWXNM<MEHUWZMIAXD>>, Id32<DXZFAYBWXNM<CIAGZBHOAUA<MEHUWZMIAXD>>>, Id32<DXZFAYBWXNM<CIAGZBHOAUA<MEHUWZMIAXD>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x2ADB6E0", Offset = "0x2ADA4E0", VA = "0x182ADB6E0")]
		public static (Id32<DXZFAYBWXNM<JPROXOTIKYR>>, Id32<DXZFAYBWXNM<CIAGZBHOAUA<MEHUWZMIAXD>>>, Id32<DXZFAYBWXNM<CIAGZBHOAUA<MEHUWZMIAXD>>>, Id32<DXZFAYBWXNM<CIAGZBHOAUA<MEHUWZMIAXD>>>) JLEAVFQZPIA(this UnsafeList<byte> a, [Optional] Id32<CIAGZBHOAUA<MEHUWZMIAXD>>? b, [Optional] Id32<CIAGZBHOAUA<MEHUWZMIAXD>>? c, [Optional] Id32<CIAGZBHOAUA<MEHUWZMIAXD>>? d)
		{
			return default((Id32<DXZFAYBWXNM<JPROXOTIKYR>>, Id32<DXZFAYBWXNM<CIAGZBHOAUA<MEHUWZMIAXD>>>, Id32<DXZFAYBWXNM<CIAGZBHOAUA<MEHUWZMIAXD>>>, Id32<DXZFAYBWXNM<CIAGZBHOAUA<MEHUWZMIAXD>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x2ADD470", Offset = "0x2ADC270", VA = "0x182ADD470")]
		public static (Id32<DXZFAYBWXNM<JPROXOTIKYR>>, Id32<DXZFAYBWXNM<OAUMMLHDYFG>>, Id32<DXZFAYBWXNM<OAUMMLHDYFG>>, Id32<DXZFAYBWXNM<CIAGZBHOAUA<OAUMMLHDYFG>>>) RMJASMAPHJW(this UnsafeList<byte> a, int b, int c, [Optional] Id32<CIAGZBHOAUA<OAUMMLHDYFG>>? d)
		{
			return default((Id32<DXZFAYBWXNM<JPROXOTIKYR>>, Id32<DXZFAYBWXNM<OAUMMLHDYFG>>, Id32<DXZFAYBWXNM<OAUMMLHDYFG>>, Id32<DXZFAYBWXNM<CIAGZBHOAUA<OAUMMLHDYFG>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x2ADC220", Offset = "0x2ADB020", VA = "0x182ADC220")]
		public static (Id32<DXZFAYBWXNM<JPROXOTIKYR>>, Id32<DXZFAYBWXNM<OAUMMLHDYFG>>, Id32<DXZFAYBWXNM<CIAGZBHOAUA<OAUMMLHDYFG>>>, Id32<DXZFAYBWXNM<CIAGZBHOAUA<OAUMMLHDYFG>>>) LSWDWMYDOWX(this UnsafeList<byte> a, int b, [Optional] Id32<CIAGZBHOAUA<OAUMMLHDYFG>>? c, [Optional] Id32<CIAGZBHOAUA<OAUMMLHDYFG>>? d)
		{
			return default((Id32<DXZFAYBWXNM<JPROXOTIKYR>>, Id32<DXZFAYBWXNM<OAUMMLHDYFG>>, Id32<DXZFAYBWXNM<CIAGZBHOAUA<OAUMMLHDYFG>>>, Id32<DXZFAYBWXNM<CIAGZBHOAUA<OAUMMLHDYFG>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x2ADE0D0", Offset = "0x2ADCED0", VA = "0x182ADE0D0")]
		public static (Id32<DXZFAYBWXNM<JPROXOTIKYR>>, Id32<DXZFAYBWXNM<CIAGZBHOAUA<OAUMMLHDYFG>>>, Id32<DXZFAYBWXNM<CIAGZBHOAUA<OAUMMLHDYFG>>>, Id32<DXZFAYBWXNM<CIAGZBHOAUA<OAUMMLHDYFG>>>) VHMAGZNIHMC(this UnsafeList<byte> a, [Optional] Id32<CIAGZBHOAUA<OAUMMLHDYFG>>? b, [Optional] Id32<CIAGZBHOAUA<OAUMMLHDYFG>>? c, [Optional] Id32<CIAGZBHOAUA<OAUMMLHDYFG>>? d)
		{
			return default((Id32<DXZFAYBWXNM<JPROXOTIKYR>>, Id32<DXZFAYBWXNM<CIAGZBHOAUA<OAUMMLHDYFG>>>, Id32<DXZFAYBWXNM<CIAGZBHOAUA<OAUMMLHDYFG>>>, Id32<DXZFAYBWXNM<CIAGZBHOAUA<OAUMMLHDYFG>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x2ADDFC0", Offset = "0x2ADCDC0", VA = "0x182ADDFC0")]
		public static (Id32<DXZFAYBWXNM<JPROXOTIKYR>>, Id32<DXZFAYBWXNM<OAUMMLHDYFG>>, Id32<DXZFAYBWXNM<CIAGZBHOAUA<OAUMMLHDYFG>>>) UXKSYNCHZUH(this UnsafeList<byte> a, [Optional] int? b, [Optional] Id32<CIAGZBHOAUA<OAUMMLHDYFG>>? c)
		{
			return default((Id32<DXZFAYBWXNM<JPROXOTIKYR>>, Id32<DXZFAYBWXNM<OAUMMLHDYFG>>, Id32<DXZFAYBWXNM<CIAGZBHOAUA<OAUMMLHDYFG>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x2ADCFC0", Offset = "0x2ADBDC0", VA = "0x182ADCFC0")]
		public static (Id32<DXZFAYBWXNM<JPROXOTIKYR>>, Id32<DXZFAYBWXNM<CIAGZBHOAUA<OAUMMLHDYFG>>>, Id32<DXZFAYBWXNM<CIAGZBHOAUA<OAUMMLHDYFG>>>) QJUSPLWBCYM(this UnsafeList<byte> a, [Optional] Id32<CIAGZBHOAUA<OAUMMLHDYFG>>? b, [Optional] Id32<CIAGZBHOAUA<OAUMMLHDYFG>>? c)
		{
			return default((Id32<DXZFAYBWXNM<JPROXOTIKYR>>, Id32<DXZFAYBWXNM<CIAGZBHOAUA<OAUMMLHDYFG>>>, Id32<DXZFAYBWXNM<CIAGZBHOAUA<OAUMMLHDYFG>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x2ADCB40", Offset = "0x2ADB940", VA = "0x182ADCB40")]
		public static Id32<DXZFAYBWXNM<JPROXOTIKYR>> PJAWMZVBYDX(this UnsafeList<byte> a)
		{
			return default(Id32<DXZFAYBWXNM<JPROXOTIKYR>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x2ADD980", Offset = "0x2ADC780", VA = "0x182ADD980")]
		public static (Id32<DXZFAYBWXNM<JPROXOTIKYR>>, Id32<DXZFAYBWXNM<MEHUWZMIAXD>>, Id32<DXZFAYBWXNM<MEHUWZMIAXD>>, Id32<DXZFAYBWXNM<CIAGZBHOAUA<MEHUWZMIAXD>>>) SUHMKQGDIOW(this UnsafeList<byte> a, float b, float c, [Optional] Id32<CIAGZBHOAUA<MEHUWZMIAXD>>? d)
		{
			return default((Id32<DXZFAYBWXNM<JPROXOTIKYR>>, Id32<DXZFAYBWXNM<MEHUWZMIAXD>>, Id32<DXZFAYBWXNM<MEHUWZMIAXD>>, Id32<DXZFAYBWXNM<CIAGZBHOAUA<MEHUWZMIAXD>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x2ADB590", Offset = "0x2ADA390", VA = "0x182ADB590")]
		public static (Id32<DXZFAYBWXNM<JPROXOTIKYR>>, Id32<DXZFAYBWXNM<MEHUWZMIAXD>>, Id32<DXZFAYBWXNM<CIAGZBHOAUA<MEHUWZMIAXD>>>, Id32<DXZFAYBWXNM<CIAGZBHOAUA<MEHUWZMIAXD>>>) IXXDAFAWXPD(this UnsafeList<byte> a, float b, [Optional] Id32<CIAGZBHOAUA<MEHUWZMIAXD>>? c, [Optional] Id32<CIAGZBHOAUA<MEHUWZMIAXD>>? d)
		{
			return default((Id32<DXZFAYBWXNM<JPROXOTIKYR>>, Id32<DXZFAYBWXNM<MEHUWZMIAXD>>, Id32<DXZFAYBWXNM<CIAGZBHOAUA<MEHUWZMIAXD>>>, Id32<DXZFAYBWXNM<CIAGZBHOAUA<MEHUWZMIAXD>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x2ADDB00", Offset = "0x2ADC900", VA = "0x182ADDB00")]
		public static (Id32<DXZFAYBWXNM<JPROXOTIKYR>>, Id32<DXZFAYBWXNM<CIAGZBHOAUA<MEHUWZMIAXD>>>, Id32<DXZFAYBWXNM<CIAGZBHOAUA<MEHUWZMIAXD>>>, Id32<DXZFAYBWXNM<CIAGZBHOAUA<MEHUWZMIAXD>>>) TBQUSKRNHIU(this UnsafeList<byte> a, [Optional] Id32<CIAGZBHOAUA<MEHUWZMIAXD>>? b, [Optional] Id32<CIAGZBHOAUA<MEHUWZMIAXD>>? c, [Optional] Id32<CIAGZBHOAUA<MEHUWZMIAXD>>? d)
		{
			return default((Id32<DXZFAYBWXNM<JPROXOTIKYR>>, Id32<DXZFAYBWXNM<CIAGZBHOAUA<MEHUWZMIAXD>>>, Id32<DXZFAYBWXNM<CIAGZBHOAUA<MEHUWZMIAXD>>>, Id32<DXZFAYBWXNM<CIAGZBHOAUA<MEHUWZMIAXD>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x2ADC370", Offset = "0x2ADB170", VA = "0x182ADC370")]
		public static (Id32<DXZFAYBWXNM<JPROXOTIKYR>>, Id32<DXZFAYBWXNM<OAUMMLHDYFG>>, Id32<DXZFAYBWXNM<OAUMMLHDYFG>>, Id32<DXZFAYBWXNM<CIAGZBHOAUA<OAUMMLHDYFG>>>) LTZMOWMZHAU(this UnsafeList<byte> a, int b, int c, [Optional] Id32<CIAGZBHOAUA<OAUMMLHDYFG>>? d)
		{
			return default((Id32<DXZFAYBWXNM<JPROXOTIKYR>>, Id32<DXZFAYBWXNM<OAUMMLHDYFG>>, Id32<DXZFAYBWXNM<OAUMMLHDYFG>>, Id32<DXZFAYBWXNM<CIAGZBHOAUA<OAUMMLHDYFG>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x2ADC890", Offset = "0x2ADB690", VA = "0x182ADC890")]
		public static (Id32<DXZFAYBWXNM<JPROXOTIKYR>>, Id32<DXZFAYBWXNM<OAUMMLHDYFG>>, Id32<DXZFAYBWXNM<CIAGZBHOAUA<OAUMMLHDYFG>>>, Id32<DXZFAYBWXNM<CIAGZBHOAUA<OAUMMLHDYFG>>>) NNKRPGHOUVF(this UnsafeList<byte> a, int b, [Optional] Id32<CIAGZBHOAUA<OAUMMLHDYFG>>? c, [Optional] Id32<CIAGZBHOAUA<OAUMMLHDYFG>>? d)
		{
			return default((Id32<DXZFAYBWXNM<JPROXOTIKYR>>, Id32<DXZFAYBWXNM<OAUMMLHDYFG>>, Id32<DXZFAYBWXNM<CIAGZBHOAUA<OAUMMLHDYFG>>>, Id32<DXZFAYBWXNM<CIAGZBHOAUA<OAUMMLHDYFG>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x2ADDD80", Offset = "0x2ADCB80", VA = "0x182ADDD80")]
		public static (Id32<DXZFAYBWXNM<JPROXOTIKYR>>, Id32<DXZFAYBWXNM<CIAGZBHOAUA<OAUMMLHDYFG>>>, Id32<DXZFAYBWXNM<CIAGZBHOAUA<OAUMMLHDYFG>>>, Id32<DXZFAYBWXNM<CIAGZBHOAUA<OAUMMLHDYFG>>>) UHZFXRTGKWW(this UnsafeList<byte> a, [Optional] Id32<CIAGZBHOAUA<OAUMMLHDYFG>>? b, [Optional] Id32<CIAGZBHOAUA<OAUMMLHDYFG>>? c, [Optional] Id32<CIAGZBHOAUA<OAUMMLHDYFG>>? d)
		{
			return default((Id32<DXZFAYBWXNM<JPROXOTIKYR>>, Id32<DXZFAYBWXNM<CIAGZBHOAUA<OAUMMLHDYFG>>>, Id32<DXZFAYBWXNM<CIAGZBHOAUA<OAUMMLHDYFG>>>, Id32<DXZFAYBWXNM<CIAGZBHOAUA<OAUMMLHDYFG>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x2AD9E90", Offset = "0x2AD8C90", VA = "0x182AD9E90")]
		public static (Id32<DXZFAYBWXNM<JPROXOTIKYR>>, Id32<DXZFAYBWXNM<OAUMMLHDYFG>>, Id32<DXZFAYBWXNM<OAUMMLHDYFG>>, Id32<DXZFAYBWXNM<CIAGZBHOAUA<OAUMMLHDYFG>>>) CWDKDAPWEIL(this UnsafeList<byte> a, int b, int c, [Optional] Id32<CIAGZBHOAUA<OAUMMLHDYFG>>? d)
		{
			return default((Id32<DXZFAYBWXNM<JPROXOTIKYR>>, Id32<DXZFAYBWXNM<OAUMMLHDYFG>>, Id32<DXZFAYBWXNM<OAUMMLHDYFG>>, Id32<DXZFAYBWXNM<CIAGZBHOAUA<OAUMMLHDYFG>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x2ADED80", Offset = "0x2ADDB80", VA = "0x182ADED80")]
		public static (Id32<DXZFAYBWXNM<JPROXOTIKYR>>, Id32<DXZFAYBWXNM<OAUMMLHDYFG>>, Id32<DXZFAYBWXNM<CIAGZBHOAUA<OAUMMLHDYFG>>>, Id32<DXZFAYBWXNM<CIAGZBHOAUA<OAUMMLHDYFG>>>) YYFRTZWBKRC(this UnsafeList<byte> a, int b, [Optional] Id32<CIAGZBHOAUA<OAUMMLHDYFG>>? c, [Optional] Id32<CIAGZBHOAUA<OAUMMLHDYFG>>? d)
		{
			return default((Id32<DXZFAYBWXNM<JPROXOTIKYR>>, Id32<DXZFAYBWXNM<OAUMMLHDYFG>>, Id32<DXZFAYBWXNM<CIAGZBHOAUA<OAUMMLHDYFG>>>, Id32<DXZFAYBWXNM<CIAGZBHOAUA<OAUMMLHDYFG>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x2ADF020", Offset = "0x2ADDE20", VA = "0x182ADF020")]
		public static (Id32<DXZFAYBWXNM<JPROXOTIKYR>>, Id32<DXZFAYBWXNM<CIAGZBHOAUA<OAUMMLHDYFG>>>, Id32<DXZFAYBWXNM<CIAGZBHOAUA<OAUMMLHDYFG>>>, Id32<DXZFAYBWXNM<CIAGZBHOAUA<OAUMMLHDYFG>>>) ZUIYAZIEMCB(this UnsafeList<byte> a, [Optional] Id32<CIAGZBHOAUA<OAUMMLHDYFG>>? b, [Optional] Id32<CIAGZBHOAUA<OAUMMLHDYFG>>? c, [Optional] Id32<CIAGZBHOAUA<OAUMMLHDYFG>>? d)
		{
			return default((Id32<DXZFAYBWXNM<JPROXOTIKYR>>, Id32<DXZFAYBWXNM<CIAGZBHOAUA<OAUMMLHDYFG>>>, Id32<DXZFAYBWXNM<CIAGZBHOAUA<OAUMMLHDYFG>>>, Id32<DXZFAYBWXNM<CIAGZBHOAUA<OAUMMLHDYFG>>>));
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
