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
	public class LogRegistrationIndex : BPLGCOBKJGC
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x7DCD9F0", Offset = "0x7DCBFF0", VA = "0x187DCD9F0", Slot = "4")]
		public override void AMBIAOGNIIF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xA149D0", Offset = "0xA12FD0", VA = "0x180A149D0")]
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
			[Cpp2IlInjected.Address(RVA = "0x9EB780", Offset = "0x9E9D80", VA = "0x1809EB780", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x7B64240", Offset = "0x7B62840", VA = "0x187B64240", Slot = "5")]
		public override void SetServiceCategoryIndices(List<int> globalFromLocalIndices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x7DCF490", Offset = "0x7DCDA90", VA = "0x187DCF490")]
		private void MEMPKEBCMCB(IServiceRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x7DCF170", Offset = "0x7DCD770", VA = "0x187DCF170")]
		private void KMFPJCIAGGA(IServiceRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x7DCF860", Offset = "0x7DCDE60", VA = "0x187DCF860", Slot = "6")]
		public override void RegisterServices(IServiceRegistration registry, [In] ServiceBitsetFilter filter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x7DCF910", Offset = "0x7DCDF10", VA = "0x187DCF910")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
[RegisterService(typeof(FHPIJCIIFKO), new string[] { "Photon" })]
public class EFICFCKKIPM : FHPIJCIIFKO
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	private class OCDDEBOGMDH : CEADAKHMIIO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		public OJOPFCHDHDL NKBJHKLGFDP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public StatusCode FOOMEOJAJGM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public GFPECLGBMNH AHFBFJLAKCI;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public PMGMMGGAAPO KFIKOGBAHMD
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x7DCDF50", Offset = "0x7DCC550", VA = "0x187DCDF50", Slot = "4")]
			get
			{
				return default(PMGMMGGAAPO);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public AEMMHEJJEHA FACMAKELJCD
		{
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x7DCDB00", Offset = "0x7DCC100", VA = "0x187DCDB00", Slot = "5")]
			get
			{
				return default(AEMMHEJJEHA);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public bool JHEKIIEFEMD
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x7DCDB50", Offset = "0x7DCC150", VA = "0x187DCDB50", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		private bool MBLJOBEFPKA
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x7DCDD90", Offset = "0x7DCC390", VA = "0x187DCDD90", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x7DCE170", Offset = "0x7DCC770", VA = "0x187DCE170", Slot = "8")]
		public object KFABMFMFJPB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x7DCDFA0", Offset = "0x7DCC5A0", VA = "0x187DCDFA0", Slot = "9")]
		private (AEMMHEJJEHA, Dictionary<object, object>) JIBHAOJPCOF()
		{
			return default((AEMMHEJJEHA, Dictionary<object, object>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x7DCE2F0", Offset = "0x7DCC8F0", VA = "0x187DCE2F0", Slot = "10")]
		private (JOKHKLAANOK, AEMMHEJJEHA) PECMDADJBNP()
		{
			return default((JOKHKLAANOK, AEMMHEJJEHA));
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x7DCE1C0", Offset = "0x7DCC7C0", VA = "0x187DCE1C0", Slot = "11")]
		private MLEJCHELJGC<(JOKHKLAANOK, AEMMHEJJEHA)> LFEACMHDMCM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x7DCE3E0", Offset = "0x7DCC9E0", VA = "0x187DCE3E0", Slot = "12")]
		private (JJHDADELCNN, byte[]) PONBBBEPJKI()
		{
			return default((JJHDADELCNN, byte[]));
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x7DCDB60", Offset = "0x7DCC160", VA = "0x187DCDB60", Slot = "13")]
		private (NAKHDIPHEPO, byte[]) DHODOMCPELN()
		{
			return default((NAKHDIPHEPO, byte[]));
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x3F41D10", Offset = "0x3F40310", VA = "0x183F41D10", Slot = "14")]
		public T PGKJJBBGDIO<T>()
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x7DCE5F0", Offset = "0x7DCCBF0", VA = "0x187DCE5F0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
		public OCDDEBOGMDH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[DefaultMember("Item")]
	private class GFPECLGBMNH : MLEJCHELJGC<(JOKHKLAANOK, AEMMHEJJEHA)>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public int[] FOOCPKJGLIL;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public int JPLLFCIDPGJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x7DCCAF0", Offset = "0x7DCB0F0", VA = "0x187DCCAF0", Slot = "5")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public (JOKHKLAANOK view, AEMMHEJJEHA newOwner) OEMFNNCKNFG
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x7DCCA50", Offset = "0x7DCB050", VA = "0x187DCCA50", Slot = "4")]
			get
			{
				return default((JOKHKLAANOK, AEMMHEJJEHA));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
		public GFPECLGBMNH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x7DCA3E0", Offset = "0x7DC89E0", VA = "0x187DCA3E0", Slot = "4")]
	public bool HBGMKAEOAKP(object APDBNIMCPID, CEADAKHMIIO DJCKCBEAICI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
	public EFICFCKKIPM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
internal static class NEAGMAKILNN
{
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
[AlsoBindServiceAs(typeof(IKMMOJKDOIA))]
[RegisterService(typeof(DCIIAEEBHIA), new string[] { "Photon" })]
public class IKMMOJKDOIA : PNPJOMLIBJD, EECMODLKMOH, DCIIAEEBHIA, KBDPBLKCNPK, FGICIDPFKIB
{
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private static readonly JBBHIJHGEPM PAJIGEJCNAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	[DependsOn]
	private DONCFGGANJP JDPKJPILGNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	[DependsOn]
	private PLADEJNHEJL IPLPPMJAAOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly Hashtable FBEFHOGBKOJ;

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x7DCD140", Offset = "0x7DCB740", VA = "0x187DCD140", Slot = "4")]
	public void InitReferences(APJCDBKKFBB IDEMOBALCHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x7DCCDC0", Offset = "0x7DCB3C0", VA = "0x187DCCDC0", Slot = "5")]
	public void BAOPLEDIANP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x7DCD540", Offset = "0x7DCBB40", VA = "0x187DCD540", Slot = "6")]
	public void OFMEIPHEHKH(NAKHDIPHEPO OEHHKNIGGMI, ReadOnlySpan<byte> DGHLABNPIEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x7DCD420", Offset = "0x7DCBA20", VA = "0x187DCD420", Slot = "10")]
	public void NPLJIMPLMPL(NAKHDIPHEPO IJCHNJDOMJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x7DCD230", Offset = "0x7DCB830", VA = "0x187DCD230", Slot = "7")]
	public void JBDAPJANMNN(ReadOnlySpan<NAKHDIPHEPO> BABFMBLDKKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x7DCCEE0", Offset = "0x7DCB4E0", VA = "0x187DCCEE0")]
	private Hashtable DIMHKPHIIIJ(Hashtable PIDJHJKLGAE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x7DCD3C0", Offset = "0x7DCB9C0", VA = "0x187DCD3C0")]
	public void JINGFBINPHA(object KGFBFINKAKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x7DCCE70", Offset = "0x7DCB470", VA = "0x187DCCE70", Slot = "8")]
	private void CNNCCPCEIKO(APJCDBKKFBB IDEMOBALCHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x11661B0", Offset = "0x11647B0", VA = "0x1811661B0", Slot = "9")]
	private void AIFFBAJCNLC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x7DCD730", Offset = "0x7DCBD30", VA = "0x187DCD730")]
	public IKMMOJKDOIA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
[RegisterService(typeof(global::HLOFNANLBJP), new string[] { })]
internal class JNMGHMJLPBB : GIFGBLHKBOK, global::HLOFNANLBJP
{
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private static readonly JBBHIJHGEPM PAMLFPGMJBA;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	protected override JBBHIJHGEPM[] EBMKHFHPPKJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x9EACB0", Offset = "0x9E92B0", VA = "0x1809EACB0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x7DCD800", Offset = "0x7DCBE00", VA = "0x187DCD800")]
	public JNMGHMJLPBB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public class GKFGOPLKNHK : DefaultContractResolver
{
	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x7DCCB10", Offset = "0x7DCB110", VA = "0x187DCCB10", Slot = "19")]
	protected override IList<JsonProperty> CreateProperties(Type MLCOGCMJLBB, MemberSerialization FJABLLNLINE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x7DCCD10", Offset = "0x7DCB310", VA = "0x187DCCD10")]
	public GKFGOPLKNHK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public static class PJMLBMMDAIK
{
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private sealed class LICKNNMAFPL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public JsonSerializerSettings serializationSettings;

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
		public LICKNNMAFPL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x7DCD8B0", Offset = "0x7DCBEB0", VA = "0x187DCD8B0")]
		internal string LBECLCGFDCL(OJOPFCHDHDL eventData)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x7DCEEF0", Offset = "0x7DCD4F0", VA = "0x187DCEEF0")]
	public static string NGPCLDOEEOD(this OJOPFCHDHDL NKBJHKLGFDP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x7DCEB50", Offset = "0x7DCD150", VA = "0x187DCEB50")]
	public static PMGMMGGAAPO FICALAGANPO(this OJOPFCHDHDL NKBJHKLGFDP)
	{
		return default(PMGMMGGAAPO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x7DCE800", Offset = "0x7DCCE00", VA = "0x187DCE800")]
	public static ViewId DIJDDHMPNPH(this OJOPFCHDHDL NKBJHKLGFDP)
	{
		return default(ViewId);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x7DCEA80", Offset = "0x7DCD080", VA = "0x187DCEA80")]
	public static string EDGOEPMDBKM(this OJOPFCHDHDL NKBJHKLGFDP, JsonSerializerSettings OPLIANKAEPH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x7DCEE00", Offset = "0x7DCD400", VA = "0x187DCEE00")]
	private static string MHBHJODGEAJ(OJOPFCHDHDL NKBJHKLGFDP, Func<OJOPFCHDHDL, string> BDCLNIJAFBF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x7DCEC90", Offset = "0x7DCD290", VA = "0x187DCEC90")]
	public static string FMLKFIJNHDC(this OJOPFCHDHDL NKBJHKLGFDP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x7DCE950", Offset = "0x7DCCF50", VA = "0x187DCE950")]
	public static ViewId EDDPEJNHFCJ(this OJOPFCHDHDL NKBJHKLGFDP)
	{
		return default(ViewId);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x7DCE6E0", Offset = "0x7DCCCE0", VA = "0x187DCE6E0")]
	public static string CLPFOLJMEGI(this OJOPFCHDHDL NKBJHKLGFDP, JsonSerializerSettings OPLIANKAEPH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class AEFHHKMNABC
{
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	internal static class HAMFNGADLEJ
	{
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public static string HEMHGIDMDHP;
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x7DC9DD0", Offset = "0x7DC83D0", VA = "0x187DC9DD0")]
	public static string HNFOPDGEGFG(PMGMMGGAAPO OGKCOMEHLBF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
[RegisterService(typeof(FOPPGCGLICP), new string[] { })]
[ServiceLifetime(Lifetime.PhotonRoom)]
internal class FOPPGCGLICP : GIFGBLHKBOK
{
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private static readonly JBBHIJHGEPM EPPEKNOFEFD;

	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private static readonly JBBHIJHGEPM EHAFLPKEMFC;

	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private static readonly JBBHIJHGEPM GEFKLDEGOML;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	protected override JBBHIJHGEPM[] EBMKHFHPPKJ
	{
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x9EACB0", Offset = "0x9E92B0", VA = "0x1809EACB0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x7DCC350", Offset = "0x7DCA950", VA = "0x187DCC350", Slot = "9")]
	public override void JAINDIDLLHK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x7DCC750", Offset = "0x7DCAD50", VA = "0x187DCC750", Slot = "10")]
	public override void OIABCBMEMDD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x7DCC740", Offset = "0x7DCAD40", VA = "0x187DCC740")]
	private void NEJMJJLHGLJ(OJOPFCHDHDL NKBJHKLGFDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x7DCC710", Offset = "0x7DCAD10", VA = "0x187DCC710")]
	private void MIKICKAGJAI(OJOPFCHDHDL NKBJHKLGFDP, FIHNAFNBAOM BPOCFKJCMPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x7DCC4D0", Offset = "0x7DCAAD0", VA = "0x187DCC4D0")]
	public void LAHMHNDHIIJ(OJOPFCHDHDL NKBJHKLGFDP, DAFDNPPDPPJ KCFPPIHNKCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x7DCC2A0", Offset = "0x7DCA8A0", VA = "0x187DCC2A0")]
	private static JBBHIJHGEPM CEJKPKBPJMH(byte DAOAPLFBLDC)
	{
		return default(JBBHIJHGEPM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x7DCC970", Offset = "0x7DCAF70", VA = "0x187DCC970")]
	public FOPPGCGLICP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public static class FGHCAFJKDPK
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[CompilerGenerated]
	private struct AAKCCANLDBP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public byte[] payload;
	}

	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private static readonly JsonSerializerSettings DFEGDODJDPO;

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x7DCABC0", Offset = "0x7DC91C0", VA = "0x187DCABC0")]
	public static HHFCBOBDKHP KOHGHAEDKGD([In] this HHFCBOBDKHP DOHIDBPJPGC, OJOPFCHDHDL NKBJHKLGFDP, DAFDNPPDPPJ KCFPPIHNKCA)
	{
		return default(HHFCBOBDKHP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x7DCBD90", Offset = "0x7DCA390", VA = "0x187DCBD90")]
	public static HHFCBOBDKHP PMJGDAOKBEE([In] this HHFCBOBDKHP DOHIDBPJPGC, OJOPFCHDHDL NKBJHKLGFDP)
	{
		return default(HHFCBOBDKHP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x7DCA560", Offset = "0x7DC8B60", VA = "0x187DCA560")]
	public static string CNLKIBHPMAF(OJOPFCHDHDL NKBJHKLGFDP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x7DCA7D0", Offset = "0x7DC8DD0", VA = "0x187DCA7D0")]
	public static string HBOJDKLHEDN(OJOPFCHDHDL NKBJHKLGFDP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x7DCAA30", Offset = "0x7DC9030", VA = "0x187DCAA30")]
	public static string HFMGEFIKNCH(OJOPFCHDHDL NKBJHKLGFDP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x7DCA740", Offset = "0x7DC8D40", VA = "0x187DCA740")]
	[CompilerGenerated]
	internal static bool EPKNNJHOKJO([Out] string OBOOAPELMPF, AAKCCANLDBP P_1)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x7DCBC20", Offset = "0x7DCA220", VA = "0x187DCBC20")]
	[CompilerGenerated]
	internal static bool MACHCKDCODE([Out] string OBOOAPELMPF, AAKCCANLDBP P_1)
	{
		return default(bool);
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class PPHBBBBMJHN
{
	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
	public PPHBBBBMJHN()
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
