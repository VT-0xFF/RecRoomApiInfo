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
		[Cpp2IlInjected.Address(RVA = "0x98FE40", Offset = "0x98F240", VA = "0x18098FE40")]
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
		[Cpp2IlInjected.Address(RVA = "0x98FE40", Offset = "0x98F240", VA = "0x18098FE40")]
		public IsUnmanagedAttribute()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public static class NCKCILHOCJE
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	private delegate ProfilerRecorderHandle EAFHGAICMOI(ProfilerCategory EFJBPHHNLAK, string JDIHNLGFDEG);

	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private static EAFHGAICMOI FPHMHDOAAKM;

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x802A570", Offset = "0x8029970", VA = "0x18802A570")]
	static NCKCILHOCJE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x3622610", Offset = "0x3621A10", VA = "0x183622610")]
	public static byte HJJLKFIGBPE<T>()
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x802A4E0", Offset = "0x80298E0", VA = "0x18802A4E0")]
	public static ProfilerRecorderHandle JNBCMMPCNLC(ProfilerCategory BKBLANLFHBE, string BHGEJIJHINI)
	{
		return default(ProfilerRecorderHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x802A560", Offset = "0x8029960", VA = "0x18802A560")]
	public static ProfilerCategory OOLIEPBKDEK(string BKBLANLFHBE)
	{
		return default(ProfilerCategory);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public readonly struct HNGDCMJPDCK<T> : IEquatable<HNGDCMJPDCK<T>>, IEquatable<ProfilerCounterValue<T>> where T : struct
{
	[NonSerialized]
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	[NativeDisableUnsafePtrRestriction]
	private unsafe readonly T* GNLBICLOGLG;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public T KAMPPLLIEDO
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x4756D80", Offset = "0x4756180", VA = "0x184756D80")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x4756FA0", Offset = "0x47563A0", VA = "0x184756FA0")]
	public HNGDCMJPDCK(ProfilerCategory EFJBPHHNLAK, string OGOCCCFKJPG, ProfilerMarkerDataUnit MPMMEHMCHLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x1F657A0", Offset = "0x1F64BA0", VA = "0x181F657A0", Slot = "4")]
	public bool Equals(HNGDCMJPDCK<T> MNALNBMKJLK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x4756D90", Offset = "0x4756190", VA = "0x184756D90", Slot = "5")]
	public bool Equals(ProfilerCounterValue<T> MNALNBMKJLK)
	{
		return default(bool);
	}
}
[StructLayout((LayoutKind)2, Pack = 1, Size = 8)]
[Cpp2IlInjected.Token(Token = "0x2000007")]
public readonly struct BPMCBEFAPND : IEquatable<BPMCBEFAPND>, IEquatable<ProfilerMarker>
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public readonly struct AECCBOPNJLE : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		[NativeDisableUnsafePtrRestriction]
		internal readonly IntPtr GAACKEPJFNB;

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x802A260", Offset = "0x8029660", VA = "0x18802A260")]
		internal AECCBOPNJLE(IntPtr GAACKEPJFNB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x802A250", Offset = "0x8029650", VA = "0x18802A250", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[NonSerialized]
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	internal readonly IntPtr GAACKEPJFNB;

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x802A2F0", Offset = "0x80296F0", VA = "0x18802A2F0")]
	public BPMCBEFAPND(ushort PMDOAILDELG, string OGOCCCFKJPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x802A2A0", Offset = "0x80296A0", VA = "0x18802A2A0")]
	public BPMCBEFAPND(ProfilerCategory EFJBPHHNLAK, string OGOCCCFKJPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x802A270", Offset = "0x8029670", VA = "0x18802A270")]
	public AECCBOPNJLE BFPBONIEBII()
	{
		return default(AECCBOPNJLE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x802A290", Offset = "0x8029690", VA = "0x18802A290", Slot = "4")]
	public bool Equals(BPMCBEFAPND MNALNBMKJLK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x802A290", Offset = "0x8029690", VA = "0x18802A290", Slot = "5")]
	public bool Equals(ProfilerMarker MNALNBMKJLK)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
internal static class LINANFLEALK
{
	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x359C190", Offset = "0x359B590", VA = "0x18359C190")]
	internal unsafe static bool OIPFBKNMLDH<T>(ProfilerCounterValue<T> JDLFHDKKIAF, [Out] T* GEHEJGGGMPI) where T : struct
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x312E670", Offset = "0x312DA70", VA = "0x18312E670")]
	public static ProfilerCategory JGAFMLGEHCN(ushort ECPENMELENL)
	{
		return default(ProfilerCategory);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x802A410", Offset = "0x8029810", VA = "0x18802A410")]
	public static ushort NGEBEOLMBME(string EIOLBHFLIIK)
	{
		return default(ushort);
	}
}
[StructLayout((LayoutKind)2, Pack = 1, Size = 2)]
[Cpp2IlInjected.Token(Token = "0x200000A")]
public struct IAHIGBJKJHK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public ushort KEEBBIMGFDM;
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
