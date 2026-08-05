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
		[Cpp2IlInjected.Address(RVA = "0xA8A800", Offset = "0xA89800", VA = "0x180A8A800")]
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
		[Cpp2IlInjected.Address(RVA = "0xA8A800", Offset = "0xA89800", VA = "0x180A8A800")]
		public IsUnmanagedAttribute()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public static class AFBAKLNGLBB
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	private delegate ProfilerRecorderHandle NCAIMIPAEGO(ProfilerCategory AJJONCKACFM, string HGHAPGIMMMJ);

	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private static NCAIMIPAEGO CJDOEJMJHKE;

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x8CADBA0", Offset = "0x8CACBA0", VA = "0x188CADBA0")]
	static AFBAKLNGLBB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x3199520", Offset = "0x3198520", VA = "0x183199520")]
	public static byte BDGMMBCHEDN<T>()
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x8CADB10", Offset = "0x8CACB10", VA = "0x188CADB10")]
	public static ProfilerRecorderHandle KHAHEOKMLFG(ProfilerCategory IFPMIBDFJLB, string IFKIPKLLFMH)
	{
		return default(ProfilerRecorderHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x8CADB90", Offset = "0x8CACB90", VA = "0x188CADB90")]
	public static ProfilerCategory PJKAGNNIENM(string IFPMIBDFJLB)
	{
		return default(ProfilerCategory);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public readonly struct ANDLEJIKKLC<T> : IEquatable<ANDLEJIKKLC<T>>, IEquatable<ProfilerCounterValue<T>> where T : struct
{
	[NonSerialized]
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	[NativeDisableUnsafePtrRestriction]
	private unsafe readonly T* FKMNMGDJILN;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public T BDJLGAHJNPH
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x527BB30", Offset = "0x527AB30", VA = "0x18527BB30")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x527BB60", Offset = "0x527AB60", VA = "0x18527BB60")]
	public ANDLEJIKKLC(ProfilerCategory AJJONCKACFM, string HJLBILHBIIC, ProfilerMarkerDataUnit FIBPAEFFFJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x2428620", Offset = "0x2427620", VA = "0x182428620", Slot = "4")]
	public bool Equals(ANDLEJIKKLC<T> EDJHHGMLKFA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x527BA80", Offset = "0x527AA80", VA = "0x18527BA80", Slot = "5")]
	public bool Equals(ProfilerCounterValue<T> EDJHHGMLKFA)
	{
		return default(bool);
	}
}
[StructLayout((LayoutKind)2, Pack = 1, Size = 8)]
[Cpp2IlInjected.Token(Token = "0x2000007")]
public readonly struct JICGFBMJLKP : IEquatable<JICGFBMJLKP>, IEquatable<ProfilerMarker>
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public readonly struct OMFKIDBFKAA : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		[NativeDisableUnsafePtrRestriction]
		internal readonly IntPtr IJGIPIFNEOF;

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x8CAE0B0", Offset = "0x8CAD0B0", VA = "0x188CAE0B0")]
		internal OMFKIDBFKAA(IntPtr IJGIPIFNEOF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x8CAE0A0", Offset = "0x8CAD0A0", VA = "0x188CAE0A0", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[NonSerialized]
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	internal readonly IntPtr IJGIPIFNEOF;

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x8CADF30", Offset = "0x8CACF30", VA = "0x188CADF30")]
	public JICGFBMJLKP(ushort IMDGOJNDCMB, string HJLBILHBIIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x8CADF60", Offset = "0x8CACF60", VA = "0x188CADF60")]
	public JICGFBMJLKP(ProfilerCategory AJJONCKACFM, string HJLBILHBIIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x8CADF10", Offset = "0x8CACF10", VA = "0x188CADF10")]
	public OMFKIDBFKAA PFIPEAMIKKI()
	{
		return default(OMFKIDBFKAA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x8CADF00", Offset = "0x8CACF00", VA = "0x188CADF00", Slot = "4")]
	public bool Equals(JICGFBMJLKP EDJHHGMLKFA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x8CADF00", Offset = "0x8CACF00", VA = "0x188CADF00", Slot = "5")]
	public bool Equals(ProfilerMarker EDJHHGMLKFA)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
internal static class JHDCJEDGIGN
{
	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x3CE8130", Offset = "0x3CE7130", VA = "0x183CE8130")]
	internal unsafe static bool OPCNDMNNFDE<T>(ProfilerCounterValue<T> HPMLBLGKGIE, [Out] T* AKLHOEFIDEC) where T : struct
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x38EE240", Offset = "0x38ED240", VA = "0x1838EE240")]
	public static ProfilerCategory MMJNPKMCAFP(ushort GKCIAFICMOC)
	{
		return default(ProfilerCategory);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x8CADE30", Offset = "0x8CACE30", VA = "0x188CADE30")]
	public static ushort OBLFMDFBBLA(string NLDKJHHEIPE)
	{
		return default(ushort);
	}
}
[StructLayout((LayoutKind)2, Pack = 1, Size = 2)]
[Cpp2IlInjected.Token(Token = "0x200000A")]
public struct FMOAJEHPJHK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public ushort HIGFKOBEOIE;
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
