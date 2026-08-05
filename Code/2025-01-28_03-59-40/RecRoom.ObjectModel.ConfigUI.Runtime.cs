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
	public class LogRegistrationIndex : FOFAFNFGNAM
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x736FB00", Offset = "0x736ED00", VA = "0x18736FB00", Slot = "4")]
		public override void JMFBCAGPLCG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x91D620", Offset = "0x91C820", VA = "0x18091D620")]
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
			[Cpp2IlInjected.Address(RVA = "0x8F85D0", Offset = "0x8F77D0", VA = "0x1808F85D0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x1DE0C10", Offset = "0x1DDFE10", VA = "0x181DE0C10", Slot = "5")]
		public override void SetServiceCategoryIndices(List<int> globalFromLocalIndices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x7372B00", Offset = "0x7371D00", VA = "0x187372B00")]
		private void GAEACHOPMAB(IServiceRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x7372D40", Offset = "0x7371F40", VA = "0x187372D40", Slot = "6")]
		public override void RegisterServices(IServiceRegistration registry, [In] ServiceBitsetFilter filter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x7372DA0", Offset = "0x7371FA0", VA = "0x187372DA0", Slot = "7")]
		public override void RegisterTypes(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x7373490", Offset = "0x7372690", VA = "0x187373490")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
internal abstract class CNIMFDKOMJF : IBLGIJDPOAM<Enum>, BIFNMGNAGJP, HPPODOGBKNA, GFEACFNHNGJ
{
	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "7")]
	public abstract bool EJJLBHEECPI(Type MDOOANEGCAH);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x736B610", Offset = "0x736A810", VA = "0x18736B610")]
	protected CNIMFDKOMJF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
internal abstract class IBLGIJDPOAM<T> : HPPODOGBKNA, GFEACFNHNGJ where T : Enum
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[CompilerGenerated]
	private sealed class PMBDGKEHFNF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		public KHJBOKAGKHP property;

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x901140", Offset = "0x900340", VA = "0x180901140")]
		public PMBDGKEHFNF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x4F41500", Offset = "0x4F40700", VA = "0x184F41500")]
		internal bool LIJJAFBACFM()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x45A9310", Offset = "0x45A8510", VA = "0x1845A9310")]
	protected IBLGIJDPOAM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x45A9050", Offset = "0x45A8250", VA = "0x1845A9050")]
	protected void LFBHHAFNCMG(NJNMFINDCPE CFNJPDBBFFB, KHJBOKAGKHP FPOONLFOOIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x3EF8680", Offset = "0x3EF7880", VA = "0x183EF8680")]
	protected void KIFPBOCHJGJ(BICEINPDFOM<T> CFNJPDBBFFB, KHJBOKAGKHP FPOONLFOOIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "5")]
	public abstract void PEMNBFJKEOJ(KHJBOKAGKHP FPOONLFOOIF, IMOJHDCELFM LIDLPLGMNKB);
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
internal abstract class COONEGLMIBA : FAAMODDINCI, GFEACFNHNGJ
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public abstract GFCAKFAODMC[] CIKCNDMAOAH
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public abstract GFCAKFAODMC[] KHBJMLLGNCC
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "9")]
	public abstract void PEMNBFJKEOJ(KHJBOKAGKHP FPOONLFOOIF, EPPLHPOGBCG AEIKEPDMKNJ, DFNEHJMGEOJ HKEKABKNMAE, IMOJHDCELFM LIDLPLGMNKB);

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x30BF960", Offset = "0x30BEB60", VA = "0x1830BF960")]
	protected static T ELJNFBABDDE<T>(NDNBDIACCIO MHDKMAGHJOG, JNACMFGBLNP<T> FPOONLFOOIF) where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x30BF9B0", Offset = "0x30BEBB0", VA = "0x1830BF9B0")]
	protected static void PIKNAICMCBK<T>(NDNBDIACCIO MHDKMAGHJOG, JNACMFGBLNP<T> FPOONLFOOIF, T OMEFCJCOLII) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x901140", Offset = "0x900340", VA = "0x180901140")]
	protected COONEGLMIBA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
internal abstract class EFLBDEJCLKA<T> : HPPODOGBKNA, GFEACFNHNGJ where T : struct
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CompilerGenerated]
	private sealed class FCFALAODPDM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		public KHJBOKAGKHP property;

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x901140", Offset = "0x900340", VA = "0x180901140")]
		public FCFALAODPDM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x42DD4A0", Offset = "0x42DC6A0", VA = "0x1842DD4A0")]
		internal bool LIJJAFBACFM()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x3EF9EE0", Offset = "0x3EF90E0", VA = "0x183EF9EE0")]
	protected EFLBDEJCLKA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x3EF9340", Offset = "0x3EF8540", VA = "0x183EF9340")]
	protected void LFBHHAFNCMG(NJNMFINDCPE CFNJPDBBFFB, KHJBOKAGKHP FPOONLFOOIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x3EF88D0", Offset = "0x3EF7AD0", VA = "0x183EF88D0")]
	protected void KIFPBOCHJGJ(BICEINPDFOM<T> CFNJPDBBFFB, KHJBOKAGKHP FPOONLFOOIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(Slot = "5")]
	public abstract void PEMNBFJKEOJ(KHJBOKAGKHP FPOONLFOOIF, IMOJHDCELFM LIDLPLGMNKB);
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
[RegisterService(typeof(EPPLHPOGBCG), new string[] { })]
internal class PFMINEPAEIF : EPPLHPOGBCG, FMGJOLNHDJA, CIDGALBBDPG, CDKIFFPDAFF, AGGHCDPFEAK
{
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private static readonly KJMCEDJMPPA MOKKIOIDAGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	[DependsOn]
	private DFNEHJMGEOJ HKEKABKNMAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	[DependsOn]
	private IMOJHDCELFM DCOHDLHCPEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private PDCAHPFHDMG NHPLBPJIMDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private NDNBDIACCIO MHDKMAGHJOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private List<KHJBOKAGKHP> FHLKEKGNHGL;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public NDNBDIACCIO LNLNBFBEIAM
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x11E60C0", Offset = "0x11E52C0", VA = "0x1811E60C0", Slot = "5")]
		get
		{
			return default(NDNBDIACCIO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x7371ED0", Offset = "0x73710D0", VA = "0x187371ED0", Slot = "6")]
	public void IKMJEIIMCKI(DMNOAHHBJOJ CPBDPEKDPAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x7371860", Offset = "0x7370A60", VA = "0x187371860", Slot = "7")]
	public void APIIJJHOIBL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x73719A0", Offset = "0x7370BA0", VA = "0x1873719A0", Slot = "4")]
	public void IJJBFKINCLH(NDNBDIACCIO JGMOJBKCECC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x7372780", Offset = "0x7371980", VA = "0x187372780")]
	private void PKFNDFIJMNN(NDNBDIACCIO JGMOJBKCECC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x7372220", Offset = "0x7371420", VA = "0x187372220")]
	private void LJFGICBBCIC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x7372480", Offset = "0x7371680", VA = "0x187372480")]
	private void PEMNBFJKEOJ(KELOAIDNFMF AFJMEJNMLGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x7372410", Offset = "0x7371610", VA = "0x187372410", Slot = "8")]
	private void MDGJKGBLCGG(DMNOAHHBJOJ CPBDPEKDPAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x7371960", Offset = "0x7370B60", VA = "0x187371960", Slot = "9")]
	private void DEIJODOHECD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x7372890", Offset = "0x7371A90", VA = "0x187372890")]
	public PFMINEPAEIF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
[BIIDJKJFFLA(0)]
internal class BNOHJBDMIAE : CNIMFDKOMJF
{
	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x736B560", Offset = "0x736A760", VA = "0x18736B560", Slot = "5")]
	public override void PEMNBFJKEOJ(KHJBOKAGKHP FPOONLFOOIF, IMOJHDCELFM LIDLPLGMNKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x736B4C0", Offset = "0x736A6C0", VA = "0x18736B4C0", Slot = "7")]
	public override bool EJJLBHEECPI(Type MDOOANEGCAH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x736B610", Offset = "0x736A810", VA = "0x18736B610")]
	public BNOHJBDMIAE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
[BIIDJKJFFLA(0)]
internal class IDAAAGBKGFD : CNIMFDKOMJF
{
	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x736D4C0", Offset = "0x736C6C0", VA = "0x18736D4C0", Slot = "5")]
	public override void PEMNBFJKEOJ(KHJBOKAGKHP FPOONLFOOIF, IMOJHDCELFM LIDLPLGMNKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x736D410", Offset = "0x736C610", VA = "0x18736D410", Slot = "7")]
	public override bool EJJLBHEECPI(Type MDOOANEGCAH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x736B610", Offset = "0x736A810", VA = "0x18736B610")]
	public IDAAAGBKGFD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
[OOEGBIGOMOL(typeof(MIAEMOOKOJL), 1)]
internal class KBFBAGNKAGA : IBLGIJDPOAM<MIAEMOOKOJL>
{
	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x736E4A0", Offset = "0x736D6A0", VA = "0x18736E4A0", Slot = "5")]
	public override void PEMNBFJKEOJ(KHJBOKAGKHP FPOONLFOOIF, IMOJHDCELFM LIDLPLGMNKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x736E5F0", Offset = "0x736D7F0", VA = "0x18736E5F0")]
	public KBFBAGNKAGA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
[FIDBNOHMKFK(2)]
internal class CNJONMHKDEP : COONEGLMIBA
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[CompilerGenerated]
	private sealed class FHAEBMFAJEF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public EPPLHPOGBCG configUIService;

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x901140", Offset = "0x900340", VA = "0x180901140")]
		public FHAEBMFAJEF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x736C420", Offset = "0x736B620", VA = "0x18736C420")]
		internal (int, int) EAKGGGEHJML()
		{
			return default((int, int));
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x736C690", Offset = "0x736B890", VA = "0x18736C690")]
		internal void IDHOJNGKEFK((int color, int material) value)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public override GFCAKFAODMC[] CIKCNDMAOAH
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x8F4D10", Offset = "0x8F3F10", VA = "0x1808F4D10", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public override GFCAKFAODMC[] KHBJMLLGNCC
	{
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x8F2BF0", Offset = "0x8F1DF0", VA = "0x1808F2BF0", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x736B650", Offset = "0x736A850", VA = "0x18736B650", Slot = "9")]
	public override void PEMNBFJKEOJ(KHJBOKAGKHP FPOONLFOOIF, EPPLHPOGBCG AEIKEPDMKNJ, DFNEHJMGEOJ HKEKABKNMAE, IMOJHDCELFM LIDLPLGMNKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x736BA00", Offset = "0x736AC00", VA = "0x18736BA00")]
	public CNJONMHKDEP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
[OOEGBIGOMOL(typeof(bool))]
internal class DJIIEPMEDMN : EFLBDEJCLKA<bool>
{
	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x736BB30", Offset = "0x736AD30", VA = "0x18736BB30", Slot = "5")]
	public override void PEMNBFJKEOJ(KHJBOKAGKHP FPOONLFOOIF, IMOJHDCELFM LIDLPLGMNKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x736BBC0", Offset = "0x736ADC0", VA = "0x18736BBC0")]
	public DJIIEPMEDMN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
[OOEGBIGOMOL(typeof(FixedString32Bytes))]
internal class FEMEODPPHDD : EFLBDEJCLKA<FixedString32Bytes>
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[CompilerGenerated]
	private sealed class LACOBKMOIMP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public KHJBOKAGKHP property;

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x901140", Offset = "0x900340", VA = "0x180901140")]
		public LACOBKMOIMP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x736EE10", Offset = "0x736E010", VA = "0x18736EE10")]
		internal string EAKGGGEHJML()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x736EE70", Offset = "0x736E070", VA = "0x18736EE70")]
		internal void IDHOJNGKEFK(string value)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x736C240", Offset = "0x736B440", VA = "0x18736C240", Slot = "5")]
	public override void PEMNBFJKEOJ(KHJBOKAGKHP FPOONLFOOIF, IMOJHDCELFM LIDLPLGMNKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x736C3E0", Offset = "0x736B5E0", VA = "0x18736C3E0")]
	public FEMEODPPHDD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
[OOEGBIGOMOL(typeof(FixedString64Bytes))]
internal class KFOGJGBFOBO : EFLBDEJCLKA<FixedString64Bytes>
{
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	[CompilerGenerated]
	private sealed class APLFFDLLDPH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public KHJBOKAGKHP property;

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x901140", Offset = "0x900340", VA = "0x180901140")]
		public APLFFDLLDPH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x736B280", Offset = "0x736A480", VA = "0x18736B280")]
		internal string EAKGGGEHJML()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x736B300", Offset = "0x736A500", VA = "0x18736B300")]
		internal void IDHOJNGKEFK(string value)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x736E630", Offset = "0x736D830", VA = "0x18736E630", Slot = "5")]
	public override void PEMNBFJKEOJ(KHJBOKAGKHP FPOONLFOOIF, IMOJHDCELFM LIDLPLGMNKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x736E7D0", Offset = "0x736D9D0", VA = "0x18736E7D0")]
	public KFOGJGBFOBO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
[OOEGBIGOMOL(typeof(float3))]
internal class ANMMDCKKJBK : EFLBDEJCLKA<float3>
{
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[CompilerGenerated]
	private sealed class ENMNEANJGAI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public KHJBOKAGKHP property;

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x901140", Offset = "0x900340", VA = "0x180901140")]
		public ENMNEANJGAI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x736C050", Offset = "0x736B250", VA = "0x18736C050")]
		internal float EAKGGGEHJML()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x736C1B0", Offset = "0x736B3B0", VA = "0x18736C1B0")]
		internal void IDHOJNGKEFK(float value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x736C0C0", Offset = "0x736B2C0", VA = "0x18736C0C0")]
		internal float EEJCMCLBNLL()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x736C130", Offset = "0x736B330", VA = "0x18736C130")]
		internal void FBFIMEIIJKF(float value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x736C1C0", Offset = "0x736B3C0", VA = "0x18736C1C0")]
		internal float OEOABNENEKP()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x736C230", Offset = "0x736B430", VA = "0x18736C230")]
		internal void ONIMLJLAOGD(float value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x736C140", Offset = "0x736B340", VA = "0x18736C140")]
		internal float GIHJMFAJNED(int index)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x736BF70", Offset = "0x736B170", VA = "0x18736BF70")]
		internal void APBAGFHPNHC(int index, float value)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x736AE10", Offset = "0x736A010", VA = "0x18736AE10", Slot = "5")]
	public override void PEMNBFJKEOJ(KHJBOKAGKHP FPOONLFOOIF, IMOJHDCELFM LIDLPLGMNKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x736B240", Offset = "0x736A440", VA = "0x18736B240")]
	public ANMMDCKKJBK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
[OOEGBIGOMOL(typeof(float))]
internal class BLCKBABEEKH : EFLBDEJCLKA<float>
{
	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x736B3F0", Offset = "0x736A5F0", VA = "0x18736B3F0", Slot = "5")]
	public override void PEMNBFJKEOJ(KHJBOKAGKHP FPOONLFOOIF, IMOJHDCELFM LIDLPLGMNKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x736B480", Offset = "0x736A680", VA = "0x18736B480")]
	public BLCKBABEEKH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
[OOEGBIGOMOL(typeof(int))]
internal class JGGCMGDJJHK : EFLBDEJCLKA<int>
{
	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x736D9E0", Offset = "0x736CBE0", VA = "0x18736D9E0", Slot = "5")]
	public override void PEMNBFJKEOJ(KHJBOKAGKHP FPOONLFOOIF, IMOJHDCELFM LIDLPLGMNKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x736DA70", Offset = "0x736CC70", VA = "0x18736DA70")]
	public JGGCMGDJJHK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
[OOEGBIGOMOL(typeof(quaternion))]
internal class JGBHPIBJPCP : EFLBDEJCLKA<quaternion>
{
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	[CompilerGenerated]
	private sealed class LGPHLCCDPEP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public KHJBOKAGKHP property;

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x901140", Offset = "0x900340", VA = "0x180901140")]
		public LGPHLCCDPEP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x736F230", Offset = "0x736E430", VA = "0x18736F230")]
		internal float EAKGGGEHJML()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x736F260", Offset = "0x736E460", VA = "0x18736F260")]
		internal void IDHOJNGKEFK(float value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x736F240", Offset = "0x736E440", VA = "0x18736F240")]
		internal float EEJCMCLBNLL()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x736F250", Offset = "0x736E450", VA = "0x18736F250")]
		internal void FBFIMEIIJKF(float value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x736F640", Offset = "0x736E840", VA = "0x18736F640")]
		internal float OEOABNENEKP()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x736F650", Offset = "0x736E850", VA = "0x18736F650")]
		internal void ONIMLJLAOGD(float value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x736F270", Offset = "0x736E470", VA = "0x18736F270")]
		internal float JGEOJBNGBLG(int index)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x736F3E0", Offset = "0x736E5E0", VA = "0x18736F3E0")]
		internal void MIHPCCLFOIB(int index, float value)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x736D570", Offset = "0x736C770", VA = "0x18736D570", Slot = "5")]
	public override void PEMNBFJKEOJ(KHJBOKAGKHP FPOONLFOOIF, IMOJHDCELFM LIDLPLGMNKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x736D9A0", Offset = "0x736CBA0", VA = "0x18736D9A0")]
	public JGBHPIBJPCP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
[OOEGBIGOMOL(typeof(uint))]
internal class PHIKCKCMBMP : EFLBDEJCLKA<uint>
{
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	[CompilerGenerated]
	private sealed class GPGJENCPPBI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public KHJBOKAGKHP property;

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x901140", Offset = "0x900340", VA = "0x180901140")]
		public GPGJENCPPBI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x736C7E0", Offset = "0x736B9E0", VA = "0x18736C7E0")]
		internal int EAKGGGEHJML()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x736C820", Offset = "0x736BA20", VA = "0x18736C820")]
		internal void IDHOJNGKEFK(int value)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x7372920", Offset = "0x7371B20", VA = "0x187372920", Slot = "5")]
	public override void PEMNBFJKEOJ(KHJBOKAGKHP FPOONLFOOIF, IMOJHDCELFM LIDLPLGMNKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x7372AC0", Offset = "0x7371CC0", VA = "0x187372AC0")]
	public PHIKCKCMBMP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
internal struct KELOAIDNFMF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public int DPKPDGLMFOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public GFCAKFAODMC FPOONLFOOIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public int ENGJFBPJMAC;
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
internal static class OHGDMFOCMFH
{
	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x7370040", Offset = "0x736F240", VA = "0x187370040")]
	public static void MGGDFLEJHEN(Type IBOGDPMMIGI, Type ELGGAFMCMEC)
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200001F")]
internal struct LDJEKMNMCGN
{
	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x736EEE0", Offset = "0x736E0E0", VA = "0x18736EEE0")]
	public static NativeList<GFCAKFAODMC> BCMDDKOGFLO(NDNBDIACCIO MHDKMAGHJOG, DFNEHJMGEOJ HKEKABKNMAE)
	{
		return default(NativeList<GFCAKFAODMC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x736F140", Offset = "0x736E340", VA = "0x18736F140")]
	private static bool NOECHFFNDJM(GFCAKFAODMC FPOONLFOOIF, NDNBDIACCIO MHDKMAGHJOG)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public class JIAAOKCIIOO : KHJBOKAGKHP, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private readonly GFCAKFAODMC FPOONLFOOIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private readonly DFNEHJMGEOJ ODHHJDJAJFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private readonly NDNBDIACCIO MHDKMAGHJOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private bool HAOFCOOGPMB;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public string PCMLNMEPCBI
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x736DAB0", Offset = "0x736CCB0", VA = "0x18736DAB0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public bool MEJCLCCDGDO
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x736DEF0", Offset = "0x736D0F0", VA = "0x18736DEF0", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public JGGGIHBIMPC JFDKEFHGCOB
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x736DF80", Offset = "0x736D180", VA = "0x18736DF80", Slot = "8")]
		get
		{
			return default(JGGGIHBIMPC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public Type BLFPNJPCADF
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x736E070", Offset = "0x736D270", VA = "0x18736E070", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event Action AMAMNKCELNN
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x736DFD0", Offset = "0x736D1D0", VA = "0x18736DFD0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x736E0D0", Offset = "0x736D2D0", VA = "0x18736E0D0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x736E170", Offset = "0x736D370", VA = "0x18736E170")]
	public JIAAOKCIIOO(NDNBDIACCIO MHDKMAGHJOG, GFCAKFAODMC FPOONLFOOIF, DFNEHJMGEOJ ODHHJDJAJFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x736DB10", Offset = "0x736CD10", VA = "0x18736DB10")]
	private void BBHLKPDBDGP(AGLMBIPPLLA LFDKFEEPNFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x736DC20", Offset = "0x736CE20", VA = "0x18736DC20", Slot = "10")]
	public void BGMHNJIJIDG(LHLPPNFLPDM OMEFCJCOLII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x736DD00", Offset = "0x736CF00", VA = "0x18736DD00", Slot = "11")]
	public void CEJFMFJKFIE(JMNLNDOMIAK OMEFCJCOLII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x736DE20", Offset = "0x736D020", VA = "0x18736DE20", Slot = "12")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
[NDNLLBHNOKB(1)]
internal sealed class OJPFLADAPBN : HGJHDEGLBFA, HPPODOGBKNA, GFEACFNHNGJ
{
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[CompilerGenerated]
	private sealed class JOBMPPNPOEB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public KHJBOKAGKHP property;

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x901140", Offset = "0x900340", VA = "0x180901140")]
		public JOBMPPNPOEB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x736E270", Offset = "0x736D470", VA = "0x18736E270")]
		internal bool EAKGGGEHJML()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x736E420", Offset = "0x736D620", VA = "0x18736E420")]
		internal string IDHOJNGKEFK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x736E2C0", Offset = "0x736D4C0", VA = "0x18736E2C0")]
		internal void EEJCMCLBNLL(string value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x736E350", Offset = "0x736D550", VA = "0x18736E350")]
		internal string FBFIMEIIJKF()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public GFCAKFAODMC OMPKIFGNKJD
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x7370110", Offset = "0x736F310", VA = "0x187370110", Slot = "4")]
		get
		{
			return default(GFCAKFAODMC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x7370180", Offset = "0x736F380", VA = "0x187370180", Slot = "5")]
	public void PEMNBFJKEOJ(KHJBOKAGKHP FPOONLFOOIF, IMOJHDCELFM LIDLPLGMNKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x901140", Offset = "0x900340", VA = "0x180901140")]
	public OJPFLADAPBN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
internal class HPNIBEEKJIK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private readonly DFNEHJMGEOJ HKEKABKNMAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	private readonly IMOJHDCELFM LIDLPLGMNKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	private readonly Action<KELOAIDNFMF> PBKHIPIPBDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private readonly HashSet<NKDGKKIBGPK> EMOPLKEJNFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private readonly Dictionary<NKDGKKIBGPK, List<KELOAIDNFMF>> LIHFPAFBCIN;

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x736D2F0", Offset = "0x736C4F0", VA = "0x18736D2F0")]
	public HPNIBEEKJIK(DFNEHJMGEOJ HKEKABKNMAE, IMOJHDCELFM LIDLPLGMNKB, Action<KELOAIDNFMF> PBKHIPIPBDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x736C910", Offset = "0x736BB10", VA = "0x18736C910")]
	public void AGFDDEOKFPG(NativeList<KELOAIDNFMF> NDKHFDBAGPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x736CCE0", Offset = "0x736BEE0", VA = "0x18736CCE0")]
	private void DFLEIGCOAHH(NKDGKKIBGPK GEDEGGCFAKO, KELOAIDNFMF AFJMEJNMLGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x736CC80", Offset = "0x736BE80", VA = "0x18736CC80")]
	public void BJOKHPNFJBP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x736CE80", Offset = "0x736C080", VA = "0x18736CE80")]
	private void EMNOBBALKLK(NKDGKKIBGPK GEDEGGCFAKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x736C870", Offset = "0x736BA70", VA = "0x18736C870")]
	private void AFNIGACEPNC(NKDGKKIBGPK GEDEGGCFAKO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
internal class NAFLKBBPMCA : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	[CompilerGenerated]
	private sealed class LINMEBINIFN : IEnumerable<GFCAKFAODMC>, IEnumerable, IEnumerator<GFCAKFAODMC>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private GFCAKFAODMC <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		public NAFLKBBPMCA <>4__this;

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
		private GFCAKFAODMC System.Collections.Generic.IEnumerator<RecRoom.DataLayer.NetworkProperty>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0xA3D4D0", Offset = "0xA3C6D0", VA = "0x180A3D4D0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default(GFCAKFAODMC);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600008A")]
			[Cpp2IlInjected.Address(RVA = "0x736FA20", Offset = "0x736EC20", VA = "0x18736FA20", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x10AA4B0", Offset = "0x10A96B0", VA = "0x1810AA4B0")]
		[DebuggerHidden]
		public LINMEBINIFN(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x736FA70", Offset = "0x736EC70", VA = "0x18736FA70", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x736F6B0", Offset = "0x736E8B0", VA = "0x18736F6B0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x736F660", Offset = "0x736E860", VA = "0x18736F660")]
		private void MHLANDJELDL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x736F9D0", Offset = "0x736EBD0", VA = "0x18736F9D0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x736F910", Offset = "0x736EB10", VA = "0x18736F910", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<GFCAKFAODMC> System.Collections.Generic.IEnumerable<RecRoom.DataLayer.NetworkProperty>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x736F910", Offset = "0x736EB10", VA = "0x18736F910", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private static readonly KJMCEDJMPPA MOKKIOIDAGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private NativeParallelMultiHashMap<long, int> DINBEBIEOCF;

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x736FE40", Offset = "0x736F040", VA = "0x18736FE40")]
	public NAFLKBBPMCA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x736FD10", Offset = "0x736EF10", VA = "0x18736FD10")]
	[IteratorStateMachine(typeof(LINMEBINIFN))]
	public IEnumerable<GFCAKFAODMC> JJPEEPAJMHB(Type MDOOANEGCAH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x736FC10", Offset = "0x736EE10", VA = "0x18736FC10", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x736FC90", Offset = "0x736EE90", VA = "0x18736FC90")]
	private long IIFDHOMEMAO(GFCAKFAODMC FPOONLFOOIF)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x736FC50", Offset = "0x736EE50", VA = "0x18736FC50")]
	private long IIFDHOMEMAO(Type MDOOANEGCAH)
	{
		return default(long);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
internal struct EICOLEFMMNL : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private NativeBitArray BDMMNPFHKNA;

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x736BF10", Offset = "0x736B110", VA = "0x18736BF10")]
	public EICOLEFMMNL(int EOKNBJLIKEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x736BCD0", Offset = "0x736AED0", VA = "0x18736BCD0")]
	public static EICOLEFMMNL FKGELDJLELB(int EKPEFEBPGMB, NativeArray<GFCAKFAODMC> LJAGDLAELPK)
	{
		return default(EICOLEFMMNL);
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x736BF00", Offset = "0x736B100", VA = "0x18736BF00")]
	public bool MCKGELOKMLN(int CPLNODNGKGB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x736BCB0", Offset = "0x736AEB0", VA = "0x18736BCB0")]
	public void CEJFMFJKFIE(int CPLNODNGKGB, bool OMEFCJCOLII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x736BE50", Offset = "0x736B050", VA = "0x18736BE50")]
	public bool IEEDPJIFCHL(GFCAKFAODMC[] LJAGDLAELPK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x736BC00", Offset = "0x736AE00", VA = "0x18736BC00")]
	public bool BOAMBHOGAKN(GFCAKFAODMC[] LJAGDLAELPK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x736BCC0", Offset = "0x736AEC0", VA = "0x18736BCC0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
internal class PDCAHPFHDMG
{
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private static readonly KJMCEDJMPPA MOKKIOIDAGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private readonly DFNEHJMGEOJ HKEKABKNMAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private readonly List<GFEACFNHNGJ> BBBGECHNOOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private readonly NAFLKBBPMCA DINBEBIEOCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private NativeParallelMultiHashMap<int, int> NFJGGNMINMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private NativeList<int> JCOEDNMNCFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private bool HAOFCOOGPMB;

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public List<GFEACFNHNGJ> DGLPMINJEHN
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x8F2BF0", Offset = "0x8F1DF0", VA = "0x1808F2BF0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x7371700", Offset = "0x7370900", VA = "0x187371700")]
	public PDCAHPFHDMG(DFNEHJMGEOJ HKEKABKNMAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x7370E20", Offset = "0x7370020", VA = "0x187370E20")]
	public void MFBFDNDBONL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x7370960", Offset = "0x736FB60", VA = "0x187370960")]
	public void HILKPDJAIPC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x7371180", Offset = "0x7370380", VA = "0x187371180")]
	public NativeList<KELOAIDNFMF> PBHPNKDENDF(NativeArray<GFCAKFAODMC> LJAGDLAELPK)
	{
		return default(NativeList<KELOAIDNFMF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x7370890", Offset = "0x736FA90", VA = "0x187370890")]
	private bool GCJAAFLDFLN(GFEACFNHNGJ KJHHIMEBFIB, EICOLEFMMNL MMAOOHEGFFA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x3462D00", Offset = "0x3461F00", VA = "0x183462D00")]
	private void FIGBFGMBMDO<TInterface, TAttribute>(Action<TInterface, TAttribute> GAAPFLHHLEM) where TInterface : GFEACFNHNGJ where TAttribute : Attribute
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x73706F0", Offset = "0x736F8F0", VA = "0x1873706F0")]
	private void CPCGCJKGLHE(Type MDOOANEGCAH, Type ICBGEDJFENI, Type CCPDCKADPME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x3462F60", Offset = "0x3462160", VA = "0x183462F60")]
	private TInterface OEEHOPIPEKL<TInterface>(Type MDOOANEGCAH)
	{
		return (TInterface)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x73707F0", Offset = "0x736F9F0", VA = "0x1873707F0")]
	private int FHCAGNFNJCD(GFEACFNHNGJ OMLEEHAPDFA, int ENGJFBPJMAC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x7370F00", Offset = "0x7370100", VA = "0x187370F00")]
	private void MKLCEIGJHBA(HPPODOGBKNA KJHHIMEBFIB, OOEGBIGOMOL FBENDGJPBBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x7370B20", Offset = "0x736FD20", VA = "0x187370B20")]
	private void HOHADJLOFPF(BIFNMGNAGJP KJHHIMEBFIB, BIIDJKJFFLA FBENDGJPBBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x73705E0", Offset = "0x736F7E0", VA = "0x1873705E0")]
	private void BHLMEKFAJEM(FAAMODDINCI KJHHIMEBFIB, FIDBNOHMKFK FBENDGJPBBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x7370720", Offset = "0x736F920", VA = "0x187370720")]
	private void DLCIDDJFANB(HGJHDEGLBFA KJHHIMEBFIB, NDNLLBHNOKB FBENDGJPBBA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
internal struct KLMHCIOIIKA : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private readonly List<GFEACFNHNGJ> BBBGECHNOOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private NativeList<KELOAIDNFMF> HIINBAKPMFL;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public NativeList<KELOAIDNFMF> IOBFALCHAKD
	{
		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x2B3B690", Offset = "0x2B3A890", VA = "0x182B3B690")]
		get
		{
			return default(NativeList<KELOAIDNFMF>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x736EDB0", Offset = "0x736DFB0", VA = "0x18736EDB0")]
	public KLMHCIOIIKA(List<GFEACFNHNGJ> BBBGECHNOOH, NativeArray<KELOAIDNFMF> NDKHFDBAGPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x736E810", Offset = "0x736DA10", VA = "0x18736E810", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x736E990", Offset = "0x736DB90", VA = "0x18736E990")]
	private NativeList<KELOAIDNFMF> OMPOEKBBHHH(NativeArray<KELOAIDNFMF> KJFFBJNJOGE)
	{
		return default(NativeList<KELOAIDNFMF>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x736ECC0", Offset = "0x736DEC0", VA = "0x18736ECC0")]
	private bool ONNFOPGIBHH(GFEACFNHNGJ KJHHIMEBFIB, EICOLEFMMNL HPHCDDHKGKF, GFCAKFAODMC FPOONLFOOIF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x736E850", Offset = "0x736DA50", VA = "0x18736E850")]
	private void KOIDEFBCNFH(GFEACFNHNGJ KJHHIMEBFIB, EICOLEFMMNL BDMMNPFHKNA, GFCAKFAODMC GKDBBNEBFPM)
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000029")]
internal struct BFJGFEHLEND : IComparer<KELOAIDNFMF>
{
	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x736B390", Offset = "0x736A590", VA = "0x18736B390", Slot = "4")]
	public int Compare(KELOAIDNFMF KKLLOEEDINO, KELOAIDNFMF NHCGDJCFKIC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x736B3A0", Offset = "0x736A5A0", VA = "0x18736B3A0")]
	public static void MGAEMPABJFP(NativeList<KELOAIDNFMF> NDKHFDBAGPD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
[AttributeUsage(AttributeTargets.Class)]
public class NDNLLBHNOKB : GNBGIIJHINL
{
	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x7370030", Offset = "0x736F230", VA = "0x187370030")]
	public NDNLLBHNOKB(int JIAAJMHFFBM = 1)
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
