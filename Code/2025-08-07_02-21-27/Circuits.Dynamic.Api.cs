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
		[Cpp2IlInjected.Address(RVA = "0xB3E190", Offset = "0xB3CD90", VA = "0x180B3E190")]
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
		[Cpp2IlInjected.Address(RVA = "0xB3E190", Offset = "0xB3CD90", VA = "0x180B3E190")]
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
		[Cpp2IlInjected.Address(RVA = "0x2DBFD80", Offset = "0x2DBE980", VA = "0x182DBFD80")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xB3EE00", Offset = "0xB3DA00", VA = "0x180B3EE00")]
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
		[Cpp2IlInjected.Address(RVA = "0xB3EE40", Offset = "0xB3DA40", VA = "0x180B3EE40")]
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
		[Cpp2IlInjected.Address(RVA = "0x167A4A0", Offset = "0x16790A0", VA = "0x18167A4A0")]
		private CircuitsBool(int value)
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x15D8AB0", Offset = "0x15D76B0", VA = "0x1815D8AB0")]
		public static bool UIBWLZUGNWE(CircuitsBool a)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x2DBF500", Offset = "0x2DBE100", VA = "0x182DBF500")]
		public static CircuitsBool UIBWLZUGNWE(bool a)
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
		public readonly Id32<UCWLUIIGNGH> DefId;

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x2DBF770", Offset = "0x2DBE370", VA = "0x182DBF770")]
		public DynamicCircuitsErr(IntPtr ptr, Id32<UCWLUIIGNGH> defId)
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
		[Cpp2IlInjected.Address(RVA = "0x2167760", Offset = "0x2166360", VA = "0x182167760")]
		public DynamicCircuitsErrDef(IntPtr destroy, IntPtr toDebugString, IntPtr toDisplayString)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x2DBF510", Offset = "0x2DBE110", VA = "0x182DBF510")]
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
		private readonly ReadOnlyIdArray<UCWLUIIGNGH, DynamicCircuitsErrDef> _impl;

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x2D841D0", Offset = "0x2D82DD0", VA = "0x182D841D0")]
		internal DynamicCircuitsErrDefs(ReadOnlyIdArray<UCWLUIIGNGH, DynamicCircuitsErrDef> impl)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x2DBF520", Offset = "0x2DBE120", VA = "0x182DBF520")]
		public DynamicCircuitsErrDef Get(Id32<UCWLUIIGNGH> dynamicCircuitsErrDefId)
		{
			return default(DynamicCircuitsErrDef);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public struct DynamicCircuitsErrRegistryFactory
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private IdUnsafeList<UCWLUIIGNGH, DynamicCircuitsErrDef> _dynamicCircuitsErrDefs;

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x13722D0", Offset = "0x1370ED0", VA = "0x1813722D0")]
		private DynamicCircuitsErrRegistryFactory([In] IdUnsafeList<UCWLUIIGNGH, DynamicCircuitsErrDef> dynamicCircuitsErrDefs)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x2DBF5F0", Offset = "0x2DBE1F0", VA = "0x182DBF5F0")]
		public static DynamicCircuitsErrRegistryFactory Begin()
		{
			return default(DynamicCircuitsErrRegistryFactory);
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x2DBF650", Offset = "0x2DBE250", VA = "0x182DBF650")]
		public DynamicCircuitsErrDefs End()
		{
			return default(DynamicCircuitsErrDefs);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x2DBF6A0", Offset = "0x2DBE2A0", VA = "0x182DBF6A0")]
		public void SKEOYPQILPE(Id32<UCWLUIIGNGH> dynamicCircuitsErrDefId, [In] DynamicCircuitsErrDef dynamicCircuitsErrDef)
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
		[Cpp2IlInjected.Address(RVA = "0xF290B0", Offset = "0xF27CB0", VA = "0x180F290B0")]
		public ExternalFnDelegate(IntPtr functionPointer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x2DBF780", Offset = "0x2DBE380", VA = "0x182DBF780")]
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
		[Cpp2IlInjected.Address(RVA = "0x2167760", Offset = "0x2166360", VA = "0x182167760")]
		public ExternalFnDeps(IntPtr getExternalFnIODeps, IntPtr getDynamicDeps, IntPtr getExecParams)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x2DBF7C0", Offset = "0x2DBE3C0", VA = "0x182DBF7C0")]
		internal ExternalFnIODeps DOLMBBYDNDY(IntPtr a)
		{
			return default(ExternalFnIODeps);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x2DBF820", Offset = "0x2DBE420", VA = "0x182DBF820")]
		internal IntPtr ZMHXYAIBMNI(IntPtr a)
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x2DBF800", Offset = "0x2DBE400", VA = "0x182DBF800")]
		internal ABZCVUHNAYT LVIOVIBSVSQ(IntPtr a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public static class GZJZYCJRUKH
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x2DBFC00", Offset = "0x2DBE800", VA = "0x182DBFC00")]
		public static void BJBRKQIIZZU([In] this ExternalFnDeps deps, IntPtr a, [Out] ExternalFnIO b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x2DBFB10", Offset = "0x2DBE710", VA = "0x182DBFB10")]
		public static void BJBRKQIIZZU([In] this ExternalFnDeps deps, IntPtr a, [Out] ExternalFnIO b, [Out] ABZCVUHNAYT c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x3BCA7B0", Offset = "0x3BC93B0", VA = "0x183BCA7B0")]
		public static TDeps BJBRKQIIZZU<TDeps>([In] this ExternalFnDeps deps, IntPtr a, [Out] ExternalFnIO b) where TDeps : notnull
		{
			return (TDeps)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x3BCA590", Offset = "0x3BC9190", VA = "0x183BCA590")]
		public static TDeps BJBRKQIIZZU<TDeps>([In] this ExternalFnDeps deps, IntPtr a, [Out] ExternalFnIO b, [Out] ABZCVUHNAYT c) where TDeps : notnull
		{
			return (TDeps)null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public struct ExternalFnIO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		internal Id32<NZMKZPVTOGO<PCOBNQTLDEG>> _UnmanagedArgPtr;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		internal Id32<NZMKZPVTOGO<PCOBNQTLDEG>> _UnmanagedReturnPtr;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		internal Id32<DGVAYPZQLZQ> _ManagedArgPtr;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		internal Id32<DGVAYPZQLZQ> _ManagedReturnPtr;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		internal IdArray<NZMKZPVTOGO<PCOBNQTLDEG>, byte> _UnmanagedRegisters;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		internal IdArray<DGVAYPZQLZQ, object?> _ManagedRegisters;

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x2DBF880", Offset = "0x2DBE480", VA = "0x182DBF880")]
		internal ExternalFnIO(Id32<NZMKZPVTOGO<PCOBNQTLDEG>> unmanagedArgPtr, Id32<NZMKZPVTOGO<PCOBNQTLDEG>> unmanagedReturnPtr, Id32<DGVAYPZQLZQ> managedArgPtr, Id32<DGVAYPZQLZQ> managedReturnPtr, IdArray<NZMKZPVTOGO<PCOBNQTLDEG>, byte> unmanagedRegisters, IdArray<DGVAYPZQLZQ, object?> managedRegisters)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public static class UKSHZXDOMIU
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x2DC00E0", Offset = "0x2DBECE0", VA = "0x182DC00E0")]
		public static ReadOnlySpan<byte> In(this ExternalFnIO self, int size)
		{
			return default(ReadOnlySpan<byte>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public static class CLCOAYVWKTQ
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x39AB710", Offset = "0x39AA310", VA = "0x1839AB710")]
		public static T In<T>(this ExternalFnIO self) where T : struct
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x39ABF80", Offset = "0x39AAB80", VA = "0x1839ABF80")]
		public static void Out<T>(this ExternalFnIO self, T value) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x2DBF430", Offset = "0x2DBE030", VA = "0x182DBF430")]
		public static void Out(this ExternalFnIO self, bool value)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public static class RROGITRTEFD
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x3FB4040", Offset = "0x3FB2C40", VA = "0x183FB4040")]
		public static T In<T>(this ExternalFnIO self) where T : class
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x3FB4130", Offset = "0x3FB2D30", VA = "0x183FB4130")]
		public static void Out<T>(this ExternalFnIO self, T value) where T : class
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public struct ExternalFnIODeps
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		internal readonly Id32<NZMKZPVTOGO<PCOBNQTLDEG>> _UnmanagedRegisterPointer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		internal readonly Id32<DGVAYPZQLZQ> _ManagedRegisterPointer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		internal IdArray<NZMKZPVTOGO<PCOBNQTLDEG>, byte> _UnmanagedRegisters;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		internal IdArray<DGVAYPZQLZQ, object?> _ManagedRegisters;

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x2DBF840", Offset = "0x2DBE440", VA = "0x182DBF840")]
		public ExternalFnIODeps(Id32<NZMKZPVTOGO<PCOBNQTLDEG>> unmanagedRegisterPointer, Id32<DGVAYPZQLZQ> managedRegisterPointer, IdArray<NZMKZPVTOGO<PCOBNQTLDEG>, byte> unmanagedRegisters, IdArray<DGVAYPZQLZQ, object?> managedRegisters)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public struct ExternalFnRegistryFactory
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private IdUnsafeList<KQWRYFZVYKT, ExternalFnDelegate> _externalDefs;

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x13722D0", Offset = "0x1370ED0", VA = "0x1813722D0")]
		private ExternalFnRegistryFactory([In] IdUnsafeList<KQWRYFZVYKT, ExternalFnDelegate> externalDefs)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x2DBF8D0", Offset = "0x2DBE4D0", VA = "0x182DBF8D0")]
		public static ExternalFnRegistryFactory Begin()
		{
			return default(ExternalFnRegistryFactory);
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x2DBF930", Offset = "0x2DBE530", VA = "0x182DBF930")]
		public ExternalFns End()
		{
			return default(ExternalFns);
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x2DBF980", Offset = "0x2DBE580", VA = "0x182DBF980")]
		public void MSSERNDSQSQ(Id32<KQWRYFZVYKT> externalFnId, IntPtr a)
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
		private readonly ReadOnlyIdArray<KQWRYFZVYKT, ExternalFnDelegate> _impl;

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x2D841D0", Offset = "0x2D82DD0", VA = "0x182D841D0")]
		internal ExternalFns(ReadOnlyIdArray<KQWRYFZVYKT, ExternalFnDelegate> impl)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x2DBFA40", Offset = "0x2DBE640", VA = "0x182DBFA40")]
		public ExternalFnDelegate Get(Id32<KQWRYFZVYKT> externalFnId)
		{
			return default(ExternalFnDelegate);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public interface ABZCVUHNAYT
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		LegacyCV2Result<None> TWVZLRNQMZJ(int a);

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		LegacyCV2Result<None> GIDATWNZUVI(int a, bool b = true);

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(Slot = "2")]
		bool MCFIPKYHKMJ(int a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public interface QODCMTMTBAJ
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public readonly struct LegacyCV2Result<T> : IEnumerable<T>, IEnumerable
	{
		[Cpp2IlInjected.Token(Token = "0x2000018")]
		private sealed class FGPXOXJLAER<b> : IEnumerator<b>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001F")]
			private readonly LegacyCV2Result<b> DPYMPPUTDRZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000020")]
			private bool GVGLLYNKLVM;

			[Cpp2IlInjected.Token(Token = "0x17000001")]
			public b Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000037")]
				[Cpp2IlInjected.Address(RVA = "0x52F6BC0", Offset = "0x52F57C0", VA = "0x1852F6BC0", Slot = "4")]
				get
				{
					return (b)null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000002")]
			private object APIHCGBOWUL
			{
				[Cpp2IlInjected.Token(Token = "0x6000038")]
				[Cpp2IlInjected.Address(RVA = "0x52F6100", Offset = "0x52F4D00", VA = "0x1852F6100", Slot = "7")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x52F6770", Offset = "0x52F5370", VA = "0x1852F6770")]
			public FGPXOXJLAER([In] LegacyCV2Result<b> result)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0xB167F0", Offset = "0xB153F0", VA = "0x180B167F0", Slot = "5")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x52F6670", Offset = "0x52F5270", VA = "0x1852F6670", Slot = "6")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x52F6720", Offset = "0x52F5320", VA = "0x1852F6720", Slot = "8")]
			public void Reset()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public readonly QODCMTMTBAJ err;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public readonly T ok;

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x59FD9A0", Offset = "0x59FC5A0", VA = "0x1859FD9A0")]
		private LegacyCV2Result(QODCMTMTBAJ err, [In] T ok)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x59FD2E0", Offset = "0x59FBEE0", VA = "0x1859FD2E0")]
		public static LegacyCV2Result<T> UTITDXZLKVK(QODCMTMTBAJ a)
		{
			return default(LegacyCV2Result<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x59FBD30", Offset = "0x59FA930", VA = "0x1859FBD30")]
		public static LegacyCV2Result<T> Ok([In] T ok)
		{
			return default(LegacyCV2Result<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x41A7D40", Offset = "0x41A6940", VA = "0x1841A7D40")]
		public LegacyCV2Result<a?> ZKVELOCVFBL<a>()
		{
			return default(LegacyCV2Result<a>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x59FB220", Offset = "0x59F9E20", VA = "0x1859FB220")]
		public LegacyCV2Result<None> AMMIGXBAMAU()
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x59FBAB0", Offset = "0x59FA6B0", VA = "0x1859FBAB0", Slot = "4")]
		public IEnumerator<T> GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x59FD770", Offset = "0x59FC370", VA = "0x1859FD770", Slot = "5")]
		private IEnumerator ZFHLTDQPCLO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x59FC1D0", Offset = "0x59FADD0", VA = "0x1859FC1D0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public static class LRZVQEVFHVE
	{
		[Cpp2IlInjected.Token(Token = "0x200001A")]
		public delegate U RefMapOp<T, U, Args>([In] T ok, [In] Args args);

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x3CB7C10", Offset = "0x3CB6810", VA = "0x183CB7C10")]
		public static LegacyCV2Result<T> UTITDXZLKVK<T>(QODCMTMTBAJ a) where T : notnull
		{
			return default(LegacyCV2Result<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x2DBFD20", Offset = "0x2DBE920", VA = "0x182DBFD20")]
		public static LegacyCV2Result<None> UTITDXZLKVK(QODCMTMTBAJ err)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x3CB6D40", Offset = "0x3CB5940", VA = "0x183CB6D40")]
		public static LegacyCV2Result<T> Ok<T>([In] T ok) where T : notnull
		{
			return default(LegacyCV2Result<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x2DBFCC0", Offset = "0x2DBE8C0", VA = "0x182DBFCC0")]
		public static LegacyCV2Result<None> Ok()
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x3CB69E0", Offset = "0x3CB55E0", VA = "0x183CB69E0")]
		public static bool MLMNYRZYGNV<a>([In] this LegacyCV2Result<a> self)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x1D66F90", Offset = "0x1D65B90", VA = "0x181D66F90")]
		public static bool OJPHJDEUCMM<b>([In] this LegacyCV2Result<b> self)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x3CB68A0", Offset = "0x3CB54A0", VA = "0x183CB68A0")]
		public static LegacyCV2Result<i?> LKVFVCMQHVY<i, h>([In] this LegacyCV2Result<h> self, [In] LegacyCV2Result<i> ok)
		{
			return default(LegacyCV2Result<i>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x3CB65F0", Offset = "0x3CB51F0", VA = "0x183CB65F0")]
		public static LegacyCV2Result<m?> LFDZIKICXHH<m, l, n>([In] this LegacyCV2Result<l> self, [In] n args, RefMapOp<l, LegacyCV2Result<m>, n> ok)
		{
			return default(LegacyCV2Result<m>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x3CB6070", Offset = "0x3CB4C70", VA = "0x183CB6070")]
		public static T HTKADWIEEMG<T>([In] this LegacyCV2Result<T> self) where T : notnull
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x3CB7650", Offset = "0x3CB6250", VA = "0x183CB7650")]
		public static bool Try<T>([In] this LegacyCV2Result<T> self, [Out] LegacyCV2Result<T> res)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x3CB5C10", Offset = "0x3CB4810", VA = "0x183CB5C10")]
		public static bool HHAVBMAAPKK<T>([In] this LegacyCV2Result<T> self, [Out] T a, [Out] LegacyCV2Result<T> res) where T : notnull
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x3CB7F70", Offset = "0x3CB6B70", VA = "0x183CB7F70")]
		public static bool VIXAYDFFPZX<T>([In] this LegacyCV2Result<T> self, [Out] T ok, [Out] LegacyCV2Result<None> a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x3CB57E0", Offset = "0x3CB43E0", VA = "0x183CB57E0")]
		public static bool GPCBLQUTKJX<r, s>([In] this LegacyCV2Result<r> self, [Out] s a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x3CB7260", Offset = "0x3CB5E60", VA = "0x183CB7260")]
		public static LegacyCV2Result<t?> TALGTLBWJYF<t>([In] this LegacyCV2Result<LegacyCV2Result<t>> self)
		{
			return default(LegacyCV2Result<t>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public sealed class UCWLUIIGNGH
	{
	}
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public readonly struct RuntimeFnDelegate
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private readonly IntPtr _functionPointer;

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0xF290B0", Offset = "0xF27CB0", VA = "0x180F290B0")]
		public RuntimeFnDelegate(IntPtr functionPointer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x2DBFE00", Offset = "0x2DBEA00", VA = "0x182DBFE00")]
		public void Invoke([In] RuntimeFnDeps deps, IntPtr ctx, [In] ReadOnlySpan<byte> data)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001D")]
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

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0xF7B300", Offset = "0xF79F00", VA = "0x180F7B300")]
		public RuntimeFnDeps(IntPtr getUnmanagedRegisterPointer, IntPtr getManagedRegisterPointer, IntPtr getUnmanagedRegisters, IntPtr getManagedRegisters, IntPtr setUnmanagedRegisterPointer, IntPtr setManagedRegisterPointer, IntPtr getDynamicDeps, IntPtr setDataDeadEnd, IntPtr setExecDeadEnd)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x2DBF820", Offset = "0x2DBE420", VA = "0x182DBF820")]
		public Id32<DGVAYPZQLZQ> NBEZMDUPDQO(IntPtr a)
		{
			return default(Id32<DGVAYPZQLZQ>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x2DBFE20", Offset = "0x2DBEA20", VA = "0x182DBFE20")]
		public IdArray<DGVAYPZQLZQ, object> CGLBRUDSURQ(IntPtr a)
		{
			return default(IdArray<DGVAYPZQLZQ, object>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x2DBFE40", Offset = "0x2DBEA40", VA = "0x182DBFE40")]
		public void MKGBXHNHZXU(IntPtr a, Id32<DGVAYPZQLZQ> value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x3FE6040", Offset = "0x3FE4C40", VA = "0x183FE6040")]
		public TDeps ZMHXYAIBMNI<TDeps>(IntPtr a) where TDeps : notnull
		{
			return (TDeps)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x2DBFE60", Offset = "0x2DBEA60", VA = "0x182DBFE60")]
		public void UXLRPKZMBXI(IntPtr a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x2DBFE80", Offset = "0x2DBEA80", VA = "0x182DBFE80")]
		public void ZQLWVRGABXP(IntPtr a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public struct RuntimeFnRegistryFactory
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private IdUnsafeList<GEBYEJADWWU, RuntimeFnDelegate> _runtimeDefs;

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x13722D0", Offset = "0x1370ED0", VA = "0x1813722D0")]
		private RuntimeFnRegistryFactory([In] IdUnsafeList<GEBYEJADWWU, RuntimeFnDelegate> runtimeDefs)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x2DBFEA0", Offset = "0x2DBEAA0", VA = "0x182DBFEA0")]
		public static RuntimeFnRegistryFactory Begin()
		{
			return default(RuntimeFnRegistryFactory);
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x2DBFF00", Offset = "0x2DBEB00", VA = "0x182DBFF00")]
		public RuntimeFns End()
		{
			return default(RuntimeFns);
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x2DBFF50", Offset = "0x2DBEB50", VA = "0x182DBFF50")]
		public void KZVCVMDFXVP(Id32<GEBYEJADWWU> runtimeFnId, IntPtr a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public readonly struct RuntimeFns
	{
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		public static readonly RuntimeFns Empty;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private readonly ReadOnlyIdArray<GEBYEJADWWU, RuntimeFnDelegate> _impl;

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x2D841D0", Offset = "0x2D82DD0", VA = "0x182D841D0")]
		internal RuntimeFns(ReadOnlyIdArray<GEBYEJADWWU, RuntimeFnDelegate> impl)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x2DC0010", Offset = "0x2DBEC10", VA = "0x182DC0010")]
		public RuntimeFnDelegate Get(Id32<GEBYEJADWWU> runtimeFnId)
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
