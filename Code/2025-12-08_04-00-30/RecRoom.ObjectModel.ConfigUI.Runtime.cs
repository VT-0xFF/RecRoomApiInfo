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
		[Cpp2IlInjected.Address(RVA = "0x83E44B0", Offset = "0x83E2CB0", VA = "0x1883E44B0", Slot = "4")]
		public override void JIBLBJTHOBM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xAC98A0", Offset = "0xAC80A0", VA = "0x180AC98A0")]
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
		private int[] TVXWIVSLKTH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private ServiceBitset EJWMBZOWMVA;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public override string[] ServiceCategories
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0xAA15F0", Offset = "0xA9FDF0", VA = "0x180AA15F0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x83EA140", Offset = "0x83E8940", VA = "0x1883EA140", Slot = "5")]
		public override void SetServiceCategoryIndices(List<int> globalFromLocalIndices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x83E97B0", Offset = "0x83E7FB0", VA = "0x1883E97B0")]
		private void ANRTHLCVEKO(IServiceRegistration a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x83E99D0", Offset = "0x83E81D0", VA = "0x1883E99D0", Slot = "6")]
		public override void RegisterServices(IServiceRegistration registry, [In] ServiceBitsetFilter filter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x83E9A30", Offset = "0x83E8230", VA = "0x1883E9A30", Slot = "7")]
		public override void RegisterTypes(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x83EA160", Offset = "0x83E8960", VA = "0x1883EA160")]
		public _AssemblyIndex()
		{
		}
	}
}
namespace RecRoom.ObjectModel.ConfigUI
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	internal abstract class MKZEAYEOSOC : GJGDCRADNUU<Enum>, ZUNGZYNWFGH, PRMLUTUQWHU, XUGRFQWRVMO
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "7")]
		public abstract bool RFPAVOIQIBO(Type a);

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x83E4470", Offset = "0x83E2C70", VA = "0x1883E4470")]
		protected MKZEAYEOSOC()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	internal abstract class GJGDCRADNUU<a> : PRMLUTUQWHU, XUGRFQWRVMO where a : Enum
	{
		[Cpp2IlInjected.Token(Token = "0x2000006")]
		[CompilerGenerated]
		private sealed class CGPLWVDWZDM
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000004")]
			public YJVAKODYZZD XUYIMOPZMJI;

			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0xAA6A60", Offset = "0xAA5260", VA = "0x180AA6A60")]
			public CGPLWVDWZDM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x3D336B0", Offset = "0x3D31EB0", VA = "0x183D336B0")]
			internal bool GKAQHTOYQCZ()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x4DCC990", Offset = "0x4DCB190", VA = "0x184DCC990")]
		protected GJGDCRADNUU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x4DCC1A0", Offset = "0x4DCA9A0", VA = "0x184DCC1A0")]
		protected void IHWVEWOLOQP(CSUJRKKPPCK a, YJVAKODYZZD b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x4DCC790", Offset = "0x4DCAF90", VA = "0x184DCC790")]
		protected void MKYBLQTABJH(QQWWLJINELP<a> a, YJVAKODYZZD b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "5")]
		public abstract void THPRDRPBRTH(YJVAKODYZZD a, QJXNCQOTCYD b);
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	internal abstract class JFBVAARHBYZ : RWGFYDDLZCH, XUGRFQWRVMO
	{
		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public abstract NetworkProperty[] KSBZJLLZMPC
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(Slot = "7")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public abstract NetworkProperty[] UNQQJBVNASL
		{
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(Slot = "8")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(Slot = "9")]
		public abstract void THPRDRPBRTH(YJVAKODYZZD a, ZVZULZESFLY b, SWDFGOAGXHK c, QJXNCQOTCYD d);

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x3710100", Offset = "0x370E900", VA = "0x183710100")]
		protected static b WSFQZSWBYZH<b>(NativeObjectLocalIdArray a, NetworkProperty<b> b) where b : struct
		{
			return (b)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x370FF10", Offset = "0x370E710", VA = "0x18370FF10")]
		protected static void GCAYKDOCZWY<d>(NativeObjectLocalIdArray a, NetworkProperty<d> b, d c) where d : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0xAA6A60", Offset = "0xAA5260", VA = "0x180AA6A60")]
		protected JFBVAARHBYZ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	internal abstract class KBUDNADRCZH<a> : PRMLUTUQWHU, XUGRFQWRVMO where a : struct
	{
		[Cpp2IlInjected.Token(Token = "0x2000009")]
		[CompilerGenerated]
		private sealed class CGPLWVDWZDM
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000005")]
			public YJVAKODYZZD XUYIMOPZMJI;

			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0xAA6A60", Offset = "0xAA5260", VA = "0x180AA6A60")]
			public CGPLWVDWZDM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x3D33480", Offset = "0x3D31C80", VA = "0x183D33480")]
			internal bool GKAQHTOYQCZ()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x4DCC990", Offset = "0x4DCB190", VA = "0x184DCC990")]
		protected KBUDNADRCZH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x51FE010", Offset = "0x51FC810", VA = "0x1851FE010")]
		protected void IHWVEWOLOQP(CSUJRKKPPCK a, YJVAKODYZZD b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x51FEC00", Offset = "0x51FD400", VA = "0x1851FEC00")]
		protected void MKYBLQTABJH(QQWWLJINELP<a> a, YJVAKODYZZD b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(Slot = "5")]
		public abstract void THPRDRPBRTH(YJVAKODYZZD a, QJXNCQOTCYD b);
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[RegisterService(typeof(ZVZULZESFLY), new string[] { })]
	internal class ConfigUIService : ZVZULZESFLY, PFYTZJIIFSI, XVYQGXFPXEO, TTDQLFCDEXA, TFZKCIODVYK
	{
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private static readonly Log RKIUKOTABJV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		[DependsOn]
		private SWDFGOAGXHK QDXWLUELGXZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		[DependsOn]
		private QJXNCQOTCYD ELSXMSMJQQF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private PropertyDrawerCandidates YVZHQBUXTVS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private NativeObjectLocalIdArray ECFCGSIWBLN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private List<YJVAKODYZZD> TMMXHZOXFGI;

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public NativeObjectLocalIdArray NDZKUQJMMTR
		{
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x1440AE0", Offset = "0x143F2E0", VA = "0x181440AE0", Slot = "5")]
			get
			{
				return default(NativeObjectLocalIdArray);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x83E3050", Offset = "0x83E1850", VA = "0x1883E3050", Slot = "6")]
		public void InitExternal(BDQJEHGTRBM services)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x83E2CF0", Offset = "0x83E14F0", VA = "0x1883E2CF0", Slot = "7")]
		public void BTTVCOLODYQ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x83E33E0", Offset = "0x83E1BE0", VA = "0x1883E33E0", Slot = "4")]
		public void SKLYAHNPKJV(NativeObjectLocalIdArray a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x83E3370", Offset = "0x83E1B70", VA = "0x1883E3370")]
		private void MXSGUQLLHYB(NativeObjectLocalIdArray a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x83E2E60", Offset = "0x83E1660", VA = "0x1883E2E60")]
		private void EILYSZPRDQW()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x83E3850", Offset = "0x83E2050", VA = "0x1883E3850")]
		private void THPRDRPBRTH(Candidate a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x83E2DF0", Offset = "0x83E15F0", VA = "0x1883E2DF0", Slot = "8")]
		private void EFSYMFFESBS(BDQJEHGTRBM a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0xD48920", Offset = "0xD47120", VA = "0x180D48920", Slot = "9")]
		private void MIIBQCGEILO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x83E3C00", Offset = "0x83E2400", VA = "0x1883E3C00")]
		public ConfigUIService()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[MatchPropertyDrawer(0)]
	internal class QUQEHRJBFPY : MKZEAYEOSOC
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x83E8690", Offset = "0x83E6E90", VA = "0x1883E8690", Slot = "5")]
		public override void THPRDRPBRTH(YJVAKODYZZD a, QJXNCQOTCYD b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x83E85F0", Offset = "0x83E6DF0", VA = "0x1883E85F0", Slot = "7")]
		public override bool RFPAVOIQIBO(Type a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x83E4470", Offset = "0x83E2C70", VA = "0x1883E4470")]
		public QUQEHRJBFPY()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[MatchPropertyDrawer(0)]
	internal class JQWFJJJCCTF : MKZEAYEOSOC
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x83E43C0", Offset = "0x83E2BC0", VA = "0x1883E43C0", Slot = "5")]
		public override void THPRDRPBRTH(YJVAKODYZZD a, QJXNCQOTCYD b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x83E4320", Offset = "0x83E2B20", VA = "0x1883E4320", Slot = "7")]
		public override bool RFPAVOIQIBO(Type a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x83E4470", Offset = "0x83E2C70", VA = "0x1883E4470")]
		public JQWFJJJCCTF()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[ConfigPropertyDrawer(typeof(RenderableColor), 1)]
	internal class BEOCAMPKXBA : GJGDCRADNUU<RenderableColor>
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x83E1CC0", Offset = "0x83E04C0", VA = "0x1883E1CC0", Slot = "5")]
		public override void THPRDRPBRTH(YJVAKODYZZD a, QJXNCQOTCYD b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x83E1E10", Offset = "0x83E0610", VA = "0x1883E1E10")]
		public BEOCAMPKXBA()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[MultiPropertyDrawer(2)]
	internal class VFVWZODFTBA : JFBVAARHBYZ
	{
		[Cpp2IlInjected.Token(Token = "0x200000F")]
		[CompilerGenerated]
		private sealed class PBZSWMUOFRV
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400000E")]
			public ZVZULZESFLY SLDPSBJXHEW;

			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0xAA6A60", Offset = "0xAA5260", VA = "0x180AA6A60")]
			public PBZSWMUOFRV()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x83E5990", Offset = "0x83E4190", VA = "0x1883E5990")]
			internal (int, int) NEFTUSTAFBR()
			{
				return default((int, int));
			}

			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x83E5850", Offset = "0x83E4050", VA = "0x1883E5850")]
			internal void NEAMXLZCVQI((int color, int material) value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public override NetworkProperty[] KSBZJLLZMPC
		{
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0xAA1AA0", Offset = "0xAA02A0", VA = "0x180AA1AA0", Slot = "7")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public override NetworkProperty[] UNQQJBVNASL
		{
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0xAA1610", Offset = "0xA9FE10", VA = "0x180AA1610", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x83E8DE0", Offset = "0x83E75E0", VA = "0x1883E8DE0", Slot = "9")]
		public override void THPRDRPBRTH(YJVAKODYZZD a, ZVZULZESFLY b, SWDFGOAGXHK c, QJXNCQOTCYD d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x83E9190", Offset = "0x83E7990", VA = "0x1883E9190")]
		public VFVWZODFTBA()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[ConfigPropertyDrawer(typeof(bool))]
	internal class TPKKKEBLJVJ : KBUDNADRCZH<bool>
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x83E8870", Offset = "0x83E7070", VA = "0x1883E8870", Slot = "5")]
		public override void THPRDRPBRTH(YJVAKODYZZD a, QJXNCQOTCYD b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x83E8900", Offset = "0x83E7100", VA = "0x1883E8900")]
		public TPKKKEBLJVJ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[ConfigPropertyDrawer(typeof(FixedString32Bytes))]
	internal class NJQTLQBVUXN : KBUDNADRCZH<FixedString32Bytes>
	{
		[Cpp2IlInjected.Token(Token = "0x2000012")]
		[CompilerGenerated]
		private sealed class QFMADIQWEXT
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400000F")]
			public YJVAKODYZZD XUYIMOPZMJI;

			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0xAA6A60", Offset = "0xAA5260", VA = "0x180AA6A60")]
			public QFMADIQWEXT()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x83E8350", Offset = "0x83E6B50", VA = "0x1883E8350")]
			internal string NEFTUSTAFBR()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x83E8210", Offset = "0x83E6A10", VA = "0x1883E8210")]
			internal void NEAMXLZCVQI(string a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x83E45B0", Offset = "0x83E2DB0", VA = "0x1883E45B0", Slot = "5")]
		public override void THPRDRPBRTH(YJVAKODYZZD a, QJXNCQOTCYD b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x83E4740", Offset = "0x83E2F40", VA = "0x1883E4740")]
		public NJQTLQBVUXN()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[ConfigPropertyDrawer(typeof(FixedString64Bytes))]
	internal class HPYLQRYFHNW : KBUDNADRCZH<FixedString64Bytes>
	{
		[Cpp2IlInjected.Token(Token = "0x2000014")]
		[CompilerGenerated]
		private sealed class QFMADIQWEXT
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000010")]
			public YJVAKODYZZD XUYIMOPZMJI;

			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0xAA6A60", Offset = "0xAA5260", VA = "0x180AA6A60")]
			public QFMADIQWEXT()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x83E82D0", Offset = "0x83E6AD0", VA = "0x1883E82D0")]
			internal string NEFTUSTAFBR()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x83E8160", Offset = "0x83E6960", VA = "0x1883E8160")]
			internal void NEAMXLZCVQI(string a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x83E3F80", Offset = "0x83E2780", VA = "0x1883E3F80", Slot = "5")]
		public override void THPRDRPBRTH(YJVAKODYZZD a, QJXNCQOTCYD b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x83E4110", Offset = "0x83E2910", VA = "0x1883E4110")]
		public HPYLQRYFHNW()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	[ConfigPropertyDrawer(typeof(float3))]
	internal class NTCBVOJPDNC : KBUDNADRCZH<float3>
	{
		[Cpp2IlInjected.Token(Token = "0x2000016")]
		[CompilerGenerated]
		private sealed class QFMADIQWEXT
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000011")]
			public YJVAKODYZZD XUYIMOPZMJI;

			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0xAA6A60", Offset = "0xAA5260", VA = "0x180AA6A60")]
			public QFMADIQWEXT()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x83E83F0", Offset = "0x83E6BF0", VA = "0x1883E83F0")]
			internal float NEFTUSTAFBR()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x83E8200", Offset = "0x83E6A00", VA = "0x1883E8200")]
			internal void NEAMXLZCVQI(float a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x83E84A0", Offset = "0x83E6CA0", VA = "0x1883E84A0")]
			internal float NEQHPGGUXYJ()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x83E8480", Offset = "0x83E6C80", VA = "0x1883E8480")]
			internal void NELARZMXONA(float a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x83E80F0", Offset = "0x83E68F0", VA = "0x1883E80F0")]
			internal float NDKSFRRKTIH()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x83E80D0", Offset = "0x83E68D0", VA = "0x1883E80D0")]
			internal void NDFLIKXNJWY(float a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x83E7DF0", Offset = "0x83E65F0", VA = "0x1883E7DF0")]
			internal float AUTGYUOHUYU(int a)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x83E8510", Offset = "0x83E6D10", VA = "0x1883E8510")]
			internal void XEDTWAVUHNN(int a, float b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x83E4F10", Offset = "0x83E3710", VA = "0x1883E4F10", Slot = "5")]
		public override void THPRDRPBRTH(YJVAKODYZZD a, QJXNCQOTCYD b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x83E5310", Offset = "0x83E3B10", VA = "0x1883E5310")]
		public NTCBVOJPDNC()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[ConfigPropertyDrawer(typeof(float))]
	internal class SMHXUMDSMYH : KBUDNADRCZH<float>
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x83E8740", Offset = "0x83E6F40", VA = "0x1883E8740", Slot = "5")]
		public override void THPRDRPBRTH(YJVAKODYZZD a, QJXNCQOTCYD b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x83E87D0", Offset = "0x83E6FD0", VA = "0x1883E87D0")]
		public SMHXUMDSMYH()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[ConfigPropertyDrawer(typeof(int))]
	internal class DVCXJJLMXKI : KBUDNADRCZH<int>
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x83E3C80", Offset = "0x83E2480", VA = "0x1883E3C80", Slot = "5")]
		public override void THPRDRPBRTH(YJVAKODYZZD a, QJXNCQOTCYD b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x83E3D10", Offset = "0x83E2510", VA = "0x1883E3D10")]
		public DVCXJJLMXKI()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	[ConfigPropertyDrawer(typeof(quaternion))]
	internal class WTDLWXUAIJZ : KBUDNADRCZH<quaternion>
	{
		[Cpp2IlInjected.Token(Token = "0x200001A")]
		[CompilerGenerated]
		private sealed class QFMADIQWEXT
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000012")]
			public YJVAKODYZZD XUYIMOPZMJI;

			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0xAA6A60", Offset = "0xAA5260", VA = "0x180AA6A60")]
			public QFMADIQWEXT()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x83E8460", Offset = "0x83E6C60", VA = "0x1883E8460")]
			internal float NEFTUSTAFBR()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x83E81F0", Offset = "0x83E69F0", VA = "0x1883E81F0")]
			internal void NEAMXLZCVQI(float a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x83E8490", Offset = "0x83E6C90", VA = "0x1883E8490")]
			internal float NEQHPGGUXYJ()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x83E8470", Offset = "0x83E6C70", VA = "0x1883E8470")]
			internal void NELARZMXONA(float a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x83E80E0", Offset = "0x83E68E0", VA = "0x1883E80E0")]
			internal float NDKSFRRKTIH()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x83E80C0", Offset = "0x83E68C0", VA = "0x1883E80C0")]
			internal void NDFLIKXNJWY(float a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x83E7C90", Offset = "0x83E6490", VA = "0x1883E7C90")]
			internal float APHIKKNVOER(int a)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x83E7E60", Offset = "0x83E6660", VA = "0x1883E7E60")]
			internal void LZASJANLAFA(int a, float b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x83E92B0", Offset = "0x83E7AB0", VA = "0x1883E92B0", Slot = "5")]
		public override void THPRDRPBRTH(YJVAKODYZZD a, QJXNCQOTCYD b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x83E96B0", Offset = "0x83E7EB0", VA = "0x1883E96B0")]
		public WTDLWXUAIJZ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[ConfigPropertyDrawer(typeof(uint))]
	internal class IPGIZAYGUKH : KBUDNADRCZH<uint>
	{
		[Cpp2IlInjected.Token(Token = "0x200001C")]
		[CompilerGenerated]
		private sealed class QFMADIQWEXT
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000013")]
			public YJVAKODYZZD XUYIMOPZMJI;

			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0xAA6A60", Offset = "0xAA5260", VA = "0x180AA6A60")]
			public QFMADIQWEXT()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x83E83B0", Offset = "0x83E6BB0", VA = "0x1883E83B0")]
			internal int NEFTUSTAFBR()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x83E8280", Offset = "0x83E6A80", VA = "0x1883E8280")]
			internal void NEAMXLZCVQI(int a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x83E4150", Offset = "0x83E2950", VA = "0x1883E4150", Slot = "5")]
		public override void THPRDRPBRTH(YJVAKODYZZD a, QJXNCQOTCYD b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x83E42E0", Offset = "0x83E2AE0", VA = "0x1883E42E0")]
		public IPGIZAYGUKH()
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
	internal static class ZRPVLLFYKUE
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x83E96F0", Offset = "0x83E7EF0", VA = "0x1883E96F0")]
		public static void AEZOSXYBOGY(Type a, Type b)
		{
		}
	}
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	internal struct CommonProperties
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x83E2980", Offset = "0x83E1180", VA = "0x1883E2980")]
		public static NativeList<NetworkProperty> MWAJSUCANPZ(NativeObjectLocalIdArray a, SWDFGOAGXHK b)
		{
			return default(NativeList<NetworkProperty>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x83E2C00", Offset = "0x83E1400", VA = "0x1883E2C00")]
		private static bool XJGJLMIJBUS(NetworkProperty a, NativeObjectLocalIdArray b)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public class NMLPREXENVG : YJVAKODYZZD, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private readonly NetworkProperty XUYIMOPZMJI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private readonly SWDFGOAGXHK YROWTQXMMNE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private readonly NativeObjectLocalIdArray ECFCGSIWBLN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private bool VACBKMVGOGA;

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public string NRBYPZADYJW
		{
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x83E4780", Offset = "0x83E2F80", VA = "0x1883E4780", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public bool MVQOJPYSRSA
		{
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x83E4830", Offset = "0x83E3030", VA = "0x1883E4830", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public RRObject ZQWCMTTOUIE
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x83E4B00", Offset = "0x83E3300", VA = "0x1883E4B00", Slot = "8")]
			get
			{
				return default(RRObject);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public Type BFJYMHQJKIL
		{
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x83E47E0", Offset = "0x83E2FE0", VA = "0x1883E47E0", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action JVBKRTKHQOF
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x83E4D80", Offset = "0x83E3580", VA = "0x1883E4D80", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x83E48B0", Offset = "0x83E30B0", VA = "0x1883E48B0", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x83E4E20", Offset = "0x83E3620", VA = "0x1883E4E20")]
		public NMLPREXENVG(NativeObjectLocalIdArray a, NetworkProperty b, SWDFGOAGXHK c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x83E4C70", Offset = "0x83E3470", VA = "0x1883E4C70")]
		private void WKTCODEYBUO(BulkPropertyChangeData a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x83E4A20", Offset = "0x83E3220", VA = "0x1883E4A20", Slot = "10")]
		public void Get(MutableRef value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x83E4B50", Offset = "0x83E3350", VA = "0x1883E4B50", Slot = "11")]
		public void Set(ReadOnlyRef value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x83E4950", Offset = "0x83E3150", VA = "0x1883E4950", Slot = "12")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[SpecificPropertyDrawer(1)]
	internal sealed class UEYBTGACVBX : ZNZOYWNPNRE, PRMLUTUQWHU, XUGRFQWRVMO
	{
		[Cpp2IlInjected.Token(Token = "0x2000022")]
		[CompilerGenerated]
		private sealed class GZWDQNLWZKX
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			public YJVAKODYZZD XUYIMOPZMJI;

			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0xAA6A60", Offset = "0xAA5260", VA = "0x180AA6A60")]
			public GZWDQNLWZKX()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0x83E3DD0", Offset = "0x83E25D0", VA = "0x1883E3DD0")]
			internal bool NEFTUSTAFBR()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0x83E3D50", Offset = "0x83E2550", VA = "0x1883E3D50")]
			internal string NEAMXLZCVQI()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0x83E3EF0", Offset = "0x83E26F0", VA = "0x1883E3EF0")]
			internal void NEQHPGGUXYJ(string a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0x83E3E20", Offset = "0x83E2620", VA = "0x1883E3E20")]
			internal string NELARZMXONA()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public NetworkProperty PPRLZTXFBIO
		{
			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x83E8D70", Offset = "0x83E7570", VA = "0x1883E8D70", Slot = "4")]
			get
			{
				return default(NetworkProperty);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x83E8940", Offset = "0x83E7140", VA = "0x1883E8940", Slot = "5")]
		public void THPRDRPBRTH(YJVAKODYZZD a, QJXNCQOTCYD b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0xAA6A60", Offset = "0xAA5260", VA = "0x180AA6A60")]
		public UEYBTGACVBX()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	internal class BVARXDJOILP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private readonly SWDFGOAGXHK QDXWLUELGXZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private readonly QJXNCQOTCYD GVKEUSTQPQV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private readonly Action<Candidate> JWZQLADBQLU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private readonly HashSet<AUXLFWFIQJL> DSTELEGGUVN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private readonly Dictionary<AUXLFWFIQJL, List<Candidate>> LJSVBPACSIF;

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x83E2870", Offset = "0x83E1070", VA = "0x1883E2870")]
		public BVARXDJOILP(SWDFGOAGXHK a, QJXNCQOTCYD b, Action<Candidate> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x83E2530", Offset = "0x83E0D30", VA = "0x1883E2530")]
		public void HBVPXEVOJIP(NativeList<Candidate> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x83E23C0", Offset = "0x83E0BC0", VA = "0x1883E23C0")]
		private void FDIUBULSSCZ(AUXLFWFIQJL a, Candidate b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x83E1EF0", Offset = "0x83E06F0", VA = "0x1883E1EF0")]
		public void CQGULTQWVVP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x83E1F50", Offset = "0x83E0750", VA = "0x1883E1F50")]
		private void FCGSWIOUMND(AUXLFWFIQJL a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x83E1E50", Offset = "0x83E0650", VA = "0x1883E1E50")]
		private void BADZRMCTXBG(AUXLFWFIQJL a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	internal class PropertiesByType : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x2000025")]
		[CompilerGenerated]
		private sealed class PBCPPICRIDK : IEnumerable<NetworkProperty>, IEnumerable, IEnumerator<NetworkProperty>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000024")]
			private int ILQFHFJYACP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x4000025")]
			private NetworkProperty YDRMGGSTAGM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000026")]
			private int XJERYWNBAAG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000027")]
			public PropertiesByType VIXLAPAPYNX;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000028")]
			private Type PUQVJDXVEJZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000029")]
			public Type HUJSWXFALOE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			private NativeParallelMultiHashMap<long, int>.Enumerator RECIBZUSAYP;

			[Cpp2IlInjected.Token(Token = "0x1700000C")]
			private NetworkProperty TXXYYDYPVID
			{
				[Cpp2IlInjected.Token(Token = "0x6000088")]
				[Cpp2IlInjected.Address(RVA = "0xB447A0", Offset = "0xB42FA0", VA = "0x180B447A0", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return default(NetworkProperty);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000D")]
			private object IDRIDRBRWXH
			{
				[Cpp2IlInjected.Token(Token = "0x600008A")]
				[Cpp2IlInjected.Address(RVA = "0x83E5630", Offset = "0x83E3E30", VA = "0x1883E5630", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0x12C4CC0", Offset = "0x12C34C0", VA = "0x1812C4CC0")]
			[DebuggerHidden]
			public PBCPPICRIDK(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x83E5680", Offset = "0x83E3E80", VA = "0x1883E5680", Slot = "7")]
			[DebuggerHidden]
			private void QBKHVLXPXWS()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0x83E5350", Offset = "0x83E3B50", VA = "0x1883E5350", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0x83E5710", Offset = "0x83E3F10", VA = "0x1883E5710")]
			private void SNXRWXESNLS()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0x83E5760", Offset = "0x83E3F60", VA = "0x1883E5760", Slot = "10")]
			[DebuggerHidden]
			private void VXYFNEQVOKT()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008B")]
			[Cpp2IlInjected.Address(RVA = "0x83E57A0", Offset = "0x83E3FA0", VA = "0x1883E57A0", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<NetworkProperty> YUJQIWMBCVC()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x83E57A0", Offset = "0x83E3FA0", VA = "0x1883E57A0", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator WFEYQSZVQHA()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private static readonly Log RKIUKOTABJV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private NativeParallelMultiHashMap<long, int> MJVIEYNILHZ;

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x83E5E00", Offset = "0x83E4600", VA = "0x1883E5E00")]
		public PropertiesByType()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x83E5CF0", Offset = "0x83E44F0", VA = "0x1883E5CF0")]
		[IteratorStateMachine(typeof(PBCPPICRIDK))]
		public IEnumerable<NetworkProperty> EEKMDVLAONT(Type a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x83E5CB0", Offset = "0x83E44B0", VA = "0x1883E5CB0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x83E5BF0", Offset = "0x83E43F0", VA = "0x1883E5BF0")]
		private long CBLEWEXBRHC(NetworkProperty a)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x83E5C70", Offset = "0x83E4470", VA = "0x1883E5C70")]
		private long CBLEWEXBRHC(Type a)
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
		[Cpp2IlInjected.Address(RVA = "0x83E6310", Offset = "0x83E4B10", VA = "0x1883E6310")]
		public PropertyBitmap(int count)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x83E6170", Offset = "0x83E4970", VA = "0x1883E6170")]
		public static PropertyBitmap TPIWQBYTAWH(int a, NativeArray<NetworkProperty> b)
		{
			return default(PropertyBitmap);
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x83E6300", Offset = "0x83E4B00", VA = "0x1883E6300")]
		public bool VJKBHEMINXT(int a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x83E6160", Offset = "0x83E4960", VA = "0x1883E6160")]
		public void Set(int index, bool value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x83E5FF0", Offset = "0x83E47F0", VA = "0x1883E5FF0")]
		public bool All(NetworkProperty[] properties)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x83E60A0", Offset = "0x83E48A0", VA = "0x1883E60A0")]
		public bool Any(NetworkProperty[] properties)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x83E6150", Offset = "0x83E4950", VA = "0x1883E6150", Slot = "4")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	internal class PropertyDrawerCandidates
	{
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private static readonly Log RKIUKOTABJV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private readonly SWDFGOAGXHK QDXWLUELGXZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private readonly List<XUGRFQWRVMO> JHPWRGVTWED;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private readonly PropertiesByType MJVIEYNILHZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private NativeParallelMultiHashMap<int, int> HFDYUZYKIDF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private NativeList<int> DMIOHTCWEVZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private bool VACBKMVGOGA;

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public List<XUGRFQWRVMO> OWOEXWEVNKL
		{
			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(RVA = "0xAA1610", Offset = "0xA9FE10", VA = "0x180AA1610")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x83E7520", Offset = "0x83E5D20", VA = "0x1883E7520")]
		public PropertyDrawerCandidates(SWDFGOAGXHK configPropertyService)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x83E6520", Offset = "0x83E4D20", VA = "0x1883E6520")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x83E7300", Offset = "0x83E5B00", VA = "0x1883E7300")]
		public void UYNPTRDUYIC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x83E6710", Offset = "0x83E4F10", VA = "0x1883E6710")]
		public NativeList<Candidate> HQPWTNSHWEL(NativeArray<NetworkProperty> a)
		{
			return default(NativeList<Candidate>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x83E6BE0", Offset = "0x83E53E0", VA = "0x1883E6BE0")]
		private bool HQRMKGIHUYB(XUGRFQWRVMO a, PropertyBitmap b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x3907800", Offset = "0x3906000", VA = "0x183907800")]
		private void FVKUUKHVIUM<b, a>(Action<b, a> a) where b : XUGRFQWRVMO where a : Attribute
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x83E72D0", Offset = "0x83E5AD0", VA = "0x1883E72D0")]
		private void MPPDFOHZSOK(Type a, Type b, Type c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x3907B10", Offset = "0x3906310", VA = "0x183907B10")]
		private c HVFHAPBVEUT<c>(Type a)
		{
			return (c)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x83E6430", Offset = "0x83E4C30", VA = "0x1883E6430")]
		private int DRPGCZFSFJM(XUGRFQWRVMO a, int b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x83E7050", Offset = "0x83E5850", VA = "0x1883E7050")]
		private void LXGADRFORSS(PRMLUTUQWHU a, ConfigPropertyDrawer b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x83E6D30", Offset = "0x83E5530", VA = "0x1883E6D30")]
		private void LVHEHAKOJTN(ZUNGZYNWFGH a, MatchPropertyDrawer b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x83E6600", Offset = "0x83E4E00", VA = "0x1883E6600")]
		private void GIJMSDXVZBJ(RWGFYDDLZCH a, MultiPropertyDrawer b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x83E6360", Offset = "0x83E4B60", VA = "0x1883E6360")]
		private void CNMXFYEXXMG(ZNZOYWNPNRE a, SpecificPropertyDrawer b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	internal struct PropertyShadowing : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private readonly List<XUGRFQWRVMO> drawers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private NativeList<Candidate> unshadowed;

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public NativeList<Candidate> PSVTANHRSRX
		{
			[Cpp2IlInjected.Token(Token = "0x60000A3")]
			[Cpp2IlInjected.Address(RVA = "0xC71A80", Offset = "0xC70280", VA = "0x180C71A80")]
			get
			{
				return default(NativeList<Candidate>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x83E7C40", Offset = "0x83E6440", VA = "0x1883E7C40")]
		public PropertyShadowing(List<XUGRFQWRVMO> drawers, NativeArray<Candidate> candidates)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x83E7660", Offset = "0x83E5E60", VA = "0x1883E7660", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x83E7940", Offset = "0x83E6140", VA = "0x1883E7940")]
		private NativeList<Candidate> TPQLPZRHCKJ(NativeArray<Candidate> a)
		{
			return default(NativeList<Candidate>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x83E76A0", Offset = "0x83E5EA0", VA = "0x1883E76A0")]
		private bool EETEOKDJAPQ(XUGRFQWRVMO a, PropertyBitmap b, NetworkProperty c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x83E7810", Offset = "0x83E6010", VA = "0x1883E7810")]
		private void PGQPOBHYYJH(XUGRFQWRVMO a, PropertyBitmap b, NetworkProperty c)
		{
		}
	}
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	internal struct SortCandidatesByPriority : IComparer<Candidate>
	{
		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x83E8810", Offset = "0x83E7010", VA = "0x1883E8810", Slot = "4")]
		public int Compare(Candidate a, Candidate b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x83E8820", Offset = "0x83E7020", VA = "0x1883E8820")]
		public static void Sort(NativeList<Candidate> candidates)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	[AttributeUsage(AttributeTargets.Class)]
	public class SpecificPropertyDrawer : ConfigPropertyDrawerBase
	{
		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x83E8860", Offset = "0x83E7060", VA = "0x1883E8860")]
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
