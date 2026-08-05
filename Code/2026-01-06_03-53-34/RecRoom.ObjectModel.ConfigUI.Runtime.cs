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
		[Cpp2IlInjected.Address(RVA = "0x84E7980", Offset = "0x84E6380", VA = "0x1884E7980", Slot = "4")]
		public override void JIBLBJTHOBM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xAE07F0", Offset = "0xADF1F0", VA = "0x180AE07F0")]
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
			[Cpp2IlInjected.Address(RVA = "0xAB85B0", Offset = "0xAB6FB0", VA = "0x180AB85B0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x84ED650", Offset = "0x84EC050", VA = "0x1884ED650", Slot = "5")]
		public override void SetServiceCategoryIndices(List<int> globalFromLocalIndices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x84ECCE0", Offset = "0x84EB6E0", VA = "0x1884ECCE0")]
		private void ANRTHLCVEKO(IServiceRegistration a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x84ECF00", Offset = "0x84EB900", VA = "0x1884ECF00", Slot = "6")]
		public override void RegisterServices(IServiceRegistration registry, [In] ServiceBitsetFilter filter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x84ECF60", Offset = "0x84EB960", VA = "0x1884ECF60", Slot = "7")]
		public override void RegisterTypes(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x84ED670", Offset = "0x84EC070", VA = "0x1884ED670")]
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
		[Cpp2IlInjected.Address(RVA = "0x84E7940", Offset = "0x84E6340", VA = "0x1884E7940")]
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
			[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
			public CGPLWVDWZDM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x3D4D8D0", Offset = "0x3D4C2D0", VA = "0x183D4D8D0")]
			internal bool GKAQHTOYQCZ()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x4E3C050", Offset = "0x4E3AA50", VA = "0x184E3C050")]
		protected GJGDCRADNUU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x4E3B810", Offset = "0x4E3A210", VA = "0x184E3B810")]
		protected void IHWVEWOLOQP(CSUJRKKPPCK a, YJVAKODYZZD b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x4E3BE40", Offset = "0x4E3A840", VA = "0x184E3BE40")]
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
		[Cpp2IlInjected.Address(RVA = "0x372A0F0", Offset = "0x3728AF0", VA = "0x18372A0F0")]
		protected static b WSFQZSWBYZH<b>(NativeObjectLocalIdArray a, NetworkProperty<b> b) where b : struct
		{
			return (b)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x3729F00", Offset = "0x3728900", VA = "0x183729F00")]
		protected static void GCAYKDOCZWY<d>(NativeObjectLocalIdArray a, NetworkProperty<d> b, d c) where d : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
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
			[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
			public CGPLWVDWZDM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x3D4D6A0", Offset = "0x3D4C0A0", VA = "0x183D4D6A0")]
			internal bool GKAQHTOYQCZ()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x4E3C050", Offset = "0x4E3AA50", VA = "0x184E3C050")]
		protected KBUDNADRCZH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x5289770", Offset = "0x5288170", VA = "0x185289770")]
		protected void IHWVEWOLOQP(CSUJRKKPPCK a, YJVAKODYZZD b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x528A3C0", Offset = "0x5288DC0", VA = "0x18528A3C0")]
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
			[Cpp2IlInjected.Address(RVA = "0x1457F70", Offset = "0x1456970", VA = "0x181457F70", Slot = "5")]
			get
			{
				return default(NativeObjectLocalIdArray);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x84E6510", Offset = "0x84E4F10", VA = "0x1884E6510", Slot = "6")]
		public void InitExternal(BDQJEHGTRBM services)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x84E61A0", Offset = "0x84E4BA0", VA = "0x1884E61A0", Slot = "7")]
		public void BTTVCOLODYQ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x84E68A0", Offset = "0x84E52A0", VA = "0x1884E68A0", Slot = "4")]
		public void SKLYAHNPKJV(NativeObjectLocalIdArray a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x84E6830", Offset = "0x84E5230", VA = "0x1884E6830")]
		private void MXSGUQLLHYB(NativeObjectLocalIdArray a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x84E6310", Offset = "0x84E4D10", VA = "0x1884E6310")]
		private void EILYSZPRDQW()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x84E6D10", Offset = "0x84E5710", VA = "0x1884E6D10")]
		private void THPRDRPBRTH(Candidate a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x84E62A0", Offset = "0x84E4CA0", VA = "0x1884E62A0", Slot = "8")]
		private void EFSYMFFESBS(BDQJEHGTRBM a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0xD5FF40", Offset = "0xD5E940", VA = "0x180D5FF40", Slot = "9")]
		private void MIIBQCGEILO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x84E70D0", Offset = "0x84E5AD0", VA = "0x1884E70D0")]
		public ConfigUIService()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[MatchPropertyDrawer(0)]
	internal class QUQEHRJBFPY : MKZEAYEOSOC
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x84EBBB0", Offset = "0x84EA5B0", VA = "0x1884EBBB0", Slot = "5")]
		public override void THPRDRPBRTH(YJVAKODYZZD a, QJXNCQOTCYD b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x84EBB10", Offset = "0x84EA510", VA = "0x1884EBB10", Slot = "7")]
		public override bool RFPAVOIQIBO(Type a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x84E7940", Offset = "0x84E6340", VA = "0x1884E7940")]
		public QUQEHRJBFPY()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[MatchPropertyDrawer(0)]
	internal class JQWFJJJCCTF : MKZEAYEOSOC
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x84E7890", Offset = "0x84E6290", VA = "0x1884E7890", Slot = "5")]
		public override void THPRDRPBRTH(YJVAKODYZZD a, QJXNCQOTCYD b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x84E77F0", Offset = "0x84E61F0", VA = "0x1884E77F0", Slot = "7")]
		public override bool RFPAVOIQIBO(Type a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x84E7940", Offset = "0x84E6340", VA = "0x1884E7940")]
		public JQWFJJJCCTF()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[ConfigPropertyDrawer(typeof(RenderableColor), 1)]
	internal class BEOCAMPKXBA : GJGDCRADNUU<RenderableColor>
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x84E5160", Offset = "0x84E3B60", VA = "0x1884E5160", Slot = "5")]
		public override void THPRDRPBRTH(YJVAKODYZZD a, QJXNCQOTCYD b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x84E52B0", Offset = "0x84E3CB0", VA = "0x1884E52B0")]
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
			[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
			public PBZSWMUOFRV()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x84E8E70", Offset = "0x84E7870", VA = "0x1884E8E70")]
			internal (int, int) NEFTUSTAFBR()
			{
				return default((int, int));
			}

			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x84E8D30", Offset = "0x84E7730", VA = "0x1884E8D30")]
			internal void NEAMXLZCVQI((int color, int material) value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public override NetworkProperty[] KSBZJLLZMPC
		{
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0xAB8A50", Offset = "0xAB7450", VA = "0x180AB8A50", Slot = "7")]
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
			[Cpp2IlInjected.Address(RVA = "0xAB85D0", Offset = "0xAB6FD0", VA = "0x180AB85D0", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x84EC310", Offset = "0x84EAD10", VA = "0x1884EC310", Slot = "9")]
		public override void THPRDRPBRTH(YJVAKODYZZD a, ZVZULZESFLY b, SWDFGOAGXHK c, QJXNCQOTCYD d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x84EC6C0", Offset = "0x84EB0C0", VA = "0x1884EC6C0")]
		public VFVWZODFTBA()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[ConfigPropertyDrawer(typeof(bool))]
	internal class TPKKKEBLJVJ : KBUDNADRCZH<bool>
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x84EBD90", Offset = "0x84EA790", VA = "0x1884EBD90", Slot = "5")]
		public override void THPRDRPBRTH(YJVAKODYZZD a, QJXNCQOTCYD b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x84EBE20", Offset = "0x84EA820", VA = "0x1884EBE20")]
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
			[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
			public QFMADIQWEXT()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x84EB870", Offset = "0x84EA270", VA = "0x1884EB870")]
			internal string NEFTUSTAFBR()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x84EB730", Offset = "0x84EA130", VA = "0x1884EB730")]
			internal void NEAMXLZCVQI(string a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x84E7A80", Offset = "0x84E6480", VA = "0x1884E7A80", Slot = "5")]
		public override void THPRDRPBRTH(YJVAKODYZZD a, QJXNCQOTCYD b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x84E7C10", Offset = "0x84E6610", VA = "0x1884E7C10")]
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
			[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
			public QFMADIQWEXT()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x84EB7F0", Offset = "0x84EA1F0", VA = "0x1884EB7F0")]
			internal string NEFTUSTAFBR()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x84EB680", Offset = "0x84EA080", VA = "0x1884EB680")]
			internal void NEAMXLZCVQI(string a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x84E7450", Offset = "0x84E5E50", VA = "0x1884E7450", Slot = "5")]
		public override void THPRDRPBRTH(YJVAKODYZZD a, QJXNCQOTCYD b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x84E75E0", Offset = "0x84E5FE0", VA = "0x1884E75E0")]
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
			[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
			public QFMADIQWEXT()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x84EB910", Offset = "0x84EA310", VA = "0x1884EB910")]
			internal float NEFTUSTAFBR()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x84EB720", Offset = "0x84EA120", VA = "0x1884EB720")]
			internal void NEAMXLZCVQI(float a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x84EB9C0", Offset = "0x84EA3C0", VA = "0x1884EB9C0")]
			internal float NEQHPGGUXYJ()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x84EB9A0", Offset = "0x84EA3A0", VA = "0x1884EB9A0")]
			internal void NELARZMXONA(float a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x84EB610", Offset = "0x84EA010", VA = "0x1884EB610")]
			internal float NDKSFRRKTIH()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x84EB5F0", Offset = "0x84E9FF0", VA = "0x1884EB5F0")]
			internal void NDFLIKXNJWY(float a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x84EB310", Offset = "0x84E9D10", VA = "0x1884EB310")]
			internal float AUTGYUOHUYU(int a)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x84EBA30", Offset = "0x84EA430", VA = "0x1884EBA30")]
			internal void XEDTWAVUHNN(int a, float b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x84E83E0", Offset = "0x84E6DE0", VA = "0x1884E83E0", Slot = "5")]
		public override void THPRDRPBRTH(YJVAKODYZZD a, QJXNCQOTCYD b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x84E87E0", Offset = "0x84E71E0", VA = "0x1884E87E0")]
		public NTCBVOJPDNC()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[ConfigPropertyDrawer(typeof(float))]
	internal class SMHXUMDSMYH : KBUDNADRCZH<float>
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x84EBC60", Offset = "0x84EA660", VA = "0x1884EBC60", Slot = "5")]
		public override void THPRDRPBRTH(YJVAKODYZZD a, QJXNCQOTCYD b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x84EBCF0", Offset = "0x84EA6F0", VA = "0x1884EBCF0")]
		public SMHXUMDSMYH()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[ConfigPropertyDrawer(typeof(int))]
	internal class DVCXJJLMXKI : KBUDNADRCZH<int>
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x84E7150", Offset = "0x84E5B50", VA = "0x1884E7150", Slot = "5")]
		public override void THPRDRPBRTH(YJVAKODYZZD a, QJXNCQOTCYD b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x84E71E0", Offset = "0x84E5BE0", VA = "0x1884E71E0")]
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
			[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
			public QFMADIQWEXT()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x84EB980", Offset = "0x84EA380", VA = "0x1884EB980")]
			internal float NEFTUSTAFBR()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x84EB710", Offset = "0x84EA110", VA = "0x1884EB710")]
			internal void NEAMXLZCVQI(float a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x84EB9B0", Offset = "0x84EA3B0", VA = "0x1884EB9B0")]
			internal float NEQHPGGUXYJ()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x84EB990", Offset = "0x84EA390", VA = "0x1884EB990")]
			internal void NELARZMXONA(float a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x84EB600", Offset = "0x84EA000", VA = "0x1884EB600")]
			internal float NDKSFRRKTIH()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x84EB5E0", Offset = "0x84E9FE0", VA = "0x1884EB5E0")]
			internal void NDFLIKXNJWY(float a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x84EB1B0", Offset = "0x84E9BB0", VA = "0x1884EB1B0")]
			internal float APHIKKNVOER(int a)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x84EB380", Offset = "0x84E9D80", VA = "0x1884EB380")]
			internal void LZASJANLAFA(int a, float b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x84EC7E0", Offset = "0x84EB1E0", VA = "0x1884EC7E0", Slot = "5")]
		public override void THPRDRPBRTH(YJVAKODYZZD a, QJXNCQOTCYD b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x84ECBE0", Offset = "0x84EB5E0", VA = "0x1884ECBE0")]
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
			[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
			public QFMADIQWEXT()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x84EB8D0", Offset = "0x84EA2D0", VA = "0x1884EB8D0")]
			internal int NEFTUSTAFBR()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x84EB7A0", Offset = "0x84EA1A0", VA = "0x1884EB7A0")]
			internal void NEAMXLZCVQI(int a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x84E7620", Offset = "0x84E6020", VA = "0x1884E7620", Slot = "5")]
		public override void THPRDRPBRTH(YJVAKODYZZD a, QJXNCQOTCYD b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x84E77B0", Offset = "0x84E61B0", VA = "0x1884E77B0")]
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
		[Cpp2IlInjected.Address(RVA = "0x84ECC20", Offset = "0x84EB620", VA = "0x1884ECC20")]
		public static void AEZOSXYBOGY(Type a, Type b)
		{
		}
	}
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	internal struct CommonProperties
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x84E5E30", Offset = "0x84E4830", VA = "0x1884E5E30")]
		public static NativeList<NetworkProperty> MWAJSUCANPZ(NativeObjectLocalIdArray a, SWDFGOAGXHK b)
		{
			return default(NativeList<NetworkProperty>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x84E60B0", Offset = "0x84E4AB0", VA = "0x1884E60B0")]
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
			[Cpp2IlInjected.Address(RVA = "0x84E7C50", Offset = "0x84E6650", VA = "0x1884E7C50", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public bool MVQOJPYSRSA
		{
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x84E7D00", Offset = "0x84E6700", VA = "0x1884E7D00", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public RRObject ZQWCMTTOUIE
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x84E7FD0", Offset = "0x84E69D0", VA = "0x1884E7FD0", Slot = "8")]
			get
			{
				return default(RRObject);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public Type BFJYMHQJKIL
		{
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x84E7CB0", Offset = "0x84E66B0", VA = "0x1884E7CB0", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action JVBKRTKHQOF
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x84E8250", Offset = "0x84E6C50", VA = "0x1884E8250", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x84E7D80", Offset = "0x84E6780", VA = "0x1884E7D80", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x84E82F0", Offset = "0x84E6CF0", VA = "0x1884E82F0")]
		public NMLPREXENVG(NativeObjectLocalIdArray a, NetworkProperty b, SWDFGOAGXHK c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x84E8140", Offset = "0x84E6B40", VA = "0x1884E8140")]
		private void WKTCODEYBUO(BulkPropertyChangeData a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x84E7EF0", Offset = "0x84E68F0", VA = "0x1884E7EF0", Slot = "10")]
		public void Get(MutableRef value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x84E8020", Offset = "0x84E6A20", VA = "0x1884E8020", Slot = "11")]
		public void Set(ReadOnlyRef value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x84E7E20", Offset = "0x84E6820", VA = "0x1884E7E20", Slot = "12")]
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
			[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
			public GZWDQNLWZKX()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0x84E72A0", Offset = "0x84E5CA0", VA = "0x1884E72A0")]
			internal bool NEFTUSTAFBR()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0x84E7220", Offset = "0x84E5C20", VA = "0x1884E7220")]
			internal string NEAMXLZCVQI()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0x84E73C0", Offset = "0x84E5DC0", VA = "0x1884E73C0")]
			internal void NEQHPGGUXYJ(string a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0x84E72F0", Offset = "0x84E5CF0", VA = "0x1884E72F0")]
			internal string NELARZMXONA()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public NetworkProperty PPRLZTXFBIO
		{
			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x84EC2A0", Offset = "0x84EACA0", VA = "0x1884EC2A0", Slot = "4")]
			get
			{
				return default(NetworkProperty);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x84EBE60", Offset = "0x84EA860", VA = "0x1884EBE60", Slot = "5")]
		public void THPRDRPBRTH(YJVAKODYZZD a, QJXNCQOTCYD b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x84E5D20", Offset = "0x84E4720", VA = "0x1884E5D20")]
		public BVARXDJOILP(SWDFGOAGXHK a, QJXNCQOTCYD b, Action<Candidate> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x84E59E0", Offset = "0x84E43E0", VA = "0x1884E59E0")]
		public void HBVPXEVOJIP(NativeList<Candidate> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x84E5860", Offset = "0x84E4260", VA = "0x1884E5860")]
		private void FDIUBULSSCZ(AUXLFWFIQJL a, Candidate b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x84E5390", Offset = "0x84E3D90", VA = "0x1884E5390")]
		public void CQGULTQWVVP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x84E53F0", Offset = "0x84E3DF0", VA = "0x1884E53F0")]
		private void FCGSWIOUMND(AUXLFWFIQJL a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x84E52F0", Offset = "0x84E3CF0", VA = "0x1884E52F0")]
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
				[Cpp2IlInjected.Address(RVA = "0xB5B940", Offset = "0xB5A340", VA = "0x180B5B940", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0x84E8B10", Offset = "0x84E7510", VA = "0x1884E8B10", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0x12DCEB0", Offset = "0x12DB8B0", VA = "0x1812DCEB0")]
			[DebuggerHidden]
			public PBCPPICRIDK(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x84E8B60", Offset = "0x84E7560", VA = "0x1884E8B60", Slot = "7")]
			[DebuggerHidden]
			private void QBKHVLXPXWS()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0x84E8820", Offset = "0x84E7220", VA = "0x1884E8820", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0x84E8BF0", Offset = "0x84E75F0", VA = "0x1884E8BF0")]
			private void SNXRWXESNLS()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0x84E8C40", Offset = "0x84E7640", VA = "0x1884E8C40", Slot = "10")]
			[DebuggerHidden]
			private void VXYFNEQVOKT()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008B")]
			[Cpp2IlInjected.Address(RVA = "0x84E8C80", Offset = "0x84E7680", VA = "0x1884E8C80", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<NetworkProperty> YUJQIWMBCVC()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x84E8C80", Offset = "0x84E7680", VA = "0x1884E8C80", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x84E9300", Offset = "0x84E7D00", VA = "0x1884E9300")]
		public PropertiesByType()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x84E91F0", Offset = "0x84E7BF0", VA = "0x1884E91F0")]
		[IteratorStateMachine(typeof(PBCPPICRIDK))]
		public IEnumerable<NetworkProperty> EEKMDVLAONT(Type a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x84E91B0", Offset = "0x84E7BB0", VA = "0x1884E91B0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x84E90F0", Offset = "0x84E7AF0", VA = "0x1884E90F0")]
		private long CBLEWEXBRHC(NetworkProperty a)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x84E9170", Offset = "0x84E7B70", VA = "0x1884E9170")]
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
		[Cpp2IlInjected.Address(RVA = "0x84E9810", Offset = "0x84E8210", VA = "0x1884E9810")]
		public PropertyBitmap(int count)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x84E9670", Offset = "0x84E8070", VA = "0x1884E9670")]
		public static PropertyBitmap TPIWQBYTAWH(int a, NativeArray<NetworkProperty> b)
		{
			return default(PropertyBitmap);
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x84E9800", Offset = "0x84E8200", VA = "0x1884E9800")]
		public bool VJKBHEMINXT(int a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x84E9660", Offset = "0x84E8060", VA = "0x1884E9660")]
		public void Set(int index, bool value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x84E94F0", Offset = "0x84E7EF0", VA = "0x1884E94F0")]
		public bool All(NetworkProperty[] properties)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x84E95A0", Offset = "0x84E7FA0", VA = "0x1884E95A0")]
		public bool Any(NetworkProperty[] properties)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x84E9650", Offset = "0x84E8050", VA = "0x1884E9650", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0xAB85D0", Offset = "0xAB6FD0", VA = "0x180AB85D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x84EAA40", Offset = "0x84E9440", VA = "0x1884EAA40")]
		public PropertyDrawerCandidates(SWDFGOAGXHK configPropertyService)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x84E9A20", Offset = "0x84E8420", VA = "0x1884E9A20")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x84EA820", Offset = "0x84E9220", VA = "0x1884EA820")]
		public void UYNPTRDUYIC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x84E9C10", Offset = "0x84E8610", VA = "0x1884E9C10")]
		public NativeList<Candidate> HQPWTNSHWEL(NativeArray<NetworkProperty> a)
		{
			return default(NativeList<Candidate>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x84EA0E0", Offset = "0x84E8AE0", VA = "0x1884EA0E0")]
		private bool HQRMKGIHUYB(XUGRFQWRVMO a, PropertyBitmap b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x3923640", Offset = "0x3922040", VA = "0x183923640")]
		private void FVKUUKHVIUM<b, a>(Action<b, a> a) where b : XUGRFQWRVMO where a : Attribute
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x84EA7F0", Offset = "0x84E91F0", VA = "0x1884EA7F0")]
		private void MPPDFOHZSOK(Type a, Type b, Type c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x3923950", Offset = "0x3922350", VA = "0x183923950")]
		private c HVFHAPBVEUT<c>(Type a)
		{
			return (c)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x84E9930", Offset = "0x84E8330", VA = "0x1884E9930")]
		private int DRPGCZFSFJM(XUGRFQWRVMO a, int b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x84EA560", Offset = "0x84E8F60", VA = "0x1884EA560")]
		private void LXGADRFORSS(PRMLUTUQWHU a, ConfigPropertyDrawer b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x84EA230", Offset = "0x84E8C30", VA = "0x1884EA230")]
		private void LVHEHAKOJTN(ZUNGZYNWFGH a, MatchPropertyDrawer b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x84E9B00", Offset = "0x84E8500", VA = "0x1884E9B00")]
		private void GIJMSDXVZBJ(RWGFYDDLZCH a, MultiPropertyDrawer b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x84E9860", Offset = "0x84E8260", VA = "0x1884E9860")]
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
			[Cpp2IlInjected.Address(RVA = "0xC88E70", Offset = "0xC87870", VA = "0x180C88E70")]
			get
			{
				return default(NativeList<Candidate>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x84EB160", Offset = "0x84E9B60", VA = "0x1884EB160")]
		public PropertyShadowing(List<XUGRFQWRVMO> drawers, NativeArray<Candidate> candidates)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x84EAB80", Offset = "0x84E9580", VA = "0x1884EAB80", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x84EAE60", Offset = "0x84E9860", VA = "0x1884EAE60")]
		private NativeList<Candidate> TPQLPZRHCKJ(NativeArray<Candidate> a)
		{
			return default(NativeList<Candidate>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x84EABC0", Offset = "0x84E95C0", VA = "0x1884EABC0")]
		private bool EETEOKDJAPQ(XUGRFQWRVMO a, PropertyBitmap b, NetworkProperty c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x84EAD30", Offset = "0x84E9730", VA = "0x1884EAD30")]
		private void PGQPOBHYYJH(XUGRFQWRVMO a, PropertyBitmap b, NetworkProperty c)
		{
		}
	}
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	internal struct SortCandidatesByPriority : IComparer<Candidate>
	{
		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x84EBD30", Offset = "0x84EA730", VA = "0x1884EBD30", Slot = "4")]
		public int Compare(Candidate a, Candidate b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x84EBD40", Offset = "0x84EA740", VA = "0x1884EBD40")]
		public static void Sort(NativeList<Candidate> candidates)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	[AttributeUsage(AttributeTargets.Class)]
	public class SpecificPropertyDrawer : ConfigPropertyDrawerBase
	{
		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x84EBD80", Offset = "0x84EA780", VA = "0x1884EBD80")]
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
