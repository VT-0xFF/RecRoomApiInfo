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
		[Cpp2IlInjected.Address(RVA = "0xAAFD40", Offset = "0xAAE740", VA = "0x180AAFD40")]
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
		[Cpp2IlInjected.Address(RVA = "0xAAFD40", Offset = "0xAAE740", VA = "0x180AAFD40")]
		public IsUnmanagedAttribute()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public static class GOKCPJPONHF
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	private delegate ProfilerRecorderHandle AGJNPFMDILO(ProfilerCategory COBMGFAEIIO, string DGEOMPHIPBB);

	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private static AGJNPFMDILO ODDNBICHPCL;

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x8E3B8B0", Offset = "0x8E3A2B0", VA = "0x188E3B8B0")]
	static GOKCPJPONHF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x3C77C50", Offset = "0x3C76650", VA = "0x183C77C50")]
	public static byte NLJEAMPGKHA<T>()
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x8E3B830", Offset = "0x8E3A230", VA = "0x188E3B830")]
	public static ProfilerRecorderHandle MKHLDOAAHGP(ProfilerCategory COPHPNIEEOH, string GJHCKPBFKFD)
	{
		return default(ProfilerRecorderHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x8E3B820", Offset = "0x8E3A220", VA = "0x188E3B820")]
	public static ProfilerCategory KBMEJDICPLE(string COPHPNIEEOH)
	{
		return default(ProfilerCategory);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public readonly struct ABGOHHDPAFJ<T> : IEquatable<ABGOHHDPAFJ<T>>, IEquatable<ProfilerCounterValue<T>> where T : struct
{
	[NonSerialized]
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	[NativeDisableUnsafePtrRestriction]
	private unsafe readonly T* PPOFALEGEGL;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public T BHKLFFIKDPE
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x513FA40", Offset = "0x513E440", VA = "0x18513FA40")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x513FA70", Offset = "0x513E470", VA = "0x18513FA70")]
	public ABGOHHDPAFJ(ProfilerCategory COBMGFAEIIO, string FLBFBHGDBLM, ProfilerMarkerDataUnit MHBNPEBLEEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x24587C0", Offset = "0x24571C0", VA = "0x1824587C0", Slot = "4")]
	public bool Equals(ABGOHHDPAFJ<T> EFNHKCDKOGH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x513F990", Offset = "0x513E390", VA = "0x18513F990", Slot = "5")]
	public bool Equals(ProfilerCounterValue<T> EFNHKCDKOGH)
	{
		return default(bool);
	}
}
[StructLayout((LayoutKind)2, Pack = 1, Size = 8)]
[Cpp2IlInjected.Token(Token = "0x2000007")]
public readonly struct MNMIJBLKHEN : IEquatable<MNMIJBLKHEN>, IEquatable<ProfilerMarker>
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public readonly struct JDDGKNENCNM : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		[NativeDisableUnsafePtrRestriction]
		internal readonly IntPtr ILDDCDEAFOF;

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x8E3BB50", Offset = "0x8E3A550", VA = "0x188E3BB50")]
		internal JDDGKNENCNM(IntPtr ILDDCDEAFOF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x8E3BB40", Offset = "0x8E3A540", VA = "0x188E3BB40", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[NonSerialized]
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	internal readonly IntPtr ILDDCDEAFOF;

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x8E3BC60", Offset = "0x8E3A660", VA = "0x188E3BC60")]
	public MNMIJBLKHEN(ushort LFHKMHLLGKH, string FLBFBHGDBLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x8E3BC90", Offset = "0x8E3A690", VA = "0x188E3BC90")]
	public MNMIJBLKHEN(ProfilerCategory COBMGFAEIIO, string FLBFBHGDBLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x8E3BC40", Offset = "0x8E3A640", VA = "0x188E3BC40")]
	public JDDGKNENCNM PCIBDKNBHEM()
	{
		return default(JDDGKNENCNM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x8E3BC30", Offset = "0x8E3A630", VA = "0x188E3BC30", Slot = "4")]
	public bool Equals(MNMIJBLKHEN EFNHKCDKOGH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x8E3BC30", Offset = "0x8E3A630", VA = "0x188E3BC30", Slot = "5")]
	public bool Equals(ProfilerMarker EFNHKCDKOGH)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
internal static class KIEKDHNLJGH
{
	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x3D2B520", Offset = "0x3D29F20", VA = "0x183D2B520")]
	internal unsafe static bool MGMMJILMJPF<T>(ProfilerCounterValue<T> IJJKMMPKJCE, [Out] T* IDFGEJNDMMF) where T : struct
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x3915E30", Offset = "0x3914830", VA = "0x183915E30")]
	public static ProfilerCategory HLPEIKPMONE(ushort CFDGIKKEMBM)
	{
		return default(ProfilerCategory);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x8E3BB60", Offset = "0x8E3A560", VA = "0x188E3BB60")]
	public static ushort OJHNFBMKICA(string CGBPEPFOKCM)
	{
		return default(ushort);
	}
}
[StructLayout((LayoutKind)2, Pack = 1, Size = 2)]
[Cpp2IlInjected.Token(Token = "0x200000A")]
public struct GNFMFOHKFDK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public ushort BBLNPLAJGJA;
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
