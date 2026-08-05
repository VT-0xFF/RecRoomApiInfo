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
		[Cpp2IlInjected.Address(RVA = "0x9D7E50", Offset = "0x9D6850", VA = "0x1809D7E50")]
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
		[Cpp2IlInjected.Address(RVA = "0x9D7E50", Offset = "0x9D6850", VA = "0x1809D7E50")]
		public IsUnmanagedAttribute()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
[AttributeUsage(AttributeTargets.Class)]
public class GCPKOAIHHOI : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x9D7E50", Offset = "0x9D6850", VA = "0x1809D7E50")]
	public GCPKOAIHHOI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
[AttributeUsage(AttributeTargets.Class)]
public class NPJLNGMMDGL : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x79227C0", Offset = "0x79211C0", VA = "0x1879227C0")]
	public NPJLNGMMDGL(int PICLDLMFMMM, int GNJBONMDFOP, int LDMIJBGHBCG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[AttributeUsage(AttributeTargets.Class)]
public class CIEFEAEBHFA : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x9D84D0", Offset = "0x9D6ED0", VA = "0x1809D84D0")]
	public CIEFEAEBHFA(bool PACFHJLLAEJ = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
[AttributeUsage(AttributeTargets.Class)]
public class PBNFDPILMHO : RegisterType
{
	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x7922910", Offset = "0x7921310", VA = "0x187922910")]
	public PBNFDPILMHO(string EMLAIMJKHOE, string NMJGNNNOHKB = "")
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
[AttributeUsage(AttributeTargets.Class)]
public class LHBLGNAAHNL : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int ABKPALEDJBA
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x9AC1A0", Offset = "0x9AABA0", VA = "0x1809AC1A0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x206ACB0", Offset = "0x20696B0", VA = "0x18206ACB0")]
	public LHBLGNAAHNL(int PPJFMHBDGNA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
[Flags]
public enum FOILGMIHJNH
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
public interface MMKJIEJAOOK
{
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface JDMDNAEGAML<T> : MMKJIEJAOOK
{
	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void KHBHEAPLAIM([In] INAJGFCNEJM IIDGBHKFKEK, T PPJFMHBDGNA);
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface DPJHMODHLBI : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	bool BOEKNPCABAN
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	int LNCHKAIGHBN
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	int BNDNHKAADKD(Type OHCGINPDMEI);

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void DDGHEEELBFC(NativeParallelHashMap<int, FOFEFKICODD> BAKNOLAPDBG, NativeArray<byte> DFPGGEDGGGN);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface IIKGOHLIAFN
{
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public sealed class MOGLFDBPFLE
{
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public abstract class NGGOLIHGPGD<T> : IADAKPEBAPF<T> where T : struct, Enum
{
	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x431C530", Offset = "0x431AF30", VA = "0x18431C530")]
	protected NGGOLIHGPGD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public abstract class IADAKPEBAPF<T> : JDMDNAEGAML<T>, MMKJIEJAOOK where T : struct
{
	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x48860D0", Offset = "0x4884AD0", VA = "0x1848860D0")]
	public void KHBHEAPLAIM([In] INAJGFCNEJM IIDGBHKFKEK, T PPJFMHBDGNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x9B1770", Offset = "0x9B0170", VA = "0x1809B1770")]
	protected IADAKPEBAPF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x4886540", Offset = "0x4884F40", VA = "0x184886540", Slot = "4")]
	private void NMNOPKOMMHB([In] INAJGFCNEJM IIDGBHKFKEK, T PPJFMHBDGNA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public abstract class PAAPKOOBLMM<T> : JDMDNAEGAML<NativeArray<T>>, MMKJIEJAOOK where T : struct
{
	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x53C12E0", Offset = "0x53BFCE0", VA = "0x1853C12E0")]
	public void KHBHEAPLAIM([In] INAJGFCNEJM IIDGBHKFKEK, NativeArray<T> PPJFMHBDGNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x37F40A0", Offset = "0x37F2AA0", VA = "0x1837F40A0")]
	public static ReadOnlySpan<T> HKCNMEFCKLB<T>(NativeArray<T> NAKGFAINKPB) where T : struct
	{
		return default(ReadOnlySpan<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x9B1770", Offset = "0x9B0170", VA = "0x1809B1770")]
	protected PAAPKOOBLMM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x53C1290", Offset = "0x53BFC90", VA = "0x1853C1290", Slot = "4")]
	private void CDBCIBCMMFB([In] INAJGFCNEJM IIDGBHKFKEK, NativeArray<T> PPJFMHBDGNA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class CMGMIGMLKMP : JDMDNAEGAML<CMGMIGMLKMP.GAMDEFIDBHL>, MMKJIEJAOOK
{
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public struct GAMDEFIDBHL
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x9AE060", Offset = "0x9ACA60", VA = "0x1809AE060")]
	public void KHBHEAPLAIM([In] INAJGFCNEJM IIDGBHKFKEK, GAMDEFIDBHL PPJFMHBDGNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x9B1770", Offset = "0x9B0170", VA = "0x1809B1770")]
	public CMGMIGMLKMP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x9AE060", Offset = "0x9ACA60", VA = "0x1809AE060", Slot = "4")]
	private void JLFCHMFOECH([In] INAJGFCNEJM IIDGBHKFKEK, GAMDEFIDBHL PPJFMHBDGNA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class HGPIBBODGJD : JDMDNAEGAML<string>, MMKJIEJAOOK
{
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public static readonly HGPIBBODGJD LALLOKGAEJH;

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x7921D60", Offset = "0x7920760", VA = "0x187921D60")]
	public void KHBHEAPLAIM([In] INAJGFCNEJM IIDGBHKFKEK, string PPJFMHBDGNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x9B1770", Offset = "0x9B0170", VA = "0x1809B1770")]
	public HGPIBBODGJD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x7921D50", Offset = "0x7920750", VA = "0x187921D50", Slot = "4")]
	private void IEOHKFKMPBE([In] INAJGFCNEJM IIDGBHKFKEK, string PPJFMHBDGNA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public abstract class IIFEONGLAPJ<T> : GDLGOJPFADE<T> where T : struct, IComparable<T>
{
	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x431C530", Offset = "0x431AF30", VA = "0x18431C530")]
	protected IIFEONGLAPJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public abstract class GDLGOJPFADE<T> : JDMDNAEGAML<T>, MMKJIEJAOOK where T : struct
{
	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x4886290", Offset = "0x4884C90", VA = "0x184886290")]
	public void KHBHEAPLAIM([In] INAJGFCNEJM IIDGBHKFKEK, T PPJFMHBDGNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x9B1770", Offset = "0x9B0170", VA = "0x1809B1770")]
	protected GDLGOJPFADE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x4886540", Offset = "0x4884F40", VA = "0x184886540", Slot = "4")]
	private void NMNOPKOMMHB([In] INAJGFCNEJM IIDGBHKFKEK, T PPJFMHBDGNA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public struct INAJGFCNEJM : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public readonly struct OEPOHEMEPOL : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private readonly INAJGFCNEJM IIDGBHKFKEK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private readonly int BKIEABHMHAI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private readonly int HBADDCKJDNG;

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x59B5D90", Offset = "0x59B4790", VA = "0x1859B5D90")]
		public OEPOHEMEPOL(INAJGFCNEJM IIDGBHKFKEK, int BKIEABHMHAI, int HBADDCKJDNG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x7922810", Offset = "0x7921210", VA = "0x187922810")]
		public OEPOHEMEPOL APPDCIMCGAP(ReadOnlySpan<byte> DFPGGEDGGGN)
		{
			return default(OEPOHEMEPOL);
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x3D4CE10", Offset = "0x3D4B810", VA = "0x183D4CE10")]
		public OEPOHEMEPOL APPDCIMCGAP<T>(T DFPGGEDGGGN) where T : struct
		{
			return default(OEPOHEMEPOL);
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x7922870", Offset = "0x7921270", VA = "0x187922870", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private DPJHMODHLBI JOGMADANJPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private NativeParallelHashMap<int, FOFEFKICODD> BAKNOLAPDBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private NativeList<byte> DFPGGEDGGGN;

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x79225E0", Offset = "0x7920FE0", VA = "0x1879225E0")]
	public INAJGFCNEJM(DPJHMODHLBI JOGMADANJPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x7922350", Offset = "0x7920D50", VA = "0x187922350")]
	public int IDHKIEHFAPP(MMKJIEJAOOK LGMJFLOIPKK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x7922440", Offset = "0x7920E40", VA = "0x187922440")]
	public OEPOHEMEPOL PDICLOJNGME(MMKJIEJAOOK LGMJFLOIPKK)
	{
		return default(OEPOHEMEPOL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x7922530", Offset = "0x7920F30", VA = "0x187922530")]
	public OEPOHEMEPOL PDICLOJNGME(int EHJMMCIGFNO)
	{
		return default(OEPOHEMEPOL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x7922120", Offset = "0x7920B20", VA = "0x187922120")]
	public void BPJNPCBNDJL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x7922250", Offset = "0x7920C50", VA = "0x187922250")]
	public INAJGFCNEJM DDDFCMLAOKM()
	{
		return default(INAJGFCNEJM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x79222F0", Offset = "0x7920CF0", VA = "0x1879222F0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public static class MMDGOOBCDEL
{
	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x3754DA0", Offset = "0x37537A0", VA = "0x183754DA0")]
	public static INAJGFCNEJM HEHCILJMFIP<T>([In] this INAJGFCNEJM IIDGBHKFKEK, JDMDNAEGAML<T> LGMJFLOIPKK, T PPJFMHBDGNA)
	{
		return default(INAJGFCNEJM);
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
