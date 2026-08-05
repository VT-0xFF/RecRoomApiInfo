using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Cpp2IlInjected;
using RecRoom.RoomEconomy.RoomInventory;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public class LEJPLJKFIBO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public readonly OFBDEGOKLEI PIGKFMPIMIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public readonly long MNPNLHNEGFK;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int OPLFBGBLJIA
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x66D6350", Offset = "0x66D5550", VA = "0x1866D6350")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x66D6360", Offset = "0x66D5560", VA = "0x1866D6360")]
	public LEJPLJKFIBO(OFBDEGOKLEI JKJJELABMHK, long BNPJLEJJKIB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public enum DJKEDLFPCCF
{
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	HiddenWhenNone,
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	Hidden,
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	AlwaysVisibleOnceOwned,
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	AlwaysVisible
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface PJNNMLIGLMB
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	DIKKIJJDOON CBHDNLDHLNN
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	APOAGECOPGB<JJAPGPOIBFC> FNCEDMADEHN
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	APOAGECOPGB<Guid> EEJLLOJLHPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(Slot = "5")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	KIDGADDAONM<NHLEFHGJCPF, int> EIAPOKCDEGN
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "7")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	DIKKIJJDOON LEEJCMKHKKK
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "9")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "10")]
	Task<BLNBDNPDEEM<JJAPGPOIBFC, string>> JMCLOBJHPLA(long NIPGINDOPCB, string NLBAJPAADNH, string MJGEABCNLKP, string IHPBEHIBOMD, RoomInventoryItemProperties PMLKCHHKGGA);

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "11")]
	Task<BLNBDNPDEEM<JJAPGPOIBFC, string>> MCBLNBEJKDA(Guid CKJNICIHABM, [Optional] string NLBAJPAADNH, [Optional] string MJGEABCNLKP, [Optional] string IHPBEHIBOMD, [Optional] List<long> KKGAFHAFIBE, [Optional] RoomInventoryItemProperties PMLKCHHKGGA);

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "12")]
	Task<BLNBDNPDEEM<bool, string>> JMMIKOFMDAG(Guid CKJNICIHABM);

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(Slot = "13")]
	IReadOnlyList<JJAPGPOIBFC> GDLPBEKIGLH();

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(Slot = "14")]
	IReadOnlyList<JJAPGPOIBFC> MFJNHPEHAIH();

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "15")]
	bool CMFBCKKEMNI();

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "16")]
	bool JLCHLOODELL(Guid CKJNICIHABM, [Out] JJAPGPOIBFC ONDFNEDIFBB);

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(Slot = "17")]
	bool IAOCKHIHNKH(string OKPLLGAFAKA, [Out] JJAPGPOIBFC ONDFNEDIFBB);

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(Slot = "18")]
	IReadOnlyList<NHLEFHGJCPF> INDPMBCEOMM();

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(Slot = "19")]
	bool NAHMHNPKHLN(Guid CKJNICIHABM, [Out] NHLEFHGJCPF KGCIHAGPECC);

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(Slot = "20")]
	Task<int> DMGLONKDKCK(PFFLGDPBKDO DONKKIJPHLE, Guid CKJNICIHABM);

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(Slot = "21")]
	Task<LEJPLJKFIBO> LKBPLICHPLM(PFFLGDPBKDO DONKKIJPHLE, Guid CKJNICIHABM, int IPCCNPIMMBE);

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "22")]
	string ILPIALNMDNI(OFBDEGOKLEI JKJJELABMHK);

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(Slot = "23")]
	bool DOLLMOLIHCE();

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(Slot = "24")]
	void Dispose();
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface IKNACJNBMLB : PJNNMLIGLMB
{
	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void DJBAGBLLCIM(IEnumerable<EOLHHMCIFLB> IJKAAGGGLDA);
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class NHLEFHGJCPF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public readonly Guid OMPIGDFPKKH;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public long MNPNLHNEGFK
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x66D6780", Offset = "0x66D5980", VA = "0x1866D6780")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public int OPLFBGBLJIA
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x66D69E0", Offset = "0x66D5BE0", VA = "0x1866D69E0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public long EKKEMGAEFMO
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x7BA3C0", Offset = "0x7B95C0", VA = "0x1807BA3C0")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x7C1D10", Offset = "0x7C0F10", VA = "0x1807C1D10")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public long FNMCCBOHKEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x7C1BE0", Offset = "0x7C0DE0", VA = "0x1807C1BE0")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x7C7830", Offset = "0x7C6A30", VA = "0x1807C7830")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public Guid? JPLACJHCADL
	{
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x7BF5D0", Offset = "0x7BE7D0", VA = "0x1807BF5D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x7BF5A0", Offset = "0x7BE7A0", VA = "0x1807BF5A0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public bool JCJJBEIMGLB
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x8C1DD0", Offset = "0x8C0FD0", VA = "0x1808C1DD0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x1A95540", Offset = "0x1A94740", VA = "0x181A95540")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x66D6A00", Offset = "0x66D5C00", VA = "0x1866D6A00")]
	public NHLEFHGJCPF(EOLHHMCIFLB BOMOAIDFLBD, bool POEIFEKKFIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x1B6F2C0", Offset = "0x1B6E4C0", VA = "0x181B6F2C0")]
	public NHLEFHGJCPF(Guid CKJNICIHABM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x66D6790", Offset = "0x66D5990", VA = "0x1866D6790")]
	internal bool HIJKAFNAKDI(EOLHHMCIFLB BOMOAIDFLBD, long NEFCLLKHOFD, Action<NHLEFHGJCPF, int> OKLGPCKODIE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x66D6980", Offset = "0x66D5B80", VA = "0x1866D6980")]
	internal void LEJMHJHLKDL(long CPFOKDNNHON, Action<NHLEFHGJCPF, int> OKLGPCKODIE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public class JJAPGPOIBFC : IEquatable<JJAPGPOIBFC>
{
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public const int OBGICJAKKOP = 3;

	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public const int ALMLCEHCFMI = 25;

	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public const int CLGJLFKCGKG = 180;

	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public const int GIAKKHCGLII = 1000;

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public Guid OMPIGDFPKKH
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x8507D0", Offset = "0x84F9D0", VA = "0x1808507D0")]
		[CompilerGenerated]
		get
		{
			return default(Guid);
		}
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x850870", Offset = "0x84FA70", VA = "0x180850870")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public long GIFJKPDDJAC
	{
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x7BA390", Offset = "0x7B9590", VA = "0x1807BA390")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0xED80B0", Offset = "0xED72B0", VA = "0x180ED80B0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public string IHKMJLPGIHG
	{
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x7BA3D0", Offset = "0x7B95D0", VA = "0x1807BA3D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x7BA3F0", Offset = "0x7B95F0", VA = "0x1807BA3F0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public string FLBKLLDNKPA
	{
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x7BA3C0", Offset = "0x7B95C0", VA = "0x1807BA3C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x7BA420", Offset = "0x7B9620", VA = "0x1807BA420")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public string CDGLJLMLBAE
	{
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x7C1BE0", Offset = "0x7C0DE0", VA = "0x1807C1BE0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x7C1D70", Offset = "0x7C0F70", VA = "0x1807C1D70")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public DateTime BDDFIKNDKIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x7C1D60", Offset = "0x7C0F60", VA = "0x1807C1D60")]
		[CompilerGenerated]
		get
		{
			return default(DateTime);
		}
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x1A6B6E0", Offset = "0x1A6A8E0", VA = "0x181A6B6E0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public DateTime MFPBDIGCDJM
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x7C1D40", Offset = "0x7C0F40", VA = "0x1807C1D40")]
		[CompilerGenerated]
		get
		{
			return default(DateTime);
		}
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x1A99030", Offset = "0x1A98230", VA = "0x181A99030")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public HashSet<long> CEKNENKABOH
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x7BDFB0", Offset = "0x7BD1B0", VA = "0x1807BDFB0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x7BDFF0", Offset = "0x7BD1F0", VA = "0x1807BDFF0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public RoomInventoryItemProperties EMJJIAMBPCC
	{
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x7BDF60", Offset = "0x7BD160", VA = "0x1807BDF60")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x7BDFE0", Offset = "0x7BD1E0", VA = "0x1807BDFE0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x66D61B0", Offset = "0x66D53B0", VA = "0x1866D61B0")]
	public JJAPGPOIBFC(IJHFJJAKNCN BOMOAIDFLBD, [Optional] RoomInventoryItemProperties PMLKCHHKGGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x66D5A80", Offset = "0x66D4C80", VA = "0x1866D5A80", Slot = "4")]
	public bool Equals(JJAPGPOIBFC NFMPGFPPFKH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x66D5C00", Offset = "0x66D4E00", VA = "0x1866D5C00", Slot = "0")]
	public override bool Equals(object MFLACBLODGN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x66D5DE0", Offset = "0x66D4FE0", VA = "0x1866D5DE0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x66D5EC0", Offset = "0x66D50C0", VA = "0x1866D5EC0")]
	private HashSet<long> JILFAHHLHKD(IJHFJJAKNCN BOMOAIDFLBD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public class NGKHFLFCOIA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private NHLEFHGJCPF KGCIHAGPECC;

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public JJAPGPOIBFC LELCBILGFDL
	{
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x7BA3A0", Offset = "0x7B95A0", VA = "0x1807BA3A0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x7BA400", Offset = "0x7B9600", VA = "0x1807BA400")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public NHLEFHGJCPF PKDDAKHFGLL
	{
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x66D63A0", Offset = "0x66D55A0", VA = "0x1866D63A0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x7BA410", Offset = "0x7B9610", VA = "0x1807BA410")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x66D6430", Offset = "0x66D5630", VA = "0x1866D6430")]
	public NGKHFLFCOIA(JJAPGPOIBFC ONDFNEDIFBB, [Optional] NHLEFHGJCPF KGCIHAGPECC)
	{
	}
}
namespace RecRoom.RoomEconomy.RoomInventory
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public class RoomInventoryItemProperties : IEquatable<RoomInventoryItemProperties>
	{
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private const int CURRENT_VERSION = 1;

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public static RoomInventoryItemProperties Default
		{
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x66D6CF0", Offset = "0x66D5EF0", VA = "0x1866D6CF0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		internal int Version
		{
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x7BA180", Offset = "0x7B9380", VA = "0x1807BA180")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x7BF590", Offset = "0x7BE790", VA = "0x1807BF590")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public bool SupportsUseAction
		{
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x9B4E70", Offset = "0x9B4070", VA = "0x1809B4E70")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x9B4E80", Offset = "0x9B4080", VA = "0x1809B4E80")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public DJKEDLFPCCF Visibility
		{
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x7C0510", Offset = "0x7BF710", VA = "0x1807C0510")]
			[CompilerGenerated]
			get
			{
				return default(DJKEDLFPCCF);
			}
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x7C0520", Offset = "0x7BF720", VA = "0x1807C0520")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x66D6BB0", Offset = "0x66D5DB0", VA = "0x1866D6BB0", Slot = "4")]
		public bool Equals(RoomInventoryItemProperties NFMPGFPPFKH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x66D6BF0", Offset = "0x66D5DF0", VA = "0x1866D6BF0")]
		public static RoomInventoryItemProperties OIJLLNDPLBD(RoomInventoryItemProperties PMLKCHHKGGA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x1AF72C0", Offset = "0x1AF64C0", VA = "0x181AF72C0")]
		public RoomInventoryItemProperties()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public class OBNFDGGDBAF
{
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public const int OMJCILDANNO = 10;

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public long MEJGGAPLMFJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x7BA3A0", Offset = "0x7B95A0", VA = "0x1807BA3A0")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x13307D0", Offset = "0x132F9D0", VA = "0x1813307D0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public string IHKMJLPGIHG
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x7BA3B0", Offset = "0x7B95B0", VA = "0x1807BA3B0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x7BA410", Offset = "0x7B9610", VA = "0x1807BA410")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public RoomInventoryTagClientProperties EMJJIAMBPCC
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x7BA390", Offset = "0x7B9590", VA = "0x1807BA390")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x7BA3E0", Offset = "0x7B95E0", VA = "0x1807BA3E0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public bool AHNOIILHPPL
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x66D6AB0", Offset = "0x66D5CB0", VA = "0x1866D6AB0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x66D6AD0", Offset = "0x66D5CD0", VA = "0x1866D6AD0")]
	public OBNFDGGDBAF(EMJOMLDENKE BOMOAIDFLBD, [Optional] RoomInventoryTagClientProperties PMLKCHHKGGA)
	{
	}
}
namespace RecRoom.RoomEconomy.RoomInventory
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public class RoomInventoryTagClientProperties
	{
		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public static RoomInventoryTagClientProperties Default
		{
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x66D6F40", Offset = "0x66D6140", VA = "0x1866D6F40")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public int DisplayOrder
		{
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x7BA180", Offset = "0x7B9380", VA = "0x1807BA180")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x7BF590", Offset = "0x7BE790", VA = "0x1807BF590")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x66D6D40", Offset = "0x66D5F40", VA = "0x1866D6D40")]
		public void AKBPFHFBLIJ(Dictionary<string, object> BHCBHFHAIBP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x7C5F10", Offset = "0x7C5110", VA = "0x1807C5F10")]
		public RoomInventoryTagClientProperties()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
internal static class KCNDLNFGNJG
{
	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x66D62F0", Offset = "0x66D54F0", VA = "0x1866D62F0")]
	public static int AIKANAOPCGA(long MKDPBDDBIMB)
	{
		return default(int);
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
