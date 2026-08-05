using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using ExitGames.Client.Photon;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using RecRoom;
using RecRoom.DataLayer.Attributes;
using RecRoom.DataLayer.Registration;
using RecRoom.Foundation;
using RecRoom.Logging.Attributes;
using RecRoom.ObjectModel;

[assembly: AssemblyVersion("0.0.0.0")]
namespace _LogRegistration.RecRoom_ObjectModel_Dependencies_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[RecRoom.Logging.Attributes.Preserve]
	public class LogRegistrationIndex : DHBOPDJGFAL
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x86C5B50", Offset = "0x86C4150", VA = "0x1886C5B50", Slot = "4")]
		public override void NCEHDCEOICJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xAD1210", Offset = "0xACF810", VA = "0x180AD1210")]
		public LogRegistrationIndex()
		{
		}
	}
}
namespace _AssemblyRegistry.RecRoom_ObjectModel_Dependencies_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[CompilerGenerated]
	[RecRoom.DataLayer.Attributes.Preserve]
	public class _AssemblyIndex : AssemblyIndex
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private int[] localIndices0;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private int[] localIndices1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private ServiceBitset bitset0;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private ServiceBitset bitset1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private Type[] bindTypeSet3;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public override string[] ServiceCategories
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0xAA54B0", Offset = "0xAA3AB0", VA = "0x180AA54B0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x23FEEA0", Offset = "0x23FD4A0", VA = "0x1823FEEA0", Slot = "5")]
		public override void SetServiceCategoryIndices(List<int> globalFromLocalIndices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x86C6AB0", Offset = "0x86C50B0", VA = "0x1886C6AB0")]
		private void BFHOJBJGDPP(IServiceRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x86C6E90", Offset = "0x86C5490", VA = "0x1886C6E90")]
		private void KNNDHOHFANH(IServiceRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x86C71C0", Offset = "0x86C57C0", VA = "0x1886C71C0", Slot = "6")]
		public override void RegisterServices(IServiceRegistration registry, [In] ServiceBitsetFilter filter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x86C7270", Offset = "0x86C5870", VA = "0x1886C7270")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
[RegisterService(typeof(ENEHNEGEIHO), new string[] { "Photon" })]
public class PFDFNECFLIH : ENEHNEGEIHO
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	private class FFGGEKKIFHI : BIEMNAKNEJO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		public NDDAOAIJPDM CBIMJBOHKKP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public StatusCode NLCCPALPJFK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public ICHDJAMEDMA JNJEAEPOBMP;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public KDHFFFFPNJA HIKNDMJOAGH
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x86C1F70", Offset = "0x86C0570", VA = "0x1886C1F70", Slot = "4")]
			get
			{
				return default(KDHFFFFPNJA);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public NOCCEEEBCMN PBMONNHFCBH
		{
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x86C2190", Offset = "0x86C0790", VA = "0x1886C2190", Slot = "5")]
			get
			{
				return default(NOCCEEEBCMN);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public bool CLPBAECCPBK
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x86C2180", Offset = "0x86C0780", VA = "0x1886C2180", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		private bool MFABFIIIJDA
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x86C1FC0", Offset = "0x86C05C0", VA = "0x1886C1FC0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x86C2450", Offset = "0x86C0A50", VA = "0x1886C2450", Slot = "9")]
		public bool KNILBBONLFP([Out] NOCCEEEBCMN OIFMJLAHCKJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x86C2400", Offset = "0x86C0A00", VA = "0x1886C2400", Slot = "8")]
		public object KDPNDHNAFLP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x86C2720", Offset = "0x86C0D20", VA = "0x1886C2720", Slot = "10")]
		private (NOCCEEEBCMN, object) PBECKMDGIDI()
		{
			return default((NOCCEEEBCMN, object));
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x86C2310", Offset = "0x86C0910", VA = "0x1886C2310", Slot = "11")]
		private (NEKBNCKOEOB, NOCCEEEBCMN) JGICHONCAPA()
		{
			return default((NEKBNCKOEOB, NOCCEEEBCMN));
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x86C21E0", Offset = "0x86C07E0", VA = "0x1886C21E0", Slot = "12")]
		private NAOOHNEIFIM<(NEKBNCKOEOB, NOCCEEEBCMN)> IDEAHCCHFLA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x86C2510", Offset = "0x86C0B10", VA = "0x1886C2510", Slot = "13")]
		private (AHDIOKNFJLF, byte[]) OAAGKKDEKJE()
		{
			return default((AHDIOKNFJLF, byte[]));
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x86C1D40", Offset = "0x86C0340", VA = "0x1886C1D40", Slot = "14")]
		private (HGADKIBHGFO, byte[]) AOAOHNAJECM()
		{
			return default((HGADKIBHGFO, byte[]));
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x44E6CA0", Offset = "0x44E52A0", VA = "0x1844E6CA0", Slot = "15")]
		public T IEEOGNLMJFI<T>()
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x86C28B0", Offset = "0x86C0EB0", VA = "0x1886C28B0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0xAACE80", Offset = "0xAAB480", VA = "0x180AACE80")]
		public FFGGEKKIFHI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[DefaultMember("Item")]
	private class ICHDJAMEDMA : NAOOHNEIFIM<(NEKBNCKOEOB, NOCCEEEBCMN)>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public int[] PKPOEGINAGG;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public int AOCLJDLKDLK
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x86C5240", Offset = "0x86C3840", VA = "0x1886C5240", Slot = "5")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public (NEKBNCKOEOB view, NOCCEEEBCMN newOwner) LAJHLDAJFPK
		{
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x86C5260", Offset = "0x86C3860", VA = "0x1886C5260", Slot = "4")]
			get
			{
				return default((NEKBNCKOEOB, NOCCEEEBCMN));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0xAACE80", Offset = "0xAAB480", VA = "0x180AACE80")]
		public ICHDJAMEDMA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x86C6600", Offset = "0x86C4C00", VA = "0x1886C6600", Slot = "4")]
	public bool KKCEGINDOMB(object CDDIADBJAOB, BIEMNAKNEJO LIJBKCOOFMN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0xAACE80", Offset = "0xAAB480", VA = "0x180AACE80")]
	public PFDFNECFLIH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
internal static class OHLCGNMLLDH
{
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
[AlsoBindServiceAs(typeof(GBDIBBAOKFN))]
[RegisterService(typeof(HCIHEAHFDKB), new string[] { "Photon" })]
public class GBDIBBAOKFN : MOLBKPMFEIO, HJNPDELKIBF, HCIHEAHFDKB, HKPOOEHKBFO, PFDHPBBBFAF
{
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private static readonly IPHNFELODMJ AMCHCCAPJNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	[DependsOn]
	private CNKHDPAHPHO AJLGIFGJLEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	[DependsOn]
	private EBIHMMJKLCA HMIEEBPBJFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly Hashtable MGIBLGJBEDG;

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x86C2E90", Offset = "0x86C1490", VA = "0x1886C2E90", Slot = "4")]
	public void InitReferences(CNPFBIMHGJN KADNKCJPKCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x86C31E0", Offset = "0x86C17E0", VA = "0x1886C31E0", Slot = "5")]
	public void ShutdownReferences()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x86C2A70", Offset = "0x86C1070", VA = "0x1886C2A70", Slot = "6")]
	public void EFFLGCJPCMC(HGADKIBHGFO HAELBKGFDIJ, ReadOnlySpan<byte> JFAOAIPNPMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x86C2BE0", Offset = "0x86C11E0", VA = "0x1886C2BE0", Slot = "10")]
	public void GPEMLMDDLEC(HGADKIBHGFO GOKFDAACHMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x86C2D00", Offset = "0x86C1300", VA = "0x1886C2D00", Slot = "7")]
	public void HEKIOKBMMDP(ReadOnlySpan<HGADKIBHGFO> DJFFHBMKOAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x86C2F80", Offset = "0x86C1580", VA = "0x1886C2F80")]
	private Hashtable LAAMPBKFLNG(Hashtable NFCGDGFODPB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x86C2A10", Offset = "0x86C1010", VA = "0x1886C2A10")]
	public void DAOHPHKPIFM(object DONNKKDINIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x86C29A0", Offset = "0x86C0FA0", VA = "0x1886C29A0", Slot = "8")]
	private void CMMNFFLCJOL(CNPFBIMHGJN KADNKCJPKCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x10354A0", Offset = "0x1033AA0", VA = "0x1810354A0", Slot = "9")]
	private void GCOCFFJOAJG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x86C3320", Offset = "0x86C1920", VA = "0x1886C3320")]
	public GBDIBBAOKFN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
[RegisterService(typeof(global::HMOBNJMKKIG), new string[] { })]
internal class IMGIAGNCNOJ : CAPKPGEFGAL, global::HMOBNJMKKIG
{
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private static readonly IPHNFELODMJ ONCPPCGCCMB;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	protected override IPHNFELODMJ[] GNMJMKBOLFL
	{
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0xAA70C0", Offset = "0xAA56C0", VA = "0x180AA70C0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x86C5350", Offset = "0x86C3950", VA = "0x1886C5350")]
	public IMGIAGNCNOJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public class CNPJEMEMNLO : DefaultContractResolver
{
	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x86C1AE0", Offset = "0x86C00E0", VA = "0x1886C1AE0", Slot = "19")]
	protected override IList<JsonProperty> CreateProperties(Type GPEIAHGICNA, MemberSerialization PLCNHGGJHJC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x86C1CF0", Offset = "0x86C02F0", VA = "0x1886C1CF0")]
	public CNPJEMEMNLO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public static class NEAFJBLMIEA
{
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private sealed class LDBAMHLDOMJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public JsonSerializerSettings serializationSettings;

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0xAACE80", Offset = "0xAAB480", VA = "0x180AACE80")]
		public LDBAMHLDOMJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x86C5A10", Offset = "0x86C4010", VA = "0x1886C5A10")]
		internal string POMOIGFGPEI(NDDAOAIJPDM eventData)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x86C63D0", Offset = "0x86C49D0", VA = "0x1886C63D0")]
	public static string IGGHPIKIBNE(this NDDAOAIJPDM CBIMJBOHKKP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x86C6110", Offset = "0x86C4710", VA = "0x1886C6110")]
	public static KDHFFFFPNJA HMLBDPPEDMI(this NDDAOAIJPDM CBIMJBOHKKP)
	{
		return default(KDHFFFFPNJA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x86C5F10", Offset = "0x86C4510", VA = "0x1886C5F10")]
	public static ViewId FBGJKAPOHPL(this NDDAOAIJPDM CBIMJBOHKKP)
	{
		return default(ViewId);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x86C5C60", Offset = "0x86C4260", VA = "0x1886C5C60")]
	public static string BLAKPJGIDAE(this NDDAOAIJPDM CBIMJBOHKKP, JsonSerializerSettings JINNOOGOLMC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x86C6510", Offset = "0x86C4B10", VA = "0x1886C6510")]
	private static string NAFNDKCMABP(NDDAOAIJPDM CBIMJBOHKKP, Func<NDDAOAIJPDM, string> PMBBLAOPHON)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x86C6260", Offset = "0x86C4860", VA = "0x1886C6260")]
	public static string IFFNGOCPPMB(this NDDAOAIJPDM CBIMJBOHKKP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x86C5D30", Offset = "0x86C4330", VA = "0x1886C5D30")]
	public static ViewId CAEPGFFECEF(this NDDAOAIJPDM CBIMJBOHKKP)
	{
		return default(ViewId);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x86C63F0", Offset = "0x86C49F0", VA = "0x1886C63F0")]
	public static string KGBKNLPGOBK(this NDDAOAIJPDM CBIMJBOHKKP, JsonSerializerSettings JINNOOGOLMC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class KDCAJIJPOEG
{
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	internal static class HIHPJMFHHPL
	{
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public static string IIKNGMIOCAK;
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x86C5400", Offset = "0x86C3A00", VA = "0x1886C5400")]
	public static string GEJLLKLCMCI(KDHFFFFPNJA NLMJOFNGIOJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
[RegisterService(typeof(BAJAGFLIPKM), new string[] { })]
[ServiceLifetime(Lifetime.PhotonRoom)]
internal class BAJAGFLIPKM : CAPKPGEFGAL
{
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private static readonly IPHNFELODMJ OPLFDFBPGNO;

	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private static readonly IPHNFELODMJ ECHNLFDDNDM;

	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private static readonly IPHNFELODMJ JBKPCBGHHAM;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	protected override IPHNFELODMJ[] GNMJMKBOLFL
	{
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0xAA70C0", Offset = "0xAA56C0", VA = "0x180AA70C0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x86C12E0", Offset = "0x86BF8E0", VA = "0x1886C12E0", Slot = "9")]
	public override void AAOGDOMHBGP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x86C1480", Offset = "0x86BFA80", VA = "0x1886C1480", Slot = "10")]
	public override void KGIFKDJGHBJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x86C1470", Offset = "0x86BFA70", VA = "0x1886C1470")]
	private void FKLCDBKGPAC(NDDAOAIJPDM CBIMJBOHKKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x86C1610", Offset = "0x86BFC10", VA = "0x1886C1610")]
	private void LMOJBHOBBCC(NDDAOAIJPDM CBIMJBOHKKP, CIJKFJMOGHC KNBPPAKDDHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x86C1640", Offset = "0x86BFC40", VA = "0x1886C1640")]
	public void MGBBAGNKOMP(NDDAOAIJPDM CBIMJBOHKKP, NBNENBOIAOH NFFNOCCKGBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x86C1890", Offset = "0x86BFE90", VA = "0x1886C1890")]
	private static IPHNFELODMJ NDHJLEEJFLO(byte JEKPMBEJDGB)
	{
		return default(IPHNFELODMJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x86C19F0", Offset = "0x86BFFF0", VA = "0x1886C19F0")]
	public BAJAGFLIPKM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public static class HHDHNBLCKEH
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[CompilerGenerated]
	private struct BIPMCGJNNFL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public byte[] payload;
	}

	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private static readonly JsonSerializerSettings HKLEFJDNNIK;

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x86C3ED0", Offset = "0x86C24D0", VA = "0x1886C3ED0")]
	public static GIMEACGKDIN PIHFKLGOIDJ([In] this GIMEACGKDIN AHMCHECBFBO, NDDAOAIJPDM CBIMJBOHKKP, NBNENBOIAOH NFFNOCCKGBK)
	{
		return default(GIMEACGKDIN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x86C3530", Offset = "0x86C1B30", VA = "0x1886C3530")]
	public static GIMEACGKDIN DNAACCLAOKB([In] this GIMEACGKDIN AHMCHECBFBO, NDDAOAIJPDM CBIMJBOHKKP)
	{
		return default(GIMEACGKDIN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x86C3890", Offset = "0x86C1E90", VA = "0x1886C3890")]
	public static string GFGIHCFBELG(NDDAOAIJPDM CBIMJBOHKKP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x86C3A70", Offset = "0x86C2070", VA = "0x1886C3A70")]
	public static string GGMJICODKKN(NDDAOAIJPDM CBIMJBOHKKP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x86C33A0", Offset = "0x86C19A0", VA = "0x1886C33A0")]
	public static string DBOAENGMNCH(NDDAOAIJPDM CBIMJBOHKKP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x86C3CD0", Offset = "0x86C22D0", VA = "0x1886C3CD0")]
	[CompilerGenerated]
	internal static bool KKMFAGMHIOO([Out] string FAKHJBCPGHO, BIPMCGJNNFL P_1)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x86C3D60", Offset = "0x86C2360", VA = "0x1886C3D60")]
	[CompilerGenerated]
	internal static bool NBHFGIGJNKE([Out] string FAKHJBCPGHO, BIPMCGJNNFL P_1)
	{
		return default(bool);
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class IDEENHLMJMC
{
	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0xAACE80", Offset = "0xAAB480", VA = "0x180AACE80")]
	public IDEENHLMJMC()
	{
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public class __BB_OBFUSCATOR_VERSION_3_10_0
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
