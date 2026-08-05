using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Microsoft.CodeAnalysis;
using Unity.Collections.LowLevel.Unsafe;
using Unity.Profiling;
using Unity.Profiling.LowLevel.Unsafe;

[assembly: AssemblyVersion("0.0.0.0")]
namespace Microsoft.CodeAnalysis
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class EmbeddedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0xA1A8A0", Offset = "0xA19AA0", VA = "0x180A1A8A0")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[Microsoft.CodeAnalysis.Embedded]
	[CompilerGenerated]
	internal sealed class IsUnmanagedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xA1A8A0", Offset = "0xA19AA0", VA = "0x180A1A8A0")]
		public IsUnmanagedAttribute()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public static class DOMMMGFPDEE
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	private delegate ProfilerRecorderHandle AHJBDPOBIBB(ProfilerCategory BHDEGBMLBGB, string HHKHEDEKBJM);

	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private static AHJBDPOBIBB HPAKPBMGHEB;

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x873ECB0", Offset = "0x873DEB0", VA = "0x18873ECB0")]
	static DOMMMGFPDEE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x36743B0", Offset = "0x36735B0", VA = "0x1836743B0")]
	public static byte MDGEDNBFBCI<T>()
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x873EC30", Offset = "0x873DE30", VA = "0x18873EC30")]
	public static ProfilerRecorderHandle KEDIOPNCPKO(ProfilerCategory BECHMMCAKGB, string EGEPCBHELOO)
	{
		return default(ProfilerRecorderHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x873EC20", Offset = "0x873DE20", VA = "0x18873EC20")]
	public static ProfilerCategory EEKMKLOKGEE(string BECHMMCAKGB)
	{
		return default(ProfilerCategory);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public readonly struct PLILLHCLCLK<T> : IEquatable<PLILLHCLCLK<T>>, IEquatable<ProfilerCounterValue<T>> where T : struct
{
	[NonSerialized]
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	[NativeDisableUnsafePtrRestriction]
	private unsafe readonly T* HFOHOOIFKKM;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public T ABLHJAOAOGP
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x5634F40", Offset = "0x5634140", VA = "0x185634F40")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x5634F70", Offset = "0x5634170", VA = "0x185634F70")]
	public PLILLHCLCLK(ProfilerCategory BHDEGBMLBGB, string DGIAFBEDPNJ, ProfilerMarkerDataUnit KEMDLCJPILL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x21784B0", Offset = "0x21776B0", VA = "0x1821784B0", Slot = "4")]
	public bool Equals(PLILLHCLCLK<T> FNJGMJGALLH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x5634E90", Offset = "0x5634090", VA = "0x185634E90", Slot = "5")]
	public bool Equals(ProfilerCounterValue<T> FNJGMJGALLH)
	{
		return default(bool);
	}
}
[StructLayout((LayoutKind)2, Pack = 1, Size = 8)]
[Cpp2IlInjected.Token(Token = "0x2000007")]
public readonly struct AGIHOIBAMMI : IEquatable<AGIHOIBAMMI>, IEquatable<ProfilerMarker>
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public readonly struct ILGOMIPIPLK : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		[NativeDisableUnsafePtrRestriction]
		internal readonly IntPtr LIAECAODGIF;

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x873EF40", Offset = "0x873E140", VA = "0x18873EF40")]
		internal ILGOMIPIPLK(IntPtr LIAECAODGIF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x873EF30", Offset = "0x873E130", VA = "0x18873EF30", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[NonSerialized]
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	internal readonly IntPtr LIAECAODGIF;

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x873EAB0", Offset = "0x873DCB0", VA = "0x18873EAB0")]
	public AGIHOIBAMMI(ushort DNNPEHNCMKD, string DGIAFBEDPNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x873EAE0", Offset = "0x873DCE0", VA = "0x18873EAE0")]
	public AGIHOIBAMMI(ProfilerCategory BHDEGBMLBGB, string DGIAFBEDPNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x873EA90", Offset = "0x873DC90", VA = "0x18873EA90")]
	public ILGOMIPIPLK JNECLPMNEBK()
	{
		return default(ILGOMIPIPLK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x873EA80", Offset = "0x873DC80", VA = "0x18873EA80", Slot = "4")]
	public bool Equals(AGIHOIBAMMI FNJGMJGALLH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x873EA80", Offset = "0x873DC80", VA = "0x18873EA80", Slot = "5")]
	public bool Equals(ProfilerMarker FNJGMJGALLH)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
internal static class AEDNGKKEINB
{
	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x4015090", Offset = "0x4014290", VA = "0x184015090")]
	internal unsafe static bool FGLLHOHLPBF<T>(ProfilerCounterValue<T> CGOJPBDKMDP, [Out] T* JOAOMCDFEOD) where T : struct
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x34D6C30", Offset = "0x34D5E30", VA = "0x1834D6C30")]
	public static ProfilerCategory FLDFBOHDLHI(ushort EOCPNEEDLIA)
	{
		return default(ProfilerCategory);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x873E9B0", Offset = "0x873DBB0", VA = "0x18873E9B0")]
	public static ushort PHKFGFDGGMD(string CDCJPBFEGAK)
	{
		return default(ushort);
	}
}
[StructLayout((LayoutKind)2, Pack = 1, Size = 2)]
[Cpp2IlInjected.Token(Token = "0x200000A")]
public struct BDPFMEIMLOI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public ushort GBDIGMMCBEH;
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
