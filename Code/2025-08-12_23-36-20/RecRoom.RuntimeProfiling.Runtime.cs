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
		[Cpp2IlInjected.Address(RVA = "0xABED60", Offset = "0xABDB60", VA = "0x180ABED60")]
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
		[Cpp2IlInjected.Address(RVA = "0xABED60", Offset = "0xABDB60", VA = "0x180ABED60")]
		public IsUnmanagedAttribute()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public static class ENNKHOHHOPP
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	private delegate ProfilerRecorderHandle JKCOINOCNOL(ProfilerCategory IBMBMDODBPF, string GOKMDLEJDMO);

	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private static JKCOINOCNOL NDNOHNEJACI;

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x8EBBE90", Offset = "0x8EBAC90", VA = "0x188EBBE90")]
	static ENNKHOHHOPP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x3B84D30", Offset = "0x3B83B30", VA = "0x183B84D30")]
	public static byte HIAPENFLIMJ<T>()
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x8EBBE00", Offset = "0x8EBAC00", VA = "0x188EBBE00")]
	public static ProfilerRecorderHandle DOFHMIGKNCK(ProfilerCategory BKHOBKBEJDB, string KHEPAFLLBJG)
	{
		return default(ProfilerRecorderHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x8EBBE80", Offset = "0x8EBAC80", VA = "0x188EBBE80")]
	public static ProfilerCategory JGIIHMPBKJP(string BKHOBKBEJDB)
	{
		return default(ProfilerCategory);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public readonly struct LCEDLBLDAGB<T> : IEquatable<LCEDLBLDAGB<T>>, IEquatable<ProfilerCounterValue<T>> where T : struct
{
	[NonSerialized]
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	[NativeDisableUnsafePtrRestriction]
	private unsafe readonly T* FEHLBHHLHDL;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public T DDHBFJGPDAJ
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x5679B70", Offset = "0x5678970", VA = "0x185679B70")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x5679DA0", Offset = "0x5678BA0", VA = "0x185679DA0")]
	public LCEDLBLDAGB(ProfilerCategory IBMBMDODBPF, string PFLDDMDPCBI, ProfilerMarkerDataUnit MGHKIGBEBFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x24AA520", Offset = "0x24A9320", VA = "0x1824AA520", Slot = "4")]
	public bool Equals(LCEDLBLDAGB<T> FGAEAFBDBPK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x5679BA0", Offset = "0x56789A0", VA = "0x185679BA0", Slot = "5")]
	public bool Equals(ProfilerCounterValue<T> FGAEAFBDBPK)
	{
		return default(bool);
	}
}
[StructLayout((LayoutKind)2, Pack = 1, Size = 8)]
[Cpp2IlInjected.Token(Token = "0x2000007")]
public readonly struct ENGGOGGONEN : IEquatable<ENGGOGGONEN>, IEquatable<ProfilerMarker>
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public readonly struct NOPLBFFIEEJ : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		[NativeDisableUnsafePtrRestriction]
		internal readonly IntPtr FBHICCMFGCG;

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x8EBC2D0", Offset = "0x8EBB0D0", VA = "0x188EBC2D0")]
		internal NOPLBFFIEEJ(IntPtr FBHICCMFGCG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x8EBBD70", Offset = "0x8EBAB70", VA = "0x188EBBD70", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[NonSerialized]
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	internal readonly IntPtr FBHICCMFGCG;

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x8EBBD80", Offset = "0x8EBAB80", VA = "0x188EBBD80")]
	public ENGGOGGONEN(ushort OEGLKFOKMEB, string PFLDDMDPCBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x8EBBDB0", Offset = "0x8EBABB0", VA = "0x188EBBDB0")]
	public ENGGOGGONEN(ProfilerCategory IBMBMDODBPF, string PFLDDMDPCBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x8EBBD60", Offset = "0x8EBAB60", VA = "0x188EBBD60")]
	public void MGHFNHPKFKE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x8EBBD70", Offset = "0x8EBAB70", VA = "0x188EBBD70")]
	public void OKAPFDDJAJF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x8EBBD40", Offset = "0x8EBAB40", VA = "0x188EBBD40")]
	public NOPLBFFIEEJ FJCEGCBOKBG()
	{
		return default(NOPLBFFIEEJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x8EBBD30", Offset = "0x8EBAB30", VA = "0x188EBBD30", Slot = "4")]
	public bool Equals(ENGGOGGONEN FGAEAFBDBPK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x8EBBD30", Offset = "0x8EBAB30", VA = "0x188EBBD30", Slot = "5")]
	public bool Equals(ProfilerMarker FGAEAFBDBPK)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
internal static class LOCEGHBAEOF
{
	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x3DDF880", Offset = "0x3DDE680", VA = "0x183DDF880")]
	internal unsafe static bool MBHAMHEOBFD<T>(ProfilerCounterValue<T> PNCJPMFEJAA, [Out] T* NFHMMNMHENG) where T : struct
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x39B5D10", Offset = "0x39B4B10", VA = "0x1839B5D10")]
	public static ProfilerCategory HJKHAKGBKMG(ushort PKFCHDGGEEL)
	{
		return default(ProfilerCategory);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x8EBC200", Offset = "0x8EBB000", VA = "0x188EBC200")]
	public static ushort FEJMHHPAJEN(string OBCMIFCCAJI)
	{
		return default(ushort);
	}
}
[StructLayout((LayoutKind)2, Pack = 1, Size = 2)]
[Cpp2IlInjected.Token(Token = "0x200000A")]
public struct FKCNDEBMFLG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public ushort ANEJECDANKL;
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
