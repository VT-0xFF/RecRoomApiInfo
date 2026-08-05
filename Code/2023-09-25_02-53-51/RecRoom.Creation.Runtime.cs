using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Google.Protobuf;
using Microsoft.CodeAnalysis;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
namespace Microsoft.CodeAnalysis
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class EmbeddedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x78D520", Offset = "0x78C920", VA = "0x18078D520")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter, AllowMultiple = false, Inherited = false)]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x5C95A70", Offset = "0x5C94E70", VA = "0x185C95A70")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x78E300", Offset = "0x78D700", VA = "0x18078E300")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x78E340", Offset = "0x78D740", VA = "0x18078E340")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class IOFBIJCLMML
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x5C93D50", Offset = "0x5C93150", VA = "0x185C93D50")]
	public static bool EDFDCEJAANJ(EOLOILDHMCA FENBMCMKKPH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x5C939A0", Offset = "0x5C92DA0", VA = "0x185C939A0")]
	private static bool EDFDCEJAANJ(KJLNBLCLDOG KIOBBALPIHB, EOLOILDHMCA FENBMCMKKPH)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public readonly struct EGMMDDPFNPI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public readonly BCIEEEAOHOF HMFFELCEKAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public readonly IEnumerable<DAJJDHFICPI> EPGEDPLLMBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public readonly IReadOnlyList<DAJJDHFICPI> NFFBOGPBIJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public readonly IReadOnlyList<MIPNFHKLOLI<EHDOJPLINGC>> ONNJPLLLMNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public readonly ByteString PJLDGFHDGGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public readonly HCKHNCKIMEB PHEOKNIAPDG;

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x5C92E10", Offset = "0x5C92210", VA = "0x185C92E10")]
	public EGMMDDPFNPI(BCIEEEAOHOF EJMBOKJJOKM, IEnumerable<DAJJDHFICPI> FCLGCMFKGNJ, IReadOnlyList<DAJJDHFICPI> DPBABDOFHFJ, IReadOnlyList<MIPNFHKLOLI<EHDOJPLINGC>> OHMMGCMPKMK, ByteString FDPLHLAKEGO, HCKHNCKIMEB LFJJHMBODKI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface HILJKPEHMNG
{
	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void InitializeNewGraph(LFCBDELLCLD OOIBMCBCEPD, [Out] Dictionary<int, int> MNJHJIPPPMJ);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void RunPreInitializationMigration(DAACELPKEHI HNIEOLDAJFB, OECHPGKDCME ONHMIFELPOL);
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public class BGIJLNGPCMI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public readonly Guid CLMLNNDJMJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly Dictionary<Guid, Guid> AEDLAALNDNF;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public IReadOnlyDictionary<Guid, Guid> LPDPOJMEDEN
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x76B410", Offset = "0x76A810", VA = "0x18076B410")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x318FD40", Offset = "0x318F140", VA = "0x18318FD40")]
	private BGIJLNGPCMI([In] Guid CCONLFLBHKI, Dictionary<Guid, Guid> DENIOBALHGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x5C913F0", Offset = "0x5C907F0", VA = "0x185C913F0")]
	public static BGIJLNGPCMI CGOGPFIADKC(IReadOnlyDictionary<Guid, Guid> HCPLEKPBADM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x5C914B0", Offset = "0x5C908B0", VA = "0x185C914B0")]
	public static BGIJLNGPCMI FNINLGCGMAI(IEnumerable<KeyValuePair<Guid, Guid>> HCPLEKPBADM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x5C91400", Offset = "0x5C90800", VA = "0x185C91400")]
	private static Dictionary<Guid, Guid> FCLDBDLHDAM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x5C918D0", Offset = "0x5C90CD0", VA = "0x185C918D0")]
	public Guid KJADHLDCIPC([In] Guid HILDEDLDEPK, bool CNFHCJEDGBH)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x5C91860", Offset = "0x5C90C60", VA = "0x185C91860")]
	public bool KDAHLGFABKN([In] Guid KOJKDECJOKK, [Out] Guid DDJPGOIHOBP)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface BLMHABIMPBI : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	bool ENLBFFMNMKN
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void HNNKJEMPCFP(ByteString KHPJJNGKJGC, BGIJLNGPCMI AEIDKKIEPOL, [In] CJOBJHHCGGP DPDMGNEEHGG);
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface DOONNPBMJJG
{
	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IEnumerable<ByteString> GetValidRoomKeyReplicationIds();

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IEnumerable<ByteString> GetValidRoomCurrencies();

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(Slot = "2")]
	IEnumerable<ByteString> GetValidRoomConsumables();
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public sealed class GBJIFEDHFNE
{
	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public IReadOnlyDictionary<Guid, Guid> KEDMJCCGMKG
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x764450", Offset = "0x763850", VA = "0x180764450")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public IReadOnlyDictionary<Guid, Guid> FILIJLCBALO
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x767230", Offset = "0x766630", VA = "0x180767230")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x769080", Offset = "0x768480", VA = "0x180769080")]
	public GBJIFEDHFNE(IReadOnlyDictionary<Guid, Guid> LNKGNEPJJCC, IReadOnlyDictionary<Guid, Guid> HDNEEPNDPCF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public static class PAPINDGAAMC
{
	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x5C98520", Offset = "0x5C97920", VA = "0x185C98520")]
	public static NKFBCEKJGEC OCOBGFBGGIL([In] EGMMDDPFNPI DFFGBJOOEOM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x5C970E0", Offset = "0x5C964E0", VA = "0x185C970E0")]
	private static void GEGPHLLAFKD(NKFBCEKJGEC DOPFMEHBGAI, [In] EGMMDDPFNPI KFILKDCBGPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x5C95AF0", Offset = "0x5C94EF0", VA = "0x185C95AF0")]
	public static bool ALAPLNBCFLG(NKFBCEKJGEC DOPFMEHBGAI, IEEFINDCNPB OBBFKDKGMMM, [Out] GBJIFEDHFNE? DENIOBALHGO, [Out] string? NJAPBBBJJNP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x5C96DE0", Offset = "0x5C961E0", VA = "0x185C96DE0")]
	private static void AMEKALDJAAM(NKFBCEKJGEC DOPFMEHBGAI, BGIJLNGPCMI? BEDKGOACLBP, IEEFINDCNPB OBBFKDKGMMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x5C97070", Offset = "0x5C96470", VA = "0x185C97070")]
	private static void FHFEOAIFONN(NKFBCEKJGEC DOPFMEHBGAI, IEEFINDCNPB OBBFKDKGMMM, IReadOnlyCollection<ByteString>? KKFMAPJMKAD, IReadOnlyCollection<ByteString>? KCJJLGHEJFF, IReadOnlyCollection<ByteString>? ELDNNLELJMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x5C97740", Offset = "0x5C96B40", VA = "0x185C97740")]
	private static bool GLBPMEEFANI(NKFBCEKJGEC DOPFMEHBGAI, DAACELPKEHI HNIEOLDAJFB, IEEFINDCNPB OBBFKDKGMMM, [Out] string NJAPBBBJJNP, [Out] Dictionary<int, int> MNJHJIPPPMJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x5C98720", Offset = "0x5C97B20", VA = "0x185C98720")]
	private static Dictionary<Guid, KJLNBLCLDOG> PIMPHJPEAFD(NKFBCEKJGEC DOPFMEHBGAI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x5C98690", Offset = "0x5C97A90", VA = "0x185C98690")]
	private static void PDDMLABBEMC(bool LGDOBIONJGG, DAJJDHFICPI JINLJHLPIMH, Dictionary<Guid, Guid> GCAKHMKONGG, BGIJLNGPCMI ICPLJNPILJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x5C97DE0", Offset = "0x5C971E0", VA = "0x185C97DE0")]
	private static void KHAHNPDMCJF(DAJJDHFICPI JINLJHLPIMH, Guid ANBMIIKPDPO, ILMHLEIJOCN? IOHPJMNNCGB, Dictionary<Guid, KJLNBLCLDOG> IAALIODBBCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x5C98070", Offset = "0x5C97470", VA = "0x185C98070")]
	private static void MJJHKAJOANH(IEnumerable<DAJJDHFICPI> ENEGNOAODOO, IReadOnlyCollection<ByteString> KKFMAPJMKAD, IReadOnlyCollection<ByteString> KCJJLGHEJFF, IReadOnlyCollection<ByteString> ELDNNLELJMA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public struct IEEFINDCNPB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public bool LGDOBIONJGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public HCKHNCKIMEB LFJJHMBODKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public ILMHLEIJOCN? IOHPJMNNCGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public ILMHLEIJOCN? LDFIJEPOGOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public BCIEEEAOHOF JJMLILDPNOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public DOONNPBMJJG JOHMEAMIJDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public HILJKPEHMNG EEJAMOKGBMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public BLMHABIMPBI CPGABNPCCCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public MIPNFHKLOLI<IOFALGJHBGF> GLBGNLOGMAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	public AEKDMDCHPLL MFPGDLIIPCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public List<DAJJDHFICPI> OIPEJMDFBHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public Dictionary<string, object> AACPJGMJKOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public MPJLFCLCHFF NKOAMKHEEMP;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public bool NFNOHINFFBK
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x5C92F80", Offset = "0x5C92380", VA = "0x185C92F80")]
		get
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public struct ILMHLEIJOCN
{
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private const float GMGLCHJAMBK = 1f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public Vector3 BAONBICGOEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public Quaternion CKFJFCLIANA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public float IJMHENINMDB;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public Matrix4x4 MIBHHDMLJMP
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x5C931C0", Offset = "0x5C925C0", VA = "0x185C931C0")]
		get
		{
			return default(Matrix4x4);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public CJOBJHHCGGP OPHCDNDFLCJ
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x5C93800", Offset = "0x5C92C00", VA = "0x185C93800")]
		get
		{
			return default(CJOBJHHCGGP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x850500", Offset = "0x84F900", VA = "0x180850500")]
	public ILMHLEIJOCN(Vector3 BAONBICGOEJ, Quaternion CKFJFCLIANA, float IJMHENINMDB = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x5C93360", Offset = "0x5C92760", VA = "0x185C93360")]
	public static ILMHLEIJOCN NAJPDCILNAI(ILMHLEIJOCN DCLCDDGJKIC, ILMHLEIJOCN BOLAOFOJEPK)
	{
		return default(ILMHLEIJOCN);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x5C92FD0", Offset = "0x5C923D0", VA = "0x185C92FD0")]
	public static ILMHLEIJOCN DLNOOKJDMMJ((Vector3, Quaternion, float) OOIBMCBCEPD)
	{
		return default(ILMHLEIJOCN);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x5C92FF0", Offset = "0x5C923F0", VA = "0x185C92FF0")]
	public static ILMHLEIJOCN DLNOOKJDMMJ(Matrix4x4 MCJOANKFCAI)
	{
		return default(ILMHLEIJOCN);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x5C935E0", Offset = "0x5C929E0", VA = "0x185C935E0")]
	public ILMHLEIJOCN NLMCBDNJACJ(Matrix4x4 IJKPFNCIDCJ)
	{
		return default(ILMHLEIJOCN);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x5C93150", Offset = "0x5C92550", VA = "0x185C93150")]
	public static ILMHLEIJOCN ENLLJPIKOPF(Vector3 BAONBICGOEJ)
	{
		return default(ILMHLEIJOCN);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x5C932D0", Offset = "0x5C926D0", VA = "0x185C932D0")]
	public readonly IPABAODHIGJ KMBMLAGIHJE()
	{
		return default(IPABAODHIGJ);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public static class BFIPCAJIOPL
{
	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x5C91360", Offset = "0x5C90760", VA = "0x185C91360")]
	public static ILMHLEIJOCN BHDLKNOFKKP([In] this IPABAODHIGJ CLFMFOEGLFG)
	{
		return default(ILMHLEIJOCN);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public sealed class PFDHONLMEAM : AFFFHOEHDAE
{
	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x5C98AB0", Offset = "0x5C97EB0", VA = "0x185C98AB0", Slot = "4")]
	public void BLONOAECMHN(PCINEGOOCHP FBCEMNKCDOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x5C98E10", Offset = "0x5C98210", VA = "0x185C98E10")]
	private void NJIFMGJJKAN(Dictionary<Guid, Guid> KPFPOFPOKJA, FMJONCAKPIL CKMMBAONDMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x5C98B30", Offset = "0x5C97F30", VA = "0x185C98B30")]
	private void NJIFMGJJKAN(Dictionary<Guid, Guid> KPFPOFPOKJA, JFMIPMGHFAO BGOHEPDFLNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x5C98B90", Offset = "0x5C97F90", VA = "0x185C98B90")]
	private void NJIFMGJJKAN(Dictionary<Guid, Guid> KPFPOFPOKJA, FKAOAPOHDLM NJFHJFGCNAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x76DD90", Offset = "0x76D190", VA = "0x18076DD90")]
	public PFDHONLMEAM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public sealed class MABKJLBPEON : AFFFHOEHDAE
{
	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x5C95490", Offset = "0x5C94890", VA = "0x185C95490", Slot = "4")]
	public void BLONOAECMHN(PCINEGOOCHP FBCEMNKCDOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x76DD90", Offset = "0x76D190", VA = "0x18076DD90")]
	public MABKJLBPEON()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public sealed class INDOGFGDGFM : AFFFHOEHDAE
{
	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x5C93840", Offset = "0x5C92C40", VA = "0x185C93840", Slot = "4")]
	public void BLONOAECMHN(PCINEGOOCHP FBCEMNKCDOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x76DD90", Offset = "0x76D190", VA = "0x18076DD90")]
	public INDOGFGDGFM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public sealed class NLDHOCJPCIE : AFFFHOEHDAE
{
	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x5C95920", Offset = "0x5C94D20", VA = "0x185C95920", Slot = "4")]
	public void BLONOAECMHN(PCINEGOOCHP FBCEMNKCDOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x76DD90", Offset = "0x76D190", VA = "0x18076DD90")]
	public NLDHOCJPCIE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public sealed class KCIGKCCKGKN : AFFFHOEHDAE
{
	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x5C93D80", Offset = "0x5C93180", VA = "0x185C93D80", Slot = "4")]
	public void BLONOAECMHN(PCINEGOOCHP FBCEMNKCDOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x76DD90", Offset = "0x76D190", VA = "0x18076DD90")]
	public KCIGKCCKGKN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public sealed class DMJEPKMDMEH : AFFFHOEHDAE
{
	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x5C92CD0", Offset = "0x5C920D0", VA = "0x185C92CD0", Slot = "4")]
	public void BLONOAECMHN(PCINEGOOCHP FBCEMNKCDOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x76DD90", Offset = "0x76D190", VA = "0x18076DD90")]
	public DMJEPKMDMEH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public sealed class CBLLJIEBFCL : AFFFHOEHDAE
{
	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x5C92B30", Offset = "0x5C91F30", VA = "0x185C92B30", Slot = "4")]
	public void BLONOAECMHN(PCINEGOOCHP FBCEMNKCDOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x76DD90", Offset = "0x76D190", VA = "0x18076DD90")]
	public CBLLJIEBFCL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public sealed class EICJPFMNAMG : AFFFHOEHDAE
{
	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x5C92E90", Offset = "0x5C92290", VA = "0x185C92E90", Slot = "4")]
	public void BLONOAECMHN(PCINEGOOCHP FBCEMNKCDOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x76DD90", Offset = "0x76D190", VA = "0x18076DD90")]
	public EICJPFMNAMG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public sealed class MKMKNHKCEKL : AFFFHOEHDAE
{
	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x5C95630", Offset = "0x5C94A30", VA = "0x185C95630", Slot = "4")]
	public void BLONOAECMHN(PCINEGOOCHP FBCEMNKCDOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x76DD90", Offset = "0x76D190", VA = "0x18076DD90")]
	public MKMKNHKCEKL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public sealed class BPCFMAAKCGM : AFFFHOEHDAE
{
	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x5C92970", Offset = "0x5C91D70", VA = "0x185C92970", Slot = "4")]
	public void BLONOAECMHN(PCINEGOOCHP FBCEMNKCDOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x76DD90", Offset = "0x76D190", VA = "0x18076DD90")]
	public BPCFMAAKCGM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public sealed class MBJLIJPDOJC : AFFFHOEHDAE
{
	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x5C95530", Offset = "0x5C94930", VA = "0x185C95530", Slot = "4")]
	public void BLONOAECMHN(PCINEGOOCHP FBCEMNKCDOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x76DD90", Offset = "0x76D190", VA = "0x18076DD90")]
	public MBJLIJPDOJC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public sealed class NBGEDHFOADG : AFFFHOEHDAE
{
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public static readonly System.Random JCOKAKOEMFE;

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x5C957F0", Offset = "0x5C94BF0", VA = "0x185C957F0", Slot = "4")]
	public void BLONOAECMHN(PCINEGOOCHP FBCEMNKCDOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x76DD90", Offset = "0x76D190", VA = "0x18076DD90")]
	public NBGEDHFOADG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public struct EOLOILDHMCA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public DAACELPKEHI KAHINILDCOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public DKPMHCLIHPA CIGKKGDBNPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public Dictionary<int, int> HGGIFNHEKMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public Dictionary<Guid, Guid> HKBONAPANGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public MPJLFCLCHFF NKOAMKHEEMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public bool MHGHDIECJPA;
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public interface AFFFHOEHDAE
{
	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void BLONOAECMHN(PCINEGOOCHP FBCEMNKCDOB);
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class BJDGCAMPGFK
{
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private static readonly AFFFHOEHDAE[] NBFEFMMBBOD;

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x5C92110", Offset = "0x5C91510", VA = "0x185C92110")]
	public static void KPGGLGPKPII(DAJJDHFICPI OOIBMCBCEPD, Dictionary<Guid, Guid> EGMGDMBLCKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x5C919E0", Offset = "0x5C90DE0", VA = "0x185C919E0")]
	public static void BHFKOBKEAAD(DAJJDHFICPI? OOIBMCBCEPD, BGIJLNGPCMI ICPLJNPILJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x5C91D40", Offset = "0x5C91140", VA = "0x185C91D40")]
	public static void EDFDCEJAANJ(PCINEGOOCHP FBCEMNKCDOB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public struct PCINEGOOCHP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public DAACELPKEHI HBEHPCDFOOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public DAJJDHFICPI JINLJHLPIMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public Dictionary<int, int> HGGIFNHEKMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	public Dictionary<Guid, Guid> HKBONAPANGO;

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x5C98A00", Offset = "0x5C97E00", VA = "0x185C98A00")]
	public Guid GEEADNDJNHA(Guid HILDEDLDEPK)
	{
		return default(Guid);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public interface MPJLFCLCHFF
{
	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool TryGetPersistenceViewId(int EFHGLPLCBNJ, [Out] Guid FDEGECPLKIB);
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public sealed class KDOGLIIIJHM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private readonly HashSet<string> MOIDHIPAPBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private readonly Dictionary<long, int> KFOLCNIADAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private readonly HashSet<Guid> MHKDFGHJHCA;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public IReadOnlyCollection<string> HDCDGEGKEHB
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x764450", Offset = "0x763850", VA = "0x180764450")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public IReadOnlyDictionary<long, int> BAHEDKKNFDC
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x767230", Offset = "0x766630", VA = "0x180767230")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x5C941E0", Offset = "0x5C935E0", VA = "0x185C941E0")]
	public static KDOGLIIIJHM EALIOANLEFA(KAIKLPKIAEH NDJHINJFLAD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x5C94170", Offset = "0x5C93570", VA = "0x185C94170")]
	public static KDOGLIIIJHM EADHPJOGOGE(NKFBCEKJGEC FCLIKFLGDMC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x5C94250", Offset = "0x5C93650", VA = "0x185C94250")]
	public static KDOGLIIIJHM LBFEGHPAIMM(IEnumerable<string> MOIDHIPAPBL, IDictionary<long, int> GDHGPFODGHJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x5C95230", Offset = "0x5C94630", VA = "0x185C95230")]
	private KDOGLIIIJHM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x5C95350", Offset = "0x5C94750", VA = "0x185C95350")]
	private KDOGLIIIJHM(IEnumerable<string> MOIDHIPAPBL, IDictionary<long, int> GDHGPFODGHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x5C94830", Offset = "0x5C93C30", VA = "0x185C94830")]
	private void OOGAANANJOO(KAIKLPKIAEH NDJHINJFLAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x5C95040", Offset = "0x5C94440", VA = "0x185C95040")]
	private void OOGAANANJOO(NKFBCEKJGEC FCLIKFLGDMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x5C94A30", Offset = "0x5C93E30", VA = "0x185C94A30")]
	private void OOGAANANJOO(EAJFEDCIBLD? JMNDOLBKAMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x5C94ED0", Offset = "0x5C942D0", VA = "0x185C94ED0")]
	private void OOGAANANJOO(PINPLNGICBI? BLMOEKLGDFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x5C94440", Offset = "0x5C93840", VA = "0x185C94440")]
	private void OOGAANANJOO(DAJJDHFICPI? JINLJHLPIMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x5C943D0", Offset = "0x5C937D0", VA = "0x185C943D0")]
	private void NCNNGMHIJPK(string? GKDEICMIABL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x5C94090", Offset = "0x5C93490", VA = "0x185C94090")]
	private void BJGAFBCCOLO(MMAPOJKOJOK? OPIOLPFAIIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x5C93FA0", Offset = "0x5C933A0", VA = "0x185C93FA0")]
	private void BJGAFBCCOLO(DBMCIKGLOEB? OPIOLPFAIIP)
	{
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
