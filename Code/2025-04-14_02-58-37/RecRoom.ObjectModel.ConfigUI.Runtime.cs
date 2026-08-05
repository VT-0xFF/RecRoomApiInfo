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
	public class LogRegistrationIndex : CCAGPMFGEMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x7A75D10", Offset = "0x7A74710", VA = "0x187A75D10", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x9AED50", Offset = "0x9AD750", VA = "0x1809AED50", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x1F7EA40", Offset = "0x1F7D440", VA = "0x181F7EA40", Slot = "5")]
		public override void SetServiceCategoryIndices(List<int> globalFromLocalIndices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x7A770C0", Offset = "0x7A75AC0", VA = "0x187A770C0")]
		private void IPCGMJBOKKK(IServiceRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x7A77300", Offset = "0x7A75D00", VA = "0x187A77300", Slot = "6")]
		public override void RegisterServices(IServiceRegistration registry, [In] ServiceBitsetFilter filter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x7A77360", Offset = "0x7A75D60", VA = "0x187A77360", Slot = "7")]
		public override void RegisterTypes(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x7A77A50", Offset = "0x7A76450", VA = "0x187A77A50")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
internal abstract class BADGLGNEOBG : GKHGDLGAPCG<Enum>, GHKJNDGDJJA, DMHJADOFHJO, NAOEMNIHDHF
{
	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "7")]
	public abstract bool OMCCHDFEAPE(Type OHCGINPDMEI);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x7A6F540", Offset = "0x7A6DF40", VA = "0x187A6F540")]
	protected BADGLGNEOBG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
internal abstract class GKHGDLGAPCG<T> : DMHJADOFHJO, NAOEMNIHDHF where T : Enum
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[CompilerGenerated]
	private sealed class KPPPKJOIAMI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		public IIHMHNPKOHI property;

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x9B1770", Offset = "0x9B0170", VA = "0x1809B1770")]
		public KPPPKJOIAMI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x4E24D10", Offset = "0x4E23710", VA = "0x184E24D10")]
		internal bool FHFBNIHCMLG()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x48D93C0", Offset = "0x48D7DC0", VA = "0x1848D93C0")]
	protected GKHGDLGAPCG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x48D91A0", Offset = "0x48D7BA0", VA = "0x1848D91A0")]
	protected void LCIKMHAHAAM(MFKPFKPFGIL GAICPBMAOMP, IIHMHNPKOHI LDIFMBFDAPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x48D8D30", Offset = "0x48D7730", VA = "0x1848D8D30")]
	protected void COIJDNGKNKJ(OCNKPBBMDDI<T> GAICPBMAOMP, IIHMHNPKOHI LDIFMBFDAPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "5")]
	public abstract void OKBDEDLPION(IIHMHNPKOHI LDIFMBFDAPL, PCCDPJCCLCB DIKACDMOGAI);
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
internal abstract class MLLEDCDIHIF : PFLEFFBGKLP, NAOEMNIHDHF
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public abstract DBDIPFEPNDG[] PFPONHPDFNL
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public abstract DBDIPFEPNDG[] GLEBELIEOPN
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "9")]
	public abstract void OKBDEDLPION(IIHMHNPKOHI LDIFMBFDAPL, AOJJHODMOIO MJJCDBCIJMF, MPEEOMKACKA HBDHDMCEFMJ, PCCDPJCCLCB DIKACDMOGAI);

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x3754930", Offset = "0x3753330", VA = "0x183754930")]
	protected static T KAFIHBCMOMF<T>(KFKFMJGCIBC FHANMPNELBN, HLIGJNDODGC<T> LDIFMBFDAPL) where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x3754980", Offset = "0x3753380", VA = "0x183754980")]
	protected static void NJIMDNOEGAG<T>(KFKFMJGCIBC FHANMPNELBN, HLIGJNDODGC<T> LDIFMBFDAPL, T PPJFMHBDGNA) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x9B1770", Offset = "0x9B0170", VA = "0x1809B1770")]
	protected MLLEDCDIHIF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
internal abstract class HBKMCJBKNCH<T> : DMHJADOFHJO, NAOEMNIHDHF where T : struct
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CompilerGenerated]
	private sealed class KDLMHOLGAKE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		public IIHMHNPKOHI property;

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x9B1770", Offset = "0x9B0170", VA = "0x1809B1770")]
		public KDLMHOLGAKE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x4DFCE80", Offset = "0x4DFB880", VA = "0x184DFCE80")]
		internal bool FHFBNIHCMLG()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x4935D10", Offset = "0x4934710", VA = "0x184935D10")]
	protected HBKMCJBKNCH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x4935730", Offset = "0x4934130", VA = "0x184935730")]
	protected void LCIKMHAHAAM(MFKPFKPFGIL GAICPBMAOMP, IIHMHNPKOHI LDIFMBFDAPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x4934650", Offset = "0x4933050", VA = "0x184934650")]
	protected void COIJDNGKNKJ(OCNKPBBMDDI<T> GAICPBMAOMP, IIHMHNPKOHI LDIFMBFDAPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(Slot = "5")]
	public abstract void OKBDEDLPION(IIHMHNPKOHI LDIFMBFDAPL, PCCDPJCCLCB DIKACDMOGAI);
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
[RegisterService(typeof(AOJJHODMOIO), new string[] { })]
internal class JDILHENLFIB : AOJJHODMOIO, PNIPCMGBJDE, BLJGGMGKPKC, OMHPDBDDEHH, HDFHGFMLGCI
{
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private static readonly LMPJBEBLCLM BLAHIKOFFGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	[DependsOn]
	private MPEEOMKACKA HBDHDMCEFMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	[DependsOn]
	private PCCDPJCCLCB IDGFKDEGEEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private KAJKNJKGPKB LOELPECPIHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private KFKFMJGCIBC FHANMPNELBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private List<IIHMHNPKOHI> BPIOCAHGAEF;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public KFKFMJGCIBC KAPGLJHCENE
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x132FD70", Offset = "0x132E770", VA = "0x18132FD70", Slot = "5")]
		get
		{
			return default(KFKFMJGCIBC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x7A72BC0", Offset = "0x7A715C0", VA = "0x187A72BC0", Slot = "6")]
	public void ACILAGDNKKA(LBHNIGEPODB GNJMKKKJHPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x7A72F10", Offset = "0x7A71910", VA = "0x187A72F10", Slot = "7")]
	public void FCBNDJLJLIB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x7A73200", Offset = "0x7A71C00", VA = "0x187A73200", Slot = "4")]
	public void GMIKEAONDOP(KFKFMJGCIBC DFDHDOCLBKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x7A73790", Offset = "0x7A72190", VA = "0x187A73790")]
	private void IFNDLPBFJPA(KFKFMJGCIBC DFDHDOCLBKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x7A73010", Offset = "0x7A71A10", VA = "0x187A73010")]
	private void GBMANIFKFKL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x7A73800", Offset = "0x7A72200", VA = "0x187A73800")]
	private void OKBDEDLPION(HEMCFMNCMIB PIPGIJFLAKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x7A73720", Offset = "0x7A72120", VA = "0x187A73720", Slot = "8")]
	private void HOMBBOJBDKL(LBHNIGEPODB GNJMKKKJHPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x10C4C30", Offset = "0x10C3630", VA = "0x1810C4C30", Slot = "9")]
	private void MOKMDAMCMCP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x7A73B70", Offset = "0x7A72570", VA = "0x187A73B70")]
	public JDILHENLFIB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
[JMADMCNOOKK(0)]
internal class MDEHOOEKOPC : BADGLGNEOBG
{
	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x7A760F0", Offset = "0x7A74AF0", VA = "0x187A760F0", Slot = "5")]
	public override void OKBDEDLPION(IIHMHNPKOHI LDIFMBFDAPL, PCCDPJCCLCB DIKACDMOGAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x7A761A0", Offset = "0x7A74BA0", VA = "0x187A761A0", Slot = "7")]
	public override bool OMCCHDFEAPE(Type OHCGINPDMEI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x7A6F540", Offset = "0x7A6DF40", VA = "0x187A6F540")]
	public MDEHOOEKOPC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
[JMADMCNOOKK(0)]
internal class LFGINIKPBML : BADGLGNEOBG
{
	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x7A75710", Offset = "0x7A74110", VA = "0x187A75710", Slot = "5")]
	public override void OKBDEDLPION(IIHMHNPKOHI LDIFMBFDAPL, PCCDPJCCLCB DIKACDMOGAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x7A757C0", Offset = "0x7A741C0", VA = "0x187A757C0", Slot = "7")]
	public override bool OMCCHDFEAPE(Type OHCGINPDMEI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x7A6F540", Offset = "0x7A6DF40", VA = "0x187A6F540")]
	public LFGINIKPBML()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
[KFOGAKFBIGN(typeof(EJODAALJJDB), 1)]
internal class IMGGGDJGAPN : GKHGDLGAPCG<EJODAALJJDB>
{
	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x7A729C0", Offset = "0x7A713C0", VA = "0x187A729C0", Slot = "5")]
	public override void OKBDEDLPION(IIHMHNPKOHI LDIFMBFDAPL, PCCDPJCCLCB DIKACDMOGAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x7A72B10", Offset = "0x7A71510", VA = "0x187A72B10")]
	public IMGGGDJGAPN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
[BNGPLICBMKD(2)]
internal class DDNNGBLNOAE : MLLEDCDIHIF
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[CompilerGenerated]
	private sealed class OHLPBKEGGJC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public AOJJHODMOIO configUIService;

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x9B1770", Offset = "0x9B0170", VA = "0x1809B1770")]
		public OHLPBKEGGJC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x7A765C0", Offset = "0x7A74FC0", VA = "0x187A765C0")]
		internal (int, int) NBBANBMHGAJ()
		{
			return default((int, int));
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x7A76820", Offset = "0x7A75220", VA = "0x187A76820")]
		internal void PDPBEAFBPKN((int color, int material) value)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public override DBDIPFEPNDG[] PFPONHPDFNL
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x9AEFD0", Offset = "0x9AD9D0", VA = "0x1809AEFD0", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public override DBDIPFEPNDG[] GLEBELIEOPN
	{
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x9ACED0", Offset = "0x9AB8D0", VA = "0x1809ACED0", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x7A6FEC0", Offset = "0x7A6E8C0", VA = "0x187A6FEC0", Slot = "9")]
	public override void OKBDEDLPION(IIHMHNPKOHI LDIFMBFDAPL, AOJJHODMOIO MJJCDBCIJMF, MPEEOMKACKA HBDHDMCEFMJ, PCCDPJCCLCB DIKACDMOGAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x7A70280", Offset = "0x7A6EC80", VA = "0x187A70280")]
	public DDNNGBLNOAE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
[KFOGAKFBIGN(typeof(bool))]
internal class HHINJJMDPNA : HBKMCJBKNCH<bool>
{
	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x7A722A0", Offset = "0x7A70CA0", VA = "0x187A722A0", Slot = "5")]
	public override void OKBDEDLPION(IIHMHNPKOHI LDIFMBFDAPL, PCCDPJCCLCB DIKACDMOGAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x7A72330", Offset = "0x7A70D30", VA = "0x187A72330")]
	public HHINJJMDPNA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
[KFOGAKFBIGN(typeof(FixedString32Bytes))]
internal class MPJNKFKFBNN : HBKMCJBKNCH<FixedString32Bytes>
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[CompilerGenerated]
	private sealed class CELFBHIKDMF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public IIHMHNPKOHI property;

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x9B1770", Offset = "0x9B0170", VA = "0x1809B1770")]
		public CELFBHIKDMF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x7A6F9C0", Offset = "0x7A6E3C0", VA = "0x187A6F9C0")]
		internal string NBBANBMHGAJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x7A6FA20", Offset = "0x7A6E420", VA = "0x187A6FA20")]
		internal void PDPBEAFBPKN(string value)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x7A76310", Offset = "0x7A74D10", VA = "0x187A76310", Slot = "5")]
	public override void OKBDEDLPION(IIHMHNPKOHI LDIFMBFDAPL, PCCDPJCCLCB DIKACDMOGAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x7A764B0", Offset = "0x7A74EB0", VA = "0x187A764B0")]
	public MPJNKFKFBNN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
[KFOGAKFBIGN(typeof(FixedString64Bytes))]
internal class HNOEBDIPBBN : HBKMCJBKNCH<FixedString64Bytes>
{
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	[CompilerGenerated]
	private sealed class KAJDHGMDAMH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public IIHMHNPKOHI property;

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x9B1770", Offset = "0x9B0170", VA = "0x1809B1770")]
		public KAJDHGMDAMH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x7A74390", Offset = "0x7A72D90", VA = "0x187A74390")]
		internal string NBBANBMHGAJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x7A74410", Offset = "0x7A72E10", VA = "0x187A74410")]
		internal void PDPBEAFBPKN(string value)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x7A727E0", Offset = "0x7A711E0", VA = "0x187A727E0", Slot = "5")]
	public override void OKBDEDLPION(IIHMHNPKOHI LDIFMBFDAPL, PCCDPJCCLCB DIKACDMOGAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x7A72980", Offset = "0x7A71380", VA = "0x187A72980")]
	public HNOEBDIPBBN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
[KFOGAKFBIGN(typeof(float3))]
internal class GEDFADGPHOD : HBKMCJBKNCH<float3>
{
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[CompilerGenerated]
	private sealed class MCFHCIMEBOJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public IIHMHNPKOHI property;

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x9B1770", Offset = "0x9B0170", VA = "0x1809B1770")]
		public MCFHCIMEBOJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x7A76000", Offset = "0x7A74A00", VA = "0x187A76000")]
		internal float NBBANBMHGAJ()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x7A760E0", Offset = "0x7A74AE0", VA = "0x187A760E0")]
		internal void PDPBEAFBPKN(float value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x7A75F90", Offset = "0x7A74990", VA = "0x187A75F90")]
		internal float MPHFOFOADPC()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x7A75E20", Offset = "0x7A74820", VA = "0x187A75E20")]
		internal void BGHKOLGJNDN(float value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x7A76070", Offset = "0x7A74A70", VA = "0x187A76070")]
		internal float OEKDGBADFJN()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x7A75F80", Offset = "0x7A74980", VA = "0x187A75F80")]
		internal void MCGHFMHFBEC(float value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x7A75F10", Offset = "0x7A74910", VA = "0x187A75F10")]
		internal float IAOEMMLIACB(int index)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x7A75E30", Offset = "0x7A74830", VA = "0x187A75E30")]
		internal void GFCFPMPHPNC(int index, float value)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x7A707B0", Offset = "0x7A6F1B0", VA = "0x187A707B0", Slot = "5")]
	public override void OKBDEDLPION(IIHMHNPKOHI LDIFMBFDAPL, PCCDPJCCLCB DIKACDMOGAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x7A70BE0", Offset = "0x7A6F5E0", VA = "0x187A70BE0")]
	public GEDFADGPHOD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
[KFOGAKFBIGN(typeof(float))]
internal class MKILKNGAJCM : HBKMCJBKNCH<float>
{
	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x7A76240", Offset = "0x7A74C40", VA = "0x187A76240", Slot = "5")]
	public override void OKBDEDLPION(IIHMHNPKOHI LDIFMBFDAPL, PCCDPJCCLCB DIKACDMOGAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x7A762D0", Offset = "0x7A74CD0", VA = "0x187A762D0")]
	public MKILKNGAJCM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
[KFOGAKFBIGN(typeof(int))]
internal class NNPLAIKCIAI : HBKMCJBKNCH<int>
{
	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x7A764F0", Offset = "0x7A74EF0", VA = "0x187A764F0", Slot = "5")]
	public override void OKBDEDLPION(IIHMHNPKOHI LDIFMBFDAPL, PCCDPJCCLCB DIKACDMOGAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x7A76580", Offset = "0x7A74F80", VA = "0x187A76580")]
	public NNPLAIKCIAI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
[KFOGAKFBIGN(typeof(quaternion))]
internal class HMLEEEGPINA : HBKMCJBKNCH<quaternion>
{
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	[CompilerGenerated]
	private sealed class COMKBCNELAM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public IIHMHNPKOHI property;

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x9B1770", Offset = "0x9B0170", VA = "0x1809B1770")]
		public COMKBCNELAM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x7A6FE90", Offset = "0x7A6E890", VA = "0x187A6FE90")]
		internal float NBBANBMHGAJ()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x7A6FEB0", Offset = "0x7A6E8B0", VA = "0x187A6FEB0")]
		internal void PDPBEAFBPKN(float value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x7A6FE80", Offset = "0x7A6E880", VA = "0x187A6FE80")]
		internal float MPHFOFOADPC()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x7A6FC00", Offset = "0x7A6E600", VA = "0x187A6FC00")]
		internal void BGHKOLGJNDN(float value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x7A6FEA0", Offset = "0x7A6E8A0", VA = "0x187A6FEA0")]
		internal float OEKDGBADFJN()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x7A6FE70", Offset = "0x7A6E870", VA = "0x187A6FE70")]
		internal void MCGHFMHFBEC(float value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x7A6FA90", Offset = "0x7A6E490", VA = "0x187A6FA90")]
		internal float APCIEAIAKIE(int index)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x7A6FC10", Offset = "0x7A6E610", VA = "0x187A6FC10")]
		internal void BPMODECHAIN(int index, float value)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x7A72370", Offset = "0x7A70D70", VA = "0x187A72370", Slot = "5")]
	public override void OKBDEDLPION(IIHMHNPKOHI LDIFMBFDAPL, PCCDPJCCLCB DIKACDMOGAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x7A727A0", Offset = "0x7A711A0", VA = "0x187A727A0")]
	public HMLEEEGPINA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
[KFOGAKFBIGN(typeof(uint))]
internal class EJHBAGIAOHN : HBKMCJBKNCH<uint>
{
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	[CompilerGenerated]
	private sealed class ACDAKNPLCKP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public IIHMHNPKOHI property;

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x9B1770", Offset = "0x9B0170", VA = "0x1809B1770")]
		public ACDAKNPLCKP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x7A6F4B0", Offset = "0x7A6DEB0", VA = "0x187A6F4B0")]
		internal int NBBANBMHGAJ()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x7A6F4F0", Offset = "0x7A6DEF0", VA = "0x187A6F4F0")]
		internal void PDPBEAFBPKN(int value)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x7A705D0", Offset = "0x7A6EFD0", VA = "0x187A705D0", Slot = "5")]
	public override void OKBDEDLPION(IIHMHNPKOHI LDIFMBFDAPL, PCCDPJCCLCB DIKACDMOGAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x7A70770", Offset = "0x7A6F170", VA = "0x187A70770")]
	public EJHBAGIAOHN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
internal struct HEMCFMNCMIB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public int NMNOBHLECNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public DBDIPFEPNDG LDIFMBFDAPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public int KLEICHAFCLM;
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
internal static class BOMLBOHBBJG
{
	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x7A6F8F0", Offset = "0x7A6E2F0", VA = "0x187A6F8F0")]
	public static void NBKAFJBJFNK(Type PJJOKEEIIPO, Type DIGFCDLCOMM)
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200001F")]
internal struct OJPCMLDGDMC
{
	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x7A76960", Offset = "0x7A75360", VA = "0x187A76960")]
	public static NativeList<DBDIPFEPNDG> GENPAMPPHBD(KFKFMJGCIBC FHANMPNELBN, MPEEOMKACKA HBDHDMCEFMJ)
	{
		return default(NativeList<DBDIPFEPNDG>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x7A76BC0", Offset = "0x7A755C0", VA = "0x187A76BC0")]
	private static bool JIPOCHIAMAO(DBDIPFEPNDG LDIFMBFDAPL, KFKFMJGCIBC FHANMPNELBN)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public class JLHDHEMAAKM : IIHMHNPKOHI, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private readonly DBDIPFEPNDG LDIFMBFDAPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private readonly MPEEOMKACKA GCGBBJOEAED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private readonly KFKFMJGCIBC FHANMPNELBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private bool FIMHNIKAAJI;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public string HFKDIDMKBGI
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x7A73CE0", Offset = "0x7A726E0", VA = "0x187A73CE0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public bool MJIOMGCHBIC
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x7A74100", Offset = "0x7A72B00", VA = "0x187A74100", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public DFLEJIJCDEG JCBEFODLPCC
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x7A740B0", Offset = "0x7A72AB0", VA = "0x187A740B0", Slot = "8")]
		get
		{
			return default(DFLEJIJCDEG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public Type ABBLELNBDOD
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x7A73D40", Offset = "0x7A72740", VA = "0x187A73D40", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event Action FEDFDEPKJAP
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x7A73E60", Offset = "0x7A72860", VA = "0x187A73E60", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x7A73F00", Offset = "0x7A72900", VA = "0x187A73F00", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x7A742A0", Offset = "0x7A72CA0", VA = "0x187A742A0")]
	public JLHDHEMAAKM(KFKFMJGCIBC FHANMPNELBN, DBDIPFEPNDG LDIFMBFDAPL, MPEEOMKACKA GCGBBJOEAED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x7A73FA0", Offset = "0x7A729A0", VA = "0x187A73FA0")]
	private void KAJPKBJBHBN(OFFLNPLDBAL DFPGGEDGGGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x7A73C00", Offset = "0x7A72600", VA = "0x187A73C00", Slot = "10")]
	public void BLCCCENAIKI(GDFAAFKOMOG PPJFMHBDGNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x7A74180", Offset = "0x7A72B80", VA = "0x187A74180", Slot = "11")]
	public void PMHEFKOCJCJ(FIDCCCBCGML PPJFMHBDGNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x7A73D90", Offset = "0x7A72790", VA = "0x187A73D90", Slot = "12")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
[JCNMJOIGONP(1)]
internal sealed class HFLABMOMNPO : OPFLGJHJMEP, DMHJADOFHJO, NAOEMNIHDHF
{
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[CompilerGenerated]
	private sealed class DIAAJGBGBDM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public IIHMHNPKOHI property;

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x9B1770", Offset = "0x9B0170", VA = "0x1809B1770")]
		public DIAAJGBGBDM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x7A70500", Offset = "0x7A6EF00", VA = "0x187A70500")]
		internal bool NBBANBMHGAJ()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x7A70550", Offset = "0x7A6EF50", VA = "0x187A70550")]
		internal string PDPBEAFBPKN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x7A70470", Offset = "0x7A6EE70", VA = "0x187A70470")]
		internal void MPHFOFOADPC(string value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x7A703A0", Offset = "0x7A6EDA0", VA = "0x187A703A0")]
		internal string BGHKOLGJNDN()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public DBDIPFEPNDG LDBNNDPEJHB
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x7A71DD0", Offset = "0x7A707D0", VA = "0x187A71DD0", Slot = "4")]
		get
		{
			return default(DBDIPFEPNDG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x7A71E40", Offset = "0x7A70840", VA = "0x187A71E40", Slot = "5")]
	public void OKBDEDLPION(IIHMHNPKOHI LDIFMBFDAPL, PCCDPJCCLCB DIKACDMOGAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x9B1770", Offset = "0x9B0170", VA = "0x1809B1770")]
	public HFLABMOMNPO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
internal class GKHDKCGNDMI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private readonly MPEEOMKACKA HBDHDMCEFMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	private readonly PCCDPJCCLCB DIKACDMOGAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	private readonly Action<HEMCFMNCMIB> NEPOLLLPNEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private readonly HashSet<IAEKMPLBFFD> NEPNBCHPIMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private readonly Dictionary<IAEKMPLBFFD, List<HEMCFMNCMIB>> KAEPBPOPDDM;

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x7A716B0", Offset = "0x7A700B0", VA = "0x187A716B0")]
	public GKHDKCGNDMI(MPEEOMKACKA HBDHDMCEFMJ, PCCDPJCCLCB DIKACDMOGAI, Action<HEMCFMNCMIB> NEPOLLLPNEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x7A70C80", Offset = "0x7A6F680", VA = "0x187A70C80")]
	public void HHKAOCKDOAF(NativeList<HEMCFMNCMIB> HIILGJAHBHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x7A70FF0", Offset = "0x7A6F9F0", VA = "0x187A70FF0")]
	private void JLFLLFMAHNL(IAEKMPLBFFD ILBJJIFAJFF, HEMCFMNCMIB PIPGIJFLAKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x7A70C20", Offset = "0x7A6F620", VA = "0x187A70C20")]
	public void DEBMOGFCPED()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x7A71230", Offset = "0x7A6FC30", VA = "0x187A71230")]
	private void NBLOFLLCIAM(IAEKMPLBFFD ILBJJIFAJFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x7A71190", Offset = "0x7A6FB90", VA = "0x187A71190")]
	private void LPJMJJCDPJK(IAEKMPLBFFD ILBJJIFAJFF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
internal class PEBOAKFBOJI : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	[CompilerGenerated]
	private sealed class LMCHIONMFMD : IEnumerable<DBDIPFEPNDG>, IEnumerable, IEnumerator<DBDIPFEPNDG>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private DBDIPFEPNDG <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		public PEBOAKFBOJI <>4__this;

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
		private DBDIPFEPNDG System.Collections.Generic.IEnumerator<RecRoom.DataLayer.NetworkProperty>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0xB16BF0", Offset = "0xB155F0", VA = "0x180B16BF0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default(DBDIPFEPNDG);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600008A")]
			[Cpp2IlInjected.Address(RVA = "0x7A75C30", Offset = "0x7A74630", VA = "0x187A75C30", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x11D73F0", Offset = "0x11D5DF0", VA = "0x1811D73F0")]
		[DebuggerHidden]
		public LMCHIONMFMD(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x7A75C80", Offset = "0x7A74680", VA = "0x187A75C80", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x7A758C0", Offset = "0x7A742C0", VA = "0x187A758C0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x7A75870", Offset = "0x7A74270", VA = "0x187A75870")]
		private void JKNFIIFCPDC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x7A75BE0", Offset = "0x7A745E0", VA = "0x187A75BE0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x7A75B20", Offset = "0x7A74520", VA = "0x187A75B20", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<DBDIPFEPNDG> System.Collections.Generic.IEnumerable<RecRoom.DataLayer.NetworkProperty>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x7A75B20", Offset = "0x7A74520", VA = "0x187A75B20", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private static readonly LMPJBEBLCLM BLAHIKOFFGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private NativeParallelMultiHashMap<long, int> AEOKBPAGGGM;

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x7A76ED0", Offset = "0x7A758D0", VA = "0x187A76ED0")]
	public PEBOAKFBOJI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x7A76CB0", Offset = "0x7A756B0", VA = "0x187A76CB0")]
	[IteratorStateMachine(typeof(LMCHIONMFMD))]
	public IEnumerable<DBDIPFEPNDG> DBOAKFBDEIK(Type OHCGINPDMEI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x7A76D50", Offset = "0x7A75750", VA = "0x187A76D50", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x7A76D90", Offset = "0x7A75790", VA = "0x187A76D90")]
	private long EOBMLAKMHFB(DBDIPFEPNDG LDIFMBFDAPL)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x7A76E10", Offset = "0x7A75810", VA = "0x187A76E10")]
	private long EOBMLAKMHFB(Type OHCGINPDMEI)
	{
		return default(long);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
internal struct BIFGCACGAPO : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private NativeBitArray FDBNBOEPIBM;

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x7A6F890", Offset = "0x7A6E290", VA = "0x187A6F890")]
	public BIFGCACGAPO(int PGJKBFGEJNK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x7A6F5A0", Offset = "0x7A6DFA0", VA = "0x187A6F5A0")]
	public static BIFGCACGAPO IFMHFKMNAPL(int CIIHPLFOGKO, NativeArray<DBDIPFEPNDG> FPBCGBJHAKH)
	{
		return default(BIFGCACGAPO);
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x7A6F580", Offset = "0x7A6DF80", VA = "0x187A6F580")]
	public bool CFNNLKKLOKM(int DOAKEFBOPIA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x7A6F880", Offset = "0x7A6E280", VA = "0x187A6F880")]
	public void PMHEFKOCJCJ(int DOAKEFBOPIA, bool PPJFMHBDGNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x7A6F7D0", Offset = "0x7A6E1D0", VA = "0x187A6F7D0")]
	public bool NOMMEILPFHJ(DBDIPFEPNDG[] FPBCGBJHAKH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x7A6F720", Offset = "0x7A6E120", VA = "0x187A6F720")]
	public bool LEPHPCMDGGI(DBDIPFEPNDG[] FPBCGBJHAKH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x7A6F590", Offset = "0x7A6DF90", VA = "0x187A6F590", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
internal class KAJKNJKGPKB
{
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private static readonly LMPJBEBLCLM BLAHIKOFFGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private readonly MPEEOMKACKA HBDHDMCEFMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private readonly List<NAOEMNIHDHF> GGINPKODBLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private readonly PEBOAKFBOJI AEOKBPAGGGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private NativeParallelMultiHashMap<int, int> PDNEBFPOLEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private NativeList<int> HGCJKFNEGFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private bool FIMHNIKAAJI;

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public List<NAOEMNIHDHF> NAGNDMLLHMC
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x9ACED0", Offset = "0x9AB8D0", VA = "0x1809ACED0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x7A755B0", Offset = "0x7A73FB0", VA = "0x187A755B0")]
	public KAJKNJKGPKB(MPEEOMKACKA HBDHDMCEFMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x7A744A0", Offset = "0x7A72EA0", VA = "0x187A744A0")]
	public void CHMHFDMILHD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x7A74970", Offset = "0x7A73370", VA = "0x187A74970")]
	public void INCOBLPFEFO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x7A74B30", Offset = "0x7A73530", VA = "0x187A74B30")]
	public NativeList<HEMCFMNCMIB> JJDNFGKCJFJ(NativeArray<DBDIPFEPNDG> FPBCGBJHAKH)
	{
		return default(NativeList<HEMCFMNCMIB>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x7A75460", Offset = "0x7A73E60", VA = "0x187A75460")]
	private bool PNGMHIPJIHA(NAOEMNIHDHF CAEMAGBBDIF, BIFGCACGAPO DKMKJOKJNKJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x3709A10", Offset = "0x3708410", VA = "0x183709A10")]
	private void DCJJHPMCFMG<TInterface, TAttribute>(Action<TInterface, TAttribute> OHGAOFBPBAG) where TInterface : NAOEMNIHDHF where TAttribute : Attribute
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x7A75430", Offset = "0x7A73E30", VA = "0x187A75430")]
	private void PBLHPJJHAAO(Type OHCGINPDMEI, Type CHIMCMPDEGE, Type MEOIBCLMCNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x3709C70", Offset = "0x3708670", VA = "0x183709C70")]
	private TInterface PFFMHOBLMFM<TInterface>(Type OHCGINPDMEI)
	{
		return (TInterface)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x7A748D0", Offset = "0x7A732D0", VA = "0x187A748D0")]
	private int ILDIDAJOJFE(NAOEMNIHDHF KDMEMFMCOOJ, int KLEICHAFCLM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x7A74650", Offset = "0x7A73050", VA = "0x187A74650")]
	private void HIAPDOFEKMN(DMHJADOFHJO CAEMAGBBDIF, KFOGAKFBIGN MMHPKEJFKOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x7A75130", Offset = "0x7A73B30", VA = "0x187A75130")]
	private void MMMOAJJPGAD(GHKJNDGDJJA CAEMAGBBDIF, JMADMCNOOKK MMHPKEJFKOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x7A75020", Offset = "0x7A73A20", VA = "0x187A75020")]
	private void MKCEANNDLHB(PFLEFFBGKLP CAEMAGBBDIF, BNGPLICBMKD MMHPKEJFKOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x7A74580", Offset = "0x7A72F80", VA = "0x187A74580")]
	private void DIBDOCKACBK(OPFLGJHJMEP CAEMAGBBDIF, JCNMJOIGONP MMHPKEJFKOE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
internal struct HABBGLFMKDD : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private readonly List<NAOEMNIHDHF> GGINPKODBLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private NativeList<HEMCFMNCMIB> PIHNHKHIKEF;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public NativeList<HEMCFMNCMIB> HIOPCIJDNKB
	{
		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x2CDA850", Offset = "0x2CD9250", VA = "0x182CDA850")]
		get
		{
			return default(NativeList<HEMCFMNCMIB>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x7A71D70", Offset = "0x7A70770", VA = "0x187A71D70")]
	public HABBGLFMKDD(List<NAOEMNIHDHF> GGINPKODBLO, NativeArray<HEMCFMNCMIB> HIILGJAHBHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x7A71B00", Offset = "0x7A70500", VA = "0x187A71B00", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x7A717D0", Offset = "0x7A701D0", VA = "0x187A717D0")]
	private NativeList<HEMCFMNCMIB> ANHMLFDOGIB(NativeArray<HEMCFMNCMIB> NBOJIECECED)
	{
		return default(NativeList<HEMCFMNCMIB>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x7A71C80", Offset = "0x7A70680", VA = "0x187A71C80")]
	private bool NMAGPABOEJP(NAOEMNIHDHF CAEMAGBBDIF, BIFGCACGAPO FNIDBILJNJJ, DBDIPFEPNDG LDIFMBFDAPL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x7A71B40", Offset = "0x7A70540", VA = "0x187A71B40")]
	private void LJLKHIANJBJ(NAOEMNIHDHF CAEMAGBBDIF, BIFGCACGAPO FDBNBOEPIBM, DBDIPFEPNDG JJFNHINHLDE)
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000029")]
internal struct IOFBLCFPHFM : IComparer<HEMCFMNCMIB>
{
	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x7A72B50", Offset = "0x7A71550", VA = "0x187A72B50", Slot = "4")]
	public int Compare(HEMCFMNCMIB KEEADJCBJCP, HEMCFMNCMIB LKKBJAKGIGL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x7A72B60", Offset = "0x7A71560", VA = "0x187A72B60")]
	public static void JGFMGEMKOFO(NativeList<HEMCFMNCMIB> HIILGJAHBHJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
[AttributeUsage(AttributeTargets.Class)]
public class JCNMJOIGONP : MCDDOPEENNH
{
	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x7A72BB0", Offset = "0x7A715B0", VA = "0x187A72BB0")]
	public JCNMJOIGONP(int JEJIBJPMBDP = 1)
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
