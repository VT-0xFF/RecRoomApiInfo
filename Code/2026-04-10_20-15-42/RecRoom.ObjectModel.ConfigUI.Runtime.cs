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
		[Cpp2IlInjected.Address(RVA = "0x9BAA450", Offset = "0x9BA9450", VA = "0x189BAA450", Slot = "4")]
		public override void SIFQFAPRLAF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xD34090", Offset = "0xD33090", VA = "0x180D34090")]
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
			[Cpp2IlInjected.Address(RVA = "0xD0F400", Offset = "0xD0E400", VA = "0x180D0F400", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x9BB0060", Offset = "0x9BAF060", VA = "0x189BB0060", Slot = "5")]
		public override void SetServiceCategoryIndices(List<int> globalFromLocalIndices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x9BAF6D0", Offset = "0x9BAE6D0", VA = "0x189BAF6D0")]
		private void GVEYSKBSPJB(IServiceRegistration a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x9BAF8F0", Offset = "0x9BAE8F0", VA = "0x189BAF8F0", Slot = "6")]
		public override void RegisterServices(IServiceRegistration registry, [In] ServiceBitsetFilter filter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x9BAF950", Offset = "0x9BAE950", VA = "0x189BAF950", Slot = "7")]
		public override void RegisterTypes(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x9BB0080", Offset = "0x9BAF080", VA = "0x189BB0080")]
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
		[Cpp2IlInjected.Address(RVA = "0x9BA7CA0", Offset = "0x9BA6CA0", VA = "0x189BA7CA0")]
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
			[Cpp2IlInjected.Address(RVA = "0xD11530", Offset = "0xD10530", VA = "0x180D11530")]
			public HGOHUZHWDLD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x654A300", Offset = "0x6549300", VA = "0x18654A300")]
			internal bool GPDPFRSHUUU()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x634C680", Offset = "0x634B680", VA = "0x18634C680")]
		protected FLKMENPKIZB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x634BE50", Offset = "0x634AE50", VA = "0x18634BE50")]
		protected void FWSEKVAZIEK(WVPUCKMDXCR a, MZEXCYTGDUA b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x634C470", Offset = "0x634B470", VA = "0x18634C470")]
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
		[Cpp2IlInjected.Address(RVA = "0x3F684F0", Offset = "0x3F674F0", VA = "0x183F684F0")]
		protected static b FARHZPDKCWO<b>(NativeObjectLocalIdArray a, NetworkProperty<b> b) where b : struct
		{
			return (b)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x3F68300", Offset = "0x3F67300", VA = "0x183F68300")]
		protected static void BQFKJGOILXB<d>(NativeObjectLocalIdArray a, NetworkProperty<d> b, d c) where d : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0xD11530", Offset = "0xD10530", VA = "0x180D11530")]
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
			[Cpp2IlInjected.Address(RVA = "0xD11530", Offset = "0xD10530", VA = "0x180D11530")]
			public HGOHUZHWDLD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x654A4E0", Offset = "0x65494E0", VA = "0x18654A4E0")]
			internal bool GPDPFRSHUUU()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x634C680", Offset = "0x634B680", VA = "0x18634C680")]
		protected AMPRZBIONHE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x72EBD60", Offset = "0x72EAD60", VA = "0x1872EBD60")]
		protected void FWSEKVAZIEK(WVPUCKMDXCR a, MZEXCYTGDUA b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x72ED190", Offset = "0x72EC190", VA = "0x1872ED190")]
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
			[Cpp2IlInjected.Address(RVA = "0x1731F10", Offset = "0x1730F10", VA = "0x181731F10", Slot = "5")]
			get
			{
				return default(NativeObjectLocalIdArray);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x9BA8150", Offset = "0x9BA7150", VA = "0x189BA8150", Slot = "6")]
		public void InitExternal(PPCVAYWFABF services)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x9BA8050", Offset = "0x9BA7050", VA = "0x189BA8050", Slot = "7")]
		public void AALNHOBOWYP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x9BA8740", Offset = "0x9BA7740", VA = "0x189BA8740", Slot = "4")]
		public void YDKNOKRPSNS(NativeObjectLocalIdArray a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x9BA8470", Offset = "0x9BA7470", VA = "0x189BA8470")]
		private void LWSDGGKWOEO(NativeObjectLocalIdArray a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x9BA8550", Offset = "0x9BA7550", VA = "0x189BA8550")]
		private void OVNPJGLCFXL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x9BA8BB0", Offset = "0x9BA7BB0", VA = "0x189BA8BB0")]
		private void ZNMWNVUQKVU(Candidate a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x9BA84E0", Offset = "0x9BA74E0", VA = "0x189BA84E0", Slot = "8")]
		private void MMZJSGUTRHN(PPCVAYWFABF a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x104ABF0", Offset = "0x1049BF0", VA = "0x18104ABF0", Slot = "9")]
		private void IKBYUUMLEVN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x9BA8F80", Offset = "0x9BA7F80", VA = "0x189BA8F80")]
		public ConfigUIService()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[MatchPropertyDrawer(0)]
	internal class BTYRJPGJPMZ : FMEBWTLAPCP
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x9BA7BF0", Offset = "0x9BA6BF0", VA = "0x189BA7BF0", Slot = "5")]
		public override void ZNMWNVUQKVU(MZEXCYTGDUA a, UYLYJABWQJU b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x9BA7B50", Offset = "0x9BA6B50", VA = "0x189BA7B50", Slot = "7")]
		public override bool HEHUHCHHXSN(Type a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x9BA7CA0", Offset = "0x9BA6CA0", VA = "0x189BA7CA0")]
		public BTYRJPGJPMZ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[MatchPropertyDrawer(0)]
	internal class IXYDFSSFCXM : FMEBWTLAPCP
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x9BA9EA0", Offset = "0x9BA8EA0", VA = "0x189BA9EA0", Slot = "5")]
		public override void ZNMWNVUQKVU(MZEXCYTGDUA a, UYLYJABWQJU b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x9BA9E00", Offset = "0x9BA8E00", VA = "0x189BA9E00", Slot = "7")]
		public override bool HEHUHCHHXSN(Type a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x9BA7CA0", Offset = "0x9BA6CA0", VA = "0x189BA7CA0")]
		public IXYDFSSFCXM()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[ConfigPropertyDrawer(typeof(RenderableColor), 1)]
	internal class UZKCVKWSHOH : FLKMENPKIZB<RenderableColor>
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x9BAEE60", Offset = "0x9BADE60", VA = "0x189BAEE60", Slot = "5")]
		public override void ZNMWNVUQKVU(MZEXCYTGDUA a, UYLYJABWQJU b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x9BAEFB0", Offset = "0x9BADFB0", VA = "0x189BAEFB0")]
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
			[Cpp2IlInjected.Address(RVA = "0xD11530", Offset = "0xD10530", VA = "0x180D11530")]
			public MDJIIFNDRCE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x9BAB090", Offset = "0x9BAA090", VA = "0x189BAB090")]
			internal (int, int) DSPGIDOBCYY()
			{
				return default((int, int));
			}

			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x9BAB300", Offset = "0x9BAA300", VA = "0x189BAB300")]
			internal void DSUNFKHYMKH((int color, int material) value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public override NetworkProperty[] NYGDHSDPIJJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0xD0F3C0", Offset = "0xD0E3C0", VA = "0x180D0F3C0", Slot = "7")]
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
			[Cpp2IlInjected.Address(RVA = "0xD0CDC0", Offset = "0xD0BDC0", VA = "0x180D0CDC0", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x9BAB450", Offset = "0x9BAA450", VA = "0x189BAB450", Slot = "9")]
		public override void ZNMWNVUQKVU(MZEXCYTGDUA a, HVXZROXIITZ b, LISNGJFWSIP c, UYLYJABWQJU d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x9BAB800", Offset = "0x9BAA800", VA = "0x189BAB800")]
		public MZOPOQEYRLJ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[ConfigPropertyDrawer(typeof(bool))]
	internal class TYFEOAWRAXO : AMPRZBIONHE<bool>
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x9BAE200", Offset = "0x9BAD200", VA = "0x189BAE200", Slot = "5")]
		public override void ZNMWNVUQKVU(MZEXCYTGDUA a, UYLYJABWQJU b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x9BAE290", Offset = "0x9BAD290", VA = "0x189BAE290")]
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
			[Cpp2IlInjected.Address(RVA = "0xD11530", Offset = "0xD10530", VA = "0x180D11530")]
			public UBYOUQYNJZM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x9BAE5F0", Offset = "0x9BAD5F0", VA = "0x189BAE5F0")]
			internal string DSPGIDOBCYY()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x9BAE740", Offset = "0x9BAD740", VA = "0x189BAE740")]
			internal void DSUNFKHYMKH(string a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x9BA94A0", Offset = "0x9BA84A0", VA = "0x189BA94A0", Slot = "5")]
		public override void ZNMWNVUQKVU(MZEXCYTGDUA a, UYLYJABWQJU b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x9BA9630", Offset = "0x9BA8630", VA = "0x189BA9630")]
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
			[Cpp2IlInjected.Address(RVA = "0xD11530", Offset = "0xD10530", VA = "0x180D11530")]
			public UBYOUQYNJZM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x9BAE650", Offset = "0x9BAD650", VA = "0x189BAE650")]
			internal string DSPGIDOBCYY()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x9BAE7B0", Offset = "0x9BAD7B0", VA = "0x189BAE7B0")]
			internal void DSUNFKHYMKH(string a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x9BAF0C0", Offset = "0x9BAE0C0", VA = "0x189BAF0C0", Slot = "5")]
		public override void ZNMWNVUQKVU(MZEXCYTGDUA a, UYLYJABWQJU b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x9BAF250", Offset = "0x9BAE250", VA = "0x189BAF250")]
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
			[Cpp2IlInjected.Address(RVA = "0xD11530", Offset = "0xD10530", VA = "0x180D11530")]
			public UBYOUQYNJZM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x9BAE540", Offset = "0x9BAD540", VA = "0x189BAE540")]
			internal float DSPGIDOBCYY()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x9BAE720", Offset = "0x9BAD720", VA = "0x189BAE720")]
			internal void DSUNFKHYMKH(float a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x9BAE840", Offset = "0x9BAD840", VA = "0x189BAE840")]
			internal float DSZUCRBVVVQ()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x9BAE8C0", Offset = "0x9BAD8C0", VA = "0x189BAE8C0")]
			internal void DTFAZXVTFGZ(float a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x9BAE8F0", Offset = "0x9BAD8F0", VA = "0x189BAE8F0")]
			internal float DTKHXEPQOSI()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x9BAE960", Offset = "0x9BAD960", VA = "0x189BAE960")]
			internal void DTPOULJNYDR(float a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x9BAEBC0", Offset = "0x9BADBC0", VA = "0x189BAEBC0")]
			internal float MVPGJFGNCPN(int a)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x9BAE980", Offset = "0x9BAD980", VA = "0x189BAE980")]
			internal void JJOEZQHJXKE(int a, float b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x9BA9F50", Offset = "0x9BA8F50", VA = "0x189BA9F50", Slot = "5")]
		public override void ZNMWNVUQKVU(MZEXCYTGDUA a, UYLYJABWQJU b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x9BAA350", Offset = "0x9BA9350", VA = "0x189BAA350")]
		public KWSGKRACOYT()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[ConfigPropertyDrawer(typeof(float))]
	internal class NZVNUBAQCXA : AMPRZBIONHE<float>
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x9BAB930", Offset = "0x9BAA930", VA = "0x189BAB930", Slot = "5")]
		public override void ZNMWNVUQKVU(MZEXCYTGDUA a, UYLYJABWQJU b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x9BAB9C0", Offset = "0x9BAA9C0", VA = "0x189BAB9C0")]
		public NZVNUBAQCXA()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[ConfigPropertyDrawer(typeof(int))]
	internal class XRMNCCKBKAJ : AMPRZBIONHE<int>
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x9BAEFF0", Offset = "0x9BADFF0", VA = "0x189BAEFF0", Slot = "5")]
		public override void ZNMWNVUQKVU(MZEXCYTGDUA a, UYLYJABWQJU b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x9BAF080", Offset = "0x9BAE080", VA = "0x189BAF080")]
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
			[Cpp2IlInjected.Address(RVA = "0xD11530", Offset = "0xD10530", VA = "0x180D11530")]
			public UBYOUQYNJZM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x9BAE530", Offset = "0x9BAD530", VA = "0x189BAE530")]
			internal float DSPGIDOBCYY()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x9BAE730", Offset = "0x9BAD730", VA = "0x189BAE730")]
			internal void DSUNFKHYMKH(float a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x9BAE8B0", Offset = "0x9BAD8B0", VA = "0x189BAE8B0")]
			internal float DSZUCRBVVVQ()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x9BAE8D0", Offset = "0x9BAD8D0", VA = "0x189BAE8D0")]
			internal void DTFAZXVTFGZ(float a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x9BAE8E0", Offset = "0x9BAD8E0", VA = "0x189BAE8E0")]
			internal float DTKHXEPQOSI()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x9BAE970", Offset = "0x9BAD970", VA = "0x189BAE970")]
			internal void DTPOULJNYDR(float a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x9BAEA60", Offset = "0x9BADA60", VA = "0x189BAEA60")]
			internal float KNWHAFZGLGA(int a)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x9BAE2D0", Offset = "0x9BAD2D0", VA = "0x189BAE2D0")]
			internal void BPBZVYQJUST(int a, float b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x9BAF290", Offset = "0x9BAE290", VA = "0x189BAF290", Slot = "5")]
		public override void ZNMWNVUQKVU(MZEXCYTGDUA a, UYLYJABWQJU b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x9BAF690", Offset = "0x9BAE690", VA = "0x189BAF690")]
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
			[Cpp2IlInjected.Address(RVA = "0xD11530", Offset = "0xD10530", VA = "0x180D11530")]
			public UBYOUQYNJZM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x9BAE5B0", Offset = "0x9BAD5B0", VA = "0x189BAE5B0")]
			internal int DSPGIDOBCYY()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x9BAE6D0", Offset = "0x9BAD6D0", VA = "0x189BAE6D0")]
			internal void DSUNFKHYMKH(int a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x9BAE030", Offset = "0x9BAD030", VA = "0x189BAE030", Slot = "5")]
		public override void ZNMWNVUQKVU(MZEXCYTGDUA a, UYLYJABWQJU b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x9BAE1C0", Offset = "0x9BAD1C0", VA = "0x189BAE1C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x9BAA390", Offset = "0x9BA9390", VA = "0x189BAA390")]
		public static void CYAXJOSSCEP(Type a, Type b)
		{
		}
	}
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	internal struct CommonProperties
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x9BA7CE0", Offset = "0x9BA6CE0", VA = "0x189BA7CE0")]
		public static NativeList<NetworkProperty> CKKBOWJUVDM(NativeObjectLocalIdArray a, LISNGJFWSIP b)
		{
			return default(NativeList<NetworkProperty>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x9BA7F60", Offset = "0x9BA6F60", VA = "0x189BA7F60")]
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
			[Cpp2IlInjected.Address(RVA = "0x9BA9A80", Offset = "0x9BA8A80", VA = "0x189BA9A80", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public bool CXRGWAGXVPP
		{
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x9BA9830", Offset = "0x9BA8830", VA = "0x189BA9830", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public RRObject OGMCZHCYKWJ
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x9BA98B0", Offset = "0x9BA88B0", VA = "0x189BA98B0", Slot = "8")]
			get
			{
				return default(RRObject);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public Type XYUHIEMAMOM
		{
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x9BA9740", Offset = "0x9BA8740", VA = "0x189BA9740", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action AWRUUXEIWDO
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x9BA99E0", Offset = "0x9BA89E0", VA = "0x189BA99E0", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x9BA9790", Offset = "0x9BA8790", VA = "0x189BA9790", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x9BA9D10", Offset = "0x9BA8D10", VA = "0x189BA9D10")]
		public EGUYAMYPMAT(NativeObjectLocalIdArray a, NetworkProperty b, LISNGJFWSIP c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x9BA9AE0", Offset = "0x9BA8AE0", VA = "0x189BA9AE0")]
		private void NIPBRXYIECT(BulkPropertyChangeData a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x9BA9900", Offset = "0x9BA8900", VA = "0x189BA9900", Slot = "10")]
		public void Get(MutableRef value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x9BA9BF0", Offset = "0x9BA8BF0", VA = "0x189BA9BF0", Slot = "11")]
		public void Set(ReadOnlyRef value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x9BA9670", Offset = "0x9BA8670", VA = "0x189BA9670", Slot = "12")]
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
			[Cpp2IlInjected.Address(RVA = "0xD11530", Offset = "0xD10530", VA = "0x180D11530")]
			public UFMXOEVUXJC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0x9BAEC30", Offset = "0x9BADC30", VA = "0x189BAEC30")]
			internal bool DSPGIDOBCYY()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0x9BAEC80", Offset = "0x9BADC80", VA = "0x189BAEC80")]
			internal string DSUNFKHYMKH()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0x9BAED00", Offset = "0x9BADD00", VA = "0x189BAED00")]
			internal void DSZUCRBVVVQ(string a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0x9BAED90", Offset = "0x9BADD90", VA = "0x189BAED90")]
			internal string DTFAZXVTFGZ()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public NetworkProperty IFWWVKYBDVT
		{
			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x9BA9000", Offset = "0x9BA8000", VA = "0x189BA9000", Slot = "4")]
			get
			{
				return default(NetworkProperty);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x9BA9070", Offset = "0x9BA8070", VA = "0x189BA9070", Slot = "5")]
		public void ZNMWNVUQKVU(MZEXCYTGDUA a, UYLYJABWQJU b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0xD11530", Offset = "0xD10530", VA = "0x180D11530")]
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
		[Cpp2IlInjected.Address(RVA = "0x9BAAF80", Offset = "0x9BA9F80", VA = "0x189BAAF80")]
		public MBVOASLYIEI(LISNGJFWSIP a, UYLYJABWQJU b, Action<Candidate> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x9BAABE0", Offset = "0x9BA9BE0", VA = "0x189BAABE0")]
		public void UIANMRNCADC(NativeList<Candidate> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x9BAAA60", Offset = "0x9BA9A60", VA = "0x189BAAA60")]
		private void PQGKNQROPII(ZCIBIFKBEZY a, Candidate b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x9BAAF20", Offset = "0x9BA9F20", VA = "0x189BAAF20")]
		public void VTDECWMGXQY()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x9BAA5F0", Offset = "0x9BA95F0", VA = "0x189BAA5F0")]
		private void BVMDWARVUOA(ZCIBIFKBEZY a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x9BAA550", Offset = "0x9BA9550", VA = "0x189BAA550")]
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
				[Cpp2IlInjected.Address(RVA = "0xDF8EE0", Offset = "0xDF7EE0", VA = "0x180DF8EE0", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0x9BABA00", Offset = "0x9BAAA00", VA = "0x189BABA00", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0x15D3630", Offset = "0x15D2630", VA = "0x1815D3630")]
			[DebuggerHidden]
			public OVPEPPQLCJP(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x9BABE30", Offset = "0x9BAAE30", VA = "0x189BABE30", Slot = "7")]
			[DebuggerHidden]
			private void PEABEYBFILL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0x9BABB40", Offset = "0x9BAAB40", VA = "0x189BABB40", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0x9BABEC0", Offset = "0x9BAAEC0", VA = "0x189BABEC0")]
			private void SYBUDUAVPHD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0x9BABB00", Offset = "0x9BAAB00", VA = "0x189BABB00", Slot = "10")]
			[DebuggerHidden]
			private void KTHCATTUQZC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008B")]
			[Cpp2IlInjected.Address(RVA = "0x9BABA50", Offset = "0x9BAAA50", VA = "0x189BABA50", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<NetworkProperty> WROTJYBXICV()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x9BABA50", Offset = "0x9BAAA50", VA = "0x189BABA50", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x9BAC130", Offset = "0x9BAB130", VA = "0x189BAC130")]
		public PropertiesByType()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x9BABF10", Offset = "0x9BAAF10", VA = "0x189BABF10")]
		[IteratorStateMachine(typeof(OVPEPPQLCJP))]
		public IEnumerable<NetworkProperty> DWOYVIJVTQI(Type a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x9BABFA0", Offset = "0x9BAAFA0", VA = "0x189BABFA0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x9BAC020", Offset = "0x9BAB020", VA = "0x189BAC020")]
		private long ZISYBYPKSTV(NetworkProperty a)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x9BABFE0", Offset = "0x9BAAFE0", VA = "0x189BABFE0")]
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
		[Cpp2IlInjected.Address(RVA = "0x9BAC640", Offset = "0x9BAB640", VA = "0x189BAC640")]
		public PropertyBitmap(int count)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x9BAC4B0", Offset = "0x9BAB4B0", VA = "0x189BAC4B0")]
		public static PropertyBitmap ZHBZLLLDLHE(int a, NativeArray<NetworkProperty> b)
		{
			return default(PropertyBitmap);
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x9BAC4A0", Offset = "0x9BAB4A0", VA = "0x189BAC4A0")]
		public bool WZHEHJKZUEI(int a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x9BAC490", Offset = "0x9BAB490", VA = "0x189BAC490")]
		public void Set(int index, bool value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x9BAC320", Offset = "0x9BAB320", VA = "0x189BAC320")]
		public bool All(NetworkProperty[] properties)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x9BAC3D0", Offset = "0x9BAB3D0", VA = "0x189BAC3D0")]
		public bool Any(NetworkProperty[] properties)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x9BAC480", Offset = "0x9BAB480", VA = "0x189BAC480", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0xD0CDC0", Offset = "0xD0BDC0", VA = "0x180D0CDC0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x9BAD860", Offset = "0x9BAC860", VA = "0x189BAD860")]
		public PropertyDrawerCandidates(LISNGJFWSIP configPropertyService)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x9BACA00", Offset = "0x9BABA00", VA = "0x189BACA00")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x9BAD630", Offset = "0x9BAC630", VA = "0x189BAD630")]
		public void TGZVITVKGJN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x9BAD090", Offset = "0x9BAC090", VA = "0x189BAD090")]
		public NativeList<Candidate> NHJMIKCDAHQ(NativeArray<NetworkProperty> a)
		{
			return default(NativeList<Candidate>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x9BACAE0", Offset = "0x9BABAE0", VA = "0x189BACAE0")]
		private bool GVEUYYRHCNW(TXRZSTPMAZR a, PropertyBitmap b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x3E19D70", Offset = "0x3E18D70", VA = "0x183E19D70")]
		private void QFKUUEPAKJL<b, a>(Action<b, a> a) where b : TXRZSTPMAZR where a : Attribute
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x9BACC30", Offset = "0x9BABC30", VA = "0x189BACC30")]
		private void HYZABRTBBSF(Type a, Type b, Type c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x3E19A00", Offset = "0x3E18A00", VA = "0x183E19A00")]
		private c JBRSNIREQEI<c>(Type a)
		{
			return (c)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x9BAC690", Offset = "0x9BAB690", VA = "0x189BAC690")]
		private int DDWBVLIBDKL(TXRZSTPMAZR a, int b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x9BAC780", Offset = "0x9BAB780", VA = "0x189BAC780")]
		private void DYTJBVHIGLD(GWBYPVMBYQL a, ConfigPropertyDrawer b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x9BACD70", Offset = "0x9BABD70", VA = "0x189BACD70")]
		private void JTKNAAZHYQW(FUGCORJLEGM a, MatchPropertyDrawer b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x9BACC60", Offset = "0x9BABC60", VA = "0x189BACC60")]
		private void ILRIJUXCJGC(SXAYRTSQJMM a, MultiPropertyDrawer b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x9BAD560", Offset = "0x9BAC560", VA = "0x189BAD560")]
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
			[Cpp2IlInjected.Address(RVA = "0xF429D0", Offset = "0xF419D0", VA = "0x180F429D0")]
			get
			{
				return default(NativeList<Candidate>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x9BADF80", Offset = "0x9BACF80", VA = "0x189BADF80")]
		public PropertyShadowing(List<TXRZSTPMAZR> drawers, NativeArray<Candidate> candidates)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x9BAD9A0", Offset = "0x9BAC9A0", VA = "0x189BAD9A0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x9BAD9E0", Offset = "0x9BAC9E0", VA = "0x189BAD9E0")]
		private NativeList<Candidate> NDCIYZWNYTG(NativeArray<Candidate> a)
		{
			return default(NativeList<Candidate>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x9BADE10", Offset = "0x9BACE10", VA = "0x189BADE10")]
		private bool YKODBTJYZGN(TXRZSTPMAZR a, PropertyBitmap b, NetworkProperty c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x9BADCE0", Offset = "0x9BACCE0", VA = "0x189BADCE0")]
		private void NGTCCIFJNCQ(TXRZSTPMAZR a, PropertyBitmap b, NetworkProperty c)
		{
		}
	}
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	internal struct SortCandidatesByPriority : IComparer<Candidate>
	{
		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x9BADFD0", Offset = "0x9BACFD0", VA = "0x189BADFD0", Slot = "4")]
		public int Compare(Candidate a, Candidate b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x9BADFE0", Offset = "0x9BACFE0", VA = "0x189BADFE0")]
		public static void Sort(NativeList<Candidate> candidates)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	[AttributeUsage(AttributeTargets.Class)]
	public class SpecificPropertyDrawer : ConfigPropertyDrawerBase
	{
		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x9BAE020", Offset = "0x9BAD020", VA = "0x189BAE020")]
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
