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
[AttributeUsage(AttributeTargets.Class)]
public class ODCPMDPGHEM : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0xA1A8A0", Offset = "0xA19AA0", VA = "0x180A1A8A0")]
	public ODCPMDPGHEM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
[AttributeUsage(AttributeTargets.Class)]
public class IJCNBDJPDLL : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x7CAE8E0", Offset = "0x7CADAE0", VA = "0x187CAE8E0")]
	public IJCNBDJPDLL(int JAFKPMJIGFL, int IKNOBPPKGDD, int APHPAAMJLLC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[AttributeUsage(AttributeTargets.Class)]
public class HECMMIEFCGK : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0xA1B7B0", Offset = "0xA1A9B0", VA = "0x180A1B7B0")]
	public HECMMIEFCGK(bool NBKBPBICMLB = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
[AttributeUsage(AttributeTargets.Class)]
public class JHFOENBELBE : RegisterType
{
	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x7CAE930", Offset = "0x7CADB30", VA = "0x187CAE930")]
	public JHFOENBELBE(string DGIAFBEDPNJ, string CMDDDPOOGFO = "")
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
[AttributeUsage(AttributeTargets.Class)]
public class HDPBNCMMFJA : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int ABLHJAOAOGP
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x9EF1A0", Offset = "0x9EE3A0", VA = "0x1809EF1A0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x217A920", Offset = "0x2179B20", VA = "0x18217A920")]
	public HDPBNCMMFJA(int MLCDCHNOCFI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
[Flags]
public enum NKGMIBAHLKM
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
public interface IDMODGMNOBK
{
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface CCNMPJMHPNM<T> : IDMODGMNOBK
{
	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PCGNEAOCADF([In] HGAFIGENIDF PMEFDCNDBEI, T MLCDCHNOCFI);
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface BGEANPDKOJA : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	bool OANBOBBNJPI
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	int IPOMEGCIEIE
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	int KIBGFMGFMJC(Type EDLOHJEBKFM);

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void LBEDGOIFOPN(NativeParallelHashMap<int, GDHEFDIGGIJ> IKOPOIHFBKC, NativeArray<byte> DHAOEHNLNON);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface MHPPNNBIOKO
{
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public sealed class AKJOCCMPNOG
{
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public abstract class HBDEFJCJCKI<T> : HJOMLDBFJJE<T> where T : struct, Enum
{
	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x44F4310", Offset = "0x44F3510", VA = "0x1844F4310")]
	protected HBDEFJCJCKI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public abstract class HJOMLDBFJJE<T> : CCNMPJMHPNM<T>, IDMODGMNOBK where T : struct
{
	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x4B9F480", Offset = "0x4B9E680", VA = "0x184B9F480")]
	public void PCGNEAOCADF([In] HGAFIGENIDF PMEFDCNDBEI, T MLCDCHNOCFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
	protected HJOMLDBFJJE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x4B9F440", Offset = "0x4B9E640", VA = "0x184B9F440", Slot = "4")]
	private void FAKDEFEIIGF([In] HGAFIGENIDF PMEFDCNDBEI, T MLCDCHNOCFI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public abstract class CILCDCACCLE<T> : CCNMPJMHPNM<NativeArray<T>>, IDMODGMNOBK where T : struct
{
	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x654B850", Offset = "0x654AA50", VA = "0x18654B850")]
	public void PCGNEAOCADF([In] HGAFIGENIDF PMEFDCNDBEI, NativeArray<T> MLCDCHNOCFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x398FAC0", Offset = "0x398ECC0", VA = "0x18398FAC0")]
	public static ReadOnlySpan<T> FJILBGCJDHL<T>(NativeArray<T> CABEAFGDMFF) where T : struct
	{
		return default(ReadOnlySpan<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
	protected CILCDCACCLE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x654B800", Offset = "0x654AA00", VA = "0x18654B800", Slot = "4")]
	private void EFIGNPGJBLI([In] HGAFIGENIDF PMEFDCNDBEI, NativeArray<T> MLCDCHNOCFI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class ACKFPGEKGJL : CCNMPJMHPNM<ACKFPGEKGJL.KCJFFIPONML>, IDMODGMNOBK
{
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public struct KCJFFIPONML
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0")]
	public void PCGNEAOCADF([In] HGAFIGENIDF PMEFDCNDBEI, KCJFFIPONML MLCDCHNOCFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
	public ACKFPGEKGJL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0", Slot = "4")]
	private void PNAIMEGNEPP([In] HGAFIGENIDF PMEFDCNDBEI, KCJFFIPONML MLCDCHNOCFI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class OFPIOGPNFFK : CCNMPJMHPNM<string>, IDMODGMNOBK
{
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public static readonly OFPIOGPNFFK NDDGJHHDBNJ;

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x7CAEA90", Offset = "0x7CADC90", VA = "0x187CAEA90")]
	public void PCGNEAOCADF([In] HGAFIGENIDF PMEFDCNDBEI, string MLCDCHNOCFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
	public OFPIOGPNFFK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x7CAEA80", Offset = "0x7CADC80", VA = "0x187CAEA80", Slot = "4")]
	private void CJIOIOLCGBO([In] HGAFIGENIDF PMEFDCNDBEI, string MLCDCHNOCFI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public abstract class DPEDMIPOMCC<T> : LIDEGMFBAFE<T> where T : struct, IComparable<T>
{
	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x44F4310", Offset = "0x44F3510", VA = "0x1844F4310")]
	protected DPEDMIPOMCC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public abstract class LIDEGMFBAFE<T> : CCNMPJMHPNM<T>, IDMODGMNOBK where T : struct
{
	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x50D25F0", Offset = "0x50D17F0", VA = "0x1850D25F0")]
	public void PCGNEAOCADF([In] HGAFIGENIDF PMEFDCNDBEI, T MLCDCHNOCFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
	protected LIDEGMFBAFE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x4B9F440", Offset = "0x4B9E640", VA = "0x184B9F440", Slot = "4")]
	private void FAKDEFEIIGF([In] HGAFIGENIDF PMEFDCNDBEI, T MLCDCHNOCFI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public struct HGAFIGENIDF : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public readonly struct NAAMOACJCHF : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private readonly HGAFIGENIDF PMEFDCNDBEI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private readonly int HKAKCHMGJLL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private readonly int MMMPPPJAFGP;

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x5C6C5E0", Offset = "0x5C6B7E0", VA = "0x185C6C5E0")]
		public NAAMOACJCHF(HGAFIGENIDF PMEFDCNDBEI, int HKAKCHMGJLL, int MMMPPPJAFGP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x7CAEA20", Offset = "0x7CADC20", VA = "0x187CAEA20")]
		public NAAMOACJCHF EDDMLGEHMIO(ReadOnlySpan<byte> DHAOEHNLNON)
		{
			return default(NAAMOACJCHF);
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x3F9CE80", Offset = "0x3F9C080", VA = "0x183F9CE80")]
		public NAAMOACJCHF EDDMLGEHMIO<T>(T DHAOEHNLNON) where T : struct
		{
			return default(NAAMOACJCHF);
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x7CAE980", Offset = "0x7CADB80", VA = "0x187CAE980", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private BGEANPDKOJA JPLLHKJOCLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private NativeParallelHashMap<int, GDHEFDIGGIJ> IKOPOIHFBKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private NativeList<byte> DHAOEHNLNON;

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x7CAE710", Offset = "0x7CAD910", VA = "0x187CAE710")]
	public HGAFIGENIDF(BGEANPDKOJA JPLLHKJOCLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x7CAE2C0", Offset = "0x7CAD4C0", VA = "0x187CAE2C0")]
	public int EGOEHMNFAEG(IDMODGMNOBK BMKNJFOIIEM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x7CAE580", Offset = "0x7CAD780", VA = "0x187CAE580")]
	public NAAMOACJCHF KPCBFMBJLNJ(IDMODGMNOBK BMKNJFOIIEM)
	{
		return default(NAAMOACJCHF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x7CAE4D0", Offset = "0x7CAD6D0", VA = "0x187CAE4D0")]
	public NAAMOACJCHF KPCBFMBJLNJ(int HMPHCCFLFBL)
	{
		return default(NAAMOACJCHF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x7CAE3A0", Offset = "0x7CAD5A0", VA = "0x187CAE3A0")]
	public void FOHJPDGGHJE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x7CAE670", Offset = "0x7CAD870", VA = "0x187CAE670")]
	public HGAFIGENIDF PCMJMPFBLNN()
	{
		return default(HGAFIGENIDF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x7CAE260", Offset = "0x7CAD460", VA = "0x187CAE260", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public static class FKJJOEHNDHE
{
	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x3804B80", Offset = "0x3803D80", VA = "0x183804B80")]
	public static HGAFIGENIDF OOLDDNFEGEK<T>([In] this HGAFIGENIDF PMEFDCNDBEI, CCNMPJMHPNM<T> BMKNJFOIIEM, T MLCDCHNOCFI)
	{
		return default(HGAFIGENIDF);
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
