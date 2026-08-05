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
		[Cpp2IlInjected.Address(RVA = "0xD1E1A0", Offset = "0xD1D5A0", VA = "0x180D1E1A0")]
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
		[Cpp2IlInjected.Address(RVA = "0xD1E1A0", Offset = "0xD1D5A0", VA = "0x180D1E1A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x2B6ACA0", Offset = "0x2B6A0A0", VA = "0x182B6ACA0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xD1EA70", Offset = "0xD1DE70", VA = "0x180D1EA70")]
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
		[Cpp2IlInjected.Address(RVA = "0xD1EAB0", Offset = "0xD1DEB0", VA = "0x180D1EAB0")]
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
		[Cpp2IlInjected.Address(RVA = "0x15C4A60", Offset = "0x15C3E60", VA = "0x1815C4A60")]
		private CircuitsBool(int value)
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x1542690", Offset = "0x1541A90", VA = "0x181542690")]
		public static bool WQHQWYPMLDD(CircuitsBool a)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x2B6A480", Offset = "0x2B69880", VA = "0x182B6A480")]
		public static CircuitsBool WQHQWYPMLDD(bool a)
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
		public readonly Id32<YLFQBSKWGYE> DefId;

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x2B6A840", Offset = "0x2B69C40", VA = "0x182B6A840")]
		public DynamicCircuitsErr(IntPtr ptr, Id32<YLFQBSKWGYE> defId)
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
		[Cpp2IlInjected.Address(RVA = "0x1F2B580", Offset = "0x1F2A980", VA = "0x181F2B580")]
		public DynamicCircuitsErrDef(IntPtr destroy, IntPtr toDebugString, IntPtr toDisplayString)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x2B6A5E0", Offset = "0x2B699E0", VA = "0x182B6A5E0")]
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
		private readonly ReadOnlyIdArray<YLFQBSKWGYE, DynamicCircuitsErrDef> _impl;

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x2B22620", Offset = "0x2B21A20", VA = "0x182B22620")]
		internal DynamicCircuitsErrDefs(ReadOnlyIdArray<YLFQBSKWGYE, DynamicCircuitsErrDef> impl)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x2B6A5F0", Offset = "0x2B699F0", VA = "0x182B6A5F0")]
		public DynamicCircuitsErrDef Get(Id32<YLFQBSKWGYE> dynamicCircuitsErrDefId)
		{
			return default(DynamicCircuitsErrDef);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public struct DynamicCircuitsErrRegistryFactory
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private IdUnsafeList<YLFQBSKWGYE, DynamicCircuitsErrDef> _dynamicCircuitsErrDefs;

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x12C9430", Offset = "0x12C8830", VA = "0x1812C9430")]
		private DynamicCircuitsErrRegistryFactory([In] IdUnsafeList<YLFQBSKWGYE, DynamicCircuitsErrDef> dynamicCircuitsErrDefs)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x2B6A6C0", Offset = "0x2B69AC0", VA = "0x182B6A6C0")]
		public static DynamicCircuitsErrRegistryFactory GYMJYDCNRDR()
		{
			return default(DynamicCircuitsErrRegistryFactory);
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x2B6A720", Offset = "0x2B69B20", VA = "0x182B6A720")]
		public DynamicCircuitsErrDefs ISHNKJMJOID()
		{
			return default(DynamicCircuitsErrDefs);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x2B6A770", Offset = "0x2B69B70", VA = "0x182B6A770")]
		public void LVCNHKUJJMJ(Id32<YLFQBSKWGYE> dynamicCircuitsErrDefId, [In] DynamicCircuitsErrDef dynamicCircuitsErrDef)
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
		[Cpp2IlInjected.Address(RVA = "0xED9440", Offset = "0xED8840", VA = "0x180ED9440")]
		public ExternalFnDelegate(IntPtr functionPointer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x2B6A850", Offset = "0x2B69C50", VA = "0x182B6A850")]
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
		[Cpp2IlInjected.Address(RVA = "0x1F2B580", Offset = "0x1F2A980", VA = "0x181F2B580")]
		public ExternalFnDeps(IntPtr getExternalFnIODeps, IntPtr getDynamicDeps, IntPtr getExecParams)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x2B6A8D0", Offset = "0x2B69CD0", VA = "0x182B6A8D0")]
		internal ExternalFnIODeps VRPCQCGKNOX(IntPtr a)
		{
			return default(ExternalFnIODeps);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x2B6A8B0", Offset = "0x2B69CB0", VA = "0x182B6A8B0")]
		internal IntPtr IQISOILYICR(IntPtr a)
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x2B6A890", Offset = "0x2B69C90", VA = "0x182B6A890")]
		internal GOCFXIZVABA HVMNVAAIDDD(IntPtr a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public static class CCLKSAJRWVQ
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x2B6A2D0", Offset = "0x2B696D0", VA = "0x182B6A2D0")]
		public static void OWKLQDTDHDV([In] this ExternalFnDeps deps, IntPtr a, [Out] ExternalFnIO b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x2B6A390", Offset = "0x2B69790", VA = "0x182B6A390")]
		public static void OWKLQDTDHDV([In] this ExternalFnDeps deps, IntPtr a, [Out] ExternalFnIO b, [Out] GOCFXIZVABA c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x37D2310", Offset = "0x37D1710", VA = "0x1837D2310")]
		public static TDeps OWKLQDTDHDV<TDeps>([In] this ExternalFnDeps deps, IntPtr a, [Out] ExternalFnIO b) where TDeps : notnull
		{
			return (TDeps)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x37D20F0", Offset = "0x37D14F0", VA = "0x1837D20F0")]
		public static TDeps OWKLQDTDHDV<TDeps>([In] this ExternalFnDeps deps, IntPtr a, [Out] ExternalFnIO b, [Out] GOCFXIZVABA c) where TDeps : notnull
		{
			return (TDeps)null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public struct ExternalFnIO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		internal Id32<WHMLTPZNLLH<JPZFXDVMDNP>> _UnmanagedArgPtr;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		internal Id32<WHMLTPZNLLH<JPZFXDVMDNP>> _UnmanagedReturnPtr;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		internal Id32<YVGHOMRCUTJ> _ManagedArgPtr;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		internal Id32<YVGHOMRCUTJ> _ManagedReturnPtr;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		internal IdArray<WHMLTPZNLLH<JPZFXDVMDNP>, byte> _UnmanagedRegisters;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		internal IdArray<YVGHOMRCUTJ, object?> _ManagedRegisters;

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x2B6A950", Offset = "0x2B69D50", VA = "0x182B6A950")]
		internal ExternalFnIO(Id32<WHMLTPZNLLH<JPZFXDVMDNP>> unmanagedArgPtr, Id32<WHMLTPZNLLH<JPZFXDVMDNP>> unmanagedReturnPtr, Id32<YVGHOMRCUTJ> managedArgPtr, Id32<YVGHOMRCUTJ> managedReturnPtr, IdArray<WHMLTPZNLLH<JPZFXDVMDNP>, byte> unmanagedRegisters, IdArray<YVGHOMRCUTJ, object?> managedRegisters)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public static class DZPDDAFPZHJ
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x2B6A490", Offset = "0x2B69890", VA = "0x182B6A490")]
		public static ReadOnlySpan<byte> In(this ExternalFnIO self, int size)
		{
			return default(ReadOnlySpan<byte>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public static class YECHSEBHMIH
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x411A830", Offset = "0x4119C30", VA = "0x18411A830")]
		public static T In<T>(this ExternalFnIO self) where T : struct
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x411B0A0", Offset = "0x411A4A0", VA = "0x18411B0A0")]
		public static void Out<T>(this ExternalFnIO self, T value) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x2B6B000", Offset = "0x2B6A400", VA = "0x182B6B000")]
		public static void Out(this ExternalFnIO self, bool value)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public static class PYLCTYASTPU
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x3D594C0", Offset = "0x3D588C0", VA = "0x183D594C0")]
		public static T In<T>(this ExternalFnIO self) where T : class
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x3D595B0", Offset = "0x3D589B0", VA = "0x183D595B0")]
		public static void Out<T>(this ExternalFnIO self, T value) where T : class
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public struct ExternalFnIODeps
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		internal readonly Id32<WHMLTPZNLLH<JPZFXDVMDNP>> _UnmanagedRegisterPointer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		internal readonly Id32<YVGHOMRCUTJ> _ManagedRegisterPointer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		internal IdArray<WHMLTPZNLLH<JPZFXDVMDNP>, byte> _UnmanagedRegisters;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		internal IdArray<YVGHOMRCUTJ, object?> _ManagedRegisters;

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x2B6A910", Offset = "0x2B69D10", VA = "0x182B6A910")]
		public ExternalFnIODeps(Id32<WHMLTPZNLLH<JPZFXDVMDNP>> unmanagedRegisterPointer, Id32<YVGHOMRCUTJ> managedRegisterPointer, IdArray<WHMLTPZNLLH<JPZFXDVMDNP>, byte> unmanagedRegisters, IdArray<YVGHOMRCUTJ, object?> managedRegisters)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public struct ExternalFnRegistryFactory
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private IdUnsafeList<KXFBWSJODNE, ExternalFnDelegate> _externalDefs;

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x12C9430", Offset = "0x12C8830", VA = "0x1812C9430")]
		private ExternalFnRegistryFactory([In] IdUnsafeList<KXFBWSJODNE, ExternalFnDelegate> externalDefs)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x2B6AA60", Offset = "0x2B69E60", VA = "0x182B6AA60")]
		public static ExternalFnRegistryFactory GYMJYDCNRDR()
		{
			return default(ExternalFnRegistryFactory);
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x2B6AAC0", Offset = "0x2B69EC0", VA = "0x182B6AAC0")]
		public ExternalFns ISHNKJMJOID()
		{
			return default(ExternalFns);
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x2B6A9A0", Offset = "0x2B69DA0", VA = "0x182B6A9A0")]
		public void EAVCHGGUIZT(Id32<KXFBWSJODNE> externalFnId, IntPtr a)
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
		private readonly ReadOnlyIdArray<KXFBWSJODNE, ExternalFnDelegate> _impl;

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x2B22620", Offset = "0x2B21A20", VA = "0x182B22620")]
		internal ExternalFns(ReadOnlyIdArray<KXFBWSJODNE, ExternalFnDelegate> impl)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x2B6AB10", Offset = "0x2B69F10", VA = "0x182B6AB10")]
		public ExternalFnDelegate Get(Id32<KXFBWSJODNE> externalFnId)
		{
			return default(ExternalFnDelegate);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public interface OJDDANHBPRY
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void LVGDTBRWPPO();
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public interface GOCFXIZVABA
	{
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		LegacyCV2Result<None> FBEDENTADPE(int a);

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		LegacyCV2Result<None> EUPPFPKKNHP(int a, bool b = true);

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(Slot = "2")]
		bool TEJSJXHHZZG(int a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public interface WSAWTNIADHO
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public readonly struct LegacyCV2Result<T> : IEnumerable<T>, IEnumerable
	{
		[Cpp2IlInjected.Token(Token = "0x2000019")]
		private sealed class NCYXAXFNHLE<b> : IEnumerator<b>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001F")]
			private readonly LegacyCV2Result<b> IHOPIKNJEFY;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000020")]
			private bool KIPZHNTAFJH;

			[Cpp2IlInjected.Token(Token = "0x17000001")]
			public b Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000038")]
				[Cpp2IlInjected.Address(RVA = "0x71BBC20", Offset = "0x71BB020", VA = "0x1871BBC20", Slot = "4")]
				get
				{
					return (b)null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000002")]
			private object ERGKPVHJUQY
			{
				[Cpp2IlInjected.Token(Token = "0x6000039")]
				[Cpp2IlInjected.Address(RVA = "0x71BB500", Offset = "0x71BA900", VA = "0x1871BB500", Slot = "7")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x71BB810", Offset = "0x71BAC10", VA = "0x1871BB810")]
			public NCYXAXFNHLE([In] LegacyCV2Result<b> result)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0xCF4190", Offset = "0xCF3590", VA = "0x180CF4190", Slot = "5")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x71BB410", Offset = "0x71BA810", VA = "0x1871BB410", Slot = "6")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x71BB7C0", Offset = "0x71BABC0", VA = "0x1871BB7C0", Slot = "8")]
			public void Reset()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public readonly WSAWTNIADHO err;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public readonly T ok;

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x69988F0", Offset = "0x6997CF0", VA = "0x1869988F0")]
		private LegacyCV2Result(WSAWTNIADHO err, [In] T ok)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x69969F0", Offset = "0x6995DF0", VA = "0x1869969F0")]
		public static LegacyCV2Result<T> OKJLNQTBITD(WSAWTNIADHO a)
		{
			return default(LegacyCV2Result<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x6996F20", Offset = "0x6996320", VA = "0x186996F20")]
		public static LegacyCV2Result<T> Ok([In] T ok)
		{
			return default(LegacyCV2Result<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x3994120", Offset = "0x3993520", VA = "0x183994120")]
		public LegacyCV2Result<a?> SFETEGWOKWA<a>()
		{
			return default(LegacyCV2Result<a>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x6995FA0", Offset = "0x69953A0", VA = "0x186995FA0")]
		public LegacyCV2Result<None> MCDCTTSNYRB()
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x6995640", Offset = "0x6994A40", VA = "0x186995640", Slot = "4")]
		public IEnumerator<T> GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x69973A0", Offset = "0x69967A0", VA = "0x1869973A0", Slot = "5")]
		private IEnumerator SJAOULXGYMP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x6997610", Offset = "0x6996A10", VA = "0x186997610", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public static class LVAUEQEEBTB
	{
		[Cpp2IlInjected.Token(Token = "0x200001B")]
		public delegate U RefMapOp<T, U, Args>([In] T ok, [In] Args args);

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x3BD0BD0", Offset = "0x3BCFFD0", VA = "0x183BD0BD0")]
		public static LegacyCV2Result<T> OKJLNQTBITD<T>(WSAWTNIADHO a) where T : notnull
		{
			return default(LegacyCV2Result<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x2B6ABE0", Offset = "0x2B69FE0", VA = "0x182B6ABE0")]
		public static LegacyCV2Result<None> OKJLNQTBITD(WSAWTNIADHO err)
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x3BD12B0", Offset = "0x3BD06B0", VA = "0x183BD12B0")]
		public static LegacyCV2Result<T> Ok<T>([In] T ok) where T : notnull
		{
			return default(LegacyCV2Result<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x2B6AC40", Offset = "0x2B6A040", VA = "0x182B6AC40")]
		public static LegacyCV2Result<None> Ok()
		{
			return default(LegacyCV2Result<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x3AD5C00", Offset = "0x3AD5000", VA = "0x183AD5C00")]
		public static bool FSSWGUFHNOE<a>([In] this LegacyCV2Result<a> self)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x1A923A0", Offset = "0x1A917A0", VA = "0x181A923A0")]
		public static bool UYGNOBIHAPP<b>([In] this LegacyCV2Result<b> self)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x3BCFC80", Offset = "0x3BCF080", VA = "0x183BCFC80")]
		public static LegacyCV2Result<i?> BESRWMDVBOX<i, h>([In] this LegacyCV2Result<h> self, [In] LegacyCV2Result<i> ok)
		{
			return default(LegacyCV2Result<i>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x3BD0770", Offset = "0x3BCFB70", VA = "0x183BD0770")]
		public static LegacyCV2Result<m?> OGZOVWUUGRK<m, l, n>([In] this LegacyCV2Result<l> self, [In] n args, RefMapOp<l, LegacyCV2Result<m>, n> ok)
		{
			return default(LegacyCV2Result<m>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x3BD1C70", Offset = "0x3BD1070", VA = "0x183BD1C70")]
		public static T WDLEIAVLNSF<T>([In] this LegacyCV2Result<T> self) where T : notnull
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x3BD1860", Offset = "0x3BD0C60", VA = "0x183BD1860")]
		public static bool Try<T>([In] this LegacyCV2Result<T> self, [Out] LegacyCV2Result<T> res)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x3BD2620", Offset = "0x3BD1A20", VA = "0x183BD2620")]
		public static bool YSUOHJHYAIZ<T>([In] this LegacyCV2Result<T> self, [Out] T a, [Out] LegacyCV2Result<T> res) where T : notnull
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x3BCFFE0", Offset = "0x3BCF3E0", VA = "0x183BCFFE0")]
		public static bool DTADZIDAQYM<T>([In] this LegacyCV2Result<T> self, [Out] T ok, [Out] LegacyCV2Result<None> a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x3BCFDC0", Offset = "0x3BCF1C0", VA = "0x183BCFDC0")]
		public static bool CWIEXVHELOK<r, s>([In] this LegacyCV2Result<r> self, [Out] s a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x3BD2190", Offset = "0x3BD1590", VA = "0x183BD2190")]
		public static LegacyCV2Result<t?> XSFTRJVNNOY<t>([In] this LegacyCV2Result<LegacyCV2Result<t>> self)
		{
			return default(LegacyCV2Result<t>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public sealed class YLFQBSKWGYE
	{
	}
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	public readonly struct RuntimeFnDelegate
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private readonly IntPtr _functionPointer;

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0xED9440", Offset = "0xED8840", VA = "0x180ED9440")]
		public RuntimeFnDelegate(IntPtr functionPointer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x2B6AD20", Offset = "0x2B6A120", VA = "0x182B6AD20")]
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
		[Cpp2IlInjected.Address(RVA = "0xF17060", Offset = "0xF16460", VA = "0x180F17060")]
		public RuntimeFnDeps(IntPtr getUnmanagedRegisterPointer, IntPtr getManagedRegisterPointer, IntPtr getUnmanagedRegisters, IntPtr getManagedRegisters, IntPtr setUnmanagedRegisterPointer, IntPtr setManagedRegisterPointer, IntPtr getDynamicDeps, IntPtr setDataDeadEnd, IntPtr setExecDeadEnd)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x2B6A8B0", Offset = "0x2B69CB0", VA = "0x182B6A8B0")]
		public Id32<YVGHOMRCUTJ> WUZRXVKKNKL(IntPtr a)
		{
			return default(Id32<YVGHOMRCUTJ>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x2B6AD40", Offset = "0x2B6A140", VA = "0x182B6AD40")]
		public IdArray<YVGHOMRCUTJ, object> CHQDAENYZOT(IntPtr a)
		{
			return default(IdArray<YVGHOMRCUTJ, object>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x2B6AD80", Offset = "0x2B6A180", VA = "0x182B6AD80")]
		public void VEGTFZNYJLV(IntPtr a, Id32<YVGHOMRCUTJ> value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x3EC8D40", Offset = "0x3EC8140", VA = "0x183EC8D40")]
		public TDeps IQISOILYICR<TDeps>(IntPtr a) where TDeps : notnull
		{
			return (TDeps)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x2B6AD60", Offset = "0x2B6A160", VA = "0x182B6AD60")]
		public void JZSPDSNHPBD(IntPtr a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x2B6ADA0", Offset = "0x2B6A1A0", VA = "0x182B6ADA0")]
		public void WIOREBXNGFQ(IntPtr a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public struct RuntimeFnRegistryFactory
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private IdUnsafeList<UXTEGGEVDNB, RuntimeFnDelegate> _runtimeDefs;

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x12C9430", Offset = "0x12C8830", VA = "0x1812C9430")]
		private RuntimeFnRegistryFactory([In] IdUnsafeList<UXTEGGEVDNB, RuntimeFnDelegate> runtimeDefs)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x2B6AE80", Offset = "0x2B6A280", VA = "0x182B6AE80")]
		public static RuntimeFnRegistryFactory GYMJYDCNRDR()
		{
			return default(RuntimeFnRegistryFactory);
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x2B6AEE0", Offset = "0x2B6A2E0", VA = "0x182B6AEE0")]
		public RuntimeFns ISHNKJMJOID()
		{
			return default(RuntimeFns);
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x2B6ADC0", Offset = "0x2B6A1C0", VA = "0x182B6ADC0")]
		public void DOGMMXIVLYW(Id32<UXTEGGEVDNB> runtimeFnId, IntPtr a)
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
		private readonly ReadOnlyIdArray<UXTEGGEVDNB, RuntimeFnDelegate> _impl;

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x2B22620", Offset = "0x2B21A20", VA = "0x182B22620")]
		internal RuntimeFns(ReadOnlyIdArray<UXTEGGEVDNB, RuntimeFnDelegate> impl)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x2B6AF30", Offset = "0x2B6A330", VA = "0x182B6AF30")]
		public RuntimeFnDelegate Get(Id32<UXTEGGEVDNB> runtimeFnId)
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
