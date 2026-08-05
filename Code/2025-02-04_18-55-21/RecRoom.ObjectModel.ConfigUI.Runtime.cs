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
	public class LogRegistrationIndex : CGFLIBNDCKI
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x73CF750", Offset = "0x73CE550", VA = "0x1873CF750", Slot = "4")]
		public override void EHDMJEMLBPD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x9201C0", Offset = "0x91EFC0", VA = "0x1809201C0")]
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
			[Cpp2IlInjected.Address(RVA = "0x8F41F0", Offset = "0x8F2FF0", VA = "0x1808F41F0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x1E0BA10", Offset = "0x1E0A810", VA = "0x181E0BA10", Slot = "5")]
		public override void SetServiceCategoryIndices(List<int> globalFromLocalIndices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x73D1C10", Offset = "0x73D0A10", VA = "0x1873D1C10")]
		private void OGIEEDDHGBJ(IServiceRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x73D1E50", Offset = "0x73D0C50", VA = "0x1873D1E50", Slot = "6")]
		public override void RegisterServices(IServiceRegistration registry, [In] ServiceBitsetFilter filter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x73D1EB0", Offset = "0x73D0CB0", VA = "0x1873D1EB0", Slot = "7")]
		public override void RegisterTypes(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x73D25D0", Offset = "0x73D13D0", VA = "0x1873D25D0")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
internal abstract class CAABCCGKNGD : EPCBPPBOHCC<Enum>, PHFGODBDNAE, DHLAJIFPLLJ, EALPDHOFMOP
{
	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "7")]
	public abstract bool NINDHCFHMEA(Type OBDHBADPJNM);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x73CA3D0", Offset = "0x73C91D0", VA = "0x1873CA3D0")]
	protected CAABCCGKNGD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
internal abstract class EPCBPPBOHCC<T> : DHLAJIFPLLJ, EALPDHOFMOP where T : Enum
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[CompilerGenerated]
	private sealed class CPMANLKKGIN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		public GHEMHAICIDG property;

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x8FE490", Offset = "0x8FD290", VA = "0x1808FE490")]
		public CPMANLKKGIN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x5A57740", Offset = "0x5A56540", VA = "0x185A57740")]
		internal bool CGOOEPHDCPL()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x4007CA0", Offset = "0x4006AA0", VA = "0x184007CA0")]
	protected EPCBPPBOHCC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x4007790", Offset = "0x4006590", VA = "0x184007790")]
	protected void CEGCMJPMLCB(MEKLECHPCAF MKAIGHNBGKO, GHEMHAICIDG AMBDMECJFHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x40079B0", Offset = "0x40067B0", VA = "0x1840079B0")]
	protected void LOIIPIFCMKI(HPEBCCPGICK<T> MKAIGHNBGKO, GHEMHAICIDG AMBDMECJFHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "5")]
	public abstract void CPMJAAPLLJK(GHEMHAICIDG AMBDMECJFHI, JHPEMIFICDJ GFJFPCIBNHH);
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
internal abstract class EKEJHHMMLKL : LNCMNFNJDOM, EALPDHOFMOP
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public abstract KEJCGFMDGGO[] COHKFAJAMKO
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public abstract KEJCGFMDGGO[] KPONBMINJCA
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "9")]
	public abstract void CPMJAAPLLJK(GHEMHAICIDG AMBDMECJFHI, DDMJKEEAMPJ MIIGAJHHIOG, BCBGGKGOEJO LGAECFLJFJL, JHPEMIFICDJ GFJFPCIBNHH);

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x316C750", Offset = "0x316B550", VA = "0x18316C750")]
	protected static T ELHNBPFMIAL<T>(FEBOOADAFMA FBJOMFELGNP, NCDLGKIFGAI<T> AMBDMECJFHI) where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x316C7A0", Offset = "0x316B5A0", VA = "0x18316C7A0")]
	protected static void OKDEHMKEDGA<T>(FEBOOADAFMA FBJOMFELGNP, NCDLGKIFGAI<T> AMBDMECJFHI, T IPHILEOFJLB) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x8FE490", Offset = "0x8FD290", VA = "0x1808FE490")]
	protected EKEJHHMMLKL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
internal abstract class BDBEKFGBLPJ<T> : DHLAJIFPLLJ, EALPDHOFMOP where T : struct
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CompilerGenerated]
	private sealed class EFHDBPGHHCG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		public GHEMHAICIDG property;

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x8FE490", Offset = "0x8FD290", VA = "0x1808FE490")]
		public EFHDBPGHHCG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x3FDC4B0", Offset = "0x3FDB2B0", VA = "0x183FDC4B0")]
		internal bool CGOOEPHDCPL()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x5615560", Offset = "0x5614360", VA = "0x185615560")]
	protected BDBEKFGBLPJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x56148B0", Offset = "0x56136B0", VA = "0x1856148B0")]
	protected void CEGCMJPMLCB(MEKLECHPCAF MKAIGHNBGKO, GHEMHAICIDG AMBDMECJFHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x5614F10", Offset = "0x5613D10", VA = "0x185614F10")]
	protected void LOIIPIFCMKI(HPEBCCPGICK<T> MKAIGHNBGKO, GHEMHAICIDG AMBDMECJFHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(Slot = "5")]
	public abstract void CPMJAAPLLJK(GHEMHAICIDG AMBDMECJFHI, JHPEMIFICDJ GFJFPCIBNHH);
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
[RegisterService(typeof(DDMJKEEAMPJ), new string[] { })]
internal class IONLMOEPJPE : DDMJKEEAMPJ, NAIFEMPPMKG, EJBGNPMNAED, JGMFHEFMNDL, HFKIOGDGJAO
{
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private static readonly IMOCAMGHNDM JBCGOBEIKAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	[DependsOn]
	private BCBGGKGOEJO LGAECFLJFJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	[DependsOn]
	private JHPEMIFICDJ ILPNNJMMDLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private MBILHMNKKOL EBJHMLNNGMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private FEBOOADAFMA FBJOMFELGNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private List<GHEMHAICIDG> ECNPNNACFIG;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public FEBOOADAFMA IJJMEOFFNNB
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x11F44E0", Offset = "0x11F32E0", VA = "0x1811F44E0", Slot = "5")]
		get
		{
			return default(FEBOOADAFMA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x73CC780", Offset = "0x73CB580", VA = "0x1873CC780", Slot = "6")]
	public void FELIODKOHEH(BFHPBCPPECP AGGPMDGGKLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x73CD0C0", Offset = "0x73CBEC0", VA = "0x1873CD0C0", Slot = "7")]
	public void OAKNFNBDPDH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x73CCB90", Offset = "0x73CB990", VA = "0x1873CCB90", Slot = "4")]
	public void MDCCAKELCOF(FEBOOADAFMA NCLLDJENAMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x73CCAD0", Offset = "0x73CB8D0", VA = "0x1873CCAD0")]
	private void FNFCNLEEOAN(FEBOOADAFMA NCLLDJENAMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x73CD1C0", Offset = "0x73CBFC0", VA = "0x1873CD1C0")]
	private void PDJABDLNILF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x73CC480", Offset = "0x73CB280", VA = "0x1873CC480")]
	private void CPMJAAPLLJK(OIGAECJMGAB NEKGJJDNENB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x73CC410", Offset = "0x73CB210", VA = "0x1873CC410", Slot = "8")]
	private void BKNPNHIBBHM(BFHPBCPPECP AGGPMDGGKLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x73CCB50", Offset = "0x73CB950", VA = "0x1873CCB50", Slot = "9")]
	private void JAPPIEFINBH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x73CD440", Offset = "0x73CC240", VA = "0x1873CD440")]
	public IONLMOEPJPE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
[DEOKBDNPPCG(0)]
internal class NHCJGJEPNKJ : CAABCCGKNGD
{
	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x73D0BF0", Offset = "0x73CF9F0", VA = "0x1873D0BF0", Slot = "5")]
	public override void CPMJAAPLLJK(GHEMHAICIDG AMBDMECJFHI, JHPEMIFICDJ GFJFPCIBNHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x73D0CA0", Offset = "0x73CFAA0", VA = "0x1873D0CA0", Slot = "7")]
	public override bool NINDHCFHMEA(Type OBDHBADPJNM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x73CA3D0", Offset = "0x73C91D0", VA = "0x1873CA3D0")]
	public NHCJGJEPNKJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
[DEOKBDNPPCG(0)]
internal class FCHGCLBHJPJ : CAABCCGKNGD
{
	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x73CAAC0", Offset = "0x73C98C0", VA = "0x1873CAAC0", Slot = "5")]
	public override void CPMJAAPLLJK(GHEMHAICIDG AMBDMECJFHI, JHPEMIFICDJ GFJFPCIBNHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x73CAB70", Offset = "0x73C9970", VA = "0x1873CAB70", Slot = "7")]
	public override bool NINDHCFHMEA(Type OBDHBADPJNM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x73CA3D0", Offset = "0x73C91D0", VA = "0x1873CA3D0")]
	public FCHGCLBHJPJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
[ONKOBDFKOJF(typeof(BHMDPIOBIIO), 1)]
internal class HNOJLHJJGDD : EPCBPPBOHCC<BHMDPIOBIIO>
{
	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x73CBE10", Offset = "0x73CAC10", VA = "0x1873CBE10", Slot = "5")]
	public override void CPMJAAPLLJK(GHEMHAICIDG AMBDMECJFHI, JHPEMIFICDJ GFJFPCIBNHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x73CBF60", Offset = "0x73CAD60", VA = "0x1873CBF60")]
	public HNOJLHJJGDD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
[JJNDMFPDIEC(2)]
internal class ODJLHAILLKE : EKEJHHMMLKL
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[CompilerGenerated]
	private sealed class GPCLCAFMFCG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public DDMJKEEAMPJ configUIService;

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x8FE490", Offset = "0x8FD290", VA = "0x1808FE490")]
		public GPCLCAFMFCG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x73CB190", Offset = "0x73C9F90", VA = "0x1873CB190")]
		internal (int, int) DIDDAPFPAGA()
		{
			return default((int, int));
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x73CB040", Offset = "0x73C9E40", VA = "0x1873CB040")]
		internal void CPDHJDDAMCJ((int color, int material) value)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public override KEJCGFMDGGO[] COHKFAJAMKO
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x8F4460", Offset = "0x8F3260", VA = "0x1808F4460", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public override KEJCGFMDGGO[] KPONBMINJCA
	{
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x8F4430", Offset = "0x8F3230", VA = "0x1808F4430", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x73D0D40", Offset = "0x73CFB40", VA = "0x1873D0D40", Slot = "9")]
	public override void CPMJAAPLLJK(GHEMHAICIDG AMBDMECJFHI, DDMJKEEAMPJ MIIGAJHHIOG, BCBGGKGOEJO LGAECFLJFJL, JHPEMIFICDJ GFJFPCIBNHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x73D10F0", Offset = "0x73CFEF0", VA = "0x1873D10F0")]
	public ODJLHAILLKE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
[ONKOBDFKOJF(typeof(bool))]
internal class JMHCMHJPCNP : BDBEKFGBLPJ<bool>
{
	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x73CDE70", Offset = "0x73CCC70", VA = "0x1873CDE70", Slot = "5")]
	public override void CPMJAAPLLJK(GHEMHAICIDG AMBDMECJFHI, JHPEMIFICDJ GFJFPCIBNHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x73CDF00", Offset = "0x73CCD00", VA = "0x1873CDF00")]
	public JMHCMHJPCNP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
[ONKOBDFKOJF(typeof(FixedString32Bytes))]
internal class AOAOIGCKCLC : BDBEKFGBLPJ<FixedString32Bytes>
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[CompilerGenerated]
	private sealed class ONOJNFMAGOB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public GHEMHAICIDG property;

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x8FE490", Offset = "0x8FD290", VA = "0x1808FE490")]
		public ONOJNFMAGOB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x73D1600", Offset = "0x73D0400", VA = "0x1873D1600")]
		internal string DIDDAPFPAGA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x73D1590", Offset = "0x73D0390", VA = "0x1873D1590")]
		internal void CPDHJDDAMCJ(string value)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x73C9F20", Offset = "0x73C8D20", VA = "0x1873C9F20", Slot = "5")]
	public override void CPMJAAPLLJK(GHEMHAICIDG AMBDMECJFHI, JHPEMIFICDJ GFJFPCIBNHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x73CA0C0", Offset = "0x73C8EC0", VA = "0x1873CA0C0")]
	public AOAOIGCKCLC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
[ONKOBDFKOJF(typeof(FixedString64Bytes))]
internal class GPPJGGMGOBA : BDBEKFGBLPJ<FixedString64Bytes>
{
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	[CompilerGenerated]
	private sealed class MAKALEOOCKO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public GHEMHAICIDG property;

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x8FE490", Offset = "0x8FD290", VA = "0x1808FE490")]
		public MAKALEOOCKO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x73CF8F0", Offset = "0x73CE6F0", VA = "0x1873CF8F0")]
		internal string DIDDAPFPAGA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x73CF860", Offset = "0x73CE660", VA = "0x1873CF860")]
		internal void CPDHJDDAMCJ(string value)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x73CB400", Offset = "0x73CA200", VA = "0x1873CB400", Slot = "5")]
	public override void CPMJAAPLLJK(GHEMHAICIDG AMBDMECJFHI, JHPEMIFICDJ GFJFPCIBNHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x73CB5A0", Offset = "0x73CA3A0", VA = "0x1873CB5A0")]
	public GPPJGGMGOBA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
[ONKOBDFKOJF(typeof(float3))]
internal class IFHIPELCGGI : BDBEKFGBLPJ<float3>
{
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[CompilerGenerated]
	private sealed class BDPENCFBLOI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public GHEMHAICIDG property;

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x8FE490", Offset = "0x8FD290", VA = "0x1808FE490")]
		public BDPENCFBLOI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x73CA110", Offset = "0x73C8F10", VA = "0x1873CA110")]
		internal float DIDDAPFPAGA()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x73CA100", Offset = "0x73C8F00", VA = "0x1873CA100")]
		internal void CPDHJDDAMCJ(float value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x73CA1F0", Offset = "0x73C8FF0", VA = "0x1873CA1F0")]
		internal float FNGDMJHBHKI()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x73CA260", Offset = "0x73C9060", VA = "0x1873CA260")]
		internal void FPNHHDBHLEJ(float value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x73CA180", Offset = "0x73C8F80", VA = "0x1873CA180")]
		internal float FGDOMDCCLJK()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x73CA350", Offset = "0x73C9150", VA = "0x1873CA350")]
		internal void JNJODOBECCF(float value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x73CA360", Offset = "0x73C9160", VA = "0x1873CA360")]
		internal float MKDBGCIDAOG(int index)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x73CA270", Offset = "0x73C9070", VA = "0x1873CA270")]
		internal void HLALHBCKECK(int index, float value)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x73CBFA0", Offset = "0x73CADA0", VA = "0x1873CBFA0", Slot = "5")]
	public override void CPMJAAPLLJK(GHEMHAICIDG AMBDMECJFHI, JHPEMIFICDJ GFJFPCIBNHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x73CC3D0", Offset = "0x73CB1D0", VA = "0x1873CC3D0")]
	public IFHIPELCGGI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
[ONKOBDFKOJF(typeof(float))]
internal class JKHNHFFMFMG : BDBEKFGBLPJ<float>
{
	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x73CDDA0", Offset = "0x73CCBA0", VA = "0x1873CDDA0", Slot = "5")]
	public override void CPMJAAPLLJK(GHEMHAICIDG AMBDMECJFHI, JHPEMIFICDJ GFJFPCIBNHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x73CDE30", Offset = "0x73CCC30", VA = "0x1873CDE30")]
	public JKHNHFFMFMG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
[ONKOBDFKOJF(typeof(int))]
internal class FPNCLIMBOEG : BDBEKFGBLPJ<int>
{
	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x73CAF70", Offset = "0x73C9D70", VA = "0x1873CAF70", Slot = "5")]
	public override void CPMJAAPLLJK(GHEMHAICIDG AMBDMECJFHI, JHPEMIFICDJ GFJFPCIBNHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x73CB000", Offset = "0x73C9E00", VA = "0x1873CB000")]
	public FPNCLIMBOEG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
[ONKOBDFKOJF(typeof(quaternion))]
internal class CBFEDJCBNNE : BDBEKFGBLPJ<quaternion>
{
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	[CompilerGenerated]
	private sealed class JGHMEPHGCNH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public GHEMHAICIDG property;

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x8FE490", Offset = "0x8FD290", VA = "0x1808FE490")]
		public JGHMEPHGCNH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x73CD980", Offset = "0x73CC780", VA = "0x1873CD980")]
		internal float DIDDAPFPAGA()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x73CD970", Offset = "0x73CC770", VA = "0x1873CD970")]
		internal void CPDHJDDAMCJ(float value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x73CDC00", Offset = "0x73CCA00", VA = "0x1873CDC00")]
		internal float FNGDMJHBHKI()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x73CDC10", Offset = "0x73CCA10", VA = "0x1873CDC10")]
		internal void FPNHHDBHLEJ(float value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x73CDBF0", Offset = "0x73CC9F0", VA = "0x1873CDBF0")]
		internal float FGDOMDCCLJK()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x73CDC20", Offset = "0x73CCA20", VA = "0x1873CDC20")]
		internal void JNJODOBECCF(float value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x73CDC30", Offset = "0x73CCA30", VA = "0x1873CDC30")]
		internal float KBDHNBLCKFJ(int index)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x73CD990", Offset = "0x73CC790", VA = "0x1873CD990")]
		internal void ELIFAOANJEO(int index, float value)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x73CA410", Offset = "0x73C9210", VA = "0x1873CA410", Slot = "5")]
	public override void CPMJAAPLLJK(GHEMHAICIDG AMBDMECJFHI, JHPEMIFICDJ GFJFPCIBNHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x73CA840", Offset = "0x73C9640", VA = "0x1873CA840")]
	public CBFEDJCBNNE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
[ONKOBDFKOJF(typeof(uint))]
internal class DMGLENLNOKA : BDBEKFGBLPJ<uint>
{
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	[CompilerGenerated]
	private sealed class LCDKJIMPFPG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public GHEMHAICIDG property;

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x8FE490", Offset = "0x8FD290", VA = "0x1808FE490")]
		public LCDKJIMPFPG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x73CEB70", Offset = "0x73CD970", VA = "0x1873CEB70")]
		internal int DIDDAPFPAGA()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x73CEB20", Offset = "0x73CD920", VA = "0x1873CEB20")]
		internal void CPDHJDDAMCJ(int value)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x73CA8E0", Offset = "0x73C96E0", VA = "0x1873CA8E0", Slot = "5")]
	public override void CPMJAAPLLJK(GHEMHAICIDG AMBDMECJFHI, JHPEMIFICDJ GFJFPCIBNHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x73CAA80", Offset = "0x73C9880", VA = "0x1873CAA80")]
	public DMGLENLNOKA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
internal struct OIGAECJMGAB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public int HMNCBMBEMPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public KEJCGFMDGGO AMBDMECJFHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public int JHPBGABBKOP;
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
internal static class PJIHHMDEIFA
{
	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x73D1B40", Offset = "0x73D0940", VA = "0x1873D1B40")]
	public static void DCDOKGOLIHJ(Type MNLIEBCFNGN, Type MCOAJIKJELA)
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200001F")]
internal struct FOIMICHHPBD
{
	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x73CAD10", Offset = "0x73C9B10", VA = "0x1873CAD10")]
	public static NativeList<KEJCGFMDGGO> MODNMONELHD(FEBOOADAFMA FBJOMFELGNP, BCBGGKGOEJO LGAECFLJFJL)
	{
		return default(NativeList<KEJCGFMDGGO>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x73CAC20", Offset = "0x73C9A20", VA = "0x1873CAC20")]
	private static bool KOMMDEHMJBO(KEJCGFMDGGO AMBDMECJFHI, FEBOOADAFMA FBJOMFELGNP)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public class KEEBIKAPPHB : GHEMHAICIDG, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private readonly KEJCGFMDGGO AMBDMECJFHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private readonly BCBGGKGOEJO JNOEDKOEBAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private readonly FEBOOADAFMA FBJOMFELGNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private bool BBDDFKFCEGM;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public string HIGBIGGFHEK
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x73CE5A0", Offset = "0x73CD3A0", VA = "0x1873CE5A0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public bool IJHDOOBJGHE
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x73CE130", Offset = "0x73CCF30", VA = "0x1873CE130", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public JNCOEOPKELP OHMNDEFFAHP
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x73CE450", Offset = "0x73CD250", VA = "0x1873CE450", Slot = "8")]
		get
		{
			return default(JNCOEOPKELP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public Type LPNEJLDPBGO
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x73CE4A0", Offset = "0x73CD2A0", VA = "0x1873CE4A0", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event Action ABCAMAMPLPE
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x73CE3B0", Offset = "0x73CD1B0", VA = "0x1873CE3B0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x73CE500", Offset = "0x73CD300", VA = "0x1873CE500", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x73CE600", Offset = "0x73CD400", VA = "0x1873CE600")]
	public KEEBIKAPPHB(FEBOOADAFMA FBJOMFELGNP, KEJCGFMDGGO AMBDMECJFHI, BCBGGKGOEJO JNOEDKOEBAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x73CDF40", Offset = "0x73CCD40", VA = "0x1873CDF40")]
	private void AKOHPKHOFMN(BCNNNCBAKCN JOAPLPPIFPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x73CE050", Offset = "0x73CCE50", VA = "0x1873CE050", Slot = "10")]
	public void ANFJBBFMPMK(ALJDIGJCPKP IPHILEOFJLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x73CE1C0", Offset = "0x73CCFC0", VA = "0x1873CE1C0", Slot = "11")]
	public void DJKOKNNCNMK(DIKFDJPCMMB IPHILEOFJLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x73CE2E0", Offset = "0x73CD0E0", VA = "0x1873CE2E0", Slot = "12")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
[PDJNEOBDGPJ(1)]
internal sealed class PGCFANICNGN : BLGNMLIHFAJ, DHLAJIFPLLJ, EALPDHOFMOP
{
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[CompilerGenerated]
	private sealed class HKGKBDOKGCL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public GHEMHAICIDG property;

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x8FE490", Offset = "0x8FD290", VA = "0x1808FE490")]
		public HKGKBDOKGCL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x73CB660", Offset = "0x73CA460", VA = "0x1873CB660")]
		internal bool DIDDAPFPAGA()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x73CB5E0", Offset = "0x73CA3E0", VA = "0x1873CB5E0")]
		internal string CPDHJDDAMCJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x73CB6B0", Offset = "0x73CA4B0", VA = "0x1873CB6B0")]
		internal void FNGDMJHBHKI(string value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x73CB740", Offset = "0x73CA540", VA = "0x1873CB740")]
		internal string FPNHHDBHLEJ()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public KEJCGFMDGGO FKJEHBJEJAM
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x73D1AD0", Offset = "0x73D08D0", VA = "0x1873D1AD0", Slot = "4")]
		get
		{
			return default(KEJCGFMDGGO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x73D1670", Offset = "0x73D0470", VA = "0x1873D1670", Slot = "5")]
	public void CPMJAAPLLJK(GHEMHAICIDG AMBDMECJFHI, JHPEMIFICDJ GFJFPCIBNHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x8FE490", Offset = "0x8FD290", VA = "0x1808FE490")]
	public PGCFANICNGN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
internal class LDCNJJDKJCI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private readonly BCBGGKGOEJO LGAECFLJFJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	private readonly JHPEMIFICDJ GFJFPCIBNHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	private readonly Action<OIGAECJMGAB> LNLHGGIBEFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private readonly HashSet<ECFHFAKIMGD> MAHFOMMNNLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private readonly Dictionary<ECFHFAKIMGD, List<OIGAECJMGAB>> GJLNDPPJEKH;

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x73CF630", Offset = "0x73CE430", VA = "0x1873CF630")]
	public LDCNJJDKJCI(BCBGGKGOEJO LGAECFLJFJL, JHPEMIFICDJ GFJFPCIBNHH, Action<OIGAECJMGAB> LNLHGGIBEFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x73CF0C0", Offset = "0x73CDEC0", VA = "0x1873CF0C0")]
	public void KHIMALEOEBP(NativeList<OIGAECJMGAB> DPPMFEPEKJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x73CF430", Offset = "0x73CE230", VA = "0x1873CF430")]
	private void LNNEEHDLPKN(ECFHFAKIMGD DGBJJAAHDHC, OIGAECJMGAB NEKGJJDNENB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x73CF5D0", Offset = "0x73CE3D0", VA = "0x1873CF5D0")]
	public void ODJEFKGCDBC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x73CEC50", Offset = "0x73CDA50", VA = "0x1873CEC50")]
	private void HHDAHIOENCO(ECFHFAKIMGD DGBJJAAHDHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x73CEBB0", Offset = "0x73CD9B0", VA = "0x1873CEBB0")]
	private void DGJBKIHJAIA(ECFHFAKIMGD DGBJJAAHDHC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
internal class KGOPFOLFKOD : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	[CompilerGenerated]
	private sealed class JEBICODLMKL : IEnumerable<KEJCGFMDGGO>, IEnumerable, IEnumerator<KEJCGFMDGGO>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private KEJCGFMDGGO <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		public KGOPFOLFKOD <>4__this;

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
		private KEJCGFMDGGO System.Collections.Generic.IEnumerator<RecRoom.DataLayer.NetworkProperty>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0xA5E990", Offset = "0xA5D790", VA = "0x180A5E990", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default(KEJCGFMDGGO);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600008A")]
			[Cpp2IlInjected.Address(RVA = "0x73CD890", Offset = "0x73CC690", VA = "0x1873CD890", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x10CA150", Offset = "0x10C8F50", VA = "0x1810CA150")]
		[DebuggerHidden]
		public JEBICODLMKL(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x73CD8E0", Offset = "0x73CC6E0", VA = "0x1873CD8E0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x73CD520", Offset = "0x73CC320", VA = "0x1873CD520", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x73CD4D0", Offset = "0x73CC2D0", VA = "0x1873CD4D0")]
		private void GEDOPIMJGAM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x73CD840", Offset = "0x73CC640", VA = "0x1873CD840", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x73CD780", Offset = "0x73CC580", VA = "0x1873CD780", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<KEJCGFMDGGO> System.Collections.Generic.IEnumerable<RecRoom.DataLayer.NetworkProperty>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x73CD780", Offset = "0x73CC580", VA = "0x1873CD780", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private static readonly IMOCAMGHNDM JBCGOBEIKAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private NativeParallelMultiHashMap<long, int> IGILDDNIHPO;

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x73CE930", Offset = "0x73CD730", VA = "0x1873CE930")]
	public KGOPFOLFKOD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x73CE740", Offset = "0x73CD540", VA = "0x1873CE740")]
	[IteratorStateMachine(typeof(JEBICODLMKL))]
	public IEnumerable<KEJCGFMDGGO> JAJKHNKHMFB(Type OBDHBADPJNM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x73CE700", Offset = "0x73CD500", VA = "0x1873CE700", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x73CE7E0", Offset = "0x73CD5E0", VA = "0x1873CE7E0")]
	private long LBENCEDEOAP(KEJCGFMDGGO AMBDMECJFHI)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x73CE860", Offset = "0x73CD660", VA = "0x1873CE860")]
	private long LBENCEDEOAP(Type OBDHBADPJNM)
	{
		return default(long);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
internal struct OKNHLAODJKF : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private NativeBitArray FHEPPNHPHHO;

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x73D1530", Offset = "0x73D0330", VA = "0x1873D1530")]
	public OKNHLAODJKF(int BMGBDLLODJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x73D1240", Offset = "0x73D0040", VA = "0x1873D1240")]
	public static OKNHLAODJKF EJMBPIADODK(int MLAKJOPIGGN, NativeArray<KEJCGFMDGGO> ENPIDHGCEBL)
	{
		return default(OKNHLAODJKF);
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x73D1470", Offset = "0x73D0270", VA = "0x1873D1470")]
	public bool JIHHMBHEPJN(int KNCPCNBMDNF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x73D1220", Offset = "0x73D0020", VA = "0x1873D1220")]
	public void DJKOKNNCNMK(int KNCPCNBMDNF, bool IPHILEOFJLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x73D13C0", Offset = "0x73D01C0", VA = "0x1873D13C0")]
	public bool IKIPDIONMNH(KEJCGFMDGGO[] ENPIDHGCEBL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x73D1480", Offset = "0x73D0280", VA = "0x1873D1480")]
	public bool JPEOIBHCLMO(KEJCGFMDGGO[] ENPIDHGCEBL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x73D1230", Offset = "0x73D0030", VA = "0x1873D1230", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
internal class MBILHMNKKOL
{
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private static readonly IMOCAMGHNDM JBCGOBEIKAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private readonly BCBGGKGOEJO LGAECFLJFJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private readonly List<EALPDHOFMOP> PKICOPGLKOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private readonly KGOPFOLFKOD IGILDDNIHPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private NativeParallelMultiHashMap<int, int> GFICKKHHCBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private NativeList<int> LKPJCLPLOMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private bool BBDDFKFCEGM;

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public List<EALPDHOFMOP> OLPHNNMEJBP
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x8F4430", Offset = "0x8F3230", VA = "0x1808F4430")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x73D0A90", Offset = "0x73CF890", VA = "0x1873D0A90")]
	public MBILHMNKKOL(BCBGGKGOEJO LGAECFLJFJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x73D0920", Offset = "0x73CF720", VA = "0x1873D0920")]
	public void MOHLAAINEEE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x73D03D0", Offset = "0x73CF1D0", VA = "0x1873D03D0")]
	public void JFGCADIOOCK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x73CF970", Offset = "0x73CE770", VA = "0x1873CF970")]
	public NativeList<OIGAECJMGAB> AECOFMAGPIJ(NativeArray<KEJCGFMDGGO> ENPIDHGCEBL)
	{
		return default(NativeList<OIGAECJMGAB>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x73D02D0", Offset = "0x73CF0D0", VA = "0x1873D02D0")]
	private bool HHCAMGOMAEE(EALPDHOFMOP CNBDBMKADJM, OKNHLAODJKF APDFNDDGCCC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x33BFBD0", Offset = "0x33BE9D0", VA = "0x1833BFBD0")]
	private void BPPNLDLBCAE<TInterface, TAttribute>(Action<TInterface, TAttribute> MANHCMJFANP) where TInterface : EALPDHOFMOP where TAttribute : Attribute
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x73D03A0", Offset = "0x73CF1A0", VA = "0x1873D03A0")]
	private void HLEJEKPOHAM(Type OBDHBADPJNM, Type ADNLEPNEACA, Type LAHOHLFJHND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x33BFE30", Offset = "0x33BEC30", VA = "0x1833BFE30")]
	private TInterface IJDDNJFDDMC<TInterface>(Type OBDHBADPJNM)
	{
		return (TInterface)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x73CFE60", Offset = "0x73CEC60", VA = "0x1873CFE60")]
	private int BOJODPHEKJP(EALPDHOFMOP NHDKBJDMLFJ, int JHPBGABBKOP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x73D0590", Offset = "0x73CF390", VA = "0x1873D0590")]
	private void JKHAEEPAEPO(DHLAJIFPLLJ CNBDBMKADJM, ONKOBDFKOJF CLBIJOKANHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x73CFF00", Offset = "0x73CED00", VA = "0x1873CFF00")]
	private void CDFINBJIJBI(PHFGODBDNAE CNBDBMKADJM, DEOKBDNPPCG CLBIJOKANHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x73D0810", Offset = "0x73CF610", VA = "0x1873D0810")]
	private void MCLMNMKBNDE(LNCMNFNJDOM CNBDBMKADJM, JJNDMFPDIEC CLBIJOKANHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x73D0200", Offset = "0x73CF000", VA = "0x1873D0200")]
	private void FPKOIDMHBOB(BLGNMLIHFAJ CNBDBMKADJM, PDJNEOBDGPJ CLBIJOKANHC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
internal struct HNNONOAKJKP : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private readonly List<EALPDHOFMOP> PKICOPGLKOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private NativeList<OIGAECJMGAB> DOKEDJNINLL;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public NativeList<OIGAECJMGAB> DLENLKMFEEJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x2B5B400", Offset = "0x2B5A200", VA = "0x182B5B400")]
		get
		{
			return default(NativeList<OIGAECJMGAB>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x73CBDB0", Offset = "0x73CABB0", VA = "0x1873CBDB0")]
	public HNNONOAKJKP(List<EALPDHOFMOP> PKICOPGLKOM, NativeArray<OIGAECJMGAB> DPPMFEPEKJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x73CB810", Offset = "0x73CA610", VA = "0x1873CB810", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x73CB850", Offset = "0x73CA650", VA = "0x1873CB850")]
	private NativeList<OIGAECJMGAB> EBIKCBFKPPO(NativeArray<OIGAECJMGAB> MJGFKJIKGJL)
	{
		return default(NativeList<OIGAECJMGAB>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x73CBCC0", Offset = "0x73CAAC0", VA = "0x1873CBCC0")]
	private bool MKJBLOHAAMF(EALPDHOFMOP CNBDBMKADJM, OKNHLAODJKF NMKIMMLLKEM, KEJCGFMDGGO AMBDMECJFHI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x73CBB80", Offset = "0x73CA980", VA = "0x1873CBB80")]
	private void EDEKOHGEMNI(EALPDHOFMOP CNBDBMKADJM, OKNHLAODJKF FHEPPNHPHHO, KEJCGFMDGGO HEPHNKLNPIK)
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000029")]
internal struct DCPGHJDCDNI : IComparer<OIGAECJMGAB>
{
	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x73CA880", Offset = "0x73C9680", VA = "0x1873CA880", Slot = "4")]
	public int Compare(OIGAECJMGAB HJGGLHBFMKO, OIGAECJMGAB AGAPPIBJJBC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x73CA890", Offset = "0x73C9690", VA = "0x1873CA890")]
	public static void DNCCLPELLGE(NativeList<OIGAECJMGAB> DPPMFEPEKJO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
[AttributeUsage(AttributeTargets.Class)]
public class PDJNEOBDGPJ : HHIPKBMNLOA
{
	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x73D1660", Offset = "0x73D0460", VA = "0x1873D1660")]
	public PDJNEOBDGPJ(int CKBPAMIEPPI = 1)
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
