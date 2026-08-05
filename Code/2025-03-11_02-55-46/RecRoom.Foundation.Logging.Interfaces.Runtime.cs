using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Microsoft.CodeAnalysis;
using RecRoom;
using Unity.Collections;

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
[AttributeUsage(AttributeTargets.Class)]
public class BBJFNCEDGOB : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x98FE40", Offset = "0x98F240", VA = "0x18098FE40")]
	public BBJFNCEDGOB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
[AttributeUsage(AttributeTargets.Class)]
public class GINBKNOANIN : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x75FD1A0", Offset = "0x75FC5A0", VA = "0x1875FD1A0")]
	public GINBKNOANIN(int NBPEDBIONNC, int DDKAAGFCMAC, int OEHDNNBNHNF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[AttributeUsage(AttributeTargets.Class)]
public class ICPKKFOJFPM : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x9905D0", Offset = "0x98F9D0", VA = "0x1809905D0")]
	public ICPKKFOJFPM(bool FNFKKCGPAEI = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
[AttributeUsage(AttributeTargets.Class)]
public class OAIFPGCMIBK : RegisterType
{
	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x75FD2F0", Offset = "0x75FC6F0", VA = "0x1875FD2F0")]
	public OAIFPGCMIBK(string OGOCCCFKJPG, string APDEKOCIEGN = "")
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
[AttributeUsage(AttributeTargets.Class)]
public class DHHEJPMDCPP : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int KAMPPLLIEDO
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x9641A0", Offset = "0x9635A0", VA = "0x1809641A0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x1F67C00", Offset = "0x1F67000", VA = "0x181F67C00")]
	public DHHEJPMDCPP(int PEBNJNGMMHE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
[Flags]
public enum EDKFLKNJHNI
{
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	NonNetworked = 1,
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	Incoming = 2,
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	Outgoing = 4,
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	Suppressed = 8,
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	FastForward = 0x10,
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	CacheRemove = 0x20,
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	Default = 0x3F,
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	All = 0x3F
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface JOHFIMIOIAA
{
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface AAFDJAOJKML<T> : JOHFIMIOIAA
{
	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void MGBOBDHIHDK([In] ECGIAGCEELD ICDINJIMJPC, T PEBNJNGMMHE);
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface NFHHBMPMEMJ : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	bool LCGBKIDHNKC
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	int KEAFBEDFEAO
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	int GANNGCCKJEL(Type ANONBNLNHHL);

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void NGKGOGCKDHD(NativeParallelHashMap<int, AOIKGLJHPKL> NBKCBIBCKOC, NativeArray<byte> MJFOKKFMONL);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface GLIBCCBOHNI
{
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public sealed class NIDEDIBAFEA
{
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public abstract class CLKKNBJFGEO<T> : AMDMCGCENJN<T> where T : struct, Enum
{
	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x40B57F0", Offset = "0x40B4BF0", VA = "0x1840B57F0")]
	protected CLKKNBJFGEO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public abstract class AMDMCGCENJN<T> : AAFDJAOJKML<T>, JOHFIMIOIAA where T : struct
{
	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x473D8C0", Offset = "0x473CCC0", VA = "0x18473D8C0")]
	public void MGBOBDHIHDK([In] ECGIAGCEELD ICDINJIMJPC, T PEBNJNGMMHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x96D700", Offset = "0x96CB00", VA = "0x18096D700")]
	protected AMDMCGCENJN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x473D9A0", Offset = "0x473CDA0", VA = "0x18473D9A0", Slot = "4")]
	private void NPLJEAJGLID([In] ECGIAGCEELD ICDINJIMJPC, T PEBNJNGMMHE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public abstract class DBOIFDEAJFM<T> : AAFDJAOJKML<NativeArray<T>>, JOHFIMIOIAA where T : struct
{
	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x63E7D20", Offset = "0x63E7120", VA = "0x1863E7D20")]
	public void MGBOBDHIHDK([In] ECGIAGCEELD ICDINJIMJPC, NativeArray<T> PEBNJNGMMHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x3635AC0", Offset = "0x3634EC0", VA = "0x183635AC0")]
	public static ReadOnlySpan<T> PCNIGNBHHJH<T>(NativeArray<T> PHAPILEGACC) where T : struct
	{
		return default(ReadOnlySpan<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x96D700", Offset = "0x96CB00", VA = "0x18096D700")]
	protected DBOIFDEAJFM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x63E7CD0", Offset = "0x63E70D0", VA = "0x1863E7CD0", Slot = "4")]
	private void KPPNBFOIKHF([In] ECGIAGCEELD ICDINJIMJPC, NativeArray<T> PEBNJNGMMHE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class HFJKBCKFPCB : AAFDJAOJKML<HFJKBCKFPCB.PEEGENOMDIE>, JOHFIMIOIAA
{
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public struct PEEGENOMDIE
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x966900", Offset = "0x965D00", VA = "0x180966900")]
	public void MGBOBDHIHDK([In] ECGIAGCEELD ICDINJIMJPC, PEEGENOMDIE PEBNJNGMMHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x96D700", Offset = "0x96CB00", VA = "0x18096D700")]
	public HFJKBCKFPCB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x966900", Offset = "0x965D00", VA = "0x180966900", Slot = "4")]
	private void PJJOLDAFDNA([In] ECGIAGCEELD ICDINJIMJPC, PEEGENOMDIE PEBNJNGMMHE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class OFEKPCMBEMM : AAFDJAOJKML<string>, JOHFIMIOIAA
{
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public static readonly OFEKPCMBEMM AJPLFLPAHGP;

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x75FD350", Offset = "0x75FC750", VA = "0x1875FD350")]
	public void MGBOBDHIHDK([In] ECGIAGCEELD ICDINJIMJPC, string PEBNJNGMMHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x96D700", Offset = "0x96CB00", VA = "0x18096D700")]
	public OFEKPCMBEMM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x75FD340", Offset = "0x75FC740", VA = "0x1875FD340", Slot = "4")]
	private void LPIKPAKFJEH([In] ECGIAGCEELD ICDINJIMJPC, string PEBNJNGMMHE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public abstract class FHLOHNEJINI<T> : OGLCJDJOAHM<T> where T : struct, IComparable<T>
{
	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x40B57F0", Offset = "0x40B4BF0", VA = "0x1840B57F0")]
	protected FHLOHNEJINI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public abstract class OGLCJDJOAHM<T> : AAFDJAOJKML<T>, JOHFIMIOIAA where T : struct
{
	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x4FA25A0", Offset = "0x4FA19A0", VA = "0x184FA25A0")]
	public void MGBOBDHIHDK([In] ECGIAGCEELD ICDINJIMJPC, T PEBNJNGMMHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x96D700", Offset = "0x96CB00", VA = "0x18096D700")]
	protected OGLCJDJOAHM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x473D9A0", Offset = "0x473CDA0", VA = "0x18473D9A0", Slot = "4")]
	private void NPLJEAJGLID([In] ECGIAGCEELD ICDINJIMJPC, T PEBNJNGMMHE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public struct ECGIAGCEELD : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public readonly struct IFJFDPOPGDD : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private readonly ECGIAGCEELD ICDINJIMJPC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private readonly int EBLICLHHKFK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private readonly int POEPDMLAENA;

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x5697D00", Offset = "0x5697100", VA = "0x185697D00")]
		public IFJFDPOPGDD(ECGIAGCEELD ICDINJIMJPC, int EBLICLHHKFK, int POEPDMLAENA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x75FD1F0", Offset = "0x75FC5F0", VA = "0x1875FD1F0")]
		public IFJFDPOPGDD CONKKCDEMEH(ReadOnlySpan<byte> MJFOKKFMONL)
		{
			return default(IFJFDPOPGDD);
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x3B551B0", Offset = "0x3B545B0", VA = "0x183B551B0")]
		public IFJFDPOPGDD CONKKCDEMEH<T>(T MJFOKKFMONL) where T : struct
		{
			return default(IFJFDPOPGDD);
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x75FD250", Offset = "0x75FC650", VA = "0x1875FD250", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private NFHHBMPMEMJ LGIKFOFADHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private NativeParallelHashMap<int, AOIKGLJHPKL> NBKCBIBCKOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private NativeList<byte> MJFOKKFMONL;

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x75FCFC0", Offset = "0x75FC3C0", VA = "0x1875FCFC0")]
	public ECGIAGCEELD(NFHHBMPMEMJ LGIKFOFADHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x75FCED0", Offset = "0x75FC2D0", VA = "0x1875FCED0")]
	public int MLENNKCBOPG(JOHFIMIOIAA PLMEPNACBMF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x75FCBB0", Offset = "0x75FBFB0", VA = "0x1875FCBB0")]
	public IFJFDPOPGDD BONDNIJOJMO(JOHFIMIOIAA PLMEPNACBMF)
	{
		return default(IFJFDPOPGDD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x75FCB00", Offset = "0x75FBF00", VA = "0x1875FCB00")]
	public IFJFDPOPGDD BONDNIJOJMO(int MNFLMJIOJHC)
	{
		return default(IFJFDPOPGDD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x75FCDA0", Offset = "0x75FC1A0", VA = "0x1875FCDA0")]
	public void LPJNLMJAAPM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x75FCD00", Offset = "0x75FC100", VA = "0x1875FCD00")]
	public ECGIAGCEELD FGPIGKDDHPD()
	{
		return default(ECGIAGCEELD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x75FCCA0", Offset = "0x75FC0A0", VA = "0x1875FCCA0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public static class DIGKAONNNFP
{
	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x32D5760", Offset = "0x32D4B60", VA = "0x1832D5760")]
	public static ECGIAGCEELD KAAHFJDOOLK<T>([In] this ECGIAGCEELD ICDINJIMJPC, AAFDJAOJKML<T> PLMEPNACBMF, T PEBNJNGMMHE)
	{
		return default(ECGIAGCEELD);
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
