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
		[Cpp2IlInjected.Address(RVA = "0xABFAB0", Offset = "0xABE0B0", VA = "0x180ABFAB0")]
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
		[Cpp2IlInjected.Address(RVA = "0xABFAB0", Offset = "0xABE0B0", VA = "0x180ABFAB0")]
		public IsUnmanagedAttribute()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public static class CPHLIMFPHBK
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	private delegate ProfilerRecorderHandle LNOBJDAFBAN(ProfilerCategory HIKGHFOMFFB, string HBAOIKNDAJH);

	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private static LNOBJDAFBAN ALMKGMOGKOO;

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x8FAEA70", Offset = "0x8FAD070", VA = "0x188FAEA70")]
	static CPHLIMFPHBK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x3B8ED70", Offset = "0x3B8D370", VA = "0x183B8ED70")]
	public static byte NHBJCCPLLNF<T>()
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x8FAE9E0", Offset = "0x8FACFE0", VA = "0x188FAE9E0")]
	public static ProfilerRecorderHandle AJMHIACDCIH(ProfilerCategory PIACINCGEHE, string JIFOILAELCM)
	{
		return default(ProfilerRecorderHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x8FAEA60", Offset = "0x8FAD060", VA = "0x188FAEA60")]
	public static ProfilerCategory EDCKBPGPHFM(string PIACINCGEHE)
	{
		return default(ProfilerCategory);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public readonly struct AFPMEIHEKKD<T> : IEquatable<AFPMEIHEKKD<T>>, IEquatable<ProfilerCounterValue<T>> where T : struct
{
	[NonSerialized]
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	[NativeDisableUnsafePtrRestriction]
	private unsafe readonly T* OLMCDMDHDMD;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public T FAGODIAEODP
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x53E6C50", Offset = "0x53E5250", VA = "0x1853E6C50")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x53E7140", Offset = "0x53E5740", VA = "0x1853E7140")]
	public AFPMEIHEKKD(ProfilerCategory HIKGHFOMFFB, string DJFMCHMDHGK, ProfilerMarkerDataUnit IKIGJNCFDPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x24C0E60", Offset = "0x24BF460", VA = "0x1824C0E60", Slot = "4")]
	public bool Equals(AFPMEIHEKKD<T> IBCMCOKAJEM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x53E6C80", Offset = "0x53E5280", VA = "0x1853E6C80", Slot = "5")]
	public bool Equals(ProfilerCounterValue<T> IBCMCOKAJEM)
	{
		return default(bool);
	}
}
[StructLayout((LayoutKind)2, Pack = 1, Size = 8)]
[Cpp2IlInjected.Token(Token = "0x2000007")]
public readonly struct PHIBLNCDEGC : IEquatable<PHIBLNCDEGC>, IEquatable<ProfilerMarker>
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public readonly struct AJAIFGECDKH : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		[NativeDisableUnsafePtrRestriction]
		internal readonly IntPtr LIHANCKFEKA;

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x8FAE9D0", Offset = "0x8FACFD0", VA = "0x188FAE9D0")]
		internal AJAIFGECDKH(IntPtr LIHANCKFEKA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x8FAE9C0", Offset = "0x8FACFC0", VA = "0x188FAE9C0", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[NonSerialized]
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	internal readonly IntPtr LIHANCKFEKA;

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x8FAEF50", Offset = "0x8FAD550", VA = "0x188FAEF50")]
	public PHIBLNCDEGC(ushort FGDGHHCHKNE, string DJFMCHMDHGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x8FAEF00", Offset = "0x8FAD500", VA = "0x188FAEF00")]
	public PHIBLNCDEGC(ProfilerCategory HIKGHFOMFFB, string DJFMCHMDHGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x8FAEEF0", Offset = "0x8FAD4F0", VA = "0x188FAEEF0")]
	public void LOBOJNLEMFD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x8FAE9C0", Offset = "0x8FACFC0", VA = "0x188FAE9C0")]
	public void ONIBBDPIEBH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x8FAEED0", Offset = "0x8FAD4D0", VA = "0x188FAEED0")]
	public AJAIFGECDKH LJKLDDNLMGH()
	{
		return default(AJAIFGECDKH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x8FAEEC0", Offset = "0x8FAD4C0", VA = "0x188FAEEC0", Slot = "4")]
	public bool Equals(PHIBLNCDEGC IBCMCOKAJEM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x8FAEEC0", Offset = "0x8FAD4C0", VA = "0x188FAEEC0", Slot = "5")]
	public bool Equals(ProfilerMarker IBCMCOKAJEM)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
internal static class FNEKCOJFMJJ
{
	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x3D8BAA0", Offset = "0x3D8A0A0", VA = "0x183D8BAA0")]
	internal unsafe static bool DFAIFDMMJHN<T>(ProfilerCounterValue<T> IFPJKNJCFGG, [Out] T* ACMJOHBMFNL) where T : struct
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x3A245A0", Offset = "0x3A22BA0", VA = "0x183A245A0")]
	public static ProfilerCategory PKKFLHHPEMB(ushort GPDNENOBPCI)
	{
		return default(ProfilerCategory);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x8FAED00", Offset = "0x8FAD300", VA = "0x188FAED00")]
	public static ushort PHDKDBDBFKJ(string FOHHMHNKCCD)
	{
		return default(ushort);
	}
}
[StructLayout((LayoutKind)2, Pack = 1, Size = 2)]
[Cpp2IlInjected.Token(Token = "0x200000A")]
public struct GHJLHFNKAKO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public ushort AIEDODKBOKI;
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
