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
		[Cpp2IlInjected.Address(RVA = "0x86B9900", Offset = "0x86B7F00", VA = "0x1886B9900", Slot = "4")]
		public override void KQPXXDZDTRT()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xAD08C0", Offset = "0xACEEC0", VA = "0x180AD08C0")]
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
		private int[] TPUBNGGXPOQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private ServiceBitset EHSYFWCIGXF;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public override string[] ServiceCategories
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0xAAFED0", Offset = "0xAAE4D0", VA = "0x180AAFED0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x86BE6A0", Offset = "0x86BCCA0", VA = "0x1886BE6A0", Slot = "5")]
		public override void SetServiceCategoryIndices(List<int> globalFromLocalIndices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x86BE6C0", Offset = "0x86BCCC0", VA = "0x1886BE6C0")]
		private void UAFZRFJIDZJ(IServiceRegistration a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x86BDF30", Offset = "0x86BC530", VA = "0x1886BDF30", Slot = "6")]
		public override void RegisterServices(IServiceRegistration registry, [In] ServiceBitsetFilter filter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x86BDF90", Offset = "0x86BC590", VA = "0x1886BDF90", Slot = "7")]
		public override void RegisterTypes(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x86BE8E0", Offset = "0x86BCEE0", VA = "0x1886BE8E0")]
		public _AssemblyIndex()
		{
		}
	}
}
namespace RecRoom.ObjectModel.ConfigUI
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	internal abstract class LHMSGOQLMCL : KURQRHEETNV<Enum>, SAWUJCIXDRK, PWOVGZJTOLN, XFTUXNADLDB
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "7")]
		public abstract bool PGUJWZBQMXX(Type a);

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x86B85B0", Offset = "0x86B6BB0", VA = "0x1886B85B0")]
		protected LHMSGOQLMCL()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	internal abstract class KURQRHEETNV<a> : PWOVGZJTOLN, XFTUXNADLDB where a : Enum
	{
		[Cpp2IlInjected.Token(Token = "0x2000006")]
		[CompilerGenerated]
		private sealed class MVZLYDKGBFP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000004")]
			public VPBOJOMAXJG BHMVJNSVFVT;

			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
			public MVZLYDKGBFP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x5A05B90", Offset = "0x5A04190", VA = "0x185A05B90")]
			internal bool VDDDIJGMXBG()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x53B23F0", Offset = "0x53B09F0", VA = "0x1853B23F0")]
		protected KURQRHEETNV()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x53B1E20", Offset = "0x53B0420", VA = "0x1853B1E20")]
		protected void WCXFPDDQJLA(CDCTLOJLLRT a, VPBOJOMAXJG b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x53B1A20", Offset = "0x53B0020", VA = "0x1853B1A20")]
		protected void SSYEYXOMPEU(MNPXCDQDMBE<a> a, VPBOJOMAXJG b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "5")]
		public abstract void FJHYSNSBVIK(VPBOJOMAXJG a, NLWDNDZWUNU b);
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	internal abstract class WOIWNELCJOY : ISLHJDGSJSI, XFTUXNADLDB
	{
		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public abstract NetworkProperty[] WMKLOOQPKNR
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(Slot = "7")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public abstract NetworkProperty[] XMQVARKBHSK
		{
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(Slot = "8")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(Slot = "9")]
		public abstract void FJHYSNSBVIK(VPBOJOMAXJG a, GTQUUPOAQMH b, BKRGAXGZFKP c, NLWDNDZWUNU d);

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x3EC5860", Offset = "0x3EC3E60", VA = "0x183EC5860")]
		protected static b HOOOUIFVFJU<b>(NativeObjectLocalIdArray a, NetworkProperty<b> b) where b : struct
		{
			return (b)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x3EC5670", Offset = "0x3EC3C70", VA = "0x183EC5670")]
		protected static void CKNOXQOZVMX<d>(NativeObjectLocalIdArray a, NetworkProperty<d> b, d c) where d : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
		protected WOIWNELCJOY()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	internal abstract class MTLUIYZAJNA<a> : PWOVGZJTOLN, XFTUXNADLDB where a : struct
	{
		[Cpp2IlInjected.Token(Token = "0x2000009")]
		[CompilerGenerated]
		private sealed class MVZLYDKGBFP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000005")]
			public VPBOJOMAXJG BHMVJNSVFVT;

			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
			public MVZLYDKGBFP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x5A059B0", Offset = "0x5A03FB0", VA = "0x185A059B0")]
			internal bool VDDDIJGMXBG()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x53B23F0", Offset = "0x53B09F0", VA = "0x1853B23F0")]
		protected MTLUIYZAJNA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x59D9090", Offset = "0x59D7690", VA = "0x1859D9090")]
		protected void WCXFPDDQJLA(CDCTLOJLLRT a, VPBOJOMAXJG b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x59D7750", Offset = "0x59D5D50", VA = "0x1859D7750")]
		protected void SSYEYXOMPEU(MNPXCDQDMBE<a> a, VPBOJOMAXJG b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(Slot = "5")]
		public abstract void FJHYSNSBVIK(VPBOJOMAXJG a, NLWDNDZWUNU b);
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[RegisterService(typeof(GTQUUPOAQMH), new string[] { })]
	internal class ConfigUIService : GTQUUPOAQMH, ZGVBPXQWGAT, SPJAMBOPKUB, GIIGMTDPOEP, SWFXCOYYPIH
	{
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private static readonly Log WOAZIZZDVRE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		[DependsOn]
		private BKRGAXGZFKP TBHMUSTVPCO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		[DependsOn]
		private NLWDNDZWUNU FBMDNFQTHCW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private PropertyDrawerCandidates HMDSPLOAVZF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private NativeObjectLocalIdArray FOXZSQGPTAC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private List<VPBOJOMAXJG> IXKSHOKYVVX;

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public NativeObjectLocalIdArray GNGPWHEGAOK
		{
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x1765A00", Offset = "0x1764000", VA = "0x181765A00", Slot = "5")]
			get
			{
				return default(NativeObjectLocalIdArray);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x86B7DD0", Offset = "0x86B63D0", VA = "0x1886B7DD0", Slot = "6")]
		public void InitExternal(XRIYJCZWKCD services)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x86B7CD0", Offset = "0x86B62D0", VA = "0x1886B7CD0", Slot = "7")]
		public void IPUBHZMPJRZ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x86B7670", Offset = "0x86B5C70", VA = "0x1886B7670", Slot = "4")]
		public void FOOGCUEGIJC(NativeObjectLocalIdArray a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x86B8160", Offset = "0x86B6760", VA = "0x1886B8160")]
		private void XPMQNLYSHCG(NativeObjectLocalIdArray a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x86B7AE0", Offset = "0x86B60E0", VA = "0x1886B7AE0")]
		private void ILKKKXSHGVL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x86B7340", Offset = "0x86B5940", VA = "0x1886B7340")]
		private void FJHYSNSBVIK(Candidate a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x86B80F0", Offset = "0x86B66F0", VA = "0x1886B80F0", Slot = "8")]
		private void KPEUJIHXKXR(XRIYJCZWKCD a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x1091A50", Offset = "0x1090050", VA = "0x181091A50", Slot = "9")]
		private void WCDWJAGTXKX()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x86B8250", Offset = "0x86B6850", VA = "0x1886B8250")]
		public ConfigUIService()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[MatchPropertyDrawer(0)]
	internal class EMNTFTVBUBL : LHMSGOQLMCL
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x86B8460", Offset = "0x86B6A60", VA = "0x1886B8460", Slot = "5")]
		public override void FJHYSNSBVIK(VPBOJOMAXJG a, NLWDNDZWUNU b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x86B8510", Offset = "0x86B6B10", VA = "0x1886B8510", Slot = "7")]
		public override bool PGUJWZBQMXX(Type a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x86B85B0", Offset = "0x86B6BB0", VA = "0x1886B85B0")]
		public EMNTFTVBUBL()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[MatchPropertyDrawer(0)]
	internal class IFAKLBZCKHM : LHMSGOQLMCL
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x86B97B0", Offset = "0x86B7DB0", VA = "0x1886B97B0", Slot = "5")]
		public override void FJHYSNSBVIK(VPBOJOMAXJG a, NLWDNDZWUNU b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x86B9860", Offset = "0x86B7E60", VA = "0x1886B9860", Slot = "7")]
		public override bool PGUJWZBQMXX(Type a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x86B85B0", Offset = "0x86B6BB0", VA = "0x1886B85B0")]
		public IFAKLBZCKHM()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[ConfigPropertyDrawer(typeof(RenderableColor), 1)]
	internal class DBVTMSOCSUH : KURQRHEETNV<RenderableColor>
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x86B82D0", Offset = "0x86B68D0", VA = "0x1886B82D0", Slot = "5")]
		public override void FJHYSNSBVIK(VPBOJOMAXJG a, NLWDNDZWUNU b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x86B8420", Offset = "0x86B6A20", VA = "0x1886B8420")]
		public DBVTMSOCSUH()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[MultiPropertyDrawer(2)]
	internal class ULJIAHUVVDZ : WOIWNELCJOY
	{
		[Cpp2IlInjected.Token(Token = "0x200000F")]
		[CompilerGenerated]
		private sealed class SSSKYROOASY
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400000E")]
			public GTQUUPOAQMH TDJADVTINJF;

			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
			public SSSKYROOASY()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x86BD590", Offset = "0x86BBB90", VA = "0x1886BD590")]
			internal (int, int) SIUWFZBEGVG()
			{
				return default((int, int));
			}

			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x86BD7F0", Offset = "0x86BBDF0", VA = "0x1886BD7F0")]
			internal void SJADDFVBQGP((int color, int material) value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public override NetworkProperty[] WMKLOOQPKNR
		{
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0xAAB6B0", Offset = "0xAA9CB0", VA = "0x180AAB6B0", Slot = "7")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public override NetworkProperty[] XMQVARKBHSK
		{
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0xAA7760", Offset = "0xAA5D60", VA = "0x180AA7760", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x86BD990", Offset = "0x86BBF90", VA = "0x1886BD990", Slot = "9")]
		public override void FJHYSNSBVIK(VPBOJOMAXJG a, GTQUUPOAQMH b, BKRGAXGZFKP c, NLWDNDZWUNU d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x86BDD40", Offset = "0x86BC340", VA = "0x1886BDD40")]
		public ULJIAHUVVDZ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[ConfigPropertyDrawer(typeof(bool))]
	internal class XLYQVKNDGRK : MTLUIYZAJNA<bool>
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x86BDE60", Offset = "0x86BC460", VA = "0x1886BDE60", Slot = "5")]
		public override void FJHYSNSBVIK(VPBOJOMAXJG a, NLWDNDZWUNU b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x86BDEF0", Offset = "0x86BC4F0", VA = "0x1886BDEF0")]
		public XLYQVKNDGRK()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[ConfigPropertyDrawer(typeof(FixedString32Bytes))]
	internal class PARNXKMIFEG : MTLUIYZAJNA<FixedString32Bytes>
	{
		[Cpp2IlInjected.Token(Token = "0x2000012")]
		[CompilerGenerated]
		private sealed class SPJGRQAUTAO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400000F")]
			public VPBOJOMAXJG BHMVJNSVFVT;

			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
			public SPJGRQAUTAO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x86BD060", Offset = "0x86BB660", VA = "0x1886BD060")]
			internal string SIUWFZBEGVG()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x86BD2B0", Offset = "0x86BB8B0", VA = "0x1886BD2B0")]
			internal void SJADDFVBQGP(string a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x86B9E40", Offset = "0x86B8440", VA = "0x1886B9E40", Slot = "5")]
		public override void FJHYSNSBVIK(VPBOJOMAXJG a, NLWDNDZWUNU b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x86B9FD0", Offset = "0x86B85D0", VA = "0x1886B9FD0")]
		public PARNXKMIFEG()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[ConfigPropertyDrawer(typeof(FixedString64Bytes))]
	internal class ACIQETQDYVX : MTLUIYZAJNA<FixedString64Bytes>
	{
		[Cpp2IlInjected.Token(Token = "0x2000014")]
		[CompilerGenerated]
		private sealed class SPJGRQAUTAO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000010")]
			public VPBOJOMAXJG BHMVJNSVFVT;

			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
			public SPJGRQAUTAO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x86BD0C0", Offset = "0x86BB6C0", VA = "0x1886BD0C0")]
			internal string SIUWFZBEGVG()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x86BD210", Offset = "0x86BB810", VA = "0x1886BD210")]
			internal void SJADDFVBQGP(string a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x86B6440", Offset = "0x86B4A40", VA = "0x1886B6440", Slot = "5")]
		public override void FJHYSNSBVIK(VPBOJOMAXJG a, NLWDNDZWUNU b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x86B65D0", Offset = "0x86B4BD0", VA = "0x1886B65D0")]
		public ACIQETQDYVX()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	[ConfigPropertyDrawer(typeof(float3))]
	internal class MVEHXSFRVTZ : MTLUIYZAJNA<float3>
	{
		[Cpp2IlInjected.Token(Token = "0x2000016")]
		[CompilerGenerated]
		private sealed class SPJGRQAUTAO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000011")]
			public VPBOJOMAXJG BHMVJNSVFVT;

			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
			public SPJGRQAUTAO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x86BD190", Offset = "0x86BB790", VA = "0x1886BD190")]
			internal float SIUWFZBEGVG()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x86BD200", Offset = "0x86BB800", VA = "0x1886BD200")]
			internal void SJADDFVBQGP(float a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x86BD370", Offset = "0x86BB970", VA = "0x1886BD370")]
			internal float SJFKAMOYZRY()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x86BD3F0", Offset = "0x86BB9F0", VA = "0x1886BD3F0")]
			internal void SJKQXTIWJDH(float a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x86BD410", Offset = "0x86BBA10", VA = "0x1886BD410")]
			internal float SJPXVACTSOQ()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x86BD4A0", Offset = "0x86BBAA0", VA = "0x1886BD4A0")]
			internal void SJVESGWRBZZ(float a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x86BCFF0", Offset = "0x86BB5F0", VA = "0x1886BCFF0")]
			internal float NDCRRTCEVDJ(int a)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x86BD4B0", Offset = "0x86BBAB0", VA = "0x1886BD4B0")]
			internal void TMFJZHENBXC(int a, float b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x86B9A00", Offset = "0x86B8000", VA = "0x1886B9A00", Slot = "5")]
		public override void FJHYSNSBVIK(VPBOJOMAXJG a, NLWDNDZWUNU b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x86B9E00", Offset = "0x86B8400", VA = "0x1886B9E00")]
		public MVEHXSFRVTZ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[ConfigPropertyDrawer(typeof(float))]
	internal class ICURKOCPIBE : MTLUIYZAJNA<float>
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x86B96E0", Offset = "0x86B7CE0", VA = "0x1886B96E0", Slot = "5")]
		public override void FJHYSNSBVIK(VPBOJOMAXJG a, NLWDNDZWUNU b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x86B9770", Offset = "0x86B7D70", VA = "0x1886B9770")]
		public ICURKOCPIBE()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[ConfigPropertyDrawer(typeof(int))]
	internal class QJGMLWJHVFT : MTLUIYZAJNA<int>
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x86BC0B0", Offset = "0x86BA6B0", VA = "0x1886BC0B0", Slot = "5")]
		public override void FJHYSNSBVIK(VPBOJOMAXJG a, NLWDNDZWUNU b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x86BC140", Offset = "0x86BA740", VA = "0x1886BC140")]
		public QJGMLWJHVFT()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	[ConfigPropertyDrawer(typeof(quaternion))]
	internal class RIOPPZTRQXO : MTLUIYZAJNA<quaternion>
	{
		[Cpp2IlInjected.Token(Token = "0x200001A")]
		[CompilerGenerated]
		private sealed class SPJGRQAUTAO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000012")]
			public VPBOJOMAXJG BHMVJNSVFVT;

			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
			public SPJGRQAUTAO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x86BD180", Offset = "0x86BB780", VA = "0x1886BD180")]
			internal float SIUWFZBEGVG()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x86BD2A0", Offset = "0x86BB8A0", VA = "0x1886BD2A0")]
			internal void SJADDFVBQGP(float a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x86BD3E0", Offset = "0x86BB9E0", VA = "0x1886BD3E0")]
			internal float SJFKAMOYZRY()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x86BD400", Offset = "0x86BBA00", VA = "0x1886BD400")]
			internal void SJKQXTIWJDH(float a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x86BD480", Offset = "0x86BBA80", VA = "0x1886BD480")]
			internal float SJPXVACTSOQ()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x86BD490", Offset = "0x86BBA90", VA = "0x1886BD490")]
			internal void SJVESGWRBZZ(float a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x86BCE90", Offset = "0x86BB490", VA = "0x1886BCE90")]
			internal float IGWDRJGRZOY(int a)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x86BCC30", Offset = "0x86BB230", VA = "0x1886BCC30")]
			internal void ERAWUTUKIPR(int a, float b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x86BC350", Offset = "0x86BA950", VA = "0x1886BC350", Slot = "5")]
		public override void FJHYSNSBVIK(VPBOJOMAXJG a, NLWDNDZWUNU b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x86BC750", Offset = "0x86BAD50", VA = "0x1886BC750")]
		public RIOPPZTRQXO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[ConfigPropertyDrawer(typeof(uint))]
	internal class QSXWKEKCUVS : MTLUIYZAJNA<uint>
	{
		[Cpp2IlInjected.Token(Token = "0x200001C")]
		[CompilerGenerated]
		private sealed class SPJGRQAUTAO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000013")]
			public VPBOJOMAXJG BHMVJNSVFVT;

			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
			public SPJGRQAUTAO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x86BD140", Offset = "0x86BB740", VA = "0x1886BD140")]
			internal int SIUWFZBEGVG()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x86BD320", Offset = "0x86BB920", VA = "0x1886BD320")]
			internal void SJADDFVBQGP(int a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x86BC180", Offset = "0x86BA780", VA = "0x1886BC180", Slot = "5")]
		public override void FJHYSNSBVIK(VPBOJOMAXJG a, NLWDNDZWUNU b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x86BC310", Offset = "0x86BA910", VA = "0x1886BC310")]
		public QSXWKEKCUVS()
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
	internal static class EUQCAKEFWIJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x86B85F0", Offset = "0x86B6BF0", VA = "0x1886B85F0")]
		public static void NRNQLSMCCEX(Type a, Type b)
		{
		}
	}
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	internal struct CommonProperties
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x86B6FD0", Offset = "0x86B55D0", VA = "0x1886B6FD0")]
		public static NativeList<NetworkProperty> OHSSJBTLFVY(NativeObjectLocalIdArray a, BKRGAXGZFKP b)
		{
			return default(NativeList<NetworkProperty>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x86B7250", Offset = "0x86B5850", VA = "0x1886B7250")]
		private static bool TITFLFWXVXZ(NetworkProperty a, NativeObjectLocalIdArray b)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public class CNNGUUVLVFV : VPBOJOMAXJG, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private readonly NetworkProperty BHMVJNSVFVT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private readonly BKRGAXGZFKP EMUEZBQBFUX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private readonly NativeObjectLocalIdArray FOXZSQGPTAC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private bool MFRVCTFDCZV;

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public string UDAZODDRFXJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x86B6840", Offset = "0x86B4E40", VA = "0x1886B6840", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public bool YGAJUXDHCKF
		{
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x86B6A50", Offset = "0x86B5050", VA = "0x1886B6A50", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public RRObject YSCKYYAACZD
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x86B6B70", Offset = "0x86B5170", VA = "0x1886B6B70", Slot = "8")]
			get
			{
				return default(RRObject);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public Type BTZTINVWBHG
		{
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x86B6E90", Offset = "0x86B5490", VA = "0x1886B6E90", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action KGMWYKNRLWM
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x86B6AD0", Offset = "0x86B50D0", VA = "0x1886B6AD0", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x86B6CE0", Offset = "0x86B52E0", VA = "0x1886B6CE0", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x86B6EE0", Offset = "0x86B54E0", VA = "0x1886B6EE0")]
		public CNNGUUVLVFV(NativeObjectLocalIdArray a, NetworkProperty b, BKRGAXGZFKP c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x86B6D80", Offset = "0x86B5380", VA = "0x1886B6D80")]
		private void VAMFWBAUZLN(BulkPropertyChangeData a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x86B6970", Offset = "0x86B4F70", VA = "0x1886B6970", Slot = "10")]
		public void Get(MutableRef value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x86B6BC0", Offset = "0x86B51C0", VA = "0x1886B6BC0", Slot = "11")]
		public void Set(ReadOnlyRef value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x86B68A0", Offset = "0x86B4EA0", VA = "0x1886B68A0", Slot = "12")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[SpecificPropertyDrawer(1)]
	internal sealed class RRCATRTIRKA : DQTSZTVBVZB, PWOVGZJTOLN, XFTUXNADLDB
	{
		[Cpp2IlInjected.Token(Token = "0x2000022")]
		[CompilerGenerated]
		private sealed class AUWAEQXFGZW
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			public VPBOJOMAXJG BHMVJNSVFVT;

			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
			public AUWAEQXFGZW()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0x86B6610", Offset = "0x86B4C10", VA = "0x1886B6610")]
			internal bool SIUWFZBEGVG()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0x86B6660", Offset = "0x86B4C60", VA = "0x1886B6660")]
			internal string SJADDFVBQGP()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0x86B66E0", Offset = "0x86B4CE0", VA = "0x1886B66E0")]
			internal void SJFKAMOYZRY(string a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0x86B6770", Offset = "0x86B4D70", VA = "0x1886B6770")]
			internal string SJKQXTIWJDH()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public NetworkProperty YWXLDIBZMSV
		{
			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x86BCBC0", Offset = "0x86BB1C0", VA = "0x1886BCBC0", Slot = "4")]
			get
			{
				return default(NetworkProperty);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x86BC790", Offset = "0x86BAD90", VA = "0x1886BC790", Slot = "5")]
		public void FJHYSNSBVIK(VPBOJOMAXJG a, NLWDNDZWUNU b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
		public RRCATRTIRKA()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	internal class FAIXJEVZFCI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private readonly BKRGAXGZFKP TBHMUSTVPCO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private readonly NLWDNDZWUNU JDFQXWFRVZU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private readonly Action<Candidate> YRMEGHTVAJX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private readonly HashSet<IXUTGBQAJSK> HULEMXCEQTE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private readonly Dictionary<IXUTGBQAJSK, List<Candidate>> RWGFNNECMNW;

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x86B90D0", Offset = "0x86B76D0", VA = "0x1886B90D0")]
		public FAIXJEVZFCI(BKRGAXGZFKP a, NLWDNDZWUNU b, Action<Candidate> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x86B8920", Offset = "0x86B6F20", VA = "0x1886B8920")]
		public void QVVJBFOUQKE(NativeList<Candidate> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x86B8750", Offset = "0x86B6D50", VA = "0x1886B8750")]
		private void CZXZRKQCFAI(IXUTGBQAJSK a, Candidate b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x86B88C0", Offset = "0x86B6EC0", VA = "0x1886B88C0")]
		public void PIXCYPFXPAI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x86B8C60", Offset = "0x86B7260", VA = "0x1886B8C60")]
		private void TSDZGROSMPG(IXUTGBQAJSK a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x86B86B0", Offset = "0x86B6CB0", VA = "0x1886B86B0")]
		private void ARPVBDFAQUT(IXUTGBQAJSK a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	internal class PropertiesByType : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x2000025")]
		[CompilerGenerated]
		private sealed class GCTGDPQSKON : IEnumerable<NetworkProperty>, IEnumerable, IEnumerator<NetworkProperty>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000024")]
			private int AEMBTWPORMI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x4000025")]
			private NetworkProperty MVWPOXUKILF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000026")]
			private int NVRLJVISCMF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000027")]
			public PropertiesByType CDTALOACOKM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000028")]
			private Type FOEYAZCVXNK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000029")]
			public Type RZOJFOZVPAB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			private NativeParallelMultiHashMap<long, int>.Enumerator TPFONUYPLCA;

			[Cpp2IlInjected.Token(Token = "0x1700000C")]
			private NetworkProperty XFGQWMTPLLQ
			{
				[Cpp2IlInjected.Token(Token = "0x6000088")]
				[Cpp2IlInjected.Address(RVA = "0xC071B0", Offset = "0xC057B0", VA = "0x180C071B0", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return default(NetworkProperty);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000D")]
			private object HLWKSVCMTHU
			{
				[Cpp2IlInjected.Token(Token = "0x600008A")]
				[Cpp2IlInjected.Address(RVA = "0x86B9270", Offset = "0x86B7870", VA = "0x1886B9270", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0x15FB710", Offset = "0x15F9D10", VA = "0x1815FB710")]
			[DebuggerHidden]
			public GCTGDPQSKON(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x86B91E0", Offset = "0x86B77E0", VA = "0x1886B91E0", Slot = "7")]
			[DebuggerHidden]
			private void CJOOGEZDZDP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0x86B93C0", Offset = "0x86B79C0", VA = "0x1886B93C0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0x86B92C0", Offset = "0x86B78C0", VA = "0x1886B92C0")]
			private void KPIRURCCWVL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0x86B96A0", Offset = "0x86B7CA0", VA = "0x1886B96A0", Slot = "10")]
			[DebuggerHidden]
			private void VIZWRAVZEQM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008B")]
			[Cpp2IlInjected.Address(RVA = "0x86B9310", Offset = "0x86B7910", VA = "0x1886B9310", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<NetworkProperty> QXHQYPZAJNT()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x86B9310", Offset = "0x86B7910", VA = "0x1886B9310", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator MZPFIUHPQEF()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private static readonly Log WOAZIZZDVRE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private NativeParallelMultiHashMap<long, int> OEKJAHOVPHK;

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x86BA220", Offset = "0x86B8820", VA = "0x1886BA220")]
		public PropertiesByType()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x86BA110", Offset = "0x86B8710", VA = "0x1886BA110")]
		[IteratorStateMachine(typeof(GCTGDPQSKON))]
		public IEnumerable<NetworkProperty> RNODQGFBFHC(Type a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x86BA010", Offset = "0x86B8610", VA = "0x1886BA010", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x86BA050", Offset = "0x86B8650", VA = "0x1886BA050")]
		private long OHFIOZYJSIT(NetworkProperty a)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x86BA0D0", Offset = "0x86B86D0", VA = "0x1886BA0D0")]
		private long OHFIOZYJSIT(Type a)
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
		[Cpp2IlInjected.Address(RVA = "0x86BA730", Offset = "0x86B8D30", VA = "0x1886BA730")]
		public PropertyBitmap(int count)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x86BA590", Offset = "0x86B8B90", VA = "0x1886BA590")]
		public static PropertyBitmap NQHFUFWUWUG(int a, NativeArray<NetworkProperty> b)
		{
			return default(PropertyBitmap);
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x86BA570", Offset = "0x86B8B70", VA = "0x1886BA570")]
		public bool DYAODMMLNYU(int a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x86BA720", Offset = "0x86B8D20", VA = "0x1886BA720")]
		public void Set(int index, bool value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x86BA410", Offset = "0x86B8A10", VA = "0x1886BA410")]
		public bool All(NetworkProperty[] properties)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x86BA4C0", Offset = "0x86B8AC0", VA = "0x1886BA4C0")]
		public bool Any(NetworkProperty[] properties)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x86BA580", Offset = "0x86B8B80", VA = "0x1886BA580", Slot = "4")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	internal class PropertyDrawerCandidates
	{
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private static readonly Log WOAZIZZDVRE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private readonly BKRGAXGZFKP TBHMUSTVPCO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private readonly List<XFTUXNADLDB> AEFHQILUBQW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private readonly PropertiesByType OEKJAHOVPHK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private NativeParallelMultiHashMap<int, int> BHHUFHGHADU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private NativeList<int> KMHQHVUNUNK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private bool MFRVCTFDCZV;

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public List<XFTUXNADLDB> VKNJNJMPXFU
		{
			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(RVA = "0xAA7760", Offset = "0xAA5D60", VA = "0x180AA7760")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x86BB940", Offset = "0x86B9F40", VA = "0x1886BB940")]
		public PropertyDrawerCandidates(BKRGAXGZFKP configPropertyService)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x86BAF20", Offset = "0x86B9520", VA = "0x1886BAF20")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x86BB000", Offset = "0x86B9600", VA = "0x1886BB000")]
		public void JUYWZZXFNED()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x86BAA50", Offset = "0x86B9050", VA = "0x1886BAA50")]
		public NativeList<Candidate> DVGRSIZDLIS(NativeArray<NetworkProperty> a)
		{
			return default(NativeList<Candidate>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x86BB1A0", Offset = "0x86B97A0", VA = "0x1886BB1A0")]
		private bool MVOLCYXDMQY(XFTUXNADLDB a, PropertyBitmap b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x3BF54E0", Offset = "0x3BF3AE0", VA = "0x183BF54E0")]
		private void EMTGBIZWZJH<b, a>(Action<b, a> a) where b : XFTUXNADLDB where a : Attribute
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x86BB2F0", Offset = "0x86B98F0", VA = "0x1886BB2F0")]
		private void OBRGHGEXQWJ(Type a, Type b, Type c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x3BF5170", Offset = "0x3BF3770", VA = "0x183BF5170")]
		private c AWZCRZXGEOM<c>(Type a)
		{
			return (c)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x86BA890", Offset = "0x86B8E90", VA = "0x1886BA890")]
		private int BWHCPLEXBYP(XFTUXNADLDB a, int b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x86BB640", Offset = "0x86B9C40", VA = "0x1886BB640")]
		private void ZTGOIIIGYMJ(PWOVGZJTOLN a, ConfigPropertyDrawer b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x86BB320", Offset = "0x86B9920", VA = "0x1886BB320")]
		private void WWQOFYHELMC(SAWUJCIXDRK a, MatchPropertyDrawer b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x86BA780", Offset = "0x86B8D80", VA = "0x1886BA780")]
		private void BAXMOHSQUCW(ISLHJDGSJSI a, MultiPropertyDrawer b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x86BA980", Offset = "0x86B8F80", VA = "0x1886BA980")]
		private void CBAGQJFZEVD(DQTSZTVBVZB a, SpecificPropertyDrawer b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	internal struct PropertyShadowing : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private readonly List<XFTUXNADLDB> drawers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private NativeList<Candidate> unshadowed;

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public NativeList<Candidate> NDUQVUPKDGS
		{
			[Cpp2IlInjected.Token(Token = "0x60000A3")]
			[Cpp2IlInjected.Address(RVA = "0xBBDF80", Offset = "0xBBC580", VA = "0x180BBDF80")]
			get
			{
				return default(NativeList<Candidate>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x86BC060", Offset = "0x86BA660", VA = "0x1886BC060")]
		public PropertyShadowing(List<XFTUXNADLDB> drawers, NativeArray<Candidate> candidates)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x86BBBF0", Offset = "0x86BA1F0", VA = "0x1886BBBF0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x86BBC30", Offset = "0x86BA230", VA = "0x1886BBC30")]
		private NativeList<Candidate> GMKLIDHVLYQ(NativeArray<Candidate> a)
		{
			return default(NativeList<Candidate>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x86BBA80", Offset = "0x86BA080", VA = "0x1886BBA80")]
		private bool BWBSGGENLQB(XFTUXNADLDB a, PropertyBitmap b, NetworkProperty c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x86BBF30", Offset = "0x86BA530", VA = "0x1886BBF30")]
		private void RMCYVJWNQXK(XFTUXNADLDB a, PropertyBitmap b, NetworkProperty c)
		{
		}
	}
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	internal struct SortCandidatesByPriority : IComparer<Candidate>
	{
		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x86BD930", Offset = "0x86BBF30", VA = "0x1886BD930", Slot = "4")]
		public int Compare(Candidate a, Candidate b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x86BD940", Offset = "0x86BBF40", VA = "0x1886BD940")]
		public static void Sort(NativeList<Candidate> candidates)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	[AttributeUsage(AttributeTargets.Class)]
	public class SpecificPropertyDrawer : ConfigPropertyDrawerBase
	{
		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x86BD980", Offset = "0x86BBF80", VA = "0x1886BD980")]
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
