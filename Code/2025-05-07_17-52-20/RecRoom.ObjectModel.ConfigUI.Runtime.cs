using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using RecRoom;
using RecRoom.DataLayer.Attributes;
using RecRoom.DataLayer.Registration;
using RecRoom.Logging.Attributes;
using Unity.Collections;
using Unity.Mathematics;

[assembly: AssemblyVersion("0.0.0.0")]
namespace _LogRegistration.RecRoom_ObjectModel_ConfigUI_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[RecRoom.Logging.Attributes.Preserve]
	public class LogRegistrationIndex : BPLGCOBKJGC
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x7DD5FC0", Offset = "0x7DD4FC0", VA = "0x187DD5FC0", Slot = "4")]
		public override void AMBIAOGNIIF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xA1A700", Offset = "0xA19700", VA = "0x180A1A700")]
		public LogRegistrationIndex()
		{
		}
	}
}
namespace _AssemblyRegistry.RecRoom_ObjectModel_ConfigUI_Runtime
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
		private ServiceBitset bitset0;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public override string[] ServiceCategories
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x9F1550", Offset = "0x9F0550", VA = "0x1809F1550", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x204FCB0", Offset = "0x204ECB0", VA = "0x18204FCB0", Slot = "5")]
		public override void SetServiceCategoryIndices(List<int> globalFromLocalIndices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x7DD8800", Offset = "0x7DD7800", VA = "0x187DD8800")]
		private void MEMPKEBCMCB(IServiceRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x7DD8A50", Offset = "0x7DD7A50", VA = "0x187DD8A50", Slot = "6")]
		public override void RegisterServices(IServiceRegistration registry, [In] ServiceBitsetFilter filter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x7DD8AB0", Offset = "0x7DD7AB0", VA = "0x187DD8AB0", Slot = "7")]
		public override void RegisterTypes(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x7DD91D0", Offset = "0x7DD81D0", VA = "0x187DD91D0")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
internal abstract class LBNINDMJBFE : HHHIMNBEFHF<Enum>, LPKJEGPPBHB, DLLIGHIHKGO, HBHIABJICHG
{
	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "7")]
	public abstract bool EFBDPMENOIA(Type MLCOGCMJLBB);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x7DD0CB0", Offset = "0x7DCFCB0", VA = "0x187DD0CB0")]
	protected LBNINDMJBFE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
internal abstract class HHHIMNBEFHF<T> : DLLIGHIHKGO, HBHIABJICHG where T : Enum
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[CompilerGenerated]
	private sealed class PFHOOLBOPML
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		public BJOHLLCFMIE property;

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
		public PFHOOLBOPML()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x5601930", Offset = "0x5600930", VA = "0x185601930")]
		internal bool OHMDMODJNFP()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x4AE8C20", Offset = "0x4AE7C20", VA = "0x184AE8C20")]
	protected HHHIMNBEFHF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x4AE8950", Offset = "0x4AE7950", VA = "0x184AE8950")]
	protected void EDLNHKNMOOL(GJNBDPFLKMA OHDGCHLKIKP, BJOHLLCFMIE LLPAKFGNDOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x4AE84B0", Offset = "0x4AE74B0", VA = "0x184AE84B0")]
	protected void AELJKIKAAFC(JDPDONJONKN<T> OHDGCHLKIKP, BJOHLLCFMIE LLPAKFGNDOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "5")]
	public abstract void DPFEDFGJPFC(BJOHLLCFMIE LLPAKFGNDOB, PJFGALKIBFD NNGJBDNKPJC);
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
internal abstract class GJGLIPHAHMM : KAPHDOPOBFB, HBHIABJICHG
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public abstract ANLDAMAMKAN[] PDDEGKGMBME
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public abstract ANLDAMAMKAN[] KPIJLOOLFLF
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "9")]
	public abstract void DPFEDFGJPFC(BJOHLLCFMIE LLPAKFGNDOB, GEKEMGPJFHA EOLFENMNECN, LEHLIJHKDMN OGJDOJELJPK, PJFGALKIBFD NNGJBDNKPJC);

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x385DD60", Offset = "0x385CD60", VA = "0x18385DD60")]
	protected static T HLDPGMMJIBP<T>(EPFJFEANHAG LIAECCDAGKL, DFJLOPPNCOO<T> LLPAKFGNDOB) where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x385DC60", Offset = "0x385CC60", VA = "0x18385DC60")]
	protected static void CDAGNGCOBML<T>(EPFJFEANHAG LIAECCDAGKL, DFJLOPPNCOO<T> LLPAKFGNDOB, T OHLIHBDBKCE) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
	protected GJGLIPHAHMM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
internal abstract class OGNMDCGBCFE<T> : DLLIGHIHKGO, HBHIABJICHG where T : struct
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CompilerGenerated]
	private sealed class NDGFFGGIKHF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		public BJOHLLCFMIE property;

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
		public NDGFFGGIKHF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x53A6840", Offset = "0x53A5840", VA = "0x1853A6840")]
		internal bool OHMDMODJNFP()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x55186D0", Offset = "0x55176D0", VA = "0x1855186D0")]
	protected OGNMDCGBCFE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x5517410", Offset = "0x5516410", VA = "0x185517410")]
	protected void EDLNHKNMOOL(GJNBDPFLKMA OHDGCHLKIKP, BJOHLLCFMIE LLPAKFGNDOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x5517200", Offset = "0x5516200", VA = "0x185517200")]
	protected void AELJKIKAAFC(JDPDONJONKN<T> OHDGCHLKIKP, BJOHLLCFMIE LLPAKFGNDOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(Slot = "5")]
	public abstract void DPFEDFGJPFC(BJOHLLCFMIE LLPAKFGNDOB, PJFGALKIBFD NNGJBDNKPJC);
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
[RegisterService(typeof(GEKEMGPJFHA), new string[] { })]
internal class DDAJMFFKPDB : GEKEMGPJFHA, ILPONKCDKJP, MMMIGLKPHHG, KBDPBLKCNPK, FGICIDPFKIB
{
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private static readonly JBBHIJHGEPM PAJIGEJCNAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	[DependsOn]
	private LEHLIJHKDMN OGJDOJELJPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	[DependsOn]
	private PJFGALKIBFD FEKNENPPDGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private HMHCIHEOKKP NBLDAGKDDPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private EPFJFEANHAG LIAECCDAGKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private List<BJOHLLCFMIE> MJHNMMAIAFG;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public EPFJFEANHAG KEEJDCNLHGC
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x13D9310", Offset = "0x13D8310", VA = "0x1813D9310", Slot = "5")]
		get
		{
			return default(EPFJFEANHAG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x7DD1580", Offset = "0x7DD0580", VA = "0x187DD1580", Slot = "6")]
	public void GJKEBEKMMLO(APJCDBKKFBB IDEMOBALCHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x7DD2060", Offset = "0x7DD1060", VA = "0x187DD2060", Slot = "7")]
	public void NHMAMKPPBPC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x7DD1B40", Offset = "0x7DD0B40", VA = "0x187DD1B40", Slot = "4")]
	public void KOJOAMNJMPI(EPFJFEANHAG CCMDDCOGLLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x7DD1AD0", Offset = "0x7DD0AD0", VA = "0x187DD1AD0")]
	private void JDHIBBGKGJH(EPFJFEANHAG CCMDDCOGLLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x7DD18D0", Offset = "0x7DD08D0", VA = "0x187DD18D0")]
	private void HDODKJPDKJC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x7DD1290", Offset = "0x7DD0290", VA = "0x187DD1290")]
	private void DPFEDFGJPFC(JFNEHGFGIDP GFFBMHPJFDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x7DD1220", Offset = "0x7DD0220", VA = "0x187DD1220", Slot = "8")]
	private void CNNCCPCEIKO(APJCDBKKFBB IDEMOBALCHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x1151D80", Offset = "0x1150D80", VA = "0x181151D80", Slot = "9")]
	private void AIFFBAJCNLC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x7DD21F0", Offset = "0x7DD11F0", VA = "0x187DD21F0")]
	public DDAJMFFKPDB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
[ALCBHDGKDFJ(0)]
internal class AIFBNJPAAFM : LBNINDMJBFE
{
	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x7DD0B60", Offset = "0x7DCFB60", VA = "0x187DD0B60", Slot = "5")]
	public override void DPFEDFGJPFC(BJOHLLCFMIE LLPAKFGNDOB, PJFGALKIBFD NNGJBDNKPJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x7DD0C10", Offset = "0x7DCFC10", VA = "0x187DD0C10", Slot = "7")]
	public override bool EFBDPMENOIA(Type MLCOGCMJLBB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x7DD0CB0", Offset = "0x7DCFCB0", VA = "0x187DD0CB0")]
	public AIFBNJPAAFM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
[ALCBHDGKDFJ(0)]
internal class LFANEDKINBC : LBNINDMJBFE
{
	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x7DD5E50", Offset = "0x7DD4E50", VA = "0x187DD5E50", Slot = "5")]
	public override void DPFEDFGJPFC(BJOHLLCFMIE LLPAKFGNDOB, PJFGALKIBFD NNGJBDNKPJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x7DD5F00", Offset = "0x7DD4F00", VA = "0x187DD5F00", Slot = "7")]
	public override bool EFBDPMENOIA(Type MLCOGCMJLBB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x7DD0CB0", Offset = "0x7DCFCB0", VA = "0x187DD0CB0")]
	public LFANEDKINBC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
[IGJDHIGMCHK(typeof(GBOINGGHPAL), 1)]
internal class PNJCPKDNJHN : HHHIMNBEFHF<GBOINGGHPAL>
{
	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x7DD8670", Offset = "0x7DD7670", VA = "0x187DD8670", Slot = "5")]
	public override void DPFEDFGJPFC(BJOHLLCFMIE LLPAKFGNDOB, PJFGALKIBFD NNGJBDNKPJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x7DD87C0", Offset = "0x7DD77C0", VA = "0x187DD87C0")]
	public PNJCPKDNJHN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
[ELIDOEJBMJL(2)]
internal class EINDCJMGBIP : GJGLIPHAHMM
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[CompilerGenerated]
	private sealed class PFCOBCNFPMM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public GEKEMGPJFHA configUIService;

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
		public PFCOBCNFPMM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x7DD83F0", Offset = "0x7DD73F0", VA = "0x187DD83F0")]
		internal (int, int) DDPLNDBFPGB()
		{
			return default((int, int));
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x7DD82A0", Offset = "0x7DD72A0", VA = "0x187DD82A0")]
		internal void CEPCMCGBFIH((int color, int material) value)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public override ANLDAMAMKAN[] PDDEGKGMBME
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x9F1570", Offset = "0x9F0570", VA = "0x1809F1570", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public override ANLDAMAMKAN[] KPIJLOOLFLF
	{
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x9F0D20", Offset = "0x9EFD20", VA = "0x1809F0D20", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x7DD28E0", Offset = "0x7DD18E0", VA = "0x187DD28E0", Slot = "9")]
	public override void DPFEDFGJPFC(BJOHLLCFMIE LLPAKFGNDOB, GEKEMGPJFHA EOLFENMNECN, LEHLIJHKDMN OGJDOJELJPK, PJFGALKIBFD NNGJBDNKPJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x7DD2C90", Offset = "0x7DD1C90", VA = "0x187DD2C90")]
	public EINDCJMGBIP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
[IGJDHIGMCHK(typeof(bool))]
internal class NLHPGCAFFBD : OGNMDCGBCFE<bool>
{
	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x7DD7D30", Offset = "0x7DD6D30", VA = "0x187DD7D30", Slot = "5")]
	public override void DPFEDFGJPFC(BJOHLLCFMIE LLPAKFGNDOB, PJFGALKIBFD NNGJBDNKPJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x7DD7DC0", Offset = "0x7DD6DC0", VA = "0x187DD7DC0")]
	public NLHPGCAFFBD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
[IGJDHIGMCHK(typeof(FixedString32Bytes))]
internal class DCFONPLJHHG : OGNMDCGBCFE<FixedString32Bytes>
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[CompilerGenerated]
	private sealed class IEOBGJFPNBB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public BJOHLLCFMIE property;

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
		public IEOBGJFPNBB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x7DD50A0", Offset = "0x7DD40A0", VA = "0x187DD50A0")]
		internal string DDPLNDBFPGB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x7DD5030", Offset = "0x7DD4030", VA = "0x187DD5030")]
		internal void CEPCMCGBFIH(string value)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x7DD1040", Offset = "0x7DD0040", VA = "0x187DD1040", Slot = "5")]
	public override void DPFEDFGJPFC(BJOHLLCFMIE LLPAKFGNDOB, PJFGALKIBFD NNGJBDNKPJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x7DD11E0", Offset = "0x7DD01E0", VA = "0x187DD11E0")]
	public DCFONPLJHHG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
[IGJDHIGMCHK(typeof(FixedString64Bytes))]
internal class MKJIHNMKMHH : OGNMDCGBCFE<FixedString64Bytes>
{
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	[CompilerGenerated]
	private sealed class KLIFCACCIJN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public BJOHLLCFMIE property;

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
		public KLIFCACCIJN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x7DD5640", Offset = "0x7DD4640", VA = "0x187DD5640")]
		internal string DDPLNDBFPGB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x7DD55B0", Offset = "0x7DD45B0", VA = "0x187DD55B0")]
		internal void CEPCMCGBFIH(string value)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x7DD6F40", Offset = "0x7DD5F40", VA = "0x187DD6F40", Slot = "5")]
	public override void DPFEDFGJPFC(BJOHLLCFMIE LLPAKFGNDOB, PJFGALKIBFD NNGJBDNKPJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x7DD70E0", Offset = "0x7DD60E0", VA = "0x187DD70E0")]
	public MKJIHNMKMHH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
[IGJDHIGMCHK(typeof(float3))]
internal class NDOEKBAHBFN : OGNMDCGBCFE<float3>
{
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[CompilerGenerated]
	private sealed class MINMLDDNIMB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public BJOHLLCFMIE property;

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
		public MINMLDDNIMB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x7DD6D00", Offset = "0x7DD5D00", VA = "0x187DD6D00")]
		internal float DDPLNDBFPGB()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x7DD6CE0", Offset = "0x7DD5CE0", VA = "0x187DD6CE0")]
		internal void CEPCMCGBFIH(float value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x7DD6DF0", Offset = "0x7DD5DF0", VA = "0x187DD6DF0")]
		internal float LAHILPKMBGD()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x7DD6CF0", Offset = "0x7DD5CF0", VA = "0x187DD6CF0")]
		internal void CMNOPFBBGDG(float value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x7DD6C70", Offset = "0x7DD5C70", VA = "0x187DD6C70")]
		internal float CALJOOMMKJJ()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x7DD6DE0", Offset = "0x7DD5DE0", VA = "0x187DD6DE0")]
		internal void KJAOALLJALK(float value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x7DD6D70", Offset = "0x7DD5D70", VA = "0x187DD6D70")]
		internal float KBCONLAPCNK(int index)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x7DD6E60", Offset = "0x7DD5E60", VA = "0x187DD6E60")]
		internal void LILHLKAKJEE(int index, float value)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x7DD77F0", Offset = "0x7DD67F0", VA = "0x187DD77F0", Slot = "5")]
	public override void DPFEDFGJPFC(BJOHLLCFMIE LLPAKFGNDOB, PJFGALKIBFD NNGJBDNKPJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x7DD7C20", Offset = "0x7DD6C20", VA = "0x187DD7C20")]
	public NDOEKBAHBFN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
[IGJDHIGMCHK(typeof(float))]
internal class MMDPLOENAEN : OGNMDCGBCFE<float>
{
	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x7DD7720", Offset = "0x7DD6720", VA = "0x187DD7720", Slot = "5")]
	public override void DPFEDFGJPFC(BJOHLLCFMIE LLPAKFGNDOB, PJFGALKIBFD NNGJBDNKPJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x7DD77B0", Offset = "0x7DD67B0", VA = "0x187DD77B0")]
	public MMDPLOENAEN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
[IGJDHIGMCHK(typeof(int))]
internal class NIFEDINDCNP : OGNMDCGBCFE<int>
{
	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x7DD7C60", Offset = "0x7DD6C60", VA = "0x187DD7C60", Slot = "5")]
	public override void DPFEDFGJPFC(BJOHLLCFMIE LLPAKFGNDOB, PJFGALKIBFD NNGJBDNKPJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x7DD7CF0", Offset = "0x7DD6CF0", VA = "0x187DD7CF0")]
	public NIFEDINDCNP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
[IGJDHIGMCHK(typeof(quaternion))]
internal class HNPBEIMNHPC : OGNMDCGBCFE<quaternion>
{
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	[CompilerGenerated]
	private sealed class EIHHPKDKDLG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public BJOHLLCFMIE property;

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
		public EIHHPKDKDLG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x7DD24E0", Offset = "0x7DD14E0", VA = "0x187DD24E0")]
		internal float DDPLNDBFPGB()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x7DD24C0", Offset = "0x7DD14C0", VA = "0x187DD24C0")]
		internal void CEPCMCGBFIH(float value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x7DD28D0", Offset = "0x7DD18D0", VA = "0x187DD28D0")]
		internal float LAHILPKMBGD()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x7DD24D0", Offset = "0x7DD14D0", VA = "0x187DD24D0")]
		internal void CMNOPFBBGDG(float value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x7DD24B0", Offset = "0x7DD14B0", VA = "0x187DD24B0")]
		internal float CALJOOMMKJJ()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x7DD28C0", Offset = "0x7DD18C0", VA = "0x187DD28C0")]
		internal void KJAOALLJALK(float value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x7DD24F0", Offset = "0x7DD14F0", VA = "0x187DD24F0")]
		internal float FHKLPGCBGCE(int index)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x7DD2660", Offset = "0x7DD1660", VA = "0x187DD2660")]
		internal void JAOHMHJKOFM(int index, float value)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x7DD47F0", Offset = "0x7DD37F0", VA = "0x187DD47F0", Slot = "5")]
	public override void DPFEDFGJPFC(BJOHLLCFMIE LLPAKFGNDOB, PJFGALKIBFD NNGJBDNKPJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x7DD4C20", Offset = "0x7DD3C20", VA = "0x187DD4C20")]
	public HNPBEIMNHPC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
[IGJDHIGMCHK(typeof(uint))]
internal class FNIBLPGAEFK : OGNMDCGBCFE<uint>
{
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	[CompilerGenerated]
	private sealed class JLIKHIJKMIE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public BJOHLLCFMIE property;

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
		public JLIKHIJKMIE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x7DD5570", Offset = "0x7DD4570", VA = "0x187DD5570")]
		internal int DDPLNDBFPGB()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x7DD5520", Offset = "0x7DD4520", VA = "0x187DD5520")]
		internal void CEPCMCGBFIH(int value)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x7DD32A0", Offset = "0x7DD22A0", VA = "0x187DD32A0", Slot = "5")]
	public override void DPFEDFGJPFC(BJOHLLCFMIE LLPAKFGNDOB, PJFGALKIBFD NNGJBDNKPJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x7DD3440", Offset = "0x7DD2440", VA = "0x187DD3440")]
	public FNIBLPGAEFK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
internal struct JFNEHGFGIDP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public int LELLGICCHDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public ANLDAMAMKAN LLPAKFGNDOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public int DPEJEDCKJBD;
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
internal static class GDGOKFHHGBB
{
	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x7DD3480", Offset = "0x7DD2480", VA = "0x187DD3480")]
	public static void CEHHHIKCAFD(Type IHBOPAHJNII, Type JGOKGDDPEPP)
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200001F")]
internal struct CAIPCDIBBFN
{
	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x7DD0CF0", Offset = "0x7DCFCF0", VA = "0x187DD0CF0")]
	public static NativeList<ANLDAMAMKAN> HOJKKCLHJHN(EPFJFEANHAG LIAECCDAGKL, LEHLIJHKDMN OGJDOJELJPK)
	{
		return default(NativeList<ANLDAMAMKAN>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x7DD0F50", Offset = "0x7DCFF50", VA = "0x187DD0F50")]
	private static bool MCBEINKOBNB(ANLDAMAMKAN LLPAKFGNDOB, EPFJFEANHAG LIAECCDAGKL)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public class KMNLOIIIDHN : BJOHLLCFMIE, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private readonly ANLDAMAMKAN LLPAKFGNDOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private readonly LEHLIJHKDMN BEGHPONNAEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private readonly EPFJFEANHAG LIAECCDAGKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private bool DPFEMHMCJBH;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public string IJKBIMCGCEM
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x7DD5B80", Offset = "0x7DD4B80", VA = "0x187DD5B80", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public bool KMGCMFNJFCC
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x7DD59F0", Offset = "0x7DD49F0", VA = "0x187DD59F0", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public FHMOHIBLLDK HIMELPIAIGG
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x7DD5950", Offset = "0x7DD4950", VA = "0x187DD5950", Slot = "8")]
		get
		{
			return default(FHMOHIBLLDK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public Type KFIKOGBAHMD
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x7DD59A0", Offset = "0x7DD49A0", VA = "0x187DD59A0", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event Action FMICLCBEALH
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x7DD56C0", Offset = "0x7DD46C0", VA = "0x187DD56C0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x7DD5BE0", Offset = "0x7DD4BE0", VA = "0x187DD5BE0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x7DD5D60", Offset = "0x7DD4D60", VA = "0x187DD5D60")]
	public KMNLOIIIDHN(EPFJFEANHAG LIAECCDAGKL, ANLDAMAMKAN LLPAKFGNDOB, LEHLIJHKDMN BEGHPONNAEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x7DD5A70", Offset = "0x7DD4A70", VA = "0x187DD5A70")]
	private void IJMGPLFFILC(GOGONLBFFOA APDBNIMCPID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x7DD5C80", Offset = "0x7DD4C80", VA = "0x187DD5C80", Slot = "10")]
	public void PHDCGNDDLGA(NBDNAFKNLDM OHLIHBDBKCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x7DD5760", Offset = "0x7DD4760", VA = "0x187DD5760", Slot = "11")]
	public void DGBNDJBCMEF(JBPLEEKMCJK OHLIHBDBKCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x7DD5880", Offset = "0x7DD4880", VA = "0x187DD5880", Slot = "12")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
[LOIKGEDNMCE(1)]
internal sealed class FHOJCDCFPOC : LEBBDPMMKML, DLLIGHIHKGO, HBHIABJICHG
{
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[CompilerGenerated]
	private sealed class DHNJJOHBIND
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public BJOHLLCFMIE property;

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
		public DHNJJOHBIND()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x7DD23D0", Offset = "0x7DD13D0", VA = "0x187DD23D0")]
		internal bool DDPLNDBFPGB()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x7DD2280", Offset = "0x7DD1280", VA = "0x187DD2280")]
		internal string CEPCMCGBFIH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x7DD2420", Offset = "0x7DD1420", VA = "0x187DD2420")]
		internal void LAHILPKMBGD(string value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x7DD2300", Offset = "0x7DD1300", VA = "0x187DD2300")]
		internal string CMNOPFBBGDG()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public ANLDAMAMKAN CAKAJDAKFAD
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x7DD3230", Offset = "0x7DD2230", VA = "0x187DD3230", Slot = "4")]
		get
		{
			return default(ANLDAMAMKAN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x7DD2DC0", Offset = "0x7DD1DC0", VA = "0x187DD2DC0", Slot = "5")]
	public void DPFEDFGJPFC(BJOHLLCFMIE LLPAKFGNDOB, PJFGALKIBFD NNGJBDNKPJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
	public FHOJCDCFPOC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
internal class MFAMBBOANBD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private readonly LEHLIJHKDMN OGJDOJELJPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	private readonly PJFGALKIBFD NNGJBDNKPJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	private readonly Action<JFNEHGFGIDP> DOMHNPIFGCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private readonly HashSet<LNHHAEMFJCL> ECGIJAELLHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private readonly Dictionary<LNHHAEMFJCL, List<JFNEHGFGIDP>> OLANPPFNCEK;

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x7DD6B50", Offset = "0x7DD5B50", VA = "0x187DD6B50")]
	public MFAMBBOANBD(LEHLIJHKDMN OGJDOJELJPK, PJFGALKIBFD NNGJBDNKPJC, Action<JFNEHGFGIDP> DOMHNPIFGCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x7DD67E0", Offset = "0x7DD57E0", VA = "0x187DD67E0")]
	public void INBFBIJIGKF(NativeList<JFNEHGFGIDP> MCCPIHKKDED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x7DD61D0", Offset = "0x7DD51D0", VA = "0x187DD61D0")]
	private void FBHHFIFOAFM(LNHHAEMFJCL FEHDPLGKCJJ, JFNEHGFGIDP GFFBMHPJFDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x7DD6170", Offset = "0x7DD5170", VA = "0x187DD6170")]
	public void BFGCAGHIAFA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x7DD6370", Offset = "0x7DD5370", VA = "0x187DD6370")]
	private void FJCGNHDCBDE(LNHHAEMFJCL FEHDPLGKCJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x7DD60D0", Offset = "0x7DD50D0", VA = "0x187DD60D0")]
	private void AGGACJELBKF(LNHHAEMFJCL FEHDPLGKCJJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
internal class JLDCIHFKDPA : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	[CompilerGenerated]
	private sealed class NODBOGOPBHJ : IEnumerable<ANLDAMAMKAN>, IEnumerable, IEnumerator<ANLDAMAMKAN>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private ANLDAMAMKAN <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		public JLDCIHFKDPA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private Type type;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		public Type <>3__type;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private NativeParallelMultiHashMap<long, int>.Enumerator <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		private ANLDAMAMKAN System.Collections.Generic.IEnumerator<RecRoom.DataLayer.NetworkProperty>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0xB72E60", Offset = "0xB71E60", VA = "0x180B72E60", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default(ANLDAMAMKAN);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600008A")]
			[Cpp2IlInjected.Address(RVA = "0x7DD81C0", Offset = "0x7DD71C0", VA = "0x187DD81C0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x126B660", Offset = "0x126A660", VA = "0x18126B660")]
		[DebuggerHidden]
		public NODBOGOPBHJ(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x7DD8210", Offset = "0x7DD7210", VA = "0x187DD8210", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x7DD7E50", Offset = "0x7DD6E50", VA = "0x187DD7E50", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x7DD7E00", Offset = "0x7DD6E00", VA = "0x187DD7E00")]
		private void KILKBHNKCHN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x7DD8170", Offset = "0x7DD7170", VA = "0x187DD8170", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x7DD80B0", Offset = "0x7DD70B0", VA = "0x187DD80B0", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<ANLDAMAMKAN> System.Collections.Generic.IEnumerable<RecRoom.DataLayer.NetworkProperty>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x7DD80B0", Offset = "0x7DD70B0", VA = "0x187DD80B0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private static readonly JBBHIJHGEPM PAJIGEJCNAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private NativeParallelMultiHashMap<long, int> CDAIFJDEDIF;

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x7DD5330", Offset = "0x7DD4330", VA = "0x187DD5330")]
	public JLDCIHFKDPA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x7DD5140", Offset = "0x7DD4140", VA = "0x187DD5140")]
	[IteratorStateMachine(typeof(NODBOGOPBHJ))]
	public IEnumerable<ANLDAMAMKAN> FDIKKNBDFPO(Type MLCOGCMJLBB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x7DD5100", Offset = "0x7DD4100", VA = "0x187DD5100", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x7DD5220", Offset = "0x7DD4220", VA = "0x187DD5220")]
	private long IGBCDELIGDK(ANLDAMAMKAN LLPAKFGNDOB)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x7DD51E0", Offset = "0x7DD41E0", VA = "0x187DD51E0")]
	private long IGBCDELIGDK(Type MLCOGCMJLBB)
	{
		return default(long);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
internal struct IDMNMGBGBAO : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private NativeBitArray FOAOOIGNCJP;

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x7DD4FD0", Offset = "0x7DD3FD0", VA = "0x187DD4FD0")]
	public IDMNMGBGBAO(int JAALIADHHOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x7DD4E50", Offset = "0x7DD3E50", VA = "0x187DD4E50")]
	public static IDMNMGBGBAO NOGOIOEICIB(int GDBMBEIFFOO, NativeArray<ANLDAMAMKAN> FBEFHOGBKOJ)
	{
		return default(IDMNMGBGBAO);
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x7DD4D80", Offset = "0x7DD3D80", VA = "0x187DD4D80")]
	public bool DJDKMBLFGDO(int OHHMJGCBCKD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x7DD4D70", Offset = "0x7DD3D70", VA = "0x187DD4D70")]
	public void DGBNDJBCMEF(int OHHMJGCBCKD, bool OHLIHBDBKCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x7DD4DA0", Offset = "0x7DD3DA0", VA = "0x187DD4DA0")]
	public bool JBMMPJAGPJN(ANLDAMAMKAN[] FBEFHOGBKOJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x7DD4CC0", Offset = "0x7DD3CC0", VA = "0x187DD4CC0")]
	public bool AMMCPDCIEJN(ANLDAMAMKAN[] FBEFHOGBKOJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x7DD4D90", Offset = "0x7DD3D90", VA = "0x187DD4D90", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
internal class HMHCIHEOKKP
{
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private static readonly JBBHIJHGEPM PAJIGEJCNAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private readonly LEHLIJHKDMN OGJDOJELJPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private readonly List<HBHIABJICHG> LEKNHFLJJGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private readonly JLDCIHFKDPA CDAIFJDEDIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private NativeParallelMultiHashMap<int, int> DBGBIKPCCLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private NativeList<int> PNJGOEFAFDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private bool DPFEMHMCJBH;

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public List<HBHIABJICHG> DICDBEOPPHI
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x9F0D20", Offset = "0x9EFD20", VA = "0x1809F0D20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x7DD4690", Offset = "0x7DD3690", VA = "0x187DD4690")]
	public HMHCIHEOKKP(LEHLIJHKDMN OGJDOJELJPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x7DD4410", Offset = "0x7DD3410", VA = "0x187DD4410")]
	public void NNOHEEPCFHD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x7DD3580", Offset = "0x7DD2580", VA = "0x187DD3580")]
	public void AMKNLBFBIMJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x7DD3810", Offset = "0x7DD2810", VA = "0x187DD3810")]
	public NativeList<JFNEHGFGIDP> HBBAPPJPLHN(NativeArray<ANLDAMAMKAN> FBEFHOGBKOJ)
	{
		return default(NativeList<JFNEHGFGIDP>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x7DD4030", Offset = "0x7DD3030", VA = "0x187DD4030")]
	private bool LANKKDDMBFF(HBHIABJICHG NNONNINKGND, IDMNMGBGBAO CCILCANPKLJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x386C860", Offset = "0x386B860", VA = "0x18386C860")]
	private void NJJKJELIFIH<TInterface, TAttribute>(Action<TInterface, TAttribute> APHALDJIPGE) where TInterface : HBHIABJICHG where TAttribute : Attribute
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x7DD3550", Offset = "0x7DD2550", VA = "0x187DD3550")]
	private void AFPHICACAPK(Type MLCOGCMJLBB, Type CMKGOIBIHLK, Type ADHOCMDHOLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x386C7F0", Offset = "0x386B7F0", VA = "0x18386C7F0")]
	private TInterface CADFLFKPJIP<TInterface>(Type MLCOGCMJLBB)
	{
		return (TInterface)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x7DD3F90", Offset = "0x7DD2F90", VA = "0x187DD3F90")]
	private int JMMMIOGFOKG(HBHIABJICHG JGONMCGPFPB, int DPEJEDCKJBD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x7DD3D00", Offset = "0x7DD2D00", VA = "0x187DD3D00")]
	private void JLDMDDBEIGD(DLLIGHIHKGO NNONNINKGND, IGJDHIGMCHK IMANPKGHLPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x7DD4100", Offset = "0x7DD3100", VA = "0x187DD4100")]
	private void MKOCNIDHOPK(LPKJEGPPBHB NNONNINKGND, ALCBHDGKDFJ IMANPKGHLPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x7DD44F0", Offset = "0x7DD34F0", VA = "0x187DD44F0")]
	private void OKFGPHLGMJF(KAPHDOPOBFB NNONNINKGND, ELIDOEJBMJL IMANPKGHLPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x7DD3740", Offset = "0x7DD2740", VA = "0x187DD3740")]
	private void DBMCNLGMHPB(LEBBDPMMKML NNONNINKGND, LOIKGEDNMCE IMANPKGHLPM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
internal struct MLLCPGDGMGK : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private readonly List<HBHIABJICHG> LEKNHFLJJGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private NativeList<JFNEHGFGIDP> HNGDKDGPENN;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public NativeList<JFNEHGFGIDP> PDHFLJOOICF
	{
		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x2DEFFA0", Offset = "0x2DEEFA0", VA = "0x182DEFFA0")]
		get
		{
			return default(NativeList<JFNEHGFGIDP>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x7DD76C0", Offset = "0x7DD66C0", VA = "0x187DD76C0")]
	public MLLCPGDGMGK(List<HBHIABJICHG> LEKNHFLJJGN, NativeArray<JFNEHGFGIDP> MCCPIHKKDED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x7DD7120", Offset = "0x7DD6120", VA = "0x187DD7120", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x7DD7390", Offset = "0x7DD6390", VA = "0x187DD7390")]
	private NativeList<JFNEHGFGIDP> JBEOAABEGHJ(NativeArray<JFNEHGFGIDP> AHJOLBDODFI)
	{
		return default(NativeList<JFNEHGFGIDP>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x7DD7160", Offset = "0x7DD6160", VA = "0x187DD7160")]
	private bool GAKGBKLAAPD(HBHIABJICHG NNONNINKGND, IDMNMGBGBAO PKMAFGIFKHP, ANLDAMAMKAN LLPAKFGNDOB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x7DD7250", Offset = "0x7DD6250", VA = "0x187DD7250")]
	private void IHMCCCJFACL(HBHIABJICHG NNONNINKGND, IDMNMGBGBAO FOAOOIGNCJP, ANLDAMAMKAN NONDBGDJLCN)
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000029")]
internal struct HPFADEFAAKG : IComparer<JFNEHGFGIDP>
{
	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x7DD4C60", Offset = "0x7DD3C60", VA = "0x187DD4C60", Slot = "4")]
	public int Compare(JFNEHGFGIDP FDJHCIBLFFB, JFNEHGFGIDP CNIMJCCKEDM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x7DD4C70", Offset = "0x7DD3C70", VA = "0x187DD4C70")]
	public static void EGGGPIHMFEO(NativeList<JFNEHGFGIDP> MCCPIHKKDED)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
[AttributeUsage(AttributeTargets.Class)]
public class LOIKGEDNMCE : EJAAIPNKIOH
{
	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x7DD5FB0", Offset = "0x7DD4FB0", VA = "0x187DD5FB0")]
	public LOIKGEDNMCE(int MHNIDGOLKKJ = 1)
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
