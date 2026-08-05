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
		[Cpp2IlInjected.Address(RVA = "0x9B7B2E0", Offset = "0x9B79CE0", VA = "0x189B7B2E0", Slot = "4")]
		public override void WSFSWRIEDET()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xD3AE50", Offset = "0xD39850", VA = "0x180D3AE50")]
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
		private int[] YLRGDEQABQS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private ServiceBitset KVULHZCLSVL;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public override string[] ServiceCategories
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0xD11C00", Offset = "0xD10600", VA = "0x180D11C00", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x9B80530", Offset = "0x9B7EF30", VA = "0x189B80530", Slot = "5")]
		public override void SetServiceCategoryIndices(List<int> globalFromLocalIndices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x9B7FBA0", Offset = "0x9B7E5A0", VA = "0x189B7FBA0")]
		private void AWUQDEJRHIB(IServiceRegistration a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x9B7FDC0", Offset = "0x9B7E7C0", VA = "0x189B7FDC0", Slot = "6")]
		public override void RegisterServices(IServiceRegistration registry, [In] ServiceBitsetFilter filter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x9B7FE20", Offset = "0x9B7E820", VA = "0x189B7FE20", Slot = "7")]
		public override void RegisterTypes(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x9B80550", Offset = "0x9B7EF50", VA = "0x189B80550")]
		public _AssemblyIndex()
		{
		}
	}
}
namespace RecRoom.ObjectModel.ConfigUI
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	internal abstract class THBDDAFRKUZ : ASKAENRLWHP<Enum>, TSBYPLPHCRY, UVRTBVMCHQZ, EVXKIIZWLTD
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "7")]
		public abstract bool IRQYTNDBJJR(Type a);

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x9B78630", Offset = "0x9B77030", VA = "0x189B78630")]
		protected THBDDAFRKUZ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	internal abstract class ASKAENRLWHP<a> : UVRTBVMCHQZ, EVXKIIZWLTD where a : Enum
	{
		[Cpp2IlInjected.Token(Token = "0x2000006")]
		[CompilerGenerated]
		private sealed class BGYUSPZXLWP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000004")]
			public OLTTEFKKSOS FYSYPMHYNTJ;

			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
			public BGYUSPZXLWP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x4F32B60", Offset = "0x4F31560", VA = "0x184F32B60")]
			internal bool LRDPTXVCQZE()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x51183C0", Offset = "0x5116DC0", VA = "0x1851183C0")]
		protected ASKAENRLWHP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x721FA90", Offset = "0x721E490", VA = "0x18721FA90")]
		protected void AGZVQDTRQAE(WPAXPHITEYH a, OLTTEFKKSOS b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x72202A0", Offset = "0x721ECA0", VA = "0x1872202A0")]
		protected void RYKHMMAIMOW(KDUAOPDZMZC<a> a, OLTTEFKKSOS b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "5")]
		public abstract void KPDEGRBVGRC(OLTTEFKKSOS a, GVOHYNPXQKY b);
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	internal abstract class EQRMPQISJFU : IUPRSUSAXDM, EVXKIIZWLTD
	{
		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public abstract NetworkProperty[] BLBJEHKPCLX
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(Slot = "7")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public abstract NetworkProperty[] IHFSDJBRNHG
		{
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(Slot = "8")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(Slot = "9")]
		public abstract void KPDEGRBVGRC(OLTTEFKKSOS a, YGRPPLSNGOB b, ETIHPWQRPDD c, GVOHYNPXQKY d);

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x3965E30", Offset = "0x3964830", VA = "0x183965E30")]
		protected static b JYBCFKGAGIY<b>(NativeObjectLocalIdArray a, NetworkProperty<b> b) where b : struct
		{
			return (b)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x3966010", Offset = "0x3964A10", VA = "0x183966010")]
		protected static void RJQKHQHHFHD<d>(NativeObjectLocalIdArray a, NetworkProperty<d> b, d c) where d : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
		protected EQRMPQISJFU()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	internal abstract class XEDXNKZYVUI<a> : UVRTBVMCHQZ, EVXKIIZWLTD where a : struct
	{
		[Cpp2IlInjected.Token(Token = "0x2000009")]
		[CompilerGenerated]
		private sealed class BGYUSPZXLWP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000005")]
			public OLTTEFKKSOS FYSYPMHYNTJ;

			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
			public BGYUSPZXLWP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x4F329D0", Offset = "0x4F313D0", VA = "0x184F329D0")]
			internal bool LRDPTXVCQZE()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x51183C0", Offset = "0x5116DC0", VA = "0x1851183C0")]
		protected XEDXNKZYVUI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x5116F80", Offset = "0x5115980", VA = "0x185116F80")]
		protected void AGZVQDTRQAE(WPAXPHITEYH a, OLTTEFKKSOS b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x5117180", Offset = "0x5115B80", VA = "0x185117180")]
		protected void RYKHMMAIMOW(KDUAOPDZMZC<a> a, OLTTEFKKSOS b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(Slot = "5")]
		public abstract void KPDEGRBVGRC(OLTTEFKKSOS a, GVOHYNPXQKY b);
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[RegisterService(typeof(YGRPPLSNGOB), new string[] { })]
	internal class ConfigUIService : YGRPPLSNGOB, FIGEDIDLMZD, PLILCFKSRWT, KZDQEQUQNCZ, PGANNZBSSYB
	{
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private static readonly Log WVPIFBCBMJC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		[DependsOn]
		private ETIHPWQRPDD VGKUPTDRUIY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		[DependsOn]
		private GVOHYNPXQKY QDIELNREHHW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private PropertyDrawerCandidates AMXANLGDBCZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private NativeObjectLocalIdArray GBDUVNBDQTO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private List<OLTTEFKKSOS> TUXCFXHODYT;

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public NativeObjectLocalIdArray VEJUCFUQIYU
		{
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x1741110", Offset = "0x173FB10", VA = "0x181741110", Slot = "5")]
			get
			{
				return default(NativeObjectLocalIdArray);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x9B79120", Offset = "0x9B77B20", VA = "0x189B79120", Slot = "6")]
		public void InitExternal(VBPLBVQDNMR services)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x9B79780", Offset = "0x9B78180", VA = "0x189B79780", Slot = "7")]
		public void ONYBPXDDZTX()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x9B78AB0", Offset = "0x9B774B0", VA = "0x189B78AB0", Slot = "4")]
		public void AMIIKOAIXNQ(NativeObjectLocalIdArray a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x9B79880", Offset = "0x9B78280", VA = "0x189B79880")]
		private void QENQVZZAWOI(NativeObjectLocalIdArray a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x9B78F20", Offset = "0x9B77920", VA = "0x189B78F20")]
		private void BLMILIKEAZB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x9B79440", Offset = "0x9B77E40", VA = "0x189B79440")]
		private void KPDEGRBVGRC(Candidate a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x9B798F0", Offset = "0x9B782F0", VA = "0x189B798F0", Slot = "8")]
		private void UBCVDPRMWRT(VBPLBVQDNMR a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x104F8B0", Offset = "0x104E2B0", VA = "0x18104F8B0", Slot = "9")]
		private void UYXNLSZGBZH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x9B799F0", Offset = "0x9B783F0", VA = "0x189B799F0")]
		public ConfigUIService()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[MatchPropertyDrawer(0)]
	internal class ANGPZVOXISD : THBDDAFRKUZ
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x9B78580", Offset = "0x9B76F80", VA = "0x189B78580", Slot = "5")]
		public override void KPDEGRBVGRC(OLTTEFKKSOS a, GVOHYNPXQKY b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x9B784E0", Offset = "0x9B76EE0", VA = "0x189B784E0", Slot = "7")]
		public override bool IRQYTNDBJJR(Type a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x9B78630", Offset = "0x9B77030", VA = "0x189B78630")]
		public ANGPZVOXISD()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[MatchPropertyDrawer(0)]
	internal class FZJEPAAZFMA : THBDDAFRKUZ
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x9B7AC80", Offset = "0x9B79680", VA = "0x189B7AC80", Slot = "5")]
		public override void KPDEGRBVGRC(OLTTEFKKSOS a, GVOHYNPXQKY b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x9B7ABE0", Offset = "0x9B795E0", VA = "0x189B7ABE0", Slot = "7")]
		public override bool IRQYTNDBJJR(Type a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x9B78630", Offset = "0x9B77030", VA = "0x189B78630")]
		public FZJEPAAZFMA()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[ConfigPropertyDrawer(typeof(RenderableColor), 1)]
	internal class QGYOIVQXIUB : ASKAENRLWHP<RenderableColor>
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x9B7E850", Offset = "0x9B7D250", VA = "0x189B7E850", Slot = "5")]
		public override void KPDEGRBVGRC(OLTTEFKKSOS a, GVOHYNPXQKY b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x9B7E9A0", Offset = "0x9B7D3A0", VA = "0x189B7E9A0")]
		public QGYOIVQXIUB()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[MultiPropertyDrawer(2)]
	internal class LUAHIRHOODT : EQRMPQISJFU
	{
		[Cpp2IlInjected.Token(Token = "0x200000F")]
		[CompilerGenerated]
		private sealed class EPVSEXAORWC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400000E")]
			public YGRPPLSNGOB RSMNSFXZJFD;

			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
			public EPVSEXAORWC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x9B79EB0", Offset = "0x9B788B0", VA = "0x189B79EB0")]
			internal (int, int) XKICBHUCLDU()
			{
				return default((int, int));
			}

			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x9B7A130", Offset = "0x9B78B30", VA = "0x189B7A130")]
			internal void XKNIYONZUPD((int color, int material) value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public override NetworkProperty[] BLBJEHKPCLX
		{
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0xD11BF0", Offset = "0xD105F0", VA = "0x180D11BF0", Slot = "7")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public override NetworkProperty[] IHFSDJBRNHG
		{
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0xD11BC0", Offset = "0xD105C0", VA = "0x180D11BC0", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x9B7AE00", Offset = "0x9B79800", VA = "0x189B7AE00", Slot = "9")]
		public override void KPDEGRBVGRC(OLTTEFKKSOS a, YGRPPLSNGOB b, ETIHPWQRPDD c, GVOHYNPXQKY d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x9B7B1B0", Offset = "0x9B79BB0", VA = "0x189B7B1B0")]
		public LUAHIRHOODT()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[ConfigPropertyDrawer(typeof(bool))]
	internal class VLRIVROJLQS : XEDXNKZYVUI<bool>
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x9B7F290", Offset = "0x9B7DC90", VA = "0x189B7F290", Slot = "5")]
		public override void KPDEGRBVGRC(OLTTEFKKSOS a, GVOHYNPXQKY b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x9B7F320", Offset = "0x9B7DD20", VA = "0x189B7F320")]
		public VLRIVROJLQS()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[ConfigPropertyDrawer(typeof(FixedString32Bytes))]
	internal class WPIINFARPRK : XEDXNKZYVUI<FixedString32Bytes>
	{
		[Cpp2IlInjected.Token(Token = "0x2000012")]
		[CompilerGenerated]
		private sealed class EZRJCHBBPNO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400000F")]
			public OLTTEFKKSOS FYSYPMHYNTJ;

			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
			public EZRJCHBBPNO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x9B7A880", Offset = "0x9B79280", VA = "0x189B7A880")]
			internal string XKICBHUCLDU()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x9B7A9D0", Offset = "0x9B793D0", VA = "0x189B7A9D0")]
			internal void XKNIYONZUPD(string a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x9B7F590", Offset = "0x9B7DF90", VA = "0x189B7F590", Slot = "5")]
		public override void KPDEGRBVGRC(OLTTEFKKSOS a, GVOHYNPXQKY b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x9B7F720", Offset = "0x9B7E120", VA = "0x189B7F720")]
		public WPIINFARPRK()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[ConfigPropertyDrawer(typeof(FixedString64Bytes))]
	internal class SCSYQHXGDXR : XEDXNKZYVUI<FixedString64Bytes>
	{
		[Cpp2IlInjected.Token(Token = "0x2000014")]
		[CompilerGenerated]
		private sealed class EZRJCHBBPNO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000010")]
			public OLTTEFKKSOS FYSYPMHYNTJ;

			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
			public EZRJCHBBPNO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x9B7A8E0", Offset = "0x9B792E0", VA = "0x189B7A8E0")]
			internal string XKICBHUCLDU()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x9B7AA60", Offset = "0x9B79460", VA = "0x189B7AA60")]
			internal void XKNIYONZUPD(string a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x9B7EBB0", Offset = "0x9B7D5B0", VA = "0x189B7EBB0", Slot = "5")]
		public override void KPDEGRBVGRC(OLTTEFKKSOS a, GVOHYNPXQKY b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x9B7ED40", Offset = "0x9B7D740", VA = "0x189B7ED40")]
		public SCSYQHXGDXR()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	[ConfigPropertyDrawer(typeof(float3))]
	internal class DCMCRQNLQGJ : XEDXNKZYVUI<float3>
	{
		[Cpp2IlInjected.Token(Token = "0x2000016")]
		[CompilerGenerated]
		private sealed class EZRJCHBBPNO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000011")]
			public OLTTEFKKSOS FYSYPMHYNTJ;

			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
			public EZRJCHBBPNO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x9B7A960", Offset = "0x9B79360", VA = "0x189B7A960")]
			internal float XKICBHUCLDU()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x9B7AA50", Offset = "0x9B79450", VA = "0x189B7AA50")]
			internal void XKNIYONZUPD(float a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x9B7A7A0", Offset = "0x9B791A0", VA = "0x189B7A7A0")]
			internal float XJXOGUGHSHC()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x9B7A820", Offset = "0x9B79220", VA = "0x189B7A820")]
			internal void XKCVEBAFBSL(float a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x9B7AB40", Offset = "0x9B79540", VA = "0x189B7AB40")]
			internal float XLDDQIVRWXE()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x9B7ABC0", Offset = "0x9B795C0", VA = "0x189B7ABC0")]
			internal void XLIKNPPPGIN(float a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x9B7A4E0", Offset = "0x9B78EE0", VA = "0x189B7A4E0")]
			internal float JBNMQKJSWJH(int a)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x9B7A550", Offset = "0x9B78F50", VA = "0x189B7A550")]
			internal void NWAOTDCMJSC(int a, float b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x9B79A70", Offset = "0x9B78470", VA = "0x189B79A70", Slot = "5")]
		public override void KPDEGRBVGRC(OLTTEFKKSOS a, GVOHYNPXQKY b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x9B79E70", Offset = "0x9B78870", VA = "0x189B79E70")]
		public DCMCRQNLQGJ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[ConfigPropertyDrawer(typeof(float))]
	internal class BGAWECTLJOI : XEDXNKZYVUI<float>
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x9B78670", Offset = "0x9B77070", VA = "0x189B78670", Slot = "5")]
		public override void KPDEGRBVGRC(OLTTEFKKSOS a, GVOHYNPXQKY b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x9B78700", Offset = "0x9B77100", VA = "0x189B78700")]
		public BGAWECTLJOI()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[ConfigPropertyDrawer(typeof(int))]
	internal class IMOIWHUUQAP : XEDXNKZYVUI<int>
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x9B7AD30", Offset = "0x9B79730", VA = "0x189B7AD30", Slot = "5")]
		public override void KPDEGRBVGRC(OLTTEFKKSOS a, GVOHYNPXQKY b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x9B7ADC0", Offset = "0x9B797C0", VA = "0x189B7ADC0")]
		public IMOIWHUUQAP()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	[ConfigPropertyDrawer(typeof(quaternion))]
	internal class YHFIZUSEIWO : XEDXNKZYVUI<quaternion>
	{
		[Cpp2IlInjected.Token(Token = "0x200001A")]
		[CompilerGenerated]
		private sealed class EZRJCHBBPNO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000012")]
			public OLTTEFKKSOS FYSYPMHYNTJ;

			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
			public EZRJCHBBPNO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x9B7A830", Offset = "0x9B79230", VA = "0x189B7A830")]
			internal float XKICBHUCLDU()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x9B7AA40", Offset = "0x9B79440", VA = "0x189B7AA40")]
			internal void XKNIYONZUPD(float a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x9B7A790", Offset = "0x9B79190", VA = "0x189B7A790")]
			internal float XJXOGUGHSHC()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x9B7A810", Offset = "0x9B79210", VA = "0x189B7A810")]
			internal void XKCVEBAFBSL(float a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x9B7ABB0", Offset = "0x9B795B0", VA = "0x189B7ABB0")]
			internal float XLDDQIVRWXE()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x9B7ABD0", Offset = "0x9B795D0", VA = "0x189B7ABD0")]
			internal void XLIKNPPPGIN(float a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x9B7A630", Offset = "0x9B79030", VA = "0x189B7A630")]
			internal float ULGSSANBIWS(int a)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x9B7A280", Offset = "0x9B78C80", VA = "0x189B7A280")]
			internal void ANLXSJEAAEN(int a, float b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x9B7F760", Offset = "0x9B7E160", VA = "0x189B7F760", Slot = "5")]
		public override void KPDEGRBVGRC(OLTTEFKKSOS a, GVOHYNPXQKY b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x9B7FB60", Offset = "0x9B7E560", VA = "0x189B7FB60")]
		public YHFIZUSEIWO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[ConfigPropertyDrawer(typeof(uint))]
	internal class QNCIWSNDCAW : XEDXNKZYVUI<uint>
	{
		[Cpp2IlInjected.Token(Token = "0x200001C")]
		[CompilerGenerated]
		private sealed class EZRJCHBBPNO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000013")]
			public OLTTEFKKSOS FYSYPMHYNTJ;

			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
			public EZRJCHBBPNO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x9B7A840", Offset = "0x9B79240", VA = "0x189B7A840")]
			internal int XKICBHUCLDU()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x9B7AAF0", Offset = "0x9B794F0", VA = "0x189B7AAF0")]
			internal void XKNIYONZUPD(int a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x9B7E9E0", Offset = "0x9B7D3E0", VA = "0x189B7E9E0", Slot = "5")]
		public override void KPDEGRBVGRC(OLTTEFKKSOS a, GVOHYNPXQKY b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x9B7EB70", Offset = "0x9B7D570", VA = "0x189B7EB70")]
		public QNCIWSNDCAW()
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
	internal static class MNLJEAFKDVN
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x9B7B3E0", Offset = "0x9B79DE0", VA = "0x189B7B3E0")]
		public static void PMUEQVCEWIR(Type a, Type b)
		{
		}
	}
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	internal struct CommonProperties
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x9B78740", Offset = "0x9B77140", VA = "0x189B78740")]
		public static NativeList<NetworkProperty> EIRNUIEOGZW(NativeObjectLocalIdArray a, ETIHPWQRPDD b)
		{
			return default(NativeList<NetworkProperty>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x9B789C0", Offset = "0x9B773C0", VA = "0x189B789C0")]
		private static bool OMALMCJTLWZ(NetworkProperty a, NativeObjectLocalIdArray b)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public class PVBZRFYIALD : OLTTEFKKSOS, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private readonly NetworkProperty FYSYPMHYNTJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private readonly ETIHPWQRPDD MDCKNWROMTH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private readonly NativeObjectLocalIdArray GBDUVNBDQTO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private bool JHVCKNKMFHD;

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public string EDJPGUEQTOV
		{
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x9B7C320", Offset = "0x9B7AD20", VA = "0x189B7C320", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public bool OTBSLNJLAOX
		{
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x9B7C4A0", Offset = "0x9B7AEA0", VA = "0x189B7C4A0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public RRObject LZVBMOWJJUH
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x9B7C630", Offset = "0x9B7B030", VA = "0x189B7C630", Slot = "8")]
			get
			{
				return default(RRObject);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public Type AFHKRTOWHTU
		{
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x9B7C2D0", Offset = "0x9B7ACD0", VA = "0x189B7C2D0", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action DUGNYYFVJXI
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x9B7BFE0", Offset = "0x9B7A9E0", VA = "0x189B7BFE0", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x9B7C230", Offset = "0x9B7AC30", VA = "0x189B7C230", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x9B7C680", Offset = "0x9B7B080", VA = "0x189B7C680")]
		public PVBZRFYIALD(NativeObjectLocalIdArray a, NetworkProperty b, ETIHPWQRPDD c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x9B7C520", Offset = "0x9B7AF20", VA = "0x189B7C520")]
		private void UZZEWHPQXVX(BulkPropertyChangeData a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x9B7C150", Offset = "0x9B7AB50", VA = "0x189B7C150", Slot = "10")]
		public void Get(MutableRef value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x9B7C380", Offset = "0x9B7AD80", VA = "0x189B7C380", Slot = "11")]
		public void Set(ReadOnlyRef value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x9B7C080", Offset = "0x9B7AA80", VA = "0x189B7C080", Slot = "12")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[SpecificPropertyDrawer(1)]
	internal sealed class TPIGVMMUTKC : OTPFAMGNWSN, UVRTBVMCHQZ, EVXKIIZWLTD
	{
		[Cpp2IlInjected.Token(Token = "0x2000022")]
		[CompilerGenerated]
		private sealed class WNSCYXRXLPE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			public OLTTEFKKSOS FYSYPMHYNTJ;

			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
			public WNSCYXRXLPE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0x9B7F4C0", Offset = "0x9B7DEC0", VA = "0x189B7F4C0")]
			internal bool XKICBHUCLDU()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0x9B7F510", Offset = "0x9B7DF10", VA = "0x189B7F510")]
			internal string XKNIYONZUPD()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0x9B7F360", Offset = "0x9B7DD60", VA = "0x189B7F360")]
			internal void XJXOGUGHSHC(string a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0x9B7F3F0", Offset = "0x9B7DDF0", VA = "0x189B7F3F0")]
			internal string XKCVEBAFBSL()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public NetworkProperty CLXNOASTQRJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x9B7F220", Offset = "0x9B7DC20", VA = "0x189B7F220", Slot = "4")]
			get
			{
				return default(NetworkProperty);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x9B7EDE0", Offset = "0x9B7D7E0", VA = "0x189B7EDE0", Slot = "5")]
		public void KPDEGRBVGRC(OLTTEFKKSOS a, GVOHYNPXQKY b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
		public TPIGVMMUTKC()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	internal class PFVPUZKWSHE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private readonly ETIHPWQRPDD VGKUPTDRUIY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private readonly GVOHYNPXQKY FXKFBMOUGOU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private readonly Action<Candidate> GUYATQHZLHJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private readonly HashSet<BADPPXIQDIQ> XIABDLEJLCU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private readonly Dictionary<BADPPXIQDIQ, List<Candidate>> YZQAHIRZRHA;

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x9B7BED0", Offset = "0x9B7A8D0", VA = "0x189B7BED0")]
		public PFVPUZKWSHE(ETIHPWQRPDD a, GVOHYNPXQKY b, Action<Candidate> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x9B7BAF0", Offset = "0x9B7A4F0", VA = "0x189B7BAF0")]
		public void YGRLWYHZHPE(NativeList<Candidate> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x9B7B970", Offset = "0x9B7A370", VA = "0x189B7B970")]
		private void SAZEUGBPXKG(BADPPXIQDIQ a, Candidate b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x9B7B4A0", Offset = "0x9B79EA0", VA = "0x189B7B4A0")]
		public void KAYYYMGOJTI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x9B7B500", Offset = "0x9B79F00", VA = "0x189B7B500")]
		private void KKNJSHHQTPI(BADPPXIQDIQ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x9B7BE30", Offset = "0x9B7A830", VA = "0x189B7BE30")]
		private void ZRNPWFXVDUN(BADPPXIQDIQ a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	internal class PropertiesByType : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x2000025")]
		[CompilerGenerated]
		private sealed class ADMYPQGJUCT : IEnumerable<NetworkProperty>, IEnumerable, IEnumerator<NetworkProperty>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000024")]
			private int EQRCVSNPEJY;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x4000025")]
			private NetworkProperty RIDNXCOLQWN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000026")]
			private int QBMVXUNSGXZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000027")]
			public PropertiesByType TICTAVAJHVE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000028")]
			private Type ONBAXEIQBBQ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000029")]
			public Type WTNBTZQZRCX;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			private NativeParallelMultiHashMap<long, int>.Enumerator IRFNBWFCZWO;

			[Cpp2IlInjected.Token(Token = "0x1700000C")]
			private NetworkProperty ZPGFKWTLBGQ
			{
				[Cpp2IlInjected.Token(Token = "0x6000088")]
				[Cpp2IlInjected.Address(RVA = "0xDF7E10", Offset = "0xDF6810", VA = "0x180DF7E10", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return default(NetworkProperty);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000D")]
			private object IFKDFAMTOCU
			{
				[Cpp2IlInjected.Token(Token = "0x600008A")]
				[Cpp2IlInjected.Address(RVA = "0x9B78440", Offset = "0x9B76E40", VA = "0x189B78440", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0x15E64E0", Offset = "0x15E4EE0", VA = "0x1815E64E0")]
			[DebuggerHidden]
			public ADMYPQGJUCT(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x9B77FD0", Offset = "0x9B769D0", VA = "0x189B77FD0", Slot = "7")]
			[DebuggerHidden]
			private void GWJQUAHXPBV()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0x9B78150", Offset = "0x9B76B50", VA = "0x189B78150", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0x9B78490", Offset = "0x9B76E90", VA = "0x189B78490")]
			private void XNJKRYGWMCP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0x9B78060", Offset = "0x9B76A60", VA = "0x189B78060", Slot = "10")]
			[DebuggerHidden]
			private void JNSYTSSCILY()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008B")]
			[Cpp2IlInjected.Address(RVA = "0x9B780A0", Offset = "0x9B76AA0", VA = "0x189B780A0", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<NetworkProperty> MYCOGFDOMST()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x9B780A0", Offset = "0x9B76AA0", VA = "0x189B780A0", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator XDTPACFLBGX()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private static readonly Log WVPIFBCBMJC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private NativeParallelMultiHashMap<long, int> BDMDZVWNYLQ;

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x9B7C990", Offset = "0x9B7B390", VA = "0x189B7C990")]
		public PropertiesByType()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x9B7C770", Offset = "0x9B7B170", VA = "0x189B7C770")]
		[IteratorStateMachine(typeof(ADMYPQGJUCT))]
		public IEnumerable<NetworkProperty> DUHAMOCZKNY(Type a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x9B7C800", Offset = "0x9B7B200", VA = "0x189B7C800", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x9B7C880", Offset = "0x9B7B280", VA = "0x189B7C880")]
		private long IJMRTDAYQAR(NetworkProperty a)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x9B7C840", Offset = "0x9B7B240", VA = "0x189B7C840")]
		private long IJMRTDAYQAR(Type a)
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
		[Cpp2IlInjected.Address(RVA = "0x9B7CEA0", Offset = "0x9B7B8A0", VA = "0x189B7CEA0")]
		public PropertyBitmap(int count)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x9B7CD00", Offset = "0x9B7B700", VA = "0x189B7CD00")]
		public static PropertyBitmap XUEYKOESCUU(int a, NativeArray<NetworkProperty> b)
		{
			return default(PropertyBitmap);
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x9B7CE90", Offset = "0x9B7B890", VA = "0x189B7CE90")]
		public bool YRFMSBELFGK(int a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x9B7CCF0", Offset = "0x9B7B6F0", VA = "0x189B7CCF0")]
		public void Set(int index, bool value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x9B7CB80", Offset = "0x9B7B580", VA = "0x189B7CB80")]
		public bool All(NetworkProperty[] properties)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x9B7CC30", Offset = "0x9B7B630", VA = "0x189B7CC30")]
		public bool Any(NetworkProperty[] properties)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x9B7CCE0", Offset = "0x9B7B6E0", VA = "0x189B7CCE0", Slot = "4")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	internal class PropertyDrawerCandidates
	{
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private static readonly Log WVPIFBCBMJC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private readonly ETIHPWQRPDD VGKUPTDRUIY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private readonly List<EVXKIIZWLTD> BXFVPANZAIM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private readonly PropertiesByType BDMDZVWNYLQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private NativeParallelMultiHashMap<int, int> WMJEXZVWOIU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private NativeList<int> NEVLPSUYPQG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private bool JHVCKNKMFHD;

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public List<EVXKIIZWLTD> GFKCRIGZUSI
		{
			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(RVA = "0xD11BC0", Offset = "0xD105C0", VA = "0x180D11BC0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x9B7E0E0", Offset = "0x9B7CAE0", VA = "0x189B7E0E0")]
		public PropertyDrawerCandidates(ETIHPWQRPDD configPropertyService)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x9B7D3D0", Offset = "0x9B7BDD0", VA = "0x189B7D3D0")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x9B7DEB0", Offset = "0x9B7C8B0", VA = "0x189B7DEB0")]
		public void RCAUQMFXAYB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x9B7D8D0", Offset = "0x9B7C2D0", VA = "0x189B7D8D0")]
		public NativeList<Candidate> NEVCJIQTOYY(NativeArray<NetworkProperty> a)
		{
			return default(NativeList<Candidate>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x9B7CEF0", Offset = "0x9B7B8F0", VA = "0x189B7CEF0")]
		private bool ACPQWTSCWQW(EVXKIIZWLTD a, PropertyBitmap b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x3E17590", Offset = "0x3E15F90", VA = "0x183E17590")]
		private void ZTQRLSTRMKX<b, a>(Action<b, a> a) where b : EVXKIIZWLTD where a : Attribute
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x9B7D3A0", Offset = "0x9B7BDA0", VA = "0x189B7D3A0")]
		private void DTOODSSRUAP(Type a, Type b, Type c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x3E17220", Offset = "0x3E15C20", VA = "0x183E17220")]
		private c QVLKFQIAQHY<c>(Type a)
		{
			return (c)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x9B7D7E0", Offset = "0x9B7C1E0", VA = "0x189B7D7E0")]
		private int INZZEIPCQHP(EVXKIIZWLTD a, int b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x9B7D040", Offset = "0x9B7BA40", VA = "0x189B7D040")]
		private void BBZBDTKHMCT(UVRTBVMCHQZ a, ConfigPropertyDrawer b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x9B7D4B0", Offset = "0x9B7BEB0", VA = "0x189B7D4B0")]
		private void EGYBUYJDJQI(TSBYPLPHCRY a, MatchPropertyDrawer b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x9B7DDA0", Offset = "0x9B7C7A0", VA = "0x189B7DDA0")]
		private void NGNEVDVAPQA(IUPRSUSAXDM a, MultiPropertyDrawer b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x9B7D2D0", Offset = "0x9B7BCD0", VA = "0x189B7D2D0")]
		private void DKWPKKRBGHF(OTPFAMGNWSN a, SpecificPropertyDrawer b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	internal struct PropertyShadowing : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private readonly List<EVXKIIZWLTD> drawers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private NativeList<Candidate> unshadowed;

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public NativeList<Candidate> MLAHZYQZUPS
		{
			[Cpp2IlInjected.Token(Token = "0x60000A3")]
			[Cpp2IlInjected.Address(RVA = "0xF5EB10", Offset = "0xF5D510", VA = "0x180F5EB10")]
			get
			{
				return default(NativeList<Candidate>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x9B7E800", Offset = "0x9B7D200", VA = "0x189B7E800")]
		public PropertyShadowing(List<EVXKIIZWLTD> drawers, NativeArray<Candidate> candidates)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x9B7E220", Offset = "0x9B7CC20", VA = "0x189B7E220", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x9B7E500", Offset = "0x9B7CF00", VA = "0x189B7E500")]
		private NativeList<Candidate> VJEYZZPCPVY(NativeArray<Candidate> a)
		{
			return default(NativeList<Candidate>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x9B7E390", Offset = "0x9B7CD90", VA = "0x189B7E390")]
		private bool UHYHJJXAURR(EVXKIIZWLTD a, PropertyBitmap b, NetworkProperty c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x9B7E260", Offset = "0x9B7CC60", VA = "0x189B7E260")]
		private void SUDYYBCSCPY(EVXKIIZWLTD a, PropertyBitmap b, NetworkProperty c)
		{
		}
	}
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	internal struct SortCandidatesByPriority : IComparer<Candidate>
	{
		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x9B7ED80", Offset = "0x9B7D780", VA = "0x189B7ED80", Slot = "4")]
		public int Compare(Candidate a, Candidate b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x9B7ED90", Offset = "0x9B7D790", VA = "0x189B7ED90")]
		public static void Sort(NativeList<Candidate> candidates)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	[AttributeUsage(AttributeTargets.Class)]
	public class SpecificPropertyDrawer : ConfigPropertyDrawerBase
	{
		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x9B7EDD0", Offset = "0x9B7D7D0", VA = "0x189B7EDD0")]
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
