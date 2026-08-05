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
	public class LogRegistrationIndex : CCAGPMFGEMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x7A7BA20", Offset = "0x7A7A420", VA = "0x187A7BA20", Slot = "4")]
		public override void BLLBFFICICF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x9D7E50", Offset = "0x9D6850", VA = "0x1809D7E50")]
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
			[Cpp2IlInjected.Address(RVA = "0x9AF000", Offset = "0x9ADA00", VA = "0x1809AF000", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x783DF70", Offset = "0x783C970", VA = "0x18783DF70", Slot = "5")]
		public override void SetServiceCategoryIndices(List<int> globalFromLocalIndices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x7A7CE10", Offset = "0x7A7B810", VA = "0x187A7CE10")]
		private void IPCGMJBOKKK(IServiceRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x7A7D1E0", Offset = "0x7A7BBE0", VA = "0x187A7D1E0")]
		private void PENEIAJNJEJ(IServiceRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x7A7D510", Offset = "0x7A7BF10", VA = "0x187A7D510", Slot = "6")]
		public override void RegisterServices(IServiceRegistration registry, [In] ServiceBitsetFilter filter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x7A7D5C0", Offset = "0x7A7BFC0", VA = "0x187A7D5C0")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
[RegisterService(typeof(CAJMJJNIEOC), new string[] { "Photon" })]
public class HKJPLKLBJOC : CAJMJJNIEOC
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	private class BHDJBJCFABG : HLCLMIGFJLH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		public EventData GLECKDJIKIL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public StatusCode PGPKPDALKBA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public GBIIPJPOIDD HHFPDLJPNHC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public HIGBPICCMBD IHNGHJHKKOD;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public OJCJCAFGJEL ABBLELNBDOD
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x7A77D90", Offset = "0x7A76790", VA = "0x187A77D90", Slot = "4")]
			get
			{
				return default(OJCJCAFGJEL);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public JKHDNFMHOCD LICHLKNELCG
		{
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x7A77D70", Offset = "0x7A76770", VA = "0x187A77D70", Slot = "5")]
			get
			{
				return default(JKHDNFMHOCD);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public bool JIDEEGBEELL
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x7A78710", Offset = "0x7A77110", VA = "0x187A78710", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		private bool NNJMKGOLJDB
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x7A785A0", Offset = "0x7A76FA0", VA = "0x187A785A0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x7A78450", Offset = "0x7A76E50", VA = "0x187A78450", Slot = "8")]
		private (JKHDNFMHOCD, Dictionary<object, object>) LMJPMKJHKDJ()
		{
			return default((JKHDNFMHOCD, Dictionary<object, object>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x7A77CA0", Offset = "0x7A766A0", VA = "0x187A77CA0", Slot = "9")]
		private (MNGNDNIEHNP, JKHDNFMHOCD) DCDIBIONKEG()
		{
			return default((MNGNDNIEHNP, JKHDNFMHOCD));
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x7A78330", Offset = "0x7A76D30", VA = "0x187A78330", Slot = "10")]
		private IMMIBLOAIDI<(MNGNDNIEHNP, JKHDNFMHOCD)> HLDOKEMLEBJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x7A77FB0", Offset = "0x7A769B0", VA = "0x187A77FB0", Slot = "11")]
		private IMMIBLOAIDI<EKFNOCNPMID> GIMBPJHOECJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x7A77DB0", Offset = "0x7A767B0", VA = "0x187A77DB0", Slot = "12")]
		private (BHMFNJNGEHN, byte[]) ECCLNPILFEH()
		{
			return default((BHMFNJNGEHN, byte[]));
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x7A78120", Offset = "0x7A76B20", VA = "0x187A78120", Slot = "13")]
		private (PEEMFHDLDKA, byte[]) GOPDLFDDBKC()
		{
			return default((PEEMFHDLDKA, byte[]));
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x3D42590", Offset = "0x3D40F90", VA = "0x183D42590", Slot = "14")]
		public T JINKEBIBEHI<T>()
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x7A78720", Offset = "0x7A77120", VA = "0x187A78720", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x9B1770", Offset = "0x9B0170", VA = "0x1809B1770")]
		public BHDJBJCFABG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[DefaultMember("Item")]
	private class GBIIPJPOIDD : IMMIBLOAIDI<(MNGNDNIEHNP, JKHDNFMHOCD)>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public int[] GEOBPNEEOAM;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public int NIKDNFEJMFN
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x7A7A560", Offset = "0x7A78F60", VA = "0x187A7A560", Slot = "5")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public (MNGNDNIEHNP view, JKHDNFMHOCD newOwner) NKIDLMDDABC
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x7A7A4C0", Offset = "0x7A78EC0", VA = "0x187A7A4C0", Slot = "4")]
			get
			{
				return default((MNGNDNIEHNP, JKHDNFMHOCD));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x9B1770", Offset = "0x9B0170", VA = "0x1809B1770")]
		public GBIIPJPOIDD()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[DefaultMember("Item")]
	private class HIGBPICCMBD : IMMIBLOAIDI<EKFNOCNPMID>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public object[] GEOBPNEEOAM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public NLODIBDILPH GEBLMOBADNK;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public int NIKDNFEJMFN
		{
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x7A7AC40", Offset = "0x7A79640", VA = "0x187A7AC40", Slot = "5")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public EKFNOCNPMID NKIDLMDDABC
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x7A7AB40", Offset = "0x7A79540", VA = "0x187A7AB40", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x7A7AC60", Offset = "0x7A79660", VA = "0x187A7AC60")]
		public HIGBPICCMBD()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[DefaultMember("Item")]
	private class NLODIBDILPH : EKFNOCNPMID, IMMIBLOAIDI<DHIJOKOLFJM>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public MNGNDNIEHNP NBMFEEBJLOH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public object[] IOMEFCNHNJN;

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public MNGNDNIEHNP ADNGAANLBDG
		{
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x9AC1A0", Offset = "0x9AABA0", VA = "0x1809AC1A0", Slot = "4")]
			get
			{
				return default(MNGNDNIEHNP);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public int NIKDNFEJMFN
		{
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x7A7CAC0", Offset = "0x7A7B4C0", VA = "0x187A7CAC0", Slot = "6")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public DHIJOKOLFJM NKIDLMDDABC
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x7A7CA00", Offset = "0x7A7B400", VA = "0x187A7CA00", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x9B1770", Offset = "0x9B0170", VA = "0x1809B1770")]
		public NLODIBDILPH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x7A7ACE0", Offset = "0x7A796E0", VA = "0x187A7ACE0", Slot = "4")]
	public bool BODMEEJLOED(object DFPGGEDGGGN, HLCLMIGFJLH IALOAICAFFP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x9B1770", Offset = "0x9B0170", VA = "0x1809B1770")]
	public HKJPLKLBJOC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
internal static class JCBIFGFBLMD
{
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
[RegisterService(typeof(CFMLAOCAKEO), new string[] { "Photon" })]
[AlsoBindServiceAs(typeof(LPCJJHJAPKN))]
public class LPCJJHJAPKN : KFPIMHBKPFA, FEIEJJCEAHO, CFMLAOCAKEO, CNHFPODFAID, OMHPDBDDEHH, HDFHGFMLGCI
{
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private static readonly LMPJBEBLCLM BLAHIKOFFGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	[DependsOn]
	private PKFPEIEOMBL OADJGMBHLBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	[DependsOn]
	private MGOIPOJOJAJ EFHDKMLIOGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private readonly Hashtable FPBCGBJHAKH;

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x7A7B400", Offset = "0x7A79E00", VA = "0x187A7B400", Slot = "4")]
	public void InitReferences(LBHNIGEPODB GNJMKKKJHPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x7A7B870", Offset = "0x7A7A270", VA = "0x187A7B870", Slot = "5")]
	public void OFIOACGPNNO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x7A7B700", Offset = "0x7A7A100", VA = "0x187A7B700", Slot = "6")]
	public void NMLNEOMDADK(PEEMFHDLDKA NJBPFCDJFGD, ReadOnlySpan<byte> ECGNDACMANN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x7A7B270", Offset = "0x7A79C70", VA = "0x187A7B270", Slot = "11")]
	public void EEEOIAFOJOH(PEEMFHDLDKA CJHEEJNMBFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x7A7B0E0", Offset = "0x7A79AE0", VA = "0x187A7B0E0", Slot = "7")]
	public void DDCIAMOIHGP(ReadOnlySpan<PEEMFHDLDKA> IBPDAMHPHPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x7A7B4A0", Offset = "0x7A79EA0", VA = "0x187A7B4A0")]
	private Hashtable KFGPNGLICOH(Hashtable MGDLBAJDJGA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x7A7B8C0", Offset = "0x7A7A2C0", VA = "0x187A7B8C0", Slot = "8")]
	public void OnEvent(EventData GLECKDJIKIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x7A7B390", Offset = "0x7A79D90", VA = "0x187A7B390", Slot = "9")]
	private void HOMBBOJBDKL(LBHNIGEPODB GNJMKKKJHPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x10C4C30", Offset = "0x10C3630", VA = "0x1810C4C30", Slot = "10")]
	private void MOKMDAMCMCP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x7A7B9A0", Offset = "0x7A7A3A0", VA = "0x187A7B9A0")]
	public LPCJJHJAPKN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
[RegisterService(typeof(global::EDBOGPODLGD), new string[] { })]
internal class AGEGLDELBMG : BFBBNADDDKG, global::EDBOGPODLGD
{
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private static readonly LMPJBEBLCLM CDCBPHLPNJO;

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	protected override LMPJBEBLCLM[] NKJOKCJNMGI
	{
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x9B5560", Offset = "0x9B3F60", VA = "0x1809B5560", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x7A77BF0", Offset = "0x7A765F0", VA = "0x187A77BF0")]
	public AGEGLDELBMG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public class LJFOHGCJPNL : DefaultContractResolver
{
	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x7A7AE90", Offset = "0x7A79890", VA = "0x187A7AE90", Slot = "19")]
	protected override IList<JsonProperty> CreateProperties(Type OHCGINPDMEI, MemberSerialization DDBIBMGMIPE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x7A7B090", Offset = "0x7A79A90", VA = "0x187A7B090")]
	public LJFOHGCJPNL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public static class MLGHBCJOKAA
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	internal static class PPFGFFGHFKA
	{
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public static string IFBIHCMJEIJ;
	}

	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[CompilerGenerated]
	private sealed class CGNOHEHAMOK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public JsonSerializerSettings serializationSettings;

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x9B1770", Offset = "0x9B0170", VA = "0x1809B1770")]
		public CGNOHEHAMOK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x7A7A390", Offset = "0x7A78D90", VA = "0x187A7A390")]
		internal string CBJNLEJOHGM(EventData eventData)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x7A7C9E0", Offset = "0x7A7B3E0", VA = "0x187A7C9E0")]
	public static string MMGPEMNKAPA(this EventData GLECKDJIKIL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x7A7BB30", Offset = "0x7A7A530", VA = "0x187A7BB30")]
	public static OJCJCAFGJEL ALGGHGAOCEE(this EventData GLECKDJIKIL)
	{
		return default(OJCJCAFGJEL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x7A7BDA0", Offset = "0x7A7A7A0", VA = "0x187A7BDA0")]
	public static string DLLCFKJMOOA(OJCJCAFGJEL OPGMLCDKFBP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x7A7C750", Offset = "0x7A7B150", VA = "0x187A7C750")]
	public static string KIFPAODGHNM(this EventData GLECKDJIKIL, JsonSerializerSettings MJKCNOHJBCE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x7A7BBE0", Offset = "0x7A7A5E0", VA = "0x187A7BBE0")]
	public static ViewId DFIFPPNJODB(this EventData GLECKDJIKIL)
	{
		return default(ViewId);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x7A7C870", Offset = "0x7A7B270", VA = "0x187A7C870")]
	public static string KKFHENLIMBL(this EventData GLECKDJIKIL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x7A7C590", Offset = "0x7A7AF90", VA = "0x187A7C590")]
	public static ViewId JEBDOGOACBB(this EventData GLECKDJIKIL)
	{
		return default(ViewId);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x7A7C3D0", Offset = "0x7A7ADD0", VA = "0x187A7C3D0")]
	public static string DMBOJIBMJDJ(this EventData GLECKDJIKIL, JsonSerializerSettings MJKCNOHJBCE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x7A7C4A0", Offset = "0x7A7AEA0", VA = "0x187A7C4A0")]
	private static string HPMFEKONCPE(EventData GLECKDJIKIL, Func<EventData, string> HNDDBOOOBBE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
[ServiceLifetime(Lifetime.PhotonRoom)]
[RegisterService(typeof(GCFDFJKOKDB), new string[] { })]
internal class GCFDFJKOKDB : BFBBNADDDKG, CNHFPODFAID, MMEMAKHMGOK
{
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private static readonly LMPJBEBLCLM NEJFFOFPKEP;

	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private static readonly LMPJBEBLCLM FCCFLMFFGFM;

	[Cpp2IlInjected.Token(Token = "0x400001E")]
	private static readonly LMPJBEBLCLM BDOGIDCNPHO;

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	protected override LMPJBEBLCLM[] NKJOKCJNMGI
	{
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x9B5560", Offset = "0x9B3F60", VA = "0x1809B5560", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x7A7A7A0", Offset = "0x7A791A0", VA = "0x187A7A7A0", Slot = "9")]
	public override void CCMHLPMEACK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x7A7A920", Offset = "0x7A79320", VA = "0x187A7A920", Slot = "10")]
	public override void NAEDHDKIOFD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x7A7A9B0", Offset = "0x7A793B0", VA = "0x187A7A9B0", Slot = "11")]
	private void OBOCFAKJBFJ(EventData GLECKDJIKIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x7A7A8F0", Offset = "0x7A792F0", VA = "0x187A7A8F0", Slot = "12")]
	private void PDAFKNDAIJP(EventData GLECKDJIKIL, IJDHNGPEKCN JHFELOMPNJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x7A7A8F0", Offset = "0x7A792F0", VA = "0x187A7A8F0")]
	private void KFEPHDAPMFK(EventData GLECKDJIKIL, IJDHNGPEKCN JHFELOMPNJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x7A7A580", Offset = "0x7A78F80", VA = "0x187A7A580")]
	public void AJJODAGKKIG(EventData GLECKDJIKIL, FOILGMIHJNH NOFAICNOHHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x7A7A830", Offset = "0x7A79230", VA = "0x187A7A830")]
	private static LMPJBEBLCLM HDGIMCAEJHI(EventData GLECKDJIKIL)
	{
		return default(LMPJBEBLCLM);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x7A7AA60", Offset = "0x7A79460", VA = "0x187A7AA60")]
	public GCFDFJKOKDB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public static class CFNDCOMMKBA
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	[CompilerGenerated]
	private struct OFJOLGMDMAD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		public byte[] payload;
	}

	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private static readonly JsonSerializerSettings ECKAPFDDOEI;

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x7A78F30", Offset = "0x7A77930", VA = "0x187A78F30")]
	public static INAJGFCNEJM OKCNMIDBING([In] this INAJGFCNEJM DKOJJABANLG, EventData GLECKDJIKIL, FOILGMIHJNH NOFAICNOHHO)
	{
		return default(INAJGFCNEJM);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x7A787D0", Offset = "0x7A771D0", VA = "0x187A787D0")]
	public static INAJGFCNEJM ANMJABHAGGB([In] this INAJGFCNEJM DKOJJABANLG, EventData GLECKDJIKIL)
	{
		return default(INAJGFCNEJM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x7A78D60", Offset = "0x7A77760", VA = "0x187A78D60")]
	public static string FIKHJKDDAMA(EventData GLECKDJIKIL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x7A78B10", Offset = "0x7A77510", VA = "0x187A78B10")]
	public static string CBAOFNDHBDF(EventData GLECKDJIKIL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x7A79EE0", Offset = "0x7A788E0", VA = "0x187A79EE0")]
	public static string PIOJAGEGNDD(EventData GLECKDJIKIL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x7A79E50", Offset = "0x7A78850", VA = "0x187A79E50")]
	[CompilerGenerated]
	internal static bool PGCJIPDGHJF([Out] string FFBEKAFHIDB, OFJOLGMDMAD P_1)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x7A7A060", Offset = "0x7A78A60", VA = "0x187A7A060")]
	[CompilerGenerated]
	internal static bool PLIODKLJPNH([Out] string FFBEKAFHIDB, OFJOLGMDMAD P_1)
	{
		return default(bool);
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class LPHLOPHCPMO
{
	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x9B1770", Offset = "0x9B0170", VA = "0x1809B1770")]
	public LPHLOPHCPMO()
	{
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x2000017")]
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
