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
		[Cpp2IlInjected.Address(RVA = "0xA336C0", Offset = "0xA324C0", VA = "0x180A336C0")]
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
		[Cpp2IlInjected.Address(RVA = "0xA336C0", Offset = "0xA324C0", VA = "0x180A336C0")]
		public IsUnmanagedAttribute()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public static class CAKEEOLPDKF
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	private delegate ProfilerRecorderHandle LEMDJNIGKHH(ProfilerCategory IOLEFJBIFKA, string NLHINDNEKOC);

	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private static LEMDJNIGKHH AFEGNOFCBKO;

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x8875730", Offset = "0x8874530", VA = "0x188875730")]
	static CAKEEOLPDKF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x3705DF0", Offset = "0x3704BF0", VA = "0x183705DF0")]
	public static byte GAOKBPAJMFP<T>()
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x88756B0", Offset = "0x88744B0", VA = "0x1888756B0")]
	public static ProfilerRecorderHandle PGOCFCHBAOE(ProfilerCategory PJKGKDLBCFA, string FADNIGDPIHN)
	{
		return default(ProfilerRecorderHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x88756A0", Offset = "0x88744A0", VA = "0x1888756A0")]
	public static ProfilerCategory KFAJCIJIKPH(string PJKGKDLBCFA)
	{
		return default(ProfilerCategory);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public readonly struct KCCNKDELGKM<T> : IEquatable<KCCNKDELGKM<T>>, IEquatable<ProfilerCounterValue<T>> where T : struct
{
	[NonSerialized]
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	[NativeDisableUnsafePtrRestriction]
	private unsafe readonly T* OPADNLFLNFA;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public T COJGBJGNJFM
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x50950C0", Offset = "0x5093EC0", VA = "0x1850950C0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x5095100", Offset = "0x5093F00", VA = "0x185095100")]
	public KCCNKDELGKM(ProfilerCategory IOLEFJBIFKA, string IHGFMOMOADA, ProfilerMarkerDataUnit GFLOIPAJAFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x21CE370", Offset = "0x21CD170", VA = "0x1821CE370", Slot = "4")]
	public bool Equals(KCCNKDELGKM<T> HBLONCAMFLG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x5095020", Offset = "0x5093E20", VA = "0x185095020", Slot = "5")]
	public bool Equals(ProfilerCounterValue<T> HBLONCAMFLG)
	{
		return default(bool);
	}
}
[StructLayout((LayoutKind)2, Pack = 1, Size = 8)]
[Cpp2IlInjected.Token(Token = "0x2000007")]
public readonly struct LJJLJNIKDGF : IEquatable<LJJLJNIKDGF>, IEquatable<ProfilerMarker>
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public readonly struct BDNCKFEOGJK : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		[NativeDisableUnsafePtrRestriction]
		internal readonly IntPtr HKPOKNDGFPG;

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x8875690", Offset = "0x8874490", VA = "0x188875690")]
		internal BDNCKFEOGJK(IntPtr HKPOKNDGFPG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x8875680", Offset = "0x8874480", VA = "0x188875680", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[NonSerialized]
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	internal readonly IntPtr HKPOKNDGFPG;

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x8875B30", Offset = "0x8874930", VA = "0x188875B30")]
	public LJJLJNIKDGF(ushort GBFNDIBHLCA, string IHGFMOMOADA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x8875AE0", Offset = "0x88748E0", VA = "0x188875AE0")]
	public LJJLJNIKDGF(ProfilerCategory IOLEFJBIFKA, string IHGFMOMOADA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x8875AC0", Offset = "0x88748C0", VA = "0x188875AC0")]
	public BDNCKFEOGJK IBKPIKBIEJJ()
	{
		return default(BDNCKFEOGJK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x8875AB0", Offset = "0x88748B0", VA = "0x188875AB0", Slot = "4")]
	public bool Equals(LJJLJNIKDGF HBLONCAMFLG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x8875AB0", Offset = "0x88748B0", VA = "0x188875AB0", Slot = "5")]
	public bool Equals(ProfilerMarker HBLONCAMFLG)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
internal static class MPIBGFIBMMM
{
	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x3A1E2B0", Offset = "0x3A1D0B0", VA = "0x183A1E2B0")]
	internal unsafe static bool BCDJPJEBAKI<T>(ProfilerCounterValue<T> DOEFGKANLNH, [Out] T* FFMNHJIBMAL) where T : struct
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x35BF7C0", Offset = "0x35BE5C0", VA = "0x1835BF7C0")]
	public static ProfilerCategory EONEHAJJJOB(ushort KNMFOOLNGPL)
	{
		return default(ProfilerCategory);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x8875B60", Offset = "0x8874960", VA = "0x188875B60")]
	public static ushort PKOJDMHHBBA(string CANOHJADPGF)
	{
		return default(ushort);
	}
}
[StructLayout((LayoutKind)2, Pack = 1, Size = 2)]
[Cpp2IlInjected.Token(Token = "0x200000A")]
public struct OBJIMMANJCO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public ushort DGPBKFIELKB;
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
