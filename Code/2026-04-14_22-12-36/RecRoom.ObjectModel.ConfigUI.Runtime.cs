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
		[Cpp2IlInjected.Address(RVA = "0x9A09130", Offset = "0x9A07D30", VA = "0x189A09130", Slot = "4")]
		public override void SIFQFAPRLAF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xD18E40", Offset = "0xD17A40", VA = "0x180D18E40")]
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
			[Cpp2IlInjected.Address(RVA = "0xCF4350", Offset = "0xCF2F50", VA = "0x180CF4350", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x9A0ED20", Offset = "0x9A0D920", VA = "0x189A0ED20", Slot = "5")]
		public override void SetServiceCategoryIndices(List<int> globalFromLocalIndices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x9A0E390", Offset = "0x9A0CF90", VA = "0x189A0E390")]
		private void GVEYSKBSPJB(IServiceRegistration a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x9A0E5B0", Offset = "0x9A0D1B0", VA = "0x189A0E5B0", Slot = "6")]
		public override void RegisterServices(IServiceRegistration registry, [In] ServiceBitsetFilter filter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x9A0E610", Offset = "0x9A0D210", VA = "0x189A0E610", Slot = "7")]
		public override void RegisterTypes(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x9A0ED40", Offset = "0x9A0D940", VA = "0x189A0ED40")]
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
		[Cpp2IlInjected.Address(RVA = "0x9A06990", Offset = "0x9A05590", VA = "0x189A06990")]
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
			[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF5050", VA = "0x180CF6450")]
			public HGOHUZHWDLD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x647AF70", Offset = "0x6479B70", VA = "0x18647AF70")]
			internal bool GPDPFRSHUUU()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x628A4F0", Offset = "0x62890F0", VA = "0x18628A4F0")]
		protected FLKMENPKIZB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x6289D00", Offset = "0x6288900", VA = "0x186289D00")]
		protected void FWSEKVAZIEK(WVPUCKMDXCR a, MZEXCYTGDUA b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x628A2F0", Offset = "0x6288EF0", VA = "0x18628A2F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x3F52400", Offset = "0x3F51000", VA = "0x183F52400")]
		protected static b FARHZPDKCWO<b>(NativeObjectLocalIdArray a, NetworkProperty<b> b) where b : struct
		{
			return (b)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x3F52210", Offset = "0x3F50E10", VA = "0x183F52210")]
		protected static void BQFKJGOILXB<d>(NativeObjectLocalIdArray a, NetworkProperty<d> b, d c) where d : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF5050", VA = "0x180CF6450")]
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
			[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF5050", VA = "0x180CF6450")]
			public HGOHUZHWDLD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x647B150", Offset = "0x6479D50", VA = "0x18647B150")]
			internal bool GPDPFRSHUUU()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x628A4F0", Offset = "0x62890F0", VA = "0x18628A4F0")]
		protected AMPRZBIONHE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x71C5DC0", Offset = "0x71C49C0", VA = "0x1871C5DC0")]
		protected void FWSEKVAZIEK(WVPUCKMDXCR a, MZEXCYTGDUA b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x71C7150", Offset = "0x71C5D50", VA = "0x1871C7150")]
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
			[Cpp2IlInjected.Address(RVA = "0x1717B70", Offset = "0x1716770", VA = "0x181717B70", Slot = "5")]
			get
			{
				return default(NativeObjectLocalIdArray);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x9A06E40", Offset = "0x9A05A40", VA = "0x189A06E40", Slot = "6")]
		public void InitExternal(PPCVAYWFABF services)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x9A06D40", Offset = "0x9A05940", VA = "0x189A06D40", Slot = "7")]
		public void AALNHOBOWYP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x9A07430", Offset = "0x9A06030", VA = "0x189A07430", Slot = "4")]
		public void YDKNOKRPSNS(NativeObjectLocalIdArray a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x9A07160", Offset = "0x9A05D60", VA = "0x189A07160")]
		private void LWSDGGKWOEO(NativeObjectLocalIdArray a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x9A07240", Offset = "0x9A05E40", VA = "0x189A07240")]
		private void OVNPJGLCFXL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x9A078A0", Offset = "0x9A064A0", VA = "0x189A078A0")]
		private void ZNMWNVUQKVU(Candidate a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x9A071D0", Offset = "0x9A05DD0", VA = "0x189A071D0", Slot = "8")]
		private void MMZJSGUTRHN(PPCVAYWFABF a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x102F010", Offset = "0x102DC10", VA = "0x18102F010", Slot = "9")]
		private void IKBYUUMLEVN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x9A07C60", Offset = "0x9A06860", VA = "0x189A07C60")]
		public ConfigUIService()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[MatchPropertyDrawer(0)]
	internal class BTYRJPGJPMZ : FMEBWTLAPCP
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x9A068E0", Offset = "0x9A054E0", VA = "0x189A068E0", Slot = "5")]
		public override void ZNMWNVUQKVU(MZEXCYTGDUA a, UYLYJABWQJU b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x9A06840", Offset = "0x9A05440", VA = "0x189A06840", Slot = "7")]
		public override bool HEHUHCHHXSN(Type a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x9A06990", Offset = "0x9A05590", VA = "0x189A06990")]
		public BTYRJPGJPMZ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[MatchPropertyDrawer(0)]
	internal class IXYDFSSFCXM : FMEBWTLAPCP
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x9A08B80", Offset = "0x9A07780", VA = "0x189A08B80", Slot = "5")]
		public override void ZNMWNVUQKVU(MZEXCYTGDUA a, UYLYJABWQJU b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x9A08AE0", Offset = "0x9A076E0", VA = "0x189A08AE0", Slot = "7")]
		public override bool HEHUHCHHXSN(Type a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x9A06990", Offset = "0x9A05590", VA = "0x189A06990")]
		public IXYDFSSFCXM()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[ConfigPropertyDrawer(typeof(RenderableColor), 1)]
	internal class UZKCVKWSHOH : FLKMENPKIZB<RenderableColor>
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x9A0DB20", Offset = "0x9A0C720", VA = "0x189A0DB20", Slot = "5")]
		public override void ZNMWNVUQKVU(MZEXCYTGDUA a, UYLYJABWQJU b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x9A0DC70", Offset = "0x9A0C870", VA = "0x189A0DC70")]
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
			[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF5050", VA = "0x180CF6450")]
			public MDJIIFNDRCE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x9A09D60", Offset = "0x9A08960", VA = "0x189A09D60")]
			internal (int, int) DSPGIDOBCYY()
			{
				return default((int, int));
			}

			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x9A09FD0", Offset = "0x9A08BD0", VA = "0x189A09FD0")]
			internal void DSUNFKHYMKH((int color, int material) value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public override NetworkProperty[] NYGDHSDPIJJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0xCF4310", Offset = "0xCF2F10", VA = "0x180CF4310", Slot = "7")]
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
			[Cpp2IlInjected.Address(RVA = "0xCF1D40", Offset = "0xCF0940", VA = "0x180CF1D40", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x9A0A120", Offset = "0x9A08D20", VA = "0x189A0A120", Slot = "9")]
		public override void ZNMWNVUQKVU(MZEXCYTGDUA a, HVXZROXIITZ b, LISNGJFWSIP c, UYLYJABWQJU d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x9A0A4D0", Offset = "0x9A090D0", VA = "0x189A0A4D0")]
		public MZOPOQEYRLJ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[ConfigPropertyDrawer(typeof(bool))]
	internal class TYFEOAWRAXO : AMPRZBIONHE<bool>
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x9A0CEC0", Offset = "0x9A0BAC0", VA = "0x189A0CEC0", Slot = "5")]
		public override void ZNMWNVUQKVU(MZEXCYTGDUA a, UYLYJABWQJU b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x9A0CF50", Offset = "0x9A0BB50", VA = "0x189A0CF50")]
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
			[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF5050", VA = "0x180CF6450")]
			public UBYOUQYNJZM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x9A0D2B0", Offset = "0x9A0BEB0", VA = "0x189A0D2B0")]
			internal string DSPGIDOBCYY()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x9A0D400", Offset = "0x9A0C000", VA = "0x189A0D400")]
			internal void DSUNFKHYMKH(string a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x9A08180", Offset = "0x9A06D80", VA = "0x189A08180", Slot = "5")]
		public override void ZNMWNVUQKVU(MZEXCYTGDUA a, UYLYJABWQJU b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x9A08310", Offset = "0x9A06F10", VA = "0x189A08310")]
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
			[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF5050", VA = "0x180CF6450")]
			public UBYOUQYNJZM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x9A0D310", Offset = "0x9A0BF10", VA = "0x189A0D310")]
			internal string DSPGIDOBCYY()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x9A0D470", Offset = "0x9A0C070", VA = "0x189A0D470")]
			internal void DSUNFKHYMKH(string a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x9A0DD80", Offset = "0x9A0C980", VA = "0x189A0DD80", Slot = "5")]
		public override void ZNMWNVUQKVU(MZEXCYTGDUA a, UYLYJABWQJU b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x9A0DF10", Offset = "0x9A0CB10", VA = "0x189A0DF10")]
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
			[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF5050", VA = "0x180CF6450")]
			public UBYOUQYNJZM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x9A0D200", Offset = "0x9A0BE00", VA = "0x189A0D200")]
			internal float DSPGIDOBCYY()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x9A0D3E0", Offset = "0x9A0BFE0", VA = "0x189A0D3E0")]
			internal void DSUNFKHYMKH(float a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x9A0D500", Offset = "0x9A0C100", VA = "0x189A0D500")]
			internal float DSZUCRBVVVQ()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x9A0D580", Offset = "0x9A0C180", VA = "0x189A0D580")]
			internal void DTFAZXVTFGZ(float a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x9A0D5B0", Offset = "0x9A0C1B0", VA = "0x189A0D5B0")]
			internal float DTKHXEPQOSI()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x9A0D620", Offset = "0x9A0C220", VA = "0x189A0D620")]
			internal void DTPOULJNYDR(float a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x9A0D880", Offset = "0x9A0C480", VA = "0x189A0D880")]
			internal float MVPGJFGNCPN(int a)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x9A0D640", Offset = "0x9A0C240", VA = "0x189A0D640")]
			internal void JJOEZQHJXKE(int a, float b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x9A08C30", Offset = "0x9A07830", VA = "0x189A08C30", Slot = "5")]
		public override void ZNMWNVUQKVU(MZEXCYTGDUA a, UYLYJABWQJU b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x9A09030", Offset = "0x9A07C30", VA = "0x189A09030")]
		public KWSGKRACOYT()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[ConfigPropertyDrawer(typeof(float))]
	internal class NZVNUBAQCXA : AMPRZBIONHE<float>
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x9A0A600", Offset = "0x9A09200", VA = "0x189A0A600", Slot = "5")]
		public override void ZNMWNVUQKVU(MZEXCYTGDUA a, UYLYJABWQJU b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x9A0A690", Offset = "0x9A09290", VA = "0x189A0A690")]
		public NZVNUBAQCXA()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[ConfigPropertyDrawer(typeof(int))]
	internal class XRMNCCKBKAJ : AMPRZBIONHE<int>
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x9A0DCB0", Offset = "0x9A0C8B0", VA = "0x189A0DCB0", Slot = "5")]
		public override void ZNMWNVUQKVU(MZEXCYTGDUA a, UYLYJABWQJU b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x9A0DD40", Offset = "0x9A0C940", VA = "0x189A0DD40")]
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
			[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF5050", VA = "0x180CF6450")]
			public UBYOUQYNJZM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x9A0D1F0", Offset = "0x9A0BDF0", VA = "0x189A0D1F0")]
			internal float DSPGIDOBCYY()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x9A0D3F0", Offset = "0x9A0BFF0", VA = "0x189A0D3F0")]
			internal void DSUNFKHYMKH(float a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x9A0D570", Offset = "0x9A0C170", VA = "0x189A0D570")]
			internal float DSZUCRBVVVQ()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x9A0D590", Offset = "0x9A0C190", VA = "0x189A0D590")]
			internal void DTFAZXVTFGZ(float a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x9A0D5A0", Offset = "0x9A0C1A0", VA = "0x189A0D5A0")]
			internal float DTKHXEPQOSI()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x9A0D630", Offset = "0x9A0C230", VA = "0x189A0D630")]
			internal void DTPOULJNYDR(float a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x9A0D720", Offset = "0x9A0C320", VA = "0x189A0D720")]
			internal float KNWHAFZGLGA(int a)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x9A0CF90", Offset = "0x9A0BB90", VA = "0x189A0CF90")]
			internal void BPBZVYQJUST(int a, float b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x9A0DF50", Offset = "0x9A0CB50", VA = "0x189A0DF50", Slot = "5")]
		public override void ZNMWNVUQKVU(MZEXCYTGDUA a, UYLYJABWQJU b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x9A0E350", Offset = "0x9A0CF50", VA = "0x189A0E350")]
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
			[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF5050", VA = "0x180CF6450")]
			public UBYOUQYNJZM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x9A0D270", Offset = "0x9A0BE70", VA = "0x189A0D270")]
			internal int DSPGIDOBCYY()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x9A0D390", Offset = "0x9A0BF90", VA = "0x189A0D390")]
			internal void DSUNFKHYMKH(int a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x9A0CCF0", Offset = "0x9A0B8F0", VA = "0x189A0CCF0", Slot = "5")]
		public override void ZNMWNVUQKVU(MZEXCYTGDUA a, UYLYJABWQJU b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x9A0CE80", Offset = "0x9A0BA80", VA = "0x189A0CE80")]
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
		[Cpp2IlInjected.Address(RVA = "0x9A09070", Offset = "0x9A07C70", VA = "0x189A09070")]
		public static void CYAXJOSSCEP(Type a, Type b)
		{
		}
	}
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	internal struct CommonProperties
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x9A069D0", Offset = "0x9A055D0", VA = "0x189A069D0")]
		public static NativeList<NetworkProperty> CKKBOWJUVDM(NativeObjectLocalIdArray a, LISNGJFWSIP b)
		{
			return default(NativeList<NetworkProperty>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x9A06C50", Offset = "0x9A05850", VA = "0x189A06C50")]
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
			[Cpp2IlInjected.Address(RVA = "0x9A08760", Offset = "0x9A07360", VA = "0x189A08760", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public bool CXRGWAGXVPP
		{
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x9A08510", Offset = "0x9A07110", VA = "0x189A08510", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public RRObject OGMCZHCYKWJ
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x9A08590", Offset = "0x9A07190", VA = "0x189A08590", Slot = "8")]
			get
			{
				return default(RRObject);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public Type XYUHIEMAMOM
		{
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x9A08420", Offset = "0x9A07020", VA = "0x189A08420", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action AWRUUXEIWDO
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x9A086C0", Offset = "0x9A072C0", VA = "0x189A086C0", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x9A08470", Offset = "0x9A07070", VA = "0x189A08470", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x9A089F0", Offset = "0x9A075F0", VA = "0x189A089F0")]
		public EGUYAMYPMAT(NativeObjectLocalIdArray a, NetworkProperty b, LISNGJFWSIP c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x9A087C0", Offset = "0x9A073C0", VA = "0x189A087C0")]
		private void NIPBRXYIECT(BulkPropertyChangeData a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x9A085E0", Offset = "0x9A071E0", VA = "0x189A085E0", Slot = "10")]
		public void Get(MutableRef value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x9A088D0", Offset = "0x9A074D0", VA = "0x189A088D0", Slot = "11")]
		public void Set(ReadOnlyRef value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x9A08350", Offset = "0x9A06F50", VA = "0x189A08350", Slot = "12")]
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
			[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF5050", VA = "0x180CF6450")]
			public UFMXOEVUXJC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0x9A0D8F0", Offset = "0x9A0C4F0", VA = "0x189A0D8F0")]
			internal bool DSPGIDOBCYY()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0x9A0D940", Offset = "0x9A0C540", VA = "0x189A0D940")]
			internal string DSUNFKHYMKH()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0x9A0D9C0", Offset = "0x9A0C5C0", VA = "0x189A0D9C0")]
			internal void DSZUCRBVVVQ(string a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0x9A0DA50", Offset = "0x9A0C650", VA = "0x189A0DA50")]
			internal string DTFAZXVTFGZ()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public NetworkProperty IFWWVKYBDVT
		{
			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x9A07CE0", Offset = "0x9A068E0", VA = "0x189A07CE0", Slot = "4")]
			get
			{
				return default(NetworkProperty);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x9A07D50", Offset = "0x9A06950", VA = "0x189A07D50", Slot = "5")]
		public void ZNMWNVUQKVU(MZEXCYTGDUA a, UYLYJABWQJU b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF5050", VA = "0x180CF6450")]
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
		[Cpp2IlInjected.Address(RVA = "0x9A09C50", Offset = "0x9A08850", VA = "0x189A09C50")]
		public MBVOASLYIEI(LISNGJFWSIP a, UYLYJABWQJU b, Action<Candidate> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x9A098B0", Offset = "0x9A084B0", VA = "0x189A098B0")]
		public void UIANMRNCADC(NativeList<Candidate> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x9A09740", Offset = "0x9A08340", VA = "0x189A09740")]
		private void PQGKNQROPII(ZCIBIFKBEZY a, Candidate b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x9A09BF0", Offset = "0x9A087F0", VA = "0x189A09BF0")]
		public void VTDECWMGXQY()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x9A092D0", Offset = "0x9A07ED0", VA = "0x189A092D0")]
		private void BVMDWARVUOA(ZCIBIFKBEZY a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x9A09230", Offset = "0x9A07E30", VA = "0x189A09230")]
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
				[Cpp2IlInjected.Address(RVA = "0xDDD830", Offset = "0xDDC430", VA = "0x180DDD830", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0x9A0A6D0", Offset = "0x9A092D0", VA = "0x189A0A6D0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0x15B82D0", Offset = "0x15B6ED0", VA = "0x1815B82D0")]
			[DebuggerHidden]
			public OVPEPPQLCJP(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x9A0AAF0", Offset = "0x9A096F0", VA = "0x189A0AAF0", Slot = "7")]
			[DebuggerHidden]
			private void PEABEYBFILL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0x9A0A810", Offset = "0x9A09410", VA = "0x189A0A810", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0x9A0AB80", Offset = "0x9A09780", VA = "0x189A0AB80")]
			private void SYBUDUAVPHD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0x9A0A7D0", Offset = "0x9A093D0", VA = "0x189A0A7D0", Slot = "10")]
			[DebuggerHidden]
			private void KTHCATTUQZC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008B")]
			[Cpp2IlInjected.Address(RVA = "0x9A0A720", Offset = "0x9A09320", VA = "0x189A0A720", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<NetworkProperty> WROTJYBXICV()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x9A0A720", Offset = "0x9A09320", VA = "0x189A0A720", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x9A0ADF0", Offset = "0x9A099F0", VA = "0x189A0ADF0")]
		public PropertiesByType()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x9A0ABD0", Offset = "0x9A097D0", VA = "0x189A0ABD0")]
		[IteratorStateMachine(typeof(OVPEPPQLCJP))]
		public IEnumerable<NetworkProperty> DWOYVIJVTQI(Type a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x9A0AC60", Offset = "0x9A09860", VA = "0x189A0AC60", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x9A0ACE0", Offset = "0x9A098E0", VA = "0x189A0ACE0")]
		private long ZISYBYPKSTV(NetworkProperty a)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x9A0ACA0", Offset = "0x9A098A0", VA = "0x189A0ACA0")]
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
		[Cpp2IlInjected.Address(RVA = "0x9A0B300", Offset = "0x9A09F00", VA = "0x189A0B300")]
		public PropertyBitmap(int count)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x9A0B170", Offset = "0x9A09D70", VA = "0x189A0B170")]
		public static PropertyBitmap ZHBZLLLDLHE(int a, NativeArray<NetworkProperty> b)
		{
			return default(PropertyBitmap);
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x9A0B160", Offset = "0x9A09D60", VA = "0x189A0B160")]
		public bool WZHEHJKZUEI(int a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x9A0B150", Offset = "0x9A09D50", VA = "0x189A0B150")]
		public void Set(int index, bool value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x9A0AFE0", Offset = "0x9A09BE0", VA = "0x189A0AFE0")]
		public bool All(NetworkProperty[] properties)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x9A0B090", Offset = "0x9A09C90", VA = "0x189A0B090")]
		public bool Any(NetworkProperty[] properties)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x9A0B140", Offset = "0x9A09D40", VA = "0x189A0B140", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0xCF1D40", Offset = "0xCF0940", VA = "0x180CF1D40")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x9A0C520", Offset = "0x9A0B120", VA = "0x189A0C520")]
		public PropertyDrawerCandidates(LISNGJFWSIP configPropertyService)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x9A0B6C0", Offset = "0x9A0A2C0", VA = "0x189A0B6C0")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x9A0C2F0", Offset = "0x9A0AEF0", VA = "0x189A0C2F0")]
		public void TGZVITVKGJN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x9A0BD50", Offset = "0x9A0A950", VA = "0x189A0BD50")]
		public NativeList<Candidate> NHJMIKCDAHQ(NativeArray<NetworkProperty> a)
		{
			return default(NativeList<Candidate>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x9A0B7A0", Offset = "0x9A0A3A0", VA = "0x189A0B7A0")]
		private bool GVEUYYRHCNW(TXRZSTPMAZR a, PropertyBitmap b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x3E03570", Offset = "0x3E02170", VA = "0x183E03570")]
		private void QFKUUEPAKJL<b, a>(Action<b, a> a) where b : TXRZSTPMAZR where a : Attribute
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x9A0B8F0", Offset = "0x9A0A4F0", VA = "0x189A0B8F0")]
		private void HYZABRTBBSF(Type a, Type b, Type c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x3E03200", Offset = "0x3E01E00", VA = "0x183E03200")]
		private c JBRSNIREQEI<c>(Type a)
		{
			return (c)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x9A0B350", Offset = "0x9A09F50", VA = "0x189A0B350")]
		private int DDWBVLIBDKL(TXRZSTPMAZR a, int b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x9A0B440", Offset = "0x9A0A040", VA = "0x189A0B440")]
		private void DYTJBVHIGLD(GWBYPVMBYQL a, ConfigPropertyDrawer b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x9A0BA30", Offset = "0x9A0A630", VA = "0x189A0BA30")]
		private void JTKNAAZHYQW(FUGCORJLEGM a, MatchPropertyDrawer b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x9A0B920", Offset = "0x9A0A520", VA = "0x189A0B920")]
		private void ILRIJUXCJGC(SXAYRTSQJMM a, MultiPropertyDrawer b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x9A0C220", Offset = "0x9A0AE20", VA = "0x189A0C220")]
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
			[Cpp2IlInjected.Address(RVA = "0xF270D0", Offset = "0xF25CD0", VA = "0x180F270D0")]
			get
			{
				return default(NativeList<Candidate>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x9A0CC40", Offset = "0x9A0B840", VA = "0x189A0CC40")]
		public PropertyShadowing(List<TXRZSTPMAZR> drawers, NativeArray<Candidate> candidates)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x9A0C660", Offset = "0x9A0B260", VA = "0x189A0C660", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x9A0C6A0", Offset = "0x9A0B2A0", VA = "0x189A0C6A0")]
		private NativeList<Candidate> NDCIYZWNYTG(NativeArray<Candidate> a)
		{
			return default(NativeList<Candidate>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x9A0CAD0", Offset = "0x9A0B6D0", VA = "0x189A0CAD0")]
		private bool YKODBTJYZGN(TXRZSTPMAZR a, PropertyBitmap b, NetworkProperty c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x9A0C9A0", Offset = "0x9A0B5A0", VA = "0x189A0C9A0")]
		private void NGTCCIFJNCQ(TXRZSTPMAZR a, PropertyBitmap b, NetworkProperty c)
		{
		}
	}
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	internal struct SortCandidatesByPriority : IComparer<Candidate>
	{
		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x9A0CC90", Offset = "0x9A0B890", VA = "0x189A0CC90", Slot = "4")]
		public int Compare(Candidate a, Candidate b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x9A0CCA0", Offset = "0x9A0B8A0", VA = "0x189A0CCA0")]
		public static void Sort(NativeList<Candidate> candidates)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	[AttributeUsage(AttributeTargets.Class)]
	public class SpecificPropertyDrawer : ConfigPropertyDrawerBase
	{
		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x9A0CCE0", Offset = "0x9A0B8E0", VA = "0x189A0CCE0")]
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
