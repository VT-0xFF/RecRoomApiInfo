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
	public class LogRegistrationIndex : BDONJGGEMII
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x7A3A250", Offset = "0x7A39650", VA = "0x187A3A250", Slot = "4")]
		public override void GEAMIGHEOPG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x9D4820", Offset = "0x9D3C20", VA = "0x1809D4820")]
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
			[Cpp2IlInjected.Address(RVA = "0x9AA3A0", Offset = "0x9A97A0", VA = "0x1809AA3A0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x1F4AA20", Offset = "0x1F49E20", VA = "0x181F4AA20", Slot = "5")]
		public override void SetServiceCategoryIndices(List<int> globalFromLocalIndices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x7A3CFB0", Offset = "0x7A3C3B0", VA = "0x187A3CFB0")]
		private void CJALBJKGDPB(IServiceRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x7A3D1F0", Offset = "0x7A3C5F0", VA = "0x187A3D1F0", Slot = "6")]
		public override void RegisterServices(IServiceRegistration registry, [In] ServiceBitsetFilter filter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x7A3D250", Offset = "0x7A3C650", VA = "0x187A3D250", Slot = "7")]
		public override void RegisterTypes(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x7A3D940", Offset = "0x7A3CD40", VA = "0x187A3D940")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
internal abstract class LHCPPPLMPEA : CEPDHDFMOKI<Enum>, OFLBHPLMPGN, GOLJIKAADON, DGDOIANFDLG
{
	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "7")]
	public abstract bool AFCCPNMFPAB(Type HAFNBBNOLPO);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x7A356D0", Offset = "0x7A34AD0", VA = "0x187A356D0")]
	protected LHCPPPLMPEA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
internal abstract class CEPDHDFMOKI<T> : GOLJIKAADON, DGDOIANFDLG where T : Enum
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[CompilerGenerated]
	private sealed class PIAIELLGNED
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		public DFBKNGEEMFG property;

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x9B8350", Offset = "0x9B7750", VA = "0x1809B8350")]
		public PIAIELLGNED()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x53142F0", Offset = "0x53136F0", VA = "0x1853142F0")]
		internal bool FKHFKMGEKPI()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x63E60B0", Offset = "0x63E54B0", VA = "0x1863E60B0")]
	protected CEPDHDFMOKI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x63E5E90", Offset = "0x63E5290", VA = "0x1863E5E90")]
	protected void ODEHEGDPMMF(NEPIPMPEKOG KAHAMJEBHHN, DFBKNGEEMFG MHALMOGKEGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x5317400", Offset = "0x5316800", VA = "0x185317400")]
	protected void GHIMEEBNOLG(JCACECMMFJF<T> KAHAMJEBHHN, DFBKNGEEMFG MHALMOGKEGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "5")]
	public abstract void ODNEDHINBAC(DFBKNGEEMFG MHALMOGKEGG, EHGNEHOIKIN NGGBILHBMJK);
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
internal abstract class NFDAHMOKIFP : KFKFEIJPPCA, DGDOIANFDLG
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public abstract JKPLFEIEHFJ[] KJFMCMLPDEK
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public abstract JKPLFEIEHFJ[] LKKLPPKAIIB
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "9")]
	public abstract void ODNEDHINBAC(DFBKNGEEMFG MHALMOGKEGG, IEPLONAFLHO HHGHPLDMMIL, CLCGHFJECND GBMGHNECBBK, EHGNEHOIKIN NGGBILHBMJK);

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x37CF530", Offset = "0x37CE930", VA = "0x1837CF530")]
	protected static T LGIOPOJABAN<T>(OJJAIKMKHDC KJACNMKOEKF, HOKJDAMJNEH<T> MHALMOGKEGG) where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x37CF430", Offset = "0x37CE830", VA = "0x1837CF430")]
	protected static void DNIHDHDEAMP<T>(OJJAIKMKHDC KJACNMKOEKF, HOKJDAMJNEH<T> MHALMOGKEGG, T FFOEEMKIKJO) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x9B8350", Offset = "0x9B7750", VA = "0x1809B8350")]
	protected NFDAHMOKIFP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
internal abstract class PIOHDNLPHBH<T> : GOLJIKAADON, DGDOIANFDLG where T : struct
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CompilerGenerated]
	private sealed class OEKCHHFDPDD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		public DFBKNGEEMFG property;

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x9B8350", Offset = "0x9B7750", VA = "0x1809B8350")]
		public OEKCHHFDPDD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x5213200", Offset = "0x5212600", VA = "0x185213200")]
		internal bool FKHFKMGEKPI()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x5318A90", Offset = "0x5317E90", VA = "0x185318A90")]
	protected PIOHDNLPHBH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x5317C90", Offset = "0x5317090", VA = "0x185317C90")]
	protected void ODEHEGDPMMF(NEPIPMPEKOG KAHAMJEBHHN, DFBKNGEEMFG MHALMOGKEGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x5317650", Offset = "0x5316A50", VA = "0x185317650")]
	protected void GHIMEEBNOLG(JCACECMMFJF<T> KAHAMJEBHHN, DFBKNGEEMFG MHALMOGKEGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(Slot = "5")]
	public abstract void ODNEDHINBAC(DFBKNGEEMFG MHALMOGKEGG, EHGNEHOIKIN NGGBILHBMJK);
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
[RegisterService(typeof(IEPLONAFLHO), new string[] { })]
internal class FCNKHOFHBFL : IEPLONAFLHO, ADCACANLHCF, PIEEAAJKAEB, KKLCFFMBMBE, KKJGFIPLMOM
{
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private static readonly GBHBOJAPDOA DPDKJPMBJOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	[DependsOn]
	private CLCGHFJECND GBMGHNECBBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	[DependsOn]
	private EHGNEHOIKIN DEMCFBDMEDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private JLBJGANECKP NCDMBCEAKAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private OJJAIKMKHDC KJACNMKOEKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private List<DFBKNGEEMFG> BMCFPKAHNOI;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public OJJAIKMKHDC DMBPEFCLKKF
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x12FBE60", Offset = "0x12FB260", VA = "0x1812FBE60", Slot = "5")]
		get
		{
			return default(OJJAIKMKHDC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x7A36880", Offset = "0x7A35C80", VA = "0x187A36880", Slot = "6")]
	public void KPMGEBKCBEP(BJMEEALALCJ BJPDKNNBBOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x7A36BD0", Offset = "0x7A35FD0", VA = "0x187A36BD0", Slot = "7")]
	public void NLAAFKHBPFI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x7A36FC0", Offset = "0x7A363C0", VA = "0x187A36FC0", Slot = "4")]
	public void OGAEFCNGBJB(OJJAIKMKHDC PKANDCELKLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x7A374E0", Offset = "0x7A368E0", VA = "0x187A374E0")]
	private void PJBJCBKKOJO(OJJAIKMKHDC PKANDCELKLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x7A36690", Offset = "0x7A35A90", VA = "0x187A36690")]
	private void CMDNPEJEABC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x7A36CD0", Offset = "0x7A360D0", VA = "0x187A36CD0")]
	private void ODNEDHINBAC(DKMOJHDHHGO FEJOFABKKKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x7A36620", Offset = "0x7A35A20", VA = "0x187A36620", Slot = "8")]
	private void AMIFDGGMEHF(BJMEEALALCJ BJPDKNNBBOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x109A090", Offset = "0x1099490", VA = "0x18109A090", Slot = "9")]
	private void PBLPDJGLCKO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x7A375D0", Offset = "0x7A369D0", VA = "0x187A375D0")]
	public FCNKHOFHBFL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
[JDEGNJJOFAG(0)]
internal class AKPHBANLIGE : LHCPPPLMPEA
{
	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x7A35620", Offset = "0x7A34A20", VA = "0x187A35620", Slot = "5")]
	public override void ODNEDHINBAC(DFBKNGEEMFG MHALMOGKEGG, EHGNEHOIKIN NGGBILHBMJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x7A35580", Offset = "0x7A34980", VA = "0x187A35580", Slot = "7")]
	public override bool AFCCPNMFPAB(Type HAFNBBNOLPO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x7A356D0", Offset = "0x7A34AD0", VA = "0x187A356D0")]
	public AKPHBANLIGE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
[JDEGNJJOFAG(0)]
internal class ECNEAMAFGIC : LHCPPPLMPEA
{
	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x7A36570", Offset = "0x7A35970", VA = "0x187A36570", Slot = "5")]
	public override void ODNEDHINBAC(DFBKNGEEMFG MHALMOGKEGG, EHGNEHOIKIN NGGBILHBMJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x7A364C0", Offset = "0x7A358C0", VA = "0x187A364C0", Slot = "7")]
	public override bool AFCCPNMFPAB(Type HAFNBBNOLPO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x7A356D0", Offset = "0x7A34AD0", VA = "0x187A356D0")]
	public ECNEAMAFGIC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
[IDHBNIODMOE(typeof(IMDMMENCIGE), 1)]
internal class IIEMOIKIFGG : CEPDHDFMOKI<IMDMMENCIGE>
{
	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x7A38420", Offset = "0x7A37820", VA = "0x187A38420", Slot = "5")]
	public override void ODNEDHINBAC(DFBKNGEEMFG MHALMOGKEGG, EHGNEHOIKIN NGGBILHBMJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x7A38570", Offset = "0x7A37970", VA = "0x187A38570")]
	public IIEMOIKIFGG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
[PCGOJLGKPCM(2)]
internal class DBOAHBDANMM : NFDAHMOKIFP
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[CompilerGenerated]
	private sealed class ONEDBPELNIF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public IEPLONAFLHO configUIService;

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x9B8350", Offset = "0x9B7750", VA = "0x1809B8350")]
		public ONEDBPELNIF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x7A3C130", Offset = "0x7A3B530", VA = "0x187A3C130")]
		internal (int, int) BCBCDLOAOEK()
		{
			return default((int, int));
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x7A3C390", Offset = "0x7A3B790", VA = "0x187A3C390")]
		internal void KMPDICOPLGO((int color, int material) value)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public override JKPLFEIEHFJ[] KJFMCMLPDEK
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x9AA3B0", Offset = "0x9A97B0", VA = "0x1809AA3B0", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public override JKPLFEIEHFJ[] LKKLPPKAIIB
	{
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x9A91C0", Offset = "0x9A85C0", VA = "0x1809A91C0", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x7A35F80", Offset = "0x7A35380", VA = "0x187A35F80", Slot = "9")]
	public override void ODNEDHINBAC(DFBKNGEEMFG MHALMOGKEGG, IEPLONAFLHO HHGHPLDMMIL, CLCGHFJECND GBMGHNECBBK, EHGNEHOIKIN NGGBILHBMJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x7A36340", Offset = "0x7A35740", VA = "0x187A36340")]
	public DBOAHBDANMM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
[IDHBNIODMOE(typeof(bool))]
internal class PBEAOGOGHGA : PIOHDNLPHBH<bool>
{
	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x7A3C4D0", Offset = "0x7A3B8D0", VA = "0x187A3C4D0", Slot = "5")]
	public override void ODNEDHINBAC(DFBKNGEEMFG MHALMOGKEGG, EHGNEHOIKIN NGGBILHBMJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x7A3C560", Offset = "0x7A3B960", VA = "0x187A3C560")]
	public PBEAOGOGHGA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
[IDHBNIODMOE(typeof(FixedString32Bytes))]
internal class AJJGGGPHKOG : PIOHDNLPHBH<FixedString32Bytes>
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[CompilerGenerated]
	private sealed class MJDFPGHMBDM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public DFBKNGEEMFG property;

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x9B8350", Offset = "0x9B7750", VA = "0x1809B8350")]
		public MJDFPGHMBDM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x7A3AF10", Offset = "0x7A3A310", VA = "0x187A3AF10")]
		internal string BCBCDLOAOEK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x7A3AF70", Offset = "0x7A3A370", VA = "0x187A3AF70")]
		internal void KMPDICOPLGO(string value)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x7A353A0", Offset = "0x7A347A0", VA = "0x187A353A0", Slot = "5")]
	public override void ODNEDHINBAC(DFBKNGEEMFG MHALMOGKEGG, EHGNEHOIKIN NGGBILHBMJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x7A35540", Offset = "0x7A34940", VA = "0x187A35540")]
	public AJJGGGPHKOG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
[IDHBNIODMOE(typeof(FixedString64Bytes))]
internal class FOPCOCDLFJK : PIOHDNLPHBH<FixedString64Bytes>
{
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	[CompilerGenerated]
	private sealed class NJGJHKOJJHL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public DFBKNGEEMFG property;

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x9B8350", Offset = "0x9B7750", VA = "0x1809B8350")]
		public NJGJHKOJJHL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x7A3AFE0", Offset = "0x7A3A3E0", VA = "0x187A3AFE0")]
		internal string BCBCDLOAOEK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x7A3B060", Offset = "0x7A3A460", VA = "0x187A3B060")]
		internal void KMPDICOPLGO(string value)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x7A37CC0", Offset = "0x7A370C0", VA = "0x187A37CC0", Slot = "5")]
	public override void ODNEDHINBAC(DFBKNGEEMFG MHALMOGKEGG, EHGNEHOIKIN NGGBILHBMJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x7A37E60", Offset = "0x7A37260", VA = "0x187A37E60")]
	public FOPCOCDLFJK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
[IDHBNIODMOE(typeof(float3))]
internal class PKBLJLNODIK : PIOHDNLPHBH<float3>
{
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[CompilerGenerated]
	private sealed class HPINFNFDDAL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public DFBKNGEEMFG property;

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x9B8350", Offset = "0x9B7750", VA = "0x1809B8350")]
		public HPINFNFDDAL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x7A37F70", Offset = "0x7A37370", VA = "0x187A37F70")]
		internal float BCBCDLOAOEK()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x7A38050", Offset = "0x7A37450", VA = "0x187A38050")]
		internal void KMPDICOPLGO(float value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x7A37FE0", Offset = "0x7A373E0", VA = "0x187A37FE0")]
		internal float BKFEOEBBHKC()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x7A38230", Offset = "0x7A37630", VA = "0x187A38230")]
		internal void PNDOLKBBHDA(float value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x7A38060", Offset = "0x7A37460", VA = "0x187A38060")]
		internal float KPGJKPODGMO()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x7A381B0", Offset = "0x7A375B0", VA = "0x187A381B0")]
		internal void OKMDODIGNNJ(float value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x7A381C0", Offset = "0x7A375C0", VA = "0x187A381C0")]
		internal float PIGFELBDDGB(int index)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x7A380D0", Offset = "0x7A374D0", VA = "0x187A380D0")]
		internal void LGAEBGKJCEM(int index, float value)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x7A3C5A0", Offset = "0x7A3B9A0", VA = "0x187A3C5A0", Slot = "5")]
	public override void ODNEDHINBAC(DFBKNGEEMFG MHALMOGKEGG, EHGNEHOIKIN NGGBILHBMJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x7A3C9D0", Offset = "0x7A3BDD0", VA = "0x187A3C9D0")]
	public PKBLJLNODIK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
[IDHBNIODMOE(typeof(float))]
internal class GDNLJNIEJOO : PIOHDNLPHBH<float>
{
	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x7A37EA0", Offset = "0x7A372A0", VA = "0x187A37EA0", Slot = "5")]
	public override void ODNEDHINBAC(DFBKNGEEMFG MHALMOGKEGG, EHGNEHOIKIN NGGBILHBMJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x7A37F30", Offset = "0x7A37330", VA = "0x187A37F30")]
	public GDNLJNIEJOO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
[IDHBNIODMOE(typeof(int))]
internal class PKKIEEBMBEB : PIOHDNLPHBH<int>
{
	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x7A3CA10", Offset = "0x7A3BE10", VA = "0x187A3CA10", Slot = "5")]
	public override void ODNEDHINBAC(DFBKNGEEMFG MHALMOGKEGG, EHGNEHOIKIN NGGBILHBMJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x7A3CAA0", Offset = "0x7A3BEA0", VA = "0x187A3CAA0")]
	public PKKIEEBMBEB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
[IDHBNIODMOE(typeof(quaternion))]
internal class BPEIGJAKJLE : PIOHDNLPHBH<quaternion>
{
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	[CompilerGenerated]
	private sealed class FNAACKJANMH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public DFBKNGEEMFG property;

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x9B8350", Offset = "0x9B7750", VA = "0x1809B8350")]
		public FNAACKJANMH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x7A37890", Offset = "0x7A36C90", VA = "0x187A37890")]
		internal float BCBCDLOAOEK()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x7A37C80", Offset = "0x7A37080", VA = "0x187A37C80")]
		internal void KMPDICOPLGO(float value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x7A37B00", Offset = "0x7A36F00", VA = "0x187A37B00")]
		internal float BKFEOEBBHKC()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x7A37CB0", Offset = "0x7A370B0", VA = "0x187A37CB0")]
		internal void PNDOLKBBHDA(float value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x7A37C90", Offset = "0x7A37090", VA = "0x187A37C90")]
		internal float KPGJKPODGMO()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x7A37CA0", Offset = "0x7A370A0", VA = "0x187A37CA0")]
		internal void OKMDODIGNNJ(float value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x7A37B10", Offset = "0x7A36F10", VA = "0x187A37B10")]
		internal float CAOELCFJEFM(int index)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x7A378A0", Offset = "0x7A36CA0", VA = "0x187A378A0")]
		internal void BFIIALGDAGA(int index, float value)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x7A357A0", Offset = "0x7A34BA0", VA = "0x187A357A0", Slot = "5")]
	public override void ODNEDHINBAC(DFBKNGEEMFG MHALMOGKEGG, EHGNEHOIKIN NGGBILHBMJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x7A35BD0", Offset = "0x7A34FD0", VA = "0x187A35BD0")]
	public BPEIGJAKJLE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
[IDHBNIODMOE(typeof(uint))]
internal class IHPKMFMLAJB : PIOHDNLPHBH<uint>
{
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	[CompilerGenerated]
	private sealed class BIOGDKNNCHD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public DFBKNGEEMFG property;

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x9B8350", Offset = "0x9B7750", VA = "0x1809B8350")]
		public BIOGDKNNCHD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x7A35710", Offset = "0x7A34B10", VA = "0x187A35710")]
		internal int BCBCDLOAOEK()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x7A35750", Offset = "0x7A34B50", VA = "0x187A35750")]
		internal void KMPDICOPLGO(int value)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x7A38240", Offset = "0x7A37640", VA = "0x187A38240", Slot = "5")]
	public override void ODNEDHINBAC(DFBKNGEEMFG MHALMOGKEGG, EHGNEHOIKIN NGGBILHBMJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x7A383E0", Offset = "0x7A377E0", VA = "0x187A383E0")]
	public IHPKMFMLAJB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
internal struct DKMOJHDHHGO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public int ANHGKPLFFAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public JKPLFEIEHFJ MHALMOGKEGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public int PKKOAIHLPOK;
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
internal static class KONBAJOKIJI
{
	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x7A3A180", Offset = "0x7A39580", VA = "0x187A3A180")]
	public static void NJKACMMFPPB(Type NFELEEFNGNO, Type CMDJGELPCKO)
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200001F")]
internal struct KKHFEBDHEOM
{
	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x7A39E30", Offset = "0x7A39230", VA = "0x187A39E30")]
	public static NativeList<JKPLFEIEHFJ> JFLHCOBGDIK(OJJAIKMKHDC KJACNMKOEKF, CLCGHFJECND GBMGHNECBBK)
	{
		return default(NativeList<JKPLFEIEHFJ>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x7A3A090", Offset = "0x7A39490", VA = "0x187A3A090")]
	private static bool KLOLMFNLGJE(JKPLFEIEHFJ MHALMOGKEGG, OJJAIKMKHDC KJACNMKOEKF)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public class OAGNJMJMAOA : DFBKNGEEMFG, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private readonly JKPLFEIEHFJ MHALMOGKEGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private readonly CLCGHFJECND PNJDLFCCMHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private readonly OJJAIKMKHDC KJACNMKOEKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private bool EKDCONIHOMM;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public string KAFLMFCDNKO
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x7A3B6B0", Offset = "0x7A3AAB0", VA = "0x187A3B6B0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public bool GDBJHGMFLKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x7A3B710", Offset = "0x7A3AB10", VA = "0x187A3B710", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public GNCDNFKLNJM FAGIPKBHANL
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x7A3B0F0", Offset = "0x7A3A4F0", VA = "0x187A3B0F0", Slot = "8")]
		get
		{
			return default(GNCDNFKLNJM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public Type KAFGKIIBACB
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x7A3B1E0", Offset = "0x7A3A5E0", VA = "0x187A3B1E0", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event Action HNFHPECKIOJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x7A3B140", Offset = "0x7A3A540", VA = "0x187A3B140", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x7A3B230", Offset = "0x7A3A630", VA = "0x187A3B230", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x7A3B790", Offset = "0x7A3AB90", VA = "0x187A3B790")]
	public OAGNJMJMAOA(OJJAIKMKHDC KJACNMKOEKF, JKPLFEIEHFJ MHALMOGKEGG, CLCGHFJECND PNJDLFCCMHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x7A3B5A0", Offset = "0x7A3A9A0", VA = "0x187A3B5A0")]
	private void KLBBMBOIEME(PKOKDAHEHKN HPMNBNLACCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x7A3B3A0", Offset = "0x7A3A7A0", VA = "0x187A3B3A0", Slot = "10")]
	public void IOLMGDEDCOJ(MMCAHBLJMAC FFOEEMKIKJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x7A3B480", Offset = "0x7A3A880", VA = "0x187A3B480", Slot = "11")]
	public void JFGGMENNDNP(OEMNHEJOOLM FFOEEMKIKJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x7A3B2D0", Offset = "0x7A3A6D0", VA = "0x187A3B2D0", Slot = "12")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
[JEFEHLFACFL(1)]
internal sealed class PNFAMFNHOID : IAJDKNEGCPJ, GOLJIKAADON, DGDOIANFDLG
{
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[CompilerGenerated]
	private sealed class FINCIDJHHMA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public DFBKNGEEMFG property;

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x9B8350", Offset = "0x9B7750", VA = "0x1809B8350")]
		public FINCIDJHHMA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x7A37660", Offset = "0x7A36A60", VA = "0x187A37660")]
		internal bool BCBCDLOAOEK()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x7A37740", Offset = "0x7A36B40", VA = "0x187A37740")]
		internal string KMPDICOPLGO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x7A376B0", Offset = "0x7A36AB0", VA = "0x187A376B0")]
		internal void BKFEOEBBHKC(string value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x7A377C0", Offset = "0x7A36BC0", VA = "0x187A377C0")]
		internal string PNDOLKBBHDA()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public JKPLFEIEHFJ AMBFGADHIEM
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x7A3CAE0", Offset = "0x7A3BEE0", VA = "0x187A3CAE0", Slot = "4")]
		get
		{
			return default(JKPLFEIEHFJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x7A3CB50", Offset = "0x7A3BF50", VA = "0x187A3CB50", Slot = "5")]
	public void ODNEDHINBAC(DFBKNGEEMFG MHALMOGKEGG, EHGNEHOIKIN NGGBILHBMJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x9B8350", Offset = "0x9B7750", VA = "0x1809B8350")]
	public PNFAMFNHOID()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
internal class MDLOLEJHMIP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private readonly CLCGHFJECND GBMGHNECBBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	private readonly EHGNEHOIKIN NGGBILHBMJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	private readonly Action<DKMOJHDHHGO> HPNDHJABOPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private readonly HashSet<NKNCEMHCPHH> KKJBIIFACPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private readonly Dictionary<NKNCEMHCPHH, List<DKMOJHDHHGO>> BNPMIFNPCAC;

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x7A3ADF0", Offset = "0x7A3A1F0", VA = "0x187A3ADF0")]
	public MDLOLEJHMIP(CLCGHFJECND GBMGHNECBBK, EHGNEHOIKIN NGGBILHBMJK, Action<DKMOJHDHHGO> HPNDHJABOPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x7A3A3C0", Offset = "0x7A397C0", VA = "0x187A3A3C0")]
	public void HBKCKLMJMOB(NativeList<DKMOJHDHHGO> LCOBAMHGLHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x7A3AC50", Offset = "0x7A3A050", VA = "0x187A3AC50")]
	private void LMFPMKPHCBJ(NKNCEMHCPHH EOGFPKLNIAM, DKMOJHDHHGO FEJOFABKKKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x7A3A360", Offset = "0x7A39760", VA = "0x187A3A360")]
	public void FOKNHOLJKKO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x7A3A730", Offset = "0x7A39B30", VA = "0x187A3A730")]
	private void HEOHGAJGHGJ(NKNCEMHCPHH EOGFPKLNIAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x7A3ABB0", Offset = "0x7A39FB0", VA = "0x187A3ABB0")]
	private void HOCIOIOCMOP(NKNCEMHCPHH EOGFPKLNIAM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
internal class OCHILMJGGBE : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	[CompilerGenerated]
	private sealed class OFDAKKMDAAM : IEnumerable<JKPLFEIEHFJ>, IEnumerable, IEnumerator<JKPLFEIEHFJ>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private JKPLFEIEHFJ <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		public OCHILMJGGBE <>4__this;

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
		private JKPLFEIEHFJ System.Collections.Generic.IEnumerator<RecRoom.DataLayer.NetworkProperty>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0xAE6870", Offset = "0xAE5C70", VA = "0x180AE6870", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default(JKPLFEIEHFJ);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600008A")]
			[Cpp2IlInjected.Address(RVA = "0x7A3C050", Offset = "0x7A3B450", VA = "0x187A3C050", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x11951D0", Offset = "0x11945D0", VA = "0x1811951D0")]
		[DebuggerHidden]
		public OFDAKKMDAAM(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x7A3C0A0", Offset = "0x7A3B4A0", VA = "0x187A3C0A0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x7A3BC90", Offset = "0x7A3B090", VA = "0x187A3BC90", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x7A3BEF0", Offset = "0x7A3B2F0", VA = "0x187A3BEF0")]
		private void OMCGPHJKBHJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x7A3C000", Offset = "0x7A3B400", VA = "0x187A3C000", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x7A3BF40", Offset = "0x7A3B340", VA = "0x187A3BF40", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<JKPLFEIEHFJ> System.Collections.Generic.IEnumerable<RecRoom.DataLayer.NetworkProperty>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x7A3BF40", Offset = "0x7A3B340", VA = "0x187A3BF40", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private static readonly GBHBOJAPDOA DPDKJPMBJOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private NativeParallelMultiHashMap<long, int> BNAMMMMKNLL;

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x7A3BAA0", Offset = "0x7A3AEA0", VA = "0x187A3BAA0")]
	public OCHILMJGGBE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x7A3B980", Offset = "0x7A3AD80", VA = "0x187A3B980")]
	[IteratorStateMachine(typeof(OFDAKKMDAAM))]
	public IEnumerable<JKPLFEIEHFJ> JOFEHNDNIEF(Type HAFNBBNOLPO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x7A3B940", Offset = "0x7A3AD40", VA = "0x187A3B940", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x7A3B880", Offset = "0x7A3AC80", VA = "0x187A3B880")]
	private long BAKMEAEJNKH(JKPLFEIEHFJ MHALMOGKEGG)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x7A3B900", Offset = "0x7A3AD00", VA = "0x187A3B900")]
	private long BAKMEAEJNKH(Type HAFNBBNOLPO)
	{
		return default(long);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
internal struct CCNLBLNINOJ : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private NativeBitArray CHNBFCLGPCP;

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x7A35F20", Offset = "0x7A35320", VA = "0x187A35F20")]
	public CCNLBLNINOJ(int ECKHNAPCKGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x7A35DA0", Offset = "0x7A351A0", VA = "0x187A35DA0")]
	public static CCNLBLNINOJ OGFGNNAHDPF(int HDAIOJEADNO, NativeArray<JKPLFEIEHFJ> GOEHJDBLOMA)
	{
		return default(CCNLBLNINOJ);
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x7A35D80", Offset = "0x7A35180", VA = "0x187A35D80")]
	public bool FMNNGLHMEMF(int CJFNAFNJJLB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x7A35D90", Offset = "0x7A35190", VA = "0x187A35D90")]
	public void JFGGMENNDNP(int CJFNAFNJJLB, bool FFOEEMKIKJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x7A35C10", Offset = "0x7A35010", VA = "0x187A35C10")]
	public bool BNKNLEKIIAJ(JKPLFEIEHFJ[] GOEHJDBLOMA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x7A35CD0", Offset = "0x7A350D0", VA = "0x187A35CD0")]
	public bool FLKJNJEHKOH(JKPLFEIEHFJ[] GOEHJDBLOMA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x7A35CC0", Offset = "0x7A350C0", VA = "0x187A35CC0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
internal class JLBJGANECKP
{
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private static readonly GBHBOJAPDOA DPDKJPMBJOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private readonly CLCGHFJECND GBMGHNECBBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private readonly List<DGDOIANFDLG> DHLOEMBOJMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private readonly OCHILMJGGBE BNAMMMMKNLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private NativeParallelMultiHashMap<int, int> HGEAHJODBFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private NativeList<int> FLBGKLBLDPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private bool EKDCONIHOMM;

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public List<DGDOIANFDLG> ACNNODGKFLG
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x9A91C0", Offset = "0x9A85C0", VA = "0x1809A91C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x7A396D0", Offset = "0x7A38AD0", VA = "0x187A396D0")]
	public JLBJGANECKP(CLCGHFJECND GBMGHNECBBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x7A38E40", Offset = "0x7A38240", VA = "0x187A38E40")]
	public void LIPICMLEJBD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x7A38690", Offset = "0x7A37A90", VA = "0x187A38690")]
	public void CPLDDEEKPIM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x7A38880", Offset = "0x7A37C80", VA = "0x187A38880")]
	public NativeList<DKMOJHDHHGO> HGLFFKLPJCK(NativeArray<JKPLFEIEHFJ> GOEHJDBLOMA)
	{
		return default(NativeList<DKMOJHDHHGO>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x7A38D70", Offset = "0x7A38170", VA = "0x187A38D70")]
	private bool IJKHMBFLJAP(DGDOIANFDLG EKLHFMGDBHE, CCNLBLNINOJ DJBJJIPKEIP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x3690D60", Offset = "0x3690160", VA = "0x183690D60")]
	private void CNPJDHHFBHF<TInterface, TAttribute>(Action<TInterface, TAttribute> KOCACIHGDOH) where TInterface : DGDOIANFDLG where TAttribute : Attribute
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x7A38850", Offset = "0x7A37C50", VA = "0x187A38850")]
	private void HGHHMHACNHN(Type HAFNBBNOLPO, Type OBINHALEKLO, Type BCNCKDHCJJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x3690FC0", Offset = "0x36903C0", VA = "0x183690FC0")]
	private TInterface HLBEOFLNGNG<TInterface>(Type HAFNBBNOLPO)
	{
		return (TInterface)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x7A39030", Offset = "0x7A38430", VA = "0x187A39030")]
	private int MMAEGMJKOOH(DGDOIANFDLG DNJCOFHCCGA, int PKKOAIHLPOK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x7A393D0", Offset = "0x7A387D0", VA = "0x187A393D0")]
	private void OMDIIOGDNCE(GOLJIKAADON EKLHFMGDBHE, IDHBNIODMOE DBMFBCDFODK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x7A390D0", Offset = "0x7A384D0", VA = "0x187A390D0")]
	private void NJGCNFNJFJF(OFLBHPLMPGN EKLHFMGDBHE, JDEGNJJOFAG DBMFBCDFODK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x7A38F20", Offset = "0x7A38320", VA = "0x187A38F20")]
	private void MAKKNCDDHOK(KFKFEIJPPCA EKLHFMGDBHE, PCGOJLGKPCM DBMFBCDFODK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x7A385C0", Offset = "0x7A379C0", VA = "0x187A385C0")]
	private void CBBMNHMBLJI(IAJDKNEGCPJ EKLHFMGDBHE, JEFEHLFACFL DBMFBCDFODK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
internal struct JOIPEFGKLPA : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private readonly List<DGDOIANFDLG> DHLOEMBOJMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private NativeList<DKMOJHDHHGO> FBGOONNMKLL;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public NativeList<DKMOJHDHHGO> CHDAKOMCHNE
	{
		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x2CBCB60", Offset = "0x2CBBF60", VA = "0x182CBCB60")]
		get
		{
			return default(NativeList<DKMOJHDHHGO>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x7A39DD0", Offset = "0x7A391D0", VA = "0x187A39DD0")]
	public JOIPEFGKLPA(List<DGDOIANFDLG> DHLOEMBOJMG, NativeArray<DKMOJHDHHGO> LCOBAMHGLHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x7A39970", Offset = "0x7A38D70", VA = "0x187A39970", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x7A399B0", Offset = "0x7A38DB0", VA = "0x187A399B0")]
	private NativeList<DKMOJHDHHGO> IGGKAEKHKBA(NativeArray<DKMOJHDHHGO> DKHDHGKIGDJ)
	{
		return default(NativeList<DKMOJHDHHGO>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x7A39CE0", Offset = "0x7A390E0", VA = "0x187A39CE0")]
	private bool LOIIPOCGIKG(DGDOIANFDLG EKLHFMGDBHE, CCNLBLNINOJ CBFNEMHNDIL, JKPLFEIEHFJ MHALMOGKEGG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x7A39830", Offset = "0x7A38C30", VA = "0x187A39830")]
	private void COIKDOINPIF(DGDOIANFDLG EKLHFMGDBHE, CCNLBLNINOJ CHNBFCLGPCP, JKPLFEIEHFJ OKCPOBBGJLC)
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000029")]
internal struct DEHFDAPBKCG : IComparer<DKMOJHDHHGO>
{
	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x7A36460", Offset = "0x7A35860", VA = "0x187A36460", Slot = "4")]
	public int Compare(DKMOJHDHHGO PCMHLCLONGN, DKMOJHDHHGO IAJJOLNCJOI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x7A36470", Offset = "0x7A35870", VA = "0x187A36470")]
	public static void JCPPPPGBPGP(NativeList<DKMOJHDHHGO> LCOBAMHGLHB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
[AttributeUsage(AttributeTargets.Class)]
public class JEFEHLFACFL : DNCCFOHIHKE
{
	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x7A385B0", Offset = "0x7A379B0", VA = "0x187A385B0")]
	public JEFEHLFACFL(int KCOBLCMJBKO = 1)
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
