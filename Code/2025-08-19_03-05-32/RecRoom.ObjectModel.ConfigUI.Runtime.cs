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
		[Cpp2IlInjected.Address(RVA = "0x873CB30", Offset = "0x873B930", VA = "0x18873CB30", Slot = "4")]
		public override void PUOFOOQAOVA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xAE81C0", Offset = "0xAE6FC0", VA = "0x180AE81C0")]
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
		private int[] RBTJYOZOMSN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private ServiceBitset MXKLQTZDJEC;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public override string[] ServiceCategories
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0xAC0F90", Offset = "0xABFD90", VA = "0x180AC0F90", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x87419F0", Offset = "0x87407F0", VA = "0x1887419F0", Slot = "5")]
		public override void SetServiceCategoryIndices(List<int> globalFromLocalIndices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x8741060", Offset = "0x873FE60", VA = "0x188741060")]
		private void GQKVENIQDUS(IServiceRegistration a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x8741280", Offset = "0x8740080", VA = "0x188741280", Slot = "6")]
		public override void RegisterServices(IServiceRegistration registry, [In] ServiceBitsetFilter filter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x87412E0", Offset = "0x87400E0", VA = "0x1887412E0", Slot = "7")]
		public override void RegisterTypes(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x8741A10", Offset = "0x8740810", VA = "0x188741A10")]
		public _AssemblyIndex()
		{
		}
	}
}
namespace RecRoom.ObjectModel.ConfigUI
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	internal abstract class OETTPZEAPEG : DGRPIVZLBMA<Enum>, IYUNHAQBHDZ, SPOJVAXFSRE, ZJVFGBLXYUO
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "7")]
		public abstract bool XMBHCAAIEEE(Type a);

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x8739840", Offset = "0x8738640", VA = "0x188739840")]
		protected OETTPZEAPEG()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	internal abstract class DGRPIVZLBMA<a> : SPOJVAXFSRE, ZJVFGBLXYUO where a : Enum
	{
		[Cpp2IlInjected.Token(Token = "0x2000006")]
		[CompilerGenerated]
		private sealed class CEXFFSBJGFA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000004")]
			public FFDARHOGBEJ QUWHKNADAEG;

			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
			public CEXFFSBJGFA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x7396920", Offset = "0x7395720", VA = "0x187396920")]
			internal bool RVHDKAMIKIJ()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x42F9010", Offset = "0x42F7E10", VA = "0x1842F9010")]
		protected DGRPIVZLBMA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x42F8A10", Offset = "0x42F7810", VA = "0x1842F8A10")]
		protected void YEOFEDVLIXF(UJRLIAAELXE a, FFDARHOGBEJ b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x42F85E0", Offset = "0x42F73E0", VA = "0x1842F85E0")]
		protected void JUNQJBVSCSN(JPAWFGSZVHH<a> a, FFDARHOGBEJ b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "5")]
		public abstract void UILISBYTLBX(FFDARHOGBEJ a, PNYPUWDUCEP b);
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	internal abstract class COYZVVOKIAZ : LKLPCTZBKTN, ZJVFGBLXYUO
	{
		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public abstract NetworkProperty[] GDADGEWJWPG
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(Slot = "7")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public abstract NetworkProperty[] NXMDWIHKVNV
		{
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(Slot = "8")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(Slot = "9")]
		public abstract void UILISBYTLBX(FFDARHOGBEJ a, PZYWCASNVPM b, FMNNIKHOIUY c, PNYPUWDUCEP d);

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x36D57D0", Offset = "0x36D45D0", VA = "0x1836D57D0")]
		protected static b KABIMXHWVGF<b>(NativeObjectLocalIdArray a, NetworkProperty<b> b) where b : struct
		{
			return (b)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x36D55E0", Offset = "0x36D43E0", VA = "0x1836D55E0")]
		protected static void HYQAJASPLUQ<d>(NativeObjectLocalIdArray a, NetworkProperty<d> b, d c) where d : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
		protected COYZVVOKIAZ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	internal abstract class UTKDGEFDGBD<a> : SPOJVAXFSRE, ZJVFGBLXYUO where a : struct
	{
		[Cpp2IlInjected.Token(Token = "0x2000009")]
		[CompilerGenerated]
		private sealed class CEXFFSBJGFA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000005")]
			public FFDARHOGBEJ QUWHKNADAEG;

			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
			public CEXFFSBJGFA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x7396BA0", Offset = "0x73959A0", VA = "0x187396BA0")]
			internal bool RVHDKAMIKIJ()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x42F9010", Offset = "0x42F7E10", VA = "0x1842F9010")]
		protected UTKDGEFDGBD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x6425640", Offset = "0x6424440", VA = "0x186425640")]
		protected void YEOFEDVLIXF(UJRLIAAELXE a, FFDARHOGBEJ b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x6423A30", Offset = "0x6422830", VA = "0x186423A30")]
		protected void JUNQJBVSCSN(JPAWFGSZVHH<a> a, FFDARHOGBEJ b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(Slot = "5")]
		public abstract void UILISBYTLBX(FFDARHOGBEJ a, PNYPUWDUCEP b);
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[RegisterService(typeof(PZYWCASNVPM), new string[] { })]
	internal class ConfigUIService : PZYWCASNVPM, SEJXOWERIYM, RPNCXIAYMUG, KSWDMDRTSDM, ZDJVRLQDMXE
	{
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private static readonly Log IRJSVORGEBN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		[DependsOn]
		private FMNNIKHOIUY ALKAPIDGTOT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		[DependsOn]
		private PNYPUWDUCEP WJXXUXXZAKF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private PropertyDrawerCandidates QLBVWIAHWMU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private NativeObjectLocalIdArray ETYMVUGCWFB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private List<FFDARHOGBEJ> LHASNNCPTHK;

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public NativeObjectLocalIdArray WUEZEUAVBTR
		{
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x1711250", Offset = "0x1710050", VA = "0x181711250", Slot = "5")]
			get
			{
				return default(NativeObjectLocalIdArray);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x873B2B0", Offset = "0x873A0B0", VA = "0x18873B2B0", Slot = "6")]
		public void InitExternal(FCHQYTALOWK services)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x873B5D0", Offset = "0x873A3D0", VA = "0x18873B5D0", Slot = "7")]
		public void OCFMKRRHFHW()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x873AE40", Offset = "0x8739C40", VA = "0x18873AE40", Slot = "4")]
		public void DNXEEPMKNJF(NativeObjectLocalIdArray a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x873BC10", Offset = "0x873AA10", VA = "0x18873BC10")]
		private void ZKMCTTXMJBL(NativeObjectLocalIdArray a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x873B6D0", Offset = "0x873A4D0", VA = "0x18873B6D0")]
		private void PKIPMMCKCPI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x873B8D0", Offset = "0x873A6D0", VA = "0x18873B8D0")]
		private void UILISBYTLBX(Candidate a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x873BC80", Offset = "0x873AA80", VA = "0x18873BC80", Slot = "8")]
		private void ZZSCPZJHWHS(FCHQYTALOWK a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x1026850", Offset = "0x1025650", VA = "0x181026850", Slot = "9")]
		private void NNPEZXMTYDK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x873BD70", Offset = "0x873AB70", VA = "0x18873BD70")]
		public ConfigUIService()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[MatchPropertyDrawer(0)]
	internal class NVZHEITMFOW : OETTPZEAPEG
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x873CC30", Offset = "0x873BA30", VA = "0x18873CC30", Slot = "5")]
		public override void UILISBYTLBX(FFDARHOGBEJ a, PNYPUWDUCEP b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x873CCE0", Offset = "0x873BAE0", VA = "0x18873CCE0", Slot = "7")]
		public override bool XMBHCAAIEEE(Type a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x8739840", Offset = "0x8738640", VA = "0x188739840")]
		public NVZHEITMFOW()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[MatchPropertyDrawer(0)]
	internal class CDBYJZVWTJR : OETTPZEAPEG
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x87396F0", Offset = "0x87384F0", VA = "0x1887396F0", Slot = "5")]
		public override void UILISBYTLBX(FFDARHOGBEJ a, PNYPUWDUCEP b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x87397A0", Offset = "0x87385A0", VA = "0x1887397A0", Slot = "7")]
		public override bool XMBHCAAIEEE(Type a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x8739840", Offset = "0x8738640", VA = "0x188739840")]
		public CDBYJZVWTJR()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[ConfigPropertyDrawer(typeof(RenderableColor), 1)]
	internal class QARMJCIQVLY : DGRPIVZLBMA<RenderableColor>
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x873F410", Offset = "0x873E210", VA = "0x18873F410", Slot = "5")]
		public override void UILISBYTLBX(FFDARHOGBEJ a, PNYPUWDUCEP b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x873F560", Offset = "0x873E360", VA = "0x18873F560")]
		public QARMJCIQVLY()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[MultiPropertyDrawer(2)]
	internal class DCKMTFOJHRU : COYZVVOKIAZ
	{
		[Cpp2IlInjected.Token(Token = "0x200000F")]
		[CompilerGenerated]
		private sealed class EIGBKFCSTWH
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400000E")]
			public PZYWCASNVPM HZBNLRLMYCK;

			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
			public EIGBKFCSTWH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x873C3A0", Offset = "0x873B1A0", VA = "0x18873C3A0")]
			internal (int, int) YPXRRZUQELV()
			{
				return default((int, int));
			}

			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x873C2C0", Offset = "0x873B0C0", VA = "0x18873C2C0")]
			internal void YPSKUTASVAM((int color, int material) value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public override NetworkProperty[] GDADGEWJWPG
		{
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0xABD130", Offset = "0xABBF30", VA = "0x180ABD130", Slot = "7")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public override NetworkProperty[] NXMDWIHKVNV
		{
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0xAC0D20", Offset = "0xABFB20", VA = "0x180AC0D20", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x873BDF0", Offset = "0x873ABF0", VA = "0x18873BDF0", Slot = "9")]
		public override void UILISBYTLBX(FFDARHOGBEJ a, PZYWCASNVPM b, FMNNIKHOIUY c, PNYPUWDUCEP d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x873C1A0", Offset = "0x873AFA0", VA = "0x18873C1A0")]
		public DCKMTFOJHRU()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[ConfigPropertyDrawer(typeof(bool))]
	internal class UAXGVSRECHV : UTKDGEFDGBD<bool>
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x8740320", Offset = "0x873F120", VA = "0x188740320", Slot = "5")]
		public override void UILISBYTLBX(FFDARHOGBEJ a, PNYPUWDUCEP b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x87403B0", Offset = "0x873F1B0", VA = "0x1887403B0")]
		public UAXGVSRECHV()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[ConfigPropertyDrawer(typeof(FixedString32Bytes))]
	internal class CDXPTICPHZZ : UTKDGEFDGBD<FixedString32Bytes>
	{
		[Cpp2IlInjected.Token(Token = "0x2000012")]
		[CompilerGenerated]
		private sealed class WRZXCNXOEJD
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400000F")]
			public FFDARHOGBEJ QUWHKNADAEG;

			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
			public WRZXCNXOEJD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x8740EC0", Offset = "0x873FCC0", VA = "0x188740EC0")]
			internal string YPXRRZUQELV()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x8740D00", Offset = "0x873FB00", VA = "0x188740D00")]
			internal void YPSKUTASVAM(string a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x8739880", Offset = "0x8738680", VA = "0x188739880", Slot = "5")]
		public override void UILISBYTLBX(FFDARHOGBEJ a, PNYPUWDUCEP b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x8739A10", Offset = "0x8738810", VA = "0x188739A10")]
		public CDXPTICPHZZ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[ConfigPropertyDrawer(typeof(FixedString64Bytes))]
	internal class QZRAKVNCGZG : UTKDGEFDGBD<FixedString64Bytes>
	{
		[Cpp2IlInjected.Token(Token = "0x2000014")]
		[CompilerGenerated]
		private sealed class WRZXCNXOEJD
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000010")]
			public FFDARHOGBEJ QUWHKNADAEG;

			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
			public WRZXCNXOEJD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x8740E00", Offset = "0x873FC00", VA = "0x188740E00")]
			internal string YPXRRZUQELV()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x8740C20", Offset = "0x873FA20", VA = "0x188740C20")]
			internal void YPSKUTASVAM(string a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x873F5A0", Offset = "0x873E3A0", VA = "0x18873F5A0", Slot = "5")]
		public override void UILISBYTLBX(FFDARHOGBEJ a, PNYPUWDUCEP b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x873F730", Offset = "0x873E530", VA = "0x18873F730")]
		public QZRAKVNCGZG()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	[ConfigPropertyDrawer(typeof(float3))]
	internal class KUZWOXATPEQ : UTKDGEFDGBD<float3>
	{
		[Cpp2IlInjected.Token(Token = "0x2000016")]
		[CompilerGenerated]
		private sealed class WRZXCNXOEJD
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000011")]
			public FFDARHOGBEJ QUWHKNADAEG;

			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
			public WRZXCNXOEJD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x8740D80", Offset = "0x873FB80", VA = "0x188740D80")]
			internal float YPXRRZUQELV()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x8740D70", Offset = "0x873FB70", VA = "0x188740D70")]
			internal void YPSKUTASVAM(float a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x8740F40", Offset = "0x873FD40", VA = "0x188740F40")]
			internal float YQIFMNIKXIN()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x8740F30", Offset = "0x873FD30", VA = "0x188740F30")]
			internal void YQCYPGONNXE(float a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x8740FE0", Offset = "0x873FDE0", VA = "0x188740FE0")]
			internal float YQSTHAWFQFF()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x8740FD0", Offset = "0x873FDD0", VA = "0x188740FD0")]
			internal void YQNMJUCIGTW(float a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x8740860", Offset = "0x873F660", VA = "0x188740860")]
			internal float NDGTQHYTAPC(int a)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x8740B30", Offset = "0x873F930", VA = "0x188740B30")]
			internal void VGQUBUEEILJ(int a, float b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x873C6F0", Offset = "0x873B4F0", VA = "0x18873C6F0", Slot = "5")]
		public override void UILISBYTLBX(FFDARHOGBEJ a, PNYPUWDUCEP b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x873CAF0", Offset = "0x873B8F0", VA = "0x18873CAF0")]
		public KUZWOXATPEQ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[ConfigPropertyDrawer(typeof(float))]
	internal class AUQKZCPAEAT : UTKDGEFDGBD<float>
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x8739620", Offset = "0x8738420", VA = "0x188739620", Slot = "5")]
		public override void UILISBYTLBX(FFDARHOGBEJ a, PNYPUWDUCEP b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x87396B0", Offset = "0x87384B0", VA = "0x1887396B0")]
		public AUQKZCPAEAT()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[ConfigPropertyDrawer(typeof(int))]
	internal class VPZAEAZWPSU : UTKDGEFDGBD<int>
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x8740630", Offset = "0x873F430", VA = "0x188740630", Slot = "5")]
		public override void UILISBYTLBX(FFDARHOGBEJ a, PNYPUWDUCEP b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x87406C0", Offset = "0x873F4C0", VA = "0x1887406C0")]
		public VPZAEAZWPSU()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	[ConfigPropertyDrawer(typeof(quaternion))]
	internal class CETKWKFUDAL : UTKDGEFDGBD<quaternion>
	{
		[Cpp2IlInjected.Token(Token = "0x200001A")]
		[CompilerGenerated]
		private sealed class WRZXCNXOEJD
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000012")]
			public FFDARHOGBEJ QUWHKNADAEG;

			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
			public WRZXCNXOEJD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x8740DF0", Offset = "0x873FBF0", VA = "0x188740DF0")]
			internal float YPXRRZUQELV()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x8740C10", Offset = "0x873FA10", VA = "0x188740C10")]
			internal void YPSKUTASVAM(float a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x8740FB0", Offset = "0x873FDB0", VA = "0x188740FB0")]
			internal float YQIFMNIKXIN()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x8740F20", Offset = "0x873FD20", VA = "0x188740F20")]
			internal void YQCYPGONNXE(float a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x8741050", Offset = "0x873FE50", VA = "0x188741050")]
			internal float YQSTHAWFQFF()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x8740FC0", Offset = "0x873FDC0", VA = "0x188740FC0")]
			internal void YQNMJUCIGTW(float a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x8740700", Offset = "0x873F500", VA = "0x188740700")]
			internal float BADWPEUKPER(int a)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x87408D0", Offset = "0x873F6D0", VA = "0x1887408D0")]
			internal void OVTJSZEFSVM(int a, float b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x8739A50", Offset = "0x8738850", VA = "0x188739A50", Slot = "5")]
		public override void UILISBYTLBX(FFDARHOGBEJ a, PNYPUWDUCEP b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x8739E50", Offset = "0x8738C50", VA = "0x188739E50")]
		public CETKWKFUDAL()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[ConfigPropertyDrawer(typeof(uint))]
	internal class JVLHTQTEPBR : UTKDGEFDGBD<uint>
	{
		[Cpp2IlInjected.Token(Token = "0x200001C")]
		[CompilerGenerated]
		private sealed class WRZXCNXOEJD
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000013")]
			public FFDARHOGBEJ QUWHKNADAEG;

			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
			public WRZXCNXOEJD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x8740E80", Offset = "0x873FC80", VA = "0x188740E80")]
			internal int YPXRRZUQELV()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x8740CB0", Offset = "0x873FAB0", VA = "0x188740CB0")]
			internal void YPSKUTASVAM(int a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x873C520", Offset = "0x873B320", VA = "0x18873C520", Slot = "5")]
		public override void UILISBYTLBX(FFDARHOGBEJ a, PNYPUWDUCEP b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x873C6B0", Offset = "0x873B4B0", VA = "0x18873C6B0")]
		public JVLHTQTEPBR()
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
	internal static class OVVMKQANTXW
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x873D290", Offset = "0x873C090", VA = "0x18873D290")]
		public static void DVLSBBYPJIM(Type a, Type b)
		{
		}
	}
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	internal struct CommonProperties
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x873AAD0", Offset = "0x87398D0", VA = "0x18873AAD0")]
		public static NativeList<NetworkProperty> FJGFQPVZHWX(NativeObjectLocalIdArray a, FMNNIKHOIUY b)
		{
			return default(NativeList<NetworkProperty>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x873AD50", Offset = "0x8739B50", VA = "0x18873AD50")]
		private static bool MIOBINUXEDE(NetworkProperty a, NativeObjectLocalIdArray b)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public class CXIHUFNRUWU : FFDARHOGBEJ, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private readonly NetworkProperty QUWHKNADAEG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private readonly FMNNIKHOIUY VBWJQJXGZUO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private readonly NativeObjectLocalIdArray ETYMVUGCWFB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private bool IYRJDGYKKCM;

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public string JDIPTDKIYCA
		{
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x873A860", Offset = "0x8739660", VA = "0x18873A860", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public bool HDBUMCCJOKI
		{
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x873A790", Offset = "0x8739590", VA = "0x18873A790", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public RRObject SKBJBKLGHPG
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x873A810", Offset = "0x8739610", VA = "0x18873A810", Slot = "8")]
			get
			{
				return default(RRObject);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public Type QCFSUOQZRCP
		{
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x873A410", Offset = "0x8739210", VA = "0x18873A410", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action EAMAFNHRRNH
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x873A6F0", Offset = "0x87394F0", VA = "0x18873A6F0", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x873A650", Offset = "0x8739450", VA = "0x18873A650", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x873A9E0", Offset = "0x87397E0", VA = "0x18873A9E0")]
		public CXIHUFNRUWU(NativeObjectLocalIdArray a, NetworkProperty b, FMNNIKHOIUY c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x873A540", Offset = "0x8739340", VA = "0x18873A540")]
		private void IIDFPSQRQYO(BulkPropertyChangeData a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x873A460", Offset = "0x8739260", VA = "0x18873A460", Slot = "10")]
		public void Get(MutableRef value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x873A8C0", Offset = "0x87396C0", VA = "0x18873A8C0", Slot = "11")]
		public void Set(ReadOnlyRef value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x873A340", Offset = "0x8739140", VA = "0x18873A340", Slot = "12")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[SpecificPropertyDrawer(1)]
	internal sealed class CLZPOROWLCB : QTPTECFQKJU, SPOJVAXFSRE, ZJVFGBLXYUO
	{
		[Cpp2IlInjected.Token(Token = "0x2000022")]
		[CompilerGenerated]
		private sealed class URZEQUFXAGP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			public FFDARHOGBEJ QUWHKNADAEG;

			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
			public URZEQUFXAGP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0x8740470", Offset = "0x873F270", VA = "0x188740470")]
			internal bool YPXRRZUQELV()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0x87403F0", Offset = "0x873F1F0", VA = "0x1887403F0")]
			internal string YPSKUTASVAM()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0x87405A0", Offset = "0x873F3A0", VA = "0x1887405A0")]
			internal void YQIFMNIKXIN(string a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0x87404C0", Offset = "0x873F2C0", VA = "0x1887404C0")]
			internal string YQCYPGONNXE()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public NetworkProperty DETGYEJXBPU
		{
			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x8739E90", Offset = "0x8738C90", VA = "0x188739E90", Slot = "4")]
			get
			{
				return default(NetworkProperty);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x8739F00", Offset = "0x8738D00", VA = "0x188739F00", Slot = "5")]
		public void UILISBYTLBX(FFDARHOGBEJ a, PNYPUWDUCEP b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
		public CLZPOROWLCB()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	internal class STAFFZVMIUB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private readonly FMNNIKHOIUY ALKAPIDGTOT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private readonly PNYPUWDUCEP ZXASPTBUXVP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private readonly Action<Candidate> SRKZZUMZTTM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private readonly HashSet<TREUMRAPIDL> FWRNPZXCXDZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private readonly Dictionary<TREUMRAPIDL, List<Candidate>> GEUSGHYMCKN;

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x87401B0", Offset = "0x873EFB0", VA = "0x1887401B0")]
		public STAFFZVMIUB(FMNNIKHOIUY a, PNYPUWDUCEP b, Action<Candidate> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x873FDD0", Offset = "0x873EBD0", VA = "0x18873FDD0")]
		public void WJYAIRLHYAH(NativeList<Candidate> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x873FC50", Offset = "0x873EA50", VA = "0x18873FC50")]
		private void RVNNKACWNLP(TREUMRAPIDL a, Candidate b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x873FBF0", Offset = "0x873E9F0", VA = "0x18873FBF0")]
		public void OJPRAICHODL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x873F770", Offset = "0x873E570", VA = "0x18873F770")]
		private void NUPFOZYYPZD(TREUMRAPIDL a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x8740110", Offset = "0x873EF10", VA = "0x188740110")]
		private void YPTOJMRIRCI(TREUMRAPIDL a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	internal class PropertiesByType : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x2000025")]
		[CompilerGenerated]
		private sealed class OKNDSCKWLXK : IEnumerable<NetworkProperty>, IEnumerable, IEnumerator<NetworkProperty>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000024")]
			private int YSBBACYODYD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x4000025")]
			private NetworkProperty QSNUDDCEMPO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000026")]
			private int DQRPPGNAYPM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000027")]
			public PropertiesByType WFAEFPOXIOJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000028")]
			private Type EJZIZZKTKKL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000029")]
			public Type RCVPCJGVFGA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			private NativeParallelMultiHashMap<long, int>.Enumerator ZQJSAWQBUYL;

			[Cpp2IlInjected.Token(Token = "0x1700000C")]
			private NetworkProperty VWXJLVLAQNB
			{
				[Cpp2IlInjected.Token(Token = "0x6000088")]
				[Cpp2IlInjected.Address(RVA = "0xBBC350", Offset = "0xBBB150", VA = "0x180BBC350", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return default(NetworkProperty);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000D")]
			private object OXAJVRVSDJL
			{
				[Cpp2IlInjected.Token(Token = "0x600008A")]
				[Cpp2IlInjected.Address(RVA = "0x873D240", Offset = "0x873C040", VA = "0x18873D240", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0x15A5740", Offset = "0x15A4540", VA = "0x1815A5740")]
			[DebuggerHidden]
			public OKNDSCKWLXK(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x873CDC0", Offset = "0x873BBC0", VA = "0x18873CDC0", Slot = "7")]
			[DebuggerHidden]
			private void HQYJSAUBZEC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0x873CEA0", Offset = "0x873BCA0", VA = "0x18873CEA0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0x873CE50", Offset = "0x873BC50", VA = "0x18873CE50")]
			private void LKISUJFCFYE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0x873CD80", Offset = "0x873BB80", VA = "0x18873CD80", Slot = "10")]
			[DebuggerHidden]
			private void EYXYBZSNHNN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008B")]
			[Cpp2IlInjected.Address(RVA = "0x873D190", Offset = "0x873BF90", VA = "0x18873D190", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<NetworkProperty> TINNDSEGIXC()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x873D190", Offset = "0x873BF90", VA = "0x18873D190", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator UYQUPSIMXFE()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private static readonly Log IRJSVORGEBN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private NativeParallelMultiHashMap<long, int> ZESLKMWJYKT;

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x873D560", Offset = "0x873C360", VA = "0x18873D560")]
		public PropertiesByType()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x873D450", Offset = "0x873C250", VA = "0x18873D450")]
		[IteratorStateMachine(typeof(OKNDSCKWLXK))]
		public IEnumerable<NetworkProperty> XPSRVWCKPTX(Type a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x873D350", Offset = "0x873C150", VA = "0x18873D350", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x873D3D0", Offset = "0x873C1D0", VA = "0x18873D3D0")]
		private long QDFFFTUIMCE(NetworkProperty a)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x873D390", Offset = "0x873C190", VA = "0x18873D390")]
		private long QDFFFTUIMCE(Type a)
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
		[Cpp2IlInjected.Address(RVA = "0x873DA70", Offset = "0x873C870", VA = "0x18873DA70")]
		public PropertyBitmap(int count)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x873D8B0", Offset = "0x873C6B0", VA = "0x18873D8B0")]
		public static PropertyBitmap BJXPAHBXMPJ(int a, NativeArray<NetworkProperty> b)
		{
			return default(PropertyBitmap);
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x873DA50", Offset = "0x873C850", VA = "0x18873DA50")]
		public bool LMWTKUAHZDP(int a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x873DA60", Offset = "0x873C860", VA = "0x18873DA60")]
		public void Set(int index, bool value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x873D750", Offset = "0x873C550", VA = "0x18873D750")]
		public bool All(NetworkProperty[] properties)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x873D800", Offset = "0x873C600", VA = "0x18873D800")]
		public bool Any(NetworkProperty[] properties)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x873DA40", Offset = "0x873C840", VA = "0x18873DA40", Slot = "4")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	internal class PropertyDrawerCandidates
	{
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private static readonly Log IRJSVORGEBN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private readonly FMNNIKHOIUY ALKAPIDGTOT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private readonly List<ZJVFGBLXYUO> OWKJBDLELRZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private readonly PropertiesByType ZESLKMWJYKT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private NativeParallelMultiHashMap<int, int> DDPOAZIUTQT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private NativeList<int> KFIESRLSWLB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private bool IYRJDGYKKCM;

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public List<ZJVFGBLXYUO> GNCLSGGBNAT
		{
			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(RVA = "0xAC0D20", Offset = "0xABFB20", VA = "0x180AC0D20")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x873ECA0", Offset = "0x873DAA0", VA = "0x18873ECA0")]
		public PropertyDrawerCandidates(FMNNIKHOIUY configPropertyService)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x873E1F0", Offset = "0x873CFF0", VA = "0x18873E1F0")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x873E2D0", Offset = "0x873D0D0", VA = "0x18873E2D0")]
		public void FISAQRQBNDE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x873DAC0", Offset = "0x873C8C0", VA = "0x18873DAC0")]
		public NativeList<Candidate> AIGDEPNBAFF(NativeArray<NetworkProperty> a)
		{
			return default(NativeList<Candidate>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x873DF90", Offset = "0x873CD90", VA = "0x18873DF90")]
		private bool ANMRWXSQATH(ZJVFGBLXYUO a, PropertyBitmap b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x3BE6280", Offset = "0x3BE5080", VA = "0x183BE6280")]
		private void EKLBQDMNZTO<b, a>(Action<b, a> a) where b : ZJVFGBLXYUO where a : Attribute
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x873EBF0", Offset = "0x873D9F0", VA = "0x18873EBF0")]
		private void YSGREUQOGKG(Type a, Type b, Type c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x3BE5F10", Offset = "0x3BE4D10", VA = "0x183BE5F10")]
		private c BOXMUCAITFB<c>(Type a)
		{
			return (c)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x873E870", Offset = "0x873D670", VA = "0x18873E870")]
		private int RZURMLZMBLU(ZJVFGBLXYUO a, int b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x873E960", Offset = "0x873D760", VA = "0x18873E960")]
		private void WPAUMTIHULY(SPOJVAXFSRE a, ConfigPropertyDrawer b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x873E540", Offset = "0x873D340", VA = "0x18873E540")]
		private void RNTEMNUHTIX(IYUNHAQBHDZ a, MatchPropertyDrawer b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x873E0E0", Offset = "0x873CEE0", VA = "0x18873E0E0")]
		private void CIPCJMYCDCL(LKLPCTZBKTN a, MultiPropertyDrawer b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x873E470", Offset = "0x873D270", VA = "0x18873E470")]
		private void GFTAVDRGWTQ(QTPTECFQKJU a, SpecificPropertyDrawer b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	internal struct PropertyShadowing : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private readonly List<ZJVFGBLXYUO> drawers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private NativeList<Candidate> unshadowed;

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public NativeList<Candidate> EPRDDTTICPP
		{
			[Cpp2IlInjected.Token(Token = "0x60000A3")]
			[Cpp2IlInjected.Address(RVA = "0xB72150", Offset = "0xB70F50", VA = "0x180B72150")]
			get
			{
				return default(NativeList<Candidate>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x873F3C0", Offset = "0x873E1C0", VA = "0x18873F3C0")]
		public PropertyShadowing(List<ZJVFGBLXYUO> drawers, NativeArray<Candidate> candidates)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x873EDE0", Offset = "0x873DBE0", VA = "0x18873EDE0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x873EF50", Offset = "0x873DD50", VA = "0x18873EF50")]
		private NativeList<Candidate> PTJZTLZUBTP(NativeArray<Candidate> a)
		{
			return default(NativeList<Candidate>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x873F250", Offset = "0x873E050", VA = "0x18873F250")]
		private bool RTWEUPELPPA(ZJVFGBLXYUO a, PropertyBitmap b, NetworkProperty c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x873EE20", Offset = "0x873DC20", VA = "0x18873EE20")]
		private void POXURDBGNEB(ZJVFGBLXYUO a, PropertyBitmap b, NetworkProperty c)
		{
		}
	}
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	internal struct SortCandidatesByPriority : IComparer<Candidate>
	{
		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x87402C0", Offset = "0x873F0C0", VA = "0x1887402C0", Slot = "4")]
		public int Compare(Candidate a, Candidate b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x87402D0", Offset = "0x873F0D0", VA = "0x1887402D0")]
		public static void Sort(NativeList<Candidate> candidates)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	[AttributeUsage(AttributeTargets.Class)]
	public class SpecificPropertyDrawer : ConfigPropertyDrawerBase
	{
		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x8740310", Offset = "0x873F110", VA = "0x188740310")]
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
