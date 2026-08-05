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
		[Cpp2IlInjected.Address(RVA = "0xA82AE0", Offset = "0xA818E0", VA = "0x180A82AE0")]
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
		[Cpp2IlInjected.Address(RVA = "0xA82AE0", Offset = "0xA818E0", VA = "0x180A82AE0")]
		public IsUnmanagedAttribute()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public static class HKLJPIJBFNI
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	private delegate ProfilerRecorderHandle LDLBPILPKED(ProfilerCategory INDDHEPFNIF, string NLHKMPPIPHH);

	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private static LDLBPILPKED KJKFJCHEAAM;

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x8BD7AE0", Offset = "0x8BD68E0", VA = "0x188BD7AE0")]
	static HKLJPIJBFNI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x3BA0EB0", Offset = "0x3B9FCB0", VA = "0x183BA0EB0")]
	public static byte DEBEGPNMKFJ<T>()
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x8BD7A50", Offset = "0x8BD6850", VA = "0x188BD7A50")]
	public static ProfilerRecorderHandle GMCCALBHAOC(ProfilerCategory KEOIDOHFFNC, string KNKCFBKFKGL)
	{
		return default(ProfilerRecorderHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x8BD7AD0", Offset = "0x8BD68D0", VA = "0x188BD7AD0")]
	public static ProfilerCategory ILMDBPJCLFA(string KEOIDOHFFNC)
	{
		return default(ProfilerCategory);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public readonly struct IILCKCKDCNP<T> : IEquatable<IILCKCKDCNP<T>>, IEquatable<ProfilerCounterValue<T>> where T : struct
{
	[NonSerialized]
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	[NativeDisableUnsafePtrRestriction]
	private unsafe readonly T* IEFCPIHGJOI;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public T HBDLGDLEPJD
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x4F20730", Offset = "0x4F1F530", VA = "0x184F20730")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x4F208C0", Offset = "0x4F1F6C0", VA = "0x184F208C0")]
	public IILCKCKDCNP(ProfilerCategory INDDHEPFNIF, string GGDFKFACHGG, ProfilerMarkerDataUnit KAKCADMONBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x23CD190", Offset = "0x23CBF90", VA = "0x1823CD190", Slot = "4")]
	public bool Equals(IILCKCKDCNP<T> LOKLFHKEJPC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x4F20680", Offset = "0x4F1F480", VA = "0x184F20680", Slot = "5")]
	public bool Equals(ProfilerCounterValue<T> LOKLFHKEJPC)
	{
		return default(bool);
	}
}
[StructLayout((LayoutKind)2, Pack = 1, Size = 8)]
[Cpp2IlInjected.Token(Token = "0x2000007")]
public readonly struct LCMFMBCPLOH : IEquatable<LCMFMBCPLOH>, IEquatable<ProfilerMarker>
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public readonly struct OACMBPPMIOB : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		[NativeDisableUnsafePtrRestriction]
		internal readonly IntPtr MIMMKAGEHPM;

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x8BD7F20", Offset = "0x8BD6D20", VA = "0x188BD7F20")]
		internal OACMBPPMIOB(IntPtr MIMMKAGEHPM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x8BD7F10", Offset = "0x8BD6D10", VA = "0x188BD7F10", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[NonSerialized]
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	internal readonly IntPtr MIMMKAGEHPM;

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x8BD7DF0", Offset = "0x8BD6BF0", VA = "0x188BD7DF0")]
	public LCMFMBCPLOH(ushort COGJGNNIIJK, string GGDFKFACHGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x8BD7DA0", Offset = "0x8BD6BA0", VA = "0x188BD7DA0")]
	public LCMFMBCPLOH(ProfilerCategory INDDHEPFNIF, string GGDFKFACHGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x8BD7D70", Offset = "0x8BD6B70", VA = "0x188BD7D70")]
	public OACMBPPMIOB DOLKLCPKHPA()
	{
		return default(OACMBPPMIOB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x8BD7D90", Offset = "0x8BD6B90", VA = "0x188BD7D90", Slot = "4")]
	public bool Equals(LCMFMBCPLOH LOKLFHKEJPC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x8BD7D90", Offset = "0x8BD6B90", VA = "0x188BD7D90", Slot = "5")]
	public bool Equals(ProfilerMarker LOKLFHKEJPC)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
internal static class EJEGADBNEAF
{
	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x3A1C620", Offset = "0x3A1B420", VA = "0x183A1C620")]
	internal unsafe static bool PACGMPBILOA<T>(ProfilerCounterValue<T> MHACEKDPNKF, [Out] T* AFAOAJPFPAH) where T : struct
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x384CF90", Offset = "0x384BD90", VA = "0x18384CF90")]
	public static ProfilerCategory OHIAHOGOEFA(ushort MEMFAEOGFAF)
	{
		return default(ProfilerCategory);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x8BD7980", Offset = "0x8BD6780", VA = "0x188BD7980")]
	public static ushort HNCEPNNJECO(string OBIKLPKFLKK)
	{
		return default(ushort);
	}
}
[StructLayout((LayoutKind)2, Pack = 1, Size = 2)]
[Cpp2IlInjected.Token(Token = "0x200000A")]
public struct LKGLHKPJEMO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public ushort GPAJMBLOOLA;
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
