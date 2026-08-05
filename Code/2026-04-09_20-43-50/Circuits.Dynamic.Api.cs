using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Circuits.Shared.Api;
using Circuits.Shared.Utilities;
using Cpp2IlInjected;
using Microsoft.CodeAnalysis;
using RecRoom.NoEngine.Common;
using RecRoom.NoEngine.DataStructures;

[assembly: AssemblyVersion("0.0.0.0")]
namespace Microsoft.CodeAnalysis
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class EmbeddedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0xD34090", Offset = "0xD33090", VA = "0x180D34090")]
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
	internal sealed class IsUnmanagedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xD34090", Offset = "0xD33090", VA = "0x180D34090")]
		public IsUnmanagedAttribute()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter, AllowMultiple = false, Inherited = false)]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x2B7DC20", Offset = "0x2B7CC20", VA = "0x182B7DC20")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xD34A60", Offset = "0xD33A60", VA = "0x180D34A60")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0xD34AA0", Offset = "0xD33AA0", VA = "0x180D34AA0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
namespace Circuits.Dynamic.Api
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public readonly struct CircuitsBool
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private readonly int _value;

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x15D7850", Offset = "0x15D6850", VA = "0x1815D7850")]
		private CircuitsBool(int value)
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x1561E50", Offset = "0x1560E50", VA = "0x181561E50")]
		public static bool LBSJLKWWTAL(CircuitsBool a)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x2B7D610", Offset = "0x2B7C610", VA = "0x182B7D610")]
		public static CircuitsBool LBSJLKWWTAL(bool a)
		{
			return default(CircuitsBool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public readonly struct DynamicCircuitsErr
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		public readonly IntPtr Ptr;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		public readonly Id32<ZEMNTRNURSC> DefId;

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x2B7D880", Offset = "0x2B7C880", VA = "0x182B7D880")]
		public DynamicCircuitsErr(IntPtr ptr, Id32<ZEMNTRNURSC> defId)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public readonly struct DynamicCircuitsErrDef
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private readonly IntPtr _destroy;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private readonly IntPtr _toDebugString;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private readonly IntPtr _toDisplayString;

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x1F50EC0", Offset = "0x1F4FEC0", VA = "0x181F50EC0")]
		public DynamicCircuitsErrDef(IntPtr destroy, IntPtr toDebugString, IntPtr toDisplayString)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x2B7D620", Offset = "0x2B7C620", VA = "0x182B7D620")]
		public void Destroy([In] DynamicCircuitsErr err)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public readonly struct DynamicCircuitsErrDefs
	{
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public static readonly DynamicCircuitsErrDefs Empty;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private readonly ReadOnlyIdArray<ZEMNTRNURSC, DynamicCircuitsErrDef> _impl;

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x2B34700", Offset = "0x2B33700", VA = "0x182B34700")]
		internal DynamicCircuitsErrDefs(ReadOnlyIdArray<ZEMNTRNURSC, DynamicCircuitsErrDef> impl)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x2B7D630", Offset = "0x2B7C630", VA = "0x182B7D630")]
		public DynamicCircuitsErrDef Get(Id32<ZEMNTRNURSC> dynamicCircuitsErrDefId)
		{
			return default(DynamicCircuitsErrDef);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public struct DynamicCircuitsErrRegistryFactory
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private IdUnsafeList<ZEMNTRNURSC, DynamicCircuitsErrDef> _dynamicCircuitsErrDefs;

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x12D4C50", Offset = "0x12D3C50", VA = "0x1812D4C50")]
		private DynamicCircuitsErrRegistryFactory([In] IdUnsafeList<ZEMNTRNURSC, DynamicCircuitsErrDef> dynamicCircuitsErrDefs)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x2B7D750", Offset = "0x2B7C750", VA = "0x182B7D750")]
		public static DynamicCircuitsErrRegistryFactory SIUHUEYRRON()
		{
			return default(DynamicCircuitsErrRegistryFactory);
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x2B7D700", Offset = "0x2B7C700", VA = "0x182B7D700")]
		public DynamicCircuitsErrDefs CLJSAMBXECZ()
		{
			return default(DynamicCircuitsErrDefs);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x2B7D7B0", Offset = "0x2B7C7B0", VA = "0x182B7D7B0")]
		public void UKDOUQGZAQX(Id32<ZEMNTRNURSC> dynamicCircuitsErrDefId, [In] DynamicCircuitsErrDef dynamicCircuitsErrDef)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public readonly struct ExternalFnDelegate
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private readonly IntPtr _functionPointer;

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0xEE3920", Offset = "0xEE2920", VA = "0x180EE3920")]
		public ExternalFnDelegate(IntPtr functionPointer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x2B7D890", Offset = "0x2B7C890", VA = "0x182B7D890")]
		public Result<None, DynamicCircuitsErr> Invoke([In] ExternalFnDeps deps, IntPtr ctx)
		{
			return default(Result<None, DynamicCircuitsErr>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public readonly struct ExternalFnDeps
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private readonly IntPtr _getExternalFnIODeps;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private readonly IntPtr _getDynamicDeps;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private readonly IntPtr _getExecParams;

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x1F50EC0", Offset = "0x1F4FEC0", VA = "0x181F50EC0")]
		public ExternalFnDeps(IntPtr getExternalFnIODeps, IntPtr getDynamicDeps, IntPtr getExecParams)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x2B7D8D0", Offset = "0x2B7C8D0", VA = "0x182B7D8D0")]
		internal ExternalFnIODeps BEKOLUXQFZD(IntPtr a)
		{
			return default(ExternalFnIODeps);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x2B7D910", Offset = "0x2B7C910", VA = "0x182B7D910")]
		internal IntPtr FAUSHDFWOEH(IntPtr a)
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x2B7D930", Offset = "0x2B7C930", VA = "0x182B7D930")]
		internal JTWCQRGBJCE TSSTKEXFUSH(IntPtr a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public static class AXQVBCYMFMQ
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x2B7D400", Offset = "0x2B7C400", VA = "0x182B7D400")]
		public static void LEZXLAMXWMJ([In] this ExternalFnDeps deps, IntPtr a, [Out] ExternalFnIO b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x2B7D310", Offset = "0x2B7C310", VA = "0x182B7D310")]
		public static void LEZXLAMXWMJ([In] this ExternalFnDeps deps, IntPtr a, [Out] ExternalFnIO b, [Out] JTWCQRGBJCE c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x3380950", Offset = "0x337F950", VA = "0x183380950")]
		public static TDeps LEZXLAMXWMJ<TDeps>([In] this ExternalFnDeps deps, IntPtr a, [Out] ExternalFnIO b) where TDeps : notnull
		{
			return (TDeps)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x3380730", Offset = "0x337F730", VA = "0x183380730")]
		public static TDeps LEZXLAMXWMJ<TDeps>([In] this ExternalFnDeps deps, IntPtr a, [Out] ExternalFnIO b, [Out] JTWCQRGBJCE c) where TDeps : notnull
		{
			return (TDeps)null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public struct ExternalFnIO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		internal Id32<UTDLMYHANGH<RRRVXHRUCXR>> _UnmanagedArgPtr;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		internal Id32<UTDLMYHANGH<RRRVXHRUCXR>> _UnmanagedReturnPtr;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		internal Id32<BEQDFDHTNDH> _ManagedArgPtr;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		internal Id32<BEQDFDHTNDH> _ManagedReturnPtr;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		internal IdArray<UTDLMYHANGH<RRRVXHRUCXR>, byte> _UnmanagedRegisters;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		internal IdArray<BEQDFDHTNDH, object?> _ManagedRegisters;

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x2B7D990", Offset = "0x2B7C990", VA = "0x182B7D990")]
		internal ExternalFnIO(Id32<UTDLMYHANGH<RRRVXHRUCXR>> unmanagedArgPtr, Id32<UTDLMYHANGH<RRRVXHRUCXR>> unmanagedReturnPtr, Id32<BEQDFDHTNDH> managedArgPtr, Id32<BEQDFDHTNDH> managedReturnPtr, IdArray<UTDLMYHANGH<RRRVXHRUCXR>, byte> unmanagedRegisters, IdArray<BEQDFDHTNDH, object?> managedRegisters)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public static class CKWLGXFCPZL
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x2B7D4C0", Offset = "0x2B7C4C0", VA = "0x182B7D4C0")]
		public static ReadOnlySpan<byte> In(this ExternalFnIO self, int size)
		{
			return default(ReadOnlySpan<byte>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public static class SFVOKRUGOGZ
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x3F1CB70", Offset = "0x3F1BB70", VA = "0x183F1CB70")]
		public static T In<T>(this ExternalFnIO self) where T : struct
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x3F1D3E0", Offset = "0x3F1C3E0", VA = "0x183F1D3E0")]
		public static void Out<T>(this ExternalFnIO self, T value) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x2B7DF80", Offset = "0x2B7CF80", VA = "0x182B7DF80")]
		public static void Out(this ExternalFnIO self, bool value)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public static class MGPSXRGJWZO
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x3C39E80", Offset = "0x3C38E80", VA = "0x183C39E80")]
		public static T In<T>(this ExternalFnIO self) where T : class
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x3C39F90", Offset = "0x3C38F90", VA = "0x183C39F90")]
		public static void Out<T>(this ExternalFnIO self, T value) where T : class
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public struct ExternalFnIODeps
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		internal readonly Id32<UTDLMYHANGH<RRRVXHRUCXR>> _UnmanagedRegisterPointer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		internal readonly Id32<BEQDFDHTNDH> _ManagedRegisterPointer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		internal IdArray<UTDLMYHANGH<RRRVXHRUCXR>, byte> _UnmanagedRegisters;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		internal IdArray<BEQDFDHTNDH, object?> _ManagedRegisters;

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x2B7D950", Offset = "0x2B7C950", VA = "0x182B7D950")]
		public ExternalFnIODeps(Id32<UTDLMYHANGH<RRRVXHRUCXR>> unmanagedRegisterPointer, Id32<BEQDFDHTNDH> managedRegisterPointer, IdArray<UTDLMYHANGH<RRRVXHRUCXR>, byte> unmanagedRegisters, IdArray<BEQDFDHTNDH, object?> managedRegisters)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public struct ExternalFnRegistryFactory
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private IdUnsafeList<CQQKHLGBDOQ, ExternalFnDelegate> _externalDefs;

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x12D4C50", Offset = "0x12D3C50", VA = "0x1812D4C50")]
		private ExternalFnRegistryFactory([In] IdUnsafeList<CQQKHLGBDOQ, ExternalFnDelegate> externalDefs)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x2B7DAF0", Offset = "0x2B7CAF0", VA = "0x182B7DAF0")]
		public static ExternalFnRegistryFactory SIUHUEYRRON()
		{
			return default(ExternalFnRegistryFactory);
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x2B7D9E0", Offset = "0x2B7C9E0", VA = "0x182B7D9E0")]
		public ExternalFns CLJSAMBXECZ()
		{
			return default(ExternalFns);
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x2B7DA30", Offset = "0x2B7CA30", VA = "0x182B7DA30")]
		public void KSUFYKHRQCL(Id32<CQQKHLGBDOQ> externalFnId, IntPtr a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public readonly struct ExternalFns
	{
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public static readonly ExternalFns Empty;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private readonly ReadOnlyIdArray<CQQKHLGBDOQ, ExternalFnDelegate> _impl;

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x2B34700", Offset = "0x2B33700", VA = "0x182B34700")]
		internal ExternalFns(ReadOnlyIdArray<CQQKHLGBDOQ, ExternalFnDelegate> impl)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x2B7DB50", Offset = "0x2B7CB50", VA = "0x182B7DB50")]
		public ExternalFnDelegate Get(Id32<CQQKHLGBDOQ> externalFnId)
		{
			return default(ExternalFnDelegate);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public interface ZAWQUGKQBEM
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void AECCAWEDORY();
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public interface JTWCQRGBJCE
	{
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		LegacyCV2Result<None> OTSRFZDXSNS(int a);

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		LegacyCV2Result<None> NGWMJVJZXJR(int a, bool b = true);

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(Slot = "2")]
		bool GXXCSJCKHKG(int a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public interface UKNZYCJKZBM
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public readonly struct LegacyCV2Result<T> : IEnumerable<T>, IEnumerable
	{
		[Cpp2IlInjected.Token(Token = "0x2000019")]
		private sealed class MPEGJYGPDJW<b> : IEnumerator<b>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001F")]
			private readonly LegacyCV2Result<b> ORAECKMBJZG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000020")]
			private bool FLXZXENKXVV;

			[Cpp2IlInjected.Token(Token = "0x17000001")]
			public b Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000038")]
				[Cpp2IlInjected.Address(RVA = "0x7027B90", Offset = "0x7026B90", VA = "0x187027B90", Slot = "4")]
				get
				{
					return (b)null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000002")]
			private object RTHQPUQEOJM
			{
				[Cpp2IlInjected.Token(Token = "0x6000039")]
				[Cpp2IlInjected.Address(RVA = "0x7027360", Offset = "0x7026360", VA = "0x187027360", Slot = "7")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x7027800", Offset = "0x7026800", VA = "0x187027800")]
			public MPEGJYGPDJW([In] LegacyCV2Result<b> result)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0xD0AF90", Offset = "0xD09F90", VA = "0x180D0AF90", Slot = "5")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x70274E0", Offset = "0x70264E0", VA = "0x1870274E0", Slot = "6")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x70277B0", Offset = "0x70267B0", VA = "0x1870277B0", Slot = "8")]
			public void Reset()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public readonly UKNZYCJKZBM err;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public readonly T ok;

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x69BB860", Offset = "0x69BA860", VA = "0x1869BB860")]
		private LegacyCV2Result(UKNZYCJKZBM err, [In] T ok)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x69B80A0", Offset = "0x69B70A0", VA = "0x1869B80A0")]
		public static LegacyCV2Result<T> ARGBUOZFZQD(UKNZYCJKZBM a)
		{
			return default(LegacyCV2Result<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x69B9C60", Offset = "0x69B8C60", VA = "0x1869B9C60")]
		public static LegacyCV2Result<T> Ok([In] T ok)
		{
			return default(LegacyCV2Result<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x39CFB90", Offset = "0x39CEB90", VA = "0x1839CFB90")]
		public LegacyCV2Result<a?> SDMNBAUKTBM<a>()
		{
			return default(LegacyCV2Result<a>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x69B9330", Offset = "0x69B8330", VA = "0x1869B9330")]
		public LegacyCV2Result<None> JKSHCPRHBLH()
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x69B8990", Offset = "0x69B7990", VA = "0x1869B8990", Slot = "4")]
		public IEnumerator<T> GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x69B8C30", Offset = "0x69B7C30", VA = "0x1869B8C30", Slot = "5")]
		private IEnumerator IEVKUCCAWWZ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x69BA1D0", Offset = "0x69B91D0", VA = "0x1869BA1D0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public static class VXNHNVIVWSB
	{
		[Cpp2IlInjected.Token(Token = "0x200001B")]
		public delegate U RefMapOp<T, U, Args>([In] T ok, [In] Args args);

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x40DD4B0", Offset = "0x40DC4B0", VA = "0x1840DD4B0")]
		public static LegacyCV2Result<T> ARGBUOZFZQD<T>(UKNZYCJKZBM a) where T : notnull
		{
			return default(LegacyCV2Result<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x2B7E050", Offset = "0x2B7D050", VA = "0x182B7E050")]
		public static LegacyCV2Result<None> ARGBUOZFZQD(UKNZYCJKZBM err)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x40DE4A0", Offset = "0x40DD4A0", VA = "0x1840DE4A0")]
		public static LegacyCV2Result<T> Ok<T>([In] T ok) where T : notnull
		{
			return default(LegacyCV2Result<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x2B7E0B0", Offset = "0x2B7D0B0", VA = "0x182B7E0B0")]
		public static LegacyCV2Result<None> Ok()
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x3BA9A40", Offset = "0x3BA8A40", VA = "0x183BA9A40")]
		public static bool MELYQXGTSAK<a>([In] this LegacyCV2Result<a> self)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x1AAD840", Offset = "0x1AAC840", VA = "0x181AAD840")]
		public static bool RZCFQTOLJTN<b>([In] this LegacyCV2Result<b> self)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x40DF250", Offset = "0x40DE250", VA = "0x1840DF250")]
		public static LegacyCV2Result<i?> THSBDCRAOMZ<i, h>([In] this LegacyCV2Result<h> self, [In] LegacyCV2Result<i> ok)
		{
			return default(LegacyCV2Result<i>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x40DDDE0", Offset = "0x40DCDE0", VA = "0x1840DDDE0")]
		public static LegacyCV2Result<m?> EYVDOUAKNEW<m, l, n>([In] this LegacyCV2Result<l> self, [In] n args, RefMapOp<l, LegacyCV2Result<m>, n> ok)
		{
			return default(LegacyCV2Result<m>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x40DD8E0", Offset = "0x40DC8E0", VA = "0x1840DD8E0")]
		public static T CNAAOLXBPRV<T>([In] this LegacyCV2Result<T> self) where T : notnull
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x40DF510", Offset = "0x40DE510", VA = "0x1840DF510")]
		public static bool Try<T>([In] this LegacyCV2Result<T> self, [Out] LegacyCV2Result<T> res)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x40DEAF0", Offset = "0x40DDAF0", VA = "0x1840DEAF0")]
		public static bool PXXJOAVVPYH<T>([In] this LegacyCV2Result<T> self, [Out] T a, [Out] LegacyCV2Result<T> res) where T : notnull
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x40DF8D0", Offset = "0x40DE8D0", VA = "0x1840DF8D0")]
		public static bool UWWQVUZQYEC<T>([In] this LegacyCV2Result<T> self, [Out] T ok, [Out] LegacyCV2Result<None> a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x40DDF90", Offset = "0x40DCF90", VA = "0x1840DDF90")]
		public static bool FELVUHODMMQ<r, s>([In] this LegacyCV2Result<r> self, [Out] s a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x40E0030", Offset = "0x40DF030", VA = "0x1840E0030")]
		public static LegacyCV2Result<t?> WAICIMDHEUG<t>([In] this LegacyCV2Result<LegacyCV2Result<t>> self)
		{
			return default(LegacyCV2Result<t>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public sealed class ZEMNTRNURSC
	{
	}
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	public readonly struct RuntimeFnDelegate
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private readonly IntPtr _functionPointer;

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0xEE3920", Offset = "0xEE2920", VA = "0x180EE3920")]
		public RuntimeFnDelegate(IntPtr functionPointer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x2B7DCA0", Offset = "0x2B7CCA0", VA = "0x182B7DCA0")]
		public void Invoke([In] RuntimeFnDeps deps, IntPtr ctx, [In] ReadOnlySpan<byte> data)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public readonly struct RuntimeFnDeps
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private readonly IntPtr _getUnmanagedRegisterPointer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private readonly IntPtr _getManagedRegisterPointer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private readonly IntPtr _getUnmanagedRegisters;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private readonly IntPtr _getManagedRegisters;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private readonly IntPtr _setUnmanagedRegisterPointer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private readonly IntPtr _setManagedRegisterPointer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private readonly IntPtr _getDynamicDeps;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private readonly IntPtr _setDataDeadEnd;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private readonly IntPtr _setExecDeadEnd;

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0xF1F1F0", Offset = "0xF1E1F0", VA = "0x180F1F1F0")]
		public RuntimeFnDeps(IntPtr getUnmanagedRegisterPointer, IntPtr getManagedRegisterPointer, IntPtr getUnmanagedRegisters, IntPtr getManagedRegisters, IntPtr setUnmanagedRegisterPointer, IntPtr setManagedRegisterPointer, IntPtr getDynamicDeps, IntPtr setDataDeadEnd, IntPtr setExecDeadEnd)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x2B7D910", Offset = "0x2B7C910", VA = "0x182B7D910")]
		public Id32<BEQDFDHTNDH> NKPOZWJVDSJ(IntPtr a)
		{
			return default(Id32<BEQDFDHTNDH>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x2B7DCE0", Offset = "0x2B7CCE0", VA = "0x182B7DCE0")]
		public IdArray<BEQDFDHTNDH, object> ICXUQEMPIUJ(IntPtr a)
		{
			return default(IdArray<BEQDFDHTNDH, object>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x2B7DD00", Offset = "0x2B7CD00", VA = "0x182B7DD00")]
		public void KCXTSHGXAFD(IntPtr a, Id32<BEQDFDHTNDH> value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x3F149B0", Offset = "0x3F139B0", VA = "0x183F149B0")]
		public TDeps FAUSHDFWOEH<TDeps>(IntPtr a) where TDeps : notnull
		{
			return (TDeps)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x2B7DD20", Offset = "0x2B7CD20", VA = "0x182B7DD20")]
		public void XOCIHPBIPYH(IntPtr a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x2B7DCC0", Offset = "0x2B7CCC0", VA = "0x182B7DCC0")]
		public void EQBGPBIOMKM(IntPtr a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public struct RuntimeFnRegistryFactory
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private IdUnsafeList<FKAHYQVBHTH, RuntimeFnDelegate> _runtimeDefs;

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x12D4C50", Offset = "0x12D3C50", VA = "0x1812D4C50")]
		private RuntimeFnRegistryFactory([In] IdUnsafeList<FKAHYQVBHTH, RuntimeFnDelegate> runtimeDefs)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x2B7DD90", Offset = "0x2B7CD90", VA = "0x182B7DD90")]
		public static RuntimeFnRegistryFactory SIUHUEYRRON()
		{
			return default(RuntimeFnRegistryFactory);
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x2B7DD40", Offset = "0x2B7CD40", VA = "0x182B7DD40")]
		public RuntimeFns CLJSAMBXECZ()
		{
			return default(RuntimeFns);
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x2B7DDF0", Offset = "0x2B7CDF0", VA = "0x182B7DDF0")]
		public void XIUBLUPEOIA(Id32<FKAHYQVBHTH> runtimeFnId, IntPtr a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public readonly struct RuntimeFns
	{
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		public static readonly RuntimeFns Empty;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private readonly ReadOnlyIdArray<FKAHYQVBHTH, RuntimeFnDelegate> _impl;

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x2B34700", Offset = "0x2B33700", VA = "0x182B34700")]
		internal RuntimeFns(ReadOnlyIdArray<FKAHYQVBHTH, RuntimeFnDelegate> impl)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x2B7DEB0", Offset = "0x2B7CEB0", VA = "0x182B7DEB0")]
		public RuntimeFnDelegate Get(Id32<FKAHYQVBHTH> runtimeFnId)
		{
			return default(RuntimeFnDelegate);
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
