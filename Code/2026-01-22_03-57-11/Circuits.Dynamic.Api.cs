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
	internal sealed class IsUnmanagedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xAD7680", Offset = "0xAD5E80", VA = "0x180AD7680")]
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
		[Cpp2IlInjected.Address(RVA = "0x28CAEC0", Offset = "0x28C96C0", VA = "0x1828CAEC0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xAD7810", Offset = "0xAD6010", VA = "0x180AD7810")]
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
		[Cpp2IlInjected.Address(RVA = "0xAD7850", Offset = "0xAD6050", VA = "0x180AD7850")]
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
		[Cpp2IlInjected.Address(RVA = "0x1320020", Offset = "0x131E820", VA = "0x181320020")]
		private CircuitsBool(int value)
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x12A5180", Offset = "0x12A3980", VA = "0x1812A5180")]
		public static bool PIUEUOZQYSW(CircuitsBool a)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x28CA4E0", Offset = "0x28C8CE0", VA = "0x1828CA4E0")]
		public static CircuitsBool PIUEUOZQYSW(bool a)
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
		public readonly Id32<RNVYDKETTMF> DefId;

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x28CA750", Offset = "0x28C8F50", VA = "0x1828CA750")]
		public DynamicCircuitsErr(IntPtr ptr, Id32<RNVYDKETTMF> defId)
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
		[Cpp2IlInjected.Address(RVA = "0x1C99A20", Offset = "0x1C98220", VA = "0x181C99A20")]
		public DynamicCircuitsErrDef(IntPtr destroy, IntPtr toDebugString, IntPtr toDisplayString)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x28CA4F0", Offset = "0x28C8CF0", VA = "0x1828CA4F0")]
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
		private readonly ReadOnlyIdArray<RNVYDKETTMF, DynamicCircuitsErrDef> _impl;

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x28829D0", Offset = "0x28811D0", VA = "0x1828829D0")]
		internal DynamicCircuitsErrDefs(ReadOnlyIdArray<RNVYDKETTMF, DynamicCircuitsErrDef> impl)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x28CA500", Offset = "0x28C8D00", VA = "0x1828CA500")]
		public DynamicCircuitsErrDef Get(Id32<RNVYDKETTMF> dynamicCircuitsErrDefId)
		{
			return default(DynamicCircuitsErrDef);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public struct DynamicCircuitsErrRegistryFactory
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private IdUnsafeList<RNVYDKETTMF, DynamicCircuitsErrDef> _dynamicCircuitsErrDefs;

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x102F760", Offset = "0x102DF60", VA = "0x18102F760")]
		private DynamicCircuitsErrRegistryFactory([In] IdUnsafeList<RNVYDKETTMF, DynamicCircuitsErrDef> dynamicCircuitsErrDefs)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x28CA620", Offset = "0x28C8E20", VA = "0x1828CA620")]
		public static DynamicCircuitsErrRegistryFactory CYOPTWCDXLK()
		{
			return default(DynamicCircuitsErrRegistryFactory);
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x28CA5D0", Offset = "0x28C8DD0", VA = "0x1828CA5D0")]
		public DynamicCircuitsErrDefs AXHFTEUJRLO()
		{
			return default(DynamicCircuitsErrDefs);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x28CA680", Offset = "0x28C8E80", VA = "0x1828CA680")]
		public void HUOYRBHWCHG(Id32<RNVYDKETTMF> dynamicCircuitsErrDefId, [In] DynamicCircuitsErrDef dynamicCircuitsErrDef)
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
		[Cpp2IlInjected.Address(RVA = "0xC21680", Offset = "0xC1FE80", VA = "0x180C21680")]
		public ExternalFnDelegate(IntPtr functionPointer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x28CA760", Offset = "0x28C8F60", VA = "0x1828CA760")]
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
		[Cpp2IlInjected.Address(RVA = "0x1C99A20", Offset = "0x1C98220", VA = "0x181C99A20")]
		public ExternalFnDeps(IntPtr getExternalFnIODeps, IntPtr getDynamicDeps, IntPtr getExecParams)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x28CA7A0", Offset = "0x28C8FA0", VA = "0x1828CA7A0")]
		internal ExternalFnIODeps JYJTVRPCHZK(IntPtr a)
		{
			return default(ExternalFnIODeps);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x28CA800", Offset = "0x28C9000", VA = "0x1828CA800")]
		internal IntPtr PSVXIZTFXYM(IntPtr a)
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x28CA7E0", Offset = "0x28C8FE0", VA = "0x1828CA7E0")]
		internal KWKTECQWUKV OTPBHACGGTU(IntPtr a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public static class NUFZXZFRXUN
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x28CAD10", Offset = "0x28C9510", VA = "0x1828CAD10")]
		public static void OFUNHGQCVUE([In] this ExternalFnDeps deps, IntPtr a, [Out] ExternalFnIO b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x28CADD0", Offset = "0x28C95D0", VA = "0x1828CADD0")]
		public static void OFUNHGQCVUE([In] this ExternalFnDeps deps, IntPtr a, [Out] ExternalFnIO b, [Out] KWKTECQWUKV c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x38AB820", Offset = "0x38AA020", VA = "0x1838AB820")]
		public static TDeps OFUNHGQCVUE<TDeps>([In] this ExternalFnDeps deps, IntPtr a, [Out] ExternalFnIO b) where TDeps : notnull
		{
			return (TDeps)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x38ABA20", Offset = "0x38AA220", VA = "0x1838ABA20")]
		public static TDeps OFUNHGQCVUE<TDeps>([In] this ExternalFnDeps deps, IntPtr a, [Out] ExternalFnIO b, [Out] KWKTECQWUKV c) where TDeps : notnull
		{
			return (TDeps)null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public struct ExternalFnIO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		internal Id32<GZQXHQYHYRK<JRUSPVYOFZC>> _UnmanagedArgPtr;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		internal Id32<GZQXHQYHYRK<JRUSPVYOFZC>> _UnmanagedReturnPtr;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		internal Id32<NWXWONCHIFS> _ManagedArgPtr;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		internal Id32<NWXWONCHIFS> _ManagedReturnPtr;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		internal IdArray<GZQXHQYHYRK<JRUSPVYOFZC>, byte> _UnmanagedRegisters;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		internal IdArray<NWXWONCHIFS, object?> _ManagedRegisters;

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x28CA860", Offset = "0x28C9060", VA = "0x1828CA860")]
		internal ExternalFnIO(Id32<GZQXHQYHYRK<JRUSPVYOFZC>> unmanagedArgPtr, Id32<GZQXHQYHYRK<JRUSPVYOFZC>> unmanagedReturnPtr, Id32<NWXWONCHIFS> managedArgPtr, Id32<NWXWONCHIFS> managedReturnPtr, IdArray<GZQXHQYHYRK<JRUSPVYOFZC>, byte> unmanagedRegisters, IdArray<NWXWONCHIFS, object?> managedRegisters)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public static class MOWZEIJTGCS
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x28CABC0", Offset = "0x28C93C0", VA = "0x1828CABC0")]
		public static ReadOnlySpan<byte> In(this ExternalFnIO self, int size)
		{
			return default(ReadOnlySpan<byte>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public static class JNQDYXXWDOY
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x37696E0", Offset = "0x3767EE0", VA = "0x1837696E0")]
		public static T In<T>(this ExternalFnIO self) where T : struct
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x3769F50", Offset = "0x3768750", VA = "0x183769F50")]
		public static void Out<T>(this ExternalFnIO self, T value) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x28CAAF0", Offset = "0x28C92F0", VA = "0x1828CAAF0")]
		public static void Out(this ExternalFnIO self, bool value)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public static class UYMUSZFLPDJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x3BB06F0", Offset = "0x3BAEEF0", VA = "0x183BB06F0")]
		public static T In<T>(this ExternalFnIO self) where T : class
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x3BB07E0", Offset = "0x3BAEFE0", VA = "0x183BB07E0")]
		public static void Out<T>(this ExternalFnIO self, T value) where T : class
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public struct ExternalFnIODeps
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		internal readonly Id32<GZQXHQYHYRK<JRUSPVYOFZC>> _UnmanagedRegisterPointer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		internal readonly Id32<NWXWONCHIFS> _ManagedRegisterPointer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		internal IdArray<GZQXHQYHYRK<JRUSPVYOFZC>, byte> _UnmanagedRegisters;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		internal IdArray<NWXWONCHIFS, object?> _ManagedRegisters;

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x28CA820", Offset = "0x28C9020", VA = "0x1828CA820")]
		public ExternalFnIODeps(Id32<GZQXHQYHYRK<JRUSPVYOFZC>> unmanagedRegisterPointer, Id32<NWXWONCHIFS> managedRegisterPointer, IdArray<GZQXHQYHYRK<JRUSPVYOFZC>, byte> unmanagedRegisters, IdArray<NWXWONCHIFS, object?> managedRegisters)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public struct ExternalFnRegistryFactory
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private IdUnsafeList<ULSOTBCMXIN, ExternalFnDelegate> _externalDefs;

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x102F760", Offset = "0x102DF60", VA = "0x18102F760")]
		private ExternalFnRegistryFactory([In] IdUnsafeList<ULSOTBCMXIN, ExternalFnDelegate> externalDefs)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x28CA900", Offset = "0x28C9100", VA = "0x1828CA900")]
		public static ExternalFnRegistryFactory CYOPTWCDXLK()
		{
			return default(ExternalFnRegistryFactory);
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x28CA8B0", Offset = "0x28C90B0", VA = "0x1828CA8B0")]
		public ExternalFns AXHFTEUJRLO()
		{
			return default(ExternalFns);
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x28CA960", Offset = "0x28C9160", VA = "0x1828CA960")]
		public void PLDGGOLMWPM(Id32<ULSOTBCMXIN> externalFnId, IntPtr a)
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
		private readonly ReadOnlyIdArray<ULSOTBCMXIN, ExternalFnDelegate> _impl;

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x28829D0", Offset = "0x28811D0", VA = "0x1828829D0")]
		internal ExternalFns(ReadOnlyIdArray<ULSOTBCMXIN, ExternalFnDelegate> impl)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x28CAA20", Offset = "0x28C9220", VA = "0x1828CAA20")]
		public ExternalFnDelegate Get(Id32<ULSOTBCMXIN> externalFnId)
		{
			return default(ExternalFnDelegate);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public interface QUBDHEIJUTP
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void KJTYMYJCDPB();
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public interface KWKTECQWUKV
	{
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		LegacyCV2Result<None> FQCLWTMBIIN(int a);

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		LegacyCV2Result<None> IGKKDCMWLDK(int a, bool b = true);

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(Slot = "2")]
		bool NKAACDNSLQL(int a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public interface JQZOFTEVPUX
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public readonly struct LegacyCV2Result<T> : IEnumerable<T>, IEnumerable
	{
		[Cpp2IlInjected.Token(Token = "0x2000019")]
		private sealed class MESRDNZKIBB<b> : IEnumerator<b>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001F")]
			private readonly LegacyCV2Result<b> HABHYPEDKMN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000020")]
			private bool SNRTRNKFLRW;

			[Cpp2IlInjected.Token(Token = "0x17000001")]
			public b Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000038")]
				[Cpp2IlInjected.Address(RVA = "0x57E7BF0", Offset = "0x57E63F0", VA = "0x1857E7BF0", Slot = "4")]
				get
				{
					return (b)null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000002")]
			private object BXTOFOKJAZT
			{
				[Cpp2IlInjected.Token(Token = "0x6000039")]
				[Cpp2IlInjected.Address(RVA = "0x57E7570", Offset = "0x57E5D70", VA = "0x1857E7570", Slot = "7")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x57E7A60", Offset = "0x57E6260", VA = "0x1857E7A60")]
			public MESRDNZKIBB([In] LegacyCV2Result<b> result)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0xAAEAD0", Offset = "0xAAD2D0", VA = "0x180AAEAD0", Slot = "5")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x57E7290", Offset = "0x57E5A90", VA = "0x1857E7290", Slot = "6")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x57E77B0", Offset = "0x57E5FB0", VA = "0x1857E77B0", Slot = "8")]
			public void Reset()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public readonly JQZOFTEVPUX err;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public readonly T ok;

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x53571E0", Offset = "0x53559E0", VA = "0x1853571E0")]
		private LegacyCV2Result(JQZOFTEVPUX err, [In] T ok)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x5354040", Offset = "0x5352840", VA = "0x185354040")]
		public static LegacyCV2Result<T> GPJDWMBBLWO(JQZOFTEVPUX a)
		{
			return default(LegacyCV2Result<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x5354910", Offset = "0x5353110", VA = "0x185354910")]
		public static LegacyCV2Result<T> Ok([In] T ok)
		{
			return default(LegacyCV2Result<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x36325A0", Offset = "0x3630DA0", VA = "0x1836325A0")]
		public LegacyCV2Result<a?> VITPNGHZCPN<a>()
		{
			return default(LegacyCV2Result<a>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x5355900", Offset = "0x5354100", VA = "0x185355900")]
		public LegacyCV2Result<None> SYRKFHDVDLU()
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x53544D0", Offset = "0x5352CD0", VA = "0x1853544D0", Slot = "4")]
		public IEnumerator<T> GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x5354730", Offset = "0x5352F30", VA = "0x185354730", Slot = "5")]
		private IEnumerator LRASTPXJBWO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x5355DD0", Offset = "0x53545D0", VA = "0x185355DD0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public static class BABOUGAUQZO
	{
		[Cpp2IlInjected.Token(Token = "0x200001B")]
		public delegate U RefMapOp<T, U, Args>([In] T ok, [In] Args args);

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x33D7B60", Offset = "0x33D6360", VA = "0x1833D7B60")]
		public static LegacyCV2Result<T> GPJDWMBBLWO<T>(JQZOFTEVPUX a) where T : notnull
		{
			return default(LegacyCV2Result<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x28CA420", Offset = "0x28C8C20", VA = "0x1828CA420")]
		public static LegacyCV2Result<None> GPJDWMBBLWO(JQZOFTEVPUX err)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x33D8950", Offset = "0x33D7150", VA = "0x1833D8950")]
		public static LegacyCV2Result<T> Ok<T>([In] T ok) where T : notnull
		{
			return default(LegacyCV2Result<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x28CA480", Offset = "0x28C8C80", VA = "0x1828CA480")]
		public static LegacyCV2Result<None> Ok()
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x33D8350", Offset = "0x33D6B50", VA = "0x1833D8350")]
		public static bool LKIMPJTLFIF<a>([In] this LegacyCV2Result<a> self)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x17F8EE0", Offset = "0x17F76E0", VA = "0x1817F8EE0")]
		public static bool SQWUINUVVWK<b>([In] this LegacyCV2Result<b> self)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x33D9250", Offset = "0x33D7A50", VA = "0x1833D9250")]
		public static LegacyCV2Result<i?> RAXGDDZTSVK<i, h>([In] this LegacyCV2Result<h> self, [In] LegacyCV2Result<i> ok)
		{
			return default(LegacyCV2Result<i>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x33D84F0", Offset = "0x33D6CF0", VA = "0x1833D84F0")]
		public static LegacyCV2Result<m?> LTIVOIJTWVR<m, l, n>([In] this LegacyCV2Result<l> self, [In] n args, RefMapOp<l, LegacyCV2Result<m>, n> ok)
		{
			return default(LegacyCV2Result<m>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x33D7F90", Offset = "0x33D6790", VA = "0x1833D7F90")]
		public static T HQVSWDMNLEM<T>([In] this LegacyCV2Result<T> self) where T : notnull
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x33D9D90", Offset = "0x33D8590", VA = "0x1833D9D90")]
		public static bool Try<T>([In] this LegacyCV2Result<T> self, [Out] LegacyCV2Result<T> res)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x33D95B0", Offset = "0x33D7DB0", VA = "0x1833D95B0")]
		public static bool RMKZRLMVTAU<T>([In] this LegacyCV2Result<T> self, [Out] T a, [Out] LegacyCV2Result<T> res) where T : notnull
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x33D72B0", Offset = "0x33D5AB0", VA = "0x1833D72B0")]
		public static bool EVSLMQCPGJV<T>([In] this LegacyCV2Result<T> self, [Out] T ok, [Out] LegacyCV2Result<None> a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x33D70A0", Offset = "0x33D58A0", VA = "0x1833D70A0")]
		public static bool CGXCFJIGXUH<r, s>([In] this LegacyCV2Result<r> self, [Out] s a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x33D8EE0", Offset = "0x33D76E0", VA = "0x1833D8EE0")]
		public static LegacyCV2Result<t?> QOZTCAIUZYX<t>([In] this LegacyCV2Result<LegacyCV2Result<t>> self)
		{
			return default(LegacyCV2Result<t>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public sealed class RNVYDKETTMF
	{
	}
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	public readonly struct RuntimeFnDelegate
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private readonly IntPtr _functionPointer;

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0xC21680", Offset = "0xC1FE80", VA = "0x180C21680")]
		public RuntimeFnDelegate(IntPtr functionPointer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x28CAF40", Offset = "0x28C9740", VA = "0x1828CAF40")]
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
		[Cpp2IlInjected.Address(RVA = "0xC7DB60", Offset = "0xC7C360", VA = "0x180C7DB60")]
		public RuntimeFnDeps(IntPtr getUnmanagedRegisterPointer, IntPtr getManagedRegisterPointer, IntPtr getUnmanagedRegisters, IntPtr getManagedRegisters, IntPtr setUnmanagedRegisterPointer, IntPtr setManagedRegisterPointer, IntPtr getDynamicDeps, IntPtr setDataDeadEnd, IntPtr setExecDeadEnd)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x28CA800", Offset = "0x28C9000", VA = "0x1828CA800")]
		public Id32<NWXWONCHIFS> VLRLSHHJKRS(IntPtr a)
		{
			return default(Id32<NWXWONCHIFS>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x28CAF80", Offset = "0x28C9780", VA = "0x1828CAF80")]
		public IdArray<NWXWONCHIFS, object> EQZMAWIHOUM(IntPtr a)
		{
			return default(IdArray<NWXWONCHIFS, object>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x28CAFA0", Offset = "0x28C97A0", VA = "0x1828CAFA0")]
		public void SXNKNODBZQM(IntPtr a, Id32<NWXWONCHIFS> value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x3A30420", Offset = "0x3A2EC20", VA = "0x183A30420")]
		public TDeps PSVXIZTFXYM<TDeps>(IntPtr a) where TDeps : notnull
		{
			return (TDeps)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x28CAF60", Offset = "0x28C9760", VA = "0x1828CAF60")]
		public void AMVQGNIYPAU(IntPtr a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x28CAFC0", Offset = "0x28C97C0", VA = "0x1828CAFC0")]
		public void ZVNNDOZOCOH(IntPtr a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public struct RuntimeFnRegistryFactory
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private IdUnsafeList<PBOKRPYDFLU, RuntimeFnDelegate> _runtimeDefs;

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x102F760", Offset = "0x102DF60", VA = "0x18102F760")]
		private RuntimeFnRegistryFactory([In] IdUnsafeList<PBOKRPYDFLU, RuntimeFnDelegate> runtimeDefs)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x28CB030", Offset = "0x28C9830", VA = "0x1828CB030")]
		public static RuntimeFnRegistryFactory CYOPTWCDXLK()
		{
			return default(RuntimeFnRegistryFactory);
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x28CAFE0", Offset = "0x28C97E0", VA = "0x1828CAFE0")]
		public RuntimeFns AXHFTEUJRLO()
		{
			return default(RuntimeFns);
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x28CB090", Offset = "0x28C9890", VA = "0x1828CB090")]
		public void ZQXFTROHYPR(Id32<PBOKRPYDFLU> runtimeFnId, IntPtr a)
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
		private readonly ReadOnlyIdArray<PBOKRPYDFLU, RuntimeFnDelegate> _impl;

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x28829D0", Offset = "0x28811D0", VA = "0x1828829D0")]
		internal RuntimeFns(ReadOnlyIdArray<PBOKRPYDFLU, RuntimeFnDelegate> impl)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x28CB150", Offset = "0x28C9950", VA = "0x1828CB150")]
		public RuntimeFnDelegate Get(Id32<PBOKRPYDFLU> runtimeFnId)
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
