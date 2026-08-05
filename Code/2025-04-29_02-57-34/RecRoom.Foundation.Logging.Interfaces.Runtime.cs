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
		[Cpp2IlInjected.Address(RVA = "0x9F4500", Offset = "0x9F3900", VA = "0x1809F4500")]
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
		[Cpp2IlInjected.Address(RVA = "0x9F4500", Offset = "0x9F3900", VA = "0x1809F4500")]
		public IsUnmanagedAttribute()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
[AttributeUsage(AttributeTargets.Class)]
public class GMGMMJJNFGN : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x9F4500", Offset = "0x9F3900", VA = "0x1809F4500")]
	public GMGMMJJNFGN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
[AttributeUsage(AttributeTargets.Class)]
public class PAHLGLIIMPK : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x7B15390", Offset = "0x7B14790", VA = "0x187B15390")]
	public PAHLGLIIMPK(int LLBNOFGPNDN, int AJNCGCJPLAF, int HNMIGALEMPB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[AttributeUsage(AttributeTargets.Class)]
public class DPOEGLBKMNC : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x9F5380", Offset = "0x9F4780", VA = "0x1809F5380")]
	public DPOEGLBKMNC(bool ELIHIDEMDAH = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
[AttributeUsage(AttributeTargets.Class)]
public class GBOEKBEHPHL : RegisterType
{
	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x7B14F60", Offset = "0x7B14360", VA = "0x187B14F60")]
	public GBOEKBEHPHL(string KCCMEIDBNGP, string IKFIIFEGFHM = "")
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
[AttributeUsage(AttributeTargets.Class)]
public class FGMDCHACGIG : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int APFNDOMNAPN
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x9C91A0", Offset = "0x9C85A0", VA = "0x1809C91A0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x20D4E20", Offset = "0x20D4220", VA = "0x1820D4E20")]
	public FGMDCHACGIG(int OOEMJLHLIHJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
[Flags]
public enum OJILAHEFCOG
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
public interface MFANDCHEDHA
{
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface LLAJGNDCIFA<T> : MFANDCHEDHA
{
	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void IKIGLPEKNBK([In] CCOJFIJBEPG LEMJKLBLFNK, T OOEMJLHLIHJ);
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface OACFDCNKINB : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	bool NJPIKAKJEBL
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	int HNPBBLIMDJL
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	int MIPLNKPOBBH(Type KHNCICOHHHJ);

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void INGDDFLEMJB(NativeParallelHashMap<int, OIJNMGBLDKP> OGPEFHDLAJP, NativeArray<byte> AOFGGGKINCN);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface BKILABHKBHD
{
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public sealed class JIHHMDLKCGK
{
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public abstract class LKGDKLKCKDP<T> : EDKKJMOALHB<T> where T : struct, Enum
{
	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x434E6A0", Offset = "0x434DAA0", VA = "0x18434E6A0")]
	protected LKGDKLKCKDP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public abstract class EDKKJMOALHB<T> : LLAJGNDCIFA<T>, MFANDCHEDHA where T : struct
{
	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x4382A20", Offset = "0x4381E20", VA = "0x184382A20")]
	public void IKIGLPEKNBK([In] CCOJFIJBEPG LEMJKLBLFNK, T OOEMJLHLIHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x9D3E50", Offset = "0x9D3250", VA = "0x1809D3E50")]
	protected EDKKJMOALHB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x4382B00", Offset = "0x4381F00", VA = "0x184382B00", Slot = "4")]
	private void MAJCMHKOLLC([In] CCOJFIJBEPG LEMJKLBLFNK, T OOEMJLHLIHJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public abstract class FDDHNAKHIBI<T> : LLAJGNDCIFA<NativeArray<T>>, MFANDCHEDHA where T : struct
{
	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x47D09E0", Offset = "0x47CFDE0", VA = "0x1847D09E0")]
	public void IKIGLPEKNBK([In] CCOJFIJBEPG LEMJKLBLFNK, NativeArray<T> OOEMJLHLIHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x3867640", Offset = "0x3866A40", VA = "0x183867640")]
	public static ReadOnlySpan<T> EMLEFPBFHAA<T>(NativeArray<T> IMLJIFPAFGH) where T : struct
	{
		return default(ReadOnlySpan<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x9D3E50", Offset = "0x9D3250", VA = "0x1809D3E50")]
	protected FDDHNAKHIBI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x47D0990", Offset = "0x47CFD90", VA = "0x1847D0990", Slot = "4")]
	private void HMALEPFIDAL([In] CCOJFIJBEPG LEMJKLBLFNK, NativeArray<T> OOEMJLHLIHJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class MBHJLBGEIAH : LLAJGNDCIFA<MBHJLBGEIAH.JNHIEHEFKMI>, MFANDCHEDHA
{
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public struct JNHIEHEFKMI
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x9CB230", Offset = "0x9CA630", VA = "0x1809CB230")]
	public void IKIGLPEKNBK([In] CCOJFIJBEPG LEMJKLBLFNK, JNHIEHEFKMI OOEMJLHLIHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x9D3E50", Offset = "0x9D3250", VA = "0x1809D3E50")]
	public MBHJLBGEIAH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x9CB230", Offset = "0x9CA630", VA = "0x1809CB230", Slot = "4")]
	private void MLJDJAGALFM([In] CCOJFIJBEPG LEMJKLBLFNK, JNHIEHEFKMI OOEMJLHLIHJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class IMGOALPLAPK : LLAJGNDCIFA<string>, MFANDCHEDHA
{
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public static readonly IMGOALPLAPK IADGMEFIGGI;

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x7B14FC0", Offset = "0x7B143C0", VA = "0x187B14FC0")]
	public void IKIGLPEKNBK([In] CCOJFIJBEPG LEMJKLBLFNK, string OOEMJLHLIHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x9D3E50", Offset = "0x9D3250", VA = "0x1809D3E50")]
	public IMGOALPLAPK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x7B14FB0", Offset = "0x7B143B0", VA = "0x187B14FB0", Slot = "4")]
	private void CJJHDCCPPGM([In] CCOJFIJBEPG LEMJKLBLFNK, string OOEMJLHLIHJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public abstract class KOIOBOJEBCH<T> : BHIDHMOHHMA<T> where T : struct, IComparable<T>
{
	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x434E6A0", Offset = "0x434DAA0", VA = "0x18434E6A0")]
	protected KOIOBOJEBCH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public abstract class BHIDHMOHHMA<T> : LLAJGNDCIFA<T>, MFANDCHEDHA where T : struct
{
	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x5F95830", Offset = "0x5F94C30", VA = "0x185F95830")]
	public void IKIGLPEKNBK([In] CCOJFIJBEPG LEMJKLBLFNK, T OOEMJLHLIHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x9D3E50", Offset = "0x9D3250", VA = "0x1809D3E50")]
	protected BHIDHMOHHMA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x4382B00", Offset = "0x4381F00", VA = "0x184382B00", Slot = "4")]
	private void MAJCMHKOLLC([In] CCOJFIJBEPG LEMJKLBLFNK, T OOEMJLHLIHJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public struct CCOJFIJBEPG : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public readonly struct AOANCANMPEL : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private readonly CCOJFIJBEPG LEMJKLBLFNK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private readonly int BNBLDALNDKK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private readonly int AMAGLJDPNNK;

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x5AED330", Offset = "0x5AEC730", VA = "0x185AED330")]
		public AOANCANMPEL(CCOJFIJBEPG LEMJKLBLFNK, int BNBLDALNDKK, int AMAGLJDPNNK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x7B147B0", Offset = "0x7B13BB0", VA = "0x187B147B0")]
		public AOANCANMPEL AHBKDABMBLH(ReadOnlySpan<byte> AOFGGGKINCN)
		{
			return default(AOANCANMPEL);
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x3DDB9E0", Offset = "0x3DDADE0", VA = "0x183DDB9E0")]
		public AOANCANMPEL AHBKDABMBLH<T>(T AOFGGGKINCN) where T : struct
		{
			return default(AOANCANMPEL);
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x7B14810", Offset = "0x7B13C10", VA = "0x187B14810", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private OACFDCNKINB GKOJHOAHNED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private NativeParallelHashMap<int, OIJNMGBLDKP> OGPEFHDLAJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private NativeList<byte> AOFGGGKINCN;

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x7B14D70", Offset = "0x7B14170", VA = "0x187B14D70")]
	public CCOJFIJBEPG(OACFDCNKINB GKOJHOAHNED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x7B14AE0", Offset = "0x7B13EE0", VA = "0x187B14AE0")]
	public int PEFHEIBBBAB(MFANDCHEDHA EKNFDDNNCCO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x7B14BD0", Offset = "0x7B13FD0", VA = "0x187B14BD0")]
	public AOANCANMPEL POINCIDDIAI(MFANDCHEDHA EKNFDDNNCCO)
	{
		return default(AOANCANMPEL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x7B14CC0", Offset = "0x7B140C0", VA = "0x187B14CC0")]
	public AOANCANMPEL POINCIDDIAI(int KGBAEDOHIBJ)
	{
		return default(AOANCANMPEL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x7B14910", Offset = "0x7B13D10", VA = "0x187B14910")]
	public void KEONIDJGMED()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x7B14A40", Offset = "0x7B13E40", VA = "0x187B14A40")]
	public CCOJFIJBEPG KOCPBONGJHC()
	{
		return default(CCOJFIJBEPG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x7B148B0", Offset = "0x7B13CB0", VA = "0x187B148B0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public static class DAFBHFIABBD
{
	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x34FAB00", Offset = "0x34F9F00", VA = "0x1834FAB00")]
	public static CCOJFIJBEPG FGAAHPGCDNG<T>([In] this CCOJFIJBEPG LEMJKLBLFNK, LLAJGNDCIFA<T> EKNFDDNNCCO, T OOEMJLHLIHJ)
	{
		return default(CCOJFIJBEPG);
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
