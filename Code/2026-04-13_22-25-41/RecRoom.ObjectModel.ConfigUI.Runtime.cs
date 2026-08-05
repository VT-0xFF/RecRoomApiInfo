using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using RecRoom.DataLayer;
using RecRoom.DataLayer.Attributes;
using RecRoom.DataLayer.Registration;
using RecRoom.Foundation.Collections;
using RecRoom.Foundation.Service;
using RecRoom.Logging;
using RecRoom.Logging.Attributes;
using Unity.Collections;
using Unity.Mathematics;

[assembly: AssemblyVersion("0.0.0.0")]
namespace _LogRegistration.RecRoom_ObjectModel_ConfigUI_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[Obfuscation(ApplyToMembers = false)]
	[RecRoom.Logging.Attributes.Preserve]
	public class LogRegistrationIndex : RecRoom.Logging.LogRegistrationIndex
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x9A07680", Offset = "0x9A06080", VA = "0x189A07680", Slot = "4")]
		public override void SIFQFAPRLAF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xD18E40", Offset = "0xD17840", VA = "0x180D18E40")]
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
	[Obfuscation(ApplyToMembers = false)]
	public class _AssemblyIndex : AssemblyIndex
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private int[] FEHXVDYRGKU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private ServiceBitset GXKYIJVMEXV;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public override string[] ServiceCategories
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0xCF4350", Offset = "0xCF2D50", VA = "0x180CF4350", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x9A0D270", Offset = "0x9A0BC70", VA = "0x189A0D270", Slot = "5")]
		public override void SetServiceCategoryIndices(List<int> globalFromLocalIndices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x9A0C8E0", Offset = "0x9A0B2E0", VA = "0x189A0C8E0")]
		private void GVEYSKBSPJB(IServiceRegistration a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x9A0CB00", Offset = "0x9A0B500", VA = "0x189A0CB00", Slot = "6")]
		public override void RegisterServices(IServiceRegistration registry, [In] ServiceBitsetFilter filter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x9A0CB60", Offset = "0x9A0B560", VA = "0x189A0CB60", Slot = "7")]
		public override void RegisterTypes(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x9A0D290", Offset = "0x9A0BC90", VA = "0x189A0D290")]
		public _AssemblyIndex()
		{
		}
	}
}
namespace RecRoom.ObjectModel.ConfigUI
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	internal abstract class FMEBWTLAPCP : FLKMENPKIZB<Enum>, FUGCORJLEGM, GWBYPVMBYQL, TXRZSTPMAZR
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "7")]
		public abstract bool HEHUHCHHXSN(Type a);

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x9A04EE0", Offset = "0x9A038E0", VA = "0x189A04EE0")]
		protected FMEBWTLAPCP()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	internal abstract class FLKMENPKIZB<a> : GWBYPVMBYQL, TXRZSTPMAZR where a : Enum
	{
		[Cpp2IlInjected.Token(Token = "0x2000006")]
		[CompilerGenerated]
		private sealed class HGOHUZHWDLD
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000004")]
			public MZEXCYTGDUA EBMOYTMLXND;

			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF4E50", VA = "0x180CF6450")]
			public HGOHUZHWDLD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x64797F0", Offset = "0x64781F0", VA = "0x1864797F0")]
			internal bool GPDPFRSHUUU()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x6288D70", Offset = "0x6287770", VA = "0x186288D70")]
		protected FLKMENPKIZB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x6288580", Offset = "0x6286F80", VA = "0x186288580")]
		protected void FWSEKVAZIEK(WVPUCKMDXCR a, MZEXCYTGDUA b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x6288B70", Offset = "0x6287570", VA = "0x186288B70")]
		protected void MGEJWEGYDSQ(RPPGFKESHGW<a> a, MZEXCYTGDUA b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "5")]
		public abstract void ZNMWNVUQKVU(MZEXCYTGDUA a, UYLYJABWQJU b);
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	internal abstract class TJDEBICCSAI : SXAYRTSQJMM, TXRZSTPMAZR
	{
		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public abstract NetworkProperty[] NYGDHSDPIJJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(Slot = "7")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public abstract NetworkProperty[] NLJCDRULUUK
		{
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(Slot = "8")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(Slot = "9")]
		public abstract void ZNMWNVUQKVU(MZEXCYTGDUA a, HVXZROXIITZ b, LISNGJFWSIP c, UYLYJABWQJU d);

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x3F50D10", Offset = "0x3F4F710", VA = "0x183F50D10")]
		protected static b FARHZPDKCWO<b>(NativeObjectLocalIdArray a, NetworkProperty<b> b) where b : struct
		{
			return (b)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x3F50B20", Offset = "0x3F4F520", VA = "0x183F50B20")]
		protected static void BQFKJGOILXB<d>(NativeObjectLocalIdArray a, NetworkProperty<d> b, d c) where d : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF4E50", VA = "0x180CF6450")]
		protected TJDEBICCSAI()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	internal abstract class AMPRZBIONHE<a> : GWBYPVMBYQL, TXRZSTPMAZR where a : struct
	{
		[Cpp2IlInjected.Token(Token = "0x2000009")]
		[CompilerGenerated]
		private sealed class HGOHUZHWDLD
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000005")]
			public MZEXCYTGDUA EBMOYTMLXND;

			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF4E50", VA = "0x180CF6450")]
			public HGOHUZHWDLD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x64799D0", Offset = "0x64783D0", VA = "0x1864799D0")]
			internal bool GPDPFRSHUUU()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x6288D70", Offset = "0x6287770", VA = "0x186288D70")]
		protected AMPRZBIONHE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x71C4640", Offset = "0x71C3040", VA = "0x1871C4640")]
		protected void FWSEKVAZIEK(WVPUCKMDXCR a, MZEXCYTGDUA b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x71C59D0", Offset = "0x71C43D0", VA = "0x1871C59D0")]
		protected void MGEJWEGYDSQ(RPPGFKESHGW<a> a, MZEXCYTGDUA b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(Slot = "5")]
		public abstract void ZNMWNVUQKVU(MZEXCYTGDUA a, UYLYJABWQJU b);
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[RegisterService(typeof(HVXZROXIITZ), new string[] { })]
	internal class ConfigUIService : HVXZROXIITZ, BSBPOUIRCFB, EQFYRFRSSPD, CJJGAWHPXAL, KXJYMNDEBYH
	{
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private static readonly Log KZEIFDHBWKO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		[DependsOn]
		private LISNGJFWSIP BNABZGXHQVU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		[DependsOn]
		private UYLYJABWQJU FYSYUMNWDZQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private PropertyDrawerCandidates FEPYOLHNGVJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private NativeObjectLocalIdArray CKBZDWOOYOS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private List<MZEXCYTGDUA> SZLHRDISAAV;

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public NativeObjectLocalIdArray FRROUIGHYTI
		{
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x17162D0", Offset = "0x1714CD0", VA = "0x1817162D0", Slot = "5")]
			get
			{
				return default(NativeObjectLocalIdArray);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x9A05390", Offset = "0x9A03D90", VA = "0x189A05390", Slot = "6")]
		public void InitExternal(PPCVAYWFABF services)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x9A05290", Offset = "0x9A03C90", VA = "0x189A05290", Slot = "7")]
		public void AALNHOBOWYP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x9A05980", Offset = "0x9A04380", VA = "0x189A05980", Slot = "4")]
		public void YDKNOKRPSNS(NativeObjectLocalIdArray a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x9A056B0", Offset = "0x9A040B0", VA = "0x189A056B0")]
		private void LWSDGGKWOEO(NativeObjectLocalIdArray a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x9A05790", Offset = "0x9A04190", VA = "0x189A05790")]
		private void OVNPJGLCFXL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x9A05DF0", Offset = "0x9A047F0", VA = "0x189A05DF0")]
		private void ZNMWNVUQKVU(Candidate a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x9A05720", Offset = "0x9A04120", VA = "0x189A05720", Slot = "8")]
		private void MMZJSGUTRHN(PPCVAYWFABF a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x102F010", Offset = "0x102DA10", VA = "0x18102F010", Slot = "9")]
		private void IKBYUUMLEVN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x9A061B0", Offset = "0x9A04BB0", VA = "0x189A061B0")]
		public ConfigUIService()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[MatchPropertyDrawer(0)]
	internal class BTYRJPGJPMZ : FMEBWTLAPCP
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x9A04E30", Offset = "0x9A03830", VA = "0x189A04E30", Slot = "5")]
		public override void ZNMWNVUQKVU(MZEXCYTGDUA a, UYLYJABWQJU b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x9A04D90", Offset = "0x9A03790", VA = "0x189A04D90", Slot = "7")]
		public override bool HEHUHCHHXSN(Type a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x9A04EE0", Offset = "0x9A038E0", VA = "0x189A04EE0")]
		public BTYRJPGJPMZ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[MatchPropertyDrawer(0)]
	internal class IXYDFSSFCXM : FMEBWTLAPCP
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x9A070D0", Offset = "0x9A05AD0", VA = "0x189A070D0", Slot = "5")]
		public override void ZNMWNVUQKVU(MZEXCYTGDUA a, UYLYJABWQJU b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x9A07030", Offset = "0x9A05A30", VA = "0x189A07030", Slot = "7")]
		public override bool HEHUHCHHXSN(Type a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x9A04EE0", Offset = "0x9A038E0", VA = "0x189A04EE0")]
		public IXYDFSSFCXM()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[ConfigPropertyDrawer(typeof(RenderableColor), 1)]
	internal class UZKCVKWSHOH : FLKMENPKIZB<RenderableColor>
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x9A0C070", Offset = "0x9A0AA70", VA = "0x189A0C070", Slot = "5")]
		public override void ZNMWNVUQKVU(MZEXCYTGDUA a, UYLYJABWQJU b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x9A0C1C0", Offset = "0x9A0ABC0", VA = "0x189A0C1C0")]
		public UZKCVKWSHOH()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[MultiPropertyDrawer(2)]
	internal class MZOPOQEYRLJ : TJDEBICCSAI
	{
		[Cpp2IlInjected.Token(Token = "0x200000F")]
		[CompilerGenerated]
		private sealed class MDJIIFNDRCE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400000E")]
			public HVXZROXIITZ HEAYVYEXADF;

			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF4E50", VA = "0x180CF6450")]
			public MDJIIFNDRCE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x9A082B0", Offset = "0x9A06CB0", VA = "0x189A082B0")]
			internal (int, int) DSPGIDOBCYY()
			{
				return default((int, int));
			}

			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x9A08520", Offset = "0x9A06F20", VA = "0x189A08520")]
			internal void DSUNFKHYMKH((int color, int material) value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public override NetworkProperty[] NYGDHSDPIJJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0xCF4310", Offset = "0xCF2D10", VA = "0x180CF4310", Slot = "7")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public override NetworkProperty[] NLJCDRULUUK
		{
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0xCF1D40", Offset = "0xCF0740", VA = "0x180CF1D40", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x9A08670", Offset = "0x9A07070", VA = "0x189A08670", Slot = "9")]
		public override void ZNMWNVUQKVU(MZEXCYTGDUA a, HVXZROXIITZ b, LISNGJFWSIP c, UYLYJABWQJU d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x9A08A20", Offset = "0x9A07420", VA = "0x189A08A20")]
		public MZOPOQEYRLJ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[ConfigPropertyDrawer(typeof(bool))]
	internal class TYFEOAWRAXO : AMPRZBIONHE<bool>
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x9A0B410", Offset = "0x9A09E10", VA = "0x189A0B410", Slot = "5")]
		public override void ZNMWNVUQKVU(MZEXCYTGDUA a, UYLYJABWQJU b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x9A0B4A0", Offset = "0x9A09EA0", VA = "0x189A0B4A0")]
		public TYFEOAWRAXO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[ConfigPropertyDrawer(typeof(FixedString32Bytes))]
	internal class DMKBCHNMKZI : AMPRZBIONHE<FixedString32Bytes>
	{
		[Cpp2IlInjected.Token(Token = "0x2000012")]
		[CompilerGenerated]
		private sealed class UBYOUQYNJZM
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400000F")]
			public MZEXCYTGDUA EBMOYTMLXND;

			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF4E50", VA = "0x180CF6450")]
			public UBYOUQYNJZM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x9A0B800", Offset = "0x9A0A200", VA = "0x189A0B800")]
			internal string DSPGIDOBCYY()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x9A0B950", Offset = "0x9A0A350", VA = "0x189A0B950")]
			internal void DSUNFKHYMKH(string a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x9A066D0", Offset = "0x9A050D0", VA = "0x189A066D0", Slot = "5")]
		public override void ZNMWNVUQKVU(MZEXCYTGDUA a, UYLYJABWQJU b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x9A06860", Offset = "0x9A05260", VA = "0x189A06860")]
		public DMKBCHNMKZI()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[ConfigPropertyDrawer(typeof(FixedString64Bytes))]
	internal class YDSOMPYSRNT : AMPRZBIONHE<FixedString64Bytes>
	{
		[Cpp2IlInjected.Token(Token = "0x2000014")]
		[CompilerGenerated]
		private sealed class UBYOUQYNJZM
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000010")]
			public MZEXCYTGDUA EBMOYTMLXND;

			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF4E50", VA = "0x180CF6450")]
			public UBYOUQYNJZM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x9A0B860", Offset = "0x9A0A260", VA = "0x189A0B860")]
			internal string DSPGIDOBCYY()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x9A0B9C0", Offset = "0x9A0A3C0", VA = "0x189A0B9C0")]
			internal void DSUNFKHYMKH(string a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x9A0C2D0", Offset = "0x9A0ACD0", VA = "0x189A0C2D0", Slot = "5")]
		public override void ZNMWNVUQKVU(MZEXCYTGDUA a, UYLYJABWQJU b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x9A0C460", Offset = "0x9A0AE60", VA = "0x189A0C460")]
		public YDSOMPYSRNT()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	[ConfigPropertyDrawer(typeof(float3))]
	internal class KWSGKRACOYT : AMPRZBIONHE<float3>
	{
		[Cpp2IlInjected.Token(Token = "0x2000016")]
		[CompilerGenerated]
		private sealed class UBYOUQYNJZM
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000011")]
			public MZEXCYTGDUA EBMOYTMLXND;

			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF4E50", VA = "0x180CF6450")]
			public UBYOUQYNJZM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x9A0B750", Offset = "0x9A0A150", VA = "0x189A0B750")]
			internal float DSPGIDOBCYY()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x9A0B930", Offset = "0x9A0A330", VA = "0x189A0B930")]
			internal void DSUNFKHYMKH(float a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x9A0BA50", Offset = "0x9A0A450", VA = "0x189A0BA50")]
			internal float DSZUCRBVVVQ()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x9A0BAD0", Offset = "0x9A0A4D0", VA = "0x189A0BAD0")]
			internal void DTFAZXVTFGZ(float a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x9A0BB00", Offset = "0x9A0A500", VA = "0x189A0BB00")]
			internal float DTKHXEPQOSI()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x9A0BB70", Offset = "0x9A0A570", VA = "0x189A0BB70")]
			internal void DTPOULJNYDR(float a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x9A0BDD0", Offset = "0x9A0A7D0", VA = "0x189A0BDD0")]
			internal float MVPGJFGNCPN(int a)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x9A0BB90", Offset = "0x9A0A590", VA = "0x189A0BB90")]
			internal void JJOEZQHJXKE(int a, float b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x9A07180", Offset = "0x9A05B80", VA = "0x189A07180", Slot = "5")]
		public override void ZNMWNVUQKVU(MZEXCYTGDUA a, UYLYJABWQJU b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x9A07580", Offset = "0x9A05F80", VA = "0x189A07580")]
		public KWSGKRACOYT()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[ConfigPropertyDrawer(typeof(float))]
	internal class NZVNUBAQCXA : AMPRZBIONHE<float>
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x9A08B50", Offset = "0x9A07550", VA = "0x189A08B50", Slot = "5")]
		public override void ZNMWNVUQKVU(MZEXCYTGDUA a, UYLYJABWQJU b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x9A08BE0", Offset = "0x9A075E0", VA = "0x189A08BE0")]
		public NZVNUBAQCXA()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[ConfigPropertyDrawer(typeof(int))]
	internal class XRMNCCKBKAJ : AMPRZBIONHE<int>
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x9A0C200", Offset = "0x9A0AC00", VA = "0x189A0C200", Slot = "5")]
		public override void ZNMWNVUQKVU(MZEXCYTGDUA a, UYLYJABWQJU b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x9A0C290", Offset = "0x9A0AC90", VA = "0x189A0C290")]
		public XRMNCCKBKAJ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	[ConfigPropertyDrawer(typeof(quaternion))]
	internal class ZOJXVPALEWQ : AMPRZBIONHE<quaternion>
	{
		[Cpp2IlInjected.Token(Token = "0x200001A")]
		[CompilerGenerated]
		private sealed class UBYOUQYNJZM
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000012")]
			public MZEXCYTGDUA EBMOYTMLXND;

			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF4E50", VA = "0x180CF6450")]
			public UBYOUQYNJZM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x9A0B740", Offset = "0x9A0A140", VA = "0x189A0B740")]
			internal float DSPGIDOBCYY()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x9A0B940", Offset = "0x9A0A340", VA = "0x189A0B940")]
			internal void DSUNFKHYMKH(float a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x9A0BAC0", Offset = "0x9A0A4C0", VA = "0x189A0BAC0")]
			internal float DSZUCRBVVVQ()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x9A0BAE0", Offset = "0x9A0A4E0", VA = "0x189A0BAE0")]
			internal void DTFAZXVTFGZ(float a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x9A0BAF0", Offset = "0x9A0A4F0", VA = "0x189A0BAF0")]
			internal float DTKHXEPQOSI()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x9A0BB80", Offset = "0x9A0A580", VA = "0x189A0BB80")]
			internal void DTPOULJNYDR(float a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x9A0BC70", Offset = "0x9A0A670", VA = "0x189A0BC70")]
			internal float KNWHAFZGLGA(int a)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x9A0B4E0", Offset = "0x9A09EE0", VA = "0x189A0B4E0")]
			internal void BPBZVYQJUST(int a, float b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x9A0C4A0", Offset = "0x9A0AEA0", VA = "0x189A0C4A0", Slot = "5")]
		public override void ZNMWNVUQKVU(MZEXCYTGDUA a, UYLYJABWQJU b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x9A0C8A0", Offset = "0x9A0B2A0", VA = "0x189A0C8A0")]
		public ZOJXVPALEWQ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[ConfigPropertyDrawer(typeof(uint))]
	internal class TEUXWFZGWVS : AMPRZBIONHE<uint>
	{
		[Cpp2IlInjected.Token(Token = "0x200001C")]
		[CompilerGenerated]
		private sealed class UBYOUQYNJZM
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000013")]
			public MZEXCYTGDUA EBMOYTMLXND;

			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF4E50", VA = "0x180CF6450")]
			public UBYOUQYNJZM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x9A0B7C0", Offset = "0x9A0A1C0", VA = "0x189A0B7C0")]
			internal int DSPGIDOBCYY()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x9A0B8E0", Offset = "0x9A0A2E0", VA = "0x189A0B8E0")]
			internal void DSUNFKHYMKH(int a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x9A0B240", Offset = "0x9A09C40", VA = "0x189A0B240", Slot = "5")]
		public override void ZNMWNVUQKVU(MZEXCYTGDUA a, UYLYJABWQJU b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x9A0B3D0", Offset = "0x9A09DD0", VA = "0x189A0B3D0")]
		public TEUXWFZGWVS()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	internal struct Candidate
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public int drawerIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public NetworkProperty property;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public int priority;
	}
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	internal static class LXWTSPTJJTH
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x9A075C0", Offset = "0x9A05FC0", VA = "0x189A075C0")]
		public static void CYAXJOSSCEP(Type a, Type b)
		{
		}
	}
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	internal struct CommonProperties
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x9A04F20", Offset = "0x9A03920", VA = "0x189A04F20")]
		public static NativeList<NetworkProperty> CKKBOWJUVDM(NativeObjectLocalIdArray a, LISNGJFWSIP b)
		{
			return default(NativeList<NetworkProperty>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x9A051A0", Offset = "0x9A03BA0", VA = "0x189A051A0")]
		private static bool JTMOXUNQJYP(NetworkProperty a, NativeObjectLocalIdArray b)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public class EGUYAMYPMAT : MZEXCYTGDUA, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private readonly NetworkProperty EBMOYTMLXND;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private readonly LISNGJFWSIP KGCDZOBLHRV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private readonly NativeObjectLocalIdArray CKBZDWOOYOS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private bool IXEHIPWMHET;

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public string AZGBUIWNJKT
		{
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x9A06CB0", Offset = "0x9A056B0", VA = "0x189A06CB0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public bool CXRGWAGXVPP
		{
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x9A06A60", Offset = "0x9A05460", VA = "0x189A06A60", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public RRObject OGMCZHCYKWJ
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x9A06AE0", Offset = "0x9A054E0", VA = "0x189A06AE0", Slot = "8")]
			get
			{
				return default(RRObject);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public Type XYUHIEMAMOM
		{
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x9A06970", Offset = "0x9A05370", VA = "0x189A06970", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action AWRUUXEIWDO
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x9A06C10", Offset = "0x9A05610", VA = "0x189A06C10", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x9A069C0", Offset = "0x9A053C0", VA = "0x189A069C0", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x9A06F40", Offset = "0x9A05940", VA = "0x189A06F40")]
		public EGUYAMYPMAT(NativeObjectLocalIdArray a, NetworkProperty b, LISNGJFWSIP c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x9A06D10", Offset = "0x9A05710", VA = "0x189A06D10")]
		private void NIPBRXYIECT(BulkPropertyChangeData a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x9A06B30", Offset = "0x9A05530", VA = "0x189A06B30", Slot = "10")]
		public void Get(MutableRef value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x9A06E20", Offset = "0x9A05820", VA = "0x189A06E20", Slot = "11")]
		public void Set(ReadOnlyRef value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x9A068A0", Offset = "0x9A052A0", VA = "0x189A068A0", Slot = "12")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[SpecificPropertyDrawer(1)]
	internal sealed class DIGVRCDEBBS : YYETYGZKQLR, GWBYPVMBYQL, TXRZSTPMAZR
	{
		[Cpp2IlInjected.Token(Token = "0x2000022")]
		[CompilerGenerated]
		private sealed class UFMXOEVUXJC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			public MZEXCYTGDUA EBMOYTMLXND;

			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF4E50", VA = "0x180CF6450")]
			public UFMXOEVUXJC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0x9A0BE40", Offset = "0x9A0A840", VA = "0x189A0BE40")]
			internal bool DSPGIDOBCYY()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0x9A0BE90", Offset = "0x9A0A890", VA = "0x189A0BE90")]
			internal string DSUNFKHYMKH()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0x9A0BF10", Offset = "0x9A0A910", VA = "0x189A0BF10")]
			internal void DSZUCRBVVVQ(string a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0x9A0BFA0", Offset = "0x9A0A9A0", VA = "0x189A0BFA0")]
			internal string DTFAZXVTFGZ()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public NetworkProperty IFWWVKYBDVT
		{
			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x9A06230", Offset = "0x9A04C30", VA = "0x189A06230", Slot = "4")]
			get
			{
				return default(NetworkProperty);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x9A062A0", Offset = "0x9A04CA0", VA = "0x189A062A0", Slot = "5")]
		public void ZNMWNVUQKVU(MZEXCYTGDUA a, UYLYJABWQJU b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF4E50", VA = "0x180CF6450")]
		public DIGVRCDEBBS()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	internal class MBVOASLYIEI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private readonly LISNGJFWSIP BNABZGXHQVU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private readonly UYLYJABWQJU DZWFDPTHBLI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private readonly Action<Candidate> TVFQTNRDQKF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private readonly HashSet<ZCIBIFKBEZY> JQHPRTBLJMG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private readonly Dictionary<ZCIBIFKBEZY, List<Candidate>> LADLPDGKVZS;

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x9A081A0", Offset = "0x9A06BA0", VA = "0x189A081A0")]
		public MBVOASLYIEI(LISNGJFWSIP a, UYLYJABWQJU b, Action<Candidate> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x9A07E00", Offset = "0x9A06800", VA = "0x189A07E00")]
		public void UIANMRNCADC(NativeList<Candidate> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x9A07C90", Offset = "0x9A06690", VA = "0x189A07C90")]
		private void PQGKNQROPII(ZCIBIFKBEZY a, Candidate b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x9A08140", Offset = "0x9A06B40", VA = "0x189A08140")]
		public void VTDECWMGXQY()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x9A07820", Offset = "0x9A06220", VA = "0x189A07820")]
		private void BVMDWARVUOA(ZCIBIFKBEZY a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x9A07780", Offset = "0x9A06180", VA = "0x189A07780")]
		private void BAVPYJHOJMH(ZCIBIFKBEZY a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	internal class PropertiesByType : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x2000025")]
		[CompilerGenerated]
		private sealed class OVPEPPQLCJP : IEnumerable<NetworkProperty>, IEnumerable, IEnumerator<NetworkProperty>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000024")]
			private int NSYFVIOVDQI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x4000025")]
			private NetworkProperty PGYMGSMZHLZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000026")]
			private int DQGTEBFWJSV;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000027")]
			public PropertiesByType DIJXGYBMMZW;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000028")]
			private Type MGNXNPFUFWI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000029")]
			public Type QITXUGJOPOF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			private NativeParallelMultiHashMap<long, int>.Enumerator MOIGOWZIHVC;

			[Cpp2IlInjected.Token(Token = "0x1700000C")]
			private NetworkProperty HRNMOFCUXJU
			{
				[Cpp2IlInjected.Token(Token = "0x6000088")]
				[Cpp2IlInjected.Address(RVA = "0xDDD830", Offset = "0xDDC230", VA = "0x180DDD830", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return default(NetworkProperty);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000D")]
			private object RTHQPUQEOJM
			{
				[Cpp2IlInjected.Token(Token = "0x600008A")]
				[Cpp2IlInjected.Address(RVA = "0x9A08C20", Offset = "0x9A07620", VA = "0x189A08C20", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0x15B7650", Offset = "0x15B6050", VA = "0x1815B7650")]
			[DebuggerHidden]
			public OVPEPPQLCJP(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x9A09040", Offset = "0x9A07A40", VA = "0x189A09040", Slot = "7")]
			[DebuggerHidden]
			private void PEABEYBFILL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0x9A08D60", Offset = "0x9A07760", VA = "0x189A08D60", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0x9A090D0", Offset = "0x9A07AD0", VA = "0x189A090D0")]
			private void SYBUDUAVPHD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0x9A08D20", Offset = "0x9A07720", VA = "0x189A08D20", Slot = "10")]
			[DebuggerHidden]
			private void KTHCATTUQZC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008B")]
			[Cpp2IlInjected.Address(RVA = "0x9A08C70", Offset = "0x9A07670", VA = "0x189A08C70", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<NetworkProperty> WROTJYBXICV()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x9A08C70", Offset = "0x9A07670", VA = "0x189A08C70", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator IEVKUCCAWWZ()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private static readonly Log KZEIFDHBWKO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private NativeParallelMultiHashMap<long, int> YVWIBNZOVAI;

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x9A09340", Offset = "0x9A07D40", VA = "0x189A09340")]
		public PropertiesByType()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x9A09120", Offset = "0x9A07B20", VA = "0x189A09120")]
		[IteratorStateMachine(typeof(OVPEPPQLCJP))]
		public IEnumerable<NetworkProperty> DWOYVIJVTQI(Type a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x9A091B0", Offset = "0x9A07BB0", VA = "0x189A091B0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x9A09230", Offset = "0x9A07C30", VA = "0x189A09230")]
		private long ZISYBYPKSTV(NetworkProperty a)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x9A091F0", Offset = "0x9A07BF0", VA = "0x189A091F0")]
		private long ZISYBYPKSTV(Type a)
		{
			return default(long);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	internal struct PropertyBitmap : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private NativeBitArray bitmap;

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x9A09850", Offset = "0x9A08250", VA = "0x189A09850")]
		public PropertyBitmap(int count)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x9A096C0", Offset = "0x9A080C0", VA = "0x189A096C0")]
		public static PropertyBitmap ZHBZLLLDLHE(int a, NativeArray<NetworkProperty> b)
		{
			return default(PropertyBitmap);
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x9A096B0", Offset = "0x9A080B0", VA = "0x189A096B0")]
		public bool WZHEHJKZUEI(int a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x9A096A0", Offset = "0x9A080A0", VA = "0x189A096A0")]
		public void Set(int index, bool value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x9A09530", Offset = "0x9A07F30", VA = "0x189A09530")]
		public bool All(NetworkProperty[] properties)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x9A095E0", Offset = "0x9A07FE0", VA = "0x189A095E0")]
		public bool Any(NetworkProperty[] properties)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x9A09690", Offset = "0x9A08090", VA = "0x189A09690", Slot = "4")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	internal class PropertyDrawerCandidates
	{
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private static readonly Log KZEIFDHBWKO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private readonly LISNGJFWSIP BNABZGXHQVU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private readonly List<TXRZSTPMAZR> WATMFAQZCJY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private readonly PropertiesByType YVWIBNZOVAI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private NativeParallelMultiHashMap<int, int> HYTUYXZEYGG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private NativeList<int> MXVAXDCPVTS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private bool IXEHIPWMHET;

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public List<TXRZSTPMAZR> UMRSOOPCPVU
		{
			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(RVA = "0xCF1D40", Offset = "0xCF0740", VA = "0x180CF1D40")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x9A0AA70", Offset = "0x9A09470", VA = "0x189A0AA70")]
		public PropertyDrawerCandidates(LISNGJFWSIP configPropertyService)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x9A09C10", Offset = "0x9A08610", VA = "0x189A09C10")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x9A0A840", Offset = "0x9A09240", VA = "0x189A0A840")]
		public void TGZVITVKGJN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x9A0A2A0", Offset = "0x9A08CA0", VA = "0x189A0A2A0")]
		public NativeList<Candidate> NHJMIKCDAHQ(NativeArray<NetworkProperty> a)
		{
			return default(NativeList<Candidate>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x9A09CF0", Offset = "0x9A086F0", VA = "0x189A09CF0")]
		private bool GVEUYYRHCNW(TXRZSTPMAZR a, PropertyBitmap b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x3E01E80", Offset = "0x3E00880", VA = "0x183E01E80")]
		private void QFKUUEPAKJL<b, a>(Action<b, a> a) where b : TXRZSTPMAZR where a : Attribute
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x9A09E40", Offset = "0x9A08840", VA = "0x189A09E40")]
		private void HYZABRTBBSF(Type a, Type b, Type c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x3E01B10", Offset = "0x3E00510", VA = "0x183E01B10")]
		private c JBRSNIREQEI<c>(Type a)
		{
			return (c)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x9A098A0", Offset = "0x9A082A0", VA = "0x189A098A0")]
		private int DDWBVLIBDKL(TXRZSTPMAZR a, int b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x9A09990", Offset = "0x9A08390", VA = "0x189A09990")]
		private void DYTJBVHIGLD(GWBYPVMBYQL a, ConfigPropertyDrawer b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x9A09F80", Offset = "0x9A08980", VA = "0x189A09F80")]
		private void JTKNAAZHYQW(FUGCORJLEGM a, MatchPropertyDrawer b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x9A09E70", Offset = "0x9A08870", VA = "0x189A09E70")]
		private void ILRIJUXCJGC(SXAYRTSQJMM a, MultiPropertyDrawer b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x9A0A770", Offset = "0x9A09170", VA = "0x189A0A770")]
		private void OIOJAUFEWKJ(YYETYGZKQLR a, SpecificPropertyDrawer b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	internal struct PropertyShadowing : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private readonly List<TXRZSTPMAZR> drawers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private NativeList<Candidate> unshadowed;

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public NativeList<Candidate> NDLCYGTPXHI
		{
			[Cpp2IlInjected.Token(Token = "0x60000A3")]
			[Cpp2IlInjected.Address(RVA = "0xF270D0", Offset = "0xF25AD0", VA = "0x180F270D0")]
			get
			{
				return default(NativeList<Candidate>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x9A0B190", Offset = "0x9A09B90", VA = "0x189A0B190")]
		public PropertyShadowing(List<TXRZSTPMAZR> drawers, NativeArray<Candidate> candidates)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x9A0ABB0", Offset = "0x9A095B0", VA = "0x189A0ABB0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x9A0ABF0", Offset = "0x9A095F0", VA = "0x189A0ABF0")]
		private NativeList<Candidate> NDCIYZWNYTG(NativeArray<Candidate> a)
		{
			return default(NativeList<Candidate>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x9A0B020", Offset = "0x9A09A20", VA = "0x189A0B020")]
		private bool YKODBTJYZGN(TXRZSTPMAZR a, PropertyBitmap b, NetworkProperty c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x9A0AEF0", Offset = "0x9A098F0", VA = "0x189A0AEF0")]
		private void NGTCCIFJNCQ(TXRZSTPMAZR a, PropertyBitmap b, NetworkProperty c)
		{
		}
	}
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	internal struct SortCandidatesByPriority : IComparer<Candidate>
	{
		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x9A0B1E0", Offset = "0x9A09BE0", VA = "0x189A0B1E0", Slot = "4")]
		public int Compare(Candidate a, Candidate b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x9A0B1F0", Offset = "0x9A09BF0", VA = "0x189A0B1F0")]
		public static void Sort(NativeList<Candidate> candidates)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	[AttributeUsage(AttributeTargets.Class)]
	public class SpecificPropertyDrawer : ConfigPropertyDrawerBase
	{
		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x9A0B230", Offset = "0x9A09C30", VA = "0x189A0B230")]
		public SpecificPropertyDrawer(int Priority = 1)
		{
		}
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
