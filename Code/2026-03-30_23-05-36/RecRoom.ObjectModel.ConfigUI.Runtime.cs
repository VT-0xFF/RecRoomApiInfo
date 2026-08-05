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
		[Cpp2IlInjected.Address(RVA = "0x86CF680", Offset = "0x86CE480", VA = "0x1886CF680", Slot = "4")]
		public override void DELFABVRANX()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xAF1770", Offset = "0xAF0570", VA = "0x180AF1770")]
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
		private int[] TDVEOKFWPNC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private ServiceBitset GMAWWHUIGYL;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public override string[] ServiceCategories
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0xACC820", Offset = "0xACB620", VA = "0x180ACC820", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x86D4F80", Offset = "0x86D3D80", VA = "0x1886D4F80", Slot = "5")]
		public override void SetServiceCategoryIndices(List<int> globalFromLocalIndices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x86D4610", Offset = "0x86D3410", VA = "0x1886D4610")]
		private void BUNBWTHGJFJ(IServiceRegistration a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x86D4830", Offset = "0x86D3630", VA = "0x1886D4830", Slot = "6")]
		public override void RegisterServices(IServiceRegistration registry, [In] ServiceBitsetFilter filter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x86D4890", Offset = "0x86D3690", VA = "0x1886D4890", Slot = "7")]
		public override void RegisterTypes(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x86D4FA0", Offset = "0x86D3DA0", VA = "0x1886D4FA0")]
		public _AssemblyIndex()
		{
		}
	}
}
namespace RecRoom.ObjectModel.ConfigUI
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	internal abstract class SZNBJAKEJOX : FTOPMSTGZRV<Enum>, TTVLQLMMAQI, IBUKJZPYONR, RQJRQQSLPUX
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "7")]
		public abstract bool TNRPPWKXSLP(Type a);

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x86CCBE0", Offset = "0x86CB9E0", VA = "0x1886CCBE0")]
		protected SZNBJAKEJOX()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	internal abstract class FTOPMSTGZRV<a> : IBUKJZPYONR, RQJRQQSLPUX where a : Enum
	{
		[Cpp2IlInjected.Token(Token = "0x2000006")]
		[CompilerGenerated]
		private sealed class NHMYBFFRWAV
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000004")]
			public IRJBRFJRFOU LGMNIYOWPNT;

			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0xACC5C0", Offset = "0xACB3C0", VA = "0x180ACC5C0")]
			public NHMYBFFRWAV()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x59EE3C0", Offset = "0x59ED1C0", VA = "0x1859EE3C0")]
			internal bool SDFLYNHXEBK()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x4E8E810", Offset = "0x4E8D610", VA = "0x184E8E810")]
		protected FTOPMSTGZRV()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x4E8E410", Offset = "0x4E8D210", VA = "0x184E8E410")]
		protected void GMKQWPPWVUW(OXGMWZBFBSR a, IRJBRFJRFOU b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x4E8DDF0", Offset = "0x4E8CBF0", VA = "0x184E8DDF0")]
		protected void ADGCXWYOUZO(VFNHIPSORJI<a> a, IRJBRFJRFOU b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "5")]
		public abstract void VJNAEYZRICK(IRJBRFJRFOU a, RFNNDSOQVXM b);
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	internal abstract class QOKZHEIMMSE : DUEBFIGOQEY, RQJRQQSLPUX
	{
		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public abstract NetworkProperty[] TCVXHBEJMFJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(Slot = "7")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public abstract NetworkProperty[] FEFNGHPMXCC
		{
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(Slot = "8")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(Slot = "9")]
		public abstract void VJNAEYZRICK(IRJBRFJRFOU a, GBHTZALYUNN b, VLCPTDEKWHR c, RFNNDSOQVXM d);

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x3A0C480", Offset = "0x3A0B280", VA = "0x183A0C480")]
		protected static b ZIHIEWFZUGG<b>(NativeObjectLocalIdArray a, NetworkProperty<b> b) where b : struct
		{
			return (b)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x3A0C290", Offset = "0x3A0B090", VA = "0x183A0C290")]
		protected static void QRLQLQJAPEX<d>(NativeObjectLocalIdArray a, NetworkProperty<d> b, d c) where d : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0xACC5C0", Offset = "0xACB3C0", VA = "0x180ACC5C0")]
		protected QOKZHEIMMSE()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	internal abstract class VXJXDKRWTSG<a> : IBUKJZPYONR, RQJRQQSLPUX where a : struct
	{
		[Cpp2IlInjected.Token(Token = "0x2000009")]
		[CompilerGenerated]
		private sealed class NHMYBFFRWAV
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000005")]
			public IRJBRFJRFOU LGMNIYOWPNT;

			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0xACC5C0", Offset = "0xACB3C0", VA = "0x180ACC5C0")]
			public NHMYBFFRWAV()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x59EE550", Offset = "0x59ED350", VA = "0x1859EE550")]
			internal bool SDFLYNHXEBK()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x4E8E810", Offset = "0x4E8D610", VA = "0x184E8E810")]
		protected VXJXDKRWTSG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x64E5740", Offset = "0x64E4540", VA = "0x1864E5740")]
		protected void GMKQWPPWVUW(OXGMWZBFBSR a, IRJBRFJRFOU b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x64E4520", Offset = "0x64E3320", VA = "0x1864E4520")]
		protected void ADGCXWYOUZO(VFNHIPSORJI<a> a, IRJBRFJRFOU b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(Slot = "5")]
		public abstract void VJNAEYZRICK(IRJBRFJRFOU a, RFNNDSOQVXM b);
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[RegisterService(typeof(GBHTZALYUNN), new string[] { })]
	internal class ConfigUIService : GBHTZALYUNN, PKZSUEEEGNR, CZJXGPXNOFX, KCNRTBNFQOT, XREDDEZXVJN
	{
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private static readonly Log VYIZTFKBMQC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		[DependsOn]
		private VLCPTDEKWHR HSGEEFGIBRY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		[DependsOn]
		private RFNNDSOQVXM OJQYJZNQDDU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private PropertyDrawerCandidates EVNUXZZVALN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private NativeObjectLocalIdArray LZEEDENZAUG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private List<IRJBRFJRFOU> JWBBCKSPDYZ;

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public NativeObjectLocalIdArray LAVNZNQITFY
		{
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x14FF6E0", Offset = "0x14FE4E0", VA = "0x1814FF6E0", Slot = "5")]
			get
			{
				return default(NativeObjectLocalIdArray);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x86CD1D0", Offset = "0x86CBFD0", VA = "0x1886CD1D0", Slot = "6")]
		public void InitExternal(ODEDMYTJIPB services)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x86CDA90", Offset = "0x86CC890", VA = "0x1886CDA90", Slot = "7")]
		public void VZXWUYBQFJB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x86CDB90", Offset = "0x86CC990", VA = "0x1886CDB90", Slot = "4")]
		public void YRWEZUNFXHS(NativeObjectLocalIdArray a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x86CD4F0", Offset = "0x86CC2F0", VA = "0x1886CD4F0")]
		private void NYHGGSWCSHY(NativeObjectLocalIdArray a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x86CD560", Offset = "0x86CC360", VA = "0x1886CD560")]
		private void SIMOHWULCOR()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x86CD750", Offset = "0x86CC550", VA = "0x1886CD750")]
		private void VJNAEYZRICK(Candidate a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x86CD160", Offset = "0x86CBF60", VA = "0x1886CD160", Slot = "8")]
		private void GXDLTINPSCT(ODEDMYTJIPB a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0xE07220", Offset = "0xE06020", VA = "0x180E07220", Slot = "9")]
		private void WXTEKSAVTDN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x86CE090", Offset = "0x86CCE90", VA = "0x1886CE090")]
		public ConfigUIService()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[MatchPropertyDrawer(0)]
	internal class TROWEXHDAGJ : SZNBJAKEJOX
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x86D2A50", Offset = "0x86D1850", VA = "0x1886D2A50", Slot = "5")]
		public override void VJNAEYZRICK(IRJBRFJRFOU a, RFNNDSOQVXM b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x86D29B0", Offset = "0x86D17B0", VA = "0x1886D29B0", Slot = "7")]
		public override bool TNRPPWKXSLP(Type a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x86CCBE0", Offset = "0x86CB9E0", VA = "0x1886CCBE0")]
		public TROWEXHDAGJ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[MatchPropertyDrawer(0)]
	internal class AJOCPTPHASO : SZNBJAKEJOX
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x86CCB30", Offset = "0x86CB930", VA = "0x1886CCB30", Slot = "5")]
		public override void VJNAEYZRICK(IRJBRFJRFOU a, RFNNDSOQVXM b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x86CCA90", Offset = "0x86CB890", VA = "0x1886CCA90", Slot = "7")]
		public override bool TNRPPWKXSLP(Type a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x86CCBE0", Offset = "0x86CB9E0", VA = "0x1886CCBE0")]
		public AJOCPTPHASO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[ConfigPropertyDrawer(typeof(RenderableColor), 1)]
	internal class IFCYWRJZTIT : FTOPMSTGZRV<RenderableColor>
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x86CF2C0", Offset = "0x86CE0C0", VA = "0x1886CF2C0", Slot = "5")]
		public override void VJNAEYZRICK(IRJBRFJRFOU a, RFNNDSOQVXM b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x86CF410", Offset = "0x86CE210", VA = "0x1886CF410")]
		public IFCYWRJZTIT()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[MultiPropertyDrawer(2)]
	internal class TPZBTXVMOPV : QOKZHEIMMSE
	{
		[Cpp2IlInjected.Token(Token = "0x200000F")]
		[CompilerGenerated]
		private sealed class SEHYOLKZJRW
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400000E")]
			public GBHTZALYUNN DLMZJGTUVGT;

			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0xACC5C0", Offset = "0xACB3C0", VA = "0x180ACC5C0")]
			public SEHYOLKZJRW()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x86D1FE0", Offset = "0x86D0DE0", VA = "0x1886D1FE0")]
			internal (int, int) UUAWBLEWUDC()
			{
				return default((int, int));
			}

			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x86D2250", Offset = "0x86D1050", VA = "0x1886D2250")]
			internal void UUGCYRYUDOL((int color, int material) value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public override NetworkProperty[] TCVXHBEJMFJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0xACA860", Offset = "0xAC9660", VA = "0x180ACA860", Slot = "7")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public override NetworkProperty[] FEFNGHPMXCC
		{
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0xAC91C0", Offset = "0xAC7FC0", VA = "0x180AC91C0", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x86D24D0", Offset = "0x86D12D0", VA = "0x1886D24D0", Slot = "9")]
		public override void VJNAEYZRICK(IRJBRFJRFOU a, GBHTZALYUNN b, VLCPTDEKWHR c, RFNNDSOQVXM d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x86D2880", Offset = "0x86D1680", VA = "0x1886D2880")]
		public TPZBTXVMOPV()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[ConfigPropertyDrawer(typeof(bool))]
	internal class SFDTFKNNHYA : VXJXDKRWTSG<bool>
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x86D23A0", Offset = "0x86D11A0", VA = "0x1886D23A0", Slot = "5")]
		public override void VJNAEYZRICK(IRJBRFJRFOU a, RFNNDSOQVXM b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x86D2430", Offset = "0x86D1230", VA = "0x1886D2430")]
		public SFDTFKNNHYA()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[ConfigPropertyDrawer(typeof(FixedString32Bytes))]
	internal class CBSGURLHPCK : VXJXDKRWTSG<FixedString32Bytes>
	{
		[Cpp2IlInjected.Token(Token = "0x2000012")]
		[CompilerGenerated]
		private sealed class ZIQJURSSQGO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400000F")]
			public IRJBRFJRFOU LGMNIYOWPNT;

			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0xACC5C0", Offset = "0xACB3C0", VA = "0x180ACC5C0")]
			public ZIQJURSSQGO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x86D3F10", Offset = "0x86D2D10", VA = "0x1886D3F10")]
			internal string UUAWBLEWUDC()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x86D3FB0", Offset = "0x86D2DB0", VA = "0x1886D3FB0")]
			internal void UUGCYRYUDOL(string a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x86CCC20", Offset = "0x86CBA20", VA = "0x1886CCC20", Slot = "5")]
		public override void VJNAEYZRICK(IRJBRFJRFOU a, RFNNDSOQVXM b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x86CCDB0", Offset = "0x86CBBB0", VA = "0x1886CCDB0")]
		public CBSGURLHPCK()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[ConfigPropertyDrawer(typeof(FixedString64Bytes))]
	internal class QHTMXASLYFX : VXJXDKRWTSG<FixedString64Bytes>
	{
		[Cpp2IlInjected.Token(Token = "0x2000014")]
		[CompilerGenerated]
		private sealed class ZIQJURSSQGO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000010")]
			public IRJBRFJRFOU LGMNIYOWPNT;

			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0xACC5C0", Offset = "0xACB3C0", VA = "0x180ACC5C0")]
			public ZIQJURSSQGO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x86D3E20", Offset = "0x86D2C20", VA = "0x1886D3E20")]
			internal string UUAWBLEWUDC()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x86D4080", Offset = "0x86D2E80", VA = "0x1886D4080")]
			internal void UUGCYRYUDOL(string a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x86D19D0", Offset = "0x86D07D0", VA = "0x1886D19D0", Slot = "5")]
		public override void VJNAEYZRICK(IRJBRFJRFOU a, RFNNDSOQVXM b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x86D1B60", Offset = "0x86D0960", VA = "0x1886D1B60")]
		public QHTMXASLYFX()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	[ConfigPropertyDrawer(typeof(float3))]
	internal class EIBCQIKLRFV : VXJXDKRWTSG<float3>
	{
		[Cpp2IlInjected.Token(Token = "0x2000016")]
		[CompilerGenerated]
		private sealed class ZIQJURSSQGO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000011")]
			public IRJBRFJRFOU LGMNIYOWPNT;

			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0xACC5C0", Offset = "0xACB3C0", VA = "0x180ACC5C0")]
			public ZIQJURSSQGO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x86D3EA0", Offset = "0x86D2CA0", VA = "0x1886D3EA0")]
			internal float UUAWBLEWUDC()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x86D4020", Offset = "0x86D2E20", VA = "0x1886D4020")]
			internal void UUGCYRYUDOL(float a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x86D4130", Offset = "0x86D2F30", VA = "0x1886D4130")]
			internal float UULJVYSRMZU()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x86D41B0", Offset = "0x86D2FB0", VA = "0x1886D41B0")]
			internal void UUQQTFMOWLD(float a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x86D41D0", Offset = "0x86D2FD0", VA = "0x1886D41D0")]
			internal float UUVXQMGMFWM()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x86D4250", Offset = "0x86D3050", VA = "0x1886D4250")]
			internal void UVBENTAJPHV(float a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x86D44C0", Offset = "0x86D32C0", VA = "0x1886D44C0")]
			internal float ZGYUYYNQSGX(int a)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x86D4530", Offset = "0x86D3330", VA = "0x1886D4530")]
			internal void ZIHWGMTMWPW(int a, float b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x86CE1E0", Offset = "0x86CCFE0", VA = "0x1886CE1E0", Slot = "5")]
		public override void VJNAEYZRICK(IRJBRFJRFOU a, RFNNDSOQVXM b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x86CE5E0", Offset = "0x86CD3E0", VA = "0x1886CE5E0")]
		public EIBCQIKLRFV()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[ConfigPropertyDrawer(typeof(float))]
	internal class MKPRIMDRPDU : VXJXDKRWTSG<float>
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x86CF840", Offset = "0x86CE640", VA = "0x1886CF840", Slot = "5")]
		public override void VJNAEYZRICK(IRJBRFJRFOU a, RFNNDSOQVXM b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x86CF8D0", Offset = "0x86CE6D0", VA = "0x1886CF8D0")]
		public MKPRIMDRPDU()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[ConfigPropertyDrawer(typeof(int))]
	internal class DCDRJOMLMEB : VXJXDKRWTSG<int>
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x86CE110", Offset = "0x86CCF10", VA = "0x1886CE110", Slot = "5")]
		public override void VJNAEYZRICK(IRJBRFJRFOU a, RFNNDSOQVXM b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x86CE1A0", Offset = "0x86CCFA0", VA = "0x1886CE1A0")]
		public DCDRJOMLMEB()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	[ConfigPropertyDrawer(typeof(quaternion))]
	internal class QVYAIQMWKGI : VXJXDKRWTSG<quaternion>
	{
		[Cpp2IlInjected.Token(Token = "0x200001A")]
		[CompilerGenerated]
		private sealed class ZIQJURSSQGO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000012")]
			public IRJBRFJRFOU LGMNIYOWPNT;

			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0xACC5C0", Offset = "0xACB3C0", VA = "0x180ACC5C0")]
			public ZIQJURSSQGO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x86D3E10", Offset = "0x86D2C10", VA = "0x1886D3E10")]
			internal float UUAWBLEWUDC()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x86D4110", Offset = "0x86D2F10", VA = "0x1886D4110")]
			internal void UUGCYRYUDOL(float a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x86D4120", Offset = "0x86D2F20", VA = "0x1886D4120")]
			internal float UULJVYSRMZU()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x86D41A0", Offset = "0x86D2FA0", VA = "0x1886D41A0")]
			internal void UUQQTFMOWLD(float a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x86D41C0", Offset = "0x86D2FC0", VA = "0x1886D41C0")]
			internal float UUVXQMGMFWM()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x86D4240", Offset = "0x86D3040", VA = "0x1886D4240")]
			internal void UVBENTAJPHV(float a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x86D3CB0", Offset = "0x86D2AB0", VA = "0x1886D3CB0")]
			internal float FEAFSWKVASU(int a)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x86D4260", Offset = "0x86D3060", VA = "0x1886D4260")]
			internal void XEQZCLJULED(int a, float b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x86D1BA0", Offset = "0x86D09A0", VA = "0x1886D1BA0", Slot = "5")]
		public override void VJNAEYZRICK(IRJBRFJRFOU a, RFNNDSOQVXM b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x86D1FA0", Offset = "0x86D0DA0", VA = "0x1886D1FA0")]
		public QVYAIQMWKGI()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[ConfigPropertyDrawer(typeof(uint))]
	internal class TXWSYKQKNOE : VXJXDKRWTSG<uint>
	{
		[Cpp2IlInjected.Token(Token = "0x200001C")]
		[CompilerGenerated]
		private sealed class ZIQJURSSQGO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000013")]
			public IRJBRFJRFOU LGMNIYOWPNT;

			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0xACC5C0", Offset = "0xACB3C0", VA = "0x180ACC5C0")]
			public ZIQJURSSQGO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x86D3F70", Offset = "0x86D2D70", VA = "0x1886D3F70")]
			internal int UUAWBLEWUDC()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x86D4030", Offset = "0x86D2E30", VA = "0x1886D4030")]
			internal void UUGCYRYUDOL(int a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x86D2B00", Offset = "0x86D1900", VA = "0x1886D2B00", Slot = "5")]
		public override void VJNAEYZRICK(IRJBRFJRFOU a, RFNNDSOQVXM b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x86D2C90", Offset = "0x86D1A90", VA = "0x1886D2C90")]
		public TXWSYKQKNOE()
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
	internal static class MBFRJXWNKXT
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x86CF780", Offset = "0x86CE580", VA = "0x1886CF780")]
		public static void UHLEABNKZTF(Type a, Type b)
		{
		}
	}
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	internal struct CommonProperties
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x86CCDF0", Offset = "0x86CBBF0", VA = "0x1886CCDF0")]
		public static NativeList<NetworkProperty> HFVCLJGBBMS(NativeObjectLocalIdArray a, VLCPTDEKWHR b)
		{
			return default(NativeList<NetworkProperty>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x86CD070", Offset = "0x86CBE70", VA = "0x1886CD070")]
		private static bool OBGCKFEDCET(NetworkProperty a, NativeObjectLocalIdArray b)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public class FMOJSZUKOMT : IRJBRFJRFOU, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private readonly NetworkProperty LGMNIYOWPNT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private readonly VLCPTDEKWHR RYLGWZFCAMD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private readonly NativeObjectLocalIdArray LZEEDENZAUG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private bool BRKISHTLOGT;

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public string CANLOGIQDOT
		{
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x86CEFD0", Offset = "0x86CDDD0", VA = "0x1886CEFD0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public bool QAUIGFKLNKJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x86CF150", Offset = "0x86CDF50", VA = "0x1886CF150", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public RRObject YMLTDDRQNEJ
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x86CED80", Offset = "0x86CDB80", VA = "0x1886CED80", Slot = "8")]
			get
			{
				return default(RRObject);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public Type ULTKTFGCAFO
		{
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x86CEE70", Offset = "0x86CDC70", VA = "0x1886CEE70", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action BIGHUXLXUTG
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x86CEDD0", Offset = "0x86CDBD0", VA = "0x1886CEDD0", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x86CECE0", Offset = "0x86CDAE0", VA = "0x1886CECE0", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x86CF1D0", Offset = "0x86CDFD0", VA = "0x1886CF1D0")]
		public FMOJSZUKOMT(NativeObjectLocalIdArray a, NetworkProperty b, VLCPTDEKWHR c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x86CEEC0", Offset = "0x86CDCC0", VA = "0x1886CEEC0")]
		private void QRHJESZJIHB(BulkPropertyChangeData a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x86CEC00", Offset = "0x86CDA00", VA = "0x1886CEC00", Slot = "10")]
		public void Get(MutableRef value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x86CF030", Offset = "0x86CDE30", VA = "0x1886CF030", Slot = "11")]
		public void Set(ReadOnlyRef value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x86CEB30", Offset = "0x86CD930", VA = "0x1886CEB30", Slot = "12")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[SpecificPropertyDrawer(1)]
	internal sealed class UARGEVPJCAY : ICFVMXYIQDJ, IBUKJZPYONR, RQJRQQSLPUX
	{
		[Cpp2IlInjected.Token(Token = "0x2000022")]
		[CompilerGenerated]
		private sealed class IOBBVAODQCE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			public IRJBRFJRFOU LGMNIYOWPNT;

			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0xACC5C0", Offset = "0xACB3C0", VA = "0x180ACC5C0")]
			public IOBBVAODQCE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0x86CF450", Offset = "0x86CE250", VA = "0x1886CF450")]
			internal bool UUAWBLEWUDC()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0x86CF4A0", Offset = "0x86CE2A0", VA = "0x1886CF4A0")]
			internal string UUGCYRYUDOL()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0x86CF520", Offset = "0x86CE320", VA = "0x1886CF520")]
			internal void UULJVYSRMZU(string a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0x86CF5B0", Offset = "0x86CE3B0", VA = "0x1886CF5B0")]
			internal string UUQQTFMOWLD()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public NetworkProperty QOCKRLGXWAB
		{
			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x86D2CD0", Offset = "0x86D1AD0", VA = "0x1886D2CD0", Slot = "4")]
			get
			{
				return default(NetworkProperty);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x86D2D40", Offset = "0x86D1B40", VA = "0x1886D2D40", Slot = "5")]
		public void VJNAEYZRICK(IRJBRFJRFOU a, RFNNDSOQVXM b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0xACC5C0", Offset = "0xACB3C0", VA = "0x180ACC5C0")]
		public UARGEVPJCAY()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	internal class VVBJICGBHHO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private readonly VLCPTDEKWHR HSGEEFGIBRY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private readonly RFNNDSOQVXM XTWDADTUATM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private readonly Action<Candidate> ENZRBONGGGF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private readonly HashSet<HAGVRCLCIMK> KAJYUOTLSJY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private readonly Dictionary<HAGVRCLCIMK, List<Candidate>> IZEBDTXXZWA;

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x86D3BA0", Offset = "0x86D29A0", VA = "0x1886D3BA0")]
		public VVBJICGBHHO(VLCPTDEKWHR a, RFNNDSOQVXM b, Action<Candidate> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x86D3390", Offset = "0x86D2190", VA = "0x1886D3390")]
		public void KQOSYXNSSWE(NativeList<Candidate> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x86D3170", Offset = "0x86D1F70", VA = "0x1886D3170")]
		private void AYMHTRJSFCE(HAGVRCLCIMK a, Candidate b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x86D3B40", Offset = "0x86D2940", VA = "0x1886D3B40")]
		public void RVGQZZZRNBG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x86D36D0", Offset = "0x86D24D0", VA = "0x1886D36D0")]
		private void PZPDPNCCFQI(HAGVRCLCIMK a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x86D32F0", Offset = "0x86D20F0", VA = "0x1886D32F0")]
		private void GLRQUJHVVPZ(HAGVRCLCIMK a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	internal class PropertiesByType : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x2000025")]
		[CompilerGenerated]
		private sealed class EVMWUFXONSJ : IEnumerable<NetworkProperty>, IEnumerable, IEnumerator<NetworkProperty>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000024")]
			private int GTWEEXJFPKM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x4000025")]
			private NetworkProperty LBVZGXVZPSL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000026")]
			private int DGBKDPSSRXL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000027")]
			public PropertiesByType FNBWZDPUGEI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000028")]
			private Type QROGATZCDZK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000029")]
			public Type FGUCAINGVDT;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			private NativeParallelMultiHashMap<long, int>.Enumerator NUQJCBGEMQI;

			[Cpp2IlInjected.Token(Token = "0x1700000C")]
			private NetworkProperty ALKBEWGOLTY
			{
				[Cpp2IlInjected.Token(Token = "0x6000088")]
				[Cpp2IlInjected.Address(RVA = "0xBD3950", Offset = "0xBD2750", VA = "0x180BD3950", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return default(NetworkProperty);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000D")]
			private object UUTAULZFDNA
			{
				[Cpp2IlInjected.Token(Token = "0x600008A")]
				[Cpp2IlInjected.Address(RVA = "0x86CEAA0", Offset = "0x86CD8A0", VA = "0x1886CEAA0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0x138C8D0", Offset = "0x138B6D0", VA = "0x18138C8D0")]
			[DebuggerHidden]
			public EVMWUFXONSJ(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x86CEA10", Offset = "0x86CD810", VA = "0x1886CEA10", Slot = "7")]
			[DebuggerHidden]
			private void NFYYAPEFSFX()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0x86CE720", Offset = "0x86CD520", VA = "0x1886CE720", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0x86CE620", Offset = "0x86CD420", VA = "0x1886CE620")]
			private void GWSJMPTZZMB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0x86CEAF0", Offset = "0x86CD8F0", VA = "0x1886CEAF0", Slot = "10")]
			[DebuggerHidden]
			private void USEBYPNATQY()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008B")]
			[Cpp2IlInjected.Address(RVA = "0x86CE670", Offset = "0x86CD470", VA = "0x1886CE670", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<NetworkProperty> WLDFTJALBRD()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x86CE670", Offset = "0x86CD470", VA = "0x1886CE670", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator HTHYFOXNRHD()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private static readonly Log VYIZTFKBMQC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private NativeParallelMultiHashMap<long, int> WQNZPTCLWYE;

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x86CFB30", Offset = "0x86CE930", VA = "0x1886CFB30")]
		public PropertiesByType()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x86CFA10", Offset = "0x86CE810", VA = "0x1886CFA10")]
		[IteratorStateMachine(typeof(EVMWUFXONSJ))]
		public IEnumerable<NetworkProperty> GEIWHFWACCI(Type a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x86CF910", Offset = "0x86CE710", VA = "0x1886CF910", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x86CF990", Offset = "0x86CE790", VA = "0x1886CF990")]
		private long EYYPNKOQPFV(NetworkProperty a)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x86CF950", Offset = "0x86CE750", VA = "0x1886CF950")]
		private long EYYPNKOQPFV(Type a)
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
		[Cpp2IlInjected.Address(RVA = "0x86D0040", Offset = "0x86CEE40", VA = "0x1886D0040")]
		public PropertyBitmap(int count)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x86CFEB0", Offset = "0x86CECB0", VA = "0x1886CFEB0")]
		public static PropertyBitmap WKNOHOMKXFY(int a, NativeArray<NetworkProperty> b)
		{
			return default(PropertyBitmap);
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x86CFE90", Offset = "0x86CEC90", VA = "0x1886CFE90")]
		public bool OOPGQHJGCYY(int a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x86CFEA0", Offset = "0x86CECA0", VA = "0x1886CFEA0")]
		public void Set(int index, bool value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x86CFD20", Offset = "0x86CEB20", VA = "0x1886CFD20")]
		public bool All(NetworkProperty[] properties)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x86CFDD0", Offset = "0x86CEBD0", VA = "0x1886CFDD0")]
		public bool Any(NetworkProperty[] properties)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x86CFE80", Offset = "0x86CEC80", VA = "0x1886CFE80", Slot = "4")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	internal class PropertyDrawerCandidates
	{
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private static readonly Log VYIZTFKBMQC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private readonly VLCPTDEKWHR HSGEEFGIBRY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private readonly List<RQJRQQSLPUX> XZKKRZVDKCG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private readonly PropertiesByType WQNZPTCLWYE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private NativeParallelMultiHashMap<int, int> HLSXWYKPVGS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private NativeList<int> RCTMEOSLUFK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private bool BRKISHTLOGT;

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public List<RQJRQQSLPUX> FQCVXFVNBWS
		{
			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(RVA = "0xAC91C0", Offset = "0xAC7FC0", VA = "0x180AC91C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x86D1260", Offset = "0x86D0060", VA = "0x1886D1260")]
		public PropertyDrawerCandidates(VLCPTDEKWHR configPropertyService)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x86D0090", Offset = "0x86CEE90", VA = "0x1886D0090")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x86D0760", Offset = "0x86CF560", VA = "0x1886D0760")]
		public void MSHZGGEWXPF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x86D0290", Offset = "0x86CF090", VA = "0x1886D0290")]
		public NativeList<Candidate> LDSKQISYZGW(NativeArray<NetworkProperty> a)
		{
			return default(NativeList<Candidate>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x86D1080", Offset = "0x86CFE80", VA = "0x1886D1080")]
		private bool XENHOCMMHDG(RQJRQQSLPUX a, PropertyBitmap b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x39D4B60", Offset = "0x39D3960", VA = "0x1839D4B60")]
		private void RIBFSPTCBRX<b, a>(Action<b, a> a) where b : RQJRQQSLPUX where a : Attribute
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x86D0170", Offset = "0x86CEF70", VA = "0x1886D0170")]
		private void FWDCRXEDTYJ(Type a, Type b, Type c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x39D47F0", Offset = "0x39D35F0", VA = "0x1839D47F0")]
		private c FYLNMRTRNIM<c>(Type a)
		{
			return (c)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x86D01A0", Offset = "0x86CEFA0", VA = "0x1886D01A0")]
		private int GLURUKNARKD(RQJRQQSLPUX a, int b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x86D0D30", Offset = "0x86CFB30", VA = "0x1886D0D30")]
		private void UKDVPSKYPLX(IBUKJZPYONR a, ConfigPropertyDrawer b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x86D0A10", Offset = "0x86CF810", VA = "0x1886D0A10")]
		private void PWPAORXXADA(TTVLQLMMAQI a, MatchPropertyDrawer b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x86D0900", Offset = "0x86CF700", VA = "0x1886D0900")]
		private void NLEAROBMUJQ(DUEBFIGOQEY a, MultiPropertyDrawer b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x86D0FB0", Offset = "0x86CFDB0", VA = "0x1886D0FB0")]
		private void VSVATRQWONT(ICFVMXYIQDJ a, SpecificPropertyDrawer b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	internal struct PropertyShadowing : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private readonly List<RQJRQQSLPUX> drawers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private NativeList<Candidate> unshadowed;

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public NativeList<Candidate> WOXDGQJDYDE
		{
			[Cpp2IlInjected.Token(Token = "0x60000A3")]
			[Cpp2IlInjected.Address(RVA = "0xD028E0", Offset = "0xD016E0", VA = "0x180D028E0")]
			get
			{
				return default(NativeList<Candidate>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x86D1980", Offset = "0x86D0780", VA = "0x1886D1980")]
		public PropertyShadowing(List<RQJRQQSLPUX> drawers, NativeArray<Candidate> candidates)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x86D14D0", Offset = "0x86D02D0", VA = "0x1886D14D0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x86D1510", Offset = "0x86D0310", VA = "0x1886D1510")]
		private NativeList<Candidate> KBXJSOTCJEY(NativeArray<Candidate> a)
		{
			return default(NativeList<Candidate>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x86D1810", Offset = "0x86D0610", VA = "0x1886D1810")]
		private bool MLAMPIRGMNT(RQJRQQSLPUX a, PropertyBitmap b, NetworkProperty c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x86D13A0", Offset = "0x86D01A0", VA = "0x1886D13A0")]
		private void AIJHTZTWJCQ(RQJRQQSLPUX a, PropertyBitmap b, NetworkProperty c)
		{
		}
	}
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	internal struct SortCandidatesByPriority : IComparer<Candidate>
	{
		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x86D2470", Offset = "0x86D1270", VA = "0x1886D2470", Slot = "4")]
		public int Compare(Candidate a, Candidate b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x86D2480", Offset = "0x86D1280", VA = "0x1886D2480")]
		public static void Sort(NativeList<Candidate> candidates)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	[AttributeUsage(AttributeTargets.Class)]
	public class SpecificPropertyDrawer : ConfigPropertyDrawerBase
	{
		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x86D24C0", Offset = "0x86D12C0", VA = "0x1886D24C0")]
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
