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
		[Cpp2IlInjected.Address(RVA = "0x7DC6AB0", Offset = "0x7DC50B0", VA = "0x187DC6AB0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x9EB550", Offset = "0x9E9B50", VA = "0x1809EB550", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x2064230", Offset = "0x2062830", VA = "0x182064230", Slot = "5")]
		public override void SetServiceCategoryIndices(List<int> globalFromLocalIndices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x7DC92E0", Offset = "0x7DC78E0", VA = "0x187DC92E0")]
		private void MEMPKEBCMCB(IServiceRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x7DC9530", Offset = "0x7DC7B30", VA = "0x187DC9530", Slot = "6")]
		public override void RegisterServices(IServiceRegistration registry, [In] ServiceBitsetFilter filter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x7DC9590", Offset = "0x7DC7B90", VA = "0x187DC9590", Slot = "7")]
		public override void RegisterTypes(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x7DC9C80", Offset = "0x7DC8280", VA = "0x187DC9C80")]
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
	[Cpp2IlInjected.Address(RVA = "0x7DC17E0", Offset = "0x7DBFDE0", VA = "0x187DC17E0")]
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
		[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
		public PFHOOLBOPML()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x56103F0", Offset = "0x560E9F0", VA = "0x1856103F0")]
		internal bool OHMDMODJNFP()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x4B20EF0", Offset = "0x4B1F4F0", VA = "0x184B20EF0")]
	protected HHHIMNBEFHF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x4B20C30", Offset = "0x4B1F230", VA = "0x184B20C30")]
	protected void EDLNHKNMOOL(GJNBDPFLKMA OHDGCHLKIKP, BJOHLLCFMIE LLPAKFGNDOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x4B207C0", Offset = "0x4B1EDC0", VA = "0x184B207C0")]
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
	[Cpp2IlInjected.Address(RVA = "0x387C190", Offset = "0x387A790", VA = "0x18387C190")]
	protected static T HLDPGMMJIBP<T>(EPFJFEANHAG LIAECCDAGKL, DFJLOPPNCOO<T> LLPAKFGNDOB) where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x387C090", Offset = "0x387A690", VA = "0x18387C090")]
	protected static void CDAGNGCOBML<T>(EPFJFEANHAG LIAECCDAGKL, DFJLOPPNCOO<T> LLPAKFGNDOB, T OHLIHBDBKCE) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
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
		[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
		public NDGFFGGIKHF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x53D5FF0", Offset = "0x53D45F0", VA = "0x1853D5FF0")]
		internal bool OHMDMODJNFP()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x552EAF0", Offset = "0x552D0F0", VA = "0x18552EAF0")]
	protected OGNMDCGBCFE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x552D8B0", Offset = "0x552BEB0", VA = "0x18552D8B0")]
	protected void EDLNHKNMOOL(GJNBDPFLKMA OHDGCHLKIKP, BJOHLLCFMIE LLPAKFGNDOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x552D6B0", Offset = "0x552BCB0", VA = "0x18552D6B0")]
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
		[Cpp2IlInjected.Address(RVA = "0x13F47B0", Offset = "0x13F2DB0", VA = "0x1813F47B0", Slot = "5")]
		get
		{
			return default(EPFJFEANHAG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x7DC20B0", Offset = "0x7DC06B0", VA = "0x187DC20B0", Slot = "6")]
	public void GJKEBEKMMLO(APJCDBKKFBB IDEMOBALCHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x7DC2B90", Offset = "0x7DC1190", VA = "0x187DC2B90", Slot = "7")]
	public void NHMAMKPPBPC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x7DC2670", Offset = "0x7DC0C70", VA = "0x187DC2670", Slot = "4")]
	public void KOJOAMNJMPI(EPFJFEANHAG CCMDDCOGLLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x7DC2600", Offset = "0x7DC0C00", VA = "0x187DC2600")]
	private void JDHIBBGKGJH(EPFJFEANHAG CCMDDCOGLLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x7DC2400", Offset = "0x7DC0A00", VA = "0x187DC2400")]
	private void HDODKJPDKJC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x7DC1DC0", Offset = "0x7DC03C0", VA = "0x187DC1DC0")]
	private void DPFEDFGJPFC(JFNEHGFGIDP GFFBMHPJFDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x7DC1D50", Offset = "0x7DC0350", VA = "0x187DC1D50", Slot = "8")]
	private void CNNCCPCEIKO(APJCDBKKFBB IDEMOBALCHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x11661B0", Offset = "0x11647B0", VA = "0x1811661B0", Slot = "9")]
	private void AIFFBAJCNLC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x7DC2D10", Offset = "0x7DC1310", VA = "0x187DC2D10")]
	public DDAJMFFKPDB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
[ALCBHDGKDFJ(0)]
internal class AIFBNJPAAFM : LBNINDMJBFE
{
	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x7DC1690", Offset = "0x7DBFC90", VA = "0x187DC1690", Slot = "5")]
	public override void DPFEDFGJPFC(BJOHLLCFMIE LLPAKFGNDOB, PJFGALKIBFD NNGJBDNKPJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x7DC1740", Offset = "0x7DBFD40", VA = "0x187DC1740", Slot = "7")]
	public override bool EFBDPMENOIA(Type MLCOGCMJLBB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x7DC17E0", Offset = "0x7DBFDE0", VA = "0x187DC17E0")]
	public AIFBNJPAAFM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
[ALCBHDGKDFJ(0)]
internal class LFANEDKINBC : LBNINDMJBFE
{
	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x7DC6940", Offset = "0x7DC4F40", VA = "0x187DC6940", Slot = "5")]
	public override void DPFEDFGJPFC(BJOHLLCFMIE LLPAKFGNDOB, PJFGALKIBFD NNGJBDNKPJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x7DC69F0", Offset = "0x7DC4FF0", VA = "0x187DC69F0", Slot = "7")]
	public override bool EFBDPMENOIA(Type MLCOGCMJLBB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x7DC17E0", Offset = "0x7DBFDE0", VA = "0x187DC17E0")]
	public LFANEDKINBC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
[IGJDHIGMCHK(typeof(GBOINGGHPAL), 1)]
internal class PNJCPKDNJHN : HHHIMNBEFHF<GBOINGGHPAL>
{
	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x7DC9150", Offset = "0x7DC7750", VA = "0x187DC9150", Slot = "5")]
	public override void DPFEDFGJPFC(BJOHLLCFMIE LLPAKFGNDOB, PJFGALKIBFD NNGJBDNKPJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x7DC92A0", Offset = "0x7DC78A0", VA = "0x187DC92A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
		public PFCOBCNFPMM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x7DC8ED0", Offset = "0x7DC74D0", VA = "0x187DC8ED0")]
		internal (int, int) DDPLNDBFPGB()
		{
			return default((int, int));
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x7DC8D90", Offset = "0x7DC7390", VA = "0x187DC8D90")]
		internal void CEPCMCGBFIH((int color, int material) value)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public override ANLDAMAMKAN[] PDDEGKGMBME
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x9EB570", Offset = "0x9E9B70", VA = "0x1809EB570", Slot = "7")]
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
		[Cpp2IlInjected.Address(RVA = "0x9EAD20", Offset = "0x9E9320", VA = "0x1809EAD20", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x7DC3400", Offset = "0x7DC1A00", VA = "0x187DC3400", Slot = "9")]
	public override void DPFEDFGJPFC(BJOHLLCFMIE LLPAKFGNDOB, GEKEMGPJFHA EOLFENMNECN, LEHLIJHKDMN OGJDOJELJPK, PJFGALKIBFD NNGJBDNKPJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x7DC37B0", Offset = "0x7DC1DB0", VA = "0x187DC37B0")]
	public EINDCJMGBIP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
[IGJDHIGMCHK(typeof(bool))]
internal class NLHPGCAFFBD : OGNMDCGBCFE<bool>
{
	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x7DC8820", Offset = "0x7DC6E20", VA = "0x187DC8820", Slot = "5")]
	public override void DPFEDFGJPFC(BJOHLLCFMIE LLPAKFGNDOB, PJFGALKIBFD NNGJBDNKPJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x7DC88B0", Offset = "0x7DC6EB0", VA = "0x187DC88B0")]
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
		[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
		public IEOBGJFPNBB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x7DC5BA0", Offset = "0x7DC41A0", VA = "0x187DC5BA0")]
		internal string DDPLNDBFPGB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x7DC5B30", Offset = "0x7DC4130", VA = "0x187DC5B30")]
		internal void CEPCMCGBFIH(string value)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x7DC1B70", Offset = "0x7DC0170", VA = "0x187DC1B70", Slot = "5")]
	public override void DPFEDFGJPFC(BJOHLLCFMIE LLPAKFGNDOB, PJFGALKIBFD NNGJBDNKPJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x7DC1D10", Offset = "0x7DC0310", VA = "0x187DC1D10")]
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
		[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
		public KLIFCACCIJN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x7DC6130", Offset = "0x7DC4730", VA = "0x187DC6130")]
		internal string DDPLNDBFPGB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x7DC60A0", Offset = "0x7DC46A0", VA = "0x187DC60A0")]
		internal void CEPCMCGBFIH(string value)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x7DC7A30", Offset = "0x7DC6030", VA = "0x187DC7A30", Slot = "5")]
	public override void DPFEDFGJPFC(BJOHLLCFMIE LLPAKFGNDOB, PJFGALKIBFD NNGJBDNKPJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x7DC7BD0", Offset = "0x7DC61D0", VA = "0x187DC7BD0")]
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
		[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
		public MINMLDDNIMB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x7DC77F0", Offset = "0x7DC5DF0", VA = "0x187DC77F0")]
		internal float DDPLNDBFPGB()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x7DC77D0", Offset = "0x7DC5DD0", VA = "0x187DC77D0")]
		internal void CEPCMCGBFIH(float value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x7DC78E0", Offset = "0x7DC5EE0", VA = "0x187DC78E0")]
		internal float LAHILPKMBGD()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x7DC77E0", Offset = "0x7DC5DE0", VA = "0x187DC77E0")]
		internal void CMNOPFBBGDG(float value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x7DC7760", Offset = "0x7DC5D60", VA = "0x187DC7760")]
		internal float CALJOOMMKJJ()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x7DC78D0", Offset = "0x7DC5ED0", VA = "0x187DC78D0")]
		internal void KJAOALLJALK(float value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x7DC7860", Offset = "0x7DC5E60", VA = "0x187DC7860")]
		internal float KBCONLAPCNK(int index)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x7DC7950", Offset = "0x7DC5F50", VA = "0x187DC7950")]
		internal void LILHLKAKJEE(int index, float value)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x7DC82E0", Offset = "0x7DC68E0", VA = "0x187DC82E0", Slot = "5")]
	public override void DPFEDFGJPFC(BJOHLLCFMIE LLPAKFGNDOB, PJFGALKIBFD NNGJBDNKPJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x7DC8710", Offset = "0x7DC6D10", VA = "0x187DC8710")]
	public NDOEKBAHBFN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
[IGJDHIGMCHK(typeof(float))]
internal class MMDPLOENAEN : OGNMDCGBCFE<float>
{
	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x7DC8210", Offset = "0x7DC6810", VA = "0x187DC8210", Slot = "5")]
	public override void DPFEDFGJPFC(BJOHLLCFMIE LLPAKFGNDOB, PJFGALKIBFD NNGJBDNKPJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x7DC82A0", Offset = "0x7DC68A0", VA = "0x187DC82A0")]
	public MMDPLOENAEN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
[IGJDHIGMCHK(typeof(int))]
internal class NIFEDINDCNP : OGNMDCGBCFE<int>
{
	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x7DC8750", Offset = "0x7DC6D50", VA = "0x187DC8750", Slot = "5")]
	public override void DPFEDFGJPFC(BJOHLLCFMIE LLPAKFGNDOB, PJFGALKIBFD NNGJBDNKPJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x7DC87E0", Offset = "0x7DC6DE0", VA = "0x187DC87E0")]
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
		[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
		public EIHHPKDKDLG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x7DC3000", Offset = "0x7DC1600", VA = "0x187DC3000")]
		internal float DDPLNDBFPGB()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x7DC2FE0", Offset = "0x7DC15E0", VA = "0x187DC2FE0")]
		internal void CEPCMCGBFIH(float value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x7DC33F0", Offset = "0x7DC19F0", VA = "0x187DC33F0")]
		internal float LAHILPKMBGD()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x7DC2FF0", Offset = "0x7DC15F0", VA = "0x187DC2FF0")]
		internal void CMNOPFBBGDG(float value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x7DC2FD0", Offset = "0x7DC15D0", VA = "0x187DC2FD0")]
		internal float CALJOOMMKJJ()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x7DC33E0", Offset = "0x7DC19E0", VA = "0x187DC33E0")]
		internal void KJAOALLJALK(float value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x7DC3010", Offset = "0x7DC1610", VA = "0x187DC3010")]
		internal float FHKLPGCBGCE(int index)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x7DC3180", Offset = "0x7DC1780", VA = "0x187DC3180")]
		internal void JAOHMHJKOFM(int index, float value)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x7DC52F0", Offset = "0x7DC38F0", VA = "0x187DC52F0", Slot = "5")]
	public override void DPFEDFGJPFC(BJOHLLCFMIE LLPAKFGNDOB, PJFGALKIBFD NNGJBDNKPJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x7DC5720", Offset = "0x7DC3D20", VA = "0x187DC5720")]
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
		[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
		public JLIKHIJKMIE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x7DC6060", Offset = "0x7DC4660", VA = "0x187DC6060")]
		internal int DDPLNDBFPGB()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x7DC6010", Offset = "0x7DC4610", VA = "0x187DC6010")]
		internal void CEPCMCGBFIH(int value)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x7DC3DB0", Offset = "0x7DC23B0", VA = "0x187DC3DB0", Slot = "5")]
	public override void DPFEDFGJPFC(BJOHLLCFMIE LLPAKFGNDOB, PJFGALKIBFD NNGJBDNKPJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x7DC3F50", Offset = "0x7DC2550", VA = "0x187DC3F50")]
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
	[Cpp2IlInjected.Address(RVA = "0x7DC3F90", Offset = "0x7DC2590", VA = "0x187DC3F90")]
	public static void CEHHHIKCAFD(Type IHBOPAHJNII, Type JGOKGDDPEPP)
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200001F")]
internal struct CAIPCDIBBFN
{
	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x7DC1820", Offset = "0x7DBFE20", VA = "0x187DC1820")]
	public static NativeList<ANLDAMAMKAN> HOJKKCLHJHN(EPFJFEANHAG LIAECCDAGKL, LEHLIJHKDMN OGJDOJELJPK)
	{
		return default(NativeList<ANLDAMAMKAN>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x7DC1A80", Offset = "0x7DC0080", VA = "0x187DC1A80")]
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
		[Cpp2IlInjected.Address(RVA = "0x7DC6670", Offset = "0x7DC4C70", VA = "0x187DC6670", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public bool KMGCMFNJFCC
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x7DC64E0", Offset = "0x7DC4AE0", VA = "0x187DC64E0", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public FHMOHIBLLDK HIMELPIAIGG
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x7DC6440", Offset = "0x7DC4A40", VA = "0x187DC6440", Slot = "8")]
		get
		{
			return default(FHMOHIBLLDK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public Type KFIKOGBAHMD
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x7DC6490", Offset = "0x7DC4A90", VA = "0x187DC6490", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event Action FMICLCBEALH
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x7DC61B0", Offset = "0x7DC47B0", VA = "0x187DC61B0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x7DC66D0", Offset = "0x7DC4CD0", VA = "0x187DC66D0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x7DC6850", Offset = "0x7DC4E50", VA = "0x187DC6850")]
	public KMNLOIIIDHN(EPFJFEANHAG LIAECCDAGKL, ANLDAMAMKAN LLPAKFGNDOB, LEHLIJHKDMN BEGHPONNAEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x7DC6560", Offset = "0x7DC4B60", VA = "0x187DC6560")]
	private void IJMGPLFFILC(GOGONLBFFOA APDBNIMCPID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x7DC6770", Offset = "0x7DC4D70", VA = "0x187DC6770", Slot = "10")]
	public void PHDCGNDDLGA(NBDNAFKNLDM OHLIHBDBKCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x7DC6250", Offset = "0x7DC4850", VA = "0x187DC6250", Slot = "11")]
	public void DGBNDJBCMEF(JBPLEEKMCJK OHLIHBDBKCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x7DC6370", Offset = "0x7DC4970", VA = "0x187DC6370", Slot = "12")]
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
		[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
		public DHNJJOHBIND()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x7DC2EF0", Offset = "0x7DC14F0", VA = "0x187DC2EF0")]
		internal bool DDPLNDBFPGB()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x7DC2DA0", Offset = "0x7DC13A0", VA = "0x187DC2DA0")]
		internal string CEPCMCGBFIH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x7DC2F40", Offset = "0x7DC1540", VA = "0x187DC2F40")]
		internal void LAHILPKMBGD(string value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x7DC2E20", Offset = "0x7DC1420", VA = "0x187DC2E20")]
		internal string CMNOPFBBGDG()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public ANLDAMAMKAN CAKAJDAKFAD
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x7DC3D40", Offset = "0x7DC2340", VA = "0x187DC3D40", Slot = "4")]
		get
		{
			return default(ANLDAMAMKAN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x7DC38D0", Offset = "0x7DC1ED0", VA = "0x187DC38D0", Slot = "5")]
	public void DPFEDFGJPFC(BJOHLLCFMIE LLPAKFGNDOB, PJFGALKIBFD NNGJBDNKPJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
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
	[Cpp2IlInjected.Address(RVA = "0x7DC7640", Offset = "0x7DC5C40", VA = "0x187DC7640")]
	public MFAMBBOANBD(LEHLIJHKDMN OGJDOJELJPK, PJFGALKIBFD NNGJBDNKPJC, Action<JFNEHGFGIDP> DOMHNPIFGCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x7DC72D0", Offset = "0x7DC58D0", VA = "0x187DC72D0")]
	public void INBFBIJIGKF(NativeList<JFNEHGFGIDP> MCCPIHKKDED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x7DC6CC0", Offset = "0x7DC52C0", VA = "0x187DC6CC0")]
	private void FBHHFIFOAFM(LNHHAEMFJCL FEHDPLGKCJJ, JFNEHGFGIDP GFFBMHPJFDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x7DC6C60", Offset = "0x7DC5260", VA = "0x187DC6C60")]
	public void BFGCAGHIAFA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x7DC6E60", Offset = "0x7DC5460", VA = "0x187DC6E60")]
	private void FJCGNHDCBDE(LNHHAEMFJCL FEHDPLGKCJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x7DC6BC0", Offset = "0x7DC51C0", VA = "0x187DC6BC0")]
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
			[Cpp2IlInjected.Address(RVA = "0xB76480", Offset = "0xB74A80", VA = "0x180B76480", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x7DC8CB0", Offset = "0x7DC72B0", VA = "0x187DC8CB0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x1285160", Offset = "0x1283760", VA = "0x181285160")]
		[DebuggerHidden]
		public NODBOGOPBHJ(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x7DC8D00", Offset = "0x7DC7300", VA = "0x187DC8D00", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x7DC8940", Offset = "0x7DC6F40", VA = "0x187DC8940", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x7DC88F0", Offset = "0x7DC6EF0", VA = "0x187DC88F0")]
		private void KILKBHNKCHN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x7DC8C60", Offset = "0x7DC7260", VA = "0x187DC8C60", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x7DC8BA0", Offset = "0x7DC71A0", VA = "0x187DC8BA0", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<ANLDAMAMKAN> System.Collections.Generic.IEnumerable<RecRoom.DataLayer.NetworkProperty>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x7DC8BA0", Offset = "0x7DC71A0", VA = "0x187DC8BA0", Slot = "5")]
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
	[Cpp2IlInjected.Address(RVA = "0x7DC5E20", Offset = "0x7DC4420", VA = "0x187DC5E20")]
	public JLDCIHFKDPA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x7DC5C40", Offset = "0x7DC4240", VA = "0x187DC5C40")]
	[IteratorStateMachine(typeof(NODBOGOPBHJ))]
	public IEnumerable<ANLDAMAMKAN> FDIKKNBDFPO(Type MLCOGCMJLBB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x7DC5C00", Offset = "0x7DC4200", VA = "0x187DC5C00", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x7DC5D20", Offset = "0x7DC4320", VA = "0x187DC5D20")]
	private long IGBCDELIGDK(ANLDAMAMKAN LLPAKFGNDOB)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x7DC5CE0", Offset = "0x7DC42E0", VA = "0x187DC5CE0")]
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
	[Cpp2IlInjected.Address(RVA = "0x7DC5AD0", Offset = "0x7DC40D0", VA = "0x187DC5AD0")]
	public IDMNMGBGBAO(int JAALIADHHOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x7DC5950", Offset = "0x7DC3F50", VA = "0x187DC5950")]
	public static IDMNMGBGBAO NOGOIOEICIB(int GDBMBEIFFOO, NativeArray<ANLDAMAMKAN> FBEFHOGBKOJ)
	{
		return default(IDMNMGBGBAO);
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x7DC5880", Offset = "0x7DC3E80", VA = "0x187DC5880")]
	public bool DJDKMBLFGDO(int OHHMJGCBCKD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x7DC5870", Offset = "0x7DC3E70", VA = "0x187DC5870")]
	public void DGBNDJBCMEF(int OHHMJGCBCKD, bool OHLIHBDBKCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x7DC58A0", Offset = "0x7DC3EA0", VA = "0x187DC58A0")]
	public bool JBMMPJAGPJN(ANLDAMAMKAN[] FBEFHOGBKOJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x7DC57C0", Offset = "0x7DC3DC0", VA = "0x187DC57C0")]
	public bool AMMCPDCIEJN(ANLDAMAMKAN[] FBEFHOGBKOJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x7DC5890", Offset = "0x7DC3E90", VA = "0x187DC5890", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x9EAD20", Offset = "0x9E9320", VA = "0x1809EAD20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x7DC5190", Offset = "0x7DC3790", VA = "0x187DC5190")]
	public HMHCIHEOKKP(LEHLIJHKDMN OGJDOJELJPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x7DC4F20", Offset = "0x7DC3520", VA = "0x187DC4F20")]
	public void NNOHEEPCFHD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x7DC4090", Offset = "0x7DC2690", VA = "0x187DC4090")]
	public void AMKNLBFBIMJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x7DC4320", Offset = "0x7DC2920", VA = "0x187DC4320")]
	public NativeList<JFNEHGFGIDP> HBBAPPJPLHN(NativeArray<ANLDAMAMKAN> FBEFHOGBKOJ)
	{
		return default(NativeList<JFNEHGFGIDP>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x7DC4B40", Offset = "0x7DC3140", VA = "0x187DC4B40")]
	private bool LANKKDDMBFF(HBHIABJICHG NNONNINKGND, IDMNMGBGBAO CCILCANPKLJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x388A9E0", Offset = "0x3888FE0", VA = "0x18388A9E0")]
	private void NJJKJELIFIH<TInterface, TAttribute>(Action<TInterface, TAttribute> APHALDJIPGE) where TInterface : HBHIABJICHG where TAttribute : Attribute
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x7DC4060", Offset = "0x7DC2660", VA = "0x187DC4060")]
	private void AFPHICACAPK(Type MLCOGCMJLBB, Type CMKGOIBIHLK, Type ADHOCMDHOLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x388A970", Offset = "0x3888F70", VA = "0x18388A970")]
	private TInterface CADFLFKPJIP<TInterface>(Type MLCOGCMJLBB)
	{
		return (TInterface)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x7DC4AA0", Offset = "0x7DC30A0", VA = "0x187DC4AA0")]
	private int JMMMIOGFOKG(HBHIABJICHG JGONMCGPFPB, int DPEJEDCKJBD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x7DC4810", Offset = "0x7DC2E10", VA = "0x187DC4810")]
	private void JLDMDDBEIGD(DLLIGHIHKGO NNONNINKGND, IGJDHIGMCHK IMANPKGHLPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x7DC4C10", Offset = "0x7DC3210", VA = "0x187DC4C10")]
	private void MKOCNIDHOPK(LPKJEGPPBHB NNONNINKGND, ALCBHDGKDFJ IMANPKGHLPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x7DC5000", Offset = "0x7DC3600", VA = "0x187DC5000")]
	private void OKFGPHLGMJF(KAPHDOPOBFB NNONNINKGND, ELIDOEJBMJL IMANPKGHLPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x7DC4250", Offset = "0x7DC2850", VA = "0x187DC4250")]
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
		[Cpp2IlInjected.Address(RVA = "0x2DF0300", Offset = "0x2DEE900", VA = "0x182DF0300")]
		get
		{
			return default(NativeList<JFNEHGFGIDP>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x7DC81B0", Offset = "0x7DC67B0", VA = "0x187DC81B0")]
	public MLLCPGDGMGK(List<HBHIABJICHG> LEKNHFLJJGN, NativeArray<JFNEHGFGIDP> MCCPIHKKDED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x7DC7C10", Offset = "0x7DC6210", VA = "0x187DC7C10", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x7DC7E80", Offset = "0x7DC6480", VA = "0x187DC7E80")]
	private NativeList<JFNEHGFGIDP> JBEOAABEGHJ(NativeArray<JFNEHGFGIDP> AHJOLBDODFI)
	{
		return default(NativeList<JFNEHGFGIDP>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x7DC7C50", Offset = "0x7DC6250", VA = "0x187DC7C50")]
	private bool GAKGBKLAAPD(HBHIABJICHG NNONNINKGND, IDMNMGBGBAO PKMAFGIFKHP, ANLDAMAMKAN LLPAKFGNDOB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x7DC7D40", Offset = "0x7DC6340", VA = "0x187DC7D40")]
	private void IHMCCCJFACL(HBHIABJICHG NNONNINKGND, IDMNMGBGBAO FOAOOIGNCJP, ANLDAMAMKAN NONDBGDJLCN)
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000029")]
internal struct HPFADEFAAKG : IComparer<JFNEHGFGIDP>
{
	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x7DC5760", Offset = "0x7DC3D60", VA = "0x187DC5760", Slot = "4")]
	public int Compare(JFNEHGFGIDP FDJHCIBLFFB, JFNEHGFGIDP CNIMJCCKEDM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x7DC5770", Offset = "0x7DC3D70", VA = "0x187DC5770")]
	public static void EGGGPIHMFEO(NativeList<JFNEHGFGIDP> MCCPIHKKDED)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
[AttributeUsage(AttributeTargets.Class)]
public class LOIKGEDNMCE : EJAAIPNKIOH
{
	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x7DC6AA0", Offset = "0x7DC50A0", VA = "0x187DC6AA0")]
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
