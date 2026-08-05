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
		[Cpp2IlInjected.Address(RVA = "0x8642940", Offset = "0x8641940", VA = "0x188642940", Slot = "4")]
		public override void BPSMAKIBARY()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xAF57C0", Offset = "0xAF47C0", VA = "0x180AF57C0")]
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
		private int[] DGVDDFJHVEN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private ServiceBitset XRLFBVIQUFE;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public override string[] ServiceCategories
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0xAD2F30", Offset = "0xAD1F30", VA = "0x180AD2F30", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x8647500", Offset = "0x8646500", VA = "0x188647500", Slot = "5")]
		public override void SetServiceCategoryIndices(List<int> globalFromLocalIndices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x8647520", Offset = "0x8646520", VA = "0x188647520")]
		private void ZASTUGVTQWC(IServiceRegistration a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x8646DB0", Offset = "0x8645DB0", VA = "0x188646DB0", Slot = "6")]
		public override void RegisterServices(IServiceRegistration registry, [In] ServiceBitsetFilter filter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x8646E10", Offset = "0x8645E10", VA = "0x188646E10", Slot = "7")]
		public override void RegisterTypes(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x8647740", Offset = "0x8646740", VA = "0x188647740")]
		public _AssemblyIndex()
		{
		}
	}
}
namespace RecRoom.ObjectModel.ConfigUI
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	internal abstract class RWOJRZCVCTM : PFVGWRMCPPS<Enum>, VCJUOFWRGLN, ACVMUXEQEVM, DSFFAMYQGNU
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "7")]
		public abstract bool DABOANHFRZW(Type a);

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x86434A0", Offset = "0x86424A0", VA = "0x1886434A0")]
		protected RWOJRZCVCTM()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	internal abstract class PFVGWRMCPPS<a> : ACVMUXEQEVM, DSFFAMYQGNU where a : Enum
	{
		[Cpp2IlInjected.Token(Token = "0x2000006")]
		[CompilerGenerated]
		private sealed class HQENANIBZDY
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000004")]
			public OBHYUJXHARD WHJHTCRZRRQ;

			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0xAD2EF0", Offset = "0xAD1EF0", VA = "0x180AD2EF0")]
			public HQENANIBZDY()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x50C2220", Offset = "0x50C1220", VA = "0x1850C2220")]
			internal bool YWQZNRXICAJ()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x52B1D60", Offset = "0x52B0D60", VA = "0x1852B1D60")]
		protected PFVGWRMCPPS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x5DBE590", Offset = "0x5DBD590", VA = "0x185DBE590")]
		protected void FGTTSLSOFZV(MKHADALCLBA a, OBHYUJXHARD b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x5DBEB90", Offset = "0x5DBDB90", VA = "0x185DBEB90")]
		protected void KUQIMUPDHLH(WCEEGISSBFD<a> a, OBHYUJXHARD b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "5")]
		public abstract void DPNMDIIUTVH(OBHYUJXHARD a, DTMIGTPTCBF b);
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	internal abstract class VOZIHIZCJCR : NXKHFDMKJXR, DSFFAMYQGNU
	{
		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public abstract NetworkProperty[] QHVRDVEFRTS
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(Slot = "7")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public abstract NetworkProperty[] DDIEFEEKCIT
		{
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(Slot = "8")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(Slot = "9")]
		public abstract void DPNMDIIUTVH(OBHYUJXHARD a, SVSMEFNUQEW b, NVEEAEOMCJO c, DTMIGTPTCBF d);

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x3C53130", Offset = "0x3C52130", VA = "0x183C53130")]
		protected static b ROLWSVOBRXT<b>(NativeObjectLocalIdArray a, NetworkProperty<b> b) where b : struct
		{
			return (b)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x3C52F40", Offset = "0x3C51F40", VA = "0x183C52F40")]
		protected static void QECEBVDJZTS<d>(NativeObjectLocalIdArray a, NetworkProperty<d> b, d c) where d : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0xAD2EF0", Offset = "0xAD1EF0", VA = "0x180AD2EF0")]
		protected VOZIHIZCJCR()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	internal abstract class JKNDBWBGVVH<a> : ACVMUXEQEVM, DSFFAMYQGNU where a : struct
	{
		[Cpp2IlInjected.Token(Token = "0x2000009")]
		[CompilerGenerated]
		private sealed class HQENANIBZDY
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000005")]
			public OBHYUJXHARD WHJHTCRZRRQ;

			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0xAD2EF0", Offset = "0xAD1EF0", VA = "0x180AD2EF0")]
			public HQENANIBZDY()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x50C2180", Offset = "0x50C1180", VA = "0x1850C2180")]
			internal bool YWQZNRXICAJ()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x52B1D60", Offset = "0x52B0D60", VA = "0x1852B1D60")]
		protected JKNDBWBGVVH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x52AFD30", Offset = "0x52AED30", VA = "0x1852AFD30")]
		protected void FGTTSLSOFZV(MKHADALCLBA a, OBHYUJXHARD b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x52B1580", Offset = "0x52B0580", VA = "0x1852B1580")]
		protected void KUQIMUPDHLH(WCEEGISSBFD<a> a, OBHYUJXHARD b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(Slot = "5")]
		public abstract void DPNMDIIUTVH(OBHYUJXHARD a, DTMIGTPTCBF b);
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[RegisterService(typeof(SVSMEFNUQEW), new string[] { })]
	internal class ConfigUIService : SVSMEFNUQEW, WETTKMMHKBK, YKHKLPHTBGW, FGJPSHLXWSW, OZDTSOBLUVI
	{
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private static readonly Log HRODLTCIOIP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		[DependsOn]
		private NVEEAEOMCJO MDSVUQABNBV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		[DependsOn]
		private DTMIGTPTCBF AISDIFNARRT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private PropertyDrawerCandidates OSTGIZSZOHG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private NativeObjectLocalIdArray AMIPJTXNTIX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private List<OBHYUJXHARD> LKGXUFZBCHO;

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public NativeObjectLocalIdArray NCXNTMYUOJJ
		{
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x14A6790", Offset = "0x14A5790", VA = "0x1814A6790", Slot = "5")]
			get
			{
				return default(NativeObjectLocalIdArray);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x8640250", Offset = "0x863F250", VA = "0x188640250", Slot = "6")]
		public void InitExternal(MEMEGXEKDDM services)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x8640570", Offset = "0x863F570", VA = "0x188640570", Slot = "7")]
		public void QQFIGNLTLAU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x863FDE0", Offset = "0x863EDE0", VA = "0x18863FDE0", Slot = "4")]
		public void HFZXCMRTEYL(NativeObjectLocalIdArray a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x8640860", Offset = "0x863F860", VA = "0x188640860")]
		private void ZLORIRXTDAF(NativeObjectLocalIdArray a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x8640670", Offset = "0x863F670", VA = "0x188640670")]
		private void ZEKZUFJEJKO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x863FA30", Offset = "0x863EA30", VA = "0x18863FA30")]
		private void DPNMDIIUTVH(Candidate a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x863FD70", Offset = "0x863ED70", VA = "0x18863FD70", Slot = "8")]
		private void DRCAJKSLWZO(MEMEGXEKDDM a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0xDC7100", Offset = "0xDC6100", VA = "0x180DC7100", Slot = "9")]
		private void ZWDRINULYCE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x8640950", Offset = "0x863F950", VA = "0x188640950")]
		public ConfigUIService()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[MatchPropertyDrawer(0)]
	internal class QORRGUOYBIS : RWOJRZCVCTM
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x8645620", Offset = "0x8644620", VA = "0x188645620", Slot = "5")]
		public override void DPNMDIIUTVH(OBHYUJXHARD a, DTMIGTPTCBF b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x8645580", Offset = "0x8644580", VA = "0x188645580", Slot = "7")]
		public override bool DABOANHFRZW(Type a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x86434A0", Offset = "0x86424A0", VA = "0x1886434A0")]
		public QORRGUOYBIS()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[MatchPropertyDrawer(0)]
	internal class PXAMBWVOSXJ : RWOJRZCVCTM
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x86433F0", Offset = "0x86423F0", VA = "0x1886433F0", Slot = "5")]
		public override void DPNMDIIUTVH(OBHYUJXHARD a, DTMIGTPTCBF b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x8643350", Offset = "0x8642350", VA = "0x188643350", Slot = "7")]
		public override bool DABOANHFRZW(Type a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x86434A0", Offset = "0x86424A0", VA = "0x1886434A0")]
		public PXAMBWVOSXJ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[ConfigPropertyDrawer(typeof(RenderableColor), 1)]
	internal class VLNMMKDOWUK : PFVGWRMCPPS<RenderableColor>
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x86468B0", Offset = "0x86458B0", VA = "0x1886468B0", Slot = "5")]
		public override void DPNMDIIUTVH(OBHYUJXHARD a, DTMIGTPTCBF b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x8646A00", Offset = "0x8645A00", VA = "0x188646A00")]
		public VLNMMKDOWUK()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[MultiPropertyDrawer(2)]
	internal class DUVCHCQOROS : VOZIHIZCJCR
	{
		[Cpp2IlInjected.Token(Token = "0x200000F")]
		[CompilerGenerated]
		private sealed class EHHPOGHKTEL
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400000E")]
			public SVSMEFNUQEW NTVCUYSEXOG;

			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0xAD2EF0", Offset = "0xAD1EF0", VA = "0x180AD2EF0")]
			public EHHPOGHKTEL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x8641940", Offset = "0x8640940", VA = "0x188641940")]
			internal (int, int) CWOXSEPOALF()
			{
				return default((int, int));
			}

			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x8641800", Offset = "0x8640800", VA = "0x188641800")]
			internal void CWJQUXVQQZW((int color, int material) value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public override NetworkProperty[] QHVRDVEFRTS
		{
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0xACF720", Offset = "0xACE720", VA = "0x180ACF720", Slot = "7")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public override NetworkProperty[] DDIEFEEKCIT
		{
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0xACF7F0", Offset = "0xACE7F0", VA = "0x180ACF7F0", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x8641330", Offset = "0x8640330", VA = "0x188641330", Slot = "9")]
		public override void DPNMDIIUTVH(OBHYUJXHARD a, SVSMEFNUQEW b, NVEEAEOMCJO c, DTMIGTPTCBF d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x86416E0", Offset = "0x86406E0", VA = "0x1886416E0")]
		public DUVCHCQOROS()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[ConfigPropertyDrawer(typeof(bool))]
	internal class ZPWORHPIMZZ : JKNDBWBGVVH<bool>
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x8646CE0", Offset = "0x8645CE0", VA = "0x188646CE0", Slot = "5")]
		public override void DPNMDIIUTVH(OBHYUJXHARD a, DTMIGTPTCBF b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x8646D70", Offset = "0x8645D70", VA = "0x188646D70")]
		public ZPWORHPIMZZ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[ConfigPropertyDrawer(typeof(FixedString32Bytes))]
	internal class NWSBAJRWZID : JKNDBWBGVVH<FixedString32Bytes>
	{
		[Cpp2IlInjected.Token(Token = "0x2000012")]
		[CompilerGenerated]
		private sealed class DDFDKRDHJEJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400000F")]
			public OBHYUJXHARD WHJHTCRZRRQ;

			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0xAD2EF0", Offset = "0xAD1EF0", VA = "0x180AD2EF0")]
			public DDFDKRDHJEJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x8640BC0", Offset = "0x863FBC0", VA = "0x188640BC0")]
			internal string CWOXSEPOALF()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x8640AB0", Offset = "0x863FAB0", VA = "0x188640AB0")]
			internal void CWJQUXVQQZW(string a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x8642C70", Offset = "0x8641C70", VA = "0x188642C70", Slot = "5")]
		public override void DPNMDIIUTVH(OBHYUJXHARD a, DTMIGTPTCBF b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x8642E00", Offset = "0x8641E00", VA = "0x188642E00")]
		public NWSBAJRWZID()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[ConfigPropertyDrawer(typeof(FixedString64Bytes))]
	internal class VORLHEWISXK : JKNDBWBGVVH<FixedString64Bytes>
	{
		[Cpp2IlInjected.Token(Token = "0x2000014")]
		[CompilerGenerated]
		private sealed class DDFDKRDHJEJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000010")]
			public OBHYUJXHARD WHJHTCRZRRQ;

			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0xAD2EF0", Offset = "0xAD1EF0", VA = "0x180AD2EF0")]
			public DDFDKRDHJEJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x8640CD0", Offset = "0x863FCD0", VA = "0x188640CD0")]
			internal string CWOXSEPOALF()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x8640B20", Offset = "0x863FB20", VA = "0x188640B20")]
			internal void CWJQUXVQQZW(string a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x8646A40", Offset = "0x8645A40", VA = "0x188646A40", Slot = "5")]
		public override void DPNMDIIUTVH(OBHYUJXHARD a, DTMIGTPTCBF b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x8646BD0", Offset = "0x8645BD0", VA = "0x188646BD0")]
		public VORLHEWISXK()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	[ConfigPropertyDrawer(typeof(float3))]
	internal class CUYGNQGONVG : JKNDBWBGVVH<float3>
	{
		[Cpp2IlInjected.Token(Token = "0x2000016")]
		[CompilerGenerated]
		private sealed class DDFDKRDHJEJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000011")]
			public OBHYUJXHARD WHJHTCRZRRQ;

			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0xAD2EF0", Offset = "0xAD1EF0", VA = "0x180AD2EF0")]
			public DDFDKRDHJEJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x8640C20", Offset = "0x863FC20", VA = "0x188640C20")]
			internal float CWOXSEPOALF()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x8640A90", Offset = "0x863FA90", VA = "0x188640A90")]
			internal void CWJQUXVQQZW(float a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x8640D80", Offset = "0x863FD80", VA = "0x188640D80")]
			internal float CWZLMSDITHX()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x8640D60", Offset = "0x863FD60", VA = "0x188640D60")]
			internal void CWUEPLJLJWO(float a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x8640E20", Offset = "0x863FE20", VA = "0x188640E20")]
			internal float CXJZHFRDMEP()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x8640E00", Offset = "0x863FE00", VA = "0x188640E00")]
			internal void CXESJYXGCTG(float a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x86409D0", Offset = "0x863F9D0", VA = "0x1886409D0")]
			internal float BCDFNYDYWEQ(int a)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x8640E90", Offset = "0x863FE90", VA = "0x188640E90")]
			internal void JFNFZKJKEAX(int a, float b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x863F280", Offset = "0x863E280", VA = "0x18863F280", Slot = "5")]
		public override void DPNMDIIUTVH(OBHYUJXHARD a, DTMIGTPTCBF b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x863F680", Offset = "0x863E680", VA = "0x18863F680")]
		public CUYGNQGONVG()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[ConfigPropertyDrawer(typeof(float))]
	internal class TZKCQLEIRVN : JKNDBWBGVVH<float>
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x8646720", Offset = "0x8645720", VA = "0x188646720", Slot = "5")]
		public override void DPNMDIIUTVH(OBHYUJXHARD a, DTMIGTPTCBF b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x86467B0", Offset = "0x86457B0", VA = "0x1886467B0")]
		public TZKCQLEIRVN()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[ConfigPropertyDrawer(typeof(int))]
	internal class ZBMRMSNCEJK : JKNDBWBGVVH<int>
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x8646C10", Offset = "0x8645C10", VA = "0x188646C10", Slot = "5")]
		public override void DPNMDIIUTVH(OBHYUJXHARD a, DTMIGTPTCBF b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x8646CA0", Offset = "0x8645CA0", VA = "0x188646CA0")]
		public ZBMRMSNCEJK()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	[ConfigPropertyDrawer(typeof(quaternion))]
	internal class HLSRHYDZGDJ : JKNDBWBGVVH<quaternion>
	{
		[Cpp2IlInjected.Token(Token = "0x200001A")]
		[CompilerGenerated]
		private sealed class DDFDKRDHJEJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000012")]
			public OBHYUJXHARD WHJHTCRZRRQ;

			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0xAD2EF0", Offset = "0xAD1EF0", VA = "0x180AD2EF0")]
			public DDFDKRDHJEJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x8640BB0", Offset = "0x863FBB0", VA = "0x188640BB0")]
			internal float CWOXSEPOALF()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x8640AA0", Offset = "0x863FAA0", VA = "0x188640AA0")]
			internal void CWJQUXVQQZW(float a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x8640D70", Offset = "0x863FD70", VA = "0x188640D70")]
			internal float CWZLMSDITHX()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x8640D50", Offset = "0x863FD50", VA = "0x188640D50")]
			internal void CWUEPLJLJWO(float a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x8640E10", Offset = "0x863FE10", VA = "0x188640E10")]
			internal float CXJZHFRDMEP()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x8640DF0", Offset = "0x863FDF0", VA = "0x188640DF0")]
			internal void CXESJYXGCTG(float a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x86411D0", Offset = "0x86401D0", VA = "0x1886411D0")]
			internal float ZDCCWERAWZT(int a)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x8640F70", Offset = "0x863FF70", VA = "0x188640F70")]
			internal void OEWAGDTDYUO(int a, float b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x8642500", Offset = "0x8641500", VA = "0x188642500", Slot = "5")]
		public override void DPNMDIIUTVH(OBHYUJXHARD a, DTMIGTPTCBF b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x8642900", Offset = "0x8641900", VA = "0x188642900")]
		public HLSRHYDZGDJ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[ConfigPropertyDrawer(typeof(uint))]
	internal class FEIMPGGPVRR : JKNDBWBGVVH<uint>
	{
		[Cpp2IlInjected.Token(Token = "0x200001C")]
		[CompilerGenerated]
		private sealed class DDFDKRDHJEJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000013")]
			public OBHYUJXHARD WHJHTCRZRRQ;

			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0xAD2EF0", Offset = "0xAD1EF0", VA = "0x180AD2EF0")]
			public DDFDKRDHJEJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x8640C90", Offset = "0x863FC90", VA = "0x188640C90")]
			internal int CWOXSEPOALF()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x8640A40", Offset = "0x863FA40", VA = "0x188640A40")]
			internal void CWJQUXVQQZW(int a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x8641BA0", Offset = "0x8640BA0", VA = "0x188641BA0", Slot = "5")]
		public override void DPNMDIIUTVH(OBHYUJXHARD a, DTMIGTPTCBF b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x8641D30", Offset = "0x8640D30", VA = "0x188641D30")]
		public FEIMPGGPVRR()
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
	internal static class UXMSPFDOYZW
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x86467F0", Offset = "0x86457F0", VA = "0x1886467F0")]
		public static void UFEENVEOPAM(Type a, Type b)
		{
		}
	}
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	internal struct CommonProperties
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x863F7B0", Offset = "0x863E7B0", VA = "0x18863F7B0")]
		public static NativeList<NetworkProperty> QPXQHGGUSTR(NativeObjectLocalIdArray a, NVEEAEOMCJO b)
		{
			return default(NativeList<NetworkProperty>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x863F6C0", Offset = "0x863E6C0", VA = "0x18863F6C0")]
		private static bool NZKZQJYQPYO(NetworkProperty a, NativeObjectLocalIdArray b)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public class GJOCUPYRYJG : OBHYUJXHARD, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private readonly NetworkProperty WHJHTCRZRRQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private readonly NVEEAEOMCJO FMXIWXRRCIK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private readonly NativeObjectLocalIdArray AMIPJTXNTIX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private bool HORTZAXUTKY;

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public string QQXGIPEDADO
		{
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x86423B0", Offset = "0x86413B0", VA = "0x1886423B0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public bool SDYQODCXKLO
		{
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x8641E40", Offset = "0x8640E40", VA = "0x188641E40", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public RRObject GWOKFAMLHAU
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x8641FF0", Offset = "0x8640FF0", VA = "0x188641FF0", Slot = "8")]
			get
			{
				return default(RRObject);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public Type GLAENVNETGX
		{
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x8641FA0", Offset = "0x8640FA0", VA = "0x188641FA0", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action WCTTUXPXALP
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x8642310", Offset = "0x8641310", VA = "0x188642310", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x8642270", Offset = "0x8641270", VA = "0x188642270", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x8642410", Offset = "0x8641410", VA = "0x188642410")]
		public GJOCUPYRYJG(NativeObjectLocalIdArray a, NetworkProperty b, NVEEAEOMCJO c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x8642040", Offset = "0x8641040", VA = "0x188642040")]
		private void SWYIKQLMLXU(BulkPropertyChangeData a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x8641EC0", Offset = "0x8640EC0", VA = "0x188641EC0", Slot = "10")]
		public void Get(MutableRef value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x8642150", Offset = "0x8641150", VA = "0x188642150", Slot = "11")]
		public void Set(ReadOnlyRef value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x8641D70", Offset = "0x8640D70", VA = "0x188641D70", Slot = "12")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[SpecificPropertyDrawer(1)]
	internal sealed class RHRRVEVYTDH : QMIKLEXNCFU, ACVMUXEQEVM, DSFFAMYQGNU
	{
		[Cpp2IlInjected.Token(Token = "0x2000022")]
		[CompilerGenerated]
		private sealed class MJLEUFQBZLJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			public OBHYUJXHARD WHJHTCRZRRQ;

			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0xAD2EF0", Offset = "0xAD1EF0", VA = "0x180AD2EF0")]
			public MJLEUFQBZLJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0x8642AC0", Offset = "0x8641AC0", VA = "0x188642AC0")]
			internal bool CWOXSEPOALF()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0x8642A40", Offset = "0x8641A40", VA = "0x188642A40")]
			internal string CWJQUXVQQZW()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0x8642BE0", Offset = "0x8641BE0", VA = "0x188642BE0")]
			internal void CWZLMSDITHX(string a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0x8642B10", Offset = "0x8641B10", VA = "0x188642B10")]
			internal string CWUEPLJLJWO()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public NetworkProperty OZXNKABXNMS
		{
			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x8646650", Offset = "0x8645650", VA = "0x188646650", Slot = "4")]
			get
			{
				return default(NetworkProperty);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x8646220", Offset = "0x8645220", VA = "0x188646220", Slot = "5")]
		public void DPNMDIIUTVH(OBHYUJXHARD a, DTMIGTPTCBF b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0xAD2EF0", Offset = "0xAD1EF0", VA = "0x180AD2EF0")]
		public RHRRVEVYTDH()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	internal class RBCMIYSLPSR
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private readonly NVEEAEOMCJO MDSVUQABNBV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private readonly DTMIGTPTCBF VOCNWKIVDXT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private readonly Action<Candidate> FMWBTAXKZBQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private readonly HashSet<GBHEHATLJQF> KTFJSJQIILF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private readonly Dictionary<GBHEHATLJQF, List<Candidate>> MEOLOIESMMB;

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x8646110", Offset = "0x8645110", VA = "0x188646110")]
		public RBCMIYSLPSR(NVEEAEOMCJO a, DTMIGTPTCBF b, Action<Candidate> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x8645DD0", Offset = "0x8644DD0", VA = "0x188645DD0")]
		public void VSRSUZNWMXJ(NativeList<Candidate> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x86456D0", Offset = "0x86446D0", VA = "0x1886456D0")]
		private void AETJTFJHLUV(GBHEHATLJQF a, Candidate b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x86458F0", Offset = "0x86448F0", VA = "0x1886458F0")]
		public void RCUGGBPGIKF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x8645950", Offset = "0x8644950", VA = "0x188645950")]
		private void RSVMWYFFAAR(GBHEHATLJQF a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x8645850", Offset = "0x8644850", VA = "0x188645850")]
		private void NJDRACFGZWQ(GBHEHATLJQF a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	internal class PropertiesByType : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x2000025")]
		[CompilerGenerated]
		private sealed class OIRRUHJQEXG : IEnumerable<NetworkProperty>, IEnumerable, IEnumerator<NetworkProperty>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000024")]
			private int NNYUMBTASKT;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x4000025")]
			private NetworkProperty GLROCXYMSEU;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000026")]
			private int CYUNKNWTKTU;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000027")]
			public PropertiesByType SULNKEFFSGR;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000028")]
			private Type HIEWDZSZCDR;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000029")]
			public Type VQIDJBWJZKI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			private NativeParallelMultiHashMap<long, int>.Enumerator NVXWRKLJBUP;

			[Cpp2IlInjected.Token(Token = "0x1700000C")]
			private NetworkProperty RMUXCUWWIRZ
			{
				[Cpp2IlInjected.Token(Token = "0x6000088")]
				[Cpp2IlInjected.Address(RVA = "0xB7CE40", Offset = "0xB7BE40", VA = "0x180B7CE40", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return default(NetworkProperty);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000D")]
			private object OPJHDGDZAVH
			{
				[Cpp2IlInjected.Token(Token = "0x600008A")]
				[Cpp2IlInjected.Address(RVA = "0x8642EF0", Offset = "0x8641EF0", VA = "0x188642EF0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0x13438E0", Offset = "0x13428E0", VA = "0x1813438E0")]
			[DebuggerHidden]
			public OIRRUHJQEXG(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x8642F40", Offset = "0x8641F40", VA = "0x188642F40", Slot = "7")]
			[DebuggerHidden]
			private void FQZHCUDIKGC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0x8642FD0", Offset = "0x8641FD0", VA = "0x188642FD0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0x86432C0", Offset = "0x86422C0", VA = "0x1886432C0")]
			private void QJEWXGNEXZS()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0x8643310", Offset = "0x8642310", VA = "0x188643310", Slot = "10")]
			[DebuggerHidden]
			private void SEWTXRYPVUP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008B")]
			[Cpp2IlInjected.Address(RVA = "0x8642E40", Offset = "0x8641E40", VA = "0x188642E40", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<NetworkProperty> CNUHNNTSHVK()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x8642E40", Offset = "0x8641E40", VA = "0x188642E40", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator HKYUJZELIWO()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private static readonly Log HRODLTCIOIP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private NativeParallelMultiHashMap<long, int> FWKKUBWMISL;

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x86436F0", Offset = "0x86426F0", VA = "0x1886436F0")]
		public PropertiesByType()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x86435E0", Offset = "0x86425E0", VA = "0x1886435E0")]
		[IteratorStateMachine(typeof(OIRRUHJQEXG))]
		public IEnumerable<NetworkProperty> UEGODWEAZLP(Type a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x86434E0", Offset = "0x86424E0", VA = "0x1886434E0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x8643560", Offset = "0x8642560", VA = "0x188643560")]
		private long LCCUSNJOYXS(NetworkProperty a)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x8643520", Offset = "0x8642520", VA = "0x188643520")]
		private long LCCUSNJOYXS(Type a)
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
		[Cpp2IlInjected.Address(RVA = "0x8643C00", Offset = "0x8642C00", VA = "0x188643C00")]
		public PropertyBitmap(int count)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x8643A60", Offset = "0x8642A60", VA = "0x188643A60")]
		public static PropertyBitmap HDIKKQKOFVB(int a, NativeArray<NetworkProperty> b)
		{
			return default(PropertyBitmap);
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x8643A50", Offset = "0x8642A50", VA = "0x188643A50")]
		public bool GTMCYRBXTQF(int a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x8643BF0", Offset = "0x8642BF0", VA = "0x188643BF0")]
		public void Set(int index, bool value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x86438E0", Offset = "0x86428E0", VA = "0x1886438E0")]
		public bool All(NetworkProperty[] properties)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x8643990", Offset = "0x8642990", VA = "0x188643990")]
		public bool Any(NetworkProperty[] properties)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x8643A40", Offset = "0x8642A40", VA = "0x188643A40", Slot = "4")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	internal class PropertyDrawerCandidates
	{
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private static readonly Log HRODLTCIOIP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private readonly NVEEAEOMCJO MDSVUQABNBV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private readonly List<DSFFAMYQGNU> AFGKLJIGVBR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private readonly PropertiesByType FWKKUBWMISL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private NativeParallelMultiHashMap<int, int> QTDFKBDURJB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private NativeList<int> TEQCXDTIUKT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private bool HORTZAXUTKY;

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public List<DSFFAMYQGNU> TABQGUOANIL
		{
			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(RVA = "0xACF7F0", Offset = "0xACE7F0", VA = "0x180ACF7F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x8644E10", Offset = "0x8643E10", VA = "0x188644E10")]
		public PropertyDrawerCandidates(NVEEAEOMCJO configPropertyService)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x8644170", Offset = "0x8643170", VA = "0x188644170")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x8644970", Offset = "0x8643970", VA = "0x188644970")]
		public void WHSIEBGTJKO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x86444A0", Offset = "0x86434A0", VA = "0x1886444A0")]
		public NativeList<Candidate> MTBQOLGDJTV(NativeArray<NetworkProperty> a)
		{
			return default(NativeList<Candidate>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x8644250", Offset = "0x8643250", VA = "0x188644250")]
		private bool ICHGZQFBKGZ(DSFFAMYQGNU a, PropertyBitmap b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x39C5050", Offset = "0x39C4050", VA = "0x1839C5050")]
		private void DCAPAJWEFTG<b, a>(Action<b, a> a) where b : DSFFAMYQGNU where a : Attribute
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x8644470", Offset = "0x8643470", VA = "0x188644470")]
		private void KEVLYSYAVYO(Type a, Type b, Type c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x39C5360", Offset = "0x39C4360", VA = "0x1839C5360")]
		private c SEFULJWAKXR<c>(Type a)
		{
			return (c)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x8643F70", Offset = "0x8642F70", VA = "0x188643F70")]
		private int BQERYBRFLTU(DSFFAMYQGNU a, int b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x8644B10", Offset = "0x8643B10", VA = "0x188644B10")]
		private void ZNUODBAVHJQ(ACVMUXEQEVM a, ConfigPropertyDrawer b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x8643C50", Offset = "0x8642C50", VA = "0x188643C50")]
		private void AKYDFEAHFSL(VCJUOFWRGLN a, MatchPropertyDrawer b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x8644060", Offset = "0x8643060", VA = "0x188644060")]
		private void CCOXDCBYOPN(NXKHFDMKJXR a, MultiPropertyDrawer b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x86443A0", Offset = "0x86433A0", VA = "0x1886443A0")]
		private void IZJOSBUKHXU(QMIKLEXNCFU a, SpecificPropertyDrawer b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	internal struct PropertyShadowing : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private readonly List<DSFFAMYQGNU> drawers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private NativeList<Candidate> unshadowed;

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public NativeList<Candidate> UISYOBLVDWN
		{
			[Cpp2IlInjected.Token(Token = "0x60000A3")]
			[Cpp2IlInjected.Address(RVA = "0xCC4250", Offset = "0xCC3250", VA = "0x180CC4250")]
			get
			{
				return default(NativeList<Candidate>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x8645530", Offset = "0x8644530", VA = "0x188645530")]
		public PropertyShadowing(List<DSFFAMYQGNU> drawers, NativeArray<Candidate> candidates)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x86450C0", Offset = "0x86440C0", VA = "0x1886450C0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x8645230", Offset = "0x8644230", VA = "0x188645230")]
		private NativeList<Candidate> OZLTQVTHGAR(NativeArray<Candidate> a)
		{
			return default(NativeList<Candidate>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x8644F50", Offset = "0x8643F50", VA = "0x188644F50")]
		private bool ARRQCBGSQAK(DSFFAMYQGNU a, PropertyBitmap b, NetworkProperty c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x8645100", Offset = "0x8644100", VA = "0x188645100")]
		private void JJSVHWFTFEZ(DSFFAMYQGNU a, PropertyBitmap b, NetworkProperty c)
		{
		}
	}
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	internal struct SortCandidatesByPriority : IComparer<Candidate>
	{
		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x86466C0", Offset = "0x86456C0", VA = "0x1886466C0", Slot = "4")]
		public int Compare(Candidate a, Candidate b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x86466D0", Offset = "0x86456D0", VA = "0x1886466D0")]
		public static void Sort(NativeList<Candidate> candidates)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	[AttributeUsage(AttributeTargets.Class)]
	public class SpecificPropertyDrawer : ConfigPropertyDrawerBase
	{
		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x8646710", Offset = "0x8645710", VA = "0x188646710")]
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
