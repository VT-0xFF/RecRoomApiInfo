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
		[Cpp2IlInjected.Address(RVA = "0xD0FDB0", Offset = "0xD0EBB0", VA = "0x180D0FDB0")]
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
		[Cpp2IlInjected.Address(RVA = "0x2B6C690", Offset = "0x2B6B490", VA = "0x182B6C690")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xD10080", Offset = "0xD0EE80", VA = "0x180D10080")]
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
		[Cpp2IlInjected.Address(RVA = "0xD100C0", Offset = "0xD0EEC0", VA = "0x180D100C0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
namespace Circuits.Shared.Core.ByteCode
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public static class VOARQCJAOUW
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x40C2A10", Offset = "0x40C1810", VA = "0x1840C2A10")]
		public static Id32<WXKPXITHDLK<a>> JLRXYMXSZKU<a>(this int a)
		{
			return default(Id32<WXKPXITHDLK<a>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x2B6C710", Offset = "0x2B6B510", VA = "0x182B6C710")]
		public static Id32<GQSCCKHWVOV> IFQEZZKSSEF(this int a)
		{
			return default(Id32<GQSCCKHWVOV>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x40C2A10", Offset = "0x40C1810", VA = "0x1840C2A10")]
		public static Id32<IXKHGZWDMFU<b>> PFIZFDBGOOS<b>(this int a)
		{
			return default(Id32<IXKHGZWDMFU<b>>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public sealed class WXKPXITHDLK<a>
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public sealed class XZWASXESRJR
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public sealed class CXMCVELPQUC
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public sealed class GQSCCKHWVOV
	{
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public sealed class VABZENOIJNF
	{
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public sealed class FRPUBIFEUNX
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
	public static class LIVRQFOHDMC
	{
		[Cpp2IlInjected.Token(Token = "0x200000E")]
		public readonly struct ProcessOpDelegate<TContext, TDeps, TCompileState>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000091")]
			private readonly IntPtr _impl;

			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0xEBF7D0", Offset = "0xEBE5D0", VA = "0x180EBF7D0")]
			public ProcessOpDelegate(IntPtr impl)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x756DAD0", Offset = "0x756C8D0", VA = "0x18756DAD0")]
			public int Invoke(TDeps deps, TContext ctx, TCompileState compileState, [In] UnsafeList<byte> fromByteCode, int byteCodePtr)
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x3BCC6E0", Offset = "0x3BCB4E0", VA = "0x183BCC6E0")]
		public static void OCKWTTKZKNH<TDeps, TContext, TCompileState>(TDeps a, TContext b, TCompileState c, [In] UnsafeList<byte> oldByteCode, UnsafeList<byte> newByteCode, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processAddF32_F32i_F32i_F32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processAddF32_F32i_F32r_F32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processAddF32_F32r_F32r_F32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processAddI32_I32i_I32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processAddI32_I32i_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processAddI32_I32r_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processAndI32_I32i_I32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processAndI32_I32i_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processAndI32_I32r_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfEqualF32_F32i_F32i_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfEqualF32_F32i_F32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfEqualF32_F32r_F32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfEqualI32_I32i_I32i_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfEqualI32_I32i_I32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfEqualI32_I32r_I32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfGreaterOrEqualF32_F32i_F32i_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfGreaterOrEqualF32_F32i_F32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfGreaterOrEqualF32_F32r_F32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfGreaterOrEqualI32_I32i_I32i_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfGreaterOrEqualI32_I32i_I32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfGreaterOrEqualI32_I32r_I32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfLessF32_F32i_F32i_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfLessF32_F32i_F32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfLessF32_F32r_F32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfLessI32_I32i_I32i_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfLessI32_I32i_I32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfLessI32_I32r_I32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfLessOrEqualF32_F32i_F32i_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfLessOrEqualF32_F32i_F32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfLessOrEqualF32_F32r_F32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfLessOrEqualI32_I32i_I32i_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfLessOrEqualI32_I32i_I32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfLessOrEqualI32_I32r_I32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfNotEqualF32_F32i_F32i_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfNotEqualF32_F32i_F32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfNotEqualF32_F32r_F32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfNotEqualI32_I32i_I32i_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfNotEqualI32_I32i_I32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfNotEqualI32_I32r_I32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfNotZeroF32_F32i_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfNotZeroF32_F32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfNotZeroI32_I32i_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfNotZeroI32_I32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfZeroF32_F32i_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfZeroF32_F32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfZeroI32_I32i_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processBranchIfZeroI32_I32r_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processCallInternal_I32i_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processCallInternal_I32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processCallExternal_I32i_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processCallExternal_I32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processCallRuntime_I32i_I32i_Xi, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processCopyI32_I32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processCopyI32_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processCopyX_Xr_I32i_Xi, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processCopyX_Xr_Xr_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processDivideF32_F32i_F32i_F32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processDivideF32_F32i_F32r_F32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processDivideF32_F32r_F32r_F32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processDivideI32_I32i_I32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processDivideI32_I32i_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processDivideI32_I32r_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processEqualF32_F32i_F32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processEqualF32_F32i_F32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processEqualF32_F32r_F32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processEqualI32_I32i_I32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processEqualI32_I32i_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processEqualI32_I32r_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processEnd, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processGreaterF32_F32i_F32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processGreaterF32_F32i_F32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processGreaterF32_F32r_F32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processGreaterI32_I32i_I32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processGreaterI32_I32i_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processGreaterI32_I32r_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processGreaterOrEqualF32_F32i_F32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processGreaterOrEqualF32_F32i_F32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processGreaterOrEqualF32_F32r_F32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processGreaterOrEqualI32_I32i_I32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processGreaterOrEqualI32_I32i_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processGreaterOrEqualI32_I32r_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processJump_I32i, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processJump_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processLessF32_F32i_F32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processLessF32_F32i_F32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processLessF32_F32r_F32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processLessI32_I32i_I32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processLessI32_I32i_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processLessI32_I32r_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processLessOrEqualF32_F32i_F32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processLessOrEqualF32_F32i_F32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processLessOrEqualF32_F32r_F32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processLessOrEqualI32_I32i_I32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processLessOrEqualI32_I32i_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processLessOrEqualI32_I32r_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processModI32_I32i_I32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processModI32_I32i_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processModI32_I32r_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processMultiplyF32_F32i_F32i_F32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processMultiplyF32_F32i_F32r_F32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processMultiplyF32_F32r_F32r_F32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processMultiplyI32_I32i_I32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processMultiplyI32_I32i_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processMultiplyI32_I32r_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processNegateF32_F32i_F32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processNegateF32_F32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processNegateF32_F32r_F32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processNegateI32_I32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processNegateI32_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processNegateI32_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processNoOp, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processNotEqualF32_F32i_F32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processNotEqualF32_F32i_F32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processNotEqualF32_F32r_F32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processNotEqualI32_I32i_I32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processNotEqualI32_I32i_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processNotEqualI32_I32r_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processNotI32_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processNotI32_I32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processNotI32_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processOrI32_I32i_I32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processOrI32_I32i_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processOrI32_I32r_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processReturn, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processStaticCastF32I32_F32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processStaticCastI32F32_I32r_F32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processSubtractF32_F32i_F32i_F32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processSubtractF32_F32i_F32r_F32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processSubtractF32_F32r_F32r_F32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processSubtractI32_I32i_I32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processSubtractI32_I32i_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processSubtractI32_I32r_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processXorI32_I32i_I32i_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processXorI32_I32i_I32r_I32r, [Optional] ProcessOpDelegate<TContext, TDeps, TCompileState>? processXorI32_I32r_I32r_I32r) where TDeps : notnull where TContext : notnull where TCompileState : notnull
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x2B6C5F0", Offset = "0x2B6B3F0", VA = "0x182B6C5F0")]
		private static int WGHKTVJLLUP([In] UnsafeList<byte> from, UnsafeList<byte> a, int b, int c)
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public static class GBGBFCBRUXX
	{
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		public static readonly int NEKDIGOLBFD;

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x3ABDD90", Offset = "0x3ABCB90", VA = "0x183ABDD90")]
		public static Id32<WXKPXITHDLK<a>> CVTSUYBSWXR<a>([In] this UnsafeList<byte> self)
		{
			return default(Id32<WXKPXITHDLK<a>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x3ABDEF0", Offset = "0x3ABCCF0", VA = "0x183ABDEF0")]
		public static Id32<WXKPXITHDLK<WXKPXITHDLK<b>>> DXWQSOXWPFC<b>(this UnsafeList<byte> a, [Optional] Id32<WXKPXITHDLK<b>>? b)
		{
			return default(Id32<WXKPXITHDLK<WXKPXITHDLK<b>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x2B6C1D0", Offset = "0x2B6AFD0", VA = "0x182B6C1D0")]
		public static Id32<WXKPXITHDLK<OYXCYVSZNSL>> PEMFXOIHCXA(this UnsafeList<byte> a, [Optional] Id32<OYXCYVSZNSL>? b)
		{
			return default(Id32<WXKPXITHDLK<OYXCYVSZNSL>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x2B6BF00", Offset = "0x2B6AD00", VA = "0x182B6BF00")]
		public static Id32<WXKPXITHDLK<XZWASXESRJR>> IMAAEUNDLIY(this UnsafeList<byte> a, [Optional] float? b)
		{
			return default(Id32<WXKPXITHDLK<XZWASXESRJR>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x2B6BFF0", Offset = "0x2B6ADF0", VA = "0x182B6BFF0")]
		public static Id32<WXKPXITHDLK<CXMCVELPQUC>> MVAJXDWTNEZ(this UnsafeList<byte> a, [Optional] int? b)
		{
			return default(Id32<WXKPXITHDLK<CXMCVELPQUC>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x2B6BE10", Offset = "0x2B6AC10", VA = "0x182B6BE10")]
		public static Id32<WXKPXITHDLK<IUBIECDJGSA>> FUNUFRNDTJV(this UnsafeList<byte> a, [Optional] Id32<IUBIECDJGSA>? b)
		{
			return default(Id32<WXKPXITHDLK<IUBIECDJGSA>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x2B6C0D0", Offset = "0x2B6AED0", VA = "0x182B6C0D0")]
		public static Id32<WXKPXITHDLK<FRPUBIFEUNX>> OMPLHFGRDJS(this UnsafeList<byte> a, [Optional] byte? b)
		{
			return default(Id32<WXKPXITHDLK<FRPUBIFEUNX>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x2B6C3B0", Offset = "0x2B6B1B0", VA = "0x182B6C3B0")]
		public static Id32<WXKPXITHDLK<GQSCCKHWVOV>> UQDODDJPIHS(this UnsafeList<byte> a, [Optional] Id32<GQSCCKHWVOV>? b)
		{
			return default(Id32<WXKPXITHDLK<GQSCCKHWVOV>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x2B6C2C0", Offset = "0x2B6B0C0", VA = "0x182B6C2C0")]
		public static Id32<WXKPXITHDLK<VABZENOIJNF>> UMICVRJFUSG(this UnsafeList<byte> a, [Optional] Op? b)
		{
			return default(Id32<WXKPXITHDLK<VABZENOIJNF>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x3ABDEF0", Offset = "0x3ABCCF0", VA = "0x183ABDEF0")]
		public static Id32<WXKPXITHDLK<IXKHGZWDMFU<c>>> FFXNBZDSRCK<c>(this UnsafeList<byte> a, [Optional] Id32<IXKHGZWDMFU<c>>? b)
		{
			return default(Id32<WXKPXITHDLK<IXKHGZWDMFU<c>>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x2B65F60", Offset = "0x2B64D60", VA = "0x182B65F60")]
		public static void ITFMAKCQRFI(this UnsafeList<byte> a, Id32<WXKPXITHDLK<CXMCVELPQUC>> b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x3ABDD30", Offset = "0x3ABCB30", VA = "0x183ABDD30")]
		public static void BPAXYQVHQDN<d>(this UnsafeList<byte> a, Id32<WXKPXITHDLK<WXKPXITHDLK<d>>> b, Id32<WXKPXITHDLK<d>> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x3ABDD30", Offset = "0x3ABCB30", VA = "0x183ABDD30")]
		public static void XJYIRTKMEJD<e>(this UnsafeList<byte> a, Id32<WXKPXITHDLK<IXKHGZWDMFU<e>>> b, Id32<IXKHGZWDMFU<e>> c)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public static class KRZWNZTWIUE
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x2B6C4E0", Offset = "0x2B6B2E0", VA = "0x182B6C4E0")]
		public static Union32 FOXBGIXPFHE([In] this ReadOnlySpan<byte> bytes, int a)
		{
			return default(Union32);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x2B6C550", Offset = "0x2B6B350", VA = "0x182B6C550")]
		public static Union32 FOXBGIXPFHE([In] this UnsafeList<byte> bytes, int a)
		{
			return default(Union32);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x3BC3E00", Offset = "0x3BC2C00", VA = "0x183BC3E00")]
		public static Union32 FOXBGIXPFHE<f>(this ReadOnlyIdArray<f, byte> a, Id32<f> b)
		{
			return default(Union32);
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x3BC3C80", Offset = "0x3BC2A80", VA = "0x183BC3C80")]
		public static Union32 FOXBGIXPFHE<g>([In] this ReadOnlyIdSpan<g, byte> bytes, Id32<g> a)
		{
			return default(Union32);
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x3BC4040", Offset = "0x3BC2E40", VA = "0x183BC4040")]
		public static Union32 FOXBGIXPFHE<i>(this IdArray<i, byte> a, Id32<i> b)
		{
			return default(Union32);
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x3BC3C10", Offset = "0x3BC2A10", VA = "0x183BC3C10")]
		public static Union32 FOXBGIXPFHE<j>([In] this IdSpan<j, byte> bytes, Id32<j> a)
		{
			return default(Union32);
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x3BC3F80", Offset = "0x3BC2D80", VA = "0x183BC3F80")]
		public static Union32 FOXBGIXPFHE<k>(this ReadOnlyIdArray<k, byte> a, Id32<k> b)
		{
			return default(Union32);
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x2B6C4E0", Offset = "0x2B6B2E0", VA = "0x182B6C4E0")]
		public static int PYOBFIISELT([In] this ReadOnlySpan<byte> bytes, int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x2B66100", Offset = "0x2B64F00", VA = "0x182B66100")]
		public static int PYOBFIISELT([In] this UnsafeList<byte> bytes, int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x3BC4430", Offset = "0x3BC3230", VA = "0x183BC4430")]
		public static int PYOBFIISELT<p>(this ReadOnlyIdArray<p, byte> a, Id32<p> b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x3BC44D0", Offset = "0x3BC32D0", VA = "0x183BC44D0")]
		public static int PYOBFIISELT<s>(this IdArray<s, byte> a, Id32<s> b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x3BC4550", Offset = "0x3BC3350", VA = "0x183BC4550")]
		public static int PYOBFIISELT<t>([In] this IdSpan<t, byte> bytes, Id32<t> a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x3BC4480", Offset = "0x3BC3280", VA = "0x183BC4480")]
		public static int PYOBFIISELT<u>(this ReadOnlyIdArray<u, byte> a, Id32<u> b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x3BC4210", Offset = "0x3BC3010", VA = "0x183BC4210")]
		public static float JOGXUGYZJBS<bc>(this IdArray<bc, byte> a, Id32<bc> b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x3BC4290", Offset = "0x3BC3090", VA = "0x183BC4290")]
		public static float JOGXUGYZJBS<bd>([In] this IdSpan<bd, byte> bytes, Id32<bd> a)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x3BC41C0", Offset = "0x3BC2FC0", VA = "0x183BC41C0")]
		public static float JOGXUGYZJBS<be>(this ReadOnlyIdArray<be, byte> a, Id32<be> b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x3BC4870", Offset = "0x3BC3670", VA = "0x183BC4870")]
		public static byte TRFAKJIWNBW<bj>(this ReadOnlyIdArray<bj, byte> a, Id32<bj> b)
		{
			return default(byte);
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x3BC46D0", Offset = "0x3BC34D0", VA = "0x183BC46D0")]
		public static byte TRFAKJIWNBW<bk>([In] this ReadOnlyIdSpan<bk, byte> bytes, Id32<bk> a)
		{
			return default(byte);
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x3BC47F0", Offset = "0x3BC35F0", VA = "0x183BC47F0")]
		public static byte TRFAKJIWNBW<bm>(this IdArray<bm, byte> a, Id32<bm> b)
		{
			return default(byte);
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x3BC48C0", Offset = "0x3BC36C0", VA = "0x183BC48C0")]
		public static byte TRFAKJIWNBW<bn>([In] this IdSpan<bn, byte> bytes, Id32<bn> a)
		{
			return default(byte);
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x3BC4720", Offset = "0x3BC3520", VA = "0x183BC4720")]
		public static byte TRFAKJIWNBW<bo>(this ReadOnlyIdArray<bo, byte> a, Id32<bo> b)
		{
			return default(byte);
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x2B66100", Offset = "0x2B64F00", VA = "0x182B66100")]
		public static Op JWIXSSKQSXY([In] this UnsafeList<byte> bytes, int a)
		{
			return default(Op);
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x3BC4330", Offset = "0x3BC3130", VA = "0x183BC4330")]
		public static Op JWIXSSKQSXY<by>(this ReadOnlyIdArray<by, byte> a, Id32<by> b)
		{
			return default(Op);
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x3BC4B60", Offset = "0x3BC3960", VA = "0x183BC4B60")]
		public static Id32<WXKPXITHDLK<WFSWBPUBAOK>> VNDMZCKPMDO<cg>(this IdArray<cg, byte> a, Id32<cg> b)
		{
			return default(Id32<WXKPXITHDLK<WFSWBPUBAOK>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x3BC4BE0", Offset = "0x3BC39E0", VA = "0x183BC4BE0")]
		public static Id32<WXKPXITHDLK<WFSWBPUBAOK>> VNDMZCKPMDO<ch>([In] this IdSpan<ch, byte> bytes, Id32<ch> a)
		{
			return default(Id32<WXKPXITHDLK<WFSWBPUBAOK>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x3BC4AD0", Offset = "0x3BC38D0", VA = "0x183BC4AD0")]
		public static Id32<WXKPXITHDLK<WFSWBPUBAOK>> VNDMZCKPMDO<ci>(this ReadOnlyIdArray<ci, byte> a, Id32<ci> b)
		{
			return default(Id32<WXKPXITHDLK<WFSWBPUBAOK>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x3BC3480", Offset = "0x3BC2280", VA = "0x183BC3480")]
		public static Id32<IXKHGZWDMFU<WFSWBPUBAOK>> DGPXBFYSUUG<cs>(this ReadOnlyIdArray<cs, byte> a, Id32<cs> b)
		{
			return default(Id32<IXKHGZWDMFU<WFSWBPUBAOK>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x3BC4F10", Offset = "0x3BC3D10", VA = "0x183BC4F10")]
		public static Id32<GQSCCKHWVOV> YAYOHXZZMNA<da>(this IdArray<da, byte> a, Id32<da> b)
		{
			return default(Id32<GQSCCKHWVOV>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x3BC4E80", Offset = "0x3BC3C80", VA = "0x183BC4E80")]
		public static Id32<GQSCCKHWVOV> YAYOHXZZMNA<db>([In] this IdSpan<db, byte> bytes, Id32<db> a)
		{
			return default(Id32<GQSCCKHWVOV>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x3BC4DF0", Offset = "0x3BC3BF0", VA = "0x183BC4DF0")]
		public static Id32<GQSCCKHWVOV> YAYOHXZZMNA<dc>(this ReadOnlyIdArray<dc, byte> a, Id32<dc> b)
		{
			return default(Id32<GQSCCKHWVOV>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x3BC3610", Offset = "0x3BC2410", VA = "0x183BC3610")]
		public static Id32<OYXCYVSZNSL> DZULTHUJLKM<dl>([In] this IdSpan<dl, byte> bytes, Id32<dl> a)
		{
			return default(Id32<OYXCYVSZNSL>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x3BC36A0", Offset = "0x3BC24A0", VA = "0x183BC36A0")]
		public static Id32<OYXCYVSZNSL> DZULTHUJLKM<dm>(this ReadOnlyIdArray<dm, byte> a, Id32<dm> b)
		{
			return default(Id32<OYXCYVSZNSL>);
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x3BC37B0", Offset = "0x3BC25B0", VA = "0x183BC37B0")]
		public static Id32<IUBIECDJGSA> FCISTPGXRQP<dw>(this ReadOnlyIdArray<dw, byte> a, Id32<dw> b)
		{
			return default(Id32<IUBIECDJGSA>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public static class FUONFSCORSE
	{
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x2B6BBF0", Offset = "0x2B6A9F0", VA = "0x182B6BBF0")]
		public static void SWJZJBBAAKV(this UnsafeList<byte> a, int b, Union32 c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x2B6BCB0", Offset = "0x2B6AAB0", VA = "0x182B6BCB0")]
		public static void SWJZJBBAAKV(this byte[] a, int b, Union32 c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x2B6BD20", Offset = "0x2B6AB20", VA = "0x182B6BD20")]
		public static void SWJZJBBAAKV([In] this Span<byte> bytes, int a, Union32 b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x3AA8A20", Offset = "0x3AA7820", VA = "0x183AA8A20")]
		public static void SWJZJBBAAKV<e>(this IdArray<e, byte> a, Id32<e> b, Union32 c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x3AA8B70", Offset = "0x3AA7970", VA = "0x183AA8B70")]
		public static void SWJZJBBAAKV<f>([In] this IdSpan<f, byte> bytes, Id32<f> a, Union32 b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x2B65F60", Offset = "0x2B64D60", VA = "0x182B65F60")]
		public static void ITFMAKCQRFI(this UnsafeList<byte> a, int b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x2B6BAF0", Offset = "0x2B6A8F0", VA = "0x182B6BAF0")]
		public static void ITFMAKCQRFI(this byte[] a, int b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x2B6BB70", Offset = "0x2B6A970", VA = "0x182B6BB70")]
		public static void ITFMAKCQRFI([In] this Span<byte> bytes, int a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x3AA8760", Offset = "0x3AA7560", VA = "0x183AA8760")]
		public static void ITFMAKCQRFI<h>(this IdArray<h, byte> a, Id32<h> b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x3AA87C0", Offset = "0x3AA75C0", VA = "0x183AA87C0")]
		public static void ITFMAKCQRFI<i>([In] this IdSpan<i, byte> bytes, Id32<i> a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x2B6BAB0", Offset = "0x2B6A8B0", VA = "0x182B6BAB0")]
		public static void ALWLAWGXDJF(this UnsafeList<byte> a, int b, float c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x3AA83E0", Offset = "0x3AA71E0", VA = "0x183AA83E0")]
		public static void ALWLAWGXDJF<k>(this IdArray<k, byte> a, Id32<k> b, float c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x3AA8450", Offset = "0x3AA7250", VA = "0x183AA8450")]
		public static void ALWLAWGXDJF<l>([In] this IdSpan<l, byte> bytes, Id32<l> a, float b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x2B6BDA0", Offset = "0x2B6ABA0", VA = "0x182B6BDA0")]
		public static void WTJEXMYEAUN(this UnsafeList<byte> a, int b, byte c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x3AA8D70", Offset = "0x3AA7B70", VA = "0x183AA8D70")]
		public static void WTJEXMYEAUN<n>(this IdArray<n, byte> a, Id32<n> b, byte c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x3AA8DC0", Offset = "0x3AA7BC0", VA = "0x183AA8DC0")]
		public static void WTJEXMYEAUN<o>([In] this IdSpan<o, byte> bytes, Id32<o> a, byte b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x3AA8600", Offset = "0x3AA7400", VA = "0x183AA8600")]
		public static void BPAXYQVHQDN<q>(this IdArray<q, byte> a, Id32<q> b, Id32<WXKPXITHDLK<WFSWBPUBAOK>> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x3AA8580", Offset = "0x3AA7380", VA = "0x183AA8580")]
		public static void BPAXYQVHQDN<r>([In] this IdSpan<r, byte> bytes, Id32<r> a, Id32<WXKPXITHDLK<WFSWBPUBAOK>> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x3AA8600", Offset = "0x3AA7400", VA = "0x183AA8600")]
		public static void YEKSCATTISV<t>(this IdArray<t, byte> a, Id32<t> b, Id32<GQSCCKHWVOV> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x3AA8580", Offset = "0x3AA7380", VA = "0x183AA8580")]
		public static void YEKSCATTISV<u>([In] this IdSpan<u, byte> bytes, Id32<u> a, Id32<GQSCCKHWVOV> b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public static class FSBRECRZUVP
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x2B676A0", Offset = "0x2B664A0", VA = "0x182B676A0")]
		public static (Id32<WXKPXITHDLK<VABZENOIJNF>>, Id32<WXKPXITHDLK<XZWASXESRJR>>, Id32<WXKPXITHDLK<XZWASXESRJR>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<XZWASXESRJR>>>) GRQWXGOASKJ(this UnsafeList<byte> a, float b, float c, [Optional] Id32<IXKHGZWDMFU<XZWASXESRJR>>? d)
		{
			return default((Id32<WXKPXITHDLK<VABZENOIJNF>>, Id32<WXKPXITHDLK<XZWASXESRJR>>, Id32<WXKPXITHDLK<XZWASXESRJR>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<XZWASXESRJR>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x2B69CA0", Offset = "0x2B68AA0", VA = "0x182B69CA0")]
		public static (Id32<WXKPXITHDLK<VABZENOIJNF>>, Id32<WXKPXITHDLK<XZWASXESRJR>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<XZWASXESRJR>>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<XZWASXESRJR>>>) SINOEXLVUJI(this UnsafeList<byte> a, float b, [Optional] Id32<IXKHGZWDMFU<XZWASXESRJR>>? c, [Optional] Id32<IXKHGZWDMFU<XZWASXESRJR>>? d)
		{
			return default((Id32<WXKPXITHDLK<VABZENOIJNF>>, Id32<WXKPXITHDLK<XZWASXESRJR>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<XZWASXESRJR>>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<XZWASXESRJR>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x2B67C30", Offset = "0x2B66A30", VA = "0x182B67C30")]
		public static (Id32<WXKPXITHDLK<VABZENOIJNF>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<XZWASXESRJR>>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<XZWASXESRJR>>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<XZWASXESRJR>>>) IKAFSZQBHLB(this UnsafeList<byte> a, [Optional] Id32<IXKHGZWDMFU<XZWASXESRJR>>? b, [Optional] Id32<IXKHGZWDMFU<XZWASXESRJR>>? c, [Optional] Id32<IXKHGZWDMFU<XZWASXESRJR>>? d)
		{
			return default((Id32<WXKPXITHDLK<VABZENOIJNF>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<XZWASXESRJR>>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<XZWASXESRJR>>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<XZWASXESRJR>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x2B67820", Offset = "0x2B66620", VA = "0x182B67820")]
		public static (Id32<WXKPXITHDLK<VABZENOIJNF>>, Id32<WXKPXITHDLK<CXMCVELPQUC>>, Id32<WXKPXITHDLK<CXMCVELPQUC>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<CXMCVELPQUC>>>) HBPUYIUQTEP(this UnsafeList<byte> a, int b, int c, [Optional] Id32<IXKHGZWDMFU<CXMCVELPQUC>>? d)
		{
			return default((Id32<WXKPXITHDLK<VABZENOIJNF>>, Id32<WXKPXITHDLK<CXMCVELPQUC>>, Id32<WXKPXITHDLK<CXMCVELPQUC>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<CXMCVELPQUC>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x2B66A30", Offset = "0x2B65830", VA = "0x182B66A30")]
		public static (Id32<WXKPXITHDLK<VABZENOIJNF>>, Id32<WXKPXITHDLK<CXMCVELPQUC>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<CXMCVELPQUC>>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<CXMCVELPQUC>>>) DZMWLUCEXQY(this UnsafeList<byte> a, int b, [Optional] Id32<IXKHGZWDMFU<CXMCVELPQUC>>? c, [Optional] Id32<IXKHGZWDMFU<CXMCVELPQUC>>? d)
		{
			return default((Id32<WXKPXITHDLK<VABZENOIJNF>>, Id32<WXKPXITHDLK<CXMCVELPQUC>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<CXMCVELPQUC>>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<CXMCVELPQUC>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x2B68590", Offset = "0x2B67390", VA = "0x182B68590")]
		public static (Id32<WXKPXITHDLK<VABZENOIJNF>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<CXMCVELPQUC>>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<CXMCVELPQUC>>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<CXMCVELPQUC>>>) MFAISFRBLCF(this UnsafeList<byte> a, [Optional] Id32<IXKHGZWDMFU<CXMCVELPQUC>>? b, [Optional] Id32<IXKHGZWDMFU<CXMCVELPQUC>>? c, [Optional] Id32<IXKHGZWDMFU<CXMCVELPQUC>>? d)
		{
			return default((Id32<WXKPXITHDLK<VABZENOIJNF>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<CXMCVELPQUC>>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<CXMCVELPQUC>>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<CXMCVELPQUC>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x2B66B80", Offset = "0x2B65980", VA = "0x182B66B80")]
		public static (Id32<WXKPXITHDLK<VABZENOIJNF>>, Id32<WXKPXITHDLK<CXMCVELPQUC>>, Id32<WXKPXITHDLK<CXMCVELPQUC>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<CXMCVELPQUC>>>) ECHFHLXTSGZ(this UnsafeList<byte> a, int b, int c, [Optional] Id32<IXKHGZWDMFU<CXMCVELPQUC>>? d)
		{
			return default((Id32<WXKPXITHDLK<VABZENOIJNF>>, Id32<WXKPXITHDLK<CXMCVELPQUC>>, Id32<WXKPXITHDLK<CXMCVELPQUC>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<CXMCVELPQUC>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x2B66E00", Offset = "0x2B65C00", VA = "0x182B66E00")]
		public static (Id32<WXKPXITHDLK<VABZENOIJNF>>, Id32<WXKPXITHDLK<CXMCVELPQUC>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<CXMCVELPQUC>>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<CXMCVELPQUC>>>) EUHZCHUYWMK(this UnsafeList<byte> a, int b, [Optional] Id32<IXKHGZWDMFU<CXMCVELPQUC>>? c, [Optional] Id32<IXKHGZWDMFU<CXMCVELPQUC>>? d)
		{
			return default((Id32<WXKPXITHDLK<VABZENOIJNF>>, Id32<WXKPXITHDLK<CXMCVELPQUC>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<CXMCVELPQUC>>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<CXMCVELPQUC>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x2B6B270", Offset = "0x2B6A070", VA = "0x182B6B270")]
		public static (Id32<WXKPXITHDLK<VABZENOIJNF>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<CXMCVELPQUC>>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<CXMCVELPQUC>>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<CXMCVELPQUC>>>) XZTKTWJHGKT(this UnsafeList<byte> a, [Optional] Id32<IXKHGZWDMFU<CXMCVELPQUC>>? b, [Optional] Id32<IXKHGZWDMFU<CXMCVELPQUC>>? c, [Optional] Id32<IXKHGZWDMFU<CXMCVELPQUC>>? d)
		{
			return default((Id32<WXKPXITHDLK<VABZENOIJNF>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<CXMCVELPQUC>>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<CXMCVELPQUC>>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<CXMCVELPQUC>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x2B6AC10", Offset = "0x2B69A10", VA = "0x182B6AC10")]
		public static (Id32<WXKPXITHDLK<VABZENOIJNF>>, Id32<WXKPXITHDLK<CXMCVELPQUC>>, Id32<WXKPXITHDLK<WXKPXITHDLK<VABZENOIJNF>>>) WSEVYTNUNDH(this UnsafeList<byte> a, [Optional] int? b, [Optional] Id32<WXKPXITHDLK<VABZENOIJNF>>? c)
		{
			return default((Id32<WXKPXITHDLK<VABZENOIJNF>>, Id32<WXKPXITHDLK<CXMCVELPQUC>>, Id32<WXKPXITHDLK<WXKPXITHDLK<VABZENOIJNF>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x2B6B990", Offset = "0x2B6A790", VA = "0x182B6B990")]
		public static (Id32<WXKPXITHDLK<VABZENOIJNF>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<CXMCVELPQUC>>>, Id32<WXKPXITHDLK<WXKPXITHDLK<VABZENOIJNF>>>) ZQNASLNIOVI(this UnsafeList<byte> a, [Optional] Id32<IXKHGZWDMFU<CXMCVELPQUC>>? b, [Optional] Id32<WXKPXITHDLK<VABZENOIJNF>>? c)
		{
			return default((Id32<WXKPXITHDLK<VABZENOIJNF>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<CXMCVELPQUC>>>, Id32<WXKPXITHDLK<WXKPXITHDLK<VABZENOIJNF>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x2B6A9B0", Offset = "0x2B697B0", VA = "0x182B6A9B0")]
		public static (Id32<WXKPXITHDLK<VABZENOIJNF>>, Id32<WXKPXITHDLK<CXMCVELPQUC>>, Id32<WXKPXITHDLK<WXKPXITHDLK<VABZENOIJNF>>>) VHLVCFUZBNM(this UnsafeList<byte> a, [Optional] int? b, [Optional] Id32<WXKPXITHDLK<VABZENOIJNF>>? c)
		{
			return default((Id32<WXKPXITHDLK<VABZENOIJNF>>, Id32<WXKPXITHDLK<CXMCVELPQUC>>, Id32<WXKPXITHDLK<WXKPXITHDLK<VABZENOIJNF>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x2B6AD20", Offset = "0x2B69B20", VA = "0x182B6AD20")]
		public static (Id32<WXKPXITHDLK<VABZENOIJNF>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<CXMCVELPQUC>>>, Id32<WXKPXITHDLK<WXKPXITHDLK<VABZENOIJNF>>>) XELEKGWNSWV(this UnsafeList<byte> a, [Optional] Id32<IXKHGZWDMFU<CXMCVELPQUC>>? b, [Optional] Id32<WXKPXITHDLK<VABZENOIJNF>>? c)
		{
			return default((Id32<WXKPXITHDLK<VABZENOIJNF>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<CXMCVELPQUC>>>, Id32<WXKPXITHDLK<WXKPXITHDLK<VABZENOIJNF>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x2B69990", Offset = "0x2B68790", VA = "0x182B69990")]
		public static (Id32<WXKPXITHDLK<VABZENOIJNF>>, Id32<WXKPXITHDLK<CXMCVELPQUC>>, Id32<WXKPXITHDLK<OYXCYVSZNSL>>) RONQUSROTPE(this UnsafeList<byte> a, [Optional] int? b, [Optional] Id32<OYXCYVSZNSL>? c)
		{
			return default((Id32<WXKPXITHDLK<VABZENOIJNF>>, Id32<WXKPXITHDLK<CXMCVELPQUC>>, Id32<WXKPXITHDLK<OYXCYVSZNSL>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x2B69880", Offset = "0x2B68680", VA = "0x182B69880")]
		public static (Id32<WXKPXITHDLK<VABZENOIJNF>>, Id32<WXKPXITHDLK<CXMCVELPQUC>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<OYXCYVSZNSL>>>) RMSGTJUMMRB(this UnsafeList<byte> a, [Optional] int? b, [Optional] Id32<IXKHGZWDMFU<OYXCYVSZNSL>>? c)
		{
			return default((Id32<WXKPXITHDLK<VABZENOIJNF>>, Id32<WXKPXITHDLK<CXMCVELPQUC>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<OYXCYVSZNSL>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x2B67D50", Offset = "0x2B66B50", VA = "0x182B67D50")]
		public static (Id32<WXKPXITHDLK<VABZENOIJNF>>, Id32<WXKPXITHDLK<CXMCVELPQUC>>, Id32<WXKPXITHDLK<GQSCCKHWVOV>>) IVOPVAEGJFW(this UnsafeList<byte> a, [Optional] int? b, [Optional] Id32<GQSCCKHWVOV>? c)
		{
			return default((Id32<WXKPXITHDLK<VABZENOIJNF>>, Id32<WXKPXITHDLK<CXMCVELPQUC>>, Id32<WXKPXITHDLK<GQSCCKHWVOV>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x2B67F00", Offset = "0x2B66D00", VA = "0x182B67F00")]
		public static (Id32<WXKPXITHDLK<VABZENOIJNF>>, Id32<WXKPXITHDLK<CXMCVELPQUC>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<GQSCCKHWVOV>>>) JBATZAVNEAF(this UnsafeList<byte> a, [Optional] int? b, [Optional] Id32<IXKHGZWDMFU<GQSCCKHWVOV>>? c)
		{
			return default((Id32<WXKPXITHDLK<VABZENOIJNF>>, Id32<WXKPXITHDLK<CXMCVELPQUC>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<GQSCCKHWVOV>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x3AA6700", Offset = "0x3AA5500", VA = "0x183AA6700")]
		public static (Id32<WXKPXITHDLK<VABZENOIJNF>>, Id32<WXKPXITHDLK<IUBIECDJGSA>>, Id32<WXKPXITHDLK<CXMCVELPQUC>>, Id32<WXKPXITHDLK<a>>) EZWGIYNAQNF<a>(this UnsafeList<byte> a, [Optional] Id32<IUBIECDJGSA>? b, [Optional][In] ReadOnlySpan<byte> data)
		{
			return default((Id32<WXKPXITHDLK<VABZENOIJNF>>, Id32<WXKPXITHDLK<IUBIECDJGSA>>, Id32<WXKPXITHDLK<CXMCVELPQUC>>, Id32<WXKPXITHDLK<a>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x2B686B0", Offset = "0x2B674B0", VA = "0x182B686B0")]
		public static (Id32<WXKPXITHDLK<VABZENOIJNF>>, Id32<WXKPXITHDLK<CXMCVELPQUC>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<CXMCVELPQUC>>>) MGCMIKUUOVF(this UnsafeList<byte> a, int b, [Optional] Id32<IXKHGZWDMFU<CXMCVELPQUC>>? c)
		{
			return default((Id32<WXKPXITHDLK<VABZENOIJNF>>, Id32<WXKPXITHDLK<CXMCVELPQUC>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<CXMCVELPQUC>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x2B67070", Offset = "0x2B65E70", VA = "0x182B67070")]
		public static (Id32<WXKPXITHDLK<VABZENOIJNF>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<CXMCVELPQUC>>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<CXMCVELPQUC>>>) FJFSEMHPCHK(this UnsafeList<byte> a, [Optional] Id32<IXKHGZWDMFU<CXMCVELPQUC>>? b, [Optional] Id32<IXKHGZWDMFU<CXMCVELPQUC>>? c)
		{
			return default((Id32<WXKPXITHDLK<VABZENOIJNF>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<CXMCVELPQUC>>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<CXMCVELPQUC>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x3AA6B00", Offset = "0x3AA5900", VA = "0x183AA6B00")]
		public static (Id32<WXKPXITHDLK<VABZENOIJNF>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<b>>>, Id32<WXKPXITHDLK<CXMCVELPQUC>>, Id32<WXKPXITHDLK<b>>) MIOIPNLESCZ<b>(this UnsafeList<byte> a, [Optional] Id32<IXKHGZWDMFU<b>>? b, [Optional] int? c, [Optional][In] ReadOnlySpan<byte> from)
		{
			return default((Id32<WXKPXITHDLK<VABZENOIJNF>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<b>>>, Id32<WXKPXITHDLK<CXMCVELPQUC>>, Id32<WXKPXITHDLK<b>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x3AA6E30", Offset = "0x3AA5C30", VA = "0x183AA6E30")]
		public static (Id32<WXKPXITHDLK<VABZENOIJNF>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<c>>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<c>>>, Id32<WXKPXITHDLK<CXMCVELPQUC>>) VOKSXTHBLOG<c>(this UnsafeList<byte> a, [Optional] Id32<IXKHGZWDMFU<c>>? b, [Optional] Id32<IXKHGZWDMFU<c>>? c, [Optional] int? d)
		{
			return default((Id32<WXKPXITHDLK<VABZENOIJNF>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<c>>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<c>>>, Id32<WXKPXITHDLK<CXMCVELPQUC>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x2B69DF0", Offset = "0x2B68BF0", VA = "0x182B69DF0")]
		public static (Id32<WXKPXITHDLK<VABZENOIJNF>>, Id32<WXKPXITHDLK<XZWASXESRJR>>, Id32<WXKPXITHDLK<XZWASXESRJR>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<XZWASXESRJR>>>) SVEMGVTFFLP(this UnsafeList<byte> a, float b, float c, [Optional] Id32<IXKHGZWDMFU<XZWASXESRJR>>? d)
		{
			return default((Id32<WXKPXITHDLK<VABZENOIJNF>>, Id32<WXKPXITHDLK<XZWASXESRJR>>, Id32<WXKPXITHDLK<XZWASXESRJR>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<XZWASXESRJR>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x2B6AAC0", Offset = "0x2B698C0", VA = "0x182B6AAC0")]
		public static (Id32<WXKPXITHDLK<VABZENOIJNF>>, Id32<WXKPXITHDLK<XZWASXESRJR>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<XZWASXESRJR>>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<XZWASXESRJR>>>) VJTXFPOZDRA(this UnsafeList<byte> a, float b, [Optional] Id32<IXKHGZWDMFU<XZWASXESRJR>>? c, [Optional] Id32<IXKHGZWDMFU<XZWASXESRJR>>? d)
		{
			return default((Id32<WXKPXITHDLK<VABZENOIJNF>>, Id32<WXKPXITHDLK<XZWASXESRJR>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<XZWASXESRJR>>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<XZWASXESRJR>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x2B68470", Offset = "0x2B67270", VA = "0x182B68470")]
		public static (Id32<WXKPXITHDLK<VABZENOIJNF>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<XZWASXESRJR>>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<XZWASXESRJR>>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<XZWASXESRJR>>>) LWPFBOMUIST(this UnsafeList<byte> a, [Optional] Id32<IXKHGZWDMFU<XZWASXESRJR>>? b, [Optional] Id32<IXKHGZWDMFU<XZWASXESRJR>>? c, [Optional] Id32<IXKHGZWDMFU<XZWASXESRJR>>? d)
		{
			return default((Id32<WXKPXITHDLK<VABZENOIJNF>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<XZWASXESRJR>>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<XZWASXESRJR>>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<XZWASXESRJR>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x2B67420", Offset = "0x2B66220", VA = "0x182B67420")]
		public static (Id32<WXKPXITHDLK<VABZENOIJNF>>, Id32<WXKPXITHDLK<CXMCVELPQUC>>, Id32<WXKPXITHDLK<CXMCVELPQUC>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<CXMCVELPQUC>>>) FVOFLCCKXNJ(this UnsafeList<byte> a, int b, int c, [Optional] Id32<IXKHGZWDMFU<CXMCVELPQUC>>? d)
		{
			return default((Id32<WXKPXITHDLK<VABZENOIJNF>>, Id32<WXKPXITHDLK<CXMCVELPQUC>>, Id32<WXKPXITHDLK<CXMCVELPQUC>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<CXMCVELPQUC>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x2B6A430", Offset = "0x2B69230", VA = "0x182B6A430")]
		public static (Id32<WXKPXITHDLK<VABZENOIJNF>>, Id32<WXKPXITHDLK<CXMCVELPQUC>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<CXMCVELPQUC>>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<CXMCVELPQUC>>>) UBFROIUEOYA(this UnsafeList<byte> a, int b, [Optional] Id32<IXKHGZWDMFU<CXMCVELPQUC>>? c, [Optional] Id32<IXKHGZWDMFU<CXMCVELPQUC>>? d)
		{
			return default((Id32<WXKPXITHDLK<VABZENOIJNF>>, Id32<WXKPXITHDLK<CXMCVELPQUC>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<CXMCVELPQUC>>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<CXMCVELPQUC>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x2B66910", Offset = "0x2B65710", VA = "0x182B66910")]
		public static (Id32<WXKPXITHDLK<VABZENOIJNF>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<CXMCVELPQUC>>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<CXMCVELPQUC>>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<CXMCVELPQUC>>>) CVGMZFMKZFL(this UnsafeList<byte> a, [Optional] Id32<IXKHGZWDMFU<CXMCVELPQUC>>? b, [Optional] Id32<IXKHGZWDMFU<CXMCVELPQUC>>? c, [Optional] Id32<IXKHGZWDMFU<CXMCVELPQUC>>? d)
		{
			return default((Id32<WXKPXITHDLK<VABZENOIJNF>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<CXMCVELPQUC>>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<CXMCVELPQUC>>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<CXMCVELPQUC>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x2B67980", Offset = "0x2B66780", VA = "0x182B67980")]
		public static (Id32<WXKPXITHDLK<VABZENOIJNF>>, Id32<WXKPXITHDLK<CXMCVELPQUC>>, Id32<WXKPXITHDLK<CXMCVELPQUC>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<CXMCVELPQUC>>>) IEEICNJQOWY(this UnsafeList<byte> a, int b, int c, [Optional] Id32<IXKHGZWDMFU<CXMCVELPQUC>>? d)
		{
			return default((Id32<WXKPXITHDLK<VABZENOIJNF>>, Id32<WXKPXITHDLK<CXMCVELPQUC>>, Id32<WXKPXITHDLK<CXMCVELPQUC>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<CXMCVELPQUC>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x2B67AE0", Offset = "0x2B668E0", VA = "0x182B67AE0")]
		public static (Id32<WXKPXITHDLK<VABZENOIJNF>>, Id32<WXKPXITHDLK<CXMCVELPQUC>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<CXMCVELPQUC>>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<CXMCVELPQUC>>>) IGUNYISFRDB(this UnsafeList<byte> a, int b, [Optional] Id32<IXKHGZWDMFU<CXMCVELPQUC>>? c, [Optional] Id32<IXKHGZWDMFU<CXMCVELPQUC>>? d)
		{
			return default((Id32<WXKPXITHDLK<VABZENOIJNF>>, Id32<WXKPXITHDLK<CXMCVELPQUC>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<CXMCVELPQUC>>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<CXMCVELPQUC>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x2B69600", Offset = "0x2B68400", VA = "0x182B69600")]
		public static (Id32<WXKPXITHDLK<VABZENOIJNF>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<CXMCVELPQUC>>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<CXMCVELPQUC>>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<CXMCVELPQUC>>>) QFUAXIXBYLY(this UnsafeList<byte> a, [Optional] Id32<IXKHGZWDMFU<CXMCVELPQUC>>? b, [Optional] Id32<IXKHGZWDMFU<CXMCVELPQUC>>? c, [Optional] Id32<IXKHGZWDMFU<CXMCVELPQUC>>? d)
		{
			return default((Id32<WXKPXITHDLK<VABZENOIJNF>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<CXMCVELPQUC>>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<CXMCVELPQUC>>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<CXMCVELPQUC>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x2B6A220", Offset = "0x2B69020", VA = "0x182B6A220")]
		public static (Id32<WXKPXITHDLK<VABZENOIJNF>>, Id32<WXKPXITHDLK<WXKPXITHDLK<VABZENOIJNF>>>) TPGGIZKFHTZ(this UnsafeList<byte> a, [Optional] Id32<WXKPXITHDLK<VABZENOIJNF>>? b)
		{
			return default((Id32<WXKPXITHDLK<VABZENOIJNF>>, Id32<WXKPXITHDLK<WXKPXITHDLK<VABZENOIJNF>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x2B66270", Offset = "0x2B65070", VA = "0x182B66270")]
		public static (Id32<WXKPXITHDLK<VABZENOIJNF>>, Id32<WXKPXITHDLK<XZWASXESRJR>>, Id32<WXKPXITHDLK<XZWASXESRJR>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<CXMCVELPQUC>>>) ATGMFSIIWQP(this UnsafeList<byte> a, float b, float c, [Optional] Id32<IXKHGZWDMFU<CXMCVELPQUC>>? d)
		{
			return default((Id32<WXKPXITHDLK<VABZENOIJNF>>, Id32<WXKPXITHDLK<XZWASXESRJR>>, Id32<WXKPXITHDLK<XZWASXESRJR>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<CXMCVELPQUC>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x2B68F50", Offset = "0x2B67D50", VA = "0x182B68F50")]
		public static (Id32<WXKPXITHDLK<VABZENOIJNF>>, Id32<WXKPXITHDLK<XZWASXESRJR>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<XZWASXESRJR>>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<CXMCVELPQUC>>>) OYXYIZACOBG(this UnsafeList<byte> a, float b, [Optional] Id32<IXKHGZWDMFU<XZWASXESRJR>>? c, [Optional] Id32<IXKHGZWDMFU<CXMCVELPQUC>>? d)
		{
			return default((Id32<WXKPXITHDLK<VABZENOIJNF>>, Id32<WXKPXITHDLK<XZWASXESRJR>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<XZWASXESRJR>>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<CXMCVELPQUC>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x2B6B5C0", Offset = "0x2B6A3C0", VA = "0x182B6B5C0")]
		public static (Id32<WXKPXITHDLK<VABZENOIJNF>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<XZWASXESRJR>>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<XZWASXESRJR>>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<CXMCVELPQUC>>>) YSDXEAIIYBH(this UnsafeList<byte> a, [Optional] Id32<IXKHGZWDMFU<XZWASXESRJR>>? b, [Optional] Id32<IXKHGZWDMFU<XZWASXESRJR>>? c, [Optional] Id32<IXKHGZWDMFU<CXMCVELPQUC>>? d)
		{
			return default((Id32<WXKPXITHDLK<VABZENOIJNF>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<XZWASXESRJR>>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<XZWASXESRJR>>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<CXMCVELPQUC>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x2B69B40", Offset = "0x2B68940", VA = "0x182B69B40")]
		public static (Id32<WXKPXITHDLK<VABZENOIJNF>>, Id32<WXKPXITHDLK<CXMCVELPQUC>>, Id32<WXKPXITHDLK<CXMCVELPQUC>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<CXMCVELPQUC>>>) RWUOLPMGBJY(this UnsafeList<byte> a, int b, int c, [Optional] Id32<IXKHGZWDMFU<CXMCVELPQUC>>? d)
		{
			return default((Id32<WXKPXITHDLK<VABZENOIJNF>>, Id32<WXKPXITHDLK<CXMCVELPQUC>>, Id32<WXKPXITHDLK<CXMCVELPQUC>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<CXMCVELPQUC>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x2B68B90", Offset = "0x2B67990", VA = "0x182B68B90")]
		public static (Id32<WXKPXITHDLK<VABZENOIJNF>>, Id32<WXKPXITHDLK<CXMCVELPQUC>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<CXMCVELPQUC>>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<CXMCVELPQUC>>>) MXZAOGWHIKV(this UnsafeList<byte> a, int b, [Optional] Id32<IXKHGZWDMFU<CXMCVELPQUC>>? c, [Optional] Id32<IXKHGZWDMFU<CXMCVELPQUC>>? d)
		{
			return default((Id32<WXKPXITHDLK<VABZENOIJNF>>, Id32<WXKPXITHDLK<CXMCVELPQUC>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<CXMCVELPQUC>>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<CXMCVELPQUC>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x2B6A310", Offset = "0x2B69110", VA = "0x182B6A310")]
		public static (Id32<WXKPXITHDLK<VABZENOIJNF>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<CXMCVELPQUC>>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<CXMCVELPQUC>>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<CXMCVELPQUC>>>) UAOJHPRMFPO(this UnsafeList<byte> a, [Optional] Id32<IXKHGZWDMFU<CXMCVELPQUC>>? b, [Optional] Id32<IXKHGZWDMFU<CXMCVELPQUC>>? c, [Optional] Id32<IXKHGZWDMFU<CXMCVELPQUC>>? d)
		{
			return default((Id32<WXKPXITHDLK<VABZENOIJNF>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<CXMCVELPQUC>>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<CXMCVELPQUC>>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<CXMCVELPQUC>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x2B6A580", Offset = "0x2B69380", VA = "0x182B6A580")]
		public static (Id32<WXKPXITHDLK<VABZENOIJNF>>, Id32<WXKPXITHDLK<XZWASXESRJR>>, Id32<WXKPXITHDLK<XZWASXESRJR>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<CXMCVELPQUC>>>) ULMTWYGDPJY(this UnsafeList<byte> a, float b, float c, [Optional] Id32<IXKHGZWDMFU<CXMCVELPQUC>>? d)
		{
			return default((Id32<WXKPXITHDLK<VABZENOIJNF>>, Id32<WXKPXITHDLK<XZWASXESRJR>>, Id32<WXKPXITHDLK<XZWASXESRJR>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<CXMCVELPQUC>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x2B69370", Offset = "0x2B68170", VA = "0x182B69370")]
		public static (Id32<WXKPXITHDLK<VABZENOIJNF>>, Id32<WXKPXITHDLK<XZWASXESRJR>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<XZWASXESRJR>>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<CXMCVELPQUC>>>) PMRFZPQEWKV(this UnsafeList<byte> a, float b, [Optional] Id32<IXKHGZWDMFU<XZWASXESRJR>>? c, [Optional] Id32<IXKHGZWDMFU<CXMCVELPQUC>>? d)
		{
			return default((Id32<WXKPXITHDLK<VABZENOIJNF>>, Id32<WXKPXITHDLK<XZWASXESRJR>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<XZWASXESRJR>>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<CXMCVELPQUC>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x2B694D0", Offset = "0x2B682D0", VA = "0x182B694D0")]
		public static (Id32<WXKPXITHDLK<VABZENOIJNF>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<XZWASXESRJR>>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<XZWASXESRJR>>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<CXMCVELPQUC>>>) PWIFBVZUWYA(this UnsafeList<byte> a, [Optional] Id32<IXKHGZWDMFU<XZWASXESRJR>>? b, [Optional] Id32<IXKHGZWDMFU<XZWASXESRJR>>? c, [Optional] Id32<IXKHGZWDMFU<CXMCVELPQUC>>? d)
		{
			return default((Id32<WXKPXITHDLK<VABZENOIJNF>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<XZWASXESRJR>>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<XZWASXESRJR>>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<CXMCVELPQUC>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x2B69210", Offset = "0x2B68010", VA = "0x182B69210")]
		public static (Id32<WXKPXITHDLK<VABZENOIJNF>>, Id32<WXKPXITHDLK<CXMCVELPQUC>>, Id32<WXKPXITHDLK<CXMCVELPQUC>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<CXMCVELPQUC>>>) PGYRCXZZYZN(this UnsafeList<byte> a, int b, int c, [Optional] Id32<IXKHGZWDMFU<CXMCVELPQUC>>? d)
		{
			return default((Id32<WXKPXITHDLK<VABZENOIJNF>>, Id32<WXKPXITHDLK<CXMCVELPQUC>>, Id32<WXKPXITHDLK<CXMCVELPQUC>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<CXMCVELPQUC>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x2B68910", Offset = "0x2B67710", VA = "0x182B68910")]
		public static (Id32<WXKPXITHDLK<VABZENOIJNF>>, Id32<WXKPXITHDLK<CXMCVELPQUC>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<CXMCVELPQUC>>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<CXMCVELPQUC>>>) MTQPVACTBHO(this UnsafeList<byte> a, int b, [Optional] Id32<IXKHGZWDMFU<CXMCVELPQUC>>? c, [Optional] Id32<IXKHGZWDMFU<CXMCVELPQUC>>? d)
		{
			return default((Id32<WXKPXITHDLK<VABZENOIJNF>>, Id32<WXKPXITHDLK<CXMCVELPQUC>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<CXMCVELPQUC>>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<CXMCVELPQUC>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x2B66CE0", Offset = "0x2B65AE0", VA = "0x182B66CE0")]
		public static (Id32<WXKPXITHDLK<VABZENOIJNF>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<CXMCVELPQUC>>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<CXMCVELPQUC>>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<CXMCVELPQUC>>>) ENRPDHLFPSB(this UnsafeList<byte> a, [Optional] Id32<IXKHGZWDMFU<CXMCVELPQUC>>? b, [Optional] Id32<IXKHGZWDMFU<CXMCVELPQUC>>? c, [Optional] Id32<IXKHGZWDMFU<CXMCVELPQUC>>? d)
		{
			return default((Id32<WXKPXITHDLK<VABZENOIJNF>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<CXMCVELPQUC>>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<CXMCVELPQUC>>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<CXMCVELPQUC>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x2B67180", Offset = "0x2B65F80", VA = "0x182B67180")]
		public static (Id32<WXKPXITHDLK<VABZENOIJNF>>, Id32<WXKPXITHDLK<XZWASXESRJR>>, Id32<WXKPXITHDLK<XZWASXESRJR>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<CXMCVELPQUC>>>) FOOVXCBWJAS(this UnsafeList<byte> a, float b, float c, [Optional] Id32<IXKHGZWDMFU<CXMCVELPQUC>>? d)
		{
			return default((Id32<WXKPXITHDLK<VABZENOIJNF>>, Id32<WXKPXITHDLK<XZWASXESRJR>>, Id32<WXKPXITHDLK<XZWASXESRJR>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<CXMCVELPQUC>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x2B690B0", Offset = "0x2B67EB0", VA = "0x182B690B0")]
		public static (Id32<WXKPXITHDLK<VABZENOIJNF>>, Id32<WXKPXITHDLK<XZWASXESRJR>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<XZWASXESRJR>>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<CXMCVELPQUC>>>) PEZHVHYZPBT(this UnsafeList<byte> a, float b, [Optional] Id32<IXKHGZWDMFU<XZWASXESRJR>>? c, [Optional] Id32<IXKHGZWDMFU<CXMCVELPQUC>>? d)
		{
			return default((Id32<WXKPXITHDLK<VABZENOIJNF>>, Id32<WXKPXITHDLK<XZWASXESRJR>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<XZWASXESRJR>>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<CXMCVELPQUC>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x2B687E0", Offset = "0x2B675E0", VA = "0x182B687E0")]
		public static (Id32<WXKPXITHDLK<VABZENOIJNF>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<XZWASXESRJR>>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<XZWASXESRJR>>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<CXMCVELPQUC>>>) MODBDGYCBAE(this UnsafeList<byte> a, [Optional] Id32<IXKHGZWDMFU<XZWASXESRJR>>? b, [Optional] Id32<IXKHGZWDMFU<XZWASXESRJR>>? c, [Optional] Id32<IXKHGZWDMFU<CXMCVELPQUC>>? d)
		{
			return default((Id32<WXKPXITHDLK<VABZENOIJNF>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<XZWASXESRJR>>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<XZWASXESRJR>>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<CXMCVELPQUC>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x2B6B110", Offset = "0x2B69F10", VA = "0x182B6B110")]
		public static (Id32<WXKPXITHDLK<VABZENOIJNF>>, Id32<WXKPXITHDLK<CXMCVELPQUC>>, Id32<WXKPXITHDLK<CXMCVELPQUC>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<CXMCVELPQUC>>>) XSWAWPHAUZF(this UnsafeList<byte> a, int b, int c, [Optional] Id32<IXKHGZWDMFU<CXMCVELPQUC>>? d)
		{
			return default((Id32<WXKPXITHDLK<VABZENOIJNF>>, Id32<WXKPXITHDLK<CXMCVELPQUC>>, Id32<WXKPXITHDLK<CXMCVELPQUC>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<CXMCVELPQUC>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x2B6B840", Offset = "0x2B6A640", VA = "0x182B6B840")]
		public static (Id32<WXKPXITHDLK<VABZENOIJNF>>, Id32<WXKPXITHDLK<CXMCVELPQUC>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<CXMCVELPQUC>>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<CXMCVELPQUC>>>) ZIYJTUIBDMU(this UnsafeList<byte> a, int b, [Optional] Id32<IXKHGZWDMFU<CXMCVELPQUC>>? c, [Optional] Id32<IXKHGZWDMFU<CXMCVELPQUC>>? d)
		{
			return default((Id32<WXKPXITHDLK<VABZENOIJNF>>, Id32<WXKPXITHDLK<CXMCVELPQUC>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<CXMCVELPQUC>>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<CXMCVELPQUC>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x2B68E30", Offset = "0x2B67C30", VA = "0x182B68E30")]
		public static (Id32<WXKPXITHDLK<VABZENOIJNF>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<CXMCVELPQUC>>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<CXMCVELPQUC>>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<CXMCVELPQUC>>>) NXMQGEFSXUF(this UnsafeList<byte> a, [Optional] Id32<IXKHGZWDMFU<CXMCVELPQUC>>? b, [Optional] Id32<IXKHGZWDMFU<CXMCVELPQUC>>? c, [Optional] Id32<IXKHGZWDMFU<CXMCVELPQUC>>? d)
		{
			return default((Id32<WXKPXITHDLK<VABZENOIJNF>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<CXMCVELPQUC>>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<CXMCVELPQUC>>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<CXMCVELPQUC>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x2B68010", Offset = "0x2B66E10", VA = "0x182B68010")]
		public static (Id32<WXKPXITHDLK<VABZENOIJNF>>, Id32<WXKPXITHDLK<XZWASXESRJR>>, Id32<WXKPXITHDLK<XZWASXESRJR>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<CXMCVELPQUC>>>) JFECNYJPAAR(this UnsafeList<byte> a, float b, float c, [Optional] Id32<IXKHGZWDMFU<CXMCVELPQUC>>? d)
		{
			return default((Id32<WXKPXITHDLK<VABZENOIJNF>>, Id32<WXKPXITHDLK<XZWASXESRJR>>, Id32<WXKPXITHDLK<XZWASXESRJR>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<CXMCVELPQUC>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x2B6A0C0", Offset = "0x2B68EC0", VA = "0x182B6A0C0")]
		public static (Id32<WXKPXITHDLK<VABZENOIJNF>>, Id32<WXKPXITHDLK<XZWASXESRJR>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<XZWASXESRJR>>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<CXMCVELPQUC>>>) TJGELXCEEGC(this UnsafeList<byte> a, float b, [Optional] Id32<IXKHGZWDMFU<XZWASXESRJR>>? c, [Optional] Id32<IXKHGZWDMFU<CXMCVELPQUC>>? d)
		{
			return default((Id32<WXKPXITHDLK<VABZENOIJNF>>, Id32<WXKPXITHDLK<XZWASXESRJR>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<XZWASXESRJR>>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<CXMCVELPQUC>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x2B68A60", Offset = "0x2B67860", VA = "0x182B68A60")]
		public static (Id32<WXKPXITHDLK<VABZENOIJNF>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<XZWASXESRJR>>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<XZWASXESRJR>>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<CXMCVELPQUC>>>) MXPZFIWENYH(this UnsafeList<byte> a, [Optional] Id32<IXKHGZWDMFU<XZWASXESRJR>>? b, [Optional] Id32<IXKHGZWDMFU<XZWASXESRJR>>? c, [Optional] Id32<IXKHGZWDMFU<CXMCVELPQUC>>? d)
		{
			return default((Id32<WXKPXITHDLK<VABZENOIJNF>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<XZWASXESRJR>>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<XZWASXESRJR>>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<CXMCVELPQUC>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x2B6A700", Offset = "0x2B69500", VA = "0x182B6A700")]
		public static (Id32<WXKPXITHDLK<VABZENOIJNF>>, Id32<WXKPXITHDLK<CXMCVELPQUC>>, Id32<WXKPXITHDLK<CXMCVELPQUC>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<CXMCVELPQUC>>>) ULOQSHXMVXC(this UnsafeList<byte> a, int b, int c, [Optional] Id32<IXKHGZWDMFU<CXMCVELPQUC>>? d)
		{
			return default((Id32<WXKPXITHDLK<VABZENOIJNF>>, Id32<WXKPXITHDLK<CXMCVELPQUC>>, Id32<WXKPXITHDLK<CXMCVELPQUC>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<CXMCVELPQUC>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x2B6A860", Offset = "0x2B69660", VA = "0x182B6A860")]
		public static (Id32<WXKPXITHDLK<VABZENOIJNF>>, Id32<WXKPXITHDLK<CXMCVELPQUC>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<CXMCVELPQUC>>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<CXMCVELPQUC>>>) UOEWODGBYDF(this UnsafeList<byte> a, int b, [Optional] Id32<IXKHGZWDMFU<CXMCVELPQUC>>? c, [Optional] Id32<IXKHGZWDMFU<CXMCVELPQUC>>? d)
		{
			return default((Id32<WXKPXITHDLK<VABZENOIJNF>>, Id32<WXKPXITHDLK<CXMCVELPQUC>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<CXMCVELPQUC>>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<CXMCVELPQUC>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x2B667F0", Offset = "0x2B655F0", VA = "0x182B667F0")]
		public static (Id32<WXKPXITHDLK<VABZENOIJNF>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<CXMCVELPQUC>>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<CXMCVELPQUC>>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<CXMCVELPQUC>>>) CNEJNDKYFMC(this UnsafeList<byte> a, [Optional] Id32<IXKHGZWDMFU<CXMCVELPQUC>>? b, [Optional] Id32<IXKHGZWDMFU<CXMCVELPQUC>>? c, [Optional] Id32<IXKHGZWDMFU<CXMCVELPQUC>>? d)
		{
			return default((Id32<WXKPXITHDLK<VABZENOIJNF>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<CXMCVELPQUC>>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<CXMCVELPQUC>>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<CXMCVELPQUC>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x2B6AE40", Offset = "0x2B69C40", VA = "0x182B6AE40")]
		public static (Id32<WXKPXITHDLK<VABZENOIJNF>>, Id32<WXKPXITHDLK<XZWASXESRJR>>, Id32<WXKPXITHDLK<XZWASXESRJR>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<XZWASXESRJR>>>) XHGXTUMSTUQ(this UnsafeList<byte> a, float b, float c, [Optional] Id32<IXKHGZWDMFU<XZWASXESRJR>>? d)
		{
			return default((Id32<WXKPXITHDLK<VABZENOIJNF>>, Id32<WXKPXITHDLK<XZWASXESRJR>>, Id32<WXKPXITHDLK<XZWASXESRJR>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<XZWASXESRJR>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x2B6B6F0", Offset = "0x2B6A4F0", VA = "0x182B6B6F0")]
		public static (Id32<WXKPXITHDLK<VABZENOIJNF>>, Id32<WXKPXITHDLK<XZWASXESRJR>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<XZWASXESRJR>>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<XZWASXESRJR>>>) ZBTACJZQHUP(this UnsafeList<byte> a, float b, [Optional] Id32<IXKHGZWDMFU<XZWASXESRJR>>? c, [Optional] Id32<IXKHGZWDMFU<XZWASXESRJR>>? d)
		{
			return default((Id32<WXKPXITHDLK<VABZENOIJNF>>, Id32<WXKPXITHDLK<XZWASXESRJR>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<XZWASXESRJR>>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<XZWASXESRJR>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x2B66F50", Offset = "0x2B65D50", VA = "0x182B66F50")]
		public static (Id32<WXKPXITHDLK<VABZENOIJNF>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<XZWASXESRJR>>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<XZWASXESRJR>>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<XZWASXESRJR>>>) EYUQPPMSOWW(this UnsafeList<byte> a, [Optional] Id32<IXKHGZWDMFU<XZWASXESRJR>>? b, [Optional] Id32<IXKHGZWDMFU<XZWASXESRJR>>? c, [Optional] Id32<IXKHGZWDMFU<XZWASXESRJR>>? d)
		{
			return default((Id32<WXKPXITHDLK<VABZENOIJNF>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<XZWASXESRJR>>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<XZWASXESRJR>>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<XZWASXESRJR>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x2B66110", Offset = "0x2B64F10", VA = "0x182B66110")]
		public static (Id32<WXKPXITHDLK<VABZENOIJNF>>, Id32<WXKPXITHDLK<CXMCVELPQUC>>, Id32<WXKPXITHDLK<CXMCVELPQUC>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<CXMCVELPQUC>>>) AKVNOVGYNJM(this UnsafeList<byte> a, int b, int c, [Optional] Id32<IXKHGZWDMFU<CXMCVELPQUC>>? d)
		{
			return default((Id32<WXKPXITHDLK<VABZENOIJNF>>, Id32<WXKPXITHDLK<CXMCVELPQUC>>, Id32<WXKPXITHDLK<CXMCVELPQUC>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<CXMCVELPQUC>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x2B69F70", Offset = "0x2B68D70", VA = "0x182B69F70")]
		public static (Id32<WXKPXITHDLK<VABZENOIJNF>>, Id32<WXKPXITHDLK<CXMCVELPQUC>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<CXMCVELPQUC>>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<CXMCVELPQUC>>>) SXMSTHUEQCB(this UnsafeList<byte> a, int b, [Optional] Id32<IXKHGZWDMFU<CXMCVELPQUC>>? c, [Optional] Id32<IXKHGZWDMFU<CXMCVELPQUC>>? d)
		{
			return default((Id32<WXKPXITHDLK<VABZENOIJNF>>, Id32<WXKPXITHDLK<CXMCVELPQUC>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<CXMCVELPQUC>>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<CXMCVELPQUC>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x2B67580", Offset = "0x2B66380", VA = "0x182B67580")]
		public static (Id32<WXKPXITHDLK<VABZENOIJNF>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<CXMCVELPQUC>>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<CXMCVELPQUC>>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<CXMCVELPQUC>>>) GRILZIPUAQM(this UnsafeList<byte> a, [Optional] Id32<IXKHGZWDMFU<CXMCVELPQUC>>? b, [Optional] Id32<IXKHGZWDMFU<CXMCVELPQUC>>? c, [Optional] Id32<IXKHGZWDMFU<CXMCVELPQUC>>? d)
		{
			return default((Id32<WXKPXITHDLK<VABZENOIJNF>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<CXMCVELPQUC>>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<CXMCVELPQUC>>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<CXMCVELPQUC>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x2B682E0", Offset = "0x2B670E0", VA = "0x182B682E0")]
		public static (Id32<WXKPXITHDLK<VABZENOIJNF>>, Id32<WXKPXITHDLK<CXMCVELPQUC>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<CXMCVELPQUC>>>) KMKENRMZICJ(this UnsafeList<byte> a, [Optional] int? b, [Optional] Id32<IXKHGZWDMFU<CXMCVELPQUC>>? c)
		{
			return default((Id32<WXKPXITHDLK<VABZENOIJNF>>, Id32<WXKPXITHDLK<CXMCVELPQUC>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<CXMCVELPQUC>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x2B6B4B0", Offset = "0x2B6A2B0", VA = "0x182B6B4B0")]
		public static (Id32<WXKPXITHDLK<VABZENOIJNF>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<CXMCVELPQUC>>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<CXMCVELPQUC>>>) YJDPFVNSRYG(this UnsafeList<byte> a, [Optional] Id32<IXKHGZWDMFU<CXMCVELPQUC>>? b, [Optional] Id32<IXKHGZWDMFU<CXMCVELPQUC>>? c)
		{
			return default((Id32<WXKPXITHDLK<VABZENOIJNF>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<CXMCVELPQUC>>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<CXMCVELPQUC>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x2B683F0", Offset = "0x2B671F0", VA = "0x182B683F0")]
		public static Id32<WXKPXITHDLK<VABZENOIJNF>> KXWDEBSCRJZ(this UnsafeList<byte> a)
		{
			return default(Id32<WXKPXITHDLK<VABZENOIJNF>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x2B663F0", Offset = "0x2B651F0", VA = "0x182B663F0")]
		public static (Id32<WXKPXITHDLK<VABZENOIJNF>>, Id32<WXKPXITHDLK<XZWASXESRJR>>, Id32<WXKPXITHDLK<XZWASXESRJR>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<XZWASXESRJR>>>) ATOKEPVQLXW(this UnsafeList<byte> a, float b, float c, [Optional] Id32<IXKHGZWDMFU<XZWASXESRJR>>? d)
		{
			return default((Id32<WXKPXITHDLK<VABZENOIJNF>>, Id32<WXKPXITHDLK<XZWASXESRJR>>, Id32<WXKPXITHDLK<XZWASXESRJR>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<XZWASXESRJR>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x2B68CE0", Offset = "0x2B67AE0", VA = "0x182B68CE0")]
		public static (Id32<WXKPXITHDLK<VABZENOIJNF>>, Id32<WXKPXITHDLK<XZWASXESRJR>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<XZWASXESRJR>>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<XZWASXESRJR>>>) NLWTIWFNMQP(this UnsafeList<byte> a, float b, [Optional] Id32<IXKHGZWDMFU<XZWASXESRJR>>? c, [Optional] Id32<IXKHGZWDMFU<XZWASXESRJR>>? d)
		{
			return default((Id32<WXKPXITHDLK<VABZENOIJNF>>, Id32<WXKPXITHDLK<XZWASXESRJR>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<XZWASXESRJR>>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<XZWASXESRJR>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x2B6B390", Offset = "0x2B6A190", VA = "0x182B6B390")]
		public static (Id32<WXKPXITHDLK<VABZENOIJNF>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<XZWASXESRJR>>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<XZWASXESRJR>>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<XZWASXESRJR>>>) YJAXLIRIIHY(this UnsafeList<byte> a, [Optional] Id32<IXKHGZWDMFU<XZWASXESRJR>>? b, [Optional] Id32<IXKHGZWDMFU<XZWASXESRJR>>? c, [Optional] Id32<IXKHGZWDMFU<XZWASXESRJR>>? d)
		{
			return default((Id32<WXKPXITHDLK<VABZENOIJNF>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<XZWASXESRJR>>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<XZWASXESRJR>>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<XZWASXESRJR>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x2B66570", Offset = "0x2B65370", VA = "0x182B66570")]
		public static (Id32<WXKPXITHDLK<VABZENOIJNF>>, Id32<WXKPXITHDLK<CXMCVELPQUC>>, Id32<WXKPXITHDLK<CXMCVELPQUC>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<CXMCVELPQUC>>>) BHYKYDUKLTU(this UnsafeList<byte> a, int b, int c, [Optional] Id32<IXKHGZWDMFU<CXMCVELPQUC>>? d)
		{
			return default((Id32<WXKPXITHDLK<VABZENOIJNF>>, Id32<WXKPXITHDLK<CXMCVELPQUC>>, Id32<WXKPXITHDLK<CXMCVELPQUC>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<CXMCVELPQUC>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x2B6AFC0", Offset = "0x2B69DC0", VA = "0x182B6AFC0")]
		public static (Id32<WXKPXITHDLK<VABZENOIJNF>>, Id32<WXKPXITHDLK<CXMCVELPQUC>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<CXMCVELPQUC>>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<CXMCVELPQUC>>>) XKZMCSRELAN(this UnsafeList<byte> a, int b, [Optional] Id32<IXKHGZWDMFU<CXMCVELPQUC>>? c, [Optional] Id32<IXKHGZWDMFU<CXMCVELPQUC>>? d)
		{
			return default((Id32<WXKPXITHDLK<VABZENOIJNF>>, Id32<WXKPXITHDLK<CXMCVELPQUC>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<CXMCVELPQUC>>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<CXMCVELPQUC>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x2B67300", Offset = "0x2B66100", VA = "0x182B67300")]
		public static (Id32<WXKPXITHDLK<VABZENOIJNF>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<CXMCVELPQUC>>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<CXMCVELPQUC>>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<CXMCVELPQUC>>>) FQYMULIRWQA(this UnsafeList<byte> a, [Optional] Id32<IXKHGZWDMFU<CXMCVELPQUC>>? b, [Optional] Id32<IXKHGZWDMFU<CXMCVELPQUC>>? c, [Optional] Id32<IXKHGZWDMFU<CXMCVELPQUC>>? d)
		{
			return default((Id32<WXKPXITHDLK<VABZENOIJNF>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<CXMCVELPQUC>>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<CXMCVELPQUC>>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<CXMCVELPQUC>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x2B69720", Offset = "0x2B68520", VA = "0x182B69720")]
		public static (Id32<WXKPXITHDLK<VABZENOIJNF>>, Id32<WXKPXITHDLK<CXMCVELPQUC>>, Id32<WXKPXITHDLK<CXMCVELPQUC>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<CXMCVELPQUC>>>) QNJLSQSKQBT(this UnsafeList<byte> a, int b, int c, [Optional] Id32<IXKHGZWDMFU<CXMCVELPQUC>>? d)
		{
			return default((Id32<WXKPXITHDLK<VABZENOIJNF>>, Id32<WXKPXITHDLK<CXMCVELPQUC>>, Id32<WXKPXITHDLK<CXMCVELPQUC>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<CXMCVELPQUC>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x2B68190", Offset = "0x2B66F90", VA = "0x182B68190")]
		public static (Id32<WXKPXITHDLK<VABZENOIJNF>>, Id32<WXKPXITHDLK<CXMCVELPQUC>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<CXMCVELPQUC>>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<CXMCVELPQUC>>>) JVJGNXLRVDI(this UnsafeList<byte> a, int b, [Optional] Id32<IXKHGZWDMFU<CXMCVELPQUC>>? c, [Optional] Id32<IXKHGZWDMFU<CXMCVELPQUC>>? d)
		{
			return default((Id32<WXKPXITHDLK<VABZENOIJNF>>, Id32<WXKPXITHDLK<CXMCVELPQUC>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<CXMCVELPQUC>>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<CXMCVELPQUC>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x2B666D0", Offset = "0x2B654D0", VA = "0x182B666D0")]
		public static (Id32<WXKPXITHDLK<VABZENOIJNF>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<CXMCVELPQUC>>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<CXMCVELPQUC>>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<CXMCVELPQUC>>>) BOICWFYUAWT(this UnsafeList<byte> a, [Optional] Id32<IXKHGZWDMFU<CXMCVELPQUC>>? b, [Optional] Id32<IXKHGZWDMFU<CXMCVELPQUC>>? c, [Optional] Id32<IXKHGZWDMFU<CXMCVELPQUC>>? d)
		{
			return default((Id32<WXKPXITHDLK<VABZENOIJNF>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<CXMCVELPQUC>>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<CXMCVELPQUC>>>, Id32<WXKPXITHDLK<IXKHGZWDMFU<CXMCVELPQUC>>>));
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
